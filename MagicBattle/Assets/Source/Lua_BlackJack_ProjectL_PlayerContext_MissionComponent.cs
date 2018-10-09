using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using BlackJack.ConfigData;
using BlackJack.ProjectL.Common;
using BlackJack.ProjectL.PlayerContext;
using BlackJack.ProjectL.Protocol;
using SLua;
using UnityEngine.Scripting;

// Token: 0x020012D2 RID: 4818
[Preserve]
public class Lua_BlackJack_ProjectL_PlayerContext_MissionComponent : LuaObject
{
	// Token: 0x060196C3 RID: 104131 RVA: 0x007518BC File Offset: 0x0074FABC
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int constructor(IntPtr l)
	{
		int result;
		try
		{
			MissionComponent o = new MissionComponent();
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

	// Token: 0x060196C4 RID: 104132 RVA: 0x00751904 File Offset: 0x0074FB04
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int Init(IntPtr l)
	{
		int result;
		try
		{
			MissionComponent missionComponent = (MissionComponent)LuaObject.checkSelf(l);
			missionComponent.Init();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060196C5 RID: 104133 RVA: 0x00751950 File Offset: 0x0074FB50
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int PostInit(IntPtr l)
	{
		int result;
		try
		{
			MissionComponent missionComponent = (MissionComponent)LuaObject.checkSelf(l);
			missionComponent.PostInit();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060196C6 RID: 104134 RVA: 0x0075199C File Offset: 0x0074FB9C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int DeInit(IntPtr l)
	{
		int result;
		try
		{
			MissionComponent missionComponent = (MissionComponent)LuaObject.checkSelf(l);
			missionComponent.DeInit();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060196C7 RID: 104135 RVA: 0x007519E8 File Offset: 0x0074FBE8
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int DeSerialize(IntPtr l)
	{
		int result;
		try
		{
			MissionComponent missionComponent = (MissionComponent)LuaObject.checkSelf(l);
			DSMissionNtf msg;
			LuaObject.checkType<DSMissionNtf>(l, 2, out msg);
			missionComponent.DeSerialize(msg);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060196C8 RID: 104136 RVA: 0x00751A40 File Offset: 0x0074FC40
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int GetDSVersion(IntPtr l)
	{
		int result;
		try
		{
			MissionComponent missionComponent = (MissionComponent)LuaObject.checkSelf(l);
			ushort dsversion = missionComponent.GetDSVersion();
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

	// Token: 0x060196C9 RID: 104137 RVA: 0x00751A94 File Offset: 0x0074FC94
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int AddMissionById(IntPtr l)
	{
		int result;
		try
		{
			MissionComponent missionComponent = (MissionComponent)LuaObject.checkSelf(l);
			int missionId;
			LuaObject.checkType(l, 2, out missionId);
			missionComponent.AddMissionById(missionId);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060196CA RID: 104138 RVA: 0x00751AEC File Offset: 0x0074FCEC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int GetMissionReward(IntPtr l)
	{
		int result;
		try
		{
			MissionComponent missionComponent = (MissionComponent)LuaObject.checkSelf(l);
			int missionId;
			LuaObject.checkType(l, 2, out missionId);
			int missionReward = missionComponent.GetMissionReward(missionId);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, missionReward);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060196CB RID: 104139 RVA: 0x00751B50 File Offset: 0x0074FD50
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int GetAllProcessingMissionList(IntPtr l)
	{
		int result;
		try
		{
			MissionComponent missionComponent = (MissionComponent)LuaObject.checkSelf(l);
			List<Mission> allProcessingMissionList = missionComponent.GetAllProcessingMissionList();
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, allProcessingMissionList);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060196CC RID: 104140 RVA: 0x00751BA4 File Offset: 0x0074FDA4
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int GetAllCompletedMissionList(IntPtr l)
	{
		int result;
		try
		{
			MissionComponent missionComponent = (MissionComponent)LuaObject.checkSelf(l);
			List<Mission> allCompletedMissionList = missionComponent.GetAllCompletedMissionList();
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, allCompletedMissionList);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060196CD RID: 104141 RVA: 0x00751BF8 File Offset: 0x0074FDF8
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int GetAllFinishedMissionList(IntPtr l)
	{
		int result;
		try
		{
			MissionComponent missionComponent = (MissionComponent)LuaObject.checkSelf(l);
			List<Mission> allFinishedMissionList = missionComponent.GetAllFinishedMissionList();
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, allFinishedMissionList);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060196CE RID: 104142 RVA: 0x00751C4C File Offset: 0x0074FE4C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int CanUnlockMissionInLogicFromInit(IntPtr l)
	{
		int result;
		try
		{
			MissionComponent missionComponent = (MissionComponent)LuaObject.checkSelf(l);
			ConfigDataMissionInfo missionInfo;
			LuaObject.checkType<ConfigDataMissionInfo>(l, 2, out missionInfo);
			bool b = missionComponent.m_luaExportHelper.CanUnlockMissionInLogicFromInit(missionInfo);
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

	// Token: 0x060196CF RID: 104143 RVA: 0x00751CB4 File Offset: 0x0074FEB4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int CanUnlockMissionInUIInterface(IntPtr l)
	{
		int result;
		try
		{
			MissionComponent missionComponent = (MissionComponent)LuaObject.checkSelf(l);
			Mission mission;
			LuaObject.checkType<Mission>(l, 2, out mission);
			bool b = missionComponent.m_luaExportHelper.CanUnlockMissionInUIInterface(mission);
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

	// Token: 0x060196D0 RID: 104144 RVA: 0x00751D1C File Offset: 0x0074FF1C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_GetName(IntPtr l)
	{
		int result;
		try
		{
			MissionComponent missionComponent = (MissionComponent)LuaObject.checkSelf(l);
			string s = missionComponent.m_luaExportHelper.__callBase_GetName();
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

	// Token: 0x060196D1 RID: 104145 RVA: 0x00751D78 File Offset: 0x0074FF78
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_Init(IntPtr l)
	{
		int result;
		try
		{
			MissionComponent missionComponent = (MissionComponent)LuaObject.checkSelf(l);
			missionComponent.m_luaExportHelper.__callBase_Init();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060196D2 RID: 104146 RVA: 0x00751DCC File Offset: 0x0074FFCC
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int __callBase_PostInit(IntPtr l)
	{
		int result;
		try
		{
			MissionComponent missionComponent = (MissionComponent)LuaObject.checkSelf(l);
			missionComponent.m_luaExportHelper.__callBase_PostInit();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060196D3 RID: 104147 RVA: 0x00751E20 File Offset: 0x00750020
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int __callBase_DeInit(IntPtr l)
	{
		int result;
		try
		{
			MissionComponent missionComponent = (MissionComponent)LuaObject.checkSelf(l);
			missionComponent.m_luaExportHelper.__callBase_DeInit();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060196D4 RID: 104148 RVA: 0x00751E74 File Offset: 0x00750074
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_Tick(IntPtr l)
	{
		int result;
		try
		{
			MissionComponent missionComponent = (MissionComponent)LuaObject.checkSelf(l);
			uint deltaMillisecond;
			LuaObject.checkType(l, 2, out deltaMillisecond);
			missionComponent.m_luaExportHelper.__callBase_Tick(deltaMillisecond);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060196D5 RID: 104149 RVA: 0x00751ED0 File Offset: 0x007500D0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_PostDeSerialize(IntPtr l)
	{
		int result;
		try
		{
			MissionComponent missionComponent = (MissionComponent)LuaObject.checkSelf(l);
			missionComponent.m_luaExportHelper.__callBase_PostDeSerialize();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060196D6 RID: 104150 RVA: 0x00751F24 File Offset: 0x00750124
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int __callBase_RemoveProcessingMissionById(IntPtr l)
	{
		int result;
		try
		{
			MissionComponent missionComponent = (MissionComponent)LuaObject.checkSelf(l);
			int missionId;
			LuaObject.checkType(l, 2, out missionId);
			missionComponent.m_luaExportHelper.__callBase_RemoveProcessingMissionById(missionId);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060196D7 RID: 104151 RVA: 0x00751F80 File Offset: 0x00750180
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int __callBase_InitProcessingMission(IntPtr l)
	{
		int result;
		try
		{
			MissionComponent missionComponent = (MissionComponent)LuaObject.checkSelf(l);
			List<Mission> processingMissionList;
			LuaObject.checkType<List<Mission>>(l, 2, out processingMissionList);
			missionComponent.m_luaExportHelper.__callBase_InitProcessingMission(processingMissionList);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060196D8 RID: 104152 RVA: 0x00751FDC File Offset: 0x007501DC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_GetProcessingMissionByMissionType(IntPtr l)
	{
		int result;
		try
		{
			MissionComponent missionComponent = (MissionComponent)LuaObject.checkSelf(l);
			MissionType missionType;
			LuaObject.checkEnum<MissionType>(l, 2, out missionType);
			List<Mission> o = missionComponent.m_luaExportHelper.__callBase_GetProcessingMissionByMissionType(missionType);
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

	// Token: 0x060196D9 RID: 104153 RVA: 0x00752044 File Offset: 0x00750244
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int __callBase_InitExistMissions(IntPtr l)
	{
		int result;
		try
		{
			MissionComponent missionComponent = (MissionComponent)LuaObject.checkSelf(l);
			missionComponent.m_luaExportHelper.__callBase_InitExistMissions();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060196DA RID: 104154 RVA: 0x00752098 File Offset: 0x00750298
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_ResetEverydayMissions(IntPtr l)
	{
		int result;
		try
		{
			MissionComponent missionComponent = (MissionComponent)LuaObject.checkSelf(l);
			missionComponent.m_luaExportHelper.__callBase_ResetEverydayMissions();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060196DB RID: 104155 RVA: 0x007520EC File Offset: 0x007502EC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_InitMissionListByMissionPeriodType(IntPtr l)
	{
		int result;
		try
		{
			MissionComponent missionComponent = (MissionComponent)LuaObject.checkSelf(l);
			MissionPeriodType missionPeriod;
			LuaObject.checkEnum<MissionPeriodType>(l, 2, out missionPeriod);
			missionComponent.m_luaExportHelper.__callBase_InitMissionListByMissionPeriodType(missionPeriod);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060196DC RID: 104156 RVA: 0x00752148 File Offset: 0x00750348
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_CanUnlockMissionInLogicFromInit(IntPtr l)
	{
		int result;
		try
		{
			MissionComponent missionComponent = (MissionComponent)LuaObject.checkSelf(l);
			ConfigDataMissionInfo missionInfo;
			LuaObject.checkType<ConfigDataMissionInfo>(l, 2, out missionInfo);
			bool b = missionComponent.m_luaExportHelper.__callBase_CanUnlockMissionInLogicFromInit(missionInfo);
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

	// Token: 0x060196DD RID: 104157 RVA: 0x007521B0 File Offset: 0x007503B0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_OnDirectActivatedMissionLocked(IntPtr l)
	{
		int result;
		try
		{
			MissionComponent missionComponent = (MissionComponent)LuaObject.checkSelf(l);
			ConfigDataMissionInfo missionConfig;
			LuaObject.checkType<ConfigDataMissionInfo>(l, 2, out missionConfig);
			missionComponent.m_luaExportHelper.__callBase_OnDirectActivatedMissionLocked(missionConfig);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060196DE RID: 104158 RVA: 0x0075220C File Offset: 0x0075040C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_IsNoviceMission(IntPtr l)
	{
		int result;
		try
		{
			int total = LuaDLL.lua_gettop(l);
			if (LuaObject.matchType(l, total, 2, typeof(Mission)))
			{
				MissionComponent missionComponent = (MissionComponent)LuaObject.checkSelf(l);
				Mission mission;
				LuaObject.checkType<Mission>(l, 2, out mission);
				bool b = missionComponent.m_luaExportHelper.__callBase_IsNoviceMission(mission);
				LuaObject.pushValue(l, true);
				LuaObject.pushValue(l, b);
				result = 2;
			}
			else if (LuaObject.matchType(l, total, 2, typeof(ConfigDataMissionInfo)))
			{
				MissionComponent missionComponent2 = (MissionComponent)LuaObject.checkSelf(l);
				ConfigDataMissionInfo mission2;
				LuaObject.checkType<ConfigDataMissionInfo>(l, 2, out mission2);
				bool b2 = missionComponent2.m_luaExportHelper.__callBase_IsNoviceMission(mission2);
				LuaObject.pushValue(l, true);
				LuaObject.pushValue(l, b2);
				result = 2;
			}
			else
			{
				LuaObject.pushValue(l, false);
				LuaDLL.lua_pushstring(l, "No matched override function __callBase_IsNoviceMission to call");
				result = 2;
			}
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060196DF RID: 104159 RVA: 0x00752304 File Offset: 0x00750504
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int __callBase_IsNoviceMissionActivated(IntPtr l)
	{
		int result;
		try
		{
			int total = LuaDLL.lua_gettop(l);
			if (LuaObject.matchType(l, total, 2, typeof(ConfigDataMissionInfo)))
			{
				MissionComponent missionComponent = (MissionComponent)LuaObject.checkSelf(l);
				ConfigDataMissionInfo mission;
				LuaObject.checkType<ConfigDataMissionInfo>(l, 2, out mission);
				bool b = missionComponent.m_luaExportHelper.__callBase_IsNoviceMissionActivated(mission);
				LuaObject.pushValue(l, true);
				LuaObject.pushValue(l, b);
				result = 2;
			}
			else if (LuaObject.matchType(l, total, 2, typeof(Mission)))
			{
				MissionComponent missionComponent2 = (MissionComponent)LuaObject.checkSelf(l);
				Mission mission2;
				LuaObject.checkType<Mission>(l, 2, out mission2);
				bool b2 = missionComponent2.m_luaExportHelper.__callBase_IsNoviceMissionActivated(mission2);
				LuaObject.pushValue(l, true);
				LuaObject.pushValue(l, b2);
				result = 2;
			}
			else
			{
				LuaObject.pushValue(l, false);
				LuaDLL.lua_pushstring(l, "No matched override function __callBase_IsNoviceMissionActivated to call");
				result = 2;
			}
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060196E0 RID: 104160 RVA: 0x007523FC File Offset: 0x007505FC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_IsNoviceMissionActivatedForRewarding(IntPtr l)
	{
		int result;
		try
		{
			MissionComponent missionComponent = (MissionComponent)LuaObject.checkSelf(l);
			ConfigDataMissionInfo mission;
			LuaObject.checkType<ConfigDataMissionInfo>(l, 2, out mission);
			bool b = missionComponent.m_luaExportHelper.__callBase_IsNoviceMissionActivatedForRewarding(mission);
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

	// Token: 0x060196E1 RID: 104161 RVA: 0x00752464 File Offset: 0x00750664
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int __callBase_CanGetRewarding(IntPtr l)
	{
		int result;
		try
		{
			MissionComponent missionComponent = (MissionComponent)LuaObject.checkSelf(l);
			Mission mission;
			LuaObject.checkType<Mission>(l, 2, out mission);
			bool b = missionComponent.m_luaExportHelper.__callBase_CanGetRewarding(mission);
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

	// Token: 0x060196E2 RID: 104162 RVA: 0x007524CC File Offset: 0x007506CC
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int __callBase_CanUnlockMissionInLogic(IntPtr l)
	{
		int result;
		try
		{
			MissionComponent missionComponent = (MissionComponent)LuaObject.checkSelf(l);
			ConfigDataMissionInfo missionConfigInfo;
			LuaObject.checkType<ConfigDataMissionInfo>(l, 2, out missionConfigInfo);
			bool b = missionComponent.m_luaExportHelper.__callBase_CanUnlockMissionInLogic(missionConfigInfo);
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

	// Token: 0x060196E3 RID: 104163 RVA: 0x00752534 File Offset: 0x00750734
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int __callBase_CanUnlockMission(IntPtr l)
	{
		int result;
		try
		{
			MissionComponent missionComponent = (MissionComponent)LuaObject.checkSelf(l);
			ConfigDataMissionInfo missionConfigInfo;
			LuaObject.checkType<ConfigDataMissionInfo>(l, 2, out missionConfigInfo);
			bool b = missionComponent.m_luaExportHelper.__callBase_CanUnlockMission(missionConfigInfo);
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

	// Token: 0x060196E4 RID: 104164 RVA: 0x0075259C File Offset: 0x0075079C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_CaculateDirectlyActivationMissionStatus(IntPtr l)
	{
		int result;
		try
		{
			MissionComponent missionComponent = (MissionComponent)LuaObject.checkSelf(l);
			ConfigDataMissionInfo missionConfigInfo;
			LuaObject.checkType<ConfigDataMissionInfo>(l, 2, out missionConfigInfo);
			DirectlyActivatedMissionSatatus e = missionComponent.m_luaExportHelper.__callBase_CaculateDirectlyActivationMissionStatus(missionConfigInfo);
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

	// Token: 0x060196E5 RID: 104165 RVA: 0x00752604 File Offset: 0x00750804
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int __callBase_AddMission(IntPtr l)
	{
		int result;
		try
		{
			MissionComponent missionComponent = (MissionComponent)LuaObject.checkSelf(l);
			ConfigDataMissionInfo missionInfo;
			LuaObject.checkType<ConfigDataMissionInfo>(l, 2, out missionInfo);
			bool b = missionComponent.m_luaExportHelper.__callBase_AddMission(missionInfo);
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

	// Token: 0x060196E6 RID: 104166 RVA: 0x0075266C File Offset: 0x0075086C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_OnAddProcessingDirectelyActivitedMission(IntPtr l)
	{
		int result;
		try
		{
			MissionComponent missionComponent = (MissionComponent)LuaObject.checkSelf(l);
			Mission mission;
			LuaObject.checkType<Mission>(l, 2, out mission);
			missionComponent.m_luaExportHelper.__callBase_OnAddProcessingDirectelyActivitedMission(mission);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060196E7 RID: 104167 RVA: 0x007526C8 File Offset: 0x007508C8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_GetProcessingMissionByMissionPeriod(IntPtr l)
	{
		int result;
		try
		{
			MissionComponent missionComponent = (MissionComponent)LuaObject.checkSelf(l);
			MissionPeriodType missionPeriodType;
			LuaObject.checkEnum<MissionPeriodType>(l, 2, out missionPeriodType);
			int missionId;
			LuaObject.checkType(l, 3, out missionId);
			Mission o = missionComponent.m_luaExportHelper.__callBase_GetProcessingMissionByMissionPeriod(missionPeriodType, missionId);
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

	// Token: 0x060196E8 RID: 104168 RVA: 0x0075273C File Offset: 0x0075093C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_OnGetProcessingDirectActivationMissionFail(IntPtr l)
	{
		int result;
		try
		{
			MissionComponent missionComponent = (MissionComponent)LuaObject.checkSelf(l);
			Mission mission;
			LuaObject.checkType<Mission>(l, 2, out mission);
			missionComponent.m_luaExportHelper.__callBase_OnGetProcessingDirectActivationMissionFail(mission);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060196E9 RID: 104169 RVA: 0x00752798 File Offset: 0x00750998
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int __callBase_AddOneOffMission(IntPtr l)
	{
		int result;
		try
		{
			MissionComponent missionComponent = (MissionComponent)LuaObject.checkSelf(l);
			Mission mission;
			LuaObject.checkType<Mission>(l, 2, out mission);
			missionComponent.m_luaExportHelper.__callBase_AddOneOffMission(mission);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060196EA RID: 104170 RVA: 0x007527F4 File Offset: 0x007509F4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_IsMissionFinished(IntPtr l)
	{
		int result;
		try
		{
			MissionComponent missionComponent = (MissionComponent)LuaObject.checkSelf(l);
			int missionId;
			LuaObject.checkType(l, 2, out missionId);
			bool b = missionComponent.m_luaExportHelper.__callBase_IsMissionFinished(missionId);
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

	// Token: 0x060196EB RID: 104171 RVA: 0x0075285C File Offset: 0x00750A5C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_InitMissionsFromConfig(IntPtr l)
	{
		int result;
		try
		{
			MissionComponent missionComponent = (MissionComponent)LuaObject.checkSelf(l);
			List<Mission> missions;
			LuaObject.checkType<List<Mission>>(l, 2, out missions);
			missionComponent.m_luaExportHelper.__callBase_InitMissionsFromConfig(missions);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060196EC RID: 104172 RVA: 0x007528B8 File Offset: 0x00750AB8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_FinishMission(IntPtr l)
	{
		int result;
		try
		{
			MissionComponent missionComponent = (MissionComponent)LuaObject.checkSelf(l);
			Mission mission;
			LuaObject.checkType<Mission>(l, 2, out mission);
			missionComponent.m_luaExportHelper.__callBase_FinishMission(mission);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060196ED RID: 104173 RVA: 0x00752914 File Offset: 0x00750B14
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_GetAllProcessingNoviceMissionList(IntPtr l)
	{
		int result;
		try
		{
			MissionComponent missionComponent = (MissionComponent)LuaObject.checkSelf(l);
			List<Mission> o = missionComponent.m_luaExportHelper.__callBase_GetAllProcessingNoviceMissionList();
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

	// Token: 0x060196EE RID: 104174 RVA: 0x00752970 File Offset: 0x00750B70
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_GetAllFinishedNoviceMissionList(IntPtr l)
	{
		int result;
		try
		{
			MissionComponent missionComponent = (MissionComponent)LuaObject.checkSelf(l);
			List<Mission> o = missionComponent.m_luaExportHelper.__callBase_GetAllFinishedNoviceMissionList();
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

	// Token: 0x060196EF RID: 104175 RVA: 0x007529CC File Offset: 0x00750BCC
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int __callBase_AddMissionProcess(IntPtr l)
	{
		int result;
		try
		{
			MissionComponent missionComponent = (MissionComponent)LuaObject.checkSelf(l);
			Mission mission;
			LuaObject.checkType<Mission>(l, 2, out mission);
			long process;
			LuaObject.checkType(l, 3, out process);
			missionComponent.m_luaExportHelper.__callBase_AddMissionProcess(mission, process);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060196F0 RID: 104176 RVA: 0x00752A38 File Offset: 0x00750C38
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_GetMissionMaxProcess(IntPtr l)
	{
		int result;
		try
		{
			MissionComponent missionComponent = (MissionComponent)LuaObject.checkSelf(l);
			Mission mission;
			LuaObject.checkType<Mission>(l, 2, out mission);
			int i = missionComponent.m_luaExportHelper.__callBase_GetMissionMaxProcess(mission);
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

	// Token: 0x060196F1 RID: 104177 RVA: 0x00752AA0 File Offset: 0x00750CA0
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int __callBase_IsMissionProcessFinished(IntPtr l)
	{
		int result;
		try
		{
			MissionComponent missionComponent = (MissionComponent)LuaObject.checkSelf(l);
			int missionId;
			LuaObject.checkType(l, 2, out missionId);
			bool b = missionComponent.m_luaExportHelper.__callBase_IsMissionProcessFinished(missionId);
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

	// Token: 0x060196F2 RID: 104178 RVA: 0x00752B08 File Offset: 0x00750D08
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_CanGainMissionReward(IntPtr l)
	{
		int result;
		try
		{
			MissionComponent missionComponent = (MissionComponent)LuaObject.checkSelf(l);
			int missionId;
			LuaObject.checkType(l, 2, out missionId);
			int i = missionComponent.m_luaExportHelper.__callBase_CanGainMissionReward(missionId);
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

	// Token: 0x060196F3 RID: 104179 RVA: 0x00752B70 File Offset: 0x00750D70
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int __callBase_IsCompleted(IntPtr l)
	{
		int result;
		try
		{
			MissionComponent missionComponent = (MissionComponent)LuaObject.checkSelf(l);
			int missionId;
			LuaObject.checkType(l, 2, out missionId);
			bool b = missionComponent.m_luaExportHelper.__callBase_IsCompleted(missionId);
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

	// Token: 0x060196F4 RID: 104180 RVA: 0x00752BD8 File Offset: 0x00750DD8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_SetStatisticalData(IntPtr l)
	{
		int result;
		try
		{
			MissionComponent missionComponent = (MissionComponent)LuaObject.checkSelf(l);
			StatisticalDataType typeId;
			LuaObject.checkEnum<StatisticalDataType>(l, 2, out typeId);
			long nums;
			LuaObject.checkType(l, 3, out nums);
			missionComponent.m_luaExportHelper.__callBase_SetStatisticalData(typeId, nums);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060196F5 RID: 104181 RVA: 0x00752C44 File Offset: 0x00750E44
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int __callBase_AddStatisticalData(IntPtr l)
	{
		int result;
		try
		{
			MissionComponent missionComponent = (MissionComponent)LuaObject.checkSelf(l);
			StatisticalDataType typeId;
			LuaObject.checkEnum<StatisticalDataType>(l, 2, out typeId);
			int nums;
			LuaObject.checkType(l, 3, out nums);
			missionComponent.m_luaExportHelper.__callBase_AddStatisticalData(typeId, nums);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060196F6 RID: 104182 RVA: 0x00752CB0 File Offset: 0x00750EB0
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int __callBase_GetMissionCompletedProcess(IntPtr l)
	{
		int result;
		try
		{
			MissionComponent missionComponent = (MissionComponent)LuaObject.checkSelf(l);
			Mission mission;
			LuaObject.checkType<Mission>(l, 2, out mission);
			long i = missionComponent.m_luaExportHelper.__callBase_GetMissionCompletedProcess(mission);
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

	// Token: 0x060196F7 RID: 104183 RVA: 0x00752D18 File Offset: 0x00750F18
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int __callBase_OnLoginGameCallBack(IntPtr l)
	{
		int result;
		try
		{
			MissionComponent missionComponent = (MissionComponent)LuaObject.checkSelf(l);
			missionComponent.m_luaExportHelper.__callBase_OnLoginGameCallBack();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060196F8 RID: 104184 RVA: 0x00752D6C File Offset: 0x00750F6C
	[Preserve]
	public static void reg(IntPtr l)
	{
		LuaObject.getTypeTable(l, "BlackJack.ProjectL.PlayerContext.MissionComponent");
		if (Lua_BlackJack_ProjectL_PlayerContext_MissionComponent.<>f__mg$cache0 == null)
		{
			Lua_BlackJack_ProjectL_PlayerContext_MissionComponent.<>f__mg$cache0 = new LuaCSFunction(Lua_BlackJack_ProjectL_PlayerContext_MissionComponent.Init);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_PlayerContext_MissionComponent.<>f__mg$cache0);
		if (Lua_BlackJack_ProjectL_PlayerContext_MissionComponent.<>f__mg$cache1 == null)
		{
			Lua_BlackJack_ProjectL_PlayerContext_MissionComponent.<>f__mg$cache1 = new LuaCSFunction(Lua_BlackJack_ProjectL_PlayerContext_MissionComponent.PostInit);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_PlayerContext_MissionComponent.<>f__mg$cache1);
		if (Lua_BlackJack_ProjectL_PlayerContext_MissionComponent.<>f__mg$cache2 == null)
		{
			Lua_BlackJack_ProjectL_PlayerContext_MissionComponent.<>f__mg$cache2 = new LuaCSFunction(Lua_BlackJack_ProjectL_PlayerContext_MissionComponent.DeInit);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_PlayerContext_MissionComponent.<>f__mg$cache2);
		if (Lua_BlackJack_ProjectL_PlayerContext_MissionComponent.<>f__mg$cache3 == null)
		{
			Lua_BlackJack_ProjectL_PlayerContext_MissionComponent.<>f__mg$cache3 = new LuaCSFunction(Lua_BlackJack_ProjectL_PlayerContext_MissionComponent.DeSerialize);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_PlayerContext_MissionComponent.<>f__mg$cache3);
		if (Lua_BlackJack_ProjectL_PlayerContext_MissionComponent.<>f__mg$cache4 == null)
		{
			Lua_BlackJack_ProjectL_PlayerContext_MissionComponent.<>f__mg$cache4 = new LuaCSFunction(Lua_BlackJack_ProjectL_PlayerContext_MissionComponent.GetDSVersion);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_PlayerContext_MissionComponent.<>f__mg$cache4);
		if (Lua_BlackJack_ProjectL_PlayerContext_MissionComponent.<>f__mg$cache5 == null)
		{
			Lua_BlackJack_ProjectL_PlayerContext_MissionComponent.<>f__mg$cache5 = new LuaCSFunction(Lua_BlackJack_ProjectL_PlayerContext_MissionComponent.AddMissionById);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_PlayerContext_MissionComponent.<>f__mg$cache5);
		if (Lua_BlackJack_ProjectL_PlayerContext_MissionComponent.<>f__mg$cache6 == null)
		{
			Lua_BlackJack_ProjectL_PlayerContext_MissionComponent.<>f__mg$cache6 = new LuaCSFunction(Lua_BlackJack_ProjectL_PlayerContext_MissionComponent.GetMissionReward);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_PlayerContext_MissionComponent.<>f__mg$cache6);
		if (Lua_BlackJack_ProjectL_PlayerContext_MissionComponent.<>f__mg$cache7 == null)
		{
			Lua_BlackJack_ProjectL_PlayerContext_MissionComponent.<>f__mg$cache7 = new LuaCSFunction(Lua_BlackJack_ProjectL_PlayerContext_MissionComponent.GetAllProcessingMissionList);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_PlayerContext_MissionComponent.<>f__mg$cache7);
		if (Lua_BlackJack_ProjectL_PlayerContext_MissionComponent.<>f__mg$cache8 == null)
		{
			Lua_BlackJack_ProjectL_PlayerContext_MissionComponent.<>f__mg$cache8 = new LuaCSFunction(Lua_BlackJack_ProjectL_PlayerContext_MissionComponent.GetAllCompletedMissionList);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_PlayerContext_MissionComponent.<>f__mg$cache8);
		if (Lua_BlackJack_ProjectL_PlayerContext_MissionComponent.<>f__mg$cache9 == null)
		{
			Lua_BlackJack_ProjectL_PlayerContext_MissionComponent.<>f__mg$cache9 = new LuaCSFunction(Lua_BlackJack_ProjectL_PlayerContext_MissionComponent.GetAllFinishedMissionList);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_PlayerContext_MissionComponent.<>f__mg$cache9);
		if (Lua_BlackJack_ProjectL_PlayerContext_MissionComponent.<>f__mg$cacheA == null)
		{
			Lua_BlackJack_ProjectL_PlayerContext_MissionComponent.<>f__mg$cacheA = new LuaCSFunction(Lua_BlackJack_ProjectL_PlayerContext_MissionComponent.CanUnlockMissionInLogicFromInit);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_PlayerContext_MissionComponent.<>f__mg$cacheA);
		if (Lua_BlackJack_ProjectL_PlayerContext_MissionComponent.<>f__mg$cacheB == null)
		{
			Lua_BlackJack_ProjectL_PlayerContext_MissionComponent.<>f__mg$cacheB = new LuaCSFunction(Lua_BlackJack_ProjectL_PlayerContext_MissionComponent.CanUnlockMissionInUIInterface);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_PlayerContext_MissionComponent.<>f__mg$cacheB);
		if (Lua_BlackJack_ProjectL_PlayerContext_MissionComponent.<>f__mg$cacheC == null)
		{
			Lua_BlackJack_ProjectL_PlayerContext_MissionComponent.<>f__mg$cacheC = new LuaCSFunction(Lua_BlackJack_ProjectL_PlayerContext_MissionComponent.__callBase_GetName);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_PlayerContext_MissionComponent.<>f__mg$cacheC);
		if (Lua_BlackJack_ProjectL_PlayerContext_MissionComponent.<>f__mg$cacheD == null)
		{
			Lua_BlackJack_ProjectL_PlayerContext_MissionComponent.<>f__mg$cacheD = new LuaCSFunction(Lua_BlackJack_ProjectL_PlayerContext_MissionComponent.__callBase_Init);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_PlayerContext_MissionComponent.<>f__mg$cacheD);
		if (Lua_BlackJack_ProjectL_PlayerContext_MissionComponent.<>f__mg$cacheE == null)
		{
			Lua_BlackJack_ProjectL_PlayerContext_MissionComponent.<>f__mg$cacheE = new LuaCSFunction(Lua_BlackJack_ProjectL_PlayerContext_MissionComponent.__callBase_PostInit);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_PlayerContext_MissionComponent.<>f__mg$cacheE);
		if (Lua_BlackJack_ProjectL_PlayerContext_MissionComponent.<>f__mg$cacheF == null)
		{
			Lua_BlackJack_ProjectL_PlayerContext_MissionComponent.<>f__mg$cacheF = new LuaCSFunction(Lua_BlackJack_ProjectL_PlayerContext_MissionComponent.__callBase_DeInit);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_PlayerContext_MissionComponent.<>f__mg$cacheF);
		if (Lua_BlackJack_ProjectL_PlayerContext_MissionComponent.<>f__mg$cache10 == null)
		{
			Lua_BlackJack_ProjectL_PlayerContext_MissionComponent.<>f__mg$cache10 = new LuaCSFunction(Lua_BlackJack_ProjectL_PlayerContext_MissionComponent.__callBase_Tick);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_PlayerContext_MissionComponent.<>f__mg$cache10);
		if (Lua_BlackJack_ProjectL_PlayerContext_MissionComponent.<>f__mg$cache11 == null)
		{
			Lua_BlackJack_ProjectL_PlayerContext_MissionComponent.<>f__mg$cache11 = new LuaCSFunction(Lua_BlackJack_ProjectL_PlayerContext_MissionComponent.__callBase_PostDeSerialize);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_PlayerContext_MissionComponent.<>f__mg$cache11);
		if (Lua_BlackJack_ProjectL_PlayerContext_MissionComponent.<>f__mg$cache12 == null)
		{
			Lua_BlackJack_ProjectL_PlayerContext_MissionComponent.<>f__mg$cache12 = new LuaCSFunction(Lua_BlackJack_ProjectL_PlayerContext_MissionComponent.__callBase_RemoveProcessingMissionById);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_PlayerContext_MissionComponent.<>f__mg$cache12);
		if (Lua_BlackJack_ProjectL_PlayerContext_MissionComponent.<>f__mg$cache13 == null)
		{
			Lua_BlackJack_ProjectL_PlayerContext_MissionComponent.<>f__mg$cache13 = new LuaCSFunction(Lua_BlackJack_ProjectL_PlayerContext_MissionComponent.__callBase_InitProcessingMission);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_PlayerContext_MissionComponent.<>f__mg$cache13);
		if (Lua_BlackJack_ProjectL_PlayerContext_MissionComponent.<>f__mg$cache14 == null)
		{
			Lua_BlackJack_ProjectL_PlayerContext_MissionComponent.<>f__mg$cache14 = new LuaCSFunction(Lua_BlackJack_ProjectL_PlayerContext_MissionComponent.__callBase_GetProcessingMissionByMissionType);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_PlayerContext_MissionComponent.<>f__mg$cache14);
		if (Lua_BlackJack_ProjectL_PlayerContext_MissionComponent.<>f__mg$cache15 == null)
		{
			Lua_BlackJack_ProjectL_PlayerContext_MissionComponent.<>f__mg$cache15 = new LuaCSFunction(Lua_BlackJack_ProjectL_PlayerContext_MissionComponent.__callBase_InitExistMissions);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_PlayerContext_MissionComponent.<>f__mg$cache15);
		if (Lua_BlackJack_ProjectL_PlayerContext_MissionComponent.<>f__mg$cache16 == null)
		{
			Lua_BlackJack_ProjectL_PlayerContext_MissionComponent.<>f__mg$cache16 = new LuaCSFunction(Lua_BlackJack_ProjectL_PlayerContext_MissionComponent.__callBase_ResetEverydayMissions);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_PlayerContext_MissionComponent.<>f__mg$cache16);
		if (Lua_BlackJack_ProjectL_PlayerContext_MissionComponent.<>f__mg$cache17 == null)
		{
			Lua_BlackJack_ProjectL_PlayerContext_MissionComponent.<>f__mg$cache17 = new LuaCSFunction(Lua_BlackJack_ProjectL_PlayerContext_MissionComponent.__callBase_InitMissionListByMissionPeriodType);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_PlayerContext_MissionComponent.<>f__mg$cache17);
		if (Lua_BlackJack_ProjectL_PlayerContext_MissionComponent.<>f__mg$cache18 == null)
		{
			Lua_BlackJack_ProjectL_PlayerContext_MissionComponent.<>f__mg$cache18 = new LuaCSFunction(Lua_BlackJack_ProjectL_PlayerContext_MissionComponent.__callBase_CanUnlockMissionInLogicFromInit);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_PlayerContext_MissionComponent.<>f__mg$cache18);
		if (Lua_BlackJack_ProjectL_PlayerContext_MissionComponent.<>f__mg$cache19 == null)
		{
			Lua_BlackJack_ProjectL_PlayerContext_MissionComponent.<>f__mg$cache19 = new LuaCSFunction(Lua_BlackJack_ProjectL_PlayerContext_MissionComponent.__callBase_OnDirectActivatedMissionLocked);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_PlayerContext_MissionComponent.<>f__mg$cache19);
		if (Lua_BlackJack_ProjectL_PlayerContext_MissionComponent.<>f__mg$cache1A == null)
		{
			Lua_BlackJack_ProjectL_PlayerContext_MissionComponent.<>f__mg$cache1A = new LuaCSFunction(Lua_BlackJack_ProjectL_PlayerContext_MissionComponent.__callBase_IsNoviceMission);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_PlayerContext_MissionComponent.<>f__mg$cache1A);
		if (Lua_BlackJack_ProjectL_PlayerContext_MissionComponent.<>f__mg$cache1B == null)
		{
			Lua_BlackJack_ProjectL_PlayerContext_MissionComponent.<>f__mg$cache1B = new LuaCSFunction(Lua_BlackJack_ProjectL_PlayerContext_MissionComponent.__callBase_IsNoviceMissionActivated);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_PlayerContext_MissionComponent.<>f__mg$cache1B);
		if (Lua_BlackJack_ProjectL_PlayerContext_MissionComponent.<>f__mg$cache1C == null)
		{
			Lua_BlackJack_ProjectL_PlayerContext_MissionComponent.<>f__mg$cache1C = new LuaCSFunction(Lua_BlackJack_ProjectL_PlayerContext_MissionComponent.__callBase_IsNoviceMissionActivatedForRewarding);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_PlayerContext_MissionComponent.<>f__mg$cache1C);
		if (Lua_BlackJack_ProjectL_PlayerContext_MissionComponent.<>f__mg$cache1D == null)
		{
			Lua_BlackJack_ProjectL_PlayerContext_MissionComponent.<>f__mg$cache1D = new LuaCSFunction(Lua_BlackJack_ProjectL_PlayerContext_MissionComponent.__callBase_CanGetRewarding);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_PlayerContext_MissionComponent.<>f__mg$cache1D);
		if (Lua_BlackJack_ProjectL_PlayerContext_MissionComponent.<>f__mg$cache1E == null)
		{
			Lua_BlackJack_ProjectL_PlayerContext_MissionComponent.<>f__mg$cache1E = new LuaCSFunction(Lua_BlackJack_ProjectL_PlayerContext_MissionComponent.__callBase_CanUnlockMissionInLogic);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_PlayerContext_MissionComponent.<>f__mg$cache1E);
		if (Lua_BlackJack_ProjectL_PlayerContext_MissionComponent.<>f__mg$cache1F == null)
		{
			Lua_BlackJack_ProjectL_PlayerContext_MissionComponent.<>f__mg$cache1F = new LuaCSFunction(Lua_BlackJack_ProjectL_PlayerContext_MissionComponent.__callBase_CanUnlockMission);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_PlayerContext_MissionComponent.<>f__mg$cache1F);
		if (Lua_BlackJack_ProjectL_PlayerContext_MissionComponent.<>f__mg$cache20 == null)
		{
			Lua_BlackJack_ProjectL_PlayerContext_MissionComponent.<>f__mg$cache20 = new LuaCSFunction(Lua_BlackJack_ProjectL_PlayerContext_MissionComponent.__callBase_CaculateDirectlyActivationMissionStatus);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_PlayerContext_MissionComponent.<>f__mg$cache20);
		if (Lua_BlackJack_ProjectL_PlayerContext_MissionComponent.<>f__mg$cache21 == null)
		{
			Lua_BlackJack_ProjectL_PlayerContext_MissionComponent.<>f__mg$cache21 = new LuaCSFunction(Lua_BlackJack_ProjectL_PlayerContext_MissionComponent.__callBase_AddMission);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_PlayerContext_MissionComponent.<>f__mg$cache21);
		if (Lua_BlackJack_ProjectL_PlayerContext_MissionComponent.<>f__mg$cache22 == null)
		{
			Lua_BlackJack_ProjectL_PlayerContext_MissionComponent.<>f__mg$cache22 = new LuaCSFunction(Lua_BlackJack_ProjectL_PlayerContext_MissionComponent.__callBase_OnAddProcessingDirectelyActivitedMission);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_PlayerContext_MissionComponent.<>f__mg$cache22);
		if (Lua_BlackJack_ProjectL_PlayerContext_MissionComponent.<>f__mg$cache23 == null)
		{
			Lua_BlackJack_ProjectL_PlayerContext_MissionComponent.<>f__mg$cache23 = new LuaCSFunction(Lua_BlackJack_ProjectL_PlayerContext_MissionComponent.__callBase_GetProcessingMissionByMissionPeriod);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_PlayerContext_MissionComponent.<>f__mg$cache23);
		if (Lua_BlackJack_ProjectL_PlayerContext_MissionComponent.<>f__mg$cache24 == null)
		{
			Lua_BlackJack_ProjectL_PlayerContext_MissionComponent.<>f__mg$cache24 = new LuaCSFunction(Lua_BlackJack_ProjectL_PlayerContext_MissionComponent.__callBase_OnGetProcessingDirectActivationMissionFail);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_PlayerContext_MissionComponent.<>f__mg$cache24);
		if (Lua_BlackJack_ProjectL_PlayerContext_MissionComponent.<>f__mg$cache25 == null)
		{
			Lua_BlackJack_ProjectL_PlayerContext_MissionComponent.<>f__mg$cache25 = new LuaCSFunction(Lua_BlackJack_ProjectL_PlayerContext_MissionComponent.__callBase_AddOneOffMission);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_PlayerContext_MissionComponent.<>f__mg$cache25);
		if (Lua_BlackJack_ProjectL_PlayerContext_MissionComponent.<>f__mg$cache26 == null)
		{
			Lua_BlackJack_ProjectL_PlayerContext_MissionComponent.<>f__mg$cache26 = new LuaCSFunction(Lua_BlackJack_ProjectL_PlayerContext_MissionComponent.__callBase_IsMissionFinished);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_PlayerContext_MissionComponent.<>f__mg$cache26);
		if (Lua_BlackJack_ProjectL_PlayerContext_MissionComponent.<>f__mg$cache27 == null)
		{
			Lua_BlackJack_ProjectL_PlayerContext_MissionComponent.<>f__mg$cache27 = new LuaCSFunction(Lua_BlackJack_ProjectL_PlayerContext_MissionComponent.__callBase_InitMissionsFromConfig);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_PlayerContext_MissionComponent.<>f__mg$cache27);
		if (Lua_BlackJack_ProjectL_PlayerContext_MissionComponent.<>f__mg$cache28 == null)
		{
			Lua_BlackJack_ProjectL_PlayerContext_MissionComponent.<>f__mg$cache28 = new LuaCSFunction(Lua_BlackJack_ProjectL_PlayerContext_MissionComponent.__callBase_FinishMission);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_PlayerContext_MissionComponent.<>f__mg$cache28);
		if (Lua_BlackJack_ProjectL_PlayerContext_MissionComponent.<>f__mg$cache29 == null)
		{
			Lua_BlackJack_ProjectL_PlayerContext_MissionComponent.<>f__mg$cache29 = new LuaCSFunction(Lua_BlackJack_ProjectL_PlayerContext_MissionComponent.__callBase_GetAllProcessingNoviceMissionList);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_PlayerContext_MissionComponent.<>f__mg$cache29);
		if (Lua_BlackJack_ProjectL_PlayerContext_MissionComponent.<>f__mg$cache2A == null)
		{
			Lua_BlackJack_ProjectL_PlayerContext_MissionComponent.<>f__mg$cache2A = new LuaCSFunction(Lua_BlackJack_ProjectL_PlayerContext_MissionComponent.__callBase_GetAllFinishedNoviceMissionList);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_PlayerContext_MissionComponent.<>f__mg$cache2A);
		if (Lua_BlackJack_ProjectL_PlayerContext_MissionComponent.<>f__mg$cache2B == null)
		{
			Lua_BlackJack_ProjectL_PlayerContext_MissionComponent.<>f__mg$cache2B = new LuaCSFunction(Lua_BlackJack_ProjectL_PlayerContext_MissionComponent.__callBase_AddMissionProcess);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_PlayerContext_MissionComponent.<>f__mg$cache2B);
		if (Lua_BlackJack_ProjectL_PlayerContext_MissionComponent.<>f__mg$cache2C == null)
		{
			Lua_BlackJack_ProjectL_PlayerContext_MissionComponent.<>f__mg$cache2C = new LuaCSFunction(Lua_BlackJack_ProjectL_PlayerContext_MissionComponent.__callBase_GetMissionMaxProcess);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_PlayerContext_MissionComponent.<>f__mg$cache2C);
		if (Lua_BlackJack_ProjectL_PlayerContext_MissionComponent.<>f__mg$cache2D == null)
		{
			Lua_BlackJack_ProjectL_PlayerContext_MissionComponent.<>f__mg$cache2D = new LuaCSFunction(Lua_BlackJack_ProjectL_PlayerContext_MissionComponent.__callBase_IsMissionProcessFinished);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_PlayerContext_MissionComponent.<>f__mg$cache2D);
		if (Lua_BlackJack_ProjectL_PlayerContext_MissionComponent.<>f__mg$cache2E == null)
		{
			Lua_BlackJack_ProjectL_PlayerContext_MissionComponent.<>f__mg$cache2E = new LuaCSFunction(Lua_BlackJack_ProjectL_PlayerContext_MissionComponent.__callBase_CanGainMissionReward);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_PlayerContext_MissionComponent.<>f__mg$cache2E);
		if (Lua_BlackJack_ProjectL_PlayerContext_MissionComponent.<>f__mg$cache2F == null)
		{
			Lua_BlackJack_ProjectL_PlayerContext_MissionComponent.<>f__mg$cache2F = new LuaCSFunction(Lua_BlackJack_ProjectL_PlayerContext_MissionComponent.__callBase_IsCompleted);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_PlayerContext_MissionComponent.<>f__mg$cache2F);
		if (Lua_BlackJack_ProjectL_PlayerContext_MissionComponent.<>f__mg$cache30 == null)
		{
			Lua_BlackJack_ProjectL_PlayerContext_MissionComponent.<>f__mg$cache30 = new LuaCSFunction(Lua_BlackJack_ProjectL_PlayerContext_MissionComponent.__callBase_SetStatisticalData);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_PlayerContext_MissionComponent.<>f__mg$cache30);
		if (Lua_BlackJack_ProjectL_PlayerContext_MissionComponent.<>f__mg$cache31 == null)
		{
			Lua_BlackJack_ProjectL_PlayerContext_MissionComponent.<>f__mg$cache31 = new LuaCSFunction(Lua_BlackJack_ProjectL_PlayerContext_MissionComponent.__callBase_AddStatisticalData);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_PlayerContext_MissionComponent.<>f__mg$cache31);
		if (Lua_BlackJack_ProjectL_PlayerContext_MissionComponent.<>f__mg$cache32 == null)
		{
			Lua_BlackJack_ProjectL_PlayerContext_MissionComponent.<>f__mg$cache32 = new LuaCSFunction(Lua_BlackJack_ProjectL_PlayerContext_MissionComponent.__callBase_GetMissionCompletedProcess);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_PlayerContext_MissionComponent.<>f__mg$cache32);
		if (Lua_BlackJack_ProjectL_PlayerContext_MissionComponent.<>f__mg$cache33 == null)
		{
			Lua_BlackJack_ProjectL_PlayerContext_MissionComponent.<>f__mg$cache33 = new LuaCSFunction(Lua_BlackJack_ProjectL_PlayerContext_MissionComponent.__callBase_OnLoginGameCallBack);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_PlayerContext_MissionComponent.<>f__mg$cache33);
		if (Lua_BlackJack_ProjectL_PlayerContext_MissionComponent.<>f__mg$cache34 == null)
		{
			Lua_BlackJack_ProjectL_PlayerContext_MissionComponent.<>f__mg$cache34 = new LuaCSFunction(Lua_BlackJack_ProjectL_PlayerContext_MissionComponent.constructor);
		}
		LuaObject.createTypeMetatable(l, Lua_BlackJack_ProjectL_PlayerContext_MissionComponent.<>f__mg$cache34, typeof(MissionComponent), typeof(MissionComponentCommon));
	}

	// Token: 0x0400FB01 RID: 64257
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache0;

	// Token: 0x0400FB02 RID: 64258
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1;

	// Token: 0x0400FB03 RID: 64259
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2;

	// Token: 0x0400FB04 RID: 64260
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3;

	// Token: 0x0400FB05 RID: 64261
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache4;

	// Token: 0x0400FB06 RID: 64262
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache5;

	// Token: 0x0400FB07 RID: 64263
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache6;

	// Token: 0x0400FB08 RID: 64264
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache7;

	// Token: 0x0400FB09 RID: 64265
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache8;

	// Token: 0x0400FB0A RID: 64266
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache9;

	// Token: 0x0400FB0B RID: 64267
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheA;

	// Token: 0x0400FB0C RID: 64268
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheB;

	// Token: 0x0400FB0D RID: 64269
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheC;

	// Token: 0x0400FB0E RID: 64270
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheD;

	// Token: 0x0400FB0F RID: 64271
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheE;

	// Token: 0x0400FB10 RID: 64272
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheF;

	// Token: 0x0400FB11 RID: 64273
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache10;

	// Token: 0x0400FB12 RID: 64274
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache11;

	// Token: 0x0400FB13 RID: 64275
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache12;

	// Token: 0x0400FB14 RID: 64276
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache13;

	// Token: 0x0400FB15 RID: 64277
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache14;

	// Token: 0x0400FB16 RID: 64278
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache15;

	// Token: 0x0400FB17 RID: 64279
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache16;

	// Token: 0x0400FB18 RID: 64280
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache17;

	// Token: 0x0400FB19 RID: 64281
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache18;

	// Token: 0x0400FB1A RID: 64282
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache19;

	// Token: 0x0400FB1B RID: 64283
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1A;

	// Token: 0x0400FB1C RID: 64284
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1B;

	// Token: 0x0400FB1D RID: 64285
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1C;

	// Token: 0x0400FB1E RID: 64286
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1D;

	// Token: 0x0400FB1F RID: 64287
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1E;

	// Token: 0x0400FB20 RID: 64288
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1F;

	// Token: 0x0400FB21 RID: 64289
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache20;

	// Token: 0x0400FB22 RID: 64290
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache21;

	// Token: 0x0400FB23 RID: 64291
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache22;

	// Token: 0x0400FB24 RID: 64292
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache23;

	// Token: 0x0400FB25 RID: 64293
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache24;

	// Token: 0x0400FB26 RID: 64294
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache25;

	// Token: 0x0400FB27 RID: 64295
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache26;

	// Token: 0x0400FB28 RID: 64296
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache27;

	// Token: 0x0400FB29 RID: 64297
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache28;

	// Token: 0x0400FB2A RID: 64298
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache29;

	// Token: 0x0400FB2B RID: 64299
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2A;

	// Token: 0x0400FB2C RID: 64300
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2B;

	// Token: 0x0400FB2D RID: 64301
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2C;

	// Token: 0x0400FB2E RID: 64302
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2D;

	// Token: 0x0400FB2F RID: 64303
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2E;

	// Token: 0x0400FB30 RID: 64304
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2F;

	// Token: 0x0400FB31 RID: 64305
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache30;

	// Token: 0x0400FB32 RID: 64306
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache31;

	// Token: 0x0400FB33 RID: 64307
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache32;

	// Token: 0x0400FB34 RID: 64308
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache33;

	// Token: 0x0400FB35 RID: 64309
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache34;
}
