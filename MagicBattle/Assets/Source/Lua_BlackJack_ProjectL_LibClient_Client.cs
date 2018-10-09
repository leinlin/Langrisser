using System;
using System.IO;
using System.Runtime.CompilerServices;
using BlackJack.ProjectL.LibClient;
using SLua;
using UnityEngine.Scripting;

// Token: 0x02001298 RID: 4760
[Preserve]
public class Lua_BlackJack_ProjectL_LibClient_Client : LuaObject
{
	// Token: 0x06018FCA RID: 102346 RVA: 0x0071B404 File Offset: 0x00719604
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int constructor(IntPtr l)
	{
		int result;
		try
		{
			IClientEventHandler handler;
			LuaObject.checkType<IClientEventHandler>(l, 2, out handler);
			Func<Stream, Type, int, object> deserializeMessageAction;
			LuaObject.checkDelegate<Func<Stream, Type, int, object>>(l, 3, out deserializeMessageAction);
			Client o = new Client(handler, deserializeMessageAction);
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

	// Token: 0x06018FCB RID: 102347 RVA: 0x0071B464 File Offset: 0x00719664
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int SetClientToInit(IntPtr l)
	{
		int result;
		try
		{
			Client client = (Client)LuaObject.checkSelf(l);
			client.SetClientToInit();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06018FCC RID: 102348 RVA: 0x0071B4B0 File Offset: 0x007196B0
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int BlockProcessMsg(IntPtr l)
	{
		int result;
		try
		{
			Client client = (Client)LuaObject.checkSelf(l);
			bool isBlock;
			LuaObject.checkType(l, 2, out isBlock);
			client.BlockProcessMsg(isBlock);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06018FCD RID: 102349 RVA: 0x0071B508 File Offset: 0x00719708
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int LoginByAuthToken(IntPtr l)
	{
		int result;
		try
		{
			Client client = (Client)LuaObject.checkSelf(l);
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
			bool b = client.LoginByAuthToken(serverAddress, serverPort, authToken, clientVersion, clientDeviceId, localization, loginChannelId, bornChannelId);
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

	// Token: 0x06018FCE RID: 102350 RVA: 0x0071B5C4 File Offset: 0x007197C4
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int LoginBySessionToken(IntPtr l)
	{
		int result;
		try
		{
			Client client = (Client)LuaObject.checkSelf(l);
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
			bool b = client.LoginBySessionToken(sessionToken, clientVersion, localization, loginChannelId, bornChannelId);
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

	// Token: 0x06018FCF RID: 102351 RVA: 0x0071B658 File Offset: 0x00719858
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int Disconnect(IntPtr l)
	{
		int result;
		try
		{
			Client client = (Client)LuaObject.checkSelf(l);
			bool b = client.Disconnect();
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

	// Token: 0x06018FD0 RID: 102352 RVA: 0x0071B6AC File Offset: 0x007198AC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int Close(IntPtr l)
	{
		int result;
		try
		{
			Client client = (Client)LuaObject.checkSelf(l);
			client.Close();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06018FD1 RID: 102353 RVA: 0x0071B6F8 File Offset: 0x007198F8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int SendMessage(IntPtr l)
	{
		int result;
		try
		{
			Client client = (Client)LuaObject.checkSelf(l);
			object msg;
			LuaObject.checkType<object>(l, 2, out msg);
			bool b = client.SendMessage(msg);
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

	// Token: 0x06018FD2 RID: 102354 RVA: 0x0071B75C File Offset: 0x0071995C
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int Tick(IntPtr l)
	{
		int result;
		try
		{
			Client client = (Client)LuaObject.checkSelf(l);
			client.Tick();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06018FD3 RID: 102355 RVA: 0x0071B7A8 File Offset: 0x007199A8
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int GetEndPoint(IntPtr l)
	{
		int result;
		try
		{
			Client client = (Client)LuaObject.checkSelf(l);
			int endPoint = client.GetEndPoint();
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, endPoint);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06018FD4 RID: 102356 RVA: 0x0071B7FC File Offset: 0x007199FC
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int RegConnectionLogEvent(IntPtr l)
	{
		int result;
		try
		{
			Client client = (Client)LuaObject.checkSelf(l);
			Action<string> logEvent;
			LuaObject.checkDelegate<Action<string>>(l, 2, out logEvent);
			client.RegConnectionLogEvent(logEvent);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06018FD5 RID: 102357 RVA: 0x0071B854 File Offset: 0x00719A54
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int GetIp(IntPtr l)
	{
		int result;
		try
		{
			Client client = (Client)LuaObject.checkSelf(l);
			string ip = client.GetIp();
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, ip);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06018FD6 RID: 102358 RVA: 0x0071B8A8 File Offset: 0x00719AA8
	[Preserve]
	public static void reg(IntPtr l)
	{
		LuaObject.getTypeTable(l, "BlackJack.ProjectL.LibClient.Client");
		if (Lua_BlackJack_ProjectL_LibClient_Client.<>f__mg$cache0 == null)
		{
			Lua_BlackJack_ProjectL_LibClient_Client.<>f__mg$cache0 = new LuaCSFunction(Lua_BlackJack_ProjectL_LibClient_Client.SetClientToInit);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_LibClient_Client.<>f__mg$cache0);
		if (Lua_BlackJack_ProjectL_LibClient_Client.<>f__mg$cache1 == null)
		{
			Lua_BlackJack_ProjectL_LibClient_Client.<>f__mg$cache1 = new LuaCSFunction(Lua_BlackJack_ProjectL_LibClient_Client.BlockProcessMsg);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_LibClient_Client.<>f__mg$cache1);
		if (Lua_BlackJack_ProjectL_LibClient_Client.<>f__mg$cache2 == null)
		{
			Lua_BlackJack_ProjectL_LibClient_Client.<>f__mg$cache2 = new LuaCSFunction(Lua_BlackJack_ProjectL_LibClient_Client.LoginByAuthToken);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_LibClient_Client.<>f__mg$cache2);
		if (Lua_BlackJack_ProjectL_LibClient_Client.<>f__mg$cache3 == null)
		{
			Lua_BlackJack_ProjectL_LibClient_Client.<>f__mg$cache3 = new LuaCSFunction(Lua_BlackJack_ProjectL_LibClient_Client.LoginBySessionToken);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_LibClient_Client.<>f__mg$cache3);
		if (Lua_BlackJack_ProjectL_LibClient_Client.<>f__mg$cache4 == null)
		{
			Lua_BlackJack_ProjectL_LibClient_Client.<>f__mg$cache4 = new LuaCSFunction(Lua_BlackJack_ProjectL_LibClient_Client.Disconnect);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_LibClient_Client.<>f__mg$cache4);
		if (Lua_BlackJack_ProjectL_LibClient_Client.<>f__mg$cache5 == null)
		{
			Lua_BlackJack_ProjectL_LibClient_Client.<>f__mg$cache5 = new LuaCSFunction(Lua_BlackJack_ProjectL_LibClient_Client.Close);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_LibClient_Client.<>f__mg$cache5);
		if (Lua_BlackJack_ProjectL_LibClient_Client.<>f__mg$cache6 == null)
		{
			Lua_BlackJack_ProjectL_LibClient_Client.<>f__mg$cache6 = new LuaCSFunction(Lua_BlackJack_ProjectL_LibClient_Client.SendMessage);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_LibClient_Client.<>f__mg$cache6);
		if (Lua_BlackJack_ProjectL_LibClient_Client.<>f__mg$cache7 == null)
		{
			Lua_BlackJack_ProjectL_LibClient_Client.<>f__mg$cache7 = new LuaCSFunction(Lua_BlackJack_ProjectL_LibClient_Client.Tick);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_LibClient_Client.<>f__mg$cache7);
		if (Lua_BlackJack_ProjectL_LibClient_Client.<>f__mg$cache8 == null)
		{
			Lua_BlackJack_ProjectL_LibClient_Client.<>f__mg$cache8 = new LuaCSFunction(Lua_BlackJack_ProjectL_LibClient_Client.GetEndPoint);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_LibClient_Client.<>f__mg$cache8);
		if (Lua_BlackJack_ProjectL_LibClient_Client.<>f__mg$cache9 == null)
		{
			Lua_BlackJack_ProjectL_LibClient_Client.<>f__mg$cache9 = new LuaCSFunction(Lua_BlackJack_ProjectL_LibClient_Client.RegConnectionLogEvent);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_LibClient_Client.<>f__mg$cache9);
		if (Lua_BlackJack_ProjectL_LibClient_Client.<>f__mg$cacheA == null)
		{
			Lua_BlackJack_ProjectL_LibClient_Client.<>f__mg$cacheA = new LuaCSFunction(Lua_BlackJack_ProjectL_LibClient_Client.GetIp);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_LibClient_Client.<>f__mg$cacheA);
		if (Lua_BlackJack_ProjectL_LibClient_Client.<>f__mg$cacheB == null)
		{
			Lua_BlackJack_ProjectL_LibClient_Client.<>f__mg$cacheB = new LuaCSFunction(Lua_BlackJack_ProjectL_LibClient_Client.constructor);
		}
		LuaObject.createTypeMetatable(l, Lua_BlackJack_ProjectL_LibClient_Client.<>f__mg$cacheB, typeof(Client));
	}

	// Token: 0x0400F47C RID: 62588
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache0;

	// Token: 0x0400F47D RID: 62589
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1;

	// Token: 0x0400F47E RID: 62590
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2;

	// Token: 0x0400F47F RID: 62591
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3;

	// Token: 0x0400F480 RID: 62592
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache4;

	// Token: 0x0400F481 RID: 62593
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache5;

	// Token: 0x0400F482 RID: 62594
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache6;

	// Token: 0x0400F483 RID: 62595
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache7;

	// Token: 0x0400F484 RID: 62596
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache8;

	// Token: 0x0400F485 RID: 62597
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache9;

	// Token: 0x0400F486 RID: 62598
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheA;

	// Token: 0x0400F487 RID: 62599
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheB;
}
