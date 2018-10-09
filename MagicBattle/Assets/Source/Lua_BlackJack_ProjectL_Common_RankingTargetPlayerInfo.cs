using System;
using System.Runtime.CompilerServices;
using BlackJack.ProjectL.Common;
using SLua;
using UnityEngine.Scripting;

// Token: 0x0200126C RID: 4716
[Preserve]
public class Lua_BlackJack_ProjectL_Common_RankingTargetPlayerInfo : LuaObject
{
	// Token: 0x06018933 RID: 100659 RVA: 0x006EBAF4 File Offset: 0x006E9CF4
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int constructor(IntPtr l)
	{
		int result;
		try
		{
			RankingTargetPlayerInfo o = new RankingTargetPlayerInfo();
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

	// Token: 0x06018934 RID: 100660 RVA: 0x006EBB3C File Offset: 0x006E9D3C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_PlayerInfo(IntPtr l)
	{
		int result;
		try
		{
			RankingTargetPlayerInfo rankingTargetPlayerInfo = (RankingTargetPlayerInfo)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, rankingTargetPlayerInfo.PlayerInfo);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06018935 RID: 100661 RVA: 0x006EBB90 File Offset: 0x006E9D90
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_PlayerInfo(IntPtr l)
	{
		int result;
		try
		{
			RankingTargetPlayerInfo rankingTargetPlayerInfo = (RankingTargetPlayerInfo)LuaObject.checkSelf(l);
			RankingPlayerInfo playerInfo;
			LuaObject.checkType<RankingPlayerInfo>(l, 2, out playerInfo);
			rankingTargetPlayerInfo.PlayerInfo = playerInfo;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06018936 RID: 100662 RVA: 0x006EBBE8 File Offset: 0x006E9DE8
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_UpdateTime(IntPtr l)
	{
		int result;
		try
		{
			RankingTargetPlayerInfo rankingTargetPlayerInfo = (RankingTargetPlayerInfo)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, rankingTargetPlayerInfo.UpdateTime);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06018937 RID: 100663 RVA: 0x006EBC3C File Offset: 0x006E9E3C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_UpdateTime(IntPtr l)
	{
		int result;
		try
		{
			RankingTargetPlayerInfo rankingTargetPlayerInfo = (RankingTargetPlayerInfo)LuaObject.checkSelf(l);
			long updateTime;
			LuaObject.checkType(l, 2, out updateTime);
			rankingTargetPlayerInfo.UpdateTime = updateTime;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06018938 RID: 100664 RVA: 0x006EBC94 File Offset: 0x006E9E94
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_Score(IntPtr l)
	{
		int result;
		try
		{
			RankingTargetPlayerInfo rankingTargetPlayerInfo = (RankingTargetPlayerInfo)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, rankingTargetPlayerInfo.Score);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06018939 RID: 100665 RVA: 0x006EBCE8 File Offset: 0x006E9EE8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_Score(IntPtr l)
	{
		int result;
		try
		{
			RankingTargetPlayerInfo rankingTargetPlayerInfo = (RankingTargetPlayerInfo)LuaObject.checkSelf(l);
			int score;
			LuaObject.checkType(l, 2, out score);
			rankingTargetPlayerInfo.Score = score;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601893A RID: 100666 RVA: 0x006EBD40 File Offset: 0x006E9F40
	[Preserve]
	public static void reg(IntPtr l)
	{
		LuaObject.getTypeTable(l, "BlackJack.ProjectL.Common.RankingTargetPlayerInfo");
		string name = "PlayerInfo";
		if (Lua_BlackJack_ProjectL_Common_RankingTargetPlayerInfo.<>f__mg$cache0 == null)
		{
			Lua_BlackJack_ProjectL_Common_RankingTargetPlayerInfo.<>f__mg$cache0 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_RankingTargetPlayerInfo.get_PlayerInfo);
		}
		LuaCSFunction get = Lua_BlackJack_ProjectL_Common_RankingTargetPlayerInfo.<>f__mg$cache0;
		if (Lua_BlackJack_ProjectL_Common_RankingTargetPlayerInfo.<>f__mg$cache1 == null)
		{
			Lua_BlackJack_ProjectL_Common_RankingTargetPlayerInfo.<>f__mg$cache1 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_RankingTargetPlayerInfo.set_PlayerInfo);
		}
		LuaObject.addMember(l, name, get, Lua_BlackJack_ProjectL_Common_RankingTargetPlayerInfo.<>f__mg$cache1, true);
		string name2 = "UpdateTime";
		if (Lua_BlackJack_ProjectL_Common_RankingTargetPlayerInfo.<>f__mg$cache2 == null)
		{
			Lua_BlackJack_ProjectL_Common_RankingTargetPlayerInfo.<>f__mg$cache2 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_RankingTargetPlayerInfo.get_UpdateTime);
		}
		LuaCSFunction get2 = Lua_BlackJack_ProjectL_Common_RankingTargetPlayerInfo.<>f__mg$cache2;
		if (Lua_BlackJack_ProjectL_Common_RankingTargetPlayerInfo.<>f__mg$cache3 == null)
		{
			Lua_BlackJack_ProjectL_Common_RankingTargetPlayerInfo.<>f__mg$cache3 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_RankingTargetPlayerInfo.set_UpdateTime);
		}
		LuaObject.addMember(l, name2, get2, Lua_BlackJack_ProjectL_Common_RankingTargetPlayerInfo.<>f__mg$cache3, true);
		string name3 = "Score";
		if (Lua_BlackJack_ProjectL_Common_RankingTargetPlayerInfo.<>f__mg$cache4 == null)
		{
			Lua_BlackJack_ProjectL_Common_RankingTargetPlayerInfo.<>f__mg$cache4 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_RankingTargetPlayerInfo.get_Score);
		}
		LuaCSFunction get3 = Lua_BlackJack_ProjectL_Common_RankingTargetPlayerInfo.<>f__mg$cache4;
		if (Lua_BlackJack_ProjectL_Common_RankingTargetPlayerInfo.<>f__mg$cache5 == null)
		{
			Lua_BlackJack_ProjectL_Common_RankingTargetPlayerInfo.<>f__mg$cache5 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_RankingTargetPlayerInfo.set_Score);
		}
		LuaObject.addMember(l, name3, get3, Lua_BlackJack_ProjectL_Common_RankingTargetPlayerInfo.<>f__mg$cache5, true);
		if (Lua_BlackJack_ProjectL_Common_RankingTargetPlayerInfo.<>f__mg$cache6 == null)
		{
			Lua_BlackJack_ProjectL_Common_RankingTargetPlayerInfo.<>f__mg$cache6 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_RankingTargetPlayerInfo.constructor);
		}
		LuaObject.createTypeMetatable(l, Lua_BlackJack_ProjectL_Common_RankingTargetPlayerInfo.<>f__mg$cache6, typeof(RankingTargetPlayerInfo));
	}

	// Token: 0x0400EE3D RID: 60989
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache0;

	// Token: 0x0400EE3E RID: 60990
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1;

	// Token: 0x0400EE3F RID: 60991
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2;

	// Token: 0x0400EE40 RID: 60992
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3;

	// Token: 0x0400EE41 RID: 60993
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache4;

	// Token: 0x0400EE42 RID: 60994
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache5;

	// Token: 0x0400EE43 RID: 60995
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache6;
}
