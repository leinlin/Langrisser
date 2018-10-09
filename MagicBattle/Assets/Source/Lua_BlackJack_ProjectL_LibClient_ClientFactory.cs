using System;
using System.IO;
using System.Runtime.CompilerServices;
using BlackJack.ProjectL.LibClient;
using SLua;
using UnityEngine.Scripting;

// Token: 0x02001299 RID: 4761
[Preserve]
public class Lua_BlackJack_ProjectL_LibClient_ClientFactory : LuaObject
{
	// Token: 0x06018FD8 RID: 102360 RVA: 0x0071BA78 File Offset: 0x00719C78
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int constructor(IntPtr l)
	{
		int result;
		try
		{
			ClientFactory o = new ClientFactory();
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

	// Token: 0x06018FD9 RID: 102361 RVA: 0x0071BAC0 File Offset: 0x00719CC0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int CreateClient_s(IntPtr l)
	{
		int result;
		try
		{
			IClientEventHandler handler;
			LuaObject.checkType<IClientEventHandler>(l, 1, out handler);
			Func<Stream, Type, int, object> deserializeMessageAction;
			LuaObject.checkDelegate<Func<Stream, Type, int, object>>(l, 2, out deserializeMessageAction);
			IClient o = ClientFactory.CreateClient(handler, deserializeMessageAction);
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

	// Token: 0x06018FDA RID: 102362 RVA: 0x0071BB20 File Offset: 0x00719D20
	[Preserve]
	public static void reg(IntPtr l)
	{
		LuaObject.getTypeTable(l, "BlackJack.ProjectL.LibClient.ClientFactory");
		if (Lua_BlackJack_ProjectL_LibClient_ClientFactory.<>f__mg$cache0 == null)
		{
			Lua_BlackJack_ProjectL_LibClient_ClientFactory.<>f__mg$cache0 = new LuaCSFunction(Lua_BlackJack_ProjectL_LibClient_ClientFactory.CreateClient_s);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_LibClient_ClientFactory.<>f__mg$cache0);
		if (Lua_BlackJack_ProjectL_LibClient_ClientFactory.<>f__mg$cache1 == null)
		{
			Lua_BlackJack_ProjectL_LibClient_ClientFactory.<>f__mg$cache1 = new LuaCSFunction(Lua_BlackJack_ProjectL_LibClient_ClientFactory.constructor);
		}
		LuaObject.createTypeMetatable(l, Lua_BlackJack_ProjectL_LibClient_ClientFactory.<>f__mg$cache1, typeof(ClientFactory));
	}

	// Token: 0x0400F488 RID: 62600
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache0;

	// Token: 0x0400F489 RID: 62601
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1;
}
