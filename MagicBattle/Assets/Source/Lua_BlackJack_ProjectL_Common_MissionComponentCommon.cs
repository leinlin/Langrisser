using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using BlackJack.ConfigData;
using BlackJack.ProjectL.Common;
using SLua;
using UnityEngine.Scripting;

// Token: 0x02001252 RID: 4690
[Preserve]
public class Lua_BlackJack_ProjectL_Common_MissionComponentCommon : LuaObject
{
	// Token: 0x06018639 RID: 99897 RVA: 0x006D54F0 File Offset: 0x006D36F0
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int constructor(IntPtr l)
	{
		int result;
		try
		{
			MissionComponentCommon o = new MissionComponentCommon();
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

	// Token: 0x0601863A RID: 99898 RVA: 0x006D5538 File Offset: 0x006D3738
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int GetName(IntPtr l)
	{
		int result;
		try
		{
			MissionComponentCommon missionComponentCommon = (MissionComponentCommon)LuaObject.checkSelf(l);
			string name = missionComponentCommon.GetName();
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

	// Token: 0x0601863B RID: 99899 RVA: 0x006D558C File Offset: 0x006D378C
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int Init(IntPtr l)
	{
		int result;
		try
		{
			MissionComponentCommon missionComponentCommon = (MissionComponentCommon)LuaObject.checkSelf(l);
			missionComponentCommon.Init();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601863C RID: 99900 RVA: 0x006D55D8 File Offset: 0x006D37D8
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int PostInit(IntPtr l)
	{
		int result;
		try
		{
			MissionComponentCommon missionComponentCommon = (MissionComponentCommon)LuaObject.checkSelf(l);
			missionComponentCommon.PostInit();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601863D RID: 99901 RVA: 0x006D5624 File Offset: 0x006D3824
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int DeInit(IntPtr l)
	{
		int result;
		try
		{
			MissionComponentCommon missionComponentCommon = (MissionComponentCommon)LuaObject.checkSelf(l);
			missionComponentCommon.DeInit();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601863E RID: 99902 RVA: 0x006D5670 File Offset: 0x006D3870
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int Tick(IntPtr l)
	{
		int result;
		try
		{
			MissionComponentCommon missionComponentCommon = (MissionComponentCommon)LuaObject.checkSelf(l);
			uint deltaMillisecond;
			LuaObject.checkType(l, 2, out deltaMillisecond);
			missionComponentCommon.Tick(deltaMillisecond);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601863F RID: 99903 RVA: 0x006D56C8 File Offset: 0x006D38C8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int PostDeSerialize(IntPtr l)
	{
		int result;
		try
		{
			MissionComponentCommon missionComponentCommon = (MissionComponentCommon)LuaObject.checkSelf(l);
			missionComponentCommon.PostDeSerialize();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06018640 RID: 99904 RVA: 0x006D5714 File Offset: 0x006D3914
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int RemoveProcessingMissionById(IntPtr l)
	{
		int result;
		try
		{
			MissionComponentCommon missionComponentCommon = (MissionComponentCommon)LuaObject.checkSelf(l);
			int missionId;
			LuaObject.checkType(l, 2, out missionId);
			missionComponentCommon.RemoveProcessingMissionById(missionId);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06018641 RID: 99905 RVA: 0x006D576C File Offset: 0x006D396C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int GetProcessingMissionByMissionType(IntPtr l)
	{
		int result;
		try
		{
			MissionComponentCommon missionComponentCommon = (MissionComponentCommon)LuaObject.checkSelf(l);
			MissionType missionType;
			LuaObject.checkEnum<MissionType>(l, 2, out missionType);
			List<Mission> processingMissionByMissionType = missionComponentCommon.GetProcessingMissionByMissionType(missionType);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, processingMissionByMissionType);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06018642 RID: 99906 RVA: 0x006D57D0 File Offset: 0x006D39D0
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int CanGetRewarding(IntPtr l)
	{
		int result;
		try
		{
			MissionComponentCommon missionComponentCommon = (MissionComponentCommon)LuaObject.checkSelf(l);
			Mission mission;
			LuaObject.checkType<Mission>(l, 2, out mission);
			bool b = missionComponentCommon.CanGetRewarding(mission);
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

	// Token: 0x06018643 RID: 99907 RVA: 0x006D5834 File Offset: 0x006D3A34
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int IsMissionFinished(IntPtr l)
	{
		int result;
		try
		{
			MissionComponentCommon missionComponentCommon = (MissionComponentCommon)LuaObject.checkSelf(l);
			int missionId;
			LuaObject.checkType(l, 2, out missionId);
			bool b = missionComponentCommon.IsMissionFinished(missionId);
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

	// Token: 0x06018644 RID: 99908 RVA: 0x006D5898 File Offset: 0x006D3A98
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int GetAllProcessingNoviceMissionList(IntPtr l)
	{
		int result;
		try
		{
			MissionComponentCommon missionComponentCommon = (MissionComponentCommon)LuaObject.checkSelf(l);
			List<Mission> allProcessingNoviceMissionList = missionComponentCommon.GetAllProcessingNoviceMissionList();
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, allProcessingNoviceMissionList);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06018645 RID: 99909 RVA: 0x006D58EC File Offset: 0x006D3AEC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int GetAllFinishedNoviceMissionList(IntPtr l)
	{
		int result;
		try
		{
			MissionComponentCommon missionComponentCommon = (MissionComponentCommon)LuaObject.checkSelf(l);
			List<Mission> allFinishedNoviceMissionList = missionComponentCommon.GetAllFinishedNoviceMissionList();
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, allFinishedNoviceMissionList);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06018646 RID: 99910 RVA: 0x006D5940 File Offset: 0x006D3B40
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int GetMissionMaxProcess(IntPtr l)
	{
		int result;
		try
		{
			MissionComponentCommon missionComponentCommon = (MissionComponentCommon)LuaObject.checkSelf(l);
			Mission mission;
			LuaObject.checkType<Mission>(l, 2, out mission);
			int missionMaxProcess = missionComponentCommon.GetMissionMaxProcess(mission);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, missionMaxProcess);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06018647 RID: 99911 RVA: 0x006D59A4 File Offset: 0x006D3BA4
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int IsMissionProcessFinished(IntPtr l)
	{
		int result;
		try
		{
			MissionComponentCommon missionComponentCommon = (MissionComponentCommon)LuaObject.checkSelf(l);
			int missionId;
			LuaObject.checkType(l, 2, out missionId);
			bool b = missionComponentCommon.IsMissionProcessFinished(missionId);
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

	// Token: 0x06018648 RID: 99912 RVA: 0x006D5A08 File Offset: 0x006D3C08
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int CanGainMissionReward(IntPtr l)
	{
		int result;
		try
		{
			MissionComponentCommon missionComponentCommon = (MissionComponentCommon)LuaObject.checkSelf(l);
			int missionId;
			LuaObject.checkType(l, 2, out missionId);
			int i = missionComponentCommon.CanGainMissionReward(missionId);
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

	// Token: 0x06018649 RID: 99913 RVA: 0x006D5A6C File Offset: 0x006D3C6C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int GetMissionCompletedProcess(IntPtr l)
	{
		int result;
		try
		{
			MissionComponentCommon missionComponentCommon = (MissionComponentCommon)LuaObject.checkSelf(l);
			Mission mission;
			LuaObject.checkType<Mission>(l, 2, out mission);
			long missionCompletedProcess = missionComponentCommon.GetMissionCompletedProcess(mission);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, missionCompletedProcess);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601864A RID: 99914 RVA: 0x006D5AD0 File Offset: 0x006D3CD0
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int OnMonthCardVaildEveryDayFlush(IntPtr l)
	{
		int result;
		try
		{
			MissionComponentCommon missionComponentCommon = (MissionComponentCommon)LuaObject.checkSelf(l);
			missionComponentCommon.m_luaExportHelper.OnMonthCardVaildEveryDayFlush();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601864B RID: 99915 RVA: 0x006D5B24 File Offset: 0x006D3D24
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int OnMonthCardVaildCallBack(IntPtr l)
	{
		int result;
		try
		{
			MissionComponentCommon missionComponentCommon = (MissionComponentCommon)LuaObject.checkSelf(l);
			int monthCardId;
			LuaObject.checkType(l, 2, out monthCardId);
			missionComponentCommon.m_luaExportHelper.OnMonthCardVaildCallBack(monthCardId);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601864C RID: 99916 RVA: 0x006D5B80 File Offset: 0x006D3D80
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int InitProcessingMission(IntPtr l)
	{
		int result;
		try
		{
			MissionComponentCommon missionComponentCommon = (MissionComponentCommon)LuaObject.checkSelf(l);
			List<Mission> processingMissionList;
			LuaObject.checkType<List<Mission>>(l, 2, out processingMissionList);
			missionComponentCommon.m_luaExportHelper.InitProcessingMission(processingMissionList);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601864D RID: 99917 RVA: 0x006D5BDC File Offset: 0x006D3DDC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int InitExistMissions(IntPtr l)
	{
		int result;
		try
		{
			MissionComponentCommon missionComponentCommon = (MissionComponentCommon)LuaObject.checkSelf(l);
			missionComponentCommon.m_luaExportHelper.InitExistMissions();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601864E RID: 99918 RVA: 0x006D5C30 File Offset: 0x006D3E30
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int OnFlushEverydayMissionEvent(IntPtr l)
	{
		int result;
		try
		{
			MissionComponentCommon missionComponentCommon = (MissionComponentCommon)LuaObject.checkSelf(l);
			missionComponentCommon.m_luaExportHelper.OnFlushEverydayMissionEvent();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601864F RID: 99919 RVA: 0x006D5C84 File Offset: 0x006D3E84
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int ResetEverydayMissions(IntPtr l)
	{
		int result;
		try
		{
			MissionComponentCommon missionComponentCommon = (MissionComponentCommon)LuaObject.checkSelf(l);
			missionComponentCommon.m_luaExportHelper.ResetEverydayMissions();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06018650 RID: 99920 RVA: 0x006D5CD8 File Offset: 0x006D3ED8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int InitMissionListByMissionPeriodType(IntPtr l)
	{
		int result;
		try
		{
			MissionComponentCommon missionComponentCommon = (MissionComponentCommon)LuaObject.checkSelf(l);
			MissionPeriodType missionPeriod;
			LuaObject.checkEnum<MissionPeriodType>(l, 2, out missionPeriod);
			missionComponentCommon.m_luaExportHelper.InitMissionListByMissionPeriodType(missionPeriod);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06018651 RID: 99921 RVA: 0x006D5D34 File Offset: 0x006D3F34
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int CanUnlockMissionInLogicFromInit(IntPtr l)
	{
		int result;
		try
		{
			MissionComponentCommon missionComponentCommon = (MissionComponentCommon)LuaObject.checkSelf(l);
			ConfigDataMissionInfo missionInfo;
			LuaObject.checkType<ConfigDataMissionInfo>(l, 2, out missionInfo);
			bool b = missionComponentCommon.m_luaExportHelper.CanUnlockMissionInLogicFromInit(missionInfo);
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

	// Token: 0x06018652 RID: 99922 RVA: 0x006D5D9C File Offset: 0x006D3F9C
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int OnDirectActivatedMissionLocked(IntPtr l)
	{
		int result;
		try
		{
			MissionComponentCommon missionComponentCommon = (MissionComponentCommon)LuaObject.checkSelf(l);
			ConfigDataMissionInfo missionConfig;
			LuaObject.checkType<ConfigDataMissionInfo>(l, 2, out missionConfig);
			missionComponentCommon.m_luaExportHelper.OnDirectActivatedMissionLocked(missionConfig);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06018653 RID: 99923 RVA: 0x006D5DF8 File Offset: 0x006D3FF8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int IsNoviceMission(IntPtr l)
	{
		int result;
		try
		{
			int total = LuaDLL.lua_gettop(l);
			if (LuaObject.matchType(l, total, 2, typeof(Mission)))
			{
				MissionComponentCommon missionComponentCommon = (MissionComponentCommon)LuaObject.checkSelf(l);
				Mission mission;
				LuaObject.checkType<Mission>(l, 2, out mission);
				bool b = missionComponentCommon.m_luaExportHelper.IsNoviceMission(mission);
				LuaObject.pushValue(l, true);
				LuaObject.pushValue(l, b);
				result = 2;
			}
			else if (LuaObject.matchType(l, total, 2, typeof(ConfigDataMissionInfo)))
			{
				MissionComponentCommon missionComponentCommon2 = (MissionComponentCommon)LuaObject.checkSelf(l);
				ConfigDataMissionInfo mission2;
				LuaObject.checkType<ConfigDataMissionInfo>(l, 2, out mission2);
				bool b2 = missionComponentCommon2.m_luaExportHelper.IsNoviceMission(mission2);
				LuaObject.pushValue(l, true);
				LuaObject.pushValue(l, b2);
				result = 2;
			}
			else
			{
				LuaObject.pushValue(l, false);
				LuaDLL.lua_pushstring(l, "No matched override function IsNoviceMission to call");
				result = 2;
			}
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06018654 RID: 99924 RVA: 0x006D5EF0 File Offset: 0x006D40F0
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int IsNoviceMissionActivated(IntPtr l)
	{
		int result;
		try
		{
			int total = LuaDLL.lua_gettop(l);
			if (LuaObject.matchType(l, total, 2, typeof(ConfigDataMissionInfo)))
			{
				MissionComponentCommon missionComponentCommon = (MissionComponentCommon)LuaObject.checkSelf(l);
				ConfigDataMissionInfo mission;
				LuaObject.checkType<ConfigDataMissionInfo>(l, 2, out mission);
				bool b = missionComponentCommon.m_luaExportHelper.IsNoviceMissionActivated(mission);
				LuaObject.pushValue(l, true);
				LuaObject.pushValue(l, b);
				result = 2;
			}
			else if (LuaObject.matchType(l, total, 2, typeof(Mission)))
			{
				MissionComponentCommon missionComponentCommon2 = (MissionComponentCommon)LuaObject.checkSelf(l);
				Mission mission2;
				LuaObject.checkType<Mission>(l, 2, out mission2);
				bool b2 = missionComponentCommon2.m_luaExportHelper.IsNoviceMissionActivated(mission2);
				LuaObject.pushValue(l, true);
				LuaObject.pushValue(l, b2);
				result = 2;
			}
			else
			{
				LuaObject.pushValue(l, false);
				LuaDLL.lua_pushstring(l, "No matched override function IsNoviceMissionActivated to call");
				result = 2;
			}
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06018655 RID: 99925 RVA: 0x006D5FE8 File Offset: 0x006D41E8
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int IsNoviceMissionActivatedForRewarding(IntPtr l)
	{
		int result;
		try
		{
			MissionComponentCommon missionComponentCommon = (MissionComponentCommon)LuaObject.checkSelf(l);
			ConfigDataMissionInfo mission;
			LuaObject.checkType<ConfigDataMissionInfo>(l, 2, out mission);
			bool b = missionComponentCommon.m_luaExportHelper.IsNoviceMissionActivatedForRewarding(mission);
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

	// Token: 0x06018656 RID: 99926 RVA: 0x006D6050 File Offset: 0x006D4250
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int CanUnlockMissionInLogic(IntPtr l)
	{
		int result;
		try
		{
			MissionComponentCommon missionComponentCommon = (MissionComponentCommon)LuaObject.checkSelf(l);
			ConfigDataMissionInfo missionConfigInfo;
			LuaObject.checkType<ConfigDataMissionInfo>(l, 2, out missionConfigInfo);
			bool b = missionComponentCommon.m_luaExportHelper.CanUnlockMissionInLogic(missionConfigInfo);
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

	// Token: 0x06018657 RID: 99927 RVA: 0x006D60B8 File Offset: 0x006D42B8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int CanUnlockMission(IntPtr l)
	{
		int result;
		try
		{
			MissionComponentCommon missionComponentCommon = (MissionComponentCommon)LuaObject.checkSelf(l);
			ConfigDataMissionInfo missionConfigInfo;
			LuaObject.checkType<ConfigDataMissionInfo>(l, 2, out missionConfigInfo);
			bool b = missionComponentCommon.m_luaExportHelper.CanUnlockMission(missionConfigInfo);
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

	// Token: 0x06018658 RID: 99928 RVA: 0x006D6120 File Offset: 0x006D4320
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int CaculateDirectlyActivationMissionStatus(IntPtr l)
	{
		int result;
		try
		{
			MissionComponentCommon missionComponentCommon = (MissionComponentCommon)LuaObject.checkSelf(l);
			ConfigDataMissionInfo missionConfigInfo;
			LuaObject.checkType<ConfigDataMissionInfo>(l, 2, out missionConfigInfo);
			DirectlyActivatedMissionSatatus e = missionComponentCommon.m_luaExportHelper.CaculateDirectlyActivationMissionStatus(missionConfigInfo);
			LuaObject.pushValue(l, true);
			LuaObject.pushEnum(l, (int)e);
			result = 2;
		}
		catch (Exception e2)
		{
			result = LuaObject.error(l, e2);
		}
		return result;
	}

	// Token: 0x06018659 RID: 99929 RVA: 0x006D6188 File Offset: 0x006D4388
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int AddMission(IntPtr l)
	{
		int result;
		try
		{
			MissionComponentCommon missionComponentCommon = (MissionComponentCommon)LuaObject.checkSelf(l);
			ConfigDataMissionInfo missionInfo;
			LuaObject.checkType<ConfigDataMissionInfo>(l, 2, out missionInfo);
			bool b = missionComponentCommon.m_luaExportHelper.AddMission(missionInfo);
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

	// Token: 0x0601865A RID: 99930 RVA: 0x006D61F0 File Offset: 0x006D43F0
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int OnAddProcessingDirectelyActivitedMission(IntPtr l)
	{
		int result;
		try
		{
			MissionComponentCommon missionComponentCommon = (MissionComponentCommon)LuaObject.checkSelf(l);
			Mission mission;
			LuaObject.checkType<Mission>(l, 2, out mission);
			missionComponentCommon.m_luaExportHelper.OnAddProcessingDirectelyActivitedMission(mission);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601865B RID: 99931 RVA: 0x006D624C File Offset: 0x006D444C
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int GetProcessingMissionByMissionPeriod(IntPtr l)
	{
		int result;
		try
		{
			MissionComponentCommon missionComponentCommon = (MissionComponentCommon)LuaObject.checkSelf(l);
			MissionPeriodType missionPeriodType;
			LuaObject.checkEnum<MissionPeriodType>(l, 2, out missionPeriodType);
			int missionId;
			LuaObject.checkType(l, 3, out missionId);
			Mission processingMissionByMissionPeriod = missionComponentCommon.m_luaExportHelper.GetProcessingMissionByMissionPeriod(missionPeriodType, missionId);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, processingMissionByMissionPeriod);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601865C RID: 99932 RVA: 0x006D62C0 File Offset: 0x006D44C0
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int OnGetProcessingDirectActivationMissionFail(IntPtr l)
	{
		int result;
		try
		{
			MissionComponentCommon missionComponentCommon = (MissionComponentCommon)LuaObject.checkSelf(l);
			Mission mission;
			LuaObject.checkType<Mission>(l, 2, out mission);
			missionComponentCommon.m_luaExportHelper.OnGetProcessingDirectActivationMissionFail(mission);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601865D RID: 99933 RVA: 0x006D631C File Offset: 0x006D451C
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int AddEverydayMission(IntPtr l)
	{
		int result;
		try
		{
			MissionComponentCommon missionComponentCommon = (MissionComponentCommon)LuaObject.checkSelf(l);
			Mission mission;
			LuaObject.checkType<Mission>(l, 2, out mission);
			missionComponentCommon.m_luaExportHelper.AddEverydayMission(mission);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601865E RID: 99934 RVA: 0x006D6378 File Offset: 0x006D4578
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int AddOneOffMission(IntPtr l)
	{
		int result;
		try
		{
			MissionComponentCommon missionComponentCommon = (MissionComponentCommon)LuaObject.checkSelf(l);
			Mission mission;
			LuaObject.checkType<Mission>(l, 2, out mission);
			missionComponentCommon.m_luaExportHelper.AddOneOffMission(mission);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601865F RID: 99935 RVA: 0x006D63D4 File Offset: 0x006D45D4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int IsMissionExist(IntPtr l)
	{
		int result;
		try
		{
			MissionComponentCommon missionComponentCommon = (MissionComponentCommon)LuaObject.checkSelf(l);
			int missionId;
			LuaObject.checkType(l, 2, out missionId);
			bool b = missionComponentCommon.m_luaExportHelper.IsMissionExist(missionId);
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

	// Token: 0x06018660 RID: 99936 RVA: 0x006D643C File Offset: 0x006D463C
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int InitMissionsFromConfig(IntPtr l)
	{
		int result;
		try
		{
			MissionComponentCommon missionComponentCommon = (MissionComponentCommon)LuaObject.checkSelf(l);
			List<Mission> missions;
			LuaObject.checkType<List<Mission>>(l, 2, out missions);
			missionComponentCommon.m_luaExportHelper.InitMissionsFromConfig(missions);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06018661 RID: 99937 RVA: 0x006D6498 File Offset: 0x006D4698
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int FinishMission(IntPtr l)
	{
		int result;
		try
		{
			MissionComponentCommon missionComponentCommon = (MissionComponentCommon)LuaObject.checkSelf(l);
			Mission mission;
			LuaObject.checkType<Mission>(l, 2, out mission);
			missionComponentCommon.m_luaExportHelper.FinishMission(mission);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06018662 RID: 99938 RVA: 0x006D64F4 File Offset: 0x006D46F4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int GetAllEverydayMissionConfigByPreMissionId(IntPtr l)
	{
		int result;
		try
		{
			MissionComponentCommon missionComponentCommon = (MissionComponentCommon)LuaObject.checkSelf(l);
			int missionId;
			LuaObject.checkType(l, 2, out missionId);
			List<ConfigDataMissionInfo> allEverydayMissionConfigByPreMissionId = missionComponentCommon.m_luaExportHelper.GetAllEverydayMissionConfigByPreMissionId(missionId);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, allEverydayMissionConfigByPreMissionId);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06018663 RID: 99939 RVA: 0x006D655C File Offset: 0x006D475C
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int GetAllEverydayMissionListByPlayerLevel(IntPtr l)
	{
		int result;
		try
		{
			MissionComponentCommon missionComponentCommon = (MissionComponentCommon)LuaObject.checkSelf(l);
			int playerLvl;
			LuaObject.checkType(l, 2, out playerLvl);
			List<ConfigDataMissionInfo> allEverydayMissionListByPlayerLevel = missionComponentCommon.m_luaExportHelper.GetAllEverydayMissionListByPlayerLevel(playerLvl);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, allEverydayMissionListByPlayerLevel);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06018664 RID: 99940 RVA: 0x006D65C4 File Offset: 0x006D47C4
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int GetAllEverydayMissionListByScenario(IntPtr l)
	{
		int result;
		try
		{
			MissionComponentCommon missionComponentCommon = (MissionComponentCommon)LuaObject.checkSelf(l);
			int scenario;
			LuaObject.checkType(l, 2, out scenario);
			List<ConfigDataMissionInfo> allEverydayMissionListByScenario = missionComponentCommon.m_luaExportHelper.GetAllEverydayMissionListByScenario(scenario);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, allEverydayMissionListByScenario);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06018665 RID: 99941 RVA: 0x006D662C File Offset: 0x006D482C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int UpdateMissionListByMissionComplete(IntPtr l)
	{
		int result;
		try
		{
			MissionComponentCommon missionComponentCommon = (MissionComponentCommon)LuaObject.checkSelf(l);
			int missionId;
			LuaObject.checkType(l, 2, out missionId);
			missionComponentCommon.m_luaExportHelper.UpdateMissionListByMissionComplete(missionId);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06018666 RID: 99942 RVA: 0x006D6688 File Offset: 0x006D4888
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int UpdateMissionListByLevelUp(IntPtr l)
	{
		int result;
		try
		{
			MissionComponentCommon missionComponentCommon = (MissionComponentCommon)LuaObject.checkSelf(l);
			int playerLevel;
			LuaObject.checkType(l, 2, out playerLevel);
			missionComponentCommon.m_luaExportHelper.UpdateMissionListByLevelUp(playerLevel);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06018667 RID: 99943 RVA: 0x006D66E4 File Offset: 0x006D48E4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int UpdateMissionListByScenario(IntPtr l)
	{
		int result;
		try
		{
			MissionComponentCommon missionComponentCommon = (MissionComponentCommon)LuaObject.checkSelf(l);
			int scenarioId;
			LuaObject.checkType(l, 2, out scenarioId);
			missionComponentCommon.m_luaExportHelper.UpdateMissionListByScenario(scenarioId);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06018668 RID: 99944 RVA: 0x006D6740 File Offset: 0x006D4940
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int UpdateMissionListByNewMissionConfigList(IntPtr l)
	{
		int result;
		try
		{
			MissionComponentCommon missionComponentCommon = (MissionComponentCommon)LuaObject.checkSelf(l);
			List<ConfigDataMissionInfo> newMissionConfigList;
			LuaObject.checkType<List<ConfigDataMissionInfo>>(l, 2, out newMissionConfigList);
			missionComponentCommon.m_luaExportHelper.UpdateMissionListByNewMissionConfigList(newMissionConfigList);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06018669 RID: 99945 RVA: 0x006D679C File Offset: 0x006D499C
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int AddMissionProcess(IntPtr l)
	{
		int result;
		try
		{
			MissionComponentCommon missionComponentCommon = (MissionComponentCommon)LuaObject.checkSelf(l);
			Mission mission;
			LuaObject.checkType<Mission>(l, 2, out mission);
			long process;
			LuaObject.checkType(l, 3, out process);
			missionComponentCommon.m_luaExportHelper.AddMissionProcess(mission, process);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601866A RID: 99946 RVA: 0x006D6808 File Offset: 0x006D4A08
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int RegisterMissionCallBack(IntPtr l)
	{
		int result;
		try
		{
			MissionComponentCommon missionComponentCommon = (MissionComponentCommon)LuaObject.checkSelf(l);
			missionComponentCommon.m_luaExportHelper.RegisterMissionCallBack();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601866B RID: 99947 RVA: 0x006D685C File Offset: 0x006D4A5C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int IsCompleted(IntPtr l)
	{
		int result;
		try
		{
			MissionComponentCommon missionComponentCommon = (MissionComponentCommon)LuaObject.checkSelf(l);
			int missionId;
			LuaObject.checkType(l, 2, out missionId);
			bool b = missionComponentCommon.m_luaExportHelper.IsCompleted(missionId);
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

	// Token: 0x0601866C RID: 99948 RVA: 0x006D68C4 File Offset: 0x006D4AC4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int OnSelectCardMissionCallBack(IntPtr l)
	{
		int result;
		try
		{
			MissionComponentCommon missionComponentCommon = (MissionComponentCommon)LuaObject.checkSelf(l);
			int cardPoolId;
			LuaObject.checkType(l, 2, out cardPoolId);
			int selectCount;
			LuaObject.checkType(l, 3, out selectCount);
			missionComponentCommon.m_luaExportHelper.OnSelectCardMissionCallBack(cardPoolId, selectCount);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601866D RID: 99949 RVA: 0x006D6930 File Offset: 0x006D4B30
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int OnMissionSelectCardCallBack(IntPtr l)
	{
		int result;
		try
		{
			MissionComponentCommon missionComponentCommon = (MissionComponentCommon)LuaObject.checkSelf(l);
			int cardPoolId;
			LuaObject.checkType(l, 2, out cardPoolId);
			int selectCount;
			LuaObject.checkType(l, 3, out selectCount);
			missionComponentCommon.m_luaExportHelper.OnMissionSelectCardCallBack(cardPoolId, selectCount);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601866E RID: 99950 RVA: 0x006D699C File Offset: 0x006D4B9C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int SetStatisticalData(IntPtr l)
	{
		int result;
		try
		{
			MissionComponentCommon missionComponentCommon = (MissionComponentCommon)LuaObject.checkSelf(l);
			StatisticalDataType typeId;
			LuaObject.checkEnum<StatisticalDataType>(l, 2, out typeId);
			long nums;
			LuaObject.checkType(l, 3, out nums);
			missionComponentCommon.m_luaExportHelper.SetStatisticalData(typeId, nums);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601866F RID: 99951 RVA: 0x006D6A08 File Offset: 0x006D4C08
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int AddStatisticalData(IntPtr l)
	{
		int result;
		try
		{
			MissionComponentCommon missionComponentCommon = (MissionComponentCommon)LuaObject.checkSelf(l);
			StatisticalDataType typeId;
			LuaObject.checkEnum<StatisticalDataType>(l, 2, out typeId);
			int nums;
			LuaObject.checkType(l, 3, out nums);
			missionComponentCommon.m_luaExportHelper.AddStatisticalData(typeId, nums);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06018670 RID: 99952 RVA: 0x006D6A74 File Offset: 0x006D4C74
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int OnSummonHeroCallBack(IntPtr l)
	{
		int result;
		try
		{
			MissionComponentCommon missionComponentCommon = (MissionComponentCommon)LuaObject.checkSelf(l);
			int heroId;
			LuaObject.checkType(l, 2, out heroId);
			missionComponentCommon.m_luaExportHelper.OnSummonHeroCallBack(heroId);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06018671 RID: 99953 RVA: 0x006D6AD0 File Offset: 0x006D4CD0
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int OnConsumeEnergyCallBack(IntPtr l)
	{
		int result;
		try
		{
			MissionComponentCommon missionComponentCommon = (MissionComponentCommon)LuaObject.checkSelf(l);
			int energyCost;
			LuaObject.checkType(l, 2, out energyCost);
			missionComponentCommon.m_luaExportHelper.OnConsumeEnergyCallBack(energyCost);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06018672 RID: 99954 RVA: 0x006D6B2C File Offset: 0x006D4D2C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int OnCompleteEventCallBack(IntPtr l)
	{
		int result;
		try
		{
			MissionComponentCommon missionComponentCommon = (MissionComponentCommon)LuaObject.checkSelf(l);
			bool isRandomEvent;
			LuaObject.checkType(l, 2, out isRandomEvent);
			missionComponentCommon.m_luaExportHelper.OnCompleteEventCallBack(isRandomEvent);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06018673 RID: 99955 RVA: 0x006D6B88 File Offset: 0x006D4D88
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int OnCompleteLevelCallBack(IntPtr l)
	{
		int result;
		try
		{
			MissionComponentCommon missionComponentCommon = (MissionComponentCommon)LuaObject.checkSelf(l);
			BattleType levelType;
			LuaObject.checkEnum<BattleType>(l, 2, out levelType);
			int levelId;
			LuaObject.checkType(l, 3, out levelId);
			List<int> fightHeroes;
			LuaObject.checkType<List<int>>(l, 4, out fightHeroes);
			missionComponentCommon.m_luaExportHelper.OnCompleteLevelCallBack(levelType, levelId, fightHeroes);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06018674 RID: 99956 RVA: 0x006D6C00 File Offset: 0x006D4E00
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int RiftLevelAttackDiffculityCallBack(IntPtr l)
	{
		int result;
		try
		{
			MissionComponentCommon missionComponentCommon = (MissionComponentCommon)LuaObject.checkSelf(l);
			int levelId;
			LuaObject.checkType(l, 2, out levelId);
			missionComponentCommon.m_luaExportHelper.RiftLevelAttackDiffculityCallBack(levelId);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06018675 RID: 99957 RVA: 0x006D6C5C File Offset: 0x006D4E5C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int AddBattleTypeLevelStatisticalData(IntPtr l)
	{
		int result;
		try
		{
			MissionComponentCommon missionComponentCommon = (MissionComponentCommon)LuaObject.checkSelf(l);
			BattleType levelType;
			LuaObject.checkEnum<BattleType>(l, 2, out levelType);
			missionComponentCommon.m_luaExportHelper.AddBattleTypeLevelStatisticalData(levelType);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06018676 RID: 99958 RVA: 0x006D6CB8 File Offset: 0x006D4EB8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int OnArenaConsecutiveVictoryCallBack(IntPtr l)
	{
		int result;
		try
		{
			MissionComponentCommon missionComponentCommon = (MissionComponentCommon)LuaObject.checkSelf(l);
			int consecutiveVictoryNums;
			LuaObject.checkType(l, 2, out consecutiveVictoryNums);
			missionComponentCommon.m_luaExportHelper.OnArenaConsecutiveVictoryCallBack(consecutiveVictoryNums);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06018677 RID: 99959 RVA: 0x006D6D14 File Offset: 0x006D4F14
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int OnArenaFightCallBack(IntPtr l)
	{
		int result;
		try
		{
			MissionComponentCommon missionComponentCommon = (MissionComponentCommon)LuaObject.checkSelf(l);
			missionComponentCommon.m_luaExportHelper.OnArenaFightCallBack();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06018678 RID: 99960 RVA: 0x006D6D68 File Offset: 0x006D4F68
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int OnCompleteScenaioCallBack(IntPtr l)
	{
		int result;
		try
		{
			MissionComponentCommon missionComponentCommon = (MissionComponentCommon)LuaObject.checkSelf(l);
			int scenarioId;
			LuaObject.checkType(l, 2, out scenarioId);
			missionComponentCommon.m_luaExportHelper.OnCompleteScenaioCallBack(scenarioId);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06018679 RID: 99961 RVA: 0x006D6DC4 File Offset: 0x006D4FC4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int OnCompleteRiftLevelCallBack(IntPtr l)
	{
		int result;
		try
		{
			MissionComponentCommon missionComponentCommon = (MissionComponentCommon)LuaObject.checkSelf(l);
			int diffculty;
			LuaObject.checkType(l, 2, out diffculty);
			missionComponentCommon.m_luaExportHelper.OnCompleteRiftLevelCallBack(diffculty);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601867A RID: 99962 RVA: 0x006D6E20 File Offset: 0x006D5020
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int OnGetRiftLevelFightAchievementCallBack(IntPtr l)
	{
		int result;
		try
		{
			MissionComponentCommon missionComponentCommon = (MissionComponentCommon)LuaObject.checkSelf(l);
			int achievementRelatedId;
			LuaObject.checkType(l, 2, out achievementRelatedId);
			missionComponentCommon.m_luaExportHelper.OnGetRiftLevelFightAchievementCallBack(achievementRelatedId);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601867B RID: 99963 RVA: 0x006D6E7C File Offset: 0x006D507C
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int OnFinishFightAchievementCallBack(IntPtr l)
	{
		int result;
		try
		{
			MissionComponentCommon missionComponentCommon = (MissionComponentCommon)LuaObject.checkSelf(l);
			int achievementRelatedId;
			LuaObject.checkType(l, 2, out achievementRelatedId);
			missionComponentCommon.m_luaExportHelper.OnFinishFightAchievementCallBack(achievementRelatedId);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601867C RID: 99964 RVA: 0x006D6ED8 File Offset: 0x006D50D8
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int OnGetRiftLevelStarCallBack(IntPtr l)
	{
		int result;
		try
		{
			MissionComponentCommon missionComponentCommon = (MissionComponentCommon)LuaObject.checkSelf(l);
			int starCount;
			LuaObject.checkType(l, 2, out starCount);
			missionComponentCommon.m_luaExportHelper.OnGetRiftLevelStarCallBack(starCount);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601867D RID: 99965 RVA: 0x006D6F34 File Offset: 0x006D5134
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int OnConsumeCrystalCallBack(IntPtr l)
	{
		int result;
		try
		{
			MissionComponentCommon missionComponentCommon = (MissionComponentCommon)LuaObject.checkSelf(l);
			int crystalCount;
			LuaObject.checkType(l, 2, out crystalCount);
			missionComponentCommon.m_luaExportHelper.OnConsumeCrystalCallBack(crystalCount);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601867E RID: 99966 RVA: 0x006D6F90 File Offset: 0x006D5190
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int OnComsumeGoldCallBack(IntPtr l)
	{
		int result;
		try
		{
			MissionComponentCommon missionComponentCommon = (MissionComponentCommon)LuaObject.checkSelf(l);
			int goldCount;
			LuaObject.checkType(l, 2, out goldCount);
			missionComponentCommon.m_luaExportHelper.OnComsumeGoldCallBack(goldCount);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601867F RID: 99967 RVA: 0x006D6FEC File Offset: 0x006D51EC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int OnUseHeroExpItemCallBack(IntPtr l)
	{
		int result;
		try
		{
			MissionComponentCommon missionComponentCommon = (MissionComponentCommon)LuaObject.checkSelf(l);
			int itemCount;
			LuaObject.checkType(l, 2, out itemCount);
			missionComponentCommon.m_luaExportHelper.OnUseHeroExpItemCallBack(itemCount);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06018680 RID: 99968 RVA: 0x006D7048 File Offset: 0x006D5248
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int OnAllHeroAllJobLevelUpCallBack(IntPtr l)
	{
		int result;
		try
		{
			MissionComponentCommon missionComponentCommon = (MissionComponentCommon)LuaObject.checkSelf(l);
			missionComponentCommon.m_luaExportHelper.OnAllHeroAllJobLevelUpCallBack();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06018681 RID: 99969 RVA: 0x006D709C File Offset: 0x006D529C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int OnAllHeroAddJobNums(IntPtr l)
	{
		int result;
		try
		{
			MissionComponentCommon missionComponentCommon = (MissionComponentCommon)LuaObject.checkSelf(l);
			missionComponentCommon.m_luaExportHelper.OnAllHeroAddJobNums();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06018682 RID: 99970 RVA: 0x006D70F0 File Offset: 0x006D52F0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int OnRankJobHaveCallBack(IntPtr l)
	{
		int result;
		try
		{
			MissionComponentCommon missionComponentCommon = (MissionComponentCommon)LuaObject.checkSelf(l);
			missionComponentCommon.m_luaExportHelper.OnRankJobHaveCallBack();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06018683 RID: 99971 RVA: 0x006D7144 File Offset: 0x006D5344
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int OnAllHeroAddSkillNumsCallBack(IntPtr l)
	{
		int result;
		try
		{
			MissionComponentCommon missionComponentCommon = (MissionComponentCommon)LuaObject.checkSelf(l);
			int skillId;
			LuaObject.checkType(l, 2, out skillId);
			missionComponentCommon.m_luaExportHelper.OnAllHeroAddSkillNumsCallBack(skillId);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06018684 RID: 99972 RVA: 0x006D71A0 File Offset: 0x006D53A0
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int OnAllHeroAddSoliderNumsCallBack(IntPtr l)
	{
		int result;
		try
		{
			MissionComponentCommon missionComponentCommon = (MissionComponentCommon)LuaObject.checkSelf(l);
			int soliderId;
			LuaObject.checkType(l, 2, out soliderId);
			missionComponentCommon.m_luaExportHelper.OnAllHeroAddSoliderNumsCallBack(soliderId);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06018685 RID: 99973 RVA: 0x006D71FC File Offset: 0x006D53FC
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int OnAllJobMasterHeroCallBack(IntPtr l)
	{
		int result;
		try
		{
			MissionComponentCommon missionComponentCommon = (MissionComponentCommon)LuaObject.checkSelf(l);
			int heroId;
			LuaObject.checkType(l, 2, out heroId);
			missionComponentCommon.m_luaExportHelper.OnAllJobMasterHeroCallBack(heroId);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06018686 RID: 99974 RVA: 0x006D7258 File Offset: 0x006D5458
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int OnHeroMasterJobCallBack(IntPtr l)
	{
		int result;
		try
		{
			MissionComponentCommon missionComponentCommon = (MissionComponentCommon)LuaObject.checkSelf(l);
			int heroId;
			LuaObject.checkType(l, 2, out heroId);
			int jobRelateId;
			LuaObject.checkType(l, 3, out jobRelateId);
			missionComponentCommon.m_luaExportHelper.OnHeroMasterJobCallBack(heroId, jobRelateId);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06018687 RID: 99975 RVA: 0x006D72C4 File Offset: 0x006D54C4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int OnLevelUpHeroStarLevelCallBack(IntPtr l)
	{
		int result;
		try
		{
			MissionComponentCommon missionComponentCommon = (MissionComponentCommon)LuaObject.checkSelf(l);
			int heroId;
			LuaObject.checkType(l, 2, out heroId);
			missionComponentCommon.m_luaExportHelper.OnLevelUpHeroStarLevelCallBack(heroId);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06018688 RID: 99976 RVA: 0x006D7320 File Offset: 0x006D5520
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int UpdateHeroRankLevelCallBack(IntPtr l)
	{
		int result;
		try
		{
			MissionComponentCommon missionComponentCommon = (MissionComponentCommon)LuaObject.checkSelf(l);
			int heroRank;
			LuaObject.checkType(l, 2, out heroRank);
			missionComponentCommon.m_luaExportHelper.UpdateHeroRankLevelCallBack(heroRank);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06018689 RID: 99977 RVA: 0x006D737C File Offset: 0x006D557C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int OnAddHeroNumsCallBack(IntPtr l)
	{
		int result;
		try
		{
			MissionComponentCommon missionComponentCommon = (MissionComponentCommon)LuaObject.checkSelf(l);
			int heroId;
			LuaObject.checkType(l, 2, out heroId);
			missionComponentCommon.m_luaExportHelper.OnAddHeroNumsCallBack(heroId);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601868A RID: 99978 RVA: 0x006D73D8 File Offset: 0x006D55D8
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int OnHasAboveLevelHeroNumsCallBack(IntPtr l)
	{
		int result;
		try
		{
			MissionComponentCommon missionComponentCommon = (MissionComponentCommon)LuaObject.checkSelf(l);
			missionComponentCommon.m_luaExportHelper.OnHasAboveLevelHeroNumsCallBack();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601868B RID: 99979 RVA: 0x006D742C File Offset: 0x006D562C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int OnLevelUpPlayerLevelCallBack(IntPtr l)
	{
		int result;
		try
		{
			MissionComponentCommon missionComponentCommon = (MissionComponentCommon)LuaObject.checkSelf(l);
			int upLevel;
			LuaObject.checkType(l, 2, out upLevel);
			missionComponentCommon.m_luaExportHelper.OnLevelUpPlayerLevelCallBack(upLevel);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601868C RID: 99980 RVA: 0x006D7488 File Offset: 0x006D5688
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int OnUseCrystalBuyEnergyCallBack(IntPtr l)
	{
		int result;
		try
		{
			MissionComponentCommon missionComponentCommon = (MissionComponentCommon)LuaObject.checkSelf(l);
			int buyCount;
			LuaObject.checkType(l, 2, out buyCount);
			missionComponentCommon.m_luaExportHelper.OnUseCrystalBuyEnergyCallBack(buyCount);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601868D RID: 99981 RVA: 0x006D74E4 File Offset: 0x006D56E4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int OnLoginGameCallBack(IntPtr l)
	{
		int result;
		try
		{
			MissionComponentCommon missionComponentCommon = (MissionComponentCommon)LuaObject.checkSelf(l);
			missionComponentCommon.m_luaExportHelper.OnLoginGameCallBack();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601868E RID: 99982 RVA: 0x006D7538 File Offset: 0x006D5738
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int OnNewHeroJobTransferCallBack(IntPtr l)
	{
		int result;
		try
		{
			MissionComponentCommon missionComponentCommon = (MissionComponentCommon)LuaObject.checkSelf(l);
			int heroId;
			LuaObject.checkType(l, 2, out heroId);
			int jobConnnectionId;
			LuaObject.checkType(l, 3, out jobConnnectionId);
			missionComponentCommon.m_luaExportHelper.OnNewHeroJobTransferCallBack(heroId, jobConnnectionId);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601868F RID: 99983 RVA: 0x006D75A4 File Offset: 0x006D57A4
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int OnSpecificHeroFight(IntPtr l)
	{
		int result;
		try
		{
			MissionComponentCommon missionComponentCommon = (MissionComponentCommon)LuaObject.checkSelf(l);
			int heroId;
			LuaObject.checkType(l, 2, out heroId);
			int fightNums;
			LuaObject.checkType(l, 3, out fightNums);
			missionComponentCommon.m_luaExportHelper.OnSpecificHeroFight(heroId, fightNums);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06018690 RID: 99984 RVA: 0x006D7610 File Offset: 0x006D5810
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int OnSpecificHeroLevelUp(IntPtr l)
	{
		int result;
		try
		{
			MissionComponentCommon missionComponentCommon = (MissionComponentCommon)LuaObject.checkSelf(l);
			int heroId;
			LuaObject.checkType(l, 2, out heroId);
			missionComponentCommon.m_luaExportHelper.OnSpecificHeroLevelUp(heroId);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06018691 RID: 99985 RVA: 0x006D766C File Offset: 0x006D586C
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int OnTrainingTechToLevelCallBack(IntPtr l)
	{
		int result;
		try
		{
			MissionComponentCommon missionComponentCommon = (MissionComponentCommon)LuaObject.checkSelf(l);
			TrainingTech tech;
			LuaObject.checkType<TrainingTech>(l, 2, out tech);
			missionComponentCommon.m_luaExportHelper.OnTrainingTechToLevelCallBack(tech);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06018692 RID: 99986 RVA: 0x006D76C8 File Offset: 0x006D58C8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int OnEquipmentToLevelCallBack(IntPtr l)
	{
		int result;
		try
		{
			MissionComponentCommon missionComponentCommon = (MissionComponentCommon)LuaObject.checkSelf(l);
			EquipmentBagItem equipment;
			LuaObject.checkType<EquipmentBagItem>(l, 2, out equipment);
			missionComponentCommon.m_luaExportHelper.OnEquipmentToLevelCallBack(equipment);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06018693 RID: 99987 RVA: 0x006D7724 File Offset: 0x006D5924
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int OnFinishTeamBattleCallBack(IntPtr l)
	{
		int result;
		try
		{
			MissionComponentCommon missionComponentCommon = (MissionComponentCommon)LuaObject.checkSelf(l);
			missionComponentCommon.m_luaExportHelper.OnFinishTeamBattleCallBack();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06018694 RID: 99988 RVA: 0x006D7778 File Offset: 0x006D5978
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int OnFavorabilityToLevelCallBack(IntPtr l)
	{
		int result;
		try
		{
			MissionComponentCommon missionComponentCommon = (MissionComponentCommon)LuaObject.checkSelf(l);
			Hero hero;
			LuaObject.checkType<Hero>(l, 2, out hero);
			missionComponentCommon.m_luaExportHelper.OnFavorabilityToLevelCallBack(hero);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06018695 RID: 99989 RVA: 0x006D77D4 File Offset: 0x006D59D4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int OnFetterToLevelCallBack(IntPtr l)
	{
		int result;
		try
		{
			MissionComponentCommon missionComponentCommon = (MissionComponentCommon)LuaObject.checkSelf(l);
			Hero hero;
			LuaObject.checkType<Hero>(l, 2, out hero);
			int fetterId;
			LuaObject.checkType(l, 3, out fetterId);
			missionComponentCommon.m_luaExportHelper.OnFetterToLevelCallBack(hero, fetterId);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06018696 RID: 99990 RVA: 0x006D7840 File Offset: 0x006D5A40
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int OnEnchantPropertiesSaveCallBack(IntPtr l)
	{
		int result;
		try
		{
			MissionComponentCommon missionComponentCommon = (MissionComponentCommon)LuaObject.checkSelf(l);
			EquipmentBagItem equipment;
			LuaObject.checkType<EquipmentBagItem>(l, 2, out equipment);
			missionComponentCommon.m_luaExportHelper.OnEnchantPropertiesSaveCallBack(equipment);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06018697 RID: 99991 RVA: 0x006D789C File Offset: 0x006D5A9C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int OnEnchantEquipmentCallBack(IntPtr l)
	{
		int result;
		try
		{
			MissionComponentCommon missionComponentCommon = (MissionComponentCommon)LuaObject.checkSelf(l);
			EquipmentBagItem equipment;
			LuaObject.checkType<EquipmentBagItem>(l, 2, out equipment);
			missionComponentCommon.m_luaExportHelper.OnEnchantEquipmentCallBack(equipment);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06018698 RID: 99992 RVA: 0x006D78F8 File Offset: 0x006D5AF8
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int OnTotalHeroJobLevelUpCallBack(IntPtr l)
	{
		int result;
		try
		{
			MissionComponentCommon missionComponentCommon = (MissionComponentCommon)LuaObject.checkSelf(l);
			missionComponentCommon.m_luaExportHelper.OnTotalHeroJobLevelUpCallBack();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06018699 RID: 99993 RVA: 0x006D794C File Offset: 0x006D5B4C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int OnInviteFriendCallBack(IntPtr l)
	{
		int result;
		try
		{
			MissionComponentCommon missionComponentCommon = (MissionComponentCommon)LuaObject.checkSelf(l);
			missionComponentCommon.m_luaExportHelper.OnInviteFriendCallBack();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601869A RID: 99994 RVA: 0x006D79A0 File Offset: 0x006D5BA0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int OnAssignHeroToTaskCallBack(IntPtr l)
	{
		int result;
		try
		{
			MissionComponentCommon missionComponentCommon = (MissionComponentCommon)LuaObject.checkSelf(l);
			missionComponentCommon.m_luaExportHelper.OnAssignHeroToTaskCallBack();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601869B RID: 99995 RVA: 0x006D79F4 File Offset: 0x006D5BF4
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int OnBattlePracticeCallBack(IntPtr l)
	{
		int result;
		try
		{
			MissionComponentCommon missionComponentCommon = (MissionComponentCommon)LuaObject.checkSelf(l);
			missionComponentCommon.m_luaExportHelper.OnBattlePracticeCallBack();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601869C RID: 99996 RVA: 0x006D7A48 File Offset: 0x006D5C48
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int OnRealTimeArenaBattleStartCallBack(IntPtr l)
	{
		int result;
		try
		{
			MissionComponentCommon missionComponentCommon = (MissionComponentCommon)LuaObject.checkSelf(l);
			BattleMode battleMode;
			LuaObject.checkEnum<BattleMode>(l, 2, out battleMode);
			missionComponentCommon.m_luaExportHelper.OnRealTimeArenaBattleStartCallBack(battleMode);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601869D RID: 99997 RVA: 0x006D7AA4 File Offset: 0x006D5CA4
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int OnRealTimeArenaBattleFinishCallBack(IntPtr l)
	{
		int result;
		try
		{
			MissionComponentCommon missionComponentCommon = (MissionComponentCommon)LuaObject.checkSelf(l);
			BattleMode battleMode;
			LuaObject.checkEnum<BattleMode>(l, 2, out battleMode);
			bool win;
			LuaObject.checkType(l, 3, out win);
			missionComponentCommon.m_luaExportHelper.OnRealTimeArenaBattleFinishCallBack(battleMode, win);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601869E RID: 99998 RVA: 0x006D7B10 File Offset: 0x006D5D10
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int OnRealTimeArenaDanUpdateCallBack(IntPtr l)
	{
		int result;
		try
		{
			MissionComponentCommon missionComponentCommon = (MissionComponentCommon)LuaObject.checkSelf(l);
			int dan;
			LuaObject.checkType(l, 2, out dan);
			missionComponentCommon.m_luaExportHelper.OnRealTimeArenaDanUpdateCallBack(dan);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601869F RID: 99999 RVA: 0x006D7B6C File Offset: 0x006D5D6C
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int OnBuyGiftStoreGoodsCallBack(IntPtr l)
	{
		int result;
		try
		{
			MissionComponentCommon missionComponentCommon = (MissionComponentCommon)LuaObject.checkSelf(l);
			int goodsId;
			LuaObject.checkType(l, 2, out goodsId);
			missionComponentCommon.m_luaExportHelper.OnBuyGiftStoreGoodsCallBack(goodsId);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060186A0 RID: 100000 RVA: 0x006D7BC8 File Offset: 0x006D5DC8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int OnBuyRechargeStoreGoodsCallBack(IntPtr l)
	{
		int result;
		try
		{
			MissionComponentCommon missionComponentCommon = (MissionComponentCommon)LuaObject.checkSelf(l);
			int goodsId;
			LuaObject.checkType(l, 2, out goodsId);
			missionComponentCommon.m_luaExportHelper.OnBuyRechargeStoreGoodsCallBack(goodsId);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060186A1 RID: 100001 RVA: 0x006D7C24 File Offset: 0x006D5E24
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int OnDoShareCallBack(IntPtr l)
	{
		int result;
		try
		{
			MissionComponentCommon missionComponentCommon = (MissionComponentCommon)LuaObject.checkSelf(l);
			missionComponentCommon.m_luaExportHelper.OnDoShareCallBack();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060186A2 RID: 100002 RVA: 0x006D7C78 File Offset: 0x006D5E78
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_lockedMissionConfigsInLogic(IntPtr l)
	{
		int result;
		try
		{
			MissionComponentCommon missionComponentCommon = (MissionComponentCommon)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, missionComponentCommon.m_luaExportHelper.m_lockedMissionConfigsInLogic);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060186A3 RID: 100003 RVA: 0x006D7CD0 File Offset: 0x006D5ED0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_lockedMissionConfigsInLogic(IntPtr l)
	{
		int result;
		try
		{
			MissionComponentCommon missionComponentCommon = (MissionComponentCommon)LuaObject.checkSelf(l);
			HashSet<ConfigDataMissionInfo> lockedMissionConfigsInLogic;
			LuaObject.checkType<HashSet<ConfigDataMissionInfo>>(l, 2, out lockedMissionConfigsInLogic);
			missionComponentCommon.m_luaExportHelper.m_lockedMissionConfigsInLogic = lockedMissionConfigsInLogic;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060186A4 RID: 100004 RVA: 0x006D7D2C File Offset: 0x006D5F2C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_existMissions(IntPtr l)
	{
		int result;
		try
		{
			MissionComponentCommon missionComponentCommon = (MissionComponentCommon)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, missionComponentCommon.m_luaExportHelper.m_existMissions);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060186A5 RID: 100005 RVA: 0x006D7D84 File Offset: 0x006D5F84
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_m_existMissions(IntPtr l)
	{
		int result;
		try
		{
			MissionComponentCommon missionComponentCommon = (MissionComponentCommon)LuaObject.checkSelf(l);
			HashSet<int> existMissions;
			LuaObject.checkType<HashSet<int>>(l, 2, out existMissions);
			missionComponentCommon.m_luaExportHelper.m_existMissions = existMissions;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060186A6 RID: 100006 RVA: 0x006D7DE0 File Offset: 0x006D5FE0
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_m_missionDS(IntPtr l)
	{
		int result;
		try
		{
			MissionComponentCommon missionComponentCommon = (MissionComponentCommon)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, missionComponentCommon.m_luaExportHelper.m_missionDS);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060186A7 RID: 100007 RVA: 0x006D7E38 File Offset: 0x006D6038
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_m_missionDS(IntPtr l)
	{
		int result;
		try
		{
			MissionComponentCommon missionComponentCommon = (MissionComponentCommon)LuaObject.checkSelf(l);
			DataSectionMission missionDS;
			LuaObject.checkType<DataSectionMission>(l, 2, out missionDS);
			missionComponentCommon.m_luaExportHelper.m_missionDS = missionDS;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060186A8 RID: 100008 RVA: 0x006D7E94 File Offset: 0x006D6094
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_m_configDataLoader(IntPtr l)
	{
		int result;
		try
		{
			MissionComponentCommon missionComponentCommon = (MissionComponentCommon)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, missionComponentCommon.m_luaExportHelper.m_configDataLoader);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060186A9 RID: 100009 RVA: 0x006D7EEC File Offset: 0x006D60EC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_configDataLoader(IntPtr l)
	{
		int result;
		try
		{
			MissionComponentCommon missionComponentCommon = (MissionComponentCommon)LuaObject.checkSelf(l);
			IConfigDataLoader configDataLoader;
			LuaObject.checkType<IConfigDataLoader>(l, 2, out configDataLoader);
			missionComponentCommon.m_luaExportHelper.m_configDataLoader = configDataLoader;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060186AA RID: 100010 RVA: 0x006D7F48 File Offset: 0x006D6148
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_basicInfo(IntPtr l)
	{
		int result;
		try
		{
			MissionComponentCommon missionComponentCommon = (MissionComponentCommon)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, missionComponentCommon.m_luaExportHelper.m_basicInfo);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060186AB RID: 100011 RVA: 0x006D7FA0 File Offset: 0x006D61A0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_basicInfo(IntPtr l)
	{
		int result;
		try
		{
			MissionComponentCommon missionComponentCommon = (MissionComponentCommon)LuaObject.checkSelf(l);
			PlayerBasicInfoComponentCommon basicInfo;
			LuaObject.checkType<PlayerBasicInfoComponentCommon>(l, 2, out basicInfo);
			missionComponentCommon.m_luaExportHelper.m_basicInfo = basicInfo;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060186AC RID: 100012 RVA: 0x006D7FFC File Offset: 0x006D61FC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_selectCard(IntPtr l)
	{
		int result;
		try
		{
			MissionComponentCommon missionComponentCommon = (MissionComponentCommon)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, missionComponentCommon.m_luaExportHelper.m_selectCard);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060186AD RID: 100013 RVA: 0x006D8054 File Offset: 0x006D6254
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_m_selectCard(IntPtr l)
	{
		int result;
		try
		{
			MissionComponentCommon missionComponentCommon = (MissionComponentCommon)LuaObject.checkSelf(l);
			SelectCardComponentCommon selectCard;
			LuaObject.checkType<SelectCardComponentCommon>(l, 2, out selectCard);
			missionComponentCommon.m_luaExportHelper.m_selectCard = selectCard;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060186AE RID: 100014 RVA: 0x006D80B0 File Offset: 0x006D62B0
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_m_bag(IntPtr l)
	{
		int result;
		try
		{
			MissionComponentCommon missionComponentCommon = (MissionComponentCommon)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, missionComponentCommon.m_luaExportHelper.m_bag);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060186AF RID: 100015 RVA: 0x006D8108 File Offset: 0x006D6308
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_m_bag(IntPtr l)
	{
		int result;
		try
		{
			MissionComponentCommon missionComponentCommon = (MissionComponentCommon)LuaObject.checkSelf(l);
			BagComponentCommon bag;
			LuaObject.checkType<BagComponentCommon>(l, 2, out bag);
			missionComponentCommon.m_luaExportHelper.m_bag = bag;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060186B0 RID: 100016 RVA: 0x006D8164 File Offset: 0x006D6364
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_level(IntPtr l)
	{
		int result;
		try
		{
			MissionComponentCommon missionComponentCommon = (MissionComponentCommon)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, missionComponentCommon.m_luaExportHelper.m_level);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060186B1 RID: 100017 RVA: 0x006D81BC File Offset: 0x006D63BC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_level(IntPtr l)
	{
		int result;
		try
		{
			MissionComponentCommon missionComponentCommon = (MissionComponentCommon)LuaObject.checkSelf(l);
			LevelComponentCommon level;
			LuaObject.checkType<LevelComponentCommon>(l, 2, out level);
			missionComponentCommon.m_luaExportHelper.m_level = level;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060186B2 RID: 100018 RVA: 0x006D8218 File Offset: 0x006D6418
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_rift(IntPtr l)
	{
		int result;
		try
		{
			MissionComponentCommon missionComponentCommon = (MissionComponentCommon)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, missionComponentCommon.m_luaExportHelper.m_rift);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060186B3 RID: 100019 RVA: 0x006D8270 File Offset: 0x006D6470
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_rift(IntPtr l)
	{
		int result;
		try
		{
			MissionComponentCommon missionComponentCommon = (MissionComponentCommon)LuaObject.checkSelf(l);
			RiftComponentCommon rift;
			LuaObject.checkType<RiftComponentCommon>(l, 2, out rift);
			missionComponentCommon.m_luaExportHelper.m_rift = rift;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060186B4 RID: 100020 RVA: 0x006D82CC File Offset: 0x006D64CC
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_m_hero(IntPtr l)
	{
		int result;
		try
		{
			MissionComponentCommon missionComponentCommon = (MissionComponentCommon)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, missionComponentCommon.m_luaExportHelper.m_hero);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060186B5 RID: 100021 RVA: 0x006D8324 File Offset: 0x006D6524
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_m_hero(IntPtr l)
	{
		int result;
		try
		{
			MissionComponentCommon missionComponentCommon = (MissionComponentCommon)LuaObject.checkSelf(l);
			HeroComponentCommon hero;
			LuaObject.checkType<HeroComponentCommon>(l, 2, out hero);
			missionComponentCommon.m_luaExportHelper.m_hero = hero;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060186B6 RID: 100022 RVA: 0x006D8380 File Offset: 0x006D6580
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_m_thearchyTrial(IntPtr l)
	{
		int result;
		try
		{
			MissionComponentCommon missionComponentCommon = (MissionComponentCommon)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, missionComponentCommon.m_luaExportHelper.m_thearchyTrial);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060186B7 RID: 100023 RVA: 0x006D83D8 File Offset: 0x006D65D8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_thearchyTrial(IntPtr l)
	{
		int result;
		try
		{
			MissionComponentCommon missionComponentCommon = (MissionComponentCommon)LuaObject.checkSelf(l);
			ThearchyTrialCompomentCommon thearchyTrial;
			LuaObject.checkType<ThearchyTrialCompomentCommon>(l, 2, out thearchyTrial);
			missionComponentCommon.m_luaExportHelper.m_thearchyTrial = thearchyTrial;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060186B8 RID: 100024 RVA: 0x006D8434 File Offset: 0x006D6634
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_m_anikiGym(IntPtr l)
	{
		int result;
		try
		{
			MissionComponentCommon missionComponentCommon = (MissionComponentCommon)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, missionComponentCommon.m_luaExportHelper.m_anikiGym);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060186B9 RID: 100025 RVA: 0x006D848C File Offset: 0x006D668C
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_m_anikiGym(IntPtr l)
	{
		int result;
		try
		{
			MissionComponentCommon missionComponentCommon = (MissionComponentCommon)LuaObject.checkSelf(l);
			AnikiGymComponentCommon anikiGym;
			LuaObject.checkType<AnikiGymComponentCommon>(l, 2, out anikiGym);
			missionComponentCommon.m_luaExportHelper.m_anikiGym = anikiGym;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060186BA RID: 100026 RVA: 0x006D84E8 File Offset: 0x006D66E8
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_m_battle(IntPtr l)
	{
		int result;
		try
		{
			MissionComponentCommon missionComponentCommon = (MissionComponentCommon)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, missionComponentCommon.m_luaExportHelper.m_battle);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060186BB RID: 100027 RVA: 0x006D8540 File Offset: 0x006D6740
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_battle(IntPtr l)
	{
		int result;
		try
		{
			MissionComponentCommon missionComponentCommon = (MissionComponentCommon)LuaObject.checkSelf(l);
			BattleComponentCommon battle;
			LuaObject.checkType<BattleComponentCommon>(l, 2, out battle);
			missionComponentCommon.m_luaExportHelper.m_battle = battle;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060186BC RID: 100028 RVA: 0x006D859C File Offset: 0x006D679C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_arena(IntPtr l)
	{
		int result;
		try
		{
			MissionComponentCommon missionComponentCommon = (MissionComponentCommon)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, missionComponentCommon.m_luaExportHelper.m_arena);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060186BD RID: 100029 RVA: 0x006D85F4 File Offset: 0x006D67F4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_arena(IntPtr l)
	{
		int result;
		try
		{
			MissionComponentCommon missionComponentCommon = (MissionComponentCommon)LuaObject.checkSelf(l);
			ArenaComponentCommon arena;
			LuaObject.checkType<ArenaComponentCommon>(l, 2, out arena);
			missionComponentCommon.m_luaExportHelper.m_arena = arena;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060186BE RID: 100030 RVA: 0x006D8650 File Offset: 0x006D6850
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_heroDungeon(IntPtr l)
	{
		int result;
		try
		{
			MissionComponentCommon missionComponentCommon = (MissionComponentCommon)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, missionComponentCommon.m_luaExportHelper.m_heroDungeon);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060186BF RID: 100031 RVA: 0x006D86A8 File Offset: 0x006D68A8
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_m_heroDungeon(IntPtr l)
	{
		int result;
		try
		{
			MissionComponentCommon missionComponentCommon = (MissionComponentCommon)LuaObject.checkSelf(l);
			HeroDungeonComponentCommon heroDungeon;
			LuaObject.checkType<HeroDungeonComponentCommon>(l, 2, out heroDungeon);
			missionComponentCommon.m_luaExportHelper.m_heroDungeon = heroDungeon;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060186C0 RID: 100032 RVA: 0x006D8704 File Offset: 0x006D6904
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_m_heroTrainning(IntPtr l)
	{
		int result;
		try
		{
			MissionComponentCommon missionComponentCommon = (MissionComponentCommon)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, missionComponentCommon.m_luaExportHelper.m_heroTrainning);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060186C1 RID: 100033 RVA: 0x006D875C File Offset: 0x006D695C
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_m_heroTrainning(IntPtr l)
	{
		int result;
		try
		{
			MissionComponentCommon missionComponentCommon = (MissionComponentCommon)LuaObject.checkSelf(l);
			HeroTrainningComponentCommon heroTrainning;
			LuaObject.checkType<HeroTrainningComponentCommon>(l, 2, out heroTrainning);
			missionComponentCommon.m_luaExportHelper.m_heroTrainning = heroTrainning;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060186C2 RID: 100034 RVA: 0x006D87B8 File Offset: 0x006D69B8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_memoryCorridor(IntPtr l)
	{
		int result;
		try
		{
			MissionComponentCommon missionComponentCommon = (MissionComponentCommon)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, missionComponentCommon.m_luaExportHelper.m_memoryCorridor);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060186C3 RID: 100035 RVA: 0x006D8810 File Offset: 0x006D6A10
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_m_memoryCorridor(IntPtr l)
	{
		int result;
		try
		{
			MissionComponentCommon missionComponentCommon = (MissionComponentCommon)LuaObject.checkSelf(l);
			MemoryCorridorCompomentCommon memoryCorridor;
			LuaObject.checkType<MemoryCorridorCompomentCommon>(l, 2, out memoryCorridor);
			missionComponentCommon.m_luaExportHelper.m_memoryCorridor = memoryCorridor;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060186C4 RID: 100036 RVA: 0x006D886C File Offset: 0x006D6A6C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_treasureMap(IntPtr l)
	{
		int result;
		try
		{
			MissionComponentCommon missionComponentCommon = (MissionComponentCommon)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, missionComponentCommon.m_luaExportHelper.m_treasureMap);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060186C5 RID: 100037 RVA: 0x006D88C4 File Offset: 0x006D6AC4
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_m_treasureMap(IntPtr l)
	{
		int result;
		try
		{
			MissionComponentCommon missionComponentCommon = (MissionComponentCommon)LuaObject.checkSelf(l);
			TreasureMapComponentCommon treasureMap;
			LuaObject.checkType<TreasureMapComponentCommon>(l, 2, out treasureMap);
			missionComponentCommon.m_luaExportHelper.m_treasureMap = treasureMap;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060186C6 RID: 100038 RVA: 0x006D8920 File Offset: 0x006D6B20
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_heroPhantom(IntPtr l)
	{
		int result;
		try
		{
			MissionComponentCommon missionComponentCommon = (MissionComponentCommon)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, missionComponentCommon.m_luaExportHelper.m_heroPhantom);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060186C7 RID: 100039 RVA: 0x006D8978 File Offset: 0x006D6B78
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_m_heroPhantom(IntPtr l)
	{
		int result;
		try
		{
			MissionComponentCommon missionComponentCommon = (MissionComponentCommon)LuaObject.checkSelf(l);
			HeroPhantomCompomentCommon heroPhantom;
			LuaObject.checkType<HeroPhantomCompomentCommon>(l, 2, out heroPhantom);
			missionComponentCommon.m_luaExportHelper.m_heroPhantom = heroPhantom;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060186C8 RID: 100040 RVA: 0x006D89D4 File Offset: 0x006D6BD4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_cooperateBattle(IntPtr l)
	{
		int result;
		try
		{
			MissionComponentCommon missionComponentCommon = (MissionComponentCommon)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, missionComponentCommon.m_luaExportHelper.m_cooperateBattle);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060186C9 RID: 100041 RVA: 0x006D8A2C File Offset: 0x006D6C2C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_cooperateBattle(IntPtr l)
	{
		int result;
		try
		{
			MissionComponentCommon missionComponentCommon = (MissionComponentCommon)LuaObject.checkSelf(l);
			CooperateBattleCompomentCommon cooperateBattle;
			LuaObject.checkType<CooperateBattleCompomentCommon>(l, 2, out cooperateBattle);
			missionComponentCommon.m_luaExportHelper.m_cooperateBattle = cooperateBattle;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060186CA RID: 100042 RVA: 0x006D8A88 File Offset: 0x006D6C88
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_m_trainingGround(IntPtr l)
	{
		int result;
		try
		{
			MissionComponentCommon missionComponentCommon = (MissionComponentCommon)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, missionComponentCommon.m_luaExportHelper.m_trainingGround);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060186CB RID: 100043 RVA: 0x006D8AE0 File Offset: 0x006D6CE0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_trainingGround(IntPtr l)
	{
		int result;
		try
		{
			MissionComponentCommon missionComponentCommon = (MissionComponentCommon)LuaObject.checkSelf(l);
			TrainingGroundCompomentCommon trainingGround;
			LuaObject.checkType<TrainingGroundCompomentCommon>(l, 2, out trainingGround);
			missionComponentCommon.m_luaExportHelper.m_trainingGround = trainingGround;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060186CC RID: 100044 RVA: 0x006D8B3C File Offset: 0x006D6D3C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_team(IntPtr l)
	{
		int result;
		try
		{
			MissionComponentCommon missionComponentCommon = (MissionComponentCommon)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, missionComponentCommon.m_luaExportHelper.m_team);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060186CD RID: 100045 RVA: 0x006D8B94 File Offset: 0x006D6D94
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_team(IntPtr l)
	{
		int result;
		try
		{
			MissionComponentCommon missionComponentCommon = (MissionComponentCommon)LuaObject.checkSelf(l);
			TeamComponentCommon team;
			LuaObject.checkType<TeamComponentCommon>(l, 2, out team);
			missionComponentCommon.m_luaExportHelper.m_team = team;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060186CE RID: 100046 RVA: 0x006D8BF0 File Offset: 0x006D6DF0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_novice(IntPtr l)
	{
		int result;
		try
		{
			MissionComponentCommon missionComponentCommon = (MissionComponentCommon)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, missionComponentCommon.m_luaExportHelper.m_novice);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060186CF RID: 100047 RVA: 0x006D8C48 File Offset: 0x006D6E48
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_m_novice(IntPtr l)
	{
		int result;
		try
		{
			MissionComponentCommon missionComponentCommon = (MissionComponentCommon)LuaObject.checkSelf(l);
			NoviceComponentCommon novice;
			LuaObject.checkType<NoviceComponentCommon>(l, 2, out novice);
			missionComponentCommon.m_luaExportHelper.m_novice = novice;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060186D0 RID: 100048 RVA: 0x006D8CA4 File Offset: 0x006D6EA4
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_m_friend(IntPtr l)
	{
		int result;
		try
		{
			MissionComponentCommon missionComponentCommon = (MissionComponentCommon)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, missionComponentCommon.m_luaExportHelper.m_friend);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060186D1 RID: 100049 RVA: 0x006D8CFC File Offset: 0x006D6EFC
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_m_friend(IntPtr l)
	{
		int result;
		try
		{
			MissionComponentCommon missionComponentCommon = (MissionComponentCommon)LuaObject.checkSelf(l);
			FriendComponentCommon friend;
			LuaObject.checkType<FriendComponentCommon>(l, 2, out friend);
			missionComponentCommon.m_luaExportHelper.m_friend = friend;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060186D2 RID: 100050 RVA: 0x006D8D58 File Offset: 0x006D6F58
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_m_heroAssistants(IntPtr l)
	{
		int result;
		try
		{
			MissionComponentCommon missionComponentCommon = (MissionComponentCommon)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, missionComponentCommon.m_luaExportHelper.m_heroAssistants);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060186D3 RID: 100051 RVA: 0x006D8DB0 File Offset: 0x006D6FB0
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_m_heroAssistants(IntPtr l)
	{
		int result;
		try
		{
			MissionComponentCommon missionComponentCommon = (MissionComponentCommon)LuaObject.checkSelf(l);
			HeroAssistantsCompomentCommon heroAssistants;
			LuaObject.checkType<HeroAssistantsCompomentCommon>(l, 2, out heroAssistants);
			missionComponentCommon.m_luaExportHelper.m_heroAssistants = heroAssistants;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060186D4 RID: 100052 RVA: 0x006D8E0C File Offset: 0x006D700C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_resource(IntPtr l)
	{
		int result;
		try
		{
			MissionComponentCommon missionComponentCommon = (MissionComponentCommon)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, missionComponentCommon.m_luaExportHelper.m_resource);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060186D5 RID: 100053 RVA: 0x006D8E64 File Offset: 0x006D7064
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_resource(IntPtr l)
	{
		int result;
		try
		{
			MissionComponentCommon missionComponentCommon = (MissionComponentCommon)LuaObject.checkSelf(l);
			ResourceComponentCommon resource;
			LuaObject.checkType<ResourceComponentCommon>(l, 2, out resource);
			missionComponentCommon.m_luaExportHelper.m_resource = resource;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060186D6 RID: 100054 RVA: 0x006D8EC0 File Offset: 0x006D70C0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_realTimePvp(IntPtr l)
	{
		int result;
		try
		{
			MissionComponentCommon missionComponentCommon = (MissionComponentCommon)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, missionComponentCommon.m_luaExportHelper.m_realTimePvp);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060186D7 RID: 100055 RVA: 0x006D8F18 File Offset: 0x006D7118
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_realTimePvp(IntPtr l)
	{
		int result;
		try
		{
			MissionComponentCommon missionComponentCommon = (MissionComponentCommon)LuaObject.checkSelf(l);
			RealTimePVPComponentCommon realTimePvp;
			LuaObject.checkType<RealTimePVPComponentCommon>(l, 2, out realTimePvp);
			missionComponentCommon.m_luaExportHelper.m_realTimePvp = realTimePvp;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060186D8 RID: 100056 RVA: 0x006D8F74 File Offset: 0x006D7174
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_giftStore(IntPtr l)
	{
		int result;
		try
		{
			MissionComponentCommon missionComponentCommon = (MissionComponentCommon)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, missionComponentCommon.m_luaExportHelper.m_giftStore);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060186D9 RID: 100057 RVA: 0x006D8FCC File Offset: 0x006D71CC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_giftStore(IntPtr l)
	{
		int result;
		try
		{
			MissionComponentCommon missionComponentCommon = (MissionComponentCommon)LuaObject.checkSelf(l);
			GiftStoreComponentCommon giftStore;
			LuaObject.checkType<GiftStoreComponentCommon>(l, 2, out giftStore);
			missionComponentCommon.m_luaExportHelper.m_giftStore = giftStore;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060186DA RID: 100058 RVA: 0x006D9028 File Offset: 0x006D7228
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_m_rechargeStore(IntPtr l)
	{
		int result;
		try
		{
			MissionComponentCommon missionComponentCommon = (MissionComponentCommon)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, missionComponentCommon.m_luaExportHelper.m_rechargeStore);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060186DB RID: 100059 RVA: 0x006D9080 File Offset: 0x006D7280
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_m_rechargeStore(IntPtr l)
	{
		int result;
		try
		{
			MissionComponentCommon missionComponentCommon = (MissionComponentCommon)LuaObject.checkSelf(l);
			RechargeStoreComponentCommon rechargeStore;
			LuaObject.checkType<RechargeStoreComponentCommon>(l, 2, out rechargeStore);
			missionComponentCommon.m_luaExportHelper.m_rechargeStore = rechargeStore;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060186DC RID: 100060 RVA: 0x006D90DC File Offset: 0x006D72DC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_Owner(IntPtr l)
	{
		int result;
		try
		{
			MissionComponentCommon missionComponentCommon = (MissionComponentCommon)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, missionComponentCommon.Owner);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060186DD RID: 100061 RVA: 0x006D9130 File Offset: 0x006D7330
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_Owner(IntPtr l)
	{
		int result;
		try
		{
			MissionComponentCommon missionComponentCommon = (MissionComponentCommon)LuaObject.checkSelf(l);
			IComponentOwner owner;
			LuaObject.checkType<IComponentOwner>(l, 2, out owner);
			missionComponentCommon.Owner = owner;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060186DE RID: 100062 RVA: 0x006D9188 File Offset: 0x006D7388
	[Preserve]
	public static void reg(IntPtr l)
	{
		LuaObject.getTypeTable(l, "BlackJack.ProjectL.Common.MissionComponentCommon");
		if (Lua_BlackJack_ProjectL_Common_MissionComponentCommon.<>f__mg$cache0 == null)
		{
			Lua_BlackJack_ProjectL_Common_MissionComponentCommon.<>f__mg$cache0 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_MissionComponentCommon.GetName);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_MissionComponentCommon.<>f__mg$cache0);
		if (Lua_BlackJack_ProjectL_Common_MissionComponentCommon.<>f__mg$cache1 == null)
		{
			Lua_BlackJack_ProjectL_Common_MissionComponentCommon.<>f__mg$cache1 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_MissionComponentCommon.Init);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_MissionComponentCommon.<>f__mg$cache1);
		if (Lua_BlackJack_ProjectL_Common_MissionComponentCommon.<>f__mg$cache2 == null)
		{
			Lua_BlackJack_ProjectL_Common_MissionComponentCommon.<>f__mg$cache2 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_MissionComponentCommon.PostInit);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_MissionComponentCommon.<>f__mg$cache2);
		if (Lua_BlackJack_ProjectL_Common_MissionComponentCommon.<>f__mg$cache3 == null)
		{
			Lua_BlackJack_ProjectL_Common_MissionComponentCommon.<>f__mg$cache3 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_MissionComponentCommon.DeInit);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_MissionComponentCommon.<>f__mg$cache3);
		if (Lua_BlackJack_ProjectL_Common_MissionComponentCommon.<>f__mg$cache4 == null)
		{
			Lua_BlackJack_ProjectL_Common_MissionComponentCommon.<>f__mg$cache4 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_MissionComponentCommon.Tick);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_MissionComponentCommon.<>f__mg$cache4);
		if (Lua_BlackJack_ProjectL_Common_MissionComponentCommon.<>f__mg$cache5 == null)
		{
			Lua_BlackJack_ProjectL_Common_MissionComponentCommon.<>f__mg$cache5 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_MissionComponentCommon.PostDeSerialize);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_MissionComponentCommon.<>f__mg$cache5);
		if (Lua_BlackJack_ProjectL_Common_MissionComponentCommon.<>f__mg$cache6 == null)
		{
			Lua_BlackJack_ProjectL_Common_MissionComponentCommon.<>f__mg$cache6 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_MissionComponentCommon.RemoveProcessingMissionById);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_MissionComponentCommon.<>f__mg$cache6);
		if (Lua_BlackJack_ProjectL_Common_MissionComponentCommon.<>f__mg$cache7 == null)
		{
			Lua_BlackJack_ProjectL_Common_MissionComponentCommon.<>f__mg$cache7 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_MissionComponentCommon.GetProcessingMissionByMissionType);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_MissionComponentCommon.<>f__mg$cache7);
		if (Lua_BlackJack_ProjectL_Common_MissionComponentCommon.<>f__mg$cache8 == null)
		{
			Lua_BlackJack_ProjectL_Common_MissionComponentCommon.<>f__mg$cache8 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_MissionComponentCommon.CanGetRewarding);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_MissionComponentCommon.<>f__mg$cache8);
		if (Lua_BlackJack_ProjectL_Common_MissionComponentCommon.<>f__mg$cache9 == null)
		{
			Lua_BlackJack_ProjectL_Common_MissionComponentCommon.<>f__mg$cache9 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_MissionComponentCommon.IsMissionFinished);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_MissionComponentCommon.<>f__mg$cache9);
		if (Lua_BlackJack_ProjectL_Common_MissionComponentCommon.<>f__mg$cacheA == null)
		{
			Lua_BlackJack_ProjectL_Common_MissionComponentCommon.<>f__mg$cacheA = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_MissionComponentCommon.GetAllProcessingNoviceMissionList);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_MissionComponentCommon.<>f__mg$cacheA);
		if (Lua_BlackJack_ProjectL_Common_MissionComponentCommon.<>f__mg$cacheB == null)
		{
			Lua_BlackJack_ProjectL_Common_MissionComponentCommon.<>f__mg$cacheB = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_MissionComponentCommon.GetAllFinishedNoviceMissionList);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_MissionComponentCommon.<>f__mg$cacheB);
		if (Lua_BlackJack_ProjectL_Common_MissionComponentCommon.<>f__mg$cacheC == null)
		{
			Lua_BlackJack_ProjectL_Common_MissionComponentCommon.<>f__mg$cacheC = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_MissionComponentCommon.GetMissionMaxProcess);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_MissionComponentCommon.<>f__mg$cacheC);
		if (Lua_BlackJack_ProjectL_Common_MissionComponentCommon.<>f__mg$cacheD == null)
		{
			Lua_BlackJack_ProjectL_Common_MissionComponentCommon.<>f__mg$cacheD = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_MissionComponentCommon.IsMissionProcessFinished);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_MissionComponentCommon.<>f__mg$cacheD);
		if (Lua_BlackJack_ProjectL_Common_MissionComponentCommon.<>f__mg$cacheE == null)
		{
			Lua_BlackJack_ProjectL_Common_MissionComponentCommon.<>f__mg$cacheE = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_MissionComponentCommon.CanGainMissionReward);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_MissionComponentCommon.<>f__mg$cacheE);
		if (Lua_BlackJack_ProjectL_Common_MissionComponentCommon.<>f__mg$cacheF == null)
		{
			Lua_BlackJack_ProjectL_Common_MissionComponentCommon.<>f__mg$cacheF = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_MissionComponentCommon.GetMissionCompletedProcess);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_MissionComponentCommon.<>f__mg$cacheF);
		if (Lua_BlackJack_ProjectL_Common_MissionComponentCommon.<>f__mg$cache10 == null)
		{
			Lua_BlackJack_ProjectL_Common_MissionComponentCommon.<>f__mg$cache10 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_MissionComponentCommon.OnMonthCardVaildEveryDayFlush);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_MissionComponentCommon.<>f__mg$cache10);
		if (Lua_BlackJack_ProjectL_Common_MissionComponentCommon.<>f__mg$cache11 == null)
		{
			Lua_BlackJack_ProjectL_Common_MissionComponentCommon.<>f__mg$cache11 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_MissionComponentCommon.OnMonthCardVaildCallBack);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_MissionComponentCommon.<>f__mg$cache11);
		if (Lua_BlackJack_ProjectL_Common_MissionComponentCommon.<>f__mg$cache12 == null)
		{
			Lua_BlackJack_ProjectL_Common_MissionComponentCommon.<>f__mg$cache12 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_MissionComponentCommon.InitProcessingMission);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_MissionComponentCommon.<>f__mg$cache12);
		if (Lua_BlackJack_ProjectL_Common_MissionComponentCommon.<>f__mg$cache13 == null)
		{
			Lua_BlackJack_ProjectL_Common_MissionComponentCommon.<>f__mg$cache13 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_MissionComponentCommon.InitExistMissions);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_MissionComponentCommon.<>f__mg$cache13);
		if (Lua_BlackJack_ProjectL_Common_MissionComponentCommon.<>f__mg$cache14 == null)
		{
			Lua_BlackJack_ProjectL_Common_MissionComponentCommon.<>f__mg$cache14 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_MissionComponentCommon.OnFlushEverydayMissionEvent);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_MissionComponentCommon.<>f__mg$cache14);
		if (Lua_BlackJack_ProjectL_Common_MissionComponentCommon.<>f__mg$cache15 == null)
		{
			Lua_BlackJack_ProjectL_Common_MissionComponentCommon.<>f__mg$cache15 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_MissionComponentCommon.ResetEverydayMissions);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_MissionComponentCommon.<>f__mg$cache15);
		if (Lua_BlackJack_ProjectL_Common_MissionComponentCommon.<>f__mg$cache16 == null)
		{
			Lua_BlackJack_ProjectL_Common_MissionComponentCommon.<>f__mg$cache16 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_MissionComponentCommon.InitMissionListByMissionPeriodType);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_MissionComponentCommon.<>f__mg$cache16);
		if (Lua_BlackJack_ProjectL_Common_MissionComponentCommon.<>f__mg$cache17 == null)
		{
			Lua_BlackJack_ProjectL_Common_MissionComponentCommon.<>f__mg$cache17 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_MissionComponentCommon.CanUnlockMissionInLogicFromInit);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_MissionComponentCommon.<>f__mg$cache17);
		if (Lua_BlackJack_ProjectL_Common_MissionComponentCommon.<>f__mg$cache18 == null)
		{
			Lua_BlackJack_ProjectL_Common_MissionComponentCommon.<>f__mg$cache18 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_MissionComponentCommon.OnDirectActivatedMissionLocked);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_MissionComponentCommon.<>f__mg$cache18);
		if (Lua_BlackJack_ProjectL_Common_MissionComponentCommon.<>f__mg$cache19 == null)
		{
			Lua_BlackJack_ProjectL_Common_MissionComponentCommon.<>f__mg$cache19 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_MissionComponentCommon.IsNoviceMission);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_MissionComponentCommon.<>f__mg$cache19);
		if (Lua_BlackJack_ProjectL_Common_MissionComponentCommon.<>f__mg$cache1A == null)
		{
			Lua_BlackJack_ProjectL_Common_MissionComponentCommon.<>f__mg$cache1A = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_MissionComponentCommon.IsNoviceMissionActivated);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_MissionComponentCommon.<>f__mg$cache1A);
		if (Lua_BlackJack_ProjectL_Common_MissionComponentCommon.<>f__mg$cache1B == null)
		{
			Lua_BlackJack_ProjectL_Common_MissionComponentCommon.<>f__mg$cache1B = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_MissionComponentCommon.IsNoviceMissionActivatedForRewarding);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_MissionComponentCommon.<>f__mg$cache1B);
		if (Lua_BlackJack_ProjectL_Common_MissionComponentCommon.<>f__mg$cache1C == null)
		{
			Lua_BlackJack_ProjectL_Common_MissionComponentCommon.<>f__mg$cache1C = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_MissionComponentCommon.CanUnlockMissionInLogic);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_MissionComponentCommon.<>f__mg$cache1C);
		if (Lua_BlackJack_ProjectL_Common_MissionComponentCommon.<>f__mg$cache1D == null)
		{
			Lua_BlackJack_ProjectL_Common_MissionComponentCommon.<>f__mg$cache1D = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_MissionComponentCommon.CanUnlockMission);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_MissionComponentCommon.<>f__mg$cache1D);
		if (Lua_BlackJack_ProjectL_Common_MissionComponentCommon.<>f__mg$cache1E == null)
		{
			Lua_BlackJack_ProjectL_Common_MissionComponentCommon.<>f__mg$cache1E = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_MissionComponentCommon.CaculateDirectlyActivationMissionStatus);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_MissionComponentCommon.<>f__mg$cache1E);
		if (Lua_BlackJack_ProjectL_Common_MissionComponentCommon.<>f__mg$cache1F == null)
		{
			Lua_BlackJack_ProjectL_Common_MissionComponentCommon.<>f__mg$cache1F = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_MissionComponentCommon.AddMission);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_MissionComponentCommon.<>f__mg$cache1F);
		if (Lua_BlackJack_ProjectL_Common_MissionComponentCommon.<>f__mg$cache20 == null)
		{
			Lua_BlackJack_ProjectL_Common_MissionComponentCommon.<>f__mg$cache20 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_MissionComponentCommon.OnAddProcessingDirectelyActivitedMission);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_MissionComponentCommon.<>f__mg$cache20);
		if (Lua_BlackJack_ProjectL_Common_MissionComponentCommon.<>f__mg$cache21 == null)
		{
			Lua_BlackJack_ProjectL_Common_MissionComponentCommon.<>f__mg$cache21 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_MissionComponentCommon.GetProcessingMissionByMissionPeriod);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_MissionComponentCommon.<>f__mg$cache21);
		if (Lua_BlackJack_ProjectL_Common_MissionComponentCommon.<>f__mg$cache22 == null)
		{
			Lua_BlackJack_ProjectL_Common_MissionComponentCommon.<>f__mg$cache22 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_MissionComponentCommon.OnGetProcessingDirectActivationMissionFail);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_MissionComponentCommon.<>f__mg$cache22);
		if (Lua_BlackJack_ProjectL_Common_MissionComponentCommon.<>f__mg$cache23 == null)
		{
			Lua_BlackJack_ProjectL_Common_MissionComponentCommon.<>f__mg$cache23 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_MissionComponentCommon.AddEverydayMission);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_MissionComponentCommon.<>f__mg$cache23);
		if (Lua_BlackJack_ProjectL_Common_MissionComponentCommon.<>f__mg$cache24 == null)
		{
			Lua_BlackJack_ProjectL_Common_MissionComponentCommon.<>f__mg$cache24 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_MissionComponentCommon.AddOneOffMission);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_MissionComponentCommon.<>f__mg$cache24);
		if (Lua_BlackJack_ProjectL_Common_MissionComponentCommon.<>f__mg$cache25 == null)
		{
			Lua_BlackJack_ProjectL_Common_MissionComponentCommon.<>f__mg$cache25 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_MissionComponentCommon.IsMissionExist);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_MissionComponentCommon.<>f__mg$cache25);
		if (Lua_BlackJack_ProjectL_Common_MissionComponentCommon.<>f__mg$cache26 == null)
		{
			Lua_BlackJack_ProjectL_Common_MissionComponentCommon.<>f__mg$cache26 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_MissionComponentCommon.InitMissionsFromConfig);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_MissionComponentCommon.<>f__mg$cache26);
		if (Lua_BlackJack_ProjectL_Common_MissionComponentCommon.<>f__mg$cache27 == null)
		{
			Lua_BlackJack_ProjectL_Common_MissionComponentCommon.<>f__mg$cache27 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_MissionComponentCommon.FinishMission);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_MissionComponentCommon.<>f__mg$cache27);
		if (Lua_BlackJack_ProjectL_Common_MissionComponentCommon.<>f__mg$cache28 == null)
		{
			Lua_BlackJack_ProjectL_Common_MissionComponentCommon.<>f__mg$cache28 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_MissionComponentCommon.GetAllEverydayMissionConfigByPreMissionId);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_MissionComponentCommon.<>f__mg$cache28);
		if (Lua_BlackJack_ProjectL_Common_MissionComponentCommon.<>f__mg$cache29 == null)
		{
			Lua_BlackJack_ProjectL_Common_MissionComponentCommon.<>f__mg$cache29 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_MissionComponentCommon.GetAllEverydayMissionListByPlayerLevel);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_MissionComponentCommon.<>f__mg$cache29);
		if (Lua_BlackJack_ProjectL_Common_MissionComponentCommon.<>f__mg$cache2A == null)
		{
			Lua_BlackJack_ProjectL_Common_MissionComponentCommon.<>f__mg$cache2A = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_MissionComponentCommon.GetAllEverydayMissionListByScenario);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_MissionComponentCommon.<>f__mg$cache2A);
		if (Lua_BlackJack_ProjectL_Common_MissionComponentCommon.<>f__mg$cache2B == null)
		{
			Lua_BlackJack_ProjectL_Common_MissionComponentCommon.<>f__mg$cache2B = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_MissionComponentCommon.UpdateMissionListByMissionComplete);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_MissionComponentCommon.<>f__mg$cache2B);
		if (Lua_BlackJack_ProjectL_Common_MissionComponentCommon.<>f__mg$cache2C == null)
		{
			Lua_BlackJack_ProjectL_Common_MissionComponentCommon.<>f__mg$cache2C = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_MissionComponentCommon.UpdateMissionListByLevelUp);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_MissionComponentCommon.<>f__mg$cache2C);
		if (Lua_BlackJack_ProjectL_Common_MissionComponentCommon.<>f__mg$cache2D == null)
		{
			Lua_BlackJack_ProjectL_Common_MissionComponentCommon.<>f__mg$cache2D = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_MissionComponentCommon.UpdateMissionListByScenario);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_MissionComponentCommon.<>f__mg$cache2D);
		if (Lua_BlackJack_ProjectL_Common_MissionComponentCommon.<>f__mg$cache2E == null)
		{
			Lua_BlackJack_ProjectL_Common_MissionComponentCommon.<>f__mg$cache2E = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_MissionComponentCommon.UpdateMissionListByNewMissionConfigList);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_MissionComponentCommon.<>f__mg$cache2E);
		if (Lua_BlackJack_ProjectL_Common_MissionComponentCommon.<>f__mg$cache2F == null)
		{
			Lua_BlackJack_ProjectL_Common_MissionComponentCommon.<>f__mg$cache2F = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_MissionComponentCommon.AddMissionProcess);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_MissionComponentCommon.<>f__mg$cache2F);
		if (Lua_BlackJack_ProjectL_Common_MissionComponentCommon.<>f__mg$cache30 == null)
		{
			Lua_BlackJack_ProjectL_Common_MissionComponentCommon.<>f__mg$cache30 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_MissionComponentCommon.RegisterMissionCallBack);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_MissionComponentCommon.<>f__mg$cache30);
		if (Lua_BlackJack_ProjectL_Common_MissionComponentCommon.<>f__mg$cache31 == null)
		{
			Lua_BlackJack_ProjectL_Common_MissionComponentCommon.<>f__mg$cache31 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_MissionComponentCommon.IsCompleted);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_MissionComponentCommon.<>f__mg$cache31);
		if (Lua_BlackJack_ProjectL_Common_MissionComponentCommon.<>f__mg$cache32 == null)
		{
			Lua_BlackJack_ProjectL_Common_MissionComponentCommon.<>f__mg$cache32 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_MissionComponentCommon.OnSelectCardMissionCallBack);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_MissionComponentCommon.<>f__mg$cache32);
		if (Lua_BlackJack_ProjectL_Common_MissionComponentCommon.<>f__mg$cache33 == null)
		{
			Lua_BlackJack_ProjectL_Common_MissionComponentCommon.<>f__mg$cache33 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_MissionComponentCommon.OnMissionSelectCardCallBack);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_MissionComponentCommon.<>f__mg$cache33);
		if (Lua_BlackJack_ProjectL_Common_MissionComponentCommon.<>f__mg$cache34 == null)
		{
			Lua_BlackJack_ProjectL_Common_MissionComponentCommon.<>f__mg$cache34 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_MissionComponentCommon.SetStatisticalData);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_MissionComponentCommon.<>f__mg$cache34);
		if (Lua_BlackJack_ProjectL_Common_MissionComponentCommon.<>f__mg$cache35 == null)
		{
			Lua_BlackJack_ProjectL_Common_MissionComponentCommon.<>f__mg$cache35 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_MissionComponentCommon.AddStatisticalData);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_MissionComponentCommon.<>f__mg$cache35);
		if (Lua_BlackJack_ProjectL_Common_MissionComponentCommon.<>f__mg$cache36 == null)
		{
			Lua_BlackJack_ProjectL_Common_MissionComponentCommon.<>f__mg$cache36 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_MissionComponentCommon.OnSummonHeroCallBack);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_MissionComponentCommon.<>f__mg$cache36);
		if (Lua_BlackJack_ProjectL_Common_MissionComponentCommon.<>f__mg$cache37 == null)
		{
			Lua_BlackJack_ProjectL_Common_MissionComponentCommon.<>f__mg$cache37 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_MissionComponentCommon.OnConsumeEnergyCallBack);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_MissionComponentCommon.<>f__mg$cache37);
		if (Lua_BlackJack_ProjectL_Common_MissionComponentCommon.<>f__mg$cache38 == null)
		{
			Lua_BlackJack_ProjectL_Common_MissionComponentCommon.<>f__mg$cache38 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_MissionComponentCommon.OnCompleteEventCallBack);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_MissionComponentCommon.<>f__mg$cache38);
		if (Lua_BlackJack_ProjectL_Common_MissionComponentCommon.<>f__mg$cache39 == null)
		{
			Lua_BlackJack_ProjectL_Common_MissionComponentCommon.<>f__mg$cache39 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_MissionComponentCommon.OnCompleteLevelCallBack);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_MissionComponentCommon.<>f__mg$cache39);
		if (Lua_BlackJack_ProjectL_Common_MissionComponentCommon.<>f__mg$cache3A == null)
		{
			Lua_BlackJack_ProjectL_Common_MissionComponentCommon.<>f__mg$cache3A = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_MissionComponentCommon.RiftLevelAttackDiffculityCallBack);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_MissionComponentCommon.<>f__mg$cache3A);
		if (Lua_BlackJack_ProjectL_Common_MissionComponentCommon.<>f__mg$cache3B == null)
		{
			Lua_BlackJack_ProjectL_Common_MissionComponentCommon.<>f__mg$cache3B = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_MissionComponentCommon.AddBattleTypeLevelStatisticalData);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_MissionComponentCommon.<>f__mg$cache3B);
		if (Lua_BlackJack_ProjectL_Common_MissionComponentCommon.<>f__mg$cache3C == null)
		{
			Lua_BlackJack_ProjectL_Common_MissionComponentCommon.<>f__mg$cache3C = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_MissionComponentCommon.OnArenaConsecutiveVictoryCallBack);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_MissionComponentCommon.<>f__mg$cache3C);
		if (Lua_BlackJack_ProjectL_Common_MissionComponentCommon.<>f__mg$cache3D == null)
		{
			Lua_BlackJack_ProjectL_Common_MissionComponentCommon.<>f__mg$cache3D = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_MissionComponentCommon.OnArenaFightCallBack);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_MissionComponentCommon.<>f__mg$cache3D);
		if (Lua_BlackJack_ProjectL_Common_MissionComponentCommon.<>f__mg$cache3E == null)
		{
			Lua_BlackJack_ProjectL_Common_MissionComponentCommon.<>f__mg$cache3E = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_MissionComponentCommon.OnCompleteScenaioCallBack);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_MissionComponentCommon.<>f__mg$cache3E);
		if (Lua_BlackJack_ProjectL_Common_MissionComponentCommon.<>f__mg$cache3F == null)
		{
			Lua_BlackJack_ProjectL_Common_MissionComponentCommon.<>f__mg$cache3F = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_MissionComponentCommon.OnCompleteRiftLevelCallBack);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_MissionComponentCommon.<>f__mg$cache3F);
		if (Lua_BlackJack_ProjectL_Common_MissionComponentCommon.<>f__mg$cache40 == null)
		{
			Lua_BlackJack_ProjectL_Common_MissionComponentCommon.<>f__mg$cache40 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_MissionComponentCommon.OnGetRiftLevelFightAchievementCallBack);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_MissionComponentCommon.<>f__mg$cache40);
		if (Lua_BlackJack_ProjectL_Common_MissionComponentCommon.<>f__mg$cache41 == null)
		{
			Lua_BlackJack_ProjectL_Common_MissionComponentCommon.<>f__mg$cache41 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_MissionComponentCommon.OnFinishFightAchievementCallBack);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_MissionComponentCommon.<>f__mg$cache41);
		if (Lua_BlackJack_ProjectL_Common_MissionComponentCommon.<>f__mg$cache42 == null)
		{
			Lua_BlackJack_ProjectL_Common_MissionComponentCommon.<>f__mg$cache42 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_MissionComponentCommon.OnGetRiftLevelStarCallBack);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_MissionComponentCommon.<>f__mg$cache42);
		if (Lua_BlackJack_ProjectL_Common_MissionComponentCommon.<>f__mg$cache43 == null)
		{
			Lua_BlackJack_ProjectL_Common_MissionComponentCommon.<>f__mg$cache43 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_MissionComponentCommon.OnConsumeCrystalCallBack);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_MissionComponentCommon.<>f__mg$cache43);
		if (Lua_BlackJack_ProjectL_Common_MissionComponentCommon.<>f__mg$cache44 == null)
		{
			Lua_BlackJack_ProjectL_Common_MissionComponentCommon.<>f__mg$cache44 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_MissionComponentCommon.OnComsumeGoldCallBack);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_MissionComponentCommon.<>f__mg$cache44);
		if (Lua_BlackJack_ProjectL_Common_MissionComponentCommon.<>f__mg$cache45 == null)
		{
			Lua_BlackJack_ProjectL_Common_MissionComponentCommon.<>f__mg$cache45 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_MissionComponentCommon.OnUseHeroExpItemCallBack);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_MissionComponentCommon.<>f__mg$cache45);
		if (Lua_BlackJack_ProjectL_Common_MissionComponentCommon.<>f__mg$cache46 == null)
		{
			Lua_BlackJack_ProjectL_Common_MissionComponentCommon.<>f__mg$cache46 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_MissionComponentCommon.OnAllHeroAllJobLevelUpCallBack);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_MissionComponentCommon.<>f__mg$cache46);
		if (Lua_BlackJack_ProjectL_Common_MissionComponentCommon.<>f__mg$cache47 == null)
		{
			Lua_BlackJack_ProjectL_Common_MissionComponentCommon.<>f__mg$cache47 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_MissionComponentCommon.OnAllHeroAddJobNums);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_MissionComponentCommon.<>f__mg$cache47);
		if (Lua_BlackJack_ProjectL_Common_MissionComponentCommon.<>f__mg$cache48 == null)
		{
			Lua_BlackJack_ProjectL_Common_MissionComponentCommon.<>f__mg$cache48 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_MissionComponentCommon.OnRankJobHaveCallBack);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_MissionComponentCommon.<>f__mg$cache48);
		if (Lua_BlackJack_ProjectL_Common_MissionComponentCommon.<>f__mg$cache49 == null)
		{
			Lua_BlackJack_ProjectL_Common_MissionComponentCommon.<>f__mg$cache49 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_MissionComponentCommon.OnAllHeroAddSkillNumsCallBack);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_MissionComponentCommon.<>f__mg$cache49);
		if (Lua_BlackJack_ProjectL_Common_MissionComponentCommon.<>f__mg$cache4A == null)
		{
			Lua_BlackJack_ProjectL_Common_MissionComponentCommon.<>f__mg$cache4A = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_MissionComponentCommon.OnAllHeroAddSoliderNumsCallBack);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_MissionComponentCommon.<>f__mg$cache4A);
		if (Lua_BlackJack_ProjectL_Common_MissionComponentCommon.<>f__mg$cache4B == null)
		{
			Lua_BlackJack_ProjectL_Common_MissionComponentCommon.<>f__mg$cache4B = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_MissionComponentCommon.OnAllJobMasterHeroCallBack);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_MissionComponentCommon.<>f__mg$cache4B);
		if (Lua_BlackJack_ProjectL_Common_MissionComponentCommon.<>f__mg$cache4C == null)
		{
			Lua_BlackJack_ProjectL_Common_MissionComponentCommon.<>f__mg$cache4C = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_MissionComponentCommon.OnHeroMasterJobCallBack);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_MissionComponentCommon.<>f__mg$cache4C);
		if (Lua_BlackJack_ProjectL_Common_MissionComponentCommon.<>f__mg$cache4D == null)
		{
			Lua_BlackJack_ProjectL_Common_MissionComponentCommon.<>f__mg$cache4D = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_MissionComponentCommon.OnLevelUpHeroStarLevelCallBack);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_MissionComponentCommon.<>f__mg$cache4D);
		if (Lua_BlackJack_ProjectL_Common_MissionComponentCommon.<>f__mg$cache4E == null)
		{
			Lua_BlackJack_ProjectL_Common_MissionComponentCommon.<>f__mg$cache4E = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_MissionComponentCommon.UpdateHeroRankLevelCallBack);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_MissionComponentCommon.<>f__mg$cache4E);
		if (Lua_BlackJack_ProjectL_Common_MissionComponentCommon.<>f__mg$cache4F == null)
		{
			Lua_BlackJack_ProjectL_Common_MissionComponentCommon.<>f__mg$cache4F = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_MissionComponentCommon.OnAddHeroNumsCallBack);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_MissionComponentCommon.<>f__mg$cache4F);
		if (Lua_BlackJack_ProjectL_Common_MissionComponentCommon.<>f__mg$cache50 == null)
		{
			Lua_BlackJack_ProjectL_Common_MissionComponentCommon.<>f__mg$cache50 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_MissionComponentCommon.OnHasAboveLevelHeroNumsCallBack);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_MissionComponentCommon.<>f__mg$cache50);
		if (Lua_BlackJack_ProjectL_Common_MissionComponentCommon.<>f__mg$cache51 == null)
		{
			Lua_BlackJack_ProjectL_Common_MissionComponentCommon.<>f__mg$cache51 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_MissionComponentCommon.OnLevelUpPlayerLevelCallBack);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_MissionComponentCommon.<>f__mg$cache51);
		if (Lua_BlackJack_ProjectL_Common_MissionComponentCommon.<>f__mg$cache52 == null)
		{
			Lua_BlackJack_ProjectL_Common_MissionComponentCommon.<>f__mg$cache52 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_MissionComponentCommon.OnUseCrystalBuyEnergyCallBack);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_MissionComponentCommon.<>f__mg$cache52);
		if (Lua_BlackJack_ProjectL_Common_MissionComponentCommon.<>f__mg$cache53 == null)
		{
			Lua_BlackJack_ProjectL_Common_MissionComponentCommon.<>f__mg$cache53 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_MissionComponentCommon.OnLoginGameCallBack);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_MissionComponentCommon.<>f__mg$cache53);
		if (Lua_BlackJack_ProjectL_Common_MissionComponentCommon.<>f__mg$cache54 == null)
		{
			Lua_BlackJack_ProjectL_Common_MissionComponentCommon.<>f__mg$cache54 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_MissionComponentCommon.OnNewHeroJobTransferCallBack);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_MissionComponentCommon.<>f__mg$cache54);
		if (Lua_BlackJack_ProjectL_Common_MissionComponentCommon.<>f__mg$cache55 == null)
		{
			Lua_BlackJack_ProjectL_Common_MissionComponentCommon.<>f__mg$cache55 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_MissionComponentCommon.OnSpecificHeroFight);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_MissionComponentCommon.<>f__mg$cache55);
		if (Lua_BlackJack_ProjectL_Common_MissionComponentCommon.<>f__mg$cache56 == null)
		{
			Lua_BlackJack_ProjectL_Common_MissionComponentCommon.<>f__mg$cache56 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_MissionComponentCommon.OnSpecificHeroLevelUp);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_MissionComponentCommon.<>f__mg$cache56);
		if (Lua_BlackJack_ProjectL_Common_MissionComponentCommon.<>f__mg$cache57 == null)
		{
			Lua_BlackJack_ProjectL_Common_MissionComponentCommon.<>f__mg$cache57 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_MissionComponentCommon.OnTrainingTechToLevelCallBack);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_MissionComponentCommon.<>f__mg$cache57);
		if (Lua_BlackJack_ProjectL_Common_MissionComponentCommon.<>f__mg$cache58 == null)
		{
			Lua_BlackJack_ProjectL_Common_MissionComponentCommon.<>f__mg$cache58 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_MissionComponentCommon.OnEquipmentToLevelCallBack);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_MissionComponentCommon.<>f__mg$cache58);
		if (Lua_BlackJack_ProjectL_Common_MissionComponentCommon.<>f__mg$cache59 == null)
		{
			Lua_BlackJack_ProjectL_Common_MissionComponentCommon.<>f__mg$cache59 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_MissionComponentCommon.OnFinishTeamBattleCallBack);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_MissionComponentCommon.<>f__mg$cache59);
		if (Lua_BlackJack_ProjectL_Common_MissionComponentCommon.<>f__mg$cache5A == null)
		{
			Lua_BlackJack_ProjectL_Common_MissionComponentCommon.<>f__mg$cache5A = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_MissionComponentCommon.OnFavorabilityToLevelCallBack);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_MissionComponentCommon.<>f__mg$cache5A);
		if (Lua_BlackJack_ProjectL_Common_MissionComponentCommon.<>f__mg$cache5B == null)
		{
			Lua_BlackJack_ProjectL_Common_MissionComponentCommon.<>f__mg$cache5B = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_MissionComponentCommon.OnFetterToLevelCallBack);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_MissionComponentCommon.<>f__mg$cache5B);
		if (Lua_BlackJack_ProjectL_Common_MissionComponentCommon.<>f__mg$cache5C == null)
		{
			Lua_BlackJack_ProjectL_Common_MissionComponentCommon.<>f__mg$cache5C = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_MissionComponentCommon.OnEnchantPropertiesSaveCallBack);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_MissionComponentCommon.<>f__mg$cache5C);
		if (Lua_BlackJack_ProjectL_Common_MissionComponentCommon.<>f__mg$cache5D == null)
		{
			Lua_BlackJack_ProjectL_Common_MissionComponentCommon.<>f__mg$cache5D = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_MissionComponentCommon.OnEnchantEquipmentCallBack);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_MissionComponentCommon.<>f__mg$cache5D);
		if (Lua_BlackJack_ProjectL_Common_MissionComponentCommon.<>f__mg$cache5E == null)
		{
			Lua_BlackJack_ProjectL_Common_MissionComponentCommon.<>f__mg$cache5E = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_MissionComponentCommon.OnTotalHeroJobLevelUpCallBack);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_MissionComponentCommon.<>f__mg$cache5E);
		if (Lua_BlackJack_ProjectL_Common_MissionComponentCommon.<>f__mg$cache5F == null)
		{
			Lua_BlackJack_ProjectL_Common_MissionComponentCommon.<>f__mg$cache5F = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_MissionComponentCommon.OnInviteFriendCallBack);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_MissionComponentCommon.<>f__mg$cache5F);
		if (Lua_BlackJack_ProjectL_Common_MissionComponentCommon.<>f__mg$cache60 == null)
		{
			Lua_BlackJack_ProjectL_Common_MissionComponentCommon.<>f__mg$cache60 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_MissionComponentCommon.OnAssignHeroToTaskCallBack);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_MissionComponentCommon.<>f__mg$cache60);
		if (Lua_BlackJack_ProjectL_Common_MissionComponentCommon.<>f__mg$cache61 == null)
		{
			Lua_BlackJack_ProjectL_Common_MissionComponentCommon.<>f__mg$cache61 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_MissionComponentCommon.OnBattlePracticeCallBack);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_MissionComponentCommon.<>f__mg$cache61);
		if (Lua_BlackJack_ProjectL_Common_MissionComponentCommon.<>f__mg$cache62 == null)
		{
			Lua_BlackJack_ProjectL_Common_MissionComponentCommon.<>f__mg$cache62 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_MissionComponentCommon.OnRealTimeArenaBattleStartCallBack);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_MissionComponentCommon.<>f__mg$cache62);
		if (Lua_BlackJack_ProjectL_Common_MissionComponentCommon.<>f__mg$cache63 == null)
		{
			Lua_BlackJack_ProjectL_Common_MissionComponentCommon.<>f__mg$cache63 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_MissionComponentCommon.OnRealTimeArenaBattleFinishCallBack);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_MissionComponentCommon.<>f__mg$cache63);
		if (Lua_BlackJack_ProjectL_Common_MissionComponentCommon.<>f__mg$cache64 == null)
		{
			Lua_BlackJack_ProjectL_Common_MissionComponentCommon.<>f__mg$cache64 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_MissionComponentCommon.OnRealTimeArenaDanUpdateCallBack);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_MissionComponentCommon.<>f__mg$cache64);
		if (Lua_BlackJack_ProjectL_Common_MissionComponentCommon.<>f__mg$cache65 == null)
		{
			Lua_BlackJack_ProjectL_Common_MissionComponentCommon.<>f__mg$cache65 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_MissionComponentCommon.OnBuyGiftStoreGoodsCallBack);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_MissionComponentCommon.<>f__mg$cache65);
		if (Lua_BlackJack_ProjectL_Common_MissionComponentCommon.<>f__mg$cache66 == null)
		{
			Lua_BlackJack_ProjectL_Common_MissionComponentCommon.<>f__mg$cache66 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_MissionComponentCommon.OnBuyRechargeStoreGoodsCallBack);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_MissionComponentCommon.<>f__mg$cache66);
		if (Lua_BlackJack_ProjectL_Common_MissionComponentCommon.<>f__mg$cache67 == null)
		{
			Lua_BlackJack_ProjectL_Common_MissionComponentCommon.<>f__mg$cache67 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_MissionComponentCommon.OnDoShareCallBack);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_MissionComponentCommon.<>f__mg$cache67);
		string name = "m_lockedMissionConfigsInLogic";
		if (Lua_BlackJack_ProjectL_Common_MissionComponentCommon.<>f__mg$cache68 == null)
		{
			Lua_BlackJack_ProjectL_Common_MissionComponentCommon.<>f__mg$cache68 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_MissionComponentCommon.get_m_lockedMissionConfigsInLogic);
		}
		LuaCSFunction get = Lua_BlackJack_ProjectL_Common_MissionComponentCommon.<>f__mg$cache68;
		if (Lua_BlackJack_ProjectL_Common_MissionComponentCommon.<>f__mg$cache69 == null)
		{
			Lua_BlackJack_ProjectL_Common_MissionComponentCommon.<>f__mg$cache69 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_MissionComponentCommon.set_m_lockedMissionConfigsInLogic);
		}
		LuaObject.addMember(l, name, get, Lua_BlackJack_ProjectL_Common_MissionComponentCommon.<>f__mg$cache69, true);
		string name2 = "m_existMissions";
		if (Lua_BlackJack_ProjectL_Common_MissionComponentCommon.<>f__mg$cache6A == null)
		{
			Lua_BlackJack_ProjectL_Common_MissionComponentCommon.<>f__mg$cache6A = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_MissionComponentCommon.get_m_existMissions);
		}
		LuaCSFunction get2 = Lua_BlackJack_ProjectL_Common_MissionComponentCommon.<>f__mg$cache6A;
		if (Lua_BlackJack_ProjectL_Common_MissionComponentCommon.<>f__mg$cache6B == null)
		{
			Lua_BlackJack_ProjectL_Common_MissionComponentCommon.<>f__mg$cache6B = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_MissionComponentCommon.set_m_existMissions);
		}
		LuaObject.addMember(l, name2, get2, Lua_BlackJack_ProjectL_Common_MissionComponentCommon.<>f__mg$cache6B, true);
		string name3 = "m_missionDS";
		if (Lua_BlackJack_ProjectL_Common_MissionComponentCommon.<>f__mg$cache6C == null)
		{
			Lua_BlackJack_ProjectL_Common_MissionComponentCommon.<>f__mg$cache6C = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_MissionComponentCommon.get_m_missionDS);
		}
		LuaCSFunction get3 = Lua_BlackJack_ProjectL_Common_MissionComponentCommon.<>f__mg$cache6C;
		if (Lua_BlackJack_ProjectL_Common_MissionComponentCommon.<>f__mg$cache6D == null)
		{
			Lua_BlackJack_ProjectL_Common_MissionComponentCommon.<>f__mg$cache6D = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_MissionComponentCommon.set_m_missionDS);
		}
		LuaObject.addMember(l, name3, get3, Lua_BlackJack_ProjectL_Common_MissionComponentCommon.<>f__mg$cache6D, true);
		string name4 = "m_configDataLoader";
		if (Lua_BlackJack_ProjectL_Common_MissionComponentCommon.<>f__mg$cache6E == null)
		{
			Lua_BlackJack_ProjectL_Common_MissionComponentCommon.<>f__mg$cache6E = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_MissionComponentCommon.get_m_configDataLoader);
		}
		LuaCSFunction get4 = Lua_BlackJack_ProjectL_Common_MissionComponentCommon.<>f__mg$cache6E;
		if (Lua_BlackJack_ProjectL_Common_MissionComponentCommon.<>f__mg$cache6F == null)
		{
			Lua_BlackJack_ProjectL_Common_MissionComponentCommon.<>f__mg$cache6F = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_MissionComponentCommon.set_m_configDataLoader);
		}
		LuaObject.addMember(l, name4, get4, Lua_BlackJack_ProjectL_Common_MissionComponentCommon.<>f__mg$cache6F, true);
		string name5 = "m_basicInfo";
		if (Lua_BlackJack_ProjectL_Common_MissionComponentCommon.<>f__mg$cache70 == null)
		{
			Lua_BlackJack_ProjectL_Common_MissionComponentCommon.<>f__mg$cache70 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_MissionComponentCommon.get_m_basicInfo);
		}
		LuaCSFunction get5 = Lua_BlackJack_ProjectL_Common_MissionComponentCommon.<>f__mg$cache70;
		if (Lua_BlackJack_ProjectL_Common_MissionComponentCommon.<>f__mg$cache71 == null)
		{
			Lua_BlackJack_ProjectL_Common_MissionComponentCommon.<>f__mg$cache71 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_MissionComponentCommon.set_m_basicInfo);
		}
		LuaObject.addMember(l, name5, get5, Lua_BlackJack_ProjectL_Common_MissionComponentCommon.<>f__mg$cache71, true);
		string name6 = "m_selectCard";
		if (Lua_BlackJack_ProjectL_Common_MissionComponentCommon.<>f__mg$cache72 == null)
		{
			Lua_BlackJack_ProjectL_Common_MissionComponentCommon.<>f__mg$cache72 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_MissionComponentCommon.get_m_selectCard);
		}
		LuaCSFunction get6 = Lua_BlackJack_ProjectL_Common_MissionComponentCommon.<>f__mg$cache72;
		if (Lua_BlackJack_ProjectL_Common_MissionComponentCommon.<>f__mg$cache73 == null)
		{
			Lua_BlackJack_ProjectL_Common_MissionComponentCommon.<>f__mg$cache73 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_MissionComponentCommon.set_m_selectCard);
		}
		LuaObject.addMember(l, name6, get6, Lua_BlackJack_ProjectL_Common_MissionComponentCommon.<>f__mg$cache73, true);
		string name7 = "m_bag";
		if (Lua_BlackJack_ProjectL_Common_MissionComponentCommon.<>f__mg$cache74 == null)
		{
			Lua_BlackJack_ProjectL_Common_MissionComponentCommon.<>f__mg$cache74 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_MissionComponentCommon.get_m_bag);
		}
		LuaCSFunction get7 = Lua_BlackJack_ProjectL_Common_MissionComponentCommon.<>f__mg$cache74;
		if (Lua_BlackJack_ProjectL_Common_MissionComponentCommon.<>f__mg$cache75 == null)
		{
			Lua_BlackJack_ProjectL_Common_MissionComponentCommon.<>f__mg$cache75 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_MissionComponentCommon.set_m_bag);
		}
		LuaObject.addMember(l, name7, get7, Lua_BlackJack_ProjectL_Common_MissionComponentCommon.<>f__mg$cache75, true);
		string name8 = "m_level";
		if (Lua_BlackJack_ProjectL_Common_MissionComponentCommon.<>f__mg$cache76 == null)
		{
			Lua_BlackJack_ProjectL_Common_MissionComponentCommon.<>f__mg$cache76 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_MissionComponentCommon.get_m_level);
		}
		LuaCSFunction get8 = Lua_BlackJack_ProjectL_Common_MissionComponentCommon.<>f__mg$cache76;
		if (Lua_BlackJack_ProjectL_Common_MissionComponentCommon.<>f__mg$cache77 == null)
		{
			Lua_BlackJack_ProjectL_Common_MissionComponentCommon.<>f__mg$cache77 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_MissionComponentCommon.set_m_level);
		}
		LuaObject.addMember(l, name8, get8, Lua_BlackJack_ProjectL_Common_MissionComponentCommon.<>f__mg$cache77, true);
		string name9 = "m_rift";
		if (Lua_BlackJack_ProjectL_Common_MissionComponentCommon.<>f__mg$cache78 == null)
		{
			Lua_BlackJack_ProjectL_Common_MissionComponentCommon.<>f__mg$cache78 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_MissionComponentCommon.get_m_rift);
		}
		LuaCSFunction get9 = Lua_BlackJack_ProjectL_Common_MissionComponentCommon.<>f__mg$cache78;
		if (Lua_BlackJack_ProjectL_Common_MissionComponentCommon.<>f__mg$cache79 == null)
		{
			Lua_BlackJack_ProjectL_Common_MissionComponentCommon.<>f__mg$cache79 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_MissionComponentCommon.set_m_rift);
		}
		LuaObject.addMember(l, name9, get9, Lua_BlackJack_ProjectL_Common_MissionComponentCommon.<>f__mg$cache79, true);
		string name10 = "m_hero";
		if (Lua_BlackJack_ProjectL_Common_MissionComponentCommon.<>f__mg$cache7A == null)
		{
			Lua_BlackJack_ProjectL_Common_MissionComponentCommon.<>f__mg$cache7A = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_MissionComponentCommon.get_m_hero);
		}
		LuaCSFunction get10 = Lua_BlackJack_ProjectL_Common_MissionComponentCommon.<>f__mg$cache7A;
		if (Lua_BlackJack_ProjectL_Common_MissionComponentCommon.<>f__mg$cache7B == null)
		{
			Lua_BlackJack_ProjectL_Common_MissionComponentCommon.<>f__mg$cache7B = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_MissionComponentCommon.set_m_hero);
		}
		LuaObject.addMember(l, name10, get10, Lua_BlackJack_ProjectL_Common_MissionComponentCommon.<>f__mg$cache7B, true);
		string name11 = "m_thearchyTrial";
		if (Lua_BlackJack_ProjectL_Common_MissionComponentCommon.<>f__mg$cache7C == null)
		{
			Lua_BlackJack_ProjectL_Common_MissionComponentCommon.<>f__mg$cache7C = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_MissionComponentCommon.get_m_thearchyTrial);
		}
		LuaCSFunction get11 = Lua_BlackJack_ProjectL_Common_MissionComponentCommon.<>f__mg$cache7C;
		if (Lua_BlackJack_ProjectL_Common_MissionComponentCommon.<>f__mg$cache7D == null)
		{
			Lua_BlackJack_ProjectL_Common_MissionComponentCommon.<>f__mg$cache7D = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_MissionComponentCommon.set_m_thearchyTrial);
		}
		LuaObject.addMember(l, name11, get11, Lua_BlackJack_ProjectL_Common_MissionComponentCommon.<>f__mg$cache7D, true);
		string name12 = "m_anikiGym";
		if (Lua_BlackJack_ProjectL_Common_MissionComponentCommon.<>f__mg$cache7E == null)
		{
			Lua_BlackJack_ProjectL_Common_MissionComponentCommon.<>f__mg$cache7E = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_MissionComponentCommon.get_m_anikiGym);
		}
		LuaCSFunction get12 = Lua_BlackJack_ProjectL_Common_MissionComponentCommon.<>f__mg$cache7E;
		if (Lua_BlackJack_ProjectL_Common_MissionComponentCommon.<>f__mg$cache7F == null)
		{
			Lua_BlackJack_ProjectL_Common_MissionComponentCommon.<>f__mg$cache7F = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_MissionComponentCommon.set_m_anikiGym);
		}
		LuaObject.addMember(l, name12, get12, Lua_BlackJack_ProjectL_Common_MissionComponentCommon.<>f__mg$cache7F, true);
		string name13 = "m_battle";
		if (Lua_BlackJack_ProjectL_Common_MissionComponentCommon.<>f__mg$cache80 == null)
		{
			Lua_BlackJack_ProjectL_Common_MissionComponentCommon.<>f__mg$cache80 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_MissionComponentCommon.get_m_battle);
		}
		LuaCSFunction get13 = Lua_BlackJack_ProjectL_Common_MissionComponentCommon.<>f__mg$cache80;
		if (Lua_BlackJack_ProjectL_Common_MissionComponentCommon.<>f__mg$cache81 == null)
		{
			Lua_BlackJack_ProjectL_Common_MissionComponentCommon.<>f__mg$cache81 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_MissionComponentCommon.set_m_battle);
		}
		LuaObject.addMember(l, name13, get13, Lua_BlackJack_ProjectL_Common_MissionComponentCommon.<>f__mg$cache81, true);
		string name14 = "m_arena";
		if (Lua_BlackJack_ProjectL_Common_MissionComponentCommon.<>f__mg$cache82 == null)
		{
			Lua_BlackJack_ProjectL_Common_MissionComponentCommon.<>f__mg$cache82 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_MissionComponentCommon.get_m_arena);
		}
		LuaCSFunction get14 = Lua_BlackJack_ProjectL_Common_MissionComponentCommon.<>f__mg$cache82;
		if (Lua_BlackJack_ProjectL_Common_MissionComponentCommon.<>f__mg$cache83 == null)
		{
			Lua_BlackJack_ProjectL_Common_MissionComponentCommon.<>f__mg$cache83 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_MissionComponentCommon.set_m_arena);
		}
		LuaObject.addMember(l, name14, get14, Lua_BlackJack_ProjectL_Common_MissionComponentCommon.<>f__mg$cache83, true);
		string name15 = "m_heroDungeon";
		if (Lua_BlackJack_ProjectL_Common_MissionComponentCommon.<>f__mg$cache84 == null)
		{
			Lua_BlackJack_ProjectL_Common_MissionComponentCommon.<>f__mg$cache84 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_MissionComponentCommon.get_m_heroDungeon);
		}
		LuaCSFunction get15 = Lua_BlackJack_ProjectL_Common_MissionComponentCommon.<>f__mg$cache84;
		if (Lua_BlackJack_ProjectL_Common_MissionComponentCommon.<>f__mg$cache85 == null)
		{
			Lua_BlackJack_ProjectL_Common_MissionComponentCommon.<>f__mg$cache85 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_MissionComponentCommon.set_m_heroDungeon);
		}
		LuaObject.addMember(l, name15, get15, Lua_BlackJack_ProjectL_Common_MissionComponentCommon.<>f__mg$cache85, true);
		string name16 = "m_heroTrainning";
		if (Lua_BlackJack_ProjectL_Common_MissionComponentCommon.<>f__mg$cache86 == null)
		{
			Lua_BlackJack_ProjectL_Common_MissionComponentCommon.<>f__mg$cache86 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_MissionComponentCommon.get_m_heroTrainning);
		}
		LuaCSFunction get16 = Lua_BlackJack_ProjectL_Common_MissionComponentCommon.<>f__mg$cache86;
		if (Lua_BlackJack_ProjectL_Common_MissionComponentCommon.<>f__mg$cache87 == null)
		{
			Lua_BlackJack_ProjectL_Common_MissionComponentCommon.<>f__mg$cache87 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_MissionComponentCommon.set_m_heroTrainning);
		}
		LuaObject.addMember(l, name16, get16, Lua_BlackJack_ProjectL_Common_MissionComponentCommon.<>f__mg$cache87, true);
		string name17 = "m_memoryCorridor";
		if (Lua_BlackJack_ProjectL_Common_MissionComponentCommon.<>f__mg$cache88 == null)
		{
			Lua_BlackJack_ProjectL_Common_MissionComponentCommon.<>f__mg$cache88 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_MissionComponentCommon.get_m_memoryCorridor);
		}
		LuaCSFunction get17 = Lua_BlackJack_ProjectL_Common_MissionComponentCommon.<>f__mg$cache88;
		if (Lua_BlackJack_ProjectL_Common_MissionComponentCommon.<>f__mg$cache89 == null)
		{
			Lua_BlackJack_ProjectL_Common_MissionComponentCommon.<>f__mg$cache89 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_MissionComponentCommon.set_m_memoryCorridor);
		}
		LuaObject.addMember(l, name17, get17, Lua_BlackJack_ProjectL_Common_MissionComponentCommon.<>f__mg$cache89, true);
		string name18 = "m_treasureMap";
		if (Lua_BlackJack_ProjectL_Common_MissionComponentCommon.<>f__mg$cache8A == null)
		{
			Lua_BlackJack_ProjectL_Common_MissionComponentCommon.<>f__mg$cache8A = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_MissionComponentCommon.get_m_treasureMap);
		}
		LuaCSFunction get18 = Lua_BlackJack_ProjectL_Common_MissionComponentCommon.<>f__mg$cache8A;
		if (Lua_BlackJack_ProjectL_Common_MissionComponentCommon.<>f__mg$cache8B == null)
		{
			Lua_BlackJack_ProjectL_Common_MissionComponentCommon.<>f__mg$cache8B = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_MissionComponentCommon.set_m_treasureMap);
		}
		LuaObject.addMember(l, name18, get18, Lua_BlackJack_ProjectL_Common_MissionComponentCommon.<>f__mg$cache8B, true);
		string name19 = "m_heroPhantom";
		if (Lua_BlackJack_ProjectL_Common_MissionComponentCommon.<>f__mg$cache8C == null)
		{
			Lua_BlackJack_ProjectL_Common_MissionComponentCommon.<>f__mg$cache8C = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_MissionComponentCommon.get_m_heroPhantom);
		}
		LuaCSFunction get19 = Lua_BlackJack_ProjectL_Common_MissionComponentCommon.<>f__mg$cache8C;
		if (Lua_BlackJack_ProjectL_Common_MissionComponentCommon.<>f__mg$cache8D == null)
		{
			Lua_BlackJack_ProjectL_Common_MissionComponentCommon.<>f__mg$cache8D = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_MissionComponentCommon.set_m_heroPhantom);
		}
		LuaObject.addMember(l, name19, get19, Lua_BlackJack_ProjectL_Common_MissionComponentCommon.<>f__mg$cache8D, true);
		string name20 = "m_cooperateBattle";
		if (Lua_BlackJack_ProjectL_Common_MissionComponentCommon.<>f__mg$cache8E == null)
		{
			Lua_BlackJack_ProjectL_Common_MissionComponentCommon.<>f__mg$cache8E = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_MissionComponentCommon.get_m_cooperateBattle);
		}
		LuaCSFunction get20 = Lua_BlackJack_ProjectL_Common_MissionComponentCommon.<>f__mg$cache8E;
		if (Lua_BlackJack_ProjectL_Common_MissionComponentCommon.<>f__mg$cache8F == null)
		{
			Lua_BlackJack_ProjectL_Common_MissionComponentCommon.<>f__mg$cache8F = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_MissionComponentCommon.set_m_cooperateBattle);
		}
		LuaObject.addMember(l, name20, get20, Lua_BlackJack_ProjectL_Common_MissionComponentCommon.<>f__mg$cache8F, true);
		string name21 = "m_trainingGround";
		if (Lua_BlackJack_ProjectL_Common_MissionComponentCommon.<>f__mg$cache90 == null)
		{
			Lua_BlackJack_ProjectL_Common_MissionComponentCommon.<>f__mg$cache90 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_MissionComponentCommon.get_m_trainingGround);
		}
		LuaCSFunction get21 = Lua_BlackJack_ProjectL_Common_MissionComponentCommon.<>f__mg$cache90;
		if (Lua_BlackJack_ProjectL_Common_MissionComponentCommon.<>f__mg$cache91 == null)
		{
			Lua_BlackJack_ProjectL_Common_MissionComponentCommon.<>f__mg$cache91 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_MissionComponentCommon.set_m_trainingGround);
		}
		LuaObject.addMember(l, name21, get21, Lua_BlackJack_ProjectL_Common_MissionComponentCommon.<>f__mg$cache91, true);
		string name22 = "m_team";
		if (Lua_BlackJack_ProjectL_Common_MissionComponentCommon.<>f__mg$cache92 == null)
		{
			Lua_BlackJack_ProjectL_Common_MissionComponentCommon.<>f__mg$cache92 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_MissionComponentCommon.get_m_team);
		}
		LuaCSFunction get22 = Lua_BlackJack_ProjectL_Common_MissionComponentCommon.<>f__mg$cache92;
		if (Lua_BlackJack_ProjectL_Common_MissionComponentCommon.<>f__mg$cache93 == null)
		{
			Lua_BlackJack_ProjectL_Common_MissionComponentCommon.<>f__mg$cache93 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_MissionComponentCommon.set_m_team);
		}
		LuaObject.addMember(l, name22, get22, Lua_BlackJack_ProjectL_Common_MissionComponentCommon.<>f__mg$cache93, true);
		string name23 = "m_novice";
		if (Lua_BlackJack_ProjectL_Common_MissionComponentCommon.<>f__mg$cache94 == null)
		{
			Lua_BlackJack_ProjectL_Common_MissionComponentCommon.<>f__mg$cache94 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_MissionComponentCommon.get_m_novice);
		}
		LuaCSFunction get23 = Lua_BlackJack_ProjectL_Common_MissionComponentCommon.<>f__mg$cache94;
		if (Lua_BlackJack_ProjectL_Common_MissionComponentCommon.<>f__mg$cache95 == null)
		{
			Lua_BlackJack_ProjectL_Common_MissionComponentCommon.<>f__mg$cache95 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_MissionComponentCommon.set_m_novice);
		}
		LuaObject.addMember(l, name23, get23, Lua_BlackJack_ProjectL_Common_MissionComponentCommon.<>f__mg$cache95, true);
		string name24 = "m_friend";
		if (Lua_BlackJack_ProjectL_Common_MissionComponentCommon.<>f__mg$cache96 == null)
		{
			Lua_BlackJack_ProjectL_Common_MissionComponentCommon.<>f__mg$cache96 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_MissionComponentCommon.get_m_friend);
		}
		LuaCSFunction get24 = Lua_BlackJack_ProjectL_Common_MissionComponentCommon.<>f__mg$cache96;
		if (Lua_BlackJack_ProjectL_Common_MissionComponentCommon.<>f__mg$cache97 == null)
		{
			Lua_BlackJack_ProjectL_Common_MissionComponentCommon.<>f__mg$cache97 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_MissionComponentCommon.set_m_friend);
		}
		LuaObject.addMember(l, name24, get24, Lua_BlackJack_ProjectL_Common_MissionComponentCommon.<>f__mg$cache97, true);
		string name25 = "m_heroAssistants";
		if (Lua_BlackJack_ProjectL_Common_MissionComponentCommon.<>f__mg$cache98 == null)
		{
			Lua_BlackJack_ProjectL_Common_MissionComponentCommon.<>f__mg$cache98 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_MissionComponentCommon.get_m_heroAssistants);
		}
		LuaCSFunction get25 = Lua_BlackJack_ProjectL_Common_MissionComponentCommon.<>f__mg$cache98;
		if (Lua_BlackJack_ProjectL_Common_MissionComponentCommon.<>f__mg$cache99 == null)
		{
			Lua_BlackJack_ProjectL_Common_MissionComponentCommon.<>f__mg$cache99 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_MissionComponentCommon.set_m_heroAssistants);
		}
		LuaObject.addMember(l, name25, get25, Lua_BlackJack_ProjectL_Common_MissionComponentCommon.<>f__mg$cache99, true);
		string name26 = "m_resource";
		if (Lua_BlackJack_ProjectL_Common_MissionComponentCommon.<>f__mg$cache9A == null)
		{
			Lua_BlackJack_ProjectL_Common_MissionComponentCommon.<>f__mg$cache9A = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_MissionComponentCommon.get_m_resource);
		}
		LuaCSFunction get26 = Lua_BlackJack_ProjectL_Common_MissionComponentCommon.<>f__mg$cache9A;
		if (Lua_BlackJack_ProjectL_Common_MissionComponentCommon.<>f__mg$cache9B == null)
		{
			Lua_BlackJack_ProjectL_Common_MissionComponentCommon.<>f__mg$cache9B = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_MissionComponentCommon.set_m_resource);
		}
		LuaObject.addMember(l, name26, get26, Lua_BlackJack_ProjectL_Common_MissionComponentCommon.<>f__mg$cache9B, true);
		string name27 = "m_realTimePvp";
		if (Lua_BlackJack_ProjectL_Common_MissionComponentCommon.<>f__mg$cache9C == null)
		{
			Lua_BlackJack_ProjectL_Common_MissionComponentCommon.<>f__mg$cache9C = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_MissionComponentCommon.get_m_realTimePvp);
		}
		LuaCSFunction get27 = Lua_BlackJack_ProjectL_Common_MissionComponentCommon.<>f__mg$cache9C;
		if (Lua_BlackJack_ProjectL_Common_MissionComponentCommon.<>f__mg$cache9D == null)
		{
			Lua_BlackJack_ProjectL_Common_MissionComponentCommon.<>f__mg$cache9D = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_MissionComponentCommon.set_m_realTimePvp);
		}
		LuaObject.addMember(l, name27, get27, Lua_BlackJack_ProjectL_Common_MissionComponentCommon.<>f__mg$cache9D, true);
		string name28 = "m_giftStore";
		if (Lua_BlackJack_ProjectL_Common_MissionComponentCommon.<>f__mg$cache9E == null)
		{
			Lua_BlackJack_ProjectL_Common_MissionComponentCommon.<>f__mg$cache9E = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_MissionComponentCommon.get_m_giftStore);
		}
		LuaCSFunction get28 = Lua_BlackJack_ProjectL_Common_MissionComponentCommon.<>f__mg$cache9E;
		if (Lua_BlackJack_ProjectL_Common_MissionComponentCommon.<>f__mg$cache9F == null)
		{
			Lua_BlackJack_ProjectL_Common_MissionComponentCommon.<>f__mg$cache9F = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_MissionComponentCommon.set_m_giftStore);
		}
		LuaObject.addMember(l, name28, get28, Lua_BlackJack_ProjectL_Common_MissionComponentCommon.<>f__mg$cache9F, true);
		string name29 = "m_rechargeStore";
		if (Lua_BlackJack_ProjectL_Common_MissionComponentCommon.<>f__mg$cacheA0 == null)
		{
			Lua_BlackJack_ProjectL_Common_MissionComponentCommon.<>f__mg$cacheA0 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_MissionComponentCommon.get_m_rechargeStore);
		}
		LuaCSFunction get29 = Lua_BlackJack_ProjectL_Common_MissionComponentCommon.<>f__mg$cacheA0;
		if (Lua_BlackJack_ProjectL_Common_MissionComponentCommon.<>f__mg$cacheA1 == null)
		{
			Lua_BlackJack_ProjectL_Common_MissionComponentCommon.<>f__mg$cacheA1 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_MissionComponentCommon.set_m_rechargeStore);
		}
		LuaObject.addMember(l, name29, get29, Lua_BlackJack_ProjectL_Common_MissionComponentCommon.<>f__mg$cacheA1, true);
		string name30 = "Owner";
		if (Lua_BlackJack_ProjectL_Common_MissionComponentCommon.<>f__mg$cacheA2 == null)
		{
			Lua_BlackJack_ProjectL_Common_MissionComponentCommon.<>f__mg$cacheA2 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_MissionComponentCommon.get_Owner);
		}
		LuaCSFunction get30 = Lua_BlackJack_ProjectL_Common_MissionComponentCommon.<>f__mg$cacheA2;
		if (Lua_BlackJack_ProjectL_Common_MissionComponentCommon.<>f__mg$cacheA3 == null)
		{
			Lua_BlackJack_ProjectL_Common_MissionComponentCommon.<>f__mg$cacheA3 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_MissionComponentCommon.set_Owner);
		}
		LuaObject.addMember(l, name30, get30, Lua_BlackJack_ProjectL_Common_MissionComponentCommon.<>f__mg$cacheA3, true);
		if (Lua_BlackJack_ProjectL_Common_MissionComponentCommon.<>f__mg$cacheA4 == null)
		{
			Lua_BlackJack_ProjectL_Common_MissionComponentCommon.<>f__mg$cacheA4 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_MissionComponentCommon.constructor);
		}
		LuaObject.createTypeMetatable(l, Lua_BlackJack_ProjectL_Common_MissionComponentCommon.<>f__mg$cacheA4, typeof(MissionComponentCommon));
	}

	// Token: 0x0400EB77 RID: 60279
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache0;

	// Token: 0x0400EB78 RID: 60280
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1;

	// Token: 0x0400EB79 RID: 60281
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2;

	// Token: 0x0400EB7A RID: 60282
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3;

	// Token: 0x0400EB7B RID: 60283
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache4;

	// Token: 0x0400EB7C RID: 60284
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache5;

	// Token: 0x0400EB7D RID: 60285
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache6;

	// Token: 0x0400EB7E RID: 60286
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache7;

	// Token: 0x0400EB7F RID: 60287
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache8;

	// Token: 0x0400EB80 RID: 60288
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache9;

	// Token: 0x0400EB81 RID: 60289
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheA;

	// Token: 0x0400EB82 RID: 60290
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheB;

	// Token: 0x0400EB83 RID: 60291
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheC;

	// Token: 0x0400EB84 RID: 60292
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheD;

	// Token: 0x0400EB85 RID: 60293
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheE;

	// Token: 0x0400EB86 RID: 60294
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheF;

	// Token: 0x0400EB87 RID: 60295
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache10;

	// Token: 0x0400EB88 RID: 60296
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache11;

	// Token: 0x0400EB89 RID: 60297
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache12;

	// Token: 0x0400EB8A RID: 60298
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache13;

	// Token: 0x0400EB8B RID: 60299
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache14;

	// Token: 0x0400EB8C RID: 60300
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache15;

	// Token: 0x0400EB8D RID: 60301
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache16;

	// Token: 0x0400EB8E RID: 60302
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache17;

	// Token: 0x0400EB8F RID: 60303
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache18;

	// Token: 0x0400EB90 RID: 60304
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache19;

	// Token: 0x0400EB91 RID: 60305
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1A;

	// Token: 0x0400EB92 RID: 60306
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1B;

	// Token: 0x0400EB93 RID: 60307
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1C;

	// Token: 0x0400EB94 RID: 60308
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1D;

	// Token: 0x0400EB95 RID: 60309
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1E;

	// Token: 0x0400EB96 RID: 60310
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1F;

	// Token: 0x0400EB97 RID: 60311
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache20;

	// Token: 0x0400EB98 RID: 60312
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache21;

	// Token: 0x0400EB99 RID: 60313
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache22;

	// Token: 0x0400EB9A RID: 60314
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache23;

	// Token: 0x0400EB9B RID: 60315
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache24;

	// Token: 0x0400EB9C RID: 60316
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache25;

	// Token: 0x0400EB9D RID: 60317
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache26;

	// Token: 0x0400EB9E RID: 60318
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache27;

	// Token: 0x0400EB9F RID: 60319
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache28;

	// Token: 0x0400EBA0 RID: 60320
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache29;

	// Token: 0x0400EBA1 RID: 60321
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2A;

	// Token: 0x0400EBA2 RID: 60322
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2B;

	// Token: 0x0400EBA3 RID: 60323
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2C;

	// Token: 0x0400EBA4 RID: 60324
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2D;

	// Token: 0x0400EBA5 RID: 60325
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2E;

	// Token: 0x0400EBA6 RID: 60326
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2F;

	// Token: 0x0400EBA7 RID: 60327
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache30;

	// Token: 0x0400EBA8 RID: 60328
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache31;

	// Token: 0x0400EBA9 RID: 60329
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache32;

	// Token: 0x0400EBAA RID: 60330
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache33;

	// Token: 0x0400EBAB RID: 60331
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache34;

	// Token: 0x0400EBAC RID: 60332
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache35;

	// Token: 0x0400EBAD RID: 60333
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache36;

	// Token: 0x0400EBAE RID: 60334
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache37;

	// Token: 0x0400EBAF RID: 60335
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache38;

	// Token: 0x0400EBB0 RID: 60336
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache39;

	// Token: 0x0400EBB1 RID: 60337
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3A;

	// Token: 0x0400EBB2 RID: 60338
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3B;

	// Token: 0x0400EBB3 RID: 60339
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3C;

	// Token: 0x0400EBB4 RID: 60340
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3D;

	// Token: 0x0400EBB5 RID: 60341
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3E;

	// Token: 0x0400EBB6 RID: 60342
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3F;

	// Token: 0x0400EBB7 RID: 60343
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache40;

	// Token: 0x0400EBB8 RID: 60344
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache41;

	// Token: 0x0400EBB9 RID: 60345
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache42;

	// Token: 0x0400EBBA RID: 60346
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache43;

	// Token: 0x0400EBBB RID: 60347
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache44;

	// Token: 0x0400EBBC RID: 60348
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache45;

	// Token: 0x0400EBBD RID: 60349
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache46;

	// Token: 0x0400EBBE RID: 60350
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache47;

	// Token: 0x0400EBBF RID: 60351
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache48;

	// Token: 0x0400EBC0 RID: 60352
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache49;

	// Token: 0x0400EBC1 RID: 60353
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache4A;

	// Token: 0x0400EBC2 RID: 60354
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache4B;

	// Token: 0x0400EBC3 RID: 60355
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache4C;

	// Token: 0x0400EBC4 RID: 60356
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache4D;

	// Token: 0x0400EBC5 RID: 60357
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache4E;

	// Token: 0x0400EBC6 RID: 60358
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache4F;

	// Token: 0x0400EBC7 RID: 60359
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache50;

	// Token: 0x0400EBC8 RID: 60360
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache51;

	// Token: 0x0400EBC9 RID: 60361
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache52;

	// Token: 0x0400EBCA RID: 60362
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache53;

	// Token: 0x0400EBCB RID: 60363
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache54;

	// Token: 0x0400EBCC RID: 60364
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache55;

	// Token: 0x0400EBCD RID: 60365
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache56;

	// Token: 0x0400EBCE RID: 60366
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache57;

	// Token: 0x0400EBCF RID: 60367
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache58;

	// Token: 0x0400EBD0 RID: 60368
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache59;

	// Token: 0x0400EBD1 RID: 60369
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache5A;

	// Token: 0x0400EBD2 RID: 60370
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache5B;

	// Token: 0x0400EBD3 RID: 60371
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache5C;

	// Token: 0x0400EBD4 RID: 60372
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache5D;

	// Token: 0x0400EBD5 RID: 60373
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache5E;

	// Token: 0x0400EBD6 RID: 60374
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache5F;

	// Token: 0x0400EBD7 RID: 60375
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache60;

	// Token: 0x0400EBD8 RID: 60376
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache61;

	// Token: 0x0400EBD9 RID: 60377
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache62;

	// Token: 0x0400EBDA RID: 60378
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache63;

	// Token: 0x0400EBDB RID: 60379
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache64;

	// Token: 0x0400EBDC RID: 60380
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache65;

	// Token: 0x0400EBDD RID: 60381
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache66;

	// Token: 0x0400EBDE RID: 60382
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache67;

	// Token: 0x0400EBDF RID: 60383
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache68;

	// Token: 0x0400EBE0 RID: 60384
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache69;

	// Token: 0x0400EBE1 RID: 60385
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache6A;

	// Token: 0x0400EBE2 RID: 60386
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache6B;

	// Token: 0x0400EBE3 RID: 60387
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache6C;

	// Token: 0x0400EBE4 RID: 60388
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache6D;

	// Token: 0x0400EBE5 RID: 60389
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache6E;

	// Token: 0x0400EBE6 RID: 60390
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache6F;

	// Token: 0x0400EBE7 RID: 60391
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache70;

	// Token: 0x0400EBE8 RID: 60392
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache71;

	// Token: 0x0400EBE9 RID: 60393
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache72;

	// Token: 0x0400EBEA RID: 60394
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache73;

	// Token: 0x0400EBEB RID: 60395
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache74;

	// Token: 0x0400EBEC RID: 60396
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache75;

	// Token: 0x0400EBED RID: 60397
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache76;

	// Token: 0x0400EBEE RID: 60398
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache77;

	// Token: 0x0400EBEF RID: 60399
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache78;

	// Token: 0x0400EBF0 RID: 60400
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache79;

	// Token: 0x0400EBF1 RID: 60401
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache7A;

	// Token: 0x0400EBF2 RID: 60402
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache7B;

	// Token: 0x0400EBF3 RID: 60403
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache7C;

	// Token: 0x0400EBF4 RID: 60404
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache7D;

	// Token: 0x0400EBF5 RID: 60405
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache7E;

	// Token: 0x0400EBF6 RID: 60406
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache7F;

	// Token: 0x0400EBF7 RID: 60407
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache80;

	// Token: 0x0400EBF8 RID: 60408
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache81;

	// Token: 0x0400EBF9 RID: 60409
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache82;

	// Token: 0x0400EBFA RID: 60410
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache83;

	// Token: 0x0400EBFB RID: 60411
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache84;

	// Token: 0x0400EBFC RID: 60412
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache85;

	// Token: 0x0400EBFD RID: 60413
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache86;

	// Token: 0x0400EBFE RID: 60414
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache87;

	// Token: 0x0400EBFF RID: 60415
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache88;

	// Token: 0x0400EC00 RID: 60416
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache89;

	// Token: 0x0400EC01 RID: 60417
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache8A;

	// Token: 0x0400EC02 RID: 60418
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache8B;

	// Token: 0x0400EC03 RID: 60419
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache8C;

	// Token: 0x0400EC04 RID: 60420
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache8D;

	// Token: 0x0400EC05 RID: 60421
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache8E;

	// Token: 0x0400EC06 RID: 60422
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache8F;

	// Token: 0x0400EC07 RID: 60423
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache90;

	// Token: 0x0400EC08 RID: 60424
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache91;

	// Token: 0x0400EC09 RID: 60425
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache92;

	// Token: 0x0400EC0A RID: 60426
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache93;

	// Token: 0x0400EC0B RID: 60427
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache94;

	// Token: 0x0400EC0C RID: 60428
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache95;

	// Token: 0x0400EC0D RID: 60429
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache96;

	// Token: 0x0400EC0E RID: 60430
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache97;

	// Token: 0x0400EC0F RID: 60431
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache98;

	// Token: 0x0400EC10 RID: 60432
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache99;

	// Token: 0x0400EC11 RID: 60433
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache9A;

	// Token: 0x0400EC12 RID: 60434
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache9B;

	// Token: 0x0400EC13 RID: 60435
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache9C;

	// Token: 0x0400EC14 RID: 60436
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache9D;

	// Token: 0x0400EC15 RID: 60437
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache9E;

	// Token: 0x0400EC16 RID: 60438
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache9F;

	// Token: 0x0400EC17 RID: 60439
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheA0;

	// Token: 0x0400EC18 RID: 60440
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheA1;

	// Token: 0x0400EC19 RID: 60441
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheA2;

	// Token: 0x0400EC1A RID: 60442
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheA3;

	// Token: 0x0400EC1B RID: 60443
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheA4;
}
