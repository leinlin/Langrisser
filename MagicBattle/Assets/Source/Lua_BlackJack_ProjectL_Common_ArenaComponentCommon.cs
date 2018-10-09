using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using BlackJack.ConfigData;
using BlackJack.ProjectL.Common;
using SLua;
using UnityEngine.Scripting;

// Token: 0x020011BA RID: 4538
[Preserve]
public class Lua_BlackJack_ProjectL_Common_ArenaComponentCommon : LuaObject
{
	// Token: 0x0601780C RID: 96268 RVA: 0x0066CD74 File Offset: 0x0066AF74
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int constructor(IntPtr l)
	{
		int result;
		try
		{
			ArenaComponentCommon o = new ArenaComponentCommon();
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

	// Token: 0x0601780D RID: 96269 RVA: 0x0066CDBC File Offset: 0x0066AFBC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int GetName(IntPtr l)
	{
		int result;
		try
		{
			ArenaComponentCommon arenaComponentCommon = (ArenaComponentCommon)LuaObject.checkSelf(l);
			string name = arenaComponentCommon.GetName();
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, name);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601780E RID: 96270 RVA: 0x0066CE10 File Offset: 0x0066B010
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int Init(IntPtr l)
	{
		int result;
		try
		{
			ArenaComponentCommon arenaComponentCommon = (ArenaComponentCommon)LuaObject.checkSelf(l);
			arenaComponentCommon.Init();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601780F RID: 96271 RVA: 0x0066CE5C File Offset: 0x0066B05C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int PostInit(IntPtr l)
	{
		int result;
		try
		{
			ArenaComponentCommon arenaComponentCommon = (ArenaComponentCommon)LuaObject.checkSelf(l);
			arenaComponentCommon.PostInit();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06017810 RID: 96272 RVA: 0x0066CEA8 File Offset: 0x0066B0A8
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int DeInit(IntPtr l)
	{
		int result;
		try
		{
			ArenaComponentCommon arenaComponentCommon = (ArenaComponentCommon)LuaObject.checkSelf(l);
			arenaComponentCommon.DeInit();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06017811 RID: 96273 RVA: 0x0066CEF4 File Offset: 0x0066B0F4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int Tick(IntPtr l)
	{
		int result;
		try
		{
			ArenaComponentCommon arenaComponentCommon = (ArenaComponentCommon)LuaObject.checkSelf(l);
			uint deltaMillisecond;
			LuaObject.checkType(l, 2, out deltaMillisecond);
			arenaComponentCommon.Tick(deltaMillisecond);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06017812 RID: 96274 RVA: 0x0066CF4C File Offset: 0x0066B14C
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int PostDeSerialize(IntPtr l)
	{
		int result;
		try
		{
			ArenaComponentCommon arenaComponentCommon = (ArenaComponentCommon)LuaObject.checkSelf(l);
			arenaComponentCommon.PostDeSerialize();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06017813 RID: 96275 RVA: 0x0066CF98 File Offset: 0x0066B198
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int GetArenaDefensiveBattleInfo(IntPtr l)
	{
		int result;
		try
		{
			ArenaComponentCommon arenaComponentCommon = (ArenaComponentCommon)LuaObject.checkSelf(l);
			ArenaOpponentDefensiveBattleInfo arenaDefensiveBattleInfo = arenaComponentCommon.GetArenaDefensiveBattleInfo();
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, arenaDefensiveBattleInfo);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06017814 RID: 96276 RVA: 0x0066CFEC File Offset: 0x0066B1EC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int AddArenaBattleReport(IntPtr l)
	{
		int result;
		try
		{
			ArenaComponentCommon arenaComponentCommon = (ArenaComponentCommon)LuaObject.checkSelf(l);
			ArenaBattleReport arenaBattleReport;
			LuaObject.checkType<ArenaBattleReport>(l, 2, out arenaBattleReport);
			arenaComponentCommon.AddArenaBattleReport(arenaBattleReport);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06017815 RID: 96277 RVA: 0x0066D044 File Offset: 0x0066B244
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int SetArenaLevelIdAndPoints(IntPtr l)
	{
		int result;
		try
		{
			ArenaComponentCommon arenaComponentCommon = (ArenaComponentCommon)LuaObject.checkSelf(l);
			int arenaLevelId;
			LuaObject.checkType(l, 2, out arenaLevelId);
			ushort arenaPoints;
			LuaObject.checkType(l, 3, out arenaPoints);
			arenaComponentCommon.SetArenaLevelIdAndPoints(arenaLevelId, arenaPoints);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06017816 RID: 96278 RVA: 0x0066D0A8 File Offset: 0x0066B2A8
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int CanGetVictoryPointsReward(IntPtr l)
	{
		int result;
		try
		{
			ArenaComponentCommon arenaComponentCommon = (ArenaComponentCommon)LuaObject.checkSelf(l);
			int victoryPointsRewardIndex;
			LuaObject.checkType(l, 2, out victoryPointsRewardIndex);
			int i = arenaComponentCommon.CanGetVictoryPointsReward(victoryPointsRewardIndex);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, i);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06017817 RID: 96279 RVA: 0x0066D10C File Offset: 0x0066B30C
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int CanViewOpponent(IntPtr l)
	{
		int result;
		try
		{
			ArenaComponentCommon arenaComponentCommon = (ArenaComponentCommon)LuaObject.checkSelf(l);
			int index;
			LuaObject.checkType(l, 2, out index);
			int i = arenaComponentCommon.CanViewOpponent(index);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, i);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06017818 RID: 96280 RVA: 0x0066D170 File Offset: 0x0066B370
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int CanAttackOpponentByClient(IntPtr l)
	{
		int result;
		try
		{
			ArenaComponentCommon arenaComponentCommon = (ArenaComponentCommon)LuaObject.checkSelf(l);
			int i = arenaComponentCommon.CanAttackOpponentByClient();
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, i);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06017819 RID: 96281 RVA: 0x0066D1C4 File Offset: 0x0066B3C4
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int CanRevengeOpponent(IntPtr l)
	{
		int result;
		try
		{
			ArenaComponentCommon arenaComponentCommon = (ArenaComponentCommon)LuaObject.checkSelf(l);
			ulong battleReportInstanceId;
			LuaObject.checkType(l, 2, out battleReportInstanceId);
			int i = arenaComponentCommon.CanRevengeOpponent(battleReportInstanceId);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, i);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601781A RID: 96282 RVA: 0x0066D228 File Offset: 0x0066B428
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int CanFlushOpponents(IntPtr l)
	{
		int result;
		try
		{
			ArenaComponentCommon arenaComponentCommon = (ArenaComponentCommon)LuaObject.checkSelf(l);
			int i = arenaComponentCommon.CanFlushOpponents();
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, i);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601781B RID: 96283 RVA: 0x0066D27C File Offset: 0x0066B47C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int IsInSettleCacheTime(IntPtr l)
	{
		int result;
		try
		{
			ArenaComponentCommon arenaComponentCommon = (ArenaComponentCommon)LuaObject.checkSelf(l);
			bool b = arenaComponentCommon.IsInSettleCacheTime();
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

	// Token: 0x0601781C RID: 96284 RVA: 0x0066D2D0 File Offset: 0x0066B4D0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int IsArenaOpen(IntPtr l)
	{
		int result;
		try
		{
			ArenaComponentCommon arenaComponentCommon = (ArenaComponentCommon)LuaObject.checkSelf(l);
			bool b = arenaComponentCommon.IsArenaOpen();
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

	// Token: 0x0601781D RID: 96285 RVA: 0x0066D324 File Offset: 0x0066B524
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int IsEmptyArenaPlayerInfo(IntPtr l)
	{
		int result;
		try
		{
			ArenaComponentCommon arenaComponentCommon = (ArenaComponentCommon)LuaObject.checkSelf(l);
			bool b = arenaComponentCommon.IsEmptyArenaPlayerInfo();
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

	// Token: 0x0601781E RID: 96286 RVA: 0x0066D378 File Offset: 0x0066B578
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int IsArenaInited(IntPtr l)
	{
		int result;
		try
		{
			ArenaComponentCommon arenaComponentCommon = (ArenaComponentCommon)LuaObject.checkSelf(l);
			bool b = arenaComponentCommon.IsArenaInited();
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

	// Token: 0x0601781F RID: 96287 RVA: 0x0066D3CC File Offset: 0x0066B5CC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int IsVictoryPointsRewardGot(IntPtr l)
	{
		int result;
		try
		{
			ArenaComponentCommon arenaComponentCommon = (ArenaComponentCommon)LuaObject.checkSelf(l);
			int victoryPointsRewardIndex;
			LuaObject.checkType(l, 2, out victoryPointsRewardIndex);
			bool b = arenaComponentCommon.IsVictoryPointsRewardGot(victoryPointsRewardIndex);
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

	// Token: 0x06017820 RID: 96288 RVA: 0x0066D430 File Offset: 0x0066B630
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int AttackOpponentFighting(IntPtr l)
	{
		int result;
		try
		{
			ArenaComponentCommon arenaComponentCommon = (ArenaComponentCommon)LuaObject.checkSelf(l);
			int i = arenaComponentCommon.AttackOpponentFighting();
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, i);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06017821 RID: 96289 RVA: 0x0066D484 File Offset: 0x0066B684
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int ArenaBattleFinish(IntPtr l)
	{
		int result;
		try
		{
			ArenaComponentCommon arenaComponentCommon = (ArenaComponentCommon)LuaObject.checkSelf(l);
			GameFunctionStatus status;
			LuaObject.checkEnum<GameFunctionStatus>(l, 2, out status);
			arenaComponentCommon.ArenaBattleFinish(status);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06017822 RID: 96290 RVA: 0x0066D4DC File Offset: 0x0066B6DC
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int SetMineRank(IntPtr l)
	{
		int result;
		try
		{
			ArenaComponentCommon arenaComponentCommon = (ArenaComponentCommon)LuaObject.checkSelf(l);
			int mineRank;
			LuaObject.checkType(l, 2, out mineRank);
			arenaComponentCommon.SetMineRank(mineRank);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06017823 RID: 96291 RVA: 0x0066D534 File Offset: 0x0066B734
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int GetMineRank(IntPtr l)
	{
		int result;
		try
		{
			ArenaComponentCommon arenaComponentCommon = (ArenaComponentCommon)LuaObject.checkSelf(l);
			int mineRank = arenaComponentCommon.GetMineRank();
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, mineRank);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06017824 RID: 96292 RVA: 0x0066D588 File Offset: 0x0066B788
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int GetAllArenaBattleReports(IntPtr l)
	{
		int result;
		try
		{
			ArenaComponentCommon arenaComponentCommon = (ArenaComponentCommon)LuaObject.checkSelf(l);
			List<ArenaBattleReport> allArenaBattleReports = arenaComponentCommon.GetAllArenaBattleReports();
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, allArenaBattleReports);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06017825 RID: 96293 RVA: 0x0066D5DC File Offset: 0x0066B7DC
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int CanGetArenaTopRankPlayers(IntPtr l)
	{
		int result;
		try
		{
			ArenaComponentCommon arenaComponentCommon = (ArenaComponentCommon)LuaObject.checkSelf(l);
			int i = arenaComponentCommon.CanGetArenaTopRankPlayers();
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, i);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06017826 RID: 96294 RVA: 0x0066D630 File Offset: 0x0066B830
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int CanGetArenaPlayerInfo(IntPtr l)
	{
		int result;
		try
		{
			ArenaComponentCommon arenaComponentCommon = (ArenaComponentCommon)LuaObject.checkSelf(l);
			int i = arenaComponentCommon.CanGetArenaPlayerInfo();
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, i);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06017827 RID: 96295 RVA: 0x0066D684 File Offset: 0x0066B884
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int CanReconnectArenaBattle(IntPtr l)
	{
		int result;
		try
		{
			ArenaComponentCommon arenaComponentCommon = (ArenaComponentCommon)LuaObject.checkSelf(l);
			int i = arenaComponentCommon.CanReconnectArenaBattle();
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, i);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06017828 RID: 96296 RVA: 0x0066D6D8 File Offset: 0x0066B8D8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int ReconnectArenaBattle(IntPtr l)
	{
		int result;
		try
		{
			ArenaComponentCommon arenaComponentCommon = (ArenaComponentCommon)LuaObject.checkSelf(l);
			int i = arenaComponentCommon.ReconnectArenaBattle();
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, i);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06017829 RID: 96297 RVA: 0x0066D72C File Offset: 0x0066B92C
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int GetNextBattleReportIndex_s(IntPtr l)
	{
		int result;
		try
		{
			byte currentNextBattleReportIndex;
			LuaObject.checkType(l, 1, out currentNextBattleReportIndex);
			int arenaBattleReportMaxNums;
			LuaObject.checkType(l, 2, out arenaBattleReportMaxNums);
			byte nextBattleReportIndex = ArenaComponentCommon.GetNextBattleReportIndex(currentNextBattleReportIndex, arenaBattleReportMaxNums);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, nextBattleReportIndex);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601782A RID: 96298 RVA: 0x0066D78C File Offset: 0x0066B98C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int IsInSettleTime_s(IntPtr l)
	{
		int result;
		try
		{
			IConfigDataLoader configDataLoader;
			LuaObject.checkType<IConfigDataLoader>(l, 1, out configDataLoader);
			int offsetSeconds;
			LuaObject.checkType(l, 2, out offsetSeconds);
			DateTime currentTime;
			LuaObject.checkValueType<DateTime>(l, 3, out currentTime);
			bool b = ArenaComponentCommon.IsInSettleTime(configDataLoader, offsetSeconds, currentTime);
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

	// Token: 0x0601782B RID: 96299 RVA: 0x0066D7FC File Offset: 0x0066B9FC
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int CanFlushArenaByWeek_s(IntPtr l)
	{
		int result;
		try
		{
			DateTime current;
			LuaObject.checkValueType<DateTime>(l, 1, out current);
			DateTime lastFlushTime;
			LuaObject.checkValueType<DateTime>(l, 2, out lastFlushTime);
			int relativeSeconds;
			LuaObject.checkType(l, 3, out relativeSeconds);
			bool b = ArenaComponentCommon.CanFlushArenaByWeek(current, lastFlushTime, relativeSeconds);
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

	// Token: 0x0601782C RID: 96300 RVA: 0x0066D86C File Offset: 0x0066BA6C
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int OnBattleTimeOut(IntPtr l)
	{
		int result;
		try
		{
			ArenaComponentCommon arenaComponentCommon = (ArenaComponentCommon)LuaObject.checkSelf(l);
			arenaComponentCommon.m_luaExportHelper.OnBattleTimeOut();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601782D RID: 96301 RVA: 0x0066D8C0 File Offset: 0x0066BAC0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int OnFinishedArenaBattle(IntPtr l)
	{
		int result;
		try
		{
			ArenaComponentCommon arenaComponentCommon = (ArenaComponentCommon)LuaObject.checkSelf(l);
			ArenaOpponentDefensiveBattleInfo defensivBattleInfo;
			LuaObject.checkType<ArenaOpponentDefensiveBattleInfo>(l, 2, out defensivBattleInfo);
			bool isWin;
			LuaObject.checkType(l, 3, out isWin);
			arenaComponentCommon.m_luaExportHelper.OnFinishedArenaBattle(defensivBattleInfo, isWin);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601782E RID: 96302 RVA: 0x0066D92C File Offset: 0x0066BB2C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int SetThisWeekBattleInfo(IntPtr l)
	{
		int result;
		try
		{
			ArenaComponentCommon arenaComponentCommon = (ArenaComponentCommon)LuaObject.checkSelf(l);
			bool thisWeekBattleInfo;
			LuaObject.checkType(l, 2, out thisWeekBattleInfo);
			arenaComponentCommon.m_luaExportHelper.SetThisWeekBattleInfo(thisWeekBattleInfo);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601782F RID: 96303 RVA: 0x0066D988 File Offset: 0x0066BB88
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int ResetThisWeekBattleInfo(IntPtr l)
	{
		int result;
		try
		{
			ArenaComponentCommon arenaComponentCommon = (ArenaComponentCommon)LuaObject.checkSelf(l);
			arenaComponentCommon.m_luaExportHelper.ResetThisWeekBattleInfo();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06017830 RID: 96304 RVA: 0x0066D9DC File Offset: 0x0066BBDC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int InitArenaPlayerInfo(IntPtr l)
	{
		int result;
		try
		{
			ArenaComponentCommon arenaComponentCommon = (ArenaComponentCommon)LuaObject.checkSelf(l);
			ArenaPlayerInfo info;
			LuaObject.checkType<ArenaPlayerInfo>(l, 2, out info);
			arenaComponentCommon.m_luaExportHelper.InitArenaPlayerInfo(info);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06017831 RID: 96305 RVA: 0x0066DA38 File Offset: 0x0066BC38
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int AddReceivedVictoryPointsRewardIndex(IntPtr l)
	{
		int result;
		try
		{
			ArenaComponentCommon arenaComponentCommon = (ArenaComponentCommon)LuaObject.checkSelf(l);
			int victoryPointsIndex;
			LuaObject.checkType(l, 2, out victoryPointsIndex);
			arenaComponentCommon.m_luaExportHelper.AddReceivedVictoryPointsRewardIndex(victoryPointsIndex);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06017832 RID: 96306 RVA: 0x0066DA94 File Offset: 0x0066BC94
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int OnFlushVictoryPointsEvent(IntPtr l)
	{
		int result;
		try
		{
			ArenaComponentCommon arenaComponentCommon = (ArenaComponentCommon)LuaObject.checkSelf(l);
			arenaComponentCommon.m_luaExportHelper.OnFlushVictoryPointsEvent();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06017833 RID: 96307 RVA: 0x0066DAE8 File Offset: 0x0066BCE8
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int OnArenaGiveTicketsEvent(IntPtr l)
	{
		int result;
		try
		{
			ArenaComponentCommon arenaComponentCommon = (ArenaComponentCommon)LuaObject.checkSelf(l);
			arenaComponentCommon.m_luaExportHelper.OnArenaGiveTicketsEvent();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06017834 RID: 96308 RVA: 0x0066DB3C File Offset: 0x0066BD3C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int SystemGiveArenaTickets(IntPtr l)
	{
		int result;
		try
		{
			ArenaComponentCommon arenaComponentCommon = (ArenaComponentCommon)LuaObject.checkSelf(l);
			arenaComponentCommon.m_luaExportHelper.SystemGiveArenaTickets();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06017835 RID: 96309 RVA: 0x0066DB90 File Offset: 0x0066BD90
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int SetSuccessArenaBattle(IntPtr l)
	{
		int result;
		try
		{
			ArenaComponentCommon arenaComponentCommon = (ArenaComponentCommon)LuaObject.checkSelf(l);
			int successArenaBattle;
			LuaObject.checkType(l, 2, out successArenaBattle);
			arenaComponentCommon.m_luaExportHelper.SetSuccessArenaBattle(successArenaBattle);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06017836 RID: 96310 RVA: 0x0066DBEC File Offset: 0x0066BDEC
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int IsFullBattleReportNums(IntPtr l)
	{
		int result;
		try
		{
			ArenaComponentCommon arenaComponentCommon = (ArenaComponentCommon)LuaObject.checkSelf(l);
			bool b = arenaComponentCommon.m_luaExportHelper.IsFullBattleReportNums();
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

	// Token: 0x06017837 RID: 96311 RVA: 0x0066DC48 File Offset: 0x0066BE48
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int CanAttackOpponent(IntPtr l)
	{
		int result;
		try
		{
			ArenaComponentCommon arenaComponentCommon = (ArenaComponentCommon)LuaObject.checkSelf(l);
			int i = arenaComponentCommon.m_luaExportHelper.CanAttackOpponent();
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, i);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06017838 RID: 96312 RVA: 0x0066DCA4 File Offset: 0x0066BEA4
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int SetBattleReportRevenged(IntPtr l)
	{
		int result;
		try
		{
			ArenaComponentCommon arenaComponentCommon = (ArenaComponentCommon)LuaObject.checkSelf(l);
			ArenaBattleReport battleReportRevenged;
			LuaObject.checkType<ArenaBattleReport>(l, 2, out battleReportRevenged);
			arenaComponentCommon.m_luaExportHelper.SetBattleReportRevenged(battleReportRevenged);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06017839 RID: 96313 RVA: 0x0066DD00 File Offset: 0x0066BF00
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int IsInRealWeekSettleTime(IntPtr l)
	{
		int result;
		try
		{
			ArenaComponentCommon arenaComponentCommon = (ArenaComponentCommon)LuaObject.checkSelf(l);
			bool b = arenaComponentCommon.m_luaExportHelper.IsInRealWeekSettleTime();
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

	// Token: 0x0601783A RID: 96314 RVA: 0x0066DD5C File Offset: 0x0066BF5C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int SetUpFirstDefensiveTeam(IntPtr l)
	{
		int result;
		try
		{
			ArenaComponentCommon arenaComponentCommon = (ArenaComponentCommon)LuaObject.checkSelf(l);
			arenaComponentCommon.m_luaExportHelper.SetUpFirstDefensiveTeam();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601783B RID: 96315 RVA: 0x0066DDB0 File Offset: 0x0066BFB0
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int ArenaConsecutiveSuccess(IntPtr l)
	{
		int result;
		try
		{
			ArenaComponentCommon arenaComponentCommon = (ArenaComponentCommon)LuaObject.checkSelf(l);
			int consecutiveVictoryNums;
			LuaObject.checkType(l, 2, out consecutiveVictoryNums);
			arenaComponentCommon.m_luaExportHelper.ArenaConsecutiveSuccess(consecutiveVictoryNums);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601783C RID: 96316 RVA: 0x0066DE0C File Offset: 0x0066C00C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int CalculateWeekNextFlushTime_s(IntPtr l)
	{
		int result;
		try
		{
			DateTime lastFlushTime;
			LuaObject.checkValueType<DateTime>(l, 1, out lastFlushTime);
			int relativeSeconds;
			LuaObject.checkType(l, 2, out relativeSeconds);
			DateTime dateTime = ArenaComponentCommon.LuaExportHelper.CalculateWeekNextFlushTime(lastFlushTime, relativeSeconds);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, dateTime);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601783D RID: 96317 RVA: 0x0066DE70 File Offset: 0x0066C070
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_m_arenaDS(IntPtr l)
	{
		int result;
		try
		{
			ArenaComponentCommon arenaComponentCommon = (ArenaComponentCommon)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, arenaComponentCommon.m_luaExportHelper.m_arenaDS);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601783E RID: 96318 RVA: 0x0066DEC8 File Offset: 0x0066C0C8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_arenaDS(IntPtr l)
	{
		int result;
		try
		{
			ArenaComponentCommon arenaComponentCommon = (ArenaComponentCommon)LuaObject.checkSelf(l);
			DataSectionArena arenaDS;
			LuaObject.checkType<DataSectionArena>(l, 2, out arenaDS);
			arenaComponentCommon.m_luaExportHelper.m_arenaDS = arenaDS;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601783F RID: 96319 RVA: 0x0066DF24 File Offset: 0x0066C124
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_m_basicInfo(IntPtr l)
	{
		int result;
		try
		{
			ArenaComponentCommon arenaComponentCommon = (ArenaComponentCommon)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, arenaComponentCommon.m_luaExportHelper.m_basicInfo);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06017840 RID: 96320 RVA: 0x0066DF7C File Offset: 0x0066C17C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_basicInfo(IntPtr l)
	{
		int result;
		try
		{
			ArenaComponentCommon arenaComponentCommon = (ArenaComponentCommon)LuaObject.checkSelf(l);
			PlayerBasicInfoComponentCommon basicInfo;
			LuaObject.checkType<PlayerBasicInfoComponentCommon>(l, 2, out basicInfo);
			arenaComponentCommon.m_luaExportHelper.m_basicInfo = basicInfo;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06017841 RID: 96321 RVA: 0x0066DFD8 File Offset: 0x0066C1D8
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_m_battle(IntPtr l)
	{
		int result;
		try
		{
			ArenaComponentCommon arenaComponentCommon = (ArenaComponentCommon)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, arenaComponentCommon.m_luaExportHelper.m_battle);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06017842 RID: 96322 RVA: 0x0066E030 File Offset: 0x0066C230
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_battle(IntPtr l)
	{
		int result;
		try
		{
			ArenaComponentCommon arenaComponentCommon = (ArenaComponentCommon)LuaObject.checkSelf(l);
			BattleComponentCommon battle;
			LuaObject.checkType<BattleComponentCommon>(l, 2, out battle);
			arenaComponentCommon.m_luaExportHelper.m_battle = battle;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06017843 RID: 96323 RVA: 0x0066E08C File Offset: 0x0066C28C
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_m_hero(IntPtr l)
	{
		int result;
		try
		{
			ArenaComponentCommon arenaComponentCommon = (ArenaComponentCommon)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, arenaComponentCommon.m_luaExportHelper.m_hero);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06017844 RID: 96324 RVA: 0x0066E0E4 File Offset: 0x0066C2E4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_hero(IntPtr l)
	{
		int result;
		try
		{
			ArenaComponentCommon arenaComponentCommon = (ArenaComponentCommon)LuaObject.checkSelf(l);
			HeroComponentCommon hero;
			LuaObject.checkType<HeroComponentCommon>(l, 2, out hero);
			arenaComponentCommon.m_luaExportHelper.m_hero = hero;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06017845 RID: 96325 RVA: 0x0066E140 File Offset: 0x0066C340
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_m_bag(IntPtr l)
	{
		int result;
		try
		{
			ArenaComponentCommon arenaComponentCommon = (ArenaComponentCommon)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, arenaComponentCommon.m_luaExportHelper.m_bag);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06017846 RID: 96326 RVA: 0x0066E198 File Offset: 0x0066C398
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_m_bag(IntPtr l)
	{
		int result;
		try
		{
			ArenaComponentCommon arenaComponentCommon = (ArenaComponentCommon)LuaObject.checkSelf(l);
			BagComponentCommon bag;
			LuaObject.checkType<BagComponentCommon>(l, 2, out bag);
			arenaComponentCommon.m_luaExportHelper.m_bag = bag;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06017847 RID: 96327 RVA: 0x0066E1F4 File Offset: 0x0066C3F4
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_m_rift(IntPtr l)
	{
		int result;
		try
		{
			ArenaComponentCommon arenaComponentCommon = (ArenaComponentCommon)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, arenaComponentCommon.m_luaExportHelper.m_rift);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06017848 RID: 96328 RVA: 0x0066E24C File Offset: 0x0066C44C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_rift(IntPtr l)
	{
		int result;
		try
		{
			ArenaComponentCommon arenaComponentCommon = (ArenaComponentCommon)LuaObject.checkSelf(l);
			RiftComponentCommon rift;
			LuaObject.checkType<RiftComponentCommon>(l, 2, out rift);
			arenaComponentCommon.m_luaExportHelper.m_rift = rift;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06017849 RID: 96329 RVA: 0x0066E2A8 File Offset: 0x0066C4A8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_configDataLoader(IntPtr l)
	{
		int result;
		try
		{
			ArenaComponentCommon arenaComponentCommon = (ArenaComponentCommon)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, arenaComponentCommon.m_luaExportHelper.m_configDataLoader);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601784A RID: 96330 RVA: 0x0066E300 File Offset: 0x0066C500
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_m_configDataLoader(IntPtr l)
	{
		int result;
		try
		{
			ArenaComponentCommon arenaComponentCommon = (ArenaComponentCommon)LuaObject.checkSelf(l);
			IConfigDataLoader configDataLoader;
			LuaObject.checkType<IConfigDataLoader>(l, 2, out configDataLoader);
			arenaComponentCommon.m_luaExportHelper.m_configDataLoader = configDataLoader;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601784B RID: 96331 RVA: 0x0066E35C File Offset: 0x0066C55C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_ArenaConsecutiveVictoryEvent(IntPtr l)
	{
		int result;
		try
		{
			ArenaComponentCommon arenaComponentCommon = (ArenaComponentCommon)LuaObject.checkSelf(l);
			Action<int> action;
			int num = LuaObject.checkDelegate<Action<int>>(l, 2, out action);
			if (num == 0)
			{
				arenaComponentCommon.ArenaConsecutiveVictoryEvent = action;
			}
			else if (num == 1)
			{
				ArenaComponentCommon arenaComponentCommon2 = arenaComponentCommon;
				arenaComponentCommon2.ArenaConsecutiveVictoryEvent = (Action<int>)Delegate.Combine(arenaComponentCommon2.ArenaConsecutiveVictoryEvent, action);
			}
			else if (num == 2)
			{
				ArenaComponentCommon arenaComponentCommon3 = arenaComponentCommon;
				arenaComponentCommon3.ArenaConsecutiveVictoryEvent = (Action<int>)Delegate.Remove(arenaComponentCommon3.ArenaConsecutiveVictoryEvent, action);
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

	// Token: 0x0601784C RID: 96332 RVA: 0x0066E404 File Offset: 0x0066C604
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_ArenaAttackMissionEvent(IntPtr l)
	{
		int result;
		try
		{
			ArenaComponentCommon arenaComponentCommon = (ArenaComponentCommon)LuaObject.checkSelf(l);
			Action<BattleType, int, List<int>> action;
			int num = LuaObject.checkDelegate<Action<BattleType, int, List<int>>>(l, 2, out action);
			if (num == 0)
			{
				arenaComponentCommon.ArenaAttackMissionEvent = action;
			}
			else if (num == 1)
			{
				ArenaComponentCommon arenaComponentCommon2 = arenaComponentCommon;
				arenaComponentCommon2.ArenaAttackMissionEvent = (Action<BattleType, int, List<int>>)Delegate.Combine(arenaComponentCommon2.ArenaAttackMissionEvent, action);
			}
			else if (num == 2)
			{
				ArenaComponentCommon arenaComponentCommon3 = arenaComponentCommon;
				arenaComponentCommon3.ArenaAttackMissionEvent = (Action<BattleType, int, List<int>>)Delegate.Remove(arenaComponentCommon3.ArenaAttackMissionEvent, action);
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

	// Token: 0x0601784D RID: 96333 RVA: 0x0066E4AC File Offset: 0x0066C6AC
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_ArenaFightEvent(IntPtr l)
	{
		int result;
		try
		{
			ArenaComponentCommon arenaComponentCommon = (ArenaComponentCommon)LuaObject.checkSelf(l);
			Action action;
			int num = LuaObject.checkDelegate<Action>(l, 2, out action);
			if (num == 0)
			{
				arenaComponentCommon.ArenaFightEvent = action;
			}
			else if (num == 1)
			{
				ArenaComponentCommon arenaComponentCommon2 = arenaComponentCommon;
				arenaComponentCommon2.ArenaFightEvent = (Action)Delegate.Combine(arenaComponentCommon2.ArenaFightEvent, action);
			}
			else if (num == 2)
			{
				ArenaComponentCommon arenaComponentCommon3 = arenaComponentCommon;
				arenaComponentCommon3.ArenaFightEvent = (Action)Delegate.Remove(arenaComponentCommon3.ArenaFightEvent, action);
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

	// Token: 0x0601784E RID: 96334 RVA: 0x0066E554 File Offset: 0x0066C754
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_Owner(IntPtr l)
	{
		int result;
		try
		{
			ArenaComponentCommon arenaComponentCommon = (ArenaComponentCommon)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, arenaComponentCommon.Owner);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601784F RID: 96335 RVA: 0x0066E5A8 File Offset: 0x0066C7A8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_Owner(IntPtr l)
	{
		int result;
		try
		{
			ArenaComponentCommon arenaComponentCommon = (ArenaComponentCommon)LuaObject.checkSelf(l);
			IComponentOwner owner;
			LuaObject.checkType<IComponentOwner>(l, 2, out owner);
			arenaComponentCommon.Owner = owner;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06017850 RID: 96336 RVA: 0x0066E600 File Offset: 0x0066C800
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_IsFirstFindOpponents(IntPtr l)
	{
		int result;
		try
		{
			ArenaComponentCommon arenaComponentCommon = (ArenaComponentCommon)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, arenaComponentCommon.m_luaExportHelper.IsFirstFindOpponents);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06017851 RID: 96337 RVA: 0x0066E658 File Offset: 0x0066C858
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_ArenaPlayerInfo(IntPtr l)
	{
		int result;
		try
		{
			ArenaComponentCommon arenaComponentCommon = (ArenaComponentCommon)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, arenaComponentCommon.ArenaPlayerInfo);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06017852 RID: 96338 RVA: 0x0066E6AC File Offset: 0x0066C8AC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_arenaBattleReportDS(IntPtr l)
	{
		int result;
		try
		{
			ArenaComponentCommon arenaComponentCommon = (ArenaComponentCommon)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, arenaComponentCommon.m_arenaBattleReportDS);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06017853 RID: 96339 RVA: 0x0066E700 File Offset: 0x0066C900
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_arenaBattleReportDS(IntPtr l)
	{
		int result;
		try
		{
			ArenaComponentCommon arenaComponentCommon = (ArenaComponentCommon)LuaObject.checkSelf(l);
			DataSectionArenaBattleReport arenaBattleReportDS;
			LuaObject.checkType<DataSectionArenaBattleReport>(l, 2, out arenaBattleReportDS);
			arenaComponentCommon.m_luaExportHelper.m_arenaBattleReportDS = arenaBattleReportDS;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06017854 RID: 96340 RVA: 0x0066E75C File Offset: 0x0066C95C
	[Preserve]
	public static void reg(IntPtr l)
	{
		LuaObject.getTypeTable(l, "BlackJack.ProjectL.Common.ArenaComponentCommon");
		if (Lua_BlackJack_ProjectL_Common_ArenaComponentCommon.<>f__mg$cache0 == null)
		{
			Lua_BlackJack_ProjectL_Common_ArenaComponentCommon.<>f__mg$cache0 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_ArenaComponentCommon.GetName);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_ArenaComponentCommon.<>f__mg$cache0);
		if (Lua_BlackJack_ProjectL_Common_ArenaComponentCommon.<>f__mg$cache1 == null)
		{
			Lua_BlackJack_ProjectL_Common_ArenaComponentCommon.<>f__mg$cache1 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_ArenaComponentCommon.Init);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_ArenaComponentCommon.<>f__mg$cache1);
		if (Lua_BlackJack_ProjectL_Common_ArenaComponentCommon.<>f__mg$cache2 == null)
		{
			Lua_BlackJack_ProjectL_Common_ArenaComponentCommon.<>f__mg$cache2 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_ArenaComponentCommon.PostInit);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_ArenaComponentCommon.<>f__mg$cache2);
		if (Lua_BlackJack_ProjectL_Common_ArenaComponentCommon.<>f__mg$cache3 == null)
		{
			Lua_BlackJack_ProjectL_Common_ArenaComponentCommon.<>f__mg$cache3 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_ArenaComponentCommon.DeInit);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_ArenaComponentCommon.<>f__mg$cache3);
		if (Lua_BlackJack_ProjectL_Common_ArenaComponentCommon.<>f__mg$cache4 == null)
		{
			Lua_BlackJack_ProjectL_Common_ArenaComponentCommon.<>f__mg$cache4 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_ArenaComponentCommon.Tick);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_ArenaComponentCommon.<>f__mg$cache4);
		if (Lua_BlackJack_ProjectL_Common_ArenaComponentCommon.<>f__mg$cache5 == null)
		{
			Lua_BlackJack_ProjectL_Common_ArenaComponentCommon.<>f__mg$cache5 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_ArenaComponentCommon.PostDeSerialize);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_ArenaComponentCommon.<>f__mg$cache5);
		if (Lua_BlackJack_ProjectL_Common_ArenaComponentCommon.<>f__mg$cache6 == null)
		{
			Lua_BlackJack_ProjectL_Common_ArenaComponentCommon.<>f__mg$cache6 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_ArenaComponentCommon.GetArenaDefensiveBattleInfo);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_ArenaComponentCommon.<>f__mg$cache6);
		if (Lua_BlackJack_ProjectL_Common_ArenaComponentCommon.<>f__mg$cache7 == null)
		{
			Lua_BlackJack_ProjectL_Common_ArenaComponentCommon.<>f__mg$cache7 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_ArenaComponentCommon.AddArenaBattleReport);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_ArenaComponentCommon.<>f__mg$cache7);
		if (Lua_BlackJack_ProjectL_Common_ArenaComponentCommon.<>f__mg$cache8 == null)
		{
			Lua_BlackJack_ProjectL_Common_ArenaComponentCommon.<>f__mg$cache8 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_ArenaComponentCommon.SetArenaLevelIdAndPoints);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_ArenaComponentCommon.<>f__mg$cache8);
		if (Lua_BlackJack_ProjectL_Common_ArenaComponentCommon.<>f__mg$cache9 == null)
		{
			Lua_BlackJack_ProjectL_Common_ArenaComponentCommon.<>f__mg$cache9 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_ArenaComponentCommon.CanGetVictoryPointsReward);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_ArenaComponentCommon.<>f__mg$cache9);
		if (Lua_BlackJack_ProjectL_Common_ArenaComponentCommon.<>f__mg$cacheA == null)
		{
			Lua_BlackJack_ProjectL_Common_ArenaComponentCommon.<>f__mg$cacheA = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_ArenaComponentCommon.CanViewOpponent);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_ArenaComponentCommon.<>f__mg$cacheA);
		if (Lua_BlackJack_ProjectL_Common_ArenaComponentCommon.<>f__mg$cacheB == null)
		{
			Lua_BlackJack_ProjectL_Common_ArenaComponentCommon.<>f__mg$cacheB = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_ArenaComponentCommon.CanAttackOpponentByClient);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_ArenaComponentCommon.<>f__mg$cacheB);
		if (Lua_BlackJack_ProjectL_Common_ArenaComponentCommon.<>f__mg$cacheC == null)
		{
			Lua_BlackJack_ProjectL_Common_ArenaComponentCommon.<>f__mg$cacheC = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_ArenaComponentCommon.CanRevengeOpponent);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_ArenaComponentCommon.<>f__mg$cacheC);
		if (Lua_BlackJack_ProjectL_Common_ArenaComponentCommon.<>f__mg$cacheD == null)
		{
			Lua_BlackJack_ProjectL_Common_ArenaComponentCommon.<>f__mg$cacheD = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_ArenaComponentCommon.CanFlushOpponents);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_ArenaComponentCommon.<>f__mg$cacheD);
		if (Lua_BlackJack_ProjectL_Common_ArenaComponentCommon.<>f__mg$cacheE == null)
		{
			Lua_BlackJack_ProjectL_Common_ArenaComponentCommon.<>f__mg$cacheE = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_ArenaComponentCommon.IsInSettleCacheTime);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_ArenaComponentCommon.<>f__mg$cacheE);
		if (Lua_BlackJack_ProjectL_Common_ArenaComponentCommon.<>f__mg$cacheF == null)
		{
			Lua_BlackJack_ProjectL_Common_ArenaComponentCommon.<>f__mg$cacheF = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_ArenaComponentCommon.IsArenaOpen);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_ArenaComponentCommon.<>f__mg$cacheF);
		if (Lua_BlackJack_ProjectL_Common_ArenaComponentCommon.<>f__mg$cache10 == null)
		{
			Lua_BlackJack_ProjectL_Common_ArenaComponentCommon.<>f__mg$cache10 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_ArenaComponentCommon.IsEmptyArenaPlayerInfo);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_ArenaComponentCommon.<>f__mg$cache10);
		if (Lua_BlackJack_ProjectL_Common_ArenaComponentCommon.<>f__mg$cache11 == null)
		{
			Lua_BlackJack_ProjectL_Common_ArenaComponentCommon.<>f__mg$cache11 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_ArenaComponentCommon.IsArenaInited);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_ArenaComponentCommon.<>f__mg$cache11);
		if (Lua_BlackJack_ProjectL_Common_ArenaComponentCommon.<>f__mg$cache12 == null)
		{
			Lua_BlackJack_ProjectL_Common_ArenaComponentCommon.<>f__mg$cache12 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_ArenaComponentCommon.IsVictoryPointsRewardGot);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_ArenaComponentCommon.<>f__mg$cache12);
		if (Lua_BlackJack_ProjectL_Common_ArenaComponentCommon.<>f__mg$cache13 == null)
		{
			Lua_BlackJack_ProjectL_Common_ArenaComponentCommon.<>f__mg$cache13 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_ArenaComponentCommon.AttackOpponentFighting);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_ArenaComponentCommon.<>f__mg$cache13);
		if (Lua_BlackJack_ProjectL_Common_ArenaComponentCommon.<>f__mg$cache14 == null)
		{
			Lua_BlackJack_ProjectL_Common_ArenaComponentCommon.<>f__mg$cache14 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_ArenaComponentCommon.ArenaBattleFinish);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_ArenaComponentCommon.<>f__mg$cache14);
		if (Lua_BlackJack_ProjectL_Common_ArenaComponentCommon.<>f__mg$cache15 == null)
		{
			Lua_BlackJack_ProjectL_Common_ArenaComponentCommon.<>f__mg$cache15 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_ArenaComponentCommon.SetMineRank);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_ArenaComponentCommon.<>f__mg$cache15);
		if (Lua_BlackJack_ProjectL_Common_ArenaComponentCommon.<>f__mg$cache16 == null)
		{
			Lua_BlackJack_ProjectL_Common_ArenaComponentCommon.<>f__mg$cache16 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_ArenaComponentCommon.GetMineRank);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_ArenaComponentCommon.<>f__mg$cache16);
		if (Lua_BlackJack_ProjectL_Common_ArenaComponentCommon.<>f__mg$cache17 == null)
		{
			Lua_BlackJack_ProjectL_Common_ArenaComponentCommon.<>f__mg$cache17 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_ArenaComponentCommon.GetAllArenaBattleReports);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_ArenaComponentCommon.<>f__mg$cache17);
		if (Lua_BlackJack_ProjectL_Common_ArenaComponentCommon.<>f__mg$cache18 == null)
		{
			Lua_BlackJack_ProjectL_Common_ArenaComponentCommon.<>f__mg$cache18 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_ArenaComponentCommon.CanGetArenaTopRankPlayers);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_ArenaComponentCommon.<>f__mg$cache18);
		if (Lua_BlackJack_ProjectL_Common_ArenaComponentCommon.<>f__mg$cache19 == null)
		{
			Lua_BlackJack_ProjectL_Common_ArenaComponentCommon.<>f__mg$cache19 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_ArenaComponentCommon.CanGetArenaPlayerInfo);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_ArenaComponentCommon.<>f__mg$cache19);
		if (Lua_BlackJack_ProjectL_Common_ArenaComponentCommon.<>f__mg$cache1A == null)
		{
			Lua_BlackJack_ProjectL_Common_ArenaComponentCommon.<>f__mg$cache1A = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_ArenaComponentCommon.CanReconnectArenaBattle);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_ArenaComponentCommon.<>f__mg$cache1A);
		if (Lua_BlackJack_ProjectL_Common_ArenaComponentCommon.<>f__mg$cache1B == null)
		{
			Lua_BlackJack_ProjectL_Common_ArenaComponentCommon.<>f__mg$cache1B = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_ArenaComponentCommon.ReconnectArenaBattle);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_ArenaComponentCommon.<>f__mg$cache1B);
		if (Lua_BlackJack_ProjectL_Common_ArenaComponentCommon.<>f__mg$cache1C == null)
		{
			Lua_BlackJack_ProjectL_Common_ArenaComponentCommon.<>f__mg$cache1C = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_ArenaComponentCommon.GetNextBattleReportIndex_s);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_ArenaComponentCommon.<>f__mg$cache1C);
		if (Lua_BlackJack_ProjectL_Common_ArenaComponentCommon.<>f__mg$cache1D == null)
		{
			Lua_BlackJack_ProjectL_Common_ArenaComponentCommon.<>f__mg$cache1D = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_ArenaComponentCommon.IsInSettleTime_s);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_ArenaComponentCommon.<>f__mg$cache1D);
		if (Lua_BlackJack_ProjectL_Common_ArenaComponentCommon.<>f__mg$cache1E == null)
		{
			Lua_BlackJack_ProjectL_Common_ArenaComponentCommon.<>f__mg$cache1E = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_ArenaComponentCommon.CanFlushArenaByWeek_s);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_ArenaComponentCommon.<>f__mg$cache1E);
		if (Lua_BlackJack_ProjectL_Common_ArenaComponentCommon.<>f__mg$cache1F == null)
		{
			Lua_BlackJack_ProjectL_Common_ArenaComponentCommon.<>f__mg$cache1F = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_ArenaComponentCommon.OnBattleTimeOut);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_ArenaComponentCommon.<>f__mg$cache1F);
		if (Lua_BlackJack_ProjectL_Common_ArenaComponentCommon.<>f__mg$cache20 == null)
		{
			Lua_BlackJack_ProjectL_Common_ArenaComponentCommon.<>f__mg$cache20 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_ArenaComponentCommon.OnFinishedArenaBattle);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_ArenaComponentCommon.<>f__mg$cache20);
		if (Lua_BlackJack_ProjectL_Common_ArenaComponentCommon.<>f__mg$cache21 == null)
		{
			Lua_BlackJack_ProjectL_Common_ArenaComponentCommon.<>f__mg$cache21 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_ArenaComponentCommon.SetThisWeekBattleInfo);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_ArenaComponentCommon.<>f__mg$cache21);
		if (Lua_BlackJack_ProjectL_Common_ArenaComponentCommon.<>f__mg$cache22 == null)
		{
			Lua_BlackJack_ProjectL_Common_ArenaComponentCommon.<>f__mg$cache22 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_ArenaComponentCommon.ResetThisWeekBattleInfo);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_ArenaComponentCommon.<>f__mg$cache22);
		if (Lua_BlackJack_ProjectL_Common_ArenaComponentCommon.<>f__mg$cache23 == null)
		{
			Lua_BlackJack_ProjectL_Common_ArenaComponentCommon.<>f__mg$cache23 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_ArenaComponentCommon.InitArenaPlayerInfo);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_ArenaComponentCommon.<>f__mg$cache23);
		if (Lua_BlackJack_ProjectL_Common_ArenaComponentCommon.<>f__mg$cache24 == null)
		{
			Lua_BlackJack_ProjectL_Common_ArenaComponentCommon.<>f__mg$cache24 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_ArenaComponentCommon.AddReceivedVictoryPointsRewardIndex);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_ArenaComponentCommon.<>f__mg$cache24);
		if (Lua_BlackJack_ProjectL_Common_ArenaComponentCommon.<>f__mg$cache25 == null)
		{
			Lua_BlackJack_ProjectL_Common_ArenaComponentCommon.<>f__mg$cache25 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_ArenaComponentCommon.OnFlushVictoryPointsEvent);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_ArenaComponentCommon.<>f__mg$cache25);
		if (Lua_BlackJack_ProjectL_Common_ArenaComponentCommon.<>f__mg$cache26 == null)
		{
			Lua_BlackJack_ProjectL_Common_ArenaComponentCommon.<>f__mg$cache26 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_ArenaComponentCommon.OnArenaGiveTicketsEvent);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_ArenaComponentCommon.<>f__mg$cache26);
		if (Lua_BlackJack_ProjectL_Common_ArenaComponentCommon.<>f__mg$cache27 == null)
		{
			Lua_BlackJack_ProjectL_Common_ArenaComponentCommon.<>f__mg$cache27 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_ArenaComponentCommon.SystemGiveArenaTickets);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_ArenaComponentCommon.<>f__mg$cache27);
		if (Lua_BlackJack_ProjectL_Common_ArenaComponentCommon.<>f__mg$cache28 == null)
		{
			Lua_BlackJack_ProjectL_Common_ArenaComponentCommon.<>f__mg$cache28 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_ArenaComponentCommon.SetSuccessArenaBattle);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_ArenaComponentCommon.<>f__mg$cache28);
		if (Lua_BlackJack_ProjectL_Common_ArenaComponentCommon.<>f__mg$cache29 == null)
		{
			Lua_BlackJack_ProjectL_Common_ArenaComponentCommon.<>f__mg$cache29 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_ArenaComponentCommon.IsFullBattleReportNums);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_ArenaComponentCommon.<>f__mg$cache29);
		if (Lua_BlackJack_ProjectL_Common_ArenaComponentCommon.<>f__mg$cache2A == null)
		{
			Lua_BlackJack_ProjectL_Common_ArenaComponentCommon.<>f__mg$cache2A = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_ArenaComponentCommon.CanAttackOpponent);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_ArenaComponentCommon.<>f__mg$cache2A);
		if (Lua_BlackJack_ProjectL_Common_ArenaComponentCommon.<>f__mg$cache2B == null)
		{
			Lua_BlackJack_ProjectL_Common_ArenaComponentCommon.<>f__mg$cache2B = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_ArenaComponentCommon.SetBattleReportRevenged);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_ArenaComponentCommon.<>f__mg$cache2B);
		if (Lua_BlackJack_ProjectL_Common_ArenaComponentCommon.<>f__mg$cache2C == null)
		{
			Lua_BlackJack_ProjectL_Common_ArenaComponentCommon.<>f__mg$cache2C = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_ArenaComponentCommon.IsInRealWeekSettleTime);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_ArenaComponentCommon.<>f__mg$cache2C);
		if (Lua_BlackJack_ProjectL_Common_ArenaComponentCommon.<>f__mg$cache2D == null)
		{
			Lua_BlackJack_ProjectL_Common_ArenaComponentCommon.<>f__mg$cache2D = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_ArenaComponentCommon.SetUpFirstDefensiveTeam);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_ArenaComponentCommon.<>f__mg$cache2D);
		if (Lua_BlackJack_ProjectL_Common_ArenaComponentCommon.<>f__mg$cache2E == null)
		{
			Lua_BlackJack_ProjectL_Common_ArenaComponentCommon.<>f__mg$cache2E = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_ArenaComponentCommon.ArenaConsecutiveSuccess);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_ArenaComponentCommon.<>f__mg$cache2E);
		if (Lua_BlackJack_ProjectL_Common_ArenaComponentCommon.<>f__mg$cache2F == null)
		{
			Lua_BlackJack_ProjectL_Common_ArenaComponentCommon.<>f__mg$cache2F = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_ArenaComponentCommon.CalculateWeekNextFlushTime_s);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_ArenaComponentCommon.<>f__mg$cache2F);
		string name = "m_arenaDS";
		if (Lua_BlackJack_ProjectL_Common_ArenaComponentCommon.<>f__mg$cache30 == null)
		{
			Lua_BlackJack_ProjectL_Common_ArenaComponentCommon.<>f__mg$cache30 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_ArenaComponentCommon.get_m_arenaDS);
		}
		LuaCSFunction get = Lua_BlackJack_ProjectL_Common_ArenaComponentCommon.<>f__mg$cache30;
		if (Lua_BlackJack_ProjectL_Common_ArenaComponentCommon.<>f__mg$cache31 == null)
		{
			Lua_BlackJack_ProjectL_Common_ArenaComponentCommon.<>f__mg$cache31 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_ArenaComponentCommon.set_m_arenaDS);
		}
		LuaObject.addMember(l, name, get, Lua_BlackJack_ProjectL_Common_ArenaComponentCommon.<>f__mg$cache31, true);
		string name2 = "m_basicInfo";
		if (Lua_BlackJack_ProjectL_Common_ArenaComponentCommon.<>f__mg$cache32 == null)
		{
			Lua_BlackJack_ProjectL_Common_ArenaComponentCommon.<>f__mg$cache32 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_ArenaComponentCommon.get_m_basicInfo);
		}
		LuaCSFunction get2 = Lua_BlackJack_ProjectL_Common_ArenaComponentCommon.<>f__mg$cache32;
		if (Lua_BlackJack_ProjectL_Common_ArenaComponentCommon.<>f__mg$cache33 == null)
		{
			Lua_BlackJack_ProjectL_Common_ArenaComponentCommon.<>f__mg$cache33 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_ArenaComponentCommon.set_m_basicInfo);
		}
		LuaObject.addMember(l, name2, get2, Lua_BlackJack_ProjectL_Common_ArenaComponentCommon.<>f__mg$cache33, true);
		string name3 = "m_battle";
		if (Lua_BlackJack_ProjectL_Common_ArenaComponentCommon.<>f__mg$cache34 == null)
		{
			Lua_BlackJack_ProjectL_Common_ArenaComponentCommon.<>f__mg$cache34 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_ArenaComponentCommon.get_m_battle);
		}
		LuaCSFunction get3 = Lua_BlackJack_ProjectL_Common_ArenaComponentCommon.<>f__mg$cache34;
		if (Lua_BlackJack_ProjectL_Common_ArenaComponentCommon.<>f__mg$cache35 == null)
		{
			Lua_BlackJack_ProjectL_Common_ArenaComponentCommon.<>f__mg$cache35 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_ArenaComponentCommon.set_m_battle);
		}
		LuaObject.addMember(l, name3, get3, Lua_BlackJack_ProjectL_Common_ArenaComponentCommon.<>f__mg$cache35, true);
		string name4 = "m_hero";
		if (Lua_BlackJack_ProjectL_Common_ArenaComponentCommon.<>f__mg$cache36 == null)
		{
			Lua_BlackJack_ProjectL_Common_ArenaComponentCommon.<>f__mg$cache36 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_ArenaComponentCommon.get_m_hero);
		}
		LuaCSFunction get4 = Lua_BlackJack_ProjectL_Common_ArenaComponentCommon.<>f__mg$cache36;
		if (Lua_BlackJack_ProjectL_Common_ArenaComponentCommon.<>f__mg$cache37 == null)
		{
			Lua_BlackJack_ProjectL_Common_ArenaComponentCommon.<>f__mg$cache37 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_ArenaComponentCommon.set_m_hero);
		}
		LuaObject.addMember(l, name4, get4, Lua_BlackJack_ProjectL_Common_ArenaComponentCommon.<>f__mg$cache37, true);
		string name5 = "m_bag";
		if (Lua_BlackJack_ProjectL_Common_ArenaComponentCommon.<>f__mg$cache38 == null)
		{
			Lua_BlackJack_ProjectL_Common_ArenaComponentCommon.<>f__mg$cache38 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_ArenaComponentCommon.get_m_bag);
		}
		LuaCSFunction get5 = Lua_BlackJack_ProjectL_Common_ArenaComponentCommon.<>f__mg$cache38;
		if (Lua_BlackJack_ProjectL_Common_ArenaComponentCommon.<>f__mg$cache39 == null)
		{
			Lua_BlackJack_ProjectL_Common_ArenaComponentCommon.<>f__mg$cache39 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_ArenaComponentCommon.set_m_bag);
		}
		LuaObject.addMember(l, name5, get5, Lua_BlackJack_ProjectL_Common_ArenaComponentCommon.<>f__mg$cache39, true);
		string name6 = "m_rift";
		if (Lua_BlackJack_ProjectL_Common_ArenaComponentCommon.<>f__mg$cache3A == null)
		{
			Lua_BlackJack_ProjectL_Common_ArenaComponentCommon.<>f__mg$cache3A = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_ArenaComponentCommon.get_m_rift);
		}
		LuaCSFunction get6 = Lua_BlackJack_ProjectL_Common_ArenaComponentCommon.<>f__mg$cache3A;
		if (Lua_BlackJack_ProjectL_Common_ArenaComponentCommon.<>f__mg$cache3B == null)
		{
			Lua_BlackJack_ProjectL_Common_ArenaComponentCommon.<>f__mg$cache3B = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_ArenaComponentCommon.set_m_rift);
		}
		LuaObject.addMember(l, name6, get6, Lua_BlackJack_ProjectL_Common_ArenaComponentCommon.<>f__mg$cache3B, true);
		string name7 = "m_configDataLoader";
		if (Lua_BlackJack_ProjectL_Common_ArenaComponentCommon.<>f__mg$cache3C == null)
		{
			Lua_BlackJack_ProjectL_Common_ArenaComponentCommon.<>f__mg$cache3C = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_ArenaComponentCommon.get_m_configDataLoader);
		}
		LuaCSFunction get7 = Lua_BlackJack_ProjectL_Common_ArenaComponentCommon.<>f__mg$cache3C;
		if (Lua_BlackJack_ProjectL_Common_ArenaComponentCommon.<>f__mg$cache3D == null)
		{
			Lua_BlackJack_ProjectL_Common_ArenaComponentCommon.<>f__mg$cache3D = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_ArenaComponentCommon.set_m_configDataLoader);
		}
		LuaObject.addMember(l, name7, get7, Lua_BlackJack_ProjectL_Common_ArenaComponentCommon.<>f__mg$cache3D, true);
		string name8 = "ArenaConsecutiveVictoryEvent";
		LuaCSFunction get8 = null;
		if (Lua_BlackJack_ProjectL_Common_ArenaComponentCommon.<>f__mg$cache3E == null)
		{
			Lua_BlackJack_ProjectL_Common_ArenaComponentCommon.<>f__mg$cache3E = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_ArenaComponentCommon.set_ArenaConsecutiveVictoryEvent);
		}
		LuaObject.addMember(l, name8, get8, Lua_BlackJack_ProjectL_Common_ArenaComponentCommon.<>f__mg$cache3E, true);
		string name9 = "ArenaAttackMissionEvent";
		LuaCSFunction get9 = null;
		if (Lua_BlackJack_ProjectL_Common_ArenaComponentCommon.<>f__mg$cache3F == null)
		{
			Lua_BlackJack_ProjectL_Common_ArenaComponentCommon.<>f__mg$cache3F = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_ArenaComponentCommon.set_ArenaAttackMissionEvent);
		}
		LuaObject.addMember(l, name9, get9, Lua_BlackJack_ProjectL_Common_ArenaComponentCommon.<>f__mg$cache3F, true);
		string name10 = "ArenaFightEvent";
		LuaCSFunction get10 = null;
		if (Lua_BlackJack_ProjectL_Common_ArenaComponentCommon.<>f__mg$cache40 == null)
		{
			Lua_BlackJack_ProjectL_Common_ArenaComponentCommon.<>f__mg$cache40 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_ArenaComponentCommon.set_ArenaFightEvent);
		}
		LuaObject.addMember(l, name10, get10, Lua_BlackJack_ProjectL_Common_ArenaComponentCommon.<>f__mg$cache40, true);
		string name11 = "Owner";
		if (Lua_BlackJack_ProjectL_Common_ArenaComponentCommon.<>f__mg$cache41 == null)
		{
			Lua_BlackJack_ProjectL_Common_ArenaComponentCommon.<>f__mg$cache41 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_ArenaComponentCommon.get_Owner);
		}
		LuaCSFunction get11 = Lua_BlackJack_ProjectL_Common_ArenaComponentCommon.<>f__mg$cache41;
		if (Lua_BlackJack_ProjectL_Common_ArenaComponentCommon.<>f__mg$cache42 == null)
		{
			Lua_BlackJack_ProjectL_Common_ArenaComponentCommon.<>f__mg$cache42 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_ArenaComponentCommon.set_Owner);
		}
		LuaObject.addMember(l, name11, get11, Lua_BlackJack_ProjectL_Common_ArenaComponentCommon.<>f__mg$cache42, true);
		string name12 = "IsFirstFindOpponents";
		if (Lua_BlackJack_ProjectL_Common_ArenaComponentCommon.<>f__mg$cache43 == null)
		{
			Lua_BlackJack_ProjectL_Common_ArenaComponentCommon.<>f__mg$cache43 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_ArenaComponentCommon.get_IsFirstFindOpponents);
		}
		LuaObject.addMember(l, name12, Lua_BlackJack_ProjectL_Common_ArenaComponentCommon.<>f__mg$cache43, null, true);
		string name13 = "ArenaPlayerInfo";
		if (Lua_BlackJack_ProjectL_Common_ArenaComponentCommon.<>f__mg$cache44 == null)
		{
			Lua_BlackJack_ProjectL_Common_ArenaComponentCommon.<>f__mg$cache44 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_ArenaComponentCommon.get_ArenaPlayerInfo);
		}
		LuaObject.addMember(l, name13, Lua_BlackJack_ProjectL_Common_ArenaComponentCommon.<>f__mg$cache44, null, true);
		string name14 = "m_arenaBattleReportDS";
		if (Lua_BlackJack_ProjectL_Common_ArenaComponentCommon.<>f__mg$cache45 == null)
		{
			Lua_BlackJack_ProjectL_Common_ArenaComponentCommon.<>f__mg$cache45 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_ArenaComponentCommon.get_m_arenaBattleReportDS);
		}
		LuaCSFunction get12 = Lua_BlackJack_ProjectL_Common_ArenaComponentCommon.<>f__mg$cache45;
		if (Lua_BlackJack_ProjectL_Common_ArenaComponentCommon.<>f__mg$cache46 == null)
		{
			Lua_BlackJack_ProjectL_Common_ArenaComponentCommon.<>f__mg$cache46 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_ArenaComponentCommon.set_m_arenaBattleReportDS);
		}
		LuaObject.addMember(l, name14, get12, Lua_BlackJack_ProjectL_Common_ArenaComponentCommon.<>f__mg$cache46, true);
		if (Lua_BlackJack_ProjectL_Common_ArenaComponentCommon.<>f__mg$cache47 == null)
		{
			Lua_BlackJack_ProjectL_Common_ArenaComponentCommon.<>f__mg$cache47 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_ArenaComponentCommon.constructor);
		}
		LuaObject.createTypeMetatable(l, Lua_BlackJack_ProjectL_Common_ArenaComponentCommon.<>f__mg$cache47, typeof(ArenaComponentCommon));
	}

	// Token: 0x0400DE7A RID: 56954
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache0;

	// Token: 0x0400DE7B RID: 56955
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1;

	// Token: 0x0400DE7C RID: 56956
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2;

	// Token: 0x0400DE7D RID: 56957
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3;

	// Token: 0x0400DE7E RID: 56958
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache4;

	// Token: 0x0400DE7F RID: 56959
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache5;

	// Token: 0x0400DE80 RID: 56960
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache6;

	// Token: 0x0400DE81 RID: 56961
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache7;

	// Token: 0x0400DE82 RID: 56962
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache8;

	// Token: 0x0400DE83 RID: 56963
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache9;

	// Token: 0x0400DE84 RID: 56964
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheA;

	// Token: 0x0400DE85 RID: 56965
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheB;

	// Token: 0x0400DE86 RID: 56966
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheC;

	// Token: 0x0400DE87 RID: 56967
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheD;

	// Token: 0x0400DE88 RID: 56968
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheE;

	// Token: 0x0400DE89 RID: 56969
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheF;

	// Token: 0x0400DE8A RID: 56970
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache10;

	// Token: 0x0400DE8B RID: 56971
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache11;

	// Token: 0x0400DE8C RID: 56972
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache12;

	// Token: 0x0400DE8D RID: 56973
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache13;

	// Token: 0x0400DE8E RID: 56974
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache14;

	// Token: 0x0400DE8F RID: 56975
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache15;

	// Token: 0x0400DE90 RID: 56976
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache16;

	// Token: 0x0400DE91 RID: 56977
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache17;

	// Token: 0x0400DE92 RID: 56978
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache18;

	// Token: 0x0400DE93 RID: 56979
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache19;

	// Token: 0x0400DE94 RID: 56980
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1A;

	// Token: 0x0400DE95 RID: 56981
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1B;

	// Token: 0x0400DE96 RID: 56982
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1C;

	// Token: 0x0400DE97 RID: 56983
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1D;

	// Token: 0x0400DE98 RID: 56984
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1E;

	// Token: 0x0400DE99 RID: 56985
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1F;

	// Token: 0x0400DE9A RID: 56986
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache20;

	// Token: 0x0400DE9B RID: 56987
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache21;

	// Token: 0x0400DE9C RID: 56988
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache22;

	// Token: 0x0400DE9D RID: 56989
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache23;

	// Token: 0x0400DE9E RID: 56990
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache24;

	// Token: 0x0400DE9F RID: 56991
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache25;

	// Token: 0x0400DEA0 RID: 56992
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache26;

	// Token: 0x0400DEA1 RID: 56993
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache27;

	// Token: 0x0400DEA2 RID: 56994
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache28;

	// Token: 0x0400DEA3 RID: 56995
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache29;

	// Token: 0x0400DEA4 RID: 56996
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2A;

	// Token: 0x0400DEA5 RID: 56997
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2B;

	// Token: 0x0400DEA6 RID: 56998
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2C;

	// Token: 0x0400DEA7 RID: 56999
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2D;

	// Token: 0x0400DEA8 RID: 57000
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2E;

	// Token: 0x0400DEA9 RID: 57001
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2F;

	// Token: 0x0400DEAA RID: 57002
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache30;

	// Token: 0x0400DEAB RID: 57003
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache31;

	// Token: 0x0400DEAC RID: 57004
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache32;

	// Token: 0x0400DEAD RID: 57005
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache33;

	// Token: 0x0400DEAE RID: 57006
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache34;

	// Token: 0x0400DEAF RID: 57007
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache35;

	// Token: 0x0400DEB0 RID: 57008
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache36;

	// Token: 0x0400DEB1 RID: 57009
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache37;

	// Token: 0x0400DEB2 RID: 57010
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache38;

	// Token: 0x0400DEB3 RID: 57011
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache39;

	// Token: 0x0400DEB4 RID: 57012
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3A;

	// Token: 0x0400DEB5 RID: 57013
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3B;

	// Token: 0x0400DEB6 RID: 57014
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3C;

	// Token: 0x0400DEB7 RID: 57015
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3D;

	// Token: 0x0400DEB8 RID: 57016
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3E;

	// Token: 0x0400DEB9 RID: 57017
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3F;

	// Token: 0x0400DEBA RID: 57018
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache40;

	// Token: 0x0400DEBB RID: 57019
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache41;

	// Token: 0x0400DEBC RID: 57020
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache42;

	// Token: 0x0400DEBD RID: 57021
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache43;

	// Token: 0x0400DEBE RID: 57022
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache44;

	// Token: 0x0400DEBF RID: 57023
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache45;

	// Token: 0x0400DEC0 RID: 57024
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache46;

	// Token: 0x0400DEC1 RID: 57025
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache47;
}
