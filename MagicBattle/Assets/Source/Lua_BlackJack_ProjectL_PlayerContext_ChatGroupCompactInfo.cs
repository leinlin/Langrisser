using System;
using System.Runtime.CompilerServices;
using BlackJack.ProjectL.PlayerContext;
using BlackJack.ProjectL.Protocol;
using SLua;
using UnityEngine.Scripting;

// Token: 0x020012B9 RID: 4793
[Preserve]
public class Lua_BlackJack_ProjectL_PlayerContext_ChatGroupCompactInfo : LuaObject
{
	// Token: 0x06019347 RID: 103239 RVA: 0x00736040 File Offset: 0x00734240
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int constructor(IntPtr l)
	{
		int result;
		try
		{
			ProChatGroupCompactInfo pbGroupInfo;
			LuaObject.checkType<ProChatGroupCompactInfo>(l, 2, out pbGroupInfo);
			ChatGroupCompactInfo o = new ChatGroupCompactInfo(pbGroupInfo);
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

	// Token: 0x06019348 RID: 103240 RVA: 0x00736094 File Offset: 0x00734294
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_ChatGroupId(IntPtr l)
	{
		int result;
		try
		{
			ChatGroupCompactInfo chatGroupCompactInfo = (ChatGroupCompactInfo)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, chatGroupCompactInfo.ChatGroupId);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06019349 RID: 103241 RVA: 0x007360E8 File Offset: 0x007342E8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_ChatGroupId(IntPtr l)
	{
		int result;
		try
		{
			ChatGroupCompactInfo chatGroupCompactInfo = (ChatGroupCompactInfo)LuaObject.checkSelf(l);
			string chatGroupId;
			LuaObject.checkType(l, 2, out chatGroupId);
			chatGroupCompactInfo.ChatGroupId = chatGroupId;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601934A RID: 103242 RVA: 0x00736140 File Offset: 0x00734340
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_ChatGroupName(IntPtr l)
	{
		int result;
		try
		{
			ChatGroupCompactInfo chatGroupCompactInfo = (ChatGroupCompactInfo)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, chatGroupCompactInfo.ChatGroupName);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601934B RID: 103243 RVA: 0x00736194 File Offset: 0x00734394
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_ChatGroupName(IntPtr l)
	{
		int result;
		try
		{
			ChatGroupCompactInfo chatGroupCompactInfo = (ChatGroupCompactInfo)LuaObject.checkSelf(l);
			string chatGroupName;
			LuaObject.checkType(l, 2, out chatGroupName);
			chatGroupCompactInfo.ChatGroupName = chatGroupName;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601934C RID: 103244 RVA: 0x007361EC File Offset: 0x007343EC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_Owner(IntPtr l)
	{
		int result;
		try
		{
			ChatGroupCompactInfo chatGroupCompactInfo = (ChatGroupCompactInfo)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, chatGroupCompactInfo.Owner);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601934D RID: 103245 RVA: 0x00736240 File Offset: 0x00734440
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_Owner(IntPtr l)
	{
		int result;
		try
		{
			ChatGroupCompactInfo chatGroupCompactInfo = (ChatGroupCompactInfo)LuaObject.checkSelf(l);
			ChatUserCompactInfo owner;
			LuaObject.checkType<ChatUserCompactInfo>(l, 2, out owner);
			chatGroupCompactInfo.Owner = owner;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601934E RID: 103246 RVA: 0x00736298 File Offset: 0x00734498
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_UserCount(IntPtr l)
	{
		int result;
		try
		{
			ChatGroupCompactInfo chatGroupCompactInfo = (ChatGroupCompactInfo)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, chatGroupCompactInfo.UserCount);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601934F RID: 103247 RVA: 0x007362EC File Offset: 0x007344EC
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_UserCount(IntPtr l)
	{
		int result;
		try
		{
			ChatGroupCompactInfo chatGroupCompactInfo = (ChatGroupCompactInfo)LuaObject.checkSelf(l);
			int userCount;
			LuaObject.checkType(l, 2, out userCount);
			chatGroupCompactInfo.UserCount = userCount;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06019350 RID: 103248 RVA: 0x00736344 File Offset: 0x00734544
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_OnlineUserCount(IntPtr l)
	{
		int result;
		try
		{
			ChatGroupCompactInfo chatGroupCompactInfo = (ChatGroupCompactInfo)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, chatGroupCompactInfo.OnlineUserCount);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06019351 RID: 103249 RVA: 0x00736398 File Offset: 0x00734598
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_OnlineUserCount(IntPtr l)
	{
		int result;
		try
		{
			ChatGroupCompactInfo chatGroupCompactInfo = (ChatGroupCompactInfo)LuaObject.checkSelf(l);
			int onlineUserCount;
			LuaObject.checkType(l, 2, out onlineUserCount);
			chatGroupCompactInfo.OnlineUserCount = onlineUserCount;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06019352 RID: 103250 RVA: 0x007363F0 File Offset: 0x007345F0
	[Preserve]
	public static void reg(IntPtr l)
	{
		LuaObject.getTypeTable(l, "BlackJack.ProjectL.PlayerContext.ChatGroupCompactInfo");
		string name = "ChatGroupId";
		if (Lua_BlackJack_ProjectL_PlayerContext_ChatGroupCompactInfo.<>f__mg$cache0 == null)
		{
			Lua_BlackJack_ProjectL_PlayerContext_ChatGroupCompactInfo.<>f__mg$cache0 = new LuaCSFunction(Lua_BlackJack_ProjectL_PlayerContext_ChatGroupCompactInfo.get_ChatGroupId);
		}
		LuaCSFunction get = Lua_BlackJack_ProjectL_PlayerContext_ChatGroupCompactInfo.<>f__mg$cache0;
		if (Lua_BlackJack_ProjectL_PlayerContext_ChatGroupCompactInfo.<>f__mg$cache1 == null)
		{
			Lua_BlackJack_ProjectL_PlayerContext_ChatGroupCompactInfo.<>f__mg$cache1 = new LuaCSFunction(Lua_BlackJack_ProjectL_PlayerContext_ChatGroupCompactInfo.set_ChatGroupId);
		}
		LuaObject.addMember(l, name, get, Lua_BlackJack_ProjectL_PlayerContext_ChatGroupCompactInfo.<>f__mg$cache1, true);
		string name2 = "ChatGroupName";
		if (Lua_BlackJack_ProjectL_PlayerContext_ChatGroupCompactInfo.<>f__mg$cache2 == null)
		{
			Lua_BlackJack_ProjectL_PlayerContext_ChatGroupCompactInfo.<>f__mg$cache2 = new LuaCSFunction(Lua_BlackJack_ProjectL_PlayerContext_ChatGroupCompactInfo.get_ChatGroupName);
		}
		LuaCSFunction get2 = Lua_BlackJack_ProjectL_PlayerContext_ChatGroupCompactInfo.<>f__mg$cache2;
		if (Lua_BlackJack_ProjectL_PlayerContext_ChatGroupCompactInfo.<>f__mg$cache3 == null)
		{
			Lua_BlackJack_ProjectL_PlayerContext_ChatGroupCompactInfo.<>f__mg$cache3 = new LuaCSFunction(Lua_BlackJack_ProjectL_PlayerContext_ChatGroupCompactInfo.set_ChatGroupName);
		}
		LuaObject.addMember(l, name2, get2, Lua_BlackJack_ProjectL_PlayerContext_ChatGroupCompactInfo.<>f__mg$cache3, true);
		string name3 = "Owner";
		if (Lua_BlackJack_ProjectL_PlayerContext_ChatGroupCompactInfo.<>f__mg$cache4 == null)
		{
			Lua_BlackJack_ProjectL_PlayerContext_ChatGroupCompactInfo.<>f__mg$cache4 = new LuaCSFunction(Lua_BlackJack_ProjectL_PlayerContext_ChatGroupCompactInfo.get_Owner);
		}
		LuaCSFunction get3 = Lua_BlackJack_ProjectL_PlayerContext_ChatGroupCompactInfo.<>f__mg$cache4;
		if (Lua_BlackJack_ProjectL_PlayerContext_ChatGroupCompactInfo.<>f__mg$cache5 == null)
		{
			Lua_BlackJack_ProjectL_PlayerContext_ChatGroupCompactInfo.<>f__mg$cache5 = new LuaCSFunction(Lua_BlackJack_ProjectL_PlayerContext_ChatGroupCompactInfo.set_Owner);
		}
		LuaObject.addMember(l, name3, get3, Lua_BlackJack_ProjectL_PlayerContext_ChatGroupCompactInfo.<>f__mg$cache5, true);
		string name4 = "UserCount";
		if (Lua_BlackJack_ProjectL_PlayerContext_ChatGroupCompactInfo.<>f__mg$cache6 == null)
		{
			Lua_BlackJack_ProjectL_PlayerContext_ChatGroupCompactInfo.<>f__mg$cache6 = new LuaCSFunction(Lua_BlackJack_ProjectL_PlayerContext_ChatGroupCompactInfo.get_UserCount);
		}
		LuaCSFunction get4 = Lua_BlackJack_ProjectL_PlayerContext_ChatGroupCompactInfo.<>f__mg$cache6;
		if (Lua_BlackJack_ProjectL_PlayerContext_ChatGroupCompactInfo.<>f__mg$cache7 == null)
		{
			Lua_BlackJack_ProjectL_PlayerContext_ChatGroupCompactInfo.<>f__mg$cache7 = new LuaCSFunction(Lua_BlackJack_ProjectL_PlayerContext_ChatGroupCompactInfo.set_UserCount);
		}
		LuaObject.addMember(l, name4, get4, Lua_BlackJack_ProjectL_PlayerContext_ChatGroupCompactInfo.<>f__mg$cache7, true);
		string name5 = "OnlineUserCount";
		if (Lua_BlackJack_ProjectL_PlayerContext_ChatGroupCompactInfo.<>f__mg$cache8 == null)
		{
			Lua_BlackJack_ProjectL_PlayerContext_ChatGroupCompactInfo.<>f__mg$cache8 = new LuaCSFunction(Lua_BlackJack_ProjectL_PlayerContext_ChatGroupCompactInfo.get_OnlineUserCount);
		}
		LuaCSFunction get5 = Lua_BlackJack_ProjectL_PlayerContext_ChatGroupCompactInfo.<>f__mg$cache8;
		if (Lua_BlackJack_ProjectL_PlayerContext_ChatGroupCompactInfo.<>f__mg$cache9 == null)
		{
			Lua_BlackJack_ProjectL_PlayerContext_ChatGroupCompactInfo.<>f__mg$cache9 = new LuaCSFunction(Lua_BlackJack_ProjectL_PlayerContext_ChatGroupCompactInfo.set_OnlineUserCount);
		}
		LuaObject.addMember(l, name5, get5, Lua_BlackJack_ProjectL_PlayerContext_ChatGroupCompactInfo.<>f__mg$cache9, true);
		if (Lua_BlackJack_ProjectL_PlayerContext_ChatGroupCompactInfo.<>f__mg$cacheA == null)
		{
			Lua_BlackJack_ProjectL_PlayerContext_ChatGroupCompactInfo.<>f__mg$cacheA = new LuaCSFunction(Lua_BlackJack_ProjectL_PlayerContext_ChatGroupCompactInfo.constructor);
		}
		LuaObject.createTypeMetatable(l, Lua_BlackJack_ProjectL_PlayerContext_ChatGroupCompactInfo.<>f__mg$cacheA, typeof(ChatGroupCompactInfo));
	}

	// Token: 0x0400F7B7 RID: 63415
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache0;

	// Token: 0x0400F7B8 RID: 63416
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1;

	// Token: 0x0400F7B9 RID: 63417
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2;

	// Token: 0x0400F7BA RID: 63418
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3;

	// Token: 0x0400F7BB RID: 63419
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache4;

	// Token: 0x0400F7BC RID: 63420
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache5;

	// Token: 0x0400F7BD RID: 63421
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache6;

	// Token: 0x0400F7BE RID: 63422
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache7;

	// Token: 0x0400F7BF RID: 63423
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache8;

	// Token: 0x0400F7C0 RID: 63424
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache9;

	// Token: 0x0400F7C1 RID: 63425
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheA;
}
