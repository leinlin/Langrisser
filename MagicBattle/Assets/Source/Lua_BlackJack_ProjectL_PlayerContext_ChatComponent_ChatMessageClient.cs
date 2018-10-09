using System;
using System.Runtime.CompilerServices;
using BlackJack.ProjectL.Common;
using BlackJack.ProjectL.PlayerContext;
using SLua;
using UnityEngine.Scripting;

// Token: 0x020012B7 RID: 4791
[Preserve]
public class Lua_BlackJack_ProjectL_PlayerContext_ChatComponent_ChatMessageClient : LuaObject
{
	// Token: 0x0601932D RID: 103213 RVA: 0x0073558C File Offset: 0x0073378C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int constructor(IntPtr l)
	{
		int result;
		try
		{
			ChatMessage msgInfo;
			LuaObject.checkType<ChatMessage>(l, 2, out msgInfo);
			ChatComponent.ChatMessageClient o = new ChatComponent.ChatMessageClient(msgInfo);
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

	// Token: 0x0601932E RID: 103214 RVA: 0x007355E0 File Offset: 0x007337E0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_ChatMessageInfo(IntPtr l)
	{
		int result;
		try
		{
			ChatComponent.ChatMessageClient chatMessageClient = (ChatComponent.ChatMessageClient)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, chatMessageClient.ChatMessageInfo);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601932F RID: 103215 RVA: 0x00735634 File Offset: 0x00733834
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_ChatMessageInfo(IntPtr l)
	{
		int result;
		try
		{
			ChatComponent.ChatMessageClient chatMessageClient = (ChatComponent.ChatMessageClient)LuaObject.checkSelf(l);
			ChatMessage chatMessageInfo;
			LuaObject.checkType<ChatMessage>(l, 2, out chatMessageInfo);
			chatMessageClient.ChatMessageInfo = chatMessageInfo;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06019330 RID: 103216 RVA: 0x0073568C File Offset: 0x0073388C
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_isRead(IntPtr l)
	{
		int result;
		try
		{
			ChatComponent.ChatMessageClient chatMessageClient = (ChatComponent.ChatMessageClient)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, chatMessageClient.isRead);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06019331 RID: 103217 RVA: 0x007356E0 File Offset: 0x007338E0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_isRead(IntPtr l)
	{
		int result;
		try
		{
			ChatComponent.ChatMessageClient chatMessageClient = (ChatComponent.ChatMessageClient)LuaObject.checkSelf(l);
			bool isRead;
			LuaObject.checkType(l, 2, out isRead);
			chatMessageClient.isRead = isRead;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06019332 RID: 103218 RVA: 0x00735738 File Offset: 0x00733938
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_isHistoryRecord(IntPtr l)
	{
		int result;
		try
		{
			ChatComponent.ChatMessageClient chatMessageClient = (ChatComponent.ChatMessageClient)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, chatMessageClient.isHistoryRecord);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06019333 RID: 103219 RVA: 0x0073578C File Offset: 0x0073398C
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_isHistoryRecord(IntPtr l)
	{
		int result;
		try
		{
			ChatComponent.ChatMessageClient chatMessageClient = (ChatComponent.ChatMessageClient)LuaObject.checkSelf(l);
			bool isHistoryRecord;
			LuaObject.checkType(l, 2, out isHistoryRecord);
			chatMessageClient.isHistoryRecord = isHistoryRecord;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06019334 RID: 103220 RVA: 0x007357E4 File Offset: 0x007339E4
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_isLocalSystemTip(IntPtr l)
	{
		int result;
		try
		{
			ChatComponent.ChatMessageClient chatMessageClient = (ChatComponent.ChatMessageClient)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, chatMessageClient.isLocalSystemTip);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06019335 RID: 103221 RVA: 0x00735838 File Offset: 0x00733A38
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_isLocalSystemTip(IntPtr l)
	{
		int result;
		try
		{
			ChatComponent.ChatMessageClient chatMessageClient = (ChatComponent.ChatMessageClient)LuaObject.checkSelf(l);
			bool isLocalSystemTip;
			LuaObject.checkType(l, 2, out isLocalSystemTip);
			chatMessageClient.isLocalSystemTip = isLocalSystemTip;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06019336 RID: 103222 RVA: 0x00735890 File Offset: 0x00733A90
	[Preserve]
	public static void reg(IntPtr l)
	{
		LuaObject.getTypeTable(l, "BlackJack.ProjectL.PlayerContext.ChatComponent.ChatMessageClient");
		string name = "ChatMessageInfo";
		if (Lua_BlackJack_ProjectL_PlayerContext_ChatComponent_ChatMessageClient.<>f__mg$cache0 == null)
		{
			Lua_BlackJack_ProjectL_PlayerContext_ChatComponent_ChatMessageClient.<>f__mg$cache0 = new LuaCSFunction(Lua_BlackJack_ProjectL_PlayerContext_ChatComponent_ChatMessageClient.get_ChatMessageInfo);
		}
		LuaCSFunction get = Lua_BlackJack_ProjectL_PlayerContext_ChatComponent_ChatMessageClient.<>f__mg$cache0;
		if (Lua_BlackJack_ProjectL_PlayerContext_ChatComponent_ChatMessageClient.<>f__mg$cache1 == null)
		{
			Lua_BlackJack_ProjectL_PlayerContext_ChatComponent_ChatMessageClient.<>f__mg$cache1 = new LuaCSFunction(Lua_BlackJack_ProjectL_PlayerContext_ChatComponent_ChatMessageClient.set_ChatMessageInfo);
		}
		LuaObject.addMember(l, name, get, Lua_BlackJack_ProjectL_PlayerContext_ChatComponent_ChatMessageClient.<>f__mg$cache1, true);
		string name2 = "isRead";
		if (Lua_BlackJack_ProjectL_PlayerContext_ChatComponent_ChatMessageClient.<>f__mg$cache2 == null)
		{
			Lua_BlackJack_ProjectL_PlayerContext_ChatComponent_ChatMessageClient.<>f__mg$cache2 = new LuaCSFunction(Lua_BlackJack_ProjectL_PlayerContext_ChatComponent_ChatMessageClient.get_isRead);
		}
		LuaCSFunction get2 = Lua_BlackJack_ProjectL_PlayerContext_ChatComponent_ChatMessageClient.<>f__mg$cache2;
		if (Lua_BlackJack_ProjectL_PlayerContext_ChatComponent_ChatMessageClient.<>f__mg$cache3 == null)
		{
			Lua_BlackJack_ProjectL_PlayerContext_ChatComponent_ChatMessageClient.<>f__mg$cache3 = new LuaCSFunction(Lua_BlackJack_ProjectL_PlayerContext_ChatComponent_ChatMessageClient.set_isRead);
		}
		LuaObject.addMember(l, name2, get2, Lua_BlackJack_ProjectL_PlayerContext_ChatComponent_ChatMessageClient.<>f__mg$cache3, true);
		string name3 = "isHistoryRecord";
		if (Lua_BlackJack_ProjectL_PlayerContext_ChatComponent_ChatMessageClient.<>f__mg$cache4 == null)
		{
			Lua_BlackJack_ProjectL_PlayerContext_ChatComponent_ChatMessageClient.<>f__mg$cache4 = new LuaCSFunction(Lua_BlackJack_ProjectL_PlayerContext_ChatComponent_ChatMessageClient.get_isHistoryRecord);
		}
		LuaCSFunction get3 = Lua_BlackJack_ProjectL_PlayerContext_ChatComponent_ChatMessageClient.<>f__mg$cache4;
		if (Lua_BlackJack_ProjectL_PlayerContext_ChatComponent_ChatMessageClient.<>f__mg$cache5 == null)
		{
			Lua_BlackJack_ProjectL_PlayerContext_ChatComponent_ChatMessageClient.<>f__mg$cache5 = new LuaCSFunction(Lua_BlackJack_ProjectL_PlayerContext_ChatComponent_ChatMessageClient.set_isHistoryRecord);
		}
		LuaObject.addMember(l, name3, get3, Lua_BlackJack_ProjectL_PlayerContext_ChatComponent_ChatMessageClient.<>f__mg$cache5, true);
		string name4 = "isLocalSystemTip";
		if (Lua_BlackJack_ProjectL_PlayerContext_ChatComponent_ChatMessageClient.<>f__mg$cache6 == null)
		{
			Lua_BlackJack_ProjectL_PlayerContext_ChatComponent_ChatMessageClient.<>f__mg$cache6 = new LuaCSFunction(Lua_BlackJack_ProjectL_PlayerContext_ChatComponent_ChatMessageClient.get_isLocalSystemTip);
		}
		LuaCSFunction get4 = Lua_BlackJack_ProjectL_PlayerContext_ChatComponent_ChatMessageClient.<>f__mg$cache6;
		if (Lua_BlackJack_ProjectL_PlayerContext_ChatComponent_ChatMessageClient.<>f__mg$cache7 == null)
		{
			Lua_BlackJack_ProjectL_PlayerContext_ChatComponent_ChatMessageClient.<>f__mg$cache7 = new LuaCSFunction(Lua_BlackJack_ProjectL_PlayerContext_ChatComponent_ChatMessageClient.set_isLocalSystemTip);
		}
		LuaObject.addMember(l, name4, get4, Lua_BlackJack_ProjectL_PlayerContext_ChatComponent_ChatMessageClient.<>f__mg$cache7, true);
		if (Lua_BlackJack_ProjectL_PlayerContext_ChatComponent_ChatMessageClient.<>f__mg$cache8 == null)
		{
			Lua_BlackJack_ProjectL_PlayerContext_ChatComponent_ChatMessageClient.<>f__mg$cache8 = new LuaCSFunction(Lua_BlackJack_ProjectL_PlayerContext_ChatComponent_ChatMessageClient.constructor);
		}
		LuaObject.createTypeMetatable(l, Lua_BlackJack_ProjectL_PlayerContext_ChatComponent_ChatMessageClient.<>f__mg$cache8, typeof(ChatComponent.ChatMessageClient));
	}

	// Token: 0x0400F7A1 RID: 63393
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache0;

	// Token: 0x0400F7A2 RID: 63394
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1;

	// Token: 0x0400F7A3 RID: 63395
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2;

	// Token: 0x0400F7A4 RID: 63396
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3;

	// Token: 0x0400F7A5 RID: 63397
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache4;

	// Token: 0x0400F7A6 RID: 63398
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache5;

	// Token: 0x0400F7A7 RID: 63399
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache6;

	// Token: 0x0400F7A8 RID: 63400
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache7;

	// Token: 0x0400F7A9 RID: 63401
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache8;
}
