using System;
using System.Runtime.CompilerServices;
using BlackJack.ProjectL.Common;
using SLua;
using UnityEngine.Scripting;

// Token: 0x02001232 RID: 4658
[Preserve]
public class Lua_BlackJack_ProjectL_Common_GuildMemberCacheObject : LuaObject
{
	// Token: 0x0601827C RID: 98940 RVA: 0x006B8634 File Offset: 0x006B6834
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int constructor(IntPtr l)
	{
		int result;
		try
		{
			GuildMemberCacheObject o = new GuildMemberCacheObject();
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

	// Token: 0x0601827D RID: 98941 RVA: 0x006B867C File Offset: 0x006B687C
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_Dirty(IntPtr l)
	{
		int result;
		try
		{
			GuildMemberCacheObject guildMemberCacheObject = (GuildMemberCacheObject)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, guildMemberCacheObject.Dirty);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601827E RID: 98942 RVA: 0x006B86D0 File Offset: 0x006B68D0
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_Dirty(IntPtr l)
	{
		int result;
		try
		{
			GuildMemberCacheObject guildMemberCacheObject = (GuildMemberCacheObject)LuaObject.checkSelf(l);
			bool dirty;
			LuaObject.checkType(l, 2, out dirty);
			guildMemberCacheObject.Dirty = dirty;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601827F RID: 98943 RVA: 0x006B8728 File Offset: 0x006B6928
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_Member(IntPtr l)
	{
		int result;
		try
		{
			GuildMemberCacheObject guildMemberCacheObject = (GuildMemberCacheObject)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, guildMemberCacheObject.Member);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06018280 RID: 98944 RVA: 0x006B877C File Offset: 0x006B697C
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_Member(IntPtr l)
	{
		int result;
		try
		{
			GuildMemberCacheObject guildMemberCacheObject = (GuildMemberCacheObject)LuaObject.checkSelf(l);
			GuildMember member;
			LuaObject.checkType<GuildMember>(l, 2, out member);
			guildMemberCacheObject.Member = member;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06018281 RID: 98945 RVA: 0x006B87D4 File Offset: 0x006B69D4
	[Preserve]
	public static void reg(IntPtr l)
	{
		LuaObject.getTypeTable(l, "BlackJack.ProjectL.Common.GuildMemberCacheObject");
		string name = "Dirty";
		if (Lua_BlackJack_ProjectL_Common_GuildMemberCacheObject.<>f__mg$cache0 == null)
		{
			Lua_BlackJack_ProjectL_Common_GuildMemberCacheObject.<>f__mg$cache0 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_GuildMemberCacheObject.get_Dirty);
		}
		LuaCSFunction get = Lua_BlackJack_ProjectL_Common_GuildMemberCacheObject.<>f__mg$cache0;
		if (Lua_BlackJack_ProjectL_Common_GuildMemberCacheObject.<>f__mg$cache1 == null)
		{
			Lua_BlackJack_ProjectL_Common_GuildMemberCacheObject.<>f__mg$cache1 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_GuildMemberCacheObject.set_Dirty);
		}
		LuaObject.addMember(l, name, get, Lua_BlackJack_ProjectL_Common_GuildMemberCacheObject.<>f__mg$cache1, true);
		string name2 = "Member";
		if (Lua_BlackJack_ProjectL_Common_GuildMemberCacheObject.<>f__mg$cache2 == null)
		{
			Lua_BlackJack_ProjectL_Common_GuildMemberCacheObject.<>f__mg$cache2 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_GuildMemberCacheObject.get_Member);
		}
		LuaCSFunction get2 = Lua_BlackJack_ProjectL_Common_GuildMemberCacheObject.<>f__mg$cache2;
		if (Lua_BlackJack_ProjectL_Common_GuildMemberCacheObject.<>f__mg$cache3 == null)
		{
			Lua_BlackJack_ProjectL_Common_GuildMemberCacheObject.<>f__mg$cache3 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_GuildMemberCacheObject.set_Member);
		}
		LuaObject.addMember(l, name2, get2, Lua_BlackJack_ProjectL_Common_GuildMemberCacheObject.<>f__mg$cache3, true);
		if (Lua_BlackJack_ProjectL_Common_GuildMemberCacheObject.<>f__mg$cache4 == null)
		{
			Lua_BlackJack_ProjectL_Common_GuildMemberCacheObject.<>f__mg$cache4 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_GuildMemberCacheObject.constructor);
		}
		LuaObject.createTypeMetatable(l, Lua_BlackJack_ProjectL_Common_GuildMemberCacheObject.<>f__mg$cache4, typeof(GuildMemberCacheObject));
	}

	// Token: 0x0400E7FA RID: 59386
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache0;

	// Token: 0x0400E7FB RID: 59387
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1;

	// Token: 0x0400E7FC RID: 59388
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2;

	// Token: 0x0400E7FD RID: 59389
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3;

	// Token: 0x0400E7FE RID: 59390
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache4;
}
