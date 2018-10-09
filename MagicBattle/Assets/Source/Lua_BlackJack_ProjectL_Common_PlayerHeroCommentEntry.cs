using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using BlackJack.ProjectL.Common;
using BlackJack.ProjectL.Protocol;
using SLua;
using UnityEngine.Scripting;

// Token: 0x0200125B RID: 4699
[Preserve]
public class Lua_BlackJack_ProjectL_Common_PlayerHeroCommentEntry : LuaObject
{
	// Token: 0x0601883B RID: 100411 RVA: 0x006E50C0 File Offset: 0x006E32C0
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int constructor(IntPtr l)
	{
		int result;
		try
		{
			PlayerHeroCommentEntry o = new PlayerHeroCommentEntry();
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

	// Token: 0x0601883C RID: 100412 RVA: 0x006E5108 File Offset: 0x006E3308
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int PlayerHeroCommentEntryToPBPlayerHeroCommentEntry_s(IntPtr l)
	{
		int result;
		try
		{
			PlayerHeroCommentEntry entry;
			LuaObject.checkType<PlayerHeroCommentEntry>(l, 1, out entry);
			ProPlayerHeroCommentEntry o = PlayerHeroCommentEntry.PlayerHeroCommentEntryToPBPlayerHeroCommentEntry(entry);
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

	// Token: 0x0601883D RID: 100413 RVA: 0x006E515C File Offset: 0x006E335C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int PBPlayerHeroCommentEntryToPlayerHeroCommentEntry_s(IntPtr l)
	{
		int result;
		try
		{
			ProPlayerHeroCommentEntry pbEntry;
			LuaObject.checkType<ProPlayerHeroCommentEntry>(l, 1, out pbEntry);
			PlayerHeroCommentEntry o = PlayerHeroCommentEntry.PBPlayerHeroCommentEntryToPlayerHeroCommentEntry(pbEntry);
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

	// Token: 0x0601883E RID: 100414 RVA: 0x006E51B0 File Offset: 0x006E33B0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_CommentedEntryInstanceIds(IntPtr l)
	{
		int result;
		try
		{
			PlayerHeroCommentEntry playerHeroCommentEntry = (PlayerHeroCommentEntry)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, playerHeroCommentEntry.CommentedEntryInstanceIds);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601883F RID: 100415 RVA: 0x006E5204 File Offset: 0x006E3404
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_CommentedEntryInstanceIds(IntPtr l)
	{
		int result;
		try
		{
			PlayerHeroCommentEntry playerHeroCommentEntry = (PlayerHeroCommentEntry)LuaObject.checkSelf(l);
			List<ulong> commentedEntryInstanceIds;
			LuaObject.checkType<List<ulong>>(l, 2, out commentedEntryInstanceIds);
			playerHeroCommentEntry.CommentedEntryInstanceIds = commentedEntryInstanceIds;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06018840 RID: 100416 RVA: 0x006E525C File Offset: 0x006E345C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_PraisedEntryInstanceIds(IntPtr l)
	{
		int result;
		try
		{
			PlayerHeroCommentEntry playerHeroCommentEntry = (PlayerHeroCommentEntry)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, playerHeroCommentEntry.PraisedEntryInstanceIds);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06018841 RID: 100417 RVA: 0x006E52B0 File Offset: 0x006E34B0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_PraisedEntryInstanceIds(IntPtr l)
	{
		int result;
		try
		{
			PlayerHeroCommentEntry playerHeroCommentEntry = (PlayerHeroCommentEntry)LuaObject.checkSelf(l);
			HashSet<ulong> praisedEntryInstanceIds;
			LuaObject.checkType<HashSet<ulong>>(l, 2, out praisedEntryInstanceIds);
			playerHeroCommentEntry.PraisedEntryInstanceIds = praisedEntryInstanceIds;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06018842 RID: 100418 RVA: 0x006E5308 File Offset: 0x006E3508
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_HeroId(IntPtr l)
	{
		int result;
		try
		{
			PlayerHeroCommentEntry playerHeroCommentEntry = (PlayerHeroCommentEntry)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, playerHeroCommentEntry.HeroId);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06018843 RID: 100419 RVA: 0x006E535C File Offset: 0x006E355C
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_HeroId(IntPtr l)
	{
		int result;
		try
		{
			PlayerHeroCommentEntry playerHeroCommentEntry = (PlayerHeroCommentEntry)LuaObject.checkSelf(l);
			int heroId;
			LuaObject.checkType(l, 2, out heroId);
			playerHeroCommentEntry.HeroId = heroId;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06018844 RID: 100420 RVA: 0x006E53B4 File Offset: 0x006E35B4
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_CommentedNums(IntPtr l)
	{
		int result;
		try
		{
			PlayerHeroCommentEntry playerHeroCommentEntry = (PlayerHeroCommentEntry)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, playerHeroCommentEntry.CommentedNums);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06018845 RID: 100421 RVA: 0x006E5408 File Offset: 0x006E3608
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_CommentedNums(IntPtr l)
	{
		int result;
		try
		{
			PlayerHeroCommentEntry playerHeroCommentEntry = (PlayerHeroCommentEntry)LuaObject.checkSelf(l);
			int commentedNums;
			LuaObject.checkType(l, 2, out commentedNums);
			playerHeroCommentEntry.CommentedNums = commentedNums;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06018846 RID: 100422 RVA: 0x006E5460 File Offset: 0x006E3660
	[Preserve]
	public static void reg(IntPtr l)
	{
		LuaObject.getTypeTable(l, "BlackJack.ProjectL.Common.PlayerHeroCommentEntry");
		if (Lua_BlackJack_ProjectL_Common_PlayerHeroCommentEntry.<>f__mg$cache0 == null)
		{
			Lua_BlackJack_ProjectL_Common_PlayerHeroCommentEntry.<>f__mg$cache0 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_PlayerHeroCommentEntry.PlayerHeroCommentEntryToPBPlayerHeroCommentEntry_s);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_PlayerHeroCommentEntry.<>f__mg$cache0);
		if (Lua_BlackJack_ProjectL_Common_PlayerHeroCommentEntry.<>f__mg$cache1 == null)
		{
			Lua_BlackJack_ProjectL_Common_PlayerHeroCommentEntry.<>f__mg$cache1 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_PlayerHeroCommentEntry.PBPlayerHeroCommentEntryToPlayerHeroCommentEntry_s);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_PlayerHeroCommentEntry.<>f__mg$cache1);
		string name = "CommentedEntryInstanceIds";
		if (Lua_BlackJack_ProjectL_Common_PlayerHeroCommentEntry.<>f__mg$cache2 == null)
		{
			Lua_BlackJack_ProjectL_Common_PlayerHeroCommentEntry.<>f__mg$cache2 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_PlayerHeroCommentEntry.get_CommentedEntryInstanceIds);
		}
		LuaCSFunction get = Lua_BlackJack_ProjectL_Common_PlayerHeroCommentEntry.<>f__mg$cache2;
		if (Lua_BlackJack_ProjectL_Common_PlayerHeroCommentEntry.<>f__mg$cache3 == null)
		{
			Lua_BlackJack_ProjectL_Common_PlayerHeroCommentEntry.<>f__mg$cache3 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_PlayerHeroCommentEntry.set_CommentedEntryInstanceIds);
		}
		LuaObject.addMember(l, name, get, Lua_BlackJack_ProjectL_Common_PlayerHeroCommentEntry.<>f__mg$cache3, true);
		string name2 = "PraisedEntryInstanceIds";
		if (Lua_BlackJack_ProjectL_Common_PlayerHeroCommentEntry.<>f__mg$cache4 == null)
		{
			Lua_BlackJack_ProjectL_Common_PlayerHeroCommentEntry.<>f__mg$cache4 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_PlayerHeroCommentEntry.get_PraisedEntryInstanceIds);
		}
		LuaCSFunction get2 = Lua_BlackJack_ProjectL_Common_PlayerHeroCommentEntry.<>f__mg$cache4;
		if (Lua_BlackJack_ProjectL_Common_PlayerHeroCommentEntry.<>f__mg$cache5 == null)
		{
			Lua_BlackJack_ProjectL_Common_PlayerHeroCommentEntry.<>f__mg$cache5 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_PlayerHeroCommentEntry.set_PraisedEntryInstanceIds);
		}
		LuaObject.addMember(l, name2, get2, Lua_BlackJack_ProjectL_Common_PlayerHeroCommentEntry.<>f__mg$cache5, true);
		string name3 = "HeroId";
		if (Lua_BlackJack_ProjectL_Common_PlayerHeroCommentEntry.<>f__mg$cache6 == null)
		{
			Lua_BlackJack_ProjectL_Common_PlayerHeroCommentEntry.<>f__mg$cache6 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_PlayerHeroCommentEntry.get_HeroId);
		}
		LuaCSFunction get3 = Lua_BlackJack_ProjectL_Common_PlayerHeroCommentEntry.<>f__mg$cache6;
		if (Lua_BlackJack_ProjectL_Common_PlayerHeroCommentEntry.<>f__mg$cache7 == null)
		{
			Lua_BlackJack_ProjectL_Common_PlayerHeroCommentEntry.<>f__mg$cache7 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_PlayerHeroCommentEntry.set_HeroId);
		}
		LuaObject.addMember(l, name3, get3, Lua_BlackJack_ProjectL_Common_PlayerHeroCommentEntry.<>f__mg$cache7, true);
		string name4 = "CommentedNums";
		if (Lua_BlackJack_ProjectL_Common_PlayerHeroCommentEntry.<>f__mg$cache8 == null)
		{
			Lua_BlackJack_ProjectL_Common_PlayerHeroCommentEntry.<>f__mg$cache8 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_PlayerHeroCommentEntry.get_CommentedNums);
		}
		LuaCSFunction get4 = Lua_BlackJack_ProjectL_Common_PlayerHeroCommentEntry.<>f__mg$cache8;
		if (Lua_BlackJack_ProjectL_Common_PlayerHeroCommentEntry.<>f__mg$cache9 == null)
		{
			Lua_BlackJack_ProjectL_Common_PlayerHeroCommentEntry.<>f__mg$cache9 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_PlayerHeroCommentEntry.set_CommentedNums);
		}
		LuaObject.addMember(l, name4, get4, Lua_BlackJack_ProjectL_Common_PlayerHeroCommentEntry.<>f__mg$cache9, true);
		if (Lua_BlackJack_ProjectL_Common_PlayerHeroCommentEntry.<>f__mg$cacheA == null)
		{
			Lua_BlackJack_ProjectL_Common_PlayerHeroCommentEntry.<>f__mg$cacheA = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_PlayerHeroCommentEntry.constructor);
		}
		LuaObject.createTypeMetatable(l, Lua_BlackJack_ProjectL_Common_PlayerHeroCommentEntry.<>f__mg$cacheA, typeof(PlayerHeroCommentEntry));
	}

	// Token: 0x0400ED67 RID: 60775
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache0;

	// Token: 0x0400ED68 RID: 60776
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1;

	// Token: 0x0400ED69 RID: 60777
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2;

	// Token: 0x0400ED6A RID: 60778
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3;

	// Token: 0x0400ED6B RID: 60779
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache4;

	// Token: 0x0400ED6C RID: 60780
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache5;

	// Token: 0x0400ED6D RID: 60781
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache6;

	// Token: 0x0400ED6E RID: 60782
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache7;

	// Token: 0x0400ED6F RID: 60783
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache8;

	// Token: 0x0400ED70 RID: 60784
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache9;

	// Token: 0x0400ED71 RID: 60785
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheA;
}
