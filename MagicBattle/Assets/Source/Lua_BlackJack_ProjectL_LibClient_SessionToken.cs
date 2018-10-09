using System;
using System.Runtime.CompilerServices;
using BlackJack.ProjectL.LibClient;
using SLua;
using UnityEngine.Scripting;

// Token: 0x0200129B RID: 4763
[Preserve]
public class Lua_BlackJack_ProjectL_LibClient_SessionToken : LuaObject
{
	// Token: 0x06018FF3 RID: 102387 RVA: 0x0071C4F8 File Offset: 0x0071A6F8
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int constructor(IntPtr l)
	{
		int result;
		try
		{
			SessionToken o = new SessionToken();
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

	// Token: 0x06018FF4 RID: 102388 RVA: 0x0071C540 File Offset: 0x0071A740
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int GetSessionObject_s(IntPtr l)
	{
		int result;
		try
		{
			string sessionToken;
			LuaObject.checkType(l, 1, out sessionToken);
			SessionToken sessionObject = SessionToken.GetSessionObject(sessionToken);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, sessionObject);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06018FF5 RID: 102389 RVA: 0x0071C594 File Offset: 0x0071A794
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_AuthId(IntPtr l)
	{
		int result;
		try
		{
			SessionToken sessionToken = (SessionToken)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, sessionToken.AuthId);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06018FF6 RID: 102390 RVA: 0x0071C5E8 File Offset: 0x0071A7E8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_AuthId(IntPtr l)
	{
		int result;
		try
		{
			SessionToken sessionToken = (SessionToken)LuaObject.checkSelf(l);
			string authId;
			LuaObject.checkType(l, 2, out authId);
			sessionToken.AuthId = authId;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06018FF7 RID: 102391 RVA: 0x0071C640 File Offset: 0x0071A840
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_ServerAddress(IntPtr l)
	{
		int result;
		try
		{
			SessionToken sessionToken = (SessionToken)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, sessionToken.ServerAddress);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06018FF8 RID: 102392 RVA: 0x0071C694 File Offset: 0x0071A894
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_ServerAddress(IntPtr l)
	{
		int result;
		try
		{
			SessionToken sessionToken = (SessionToken)LuaObject.checkSelf(l);
			string serverAddress;
			LuaObject.checkType(l, 2, out serverAddress);
			sessionToken.ServerAddress = serverAddress;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06018FF9 RID: 102393 RVA: 0x0071C6EC File Offset: 0x0071A8EC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_ServerPort(IntPtr l)
	{
		int result;
		try
		{
			SessionToken sessionToken = (SessionToken)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, sessionToken.ServerPort);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06018FFA RID: 102394 RVA: 0x0071C740 File Offset: 0x0071A940
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_ServerPort(IntPtr l)
	{
		int result;
		try
		{
			SessionToken sessionToken = (SessionToken)LuaObject.checkSelf(l);
			int serverPort;
			LuaObject.checkType(l, 2, out serverPort);
			sessionToken.ServerPort = serverPort;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06018FFB RID: 102395 RVA: 0x0071C798 File Offset: 0x0071A998
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_TimeStamp(IntPtr l)
	{
		int result;
		try
		{
			SessionToken sessionToken = (SessionToken)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, sessionToken.TimeStamp);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06018FFC RID: 102396 RVA: 0x0071C7F0 File Offset: 0x0071A9F0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_TimeStamp(IntPtr l)
	{
		int result;
		try
		{
			SessionToken sessionToken = (SessionToken)LuaObject.checkSelf(l);
			DateTime timeStamp;
			LuaObject.checkValueType<DateTime>(l, 2, out timeStamp);
			sessionToken.TimeStamp = timeStamp;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06018FFD RID: 102397 RVA: 0x0071C848 File Offset: 0x0071AA48
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_SessionTokenOriginal(IntPtr l)
	{
		int result;
		try
		{
			SessionToken sessionToken = (SessionToken)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, sessionToken.SessionTokenOriginal);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06018FFE RID: 102398 RVA: 0x0071C89C File Offset: 0x0071AA9C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_SessionTokenOriginal(IntPtr l)
	{
		int result;
		try
		{
			SessionToken sessionToken = (SessionToken)LuaObject.checkSelf(l);
			string sessionTokenOriginal;
			LuaObject.checkType(l, 2, out sessionTokenOriginal);
			sessionToken.SessionTokenOriginal = sessionTokenOriginal;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06018FFF RID: 102399 RVA: 0x0071C8F4 File Offset: 0x0071AAF4
	[Preserve]
	public static void reg(IntPtr l)
	{
		LuaObject.getTypeTable(l, "BlackJack.ProjectL.LibClient.SessionToken");
		if (Lua_BlackJack_ProjectL_LibClient_SessionToken.<>f__mg$cache0 == null)
		{
			Lua_BlackJack_ProjectL_LibClient_SessionToken.<>f__mg$cache0 = new LuaCSFunction(Lua_BlackJack_ProjectL_LibClient_SessionToken.GetSessionObject_s);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_LibClient_SessionToken.<>f__mg$cache0);
		string name = "AuthId";
		if (Lua_BlackJack_ProjectL_LibClient_SessionToken.<>f__mg$cache1 == null)
		{
			Lua_BlackJack_ProjectL_LibClient_SessionToken.<>f__mg$cache1 = new LuaCSFunction(Lua_BlackJack_ProjectL_LibClient_SessionToken.get_AuthId);
		}
		LuaCSFunction get = Lua_BlackJack_ProjectL_LibClient_SessionToken.<>f__mg$cache1;
		if (Lua_BlackJack_ProjectL_LibClient_SessionToken.<>f__mg$cache2 == null)
		{
			Lua_BlackJack_ProjectL_LibClient_SessionToken.<>f__mg$cache2 = new LuaCSFunction(Lua_BlackJack_ProjectL_LibClient_SessionToken.set_AuthId);
		}
		LuaObject.addMember(l, name, get, Lua_BlackJack_ProjectL_LibClient_SessionToken.<>f__mg$cache2, true);
		string name2 = "ServerAddress";
		if (Lua_BlackJack_ProjectL_LibClient_SessionToken.<>f__mg$cache3 == null)
		{
			Lua_BlackJack_ProjectL_LibClient_SessionToken.<>f__mg$cache3 = new LuaCSFunction(Lua_BlackJack_ProjectL_LibClient_SessionToken.get_ServerAddress);
		}
		LuaCSFunction get2 = Lua_BlackJack_ProjectL_LibClient_SessionToken.<>f__mg$cache3;
		if (Lua_BlackJack_ProjectL_LibClient_SessionToken.<>f__mg$cache4 == null)
		{
			Lua_BlackJack_ProjectL_LibClient_SessionToken.<>f__mg$cache4 = new LuaCSFunction(Lua_BlackJack_ProjectL_LibClient_SessionToken.set_ServerAddress);
		}
		LuaObject.addMember(l, name2, get2, Lua_BlackJack_ProjectL_LibClient_SessionToken.<>f__mg$cache4, true);
		string name3 = "ServerPort";
		if (Lua_BlackJack_ProjectL_LibClient_SessionToken.<>f__mg$cache5 == null)
		{
			Lua_BlackJack_ProjectL_LibClient_SessionToken.<>f__mg$cache5 = new LuaCSFunction(Lua_BlackJack_ProjectL_LibClient_SessionToken.get_ServerPort);
		}
		LuaCSFunction get3 = Lua_BlackJack_ProjectL_LibClient_SessionToken.<>f__mg$cache5;
		if (Lua_BlackJack_ProjectL_LibClient_SessionToken.<>f__mg$cache6 == null)
		{
			Lua_BlackJack_ProjectL_LibClient_SessionToken.<>f__mg$cache6 = new LuaCSFunction(Lua_BlackJack_ProjectL_LibClient_SessionToken.set_ServerPort);
		}
		LuaObject.addMember(l, name3, get3, Lua_BlackJack_ProjectL_LibClient_SessionToken.<>f__mg$cache6, true);
		string name4 = "TimeStamp";
		if (Lua_BlackJack_ProjectL_LibClient_SessionToken.<>f__mg$cache7 == null)
		{
			Lua_BlackJack_ProjectL_LibClient_SessionToken.<>f__mg$cache7 = new LuaCSFunction(Lua_BlackJack_ProjectL_LibClient_SessionToken.get_TimeStamp);
		}
		LuaCSFunction get4 = Lua_BlackJack_ProjectL_LibClient_SessionToken.<>f__mg$cache7;
		if (Lua_BlackJack_ProjectL_LibClient_SessionToken.<>f__mg$cache8 == null)
		{
			Lua_BlackJack_ProjectL_LibClient_SessionToken.<>f__mg$cache8 = new LuaCSFunction(Lua_BlackJack_ProjectL_LibClient_SessionToken.set_TimeStamp);
		}
		LuaObject.addMember(l, name4, get4, Lua_BlackJack_ProjectL_LibClient_SessionToken.<>f__mg$cache8, true);
		string name5 = "SessionTokenOriginal";
		if (Lua_BlackJack_ProjectL_LibClient_SessionToken.<>f__mg$cache9 == null)
		{
			Lua_BlackJack_ProjectL_LibClient_SessionToken.<>f__mg$cache9 = new LuaCSFunction(Lua_BlackJack_ProjectL_LibClient_SessionToken.get_SessionTokenOriginal);
		}
		LuaCSFunction get5 = Lua_BlackJack_ProjectL_LibClient_SessionToken.<>f__mg$cache9;
		if (Lua_BlackJack_ProjectL_LibClient_SessionToken.<>f__mg$cacheA == null)
		{
			Lua_BlackJack_ProjectL_LibClient_SessionToken.<>f__mg$cacheA = new LuaCSFunction(Lua_BlackJack_ProjectL_LibClient_SessionToken.set_SessionTokenOriginal);
		}
		LuaObject.addMember(l, name5, get5, Lua_BlackJack_ProjectL_LibClient_SessionToken.<>f__mg$cacheA, true);
		if (Lua_BlackJack_ProjectL_LibClient_SessionToken.<>f__mg$cacheB == null)
		{
			Lua_BlackJack_ProjectL_LibClient_SessionToken.<>f__mg$cacheB = new LuaCSFunction(Lua_BlackJack_ProjectL_LibClient_SessionToken.constructor);
		}
		LuaObject.createTypeMetatable(l, Lua_BlackJack_ProjectL_LibClient_SessionToken.<>f__mg$cacheB, typeof(SessionToken));
	}

	// Token: 0x0400F49F RID: 62623
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache0;

	// Token: 0x0400F4A0 RID: 62624
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1;

	// Token: 0x0400F4A1 RID: 62625
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2;

	// Token: 0x0400F4A2 RID: 62626
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3;

	// Token: 0x0400F4A3 RID: 62627
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache4;

	// Token: 0x0400F4A4 RID: 62628
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache5;

	// Token: 0x0400F4A5 RID: 62629
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache6;

	// Token: 0x0400F4A6 RID: 62630
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache7;

	// Token: 0x0400F4A7 RID: 62631
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache8;

	// Token: 0x0400F4A8 RID: 62632
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache9;

	// Token: 0x0400F4A9 RID: 62633
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheA;

	// Token: 0x0400F4AA RID: 62634
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheB;
}
