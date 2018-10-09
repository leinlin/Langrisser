using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using BlackJack.ConfigData;
using BlackJack.ProjectL.Common;
using SLua;
using UnityEngine.Scripting;

// Token: 0x02001254 RID: 4692
[Preserve]
public class Lua_BlackJack_ProjectL_Common_NoviceComponentCommon : LuaObject
{
	// Token: 0x060186EB RID: 100075 RVA: 0x006DACA4 File Offset: 0x006D8EA4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int constructor(IntPtr l)
	{
		int result;
		try
		{
			NoviceComponentCommon o = new NoviceComponentCommon();
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

	// Token: 0x060186EC RID: 100076 RVA: 0x006DACEC File Offset: 0x006D8EEC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int GetName(IntPtr l)
	{
		int result;
		try
		{
			NoviceComponentCommon noviceComponentCommon = (NoviceComponentCommon)LuaObject.checkSelf(l);
			string name = noviceComponentCommon.GetName();
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

	// Token: 0x060186ED RID: 100077 RVA: 0x006DAD40 File Offset: 0x006D8F40
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int Init(IntPtr l)
	{
		int result;
		try
		{
			NoviceComponentCommon noviceComponentCommon = (NoviceComponentCommon)LuaObject.checkSelf(l);
			noviceComponentCommon.Init();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060186EE RID: 100078 RVA: 0x006DAD8C File Offset: 0x006D8F8C
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int PostInit(IntPtr l)
	{
		int result;
		try
		{
			NoviceComponentCommon noviceComponentCommon = (NoviceComponentCommon)LuaObject.checkSelf(l);
			noviceComponentCommon.PostInit();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060186EF RID: 100079 RVA: 0x006DADD8 File Offset: 0x006D8FD8
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int DeInit(IntPtr l)
	{
		int result;
		try
		{
			NoviceComponentCommon noviceComponentCommon = (NoviceComponentCommon)LuaObject.checkSelf(l);
			noviceComponentCommon.DeInit();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060186F0 RID: 100080 RVA: 0x006DAE24 File Offset: 0x006D9024
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int Tick(IntPtr l)
	{
		int result;
		try
		{
			NoviceComponentCommon noviceComponentCommon = (NoviceComponentCommon)LuaObject.checkSelf(l);
			uint deltaMillisecond;
			LuaObject.checkType(l, 2, out deltaMillisecond);
			noviceComponentCommon.Tick(deltaMillisecond);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060186F1 RID: 100081 RVA: 0x006DAE7C File Offset: 0x006D907C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int PostDeSerialize(IntPtr l)
	{
		int result;
		try
		{
			NoviceComponentCommon noviceComponentCommon = (NoviceComponentCommon)LuaObject.checkSelf(l);
			noviceComponentCommon.PostDeSerialize();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060186F2 RID: 100082 RVA: 0x006DAEC8 File Offset: 0x006D90C8
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int GetMissionPoints(IntPtr l)
	{
		int result;
		try
		{
			NoviceComponentCommon noviceComponentCommon = (NoviceComponentCommon)LuaObject.checkSelf(l);
			int missionPoints = noviceComponentCommon.GetMissionPoints();
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, missionPoints);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060186F3 RID: 100083 RVA: 0x006DAF1C File Offset: 0x006D911C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int AddMissionPoints(IntPtr l)
	{
		int result;
		try
		{
			NoviceComponentCommon noviceComponentCommon = (NoviceComponentCommon)LuaObject.checkSelf(l);
			int delta;
			LuaObject.checkType(l, 2, out delta);
			noviceComponentCommon.AddMissionPoints(delta);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060186F4 RID: 100084 RVA: 0x006DAF74 File Offset: 0x006D9174
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int GetRewardClaimedSlots(IntPtr l)
	{
		int result;
		try
		{
			NoviceComponentCommon noviceComponentCommon = (NoviceComponentCommon)LuaObject.checkSelf(l);
			List<int> rewardClaimedSlots = noviceComponentCommon.GetRewardClaimedSlots();
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, rewardClaimedSlots);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060186F5 RID: 100085 RVA: 0x006DAFC8 File Offset: 0x006D91C8
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int IsRewardClaimed(IntPtr l)
	{
		int result;
		try
		{
			NoviceComponentCommon noviceComponentCommon = (NoviceComponentCommon)LuaObject.checkSelf(l);
			int slot;
			LuaObject.checkType(l, 2, out slot);
			bool b = noviceComponentCommon.IsRewardClaimed(slot);
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

	// Token: 0x060186F6 RID: 100086 RVA: 0x006DB02C File Offset: 0x006D922C
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int CanClaimReward(IntPtr l)
	{
		int result;
		try
		{
			NoviceComponentCommon noviceComponentCommon = (NoviceComponentCommon)LuaObject.checkSelf(l);
			int slot;
			LuaObject.checkType(l, 2, out slot);
			int i = noviceComponentCommon.CanClaimReward(slot);
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

	// Token: 0x060186F7 RID: 100087 RVA: 0x006DB090 File Offset: 0x006D9290
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int ClaimReward(IntPtr l)
	{
		int result;
		try
		{
			NoviceComponentCommon noviceComponentCommon = (NoviceComponentCommon)LuaObject.checkSelf(l);
			int slot;
			LuaObject.checkType(l, 2, out slot);
			bool noCheck;
			LuaObject.checkType(l, 3, out noCheck);
			int i = noviceComponentCommon.ClaimReward(slot, noCheck);
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

	// Token: 0x060186F8 RID: 100088 RVA: 0x006DB100 File Offset: 0x006D9300
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int GetNovicePointsRewardsConfig(IntPtr l)
	{
		int result;
		try
		{
			NoviceComponentCommon noviceComponentCommon = (NoviceComponentCommon)LuaObject.checkSelf(l);
			List<ConfigDataNoviceRewardInfo> novicePointsRewardsConfig = noviceComponentCommon.GetNovicePointsRewardsConfig();
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, novicePointsRewardsConfig);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060186F9 RID: 100089 RVA: 0x006DB154 File Offset: 0x006D9354
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int GetDaysAfterCreation(IntPtr l)
	{
		int result;
		try
		{
			NoviceComponentCommon noviceComponentCommon = (NoviceComponentCommon)LuaObject.checkSelf(l);
			int daysAfterCreation = noviceComponentCommon.GetDaysAfterCreation();
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, daysAfterCreation);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060186FA RID: 100090 RVA: 0x006DB1A8 File Offset: 0x006D93A8
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int GetProcessingMissions(IntPtr l)
	{
		int result;
		try
		{
			NoviceComponentCommon noviceComponentCommon = (NoviceComponentCommon)LuaObject.checkSelf(l);
			List<Mission> processingMissions = noviceComponentCommon.GetProcessingMissions();
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, processingMissions);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060186FB RID: 100091 RVA: 0x006DB1FC File Offset: 0x006D93FC
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int GetFinishedMissions(IntPtr l)
	{
		int result;
		try
		{
			NoviceComponentCommon noviceComponentCommon = (NoviceComponentCommon)LuaObject.checkSelf(l);
			List<Mission> finishedMissions = noviceComponentCommon.GetFinishedMissions();
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, finishedMissions);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060186FC RID: 100092 RVA: 0x006DB250 File Offset: 0x006D9450
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int GetMissionDay(IntPtr l)
	{
		int result;
		try
		{
			NoviceComponentCommon noviceComponentCommon = (NoviceComponentCommon)LuaObject.checkSelf(l);
			ConfigDataMissionInfo mission;
			LuaObject.checkType<ConfigDataMissionInfo>(l, 2, out mission);
			int missionDay = noviceComponentCommon.GetMissionDay(mission);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, missionDay);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060186FD RID: 100093 RVA: 0x006DB2B4 File Offset: 0x006D94B4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int GetMissions(IntPtr l)
	{
		int result;
		try
		{
			NoviceComponentCommon noviceComponentCommon = (NoviceComponentCommon)LuaObject.checkSelf(l);
			Dictionary<int, List<int>> missions = noviceComponentCommon.GetMissions();
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, missions);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060186FE RID: 100094 RVA: 0x006DB308 File Offset: 0x006D9508
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int GetMissionsEndTime(IntPtr l)
	{
		int result;
		try
		{
			NoviceComponentCommon noviceComponentCommon = (NoviceComponentCommon)LuaObject.checkSelf(l);
			TimeSpan missionsEndTime = noviceComponentCommon.GetMissionsEndTime();
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, missionsEndTime);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060186FF RID: 100095 RVA: 0x006DB364 File Offset: 0x006D9564
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get__configDataLoader(IntPtr l)
	{
		int result;
		try
		{
			NoviceComponentCommon noviceComponentCommon = (NoviceComponentCommon)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, noviceComponentCommon.m_luaExportHelper._configDataLoader);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06018700 RID: 100096 RVA: 0x006DB3BC File Offset: 0x006D95BC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set__configDataLoader(IntPtr l)
	{
		int result;
		try
		{
			NoviceComponentCommon noviceComponentCommon = (NoviceComponentCommon)LuaObject.checkSelf(l);
			IConfigDataLoader configDataLoader;
			LuaObject.checkType<IConfigDataLoader>(l, 2, out configDataLoader);
			noviceComponentCommon.m_luaExportHelper._configDataLoader = configDataLoader;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06018701 RID: 100097 RVA: 0x006DB418 File Offset: 0x006D9618
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_novicePointsRewards(IntPtr l)
	{
		int result;
		try
		{
			NoviceComponentCommon noviceComponentCommon = (NoviceComponentCommon)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, noviceComponentCommon.m_luaExportHelper.m_novicePointsRewards);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06018702 RID: 100098 RVA: 0x006DB470 File Offset: 0x006D9670
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_m_novicePointsRewards(IntPtr l)
	{
		int result;
		try
		{
			NoviceComponentCommon noviceComponentCommon = (NoviceComponentCommon)LuaObject.checkSelf(l);
			List<ConfigDataNoviceRewardInfo> novicePointsRewards;
			LuaObject.checkType<List<ConfigDataNoviceRewardInfo>>(l, 2, out novicePointsRewards);
			noviceComponentCommon.m_luaExportHelper.m_novicePointsRewards = novicePointsRewards;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06018703 RID: 100099 RVA: 0x006DB4CC File Offset: 0x006D96CC
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_m_noviceMissionDuration(IntPtr l)
	{
		int result;
		try
		{
			NoviceComponentCommon noviceComponentCommon = (NoviceComponentCommon)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, noviceComponentCommon.m_luaExportHelper.m_noviceMissionDuration);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06018704 RID: 100100 RVA: 0x006DB528 File Offset: 0x006D9728
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_noviceMissionDuration(IntPtr l)
	{
		int result;
		try
		{
			NoviceComponentCommon noviceComponentCommon = (NoviceComponentCommon)LuaObject.checkSelf(l);
			TimeSpan noviceMissionDuration;
			LuaObject.checkValueType<TimeSpan>(l, 2, out noviceMissionDuration);
			noviceComponentCommon.m_luaExportHelper.m_noviceMissionDuration = noviceMissionDuration;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06018705 RID: 100101 RVA: 0x006DB584 File Offset: 0x006D9784
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_basicInfo(IntPtr l)
	{
		int result;
		try
		{
			NoviceComponentCommon noviceComponentCommon = (NoviceComponentCommon)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, noviceComponentCommon.m_luaExportHelper.m_basicInfo);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06018706 RID: 100102 RVA: 0x006DB5DC File Offset: 0x006D97DC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_basicInfo(IntPtr l)
	{
		int result;
		try
		{
			NoviceComponentCommon noviceComponentCommon = (NoviceComponentCommon)LuaObject.checkSelf(l);
			PlayerBasicInfoComponentCommon basicInfo;
			LuaObject.checkType<PlayerBasicInfoComponentCommon>(l, 2, out basicInfo);
			noviceComponentCommon.m_luaExportHelper.m_basicInfo = basicInfo;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06018707 RID: 100103 RVA: 0x006DB638 File Offset: 0x006D9838
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_hero(IntPtr l)
	{
		int result;
		try
		{
			NoviceComponentCommon noviceComponentCommon = (NoviceComponentCommon)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, noviceComponentCommon.m_luaExportHelper.m_hero);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06018708 RID: 100104 RVA: 0x006DB690 File Offset: 0x006D9890
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_m_hero(IntPtr l)
	{
		int result;
		try
		{
			NoviceComponentCommon noviceComponentCommon = (NoviceComponentCommon)LuaObject.checkSelf(l);
			HeroComponentCommon hero;
			LuaObject.checkType<HeroComponentCommon>(l, 2, out hero);
			noviceComponentCommon.m_luaExportHelper.m_hero = hero;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06018709 RID: 100105 RVA: 0x006DB6EC File Offset: 0x006D98EC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_bag(IntPtr l)
	{
		int result;
		try
		{
			NoviceComponentCommon noviceComponentCommon = (NoviceComponentCommon)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, noviceComponentCommon.m_luaExportHelper.m_bag);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601870A RID: 100106 RVA: 0x006DB744 File Offset: 0x006D9944
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_m_bag(IntPtr l)
	{
		int result;
		try
		{
			NoviceComponentCommon noviceComponentCommon = (NoviceComponentCommon)LuaObject.checkSelf(l);
			BagComponentCommon bag;
			LuaObject.checkType<BagComponentCommon>(l, 2, out bag);
			noviceComponentCommon.m_luaExportHelper.m_bag = bag;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601870B RID: 100107 RVA: 0x006DB7A0 File Offset: 0x006D99A0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_mission(IntPtr l)
	{
		int result;
		try
		{
			NoviceComponentCommon noviceComponentCommon = (NoviceComponentCommon)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, noviceComponentCommon.m_luaExportHelper.m_mission);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601870C RID: 100108 RVA: 0x006DB7F8 File Offset: 0x006D99F8
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_m_mission(IntPtr l)
	{
		int result;
		try
		{
			NoviceComponentCommon noviceComponentCommon = (NoviceComponentCommon)LuaObject.checkSelf(l);
			MissionComponentCommon mission;
			LuaObject.checkType<MissionComponentCommon>(l, 2, out mission);
			noviceComponentCommon.m_luaExportHelper.m_mission = mission;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601870D RID: 100109 RVA: 0x006DB854 File Offset: 0x006D9A54
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_m_noviceDS(IntPtr l)
	{
		int result;
		try
		{
			NoviceComponentCommon noviceComponentCommon = (NoviceComponentCommon)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, noviceComponentCommon.m_luaExportHelper.m_noviceDS);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601870E RID: 100110 RVA: 0x006DB8AC File Offset: 0x006D9AAC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_noviceDS(IntPtr l)
	{
		int result;
		try
		{
			NoviceComponentCommon noviceComponentCommon = (NoviceComponentCommon)LuaObject.checkSelf(l);
			DataSectionNovice noviceDS;
			LuaObject.checkType<DataSectionNovice>(l, 2, out noviceDS);
			noviceComponentCommon.m_luaExportHelper.m_noviceDS = noviceDS;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601870F RID: 100111 RVA: 0x006DB908 File Offset: 0x006D9B08
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_Owner(IntPtr l)
	{
		int result;
		try
		{
			NoviceComponentCommon noviceComponentCommon = (NoviceComponentCommon)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, noviceComponentCommon.Owner);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06018710 RID: 100112 RVA: 0x006DB95C File Offset: 0x006D9B5C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_Owner(IntPtr l)
	{
		int result;
		try
		{
			NoviceComponentCommon noviceComponentCommon = (NoviceComponentCommon)LuaObject.checkSelf(l);
			IComponentOwner owner;
			LuaObject.checkType<IComponentOwner>(l, 2, out owner);
			noviceComponentCommon.Owner = owner;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06018711 RID: 100113 RVA: 0x006DB9B4 File Offset: 0x006D9BB4
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_m_configDataLoader(IntPtr l)
	{
		int result;
		try
		{
			NoviceComponentCommon noviceComponentCommon = (NoviceComponentCommon)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, noviceComponentCommon.m_luaExportHelper.m_configDataLoader);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06018712 RID: 100114 RVA: 0x006DBA0C File Offset: 0x006D9C0C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_configDataLoader(IntPtr l)
	{
		int result;
		try
		{
			NoviceComponentCommon noviceComponentCommon = (NoviceComponentCommon)LuaObject.checkSelf(l);
			IConfigDataLoader configDataLoader;
			LuaObject.checkType<IConfigDataLoader>(l, 2, out configDataLoader);
			noviceComponentCommon.m_luaExportHelper.m_configDataLoader = configDataLoader;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06018713 RID: 100115 RVA: 0x006DBA68 File Offset: 0x006D9C68
	[Preserve]
	public static void reg(IntPtr l)
	{
		LuaObject.getTypeTable(l, "BlackJack.ProjectL.Common.NoviceComponentCommon");
		if (Lua_BlackJack_ProjectL_Common_NoviceComponentCommon.<>f__mg$cache0 == null)
		{
			Lua_BlackJack_ProjectL_Common_NoviceComponentCommon.<>f__mg$cache0 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_NoviceComponentCommon.GetName);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_NoviceComponentCommon.<>f__mg$cache0);
		if (Lua_BlackJack_ProjectL_Common_NoviceComponentCommon.<>f__mg$cache1 == null)
		{
			Lua_BlackJack_ProjectL_Common_NoviceComponentCommon.<>f__mg$cache1 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_NoviceComponentCommon.Init);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_NoviceComponentCommon.<>f__mg$cache1);
		if (Lua_BlackJack_ProjectL_Common_NoviceComponentCommon.<>f__mg$cache2 == null)
		{
			Lua_BlackJack_ProjectL_Common_NoviceComponentCommon.<>f__mg$cache2 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_NoviceComponentCommon.PostInit);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_NoviceComponentCommon.<>f__mg$cache2);
		if (Lua_BlackJack_ProjectL_Common_NoviceComponentCommon.<>f__mg$cache3 == null)
		{
			Lua_BlackJack_ProjectL_Common_NoviceComponentCommon.<>f__mg$cache3 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_NoviceComponentCommon.DeInit);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_NoviceComponentCommon.<>f__mg$cache3);
		if (Lua_BlackJack_ProjectL_Common_NoviceComponentCommon.<>f__mg$cache4 == null)
		{
			Lua_BlackJack_ProjectL_Common_NoviceComponentCommon.<>f__mg$cache4 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_NoviceComponentCommon.Tick);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_NoviceComponentCommon.<>f__mg$cache4);
		if (Lua_BlackJack_ProjectL_Common_NoviceComponentCommon.<>f__mg$cache5 == null)
		{
			Lua_BlackJack_ProjectL_Common_NoviceComponentCommon.<>f__mg$cache5 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_NoviceComponentCommon.PostDeSerialize);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_NoviceComponentCommon.<>f__mg$cache5);
		if (Lua_BlackJack_ProjectL_Common_NoviceComponentCommon.<>f__mg$cache6 == null)
		{
			Lua_BlackJack_ProjectL_Common_NoviceComponentCommon.<>f__mg$cache6 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_NoviceComponentCommon.GetMissionPoints);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_NoviceComponentCommon.<>f__mg$cache6);
		if (Lua_BlackJack_ProjectL_Common_NoviceComponentCommon.<>f__mg$cache7 == null)
		{
			Lua_BlackJack_ProjectL_Common_NoviceComponentCommon.<>f__mg$cache7 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_NoviceComponentCommon.AddMissionPoints);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_NoviceComponentCommon.<>f__mg$cache7);
		if (Lua_BlackJack_ProjectL_Common_NoviceComponentCommon.<>f__mg$cache8 == null)
		{
			Lua_BlackJack_ProjectL_Common_NoviceComponentCommon.<>f__mg$cache8 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_NoviceComponentCommon.GetRewardClaimedSlots);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_NoviceComponentCommon.<>f__mg$cache8);
		if (Lua_BlackJack_ProjectL_Common_NoviceComponentCommon.<>f__mg$cache9 == null)
		{
			Lua_BlackJack_ProjectL_Common_NoviceComponentCommon.<>f__mg$cache9 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_NoviceComponentCommon.IsRewardClaimed);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_NoviceComponentCommon.<>f__mg$cache9);
		if (Lua_BlackJack_ProjectL_Common_NoviceComponentCommon.<>f__mg$cacheA == null)
		{
			Lua_BlackJack_ProjectL_Common_NoviceComponentCommon.<>f__mg$cacheA = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_NoviceComponentCommon.CanClaimReward);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_NoviceComponentCommon.<>f__mg$cacheA);
		if (Lua_BlackJack_ProjectL_Common_NoviceComponentCommon.<>f__mg$cacheB == null)
		{
			Lua_BlackJack_ProjectL_Common_NoviceComponentCommon.<>f__mg$cacheB = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_NoviceComponentCommon.ClaimReward);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_NoviceComponentCommon.<>f__mg$cacheB);
		if (Lua_BlackJack_ProjectL_Common_NoviceComponentCommon.<>f__mg$cacheC == null)
		{
			Lua_BlackJack_ProjectL_Common_NoviceComponentCommon.<>f__mg$cacheC = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_NoviceComponentCommon.GetNovicePointsRewardsConfig);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_NoviceComponentCommon.<>f__mg$cacheC);
		if (Lua_BlackJack_ProjectL_Common_NoviceComponentCommon.<>f__mg$cacheD == null)
		{
			Lua_BlackJack_ProjectL_Common_NoviceComponentCommon.<>f__mg$cacheD = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_NoviceComponentCommon.GetDaysAfterCreation);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_NoviceComponentCommon.<>f__mg$cacheD);
		if (Lua_BlackJack_ProjectL_Common_NoviceComponentCommon.<>f__mg$cacheE == null)
		{
			Lua_BlackJack_ProjectL_Common_NoviceComponentCommon.<>f__mg$cacheE = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_NoviceComponentCommon.GetProcessingMissions);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_NoviceComponentCommon.<>f__mg$cacheE);
		if (Lua_BlackJack_ProjectL_Common_NoviceComponentCommon.<>f__mg$cacheF == null)
		{
			Lua_BlackJack_ProjectL_Common_NoviceComponentCommon.<>f__mg$cacheF = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_NoviceComponentCommon.GetFinishedMissions);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_NoviceComponentCommon.<>f__mg$cacheF);
		if (Lua_BlackJack_ProjectL_Common_NoviceComponentCommon.<>f__mg$cache10 == null)
		{
			Lua_BlackJack_ProjectL_Common_NoviceComponentCommon.<>f__mg$cache10 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_NoviceComponentCommon.GetMissionDay);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_NoviceComponentCommon.<>f__mg$cache10);
		if (Lua_BlackJack_ProjectL_Common_NoviceComponentCommon.<>f__mg$cache11 == null)
		{
			Lua_BlackJack_ProjectL_Common_NoviceComponentCommon.<>f__mg$cache11 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_NoviceComponentCommon.GetMissions);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_NoviceComponentCommon.<>f__mg$cache11);
		if (Lua_BlackJack_ProjectL_Common_NoviceComponentCommon.<>f__mg$cache12 == null)
		{
			Lua_BlackJack_ProjectL_Common_NoviceComponentCommon.<>f__mg$cache12 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_NoviceComponentCommon.GetMissionsEndTime);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_NoviceComponentCommon.<>f__mg$cache12);
		string name = "_configDataLoader";
		if (Lua_BlackJack_ProjectL_Common_NoviceComponentCommon.<>f__mg$cache13 == null)
		{
			Lua_BlackJack_ProjectL_Common_NoviceComponentCommon.<>f__mg$cache13 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_NoviceComponentCommon.get__configDataLoader);
		}
		LuaCSFunction get = Lua_BlackJack_ProjectL_Common_NoviceComponentCommon.<>f__mg$cache13;
		if (Lua_BlackJack_ProjectL_Common_NoviceComponentCommon.<>f__mg$cache14 == null)
		{
			Lua_BlackJack_ProjectL_Common_NoviceComponentCommon.<>f__mg$cache14 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_NoviceComponentCommon.set__configDataLoader);
		}
		LuaObject.addMember(l, name, get, Lua_BlackJack_ProjectL_Common_NoviceComponentCommon.<>f__mg$cache14, true);
		string name2 = "m_novicePointsRewards";
		if (Lua_BlackJack_ProjectL_Common_NoviceComponentCommon.<>f__mg$cache15 == null)
		{
			Lua_BlackJack_ProjectL_Common_NoviceComponentCommon.<>f__mg$cache15 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_NoviceComponentCommon.get_m_novicePointsRewards);
		}
		LuaCSFunction get2 = Lua_BlackJack_ProjectL_Common_NoviceComponentCommon.<>f__mg$cache15;
		if (Lua_BlackJack_ProjectL_Common_NoviceComponentCommon.<>f__mg$cache16 == null)
		{
			Lua_BlackJack_ProjectL_Common_NoviceComponentCommon.<>f__mg$cache16 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_NoviceComponentCommon.set_m_novicePointsRewards);
		}
		LuaObject.addMember(l, name2, get2, Lua_BlackJack_ProjectL_Common_NoviceComponentCommon.<>f__mg$cache16, true);
		string name3 = "m_noviceMissionDuration";
		if (Lua_BlackJack_ProjectL_Common_NoviceComponentCommon.<>f__mg$cache17 == null)
		{
			Lua_BlackJack_ProjectL_Common_NoviceComponentCommon.<>f__mg$cache17 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_NoviceComponentCommon.get_m_noviceMissionDuration);
		}
		LuaCSFunction get3 = Lua_BlackJack_ProjectL_Common_NoviceComponentCommon.<>f__mg$cache17;
		if (Lua_BlackJack_ProjectL_Common_NoviceComponentCommon.<>f__mg$cache18 == null)
		{
			Lua_BlackJack_ProjectL_Common_NoviceComponentCommon.<>f__mg$cache18 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_NoviceComponentCommon.set_m_noviceMissionDuration);
		}
		LuaObject.addMember(l, name3, get3, Lua_BlackJack_ProjectL_Common_NoviceComponentCommon.<>f__mg$cache18, true);
		string name4 = "m_basicInfo";
		if (Lua_BlackJack_ProjectL_Common_NoviceComponentCommon.<>f__mg$cache19 == null)
		{
			Lua_BlackJack_ProjectL_Common_NoviceComponentCommon.<>f__mg$cache19 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_NoviceComponentCommon.get_m_basicInfo);
		}
		LuaCSFunction get4 = Lua_BlackJack_ProjectL_Common_NoviceComponentCommon.<>f__mg$cache19;
		if (Lua_BlackJack_ProjectL_Common_NoviceComponentCommon.<>f__mg$cache1A == null)
		{
			Lua_BlackJack_ProjectL_Common_NoviceComponentCommon.<>f__mg$cache1A = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_NoviceComponentCommon.set_m_basicInfo);
		}
		LuaObject.addMember(l, name4, get4, Lua_BlackJack_ProjectL_Common_NoviceComponentCommon.<>f__mg$cache1A, true);
		string name5 = "m_hero";
		if (Lua_BlackJack_ProjectL_Common_NoviceComponentCommon.<>f__mg$cache1B == null)
		{
			Lua_BlackJack_ProjectL_Common_NoviceComponentCommon.<>f__mg$cache1B = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_NoviceComponentCommon.get_m_hero);
		}
		LuaCSFunction get5 = Lua_BlackJack_ProjectL_Common_NoviceComponentCommon.<>f__mg$cache1B;
		if (Lua_BlackJack_ProjectL_Common_NoviceComponentCommon.<>f__mg$cache1C == null)
		{
			Lua_BlackJack_ProjectL_Common_NoviceComponentCommon.<>f__mg$cache1C = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_NoviceComponentCommon.set_m_hero);
		}
		LuaObject.addMember(l, name5, get5, Lua_BlackJack_ProjectL_Common_NoviceComponentCommon.<>f__mg$cache1C, true);
		string name6 = "m_bag";
		if (Lua_BlackJack_ProjectL_Common_NoviceComponentCommon.<>f__mg$cache1D == null)
		{
			Lua_BlackJack_ProjectL_Common_NoviceComponentCommon.<>f__mg$cache1D = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_NoviceComponentCommon.get_m_bag);
		}
		LuaCSFunction get6 = Lua_BlackJack_ProjectL_Common_NoviceComponentCommon.<>f__mg$cache1D;
		if (Lua_BlackJack_ProjectL_Common_NoviceComponentCommon.<>f__mg$cache1E == null)
		{
			Lua_BlackJack_ProjectL_Common_NoviceComponentCommon.<>f__mg$cache1E = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_NoviceComponentCommon.set_m_bag);
		}
		LuaObject.addMember(l, name6, get6, Lua_BlackJack_ProjectL_Common_NoviceComponentCommon.<>f__mg$cache1E, true);
		string name7 = "m_mission";
		if (Lua_BlackJack_ProjectL_Common_NoviceComponentCommon.<>f__mg$cache1F == null)
		{
			Lua_BlackJack_ProjectL_Common_NoviceComponentCommon.<>f__mg$cache1F = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_NoviceComponentCommon.get_m_mission);
		}
		LuaCSFunction get7 = Lua_BlackJack_ProjectL_Common_NoviceComponentCommon.<>f__mg$cache1F;
		if (Lua_BlackJack_ProjectL_Common_NoviceComponentCommon.<>f__mg$cache20 == null)
		{
			Lua_BlackJack_ProjectL_Common_NoviceComponentCommon.<>f__mg$cache20 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_NoviceComponentCommon.set_m_mission);
		}
		LuaObject.addMember(l, name7, get7, Lua_BlackJack_ProjectL_Common_NoviceComponentCommon.<>f__mg$cache20, true);
		string name8 = "m_noviceDS";
		if (Lua_BlackJack_ProjectL_Common_NoviceComponentCommon.<>f__mg$cache21 == null)
		{
			Lua_BlackJack_ProjectL_Common_NoviceComponentCommon.<>f__mg$cache21 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_NoviceComponentCommon.get_m_noviceDS);
		}
		LuaCSFunction get8 = Lua_BlackJack_ProjectL_Common_NoviceComponentCommon.<>f__mg$cache21;
		if (Lua_BlackJack_ProjectL_Common_NoviceComponentCommon.<>f__mg$cache22 == null)
		{
			Lua_BlackJack_ProjectL_Common_NoviceComponentCommon.<>f__mg$cache22 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_NoviceComponentCommon.set_m_noviceDS);
		}
		LuaObject.addMember(l, name8, get8, Lua_BlackJack_ProjectL_Common_NoviceComponentCommon.<>f__mg$cache22, true);
		string name9 = "Owner";
		if (Lua_BlackJack_ProjectL_Common_NoviceComponentCommon.<>f__mg$cache23 == null)
		{
			Lua_BlackJack_ProjectL_Common_NoviceComponentCommon.<>f__mg$cache23 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_NoviceComponentCommon.get_Owner);
		}
		LuaCSFunction get9 = Lua_BlackJack_ProjectL_Common_NoviceComponentCommon.<>f__mg$cache23;
		if (Lua_BlackJack_ProjectL_Common_NoviceComponentCommon.<>f__mg$cache24 == null)
		{
			Lua_BlackJack_ProjectL_Common_NoviceComponentCommon.<>f__mg$cache24 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_NoviceComponentCommon.set_Owner);
		}
		LuaObject.addMember(l, name9, get9, Lua_BlackJack_ProjectL_Common_NoviceComponentCommon.<>f__mg$cache24, true);
		string name10 = "m_configDataLoader";
		if (Lua_BlackJack_ProjectL_Common_NoviceComponentCommon.<>f__mg$cache25 == null)
		{
			Lua_BlackJack_ProjectL_Common_NoviceComponentCommon.<>f__mg$cache25 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_NoviceComponentCommon.get_m_configDataLoader);
		}
		LuaCSFunction get10 = Lua_BlackJack_ProjectL_Common_NoviceComponentCommon.<>f__mg$cache25;
		if (Lua_BlackJack_ProjectL_Common_NoviceComponentCommon.<>f__mg$cache26 == null)
		{
			Lua_BlackJack_ProjectL_Common_NoviceComponentCommon.<>f__mg$cache26 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_NoviceComponentCommon.set_m_configDataLoader);
		}
		LuaObject.addMember(l, name10, get10, Lua_BlackJack_ProjectL_Common_NoviceComponentCommon.<>f__mg$cache26, true);
		if (Lua_BlackJack_ProjectL_Common_NoviceComponentCommon.<>f__mg$cache27 == null)
		{
			Lua_BlackJack_ProjectL_Common_NoviceComponentCommon.<>f__mg$cache27 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_NoviceComponentCommon.constructor);
		}
		LuaObject.createTypeMetatable(l, Lua_BlackJack_ProjectL_Common_NoviceComponentCommon.<>f__mg$cache27, typeof(NoviceComponentCommon));
	}

	// Token: 0x0400EC25 RID: 60453
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache0;

	// Token: 0x0400EC26 RID: 60454
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1;

	// Token: 0x0400EC27 RID: 60455
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2;

	// Token: 0x0400EC28 RID: 60456
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3;

	// Token: 0x0400EC29 RID: 60457
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache4;

	// Token: 0x0400EC2A RID: 60458
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache5;

	// Token: 0x0400EC2B RID: 60459
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache6;

	// Token: 0x0400EC2C RID: 60460
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache7;

	// Token: 0x0400EC2D RID: 60461
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache8;

	// Token: 0x0400EC2E RID: 60462
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache9;

	// Token: 0x0400EC2F RID: 60463
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheA;

	// Token: 0x0400EC30 RID: 60464
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheB;

	// Token: 0x0400EC31 RID: 60465
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheC;

	// Token: 0x0400EC32 RID: 60466
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheD;

	// Token: 0x0400EC33 RID: 60467
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheE;

	// Token: 0x0400EC34 RID: 60468
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheF;

	// Token: 0x0400EC35 RID: 60469
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache10;

	// Token: 0x0400EC36 RID: 60470
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache11;

	// Token: 0x0400EC37 RID: 60471
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache12;

	// Token: 0x0400EC38 RID: 60472
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache13;

	// Token: 0x0400EC39 RID: 60473
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache14;

	// Token: 0x0400EC3A RID: 60474
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache15;

	// Token: 0x0400EC3B RID: 60475
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache16;

	// Token: 0x0400EC3C RID: 60476
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache17;

	// Token: 0x0400EC3D RID: 60477
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache18;

	// Token: 0x0400EC3E RID: 60478
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache19;

	// Token: 0x0400EC3F RID: 60479
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1A;

	// Token: 0x0400EC40 RID: 60480
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1B;

	// Token: 0x0400EC41 RID: 60481
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1C;

	// Token: 0x0400EC42 RID: 60482
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1D;

	// Token: 0x0400EC43 RID: 60483
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1E;

	// Token: 0x0400EC44 RID: 60484
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1F;

	// Token: 0x0400EC45 RID: 60485
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache20;

	// Token: 0x0400EC46 RID: 60486
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache21;

	// Token: 0x0400EC47 RID: 60487
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache22;

	// Token: 0x0400EC48 RID: 60488
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache23;

	// Token: 0x0400EC49 RID: 60489
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache24;

	// Token: 0x0400EC4A RID: 60490
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache25;

	// Token: 0x0400EC4B RID: 60491
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache26;

	// Token: 0x0400EC4C RID: 60492
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache27;
}
