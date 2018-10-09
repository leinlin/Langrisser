using System;
using System.Runtime.CompilerServices;
using BlackJack.ProjectL.LibClient;
using BlackJack.ProjectL.PlayerContext;
using SLua;
using UnityEngine.Scripting;

// Token: 0x020012D3 RID: 4819
[Preserve]
public class Lua_BlackJack_ProjectL_PlayerContext_NetWorkClient : LuaObject
{
	// Token: 0x060196FA RID: 104186 RVA: 0x007534E0 File Offset: 0x007516E0
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int constructor(IntPtr l)
	{
		int result;
		try
		{
			IClient realClient;
			LuaObject.checkType<IClient>(l, 2, out realClient);
			NetWorkClient o = new NetWorkClient(realClient);
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

	// Token: 0x060196FB RID: 104187 RVA: 0x00753534 File Offset: 0x00751734
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int LoginByAuthToken(IntPtr l)
	{
		int result;
		try
		{
			NetWorkClient netWorkClient = (NetWorkClient)LuaObject.checkSelf(l);
			string serverAddress;
			LuaObject.checkType(l, 2, out serverAddress);
			int serverPort;
			LuaObject.checkType(l, 3, out serverPort);
			string authToken;
			LuaObject.checkType(l, 4, out authToken);
			string clientVersion;
			LuaObject.checkType(l, 5, out clientVersion);
			string clientDeviceId;
			LuaObject.checkType(l, 6, out clientDeviceId);
			string localization;
			LuaObject.checkType(l, 7, out localization);
			int loginChannelId;
			LuaObject.checkType(l, 8, out loginChannelId);
			int bornChannelId;
			LuaObject.checkType(l, 9, out bornChannelId);
			bool b = netWorkClient.LoginByAuthToken(serverAddress, serverPort, authToken, clientVersion, clientDeviceId, localization, loginChannelId, bornChannelId);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, b);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060196FC RID: 104188 RVA: 0x007535F0 File Offset: 0x007517F0
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int LoginBySessionToken(IntPtr l)
	{
		int result;
		try
		{
			NetWorkClient netWorkClient = (NetWorkClient)LuaObject.checkSelf(l);
			string sessionToken;
			LuaObject.checkType(l, 2, out sessionToken);
			string clientVersion;
			LuaObject.checkType(l, 3, out clientVersion);
			string localization;
			LuaObject.checkType(l, 4, out localization);
			int loginChannelId;
			LuaObject.checkType(l, 5, out loginChannelId);
			int bornChannelId;
			LuaObject.checkType(l, 6, out bornChannelId);
			bool b = netWorkClient.LoginBySessionToken(sessionToken, clientVersion, localization, loginChannelId, bornChannelId);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, b);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060196FD RID: 104189 RVA: 0x00753684 File Offset: 0x00751884
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int Disconnect(IntPtr l)
	{
		int result;
		try
		{
			NetWorkClient netWorkClient = (NetWorkClient)LuaObject.checkSelf(l);
			bool b = netWorkClient.Disconnect();
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, b);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060196FE RID: 104190 RVA: 0x007536D8 File Offset: 0x007518D8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int SendMessage(IntPtr l)
	{
		int result;
		try
		{
			NetWorkClient netWorkClient = (NetWorkClient)LuaObject.checkSelf(l);
			object msg;
			LuaObject.checkType<object>(l, 2, out msg);
			bool b = netWorkClient.SendMessage(msg);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, b);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060196FF RID: 104191 RVA: 0x0075373C File Offset: 0x0075193C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int Tick(IntPtr l)
	{
		int result;
		try
		{
			NetWorkClient netWorkClient = (NetWorkClient)LuaObject.checkSelf(l);
			netWorkClient.Tick();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06019700 RID: 104192 RVA: 0x00753788 File Offset: 0x00751988
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int Close(IntPtr l)
	{
		int result;
		try
		{
			NetWorkClient netWorkClient = (NetWorkClient)LuaObject.checkSelf(l);
			netWorkClient.Close();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06019701 RID: 104193 RVA: 0x007537D4 File Offset: 0x007519D4
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int BlockProcessMsg(IntPtr l)
	{
		int result;
		try
		{
			NetWorkClient netWorkClient = (NetWorkClient)LuaObject.checkSelf(l);
			bool isBlock;
			LuaObject.checkType(l, 2, out isBlock);
			netWorkClient.BlockProcessMsg(isBlock);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06019702 RID: 104194 RVA: 0x0075382C File Offset: 0x00751A2C
	[Preserve]
	public static void reg(IntPtr l)
	{
		LuaObject.getTypeTable(l, "BlackJack.ProjectL.PlayerContext.NetWorkClient");
		if (Lua_BlackJack_ProjectL_PlayerContext_NetWorkClient.<>f__mg$cache0 == null)
		{
			Lua_BlackJack_ProjectL_PlayerContext_NetWorkClient.<>f__mg$cache0 = new LuaCSFunction(Lua_BlackJack_ProjectL_PlayerContext_NetWorkClient.LoginByAuthToken);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_PlayerContext_NetWorkClient.<>f__mg$cache0);
		if (Lua_BlackJack_ProjectL_PlayerContext_NetWorkClient.<>f__mg$cache1 == null)
		{
			Lua_BlackJack_ProjectL_PlayerContext_NetWorkClient.<>f__mg$cache1 = new LuaCSFunction(Lua_BlackJack_ProjectL_PlayerContext_NetWorkClient.LoginBySessionToken);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_PlayerContext_NetWorkClient.<>f__mg$cache1);
		if (Lua_BlackJack_ProjectL_PlayerContext_NetWorkClient.<>f__mg$cache2 == null)
		{
			Lua_BlackJack_ProjectL_PlayerContext_NetWorkClient.<>f__mg$cache2 = new LuaCSFunction(Lua_BlackJack_ProjectL_PlayerContext_NetWorkClient.Disconnect);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_PlayerContext_NetWorkClient.<>f__mg$cache2);
		if (Lua_BlackJack_ProjectL_PlayerContext_NetWorkClient.<>f__mg$cache3 == null)
		{
			Lua_BlackJack_ProjectL_PlayerContext_NetWorkClient.<>f__mg$cache3 = new LuaCSFunction(Lua_BlackJack_ProjectL_PlayerContext_NetWorkClient.SendMessage);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_PlayerContext_NetWorkClient.<>f__mg$cache3);
		if (Lua_BlackJack_ProjectL_PlayerContext_NetWorkClient.<>f__mg$cache4 == null)
		{
			Lua_BlackJack_ProjectL_PlayerContext_NetWorkClient.<>f__mg$cache4 = new LuaCSFunction(Lua_BlackJack_ProjectL_PlayerContext_NetWorkClient.Tick);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_PlayerContext_NetWorkClient.<>f__mg$cache4);
		if (Lua_BlackJack_ProjectL_PlayerContext_NetWorkClient.<>f__mg$cache5 == null)
		{
			Lua_BlackJack_ProjectL_PlayerContext_NetWorkClient.<>f__mg$cache5 = new LuaCSFunction(Lua_BlackJack_ProjectL_PlayerContext_NetWorkClient.Close);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_PlayerContext_NetWorkClient.<>f__mg$cache5);
		if (Lua_BlackJack_ProjectL_PlayerContext_NetWorkClient.<>f__mg$cache6 == null)
		{
			Lua_BlackJack_ProjectL_PlayerContext_NetWorkClient.<>f__mg$cache6 = new LuaCSFunction(Lua_BlackJack_ProjectL_PlayerContext_NetWorkClient.BlockProcessMsg);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_PlayerContext_NetWorkClient.<>f__mg$cache6);
		if (Lua_BlackJack_ProjectL_PlayerContext_NetWorkClient.<>f__mg$cache7 == null)
		{
			Lua_BlackJack_ProjectL_PlayerContext_NetWorkClient.<>f__mg$cache7 = new LuaCSFunction(Lua_BlackJack_ProjectL_PlayerContext_NetWorkClient.constructor);
		}
		LuaObject.createTypeMetatable(l, Lua_BlackJack_ProjectL_PlayerContext_NetWorkClient.<>f__mg$cache7, typeof(NetWorkClient));
	}

	// Token: 0x0400FB36 RID: 64310
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache0;

	// Token: 0x0400FB37 RID: 64311
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1;

	// Token: 0x0400FB38 RID: 64312
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2;

	// Token: 0x0400FB39 RID: 64313
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3;

	// Token: 0x0400FB3A RID: 64314
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache4;

	// Token: 0x0400FB3B RID: 64315
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache5;

	// Token: 0x0400FB3C RID: 64316
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache6;

	// Token: 0x0400FB3D RID: 64317
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache7;
}
