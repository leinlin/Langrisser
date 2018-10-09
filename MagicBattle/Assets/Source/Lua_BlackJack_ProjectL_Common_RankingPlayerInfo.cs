using System;
using System.Runtime.CompilerServices;
using BlackJack.ProjectL.Common;
using BlackJack.ProjectL.Protocol;
using SLua;
using UnityEngine.Scripting;

// Token: 0x0200126B RID: 4715
[Preserve]
public class Lua_BlackJack_ProjectL_Common_RankingPlayerInfo : LuaObject
{
	// Token: 0x06018924 RID: 100644 RVA: 0x006EB4A8 File Offset: 0x006E96A8
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int constructor(IntPtr l)
	{
		int result;
		try
		{
			RankingPlayerInfo o = new RankingPlayerInfo();
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

	// Token: 0x06018925 RID: 100645 RVA: 0x006EB4F0 File Offset: 0x006E96F0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int RankingPlayerToPBRankingPlayer_s(IntPtr l)
	{
		int result;
		try
		{
			RankingPlayerInfo playerInfo;
			LuaObject.checkType<RankingPlayerInfo>(l, 1, out playerInfo);
			int score;
			LuaObject.checkType(l, 2, out score);
			ProRankingPlayerInfo o = RankingPlayerInfo.RankingPlayerToPBRankingPlayer(playerInfo, score);
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

	// Token: 0x06018926 RID: 100646 RVA: 0x006EB550 File Offset: 0x006E9750
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int PBRankingPlayerToRankingPlayer_s(IntPtr l)
	{
		int result;
		try
		{
			ProRankingPlayerInfo proPlayerInfo;
			LuaObject.checkType<ProRankingPlayerInfo>(l, 1, out proPlayerInfo);
			RankingPlayerInfo o = RankingPlayerInfo.PBRankingPlayerToRankingPlayer(proPlayerInfo);
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

	// Token: 0x06018927 RID: 100647 RVA: 0x006EB5A4 File Offset: 0x006E97A4
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_UserId(IntPtr l)
	{
		int result;
		try
		{
			RankingPlayerInfo rankingPlayerInfo = (RankingPlayerInfo)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, rankingPlayerInfo.UserId);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06018928 RID: 100648 RVA: 0x006EB5F8 File Offset: 0x006E97F8
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_UserId(IntPtr l)
	{
		int result;
		try
		{
			RankingPlayerInfo rankingPlayerInfo = (RankingPlayerInfo)LuaObject.checkSelf(l);
			string userId;
			LuaObject.checkType(l, 2, out userId);
			rankingPlayerInfo.UserId = userId;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06018929 RID: 100649 RVA: 0x006EB650 File Offset: 0x006E9850
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_HeadIcon(IntPtr l)
	{
		int result;
		try
		{
			RankingPlayerInfo rankingPlayerInfo = (RankingPlayerInfo)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, rankingPlayerInfo.HeadIcon);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601892A RID: 100650 RVA: 0x006EB6A4 File Offset: 0x006E98A4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_HeadIcon(IntPtr l)
	{
		int result;
		try
		{
			RankingPlayerInfo rankingPlayerInfo = (RankingPlayerInfo)LuaObject.checkSelf(l);
			int headIcon;
			LuaObject.checkType(l, 2, out headIcon);
			rankingPlayerInfo.HeadIcon = headIcon;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601892B RID: 100651 RVA: 0x006EB6FC File Offset: 0x006E98FC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_Level(IntPtr l)
	{
		int result;
		try
		{
			RankingPlayerInfo rankingPlayerInfo = (RankingPlayerInfo)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, rankingPlayerInfo.Level);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601892C RID: 100652 RVA: 0x006EB750 File Offset: 0x006E9950
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_Level(IntPtr l)
	{
		int result;
		try
		{
			RankingPlayerInfo rankingPlayerInfo = (RankingPlayerInfo)LuaObject.checkSelf(l);
			int level;
			LuaObject.checkType(l, 2, out level);
			rankingPlayerInfo.Level = level;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601892D RID: 100653 RVA: 0x006EB7A8 File Offset: 0x006E99A8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_Name(IntPtr l)
	{
		int result;
		try
		{
			RankingPlayerInfo rankingPlayerInfo = (RankingPlayerInfo)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, rankingPlayerInfo.Name);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601892E RID: 100654 RVA: 0x006EB7FC File Offset: 0x006E99FC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_Name(IntPtr l)
	{
		int result;
		try
		{
			RankingPlayerInfo rankingPlayerInfo = (RankingPlayerInfo)LuaObject.checkSelf(l);
			string name;
			LuaObject.checkType(l, 2, out name);
			rankingPlayerInfo.Name = name;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601892F RID: 100655 RVA: 0x006EB854 File Offset: 0x006E9A54
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_ChampionHeroId(IntPtr l)
	{
		int result;
		try
		{
			RankingPlayerInfo rankingPlayerInfo = (RankingPlayerInfo)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, rankingPlayerInfo.ChampionHeroId);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06018930 RID: 100656 RVA: 0x006EB8A8 File Offset: 0x006E9AA8
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_ChampionHeroId(IntPtr l)
	{
		int result;
		try
		{
			RankingPlayerInfo rankingPlayerInfo = (RankingPlayerInfo)LuaObject.checkSelf(l);
			int championHeroId;
			LuaObject.checkType(l, 2, out championHeroId);
			rankingPlayerInfo.ChampionHeroId = championHeroId;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06018931 RID: 100657 RVA: 0x006EB900 File Offset: 0x006E9B00
	[Preserve]
	public static void reg(IntPtr l)
	{
		LuaObject.getTypeTable(l, "BlackJack.ProjectL.Common.RankingPlayerInfo");
		if (Lua_BlackJack_ProjectL_Common_RankingPlayerInfo.<>f__mg$cache0 == null)
		{
			Lua_BlackJack_ProjectL_Common_RankingPlayerInfo.<>f__mg$cache0 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_RankingPlayerInfo.RankingPlayerToPBRankingPlayer_s);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_RankingPlayerInfo.<>f__mg$cache0);
		if (Lua_BlackJack_ProjectL_Common_RankingPlayerInfo.<>f__mg$cache1 == null)
		{
			Lua_BlackJack_ProjectL_Common_RankingPlayerInfo.<>f__mg$cache1 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_RankingPlayerInfo.PBRankingPlayerToRankingPlayer_s);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_RankingPlayerInfo.<>f__mg$cache1);
		string name = "UserId";
		if (Lua_BlackJack_ProjectL_Common_RankingPlayerInfo.<>f__mg$cache2 == null)
		{
			Lua_BlackJack_ProjectL_Common_RankingPlayerInfo.<>f__mg$cache2 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_RankingPlayerInfo.get_UserId);
		}
		LuaCSFunction get = Lua_BlackJack_ProjectL_Common_RankingPlayerInfo.<>f__mg$cache2;
		if (Lua_BlackJack_ProjectL_Common_RankingPlayerInfo.<>f__mg$cache3 == null)
		{
			Lua_BlackJack_ProjectL_Common_RankingPlayerInfo.<>f__mg$cache3 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_RankingPlayerInfo.set_UserId);
		}
		LuaObject.addMember(l, name, get, Lua_BlackJack_ProjectL_Common_RankingPlayerInfo.<>f__mg$cache3, true);
		string name2 = "HeadIcon";
		if (Lua_BlackJack_ProjectL_Common_RankingPlayerInfo.<>f__mg$cache4 == null)
		{
			Lua_BlackJack_ProjectL_Common_RankingPlayerInfo.<>f__mg$cache4 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_RankingPlayerInfo.get_HeadIcon);
		}
		LuaCSFunction get2 = Lua_BlackJack_ProjectL_Common_RankingPlayerInfo.<>f__mg$cache4;
		if (Lua_BlackJack_ProjectL_Common_RankingPlayerInfo.<>f__mg$cache5 == null)
		{
			Lua_BlackJack_ProjectL_Common_RankingPlayerInfo.<>f__mg$cache5 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_RankingPlayerInfo.set_HeadIcon);
		}
		LuaObject.addMember(l, name2, get2, Lua_BlackJack_ProjectL_Common_RankingPlayerInfo.<>f__mg$cache5, true);
		string name3 = "Level";
		if (Lua_BlackJack_ProjectL_Common_RankingPlayerInfo.<>f__mg$cache6 == null)
		{
			Lua_BlackJack_ProjectL_Common_RankingPlayerInfo.<>f__mg$cache6 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_RankingPlayerInfo.get_Level);
		}
		LuaCSFunction get3 = Lua_BlackJack_ProjectL_Common_RankingPlayerInfo.<>f__mg$cache6;
		if (Lua_BlackJack_ProjectL_Common_RankingPlayerInfo.<>f__mg$cache7 == null)
		{
			Lua_BlackJack_ProjectL_Common_RankingPlayerInfo.<>f__mg$cache7 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_RankingPlayerInfo.set_Level);
		}
		LuaObject.addMember(l, name3, get3, Lua_BlackJack_ProjectL_Common_RankingPlayerInfo.<>f__mg$cache7, true);
		string name4 = "Name";
		if (Lua_BlackJack_ProjectL_Common_RankingPlayerInfo.<>f__mg$cache8 == null)
		{
			Lua_BlackJack_ProjectL_Common_RankingPlayerInfo.<>f__mg$cache8 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_RankingPlayerInfo.get_Name);
		}
		LuaCSFunction get4 = Lua_BlackJack_ProjectL_Common_RankingPlayerInfo.<>f__mg$cache8;
		if (Lua_BlackJack_ProjectL_Common_RankingPlayerInfo.<>f__mg$cache9 == null)
		{
			Lua_BlackJack_ProjectL_Common_RankingPlayerInfo.<>f__mg$cache9 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_RankingPlayerInfo.set_Name);
		}
		LuaObject.addMember(l, name4, get4, Lua_BlackJack_ProjectL_Common_RankingPlayerInfo.<>f__mg$cache9, true);
		string name5 = "ChampionHeroId";
		if (Lua_BlackJack_ProjectL_Common_RankingPlayerInfo.<>f__mg$cacheA == null)
		{
			Lua_BlackJack_ProjectL_Common_RankingPlayerInfo.<>f__mg$cacheA = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_RankingPlayerInfo.get_ChampionHeroId);
		}
		LuaCSFunction get5 = Lua_BlackJack_ProjectL_Common_RankingPlayerInfo.<>f__mg$cacheA;
		if (Lua_BlackJack_ProjectL_Common_RankingPlayerInfo.<>f__mg$cacheB == null)
		{
			Lua_BlackJack_ProjectL_Common_RankingPlayerInfo.<>f__mg$cacheB = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_RankingPlayerInfo.set_ChampionHeroId);
		}
		LuaObject.addMember(l, name5, get5, Lua_BlackJack_ProjectL_Common_RankingPlayerInfo.<>f__mg$cacheB, true);
		if (Lua_BlackJack_ProjectL_Common_RankingPlayerInfo.<>f__mg$cacheC == null)
		{
			Lua_BlackJack_ProjectL_Common_RankingPlayerInfo.<>f__mg$cacheC = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_RankingPlayerInfo.constructor);
		}
		LuaObject.createTypeMetatable(l, Lua_BlackJack_ProjectL_Common_RankingPlayerInfo.<>f__mg$cacheC, typeof(RankingPlayerInfo));
	}

	// Token: 0x0400EE30 RID: 60976
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache0;

	// Token: 0x0400EE31 RID: 60977
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1;

	// Token: 0x0400EE32 RID: 60978
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2;

	// Token: 0x0400EE33 RID: 60979
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3;

	// Token: 0x0400EE34 RID: 60980
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache4;

	// Token: 0x0400EE35 RID: 60981
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache5;

	// Token: 0x0400EE36 RID: 60982
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache6;

	// Token: 0x0400EE37 RID: 60983
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache7;

	// Token: 0x0400EE38 RID: 60984
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache8;

	// Token: 0x0400EE39 RID: 60985
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache9;

	// Token: 0x0400EE3A RID: 60986
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheA;

	// Token: 0x0400EE3B RID: 60987
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheB;

	// Token: 0x0400EE3C RID: 60988
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheC;
}
