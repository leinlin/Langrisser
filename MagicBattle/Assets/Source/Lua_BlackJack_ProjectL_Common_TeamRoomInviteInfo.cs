using System;
using System.Runtime.CompilerServices;
using BlackJack.ProjectL.Common;
using BlackJack.ProjectL.Protocol;
using SLua;
using UnityEngine.Scripting;

// Token: 0x02001286 RID: 4742
[Preserve]
public class Lua_BlackJack_ProjectL_Common_TeamRoomInviteInfo : LuaObject
{
	// Token: 0x06018B46 RID: 101190 RVA: 0x006FACE4 File Offset: 0x006F8EE4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int constructor(IntPtr l)
	{
		int result;
		try
		{
			TeamRoomInviteInfo o = new TeamRoomInviteInfo();
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

	// Token: 0x06018B47 RID: 101191 RVA: 0x006FAD2C File Offset: 0x006F8F2C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int PbTeamRoomInviteInfoToTeamRoomInviteInfo_s(IntPtr l)
	{
		int result;
		try
		{
			ProTeamRoomInviteInfo pbInfo;
			LuaObject.checkType<ProTeamRoomInviteInfo>(l, 1, out pbInfo);
			TeamRoomInviteInfo o = TeamRoomInviteInfo.PbTeamRoomInviteInfoToTeamRoomInviteInfo(pbInfo);
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

	// Token: 0x06018B48 RID: 101192 RVA: 0x006FAD80 File Offset: 0x006F8F80
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int TeamRoomInviteInfoToPbTeamRoomInviteInfo_s(IntPtr l)
	{
		int result;
		try
		{
			TeamRoomInviteInfo info;
			LuaObject.checkType<TeamRoomInviteInfo>(l, 1, out info);
			ProTeamRoomInviteInfo o = TeamRoomInviteInfo.TeamRoomInviteInfoToPbTeamRoomInviteInfo(info);
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

	// Token: 0x06018B49 RID: 101193 RVA: 0x006FADD4 File Offset: 0x006F8FD4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_SessionId(IntPtr l)
	{
		int result;
		try
		{
			TeamRoomInviteInfo teamRoomInviteInfo = (TeamRoomInviteInfo)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, teamRoomInviteInfo.SessionId);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06018B4A RID: 101194 RVA: 0x006FAE28 File Offset: 0x006F9028
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_SessionId(IntPtr l)
	{
		int result;
		try
		{
			TeamRoomInviteInfo teamRoomInviteInfo = (TeamRoomInviteInfo)LuaObject.checkSelf(l);
			ulong sessionId;
			LuaObject.checkType(l, 2, out sessionId);
			teamRoomInviteInfo.SessionId = sessionId;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06018B4B RID: 101195 RVA: 0x006FAE80 File Offset: 0x006F9080
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_ChannelId(IntPtr l)
	{
		int result;
		try
		{
			TeamRoomInviteInfo teamRoomInviteInfo = (TeamRoomInviteInfo)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, teamRoomInviteInfo.ChannelId);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06018B4C RID: 101196 RVA: 0x006FAED4 File Offset: 0x006F90D4
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_ChannelId(IntPtr l)
	{
		int result;
		try
		{
			TeamRoomInviteInfo teamRoomInviteInfo = (TeamRoomInviteInfo)LuaObject.checkSelf(l);
			int channelId;
			LuaObject.checkType(l, 2, out channelId);
			teamRoomInviteInfo.ChannelId = channelId;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06018B4D RID: 101197 RVA: 0x006FAF2C File Offset: 0x006F912C
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_Name(IntPtr l)
	{
		int result;
		try
		{
			TeamRoomInviteInfo teamRoomInviteInfo = (TeamRoomInviteInfo)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, teamRoomInviteInfo.Name);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06018B4E RID: 101198 RVA: 0x006FAF80 File Offset: 0x006F9180
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_Name(IntPtr l)
	{
		int result;
		try
		{
			TeamRoomInviteInfo teamRoomInviteInfo = (TeamRoomInviteInfo)LuaObject.checkSelf(l);
			string name;
			LuaObject.checkType(l, 2, out name);
			teamRoomInviteInfo.Name = name;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06018B4F RID: 101199 RVA: 0x006FAFD8 File Offset: 0x006F91D8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_Level(IntPtr l)
	{
		int result;
		try
		{
			TeamRoomInviteInfo teamRoomInviteInfo = (TeamRoomInviteInfo)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, teamRoomInviteInfo.Level);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06018B50 RID: 101200 RVA: 0x006FB02C File Offset: 0x006F922C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_Level(IntPtr l)
	{
		int result;
		try
		{
			TeamRoomInviteInfo teamRoomInviteInfo = (TeamRoomInviteInfo)LuaObject.checkSelf(l);
			int level;
			LuaObject.checkType(l, 2, out level);
			teamRoomInviteInfo.Level = level;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06018B51 RID: 101201 RVA: 0x006FB084 File Offset: 0x006F9284
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_RoomId(IntPtr l)
	{
		int result;
		try
		{
			TeamRoomInviteInfo teamRoomInviteInfo = (TeamRoomInviteInfo)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, teamRoomInviteInfo.RoomId);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06018B52 RID: 101202 RVA: 0x006FB0D8 File Offset: 0x006F92D8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_RoomId(IntPtr l)
	{
		int result;
		try
		{
			TeamRoomInviteInfo teamRoomInviteInfo = (TeamRoomInviteInfo)LuaObject.checkSelf(l);
			int roomId;
			LuaObject.checkType(l, 2, out roomId);
			teamRoomInviteInfo.RoomId = roomId;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06018B53 RID: 101203 RVA: 0x006FB130 File Offset: 0x006F9330
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_GameFunctionTypeId(IntPtr l)
	{
		int result;
		try
		{
			TeamRoomInviteInfo teamRoomInviteInfo = (TeamRoomInviteInfo)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, teamRoomInviteInfo.GameFunctionTypeId);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06018B54 RID: 101204 RVA: 0x006FB184 File Offset: 0x006F9384
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_GameFunctionTypeId(IntPtr l)
	{
		int result;
		try
		{
			TeamRoomInviteInfo teamRoomInviteInfo = (TeamRoomInviteInfo)LuaObject.checkSelf(l);
			int gameFunctionTypeId;
			LuaObject.checkType(l, 2, out gameFunctionTypeId);
			teamRoomInviteInfo.GameFunctionTypeId = gameFunctionTypeId;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06018B55 RID: 101205 RVA: 0x006FB1DC File Offset: 0x006F93DC
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_LocationId(IntPtr l)
	{
		int result;
		try
		{
			TeamRoomInviteInfo teamRoomInviteInfo = (TeamRoomInviteInfo)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, teamRoomInviteInfo.LocationId);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06018B56 RID: 101206 RVA: 0x006FB230 File Offset: 0x006F9430
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_LocationId(IntPtr l)
	{
		int result;
		try
		{
			TeamRoomInviteInfo teamRoomInviteInfo = (TeamRoomInviteInfo)LuaObject.checkSelf(l);
			int locationId;
			LuaObject.checkType(l, 2, out locationId);
			teamRoomInviteInfo.LocationId = locationId;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06018B57 RID: 101207 RVA: 0x006FB288 File Offset: 0x006F9488
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_TimeOut(IntPtr l)
	{
		int result;
		try
		{
			TeamRoomInviteInfo teamRoomInviteInfo = (TeamRoomInviteInfo)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, teamRoomInviteInfo.TimeOut);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06018B58 RID: 101208 RVA: 0x006FB2E0 File Offset: 0x006F94E0
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_TimeOut(IntPtr l)
	{
		int result;
		try
		{
			TeamRoomInviteInfo teamRoomInviteInfo = (TeamRoomInviteInfo)LuaObject.checkSelf(l);
			DateTime timeOut;
			LuaObject.checkValueType<DateTime>(l, 2, out timeOut);
			teamRoomInviteInfo.TimeOut = timeOut;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06018B59 RID: 101209 RVA: 0x006FB338 File Offset: 0x006F9538
	[Preserve]
	public static void reg(IntPtr l)
	{
		LuaObject.getTypeTable(l, "BlackJack.ProjectL.Common.TeamRoomInviteInfo");
		if (Lua_BlackJack_ProjectL_Common_TeamRoomInviteInfo.<>f__mg$cache0 == null)
		{
			Lua_BlackJack_ProjectL_Common_TeamRoomInviteInfo.<>f__mg$cache0 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_TeamRoomInviteInfo.PbTeamRoomInviteInfoToTeamRoomInviteInfo_s);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_TeamRoomInviteInfo.<>f__mg$cache0);
		if (Lua_BlackJack_ProjectL_Common_TeamRoomInviteInfo.<>f__mg$cache1 == null)
		{
			Lua_BlackJack_ProjectL_Common_TeamRoomInviteInfo.<>f__mg$cache1 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_TeamRoomInviteInfo.TeamRoomInviteInfoToPbTeamRoomInviteInfo_s);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_TeamRoomInviteInfo.<>f__mg$cache1);
		string name = "SessionId";
		if (Lua_BlackJack_ProjectL_Common_TeamRoomInviteInfo.<>f__mg$cache2 == null)
		{
			Lua_BlackJack_ProjectL_Common_TeamRoomInviteInfo.<>f__mg$cache2 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_TeamRoomInviteInfo.get_SessionId);
		}
		LuaCSFunction get = Lua_BlackJack_ProjectL_Common_TeamRoomInviteInfo.<>f__mg$cache2;
		if (Lua_BlackJack_ProjectL_Common_TeamRoomInviteInfo.<>f__mg$cache3 == null)
		{
			Lua_BlackJack_ProjectL_Common_TeamRoomInviteInfo.<>f__mg$cache3 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_TeamRoomInviteInfo.set_SessionId);
		}
		LuaObject.addMember(l, name, get, Lua_BlackJack_ProjectL_Common_TeamRoomInviteInfo.<>f__mg$cache3, true);
		string name2 = "ChannelId";
		if (Lua_BlackJack_ProjectL_Common_TeamRoomInviteInfo.<>f__mg$cache4 == null)
		{
			Lua_BlackJack_ProjectL_Common_TeamRoomInviteInfo.<>f__mg$cache4 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_TeamRoomInviteInfo.get_ChannelId);
		}
		LuaCSFunction get2 = Lua_BlackJack_ProjectL_Common_TeamRoomInviteInfo.<>f__mg$cache4;
		if (Lua_BlackJack_ProjectL_Common_TeamRoomInviteInfo.<>f__mg$cache5 == null)
		{
			Lua_BlackJack_ProjectL_Common_TeamRoomInviteInfo.<>f__mg$cache5 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_TeamRoomInviteInfo.set_ChannelId);
		}
		LuaObject.addMember(l, name2, get2, Lua_BlackJack_ProjectL_Common_TeamRoomInviteInfo.<>f__mg$cache5, true);
		string name3 = "Name";
		if (Lua_BlackJack_ProjectL_Common_TeamRoomInviteInfo.<>f__mg$cache6 == null)
		{
			Lua_BlackJack_ProjectL_Common_TeamRoomInviteInfo.<>f__mg$cache6 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_TeamRoomInviteInfo.get_Name);
		}
		LuaCSFunction get3 = Lua_BlackJack_ProjectL_Common_TeamRoomInviteInfo.<>f__mg$cache6;
		if (Lua_BlackJack_ProjectL_Common_TeamRoomInviteInfo.<>f__mg$cache7 == null)
		{
			Lua_BlackJack_ProjectL_Common_TeamRoomInviteInfo.<>f__mg$cache7 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_TeamRoomInviteInfo.set_Name);
		}
		LuaObject.addMember(l, name3, get3, Lua_BlackJack_ProjectL_Common_TeamRoomInviteInfo.<>f__mg$cache7, true);
		string name4 = "Level";
		if (Lua_BlackJack_ProjectL_Common_TeamRoomInviteInfo.<>f__mg$cache8 == null)
		{
			Lua_BlackJack_ProjectL_Common_TeamRoomInviteInfo.<>f__mg$cache8 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_TeamRoomInviteInfo.get_Level);
		}
		LuaCSFunction get4 = Lua_BlackJack_ProjectL_Common_TeamRoomInviteInfo.<>f__mg$cache8;
		if (Lua_BlackJack_ProjectL_Common_TeamRoomInviteInfo.<>f__mg$cache9 == null)
		{
			Lua_BlackJack_ProjectL_Common_TeamRoomInviteInfo.<>f__mg$cache9 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_TeamRoomInviteInfo.set_Level);
		}
		LuaObject.addMember(l, name4, get4, Lua_BlackJack_ProjectL_Common_TeamRoomInviteInfo.<>f__mg$cache9, true);
		string name5 = "RoomId";
		if (Lua_BlackJack_ProjectL_Common_TeamRoomInviteInfo.<>f__mg$cacheA == null)
		{
			Lua_BlackJack_ProjectL_Common_TeamRoomInviteInfo.<>f__mg$cacheA = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_TeamRoomInviteInfo.get_RoomId);
		}
		LuaCSFunction get5 = Lua_BlackJack_ProjectL_Common_TeamRoomInviteInfo.<>f__mg$cacheA;
		if (Lua_BlackJack_ProjectL_Common_TeamRoomInviteInfo.<>f__mg$cacheB == null)
		{
			Lua_BlackJack_ProjectL_Common_TeamRoomInviteInfo.<>f__mg$cacheB = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_TeamRoomInviteInfo.set_RoomId);
		}
		LuaObject.addMember(l, name5, get5, Lua_BlackJack_ProjectL_Common_TeamRoomInviteInfo.<>f__mg$cacheB, true);
		string name6 = "GameFunctionTypeId";
		if (Lua_BlackJack_ProjectL_Common_TeamRoomInviteInfo.<>f__mg$cacheC == null)
		{
			Lua_BlackJack_ProjectL_Common_TeamRoomInviteInfo.<>f__mg$cacheC = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_TeamRoomInviteInfo.get_GameFunctionTypeId);
		}
		LuaCSFunction get6 = Lua_BlackJack_ProjectL_Common_TeamRoomInviteInfo.<>f__mg$cacheC;
		if (Lua_BlackJack_ProjectL_Common_TeamRoomInviteInfo.<>f__mg$cacheD == null)
		{
			Lua_BlackJack_ProjectL_Common_TeamRoomInviteInfo.<>f__mg$cacheD = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_TeamRoomInviteInfo.set_GameFunctionTypeId);
		}
		LuaObject.addMember(l, name6, get6, Lua_BlackJack_ProjectL_Common_TeamRoomInviteInfo.<>f__mg$cacheD, true);
		string name7 = "LocationId";
		if (Lua_BlackJack_ProjectL_Common_TeamRoomInviteInfo.<>f__mg$cacheE == null)
		{
			Lua_BlackJack_ProjectL_Common_TeamRoomInviteInfo.<>f__mg$cacheE = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_TeamRoomInviteInfo.get_LocationId);
		}
		LuaCSFunction get7 = Lua_BlackJack_ProjectL_Common_TeamRoomInviteInfo.<>f__mg$cacheE;
		if (Lua_BlackJack_ProjectL_Common_TeamRoomInviteInfo.<>f__mg$cacheF == null)
		{
			Lua_BlackJack_ProjectL_Common_TeamRoomInviteInfo.<>f__mg$cacheF = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_TeamRoomInviteInfo.set_LocationId);
		}
		LuaObject.addMember(l, name7, get7, Lua_BlackJack_ProjectL_Common_TeamRoomInviteInfo.<>f__mg$cacheF, true);
		string name8 = "TimeOut";
		if (Lua_BlackJack_ProjectL_Common_TeamRoomInviteInfo.<>f__mg$cache10 == null)
		{
			Lua_BlackJack_ProjectL_Common_TeamRoomInviteInfo.<>f__mg$cache10 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_TeamRoomInviteInfo.get_TimeOut);
		}
		LuaCSFunction get8 = Lua_BlackJack_ProjectL_Common_TeamRoomInviteInfo.<>f__mg$cache10;
		if (Lua_BlackJack_ProjectL_Common_TeamRoomInviteInfo.<>f__mg$cache11 == null)
		{
			Lua_BlackJack_ProjectL_Common_TeamRoomInviteInfo.<>f__mg$cache11 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_TeamRoomInviteInfo.set_TimeOut);
		}
		LuaObject.addMember(l, name8, get8, Lua_BlackJack_ProjectL_Common_TeamRoomInviteInfo.<>f__mg$cache11, true);
		if (Lua_BlackJack_ProjectL_Common_TeamRoomInviteInfo.<>f__mg$cache12 == null)
		{
			Lua_BlackJack_ProjectL_Common_TeamRoomInviteInfo.<>f__mg$cache12 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_TeamRoomInviteInfo.constructor);
		}
		LuaObject.createTypeMetatable(l, Lua_BlackJack_ProjectL_Common_TeamRoomInviteInfo.<>f__mg$cache12, typeof(TeamRoomInviteInfo));
	}

	// Token: 0x0400F01C RID: 61468
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache0;

	// Token: 0x0400F01D RID: 61469
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1;

	// Token: 0x0400F01E RID: 61470
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2;

	// Token: 0x0400F01F RID: 61471
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3;

	// Token: 0x0400F020 RID: 61472
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache4;

	// Token: 0x0400F021 RID: 61473
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache5;

	// Token: 0x0400F022 RID: 61474
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache6;

	// Token: 0x0400F023 RID: 61475
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache7;

	// Token: 0x0400F024 RID: 61476
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache8;

	// Token: 0x0400F025 RID: 61477
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache9;

	// Token: 0x0400F026 RID: 61478
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheA;

	// Token: 0x0400F027 RID: 61479
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheB;

	// Token: 0x0400F028 RID: 61480
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheC;

	// Token: 0x0400F029 RID: 61481
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheD;

	// Token: 0x0400F02A RID: 61482
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheE;

	// Token: 0x0400F02B RID: 61483
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheF;

	// Token: 0x0400F02C RID: 61484
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache10;

	// Token: 0x0400F02D RID: 61485
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache11;

	// Token: 0x0400F02E RID: 61486
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache12;
}
