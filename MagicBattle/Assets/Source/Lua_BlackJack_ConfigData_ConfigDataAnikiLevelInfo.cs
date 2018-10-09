using System;
using System.Runtime.CompilerServices;
using BlackJack.ConfigData;
using SLua;
using UnityEngine.Scripting;

// Token: 0x02001135 RID: 4405
[Preserve]
public class Lua_BlackJack_ConfigData_ConfigDataAnikiLevelInfo : LuaObject
{
	// Token: 0x06016440 RID: 91200 RVA: 0x005D9D54 File Offset: 0x005D7F54
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int constructor(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataAnikiLevelInfo o = new ConfigDataAnikiLevelInfo();
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

	// Token: 0x06016441 RID: 91201 RVA: 0x005D9D9C File Offset: 0x005D7F9C
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_m_battleInfo(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataAnikiLevelInfo configDataAnikiLevelInfo = (ConfigDataAnikiLevelInfo)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, configDataAnikiLevelInfo.m_battleInfo);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06016442 RID: 91202 RVA: 0x005D9DF0 File Offset: 0x005D7FF0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_battleInfo(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataAnikiLevelInfo configDataAnikiLevelInfo = (ConfigDataAnikiLevelInfo)LuaObject.checkSelf(l);
			ConfigDataBattleInfo battleInfo;
			LuaObject.checkType<ConfigDataBattleInfo>(l, 2, out battleInfo);
			configDataAnikiLevelInfo.m_battleInfo = battleInfo;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06016443 RID: 91203 RVA: 0x005D9E48 File Offset: 0x005D8048
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_groupInfo(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataAnikiLevelInfo configDataAnikiLevelInfo = (ConfigDataAnikiLevelInfo)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, configDataAnikiLevelInfo.m_groupInfo);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06016444 RID: 91204 RVA: 0x005D9E9C File Offset: 0x005D809C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_groupInfo(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataAnikiLevelInfo configDataAnikiLevelInfo = (ConfigDataAnikiLevelInfo)LuaObject.checkSelf(l);
			ConfigDataAnikiGymInfo groupInfo;
			LuaObject.checkType<ConfigDataAnikiGymInfo>(l, 2, out groupInfo);
			configDataAnikiLevelInfo.m_groupInfo = groupInfo;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06016445 RID: 91205 RVA: 0x005D9EF4 File Offset: 0x005D80F4
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_m_randomDropInfo(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataAnikiLevelInfo configDataAnikiLevelInfo = (ConfigDataAnikiLevelInfo)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, configDataAnikiLevelInfo.m_randomDropInfo);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06016446 RID: 91206 RVA: 0x005D9F48 File Offset: 0x005D8148
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_randomDropInfo(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataAnikiLevelInfo configDataAnikiLevelInfo = (ConfigDataAnikiLevelInfo)LuaObject.checkSelf(l);
			ConfigDataRandomDropRewardInfo randomDropInfo;
			LuaObject.checkType<ConfigDataRandomDropRewardInfo>(l, 2, out randomDropInfo);
			configDataAnikiLevelInfo.m_randomDropInfo = randomDropInfo;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06016447 RID: 91207 RVA: 0x005D9FA0 File Offset: 0x005D81A0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_activityRandomDropInfo(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataAnikiLevelInfo configDataAnikiLevelInfo = (ConfigDataAnikiLevelInfo)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, configDataAnikiLevelInfo.m_activityRandomDropInfo);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06016448 RID: 91208 RVA: 0x005D9FF4 File Offset: 0x005D81F4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_activityRandomDropInfo(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataAnikiLevelInfo configDataAnikiLevelInfo = (ConfigDataAnikiLevelInfo)LuaObject.checkSelf(l);
			ConfigDataRandomDropRewardInfo activityRandomDropInfo;
			LuaObject.checkType<ConfigDataRandomDropRewardInfo>(l, 2, out activityRandomDropInfo);
			configDataAnikiLevelInfo.m_activityRandomDropInfo = activityRandomDropInfo;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06016449 RID: 91209 RVA: 0x005DA04C File Offset: 0x005D824C
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_ID(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataAnikiLevelInfo configDataAnikiLevelInfo = (ConfigDataAnikiLevelInfo)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, configDataAnikiLevelInfo.ID);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601644A RID: 91210 RVA: 0x005DA0A0 File Offset: 0x005D82A0
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_ID(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataAnikiLevelInfo configDataAnikiLevelInfo = (ConfigDataAnikiLevelInfo)LuaObject.checkSelf(l);
			int id;
			LuaObject.checkType(l, 2, out id);
			configDataAnikiLevelInfo.ID = id;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601644B RID: 91211 RVA: 0x005DA0F8 File Offset: 0x005D82F8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_Name(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataAnikiLevelInfo configDataAnikiLevelInfo = (ConfigDataAnikiLevelInfo)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, configDataAnikiLevelInfo.Name);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601644C RID: 91212 RVA: 0x005DA14C File Offset: 0x005D834C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_Name(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataAnikiLevelInfo configDataAnikiLevelInfo = (ConfigDataAnikiLevelInfo)LuaObject.checkSelf(l);
			string name;
			LuaObject.checkType(l, 2, out name);
			configDataAnikiLevelInfo.Name = name;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601644D RID: 91213 RVA: 0x005DA1A4 File Offset: 0x005D83A4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_TeamName(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataAnikiLevelInfo configDataAnikiLevelInfo = (ConfigDataAnikiLevelInfo)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, configDataAnikiLevelInfo.TeamName);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601644E RID: 91214 RVA: 0x005DA1F8 File Offset: 0x005D83F8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_TeamName(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataAnikiLevelInfo configDataAnikiLevelInfo = (ConfigDataAnikiLevelInfo)LuaObject.checkSelf(l);
			string teamName;
			LuaObject.checkType(l, 2, out teamName);
			configDataAnikiLevelInfo.TeamName = teamName;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601644F RID: 91215 RVA: 0x005DA250 File Offset: 0x005D8450
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_PreLevel(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataAnikiLevelInfo configDataAnikiLevelInfo = (ConfigDataAnikiLevelInfo)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, configDataAnikiLevelInfo.PreLevel);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06016450 RID: 91216 RVA: 0x005DA2A4 File Offset: 0x005D84A4
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_PreLevel(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataAnikiLevelInfo configDataAnikiLevelInfo = (ConfigDataAnikiLevelInfo)LuaObject.checkSelf(l);
			int preLevel;
			LuaObject.checkType(l, 2, out preLevel);
			configDataAnikiLevelInfo.PreLevel = preLevel;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06016451 RID: 91217 RVA: 0x005DA2FC File Offset: 0x005D84FC
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_TicketCost(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataAnikiLevelInfo configDataAnikiLevelInfo = (ConfigDataAnikiLevelInfo)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, configDataAnikiLevelInfo.TicketCost);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06016452 RID: 91218 RVA: 0x005DA350 File Offset: 0x005D8550
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_TicketCost(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataAnikiLevelInfo configDataAnikiLevelInfo = (ConfigDataAnikiLevelInfo)LuaObject.checkSelf(l);
			int ticketCost;
			LuaObject.checkType(l, 2, out ticketCost);
			configDataAnikiLevelInfo.TicketCost = ticketCost;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06016453 RID: 91219 RVA: 0x005DA3A8 File Offset: 0x005D85A8
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_EnergySuccess(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataAnikiLevelInfo configDataAnikiLevelInfo = (ConfigDataAnikiLevelInfo)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, configDataAnikiLevelInfo.EnergySuccess);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06016454 RID: 91220 RVA: 0x005DA3FC File Offset: 0x005D85FC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_EnergySuccess(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataAnikiLevelInfo configDataAnikiLevelInfo = (ConfigDataAnikiLevelInfo)LuaObject.checkSelf(l);
			int energySuccess;
			LuaObject.checkType(l, 2, out energySuccess);
			configDataAnikiLevelInfo.EnergySuccess = energySuccess;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06016455 RID: 91221 RVA: 0x005DA454 File Offset: 0x005D8654
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_EnergyFail(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataAnikiLevelInfo configDataAnikiLevelInfo = (ConfigDataAnikiLevelInfo)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, configDataAnikiLevelInfo.EnergyFail);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06016456 RID: 91222 RVA: 0x005DA4A8 File Offset: 0x005D86A8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_EnergyFail(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataAnikiLevelInfo configDataAnikiLevelInfo = (ConfigDataAnikiLevelInfo)LuaObject.checkSelf(l);
			int energyFail;
			LuaObject.checkType(l, 2, out energyFail);
			configDataAnikiLevelInfo.EnergyFail = energyFail;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06016457 RID: 91223 RVA: 0x005DA500 File Offset: 0x005D8700
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_TeamEnergyCost(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataAnikiLevelInfo configDataAnikiLevelInfo = (ConfigDataAnikiLevelInfo)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, configDataAnikiLevelInfo.TeamEnergyCost);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06016458 RID: 91224 RVA: 0x005DA554 File Offset: 0x005D8754
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_TeamEnergyCost(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataAnikiLevelInfo configDataAnikiLevelInfo = (ConfigDataAnikiLevelInfo)LuaObject.checkSelf(l);
			int teamEnergyCost;
			LuaObject.checkType(l, 2, out teamEnergyCost);
			configDataAnikiLevelInfo.TeamEnergyCost = teamEnergyCost;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06016459 RID: 91225 RVA: 0x005DA5AC File Offset: 0x005D87AC
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_MonsterLevel(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataAnikiLevelInfo configDataAnikiLevelInfo = (ConfigDataAnikiLevelInfo)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, configDataAnikiLevelInfo.MonsterLevel);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601645A RID: 91226 RVA: 0x005DA600 File Offset: 0x005D8800
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_MonsterLevel(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataAnikiLevelInfo configDataAnikiLevelInfo = (ConfigDataAnikiLevelInfo)LuaObject.checkSelf(l);
			int monsterLevel;
			LuaObject.checkType(l, 2, out monsterLevel);
			configDataAnikiLevelInfo.MonsterLevel = monsterLevel;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601645B RID: 91227 RVA: 0x005DA658 File Offset: 0x005D8858
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_Battle_ID(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataAnikiLevelInfo configDataAnikiLevelInfo = (ConfigDataAnikiLevelInfo)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, configDataAnikiLevelInfo.Battle_ID);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601645C RID: 91228 RVA: 0x005DA6AC File Offset: 0x005D88AC
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_Battle_ID(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataAnikiLevelInfo configDataAnikiLevelInfo = (ConfigDataAnikiLevelInfo)LuaObject.checkSelf(l);
			int battle_ID;
			LuaObject.checkType(l, 2, out battle_ID);
			configDataAnikiLevelInfo.Battle_ID = battle_ID;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601645D RID: 91229 RVA: 0x005DA704 File Offset: 0x005D8904
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_PlayerExp(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataAnikiLevelInfo configDataAnikiLevelInfo = (ConfigDataAnikiLevelInfo)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, configDataAnikiLevelInfo.PlayerExp);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601645E RID: 91230 RVA: 0x005DA758 File Offset: 0x005D8958
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_PlayerExp(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataAnikiLevelInfo configDataAnikiLevelInfo = (ConfigDataAnikiLevelInfo)LuaObject.checkSelf(l);
			int playerExp;
			LuaObject.checkType(l, 2, out playerExp);
			configDataAnikiLevelInfo.PlayerExp = playerExp;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601645F RID: 91231 RVA: 0x005DA7B0 File Offset: 0x005D89B0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_HeroExp(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataAnikiLevelInfo configDataAnikiLevelInfo = (ConfigDataAnikiLevelInfo)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, configDataAnikiLevelInfo.HeroExp);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06016460 RID: 91232 RVA: 0x005DA804 File Offset: 0x005D8A04
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_HeroExp(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataAnikiLevelInfo configDataAnikiLevelInfo = (ConfigDataAnikiLevelInfo)LuaObject.checkSelf(l);
			int heroExp;
			LuaObject.checkType(l, 2, out heroExp);
			configDataAnikiLevelInfo.HeroExp = heroExp;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06016461 RID: 91233 RVA: 0x005DA85C File Offset: 0x005D8A5C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_Gold(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataAnikiLevelInfo configDataAnikiLevelInfo = (ConfigDataAnikiLevelInfo)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, configDataAnikiLevelInfo.Gold);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06016462 RID: 91234 RVA: 0x005DA8B0 File Offset: 0x005D8AB0
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_Gold(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataAnikiLevelInfo configDataAnikiLevelInfo = (ConfigDataAnikiLevelInfo)LuaObject.checkSelf(l);
			int gold;
			LuaObject.checkType(l, 2, out gold);
			configDataAnikiLevelInfo.Gold = gold;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06016463 RID: 91235 RVA: 0x005DA908 File Offset: 0x005D8B08
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_Drop_ID(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataAnikiLevelInfo configDataAnikiLevelInfo = (ConfigDataAnikiLevelInfo)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, configDataAnikiLevelInfo.Drop_ID);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06016464 RID: 91236 RVA: 0x005DA95C File Offset: 0x005D8B5C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_Drop_ID(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataAnikiLevelInfo configDataAnikiLevelInfo = (ConfigDataAnikiLevelInfo)LuaObject.checkSelf(l);
			int drop_ID;
			LuaObject.checkType(l, 2, out drop_ID);
			configDataAnikiLevelInfo.Drop_ID = drop_ID;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06016465 RID: 91237 RVA: 0x005DA9B4 File Offset: 0x005D8BB4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_TeamDrop_ID(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataAnikiLevelInfo configDataAnikiLevelInfo = (ConfigDataAnikiLevelInfo)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, configDataAnikiLevelInfo.TeamDrop_ID);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06016466 RID: 91238 RVA: 0x005DAA08 File Offset: 0x005D8C08
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_TeamDrop_ID(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataAnikiLevelInfo configDataAnikiLevelInfo = (ConfigDataAnikiLevelInfo)LuaObject.checkSelf(l);
			int teamDrop_ID;
			LuaObject.checkType(l, 2, out teamDrop_ID);
			configDataAnikiLevelInfo.TeamDrop_ID = teamDrop_ID;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06016467 RID: 91239 RVA: 0x005DAA60 File Offset: 0x005D8C60
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_OperationalActivityDrop_ID(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataAnikiLevelInfo configDataAnikiLevelInfo = (ConfigDataAnikiLevelInfo)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, configDataAnikiLevelInfo.OperationalActivityDrop_ID);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06016468 RID: 91240 RVA: 0x005DAAB4 File Offset: 0x005D8CB4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_OperationalActivityDrop_ID(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataAnikiLevelInfo configDataAnikiLevelInfo = (ConfigDataAnikiLevelInfo)LuaObject.checkSelf(l);
			int operationalActivityDrop_ID;
			LuaObject.checkType(l, 2, out operationalActivityDrop_ID);
			configDataAnikiLevelInfo.OperationalActivityDrop_ID = operationalActivityDrop_ID;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06016469 RID: 91241 RVA: 0x005DAB0C File Offset: 0x005D8D0C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_DayBonusDrop_ID(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataAnikiLevelInfo configDataAnikiLevelInfo = (ConfigDataAnikiLevelInfo)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, configDataAnikiLevelInfo.DayBonusDrop_ID);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601646A RID: 91242 RVA: 0x005DAB60 File Offset: 0x005D8D60
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_DayBonusDrop_ID(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataAnikiLevelInfo configDataAnikiLevelInfo = (ConfigDataAnikiLevelInfo)LuaObject.checkSelf(l);
			int dayBonusDrop_ID;
			LuaObject.checkType(l, 2, out dayBonusDrop_ID);
			configDataAnikiLevelInfo.DayBonusDrop_ID = dayBonusDrop_ID;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601646B RID: 91243 RVA: 0x005DABB8 File Offset: 0x005D8DB8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_DisplayRewardCount(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataAnikiLevelInfo configDataAnikiLevelInfo = (ConfigDataAnikiLevelInfo)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, configDataAnikiLevelInfo.DisplayRewardCount);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601646C RID: 91244 RVA: 0x005DAC0C File Offset: 0x005D8E0C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_DisplayRewardCount(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataAnikiLevelInfo configDataAnikiLevelInfo = (ConfigDataAnikiLevelInfo)LuaObject.checkSelf(l);
			int displayRewardCount;
			LuaObject.checkType(l, 2, out displayRewardCount);
			configDataAnikiLevelInfo.DisplayRewardCount = displayRewardCount;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601646D RID: 91245 RVA: 0x005DAC64 File Offset: 0x005D8E64
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_Icon1(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataAnikiLevelInfo configDataAnikiLevelInfo = (ConfigDataAnikiLevelInfo)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, configDataAnikiLevelInfo.Icon1);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601646E RID: 91246 RVA: 0x005DACB8 File Offset: 0x005D8EB8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_Icon1(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataAnikiLevelInfo configDataAnikiLevelInfo = (ConfigDataAnikiLevelInfo)LuaObject.checkSelf(l);
			string icon;
			LuaObject.checkType(l, 2, out icon);
			configDataAnikiLevelInfo.Icon1 = icon;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601646F RID: 91247 RVA: 0x005DAD10 File Offset: 0x005D8F10
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_Icon2(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataAnikiLevelInfo configDataAnikiLevelInfo = (ConfigDataAnikiLevelInfo)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, configDataAnikiLevelInfo.Icon2);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06016470 RID: 91248 RVA: 0x005DAD64 File Offset: 0x005D8F64
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_Icon2(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataAnikiLevelInfo configDataAnikiLevelInfo = (ConfigDataAnikiLevelInfo)LuaObject.checkSelf(l);
			string icon;
			LuaObject.checkType(l, 2, out icon);
			configDataAnikiLevelInfo.Icon2 = icon;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06016471 RID: 91249 RVA: 0x005DADBC File Offset: 0x005D8FBC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_Strategy(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataAnikiLevelInfo configDataAnikiLevelInfo = (ConfigDataAnikiLevelInfo)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, configDataAnikiLevelInfo.Strategy);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06016472 RID: 91250 RVA: 0x005DAE10 File Offset: 0x005D9010
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_Strategy(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataAnikiLevelInfo configDataAnikiLevelInfo = (ConfigDataAnikiLevelInfo)LuaObject.checkSelf(l);
			string strategy;
			LuaObject.checkType(l, 2, out strategy);
			configDataAnikiLevelInfo.Strategy = strategy;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06016473 RID: 91251 RVA: 0x005DAE68 File Offset: 0x005D9068
	[Preserve]
	public static void reg(IntPtr l)
	{
		LuaObject.getTypeTable(l, "BlackJack.ConfigData.ConfigDataAnikiLevelInfo");
		string name = "m_battleInfo";
		if (Lua_BlackJack_ConfigData_ConfigDataAnikiLevelInfo.<>f__mg$cache0 == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataAnikiLevelInfo.<>f__mg$cache0 = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataAnikiLevelInfo.get_m_battleInfo);
		}
		LuaCSFunction get = Lua_BlackJack_ConfigData_ConfigDataAnikiLevelInfo.<>f__mg$cache0;
		if (Lua_BlackJack_ConfigData_ConfigDataAnikiLevelInfo.<>f__mg$cache1 == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataAnikiLevelInfo.<>f__mg$cache1 = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataAnikiLevelInfo.set_m_battleInfo);
		}
		LuaObject.addMember(l, name, get, Lua_BlackJack_ConfigData_ConfigDataAnikiLevelInfo.<>f__mg$cache1, true);
		string name2 = "m_groupInfo";
		if (Lua_BlackJack_ConfigData_ConfigDataAnikiLevelInfo.<>f__mg$cache2 == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataAnikiLevelInfo.<>f__mg$cache2 = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataAnikiLevelInfo.get_m_groupInfo);
		}
		LuaCSFunction get2 = Lua_BlackJack_ConfigData_ConfigDataAnikiLevelInfo.<>f__mg$cache2;
		if (Lua_BlackJack_ConfigData_ConfigDataAnikiLevelInfo.<>f__mg$cache3 == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataAnikiLevelInfo.<>f__mg$cache3 = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataAnikiLevelInfo.set_m_groupInfo);
		}
		LuaObject.addMember(l, name2, get2, Lua_BlackJack_ConfigData_ConfigDataAnikiLevelInfo.<>f__mg$cache3, true);
		string name3 = "m_randomDropInfo";
		if (Lua_BlackJack_ConfigData_ConfigDataAnikiLevelInfo.<>f__mg$cache4 == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataAnikiLevelInfo.<>f__mg$cache4 = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataAnikiLevelInfo.get_m_randomDropInfo);
		}
		LuaCSFunction get3 = Lua_BlackJack_ConfigData_ConfigDataAnikiLevelInfo.<>f__mg$cache4;
		if (Lua_BlackJack_ConfigData_ConfigDataAnikiLevelInfo.<>f__mg$cache5 == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataAnikiLevelInfo.<>f__mg$cache5 = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataAnikiLevelInfo.set_m_randomDropInfo);
		}
		LuaObject.addMember(l, name3, get3, Lua_BlackJack_ConfigData_ConfigDataAnikiLevelInfo.<>f__mg$cache5, true);
		string name4 = "m_activityRandomDropInfo";
		if (Lua_BlackJack_ConfigData_ConfigDataAnikiLevelInfo.<>f__mg$cache6 == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataAnikiLevelInfo.<>f__mg$cache6 = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataAnikiLevelInfo.get_m_activityRandomDropInfo);
		}
		LuaCSFunction get4 = Lua_BlackJack_ConfigData_ConfigDataAnikiLevelInfo.<>f__mg$cache6;
		if (Lua_BlackJack_ConfigData_ConfigDataAnikiLevelInfo.<>f__mg$cache7 == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataAnikiLevelInfo.<>f__mg$cache7 = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataAnikiLevelInfo.set_m_activityRandomDropInfo);
		}
		LuaObject.addMember(l, name4, get4, Lua_BlackJack_ConfigData_ConfigDataAnikiLevelInfo.<>f__mg$cache7, true);
		string name5 = "ID";
		if (Lua_BlackJack_ConfigData_ConfigDataAnikiLevelInfo.<>f__mg$cache8 == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataAnikiLevelInfo.<>f__mg$cache8 = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataAnikiLevelInfo.get_ID);
		}
		LuaCSFunction get5 = Lua_BlackJack_ConfigData_ConfigDataAnikiLevelInfo.<>f__mg$cache8;
		if (Lua_BlackJack_ConfigData_ConfigDataAnikiLevelInfo.<>f__mg$cache9 == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataAnikiLevelInfo.<>f__mg$cache9 = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataAnikiLevelInfo.set_ID);
		}
		LuaObject.addMember(l, name5, get5, Lua_BlackJack_ConfigData_ConfigDataAnikiLevelInfo.<>f__mg$cache9, true);
		string name6 = "Name";
		if (Lua_BlackJack_ConfigData_ConfigDataAnikiLevelInfo.<>f__mg$cacheA == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataAnikiLevelInfo.<>f__mg$cacheA = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataAnikiLevelInfo.get_Name);
		}
		LuaCSFunction get6 = Lua_BlackJack_ConfigData_ConfigDataAnikiLevelInfo.<>f__mg$cacheA;
		if (Lua_BlackJack_ConfigData_ConfigDataAnikiLevelInfo.<>f__mg$cacheB == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataAnikiLevelInfo.<>f__mg$cacheB = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataAnikiLevelInfo.set_Name);
		}
		LuaObject.addMember(l, name6, get6, Lua_BlackJack_ConfigData_ConfigDataAnikiLevelInfo.<>f__mg$cacheB, true);
		string name7 = "TeamName";
		if (Lua_BlackJack_ConfigData_ConfigDataAnikiLevelInfo.<>f__mg$cacheC == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataAnikiLevelInfo.<>f__mg$cacheC = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataAnikiLevelInfo.get_TeamName);
		}
		LuaCSFunction get7 = Lua_BlackJack_ConfigData_ConfigDataAnikiLevelInfo.<>f__mg$cacheC;
		if (Lua_BlackJack_ConfigData_ConfigDataAnikiLevelInfo.<>f__mg$cacheD == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataAnikiLevelInfo.<>f__mg$cacheD = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataAnikiLevelInfo.set_TeamName);
		}
		LuaObject.addMember(l, name7, get7, Lua_BlackJack_ConfigData_ConfigDataAnikiLevelInfo.<>f__mg$cacheD, true);
		string name8 = "PreLevel";
		if (Lua_BlackJack_ConfigData_ConfigDataAnikiLevelInfo.<>f__mg$cacheE == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataAnikiLevelInfo.<>f__mg$cacheE = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataAnikiLevelInfo.get_PreLevel);
		}
		LuaCSFunction get8 = Lua_BlackJack_ConfigData_ConfigDataAnikiLevelInfo.<>f__mg$cacheE;
		if (Lua_BlackJack_ConfigData_ConfigDataAnikiLevelInfo.<>f__mg$cacheF == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataAnikiLevelInfo.<>f__mg$cacheF = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataAnikiLevelInfo.set_PreLevel);
		}
		LuaObject.addMember(l, name8, get8, Lua_BlackJack_ConfigData_ConfigDataAnikiLevelInfo.<>f__mg$cacheF, true);
		string name9 = "TicketCost";
		if (Lua_BlackJack_ConfigData_ConfigDataAnikiLevelInfo.<>f__mg$cache10 == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataAnikiLevelInfo.<>f__mg$cache10 = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataAnikiLevelInfo.get_TicketCost);
		}
		LuaCSFunction get9 = Lua_BlackJack_ConfigData_ConfigDataAnikiLevelInfo.<>f__mg$cache10;
		if (Lua_BlackJack_ConfigData_ConfigDataAnikiLevelInfo.<>f__mg$cache11 == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataAnikiLevelInfo.<>f__mg$cache11 = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataAnikiLevelInfo.set_TicketCost);
		}
		LuaObject.addMember(l, name9, get9, Lua_BlackJack_ConfigData_ConfigDataAnikiLevelInfo.<>f__mg$cache11, true);
		string name10 = "EnergySuccess";
		if (Lua_BlackJack_ConfigData_ConfigDataAnikiLevelInfo.<>f__mg$cache12 == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataAnikiLevelInfo.<>f__mg$cache12 = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataAnikiLevelInfo.get_EnergySuccess);
		}
		LuaCSFunction get10 = Lua_BlackJack_ConfigData_ConfigDataAnikiLevelInfo.<>f__mg$cache12;
		if (Lua_BlackJack_ConfigData_ConfigDataAnikiLevelInfo.<>f__mg$cache13 == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataAnikiLevelInfo.<>f__mg$cache13 = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataAnikiLevelInfo.set_EnergySuccess);
		}
		LuaObject.addMember(l, name10, get10, Lua_BlackJack_ConfigData_ConfigDataAnikiLevelInfo.<>f__mg$cache13, true);
		string name11 = "EnergyFail";
		if (Lua_BlackJack_ConfigData_ConfigDataAnikiLevelInfo.<>f__mg$cache14 == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataAnikiLevelInfo.<>f__mg$cache14 = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataAnikiLevelInfo.get_EnergyFail);
		}
		LuaCSFunction get11 = Lua_BlackJack_ConfigData_ConfigDataAnikiLevelInfo.<>f__mg$cache14;
		if (Lua_BlackJack_ConfigData_ConfigDataAnikiLevelInfo.<>f__mg$cache15 == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataAnikiLevelInfo.<>f__mg$cache15 = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataAnikiLevelInfo.set_EnergyFail);
		}
		LuaObject.addMember(l, name11, get11, Lua_BlackJack_ConfigData_ConfigDataAnikiLevelInfo.<>f__mg$cache15, true);
		string name12 = "TeamEnergyCost";
		if (Lua_BlackJack_ConfigData_ConfigDataAnikiLevelInfo.<>f__mg$cache16 == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataAnikiLevelInfo.<>f__mg$cache16 = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataAnikiLevelInfo.get_TeamEnergyCost);
		}
		LuaCSFunction get12 = Lua_BlackJack_ConfigData_ConfigDataAnikiLevelInfo.<>f__mg$cache16;
		if (Lua_BlackJack_ConfigData_ConfigDataAnikiLevelInfo.<>f__mg$cache17 == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataAnikiLevelInfo.<>f__mg$cache17 = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataAnikiLevelInfo.set_TeamEnergyCost);
		}
		LuaObject.addMember(l, name12, get12, Lua_BlackJack_ConfigData_ConfigDataAnikiLevelInfo.<>f__mg$cache17, true);
		string name13 = "MonsterLevel";
		if (Lua_BlackJack_ConfigData_ConfigDataAnikiLevelInfo.<>f__mg$cache18 == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataAnikiLevelInfo.<>f__mg$cache18 = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataAnikiLevelInfo.get_MonsterLevel);
		}
		LuaCSFunction get13 = Lua_BlackJack_ConfigData_ConfigDataAnikiLevelInfo.<>f__mg$cache18;
		if (Lua_BlackJack_ConfigData_ConfigDataAnikiLevelInfo.<>f__mg$cache19 == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataAnikiLevelInfo.<>f__mg$cache19 = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataAnikiLevelInfo.set_MonsterLevel);
		}
		LuaObject.addMember(l, name13, get13, Lua_BlackJack_ConfigData_ConfigDataAnikiLevelInfo.<>f__mg$cache19, true);
		string name14 = "Battle_ID";
		if (Lua_BlackJack_ConfigData_ConfigDataAnikiLevelInfo.<>f__mg$cache1A == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataAnikiLevelInfo.<>f__mg$cache1A = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataAnikiLevelInfo.get_Battle_ID);
		}
		LuaCSFunction get14 = Lua_BlackJack_ConfigData_ConfigDataAnikiLevelInfo.<>f__mg$cache1A;
		if (Lua_BlackJack_ConfigData_ConfigDataAnikiLevelInfo.<>f__mg$cache1B == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataAnikiLevelInfo.<>f__mg$cache1B = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataAnikiLevelInfo.set_Battle_ID);
		}
		LuaObject.addMember(l, name14, get14, Lua_BlackJack_ConfigData_ConfigDataAnikiLevelInfo.<>f__mg$cache1B, true);
		string name15 = "PlayerExp";
		if (Lua_BlackJack_ConfigData_ConfigDataAnikiLevelInfo.<>f__mg$cache1C == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataAnikiLevelInfo.<>f__mg$cache1C = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataAnikiLevelInfo.get_PlayerExp);
		}
		LuaCSFunction get15 = Lua_BlackJack_ConfigData_ConfigDataAnikiLevelInfo.<>f__mg$cache1C;
		if (Lua_BlackJack_ConfigData_ConfigDataAnikiLevelInfo.<>f__mg$cache1D == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataAnikiLevelInfo.<>f__mg$cache1D = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataAnikiLevelInfo.set_PlayerExp);
		}
		LuaObject.addMember(l, name15, get15, Lua_BlackJack_ConfigData_ConfigDataAnikiLevelInfo.<>f__mg$cache1D, true);
		string name16 = "HeroExp";
		if (Lua_BlackJack_ConfigData_ConfigDataAnikiLevelInfo.<>f__mg$cache1E == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataAnikiLevelInfo.<>f__mg$cache1E = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataAnikiLevelInfo.get_HeroExp);
		}
		LuaCSFunction get16 = Lua_BlackJack_ConfigData_ConfigDataAnikiLevelInfo.<>f__mg$cache1E;
		if (Lua_BlackJack_ConfigData_ConfigDataAnikiLevelInfo.<>f__mg$cache1F == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataAnikiLevelInfo.<>f__mg$cache1F = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataAnikiLevelInfo.set_HeroExp);
		}
		LuaObject.addMember(l, name16, get16, Lua_BlackJack_ConfigData_ConfigDataAnikiLevelInfo.<>f__mg$cache1F, true);
		string name17 = "Gold";
		if (Lua_BlackJack_ConfigData_ConfigDataAnikiLevelInfo.<>f__mg$cache20 == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataAnikiLevelInfo.<>f__mg$cache20 = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataAnikiLevelInfo.get_Gold);
		}
		LuaCSFunction get17 = Lua_BlackJack_ConfigData_ConfigDataAnikiLevelInfo.<>f__mg$cache20;
		if (Lua_BlackJack_ConfigData_ConfigDataAnikiLevelInfo.<>f__mg$cache21 == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataAnikiLevelInfo.<>f__mg$cache21 = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataAnikiLevelInfo.set_Gold);
		}
		LuaObject.addMember(l, name17, get17, Lua_BlackJack_ConfigData_ConfigDataAnikiLevelInfo.<>f__mg$cache21, true);
		string name18 = "Drop_ID";
		if (Lua_BlackJack_ConfigData_ConfigDataAnikiLevelInfo.<>f__mg$cache22 == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataAnikiLevelInfo.<>f__mg$cache22 = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataAnikiLevelInfo.get_Drop_ID);
		}
		LuaCSFunction get18 = Lua_BlackJack_ConfigData_ConfigDataAnikiLevelInfo.<>f__mg$cache22;
		if (Lua_BlackJack_ConfigData_ConfigDataAnikiLevelInfo.<>f__mg$cache23 == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataAnikiLevelInfo.<>f__mg$cache23 = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataAnikiLevelInfo.set_Drop_ID);
		}
		LuaObject.addMember(l, name18, get18, Lua_BlackJack_ConfigData_ConfigDataAnikiLevelInfo.<>f__mg$cache23, true);
		string name19 = "TeamDrop_ID";
		if (Lua_BlackJack_ConfigData_ConfigDataAnikiLevelInfo.<>f__mg$cache24 == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataAnikiLevelInfo.<>f__mg$cache24 = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataAnikiLevelInfo.get_TeamDrop_ID);
		}
		LuaCSFunction get19 = Lua_BlackJack_ConfigData_ConfigDataAnikiLevelInfo.<>f__mg$cache24;
		if (Lua_BlackJack_ConfigData_ConfigDataAnikiLevelInfo.<>f__mg$cache25 == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataAnikiLevelInfo.<>f__mg$cache25 = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataAnikiLevelInfo.set_TeamDrop_ID);
		}
		LuaObject.addMember(l, name19, get19, Lua_BlackJack_ConfigData_ConfigDataAnikiLevelInfo.<>f__mg$cache25, true);
		string name20 = "OperationalActivityDrop_ID";
		if (Lua_BlackJack_ConfigData_ConfigDataAnikiLevelInfo.<>f__mg$cache26 == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataAnikiLevelInfo.<>f__mg$cache26 = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataAnikiLevelInfo.get_OperationalActivityDrop_ID);
		}
		LuaCSFunction get20 = Lua_BlackJack_ConfigData_ConfigDataAnikiLevelInfo.<>f__mg$cache26;
		if (Lua_BlackJack_ConfigData_ConfigDataAnikiLevelInfo.<>f__mg$cache27 == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataAnikiLevelInfo.<>f__mg$cache27 = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataAnikiLevelInfo.set_OperationalActivityDrop_ID);
		}
		LuaObject.addMember(l, name20, get20, Lua_BlackJack_ConfigData_ConfigDataAnikiLevelInfo.<>f__mg$cache27, true);
		string name21 = "DayBonusDrop_ID";
		if (Lua_BlackJack_ConfigData_ConfigDataAnikiLevelInfo.<>f__mg$cache28 == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataAnikiLevelInfo.<>f__mg$cache28 = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataAnikiLevelInfo.get_DayBonusDrop_ID);
		}
		LuaCSFunction get21 = Lua_BlackJack_ConfigData_ConfigDataAnikiLevelInfo.<>f__mg$cache28;
		if (Lua_BlackJack_ConfigData_ConfigDataAnikiLevelInfo.<>f__mg$cache29 == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataAnikiLevelInfo.<>f__mg$cache29 = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataAnikiLevelInfo.set_DayBonusDrop_ID);
		}
		LuaObject.addMember(l, name21, get21, Lua_BlackJack_ConfigData_ConfigDataAnikiLevelInfo.<>f__mg$cache29, true);
		string name22 = "DisplayRewardCount";
		if (Lua_BlackJack_ConfigData_ConfigDataAnikiLevelInfo.<>f__mg$cache2A == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataAnikiLevelInfo.<>f__mg$cache2A = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataAnikiLevelInfo.get_DisplayRewardCount);
		}
		LuaCSFunction get22 = Lua_BlackJack_ConfigData_ConfigDataAnikiLevelInfo.<>f__mg$cache2A;
		if (Lua_BlackJack_ConfigData_ConfigDataAnikiLevelInfo.<>f__mg$cache2B == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataAnikiLevelInfo.<>f__mg$cache2B = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataAnikiLevelInfo.set_DisplayRewardCount);
		}
		LuaObject.addMember(l, name22, get22, Lua_BlackJack_ConfigData_ConfigDataAnikiLevelInfo.<>f__mg$cache2B, true);
		string name23 = "Icon1";
		if (Lua_BlackJack_ConfigData_ConfigDataAnikiLevelInfo.<>f__mg$cache2C == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataAnikiLevelInfo.<>f__mg$cache2C = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataAnikiLevelInfo.get_Icon1);
		}
		LuaCSFunction get23 = Lua_BlackJack_ConfigData_ConfigDataAnikiLevelInfo.<>f__mg$cache2C;
		if (Lua_BlackJack_ConfigData_ConfigDataAnikiLevelInfo.<>f__mg$cache2D == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataAnikiLevelInfo.<>f__mg$cache2D = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataAnikiLevelInfo.set_Icon1);
		}
		LuaObject.addMember(l, name23, get23, Lua_BlackJack_ConfigData_ConfigDataAnikiLevelInfo.<>f__mg$cache2D, true);
		string name24 = "Icon2";
		if (Lua_BlackJack_ConfigData_ConfigDataAnikiLevelInfo.<>f__mg$cache2E == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataAnikiLevelInfo.<>f__mg$cache2E = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataAnikiLevelInfo.get_Icon2);
		}
		LuaCSFunction get24 = Lua_BlackJack_ConfigData_ConfigDataAnikiLevelInfo.<>f__mg$cache2E;
		if (Lua_BlackJack_ConfigData_ConfigDataAnikiLevelInfo.<>f__mg$cache2F == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataAnikiLevelInfo.<>f__mg$cache2F = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataAnikiLevelInfo.set_Icon2);
		}
		LuaObject.addMember(l, name24, get24, Lua_BlackJack_ConfigData_ConfigDataAnikiLevelInfo.<>f__mg$cache2F, true);
		string name25 = "Strategy";
		if (Lua_BlackJack_ConfigData_ConfigDataAnikiLevelInfo.<>f__mg$cache30 == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataAnikiLevelInfo.<>f__mg$cache30 = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataAnikiLevelInfo.get_Strategy);
		}
		LuaCSFunction get25 = Lua_BlackJack_ConfigData_ConfigDataAnikiLevelInfo.<>f__mg$cache30;
		if (Lua_BlackJack_ConfigData_ConfigDataAnikiLevelInfo.<>f__mg$cache31 == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataAnikiLevelInfo.<>f__mg$cache31 = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataAnikiLevelInfo.set_Strategy);
		}
		LuaObject.addMember(l, name25, get25, Lua_BlackJack_ConfigData_ConfigDataAnikiLevelInfo.<>f__mg$cache31, true);
		if (Lua_BlackJack_ConfigData_ConfigDataAnikiLevelInfo.<>f__mg$cache32 == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataAnikiLevelInfo.<>f__mg$cache32 = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataAnikiLevelInfo.constructor);
		}
		LuaObject.createTypeMetatable(l, Lua_BlackJack_ConfigData_ConfigDataAnikiLevelInfo.<>f__mg$cache32, typeof(ConfigDataAnikiLevelInfo));
	}

	// Token: 0x0400CBB8 RID: 52152
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache0;

	// Token: 0x0400CBB9 RID: 52153
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1;

	// Token: 0x0400CBBA RID: 52154
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2;

	// Token: 0x0400CBBB RID: 52155
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3;

	// Token: 0x0400CBBC RID: 52156
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache4;

	// Token: 0x0400CBBD RID: 52157
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache5;

	// Token: 0x0400CBBE RID: 52158
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache6;

	// Token: 0x0400CBBF RID: 52159
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache7;

	// Token: 0x0400CBC0 RID: 52160
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache8;

	// Token: 0x0400CBC1 RID: 52161
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache9;

	// Token: 0x0400CBC2 RID: 52162
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheA;

	// Token: 0x0400CBC3 RID: 52163
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheB;

	// Token: 0x0400CBC4 RID: 52164
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheC;

	// Token: 0x0400CBC5 RID: 52165
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheD;

	// Token: 0x0400CBC6 RID: 52166
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheE;

	// Token: 0x0400CBC7 RID: 52167
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheF;

	// Token: 0x0400CBC8 RID: 52168
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache10;

	// Token: 0x0400CBC9 RID: 52169
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache11;

	// Token: 0x0400CBCA RID: 52170
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache12;

	// Token: 0x0400CBCB RID: 52171
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache13;

	// Token: 0x0400CBCC RID: 52172
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache14;

	// Token: 0x0400CBCD RID: 52173
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache15;

	// Token: 0x0400CBCE RID: 52174
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache16;

	// Token: 0x0400CBCF RID: 52175
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache17;

	// Token: 0x0400CBD0 RID: 52176
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache18;

	// Token: 0x0400CBD1 RID: 52177
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache19;

	// Token: 0x0400CBD2 RID: 52178
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1A;

	// Token: 0x0400CBD3 RID: 52179
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1B;

	// Token: 0x0400CBD4 RID: 52180
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1C;

	// Token: 0x0400CBD5 RID: 52181
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1D;

	// Token: 0x0400CBD6 RID: 52182
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1E;

	// Token: 0x0400CBD7 RID: 52183
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1F;

	// Token: 0x0400CBD8 RID: 52184
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache20;

	// Token: 0x0400CBD9 RID: 52185
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache21;

	// Token: 0x0400CBDA RID: 52186
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache22;

	// Token: 0x0400CBDB RID: 52187
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache23;

	// Token: 0x0400CBDC RID: 52188
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache24;

	// Token: 0x0400CBDD RID: 52189
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache25;

	// Token: 0x0400CBDE RID: 52190
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache26;

	// Token: 0x0400CBDF RID: 52191
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache27;

	// Token: 0x0400CBE0 RID: 52192
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache28;

	// Token: 0x0400CBE1 RID: 52193
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache29;

	// Token: 0x0400CBE2 RID: 52194
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2A;

	// Token: 0x0400CBE3 RID: 52195
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2B;

	// Token: 0x0400CBE4 RID: 52196
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2C;

	// Token: 0x0400CBE5 RID: 52197
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2D;

	// Token: 0x0400CBE6 RID: 52198
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2E;

	// Token: 0x0400CBE7 RID: 52199
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2F;

	// Token: 0x0400CBE8 RID: 52200
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache30;

	// Token: 0x0400CBE9 RID: 52201
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache31;

	// Token: 0x0400CBEA RID: 52202
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache32;
}
