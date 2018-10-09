using System;
using System.Runtime.CompilerServices;
using BlackJack.ConfigData;
using SLua;
using UnityEngine.Scripting;

// Token: 0x02001168 RID: 4456
[Preserve]
public class Lua_BlackJack_ConfigData_ConfigDataScenarioInfo : LuaObject
{
	// Token: 0x06016C70 RID: 93296 RVA: 0x00615698 File Offset: 0x00613898
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int constructor(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataScenarioInfo o = new ConfigDataScenarioInfo();
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

	// Token: 0x06016C71 RID: 93297 RVA: 0x006156E0 File Offset: 0x006138E0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_waypointInfo(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataScenarioInfo configDataScenarioInfo = (ConfigDataScenarioInfo)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, configDataScenarioInfo.m_waypointInfo);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06016C72 RID: 93298 RVA: 0x00615734 File Offset: 0x00613934
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_m_waypointInfo(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataScenarioInfo configDataScenarioInfo = (ConfigDataScenarioInfo)LuaObject.checkSelf(l);
			ConfigDataWaypointInfo waypointInfo;
			LuaObject.checkType<ConfigDataWaypointInfo>(l, 2, out waypointInfo);
			configDataScenarioInfo.m_waypointInfo = waypointInfo;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06016C73 RID: 93299 RVA: 0x0061578C File Offset: 0x0061398C
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_m_nextScenarioInfo(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataScenarioInfo configDataScenarioInfo = (ConfigDataScenarioInfo)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, configDataScenarioInfo.m_nextScenarioInfo);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06016C74 RID: 93300 RVA: 0x006157E0 File Offset: 0x006139E0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_nextScenarioInfo(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataScenarioInfo configDataScenarioInfo = (ConfigDataScenarioInfo)LuaObject.checkSelf(l);
			ConfigDataScenarioInfo nextScenarioInfo;
			LuaObject.checkType<ConfigDataScenarioInfo>(l, 2, out nextScenarioInfo);
			configDataScenarioInfo.m_nextScenarioInfo = nextScenarioInfo;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06016C75 RID: 93301 RVA: 0x00615838 File Offset: 0x00613A38
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_m_battleInfo(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataScenarioInfo configDataScenarioInfo = (ConfigDataScenarioInfo)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, configDataScenarioInfo.m_battleInfo);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06016C76 RID: 93302 RVA: 0x0061588C File Offset: 0x00613A8C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_battleInfo(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataScenarioInfo configDataScenarioInfo = (ConfigDataScenarioInfo)LuaObject.checkSelf(l);
			ConfigDataBattleInfo battleInfo;
			LuaObject.checkType<ConfigDataBattleInfo>(l, 2, out battleInfo);
			configDataScenarioInfo.m_battleInfo = battleInfo;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06016C77 RID: 93303 RVA: 0x006158E4 File Offset: 0x00613AE4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_dialogInfoBefore(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataScenarioInfo configDataScenarioInfo = (ConfigDataScenarioInfo)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, configDataScenarioInfo.m_dialogInfoBefore);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06016C78 RID: 93304 RVA: 0x00615938 File Offset: 0x00613B38
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_dialogInfoBefore(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataScenarioInfo configDataScenarioInfo = (ConfigDataScenarioInfo)LuaObject.checkSelf(l);
			ConfigDataDialogInfo dialogInfoBefore;
			LuaObject.checkType<ConfigDataDialogInfo>(l, 2, out dialogInfoBefore);
			configDataScenarioInfo.m_dialogInfoBefore = dialogInfoBefore;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06016C79 RID: 93305 RVA: 0x00615990 File Offset: 0x00613B90
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_m_dialogInfoAfter(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataScenarioInfo configDataScenarioInfo = (ConfigDataScenarioInfo)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, configDataScenarioInfo.m_dialogInfoAfter);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06016C7A RID: 93306 RVA: 0x006159E4 File Offset: 0x00613BE4
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_m_dialogInfoAfter(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataScenarioInfo configDataScenarioInfo = (ConfigDataScenarioInfo)LuaObject.checkSelf(l);
			ConfigDataDialogInfo dialogInfoAfter;
			LuaObject.checkType<ConfigDataDialogInfo>(l, 2, out dialogInfoAfter);
			configDataScenarioInfo.m_dialogInfoAfter = dialogInfoAfter;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06016C7B RID: 93307 RVA: 0x00615A3C File Offset: 0x00613C3C
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_m_scenarioDepth(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataScenarioInfo configDataScenarioInfo = (ConfigDataScenarioInfo)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, configDataScenarioInfo.m_scenarioDepth);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06016C7C RID: 93308 RVA: 0x00615A90 File Offset: 0x00613C90
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_m_scenarioDepth(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataScenarioInfo configDataScenarioInfo = (ConfigDataScenarioInfo)LuaObject.checkSelf(l);
			int scenarioDepth;
			LuaObject.checkType(l, 2, out scenarioDepth);
			configDataScenarioInfo.m_scenarioDepth = scenarioDepth;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06016C7D RID: 93309 RVA: 0x00615AE8 File Offset: 0x00613CE8
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_m_regionInfo(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataScenarioInfo configDataScenarioInfo = (ConfigDataScenarioInfo)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, configDataScenarioInfo.m_regionInfo);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06016C7E RID: 93310 RVA: 0x00615B3C File Offset: 0x00613D3C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_regionInfo(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataScenarioInfo configDataScenarioInfo = (ConfigDataScenarioInfo)LuaObject.checkSelf(l);
			ConfigDataRegionInfo regionInfo;
			LuaObject.checkType<ConfigDataRegionInfo>(l, 2, out regionInfo);
			configDataScenarioInfo.m_regionInfo = regionInfo;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06016C7F RID: 93311 RVA: 0x00615B94 File Offset: 0x00613D94
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_ID(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataScenarioInfo configDataScenarioInfo = (ConfigDataScenarioInfo)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, configDataScenarioInfo.ID);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06016C80 RID: 93312 RVA: 0x00615BE8 File Offset: 0x00613DE8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_ID(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataScenarioInfo configDataScenarioInfo = (ConfigDataScenarioInfo)LuaObject.checkSelf(l);
			int id;
			LuaObject.checkType(l, 2, out id);
			configDataScenarioInfo.ID = id;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06016C81 RID: 93313 RVA: 0x00615C40 File Offset: 0x00613E40
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_Chapter(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataScenarioInfo configDataScenarioInfo = (ConfigDataScenarioInfo)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, configDataScenarioInfo.Chapter);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06016C82 RID: 93314 RVA: 0x00615C94 File Offset: 0x00613E94
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_Chapter(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataScenarioInfo configDataScenarioInfo = (ConfigDataScenarioInfo)LuaObject.checkSelf(l);
			string chapter;
			LuaObject.checkType(l, 2, out chapter);
			configDataScenarioInfo.Chapter = chapter;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06016C83 RID: 93315 RVA: 0x00615CEC File Offset: 0x00613EEC
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_ChapterStrKey(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataScenarioInfo configDataScenarioInfo = (ConfigDataScenarioInfo)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, configDataScenarioInfo.ChapterStrKey);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06016C84 RID: 93316 RVA: 0x00615D40 File Offset: 0x00613F40
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_ChapterStrKey(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataScenarioInfo configDataScenarioInfo = (ConfigDataScenarioInfo)LuaObject.checkSelf(l);
			string chapterStrKey;
			LuaObject.checkType(l, 2, out chapterStrKey);
			configDataScenarioInfo.ChapterStrKey = chapterStrKey;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06016C85 RID: 93317 RVA: 0x00615D98 File Offset: 0x00613F98
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_Name(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataScenarioInfo configDataScenarioInfo = (ConfigDataScenarioInfo)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, configDataScenarioInfo.Name);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06016C86 RID: 93318 RVA: 0x00615DEC File Offset: 0x00613FEC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_Name(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataScenarioInfo configDataScenarioInfo = (ConfigDataScenarioInfo)LuaObject.checkSelf(l);
			string name;
			LuaObject.checkType(l, 2, out name);
			configDataScenarioInfo.Name = name;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06016C87 RID: 93319 RVA: 0x00615E44 File Offset: 0x00614044
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_NameStrKey(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataScenarioInfo configDataScenarioInfo = (ConfigDataScenarioInfo)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, configDataScenarioInfo.NameStrKey);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06016C88 RID: 93320 RVA: 0x00615E98 File Offset: 0x00614098
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_NameStrKey(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataScenarioInfo configDataScenarioInfo = (ConfigDataScenarioInfo)LuaObject.checkSelf(l);
			string nameStrKey;
			LuaObject.checkType(l, 2, out nameStrKey);
			configDataScenarioInfo.NameStrKey = nameStrKey;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06016C89 RID: 93321 RVA: 0x00615EF0 File Offset: 0x006140F0
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_Desc(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataScenarioInfo configDataScenarioInfo = (ConfigDataScenarioInfo)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, configDataScenarioInfo.Desc);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06016C8A RID: 93322 RVA: 0x00615F44 File Offset: 0x00614144
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_Desc(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataScenarioInfo configDataScenarioInfo = (ConfigDataScenarioInfo)LuaObject.checkSelf(l);
			string desc;
			LuaObject.checkType(l, 2, out desc);
			configDataScenarioInfo.Desc = desc;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06016C8B RID: 93323 RVA: 0x00615F9C File Offset: 0x0061419C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_DescStrKey(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataScenarioInfo configDataScenarioInfo = (ConfigDataScenarioInfo)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, configDataScenarioInfo.DescStrKey);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06016C8C RID: 93324 RVA: 0x00615FF0 File Offset: 0x006141F0
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_DescStrKey(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataScenarioInfo configDataScenarioInfo = (ConfigDataScenarioInfo)LuaObject.checkSelf(l);
			string descStrKey;
			LuaObject.checkType(l, 2, out descStrKey);
			configDataScenarioInfo.DescStrKey = descStrKey;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06016C8D RID: 93325 RVA: 0x00616048 File Offset: 0x00614248
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_Waypoint_ID(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataScenarioInfo configDataScenarioInfo = (ConfigDataScenarioInfo)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, configDataScenarioInfo.Waypoint_ID);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06016C8E RID: 93326 RVA: 0x0061609C File Offset: 0x0061429C
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_Waypoint_ID(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataScenarioInfo configDataScenarioInfo = (ConfigDataScenarioInfo)LuaObject.checkSelf(l);
			int waypoint_ID;
			LuaObject.checkType(l, 2, out waypoint_ID);
			configDataScenarioInfo.Waypoint_ID = waypoint_ID;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06016C8F RID: 93327 RVA: 0x006160F4 File Offset: 0x006142F4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_NextScenario_ID(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataScenarioInfo configDataScenarioInfo = (ConfigDataScenarioInfo)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, configDataScenarioInfo.NextScenario_ID);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06016C90 RID: 93328 RVA: 0x00616148 File Offset: 0x00614348
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_NextScenario_ID(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataScenarioInfo configDataScenarioInfo = (ConfigDataScenarioInfo)LuaObject.checkSelf(l);
			int nextScenario_ID;
			LuaObject.checkType(l, 2, out nextScenario_ID);
			configDataScenarioInfo.NextScenario_ID = nextScenario_ID;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06016C91 RID: 93329 RVA: 0x006161A0 File Offset: 0x006143A0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_MonsterLevel(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataScenarioInfo configDataScenarioInfo = (ConfigDataScenarioInfo)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, configDataScenarioInfo.MonsterLevel);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06016C92 RID: 93330 RVA: 0x006161F4 File Offset: 0x006143F4
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_MonsterLevel(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataScenarioInfo configDataScenarioInfo = (ConfigDataScenarioInfo)LuaObject.checkSelf(l);
			int monsterLevel;
			LuaObject.checkType(l, 2, out monsterLevel);
			configDataScenarioInfo.MonsterLevel = monsterLevel;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06016C93 RID: 93331 RVA: 0x0061624C File Offset: 0x0061444C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_Battle_ID(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataScenarioInfo configDataScenarioInfo = (ConfigDataScenarioInfo)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, configDataScenarioInfo.Battle_ID);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06016C94 RID: 93332 RVA: 0x006162A0 File Offset: 0x006144A0
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_Battle_ID(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataScenarioInfo configDataScenarioInfo = (ConfigDataScenarioInfo)LuaObject.checkSelf(l);
			int battle_ID;
			LuaObject.checkType(l, 2, out battle_ID);
			configDataScenarioInfo.Battle_ID = battle_ID;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06016C95 RID: 93333 RVA: 0x006162F8 File Offset: 0x006144F8
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_DialogBefore_ID(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataScenarioInfo configDataScenarioInfo = (ConfigDataScenarioInfo)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, configDataScenarioInfo.DialogBefore_ID);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06016C96 RID: 93334 RVA: 0x0061634C File Offset: 0x0061454C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_DialogBefore_ID(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataScenarioInfo configDataScenarioInfo = (ConfigDataScenarioInfo)LuaObject.checkSelf(l);
			int dialogBefore_ID;
			LuaObject.checkType(l, 2, out dialogBefore_ID);
			configDataScenarioInfo.DialogBefore_ID = dialogBefore_ID;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06016C97 RID: 93335 RVA: 0x006163A4 File Offset: 0x006145A4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_DialogAfter_ID(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataScenarioInfo configDataScenarioInfo = (ConfigDataScenarioInfo)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, configDataScenarioInfo.DialogAfter_ID);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06016C98 RID: 93336 RVA: 0x006163F8 File Offset: 0x006145F8
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_DialogAfter_ID(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataScenarioInfo configDataScenarioInfo = (ConfigDataScenarioInfo)LuaObject.checkSelf(l);
			int dialogAfter_ID;
			LuaObject.checkType(l, 2, out dialogAfter_ID);
			configDataScenarioInfo.DialogAfter_ID = dialogAfter_ID;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06016C99 RID: 93337 RVA: 0x00616450 File Offset: 0x00614650
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_UnlockCondition(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataScenarioInfo configDataScenarioInfo = (ConfigDataScenarioInfo)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, configDataScenarioInfo.UnlockCondition);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06016C9A RID: 93338 RVA: 0x006164A4 File Offset: 0x006146A4
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_PlayerExpReward(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataScenarioInfo configDataScenarioInfo = (ConfigDataScenarioInfo)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, configDataScenarioInfo.PlayerExpReward);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06016C9B RID: 93339 RVA: 0x006164F8 File Offset: 0x006146F8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_PlayerExpReward(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataScenarioInfo configDataScenarioInfo = (ConfigDataScenarioInfo)LuaObject.checkSelf(l);
			int playerExpReward;
			LuaObject.checkType(l, 2, out playerExpReward);
			configDataScenarioInfo.PlayerExpReward = playerExpReward;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06016C9C RID: 93340 RVA: 0x00616550 File Offset: 0x00614750
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_HeroExpReward(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataScenarioInfo configDataScenarioInfo = (ConfigDataScenarioInfo)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, configDataScenarioInfo.HeroExpReward);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06016C9D RID: 93341 RVA: 0x006165A4 File Offset: 0x006147A4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_HeroExpReward(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataScenarioInfo configDataScenarioInfo = (ConfigDataScenarioInfo)LuaObject.checkSelf(l);
			int heroExpReward;
			LuaObject.checkType(l, 2, out heroExpReward);
			configDataScenarioInfo.HeroExpReward = heroExpReward;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06016C9E RID: 93342 RVA: 0x006165FC File Offset: 0x006147FC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_GoldReward(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataScenarioInfo configDataScenarioInfo = (ConfigDataScenarioInfo)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, configDataScenarioInfo.GoldReward);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06016C9F RID: 93343 RVA: 0x00616650 File Offset: 0x00614850
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_GoldReward(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataScenarioInfo configDataScenarioInfo = (ConfigDataScenarioInfo)LuaObject.checkSelf(l);
			int goldReward;
			LuaObject.checkType(l, 2, out goldReward);
			configDataScenarioInfo.GoldReward = goldReward;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06016CA0 RID: 93344 RVA: 0x006166A8 File Offset: 0x006148A8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_EnergySuccess(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataScenarioInfo configDataScenarioInfo = (ConfigDataScenarioInfo)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, configDataScenarioInfo.EnergySuccess);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06016CA1 RID: 93345 RVA: 0x006166FC File Offset: 0x006148FC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_EnergySuccess(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataScenarioInfo configDataScenarioInfo = (ConfigDataScenarioInfo)LuaObject.checkSelf(l);
			int energySuccess;
			LuaObject.checkType(l, 2, out energySuccess);
			configDataScenarioInfo.EnergySuccess = energySuccess;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06016CA2 RID: 93346 RVA: 0x00616754 File Offset: 0x00614954
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_EnergyFail(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataScenarioInfo configDataScenarioInfo = (ConfigDataScenarioInfo)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, configDataScenarioInfo.EnergyFail);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06016CA3 RID: 93347 RVA: 0x006167A8 File Offset: 0x006149A8
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_EnergyFail(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataScenarioInfo configDataScenarioInfo = (ConfigDataScenarioInfo)LuaObject.checkSelf(l);
			int energyFail;
			LuaObject.checkType(l, 2, out energyFail);
			configDataScenarioInfo.EnergyFail = energyFail;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06016CA4 RID: 93348 RVA: 0x00616800 File Offset: 0x00614A00
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_FirstReward(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataScenarioInfo configDataScenarioInfo = (ConfigDataScenarioInfo)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, configDataScenarioInfo.FirstReward);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06016CA5 RID: 93349 RVA: 0x00616854 File Offset: 0x00614A54
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_Drop_ID(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataScenarioInfo configDataScenarioInfo = (ConfigDataScenarioInfo)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, configDataScenarioInfo.Drop_ID);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06016CA6 RID: 93350 RVA: 0x006168A8 File Offset: 0x00614AA8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_Drop_ID(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataScenarioInfo configDataScenarioInfo = (ConfigDataScenarioInfo)LuaObject.checkSelf(l);
			int drop_ID;
			LuaObject.checkType(l, 2, out drop_ID);
			configDataScenarioInfo.Drop_ID = drop_ID;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06016CA7 RID: 93351 RVA: 0x00616900 File Offset: 0x00614B00
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_Strategy(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataScenarioInfo configDataScenarioInfo = (ConfigDataScenarioInfo)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, configDataScenarioInfo.Strategy);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06016CA8 RID: 93352 RVA: 0x00616954 File Offset: 0x00614B54
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_Strategy(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataScenarioInfo configDataScenarioInfo = (ConfigDataScenarioInfo)LuaObject.checkSelf(l);
			string strategy;
			LuaObject.checkType(l, 2, out strategy);
			configDataScenarioInfo.Strategy = strategy;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06016CA9 RID: 93353 RVA: 0x006169AC File Offset: 0x00614BAC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_IsOpened(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataScenarioInfo configDataScenarioInfo = (ConfigDataScenarioInfo)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, configDataScenarioInfo.IsOpened);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06016CAA RID: 93354 RVA: 0x00616A00 File Offset: 0x00614C00
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_IsOpened(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataScenarioInfo configDataScenarioInfo = (ConfigDataScenarioInfo)LuaObject.checkSelf(l);
			bool isOpened;
			LuaObject.checkType(l, 2, out isOpened);
			configDataScenarioInfo.IsOpened = isOpened;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06016CAB RID: 93355 RVA: 0x00616A58 File Offset: 0x00614C58
	[Preserve]
	public static void reg(IntPtr l)
	{
		LuaObject.getTypeTable(l, "BlackJack.ConfigData.ConfigDataScenarioInfo");
		string name = "m_waypointInfo";
		if (Lua_BlackJack_ConfigData_ConfigDataScenarioInfo.<>f__mg$cache0 == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataScenarioInfo.<>f__mg$cache0 = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataScenarioInfo.get_m_waypointInfo);
		}
		LuaCSFunction get = Lua_BlackJack_ConfigData_ConfigDataScenarioInfo.<>f__mg$cache0;
		if (Lua_BlackJack_ConfigData_ConfigDataScenarioInfo.<>f__mg$cache1 == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataScenarioInfo.<>f__mg$cache1 = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataScenarioInfo.set_m_waypointInfo);
		}
		LuaObject.addMember(l, name, get, Lua_BlackJack_ConfigData_ConfigDataScenarioInfo.<>f__mg$cache1, true);
		string name2 = "m_nextScenarioInfo";
		if (Lua_BlackJack_ConfigData_ConfigDataScenarioInfo.<>f__mg$cache2 == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataScenarioInfo.<>f__mg$cache2 = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataScenarioInfo.get_m_nextScenarioInfo);
		}
		LuaCSFunction get2 = Lua_BlackJack_ConfigData_ConfigDataScenarioInfo.<>f__mg$cache2;
		if (Lua_BlackJack_ConfigData_ConfigDataScenarioInfo.<>f__mg$cache3 == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataScenarioInfo.<>f__mg$cache3 = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataScenarioInfo.set_m_nextScenarioInfo);
		}
		LuaObject.addMember(l, name2, get2, Lua_BlackJack_ConfigData_ConfigDataScenarioInfo.<>f__mg$cache3, true);
		string name3 = "m_battleInfo";
		if (Lua_BlackJack_ConfigData_ConfigDataScenarioInfo.<>f__mg$cache4 == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataScenarioInfo.<>f__mg$cache4 = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataScenarioInfo.get_m_battleInfo);
		}
		LuaCSFunction get3 = Lua_BlackJack_ConfigData_ConfigDataScenarioInfo.<>f__mg$cache4;
		if (Lua_BlackJack_ConfigData_ConfigDataScenarioInfo.<>f__mg$cache5 == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataScenarioInfo.<>f__mg$cache5 = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataScenarioInfo.set_m_battleInfo);
		}
		LuaObject.addMember(l, name3, get3, Lua_BlackJack_ConfigData_ConfigDataScenarioInfo.<>f__mg$cache5, true);
		string name4 = "m_dialogInfoBefore";
		if (Lua_BlackJack_ConfigData_ConfigDataScenarioInfo.<>f__mg$cache6 == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataScenarioInfo.<>f__mg$cache6 = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataScenarioInfo.get_m_dialogInfoBefore);
		}
		LuaCSFunction get4 = Lua_BlackJack_ConfigData_ConfigDataScenarioInfo.<>f__mg$cache6;
		if (Lua_BlackJack_ConfigData_ConfigDataScenarioInfo.<>f__mg$cache7 == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataScenarioInfo.<>f__mg$cache7 = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataScenarioInfo.set_m_dialogInfoBefore);
		}
		LuaObject.addMember(l, name4, get4, Lua_BlackJack_ConfigData_ConfigDataScenarioInfo.<>f__mg$cache7, true);
		string name5 = "m_dialogInfoAfter";
		if (Lua_BlackJack_ConfigData_ConfigDataScenarioInfo.<>f__mg$cache8 == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataScenarioInfo.<>f__mg$cache8 = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataScenarioInfo.get_m_dialogInfoAfter);
		}
		LuaCSFunction get5 = Lua_BlackJack_ConfigData_ConfigDataScenarioInfo.<>f__mg$cache8;
		if (Lua_BlackJack_ConfigData_ConfigDataScenarioInfo.<>f__mg$cache9 == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataScenarioInfo.<>f__mg$cache9 = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataScenarioInfo.set_m_dialogInfoAfter);
		}
		LuaObject.addMember(l, name5, get5, Lua_BlackJack_ConfigData_ConfigDataScenarioInfo.<>f__mg$cache9, true);
		string name6 = "m_scenarioDepth";
		if (Lua_BlackJack_ConfigData_ConfigDataScenarioInfo.<>f__mg$cacheA == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataScenarioInfo.<>f__mg$cacheA = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataScenarioInfo.get_m_scenarioDepth);
		}
		LuaCSFunction get6 = Lua_BlackJack_ConfigData_ConfigDataScenarioInfo.<>f__mg$cacheA;
		if (Lua_BlackJack_ConfigData_ConfigDataScenarioInfo.<>f__mg$cacheB == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataScenarioInfo.<>f__mg$cacheB = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataScenarioInfo.set_m_scenarioDepth);
		}
		LuaObject.addMember(l, name6, get6, Lua_BlackJack_ConfigData_ConfigDataScenarioInfo.<>f__mg$cacheB, true);
		string name7 = "m_regionInfo";
		if (Lua_BlackJack_ConfigData_ConfigDataScenarioInfo.<>f__mg$cacheC == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataScenarioInfo.<>f__mg$cacheC = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataScenarioInfo.get_m_regionInfo);
		}
		LuaCSFunction get7 = Lua_BlackJack_ConfigData_ConfigDataScenarioInfo.<>f__mg$cacheC;
		if (Lua_BlackJack_ConfigData_ConfigDataScenarioInfo.<>f__mg$cacheD == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataScenarioInfo.<>f__mg$cacheD = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataScenarioInfo.set_m_regionInfo);
		}
		LuaObject.addMember(l, name7, get7, Lua_BlackJack_ConfigData_ConfigDataScenarioInfo.<>f__mg$cacheD, true);
		string name8 = "ID";
		if (Lua_BlackJack_ConfigData_ConfigDataScenarioInfo.<>f__mg$cacheE == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataScenarioInfo.<>f__mg$cacheE = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataScenarioInfo.get_ID);
		}
		LuaCSFunction get8 = Lua_BlackJack_ConfigData_ConfigDataScenarioInfo.<>f__mg$cacheE;
		if (Lua_BlackJack_ConfigData_ConfigDataScenarioInfo.<>f__mg$cacheF == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataScenarioInfo.<>f__mg$cacheF = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataScenarioInfo.set_ID);
		}
		LuaObject.addMember(l, name8, get8, Lua_BlackJack_ConfigData_ConfigDataScenarioInfo.<>f__mg$cacheF, true);
		string name9 = "Chapter";
		if (Lua_BlackJack_ConfigData_ConfigDataScenarioInfo.<>f__mg$cache10 == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataScenarioInfo.<>f__mg$cache10 = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataScenarioInfo.get_Chapter);
		}
		LuaCSFunction get9 = Lua_BlackJack_ConfigData_ConfigDataScenarioInfo.<>f__mg$cache10;
		if (Lua_BlackJack_ConfigData_ConfigDataScenarioInfo.<>f__mg$cache11 == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataScenarioInfo.<>f__mg$cache11 = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataScenarioInfo.set_Chapter);
		}
		LuaObject.addMember(l, name9, get9, Lua_BlackJack_ConfigData_ConfigDataScenarioInfo.<>f__mg$cache11, true);
		string name10 = "ChapterStrKey";
		if (Lua_BlackJack_ConfigData_ConfigDataScenarioInfo.<>f__mg$cache12 == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataScenarioInfo.<>f__mg$cache12 = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataScenarioInfo.get_ChapterStrKey);
		}
		LuaCSFunction get10 = Lua_BlackJack_ConfigData_ConfigDataScenarioInfo.<>f__mg$cache12;
		if (Lua_BlackJack_ConfigData_ConfigDataScenarioInfo.<>f__mg$cache13 == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataScenarioInfo.<>f__mg$cache13 = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataScenarioInfo.set_ChapterStrKey);
		}
		LuaObject.addMember(l, name10, get10, Lua_BlackJack_ConfigData_ConfigDataScenarioInfo.<>f__mg$cache13, true);
		string name11 = "Name";
		if (Lua_BlackJack_ConfigData_ConfigDataScenarioInfo.<>f__mg$cache14 == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataScenarioInfo.<>f__mg$cache14 = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataScenarioInfo.get_Name);
		}
		LuaCSFunction get11 = Lua_BlackJack_ConfigData_ConfigDataScenarioInfo.<>f__mg$cache14;
		if (Lua_BlackJack_ConfigData_ConfigDataScenarioInfo.<>f__mg$cache15 == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataScenarioInfo.<>f__mg$cache15 = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataScenarioInfo.set_Name);
		}
		LuaObject.addMember(l, name11, get11, Lua_BlackJack_ConfigData_ConfigDataScenarioInfo.<>f__mg$cache15, true);
		string name12 = "NameStrKey";
		if (Lua_BlackJack_ConfigData_ConfigDataScenarioInfo.<>f__mg$cache16 == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataScenarioInfo.<>f__mg$cache16 = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataScenarioInfo.get_NameStrKey);
		}
		LuaCSFunction get12 = Lua_BlackJack_ConfigData_ConfigDataScenarioInfo.<>f__mg$cache16;
		if (Lua_BlackJack_ConfigData_ConfigDataScenarioInfo.<>f__mg$cache17 == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataScenarioInfo.<>f__mg$cache17 = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataScenarioInfo.set_NameStrKey);
		}
		LuaObject.addMember(l, name12, get12, Lua_BlackJack_ConfigData_ConfigDataScenarioInfo.<>f__mg$cache17, true);
		string name13 = "Desc";
		if (Lua_BlackJack_ConfigData_ConfigDataScenarioInfo.<>f__mg$cache18 == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataScenarioInfo.<>f__mg$cache18 = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataScenarioInfo.get_Desc);
		}
		LuaCSFunction get13 = Lua_BlackJack_ConfigData_ConfigDataScenarioInfo.<>f__mg$cache18;
		if (Lua_BlackJack_ConfigData_ConfigDataScenarioInfo.<>f__mg$cache19 == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataScenarioInfo.<>f__mg$cache19 = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataScenarioInfo.set_Desc);
		}
		LuaObject.addMember(l, name13, get13, Lua_BlackJack_ConfigData_ConfigDataScenarioInfo.<>f__mg$cache19, true);
		string name14 = "DescStrKey";
		if (Lua_BlackJack_ConfigData_ConfigDataScenarioInfo.<>f__mg$cache1A == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataScenarioInfo.<>f__mg$cache1A = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataScenarioInfo.get_DescStrKey);
		}
		LuaCSFunction get14 = Lua_BlackJack_ConfigData_ConfigDataScenarioInfo.<>f__mg$cache1A;
		if (Lua_BlackJack_ConfigData_ConfigDataScenarioInfo.<>f__mg$cache1B == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataScenarioInfo.<>f__mg$cache1B = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataScenarioInfo.set_DescStrKey);
		}
		LuaObject.addMember(l, name14, get14, Lua_BlackJack_ConfigData_ConfigDataScenarioInfo.<>f__mg$cache1B, true);
		string name15 = "Waypoint_ID";
		if (Lua_BlackJack_ConfigData_ConfigDataScenarioInfo.<>f__mg$cache1C == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataScenarioInfo.<>f__mg$cache1C = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataScenarioInfo.get_Waypoint_ID);
		}
		LuaCSFunction get15 = Lua_BlackJack_ConfigData_ConfigDataScenarioInfo.<>f__mg$cache1C;
		if (Lua_BlackJack_ConfigData_ConfigDataScenarioInfo.<>f__mg$cache1D == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataScenarioInfo.<>f__mg$cache1D = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataScenarioInfo.set_Waypoint_ID);
		}
		LuaObject.addMember(l, name15, get15, Lua_BlackJack_ConfigData_ConfigDataScenarioInfo.<>f__mg$cache1D, true);
		string name16 = "NextScenario_ID";
		if (Lua_BlackJack_ConfigData_ConfigDataScenarioInfo.<>f__mg$cache1E == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataScenarioInfo.<>f__mg$cache1E = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataScenarioInfo.get_NextScenario_ID);
		}
		LuaCSFunction get16 = Lua_BlackJack_ConfigData_ConfigDataScenarioInfo.<>f__mg$cache1E;
		if (Lua_BlackJack_ConfigData_ConfigDataScenarioInfo.<>f__mg$cache1F == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataScenarioInfo.<>f__mg$cache1F = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataScenarioInfo.set_NextScenario_ID);
		}
		LuaObject.addMember(l, name16, get16, Lua_BlackJack_ConfigData_ConfigDataScenarioInfo.<>f__mg$cache1F, true);
		string name17 = "MonsterLevel";
		if (Lua_BlackJack_ConfigData_ConfigDataScenarioInfo.<>f__mg$cache20 == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataScenarioInfo.<>f__mg$cache20 = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataScenarioInfo.get_MonsterLevel);
		}
		LuaCSFunction get17 = Lua_BlackJack_ConfigData_ConfigDataScenarioInfo.<>f__mg$cache20;
		if (Lua_BlackJack_ConfigData_ConfigDataScenarioInfo.<>f__mg$cache21 == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataScenarioInfo.<>f__mg$cache21 = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataScenarioInfo.set_MonsterLevel);
		}
		LuaObject.addMember(l, name17, get17, Lua_BlackJack_ConfigData_ConfigDataScenarioInfo.<>f__mg$cache21, true);
		string name18 = "Battle_ID";
		if (Lua_BlackJack_ConfigData_ConfigDataScenarioInfo.<>f__mg$cache22 == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataScenarioInfo.<>f__mg$cache22 = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataScenarioInfo.get_Battle_ID);
		}
		LuaCSFunction get18 = Lua_BlackJack_ConfigData_ConfigDataScenarioInfo.<>f__mg$cache22;
		if (Lua_BlackJack_ConfigData_ConfigDataScenarioInfo.<>f__mg$cache23 == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataScenarioInfo.<>f__mg$cache23 = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataScenarioInfo.set_Battle_ID);
		}
		LuaObject.addMember(l, name18, get18, Lua_BlackJack_ConfigData_ConfigDataScenarioInfo.<>f__mg$cache23, true);
		string name19 = "DialogBefore_ID";
		if (Lua_BlackJack_ConfigData_ConfigDataScenarioInfo.<>f__mg$cache24 == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataScenarioInfo.<>f__mg$cache24 = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataScenarioInfo.get_DialogBefore_ID);
		}
		LuaCSFunction get19 = Lua_BlackJack_ConfigData_ConfigDataScenarioInfo.<>f__mg$cache24;
		if (Lua_BlackJack_ConfigData_ConfigDataScenarioInfo.<>f__mg$cache25 == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataScenarioInfo.<>f__mg$cache25 = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataScenarioInfo.set_DialogBefore_ID);
		}
		LuaObject.addMember(l, name19, get19, Lua_BlackJack_ConfigData_ConfigDataScenarioInfo.<>f__mg$cache25, true);
		string name20 = "DialogAfter_ID";
		if (Lua_BlackJack_ConfigData_ConfigDataScenarioInfo.<>f__mg$cache26 == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataScenarioInfo.<>f__mg$cache26 = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataScenarioInfo.get_DialogAfter_ID);
		}
		LuaCSFunction get20 = Lua_BlackJack_ConfigData_ConfigDataScenarioInfo.<>f__mg$cache26;
		if (Lua_BlackJack_ConfigData_ConfigDataScenarioInfo.<>f__mg$cache27 == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataScenarioInfo.<>f__mg$cache27 = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataScenarioInfo.set_DialogAfter_ID);
		}
		LuaObject.addMember(l, name20, get20, Lua_BlackJack_ConfigData_ConfigDataScenarioInfo.<>f__mg$cache27, true);
		string name21 = "UnlockCondition";
		if (Lua_BlackJack_ConfigData_ConfigDataScenarioInfo.<>f__mg$cache28 == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataScenarioInfo.<>f__mg$cache28 = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataScenarioInfo.get_UnlockCondition);
		}
		LuaObject.addMember(l, name21, Lua_BlackJack_ConfigData_ConfigDataScenarioInfo.<>f__mg$cache28, null, true);
		string name22 = "PlayerExpReward";
		if (Lua_BlackJack_ConfigData_ConfigDataScenarioInfo.<>f__mg$cache29 == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataScenarioInfo.<>f__mg$cache29 = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataScenarioInfo.get_PlayerExpReward);
		}
		LuaCSFunction get21 = Lua_BlackJack_ConfigData_ConfigDataScenarioInfo.<>f__mg$cache29;
		if (Lua_BlackJack_ConfigData_ConfigDataScenarioInfo.<>f__mg$cache2A == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataScenarioInfo.<>f__mg$cache2A = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataScenarioInfo.set_PlayerExpReward);
		}
		LuaObject.addMember(l, name22, get21, Lua_BlackJack_ConfigData_ConfigDataScenarioInfo.<>f__mg$cache2A, true);
		string name23 = "HeroExpReward";
		if (Lua_BlackJack_ConfigData_ConfigDataScenarioInfo.<>f__mg$cache2B == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataScenarioInfo.<>f__mg$cache2B = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataScenarioInfo.get_HeroExpReward);
		}
		LuaCSFunction get22 = Lua_BlackJack_ConfigData_ConfigDataScenarioInfo.<>f__mg$cache2B;
		if (Lua_BlackJack_ConfigData_ConfigDataScenarioInfo.<>f__mg$cache2C == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataScenarioInfo.<>f__mg$cache2C = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataScenarioInfo.set_HeroExpReward);
		}
		LuaObject.addMember(l, name23, get22, Lua_BlackJack_ConfigData_ConfigDataScenarioInfo.<>f__mg$cache2C, true);
		string name24 = "GoldReward";
		if (Lua_BlackJack_ConfigData_ConfigDataScenarioInfo.<>f__mg$cache2D == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataScenarioInfo.<>f__mg$cache2D = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataScenarioInfo.get_GoldReward);
		}
		LuaCSFunction get23 = Lua_BlackJack_ConfigData_ConfigDataScenarioInfo.<>f__mg$cache2D;
		if (Lua_BlackJack_ConfigData_ConfigDataScenarioInfo.<>f__mg$cache2E == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataScenarioInfo.<>f__mg$cache2E = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataScenarioInfo.set_GoldReward);
		}
		LuaObject.addMember(l, name24, get23, Lua_BlackJack_ConfigData_ConfigDataScenarioInfo.<>f__mg$cache2E, true);
		string name25 = "EnergySuccess";
		if (Lua_BlackJack_ConfigData_ConfigDataScenarioInfo.<>f__mg$cache2F == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataScenarioInfo.<>f__mg$cache2F = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataScenarioInfo.get_EnergySuccess);
		}
		LuaCSFunction get24 = Lua_BlackJack_ConfigData_ConfigDataScenarioInfo.<>f__mg$cache2F;
		if (Lua_BlackJack_ConfigData_ConfigDataScenarioInfo.<>f__mg$cache30 == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataScenarioInfo.<>f__mg$cache30 = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataScenarioInfo.set_EnergySuccess);
		}
		LuaObject.addMember(l, name25, get24, Lua_BlackJack_ConfigData_ConfigDataScenarioInfo.<>f__mg$cache30, true);
		string name26 = "EnergyFail";
		if (Lua_BlackJack_ConfigData_ConfigDataScenarioInfo.<>f__mg$cache31 == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataScenarioInfo.<>f__mg$cache31 = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataScenarioInfo.get_EnergyFail);
		}
		LuaCSFunction get25 = Lua_BlackJack_ConfigData_ConfigDataScenarioInfo.<>f__mg$cache31;
		if (Lua_BlackJack_ConfigData_ConfigDataScenarioInfo.<>f__mg$cache32 == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataScenarioInfo.<>f__mg$cache32 = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataScenarioInfo.set_EnergyFail);
		}
		LuaObject.addMember(l, name26, get25, Lua_BlackJack_ConfigData_ConfigDataScenarioInfo.<>f__mg$cache32, true);
		string name27 = "FirstReward";
		if (Lua_BlackJack_ConfigData_ConfigDataScenarioInfo.<>f__mg$cache33 == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataScenarioInfo.<>f__mg$cache33 = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataScenarioInfo.get_FirstReward);
		}
		LuaObject.addMember(l, name27, Lua_BlackJack_ConfigData_ConfigDataScenarioInfo.<>f__mg$cache33, null, true);
		string name28 = "Drop_ID";
		if (Lua_BlackJack_ConfigData_ConfigDataScenarioInfo.<>f__mg$cache34 == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataScenarioInfo.<>f__mg$cache34 = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataScenarioInfo.get_Drop_ID);
		}
		LuaCSFunction get26 = Lua_BlackJack_ConfigData_ConfigDataScenarioInfo.<>f__mg$cache34;
		if (Lua_BlackJack_ConfigData_ConfigDataScenarioInfo.<>f__mg$cache35 == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataScenarioInfo.<>f__mg$cache35 = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataScenarioInfo.set_Drop_ID);
		}
		LuaObject.addMember(l, name28, get26, Lua_BlackJack_ConfigData_ConfigDataScenarioInfo.<>f__mg$cache35, true);
		string name29 = "Strategy";
		if (Lua_BlackJack_ConfigData_ConfigDataScenarioInfo.<>f__mg$cache36 == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataScenarioInfo.<>f__mg$cache36 = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataScenarioInfo.get_Strategy);
		}
		LuaCSFunction get27 = Lua_BlackJack_ConfigData_ConfigDataScenarioInfo.<>f__mg$cache36;
		if (Lua_BlackJack_ConfigData_ConfigDataScenarioInfo.<>f__mg$cache37 == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataScenarioInfo.<>f__mg$cache37 = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataScenarioInfo.set_Strategy);
		}
		LuaObject.addMember(l, name29, get27, Lua_BlackJack_ConfigData_ConfigDataScenarioInfo.<>f__mg$cache37, true);
		string name30 = "IsOpened";
		if (Lua_BlackJack_ConfigData_ConfigDataScenarioInfo.<>f__mg$cache38 == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataScenarioInfo.<>f__mg$cache38 = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataScenarioInfo.get_IsOpened);
		}
		LuaCSFunction get28 = Lua_BlackJack_ConfigData_ConfigDataScenarioInfo.<>f__mg$cache38;
		if (Lua_BlackJack_ConfigData_ConfigDataScenarioInfo.<>f__mg$cache39 == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataScenarioInfo.<>f__mg$cache39 = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataScenarioInfo.set_IsOpened);
		}
		LuaObject.addMember(l, name30, get28, Lua_BlackJack_ConfigData_ConfigDataScenarioInfo.<>f__mg$cache39, true);
		if (Lua_BlackJack_ConfigData_ConfigDataScenarioInfo.<>f__mg$cache3A == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataScenarioInfo.<>f__mg$cache3A = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataScenarioInfo.constructor);
		}
		LuaObject.createTypeMetatable(l, Lua_BlackJack_ConfigData_ConfigDataScenarioInfo.<>f__mg$cache3A, typeof(ConfigDataScenarioInfo));
	}

	// Token: 0x0400D382 RID: 54146
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache0;

	// Token: 0x0400D383 RID: 54147
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1;

	// Token: 0x0400D384 RID: 54148
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2;

	// Token: 0x0400D385 RID: 54149
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3;

	// Token: 0x0400D386 RID: 54150
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache4;

	// Token: 0x0400D387 RID: 54151
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache5;

	// Token: 0x0400D388 RID: 54152
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache6;

	// Token: 0x0400D389 RID: 54153
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache7;

	// Token: 0x0400D38A RID: 54154
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache8;

	// Token: 0x0400D38B RID: 54155
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache9;

	// Token: 0x0400D38C RID: 54156
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheA;

	// Token: 0x0400D38D RID: 54157
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheB;

	// Token: 0x0400D38E RID: 54158
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheC;

	// Token: 0x0400D38F RID: 54159
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheD;

	// Token: 0x0400D390 RID: 54160
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheE;

	// Token: 0x0400D391 RID: 54161
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheF;

	// Token: 0x0400D392 RID: 54162
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache10;

	// Token: 0x0400D393 RID: 54163
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache11;

	// Token: 0x0400D394 RID: 54164
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache12;

	// Token: 0x0400D395 RID: 54165
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache13;

	// Token: 0x0400D396 RID: 54166
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache14;

	// Token: 0x0400D397 RID: 54167
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache15;

	// Token: 0x0400D398 RID: 54168
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache16;

	// Token: 0x0400D399 RID: 54169
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache17;

	// Token: 0x0400D39A RID: 54170
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache18;

	// Token: 0x0400D39B RID: 54171
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache19;

	// Token: 0x0400D39C RID: 54172
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1A;

	// Token: 0x0400D39D RID: 54173
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1B;

	// Token: 0x0400D39E RID: 54174
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1C;

	// Token: 0x0400D39F RID: 54175
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1D;

	// Token: 0x0400D3A0 RID: 54176
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1E;

	// Token: 0x0400D3A1 RID: 54177
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1F;

	// Token: 0x0400D3A2 RID: 54178
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache20;

	// Token: 0x0400D3A3 RID: 54179
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache21;

	// Token: 0x0400D3A4 RID: 54180
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache22;

	// Token: 0x0400D3A5 RID: 54181
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache23;

	// Token: 0x0400D3A6 RID: 54182
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache24;

	// Token: 0x0400D3A7 RID: 54183
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache25;

	// Token: 0x0400D3A8 RID: 54184
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache26;

	// Token: 0x0400D3A9 RID: 54185
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache27;

	// Token: 0x0400D3AA RID: 54186
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache28;

	// Token: 0x0400D3AB RID: 54187
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache29;

	// Token: 0x0400D3AC RID: 54188
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2A;

	// Token: 0x0400D3AD RID: 54189
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2B;

	// Token: 0x0400D3AE RID: 54190
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2C;

	// Token: 0x0400D3AF RID: 54191
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2D;

	// Token: 0x0400D3B0 RID: 54192
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2E;

	// Token: 0x0400D3B1 RID: 54193
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2F;

	// Token: 0x0400D3B2 RID: 54194
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache30;

	// Token: 0x0400D3B3 RID: 54195
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache31;

	// Token: 0x0400D3B4 RID: 54196
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache32;

	// Token: 0x0400D3B5 RID: 54197
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache33;

	// Token: 0x0400D3B6 RID: 54198
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache34;

	// Token: 0x0400D3B7 RID: 54199
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache35;

	// Token: 0x0400D3B8 RID: 54200
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache36;

	// Token: 0x0400D3B9 RID: 54201
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache37;

	// Token: 0x0400D3BA RID: 54202
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache38;

	// Token: 0x0400D3BB RID: 54203
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache39;

	// Token: 0x0400D3BC RID: 54204
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3A;
}
