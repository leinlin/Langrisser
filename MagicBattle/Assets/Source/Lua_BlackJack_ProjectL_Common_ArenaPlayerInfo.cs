using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using BlackJack.ProjectL.Common;
using BlackJack.ProjectL.Protocol;
using SLua;
using UnityEngine.Scripting;

// Token: 0x020011C1 RID: 4545
[Preserve]
public class Lua_BlackJack_ProjectL_Common_ArenaPlayerInfo : LuaObject
{
	// Token: 0x060178A2 RID: 96418 RVA: 0x00671064 File Offset: 0x0066F264
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int constructor(IntPtr l)
	{
		int result;
		try
		{
			ArenaPlayerInfo o = new ArenaPlayerInfo();
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

	// Token: 0x060178A3 RID: 96419 RVA: 0x006710AC File Offset: 0x0066F2AC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int PBArenaPlayerInfoToArenaPlayerInfo_s(IntPtr l)
	{
		int result;
		try
		{
			ProArenaPlayerInfo pbArenaPlayerInfo;
			LuaObject.checkType<ProArenaPlayerInfo>(l, 1, out pbArenaPlayerInfo);
			ArenaPlayerInfo o = ArenaPlayerInfo.PBArenaPlayerInfoToArenaPlayerInfo(pbArenaPlayerInfo);
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

	// Token: 0x060178A4 RID: 96420 RVA: 0x00671100 File Offset: 0x0066F300
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int ArenaPlayerInfoToPBArenaPlayerInfo_s(IntPtr l)
	{
		int result;
		try
		{
			ArenaPlayerInfo arenaPlayerInfo;
			LuaObject.checkType<ArenaPlayerInfo>(l, 1, out arenaPlayerInfo);
			ProArenaPlayerInfo o = ArenaPlayerInfo.ArenaPlayerInfoToPBArenaPlayerInfo(arenaPlayerInfo);
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

	// Token: 0x060178A5 RID: 96421 RVA: 0x00671154 File Offset: 0x0066F354
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_DefensiveTeam(IntPtr l)
	{
		int result;
		try
		{
			ArenaPlayerInfo arenaPlayerInfo = (ArenaPlayerInfo)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, arenaPlayerInfo.DefensiveTeam);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060178A6 RID: 96422 RVA: 0x006711A8 File Offset: 0x0066F3A8
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_DefensiveTeam(IntPtr l)
	{
		int result;
		try
		{
			ArenaPlayerInfo arenaPlayerInfo = (ArenaPlayerInfo)LuaObject.checkSelf(l);
			ArenaPlayerDefensiveTeam defensiveTeam;
			LuaObject.checkType<ArenaPlayerDefensiveTeam>(l, 2, out defensiveTeam);
			arenaPlayerInfo.DefensiveTeam = defensiveTeam;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060178A7 RID: 96423 RVA: 0x00671200 File Offset: 0x0066F400
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_Opponents(IntPtr l)
	{
		int result;
		try
		{
			ArenaPlayerInfo arenaPlayerInfo = (ArenaPlayerInfo)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, arenaPlayerInfo.Opponents);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060178A8 RID: 96424 RVA: 0x00671254 File Offset: 0x0066F454
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_Opponents(IntPtr l)
	{
		int result;
		try
		{
			ArenaPlayerInfo arenaPlayerInfo = (ArenaPlayerInfo)LuaObject.checkSelf(l);
			List<ArenaOpponent> opponents;
			LuaObject.checkType<List<ArenaOpponent>>(l, 2, out opponents);
			arenaPlayerInfo.Opponents = opponents;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060178A9 RID: 96425 RVA: 0x006712AC File Offset: 0x0066F4AC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_ArenaLevelId(IntPtr l)
	{
		int result;
		try
		{
			ArenaPlayerInfo arenaPlayerInfo = (ArenaPlayerInfo)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, arenaPlayerInfo.ArenaLevelId);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060178AA RID: 96426 RVA: 0x00671300 File Offset: 0x0066F500
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_ArenaLevelId(IntPtr l)
	{
		int result;
		try
		{
			ArenaPlayerInfo arenaPlayerInfo = (ArenaPlayerInfo)LuaObject.checkSelf(l);
			int arenaLevelId;
			LuaObject.checkType(l, 2, out arenaLevelId);
			arenaPlayerInfo.ArenaLevelId = arenaLevelId;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060178AB RID: 96427 RVA: 0x00671358 File Offset: 0x0066F558
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_ArenaPoints(IntPtr l)
	{
		int result;
		try
		{
			ArenaPlayerInfo arenaPlayerInfo = (ArenaPlayerInfo)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, arenaPlayerInfo.ArenaPoints);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060178AC RID: 96428 RVA: 0x006713AC File Offset: 0x0066F5AC
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_ArenaPoints(IntPtr l)
	{
		int result;
		try
		{
			ArenaPlayerInfo arenaPlayerInfo = (ArenaPlayerInfo)LuaObject.checkSelf(l);
			ushort arenaPoints;
			LuaObject.checkType(l, 2, out arenaPoints);
			arenaPlayerInfo.ArenaPoints = arenaPoints;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060178AD RID: 96429 RVA: 0x00671404 File Offset: 0x0066F604
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_AttackedOpponent(IntPtr l)
	{
		int result;
		try
		{
			ArenaPlayerInfo arenaPlayerInfo = (ArenaPlayerInfo)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, arenaPlayerInfo.AttackedOpponent);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060178AE RID: 96430 RVA: 0x00671458 File Offset: 0x0066F658
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_AttackedOpponent(IntPtr l)
	{
		int result;
		try
		{
			ArenaPlayerInfo arenaPlayerInfo = (ArenaPlayerInfo)LuaObject.checkSelf(l);
			bool attackedOpponent;
			LuaObject.checkType(l, 2, out attackedOpponent);
			arenaPlayerInfo.AttackedOpponent = attackedOpponent;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060178AF RID: 96431 RVA: 0x006714B0 File Offset: 0x0066F6B0
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_WeekLastFlushTime(IntPtr l)
	{
		int result;
		try
		{
			ArenaPlayerInfo arenaPlayerInfo = (ArenaPlayerInfo)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, arenaPlayerInfo.WeekLastFlushTime);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060178B0 RID: 96432 RVA: 0x00671508 File Offset: 0x0066F708
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_WeekLastFlushTime(IntPtr l)
	{
		int result;
		try
		{
			ArenaPlayerInfo arenaPlayerInfo = (ArenaPlayerInfo)LuaObject.checkSelf(l);
			DateTime weekLastFlushTime;
			LuaObject.checkValueType<DateTime>(l, 2, out weekLastFlushTime);
			arenaPlayerInfo.WeekLastFlushTime = weekLastFlushTime;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060178B1 RID: 96433 RVA: 0x00671560 File Offset: 0x0066F760
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_VictoryPoints(IntPtr l)
	{
		int result;
		try
		{
			ArenaPlayerInfo arenaPlayerInfo = (ArenaPlayerInfo)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, arenaPlayerInfo.VictoryPoints);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060178B2 RID: 96434 RVA: 0x006715B4 File Offset: 0x0066F7B4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_VictoryPoints(IntPtr l)
	{
		int result;
		try
		{
			ArenaPlayerInfo arenaPlayerInfo = (ArenaPlayerInfo)LuaObject.checkSelf(l);
			int victoryPoints;
			LuaObject.checkType(l, 2, out victoryPoints);
			arenaPlayerInfo.VictoryPoints = victoryPoints;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060178B3 RID: 96435 RVA: 0x0067160C File Offset: 0x0066F80C
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_ReceivedVictoryPointsRewardIndexs(IntPtr l)
	{
		int result;
		try
		{
			ArenaPlayerInfo arenaPlayerInfo = (ArenaPlayerInfo)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, arenaPlayerInfo.ReceivedVictoryPointsRewardIndexs);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060178B4 RID: 96436 RVA: 0x00671660 File Offset: 0x0066F860
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_ReceivedVictoryPointsRewardIndexs(IntPtr l)
	{
		int result;
		try
		{
			ArenaPlayerInfo arenaPlayerInfo = (ArenaPlayerInfo)LuaObject.checkSelf(l);
			List<int> receivedVictoryPointsRewardIndexs;
			LuaObject.checkType<List<int>>(l, 2, out receivedVictoryPointsRewardIndexs);
			arenaPlayerInfo.ReceivedVictoryPointsRewardIndexs = receivedVictoryPointsRewardIndexs;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060178B5 RID: 96437 RVA: 0x006716B8 File Offset: 0x0066F8B8
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_ThisWeekBattleIds(IntPtr l)
	{
		int result;
		try
		{
			ArenaPlayerInfo arenaPlayerInfo = (ArenaPlayerInfo)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, arenaPlayerInfo.ThisWeekBattleIds);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060178B6 RID: 96438 RVA: 0x0067170C File Offset: 0x0066F90C
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_ThisWeekBattleIds(IntPtr l)
	{
		int result;
		try
		{
			ArenaPlayerInfo arenaPlayerInfo = (ArenaPlayerInfo)LuaObject.checkSelf(l);
			List<int> thisWeekBattleIds;
			LuaObject.checkType<List<int>>(l, 2, out thisWeekBattleIds);
			arenaPlayerInfo.ThisWeekBattleIds = thisWeekBattleIds;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060178B7 RID: 96439 RVA: 0x00671764 File Offset: 0x0066F964
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_ThisWeekTotalBattleNums(IntPtr l)
	{
		int result;
		try
		{
			ArenaPlayerInfo arenaPlayerInfo = (ArenaPlayerInfo)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, arenaPlayerInfo.ThisWeekTotalBattleNums);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060178B8 RID: 96440 RVA: 0x006717B8 File Offset: 0x0066F9B8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_ThisWeekTotalBattleNums(IntPtr l)
	{
		int result;
		try
		{
			ArenaPlayerInfo arenaPlayerInfo = (ArenaPlayerInfo)LuaObject.checkSelf(l);
			int thisWeekTotalBattleNums;
			LuaObject.checkType(l, 2, out thisWeekTotalBattleNums);
			arenaPlayerInfo.ThisWeekTotalBattleNums = thisWeekTotalBattleNums;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060178B9 RID: 96441 RVA: 0x00671810 File Offset: 0x0066FA10
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_ThisWeekVictoryNums(IntPtr l)
	{
		int result;
		try
		{
			ArenaPlayerInfo arenaPlayerInfo = (ArenaPlayerInfo)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, arenaPlayerInfo.ThisWeekVictoryNums);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060178BA RID: 96442 RVA: 0x00671864 File Offset: 0x0066FA64
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_ThisWeekVictoryNums(IntPtr l)
	{
		int result;
		try
		{
			ArenaPlayerInfo arenaPlayerInfo = (ArenaPlayerInfo)LuaObject.checkSelf(l);
			int thisWeekVictoryNums;
			LuaObject.checkType(l, 2, out thisWeekVictoryNums);
			arenaPlayerInfo.ThisWeekVictoryNums = thisWeekVictoryNums;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060178BB RID: 96443 RVA: 0x006718BC File Offset: 0x0066FABC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_IsAutoBattle(IntPtr l)
	{
		int result;
		try
		{
			ArenaPlayerInfo arenaPlayerInfo = (ArenaPlayerInfo)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, arenaPlayerInfo.IsAutoBattle);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060178BC RID: 96444 RVA: 0x00671910 File Offset: 0x0066FB10
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_IsAutoBattle(IntPtr l)
	{
		int result;
		try
		{
			ArenaPlayerInfo arenaPlayerInfo = (ArenaPlayerInfo)LuaObject.checkSelf(l);
			bool isAutoBattle;
			LuaObject.checkType(l, 2, out isAutoBattle);
			arenaPlayerInfo.IsAutoBattle = isAutoBattle;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060178BD RID: 96445 RVA: 0x00671968 File Offset: 0x0066FB68
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_RevengeOpponent(IntPtr l)
	{
		int result;
		try
		{
			ArenaPlayerInfo arenaPlayerInfo = (ArenaPlayerInfo)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, arenaPlayerInfo.RevengeOpponent);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060178BE RID: 96446 RVA: 0x006719BC File Offset: 0x0066FBBC
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_RevengeOpponent(IntPtr l)
	{
		int result;
		try
		{
			ArenaPlayerInfo arenaPlayerInfo = (ArenaPlayerInfo)LuaObject.checkSelf(l);
			ArenaOpponent revengeOpponent;
			LuaObject.checkType<ArenaOpponent>(l, 2, out revengeOpponent);
			arenaPlayerInfo.RevengeOpponent = revengeOpponent;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060178BF RID: 96447 RVA: 0x00671A14 File Offset: 0x0066FC14
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_RevengeBattleReportInstanceId(IntPtr l)
	{
		int result;
		try
		{
			ArenaPlayerInfo arenaPlayerInfo = (ArenaPlayerInfo)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, arenaPlayerInfo.RevengeBattleReportInstanceId);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060178C0 RID: 96448 RVA: 0x00671A68 File Offset: 0x0066FC68
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_RevengeBattleReportInstanceId(IntPtr l)
	{
		int result;
		try
		{
			ArenaPlayerInfo arenaPlayerInfo = (ArenaPlayerInfo)LuaObject.checkSelf(l);
			ulong revengeBattleReportInstanceId;
			LuaObject.checkType(l, 2, out revengeBattleReportInstanceId);
			arenaPlayerInfo.RevengeBattleReportInstanceId = revengeBattleReportInstanceId;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060178C1 RID: 96449 RVA: 0x00671AC0 File Offset: 0x0066FCC0
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_OpponentDefensiveBattleInfo(IntPtr l)
	{
		int result;
		try
		{
			ArenaPlayerInfo arenaPlayerInfo = (ArenaPlayerInfo)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, arenaPlayerInfo.OpponentDefensiveBattleInfo);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060178C2 RID: 96450 RVA: 0x00671B14 File Offset: 0x0066FD14
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_OpponentDefensiveBattleInfo(IntPtr l)
	{
		int result;
		try
		{
			ArenaPlayerInfo arenaPlayerInfo = (ArenaPlayerInfo)LuaObject.checkSelf(l);
			ArenaOpponentDefensiveBattleInfo opponentDefensiveBattleInfo;
			LuaObject.checkType<ArenaOpponentDefensiveBattleInfo>(l, 2, out opponentDefensiveBattleInfo);
			arenaPlayerInfo.OpponentDefensiveBattleInfo = opponentDefensiveBattleInfo;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060178C3 RID: 96451 RVA: 0x00671B6C File Offset: 0x0066FD6C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_MineRank(IntPtr l)
	{
		int result;
		try
		{
			ArenaPlayerInfo arenaPlayerInfo = (ArenaPlayerInfo)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, arenaPlayerInfo.MineRank);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060178C4 RID: 96452 RVA: 0x00671BC0 File Offset: 0x0066FDC0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_MineRank(IntPtr l)
	{
		int result;
		try
		{
			ArenaPlayerInfo arenaPlayerInfo = (ArenaPlayerInfo)LuaObject.checkSelf(l);
			int mineRank;
			LuaObject.checkType(l, 2, out mineRank);
			arenaPlayerInfo.MineRank = mineRank;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060178C5 RID: 96453 RVA: 0x00671C18 File Offset: 0x0066FE18
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_ConsecutiveVictoryNums(IntPtr l)
	{
		int result;
		try
		{
			ArenaPlayerInfo arenaPlayerInfo = (ArenaPlayerInfo)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, arenaPlayerInfo.ConsecutiveVictoryNums);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060178C6 RID: 96454 RVA: 0x00671C6C File Offset: 0x0066FE6C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_ConsecutiveVictoryNums(IntPtr l)
	{
		int result;
		try
		{
			ArenaPlayerInfo arenaPlayerInfo = (ArenaPlayerInfo)LuaObject.checkSelf(l);
			int consecutiveVictoryNums;
			LuaObject.checkType(l, 2, out consecutiveVictoryNums);
			arenaPlayerInfo.ConsecutiveVictoryNums = consecutiveVictoryNums;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060178C7 RID: 96455 RVA: 0x00671CC4 File Offset: 0x0066FEC4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_NextFlushOpponentTime(IntPtr l)
	{
		int result;
		try
		{
			ArenaPlayerInfo arenaPlayerInfo = (ArenaPlayerInfo)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, arenaPlayerInfo.NextFlushOpponentTime);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060178C8 RID: 96456 RVA: 0x00671D18 File Offset: 0x0066FF18
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_NextFlushOpponentTime(IntPtr l)
	{
		int result;
		try
		{
			ArenaPlayerInfo arenaPlayerInfo = (ArenaPlayerInfo)LuaObject.checkSelf(l);
			long nextFlushOpponentTime;
			LuaObject.checkType(l, 2, out nextFlushOpponentTime);
			arenaPlayerInfo.NextFlushOpponentTime = nextFlushOpponentTime;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060178C9 RID: 96457 RVA: 0x00671D70 File Offset: 0x0066FF70
	[Preserve]
	public static void reg(IntPtr l)
	{
		LuaObject.getTypeTable(l, "BlackJack.ProjectL.Common.ArenaPlayerInfo");
		if (Lua_BlackJack_ProjectL_Common_ArenaPlayerInfo.<>f__mg$cache0 == null)
		{
			Lua_BlackJack_ProjectL_Common_ArenaPlayerInfo.<>f__mg$cache0 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_ArenaPlayerInfo.PBArenaPlayerInfoToArenaPlayerInfo_s);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_ArenaPlayerInfo.<>f__mg$cache0);
		if (Lua_BlackJack_ProjectL_Common_ArenaPlayerInfo.<>f__mg$cache1 == null)
		{
			Lua_BlackJack_ProjectL_Common_ArenaPlayerInfo.<>f__mg$cache1 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_ArenaPlayerInfo.ArenaPlayerInfoToPBArenaPlayerInfo_s);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_ArenaPlayerInfo.<>f__mg$cache1);
		string name = "DefensiveTeam";
		if (Lua_BlackJack_ProjectL_Common_ArenaPlayerInfo.<>f__mg$cache2 == null)
		{
			Lua_BlackJack_ProjectL_Common_ArenaPlayerInfo.<>f__mg$cache2 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_ArenaPlayerInfo.get_DefensiveTeam);
		}
		LuaCSFunction get = Lua_BlackJack_ProjectL_Common_ArenaPlayerInfo.<>f__mg$cache2;
		if (Lua_BlackJack_ProjectL_Common_ArenaPlayerInfo.<>f__mg$cache3 == null)
		{
			Lua_BlackJack_ProjectL_Common_ArenaPlayerInfo.<>f__mg$cache3 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_ArenaPlayerInfo.set_DefensiveTeam);
		}
		LuaObject.addMember(l, name, get, Lua_BlackJack_ProjectL_Common_ArenaPlayerInfo.<>f__mg$cache3, true);
		string name2 = "Opponents";
		if (Lua_BlackJack_ProjectL_Common_ArenaPlayerInfo.<>f__mg$cache4 == null)
		{
			Lua_BlackJack_ProjectL_Common_ArenaPlayerInfo.<>f__mg$cache4 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_ArenaPlayerInfo.get_Opponents);
		}
		LuaCSFunction get2 = Lua_BlackJack_ProjectL_Common_ArenaPlayerInfo.<>f__mg$cache4;
		if (Lua_BlackJack_ProjectL_Common_ArenaPlayerInfo.<>f__mg$cache5 == null)
		{
			Lua_BlackJack_ProjectL_Common_ArenaPlayerInfo.<>f__mg$cache5 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_ArenaPlayerInfo.set_Opponents);
		}
		LuaObject.addMember(l, name2, get2, Lua_BlackJack_ProjectL_Common_ArenaPlayerInfo.<>f__mg$cache5, true);
		string name3 = "ArenaLevelId";
		if (Lua_BlackJack_ProjectL_Common_ArenaPlayerInfo.<>f__mg$cache6 == null)
		{
			Lua_BlackJack_ProjectL_Common_ArenaPlayerInfo.<>f__mg$cache6 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_ArenaPlayerInfo.get_ArenaLevelId);
		}
		LuaCSFunction get3 = Lua_BlackJack_ProjectL_Common_ArenaPlayerInfo.<>f__mg$cache6;
		if (Lua_BlackJack_ProjectL_Common_ArenaPlayerInfo.<>f__mg$cache7 == null)
		{
			Lua_BlackJack_ProjectL_Common_ArenaPlayerInfo.<>f__mg$cache7 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_ArenaPlayerInfo.set_ArenaLevelId);
		}
		LuaObject.addMember(l, name3, get3, Lua_BlackJack_ProjectL_Common_ArenaPlayerInfo.<>f__mg$cache7, true);
		string name4 = "ArenaPoints";
		if (Lua_BlackJack_ProjectL_Common_ArenaPlayerInfo.<>f__mg$cache8 == null)
		{
			Lua_BlackJack_ProjectL_Common_ArenaPlayerInfo.<>f__mg$cache8 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_ArenaPlayerInfo.get_ArenaPoints);
		}
		LuaCSFunction get4 = Lua_BlackJack_ProjectL_Common_ArenaPlayerInfo.<>f__mg$cache8;
		if (Lua_BlackJack_ProjectL_Common_ArenaPlayerInfo.<>f__mg$cache9 == null)
		{
			Lua_BlackJack_ProjectL_Common_ArenaPlayerInfo.<>f__mg$cache9 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_ArenaPlayerInfo.set_ArenaPoints);
		}
		LuaObject.addMember(l, name4, get4, Lua_BlackJack_ProjectL_Common_ArenaPlayerInfo.<>f__mg$cache9, true);
		string name5 = "AttackedOpponent";
		if (Lua_BlackJack_ProjectL_Common_ArenaPlayerInfo.<>f__mg$cacheA == null)
		{
			Lua_BlackJack_ProjectL_Common_ArenaPlayerInfo.<>f__mg$cacheA = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_ArenaPlayerInfo.get_AttackedOpponent);
		}
		LuaCSFunction get5 = Lua_BlackJack_ProjectL_Common_ArenaPlayerInfo.<>f__mg$cacheA;
		if (Lua_BlackJack_ProjectL_Common_ArenaPlayerInfo.<>f__mg$cacheB == null)
		{
			Lua_BlackJack_ProjectL_Common_ArenaPlayerInfo.<>f__mg$cacheB = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_ArenaPlayerInfo.set_AttackedOpponent);
		}
		LuaObject.addMember(l, name5, get5, Lua_BlackJack_ProjectL_Common_ArenaPlayerInfo.<>f__mg$cacheB, true);
		string name6 = "WeekLastFlushTime";
		if (Lua_BlackJack_ProjectL_Common_ArenaPlayerInfo.<>f__mg$cacheC == null)
		{
			Lua_BlackJack_ProjectL_Common_ArenaPlayerInfo.<>f__mg$cacheC = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_ArenaPlayerInfo.get_WeekLastFlushTime);
		}
		LuaCSFunction get6 = Lua_BlackJack_ProjectL_Common_ArenaPlayerInfo.<>f__mg$cacheC;
		if (Lua_BlackJack_ProjectL_Common_ArenaPlayerInfo.<>f__mg$cacheD == null)
		{
			Lua_BlackJack_ProjectL_Common_ArenaPlayerInfo.<>f__mg$cacheD = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_ArenaPlayerInfo.set_WeekLastFlushTime);
		}
		LuaObject.addMember(l, name6, get6, Lua_BlackJack_ProjectL_Common_ArenaPlayerInfo.<>f__mg$cacheD, true);
		string name7 = "VictoryPoints";
		if (Lua_BlackJack_ProjectL_Common_ArenaPlayerInfo.<>f__mg$cacheE == null)
		{
			Lua_BlackJack_ProjectL_Common_ArenaPlayerInfo.<>f__mg$cacheE = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_ArenaPlayerInfo.get_VictoryPoints);
		}
		LuaCSFunction get7 = Lua_BlackJack_ProjectL_Common_ArenaPlayerInfo.<>f__mg$cacheE;
		if (Lua_BlackJack_ProjectL_Common_ArenaPlayerInfo.<>f__mg$cacheF == null)
		{
			Lua_BlackJack_ProjectL_Common_ArenaPlayerInfo.<>f__mg$cacheF = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_ArenaPlayerInfo.set_VictoryPoints);
		}
		LuaObject.addMember(l, name7, get7, Lua_BlackJack_ProjectL_Common_ArenaPlayerInfo.<>f__mg$cacheF, true);
		string name8 = "ReceivedVictoryPointsRewardIndexs";
		if (Lua_BlackJack_ProjectL_Common_ArenaPlayerInfo.<>f__mg$cache10 == null)
		{
			Lua_BlackJack_ProjectL_Common_ArenaPlayerInfo.<>f__mg$cache10 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_ArenaPlayerInfo.get_ReceivedVictoryPointsRewardIndexs);
		}
		LuaCSFunction get8 = Lua_BlackJack_ProjectL_Common_ArenaPlayerInfo.<>f__mg$cache10;
		if (Lua_BlackJack_ProjectL_Common_ArenaPlayerInfo.<>f__mg$cache11 == null)
		{
			Lua_BlackJack_ProjectL_Common_ArenaPlayerInfo.<>f__mg$cache11 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_ArenaPlayerInfo.set_ReceivedVictoryPointsRewardIndexs);
		}
		LuaObject.addMember(l, name8, get8, Lua_BlackJack_ProjectL_Common_ArenaPlayerInfo.<>f__mg$cache11, true);
		string name9 = "ThisWeekBattleIds";
		if (Lua_BlackJack_ProjectL_Common_ArenaPlayerInfo.<>f__mg$cache12 == null)
		{
			Lua_BlackJack_ProjectL_Common_ArenaPlayerInfo.<>f__mg$cache12 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_ArenaPlayerInfo.get_ThisWeekBattleIds);
		}
		LuaCSFunction get9 = Lua_BlackJack_ProjectL_Common_ArenaPlayerInfo.<>f__mg$cache12;
		if (Lua_BlackJack_ProjectL_Common_ArenaPlayerInfo.<>f__mg$cache13 == null)
		{
			Lua_BlackJack_ProjectL_Common_ArenaPlayerInfo.<>f__mg$cache13 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_ArenaPlayerInfo.set_ThisWeekBattleIds);
		}
		LuaObject.addMember(l, name9, get9, Lua_BlackJack_ProjectL_Common_ArenaPlayerInfo.<>f__mg$cache13, true);
		string name10 = "ThisWeekTotalBattleNums";
		if (Lua_BlackJack_ProjectL_Common_ArenaPlayerInfo.<>f__mg$cache14 == null)
		{
			Lua_BlackJack_ProjectL_Common_ArenaPlayerInfo.<>f__mg$cache14 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_ArenaPlayerInfo.get_ThisWeekTotalBattleNums);
		}
		LuaCSFunction get10 = Lua_BlackJack_ProjectL_Common_ArenaPlayerInfo.<>f__mg$cache14;
		if (Lua_BlackJack_ProjectL_Common_ArenaPlayerInfo.<>f__mg$cache15 == null)
		{
			Lua_BlackJack_ProjectL_Common_ArenaPlayerInfo.<>f__mg$cache15 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_ArenaPlayerInfo.set_ThisWeekTotalBattleNums);
		}
		LuaObject.addMember(l, name10, get10, Lua_BlackJack_ProjectL_Common_ArenaPlayerInfo.<>f__mg$cache15, true);
		string name11 = "ThisWeekVictoryNums";
		if (Lua_BlackJack_ProjectL_Common_ArenaPlayerInfo.<>f__mg$cache16 == null)
		{
			Lua_BlackJack_ProjectL_Common_ArenaPlayerInfo.<>f__mg$cache16 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_ArenaPlayerInfo.get_ThisWeekVictoryNums);
		}
		LuaCSFunction get11 = Lua_BlackJack_ProjectL_Common_ArenaPlayerInfo.<>f__mg$cache16;
		if (Lua_BlackJack_ProjectL_Common_ArenaPlayerInfo.<>f__mg$cache17 == null)
		{
			Lua_BlackJack_ProjectL_Common_ArenaPlayerInfo.<>f__mg$cache17 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_ArenaPlayerInfo.set_ThisWeekVictoryNums);
		}
		LuaObject.addMember(l, name11, get11, Lua_BlackJack_ProjectL_Common_ArenaPlayerInfo.<>f__mg$cache17, true);
		string name12 = "IsAutoBattle";
		if (Lua_BlackJack_ProjectL_Common_ArenaPlayerInfo.<>f__mg$cache18 == null)
		{
			Lua_BlackJack_ProjectL_Common_ArenaPlayerInfo.<>f__mg$cache18 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_ArenaPlayerInfo.get_IsAutoBattle);
		}
		LuaCSFunction get12 = Lua_BlackJack_ProjectL_Common_ArenaPlayerInfo.<>f__mg$cache18;
		if (Lua_BlackJack_ProjectL_Common_ArenaPlayerInfo.<>f__mg$cache19 == null)
		{
			Lua_BlackJack_ProjectL_Common_ArenaPlayerInfo.<>f__mg$cache19 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_ArenaPlayerInfo.set_IsAutoBattle);
		}
		LuaObject.addMember(l, name12, get12, Lua_BlackJack_ProjectL_Common_ArenaPlayerInfo.<>f__mg$cache19, true);
		string name13 = "RevengeOpponent";
		if (Lua_BlackJack_ProjectL_Common_ArenaPlayerInfo.<>f__mg$cache1A == null)
		{
			Lua_BlackJack_ProjectL_Common_ArenaPlayerInfo.<>f__mg$cache1A = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_ArenaPlayerInfo.get_RevengeOpponent);
		}
		LuaCSFunction get13 = Lua_BlackJack_ProjectL_Common_ArenaPlayerInfo.<>f__mg$cache1A;
		if (Lua_BlackJack_ProjectL_Common_ArenaPlayerInfo.<>f__mg$cache1B == null)
		{
			Lua_BlackJack_ProjectL_Common_ArenaPlayerInfo.<>f__mg$cache1B = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_ArenaPlayerInfo.set_RevengeOpponent);
		}
		LuaObject.addMember(l, name13, get13, Lua_BlackJack_ProjectL_Common_ArenaPlayerInfo.<>f__mg$cache1B, true);
		string name14 = "RevengeBattleReportInstanceId";
		if (Lua_BlackJack_ProjectL_Common_ArenaPlayerInfo.<>f__mg$cache1C == null)
		{
			Lua_BlackJack_ProjectL_Common_ArenaPlayerInfo.<>f__mg$cache1C = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_ArenaPlayerInfo.get_RevengeBattleReportInstanceId);
		}
		LuaCSFunction get14 = Lua_BlackJack_ProjectL_Common_ArenaPlayerInfo.<>f__mg$cache1C;
		if (Lua_BlackJack_ProjectL_Common_ArenaPlayerInfo.<>f__mg$cache1D == null)
		{
			Lua_BlackJack_ProjectL_Common_ArenaPlayerInfo.<>f__mg$cache1D = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_ArenaPlayerInfo.set_RevengeBattleReportInstanceId);
		}
		LuaObject.addMember(l, name14, get14, Lua_BlackJack_ProjectL_Common_ArenaPlayerInfo.<>f__mg$cache1D, true);
		string name15 = "OpponentDefensiveBattleInfo";
		if (Lua_BlackJack_ProjectL_Common_ArenaPlayerInfo.<>f__mg$cache1E == null)
		{
			Lua_BlackJack_ProjectL_Common_ArenaPlayerInfo.<>f__mg$cache1E = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_ArenaPlayerInfo.get_OpponentDefensiveBattleInfo);
		}
		LuaCSFunction get15 = Lua_BlackJack_ProjectL_Common_ArenaPlayerInfo.<>f__mg$cache1E;
		if (Lua_BlackJack_ProjectL_Common_ArenaPlayerInfo.<>f__mg$cache1F == null)
		{
			Lua_BlackJack_ProjectL_Common_ArenaPlayerInfo.<>f__mg$cache1F = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_ArenaPlayerInfo.set_OpponentDefensiveBattleInfo);
		}
		LuaObject.addMember(l, name15, get15, Lua_BlackJack_ProjectL_Common_ArenaPlayerInfo.<>f__mg$cache1F, true);
		string name16 = "MineRank";
		if (Lua_BlackJack_ProjectL_Common_ArenaPlayerInfo.<>f__mg$cache20 == null)
		{
			Lua_BlackJack_ProjectL_Common_ArenaPlayerInfo.<>f__mg$cache20 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_ArenaPlayerInfo.get_MineRank);
		}
		LuaCSFunction get16 = Lua_BlackJack_ProjectL_Common_ArenaPlayerInfo.<>f__mg$cache20;
		if (Lua_BlackJack_ProjectL_Common_ArenaPlayerInfo.<>f__mg$cache21 == null)
		{
			Lua_BlackJack_ProjectL_Common_ArenaPlayerInfo.<>f__mg$cache21 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_ArenaPlayerInfo.set_MineRank);
		}
		LuaObject.addMember(l, name16, get16, Lua_BlackJack_ProjectL_Common_ArenaPlayerInfo.<>f__mg$cache21, true);
		string name17 = "ConsecutiveVictoryNums";
		if (Lua_BlackJack_ProjectL_Common_ArenaPlayerInfo.<>f__mg$cache22 == null)
		{
			Lua_BlackJack_ProjectL_Common_ArenaPlayerInfo.<>f__mg$cache22 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_ArenaPlayerInfo.get_ConsecutiveVictoryNums);
		}
		LuaCSFunction get17 = Lua_BlackJack_ProjectL_Common_ArenaPlayerInfo.<>f__mg$cache22;
		if (Lua_BlackJack_ProjectL_Common_ArenaPlayerInfo.<>f__mg$cache23 == null)
		{
			Lua_BlackJack_ProjectL_Common_ArenaPlayerInfo.<>f__mg$cache23 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_ArenaPlayerInfo.set_ConsecutiveVictoryNums);
		}
		LuaObject.addMember(l, name17, get17, Lua_BlackJack_ProjectL_Common_ArenaPlayerInfo.<>f__mg$cache23, true);
		string name18 = "NextFlushOpponentTime";
		if (Lua_BlackJack_ProjectL_Common_ArenaPlayerInfo.<>f__mg$cache24 == null)
		{
			Lua_BlackJack_ProjectL_Common_ArenaPlayerInfo.<>f__mg$cache24 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_ArenaPlayerInfo.get_NextFlushOpponentTime);
		}
		LuaCSFunction get18 = Lua_BlackJack_ProjectL_Common_ArenaPlayerInfo.<>f__mg$cache24;
		if (Lua_BlackJack_ProjectL_Common_ArenaPlayerInfo.<>f__mg$cache25 == null)
		{
			Lua_BlackJack_ProjectL_Common_ArenaPlayerInfo.<>f__mg$cache25 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_ArenaPlayerInfo.set_NextFlushOpponentTime);
		}
		LuaObject.addMember(l, name18, get18, Lua_BlackJack_ProjectL_Common_ArenaPlayerInfo.<>f__mg$cache25, true);
		if (Lua_BlackJack_ProjectL_Common_ArenaPlayerInfo.<>f__mg$cache26 == null)
		{
			Lua_BlackJack_ProjectL_Common_ArenaPlayerInfo.<>f__mg$cache26 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_ArenaPlayerInfo.constructor);
		}
		LuaObject.createTypeMetatable(l, Lua_BlackJack_ProjectL_Common_ArenaPlayerInfo.<>f__mg$cache26, typeof(ArenaPlayerInfo));
	}

	// Token: 0x0400DF02 RID: 57090
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache0;

	// Token: 0x0400DF03 RID: 57091
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1;

	// Token: 0x0400DF04 RID: 57092
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2;

	// Token: 0x0400DF05 RID: 57093
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3;

	// Token: 0x0400DF06 RID: 57094
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache4;

	// Token: 0x0400DF07 RID: 57095
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache5;

	// Token: 0x0400DF08 RID: 57096
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache6;

	// Token: 0x0400DF09 RID: 57097
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache7;

	// Token: 0x0400DF0A RID: 57098
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache8;

	// Token: 0x0400DF0B RID: 57099
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache9;

	// Token: 0x0400DF0C RID: 57100
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheA;

	// Token: 0x0400DF0D RID: 57101
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheB;

	// Token: 0x0400DF0E RID: 57102
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheC;

	// Token: 0x0400DF0F RID: 57103
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheD;

	// Token: 0x0400DF10 RID: 57104
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheE;

	// Token: 0x0400DF11 RID: 57105
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheF;

	// Token: 0x0400DF12 RID: 57106
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache10;

	// Token: 0x0400DF13 RID: 57107
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache11;

	// Token: 0x0400DF14 RID: 57108
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache12;

	// Token: 0x0400DF15 RID: 57109
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache13;

	// Token: 0x0400DF16 RID: 57110
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache14;

	// Token: 0x0400DF17 RID: 57111
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache15;

	// Token: 0x0400DF18 RID: 57112
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache16;

	// Token: 0x0400DF19 RID: 57113
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache17;

	// Token: 0x0400DF1A RID: 57114
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache18;

	// Token: 0x0400DF1B RID: 57115
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache19;

	// Token: 0x0400DF1C RID: 57116
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1A;

	// Token: 0x0400DF1D RID: 57117
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1B;

	// Token: 0x0400DF1E RID: 57118
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1C;

	// Token: 0x0400DF1F RID: 57119
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1D;

	// Token: 0x0400DF20 RID: 57120
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1E;

	// Token: 0x0400DF21 RID: 57121
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1F;

	// Token: 0x0400DF22 RID: 57122
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache20;

	// Token: 0x0400DF23 RID: 57123
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache21;

	// Token: 0x0400DF24 RID: 57124
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache22;

	// Token: 0x0400DF25 RID: 57125
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache23;

	// Token: 0x0400DF26 RID: 57126
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache24;

	// Token: 0x0400DF27 RID: 57127
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache25;

	// Token: 0x0400DF28 RID: 57128
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache26;
}
