using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using BlackJack.ConfigData;
using BlackJack.ProjectL.Common;
using SLua;
using UnityEngine.Scripting;

// Token: 0x0200126F RID: 4719
[Preserve]
public class Lua_BlackJack_ProjectL_Common_RealTimePVPComponentCommon : LuaObject
{
	// Token: 0x06018960 RID: 100704 RVA: 0x006ECE14 File Offset: 0x006EB014
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int constructor(IntPtr l)
	{
		int result;
		try
		{
			RealTimePVPComponentCommon o = new RealTimePVPComponentCommon();
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

	// Token: 0x06018961 RID: 100705 RVA: 0x006ECE5C File Offset: 0x006EB05C
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int GetName(IntPtr l)
	{
		int result;
		try
		{
			RealTimePVPComponentCommon realTimePVPComponentCommon = (RealTimePVPComponentCommon)LuaObject.checkSelf(l);
			string name = realTimePVPComponentCommon.GetName();
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

	// Token: 0x06018962 RID: 100706 RVA: 0x006ECEB0 File Offset: 0x006EB0B0
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int Init(IntPtr l)
	{
		int result;
		try
		{
			RealTimePVPComponentCommon realTimePVPComponentCommon = (RealTimePVPComponentCommon)LuaObject.checkSelf(l);
			realTimePVPComponentCommon.Init();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06018963 RID: 100707 RVA: 0x006ECEFC File Offset: 0x006EB0FC
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int PostInit(IntPtr l)
	{
		int result;
		try
		{
			RealTimePVPComponentCommon realTimePVPComponentCommon = (RealTimePVPComponentCommon)LuaObject.checkSelf(l);
			realTimePVPComponentCommon.PostInit();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06018964 RID: 100708 RVA: 0x006ECF48 File Offset: 0x006EB148
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int DeInit(IntPtr l)
	{
		int result;
		try
		{
			RealTimePVPComponentCommon realTimePVPComponentCommon = (RealTimePVPComponentCommon)LuaObject.checkSelf(l);
			realTimePVPComponentCommon.DeInit();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06018965 RID: 100709 RVA: 0x006ECF94 File Offset: 0x006EB194
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int Tick(IntPtr l)
	{
		int result;
		try
		{
			RealTimePVPComponentCommon realTimePVPComponentCommon = (RealTimePVPComponentCommon)LuaObject.checkSelf(l);
			uint deltaMillisecond;
			LuaObject.checkType(l, 2, out deltaMillisecond);
			realTimePVPComponentCommon.Tick(deltaMillisecond);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06018966 RID: 100710 RVA: 0x006ECFEC File Offset: 0x006EB1EC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int PostDeSerialize(IntPtr l)
	{
		int result;
		try
		{
			RealTimePVPComponentCommon realTimePVPComponentCommon = (RealTimePVPComponentCommon)LuaObject.checkSelf(l);
			realTimePVPComponentCommon.PostDeSerialize();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06018967 RID: 100711 RVA: 0x006ED038 File Offset: 0x006EB238
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int RealTimeArenaDanUpdate(IntPtr l)
	{
		int result;
		try
		{
			RealTimePVPComponentCommon realTimePVPComponentCommon = (RealTimePVPComponentCommon)LuaObject.checkSelf(l);
			int dan;
			LuaObject.checkType(l, 2, out dan);
			realTimePVPComponentCommon.RealTimeArenaDanUpdate(dan);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06018968 RID: 100712 RVA: 0x006ED090 File Offset: 0x006EB290
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int RealTimeArenaBattleFinish(IntPtr l)
	{
		int result;
		try
		{
			RealTimePVPComponentCommon realTimePVPComponentCommon = (RealTimePVPComponentCommon)LuaObject.checkSelf(l);
			BattleMode mode;
			LuaObject.checkEnum<BattleMode>(l, 2, out mode);
			bool win;
			LuaObject.checkType(l, 3, out win);
			realTimePVPComponentCommon.RealTimeArenaBattleFinish(mode, win);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06018969 RID: 100713 RVA: 0x006ED0F4 File Offset: 0x006EB2F4
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int RealTimeArenaBattleStart(IntPtr l)
	{
		int result;
		try
		{
			RealTimePVPComponentCommon realTimePVPComponentCommon = (RealTimePVPComponentCommon)LuaObject.checkSelf(l);
			BattleMode mode;
			LuaObject.checkEnum<BattleMode>(l, 2, out mode);
			realTimePVPComponentCommon.RealTimeArenaBattleStart(mode);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601896A RID: 100714 RVA: 0x006ED14C File Offset: 0x006EB34C
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int IsRealTimePVPUnlocked(IntPtr l)
	{
		int result;
		try
		{
			RealTimePVPComponentCommon realTimePVPComponentCommon = (RealTimePVPComponentCommon)LuaObject.checkSelf(l);
			int i = realTimePVPComponentCommon.IsRealTimePVPUnlocked();
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

	// Token: 0x0601896B RID: 100715 RVA: 0x006ED1A0 File Offset: 0x006EB3A0
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int IsRealTimePVPArenaAvailable(IntPtr l)
	{
		int result;
		try
		{
			RealTimePVPComponentCommon realTimePVPComponentCommon = (RealTimePVPComponentCommon)LuaObject.checkSelf(l);
			BattleMode mode;
			LuaObject.checkEnum<BattleMode>(l, 2, out mode);
			int i = realTimePVPComponentCommon.IsRealTimePVPArenaAvailable(mode);
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

	// Token: 0x0601896C RID: 100716 RVA: 0x006ED204 File Offset: 0x006EB404
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int IsPromotion(IntPtr l)
	{
		int result;
		try
		{
			RealTimePVPComponentCommon realTimePVPComponentCommon = (RealTimePVPComponentCommon)LuaObject.checkSelf(l);
			bool b = realTimePVPComponentCommon.IsPromotion();
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

	// Token: 0x0601896D RID: 100717 RVA: 0x006ED258 File Offset: 0x006EB458
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int GetPromotionBattleReports(IntPtr l)
	{
		int result;
		try
		{
			RealTimePVPComponentCommon realTimePVPComponentCommon = (RealTimePVPComponentCommon)LuaObject.checkSelf(l);
			LinkedList<RealTimePVPBattleReport> promotionBattleReports = realTimePVPComponentCommon.GetPromotionBattleReports();
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, promotionBattleReports);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601896E RID: 100718 RVA: 0x006ED2AC File Offset: 0x006EB4AC
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int GetBattleReports(IntPtr l)
	{
		int result;
		try
		{
			RealTimePVPComponentCommon realTimePVPComponentCommon = (RealTimePVPComponentCommon)LuaObject.checkSelf(l);
			LinkedList<RealTimePVPBattleReport> battleReports = realTimePVPComponentCommon.GetBattleReports();
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, battleReports);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601896F RID: 100719 RVA: 0x006ED300 File Offset: 0x006EB500
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int StartPromotion(IntPtr l)
	{
		int result;
		try
		{
			RealTimePVPComponentCommon realTimePVPComponentCommon = (RealTimePVPComponentCommon)LuaObject.checkSelf(l);
			realTimePVPComponentCommon.StartPromotion();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06018970 RID: 100720 RVA: 0x006ED34C File Offset: 0x006EB54C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int EndPromotion(IntPtr l)
	{
		int result;
		try
		{
			RealTimePVPComponentCommon realTimePVPComponentCommon = (RealTimePVPComponentCommon)LuaObject.checkSelf(l);
			realTimePVPComponentCommon.EndPromotion();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06018971 RID: 100721 RVA: 0x006ED398 File Offset: 0x006EB598
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int SavePromotionReport(IntPtr l)
	{
		int result;
		try
		{
			RealTimePVPComponentCommon realTimePVPComponentCommon = (RealTimePVPComponentCommon)LuaObject.checkSelf(l);
			RealTimePVPBattleReport report;
			LuaObject.checkType<RealTimePVPBattleReport>(l, 2, out report);
			realTimePVPComponentCommon.SavePromotionReport(report);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06018972 RID: 100722 RVA: 0x006ED3F0 File Offset: 0x006EB5F0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int SaveReport(IntPtr l)
	{
		int result;
		try
		{
			RealTimePVPComponentCommon realTimePVPComponentCommon = (RealTimePVPComponentCommon)LuaObject.checkSelf(l);
			RealTimePVPBattleReport report;
			LuaObject.checkType<RealTimePVPBattleReport>(l, 2, out report);
			realTimePVPComponentCommon.SaveReport(report);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06018973 RID: 100723 RVA: 0x006ED448 File Offset: 0x006EB648
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int CheckAcquireWinsBonus(IntPtr l)
	{
		int result;
		try
		{
			RealTimePVPComponentCommon realTimePVPComponentCommon = (RealTimePVPComponentCommon)LuaObject.checkSelf(l);
			int bonusId;
			LuaObject.checkType(l, 2, out bonusId);
			int i = realTimePVPComponentCommon.CheckAcquireWinsBonus(bonusId);
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

	// Token: 0x06018974 RID: 100724 RVA: 0x006ED4AC File Offset: 0x006EB6AC
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int AcquireWinsBonus(IntPtr l)
	{
		int result;
		try
		{
			RealTimePVPComponentCommon realTimePVPComponentCommon = (RealTimePVPComponentCommon)LuaObject.checkSelf(l);
			int bonusId;
			LuaObject.checkType(l, 2, out bonusId);
			int i = realTimePVPComponentCommon.AcquireWinsBonus(bonusId);
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

	// Token: 0x06018975 RID: 100725 RVA: 0x006ED510 File Offset: 0x006EB710
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int GetConsecutiveWins(IntPtr l)
	{
		int result;
		try
		{
			RealTimePVPComponentCommon realTimePVPComponentCommon = (RealTimePVPComponentCommon)LuaObject.checkSelf(l);
			BattleMode mode;
			LuaObject.checkEnum<BattleMode>(l, 2, out mode);
			int consecutiveWins = realTimePVPComponentCommon.GetConsecutiveWins(mode);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, consecutiveWins);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06018976 RID: 100726 RVA: 0x006ED574 File Offset: 0x006EB774
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int GetConsecutiveLosses(IntPtr l)
	{
		int result;
		try
		{
			RealTimePVPComponentCommon realTimePVPComponentCommon = (RealTimePVPComponentCommon)LuaObject.checkSelf(l);
			BattleMode mode;
			LuaObject.checkEnum<BattleMode>(l, 2, out mode);
			int consecutiveLosses = realTimePVPComponentCommon.GetConsecutiveLosses(mode);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, consecutiveLosses);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06018977 RID: 100727 RVA: 0x006ED5D8 File Offset: 0x006EB7D8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int GetLadderCareerMatchStats(IntPtr l)
	{
		int result;
		try
		{
			RealTimePVPComponentCommon realTimePVPComponentCommon = (RealTimePVPComponentCommon)LuaObject.checkSelf(l);
			RealTimePVPMatchStats ladderCareerMatchStats = realTimePVPComponentCommon.GetLadderCareerMatchStats();
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, ladderCareerMatchStats);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06018978 RID: 100728 RVA: 0x006ED62C File Offset: 0x006EB82C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int TryGetBotParamsForNovice(IntPtr l)
	{
		int result;
		try
		{
			RealTimePVPComponentCommon realTimePVPComponentCommon = (RealTimePVPComponentCommon)LuaObject.checkSelf(l);
			BattleMode mode;
			LuaObject.checkEnum<BattleMode>(l, 2, out mode);
			int myScore;
			LuaObject.checkType(l, 3, out myScore);
			int i;
			int i2;
			int i3;
			int i4;
			bool b = realTimePVPComponentCommon.TryGetBotParamsForNovice(mode, myScore, out i, out i2, out i3, out i4);
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

	// Token: 0x06018979 RID: 100729 RVA: 0x006ED6C4 File Offset: 0x006EB8C4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int TryGetBotParamsForLoser(IntPtr l)
	{
		int result;
		try
		{
			RealTimePVPComponentCommon realTimePVPComponentCommon = (RealTimePVPComponentCommon)LuaObject.checkSelf(l);
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
			bool b = realTimePVPComponentCommon.TryGetBotParamsForLoser(mode, myScore, dan, out i, out i2, out i3, out i4);
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

	// Token: 0x0601897A RID: 100730 RVA: 0x006ED768 File Offset: 0x006EB968
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int OnFlushRealTimePVP(IntPtr l)
	{
		int result;
		try
		{
			RealTimePVPComponentCommon realTimePVPComponentCommon = (RealTimePVPComponentCommon)LuaObject.checkSelf(l);
			realTimePVPComponentCommon.m_luaExportHelper.OnFlushRealTimePVP();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601897B RID: 100731 RVA: 0x006ED7BC File Offset: 0x006EB9BC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int StartNewSeason(IntPtr l)
	{
		int result;
		try
		{
			RealTimePVPComponentCommon realTimePVPComponentCommon = (RealTimePVPComponentCommon)LuaObject.checkSelf(l);
			realTimePVPComponentCommon.m_luaExportHelper.StartNewSeason();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601897C RID: 100732 RVA: 0x006ED810 File Offset: 0x006EBA10
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int __callDele_RealTimeArenaBattleStartMissionEvent(IntPtr l)
	{
		int result;
		try
		{
			RealTimePVPComponentCommon realTimePVPComponentCommon = (RealTimePVPComponentCommon)LuaObject.checkSelf(l);
			BattleMode obj;
			LuaObject.checkEnum<BattleMode>(l, 2, out obj);
			realTimePVPComponentCommon.m_luaExportHelper.__callDele_RealTimeArenaBattleStartMissionEvent(obj);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601897D RID: 100733 RVA: 0x006ED86C File Offset: 0x006EBA6C
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int __clearDele_RealTimeArenaBattleStartMissionEvent(IntPtr l)
	{
		int result;
		try
		{
			RealTimePVPComponentCommon realTimePVPComponentCommon = (RealTimePVPComponentCommon)LuaObject.checkSelf(l);
			BattleMode obj;
			LuaObject.checkEnum<BattleMode>(l, 2, out obj);
			realTimePVPComponentCommon.m_luaExportHelper.__clearDele_RealTimeArenaBattleStartMissionEvent(obj);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601897E RID: 100734 RVA: 0x006ED8C8 File Offset: 0x006EBAC8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callDele_RealTimeArenaBattleFinishMissionEvent(IntPtr l)
	{
		int result;
		try
		{
			RealTimePVPComponentCommon realTimePVPComponentCommon = (RealTimePVPComponentCommon)LuaObject.checkSelf(l);
			BattleMode arg;
			LuaObject.checkEnum<BattleMode>(l, 2, out arg);
			bool arg2;
			LuaObject.checkType(l, 3, out arg2);
			realTimePVPComponentCommon.m_luaExportHelper.__callDele_RealTimeArenaBattleFinishMissionEvent(arg, arg2);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601897F RID: 100735 RVA: 0x006ED934 File Offset: 0x006EBB34
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __clearDele_RealTimeArenaBattleFinishMissionEvent(IntPtr l)
	{
		int result;
		try
		{
			RealTimePVPComponentCommon realTimePVPComponentCommon = (RealTimePVPComponentCommon)LuaObject.checkSelf(l);
			BattleMode arg;
			LuaObject.checkEnum<BattleMode>(l, 2, out arg);
			bool arg2;
			LuaObject.checkType(l, 3, out arg2);
			realTimePVPComponentCommon.m_luaExportHelper.__clearDele_RealTimeArenaBattleFinishMissionEvent(arg, arg2);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06018980 RID: 100736 RVA: 0x006ED9A0 File Offset: 0x006EBBA0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callDele_RealTimeArenaDanUpdateMissionEvent(IntPtr l)
	{
		int result;
		try
		{
			RealTimePVPComponentCommon realTimePVPComponentCommon = (RealTimePVPComponentCommon)LuaObject.checkSelf(l);
			int obj;
			LuaObject.checkType(l, 2, out obj);
			realTimePVPComponentCommon.m_luaExportHelper.__callDele_RealTimeArenaDanUpdateMissionEvent(obj);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06018981 RID: 100737 RVA: 0x006ED9FC File Offset: 0x006EBBFC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __clearDele_RealTimeArenaDanUpdateMissionEvent(IntPtr l)
	{
		int result;
		try
		{
			RealTimePVPComponentCommon realTimePVPComponentCommon = (RealTimePVPComponentCommon)LuaObject.checkSelf(l);
			int obj;
			LuaObject.checkType(l, 2, out obj);
			realTimePVPComponentCommon.m_luaExportHelper.__clearDele_RealTimeArenaDanUpdateMissionEvent(obj);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06018982 RID: 100738 RVA: 0x006EDA58 File Offset: 0x006EBC58
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get__configDataLoader(IntPtr l)
	{
		int result;
		try
		{
			RealTimePVPComponentCommon realTimePVPComponentCommon = (RealTimePVPComponentCommon)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, realTimePVPComponentCommon.m_luaExportHelper._configDataLoader);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06018983 RID: 100739 RVA: 0x006EDAB0 File Offset: 0x006EBCB0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set__configDataLoader(IntPtr l)
	{
		int result;
		try
		{
			RealTimePVPComponentCommon realTimePVPComponentCommon = (RealTimePVPComponentCommon)LuaObject.checkSelf(l);
			IConfigDataLoader configDataLoader;
			LuaObject.checkType<IConfigDataLoader>(l, 2, out configDataLoader);
			realTimePVPComponentCommon.m_luaExportHelper._configDataLoader = configDataLoader;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06018984 RID: 100740 RVA: 0x006EDB0C File Offset: 0x006EBD0C
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_m_basicInfo(IntPtr l)
	{
		int result;
		try
		{
			RealTimePVPComponentCommon realTimePVPComponentCommon = (RealTimePVPComponentCommon)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, realTimePVPComponentCommon.m_luaExportHelper.m_basicInfo);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06018985 RID: 100741 RVA: 0x006EDB64 File Offset: 0x006EBD64
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_basicInfo(IntPtr l)
	{
		int result;
		try
		{
			RealTimePVPComponentCommon realTimePVPComponentCommon = (RealTimePVPComponentCommon)LuaObject.checkSelf(l);
			PlayerBasicInfoComponentCommon basicInfo;
			LuaObject.checkType<PlayerBasicInfoComponentCommon>(l, 2, out basicInfo);
			realTimePVPComponentCommon.m_luaExportHelper.m_basicInfo = basicInfo;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06018986 RID: 100742 RVA: 0x006EDBC0 File Offset: 0x006EBDC0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_bag(IntPtr l)
	{
		int result;
		try
		{
			RealTimePVPComponentCommon realTimePVPComponentCommon = (RealTimePVPComponentCommon)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, realTimePVPComponentCommon.m_luaExportHelper.m_bag);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06018987 RID: 100743 RVA: 0x006EDC18 File Offset: 0x006EBE18
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_m_bag(IntPtr l)
	{
		int result;
		try
		{
			RealTimePVPComponentCommon realTimePVPComponentCommon = (RealTimePVPComponentCommon)LuaObject.checkSelf(l);
			BagComponentCommon bag;
			LuaObject.checkType<BagComponentCommon>(l, 2, out bag);
			realTimePVPComponentCommon.m_luaExportHelper.m_bag = bag;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06018988 RID: 100744 RVA: 0x006EDC74 File Offset: 0x006EBE74
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_m_battle(IntPtr l)
	{
		int result;
		try
		{
			RealTimePVPComponentCommon realTimePVPComponentCommon = (RealTimePVPComponentCommon)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, realTimePVPComponentCommon.m_luaExportHelper.m_battle);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06018989 RID: 100745 RVA: 0x006EDCCC File Offset: 0x006EBECC
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_m_battle(IntPtr l)
	{
		int result;
		try
		{
			RealTimePVPComponentCommon realTimePVPComponentCommon = (RealTimePVPComponentCommon)LuaObject.checkSelf(l);
			BattleComponentCommon battle;
			LuaObject.checkType<BattleComponentCommon>(l, 2, out battle);
			realTimePVPComponentCommon.m_luaExportHelper.m_battle = battle;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601898A RID: 100746 RVA: 0x006EDD28 File Offset: 0x006EBF28
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_realTimePVP(IntPtr l)
	{
		int result;
		try
		{
			RealTimePVPComponentCommon realTimePVPComponentCommon = (RealTimePVPComponentCommon)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, realTimePVPComponentCommon.m_realTimePVP);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601898B RID: 100747 RVA: 0x006EDD7C File Offset: 0x006EBF7C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_realTimePVP(IntPtr l)
	{
		int result;
		try
		{
			RealTimePVPComponentCommon realTimePVPComponentCommon = (RealTimePVPComponentCommon)LuaObject.checkSelf(l);
			DataSectionRealTimePVP realTimePVP;
			LuaObject.checkType<DataSectionRealTimePVP>(l, 2, out realTimePVP);
			realTimePVPComponentCommon.m_realTimePVP = realTimePVP;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601898C RID: 100748 RVA: 0x006EDDD4 File Offset: 0x006EBFD4
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_RealTimeArenaBattleStartMissionEvent(IntPtr l)
	{
		int result;
		try
		{
			RealTimePVPComponentCommon realTimePVPComponentCommon = (RealTimePVPComponentCommon)LuaObject.checkSelf(l);
			Action<BattleMode> value;
			int num = LuaObject.checkDelegate<Action<BattleMode>>(l, 2, out value);
			if (num != 0)
			{
				if (num == 1)
				{
					realTimePVPComponentCommon.RealTimeArenaBattleStartMissionEvent += value;
				}
				else if (num == 2)
				{
					realTimePVPComponentCommon.RealTimeArenaBattleStartMissionEvent -= value;
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

	// Token: 0x0601898D RID: 100749 RVA: 0x006EDE54 File Offset: 0x006EC054
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_RealTimeArenaBattleFinishMissionEvent(IntPtr l)
	{
		int result;
		try
		{
			RealTimePVPComponentCommon realTimePVPComponentCommon = (RealTimePVPComponentCommon)LuaObject.checkSelf(l);
			Action<BattleMode, bool> value;
			int num = LuaObject.checkDelegate<Action<BattleMode, bool>>(l, 2, out value);
			if (num != 0)
			{
				if (num == 1)
				{
					realTimePVPComponentCommon.RealTimeArenaBattleFinishMissionEvent += value;
				}
				else if (num == 2)
				{
					realTimePVPComponentCommon.RealTimeArenaBattleFinishMissionEvent -= value;
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

	// Token: 0x0601898E RID: 100750 RVA: 0x006EDED4 File Offset: 0x006EC0D4
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_RealTimeArenaDanUpdateMissionEvent(IntPtr l)
	{
		int result;
		try
		{
			RealTimePVPComponentCommon realTimePVPComponentCommon = (RealTimePVPComponentCommon)LuaObject.checkSelf(l);
			Action<int> value;
			int num = LuaObject.checkDelegate<Action<int>>(l, 2, out value);
			if (num != 0)
			{
				if (num == 1)
				{
					realTimePVPComponentCommon.RealTimeArenaDanUpdateMissionEvent += value;
				}
				else if (num == 2)
				{
					realTimePVPComponentCommon.RealTimeArenaDanUpdateMissionEvent -= value;
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

	// Token: 0x0601898F RID: 100751 RVA: 0x006EDF54 File Offset: 0x006EC154
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_Owner(IntPtr l)
	{
		int result;
		try
		{
			RealTimePVPComponentCommon realTimePVPComponentCommon = (RealTimePVPComponentCommon)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, realTimePVPComponentCommon.Owner);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06018990 RID: 100752 RVA: 0x006EDFA8 File Offset: 0x006EC1A8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_Owner(IntPtr l)
	{
		int result;
		try
		{
			RealTimePVPComponentCommon realTimePVPComponentCommon = (RealTimePVPComponentCommon)LuaObject.checkSelf(l);
			IComponentOwner owner;
			LuaObject.checkType<IComponentOwner>(l, 2, out owner);
			realTimePVPComponentCommon.Owner = owner;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06018991 RID: 100753 RVA: 0x006EE000 File Offset: 0x006EC200
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_configDataLoader(IntPtr l)
	{
		int result;
		try
		{
			RealTimePVPComponentCommon realTimePVPComponentCommon = (RealTimePVPComponentCommon)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, realTimePVPComponentCommon.m_luaExportHelper.m_configDataLoader);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06018992 RID: 100754 RVA: 0x006EE058 File Offset: 0x006EC258
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_configDataLoader(IntPtr l)
	{
		int result;
		try
		{
			RealTimePVPComponentCommon realTimePVPComponentCommon = (RealTimePVPComponentCommon)LuaObject.checkSelf(l);
			IConfigDataLoader configDataLoader;
			LuaObject.checkType<IConfigDataLoader>(l, 2, out configDataLoader);
			realTimePVPComponentCommon.m_luaExportHelper.m_configDataLoader = configDataLoader;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06018993 RID: 100755 RVA: 0x006EE0B4 File Offset: 0x006EC2B4
	[Preserve]
	public static void reg(IntPtr l)
	{
		LuaObject.getTypeTable(l, "BlackJack.ProjectL.Common.RealTimePVPComponentCommon");
		if (Lua_BlackJack_ProjectL_Common_RealTimePVPComponentCommon.<>f__mg$cache0 == null)
		{
			Lua_BlackJack_ProjectL_Common_RealTimePVPComponentCommon.<>f__mg$cache0 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_RealTimePVPComponentCommon.GetName);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_RealTimePVPComponentCommon.<>f__mg$cache0);
		if (Lua_BlackJack_ProjectL_Common_RealTimePVPComponentCommon.<>f__mg$cache1 == null)
		{
			Lua_BlackJack_ProjectL_Common_RealTimePVPComponentCommon.<>f__mg$cache1 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_RealTimePVPComponentCommon.Init);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_RealTimePVPComponentCommon.<>f__mg$cache1);
		if (Lua_BlackJack_ProjectL_Common_RealTimePVPComponentCommon.<>f__mg$cache2 == null)
		{
			Lua_BlackJack_ProjectL_Common_RealTimePVPComponentCommon.<>f__mg$cache2 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_RealTimePVPComponentCommon.PostInit);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_RealTimePVPComponentCommon.<>f__mg$cache2);
		if (Lua_BlackJack_ProjectL_Common_RealTimePVPComponentCommon.<>f__mg$cache3 == null)
		{
			Lua_BlackJack_ProjectL_Common_RealTimePVPComponentCommon.<>f__mg$cache3 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_RealTimePVPComponentCommon.DeInit);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_RealTimePVPComponentCommon.<>f__mg$cache3);
		if (Lua_BlackJack_ProjectL_Common_RealTimePVPComponentCommon.<>f__mg$cache4 == null)
		{
			Lua_BlackJack_ProjectL_Common_RealTimePVPComponentCommon.<>f__mg$cache4 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_RealTimePVPComponentCommon.Tick);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_RealTimePVPComponentCommon.<>f__mg$cache4);
		if (Lua_BlackJack_ProjectL_Common_RealTimePVPComponentCommon.<>f__mg$cache5 == null)
		{
			Lua_BlackJack_ProjectL_Common_RealTimePVPComponentCommon.<>f__mg$cache5 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_RealTimePVPComponentCommon.PostDeSerialize);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_RealTimePVPComponentCommon.<>f__mg$cache5);
		if (Lua_BlackJack_ProjectL_Common_RealTimePVPComponentCommon.<>f__mg$cache6 == null)
		{
			Lua_BlackJack_ProjectL_Common_RealTimePVPComponentCommon.<>f__mg$cache6 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_RealTimePVPComponentCommon.RealTimeArenaDanUpdate);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_RealTimePVPComponentCommon.<>f__mg$cache6);
		if (Lua_BlackJack_ProjectL_Common_RealTimePVPComponentCommon.<>f__mg$cache7 == null)
		{
			Lua_BlackJack_ProjectL_Common_RealTimePVPComponentCommon.<>f__mg$cache7 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_RealTimePVPComponentCommon.RealTimeArenaBattleFinish);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_RealTimePVPComponentCommon.<>f__mg$cache7);
		if (Lua_BlackJack_ProjectL_Common_RealTimePVPComponentCommon.<>f__mg$cache8 == null)
		{
			Lua_BlackJack_ProjectL_Common_RealTimePVPComponentCommon.<>f__mg$cache8 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_RealTimePVPComponentCommon.RealTimeArenaBattleStart);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_RealTimePVPComponentCommon.<>f__mg$cache8);
		if (Lua_BlackJack_ProjectL_Common_RealTimePVPComponentCommon.<>f__mg$cache9 == null)
		{
			Lua_BlackJack_ProjectL_Common_RealTimePVPComponentCommon.<>f__mg$cache9 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_RealTimePVPComponentCommon.IsRealTimePVPUnlocked);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_RealTimePVPComponentCommon.<>f__mg$cache9);
		if (Lua_BlackJack_ProjectL_Common_RealTimePVPComponentCommon.<>f__mg$cacheA == null)
		{
			Lua_BlackJack_ProjectL_Common_RealTimePVPComponentCommon.<>f__mg$cacheA = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_RealTimePVPComponentCommon.IsRealTimePVPArenaAvailable);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_RealTimePVPComponentCommon.<>f__mg$cacheA);
		if (Lua_BlackJack_ProjectL_Common_RealTimePVPComponentCommon.<>f__mg$cacheB == null)
		{
			Lua_BlackJack_ProjectL_Common_RealTimePVPComponentCommon.<>f__mg$cacheB = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_RealTimePVPComponentCommon.IsPromotion);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_RealTimePVPComponentCommon.<>f__mg$cacheB);
		if (Lua_BlackJack_ProjectL_Common_RealTimePVPComponentCommon.<>f__mg$cacheC == null)
		{
			Lua_BlackJack_ProjectL_Common_RealTimePVPComponentCommon.<>f__mg$cacheC = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_RealTimePVPComponentCommon.GetPromotionBattleReports);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_RealTimePVPComponentCommon.<>f__mg$cacheC);
		if (Lua_BlackJack_ProjectL_Common_RealTimePVPComponentCommon.<>f__mg$cacheD == null)
		{
			Lua_BlackJack_ProjectL_Common_RealTimePVPComponentCommon.<>f__mg$cacheD = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_RealTimePVPComponentCommon.GetBattleReports);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_RealTimePVPComponentCommon.<>f__mg$cacheD);
		if (Lua_BlackJack_ProjectL_Common_RealTimePVPComponentCommon.<>f__mg$cacheE == null)
		{
			Lua_BlackJack_ProjectL_Common_RealTimePVPComponentCommon.<>f__mg$cacheE = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_RealTimePVPComponentCommon.StartPromotion);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_RealTimePVPComponentCommon.<>f__mg$cacheE);
		if (Lua_BlackJack_ProjectL_Common_RealTimePVPComponentCommon.<>f__mg$cacheF == null)
		{
			Lua_BlackJack_ProjectL_Common_RealTimePVPComponentCommon.<>f__mg$cacheF = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_RealTimePVPComponentCommon.EndPromotion);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_RealTimePVPComponentCommon.<>f__mg$cacheF);
		if (Lua_BlackJack_ProjectL_Common_RealTimePVPComponentCommon.<>f__mg$cache10 == null)
		{
			Lua_BlackJack_ProjectL_Common_RealTimePVPComponentCommon.<>f__mg$cache10 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_RealTimePVPComponentCommon.SavePromotionReport);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_RealTimePVPComponentCommon.<>f__mg$cache10);
		if (Lua_BlackJack_ProjectL_Common_RealTimePVPComponentCommon.<>f__mg$cache11 == null)
		{
			Lua_BlackJack_ProjectL_Common_RealTimePVPComponentCommon.<>f__mg$cache11 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_RealTimePVPComponentCommon.SaveReport);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_RealTimePVPComponentCommon.<>f__mg$cache11);
		if (Lua_BlackJack_ProjectL_Common_RealTimePVPComponentCommon.<>f__mg$cache12 == null)
		{
			Lua_BlackJack_ProjectL_Common_RealTimePVPComponentCommon.<>f__mg$cache12 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_RealTimePVPComponentCommon.CheckAcquireWinsBonus);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_RealTimePVPComponentCommon.<>f__mg$cache12);
		if (Lua_BlackJack_ProjectL_Common_RealTimePVPComponentCommon.<>f__mg$cache13 == null)
		{
			Lua_BlackJack_ProjectL_Common_RealTimePVPComponentCommon.<>f__mg$cache13 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_RealTimePVPComponentCommon.AcquireWinsBonus);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_RealTimePVPComponentCommon.<>f__mg$cache13);
		if (Lua_BlackJack_ProjectL_Common_RealTimePVPComponentCommon.<>f__mg$cache14 == null)
		{
			Lua_BlackJack_ProjectL_Common_RealTimePVPComponentCommon.<>f__mg$cache14 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_RealTimePVPComponentCommon.GetConsecutiveWins);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_RealTimePVPComponentCommon.<>f__mg$cache14);
		if (Lua_BlackJack_ProjectL_Common_RealTimePVPComponentCommon.<>f__mg$cache15 == null)
		{
			Lua_BlackJack_ProjectL_Common_RealTimePVPComponentCommon.<>f__mg$cache15 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_RealTimePVPComponentCommon.GetConsecutiveLosses);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_RealTimePVPComponentCommon.<>f__mg$cache15);
		if (Lua_BlackJack_ProjectL_Common_RealTimePVPComponentCommon.<>f__mg$cache16 == null)
		{
			Lua_BlackJack_ProjectL_Common_RealTimePVPComponentCommon.<>f__mg$cache16 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_RealTimePVPComponentCommon.GetLadderCareerMatchStats);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_RealTimePVPComponentCommon.<>f__mg$cache16);
		if (Lua_BlackJack_ProjectL_Common_RealTimePVPComponentCommon.<>f__mg$cache17 == null)
		{
			Lua_BlackJack_ProjectL_Common_RealTimePVPComponentCommon.<>f__mg$cache17 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_RealTimePVPComponentCommon.TryGetBotParamsForNovice);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_RealTimePVPComponentCommon.<>f__mg$cache17);
		if (Lua_BlackJack_ProjectL_Common_RealTimePVPComponentCommon.<>f__mg$cache18 == null)
		{
			Lua_BlackJack_ProjectL_Common_RealTimePVPComponentCommon.<>f__mg$cache18 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_RealTimePVPComponentCommon.TryGetBotParamsForLoser);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_RealTimePVPComponentCommon.<>f__mg$cache18);
		if (Lua_BlackJack_ProjectL_Common_RealTimePVPComponentCommon.<>f__mg$cache19 == null)
		{
			Lua_BlackJack_ProjectL_Common_RealTimePVPComponentCommon.<>f__mg$cache19 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_RealTimePVPComponentCommon.OnFlushRealTimePVP);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_RealTimePVPComponentCommon.<>f__mg$cache19);
		if (Lua_BlackJack_ProjectL_Common_RealTimePVPComponentCommon.<>f__mg$cache1A == null)
		{
			Lua_BlackJack_ProjectL_Common_RealTimePVPComponentCommon.<>f__mg$cache1A = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_RealTimePVPComponentCommon.StartNewSeason);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_RealTimePVPComponentCommon.<>f__mg$cache1A);
		if (Lua_BlackJack_ProjectL_Common_RealTimePVPComponentCommon.<>f__mg$cache1B == null)
		{
			Lua_BlackJack_ProjectL_Common_RealTimePVPComponentCommon.<>f__mg$cache1B = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_RealTimePVPComponentCommon.__callDele_RealTimeArenaBattleStartMissionEvent);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_RealTimePVPComponentCommon.<>f__mg$cache1B);
		if (Lua_BlackJack_ProjectL_Common_RealTimePVPComponentCommon.<>f__mg$cache1C == null)
		{
			Lua_BlackJack_ProjectL_Common_RealTimePVPComponentCommon.<>f__mg$cache1C = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_RealTimePVPComponentCommon.__clearDele_RealTimeArenaBattleStartMissionEvent);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_RealTimePVPComponentCommon.<>f__mg$cache1C);
		if (Lua_BlackJack_ProjectL_Common_RealTimePVPComponentCommon.<>f__mg$cache1D == null)
		{
			Lua_BlackJack_ProjectL_Common_RealTimePVPComponentCommon.<>f__mg$cache1D = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_RealTimePVPComponentCommon.__callDele_RealTimeArenaBattleFinishMissionEvent);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_RealTimePVPComponentCommon.<>f__mg$cache1D);
		if (Lua_BlackJack_ProjectL_Common_RealTimePVPComponentCommon.<>f__mg$cache1E == null)
		{
			Lua_BlackJack_ProjectL_Common_RealTimePVPComponentCommon.<>f__mg$cache1E = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_RealTimePVPComponentCommon.__clearDele_RealTimeArenaBattleFinishMissionEvent);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_RealTimePVPComponentCommon.<>f__mg$cache1E);
		if (Lua_BlackJack_ProjectL_Common_RealTimePVPComponentCommon.<>f__mg$cache1F == null)
		{
			Lua_BlackJack_ProjectL_Common_RealTimePVPComponentCommon.<>f__mg$cache1F = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_RealTimePVPComponentCommon.__callDele_RealTimeArenaDanUpdateMissionEvent);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_RealTimePVPComponentCommon.<>f__mg$cache1F);
		if (Lua_BlackJack_ProjectL_Common_RealTimePVPComponentCommon.<>f__mg$cache20 == null)
		{
			Lua_BlackJack_ProjectL_Common_RealTimePVPComponentCommon.<>f__mg$cache20 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_RealTimePVPComponentCommon.__clearDele_RealTimeArenaDanUpdateMissionEvent);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_RealTimePVPComponentCommon.<>f__mg$cache20);
		string name = "_configDataLoader";
		if (Lua_BlackJack_ProjectL_Common_RealTimePVPComponentCommon.<>f__mg$cache21 == null)
		{
			Lua_BlackJack_ProjectL_Common_RealTimePVPComponentCommon.<>f__mg$cache21 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_RealTimePVPComponentCommon.get__configDataLoader);
		}
		LuaCSFunction get = Lua_BlackJack_ProjectL_Common_RealTimePVPComponentCommon.<>f__mg$cache21;
		if (Lua_BlackJack_ProjectL_Common_RealTimePVPComponentCommon.<>f__mg$cache22 == null)
		{
			Lua_BlackJack_ProjectL_Common_RealTimePVPComponentCommon.<>f__mg$cache22 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_RealTimePVPComponentCommon.set__configDataLoader);
		}
		LuaObject.addMember(l, name, get, Lua_BlackJack_ProjectL_Common_RealTimePVPComponentCommon.<>f__mg$cache22, true);
		string name2 = "m_basicInfo";
		if (Lua_BlackJack_ProjectL_Common_RealTimePVPComponentCommon.<>f__mg$cache23 == null)
		{
			Lua_BlackJack_ProjectL_Common_RealTimePVPComponentCommon.<>f__mg$cache23 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_RealTimePVPComponentCommon.get_m_basicInfo);
		}
		LuaCSFunction get2 = Lua_BlackJack_ProjectL_Common_RealTimePVPComponentCommon.<>f__mg$cache23;
		if (Lua_BlackJack_ProjectL_Common_RealTimePVPComponentCommon.<>f__mg$cache24 == null)
		{
			Lua_BlackJack_ProjectL_Common_RealTimePVPComponentCommon.<>f__mg$cache24 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_RealTimePVPComponentCommon.set_m_basicInfo);
		}
		LuaObject.addMember(l, name2, get2, Lua_BlackJack_ProjectL_Common_RealTimePVPComponentCommon.<>f__mg$cache24, true);
		string name3 = "m_bag";
		if (Lua_BlackJack_ProjectL_Common_RealTimePVPComponentCommon.<>f__mg$cache25 == null)
		{
			Lua_BlackJack_ProjectL_Common_RealTimePVPComponentCommon.<>f__mg$cache25 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_RealTimePVPComponentCommon.get_m_bag);
		}
		LuaCSFunction get3 = Lua_BlackJack_ProjectL_Common_RealTimePVPComponentCommon.<>f__mg$cache25;
		if (Lua_BlackJack_ProjectL_Common_RealTimePVPComponentCommon.<>f__mg$cache26 == null)
		{
			Lua_BlackJack_ProjectL_Common_RealTimePVPComponentCommon.<>f__mg$cache26 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_RealTimePVPComponentCommon.set_m_bag);
		}
		LuaObject.addMember(l, name3, get3, Lua_BlackJack_ProjectL_Common_RealTimePVPComponentCommon.<>f__mg$cache26, true);
		string name4 = "m_battle";
		if (Lua_BlackJack_ProjectL_Common_RealTimePVPComponentCommon.<>f__mg$cache27 == null)
		{
			Lua_BlackJack_ProjectL_Common_RealTimePVPComponentCommon.<>f__mg$cache27 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_RealTimePVPComponentCommon.get_m_battle);
		}
		LuaCSFunction get4 = Lua_BlackJack_ProjectL_Common_RealTimePVPComponentCommon.<>f__mg$cache27;
		if (Lua_BlackJack_ProjectL_Common_RealTimePVPComponentCommon.<>f__mg$cache28 == null)
		{
			Lua_BlackJack_ProjectL_Common_RealTimePVPComponentCommon.<>f__mg$cache28 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_RealTimePVPComponentCommon.set_m_battle);
		}
		LuaObject.addMember(l, name4, get4, Lua_BlackJack_ProjectL_Common_RealTimePVPComponentCommon.<>f__mg$cache28, true);
		string name5 = "m_realTimePVP";
		if (Lua_BlackJack_ProjectL_Common_RealTimePVPComponentCommon.<>f__mg$cache29 == null)
		{
			Lua_BlackJack_ProjectL_Common_RealTimePVPComponentCommon.<>f__mg$cache29 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_RealTimePVPComponentCommon.get_m_realTimePVP);
		}
		LuaCSFunction get5 = Lua_BlackJack_ProjectL_Common_RealTimePVPComponentCommon.<>f__mg$cache29;
		if (Lua_BlackJack_ProjectL_Common_RealTimePVPComponentCommon.<>f__mg$cache2A == null)
		{
			Lua_BlackJack_ProjectL_Common_RealTimePVPComponentCommon.<>f__mg$cache2A = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_RealTimePVPComponentCommon.set_m_realTimePVP);
		}
		LuaObject.addMember(l, name5, get5, Lua_BlackJack_ProjectL_Common_RealTimePVPComponentCommon.<>f__mg$cache2A, true);
		string name6 = "RealTimeArenaBattleStartMissionEvent";
		LuaCSFunction get6 = null;
		if (Lua_BlackJack_ProjectL_Common_RealTimePVPComponentCommon.<>f__mg$cache2B == null)
		{
			Lua_BlackJack_ProjectL_Common_RealTimePVPComponentCommon.<>f__mg$cache2B = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_RealTimePVPComponentCommon.set_RealTimeArenaBattleStartMissionEvent);
		}
		LuaObject.addMember(l, name6, get6, Lua_BlackJack_ProjectL_Common_RealTimePVPComponentCommon.<>f__mg$cache2B, true);
		string name7 = "RealTimeArenaBattleFinishMissionEvent";
		LuaCSFunction get7 = null;
		if (Lua_BlackJack_ProjectL_Common_RealTimePVPComponentCommon.<>f__mg$cache2C == null)
		{
			Lua_BlackJack_ProjectL_Common_RealTimePVPComponentCommon.<>f__mg$cache2C = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_RealTimePVPComponentCommon.set_RealTimeArenaBattleFinishMissionEvent);
		}
		LuaObject.addMember(l, name7, get7, Lua_BlackJack_ProjectL_Common_RealTimePVPComponentCommon.<>f__mg$cache2C, true);
		string name8 = "RealTimeArenaDanUpdateMissionEvent";
		LuaCSFunction get8 = null;
		if (Lua_BlackJack_ProjectL_Common_RealTimePVPComponentCommon.<>f__mg$cache2D == null)
		{
			Lua_BlackJack_ProjectL_Common_RealTimePVPComponentCommon.<>f__mg$cache2D = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_RealTimePVPComponentCommon.set_RealTimeArenaDanUpdateMissionEvent);
		}
		LuaObject.addMember(l, name8, get8, Lua_BlackJack_ProjectL_Common_RealTimePVPComponentCommon.<>f__mg$cache2D, true);
		string name9 = "Owner";
		if (Lua_BlackJack_ProjectL_Common_RealTimePVPComponentCommon.<>f__mg$cache2E == null)
		{
			Lua_BlackJack_ProjectL_Common_RealTimePVPComponentCommon.<>f__mg$cache2E = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_RealTimePVPComponentCommon.get_Owner);
		}
		LuaCSFunction get9 = Lua_BlackJack_ProjectL_Common_RealTimePVPComponentCommon.<>f__mg$cache2E;
		if (Lua_BlackJack_ProjectL_Common_RealTimePVPComponentCommon.<>f__mg$cache2F == null)
		{
			Lua_BlackJack_ProjectL_Common_RealTimePVPComponentCommon.<>f__mg$cache2F = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_RealTimePVPComponentCommon.set_Owner);
		}
		LuaObject.addMember(l, name9, get9, Lua_BlackJack_ProjectL_Common_RealTimePVPComponentCommon.<>f__mg$cache2F, true);
		string name10 = "m_configDataLoader";
		if (Lua_BlackJack_ProjectL_Common_RealTimePVPComponentCommon.<>f__mg$cache30 == null)
		{
			Lua_BlackJack_ProjectL_Common_RealTimePVPComponentCommon.<>f__mg$cache30 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_RealTimePVPComponentCommon.get_m_configDataLoader);
		}
		LuaCSFunction get10 = Lua_BlackJack_ProjectL_Common_RealTimePVPComponentCommon.<>f__mg$cache30;
		if (Lua_BlackJack_ProjectL_Common_RealTimePVPComponentCommon.<>f__mg$cache31 == null)
		{
			Lua_BlackJack_ProjectL_Common_RealTimePVPComponentCommon.<>f__mg$cache31 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_RealTimePVPComponentCommon.set_m_configDataLoader);
		}
		LuaObject.addMember(l, name10, get10, Lua_BlackJack_ProjectL_Common_RealTimePVPComponentCommon.<>f__mg$cache31, true);
		if (Lua_BlackJack_ProjectL_Common_RealTimePVPComponentCommon.<>f__mg$cache32 == null)
		{
			Lua_BlackJack_ProjectL_Common_RealTimePVPComponentCommon.<>f__mg$cache32 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_RealTimePVPComponentCommon.constructor);
		}
		LuaObject.createTypeMetatable(l, Lua_BlackJack_ProjectL_Common_RealTimePVPComponentCommon.<>f__mg$cache32, typeof(RealTimePVPComponentCommon));
	}

	// Token: 0x0400EE64 RID: 61028
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache0;

	// Token: 0x0400EE65 RID: 61029
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1;

	// Token: 0x0400EE66 RID: 61030
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2;

	// Token: 0x0400EE67 RID: 61031
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3;

	// Token: 0x0400EE68 RID: 61032
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache4;

	// Token: 0x0400EE69 RID: 61033
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache5;

	// Token: 0x0400EE6A RID: 61034
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache6;

	// Token: 0x0400EE6B RID: 61035
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache7;

	// Token: 0x0400EE6C RID: 61036
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache8;

	// Token: 0x0400EE6D RID: 61037
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache9;

	// Token: 0x0400EE6E RID: 61038
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheA;

	// Token: 0x0400EE6F RID: 61039
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheB;

	// Token: 0x0400EE70 RID: 61040
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheC;

	// Token: 0x0400EE71 RID: 61041
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheD;

	// Token: 0x0400EE72 RID: 61042
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheE;

	// Token: 0x0400EE73 RID: 61043
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheF;

	// Token: 0x0400EE74 RID: 61044
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache10;

	// Token: 0x0400EE75 RID: 61045
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache11;

	// Token: 0x0400EE76 RID: 61046
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache12;

	// Token: 0x0400EE77 RID: 61047
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache13;

	// Token: 0x0400EE78 RID: 61048
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache14;

	// Token: 0x0400EE79 RID: 61049
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache15;

	// Token: 0x0400EE7A RID: 61050
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache16;

	// Token: 0x0400EE7B RID: 61051
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache17;

	// Token: 0x0400EE7C RID: 61052
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache18;

	// Token: 0x0400EE7D RID: 61053
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache19;

	// Token: 0x0400EE7E RID: 61054
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1A;

	// Token: 0x0400EE7F RID: 61055
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1B;

	// Token: 0x0400EE80 RID: 61056
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1C;

	// Token: 0x0400EE81 RID: 61057
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1D;

	// Token: 0x0400EE82 RID: 61058
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1E;

	// Token: 0x0400EE83 RID: 61059
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1F;

	// Token: 0x0400EE84 RID: 61060
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache20;

	// Token: 0x0400EE85 RID: 61061
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache21;

	// Token: 0x0400EE86 RID: 61062
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache22;

	// Token: 0x0400EE87 RID: 61063
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache23;

	// Token: 0x0400EE88 RID: 61064
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache24;

	// Token: 0x0400EE89 RID: 61065
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache25;

	// Token: 0x0400EE8A RID: 61066
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache26;

	// Token: 0x0400EE8B RID: 61067
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache27;

	// Token: 0x0400EE8C RID: 61068
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache28;

	// Token: 0x0400EE8D RID: 61069
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache29;

	// Token: 0x0400EE8E RID: 61070
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2A;

	// Token: 0x0400EE8F RID: 61071
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2B;

	// Token: 0x0400EE90 RID: 61072
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2C;

	// Token: 0x0400EE91 RID: 61073
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2D;

	// Token: 0x0400EE92 RID: 61074
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2E;

	// Token: 0x0400EE93 RID: 61075
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2F;

	// Token: 0x0400EE94 RID: 61076
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache30;

	// Token: 0x0400EE95 RID: 61077
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache31;

	// Token: 0x0400EE96 RID: 61078
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache32;
}
