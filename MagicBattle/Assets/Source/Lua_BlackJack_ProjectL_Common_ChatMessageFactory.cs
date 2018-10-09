using System;
using System.Runtime.CompilerServices;
using BlackJack.ProjectL.Common;
using BlackJack.ProjectL.Protocol;
using SLua;
using UnityEngine.Scripting;

// Token: 0x020011E0 RID: 4576
[Preserve]
public class Lua_BlackJack_ProjectL_Common_ChatMessageFactory : LuaObject
{
	// Token: 0x06017BA2 RID: 97186 RVA: 0x00687450 File Offset: 0x00685650
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int constructor(IntPtr l)
	{
		int result;
		try
		{
			ChatMessageFactory o = new ChatMessageFactory();
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

	// Token: 0x06017BA3 RID: 97187 RVA: 0x00687498 File Offset: 0x00685698
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int CreateChatMessageByProtocol_s(IntPtr l)
	{
		int result;
		try
		{
			ChatMessageNtf chatMessage;
			LuaObject.checkType<ChatMessageNtf>(l, 1, out chatMessage);
			ChatMessage o = ChatMessageFactory.CreateChatMessageByProtocol(chatMessage);
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

	// Token: 0x06017BA4 RID: 97188 RVA: 0x006874EC File Offset: 0x006856EC
	[Preserve]
	public static void reg(IntPtr l)
	{
		LuaObject.getTypeTable(l, "BlackJack.ProjectL.Common.ChatMessageFactory");
		if (Lua_BlackJack_ProjectL_Common_ChatMessageFactory.<>f__mg$cache0 == null)
		{
			Lua_BlackJack_ProjectL_Common_ChatMessageFactory.<>f__mg$cache0 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_ChatMessageFactory.CreateChatMessageByProtocol_s);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_ChatMessageFactory.<>f__mg$cache0);
		if (Lua_BlackJack_ProjectL_Common_ChatMessageFactory.<>f__mg$cache1 == null)
		{
			Lua_BlackJack_ProjectL_Common_ChatMessageFactory.<>f__mg$cache1 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_ChatMessageFactory.constructor);
		}
		LuaObject.createTypeMetatable(l, Lua_BlackJack_ProjectL_Common_ChatMessageFactory.<>f__mg$cache1, typeof(ChatMessageFactory));
	}

	// Token: 0x0400E1C4 RID: 57796
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache0;

	// Token: 0x0400E1C5 RID: 57797
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1;
}
