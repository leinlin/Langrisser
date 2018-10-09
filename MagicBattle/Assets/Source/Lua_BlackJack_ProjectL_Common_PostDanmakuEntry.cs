using System;
using System.Runtime.CompilerServices;
using BlackJack.ProjectL.Common;
using BlackJack.ProjectL.Protocol;
using SLua;
using UnityEngine.Scripting;

// Token: 0x0200125E RID: 4702
[Preserve]
public class Lua_BlackJack_ProjectL_Common_PostDanmakuEntry : LuaObject
{
	// Token: 0x06018861 RID: 100449 RVA: 0x006E60CC File Offset: 0x006E42CC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int constructor(IntPtr l)
	{
		int result;
		try
		{
			PostDanmakuEntry o = new PostDanmakuEntry();
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

	// Token: 0x06018862 RID: 100450 RVA: 0x006E6114 File Offset: 0x006E4314
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int PBPostDanmakuEntryToPostDanmakuEntry_s(IntPtr l)
	{
		int result;
		try
		{
			ProPostDanmakuEntry pbEntry;
			LuaObject.checkType<ProPostDanmakuEntry>(l, 1, out pbEntry);
			PostDanmakuEntry o = PostDanmakuEntry.PBPostDanmakuEntryToPostDanmakuEntry(pbEntry);
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

	// Token: 0x06018863 RID: 100451 RVA: 0x006E6168 File Offset: 0x006E4368
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int PostDanmakuEntryToPBPostDanmakuEntry_s(IntPtr l)
	{
		int result;
		try
		{
			PostDanmakuEntry entry;
			LuaObject.checkType<PostDanmakuEntry>(l, 1, out entry);
			ProPostDanmakuEntry o = PostDanmakuEntry.PostDanmakuEntryToPBPostDanmakuEntry(entry);
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

	// Token: 0x06018864 RID: 100452 RVA: 0x006E61BC File Offset: 0x006E43BC
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_Turn(IntPtr l)
	{
		int result;
		try
		{
			PostDanmakuEntry postDanmakuEntry = (PostDanmakuEntry)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, postDanmakuEntry.Turn);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06018865 RID: 100453 RVA: 0x006E6210 File Offset: 0x006E4410
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_Turn(IntPtr l)
	{
		int result;
		try
		{
			PostDanmakuEntry postDanmakuEntry = (PostDanmakuEntry)LuaObject.checkSelf(l);
			int turn;
			LuaObject.checkType(l, 2, out turn);
			postDanmakuEntry.Turn = turn;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06018866 RID: 100454 RVA: 0x006E6268 File Offset: 0x006E4468
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_Content(IntPtr l)
	{
		int result;
		try
		{
			PostDanmakuEntry postDanmakuEntry = (PostDanmakuEntry)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, postDanmakuEntry.Content);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06018867 RID: 100455 RVA: 0x006E62BC File Offset: 0x006E44BC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_Content(IntPtr l)
	{
		int result;
		try
		{
			PostDanmakuEntry postDanmakuEntry = (PostDanmakuEntry)LuaObject.checkSelf(l);
			string content;
			LuaObject.checkType(l, 2, out content);
			postDanmakuEntry.Content = content;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06018868 RID: 100456 RVA: 0x006E6314 File Offset: 0x006E4514
	[Preserve]
	public static void reg(IntPtr l)
	{
		LuaObject.getTypeTable(l, "BlackJack.ProjectL.Common.PostDanmakuEntry");
		if (Lua_BlackJack_ProjectL_Common_PostDanmakuEntry.<>f__mg$cache0 == null)
		{
			Lua_BlackJack_ProjectL_Common_PostDanmakuEntry.<>f__mg$cache0 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_PostDanmakuEntry.PBPostDanmakuEntryToPostDanmakuEntry_s);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_PostDanmakuEntry.<>f__mg$cache0);
		if (Lua_BlackJack_ProjectL_Common_PostDanmakuEntry.<>f__mg$cache1 == null)
		{
			Lua_BlackJack_ProjectL_Common_PostDanmakuEntry.<>f__mg$cache1 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_PostDanmakuEntry.PostDanmakuEntryToPBPostDanmakuEntry_s);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_PostDanmakuEntry.<>f__mg$cache1);
		string name = "Turn";
		if (Lua_BlackJack_ProjectL_Common_PostDanmakuEntry.<>f__mg$cache2 == null)
		{
			Lua_BlackJack_ProjectL_Common_PostDanmakuEntry.<>f__mg$cache2 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_PostDanmakuEntry.get_Turn);
		}
		LuaCSFunction get = Lua_BlackJack_ProjectL_Common_PostDanmakuEntry.<>f__mg$cache2;
		if (Lua_BlackJack_ProjectL_Common_PostDanmakuEntry.<>f__mg$cache3 == null)
		{
			Lua_BlackJack_ProjectL_Common_PostDanmakuEntry.<>f__mg$cache3 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_PostDanmakuEntry.set_Turn);
		}
		LuaObject.addMember(l, name, get, Lua_BlackJack_ProjectL_Common_PostDanmakuEntry.<>f__mg$cache3, true);
		string name2 = "Content";
		if (Lua_BlackJack_ProjectL_Common_PostDanmakuEntry.<>f__mg$cache4 == null)
		{
			Lua_BlackJack_ProjectL_Common_PostDanmakuEntry.<>f__mg$cache4 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_PostDanmakuEntry.get_Content);
		}
		LuaCSFunction get2 = Lua_BlackJack_ProjectL_Common_PostDanmakuEntry.<>f__mg$cache4;
		if (Lua_BlackJack_ProjectL_Common_PostDanmakuEntry.<>f__mg$cache5 == null)
		{
			Lua_BlackJack_ProjectL_Common_PostDanmakuEntry.<>f__mg$cache5 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_PostDanmakuEntry.set_Content);
		}
		LuaObject.addMember(l, name2, get2, Lua_BlackJack_ProjectL_Common_PostDanmakuEntry.<>f__mg$cache5, true);
		if (Lua_BlackJack_ProjectL_Common_PostDanmakuEntry.<>f__mg$cache6 == null)
		{
			Lua_BlackJack_ProjectL_Common_PostDanmakuEntry.<>f__mg$cache6 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_PostDanmakuEntry.constructor);
		}
		LuaObject.createTypeMetatable(l, Lua_BlackJack_ProjectL_Common_PostDanmakuEntry.<>f__mg$cache6, typeof(PostDanmakuEntry));
	}

	// Token: 0x0400ED87 RID: 60807
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache0;

	// Token: 0x0400ED88 RID: 60808
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1;

	// Token: 0x0400ED89 RID: 60809
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2;

	// Token: 0x0400ED8A RID: 60810
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3;

	// Token: 0x0400ED8B RID: 60811
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache4;

	// Token: 0x0400ED8C RID: 60812
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache5;

	// Token: 0x0400ED8D RID: 60813
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache6;
}
