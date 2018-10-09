using System;
using System.Runtime.CompilerServices;
using BlackJack.ProjectL.Common;
using BlackJack.ProjectL.Protocol;
using SLua;
using UnityEngine.Scripting;

// Token: 0x020011DF RID: 4575
[Preserve]
public class Lua_BlackJack_ProjectL_Common_ChatMessage : LuaObject
{
	// Token: 0x06017B8A RID: 97162 RVA: 0x006869CC File Offset: 0x00684BCC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int constructor(IntPtr l)
	{
		int result;
		try
		{
			ChatMessage o = new ChatMessage();
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

	// Token: 0x06017B8B RID: 97163 RVA: 0x00686A14 File Offset: 0x00684C14
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int ToPbChatMessage(IntPtr l)
	{
		int result;
		try
		{
			ChatMessage chatMessage = (ChatMessage)LuaObject.checkSelf(l);
			ChatMessageNtf o = chatMessage.ToPbChatMessage();
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

	// Token: 0x06017B8C RID: 97164 RVA: 0x00686A68 File Offset: 0x00684C68
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_ChannelId(IntPtr l)
	{
		int result;
		try
		{
			ChatMessage chatMessage = (ChatMessage)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushEnum(l, (int)chatMessage.ChannelId);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06017B8D RID: 97165 RVA: 0x00686ABC File Offset: 0x00684CBC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_ChannelId(IntPtr l)
	{
		int result;
		try
		{
			ChatMessage chatMessage = (ChatMessage)LuaObject.checkSelf(l);
			ChatChannel channelId;
			LuaObject.checkEnum<ChatChannel>(l, 2, out channelId);
			chatMessage.ChannelId = channelId;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06017B8E RID: 97166 RVA: 0x00686B14 File Offset: 0x00684D14
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_ChatSrcType(IntPtr l)
	{
		int result;
		try
		{
			ChatMessage chatMessage = (ChatMessage)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushEnum(l, (int)chatMessage.ChatSrcType);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06017B8F RID: 97167 RVA: 0x00686B68 File Offset: 0x00684D68
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_ChatSrcType(IntPtr l)
	{
		int result;
		try
		{
			ChatMessage chatMessage = (ChatMessage)LuaObject.checkSelf(l);
			ChatSrcType chatSrcType;
			LuaObject.checkEnum<ChatSrcType>(l, 2, out chatSrcType);
			chatMessage.ChatSrcType = chatSrcType;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06017B90 RID: 97168 RVA: 0x00686BC0 File Offset: 0x00684DC0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_SrcName(IntPtr l)
	{
		int result;
		try
		{
			ChatMessage chatMessage = (ChatMessage)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, chatMessage.SrcName);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06017B91 RID: 97169 RVA: 0x00686C14 File Offset: 0x00684E14
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_SrcName(IntPtr l)
	{
		int result;
		try
		{
			ChatMessage chatMessage = (ChatMessage)LuaObject.checkSelf(l);
			string srcName;
			LuaObject.checkType(l, 2, out srcName);
			chatMessage.SrcName = srcName;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06017B92 RID: 97170 RVA: 0x00686C6C File Offset: 0x00684E6C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_AvatarId(IntPtr l)
	{
		int result;
		try
		{
			ChatMessage chatMessage = (ChatMessage)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, chatMessage.AvatarId);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06017B93 RID: 97171 RVA: 0x00686CC0 File Offset: 0x00684EC0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_AvatarId(IntPtr l)
	{
		int result;
		try
		{
			ChatMessage chatMessage = (ChatMessage)LuaObject.checkSelf(l);
			int avatarId;
			LuaObject.checkType(l, 2, out avatarId);
			chatMessage.AvatarId = avatarId;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06017B94 RID: 97172 RVA: 0x00686D18 File Offset: 0x00684F18
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_ChatContentType(IntPtr l)
	{
		int result;
		try
		{
			ChatMessage chatMessage = (ChatMessage)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushEnum(l, (int)chatMessage.ChatContentType);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06017B95 RID: 97173 RVA: 0x00686D6C File Offset: 0x00684F6C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_ChatContentType(IntPtr l)
	{
		int result;
		try
		{
			ChatMessage chatMessage = (ChatMessage)LuaObject.checkSelf(l);
			ChatContentType chatContentType;
			LuaObject.checkEnum<ChatContentType>(l, 2, out chatContentType);
			chatMessage.ChatContentType = chatContentType;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06017B96 RID: 97174 RVA: 0x00686DC4 File Offset: 0x00684FC4
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_SrcPlayerLevel(IntPtr l)
	{
		int result;
		try
		{
			ChatMessage chatMessage = (ChatMessage)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, chatMessage.SrcPlayerLevel);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06017B97 RID: 97175 RVA: 0x00686E18 File Offset: 0x00685018
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_SrcPlayerLevel(IntPtr l)
	{
		int result;
		try
		{
			ChatMessage chatMessage = (ChatMessage)LuaObject.checkSelf(l);
			int srcPlayerLevel;
			LuaObject.checkType(l, 2, out srcPlayerLevel);
			chatMessage.SrcPlayerLevel = srcPlayerLevel;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06017B98 RID: 97176 RVA: 0x00686E70 File Offset: 0x00685070
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_SrcGameUserID(IntPtr l)
	{
		int result;
		try
		{
			ChatMessage chatMessage = (ChatMessage)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, chatMessage.SrcGameUserID);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06017B99 RID: 97177 RVA: 0x00686EC4 File Offset: 0x006850C4
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_SrcGameUserID(IntPtr l)
	{
		int result;
		try
		{
			ChatMessage chatMessage = (ChatMessage)LuaObject.checkSelf(l);
			string srcGameUserID;
			LuaObject.checkType(l, 2, out srcGameUserID);
			chatMessage.SrcGameUserID = srcGameUserID;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06017B9A RID: 97178 RVA: 0x00686F1C File Offset: 0x0068511C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_SendTime(IntPtr l)
	{
		int result;
		try
		{
			ChatMessage chatMessage = (ChatMessage)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, chatMessage.SendTime);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06017B9B RID: 97179 RVA: 0x00686F74 File Offset: 0x00685174
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_SendTime(IntPtr l)
	{
		int result;
		try
		{
			ChatMessage chatMessage = (ChatMessage)LuaObject.checkSelf(l);
			DateTime sendTime;
			LuaObject.checkValueType<DateTime>(l, 2, out sendTime);
			chatMessage.SendTime = sendTime;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06017B9C RID: 97180 RVA: 0x00686FCC File Offset: 0x006851CC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_DestGameUserId(IntPtr l)
	{
		int result;
		try
		{
			ChatMessage chatMessage = (ChatMessage)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, chatMessage.DestGameUserId);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06017B9D RID: 97181 RVA: 0x00687020 File Offset: 0x00685220
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_DestGameUserId(IntPtr l)
	{
		int result;
		try
		{
			ChatMessage chatMessage = (ChatMessage)LuaObject.checkSelf(l);
			string destGameUserId;
			LuaObject.checkType(l, 2, out destGameUserId);
			chatMessage.DestGameUserId = destGameUserId;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06017B9E RID: 97182 RVA: 0x00687078 File Offset: 0x00685278
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_DestChatGroupId(IntPtr l)
	{
		int result;
		try
		{
			ChatMessage chatMessage = (ChatMessage)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, chatMessage.DestChatGroupId);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06017B9F RID: 97183 RVA: 0x006870CC File Offset: 0x006852CC
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_DestChatGroupId(IntPtr l)
	{
		int result;
		try
		{
			ChatMessage chatMessage = (ChatMessage)LuaObject.checkSelf(l);
			string destChatGroupId;
			LuaObject.checkType(l, 2, out destChatGroupId);
			chatMessage.DestChatGroupId = destChatGroupId;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06017BA0 RID: 97184 RVA: 0x00687124 File Offset: 0x00685324
	[Preserve]
	public static void reg(IntPtr l)
	{
		LuaObject.getTypeTable(l, "BlackJack.ProjectL.Common.ChatMessage");
		if (Lua_BlackJack_ProjectL_Common_ChatMessage.<>f__mg$cache0 == null)
		{
			Lua_BlackJack_ProjectL_Common_ChatMessage.<>f__mg$cache0 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_ChatMessage.ToPbChatMessage);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_ChatMessage.<>f__mg$cache0);
		string name = "ChannelId";
		if (Lua_BlackJack_ProjectL_Common_ChatMessage.<>f__mg$cache1 == null)
		{
			Lua_BlackJack_ProjectL_Common_ChatMessage.<>f__mg$cache1 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_ChatMessage.get_ChannelId);
		}
		LuaCSFunction get = Lua_BlackJack_ProjectL_Common_ChatMessage.<>f__mg$cache1;
		if (Lua_BlackJack_ProjectL_Common_ChatMessage.<>f__mg$cache2 == null)
		{
			Lua_BlackJack_ProjectL_Common_ChatMessage.<>f__mg$cache2 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_ChatMessage.set_ChannelId);
		}
		LuaObject.addMember(l, name, get, Lua_BlackJack_ProjectL_Common_ChatMessage.<>f__mg$cache2, true);
		string name2 = "ChatSrcType";
		if (Lua_BlackJack_ProjectL_Common_ChatMessage.<>f__mg$cache3 == null)
		{
			Lua_BlackJack_ProjectL_Common_ChatMessage.<>f__mg$cache3 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_ChatMessage.get_ChatSrcType);
		}
		LuaCSFunction get2 = Lua_BlackJack_ProjectL_Common_ChatMessage.<>f__mg$cache3;
		if (Lua_BlackJack_ProjectL_Common_ChatMessage.<>f__mg$cache4 == null)
		{
			Lua_BlackJack_ProjectL_Common_ChatMessage.<>f__mg$cache4 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_ChatMessage.set_ChatSrcType);
		}
		LuaObject.addMember(l, name2, get2, Lua_BlackJack_ProjectL_Common_ChatMessage.<>f__mg$cache4, true);
		string name3 = "SrcName";
		if (Lua_BlackJack_ProjectL_Common_ChatMessage.<>f__mg$cache5 == null)
		{
			Lua_BlackJack_ProjectL_Common_ChatMessage.<>f__mg$cache5 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_ChatMessage.get_SrcName);
		}
		LuaCSFunction get3 = Lua_BlackJack_ProjectL_Common_ChatMessage.<>f__mg$cache5;
		if (Lua_BlackJack_ProjectL_Common_ChatMessage.<>f__mg$cache6 == null)
		{
			Lua_BlackJack_ProjectL_Common_ChatMessage.<>f__mg$cache6 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_ChatMessage.set_SrcName);
		}
		LuaObject.addMember(l, name3, get3, Lua_BlackJack_ProjectL_Common_ChatMessage.<>f__mg$cache6, true);
		string name4 = "AvatarId";
		if (Lua_BlackJack_ProjectL_Common_ChatMessage.<>f__mg$cache7 == null)
		{
			Lua_BlackJack_ProjectL_Common_ChatMessage.<>f__mg$cache7 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_ChatMessage.get_AvatarId);
		}
		LuaCSFunction get4 = Lua_BlackJack_ProjectL_Common_ChatMessage.<>f__mg$cache7;
		if (Lua_BlackJack_ProjectL_Common_ChatMessage.<>f__mg$cache8 == null)
		{
			Lua_BlackJack_ProjectL_Common_ChatMessage.<>f__mg$cache8 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_ChatMessage.set_AvatarId);
		}
		LuaObject.addMember(l, name4, get4, Lua_BlackJack_ProjectL_Common_ChatMessage.<>f__mg$cache8, true);
		string name5 = "ChatContentType";
		if (Lua_BlackJack_ProjectL_Common_ChatMessage.<>f__mg$cache9 == null)
		{
			Lua_BlackJack_ProjectL_Common_ChatMessage.<>f__mg$cache9 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_ChatMessage.get_ChatContentType);
		}
		LuaCSFunction get5 = Lua_BlackJack_ProjectL_Common_ChatMessage.<>f__mg$cache9;
		if (Lua_BlackJack_ProjectL_Common_ChatMessage.<>f__mg$cacheA == null)
		{
			Lua_BlackJack_ProjectL_Common_ChatMessage.<>f__mg$cacheA = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_ChatMessage.set_ChatContentType);
		}
		LuaObject.addMember(l, name5, get5, Lua_BlackJack_ProjectL_Common_ChatMessage.<>f__mg$cacheA, true);
		string name6 = "SrcPlayerLevel";
		if (Lua_BlackJack_ProjectL_Common_ChatMessage.<>f__mg$cacheB == null)
		{
			Lua_BlackJack_ProjectL_Common_ChatMessage.<>f__mg$cacheB = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_ChatMessage.get_SrcPlayerLevel);
		}
		LuaCSFunction get6 = Lua_BlackJack_ProjectL_Common_ChatMessage.<>f__mg$cacheB;
		if (Lua_BlackJack_ProjectL_Common_ChatMessage.<>f__mg$cacheC == null)
		{
			Lua_BlackJack_ProjectL_Common_ChatMessage.<>f__mg$cacheC = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_ChatMessage.set_SrcPlayerLevel);
		}
		LuaObject.addMember(l, name6, get6, Lua_BlackJack_ProjectL_Common_ChatMessage.<>f__mg$cacheC, true);
		string name7 = "SrcGameUserID";
		if (Lua_BlackJack_ProjectL_Common_ChatMessage.<>f__mg$cacheD == null)
		{
			Lua_BlackJack_ProjectL_Common_ChatMessage.<>f__mg$cacheD = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_ChatMessage.get_SrcGameUserID);
		}
		LuaCSFunction get7 = Lua_BlackJack_ProjectL_Common_ChatMessage.<>f__mg$cacheD;
		if (Lua_BlackJack_ProjectL_Common_ChatMessage.<>f__mg$cacheE == null)
		{
			Lua_BlackJack_ProjectL_Common_ChatMessage.<>f__mg$cacheE = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_ChatMessage.set_SrcGameUserID);
		}
		LuaObject.addMember(l, name7, get7, Lua_BlackJack_ProjectL_Common_ChatMessage.<>f__mg$cacheE, true);
		string name8 = "SendTime";
		if (Lua_BlackJack_ProjectL_Common_ChatMessage.<>f__mg$cacheF == null)
		{
			Lua_BlackJack_ProjectL_Common_ChatMessage.<>f__mg$cacheF = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_ChatMessage.get_SendTime);
		}
		LuaCSFunction get8 = Lua_BlackJack_ProjectL_Common_ChatMessage.<>f__mg$cacheF;
		if (Lua_BlackJack_ProjectL_Common_ChatMessage.<>f__mg$cache10 == null)
		{
			Lua_BlackJack_ProjectL_Common_ChatMessage.<>f__mg$cache10 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_ChatMessage.set_SendTime);
		}
		LuaObject.addMember(l, name8, get8, Lua_BlackJack_ProjectL_Common_ChatMessage.<>f__mg$cache10, true);
		string name9 = "DestGameUserId";
		if (Lua_BlackJack_ProjectL_Common_ChatMessage.<>f__mg$cache11 == null)
		{
			Lua_BlackJack_ProjectL_Common_ChatMessage.<>f__mg$cache11 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_ChatMessage.get_DestGameUserId);
		}
		LuaCSFunction get9 = Lua_BlackJack_ProjectL_Common_ChatMessage.<>f__mg$cache11;
		if (Lua_BlackJack_ProjectL_Common_ChatMessage.<>f__mg$cache12 == null)
		{
			Lua_BlackJack_ProjectL_Common_ChatMessage.<>f__mg$cache12 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_ChatMessage.set_DestGameUserId);
		}
		LuaObject.addMember(l, name9, get9, Lua_BlackJack_ProjectL_Common_ChatMessage.<>f__mg$cache12, true);
		string name10 = "DestChatGroupId";
		if (Lua_BlackJack_ProjectL_Common_ChatMessage.<>f__mg$cache13 == null)
		{
			Lua_BlackJack_ProjectL_Common_ChatMessage.<>f__mg$cache13 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_ChatMessage.get_DestChatGroupId);
		}
		LuaCSFunction get10 = Lua_BlackJack_ProjectL_Common_ChatMessage.<>f__mg$cache13;
		if (Lua_BlackJack_ProjectL_Common_ChatMessage.<>f__mg$cache14 == null)
		{
			Lua_BlackJack_ProjectL_Common_ChatMessage.<>f__mg$cache14 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_ChatMessage.set_DestChatGroupId);
		}
		LuaObject.addMember(l, name10, get10, Lua_BlackJack_ProjectL_Common_ChatMessage.<>f__mg$cache14, true);
		if (Lua_BlackJack_ProjectL_Common_ChatMessage.<>f__mg$cache15 == null)
		{
			Lua_BlackJack_ProjectL_Common_ChatMessage.<>f__mg$cache15 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_ChatMessage.constructor);
		}
		LuaObject.createTypeMetatable(l, Lua_BlackJack_ProjectL_Common_ChatMessage.<>f__mg$cache15, typeof(ChatMessage));
	}

	// Token: 0x0400E1AE RID: 57774
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache0;

	// Token: 0x0400E1AF RID: 57775
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1;

	// Token: 0x0400E1B0 RID: 57776
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2;

	// Token: 0x0400E1B1 RID: 57777
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3;

	// Token: 0x0400E1B2 RID: 57778
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache4;

	// Token: 0x0400E1B3 RID: 57779
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache5;

	// Token: 0x0400E1B4 RID: 57780
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache6;

	// Token: 0x0400E1B5 RID: 57781
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache7;

	// Token: 0x0400E1B6 RID: 57782
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache8;

	// Token: 0x0400E1B7 RID: 57783
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache9;

	// Token: 0x0400E1B8 RID: 57784
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheA;

	// Token: 0x0400E1B9 RID: 57785
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheB;

	// Token: 0x0400E1BA RID: 57786
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheC;

	// Token: 0x0400E1BB RID: 57787
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheD;

	// Token: 0x0400E1BC RID: 57788
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheE;

	// Token: 0x0400E1BD RID: 57789
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheF;

	// Token: 0x0400E1BE RID: 57790
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache10;

	// Token: 0x0400E1BF RID: 57791
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache11;

	// Token: 0x0400E1C0 RID: 57792
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache12;

	// Token: 0x0400E1C1 RID: 57793
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache13;

	// Token: 0x0400E1C2 RID: 57794
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache14;

	// Token: 0x0400E1C3 RID: 57795
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache15;
}
