using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using BlackJack.ProjectL.Common;
using BlackJack.ProjectL.PlayerContext;
using BlackJack.ProjectL.Protocol;
using SLua;
using UnityEngine.Scripting;

// Token: 0x020012B1 RID: 4785
[Preserve]
public class Lua_BlackJack_ProjectL_PlayerContext_ArenaComponent : LuaObject
{
	// Token: 0x06019169 RID: 102761 RVA: 0x00727438 File Offset: 0x00725638
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int constructor(IntPtr l)
	{
		int result;
		try
		{
			ArenaComponent o = new ArenaComponent();
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

	// Token: 0x0601916A RID: 102762 RVA: 0x00727480 File Offset: 0x00725680
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int Init(IntPtr l)
	{
		int result;
		try
		{
			ArenaComponent arenaComponent = (ArenaComponent)LuaObject.checkSelf(l);
			arenaComponent.Init();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601916B RID: 102763 RVA: 0x007274CC File Offset: 0x007256CC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int PostInit(IntPtr l)
	{
		int result;
		try
		{
			ArenaComponent arenaComponent = (ArenaComponent)LuaObject.checkSelf(l);
			arenaComponent.PostInit();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601916C RID: 102764 RVA: 0x00727518 File Offset: 0x00725718
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int DeInit(IntPtr l)
	{
		int result;
		try
		{
			ArenaComponent arenaComponent = (ArenaComponent)LuaObject.checkSelf(l);
			arenaComponent.DeInit();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601916D RID: 102765 RVA: 0x00727564 File Offset: 0x00725764
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int Tick(IntPtr l)
	{
		int result;
		try
		{
			ArenaComponent arenaComponent = (ArenaComponent)LuaObject.checkSelf(l);
			uint deltaMillisecond;
			LuaObject.checkType(l, 2, out deltaMillisecond);
			arenaComponent.Tick(deltaMillisecond);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601916E RID: 102766 RVA: 0x007275BC File Offset: 0x007257BC
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int GetArenaTicketNextGivenTime(IntPtr l)
	{
		int result;
		try
		{
			ArenaComponent arenaComponent = (ArenaComponent)LuaObject.checkSelf(l);
			DateTime arenaTicketNextGivenTime = arenaComponent.GetArenaTicketNextGivenTime();
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, arenaTicketNextGivenTime);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601916F RID: 102767 RVA: 0x00727618 File Offset: 0x00725818
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int DeSerialize(IntPtr l)
	{
		int result;
		try
		{
			ArenaComponent arenaComponent = (ArenaComponent)LuaObject.checkSelf(l);
			DSArenaNtf ntf;
			LuaObject.checkType<DSArenaNtf>(l, 2, out ntf);
			arenaComponent.DeSerialize(ntf);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06019170 RID: 102768 RVA: 0x00727670 File Offset: 0x00725870
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int GetDSVersion(IntPtr l)
	{
		int result;
		try
		{
			ArenaComponent arenaComponent = (ArenaComponent)LuaObject.checkSelf(l);
			ushort dsversion = arenaComponent.GetDSVersion();
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, dsversion);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06019171 RID: 102769 RVA: 0x007276C4 File Offset: 0x007258C4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int AddArenaBattleReportPlayBackData(IntPtr l)
	{
		int result;
		try
		{
			ArenaComponent arenaComponent = (ArenaComponent)LuaObject.checkSelf(l);
			ProArenaBattleReport pbArenaBattleReport;
			LuaObject.checkType<ProArenaBattleReport>(l, 2, out pbArenaBattleReport);
			int i = arenaComponent.AddArenaBattleReportPlayBackData(pbArenaBattleReport);
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

	// Token: 0x06019172 RID: 102770 RVA: 0x00727728 File Offset: 0x00725928
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int StartArenaBattle(IntPtr l)
	{
		int result;
		try
		{
			ArenaComponent arenaComponent = (ArenaComponent)LuaObject.checkSelf(l);
			ProArenaDefensiveBattleInfo pbBattleInfo;
			LuaObject.checkType<ProArenaDefensiveBattleInfo>(l, 2, out pbBattleInfo);
			bool autoBattle;
			LuaObject.checkType(l, 3, out autoBattle);
			arenaComponent.StartArenaBattle(pbBattleInfo, autoBattle);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06019173 RID: 102771 RVA: 0x0072778C File Offset: 0x0072598C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int ReconnectArenaBattle(IntPtr l)
	{
		int result;
		try
		{
			ArenaComponent arenaComponent = (ArenaComponent)LuaObject.checkSelf(l);
			ProArenaDefensiveBattleInfo pbBattleInfo;
			LuaObject.checkType<ProArenaDefensiveBattleInfo>(l, 2, out pbBattleInfo);
			arenaComponent.ReconnectArenaBattle(pbBattleInfo);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06019174 RID: 102772 RVA: 0x007277E4 File Offset: 0x007259E4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int RevengeOpponent(IntPtr l)
	{
		int result;
		try
		{
			ArenaComponent arenaComponent = (ArenaComponent)LuaObject.checkSelf(l);
			ulong battleReportInstanceId;
			LuaObject.checkType(l, 2, out battleReportInstanceId);
			bool autoBattle;
			LuaObject.checkType(l, 3, out autoBattle);
			ProArenaDefensiveBattleInfo pbBattleInfo;
			LuaObject.checkType<ProArenaDefensiveBattleInfo>(l, 4, out pbBattleInfo);
			arenaComponent.RevengeOpponent(battleReportInstanceId, autoBattle, pbBattleInfo);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06019175 RID: 102773 RVA: 0x00727858 File Offset: 0x00725A58
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int SetDefensiveTeam(IntPtr l)
	{
		int result;
		try
		{
			ArenaComponent arenaComponent = (ArenaComponent)LuaObject.checkSelf(l);
			ProArenaPlayerDefensiveTeam defensiveTeam;
			LuaObject.checkType<ProArenaPlayerDefensiveTeam>(l, 2, out defensiveTeam);
			arenaComponent.SetDefensiveTeam(defensiveTeam);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06019176 RID: 102774 RVA: 0x007278B0 File Offset: 0x00725AB0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int FinsihArenaBattle(IntPtr l)
	{
		int result;
		try
		{
			ArenaComponent arenaComponent = (ArenaComponent)LuaObject.checkSelf(l);
			bool isWin;
			LuaObject.checkType(l, 2, out isWin);
			arenaComponent.FinsihArenaBattle(isWin);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06019177 RID: 102775 RVA: 0x00727908 File Offset: 0x00725B08
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int FlushOpponents(IntPtr l)
	{
		int result;
		try
		{
			ArenaComponent arenaComponent = (ArenaComponent)LuaObject.checkSelf(l);
			List<ProArenaOpponent> pbOpponents;
			LuaObject.checkType<List<ProArenaOpponent>>(l, 2, out pbOpponents);
			long nextFlushTime;
			LuaObject.checkType(l, 3, out nextFlushTime);
			arenaComponent.FlushOpponents(pbOpponents, nextFlushTime);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06019178 RID: 102776 RVA: 0x0072796C File Offset: 0x00725B6C
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int InitArenaPlayInfo(IntPtr l)
	{
		int result;
		try
		{
			ArenaComponent arenaComponent = (ArenaComponent)LuaObject.checkSelf(l);
			ProArenaPlayerInfo pbArenaPlayerInfo;
			LuaObject.checkType<ProArenaPlayerInfo>(l, 2, out pbArenaPlayerInfo);
			arenaComponent.InitArenaPlayInfo(pbArenaPlayerInfo);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06019179 RID: 102777 RVA: 0x007279C4 File Offset: 0x00725BC4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int InitBattleReportBasicInfo(IntPtr l)
	{
		int result;
		try
		{
			ArenaComponent arenaComponent = (ArenaComponent)LuaObject.checkSelf(l);
			List<ProArenaBattleReport> pbArenaBattleReports;
			LuaObject.checkType<List<ProArenaBattleReport>>(l, 2, out pbArenaBattleReports);
			int nextBattleReportIndex;
			LuaObject.checkType(l, 3, out nextBattleReportIndex);
			arenaComponent.InitBattleReportBasicInfo(pbArenaBattleReports, nextBattleReportIndex);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601917A RID: 102778 RVA: 0x00727A28 File Offset: 0x00725C28
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int GainVictoryPointsReward(IntPtr l)
	{
		int result;
		try
		{
			ArenaComponent arenaComponent = (ArenaComponent)LuaObject.checkSelf(l);
			int victoryPointsRewardIndex;
			LuaObject.checkType(l, 2, out victoryPointsRewardIndex);
			arenaComponent.GainVictoryPointsReward(victoryPointsRewardIndex);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601917B RID: 102779 RVA: 0x00727A80 File Offset: 0x00725C80
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int GetArenaPlayerInfo(IntPtr l)
	{
		int result;
		try
		{
			ArenaComponent arenaComponent = (ArenaComponent)LuaObject.checkSelf(l);
			ArenaPlayerInfo arenaPlayerInfo = arenaComponent.GetArenaPlayerInfo();
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, arenaPlayerInfo);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601917C RID: 102780 RVA: 0x00727AD4 File Offset: 0x00725CD4
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int GetArenaBattleReport(IntPtr l)
	{
		int result;
		try
		{
			ArenaComponent arenaComponent = (ArenaComponent)LuaObject.checkSelf(l);
			ulong instanceId;
			LuaObject.checkType(l, 2, out instanceId);
			ArenaBattleReport arenaBattleReport = arenaComponent.GetArenaBattleReport(instanceId);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, arenaBattleReport);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601917D RID: 102781 RVA: 0x00727B38 File Offset: 0x00725D38
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int OnStartArenaBattle(IntPtr l)
	{
		int result;
		try
		{
			ArenaComponent arenaComponent = (ArenaComponent)LuaObject.checkSelf(l);
			ArenaOpponentDefensiveBattleInfo battleInfo;
			LuaObject.checkType<ArenaOpponentDefensiveBattleInfo>(l, 2, out battleInfo);
			arenaComponent.m_luaExportHelper.OnStartArenaBattle(battleInfo);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601917E RID: 102782 RVA: 0x00727B94 File Offset: 0x00725D94
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_GetName(IntPtr l)
	{
		int result;
		try
		{
			ArenaComponent arenaComponent = (ArenaComponent)LuaObject.checkSelf(l);
			string s = arenaComponent.m_luaExportHelper.__callBase_GetName();
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

	// Token: 0x0601917F RID: 102783 RVA: 0x00727BF0 File Offset: 0x00725DF0
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int __callBase_Init(IntPtr l)
	{
		int result;
		try
		{
			ArenaComponent arenaComponent = (ArenaComponent)LuaObject.checkSelf(l);
			arenaComponent.m_luaExportHelper.__callBase_Init();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06019180 RID: 102784 RVA: 0x00727C44 File Offset: 0x00725E44
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_PostInit(IntPtr l)
	{
		int result;
		try
		{
			ArenaComponent arenaComponent = (ArenaComponent)LuaObject.checkSelf(l);
			arenaComponent.m_luaExportHelper.__callBase_PostInit();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06019181 RID: 102785 RVA: 0x00727C98 File Offset: 0x00725E98
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int __callBase_DeInit(IntPtr l)
	{
		int result;
		try
		{
			ArenaComponent arenaComponent = (ArenaComponent)LuaObject.checkSelf(l);
			arenaComponent.m_luaExportHelper.__callBase_DeInit();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06019182 RID: 102786 RVA: 0x00727CEC File Offset: 0x00725EEC
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int __callBase_Tick(IntPtr l)
	{
		int result;
		try
		{
			ArenaComponent arenaComponent = (ArenaComponent)LuaObject.checkSelf(l);
			uint deltaMillisecond;
			LuaObject.checkType(l, 2, out deltaMillisecond);
			arenaComponent.m_luaExportHelper.__callBase_Tick(deltaMillisecond);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06019183 RID: 102787 RVA: 0x00727D48 File Offset: 0x00725F48
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_OnBattleTimeOut(IntPtr l)
	{
		int result;
		try
		{
			ArenaComponent arenaComponent = (ArenaComponent)LuaObject.checkSelf(l);
			arenaComponent.m_luaExportHelper.__callBase_OnBattleTimeOut();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06019184 RID: 102788 RVA: 0x00727D9C File Offset: 0x00725F9C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_PostDeSerialize(IntPtr l)
	{
		int result;
		try
		{
			ArenaComponent arenaComponent = (ArenaComponent)LuaObject.checkSelf(l);
			arenaComponent.m_luaExportHelper.__callBase_PostDeSerialize();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06019185 RID: 102789 RVA: 0x00727DF0 File Offset: 0x00725FF0
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int __callBase_OnFinishedArenaBattle(IntPtr l)
	{
		int result;
		try
		{
			ArenaComponent arenaComponent = (ArenaComponent)LuaObject.checkSelf(l);
			ArenaOpponentDefensiveBattleInfo defensivBattleInfo;
			LuaObject.checkType<ArenaOpponentDefensiveBattleInfo>(l, 2, out defensivBattleInfo);
			bool isWin;
			LuaObject.checkType(l, 3, out isWin);
			arenaComponent.m_luaExportHelper.__callBase_OnFinishedArenaBattle(defensivBattleInfo, isWin);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06019186 RID: 102790 RVA: 0x00727E5C File Offset: 0x0072605C
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int __callBase_ResetThisWeekBattleInfo(IntPtr l)
	{
		int result;
		try
		{
			ArenaComponent arenaComponent = (ArenaComponent)LuaObject.checkSelf(l);
			arenaComponent.m_luaExportHelper.__callBase_ResetThisWeekBattleInfo();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06019187 RID: 102791 RVA: 0x00727EB0 File Offset: 0x007260B0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_InitArenaPlayerInfo(IntPtr l)
	{
		int result;
		try
		{
			ArenaComponent arenaComponent = (ArenaComponent)LuaObject.checkSelf(l);
			ArenaPlayerInfo info;
			LuaObject.checkType<ArenaPlayerInfo>(l, 2, out info);
			arenaComponent.m_luaExportHelper.__callBase_InitArenaPlayerInfo(info);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06019188 RID: 102792 RVA: 0x00727F0C File Offset: 0x0072610C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_AddReceivedVictoryPointsRewardIndex(IntPtr l)
	{
		int result;
		try
		{
			ArenaComponent arenaComponent = (ArenaComponent)LuaObject.checkSelf(l);
			int victoryPointsIndex;
			LuaObject.checkType(l, 2, out victoryPointsIndex);
			arenaComponent.m_luaExportHelper.__callBase_AddReceivedVictoryPointsRewardIndex(victoryPointsIndex);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06019189 RID: 102793 RVA: 0x00727F68 File Offset: 0x00726168
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_OnFlushVictoryPointsEvent(IntPtr l)
	{
		int result;
		try
		{
			ArenaComponent arenaComponent = (ArenaComponent)LuaObject.checkSelf(l);
			arenaComponent.m_luaExportHelper.__callBase_OnFlushVictoryPointsEvent();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601918A RID: 102794 RVA: 0x00727FBC File Offset: 0x007261BC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_OnArenaGiveTicketsEvent(IntPtr l)
	{
		int result;
		try
		{
			ArenaComponent arenaComponent = (ArenaComponent)LuaObject.checkSelf(l);
			arenaComponent.m_luaExportHelper.__callBase_OnArenaGiveTicketsEvent();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601918B RID: 102795 RVA: 0x00728010 File Offset: 0x00726210
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int __callBase_GetArenaDefensiveBattleInfo(IntPtr l)
	{
		int result;
		try
		{
			ArenaComponent arenaComponent = (ArenaComponent)LuaObject.checkSelf(l);
			ArenaOpponentDefensiveBattleInfo o = arenaComponent.m_luaExportHelper.__callBase_GetArenaDefensiveBattleInfo();
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

	// Token: 0x0601918C RID: 102796 RVA: 0x0072806C File Offset: 0x0072626C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_SetSuccessArenaBattle(IntPtr l)
	{
		int result;
		try
		{
			ArenaComponent arenaComponent = (ArenaComponent)LuaObject.checkSelf(l);
			int arenaOpponentPointZoneId;
			LuaObject.checkType(l, 2, out arenaOpponentPointZoneId);
			arenaComponent.m_luaExportHelper.__callBase_SetSuccessArenaBattle(arenaOpponentPointZoneId);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601918D RID: 102797 RVA: 0x007280C8 File Offset: 0x007262C8
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int __callBase_AddArenaBattleReport(IntPtr l)
	{
		int result;
		try
		{
			ArenaComponent arenaComponent = (ArenaComponent)LuaObject.checkSelf(l);
			ArenaBattleReport arenaBattleReport;
			LuaObject.checkType<ArenaBattleReport>(l, 2, out arenaBattleReport);
			arenaComponent.m_luaExportHelper.__callBase_AddArenaBattleReport(arenaBattleReport);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601918E RID: 102798 RVA: 0x00728124 File Offset: 0x00726324
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_SetArenaLevelIdAndPoints(IntPtr l)
	{
		int result;
		try
		{
			ArenaComponent arenaComponent = (ArenaComponent)LuaObject.checkSelf(l);
			int arenaLevelId;
			LuaObject.checkType(l, 2, out arenaLevelId);
			ushort arenaPoints;
			LuaObject.checkType(l, 3, out arenaPoints);
			arenaComponent.m_luaExportHelper.__callBase_SetArenaLevelIdAndPoints(arenaLevelId, arenaPoints);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601918F RID: 102799 RVA: 0x00728190 File Offset: 0x00726390
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_CanGetVictoryPointsReward(IntPtr l)
	{
		int result;
		try
		{
			ArenaComponent arenaComponent = (ArenaComponent)LuaObject.checkSelf(l);
			int victoryPointsRewardIndex;
			LuaObject.checkType(l, 2, out victoryPointsRewardIndex);
			int i = arenaComponent.m_luaExportHelper.__callBase_CanGetVictoryPointsReward(victoryPointsRewardIndex);
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

	// Token: 0x06019190 RID: 102800 RVA: 0x007281F8 File Offset: 0x007263F8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_CanViewOpponent(IntPtr l)
	{
		int result;
		try
		{
			ArenaComponent arenaComponent = (ArenaComponent)LuaObject.checkSelf(l);
			int index;
			LuaObject.checkType(l, 2, out index);
			int i = arenaComponent.m_luaExportHelper.__callBase_CanViewOpponent(index);
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

	// Token: 0x06019191 RID: 102801 RVA: 0x00728260 File Offset: 0x00726460
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int __callBase_CanAttackOpponent(IntPtr l)
	{
		int result;
		try
		{
			ArenaComponent arenaComponent = (ArenaComponent)LuaObject.checkSelf(l);
			int i = arenaComponent.m_luaExportHelper.__callBase_CanAttackOpponent();
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

	// Token: 0x06019192 RID: 102802 RVA: 0x007282BC File Offset: 0x007264BC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_CanAttackOpponentByClient(IntPtr l)
	{
		int result;
		try
		{
			ArenaComponent arenaComponent = (ArenaComponent)LuaObject.checkSelf(l);
			int i = arenaComponent.m_luaExportHelper.__callBase_CanAttackOpponentByClient();
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

	// Token: 0x06019193 RID: 102803 RVA: 0x00728318 File Offset: 0x00726518
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_CanRevengeOpponent(IntPtr l)
	{
		int result;
		try
		{
			ArenaComponent arenaComponent = (ArenaComponent)LuaObject.checkSelf(l);
			ulong battleReportInstanceId;
			LuaObject.checkType(l, 2, out battleReportInstanceId);
			int i = arenaComponent.m_luaExportHelper.__callBase_CanRevengeOpponent(battleReportInstanceId);
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

	// Token: 0x06019194 RID: 102804 RVA: 0x00728380 File Offset: 0x00726580
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_SetBattleReportRevenged(IntPtr l)
	{
		int result;
		try
		{
			ArenaComponent arenaComponent = (ArenaComponent)LuaObject.checkSelf(l);
			ArenaBattleReport battleReport;
			LuaObject.checkType<ArenaBattleReport>(l, 2, out battleReport);
			arenaComponent.m_luaExportHelper.__callBase_SetBattleReportRevenged(battleReport);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06019195 RID: 102805 RVA: 0x007283DC File Offset: 0x007265DC
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int __callBase_CanFlushOpponents(IntPtr l)
	{
		int result;
		try
		{
			ArenaComponent arenaComponent = (ArenaComponent)LuaObject.checkSelf(l);
			int i = arenaComponent.m_luaExportHelper.__callBase_CanFlushOpponents();
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

	// Token: 0x06019196 RID: 102806 RVA: 0x00728438 File Offset: 0x00726638
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_IsInSettleCacheTime(IntPtr l)
	{
		int result;
		try
		{
			ArenaComponent arenaComponent = (ArenaComponent)LuaObject.checkSelf(l);
			bool b = arenaComponent.m_luaExportHelper.__callBase_IsInSettleCacheTime();
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

	// Token: 0x06019197 RID: 102807 RVA: 0x00728494 File Offset: 0x00726694
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_IsInRealWeekSettleTime(IntPtr l)
	{
		int result;
		try
		{
			ArenaComponent arenaComponent = (ArenaComponent)LuaObject.checkSelf(l);
			bool b = arenaComponent.m_luaExportHelper.__callBase_IsInRealWeekSettleTime();
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

	// Token: 0x06019198 RID: 102808 RVA: 0x007284F0 File Offset: 0x007266F0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_IsArenaOpen(IntPtr l)
	{
		int result;
		try
		{
			ArenaComponent arenaComponent = (ArenaComponent)LuaObject.checkSelf(l);
			bool b = arenaComponent.m_luaExportHelper.__callBase_IsArenaOpen();
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

	// Token: 0x06019199 RID: 102809 RVA: 0x0072854C File Offset: 0x0072674C
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int __callBase_IsEmptyArenaPlayerInfo(IntPtr l)
	{
		int result;
		try
		{
			ArenaComponent arenaComponent = (ArenaComponent)LuaObject.checkSelf(l);
			bool b = arenaComponent.m_luaExportHelper.__callBase_IsEmptyArenaPlayerInfo();
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

	// Token: 0x0601919A RID: 102810 RVA: 0x007285A8 File Offset: 0x007267A8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_IsArenaInited(IntPtr l)
	{
		int result;
		try
		{
			ArenaComponent arenaComponent = (ArenaComponent)LuaObject.checkSelf(l);
			bool b = arenaComponent.m_luaExportHelper.__callBase_IsArenaInited();
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

	// Token: 0x0601919B RID: 102811 RVA: 0x00728604 File Offset: 0x00726804
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_IsVictoryPointsRewardGot(IntPtr l)
	{
		int result;
		try
		{
			ArenaComponent arenaComponent = (ArenaComponent)LuaObject.checkSelf(l);
			int victoryPointsRewardIndex;
			LuaObject.checkType(l, 2, out victoryPointsRewardIndex);
			bool b = arenaComponent.m_luaExportHelper.__callBase_IsVictoryPointsRewardGot(victoryPointsRewardIndex);
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

	// Token: 0x0601919C RID: 102812 RVA: 0x0072866C File Offset: 0x0072686C
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int __callBase_AttackOpponentFighting(IntPtr l)
	{
		int result;
		try
		{
			ArenaComponent arenaComponent = (ArenaComponent)LuaObject.checkSelf(l);
			int i = arenaComponent.m_luaExportHelper.__callBase_AttackOpponentFighting();
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

	// Token: 0x0601919D RID: 102813 RVA: 0x007286C8 File Offset: 0x007268C8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_ArenaBattleFinish(IntPtr l)
	{
		int result;
		try
		{
			ArenaComponent arenaComponent = (ArenaComponent)LuaObject.checkSelf(l);
			GameFunctionStatus status;
			LuaObject.checkEnum<GameFunctionStatus>(l, 2, out status);
			arenaComponent.m_luaExportHelper.__callBase_ArenaBattleFinish(status);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601919E RID: 102814 RVA: 0x00728724 File Offset: 0x00726924
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_SetUpFirstDefensiveTeam(IntPtr l)
	{
		int result;
		try
		{
			ArenaComponent arenaComponent = (ArenaComponent)LuaObject.checkSelf(l);
			arenaComponent.m_luaExportHelper.__callBase_SetUpFirstDefensiveTeam();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601919F RID: 102815 RVA: 0x00728778 File Offset: 0x00726978
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int __callBase_SetMineRank(IntPtr l)
	{
		int result;
		try
		{
			ArenaComponent arenaComponent = (ArenaComponent)LuaObject.checkSelf(l);
			int rank;
			LuaObject.checkType(l, 2, out rank);
			arenaComponent.m_luaExportHelper.__callBase_SetMineRank(rank);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060191A0 RID: 102816 RVA: 0x007287D4 File Offset: 0x007269D4
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int __callBase_GetMineRank(IntPtr l)
	{
		int result;
		try
		{
			ArenaComponent arenaComponent = (ArenaComponent)LuaObject.checkSelf(l);
			int i = arenaComponent.m_luaExportHelper.__callBase_GetMineRank();
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

	// Token: 0x060191A1 RID: 102817 RVA: 0x00728830 File Offset: 0x00726A30
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int __callBase_GetAllArenaBattleReports(IntPtr l)
	{
		int result;
		try
		{
			ArenaComponent arenaComponent = (ArenaComponent)LuaObject.checkSelf(l);
			List<ArenaBattleReport> o = arenaComponent.m_luaExportHelper.__callBase_GetAllArenaBattleReports();
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

	// Token: 0x060191A2 RID: 102818 RVA: 0x0072888C File Offset: 0x00726A8C
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int __callBase_ArenaConsecutiveSuccess(IntPtr l)
	{
		int result;
		try
		{
			ArenaComponent arenaComponent = (ArenaComponent)LuaObject.checkSelf(l);
			int consecutiveVictoryNums;
			LuaObject.checkType(l, 2, out consecutiveVictoryNums);
			arenaComponent.m_luaExportHelper.__callBase_ArenaConsecutiveSuccess(consecutiveVictoryNums);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060191A3 RID: 102819 RVA: 0x007288E8 File Offset: 0x00726AE8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_CanGetArenaTopRankPlayers(IntPtr l)
	{
		int result;
		try
		{
			ArenaComponent arenaComponent = (ArenaComponent)LuaObject.checkSelf(l);
			int i = arenaComponent.m_luaExportHelper.__callBase_CanGetArenaTopRankPlayers();
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

	// Token: 0x060191A4 RID: 102820 RVA: 0x00728944 File Offset: 0x00726B44
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_CanGetArenaPlayerInfo(IntPtr l)
	{
		int result;
		try
		{
			ArenaComponent arenaComponent = (ArenaComponent)LuaObject.checkSelf(l);
			int i = arenaComponent.m_luaExportHelper.__callBase_CanGetArenaPlayerInfo();
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

	// Token: 0x060191A5 RID: 102821 RVA: 0x007289A0 File Offset: 0x00726BA0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_CanReconnectArenaBattle(IntPtr l)
	{
		int result;
		try
		{
			ArenaComponent arenaComponent = (ArenaComponent)LuaObject.checkSelf(l);
			int i = arenaComponent.m_luaExportHelper.__callBase_CanReconnectArenaBattle();
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

	// Token: 0x060191A6 RID: 102822 RVA: 0x007289FC File Offset: 0x00726BFC
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int __callBase_ReconnectArenaBattle(IntPtr l)
	{
		int result;
		try
		{
			ArenaComponent arenaComponent = (ArenaComponent)LuaObject.checkSelf(l);
			int i = arenaComponent.m_luaExportHelper.__callBase_ReconnectArenaBattle();
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

	// Token: 0x060191A7 RID: 102823 RVA: 0x00728A58 File Offset: 0x00726C58
	[Preserve]
	public static void reg(IntPtr l)
	{
		LuaObject.getTypeTable(l, "BlackJack.ProjectL.PlayerContext.ArenaComponent");
		if (Lua_BlackJack_ProjectL_PlayerContext_ArenaComponent.<>f__mg$cache0 == null)
		{
			Lua_BlackJack_ProjectL_PlayerContext_ArenaComponent.<>f__mg$cache0 = new LuaCSFunction(Lua_BlackJack_ProjectL_PlayerContext_ArenaComponent.Init);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_PlayerContext_ArenaComponent.<>f__mg$cache0);
		if (Lua_BlackJack_ProjectL_PlayerContext_ArenaComponent.<>f__mg$cache1 == null)
		{
			Lua_BlackJack_ProjectL_PlayerContext_ArenaComponent.<>f__mg$cache1 = new LuaCSFunction(Lua_BlackJack_ProjectL_PlayerContext_ArenaComponent.PostInit);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_PlayerContext_ArenaComponent.<>f__mg$cache1);
		if (Lua_BlackJack_ProjectL_PlayerContext_ArenaComponent.<>f__mg$cache2 == null)
		{
			Lua_BlackJack_ProjectL_PlayerContext_ArenaComponent.<>f__mg$cache2 = new LuaCSFunction(Lua_BlackJack_ProjectL_PlayerContext_ArenaComponent.DeInit);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_PlayerContext_ArenaComponent.<>f__mg$cache2);
		if (Lua_BlackJack_ProjectL_PlayerContext_ArenaComponent.<>f__mg$cache3 == null)
		{
			Lua_BlackJack_ProjectL_PlayerContext_ArenaComponent.<>f__mg$cache3 = new LuaCSFunction(Lua_BlackJack_ProjectL_PlayerContext_ArenaComponent.Tick);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_PlayerContext_ArenaComponent.<>f__mg$cache3);
		if (Lua_BlackJack_ProjectL_PlayerContext_ArenaComponent.<>f__mg$cache4 == null)
		{
			Lua_BlackJack_ProjectL_PlayerContext_ArenaComponent.<>f__mg$cache4 = new LuaCSFunction(Lua_BlackJack_ProjectL_PlayerContext_ArenaComponent.GetArenaTicketNextGivenTime);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_PlayerContext_ArenaComponent.<>f__mg$cache4);
		if (Lua_BlackJack_ProjectL_PlayerContext_ArenaComponent.<>f__mg$cache5 == null)
		{
			Lua_BlackJack_ProjectL_PlayerContext_ArenaComponent.<>f__mg$cache5 = new LuaCSFunction(Lua_BlackJack_ProjectL_PlayerContext_ArenaComponent.DeSerialize);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_PlayerContext_ArenaComponent.<>f__mg$cache5);
		if (Lua_BlackJack_ProjectL_PlayerContext_ArenaComponent.<>f__mg$cache6 == null)
		{
			Lua_BlackJack_ProjectL_PlayerContext_ArenaComponent.<>f__mg$cache6 = new LuaCSFunction(Lua_BlackJack_ProjectL_PlayerContext_ArenaComponent.GetDSVersion);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_PlayerContext_ArenaComponent.<>f__mg$cache6);
		if (Lua_BlackJack_ProjectL_PlayerContext_ArenaComponent.<>f__mg$cache7 == null)
		{
			Lua_BlackJack_ProjectL_PlayerContext_ArenaComponent.<>f__mg$cache7 = new LuaCSFunction(Lua_BlackJack_ProjectL_PlayerContext_ArenaComponent.AddArenaBattleReportPlayBackData);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_PlayerContext_ArenaComponent.<>f__mg$cache7);
		if (Lua_BlackJack_ProjectL_PlayerContext_ArenaComponent.<>f__mg$cache8 == null)
		{
			Lua_BlackJack_ProjectL_PlayerContext_ArenaComponent.<>f__mg$cache8 = new LuaCSFunction(Lua_BlackJack_ProjectL_PlayerContext_ArenaComponent.StartArenaBattle);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_PlayerContext_ArenaComponent.<>f__mg$cache8);
		if (Lua_BlackJack_ProjectL_PlayerContext_ArenaComponent.<>f__mg$cache9 == null)
		{
			Lua_BlackJack_ProjectL_PlayerContext_ArenaComponent.<>f__mg$cache9 = new LuaCSFunction(Lua_BlackJack_ProjectL_PlayerContext_ArenaComponent.ReconnectArenaBattle);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_PlayerContext_ArenaComponent.<>f__mg$cache9);
		if (Lua_BlackJack_ProjectL_PlayerContext_ArenaComponent.<>f__mg$cacheA == null)
		{
			Lua_BlackJack_ProjectL_PlayerContext_ArenaComponent.<>f__mg$cacheA = new LuaCSFunction(Lua_BlackJack_ProjectL_PlayerContext_ArenaComponent.RevengeOpponent);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_PlayerContext_ArenaComponent.<>f__mg$cacheA);
		if (Lua_BlackJack_ProjectL_PlayerContext_ArenaComponent.<>f__mg$cacheB == null)
		{
			Lua_BlackJack_ProjectL_PlayerContext_ArenaComponent.<>f__mg$cacheB = new LuaCSFunction(Lua_BlackJack_ProjectL_PlayerContext_ArenaComponent.SetDefensiveTeam);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_PlayerContext_ArenaComponent.<>f__mg$cacheB);
		if (Lua_BlackJack_ProjectL_PlayerContext_ArenaComponent.<>f__mg$cacheC == null)
		{
			Lua_BlackJack_ProjectL_PlayerContext_ArenaComponent.<>f__mg$cacheC = new LuaCSFunction(Lua_BlackJack_ProjectL_PlayerContext_ArenaComponent.FinsihArenaBattle);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_PlayerContext_ArenaComponent.<>f__mg$cacheC);
		if (Lua_BlackJack_ProjectL_PlayerContext_ArenaComponent.<>f__mg$cacheD == null)
		{
			Lua_BlackJack_ProjectL_PlayerContext_ArenaComponent.<>f__mg$cacheD = new LuaCSFunction(Lua_BlackJack_ProjectL_PlayerContext_ArenaComponent.FlushOpponents);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_PlayerContext_ArenaComponent.<>f__mg$cacheD);
		if (Lua_BlackJack_ProjectL_PlayerContext_ArenaComponent.<>f__mg$cacheE == null)
		{
			Lua_BlackJack_ProjectL_PlayerContext_ArenaComponent.<>f__mg$cacheE = new LuaCSFunction(Lua_BlackJack_ProjectL_PlayerContext_ArenaComponent.InitArenaPlayInfo);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_PlayerContext_ArenaComponent.<>f__mg$cacheE);
		if (Lua_BlackJack_ProjectL_PlayerContext_ArenaComponent.<>f__mg$cacheF == null)
		{
			Lua_BlackJack_ProjectL_PlayerContext_ArenaComponent.<>f__mg$cacheF = new LuaCSFunction(Lua_BlackJack_ProjectL_PlayerContext_ArenaComponent.InitBattleReportBasicInfo);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_PlayerContext_ArenaComponent.<>f__mg$cacheF);
		if (Lua_BlackJack_ProjectL_PlayerContext_ArenaComponent.<>f__mg$cache10 == null)
		{
			Lua_BlackJack_ProjectL_PlayerContext_ArenaComponent.<>f__mg$cache10 = new LuaCSFunction(Lua_BlackJack_ProjectL_PlayerContext_ArenaComponent.GainVictoryPointsReward);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_PlayerContext_ArenaComponent.<>f__mg$cache10);
		if (Lua_BlackJack_ProjectL_PlayerContext_ArenaComponent.<>f__mg$cache11 == null)
		{
			Lua_BlackJack_ProjectL_PlayerContext_ArenaComponent.<>f__mg$cache11 = new LuaCSFunction(Lua_BlackJack_ProjectL_PlayerContext_ArenaComponent.GetArenaPlayerInfo);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_PlayerContext_ArenaComponent.<>f__mg$cache11);
		if (Lua_BlackJack_ProjectL_PlayerContext_ArenaComponent.<>f__mg$cache12 == null)
		{
			Lua_BlackJack_ProjectL_PlayerContext_ArenaComponent.<>f__mg$cache12 = new LuaCSFunction(Lua_BlackJack_ProjectL_PlayerContext_ArenaComponent.GetArenaBattleReport);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_PlayerContext_ArenaComponent.<>f__mg$cache12);
		if (Lua_BlackJack_ProjectL_PlayerContext_ArenaComponent.<>f__mg$cache13 == null)
		{
			Lua_BlackJack_ProjectL_PlayerContext_ArenaComponent.<>f__mg$cache13 = new LuaCSFunction(Lua_BlackJack_ProjectL_PlayerContext_ArenaComponent.OnStartArenaBattle);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_PlayerContext_ArenaComponent.<>f__mg$cache13);
		if (Lua_BlackJack_ProjectL_PlayerContext_ArenaComponent.<>f__mg$cache14 == null)
		{
			Lua_BlackJack_ProjectL_PlayerContext_ArenaComponent.<>f__mg$cache14 = new LuaCSFunction(Lua_BlackJack_ProjectL_PlayerContext_ArenaComponent.__callBase_GetName);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_PlayerContext_ArenaComponent.<>f__mg$cache14);
		if (Lua_BlackJack_ProjectL_PlayerContext_ArenaComponent.<>f__mg$cache15 == null)
		{
			Lua_BlackJack_ProjectL_PlayerContext_ArenaComponent.<>f__mg$cache15 = new LuaCSFunction(Lua_BlackJack_ProjectL_PlayerContext_ArenaComponent.__callBase_Init);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_PlayerContext_ArenaComponent.<>f__mg$cache15);
		if (Lua_BlackJack_ProjectL_PlayerContext_ArenaComponent.<>f__mg$cache16 == null)
		{
			Lua_BlackJack_ProjectL_PlayerContext_ArenaComponent.<>f__mg$cache16 = new LuaCSFunction(Lua_BlackJack_ProjectL_PlayerContext_ArenaComponent.__callBase_PostInit);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_PlayerContext_ArenaComponent.<>f__mg$cache16);
		if (Lua_BlackJack_ProjectL_PlayerContext_ArenaComponent.<>f__mg$cache17 == null)
		{
			Lua_BlackJack_ProjectL_PlayerContext_ArenaComponent.<>f__mg$cache17 = new LuaCSFunction(Lua_BlackJack_ProjectL_PlayerContext_ArenaComponent.__callBase_DeInit);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_PlayerContext_ArenaComponent.<>f__mg$cache17);
		if (Lua_BlackJack_ProjectL_PlayerContext_ArenaComponent.<>f__mg$cache18 == null)
		{
			Lua_BlackJack_ProjectL_PlayerContext_ArenaComponent.<>f__mg$cache18 = new LuaCSFunction(Lua_BlackJack_ProjectL_PlayerContext_ArenaComponent.__callBase_Tick);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_PlayerContext_ArenaComponent.<>f__mg$cache18);
		if (Lua_BlackJack_ProjectL_PlayerContext_ArenaComponent.<>f__mg$cache19 == null)
		{
			Lua_BlackJack_ProjectL_PlayerContext_ArenaComponent.<>f__mg$cache19 = new LuaCSFunction(Lua_BlackJack_ProjectL_PlayerContext_ArenaComponent.__callBase_OnBattleTimeOut);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_PlayerContext_ArenaComponent.<>f__mg$cache19);
		if (Lua_BlackJack_ProjectL_PlayerContext_ArenaComponent.<>f__mg$cache1A == null)
		{
			Lua_BlackJack_ProjectL_PlayerContext_ArenaComponent.<>f__mg$cache1A = new LuaCSFunction(Lua_BlackJack_ProjectL_PlayerContext_ArenaComponent.__callBase_PostDeSerialize);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_PlayerContext_ArenaComponent.<>f__mg$cache1A);
		if (Lua_BlackJack_ProjectL_PlayerContext_ArenaComponent.<>f__mg$cache1B == null)
		{
			Lua_BlackJack_ProjectL_PlayerContext_ArenaComponent.<>f__mg$cache1B = new LuaCSFunction(Lua_BlackJack_ProjectL_PlayerContext_ArenaComponent.__callBase_OnFinishedArenaBattle);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_PlayerContext_ArenaComponent.<>f__mg$cache1B);
		if (Lua_BlackJack_ProjectL_PlayerContext_ArenaComponent.<>f__mg$cache1C == null)
		{
			Lua_BlackJack_ProjectL_PlayerContext_ArenaComponent.<>f__mg$cache1C = new LuaCSFunction(Lua_BlackJack_ProjectL_PlayerContext_ArenaComponent.__callBase_ResetThisWeekBattleInfo);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_PlayerContext_ArenaComponent.<>f__mg$cache1C);
		if (Lua_BlackJack_ProjectL_PlayerContext_ArenaComponent.<>f__mg$cache1D == null)
		{
			Lua_BlackJack_ProjectL_PlayerContext_ArenaComponent.<>f__mg$cache1D = new LuaCSFunction(Lua_BlackJack_ProjectL_PlayerContext_ArenaComponent.__callBase_InitArenaPlayerInfo);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_PlayerContext_ArenaComponent.<>f__mg$cache1D);
		if (Lua_BlackJack_ProjectL_PlayerContext_ArenaComponent.<>f__mg$cache1E == null)
		{
			Lua_BlackJack_ProjectL_PlayerContext_ArenaComponent.<>f__mg$cache1E = new LuaCSFunction(Lua_BlackJack_ProjectL_PlayerContext_ArenaComponent.__callBase_AddReceivedVictoryPointsRewardIndex);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_PlayerContext_ArenaComponent.<>f__mg$cache1E);
		if (Lua_BlackJack_ProjectL_PlayerContext_ArenaComponent.<>f__mg$cache1F == null)
		{
			Lua_BlackJack_ProjectL_PlayerContext_ArenaComponent.<>f__mg$cache1F = new LuaCSFunction(Lua_BlackJack_ProjectL_PlayerContext_ArenaComponent.__callBase_OnFlushVictoryPointsEvent);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_PlayerContext_ArenaComponent.<>f__mg$cache1F);
		if (Lua_BlackJack_ProjectL_PlayerContext_ArenaComponent.<>f__mg$cache20 == null)
		{
			Lua_BlackJack_ProjectL_PlayerContext_ArenaComponent.<>f__mg$cache20 = new LuaCSFunction(Lua_BlackJack_ProjectL_PlayerContext_ArenaComponent.__callBase_OnArenaGiveTicketsEvent);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_PlayerContext_ArenaComponent.<>f__mg$cache20);
		if (Lua_BlackJack_ProjectL_PlayerContext_ArenaComponent.<>f__mg$cache21 == null)
		{
			Lua_BlackJack_ProjectL_PlayerContext_ArenaComponent.<>f__mg$cache21 = new LuaCSFunction(Lua_BlackJack_ProjectL_PlayerContext_ArenaComponent.__callBase_GetArenaDefensiveBattleInfo);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_PlayerContext_ArenaComponent.<>f__mg$cache21);
		if (Lua_BlackJack_ProjectL_PlayerContext_ArenaComponent.<>f__mg$cache22 == null)
		{
			Lua_BlackJack_ProjectL_PlayerContext_ArenaComponent.<>f__mg$cache22 = new LuaCSFunction(Lua_BlackJack_ProjectL_PlayerContext_ArenaComponent.__callBase_SetSuccessArenaBattle);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_PlayerContext_ArenaComponent.<>f__mg$cache22);
		if (Lua_BlackJack_ProjectL_PlayerContext_ArenaComponent.<>f__mg$cache23 == null)
		{
			Lua_BlackJack_ProjectL_PlayerContext_ArenaComponent.<>f__mg$cache23 = new LuaCSFunction(Lua_BlackJack_ProjectL_PlayerContext_ArenaComponent.__callBase_AddArenaBattleReport);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_PlayerContext_ArenaComponent.<>f__mg$cache23);
		if (Lua_BlackJack_ProjectL_PlayerContext_ArenaComponent.<>f__mg$cache24 == null)
		{
			Lua_BlackJack_ProjectL_PlayerContext_ArenaComponent.<>f__mg$cache24 = new LuaCSFunction(Lua_BlackJack_ProjectL_PlayerContext_ArenaComponent.__callBase_SetArenaLevelIdAndPoints);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_PlayerContext_ArenaComponent.<>f__mg$cache24);
		if (Lua_BlackJack_ProjectL_PlayerContext_ArenaComponent.<>f__mg$cache25 == null)
		{
			Lua_BlackJack_ProjectL_PlayerContext_ArenaComponent.<>f__mg$cache25 = new LuaCSFunction(Lua_BlackJack_ProjectL_PlayerContext_ArenaComponent.__callBase_CanGetVictoryPointsReward);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_PlayerContext_ArenaComponent.<>f__mg$cache25);
		if (Lua_BlackJack_ProjectL_PlayerContext_ArenaComponent.<>f__mg$cache26 == null)
		{
			Lua_BlackJack_ProjectL_PlayerContext_ArenaComponent.<>f__mg$cache26 = new LuaCSFunction(Lua_BlackJack_ProjectL_PlayerContext_ArenaComponent.__callBase_CanViewOpponent);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_PlayerContext_ArenaComponent.<>f__mg$cache26);
		if (Lua_BlackJack_ProjectL_PlayerContext_ArenaComponent.<>f__mg$cache27 == null)
		{
			Lua_BlackJack_ProjectL_PlayerContext_ArenaComponent.<>f__mg$cache27 = new LuaCSFunction(Lua_BlackJack_ProjectL_PlayerContext_ArenaComponent.__callBase_CanAttackOpponent);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_PlayerContext_ArenaComponent.<>f__mg$cache27);
		if (Lua_BlackJack_ProjectL_PlayerContext_ArenaComponent.<>f__mg$cache28 == null)
		{
			Lua_BlackJack_ProjectL_PlayerContext_ArenaComponent.<>f__mg$cache28 = new LuaCSFunction(Lua_BlackJack_ProjectL_PlayerContext_ArenaComponent.__callBase_CanAttackOpponentByClient);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_PlayerContext_ArenaComponent.<>f__mg$cache28);
		if (Lua_BlackJack_ProjectL_PlayerContext_ArenaComponent.<>f__mg$cache29 == null)
		{
			Lua_BlackJack_ProjectL_PlayerContext_ArenaComponent.<>f__mg$cache29 = new LuaCSFunction(Lua_BlackJack_ProjectL_PlayerContext_ArenaComponent.__callBase_CanRevengeOpponent);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_PlayerContext_ArenaComponent.<>f__mg$cache29);
		if (Lua_BlackJack_ProjectL_PlayerContext_ArenaComponent.<>f__mg$cache2A == null)
		{
			Lua_BlackJack_ProjectL_PlayerContext_ArenaComponent.<>f__mg$cache2A = new LuaCSFunction(Lua_BlackJack_ProjectL_PlayerContext_ArenaComponent.__callBase_SetBattleReportRevenged);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_PlayerContext_ArenaComponent.<>f__mg$cache2A);
		if (Lua_BlackJack_ProjectL_PlayerContext_ArenaComponent.<>f__mg$cache2B == null)
		{
			Lua_BlackJack_ProjectL_PlayerContext_ArenaComponent.<>f__mg$cache2B = new LuaCSFunction(Lua_BlackJack_ProjectL_PlayerContext_ArenaComponent.__callBase_CanFlushOpponents);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_PlayerContext_ArenaComponent.<>f__mg$cache2B);
		if (Lua_BlackJack_ProjectL_PlayerContext_ArenaComponent.<>f__mg$cache2C == null)
		{
			Lua_BlackJack_ProjectL_PlayerContext_ArenaComponent.<>f__mg$cache2C = new LuaCSFunction(Lua_BlackJack_ProjectL_PlayerContext_ArenaComponent.__callBase_IsInSettleCacheTime);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_PlayerContext_ArenaComponent.<>f__mg$cache2C);
		if (Lua_BlackJack_ProjectL_PlayerContext_ArenaComponent.<>f__mg$cache2D == null)
		{
			Lua_BlackJack_ProjectL_PlayerContext_ArenaComponent.<>f__mg$cache2D = new LuaCSFunction(Lua_BlackJack_ProjectL_PlayerContext_ArenaComponent.__callBase_IsInRealWeekSettleTime);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_PlayerContext_ArenaComponent.<>f__mg$cache2D);
		if (Lua_BlackJack_ProjectL_PlayerContext_ArenaComponent.<>f__mg$cache2E == null)
		{
			Lua_BlackJack_ProjectL_PlayerContext_ArenaComponent.<>f__mg$cache2E = new LuaCSFunction(Lua_BlackJack_ProjectL_PlayerContext_ArenaComponent.__callBase_IsArenaOpen);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_PlayerContext_ArenaComponent.<>f__mg$cache2E);
		if (Lua_BlackJack_ProjectL_PlayerContext_ArenaComponent.<>f__mg$cache2F == null)
		{
			Lua_BlackJack_ProjectL_PlayerContext_ArenaComponent.<>f__mg$cache2F = new LuaCSFunction(Lua_BlackJack_ProjectL_PlayerContext_ArenaComponent.__callBase_IsEmptyArenaPlayerInfo);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_PlayerContext_ArenaComponent.<>f__mg$cache2F);
		if (Lua_BlackJack_ProjectL_PlayerContext_ArenaComponent.<>f__mg$cache30 == null)
		{
			Lua_BlackJack_ProjectL_PlayerContext_ArenaComponent.<>f__mg$cache30 = new LuaCSFunction(Lua_BlackJack_ProjectL_PlayerContext_ArenaComponent.__callBase_IsArenaInited);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_PlayerContext_ArenaComponent.<>f__mg$cache30);
		if (Lua_BlackJack_ProjectL_PlayerContext_ArenaComponent.<>f__mg$cache31 == null)
		{
			Lua_BlackJack_ProjectL_PlayerContext_ArenaComponent.<>f__mg$cache31 = new LuaCSFunction(Lua_BlackJack_ProjectL_PlayerContext_ArenaComponent.__callBase_IsVictoryPointsRewardGot);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_PlayerContext_ArenaComponent.<>f__mg$cache31);
		if (Lua_BlackJack_ProjectL_PlayerContext_ArenaComponent.<>f__mg$cache32 == null)
		{
			Lua_BlackJack_ProjectL_PlayerContext_ArenaComponent.<>f__mg$cache32 = new LuaCSFunction(Lua_BlackJack_ProjectL_PlayerContext_ArenaComponent.__callBase_AttackOpponentFighting);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_PlayerContext_ArenaComponent.<>f__mg$cache32);
		if (Lua_BlackJack_ProjectL_PlayerContext_ArenaComponent.<>f__mg$cache33 == null)
		{
			Lua_BlackJack_ProjectL_PlayerContext_ArenaComponent.<>f__mg$cache33 = new LuaCSFunction(Lua_BlackJack_ProjectL_PlayerContext_ArenaComponent.__callBase_ArenaBattleFinish);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_PlayerContext_ArenaComponent.<>f__mg$cache33);
		if (Lua_BlackJack_ProjectL_PlayerContext_ArenaComponent.<>f__mg$cache34 == null)
		{
			Lua_BlackJack_ProjectL_PlayerContext_ArenaComponent.<>f__mg$cache34 = new LuaCSFunction(Lua_BlackJack_ProjectL_PlayerContext_ArenaComponent.__callBase_SetUpFirstDefensiveTeam);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_PlayerContext_ArenaComponent.<>f__mg$cache34);
		if (Lua_BlackJack_ProjectL_PlayerContext_ArenaComponent.<>f__mg$cache35 == null)
		{
			Lua_BlackJack_ProjectL_PlayerContext_ArenaComponent.<>f__mg$cache35 = new LuaCSFunction(Lua_BlackJack_ProjectL_PlayerContext_ArenaComponent.__callBase_SetMineRank);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_PlayerContext_ArenaComponent.<>f__mg$cache35);
		if (Lua_BlackJack_ProjectL_PlayerContext_ArenaComponent.<>f__mg$cache36 == null)
		{
			Lua_BlackJack_ProjectL_PlayerContext_ArenaComponent.<>f__mg$cache36 = new LuaCSFunction(Lua_BlackJack_ProjectL_PlayerContext_ArenaComponent.__callBase_GetMineRank);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_PlayerContext_ArenaComponent.<>f__mg$cache36);
		if (Lua_BlackJack_ProjectL_PlayerContext_ArenaComponent.<>f__mg$cache37 == null)
		{
			Lua_BlackJack_ProjectL_PlayerContext_ArenaComponent.<>f__mg$cache37 = new LuaCSFunction(Lua_BlackJack_ProjectL_PlayerContext_ArenaComponent.__callBase_GetAllArenaBattleReports);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_PlayerContext_ArenaComponent.<>f__mg$cache37);
		if (Lua_BlackJack_ProjectL_PlayerContext_ArenaComponent.<>f__mg$cache38 == null)
		{
			Lua_BlackJack_ProjectL_PlayerContext_ArenaComponent.<>f__mg$cache38 = new LuaCSFunction(Lua_BlackJack_ProjectL_PlayerContext_ArenaComponent.__callBase_ArenaConsecutiveSuccess);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_PlayerContext_ArenaComponent.<>f__mg$cache38);
		if (Lua_BlackJack_ProjectL_PlayerContext_ArenaComponent.<>f__mg$cache39 == null)
		{
			Lua_BlackJack_ProjectL_PlayerContext_ArenaComponent.<>f__mg$cache39 = new LuaCSFunction(Lua_BlackJack_ProjectL_PlayerContext_ArenaComponent.__callBase_CanGetArenaTopRankPlayers);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_PlayerContext_ArenaComponent.<>f__mg$cache39);
		if (Lua_BlackJack_ProjectL_PlayerContext_ArenaComponent.<>f__mg$cache3A == null)
		{
			Lua_BlackJack_ProjectL_PlayerContext_ArenaComponent.<>f__mg$cache3A = new LuaCSFunction(Lua_BlackJack_ProjectL_PlayerContext_ArenaComponent.__callBase_CanGetArenaPlayerInfo);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_PlayerContext_ArenaComponent.<>f__mg$cache3A);
		if (Lua_BlackJack_ProjectL_PlayerContext_ArenaComponent.<>f__mg$cache3B == null)
		{
			Lua_BlackJack_ProjectL_PlayerContext_ArenaComponent.<>f__mg$cache3B = new LuaCSFunction(Lua_BlackJack_ProjectL_PlayerContext_ArenaComponent.__callBase_CanReconnectArenaBattle);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_PlayerContext_ArenaComponent.<>f__mg$cache3B);
		if (Lua_BlackJack_ProjectL_PlayerContext_ArenaComponent.<>f__mg$cache3C == null)
		{
			Lua_BlackJack_ProjectL_PlayerContext_ArenaComponent.<>f__mg$cache3C = new LuaCSFunction(Lua_BlackJack_ProjectL_PlayerContext_ArenaComponent.__callBase_ReconnectArenaBattle);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_PlayerContext_ArenaComponent.<>f__mg$cache3C);
		if (Lua_BlackJack_ProjectL_PlayerContext_ArenaComponent.<>f__mg$cache3D == null)
		{
			Lua_BlackJack_ProjectL_PlayerContext_ArenaComponent.<>f__mg$cache3D = new LuaCSFunction(Lua_BlackJack_ProjectL_PlayerContext_ArenaComponent.constructor);
		}
		LuaObject.createTypeMetatable(l, Lua_BlackJack_ProjectL_PlayerContext_ArenaComponent.<>f__mg$cache3D, typeof(ArenaComponent), typeof(ArenaComponentCommon));
	}

	// Token: 0x0400F5E9 RID: 62953
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache0;

	// Token: 0x0400F5EA RID: 62954
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1;

	// Token: 0x0400F5EB RID: 62955
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2;

	// Token: 0x0400F5EC RID: 62956
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3;

	// Token: 0x0400F5ED RID: 62957
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache4;

	// Token: 0x0400F5EE RID: 62958
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache5;

	// Token: 0x0400F5EF RID: 62959
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache6;

	// Token: 0x0400F5F0 RID: 62960
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache7;

	// Token: 0x0400F5F1 RID: 62961
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache8;

	// Token: 0x0400F5F2 RID: 62962
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache9;

	// Token: 0x0400F5F3 RID: 62963
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheA;

	// Token: 0x0400F5F4 RID: 62964
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheB;

	// Token: 0x0400F5F5 RID: 62965
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheC;

	// Token: 0x0400F5F6 RID: 62966
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheD;

	// Token: 0x0400F5F7 RID: 62967
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheE;

	// Token: 0x0400F5F8 RID: 62968
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheF;

	// Token: 0x0400F5F9 RID: 62969
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache10;

	// Token: 0x0400F5FA RID: 62970
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache11;

	// Token: 0x0400F5FB RID: 62971
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache12;

	// Token: 0x0400F5FC RID: 62972
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache13;

	// Token: 0x0400F5FD RID: 62973
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache14;

	// Token: 0x0400F5FE RID: 62974
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache15;

	// Token: 0x0400F5FF RID: 62975
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache16;

	// Token: 0x0400F600 RID: 62976
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache17;

	// Token: 0x0400F601 RID: 62977
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache18;

	// Token: 0x0400F602 RID: 62978
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache19;

	// Token: 0x0400F603 RID: 62979
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1A;

	// Token: 0x0400F604 RID: 62980
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1B;

	// Token: 0x0400F605 RID: 62981
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1C;

	// Token: 0x0400F606 RID: 62982
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1D;

	// Token: 0x0400F607 RID: 62983
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1E;

	// Token: 0x0400F608 RID: 62984
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1F;

	// Token: 0x0400F609 RID: 62985
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache20;

	// Token: 0x0400F60A RID: 62986
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache21;

	// Token: 0x0400F60B RID: 62987
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache22;

	// Token: 0x0400F60C RID: 62988
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache23;

	// Token: 0x0400F60D RID: 62989
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache24;

	// Token: 0x0400F60E RID: 62990
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache25;

	// Token: 0x0400F60F RID: 62991
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache26;

	// Token: 0x0400F610 RID: 62992
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache27;

	// Token: 0x0400F611 RID: 62993
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache28;

	// Token: 0x0400F612 RID: 62994
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache29;

	// Token: 0x0400F613 RID: 62995
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2A;

	// Token: 0x0400F614 RID: 62996
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2B;

	// Token: 0x0400F615 RID: 62997
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2C;

	// Token: 0x0400F616 RID: 62998
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2D;

	// Token: 0x0400F617 RID: 62999
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2E;

	// Token: 0x0400F618 RID: 63000
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2F;

	// Token: 0x0400F619 RID: 63001
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache30;

	// Token: 0x0400F61A RID: 63002
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache31;

	// Token: 0x0400F61B RID: 63003
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache32;

	// Token: 0x0400F61C RID: 63004
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache33;

	// Token: 0x0400F61D RID: 63005
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache34;

	// Token: 0x0400F61E RID: 63006
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache35;

	// Token: 0x0400F61F RID: 63007
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache36;

	// Token: 0x0400F620 RID: 63008
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache37;

	// Token: 0x0400F621 RID: 63009
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache38;

	// Token: 0x0400F622 RID: 63010
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache39;

	// Token: 0x0400F623 RID: 63011
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3A;

	// Token: 0x0400F624 RID: 63012
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3B;

	// Token: 0x0400F625 RID: 63013
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3C;

	// Token: 0x0400F626 RID: 63014
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3D;
}
