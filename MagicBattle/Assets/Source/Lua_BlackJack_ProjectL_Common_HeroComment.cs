using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using BlackJack.ProjectL.Common;
using BlackJack.ProjectL.Protocol;
using SLua;
using UnityEngine.Scripting;

// Token: 0x0200123A RID: 4666
[Preserve]
public class Lua_BlackJack_ProjectL_Common_HeroComment : LuaObject
{
	// Token: 0x06018347 RID: 99143 RVA: 0x006BE4B0 File Offset: 0x006BC6B0
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int constructor(IntPtr l)
	{
		int result;
		try
		{
			HeroComment o = new HeroComment();
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

	// Token: 0x06018348 RID: 99144 RVA: 0x006BE4F8 File Offset: 0x006BC6F8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int HeroCommentToPBHeroComment_s(IntPtr l)
	{
		int result;
		try
		{
			HeroComment comment;
			LuaObject.checkType<HeroComment>(l, 1, out comment);
			ProHeroComment o = HeroComment.HeroCommentToPBHeroComment(comment);
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

	// Token: 0x06018349 RID: 99145 RVA: 0x006BE54C File Offset: 0x006BC74C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int PBHeroCommentToHeroComment_s(IntPtr l)
	{
		int result;
		try
		{
			ProHeroComment pbComment;
			LuaObject.checkType<ProHeroComment>(l, 1, out pbComment);
			HeroComment o = HeroComment.PBHeroCommentToHeroComment(pbComment);
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

	// Token: 0x0601834A RID: 99146 RVA: 0x006BE5A0 File Offset: 0x006BC7A0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_LastUpdateTime(IntPtr l)
	{
		int result;
		try
		{
			HeroComment heroComment = (HeroComment)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, heroComment.LastUpdateTime);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601834B RID: 99147 RVA: 0x006BE5F4 File Offset: 0x006BC7F4
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_LastUpdateTime(IntPtr l)
	{
		int result;
		try
		{
			HeroComment heroComment = (HeroComment)LuaObject.checkSelf(l);
			long lastUpdateTime;
			LuaObject.checkType(l, 2, out lastUpdateTime);
			heroComment.LastUpdateTime = lastUpdateTime;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601834C RID: 99148 RVA: 0x006BE64C File Offset: 0x006BC84C
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_CommentEntries(IntPtr l)
	{
		int result;
		try
		{
			HeroComment heroComment = (HeroComment)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, heroComment.CommentEntries);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601834D RID: 99149 RVA: 0x006BE6A0 File Offset: 0x006BC8A0
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_CommentEntries(IntPtr l)
	{
		int result;
		try
		{
			HeroComment heroComment = (HeroComment)LuaObject.checkSelf(l);
			List<HeroCommentEntry> commentEntries;
			LuaObject.checkType<List<HeroCommentEntry>>(l, 2, out commentEntries);
			heroComment.CommentEntries = commentEntries;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601834E RID: 99150 RVA: 0x006BE6F8 File Offset: 0x006BC8F8
	[Preserve]
	public static void reg(IntPtr l)
	{
		LuaObject.getTypeTable(l, "BlackJack.ProjectL.Common.HeroComment");
		if (Lua_BlackJack_ProjectL_Common_HeroComment.<>f__mg$cache0 == null)
		{
			Lua_BlackJack_ProjectL_Common_HeroComment.<>f__mg$cache0 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_HeroComment.HeroCommentToPBHeroComment_s);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_HeroComment.<>f__mg$cache0);
		if (Lua_BlackJack_ProjectL_Common_HeroComment.<>f__mg$cache1 == null)
		{
			Lua_BlackJack_ProjectL_Common_HeroComment.<>f__mg$cache1 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_HeroComment.PBHeroCommentToHeroComment_s);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_HeroComment.<>f__mg$cache1);
		string name = "LastUpdateTime";
		if (Lua_BlackJack_ProjectL_Common_HeroComment.<>f__mg$cache2 == null)
		{
			Lua_BlackJack_ProjectL_Common_HeroComment.<>f__mg$cache2 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_HeroComment.get_LastUpdateTime);
		}
		LuaCSFunction get = Lua_BlackJack_ProjectL_Common_HeroComment.<>f__mg$cache2;
		if (Lua_BlackJack_ProjectL_Common_HeroComment.<>f__mg$cache3 == null)
		{
			Lua_BlackJack_ProjectL_Common_HeroComment.<>f__mg$cache3 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_HeroComment.set_LastUpdateTime);
		}
		LuaObject.addMember(l, name, get, Lua_BlackJack_ProjectL_Common_HeroComment.<>f__mg$cache3, true);
		string name2 = "CommentEntries";
		if (Lua_BlackJack_ProjectL_Common_HeroComment.<>f__mg$cache4 == null)
		{
			Lua_BlackJack_ProjectL_Common_HeroComment.<>f__mg$cache4 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_HeroComment.get_CommentEntries);
		}
		LuaCSFunction get2 = Lua_BlackJack_ProjectL_Common_HeroComment.<>f__mg$cache4;
		if (Lua_BlackJack_ProjectL_Common_HeroComment.<>f__mg$cache5 == null)
		{
			Lua_BlackJack_ProjectL_Common_HeroComment.<>f__mg$cache5 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_HeroComment.set_CommentEntries);
		}
		LuaObject.addMember(l, name2, get2, Lua_BlackJack_ProjectL_Common_HeroComment.<>f__mg$cache5, true);
		if (Lua_BlackJack_ProjectL_Common_HeroComment.<>f__mg$cache6 == null)
		{
			Lua_BlackJack_ProjectL_Common_HeroComment.<>f__mg$cache6 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_HeroComment.constructor);
		}
		LuaObject.createTypeMetatable(l, Lua_BlackJack_ProjectL_Common_HeroComment.<>f__mg$cache6, typeof(HeroComment));
	}

	// Token: 0x0400E8B5 RID: 59573
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache0;

	// Token: 0x0400E8B6 RID: 59574
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1;

	// Token: 0x0400E8B7 RID: 59575
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2;

	// Token: 0x0400E8B8 RID: 59576
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3;

	// Token: 0x0400E8B9 RID: 59577
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache4;

	// Token: 0x0400E8BA RID: 59578
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache5;

	// Token: 0x0400E8BB RID: 59579
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache6;
}
