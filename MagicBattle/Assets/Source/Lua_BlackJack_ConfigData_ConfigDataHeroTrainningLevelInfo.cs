using System;
using System.Runtime.CompilerServices;
using BlackJack.ConfigData;
using SLua;
using UnityEngine.Scripting;

// Token: 0x0200115B RID: 4443
[Preserve]
public class Lua_BlackJack_ConfigData_ConfigDataHeroTrainningLevelInfo : LuaObject
{
	// Token: 0x060169F1 RID: 92657 RVA: 0x00603270 File Offset: 0x00601470
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int constructor(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataHeroTrainningLevelInfo o = new ConfigDataHeroTrainningLevelInfo();
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

	// Token: 0x060169F2 RID: 92658 RVA: 0x006032B8 File Offset: 0x006014B8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_battleInfo(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataHeroTrainningLevelInfo configDataHeroTrainningLevelInfo = (ConfigDataHeroTrainningLevelInfo)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, configDataHeroTrainningLevelInfo.m_battleInfo);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060169F3 RID: 92659 RVA: 0x0060330C File Offset: 0x0060150C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_battleInfo(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataHeroTrainningLevelInfo configDataHeroTrainningLevelInfo = (ConfigDataHeroTrainningLevelInfo)LuaObject.checkSelf(l);
			ConfigDataBattleInfo battleInfo;
			LuaObject.checkType<ConfigDataBattleInfo>(l, 2, out battleInfo);
			configDataHeroTrainningLevelInfo.m_battleInfo = battleInfo;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060169F4 RID: 92660 RVA: 0x00603364 File Offset: 0x00601564
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_groupInfo(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataHeroTrainningLevelInfo configDataHeroTrainningLevelInfo = (ConfigDataHeroTrainningLevelInfo)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, configDataHeroTrainningLevelInfo.m_groupInfo);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060169F5 RID: 92661 RVA: 0x006033B8 File Offset: 0x006015B8
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_m_groupInfo(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataHeroTrainningLevelInfo configDataHeroTrainningLevelInfo = (ConfigDataHeroTrainningLevelInfo)LuaObject.checkSelf(l);
			ConfigDataHeroTrainningInfo groupInfo;
			LuaObject.checkType<ConfigDataHeroTrainningInfo>(l, 2, out groupInfo);
			configDataHeroTrainningLevelInfo.m_groupInfo = groupInfo;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060169F6 RID: 92662 RVA: 0x00603410 File Offset: 0x00601610
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_randomDropInfo(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataHeroTrainningLevelInfo configDataHeroTrainningLevelInfo = (ConfigDataHeroTrainningLevelInfo)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, configDataHeroTrainningLevelInfo.m_randomDropInfo);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060169F7 RID: 92663 RVA: 0x00603464 File Offset: 0x00601664
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_randomDropInfo(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataHeroTrainningLevelInfo configDataHeroTrainningLevelInfo = (ConfigDataHeroTrainningLevelInfo)LuaObject.checkSelf(l);
			ConfigDataRandomDropRewardInfo randomDropInfo;
			LuaObject.checkType<ConfigDataRandomDropRewardInfo>(l, 2, out randomDropInfo);
			configDataHeroTrainningLevelInfo.m_randomDropInfo = randomDropInfo;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060169F8 RID: 92664 RVA: 0x006034BC File Offset: 0x006016BC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_activityRandomDropInfo(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataHeroTrainningLevelInfo configDataHeroTrainningLevelInfo = (ConfigDataHeroTrainningLevelInfo)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, configDataHeroTrainningLevelInfo.m_activityRandomDropInfo);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060169F9 RID: 92665 RVA: 0x00603510 File Offset: 0x00601710
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_m_activityRandomDropInfo(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataHeroTrainningLevelInfo configDataHeroTrainningLevelInfo = (ConfigDataHeroTrainningLevelInfo)LuaObject.checkSelf(l);
			ConfigDataRandomDropRewardInfo activityRandomDropInfo;
			LuaObject.checkType<ConfigDataRandomDropRewardInfo>(l, 2, out activityRandomDropInfo);
			configDataHeroTrainningLevelInfo.m_activityRandomDropInfo = activityRandomDropInfo;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060169FA RID: 92666 RVA: 0x00603568 File Offset: 0x00601768
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_ID(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataHeroTrainningLevelInfo configDataHeroTrainningLevelInfo = (ConfigDataHeroTrainningLevelInfo)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, configDataHeroTrainningLevelInfo.ID);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060169FB RID: 92667 RVA: 0x006035BC File Offset: 0x006017BC
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_ID(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataHeroTrainningLevelInfo configDataHeroTrainningLevelInfo = (ConfigDataHeroTrainningLevelInfo)LuaObject.checkSelf(l);
			int id;
			LuaObject.checkType(l, 2, out id);
			configDataHeroTrainningLevelInfo.ID = id;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060169FC RID: 92668 RVA: 0x00603614 File Offset: 0x00601814
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_Name(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataHeroTrainningLevelInfo configDataHeroTrainningLevelInfo = (ConfigDataHeroTrainningLevelInfo)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, configDataHeroTrainningLevelInfo.Name);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060169FD RID: 92669 RVA: 0x00603668 File Offset: 0x00601868
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_Name(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataHeroTrainningLevelInfo configDataHeroTrainningLevelInfo = (ConfigDataHeroTrainningLevelInfo)LuaObject.checkSelf(l);
			string name;
			LuaObject.checkType(l, 2, out name);
			configDataHeroTrainningLevelInfo.Name = name;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060169FE RID: 92670 RVA: 0x006036C0 File Offset: 0x006018C0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_TeamName(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataHeroTrainningLevelInfo configDataHeroTrainningLevelInfo = (ConfigDataHeroTrainningLevelInfo)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, configDataHeroTrainningLevelInfo.TeamName);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060169FF RID: 92671 RVA: 0x00603714 File Offset: 0x00601914
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_TeamName(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataHeroTrainningLevelInfo configDataHeroTrainningLevelInfo = (ConfigDataHeroTrainningLevelInfo)LuaObject.checkSelf(l);
			string teamName;
			LuaObject.checkType(l, 2, out teamName);
			configDataHeroTrainningLevelInfo.TeamName = teamName;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06016A00 RID: 92672 RVA: 0x0060376C File Offset: 0x0060196C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_OpenPlayerLevel(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataHeroTrainningLevelInfo configDataHeroTrainningLevelInfo = (ConfigDataHeroTrainningLevelInfo)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, configDataHeroTrainningLevelInfo.OpenPlayerLevel);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06016A01 RID: 92673 RVA: 0x006037C0 File Offset: 0x006019C0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_OpenPlayerLevel(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataHeroTrainningLevelInfo configDataHeroTrainningLevelInfo = (ConfigDataHeroTrainningLevelInfo)LuaObject.checkSelf(l);
			int openPlayerLevel;
			LuaObject.checkType(l, 2, out openPlayerLevel);
			configDataHeroTrainningLevelInfo.OpenPlayerLevel = openPlayerLevel;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06016A02 RID: 92674 RVA: 0x00603818 File Offset: 0x00601A18
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_TicketCost(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataHeroTrainningLevelInfo configDataHeroTrainningLevelInfo = (ConfigDataHeroTrainningLevelInfo)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, configDataHeroTrainningLevelInfo.TicketCost);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06016A03 RID: 92675 RVA: 0x0060386C File Offset: 0x00601A6C
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_TicketCost(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataHeroTrainningLevelInfo configDataHeroTrainningLevelInfo = (ConfigDataHeroTrainningLevelInfo)LuaObject.checkSelf(l);
			int ticketCost;
			LuaObject.checkType(l, 2, out ticketCost);
			configDataHeroTrainningLevelInfo.TicketCost = ticketCost;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06016A04 RID: 92676 RVA: 0x006038C4 File Offset: 0x00601AC4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_EnergySuccess(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataHeroTrainningLevelInfo configDataHeroTrainningLevelInfo = (ConfigDataHeroTrainningLevelInfo)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, configDataHeroTrainningLevelInfo.EnergySuccess);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06016A05 RID: 92677 RVA: 0x00603918 File Offset: 0x00601B18
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_EnergySuccess(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataHeroTrainningLevelInfo configDataHeroTrainningLevelInfo = (ConfigDataHeroTrainningLevelInfo)LuaObject.checkSelf(l);
			int energySuccess;
			LuaObject.checkType(l, 2, out energySuccess);
			configDataHeroTrainningLevelInfo.EnergySuccess = energySuccess;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06016A06 RID: 92678 RVA: 0x00603970 File Offset: 0x00601B70
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_EnergyFail(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataHeroTrainningLevelInfo configDataHeroTrainningLevelInfo = (ConfigDataHeroTrainningLevelInfo)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, configDataHeroTrainningLevelInfo.EnergyFail);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06016A07 RID: 92679 RVA: 0x006039C4 File Offset: 0x00601BC4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_EnergyFail(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataHeroTrainningLevelInfo configDataHeroTrainningLevelInfo = (ConfigDataHeroTrainningLevelInfo)LuaObject.checkSelf(l);
			int energyFail;
			LuaObject.checkType(l, 2, out energyFail);
			configDataHeroTrainningLevelInfo.EnergyFail = energyFail;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06016A08 RID: 92680 RVA: 0x00603A1C File Offset: 0x00601C1C
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_TeamEnergyCost(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataHeroTrainningLevelInfo configDataHeroTrainningLevelInfo = (ConfigDataHeroTrainningLevelInfo)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, configDataHeroTrainningLevelInfo.TeamEnergyCost);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06016A09 RID: 92681 RVA: 0x00603A70 File Offset: 0x00601C70
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_TeamEnergyCost(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataHeroTrainningLevelInfo configDataHeroTrainningLevelInfo = (ConfigDataHeroTrainningLevelInfo)LuaObject.checkSelf(l);
			int teamEnergyCost;
			LuaObject.checkType(l, 2, out teamEnergyCost);
			configDataHeroTrainningLevelInfo.TeamEnergyCost = teamEnergyCost;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06016A0A RID: 92682 RVA: 0x00603AC8 File Offset: 0x00601CC8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_MonsterLevel(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataHeroTrainningLevelInfo configDataHeroTrainningLevelInfo = (ConfigDataHeroTrainningLevelInfo)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, configDataHeroTrainningLevelInfo.MonsterLevel);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06016A0B RID: 92683 RVA: 0x00603B1C File Offset: 0x00601D1C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_MonsterLevel(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataHeroTrainningLevelInfo configDataHeroTrainningLevelInfo = (ConfigDataHeroTrainningLevelInfo)LuaObject.checkSelf(l);
			int monsterLevel;
			LuaObject.checkType(l, 2, out monsterLevel);
			configDataHeroTrainningLevelInfo.MonsterLevel = monsterLevel;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06016A0C RID: 92684 RVA: 0x00603B74 File Offset: 0x00601D74
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_Battle_ID(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataHeroTrainningLevelInfo configDataHeroTrainningLevelInfo = (ConfigDataHeroTrainningLevelInfo)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, configDataHeroTrainningLevelInfo.Battle_ID);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06016A0D RID: 92685 RVA: 0x00603BC8 File Offset: 0x00601DC8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_Battle_ID(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataHeroTrainningLevelInfo configDataHeroTrainningLevelInfo = (ConfigDataHeroTrainningLevelInfo)LuaObject.checkSelf(l);
			int battle_ID;
			LuaObject.checkType(l, 2, out battle_ID);
			configDataHeroTrainningLevelInfo.Battle_ID = battle_ID;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06016A0E RID: 92686 RVA: 0x00603C20 File Offset: 0x00601E20
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_PlayerExp(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataHeroTrainningLevelInfo configDataHeroTrainningLevelInfo = (ConfigDataHeroTrainningLevelInfo)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, configDataHeroTrainningLevelInfo.PlayerExp);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06016A0F RID: 92687 RVA: 0x00603C74 File Offset: 0x00601E74
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_PlayerExp(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataHeroTrainningLevelInfo configDataHeroTrainningLevelInfo = (ConfigDataHeroTrainningLevelInfo)LuaObject.checkSelf(l);
			int playerExp;
			LuaObject.checkType(l, 2, out playerExp);
			configDataHeroTrainningLevelInfo.PlayerExp = playerExp;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06016A10 RID: 92688 RVA: 0x00603CCC File Offset: 0x00601ECC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_HeroExp(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataHeroTrainningLevelInfo configDataHeroTrainningLevelInfo = (ConfigDataHeroTrainningLevelInfo)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, configDataHeroTrainningLevelInfo.HeroExp);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06016A11 RID: 92689 RVA: 0x00603D20 File Offset: 0x00601F20
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_HeroExp(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataHeroTrainningLevelInfo configDataHeroTrainningLevelInfo = (ConfigDataHeroTrainningLevelInfo)LuaObject.checkSelf(l);
			int heroExp;
			LuaObject.checkType(l, 2, out heroExp);
			configDataHeroTrainningLevelInfo.HeroExp = heroExp;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06016A12 RID: 92690 RVA: 0x00603D78 File Offset: 0x00601F78
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_Gold(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataHeroTrainningLevelInfo configDataHeroTrainningLevelInfo = (ConfigDataHeroTrainningLevelInfo)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, configDataHeroTrainningLevelInfo.Gold);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06016A13 RID: 92691 RVA: 0x00603DCC File Offset: 0x00601FCC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_Gold(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataHeroTrainningLevelInfo configDataHeroTrainningLevelInfo = (ConfigDataHeroTrainningLevelInfo)LuaObject.checkSelf(l);
			int gold;
			LuaObject.checkType(l, 2, out gold);
			configDataHeroTrainningLevelInfo.Gold = gold;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06016A14 RID: 92692 RVA: 0x00603E24 File Offset: 0x00602024
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_Drop_ID(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataHeroTrainningLevelInfo configDataHeroTrainningLevelInfo = (ConfigDataHeroTrainningLevelInfo)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, configDataHeroTrainningLevelInfo.Drop_ID);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06016A15 RID: 92693 RVA: 0x00603E78 File Offset: 0x00602078
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_Drop_ID(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataHeroTrainningLevelInfo configDataHeroTrainningLevelInfo = (ConfigDataHeroTrainningLevelInfo)LuaObject.checkSelf(l);
			int drop_ID;
			LuaObject.checkType(l, 2, out drop_ID);
			configDataHeroTrainningLevelInfo.Drop_ID = drop_ID;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06016A16 RID: 92694 RVA: 0x00603ED0 File Offset: 0x006020D0
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_TeamDrop_ID(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataHeroTrainningLevelInfo configDataHeroTrainningLevelInfo = (ConfigDataHeroTrainningLevelInfo)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, configDataHeroTrainningLevelInfo.TeamDrop_ID);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06016A17 RID: 92695 RVA: 0x00603F24 File Offset: 0x00602124
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_TeamDrop_ID(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataHeroTrainningLevelInfo configDataHeroTrainningLevelInfo = (ConfigDataHeroTrainningLevelInfo)LuaObject.checkSelf(l);
			int teamDrop_ID;
			LuaObject.checkType(l, 2, out teamDrop_ID);
			configDataHeroTrainningLevelInfo.TeamDrop_ID = teamDrop_ID;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06016A18 RID: 92696 RVA: 0x00603F7C File Offset: 0x0060217C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_OperationalActivityDrop_ID(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataHeroTrainningLevelInfo configDataHeroTrainningLevelInfo = (ConfigDataHeroTrainningLevelInfo)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, configDataHeroTrainningLevelInfo.OperationalActivityDrop_ID);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06016A19 RID: 92697 RVA: 0x00603FD0 File Offset: 0x006021D0
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_OperationalActivityDrop_ID(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataHeroTrainningLevelInfo configDataHeroTrainningLevelInfo = (ConfigDataHeroTrainningLevelInfo)LuaObject.checkSelf(l);
			int operationalActivityDrop_ID;
			LuaObject.checkType(l, 2, out operationalActivityDrop_ID);
			configDataHeroTrainningLevelInfo.OperationalActivityDrop_ID = operationalActivityDrop_ID;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06016A1A RID: 92698 RVA: 0x00604028 File Offset: 0x00602228
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_DayBonusDrop_ID(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataHeroTrainningLevelInfo configDataHeroTrainningLevelInfo = (ConfigDataHeroTrainningLevelInfo)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, configDataHeroTrainningLevelInfo.DayBonusDrop_ID);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06016A1B RID: 92699 RVA: 0x0060407C File Offset: 0x0060227C
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_DayBonusDrop_ID(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataHeroTrainningLevelInfo configDataHeroTrainningLevelInfo = (ConfigDataHeroTrainningLevelInfo)LuaObject.checkSelf(l);
			int dayBonusDrop_ID;
			LuaObject.checkType(l, 2, out dayBonusDrop_ID);
			configDataHeroTrainningLevelInfo.DayBonusDrop_ID = dayBonusDrop_ID;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06016A1C RID: 92700 RVA: 0x006040D4 File Offset: 0x006022D4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_DisplayRewardCount(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataHeroTrainningLevelInfo configDataHeroTrainningLevelInfo = (ConfigDataHeroTrainningLevelInfo)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, configDataHeroTrainningLevelInfo.DisplayRewardCount);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06016A1D RID: 92701 RVA: 0x00604128 File Offset: 0x00602328
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_DisplayRewardCount(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataHeroTrainningLevelInfo configDataHeroTrainningLevelInfo = (ConfigDataHeroTrainningLevelInfo)LuaObject.checkSelf(l);
			int displayRewardCount;
			LuaObject.checkType(l, 2, out displayRewardCount);
			configDataHeroTrainningLevelInfo.DisplayRewardCount = displayRewardCount;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06016A1E RID: 92702 RVA: 0x00604180 File Offset: 0x00602380
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_Icon(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataHeroTrainningLevelInfo configDataHeroTrainningLevelInfo = (ConfigDataHeroTrainningLevelInfo)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, configDataHeroTrainningLevelInfo.Icon);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06016A1F RID: 92703 RVA: 0x006041D4 File Offset: 0x006023D4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_Icon(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataHeroTrainningLevelInfo configDataHeroTrainningLevelInfo = (ConfigDataHeroTrainningLevelInfo)LuaObject.checkSelf(l);
			string icon;
			LuaObject.checkType(l, 2, out icon);
			configDataHeroTrainningLevelInfo.Icon = icon;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06016A20 RID: 92704 RVA: 0x0060422C File Offset: 0x0060242C
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_Strategy(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataHeroTrainningLevelInfo configDataHeroTrainningLevelInfo = (ConfigDataHeroTrainningLevelInfo)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, configDataHeroTrainningLevelInfo.Strategy);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06016A21 RID: 92705 RVA: 0x00604280 File Offset: 0x00602480
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_Strategy(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataHeroTrainningLevelInfo configDataHeroTrainningLevelInfo = (ConfigDataHeroTrainningLevelInfo)LuaObject.checkSelf(l);
			string strategy;
			LuaObject.checkType(l, 2, out strategy);
			configDataHeroTrainningLevelInfo.Strategy = strategy;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06016A22 RID: 92706 RVA: 0x006042D8 File Offset: 0x006024D8
	[Preserve]
	public static void reg(IntPtr l)
	{
		LuaObject.getTypeTable(l, "BlackJack.ConfigData.ConfigDataHeroTrainningLevelInfo");
		string name = "m_battleInfo";
		if (Lua_BlackJack_ConfigData_ConfigDataHeroTrainningLevelInfo.<>f__mg$cache0 == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataHeroTrainningLevelInfo.<>f__mg$cache0 = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataHeroTrainningLevelInfo.get_m_battleInfo);
		}
		LuaCSFunction get = Lua_BlackJack_ConfigData_ConfigDataHeroTrainningLevelInfo.<>f__mg$cache0;
		if (Lua_BlackJack_ConfigData_ConfigDataHeroTrainningLevelInfo.<>f__mg$cache1 == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataHeroTrainningLevelInfo.<>f__mg$cache1 = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataHeroTrainningLevelInfo.set_m_battleInfo);
		}
		LuaObject.addMember(l, name, get, Lua_BlackJack_ConfigData_ConfigDataHeroTrainningLevelInfo.<>f__mg$cache1, true);
		string name2 = "m_groupInfo";
		if (Lua_BlackJack_ConfigData_ConfigDataHeroTrainningLevelInfo.<>f__mg$cache2 == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataHeroTrainningLevelInfo.<>f__mg$cache2 = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataHeroTrainningLevelInfo.get_m_groupInfo);
		}
		LuaCSFunction get2 = Lua_BlackJack_ConfigData_ConfigDataHeroTrainningLevelInfo.<>f__mg$cache2;
		if (Lua_BlackJack_ConfigData_ConfigDataHeroTrainningLevelInfo.<>f__mg$cache3 == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataHeroTrainningLevelInfo.<>f__mg$cache3 = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataHeroTrainningLevelInfo.set_m_groupInfo);
		}
		LuaObject.addMember(l, name2, get2, Lua_BlackJack_ConfigData_ConfigDataHeroTrainningLevelInfo.<>f__mg$cache3, true);
		string name3 = "m_randomDropInfo";
		if (Lua_BlackJack_ConfigData_ConfigDataHeroTrainningLevelInfo.<>f__mg$cache4 == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataHeroTrainningLevelInfo.<>f__mg$cache4 = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataHeroTrainningLevelInfo.get_m_randomDropInfo);
		}
		LuaCSFunction get3 = Lua_BlackJack_ConfigData_ConfigDataHeroTrainningLevelInfo.<>f__mg$cache4;
		if (Lua_BlackJack_ConfigData_ConfigDataHeroTrainningLevelInfo.<>f__mg$cache5 == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataHeroTrainningLevelInfo.<>f__mg$cache5 = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataHeroTrainningLevelInfo.set_m_randomDropInfo);
		}
		LuaObject.addMember(l, name3, get3, Lua_BlackJack_ConfigData_ConfigDataHeroTrainningLevelInfo.<>f__mg$cache5, true);
		string name4 = "m_activityRandomDropInfo";
		if (Lua_BlackJack_ConfigData_ConfigDataHeroTrainningLevelInfo.<>f__mg$cache6 == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataHeroTrainningLevelInfo.<>f__mg$cache6 = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataHeroTrainningLevelInfo.get_m_activityRandomDropInfo);
		}
		LuaCSFunction get4 = Lua_BlackJack_ConfigData_ConfigDataHeroTrainningLevelInfo.<>f__mg$cache6;
		if (Lua_BlackJack_ConfigData_ConfigDataHeroTrainningLevelInfo.<>f__mg$cache7 == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataHeroTrainningLevelInfo.<>f__mg$cache7 = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataHeroTrainningLevelInfo.set_m_activityRandomDropInfo);
		}
		LuaObject.addMember(l, name4, get4, Lua_BlackJack_ConfigData_ConfigDataHeroTrainningLevelInfo.<>f__mg$cache7, true);
		string name5 = "ID";
		if (Lua_BlackJack_ConfigData_ConfigDataHeroTrainningLevelInfo.<>f__mg$cache8 == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataHeroTrainningLevelInfo.<>f__mg$cache8 = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataHeroTrainningLevelInfo.get_ID);
		}
		LuaCSFunction get5 = Lua_BlackJack_ConfigData_ConfigDataHeroTrainningLevelInfo.<>f__mg$cache8;
		if (Lua_BlackJack_ConfigData_ConfigDataHeroTrainningLevelInfo.<>f__mg$cache9 == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataHeroTrainningLevelInfo.<>f__mg$cache9 = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataHeroTrainningLevelInfo.set_ID);
		}
		LuaObject.addMember(l, name5, get5, Lua_BlackJack_ConfigData_ConfigDataHeroTrainningLevelInfo.<>f__mg$cache9, true);
		string name6 = "Name";
		if (Lua_BlackJack_ConfigData_ConfigDataHeroTrainningLevelInfo.<>f__mg$cacheA == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataHeroTrainningLevelInfo.<>f__mg$cacheA = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataHeroTrainningLevelInfo.get_Name);
		}
		LuaCSFunction get6 = Lua_BlackJack_ConfigData_ConfigDataHeroTrainningLevelInfo.<>f__mg$cacheA;
		if (Lua_BlackJack_ConfigData_ConfigDataHeroTrainningLevelInfo.<>f__mg$cacheB == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataHeroTrainningLevelInfo.<>f__mg$cacheB = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataHeroTrainningLevelInfo.set_Name);
		}
		LuaObject.addMember(l, name6, get6, Lua_BlackJack_ConfigData_ConfigDataHeroTrainningLevelInfo.<>f__mg$cacheB, true);
		string name7 = "TeamName";
		if (Lua_BlackJack_ConfigData_ConfigDataHeroTrainningLevelInfo.<>f__mg$cacheC == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataHeroTrainningLevelInfo.<>f__mg$cacheC = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataHeroTrainningLevelInfo.get_TeamName);
		}
		LuaCSFunction get7 = Lua_BlackJack_ConfigData_ConfigDataHeroTrainningLevelInfo.<>f__mg$cacheC;
		if (Lua_BlackJack_ConfigData_ConfigDataHeroTrainningLevelInfo.<>f__mg$cacheD == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataHeroTrainningLevelInfo.<>f__mg$cacheD = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataHeroTrainningLevelInfo.set_TeamName);
		}
		LuaObject.addMember(l, name7, get7, Lua_BlackJack_ConfigData_ConfigDataHeroTrainningLevelInfo.<>f__mg$cacheD, true);
		string name8 = "OpenPlayerLevel";
		if (Lua_BlackJack_ConfigData_ConfigDataHeroTrainningLevelInfo.<>f__mg$cacheE == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataHeroTrainningLevelInfo.<>f__mg$cacheE = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataHeroTrainningLevelInfo.get_OpenPlayerLevel);
		}
		LuaCSFunction get8 = Lua_BlackJack_ConfigData_ConfigDataHeroTrainningLevelInfo.<>f__mg$cacheE;
		if (Lua_BlackJack_ConfigData_ConfigDataHeroTrainningLevelInfo.<>f__mg$cacheF == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataHeroTrainningLevelInfo.<>f__mg$cacheF = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataHeroTrainningLevelInfo.set_OpenPlayerLevel);
		}
		LuaObject.addMember(l, name8, get8, Lua_BlackJack_ConfigData_ConfigDataHeroTrainningLevelInfo.<>f__mg$cacheF, true);
		string name9 = "TicketCost";
		if (Lua_BlackJack_ConfigData_ConfigDataHeroTrainningLevelInfo.<>f__mg$cache10 == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataHeroTrainningLevelInfo.<>f__mg$cache10 = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataHeroTrainningLevelInfo.get_TicketCost);
		}
		LuaCSFunction get9 = Lua_BlackJack_ConfigData_ConfigDataHeroTrainningLevelInfo.<>f__mg$cache10;
		if (Lua_BlackJack_ConfigData_ConfigDataHeroTrainningLevelInfo.<>f__mg$cache11 == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataHeroTrainningLevelInfo.<>f__mg$cache11 = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataHeroTrainningLevelInfo.set_TicketCost);
		}
		LuaObject.addMember(l, name9, get9, Lua_BlackJack_ConfigData_ConfigDataHeroTrainningLevelInfo.<>f__mg$cache11, true);
		string name10 = "EnergySuccess";
		if (Lua_BlackJack_ConfigData_ConfigDataHeroTrainningLevelInfo.<>f__mg$cache12 == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataHeroTrainningLevelInfo.<>f__mg$cache12 = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataHeroTrainningLevelInfo.get_EnergySuccess);
		}
		LuaCSFunction get10 = Lua_BlackJack_ConfigData_ConfigDataHeroTrainningLevelInfo.<>f__mg$cache12;
		if (Lua_BlackJack_ConfigData_ConfigDataHeroTrainningLevelInfo.<>f__mg$cache13 == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataHeroTrainningLevelInfo.<>f__mg$cache13 = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataHeroTrainningLevelInfo.set_EnergySuccess);
		}
		LuaObject.addMember(l, name10, get10, Lua_BlackJack_ConfigData_ConfigDataHeroTrainningLevelInfo.<>f__mg$cache13, true);
		string name11 = "EnergyFail";
		if (Lua_BlackJack_ConfigData_ConfigDataHeroTrainningLevelInfo.<>f__mg$cache14 == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataHeroTrainningLevelInfo.<>f__mg$cache14 = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataHeroTrainningLevelInfo.get_EnergyFail);
		}
		LuaCSFunction get11 = Lua_BlackJack_ConfigData_ConfigDataHeroTrainningLevelInfo.<>f__mg$cache14;
		if (Lua_BlackJack_ConfigData_ConfigDataHeroTrainningLevelInfo.<>f__mg$cache15 == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataHeroTrainningLevelInfo.<>f__mg$cache15 = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataHeroTrainningLevelInfo.set_EnergyFail);
		}
		LuaObject.addMember(l, name11, get11, Lua_BlackJack_ConfigData_ConfigDataHeroTrainningLevelInfo.<>f__mg$cache15, true);
		string name12 = "TeamEnergyCost";
		if (Lua_BlackJack_ConfigData_ConfigDataHeroTrainningLevelInfo.<>f__mg$cache16 == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataHeroTrainningLevelInfo.<>f__mg$cache16 = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataHeroTrainningLevelInfo.get_TeamEnergyCost);
		}
		LuaCSFunction get12 = Lua_BlackJack_ConfigData_ConfigDataHeroTrainningLevelInfo.<>f__mg$cache16;
		if (Lua_BlackJack_ConfigData_ConfigDataHeroTrainningLevelInfo.<>f__mg$cache17 == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataHeroTrainningLevelInfo.<>f__mg$cache17 = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataHeroTrainningLevelInfo.set_TeamEnergyCost);
		}
		LuaObject.addMember(l, name12, get12, Lua_BlackJack_ConfigData_ConfigDataHeroTrainningLevelInfo.<>f__mg$cache17, true);
		string name13 = "MonsterLevel";
		if (Lua_BlackJack_ConfigData_ConfigDataHeroTrainningLevelInfo.<>f__mg$cache18 == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataHeroTrainningLevelInfo.<>f__mg$cache18 = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataHeroTrainningLevelInfo.get_MonsterLevel);
		}
		LuaCSFunction get13 = Lua_BlackJack_ConfigData_ConfigDataHeroTrainningLevelInfo.<>f__mg$cache18;
		if (Lua_BlackJack_ConfigData_ConfigDataHeroTrainningLevelInfo.<>f__mg$cache19 == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataHeroTrainningLevelInfo.<>f__mg$cache19 = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataHeroTrainningLevelInfo.set_MonsterLevel);
		}
		LuaObject.addMember(l, name13, get13, Lua_BlackJack_ConfigData_ConfigDataHeroTrainningLevelInfo.<>f__mg$cache19, true);
		string name14 = "Battle_ID";
		if (Lua_BlackJack_ConfigData_ConfigDataHeroTrainningLevelInfo.<>f__mg$cache1A == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataHeroTrainningLevelInfo.<>f__mg$cache1A = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataHeroTrainningLevelInfo.get_Battle_ID);
		}
		LuaCSFunction get14 = Lua_BlackJack_ConfigData_ConfigDataHeroTrainningLevelInfo.<>f__mg$cache1A;
		if (Lua_BlackJack_ConfigData_ConfigDataHeroTrainningLevelInfo.<>f__mg$cache1B == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataHeroTrainningLevelInfo.<>f__mg$cache1B = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataHeroTrainningLevelInfo.set_Battle_ID);
		}
		LuaObject.addMember(l, name14, get14, Lua_BlackJack_ConfigData_ConfigDataHeroTrainningLevelInfo.<>f__mg$cache1B, true);
		string name15 = "PlayerExp";
		if (Lua_BlackJack_ConfigData_ConfigDataHeroTrainningLevelInfo.<>f__mg$cache1C == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataHeroTrainningLevelInfo.<>f__mg$cache1C = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataHeroTrainningLevelInfo.get_PlayerExp);
		}
		LuaCSFunction get15 = Lua_BlackJack_ConfigData_ConfigDataHeroTrainningLevelInfo.<>f__mg$cache1C;
		if (Lua_BlackJack_ConfigData_ConfigDataHeroTrainningLevelInfo.<>f__mg$cache1D == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataHeroTrainningLevelInfo.<>f__mg$cache1D = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataHeroTrainningLevelInfo.set_PlayerExp);
		}
		LuaObject.addMember(l, name15, get15, Lua_BlackJack_ConfigData_ConfigDataHeroTrainningLevelInfo.<>f__mg$cache1D, true);
		string name16 = "HeroExp";
		if (Lua_BlackJack_ConfigData_ConfigDataHeroTrainningLevelInfo.<>f__mg$cache1E == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataHeroTrainningLevelInfo.<>f__mg$cache1E = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataHeroTrainningLevelInfo.get_HeroExp);
		}
		LuaCSFunction get16 = Lua_BlackJack_ConfigData_ConfigDataHeroTrainningLevelInfo.<>f__mg$cache1E;
		if (Lua_BlackJack_ConfigData_ConfigDataHeroTrainningLevelInfo.<>f__mg$cache1F == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataHeroTrainningLevelInfo.<>f__mg$cache1F = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataHeroTrainningLevelInfo.set_HeroExp);
		}
		LuaObject.addMember(l, name16, get16, Lua_BlackJack_ConfigData_ConfigDataHeroTrainningLevelInfo.<>f__mg$cache1F, true);
		string name17 = "Gold";
		if (Lua_BlackJack_ConfigData_ConfigDataHeroTrainningLevelInfo.<>f__mg$cache20 == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataHeroTrainningLevelInfo.<>f__mg$cache20 = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataHeroTrainningLevelInfo.get_Gold);
		}
		LuaCSFunction get17 = Lua_BlackJack_ConfigData_ConfigDataHeroTrainningLevelInfo.<>f__mg$cache20;
		if (Lua_BlackJack_ConfigData_ConfigDataHeroTrainningLevelInfo.<>f__mg$cache21 == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataHeroTrainningLevelInfo.<>f__mg$cache21 = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataHeroTrainningLevelInfo.set_Gold);
		}
		LuaObject.addMember(l, name17, get17, Lua_BlackJack_ConfigData_ConfigDataHeroTrainningLevelInfo.<>f__mg$cache21, true);
		string name18 = "Drop_ID";
		if (Lua_BlackJack_ConfigData_ConfigDataHeroTrainningLevelInfo.<>f__mg$cache22 == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataHeroTrainningLevelInfo.<>f__mg$cache22 = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataHeroTrainningLevelInfo.get_Drop_ID);
		}
		LuaCSFunction get18 = Lua_BlackJack_ConfigData_ConfigDataHeroTrainningLevelInfo.<>f__mg$cache22;
		if (Lua_BlackJack_ConfigData_ConfigDataHeroTrainningLevelInfo.<>f__mg$cache23 == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataHeroTrainningLevelInfo.<>f__mg$cache23 = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataHeroTrainningLevelInfo.set_Drop_ID);
		}
		LuaObject.addMember(l, name18, get18, Lua_BlackJack_ConfigData_ConfigDataHeroTrainningLevelInfo.<>f__mg$cache23, true);
		string name19 = "TeamDrop_ID";
		if (Lua_BlackJack_ConfigData_ConfigDataHeroTrainningLevelInfo.<>f__mg$cache24 == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataHeroTrainningLevelInfo.<>f__mg$cache24 = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataHeroTrainningLevelInfo.get_TeamDrop_ID);
		}
		LuaCSFunction get19 = Lua_BlackJack_ConfigData_ConfigDataHeroTrainningLevelInfo.<>f__mg$cache24;
		if (Lua_BlackJack_ConfigData_ConfigDataHeroTrainningLevelInfo.<>f__mg$cache25 == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataHeroTrainningLevelInfo.<>f__mg$cache25 = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataHeroTrainningLevelInfo.set_TeamDrop_ID);
		}
		LuaObject.addMember(l, name19, get19, Lua_BlackJack_ConfigData_ConfigDataHeroTrainningLevelInfo.<>f__mg$cache25, true);
		string name20 = "OperationalActivityDrop_ID";
		if (Lua_BlackJack_ConfigData_ConfigDataHeroTrainningLevelInfo.<>f__mg$cache26 == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataHeroTrainningLevelInfo.<>f__mg$cache26 = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataHeroTrainningLevelInfo.get_OperationalActivityDrop_ID);
		}
		LuaCSFunction get20 = Lua_BlackJack_ConfigData_ConfigDataHeroTrainningLevelInfo.<>f__mg$cache26;
		if (Lua_BlackJack_ConfigData_ConfigDataHeroTrainningLevelInfo.<>f__mg$cache27 == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataHeroTrainningLevelInfo.<>f__mg$cache27 = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataHeroTrainningLevelInfo.set_OperationalActivityDrop_ID);
		}
		LuaObject.addMember(l, name20, get20, Lua_BlackJack_ConfigData_ConfigDataHeroTrainningLevelInfo.<>f__mg$cache27, true);
		string name21 = "DayBonusDrop_ID";
		if (Lua_BlackJack_ConfigData_ConfigDataHeroTrainningLevelInfo.<>f__mg$cache28 == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataHeroTrainningLevelInfo.<>f__mg$cache28 = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataHeroTrainningLevelInfo.get_DayBonusDrop_ID);
		}
		LuaCSFunction get21 = Lua_BlackJack_ConfigData_ConfigDataHeroTrainningLevelInfo.<>f__mg$cache28;
		if (Lua_BlackJack_ConfigData_ConfigDataHeroTrainningLevelInfo.<>f__mg$cache29 == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataHeroTrainningLevelInfo.<>f__mg$cache29 = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataHeroTrainningLevelInfo.set_DayBonusDrop_ID);
		}
		LuaObject.addMember(l, name21, get21, Lua_BlackJack_ConfigData_ConfigDataHeroTrainningLevelInfo.<>f__mg$cache29, true);
		string name22 = "DisplayRewardCount";
		if (Lua_BlackJack_ConfigData_ConfigDataHeroTrainningLevelInfo.<>f__mg$cache2A == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataHeroTrainningLevelInfo.<>f__mg$cache2A = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataHeroTrainningLevelInfo.get_DisplayRewardCount);
		}
		LuaCSFunction get22 = Lua_BlackJack_ConfigData_ConfigDataHeroTrainningLevelInfo.<>f__mg$cache2A;
		if (Lua_BlackJack_ConfigData_ConfigDataHeroTrainningLevelInfo.<>f__mg$cache2B == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataHeroTrainningLevelInfo.<>f__mg$cache2B = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataHeroTrainningLevelInfo.set_DisplayRewardCount);
		}
		LuaObject.addMember(l, name22, get22, Lua_BlackJack_ConfigData_ConfigDataHeroTrainningLevelInfo.<>f__mg$cache2B, true);
		string name23 = "Icon";
		if (Lua_BlackJack_ConfigData_ConfigDataHeroTrainningLevelInfo.<>f__mg$cache2C == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataHeroTrainningLevelInfo.<>f__mg$cache2C = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataHeroTrainningLevelInfo.get_Icon);
		}
		LuaCSFunction get23 = Lua_BlackJack_ConfigData_ConfigDataHeroTrainningLevelInfo.<>f__mg$cache2C;
		if (Lua_BlackJack_ConfigData_ConfigDataHeroTrainningLevelInfo.<>f__mg$cache2D == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataHeroTrainningLevelInfo.<>f__mg$cache2D = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataHeroTrainningLevelInfo.set_Icon);
		}
		LuaObject.addMember(l, name23, get23, Lua_BlackJack_ConfigData_ConfigDataHeroTrainningLevelInfo.<>f__mg$cache2D, true);
		string name24 = "Strategy";
		if (Lua_BlackJack_ConfigData_ConfigDataHeroTrainningLevelInfo.<>f__mg$cache2E == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataHeroTrainningLevelInfo.<>f__mg$cache2E = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataHeroTrainningLevelInfo.get_Strategy);
		}
		LuaCSFunction get24 = Lua_BlackJack_ConfigData_ConfigDataHeroTrainningLevelInfo.<>f__mg$cache2E;
		if (Lua_BlackJack_ConfigData_ConfigDataHeroTrainningLevelInfo.<>f__mg$cache2F == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataHeroTrainningLevelInfo.<>f__mg$cache2F = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataHeroTrainningLevelInfo.set_Strategy);
		}
		LuaObject.addMember(l, name24, get24, Lua_BlackJack_ConfigData_ConfigDataHeroTrainningLevelInfo.<>f__mg$cache2F, true);
		if (Lua_BlackJack_ConfigData_ConfigDataHeroTrainningLevelInfo.<>f__mg$cache30 == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataHeroTrainningLevelInfo.<>f__mg$cache30 = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataHeroTrainningLevelInfo.constructor);
		}
		LuaObject.createTypeMetatable(l, Lua_BlackJack_ConfigData_ConfigDataHeroTrainningLevelInfo.<>f__mg$cache30, typeof(ConfigDataHeroTrainningLevelInfo));
	}

	// Token: 0x0400D11D RID: 53533
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache0;

	// Token: 0x0400D11E RID: 53534
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1;

	// Token: 0x0400D11F RID: 53535
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2;

	// Token: 0x0400D120 RID: 53536
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3;

	// Token: 0x0400D121 RID: 53537
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache4;

	// Token: 0x0400D122 RID: 53538
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache5;

	// Token: 0x0400D123 RID: 53539
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache6;

	// Token: 0x0400D124 RID: 53540
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache7;

	// Token: 0x0400D125 RID: 53541
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache8;

	// Token: 0x0400D126 RID: 53542
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache9;

	// Token: 0x0400D127 RID: 53543
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheA;

	// Token: 0x0400D128 RID: 53544
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheB;

	// Token: 0x0400D129 RID: 53545
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheC;

	// Token: 0x0400D12A RID: 53546
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheD;

	// Token: 0x0400D12B RID: 53547
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheE;

	// Token: 0x0400D12C RID: 53548
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheF;

	// Token: 0x0400D12D RID: 53549
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache10;

	// Token: 0x0400D12E RID: 53550
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache11;

	// Token: 0x0400D12F RID: 53551
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache12;

	// Token: 0x0400D130 RID: 53552
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache13;

	// Token: 0x0400D131 RID: 53553
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache14;

	// Token: 0x0400D132 RID: 53554
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache15;

	// Token: 0x0400D133 RID: 53555
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache16;

	// Token: 0x0400D134 RID: 53556
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache17;

	// Token: 0x0400D135 RID: 53557
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache18;

	// Token: 0x0400D136 RID: 53558
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache19;

	// Token: 0x0400D137 RID: 53559
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1A;

	// Token: 0x0400D138 RID: 53560
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1B;

	// Token: 0x0400D139 RID: 53561
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1C;

	// Token: 0x0400D13A RID: 53562
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1D;

	// Token: 0x0400D13B RID: 53563
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1E;

	// Token: 0x0400D13C RID: 53564
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1F;

	// Token: 0x0400D13D RID: 53565
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache20;

	// Token: 0x0400D13E RID: 53566
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache21;

	// Token: 0x0400D13F RID: 53567
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache22;

	// Token: 0x0400D140 RID: 53568
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache23;

	// Token: 0x0400D141 RID: 53569
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache24;

	// Token: 0x0400D142 RID: 53570
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache25;

	// Token: 0x0400D143 RID: 53571
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache26;

	// Token: 0x0400D144 RID: 53572
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache27;

	// Token: 0x0400D145 RID: 53573
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache28;

	// Token: 0x0400D146 RID: 53574
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache29;

	// Token: 0x0400D147 RID: 53575
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2A;

	// Token: 0x0400D148 RID: 53576
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2B;

	// Token: 0x0400D149 RID: 53577
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2C;

	// Token: 0x0400D14A RID: 53578
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2D;

	// Token: 0x0400D14B RID: 53579
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2E;

	// Token: 0x0400D14C RID: 53580
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2F;

	// Token: 0x0400D14D RID: 53581
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache30;
}
