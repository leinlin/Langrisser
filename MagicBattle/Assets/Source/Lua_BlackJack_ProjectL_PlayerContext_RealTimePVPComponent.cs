using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using BlackJack.ProjectL.Common;
using BlackJack.ProjectL.PlayerContext;
using BlackJack.ProjectL.Protocol;
using SLua;
using UnityEngine.Scripting;

// Token: 0x020012DC RID: 4828
[Preserve]
public class Lua_BlackJack_ProjectL_PlayerContext_RealTimePVPComponent : LuaObject
{
	// Token: 0x06019F88 RID: 106376 RVA: 0x0079C10C File Offset: 0x0079A30C
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int constructor(IntPtr l)
	{
		int result;
		try
		{
			RealTimePVPComponent o = new RealTimePVPComponent();
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

	// Token: 0x06019F89 RID: 106377 RVA: 0x0079C154 File Offset: 0x0079A354
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int Init(IntPtr l)
	{
		int result;
		try
		{
			RealTimePVPComponent realTimePVPComponent = (RealTimePVPComponent)LuaObject.checkSelf(l);
			realTimePVPComponent.Init();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06019F8A RID: 106378 RVA: 0x0079C1A0 File Offset: 0x0079A3A0
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int PostInit(IntPtr l)
	{
		int result;
		try
		{
			RealTimePVPComponent realTimePVPComponent = (RealTimePVPComponent)LuaObject.checkSelf(l);
			realTimePVPComponent.PostInit();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06019F8B RID: 106379 RVA: 0x0079C1EC File Offset: 0x0079A3EC
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int DeInit(IntPtr l)
	{
		int result;
		try
		{
			RealTimePVPComponent realTimePVPComponent = (RealTimePVPComponent)LuaObject.checkSelf(l);
			realTimePVPComponent.DeInit();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06019F8C RID: 106380 RVA: 0x0079C238 File Offset: 0x0079A438
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int DeSerialize(IntPtr l)
	{
		int result;
		try
		{
			RealTimePVPComponent realTimePVPComponent = (RealTimePVPComponent)LuaObject.checkSelf(l);
			DSRealTimePVPNtf msg;
			LuaObject.checkType<DSRealTimePVPNtf>(l, 2, out msg);
			realTimePVPComponent.DeSerialize(msg);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06019F8D RID: 106381 RVA: 0x0079C290 File Offset: 0x0079A490
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int GetDSVersion(IntPtr l)
	{
		int result;
		try
		{
			RealTimePVPComponent realTimePVPComponent = (RealTimePVPComponent)LuaObject.checkSelf(l);
			ushort dsversion = realTimePVPComponent.GetDSVersion();
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

	// Token: 0x06019F8E RID: 106382 RVA: 0x0079C2E4 File Offset: 0x0079A4E4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int GetLadderMatchStats(IntPtr l)
	{
		int result;
		try
		{
			RealTimePVPComponent realTimePVPComponent = (RealTimePVPComponent)LuaObject.checkSelf(l);
			RealTimePVPMatchStats ladderMatchStats = realTimePVPComponent.GetLadderMatchStats();
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, ladderMatchStats);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06019F8F RID: 106383 RVA: 0x0079C338 File Offset: 0x0079A538
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int GetFriendlyMatchStats(IntPtr l)
	{
		int result;
		try
		{
			RealTimePVPComponent realTimePVPComponent = (RealTimePVPComponent)LuaObject.checkSelf(l);
			RealTimePVPMatchStats friendlyMatchStats = realTimePVPComponent.GetFriendlyMatchStats();
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, friendlyMatchStats);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06019F90 RID: 106384 RVA: 0x0079C38C File Offset: 0x0079A58C
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int __callBase_GetName(IntPtr l)
	{
		int result;
		try
		{
			RealTimePVPComponent realTimePVPComponent = (RealTimePVPComponent)LuaObject.checkSelf(l);
			string s = realTimePVPComponent.m_luaExportHelper.__callBase_GetName();
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

	// Token: 0x06019F91 RID: 106385 RVA: 0x0079C3E8 File Offset: 0x0079A5E8
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int __callBase_Init(IntPtr l)
	{
		int result;
		try
		{
			RealTimePVPComponent realTimePVPComponent = (RealTimePVPComponent)LuaObject.checkSelf(l);
			realTimePVPComponent.m_luaExportHelper.__callBase_Init();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06019F92 RID: 106386 RVA: 0x0079C43C File Offset: 0x0079A63C
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int __callBase_PostInit(IntPtr l)
	{
		int result;
		try
		{
			RealTimePVPComponent realTimePVPComponent = (RealTimePVPComponent)LuaObject.checkSelf(l);
			realTimePVPComponent.m_luaExportHelper.__callBase_PostInit();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06019F93 RID: 106387 RVA: 0x0079C490 File Offset: 0x0079A690
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int __callBase_DeInit(IntPtr l)
	{
		int result;
		try
		{
			RealTimePVPComponent realTimePVPComponent = (RealTimePVPComponent)LuaObject.checkSelf(l);
			realTimePVPComponent.m_luaExportHelper.__callBase_DeInit();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06019F94 RID: 106388 RVA: 0x0079C4E4 File Offset: 0x0079A6E4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_Tick(IntPtr l)
	{
		int result;
		try
		{
			RealTimePVPComponent realTimePVPComponent = (RealTimePVPComponent)LuaObject.checkSelf(l);
			uint deltaMillisecond;
			LuaObject.checkType(l, 2, out deltaMillisecond);
			realTimePVPComponent.m_luaExportHelper.__callBase_Tick(deltaMillisecond);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06019F95 RID: 106389 RVA: 0x0079C540 File Offset: 0x0079A740
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_PostDeSerialize(IntPtr l)
	{
		int result;
		try
		{
			RealTimePVPComponent realTimePVPComponent = (RealTimePVPComponent)LuaObject.checkSelf(l);
			realTimePVPComponent.m_luaExportHelper.__callBase_PostDeSerialize();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06019F96 RID: 106390 RVA: 0x0079C594 File Offset: 0x0079A794
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int __callBase_RealTimeArenaDanUpdate(IntPtr l)
	{
		int result;
		try
		{
			RealTimePVPComponent realTimePVPComponent = (RealTimePVPComponent)LuaObject.checkSelf(l);
			int dan;
			LuaObject.checkType(l, 2, out dan);
			realTimePVPComponent.m_luaExportHelper.__callBase_RealTimeArenaDanUpdate(dan);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06019F97 RID: 106391 RVA: 0x0079C5F0 File Offset: 0x0079A7F0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_RealTimeArenaBattleFinish(IntPtr l)
	{
		int result;
		try
		{
			RealTimePVPComponent realTimePVPComponent = (RealTimePVPComponent)LuaObject.checkSelf(l);
			BattleMode mode;
			LuaObject.checkEnum<BattleMode>(l, 2, out mode);
			bool win;
			LuaObject.checkType(l, 3, out win);
			realTimePVPComponent.m_luaExportHelper.__callBase_RealTimeArenaBattleFinish(mode, win);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06019F98 RID: 106392 RVA: 0x0079C65C File Offset: 0x0079A85C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_RealTimeArenaBattleStart(IntPtr l)
	{
		int result;
		try
		{
			RealTimePVPComponent realTimePVPComponent = (RealTimePVPComponent)LuaObject.checkSelf(l);
			BattleMode mode;
			LuaObject.checkEnum<BattleMode>(l, 2, out mode);
			realTimePVPComponent.m_luaExportHelper.__callBase_RealTimeArenaBattleStart(mode);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06019F99 RID: 106393 RVA: 0x0079C6B8 File Offset: 0x0079A8B8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_IsRealTimePVPUnlocked(IntPtr l)
	{
		int result;
		try
		{
			RealTimePVPComponent realTimePVPComponent = (RealTimePVPComponent)LuaObject.checkSelf(l);
			int i = realTimePVPComponent.m_luaExportHelper.__callBase_IsRealTimePVPUnlocked();
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

	// Token: 0x06019F9A RID: 106394 RVA: 0x0079C714 File Offset: 0x0079A914
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_IsRealTimePVPArenaAvailable(IntPtr l)
	{
		int result;
		try
		{
			RealTimePVPComponent realTimePVPComponent = (RealTimePVPComponent)LuaObject.checkSelf(l);
			BattleMode mode;
			LuaObject.checkEnum<BattleMode>(l, 2, out mode);
			int i = realTimePVPComponent.m_luaExportHelper.__callBase_IsRealTimePVPArenaAvailable(mode);
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

	// Token: 0x06019F9B RID: 106395 RVA: 0x0079C77C File Offset: 0x0079A97C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_OnFlushRealTimePVP(IntPtr l)
	{
		int result;
		try
		{
			RealTimePVPComponent realTimePVPComponent = (RealTimePVPComponent)LuaObject.checkSelf(l);
			realTimePVPComponent.m_luaExportHelper.__callBase_OnFlushRealTimePVP();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06019F9C RID: 106396 RVA: 0x0079C7D0 File Offset: 0x0079A9D0
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int __callBase_StartNewSeason(IntPtr l)
	{
		int result;
		try
		{
			RealTimePVPComponent realTimePVPComponent = (RealTimePVPComponent)LuaObject.checkSelf(l);
			realTimePVPComponent.m_luaExportHelper.__callBase_StartNewSeason();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06019F9D RID: 106397 RVA: 0x0079C824 File Offset: 0x0079AA24
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_IsPromotion(IntPtr l)
	{
		int result;
		try
		{
			RealTimePVPComponent realTimePVPComponent = (RealTimePVPComponent)LuaObject.checkSelf(l);
			bool b = realTimePVPComponent.m_luaExportHelper.__callBase_IsPromotion();
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

	// Token: 0x06019F9E RID: 106398 RVA: 0x0079C880 File Offset: 0x0079AA80
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int __callBase_GetPromotionBattleReports(IntPtr l)
	{
		int result;
		try
		{
			RealTimePVPComponent realTimePVPComponent = (RealTimePVPComponent)LuaObject.checkSelf(l);
			LinkedList<RealTimePVPBattleReport> o = realTimePVPComponent.m_luaExportHelper.__callBase_GetPromotionBattleReports();
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

	// Token: 0x06019F9F RID: 106399 RVA: 0x0079C8DC File Offset: 0x0079AADC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_GetBattleReports(IntPtr l)
	{
		int result;
		try
		{
			RealTimePVPComponent realTimePVPComponent = (RealTimePVPComponent)LuaObject.checkSelf(l);
			LinkedList<RealTimePVPBattleReport> o = realTimePVPComponent.m_luaExportHelper.__callBase_GetBattleReports();
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

	// Token: 0x06019FA0 RID: 106400 RVA: 0x0079C938 File Offset: 0x0079AB38
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int __callBase_StartPromotion(IntPtr l)
	{
		int result;
		try
		{
			RealTimePVPComponent realTimePVPComponent = (RealTimePVPComponent)LuaObject.checkSelf(l);
			realTimePVPComponent.m_luaExportHelper.__callBase_StartPromotion();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06019FA1 RID: 106401 RVA: 0x0079C98C File Offset: 0x0079AB8C
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int __callBase_EndPromotion(IntPtr l)
	{
		int result;
		try
		{
			RealTimePVPComponent realTimePVPComponent = (RealTimePVPComponent)LuaObject.checkSelf(l);
			realTimePVPComponent.m_luaExportHelper.__callBase_EndPromotion();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06019FA2 RID: 106402 RVA: 0x0079C9E0 File Offset: 0x0079ABE0
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int __callBase_SavePromotionReport(IntPtr l)
	{
		int result;
		try
		{
			RealTimePVPComponent realTimePVPComponent = (RealTimePVPComponent)LuaObject.checkSelf(l);
			RealTimePVPBattleReport report;
			LuaObject.checkType<RealTimePVPBattleReport>(l, 2, out report);
			realTimePVPComponent.m_luaExportHelper.__callBase_SavePromotionReport(report);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06019FA3 RID: 106403 RVA: 0x0079CA3C File Offset: 0x0079AC3C
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int __callBase_SaveReport(IntPtr l)
	{
		int result;
		try
		{
			RealTimePVPComponent realTimePVPComponent = (RealTimePVPComponent)LuaObject.checkSelf(l);
			RealTimePVPBattleReport report;
			LuaObject.checkType<RealTimePVPBattleReport>(l, 2, out report);
			realTimePVPComponent.m_luaExportHelper.__callBase_SaveReport(report);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06019FA4 RID: 106404 RVA: 0x0079CA98 File Offset: 0x0079AC98
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int __callBase_CheckAcquireWinsBonus(IntPtr l)
	{
		int result;
		try
		{
			RealTimePVPComponent realTimePVPComponent = (RealTimePVPComponent)LuaObject.checkSelf(l);
			int bonusId;
			LuaObject.checkType(l, 2, out bonusId);
			int i = realTimePVPComponent.m_luaExportHelper.__callBase_CheckAcquireWinsBonus(bonusId);
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

	// Token: 0x06019FA5 RID: 106405 RVA: 0x0079CB00 File Offset: 0x0079AD00
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_AcquireWinsBonus(IntPtr l)
	{
		int result;
		try
		{
			RealTimePVPComponent realTimePVPComponent = (RealTimePVPComponent)LuaObject.checkSelf(l);
			int bonusId;
			LuaObject.checkType(l, 2, out bonusId);
			int i = realTimePVPComponent.m_luaExportHelper.__callBase_AcquireWinsBonus(bonusId);
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

	// Token: 0x06019FA6 RID: 106406 RVA: 0x0079CB68 File Offset: 0x0079AD68
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_GetConsecutiveWins(IntPtr l)
	{
		int result;
		try
		{
			RealTimePVPComponent realTimePVPComponent = (RealTimePVPComponent)LuaObject.checkSelf(l);
			BattleMode mode;
			LuaObject.checkEnum<BattleMode>(l, 2, out mode);
			int i = realTimePVPComponent.m_luaExportHelper.__callBase_GetConsecutiveWins(mode);
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

	// Token: 0x06019FA7 RID: 106407 RVA: 0x0079CBD0 File Offset: 0x0079ADD0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_GetConsecutiveLosses(IntPtr l)
	{
		int result;
		try
		{
			RealTimePVPComponent realTimePVPComponent = (RealTimePVPComponent)LuaObject.checkSelf(l);
			BattleMode mode;
			LuaObject.checkEnum<BattleMode>(l, 2, out mode);
			int i = realTimePVPComponent.m_luaExportHelper.__callBase_GetConsecutiveLosses(mode);
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

	// Token: 0x06019FA8 RID: 106408 RVA: 0x0079CC38 File Offset: 0x0079AE38
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int __callBase_GetLadderCareerMatchStats(IntPtr l)
	{
		int result;
		try
		{
			RealTimePVPComponent realTimePVPComponent = (RealTimePVPComponent)LuaObject.checkSelf(l);
			RealTimePVPMatchStats o = realTimePVPComponent.m_luaExportHelper.__callBase_GetLadderCareerMatchStats();
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

	// Token: 0x06019FA9 RID: 106409 RVA: 0x0079CC94 File Offset: 0x0079AE94
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int __callBase_TryGetBotParamsForNovice(IntPtr l)
	{
		int result;
		try
		{
			RealTimePVPComponent realTimePVPComponent = (RealTimePVPComponent)LuaObject.checkSelf(l);
			BattleMode mode;
			LuaObject.checkEnum<BattleMode>(l, 2, out mode);
			int myScore;
			LuaObject.checkType(l, 3, out myScore);
			int i;
			int i2;
			int i3;
			int i4;
			bool b = realTimePVPComponent.m_luaExportHelper.__callBase_TryGetBotParamsForNovice(mode, myScore, out i, out i2, out i3, out i4);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, b);
			LuaObject.pushValue(l, i);
			LuaObject.pushValue(l, i2);
			LuaObject.pushValue(l, i3);
			LuaObject.pushValue(l, i4);
			result = 6;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06019FAA RID: 106410 RVA: 0x0079CD34 File Offset: 0x0079AF34
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int __callBase_TryGetBotParamsForLoser(IntPtr l)
	{
		int result;
		try
		{
			RealTimePVPComponent realTimePVPComponent = (RealTimePVPComponent)LuaObject.checkSelf(l);
			BattleMode mode;
			LuaObject.checkEnum<BattleMode>(l, 2, out mode);
			int myScore;
			LuaObject.checkType(l, 3, out myScore);
			int dan;
			LuaObject.checkType(l, 4, out dan);
			int i;
			int i2;
			int i3;
			int i4;
			bool b = realTimePVPComponent.m_luaExportHelper.__callBase_TryGetBotParamsForLoser(mode, myScore, dan, out i, out i2, out i3, out i4);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, b);
			LuaObject.pushValue(l, i);
			LuaObject.pushValue(l, i2);
			LuaObject.pushValue(l, i3);
			LuaObject.pushValue(l, i4);
			result = 6;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06019FAB RID: 106411 RVA: 0x0079CDE0 File Offset: 0x0079AFE0
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_Dan(IntPtr l)
	{
		int result;
		try
		{
			RealTimePVPComponent realTimePVPComponent = (RealTimePVPComponent)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, realTimePVPComponent.Dan);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06019FAC RID: 106412 RVA: 0x0079CE34 File Offset: 0x0079B034
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_Dan(IntPtr l)
	{
		int result;
		try
		{
			RealTimePVPComponent realTimePVPComponent = (RealTimePVPComponent)LuaObject.checkSelf(l);
			int dan;
			LuaObject.checkType(l, 2, out dan);
			realTimePVPComponent.Dan = dan;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06019FAD RID: 106413 RVA: 0x0079CE8C File Offset: 0x0079B08C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_Score(IntPtr l)
	{
		int result;
		try
		{
			RealTimePVPComponent realTimePVPComponent = (RealTimePVPComponent)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, realTimePVPComponent.Score);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06019FAE RID: 106414 RVA: 0x0079CEE0 File Offset: 0x0079B0E0
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_Score(IntPtr l)
	{
		int result;
		try
		{
			RealTimePVPComponent realTimePVPComponent = (RealTimePVPComponent)LuaObject.checkSelf(l);
			int score;
			LuaObject.checkType(l, 2, out score);
			realTimePVPComponent.Score = score;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06019FAF RID: 106415 RVA: 0x0079CF38 File Offset: 0x0079B138
	[Preserve]
	public static void reg(IntPtr l)
	{
		LuaObject.getTypeTable(l, "BlackJack.ProjectL.PlayerContext.RealTimePVPComponent");
		if (Lua_BlackJack_ProjectL_PlayerContext_RealTimePVPComponent.<>f__mg$cache0 == null)
		{
			Lua_BlackJack_ProjectL_PlayerContext_RealTimePVPComponent.<>f__mg$cache0 = new LuaCSFunction(Lua_BlackJack_ProjectL_PlayerContext_RealTimePVPComponent.Init);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_PlayerContext_RealTimePVPComponent.<>f__mg$cache0);
		if (Lua_BlackJack_ProjectL_PlayerContext_RealTimePVPComponent.<>f__mg$cache1 == null)
		{
			Lua_BlackJack_ProjectL_PlayerContext_RealTimePVPComponent.<>f__mg$cache1 = new LuaCSFunction(Lua_BlackJack_ProjectL_PlayerContext_RealTimePVPComponent.PostInit);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_PlayerContext_RealTimePVPComponent.<>f__mg$cache1);
		if (Lua_BlackJack_ProjectL_PlayerContext_RealTimePVPComponent.<>f__mg$cache2 == null)
		{
			Lua_BlackJack_ProjectL_PlayerContext_RealTimePVPComponent.<>f__mg$cache2 = new LuaCSFunction(Lua_BlackJack_ProjectL_PlayerContext_RealTimePVPComponent.DeInit);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_PlayerContext_RealTimePVPComponent.<>f__mg$cache2);
		if (Lua_BlackJack_ProjectL_PlayerContext_RealTimePVPComponent.<>f__mg$cache3 == null)
		{
			Lua_BlackJack_ProjectL_PlayerContext_RealTimePVPComponent.<>f__mg$cache3 = new LuaCSFunction(Lua_BlackJack_ProjectL_PlayerContext_RealTimePVPComponent.DeSerialize);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_PlayerContext_RealTimePVPComponent.<>f__mg$cache3);
		if (Lua_BlackJack_ProjectL_PlayerContext_RealTimePVPComponent.<>f__mg$cache4 == null)
		{
			Lua_BlackJack_ProjectL_PlayerContext_RealTimePVPComponent.<>f__mg$cache4 = new LuaCSFunction(Lua_BlackJack_ProjectL_PlayerContext_RealTimePVPComponent.GetDSVersion);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_PlayerContext_RealTimePVPComponent.<>f__mg$cache4);
		if (Lua_BlackJack_ProjectL_PlayerContext_RealTimePVPComponent.<>f__mg$cache5 == null)
		{
			Lua_BlackJack_ProjectL_PlayerContext_RealTimePVPComponent.<>f__mg$cache5 = new LuaCSFunction(Lua_BlackJack_ProjectL_PlayerContext_RealTimePVPComponent.GetLadderMatchStats);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_PlayerContext_RealTimePVPComponent.<>f__mg$cache5);
		if (Lua_BlackJack_ProjectL_PlayerContext_RealTimePVPComponent.<>f__mg$cache6 == null)
		{
			Lua_BlackJack_ProjectL_PlayerContext_RealTimePVPComponent.<>f__mg$cache6 = new LuaCSFunction(Lua_BlackJack_ProjectL_PlayerContext_RealTimePVPComponent.GetFriendlyMatchStats);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_PlayerContext_RealTimePVPComponent.<>f__mg$cache6);
		if (Lua_BlackJack_ProjectL_PlayerContext_RealTimePVPComponent.<>f__mg$cache7 == null)
		{
			Lua_BlackJack_ProjectL_PlayerContext_RealTimePVPComponent.<>f__mg$cache7 = new LuaCSFunction(Lua_BlackJack_ProjectL_PlayerContext_RealTimePVPComponent.__callBase_GetName);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_PlayerContext_RealTimePVPComponent.<>f__mg$cache7);
		if (Lua_BlackJack_ProjectL_PlayerContext_RealTimePVPComponent.<>f__mg$cache8 == null)
		{
			Lua_BlackJack_ProjectL_PlayerContext_RealTimePVPComponent.<>f__mg$cache8 = new LuaCSFunction(Lua_BlackJack_ProjectL_PlayerContext_RealTimePVPComponent.__callBase_Init);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_PlayerContext_RealTimePVPComponent.<>f__mg$cache8);
		if (Lua_BlackJack_ProjectL_PlayerContext_RealTimePVPComponent.<>f__mg$cache9 == null)
		{
			Lua_BlackJack_ProjectL_PlayerContext_RealTimePVPComponent.<>f__mg$cache9 = new LuaCSFunction(Lua_BlackJack_ProjectL_PlayerContext_RealTimePVPComponent.__callBase_PostInit);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_PlayerContext_RealTimePVPComponent.<>f__mg$cache9);
		if (Lua_BlackJack_ProjectL_PlayerContext_RealTimePVPComponent.<>f__mg$cacheA == null)
		{
			Lua_BlackJack_ProjectL_PlayerContext_RealTimePVPComponent.<>f__mg$cacheA = new LuaCSFunction(Lua_BlackJack_ProjectL_PlayerContext_RealTimePVPComponent.__callBase_DeInit);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_PlayerContext_RealTimePVPComponent.<>f__mg$cacheA);
		if (Lua_BlackJack_ProjectL_PlayerContext_RealTimePVPComponent.<>f__mg$cacheB == null)
		{
			Lua_BlackJack_ProjectL_PlayerContext_RealTimePVPComponent.<>f__mg$cacheB = new LuaCSFunction(Lua_BlackJack_ProjectL_PlayerContext_RealTimePVPComponent.__callBase_Tick);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_PlayerContext_RealTimePVPComponent.<>f__mg$cacheB);
		if (Lua_BlackJack_ProjectL_PlayerContext_RealTimePVPComponent.<>f__mg$cacheC == null)
		{
			Lua_BlackJack_ProjectL_PlayerContext_RealTimePVPComponent.<>f__mg$cacheC = new LuaCSFunction(Lua_BlackJack_ProjectL_PlayerContext_RealTimePVPComponent.__callBase_PostDeSerialize);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_PlayerContext_RealTimePVPComponent.<>f__mg$cacheC);
		if (Lua_BlackJack_ProjectL_PlayerContext_RealTimePVPComponent.<>f__mg$cacheD == null)
		{
			Lua_BlackJack_ProjectL_PlayerContext_RealTimePVPComponent.<>f__mg$cacheD = new LuaCSFunction(Lua_BlackJack_ProjectL_PlayerContext_RealTimePVPComponent.__callBase_RealTimeArenaDanUpdate);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_PlayerContext_RealTimePVPComponent.<>f__mg$cacheD);
		if (Lua_BlackJack_ProjectL_PlayerContext_RealTimePVPComponent.<>f__mg$cacheE == null)
		{
			Lua_BlackJack_ProjectL_PlayerContext_RealTimePVPComponent.<>f__mg$cacheE = new LuaCSFunction(Lua_BlackJack_ProjectL_PlayerContext_RealTimePVPComponent.__callBase_RealTimeArenaBattleFinish);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_PlayerContext_RealTimePVPComponent.<>f__mg$cacheE);
		if (Lua_BlackJack_ProjectL_PlayerContext_RealTimePVPComponent.<>f__mg$cacheF == null)
		{
			Lua_BlackJack_ProjectL_PlayerContext_RealTimePVPComponent.<>f__mg$cacheF = new LuaCSFunction(Lua_BlackJack_ProjectL_PlayerContext_RealTimePVPComponent.__callBase_RealTimeArenaBattleStart);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_PlayerContext_RealTimePVPComponent.<>f__mg$cacheF);
		if (Lua_BlackJack_ProjectL_PlayerContext_RealTimePVPComponent.<>f__mg$cache10 == null)
		{
			Lua_BlackJack_ProjectL_PlayerContext_RealTimePVPComponent.<>f__mg$cache10 = new LuaCSFunction(Lua_BlackJack_ProjectL_PlayerContext_RealTimePVPComponent.__callBase_IsRealTimePVPUnlocked);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_PlayerContext_RealTimePVPComponent.<>f__mg$cache10);
		if (Lua_BlackJack_ProjectL_PlayerContext_RealTimePVPComponent.<>f__mg$cache11 == null)
		{
			Lua_BlackJack_ProjectL_PlayerContext_RealTimePVPComponent.<>f__mg$cache11 = new LuaCSFunction(Lua_BlackJack_ProjectL_PlayerContext_RealTimePVPComponent.__callBase_IsRealTimePVPArenaAvailable);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_PlayerContext_RealTimePVPComponent.<>f__mg$cache11);
		if (Lua_BlackJack_ProjectL_PlayerContext_RealTimePVPComponent.<>f__mg$cache12 == null)
		{
			Lua_BlackJack_ProjectL_PlayerContext_RealTimePVPComponent.<>f__mg$cache12 = new LuaCSFunction(Lua_BlackJack_ProjectL_PlayerContext_RealTimePVPComponent.__callBase_OnFlushRealTimePVP);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_PlayerContext_RealTimePVPComponent.<>f__mg$cache12);
		if (Lua_BlackJack_ProjectL_PlayerContext_RealTimePVPComponent.<>f__mg$cache13 == null)
		{
			Lua_BlackJack_ProjectL_PlayerContext_RealTimePVPComponent.<>f__mg$cache13 = new LuaCSFunction(Lua_BlackJack_ProjectL_PlayerContext_RealTimePVPComponent.__callBase_StartNewSeason);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_PlayerContext_RealTimePVPComponent.<>f__mg$cache13);
		if (Lua_BlackJack_ProjectL_PlayerContext_RealTimePVPComponent.<>f__mg$cache14 == null)
		{
			Lua_BlackJack_ProjectL_PlayerContext_RealTimePVPComponent.<>f__mg$cache14 = new LuaCSFunction(Lua_BlackJack_ProjectL_PlayerContext_RealTimePVPComponent.__callBase_IsPromotion);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_PlayerContext_RealTimePVPComponent.<>f__mg$cache14);
		if (Lua_BlackJack_ProjectL_PlayerContext_RealTimePVPComponent.<>f__mg$cache15 == null)
		{
			Lua_BlackJack_ProjectL_PlayerContext_RealTimePVPComponent.<>f__mg$cache15 = new LuaCSFunction(Lua_BlackJack_ProjectL_PlayerContext_RealTimePVPComponent.__callBase_GetPromotionBattleReports);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_PlayerContext_RealTimePVPComponent.<>f__mg$cache15);
		if (Lua_BlackJack_ProjectL_PlayerContext_RealTimePVPComponent.<>f__mg$cache16 == null)
		{
			Lua_BlackJack_ProjectL_PlayerContext_RealTimePVPComponent.<>f__mg$cache16 = new LuaCSFunction(Lua_BlackJack_ProjectL_PlayerContext_RealTimePVPComponent.__callBase_GetBattleReports);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_PlayerContext_RealTimePVPComponent.<>f__mg$cache16);
		if (Lua_BlackJack_ProjectL_PlayerContext_RealTimePVPComponent.<>f__mg$cache17 == null)
		{
			Lua_BlackJack_ProjectL_PlayerContext_RealTimePVPComponent.<>f__mg$cache17 = new LuaCSFunction(Lua_BlackJack_ProjectL_PlayerContext_RealTimePVPComponent.__callBase_StartPromotion);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_PlayerContext_RealTimePVPComponent.<>f__mg$cache17);
		if (Lua_BlackJack_ProjectL_PlayerContext_RealTimePVPComponent.<>f__mg$cache18 == null)
		{
			Lua_BlackJack_ProjectL_PlayerContext_RealTimePVPComponent.<>f__mg$cache18 = new LuaCSFunction(Lua_BlackJack_ProjectL_PlayerContext_RealTimePVPComponent.__callBase_EndPromotion);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_PlayerContext_RealTimePVPComponent.<>f__mg$cache18);
		if (Lua_BlackJack_ProjectL_PlayerContext_RealTimePVPComponent.<>f__mg$cache19 == null)
		{
			Lua_BlackJack_ProjectL_PlayerContext_RealTimePVPComponent.<>f__mg$cache19 = new LuaCSFunction(Lua_BlackJack_ProjectL_PlayerContext_RealTimePVPComponent.__callBase_SavePromotionReport);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_PlayerContext_RealTimePVPComponent.<>f__mg$cache19);
		if (Lua_BlackJack_ProjectL_PlayerContext_RealTimePVPComponent.<>f__mg$cache1A == null)
		{
			Lua_BlackJack_ProjectL_PlayerContext_RealTimePVPComponent.<>f__mg$cache1A = new LuaCSFunction(Lua_BlackJack_ProjectL_PlayerContext_RealTimePVPComponent.__callBase_SaveReport);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_PlayerContext_RealTimePVPComponent.<>f__mg$cache1A);
		if (Lua_BlackJack_ProjectL_PlayerContext_RealTimePVPComponent.<>f__mg$cache1B == null)
		{
			Lua_BlackJack_ProjectL_PlayerContext_RealTimePVPComponent.<>f__mg$cache1B = new LuaCSFunction(Lua_BlackJack_ProjectL_PlayerContext_RealTimePVPComponent.__callBase_CheckAcquireWinsBonus);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_PlayerContext_RealTimePVPComponent.<>f__mg$cache1B);
		if (Lua_BlackJack_ProjectL_PlayerContext_RealTimePVPComponent.<>f__mg$cache1C == null)
		{
			Lua_BlackJack_ProjectL_PlayerContext_RealTimePVPComponent.<>f__mg$cache1C = new LuaCSFunction(Lua_BlackJack_ProjectL_PlayerContext_RealTimePVPComponent.__callBase_AcquireWinsBonus);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_PlayerContext_RealTimePVPComponent.<>f__mg$cache1C);
		if (Lua_BlackJack_ProjectL_PlayerContext_RealTimePVPComponent.<>f__mg$cache1D == null)
		{
			Lua_BlackJack_ProjectL_PlayerContext_RealTimePVPComponent.<>f__mg$cache1D = new LuaCSFunction(Lua_BlackJack_ProjectL_PlayerContext_RealTimePVPComponent.__callBase_GetConsecutiveWins);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_PlayerContext_RealTimePVPComponent.<>f__mg$cache1D);
		if (Lua_BlackJack_ProjectL_PlayerContext_RealTimePVPComponent.<>f__mg$cache1E == null)
		{
			Lua_BlackJack_ProjectL_PlayerContext_RealTimePVPComponent.<>f__mg$cache1E = new LuaCSFunction(Lua_BlackJack_ProjectL_PlayerContext_RealTimePVPComponent.__callBase_GetConsecutiveLosses);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_PlayerContext_RealTimePVPComponent.<>f__mg$cache1E);
		if (Lua_BlackJack_ProjectL_PlayerContext_RealTimePVPComponent.<>f__mg$cache1F == null)
		{
			Lua_BlackJack_ProjectL_PlayerContext_RealTimePVPComponent.<>f__mg$cache1F = new LuaCSFunction(Lua_BlackJack_ProjectL_PlayerContext_RealTimePVPComponent.__callBase_GetLadderCareerMatchStats);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_PlayerContext_RealTimePVPComponent.<>f__mg$cache1F);
		if (Lua_BlackJack_ProjectL_PlayerContext_RealTimePVPComponent.<>f__mg$cache20 == null)
		{
			Lua_BlackJack_ProjectL_PlayerContext_RealTimePVPComponent.<>f__mg$cache20 = new LuaCSFunction(Lua_BlackJack_ProjectL_PlayerContext_RealTimePVPComponent.__callBase_TryGetBotParamsForNovice);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_PlayerContext_RealTimePVPComponent.<>f__mg$cache20);
		if (Lua_BlackJack_ProjectL_PlayerContext_RealTimePVPComponent.<>f__mg$cache21 == null)
		{
			Lua_BlackJack_ProjectL_PlayerContext_RealTimePVPComponent.<>f__mg$cache21 = new LuaCSFunction(Lua_BlackJack_ProjectL_PlayerContext_RealTimePVPComponent.__callBase_TryGetBotParamsForLoser);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_PlayerContext_RealTimePVPComponent.<>f__mg$cache21);
		string name = "Dan";
		if (Lua_BlackJack_ProjectL_PlayerContext_RealTimePVPComponent.<>f__mg$cache22 == null)
		{
			Lua_BlackJack_ProjectL_PlayerContext_RealTimePVPComponent.<>f__mg$cache22 = new LuaCSFunction(Lua_BlackJack_ProjectL_PlayerContext_RealTimePVPComponent.get_Dan);
		}
		LuaCSFunction get = Lua_BlackJack_ProjectL_PlayerContext_RealTimePVPComponent.<>f__mg$cache22;
		if (Lua_BlackJack_ProjectL_PlayerContext_RealTimePVPComponent.<>f__mg$cache23 == null)
		{
			Lua_BlackJack_ProjectL_PlayerContext_RealTimePVPComponent.<>f__mg$cache23 = new LuaCSFunction(Lua_BlackJack_ProjectL_PlayerContext_RealTimePVPComponent.set_Dan);
		}
		LuaObject.addMember(l, name, get, Lua_BlackJack_ProjectL_PlayerContext_RealTimePVPComponent.<>f__mg$cache23, true);
		string name2 = "Score";
		if (Lua_BlackJack_ProjectL_PlayerContext_RealTimePVPComponent.<>f__mg$cache24 == null)
		{
			Lua_BlackJack_ProjectL_PlayerContext_RealTimePVPComponent.<>f__mg$cache24 = new LuaCSFunction(Lua_BlackJack_ProjectL_PlayerContext_RealTimePVPComponent.get_Score);
		}
		LuaCSFunction get2 = Lua_BlackJack_ProjectL_PlayerContext_RealTimePVPComponent.<>f__mg$cache24;
		if (Lua_BlackJack_ProjectL_PlayerContext_RealTimePVPComponent.<>f__mg$cache25 == null)
		{
			Lua_BlackJack_ProjectL_PlayerContext_RealTimePVPComponent.<>f__mg$cache25 = new LuaCSFunction(Lua_BlackJack_ProjectL_PlayerContext_RealTimePVPComponent.set_Score);
		}
		LuaObject.addMember(l, name2, get2, Lua_BlackJack_ProjectL_PlayerContext_RealTimePVPComponent.<>f__mg$cache25, true);
		if (Lua_BlackJack_ProjectL_PlayerContext_RealTimePVPComponent.<>f__mg$cache26 == null)
		{
			Lua_BlackJack_ProjectL_PlayerContext_RealTimePVPComponent.<>f__mg$cache26 = new LuaCSFunction(Lua_BlackJack_ProjectL_PlayerContext_RealTimePVPComponent.constructor);
		}
		LuaObject.createTypeMetatable(l, Lua_BlackJack_ProjectL_PlayerContext_RealTimePVPComponent.<>f__mg$cache26, typeof(RealTimePVPComponent), typeof(RealTimePVPComponentCommon));
	}

	// Token: 0x040103B2 RID: 66482
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache0;

	// Token: 0x040103B3 RID: 66483
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1;

	// Token: 0x040103B4 RID: 66484
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2;

	// Token: 0x040103B5 RID: 66485
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3;

	// Token: 0x040103B6 RID: 66486
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache4;

	// Token: 0x040103B7 RID: 66487
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache5;

	// Token: 0x040103B8 RID: 66488
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache6;

	// Token: 0x040103B9 RID: 66489
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache7;

	// Token: 0x040103BA RID: 66490
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache8;

	// Token: 0x040103BB RID: 66491
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache9;

	// Token: 0x040103BC RID: 66492
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheA;

	// Token: 0x040103BD RID: 66493
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheB;

	// Token: 0x040103BE RID: 66494
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheC;

	// Token: 0x040103BF RID: 66495
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheD;

	// Token: 0x040103C0 RID: 66496
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheE;

	// Token: 0x040103C1 RID: 66497
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheF;

	// Token: 0x040103C2 RID: 66498
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache10;

	// Token: 0x040103C3 RID: 66499
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache11;

	// Token: 0x040103C4 RID: 66500
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache12;

	// Token: 0x040103C5 RID: 66501
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache13;

	// Token: 0x040103C6 RID: 66502
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache14;

	// Token: 0x040103C7 RID: 66503
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache15;

	// Token: 0x040103C8 RID: 66504
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache16;

	// Token: 0x040103C9 RID: 66505
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache17;

	// Token: 0x040103CA RID: 66506
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache18;

	// Token: 0x040103CB RID: 66507
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache19;

	// Token: 0x040103CC RID: 66508
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1A;

	// Token: 0x040103CD RID: 66509
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1B;

	// Token: 0x040103CE RID: 66510
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1C;

	// Token: 0x040103CF RID: 66511
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1D;

	// Token: 0x040103D0 RID: 66512
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1E;

	// Token: 0x040103D1 RID: 66513
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1F;

	// Token: 0x040103D2 RID: 66514
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache20;

	// Token: 0x040103D3 RID: 66515
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache21;

	// Token: 0x040103D4 RID: 66516
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache22;

	// Token: 0x040103D5 RID: 66517
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache23;

	// Token: 0x040103D6 RID: 66518
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache24;

	// Token: 0x040103D7 RID: 66519
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache25;

	// Token: 0x040103D8 RID: 66520
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache26;
}
