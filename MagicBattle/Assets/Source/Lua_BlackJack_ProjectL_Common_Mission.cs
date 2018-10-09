using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using BlackJack.ConfigData;
using BlackJack.ProjectL.Common;
using BlackJack.ProjectL.Protocol;
using SLua;
using UnityEngine.Scripting;

// Token: 0x02001251 RID: 4689
[Preserve]
public class Lua_BlackJack_ProjectL_Common_Mission : LuaObject
{
	// Token: 0x0601862C RID: 99884 RVA: 0x006D4F9C File Offset: 0x006D319C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int constructor(IntPtr l)
	{
		int result;
		try
		{
			int missionId;
			LuaObject.checkType(l, 2, out missionId);
			Mission o = new Mission(missionId);
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

	// Token: 0x0601862D RID: 99885 RVA: 0x006D4FF0 File Offset: 0x006D31F0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int PBMissionToMission_s(IntPtr l)
	{
		int result;
		try
		{
			ProMission pbMission;
			LuaObject.checkType<ProMission>(l, 1, out pbMission);
			Mission o = Mission.PBMissionToMission(pbMission);
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

	// Token: 0x0601862E RID: 99886 RVA: 0x006D5044 File Offset: 0x006D3244
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int PBMissionListToMissionList_s(IntPtr l)
	{
		int result;
		try
		{
			List<ProMission> pbMissionList;
			LuaObject.checkType<List<ProMission>>(l, 1, out pbMissionList);
			List<Mission> o = Mission.PBMissionListToMissionList(pbMissionList);
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

	// Token: 0x0601862F RID: 99887 RVA: 0x006D5098 File Offset: 0x006D3298
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int MissionToPBMission_s(IntPtr l)
	{
		int result;
		try
		{
			Mission misson;
			LuaObject.checkType<Mission>(l, 1, out misson);
			ProMission o = Mission.MissionToPBMission(misson);
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

	// Token: 0x06018630 RID: 99888 RVA: 0x006D50EC File Offset: 0x006D32EC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int MissionListToPBMissionList_s(IntPtr l)
	{
		int result;
		try
		{
			List<Mission> missionList;
			LuaObject.checkType<List<Mission>>(l, 1, out missionList);
			List<ProMission> o = Mission.MissionListToPBMissionList(missionList);
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

	// Token: 0x06018631 RID: 99889 RVA: 0x006D5140 File Offset: 0x006D3340
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_MissionId(IntPtr l)
	{
		int result;
		try
		{
			Mission mission = (Mission)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, mission.MissionId);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06018632 RID: 99890 RVA: 0x006D5194 File Offset: 0x006D3394
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_MissionId(IntPtr l)
	{
		int result;
		try
		{
			Mission mission = (Mission)LuaObject.checkSelf(l);
			int missionId;
			LuaObject.checkType(l, 2, out missionId);
			mission.MissionId = missionId;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06018633 RID: 99891 RVA: 0x006D51EC File Offset: 0x006D33EC
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_CompletedProcess(IntPtr l)
	{
		int result;
		try
		{
			Mission mission = (Mission)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, mission.CompletedProcess);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06018634 RID: 99892 RVA: 0x006D5240 File Offset: 0x006D3440
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_CompletedProcess(IntPtr l)
	{
		int result;
		try
		{
			Mission mission = (Mission)LuaObject.checkSelf(l);
			long completedProcess;
			LuaObject.checkType(l, 2, out completedProcess);
			mission.CompletedProcess = completedProcess;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06018635 RID: 99893 RVA: 0x006D5298 File Offset: 0x006D3498
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_Config(IntPtr l)
	{
		int result;
		try
		{
			Mission mission = (Mission)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, mission.Config);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06018636 RID: 99894 RVA: 0x006D52EC File Offset: 0x006D34EC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_Config(IntPtr l)
	{
		int result;
		try
		{
			Mission mission = (Mission)LuaObject.checkSelf(l);
			ConfigDataMissionInfo config;
			LuaObject.checkType<ConfigDataMissionInfo>(l, 2, out config);
			mission.Config = config;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06018637 RID: 99895 RVA: 0x006D5344 File Offset: 0x006D3544
	[Preserve]
	public static void reg(IntPtr l)
	{
		LuaObject.getTypeTable(l, "BlackJack.ProjectL.Common.Mission");
		if (Lua_BlackJack_ProjectL_Common_Mission.<>f__mg$cache0 == null)
		{
			Lua_BlackJack_ProjectL_Common_Mission.<>f__mg$cache0 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_Mission.PBMissionToMission_s);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_Mission.<>f__mg$cache0);
		if (Lua_BlackJack_ProjectL_Common_Mission.<>f__mg$cache1 == null)
		{
			Lua_BlackJack_ProjectL_Common_Mission.<>f__mg$cache1 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_Mission.PBMissionListToMissionList_s);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_Mission.<>f__mg$cache1);
		if (Lua_BlackJack_ProjectL_Common_Mission.<>f__mg$cache2 == null)
		{
			Lua_BlackJack_ProjectL_Common_Mission.<>f__mg$cache2 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_Mission.MissionToPBMission_s);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_Mission.<>f__mg$cache2);
		if (Lua_BlackJack_ProjectL_Common_Mission.<>f__mg$cache3 == null)
		{
			Lua_BlackJack_ProjectL_Common_Mission.<>f__mg$cache3 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_Mission.MissionListToPBMissionList_s);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_Mission.<>f__mg$cache3);
		string name = "MissionId";
		if (Lua_BlackJack_ProjectL_Common_Mission.<>f__mg$cache4 == null)
		{
			Lua_BlackJack_ProjectL_Common_Mission.<>f__mg$cache4 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_Mission.get_MissionId);
		}
		LuaCSFunction get = Lua_BlackJack_ProjectL_Common_Mission.<>f__mg$cache4;
		if (Lua_BlackJack_ProjectL_Common_Mission.<>f__mg$cache5 == null)
		{
			Lua_BlackJack_ProjectL_Common_Mission.<>f__mg$cache5 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_Mission.set_MissionId);
		}
		LuaObject.addMember(l, name, get, Lua_BlackJack_ProjectL_Common_Mission.<>f__mg$cache5, true);
		string name2 = "CompletedProcess";
		if (Lua_BlackJack_ProjectL_Common_Mission.<>f__mg$cache6 == null)
		{
			Lua_BlackJack_ProjectL_Common_Mission.<>f__mg$cache6 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_Mission.get_CompletedProcess);
		}
		LuaCSFunction get2 = Lua_BlackJack_ProjectL_Common_Mission.<>f__mg$cache6;
		if (Lua_BlackJack_ProjectL_Common_Mission.<>f__mg$cache7 == null)
		{
			Lua_BlackJack_ProjectL_Common_Mission.<>f__mg$cache7 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_Mission.set_CompletedProcess);
		}
		LuaObject.addMember(l, name2, get2, Lua_BlackJack_ProjectL_Common_Mission.<>f__mg$cache7, true);
		string name3 = "Config";
		if (Lua_BlackJack_ProjectL_Common_Mission.<>f__mg$cache8 == null)
		{
			Lua_BlackJack_ProjectL_Common_Mission.<>f__mg$cache8 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_Mission.get_Config);
		}
		LuaCSFunction get3 = Lua_BlackJack_ProjectL_Common_Mission.<>f__mg$cache8;
		if (Lua_BlackJack_ProjectL_Common_Mission.<>f__mg$cache9 == null)
		{
			Lua_BlackJack_ProjectL_Common_Mission.<>f__mg$cache9 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_Mission.set_Config);
		}
		LuaObject.addMember(l, name3, get3, Lua_BlackJack_ProjectL_Common_Mission.<>f__mg$cache9, true);
		if (Lua_BlackJack_ProjectL_Common_Mission.<>f__mg$cacheA == null)
		{
			Lua_BlackJack_ProjectL_Common_Mission.<>f__mg$cacheA = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_Mission.constructor);
		}
		LuaObject.createTypeMetatable(l, Lua_BlackJack_ProjectL_Common_Mission.<>f__mg$cacheA, typeof(Mission));
	}

	// Token: 0x0400EB6C RID: 60268
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache0;

	// Token: 0x0400EB6D RID: 60269
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1;

	// Token: 0x0400EB6E RID: 60270
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2;

	// Token: 0x0400EB6F RID: 60271
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3;

	// Token: 0x0400EB70 RID: 60272
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache4;

	// Token: 0x0400EB71 RID: 60273
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache5;

	// Token: 0x0400EB72 RID: 60274
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache6;

	// Token: 0x0400EB73 RID: 60275
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache7;

	// Token: 0x0400EB74 RID: 60276
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache8;

	// Token: 0x0400EB75 RID: 60277
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache9;

	// Token: 0x0400EB76 RID: 60278
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheA;
}
