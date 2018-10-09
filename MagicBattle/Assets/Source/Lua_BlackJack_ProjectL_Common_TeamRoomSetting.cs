using System;
using System.Runtime.CompilerServices;
using BlackJack.ConfigData;
using BlackJack.ProjectL.Common;
using BlackJack.ProjectL.Protocol;
using SLua;
using UnityEngine.Scripting;

// Token: 0x02001288 RID: 4744
[Preserve]
public class Lua_BlackJack_ProjectL_Common_TeamRoomSetting : LuaObject
{
	// Token: 0x06018B72 RID: 101234 RVA: 0x006FC004 File Offset: 0x006FA204
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int constructor(IntPtr l)
	{
		int result;
		try
		{
			TeamRoomSetting o = new TeamRoomSetting();
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

	// Token: 0x06018B73 RID: 101235 RVA: 0x006FC04C File Offset: 0x006FA24C
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int TeamRoomSettingToPbTeamRoomSetting_s(IntPtr l)
	{
		int result;
		try
		{
			TeamRoomSetting setting;
			LuaObject.checkType<TeamRoomSetting>(l, 1, out setting);
			ProTeamRoomSetting o = TeamRoomSetting.TeamRoomSettingToPbTeamRoomSetting(setting);
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

	// Token: 0x06018B74 RID: 101236 RVA: 0x006FC0A0 File Offset: 0x006FA2A0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int PbTeamRoomSettingToTeamRoomSetting_s(IntPtr l)
	{
		int result;
		try
		{
			ProTeamRoomSetting pbSetting;
			LuaObject.checkType<ProTeamRoomSetting>(l, 1, out pbSetting);
			TeamRoomSetting o = TeamRoomSetting.PbTeamRoomSettingToTeamRoomSetting(pbSetting);
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

	// Token: 0x06018B75 RID: 101237 RVA: 0x006FC0F4 File Offset: 0x006FA2F4
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_GameFunctionTypeId(IntPtr l)
	{
		int result;
		try
		{
			TeamRoomSetting teamRoomSetting = (TeamRoomSetting)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushEnum(l, (int)teamRoomSetting.GameFunctionTypeId);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06018B76 RID: 101238 RVA: 0x006FC148 File Offset: 0x006FA348
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_GameFunctionTypeId(IntPtr l)
	{
		int result;
		try
		{
			TeamRoomSetting teamRoomSetting = (TeamRoomSetting)LuaObject.checkSelf(l);
			GameFunctionType gameFunctionTypeId;
			LuaObject.checkEnum<GameFunctionType>(l, 2, out gameFunctionTypeId);
			teamRoomSetting.GameFunctionTypeId = gameFunctionTypeId;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06018B77 RID: 101239 RVA: 0x006FC1A0 File Offset: 0x006FA3A0
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_LocationId(IntPtr l)
	{
		int result;
		try
		{
			TeamRoomSetting teamRoomSetting = (TeamRoomSetting)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, teamRoomSetting.LocationId);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06018B78 RID: 101240 RVA: 0x006FC1F4 File Offset: 0x006FA3F4
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_LocationId(IntPtr l)
	{
		int result;
		try
		{
			TeamRoomSetting teamRoomSetting = (TeamRoomSetting)LuaObject.checkSelf(l);
			int locationId;
			LuaObject.checkType(l, 2, out locationId);
			teamRoomSetting.LocationId = locationId;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06018B79 RID: 101241 RVA: 0x006FC24C File Offset: 0x006FA44C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_JoinMinLevel(IntPtr l)
	{
		int result;
		try
		{
			TeamRoomSetting teamRoomSetting = (TeamRoomSetting)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, teamRoomSetting.JoinMinLevel);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06018B7A RID: 101242 RVA: 0x006FC2A0 File Offset: 0x006FA4A0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_JoinMinLevel(IntPtr l)
	{
		int result;
		try
		{
			TeamRoomSetting teamRoomSetting = (TeamRoomSetting)LuaObject.checkSelf(l);
			int joinMinLevel;
			LuaObject.checkType(l, 2, out joinMinLevel);
			teamRoomSetting.JoinMinLevel = joinMinLevel;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06018B7B RID: 101243 RVA: 0x006FC2F8 File Offset: 0x006FA4F8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_JoinMaxLevel(IntPtr l)
	{
		int result;
		try
		{
			TeamRoomSetting teamRoomSetting = (TeamRoomSetting)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, teamRoomSetting.JoinMaxLevel);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06018B7C RID: 101244 RVA: 0x006FC34C File Offset: 0x006FA54C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_JoinMaxLevel(IntPtr l)
	{
		int result;
		try
		{
			TeamRoomSetting teamRoomSetting = (TeamRoomSetting)LuaObject.checkSelf(l);
			int joinMaxLevel;
			LuaObject.checkType(l, 2, out joinMaxLevel);
			teamRoomSetting.JoinMaxLevel = joinMaxLevel;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06018B7D RID: 101245 RVA: 0x006FC3A4 File Offset: 0x006FA5A4
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_Authority(IntPtr l)
	{
		int result;
		try
		{
			TeamRoomSetting teamRoomSetting = (TeamRoomSetting)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushEnum(l, (int)teamRoomSetting.Authority);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06018B7E RID: 101246 RVA: 0x006FC3F8 File Offset: 0x006FA5F8
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_Authority(IntPtr l)
	{
		int result;
		try
		{
			TeamRoomSetting teamRoomSetting = (TeamRoomSetting)LuaObject.checkSelf(l);
			TeamRoomAuthority authority;
			LuaObject.checkEnum<TeamRoomAuthority>(l, 2, out authority);
			teamRoomSetting.Authority = authority;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06018B7F RID: 101247 RVA: 0x006FC450 File Offset: 0x006FA650
	[Preserve]
	public static void reg(IntPtr l)
	{
		LuaObject.getTypeTable(l, "BlackJack.ProjectL.Common.TeamRoomSetting");
		if (Lua_BlackJack_ProjectL_Common_TeamRoomSetting.<>f__mg$cache0 == null)
		{
			Lua_BlackJack_ProjectL_Common_TeamRoomSetting.<>f__mg$cache0 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_TeamRoomSetting.TeamRoomSettingToPbTeamRoomSetting_s);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_TeamRoomSetting.<>f__mg$cache0);
		if (Lua_BlackJack_ProjectL_Common_TeamRoomSetting.<>f__mg$cache1 == null)
		{
			Lua_BlackJack_ProjectL_Common_TeamRoomSetting.<>f__mg$cache1 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_TeamRoomSetting.PbTeamRoomSettingToTeamRoomSetting_s);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_TeamRoomSetting.<>f__mg$cache1);
		string name = "GameFunctionTypeId";
		if (Lua_BlackJack_ProjectL_Common_TeamRoomSetting.<>f__mg$cache2 == null)
		{
			Lua_BlackJack_ProjectL_Common_TeamRoomSetting.<>f__mg$cache2 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_TeamRoomSetting.get_GameFunctionTypeId);
		}
		LuaCSFunction get = Lua_BlackJack_ProjectL_Common_TeamRoomSetting.<>f__mg$cache2;
		if (Lua_BlackJack_ProjectL_Common_TeamRoomSetting.<>f__mg$cache3 == null)
		{
			Lua_BlackJack_ProjectL_Common_TeamRoomSetting.<>f__mg$cache3 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_TeamRoomSetting.set_GameFunctionTypeId);
		}
		LuaObject.addMember(l, name, get, Lua_BlackJack_ProjectL_Common_TeamRoomSetting.<>f__mg$cache3, true);
		string name2 = "LocationId";
		if (Lua_BlackJack_ProjectL_Common_TeamRoomSetting.<>f__mg$cache4 == null)
		{
			Lua_BlackJack_ProjectL_Common_TeamRoomSetting.<>f__mg$cache4 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_TeamRoomSetting.get_LocationId);
		}
		LuaCSFunction get2 = Lua_BlackJack_ProjectL_Common_TeamRoomSetting.<>f__mg$cache4;
		if (Lua_BlackJack_ProjectL_Common_TeamRoomSetting.<>f__mg$cache5 == null)
		{
			Lua_BlackJack_ProjectL_Common_TeamRoomSetting.<>f__mg$cache5 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_TeamRoomSetting.set_LocationId);
		}
		LuaObject.addMember(l, name2, get2, Lua_BlackJack_ProjectL_Common_TeamRoomSetting.<>f__mg$cache5, true);
		string name3 = "JoinMinLevel";
		if (Lua_BlackJack_ProjectL_Common_TeamRoomSetting.<>f__mg$cache6 == null)
		{
			Lua_BlackJack_ProjectL_Common_TeamRoomSetting.<>f__mg$cache6 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_TeamRoomSetting.get_JoinMinLevel);
		}
		LuaCSFunction get3 = Lua_BlackJack_ProjectL_Common_TeamRoomSetting.<>f__mg$cache6;
		if (Lua_BlackJack_ProjectL_Common_TeamRoomSetting.<>f__mg$cache7 == null)
		{
			Lua_BlackJack_ProjectL_Common_TeamRoomSetting.<>f__mg$cache7 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_TeamRoomSetting.set_JoinMinLevel);
		}
		LuaObject.addMember(l, name3, get3, Lua_BlackJack_ProjectL_Common_TeamRoomSetting.<>f__mg$cache7, true);
		string name4 = "JoinMaxLevel";
		if (Lua_BlackJack_ProjectL_Common_TeamRoomSetting.<>f__mg$cache8 == null)
		{
			Lua_BlackJack_ProjectL_Common_TeamRoomSetting.<>f__mg$cache8 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_TeamRoomSetting.get_JoinMaxLevel);
		}
		LuaCSFunction get4 = Lua_BlackJack_ProjectL_Common_TeamRoomSetting.<>f__mg$cache8;
		if (Lua_BlackJack_ProjectL_Common_TeamRoomSetting.<>f__mg$cache9 == null)
		{
			Lua_BlackJack_ProjectL_Common_TeamRoomSetting.<>f__mg$cache9 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_TeamRoomSetting.set_JoinMaxLevel);
		}
		LuaObject.addMember(l, name4, get4, Lua_BlackJack_ProjectL_Common_TeamRoomSetting.<>f__mg$cache9, true);
		string name5 = "Authority";
		if (Lua_BlackJack_ProjectL_Common_TeamRoomSetting.<>f__mg$cacheA == null)
		{
			Lua_BlackJack_ProjectL_Common_TeamRoomSetting.<>f__mg$cacheA = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_TeamRoomSetting.get_Authority);
		}
		LuaCSFunction get5 = Lua_BlackJack_ProjectL_Common_TeamRoomSetting.<>f__mg$cacheA;
		if (Lua_BlackJack_ProjectL_Common_TeamRoomSetting.<>f__mg$cacheB == null)
		{
			Lua_BlackJack_ProjectL_Common_TeamRoomSetting.<>f__mg$cacheB = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_TeamRoomSetting.set_Authority);
		}
		LuaObject.addMember(l, name5, get5, Lua_BlackJack_ProjectL_Common_TeamRoomSetting.<>f__mg$cacheB, true);
		if (Lua_BlackJack_ProjectL_Common_TeamRoomSetting.<>f__mg$cacheC == null)
		{
			Lua_BlackJack_ProjectL_Common_TeamRoomSetting.<>f__mg$cacheC = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_TeamRoomSetting.constructor);
		}
		LuaObject.createTypeMetatable(l, Lua_BlackJack_ProjectL_Common_TeamRoomSetting.<>f__mg$cacheC, typeof(TeamRoomSetting));
	}

	// Token: 0x0400F044 RID: 61508
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache0;

	// Token: 0x0400F045 RID: 61509
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1;

	// Token: 0x0400F046 RID: 61510
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2;

	// Token: 0x0400F047 RID: 61511
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3;

	// Token: 0x0400F048 RID: 61512
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache4;

	// Token: 0x0400F049 RID: 61513
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache5;

	// Token: 0x0400F04A RID: 61514
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache6;

	// Token: 0x0400F04B RID: 61515
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache7;

	// Token: 0x0400F04C RID: 61516
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache8;

	// Token: 0x0400F04D RID: 61517
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache9;

	// Token: 0x0400F04E RID: 61518
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheA;

	// Token: 0x0400F04F RID: 61519
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheB;

	// Token: 0x0400F050 RID: 61520
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheC;
}
