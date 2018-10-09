using System;
using System.Runtime.CompilerServices;
using BlackJack.ProjectL.Common;
using SLua;
using UnityEngine.Scripting;

// Token: 0x020011F9 RID: 4601
[Preserve]
public class Lua_BlackJack_ProjectL_Common_DataSectionComment : LuaObject
{
	// Token: 0x06017DC6 RID: 97734 RVA: 0x006968F0 File Offset: 0x00694AF0
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int constructor(IntPtr l)
	{
		int result;
		try
		{
			DataSectionComment o = new DataSectionComment();
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

	// Token: 0x06017DC7 RID: 97735 RVA: 0x00696938 File Offset: 0x00694B38
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int ClearInitedData(IntPtr l)
	{
		int result;
		try
		{
			DataSectionComment dataSectionComment = (DataSectionComment)LuaObject.checkSelf(l);
			dataSectionComment.ClearInitedData();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06017DC8 RID: 97736 RVA: 0x00696984 File Offset: 0x00694B84
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int InitPlayerHeroCommentEntry(IntPtr l)
	{
		int result;
		try
		{
			DataSectionComment dataSectionComment = (DataSectionComment)LuaObject.checkSelf(l);
			PlayerHeroCommentEntry playerCommentEntry;
			LuaObject.checkType<PlayerHeroCommentEntry>(l, 2, out playerCommentEntry);
			dataSectionComment.InitPlayerHeroCommentEntry(playerCommentEntry);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06017DC9 RID: 97737 RVA: 0x006969DC File Offset: 0x00694BDC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int FindPlayerHeroCommentEntry(IntPtr l)
	{
		int result;
		try
		{
			DataSectionComment dataSectionComment = (DataSectionComment)LuaObject.checkSelf(l);
			int heroId;
			LuaObject.checkType(l, 2, out heroId);
			PlayerHeroCommentEntry o = dataSectionComment.FindPlayerHeroCommentEntry(heroId);
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

	// Token: 0x06017DCA RID: 97738 RVA: 0x00696A40 File Offset: 0x00694C40
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int PraiseHeroComment(IntPtr l)
	{
		int result;
		try
		{
			DataSectionComment dataSectionComment = (DataSectionComment)LuaObject.checkSelf(l);
			int heroId;
			LuaObject.checkType(l, 2, out heroId);
			ulong commentInstanceId;
			LuaObject.checkType(l, 3, out commentInstanceId);
			dataSectionComment.PraiseHeroComment(heroId, commentInstanceId);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06017DCB RID: 97739 RVA: 0x00696AA4 File Offset: 0x00694CA4
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int CommentHero(IntPtr l)
	{
		int result;
		try
		{
			DataSectionComment dataSectionComment = (DataSectionComment)LuaObject.checkSelf(l);
			int heroId;
			LuaObject.checkType(l, 2, out heroId);
			HeroCommentEntry commentEntry;
			LuaObject.checkType<HeroCommentEntry>(l, 3, out commentEntry);
			dataSectionComment.CommentHero(heroId, commentEntry);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06017DCC RID: 97740 RVA: 0x00696B08 File Offset: 0x00694D08
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int IsBanned(IntPtr l)
	{
		int result;
		try
		{
			DataSectionComment dataSectionComment = (DataSectionComment)LuaObject.checkSelf(l);
			DateTime currentTime;
			LuaObject.checkValueType<DateTime>(l, 2, out currentTime);
			bool b = dataSectionComment.IsBanned(currentTime);
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

	// Token: 0x06017DCD RID: 97741 RVA: 0x00696B6C File Offset: 0x00694D6C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int Ban(IntPtr l)
	{
		int result;
		try
		{
			DataSectionComment dataSectionComment = (DataSectionComment)LuaObject.checkSelf(l);
			DateTime bannedTime;
			LuaObject.checkValueType<DateTime>(l, 2, out bannedTime);
			dataSectionComment.Ban(bannedTime);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06017DCE RID: 97742 RVA: 0x00696BC4 File Offset: 0x00694DC4
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int Unban(IntPtr l)
	{
		int result;
		try
		{
			DataSectionComment dataSectionComment = (DataSectionComment)LuaObject.checkSelf(l);
			dataSectionComment.Unban();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06017DCF RID: 97743 RVA: 0x00696C10 File Offset: 0x00694E10
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_m_bannedTime(IntPtr l)
	{
		int result;
		try
		{
			DataSectionComment dataSectionComment = (DataSectionComment)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, dataSectionComment.m_bannedTime);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06017DD0 RID: 97744 RVA: 0x00696C68 File Offset: 0x00694E68
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_bannedTime(IntPtr l)
	{
		int result;
		try
		{
			DataSectionComment dataSectionComment = (DataSectionComment)LuaObject.checkSelf(l);
			DateTime bannedTime;
			LuaObject.checkValueType<DateTime>(l, 2, out bannedTime);
			dataSectionComment.m_bannedTime = bannedTime;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06017DD1 RID: 97745 RVA: 0x00696CC0 File Offset: 0x00694EC0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_playerHeroCommentEntries(IntPtr l)
	{
		int result;
		try
		{
			DataSectionComment dataSectionComment = (DataSectionComment)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, dataSectionComment.m_playerHeroCommentEntries);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06017DD2 RID: 97746 RVA: 0x00696D14 File Offset: 0x00694F14
	[Preserve]
	public static void reg(IntPtr l)
	{
		LuaObject.getTypeTable(l, "BlackJack.ProjectL.Common.DataSectionComment");
		if (Lua_BlackJack_ProjectL_Common_DataSectionComment.<>f__mg$cache0 == null)
		{
			Lua_BlackJack_ProjectL_Common_DataSectionComment.<>f__mg$cache0 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_DataSectionComment.ClearInitedData);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_DataSectionComment.<>f__mg$cache0);
		if (Lua_BlackJack_ProjectL_Common_DataSectionComment.<>f__mg$cache1 == null)
		{
			Lua_BlackJack_ProjectL_Common_DataSectionComment.<>f__mg$cache1 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_DataSectionComment.InitPlayerHeroCommentEntry);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_DataSectionComment.<>f__mg$cache1);
		if (Lua_BlackJack_ProjectL_Common_DataSectionComment.<>f__mg$cache2 == null)
		{
			Lua_BlackJack_ProjectL_Common_DataSectionComment.<>f__mg$cache2 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_DataSectionComment.FindPlayerHeroCommentEntry);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_DataSectionComment.<>f__mg$cache2);
		if (Lua_BlackJack_ProjectL_Common_DataSectionComment.<>f__mg$cache3 == null)
		{
			Lua_BlackJack_ProjectL_Common_DataSectionComment.<>f__mg$cache3 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_DataSectionComment.PraiseHeroComment);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_DataSectionComment.<>f__mg$cache3);
		if (Lua_BlackJack_ProjectL_Common_DataSectionComment.<>f__mg$cache4 == null)
		{
			Lua_BlackJack_ProjectL_Common_DataSectionComment.<>f__mg$cache4 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_DataSectionComment.CommentHero);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_DataSectionComment.<>f__mg$cache4);
		if (Lua_BlackJack_ProjectL_Common_DataSectionComment.<>f__mg$cache5 == null)
		{
			Lua_BlackJack_ProjectL_Common_DataSectionComment.<>f__mg$cache5 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_DataSectionComment.IsBanned);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_DataSectionComment.<>f__mg$cache5);
		if (Lua_BlackJack_ProjectL_Common_DataSectionComment.<>f__mg$cache6 == null)
		{
			Lua_BlackJack_ProjectL_Common_DataSectionComment.<>f__mg$cache6 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_DataSectionComment.Ban);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_DataSectionComment.<>f__mg$cache6);
		if (Lua_BlackJack_ProjectL_Common_DataSectionComment.<>f__mg$cache7 == null)
		{
			Lua_BlackJack_ProjectL_Common_DataSectionComment.<>f__mg$cache7 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_DataSectionComment.Unban);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_DataSectionComment.<>f__mg$cache7);
		string name = "m_bannedTime";
		if (Lua_BlackJack_ProjectL_Common_DataSectionComment.<>f__mg$cache8 == null)
		{
			Lua_BlackJack_ProjectL_Common_DataSectionComment.<>f__mg$cache8 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_DataSectionComment.get_m_bannedTime);
		}
		LuaCSFunction get = Lua_BlackJack_ProjectL_Common_DataSectionComment.<>f__mg$cache8;
		if (Lua_BlackJack_ProjectL_Common_DataSectionComment.<>f__mg$cache9 == null)
		{
			Lua_BlackJack_ProjectL_Common_DataSectionComment.<>f__mg$cache9 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_DataSectionComment.set_m_bannedTime);
		}
		LuaObject.addMember(l, name, get, Lua_BlackJack_ProjectL_Common_DataSectionComment.<>f__mg$cache9, true);
		string name2 = "m_playerHeroCommentEntries";
		if (Lua_BlackJack_ProjectL_Common_DataSectionComment.<>f__mg$cacheA == null)
		{
			Lua_BlackJack_ProjectL_Common_DataSectionComment.<>f__mg$cacheA = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_DataSectionComment.get_m_playerHeroCommentEntries);
		}
		LuaObject.addMember(l, name2, Lua_BlackJack_ProjectL_Common_DataSectionComment.<>f__mg$cacheA, null, true);
		if (Lua_BlackJack_ProjectL_Common_DataSectionComment.<>f__mg$cacheB == null)
		{
			Lua_BlackJack_ProjectL_Common_DataSectionComment.<>f__mg$cacheB = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_DataSectionComment.constructor);
		}
		LuaObject.createTypeMetatable(l, Lua_BlackJack_ProjectL_Common_DataSectionComment.<>f__mg$cacheB, typeof(DataSectionComment), typeof(DataSection));
	}

	// Token: 0x0400E3B6 RID: 58294
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache0;

	// Token: 0x0400E3B7 RID: 58295
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1;

	// Token: 0x0400E3B8 RID: 58296
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2;

	// Token: 0x0400E3B9 RID: 58297
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3;

	// Token: 0x0400E3BA RID: 58298
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache4;

	// Token: 0x0400E3BB RID: 58299
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache5;

	// Token: 0x0400E3BC RID: 58300
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache6;

	// Token: 0x0400E3BD RID: 58301
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache7;

	// Token: 0x0400E3BE RID: 58302
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache8;

	// Token: 0x0400E3BF RID: 58303
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache9;

	// Token: 0x0400E3C0 RID: 58304
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheA;

	// Token: 0x0400E3C1 RID: 58305
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheB;
}
