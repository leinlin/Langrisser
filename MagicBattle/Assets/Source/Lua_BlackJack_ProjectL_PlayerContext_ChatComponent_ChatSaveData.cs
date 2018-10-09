using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using BlackJack.ProjectL.PlayerContext;
using SLua;
using UnityEngine.Scripting;

// Token: 0x020012B8 RID: 4792
[Preserve]
public class Lua_BlackJack_ProjectL_PlayerContext_ChatComponent_ChatSaveData : LuaObject
{
	// Token: 0x06019338 RID: 103224 RVA: 0x007359F8 File Offset: 0x00733BF8
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int constructor(IntPtr l)
	{
		int result;
		try
		{
			ChatComponent.ChatSaveData o = new ChatComponent.ChatSaveData();
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

	// Token: 0x06019339 RID: 103225 RVA: 0x00735A40 File Offset: 0x00733C40
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_m_userId(IntPtr l)
	{
		int result;
		try
		{
			ChatComponent.ChatSaveData chatSaveData = (ChatComponent.ChatSaveData)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, chatSaveData.m_userId);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601933A RID: 103226 RVA: 0x00735A94 File Offset: 0x00733C94
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_m_userId(IntPtr l)
	{
		int result;
		try
		{
			ChatComponent.ChatSaveData chatSaveData = (ChatComponent.ChatSaveData)LuaObject.checkSelf(l);
			string userId;
			LuaObject.checkType(l, 2, out userId);
			chatSaveData.m_userId = userId;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601933B RID: 103227 RVA: 0x00735AEC File Offset: 0x00733CEC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_guildChatLastReadTime(IntPtr l)
	{
		int result;
		try
		{
			ChatComponent.ChatSaveData chatSaveData = (ChatComponent.ChatSaveData)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, chatSaveData.m_guildChatLastReadTime);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601933C RID: 103228 RVA: 0x00735B44 File Offset: 0x00733D44
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_guildChatLastReadTime(IntPtr l)
	{
		int result;
		try
		{
			ChatComponent.ChatSaveData chatSaveData = (ChatComponent.ChatSaveData)LuaObject.checkSelf(l);
			DateTime guildChatLastReadTime;
			LuaObject.checkValueType<DateTime>(l, 2, out guildChatLastReadTime);
			chatSaveData.m_guildChatLastReadTime = guildChatLastReadTime;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601933D RID: 103229 RVA: 0x00735B9C File Offset: 0x00733D9C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_recentLinkManIdList(IntPtr l)
	{
		int result;
		try
		{
			ChatComponent.ChatSaveData chatSaveData = (ChatComponent.ChatSaveData)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, chatSaveData.m_recentLinkManIdList);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601933E RID: 103230 RVA: 0x00735BF0 File Offset: 0x00733DF0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_recentLinkManIdList(IntPtr l)
	{
		int result;
		try
		{
			ChatComponent.ChatSaveData chatSaveData = (ChatComponent.ChatSaveData)LuaObject.checkSelf(l);
			List<string> recentLinkManIdList;
			LuaObject.checkType<List<string>>(l, 2, out recentLinkManIdList);
			chatSaveData.m_recentLinkManIdList = recentLinkManIdList;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601933F RID: 103231 RVA: 0x00735C48 File Offset: 0x00733E48
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_recentLinkGroupIdList(IntPtr l)
	{
		int result;
		try
		{
			ChatComponent.ChatSaveData chatSaveData = (ChatComponent.ChatSaveData)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, chatSaveData.m_recentLinkGroupIdList);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06019340 RID: 103232 RVA: 0x00735C9C File Offset: 0x00733E9C
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_m_recentLinkGroupIdList(IntPtr l)
	{
		int result;
		try
		{
			ChatComponent.ChatSaveData chatSaveData = (ChatComponent.ChatSaveData)LuaObject.checkSelf(l);
			List<string> recentLinkGroupIdList;
			LuaObject.checkType<List<string>>(l, 2, out recentLinkGroupIdList);
			chatSaveData.m_recentLinkGroupIdList = recentLinkGroupIdList;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06019341 RID: 103233 RVA: 0x00735CF4 File Offset: 0x00733EF4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_privateChatDataDict(IntPtr l)
	{
		int result;
		try
		{
			ChatComponent.ChatSaveData chatSaveData = (ChatComponent.ChatSaveData)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, chatSaveData.m_privateChatDataDict);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06019342 RID: 103234 RVA: 0x00735D48 File Offset: 0x00733F48
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_m_privateChatDataDict(IntPtr l)
	{
		int result;
		try
		{
			ChatComponent.ChatSaveData chatSaveData = (ChatComponent.ChatSaveData)LuaObject.checkSelf(l);
			Dictionary<string, List<ChatComponent.ChatMessageClient>> privateChatDataDict;
			LuaObject.checkType<Dictionary<string, List<ChatComponent.ChatMessageClient>>>(l, 2, out privateChatDataDict);
			chatSaveData.m_privateChatDataDict = privateChatDataDict;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06019343 RID: 103235 RVA: 0x00735DA0 File Offset: 0x00733FA0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_groupChatDataDict(IntPtr l)
	{
		int result;
		try
		{
			ChatComponent.ChatSaveData chatSaveData = (ChatComponent.ChatSaveData)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, chatSaveData.m_groupChatDataDict);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06019344 RID: 103236 RVA: 0x00735DF4 File Offset: 0x00733FF4
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_m_groupChatDataDict(IntPtr l)
	{
		int result;
		try
		{
			ChatComponent.ChatSaveData chatSaveData = (ChatComponent.ChatSaveData)LuaObject.checkSelf(l);
			Dictionary<string, List<ChatComponent.ChatMessageClient>> groupChatDataDict;
			LuaObject.checkType<Dictionary<string, List<ChatComponent.ChatMessageClient>>>(l, 2, out groupChatDataDict);
			chatSaveData.m_groupChatDataDict = groupChatDataDict;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06019345 RID: 103237 RVA: 0x00735E4C File Offset: 0x0073404C
	[Preserve]
	public static void reg(IntPtr l)
	{
		LuaObject.getTypeTable(l, "BlackJack.ProjectL.PlayerContext.ChatComponent.ChatSaveData");
		string name = "m_userId";
		if (Lua_BlackJack_ProjectL_PlayerContext_ChatComponent_ChatSaveData.<>f__mg$cache0 == null)
		{
			Lua_BlackJack_ProjectL_PlayerContext_ChatComponent_ChatSaveData.<>f__mg$cache0 = new LuaCSFunction(Lua_BlackJack_ProjectL_PlayerContext_ChatComponent_ChatSaveData.get_m_userId);
		}
		LuaCSFunction get = Lua_BlackJack_ProjectL_PlayerContext_ChatComponent_ChatSaveData.<>f__mg$cache0;
		if (Lua_BlackJack_ProjectL_PlayerContext_ChatComponent_ChatSaveData.<>f__mg$cache1 == null)
		{
			Lua_BlackJack_ProjectL_PlayerContext_ChatComponent_ChatSaveData.<>f__mg$cache1 = new LuaCSFunction(Lua_BlackJack_ProjectL_PlayerContext_ChatComponent_ChatSaveData.set_m_userId);
		}
		LuaObject.addMember(l, name, get, Lua_BlackJack_ProjectL_PlayerContext_ChatComponent_ChatSaveData.<>f__mg$cache1, true);
		string name2 = "m_guildChatLastReadTime";
		if (Lua_BlackJack_ProjectL_PlayerContext_ChatComponent_ChatSaveData.<>f__mg$cache2 == null)
		{
			Lua_BlackJack_ProjectL_PlayerContext_ChatComponent_ChatSaveData.<>f__mg$cache2 = new LuaCSFunction(Lua_BlackJack_ProjectL_PlayerContext_ChatComponent_ChatSaveData.get_m_guildChatLastReadTime);
		}
		LuaCSFunction get2 = Lua_BlackJack_ProjectL_PlayerContext_ChatComponent_ChatSaveData.<>f__mg$cache2;
		if (Lua_BlackJack_ProjectL_PlayerContext_ChatComponent_ChatSaveData.<>f__mg$cache3 == null)
		{
			Lua_BlackJack_ProjectL_PlayerContext_ChatComponent_ChatSaveData.<>f__mg$cache3 = new LuaCSFunction(Lua_BlackJack_ProjectL_PlayerContext_ChatComponent_ChatSaveData.set_m_guildChatLastReadTime);
		}
		LuaObject.addMember(l, name2, get2, Lua_BlackJack_ProjectL_PlayerContext_ChatComponent_ChatSaveData.<>f__mg$cache3, true);
		string name3 = "m_recentLinkManIdList";
		if (Lua_BlackJack_ProjectL_PlayerContext_ChatComponent_ChatSaveData.<>f__mg$cache4 == null)
		{
			Lua_BlackJack_ProjectL_PlayerContext_ChatComponent_ChatSaveData.<>f__mg$cache4 = new LuaCSFunction(Lua_BlackJack_ProjectL_PlayerContext_ChatComponent_ChatSaveData.get_m_recentLinkManIdList);
		}
		LuaCSFunction get3 = Lua_BlackJack_ProjectL_PlayerContext_ChatComponent_ChatSaveData.<>f__mg$cache4;
		if (Lua_BlackJack_ProjectL_PlayerContext_ChatComponent_ChatSaveData.<>f__mg$cache5 == null)
		{
			Lua_BlackJack_ProjectL_PlayerContext_ChatComponent_ChatSaveData.<>f__mg$cache5 = new LuaCSFunction(Lua_BlackJack_ProjectL_PlayerContext_ChatComponent_ChatSaveData.set_m_recentLinkManIdList);
		}
		LuaObject.addMember(l, name3, get3, Lua_BlackJack_ProjectL_PlayerContext_ChatComponent_ChatSaveData.<>f__mg$cache5, true);
		string name4 = "m_recentLinkGroupIdList";
		if (Lua_BlackJack_ProjectL_PlayerContext_ChatComponent_ChatSaveData.<>f__mg$cache6 == null)
		{
			Lua_BlackJack_ProjectL_PlayerContext_ChatComponent_ChatSaveData.<>f__mg$cache6 = new LuaCSFunction(Lua_BlackJack_ProjectL_PlayerContext_ChatComponent_ChatSaveData.get_m_recentLinkGroupIdList);
		}
		LuaCSFunction get4 = Lua_BlackJack_ProjectL_PlayerContext_ChatComponent_ChatSaveData.<>f__mg$cache6;
		if (Lua_BlackJack_ProjectL_PlayerContext_ChatComponent_ChatSaveData.<>f__mg$cache7 == null)
		{
			Lua_BlackJack_ProjectL_PlayerContext_ChatComponent_ChatSaveData.<>f__mg$cache7 = new LuaCSFunction(Lua_BlackJack_ProjectL_PlayerContext_ChatComponent_ChatSaveData.set_m_recentLinkGroupIdList);
		}
		LuaObject.addMember(l, name4, get4, Lua_BlackJack_ProjectL_PlayerContext_ChatComponent_ChatSaveData.<>f__mg$cache7, true);
		string name5 = "m_privateChatDataDict";
		if (Lua_BlackJack_ProjectL_PlayerContext_ChatComponent_ChatSaveData.<>f__mg$cache8 == null)
		{
			Lua_BlackJack_ProjectL_PlayerContext_ChatComponent_ChatSaveData.<>f__mg$cache8 = new LuaCSFunction(Lua_BlackJack_ProjectL_PlayerContext_ChatComponent_ChatSaveData.get_m_privateChatDataDict);
		}
		LuaCSFunction get5 = Lua_BlackJack_ProjectL_PlayerContext_ChatComponent_ChatSaveData.<>f__mg$cache8;
		if (Lua_BlackJack_ProjectL_PlayerContext_ChatComponent_ChatSaveData.<>f__mg$cache9 == null)
		{
			Lua_BlackJack_ProjectL_PlayerContext_ChatComponent_ChatSaveData.<>f__mg$cache9 = new LuaCSFunction(Lua_BlackJack_ProjectL_PlayerContext_ChatComponent_ChatSaveData.set_m_privateChatDataDict);
		}
		LuaObject.addMember(l, name5, get5, Lua_BlackJack_ProjectL_PlayerContext_ChatComponent_ChatSaveData.<>f__mg$cache9, true);
		string name6 = "m_groupChatDataDict";
		if (Lua_BlackJack_ProjectL_PlayerContext_ChatComponent_ChatSaveData.<>f__mg$cacheA == null)
		{
			Lua_BlackJack_ProjectL_PlayerContext_ChatComponent_ChatSaveData.<>f__mg$cacheA = new LuaCSFunction(Lua_BlackJack_ProjectL_PlayerContext_ChatComponent_ChatSaveData.get_m_groupChatDataDict);
		}
		LuaCSFunction get6 = Lua_BlackJack_ProjectL_PlayerContext_ChatComponent_ChatSaveData.<>f__mg$cacheA;
		if (Lua_BlackJack_ProjectL_PlayerContext_ChatComponent_ChatSaveData.<>f__mg$cacheB == null)
		{
			Lua_BlackJack_ProjectL_PlayerContext_ChatComponent_ChatSaveData.<>f__mg$cacheB = new LuaCSFunction(Lua_BlackJack_ProjectL_PlayerContext_ChatComponent_ChatSaveData.set_m_groupChatDataDict);
		}
		LuaObject.addMember(l, name6, get6, Lua_BlackJack_ProjectL_PlayerContext_ChatComponent_ChatSaveData.<>f__mg$cacheB, true);
		if (Lua_BlackJack_ProjectL_PlayerContext_ChatComponent_ChatSaveData.<>f__mg$cacheC == null)
		{
			Lua_BlackJack_ProjectL_PlayerContext_ChatComponent_ChatSaveData.<>f__mg$cacheC = new LuaCSFunction(Lua_BlackJack_ProjectL_PlayerContext_ChatComponent_ChatSaveData.constructor);
		}
		LuaObject.createTypeMetatable(l, Lua_BlackJack_ProjectL_PlayerContext_ChatComponent_ChatSaveData.<>f__mg$cacheC, typeof(ChatComponent.ChatSaveData));
	}

	// Token: 0x0400F7AA RID: 63402
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache0;

	// Token: 0x0400F7AB RID: 63403
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1;

	// Token: 0x0400F7AC RID: 63404
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2;

	// Token: 0x0400F7AD RID: 63405
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3;

	// Token: 0x0400F7AE RID: 63406
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache4;

	// Token: 0x0400F7AF RID: 63407
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache5;

	// Token: 0x0400F7B0 RID: 63408
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache6;

	// Token: 0x0400F7B1 RID: 63409
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache7;

	// Token: 0x0400F7B2 RID: 63410
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache8;

	// Token: 0x0400F7B3 RID: 63411
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache9;

	// Token: 0x0400F7B4 RID: 63412
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheA;

	// Token: 0x0400F7B5 RID: 63413
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheB;

	// Token: 0x0400F7B6 RID: 63414
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheC;
}
