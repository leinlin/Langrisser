using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using BlackJack.ProjectL.Common;
using SLua;
using UnityEngine.Scripting;

// Token: 0x02001295 RID: 4757
[Preserve]
public class Lua_BlackJack_ProjectL_Common_UserSocialRelation : LuaObject
{
	// Token: 0x06018C98 RID: 101528 RVA: 0x007049A4 File Offset: 0x00702BA4
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int constructor(IntPtr l)
	{
		int result;
		try
		{
			UserSocialRelation o = new UserSocialRelation();
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

	// Token: 0x06018C99 RID: 101529 RVA: 0x007049EC File Offset: 0x00702BEC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_Friends(IntPtr l)
	{
		int result;
		try
		{
			UserSocialRelation userSocialRelation = (UserSocialRelation)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, userSocialRelation.Friends);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06018C9A RID: 101530 RVA: 0x00704A40 File Offset: 0x00702C40
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_Friends(IntPtr l)
	{
		int result;
		try
		{
			UserSocialRelation userSocialRelation = (UserSocialRelation)LuaObject.checkSelf(l);
			List<string> friends;
			LuaObject.checkType<List<string>>(l, 2, out friends);
			userSocialRelation.Friends = friends;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06018C9B RID: 101531 RVA: 0x00704A98 File Offset: 0x00702C98
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_Blacklist(IntPtr l)
	{
		int result;
		try
		{
			UserSocialRelation userSocialRelation = (UserSocialRelation)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, userSocialRelation.Blacklist);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06018C9C RID: 101532 RVA: 0x00704AEC File Offset: 0x00702CEC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_Blacklist(IntPtr l)
	{
		int result;
		try
		{
			UserSocialRelation userSocialRelation = (UserSocialRelation)LuaObject.checkSelf(l);
			List<string> blacklist;
			LuaObject.checkType<List<string>>(l, 2, out blacklist);
			userSocialRelation.Blacklist = blacklist;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06018C9D RID: 101533 RVA: 0x00704B44 File Offset: 0x00702D44
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_Invitelist(IntPtr l)
	{
		int result;
		try
		{
			UserSocialRelation userSocialRelation = (UserSocialRelation)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, userSocialRelation.Invitelist);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06018C9E RID: 101534 RVA: 0x00704B98 File Offset: 0x00702D98
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_Invitelist(IntPtr l)
	{
		int result;
		try
		{
			UserSocialRelation userSocialRelation = (UserSocialRelation)LuaObject.checkSelf(l);
			List<string> invitelist;
			LuaObject.checkType<List<string>>(l, 2, out invitelist);
			userSocialRelation.Invitelist = invitelist;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06018C9F RID: 101535 RVA: 0x00704BF0 File Offset: 0x00702DF0
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_Invitedlist(IntPtr l)
	{
		int result;
		try
		{
			UserSocialRelation userSocialRelation = (UserSocialRelation)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, userSocialRelation.Invitedlist);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06018CA0 RID: 101536 RVA: 0x00704C44 File Offset: 0x00702E44
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_Invitedlist(IntPtr l)
	{
		int result;
		try
		{
			UserSocialRelation userSocialRelation = (UserSocialRelation)LuaObject.checkSelf(l);
			List<string> invitedlist;
			LuaObject.checkType<List<string>>(l, 2, out invitedlist);
			userSocialRelation.Invitedlist = invitedlist;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06018CA1 RID: 101537 RVA: 0x00704C9C File Offset: 0x00702E9C
	[Preserve]
	public static void reg(IntPtr l)
	{
		LuaObject.getTypeTable(l, "BlackJack.ProjectL.Common.UserSocialRelation");
		string name = "Friends";
		if (Lua_BlackJack_ProjectL_Common_UserSocialRelation.<>f__mg$cache0 == null)
		{
			Lua_BlackJack_ProjectL_Common_UserSocialRelation.<>f__mg$cache0 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_UserSocialRelation.get_Friends);
		}
		LuaCSFunction get = Lua_BlackJack_ProjectL_Common_UserSocialRelation.<>f__mg$cache0;
		if (Lua_BlackJack_ProjectL_Common_UserSocialRelation.<>f__mg$cache1 == null)
		{
			Lua_BlackJack_ProjectL_Common_UserSocialRelation.<>f__mg$cache1 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_UserSocialRelation.set_Friends);
		}
		LuaObject.addMember(l, name, get, Lua_BlackJack_ProjectL_Common_UserSocialRelation.<>f__mg$cache1, true);
		string name2 = "Blacklist";
		if (Lua_BlackJack_ProjectL_Common_UserSocialRelation.<>f__mg$cache2 == null)
		{
			Lua_BlackJack_ProjectL_Common_UserSocialRelation.<>f__mg$cache2 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_UserSocialRelation.get_Blacklist);
		}
		LuaCSFunction get2 = Lua_BlackJack_ProjectL_Common_UserSocialRelation.<>f__mg$cache2;
		if (Lua_BlackJack_ProjectL_Common_UserSocialRelation.<>f__mg$cache3 == null)
		{
			Lua_BlackJack_ProjectL_Common_UserSocialRelation.<>f__mg$cache3 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_UserSocialRelation.set_Blacklist);
		}
		LuaObject.addMember(l, name2, get2, Lua_BlackJack_ProjectL_Common_UserSocialRelation.<>f__mg$cache3, true);
		string name3 = "Invitelist";
		if (Lua_BlackJack_ProjectL_Common_UserSocialRelation.<>f__mg$cache4 == null)
		{
			Lua_BlackJack_ProjectL_Common_UserSocialRelation.<>f__mg$cache4 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_UserSocialRelation.get_Invitelist);
		}
		LuaCSFunction get3 = Lua_BlackJack_ProjectL_Common_UserSocialRelation.<>f__mg$cache4;
		if (Lua_BlackJack_ProjectL_Common_UserSocialRelation.<>f__mg$cache5 == null)
		{
			Lua_BlackJack_ProjectL_Common_UserSocialRelation.<>f__mg$cache5 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_UserSocialRelation.set_Invitelist);
		}
		LuaObject.addMember(l, name3, get3, Lua_BlackJack_ProjectL_Common_UserSocialRelation.<>f__mg$cache5, true);
		string name4 = "Invitedlist";
		if (Lua_BlackJack_ProjectL_Common_UserSocialRelation.<>f__mg$cache6 == null)
		{
			Lua_BlackJack_ProjectL_Common_UserSocialRelation.<>f__mg$cache6 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_UserSocialRelation.get_Invitedlist);
		}
		LuaCSFunction get4 = Lua_BlackJack_ProjectL_Common_UserSocialRelation.<>f__mg$cache6;
		if (Lua_BlackJack_ProjectL_Common_UserSocialRelation.<>f__mg$cache7 == null)
		{
			Lua_BlackJack_ProjectL_Common_UserSocialRelation.<>f__mg$cache7 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_UserSocialRelation.set_Invitedlist);
		}
		LuaObject.addMember(l, name4, get4, Lua_BlackJack_ProjectL_Common_UserSocialRelation.<>f__mg$cache7, true);
		if (Lua_BlackJack_ProjectL_Common_UserSocialRelation.<>f__mg$cache8 == null)
		{
			Lua_BlackJack_ProjectL_Common_UserSocialRelation.<>f__mg$cache8 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_UserSocialRelation.constructor);
		}
		LuaObject.createTypeMetatable(l, Lua_BlackJack_ProjectL_Common_UserSocialRelation.<>f__mg$cache8, typeof(UserSocialRelation));
	}

	// Token: 0x0400F150 RID: 61776
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache0;

	// Token: 0x0400F151 RID: 61777
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1;

	// Token: 0x0400F152 RID: 61778
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2;

	// Token: 0x0400F153 RID: 61779
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3;

	// Token: 0x0400F154 RID: 61780
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache4;

	// Token: 0x0400F155 RID: 61781
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache5;

	// Token: 0x0400F156 RID: 61782
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache6;

	// Token: 0x0400F157 RID: 61783
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache7;

	// Token: 0x0400F158 RID: 61784
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache8;
}
