using System;
using System.Runtime.CompilerServices;
using BlackJack.ConfigData;
using SLua;
using UnityEngine.Scripting;

// Token: 0x02001161 RID: 4449
[Preserve]
public class Lua_BlackJack_ConfigData_ConfigDataMissionInfo : LuaObject
{
	// Token: 0x06016B2B RID: 92971 RVA: 0x0060C23C File Offset: 0x0060A43C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int constructor(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataMissionInfo o = new ConfigDataMissionInfo();
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

	// Token: 0x06016B2C RID: 92972 RVA: 0x0060C284 File Offset: 0x0060A484
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_Novice(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataMissionInfo configDataMissionInfo = (ConfigDataMissionInfo)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, configDataMissionInfo.m_Novice);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06016B2D RID: 92973 RVA: 0x0060C2D8 File Offset: 0x0060A4D8
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_m_Novice(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataMissionInfo configDataMissionInfo = (ConfigDataMissionInfo)LuaObject.checkSelf(l);
			ConfigDataMissionExtNoviceInfo novice;
			LuaObject.checkType<ConfigDataMissionExtNoviceInfo>(l, 2, out novice);
			configDataMissionInfo.m_Novice = novice;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06016B2E RID: 92974 RVA: 0x0060C330 File Offset: 0x0060A530
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_ID(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataMissionInfo configDataMissionInfo = (ConfigDataMissionInfo)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, configDataMissionInfo.ID);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06016B2F RID: 92975 RVA: 0x0060C384 File Offset: 0x0060A584
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_ID(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataMissionInfo configDataMissionInfo = (ConfigDataMissionInfo)LuaObject.checkSelf(l);
			int id;
			LuaObject.checkType(l, 2, out id);
			configDataMissionInfo.ID = id;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06016B30 RID: 92976 RVA: 0x0060C3DC File Offset: 0x0060A5DC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_Title(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataMissionInfo configDataMissionInfo = (ConfigDataMissionInfo)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, configDataMissionInfo.Title);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06016B31 RID: 92977 RVA: 0x0060C430 File Offset: 0x0060A630
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_Title(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataMissionInfo configDataMissionInfo = (ConfigDataMissionInfo)LuaObject.checkSelf(l);
			string title;
			LuaObject.checkType(l, 2, out title);
			configDataMissionInfo.Title = title;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06016B32 RID: 92978 RVA: 0x0060C488 File Offset: 0x0060A688
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_Desc(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataMissionInfo configDataMissionInfo = (ConfigDataMissionInfo)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, configDataMissionInfo.Desc);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06016B33 RID: 92979 RVA: 0x0060C4DC File Offset: 0x0060A6DC
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_Desc(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataMissionInfo configDataMissionInfo = (ConfigDataMissionInfo)LuaObject.checkSelf(l);
			string desc;
			LuaObject.checkType(l, 2, out desc);
			configDataMissionInfo.Desc = desc;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06016B34 RID: 92980 RVA: 0x0060C534 File Offset: 0x0060A734
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_MissionPeriod(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataMissionInfo configDataMissionInfo = (ConfigDataMissionInfo)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushEnum(l, (int)configDataMissionInfo.MissionPeriod);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06016B35 RID: 92981 RVA: 0x0060C588 File Offset: 0x0060A788
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_MissionPeriod(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataMissionInfo configDataMissionInfo = (ConfigDataMissionInfo)LuaObject.checkSelf(l);
			MissionPeriodType missionPeriod;
			LuaObject.checkEnum<MissionPeriodType>(l, 2, out missionPeriod);
			configDataMissionInfo.MissionPeriod = missionPeriod;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06016B36 RID: 92982 RVA: 0x0060C5E0 File Offset: 0x0060A7E0
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_MissionColumn(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataMissionInfo configDataMissionInfo = (ConfigDataMissionInfo)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushEnum(l, (int)configDataMissionInfo.MissionColumn);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06016B37 RID: 92983 RVA: 0x0060C634 File Offset: 0x0060A834
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_MissionColumn(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataMissionInfo configDataMissionInfo = (ConfigDataMissionInfo)LuaObject.checkSelf(l);
			MissionColumnType missionColumn;
			LuaObject.checkEnum<MissionColumnType>(l, 2, out missionColumn);
			configDataMissionInfo.MissionColumn = missionColumn;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06016B38 RID: 92984 RVA: 0x0060C68C File Offset: 0x0060A88C
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_MissionType(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataMissionInfo configDataMissionInfo = (ConfigDataMissionInfo)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushEnum(l, (int)configDataMissionInfo.MissionType);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06016B39 RID: 92985 RVA: 0x0060C6E0 File Offset: 0x0060A8E0
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_MissionType(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataMissionInfo configDataMissionInfo = (ConfigDataMissionInfo)LuaObject.checkSelf(l);
			MissionType missionType;
			LuaObject.checkEnum<MissionType>(l, 2, out missionType);
			configDataMissionInfo.MissionType = missionType;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06016B3A RID: 92986 RVA: 0x0060C738 File Offset: 0x0060A938
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_Param1(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataMissionInfo configDataMissionInfo = (ConfigDataMissionInfo)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, configDataMissionInfo.Param1);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06016B3B RID: 92987 RVA: 0x0060C78C File Offset: 0x0060A98C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_Param1(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataMissionInfo configDataMissionInfo = (ConfigDataMissionInfo)LuaObject.checkSelf(l);
			int param;
			LuaObject.checkType(l, 2, out param);
			configDataMissionInfo.Param1 = param;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06016B3C RID: 92988 RVA: 0x0060C7E4 File Offset: 0x0060A9E4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_Param2(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataMissionInfo configDataMissionInfo = (ConfigDataMissionInfo)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, configDataMissionInfo.Param2);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06016B3D RID: 92989 RVA: 0x0060C838 File Offset: 0x0060AA38
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_Param2(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataMissionInfo configDataMissionInfo = (ConfigDataMissionInfo)LuaObject.checkSelf(l);
			int param;
			LuaObject.checkType(l, 2, out param);
			configDataMissionInfo.Param2 = param;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06016B3E RID: 92990 RVA: 0x0060C890 File Offset: 0x0060AA90
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_Param3(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataMissionInfo configDataMissionInfo = (ConfigDataMissionInfo)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, configDataMissionInfo.Param3);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06016B3F RID: 92991 RVA: 0x0060C8E4 File Offset: 0x0060AAE4
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_Param3(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataMissionInfo configDataMissionInfo = (ConfigDataMissionInfo)LuaObject.checkSelf(l);
			int param;
			LuaObject.checkType(l, 2, out param);
			configDataMissionInfo.Param3 = param;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06016B40 RID: 92992 RVA: 0x0060C93C File Offset: 0x0060AB3C
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_Param4(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataMissionInfo configDataMissionInfo = (ConfigDataMissionInfo)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, configDataMissionInfo.Param4);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06016B41 RID: 92993 RVA: 0x0060C990 File Offset: 0x0060AB90
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_Param4(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataMissionInfo configDataMissionInfo = (ConfigDataMissionInfo)LuaObject.checkSelf(l);
			int param;
			LuaObject.checkType(l, 2, out param);
			configDataMissionInfo.Param4 = param;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06016B42 RID: 92994 RVA: 0x0060C9E8 File Offset: 0x0060ABE8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_MissionUnlockPlayerLvl(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataMissionInfo configDataMissionInfo = (ConfigDataMissionInfo)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, configDataMissionInfo.MissionUnlockPlayerLvl);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06016B43 RID: 92995 RVA: 0x0060CA3C File Offset: 0x0060AC3C
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_MissionUnlockPlayerLvl(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataMissionInfo configDataMissionInfo = (ConfigDataMissionInfo)LuaObject.checkSelf(l);
			int missionUnlockPlayerLvl;
			LuaObject.checkType(l, 2, out missionUnlockPlayerLvl);
			configDataMissionInfo.MissionUnlockPlayerLvl = missionUnlockPlayerLvl;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06016B44 RID: 92996 RVA: 0x0060CA94 File Offset: 0x0060AC94
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_MissionUnlockPreTaskID(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataMissionInfo configDataMissionInfo = (ConfigDataMissionInfo)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, configDataMissionInfo.MissionUnlockPreTaskID);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06016B45 RID: 92997 RVA: 0x0060CAE8 File Offset: 0x0060ACE8
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_MissionUnlockPreTaskID(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataMissionInfo configDataMissionInfo = (ConfigDataMissionInfo)LuaObject.checkSelf(l);
			int missionUnlockPreTaskID;
			LuaObject.checkType(l, 2, out missionUnlockPreTaskID);
			configDataMissionInfo.MissionUnlockPreTaskID = missionUnlockPreTaskID;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06016B46 RID: 92998 RVA: 0x0060CB40 File Offset: 0x0060AD40
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_MissionUnlockScenarioID(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataMissionInfo configDataMissionInfo = (ConfigDataMissionInfo)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, configDataMissionInfo.MissionUnlockScenarioID);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06016B47 RID: 92999 RVA: 0x0060CB94 File Offset: 0x0060AD94
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_MissionUnlockScenarioID(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataMissionInfo configDataMissionInfo = (ConfigDataMissionInfo)LuaObject.checkSelf(l);
			int missionUnlockScenarioID;
			LuaObject.checkType(l, 2, out missionUnlockScenarioID);
			configDataMissionInfo.MissionUnlockScenarioID = missionUnlockScenarioID;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06016B48 RID: 93000 RVA: 0x0060CBEC File Offset: 0x0060ADEC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_SortID(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataMissionInfo configDataMissionInfo = (ConfigDataMissionInfo)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, configDataMissionInfo.SortID);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06016B49 RID: 93001 RVA: 0x0060CC40 File Offset: 0x0060AE40
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_SortID(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataMissionInfo configDataMissionInfo = (ConfigDataMissionInfo)LuaObject.checkSelf(l);
			int sortID;
			LuaObject.checkType(l, 2, out sortID);
			configDataMissionInfo.SortID = sortID;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06016B4A RID: 93002 RVA: 0x0060CC98 File Offset: 0x0060AE98
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_Reward(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataMissionInfo configDataMissionInfo = (ConfigDataMissionInfo)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, configDataMissionInfo.Reward);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06016B4B RID: 93003 RVA: 0x0060CCEC File Offset: 0x0060AEEC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_NoviceExt(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataMissionInfo configDataMissionInfo = (ConfigDataMissionInfo)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, configDataMissionInfo.NoviceExt);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06016B4C RID: 93004 RVA: 0x0060CD40 File Offset: 0x0060AF40
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_NoviceExt(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataMissionInfo configDataMissionInfo = (ConfigDataMissionInfo)LuaObject.checkSelf(l);
			int noviceExt;
			LuaObject.checkType(l, 2, out noviceExt);
			configDataMissionInfo.NoviceExt = noviceExt;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06016B4D RID: 93005 RVA: 0x0060CD98 File Offset: 0x0060AF98
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_GetPathList(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataMissionInfo configDataMissionInfo = (ConfigDataMissionInfo)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, configDataMissionInfo.GetPathList);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06016B4E RID: 93006 RVA: 0x0060CDEC File Offset: 0x0060AFEC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_IsMonthCardMission(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataMissionInfo configDataMissionInfo = (ConfigDataMissionInfo)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, configDataMissionInfo.IsMonthCardMission);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06016B4F RID: 93007 RVA: 0x0060CE40 File Offset: 0x0060B040
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_IsMonthCardMission(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataMissionInfo configDataMissionInfo = (ConfigDataMissionInfo)LuaObject.checkSelf(l);
			bool isMonthCardMission;
			LuaObject.checkType(l, 2, out isMonthCardMission);
			configDataMissionInfo.IsMonthCardMission = isMonthCardMission;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06016B50 RID: 93008 RVA: 0x0060CE98 File Offset: 0x0060B098
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_Obsoleted(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataMissionInfo configDataMissionInfo = (ConfigDataMissionInfo)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, configDataMissionInfo.Obsoleted);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06016B51 RID: 93009 RVA: 0x0060CEEC File Offset: 0x0060B0EC
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_Obsoleted(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataMissionInfo configDataMissionInfo = (ConfigDataMissionInfo)LuaObject.checkSelf(l);
			bool obsoleted;
			LuaObject.checkType(l, 2, out obsoleted);
			configDataMissionInfo.Obsoleted = obsoleted;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06016B52 RID: 93010 RVA: 0x0060CF44 File Offset: 0x0060B144
	[Preserve]
	public static void reg(IntPtr l)
	{
		LuaObject.getTypeTable(l, "BlackJack.ConfigData.ConfigDataMissionInfo");
		string name = "m_Novice";
		if (Lua_BlackJack_ConfigData_ConfigDataMissionInfo.<>f__mg$cache0 == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataMissionInfo.<>f__mg$cache0 = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataMissionInfo.get_m_Novice);
		}
		LuaCSFunction get = Lua_BlackJack_ConfigData_ConfigDataMissionInfo.<>f__mg$cache0;
		if (Lua_BlackJack_ConfigData_ConfigDataMissionInfo.<>f__mg$cache1 == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataMissionInfo.<>f__mg$cache1 = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataMissionInfo.set_m_Novice);
		}
		LuaObject.addMember(l, name, get, Lua_BlackJack_ConfigData_ConfigDataMissionInfo.<>f__mg$cache1, true);
		string name2 = "ID";
		if (Lua_BlackJack_ConfigData_ConfigDataMissionInfo.<>f__mg$cache2 == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataMissionInfo.<>f__mg$cache2 = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataMissionInfo.get_ID);
		}
		LuaCSFunction get2 = Lua_BlackJack_ConfigData_ConfigDataMissionInfo.<>f__mg$cache2;
		if (Lua_BlackJack_ConfigData_ConfigDataMissionInfo.<>f__mg$cache3 == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataMissionInfo.<>f__mg$cache3 = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataMissionInfo.set_ID);
		}
		LuaObject.addMember(l, name2, get2, Lua_BlackJack_ConfigData_ConfigDataMissionInfo.<>f__mg$cache3, true);
		string name3 = "Title";
		if (Lua_BlackJack_ConfigData_ConfigDataMissionInfo.<>f__mg$cache4 == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataMissionInfo.<>f__mg$cache4 = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataMissionInfo.get_Title);
		}
		LuaCSFunction get3 = Lua_BlackJack_ConfigData_ConfigDataMissionInfo.<>f__mg$cache4;
		if (Lua_BlackJack_ConfigData_ConfigDataMissionInfo.<>f__mg$cache5 == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataMissionInfo.<>f__mg$cache5 = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataMissionInfo.set_Title);
		}
		LuaObject.addMember(l, name3, get3, Lua_BlackJack_ConfigData_ConfigDataMissionInfo.<>f__mg$cache5, true);
		string name4 = "Desc";
		if (Lua_BlackJack_ConfigData_ConfigDataMissionInfo.<>f__mg$cache6 == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataMissionInfo.<>f__mg$cache6 = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataMissionInfo.get_Desc);
		}
		LuaCSFunction get4 = Lua_BlackJack_ConfigData_ConfigDataMissionInfo.<>f__mg$cache6;
		if (Lua_BlackJack_ConfigData_ConfigDataMissionInfo.<>f__mg$cache7 == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataMissionInfo.<>f__mg$cache7 = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataMissionInfo.set_Desc);
		}
		LuaObject.addMember(l, name4, get4, Lua_BlackJack_ConfigData_ConfigDataMissionInfo.<>f__mg$cache7, true);
		string name5 = "MissionPeriod";
		if (Lua_BlackJack_ConfigData_ConfigDataMissionInfo.<>f__mg$cache8 == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataMissionInfo.<>f__mg$cache8 = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataMissionInfo.get_MissionPeriod);
		}
		LuaCSFunction get5 = Lua_BlackJack_ConfigData_ConfigDataMissionInfo.<>f__mg$cache8;
		if (Lua_BlackJack_ConfigData_ConfigDataMissionInfo.<>f__mg$cache9 == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataMissionInfo.<>f__mg$cache9 = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataMissionInfo.set_MissionPeriod);
		}
		LuaObject.addMember(l, name5, get5, Lua_BlackJack_ConfigData_ConfigDataMissionInfo.<>f__mg$cache9, true);
		string name6 = "MissionColumn";
		if (Lua_BlackJack_ConfigData_ConfigDataMissionInfo.<>f__mg$cacheA == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataMissionInfo.<>f__mg$cacheA = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataMissionInfo.get_MissionColumn);
		}
		LuaCSFunction get6 = Lua_BlackJack_ConfigData_ConfigDataMissionInfo.<>f__mg$cacheA;
		if (Lua_BlackJack_ConfigData_ConfigDataMissionInfo.<>f__mg$cacheB == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataMissionInfo.<>f__mg$cacheB = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataMissionInfo.set_MissionColumn);
		}
		LuaObject.addMember(l, name6, get6, Lua_BlackJack_ConfigData_ConfigDataMissionInfo.<>f__mg$cacheB, true);
		string name7 = "MissionType";
		if (Lua_BlackJack_ConfigData_ConfigDataMissionInfo.<>f__mg$cacheC == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataMissionInfo.<>f__mg$cacheC = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataMissionInfo.get_MissionType);
		}
		LuaCSFunction get7 = Lua_BlackJack_ConfigData_ConfigDataMissionInfo.<>f__mg$cacheC;
		if (Lua_BlackJack_ConfigData_ConfigDataMissionInfo.<>f__mg$cacheD == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataMissionInfo.<>f__mg$cacheD = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataMissionInfo.set_MissionType);
		}
		LuaObject.addMember(l, name7, get7, Lua_BlackJack_ConfigData_ConfigDataMissionInfo.<>f__mg$cacheD, true);
		string name8 = "Param1";
		if (Lua_BlackJack_ConfigData_ConfigDataMissionInfo.<>f__mg$cacheE == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataMissionInfo.<>f__mg$cacheE = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataMissionInfo.get_Param1);
		}
		LuaCSFunction get8 = Lua_BlackJack_ConfigData_ConfigDataMissionInfo.<>f__mg$cacheE;
		if (Lua_BlackJack_ConfigData_ConfigDataMissionInfo.<>f__mg$cacheF == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataMissionInfo.<>f__mg$cacheF = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataMissionInfo.set_Param1);
		}
		LuaObject.addMember(l, name8, get8, Lua_BlackJack_ConfigData_ConfigDataMissionInfo.<>f__mg$cacheF, true);
		string name9 = "Param2";
		if (Lua_BlackJack_ConfigData_ConfigDataMissionInfo.<>f__mg$cache10 == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataMissionInfo.<>f__mg$cache10 = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataMissionInfo.get_Param2);
		}
		LuaCSFunction get9 = Lua_BlackJack_ConfigData_ConfigDataMissionInfo.<>f__mg$cache10;
		if (Lua_BlackJack_ConfigData_ConfigDataMissionInfo.<>f__mg$cache11 == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataMissionInfo.<>f__mg$cache11 = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataMissionInfo.set_Param2);
		}
		LuaObject.addMember(l, name9, get9, Lua_BlackJack_ConfigData_ConfigDataMissionInfo.<>f__mg$cache11, true);
		string name10 = "Param3";
		if (Lua_BlackJack_ConfigData_ConfigDataMissionInfo.<>f__mg$cache12 == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataMissionInfo.<>f__mg$cache12 = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataMissionInfo.get_Param3);
		}
		LuaCSFunction get10 = Lua_BlackJack_ConfigData_ConfigDataMissionInfo.<>f__mg$cache12;
		if (Lua_BlackJack_ConfigData_ConfigDataMissionInfo.<>f__mg$cache13 == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataMissionInfo.<>f__mg$cache13 = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataMissionInfo.set_Param3);
		}
		LuaObject.addMember(l, name10, get10, Lua_BlackJack_ConfigData_ConfigDataMissionInfo.<>f__mg$cache13, true);
		string name11 = "Param4";
		if (Lua_BlackJack_ConfigData_ConfigDataMissionInfo.<>f__mg$cache14 == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataMissionInfo.<>f__mg$cache14 = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataMissionInfo.get_Param4);
		}
		LuaCSFunction get11 = Lua_BlackJack_ConfigData_ConfigDataMissionInfo.<>f__mg$cache14;
		if (Lua_BlackJack_ConfigData_ConfigDataMissionInfo.<>f__mg$cache15 == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataMissionInfo.<>f__mg$cache15 = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataMissionInfo.set_Param4);
		}
		LuaObject.addMember(l, name11, get11, Lua_BlackJack_ConfigData_ConfigDataMissionInfo.<>f__mg$cache15, true);
		string name12 = "MissionUnlockPlayerLvl";
		if (Lua_BlackJack_ConfigData_ConfigDataMissionInfo.<>f__mg$cache16 == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataMissionInfo.<>f__mg$cache16 = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataMissionInfo.get_MissionUnlockPlayerLvl);
		}
		LuaCSFunction get12 = Lua_BlackJack_ConfigData_ConfigDataMissionInfo.<>f__mg$cache16;
		if (Lua_BlackJack_ConfigData_ConfigDataMissionInfo.<>f__mg$cache17 == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataMissionInfo.<>f__mg$cache17 = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataMissionInfo.set_MissionUnlockPlayerLvl);
		}
		LuaObject.addMember(l, name12, get12, Lua_BlackJack_ConfigData_ConfigDataMissionInfo.<>f__mg$cache17, true);
		string name13 = "MissionUnlockPreTaskID";
		if (Lua_BlackJack_ConfigData_ConfigDataMissionInfo.<>f__mg$cache18 == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataMissionInfo.<>f__mg$cache18 = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataMissionInfo.get_MissionUnlockPreTaskID);
		}
		LuaCSFunction get13 = Lua_BlackJack_ConfigData_ConfigDataMissionInfo.<>f__mg$cache18;
		if (Lua_BlackJack_ConfigData_ConfigDataMissionInfo.<>f__mg$cache19 == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataMissionInfo.<>f__mg$cache19 = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataMissionInfo.set_MissionUnlockPreTaskID);
		}
		LuaObject.addMember(l, name13, get13, Lua_BlackJack_ConfigData_ConfigDataMissionInfo.<>f__mg$cache19, true);
		string name14 = "MissionUnlockScenarioID";
		if (Lua_BlackJack_ConfigData_ConfigDataMissionInfo.<>f__mg$cache1A == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataMissionInfo.<>f__mg$cache1A = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataMissionInfo.get_MissionUnlockScenarioID);
		}
		LuaCSFunction get14 = Lua_BlackJack_ConfigData_ConfigDataMissionInfo.<>f__mg$cache1A;
		if (Lua_BlackJack_ConfigData_ConfigDataMissionInfo.<>f__mg$cache1B == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataMissionInfo.<>f__mg$cache1B = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataMissionInfo.set_MissionUnlockScenarioID);
		}
		LuaObject.addMember(l, name14, get14, Lua_BlackJack_ConfigData_ConfigDataMissionInfo.<>f__mg$cache1B, true);
		string name15 = "SortID";
		if (Lua_BlackJack_ConfigData_ConfigDataMissionInfo.<>f__mg$cache1C == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataMissionInfo.<>f__mg$cache1C = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataMissionInfo.get_SortID);
		}
		LuaCSFunction get15 = Lua_BlackJack_ConfigData_ConfigDataMissionInfo.<>f__mg$cache1C;
		if (Lua_BlackJack_ConfigData_ConfigDataMissionInfo.<>f__mg$cache1D == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataMissionInfo.<>f__mg$cache1D = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataMissionInfo.set_SortID);
		}
		LuaObject.addMember(l, name15, get15, Lua_BlackJack_ConfigData_ConfigDataMissionInfo.<>f__mg$cache1D, true);
		string name16 = "Reward";
		if (Lua_BlackJack_ConfigData_ConfigDataMissionInfo.<>f__mg$cache1E == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataMissionInfo.<>f__mg$cache1E = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataMissionInfo.get_Reward);
		}
		LuaObject.addMember(l, name16, Lua_BlackJack_ConfigData_ConfigDataMissionInfo.<>f__mg$cache1E, null, true);
		string name17 = "NoviceExt";
		if (Lua_BlackJack_ConfigData_ConfigDataMissionInfo.<>f__mg$cache1F == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataMissionInfo.<>f__mg$cache1F = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataMissionInfo.get_NoviceExt);
		}
		LuaCSFunction get16 = Lua_BlackJack_ConfigData_ConfigDataMissionInfo.<>f__mg$cache1F;
		if (Lua_BlackJack_ConfigData_ConfigDataMissionInfo.<>f__mg$cache20 == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataMissionInfo.<>f__mg$cache20 = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataMissionInfo.set_NoviceExt);
		}
		LuaObject.addMember(l, name17, get16, Lua_BlackJack_ConfigData_ConfigDataMissionInfo.<>f__mg$cache20, true);
		string name18 = "GetPathList";
		if (Lua_BlackJack_ConfigData_ConfigDataMissionInfo.<>f__mg$cache21 == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataMissionInfo.<>f__mg$cache21 = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataMissionInfo.get_GetPathList);
		}
		LuaObject.addMember(l, name18, Lua_BlackJack_ConfigData_ConfigDataMissionInfo.<>f__mg$cache21, null, true);
		string name19 = "IsMonthCardMission";
		if (Lua_BlackJack_ConfigData_ConfigDataMissionInfo.<>f__mg$cache22 == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataMissionInfo.<>f__mg$cache22 = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataMissionInfo.get_IsMonthCardMission);
		}
		LuaCSFunction get17 = Lua_BlackJack_ConfigData_ConfigDataMissionInfo.<>f__mg$cache22;
		if (Lua_BlackJack_ConfigData_ConfigDataMissionInfo.<>f__mg$cache23 == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataMissionInfo.<>f__mg$cache23 = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataMissionInfo.set_IsMonthCardMission);
		}
		LuaObject.addMember(l, name19, get17, Lua_BlackJack_ConfigData_ConfigDataMissionInfo.<>f__mg$cache23, true);
		string name20 = "Obsoleted";
		if (Lua_BlackJack_ConfigData_ConfigDataMissionInfo.<>f__mg$cache24 == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataMissionInfo.<>f__mg$cache24 = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataMissionInfo.get_Obsoleted);
		}
		LuaCSFunction get18 = Lua_BlackJack_ConfigData_ConfigDataMissionInfo.<>f__mg$cache24;
		if (Lua_BlackJack_ConfigData_ConfigDataMissionInfo.<>f__mg$cache25 == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataMissionInfo.<>f__mg$cache25 = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataMissionInfo.set_Obsoleted);
		}
		LuaObject.addMember(l, name20, get18, Lua_BlackJack_ConfigData_ConfigDataMissionInfo.<>f__mg$cache25, true);
		if (Lua_BlackJack_ConfigData_ConfigDataMissionInfo.<>f__mg$cache26 == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataMissionInfo.<>f__mg$cache26 = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataMissionInfo.constructor);
		}
		LuaObject.createTypeMetatable(l, Lua_BlackJack_ConfigData_ConfigDataMissionInfo.<>f__mg$cache26, typeof(ConfigDataMissionInfo));
	}

	// Token: 0x0400D24B RID: 53835
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache0;

	// Token: 0x0400D24C RID: 53836
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1;

	// Token: 0x0400D24D RID: 53837
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2;

	// Token: 0x0400D24E RID: 53838
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3;

	// Token: 0x0400D24F RID: 53839
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache4;

	// Token: 0x0400D250 RID: 53840
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache5;

	// Token: 0x0400D251 RID: 53841
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache6;

	// Token: 0x0400D252 RID: 53842
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache7;

	// Token: 0x0400D253 RID: 53843
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache8;

	// Token: 0x0400D254 RID: 53844
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache9;

	// Token: 0x0400D255 RID: 53845
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheA;

	// Token: 0x0400D256 RID: 53846
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheB;

	// Token: 0x0400D257 RID: 53847
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheC;

	// Token: 0x0400D258 RID: 53848
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheD;

	// Token: 0x0400D259 RID: 53849
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheE;

	// Token: 0x0400D25A RID: 53850
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheF;

	// Token: 0x0400D25B RID: 53851
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache10;

	// Token: 0x0400D25C RID: 53852
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache11;

	// Token: 0x0400D25D RID: 53853
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache12;

	// Token: 0x0400D25E RID: 53854
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache13;

	// Token: 0x0400D25F RID: 53855
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache14;

	// Token: 0x0400D260 RID: 53856
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache15;

	// Token: 0x0400D261 RID: 53857
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache16;

	// Token: 0x0400D262 RID: 53858
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache17;

	// Token: 0x0400D263 RID: 53859
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache18;

	// Token: 0x0400D264 RID: 53860
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache19;

	// Token: 0x0400D265 RID: 53861
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1A;

	// Token: 0x0400D266 RID: 53862
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1B;

	// Token: 0x0400D267 RID: 53863
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1C;

	// Token: 0x0400D268 RID: 53864
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1D;

	// Token: 0x0400D269 RID: 53865
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1E;

	// Token: 0x0400D26A RID: 53866
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1F;

	// Token: 0x0400D26B RID: 53867
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache20;

	// Token: 0x0400D26C RID: 53868
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache21;

	// Token: 0x0400D26D RID: 53869
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache22;

	// Token: 0x0400D26E RID: 53870
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache23;

	// Token: 0x0400D26F RID: 53871
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache24;

	// Token: 0x0400D270 RID: 53872
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache25;

	// Token: 0x0400D271 RID: 53873
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache26;
}
