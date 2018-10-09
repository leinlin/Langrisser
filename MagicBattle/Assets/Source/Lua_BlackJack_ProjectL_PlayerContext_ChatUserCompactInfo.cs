using System;
using System.Runtime.CompilerServices;
using BlackJack.ProjectL.PlayerContext;
using BlackJack.ProjectL.Protocol;
using SLua;
using UnityEngine.Scripting;

// Token: 0x020012BB RID: 4795
[Preserve]
public class Lua_BlackJack_ProjectL_PlayerContext_ChatUserCompactInfo : LuaObject
{
	// Token: 0x0601936A RID: 103274 RVA: 0x00736F74 File Offset: 0x00735174
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int constructor(IntPtr l)
	{
		int result;
		try
		{
			ProChatUserCompactInfo userInfo;
			LuaObject.checkType<ProChatUserCompactInfo>(l, 2, out userInfo);
			ChatUserCompactInfo o = new ChatUserCompactInfo(userInfo);
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

	// Token: 0x0601936B RID: 103275 RVA: 0x00736FC8 File Offset: 0x007351C8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_UserId(IntPtr l)
	{
		int result;
		try
		{
			ChatUserCompactInfo chatUserCompactInfo = (ChatUserCompactInfo)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, chatUserCompactInfo.UserId);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601936C RID: 103276 RVA: 0x0073701C File Offset: 0x0073521C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_UserId(IntPtr l)
	{
		int result;
		try
		{
			ChatUserCompactInfo chatUserCompactInfo = (ChatUserCompactInfo)LuaObject.checkSelf(l);
			string userId;
			LuaObject.checkType(l, 2, out userId);
			chatUserCompactInfo.UserId = userId;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601936D RID: 103277 RVA: 0x00737074 File Offset: 0x00735274
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_UserName(IntPtr l)
	{
		int result;
		try
		{
			ChatUserCompactInfo chatUserCompactInfo = (ChatUserCompactInfo)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, chatUserCompactInfo.UserName);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601936E RID: 103278 RVA: 0x007370C8 File Offset: 0x007352C8
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_UserName(IntPtr l)
	{
		int result;
		try
		{
			ChatUserCompactInfo chatUserCompactInfo = (ChatUserCompactInfo)LuaObject.checkSelf(l);
			string userName;
			LuaObject.checkType(l, 2, out userName);
			chatUserCompactInfo.UserName = userName;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601936F RID: 103279 RVA: 0x00737120 File Offset: 0x00735320
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_HeadIcon(IntPtr l)
	{
		int result;
		try
		{
			ChatUserCompactInfo chatUserCompactInfo = (ChatUserCompactInfo)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, chatUserCompactInfo.HeadIcon);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06019370 RID: 103280 RVA: 0x00737174 File Offset: 0x00735374
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_HeadIcon(IntPtr l)
	{
		int result;
		try
		{
			ChatUserCompactInfo chatUserCompactInfo = (ChatUserCompactInfo)LuaObject.checkSelf(l);
			int headIcon;
			LuaObject.checkType(l, 2, out headIcon);
			chatUserCompactInfo.HeadIcon = headIcon;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06019371 RID: 103281 RVA: 0x007371CC File Offset: 0x007353CC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_IsOnline(IntPtr l)
	{
		int result;
		try
		{
			ChatUserCompactInfo chatUserCompactInfo = (ChatUserCompactInfo)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, chatUserCompactInfo.IsOnline);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06019372 RID: 103282 RVA: 0x00737220 File Offset: 0x00735420
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_IsOnline(IntPtr l)
	{
		int result;
		try
		{
			ChatUserCompactInfo chatUserCompactInfo = (ChatUserCompactInfo)LuaObject.checkSelf(l);
			bool isOnline;
			LuaObject.checkType(l, 2, out isOnline);
			chatUserCompactInfo.IsOnline = isOnline;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06019373 RID: 103283 RVA: 0x00737278 File Offset: 0x00735478
	[Preserve]
	public static void reg(IntPtr l)
	{
		LuaObject.getTypeTable(l, "BlackJack.ProjectL.PlayerContext.ChatUserCompactInfo");
		string name = "UserId";
		if (Lua_BlackJack_ProjectL_PlayerContext_ChatUserCompactInfo.<>f__mg$cache0 == null)
		{
			Lua_BlackJack_ProjectL_PlayerContext_ChatUserCompactInfo.<>f__mg$cache0 = new LuaCSFunction(Lua_BlackJack_ProjectL_PlayerContext_ChatUserCompactInfo.get_UserId);
		}
		LuaCSFunction get = Lua_BlackJack_ProjectL_PlayerContext_ChatUserCompactInfo.<>f__mg$cache0;
		if (Lua_BlackJack_ProjectL_PlayerContext_ChatUserCompactInfo.<>f__mg$cache1 == null)
		{
			Lua_BlackJack_ProjectL_PlayerContext_ChatUserCompactInfo.<>f__mg$cache1 = new LuaCSFunction(Lua_BlackJack_ProjectL_PlayerContext_ChatUserCompactInfo.set_UserId);
		}
		LuaObject.addMember(l, name, get, Lua_BlackJack_ProjectL_PlayerContext_ChatUserCompactInfo.<>f__mg$cache1, true);
		string name2 = "UserName";
		if (Lua_BlackJack_ProjectL_PlayerContext_ChatUserCompactInfo.<>f__mg$cache2 == null)
		{
			Lua_BlackJack_ProjectL_PlayerContext_ChatUserCompactInfo.<>f__mg$cache2 = new LuaCSFunction(Lua_BlackJack_ProjectL_PlayerContext_ChatUserCompactInfo.get_UserName);
		}
		LuaCSFunction get2 = Lua_BlackJack_ProjectL_PlayerContext_ChatUserCompactInfo.<>f__mg$cache2;
		if (Lua_BlackJack_ProjectL_PlayerContext_ChatUserCompactInfo.<>f__mg$cache3 == null)
		{
			Lua_BlackJack_ProjectL_PlayerContext_ChatUserCompactInfo.<>f__mg$cache3 = new LuaCSFunction(Lua_BlackJack_ProjectL_PlayerContext_ChatUserCompactInfo.set_UserName);
		}
		LuaObject.addMember(l, name2, get2, Lua_BlackJack_ProjectL_PlayerContext_ChatUserCompactInfo.<>f__mg$cache3, true);
		string name3 = "HeadIcon";
		if (Lua_BlackJack_ProjectL_PlayerContext_ChatUserCompactInfo.<>f__mg$cache4 == null)
		{
			Lua_BlackJack_ProjectL_PlayerContext_ChatUserCompactInfo.<>f__mg$cache4 = new LuaCSFunction(Lua_BlackJack_ProjectL_PlayerContext_ChatUserCompactInfo.get_HeadIcon);
		}
		LuaCSFunction get3 = Lua_BlackJack_ProjectL_PlayerContext_ChatUserCompactInfo.<>f__mg$cache4;
		if (Lua_BlackJack_ProjectL_PlayerContext_ChatUserCompactInfo.<>f__mg$cache5 == null)
		{
			Lua_BlackJack_ProjectL_PlayerContext_ChatUserCompactInfo.<>f__mg$cache5 = new LuaCSFunction(Lua_BlackJack_ProjectL_PlayerContext_ChatUserCompactInfo.set_HeadIcon);
		}
		LuaObject.addMember(l, name3, get3, Lua_BlackJack_ProjectL_PlayerContext_ChatUserCompactInfo.<>f__mg$cache5, true);
		string name4 = "IsOnline";
		if (Lua_BlackJack_ProjectL_PlayerContext_ChatUserCompactInfo.<>f__mg$cache6 == null)
		{
			Lua_BlackJack_ProjectL_PlayerContext_ChatUserCompactInfo.<>f__mg$cache6 = new LuaCSFunction(Lua_BlackJack_ProjectL_PlayerContext_ChatUserCompactInfo.get_IsOnline);
		}
		LuaCSFunction get4 = Lua_BlackJack_ProjectL_PlayerContext_ChatUserCompactInfo.<>f__mg$cache6;
		if (Lua_BlackJack_ProjectL_PlayerContext_ChatUserCompactInfo.<>f__mg$cache7 == null)
		{
			Lua_BlackJack_ProjectL_PlayerContext_ChatUserCompactInfo.<>f__mg$cache7 = new LuaCSFunction(Lua_BlackJack_ProjectL_PlayerContext_ChatUserCompactInfo.set_IsOnline);
		}
		LuaObject.addMember(l, name4, get4, Lua_BlackJack_ProjectL_PlayerContext_ChatUserCompactInfo.<>f__mg$cache7, true);
		if (Lua_BlackJack_ProjectL_PlayerContext_ChatUserCompactInfo.<>f__mg$cache8 == null)
		{
			Lua_BlackJack_ProjectL_PlayerContext_ChatUserCompactInfo.<>f__mg$cache8 = new LuaCSFunction(Lua_BlackJack_ProjectL_PlayerContext_ChatUserCompactInfo.constructor);
		}
		LuaObject.createTypeMetatable(l, Lua_BlackJack_ProjectL_PlayerContext_ChatUserCompactInfo.<>f__mg$cache8, typeof(ChatUserCompactInfo));
	}

	// Token: 0x0400F7D6 RID: 63446
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache0;

	// Token: 0x0400F7D7 RID: 63447
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1;

	// Token: 0x0400F7D8 RID: 63448
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2;

	// Token: 0x0400F7D9 RID: 63449
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3;

	// Token: 0x0400F7DA RID: 63450
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache4;

	// Token: 0x0400F7DB RID: 63451
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache5;

	// Token: 0x0400F7DC RID: 63452
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache6;

	// Token: 0x0400F7DD RID: 63453
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache7;

	// Token: 0x0400F7DE RID: 63454
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache8;
}
