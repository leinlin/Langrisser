using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using BlackJack.BJFramework.Runtime.Prefab;
using BlackJack.BJFramework.Runtime.UI;
using BlackJack.ConfigData;
using BlackJack.ProjectL.Common;
using BlackJack.ProjectL.Misc;
using BlackJack.ProjectL.PlayerContext;
using BlackJack.ProjectL.Protocol;
using BlackJack.ProjectL.Scene;
using BlackJack.ProjectL.UI;
using SLua;
using UnityEngine;
using UnityEngine.Scripting;
using UnityEngine.UI;

// Token: 0x02001385 RID: 4997
[Preserve]
public class Lua_BlackJack_ProjectL_UI_ArenaUIController : LuaObject
{
	// Token: 0x0601B0A7 RID: 110759 RVA: 0x0081FB6C File Offset: 0x0081DD6C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int Open(IntPtr l)
	{
		int result;
		try
		{
			ArenaUIController arenaUIController = (ArenaUIController)LuaObject.checkSelf(l);
			ArenaUIType uiType;
			LuaObject.checkEnum<ArenaUIType>(l, 2, out uiType);
			bool canSwitchOnline;
			LuaObject.checkType(l, 3, out canSwitchOnline);
			arenaUIController.Open(uiType, canSwitchOnline);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601B0A8 RID: 110760 RVA: 0x0081FBD0 File Offset: 0x0081DDD0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int SwitchOfflineOnline(IntPtr l)
	{
		int result;
		try
		{
			ArenaUIController arenaUIController = (ArenaUIController)LuaObject.checkSelf(l);
			ArenaUIType uiType;
			LuaObject.checkEnum<ArenaUIType>(l, 2, out uiType);
			arenaUIController.SwitchOfflineOnline(uiType);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601B0A9 RID: 110761 RVA: 0x0081FC28 File Offset: 0x0081DE28
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int SetPlayerHeadIcon(IntPtr l)
	{
		int result;
		try
		{
			ArenaUIController arenaUIController = (ArenaUIController)LuaObject.checkSelf(l);
			int playerHeadIcon;
			LuaObject.checkType(l, 2, out playerHeadIcon);
			arenaUIController.SetPlayerHeadIcon(playerHeadIcon);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601B0AA RID: 110762 RVA: 0x0081FC80 File Offset: 0x0081DE80
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int SetPlayerName(IntPtr l)
	{
		int result;
		try
		{
			ArenaUIController arenaUIController = (ArenaUIController)LuaObject.checkSelf(l);
			string playerName;
			LuaObject.checkType(l, 2, out playerName);
			arenaUIController.SetPlayerName(playerName);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601B0AB RID: 110763 RVA: 0x0081FCD8 File Offset: 0x0081DED8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int SetPlayerLevel(IntPtr l)
	{
		int result;
		try
		{
			ArenaUIController arenaUIController = (ArenaUIController)LuaObject.checkSelf(l);
			int playerLevel;
			LuaObject.checkType(l, 2, out playerLevel);
			arenaUIController.SetPlayerLevel(playerLevel);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601B0AC RID: 110764 RVA: 0x0081FD30 File Offset: 0x0081DF30
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int SetArenaHonor(IntPtr l)
	{
		int result;
		try
		{
			ArenaUIController arenaUIController = (ArenaUIController)LuaObject.checkSelf(l);
			int arenaHonor;
			LuaObject.checkType(l, 2, out arenaHonor);
			arenaUIController.SetArenaHonor(arenaHonor);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601B0AD RID: 110765 RVA: 0x0081FD88 File Offset: 0x0081DF88
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int SetArenaTicket(IntPtr l)
	{
		int result;
		try
		{
			ArenaUIController arenaUIController = (ArenaUIController)LuaObject.checkSelf(l);
			int count;
			LuaObject.checkType(l, 2, out count);
			int countMax;
			LuaObject.checkType(l, 3, out countMax);
			arenaUIController.SetArenaTicket(count, countMax);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601B0AE RID: 110766 RVA: 0x0081FDEC File Offset: 0x0081DFEC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int SetBattlePower(IntPtr l)
	{
		int result;
		try
		{
			ArenaUIController arenaUIController = (ArenaUIController)LuaObject.checkSelf(l);
			int battlePower;
			LuaObject.checkType(l, 2, out battlePower);
			arenaUIController.SetBattlePower(battlePower);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601B0AF RID: 110767 RVA: 0x0081FE44 File Offset: 0x0081E044
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int ShowBuyArenaTicket(IntPtr l)
	{
		int result;
		try
		{
			ArenaUIController arenaUIController = (ArenaUIController)LuaObject.checkSelf(l);
			int ticketCount;
			LuaObject.checkType(l, 2, out ticketCount);
			int price;
			LuaObject.checkType(l, 3, out price);
			arenaUIController.ShowBuyArenaTicket(ticketCount, price);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601B0B0 RID: 110768 RVA: 0x0081FEA8 File Offset: 0x0081E0A8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int HideBuyArenaTicket(IntPtr l)
	{
		int result;
		try
		{
			ArenaUIController arenaUIController = (ArenaUIController)LuaObject.checkSelf(l);
			arenaUIController.HideBuyArenaTicket();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601B0B1 RID: 110769 RVA: 0x0081FEF4 File Offset: 0x0081E0F4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int SetOfflineArenaPointsAndLevel(IntPtr l)
	{
		int result;
		try
		{
			ArenaUIController arenaUIController = (ArenaUIController)LuaObject.checkSelf(l);
			int arenaPoints;
			LuaObject.checkType(l, 2, out arenaPoints);
			int arenaLevelId;
			LuaObject.checkType(l, 3, out arenaLevelId);
			arenaUIController.SetOfflineArenaPointsAndLevel(arenaPoints, arenaLevelId);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601B0B2 RID: 110770 RVA: 0x0081FF58 File Offset: 0x0081E158
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int SetOfflineWeekWin(IntPtr l)
	{
		int result;
		try
		{
			ArenaUIController arenaUIController = (ArenaUIController)LuaObject.checkSelf(l);
			int count;
			LuaObject.checkType(l, 2, out count);
			int countMax;
			LuaObject.checkType(l, 3, out countMax);
			arenaUIController.SetOfflineWeekWin(count, countMax);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601B0B3 RID: 110771 RVA: 0x0081FFBC File Offset: 0x0081E1BC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int SetOfflineInSettleTime(IntPtr l)
	{
		int result;
		try
		{
			ArenaUIController arenaUIController = (ArenaUIController)LuaObject.checkSelf(l);
			bool offlineInSettleTime;
			LuaObject.checkType(l, 2, out offlineInSettleTime);
			arenaUIController.SetOfflineInSettleTime(offlineInSettleTime);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601B0B4 RID: 110772 RVA: 0x00820014 File Offset: 0x0081E214
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int SetOfflineVictoryPointsRewardStatus(IntPtr l)
	{
		int result;
		try
		{
			ArenaUIController arenaUIController = (ArenaUIController)LuaObject.checkSelf(l);
			int idx;
			LuaObject.checkType(l, 2, out idx);
			int num;
			LuaObject.checkType(l, 3, out num);
			GainRewardStatus status;
			LuaObject.checkEnum<GainRewardStatus>(l, 4, out status);
			arenaUIController.SetOfflineVictoryPointsRewardStatus(idx, num, status);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601B0B5 RID: 110773 RVA: 0x00820088 File Offset: 0x0081E288
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int SetOfflineVictoryPointsRewardProgress(IntPtr l)
	{
		int result;
		try
		{
			ArenaUIController arenaUIController = (ArenaUIController)LuaObject.checkSelf(l);
			int victoryPoints;
			LuaObject.checkType(l, 2, out victoryPoints);
			int victoryPointsMax;
			LuaObject.checkType(l, 3, out victoryPointsMax);
			arenaUIController.SetOfflineVictoryPointsRewardProgress(victoryPoints, victoryPointsMax);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601B0B6 RID: 110774 RVA: 0x008200EC File Offset: 0x0081E2EC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int SetOfflineArenaOpponents(IntPtr l)
	{
		int result;
		try
		{
			ArenaUIController arenaUIController = (ArenaUIController)LuaObject.checkSelf(l);
			List<ArenaOpponent> opponents;
			LuaObject.checkType<List<ArenaOpponent>>(l, 2, out opponents);
			bool isGuardBattle;
			LuaObject.checkType(l, 3, out isGuardBattle);
			arenaUIController.SetOfflineArenaOpponents(opponents, isGuardBattle);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601B0B7 RID: 110775 RVA: 0x00820150 File Offset: 0x0081E350
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int SetOfflineArenaOpponentsRefreshTime(IntPtr l)
	{
		int result;
		try
		{
			ArenaUIController arenaUIController = (ArenaUIController)LuaObject.checkSelf(l);
			TimeSpan offlineArenaOpponentsRefreshTime;
			LuaObject.checkValueType<TimeSpan>(l, 2, out offlineArenaOpponentsRefreshTime);
			arenaUIController.SetOfflineArenaOpponentsRefreshTime(offlineArenaOpponentsRefreshTime);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601B0B8 RID: 110776 RVA: 0x008201A8 File Offset: 0x0081E3A8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int SetOfflineArenaBattleReports(IntPtr l)
	{
		int result;
		try
		{
			ArenaUIController arenaUIController = (ArenaUIController)LuaObject.checkSelf(l);
			List<ArenaBattleReport> offlineArenaBattleReports;
			LuaObject.checkType<List<ArenaBattleReport>>(l, 2, out offlineArenaBattleReports);
			arenaUIController.SetOfflineArenaBattleReports(offlineArenaBattleReports);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601B0B9 RID: 110777 RVA: 0x00820200 File Offset: 0x0081E400
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int SetOfflineArenaRankings(IntPtr l)
	{
		int result;
		try
		{
			ArenaUIController arenaUIController = (ArenaUIController)LuaObject.checkSelf(l);
			int mineRank;
			LuaObject.checkType(l, 2, out mineRank);
			List<ProArenaTopRankPlayer> players;
			LuaObject.checkType<List<ProArenaTopRankPlayer>>(l, 3, out players);
			arenaUIController.SetOfflineArenaRankings(mineRank, players);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601B0BA RID: 110778 RVA: 0x00820264 File Offset: 0x0081E464
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int ShowOfflinePanel(IntPtr l)
	{
		int result;
		try
		{
			ArenaUIController arenaUIController = (ArenaUIController)LuaObject.checkSelf(l);
			OfflineArenaPanelType panelType;
			LuaObject.checkEnum<OfflineArenaPanelType>(l, 2, out panelType);
			arenaUIController.ShowOfflinePanel(panelType);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601B0BB RID: 110779 RVA: 0x008202BC File Offset: 0x0081E4BC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int ShowArenaOpponent(IntPtr l)
	{
		int result;
		try
		{
			ArenaUIController arenaUIController = (ArenaUIController)LuaObject.checkSelf(l);
			ArenaOpponent opponent;
			LuaObject.checkType<ArenaOpponent>(l, 2, out opponent);
			List<BattleHero> heros;
			LuaObject.checkType<List<BattleHero>>(l, 3, out heros);
			int battlePower;
			LuaObject.checkType(l, 4, out battlePower);
			bool isRevenge;
			LuaObject.checkType(l, 5, out isRevenge);
			arenaUIController.ShowArenaOpponent(opponent, heros, battlePower, isRevenge);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601B0BC RID: 110780 RVA: 0x0082033C File Offset: 0x0081E53C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int SetOnlineScoreAndDan(IntPtr l)
	{
		int result;
		try
		{
			ArenaUIController arenaUIController = (ArenaUIController)LuaObject.checkSelf(l);
			int score;
			LuaObject.checkType(l, 2, out score);
			int danId;
			LuaObject.checkType(l, 3, out danId);
			arenaUIController.SetOnlineScoreAndDan(score, danId);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601B0BD RID: 110781 RVA: 0x008203A0 File Offset: 0x0081E5A0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int SetLadderMode(IntPtr l)
	{
		int result;
		try
		{
			ArenaUIController arenaUIController = (ArenaUIController)LuaObject.checkSelf(l);
			bool isOpened;
			LuaObject.checkType(l, 2, out isOpened);
			bool isPromote;
			LuaObject.checkType(l, 3, out isPromote);
			arenaUIController.SetLadderMode(isOpened, isPromote);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601B0BE RID: 110782 RVA: 0x00820404 File Offset: 0x0081E604
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int SetLadderOpenTime(IntPtr l)
	{
		int result;
		try
		{
			ArenaUIController arenaUIController = (ArenaUIController)LuaObject.checkSelf(l);
			string ladderOpenTime;
			LuaObject.checkType(l, 2, out ladderOpenTime);
			arenaUIController.SetLadderOpenTime(ladderOpenTime);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601B0BF RID: 110783 RVA: 0x0082045C File Offset: 0x0081E65C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int SetLadderWeekWin(IntPtr l)
	{
		int result;
		try
		{
			ArenaUIController arenaUIController = (ArenaUIController)LuaObject.checkSelf(l);
			int wins;
			LuaObject.checkType(l, 2, out wins);
			int matches;
			LuaObject.checkType(l, 3, out matches);
			arenaUIController.SetLadderWeekWin(wins, matches);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601B0C0 RID: 110784 RVA: 0x008204C0 File Offset: 0x0081E6C0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int SetOnlineWeekWinRewardStatus(IntPtr l)
	{
		int result;
		try
		{
			ArenaUIController arenaUIController = (ArenaUIController)LuaObject.checkSelf(l);
			int idx;
			LuaObject.checkType(l, 2, out idx);
			int num;
			LuaObject.checkType(l, 3, out num);
			GainRewardStatus status;
			LuaObject.checkEnum<GainRewardStatus>(l, 4, out status);
			arenaUIController.SetOnlineWeekWinRewardStatus(idx, num, status);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601B0C1 RID: 110785 RVA: 0x00820534 File Offset: 0x0081E734
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int SetOnlineWeekWinRewardProgress(IntPtr l)
	{
		int result;
		try
		{
			ArenaUIController arenaUIController = (ArenaUIController)LuaObject.checkSelf(l);
			int wins;
			LuaObject.checkType(l, 2, out wins);
			int countMax;
			LuaObject.checkType(l, 3, out countMax);
			arenaUIController.SetOnlineWeekWinRewardProgress(wins, countMax);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601B0C2 RID: 110786 RVA: 0x00820598 File Offset: 0x0081E798
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int ShowPromoteBattle(IntPtr l)
	{
		int result;
		try
		{
			ArenaUIController arenaUIController = (ArenaUIController)LuaObject.checkSelf(l);
			int danId;
			LuaObject.checkType(l, 2, out danId);
			arenaUIController.ShowPromoteBattle(danId);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601B0C3 RID: 110787 RVA: 0x008205F0 File Offset: 0x0081E7F0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int ShowPromoteSucceed(IntPtr l)
	{
		int result;
		try
		{
			ArenaUIController arenaUIController = (ArenaUIController)LuaObject.checkSelf(l);
			int danId;
			LuaObject.checkType(l, 2, out danId);
			arenaUIController.ShowPromoteSucceed(danId);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601B0C4 RID: 110788 RVA: 0x00820648 File Offset: 0x0081E848
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int SetPromoteBattleStatus(IntPtr l)
	{
		int result;
		try
		{
			ArenaUIController arenaUIController = (ArenaUIController)LuaObject.checkSelf(l);
			int danId;
			LuaObject.checkType(l, 2, out danId);
			List<RealTimePVPBattleReport> promoteBattleReports;
			LuaObject.checkType<List<RealTimePVPBattleReport>>(l, 3, out promoteBattleReports);
			arenaUIController.SetPromoteBattleStatus(danId, promoteBattleReports);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601B0C5 RID: 110789 RVA: 0x008206AC File Offset: 0x0081E8AC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int SetOnlineDans(IntPtr l)
	{
		int result;
		try
		{
			ArenaUIController arenaUIController = (ArenaUIController)LuaObject.checkSelf(l);
			List<ConfigDataRealTimePVPDanInfo> danInfos;
			LuaObject.checkType<List<ConfigDataRealTimePVPDanInfo>>(l, 2, out danInfos);
			int danId;
			LuaObject.checkType(l, 3, out danId);
			arenaUIController.SetOnlineDans(danInfos, danId);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601B0C6 RID: 110790 RVA: 0x00820710 File Offset: 0x0081E910
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int SetOnlineArenaBattleReports(IntPtr l)
	{
		int result;
		try
		{
			ArenaUIController arenaUIController = (ArenaUIController)LuaObject.checkSelf(l);
			List<RealTimePVPBattleReport> onlineArenaBattleReports;
			LuaObject.checkType<List<RealTimePVPBattleReport>>(l, 2, out onlineArenaBattleReports);
			arenaUIController.SetOnlineArenaBattleReports(onlineArenaBattleReports);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601B0C7 RID: 110791 RVA: 0x00820768 File Offset: 0x0081E968
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int SetOnlineArenaRankings(IntPtr l)
	{
		int result;
		try
		{
			ArenaUIController arenaUIController = (ArenaUIController)LuaObject.checkSelf(l);
			int mineRank;
			LuaObject.checkType(l, 2, out mineRank);
			List<ProRealTimePVPLeaderboardPlayerInfo> playerInfos;
			LuaObject.checkType<List<ProRealTimePVPLeaderboardPlayerInfo>>(l, 3, out playerInfos);
			List<ProUserSummary> userSummarys;
			LuaObject.checkType<List<ProUserSummary>>(l, 4, out userSummarys);
			bool isGlobal;
			LuaObject.checkType(l, 5, out isGlobal);
			arenaUIController.SetOnlineArenaRankings(mineRank, playerInfos, userSummarys, isGlobal);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601B0C8 RID: 110792 RVA: 0x008207E8 File Offset: 0x0081E9E8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int ShowGlobalRankingToggle(IntPtr l)
	{
		int result;
		try
		{
			ArenaUIController arenaUIController = (ArenaUIController)LuaObject.checkSelf(l);
			bool show;
			LuaObject.checkType(l, 2, out show);
			arenaUIController.ShowGlobalRankingToggle(show);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601B0C9 RID: 110793 RVA: 0x00820840 File Offset: 0x0081EA40
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int ShowOnlinePanel(IntPtr l)
	{
		int result;
		try
		{
			ArenaUIController arenaUIController = (ArenaUIController)LuaObject.checkSelf(l);
			OnlineArenaPanelType panelType;
			LuaObject.checkEnum<OnlineArenaPanelType>(l, 2, out panelType);
			arenaUIController.ShowOnlinePanel(panelType);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601B0CA RID: 110794 RVA: 0x00820898 File Offset: 0x0081EA98
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int ShowMatchingNow(IntPtr l)
	{
		int result;
		try
		{
			ArenaUIController arenaUIController = (ArenaUIController)LuaObject.checkSelf(l);
			arenaUIController.ShowMatchingNow();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601B0CB RID: 110795 RVA: 0x008208E4 File Offset: 0x0081EAE4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int HideMatchingNow(IntPtr l)
	{
		int result;
		try
		{
			ArenaUIController arenaUIController = (ArenaUIController)LuaObject.checkSelf(l);
			arenaUIController.HideMatchingNow();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601B0CC RID: 110796 RVA: 0x00820930 File Offset: 0x0081EB30
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int SetMatchingNowTime(IntPtr l)
	{
		int result;
		try
		{
			ArenaUIController arenaUIController = (ArenaUIController)LuaObject.checkSelf(l);
			TimeSpan matchingNowTime;
			LuaObject.checkValueType<TimeSpan>(l, 2, out matchingNowTime);
			arenaUIController.SetMatchingNowTime(matchingNowTime);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601B0CD RID: 110797 RVA: 0x00820988 File Offset: 0x0081EB88
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int SetMatchingPredictTime(IntPtr l)
	{
		int result;
		try
		{
			ArenaUIController arenaUIController = (ArenaUIController)LuaObject.checkSelf(l);
			TimeSpan matchingPredictTime;
			LuaObject.checkValueType<TimeSpan>(l, 2, out matchingPredictTime);
			arenaUIController.SetMatchingPredictTime(matchingPredictTime);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601B0CE RID: 110798 RVA: 0x008209E0 File Offset: 0x0081EBE0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int IsMatchingNowPredictTimeActive(IntPtr l)
	{
		int result;
		try
		{
			ArenaUIController arenaUIController = (ArenaUIController)LuaObject.checkSelf(l);
			bool b = arenaUIController.IsMatchingNowPredictTimeActive();
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, b);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601B0CF RID: 110799 RVA: 0x00820A34 File Offset: 0x0081EC34
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int ShowMatchingFailed(IntPtr l)
	{
		int result;
		try
		{
			ArenaUIController arenaUIController = (ArenaUIController)LuaObject.checkSelf(l);
			arenaUIController.ShowMatchingFailed();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601B0D0 RID: 110800 RVA: 0x00820A80 File Offset: 0x0081EC80
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int OnBindFiledsCompleted(IntPtr l)
	{
		int result;
		try
		{
			ArenaUIController arenaUIController = (ArenaUIController)LuaObject.checkSelf(l);
			arenaUIController.m_luaExportHelper.OnBindFiledsCompleted();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601B0D1 RID: 110801 RVA: 0x00820AD4 File Offset: 0x0081ECD4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int ShowArenaTicketDesc(IntPtr l)
	{
		int result;
		try
		{
			ArenaUIController arenaUIController = (ArenaUIController)LuaObject.checkSelf(l);
			arenaUIController.m_luaExportHelper.ShowArenaTicketDesc();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601B0D2 RID: 110802 RVA: 0x00820B28 File Offset: 0x0081ED28
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int CloseArenaTicketDesc(IntPtr l)
	{
		int result;
		try
		{
			ArenaUIController arenaUIController = (ArenaUIController)LuaObject.checkSelf(l);
			arenaUIController.m_luaExportHelper.CloseArenaTicketDesc();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601B0D3 RID: 110803 RVA: 0x00820B7C File Offset: 0x0081ED7C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int CreateSpineGraphic(IntPtr l)
	{
		int result;
		try
		{
			ArenaUIController arenaUIController = (ArenaUIController)LuaObject.checkSelf(l);
			ConfigDataJobConnectionInfo jobConnectionInfo;
			LuaObject.checkType<ConfigDataJobConnectionInfo>(l, 2, out jobConnectionInfo);
			ConfigDataModelSkinResourceInfo skinResInfo;
			LuaObject.checkType<ConfigDataModelSkinResourceInfo>(l, 3, out skinResInfo);
			UISpineGraphic o = arenaUIController.m_luaExportHelper.CreateSpineGraphic(jobConnectionInfo, skinResInfo);
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

	// Token: 0x0601B0D4 RID: 110804 RVA: 0x00820BF0 File Offset: 0x0081EDF0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int AddRewardPreviewGoods(IntPtr l)
	{
		int result;
		try
		{
			ArenaUIController arenaUIController = (ArenaUIController)LuaObject.checkSelf(l);
			List<Goods> goods;
			LuaObject.checkType<List<Goods>>(l, 2, out goods);
			arenaUIController.m_luaExportHelper.AddRewardPreviewGoods(goods);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601B0D5 RID: 110805 RVA: 0x00820C4C File Offset: 0x0081EE4C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int OnReturnButtonClick(IntPtr l)
	{
		int result;
		try
		{
			ArenaUIController arenaUIController = (ArenaUIController)LuaObject.checkSelf(l);
			arenaUIController.m_luaExportHelper.OnReturnButtonClick();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601B0D6 RID: 110806 RVA: 0x00820CA0 File Offset: 0x0081EEA0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int OnHelpButtonClick(IntPtr l)
	{
		int result;
		try
		{
			ArenaUIController arenaUIController = (ArenaUIController)LuaObject.checkSelf(l);
			arenaUIController.m_luaExportHelper.OnHelpButtonClick();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601B0D7 RID: 110807 RVA: 0x00820CF4 File Offset: 0x0081EEF4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int OnRewardPreviewBackgroundButtonClick(IntPtr l)
	{
		int result;
		try
		{
			ArenaUIController arenaUIController = (ArenaUIController)LuaObject.checkSelf(l);
			arenaUIController.m_luaExportHelper.OnRewardPreviewBackgroundButtonClick();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601B0D8 RID: 110808 RVA: 0x00820D48 File Offset: 0x0081EF48
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int OnAddArenaTicketButtonClick(IntPtr l)
	{
		int result;
		try
		{
			ArenaUIController arenaUIController = (ArenaUIController)LuaObject.checkSelf(l);
			arenaUIController.m_luaExportHelper.OnAddArenaTicketButtonClick();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601B0D9 RID: 110809 RVA: 0x00820D9C File Offset: 0x0081EF9C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int OnBuyArenaTicketBackgroundButtonClick(IntPtr l)
	{
		int result;
		try
		{
			ArenaUIController arenaUIController = (ArenaUIController)LuaObject.checkSelf(l);
			arenaUIController.m_luaExportHelper.OnBuyArenaTicketBackgroundButtonClick();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601B0DA RID: 110810 RVA: 0x00820DF0 File Offset: 0x0081EFF0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int OnBuyArenaTicketBuyButtonClick(IntPtr l)
	{
		int result;
		try
		{
			ArenaUIController arenaUIController = (ArenaUIController)LuaObject.checkSelf(l);
			arenaUIController.m_luaExportHelper.OnBuyArenaTicketBuyButtonClick();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601B0DB RID: 110811 RVA: 0x00820E44 File Offset: 0x0081F044
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int OnSwitchButtonClick(IntPtr l)
	{
		int result;
		try
		{
			ArenaUIController arenaUIController = (ArenaUIController)LuaObject.checkSelf(l);
			arenaUIController.m_luaExportHelper.OnSwitchButtonClick();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601B0DC RID: 110812 RVA: 0x00820E98 File Offset: 0x0081F098
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int OfflineOnBindFiledsCompleted(IntPtr l)
	{
		int result;
		try
		{
			ArenaUIController arenaUIController = (ArenaUIController)LuaObject.checkSelf(l);
			arenaUIController.m_luaExportHelper.OfflineOnBindFiledsCompleted();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601B0DD RID: 110813 RVA: 0x00820EEC File Offset: 0x0081F0EC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int ShowAutoBattleTips(IntPtr l)
	{
		int result;
		try
		{
			ArenaUIController arenaUIController = (ArenaUIController)LuaObject.checkSelf(l);
			arenaUIController.m_luaExportHelper.ShowAutoBattleTips();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601B0DE RID: 110814 RVA: 0x00820F40 File Offset: 0x0081F140
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int HideAutoBattleTips(IntPtr l)
	{
		int result;
		try
		{
			ArenaUIController arenaUIController = (ArenaUIController)LuaObject.checkSelf(l);
			arenaUIController.m_luaExportHelper.HideAutoBattleTips();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601B0DF RID: 110815 RVA: 0x00820F94 File Offset: 0x0081F194
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int HideArenaOpponent(IntPtr l)
	{
		int result;
		try
		{
			ArenaUIController arenaUIController = (ArenaUIController)LuaObject.checkSelf(l);
			arenaUIController.m_luaExportHelper.HideArenaOpponent();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601B0E0 RID: 110816 RVA: 0x00820FE8 File Offset: 0x0081F1E8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int ClearOpponentGraphcs(IntPtr l)
	{
		int result;
		try
		{
			ArenaUIController arenaUIController = (ArenaUIController)LuaObject.checkSelf(l);
			arenaUIController.m_luaExportHelper.ClearOpponentGraphcs();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601B0E1 RID: 110817 RVA: 0x0082103C File Offset: 0x0081F23C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int OnOfflineClashToggle(IntPtr l)
	{
		int result;
		try
		{
			ArenaUIController arenaUIController = (ArenaUIController)LuaObject.checkSelf(l);
			bool on;
			LuaObject.checkType(l, 2, out on);
			arenaUIController.m_luaExportHelper.OnOfflineClashToggle(on);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601B0E2 RID: 110818 RVA: 0x00821098 File Offset: 0x0081F298
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int OnOfflineBattleReportToggle(IntPtr l)
	{
		int result;
		try
		{
			ArenaUIController arenaUIController = (ArenaUIController)LuaObject.checkSelf(l);
			bool on;
			LuaObject.checkType(l, 2, out on);
			arenaUIController.m_luaExportHelper.OnOfflineBattleReportToggle(on);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601B0E3 RID: 110819 RVA: 0x008210F4 File Offset: 0x0081F2F4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int OnOfflineRankingToggle(IntPtr l)
	{
		int result;
		try
		{
			ArenaUIController arenaUIController = (ArenaUIController)LuaObject.checkSelf(l);
			bool on;
			LuaObject.checkType(l, 2, out on);
			arenaUIController.m_luaExportHelper.OnOfflineRankingToggle(on);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601B0E4 RID: 110820 RVA: 0x00821150 File Offset: 0x0081F350
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int OnOfflineArenaPointRewardButtonClick(IntPtr l)
	{
		int result;
		try
		{
			ArenaUIController arenaUIController = (ArenaUIController)LuaObject.checkSelf(l);
			arenaUIController.m_luaExportHelper.OnOfflineArenaPointRewardButtonClick();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601B0E5 RID: 110821 RVA: 0x008211A4 File Offset: 0x0081F3A4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int OnOfflineArenaPointRewardCloseButtonClick(IntPtr l)
	{
		int result;
		try
		{
			ArenaUIController arenaUIController = (ArenaUIController)LuaObject.checkSelf(l);
			arenaUIController.m_luaExportHelper.OnOfflineArenaPointRewardCloseButtonClick();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601B0E6 RID: 110822 RVA: 0x008211F8 File Offset: 0x0081F3F8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int OnOfflineVictoryPointsRewardButtonClick(IntPtr l)
	{
		int result;
		try
		{
			ArenaUIController arenaUIController = (ArenaUIController)LuaObject.checkSelf(l);
			GainRewardButton b;
			LuaObject.checkType<GainRewardButton>(l, 2, out b);
			arenaUIController.m_luaExportHelper.OnOfflineVictoryPointsRewardButtonClick(b);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601B0E7 RID: 110823 RVA: 0x00821254 File Offset: 0x0081F454
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int OnOfflineArenaOpponentAttackButtonClick(IntPtr l)
	{
		int result;
		try
		{
			ArenaUIController arenaUIController = (ArenaUIController)LuaObject.checkSelf(l);
			ArenaOpponentListItemUIController ctrl;
			LuaObject.checkType<ArenaOpponentListItemUIController>(l, 2, out ctrl);
			arenaUIController.m_luaExportHelper.OnOfflineArenaOpponentAttackButtonClick(ctrl);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601B0E8 RID: 110824 RVA: 0x008212B0 File Offset: 0x0081F4B0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int OnOfflineBattleReportRevengeButtonClick(IntPtr l)
	{
		int result;
		try
		{
			ArenaUIController arenaUIController = (ArenaUIController)LuaObject.checkSelf(l);
			OfflineArenaBattleReportListItemUIController ctrl;
			LuaObject.checkType<OfflineArenaBattleReportListItemUIController>(l, 2, out ctrl);
			arenaUIController.m_luaExportHelper.OnOfflineBattleReportRevengeButtonClick(ctrl);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601B0E9 RID: 110825 RVA: 0x0082130C File Offset: 0x0081F50C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int OnOfflineBattleReportReplayButtonClick(IntPtr l)
	{
		int result;
		try
		{
			ArenaUIController arenaUIController = (ArenaUIController)LuaObject.checkSelf(l);
			OfflineArenaBattleReportListItemUIController ctrl;
			LuaObject.checkType<OfflineArenaBattleReportListItemUIController>(l, 2, out ctrl);
			arenaUIController.m_luaExportHelper.OnOfflineBattleReportReplayButtonClick(ctrl);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601B0EA RID: 110826 RVA: 0x00821368 File Offset: 0x0081F568
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int OnDefendButtonClick(IntPtr l)
	{
		int result;
		try
		{
			ArenaUIController arenaUIController = (ArenaUIController)LuaObject.checkSelf(l);
			arenaUIController.m_luaExportHelper.OnDefendButtonClick();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601B0EB RID: 110827 RVA: 0x008213BC File Offset: 0x0081F5BC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int OnAttackConfirmButtonClick(IntPtr l)
	{
		int result;
		try
		{
			ArenaUIController arenaUIController = (ArenaUIController)LuaObject.checkSelf(l);
			arenaUIController.m_luaExportHelper.OnAttackConfirmButtonClick();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601B0EC RID: 110828 RVA: 0x00821410 File Offset: 0x0081F610
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int OnAutoBattleButtonClick(IntPtr l)
	{
		int result;
		try
		{
			ArenaUIController arenaUIController = (ArenaUIController)LuaObject.checkSelf(l);
			arenaUIController.m_luaExportHelper.OnAutoBattleButtonClick();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601B0ED RID: 110829 RVA: 0x00821464 File Offset: 0x0081F664
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int OnAttackBackgroundButtonClick(IntPtr l)
	{
		int result;
		try
		{
			ArenaUIController arenaUIController = (ArenaUIController)LuaObject.checkSelf(l);
			arenaUIController.m_luaExportHelper.OnAttackBackgroundButtonClick();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601B0EE RID: 110830 RVA: 0x008214B8 File Offset: 0x0081F6B8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int OnAutoBattleTipsConfirmButtonClick(IntPtr l)
	{
		int result;
		try
		{
			ArenaUIController arenaUIController = (ArenaUIController)LuaObject.checkSelf(l);
			arenaUIController.m_luaExportHelper.OnAutoBattleTipsConfirmButtonClick();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601B0EF RID: 110831 RVA: 0x0082150C File Offset: 0x0081F70C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int OnAutoBattleTipsCancelButtonClick(IntPtr l)
	{
		int result;
		try
		{
			ArenaUIController arenaUIController = (ArenaUIController)LuaObject.checkSelf(l);
			arenaUIController.m_luaExportHelper.OnAutoBattleTipsCancelButtonClick();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601B0F0 RID: 110832 RVA: 0x00821560 File Offset: 0x0081F760
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int OnlineOnBindFiledsCompleted(IntPtr l)
	{
		int result;
		try
		{
			ArenaUIController arenaUIController = (ArenaUIController)LuaObject.checkSelf(l);
			arenaUIController.m_luaExportHelper.OnlineOnBindFiledsCompleted();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601B0F1 RID: 110833 RVA: 0x008215B4 File Offset: 0x0081F7B4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int OnOnlineClashToggle(IntPtr l)
	{
		int result;
		try
		{
			ArenaUIController arenaUIController = (ArenaUIController)LuaObject.checkSelf(l);
			bool on;
			LuaObject.checkType(l, 2, out on);
			arenaUIController.m_luaExportHelper.OnOnlineClashToggle(on);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601B0F2 RID: 110834 RVA: 0x00821610 File Offset: 0x0081F810
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int OnOnlineBattleReportToggle(IntPtr l)
	{
		int result;
		try
		{
			ArenaUIController arenaUIController = (ArenaUIController)LuaObject.checkSelf(l);
			bool on;
			LuaObject.checkType(l, 2, out on);
			arenaUIController.m_luaExportHelper.OnOnlineBattleReportToggle(on);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601B0F3 RID: 110835 RVA: 0x0082166C File Offset: 0x0081F86C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int OnOnlineDanToggle(IntPtr l)
	{
		int result;
		try
		{
			ArenaUIController arenaUIController = (ArenaUIController)LuaObject.checkSelf(l);
			bool on;
			LuaObject.checkType(l, 2, out on);
			arenaUIController.m_luaExportHelper.OnOnlineDanToggle(on);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601B0F4 RID: 110836 RVA: 0x008216C8 File Offset: 0x0081F8C8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int OnOnlineLocalRankingToggle(IntPtr l)
	{
		int result;
		try
		{
			ArenaUIController arenaUIController = (ArenaUIController)LuaObject.checkSelf(l);
			bool on;
			LuaObject.checkType(l, 2, out on);
			arenaUIController.m_luaExportHelper.OnOnlineLocalRankingToggle(on);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601B0F5 RID: 110837 RVA: 0x00821724 File Offset: 0x0081F924
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int OnOnlineGlobalRankingToggle(IntPtr l)
	{
		int result;
		try
		{
			ArenaUIController arenaUIController = (ArenaUIController)LuaObject.checkSelf(l);
			bool on;
			LuaObject.checkType(l, 2, out on);
			arenaUIController.m_luaExportHelper.OnOnlineGlobalRankingToggle(on);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601B0F6 RID: 110838 RVA: 0x00821780 File Offset: 0x0081F980
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int OnOnlineWeekWinRewardButtonClick(IntPtr l)
	{
		int result;
		try
		{
			ArenaUIController arenaUIController = (ArenaUIController)LuaObject.checkSelf(l);
			GainRewardButton b;
			LuaObject.checkType<GainRewardButton>(l, 2, out b);
			arenaUIController.m_luaExportHelper.OnOnlineWeekWinRewardButtonClick(b);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601B0F7 RID: 110839 RVA: 0x008217DC File Offset: 0x0081F9DC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int OnOnlineBattleReportReplayButtonClick(IntPtr l)
	{
		int result;
		try
		{
			ArenaUIController arenaUIController = (ArenaUIController)LuaObject.checkSelf(l);
			OnlineArenaBattleReportListItemUIController ctrl;
			LuaObject.checkType<OnlineArenaBattleReportListItemUIController>(l, 2, out ctrl);
			arenaUIController.m_luaExportHelper.OnOnlineBattleReportReplayButtonClick(ctrl);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601B0F8 RID: 110840 RVA: 0x00821838 File Offset: 0x0081FA38
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int OnOnlineClashLadderChallengeButtonClick(IntPtr l)
	{
		int result;
		try
		{
			ArenaUIController arenaUIController = (ArenaUIController)LuaObject.checkSelf(l);
			arenaUIController.m_luaExportHelper.OnOnlineClashLadderChallengeButtonClick();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601B0F9 RID: 110841 RVA: 0x0082188C File Offset: 0x0081FA8C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int OnOnlineClashCasualChallengeButtonClick(IntPtr l)
	{
		int result;
		try
		{
			ArenaUIController arenaUIController = (ArenaUIController)LuaObject.checkSelf(l);
			arenaUIController.m_luaExportHelper.OnOnlineClashCasualChallengeButtonClick();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601B0FA RID: 110842 RVA: 0x008218E0 File Offset: 0x0081FAE0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int OnMatchingFailedConfirmButtonClick(IntPtr l)
	{
		int result;
		try
		{
			ArenaUIController arenaUIController = (ArenaUIController)LuaObject.checkSelf(l);
			arenaUIController.m_luaExportHelper.OnMatchingFailedConfirmButtonClick();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601B0FB RID: 110843 RVA: 0x00821934 File Offset: 0x0081FB34
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int OnMatchingNowCancelButtonClick(IntPtr l)
	{
		int result;
		try
		{
			ArenaUIController arenaUIController = (ArenaUIController)LuaObject.checkSelf(l);
			arenaUIController.m_luaExportHelper.OnMatchingNowCancelButtonClick();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601B0FC RID: 110844 RVA: 0x00821988 File Offset: 0x0081FB88
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int OnOnlineArenaRankingRewardButtonClick(IntPtr l)
	{
		int result;
		try
		{
			ArenaUIController arenaUIController = (ArenaUIController)LuaObject.checkSelf(l);
			arenaUIController.m_luaExportHelper.OnOnlineArenaRankingRewardButtonClick();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601B0FD RID: 110845 RVA: 0x008219DC File Offset: 0x0081FBDC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int OnOnlineArenaRankingRewardCloseButtonClick(IntPtr l)
	{
		int result;
		try
		{
			ArenaUIController arenaUIController = (ArenaUIController)LuaObject.checkSelf(l);
			arenaUIController.m_luaExportHelper.OnOnlineArenaRankingRewardCloseButtonClick();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601B0FE RID: 110846 RVA: 0x00821A30 File Offset: 0x0081FC30
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int OnPromoteBattleConfirmButtonClick(IntPtr l)
	{
		int result;
		try
		{
			ArenaUIController arenaUIController = (ArenaUIController)LuaObject.checkSelf(l);
			arenaUIController.m_luaExportHelper.OnPromoteBattleConfirmButtonClick();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601B0FF RID: 110847 RVA: 0x00821A84 File Offset: 0x0081FC84
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int OnPromoteSucceedConfirmButtonClick(IntPtr l)
	{
		int result;
		try
		{
			ArenaUIController arenaUIController = (ArenaUIController)LuaObject.checkSelf(l);
			arenaUIController.m_luaExportHelper.OnPromoteSucceedConfirmButtonClick();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601B100 RID: 110848 RVA: 0x00821AD8 File Offset: 0x0081FCD8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_Initlize(IntPtr l)
	{
		int result;
		try
		{
			ArenaUIController arenaUIController = (ArenaUIController)LuaObject.checkSelf(l);
			string ctrlName;
			LuaObject.checkType(l, 2, out ctrlName);
			bool bindNow;
			LuaObject.checkType(l, 3, out bindNow);
			arenaUIController.m_luaExportHelper.__callBase_Initlize(ctrlName, bindNow);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601B101 RID: 110849 RVA: 0x00821B44 File Offset: 0x0081FD44
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_BindFields(IntPtr l)
	{
		int result;
		try
		{
			ArenaUIController arenaUIController = (ArenaUIController)LuaObject.checkSelf(l);
			arenaUIController.m_luaExportHelper.__callBase_BindFields();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601B102 RID: 110850 RVA: 0x00821B98 File Offset: 0x0081FD98
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_OnBindFiledsCompleted(IntPtr l)
	{
		int result;
		try
		{
			ArenaUIController arenaUIController = (ArenaUIController)LuaObject.checkSelf(l);
			arenaUIController.m_luaExportHelper.__callBase_OnBindFiledsCompleted();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601B103 RID: 110851 RVA: 0x00821BEC File Offset: 0x0081FDEC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_BindFieldImpl(IntPtr l)
	{
		int result;
		try
		{
			ArenaUIController arenaUIController = (ArenaUIController)LuaObject.checkSelf(l);
			Type fieldType;
			LuaObject.checkType(l, 2, out fieldType);
			string path;
			LuaObject.checkType(l, 3, out path);
			AutoBindAttribute.InitState initState;
			LuaObject.checkEnum<AutoBindAttribute.InitState>(l, 4, out initState);
			string fieldName;
			LuaObject.checkType(l, 5, out fieldName);
			string ctrlName;
			LuaObject.checkType(l, 6, out ctrlName);
			bool optional;
			LuaObject.checkType(l, 7, out optional);
			UnityEngine.Object o = arenaUIController.m_luaExportHelper.__callBase_BindFieldImpl(fieldType, path, initState, fieldName, ctrlName, optional);
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

	// Token: 0x0601B104 RID: 110852 RVA: 0x00821C94 File Offset: 0x0081FE94
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_Clear(IntPtr l)
	{
		int result;
		try
		{
			ArenaUIController arenaUIController = (ArenaUIController)LuaObject.checkSelf(l);
			arenaUIController.m_luaExportHelper.__callBase_Clear();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601B105 RID: 110853 RVA: 0x00821CE8 File Offset: 0x0081FEE8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_OnButtonClick(IntPtr l)
	{
		int result;
		try
		{
			ArenaUIController arenaUIController = (ArenaUIController)LuaObject.checkSelf(l);
			Button button;
			LuaObject.checkType<Button>(l, 2, out button);
			string fieldName;
			LuaObject.checkType(l, 3, out fieldName);
			arenaUIController.m_luaExportHelper.__callBase_OnButtonClick(button, fieldName);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601B106 RID: 110854 RVA: 0x00821D54 File Offset: 0x0081FF54
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_SetButtonClickListener(IntPtr l)
	{
		int result;
		try
		{
			int total = LuaDLL.lua_gettop(l);
			if (LuaObject.matchType(l, total, 2, typeof(string[]), typeof(Action<UIControllerBase>)))
			{
				ArenaUIController arenaUIController = (ArenaUIController)LuaObject.checkSelf(l);
				string[] fieldNames;
				LuaObject.checkArray<string>(l, 2, out fieldNames);
				Action<UIControllerBase> action;
				LuaObject.checkDelegate<Action<UIControllerBase>>(l, 3, out action);
				arenaUIController.m_luaExportHelper.__callBase_SetButtonClickListener(fieldNames, action);
				LuaObject.pushValue(l, true);
				result = 1;
			}
			else if (LuaObject.matchType(l, total, 2, typeof(string), typeof(Action<UIControllerBase>)))
			{
				ArenaUIController arenaUIController2 = (ArenaUIController)LuaObject.checkSelf(l);
				string fieldName;
				LuaObject.checkType(l, 2, out fieldName);
				Action<UIControllerBase> action2;
				LuaObject.checkDelegate<Action<UIControllerBase>>(l, 3, out action2);
				arenaUIController2.m_luaExportHelper.__callBase_SetButtonClickListener(fieldName, action2);
				LuaObject.pushValue(l, true);
				result = 1;
			}
			else
			{
				LuaObject.pushValue(l, false);
				LuaDLL.lua_pushstring(l, "No matched override function __callBase_SetButtonClickListener to call");
				result = 2;
			}
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601B107 RID: 110855 RVA: 0x00821E64 File Offset: 0x00820064
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_SetButtonDoubleClickListener(IntPtr l)
	{
		int result;
		try
		{
			ArenaUIController arenaUIController = (ArenaUIController)LuaObject.checkSelf(l);
			string fieldName;
			LuaObject.checkType(l, 2, out fieldName);
			Action<UIControllerBase> action;
			LuaObject.checkDelegate<Action<UIControllerBase>>(l, 3, out action);
			arenaUIController.m_luaExportHelper.__callBase_SetButtonDoubleClickListener(fieldName, action);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601B108 RID: 110856 RVA: 0x00821ED0 File Offset: 0x008200D0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_SetButtonLongPressStartListener(IntPtr l)
	{
		int result;
		try
		{
			ArenaUIController arenaUIController = (ArenaUIController)LuaObject.checkSelf(l);
			string fieldName;
			LuaObject.checkType(l, 2, out fieldName);
			Action<UIControllerBase> action;
			LuaObject.checkDelegate<Action<UIControllerBase>>(l, 3, out action);
			arenaUIController.m_luaExportHelper.__callBase_SetButtonLongPressStartListener(fieldName, action);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601B109 RID: 110857 RVA: 0x00821F3C File Offset: 0x0082013C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_SetButtonLongPressingListener(IntPtr l)
	{
		int result;
		try
		{
			ArenaUIController arenaUIController = (ArenaUIController)LuaObject.checkSelf(l);
			string fieldName;
			LuaObject.checkType(l, 2, out fieldName);
			Action<UIControllerBase> action;
			LuaObject.checkDelegate<Action<UIControllerBase>>(l, 3, out action);
			arenaUIController.m_luaExportHelper.__callBase_SetButtonLongPressingListener(fieldName, action);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601B10A RID: 110858 RVA: 0x00821FA8 File Offset: 0x008201A8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_SetButtonLongPressEndListener(IntPtr l)
	{
		int result;
		try
		{
			ArenaUIController arenaUIController = (ArenaUIController)LuaObject.checkSelf(l);
			string fieldName;
			LuaObject.checkType(l, 2, out fieldName);
			Action<UIControllerBase> action;
			LuaObject.checkDelegate<Action<UIControllerBase>>(l, 3, out action);
			arenaUIController.m_luaExportHelper.__callBase_SetButtonLongPressEndListener(fieldName, action);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601B10B RID: 110859 RVA: 0x00822014 File Offset: 0x00820214
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_SetToggleValueChangedListener(IntPtr l)
	{
		int result;
		try
		{
			int total = LuaDLL.lua_gettop(l);
			if (LuaObject.matchType(l, total, 2, typeof(string[]), typeof(Action<UIControllerBase, bool>)))
			{
				ArenaUIController arenaUIController = (ArenaUIController)LuaObject.checkSelf(l);
				string[] fieldNames;
				LuaObject.checkArray<string>(l, 2, out fieldNames);
				Action<UIControllerBase, bool> action;
				LuaObject.checkDelegate<Action<UIControllerBase, bool>>(l, 3, out action);
				arenaUIController.m_luaExportHelper.__callBase_SetToggleValueChangedListener(fieldNames, action);
				LuaObject.pushValue(l, true);
				result = 1;
			}
			else if (LuaObject.matchType(l, total, 2, typeof(string), typeof(Action<UIControllerBase, bool>)))
			{
				ArenaUIController arenaUIController2 = (ArenaUIController)LuaObject.checkSelf(l);
				string fieldName;
				LuaObject.checkType(l, 2, out fieldName);
				Action<UIControllerBase, bool> action2;
				LuaObject.checkDelegate<Action<UIControllerBase, bool>>(l, 3, out action2);
				arenaUIController2.m_luaExportHelper.__callBase_SetToggleValueChangedListener(fieldName, action2);
				LuaObject.pushValue(l, true);
				result = 1;
			}
			else
			{
				LuaObject.pushValue(l, false);
				LuaDLL.lua_pushstring(l, "No matched override function __callBase_SetToggleValueChangedListener to call");
				result = 2;
			}
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601B10C RID: 110860 RVA: 0x00822124 File Offset: 0x00820324
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_ToString(IntPtr l)
	{
		int result;
		try
		{
			ArenaUIController arenaUIController = (ArenaUIController)LuaObject.checkSelf(l);
			string s = arenaUIController.m_luaExportHelper.__callBase_ToString();
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, s);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601B10D RID: 110861 RVA: 0x00822180 File Offset: 0x00820380
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callDele_EventOnDefend(IntPtr l)
	{
		int result;
		try
		{
			ArenaUIController arenaUIController = (ArenaUIController)LuaObject.checkSelf(l);
			arenaUIController.m_luaExportHelper.__callDele_EventOnDefend();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601B10E RID: 110862 RVA: 0x008221D4 File Offset: 0x008203D4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __clearDele_EventOnDefend(IntPtr l)
	{
		int result;
		try
		{
			ArenaUIController arenaUIController = (ArenaUIController)LuaObject.checkSelf(l);
			arenaUIController.m_luaExportHelper.__clearDele_EventOnDefend();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601B10F RID: 110863 RVA: 0x00822228 File Offset: 0x00820428
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callDele_EventOnReturn(IntPtr l)
	{
		int result;
		try
		{
			ArenaUIController arenaUIController = (ArenaUIController)LuaObject.checkSelf(l);
			arenaUIController.m_luaExportHelper.__callDele_EventOnReturn();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601B110 RID: 110864 RVA: 0x0082227C File Offset: 0x0082047C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __clearDele_EventOnReturn(IntPtr l)
	{
		int result;
		try
		{
			ArenaUIController arenaUIController = (ArenaUIController)LuaObject.checkSelf(l);
			arenaUIController.m_luaExportHelper.__clearDele_EventOnReturn();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601B111 RID: 110865 RVA: 0x008222D0 File Offset: 0x008204D0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callDele_EventOnShowHelp(IntPtr l)
	{
		int result;
		try
		{
			ArenaUIController arenaUIController = (ArenaUIController)LuaObject.checkSelf(l);
			arenaUIController.m_luaExportHelper.__callDele_EventOnShowHelp();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601B112 RID: 110866 RVA: 0x00822324 File Offset: 0x00820524
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __clearDele_EventOnShowHelp(IntPtr l)
	{
		int result;
		try
		{
			ArenaUIController arenaUIController = (ArenaUIController)LuaObject.checkSelf(l);
			arenaUIController.m_luaExportHelper.__clearDele_EventOnShowHelp();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601B113 RID: 110867 RVA: 0x00822378 File Offset: 0x00820578
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callDele_EventOnShowBuyArenaTicket(IntPtr l)
	{
		int result;
		try
		{
			ArenaUIController arenaUIController = (ArenaUIController)LuaObject.checkSelf(l);
			arenaUIController.m_luaExportHelper.__callDele_EventOnShowBuyArenaTicket();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601B114 RID: 110868 RVA: 0x008223CC File Offset: 0x008205CC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __clearDele_EventOnShowBuyArenaTicket(IntPtr l)
	{
		int result;
		try
		{
			ArenaUIController arenaUIController = (ArenaUIController)LuaObject.checkSelf(l);
			arenaUIController.m_luaExportHelper.__clearDele_EventOnShowBuyArenaTicket();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601B115 RID: 110869 RVA: 0x00822420 File Offset: 0x00820620
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callDele_EventOnBuyArenaTicket(IntPtr l)
	{
		int result;
		try
		{
			ArenaUIController arenaUIController = (ArenaUIController)LuaObject.checkSelf(l);
			arenaUIController.m_luaExportHelper.__callDele_EventOnBuyArenaTicket();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601B116 RID: 110870 RVA: 0x00822474 File Offset: 0x00820674
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __clearDele_EventOnBuyArenaTicket(IntPtr l)
	{
		int result;
		try
		{
			ArenaUIController arenaUIController = (ArenaUIController)LuaObject.checkSelf(l);
			arenaUIController.m_luaExportHelper.__clearDele_EventOnBuyArenaTicket();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601B117 RID: 110871 RVA: 0x008224C8 File Offset: 0x008206C8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callDele_EventOnSwitchOnlineOffline(IntPtr l)
	{
		int result;
		try
		{
			ArenaUIController arenaUIController = (ArenaUIController)LuaObject.checkSelf(l);
			arenaUIController.m_luaExportHelper.__callDele_EventOnSwitchOnlineOffline();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601B118 RID: 110872 RVA: 0x0082251C File Offset: 0x0082071C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __clearDele_EventOnSwitchOnlineOffline(IntPtr l)
	{
		int result;
		try
		{
			ArenaUIController arenaUIController = (ArenaUIController)LuaObject.checkSelf(l);
			arenaUIController.m_luaExportHelper.__clearDele_EventOnSwitchOnlineOffline();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601B119 RID: 110873 RVA: 0x00822570 File Offset: 0x00820770
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callDele_EventOnShowOfflinePanel(IntPtr l)
	{
		int result;
		try
		{
			ArenaUIController arenaUIController = (ArenaUIController)LuaObject.checkSelf(l);
			OfflineArenaPanelType obj;
			LuaObject.checkEnum<OfflineArenaPanelType>(l, 2, out obj);
			arenaUIController.m_luaExportHelper.__callDele_EventOnShowOfflinePanel(obj);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601B11A RID: 110874 RVA: 0x008225CC File Offset: 0x008207CC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __clearDele_EventOnShowOfflinePanel(IntPtr l)
	{
		int result;
		try
		{
			ArenaUIController arenaUIController = (ArenaUIController)LuaObject.checkSelf(l);
			OfflineArenaPanelType obj;
			LuaObject.checkEnum<OfflineArenaPanelType>(l, 2, out obj);
			arenaUIController.m_luaExportHelper.__clearDele_EventOnShowOfflinePanel(obj);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601B11B RID: 110875 RVA: 0x00822628 File Offset: 0x00820828
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callDele_EventOnGainOfflineVictoryPointsReward(IntPtr l)
	{
		int result;
		try
		{
			ArenaUIController arenaUIController = (ArenaUIController)LuaObject.checkSelf(l);
			int obj;
			LuaObject.checkType(l, 2, out obj);
			arenaUIController.m_luaExportHelper.__callDele_EventOnGainOfflineVictoryPointsReward(obj);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601B11C RID: 110876 RVA: 0x00822684 File Offset: 0x00820884
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __clearDele_EventOnGainOfflineVictoryPointsReward(IntPtr l)
	{
		int result;
		try
		{
			ArenaUIController arenaUIController = (ArenaUIController)LuaObject.checkSelf(l);
			int obj;
			LuaObject.checkType(l, 2, out obj);
			arenaUIController.m_luaExportHelper.__clearDele_EventOnGainOfflineVictoryPointsReward(obj);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601B11D RID: 110877 RVA: 0x008226E0 File Offset: 0x008208E0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callDele_EventOnShowOfflineArenaOpponent(IntPtr l)
	{
		int result;
		try
		{
			ArenaUIController arenaUIController = (ArenaUIController)LuaObject.checkSelf(l);
			int obj;
			LuaObject.checkType(l, 2, out obj);
			arenaUIController.m_luaExportHelper.__callDele_EventOnShowOfflineArenaOpponent(obj);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601B11E RID: 110878 RVA: 0x0082273C File Offset: 0x0082093C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __clearDele_EventOnShowOfflineArenaOpponent(IntPtr l)
	{
		int result;
		try
		{
			ArenaUIController arenaUIController = (ArenaUIController)LuaObject.checkSelf(l);
			int obj;
			LuaObject.checkType(l, 2, out obj);
			arenaUIController.m_luaExportHelper.__clearDele_EventOnShowOfflineArenaOpponent(obj);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601B11F RID: 110879 RVA: 0x00822798 File Offset: 0x00820998
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callDele_EventOnAttackOfflineArenaOpponent(IntPtr l)
	{
		int result;
		try
		{
			ArenaUIController arenaUIController = (ArenaUIController)LuaObject.checkSelf(l);
			bool obj;
			LuaObject.checkType(l, 2, out obj);
			arenaUIController.m_luaExportHelper.__callDele_EventOnAttackOfflineArenaOpponent(obj);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601B120 RID: 110880 RVA: 0x008227F4 File Offset: 0x008209F4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __clearDele_EventOnAttackOfflineArenaOpponent(IntPtr l)
	{
		int result;
		try
		{
			ArenaUIController arenaUIController = (ArenaUIController)LuaObject.checkSelf(l);
			bool obj;
			LuaObject.checkType(l, 2, out obj);
			arenaUIController.m_luaExportHelper.__clearDele_EventOnAttackOfflineArenaOpponent(obj);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601B121 RID: 110881 RVA: 0x00822850 File Offset: 0x00820A50
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callDele_EventOnShowRevengeOfflineArenaOpponent(IntPtr l)
	{
		int result;
		try
		{
			ArenaUIController arenaUIController = (ArenaUIController)LuaObject.checkSelf(l);
			ArenaBattleReport obj;
			LuaObject.checkType<ArenaBattleReport>(l, 2, out obj);
			arenaUIController.m_luaExportHelper.__callDele_EventOnShowRevengeOfflineArenaOpponent(obj);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601B122 RID: 110882 RVA: 0x008228AC File Offset: 0x00820AAC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __clearDele_EventOnShowRevengeOfflineArenaOpponent(IntPtr l)
	{
		int result;
		try
		{
			ArenaUIController arenaUIController = (ArenaUIController)LuaObject.checkSelf(l);
			ArenaBattleReport obj;
			LuaObject.checkType<ArenaBattleReport>(l, 2, out obj);
			arenaUIController.m_luaExportHelper.__clearDele_EventOnShowRevengeOfflineArenaOpponent(obj);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601B123 RID: 110883 RVA: 0x00822908 File Offset: 0x00820B08
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callDele_EventOnRevengeOfflineArenaOpponent(IntPtr l)
	{
		int result;
		try
		{
			ArenaUIController arenaUIController = (ArenaUIController)LuaObject.checkSelf(l);
			bool obj;
			LuaObject.checkType(l, 2, out obj);
			arenaUIController.m_luaExportHelper.__callDele_EventOnRevengeOfflineArenaOpponent(obj);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601B124 RID: 110884 RVA: 0x00822964 File Offset: 0x00820B64
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __clearDele_EventOnRevengeOfflineArenaOpponent(IntPtr l)
	{
		int result;
		try
		{
			ArenaUIController arenaUIController = (ArenaUIController)LuaObject.checkSelf(l);
			bool obj;
			LuaObject.checkType(l, 2, out obj);
			arenaUIController.m_luaExportHelper.__clearDele_EventOnRevengeOfflineArenaOpponent(obj);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601B125 RID: 110885 RVA: 0x008229C0 File Offset: 0x00820BC0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callDele_EventOnOfflineBattleReportReplay(IntPtr l)
	{
		int result;
		try
		{
			ArenaUIController arenaUIController = (ArenaUIController)LuaObject.checkSelf(l);
			ArenaBattleReport obj;
			LuaObject.checkType<ArenaBattleReport>(l, 2, out obj);
			arenaUIController.m_luaExportHelper.__callDele_EventOnOfflineBattleReportReplay(obj);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601B126 RID: 110886 RVA: 0x00822A1C File Offset: 0x00820C1C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __clearDele_EventOnOfflineBattleReportReplay(IntPtr l)
	{
		int result;
		try
		{
			ArenaUIController arenaUIController = (ArenaUIController)LuaObject.checkSelf(l);
			ArenaBattleReport obj;
			LuaObject.checkType<ArenaBattleReport>(l, 2, out obj);
			arenaUIController.m_luaExportHelper.__clearDele_EventOnOfflineBattleReportReplay(obj);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601B127 RID: 110887 RVA: 0x00822A78 File Offset: 0x00820C78
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callDele_EventOnShowOnlinePanel(IntPtr l)
	{
		int result;
		try
		{
			ArenaUIController arenaUIController = (ArenaUIController)LuaObject.checkSelf(l);
			OnlineArenaPanelType obj;
			LuaObject.checkEnum<OnlineArenaPanelType>(l, 2, out obj);
			arenaUIController.m_luaExportHelper.__callDele_EventOnShowOnlinePanel(obj);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601B128 RID: 110888 RVA: 0x00822AD4 File Offset: 0x00820CD4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __clearDele_EventOnShowOnlinePanel(IntPtr l)
	{
		int result;
		try
		{
			ArenaUIController arenaUIController = (ArenaUIController)LuaObject.checkSelf(l);
			OnlineArenaPanelType obj;
			LuaObject.checkEnum<OnlineArenaPanelType>(l, 2, out obj);
			arenaUIController.m_luaExportHelper.__clearDele_EventOnShowOnlinePanel(obj);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601B129 RID: 110889 RVA: 0x00822B30 File Offset: 0x00820D30
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callDele_EventOnGainOnlineWeekWinReward(IntPtr l)
	{
		int result;
		try
		{
			ArenaUIController arenaUIController = (ArenaUIController)LuaObject.checkSelf(l);
			int obj;
			LuaObject.checkType(l, 2, out obj);
			arenaUIController.m_luaExportHelper.__callDele_EventOnGainOnlineWeekWinReward(obj);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601B12A RID: 110890 RVA: 0x00822B8C File Offset: 0x00820D8C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __clearDele_EventOnGainOnlineWeekWinReward(IntPtr l)
	{
		int result;
		try
		{
			ArenaUIController arenaUIController = (ArenaUIController)LuaObject.checkSelf(l);
			int obj;
			LuaObject.checkType(l, 2, out obj);
			arenaUIController.m_luaExportHelper.__clearDele_EventOnGainOnlineWeekWinReward(obj);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601B12B RID: 110891 RVA: 0x00822BE8 File Offset: 0x00820DE8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callDele_EventOnOnlineBattleReportReplay(IntPtr l)
	{
		int result;
		try
		{
			ArenaUIController arenaUIController = (ArenaUIController)LuaObject.checkSelf(l);
			RealTimePVPBattleReport obj;
			LuaObject.checkType<RealTimePVPBattleReport>(l, 2, out obj);
			arenaUIController.m_luaExportHelper.__callDele_EventOnOnlineBattleReportReplay(obj);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601B12C RID: 110892 RVA: 0x00822C44 File Offset: 0x00820E44
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __clearDele_EventOnOnlineBattleReportReplay(IntPtr l)
	{
		int result;
		try
		{
			ArenaUIController arenaUIController = (ArenaUIController)LuaObject.checkSelf(l);
			RealTimePVPBattleReport obj;
			LuaObject.checkType<RealTimePVPBattleReport>(l, 2, out obj);
			arenaUIController.m_luaExportHelper.__clearDele_EventOnOnlineBattleReportReplay(obj);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601B12D RID: 110893 RVA: 0x00822CA0 File Offset: 0x00820EA0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callDele_EventOnLadderChallenge(IntPtr l)
	{
		int result;
		try
		{
			ArenaUIController arenaUIController = (ArenaUIController)LuaObject.checkSelf(l);
			arenaUIController.m_luaExportHelper.__callDele_EventOnLadderChallenge();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601B12E RID: 110894 RVA: 0x00822CF4 File Offset: 0x00820EF4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __clearDele_EventOnLadderChallenge(IntPtr l)
	{
		int result;
		try
		{
			ArenaUIController arenaUIController = (ArenaUIController)LuaObject.checkSelf(l);
			arenaUIController.m_luaExportHelper.__clearDele_EventOnLadderChallenge();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601B12F RID: 110895 RVA: 0x00822D48 File Offset: 0x00820F48
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callDele_EventOnCasualChallenge(IntPtr l)
	{
		int result;
		try
		{
			ArenaUIController arenaUIController = (ArenaUIController)LuaObject.checkSelf(l);
			arenaUIController.m_luaExportHelper.__callDele_EventOnCasualChallenge();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601B130 RID: 110896 RVA: 0x00822D9C File Offset: 0x00820F9C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __clearDele_EventOnCasualChallenge(IntPtr l)
	{
		int result;
		try
		{
			ArenaUIController arenaUIController = (ArenaUIController)LuaObject.checkSelf(l);
			arenaUIController.m_luaExportHelper.__clearDele_EventOnCasualChallenge();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601B131 RID: 110897 RVA: 0x00822DF0 File Offset: 0x00820FF0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callDele_EventOnMatchingCancel(IntPtr l)
	{
		int result;
		try
		{
			ArenaUIController arenaUIController = (ArenaUIController)LuaObject.checkSelf(l);
			arenaUIController.m_luaExportHelper.__callDele_EventOnMatchingCancel();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601B132 RID: 110898 RVA: 0x00822E44 File Offset: 0x00821044
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __clearDele_EventOnMatchingCancel(IntPtr l)
	{
		int result;
		try
		{
			ArenaUIController arenaUIController = (ArenaUIController)LuaObject.checkSelf(l);
			arenaUIController.m_luaExportHelper.__clearDele_EventOnMatchingCancel();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601B133 RID: 110899 RVA: 0x00822E98 File Offset: 0x00821098
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_EventOnDefend(IntPtr l)
	{
		int result;
		try
		{
			ArenaUIController arenaUIController = (ArenaUIController)LuaObject.checkSelf(l);
			Action value;
			int num = LuaObject.checkDelegate<Action>(l, 2, out value);
			if (num != 0)
			{
				if (num == 1)
				{
					arenaUIController.EventOnDefend += value;
				}
				else if (num == 2)
				{
					arenaUIController.EventOnDefend -= value;
				}
			}
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601B134 RID: 110900 RVA: 0x00822F18 File Offset: 0x00821118
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_EventOnReturn(IntPtr l)
	{
		int result;
		try
		{
			ArenaUIController arenaUIController = (ArenaUIController)LuaObject.checkSelf(l);
			Action value;
			int num = LuaObject.checkDelegate<Action>(l, 2, out value);
			if (num != 0)
			{
				if (num == 1)
				{
					arenaUIController.EventOnReturn += value;
				}
				else if (num == 2)
				{
					arenaUIController.EventOnReturn -= value;
				}
			}
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601B135 RID: 110901 RVA: 0x00822F98 File Offset: 0x00821198
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_EventOnShowHelp(IntPtr l)
	{
		int result;
		try
		{
			ArenaUIController arenaUIController = (ArenaUIController)LuaObject.checkSelf(l);
			Action value;
			int num = LuaObject.checkDelegate<Action>(l, 2, out value);
			if (num != 0)
			{
				if (num == 1)
				{
					arenaUIController.EventOnShowHelp += value;
				}
				else if (num == 2)
				{
					arenaUIController.EventOnShowHelp -= value;
				}
			}
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601B136 RID: 110902 RVA: 0x00823018 File Offset: 0x00821218
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_EventOnShowBuyArenaTicket(IntPtr l)
	{
		int result;
		try
		{
			ArenaUIController arenaUIController = (ArenaUIController)LuaObject.checkSelf(l);
			Action value;
			int num = LuaObject.checkDelegate<Action>(l, 2, out value);
			if (num != 0)
			{
				if (num == 1)
				{
					arenaUIController.EventOnShowBuyArenaTicket += value;
				}
				else if (num == 2)
				{
					arenaUIController.EventOnShowBuyArenaTicket -= value;
				}
			}
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601B137 RID: 110903 RVA: 0x00823098 File Offset: 0x00821298
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_EventOnBuyArenaTicket(IntPtr l)
	{
		int result;
		try
		{
			ArenaUIController arenaUIController = (ArenaUIController)LuaObject.checkSelf(l);
			Action value;
			int num = LuaObject.checkDelegate<Action>(l, 2, out value);
			if (num != 0)
			{
				if (num == 1)
				{
					arenaUIController.EventOnBuyArenaTicket += value;
				}
				else if (num == 2)
				{
					arenaUIController.EventOnBuyArenaTicket -= value;
				}
			}
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601B138 RID: 110904 RVA: 0x00823118 File Offset: 0x00821318
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_EventOnSwitchOnlineOffline(IntPtr l)
	{
		int result;
		try
		{
			ArenaUIController arenaUIController = (ArenaUIController)LuaObject.checkSelf(l);
			Action value;
			int num = LuaObject.checkDelegate<Action>(l, 2, out value);
			if (num != 0)
			{
				if (num == 1)
				{
					arenaUIController.EventOnSwitchOnlineOffline += value;
				}
				else if (num == 2)
				{
					arenaUIController.EventOnSwitchOnlineOffline -= value;
				}
			}
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601B139 RID: 110905 RVA: 0x00823198 File Offset: 0x00821398
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_uiStateController(IntPtr l)
	{
		int result;
		try
		{
			ArenaUIController arenaUIController = (ArenaUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, arenaUIController.m_luaExportHelper.m_uiStateController);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601B13A RID: 110906 RVA: 0x008231F0 File Offset: 0x008213F0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_uiStateController(IntPtr l)
	{
		int result;
		try
		{
			ArenaUIController arenaUIController = (ArenaUIController)LuaObject.checkSelf(l);
			CommonUIStateController uiStateController;
			LuaObject.checkType<CommonUIStateController>(l, 2, out uiStateController);
			arenaUIController.m_luaExportHelper.m_uiStateController = uiStateController;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601B13B RID: 110907 RVA: 0x0082324C File Offset: 0x0082144C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_returnButton(IntPtr l)
	{
		int result;
		try
		{
			ArenaUIController arenaUIController = (ArenaUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, arenaUIController.m_luaExportHelper.m_returnButton);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601B13C RID: 110908 RVA: 0x008232A4 File Offset: 0x008214A4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_returnButton(IntPtr l)
	{
		int result;
		try
		{
			ArenaUIController arenaUIController = (ArenaUIController)LuaObject.checkSelf(l);
			Button returnButton;
			LuaObject.checkType<Button>(l, 2, out returnButton);
			arenaUIController.m_luaExportHelper.m_returnButton = returnButton;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601B13D RID: 110909 RVA: 0x00823300 File Offset: 0x00821500
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_helpButton(IntPtr l)
	{
		int result;
		try
		{
			ArenaUIController arenaUIController = (ArenaUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, arenaUIController.m_luaExportHelper.m_helpButton);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601B13E RID: 110910 RVA: 0x00823358 File Offset: 0x00821558
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_helpButton(IntPtr l)
	{
		int result;
		try
		{
			ArenaUIController arenaUIController = (ArenaUIController)LuaObject.checkSelf(l);
			Button helpButton;
			LuaObject.checkType<Button>(l, 2, out helpButton);
			arenaUIController.m_luaExportHelper.m_helpButton = helpButton;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601B13F RID: 110911 RVA: 0x008233B4 File Offset: 0x008215B4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_offlineArenaCoinText(IntPtr l)
	{
		int result;
		try
		{
			ArenaUIController arenaUIController = (ArenaUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, arenaUIController.m_luaExportHelper.m_offlineArenaCoinText);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601B140 RID: 110912 RVA: 0x0082340C File Offset: 0x0082160C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_offlineArenaCoinText(IntPtr l)
	{
		int result;
		try
		{
			ArenaUIController arenaUIController = (ArenaUIController)LuaObject.checkSelf(l);
			Text offlineArenaCoinText;
			LuaObject.checkType<Text>(l, 2, out offlineArenaCoinText);
			arenaUIController.m_luaExportHelper.m_offlineArenaCoinText = offlineArenaCoinText;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601B141 RID: 110913 RVA: 0x00823468 File Offset: 0x00821668
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_onlineArenaCoinText(IntPtr l)
	{
		int result;
		try
		{
			ArenaUIController arenaUIController = (ArenaUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, arenaUIController.m_luaExportHelper.m_onlineArenaCoinText);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601B142 RID: 110914 RVA: 0x008234C0 File Offset: 0x008216C0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_onlineArenaCoinText(IntPtr l)
	{
		int result;
		try
		{
			ArenaUIController arenaUIController = (ArenaUIController)LuaObject.checkSelf(l);
			Text onlineArenaCoinText;
			LuaObject.checkType<Text>(l, 2, out onlineArenaCoinText);
			arenaUIController.m_luaExportHelper.m_onlineArenaCoinText = onlineArenaCoinText;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601B143 RID: 110915 RVA: 0x0082351C File Offset: 0x0082171C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_arenaTicketButton(IntPtr l)
	{
		int result;
		try
		{
			ArenaUIController arenaUIController = (ArenaUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, arenaUIController.m_luaExportHelper.m_arenaTicketButton);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601B144 RID: 110916 RVA: 0x00823574 File Offset: 0x00821774
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_arenaTicketButton(IntPtr l)
	{
		int result;
		try
		{
			ArenaUIController arenaUIController = (ArenaUIController)LuaObject.checkSelf(l);
			Button arenaTicketButton;
			LuaObject.checkType<Button>(l, 2, out arenaTicketButton);
			arenaUIController.m_luaExportHelper.m_arenaTicketButton = arenaTicketButton;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601B145 RID: 110917 RVA: 0x008235D0 File Offset: 0x008217D0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_arenaTicketText(IntPtr l)
	{
		int result;
		try
		{
			ArenaUIController arenaUIController = (ArenaUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, arenaUIController.m_luaExportHelper.m_arenaTicketText);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601B146 RID: 110918 RVA: 0x00823628 File Offset: 0x00821828
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_arenaTicketText(IntPtr l)
	{
		int result;
		try
		{
			ArenaUIController arenaUIController = (ArenaUIController)LuaObject.checkSelf(l);
			Text arenaTicketText;
			LuaObject.checkType<Text>(l, 2, out arenaTicketText);
			arenaUIController.m_luaExportHelper.m_arenaTicketText = arenaTicketText;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601B147 RID: 110919 RVA: 0x00823684 File Offset: 0x00821884
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_addArenaTicketButton(IntPtr l)
	{
		int result;
		try
		{
			ArenaUIController arenaUIController = (ArenaUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, arenaUIController.m_luaExportHelper.m_addArenaTicketButton);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601B148 RID: 110920 RVA: 0x008236DC File Offset: 0x008218DC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_addArenaTicketButton(IntPtr l)
	{
		int result;
		try
		{
			ArenaUIController arenaUIController = (ArenaUIController)LuaObject.checkSelf(l);
			Button addArenaTicketButton;
			LuaObject.checkType<Button>(l, 2, out addArenaTicketButton);
			arenaUIController.m_luaExportHelper.m_addArenaTicketButton = addArenaTicketButton;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601B149 RID: 110921 RVA: 0x00823738 File Offset: 0x00821938
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_switchUIStateController(IntPtr l)
	{
		int result;
		try
		{
			ArenaUIController arenaUIController = (ArenaUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, arenaUIController.m_luaExportHelper.m_switchUIStateController);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601B14A RID: 110922 RVA: 0x00823790 File Offset: 0x00821990
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_switchUIStateController(IntPtr l)
	{
		int result;
		try
		{
			ArenaUIController arenaUIController = (ArenaUIController)LuaObject.checkSelf(l);
			CommonUIStateController switchUIStateController;
			LuaObject.checkType<CommonUIStateController>(l, 2, out switchUIStateController);
			arenaUIController.m_luaExportHelper.m_switchUIStateController = switchUIStateController;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601B14B RID: 110923 RVA: 0x008237EC File Offset: 0x008219EC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_switchButton(IntPtr l)
	{
		int result;
		try
		{
			ArenaUIController arenaUIController = (ArenaUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, arenaUIController.m_luaExportHelper.m_switchButton);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601B14C RID: 110924 RVA: 0x00823844 File Offset: 0x00821A44
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_switchButton(IntPtr l)
	{
		int result;
		try
		{
			ArenaUIController arenaUIController = (ArenaUIController)LuaObject.checkSelf(l);
			Button switchButton;
			LuaObject.checkType<Button>(l, 2, out switchButton);
			arenaUIController.m_luaExportHelper.m_switchButton = switchButton;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601B14D RID: 110925 RVA: 0x008238A0 File Offset: 0x00821AA0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_switchButtonUIStateController(IntPtr l)
	{
		int result;
		try
		{
			ArenaUIController arenaUIController = (ArenaUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, arenaUIController.m_luaExportHelper.m_switchButtonUIStateController);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601B14E RID: 110926 RVA: 0x008238F8 File Offset: 0x00821AF8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_switchButtonUIStateController(IntPtr l)
	{
		int result;
		try
		{
			ArenaUIController arenaUIController = (ArenaUIController)LuaObject.checkSelf(l);
			CommonUIStateController switchButtonUIStateController;
			LuaObject.checkType<CommonUIStateController>(l, 2, out switchButtonUIStateController);
			arenaUIController.m_luaExportHelper.m_switchButtonUIStateController = switchButtonUIStateController;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601B14F RID: 110927 RVA: 0x00823954 File Offset: 0x00821B54
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_offlineOnlineChangeUIStateController(IntPtr l)
	{
		int result;
		try
		{
			ArenaUIController arenaUIController = (ArenaUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, arenaUIController.m_luaExportHelper.m_offlineOnlineChangeUIStateController);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601B150 RID: 110928 RVA: 0x008239AC File Offset: 0x00821BAC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_offlineOnlineChangeUIStateController(IntPtr l)
	{
		int result;
		try
		{
			ArenaUIController arenaUIController = (ArenaUIController)LuaObject.checkSelf(l);
			CommonUIStateController offlineOnlineChangeUIStateController;
			LuaObject.checkType<CommonUIStateController>(l, 2, out offlineOnlineChangeUIStateController);
			arenaUIController.m_luaExportHelper.m_offlineOnlineChangeUIStateController = offlineOnlineChangeUIStateController;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601B151 RID: 110929 RVA: 0x00823A08 File Offset: 0x00821C08
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_autoBattleTipsUIStateController(IntPtr l)
	{
		int result;
		try
		{
			ArenaUIController arenaUIController = (ArenaUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, arenaUIController.m_luaExportHelper.m_autoBattleTipsUIStateController);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601B152 RID: 110930 RVA: 0x00823A60 File Offset: 0x00821C60
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_autoBattleTipsUIStateController(IntPtr l)
	{
		int result;
		try
		{
			ArenaUIController arenaUIController = (ArenaUIController)LuaObject.checkSelf(l);
			CommonUIStateController autoBattleTipsUIStateController;
			LuaObject.checkType<CommonUIStateController>(l, 2, out autoBattleTipsUIStateController);
			arenaUIController.m_luaExportHelper.m_autoBattleTipsUIStateController = autoBattleTipsUIStateController;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601B153 RID: 110931 RVA: 0x00823ABC File Offset: 0x00821CBC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_autoBattleTipsBackgroundButton(IntPtr l)
	{
		int result;
		try
		{
			ArenaUIController arenaUIController = (ArenaUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, arenaUIController.m_luaExportHelper.m_autoBattleTipsBackgroundButton);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601B154 RID: 110932 RVA: 0x00823B14 File Offset: 0x00821D14
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_autoBattleTipsBackgroundButton(IntPtr l)
	{
		int result;
		try
		{
			ArenaUIController arenaUIController = (ArenaUIController)LuaObject.checkSelf(l);
			Button autoBattleTipsBackgroundButton;
			LuaObject.checkType<Button>(l, 2, out autoBattleTipsBackgroundButton);
			arenaUIController.m_luaExportHelper.m_autoBattleTipsBackgroundButton = autoBattleTipsBackgroundButton;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601B155 RID: 110933 RVA: 0x00823B70 File Offset: 0x00821D70
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_autoBattleTipsShowToggle(IntPtr l)
	{
		int result;
		try
		{
			ArenaUIController arenaUIController = (ArenaUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, arenaUIController.m_luaExportHelper.m_autoBattleTipsShowToggle);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601B156 RID: 110934 RVA: 0x00823BC8 File Offset: 0x00821DC8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_autoBattleTipsShowToggle(IntPtr l)
	{
		int result;
		try
		{
			ArenaUIController arenaUIController = (ArenaUIController)LuaObject.checkSelf(l);
			Toggle autoBattleTipsShowToggle;
			LuaObject.checkType<Toggle>(l, 2, out autoBattleTipsShowToggle);
			arenaUIController.m_luaExportHelper.m_autoBattleTipsShowToggle = autoBattleTipsShowToggle;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601B157 RID: 110935 RVA: 0x00823C24 File Offset: 0x00821E24
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_autoBattleTipsConfirmButton(IntPtr l)
	{
		int result;
		try
		{
			ArenaUIController arenaUIController = (ArenaUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, arenaUIController.m_luaExportHelper.m_autoBattleTipsConfirmButton);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601B158 RID: 110936 RVA: 0x00823C7C File Offset: 0x00821E7C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_autoBattleTipsConfirmButton(IntPtr l)
	{
		int result;
		try
		{
			ArenaUIController arenaUIController = (ArenaUIController)LuaObject.checkSelf(l);
			Button autoBattleTipsConfirmButton;
			LuaObject.checkType<Button>(l, 2, out autoBattleTipsConfirmButton);
			arenaUIController.m_luaExportHelper.m_autoBattleTipsConfirmButton = autoBattleTipsConfirmButton;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601B159 RID: 110937 RVA: 0x00823CD8 File Offset: 0x00821ED8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_autoBattleTipsCancelButton(IntPtr l)
	{
		int result;
		try
		{
			ArenaUIController arenaUIController = (ArenaUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, arenaUIController.m_luaExportHelper.m_autoBattleTipsCancelButton);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601B15A RID: 110938 RVA: 0x00823D30 File Offset: 0x00821F30
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_autoBattleTipsCancelButton(IntPtr l)
	{
		int result;
		try
		{
			ArenaUIController arenaUIController = (ArenaUIController)LuaObject.checkSelf(l);
			Button autoBattleTipsCancelButton;
			LuaObject.checkType<Button>(l, 2, out autoBattleTipsCancelButton);
			arenaUIController.m_luaExportHelper.m_autoBattleTipsCancelButton = autoBattleTipsCancelButton;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601B15B RID: 110939 RVA: 0x00823D8C File Offset: 0x00821F8C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_rewardPreviewUIStateController(IntPtr l)
	{
		int result;
		try
		{
			ArenaUIController arenaUIController = (ArenaUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, arenaUIController.m_luaExportHelper.m_rewardPreviewUIStateController);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601B15C RID: 110940 RVA: 0x00823DE4 File Offset: 0x00821FE4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_rewardPreviewUIStateController(IntPtr l)
	{
		int result;
		try
		{
			ArenaUIController arenaUIController = (ArenaUIController)LuaObject.checkSelf(l);
			CommonUIStateController rewardPreviewUIStateController;
			LuaObject.checkType<CommonUIStateController>(l, 2, out rewardPreviewUIStateController);
			arenaUIController.m_luaExportHelper.m_rewardPreviewUIStateController = rewardPreviewUIStateController;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601B15D RID: 110941 RVA: 0x00823E40 File Offset: 0x00822040
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_rewardPreviewBackgroundButton(IntPtr l)
	{
		int result;
		try
		{
			ArenaUIController arenaUIController = (ArenaUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, arenaUIController.m_luaExportHelper.m_rewardPreviewBackgroundButton);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601B15E RID: 110942 RVA: 0x00823E98 File Offset: 0x00822098
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_rewardPreviewBackgroundButton(IntPtr l)
	{
		int result;
		try
		{
			ArenaUIController arenaUIController = (ArenaUIController)LuaObject.checkSelf(l);
			Button rewardPreviewBackgroundButton;
			LuaObject.checkType<Button>(l, 2, out rewardPreviewBackgroundButton);
			arenaUIController.m_luaExportHelper.m_rewardPreviewBackgroundButton = rewardPreviewBackgroundButton;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601B15F RID: 110943 RVA: 0x00823EF4 File Offset: 0x008220F4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_rewardPreviewScrollRect(IntPtr l)
	{
		int result;
		try
		{
			ArenaUIController arenaUIController = (ArenaUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, arenaUIController.m_luaExportHelper.m_rewardPreviewScrollRect);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601B160 RID: 110944 RVA: 0x00823F4C File Offset: 0x0082214C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_rewardPreviewScrollRect(IntPtr l)
	{
		int result;
		try
		{
			ArenaUIController arenaUIController = (ArenaUIController)LuaObject.checkSelf(l);
			ScrollRect rewardPreviewScrollRect;
			LuaObject.checkType<ScrollRect>(l, 2, out rewardPreviewScrollRect);
			arenaUIController.m_luaExportHelper.m_rewardPreviewScrollRect = rewardPreviewScrollRect;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601B161 RID: 110945 RVA: 0x00823FA8 File Offset: 0x008221A8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_arenaTicketDescGameObject(IntPtr l)
	{
		int result;
		try
		{
			ArenaUIController arenaUIController = (ArenaUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, arenaUIController.m_luaExportHelper.m_arenaTicketDescGameObject);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601B162 RID: 110946 RVA: 0x00824000 File Offset: 0x00822200
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_arenaTicketDescGameObject(IntPtr l)
	{
		int result;
		try
		{
			ArenaUIController arenaUIController = (ArenaUIController)LuaObject.checkSelf(l);
			GameObject arenaTicketDescGameObject;
			LuaObject.checkType<GameObject>(l, 2, out arenaTicketDescGameObject);
			arenaUIController.m_luaExportHelper.m_arenaTicketDescGameObject = arenaTicketDescGameObject;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601B163 RID: 110947 RVA: 0x0082405C File Offset: 0x0082225C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_arenaTicketDescUIStateCtrl(IntPtr l)
	{
		int result;
		try
		{
			ArenaUIController arenaUIController = (ArenaUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, arenaUIController.m_luaExportHelper.m_arenaTicketDescUIStateCtrl);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601B164 RID: 110948 RVA: 0x008240B4 File Offset: 0x008222B4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_arenaTicketDescUIStateCtrl(IntPtr l)
	{
		int result;
		try
		{
			ArenaUIController arenaUIController = (ArenaUIController)LuaObject.checkSelf(l);
			CommonUIStateController arenaTicketDescUIStateCtrl;
			LuaObject.checkType<CommonUIStateController>(l, 2, out arenaTicketDescUIStateCtrl);
			arenaUIController.m_luaExportHelper.m_arenaTicketDescUIStateCtrl = arenaTicketDescUIStateCtrl;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601B165 RID: 110949 RVA: 0x00824110 File Offset: 0x00822310
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_arenaTicketDescBackgroundButton(IntPtr l)
	{
		int result;
		try
		{
			ArenaUIController arenaUIController = (ArenaUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, arenaUIController.m_luaExportHelper.m_arenaTicketDescBackgroundButton);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601B166 RID: 110950 RVA: 0x00824168 File Offset: 0x00822368
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_arenaTicketDescBackgroundButton(IntPtr l)
	{
		int result;
		try
		{
			ArenaUIController arenaUIController = (ArenaUIController)LuaObject.checkSelf(l);
			Button arenaTicketDescBackgroundButton;
			LuaObject.checkType<Button>(l, 2, out arenaTicketDescBackgroundButton);
			arenaUIController.m_luaExportHelper.m_arenaTicketDescBackgroundButton = arenaTicketDescBackgroundButton;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601B167 RID: 110951 RVA: 0x008241C4 File Offset: 0x008223C4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_buyArenaTicketUIStateController(IntPtr l)
	{
		int result;
		try
		{
			ArenaUIController arenaUIController = (ArenaUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, arenaUIController.m_luaExportHelper.m_buyArenaTicketUIStateController);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601B168 RID: 110952 RVA: 0x0082421C File Offset: 0x0082241C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_buyArenaTicketUIStateController(IntPtr l)
	{
		int result;
		try
		{
			ArenaUIController arenaUIController = (ArenaUIController)LuaObject.checkSelf(l);
			CommonUIStateController buyArenaTicketUIStateController;
			LuaObject.checkType<CommonUIStateController>(l, 2, out buyArenaTicketUIStateController);
			arenaUIController.m_luaExportHelper.m_buyArenaTicketUIStateController = buyArenaTicketUIStateController;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601B169 RID: 110953 RVA: 0x00824278 File Offset: 0x00822478
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_buyArenaTicketBackgroundButton(IntPtr l)
	{
		int result;
		try
		{
			ArenaUIController arenaUIController = (ArenaUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, arenaUIController.m_luaExportHelper.m_buyArenaTicketBackgroundButton);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601B16A RID: 110954 RVA: 0x008242D0 File Offset: 0x008224D0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_buyArenaTicketBackgroundButton(IntPtr l)
	{
		int result;
		try
		{
			ArenaUIController arenaUIController = (ArenaUIController)LuaObject.checkSelf(l);
			Button buyArenaTicketBackgroundButton;
			LuaObject.checkType<Button>(l, 2, out buyArenaTicketBackgroundButton);
			arenaUIController.m_luaExportHelper.m_buyArenaTicketBackgroundButton = buyArenaTicketBackgroundButton;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601B16B RID: 110955 RVA: 0x0082432C File Offset: 0x0082252C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_buyArenaTicketCountText(IntPtr l)
	{
		int result;
		try
		{
			ArenaUIController arenaUIController = (ArenaUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, arenaUIController.m_luaExportHelper.m_buyArenaTicketCountText);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601B16C RID: 110956 RVA: 0x00824384 File Offset: 0x00822584
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_buyArenaTicketCountText(IntPtr l)
	{
		int result;
		try
		{
			ArenaUIController arenaUIController = (ArenaUIController)LuaObject.checkSelf(l);
			Text buyArenaTicketCountText;
			LuaObject.checkType<Text>(l, 2, out buyArenaTicketCountText);
			arenaUIController.m_luaExportHelper.m_buyArenaTicketCountText = buyArenaTicketCountText;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601B16D RID: 110957 RVA: 0x008243E0 File Offset: 0x008225E0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_buyArenaTicketBuyButton(IntPtr l)
	{
		int result;
		try
		{
			ArenaUIController arenaUIController = (ArenaUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, arenaUIController.m_luaExportHelper.m_buyArenaTicketBuyButton);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601B16E RID: 110958 RVA: 0x00824438 File Offset: 0x00822638
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_buyArenaTicketBuyButton(IntPtr l)
	{
		int result;
		try
		{
			ArenaUIController arenaUIController = (ArenaUIController)LuaObject.checkSelf(l);
			Button buyArenaTicketBuyButton;
			LuaObject.checkType<Button>(l, 2, out buyArenaTicketBuyButton);
			arenaUIController.m_luaExportHelper.m_buyArenaTicketBuyButton = buyArenaTicketBuyButton;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601B16F RID: 110959 RVA: 0x00824494 File Offset: 0x00822694
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_buyArenaTicketPriceText(IntPtr l)
	{
		int result;
		try
		{
			ArenaUIController arenaUIController = (ArenaUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, arenaUIController.m_luaExportHelper.m_buyArenaTicketPriceText);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601B170 RID: 110960 RVA: 0x008244EC File Offset: 0x008226EC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_buyArenaTicketPriceText(IntPtr l)
	{
		int result;
		try
		{
			ArenaUIController arenaUIController = (ArenaUIController)LuaObject.checkSelf(l);
			Text buyArenaTicketPriceText;
			LuaObject.checkType<Text>(l, 2, out buyArenaTicketPriceText);
			arenaUIController.m_luaExportHelper.m_buyArenaTicketPriceText = buyArenaTicketPriceText;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601B171 RID: 110961 RVA: 0x00824548 File Offset: 0x00822748
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_offineArenaPointRewardUIStateCtrl(IntPtr l)
	{
		int result;
		try
		{
			ArenaUIController arenaUIController = (ArenaUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, arenaUIController.m_luaExportHelper.m_offineArenaPointRewardUIStateCtrl);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601B172 RID: 110962 RVA: 0x008245A0 File Offset: 0x008227A0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_offineArenaPointRewardUIStateCtrl(IntPtr l)
	{
		int result;
		try
		{
			ArenaUIController arenaUIController = (ArenaUIController)LuaObject.checkSelf(l);
			CommonUIStateController offineArenaPointRewardUIStateCtrl;
			LuaObject.checkType<CommonUIStateController>(l, 2, out offineArenaPointRewardUIStateCtrl);
			arenaUIController.m_luaExportHelper.m_offineArenaPointRewardUIStateCtrl = offineArenaPointRewardUIStateCtrl;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601B173 RID: 110963 RVA: 0x008245FC File Offset: 0x008227FC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_offlineArenaPointRewardBGButton(IntPtr l)
	{
		int result;
		try
		{
			ArenaUIController arenaUIController = (ArenaUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, arenaUIController.m_luaExportHelper.m_offlineArenaPointRewardBGButton);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601B174 RID: 110964 RVA: 0x00824654 File Offset: 0x00822854
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_offlineArenaPointRewardBGButton(IntPtr l)
	{
		int result;
		try
		{
			ArenaUIController arenaUIController = (ArenaUIController)LuaObject.checkSelf(l);
			Button offlineArenaPointRewardBGButton;
			LuaObject.checkType<Button>(l, 2, out offlineArenaPointRewardBGButton);
			arenaUIController.m_luaExportHelper.m_offlineArenaPointRewardBGButton = offlineArenaPointRewardBGButton;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601B175 RID: 110965 RVA: 0x008246B0 File Offset: 0x008228B0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_offlineArenaPointRewardCloseButton(IntPtr l)
	{
		int result;
		try
		{
			ArenaUIController arenaUIController = (ArenaUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, arenaUIController.m_luaExportHelper.m_offlineArenaPointRewardCloseButton);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601B176 RID: 110966 RVA: 0x00824708 File Offset: 0x00822908
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_offlineArenaPointRewardCloseButton(IntPtr l)
	{
		int result;
		try
		{
			ArenaUIController arenaUIController = (ArenaUIController)LuaObject.checkSelf(l);
			Button offlineArenaPointRewardCloseButton;
			LuaObject.checkType<Button>(l, 2, out offlineArenaPointRewardCloseButton);
			arenaUIController.m_luaExportHelper.m_offlineArenaPointRewardCloseButton = offlineArenaPointRewardCloseButton;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601B177 RID: 110967 RVA: 0x00824764 File Offset: 0x00822964
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_offlineArenaPointRewardScrollRect(IntPtr l)
	{
		int result;
		try
		{
			ArenaUIController arenaUIController = (ArenaUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, arenaUIController.m_luaExportHelper.m_offlineArenaPointRewardScrollRect);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601B178 RID: 110968 RVA: 0x008247BC File Offset: 0x008229BC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_offlineArenaPointRewardScrollRect(IntPtr l)
	{
		int result;
		try
		{
			ArenaUIController arenaUIController = (ArenaUIController)LuaObject.checkSelf(l);
			ScrollRect offlineArenaPointRewardScrollRect;
			LuaObject.checkType<ScrollRect>(l, 2, out offlineArenaPointRewardScrollRect);
			arenaUIController.m_luaExportHelper.m_offlineArenaPointRewardScrollRect = offlineArenaPointRewardScrollRect;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601B179 RID: 110969 RVA: 0x00824818 File Offset: 0x00822A18
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_onlineArenaRankingRewardUIStateCtrl(IntPtr l)
	{
		int result;
		try
		{
			ArenaUIController arenaUIController = (ArenaUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, arenaUIController.m_luaExportHelper.m_onlineArenaRankingRewardUIStateCtrl);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601B17A RID: 110970 RVA: 0x00824870 File Offset: 0x00822A70
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_onlineArenaRankingRewardUIStateCtrl(IntPtr l)
	{
		int result;
		try
		{
			ArenaUIController arenaUIController = (ArenaUIController)LuaObject.checkSelf(l);
			CommonUIStateController onlineArenaRankingRewardUIStateCtrl;
			LuaObject.checkType<CommonUIStateController>(l, 2, out onlineArenaRankingRewardUIStateCtrl);
			arenaUIController.m_luaExportHelper.m_onlineArenaRankingRewardUIStateCtrl = onlineArenaRankingRewardUIStateCtrl;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601B17B RID: 110971 RVA: 0x008248CC File Offset: 0x00822ACC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_onlineArenaRankingRewardBGButton(IntPtr l)
	{
		int result;
		try
		{
			ArenaUIController arenaUIController = (ArenaUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, arenaUIController.m_luaExportHelper.m_onlineArenaRankingRewardBGButton);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601B17C RID: 110972 RVA: 0x00824924 File Offset: 0x00822B24
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_onlineArenaRankingRewardBGButton(IntPtr l)
	{
		int result;
		try
		{
			ArenaUIController arenaUIController = (ArenaUIController)LuaObject.checkSelf(l);
			Button onlineArenaRankingRewardBGButton;
			LuaObject.checkType<Button>(l, 2, out onlineArenaRankingRewardBGButton);
			arenaUIController.m_luaExportHelper.m_onlineArenaRankingRewardBGButton = onlineArenaRankingRewardBGButton;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601B17D RID: 110973 RVA: 0x00824980 File Offset: 0x00822B80
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_onlineArenaRankingRewardCloseButton(IntPtr l)
	{
		int result;
		try
		{
			ArenaUIController arenaUIController = (ArenaUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, arenaUIController.m_luaExportHelper.m_onlineArenaRankingRewardCloseButton);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601B17E RID: 110974 RVA: 0x008249D8 File Offset: 0x00822BD8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_onlineArenaRankingRewardCloseButton(IntPtr l)
	{
		int result;
		try
		{
			ArenaUIController arenaUIController = (ArenaUIController)LuaObject.checkSelf(l);
			Button onlineArenaRankingRewardCloseButton;
			LuaObject.checkType<Button>(l, 2, out onlineArenaRankingRewardCloseButton);
			arenaUIController.m_luaExportHelper.m_onlineArenaRankingRewardCloseButton = onlineArenaRankingRewardCloseButton;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601B17F RID: 110975 RVA: 0x00824A34 File Offset: 0x00822C34
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_onlineArenaRankingRewardscrollRect(IntPtr l)
	{
		int result;
		try
		{
			ArenaUIController arenaUIController = (ArenaUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, arenaUIController.m_luaExportHelper.m_onlineArenaRankingRewardscrollRect);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601B180 RID: 110976 RVA: 0x00824A8C File Offset: 0x00822C8C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_onlineArenaRankingRewardscrollRect(IntPtr l)
	{
		int result;
		try
		{
			ArenaUIController arenaUIController = (ArenaUIController)LuaObject.checkSelf(l);
			ScrollRect onlineArenaRankingRewardscrollRect;
			LuaObject.checkType<ScrollRect>(l, 2, out onlineArenaRankingRewardscrollRect);
			arenaUIController.m_luaExportHelper.m_onlineArenaRankingRewardscrollRect = onlineArenaRankingRewardscrollRect;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601B181 RID: 110977 RVA: 0x00824AE8 File Offset: 0x00822CE8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_attackUIStateController(IntPtr l)
	{
		int result;
		try
		{
			ArenaUIController arenaUIController = (ArenaUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, arenaUIController.m_luaExportHelper.m_attackUIStateController);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601B182 RID: 110978 RVA: 0x00824B40 File Offset: 0x00822D40
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_attackUIStateController(IntPtr l)
	{
		int result;
		try
		{
			ArenaUIController arenaUIController = (ArenaUIController)LuaObject.checkSelf(l);
			CommonUIStateController attackUIStateController;
			LuaObject.checkType<CommonUIStateController>(l, 2, out attackUIStateController);
			arenaUIController.m_luaExportHelper.m_attackUIStateController = attackUIStateController;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601B183 RID: 110979 RVA: 0x00824B9C File Offset: 0x00822D9C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_attackBackgroundButton(IntPtr l)
	{
		int result;
		try
		{
			ArenaUIController arenaUIController = (ArenaUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, arenaUIController.m_luaExportHelper.m_attackBackgroundButton);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601B184 RID: 110980 RVA: 0x00824BF4 File Offset: 0x00822DF4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_attackBackgroundButton(IntPtr l)
	{
		int result;
		try
		{
			ArenaUIController arenaUIController = (ArenaUIController)LuaObject.checkSelf(l);
			Button attackBackgroundButton;
			LuaObject.checkType<Button>(l, 2, out attackBackgroundButton);
			arenaUIController.m_luaExportHelper.m_attackBackgroundButton = attackBackgroundButton;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601B185 RID: 110981 RVA: 0x00824C50 File Offset: 0x00822E50
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_attackBattlePowerText(IntPtr l)
	{
		int result;
		try
		{
			ArenaUIController arenaUIController = (ArenaUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, arenaUIController.m_luaExportHelper.m_attackBattlePowerText);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601B186 RID: 110982 RVA: 0x00824CA8 File Offset: 0x00822EA8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_attackBattlePowerText(IntPtr l)
	{
		int result;
		try
		{
			ArenaUIController arenaUIController = (ArenaUIController)LuaObject.checkSelf(l);
			Text attackBattlePowerText;
			LuaObject.checkType<Text>(l, 2, out attackBattlePowerText);
			arenaUIController.m_luaExportHelper.m_attackBattlePowerText = attackBattlePowerText;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601B187 RID: 110983 RVA: 0x00824D04 File Offset: 0x00822F04
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_attackConfirmButton(IntPtr l)
	{
		int result;
		try
		{
			ArenaUIController arenaUIController = (ArenaUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, arenaUIController.m_luaExportHelper.m_attackConfirmButton);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601B188 RID: 110984 RVA: 0x00824D5C File Offset: 0x00822F5C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_attackConfirmButton(IntPtr l)
	{
		int result;
		try
		{
			ArenaUIController arenaUIController = (ArenaUIController)LuaObject.checkSelf(l);
			Button attackConfirmButton;
			LuaObject.checkType<Button>(l, 2, out attackConfirmButton);
			arenaUIController.m_luaExportHelper.m_attackConfirmButton = attackConfirmButton;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601B189 RID: 110985 RVA: 0x00824DB8 File Offset: 0x00822FB8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_attackAutoConfirmButton(IntPtr l)
	{
		int result;
		try
		{
			ArenaUIController arenaUIController = (ArenaUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, arenaUIController.m_luaExportHelper.m_attackAutoConfirmButton);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601B18A RID: 110986 RVA: 0x00824E10 File Offset: 0x00823010
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_attackAutoConfirmButton(IntPtr l)
	{
		int result;
		try
		{
			ArenaUIController arenaUIController = (ArenaUIController)LuaObject.checkSelf(l);
			Button attackAutoConfirmButton;
			LuaObject.checkType<Button>(l, 2, out attackAutoConfirmButton);
			arenaUIController.m_luaExportHelper.m_attackAutoConfirmButton = attackAutoConfirmButton;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601B18B RID: 110987 RVA: 0x00824E6C File Offset: 0x0082306C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_attackGraphicsGameObject(IntPtr l)
	{
		int result;
		try
		{
			ArenaUIController arenaUIController = (ArenaUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, arenaUIController.m_luaExportHelper.m_attackGraphicsGameObject);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601B18C RID: 110988 RVA: 0x00824EC4 File Offset: 0x008230C4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_attackGraphicsGameObject(IntPtr l)
	{
		int result;
		try
		{
			ArenaUIController arenaUIController = (ArenaUIController)LuaObject.checkSelf(l);
			GameObject attackGraphicsGameObject;
			LuaObject.checkType<GameObject>(l, 2, out attackGraphicsGameObject);
			arenaUIController.m_luaExportHelper.m_attackGraphicsGameObject = attackGraphicsGameObject;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601B18D RID: 110989 RVA: 0x00824F20 File Offset: 0x00823120
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_attackPlayerIconImage(IntPtr l)
	{
		int result;
		try
		{
			ArenaUIController arenaUIController = (ArenaUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, arenaUIController.m_luaExportHelper.m_attackPlayerIconImage);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601B18E RID: 110990 RVA: 0x00824F78 File Offset: 0x00823178
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_attackPlayerIconImage(IntPtr l)
	{
		int result;
		try
		{
			ArenaUIController arenaUIController = (ArenaUIController)LuaObject.checkSelf(l);
			Image attackPlayerIconImage;
			LuaObject.checkType<Image>(l, 2, out attackPlayerIconImage);
			arenaUIController.m_luaExportHelper.m_attackPlayerIconImage = attackPlayerIconImage;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601B18F RID: 110991 RVA: 0x00824FD4 File Offset: 0x008231D4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_attackPlayerNameText(IntPtr l)
	{
		int result;
		try
		{
			ArenaUIController arenaUIController = (ArenaUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, arenaUIController.m_luaExportHelper.m_attackPlayerNameText);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601B190 RID: 110992 RVA: 0x0082502C File Offset: 0x0082322C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_attackPlayerNameText(IntPtr l)
	{
		int result;
		try
		{
			ArenaUIController arenaUIController = (ArenaUIController)LuaObject.checkSelf(l);
			Text attackPlayerNameText;
			LuaObject.checkType<Text>(l, 2, out attackPlayerNameText);
			arenaUIController.m_luaExportHelper.m_attackPlayerNameText = attackPlayerNameText;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601B191 RID: 110993 RVA: 0x00825088 File Offset: 0x00823288
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_attackPlayerLVText(IntPtr l)
	{
		int result;
		try
		{
			ArenaUIController arenaUIController = (ArenaUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, arenaUIController.m_luaExportHelper.m_attackPlayerLVText);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601B192 RID: 110994 RVA: 0x008250E0 File Offset: 0x008232E0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_attackPlayerLVText(IntPtr l)
	{
		int result;
		try
		{
			ArenaUIController arenaUIController = (ArenaUIController)LuaObject.checkSelf(l);
			Text attackPlayerLVText;
			LuaObject.checkType<Text>(l, 2, out attackPlayerLVText);
			arenaUIController.m_luaExportHelper.m_attackPlayerLVText = attackPlayerLVText;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601B193 RID: 110995 RVA: 0x0082513C File Offset: 0x0082333C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_attackPlayerArenaPointText(IntPtr l)
	{
		int result;
		try
		{
			ArenaUIController arenaUIController = (ArenaUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, arenaUIController.m_luaExportHelper.m_attackPlayerArenaPointText);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601B194 RID: 110996 RVA: 0x00825194 File Offset: 0x00823394
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_attackPlayerArenaPointText(IntPtr l)
	{
		int result;
		try
		{
			ArenaUIController arenaUIController = (ArenaUIController)LuaObject.checkSelf(l);
			Text attackPlayerArenaPointText;
			LuaObject.checkType<Text>(l, 2, out attackPlayerArenaPointText);
			arenaUIController.m_luaExportHelper.m_attackPlayerArenaPointText = attackPlayerArenaPointText;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601B195 RID: 110997 RVA: 0x008251F0 File Offset: 0x008233F0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_prefabsGameObject(IntPtr l)
	{
		int result;
		try
		{
			ArenaUIController arenaUIController = (ArenaUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, arenaUIController.m_luaExportHelper.m_prefabsGameObject);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601B196 RID: 110998 RVA: 0x00825248 File Offset: 0x00823448
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_prefabsGameObject(IntPtr l)
	{
		int result;
		try
		{
			ArenaUIController arenaUIController = (ArenaUIController)LuaObject.checkSelf(l);
			GameObject prefabsGameObject;
			LuaObject.checkType<GameObject>(l, 2, out prefabsGameObject);
			arenaUIController.m_luaExportHelper.m_prefabsGameObject = prefabsGameObject;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601B197 RID: 110999 RVA: 0x008252A4 File Offset: 0x008234A4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_arenaLevelListItemPrefab(IntPtr l)
	{
		int result;
		try
		{
			ArenaUIController arenaUIController = (ArenaUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, arenaUIController.m_luaExportHelper.m_arenaLevelListItemPrefab);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601B198 RID: 111000 RVA: 0x008252FC File Offset: 0x008234FC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_arenaLevelListItemPrefab(IntPtr l)
	{
		int result;
		try
		{
			ArenaUIController arenaUIController = (ArenaUIController)LuaObject.checkSelf(l);
			GameObject arenaLevelListItemPrefab;
			LuaObject.checkType<GameObject>(l, 2, out arenaLevelListItemPrefab);
			arenaUIController.m_luaExportHelper.m_arenaLevelListItemPrefab = arenaLevelListItemPrefab;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601B199 RID: 111001 RVA: 0x00825358 File Offset: 0x00823558
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_arenaRankingListItemPrefab(IntPtr l)
	{
		int result;
		try
		{
			ArenaUIController arenaUIController = (ArenaUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, arenaUIController.m_luaExportHelper.m_arenaRankingListItemPrefab);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601B19A RID: 111002 RVA: 0x008253B0 File Offset: 0x008235B0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_arenaRankingListItemPrefab(IntPtr l)
	{
		int result;
		try
		{
			ArenaUIController arenaUIController = (ArenaUIController)LuaObject.checkSelf(l);
			GameObject arenaRankingListItemPrefab;
			LuaObject.checkType<GameObject>(l, 2, out arenaRankingListItemPrefab);
			arenaUIController.m_luaExportHelper.m_arenaRankingListItemPrefab = arenaRankingListItemPrefab;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601B19B RID: 111003 RVA: 0x0082540C File Offset: 0x0082360C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_offlineArenaBattleReportListItemPrefab(IntPtr l)
	{
		int result;
		try
		{
			ArenaUIController arenaUIController = (ArenaUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, arenaUIController.m_luaExportHelper.m_offlineArenaBattleReportListItemPrefab);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601B19C RID: 111004 RVA: 0x00825464 File Offset: 0x00823664
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_offlineArenaBattleReportListItemPrefab(IntPtr l)
	{
		int result;
		try
		{
			ArenaUIController arenaUIController = (ArenaUIController)LuaObject.checkSelf(l);
			GameObject offlineArenaBattleReportListItemPrefab;
			LuaObject.checkType<GameObject>(l, 2, out offlineArenaBattleReportListItemPrefab);
			arenaUIController.m_luaExportHelper.m_offlineArenaBattleReportListItemPrefab = offlineArenaBattleReportListItemPrefab;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601B19D RID: 111005 RVA: 0x008254C0 File Offset: 0x008236C0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_arenaOpponentListItemPrefab(IntPtr l)
	{
		int result;
		try
		{
			ArenaUIController arenaUIController = (ArenaUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, arenaUIController.m_luaExportHelper.m_arenaOpponentListItemPrefab);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601B19E RID: 111006 RVA: 0x00825518 File Offset: 0x00823718
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_arenaOpponentListItemPrefab(IntPtr l)
	{
		int result;
		try
		{
			ArenaUIController arenaUIController = (ArenaUIController)LuaObject.checkSelf(l);
			GameObject arenaOpponentListItemPrefab;
			LuaObject.checkType<GameObject>(l, 2, out arenaOpponentListItemPrefab);
			arenaUIController.m_luaExportHelper.m_arenaOpponentListItemPrefab = arenaOpponentListItemPrefab;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601B19F RID: 111007 RVA: 0x00825574 File Offset: 0x00823774
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_arenaPointRewardListItemPrefab(IntPtr l)
	{
		int result;
		try
		{
			ArenaUIController arenaUIController = (ArenaUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, arenaUIController.m_luaExportHelper.m_arenaPointRewardListItemPrefab);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601B1A0 RID: 111008 RVA: 0x008255CC File Offset: 0x008237CC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_arenaPointRewardListItemPrefab(IntPtr l)
	{
		int result;
		try
		{
			ArenaUIController arenaUIController = (ArenaUIController)LuaObject.checkSelf(l);
			GameObject arenaPointRewardListItemPrefab;
			LuaObject.checkType<GameObject>(l, 2, out arenaPointRewardListItemPrefab);
			arenaUIController.m_luaExportHelper.m_arenaPointRewardListItemPrefab = arenaPointRewardListItemPrefab;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601B1A1 RID: 111009 RVA: 0x00825628 File Offset: 0x00823828
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_onlineArenaBattleReportListItemPrefab(IntPtr l)
	{
		int result;
		try
		{
			ArenaUIController arenaUIController = (ArenaUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, arenaUIController.m_luaExportHelper.m_onlineArenaBattleReportListItemPrefab);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601B1A2 RID: 111010 RVA: 0x00825680 File Offset: 0x00823880
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_onlineArenaBattleReportListItemPrefab(IntPtr l)
	{
		int result;
		try
		{
			ArenaUIController arenaUIController = (ArenaUIController)LuaObject.checkSelf(l);
			GameObject onlineArenaBattleReportListItemPrefab;
			LuaObject.checkType<GameObject>(l, 2, out onlineArenaBattleReportListItemPrefab);
			arenaUIController.m_luaExportHelper.m_onlineArenaBattleReportListItemPrefab = onlineArenaBattleReportListItemPrefab;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601B1A3 RID: 111011 RVA: 0x008256DC File Offset: 0x008238DC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_isIgnoreToggleEvent(IntPtr l)
	{
		int result;
		try
		{
			ArenaUIController arenaUIController = (ArenaUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, arenaUIController.m_luaExportHelper.m_isIgnoreToggleEvent);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601B1A4 RID: 111012 RVA: 0x00825734 File Offset: 0x00823934
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_isIgnoreToggleEvent(IntPtr l)
	{
		int result;
		try
		{
			ArenaUIController arenaUIController = (ArenaUIController)LuaObject.checkSelf(l);
			bool isIgnoreToggleEvent;
			LuaObject.checkType(l, 2, out isIgnoreToggleEvent);
			arenaUIController.m_luaExportHelper.m_isIgnoreToggleEvent = isIgnoreToggleEvent;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601B1A5 RID: 111013 RVA: 0x00825790 File Offset: 0x00823990
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_isRevengeOpponent(IntPtr l)
	{
		int result;
		try
		{
			ArenaUIController arenaUIController = (ArenaUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, arenaUIController.m_luaExportHelper.m_isRevengeOpponent);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601B1A6 RID: 111014 RVA: 0x008257E8 File Offset: 0x008239E8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_isRevengeOpponent(IntPtr l)
	{
		int result;
		try
		{
			ArenaUIController arenaUIController = (ArenaUIController)LuaObject.checkSelf(l);
			bool isRevengeOpponent;
			LuaObject.checkType(l, 2, out isRevengeOpponent);
			arenaUIController.m_luaExportHelper.m_isRevengeOpponent = isRevengeOpponent;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601B1A7 RID: 111015 RVA: 0x00825844 File Offset: 0x00823A44
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_s_isShowAutoBattleTips(IntPtr l)
	{
		int result;
		try
		{
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, ArenaUIController.LuaExportHelper.s_isShowAutoBattleTips);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601B1A8 RID: 111016 RVA: 0x0082588C File Offset: 0x00823A8C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_s_isShowAutoBattleTips(IntPtr l)
	{
		int result;
		try
		{
			bool s_isShowAutoBattleTips;
			LuaObject.checkType(l, 2, out s_isShowAutoBattleTips);
			ArenaUIController.LuaExportHelper.s_isShowAutoBattleTips = s_isShowAutoBattleTips;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601B1A9 RID: 111017 RVA: 0x008258D8 File Offset: 0x00823AD8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_offlineVictoryPointsRewardButtons(IntPtr l)
	{
		int result;
		try
		{
			ArenaUIController arenaUIController = (ArenaUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, arenaUIController.m_luaExportHelper.m_offlineVictoryPointsRewardButtons);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601B1AA RID: 111018 RVA: 0x00825930 File Offset: 0x00823B30
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_offlineVictoryPointsRewardButtons(IntPtr l)
	{
		int result;
		try
		{
			ArenaUIController arenaUIController = (ArenaUIController)LuaObject.checkSelf(l);
			GainRewardButton[] offlineVictoryPointsRewardButtons;
			LuaObject.checkArray<GainRewardButton>(l, 2, out offlineVictoryPointsRewardButtons);
			arenaUIController.m_luaExportHelper.m_offlineVictoryPointsRewardButtons = offlineVictoryPointsRewardButtons;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601B1AB RID: 111019 RVA: 0x0082598C File Offset: 0x00823B8C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_onlineWeekWinRewardButtons(IntPtr l)
	{
		int result;
		try
		{
			ArenaUIController arenaUIController = (ArenaUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, arenaUIController.m_luaExportHelper.m_onlineWeekWinRewardButtons);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601B1AC RID: 111020 RVA: 0x008259E4 File Offset: 0x00823BE4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_onlineWeekWinRewardButtons(IntPtr l)
	{
		int result;
		try
		{
			ArenaUIController arenaUIController = (ArenaUIController)LuaObject.checkSelf(l);
			GainRewardButton[] onlineWeekWinRewardButtons;
			LuaObject.checkArray<GainRewardButton>(l, 2, out onlineWeekWinRewardButtons);
			arenaUIController.m_luaExportHelper.m_onlineWeekWinRewardButtons = onlineWeekWinRewardButtons;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601B1AD RID: 111021 RVA: 0x00825A40 File Offset: 0x00823C40
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_onlineArenaLevelPool(IntPtr l)
	{
		int result;
		try
		{
			ArenaUIController arenaUIController = (ArenaUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, arenaUIController.m_luaExportHelper.m_onlineArenaLevelPool);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601B1AE RID: 111022 RVA: 0x00825A98 File Offset: 0x00823C98
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_onlineArenaLevelPool(IntPtr l)
	{
		int result;
		try
		{
			ArenaUIController arenaUIController = (ArenaUIController)LuaObject.checkSelf(l);
			GameObjectPool<ArenaLevelListItemUIController> onlineArenaLevelPool;
			LuaObject.checkType<GameObjectPool<ArenaLevelListItemUIController>>(l, 2, out onlineArenaLevelPool);
			arenaUIController.m_luaExportHelper.m_onlineArenaLevelPool = onlineArenaLevelPool;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601B1AF RID: 111023 RVA: 0x00825AF4 File Offset: 0x00823CF4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_opponentGraphics(IntPtr l)
	{
		int result;
		try
		{
			ArenaUIController arenaUIController = (ArenaUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, arenaUIController.m_luaExportHelper.m_opponentGraphics);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601B1B0 RID: 111024 RVA: 0x00825B4C File Offset: 0x00823D4C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_opponentGraphics(IntPtr l)
	{
		int result;
		try
		{
			ArenaUIController arenaUIController = (ArenaUIController)LuaObject.checkSelf(l);
			List<UISpineGraphic> opponentGraphics;
			LuaObject.checkType<List<UISpineGraphic>>(l, 2, out opponentGraphics);
			arenaUIController.m_luaExportHelper.m_opponentGraphics = opponentGraphics;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601B1B1 RID: 111025 RVA: 0x00825BA8 File Offset: 0x00823DA8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_EventOnShowOfflinePanel(IntPtr l)
	{
		int result;
		try
		{
			ArenaUIController arenaUIController = (ArenaUIController)LuaObject.checkSelf(l);
			Action<OfflineArenaPanelType> value;
			int num = LuaObject.checkDelegate<Action<OfflineArenaPanelType>>(l, 2, out value);
			if (num != 0)
			{
				if (num == 1)
				{
					arenaUIController.EventOnShowOfflinePanel += value;
				}
				else if (num == 2)
				{
					arenaUIController.EventOnShowOfflinePanel -= value;
				}
			}
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601B1B2 RID: 111026 RVA: 0x00825C28 File Offset: 0x00823E28
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_EventOnGainOfflineVictoryPointsReward(IntPtr l)
	{
		int result;
		try
		{
			ArenaUIController arenaUIController = (ArenaUIController)LuaObject.checkSelf(l);
			Action<int> value;
			int num = LuaObject.checkDelegate<Action<int>>(l, 2, out value);
			if (num != 0)
			{
				if (num == 1)
				{
					arenaUIController.EventOnGainOfflineVictoryPointsReward += value;
				}
				else if (num == 2)
				{
					arenaUIController.EventOnGainOfflineVictoryPointsReward -= value;
				}
			}
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601B1B3 RID: 111027 RVA: 0x00825CA8 File Offset: 0x00823EA8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_EventOnShowOfflineArenaOpponent(IntPtr l)
	{
		int result;
		try
		{
			ArenaUIController arenaUIController = (ArenaUIController)LuaObject.checkSelf(l);
			Action<int> value;
			int num = LuaObject.checkDelegate<Action<int>>(l, 2, out value);
			if (num != 0)
			{
				if (num == 1)
				{
					arenaUIController.EventOnShowOfflineArenaOpponent += value;
				}
				else if (num == 2)
				{
					arenaUIController.EventOnShowOfflineArenaOpponent -= value;
				}
			}
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601B1B4 RID: 111028 RVA: 0x00825D28 File Offset: 0x00823F28
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_EventOnAttackOfflineArenaOpponent(IntPtr l)
	{
		int result;
		try
		{
			ArenaUIController arenaUIController = (ArenaUIController)LuaObject.checkSelf(l);
			Action<bool> value;
			int num = LuaObject.checkDelegate<Action<bool>>(l, 2, out value);
			if (num != 0)
			{
				if (num == 1)
				{
					arenaUIController.EventOnAttackOfflineArenaOpponent += value;
				}
				else if (num == 2)
				{
					arenaUIController.EventOnAttackOfflineArenaOpponent -= value;
				}
			}
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601B1B5 RID: 111029 RVA: 0x00825DA8 File Offset: 0x00823FA8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_EventOnShowRevengeOfflineArenaOpponent(IntPtr l)
	{
		int result;
		try
		{
			ArenaUIController arenaUIController = (ArenaUIController)LuaObject.checkSelf(l);
			Action<ArenaBattleReport> value;
			int num = LuaObject.checkDelegate<Action<ArenaBattleReport>>(l, 2, out value);
			if (num != 0)
			{
				if (num == 1)
				{
					arenaUIController.EventOnShowRevengeOfflineArenaOpponent += value;
				}
				else if (num == 2)
				{
					arenaUIController.EventOnShowRevengeOfflineArenaOpponent -= value;
				}
			}
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601B1B6 RID: 111030 RVA: 0x00825E28 File Offset: 0x00824028
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_EventOnRevengeOfflineArenaOpponent(IntPtr l)
	{
		int result;
		try
		{
			ArenaUIController arenaUIController = (ArenaUIController)LuaObject.checkSelf(l);
			Action<bool> value;
			int num = LuaObject.checkDelegate<Action<bool>>(l, 2, out value);
			if (num != 0)
			{
				if (num == 1)
				{
					arenaUIController.EventOnRevengeOfflineArenaOpponent += value;
				}
				else if (num == 2)
				{
					arenaUIController.EventOnRevengeOfflineArenaOpponent -= value;
				}
			}
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601B1B7 RID: 111031 RVA: 0x00825EA8 File Offset: 0x008240A8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_EventOnOfflineBattleReportReplay(IntPtr l)
	{
		int result;
		try
		{
			ArenaUIController arenaUIController = (ArenaUIController)LuaObject.checkSelf(l);
			Action<ArenaBattleReport> value;
			int num = LuaObject.checkDelegate<Action<ArenaBattleReport>>(l, 2, out value);
			if (num != 0)
			{
				if (num == 1)
				{
					arenaUIController.EventOnOfflineBattleReportReplay += value;
				}
				else if (num == 2)
				{
					arenaUIController.EventOnOfflineBattleReportReplay -= value;
				}
			}
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601B1B8 RID: 111032 RVA: 0x00825F28 File Offset: 0x00824128
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_offlineGameObject(IntPtr l)
	{
		int result;
		try
		{
			ArenaUIController arenaUIController = (ArenaUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, arenaUIController.m_luaExportHelper.m_offlineGameObject);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601B1B9 RID: 111033 RVA: 0x00825F80 File Offset: 0x00824180
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_offlineGameObject(IntPtr l)
	{
		int result;
		try
		{
			ArenaUIController arenaUIController = (ArenaUIController)LuaObject.checkSelf(l);
			GameObject offlineGameObject;
			LuaObject.checkType<GameObject>(l, 2, out offlineGameObject);
			arenaUIController.m_luaExportHelper.m_offlineGameObject = offlineGameObject;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601B1BA RID: 111034 RVA: 0x00825FDC File Offset: 0x008241DC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_offlineMarginTransform(IntPtr l)
	{
		int result;
		try
		{
			ArenaUIController arenaUIController = (ArenaUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, arenaUIController.m_luaExportHelper.m_offlineMarginTransform);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601B1BB RID: 111035 RVA: 0x00826034 File Offset: 0x00824234
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_offlineMarginTransform(IntPtr l)
	{
		int result;
		try
		{
			ArenaUIController arenaUIController = (ArenaUIController)LuaObject.checkSelf(l);
			RectTransform offlineMarginTransform;
			LuaObject.checkType<RectTransform>(l, 2, out offlineMarginTransform);
			arenaUIController.m_luaExportHelper.m_offlineMarginTransform = offlineMarginTransform;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601B1BC RID: 111036 RVA: 0x00826090 File Offset: 0x00824290
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_offlineClashToggle(IntPtr l)
	{
		int result;
		try
		{
			ArenaUIController arenaUIController = (ArenaUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, arenaUIController.m_luaExportHelper.m_offlineClashToggle);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601B1BD RID: 111037 RVA: 0x008260E8 File Offset: 0x008242E8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_offlineClashToggle(IntPtr l)
	{
		int result;
		try
		{
			ArenaUIController arenaUIController = (ArenaUIController)LuaObject.checkSelf(l);
			Toggle offlineClashToggle;
			LuaObject.checkType<Toggle>(l, 2, out offlineClashToggle);
			arenaUIController.m_luaExportHelper.m_offlineClashToggle = offlineClashToggle;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601B1BE RID: 111038 RVA: 0x00826144 File Offset: 0x00824344
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_offlineBattleReportToggle(IntPtr l)
	{
		int result;
		try
		{
			ArenaUIController arenaUIController = (ArenaUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, arenaUIController.m_luaExportHelper.m_offlineBattleReportToggle);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601B1BF RID: 111039 RVA: 0x0082619C File Offset: 0x0082439C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_offlineBattleReportToggle(IntPtr l)
	{
		int result;
		try
		{
			ArenaUIController arenaUIController = (ArenaUIController)LuaObject.checkSelf(l);
			Toggle offlineBattleReportToggle;
			LuaObject.checkType<Toggle>(l, 2, out offlineBattleReportToggle);
			arenaUIController.m_luaExportHelper.m_offlineBattleReportToggle = offlineBattleReportToggle;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601B1C0 RID: 111040 RVA: 0x008261F8 File Offset: 0x008243F8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_offlineRankingToggle(IntPtr l)
	{
		int result;
		try
		{
			ArenaUIController arenaUIController = (ArenaUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, arenaUIController.m_luaExportHelper.m_offlineRankingToggle);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601B1C1 RID: 111041 RVA: 0x00826250 File Offset: 0x00824450
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_offlineRankingToggle(IntPtr l)
	{
		int result;
		try
		{
			ArenaUIController arenaUIController = (ArenaUIController)LuaObject.checkSelf(l);
			Toggle offlineRankingToggle;
			LuaObject.checkType<Toggle>(l, 2, out offlineRankingToggle);
			arenaUIController.m_luaExportHelper.m_offlineRankingToggle = offlineRankingToggle;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601B1C2 RID: 111042 RVA: 0x008262AC File Offset: 0x008244AC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_offlineClashPanelGameObject(IntPtr l)
	{
		int result;
		try
		{
			ArenaUIController arenaUIController = (ArenaUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, arenaUIController.m_luaExportHelper.m_offlineClashPanelGameObject);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601B1C3 RID: 111043 RVA: 0x00826304 File Offset: 0x00824504
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_offlineClashPanelGameObject(IntPtr l)
	{
		int result;
		try
		{
			ArenaUIController arenaUIController = (ArenaUIController)LuaObject.checkSelf(l);
			GameObject offlineClashPanelGameObject;
			LuaObject.checkType<GameObject>(l, 2, out offlineClashPanelGameObject);
			arenaUIController.m_luaExportHelper.m_offlineClashPanelGameObject = offlineClashPanelGameObject;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601B1C4 RID: 111044 RVA: 0x00826360 File Offset: 0x00824560
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_offlineArenaOpponentsGameObject(IntPtr l)
	{
		int result;
		try
		{
			ArenaUIController arenaUIController = (ArenaUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, arenaUIController.m_luaExportHelper.m_offlineArenaOpponentsGameObject);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601B1C5 RID: 111045 RVA: 0x008263B8 File Offset: 0x008245B8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_offlineArenaOpponentsGameObject(IntPtr l)
	{
		int result;
		try
		{
			ArenaUIController arenaUIController = (ArenaUIController)LuaObject.checkSelf(l);
			GameObject offlineArenaOpponentsGameObject;
			LuaObject.checkType<GameObject>(l, 2, out offlineArenaOpponentsGameObject);
			arenaUIController.m_luaExportHelper.m_offlineArenaOpponentsGameObject = offlineArenaOpponentsGameObject;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601B1C6 RID: 111046 RVA: 0x00826414 File Offset: 0x00824614
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_offlineInSettleGameObject(IntPtr l)
	{
		int result;
		try
		{
			ArenaUIController arenaUIController = (ArenaUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, arenaUIController.m_luaExportHelper.m_offlineInSettleGameObject);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601B1C7 RID: 111047 RVA: 0x0082646C File Offset: 0x0082466C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_offlineInSettleGameObject(IntPtr l)
	{
		int result;
		try
		{
			ArenaUIController arenaUIController = (ArenaUIController)LuaObject.checkSelf(l);
			GameObject offlineInSettleGameObject;
			LuaObject.checkType<GameObject>(l, 2, out offlineInSettleGameObject);
			arenaUIController.m_luaExportHelper.m_offlineInSettleGameObject = offlineInSettleGameObject;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601B1C8 RID: 111048 RVA: 0x008264C8 File Offset: 0x008246C8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_offlineArenaOpponentsRefreshTimeText(IntPtr l)
	{
		int result;
		try
		{
			ArenaUIController arenaUIController = (ArenaUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, arenaUIController.m_luaExportHelper.m_offlineArenaOpponentsRefreshTimeText);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601B1C9 RID: 111049 RVA: 0x00826520 File Offset: 0x00824720
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_offlineArenaOpponentsRefreshTimeText(IntPtr l)
	{
		int result;
		try
		{
			ArenaUIController arenaUIController = (ArenaUIController)LuaObject.checkSelf(l);
			Text offlineArenaOpponentsRefreshTimeText;
			LuaObject.checkType<Text>(l, 2, out offlineArenaOpponentsRefreshTimeText);
			arenaUIController.m_luaExportHelper.m_offlineArenaOpponentsRefreshTimeText = offlineArenaOpponentsRefreshTimeText;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601B1CA RID: 111050 RVA: 0x0082657C File Offset: 0x0082477C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_offlineBattleReportPanelGameObject(IntPtr l)
	{
		int result;
		try
		{
			ArenaUIController arenaUIController = (ArenaUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, arenaUIController.m_luaExportHelper.m_offlineBattleReportPanelGameObject);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601B1CB RID: 111051 RVA: 0x008265D4 File Offset: 0x008247D4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_offlineBattleReportPanelGameObject(IntPtr l)
	{
		int result;
		try
		{
			ArenaUIController arenaUIController = (ArenaUIController)LuaObject.checkSelf(l);
			GameObject offlineBattleReportPanelGameObject;
			LuaObject.checkType<GameObject>(l, 2, out offlineBattleReportPanelGameObject);
			arenaUIController.m_luaExportHelper.m_offlineBattleReportPanelGameObject = offlineBattleReportPanelGameObject;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601B1CC RID: 111052 RVA: 0x00826630 File Offset: 0x00824830
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_offlineBattleReportScrollRect(IntPtr l)
	{
		int result;
		try
		{
			ArenaUIController arenaUIController = (ArenaUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, arenaUIController.m_luaExportHelper.m_offlineBattleReportScrollRect);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601B1CD RID: 111053 RVA: 0x00826688 File Offset: 0x00824888
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_offlineBattleReportScrollRect(IntPtr l)
	{
		int result;
		try
		{
			ArenaUIController arenaUIController = (ArenaUIController)LuaObject.checkSelf(l);
			ScrollRect offlineBattleReportScrollRect;
			LuaObject.checkType<ScrollRect>(l, 2, out offlineBattleReportScrollRect);
			arenaUIController.m_luaExportHelper.m_offlineBattleReportScrollRect = offlineBattleReportScrollRect;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601B1CE RID: 111054 RVA: 0x008266E4 File Offset: 0x008248E4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_offlineNoBattleReportGameObject(IntPtr l)
	{
		int result;
		try
		{
			ArenaUIController arenaUIController = (ArenaUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, arenaUIController.m_luaExportHelper.m_offlineNoBattleReportGameObject);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601B1CF RID: 111055 RVA: 0x0082673C File Offset: 0x0082493C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_offlineNoBattleReportGameObject(IntPtr l)
	{
		int result;
		try
		{
			ArenaUIController arenaUIController = (ArenaUIController)LuaObject.checkSelf(l);
			GameObject offlineNoBattleReportGameObject;
			LuaObject.checkType<GameObject>(l, 2, out offlineNoBattleReportGameObject);
			arenaUIController.m_luaExportHelper.m_offlineNoBattleReportGameObject = offlineNoBattleReportGameObject;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601B1D0 RID: 111056 RVA: 0x00826798 File Offset: 0x00824998
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_offlineRankingPanelGameObject(IntPtr l)
	{
		int result;
		try
		{
			ArenaUIController arenaUIController = (ArenaUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, arenaUIController.m_luaExportHelper.m_offlineRankingPanelGameObject);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601B1D1 RID: 111057 RVA: 0x008267F0 File Offset: 0x008249F0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_offlineRankingPanelGameObject(IntPtr l)
	{
		int result;
		try
		{
			ArenaUIController arenaUIController = (ArenaUIController)LuaObject.checkSelf(l);
			GameObject offlineRankingPanelGameObject;
			LuaObject.checkType<GameObject>(l, 2, out offlineRankingPanelGameObject);
			arenaUIController.m_luaExportHelper.m_offlineRankingPanelGameObject = offlineRankingPanelGameObject;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601B1D2 RID: 111058 RVA: 0x0082684C File Offset: 0x00824A4C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_offlineRankingScrollRect(IntPtr l)
	{
		int result;
		try
		{
			ArenaUIController arenaUIController = (ArenaUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, arenaUIController.m_luaExportHelper.m_offlineRankingScrollRect);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601B1D3 RID: 111059 RVA: 0x008268A4 File Offset: 0x00824AA4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_offlineRankingScrollRect(IntPtr l)
	{
		int result;
		try
		{
			ArenaUIController arenaUIController = (ArenaUIController)LuaObject.checkSelf(l);
			ScrollRect offlineRankingScrollRect;
			LuaObject.checkType<ScrollRect>(l, 2, out offlineRankingScrollRect);
			arenaUIController.m_luaExportHelper.m_offlineRankingScrollRect = offlineRankingScrollRect;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601B1D4 RID: 111060 RVA: 0x00826900 File Offset: 0x00824B00
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_offlineRankingPlayerNameText(IntPtr l)
	{
		int result;
		try
		{
			ArenaUIController arenaUIController = (ArenaUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, arenaUIController.m_luaExportHelper.m_offlineRankingPlayerNameText);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601B1D5 RID: 111061 RVA: 0x00826958 File Offset: 0x00824B58
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_offlineRankingPlayerNameText(IntPtr l)
	{
		int result;
		try
		{
			ArenaUIController arenaUIController = (ArenaUIController)LuaObject.checkSelf(l);
			Text offlineRankingPlayerNameText;
			LuaObject.checkType<Text>(l, 2, out offlineRankingPlayerNameText);
			arenaUIController.m_luaExportHelper.m_offlineRankingPlayerNameText = offlineRankingPlayerNameText;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601B1D6 RID: 111062 RVA: 0x008269B4 File Offset: 0x00824BB4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_offlineRankingPlayerRankingUIStateController(IntPtr l)
	{
		int result;
		try
		{
			ArenaUIController arenaUIController = (ArenaUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, arenaUIController.m_luaExportHelper.m_offlineRankingPlayerRankingUIStateController);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601B1D7 RID: 111063 RVA: 0x00826A0C File Offset: 0x00824C0C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_offlineRankingPlayerRankingUIStateController(IntPtr l)
	{
		int result;
		try
		{
			ArenaUIController arenaUIController = (ArenaUIController)LuaObject.checkSelf(l);
			CommonUIStateController offlineRankingPlayerRankingUIStateController;
			LuaObject.checkType<CommonUIStateController>(l, 2, out offlineRankingPlayerRankingUIStateController);
			arenaUIController.m_luaExportHelper.m_offlineRankingPlayerRankingUIStateController = offlineRankingPlayerRankingUIStateController;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601B1D8 RID: 111064 RVA: 0x00826A68 File Offset: 0x00824C68
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_offlineRankingPlayerRankingText(IntPtr l)
	{
		int result;
		try
		{
			ArenaUIController arenaUIController = (ArenaUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, arenaUIController.m_luaExportHelper.m_offlineRankingPlayerRankingText);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601B1D9 RID: 111065 RVA: 0x00826AC0 File Offset: 0x00824CC0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_offlineRankingPlayerRankingText(IntPtr l)
	{
		int result;
		try
		{
			ArenaUIController arenaUIController = (ArenaUIController)LuaObject.checkSelf(l);
			Text offlineRankingPlayerRankingText;
			LuaObject.checkType<Text>(l, 2, out offlineRankingPlayerRankingText);
			arenaUIController.m_luaExportHelper.m_offlineRankingPlayerRankingText = offlineRankingPlayerRankingText;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601B1DA RID: 111066 RVA: 0x00826B1C File Offset: 0x00824D1C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_offlineRankingPlayerRankingImage(IntPtr l)
	{
		int result;
		try
		{
			ArenaUIController arenaUIController = (ArenaUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, arenaUIController.m_luaExportHelper.m_offlineRankingPlayerRankingImage);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601B1DB RID: 111067 RVA: 0x00826B74 File Offset: 0x00824D74
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_offlineRankingPlayerRankingImage(IntPtr l)
	{
		int result;
		try
		{
			ArenaUIController arenaUIController = (ArenaUIController)LuaObject.checkSelf(l);
			Image offlineRankingPlayerRankingImage;
			LuaObject.checkType<Image>(l, 2, out offlineRankingPlayerRankingImage);
			arenaUIController.m_luaExportHelper.m_offlineRankingPlayerRankingImage = offlineRankingPlayerRankingImage;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601B1DC RID: 111068 RVA: 0x00826BD0 File Offset: 0x00824DD0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_offlineRankingArenaPointsText(IntPtr l)
	{
		int result;
		try
		{
			ArenaUIController arenaUIController = (ArenaUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, arenaUIController.m_luaExportHelper.m_offlineRankingArenaPointsText);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601B1DD RID: 111069 RVA: 0x00826C28 File Offset: 0x00824E28
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_offlineRankingArenaPointsText(IntPtr l)
	{
		int result;
		try
		{
			ArenaUIController arenaUIController = (ArenaUIController)LuaObject.checkSelf(l);
			Text offlineRankingArenaPointsText;
			LuaObject.checkType<Text>(l, 2, out offlineRankingArenaPointsText);
			arenaUIController.m_luaExportHelper.m_offlineRankingArenaPointsText = offlineRankingArenaPointsText;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601B1DE RID: 111070 RVA: 0x00826C84 File Offset: 0x00824E84
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_offlineRankingPlayerIconImage(IntPtr l)
	{
		int result;
		try
		{
			ArenaUIController arenaUIController = (ArenaUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, arenaUIController.m_luaExportHelper.m_offlineRankingPlayerIconImage);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601B1DF RID: 111071 RVA: 0x00826CDC File Offset: 0x00824EDC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_offlineRankingPlayerIconImage(IntPtr l)
	{
		int result;
		try
		{
			ArenaUIController arenaUIController = (ArenaUIController)LuaObject.checkSelf(l);
			Image offlineRankingPlayerIconImage;
			LuaObject.checkType<Image>(l, 2, out offlineRankingPlayerIconImage);
			arenaUIController.m_luaExportHelper.m_offlineRankingPlayerIconImage = offlineRankingPlayerIconImage;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601B1E0 RID: 111072 RVA: 0x00826D38 File Offset: 0x00824F38
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_offlineRankingPlayerHeadFrameTransform(IntPtr l)
	{
		int result;
		try
		{
			ArenaUIController arenaUIController = (ArenaUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, arenaUIController.m_luaExportHelper.m_offlineRankingPlayerHeadFrameTransform);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601B1E1 RID: 111073 RVA: 0x00826D90 File Offset: 0x00824F90
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_offlineRankingPlayerHeadFrameTransform(IntPtr l)
	{
		int result;
		try
		{
			ArenaUIController arenaUIController = (ArenaUIController)LuaObject.checkSelf(l);
			Transform offlineRankingPlayerHeadFrameTransform;
			LuaObject.checkType<Transform>(l, 2, out offlineRankingPlayerHeadFrameTransform);
			arenaUIController.m_luaExportHelper.m_offlineRankingPlayerHeadFrameTransform = offlineRankingPlayerHeadFrameTransform;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601B1E2 RID: 111074 RVA: 0x00826DEC File Offset: 0x00824FEC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_offlineRankingPlayerLevelText(IntPtr l)
	{
		int result;
		try
		{
			ArenaUIController arenaUIController = (ArenaUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, arenaUIController.m_luaExportHelper.m_offlineRankingPlayerLevelText);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601B1E3 RID: 111075 RVA: 0x00826E44 File Offset: 0x00825044
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_offlineRankingPlayerLevelText(IntPtr l)
	{
		int result;
		try
		{
			ArenaUIController arenaUIController = (ArenaUIController)LuaObject.checkSelf(l);
			Text offlineRankingPlayerLevelText;
			LuaObject.checkType<Text>(l, 2, out offlineRankingPlayerLevelText);
			arenaUIController.m_luaExportHelper.m_offlineRankingPlayerLevelText = offlineRankingPlayerLevelText;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601B1E4 RID: 111076 RVA: 0x00826EA0 File Offset: 0x008250A0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_offlinePlayerIconImage(IntPtr l)
	{
		int result;
		try
		{
			ArenaUIController arenaUIController = (ArenaUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, arenaUIController.m_luaExportHelper.m_offlinePlayerIconImage);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601B1E5 RID: 111077 RVA: 0x00826EF8 File Offset: 0x008250F8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_offlinePlayerIconImage(IntPtr l)
	{
		int result;
		try
		{
			ArenaUIController arenaUIController = (ArenaUIController)LuaObject.checkSelf(l);
			Image offlinePlayerIconImage;
			LuaObject.checkType<Image>(l, 2, out offlinePlayerIconImage);
			arenaUIController.m_luaExportHelper.m_offlinePlayerIconImage = offlinePlayerIconImage;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601B1E6 RID: 111078 RVA: 0x00826F54 File Offset: 0x00825154
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_offlinePlayerNameText(IntPtr l)
	{
		int result;
		try
		{
			ArenaUIController arenaUIController = (ArenaUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, arenaUIController.m_luaExportHelper.m_offlinePlayerNameText);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601B1E7 RID: 111079 RVA: 0x00826FAC File Offset: 0x008251AC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_offlinePlayerNameText(IntPtr l)
	{
		int result;
		try
		{
			ArenaUIController arenaUIController = (ArenaUIController)LuaObject.checkSelf(l);
			Text offlinePlayerNameText;
			LuaObject.checkType<Text>(l, 2, out offlinePlayerNameText);
			arenaUIController.m_luaExportHelper.m_offlinePlayerNameText = offlinePlayerNameText;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601B1E8 RID: 111080 RVA: 0x00827008 File Offset: 0x00825208
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_offlinePlayerLevelText(IntPtr l)
	{
		int result;
		try
		{
			ArenaUIController arenaUIController = (ArenaUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, arenaUIController.m_luaExportHelper.m_offlinePlayerLevelText);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601B1E9 RID: 111081 RVA: 0x00827060 File Offset: 0x00825260
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_offlinePlayerLevelText(IntPtr l)
	{
		int result;
		try
		{
			ArenaUIController arenaUIController = (ArenaUIController)LuaObject.checkSelf(l);
			Text offlinePlayerLevelText;
			LuaObject.checkType<Text>(l, 2, out offlinePlayerLevelText);
			arenaUIController.m_luaExportHelper.m_offlinePlayerLevelText = offlinePlayerLevelText;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601B1EA RID: 111082 RVA: 0x008270BC File Offset: 0x008252BC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_offlinePlayerBattlePowerText(IntPtr l)
	{
		int result;
		try
		{
			ArenaUIController arenaUIController = (ArenaUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, arenaUIController.m_luaExportHelper.m_offlinePlayerBattlePowerText);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601B1EB RID: 111083 RVA: 0x00827114 File Offset: 0x00825314
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_offlinePlayerBattlePowerText(IntPtr l)
	{
		int result;
		try
		{
			ArenaUIController arenaUIController = (ArenaUIController)LuaObject.checkSelf(l);
			Text offlinePlayerBattlePowerText;
			LuaObject.checkType<Text>(l, 2, out offlinePlayerBattlePowerText);
			arenaUIController.m_luaExportHelper.m_offlinePlayerBattlePowerText = offlinePlayerBattlePowerText;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601B1EC RID: 111084 RVA: 0x00827170 File Offset: 0x00825370
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_offlineArenaPointsText(IntPtr l)
	{
		int result;
		try
		{
			ArenaUIController arenaUIController = (ArenaUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, arenaUIController.m_luaExportHelper.m_offlineArenaPointsText);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601B1ED RID: 111085 RVA: 0x008271C8 File Offset: 0x008253C8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_offlineArenaPointsText(IntPtr l)
	{
		int result;
		try
		{
			ArenaUIController arenaUIController = (ArenaUIController)LuaObject.checkSelf(l);
			Text offlineArenaPointsText;
			LuaObject.checkType<Text>(l, 2, out offlineArenaPointsText);
			arenaUIController.m_luaExportHelper.m_offlineArenaPointsText = offlineArenaPointsText;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601B1EE RID: 111086 RVA: 0x00827224 File Offset: 0x00825424
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_offlineArenaPointsUpText1(IntPtr l)
	{
		int result;
		try
		{
			ArenaUIController arenaUIController = (ArenaUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, arenaUIController.m_luaExportHelper.m_offlineArenaPointsUpText1);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601B1EF RID: 111087 RVA: 0x0082727C File Offset: 0x0082547C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_offlineArenaPointsUpText1(IntPtr l)
	{
		int result;
		try
		{
			ArenaUIController arenaUIController = (ArenaUIController)LuaObject.checkSelf(l);
			Text offlineArenaPointsUpText;
			LuaObject.checkType<Text>(l, 2, out offlineArenaPointsUpText);
			arenaUIController.m_luaExportHelper.m_offlineArenaPointsUpText1 = offlineArenaPointsUpText;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601B1F0 RID: 111088 RVA: 0x008272D8 File Offset: 0x008254D8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_offlineArenaPointsUpText2(IntPtr l)
	{
		int result;
		try
		{
			ArenaUIController arenaUIController = (ArenaUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, arenaUIController.m_luaExportHelper.m_offlineArenaPointsUpText2);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601B1F1 RID: 111089 RVA: 0x00827330 File Offset: 0x00825530
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_offlineArenaPointsUpText2(IntPtr l)
	{
		int result;
		try
		{
			ArenaUIController arenaUIController = (ArenaUIController)LuaObject.checkSelf(l);
			Text offlineArenaPointsUpText;
			LuaObject.checkType<Text>(l, 2, out offlineArenaPointsUpText);
			arenaUIController.m_luaExportHelper.m_offlineArenaPointsUpText2 = offlineArenaPointsUpText;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601B1F2 RID: 111090 RVA: 0x0082738C File Offset: 0x0082558C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_offlineArenaPointsUpBarImage(IntPtr l)
	{
		int result;
		try
		{
			ArenaUIController arenaUIController = (ArenaUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, arenaUIController.m_luaExportHelper.m_offlineArenaPointsUpBarImage);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601B1F3 RID: 111091 RVA: 0x008273E4 File Offset: 0x008255E4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_offlineArenaPointsUpBarImage(IntPtr l)
	{
		int result;
		try
		{
			ArenaUIController arenaUIController = (ArenaUIController)LuaObject.checkSelf(l);
			Image offlineArenaPointsUpBarImage;
			LuaObject.checkType<Image>(l, 2, out offlineArenaPointsUpBarImage);
			arenaUIController.m_luaExportHelper.m_offlineArenaPointsUpBarImage = offlineArenaPointsUpBarImage;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601B1F4 RID: 111092 RVA: 0x00827440 File Offset: 0x00825640
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_offlineDefendButton(IntPtr l)
	{
		int result;
		try
		{
			ArenaUIController arenaUIController = (ArenaUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, arenaUIController.m_luaExportHelper.m_offlineDefendButton);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601B1F5 RID: 111093 RVA: 0x00827498 File Offset: 0x00825698
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_offlineDefendButton(IntPtr l)
	{
		int result;
		try
		{
			ArenaUIController arenaUIController = (ArenaUIController)LuaObject.checkSelf(l);
			Button offlineDefendButton;
			LuaObject.checkType<Button>(l, 2, out offlineDefendButton);
			arenaUIController.m_luaExportHelper.m_offlineDefendButton = offlineDefendButton;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601B1F6 RID: 111094 RVA: 0x008274F4 File Offset: 0x008256F4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_offlineArenaPointRewardButton(IntPtr l)
	{
		int result;
		try
		{
			ArenaUIController arenaUIController = (ArenaUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, arenaUIController.m_luaExportHelper.m_offlineArenaPointRewardButton);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601B1F7 RID: 111095 RVA: 0x0082754C File Offset: 0x0082574C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_offlineArenaPointRewardButton(IntPtr l)
	{
		int result;
		try
		{
			ArenaUIController arenaUIController = (ArenaUIController)LuaObject.checkSelf(l);
			Button offlineArenaPointRewardButton;
			LuaObject.checkType<Button>(l, 2, out offlineArenaPointRewardButton);
			arenaUIController.m_luaExportHelper.m_offlineArenaPointRewardButton = offlineArenaPointRewardButton;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601B1F8 RID: 111096 RVA: 0x008275A8 File Offset: 0x008257A8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_offlineVictoryPointsText(IntPtr l)
	{
		int result;
		try
		{
			ArenaUIController arenaUIController = (ArenaUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, arenaUIController.m_luaExportHelper.m_offlineVictoryPointsText);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601B1F9 RID: 111097 RVA: 0x00827600 File Offset: 0x00825800
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_offlineVictoryPointsText(IntPtr l)
	{
		int result;
		try
		{
			ArenaUIController arenaUIController = (ArenaUIController)LuaObject.checkSelf(l);
			Text offlineVictoryPointsText;
			LuaObject.checkType<Text>(l, 2, out offlineVictoryPointsText);
			arenaUIController.m_luaExportHelper.m_offlineVictoryPointsText = offlineVictoryPointsText;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601B1FA RID: 111098 RVA: 0x0082765C File Offset: 0x0082585C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_offlineVictoryPointsRewardButton1GameObject(IntPtr l)
	{
		int result;
		try
		{
			ArenaUIController arenaUIController = (ArenaUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, arenaUIController.m_luaExportHelper.m_offlineVictoryPointsRewardButton1GameObject);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601B1FB RID: 111099 RVA: 0x008276B4 File Offset: 0x008258B4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_offlineVictoryPointsRewardButton1GameObject(IntPtr l)
	{
		int result;
		try
		{
			ArenaUIController arenaUIController = (ArenaUIController)LuaObject.checkSelf(l);
			GameObject offlineVictoryPointsRewardButton1GameObject;
			LuaObject.checkType<GameObject>(l, 2, out offlineVictoryPointsRewardButton1GameObject);
			arenaUIController.m_luaExportHelper.m_offlineVictoryPointsRewardButton1GameObject = offlineVictoryPointsRewardButton1GameObject;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601B1FC RID: 111100 RVA: 0x00827710 File Offset: 0x00825910
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_offlineVictoryPointsRewardButton2GameObject(IntPtr l)
	{
		int result;
		try
		{
			ArenaUIController arenaUIController = (ArenaUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, arenaUIController.m_luaExportHelper.m_offlineVictoryPointsRewardButton2GameObject);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601B1FD RID: 111101 RVA: 0x00827768 File Offset: 0x00825968
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_offlineVictoryPointsRewardButton2GameObject(IntPtr l)
	{
		int result;
		try
		{
			ArenaUIController arenaUIController = (ArenaUIController)LuaObject.checkSelf(l);
			GameObject offlineVictoryPointsRewardButton2GameObject;
			LuaObject.checkType<GameObject>(l, 2, out offlineVictoryPointsRewardButton2GameObject);
			arenaUIController.m_luaExportHelper.m_offlineVictoryPointsRewardButton2GameObject = offlineVictoryPointsRewardButton2GameObject;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601B1FE RID: 111102 RVA: 0x008277C4 File Offset: 0x008259C4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_offlineVictoryPointsRewardButton3GameObject(IntPtr l)
	{
		int result;
		try
		{
			ArenaUIController arenaUIController = (ArenaUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, arenaUIController.m_luaExportHelper.m_offlineVictoryPointsRewardButton3GameObject);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601B1FF RID: 111103 RVA: 0x0082781C File Offset: 0x00825A1C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_offlineVictoryPointsRewardButton3GameObject(IntPtr l)
	{
		int result;
		try
		{
			ArenaUIController arenaUIController = (ArenaUIController)LuaObject.checkSelf(l);
			GameObject offlineVictoryPointsRewardButton3GameObject;
			LuaObject.checkType<GameObject>(l, 2, out offlineVictoryPointsRewardButton3GameObject);
			arenaUIController.m_luaExportHelper.m_offlineVictoryPointsRewardButton3GameObject = offlineVictoryPointsRewardButton3GameObject;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601B200 RID: 111104 RVA: 0x00827878 File Offset: 0x00825A78
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_offlineVictoryPointsRewardImage(IntPtr l)
	{
		int result;
		try
		{
			ArenaUIController arenaUIController = (ArenaUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, arenaUIController.m_luaExportHelper.m_offlineVictoryPointsRewardImage);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601B201 RID: 111105 RVA: 0x008278D0 File Offset: 0x00825AD0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_offlineVictoryPointsRewardImage(IntPtr l)
	{
		int result;
		try
		{
			ArenaUIController arenaUIController = (ArenaUIController)LuaObject.checkSelf(l);
			Image offlineVictoryPointsRewardImage;
			LuaObject.checkType<Image>(l, 2, out offlineVictoryPointsRewardImage);
			arenaUIController.m_luaExportHelper.m_offlineVictoryPointsRewardImage = offlineVictoryPointsRewardImage;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601B202 RID: 111106 RVA: 0x0082792C File Offset: 0x00825B2C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_offlineWeekWinText(IntPtr l)
	{
		int result;
		try
		{
			ArenaUIController arenaUIController = (ArenaUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, arenaUIController.m_luaExportHelper.m_offlineWeekWinText);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601B203 RID: 111107 RVA: 0x00827984 File Offset: 0x00825B84
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_offlineWeekWinText(IntPtr l)
	{
		int result;
		try
		{
			ArenaUIController arenaUIController = (ArenaUIController)LuaObject.checkSelf(l);
			Text offlineWeekWinText;
			LuaObject.checkType<Text>(l, 2, out offlineWeekWinText);
			arenaUIController.m_luaExportHelper.m_offlineWeekWinText = offlineWeekWinText;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601B204 RID: 111108 RVA: 0x008279E0 File Offset: 0x00825BE0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_arenaOpponentPool(IntPtr l)
	{
		int result;
		try
		{
			ArenaUIController arenaUIController = (ArenaUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, arenaUIController.m_luaExportHelper.m_arenaOpponentPool);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601B205 RID: 111109 RVA: 0x00827A38 File Offset: 0x00825C38
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_arenaOpponentPool(IntPtr l)
	{
		int result;
		try
		{
			ArenaUIController arenaUIController = (ArenaUIController)LuaObject.checkSelf(l);
			GameObjectPool<ArenaOpponentListItemUIController> arenaOpponentPool;
			LuaObject.checkType<GameObjectPool<ArenaOpponentListItemUIController>>(l, 2, out arenaOpponentPool);
			arenaUIController.m_luaExportHelper.m_arenaOpponentPool = arenaOpponentPool;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601B206 RID: 111110 RVA: 0x00827A94 File Offset: 0x00825C94
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_arenaRankingPool(IntPtr l)
	{
		int result;
		try
		{
			ArenaUIController arenaUIController = (ArenaUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, arenaUIController.m_luaExportHelper.m_arenaRankingPool);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601B207 RID: 111111 RVA: 0x00827AEC File Offset: 0x00825CEC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_arenaRankingPool(IntPtr l)
	{
		int result;
		try
		{
			ArenaUIController arenaUIController = (ArenaUIController)LuaObject.checkSelf(l);
			GameObjectPool<ArenaRankingListItemUIController> arenaRankingPool;
			LuaObject.checkType<GameObjectPool<ArenaRankingListItemUIController>>(l, 2, out arenaRankingPool);
			arenaUIController.m_luaExportHelper.m_arenaRankingPool = arenaRankingPool;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601B208 RID: 111112 RVA: 0x00827B48 File Offset: 0x00825D48
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_offlineArenaBattleReportPool(IntPtr l)
	{
		int result;
		try
		{
			ArenaUIController arenaUIController = (ArenaUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, arenaUIController.m_luaExportHelper.m_offlineArenaBattleReportPool);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601B209 RID: 111113 RVA: 0x00827BA0 File Offset: 0x00825DA0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_offlineArenaBattleReportPool(IntPtr l)
	{
		int result;
		try
		{
			ArenaUIController arenaUIController = (ArenaUIController)LuaObject.checkSelf(l);
			GameObjectPool<OfflineArenaBattleReportListItemUIController> offlineArenaBattleReportPool;
			LuaObject.checkType<GameObjectPool<OfflineArenaBattleReportListItemUIController>>(l, 2, out offlineArenaBattleReportPool);
			arenaUIController.m_luaExportHelper.m_offlineArenaBattleReportPool = offlineArenaBattleReportPool;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601B20A RID: 111114 RVA: 0x00827BFC File Offset: 0x00825DFC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_offlineArenaPointRewardPool(IntPtr l)
	{
		int result;
		try
		{
			ArenaUIController arenaUIController = (ArenaUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, arenaUIController.m_luaExportHelper.m_offlineArenaPointRewardPool);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601B20B RID: 111115 RVA: 0x00827C54 File Offset: 0x00825E54
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_offlineArenaPointRewardPool(IntPtr l)
	{
		int result;
		try
		{
			ArenaUIController arenaUIController = (ArenaUIController)LuaObject.checkSelf(l);
			GameObjectPool<ArenaPointRewardListItemUIController> offlineArenaPointRewardPool;
			LuaObject.checkType<GameObjectPool<ArenaPointRewardListItemUIController>>(l, 2, out offlineArenaPointRewardPool);
			arenaUIController.m_luaExportHelper.m_offlineArenaPointRewardPool = offlineArenaPointRewardPool;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601B20C RID: 111116 RVA: 0x00827CB0 File Offset: 0x00825EB0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_EventOnShowOnlinePanel(IntPtr l)
	{
		int result;
		try
		{
			ArenaUIController arenaUIController = (ArenaUIController)LuaObject.checkSelf(l);
			Action<OnlineArenaPanelType> value;
			int num = LuaObject.checkDelegate<Action<OnlineArenaPanelType>>(l, 2, out value);
			if (num != 0)
			{
				if (num == 1)
				{
					arenaUIController.EventOnShowOnlinePanel += value;
				}
				else if (num == 2)
				{
					arenaUIController.EventOnShowOnlinePanel -= value;
				}
			}
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601B20D RID: 111117 RVA: 0x00827D30 File Offset: 0x00825F30
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_EventOnGainOnlineWeekWinReward(IntPtr l)
	{
		int result;
		try
		{
			ArenaUIController arenaUIController = (ArenaUIController)LuaObject.checkSelf(l);
			Action<int> value;
			int num = LuaObject.checkDelegate<Action<int>>(l, 2, out value);
			if (num != 0)
			{
				if (num == 1)
				{
					arenaUIController.EventOnGainOnlineWeekWinReward += value;
				}
				else if (num == 2)
				{
					arenaUIController.EventOnGainOnlineWeekWinReward -= value;
				}
			}
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601B20E RID: 111118 RVA: 0x00827DB0 File Offset: 0x00825FB0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_EventOnOnlineBattleReportReplay(IntPtr l)
	{
		int result;
		try
		{
			ArenaUIController arenaUIController = (ArenaUIController)LuaObject.checkSelf(l);
			Action<RealTimePVPBattleReport> value;
			int num = LuaObject.checkDelegate<Action<RealTimePVPBattleReport>>(l, 2, out value);
			if (num != 0)
			{
				if (num == 1)
				{
					arenaUIController.EventOnOnlineBattleReportReplay += value;
				}
				else if (num == 2)
				{
					arenaUIController.EventOnOnlineBattleReportReplay -= value;
				}
			}
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601B20F RID: 111119 RVA: 0x00827E30 File Offset: 0x00826030
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_EventOnLadderChallenge(IntPtr l)
	{
		int result;
		try
		{
			ArenaUIController arenaUIController = (ArenaUIController)LuaObject.checkSelf(l);
			Action value;
			int num = LuaObject.checkDelegate<Action>(l, 2, out value);
			if (num != 0)
			{
				if (num == 1)
				{
					arenaUIController.EventOnLadderChallenge += value;
				}
				else if (num == 2)
				{
					arenaUIController.EventOnLadderChallenge -= value;
				}
			}
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601B210 RID: 111120 RVA: 0x00827EB0 File Offset: 0x008260B0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_EventOnCasualChallenge(IntPtr l)
	{
		int result;
		try
		{
			ArenaUIController arenaUIController = (ArenaUIController)LuaObject.checkSelf(l);
			Action value;
			int num = LuaObject.checkDelegate<Action>(l, 2, out value);
			if (num != 0)
			{
				if (num == 1)
				{
					arenaUIController.EventOnCasualChallenge += value;
				}
				else if (num == 2)
				{
					arenaUIController.EventOnCasualChallenge -= value;
				}
			}
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601B211 RID: 111121 RVA: 0x00827F30 File Offset: 0x00826130
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_EventOnMatchingCancel(IntPtr l)
	{
		int result;
		try
		{
			ArenaUIController arenaUIController = (ArenaUIController)LuaObject.checkSelf(l);
			Action value;
			int num = LuaObject.checkDelegate<Action>(l, 2, out value);
			if (num != 0)
			{
				if (num == 1)
				{
					arenaUIController.EventOnMatchingCancel += value;
				}
				else if (num == 2)
				{
					arenaUIController.EventOnMatchingCancel -= value;
				}
			}
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601B212 RID: 111122 RVA: 0x00827FB0 File Offset: 0x008261B0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_onlineGameObject(IntPtr l)
	{
		int result;
		try
		{
			ArenaUIController arenaUIController = (ArenaUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, arenaUIController.m_luaExportHelper.m_onlineGameObject);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601B213 RID: 111123 RVA: 0x00828008 File Offset: 0x00826208
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_onlineGameObject(IntPtr l)
	{
		int result;
		try
		{
			ArenaUIController arenaUIController = (ArenaUIController)LuaObject.checkSelf(l);
			GameObject onlineGameObject;
			LuaObject.checkType<GameObject>(l, 2, out onlineGameObject);
			arenaUIController.m_luaExportHelper.m_onlineGameObject = onlineGameObject;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601B214 RID: 111124 RVA: 0x00828064 File Offset: 0x00826264
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_onlineMarginTransform(IntPtr l)
	{
		int result;
		try
		{
			ArenaUIController arenaUIController = (ArenaUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, arenaUIController.m_luaExportHelper.m_onlineMarginTransform);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601B215 RID: 111125 RVA: 0x008280BC File Offset: 0x008262BC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_onlineMarginTransform(IntPtr l)
	{
		int result;
		try
		{
			ArenaUIController arenaUIController = (ArenaUIController)LuaObject.checkSelf(l);
			RectTransform onlineMarginTransform;
			LuaObject.checkType<RectTransform>(l, 2, out onlineMarginTransform);
			arenaUIController.m_luaExportHelper.m_onlineMarginTransform = onlineMarginTransform;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601B216 RID: 111126 RVA: 0x00828118 File Offset: 0x00826318
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_onlineClashToggle(IntPtr l)
	{
		int result;
		try
		{
			ArenaUIController arenaUIController = (ArenaUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, arenaUIController.m_luaExportHelper.m_onlineClashToggle);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601B217 RID: 111127 RVA: 0x00828170 File Offset: 0x00826370
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_onlineClashToggle(IntPtr l)
	{
		int result;
		try
		{
			ArenaUIController arenaUIController = (ArenaUIController)LuaObject.checkSelf(l);
			Toggle onlineClashToggle;
			LuaObject.checkType<Toggle>(l, 2, out onlineClashToggle);
			arenaUIController.m_luaExportHelper.m_onlineClashToggle = onlineClashToggle;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601B218 RID: 111128 RVA: 0x008281CC File Offset: 0x008263CC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_onlineBattleReportToggle(IntPtr l)
	{
		int result;
		try
		{
			ArenaUIController arenaUIController = (ArenaUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, arenaUIController.m_luaExportHelper.m_onlineBattleReportToggle);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601B219 RID: 111129 RVA: 0x00828224 File Offset: 0x00826424
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_onlineBattleReportToggle(IntPtr l)
	{
		int result;
		try
		{
			ArenaUIController arenaUIController = (ArenaUIController)LuaObject.checkSelf(l);
			Toggle onlineBattleReportToggle;
			LuaObject.checkType<Toggle>(l, 2, out onlineBattleReportToggle);
			arenaUIController.m_luaExportHelper.m_onlineBattleReportToggle = onlineBattleReportToggle;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601B21A RID: 111130 RVA: 0x00828280 File Offset: 0x00826480
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_onlineDanToggle(IntPtr l)
	{
		int result;
		try
		{
			ArenaUIController arenaUIController = (ArenaUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, arenaUIController.m_luaExportHelper.m_onlineDanToggle);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601B21B RID: 111131 RVA: 0x008282D8 File Offset: 0x008264D8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_onlineDanToggle(IntPtr l)
	{
		int result;
		try
		{
			ArenaUIController arenaUIController = (ArenaUIController)LuaObject.checkSelf(l);
			Toggle onlineDanToggle;
			LuaObject.checkType<Toggle>(l, 2, out onlineDanToggle);
			arenaUIController.m_luaExportHelper.m_onlineDanToggle = onlineDanToggle;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601B21C RID: 111132 RVA: 0x00828334 File Offset: 0x00826534
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_onlineLocalRankingToggle(IntPtr l)
	{
		int result;
		try
		{
			ArenaUIController arenaUIController = (ArenaUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, arenaUIController.m_luaExportHelper.m_onlineLocalRankingToggle);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601B21D RID: 111133 RVA: 0x0082838C File Offset: 0x0082658C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_onlineLocalRankingToggle(IntPtr l)
	{
		int result;
		try
		{
			ArenaUIController arenaUIController = (ArenaUIController)LuaObject.checkSelf(l);
			Toggle onlineLocalRankingToggle;
			LuaObject.checkType<Toggle>(l, 2, out onlineLocalRankingToggle);
			arenaUIController.m_luaExportHelper.m_onlineLocalRankingToggle = onlineLocalRankingToggle;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601B21E RID: 111134 RVA: 0x008283E8 File Offset: 0x008265E8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_onlineGlobalRankingToggle(IntPtr l)
	{
		int result;
		try
		{
			ArenaUIController arenaUIController = (ArenaUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, arenaUIController.m_luaExportHelper.m_onlineGlobalRankingToggle);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601B21F RID: 111135 RVA: 0x00828440 File Offset: 0x00826640
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_onlineGlobalRankingToggle(IntPtr l)
	{
		int result;
		try
		{
			ArenaUIController arenaUIController = (ArenaUIController)LuaObject.checkSelf(l);
			Toggle onlineGlobalRankingToggle;
			LuaObject.checkType<Toggle>(l, 2, out onlineGlobalRankingToggle);
			arenaUIController.m_luaExportHelper.m_onlineGlobalRankingToggle = onlineGlobalRankingToggle;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601B220 RID: 111136 RVA: 0x0082849C File Offset: 0x0082669C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_onlineClashPanelGameObject(IntPtr l)
	{
		int result;
		try
		{
			ArenaUIController arenaUIController = (ArenaUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, arenaUIController.m_luaExportHelper.m_onlineClashPanelGameObject);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601B221 RID: 111137 RVA: 0x008284F4 File Offset: 0x008266F4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_onlineClashPanelGameObject(IntPtr l)
	{
		int result;
		try
		{
			ArenaUIController arenaUIController = (ArenaUIController)LuaObject.checkSelf(l);
			GameObject onlineClashPanelGameObject;
			LuaObject.checkType<GameObject>(l, 2, out onlineClashPanelGameObject);
			arenaUIController.m_luaExportHelper.m_onlineClashPanelGameObject = onlineClashPanelGameObject;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601B222 RID: 111138 RVA: 0x00828550 File Offset: 0x00826750
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_onlineClashLadderModeUIStateController(IntPtr l)
	{
		int result;
		try
		{
			ArenaUIController arenaUIController = (ArenaUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, arenaUIController.m_luaExportHelper.m_onlineClashLadderModeUIStateController);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601B223 RID: 111139 RVA: 0x008285A8 File Offset: 0x008267A8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_onlineClashLadderModeUIStateController(IntPtr l)
	{
		int result;
		try
		{
			ArenaUIController arenaUIController = (ArenaUIController)LuaObject.checkSelf(l);
			CommonUIStateController onlineClashLadderModeUIStateController;
			LuaObject.checkType<CommonUIStateController>(l, 2, out onlineClashLadderModeUIStateController);
			arenaUIController.m_luaExportHelper.m_onlineClashLadderModeUIStateController = onlineClashLadderModeUIStateController;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601B224 RID: 111140 RVA: 0x00828604 File Offset: 0x00826804
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_onlineClashWinRateText(IntPtr l)
	{
		int result;
		try
		{
			ArenaUIController arenaUIController = (ArenaUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, arenaUIController.m_luaExportHelper.m_onlineClashWinRateText);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601B225 RID: 111141 RVA: 0x0082865C File Offset: 0x0082685C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_onlineClashWinRateText(IntPtr l)
	{
		int result;
		try
		{
			ArenaUIController arenaUIController = (ArenaUIController)LuaObject.checkSelf(l);
			Text onlineClashWinRateText;
			LuaObject.checkType<Text>(l, 2, out onlineClashWinRateText);
			arenaUIController.m_luaExportHelper.m_onlineClashWinRateText = onlineClashWinRateText;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601B226 RID: 111142 RVA: 0x008286B8 File Offset: 0x008268B8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_onlineClashWinCountText(IntPtr l)
	{
		int result;
		try
		{
			ArenaUIController arenaUIController = (ArenaUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, arenaUIController.m_luaExportHelper.m_onlineClashWinCountText);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601B227 RID: 111143 RVA: 0x00828710 File Offset: 0x00826910
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_onlineClashWinCountText(IntPtr l)
	{
		int result;
		try
		{
			ArenaUIController arenaUIController = (ArenaUIController)LuaObject.checkSelf(l);
			Text onlineClashWinCountText;
			LuaObject.checkType<Text>(l, 2, out onlineClashWinCountText);
			arenaUIController.m_luaExportHelper.m_onlineClashWinCountText = onlineClashWinCountText;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601B228 RID: 111144 RVA: 0x0082876C File Offset: 0x0082696C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_onlineClashLoseCountText(IntPtr l)
	{
		int result;
		try
		{
			ArenaUIController arenaUIController = (ArenaUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, arenaUIController.m_luaExportHelper.m_onlineClashLoseCountText);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601B229 RID: 111145 RVA: 0x008287C4 File Offset: 0x008269C4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_onlineClashLoseCountText(IntPtr l)
	{
		int result;
		try
		{
			ArenaUIController arenaUIController = (ArenaUIController)LuaObject.checkSelf(l);
			Text onlineClashLoseCountText;
			LuaObject.checkType<Text>(l, 2, out onlineClashLoseCountText);
			arenaUIController.m_luaExportHelper.m_onlineClashLoseCountText = onlineClashLoseCountText;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601B22A RID: 111146 RVA: 0x00828820 File Offset: 0x00826A20
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_onlineClashTotalCountText(IntPtr l)
	{
		int result;
		try
		{
			ArenaUIController arenaUIController = (ArenaUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, arenaUIController.m_luaExportHelper.m_onlineClashTotalCountText);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601B22B RID: 111147 RVA: 0x00828878 File Offset: 0x00826A78
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_onlineClashTotalCountText(IntPtr l)
	{
		int result;
		try
		{
			ArenaUIController arenaUIController = (ArenaUIController)LuaObject.checkSelf(l);
			Text onlineClashTotalCountText;
			LuaObject.checkType<Text>(l, 2, out onlineClashTotalCountText);
			arenaUIController.m_luaExportHelper.m_onlineClashTotalCountText = onlineClashTotalCountText;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601B22C RID: 111148 RVA: 0x008288D4 File Offset: 0x00826AD4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_onlineClashDanIconImage(IntPtr l)
	{
		int result;
		try
		{
			ArenaUIController arenaUIController = (ArenaUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, arenaUIController.m_luaExportHelper.m_onlineClashDanIconImage);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601B22D RID: 111149 RVA: 0x0082892C File Offset: 0x00826B2C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_onlineClashDanIconImage(IntPtr l)
	{
		int result;
		try
		{
			ArenaUIController arenaUIController = (ArenaUIController)LuaObject.checkSelf(l);
			Image onlineClashDanIconImage;
			LuaObject.checkType<Image>(l, 2, out onlineClashDanIconImage);
			arenaUIController.m_luaExportHelper.m_onlineClashDanIconImage = onlineClashDanIconImage;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601B22E RID: 111150 RVA: 0x00828988 File Offset: 0x00826B88
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_onlineClashPromoteDanIconImage(IntPtr l)
	{
		int result;
		try
		{
			ArenaUIController arenaUIController = (ArenaUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, arenaUIController.m_luaExportHelper.m_onlineClashPromoteDanIconImage);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601B22F RID: 111151 RVA: 0x008289E0 File Offset: 0x00826BE0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_onlineClashPromoteDanIconImage(IntPtr l)
	{
		int result;
		try
		{
			ArenaUIController arenaUIController = (ArenaUIController)LuaObject.checkSelf(l);
			Image onlineClashPromoteDanIconImage;
			LuaObject.checkType<Image>(l, 2, out onlineClashPromoteDanIconImage);
			arenaUIController.m_luaExportHelper.m_onlineClashPromoteDanIconImage = onlineClashPromoteDanIconImage;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601B230 RID: 111152 RVA: 0x00828A3C File Offset: 0x00826C3C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_onlineClashPromoteNextDanIconImage(IntPtr l)
	{
		int result;
		try
		{
			ArenaUIController arenaUIController = (ArenaUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, arenaUIController.m_luaExportHelper.m_onlineClashPromoteNextDanIconImage);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601B231 RID: 111153 RVA: 0x00828A94 File Offset: 0x00826C94
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_onlineClashPromoteNextDanIconImage(IntPtr l)
	{
		int result;
		try
		{
			ArenaUIController arenaUIController = (ArenaUIController)LuaObject.checkSelf(l);
			Image onlineClashPromoteNextDanIconImage;
			LuaObject.checkType<Image>(l, 2, out onlineClashPromoteNextDanIconImage);
			arenaUIController.m_luaExportHelper.m_onlineClashPromoteNextDanIconImage = onlineClashPromoteNextDanIconImage;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601B232 RID: 111154 RVA: 0x00828AF0 File Offset: 0x00826CF0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_onlineClashPromoteCountImage(IntPtr l)
	{
		int result;
		try
		{
			ArenaUIController arenaUIController = (ArenaUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, arenaUIController.m_luaExportHelper.m_onlineClashPromoteCountImage);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601B233 RID: 111155 RVA: 0x00828B48 File Offset: 0x00826D48
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_onlineClashPromoteCountImage(IntPtr l)
	{
		int result;
		try
		{
			ArenaUIController arenaUIController = (ArenaUIController)LuaObject.checkSelf(l);
			Image onlineClashPromoteCountImage;
			LuaObject.checkType<Image>(l, 2, out onlineClashPromoteCountImage);
			arenaUIController.m_luaExportHelper.m_onlineClashPromoteCountImage = onlineClashPromoteCountImage;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601B234 RID: 111156 RVA: 0x00828BA4 File Offset: 0x00826DA4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_onlineClashPromoteRoundGroupGameObject(IntPtr l)
	{
		int result;
		try
		{
			ArenaUIController arenaUIController = (ArenaUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, arenaUIController.m_luaExportHelper.m_onlineClashPromoteRoundGroupGameObject);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601B235 RID: 111157 RVA: 0x00828BFC File Offset: 0x00826DFC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_onlineClashPromoteRoundGroupGameObject(IntPtr l)
	{
		int result;
		try
		{
			ArenaUIController arenaUIController = (ArenaUIController)LuaObject.checkSelf(l);
			GameObject onlineClashPromoteRoundGroupGameObject;
			LuaObject.checkType<GameObject>(l, 2, out onlineClashPromoteRoundGroupGameObject);
			arenaUIController.m_luaExportHelper.m_onlineClashPromoteRoundGroupGameObject = onlineClashPromoteRoundGroupGameObject;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601B236 RID: 111158 RVA: 0x00828C58 File Offset: 0x00826E58
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_onlineClashLadderOpenTimeGameObject(IntPtr l)
	{
		int result;
		try
		{
			ArenaUIController arenaUIController = (ArenaUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, arenaUIController.m_luaExportHelper.m_onlineClashLadderOpenTimeGameObject);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601B237 RID: 111159 RVA: 0x00828CB0 File Offset: 0x00826EB0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_onlineClashLadderOpenTimeGameObject(IntPtr l)
	{
		int result;
		try
		{
			ArenaUIController arenaUIController = (ArenaUIController)LuaObject.checkSelf(l);
			GameObject onlineClashLadderOpenTimeGameObject;
			LuaObject.checkType<GameObject>(l, 2, out onlineClashLadderOpenTimeGameObject);
			arenaUIController.m_luaExportHelper.m_onlineClashLadderOpenTimeGameObject = onlineClashLadderOpenTimeGameObject;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601B238 RID: 111160 RVA: 0x00828D0C File Offset: 0x00826F0C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_onlineClashLadderOpenTimeText(IntPtr l)
	{
		int result;
		try
		{
			ArenaUIController arenaUIController = (ArenaUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, arenaUIController.m_luaExportHelper.m_onlineClashLadderOpenTimeText);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601B239 RID: 111161 RVA: 0x00828D64 File Offset: 0x00826F64
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_onlineClashLadderOpenTimeText(IntPtr l)
	{
		int result;
		try
		{
			ArenaUIController arenaUIController = (ArenaUIController)LuaObject.checkSelf(l);
			Text onlineClashLadderOpenTimeText;
			LuaObject.checkType<Text>(l, 2, out onlineClashLadderOpenTimeText);
			arenaUIController.m_luaExportHelper.m_onlineClashLadderOpenTimeText = onlineClashLadderOpenTimeText;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601B23A RID: 111162 RVA: 0x00828DC0 File Offset: 0x00826FC0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_onlineClashLadderChallengeButton(IntPtr l)
	{
		int result;
		try
		{
			ArenaUIController arenaUIController = (ArenaUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, arenaUIController.m_luaExportHelper.m_onlineClashLadderChallengeButton);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601B23B RID: 111163 RVA: 0x00828E18 File Offset: 0x00827018
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_onlineClashLadderChallengeButton(IntPtr l)
	{
		int result;
		try
		{
			ArenaUIController arenaUIController = (ArenaUIController)LuaObject.checkSelf(l);
			Button onlineClashLadderChallengeButton;
			LuaObject.checkType<Button>(l, 2, out onlineClashLadderChallengeButton);
			arenaUIController.m_luaExportHelper.m_onlineClashLadderChallengeButton = onlineClashLadderChallengeButton;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601B23C RID: 111164 RVA: 0x00828E74 File Offset: 0x00827074
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_onlineClashLadderChallengeButtonUIStateController(IntPtr l)
	{
		int result;
		try
		{
			ArenaUIController arenaUIController = (ArenaUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, arenaUIController.m_luaExportHelper.m_onlineClashLadderChallengeButtonUIStateController);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601B23D RID: 111165 RVA: 0x00828ECC File Offset: 0x008270CC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_onlineClashLadderChallengeButtonUIStateController(IntPtr l)
	{
		int result;
		try
		{
			ArenaUIController arenaUIController = (ArenaUIController)LuaObject.checkSelf(l);
			CommonUIStateController onlineClashLadderChallengeButtonUIStateController;
			LuaObject.checkType<CommonUIStateController>(l, 2, out onlineClashLadderChallengeButtonUIStateController);
			arenaUIController.m_luaExportHelper.m_onlineClashLadderChallengeButtonUIStateController = onlineClashLadderChallengeButtonUIStateController;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601B23E RID: 111166 RVA: 0x00828F28 File Offset: 0x00827128
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_onlineClashCasualChallengeButton(IntPtr l)
	{
		int result;
		try
		{
			ArenaUIController arenaUIController = (ArenaUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, arenaUIController.m_luaExportHelper.m_onlineClashCasualChallengeButton);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601B23F RID: 111167 RVA: 0x00828F80 File Offset: 0x00827180
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_onlineClashCasualChallengeButton(IntPtr l)
	{
		int result;
		try
		{
			ArenaUIController arenaUIController = (ArenaUIController)LuaObject.checkSelf(l);
			Button onlineClashCasualChallengeButton;
			LuaObject.checkType<Button>(l, 2, out onlineClashCasualChallengeButton);
			arenaUIController.m_luaExportHelper.m_onlineClashCasualChallengeButton = onlineClashCasualChallengeButton;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601B240 RID: 111168 RVA: 0x00828FDC File Offset: 0x008271DC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_onlineBattleReportPanelGameObject(IntPtr l)
	{
		int result;
		try
		{
			ArenaUIController arenaUIController = (ArenaUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, arenaUIController.m_luaExportHelper.m_onlineBattleReportPanelGameObject);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601B241 RID: 111169 RVA: 0x00829034 File Offset: 0x00827234
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_onlineBattleReportPanelGameObject(IntPtr l)
	{
		int result;
		try
		{
			ArenaUIController arenaUIController = (ArenaUIController)LuaObject.checkSelf(l);
			GameObject onlineBattleReportPanelGameObject;
			LuaObject.checkType<GameObject>(l, 2, out onlineBattleReportPanelGameObject);
			arenaUIController.m_luaExportHelper.m_onlineBattleReportPanelGameObject = onlineBattleReportPanelGameObject;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601B242 RID: 111170 RVA: 0x00829090 File Offset: 0x00827290
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_onlineBattleReportScrollRect(IntPtr l)
	{
		int result;
		try
		{
			ArenaUIController arenaUIController = (ArenaUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, arenaUIController.m_luaExportHelper.m_onlineBattleReportScrollRect);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601B243 RID: 111171 RVA: 0x008290E8 File Offset: 0x008272E8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_onlineBattleReportScrollRect(IntPtr l)
	{
		int result;
		try
		{
			ArenaUIController arenaUIController = (ArenaUIController)LuaObject.checkSelf(l);
			ScrollRect onlineBattleReportScrollRect;
			LuaObject.checkType<ScrollRect>(l, 2, out onlineBattleReportScrollRect);
			arenaUIController.m_luaExportHelper.m_onlineBattleReportScrollRect = onlineBattleReportScrollRect;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601B244 RID: 111172 RVA: 0x00829144 File Offset: 0x00827344
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_onlineNoBattleReportGameObject(IntPtr l)
	{
		int result;
		try
		{
			ArenaUIController arenaUIController = (ArenaUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, arenaUIController.m_luaExportHelper.m_onlineNoBattleReportGameObject);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601B245 RID: 111173 RVA: 0x0082919C File Offset: 0x0082739C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_onlineNoBattleReportGameObject(IntPtr l)
	{
		int result;
		try
		{
			ArenaUIController arenaUIController = (ArenaUIController)LuaObject.checkSelf(l);
			GameObject onlineNoBattleReportGameObject;
			LuaObject.checkType<GameObject>(l, 2, out onlineNoBattleReportGameObject);
			arenaUIController.m_luaExportHelper.m_onlineNoBattleReportGameObject = onlineNoBattleReportGameObject;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601B246 RID: 111174 RVA: 0x008291F8 File Offset: 0x008273F8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_onlineDanPanelGameObject(IntPtr l)
	{
		int result;
		try
		{
			ArenaUIController arenaUIController = (ArenaUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, arenaUIController.m_luaExportHelper.m_onlineDanPanelGameObject);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601B247 RID: 111175 RVA: 0x00829250 File Offset: 0x00827450
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_onlineDanPanelGameObject(IntPtr l)
	{
		int result;
		try
		{
			ArenaUIController arenaUIController = (ArenaUIController)LuaObject.checkSelf(l);
			GameObject onlineDanPanelGameObject;
			LuaObject.checkType<GameObject>(l, 2, out onlineDanPanelGameObject);
			arenaUIController.m_luaExportHelper.m_onlineDanPanelGameObject = onlineDanPanelGameObject;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601B248 RID: 111176 RVA: 0x008292AC File Offset: 0x008274AC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_onlineArenaLevelScrollRect(IntPtr l)
	{
		int result;
		try
		{
			ArenaUIController arenaUIController = (ArenaUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, arenaUIController.m_luaExportHelper.m_onlineArenaLevelScrollRect);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601B249 RID: 111177 RVA: 0x00829304 File Offset: 0x00827504
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_onlineArenaLevelScrollRect(IntPtr l)
	{
		int result;
		try
		{
			ArenaUIController arenaUIController = (ArenaUIController)LuaObject.checkSelf(l);
			ScrollRect onlineArenaLevelScrollRect;
			LuaObject.checkType<ScrollRect>(l, 2, out onlineArenaLevelScrollRect);
			arenaUIController.m_luaExportHelper.m_onlineArenaLevelScrollRect = onlineArenaLevelScrollRect;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601B24A RID: 111178 RVA: 0x00829360 File Offset: 0x00827560
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_onlineRankingPanelGameObject(IntPtr l)
	{
		int result;
		try
		{
			ArenaUIController arenaUIController = (ArenaUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, arenaUIController.m_luaExportHelper.m_onlineRankingPanelGameObject);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601B24B RID: 111179 RVA: 0x008293B8 File Offset: 0x008275B8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_onlineRankingPanelGameObject(IntPtr l)
	{
		int result;
		try
		{
			ArenaUIController arenaUIController = (ArenaUIController)LuaObject.checkSelf(l);
			GameObject onlineRankingPanelGameObject;
			LuaObject.checkType<GameObject>(l, 2, out onlineRankingPanelGameObject);
			arenaUIController.m_luaExportHelper.m_onlineRankingPanelGameObject = onlineRankingPanelGameObject;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601B24C RID: 111180 RVA: 0x00829414 File Offset: 0x00827614
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_onlineRankingScrollRect(IntPtr l)
	{
		int result;
		try
		{
			ArenaUIController arenaUIController = (ArenaUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, arenaUIController.m_luaExportHelper.m_onlineRankingScrollRect);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601B24D RID: 111181 RVA: 0x0082946C File Offset: 0x0082766C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_onlineRankingScrollRect(IntPtr l)
	{
		int result;
		try
		{
			ArenaUIController arenaUIController = (ArenaUIController)LuaObject.checkSelf(l);
			ScrollRect onlineRankingScrollRect;
			LuaObject.checkType<ScrollRect>(l, 2, out onlineRankingScrollRect);
			arenaUIController.m_luaExportHelper.m_onlineRankingScrollRect = onlineRankingScrollRect;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601B24E RID: 111182 RVA: 0x008294C8 File Offset: 0x008276C8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_onlineRankingPlayerNameText(IntPtr l)
	{
		int result;
		try
		{
			ArenaUIController arenaUIController = (ArenaUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, arenaUIController.m_luaExportHelper.m_onlineRankingPlayerNameText);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601B24F RID: 111183 RVA: 0x00829520 File Offset: 0x00827720
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_onlineRankingPlayerNameText(IntPtr l)
	{
		int result;
		try
		{
			ArenaUIController arenaUIController = (ArenaUIController)LuaObject.checkSelf(l);
			Text onlineRankingPlayerNameText;
			LuaObject.checkType<Text>(l, 2, out onlineRankingPlayerNameText);
			arenaUIController.m_luaExportHelper.m_onlineRankingPlayerNameText = onlineRankingPlayerNameText;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601B250 RID: 111184 RVA: 0x0082957C File Offset: 0x0082777C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_onlineRankingPlayerRankingUIStateController(IntPtr l)
	{
		int result;
		try
		{
			ArenaUIController arenaUIController = (ArenaUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, arenaUIController.m_luaExportHelper.m_onlineRankingPlayerRankingUIStateController);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601B251 RID: 111185 RVA: 0x008295D4 File Offset: 0x008277D4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_onlineRankingPlayerRankingUIStateController(IntPtr l)
	{
		int result;
		try
		{
			ArenaUIController arenaUIController = (ArenaUIController)LuaObject.checkSelf(l);
			CommonUIStateController onlineRankingPlayerRankingUIStateController;
			LuaObject.checkType<CommonUIStateController>(l, 2, out onlineRankingPlayerRankingUIStateController);
			arenaUIController.m_luaExportHelper.m_onlineRankingPlayerRankingUIStateController = onlineRankingPlayerRankingUIStateController;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601B252 RID: 111186 RVA: 0x00829630 File Offset: 0x00827830
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_onlineRankingPlayerRankingText(IntPtr l)
	{
		int result;
		try
		{
			ArenaUIController arenaUIController = (ArenaUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, arenaUIController.m_luaExportHelper.m_onlineRankingPlayerRankingText);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601B253 RID: 111187 RVA: 0x00829688 File Offset: 0x00827888
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_onlineRankingPlayerRankingText(IntPtr l)
	{
		int result;
		try
		{
			ArenaUIController arenaUIController = (ArenaUIController)LuaObject.checkSelf(l);
			Text onlineRankingPlayerRankingText;
			LuaObject.checkType<Text>(l, 2, out onlineRankingPlayerRankingText);
			arenaUIController.m_luaExportHelper.m_onlineRankingPlayerRankingText = onlineRankingPlayerRankingText;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601B254 RID: 111188 RVA: 0x008296E4 File Offset: 0x008278E4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_onlineRankingPlayerRankingImage(IntPtr l)
	{
		int result;
		try
		{
			ArenaUIController arenaUIController = (ArenaUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, arenaUIController.m_luaExportHelper.m_onlineRankingPlayerRankingImage);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601B255 RID: 111189 RVA: 0x0082973C File Offset: 0x0082793C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_onlineRankingPlayerRankingImage(IntPtr l)
	{
		int result;
		try
		{
			ArenaUIController arenaUIController = (ArenaUIController)LuaObject.checkSelf(l);
			Image onlineRankingPlayerRankingImage;
			LuaObject.checkType<Image>(l, 2, out onlineRankingPlayerRankingImage);
			arenaUIController.m_luaExportHelper.m_onlineRankingPlayerRankingImage = onlineRankingPlayerRankingImage;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601B256 RID: 111190 RVA: 0x00829798 File Offset: 0x00827998
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_onlineRankingArenaPointsText(IntPtr l)
	{
		int result;
		try
		{
			ArenaUIController arenaUIController = (ArenaUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, arenaUIController.m_luaExportHelper.m_onlineRankingArenaPointsText);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601B257 RID: 111191 RVA: 0x008297F0 File Offset: 0x008279F0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_onlineRankingArenaPointsText(IntPtr l)
	{
		int result;
		try
		{
			ArenaUIController arenaUIController = (ArenaUIController)LuaObject.checkSelf(l);
			Text onlineRankingArenaPointsText;
			LuaObject.checkType<Text>(l, 2, out onlineRankingArenaPointsText);
			arenaUIController.m_luaExportHelper.m_onlineRankingArenaPointsText = onlineRankingArenaPointsText;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601B258 RID: 111192 RVA: 0x0082984C File Offset: 0x00827A4C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_onlineRankingPlayerIconImage(IntPtr l)
	{
		int result;
		try
		{
			ArenaUIController arenaUIController = (ArenaUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, arenaUIController.m_luaExportHelper.m_onlineRankingPlayerIconImage);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601B259 RID: 111193 RVA: 0x008298A4 File Offset: 0x00827AA4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_onlineRankingPlayerIconImage(IntPtr l)
	{
		int result;
		try
		{
			ArenaUIController arenaUIController = (ArenaUIController)LuaObject.checkSelf(l);
			Image onlineRankingPlayerIconImage;
			LuaObject.checkType<Image>(l, 2, out onlineRankingPlayerIconImage);
			arenaUIController.m_luaExportHelper.m_onlineRankingPlayerIconImage = onlineRankingPlayerIconImage;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601B25A RID: 111194 RVA: 0x00829900 File Offset: 0x00827B00
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_onlineRankingPlayerHeadFrameTransform(IntPtr l)
	{
		int result;
		try
		{
			ArenaUIController arenaUIController = (ArenaUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, arenaUIController.m_luaExportHelper.m_onlineRankingPlayerHeadFrameTransform);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601B25B RID: 111195 RVA: 0x00829958 File Offset: 0x00827B58
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_onlineRankingPlayerHeadFrameTransform(IntPtr l)
	{
		int result;
		try
		{
			ArenaUIController arenaUIController = (ArenaUIController)LuaObject.checkSelf(l);
			Transform onlineRankingPlayerHeadFrameTransform;
			LuaObject.checkType<Transform>(l, 2, out onlineRankingPlayerHeadFrameTransform);
			arenaUIController.m_luaExportHelper.m_onlineRankingPlayerHeadFrameTransform = onlineRankingPlayerHeadFrameTransform;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601B25C RID: 111196 RVA: 0x008299B4 File Offset: 0x00827BB4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_onlineRankingPlayerLevelText(IntPtr l)
	{
		int result;
		try
		{
			ArenaUIController arenaUIController = (ArenaUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, arenaUIController.m_luaExportHelper.m_onlineRankingPlayerLevelText);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601B25D RID: 111197 RVA: 0x00829A0C File Offset: 0x00827C0C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_onlineRankingPlayerLevelText(IntPtr l)
	{
		int result;
		try
		{
			ArenaUIController arenaUIController = (ArenaUIController)LuaObject.checkSelf(l);
			Text onlineRankingPlayerLevelText;
			LuaObject.checkType<Text>(l, 2, out onlineRankingPlayerLevelText);
			arenaUIController.m_luaExportHelper.m_onlineRankingPlayerLevelText = onlineRankingPlayerLevelText;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601B25E RID: 111198 RVA: 0x00829A68 File Offset: 0x00827C68
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_onlinePlayerIconImage(IntPtr l)
	{
		int result;
		try
		{
			ArenaUIController arenaUIController = (ArenaUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, arenaUIController.m_luaExportHelper.m_onlinePlayerIconImage);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601B25F RID: 111199 RVA: 0x00829AC0 File Offset: 0x00827CC0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_onlinePlayerIconImage(IntPtr l)
	{
		int result;
		try
		{
			ArenaUIController arenaUIController = (ArenaUIController)LuaObject.checkSelf(l);
			Image onlinePlayerIconImage;
			LuaObject.checkType<Image>(l, 2, out onlinePlayerIconImage);
			arenaUIController.m_luaExportHelper.m_onlinePlayerIconImage = onlinePlayerIconImage;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601B260 RID: 111200 RVA: 0x00829B1C File Offset: 0x00827D1C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_onlinePlayerNameText(IntPtr l)
	{
		int result;
		try
		{
			ArenaUIController arenaUIController = (ArenaUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, arenaUIController.m_luaExportHelper.m_onlinePlayerNameText);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601B261 RID: 111201 RVA: 0x00829B74 File Offset: 0x00827D74
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_onlinePlayerNameText(IntPtr l)
	{
		int result;
		try
		{
			ArenaUIController arenaUIController = (ArenaUIController)LuaObject.checkSelf(l);
			Text onlinePlayerNameText;
			LuaObject.checkType<Text>(l, 2, out onlinePlayerNameText);
			arenaUIController.m_luaExportHelper.m_onlinePlayerNameText = onlinePlayerNameText;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601B262 RID: 111202 RVA: 0x00829BD0 File Offset: 0x00827DD0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_onlineDanText(IntPtr l)
	{
		int result;
		try
		{
			ArenaUIController arenaUIController = (ArenaUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, arenaUIController.m_luaExportHelper.m_onlineDanText);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601B263 RID: 111203 RVA: 0x00829C28 File Offset: 0x00827E28
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_onlineDanText(IntPtr l)
	{
		int result;
		try
		{
			ArenaUIController arenaUIController = (ArenaUIController)LuaObject.checkSelf(l);
			Text onlineDanText;
			LuaObject.checkType<Text>(l, 2, out onlineDanText);
			arenaUIController.m_luaExportHelper.m_onlineDanText = onlineDanText;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601B264 RID: 111204 RVA: 0x00829C84 File Offset: 0x00827E84
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_onlineDanIconImage(IntPtr l)
	{
		int result;
		try
		{
			ArenaUIController arenaUIController = (ArenaUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, arenaUIController.m_luaExportHelper.m_onlineDanIconImage);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601B265 RID: 111205 RVA: 0x00829CDC File Offset: 0x00827EDC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_onlineDanIconImage(IntPtr l)
	{
		int result;
		try
		{
			ArenaUIController arenaUIController = (ArenaUIController)LuaObject.checkSelf(l);
			Image onlineDanIconImage;
			LuaObject.checkType<Image>(l, 2, out onlineDanIconImage);
			arenaUIController.m_luaExportHelper.m_onlineDanIconImage = onlineDanIconImage;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601B266 RID: 111206 RVA: 0x00829D38 File Offset: 0x00827F38
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_onlinePlayerLevelText(IntPtr l)
	{
		int result;
		try
		{
			ArenaUIController arenaUIController = (ArenaUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, arenaUIController.m_luaExportHelper.m_onlinePlayerLevelText);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601B267 RID: 111207 RVA: 0x00829D90 File Offset: 0x00827F90
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_onlinePlayerLevelText(IntPtr l)
	{
		int result;
		try
		{
			ArenaUIController arenaUIController = (ArenaUIController)LuaObject.checkSelf(l);
			Text onlinePlayerLevelText;
			LuaObject.checkType<Text>(l, 2, out onlinePlayerLevelText);
			arenaUIController.m_luaExportHelper.m_onlinePlayerLevelText = onlinePlayerLevelText;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601B268 RID: 111208 RVA: 0x00829DEC File Offset: 0x00827FEC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_onlineArenaPointsText(IntPtr l)
	{
		int result;
		try
		{
			ArenaUIController arenaUIController = (ArenaUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, arenaUIController.m_luaExportHelper.m_onlineArenaPointsText);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601B269 RID: 111209 RVA: 0x00829E44 File Offset: 0x00828044
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_onlineArenaPointsText(IntPtr l)
	{
		int result;
		try
		{
			ArenaUIController arenaUIController = (ArenaUIController)LuaObject.checkSelf(l);
			Text onlineArenaPointsText;
			LuaObject.checkType<Text>(l, 2, out onlineArenaPointsText);
			arenaUIController.m_luaExportHelper.m_onlineArenaPointsText = onlineArenaPointsText;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601B26A RID: 111210 RVA: 0x00829EA0 File Offset: 0x008280A0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_onlineArenaPointsUpText1(IntPtr l)
	{
		int result;
		try
		{
			ArenaUIController arenaUIController = (ArenaUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, arenaUIController.m_luaExportHelper.m_onlineArenaPointsUpText1);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601B26B RID: 111211 RVA: 0x00829EF8 File Offset: 0x008280F8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_onlineArenaPointsUpText1(IntPtr l)
	{
		int result;
		try
		{
			ArenaUIController arenaUIController = (ArenaUIController)LuaObject.checkSelf(l);
			Text onlineArenaPointsUpText;
			LuaObject.checkType<Text>(l, 2, out onlineArenaPointsUpText);
			arenaUIController.m_luaExportHelper.m_onlineArenaPointsUpText1 = onlineArenaPointsUpText;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601B26C RID: 111212 RVA: 0x00829F54 File Offset: 0x00828154
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_onlineArenaPointsUpText2(IntPtr l)
	{
		int result;
		try
		{
			ArenaUIController arenaUIController = (ArenaUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, arenaUIController.m_luaExportHelper.m_onlineArenaPointsUpText2);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601B26D RID: 111213 RVA: 0x00829FAC File Offset: 0x008281AC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_onlineArenaPointsUpText2(IntPtr l)
	{
		int result;
		try
		{
			ArenaUIController arenaUIController = (ArenaUIController)LuaObject.checkSelf(l);
			Text onlineArenaPointsUpText;
			LuaObject.checkType<Text>(l, 2, out onlineArenaPointsUpText);
			arenaUIController.m_luaExportHelper.m_onlineArenaPointsUpText2 = onlineArenaPointsUpText;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601B26E RID: 111214 RVA: 0x0082A008 File Offset: 0x00828208
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_onlineArenaPointsUpBarImage(IntPtr l)
	{
		int result;
		try
		{
			ArenaUIController arenaUIController = (ArenaUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, arenaUIController.m_luaExportHelper.m_onlineArenaPointsUpBarImage);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601B26F RID: 111215 RVA: 0x0082A060 File Offset: 0x00828260
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_onlineArenaPointsUpBarImage(IntPtr l)
	{
		int result;
		try
		{
			ArenaUIController arenaUIController = (ArenaUIController)LuaObject.checkSelf(l);
			Image onlineArenaPointsUpBarImage;
			LuaObject.checkType<Image>(l, 2, out onlineArenaPointsUpBarImage);
			arenaUIController.m_luaExportHelper.m_onlineArenaPointsUpBarImage = onlineArenaPointsUpBarImage;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601B270 RID: 111216 RVA: 0x0082A0BC File Offset: 0x008282BC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_onlineArenaRankingRewardButton(IntPtr l)
	{
		int result;
		try
		{
			ArenaUIController arenaUIController = (ArenaUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, arenaUIController.m_luaExportHelper.m_onlineArenaRankingRewardButton);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601B271 RID: 111217 RVA: 0x0082A114 File Offset: 0x00828314
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_onlineArenaRankingRewardButton(IntPtr l)
	{
		int result;
		try
		{
			ArenaUIController arenaUIController = (ArenaUIController)LuaObject.checkSelf(l);
			Button onlineArenaRankingRewardButton;
			LuaObject.checkType<Button>(l, 2, out onlineArenaRankingRewardButton);
			arenaUIController.m_luaExportHelper.m_onlineArenaRankingRewardButton = onlineArenaRankingRewardButton;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601B272 RID: 111218 RVA: 0x0082A170 File Offset: 0x00828370
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_onlineWeekWinText(IntPtr l)
	{
		int result;
		try
		{
			ArenaUIController arenaUIController = (ArenaUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, arenaUIController.m_luaExportHelper.m_onlineWeekWinText);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601B273 RID: 111219 RVA: 0x0082A1C8 File Offset: 0x008283C8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_onlineWeekWinText(IntPtr l)
	{
		int result;
		try
		{
			ArenaUIController arenaUIController = (ArenaUIController)LuaObject.checkSelf(l);
			Text onlineWeekWinText;
			LuaObject.checkType<Text>(l, 2, out onlineWeekWinText);
			arenaUIController.m_luaExportHelper.m_onlineWeekWinText = onlineWeekWinText;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601B274 RID: 111220 RVA: 0x0082A224 File Offset: 0x00828424
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_onlineWeekWinRewardButton1GameObject(IntPtr l)
	{
		int result;
		try
		{
			ArenaUIController arenaUIController = (ArenaUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, arenaUIController.m_luaExportHelper.m_onlineWeekWinRewardButton1GameObject);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601B275 RID: 111221 RVA: 0x0082A27C File Offset: 0x0082847C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_onlineWeekWinRewardButton1GameObject(IntPtr l)
	{
		int result;
		try
		{
			ArenaUIController arenaUIController = (ArenaUIController)LuaObject.checkSelf(l);
			GameObject onlineWeekWinRewardButton1GameObject;
			LuaObject.checkType<GameObject>(l, 2, out onlineWeekWinRewardButton1GameObject);
			arenaUIController.m_luaExportHelper.m_onlineWeekWinRewardButton1GameObject = onlineWeekWinRewardButton1GameObject;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601B276 RID: 111222 RVA: 0x0082A2D8 File Offset: 0x008284D8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_onlineWeekWinRewardButton2GameObject(IntPtr l)
	{
		int result;
		try
		{
			ArenaUIController arenaUIController = (ArenaUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, arenaUIController.m_luaExportHelper.m_onlineWeekWinRewardButton2GameObject);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601B277 RID: 111223 RVA: 0x0082A330 File Offset: 0x00828530
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_onlineWeekWinRewardButton2GameObject(IntPtr l)
	{
		int result;
		try
		{
			ArenaUIController arenaUIController = (ArenaUIController)LuaObject.checkSelf(l);
			GameObject onlineWeekWinRewardButton2GameObject;
			LuaObject.checkType<GameObject>(l, 2, out onlineWeekWinRewardButton2GameObject);
			arenaUIController.m_luaExportHelper.m_onlineWeekWinRewardButton2GameObject = onlineWeekWinRewardButton2GameObject;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601B278 RID: 111224 RVA: 0x0082A38C File Offset: 0x0082858C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_onlineWeekWinRewardButton3GameObject(IntPtr l)
	{
		int result;
		try
		{
			ArenaUIController arenaUIController = (ArenaUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, arenaUIController.m_luaExportHelper.m_onlineWeekWinRewardButton3GameObject);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601B279 RID: 111225 RVA: 0x0082A3E4 File Offset: 0x008285E4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_onlineWeekWinRewardButton3GameObject(IntPtr l)
	{
		int result;
		try
		{
			ArenaUIController arenaUIController = (ArenaUIController)LuaObject.checkSelf(l);
			GameObject onlineWeekWinRewardButton3GameObject;
			LuaObject.checkType<GameObject>(l, 2, out onlineWeekWinRewardButton3GameObject);
			arenaUIController.m_luaExportHelper.m_onlineWeekWinRewardButton3GameObject = onlineWeekWinRewardButton3GameObject;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601B27A RID: 111226 RVA: 0x0082A440 File Offset: 0x00828640
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_onlineWeekWinRewardImage(IntPtr l)
	{
		int result;
		try
		{
			ArenaUIController arenaUIController = (ArenaUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, arenaUIController.m_luaExportHelper.m_onlineWeekWinRewardImage);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601B27B RID: 111227 RVA: 0x0082A498 File Offset: 0x00828698
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_onlineWeekWinRewardImage(IntPtr l)
	{
		int result;
		try
		{
			ArenaUIController arenaUIController = (ArenaUIController)LuaObject.checkSelf(l);
			Image onlineWeekWinRewardImage;
			LuaObject.checkType<Image>(l, 2, out onlineWeekWinRewardImage);
			arenaUIController.m_luaExportHelper.m_onlineWeekWinRewardImage = onlineWeekWinRewardImage;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601B27C RID: 111228 RVA: 0x0082A4F4 File Offset: 0x008286F4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_promoteBattleUIStateController(IntPtr l)
	{
		int result;
		try
		{
			ArenaUIController arenaUIController = (ArenaUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, arenaUIController.m_luaExportHelper.m_promoteBattleUIStateController);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601B27D RID: 111229 RVA: 0x0082A54C File Offset: 0x0082874C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_promoteBattleUIStateController(IntPtr l)
	{
		int result;
		try
		{
			ArenaUIController arenaUIController = (ArenaUIController)LuaObject.checkSelf(l);
			CommonUIStateController promoteBattleUIStateController;
			LuaObject.checkType<CommonUIStateController>(l, 2, out promoteBattleUIStateController);
			arenaUIController.m_luaExportHelper.m_promoteBattleUIStateController = promoteBattleUIStateController;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601B27E RID: 111230 RVA: 0x0082A5A8 File Offset: 0x008287A8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_promoteBattleBGButton(IntPtr l)
	{
		int result;
		try
		{
			ArenaUIController arenaUIController = (ArenaUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, arenaUIController.m_luaExportHelper.m_promoteBattleBGButton);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601B27F RID: 111231 RVA: 0x0082A600 File Offset: 0x00828800
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_promoteBattleBGButton(IntPtr l)
	{
		int result;
		try
		{
			ArenaUIController arenaUIController = (ArenaUIController)LuaObject.checkSelf(l);
			Button promoteBattleBGButton;
			LuaObject.checkType<Button>(l, 2, out promoteBattleBGButton);
			arenaUIController.m_luaExportHelper.m_promoteBattleBGButton = promoteBattleBGButton;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601B280 RID: 111232 RVA: 0x0082A65C File Offset: 0x0082885C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_promoteBattleText(IntPtr l)
	{
		int result;
		try
		{
			ArenaUIController arenaUIController = (ArenaUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, arenaUIController.m_luaExportHelper.m_promoteBattleText);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601B281 RID: 111233 RVA: 0x0082A6B4 File Offset: 0x008288B4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_promoteBattleText(IntPtr l)
	{
		int result;
		try
		{
			ArenaUIController arenaUIController = (ArenaUIController)LuaObject.checkSelf(l);
			Text promoteBattleText;
			LuaObject.checkType<Text>(l, 2, out promoteBattleText);
			arenaUIController.m_luaExportHelper.m_promoteBattleText = promoteBattleText;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601B282 RID: 111234 RVA: 0x0082A710 File Offset: 0x00828910
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_promoteBattleConfirmButton(IntPtr l)
	{
		int result;
		try
		{
			ArenaUIController arenaUIController = (ArenaUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, arenaUIController.m_luaExportHelper.m_promoteBattleConfirmButton);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601B283 RID: 111235 RVA: 0x0082A768 File Offset: 0x00828968
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_promoteBattleConfirmButton(IntPtr l)
	{
		int result;
		try
		{
			ArenaUIController arenaUIController = (ArenaUIController)LuaObject.checkSelf(l);
			Button promoteBattleConfirmButton;
			LuaObject.checkType<Button>(l, 2, out promoteBattleConfirmButton);
			arenaUIController.m_luaExportHelper.m_promoteBattleConfirmButton = promoteBattleConfirmButton;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601B284 RID: 111236 RVA: 0x0082A7C4 File Offset: 0x008289C4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_promoteSucceedUIStateController(IntPtr l)
	{
		int result;
		try
		{
			ArenaUIController arenaUIController = (ArenaUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, arenaUIController.m_luaExportHelper.m_promoteSucceedUIStateController);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601B285 RID: 111237 RVA: 0x0082A81C File Offset: 0x00828A1C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_promoteSucceedUIStateController(IntPtr l)
	{
		int result;
		try
		{
			ArenaUIController arenaUIController = (ArenaUIController)LuaObject.checkSelf(l);
			CommonUIStateController promoteSucceedUIStateController;
			LuaObject.checkType<CommonUIStateController>(l, 2, out promoteSucceedUIStateController);
			arenaUIController.m_luaExportHelper.m_promoteSucceedUIStateController = promoteSucceedUIStateController;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601B286 RID: 111238 RVA: 0x0082A878 File Offset: 0x00828A78
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_promoteSucceedBGButton(IntPtr l)
	{
		int result;
		try
		{
			ArenaUIController arenaUIController = (ArenaUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, arenaUIController.m_luaExportHelper.m_promoteSucceedBGButton);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601B287 RID: 111239 RVA: 0x0082A8D0 File Offset: 0x00828AD0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_promoteSucceedBGButton(IntPtr l)
	{
		int result;
		try
		{
			ArenaUIController arenaUIController = (ArenaUIController)LuaObject.checkSelf(l);
			Button promoteSucceedBGButton;
			LuaObject.checkType<Button>(l, 2, out promoteSucceedBGButton);
			arenaUIController.m_luaExportHelper.m_promoteSucceedBGButton = promoteSucceedBGButton;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601B288 RID: 111240 RVA: 0x0082A92C File Offset: 0x00828B2C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_promoteSucceedDanImage(IntPtr l)
	{
		int result;
		try
		{
			ArenaUIController arenaUIController = (ArenaUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, arenaUIController.m_luaExportHelper.m_promoteSucceedDanImage);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601B289 RID: 111241 RVA: 0x0082A984 File Offset: 0x00828B84
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_promoteSucceedDanImage(IntPtr l)
	{
		int result;
		try
		{
			ArenaUIController arenaUIController = (ArenaUIController)LuaObject.checkSelf(l);
			Image promoteSucceedDanImage;
			LuaObject.checkType<Image>(l, 2, out promoteSucceedDanImage);
			arenaUIController.m_luaExportHelper.m_promoteSucceedDanImage = promoteSucceedDanImage;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601B28A RID: 111242 RVA: 0x0082A9E0 File Offset: 0x00828BE0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_promoteSucceedDanText(IntPtr l)
	{
		int result;
		try
		{
			ArenaUIController arenaUIController = (ArenaUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, arenaUIController.m_luaExportHelper.m_promoteSucceedDanText);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601B28B RID: 111243 RVA: 0x0082AA38 File Offset: 0x00828C38
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_promoteSucceedDanText(IntPtr l)
	{
		int result;
		try
		{
			ArenaUIController arenaUIController = (ArenaUIController)LuaObject.checkSelf(l);
			Text promoteSucceedDanText;
			LuaObject.checkType<Text>(l, 2, out promoteSucceedDanText);
			arenaUIController.m_luaExportHelper.m_promoteSucceedDanText = promoteSucceedDanText;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601B28C RID: 111244 RVA: 0x0082AA94 File Offset: 0x00828C94
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_promoteSucceedConfirmButton(IntPtr l)
	{
		int result;
		try
		{
			ArenaUIController arenaUIController = (ArenaUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, arenaUIController.m_luaExportHelper.m_promoteSucceedConfirmButton);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601B28D RID: 111245 RVA: 0x0082AAEC File Offset: 0x00828CEC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_promoteSucceedConfirmButton(IntPtr l)
	{
		int result;
		try
		{
			ArenaUIController arenaUIController = (ArenaUIController)LuaObject.checkSelf(l);
			Button promoteSucceedConfirmButton;
			LuaObject.checkType<Button>(l, 2, out promoteSucceedConfirmButton);
			arenaUIController.m_luaExportHelper.m_promoteSucceedConfirmButton = promoteSucceedConfirmButton;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601B28E RID: 111246 RVA: 0x0082AB48 File Offset: 0x00828D48
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_matchingFailedUIStateController(IntPtr l)
	{
		int result;
		try
		{
			ArenaUIController arenaUIController = (ArenaUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, arenaUIController.m_luaExportHelper.m_matchingFailedUIStateController);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601B28F RID: 111247 RVA: 0x0082ABA0 File Offset: 0x00828DA0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_matchingFailedUIStateController(IntPtr l)
	{
		int result;
		try
		{
			ArenaUIController arenaUIController = (ArenaUIController)LuaObject.checkSelf(l);
			CommonUIStateController matchingFailedUIStateController;
			LuaObject.checkType<CommonUIStateController>(l, 2, out matchingFailedUIStateController);
			arenaUIController.m_luaExportHelper.m_matchingFailedUIStateController = matchingFailedUIStateController;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601B290 RID: 111248 RVA: 0x0082ABFC File Offset: 0x00828DFC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_matchingFailedBGButton(IntPtr l)
	{
		int result;
		try
		{
			ArenaUIController arenaUIController = (ArenaUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, arenaUIController.m_luaExportHelper.m_matchingFailedBGButton);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601B291 RID: 111249 RVA: 0x0082AC54 File Offset: 0x00828E54
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_matchingFailedBGButton(IntPtr l)
	{
		int result;
		try
		{
			ArenaUIController arenaUIController = (ArenaUIController)LuaObject.checkSelf(l);
			Button matchingFailedBGButton;
			LuaObject.checkType<Button>(l, 2, out matchingFailedBGButton);
			arenaUIController.m_luaExportHelper.m_matchingFailedBGButton = matchingFailedBGButton;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601B292 RID: 111250 RVA: 0x0082ACB0 File Offset: 0x00828EB0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_matchingFailedConfirmButton(IntPtr l)
	{
		int result;
		try
		{
			ArenaUIController arenaUIController = (ArenaUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, arenaUIController.m_luaExportHelper.m_matchingFailedConfirmButton);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601B293 RID: 111251 RVA: 0x0082AD08 File Offset: 0x00828F08
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_matchingFailedConfirmButton(IntPtr l)
	{
		int result;
		try
		{
			ArenaUIController arenaUIController = (ArenaUIController)LuaObject.checkSelf(l);
			Button matchingFailedConfirmButton;
			LuaObject.checkType<Button>(l, 2, out matchingFailedConfirmButton);
			arenaUIController.m_luaExportHelper.m_matchingFailedConfirmButton = matchingFailedConfirmButton;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601B294 RID: 111252 RVA: 0x0082AD64 File Offset: 0x00828F64
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_matchingNowUIStateController(IntPtr l)
	{
		int result;
		try
		{
			ArenaUIController arenaUIController = (ArenaUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, arenaUIController.m_luaExportHelper.m_matchingNowUIStateController);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601B295 RID: 111253 RVA: 0x0082ADBC File Offset: 0x00828FBC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_matchingNowUIStateController(IntPtr l)
	{
		int result;
		try
		{
			ArenaUIController arenaUIController = (ArenaUIController)LuaObject.checkSelf(l);
			CommonUIStateController matchingNowUIStateController;
			LuaObject.checkType<CommonUIStateController>(l, 2, out matchingNowUIStateController);
			arenaUIController.m_luaExportHelper.m_matchingNowUIStateController = matchingNowUIStateController;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601B296 RID: 111254 RVA: 0x0082AE18 File Offset: 0x00829018
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_matchingNowTimeText(IntPtr l)
	{
		int result;
		try
		{
			ArenaUIController arenaUIController = (ArenaUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, arenaUIController.m_luaExportHelper.m_matchingNowTimeText);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601B297 RID: 111255 RVA: 0x0082AE70 File Offset: 0x00829070
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_matchingNowTimeText(IntPtr l)
	{
		int result;
		try
		{
			ArenaUIController arenaUIController = (ArenaUIController)LuaObject.checkSelf(l);
			Text matchingNowTimeText;
			LuaObject.checkType<Text>(l, 2, out matchingNowTimeText);
			arenaUIController.m_luaExportHelper.m_matchingNowTimeText = matchingNowTimeText;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601B298 RID: 111256 RVA: 0x0082AECC File Offset: 0x008290CC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_matchingNowPredictTimeGameObject(IntPtr l)
	{
		int result;
		try
		{
			ArenaUIController arenaUIController = (ArenaUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, arenaUIController.m_luaExportHelper.m_matchingNowPredictTimeGameObject);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601B299 RID: 111257 RVA: 0x0082AF24 File Offset: 0x00829124
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_matchingNowPredictTimeGameObject(IntPtr l)
	{
		int result;
		try
		{
			ArenaUIController arenaUIController = (ArenaUIController)LuaObject.checkSelf(l);
			GameObject matchingNowPredictTimeGameObject;
			LuaObject.checkType<GameObject>(l, 2, out matchingNowPredictTimeGameObject);
			arenaUIController.m_luaExportHelper.m_matchingNowPredictTimeGameObject = matchingNowPredictTimeGameObject;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601B29A RID: 111258 RVA: 0x0082AF80 File Offset: 0x00829180
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_matchingNowPredictTimeText(IntPtr l)
	{
		int result;
		try
		{
			ArenaUIController arenaUIController = (ArenaUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, arenaUIController.m_luaExportHelper.m_matchingNowPredictTimeText);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601B29B RID: 111259 RVA: 0x0082AFD8 File Offset: 0x008291D8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_matchingNowPredictTimeText(IntPtr l)
	{
		int result;
		try
		{
			ArenaUIController arenaUIController = (ArenaUIController)LuaObject.checkSelf(l);
			Text matchingNowPredictTimeText;
			LuaObject.checkType<Text>(l, 2, out matchingNowPredictTimeText);
			arenaUIController.m_luaExportHelper.m_matchingNowPredictTimeText = matchingNowPredictTimeText;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601B29C RID: 111260 RVA: 0x0082B034 File Offset: 0x00829234
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_matchingNowCancelButton(IntPtr l)
	{
		int result;
		try
		{
			ArenaUIController arenaUIController = (ArenaUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, arenaUIController.m_luaExportHelper.m_matchingNowCancelButton);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601B29D RID: 111261 RVA: 0x0082B08C File Offset: 0x0082928C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_matchingNowCancelButton(IntPtr l)
	{
		int result;
		try
		{
			ArenaUIController arenaUIController = (ArenaUIController)LuaObject.checkSelf(l);
			Button matchingNowCancelButton;
			LuaObject.checkType<Button>(l, 2, out matchingNowCancelButton);
			arenaUIController.m_luaExportHelper.m_matchingNowCancelButton = matchingNowCancelButton;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601B29E RID: 111262 RVA: 0x0082B0E8 File Offset: 0x008292E8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_onlineArenaRankingPool(IntPtr l)
	{
		int result;
		try
		{
			ArenaUIController arenaUIController = (ArenaUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, arenaUIController.m_luaExportHelper.m_onlineArenaRankingPool);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601B29F RID: 111263 RVA: 0x0082B140 File Offset: 0x00829340
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_onlineArenaRankingPool(IntPtr l)
	{
		int result;
		try
		{
			ArenaUIController arenaUIController = (ArenaUIController)LuaObject.checkSelf(l);
			GameObjectPool<ArenaRankingListItemUIController> onlineArenaRankingPool;
			LuaObject.checkType<GameObjectPool<ArenaRankingListItemUIController>>(l, 2, out onlineArenaRankingPool);
			arenaUIController.m_luaExportHelper.m_onlineArenaRankingPool = onlineArenaRankingPool;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601B2A0 RID: 111264 RVA: 0x0082B19C File Offset: 0x0082939C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_onlineArenaBattleReportPool(IntPtr l)
	{
		int result;
		try
		{
			ArenaUIController arenaUIController = (ArenaUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, arenaUIController.m_luaExportHelper.m_onlineArenaBattleReportPool);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601B2A1 RID: 111265 RVA: 0x0082B1F4 File Offset: 0x008293F4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_onlineArenaBattleReportPool(IntPtr l)
	{
		int result;
		try
		{
			ArenaUIController arenaUIController = (ArenaUIController)LuaObject.checkSelf(l);
			GameObjectPool<OnlineArenaBattleReportListItemUIController> onlineArenaBattleReportPool;
			LuaObject.checkType<GameObjectPool<OnlineArenaBattleReportListItemUIController>>(l, 2, out onlineArenaBattleReportPool);
			arenaUIController.m_luaExportHelper.m_onlineArenaBattleReportPool = onlineArenaBattleReportPool;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601B2A2 RID: 111266 RVA: 0x0082B250 File Offset: 0x00829450
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_onlineArenaRankingRewardPool(IntPtr l)
	{
		int result;
		try
		{
			ArenaUIController arenaUIController = (ArenaUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, arenaUIController.m_luaExportHelper.m_onlineArenaRankingRewardPool);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601B2A3 RID: 111267 RVA: 0x0082B2A8 File Offset: 0x008294A8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_onlineArenaRankingRewardPool(IntPtr l)
	{
		int result;
		try
		{
			ArenaUIController arenaUIController = (ArenaUIController)LuaObject.checkSelf(l);
			GameObjectPool<ArenaRankingRewardListItemUIController> onlineArenaRankingRewardPool;
			LuaObject.checkType<GameObjectPool<ArenaRankingRewardListItemUIController>>(l, 2, out onlineArenaRankingRewardPool);
			arenaUIController.m_luaExportHelper.m_onlineArenaRankingRewardPool = onlineArenaRankingRewardPool;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601B2A4 RID: 111268 RVA: 0x0082B304 File Offset: 0x00829504
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_isMatchingNow(IntPtr l)
	{
		int result;
		try
		{
			ArenaUIController arenaUIController = (ArenaUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, arenaUIController.m_luaExportHelper.m_isMatchingNow);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601B2A5 RID: 111269 RVA: 0x0082B35C File Offset: 0x0082955C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_isMatchingNow(IntPtr l)
	{
		int result;
		try
		{
			ArenaUIController arenaUIController = (ArenaUIController)LuaObject.checkSelf(l);
			bool isMatchingNow;
			LuaObject.checkType(l, 2, out isMatchingNow);
			arenaUIController.m_luaExportHelper.m_isMatchingNow = isMatchingNow;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601B2A6 RID: 111270 RVA: 0x0082B3B8 File Offset: 0x008295B8
	[Preserve]
	public static void reg(IntPtr l)
	{
		LuaObject.getTypeTable(l, "BlackJack.ProjectL.UI.ArenaUIController");
		if (Lua_BlackJack_ProjectL_UI_ArenaUIController.<>f__mg$cache0 == null)
		{
			Lua_BlackJack_ProjectL_UI_ArenaUIController.<>f__mg$cache0 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ArenaUIController.Open);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_ArenaUIController.<>f__mg$cache0);
		if (Lua_BlackJack_ProjectL_UI_ArenaUIController.<>f__mg$cache1 == null)
		{
			Lua_BlackJack_ProjectL_UI_ArenaUIController.<>f__mg$cache1 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ArenaUIController.SwitchOfflineOnline);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_ArenaUIController.<>f__mg$cache1);
		if (Lua_BlackJack_ProjectL_UI_ArenaUIController.<>f__mg$cache2 == null)
		{
			Lua_BlackJack_ProjectL_UI_ArenaUIController.<>f__mg$cache2 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ArenaUIController.SetPlayerHeadIcon);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_ArenaUIController.<>f__mg$cache2);
		if (Lua_BlackJack_ProjectL_UI_ArenaUIController.<>f__mg$cache3 == null)
		{
			Lua_BlackJack_ProjectL_UI_ArenaUIController.<>f__mg$cache3 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ArenaUIController.SetPlayerName);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_ArenaUIController.<>f__mg$cache3);
		if (Lua_BlackJack_ProjectL_UI_ArenaUIController.<>f__mg$cache4 == null)
		{
			Lua_BlackJack_ProjectL_UI_ArenaUIController.<>f__mg$cache4 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ArenaUIController.SetPlayerLevel);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_ArenaUIController.<>f__mg$cache4);
		if (Lua_BlackJack_ProjectL_UI_ArenaUIController.<>f__mg$cache5 == null)
		{
			Lua_BlackJack_ProjectL_UI_ArenaUIController.<>f__mg$cache5 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ArenaUIController.SetArenaHonor);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_ArenaUIController.<>f__mg$cache5);
		if (Lua_BlackJack_ProjectL_UI_ArenaUIController.<>f__mg$cache6 == null)
		{
			Lua_BlackJack_ProjectL_UI_ArenaUIController.<>f__mg$cache6 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ArenaUIController.SetArenaTicket);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_ArenaUIController.<>f__mg$cache6);
		if (Lua_BlackJack_ProjectL_UI_ArenaUIController.<>f__mg$cache7 == null)
		{
			Lua_BlackJack_ProjectL_UI_ArenaUIController.<>f__mg$cache7 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ArenaUIController.SetBattlePower);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_ArenaUIController.<>f__mg$cache7);
		if (Lua_BlackJack_ProjectL_UI_ArenaUIController.<>f__mg$cache8 == null)
		{
			Lua_BlackJack_ProjectL_UI_ArenaUIController.<>f__mg$cache8 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ArenaUIController.ShowBuyArenaTicket);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_ArenaUIController.<>f__mg$cache8);
		if (Lua_BlackJack_ProjectL_UI_ArenaUIController.<>f__mg$cache9 == null)
		{
			Lua_BlackJack_ProjectL_UI_ArenaUIController.<>f__mg$cache9 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ArenaUIController.HideBuyArenaTicket);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_ArenaUIController.<>f__mg$cache9);
		if (Lua_BlackJack_ProjectL_UI_ArenaUIController.<>f__mg$cacheA == null)
		{
			Lua_BlackJack_ProjectL_UI_ArenaUIController.<>f__mg$cacheA = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ArenaUIController.SetOfflineArenaPointsAndLevel);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_ArenaUIController.<>f__mg$cacheA);
		if (Lua_BlackJack_ProjectL_UI_ArenaUIController.<>f__mg$cacheB == null)
		{
			Lua_BlackJack_ProjectL_UI_ArenaUIController.<>f__mg$cacheB = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ArenaUIController.SetOfflineWeekWin);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_ArenaUIController.<>f__mg$cacheB);
		if (Lua_BlackJack_ProjectL_UI_ArenaUIController.<>f__mg$cacheC == null)
		{
			Lua_BlackJack_ProjectL_UI_ArenaUIController.<>f__mg$cacheC = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ArenaUIController.SetOfflineInSettleTime);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_ArenaUIController.<>f__mg$cacheC);
		if (Lua_BlackJack_ProjectL_UI_ArenaUIController.<>f__mg$cacheD == null)
		{
			Lua_BlackJack_ProjectL_UI_ArenaUIController.<>f__mg$cacheD = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ArenaUIController.SetOfflineVictoryPointsRewardStatus);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_ArenaUIController.<>f__mg$cacheD);
		if (Lua_BlackJack_ProjectL_UI_ArenaUIController.<>f__mg$cacheE == null)
		{
			Lua_BlackJack_ProjectL_UI_ArenaUIController.<>f__mg$cacheE = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ArenaUIController.SetOfflineVictoryPointsRewardProgress);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_ArenaUIController.<>f__mg$cacheE);
		if (Lua_BlackJack_ProjectL_UI_ArenaUIController.<>f__mg$cacheF == null)
		{
			Lua_BlackJack_ProjectL_UI_ArenaUIController.<>f__mg$cacheF = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ArenaUIController.SetOfflineArenaOpponents);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_ArenaUIController.<>f__mg$cacheF);
		if (Lua_BlackJack_ProjectL_UI_ArenaUIController.<>f__mg$cache10 == null)
		{
			Lua_BlackJack_ProjectL_UI_ArenaUIController.<>f__mg$cache10 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ArenaUIController.SetOfflineArenaOpponentsRefreshTime);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_ArenaUIController.<>f__mg$cache10);
		if (Lua_BlackJack_ProjectL_UI_ArenaUIController.<>f__mg$cache11 == null)
		{
			Lua_BlackJack_ProjectL_UI_ArenaUIController.<>f__mg$cache11 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ArenaUIController.SetOfflineArenaBattleReports);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_ArenaUIController.<>f__mg$cache11);
		if (Lua_BlackJack_ProjectL_UI_ArenaUIController.<>f__mg$cache12 == null)
		{
			Lua_BlackJack_ProjectL_UI_ArenaUIController.<>f__mg$cache12 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ArenaUIController.SetOfflineArenaRankings);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_ArenaUIController.<>f__mg$cache12);
		if (Lua_BlackJack_ProjectL_UI_ArenaUIController.<>f__mg$cache13 == null)
		{
			Lua_BlackJack_ProjectL_UI_ArenaUIController.<>f__mg$cache13 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ArenaUIController.ShowOfflinePanel);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_ArenaUIController.<>f__mg$cache13);
		if (Lua_BlackJack_ProjectL_UI_ArenaUIController.<>f__mg$cache14 == null)
		{
			Lua_BlackJack_ProjectL_UI_ArenaUIController.<>f__mg$cache14 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ArenaUIController.ShowArenaOpponent);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_ArenaUIController.<>f__mg$cache14);
		if (Lua_BlackJack_ProjectL_UI_ArenaUIController.<>f__mg$cache15 == null)
		{
			Lua_BlackJack_ProjectL_UI_ArenaUIController.<>f__mg$cache15 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ArenaUIController.SetOnlineScoreAndDan);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_ArenaUIController.<>f__mg$cache15);
		if (Lua_BlackJack_ProjectL_UI_ArenaUIController.<>f__mg$cache16 == null)
		{
			Lua_BlackJack_ProjectL_UI_ArenaUIController.<>f__mg$cache16 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ArenaUIController.SetLadderMode);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_ArenaUIController.<>f__mg$cache16);
		if (Lua_BlackJack_ProjectL_UI_ArenaUIController.<>f__mg$cache17 == null)
		{
			Lua_BlackJack_ProjectL_UI_ArenaUIController.<>f__mg$cache17 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ArenaUIController.SetLadderOpenTime);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_ArenaUIController.<>f__mg$cache17);
		if (Lua_BlackJack_ProjectL_UI_ArenaUIController.<>f__mg$cache18 == null)
		{
			Lua_BlackJack_ProjectL_UI_ArenaUIController.<>f__mg$cache18 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ArenaUIController.SetLadderWeekWin);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_ArenaUIController.<>f__mg$cache18);
		if (Lua_BlackJack_ProjectL_UI_ArenaUIController.<>f__mg$cache19 == null)
		{
			Lua_BlackJack_ProjectL_UI_ArenaUIController.<>f__mg$cache19 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ArenaUIController.SetOnlineWeekWinRewardStatus);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_ArenaUIController.<>f__mg$cache19);
		if (Lua_BlackJack_ProjectL_UI_ArenaUIController.<>f__mg$cache1A == null)
		{
			Lua_BlackJack_ProjectL_UI_ArenaUIController.<>f__mg$cache1A = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ArenaUIController.SetOnlineWeekWinRewardProgress);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_ArenaUIController.<>f__mg$cache1A);
		if (Lua_BlackJack_ProjectL_UI_ArenaUIController.<>f__mg$cache1B == null)
		{
			Lua_BlackJack_ProjectL_UI_ArenaUIController.<>f__mg$cache1B = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ArenaUIController.ShowPromoteBattle);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_ArenaUIController.<>f__mg$cache1B);
		if (Lua_BlackJack_ProjectL_UI_ArenaUIController.<>f__mg$cache1C == null)
		{
			Lua_BlackJack_ProjectL_UI_ArenaUIController.<>f__mg$cache1C = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ArenaUIController.ShowPromoteSucceed);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_ArenaUIController.<>f__mg$cache1C);
		if (Lua_BlackJack_ProjectL_UI_ArenaUIController.<>f__mg$cache1D == null)
		{
			Lua_BlackJack_ProjectL_UI_ArenaUIController.<>f__mg$cache1D = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ArenaUIController.SetPromoteBattleStatus);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_ArenaUIController.<>f__mg$cache1D);
		if (Lua_BlackJack_ProjectL_UI_ArenaUIController.<>f__mg$cache1E == null)
		{
			Lua_BlackJack_ProjectL_UI_ArenaUIController.<>f__mg$cache1E = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ArenaUIController.SetOnlineDans);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_ArenaUIController.<>f__mg$cache1E);
		if (Lua_BlackJack_ProjectL_UI_ArenaUIController.<>f__mg$cache1F == null)
		{
			Lua_BlackJack_ProjectL_UI_ArenaUIController.<>f__mg$cache1F = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ArenaUIController.SetOnlineArenaBattleReports);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_ArenaUIController.<>f__mg$cache1F);
		if (Lua_BlackJack_ProjectL_UI_ArenaUIController.<>f__mg$cache20 == null)
		{
			Lua_BlackJack_ProjectL_UI_ArenaUIController.<>f__mg$cache20 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ArenaUIController.SetOnlineArenaRankings);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_ArenaUIController.<>f__mg$cache20);
		if (Lua_BlackJack_ProjectL_UI_ArenaUIController.<>f__mg$cache21 == null)
		{
			Lua_BlackJack_ProjectL_UI_ArenaUIController.<>f__mg$cache21 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ArenaUIController.ShowGlobalRankingToggle);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_ArenaUIController.<>f__mg$cache21);
		if (Lua_BlackJack_ProjectL_UI_ArenaUIController.<>f__mg$cache22 == null)
		{
			Lua_BlackJack_ProjectL_UI_ArenaUIController.<>f__mg$cache22 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ArenaUIController.ShowOnlinePanel);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_ArenaUIController.<>f__mg$cache22);
		if (Lua_BlackJack_ProjectL_UI_ArenaUIController.<>f__mg$cache23 == null)
		{
			Lua_BlackJack_ProjectL_UI_ArenaUIController.<>f__mg$cache23 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ArenaUIController.ShowMatchingNow);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_ArenaUIController.<>f__mg$cache23);
		if (Lua_BlackJack_ProjectL_UI_ArenaUIController.<>f__mg$cache24 == null)
		{
			Lua_BlackJack_ProjectL_UI_ArenaUIController.<>f__mg$cache24 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ArenaUIController.HideMatchingNow);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_ArenaUIController.<>f__mg$cache24);
		if (Lua_BlackJack_ProjectL_UI_ArenaUIController.<>f__mg$cache25 == null)
		{
			Lua_BlackJack_ProjectL_UI_ArenaUIController.<>f__mg$cache25 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ArenaUIController.SetMatchingNowTime);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_ArenaUIController.<>f__mg$cache25);
		if (Lua_BlackJack_ProjectL_UI_ArenaUIController.<>f__mg$cache26 == null)
		{
			Lua_BlackJack_ProjectL_UI_ArenaUIController.<>f__mg$cache26 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ArenaUIController.SetMatchingPredictTime);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_ArenaUIController.<>f__mg$cache26);
		if (Lua_BlackJack_ProjectL_UI_ArenaUIController.<>f__mg$cache27 == null)
		{
			Lua_BlackJack_ProjectL_UI_ArenaUIController.<>f__mg$cache27 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ArenaUIController.IsMatchingNowPredictTimeActive);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_ArenaUIController.<>f__mg$cache27);
		if (Lua_BlackJack_ProjectL_UI_ArenaUIController.<>f__mg$cache28 == null)
		{
			Lua_BlackJack_ProjectL_UI_ArenaUIController.<>f__mg$cache28 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ArenaUIController.ShowMatchingFailed);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_ArenaUIController.<>f__mg$cache28);
		if (Lua_BlackJack_ProjectL_UI_ArenaUIController.<>f__mg$cache29 == null)
		{
			Lua_BlackJack_ProjectL_UI_ArenaUIController.<>f__mg$cache29 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ArenaUIController.OnBindFiledsCompleted);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_ArenaUIController.<>f__mg$cache29);
		if (Lua_BlackJack_ProjectL_UI_ArenaUIController.<>f__mg$cache2A == null)
		{
			Lua_BlackJack_ProjectL_UI_ArenaUIController.<>f__mg$cache2A = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ArenaUIController.ShowArenaTicketDesc);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_ArenaUIController.<>f__mg$cache2A);
		if (Lua_BlackJack_ProjectL_UI_ArenaUIController.<>f__mg$cache2B == null)
		{
			Lua_BlackJack_ProjectL_UI_ArenaUIController.<>f__mg$cache2B = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ArenaUIController.CloseArenaTicketDesc);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_ArenaUIController.<>f__mg$cache2B);
		if (Lua_BlackJack_ProjectL_UI_ArenaUIController.<>f__mg$cache2C == null)
		{
			Lua_BlackJack_ProjectL_UI_ArenaUIController.<>f__mg$cache2C = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ArenaUIController.CreateSpineGraphic);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_ArenaUIController.<>f__mg$cache2C);
		if (Lua_BlackJack_ProjectL_UI_ArenaUIController.<>f__mg$cache2D == null)
		{
			Lua_BlackJack_ProjectL_UI_ArenaUIController.<>f__mg$cache2D = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ArenaUIController.AddRewardPreviewGoods);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_ArenaUIController.<>f__mg$cache2D);
		if (Lua_BlackJack_ProjectL_UI_ArenaUIController.<>f__mg$cache2E == null)
		{
			Lua_BlackJack_ProjectL_UI_ArenaUIController.<>f__mg$cache2E = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ArenaUIController.OnReturnButtonClick);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_ArenaUIController.<>f__mg$cache2E);
		if (Lua_BlackJack_ProjectL_UI_ArenaUIController.<>f__mg$cache2F == null)
		{
			Lua_BlackJack_ProjectL_UI_ArenaUIController.<>f__mg$cache2F = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ArenaUIController.OnHelpButtonClick);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_ArenaUIController.<>f__mg$cache2F);
		if (Lua_BlackJack_ProjectL_UI_ArenaUIController.<>f__mg$cache30 == null)
		{
			Lua_BlackJack_ProjectL_UI_ArenaUIController.<>f__mg$cache30 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ArenaUIController.OnRewardPreviewBackgroundButtonClick);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_ArenaUIController.<>f__mg$cache30);
		if (Lua_BlackJack_ProjectL_UI_ArenaUIController.<>f__mg$cache31 == null)
		{
			Lua_BlackJack_ProjectL_UI_ArenaUIController.<>f__mg$cache31 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ArenaUIController.OnAddArenaTicketButtonClick);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_ArenaUIController.<>f__mg$cache31);
		if (Lua_BlackJack_ProjectL_UI_ArenaUIController.<>f__mg$cache32 == null)
		{
			Lua_BlackJack_ProjectL_UI_ArenaUIController.<>f__mg$cache32 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ArenaUIController.OnBuyArenaTicketBackgroundButtonClick);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_ArenaUIController.<>f__mg$cache32);
		if (Lua_BlackJack_ProjectL_UI_ArenaUIController.<>f__mg$cache33 == null)
		{
			Lua_BlackJack_ProjectL_UI_ArenaUIController.<>f__mg$cache33 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ArenaUIController.OnBuyArenaTicketBuyButtonClick);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_ArenaUIController.<>f__mg$cache33);
		if (Lua_BlackJack_ProjectL_UI_ArenaUIController.<>f__mg$cache34 == null)
		{
			Lua_BlackJack_ProjectL_UI_ArenaUIController.<>f__mg$cache34 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ArenaUIController.OnSwitchButtonClick);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_ArenaUIController.<>f__mg$cache34);
		if (Lua_BlackJack_ProjectL_UI_ArenaUIController.<>f__mg$cache35 == null)
		{
			Lua_BlackJack_ProjectL_UI_ArenaUIController.<>f__mg$cache35 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ArenaUIController.OfflineOnBindFiledsCompleted);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_ArenaUIController.<>f__mg$cache35);
		if (Lua_BlackJack_ProjectL_UI_ArenaUIController.<>f__mg$cache36 == null)
		{
			Lua_BlackJack_ProjectL_UI_ArenaUIController.<>f__mg$cache36 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ArenaUIController.ShowAutoBattleTips);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_ArenaUIController.<>f__mg$cache36);
		if (Lua_BlackJack_ProjectL_UI_ArenaUIController.<>f__mg$cache37 == null)
		{
			Lua_BlackJack_ProjectL_UI_ArenaUIController.<>f__mg$cache37 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ArenaUIController.HideAutoBattleTips);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_ArenaUIController.<>f__mg$cache37);
		if (Lua_BlackJack_ProjectL_UI_ArenaUIController.<>f__mg$cache38 == null)
		{
			Lua_BlackJack_ProjectL_UI_ArenaUIController.<>f__mg$cache38 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ArenaUIController.HideArenaOpponent);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_ArenaUIController.<>f__mg$cache38);
		if (Lua_BlackJack_ProjectL_UI_ArenaUIController.<>f__mg$cache39 == null)
		{
			Lua_BlackJack_ProjectL_UI_ArenaUIController.<>f__mg$cache39 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ArenaUIController.ClearOpponentGraphcs);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_ArenaUIController.<>f__mg$cache39);
		if (Lua_BlackJack_ProjectL_UI_ArenaUIController.<>f__mg$cache3A == null)
		{
			Lua_BlackJack_ProjectL_UI_ArenaUIController.<>f__mg$cache3A = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ArenaUIController.OnOfflineClashToggle);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_ArenaUIController.<>f__mg$cache3A);
		if (Lua_BlackJack_ProjectL_UI_ArenaUIController.<>f__mg$cache3B == null)
		{
			Lua_BlackJack_ProjectL_UI_ArenaUIController.<>f__mg$cache3B = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ArenaUIController.OnOfflineBattleReportToggle);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_ArenaUIController.<>f__mg$cache3B);
		if (Lua_BlackJack_ProjectL_UI_ArenaUIController.<>f__mg$cache3C == null)
		{
			Lua_BlackJack_ProjectL_UI_ArenaUIController.<>f__mg$cache3C = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ArenaUIController.OnOfflineRankingToggle);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_ArenaUIController.<>f__mg$cache3C);
		if (Lua_BlackJack_ProjectL_UI_ArenaUIController.<>f__mg$cache3D == null)
		{
			Lua_BlackJack_ProjectL_UI_ArenaUIController.<>f__mg$cache3D = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ArenaUIController.OnOfflineArenaPointRewardButtonClick);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_ArenaUIController.<>f__mg$cache3D);
		if (Lua_BlackJack_ProjectL_UI_ArenaUIController.<>f__mg$cache3E == null)
		{
			Lua_BlackJack_ProjectL_UI_ArenaUIController.<>f__mg$cache3E = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ArenaUIController.OnOfflineArenaPointRewardCloseButtonClick);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_ArenaUIController.<>f__mg$cache3E);
		if (Lua_BlackJack_ProjectL_UI_ArenaUIController.<>f__mg$cache3F == null)
		{
			Lua_BlackJack_ProjectL_UI_ArenaUIController.<>f__mg$cache3F = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ArenaUIController.OnOfflineVictoryPointsRewardButtonClick);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_ArenaUIController.<>f__mg$cache3F);
		if (Lua_BlackJack_ProjectL_UI_ArenaUIController.<>f__mg$cache40 == null)
		{
			Lua_BlackJack_ProjectL_UI_ArenaUIController.<>f__mg$cache40 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ArenaUIController.OnOfflineArenaOpponentAttackButtonClick);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_ArenaUIController.<>f__mg$cache40);
		if (Lua_BlackJack_ProjectL_UI_ArenaUIController.<>f__mg$cache41 == null)
		{
			Lua_BlackJack_ProjectL_UI_ArenaUIController.<>f__mg$cache41 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ArenaUIController.OnOfflineBattleReportRevengeButtonClick);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_ArenaUIController.<>f__mg$cache41);
		if (Lua_BlackJack_ProjectL_UI_ArenaUIController.<>f__mg$cache42 == null)
		{
			Lua_BlackJack_ProjectL_UI_ArenaUIController.<>f__mg$cache42 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ArenaUIController.OnOfflineBattleReportReplayButtonClick);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_ArenaUIController.<>f__mg$cache42);
		if (Lua_BlackJack_ProjectL_UI_ArenaUIController.<>f__mg$cache43 == null)
		{
			Lua_BlackJack_ProjectL_UI_ArenaUIController.<>f__mg$cache43 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ArenaUIController.OnDefendButtonClick);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_ArenaUIController.<>f__mg$cache43);
		if (Lua_BlackJack_ProjectL_UI_ArenaUIController.<>f__mg$cache44 == null)
		{
			Lua_BlackJack_ProjectL_UI_ArenaUIController.<>f__mg$cache44 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ArenaUIController.OnAttackConfirmButtonClick);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_ArenaUIController.<>f__mg$cache44);
		if (Lua_BlackJack_ProjectL_UI_ArenaUIController.<>f__mg$cache45 == null)
		{
			Lua_BlackJack_ProjectL_UI_ArenaUIController.<>f__mg$cache45 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ArenaUIController.OnAutoBattleButtonClick);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_ArenaUIController.<>f__mg$cache45);
		if (Lua_BlackJack_ProjectL_UI_ArenaUIController.<>f__mg$cache46 == null)
		{
			Lua_BlackJack_ProjectL_UI_ArenaUIController.<>f__mg$cache46 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ArenaUIController.OnAttackBackgroundButtonClick);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_ArenaUIController.<>f__mg$cache46);
		if (Lua_BlackJack_ProjectL_UI_ArenaUIController.<>f__mg$cache47 == null)
		{
			Lua_BlackJack_ProjectL_UI_ArenaUIController.<>f__mg$cache47 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ArenaUIController.OnAutoBattleTipsConfirmButtonClick);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_ArenaUIController.<>f__mg$cache47);
		if (Lua_BlackJack_ProjectL_UI_ArenaUIController.<>f__mg$cache48 == null)
		{
			Lua_BlackJack_ProjectL_UI_ArenaUIController.<>f__mg$cache48 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ArenaUIController.OnAutoBattleTipsCancelButtonClick);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_ArenaUIController.<>f__mg$cache48);
		if (Lua_BlackJack_ProjectL_UI_ArenaUIController.<>f__mg$cache49 == null)
		{
			Lua_BlackJack_ProjectL_UI_ArenaUIController.<>f__mg$cache49 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ArenaUIController.OnlineOnBindFiledsCompleted);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_ArenaUIController.<>f__mg$cache49);
		if (Lua_BlackJack_ProjectL_UI_ArenaUIController.<>f__mg$cache4A == null)
		{
			Lua_BlackJack_ProjectL_UI_ArenaUIController.<>f__mg$cache4A = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ArenaUIController.OnOnlineClashToggle);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_ArenaUIController.<>f__mg$cache4A);
		if (Lua_BlackJack_ProjectL_UI_ArenaUIController.<>f__mg$cache4B == null)
		{
			Lua_BlackJack_ProjectL_UI_ArenaUIController.<>f__mg$cache4B = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ArenaUIController.OnOnlineBattleReportToggle);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_ArenaUIController.<>f__mg$cache4B);
		if (Lua_BlackJack_ProjectL_UI_ArenaUIController.<>f__mg$cache4C == null)
		{
			Lua_BlackJack_ProjectL_UI_ArenaUIController.<>f__mg$cache4C = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ArenaUIController.OnOnlineDanToggle);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_ArenaUIController.<>f__mg$cache4C);
		if (Lua_BlackJack_ProjectL_UI_ArenaUIController.<>f__mg$cache4D == null)
		{
			Lua_BlackJack_ProjectL_UI_ArenaUIController.<>f__mg$cache4D = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ArenaUIController.OnOnlineLocalRankingToggle);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_ArenaUIController.<>f__mg$cache4D);
		if (Lua_BlackJack_ProjectL_UI_ArenaUIController.<>f__mg$cache4E == null)
		{
			Lua_BlackJack_ProjectL_UI_ArenaUIController.<>f__mg$cache4E = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ArenaUIController.OnOnlineGlobalRankingToggle);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_ArenaUIController.<>f__mg$cache4E);
		if (Lua_BlackJack_ProjectL_UI_ArenaUIController.<>f__mg$cache4F == null)
		{
			Lua_BlackJack_ProjectL_UI_ArenaUIController.<>f__mg$cache4F = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ArenaUIController.OnOnlineWeekWinRewardButtonClick);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_ArenaUIController.<>f__mg$cache4F);
		if (Lua_BlackJack_ProjectL_UI_ArenaUIController.<>f__mg$cache50 == null)
		{
			Lua_BlackJack_ProjectL_UI_ArenaUIController.<>f__mg$cache50 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ArenaUIController.OnOnlineBattleReportReplayButtonClick);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_ArenaUIController.<>f__mg$cache50);
		if (Lua_BlackJack_ProjectL_UI_ArenaUIController.<>f__mg$cache51 == null)
		{
			Lua_BlackJack_ProjectL_UI_ArenaUIController.<>f__mg$cache51 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ArenaUIController.OnOnlineClashLadderChallengeButtonClick);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_ArenaUIController.<>f__mg$cache51);
		if (Lua_BlackJack_ProjectL_UI_ArenaUIController.<>f__mg$cache52 == null)
		{
			Lua_BlackJack_ProjectL_UI_ArenaUIController.<>f__mg$cache52 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ArenaUIController.OnOnlineClashCasualChallengeButtonClick);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_ArenaUIController.<>f__mg$cache52);
		if (Lua_BlackJack_ProjectL_UI_ArenaUIController.<>f__mg$cache53 == null)
		{
			Lua_BlackJack_ProjectL_UI_ArenaUIController.<>f__mg$cache53 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ArenaUIController.OnMatchingFailedConfirmButtonClick);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_ArenaUIController.<>f__mg$cache53);
		if (Lua_BlackJack_ProjectL_UI_ArenaUIController.<>f__mg$cache54 == null)
		{
			Lua_BlackJack_ProjectL_UI_ArenaUIController.<>f__mg$cache54 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ArenaUIController.OnMatchingNowCancelButtonClick);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_ArenaUIController.<>f__mg$cache54);
		if (Lua_BlackJack_ProjectL_UI_ArenaUIController.<>f__mg$cache55 == null)
		{
			Lua_BlackJack_ProjectL_UI_ArenaUIController.<>f__mg$cache55 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ArenaUIController.OnOnlineArenaRankingRewardButtonClick);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_ArenaUIController.<>f__mg$cache55);
		if (Lua_BlackJack_ProjectL_UI_ArenaUIController.<>f__mg$cache56 == null)
		{
			Lua_BlackJack_ProjectL_UI_ArenaUIController.<>f__mg$cache56 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ArenaUIController.OnOnlineArenaRankingRewardCloseButtonClick);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_ArenaUIController.<>f__mg$cache56);
		if (Lua_BlackJack_ProjectL_UI_ArenaUIController.<>f__mg$cache57 == null)
		{
			Lua_BlackJack_ProjectL_UI_ArenaUIController.<>f__mg$cache57 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ArenaUIController.OnPromoteBattleConfirmButtonClick);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_ArenaUIController.<>f__mg$cache57);
		if (Lua_BlackJack_ProjectL_UI_ArenaUIController.<>f__mg$cache58 == null)
		{
			Lua_BlackJack_ProjectL_UI_ArenaUIController.<>f__mg$cache58 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ArenaUIController.OnPromoteSucceedConfirmButtonClick);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_ArenaUIController.<>f__mg$cache58);
		if (Lua_BlackJack_ProjectL_UI_ArenaUIController.<>f__mg$cache59 == null)
		{
			Lua_BlackJack_ProjectL_UI_ArenaUIController.<>f__mg$cache59 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ArenaUIController.__callBase_Initlize);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_ArenaUIController.<>f__mg$cache59);
		if (Lua_BlackJack_ProjectL_UI_ArenaUIController.<>f__mg$cache5A == null)
		{
			Lua_BlackJack_ProjectL_UI_ArenaUIController.<>f__mg$cache5A = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ArenaUIController.__callBase_BindFields);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_ArenaUIController.<>f__mg$cache5A);
		if (Lua_BlackJack_ProjectL_UI_ArenaUIController.<>f__mg$cache5B == null)
		{
			Lua_BlackJack_ProjectL_UI_ArenaUIController.<>f__mg$cache5B = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ArenaUIController.__callBase_OnBindFiledsCompleted);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_ArenaUIController.<>f__mg$cache5B);
		if (Lua_BlackJack_ProjectL_UI_ArenaUIController.<>f__mg$cache5C == null)
		{
			Lua_BlackJack_ProjectL_UI_ArenaUIController.<>f__mg$cache5C = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ArenaUIController.__callBase_BindFieldImpl);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_ArenaUIController.<>f__mg$cache5C);
		if (Lua_BlackJack_ProjectL_UI_ArenaUIController.<>f__mg$cache5D == null)
		{
			Lua_BlackJack_ProjectL_UI_ArenaUIController.<>f__mg$cache5D = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ArenaUIController.__callBase_Clear);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_ArenaUIController.<>f__mg$cache5D);
		if (Lua_BlackJack_ProjectL_UI_ArenaUIController.<>f__mg$cache5E == null)
		{
			Lua_BlackJack_ProjectL_UI_ArenaUIController.<>f__mg$cache5E = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ArenaUIController.__callBase_OnButtonClick);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_ArenaUIController.<>f__mg$cache5E);
		if (Lua_BlackJack_ProjectL_UI_ArenaUIController.<>f__mg$cache5F == null)
		{
			Lua_BlackJack_ProjectL_UI_ArenaUIController.<>f__mg$cache5F = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ArenaUIController.__callBase_SetButtonClickListener);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_ArenaUIController.<>f__mg$cache5F);
		if (Lua_BlackJack_ProjectL_UI_ArenaUIController.<>f__mg$cache60 == null)
		{
			Lua_BlackJack_ProjectL_UI_ArenaUIController.<>f__mg$cache60 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ArenaUIController.__callBase_SetButtonDoubleClickListener);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_ArenaUIController.<>f__mg$cache60);
		if (Lua_BlackJack_ProjectL_UI_ArenaUIController.<>f__mg$cache61 == null)
		{
			Lua_BlackJack_ProjectL_UI_ArenaUIController.<>f__mg$cache61 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ArenaUIController.__callBase_SetButtonLongPressStartListener);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_ArenaUIController.<>f__mg$cache61);
		if (Lua_BlackJack_ProjectL_UI_ArenaUIController.<>f__mg$cache62 == null)
		{
			Lua_BlackJack_ProjectL_UI_ArenaUIController.<>f__mg$cache62 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ArenaUIController.__callBase_SetButtonLongPressingListener);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_ArenaUIController.<>f__mg$cache62);
		if (Lua_BlackJack_ProjectL_UI_ArenaUIController.<>f__mg$cache63 == null)
		{
			Lua_BlackJack_ProjectL_UI_ArenaUIController.<>f__mg$cache63 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ArenaUIController.__callBase_SetButtonLongPressEndListener);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_ArenaUIController.<>f__mg$cache63);
		if (Lua_BlackJack_ProjectL_UI_ArenaUIController.<>f__mg$cache64 == null)
		{
			Lua_BlackJack_ProjectL_UI_ArenaUIController.<>f__mg$cache64 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ArenaUIController.__callBase_SetToggleValueChangedListener);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_ArenaUIController.<>f__mg$cache64);
		if (Lua_BlackJack_ProjectL_UI_ArenaUIController.<>f__mg$cache65 == null)
		{
			Lua_BlackJack_ProjectL_UI_ArenaUIController.<>f__mg$cache65 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ArenaUIController.__callBase_ToString);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_ArenaUIController.<>f__mg$cache65);
		if (Lua_BlackJack_ProjectL_UI_ArenaUIController.<>f__mg$cache66 == null)
		{
			Lua_BlackJack_ProjectL_UI_ArenaUIController.<>f__mg$cache66 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ArenaUIController.__callDele_EventOnDefend);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_ArenaUIController.<>f__mg$cache66);
		if (Lua_BlackJack_ProjectL_UI_ArenaUIController.<>f__mg$cache67 == null)
		{
			Lua_BlackJack_ProjectL_UI_ArenaUIController.<>f__mg$cache67 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ArenaUIController.__clearDele_EventOnDefend);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_ArenaUIController.<>f__mg$cache67);
		if (Lua_BlackJack_ProjectL_UI_ArenaUIController.<>f__mg$cache68 == null)
		{
			Lua_BlackJack_ProjectL_UI_ArenaUIController.<>f__mg$cache68 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ArenaUIController.__callDele_EventOnReturn);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_ArenaUIController.<>f__mg$cache68);
		if (Lua_BlackJack_ProjectL_UI_ArenaUIController.<>f__mg$cache69 == null)
		{
			Lua_BlackJack_ProjectL_UI_ArenaUIController.<>f__mg$cache69 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ArenaUIController.__clearDele_EventOnReturn);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_ArenaUIController.<>f__mg$cache69);
		if (Lua_BlackJack_ProjectL_UI_ArenaUIController.<>f__mg$cache6A == null)
		{
			Lua_BlackJack_ProjectL_UI_ArenaUIController.<>f__mg$cache6A = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ArenaUIController.__callDele_EventOnShowHelp);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_ArenaUIController.<>f__mg$cache6A);
		if (Lua_BlackJack_ProjectL_UI_ArenaUIController.<>f__mg$cache6B == null)
		{
			Lua_BlackJack_ProjectL_UI_ArenaUIController.<>f__mg$cache6B = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ArenaUIController.__clearDele_EventOnShowHelp);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_ArenaUIController.<>f__mg$cache6B);
		if (Lua_BlackJack_ProjectL_UI_ArenaUIController.<>f__mg$cache6C == null)
		{
			Lua_BlackJack_ProjectL_UI_ArenaUIController.<>f__mg$cache6C = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ArenaUIController.__callDele_EventOnShowBuyArenaTicket);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_ArenaUIController.<>f__mg$cache6C);
		if (Lua_BlackJack_ProjectL_UI_ArenaUIController.<>f__mg$cache6D == null)
		{
			Lua_BlackJack_ProjectL_UI_ArenaUIController.<>f__mg$cache6D = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ArenaUIController.__clearDele_EventOnShowBuyArenaTicket);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_ArenaUIController.<>f__mg$cache6D);
		if (Lua_BlackJack_ProjectL_UI_ArenaUIController.<>f__mg$cache6E == null)
		{
			Lua_BlackJack_ProjectL_UI_ArenaUIController.<>f__mg$cache6E = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ArenaUIController.__callDele_EventOnBuyArenaTicket);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_ArenaUIController.<>f__mg$cache6E);
		if (Lua_BlackJack_ProjectL_UI_ArenaUIController.<>f__mg$cache6F == null)
		{
			Lua_BlackJack_ProjectL_UI_ArenaUIController.<>f__mg$cache6F = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ArenaUIController.__clearDele_EventOnBuyArenaTicket);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_ArenaUIController.<>f__mg$cache6F);
		if (Lua_BlackJack_ProjectL_UI_ArenaUIController.<>f__mg$cache70 == null)
		{
			Lua_BlackJack_ProjectL_UI_ArenaUIController.<>f__mg$cache70 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ArenaUIController.__callDele_EventOnSwitchOnlineOffline);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_ArenaUIController.<>f__mg$cache70);
		if (Lua_BlackJack_ProjectL_UI_ArenaUIController.<>f__mg$cache71 == null)
		{
			Lua_BlackJack_ProjectL_UI_ArenaUIController.<>f__mg$cache71 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ArenaUIController.__clearDele_EventOnSwitchOnlineOffline);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_ArenaUIController.<>f__mg$cache71);
		if (Lua_BlackJack_ProjectL_UI_ArenaUIController.<>f__mg$cache72 == null)
		{
			Lua_BlackJack_ProjectL_UI_ArenaUIController.<>f__mg$cache72 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ArenaUIController.__callDele_EventOnShowOfflinePanel);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_ArenaUIController.<>f__mg$cache72);
		if (Lua_BlackJack_ProjectL_UI_ArenaUIController.<>f__mg$cache73 == null)
		{
			Lua_BlackJack_ProjectL_UI_ArenaUIController.<>f__mg$cache73 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ArenaUIController.__clearDele_EventOnShowOfflinePanel);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_ArenaUIController.<>f__mg$cache73);
		if (Lua_BlackJack_ProjectL_UI_ArenaUIController.<>f__mg$cache74 == null)
		{
			Lua_BlackJack_ProjectL_UI_ArenaUIController.<>f__mg$cache74 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ArenaUIController.__callDele_EventOnGainOfflineVictoryPointsReward);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_ArenaUIController.<>f__mg$cache74);
		if (Lua_BlackJack_ProjectL_UI_ArenaUIController.<>f__mg$cache75 == null)
		{
			Lua_BlackJack_ProjectL_UI_ArenaUIController.<>f__mg$cache75 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ArenaUIController.__clearDele_EventOnGainOfflineVictoryPointsReward);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_ArenaUIController.<>f__mg$cache75);
		if (Lua_BlackJack_ProjectL_UI_ArenaUIController.<>f__mg$cache76 == null)
		{
			Lua_BlackJack_ProjectL_UI_ArenaUIController.<>f__mg$cache76 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ArenaUIController.__callDele_EventOnShowOfflineArenaOpponent);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_ArenaUIController.<>f__mg$cache76);
		if (Lua_BlackJack_ProjectL_UI_ArenaUIController.<>f__mg$cache77 == null)
		{
			Lua_BlackJack_ProjectL_UI_ArenaUIController.<>f__mg$cache77 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ArenaUIController.__clearDele_EventOnShowOfflineArenaOpponent);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_ArenaUIController.<>f__mg$cache77);
		if (Lua_BlackJack_ProjectL_UI_ArenaUIController.<>f__mg$cache78 == null)
		{
			Lua_BlackJack_ProjectL_UI_ArenaUIController.<>f__mg$cache78 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ArenaUIController.__callDele_EventOnAttackOfflineArenaOpponent);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_ArenaUIController.<>f__mg$cache78);
		if (Lua_BlackJack_ProjectL_UI_ArenaUIController.<>f__mg$cache79 == null)
		{
			Lua_BlackJack_ProjectL_UI_ArenaUIController.<>f__mg$cache79 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ArenaUIController.__clearDele_EventOnAttackOfflineArenaOpponent);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_ArenaUIController.<>f__mg$cache79);
		if (Lua_BlackJack_ProjectL_UI_ArenaUIController.<>f__mg$cache7A == null)
		{
			Lua_BlackJack_ProjectL_UI_ArenaUIController.<>f__mg$cache7A = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ArenaUIController.__callDele_EventOnShowRevengeOfflineArenaOpponent);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_ArenaUIController.<>f__mg$cache7A);
		if (Lua_BlackJack_ProjectL_UI_ArenaUIController.<>f__mg$cache7B == null)
		{
			Lua_BlackJack_ProjectL_UI_ArenaUIController.<>f__mg$cache7B = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ArenaUIController.__clearDele_EventOnShowRevengeOfflineArenaOpponent);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_ArenaUIController.<>f__mg$cache7B);
		if (Lua_BlackJack_ProjectL_UI_ArenaUIController.<>f__mg$cache7C == null)
		{
			Lua_BlackJack_ProjectL_UI_ArenaUIController.<>f__mg$cache7C = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ArenaUIController.__callDele_EventOnRevengeOfflineArenaOpponent);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_ArenaUIController.<>f__mg$cache7C);
		if (Lua_BlackJack_ProjectL_UI_ArenaUIController.<>f__mg$cache7D == null)
		{
			Lua_BlackJack_ProjectL_UI_ArenaUIController.<>f__mg$cache7D = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ArenaUIController.__clearDele_EventOnRevengeOfflineArenaOpponent);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_ArenaUIController.<>f__mg$cache7D);
		if (Lua_BlackJack_ProjectL_UI_ArenaUIController.<>f__mg$cache7E == null)
		{
			Lua_BlackJack_ProjectL_UI_ArenaUIController.<>f__mg$cache7E = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ArenaUIController.__callDele_EventOnOfflineBattleReportReplay);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_ArenaUIController.<>f__mg$cache7E);
		if (Lua_BlackJack_ProjectL_UI_ArenaUIController.<>f__mg$cache7F == null)
		{
			Lua_BlackJack_ProjectL_UI_ArenaUIController.<>f__mg$cache7F = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ArenaUIController.__clearDele_EventOnOfflineBattleReportReplay);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_ArenaUIController.<>f__mg$cache7F);
		if (Lua_BlackJack_ProjectL_UI_ArenaUIController.<>f__mg$cache80 == null)
		{
			Lua_BlackJack_ProjectL_UI_ArenaUIController.<>f__mg$cache80 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ArenaUIController.__callDele_EventOnShowOnlinePanel);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_ArenaUIController.<>f__mg$cache80);
		if (Lua_BlackJack_ProjectL_UI_ArenaUIController.<>f__mg$cache81 == null)
		{
			Lua_BlackJack_ProjectL_UI_ArenaUIController.<>f__mg$cache81 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ArenaUIController.__clearDele_EventOnShowOnlinePanel);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_ArenaUIController.<>f__mg$cache81);
		if (Lua_BlackJack_ProjectL_UI_ArenaUIController.<>f__mg$cache82 == null)
		{
			Lua_BlackJack_ProjectL_UI_ArenaUIController.<>f__mg$cache82 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ArenaUIController.__callDele_EventOnGainOnlineWeekWinReward);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_ArenaUIController.<>f__mg$cache82);
		if (Lua_BlackJack_ProjectL_UI_ArenaUIController.<>f__mg$cache83 == null)
		{
			Lua_BlackJack_ProjectL_UI_ArenaUIController.<>f__mg$cache83 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ArenaUIController.__clearDele_EventOnGainOnlineWeekWinReward);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_ArenaUIController.<>f__mg$cache83);
		if (Lua_BlackJack_ProjectL_UI_ArenaUIController.<>f__mg$cache84 == null)
		{
			Lua_BlackJack_ProjectL_UI_ArenaUIController.<>f__mg$cache84 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ArenaUIController.__callDele_EventOnOnlineBattleReportReplay);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_ArenaUIController.<>f__mg$cache84);
		if (Lua_BlackJack_ProjectL_UI_ArenaUIController.<>f__mg$cache85 == null)
		{
			Lua_BlackJack_ProjectL_UI_ArenaUIController.<>f__mg$cache85 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ArenaUIController.__clearDele_EventOnOnlineBattleReportReplay);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_ArenaUIController.<>f__mg$cache85);
		if (Lua_BlackJack_ProjectL_UI_ArenaUIController.<>f__mg$cache86 == null)
		{
			Lua_BlackJack_ProjectL_UI_ArenaUIController.<>f__mg$cache86 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ArenaUIController.__callDele_EventOnLadderChallenge);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_ArenaUIController.<>f__mg$cache86);
		if (Lua_BlackJack_ProjectL_UI_ArenaUIController.<>f__mg$cache87 == null)
		{
			Lua_BlackJack_ProjectL_UI_ArenaUIController.<>f__mg$cache87 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ArenaUIController.__clearDele_EventOnLadderChallenge);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_ArenaUIController.<>f__mg$cache87);
		if (Lua_BlackJack_ProjectL_UI_ArenaUIController.<>f__mg$cache88 == null)
		{
			Lua_BlackJack_ProjectL_UI_ArenaUIController.<>f__mg$cache88 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ArenaUIController.__callDele_EventOnCasualChallenge);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_ArenaUIController.<>f__mg$cache88);
		if (Lua_BlackJack_ProjectL_UI_ArenaUIController.<>f__mg$cache89 == null)
		{
			Lua_BlackJack_ProjectL_UI_ArenaUIController.<>f__mg$cache89 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ArenaUIController.__clearDele_EventOnCasualChallenge);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_ArenaUIController.<>f__mg$cache89);
		if (Lua_BlackJack_ProjectL_UI_ArenaUIController.<>f__mg$cache8A == null)
		{
			Lua_BlackJack_ProjectL_UI_ArenaUIController.<>f__mg$cache8A = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ArenaUIController.__callDele_EventOnMatchingCancel);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_ArenaUIController.<>f__mg$cache8A);
		if (Lua_BlackJack_ProjectL_UI_ArenaUIController.<>f__mg$cache8B == null)
		{
			Lua_BlackJack_ProjectL_UI_ArenaUIController.<>f__mg$cache8B = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ArenaUIController.__clearDele_EventOnMatchingCancel);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_ArenaUIController.<>f__mg$cache8B);
		string name = "EventOnDefend";
		LuaCSFunction get = null;
		if (Lua_BlackJack_ProjectL_UI_ArenaUIController.<>f__mg$cache8C == null)
		{
			Lua_BlackJack_ProjectL_UI_ArenaUIController.<>f__mg$cache8C = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ArenaUIController.set_EventOnDefend);
		}
		LuaObject.addMember(l, name, get, Lua_BlackJack_ProjectL_UI_ArenaUIController.<>f__mg$cache8C, true);
		string name2 = "EventOnReturn";
		LuaCSFunction get2 = null;
		if (Lua_BlackJack_ProjectL_UI_ArenaUIController.<>f__mg$cache8D == null)
		{
			Lua_BlackJack_ProjectL_UI_ArenaUIController.<>f__mg$cache8D = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ArenaUIController.set_EventOnReturn);
		}
		LuaObject.addMember(l, name2, get2, Lua_BlackJack_ProjectL_UI_ArenaUIController.<>f__mg$cache8D, true);
		string name3 = "EventOnShowHelp";
		LuaCSFunction get3 = null;
		if (Lua_BlackJack_ProjectL_UI_ArenaUIController.<>f__mg$cache8E == null)
		{
			Lua_BlackJack_ProjectL_UI_ArenaUIController.<>f__mg$cache8E = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ArenaUIController.set_EventOnShowHelp);
		}
		LuaObject.addMember(l, name3, get3, Lua_BlackJack_ProjectL_UI_ArenaUIController.<>f__mg$cache8E, true);
		string name4 = "EventOnShowBuyArenaTicket";
		LuaCSFunction get4 = null;
		if (Lua_BlackJack_ProjectL_UI_ArenaUIController.<>f__mg$cache8F == null)
		{
			Lua_BlackJack_ProjectL_UI_ArenaUIController.<>f__mg$cache8F = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ArenaUIController.set_EventOnShowBuyArenaTicket);
		}
		LuaObject.addMember(l, name4, get4, Lua_BlackJack_ProjectL_UI_ArenaUIController.<>f__mg$cache8F, true);
		string name5 = "EventOnBuyArenaTicket";
		LuaCSFunction get5 = null;
		if (Lua_BlackJack_ProjectL_UI_ArenaUIController.<>f__mg$cache90 == null)
		{
			Lua_BlackJack_ProjectL_UI_ArenaUIController.<>f__mg$cache90 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ArenaUIController.set_EventOnBuyArenaTicket);
		}
		LuaObject.addMember(l, name5, get5, Lua_BlackJack_ProjectL_UI_ArenaUIController.<>f__mg$cache90, true);
		string name6 = "EventOnSwitchOnlineOffline";
		LuaCSFunction get6 = null;
		if (Lua_BlackJack_ProjectL_UI_ArenaUIController.<>f__mg$cache91 == null)
		{
			Lua_BlackJack_ProjectL_UI_ArenaUIController.<>f__mg$cache91 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ArenaUIController.set_EventOnSwitchOnlineOffline);
		}
		LuaObject.addMember(l, name6, get6, Lua_BlackJack_ProjectL_UI_ArenaUIController.<>f__mg$cache91, true);
		string name7 = "m_uiStateController";
		if (Lua_BlackJack_ProjectL_UI_ArenaUIController.<>f__mg$cache92 == null)
		{
			Lua_BlackJack_ProjectL_UI_ArenaUIController.<>f__mg$cache92 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ArenaUIController.get_m_uiStateController);
		}
		LuaCSFunction get7 = Lua_BlackJack_ProjectL_UI_ArenaUIController.<>f__mg$cache92;
		if (Lua_BlackJack_ProjectL_UI_ArenaUIController.<>f__mg$cache93 == null)
		{
			Lua_BlackJack_ProjectL_UI_ArenaUIController.<>f__mg$cache93 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ArenaUIController.set_m_uiStateController);
		}
		LuaObject.addMember(l, name7, get7, Lua_BlackJack_ProjectL_UI_ArenaUIController.<>f__mg$cache93, true);
		string name8 = "m_returnButton";
		if (Lua_BlackJack_ProjectL_UI_ArenaUIController.<>f__mg$cache94 == null)
		{
			Lua_BlackJack_ProjectL_UI_ArenaUIController.<>f__mg$cache94 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ArenaUIController.get_m_returnButton);
		}
		LuaCSFunction get8 = Lua_BlackJack_ProjectL_UI_ArenaUIController.<>f__mg$cache94;
		if (Lua_BlackJack_ProjectL_UI_ArenaUIController.<>f__mg$cache95 == null)
		{
			Lua_BlackJack_ProjectL_UI_ArenaUIController.<>f__mg$cache95 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ArenaUIController.set_m_returnButton);
		}
		LuaObject.addMember(l, name8, get8, Lua_BlackJack_ProjectL_UI_ArenaUIController.<>f__mg$cache95, true);
		string name9 = "m_helpButton";
		if (Lua_BlackJack_ProjectL_UI_ArenaUIController.<>f__mg$cache96 == null)
		{
			Lua_BlackJack_ProjectL_UI_ArenaUIController.<>f__mg$cache96 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ArenaUIController.get_m_helpButton);
		}
		LuaCSFunction get9 = Lua_BlackJack_ProjectL_UI_ArenaUIController.<>f__mg$cache96;
		if (Lua_BlackJack_ProjectL_UI_ArenaUIController.<>f__mg$cache97 == null)
		{
			Lua_BlackJack_ProjectL_UI_ArenaUIController.<>f__mg$cache97 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ArenaUIController.set_m_helpButton);
		}
		LuaObject.addMember(l, name9, get9, Lua_BlackJack_ProjectL_UI_ArenaUIController.<>f__mg$cache97, true);
		string name10 = "m_offlineArenaCoinText";
		if (Lua_BlackJack_ProjectL_UI_ArenaUIController.<>f__mg$cache98 == null)
		{
			Lua_BlackJack_ProjectL_UI_ArenaUIController.<>f__mg$cache98 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ArenaUIController.get_m_offlineArenaCoinText);
		}
		LuaCSFunction get10 = Lua_BlackJack_ProjectL_UI_ArenaUIController.<>f__mg$cache98;
		if (Lua_BlackJack_ProjectL_UI_ArenaUIController.<>f__mg$cache99 == null)
		{
			Lua_BlackJack_ProjectL_UI_ArenaUIController.<>f__mg$cache99 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ArenaUIController.set_m_offlineArenaCoinText);
		}
		LuaObject.addMember(l, name10, get10, Lua_BlackJack_ProjectL_UI_ArenaUIController.<>f__mg$cache99, true);
		string name11 = "m_onlineArenaCoinText";
		if (Lua_BlackJack_ProjectL_UI_ArenaUIController.<>f__mg$cache9A == null)
		{
			Lua_BlackJack_ProjectL_UI_ArenaUIController.<>f__mg$cache9A = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ArenaUIController.get_m_onlineArenaCoinText);
		}
		LuaCSFunction get11 = Lua_BlackJack_ProjectL_UI_ArenaUIController.<>f__mg$cache9A;
		if (Lua_BlackJack_ProjectL_UI_ArenaUIController.<>f__mg$cache9B == null)
		{
			Lua_BlackJack_ProjectL_UI_ArenaUIController.<>f__mg$cache9B = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ArenaUIController.set_m_onlineArenaCoinText);
		}
		LuaObject.addMember(l, name11, get11, Lua_BlackJack_ProjectL_UI_ArenaUIController.<>f__mg$cache9B, true);
		string name12 = "m_arenaTicketButton";
		if (Lua_BlackJack_ProjectL_UI_ArenaUIController.<>f__mg$cache9C == null)
		{
			Lua_BlackJack_ProjectL_UI_ArenaUIController.<>f__mg$cache9C = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ArenaUIController.get_m_arenaTicketButton);
		}
		LuaCSFunction get12 = Lua_BlackJack_ProjectL_UI_ArenaUIController.<>f__mg$cache9C;
		if (Lua_BlackJack_ProjectL_UI_ArenaUIController.<>f__mg$cache9D == null)
		{
			Lua_BlackJack_ProjectL_UI_ArenaUIController.<>f__mg$cache9D = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ArenaUIController.set_m_arenaTicketButton);
		}
		LuaObject.addMember(l, name12, get12, Lua_BlackJack_ProjectL_UI_ArenaUIController.<>f__mg$cache9D, true);
		string name13 = "m_arenaTicketText";
		if (Lua_BlackJack_ProjectL_UI_ArenaUIController.<>f__mg$cache9E == null)
		{
			Lua_BlackJack_ProjectL_UI_ArenaUIController.<>f__mg$cache9E = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ArenaUIController.get_m_arenaTicketText);
		}
		LuaCSFunction get13 = Lua_BlackJack_ProjectL_UI_ArenaUIController.<>f__mg$cache9E;
		if (Lua_BlackJack_ProjectL_UI_ArenaUIController.<>f__mg$cache9F == null)
		{
			Lua_BlackJack_ProjectL_UI_ArenaUIController.<>f__mg$cache9F = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ArenaUIController.set_m_arenaTicketText);
		}
		LuaObject.addMember(l, name13, get13, Lua_BlackJack_ProjectL_UI_ArenaUIController.<>f__mg$cache9F, true);
		string name14 = "m_addArenaTicketButton";
		if (Lua_BlackJack_ProjectL_UI_ArenaUIController.<>f__mg$cacheA0 == null)
		{
			Lua_BlackJack_ProjectL_UI_ArenaUIController.<>f__mg$cacheA0 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ArenaUIController.get_m_addArenaTicketButton);
		}
		LuaCSFunction get14 = Lua_BlackJack_ProjectL_UI_ArenaUIController.<>f__mg$cacheA0;
		if (Lua_BlackJack_ProjectL_UI_ArenaUIController.<>f__mg$cacheA1 == null)
		{
			Lua_BlackJack_ProjectL_UI_ArenaUIController.<>f__mg$cacheA1 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ArenaUIController.set_m_addArenaTicketButton);
		}
		LuaObject.addMember(l, name14, get14, Lua_BlackJack_ProjectL_UI_ArenaUIController.<>f__mg$cacheA1, true);
		string name15 = "m_switchUIStateController";
		if (Lua_BlackJack_ProjectL_UI_ArenaUIController.<>f__mg$cacheA2 == null)
		{
			Lua_BlackJack_ProjectL_UI_ArenaUIController.<>f__mg$cacheA2 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ArenaUIController.get_m_switchUIStateController);
		}
		LuaCSFunction get15 = Lua_BlackJack_ProjectL_UI_ArenaUIController.<>f__mg$cacheA2;
		if (Lua_BlackJack_ProjectL_UI_ArenaUIController.<>f__mg$cacheA3 == null)
		{
			Lua_BlackJack_ProjectL_UI_ArenaUIController.<>f__mg$cacheA3 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ArenaUIController.set_m_switchUIStateController);
		}
		LuaObject.addMember(l, name15, get15, Lua_BlackJack_ProjectL_UI_ArenaUIController.<>f__mg$cacheA3, true);
		string name16 = "m_switchButton";
		if (Lua_BlackJack_ProjectL_UI_ArenaUIController.<>f__mg$cacheA4 == null)
		{
			Lua_BlackJack_ProjectL_UI_ArenaUIController.<>f__mg$cacheA4 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ArenaUIController.get_m_switchButton);
		}
		LuaCSFunction get16 = Lua_BlackJack_ProjectL_UI_ArenaUIController.<>f__mg$cacheA4;
		if (Lua_BlackJack_ProjectL_UI_ArenaUIController.<>f__mg$cacheA5 == null)
		{
			Lua_BlackJack_ProjectL_UI_ArenaUIController.<>f__mg$cacheA5 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ArenaUIController.set_m_switchButton);
		}
		LuaObject.addMember(l, name16, get16, Lua_BlackJack_ProjectL_UI_ArenaUIController.<>f__mg$cacheA5, true);
		string name17 = "m_switchButtonUIStateController";
		if (Lua_BlackJack_ProjectL_UI_ArenaUIController.<>f__mg$cacheA6 == null)
		{
			Lua_BlackJack_ProjectL_UI_ArenaUIController.<>f__mg$cacheA6 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ArenaUIController.get_m_switchButtonUIStateController);
		}
		LuaCSFunction get17 = Lua_BlackJack_ProjectL_UI_ArenaUIController.<>f__mg$cacheA6;
		if (Lua_BlackJack_ProjectL_UI_ArenaUIController.<>f__mg$cacheA7 == null)
		{
			Lua_BlackJack_ProjectL_UI_ArenaUIController.<>f__mg$cacheA7 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ArenaUIController.set_m_switchButtonUIStateController);
		}
		LuaObject.addMember(l, name17, get17, Lua_BlackJack_ProjectL_UI_ArenaUIController.<>f__mg$cacheA7, true);
		string name18 = "m_offlineOnlineChangeUIStateController";
		if (Lua_BlackJack_ProjectL_UI_ArenaUIController.<>f__mg$cacheA8 == null)
		{
			Lua_BlackJack_ProjectL_UI_ArenaUIController.<>f__mg$cacheA8 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ArenaUIController.get_m_offlineOnlineChangeUIStateController);
		}
		LuaCSFunction get18 = Lua_BlackJack_ProjectL_UI_ArenaUIController.<>f__mg$cacheA8;
		if (Lua_BlackJack_ProjectL_UI_ArenaUIController.<>f__mg$cacheA9 == null)
		{
			Lua_BlackJack_ProjectL_UI_ArenaUIController.<>f__mg$cacheA9 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ArenaUIController.set_m_offlineOnlineChangeUIStateController);
		}
		LuaObject.addMember(l, name18, get18, Lua_BlackJack_ProjectL_UI_ArenaUIController.<>f__mg$cacheA9, true);
		string name19 = "m_autoBattleTipsUIStateController";
		if (Lua_BlackJack_ProjectL_UI_ArenaUIController.<>f__mg$cacheAA == null)
		{
			Lua_BlackJack_ProjectL_UI_ArenaUIController.<>f__mg$cacheAA = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ArenaUIController.get_m_autoBattleTipsUIStateController);
		}
		LuaCSFunction get19 = Lua_BlackJack_ProjectL_UI_ArenaUIController.<>f__mg$cacheAA;
		if (Lua_BlackJack_ProjectL_UI_ArenaUIController.<>f__mg$cacheAB == null)
		{
			Lua_BlackJack_ProjectL_UI_ArenaUIController.<>f__mg$cacheAB = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ArenaUIController.set_m_autoBattleTipsUIStateController);
		}
		LuaObject.addMember(l, name19, get19, Lua_BlackJack_ProjectL_UI_ArenaUIController.<>f__mg$cacheAB, true);
		string name20 = "m_autoBattleTipsBackgroundButton";
		if (Lua_BlackJack_ProjectL_UI_ArenaUIController.<>f__mg$cacheAC == null)
		{
			Lua_BlackJack_ProjectL_UI_ArenaUIController.<>f__mg$cacheAC = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ArenaUIController.get_m_autoBattleTipsBackgroundButton);
		}
		LuaCSFunction get20 = Lua_BlackJack_ProjectL_UI_ArenaUIController.<>f__mg$cacheAC;
		if (Lua_BlackJack_ProjectL_UI_ArenaUIController.<>f__mg$cacheAD == null)
		{
			Lua_BlackJack_ProjectL_UI_ArenaUIController.<>f__mg$cacheAD = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ArenaUIController.set_m_autoBattleTipsBackgroundButton);
		}
		LuaObject.addMember(l, name20, get20, Lua_BlackJack_ProjectL_UI_ArenaUIController.<>f__mg$cacheAD, true);
		string name21 = "m_autoBattleTipsShowToggle";
		if (Lua_BlackJack_ProjectL_UI_ArenaUIController.<>f__mg$cacheAE == null)
		{
			Lua_BlackJack_ProjectL_UI_ArenaUIController.<>f__mg$cacheAE = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ArenaUIController.get_m_autoBattleTipsShowToggle);
		}
		LuaCSFunction get21 = Lua_BlackJack_ProjectL_UI_ArenaUIController.<>f__mg$cacheAE;
		if (Lua_BlackJack_ProjectL_UI_ArenaUIController.<>f__mg$cacheAF == null)
		{
			Lua_BlackJack_ProjectL_UI_ArenaUIController.<>f__mg$cacheAF = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ArenaUIController.set_m_autoBattleTipsShowToggle);
		}
		LuaObject.addMember(l, name21, get21, Lua_BlackJack_ProjectL_UI_ArenaUIController.<>f__mg$cacheAF, true);
		string name22 = "m_autoBattleTipsConfirmButton";
		if (Lua_BlackJack_ProjectL_UI_ArenaUIController.<>f__mg$cacheB0 == null)
		{
			Lua_BlackJack_ProjectL_UI_ArenaUIController.<>f__mg$cacheB0 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ArenaUIController.get_m_autoBattleTipsConfirmButton);
		}
		LuaCSFunction get22 = Lua_BlackJack_ProjectL_UI_ArenaUIController.<>f__mg$cacheB0;
		if (Lua_BlackJack_ProjectL_UI_ArenaUIController.<>f__mg$cacheB1 == null)
		{
			Lua_BlackJack_ProjectL_UI_ArenaUIController.<>f__mg$cacheB1 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ArenaUIController.set_m_autoBattleTipsConfirmButton);
		}
		LuaObject.addMember(l, name22, get22, Lua_BlackJack_ProjectL_UI_ArenaUIController.<>f__mg$cacheB1, true);
		string name23 = "m_autoBattleTipsCancelButton";
		if (Lua_BlackJack_ProjectL_UI_ArenaUIController.<>f__mg$cacheB2 == null)
		{
			Lua_BlackJack_ProjectL_UI_ArenaUIController.<>f__mg$cacheB2 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ArenaUIController.get_m_autoBattleTipsCancelButton);
		}
		LuaCSFunction get23 = Lua_BlackJack_ProjectL_UI_ArenaUIController.<>f__mg$cacheB2;
		if (Lua_BlackJack_ProjectL_UI_ArenaUIController.<>f__mg$cacheB3 == null)
		{
			Lua_BlackJack_ProjectL_UI_ArenaUIController.<>f__mg$cacheB3 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ArenaUIController.set_m_autoBattleTipsCancelButton);
		}
		LuaObject.addMember(l, name23, get23, Lua_BlackJack_ProjectL_UI_ArenaUIController.<>f__mg$cacheB3, true);
		string name24 = "m_rewardPreviewUIStateController";
		if (Lua_BlackJack_ProjectL_UI_ArenaUIController.<>f__mg$cacheB4 == null)
		{
			Lua_BlackJack_ProjectL_UI_ArenaUIController.<>f__mg$cacheB4 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ArenaUIController.get_m_rewardPreviewUIStateController);
		}
		LuaCSFunction get24 = Lua_BlackJack_ProjectL_UI_ArenaUIController.<>f__mg$cacheB4;
		if (Lua_BlackJack_ProjectL_UI_ArenaUIController.<>f__mg$cacheB5 == null)
		{
			Lua_BlackJack_ProjectL_UI_ArenaUIController.<>f__mg$cacheB5 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ArenaUIController.set_m_rewardPreviewUIStateController);
		}
		LuaObject.addMember(l, name24, get24, Lua_BlackJack_ProjectL_UI_ArenaUIController.<>f__mg$cacheB5, true);
		string name25 = "m_rewardPreviewBackgroundButton";
		if (Lua_BlackJack_ProjectL_UI_ArenaUIController.<>f__mg$cacheB6 == null)
		{
			Lua_BlackJack_ProjectL_UI_ArenaUIController.<>f__mg$cacheB6 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ArenaUIController.get_m_rewardPreviewBackgroundButton);
		}
		LuaCSFunction get25 = Lua_BlackJack_ProjectL_UI_ArenaUIController.<>f__mg$cacheB6;
		if (Lua_BlackJack_ProjectL_UI_ArenaUIController.<>f__mg$cacheB7 == null)
		{
			Lua_BlackJack_ProjectL_UI_ArenaUIController.<>f__mg$cacheB7 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ArenaUIController.set_m_rewardPreviewBackgroundButton);
		}
		LuaObject.addMember(l, name25, get25, Lua_BlackJack_ProjectL_UI_ArenaUIController.<>f__mg$cacheB7, true);
		string name26 = "m_rewardPreviewScrollRect";
		if (Lua_BlackJack_ProjectL_UI_ArenaUIController.<>f__mg$cacheB8 == null)
		{
			Lua_BlackJack_ProjectL_UI_ArenaUIController.<>f__mg$cacheB8 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ArenaUIController.get_m_rewardPreviewScrollRect);
		}
		LuaCSFunction get26 = Lua_BlackJack_ProjectL_UI_ArenaUIController.<>f__mg$cacheB8;
		if (Lua_BlackJack_ProjectL_UI_ArenaUIController.<>f__mg$cacheB9 == null)
		{
			Lua_BlackJack_ProjectL_UI_ArenaUIController.<>f__mg$cacheB9 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ArenaUIController.set_m_rewardPreviewScrollRect);
		}
		LuaObject.addMember(l, name26, get26, Lua_BlackJack_ProjectL_UI_ArenaUIController.<>f__mg$cacheB9, true);
		string name27 = "m_arenaTicketDescGameObject";
		if (Lua_BlackJack_ProjectL_UI_ArenaUIController.<>f__mg$cacheBA == null)
		{
			Lua_BlackJack_ProjectL_UI_ArenaUIController.<>f__mg$cacheBA = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ArenaUIController.get_m_arenaTicketDescGameObject);
		}
		LuaCSFunction get27 = Lua_BlackJack_ProjectL_UI_ArenaUIController.<>f__mg$cacheBA;
		if (Lua_BlackJack_ProjectL_UI_ArenaUIController.<>f__mg$cacheBB == null)
		{
			Lua_BlackJack_ProjectL_UI_ArenaUIController.<>f__mg$cacheBB = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ArenaUIController.set_m_arenaTicketDescGameObject);
		}
		LuaObject.addMember(l, name27, get27, Lua_BlackJack_ProjectL_UI_ArenaUIController.<>f__mg$cacheBB, true);
		string name28 = "m_arenaTicketDescUIStateCtrl";
		if (Lua_BlackJack_ProjectL_UI_ArenaUIController.<>f__mg$cacheBC == null)
		{
			Lua_BlackJack_ProjectL_UI_ArenaUIController.<>f__mg$cacheBC = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ArenaUIController.get_m_arenaTicketDescUIStateCtrl);
		}
		LuaCSFunction get28 = Lua_BlackJack_ProjectL_UI_ArenaUIController.<>f__mg$cacheBC;
		if (Lua_BlackJack_ProjectL_UI_ArenaUIController.<>f__mg$cacheBD == null)
		{
			Lua_BlackJack_ProjectL_UI_ArenaUIController.<>f__mg$cacheBD = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ArenaUIController.set_m_arenaTicketDescUIStateCtrl);
		}
		LuaObject.addMember(l, name28, get28, Lua_BlackJack_ProjectL_UI_ArenaUIController.<>f__mg$cacheBD, true);
		string name29 = "m_arenaTicketDescBackgroundButton";
		if (Lua_BlackJack_ProjectL_UI_ArenaUIController.<>f__mg$cacheBE == null)
		{
			Lua_BlackJack_ProjectL_UI_ArenaUIController.<>f__mg$cacheBE = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ArenaUIController.get_m_arenaTicketDescBackgroundButton);
		}
		LuaCSFunction get29 = Lua_BlackJack_ProjectL_UI_ArenaUIController.<>f__mg$cacheBE;
		if (Lua_BlackJack_ProjectL_UI_ArenaUIController.<>f__mg$cacheBF == null)
		{
			Lua_BlackJack_ProjectL_UI_ArenaUIController.<>f__mg$cacheBF = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ArenaUIController.set_m_arenaTicketDescBackgroundButton);
		}
		LuaObject.addMember(l, name29, get29, Lua_BlackJack_ProjectL_UI_ArenaUIController.<>f__mg$cacheBF, true);
		string name30 = "m_buyArenaTicketUIStateController";
		if (Lua_BlackJack_ProjectL_UI_ArenaUIController.<>f__mg$cacheC0 == null)
		{
			Lua_BlackJack_ProjectL_UI_ArenaUIController.<>f__mg$cacheC0 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ArenaUIController.get_m_buyArenaTicketUIStateController);
		}
		LuaCSFunction get30 = Lua_BlackJack_ProjectL_UI_ArenaUIController.<>f__mg$cacheC0;
		if (Lua_BlackJack_ProjectL_UI_ArenaUIController.<>f__mg$cacheC1 == null)
		{
			Lua_BlackJack_ProjectL_UI_ArenaUIController.<>f__mg$cacheC1 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ArenaUIController.set_m_buyArenaTicketUIStateController);
		}
		LuaObject.addMember(l, name30, get30, Lua_BlackJack_ProjectL_UI_ArenaUIController.<>f__mg$cacheC1, true);
		string name31 = "m_buyArenaTicketBackgroundButton";
		if (Lua_BlackJack_ProjectL_UI_ArenaUIController.<>f__mg$cacheC2 == null)
		{
			Lua_BlackJack_ProjectL_UI_ArenaUIController.<>f__mg$cacheC2 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ArenaUIController.get_m_buyArenaTicketBackgroundButton);
		}
		LuaCSFunction get31 = Lua_BlackJack_ProjectL_UI_ArenaUIController.<>f__mg$cacheC2;
		if (Lua_BlackJack_ProjectL_UI_ArenaUIController.<>f__mg$cacheC3 == null)
		{
			Lua_BlackJack_ProjectL_UI_ArenaUIController.<>f__mg$cacheC3 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ArenaUIController.set_m_buyArenaTicketBackgroundButton);
		}
		LuaObject.addMember(l, name31, get31, Lua_BlackJack_ProjectL_UI_ArenaUIController.<>f__mg$cacheC3, true);
		string name32 = "m_buyArenaTicketCountText";
		if (Lua_BlackJack_ProjectL_UI_ArenaUIController.<>f__mg$cacheC4 == null)
		{
			Lua_BlackJack_ProjectL_UI_ArenaUIController.<>f__mg$cacheC4 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ArenaUIController.get_m_buyArenaTicketCountText);
		}
		LuaCSFunction get32 = Lua_BlackJack_ProjectL_UI_ArenaUIController.<>f__mg$cacheC4;
		if (Lua_BlackJack_ProjectL_UI_ArenaUIController.<>f__mg$cacheC5 == null)
		{
			Lua_BlackJack_ProjectL_UI_ArenaUIController.<>f__mg$cacheC5 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ArenaUIController.set_m_buyArenaTicketCountText);
		}
		LuaObject.addMember(l, name32, get32, Lua_BlackJack_ProjectL_UI_ArenaUIController.<>f__mg$cacheC5, true);
		string name33 = "m_buyArenaTicketBuyButton";
		if (Lua_BlackJack_ProjectL_UI_ArenaUIController.<>f__mg$cacheC6 == null)
		{
			Lua_BlackJack_ProjectL_UI_ArenaUIController.<>f__mg$cacheC6 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ArenaUIController.get_m_buyArenaTicketBuyButton);
		}
		LuaCSFunction get33 = Lua_BlackJack_ProjectL_UI_ArenaUIController.<>f__mg$cacheC6;
		if (Lua_BlackJack_ProjectL_UI_ArenaUIController.<>f__mg$cacheC7 == null)
		{
			Lua_BlackJack_ProjectL_UI_ArenaUIController.<>f__mg$cacheC7 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ArenaUIController.set_m_buyArenaTicketBuyButton);
		}
		LuaObject.addMember(l, name33, get33, Lua_BlackJack_ProjectL_UI_ArenaUIController.<>f__mg$cacheC7, true);
		string name34 = "m_buyArenaTicketPriceText";
		if (Lua_BlackJack_ProjectL_UI_ArenaUIController.<>f__mg$cacheC8 == null)
		{
			Lua_BlackJack_ProjectL_UI_ArenaUIController.<>f__mg$cacheC8 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ArenaUIController.get_m_buyArenaTicketPriceText);
		}
		LuaCSFunction get34 = Lua_BlackJack_ProjectL_UI_ArenaUIController.<>f__mg$cacheC8;
		if (Lua_BlackJack_ProjectL_UI_ArenaUIController.<>f__mg$cacheC9 == null)
		{
			Lua_BlackJack_ProjectL_UI_ArenaUIController.<>f__mg$cacheC9 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ArenaUIController.set_m_buyArenaTicketPriceText);
		}
		LuaObject.addMember(l, name34, get34, Lua_BlackJack_ProjectL_UI_ArenaUIController.<>f__mg$cacheC9, true);
		string name35 = "m_offineArenaPointRewardUIStateCtrl";
		if (Lua_BlackJack_ProjectL_UI_ArenaUIController.<>f__mg$cacheCA == null)
		{
			Lua_BlackJack_ProjectL_UI_ArenaUIController.<>f__mg$cacheCA = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ArenaUIController.get_m_offineArenaPointRewardUIStateCtrl);
		}
		LuaCSFunction get35 = Lua_BlackJack_ProjectL_UI_ArenaUIController.<>f__mg$cacheCA;
		if (Lua_BlackJack_ProjectL_UI_ArenaUIController.<>f__mg$cacheCB == null)
		{
			Lua_BlackJack_ProjectL_UI_ArenaUIController.<>f__mg$cacheCB = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ArenaUIController.set_m_offineArenaPointRewardUIStateCtrl);
		}
		LuaObject.addMember(l, name35, get35, Lua_BlackJack_ProjectL_UI_ArenaUIController.<>f__mg$cacheCB, true);
		string name36 = "m_offlineArenaPointRewardBGButton";
		if (Lua_BlackJack_ProjectL_UI_ArenaUIController.<>f__mg$cacheCC == null)
		{
			Lua_BlackJack_ProjectL_UI_ArenaUIController.<>f__mg$cacheCC = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ArenaUIController.get_m_offlineArenaPointRewardBGButton);
		}
		LuaCSFunction get36 = Lua_BlackJack_ProjectL_UI_ArenaUIController.<>f__mg$cacheCC;
		if (Lua_BlackJack_ProjectL_UI_ArenaUIController.<>f__mg$cacheCD == null)
		{
			Lua_BlackJack_ProjectL_UI_ArenaUIController.<>f__mg$cacheCD = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ArenaUIController.set_m_offlineArenaPointRewardBGButton);
		}
		LuaObject.addMember(l, name36, get36, Lua_BlackJack_ProjectL_UI_ArenaUIController.<>f__mg$cacheCD, true);
		string name37 = "m_offlineArenaPointRewardCloseButton";
		if (Lua_BlackJack_ProjectL_UI_ArenaUIController.<>f__mg$cacheCE == null)
		{
			Lua_BlackJack_ProjectL_UI_ArenaUIController.<>f__mg$cacheCE = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ArenaUIController.get_m_offlineArenaPointRewardCloseButton);
		}
		LuaCSFunction get37 = Lua_BlackJack_ProjectL_UI_ArenaUIController.<>f__mg$cacheCE;
		if (Lua_BlackJack_ProjectL_UI_ArenaUIController.<>f__mg$cacheCF == null)
		{
			Lua_BlackJack_ProjectL_UI_ArenaUIController.<>f__mg$cacheCF = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ArenaUIController.set_m_offlineArenaPointRewardCloseButton);
		}
		LuaObject.addMember(l, name37, get37, Lua_BlackJack_ProjectL_UI_ArenaUIController.<>f__mg$cacheCF, true);
		string name38 = "m_offlineArenaPointRewardScrollRect";
		if (Lua_BlackJack_ProjectL_UI_ArenaUIController.<>f__mg$cacheD0 == null)
		{
			Lua_BlackJack_ProjectL_UI_ArenaUIController.<>f__mg$cacheD0 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ArenaUIController.get_m_offlineArenaPointRewardScrollRect);
		}
		LuaCSFunction get38 = Lua_BlackJack_ProjectL_UI_ArenaUIController.<>f__mg$cacheD0;
		if (Lua_BlackJack_ProjectL_UI_ArenaUIController.<>f__mg$cacheD1 == null)
		{
			Lua_BlackJack_ProjectL_UI_ArenaUIController.<>f__mg$cacheD1 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ArenaUIController.set_m_offlineArenaPointRewardScrollRect);
		}
		LuaObject.addMember(l, name38, get38, Lua_BlackJack_ProjectL_UI_ArenaUIController.<>f__mg$cacheD1, true);
		string name39 = "m_onlineArenaRankingRewardUIStateCtrl";
		if (Lua_BlackJack_ProjectL_UI_ArenaUIController.<>f__mg$cacheD2 == null)
		{
			Lua_BlackJack_ProjectL_UI_ArenaUIController.<>f__mg$cacheD2 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ArenaUIController.get_m_onlineArenaRankingRewardUIStateCtrl);
		}
		LuaCSFunction get39 = Lua_BlackJack_ProjectL_UI_ArenaUIController.<>f__mg$cacheD2;
		if (Lua_BlackJack_ProjectL_UI_ArenaUIController.<>f__mg$cacheD3 == null)
		{
			Lua_BlackJack_ProjectL_UI_ArenaUIController.<>f__mg$cacheD3 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ArenaUIController.set_m_onlineArenaRankingRewardUIStateCtrl);
		}
		LuaObject.addMember(l, name39, get39, Lua_BlackJack_ProjectL_UI_ArenaUIController.<>f__mg$cacheD3, true);
		string name40 = "m_onlineArenaRankingRewardBGButton";
		if (Lua_BlackJack_ProjectL_UI_ArenaUIController.<>f__mg$cacheD4 == null)
		{
			Lua_BlackJack_ProjectL_UI_ArenaUIController.<>f__mg$cacheD4 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ArenaUIController.get_m_onlineArenaRankingRewardBGButton);
		}
		LuaCSFunction get40 = Lua_BlackJack_ProjectL_UI_ArenaUIController.<>f__mg$cacheD4;
		if (Lua_BlackJack_ProjectL_UI_ArenaUIController.<>f__mg$cacheD5 == null)
		{
			Lua_BlackJack_ProjectL_UI_ArenaUIController.<>f__mg$cacheD5 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ArenaUIController.set_m_onlineArenaRankingRewardBGButton);
		}
		LuaObject.addMember(l, name40, get40, Lua_BlackJack_ProjectL_UI_ArenaUIController.<>f__mg$cacheD5, true);
		string name41 = "m_onlineArenaRankingRewardCloseButton";
		if (Lua_BlackJack_ProjectL_UI_ArenaUIController.<>f__mg$cacheD6 == null)
		{
			Lua_BlackJack_ProjectL_UI_ArenaUIController.<>f__mg$cacheD6 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ArenaUIController.get_m_onlineArenaRankingRewardCloseButton);
		}
		LuaCSFunction get41 = Lua_BlackJack_ProjectL_UI_ArenaUIController.<>f__mg$cacheD6;
		if (Lua_BlackJack_ProjectL_UI_ArenaUIController.<>f__mg$cacheD7 == null)
		{
			Lua_BlackJack_ProjectL_UI_ArenaUIController.<>f__mg$cacheD7 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ArenaUIController.set_m_onlineArenaRankingRewardCloseButton);
		}
		LuaObject.addMember(l, name41, get41, Lua_BlackJack_ProjectL_UI_ArenaUIController.<>f__mg$cacheD7, true);
		string name42 = "m_onlineArenaRankingRewardscrollRect";
		if (Lua_BlackJack_ProjectL_UI_ArenaUIController.<>f__mg$cacheD8 == null)
		{
			Lua_BlackJack_ProjectL_UI_ArenaUIController.<>f__mg$cacheD8 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ArenaUIController.get_m_onlineArenaRankingRewardscrollRect);
		}
		LuaCSFunction get42 = Lua_BlackJack_ProjectL_UI_ArenaUIController.<>f__mg$cacheD8;
		if (Lua_BlackJack_ProjectL_UI_ArenaUIController.<>f__mg$cacheD9 == null)
		{
			Lua_BlackJack_ProjectL_UI_ArenaUIController.<>f__mg$cacheD9 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ArenaUIController.set_m_onlineArenaRankingRewardscrollRect);
		}
		LuaObject.addMember(l, name42, get42, Lua_BlackJack_ProjectL_UI_ArenaUIController.<>f__mg$cacheD9, true);
		string name43 = "m_attackUIStateController";
		if (Lua_BlackJack_ProjectL_UI_ArenaUIController.<>f__mg$cacheDA == null)
		{
			Lua_BlackJack_ProjectL_UI_ArenaUIController.<>f__mg$cacheDA = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ArenaUIController.get_m_attackUIStateController);
		}
		LuaCSFunction get43 = Lua_BlackJack_ProjectL_UI_ArenaUIController.<>f__mg$cacheDA;
		if (Lua_BlackJack_ProjectL_UI_ArenaUIController.<>f__mg$cacheDB == null)
		{
			Lua_BlackJack_ProjectL_UI_ArenaUIController.<>f__mg$cacheDB = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ArenaUIController.set_m_attackUIStateController);
		}
		LuaObject.addMember(l, name43, get43, Lua_BlackJack_ProjectL_UI_ArenaUIController.<>f__mg$cacheDB, true);
		string name44 = "m_attackBackgroundButton";
		if (Lua_BlackJack_ProjectL_UI_ArenaUIController.<>f__mg$cacheDC == null)
		{
			Lua_BlackJack_ProjectL_UI_ArenaUIController.<>f__mg$cacheDC = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ArenaUIController.get_m_attackBackgroundButton);
		}
		LuaCSFunction get44 = Lua_BlackJack_ProjectL_UI_ArenaUIController.<>f__mg$cacheDC;
		if (Lua_BlackJack_ProjectL_UI_ArenaUIController.<>f__mg$cacheDD == null)
		{
			Lua_BlackJack_ProjectL_UI_ArenaUIController.<>f__mg$cacheDD = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ArenaUIController.set_m_attackBackgroundButton);
		}
		LuaObject.addMember(l, name44, get44, Lua_BlackJack_ProjectL_UI_ArenaUIController.<>f__mg$cacheDD, true);
		string name45 = "m_attackBattlePowerText";
		if (Lua_BlackJack_ProjectL_UI_ArenaUIController.<>f__mg$cacheDE == null)
		{
			Lua_BlackJack_ProjectL_UI_ArenaUIController.<>f__mg$cacheDE = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ArenaUIController.get_m_attackBattlePowerText);
		}
		LuaCSFunction get45 = Lua_BlackJack_ProjectL_UI_ArenaUIController.<>f__mg$cacheDE;
		if (Lua_BlackJack_ProjectL_UI_ArenaUIController.<>f__mg$cacheDF == null)
		{
			Lua_BlackJack_ProjectL_UI_ArenaUIController.<>f__mg$cacheDF = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ArenaUIController.set_m_attackBattlePowerText);
		}
		LuaObject.addMember(l, name45, get45, Lua_BlackJack_ProjectL_UI_ArenaUIController.<>f__mg$cacheDF, true);
		string name46 = "m_attackConfirmButton";
		if (Lua_BlackJack_ProjectL_UI_ArenaUIController.<>f__mg$cacheE0 == null)
		{
			Lua_BlackJack_ProjectL_UI_ArenaUIController.<>f__mg$cacheE0 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ArenaUIController.get_m_attackConfirmButton);
		}
		LuaCSFunction get46 = Lua_BlackJack_ProjectL_UI_ArenaUIController.<>f__mg$cacheE0;
		if (Lua_BlackJack_ProjectL_UI_ArenaUIController.<>f__mg$cacheE1 == null)
		{
			Lua_BlackJack_ProjectL_UI_ArenaUIController.<>f__mg$cacheE1 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ArenaUIController.set_m_attackConfirmButton);
		}
		LuaObject.addMember(l, name46, get46, Lua_BlackJack_ProjectL_UI_ArenaUIController.<>f__mg$cacheE1, true);
		string name47 = "m_attackAutoConfirmButton";
		if (Lua_BlackJack_ProjectL_UI_ArenaUIController.<>f__mg$cacheE2 == null)
		{
			Lua_BlackJack_ProjectL_UI_ArenaUIController.<>f__mg$cacheE2 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ArenaUIController.get_m_attackAutoConfirmButton);
		}
		LuaCSFunction get47 = Lua_BlackJack_ProjectL_UI_ArenaUIController.<>f__mg$cacheE2;
		if (Lua_BlackJack_ProjectL_UI_ArenaUIController.<>f__mg$cacheE3 == null)
		{
			Lua_BlackJack_ProjectL_UI_ArenaUIController.<>f__mg$cacheE3 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ArenaUIController.set_m_attackAutoConfirmButton);
		}
		LuaObject.addMember(l, name47, get47, Lua_BlackJack_ProjectL_UI_ArenaUIController.<>f__mg$cacheE3, true);
		string name48 = "m_attackGraphicsGameObject";
		if (Lua_BlackJack_ProjectL_UI_ArenaUIController.<>f__mg$cacheE4 == null)
		{
			Lua_BlackJack_ProjectL_UI_ArenaUIController.<>f__mg$cacheE4 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ArenaUIController.get_m_attackGraphicsGameObject);
		}
		LuaCSFunction get48 = Lua_BlackJack_ProjectL_UI_ArenaUIController.<>f__mg$cacheE4;
		if (Lua_BlackJack_ProjectL_UI_ArenaUIController.<>f__mg$cacheE5 == null)
		{
			Lua_BlackJack_ProjectL_UI_ArenaUIController.<>f__mg$cacheE5 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ArenaUIController.set_m_attackGraphicsGameObject);
		}
		LuaObject.addMember(l, name48, get48, Lua_BlackJack_ProjectL_UI_ArenaUIController.<>f__mg$cacheE5, true);
		string name49 = "m_attackPlayerIconImage";
		if (Lua_BlackJack_ProjectL_UI_ArenaUIController.<>f__mg$cacheE6 == null)
		{
			Lua_BlackJack_ProjectL_UI_ArenaUIController.<>f__mg$cacheE6 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ArenaUIController.get_m_attackPlayerIconImage);
		}
		LuaCSFunction get49 = Lua_BlackJack_ProjectL_UI_ArenaUIController.<>f__mg$cacheE6;
		if (Lua_BlackJack_ProjectL_UI_ArenaUIController.<>f__mg$cacheE7 == null)
		{
			Lua_BlackJack_ProjectL_UI_ArenaUIController.<>f__mg$cacheE7 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ArenaUIController.set_m_attackPlayerIconImage);
		}
		LuaObject.addMember(l, name49, get49, Lua_BlackJack_ProjectL_UI_ArenaUIController.<>f__mg$cacheE7, true);
		string name50 = "m_attackPlayerNameText";
		if (Lua_BlackJack_ProjectL_UI_ArenaUIController.<>f__mg$cacheE8 == null)
		{
			Lua_BlackJack_ProjectL_UI_ArenaUIController.<>f__mg$cacheE8 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ArenaUIController.get_m_attackPlayerNameText);
		}
		LuaCSFunction get50 = Lua_BlackJack_ProjectL_UI_ArenaUIController.<>f__mg$cacheE8;
		if (Lua_BlackJack_ProjectL_UI_ArenaUIController.<>f__mg$cacheE9 == null)
		{
			Lua_BlackJack_ProjectL_UI_ArenaUIController.<>f__mg$cacheE9 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ArenaUIController.set_m_attackPlayerNameText);
		}
		LuaObject.addMember(l, name50, get50, Lua_BlackJack_ProjectL_UI_ArenaUIController.<>f__mg$cacheE9, true);
		string name51 = "m_attackPlayerLVText";
		if (Lua_BlackJack_ProjectL_UI_ArenaUIController.<>f__mg$cacheEA == null)
		{
			Lua_BlackJack_ProjectL_UI_ArenaUIController.<>f__mg$cacheEA = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ArenaUIController.get_m_attackPlayerLVText);
		}
		LuaCSFunction get51 = Lua_BlackJack_ProjectL_UI_ArenaUIController.<>f__mg$cacheEA;
		if (Lua_BlackJack_ProjectL_UI_ArenaUIController.<>f__mg$cacheEB == null)
		{
			Lua_BlackJack_ProjectL_UI_ArenaUIController.<>f__mg$cacheEB = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ArenaUIController.set_m_attackPlayerLVText);
		}
		LuaObject.addMember(l, name51, get51, Lua_BlackJack_ProjectL_UI_ArenaUIController.<>f__mg$cacheEB, true);
		string name52 = "m_attackPlayerArenaPointText";
		if (Lua_BlackJack_ProjectL_UI_ArenaUIController.<>f__mg$cacheEC == null)
		{
			Lua_BlackJack_ProjectL_UI_ArenaUIController.<>f__mg$cacheEC = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ArenaUIController.get_m_attackPlayerArenaPointText);
		}
		LuaCSFunction get52 = Lua_BlackJack_ProjectL_UI_ArenaUIController.<>f__mg$cacheEC;
		if (Lua_BlackJack_ProjectL_UI_ArenaUIController.<>f__mg$cacheED == null)
		{
			Lua_BlackJack_ProjectL_UI_ArenaUIController.<>f__mg$cacheED = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ArenaUIController.set_m_attackPlayerArenaPointText);
		}
		LuaObject.addMember(l, name52, get52, Lua_BlackJack_ProjectL_UI_ArenaUIController.<>f__mg$cacheED, true);
		string name53 = "m_prefabsGameObject";
		if (Lua_BlackJack_ProjectL_UI_ArenaUIController.<>f__mg$cacheEE == null)
		{
			Lua_BlackJack_ProjectL_UI_ArenaUIController.<>f__mg$cacheEE = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ArenaUIController.get_m_prefabsGameObject);
		}
		LuaCSFunction get53 = Lua_BlackJack_ProjectL_UI_ArenaUIController.<>f__mg$cacheEE;
		if (Lua_BlackJack_ProjectL_UI_ArenaUIController.<>f__mg$cacheEF == null)
		{
			Lua_BlackJack_ProjectL_UI_ArenaUIController.<>f__mg$cacheEF = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ArenaUIController.set_m_prefabsGameObject);
		}
		LuaObject.addMember(l, name53, get53, Lua_BlackJack_ProjectL_UI_ArenaUIController.<>f__mg$cacheEF, true);
		string name54 = "m_arenaLevelListItemPrefab";
		if (Lua_BlackJack_ProjectL_UI_ArenaUIController.<>f__mg$cacheF0 == null)
		{
			Lua_BlackJack_ProjectL_UI_ArenaUIController.<>f__mg$cacheF0 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ArenaUIController.get_m_arenaLevelListItemPrefab);
		}
		LuaCSFunction get54 = Lua_BlackJack_ProjectL_UI_ArenaUIController.<>f__mg$cacheF0;
		if (Lua_BlackJack_ProjectL_UI_ArenaUIController.<>f__mg$cacheF1 == null)
		{
			Lua_BlackJack_ProjectL_UI_ArenaUIController.<>f__mg$cacheF1 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ArenaUIController.set_m_arenaLevelListItemPrefab);
		}
		LuaObject.addMember(l, name54, get54, Lua_BlackJack_ProjectL_UI_ArenaUIController.<>f__mg$cacheF1, true);
		string name55 = "m_arenaRankingListItemPrefab";
		if (Lua_BlackJack_ProjectL_UI_ArenaUIController.<>f__mg$cacheF2 == null)
		{
			Lua_BlackJack_ProjectL_UI_ArenaUIController.<>f__mg$cacheF2 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ArenaUIController.get_m_arenaRankingListItemPrefab);
		}
		LuaCSFunction get55 = Lua_BlackJack_ProjectL_UI_ArenaUIController.<>f__mg$cacheF2;
		if (Lua_BlackJack_ProjectL_UI_ArenaUIController.<>f__mg$cacheF3 == null)
		{
			Lua_BlackJack_ProjectL_UI_ArenaUIController.<>f__mg$cacheF3 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ArenaUIController.set_m_arenaRankingListItemPrefab);
		}
		LuaObject.addMember(l, name55, get55, Lua_BlackJack_ProjectL_UI_ArenaUIController.<>f__mg$cacheF3, true);
		string name56 = "m_offlineArenaBattleReportListItemPrefab";
		if (Lua_BlackJack_ProjectL_UI_ArenaUIController.<>f__mg$cacheF4 == null)
		{
			Lua_BlackJack_ProjectL_UI_ArenaUIController.<>f__mg$cacheF4 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ArenaUIController.get_m_offlineArenaBattleReportListItemPrefab);
		}
		LuaCSFunction get56 = Lua_BlackJack_ProjectL_UI_ArenaUIController.<>f__mg$cacheF4;
		if (Lua_BlackJack_ProjectL_UI_ArenaUIController.<>f__mg$cacheF5 == null)
		{
			Lua_BlackJack_ProjectL_UI_ArenaUIController.<>f__mg$cacheF5 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ArenaUIController.set_m_offlineArenaBattleReportListItemPrefab);
		}
		LuaObject.addMember(l, name56, get56, Lua_BlackJack_ProjectL_UI_ArenaUIController.<>f__mg$cacheF5, true);
		string name57 = "m_arenaOpponentListItemPrefab";
		if (Lua_BlackJack_ProjectL_UI_ArenaUIController.<>f__mg$cacheF6 == null)
		{
			Lua_BlackJack_ProjectL_UI_ArenaUIController.<>f__mg$cacheF6 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ArenaUIController.get_m_arenaOpponentListItemPrefab);
		}
		LuaCSFunction get57 = Lua_BlackJack_ProjectL_UI_ArenaUIController.<>f__mg$cacheF6;
		if (Lua_BlackJack_ProjectL_UI_ArenaUIController.<>f__mg$cacheF7 == null)
		{
			Lua_BlackJack_ProjectL_UI_ArenaUIController.<>f__mg$cacheF7 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ArenaUIController.set_m_arenaOpponentListItemPrefab);
		}
		LuaObject.addMember(l, name57, get57, Lua_BlackJack_ProjectL_UI_ArenaUIController.<>f__mg$cacheF7, true);
		string name58 = "m_arenaPointRewardListItemPrefab";
		if (Lua_BlackJack_ProjectL_UI_ArenaUIController.<>f__mg$cacheF8 == null)
		{
			Lua_BlackJack_ProjectL_UI_ArenaUIController.<>f__mg$cacheF8 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ArenaUIController.get_m_arenaPointRewardListItemPrefab);
		}
		LuaCSFunction get58 = Lua_BlackJack_ProjectL_UI_ArenaUIController.<>f__mg$cacheF8;
		if (Lua_BlackJack_ProjectL_UI_ArenaUIController.<>f__mg$cacheF9 == null)
		{
			Lua_BlackJack_ProjectL_UI_ArenaUIController.<>f__mg$cacheF9 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ArenaUIController.set_m_arenaPointRewardListItemPrefab);
		}
		LuaObject.addMember(l, name58, get58, Lua_BlackJack_ProjectL_UI_ArenaUIController.<>f__mg$cacheF9, true);
		string name59 = "m_onlineArenaBattleReportListItemPrefab";
		if (Lua_BlackJack_ProjectL_UI_ArenaUIController.<>f__mg$cacheFA == null)
		{
			Lua_BlackJack_ProjectL_UI_ArenaUIController.<>f__mg$cacheFA = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ArenaUIController.get_m_onlineArenaBattleReportListItemPrefab);
		}
		LuaCSFunction get59 = Lua_BlackJack_ProjectL_UI_ArenaUIController.<>f__mg$cacheFA;
		if (Lua_BlackJack_ProjectL_UI_ArenaUIController.<>f__mg$cacheFB == null)
		{
			Lua_BlackJack_ProjectL_UI_ArenaUIController.<>f__mg$cacheFB = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ArenaUIController.set_m_onlineArenaBattleReportListItemPrefab);
		}
		LuaObject.addMember(l, name59, get59, Lua_BlackJack_ProjectL_UI_ArenaUIController.<>f__mg$cacheFB, true);
		string name60 = "m_isIgnoreToggleEvent";
		if (Lua_BlackJack_ProjectL_UI_ArenaUIController.<>f__mg$cacheFC == null)
		{
			Lua_BlackJack_ProjectL_UI_ArenaUIController.<>f__mg$cacheFC = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ArenaUIController.get_m_isIgnoreToggleEvent);
		}
		LuaCSFunction get60 = Lua_BlackJack_ProjectL_UI_ArenaUIController.<>f__mg$cacheFC;
		if (Lua_BlackJack_ProjectL_UI_ArenaUIController.<>f__mg$cacheFD == null)
		{
			Lua_BlackJack_ProjectL_UI_ArenaUIController.<>f__mg$cacheFD = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ArenaUIController.set_m_isIgnoreToggleEvent);
		}
		LuaObject.addMember(l, name60, get60, Lua_BlackJack_ProjectL_UI_ArenaUIController.<>f__mg$cacheFD, true);
		string name61 = "m_isRevengeOpponent";
		if (Lua_BlackJack_ProjectL_UI_ArenaUIController.<>f__mg$cacheFE == null)
		{
			Lua_BlackJack_ProjectL_UI_ArenaUIController.<>f__mg$cacheFE = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ArenaUIController.get_m_isRevengeOpponent);
		}
		LuaCSFunction get61 = Lua_BlackJack_ProjectL_UI_ArenaUIController.<>f__mg$cacheFE;
		if (Lua_BlackJack_ProjectL_UI_ArenaUIController.<>f__mg$cacheFF == null)
		{
			Lua_BlackJack_ProjectL_UI_ArenaUIController.<>f__mg$cacheFF = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ArenaUIController.set_m_isRevengeOpponent);
		}
		LuaObject.addMember(l, name61, get61, Lua_BlackJack_ProjectL_UI_ArenaUIController.<>f__mg$cacheFF, true);
		string name62 = "s_isShowAutoBattleTips";
		if (Lua_BlackJack_ProjectL_UI_ArenaUIController.<>f__mg$cache100 == null)
		{
			Lua_BlackJack_ProjectL_UI_ArenaUIController.<>f__mg$cache100 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ArenaUIController.get_s_isShowAutoBattleTips);
		}
		LuaCSFunction get62 = Lua_BlackJack_ProjectL_UI_ArenaUIController.<>f__mg$cache100;
		if (Lua_BlackJack_ProjectL_UI_ArenaUIController.<>f__mg$cache101 == null)
		{
			Lua_BlackJack_ProjectL_UI_ArenaUIController.<>f__mg$cache101 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ArenaUIController.set_s_isShowAutoBattleTips);
		}
		LuaObject.addMember(l, name62, get62, Lua_BlackJack_ProjectL_UI_ArenaUIController.<>f__mg$cache101, false);
		string name63 = "m_offlineVictoryPointsRewardButtons";
		if (Lua_BlackJack_ProjectL_UI_ArenaUIController.<>f__mg$cache102 == null)
		{
			Lua_BlackJack_ProjectL_UI_ArenaUIController.<>f__mg$cache102 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ArenaUIController.get_m_offlineVictoryPointsRewardButtons);
		}
		LuaCSFunction get63 = Lua_BlackJack_ProjectL_UI_ArenaUIController.<>f__mg$cache102;
		if (Lua_BlackJack_ProjectL_UI_ArenaUIController.<>f__mg$cache103 == null)
		{
			Lua_BlackJack_ProjectL_UI_ArenaUIController.<>f__mg$cache103 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ArenaUIController.set_m_offlineVictoryPointsRewardButtons);
		}
		LuaObject.addMember(l, name63, get63, Lua_BlackJack_ProjectL_UI_ArenaUIController.<>f__mg$cache103, true);
		string name64 = "m_onlineWeekWinRewardButtons";
		if (Lua_BlackJack_ProjectL_UI_ArenaUIController.<>f__mg$cache104 == null)
		{
			Lua_BlackJack_ProjectL_UI_ArenaUIController.<>f__mg$cache104 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ArenaUIController.get_m_onlineWeekWinRewardButtons);
		}
		LuaCSFunction get64 = Lua_BlackJack_ProjectL_UI_ArenaUIController.<>f__mg$cache104;
		if (Lua_BlackJack_ProjectL_UI_ArenaUIController.<>f__mg$cache105 == null)
		{
			Lua_BlackJack_ProjectL_UI_ArenaUIController.<>f__mg$cache105 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ArenaUIController.set_m_onlineWeekWinRewardButtons);
		}
		LuaObject.addMember(l, name64, get64, Lua_BlackJack_ProjectL_UI_ArenaUIController.<>f__mg$cache105, true);
		string name65 = "m_onlineArenaLevelPool";
		if (Lua_BlackJack_ProjectL_UI_ArenaUIController.<>f__mg$cache106 == null)
		{
			Lua_BlackJack_ProjectL_UI_ArenaUIController.<>f__mg$cache106 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ArenaUIController.get_m_onlineArenaLevelPool);
		}
		LuaCSFunction get65 = Lua_BlackJack_ProjectL_UI_ArenaUIController.<>f__mg$cache106;
		if (Lua_BlackJack_ProjectL_UI_ArenaUIController.<>f__mg$cache107 == null)
		{
			Lua_BlackJack_ProjectL_UI_ArenaUIController.<>f__mg$cache107 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ArenaUIController.set_m_onlineArenaLevelPool);
		}
		LuaObject.addMember(l, name65, get65, Lua_BlackJack_ProjectL_UI_ArenaUIController.<>f__mg$cache107, true);
		string name66 = "m_opponentGraphics";
		if (Lua_BlackJack_ProjectL_UI_ArenaUIController.<>f__mg$cache108 == null)
		{
			Lua_BlackJack_ProjectL_UI_ArenaUIController.<>f__mg$cache108 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ArenaUIController.get_m_opponentGraphics);
		}
		LuaCSFunction get66 = Lua_BlackJack_ProjectL_UI_ArenaUIController.<>f__mg$cache108;
		if (Lua_BlackJack_ProjectL_UI_ArenaUIController.<>f__mg$cache109 == null)
		{
			Lua_BlackJack_ProjectL_UI_ArenaUIController.<>f__mg$cache109 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ArenaUIController.set_m_opponentGraphics);
		}
		LuaObject.addMember(l, name66, get66, Lua_BlackJack_ProjectL_UI_ArenaUIController.<>f__mg$cache109, true);
		string name67 = "EventOnShowOfflinePanel";
		LuaCSFunction get67 = null;
		if (Lua_BlackJack_ProjectL_UI_ArenaUIController.<>f__mg$cache10A == null)
		{
			Lua_BlackJack_ProjectL_UI_ArenaUIController.<>f__mg$cache10A = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ArenaUIController.set_EventOnShowOfflinePanel);
		}
		LuaObject.addMember(l, name67, get67, Lua_BlackJack_ProjectL_UI_ArenaUIController.<>f__mg$cache10A, true);
		string name68 = "EventOnGainOfflineVictoryPointsReward";
		LuaCSFunction get68 = null;
		if (Lua_BlackJack_ProjectL_UI_ArenaUIController.<>f__mg$cache10B == null)
		{
			Lua_BlackJack_ProjectL_UI_ArenaUIController.<>f__mg$cache10B = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ArenaUIController.set_EventOnGainOfflineVictoryPointsReward);
		}
		LuaObject.addMember(l, name68, get68, Lua_BlackJack_ProjectL_UI_ArenaUIController.<>f__mg$cache10B, true);
		string name69 = "EventOnShowOfflineArenaOpponent";
		LuaCSFunction get69 = null;
		if (Lua_BlackJack_ProjectL_UI_ArenaUIController.<>f__mg$cache10C == null)
		{
			Lua_BlackJack_ProjectL_UI_ArenaUIController.<>f__mg$cache10C = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ArenaUIController.set_EventOnShowOfflineArenaOpponent);
		}
		LuaObject.addMember(l, name69, get69, Lua_BlackJack_ProjectL_UI_ArenaUIController.<>f__mg$cache10C, true);
		string name70 = "EventOnAttackOfflineArenaOpponent";
		LuaCSFunction get70 = null;
		if (Lua_BlackJack_ProjectL_UI_ArenaUIController.<>f__mg$cache10D == null)
		{
			Lua_BlackJack_ProjectL_UI_ArenaUIController.<>f__mg$cache10D = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ArenaUIController.set_EventOnAttackOfflineArenaOpponent);
		}
		LuaObject.addMember(l, name70, get70, Lua_BlackJack_ProjectL_UI_ArenaUIController.<>f__mg$cache10D, true);
		string name71 = "EventOnShowRevengeOfflineArenaOpponent";
		LuaCSFunction get71 = null;
		if (Lua_BlackJack_ProjectL_UI_ArenaUIController.<>f__mg$cache10E == null)
		{
			Lua_BlackJack_ProjectL_UI_ArenaUIController.<>f__mg$cache10E = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ArenaUIController.set_EventOnShowRevengeOfflineArenaOpponent);
		}
		LuaObject.addMember(l, name71, get71, Lua_BlackJack_ProjectL_UI_ArenaUIController.<>f__mg$cache10E, true);
		string name72 = "EventOnRevengeOfflineArenaOpponent";
		LuaCSFunction get72 = null;
		if (Lua_BlackJack_ProjectL_UI_ArenaUIController.<>f__mg$cache10F == null)
		{
			Lua_BlackJack_ProjectL_UI_ArenaUIController.<>f__mg$cache10F = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ArenaUIController.set_EventOnRevengeOfflineArenaOpponent);
		}
		LuaObject.addMember(l, name72, get72, Lua_BlackJack_ProjectL_UI_ArenaUIController.<>f__mg$cache10F, true);
		string name73 = "EventOnOfflineBattleReportReplay";
		LuaCSFunction get73 = null;
		if (Lua_BlackJack_ProjectL_UI_ArenaUIController.<>f__mg$cache110 == null)
		{
			Lua_BlackJack_ProjectL_UI_ArenaUIController.<>f__mg$cache110 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ArenaUIController.set_EventOnOfflineBattleReportReplay);
		}
		LuaObject.addMember(l, name73, get73, Lua_BlackJack_ProjectL_UI_ArenaUIController.<>f__mg$cache110, true);
		string name74 = "m_offlineGameObject";
		if (Lua_BlackJack_ProjectL_UI_ArenaUIController.<>f__mg$cache111 == null)
		{
			Lua_BlackJack_ProjectL_UI_ArenaUIController.<>f__mg$cache111 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ArenaUIController.get_m_offlineGameObject);
		}
		LuaCSFunction get74 = Lua_BlackJack_ProjectL_UI_ArenaUIController.<>f__mg$cache111;
		if (Lua_BlackJack_ProjectL_UI_ArenaUIController.<>f__mg$cache112 == null)
		{
			Lua_BlackJack_ProjectL_UI_ArenaUIController.<>f__mg$cache112 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ArenaUIController.set_m_offlineGameObject);
		}
		LuaObject.addMember(l, name74, get74, Lua_BlackJack_ProjectL_UI_ArenaUIController.<>f__mg$cache112, true);
		string name75 = "m_offlineMarginTransform";
		if (Lua_BlackJack_ProjectL_UI_ArenaUIController.<>f__mg$cache113 == null)
		{
			Lua_BlackJack_ProjectL_UI_ArenaUIController.<>f__mg$cache113 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ArenaUIController.get_m_offlineMarginTransform);
		}
		LuaCSFunction get75 = Lua_BlackJack_ProjectL_UI_ArenaUIController.<>f__mg$cache113;
		if (Lua_BlackJack_ProjectL_UI_ArenaUIController.<>f__mg$cache114 == null)
		{
			Lua_BlackJack_ProjectL_UI_ArenaUIController.<>f__mg$cache114 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ArenaUIController.set_m_offlineMarginTransform);
		}
		LuaObject.addMember(l, name75, get75, Lua_BlackJack_ProjectL_UI_ArenaUIController.<>f__mg$cache114, true);
		string name76 = "m_offlineClashToggle";
		if (Lua_BlackJack_ProjectL_UI_ArenaUIController.<>f__mg$cache115 == null)
		{
			Lua_BlackJack_ProjectL_UI_ArenaUIController.<>f__mg$cache115 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ArenaUIController.get_m_offlineClashToggle);
		}
		LuaCSFunction get76 = Lua_BlackJack_ProjectL_UI_ArenaUIController.<>f__mg$cache115;
		if (Lua_BlackJack_ProjectL_UI_ArenaUIController.<>f__mg$cache116 == null)
		{
			Lua_BlackJack_ProjectL_UI_ArenaUIController.<>f__mg$cache116 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ArenaUIController.set_m_offlineClashToggle);
		}
		LuaObject.addMember(l, name76, get76, Lua_BlackJack_ProjectL_UI_ArenaUIController.<>f__mg$cache116, true);
		string name77 = "m_offlineBattleReportToggle";
		if (Lua_BlackJack_ProjectL_UI_ArenaUIController.<>f__mg$cache117 == null)
		{
			Lua_BlackJack_ProjectL_UI_ArenaUIController.<>f__mg$cache117 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ArenaUIController.get_m_offlineBattleReportToggle);
		}
		LuaCSFunction get77 = Lua_BlackJack_ProjectL_UI_ArenaUIController.<>f__mg$cache117;
		if (Lua_BlackJack_ProjectL_UI_ArenaUIController.<>f__mg$cache118 == null)
		{
			Lua_BlackJack_ProjectL_UI_ArenaUIController.<>f__mg$cache118 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ArenaUIController.set_m_offlineBattleReportToggle);
		}
		LuaObject.addMember(l, name77, get77, Lua_BlackJack_ProjectL_UI_ArenaUIController.<>f__mg$cache118, true);
		string name78 = "m_offlineRankingToggle";
		if (Lua_BlackJack_ProjectL_UI_ArenaUIController.<>f__mg$cache119 == null)
		{
			Lua_BlackJack_ProjectL_UI_ArenaUIController.<>f__mg$cache119 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ArenaUIController.get_m_offlineRankingToggle);
		}
		LuaCSFunction get78 = Lua_BlackJack_ProjectL_UI_ArenaUIController.<>f__mg$cache119;
		if (Lua_BlackJack_ProjectL_UI_ArenaUIController.<>f__mg$cache11A == null)
		{
			Lua_BlackJack_ProjectL_UI_ArenaUIController.<>f__mg$cache11A = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ArenaUIController.set_m_offlineRankingToggle);
		}
		LuaObject.addMember(l, name78, get78, Lua_BlackJack_ProjectL_UI_ArenaUIController.<>f__mg$cache11A, true);
		string name79 = "m_offlineClashPanelGameObject";
		if (Lua_BlackJack_ProjectL_UI_ArenaUIController.<>f__mg$cache11B == null)
		{
			Lua_BlackJack_ProjectL_UI_ArenaUIController.<>f__mg$cache11B = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ArenaUIController.get_m_offlineClashPanelGameObject);
		}
		LuaCSFunction get79 = Lua_BlackJack_ProjectL_UI_ArenaUIController.<>f__mg$cache11B;
		if (Lua_BlackJack_ProjectL_UI_ArenaUIController.<>f__mg$cache11C == null)
		{
			Lua_BlackJack_ProjectL_UI_ArenaUIController.<>f__mg$cache11C = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ArenaUIController.set_m_offlineClashPanelGameObject);
		}
		LuaObject.addMember(l, name79, get79, Lua_BlackJack_ProjectL_UI_ArenaUIController.<>f__mg$cache11C, true);
		string name80 = "m_offlineArenaOpponentsGameObject";
		if (Lua_BlackJack_ProjectL_UI_ArenaUIController.<>f__mg$cache11D == null)
		{
			Lua_BlackJack_ProjectL_UI_ArenaUIController.<>f__mg$cache11D = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ArenaUIController.get_m_offlineArenaOpponentsGameObject);
		}
		LuaCSFunction get80 = Lua_BlackJack_ProjectL_UI_ArenaUIController.<>f__mg$cache11D;
		if (Lua_BlackJack_ProjectL_UI_ArenaUIController.<>f__mg$cache11E == null)
		{
			Lua_BlackJack_ProjectL_UI_ArenaUIController.<>f__mg$cache11E = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ArenaUIController.set_m_offlineArenaOpponentsGameObject);
		}
		LuaObject.addMember(l, name80, get80, Lua_BlackJack_ProjectL_UI_ArenaUIController.<>f__mg$cache11E, true);
		string name81 = "m_offlineInSettleGameObject";
		if (Lua_BlackJack_ProjectL_UI_ArenaUIController.<>f__mg$cache11F == null)
		{
			Lua_BlackJack_ProjectL_UI_ArenaUIController.<>f__mg$cache11F = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ArenaUIController.get_m_offlineInSettleGameObject);
		}
		LuaCSFunction get81 = Lua_BlackJack_ProjectL_UI_ArenaUIController.<>f__mg$cache11F;
		if (Lua_BlackJack_ProjectL_UI_ArenaUIController.<>f__mg$cache120 == null)
		{
			Lua_BlackJack_ProjectL_UI_ArenaUIController.<>f__mg$cache120 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ArenaUIController.set_m_offlineInSettleGameObject);
		}
		LuaObject.addMember(l, name81, get81, Lua_BlackJack_ProjectL_UI_ArenaUIController.<>f__mg$cache120, true);
		string name82 = "m_offlineArenaOpponentsRefreshTimeText";
		if (Lua_BlackJack_ProjectL_UI_ArenaUIController.<>f__mg$cache121 == null)
		{
			Lua_BlackJack_ProjectL_UI_ArenaUIController.<>f__mg$cache121 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ArenaUIController.get_m_offlineArenaOpponentsRefreshTimeText);
		}
		LuaCSFunction get82 = Lua_BlackJack_ProjectL_UI_ArenaUIController.<>f__mg$cache121;
		if (Lua_BlackJack_ProjectL_UI_ArenaUIController.<>f__mg$cache122 == null)
		{
			Lua_BlackJack_ProjectL_UI_ArenaUIController.<>f__mg$cache122 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ArenaUIController.set_m_offlineArenaOpponentsRefreshTimeText);
		}
		LuaObject.addMember(l, name82, get82, Lua_BlackJack_ProjectL_UI_ArenaUIController.<>f__mg$cache122, true);
		string name83 = "m_offlineBattleReportPanelGameObject";
		if (Lua_BlackJack_ProjectL_UI_ArenaUIController.<>f__mg$cache123 == null)
		{
			Lua_BlackJack_ProjectL_UI_ArenaUIController.<>f__mg$cache123 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ArenaUIController.get_m_offlineBattleReportPanelGameObject);
		}
		LuaCSFunction get83 = Lua_BlackJack_ProjectL_UI_ArenaUIController.<>f__mg$cache123;
		if (Lua_BlackJack_ProjectL_UI_ArenaUIController.<>f__mg$cache124 == null)
		{
			Lua_BlackJack_ProjectL_UI_ArenaUIController.<>f__mg$cache124 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ArenaUIController.set_m_offlineBattleReportPanelGameObject);
		}
		LuaObject.addMember(l, name83, get83, Lua_BlackJack_ProjectL_UI_ArenaUIController.<>f__mg$cache124, true);
		string name84 = "m_offlineBattleReportScrollRect";
		if (Lua_BlackJack_ProjectL_UI_ArenaUIController.<>f__mg$cache125 == null)
		{
			Lua_BlackJack_ProjectL_UI_ArenaUIController.<>f__mg$cache125 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ArenaUIController.get_m_offlineBattleReportScrollRect);
		}
		LuaCSFunction get84 = Lua_BlackJack_ProjectL_UI_ArenaUIController.<>f__mg$cache125;
		if (Lua_BlackJack_ProjectL_UI_ArenaUIController.<>f__mg$cache126 == null)
		{
			Lua_BlackJack_ProjectL_UI_ArenaUIController.<>f__mg$cache126 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ArenaUIController.set_m_offlineBattleReportScrollRect);
		}
		LuaObject.addMember(l, name84, get84, Lua_BlackJack_ProjectL_UI_ArenaUIController.<>f__mg$cache126, true);
		string name85 = "m_offlineNoBattleReportGameObject";
		if (Lua_BlackJack_ProjectL_UI_ArenaUIController.<>f__mg$cache127 == null)
		{
			Lua_BlackJack_ProjectL_UI_ArenaUIController.<>f__mg$cache127 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ArenaUIController.get_m_offlineNoBattleReportGameObject);
		}
		LuaCSFunction get85 = Lua_BlackJack_ProjectL_UI_ArenaUIController.<>f__mg$cache127;
		if (Lua_BlackJack_ProjectL_UI_ArenaUIController.<>f__mg$cache128 == null)
		{
			Lua_BlackJack_ProjectL_UI_ArenaUIController.<>f__mg$cache128 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ArenaUIController.set_m_offlineNoBattleReportGameObject);
		}
		LuaObject.addMember(l, name85, get85, Lua_BlackJack_ProjectL_UI_ArenaUIController.<>f__mg$cache128, true);
		string name86 = "m_offlineRankingPanelGameObject";
		if (Lua_BlackJack_ProjectL_UI_ArenaUIController.<>f__mg$cache129 == null)
		{
			Lua_BlackJack_ProjectL_UI_ArenaUIController.<>f__mg$cache129 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ArenaUIController.get_m_offlineRankingPanelGameObject);
		}
		LuaCSFunction get86 = Lua_BlackJack_ProjectL_UI_ArenaUIController.<>f__mg$cache129;
		if (Lua_BlackJack_ProjectL_UI_ArenaUIController.<>f__mg$cache12A == null)
		{
			Lua_BlackJack_ProjectL_UI_ArenaUIController.<>f__mg$cache12A = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ArenaUIController.set_m_offlineRankingPanelGameObject);
		}
		LuaObject.addMember(l, name86, get86, Lua_BlackJack_ProjectL_UI_ArenaUIController.<>f__mg$cache12A, true);
		string name87 = "m_offlineRankingScrollRect";
		if (Lua_BlackJack_ProjectL_UI_ArenaUIController.<>f__mg$cache12B == null)
		{
			Lua_BlackJack_ProjectL_UI_ArenaUIController.<>f__mg$cache12B = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ArenaUIController.get_m_offlineRankingScrollRect);
		}
		LuaCSFunction get87 = Lua_BlackJack_ProjectL_UI_ArenaUIController.<>f__mg$cache12B;
		if (Lua_BlackJack_ProjectL_UI_ArenaUIController.<>f__mg$cache12C == null)
		{
			Lua_BlackJack_ProjectL_UI_ArenaUIController.<>f__mg$cache12C = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ArenaUIController.set_m_offlineRankingScrollRect);
		}
		LuaObject.addMember(l, name87, get87, Lua_BlackJack_ProjectL_UI_ArenaUIController.<>f__mg$cache12C, true);
		string name88 = "m_offlineRankingPlayerNameText";
		if (Lua_BlackJack_ProjectL_UI_ArenaUIController.<>f__mg$cache12D == null)
		{
			Lua_BlackJack_ProjectL_UI_ArenaUIController.<>f__mg$cache12D = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ArenaUIController.get_m_offlineRankingPlayerNameText);
		}
		LuaCSFunction get88 = Lua_BlackJack_ProjectL_UI_ArenaUIController.<>f__mg$cache12D;
		if (Lua_BlackJack_ProjectL_UI_ArenaUIController.<>f__mg$cache12E == null)
		{
			Lua_BlackJack_ProjectL_UI_ArenaUIController.<>f__mg$cache12E = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ArenaUIController.set_m_offlineRankingPlayerNameText);
		}
		LuaObject.addMember(l, name88, get88, Lua_BlackJack_ProjectL_UI_ArenaUIController.<>f__mg$cache12E, true);
		string name89 = "m_offlineRankingPlayerRankingUIStateController";
		if (Lua_BlackJack_ProjectL_UI_ArenaUIController.<>f__mg$cache12F == null)
		{
			Lua_BlackJack_ProjectL_UI_ArenaUIController.<>f__mg$cache12F = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ArenaUIController.get_m_offlineRankingPlayerRankingUIStateController);
		}
		LuaCSFunction get89 = Lua_BlackJack_ProjectL_UI_ArenaUIController.<>f__mg$cache12F;
		if (Lua_BlackJack_ProjectL_UI_ArenaUIController.<>f__mg$cache130 == null)
		{
			Lua_BlackJack_ProjectL_UI_ArenaUIController.<>f__mg$cache130 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ArenaUIController.set_m_offlineRankingPlayerRankingUIStateController);
		}
		LuaObject.addMember(l, name89, get89, Lua_BlackJack_ProjectL_UI_ArenaUIController.<>f__mg$cache130, true);
		string name90 = "m_offlineRankingPlayerRankingText";
		if (Lua_BlackJack_ProjectL_UI_ArenaUIController.<>f__mg$cache131 == null)
		{
			Lua_BlackJack_ProjectL_UI_ArenaUIController.<>f__mg$cache131 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ArenaUIController.get_m_offlineRankingPlayerRankingText);
		}
		LuaCSFunction get90 = Lua_BlackJack_ProjectL_UI_ArenaUIController.<>f__mg$cache131;
		if (Lua_BlackJack_ProjectL_UI_ArenaUIController.<>f__mg$cache132 == null)
		{
			Lua_BlackJack_ProjectL_UI_ArenaUIController.<>f__mg$cache132 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ArenaUIController.set_m_offlineRankingPlayerRankingText);
		}
		LuaObject.addMember(l, name90, get90, Lua_BlackJack_ProjectL_UI_ArenaUIController.<>f__mg$cache132, true);
		string name91 = "m_offlineRankingPlayerRankingImage";
		if (Lua_BlackJack_ProjectL_UI_ArenaUIController.<>f__mg$cache133 == null)
		{
			Lua_BlackJack_ProjectL_UI_ArenaUIController.<>f__mg$cache133 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ArenaUIController.get_m_offlineRankingPlayerRankingImage);
		}
		LuaCSFunction get91 = Lua_BlackJack_ProjectL_UI_ArenaUIController.<>f__mg$cache133;
		if (Lua_BlackJack_ProjectL_UI_ArenaUIController.<>f__mg$cache134 == null)
		{
			Lua_BlackJack_ProjectL_UI_ArenaUIController.<>f__mg$cache134 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ArenaUIController.set_m_offlineRankingPlayerRankingImage);
		}
		LuaObject.addMember(l, name91, get91, Lua_BlackJack_ProjectL_UI_ArenaUIController.<>f__mg$cache134, true);
		string name92 = "m_offlineRankingArenaPointsText";
		if (Lua_BlackJack_ProjectL_UI_ArenaUIController.<>f__mg$cache135 == null)
		{
			Lua_BlackJack_ProjectL_UI_ArenaUIController.<>f__mg$cache135 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ArenaUIController.get_m_offlineRankingArenaPointsText);
		}
		LuaCSFunction get92 = Lua_BlackJack_ProjectL_UI_ArenaUIController.<>f__mg$cache135;
		if (Lua_BlackJack_ProjectL_UI_ArenaUIController.<>f__mg$cache136 == null)
		{
			Lua_BlackJack_ProjectL_UI_ArenaUIController.<>f__mg$cache136 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ArenaUIController.set_m_offlineRankingArenaPointsText);
		}
		LuaObject.addMember(l, name92, get92, Lua_BlackJack_ProjectL_UI_ArenaUIController.<>f__mg$cache136, true);
		string name93 = "m_offlineRankingPlayerIconImage";
		if (Lua_BlackJack_ProjectL_UI_ArenaUIController.<>f__mg$cache137 == null)
		{
			Lua_BlackJack_ProjectL_UI_ArenaUIController.<>f__mg$cache137 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ArenaUIController.get_m_offlineRankingPlayerIconImage);
		}
		LuaCSFunction get93 = Lua_BlackJack_ProjectL_UI_ArenaUIController.<>f__mg$cache137;
		if (Lua_BlackJack_ProjectL_UI_ArenaUIController.<>f__mg$cache138 == null)
		{
			Lua_BlackJack_ProjectL_UI_ArenaUIController.<>f__mg$cache138 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ArenaUIController.set_m_offlineRankingPlayerIconImage);
		}
		LuaObject.addMember(l, name93, get93, Lua_BlackJack_ProjectL_UI_ArenaUIController.<>f__mg$cache138, true);
		string name94 = "m_offlineRankingPlayerHeadFrameTransform";
		if (Lua_BlackJack_ProjectL_UI_ArenaUIController.<>f__mg$cache139 == null)
		{
			Lua_BlackJack_ProjectL_UI_ArenaUIController.<>f__mg$cache139 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ArenaUIController.get_m_offlineRankingPlayerHeadFrameTransform);
		}
		LuaCSFunction get94 = Lua_BlackJack_ProjectL_UI_ArenaUIController.<>f__mg$cache139;
		if (Lua_BlackJack_ProjectL_UI_ArenaUIController.<>f__mg$cache13A == null)
		{
			Lua_BlackJack_ProjectL_UI_ArenaUIController.<>f__mg$cache13A = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ArenaUIController.set_m_offlineRankingPlayerHeadFrameTransform);
		}
		LuaObject.addMember(l, name94, get94, Lua_BlackJack_ProjectL_UI_ArenaUIController.<>f__mg$cache13A, true);
		string name95 = "m_offlineRankingPlayerLevelText";
		if (Lua_BlackJack_ProjectL_UI_ArenaUIController.<>f__mg$cache13B == null)
		{
			Lua_BlackJack_ProjectL_UI_ArenaUIController.<>f__mg$cache13B = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ArenaUIController.get_m_offlineRankingPlayerLevelText);
		}
		LuaCSFunction get95 = Lua_BlackJack_ProjectL_UI_ArenaUIController.<>f__mg$cache13B;
		if (Lua_BlackJack_ProjectL_UI_ArenaUIController.<>f__mg$cache13C == null)
		{
			Lua_BlackJack_ProjectL_UI_ArenaUIController.<>f__mg$cache13C = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ArenaUIController.set_m_offlineRankingPlayerLevelText);
		}
		LuaObject.addMember(l, name95, get95, Lua_BlackJack_ProjectL_UI_ArenaUIController.<>f__mg$cache13C, true);
		string name96 = "m_offlinePlayerIconImage";
		if (Lua_BlackJack_ProjectL_UI_ArenaUIController.<>f__mg$cache13D == null)
		{
			Lua_BlackJack_ProjectL_UI_ArenaUIController.<>f__mg$cache13D = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ArenaUIController.get_m_offlinePlayerIconImage);
		}
		LuaCSFunction get96 = Lua_BlackJack_ProjectL_UI_ArenaUIController.<>f__mg$cache13D;
		if (Lua_BlackJack_ProjectL_UI_ArenaUIController.<>f__mg$cache13E == null)
		{
			Lua_BlackJack_ProjectL_UI_ArenaUIController.<>f__mg$cache13E = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ArenaUIController.set_m_offlinePlayerIconImage);
		}
		LuaObject.addMember(l, name96, get96, Lua_BlackJack_ProjectL_UI_ArenaUIController.<>f__mg$cache13E, true);
		string name97 = "m_offlinePlayerNameText";
		if (Lua_BlackJack_ProjectL_UI_ArenaUIController.<>f__mg$cache13F == null)
		{
			Lua_BlackJack_ProjectL_UI_ArenaUIController.<>f__mg$cache13F = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ArenaUIController.get_m_offlinePlayerNameText);
		}
		LuaCSFunction get97 = Lua_BlackJack_ProjectL_UI_ArenaUIController.<>f__mg$cache13F;
		if (Lua_BlackJack_ProjectL_UI_ArenaUIController.<>f__mg$cache140 == null)
		{
			Lua_BlackJack_ProjectL_UI_ArenaUIController.<>f__mg$cache140 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ArenaUIController.set_m_offlinePlayerNameText);
		}
		LuaObject.addMember(l, name97, get97, Lua_BlackJack_ProjectL_UI_ArenaUIController.<>f__mg$cache140, true);
		string name98 = "m_offlinePlayerLevelText";
		if (Lua_BlackJack_ProjectL_UI_ArenaUIController.<>f__mg$cache141 == null)
		{
			Lua_BlackJack_ProjectL_UI_ArenaUIController.<>f__mg$cache141 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ArenaUIController.get_m_offlinePlayerLevelText);
		}
		LuaCSFunction get98 = Lua_BlackJack_ProjectL_UI_ArenaUIController.<>f__mg$cache141;
		if (Lua_BlackJack_ProjectL_UI_ArenaUIController.<>f__mg$cache142 == null)
		{
			Lua_BlackJack_ProjectL_UI_ArenaUIController.<>f__mg$cache142 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ArenaUIController.set_m_offlinePlayerLevelText);
		}
		LuaObject.addMember(l, name98, get98, Lua_BlackJack_ProjectL_UI_ArenaUIController.<>f__mg$cache142, true);
		string name99 = "m_offlinePlayerBattlePowerText";
		if (Lua_BlackJack_ProjectL_UI_ArenaUIController.<>f__mg$cache143 == null)
		{
			Lua_BlackJack_ProjectL_UI_ArenaUIController.<>f__mg$cache143 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ArenaUIController.get_m_offlinePlayerBattlePowerText);
		}
		LuaCSFunction get99 = Lua_BlackJack_ProjectL_UI_ArenaUIController.<>f__mg$cache143;
		if (Lua_BlackJack_ProjectL_UI_ArenaUIController.<>f__mg$cache144 == null)
		{
			Lua_BlackJack_ProjectL_UI_ArenaUIController.<>f__mg$cache144 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ArenaUIController.set_m_offlinePlayerBattlePowerText);
		}
		LuaObject.addMember(l, name99, get99, Lua_BlackJack_ProjectL_UI_ArenaUIController.<>f__mg$cache144, true);
		string name100 = "m_offlineArenaPointsText";
		if (Lua_BlackJack_ProjectL_UI_ArenaUIController.<>f__mg$cache145 == null)
		{
			Lua_BlackJack_ProjectL_UI_ArenaUIController.<>f__mg$cache145 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ArenaUIController.get_m_offlineArenaPointsText);
		}
		LuaCSFunction get100 = Lua_BlackJack_ProjectL_UI_ArenaUIController.<>f__mg$cache145;
		if (Lua_BlackJack_ProjectL_UI_ArenaUIController.<>f__mg$cache146 == null)
		{
			Lua_BlackJack_ProjectL_UI_ArenaUIController.<>f__mg$cache146 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ArenaUIController.set_m_offlineArenaPointsText);
		}
		LuaObject.addMember(l, name100, get100, Lua_BlackJack_ProjectL_UI_ArenaUIController.<>f__mg$cache146, true);
		string name101 = "m_offlineArenaPointsUpText1";
		if (Lua_BlackJack_ProjectL_UI_ArenaUIController.<>f__mg$cache147 == null)
		{
			Lua_BlackJack_ProjectL_UI_ArenaUIController.<>f__mg$cache147 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ArenaUIController.get_m_offlineArenaPointsUpText1);
		}
		LuaCSFunction get101 = Lua_BlackJack_ProjectL_UI_ArenaUIController.<>f__mg$cache147;
		if (Lua_BlackJack_ProjectL_UI_ArenaUIController.<>f__mg$cache148 == null)
		{
			Lua_BlackJack_ProjectL_UI_ArenaUIController.<>f__mg$cache148 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ArenaUIController.set_m_offlineArenaPointsUpText1);
		}
		LuaObject.addMember(l, name101, get101, Lua_BlackJack_ProjectL_UI_ArenaUIController.<>f__mg$cache148, true);
		string name102 = "m_offlineArenaPointsUpText2";
		if (Lua_BlackJack_ProjectL_UI_ArenaUIController.<>f__mg$cache149 == null)
		{
			Lua_BlackJack_ProjectL_UI_ArenaUIController.<>f__mg$cache149 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ArenaUIController.get_m_offlineArenaPointsUpText2);
		}
		LuaCSFunction get102 = Lua_BlackJack_ProjectL_UI_ArenaUIController.<>f__mg$cache149;
		if (Lua_BlackJack_ProjectL_UI_ArenaUIController.<>f__mg$cache14A == null)
		{
			Lua_BlackJack_ProjectL_UI_ArenaUIController.<>f__mg$cache14A = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ArenaUIController.set_m_offlineArenaPointsUpText2);
		}
		LuaObject.addMember(l, name102, get102, Lua_BlackJack_ProjectL_UI_ArenaUIController.<>f__mg$cache14A, true);
		string name103 = "m_offlineArenaPointsUpBarImage";
		if (Lua_BlackJack_ProjectL_UI_ArenaUIController.<>f__mg$cache14B == null)
		{
			Lua_BlackJack_ProjectL_UI_ArenaUIController.<>f__mg$cache14B = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ArenaUIController.get_m_offlineArenaPointsUpBarImage);
		}
		LuaCSFunction get103 = Lua_BlackJack_ProjectL_UI_ArenaUIController.<>f__mg$cache14B;
		if (Lua_BlackJack_ProjectL_UI_ArenaUIController.<>f__mg$cache14C == null)
		{
			Lua_BlackJack_ProjectL_UI_ArenaUIController.<>f__mg$cache14C = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ArenaUIController.set_m_offlineArenaPointsUpBarImage);
		}
		LuaObject.addMember(l, name103, get103, Lua_BlackJack_ProjectL_UI_ArenaUIController.<>f__mg$cache14C, true);
		string name104 = "m_offlineDefendButton";
		if (Lua_BlackJack_ProjectL_UI_ArenaUIController.<>f__mg$cache14D == null)
		{
			Lua_BlackJack_ProjectL_UI_ArenaUIController.<>f__mg$cache14D = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ArenaUIController.get_m_offlineDefendButton);
		}
		LuaCSFunction get104 = Lua_BlackJack_ProjectL_UI_ArenaUIController.<>f__mg$cache14D;
		if (Lua_BlackJack_ProjectL_UI_ArenaUIController.<>f__mg$cache14E == null)
		{
			Lua_BlackJack_ProjectL_UI_ArenaUIController.<>f__mg$cache14E = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ArenaUIController.set_m_offlineDefendButton);
		}
		LuaObject.addMember(l, name104, get104, Lua_BlackJack_ProjectL_UI_ArenaUIController.<>f__mg$cache14E, true);
		string name105 = "m_offlineArenaPointRewardButton";
		if (Lua_BlackJack_ProjectL_UI_ArenaUIController.<>f__mg$cache14F == null)
		{
			Lua_BlackJack_ProjectL_UI_ArenaUIController.<>f__mg$cache14F = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ArenaUIController.get_m_offlineArenaPointRewardButton);
		}
		LuaCSFunction get105 = Lua_BlackJack_ProjectL_UI_ArenaUIController.<>f__mg$cache14F;
		if (Lua_BlackJack_ProjectL_UI_ArenaUIController.<>f__mg$cache150 == null)
		{
			Lua_BlackJack_ProjectL_UI_ArenaUIController.<>f__mg$cache150 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ArenaUIController.set_m_offlineArenaPointRewardButton);
		}
		LuaObject.addMember(l, name105, get105, Lua_BlackJack_ProjectL_UI_ArenaUIController.<>f__mg$cache150, true);
		string name106 = "m_offlineVictoryPointsText";
		if (Lua_BlackJack_ProjectL_UI_ArenaUIController.<>f__mg$cache151 == null)
		{
			Lua_BlackJack_ProjectL_UI_ArenaUIController.<>f__mg$cache151 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ArenaUIController.get_m_offlineVictoryPointsText);
		}
		LuaCSFunction get106 = Lua_BlackJack_ProjectL_UI_ArenaUIController.<>f__mg$cache151;
		if (Lua_BlackJack_ProjectL_UI_ArenaUIController.<>f__mg$cache152 == null)
		{
			Lua_BlackJack_ProjectL_UI_ArenaUIController.<>f__mg$cache152 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ArenaUIController.set_m_offlineVictoryPointsText);
		}
		LuaObject.addMember(l, name106, get106, Lua_BlackJack_ProjectL_UI_ArenaUIController.<>f__mg$cache152, true);
		string name107 = "m_offlineVictoryPointsRewardButton1GameObject";
		if (Lua_BlackJack_ProjectL_UI_ArenaUIController.<>f__mg$cache153 == null)
		{
			Lua_BlackJack_ProjectL_UI_ArenaUIController.<>f__mg$cache153 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ArenaUIController.get_m_offlineVictoryPointsRewardButton1GameObject);
		}
		LuaCSFunction get107 = Lua_BlackJack_ProjectL_UI_ArenaUIController.<>f__mg$cache153;
		if (Lua_BlackJack_ProjectL_UI_ArenaUIController.<>f__mg$cache154 == null)
		{
			Lua_BlackJack_ProjectL_UI_ArenaUIController.<>f__mg$cache154 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ArenaUIController.set_m_offlineVictoryPointsRewardButton1GameObject);
		}
		LuaObject.addMember(l, name107, get107, Lua_BlackJack_ProjectL_UI_ArenaUIController.<>f__mg$cache154, true);
		string name108 = "m_offlineVictoryPointsRewardButton2GameObject";
		if (Lua_BlackJack_ProjectL_UI_ArenaUIController.<>f__mg$cache155 == null)
		{
			Lua_BlackJack_ProjectL_UI_ArenaUIController.<>f__mg$cache155 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ArenaUIController.get_m_offlineVictoryPointsRewardButton2GameObject);
		}
		LuaCSFunction get108 = Lua_BlackJack_ProjectL_UI_ArenaUIController.<>f__mg$cache155;
		if (Lua_BlackJack_ProjectL_UI_ArenaUIController.<>f__mg$cache156 == null)
		{
			Lua_BlackJack_ProjectL_UI_ArenaUIController.<>f__mg$cache156 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ArenaUIController.set_m_offlineVictoryPointsRewardButton2GameObject);
		}
		LuaObject.addMember(l, name108, get108, Lua_BlackJack_ProjectL_UI_ArenaUIController.<>f__mg$cache156, true);
		string name109 = "m_offlineVictoryPointsRewardButton3GameObject";
		if (Lua_BlackJack_ProjectL_UI_ArenaUIController.<>f__mg$cache157 == null)
		{
			Lua_BlackJack_ProjectL_UI_ArenaUIController.<>f__mg$cache157 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ArenaUIController.get_m_offlineVictoryPointsRewardButton3GameObject);
		}
		LuaCSFunction get109 = Lua_BlackJack_ProjectL_UI_ArenaUIController.<>f__mg$cache157;
		if (Lua_BlackJack_ProjectL_UI_ArenaUIController.<>f__mg$cache158 == null)
		{
			Lua_BlackJack_ProjectL_UI_ArenaUIController.<>f__mg$cache158 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ArenaUIController.set_m_offlineVictoryPointsRewardButton3GameObject);
		}
		LuaObject.addMember(l, name109, get109, Lua_BlackJack_ProjectL_UI_ArenaUIController.<>f__mg$cache158, true);
		string name110 = "m_offlineVictoryPointsRewardImage";
		if (Lua_BlackJack_ProjectL_UI_ArenaUIController.<>f__mg$cache159 == null)
		{
			Lua_BlackJack_ProjectL_UI_ArenaUIController.<>f__mg$cache159 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ArenaUIController.get_m_offlineVictoryPointsRewardImage);
		}
		LuaCSFunction get110 = Lua_BlackJack_ProjectL_UI_ArenaUIController.<>f__mg$cache159;
		if (Lua_BlackJack_ProjectL_UI_ArenaUIController.<>f__mg$cache15A == null)
		{
			Lua_BlackJack_ProjectL_UI_ArenaUIController.<>f__mg$cache15A = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ArenaUIController.set_m_offlineVictoryPointsRewardImage);
		}
		LuaObject.addMember(l, name110, get110, Lua_BlackJack_ProjectL_UI_ArenaUIController.<>f__mg$cache15A, true);
		string name111 = "m_offlineWeekWinText";
		if (Lua_BlackJack_ProjectL_UI_ArenaUIController.<>f__mg$cache15B == null)
		{
			Lua_BlackJack_ProjectL_UI_ArenaUIController.<>f__mg$cache15B = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ArenaUIController.get_m_offlineWeekWinText);
		}
		LuaCSFunction get111 = Lua_BlackJack_ProjectL_UI_ArenaUIController.<>f__mg$cache15B;
		if (Lua_BlackJack_ProjectL_UI_ArenaUIController.<>f__mg$cache15C == null)
		{
			Lua_BlackJack_ProjectL_UI_ArenaUIController.<>f__mg$cache15C = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ArenaUIController.set_m_offlineWeekWinText);
		}
		LuaObject.addMember(l, name111, get111, Lua_BlackJack_ProjectL_UI_ArenaUIController.<>f__mg$cache15C, true);
		string name112 = "m_arenaOpponentPool";
		if (Lua_BlackJack_ProjectL_UI_ArenaUIController.<>f__mg$cache15D == null)
		{
			Lua_BlackJack_ProjectL_UI_ArenaUIController.<>f__mg$cache15D = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ArenaUIController.get_m_arenaOpponentPool);
		}
		LuaCSFunction get112 = Lua_BlackJack_ProjectL_UI_ArenaUIController.<>f__mg$cache15D;
		if (Lua_BlackJack_ProjectL_UI_ArenaUIController.<>f__mg$cache15E == null)
		{
			Lua_BlackJack_ProjectL_UI_ArenaUIController.<>f__mg$cache15E = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ArenaUIController.set_m_arenaOpponentPool);
		}
		LuaObject.addMember(l, name112, get112, Lua_BlackJack_ProjectL_UI_ArenaUIController.<>f__mg$cache15E, true);
		string name113 = "m_arenaRankingPool";
		if (Lua_BlackJack_ProjectL_UI_ArenaUIController.<>f__mg$cache15F == null)
		{
			Lua_BlackJack_ProjectL_UI_ArenaUIController.<>f__mg$cache15F = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ArenaUIController.get_m_arenaRankingPool);
		}
		LuaCSFunction get113 = Lua_BlackJack_ProjectL_UI_ArenaUIController.<>f__mg$cache15F;
		if (Lua_BlackJack_ProjectL_UI_ArenaUIController.<>f__mg$cache160 == null)
		{
			Lua_BlackJack_ProjectL_UI_ArenaUIController.<>f__mg$cache160 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ArenaUIController.set_m_arenaRankingPool);
		}
		LuaObject.addMember(l, name113, get113, Lua_BlackJack_ProjectL_UI_ArenaUIController.<>f__mg$cache160, true);
		string name114 = "m_offlineArenaBattleReportPool";
		if (Lua_BlackJack_ProjectL_UI_ArenaUIController.<>f__mg$cache161 == null)
		{
			Lua_BlackJack_ProjectL_UI_ArenaUIController.<>f__mg$cache161 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ArenaUIController.get_m_offlineArenaBattleReportPool);
		}
		LuaCSFunction get114 = Lua_BlackJack_ProjectL_UI_ArenaUIController.<>f__mg$cache161;
		if (Lua_BlackJack_ProjectL_UI_ArenaUIController.<>f__mg$cache162 == null)
		{
			Lua_BlackJack_ProjectL_UI_ArenaUIController.<>f__mg$cache162 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ArenaUIController.set_m_offlineArenaBattleReportPool);
		}
		LuaObject.addMember(l, name114, get114, Lua_BlackJack_ProjectL_UI_ArenaUIController.<>f__mg$cache162, true);
		string name115 = "m_offlineArenaPointRewardPool";
		if (Lua_BlackJack_ProjectL_UI_ArenaUIController.<>f__mg$cache163 == null)
		{
			Lua_BlackJack_ProjectL_UI_ArenaUIController.<>f__mg$cache163 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ArenaUIController.get_m_offlineArenaPointRewardPool);
		}
		LuaCSFunction get115 = Lua_BlackJack_ProjectL_UI_ArenaUIController.<>f__mg$cache163;
		if (Lua_BlackJack_ProjectL_UI_ArenaUIController.<>f__mg$cache164 == null)
		{
			Lua_BlackJack_ProjectL_UI_ArenaUIController.<>f__mg$cache164 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ArenaUIController.set_m_offlineArenaPointRewardPool);
		}
		LuaObject.addMember(l, name115, get115, Lua_BlackJack_ProjectL_UI_ArenaUIController.<>f__mg$cache164, true);
		string name116 = "EventOnShowOnlinePanel";
		LuaCSFunction get116 = null;
		if (Lua_BlackJack_ProjectL_UI_ArenaUIController.<>f__mg$cache165 == null)
		{
			Lua_BlackJack_ProjectL_UI_ArenaUIController.<>f__mg$cache165 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ArenaUIController.set_EventOnShowOnlinePanel);
		}
		LuaObject.addMember(l, name116, get116, Lua_BlackJack_ProjectL_UI_ArenaUIController.<>f__mg$cache165, true);
		string name117 = "EventOnGainOnlineWeekWinReward";
		LuaCSFunction get117 = null;
		if (Lua_BlackJack_ProjectL_UI_ArenaUIController.<>f__mg$cache166 == null)
		{
			Lua_BlackJack_ProjectL_UI_ArenaUIController.<>f__mg$cache166 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ArenaUIController.set_EventOnGainOnlineWeekWinReward);
		}
		LuaObject.addMember(l, name117, get117, Lua_BlackJack_ProjectL_UI_ArenaUIController.<>f__mg$cache166, true);
		string name118 = "EventOnOnlineBattleReportReplay";
		LuaCSFunction get118 = null;
		if (Lua_BlackJack_ProjectL_UI_ArenaUIController.<>f__mg$cache167 == null)
		{
			Lua_BlackJack_ProjectL_UI_ArenaUIController.<>f__mg$cache167 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ArenaUIController.set_EventOnOnlineBattleReportReplay);
		}
		LuaObject.addMember(l, name118, get118, Lua_BlackJack_ProjectL_UI_ArenaUIController.<>f__mg$cache167, true);
		string name119 = "EventOnLadderChallenge";
		LuaCSFunction get119 = null;
		if (Lua_BlackJack_ProjectL_UI_ArenaUIController.<>f__mg$cache168 == null)
		{
			Lua_BlackJack_ProjectL_UI_ArenaUIController.<>f__mg$cache168 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ArenaUIController.set_EventOnLadderChallenge);
		}
		LuaObject.addMember(l, name119, get119, Lua_BlackJack_ProjectL_UI_ArenaUIController.<>f__mg$cache168, true);
		string name120 = "EventOnCasualChallenge";
		LuaCSFunction get120 = null;
		if (Lua_BlackJack_ProjectL_UI_ArenaUIController.<>f__mg$cache169 == null)
		{
			Lua_BlackJack_ProjectL_UI_ArenaUIController.<>f__mg$cache169 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ArenaUIController.set_EventOnCasualChallenge);
		}
		LuaObject.addMember(l, name120, get120, Lua_BlackJack_ProjectL_UI_ArenaUIController.<>f__mg$cache169, true);
		string name121 = "EventOnMatchingCancel";
		LuaCSFunction get121 = null;
		if (Lua_BlackJack_ProjectL_UI_ArenaUIController.<>f__mg$cache16A == null)
		{
			Lua_BlackJack_ProjectL_UI_ArenaUIController.<>f__mg$cache16A = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ArenaUIController.set_EventOnMatchingCancel);
		}
		LuaObject.addMember(l, name121, get121, Lua_BlackJack_ProjectL_UI_ArenaUIController.<>f__mg$cache16A, true);
		string name122 = "m_onlineGameObject";
		if (Lua_BlackJack_ProjectL_UI_ArenaUIController.<>f__mg$cache16B == null)
		{
			Lua_BlackJack_ProjectL_UI_ArenaUIController.<>f__mg$cache16B = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ArenaUIController.get_m_onlineGameObject);
		}
		LuaCSFunction get122 = Lua_BlackJack_ProjectL_UI_ArenaUIController.<>f__mg$cache16B;
		if (Lua_BlackJack_ProjectL_UI_ArenaUIController.<>f__mg$cache16C == null)
		{
			Lua_BlackJack_ProjectL_UI_ArenaUIController.<>f__mg$cache16C = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ArenaUIController.set_m_onlineGameObject);
		}
		LuaObject.addMember(l, name122, get122, Lua_BlackJack_ProjectL_UI_ArenaUIController.<>f__mg$cache16C, true);
		string name123 = "m_onlineMarginTransform";
		if (Lua_BlackJack_ProjectL_UI_ArenaUIController.<>f__mg$cache16D == null)
		{
			Lua_BlackJack_ProjectL_UI_ArenaUIController.<>f__mg$cache16D = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ArenaUIController.get_m_onlineMarginTransform);
		}
		LuaCSFunction get123 = Lua_BlackJack_ProjectL_UI_ArenaUIController.<>f__mg$cache16D;
		if (Lua_BlackJack_ProjectL_UI_ArenaUIController.<>f__mg$cache16E == null)
		{
			Lua_BlackJack_ProjectL_UI_ArenaUIController.<>f__mg$cache16E = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ArenaUIController.set_m_onlineMarginTransform);
		}
		LuaObject.addMember(l, name123, get123, Lua_BlackJack_ProjectL_UI_ArenaUIController.<>f__mg$cache16E, true);
		string name124 = "m_onlineClashToggle";
		if (Lua_BlackJack_ProjectL_UI_ArenaUIController.<>f__mg$cache16F == null)
		{
			Lua_BlackJack_ProjectL_UI_ArenaUIController.<>f__mg$cache16F = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ArenaUIController.get_m_onlineClashToggle);
		}
		LuaCSFunction get124 = Lua_BlackJack_ProjectL_UI_ArenaUIController.<>f__mg$cache16F;
		if (Lua_BlackJack_ProjectL_UI_ArenaUIController.<>f__mg$cache170 == null)
		{
			Lua_BlackJack_ProjectL_UI_ArenaUIController.<>f__mg$cache170 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ArenaUIController.set_m_onlineClashToggle);
		}
		LuaObject.addMember(l, name124, get124, Lua_BlackJack_ProjectL_UI_ArenaUIController.<>f__mg$cache170, true);
		string name125 = "m_onlineBattleReportToggle";
		if (Lua_BlackJack_ProjectL_UI_ArenaUIController.<>f__mg$cache171 == null)
		{
			Lua_BlackJack_ProjectL_UI_ArenaUIController.<>f__mg$cache171 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ArenaUIController.get_m_onlineBattleReportToggle);
		}
		LuaCSFunction get125 = Lua_BlackJack_ProjectL_UI_ArenaUIController.<>f__mg$cache171;
		if (Lua_BlackJack_ProjectL_UI_ArenaUIController.<>f__mg$cache172 == null)
		{
			Lua_BlackJack_ProjectL_UI_ArenaUIController.<>f__mg$cache172 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ArenaUIController.set_m_onlineBattleReportToggle);
		}
		LuaObject.addMember(l, name125, get125, Lua_BlackJack_ProjectL_UI_ArenaUIController.<>f__mg$cache172, true);
		string name126 = "m_onlineDanToggle";
		if (Lua_BlackJack_ProjectL_UI_ArenaUIController.<>f__mg$cache173 == null)
		{
			Lua_BlackJack_ProjectL_UI_ArenaUIController.<>f__mg$cache173 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ArenaUIController.get_m_onlineDanToggle);
		}
		LuaCSFunction get126 = Lua_BlackJack_ProjectL_UI_ArenaUIController.<>f__mg$cache173;
		if (Lua_BlackJack_ProjectL_UI_ArenaUIController.<>f__mg$cache174 == null)
		{
			Lua_BlackJack_ProjectL_UI_ArenaUIController.<>f__mg$cache174 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ArenaUIController.set_m_onlineDanToggle);
		}
		LuaObject.addMember(l, name126, get126, Lua_BlackJack_ProjectL_UI_ArenaUIController.<>f__mg$cache174, true);
		string name127 = "m_onlineLocalRankingToggle";
		if (Lua_BlackJack_ProjectL_UI_ArenaUIController.<>f__mg$cache175 == null)
		{
			Lua_BlackJack_ProjectL_UI_ArenaUIController.<>f__mg$cache175 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ArenaUIController.get_m_onlineLocalRankingToggle);
		}
		LuaCSFunction get127 = Lua_BlackJack_ProjectL_UI_ArenaUIController.<>f__mg$cache175;
		if (Lua_BlackJack_ProjectL_UI_ArenaUIController.<>f__mg$cache176 == null)
		{
			Lua_BlackJack_ProjectL_UI_ArenaUIController.<>f__mg$cache176 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ArenaUIController.set_m_onlineLocalRankingToggle);
		}
		LuaObject.addMember(l, name127, get127, Lua_BlackJack_ProjectL_UI_ArenaUIController.<>f__mg$cache176, true);
		string name128 = "m_onlineGlobalRankingToggle";
		if (Lua_BlackJack_ProjectL_UI_ArenaUIController.<>f__mg$cache177 == null)
		{
			Lua_BlackJack_ProjectL_UI_ArenaUIController.<>f__mg$cache177 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ArenaUIController.get_m_onlineGlobalRankingToggle);
		}
		LuaCSFunction get128 = Lua_BlackJack_ProjectL_UI_ArenaUIController.<>f__mg$cache177;
		if (Lua_BlackJack_ProjectL_UI_ArenaUIController.<>f__mg$cache178 == null)
		{
			Lua_BlackJack_ProjectL_UI_ArenaUIController.<>f__mg$cache178 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ArenaUIController.set_m_onlineGlobalRankingToggle);
		}
		LuaObject.addMember(l, name128, get128, Lua_BlackJack_ProjectL_UI_ArenaUIController.<>f__mg$cache178, true);
		string name129 = "m_onlineClashPanelGameObject";
		if (Lua_BlackJack_ProjectL_UI_ArenaUIController.<>f__mg$cache179 == null)
		{
			Lua_BlackJack_ProjectL_UI_ArenaUIController.<>f__mg$cache179 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ArenaUIController.get_m_onlineClashPanelGameObject);
		}
		LuaCSFunction get129 = Lua_BlackJack_ProjectL_UI_ArenaUIController.<>f__mg$cache179;
		if (Lua_BlackJack_ProjectL_UI_ArenaUIController.<>f__mg$cache17A == null)
		{
			Lua_BlackJack_ProjectL_UI_ArenaUIController.<>f__mg$cache17A = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ArenaUIController.set_m_onlineClashPanelGameObject);
		}
		LuaObject.addMember(l, name129, get129, Lua_BlackJack_ProjectL_UI_ArenaUIController.<>f__mg$cache17A, true);
		string name130 = "m_onlineClashLadderModeUIStateController";
		if (Lua_BlackJack_ProjectL_UI_ArenaUIController.<>f__mg$cache17B == null)
		{
			Lua_BlackJack_ProjectL_UI_ArenaUIController.<>f__mg$cache17B = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ArenaUIController.get_m_onlineClashLadderModeUIStateController);
		}
		LuaCSFunction get130 = Lua_BlackJack_ProjectL_UI_ArenaUIController.<>f__mg$cache17B;
		if (Lua_BlackJack_ProjectL_UI_ArenaUIController.<>f__mg$cache17C == null)
		{
			Lua_BlackJack_ProjectL_UI_ArenaUIController.<>f__mg$cache17C = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ArenaUIController.set_m_onlineClashLadderModeUIStateController);
		}
		LuaObject.addMember(l, name130, get130, Lua_BlackJack_ProjectL_UI_ArenaUIController.<>f__mg$cache17C, true);
		string name131 = "m_onlineClashWinRateText";
		if (Lua_BlackJack_ProjectL_UI_ArenaUIController.<>f__mg$cache17D == null)
		{
			Lua_BlackJack_ProjectL_UI_ArenaUIController.<>f__mg$cache17D = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ArenaUIController.get_m_onlineClashWinRateText);
		}
		LuaCSFunction get131 = Lua_BlackJack_ProjectL_UI_ArenaUIController.<>f__mg$cache17D;
		if (Lua_BlackJack_ProjectL_UI_ArenaUIController.<>f__mg$cache17E == null)
		{
			Lua_BlackJack_ProjectL_UI_ArenaUIController.<>f__mg$cache17E = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ArenaUIController.set_m_onlineClashWinRateText);
		}
		LuaObject.addMember(l, name131, get131, Lua_BlackJack_ProjectL_UI_ArenaUIController.<>f__mg$cache17E, true);
		string name132 = "m_onlineClashWinCountText";
		if (Lua_BlackJack_ProjectL_UI_ArenaUIController.<>f__mg$cache17F == null)
		{
			Lua_BlackJack_ProjectL_UI_ArenaUIController.<>f__mg$cache17F = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ArenaUIController.get_m_onlineClashWinCountText);
		}
		LuaCSFunction get132 = Lua_BlackJack_ProjectL_UI_ArenaUIController.<>f__mg$cache17F;
		if (Lua_BlackJack_ProjectL_UI_ArenaUIController.<>f__mg$cache180 == null)
		{
			Lua_BlackJack_ProjectL_UI_ArenaUIController.<>f__mg$cache180 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ArenaUIController.set_m_onlineClashWinCountText);
		}
		LuaObject.addMember(l, name132, get132, Lua_BlackJack_ProjectL_UI_ArenaUIController.<>f__mg$cache180, true);
		string name133 = "m_onlineClashLoseCountText";
		if (Lua_BlackJack_ProjectL_UI_ArenaUIController.<>f__mg$cache181 == null)
		{
			Lua_BlackJack_ProjectL_UI_ArenaUIController.<>f__mg$cache181 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ArenaUIController.get_m_onlineClashLoseCountText);
		}
		LuaCSFunction get133 = Lua_BlackJack_ProjectL_UI_ArenaUIController.<>f__mg$cache181;
		if (Lua_BlackJack_ProjectL_UI_ArenaUIController.<>f__mg$cache182 == null)
		{
			Lua_BlackJack_ProjectL_UI_ArenaUIController.<>f__mg$cache182 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ArenaUIController.set_m_onlineClashLoseCountText);
		}
		LuaObject.addMember(l, name133, get133, Lua_BlackJack_ProjectL_UI_ArenaUIController.<>f__mg$cache182, true);
		string name134 = "m_onlineClashTotalCountText";
		if (Lua_BlackJack_ProjectL_UI_ArenaUIController.<>f__mg$cache183 == null)
		{
			Lua_BlackJack_ProjectL_UI_ArenaUIController.<>f__mg$cache183 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ArenaUIController.get_m_onlineClashTotalCountText);
		}
		LuaCSFunction get134 = Lua_BlackJack_ProjectL_UI_ArenaUIController.<>f__mg$cache183;
		if (Lua_BlackJack_ProjectL_UI_ArenaUIController.<>f__mg$cache184 == null)
		{
			Lua_BlackJack_ProjectL_UI_ArenaUIController.<>f__mg$cache184 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ArenaUIController.set_m_onlineClashTotalCountText);
		}
		LuaObject.addMember(l, name134, get134, Lua_BlackJack_ProjectL_UI_ArenaUIController.<>f__mg$cache184, true);
		string name135 = "m_onlineClashDanIconImage";
		if (Lua_BlackJack_ProjectL_UI_ArenaUIController.<>f__mg$cache185 == null)
		{
			Lua_BlackJack_ProjectL_UI_ArenaUIController.<>f__mg$cache185 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ArenaUIController.get_m_onlineClashDanIconImage);
		}
		LuaCSFunction get135 = Lua_BlackJack_ProjectL_UI_ArenaUIController.<>f__mg$cache185;
		if (Lua_BlackJack_ProjectL_UI_ArenaUIController.<>f__mg$cache186 == null)
		{
			Lua_BlackJack_ProjectL_UI_ArenaUIController.<>f__mg$cache186 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ArenaUIController.set_m_onlineClashDanIconImage);
		}
		LuaObject.addMember(l, name135, get135, Lua_BlackJack_ProjectL_UI_ArenaUIController.<>f__mg$cache186, true);
		string name136 = "m_onlineClashPromoteDanIconImage";
		if (Lua_BlackJack_ProjectL_UI_ArenaUIController.<>f__mg$cache187 == null)
		{
			Lua_BlackJack_ProjectL_UI_ArenaUIController.<>f__mg$cache187 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ArenaUIController.get_m_onlineClashPromoteDanIconImage);
		}
		LuaCSFunction get136 = Lua_BlackJack_ProjectL_UI_ArenaUIController.<>f__mg$cache187;
		if (Lua_BlackJack_ProjectL_UI_ArenaUIController.<>f__mg$cache188 == null)
		{
			Lua_BlackJack_ProjectL_UI_ArenaUIController.<>f__mg$cache188 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ArenaUIController.set_m_onlineClashPromoteDanIconImage);
		}
		LuaObject.addMember(l, name136, get136, Lua_BlackJack_ProjectL_UI_ArenaUIController.<>f__mg$cache188, true);
		string name137 = "m_onlineClashPromoteNextDanIconImage";
		if (Lua_BlackJack_ProjectL_UI_ArenaUIController.<>f__mg$cache189 == null)
		{
			Lua_BlackJack_ProjectL_UI_ArenaUIController.<>f__mg$cache189 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ArenaUIController.get_m_onlineClashPromoteNextDanIconImage);
		}
		LuaCSFunction get137 = Lua_BlackJack_ProjectL_UI_ArenaUIController.<>f__mg$cache189;
		if (Lua_BlackJack_ProjectL_UI_ArenaUIController.<>f__mg$cache18A == null)
		{
			Lua_BlackJack_ProjectL_UI_ArenaUIController.<>f__mg$cache18A = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ArenaUIController.set_m_onlineClashPromoteNextDanIconImage);
		}
		LuaObject.addMember(l, name137, get137, Lua_BlackJack_ProjectL_UI_ArenaUIController.<>f__mg$cache18A, true);
		string name138 = "m_onlineClashPromoteCountImage";
		if (Lua_BlackJack_ProjectL_UI_ArenaUIController.<>f__mg$cache18B == null)
		{
			Lua_BlackJack_ProjectL_UI_ArenaUIController.<>f__mg$cache18B = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ArenaUIController.get_m_onlineClashPromoteCountImage);
		}
		LuaCSFunction get138 = Lua_BlackJack_ProjectL_UI_ArenaUIController.<>f__mg$cache18B;
		if (Lua_BlackJack_ProjectL_UI_ArenaUIController.<>f__mg$cache18C == null)
		{
			Lua_BlackJack_ProjectL_UI_ArenaUIController.<>f__mg$cache18C = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ArenaUIController.set_m_onlineClashPromoteCountImage);
		}
		LuaObject.addMember(l, name138, get138, Lua_BlackJack_ProjectL_UI_ArenaUIController.<>f__mg$cache18C, true);
		string name139 = "m_onlineClashPromoteRoundGroupGameObject";
		if (Lua_BlackJack_ProjectL_UI_ArenaUIController.<>f__mg$cache18D == null)
		{
			Lua_BlackJack_ProjectL_UI_ArenaUIController.<>f__mg$cache18D = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ArenaUIController.get_m_onlineClashPromoteRoundGroupGameObject);
		}
		LuaCSFunction get139 = Lua_BlackJack_ProjectL_UI_ArenaUIController.<>f__mg$cache18D;
		if (Lua_BlackJack_ProjectL_UI_ArenaUIController.<>f__mg$cache18E == null)
		{
			Lua_BlackJack_ProjectL_UI_ArenaUIController.<>f__mg$cache18E = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ArenaUIController.set_m_onlineClashPromoteRoundGroupGameObject);
		}
		LuaObject.addMember(l, name139, get139, Lua_BlackJack_ProjectL_UI_ArenaUIController.<>f__mg$cache18E, true);
		string name140 = "m_onlineClashLadderOpenTimeGameObject";
		if (Lua_BlackJack_ProjectL_UI_ArenaUIController.<>f__mg$cache18F == null)
		{
			Lua_BlackJack_ProjectL_UI_ArenaUIController.<>f__mg$cache18F = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ArenaUIController.get_m_onlineClashLadderOpenTimeGameObject);
		}
		LuaCSFunction get140 = Lua_BlackJack_ProjectL_UI_ArenaUIController.<>f__mg$cache18F;
		if (Lua_BlackJack_ProjectL_UI_ArenaUIController.<>f__mg$cache190 == null)
		{
			Lua_BlackJack_ProjectL_UI_ArenaUIController.<>f__mg$cache190 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ArenaUIController.set_m_onlineClashLadderOpenTimeGameObject);
		}
		LuaObject.addMember(l, name140, get140, Lua_BlackJack_ProjectL_UI_ArenaUIController.<>f__mg$cache190, true);
		string name141 = "m_onlineClashLadderOpenTimeText";
		if (Lua_BlackJack_ProjectL_UI_ArenaUIController.<>f__mg$cache191 == null)
		{
			Lua_BlackJack_ProjectL_UI_ArenaUIController.<>f__mg$cache191 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ArenaUIController.get_m_onlineClashLadderOpenTimeText);
		}
		LuaCSFunction get141 = Lua_BlackJack_ProjectL_UI_ArenaUIController.<>f__mg$cache191;
		if (Lua_BlackJack_ProjectL_UI_ArenaUIController.<>f__mg$cache192 == null)
		{
			Lua_BlackJack_ProjectL_UI_ArenaUIController.<>f__mg$cache192 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ArenaUIController.set_m_onlineClashLadderOpenTimeText);
		}
		LuaObject.addMember(l, name141, get141, Lua_BlackJack_ProjectL_UI_ArenaUIController.<>f__mg$cache192, true);
		string name142 = "m_onlineClashLadderChallengeButton";
		if (Lua_BlackJack_ProjectL_UI_ArenaUIController.<>f__mg$cache193 == null)
		{
			Lua_BlackJack_ProjectL_UI_ArenaUIController.<>f__mg$cache193 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ArenaUIController.get_m_onlineClashLadderChallengeButton);
		}
		LuaCSFunction get142 = Lua_BlackJack_ProjectL_UI_ArenaUIController.<>f__mg$cache193;
		if (Lua_BlackJack_ProjectL_UI_ArenaUIController.<>f__mg$cache194 == null)
		{
			Lua_BlackJack_ProjectL_UI_ArenaUIController.<>f__mg$cache194 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ArenaUIController.set_m_onlineClashLadderChallengeButton);
		}
		LuaObject.addMember(l, name142, get142, Lua_BlackJack_ProjectL_UI_ArenaUIController.<>f__mg$cache194, true);
		string name143 = "m_onlineClashLadderChallengeButtonUIStateController";
		if (Lua_BlackJack_ProjectL_UI_ArenaUIController.<>f__mg$cache195 == null)
		{
			Lua_BlackJack_ProjectL_UI_ArenaUIController.<>f__mg$cache195 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ArenaUIController.get_m_onlineClashLadderChallengeButtonUIStateController);
		}
		LuaCSFunction get143 = Lua_BlackJack_ProjectL_UI_ArenaUIController.<>f__mg$cache195;
		if (Lua_BlackJack_ProjectL_UI_ArenaUIController.<>f__mg$cache196 == null)
		{
			Lua_BlackJack_ProjectL_UI_ArenaUIController.<>f__mg$cache196 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ArenaUIController.set_m_onlineClashLadderChallengeButtonUIStateController);
		}
		LuaObject.addMember(l, name143, get143, Lua_BlackJack_ProjectL_UI_ArenaUIController.<>f__mg$cache196, true);
		string name144 = "m_onlineClashCasualChallengeButton";
		if (Lua_BlackJack_ProjectL_UI_ArenaUIController.<>f__mg$cache197 == null)
		{
			Lua_BlackJack_ProjectL_UI_ArenaUIController.<>f__mg$cache197 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ArenaUIController.get_m_onlineClashCasualChallengeButton);
		}
		LuaCSFunction get144 = Lua_BlackJack_ProjectL_UI_ArenaUIController.<>f__mg$cache197;
		if (Lua_BlackJack_ProjectL_UI_ArenaUIController.<>f__mg$cache198 == null)
		{
			Lua_BlackJack_ProjectL_UI_ArenaUIController.<>f__mg$cache198 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ArenaUIController.set_m_onlineClashCasualChallengeButton);
		}
		LuaObject.addMember(l, name144, get144, Lua_BlackJack_ProjectL_UI_ArenaUIController.<>f__mg$cache198, true);
		string name145 = "m_onlineBattleReportPanelGameObject";
		if (Lua_BlackJack_ProjectL_UI_ArenaUIController.<>f__mg$cache199 == null)
		{
			Lua_BlackJack_ProjectL_UI_ArenaUIController.<>f__mg$cache199 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ArenaUIController.get_m_onlineBattleReportPanelGameObject);
		}
		LuaCSFunction get145 = Lua_BlackJack_ProjectL_UI_ArenaUIController.<>f__mg$cache199;
		if (Lua_BlackJack_ProjectL_UI_ArenaUIController.<>f__mg$cache19A == null)
		{
			Lua_BlackJack_ProjectL_UI_ArenaUIController.<>f__mg$cache19A = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ArenaUIController.set_m_onlineBattleReportPanelGameObject);
		}
		LuaObject.addMember(l, name145, get145, Lua_BlackJack_ProjectL_UI_ArenaUIController.<>f__mg$cache19A, true);
		string name146 = "m_onlineBattleReportScrollRect";
		if (Lua_BlackJack_ProjectL_UI_ArenaUIController.<>f__mg$cache19B == null)
		{
			Lua_BlackJack_ProjectL_UI_ArenaUIController.<>f__mg$cache19B = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ArenaUIController.get_m_onlineBattleReportScrollRect);
		}
		LuaCSFunction get146 = Lua_BlackJack_ProjectL_UI_ArenaUIController.<>f__mg$cache19B;
		if (Lua_BlackJack_ProjectL_UI_ArenaUIController.<>f__mg$cache19C == null)
		{
			Lua_BlackJack_ProjectL_UI_ArenaUIController.<>f__mg$cache19C = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ArenaUIController.set_m_onlineBattleReportScrollRect);
		}
		LuaObject.addMember(l, name146, get146, Lua_BlackJack_ProjectL_UI_ArenaUIController.<>f__mg$cache19C, true);
		string name147 = "m_onlineNoBattleReportGameObject";
		if (Lua_BlackJack_ProjectL_UI_ArenaUIController.<>f__mg$cache19D == null)
		{
			Lua_BlackJack_ProjectL_UI_ArenaUIController.<>f__mg$cache19D = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ArenaUIController.get_m_onlineNoBattleReportGameObject);
		}
		LuaCSFunction get147 = Lua_BlackJack_ProjectL_UI_ArenaUIController.<>f__mg$cache19D;
		if (Lua_BlackJack_ProjectL_UI_ArenaUIController.<>f__mg$cache19E == null)
		{
			Lua_BlackJack_ProjectL_UI_ArenaUIController.<>f__mg$cache19E = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ArenaUIController.set_m_onlineNoBattleReportGameObject);
		}
		LuaObject.addMember(l, name147, get147, Lua_BlackJack_ProjectL_UI_ArenaUIController.<>f__mg$cache19E, true);
		string name148 = "m_onlineDanPanelGameObject";
		if (Lua_BlackJack_ProjectL_UI_ArenaUIController.<>f__mg$cache19F == null)
		{
			Lua_BlackJack_ProjectL_UI_ArenaUIController.<>f__mg$cache19F = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ArenaUIController.get_m_onlineDanPanelGameObject);
		}
		LuaCSFunction get148 = Lua_BlackJack_ProjectL_UI_ArenaUIController.<>f__mg$cache19F;
		if (Lua_BlackJack_ProjectL_UI_ArenaUIController.<>f__mg$cache1A0 == null)
		{
			Lua_BlackJack_ProjectL_UI_ArenaUIController.<>f__mg$cache1A0 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ArenaUIController.set_m_onlineDanPanelGameObject);
		}
		LuaObject.addMember(l, name148, get148, Lua_BlackJack_ProjectL_UI_ArenaUIController.<>f__mg$cache1A0, true);
		string name149 = "m_onlineArenaLevelScrollRect";
		if (Lua_BlackJack_ProjectL_UI_ArenaUIController.<>f__mg$cache1A1 == null)
		{
			Lua_BlackJack_ProjectL_UI_ArenaUIController.<>f__mg$cache1A1 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ArenaUIController.get_m_onlineArenaLevelScrollRect);
		}
		LuaCSFunction get149 = Lua_BlackJack_ProjectL_UI_ArenaUIController.<>f__mg$cache1A1;
		if (Lua_BlackJack_ProjectL_UI_ArenaUIController.<>f__mg$cache1A2 == null)
		{
			Lua_BlackJack_ProjectL_UI_ArenaUIController.<>f__mg$cache1A2 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ArenaUIController.set_m_onlineArenaLevelScrollRect);
		}
		LuaObject.addMember(l, name149, get149, Lua_BlackJack_ProjectL_UI_ArenaUIController.<>f__mg$cache1A2, true);
		string name150 = "m_onlineRankingPanelGameObject";
		if (Lua_BlackJack_ProjectL_UI_ArenaUIController.<>f__mg$cache1A3 == null)
		{
			Lua_BlackJack_ProjectL_UI_ArenaUIController.<>f__mg$cache1A3 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ArenaUIController.get_m_onlineRankingPanelGameObject);
		}
		LuaCSFunction get150 = Lua_BlackJack_ProjectL_UI_ArenaUIController.<>f__mg$cache1A3;
		if (Lua_BlackJack_ProjectL_UI_ArenaUIController.<>f__mg$cache1A4 == null)
		{
			Lua_BlackJack_ProjectL_UI_ArenaUIController.<>f__mg$cache1A4 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ArenaUIController.set_m_onlineRankingPanelGameObject);
		}
		LuaObject.addMember(l, name150, get150, Lua_BlackJack_ProjectL_UI_ArenaUIController.<>f__mg$cache1A4, true);
		string name151 = "m_onlineRankingScrollRect";
		if (Lua_BlackJack_ProjectL_UI_ArenaUIController.<>f__mg$cache1A5 == null)
		{
			Lua_BlackJack_ProjectL_UI_ArenaUIController.<>f__mg$cache1A5 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ArenaUIController.get_m_onlineRankingScrollRect);
		}
		LuaCSFunction get151 = Lua_BlackJack_ProjectL_UI_ArenaUIController.<>f__mg$cache1A5;
		if (Lua_BlackJack_ProjectL_UI_ArenaUIController.<>f__mg$cache1A6 == null)
		{
			Lua_BlackJack_ProjectL_UI_ArenaUIController.<>f__mg$cache1A6 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ArenaUIController.set_m_onlineRankingScrollRect);
		}
		LuaObject.addMember(l, name151, get151, Lua_BlackJack_ProjectL_UI_ArenaUIController.<>f__mg$cache1A6, true);
		string name152 = "m_onlineRankingPlayerNameText";
		if (Lua_BlackJack_ProjectL_UI_ArenaUIController.<>f__mg$cache1A7 == null)
		{
			Lua_BlackJack_ProjectL_UI_ArenaUIController.<>f__mg$cache1A7 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ArenaUIController.get_m_onlineRankingPlayerNameText);
		}
		LuaCSFunction get152 = Lua_BlackJack_ProjectL_UI_ArenaUIController.<>f__mg$cache1A7;
		if (Lua_BlackJack_ProjectL_UI_ArenaUIController.<>f__mg$cache1A8 == null)
		{
			Lua_BlackJack_ProjectL_UI_ArenaUIController.<>f__mg$cache1A8 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ArenaUIController.set_m_onlineRankingPlayerNameText);
		}
		LuaObject.addMember(l, name152, get152, Lua_BlackJack_ProjectL_UI_ArenaUIController.<>f__mg$cache1A8, true);
		string name153 = "m_onlineRankingPlayerRankingUIStateController";
		if (Lua_BlackJack_ProjectL_UI_ArenaUIController.<>f__mg$cache1A9 == null)
		{
			Lua_BlackJack_ProjectL_UI_ArenaUIController.<>f__mg$cache1A9 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ArenaUIController.get_m_onlineRankingPlayerRankingUIStateController);
		}
		LuaCSFunction get153 = Lua_BlackJack_ProjectL_UI_ArenaUIController.<>f__mg$cache1A9;
		if (Lua_BlackJack_ProjectL_UI_ArenaUIController.<>f__mg$cache1AA == null)
		{
			Lua_BlackJack_ProjectL_UI_ArenaUIController.<>f__mg$cache1AA = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ArenaUIController.set_m_onlineRankingPlayerRankingUIStateController);
		}
		LuaObject.addMember(l, name153, get153, Lua_BlackJack_ProjectL_UI_ArenaUIController.<>f__mg$cache1AA, true);
		string name154 = "m_onlineRankingPlayerRankingText";
		if (Lua_BlackJack_ProjectL_UI_ArenaUIController.<>f__mg$cache1AB == null)
		{
			Lua_BlackJack_ProjectL_UI_ArenaUIController.<>f__mg$cache1AB = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ArenaUIController.get_m_onlineRankingPlayerRankingText);
		}
		LuaCSFunction get154 = Lua_BlackJack_ProjectL_UI_ArenaUIController.<>f__mg$cache1AB;
		if (Lua_BlackJack_ProjectL_UI_ArenaUIController.<>f__mg$cache1AC == null)
		{
			Lua_BlackJack_ProjectL_UI_ArenaUIController.<>f__mg$cache1AC = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ArenaUIController.set_m_onlineRankingPlayerRankingText);
		}
		LuaObject.addMember(l, name154, get154, Lua_BlackJack_ProjectL_UI_ArenaUIController.<>f__mg$cache1AC, true);
		string name155 = "m_onlineRankingPlayerRankingImage";
		if (Lua_BlackJack_ProjectL_UI_ArenaUIController.<>f__mg$cache1AD == null)
		{
			Lua_BlackJack_ProjectL_UI_ArenaUIController.<>f__mg$cache1AD = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ArenaUIController.get_m_onlineRankingPlayerRankingImage);
		}
		LuaCSFunction get155 = Lua_BlackJack_ProjectL_UI_ArenaUIController.<>f__mg$cache1AD;
		if (Lua_BlackJack_ProjectL_UI_ArenaUIController.<>f__mg$cache1AE == null)
		{
			Lua_BlackJack_ProjectL_UI_ArenaUIController.<>f__mg$cache1AE = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ArenaUIController.set_m_onlineRankingPlayerRankingImage);
		}
		LuaObject.addMember(l, name155, get155, Lua_BlackJack_ProjectL_UI_ArenaUIController.<>f__mg$cache1AE, true);
		string name156 = "m_onlineRankingArenaPointsText";
		if (Lua_BlackJack_ProjectL_UI_ArenaUIController.<>f__mg$cache1AF == null)
		{
			Lua_BlackJack_ProjectL_UI_ArenaUIController.<>f__mg$cache1AF = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ArenaUIController.get_m_onlineRankingArenaPointsText);
		}
		LuaCSFunction get156 = Lua_BlackJack_ProjectL_UI_ArenaUIController.<>f__mg$cache1AF;
		if (Lua_BlackJack_ProjectL_UI_ArenaUIController.<>f__mg$cache1B0 == null)
		{
			Lua_BlackJack_ProjectL_UI_ArenaUIController.<>f__mg$cache1B0 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ArenaUIController.set_m_onlineRankingArenaPointsText);
		}
		LuaObject.addMember(l, name156, get156, Lua_BlackJack_ProjectL_UI_ArenaUIController.<>f__mg$cache1B0, true);
		string name157 = "m_onlineRankingPlayerIconImage";
		if (Lua_BlackJack_ProjectL_UI_ArenaUIController.<>f__mg$cache1B1 == null)
		{
			Lua_BlackJack_ProjectL_UI_ArenaUIController.<>f__mg$cache1B1 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ArenaUIController.get_m_onlineRankingPlayerIconImage);
		}
		LuaCSFunction get157 = Lua_BlackJack_ProjectL_UI_ArenaUIController.<>f__mg$cache1B1;
		if (Lua_BlackJack_ProjectL_UI_ArenaUIController.<>f__mg$cache1B2 == null)
		{
			Lua_BlackJack_ProjectL_UI_ArenaUIController.<>f__mg$cache1B2 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ArenaUIController.set_m_onlineRankingPlayerIconImage);
		}
		LuaObject.addMember(l, name157, get157, Lua_BlackJack_ProjectL_UI_ArenaUIController.<>f__mg$cache1B2, true);
		string name158 = "m_onlineRankingPlayerHeadFrameTransform";
		if (Lua_BlackJack_ProjectL_UI_ArenaUIController.<>f__mg$cache1B3 == null)
		{
			Lua_BlackJack_ProjectL_UI_ArenaUIController.<>f__mg$cache1B3 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ArenaUIController.get_m_onlineRankingPlayerHeadFrameTransform);
		}
		LuaCSFunction get158 = Lua_BlackJack_ProjectL_UI_ArenaUIController.<>f__mg$cache1B3;
		if (Lua_BlackJack_ProjectL_UI_ArenaUIController.<>f__mg$cache1B4 == null)
		{
			Lua_BlackJack_ProjectL_UI_ArenaUIController.<>f__mg$cache1B4 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ArenaUIController.set_m_onlineRankingPlayerHeadFrameTransform);
		}
		LuaObject.addMember(l, name158, get158, Lua_BlackJack_ProjectL_UI_ArenaUIController.<>f__mg$cache1B4, true);
		string name159 = "m_onlineRankingPlayerLevelText";
		if (Lua_BlackJack_ProjectL_UI_ArenaUIController.<>f__mg$cache1B5 == null)
		{
			Lua_BlackJack_ProjectL_UI_ArenaUIController.<>f__mg$cache1B5 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ArenaUIController.get_m_onlineRankingPlayerLevelText);
		}
		LuaCSFunction get159 = Lua_BlackJack_ProjectL_UI_ArenaUIController.<>f__mg$cache1B5;
		if (Lua_BlackJack_ProjectL_UI_ArenaUIController.<>f__mg$cache1B6 == null)
		{
			Lua_BlackJack_ProjectL_UI_ArenaUIController.<>f__mg$cache1B6 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ArenaUIController.set_m_onlineRankingPlayerLevelText);
		}
		LuaObject.addMember(l, name159, get159, Lua_BlackJack_ProjectL_UI_ArenaUIController.<>f__mg$cache1B6, true);
		string name160 = "m_onlinePlayerIconImage";
		if (Lua_BlackJack_ProjectL_UI_ArenaUIController.<>f__mg$cache1B7 == null)
		{
			Lua_BlackJack_ProjectL_UI_ArenaUIController.<>f__mg$cache1B7 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ArenaUIController.get_m_onlinePlayerIconImage);
		}
		LuaCSFunction get160 = Lua_BlackJack_ProjectL_UI_ArenaUIController.<>f__mg$cache1B7;
		if (Lua_BlackJack_ProjectL_UI_ArenaUIController.<>f__mg$cache1B8 == null)
		{
			Lua_BlackJack_ProjectL_UI_ArenaUIController.<>f__mg$cache1B8 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ArenaUIController.set_m_onlinePlayerIconImage);
		}
		LuaObject.addMember(l, name160, get160, Lua_BlackJack_ProjectL_UI_ArenaUIController.<>f__mg$cache1B8, true);
		string name161 = "m_onlinePlayerNameText";
		if (Lua_BlackJack_ProjectL_UI_ArenaUIController.<>f__mg$cache1B9 == null)
		{
			Lua_BlackJack_ProjectL_UI_ArenaUIController.<>f__mg$cache1B9 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ArenaUIController.get_m_onlinePlayerNameText);
		}
		LuaCSFunction get161 = Lua_BlackJack_ProjectL_UI_ArenaUIController.<>f__mg$cache1B9;
		if (Lua_BlackJack_ProjectL_UI_ArenaUIController.<>f__mg$cache1BA == null)
		{
			Lua_BlackJack_ProjectL_UI_ArenaUIController.<>f__mg$cache1BA = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ArenaUIController.set_m_onlinePlayerNameText);
		}
		LuaObject.addMember(l, name161, get161, Lua_BlackJack_ProjectL_UI_ArenaUIController.<>f__mg$cache1BA, true);
		string name162 = "m_onlineDanText";
		if (Lua_BlackJack_ProjectL_UI_ArenaUIController.<>f__mg$cache1BB == null)
		{
			Lua_BlackJack_ProjectL_UI_ArenaUIController.<>f__mg$cache1BB = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ArenaUIController.get_m_onlineDanText);
		}
		LuaCSFunction get162 = Lua_BlackJack_ProjectL_UI_ArenaUIController.<>f__mg$cache1BB;
		if (Lua_BlackJack_ProjectL_UI_ArenaUIController.<>f__mg$cache1BC == null)
		{
			Lua_BlackJack_ProjectL_UI_ArenaUIController.<>f__mg$cache1BC = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ArenaUIController.set_m_onlineDanText);
		}
		LuaObject.addMember(l, name162, get162, Lua_BlackJack_ProjectL_UI_ArenaUIController.<>f__mg$cache1BC, true);
		string name163 = "m_onlineDanIconImage";
		if (Lua_BlackJack_ProjectL_UI_ArenaUIController.<>f__mg$cache1BD == null)
		{
			Lua_BlackJack_ProjectL_UI_ArenaUIController.<>f__mg$cache1BD = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ArenaUIController.get_m_onlineDanIconImage);
		}
		LuaCSFunction get163 = Lua_BlackJack_ProjectL_UI_ArenaUIController.<>f__mg$cache1BD;
		if (Lua_BlackJack_ProjectL_UI_ArenaUIController.<>f__mg$cache1BE == null)
		{
			Lua_BlackJack_ProjectL_UI_ArenaUIController.<>f__mg$cache1BE = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ArenaUIController.set_m_onlineDanIconImage);
		}
		LuaObject.addMember(l, name163, get163, Lua_BlackJack_ProjectL_UI_ArenaUIController.<>f__mg$cache1BE, true);
		string name164 = "m_onlinePlayerLevelText";
		if (Lua_BlackJack_ProjectL_UI_ArenaUIController.<>f__mg$cache1BF == null)
		{
			Lua_BlackJack_ProjectL_UI_ArenaUIController.<>f__mg$cache1BF = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ArenaUIController.get_m_onlinePlayerLevelText);
		}
		LuaCSFunction get164 = Lua_BlackJack_ProjectL_UI_ArenaUIController.<>f__mg$cache1BF;
		if (Lua_BlackJack_ProjectL_UI_ArenaUIController.<>f__mg$cache1C0 == null)
		{
			Lua_BlackJack_ProjectL_UI_ArenaUIController.<>f__mg$cache1C0 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ArenaUIController.set_m_onlinePlayerLevelText);
		}
		LuaObject.addMember(l, name164, get164, Lua_BlackJack_ProjectL_UI_ArenaUIController.<>f__mg$cache1C0, true);
		string name165 = "m_onlineArenaPointsText";
		if (Lua_BlackJack_ProjectL_UI_ArenaUIController.<>f__mg$cache1C1 == null)
		{
			Lua_BlackJack_ProjectL_UI_ArenaUIController.<>f__mg$cache1C1 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ArenaUIController.get_m_onlineArenaPointsText);
		}
		LuaCSFunction get165 = Lua_BlackJack_ProjectL_UI_ArenaUIController.<>f__mg$cache1C1;
		if (Lua_BlackJack_ProjectL_UI_ArenaUIController.<>f__mg$cache1C2 == null)
		{
			Lua_BlackJack_ProjectL_UI_ArenaUIController.<>f__mg$cache1C2 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ArenaUIController.set_m_onlineArenaPointsText);
		}
		LuaObject.addMember(l, name165, get165, Lua_BlackJack_ProjectL_UI_ArenaUIController.<>f__mg$cache1C2, true);
		string name166 = "m_onlineArenaPointsUpText1";
		if (Lua_BlackJack_ProjectL_UI_ArenaUIController.<>f__mg$cache1C3 == null)
		{
			Lua_BlackJack_ProjectL_UI_ArenaUIController.<>f__mg$cache1C3 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ArenaUIController.get_m_onlineArenaPointsUpText1);
		}
		LuaCSFunction get166 = Lua_BlackJack_ProjectL_UI_ArenaUIController.<>f__mg$cache1C3;
		if (Lua_BlackJack_ProjectL_UI_ArenaUIController.<>f__mg$cache1C4 == null)
		{
			Lua_BlackJack_ProjectL_UI_ArenaUIController.<>f__mg$cache1C4 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ArenaUIController.set_m_onlineArenaPointsUpText1);
		}
		LuaObject.addMember(l, name166, get166, Lua_BlackJack_ProjectL_UI_ArenaUIController.<>f__mg$cache1C4, true);
		string name167 = "m_onlineArenaPointsUpText2";
		if (Lua_BlackJack_ProjectL_UI_ArenaUIController.<>f__mg$cache1C5 == null)
		{
			Lua_BlackJack_ProjectL_UI_ArenaUIController.<>f__mg$cache1C5 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ArenaUIController.get_m_onlineArenaPointsUpText2);
		}
		LuaCSFunction get167 = Lua_BlackJack_ProjectL_UI_ArenaUIController.<>f__mg$cache1C5;
		if (Lua_BlackJack_ProjectL_UI_ArenaUIController.<>f__mg$cache1C6 == null)
		{
			Lua_BlackJack_ProjectL_UI_ArenaUIController.<>f__mg$cache1C6 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ArenaUIController.set_m_onlineArenaPointsUpText2);
		}
		LuaObject.addMember(l, name167, get167, Lua_BlackJack_ProjectL_UI_ArenaUIController.<>f__mg$cache1C6, true);
		string name168 = "m_onlineArenaPointsUpBarImage";
		if (Lua_BlackJack_ProjectL_UI_ArenaUIController.<>f__mg$cache1C7 == null)
		{
			Lua_BlackJack_ProjectL_UI_ArenaUIController.<>f__mg$cache1C7 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ArenaUIController.get_m_onlineArenaPointsUpBarImage);
		}
		LuaCSFunction get168 = Lua_BlackJack_ProjectL_UI_ArenaUIController.<>f__mg$cache1C7;
		if (Lua_BlackJack_ProjectL_UI_ArenaUIController.<>f__mg$cache1C8 == null)
		{
			Lua_BlackJack_ProjectL_UI_ArenaUIController.<>f__mg$cache1C8 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ArenaUIController.set_m_onlineArenaPointsUpBarImage);
		}
		LuaObject.addMember(l, name168, get168, Lua_BlackJack_ProjectL_UI_ArenaUIController.<>f__mg$cache1C8, true);
		string name169 = "m_onlineArenaRankingRewardButton";
		if (Lua_BlackJack_ProjectL_UI_ArenaUIController.<>f__mg$cache1C9 == null)
		{
			Lua_BlackJack_ProjectL_UI_ArenaUIController.<>f__mg$cache1C9 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ArenaUIController.get_m_onlineArenaRankingRewardButton);
		}
		LuaCSFunction get169 = Lua_BlackJack_ProjectL_UI_ArenaUIController.<>f__mg$cache1C9;
		if (Lua_BlackJack_ProjectL_UI_ArenaUIController.<>f__mg$cache1CA == null)
		{
			Lua_BlackJack_ProjectL_UI_ArenaUIController.<>f__mg$cache1CA = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ArenaUIController.set_m_onlineArenaRankingRewardButton);
		}
		LuaObject.addMember(l, name169, get169, Lua_BlackJack_ProjectL_UI_ArenaUIController.<>f__mg$cache1CA, true);
		string name170 = "m_onlineWeekWinText";
		if (Lua_BlackJack_ProjectL_UI_ArenaUIController.<>f__mg$cache1CB == null)
		{
			Lua_BlackJack_ProjectL_UI_ArenaUIController.<>f__mg$cache1CB = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ArenaUIController.get_m_onlineWeekWinText);
		}
		LuaCSFunction get170 = Lua_BlackJack_ProjectL_UI_ArenaUIController.<>f__mg$cache1CB;
		if (Lua_BlackJack_ProjectL_UI_ArenaUIController.<>f__mg$cache1CC == null)
		{
			Lua_BlackJack_ProjectL_UI_ArenaUIController.<>f__mg$cache1CC = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ArenaUIController.set_m_onlineWeekWinText);
		}
		LuaObject.addMember(l, name170, get170, Lua_BlackJack_ProjectL_UI_ArenaUIController.<>f__mg$cache1CC, true);
		string name171 = "m_onlineWeekWinRewardButton1GameObject";
		if (Lua_BlackJack_ProjectL_UI_ArenaUIController.<>f__mg$cache1CD == null)
		{
			Lua_BlackJack_ProjectL_UI_ArenaUIController.<>f__mg$cache1CD = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ArenaUIController.get_m_onlineWeekWinRewardButton1GameObject);
		}
		LuaCSFunction get171 = Lua_BlackJack_ProjectL_UI_ArenaUIController.<>f__mg$cache1CD;
		if (Lua_BlackJack_ProjectL_UI_ArenaUIController.<>f__mg$cache1CE == null)
		{
			Lua_BlackJack_ProjectL_UI_ArenaUIController.<>f__mg$cache1CE = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ArenaUIController.set_m_onlineWeekWinRewardButton1GameObject);
		}
		LuaObject.addMember(l, name171, get171, Lua_BlackJack_ProjectL_UI_ArenaUIController.<>f__mg$cache1CE, true);
		string name172 = "m_onlineWeekWinRewardButton2GameObject";
		if (Lua_BlackJack_ProjectL_UI_ArenaUIController.<>f__mg$cache1CF == null)
		{
			Lua_BlackJack_ProjectL_UI_ArenaUIController.<>f__mg$cache1CF = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ArenaUIController.get_m_onlineWeekWinRewardButton2GameObject);
		}
		LuaCSFunction get172 = Lua_BlackJack_ProjectL_UI_ArenaUIController.<>f__mg$cache1CF;
		if (Lua_BlackJack_ProjectL_UI_ArenaUIController.<>f__mg$cache1D0 == null)
		{
			Lua_BlackJack_ProjectL_UI_ArenaUIController.<>f__mg$cache1D0 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ArenaUIController.set_m_onlineWeekWinRewardButton2GameObject);
		}
		LuaObject.addMember(l, name172, get172, Lua_BlackJack_ProjectL_UI_ArenaUIController.<>f__mg$cache1D0, true);
		string name173 = "m_onlineWeekWinRewardButton3GameObject";
		if (Lua_BlackJack_ProjectL_UI_ArenaUIController.<>f__mg$cache1D1 == null)
		{
			Lua_BlackJack_ProjectL_UI_ArenaUIController.<>f__mg$cache1D1 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ArenaUIController.get_m_onlineWeekWinRewardButton3GameObject);
		}
		LuaCSFunction get173 = Lua_BlackJack_ProjectL_UI_ArenaUIController.<>f__mg$cache1D1;
		if (Lua_BlackJack_ProjectL_UI_ArenaUIController.<>f__mg$cache1D2 == null)
		{
			Lua_BlackJack_ProjectL_UI_ArenaUIController.<>f__mg$cache1D2 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ArenaUIController.set_m_onlineWeekWinRewardButton3GameObject);
		}
		LuaObject.addMember(l, name173, get173, Lua_BlackJack_ProjectL_UI_ArenaUIController.<>f__mg$cache1D2, true);
		string name174 = "m_onlineWeekWinRewardImage";
		if (Lua_BlackJack_ProjectL_UI_ArenaUIController.<>f__mg$cache1D3 == null)
		{
			Lua_BlackJack_ProjectL_UI_ArenaUIController.<>f__mg$cache1D3 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ArenaUIController.get_m_onlineWeekWinRewardImage);
		}
		LuaCSFunction get174 = Lua_BlackJack_ProjectL_UI_ArenaUIController.<>f__mg$cache1D3;
		if (Lua_BlackJack_ProjectL_UI_ArenaUIController.<>f__mg$cache1D4 == null)
		{
			Lua_BlackJack_ProjectL_UI_ArenaUIController.<>f__mg$cache1D4 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ArenaUIController.set_m_onlineWeekWinRewardImage);
		}
		LuaObject.addMember(l, name174, get174, Lua_BlackJack_ProjectL_UI_ArenaUIController.<>f__mg$cache1D4, true);
		string name175 = "m_promoteBattleUIStateController";
		if (Lua_BlackJack_ProjectL_UI_ArenaUIController.<>f__mg$cache1D5 == null)
		{
			Lua_BlackJack_ProjectL_UI_ArenaUIController.<>f__mg$cache1D5 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ArenaUIController.get_m_promoteBattleUIStateController);
		}
		LuaCSFunction get175 = Lua_BlackJack_ProjectL_UI_ArenaUIController.<>f__mg$cache1D5;
		if (Lua_BlackJack_ProjectL_UI_ArenaUIController.<>f__mg$cache1D6 == null)
		{
			Lua_BlackJack_ProjectL_UI_ArenaUIController.<>f__mg$cache1D6 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ArenaUIController.set_m_promoteBattleUIStateController);
		}
		LuaObject.addMember(l, name175, get175, Lua_BlackJack_ProjectL_UI_ArenaUIController.<>f__mg$cache1D6, true);
		string name176 = "m_promoteBattleBGButton";
		if (Lua_BlackJack_ProjectL_UI_ArenaUIController.<>f__mg$cache1D7 == null)
		{
			Lua_BlackJack_ProjectL_UI_ArenaUIController.<>f__mg$cache1D7 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ArenaUIController.get_m_promoteBattleBGButton);
		}
		LuaCSFunction get176 = Lua_BlackJack_ProjectL_UI_ArenaUIController.<>f__mg$cache1D7;
		if (Lua_BlackJack_ProjectL_UI_ArenaUIController.<>f__mg$cache1D8 == null)
		{
			Lua_BlackJack_ProjectL_UI_ArenaUIController.<>f__mg$cache1D8 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ArenaUIController.set_m_promoteBattleBGButton);
		}
		LuaObject.addMember(l, name176, get176, Lua_BlackJack_ProjectL_UI_ArenaUIController.<>f__mg$cache1D8, true);
		string name177 = "m_promoteBattleText";
		if (Lua_BlackJack_ProjectL_UI_ArenaUIController.<>f__mg$cache1D9 == null)
		{
			Lua_BlackJack_ProjectL_UI_ArenaUIController.<>f__mg$cache1D9 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ArenaUIController.get_m_promoteBattleText);
		}
		LuaCSFunction get177 = Lua_BlackJack_ProjectL_UI_ArenaUIController.<>f__mg$cache1D9;
		if (Lua_BlackJack_ProjectL_UI_ArenaUIController.<>f__mg$cache1DA == null)
		{
			Lua_BlackJack_ProjectL_UI_ArenaUIController.<>f__mg$cache1DA = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ArenaUIController.set_m_promoteBattleText);
		}
		LuaObject.addMember(l, name177, get177, Lua_BlackJack_ProjectL_UI_ArenaUIController.<>f__mg$cache1DA, true);
		string name178 = "m_promoteBattleConfirmButton";
		if (Lua_BlackJack_ProjectL_UI_ArenaUIController.<>f__mg$cache1DB == null)
		{
			Lua_BlackJack_ProjectL_UI_ArenaUIController.<>f__mg$cache1DB = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ArenaUIController.get_m_promoteBattleConfirmButton);
		}
		LuaCSFunction get178 = Lua_BlackJack_ProjectL_UI_ArenaUIController.<>f__mg$cache1DB;
		if (Lua_BlackJack_ProjectL_UI_ArenaUIController.<>f__mg$cache1DC == null)
		{
			Lua_BlackJack_ProjectL_UI_ArenaUIController.<>f__mg$cache1DC = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ArenaUIController.set_m_promoteBattleConfirmButton);
		}
		LuaObject.addMember(l, name178, get178, Lua_BlackJack_ProjectL_UI_ArenaUIController.<>f__mg$cache1DC, true);
		string name179 = "m_promoteSucceedUIStateController";
		if (Lua_BlackJack_ProjectL_UI_ArenaUIController.<>f__mg$cache1DD == null)
		{
			Lua_BlackJack_ProjectL_UI_ArenaUIController.<>f__mg$cache1DD = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ArenaUIController.get_m_promoteSucceedUIStateController);
		}
		LuaCSFunction get179 = Lua_BlackJack_ProjectL_UI_ArenaUIController.<>f__mg$cache1DD;
		if (Lua_BlackJack_ProjectL_UI_ArenaUIController.<>f__mg$cache1DE == null)
		{
			Lua_BlackJack_ProjectL_UI_ArenaUIController.<>f__mg$cache1DE = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ArenaUIController.set_m_promoteSucceedUIStateController);
		}
		LuaObject.addMember(l, name179, get179, Lua_BlackJack_ProjectL_UI_ArenaUIController.<>f__mg$cache1DE, true);
		string name180 = "m_promoteSucceedBGButton";
		if (Lua_BlackJack_ProjectL_UI_ArenaUIController.<>f__mg$cache1DF == null)
		{
			Lua_BlackJack_ProjectL_UI_ArenaUIController.<>f__mg$cache1DF = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ArenaUIController.get_m_promoteSucceedBGButton);
		}
		LuaCSFunction get180 = Lua_BlackJack_ProjectL_UI_ArenaUIController.<>f__mg$cache1DF;
		if (Lua_BlackJack_ProjectL_UI_ArenaUIController.<>f__mg$cache1E0 == null)
		{
			Lua_BlackJack_ProjectL_UI_ArenaUIController.<>f__mg$cache1E0 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ArenaUIController.set_m_promoteSucceedBGButton);
		}
		LuaObject.addMember(l, name180, get180, Lua_BlackJack_ProjectL_UI_ArenaUIController.<>f__mg$cache1E0, true);
		string name181 = "m_promoteSucceedDanImage";
		if (Lua_BlackJack_ProjectL_UI_ArenaUIController.<>f__mg$cache1E1 == null)
		{
			Lua_BlackJack_ProjectL_UI_ArenaUIController.<>f__mg$cache1E1 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ArenaUIController.get_m_promoteSucceedDanImage);
		}
		LuaCSFunction get181 = Lua_BlackJack_ProjectL_UI_ArenaUIController.<>f__mg$cache1E1;
		if (Lua_BlackJack_ProjectL_UI_ArenaUIController.<>f__mg$cache1E2 == null)
		{
			Lua_BlackJack_ProjectL_UI_ArenaUIController.<>f__mg$cache1E2 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ArenaUIController.set_m_promoteSucceedDanImage);
		}
		LuaObject.addMember(l, name181, get181, Lua_BlackJack_ProjectL_UI_ArenaUIController.<>f__mg$cache1E2, true);
		string name182 = "m_promoteSucceedDanText";
		if (Lua_BlackJack_ProjectL_UI_ArenaUIController.<>f__mg$cache1E3 == null)
		{
			Lua_BlackJack_ProjectL_UI_ArenaUIController.<>f__mg$cache1E3 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ArenaUIController.get_m_promoteSucceedDanText);
		}
		LuaCSFunction get182 = Lua_BlackJack_ProjectL_UI_ArenaUIController.<>f__mg$cache1E3;
		if (Lua_BlackJack_ProjectL_UI_ArenaUIController.<>f__mg$cache1E4 == null)
		{
			Lua_BlackJack_ProjectL_UI_ArenaUIController.<>f__mg$cache1E4 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ArenaUIController.set_m_promoteSucceedDanText);
		}
		LuaObject.addMember(l, name182, get182, Lua_BlackJack_ProjectL_UI_ArenaUIController.<>f__mg$cache1E4, true);
		string name183 = "m_promoteSucceedConfirmButton";
		if (Lua_BlackJack_ProjectL_UI_ArenaUIController.<>f__mg$cache1E5 == null)
		{
			Lua_BlackJack_ProjectL_UI_ArenaUIController.<>f__mg$cache1E5 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ArenaUIController.get_m_promoteSucceedConfirmButton);
		}
		LuaCSFunction get183 = Lua_BlackJack_ProjectL_UI_ArenaUIController.<>f__mg$cache1E5;
		if (Lua_BlackJack_ProjectL_UI_ArenaUIController.<>f__mg$cache1E6 == null)
		{
			Lua_BlackJack_ProjectL_UI_ArenaUIController.<>f__mg$cache1E6 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ArenaUIController.set_m_promoteSucceedConfirmButton);
		}
		LuaObject.addMember(l, name183, get183, Lua_BlackJack_ProjectL_UI_ArenaUIController.<>f__mg$cache1E6, true);
		string name184 = "m_matchingFailedUIStateController";
		if (Lua_BlackJack_ProjectL_UI_ArenaUIController.<>f__mg$cache1E7 == null)
		{
			Lua_BlackJack_ProjectL_UI_ArenaUIController.<>f__mg$cache1E7 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ArenaUIController.get_m_matchingFailedUIStateController);
		}
		LuaCSFunction get184 = Lua_BlackJack_ProjectL_UI_ArenaUIController.<>f__mg$cache1E7;
		if (Lua_BlackJack_ProjectL_UI_ArenaUIController.<>f__mg$cache1E8 == null)
		{
			Lua_BlackJack_ProjectL_UI_ArenaUIController.<>f__mg$cache1E8 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ArenaUIController.set_m_matchingFailedUIStateController);
		}
		LuaObject.addMember(l, name184, get184, Lua_BlackJack_ProjectL_UI_ArenaUIController.<>f__mg$cache1E8, true);
		string name185 = "m_matchingFailedBGButton";
		if (Lua_BlackJack_ProjectL_UI_ArenaUIController.<>f__mg$cache1E9 == null)
		{
			Lua_BlackJack_ProjectL_UI_ArenaUIController.<>f__mg$cache1E9 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ArenaUIController.get_m_matchingFailedBGButton);
		}
		LuaCSFunction get185 = Lua_BlackJack_ProjectL_UI_ArenaUIController.<>f__mg$cache1E9;
		if (Lua_BlackJack_ProjectL_UI_ArenaUIController.<>f__mg$cache1EA == null)
		{
			Lua_BlackJack_ProjectL_UI_ArenaUIController.<>f__mg$cache1EA = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ArenaUIController.set_m_matchingFailedBGButton);
		}
		LuaObject.addMember(l, name185, get185, Lua_BlackJack_ProjectL_UI_ArenaUIController.<>f__mg$cache1EA, true);
		string name186 = "m_matchingFailedConfirmButton";
		if (Lua_BlackJack_ProjectL_UI_ArenaUIController.<>f__mg$cache1EB == null)
		{
			Lua_BlackJack_ProjectL_UI_ArenaUIController.<>f__mg$cache1EB = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ArenaUIController.get_m_matchingFailedConfirmButton);
		}
		LuaCSFunction get186 = Lua_BlackJack_ProjectL_UI_ArenaUIController.<>f__mg$cache1EB;
		if (Lua_BlackJack_ProjectL_UI_ArenaUIController.<>f__mg$cache1EC == null)
		{
			Lua_BlackJack_ProjectL_UI_ArenaUIController.<>f__mg$cache1EC = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ArenaUIController.set_m_matchingFailedConfirmButton);
		}
		LuaObject.addMember(l, name186, get186, Lua_BlackJack_ProjectL_UI_ArenaUIController.<>f__mg$cache1EC, true);
		string name187 = "m_matchingNowUIStateController";
		if (Lua_BlackJack_ProjectL_UI_ArenaUIController.<>f__mg$cache1ED == null)
		{
			Lua_BlackJack_ProjectL_UI_ArenaUIController.<>f__mg$cache1ED = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ArenaUIController.get_m_matchingNowUIStateController);
		}
		LuaCSFunction get187 = Lua_BlackJack_ProjectL_UI_ArenaUIController.<>f__mg$cache1ED;
		if (Lua_BlackJack_ProjectL_UI_ArenaUIController.<>f__mg$cache1EE == null)
		{
			Lua_BlackJack_ProjectL_UI_ArenaUIController.<>f__mg$cache1EE = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ArenaUIController.set_m_matchingNowUIStateController);
		}
		LuaObject.addMember(l, name187, get187, Lua_BlackJack_ProjectL_UI_ArenaUIController.<>f__mg$cache1EE, true);
		string name188 = "m_matchingNowTimeText";
		if (Lua_BlackJack_ProjectL_UI_ArenaUIController.<>f__mg$cache1EF == null)
		{
			Lua_BlackJack_ProjectL_UI_ArenaUIController.<>f__mg$cache1EF = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ArenaUIController.get_m_matchingNowTimeText);
		}
		LuaCSFunction get188 = Lua_BlackJack_ProjectL_UI_ArenaUIController.<>f__mg$cache1EF;
		if (Lua_BlackJack_ProjectL_UI_ArenaUIController.<>f__mg$cache1F0 == null)
		{
			Lua_BlackJack_ProjectL_UI_ArenaUIController.<>f__mg$cache1F0 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ArenaUIController.set_m_matchingNowTimeText);
		}
		LuaObject.addMember(l, name188, get188, Lua_BlackJack_ProjectL_UI_ArenaUIController.<>f__mg$cache1F0, true);
		string name189 = "m_matchingNowPredictTimeGameObject";
		if (Lua_BlackJack_ProjectL_UI_ArenaUIController.<>f__mg$cache1F1 == null)
		{
			Lua_BlackJack_ProjectL_UI_ArenaUIController.<>f__mg$cache1F1 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ArenaUIController.get_m_matchingNowPredictTimeGameObject);
		}
		LuaCSFunction get189 = Lua_BlackJack_ProjectL_UI_ArenaUIController.<>f__mg$cache1F1;
		if (Lua_BlackJack_ProjectL_UI_ArenaUIController.<>f__mg$cache1F2 == null)
		{
			Lua_BlackJack_ProjectL_UI_ArenaUIController.<>f__mg$cache1F2 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ArenaUIController.set_m_matchingNowPredictTimeGameObject);
		}
		LuaObject.addMember(l, name189, get189, Lua_BlackJack_ProjectL_UI_ArenaUIController.<>f__mg$cache1F2, true);
		string name190 = "m_matchingNowPredictTimeText";
		if (Lua_BlackJack_ProjectL_UI_ArenaUIController.<>f__mg$cache1F3 == null)
		{
			Lua_BlackJack_ProjectL_UI_ArenaUIController.<>f__mg$cache1F3 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ArenaUIController.get_m_matchingNowPredictTimeText);
		}
		LuaCSFunction get190 = Lua_BlackJack_ProjectL_UI_ArenaUIController.<>f__mg$cache1F3;
		if (Lua_BlackJack_ProjectL_UI_ArenaUIController.<>f__mg$cache1F4 == null)
		{
			Lua_BlackJack_ProjectL_UI_ArenaUIController.<>f__mg$cache1F4 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ArenaUIController.set_m_matchingNowPredictTimeText);
		}
		LuaObject.addMember(l, name190, get190, Lua_BlackJack_ProjectL_UI_ArenaUIController.<>f__mg$cache1F4, true);
		string name191 = "m_matchingNowCancelButton";
		if (Lua_BlackJack_ProjectL_UI_ArenaUIController.<>f__mg$cache1F5 == null)
		{
			Lua_BlackJack_ProjectL_UI_ArenaUIController.<>f__mg$cache1F5 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ArenaUIController.get_m_matchingNowCancelButton);
		}
		LuaCSFunction get191 = Lua_BlackJack_ProjectL_UI_ArenaUIController.<>f__mg$cache1F5;
		if (Lua_BlackJack_ProjectL_UI_ArenaUIController.<>f__mg$cache1F6 == null)
		{
			Lua_BlackJack_ProjectL_UI_ArenaUIController.<>f__mg$cache1F6 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ArenaUIController.set_m_matchingNowCancelButton);
		}
		LuaObject.addMember(l, name191, get191, Lua_BlackJack_ProjectL_UI_ArenaUIController.<>f__mg$cache1F6, true);
		string name192 = "m_onlineArenaRankingPool";
		if (Lua_BlackJack_ProjectL_UI_ArenaUIController.<>f__mg$cache1F7 == null)
		{
			Lua_BlackJack_ProjectL_UI_ArenaUIController.<>f__mg$cache1F7 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ArenaUIController.get_m_onlineArenaRankingPool);
		}
		LuaCSFunction get192 = Lua_BlackJack_ProjectL_UI_ArenaUIController.<>f__mg$cache1F7;
		if (Lua_BlackJack_ProjectL_UI_ArenaUIController.<>f__mg$cache1F8 == null)
		{
			Lua_BlackJack_ProjectL_UI_ArenaUIController.<>f__mg$cache1F8 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ArenaUIController.set_m_onlineArenaRankingPool);
		}
		LuaObject.addMember(l, name192, get192, Lua_BlackJack_ProjectL_UI_ArenaUIController.<>f__mg$cache1F8, true);
		string name193 = "m_onlineArenaBattleReportPool";
		if (Lua_BlackJack_ProjectL_UI_ArenaUIController.<>f__mg$cache1F9 == null)
		{
			Lua_BlackJack_ProjectL_UI_ArenaUIController.<>f__mg$cache1F9 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ArenaUIController.get_m_onlineArenaBattleReportPool);
		}
		LuaCSFunction get193 = Lua_BlackJack_ProjectL_UI_ArenaUIController.<>f__mg$cache1F9;
		if (Lua_BlackJack_ProjectL_UI_ArenaUIController.<>f__mg$cache1FA == null)
		{
			Lua_BlackJack_ProjectL_UI_ArenaUIController.<>f__mg$cache1FA = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ArenaUIController.set_m_onlineArenaBattleReportPool);
		}
		LuaObject.addMember(l, name193, get193, Lua_BlackJack_ProjectL_UI_ArenaUIController.<>f__mg$cache1FA, true);
		string name194 = "m_onlineArenaRankingRewardPool";
		if (Lua_BlackJack_ProjectL_UI_ArenaUIController.<>f__mg$cache1FB == null)
		{
			Lua_BlackJack_ProjectL_UI_ArenaUIController.<>f__mg$cache1FB = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ArenaUIController.get_m_onlineArenaRankingRewardPool);
		}
		LuaCSFunction get194 = Lua_BlackJack_ProjectL_UI_ArenaUIController.<>f__mg$cache1FB;
		if (Lua_BlackJack_ProjectL_UI_ArenaUIController.<>f__mg$cache1FC == null)
		{
			Lua_BlackJack_ProjectL_UI_ArenaUIController.<>f__mg$cache1FC = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ArenaUIController.set_m_onlineArenaRankingRewardPool);
		}
		LuaObject.addMember(l, name194, get194, Lua_BlackJack_ProjectL_UI_ArenaUIController.<>f__mg$cache1FC, true);
		string name195 = "m_isMatchingNow";
		if (Lua_BlackJack_ProjectL_UI_ArenaUIController.<>f__mg$cache1FD == null)
		{
			Lua_BlackJack_ProjectL_UI_ArenaUIController.<>f__mg$cache1FD = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ArenaUIController.get_m_isMatchingNow);
		}
		LuaCSFunction get195 = Lua_BlackJack_ProjectL_UI_ArenaUIController.<>f__mg$cache1FD;
		if (Lua_BlackJack_ProjectL_UI_ArenaUIController.<>f__mg$cache1FE == null)
		{
			Lua_BlackJack_ProjectL_UI_ArenaUIController.<>f__mg$cache1FE = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ArenaUIController.set_m_isMatchingNow);
		}
		LuaObject.addMember(l, name195, get195, Lua_BlackJack_ProjectL_UI_ArenaUIController.<>f__mg$cache1FE, true);
		LuaObject.createTypeMetatable(l, null, typeof(ArenaUIController), typeof(UIControllerBase));
	}

	// Token: 0x0401137F RID: 70527
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache0;

	// Token: 0x04011380 RID: 70528
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1;

	// Token: 0x04011381 RID: 70529
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2;

	// Token: 0x04011382 RID: 70530
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3;

	// Token: 0x04011383 RID: 70531
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache4;

	// Token: 0x04011384 RID: 70532
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache5;

	// Token: 0x04011385 RID: 70533
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache6;

	// Token: 0x04011386 RID: 70534
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache7;

	// Token: 0x04011387 RID: 70535
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache8;

	// Token: 0x04011388 RID: 70536
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache9;

	// Token: 0x04011389 RID: 70537
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheA;

	// Token: 0x0401138A RID: 70538
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheB;

	// Token: 0x0401138B RID: 70539
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheC;

	// Token: 0x0401138C RID: 70540
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheD;

	// Token: 0x0401138D RID: 70541
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheE;

	// Token: 0x0401138E RID: 70542
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheF;

	// Token: 0x0401138F RID: 70543
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache10;

	// Token: 0x04011390 RID: 70544
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache11;

	// Token: 0x04011391 RID: 70545
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache12;

	// Token: 0x04011392 RID: 70546
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache13;

	// Token: 0x04011393 RID: 70547
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache14;

	// Token: 0x04011394 RID: 70548
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache15;

	// Token: 0x04011395 RID: 70549
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache16;

	// Token: 0x04011396 RID: 70550
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache17;

	// Token: 0x04011397 RID: 70551
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache18;

	// Token: 0x04011398 RID: 70552
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache19;

	// Token: 0x04011399 RID: 70553
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1A;

	// Token: 0x0401139A RID: 70554
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1B;

	// Token: 0x0401139B RID: 70555
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1C;

	// Token: 0x0401139C RID: 70556
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1D;

	// Token: 0x0401139D RID: 70557
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1E;

	// Token: 0x0401139E RID: 70558
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1F;

	// Token: 0x0401139F RID: 70559
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache20;

	// Token: 0x040113A0 RID: 70560
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache21;

	// Token: 0x040113A1 RID: 70561
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache22;

	// Token: 0x040113A2 RID: 70562
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache23;

	// Token: 0x040113A3 RID: 70563
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache24;

	// Token: 0x040113A4 RID: 70564
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache25;

	// Token: 0x040113A5 RID: 70565
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache26;

	// Token: 0x040113A6 RID: 70566
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache27;

	// Token: 0x040113A7 RID: 70567
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache28;

	// Token: 0x040113A8 RID: 70568
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache29;

	// Token: 0x040113A9 RID: 70569
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2A;

	// Token: 0x040113AA RID: 70570
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2B;

	// Token: 0x040113AB RID: 70571
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2C;

	// Token: 0x040113AC RID: 70572
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2D;

	// Token: 0x040113AD RID: 70573
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2E;

	// Token: 0x040113AE RID: 70574
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2F;

	// Token: 0x040113AF RID: 70575
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache30;

	// Token: 0x040113B0 RID: 70576
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache31;

	// Token: 0x040113B1 RID: 70577
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache32;

	// Token: 0x040113B2 RID: 70578
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache33;

	// Token: 0x040113B3 RID: 70579
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache34;

	// Token: 0x040113B4 RID: 70580
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache35;

	// Token: 0x040113B5 RID: 70581
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache36;

	// Token: 0x040113B6 RID: 70582
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache37;

	// Token: 0x040113B7 RID: 70583
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache38;

	// Token: 0x040113B8 RID: 70584
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache39;

	// Token: 0x040113B9 RID: 70585
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3A;

	// Token: 0x040113BA RID: 70586
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3B;

	// Token: 0x040113BB RID: 70587
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3C;

	// Token: 0x040113BC RID: 70588
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3D;

	// Token: 0x040113BD RID: 70589
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3E;

	// Token: 0x040113BE RID: 70590
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3F;

	// Token: 0x040113BF RID: 70591
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache40;

	// Token: 0x040113C0 RID: 70592
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache41;

	// Token: 0x040113C1 RID: 70593
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache42;

	// Token: 0x040113C2 RID: 70594
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache43;

	// Token: 0x040113C3 RID: 70595
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache44;

	// Token: 0x040113C4 RID: 70596
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache45;

	// Token: 0x040113C5 RID: 70597
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache46;

	// Token: 0x040113C6 RID: 70598
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache47;

	// Token: 0x040113C7 RID: 70599
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache48;

	// Token: 0x040113C8 RID: 70600
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache49;

	// Token: 0x040113C9 RID: 70601
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache4A;

	// Token: 0x040113CA RID: 70602
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache4B;

	// Token: 0x040113CB RID: 70603
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache4C;

	// Token: 0x040113CC RID: 70604
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache4D;

	// Token: 0x040113CD RID: 70605
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache4E;

	// Token: 0x040113CE RID: 70606
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache4F;

	// Token: 0x040113CF RID: 70607
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache50;

	// Token: 0x040113D0 RID: 70608
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache51;

	// Token: 0x040113D1 RID: 70609
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache52;

	// Token: 0x040113D2 RID: 70610
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache53;

	// Token: 0x040113D3 RID: 70611
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache54;

	// Token: 0x040113D4 RID: 70612
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache55;

	// Token: 0x040113D5 RID: 70613
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache56;

	// Token: 0x040113D6 RID: 70614
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache57;

	// Token: 0x040113D7 RID: 70615
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache58;

	// Token: 0x040113D8 RID: 70616
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache59;

	// Token: 0x040113D9 RID: 70617
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache5A;

	// Token: 0x040113DA RID: 70618
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache5B;

	// Token: 0x040113DB RID: 70619
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache5C;

	// Token: 0x040113DC RID: 70620
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache5D;

	// Token: 0x040113DD RID: 70621
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache5E;

	// Token: 0x040113DE RID: 70622
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache5F;

	// Token: 0x040113DF RID: 70623
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache60;

	// Token: 0x040113E0 RID: 70624
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache61;

	// Token: 0x040113E1 RID: 70625
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache62;

	// Token: 0x040113E2 RID: 70626
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache63;

	// Token: 0x040113E3 RID: 70627
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache64;

	// Token: 0x040113E4 RID: 70628
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache65;

	// Token: 0x040113E5 RID: 70629
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache66;

	// Token: 0x040113E6 RID: 70630
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache67;

	// Token: 0x040113E7 RID: 70631
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache68;

	// Token: 0x040113E8 RID: 70632
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache69;

	// Token: 0x040113E9 RID: 70633
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache6A;

	// Token: 0x040113EA RID: 70634
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache6B;

	// Token: 0x040113EB RID: 70635
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache6C;

	// Token: 0x040113EC RID: 70636
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache6D;

	// Token: 0x040113ED RID: 70637
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache6E;

	// Token: 0x040113EE RID: 70638
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache6F;

	// Token: 0x040113EF RID: 70639
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache70;

	// Token: 0x040113F0 RID: 70640
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache71;

	// Token: 0x040113F1 RID: 70641
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache72;

	// Token: 0x040113F2 RID: 70642
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache73;

	// Token: 0x040113F3 RID: 70643
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache74;

	// Token: 0x040113F4 RID: 70644
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache75;

	// Token: 0x040113F5 RID: 70645
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache76;

	// Token: 0x040113F6 RID: 70646
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache77;

	// Token: 0x040113F7 RID: 70647
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache78;

	// Token: 0x040113F8 RID: 70648
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache79;

	// Token: 0x040113F9 RID: 70649
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache7A;

	// Token: 0x040113FA RID: 70650
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache7B;

	// Token: 0x040113FB RID: 70651
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache7C;

	// Token: 0x040113FC RID: 70652
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache7D;

	// Token: 0x040113FD RID: 70653
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache7E;

	// Token: 0x040113FE RID: 70654
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache7F;

	// Token: 0x040113FF RID: 70655
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache80;

	// Token: 0x04011400 RID: 70656
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache81;

	// Token: 0x04011401 RID: 70657
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache82;

	// Token: 0x04011402 RID: 70658
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache83;

	// Token: 0x04011403 RID: 70659
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache84;

	// Token: 0x04011404 RID: 70660
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache85;

	// Token: 0x04011405 RID: 70661
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache86;

	// Token: 0x04011406 RID: 70662
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache87;

	// Token: 0x04011407 RID: 70663
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache88;

	// Token: 0x04011408 RID: 70664
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache89;

	// Token: 0x04011409 RID: 70665
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache8A;

	// Token: 0x0401140A RID: 70666
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache8B;

	// Token: 0x0401140B RID: 70667
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache8C;

	// Token: 0x0401140C RID: 70668
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache8D;

	// Token: 0x0401140D RID: 70669
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache8E;

	// Token: 0x0401140E RID: 70670
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache8F;

	// Token: 0x0401140F RID: 70671
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache90;

	// Token: 0x04011410 RID: 70672
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache91;

	// Token: 0x04011411 RID: 70673
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache92;

	// Token: 0x04011412 RID: 70674
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache93;

	// Token: 0x04011413 RID: 70675
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache94;

	// Token: 0x04011414 RID: 70676
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache95;

	// Token: 0x04011415 RID: 70677
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache96;

	// Token: 0x04011416 RID: 70678
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache97;

	// Token: 0x04011417 RID: 70679
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache98;

	// Token: 0x04011418 RID: 70680
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache99;

	// Token: 0x04011419 RID: 70681
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache9A;

	// Token: 0x0401141A RID: 70682
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache9B;

	// Token: 0x0401141B RID: 70683
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache9C;

	// Token: 0x0401141C RID: 70684
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache9D;

	// Token: 0x0401141D RID: 70685
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache9E;

	// Token: 0x0401141E RID: 70686
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache9F;

	// Token: 0x0401141F RID: 70687
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheA0;

	// Token: 0x04011420 RID: 70688
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheA1;

	// Token: 0x04011421 RID: 70689
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheA2;

	// Token: 0x04011422 RID: 70690
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheA3;

	// Token: 0x04011423 RID: 70691
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheA4;

	// Token: 0x04011424 RID: 70692
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheA5;

	// Token: 0x04011425 RID: 70693
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheA6;

	// Token: 0x04011426 RID: 70694
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheA7;

	// Token: 0x04011427 RID: 70695
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheA8;

	// Token: 0x04011428 RID: 70696
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheA9;

	// Token: 0x04011429 RID: 70697
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheAA;

	// Token: 0x0401142A RID: 70698
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheAB;

	// Token: 0x0401142B RID: 70699
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheAC;

	// Token: 0x0401142C RID: 70700
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheAD;

	// Token: 0x0401142D RID: 70701
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheAE;

	// Token: 0x0401142E RID: 70702
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheAF;

	// Token: 0x0401142F RID: 70703
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheB0;

	// Token: 0x04011430 RID: 70704
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheB1;

	// Token: 0x04011431 RID: 70705
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheB2;

	// Token: 0x04011432 RID: 70706
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheB3;

	// Token: 0x04011433 RID: 70707
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheB4;

	// Token: 0x04011434 RID: 70708
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheB5;

	// Token: 0x04011435 RID: 70709
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheB6;

	// Token: 0x04011436 RID: 70710
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheB7;

	// Token: 0x04011437 RID: 70711
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheB8;

	// Token: 0x04011438 RID: 70712
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheB9;

	// Token: 0x04011439 RID: 70713
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheBA;

	// Token: 0x0401143A RID: 70714
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheBB;

	// Token: 0x0401143B RID: 70715
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheBC;

	// Token: 0x0401143C RID: 70716
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheBD;

	// Token: 0x0401143D RID: 70717
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheBE;

	// Token: 0x0401143E RID: 70718
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheBF;

	// Token: 0x0401143F RID: 70719
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheC0;

	// Token: 0x04011440 RID: 70720
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheC1;

	// Token: 0x04011441 RID: 70721
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheC2;

	// Token: 0x04011442 RID: 70722
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheC3;

	// Token: 0x04011443 RID: 70723
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheC4;

	// Token: 0x04011444 RID: 70724
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheC5;

	// Token: 0x04011445 RID: 70725
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheC6;

	// Token: 0x04011446 RID: 70726
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheC7;

	// Token: 0x04011447 RID: 70727
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheC8;

	// Token: 0x04011448 RID: 70728
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheC9;

	// Token: 0x04011449 RID: 70729
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheCA;

	// Token: 0x0401144A RID: 70730
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheCB;

	// Token: 0x0401144B RID: 70731
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheCC;

	// Token: 0x0401144C RID: 70732
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheCD;

	// Token: 0x0401144D RID: 70733
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheCE;

	// Token: 0x0401144E RID: 70734
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheCF;

	// Token: 0x0401144F RID: 70735
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheD0;

	// Token: 0x04011450 RID: 70736
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheD1;

	// Token: 0x04011451 RID: 70737
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheD2;

	// Token: 0x04011452 RID: 70738
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheD3;

	// Token: 0x04011453 RID: 70739
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheD4;

	// Token: 0x04011454 RID: 70740
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheD5;

	// Token: 0x04011455 RID: 70741
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheD6;

	// Token: 0x04011456 RID: 70742
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheD7;

	// Token: 0x04011457 RID: 70743
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheD8;

	// Token: 0x04011458 RID: 70744
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheD9;

	// Token: 0x04011459 RID: 70745
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheDA;

	// Token: 0x0401145A RID: 70746
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheDB;

	// Token: 0x0401145B RID: 70747
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheDC;

	// Token: 0x0401145C RID: 70748
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheDD;

	// Token: 0x0401145D RID: 70749
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheDE;

	// Token: 0x0401145E RID: 70750
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheDF;

	// Token: 0x0401145F RID: 70751
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheE0;

	// Token: 0x04011460 RID: 70752
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheE1;

	// Token: 0x04011461 RID: 70753
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheE2;

	// Token: 0x04011462 RID: 70754
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheE3;

	// Token: 0x04011463 RID: 70755
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheE4;

	// Token: 0x04011464 RID: 70756
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheE5;

	// Token: 0x04011465 RID: 70757
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheE6;

	// Token: 0x04011466 RID: 70758
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheE7;

	// Token: 0x04011467 RID: 70759
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheE8;

	// Token: 0x04011468 RID: 70760
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheE9;

	// Token: 0x04011469 RID: 70761
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheEA;

	// Token: 0x0401146A RID: 70762
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheEB;

	// Token: 0x0401146B RID: 70763
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheEC;

	// Token: 0x0401146C RID: 70764
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheED;

	// Token: 0x0401146D RID: 70765
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheEE;

	// Token: 0x0401146E RID: 70766
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheEF;

	// Token: 0x0401146F RID: 70767
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheF0;

	// Token: 0x04011470 RID: 70768
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheF1;

	// Token: 0x04011471 RID: 70769
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheF2;

	// Token: 0x04011472 RID: 70770
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheF3;

	// Token: 0x04011473 RID: 70771
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheF4;

	// Token: 0x04011474 RID: 70772
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheF5;

	// Token: 0x04011475 RID: 70773
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheF6;

	// Token: 0x04011476 RID: 70774
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheF7;

	// Token: 0x04011477 RID: 70775
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheF8;

	// Token: 0x04011478 RID: 70776
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheF9;

	// Token: 0x04011479 RID: 70777
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheFA;

	// Token: 0x0401147A RID: 70778
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheFB;

	// Token: 0x0401147B RID: 70779
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheFC;

	// Token: 0x0401147C RID: 70780
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheFD;

	// Token: 0x0401147D RID: 70781
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheFE;

	// Token: 0x0401147E RID: 70782
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheFF;

	// Token: 0x0401147F RID: 70783
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache100;

	// Token: 0x04011480 RID: 70784
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache101;

	// Token: 0x04011481 RID: 70785
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache102;

	// Token: 0x04011482 RID: 70786
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache103;

	// Token: 0x04011483 RID: 70787
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache104;

	// Token: 0x04011484 RID: 70788
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache105;

	// Token: 0x04011485 RID: 70789
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache106;

	// Token: 0x04011486 RID: 70790
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache107;

	// Token: 0x04011487 RID: 70791
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache108;

	// Token: 0x04011488 RID: 70792
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache109;

	// Token: 0x04011489 RID: 70793
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache10A;

	// Token: 0x0401148A RID: 70794
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache10B;

	// Token: 0x0401148B RID: 70795
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache10C;

	// Token: 0x0401148C RID: 70796
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache10D;

	// Token: 0x0401148D RID: 70797
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache10E;

	// Token: 0x0401148E RID: 70798
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache10F;

	// Token: 0x0401148F RID: 70799
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache110;

	// Token: 0x04011490 RID: 70800
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache111;

	// Token: 0x04011491 RID: 70801
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache112;

	// Token: 0x04011492 RID: 70802
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache113;

	// Token: 0x04011493 RID: 70803
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache114;

	// Token: 0x04011494 RID: 70804
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache115;

	// Token: 0x04011495 RID: 70805
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache116;

	// Token: 0x04011496 RID: 70806
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache117;

	// Token: 0x04011497 RID: 70807
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache118;

	// Token: 0x04011498 RID: 70808
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache119;

	// Token: 0x04011499 RID: 70809
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache11A;

	// Token: 0x0401149A RID: 70810
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache11B;

	// Token: 0x0401149B RID: 70811
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache11C;

	// Token: 0x0401149C RID: 70812
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache11D;

	// Token: 0x0401149D RID: 70813
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache11E;

	// Token: 0x0401149E RID: 70814
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache11F;

	// Token: 0x0401149F RID: 70815
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache120;

	// Token: 0x040114A0 RID: 70816
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache121;

	// Token: 0x040114A1 RID: 70817
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache122;

	// Token: 0x040114A2 RID: 70818
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache123;

	// Token: 0x040114A3 RID: 70819
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache124;

	// Token: 0x040114A4 RID: 70820
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache125;

	// Token: 0x040114A5 RID: 70821
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache126;

	// Token: 0x040114A6 RID: 70822
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache127;

	// Token: 0x040114A7 RID: 70823
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache128;

	// Token: 0x040114A8 RID: 70824
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache129;

	// Token: 0x040114A9 RID: 70825
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache12A;

	// Token: 0x040114AA RID: 70826
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache12B;

	// Token: 0x040114AB RID: 70827
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache12C;

	// Token: 0x040114AC RID: 70828
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache12D;

	// Token: 0x040114AD RID: 70829
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache12E;

	// Token: 0x040114AE RID: 70830
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache12F;

	// Token: 0x040114AF RID: 70831
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache130;

	// Token: 0x040114B0 RID: 70832
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache131;

	// Token: 0x040114B1 RID: 70833
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache132;

	// Token: 0x040114B2 RID: 70834
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache133;

	// Token: 0x040114B3 RID: 70835
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache134;

	// Token: 0x040114B4 RID: 70836
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache135;

	// Token: 0x040114B5 RID: 70837
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache136;

	// Token: 0x040114B6 RID: 70838
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache137;

	// Token: 0x040114B7 RID: 70839
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache138;

	// Token: 0x040114B8 RID: 70840
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache139;

	// Token: 0x040114B9 RID: 70841
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache13A;

	// Token: 0x040114BA RID: 70842
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache13B;

	// Token: 0x040114BB RID: 70843
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache13C;

	// Token: 0x040114BC RID: 70844
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache13D;

	// Token: 0x040114BD RID: 70845
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache13E;

	// Token: 0x040114BE RID: 70846
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache13F;

	// Token: 0x040114BF RID: 70847
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache140;

	// Token: 0x040114C0 RID: 70848
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache141;

	// Token: 0x040114C1 RID: 70849
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache142;

	// Token: 0x040114C2 RID: 70850
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache143;

	// Token: 0x040114C3 RID: 70851
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache144;

	// Token: 0x040114C4 RID: 70852
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache145;

	// Token: 0x040114C5 RID: 70853
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache146;

	// Token: 0x040114C6 RID: 70854
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache147;

	// Token: 0x040114C7 RID: 70855
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache148;

	// Token: 0x040114C8 RID: 70856
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache149;

	// Token: 0x040114C9 RID: 70857
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache14A;

	// Token: 0x040114CA RID: 70858
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache14B;

	// Token: 0x040114CB RID: 70859
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache14C;

	// Token: 0x040114CC RID: 70860
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache14D;

	// Token: 0x040114CD RID: 70861
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache14E;

	// Token: 0x040114CE RID: 70862
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache14F;

	// Token: 0x040114CF RID: 70863
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache150;

	// Token: 0x040114D0 RID: 70864
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache151;

	// Token: 0x040114D1 RID: 70865
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache152;

	// Token: 0x040114D2 RID: 70866
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache153;

	// Token: 0x040114D3 RID: 70867
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache154;

	// Token: 0x040114D4 RID: 70868
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache155;

	// Token: 0x040114D5 RID: 70869
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache156;

	// Token: 0x040114D6 RID: 70870
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache157;

	// Token: 0x040114D7 RID: 70871
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache158;

	// Token: 0x040114D8 RID: 70872
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache159;

	// Token: 0x040114D9 RID: 70873
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache15A;

	// Token: 0x040114DA RID: 70874
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache15B;

	// Token: 0x040114DB RID: 70875
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache15C;

	// Token: 0x040114DC RID: 70876
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache15D;

	// Token: 0x040114DD RID: 70877
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache15E;

	// Token: 0x040114DE RID: 70878
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache15F;

	// Token: 0x040114DF RID: 70879
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache160;

	// Token: 0x040114E0 RID: 70880
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache161;

	// Token: 0x040114E1 RID: 70881
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache162;

	// Token: 0x040114E2 RID: 70882
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache163;

	// Token: 0x040114E3 RID: 70883
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache164;

	// Token: 0x040114E4 RID: 70884
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache165;

	// Token: 0x040114E5 RID: 70885
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache166;

	// Token: 0x040114E6 RID: 70886
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache167;

	// Token: 0x040114E7 RID: 70887
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache168;

	// Token: 0x040114E8 RID: 70888
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache169;

	// Token: 0x040114E9 RID: 70889
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache16A;

	// Token: 0x040114EA RID: 70890
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache16B;

	// Token: 0x040114EB RID: 70891
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache16C;

	// Token: 0x040114EC RID: 70892
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache16D;

	// Token: 0x040114ED RID: 70893
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache16E;

	// Token: 0x040114EE RID: 70894
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache16F;

	// Token: 0x040114EF RID: 70895
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache170;

	// Token: 0x040114F0 RID: 70896
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache171;

	// Token: 0x040114F1 RID: 70897
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache172;

	// Token: 0x040114F2 RID: 70898
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache173;

	// Token: 0x040114F3 RID: 70899
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache174;

	// Token: 0x040114F4 RID: 70900
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache175;

	// Token: 0x040114F5 RID: 70901
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache176;

	// Token: 0x040114F6 RID: 70902
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache177;

	// Token: 0x040114F7 RID: 70903
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache178;

	// Token: 0x040114F8 RID: 70904
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache179;

	// Token: 0x040114F9 RID: 70905
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache17A;

	// Token: 0x040114FA RID: 70906
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache17B;

	// Token: 0x040114FB RID: 70907
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache17C;

	// Token: 0x040114FC RID: 70908
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache17D;

	// Token: 0x040114FD RID: 70909
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache17E;

	// Token: 0x040114FE RID: 70910
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache17F;

	// Token: 0x040114FF RID: 70911
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache180;

	// Token: 0x04011500 RID: 70912
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache181;

	// Token: 0x04011501 RID: 70913
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache182;

	// Token: 0x04011502 RID: 70914
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache183;

	// Token: 0x04011503 RID: 70915
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache184;

	// Token: 0x04011504 RID: 70916
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache185;

	// Token: 0x04011505 RID: 70917
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache186;

	// Token: 0x04011506 RID: 70918
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache187;

	// Token: 0x04011507 RID: 70919
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache188;

	// Token: 0x04011508 RID: 70920
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache189;

	// Token: 0x04011509 RID: 70921
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache18A;

	// Token: 0x0401150A RID: 70922
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache18B;

	// Token: 0x0401150B RID: 70923
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache18C;

	// Token: 0x0401150C RID: 70924
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache18D;

	// Token: 0x0401150D RID: 70925
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache18E;

	// Token: 0x0401150E RID: 70926
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache18F;

	// Token: 0x0401150F RID: 70927
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache190;

	// Token: 0x04011510 RID: 70928
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache191;

	// Token: 0x04011511 RID: 70929
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache192;

	// Token: 0x04011512 RID: 70930
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache193;

	// Token: 0x04011513 RID: 70931
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache194;

	// Token: 0x04011514 RID: 70932
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache195;

	// Token: 0x04011515 RID: 70933
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache196;

	// Token: 0x04011516 RID: 70934
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache197;

	// Token: 0x04011517 RID: 70935
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache198;

	// Token: 0x04011518 RID: 70936
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache199;

	// Token: 0x04011519 RID: 70937
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache19A;

	// Token: 0x0401151A RID: 70938
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache19B;

	// Token: 0x0401151B RID: 70939
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache19C;

	// Token: 0x0401151C RID: 70940
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache19D;

	// Token: 0x0401151D RID: 70941
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache19E;

	// Token: 0x0401151E RID: 70942
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache19F;

	// Token: 0x0401151F RID: 70943
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1A0;

	// Token: 0x04011520 RID: 70944
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1A1;

	// Token: 0x04011521 RID: 70945
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1A2;

	// Token: 0x04011522 RID: 70946
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1A3;

	// Token: 0x04011523 RID: 70947
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1A4;

	// Token: 0x04011524 RID: 70948
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1A5;

	// Token: 0x04011525 RID: 70949
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1A6;

	// Token: 0x04011526 RID: 70950
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1A7;

	// Token: 0x04011527 RID: 70951
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1A8;

	// Token: 0x04011528 RID: 70952
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1A9;

	// Token: 0x04011529 RID: 70953
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1AA;

	// Token: 0x0401152A RID: 70954
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1AB;

	// Token: 0x0401152B RID: 70955
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1AC;

	// Token: 0x0401152C RID: 70956
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1AD;

	// Token: 0x0401152D RID: 70957
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1AE;

	// Token: 0x0401152E RID: 70958
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1AF;

	// Token: 0x0401152F RID: 70959
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1B0;

	// Token: 0x04011530 RID: 70960
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1B1;

	// Token: 0x04011531 RID: 70961
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1B2;

	// Token: 0x04011532 RID: 70962
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1B3;

	// Token: 0x04011533 RID: 70963
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1B4;

	// Token: 0x04011534 RID: 70964
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1B5;

	// Token: 0x04011535 RID: 70965
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1B6;

	// Token: 0x04011536 RID: 70966
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1B7;

	// Token: 0x04011537 RID: 70967
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1B8;

	// Token: 0x04011538 RID: 70968
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1B9;

	// Token: 0x04011539 RID: 70969
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1BA;

	// Token: 0x0401153A RID: 70970
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1BB;

	// Token: 0x0401153B RID: 70971
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1BC;

	// Token: 0x0401153C RID: 70972
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1BD;

	// Token: 0x0401153D RID: 70973
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1BE;

	// Token: 0x0401153E RID: 70974
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1BF;

	// Token: 0x0401153F RID: 70975
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1C0;

	// Token: 0x04011540 RID: 70976
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1C1;

	// Token: 0x04011541 RID: 70977
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1C2;

	// Token: 0x04011542 RID: 70978
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1C3;

	// Token: 0x04011543 RID: 70979
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1C4;

	// Token: 0x04011544 RID: 70980
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1C5;

	// Token: 0x04011545 RID: 70981
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1C6;

	// Token: 0x04011546 RID: 70982
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1C7;

	// Token: 0x04011547 RID: 70983
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1C8;

	// Token: 0x04011548 RID: 70984
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1C9;

	// Token: 0x04011549 RID: 70985
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1CA;

	// Token: 0x0401154A RID: 70986
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1CB;

	// Token: 0x0401154B RID: 70987
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1CC;

	// Token: 0x0401154C RID: 70988
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1CD;

	// Token: 0x0401154D RID: 70989
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1CE;

	// Token: 0x0401154E RID: 70990
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1CF;

	// Token: 0x0401154F RID: 70991
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1D0;

	// Token: 0x04011550 RID: 70992
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1D1;

	// Token: 0x04011551 RID: 70993
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1D2;

	// Token: 0x04011552 RID: 70994
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1D3;

	// Token: 0x04011553 RID: 70995
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1D4;

	// Token: 0x04011554 RID: 70996
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1D5;

	// Token: 0x04011555 RID: 70997
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1D6;

	// Token: 0x04011556 RID: 70998
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1D7;

	// Token: 0x04011557 RID: 70999
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1D8;

	// Token: 0x04011558 RID: 71000
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1D9;

	// Token: 0x04011559 RID: 71001
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1DA;

	// Token: 0x0401155A RID: 71002
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1DB;

	// Token: 0x0401155B RID: 71003
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1DC;

	// Token: 0x0401155C RID: 71004
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1DD;

	// Token: 0x0401155D RID: 71005
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1DE;

	// Token: 0x0401155E RID: 71006
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1DF;

	// Token: 0x0401155F RID: 71007
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1E0;

	// Token: 0x04011560 RID: 71008
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1E1;

	// Token: 0x04011561 RID: 71009
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1E2;

	// Token: 0x04011562 RID: 71010
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1E3;

	// Token: 0x04011563 RID: 71011
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1E4;

	// Token: 0x04011564 RID: 71012
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1E5;

	// Token: 0x04011565 RID: 71013
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1E6;

	// Token: 0x04011566 RID: 71014
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1E7;

	// Token: 0x04011567 RID: 71015
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1E8;

	// Token: 0x04011568 RID: 71016
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1E9;

	// Token: 0x04011569 RID: 71017
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1EA;

	// Token: 0x0401156A RID: 71018
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1EB;

	// Token: 0x0401156B RID: 71019
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1EC;

	// Token: 0x0401156C RID: 71020
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1ED;

	// Token: 0x0401156D RID: 71021
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1EE;

	// Token: 0x0401156E RID: 71022
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1EF;

	// Token: 0x0401156F RID: 71023
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1F0;

	// Token: 0x04011570 RID: 71024
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1F1;

	// Token: 0x04011571 RID: 71025
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1F2;

	// Token: 0x04011572 RID: 71026
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1F3;

	// Token: 0x04011573 RID: 71027
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1F4;

	// Token: 0x04011574 RID: 71028
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1F5;

	// Token: 0x04011575 RID: 71029
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1F6;

	// Token: 0x04011576 RID: 71030
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1F7;

	// Token: 0x04011577 RID: 71031
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1F8;

	// Token: 0x04011578 RID: 71032
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1F9;

	// Token: 0x04011579 RID: 71033
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1FA;

	// Token: 0x0401157A RID: 71034
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1FB;

	// Token: 0x0401157B RID: 71035
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1FC;

	// Token: 0x0401157C RID: 71036
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1FD;

	// Token: 0x0401157D RID: 71037
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1FE;
}
