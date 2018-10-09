using System;
using System.Runtime.CompilerServices;
using BlackJack.ConfigData;
using SLua;
using UnityEngine.Scripting;

// Token: 0x0200116E RID: 4462
[Preserve]
public class Lua_BlackJack_ConfigData_ConfigDataThearchyTrialLevelInfo : LuaObject
{
	// Token: 0x06016E16 RID: 93718 RVA: 0x00621970 File Offset: 0x0061FB70
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int constructor(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataThearchyTrialLevelInfo o = new ConfigDataThearchyTrialLevelInfo();
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

	// Token: 0x06016E17 RID: 93719 RVA: 0x006219B8 File Offset: 0x0061FBB8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_battleInfo(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataThearchyTrialLevelInfo configDataThearchyTrialLevelInfo = (ConfigDataThearchyTrialLevelInfo)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, configDataThearchyTrialLevelInfo.m_battleInfo);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06016E18 RID: 93720 RVA: 0x00621A0C File Offset: 0x0061FC0C
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_m_battleInfo(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataThearchyTrialLevelInfo configDataThearchyTrialLevelInfo = (ConfigDataThearchyTrialLevelInfo)LuaObject.checkSelf(l);
			ConfigDataBattleInfo battleInfo;
			LuaObject.checkType<ConfigDataBattleInfo>(l, 2, out battleInfo);
			configDataThearchyTrialLevelInfo.m_battleInfo = battleInfo;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06016E19 RID: 93721 RVA: 0x00621A64 File Offset: 0x0061FC64
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_m_groupInfo(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataThearchyTrialLevelInfo configDataThearchyTrialLevelInfo = (ConfigDataThearchyTrialLevelInfo)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, configDataThearchyTrialLevelInfo.m_groupInfo);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06016E1A RID: 93722 RVA: 0x00621AB8 File Offset: 0x0061FCB8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_groupInfo(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataThearchyTrialLevelInfo configDataThearchyTrialLevelInfo = (ConfigDataThearchyTrialLevelInfo)LuaObject.checkSelf(l);
			ConfigDataThearchyTrialInfo groupInfo;
			LuaObject.checkType<ConfigDataThearchyTrialInfo>(l, 2, out groupInfo);
			configDataThearchyTrialLevelInfo.m_groupInfo = groupInfo;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06016E1B RID: 93723 RVA: 0x00621B10 File Offset: 0x0061FD10
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_randomDropInfo(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataThearchyTrialLevelInfo configDataThearchyTrialLevelInfo = (ConfigDataThearchyTrialLevelInfo)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, configDataThearchyTrialLevelInfo.m_randomDropInfo);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06016E1C RID: 93724 RVA: 0x00621B64 File Offset: 0x0061FD64
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_randomDropInfo(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataThearchyTrialLevelInfo configDataThearchyTrialLevelInfo = (ConfigDataThearchyTrialLevelInfo)LuaObject.checkSelf(l);
			ConfigDataRandomDropRewardInfo randomDropInfo;
			LuaObject.checkType<ConfigDataRandomDropRewardInfo>(l, 2, out randomDropInfo);
			configDataThearchyTrialLevelInfo.m_randomDropInfo = randomDropInfo;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06016E1D RID: 93725 RVA: 0x00621BBC File Offset: 0x0061FDBC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_activityRandomDropInfo(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataThearchyTrialLevelInfo configDataThearchyTrialLevelInfo = (ConfigDataThearchyTrialLevelInfo)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, configDataThearchyTrialLevelInfo.m_activityRandomDropInfo);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06016E1E RID: 93726 RVA: 0x00621C10 File Offset: 0x0061FE10
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_activityRandomDropInfo(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataThearchyTrialLevelInfo configDataThearchyTrialLevelInfo = (ConfigDataThearchyTrialLevelInfo)LuaObject.checkSelf(l);
			ConfigDataRandomDropRewardInfo activityRandomDropInfo;
			LuaObject.checkType<ConfigDataRandomDropRewardInfo>(l, 2, out activityRandomDropInfo);
			configDataThearchyTrialLevelInfo.m_activityRandomDropInfo = activityRandomDropInfo;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06016E1F RID: 93727 RVA: 0x00621C68 File Offset: 0x0061FE68
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_ID(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataThearchyTrialLevelInfo configDataThearchyTrialLevelInfo = (ConfigDataThearchyTrialLevelInfo)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, configDataThearchyTrialLevelInfo.ID);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06016E20 RID: 93728 RVA: 0x00621CBC File Offset: 0x0061FEBC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_ID(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataThearchyTrialLevelInfo configDataThearchyTrialLevelInfo = (ConfigDataThearchyTrialLevelInfo)LuaObject.checkSelf(l);
			int id;
			LuaObject.checkType(l, 2, out id);
			configDataThearchyTrialLevelInfo.ID = id;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06016E21 RID: 93729 RVA: 0x00621D14 File Offset: 0x0061FF14
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_Name(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataThearchyTrialLevelInfo configDataThearchyTrialLevelInfo = (ConfigDataThearchyTrialLevelInfo)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, configDataThearchyTrialLevelInfo.Name);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06016E22 RID: 93730 RVA: 0x00621D68 File Offset: 0x0061FF68
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_Name(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataThearchyTrialLevelInfo configDataThearchyTrialLevelInfo = (ConfigDataThearchyTrialLevelInfo)LuaObject.checkSelf(l);
			string name;
			LuaObject.checkType(l, 2, out name);
			configDataThearchyTrialLevelInfo.Name = name;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06016E23 RID: 93731 RVA: 0x00621DC0 File Offset: 0x0061FFC0
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_TeamName(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataThearchyTrialLevelInfo configDataThearchyTrialLevelInfo = (ConfigDataThearchyTrialLevelInfo)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, configDataThearchyTrialLevelInfo.TeamName);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06016E24 RID: 93732 RVA: 0x00621E14 File Offset: 0x00620014
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_TeamName(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataThearchyTrialLevelInfo configDataThearchyTrialLevelInfo = (ConfigDataThearchyTrialLevelInfo)LuaObject.checkSelf(l);
			string teamName;
			LuaObject.checkType(l, 2, out teamName);
			configDataThearchyTrialLevelInfo.TeamName = teamName;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06016E25 RID: 93733 RVA: 0x00621E6C File Offset: 0x0062006C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_PreLevel(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataThearchyTrialLevelInfo configDataThearchyTrialLevelInfo = (ConfigDataThearchyTrialLevelInfo)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, configDataThearchyTrialLevelInfo.PreLevel);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06016E26 RID: 93734 RVA: 0x00621EC0 File Offset: 0x006200C0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_PreLevel(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataThearchyTrialLevelInfo configDataThearchyTrialLevelInfo = (ConfigDataThearchyTrialLevelInfo)LuaObject.checkSelf(l);
			int preLevel;
			LuaObject.checkType(l, 2, out preLevel);
			configDataThearchyTrialLevelInfo.PreLevel = preLevel;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06016E27 RID: 93735 RVA: 0x00621F18 File Offset: 0x00620118
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_TicketCost(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataThearchyTrialLevelInfo configDataThearchyTrialLevelInfo = (ConfigDataThearchyTrialLevelInfo)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, configDataThearchyTrialLevelInfo.TicketCost);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06016E28 RID: 93736 RVA: 0x00621F6C File Offset: 0x0062016C
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_TicketCost(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataThearchyTrialLevelInfo configDataThearchyTrialLevelInfo = (ConfigDataThearchyTrialLevelInfo)LuaObject.checkSelf(l);
			int ticketCost;
			LuaObject.checkType(l, 2, out ticketCost);
			configDataThearchyTrialLevelInfo.TicketCost = ticketCost;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06016E29 RID: 93737 RVA: 0x00621FC4 File Offset: 0x006201C4
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_EnergySuccess(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataThearchyTrialLevelInfo configDataThearchyTrialLevelInfo = (ConfigDataThearchyTrialLevelInfo)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, configDataThearchyTrialLevelInfo.EnergySuccess);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06016E2A RID: 93738 RVA: 0x00622018 File Offset: 0x00620218
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_EnergySuccess(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataThearchyTrialLevelInfo configDataThearchyTrialLevelInfo = (ConfigDataThearchyTrialLevelInfo)LuaObject.checkSelf(l);
			int energySuccess;
			LuaObject.checkType(l, 2, out energySuccess);
			configDataThearchyTrialLevelInfo.EnergySuccess = energySuccess;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06016E2B RID: 93739 RVA: 0x00622070 File Offset: 0x00620270
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_EnergyFail(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataThearchyTrialLevelInfo configDataThearchyTrialLevelInfo = (ConfigDataThearchyTrialLevelInfo)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, configDataThearchyTrialLevelInfo.EnergyFail);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06016E2C RID: 93740 RVA: 0x006220C4 File Offset: 0x006202C4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_EnergyFail(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataThearchyTrialLevelInfo configDataThearchyTrialLevelInfo = (ConfigDataThearchyTrialLevelInfo)LuaObject.checkSelf(l);
			int energyFail;
			LuaObject.checkType(l, 2, out energyFail);
			configDataThearchyTrialLevelInfo.EnergyFail = energyFail;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06016E2D RID: 93741 RVA: 0x0062211C File Offset: 0x0062031C
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_TeamEnergyCost(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataThearchyTrialLevelInfo configDataThearchyTrialLevelInfo = (ConfigDataThearchyTrialLevelInfo)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, configDataThearchyTrialLevelInfo.TeamEnergyCost);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06016E2E RID: 93742 RVA: 0x00622170 File Offset: 0x00620370
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_TeamEnergyCost(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataThearchyTrialLevelInfo configDataThearchyTrialLevelInfo = (ConfigDataThearchyTrialLevelInfo)LuaObject.checkSelf(l);
			int teamEnergyCost;
			LuaObject.checkType(l, 2, out teamEnergyCost);
			configDataThearchyTrialLevelInfo.TeamEnergyCost = teamEnergyCost;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06016E2F RID: 93743 RVA: 0x006221C8 File Offset: 0x006203C8
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_MonsterLevel(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataThearchyTrialLevelInfo configDataThearchyTrialLevelInfo = (ConfigDataThearchyTrialLevelInfo)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, configDataThearchyTrialLevelInfo.MonsterLevel);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06016E30 RID: 93744 RVA: 0x0062221C File Offset: 0x0062041C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_MonsterLevel(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataThearchyTrialLevelInfo configDataThearchyTrialLevelInfo = (ConfigDataThearchyTrialLevelInfo)LuaObject.checkSelf(l);
			int monsterLevel;
			LuaObject.checkType(l, 2, out monsterLevel);
			configDataThearchyTrialLevelInfo.MonsterLevel = monsterLevel;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06016E31 RID: 93745 RVA: 0x00622274 File Offset: 0x00620474
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_Battle_ID(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataThearchyTrialLevelInfo configDataThearchyTrialLevelInfo = (ConfigDataThearchyTrialLevelInfo)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, configDataThearchyTrialLevelInfo.Battle_ID);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06016E32 RID: 93746 RVA: 0x006222C8 File Offset: 0x006204C8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_Battle_ID(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataThearchyTrialLevelInfo configDataThearchyTrialLevelInfo = (ConfigDataThearchyTrialLevelInfo)LuaObject.checkSelf(l);
			int battle_ID;
			LuaObject.checkType(l, 2, out battle_ID);
			configDataThearchyTrialLevelInfo.Battle_ID = battle_ID;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06016E33 RID: 93747 RVA: 0x00622320 File Offset: 0x00620520
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_PlayerExp(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataThearchyTrialLevelInfo configDataThearchyTrialLevelInfo = (ConfigDataThearchyTrialLevelInfo)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, configDataThearchyTrialLevelInfo.PlayerExp);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06016E34 RID: 93748 RVA: 0x00622374 File Offset: 0x00620574
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_PlayerExp(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataThearchyTrialLevelInfo configDataThearchyTrialLevelInfo = (ConfigDataThearchyTrialLevelInfo)LuaObject.checkSelf(l);
			int playerExp;
			LuaObject.checkType(l, 2, out playerExp);
			configDataThearchyTrialLevelInfo.PlayerExp = playerExp;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06016E35 RID: 93749 RVA: 0x006223CC File Offset: 0x006205CC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_HeroExp(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataThearchyTrialLevelInfo configDataThearchyTrialLevelInfo = (ConfigDataThearchyTrialLevelInfo)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, configDataThearchyTrialLevelInfo.HeroExp);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06016E36 RID: 93750 RVA: 0x00622420 File Offset: 0x00620620
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_HeroExp(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataThearchyTrialLevelInfo configDataThearchyTrialLevelInfo = (ConfigDataThearchyTrialLevelInfo)LuaObject.checkSelf(l);
			int heroExp;
			LuaObject.checkType(l, 2, out heroExp);
			configDataThearchyTrialLevelInfo.HeroExp = heroExp;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06016E37 RID: 93751 RVA: 0x00622478 File Offset: 0x00620678
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_Gold(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataThearchyTrialLevelInfo configDataThearchyTrialLevelInfo = (ConfigDataThearchyTrialLevelInfo)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, configDataThearchyTrialLevelInfo.Gold);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06016E38 RID: 93752 RVA: 0x006224CC File Offset: 0x006206CC
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_Gold(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataThearchyTrialLevelInfo configDataThearchyTrialLevelInfo = (ConfigDataThearchyTrialLevelInfo)LuaObject.checkSelf(l);
			int gold;
			LuaObject.checkType(l, 2, out gold);
			configDataThearchyTrialLevelInfo.Gold = gold;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06016E39 RID: 93753 RVA: 0x00622524 File Offset: 0x00620724
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_Drop_ID(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataThearchyTrialLevelInfo configDataThearchyTrialLevelInfo = (ConfigDataThearchyTrialLevelInfo)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, configDataThearchyTrialLevelInfo.Drop_ID);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06016E3A RID: 93754 RVA: 0x00622578 File Offset: 0x00620778
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_Drop_ID(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataThearchyTrialLevelInfo configDataThearchyTrialLevelInfo = (ConfigDataThearchyTrialLevelInfo)LuaObject.checkSelf(l);
			int drop_ID;
			LuaObject.checkType(l, 2, out drop_ID);
			configDataThearchyTrialLevelInfo.Drop_ID = drop_ID;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06016E3B RID: 93755 RVA: 0x006225D0 File Offset: 0x006207D0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_TeamDrop_ID(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataThearchyTrialLevelInfo configDataThearchyTrialLevelInfo = (ConfigDataThearchyTrialLevelInfo)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, configDataThearchyTrialLevelInfo.TeamDrop_ID);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06016E3C RID: 93756 RVA: 0x00622624 File Offset: 0x00620824
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_TeamDrop_ID(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataThearchyTrialLevelInfo configDataThearchyTrialLevelInfo = (ConfigDataThearchyTrialLevelInfo)LuaObject.checkSelf(l);
			int teamDrop_ID;
			LuaObject.checkType(l, 2, out teamDrop_ID);
			configDataThearchyTrialLevelInfo.TeamDrop_ID = teamDrop_ID;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06016E3D RID: 93757 RVA: 0x0062267C File Offset: 0x0062087C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_OperationalActivityDrop_ID(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataThearchyTrialLevelInfo configDataThearchyTrialLevelInfo = (ConfigDataThearchyTrialLevelInfo)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, configDataThearchyTrialLevelInfo.OperationalActivityDrop_ID);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06016E3E RID: 93758 RVA: 0x006226D0 File Offset: 0x006208D0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_OperationalActivityDrop_ID(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataThearchyTrialLevelInfo configDataThearchyTrialLevelInfo = (ConfigDataThearchyTrialLevelInfo)LuaObject.checkSelf(l);
			int operationalActivityDrop_ID;
			LuaObject.checkType(l, 2, out operationalActivityDrop_ID);
			configDataThearchyTrialLevelInfo.OperationalActivityDrop_ID = operationalActivityDrop_ID;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06016E3F RID: 93759 RVA: 0x00622728 File Offset: 0x00620928
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_DayBonusDrop_ID(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataThearchyTrialLevelInfo configDataThearchyTrialLevelInfo = (ConfigDataThearchyTrialLevelInfo)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, configDataThearchyTrialLevelInfo.DayBonusDrop_ID);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06016E40 RID: 93760 RVA: 0x0062277C File Offset: 0x0062097C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_DayBonusDrop_ID(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataThearchyTrialLevelInfo configDataThearchyTrialLevelInfo = (ConfigDataThearchyTrialLevelInfo)LuaObject.checkSelf(l);
			int dayBonusDrop_ID;
			LuaObject.checkType(l, 2, out dayBonusDrop_ID);
			configDataThearchyTrialLevelInfo.DayBonusDrop_ID = dayBonusDrop_ID;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06016E41 RID: 93761 RVA: 0x006227D4 File Offset: 0x006209D4
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_DisplayRewardCount(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataThearchyTrialLevelInfo configDataThearchyTrialLevelInfo = (ConfigDataThearchyTrialLevelInfo)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, configDataThearchyTrialLevelInfo.DisplayRewardCount);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06016E42 RID: 93762 RVA: 0x00622828 File Offset: 0x00620A28
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_DisplayRewardCount(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataThearchyTrialLevelInfo configDataThearchyTrialLevelInfo = (ConfigDataThearchyTrialLevelInfo)LuaObject.checkSelf(l);
			int displayRewardCount;
			LuaObject.checkType(l, 2, out displayRewardCount);
			configDataThearchyTrialLevelInfo.DisplayRewardCount = displayRewardCount;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06016E43 RID: 93763 RVA: 0x00622880 File Offset: 0x00620A80
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_Icon(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataThearchyTrialLevelInfo configDataThearchyTrialLevelInfo = (ConfigDataThearchyTrialLevelInfo)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, configDataThearchyTrialLevelInfo.Icon);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06016E44 RID: 93764 RVA: 0x006228D4 File Offset: 0x00620AD4
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_Icon(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataThearchyTrialLevelInfo configDataThearchyTrialLevelInfo = (ConfigDataThearchyTrialLevelInfo)LuaObject.checkSelf(l);
			string icon;
			LuaObject.checkType(l, 2, out icon);
			configDataThearchyTrialLevelInfo.Icon = icon;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06016E45 RID: 93765 RVA: 0x0062292C File Offset: 0x00620B2C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_Strategy(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataThearchyTrialLevelInfo configDataThearchyTrialLevelInfo = (ConfigDataThearchyTrialLevelInfo)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, configDataThearchyTrialLevelInfo.Strategy);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06016E46 RID: 93766 RVA: 0x00622980 File Offset: 0x00620B80
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_Strategy(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataThearchyTrialLevelInfo configDataThearchyTrialLevelInfo = (ConfigDataThearchyTrialLevelInfo)LuaObject.checkSelf(l);
			string strategy;
			LuaObject.checkType(l, 2, out strategy);
			configDataThearchyTrialLevelInfo.Strategy = strategy;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06016E47 RID: 93767 RVA: 0x006229D8 File Offset: 0x00620BD8
	[Preserve]
	public static void reg(IntPtr l)
	{
		LuaObject.getTypeTable(l, "BlackJack.ConfigData.ConfigDataThearchyTrialLevelInfo");
		string name = "m_battleInfo";
		if (Lua_BlackJack_ConfigData_ConfigDataThearchyTrialLevelInfo.<>f__mg$cache0 == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataThearchyTrialLevelInfo.<>f__mg$cache0 = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataThearchyTrialLevelInfo.get_m_battleInfo);
		}
		LuaCSFunction get = Lua_BlackJack_ConfigData_ConfigDataThearchyTrialLevelInfo.<>f__mg$cache0;
		if (Lua_BlackJack_ConfigData_ConfigDataThearchyTrialLevelInfo.<>f__mg$cache1 == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataThearchyTrialLevelInfo.<>f__mg$cache1 = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataThearchyTrialLevelInfo.set_m_battleInfo);
		}
		LuaObject.addMember(l, name, get, Lua_BlackJack_ConfigData_ConfigDataThearchyTrialLevelInfo.<>f__mg$cache1, true);
		string name2 = "m_groupInfo";
		if (Lua_BlackJack_ConfigData_ConfigDataThearchyTrialLevelInfo.<>f__mg$cache2 == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataThearchyTrialLevelInfo.<>f__mg$cache2 = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataThearchyTrialLevelInfo.get_m_groupInfo);
		}
		LuaCSFunction get2 = Lua_BlackJack_ConfigData_ConfigDataThearchyTrialLevelInfo.<>f__mg$cache2;
		if (Lua_BlackJack_ConfigData_ConfigDataThearchyTrialLevelInfo.<>f__mg$cache3 == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataThearchyTrialLevelInfo.<>f__mg$cache3 = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataThearchyTrialLevelInfo.set_m_groupInfo);
		}
		LuaObject.addMember(l, name2, get2, Lua_BlackJack_ConfigData_ConfigDataThearchyTrialLevelInfo.<>f__mg$cache3, true);
		string name3 = "m_randomDropInfo";
		if (Lua_BlackJack_ConfigData_ConfigDataThearchyTrialLevelInfo.<>f__mg$cache4 == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataThearchyTrialLevelInfo.<>f__mg$cache4 = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataThearchyTrialLevelInfo.get_m_randomDropInfo);
		}
		LuaCSFunction get3 = Lua_BlackJack_ConfigData_ConfigDataThearchyTrialLevelInfo.<>f__mg$cache4;
		if (Lua_BlackJack_ConfigData_ConfigDataThearchyTrialLevelInfo.<>f__mg$cache5 == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataThearchyTrialLevelInfo.<>f__mg$cache5 = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataThearchyTrialLevelInfo.set_m_randomDropInfo);
		}
		LuaObject.addMember(l, name3, get3, Lua_BlackJack_ConfigData_ConfigDataThearchyTrialLevelInfo.<>f__mg$cache5, true);
		string name4 = "m_activityRandomDropInfo";
		if (Lua_BlackJack_ConfigData_ConfigDataThearchyTrialLevelInfo.<>f__mg$cache6 == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataThearchyTrialLevelInfo.<>f__mg$cache6 = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataThearchyTrialLevelInfo.get_m_activityRandomDropInfo);
		}
		LuaCSFunction get4 = Lua_BlackJack_ConfigData_ConfigDataThearchyTrialLevelInfo.<>f__mg$cache6;
		if (Lua_BlackJack_ConfigData_ConfigDataThearchyTrialLevelInfo.<>f__mg$cache7 == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataThearchyTrialLevelInfo.<>f__mg$cache7 = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataThearchyTrialLevelInfo.set_m_activityRandomDropInfo);
		}
		LuaObject.addMember(l, name4, get4, Lua_BlackJack_ConfigData_ConfigDataThearchyTrialLevelInfo.<>f__mg$cache7, true);
		string name5 = "ID";
		if (Lua_BlackJack_ConfigData_ConfigDataThearchyTrialLevelInfo.<>f__mg$cache8 == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataThearchyTrialLevelInfo.<>f__mg$cache8 = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataThearchyTrialLevelInfo.get_ID);
		}
		LuaCSFunction get5 = Lua_BlackJack_ConfigData_ConfigDataThearchyTrialLevelInfo.<>f__mg$cache8;
		if (Lua_BlackJack_ConfigData_ConfigDataThearchyTrialLevelInfo.<>f__mg$cache9 == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataThearchyTrialLevelInfo.<>f__mg$cache9 = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataThearchyTrialLevelInfo.set_ID);
		}
		LuaObject.addMember(l, name5, get5, Lua_BlackJack_ConfigData_ConfigDataThearchyTrialLevelInfo.<>f__mg$cache9, true);
		string name6 = "Name";
		if (Lua_BlackJack_ConfigData_ConfigDataThearchyTrialLevelInfo.<>f__mg$cacheA == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataThearchyTrialLevelInfo.<>f__mg$cacheA = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataThearchyTrialLevelInfo.get_Name);
		}
		LuaCSFunction get6 = Lua_BlackJack_ConfigData_ConfigDataThearchyTrialLevelInfo.<>f__mg$cacheA;
		if (Lua_BlackJack_ConfigData_ConfigDataThearchyTrialLevelInfo.<>f__mg$cacheB == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataThearchyTrialLevelInfo.<>f__mg$cacheB = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataThearchyTrialLevelInfo.set_Name);
		}
		LuaObject.addMember(l, name6, get6, Lua_BlackJack_ConfigData_ConfigDataThearchyTrialLevelInfo.<>f__mg$cacheB, true);
		string name7 = "TeamName";
		if (Lua_BlackJack_ConfigData_ConfigDataThearchyTrialLevelInfo.<>f__mg$cacheC == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataThearchyTrialLevelInfo.<>f__mg$cacheC = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataThearchyTrialLevelInfo.get_TeamName);
		}
		LuaCSFunction get7 = Lua_BlackJack_ConfigData_ConfigDataThearchyTrialLevelInfo.<>f__mg$cacheC;
		if (Lua_BlackJack_ConfigData_ConfigDataThearchyTrialLevelInfo.<>f__mg$cacheD == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataThearchyTrialLevelInfo.<>f__mg$cacheD = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataThearchyTrialLevelInfo.set_TeamName);
		}
		LuaObject.addMember(l, name7, get7, Lua_BlackJack_ConfigData_ConfigDataThearchyTrialLevelInfo.<>f__mg$cacheD, true);
		string name8 = "PreLevel";
		if (Lua_BlackJack_ConfigData_ConfigDataThearchyTrialLevelInfo.<>f__mg$cacheE == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataThearchyTrialLevelInfo.<>f__mg$cacheE = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataThearchyTrialLevelInfo.get_PreLevel);
		}
		LuaCSFunction get8 = Lua_BlackJack_ConfigData_ConfigDataThearchyTrialLevelInfo.<>f__mg$cacheE;
		if (Lua_BlackJack_ConfigData_ConfigDataThearchyTrialLevelInfo.<>f__mg$cacheF == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataThearchyTrialLevelInfo.<>f__mg$cacheF = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataThearchyTrialLevelInfo.set_PreLevel);
		}
		LuaObject.addMember(l, name8, get8, Lua_BlackJack_ConfigData_ConfigDataThearchyTrialLevelInfo.<>f__mg$cacheF, true);
		string name9 = "TicketCost";
		if (Lua_BlackJack_ConfigData_ConfigDataThearchyTrialLevelInfo.<>f__mg$cache10 == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataThearchyTrialLevelInfo.<>f__mg$cache10 = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataThearchyTrialLevelInfo.get_TicketCost);
		}
		LuaCSFunction get9 = Lua_BlackJack_ConfigData_ConfigDataThearchyTrialLevelInfo.<>f__mg$cache10;
		if (Lua_BlackJack_ConfigData_ConfigDataThearchyTrialLevelInfo.<>f__mg$cache11 == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataThearchyTrialLevelInfo.<>f__mg$cache11 = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataThearchyTrialLevelInfo.set_TicketCost);
		}
		LuaObject.addMember(l, name9, get9, Lua_BlackJack_ConfigData_ConfigDataThearchyTrialLevelInfo.<>f__mg$cache11, true);
		string name10 = "EnergySuccess";
		if (Lua_BlackJack_ConfigData_ConfigDataThearchyTrialLevelInfo.<>f__mg$cache12 == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataThearchyTrialLevelInfo.<>f__mg$cache12 = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataThearchyTrialLevelInfo.get_EnergySuccess);
		}
		LuaCSFunction get10 = Lua_BlackJack_ConfigData_ConfigDataThearchyTrialLevelInfo.<>f__mg$cache12;
		if (Lua_BlackJack_ConfigData_ConfigDataThearchyTrialLevelInfo.<>f__mg$cache13 == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataThearchyTrialLevelInfo.<>f__mg$cache13 = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataThearchyTrialLevelInfo.set_EnergySuccess);
		}
		LuaObject.addMember(l, name10, get10, Lua_BlackJack_ConfigData_ConfigDataThearchyTrialLevelInfo.<>f__mg$cache13, true);
		string name11 = "EnergyFail";
		if (Lua_BlackJack_ConfigData_ConfigDataThearchyTrialLevelInfo.<>f__mg$cache14 == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataThearchyTrialLevelInfo.<>f__mg$cache14 = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataThearchyTrialLevelInfo.get_EnergyFail);
		}
		LuaCSFunction get11 = Lua_BlackJack_ConfigData_ConfigDataThearchyTrialLevelInfo.<>f__mg$cache14;
		if (Lua_BlackJack_ConfigData_ConfigDataThearchyTrialLevelInfo.<>f__mg$cache15 == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataThearchyTrialLevelInfo.<>f__mg$cache15 = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataThearchyTrialLevelInfo.set_EnergyFail);
		}
		LuaObject.addMember(l, name11, get11, Lua_BlackJack_ConfigData_ConfigDataThearchyTrialLevelInfo.<>f__mg$cache15, true);
		string name12 = "TeamEnergyCost";
		if (Lua_BlackJack_ConfigData_ConfigDataThearchyTrialLevelInfo.<>f__mg$cache16 == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataThearchyTrialLevelInfo.<>f__mg$cache16 = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataThearchyTrialLevelInfo.get_TeamEnergyCost);
		}
		LuaCSFunction get12 = Lua_BlackJack_ConfigData_ConfigDataThearchyTrialLevelInfo.<>f__mg$cache16;
		if (Lua_BlackJack_ConfigData_ConfigDataThearchyTrialLevelInfo.<>f__mg$cache17 == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataThearchyTrialLevelInfo.<>f__mg$cache17 = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataThearchyTrialLevelInfo.set_TeamEnergyCost);
		}
		LuaObject.addMember(l, name12, get12, Lua_BlackJack_ConfigData_ConfigDataThearchyTrialLevelInfo.<>f__mg$cache17, true);
		string name13 = "MonsterLevel";
		if (Lua_BlackJack_ConfigData_ConfigDataThearchyTrialLevelInfo.<>f__mg$cache18 == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataThearchyTrialLevelInfo.<>f__mg$cache18 = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataThearchyTrialLevelInfo.get_MonsterLevel);
		}
		LuaCSFunction get13 = Lua_BlackJack_ConfigData_ConfigDataThearchyTrialLevelInfo.<>f__mg$cache18;
		if (Lua_BlackJack_ConfigData_ConfigDataThearchyTrialLevelInfo.<>f__mg$cache19 == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataThearchyTrialLevelInfo.<>f__mg$cache19 = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataThearchyTrialLevelInfo.set_MonsterLevel);
		}
		LuaObject.addMember(l, name13, get13, Lua_BlackJack_ConfigData_ConfigDataThearchyTrialLevelInfo.<>f__mg$cache19, true);
		string name14 = "Battle_ID";
		if (Lua_BlackJack_ConfigData_ConfigDataThearchyTrialLevelInfo.<>f__mg$cache1A == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataThearchyTrialLevelInfo.<>f__mg$cache1A = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataThearchyTrialLevelInfo.get_Battle_ID);
		}
		LuaCSFunction get14 = Lua_BlackJack_ConfigData_ConfigDataThearchyTrialLevelInfo.<>f__mg$cache1A;
		if (Lua_BlackJack_ConfigData_ConfigDataThearchyTrialLevelInfo.<>f__mg$cache1B == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataThearchyTrialLevelInfo.<>f__mg$cache1B = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataThearchyTrialLevelInfo.set_Battle_ID);
		}
		LuaObject.addMember(l, name14, get14, Lua_BlackJack_ConfigData_ConfigDataThearchyTrialLevelInfo.<>f__mg$cache1B, true);
		string name15 = "PlayerExp";
		if (Lua_BlackJack_ConfigData_ConfigDataThearchyTrialLevelInfo.<>f__mg$cache1C == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataThearchyTrialLevelInfo.<>f__mg$cache1C = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataThearchyTrialLevelInfo.get_PlayerExp);
		}
		LuaCSFunction get15 = Lua_BlackJack_ConfigData_ConfigDataThearchyTrialLevelInfo.<>f__mg$cache1C;
		if (Lua_BlackJack_ConfigData_ConfigDataThearchyTrialLevelInfo.<>f__mg$cache1D == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataThearchyTrialLevelInfo.<>f__mg$cache1D = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataThearchyTrialLevelInfo.set_PlayerExp);
		}
		LuaObject.addMember(l, name15, get15, Lua_BlackJack_ConfigData_ConfigDataThearchyTrialLevelInfo.<>f__mg$cache1D, true);
		string name16 = "HeroExp";
		if (Lua_BlackJack_ConfigData_ConfigDataThearchyTrialLevelInfo.<>f__mg$cache1E == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataThearchyTrialLevelInfo.<>f__mg$cache1E = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataThearchyTrialLevelInfo.get_HeroExp);
		}
		LuaCSFunction get16 = Lua_BlackJack_ConfigData_ConfigDataThearchyTrialLevelInfo.<>f__mg$cache1E;
		if (Lua_BlackJack_ConfigData_ConfigDataThearchyTrialLevelInfo.<>f__mg$cache1F == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataThearchyTrialLevelInfo.<>f__mg$cache1F = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataThearchyTrialLevelInfo.set_HeroExp);
		}
		LuaObject.addMember(l, name16, get16, Lua_BlackJack_ConfigData_ConfigDataThearchyTrialLevelInfo.<>f__mg$cache1F, true);
		string name17 = "Gold";
		if (Lua_BlackJack_ConfigData_ConfigDataThearchyTrialLevelInfo.<>f__mg$cache20 == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataThearchyTrialLevelInfo.<>f__mg$cache20 = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataThearchyTrialLevelInfo.get_Gold);
		}
		LuaCSFunction get17 = Lua_BlackJack_ConfigData_ConfigDataThearchyTrialLevelInfo.<>f__mg$cache20;
		if (Lua_BlackJack_ConfigData_ConfigDataThearchyTrialLevelInfo.<>f__mg$cache21 == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataThearchyTrialLevelInfo.<>f__mg$cache21 = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataThearchyTrialLevelInfo.set_Gold);
		}
		LuaObject.addMember(l, name17, get17, Lua_BlackJack_ConfigData_ConfigDataThearchyTrialLevelInfo.<>f__mg$cache21, true);
		string name18 = "Drop_ID";
		if (Lua_BlackJack_ConfigData_ConfigDataThearchyTrialLevelInfo.<>f__mg$cache22 == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataThearchyTrialLevelInfo.<>f__mg$cache22 = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataThearchyTrialLevelInfo.get_Drop_ID);
		}
		LuaCSFunction get18 = Lua_BlackJack_ConfigData_ConfigDataThearchyTrialLevelInfo.<>f__mg$cache22;
		if (Lua_BlackJack_ConfigData_ConfigDataThearchyTrialLevelInfo.<>f__mg$cache23 == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataThearchyTrialLevelInfo.<>f__mg$cache23 = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataThearchyTrialLevelInfo.set_Drop_ID);
		}
		LuaObject.addMember(l, name18, get18, Lua_BlackJack_ConfigData_ConfigDataThearchyTrialLevelInfo.<>f__mg$cache23, true);
		string name19 = "TeamDrop_ID";
		if (Lua_BlackJack_ConfigData_ConfigDataThearchyTrialLevelInfo.<>f__mg$cache24 == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataThearchyTrialLevelInfo.<>f__mg$cache24 = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataThearchyTrialLevelInfo.get_TeamDrop_ID);
		}
		LuaCSFunction get19 = Lua_BlackJack_ConfigData_ConfigDataThearchyTrialLevelInfo.<>f__mg$cache24;
		if (Lua_BlackJack_ConfigData_ConfigDataThearchyTrialLevelInfo.<>f__mg$cache25 == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataThearchyTrialLevelInfo.<>f__mg$cache25 = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataThearchyTrialLevelInfo.set_TeamDrop_ID);
		}
		LuaObject.addMember(l, name19, get19, Lua_BlackJack_ConfigData_ConfigDataThearchyTrialLevelInfo.<>f__mg$cache25, true);
		string name20 = "OperationalActivityDrop_ID";
		if (Lua_BlackJack_ConfigData_ConfigDataThearchyTrialLevelInfo.<>f__mg$cache26 == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataThearchyTrialLevelInfo.<>f__mg$cache26 = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataThearchyTrialLevelInfo.get_OperationalActivityDrop_ID);
		}
		LuaCSFunction get20 = Lua_BlackJack_ConfigData_ConfigDataThearchyTrialLevelInfo.<>f__mg$cache26;
		if (Lua_BlackJack_ConfigData_ConfigDataThearchyTrialLevelInfo.<>f__mg$cache27 == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataThearchyTrialLevelInfo.<>f__mg$cache27 = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataThearchyTrialLevelInfo.set_OperationalActivityDrop_ID);
		}
		LuaObject.addMember(l, name20, get20, Lua_BlackJack_ConfigData_ConfigDataThearchyTrialLevelInfo.<>f__mg$cache27, true);
		string name21 = "DayBonusDrop_ID";
		if (Lua_BlackJack_ConfigData_ConfigDataThearchyTrialLevelInfo.<>f__mg$cache28 == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataThearchyTrialLevelInfo.<>f__mg$cache28 = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataThearchyTrialLevelInfo.get_DayBonusDrop_ID);
		}
		LuaCSFunction get21 = Lua_BlackJack_ConfigData_ConfigDataThearchyTrialLevelInfo.<>f__mg$cache28;
		if (Lua_BlackJack_ConfigData_ConfigDataThearchyTrialLevelInfo.<>f__mg$cache29 == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataThearchyTrialLevelInfo.<>f__mg$cache29 = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataThearchyTrialLevelInfo.set_DayBonusDrop_ID);
		}
		LuaObject.addMember(l, name21, get21, Lua_BlackJack_ConfigData_ConfigDataThearchyTrialLevelInfo.<>f__mg$cache29, true);
		string name22 = "DisplayRewardCount";
		if (Lua_BlackJack_ConfigData_ConfigDataThearchyTrialLevelInfo.<>f__mg$cache2A == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataThearchyTrialLevelInfo.<>f__mg$cache2A = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataThearchyTrialLevelInfo.get_DisplayRewardCount);
		}
		LuaCSFunction get22 = Lua_BlackJack_ConfigData_ConfigDataThearchyTrialLevelInfo.<>f__mg$cache2A;
		if (Lua_BlackJack_ConfigData_ConfigDataThearchyTrialLevelInfo.<>f__mg$cache2B == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataThearchyTrialLevelInfo.<>f__mg$cache2B = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataThearchyTrialLevelInfo.set_DisplayRewardCount);
		}
		LuaObject.addMember(l, name22, get22, Lua_BlackJack_ConfigData_ConfigDataThearchyTrialLevelInfo.<>f__mg$cache2B, true);
		string name23 = "Icon";
		if (Lua_BlackJack_ConfigData_ConfigDataThearchyTrialLevelInfo.<>f__mg$cache2C == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataThearchyTrialLevelInfo.<>f__mg$cache2C = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataThearchyTrialLevelInfo.get_Icon);
		}
		LuaCSFunction get23 = Lua_BlackJack_ConfigData_ConfigDataThearchyTrialLevelInfo.<>f__mg$cache2C;
		if (Lua_BlackJack_ConfigData_ConfigDataThearchyTrialLevelInfo.<>f__mg$cache2D == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataThearchyTrialLevelInfo.<>f__mg$cache2D = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataThearchyTrialLevelInfo.set_Icon);
		}
		LuaObject.addMember(l, name23, get23, Lua_BlackJack_ConfigData_ConfigDataThearchyTrialLevelInfo.<>f__mg$cache2D, true);
		string name24 = "Strategy";
		if (Lua_BlackJack_ConfigData_ConfigDataThearchyTrialLevelInfo.<>f__mg$cache2E == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataThearchyTrialLevelInfo.<>f__mg$cache2E = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataThearchyTrialLevelInfo.get_Strategy);
		}
		LuaCSFunction get24 = Lua_BlackJack_ConfigData_ConfigDataThearchyTrialLevelInfo.<>f__mg$cache2E;
		if (Lua_BlackJack_ConfigData_ConfigDataThearchyTrialLevelInfo.<>f__mg$cache2F == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataThearchyTrialLevelInfo.<>f__mg$cache2F = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataThearchyTrialLevelInfo.set_Strategy);
		}
		LuaObject.addMember(l, name24, get24, Lua_BlackJack_ConfigData_ConfigDataThearchyTrialLevelInfo.<>f__mg$cache2F, true);
		if (Lua_BlackJack_ConfigData_ConfigDataThearchyTrialLevelInfo.<>f__mg$cache30 == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataThearchyTrialLevelInfo.<>f__mg$cache30 = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataThearchyTrialLevelInfo.constructor);
		}
		LuaObject.createTypeMetatable(l, Lua_BlackJack_ConfigData_ConfigDataThearchyTrialLevelInfo.<>f__mg$cache30, typeof(ConfigDataThearchyTrialLevelInfo));
	}

	// Token: 0x0400D51C RID: 54556
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache0;

	// Token: 0x0400D51D RID: 54557
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1;

	// Token: 0x0400D51E RID: 54558
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2;

	// Token: 0x0400D51F RID: 54559
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3;

	// Token: 0x0400D520 RID: 54560
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache4;

	// Token: 0x0400D521 RID: 54561
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache5;

	// Token: 0x0400D522 RID: 54562
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache6;

	// Token: 0x0400D523 RID: 54563
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache7;

	// Token: 0x0400D524 RID: 54564
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache8;

	// Token: 0x0400D525 RID: 54565
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache9;

	// Token: 0x0400D526 RID: 54566
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheA;

	// Token: 0x0400D527 RID: 54567
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheB;

	// Token: 0x0400D528 RID: 54568
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheC;

	// Token: 0x0400D529 RID: 54569
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheD;

	// Token: 0x0400D52A RID: 54570
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheE;

	// Token: 0x0400D52B RID: 54571
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheF;

	// Token: 0x0400D52C RID: 54572
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache10;

	// Token: 0x0400D52D RID: 54573
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache11;

	// Token: 0x0400D52E RID: 54574
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache12;

	// Token: 0x0400D52F RID: 54575
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache13;

	// Token: 0x0400D530 RID: 54576
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache14;

	// Token: 0x0400D531 RID: 54577
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache15;

	// Token: 0x0400D532 RID: 54578
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache16;

	// Token: 0x0400D533 RID: 54579
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache17;

	// Token: 0x0400D534 RID: 54580
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache18;

	// Token: 0x0400D535 RID: 54581
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache19;

	// Token: 0x0400D536 RID: 54582
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1A;

	// Token: 0x0400D537 RID: 54583
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1B;

	// Token: 0x0400D538 RID: 54584
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1C;

	// Token: 0x0400D539 RID: 54585
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1D;

	// Token: 0x0400D53A RID: 54586
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1E;

	// Token: 0x0400D53B RID: 54587
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1F;

	// Token: 0x0400D53C RID: 54588
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache20;

	// Token: 0x0400D53D RID: 54589
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache21;

	// Token: 0x0400D53E RID: 54590
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache22;

	// Token: 0x0400D53F RID: 54591
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache23;

	// Token: 0x0400D540 RID: 54592
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache24;

	// Token: 0x0400D541 RID: 54593
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache25;

	// Token: 0x0400D542 RID: 54594
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache26;

	// Token: 0x0400D543 RID: 54595
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache27;

	// Token: 0x0400D544 RID: 54596
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache28;

	// Token: 0x0400D545 RID: 54597
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache29;

	// Token: 0x0400D546 RID: 54598
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2A;

	// Token: 0x0400D547 RID: 54599
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2B;

	// Token: 0x0400D548 RID: 54600
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2C;

	// Token: 0x0400D549 RID: 54601
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2D;

	// Token: 0x0400D54A RID: 54602
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2E;

	// Token: 0x0400D54B RID: 54603
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2F;

	// Token: 0x0400D54C RID: 54604
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache30;
}
