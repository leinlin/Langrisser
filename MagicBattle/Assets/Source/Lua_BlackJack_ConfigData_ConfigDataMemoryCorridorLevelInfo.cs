using System;
using System.Runtime.CompilerServices;
using BlackJack.ConfigData;
using SLua;
using UnityEngine.Scripting;

// Token: 0x02001160 RID: 4448
[Preserve]
public class Lua_BlackJack_ConfigData_ConfigDataMemoryCorridorLevelInfo : LuaObject
{
	// Token: 0x06016AF8 RID: 92920 RVA: 0x0060AAF4 File Offset: 0x00608CF4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int constructor(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataMemoryCorridorLevelInfo o = new ConfigDataMemoryCorridorLevelInfo();
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

	// Token: 0x06016AF9 RID: 92921 RVA: 0x0060AB3C File Offset: 0x00608D3C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_battleInfo(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataMemoryCorridorLevelInfo configDataMemoryCorridorLevelInfo = (ConfigDataMemoryCorridorLevelInfo)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, configDataMemoryCorridorLevelInfo.m_battleInfo);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06016AFA RID: 92922 RVA: 0x0060AB90 File Offset: 0x00608D90
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_m_battleInfo(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataMemoryCorridorLevelInfo configDataMemoryCorridorLevelInfo = (ConfigDataMemoryCorridorLevelInfo)LuaObject.checkSelf(l);
			ConfigDataBattleInfo battleInfo;
			LuaObject.checkType<ConfigDataBattleInfo>(l, 2, out battleInfo);
			configDataMemoryCorridorLevelInfo.m_battleInfo = battleInfo;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06016AFB RID: 92923 RVA: 0x0060ABE8 File Offset: 0x00608DE8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_groupInfo(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataMemoryCorridorLevelInfo configDataMemoryCorridorLevelInfo = (ConfigDataMemoryCorridorLevelInfo)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, configDataMemoryCorridorLevelInfo.m_groupInfo);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06016AFC RID: 92924 RVA: 0x0060AC3C File Offset: 0x00608E3C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_groupInfo(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataMemoryCorridorLevelInfo configDataMemoryCorridorLevelInfo = (ConfigDataMemoryCorridorLevelInfo)LuaObject.checkSelf(l);
			ConfigDataMemoryCorridorInfo groupInfo;
			LuaObject.checkType<ConfigDataMemoryCorridorInfo>(l, 2, out groupInfo);
			configDataMemoryCorridorLevelInfo.m_groupInfo = groupInfo;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06016AFD RID: 92925 RVA: 0x0060AC94 File Offset: 0x00608E94
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_m_randomDropInfo(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataMemoryCorridorLevelInfo configDataMemoryCorridorLevelInfo = (ConfigDataMemoryCorridorLevelInfo)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, configDataMemoryCorridorLevelInfo.m_randomDropInfo);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06016AFE RID: 92926 RVA: 0x0060ACE8 File Offset: 0x00608EE8
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_m_randomDropInfo(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataMemoryCorridorLevelInfo configDataMemoryCorridorLevelInfo = (ConfigDataMemoryCorridorLevelInfo)LuaObject.checkSelf(l);
			ConfigDataRandomDropRewardInfo randomDropInfo;
			LuaObject.checkType<ConfigDataRandomDropRewardInfo>(l, 2, out randomDropInfo);
			configDataMemoryCorridorLevelInfo.m_randomDropInfo = randomDropInfo;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06016AFF RID: 92927 RVA: 0x0060AD40 File Offset: 0x00608F40
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_m_activityRandomDropInfo(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataMemoryCorridorLevelInfo configDataMemoryCorridorLevelInfo = (ConfigDataMemoryCorridorLevelInfo)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, configDataMemoryCorridorLevelInfo.m_activityRandomDropInfo);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06016B00 RID: 92928 RVA: 0x0060AD94 File Offset: 0x00608F94
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_m_activityRandomDropInfo(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataMemoryCorridorLevelInfo configDataMemoryCorridorLevelInfo = (ConfigDataMemoryCorridorLevelInfo)LuaObject.checkSelf(l);
			ConfigDataRandomDropRewardInfo activityRandomDropInfo;
			LuaObject.checkType<ConfigDataRandomDropRewardInfo>(l, 2, out activityRandomDropInfo);
			configDataMemoryCorridorLevelInfo.m_activityRandomDropInfo = activityRandomDropInfo;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06016B01 RID: 92929 RVA: 0x0060ADEC File Offset: 0x00608FEC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_ID(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataMemoryCorridorLevelInfo configDataMemoryCorridorLevelInfo = (ConfigDataMemoryCorridorLevelInfo)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, configDataMemoryCorridorLevelInfo.ID);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06016B02 RID: 92930 RVA: 0x0060AE40 File Offset: 0x00609040
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_ID(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataMemoryCorridorLevelInfo configDataMemoryCorridorLevelInfo = (ConfigDataMemoryCorridorLevelInfo)LuaObject.checkSelf(l);
			int id;
			LuaObject.checkType(l, 2, out id);
			configDataMemoryCorridorLevelInfo.ID = id;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06016B03 RID: 92931 RVA: 0x0060AE98 File Offset: 0x00609098
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_Name(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataMemoryCorridorLevelInfo configDataMemoryCorridorLevelInfo = (ConfigDataMemoryCorridorLevelInfo)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, configDataMemoryCorridorLevelInfo.Name);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06016B04 RID: 92932 RVA: 0x0060AEEC File Offset: 0x006090EC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_Name(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataMemoryCorridorLevelInfo configDataMemoryCorridorLevelInfo = (ConfigDataMemoryCorridorLevelInfo)LuaObject.checkSelf(l);
			string name;
			LuaObject.checkType(l, 2, out name);
			configDataMemoryCorridorLevelInfo.Name = name;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06016B05 RID: 92933 RVA: 0x0060AF44 File Offset: 0x00609144
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_TeamName(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataMemoryCorridorLevelInfo configDataMemoryCorridorLevelInfo = (ConfigDataMemoryCorridorLevelInfo)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, configDataMemoryCorridorLevelInfo.TeamName);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06016B06 RID: 92934 RVA: 0x0060AF98 File Offset: 0x00609198
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_TeamName(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataMemoryCorridorLevelInfo configDataMemoryCorridorLevelInfo = (ConfigDataMemoryCorridorLevelInfo)LuaObject.checkSelf(l);
			string teamName;
			LuaObject.checkType(l, 2, out teamName);
			configDataMemoryCorridorLevelInfo.TeamName = teamName;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06016B07 RID: 92935 RVA: 0x0060AFF0 File Offset: 0x006091F0
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_OpenPlayerLevel(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataMemoryCorridorLevelInfo configDataMemoryCorridorLevelInfo = (ConfigDataMemoryCorridorLevelInfo)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, configDataMemoryCorridorLevelInfo.OpenPlayerLevel);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06016B08 RID: 92936 RVA: 0x0060B044 File Offset: 0x00609244
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_OpenPlayerLevel(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataMemoryCorridorLevelInfo configDataMemoryCorridorLevelInfo = (ConfigDataMemoryCorridorLevelInfo)LuaObject.checkSelf(l);
			int openPlayerLevel;
			LuaObject.checkType(l, 2, out openPlayerLevel);
			configDataMemoryCorridorLevelInfo.OpenPlayerLevel = openPlayerLevel;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06016B09 RID: 92937 RVA: 0x0060B09C File Offset: 0x0060929C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_TicketCost(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataMemoryCorridorLevelInfo configDataMemoryCorridorLevelInfo = (ConfigDataMemoryCorridorLevelInfo)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, configDataMemoryCorridorLevelInfo.TicketCost);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06016B0A RID: 92938 RVA: 0x0060B0F0 File Offset: 0x006092F0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_TicketCost(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataMemoryCorridorLevelInfo configDataMemoryCorridorLevelInfo = (ConfigDataMemoryCorridorLevelInfo)LuaObject.checkSelf(l);
			int ticketCost;
			LuaObject.checkType(l, 2, out ticketCost);
			configDataMemoryCorridorLevelInfo.TicketCost = ticketCost;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06016B0B RID: 92939 RVA: 0x0060B148 File Offset: 0x00609348
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_EnergySuccess(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataMemoryCorridorLevelInfo configDataMemoryCorridorLevelInfo = (ConfigDataMemoryCorridorLevelInfo)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, configDataMemoryCorridorLevelInfo.EnergySuccess);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06016B0C RID: 92940 RVA: 0x0060B19C File Offset: 0x0060939C
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_EnergySuccess(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataMemoryCorridorLevelInfo configDataMemoryCorridorLevelInfo = (ConfigDataMemoryCorridorLevelInfo)LuaObject.checkSelf(l);
			int energySuccess;
			LuaObject.checkType(l, 2, out energySuccess);
			configDataMemoryCorridorLevelInfo.EnergySuccess = energySuccess;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06016B0D RID: 92941 RVA: 0x0060B1F4 File Offset: 0x006093F4
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_EnergyFail(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataMemoryCorridorLevelInfo configDataMemoryCorridorLevelInfo = (ConfigDataMemoryCorridorLevelInfo)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, configDataMemoryCorridorLevelInfo.EnergyFail);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06016B0E RID: 92942 RVA: 0x0060B248 File Offset: 0x00609448
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_EnergyFail(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataMemoryCorridorLevelInfo configDataMemoryCorridorLevelInfo = (ConfigDataMemoryCorridorLevelInfo)LuaObject.checkSelf(l);
			int energyFail;
			LuaObject.checkType(l, 2, out energyFail);
			configDataMemoryCorridorLevelInfo.EnergyFail = energyFail;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06016B0F RID: 92943 RVA: 0x0060B2A0 File Offset: 0x006094A0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_TeamEnergyCost(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataMemoryCorridorLevelInfo configDataMemoryCorridorLevelInfo = (ConfigDataMemoryCorridorLevelInfo)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, configDataMemoryCorridorLevelInfo.TeamEnergyCost);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06016B10 RID: 92944 RVA: 0x0060B2F4 File Offset: 0x006094F4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_TeamEnergyCost(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataMemoryCorridorLevelInfo configDataMemoryCorridorLevelInfo = (ConfigDataMemoryCorridorLevelInfo)LuaObject.checkSelf(l);
			int teamEnergyCost;
			LuaObject.checkType(l, 2, out teamEnergyCost);
			configDataMemoryCorridorLevelInfo.TeamEnergyCost = teamEnergyCost;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06016B11 RID: 92945 RVA: 0x0060B34C File Offset: 0x0060954C
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_MonsterLevel(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataMemoryCorridorLevelInfo configDataMemoryCorridorLevelInfo = (ConfigDataMemoryCorridorLevelInfo)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, configDataMemoryCorridorLevelInfo.MonsterLevel);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06016B12 RID: 92946 RVA: 0x0060B3A0 File Offset: 0x006095A0
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_MonsterLevel(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataMemoryCorridorLevelInfo configDataMemoryCorridorLevelInfo = (ConfigDataMemoryCorridorLevelInfo)LuaObject.checkSelf(l);
			int monsterLevel;
			LuaObject.checkType(l, 2, out monsterLevel);
			configDataMemoryCorridorLevelInfo.MonsterLevel = monsterLevel;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06016B13 RID: 92947 RVA: 0x0060B3F8 File Offset: 0x006095F8
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_Battle_ID(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataMemoryCorridorLevelInfo configDataMemoryCorridorLevelInfo = (ConfigDataMemoryCorridorLevelInfo)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, configDataMemoryCorridorLevelInfo.Battle_ID);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06016B14 RID: 92948 RVA: 0x0060B44C File Offset: 0x0060964C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_Battle_ID(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataMemoryCorridorLevelInfo configDataMemoryCorridorLevelInfo = (ConfigDataMemoryCorridorLevelInfo)LuaObject.checkSelf(l);
			int battle_ID;
			LuaObject.checkType(l, 2, out battle_ID);
			configDataMemoryCorridorLevelInfo.Battle_ID = battle_ID;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06016B15 RID: 92949 RVA: 0x0060B4A4 File Offset: 0x006096A4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_PlayerExp(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataMemoryCorridorLevelInfo configDataMemoryCorridorLevelInfo = (ConfigDataMemoryCorridorLevelInfo)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, configDataMemoryCorridorLevelInfo.PlayerExp);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06016B16 RID: 92950 RVA: 0x0060B4F8 File Offset: 0x006096F8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_PlayerExp(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataMemoryCorridorLevelInfo configDataMemoryCorridorLevelInfo = (ConfigDataMemoryCorridorLevelInfo)LuaObject.checkSelf(l);
			int playerExp;
			LuaObject.checkType(l, 2, out playerExp);
			configDataMemoryCorridorLevelInfo.PlayerExp = playerExp;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06016B17 RID: 92951 RVA: 0x0060B550 File Offset: 0x00609750
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_HeroExp(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataMemoryCorridorLevelInfo configDataMemoryCorridorLevelInfo = (ConfigDataMemoryCorridorLevelInfo)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, configDataMemoryCorridorLevelInfo.HeroExp);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06016B18 RID: 92952 RVA: 0x0060B5A4 File Offset: 0x006097A4
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_HeroExp(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataMemoryCorridorLevelInfo configDataMemoryCorridorLevelInfo = (ConfigDataMemoryCorridorLevelInfo)LuaObject.checkSelf(l);
			int heroExp;
			LuaObject.checkType(l, 2, out heroExp);
			configDataMemoryCorridorLevelInfo.HeroExp = heroExp;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06016B19 RID: 92953 RVA: 0x0060B5FC File Offset: 0x006097FC
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_Gold(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataMemoryCorridorLevelInfo configDataMemoryCorridorLevelInfo = (ConfigDataMemoryCorridorLevelInfo)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, configDataMemoryCorridorLevelInfo.Gold);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06016B1A RID: 92954 RVA: 0x0060B650 File Offset: 0x00609850
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_Gold(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataMemoryCorridorLevelInfo configDataMemoryCorridorLevelInfo = (ConfigDataMemoryCorridorLevelInfo)LuaObject.checkSelf(l);
			int gold;
			LuaObject.checkType(l, 2, out gold);
			configDataMemoryCorridorLevelInfo.Gold = gold;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06016B1B RID: 92955 RVA: 0x0060B6A8 File Offset: 0x006098A8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_Drop_ID(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataMemoryCorridorLevelInfo configDataMemoryCorridorLevelInfo = (ConfigDataMemoryCorridorLevelInfo)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, configDataMemoryCorridorLevelInfo.Drop_ID);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06016B1C RID: 92956 RVA: 0x0060B6FC File Offset: 0x006098FC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_Drop_ID(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataMemoryCorridorLevelInfo configDataMemoryCorridorLevelInfo = (ConfigDataMemoryCorridorLevelInfo)LuaObject.checkSelf(l);
			int drop_ID;
			LuaObject.checkType(l, 2, out drop_ID);
			configDataMemoryCorridorLevelInfo.Drop_ID = drop_ID;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06016B1D RID: 92957 RVA: 0x0060B754 File Offset: 0x00609954
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_TeamDrop_ID(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataMemoryCorridorLevelInfo configDataMemoryCorridorLevelInfo = (ConfigDataMemoryCorridorLevelInfo)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, configDataMemoryCorridorLevelInfo.TeamDrop_ID);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06016B1E RID: 92958 RVA: 0x0060B7A8 File Offset: 0x006099A8
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_TeamDrop_ID(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataMemoryCorridorLevelInfo configDataMemoryCorridorLevelInfo = (ConfigDataMemoryCorridorLevelInfo)LuaObject.checkSelf(l);
			int teamDrop_ID;
			LuaObject.checkType(l, 2, out teamDrop_ID);
			configDataMemoryCorridorLevelInfo.TeamDrop_ID = teamDrop_ID;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06016B1F RID: 92959 RVA: 0x0060B800 File Offset: 0x00609A00
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_OperationalActivityDrop_ID(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataMemoryCorridorLevelInfo configDataMemoryCorridorLevelInfo = (ConfigDataMemoryCorridorLevelInfo)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, configDataMemoryCorridorLevelInfo.OperationalActivityDrop_ID);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06016B20 RID: 92960 RVA: 0x0060B854 File Offset: 0x00609A54
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_OperationalActivityDrop_ID(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataMemoryCorridorLevelInfo configDataMemoryCorridorLevelInfo = (ConfigDataMemoryCorridorLevelInfo)LuaObject.checkSelf(l);
			int operationalActivityDrop_ID;
			LuaObject.checkType(l, 2, out operationalActivityDrop_ID);
			configDataMemoryCorridorLevelInfo.OperationalActivityDrop_ID = operationalActivityDrop_ID;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06016B21 RID: 92961 RVA: 0x0060B8AC File Offset: 0x00609AAC
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_DayBonusDrop_ID(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataMemoryCorridorLevelInfo configDataMemoryCorridorLevelInfo = (ConfigDataMemoryCorridorLevelInfo)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, configDataMemoryCorridorLevelInfo.DayBonusDrop_ID);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06016B22 RID: 92962 RVA: 0x0060B900 File Offset: 0x00609B00
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_DayBonusDrop_ID(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataMemoryCorridorLevelInfo configDataMemoryCorridorLevelInfo = (ConfigDataMemoryCorridorLevelInfo)LuaObject.checkSelf(l);
			int dayBonusDrop_ID;
			LuaObject.checkType(l, 2, out dayBonusDrop_ID);
			configDataMemoryCorridorLevelInfo.DayBonusDrop_ID = dayBonusDrop_ID;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06016B23 RID: 92963 RVA: 0x0060B958 File Offset: 0x00609B58
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_DisplayRewardCount(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataMemoryCorridorLevelInfo configDataMemoryCorridorLevelInfo = (ConfigDataMemoryCorridorLevelInfo)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, configDataMemoryCorridorLevelInfo.DisplayRewardCount);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06016B24 RID: 92964 RVA: 0x0060B9AC File Offset: 0x00609BAC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_DisplayRewardCount(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataMemoryCorridorLevelInfo configDataMemoryCorridorLevelInfo = (ConfigDataMemoryCorridorLevelInfo)LuaObject.checkSelf(l);
			int displayRewardCount;
			LuaObject.checkType(l, 2, out displayRewardCount);
			configDataMemoryCorridorLevelInfo.DisplayRewardCount = displayRewardCount;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06016B25 RID: 92965 RVA: 0x0060BA04 File Offset: 0x00609C04
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_Icon(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataMemoryCorridorLevelInfo configDataMemoryCorridorLevelInfo = (ConfigDataMemoryCorridorLevelInfo)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, configDataMemoryCorridorLevelInfo.Icon);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06016B26 RID: 92966 RVA: 0x0060BA58 File Offset: 0x00609C58
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_Icon(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataMemoryCorridorLevelInfo configDataMemoryCorridorLevelInfo = (ConfigDataMemoryCorridorLevelInfo)LuaObject.checkSelf(l);
			string icon;
			LuaObject.checkType(l, 2, out icon);
			configDataMemoryCorridorLevelInfo.Icon = icon;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06016B27 RID: 92967 RVA: 0x0060BAB0 File Offset: 0x00609CB0
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_Strategy(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataMemoryCorridorLevelInfo configDataMemoryCorridorLevelInfo = (ConfigDataMemoryCorridorLevelInfo)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, configDataMemoryCorridorLevelInfo.Strategy);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06016B28 RID: 92968 RVA: 0x0060BB04 File Offset: 0x00609D04
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_Strategy(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataMemoryCorridorLevelInfo configDataMemoryCorridorLevelInfo = (ConfigDataMemoryCorridorLevelInfo)LuaObject.checkSelf(l);
			string strategy;
			LuaObject.checkType(l, 2, out strategy);
			configDataMemoryCorridorLevelInfo.Strategy = strategy;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06016B29 RID: 92969 RVA: 0x0060BB5C File Offset: 0x00609D5C
	[Preserve]
	public static void reg(IntPtr l)
	{
		LuaObject.getTypeTable(l, "BlackJack.ConfigData.ConfigDataMemoryCorridorLevelInfo");
		string name = "m_battleInfo";
		if (Lua_BlackJack_ConfigData_ConfigDataMemoryCorridorLevelInfo.<>f__mg$cache0 == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataMemoryCorridorLevelInfo.<>f__mg$cache0 = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataMemoryCorridorLevelInfo.get_m_battleInfo);
		}
		LuaCSFunction get = Lua_BlackJack_ConfigData_ConfigDataMemoryCorridorLevelInfo.<>f__mg$cache0;
		if (Lua_BlackJack_ConfigData_ConfigDataMemoryCorridorLevelInfo.<>f__mg$cache1 == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataMemoryCorridorLevelInfo.<>f__mg$cache1 = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataMemoryCorridorLevelInfo.set_m_battleInfo);
		}
		LuaObject.addMember(l, name, get, Lua_BlackJack_ConfigData_ConfigDataMemoryCorridorLevelInfo.<>f__mg$cache1, true);
		string name2 = "m_groupInfo";
		if (Lua_BlackJack_ConfigData_ConfigDataMemoryCorridorLevelInfo.<>f__mg$cache2 == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataMemoryCorridorLevelInfo.<>f__mg$cache2 = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataMemoryCorridorLevelInfo.get_m_groupInfo);
		}
		LuaCSFunction get2 = Lua_BlackJack_ConfigData_ConfigDataMemoryCorridorLevelInfo.<>f__mg$cache2;
		if (Lua_BlackJack_ConfigData_ConfigDataMemoryCorridorLevelInfo.<>f__mg$cache3 == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataMemoryCorridorLevelInfo.<>f__mg$cache3 = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataMemoryCorridorLevelInfo.set_m_groupInfo);
		}
		LuaObject.addMember(l, name2, get2, Lua_BlackJack_ConfigData_ConfigDataMemoryCorridorLevelInfo.<>f__mg$cache3, true);
		string name3 = "m_randomDropInfo";
		if (Lua_BlackJack_ConfigData_ConfigDataMemoryCorridorLevelInfo.<>f__mg$cache4 == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataMemoryCorridorLevelInfo.<>f__mg$cache4 = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataMemoryCorridorLevelInfo.get_m_randomDropInfo);
		}
		LuaCSFunction get3 = Lua_BlackJack_ConfigData_ConfigDataMemoryCorridorLevelInfo.<>f__mg$cache4;
		if (Lua_BlackJack_ConfigData_ConfigDataMemoryCorridorLevelInfo.<>f__mg$cache5 == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataMemoryCorridorLevelInfo.<>f__mg$cache5 = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataMemoryCorridorLevelInfo.set_m_randomDropInfo);
		}
		LuaObject.addMember(l, name3, get3, Lua_BlackJack_ConfigData_ConfigDataMemoryCorridorLevelInfo.<>f__mg$cache5, true);
		string name4 = "m_activityRandomDropInfo";
		if (Lua_BlackJack_ConfigData_ConfigDataMemoryCorridorLevelInfo.<>f__mg$cache6 == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataMemoryCorridorLevelInfo.<>f__mg$cache6 = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataMemoryCorridorLevelInfo.get_m_activityRandomDropInfo);
		}
		LuaCSFunction get4 = Lua_BlackJack_ConfigData_ConfigDataMemoryCorridorLevelInfo.<>f__mg$cache6;
		if (Lua_BlackJack_ConfigData_ConfigDataMemoryCorridorLevelInfo.<>f__mg$cache7 == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataMemoryCorridorLevelInfo.<>f__mg$cache7 = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataMemoryCorridorLevelInfo.set_m_activityRandomDropInfo);
		}
		LuaObject.addMember(l, name4, get4, Lua_BlackJack_ConfigData_ConfigDataMemoryCorridorLevelInfo.<>f__mg$cache7, true);
		string name5 = "ID";
		if (Lua_BlackJack_ConfigData_ConfigDataMemoryCorridorLevelInfo.<>f__mg$cache8 == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataMemoryCorridorLevelInfo.<>f__mg$cache8 = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataMemoryCorridorLevelInfo.get_ID);
		}
		LuaCSFunction get5 = Lua_BlackJack_ConfigData_ConfigDataMemoryCorridorLevelInfo.<>f__mg$cache8;
		if (Lua_BlackJack_ConfigData_ConfigDataMemoryCorridorLevelInfo.<>f__mg$cache9 == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataMemoryCorridorLevelInfo.<>f__mg$cache9 = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataMemoryCorridorLevelInfo.set_ID);
		}
		LuaObject.addMember(l, name5, get5, Lua_BlackJack_ConfigData_ConfigDataMemoryCorridorLevelInfo.<>f__mg$cache9, true);
		string name6 = "Name";
		if (Lua_BlackJack_ConfigData_ConfigDataMemoryCorridorLevelInfo.<>f__mg$cacheA == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataMemoryCorridorLevelInfo.<>f__mg$cacheA = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataMemoryCorridorLevelInfo.get_Name);
		}
		LuaCSFunction get6 = Lua_BlackJack_ConfigData_ConfigDataMemoryCorridorLevelInfo.<>f__mg$cacheA;
		if (Lua_BlackJack_ConfigData_ConfigDataMemoryCorridorLevelInfo.<>f__mg$cacheB == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataMemoryCorridorLevelInfo.<>f__mg$cacheB = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataMemoryCorridorLevelInfo.set_Name);
		}
		LuaObject.addMember(l, name6, get6, Lua_BlackJack_ConfigData_ConfigDataMemoryCorridorLevelInfo.<>f__mg$cacheB, true);
		string name7 = "TeamName";
		if (Lua_BlackJack_ConfigData_ConfigDataMemoryCorridorLevelInfo.<>f__mg$cacheC == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataMemoryCorridorLevelInfo.<>f__mg$cacheC = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataMemoryCorridorLevelInfo.get_TeamName);
		}
		LuaCSFunction get7 = Lua_BlackJack_ConfigData_ConfigDataMemoryCorridorLevelInfo.<>f__mg$cacheC;
		if (Lua_BlackJack_ConfigData_ConfigDataMemoryCorridorLevelInfo.<>f__mg$cacheD == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataMemoryCorridorLevelInfo.<>f__mg$cacheD = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataMemoryCorridorLevelInfo.set_TeamName);
		}
		LuaObject.addMember(l, name7, get7, Lua_BlackJack_ConfigData_ConfigDataMemoryCorridorLevelInfo.<>f__mg$cacheD, true);
		string name8 = "OpenPlayerLevel";
		if (Lua_BlackJack_ConfigData_ConfigDataMemoryCorridorLevelInfo.<>f__mg$cacheE == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataMemoryCorridorLevelInfo.<>f__mg$cacheE = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataMemoryCorridorLevelInfo.get_OpenPlayerLevel);
		}
		LuaCSFunction get8 = Lua_BlackJack_ConfigData_ConfigDataMemoryCorridorLevelInfo.<>f__mg$cacheE;
		if (Lua_BlackJack_ConfigData_ConfigDataMemoryCorridorLevelInfo.<>f__mg$cacheF == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataMemoryCorridorLevelInfo.<>f__mg$cacheF = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataMemoryCorridorLevelInfo.set_OpenPlayerLevel);
		}
		LuaObject.addMember(l, name8, get8, Lua_BlackJack_ConfigData_ConfigDataMemoryCorridorLevelInfo.<>f__mg$cacheF, true);
		string name9 = "TicketCost";
		if (Lua_BlackJack_ConfigData_ConfigDataMemoryCorridorLevelInfo.<>f__mg$cache10 == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataMemoryCorridorLevelInfo.<>f__mg$cache10 = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataMemoryCorridorLevelInfo.get_TicketCost);
		}
		LuaCSFunction get9 = Lua_BlackJack_ConfigData_ConfigDataMemoryCorridorLevelInfo.<>f__mg$cache10;
		if (Lua_BlackJack_ConfigData_ConfigDataMemoryCorridorLevelInfo.<>f__mg$cache11 == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataMemoryCorridorLevelInfo.<>f__mg$cache11 = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataMemoryCorridorLevelInfo.set_TicketCost);
		}
		LuaObject.addMember(l, name9, get9, Lua_BlackJack_ConfigData_ConfigDataMemoryCorridorLevelInfo.<>f__mg$cache11, true);
		string name10 = "EnergySuccess";
		if (Lua_BlackJack_ConfigData_ConfigDataMemoryCorridorLevelInfo.<>f__mg$cache12 == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataMemoryCorridorLevelInfo.<>f__mg$cache12 = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataMemoryCorridorLevelInfo.get_EnergySuccess);
		}
		LuaCSFunction get10 = Lua_BlackJack_ConfigData_ConfigDataMemoryCorridorLevelInfo.<>f__mg$cache12;
		if (Lua_BlackJack_ConfigData_ConfigDataMemoryCorridorLevelInfo.<>f__mg$cache13 == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataMemoryCorridorLevelInfo.<>f__mg$cache13 = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataMemoryCorridorLevelInfo.set_EnergySuccess);
		}
		LuaObject.addMember(l, name10, get10, Lua_BlackJack_ConfigData_ConfigDataMemoryCorridorLevelInfo.<>f__mg$cache13, true);
		string name11 = "EnergyFail";
		if (Lua_BlackJack_ConfigData_ConfigDataMemoryCorridorLevelInfo.<>f__mg$cache14 == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataMemoryCorridorLevelInfo.<>f__mg$cache14 = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataMemoryCorridorLevelInfo.get_EnergyFail);
		}
		LuaCSFunction get11 = Lua_BlackJack_ConfigData_ConfigDataMemoryCorridorLevelInfo.<>f__mg$cache14;
		if (Lua_BlackJack_ConfigData_ConfigDataMemoryCorridorLevelInfo.<>f__mg$cache15 == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataMemoryCorridorLevelInfo.<>f__mg$cache15 = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataMemoryCorridorLevelInfo.set_EnergyFail);
		}
		LuaObject.addMember(l, name11, get11, Lua_BlackJack_ConfigData_ConfigDataMemoryCorridorLevelInfo.<>f__mg$cache15, true);
		string name12 = "TeamEnergyCost";
		if (Lua_BlackJack_ConfigData_ConfigDataMemoryCorridorLevelInfo.<>f__mg$cache16 == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataMemoryCorridorLevelInfo.<>f__mg$cache16 = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataMemoryCorridorLevelInfo.get_TeamEnergyCost);
		}
		LuaCSFunction get12 = Lua_BlackJack_ConfigData_ConfigDataMemoryCorridorLevelInfo.<>f__mg$cache16;
		if (Lua_BlackJack_ConfigData_ConfigDataMemoryCorridorLevelInfo.<>f__mg$cache17 == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataMemoryCorridorLevelInfo.<>f__mg$cache17 = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataMemoryCorridorLevelInfo.set_TeamEnergyCost);
		}
		LuaObject.addMember(l, name12, get12, Lua_BlackJack_ConfigData_ConfigDataMemoryCorridorLevelInfo.<>f__mg$cache17, true);
		string name13 = "MonsterLevel";
		if (Lua_BlackJack_ConfigData_ConfigDataMemoryCorridorLevelInfo.<>f__mg$cache18 == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataMemoryCorridorLevelInfo.<>f__mg$cache18 = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataMemoryCorridorLevelInfo.get_MonsterLevel);
		}
		LuaCSFunction get13 = Lua_BlackJack_ConfigData_ConfigDataMemoryCorridorLevelInfo.<>f__mg$cache18;
		if (Lua_BlackJack_ConfigData_ConfigDataMemoryCorridorLevelInfo.<>f__mg$cache19 == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataMemoryCorridorLevelInfo.<>f__mg$cache19 = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataMemoryCorridorLevelInfo.set_MonsterLevel);
		}
		LuaObject.addMember(l, name13, get13, Lua_BlackJack_ConfigData_ConfigDataMemoryCorridorLevelInfo.<>f__mg$cache19, true);
		string name14 = "Battle_ID";
		if (Lua_BlackJack_ConfigData_ConfigDataMemoryCorridorLevelInfo.<>f__mg$cache1A == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataMemoryCorridorLevelInfo.<>f__mg$cache1A = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataMemoryCorridorLevelInfo.get_Battle_ID);
		}
		LuaCSFunction get14 = Lua_BlackJack_ConfigData_ConfigDataMemoryCorridorLevelInfo.<>f__mg$cache1A;
		if (Lua_BlackJack_ConfigData_ConfigDataMemoryCorridorLevelInfo.<>f__mg$cache1B == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataMemoryCorridorLevelInfo.<>f__mg$cache1B = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataMemoryCorridorLevelInfo.set_Battle_ID);
		}
		LuaObject.addMember(l, name14, get14, Lua_BlackJack_ConfigData_ConfigDataMemoryCorridorLevelInfo.<>f__mg$cache1B, true);
		string name15 = "PlayerExp";
		if (Lua_BlackJack_ConfigData_ConfigDataMemoryCorridorLevelInfo.<>f__mg$cache1C == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataMemoryCorridorLevelInfo.<>f__mg$cache1C = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataMemoryCorridorLevelInfo.get_PlayerExp);
		}
		LuaCSFunction get15 = Lua_BlackJack_ConfigData_ConfigDataMemoryCorridorLevelInfo.<>f__mg$cache1C;
		if (Lua_BlackJack_ConfigData_ConfigDataMemoryCorridorLevelInfo.<>f__mg$cache1D == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataMemoryCorridorLevelInfo.<>f__mg$cache1D = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataMemoryCorridorLevelInfo.set_PlayerExp);
		}
		LuaObject.addMember(l, name15, get15, Lua_BlackJack_ConfigData_ConfigDataMemoryCorridorLevelInfo.<>f__mg$cache1D, true);
		string name16 = "HeroExp";
		if (Lua_BlackJack_ConfigData_ConfigDataMemoryCorridorLevelInfo.<>f__mg$cache1E == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataMemoryCorridorLevelInfo.<>f__mg$cache1E = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataMemoryCorridorLevelInfo.get_HeroExp);
		}
		LuaCSFunction get16 = Lua_BlackJack_ConfigData_ConfigDataMemoryCorridorLevelInfo.<>f__mg$cache1E;
		if (Lua_BlackJack_ConfigData_ConfigDataMemoryCorridorLevelInfo.<>f__mg$cache1F == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataMemoryCorridorLevelInfo.<>f__mg$cache1F = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataMemoryCorridorLevelInfo.set_HeroExp);
		}
		LuaObject.addMember(l, name16, get16, Lua_BlackJack_ConfigData_ConfigDataMemoryCorridorLevelInfo.<>f__mg$cache1F, true);
		string name17 = "Gold";
		if (Lua_BlackJack_ConfigData_ConfigDataMemoryCorridorLevelInfo.<>f__mg$cache20 == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataMemoryCorridorLevelInfo.<>f__mg$cache20 = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataMemoryCorridorLevelInfo.get_Gold);
		}
		LuaCSFunction get17 = Lua_BlackJack_ConfigData_ConfigDataMemoryCorridorLevelInfo.<>f__mg$cache20;
		if (Lua_BlackJack_ConfigData_ConfigDataMemoryCorridorLevelInfo.<>f__mg$cache21 == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataMemoryCorridorLevelInfo.<>f__mg$cache21 = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataMemoryCorridorLevelInfo.set_Gold);
		}
		LuaObject.addMember(l, name17, get17, Lua_BlackJack_ConfigData_ConfigDataMemoryCorridorLevelInfo.<>f__mg$cache21, true);
		string name18 = "Drop_ID";
		if (Lua_BlackJack_ConfigData_ConfigDataMemoryCorridorLevelInfo.<>f__mg$cache22 == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataMemoryCorridorLevelInfo.<>f__mg$cache22 = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataMemoryCorridorLevelInfo.get_Drop_ID);
		}
		LuaCSFunction get18 = Lua_BlackJack_ConfigData_ConfigDataMemoryCorridorLevelInfo.<>f__mg$cache22;
		if (Lua_BlackJack_ConfigData_ConfigDataMemoryCorridorLevelInfo.<>f__mg$cache23 == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataMemoryCorridorLevelInfo.<>f__mg$cache23 = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataMemoryCorridorLevelInfo.set_Drop_ID);
		}
		LuaObject.addMember(l, name18, get18, Lua_BlackJack_ConfigData_ConfigDataMemoryCorridorLevelInfo.<>f__mg$cache23, true);
		string name19 = "TeamDrop_ID";
		if (Lua_BlackJack_ConfigData_ConfigDataMemoryCorridorLevelInfo.<>f__mg$cache24 == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataMemoryCorridorLevelInfo.<>f__mg$cache24 = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataMemoryCorridorLevelInfo.get_TeamDrop_ID);
		}
		LuaCSFunction get19 = Lua_BlackJack_ConfigData_ConfigDataMemoryCorridorLevelInfo.<>f__mg$cache24;
		if (Lua_BlackJack_ConfigData_ConfigDataMemoryCorridorLevelInfo.<>f__mg$cache25 == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataMemoryCorridorLevelInfo.<>f__mg$cache25 = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataMemoryCorridorLevelInfo.set_TeamDrop_ID);
		}
		LuaObject.addMember(l, name19, get19, Lua_BlackJack_ConfigData_ConfigDataMemoryCorridorLevelInfo.<>f__mg$cache25, true);
		string name20 = "OperationalActivityDrop_ID";
		if (Lua_BlackJack_ConfigData_ConfigDataMemoryCorridorLevelInfo.<>f__mg$cache26 == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataMemoryCorridorLevelInfo.<>f__mg$cache26 = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataMemoryCorridorLevelInfo.get_OperationalActivityDrop_ID);
		}
		LuaCSFunction get20 = Lua_BlackJack_ConfigData_ConfigDataMemoryCorridorLevelInfo.<>f__mg$cache26;
		if (Lua_BlackJack_ConfigData_ConfigDataMemoryCorridorLevelInfo.<>f__mg$cache27 == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataMemoryCorridorLevelInfo.<>f__mg$cache27 = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataMemoryCorridorLevelInfo.set_OperationalActivityDrop_ID);
		}
		LuaObject.addMember(l, name20, get20, Lua_BlackJack_ConfigData_ConfigDataMemoryCorridorLevelInfo.<>f__mg$cache27, true);
		string name21 = "DayBonusDrop_ID";
		if (Lua_BlackJack_ConfigData_ConfigDataMemoryCorridorLevelInfo.<>f__mg$cache28 == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataMemoryCorridorLevelInfo.<>f__mg$cache28 = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataMemoryCorridorLevelInfo.get_DayBonusDrop_ID);
		}
		LuaCSFunction get21 = Lua_BlackJack_ConfigData_ConfigDataMemoryCorridorLevelInfo.<>f__mg$cache28;
		if (Lua_BlackJack_ConfigData_ConfigDataMemoryCorridorLevelInfo.<>f__mg$cache29 == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataMemoryCorridorLevelInfo.<>f__mg$cache29 = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataMemoryCorridorLevelInfo.set_DayBonusDrop_ID);
		}
		LuaObject.addMember(l, name21, get21, Lua_BlackJack_ConfigData_ConfigDataMemoryCorridorLevelInfo.<>f__mg$cache29, true);
		string name22 = "DisplayRewardCount";
		if (Lua_BlackJack_ConfigData_ConfigDataMemoryCorridorLevelInfo.<>f__mg$cache2A == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataMemoryCorridorLevelInfo.<>f__mg$cache2A = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataMemoryCorridorLevelInfo.get_DisplayRewardCount);
		}
		LuaCSFunction get22 = Lua_BlackJack_ConfigData_ConfigDataMemoryCorridorLevelInfo.<>f__mg$cache2A;
		if (Lua_BlackJack_ConfigData_ConfigDataMemoryCorridorLevelInfo.<>f__mg$cache2B == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataMemoryCorridorLevelInfo.<>f__mg$cache2B = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataMemoryCorridorLevelInfo.set_DisplayRewardCount);
		}
		LuaObject.addMember(l, name22, get22, Lua_BlackJack_ConfigData_ConfigDataMemoryCorridorLevelInfo.<>f__mg$cache2B, true);
		string name23 = "Icon";
		if (Lua_BlackJack_ConfigData_ConfigDataMemoryCorridorLevelInfo.<>f__mg$cache2C == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataMemoryCorridorLevelInfo.<>f__mg$cache2C = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataMemoryCorridorLevelInfo.get_Icon);
		}
		LuaCSFunction get23 = Lua_BlackJack_ConfigData_ConfigDataMemoryCorridorLevelInfo.<>f__mg$cache2C;
		if (Lua_BlackJack_ConfigData_ConfigDataMemoryCorridorLevelInfo.<>f__mg$cache2D == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataMemoryCorridorLevelInfo.<>f__mg$cache2D = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataMemoryCorridorLevelInfo.set_Icon);
		}
		LuaObject.addMember(l, name23, get23, Lua_BlackJack_ConfigData_ConfigDataMemoryCorridorLevelInfo.<>f__mg$cache2D, true);
		string name24 = "Strategy";
		if (Lua_BlackJack_ConfigData_ConfigDataMemoryCorridorLevelInfo.<>f__mg$cache2E == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataMemoryCorridorLevelInfo.<>f__mg$cache2E = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataMemoryCorridorLevelInfo.get_Strategy);
		}
		LuaCSFunction get24 = Lua_BlackJack_ConfigData_ConfigDataMemoryCorridorLevelInfo.<>f__mg$cache2E;
		if (Lua_BlackJack_ConfigData_ConfigDataMemoryCorridorLevelInfo.<>f__mg$cache2F == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataMemoryCorridorLevelInfo.<>f__mg$cache2F = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataMemoryCorridorLevelInfo.set_Strategy);
		}
		LuaObject.addMember(l, name24, get24, Lua_BlackJack_ConfigData_ConfigDataMemoryCorridorLevelInfo.<>f__mg$cache2F, true);
		if (Lua_BlackJack_ConfigData_ConfigDataMemoryCorridorLevelInfo.<>f__mg$cache30 == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataMemoryCorridorLevelInfo.<>f__mg$cache30 = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataMemoryCorridorLevelInfo.constructor);
		}
		LuaObject.createTypeMetatable(l, Lua_BlackJack_ConfigData_ConfigDataMemoryCorridorLevelInfo.<>f__mg$cache30, typeof(ConfigDataMemoryCorridorLevelInfo));
	}

	// Token: 0x0400D21A RID: 53786
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache0;

	// Token: 0x0400D21B RID: 53787
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1;

	// Token: 0x0400D21C RID: 53788
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2;

	// Token: 0x0400D21D RID: 53789
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3;

	// Token: 0x0400D21E RID: 53790
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache4;

	// Token: 0x0400D21F RID: 53791
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache5;

	// Token: 0x0400D220 RID: 53792
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache6;

	// Token: 0x0400D221 RID: 53793
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache7;

	// Token: 0x0400D222 RID: 53794
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache8;

	// Token: 0x0400D223 RID: 53795
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache9;

	// Token: 0x0400D224 RID: 53796
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheA;

	// Token: 0x0400D225 RID: 53797
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheB;

	// Token: 0x0400D226 RID: 53798
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheC;

	// Token: 0x0400D227 RID: 53799
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheD;

	// Token: 0x0400D228 RID: 53800
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheE;

	// Token: 0x0400D229 RID: 53801
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheF;

	// Token: 0x0400D22A RID: 53802
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache10;

	// Token: 0x0400D22B RID: 53803
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache11;

	// Token: 0x0400D22C RID: 53804
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache12;

	// Token: 0x0400D22D RID: 53805
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache13;

	// Token: 0x0400D22E RID: 53806
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache14;

	// Token: 0x0400D22F RID: 53807
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache15;

	// Token: 0x0400D230 RID: 53808
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache16;

	// Token: 0x0400D231 RID: 53809
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache17;

	// Token: 0x0400D232 RID: 53810
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache18;

	// Token: 0x0400D233 RID: 53811
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache19;

	// Token: 0x0400D234 RID: 53812
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1A;

	// Token: 0x0400D235 RID: 53813
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1B;

	// Token: 0x0400D236 RID: 53814
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1C;

	// Token: 0x0400D237 RID: 53815
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1D;

	// Token: 0x0400D238 RID: 53816
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1E;

	// Token: 0x0400D239 RID: 53817
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1F;

	// Token: 0x0400D23A RID: 53818
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache20;

	// Token: 0x0400D23B RID: 53819
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache21;

	// Token: 0x0400D23C RID: 53820
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache22;

	// Token: 0x0400D23D RID: 53821
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache23;

	// Token: 0x0400D23E RID: 53822
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache24;

	// Token: 0x0400D23F RID: 53823
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache25;

	// Token: 0x0400D240 RID: 53824
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache26;

	// Token: 0x0400D241 RID: 53825
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache27;

	// Token: 0x0400D242 RID: 53826
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache28;

	// Token: 0x0400D243 RID: 53827
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache29;

	// Token: 0x0400D244 RID: 53828
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2A;

	// Token: 0x0400D245 RID: 53829
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2B;

	// Token: 0x0400D246 RID: 53830
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2C;

	// Token: 0x0400D247 RID: 53831
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2D;

	// Token: 0x0400D248 RID: 53832
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2E;

	// Token: 0x0400D249 RID: 53833
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2F;

	// Token: 0x0400D24A RID: 53834
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache30;
}
