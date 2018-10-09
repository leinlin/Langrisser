using System;
using System.Runtime.CompilerServices;
using BlackJack.ProjectL.Common;
using BlackJack.ProjectL.Protocol;
using SLua;
using UnityEngine.Scripting;

// Token: 0x02001287 RID: 4743
[Preserve]
public class Lua_BlackJack_ProjectL_Common_TeamRoomPlayer : LuaObject
{
	// Token: 0x06018B5B RID: 101211 RVA: 0x006FB5FC File Offset: 0x006F97FC
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int constructor(IntPtr l)
	{
		int result;
		try
		{
			TeamRoomPlayer o = new TeamRoomPlayer();
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

	// Token: 0x06018B5C RID: 101212 RVA: 0x006FB644 File Offset: 0x006F9844
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int TeamRoomPlayerToPbTeamRoomPlayer_s(IntPtr l)
	{
		int result;
		try
		{
			TeamRoomPlayer player;
			LuaObject.checkType<TeamRoomPlayer>(l, 1, out player);
			ProTeamRoomPlayer o = TeamRoomPlayer.TeamRoomPlayerToPbTeamRoomPlayer(player);
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

	// Token: 0x06018B5D RID: 101213 RVA: 0x006FB698 File Offset: 0x006F9898
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int PbTeamRoomPlayerToTeamRoomPlayer_s(IntPtr l)
	{
		int result;
		try
		{
			ProTeamRoomPlayer pbPlayer;
			LuaObject.checkType<ProTeamRoomPlayer>(l, 1, out pbPlayer);
			TeamRoomPlayer o = TeamRoomPlayer.PbTeamRoomPlayerToTeamRoomPlayer(pbPlayer);
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

	// Token: 0x06018B5E RID: 101214 RVA: 0x006FB6EC File Offset: 0x006F98EC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_UserId(IntPtr l)
	{
		int result;
		try
		{
			TeamRoomPlayer teamRoomPlayer = (TeamRoomPlayer)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, teamRoomPlayer.UserId);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06018B5F RID: 101215 RVA: 0x006FB740 File Offset: 0x006F9940
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_UserId(IntPtr l)
	{
		int result;
		try
		{
			TeamRoomPlayer teamRoomPlayer = (TeamRoomPlayer)LuaObject.checkSelf(l);
			string userId;
			LuaObject.checkType(l, 2, out userId);
			teamRoomPlayer.UserId = userId;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06018B60 RID: 101216 RVA: 0x006FB798 File Offset: 0x006F9998
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_SessionId(IntPtr l)
	{
		int result;
		try
		{
			TeamRoomPlayer teamRoomPlayer = (TeamRoomPlayer)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, teamRoomPlayer.SessionId);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06018B61 RID: 101217 RVA: 0x006FB7EC File Offset: 0x006F99EC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_SessionId(IntPtr l)
	{
		int result;
		try
		{
			TeamRoomPlayer teamRoomPlayer = (TeamRoomPlayer)LuaObject.checkSelf(l);
			ulong sessionId;
			LuaObject.checkType(l, 2, out sessionId);
			teamRoomPlayer.SessionId = sessionId;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06018B62 RID: 101218 RVA: 0x006FB844 File Offset: 0x006F9A44
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_ChannelId(IntPtr l)
	{
		int result;
		try
		{
			TeamRoomPlayer teamRoomPlayer = (TeamRoomPlayer)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, teamRoomPlayer.ChannelId);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06018B63 RID: 101219 RVA: 0x006FB898 File Offset: 0x006F9A98
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_ChannelId(IntPtr l)
	{
		int result;
		try
		{
			TeamRoomPlayer teamRoomPlayer = (TeamRoomPlayer)LuaObject.checkSelf(l);
			int channelId;
			LuaObject.checkType(l, 2, out channelId);
			teamRoomPlayer.ChannelId = channelId;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06018B64 RID: 101220 RVA: 0x006FB8F0 File Offset: 0x006F9AF0
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_Name(IntPtr l)
	{
		int result;
		try
		{
			TeamRoomPlayer teamRoomPlayer = (TeamRoomPlayer)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, teamRoomPlayer.Name);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06018B65 RID: 101221 RVA: 0x006FB944 File Offset: 0x006F9B44
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_Name(IntPtr l)
	{
		int result;
		try
		{
			TeamRoomPlayer teamRoomPlayer = (TeamRoomPlayer)LuaObject.checkSelf(l);
			string name;
			LuaObject.checkType(l, 2, out name);
			teamRoomPlayer.Name = name;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06018B66 RID: 101222 RVA: 0x006FB99C File Offset: 0x006F9B9C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_HeadIcon(IntPtr l)
	{
		int result;
		try
		{
			TeamRoomPlayer teamRoomPlayer = (TeamRoomPlayer)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, teamRoomPlayer.HeadIcon);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06018B67 RID: 101223 RVA: 0x006FB9F0 File Offset: 0x006F9BF0
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_HeadIcon(IntPtr l)
	{
		int result;
		try
		{
			TeamRoomPlayer teamRoomPlayer = (TeamRoomPlayer)LuaObject.checkSelf(l);
			int headIcon;
			LuaObject.checkType(l, 2, out headIcon);
			teamRoomPlayer.HeadIcon = headIcon;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06018B68 RID: 101224 RVA: 0x006FBA48 File Offset: 0x006F9C48
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_ActiveHeroJobRelatedId(IntPtr l)
	{
		int result;
		try
		{
			TeamRoomPlayer teamRoomPlayer = (TeamRoomPlayer)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, teamRoomPlayer.ActiveHeroJobRelatedId);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06018B69 RID: 101225 RVA: 0x006FBA9C File Offset: 0x006F9C9C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_ActiveHeroJobRelatedId(IntPtr l)
	{
		int result;
		try
		{
			TeamRoomPlayer teamRoomPlayer = (TeamRoomPlayer)LuaObject.checkSelf(l);
			int activeHeroJobRelatedId;
			LuaObject.checkType(l, 2, out activeHeroJobRelatedId);
			teamRoomPlayer.ActiveHeroJobRelatedId = activeHeroJobRelatedId;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06018B6A RID: 101226 RVA: 0x006FBAF4 File Offset: 0x006F9CF4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_Level(IntPtr l)
	{
		int result;
		try
		{
			TeamRoomPlayer teamRoomPlayer = (TeamRoomPlayer)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, teamRoomPlayer.Level);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06018B6B RID: 101227 RVA: 0x006FBB48 File Offset: 0x006F9D48
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_Level(IntPtr l)
	{
		int result;
		try
		{
			TeamRoomPlayer teamRoomPlayer = (TeamRoomPlayer)LuaObject.checkSelf(l);
			int level;
			LuaObject.checkType(l, 2, out level);
			teamRoomPlayer.Level = level;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06018B6C RID: 101228 RVA: 0x006FBBA0 File Offset: 0x006F9DA0
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_Position(IntPtr l)
	{
		int result;
		try
		{
			TeamRoomPlayer teamRoomPlayer = (TeamRoomPlayer)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, teamRoomPlayer.Position);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06018B6D RID: 101229 RVA: 0x006FBBF4 File Offset: 0x006F9DF4
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_Position(IntPtr l)
	{
		int result;
		try
		{
			TeamRoomPlayer teamRoomPlayer = (TeamRoomPlayer)LuaObject.checkSelf(l);
			int position;
			LuaObject.checkType(l, 2, out position);
			teamRoomPlayer.Position = position;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06018B6E RID: 101230 RVA: 0x006FBC4C File Offset: 0x006F9E4C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_ModenSkinId(IntPtr l)
	{
		int result;
		try
		{
			TeamRoomPlayer teamRoomPlayer = (TeamRoomPlayer)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, teamRoomPlayer.ModenSkinId);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06018B6F RID: 101231 RVA: 0x006FBCA0 File Offset: 0x006F9EA0
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_ModenSkinId(IntPtr l)
	{
		int result;
		try
		{
			TeamRoomPlayer teamRoomPlayer = (TeamRoomPlayer)LuaObject.checkSelf(l);
			int modenSkinId;
			LuaObject.checkType(l, 2, out modenSkinId);
			teamRoomPlayer.ModenSkinId = modenSkinId;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06018B70 RID: 101232 RVA: 0x006FBCF8 File Offset: 0x006F9EF8
	[Preserve]
	public static void reg(IntPtr l)
	{
		LuaObject.getTypeTable(l, "BlackJack.ProjectL.Common.TeamRoomPlayer");
		if (Lua_BlackJack_ProjectL_Common_TeamRoomPlayer.<>f__mg$cache0 == null)
		{
			Lua_BlackJack_ProjectL_Common_TeamRoomPlayer.<>f__mg$cache0 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_TeamRoomPlayer.TeamRoomPlayerToPbTeamRoomPlayer_s);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_TeamRoomPlayer.<>f__mg$cache0);
		if (Lua_BlackJack_ProjectL_Common_TeamRoomPlayer.<>f__mg$cache1 == null)
		{
			Lua_BlackJack_ProjectL_Common_TeamRoomPlayer.<>f__mg$cache1 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_TeamRoomPlayer.PbTeamRoomPlayerToTeamRoomPlayer_s);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_TeamRoomPlayer.<>f__mg$cache1);
		string name = "UserId";
		if (Lua_BlackJack_ProjectL_Common_TeamRoomPlayer.<>f__mg$cache2 == null)
		{
			Lua_BlackJack_ProjectL_Common_TeamRoomPlayer.<>f__mg$cache2 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_TeamRoomPlayer.get_UserId);
		}
		LuaCSFunction get = Lua_BlackJack_ProjectL_Common_TeamRoomPlayer.<>f__mg$cache2;
		if (Lua_BlackJack_ProjectL_Common_TeamRoomPlayer.<>f__mg$cache3 == null)
		{
			Lua_BlackJack_ProjectL_Common_TeamRoomPlayer.<>f__mg$cache3 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_TeamRoomPlayer.set_UserId);
		}
		LuaObject.addMember(l, name, get, Lua_BlackJack_ProjectL_Common_TeamRoomPlayer.<>f__mg$cache3, true);
		string name2 = "SessionId";
		if (Lua_BlackJack_ProjectL_Common_TeamRoomPlayer.<>f__mg$cache4 == null)
		{
			Lua_BlackJack_ProjectL_Common_TeamRoomPlayer.<>f__mg$cache4 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_TeamRoomPlayer.get_SessionId);
		}
		LuaCSFunction get2 = Lua_BlackJack_ProjectL_Common_TeamRoomPlayer.<>f__mg$cache4;
		if (Lua_BlackJack_ProjectL_Common_TeamRoomPlayer.<>f__mg$cache5 == null)
		{
			Lua_BlackJack_ProjectL_Common_TeamRoomPlayer.<>f__mg$cache5 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_TeamRoomPlayer.set_SessionId);
		}
		LuaObject.addMember(l, name2, get2, Lua_BlackJack_ProjectL_Common_TeamRoomPlayer.<>f__mg$cache5, true);
		string name3 = "ChannelId";
		if (Lua_BlackJack_ProjectL_Common_TeamRoomPlayer.<>f__mg$cache6 == null)
		{
			Lua_BlackJack_ProjectL_Common_TeamRoomPlayer.<>f__mg$cache6 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_TeamRoomPlayer.get_ChannelId);
		}
		LuaCSFunction get3 = Lua_BlackJack_ProjectL_Common_TeamRoomPlayer.<>f__mg$cache6;
		if (Lua_BlackJack_ProjectL_Common_TeamRoomPlayer.<>f__mg$cache7 == null)
		{
			Lua_BlackJack_ProjectL_Common_TeamRoomPlayer.<>f__mg$cache7 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_TeamRoomPlayer.set_ChannelId);
		}
		LuaObject.addMember(l, name3, get3, Lua_BlackJack_ProjectL_Common_TeamRoomPlayer.<>f__mg$cache7, true);
		string name4 = "Name";
		if (Lua_BlackJack_ProjectL_Common_TeamRoomPlayer.<>f__mg$cache8 == null)
		{
			Lua_BlackJack_ProjectL_Common_TeamRoomPlayer.<>f__mg$cache8 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_TeamRoomPlayer.get_Name);
		}
		LuaCSFunction get4 = Lua_BlackJack_ProjectL_Common_TeamRoomPlayer.<>f__mg$cache8;
		if (Lua_BlackJack_ProjectL_Common_TeamRoomPlayer.<>f__mg$cache9 == null)
		{
			Lua_BlackJack_ProjectL_Common_TeamRoomPlayer.<>f__mg$cache9 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_TeamRoomPlayer.set_Name);
		}
		LuaObject.addMember(l, name4, get4, Lua_BlackJack_ProjectL_Common_TeamRoomPlayer.<>f__mg$cache9, true);
		string name5 = "HeadIcon";
		if (Lua_BlackJack_ProjectL_Common_TeamRoomPlayer.<>f__mg$cacheA == null)
		{
			Lua_BlackJack_ProjectL_Common_TeamRoomPlayer.<>f__mg$cacheA = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_TeamRoomPlayer.get_HeadIcon);
		}
		LuaCSFunction get5 = Lua_BlackJack_ProjectL_Common_TeamRoomPlayer.<>f__mg$cacheA;
		if (Lua_BlackJack_ProjectL_Common_TeamRoomPlayer.<>f__mg$cacheB == null)
		{
			Lua_BlackJack_ProjectL_Common_TeamRoomPlayer.<>f__mg$cacheB = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_TeamRoomPlayer.set_HeadIcon);
		}
		LuaObject.addMember(l, name5, get5, Lua_BlackJack_ProjectL_Common_TeamRoomPlayer.<>f__mg$cacheB, true);
		string name6 = "ActiveHeroJobRelatedId";
		if (Lua_BlackJack_ProjectL_Common_TeamRoomPlayer.<>f__mg$cacheC == null)
		{
			Lua_BlackJack_ProjectL_Common_TeamRoomPlayer.<>f__mg$cacheC = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_TeamRoomPlayer.get_ActiveHeroJobRelatedId);
		}
		LuaCSFunction get6 = Lua_BlackJack_ProjectL_Common_TeamRoomPlayer.<>f__mg$cacheC;
		if (Lua_BlackJack_ProjectL_Common_TeamRoomPlayer.<>f__mg$cacheD == null)
		{
			Lua_BlackJack_ProjectL_Common_TeamRoomPlayer.<>f__mg$cacheD = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_TeamRoomPlayer.set_ActiveHeroJobRelatedId);
		}
		LuaObject.addMember(l, name6, get6, Lua_BlackJack_ProjectL_Common_TeamRoomPlayer.<>f__mg$cacheD, true);
		string name7 = "Level";
		if (Lua_BlackJack_ProjectL_Common_TeamRoomPlayer.<>f__mg$cacheE == null)
		{
			Lua_BlackJack_ProjectL_Common_TeamRoomPlayer.<>f__mg$cacheE = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_TeamRoomPlayer.get_Level);
		}
		LuaCSFunction get7 = Lua_BlackJack_ProjectL_Common_TeamRoomPlayer.<>f__mg$cacheE;
		if (Lua_BlackJack_ProjectL_Common_TeamRoomPlayer.<>f__mg$cacheF == null)
		{
			Lua_BlackJack_ProjectL_Common_TeamRoomPlayer.<>f__mg$cacheF = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_TeamRoomPlayer.set_Level);
		}
		LuaObject.addMember(l, name7, get7, Lua_BlackJack_ProjectL_Common_TeamRoomPlayer.<>f__mg$cacheF, true);
		string name8 = "Position";
		if (Lua_BlackJack_ProjectL_Common_TeamRoomPlayer.<>f__mg$cache10 == null)
		{
			Lua_BlackJack_ProjectL_Common_TeamRoomPlayer.<>f__mg$cache10 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_TeamRoomPlayer.get_Position);
		}
		LuaCSFunction get8 = Lua_BlackJack_ProjectL_Common_TeamRoomPlayer.<>f__mg$cache10;
		if (Lua_BlackJack_ProjectL_Common_TeamRoomPlayer.<>f__mg$cache11 == null)
		{
			Lua_BlackJack_ProjectL_Common_TeamRoomPlayer.<>f__mg$cache11 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_TeamRoomPlayer.set_Position);
		}
		LuaObject.addMember(l, name8, get8, Lua_BlackJack_ProjectL_Common_TeamRoomPlayer.<>f__mg$cache11, true);
		string name9 = "ModenSkinId";
		if (Lua_BlackJack_ProjectL_Common_TeamRoomPlayer.<>f__mg$cache12 == null)
		{
			Lua_BlackJack_ProjectL_Common_TeamRoomPlayer.<>f__mg$cache12 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_TeamRoomPlayer.get_ModenSkinId);
		}
		LuaCSFunction get9 = Lua_BlackJack_ProjectL_Common_TeamRoomPlayer.<>f__mg$cache12;
		if (Lua_BlackJack_ProjectL_Common_TeamRoomPlayer.<>f__mg$cache13 == null)
		{
			Lua_BlackJack_ProjectL_Common_TeamRoomPlayer.<>f__mg$cache13 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_TeamRoomPlayer.set_ModenSkinId);
		}
		LuaObject.addMember(l, name9, get9, Lua_BlackJack_ProjectL_Common_TeamRoomPlayer.<>f__mg$cache13, true);
		if (Lua_BlackJack_ProjectL_Common_TeamRoomPlayer.<>f__mg$cache14 == null)
		{
			Lua_BlackJack_ProjectL_Common_TeamRoomPlayer.<>f__mg$cache14 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_TeamRoomPlayer.constructor);
		}
		LuaObject.createTypeMetatable(l, Lua_BlackJack_ProjectL_Common_TeamRoomPlayer.<>f__mg$cache14, typeof(TeamRoomPlayer));
	}

	// Token: 0x0400F02F RID: 61487
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache0;

	// Token: 0x0400F030 RID: 61488
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1;

	// Token: 0x0400F031 RID: 61489
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2;

	// Token: 0x0400F032 RID: 61490
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3;

	// Token: 0x0400F033 RID: 61491
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache4;

	// Token: 0x0400F034 RID: 61492
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache5;

	// Token: 0x0400F035 RID: 61493
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache6;

	// Token: 0x0400F036 RID: 61494
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache7;

	// Token: 0x0400F037 RID: 61495
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache8;

	// Token: 0x0400F038 RID: 61496
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache9;

	// Token: 0x0400F039 RID: 61497
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheA;

	// Token: 0x0400F03A RID: 61498
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheB;

	// Token: 0x0400F03B RID: 61499
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheC;

	// Token: 0x0400F03C RID: 61500
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheD;

	// Token: 0x0400F03D RID: 61501
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheE;

	// Token: 0x0400F03E RID: 61502
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheF;

	// Token: 0x0400F03F RID: 61503
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache10;

	// Token: 0x0400F040 RID: 61504
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache11;

	// Token: 0x0400F041 RID: 61505
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache12;

	// Token: 0x0400F042 RID: 61506
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache13;

	// Token: 0x0400F043 RID: 61507
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache14;
}
