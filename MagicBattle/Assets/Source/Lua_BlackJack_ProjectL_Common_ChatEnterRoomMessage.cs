using System;
using System.Runtime.CompilerServices;
using BlackJack.ProjectL.Common;
using SLua;
using UnityEngine.Scripting;

// Token: 0x020011DD RID: 4573
[Preserve]
public class Lua_BlackJack_ProjectL_Common_ChatEnterRoomMessage : LuaObject
{
	// Token: 0x06017B78 RID: 97144 RVA: 0x00686310 File Offset: 0x00684510
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int constructor(IntPtr l)
	{
		int result;
		try
		{
			ChatEnterRoomMessage o = new ChatEnterRoomMessage();
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

	// Token: 0x06017B79 RID: 97145 RVA: 0x00686358 File Offset: 0x00684558
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_RoomId(IntPtr l)
	{
		int result;
		try
		{
			ChatEnterRoomMessage chatEnterRoomMessage = (ChatEnterRoomMessage)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, chatEnterRoomMessage.RoomId);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06017B7A RID: 97146 RVA: 0x006863AC File Offset: 0x006845AC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_RoomId(IntPtr l)
	{
		int result;
		try
		{
			ChatEnterRoomMessage chatEnterRoomMessage = (ChatEnterRoomMessage)LuaObject.checkSelf(l);
			int roomId;
			LuaObject.checkType(l, 2, out roomId);
			chatEnterRoomMessage.RoomId = roomId;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06017B7B RID: 97147 RVA: 0x00686404 File Offset: 0x00684604
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_PlayerCount(IntPtr l)
	{
		int result;
		try
		{
			ChatEnterRoomMessage chatEnterRoomMessage = (ChatEnterRoomMessage)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, chatEnterRoomMessage.PlayerCount);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06017B7C RID: 97148 RVA: 0x00686458 File Offset: 0x00684658
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_PlayerCount(IntPtr l)
	{
		int result;
		try
		{
			ChatEnterRoomMessage chatEnterRoomMessage = (ChatEnterRoomMessage)LuaObject.checkSelf(l);
			int playerCount;
			LuaObject.checkType(l, 2, out playerCount);
			chatEnterRoomMessage.PlayerCount = playerCount;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06017B7D RID: 97149 RVA: 0x006864B0 File Offset: 0x006846B0
	[Preserve]
	public static void reg(IntPtr l)
	{
		LuaObject.getTypeTable(l, "BlackJack.ProjectL.Common.ChatEnterRoomMessage");
		string name = "RoomId";
		if (Lua_BlackJack_ProjectL_Common_ChatEnterRoomMessage.<>f__mg$cache0 == null)
		{
			Lua_BlackJack_ProjectL_Common_ChatEnterRoomMessage.<>f__mg$cache0 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_ChatEnterRoomMessage.get_RoomId);
		}
		LuaCSFunction get = Lua_BlackJack_ProjectL_Common_ChatEnterRoomMessage.<>f__mg$cache0;
		if (Lua_BlackJack_ProjectL_Common_ChatEnterRoomMessage.<>f__mg$cache1 == null)
		{
			Lua_BlackJack_ProjectL_Common_ChatEnterRoomMessage.<>f__mg$cache1 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_ChatEnterRoomMessage.set_RoomId);
		}
		LuaObject.addMember(l, name, get, Lua_BlackJack_ProjectL_Common_ChatEnterRoomMessage.<>f__mg$cache1, true);
		string name2 = "PlayerCount";
		if (Lua_BlackJack_ProjectL_Common_ChatEnterRoomMessage.<>f__mg$cache2 == null)
		{
			Lua_BlackJack_ProjectL_Common_ChatEnterRoomMessage.<>f__mg$cache2 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_ChatEnterRoomMessage.get_PlayerCount);
		}
		LuaCSFunction get2 = Lua_BlackJack_ProjectL_Common_ChatEnterRoomMessage.<>f__mg$cache2;
		if (Lua_BlackJack_ProjectL_Common_ChatEnterRoomMessage.<>f__mg$cache3 == null)
		{
			Lua_BlackJack_ProjectL_Common_ChatEnterRoomMessage.<>f__mg$cache3 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_ChatEnterRoomMessage.set_PlayerCount);
		}
		LuaObject.addMember(l, name2, get2, Lua_BlackJack_ProjectL_Common_ChatEnterRoomMessage.<>f__mg$cache3, true);
		if (Lua_BlackJack_ProjectL_Common_ChatEnterRoomMessage.<>f__mg$cache4 == null)
		{
			Lua_BlackJack_ProjectL_Common_ChatEnterRoomMessage.<>f__mg$cache4 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_ChatEnterRoomMessage.constructor);
		}
		LuaObject.createTypeMetatable(l, Lua_BlackJack_ProjectL_Common_ChatEnterRoomMessage.<>f__mg$cache4, typeof(ChatEnterRoomMessage), typeof(ChatMessage));
	}

	// Token: 0x0400E1A0 RID: 57760
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache0;

	// Token: 0x0400E1A1 RID: 57761
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1;

	// Token: 0x0400E1A2 RID: 57762
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2;

	// Token: 0x0400E1A3 RID: 57763
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3;

	// Token: 0x0400E1A4 RID: 57764
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache4;
}
