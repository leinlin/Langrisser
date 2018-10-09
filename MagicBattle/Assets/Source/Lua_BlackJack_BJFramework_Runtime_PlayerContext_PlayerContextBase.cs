using System;
using System.Runtime.CompilerServices;
using BlackJack.BJFramework.Runtime.PlayerContext;
using BlackJack.Utils;
using SLua;
using UnityEngine.Scripting;

// Token: 0x02001114 RID: 4372
[Preserve]
public class Lua_BlackJack_BJFramework_Runtime_PlayerContext_PlayerContextBase : LuaObject
{
	// Token: 0x06015BA3 RID: 88995 RVA: 0x0059773C File Offset: 0x0059593C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int IsInited(IntPtr l)
	{
		int result;
		try
		{
			PlayerContextBase playerContextBase = (PlayerContextBase)LuaObject.checkSelf(l);
			bool b = playerContextBase.IsInited();
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

	// Token: 0x06015BA4 RID: 88996 RVA: 0x00597790 File Offset: 0x00595990
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int IsDataCacheDirtyByPlayerInfoInitAck(IntPtr l)
	{
		int result;
		try
		{
			PlayerContextBase playerContextBase = (PlayerContextBase)LuaObject.checkSelf(l);
			object msg;
			LuaObject.checkType<object>(l, 2, out msg);
			bool b2;
			bool b = playerContextBase.IsDataCacheDirtyByPlayerInfoInitAck(msg, out b2);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, b);
			LuaObject.pushValue(l, b2);
			result = 3;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06015BA5 RID: 88997 RVA: 0x00597800 File Offset: 0x00595A00
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int IsPlayerInfoInitAck4CheckOnly(IntPtr l)
	{
		int result;
		try
		{
			PlayerContextBase playerContextBase = (PlayerContextBase)LuaObject.checkSelf(l);
			object msg;
			LuaObject.checkType<object>(l, 2, out msg);
			bool b = playerContextBase.IsPlayerInfoInitAck4CheckOnly(msg);
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

	// Token: 0x06015BA6 RID: 88998 RVA: 0x00597864 File Offset: 0x00595A64
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int GetCurrServerTime(IntPtr l)
	{
		int result;
		try
		{
			PlayerContextBase playerContextBase = (PlayerContextBase)LuaObject.checkSelf(l);
			DateTime currServerTime = playerContextBase.GetCurrServerTime();
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, currServerTime);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06015BA7 RID: 88999 RVA: 0x005978C0 File Offset: 0x00595AC0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int GetCurrTickServerTime(IntPtr l)
	{
		int result;
		try
		{
			PlayerContextBase playerContextBase = (PlayerContextBase)LuaObject.checkSelf(l);
			DateTime currTickServerTime = playerContextBase.GetCurrTickServerTime();
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, currTickServerTime);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06015BA8 RID: 89000 RVA: 0x0059791C File Offset: 0x00595B1C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int Disconnect(IntPtr l)
	{
		int result;
		try
		{
			PlayerContextBase playerContextBase = (PlayerContextBase)LuaObject.checkSelf(l);
			bool b = playerContextBase.Disconnect();
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

	// Token: 0x06015BA9 RID: 89001 RVA: 0x00597970 File Offset: 0x00595B70
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int StartGameAuthLogin(IntPtr l)
	{
		int result;
		try
		{
			PlayerContextBase playerContextBase = (PlayerContextBase)LuaObject.checkSelf(l);
			string serverAddress;
			LuaObject.checkType(l, 2, out serverAddress);
			int serverPort;
			LuaObject.checkType(l, 3, out serverPort);
			string authToken;
			LuaObject.checkType(l, 4, out authToken);
			string localization;
			LuaObject.checkType(l, 5, out localization);
			int loginChannelId;
			LuaObject.checkType(l, 6, out loginChannelId);
			int bornChannelId;
			LuaObject.checkType(l, 7, out bornChannelId);
			bool b = playerContextBase.StartGameAuthLogin(serverAddress, serverPort, authToken, localization, loginChannelId, bornChannelId);
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

	// Token: 0x06015BAA RID: 89002 RVA: 0x00597A10 File Offset: 0x00595C10
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int SetSessionToken(IntPtr l)
	{
		int result;
		try
		{
			PlayerContextBase playerContextBase = (PlayerContextBase)LuaObject.checkSelf(l);
			string sessionToken;
			LuaObject.checkType(l, 2, out sessionToken);
			int channelId;
			LuaObject.checkType(l, 3, out channelId);
			int bornChannelId;
			LuaObject.checkType(l, 4, out bornChannelId);
			playerContextBase.SetSessionToken(sessionToken, channelId, bornChannelId);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06015BAB RID: 89003 RVA: 0x00597A84 File Offset: 0x00595C84
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int StartGameSessionLogin(IntPtr l)
	{
		int result;
		try
		{
			PlayerContextBase playerContextBase = (PlayerContextBase)LuaObject.checkSelf(l);
			bool b = playerContextBase.StartGameSessionLogin();
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

	// Token: 0x06015BAC RID: 89004 RVA: 0x00597AD8 File Offset: 0x00595CD8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int SendPlayerInfoInitReq(IntPtr l)
	{
		int result;
		try
		{
			PlayerContextBase playerContextBase = (PlayerContextBase)LuaObject.checkSelf(l);
			bool b = playerContextBase.SendPlayerInfoInitReq();
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

	// Token: 0x06015BAD RID: 89005 RVA: 0x00597B2C File Offset: 0x00595D2C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int SendPlayerInfoReqOnReloginBySession(IntPtr l)
	{
		int result;
		try
		{
			PlayerContextBase playerContextBase = (PlayerContextBase)LuaObject.checkSelf(l);
			bool checkOnly;
			LuaObject.checkType(l, 2, out checkOnly);
			bool b = playerContextBase.SendPlayerInfoReqOnReloginBySession(checkOnly);
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

	// Token: 0x06015BAE RID: 89006 RVA: 0x00597B90 File Offset: 0x00595D90
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int SendWorldEnterReqOnReloginBySession(IntPtr l)
	{
		int result;
		try
		{
			PlayerContextBase playerContextBase = (PlayerContextBase)LuaObject.checkSelf(l);
			bool b = playerContextBase.SendWorldEnterReqOnReloginBySession();
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

	// Token: 0x06015BAF RID: 89007 RVA: 0x00597BE4 File Offset: 0x00595DE4
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int CheckForSessionLogin(IntPtr l)
	{
		int result;
		try
		{
			PlayerContextBase playerContextBase = (PlayerContextBase)LuaObject.checkSelf(l);
			bool b = playerContextBase.CheckForSessionLogin();
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

	// Token: 0x06015BB0 RID: 89008 RVA: 0x00597C38 File Offset: 0x00595E38
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int GetInstance_s(IntPtr l)
	{
		int result;
		try
		{
			PlayerContextBase instance = PlayerContextBase.GetInstance();
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, instance);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06015BB1 RID: 89009 RVA: 0x00597C80 File Offset: 0x00595E80
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int CreateFakeAuthToken_s(IntPtr l)
	{
		int result;
		try
		{
			string platformUserId;
			LuaObject.checkType(l, 1, out platformUserId);
			string password;
			LuaObject.checkType(l, 2, out password);
			string s = PlayerContextBase.CreateFakeAuthToken(platformUserId, password);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, s);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06015BB2 RID: 89010 RVA: 0x00597CE0 File Offset: 0x00595EE0
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int OnPlayerInfoInitEndNtf(IntPtr l)
	{
		int result;
		try
		{
			PlayerContextBase playerContextBase = (PlayerContextBase)LuaObject.checkSelf(l);
			playerContextBase.m_luaExportHelper.OnPlayerInfoInitEndNtf();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06015BB3 RID: 89011 RVA: 0x00597D34 File Offset: 0x00595F34
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int SyncServerTime(IntPtr l)
	{
		int result;
		try
		{
			PlayerContextBase playerContextBase = (PlayerContextBase)LuaObject.checkSelf(l);
			DateTime serverTime;
			LuaObject.checkValueType<DateTime>(l, 2, out serverTime);
			playerContextBase.m_luaExportHelper.SyncServerTime(serverTime);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06015BB4 RID: 89012 RVA: 0x00597D90 File Offset: 0x00595F90
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int GetDeviceId(IntPtr l)
	{
		int result;
		try
		{
			PlayerContextBase playerContextBase = (PlayerContextBase)LuaObject.checkSelf(l);
			string deviceId = playerContextBase.m_luaExportHelper.GetDeviceId();
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, deviceId);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06015BB5 RID: 89013 RVA: 0x00597DEC File Offset: 0x00595FEC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int GetClientVersion(IntPtr l)
	{
		int result;
		try
		{
			PlayerContextBase playerContextBase = (PlayerContextBase)LuaObject.checkSelf(l);
			string clientVersion = playerContextBase.m_luaExportHelper.GetClientVersion();
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, clientVersion);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06015BB6 RID: 89014 RVA: 0x00597E48 File Offset: 0x00596048
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int OnTimeJumped(IntPtr l)
	{
		int result;
		try
		{
			PlayerContextBase playerContextBase = (PlayerContextBase)LuaObject.checkSelf(l);
			playerContextBase.m_luaExportHelper.OnTimeJumped();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06015BB7 RID: 89015 RVA: 0x00597E9C File Offset: 0x0059609C
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int __callDele_EventOnGameServerConnected(IntPtr l)
	{
		int result;
		try
		{
			PlayerContextBase playerContextBase = (PlayerContextBase)LuaObject.checkSelf(l);
			playerContextBase.m_luaExportHelper.__callDele_EventOnGameServerConnected();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06015BB8 RID: 89016 RVA: 0x00597EF0 File Offset: 0x005960F0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __clearDele_EventOnGameServerConnected(IntPtr l)
	{
		int result;
		try
		{
			PlayerContextBase playerContextBase = (PlayerContextBase)LuaObject.checkSelf(l);
			playerContextBase.m_luaExportHelper.__clearDele_EventOnGameServerConnected();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06015BB9 RID: 89017 RVA: 0x00597F44 File Offset: 0x00596144
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int __callDele_EventOnGameServerNetworkError(IntPtr l)
	{
		int result;
		try
		{
			PlayerContextBase playerContextBase = (PlayerContextBase)LuaObject.checkSelf(l);
			playerContextBase.m_luaExportHelper.__callDele_EventOnGameServerNetworkError();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06015BBA RID: 89018 RVA: 0x00597F98 File Offset: 0x00596198
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int __clearDele_EventOnGameServerNetworkError(IntPtr l)
	{
		int result;
		try
		{
			PlayerContextBase playerContextBase = (PlayerContextBase)LuaObject.checkSelf(l);
			playerContextBase.m_luaExportHelper.__clearDele_EventOnGameServerNetworkError();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06015BBB RID: 89019 RVA: 0x00597FEC File Offset: 0x005961EC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callDele_EventOnGameServerDisconnected(IntPtr l)
	{
		int result;
		try
		{
			PlayerContextBase playerContextBase = (PlayerContextBase)LuaObject.checkSelf(l);
			playerContextBase.m_luaExportHelper.__callDele_EventOnGameServerDisconnected();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06015BBC RID: 89020 RVA: 0x00598040 File Offset: 0x00596240
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __clearDele_EventOnGameServerDisconnected(IntPtr l)
	{
		int result;
		try
		{
			PlayerContextBase playerContextBase = (PlayerContextBase)LuaObject.checkSelf(l);
			playerContextBase.m_luaExportHelper.__clearDele_EventOnGameServerDisconnected();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06015BBD RID: 89021 RVA: 0x00598094 File Offset: 0x00596294
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int __callDele_EventOnLoginByAuthTokenAck(IntPtr l)
	{
		int result;
		try
		{
			PlayerContextBase playerContextBase = (PlayerContextBase)LuaObject.checkSelf(l);
			int arg;
			LuaObject.checkType(l, 2, out arg);
			string arg2;
			LuaObject.checkType(l, 3, out arg2);
			bool arg3;
			LuaObject.checkType(l, 4, out arg3);
			bool b = playerContextBase.m_luaExportHelper.__callDele_EventOnLoginByAuthTokenAck(arg, arg2, arg3);
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

	// Token: 0x06015BBE RID: 89022 RVA: 0x00598118 File Offset: 0x00596318
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int __clearDele_EventOnLoginByAuthTokenAck(IntPtr l)
	{
		int result;
		try
		{
			PlayerContextBase playerContextBase = (PlayerContextBase)LuaObject.checkSelf(l);
			int arg;
			LuaObject.checkType(l, 2, out arg);
			string arg2;
			LuaObject.checkType(l, 3, out arg2);
			bool arg3;
			LuaObject.checkType(l, 4, out arg3);
			playerContextBase.m_luaExportHelper.__clearDele_EventOnLoginByAuthTokenAck(arg, arg2, arg3);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06015BBF RID: 89023 RVA: 0x00598190 File Offset: 0x00596390
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callDele_EventOnLoginBySessionTokenAck(IntPtr l)
	{
		int result;
		try
		{
			PlayerContextBase playerContextBase = (PlayerContextBase)LuaObject.checkSelf(l);
			int arg;
			LuaObject.checkType(l, 2, out arg);
			bool b = playerContextBase.m_luaExportHelper.__callDele_EventOnLoginBySessionTokenAck(arg);
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

	// Token: 0x06015BC0 RID: 89024 RVA: 0x005981F8 File Offset: 0x005963F8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __clearDele_EventOnLoginBySessionTokenAck(IntPtr l)
	{
		int result;
		try
		{
			PlayerContextBase playerContextBase = (PlayerContextBase)LuaObject.checkSelf(l);
			int arg;
			LuaObject.checkType(l, 2, out arg);
			playerContextBase.m_luaExportHelper.__clearDele_EventOnLoginBySessionTokenAck(arg);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06015BC1 RID: 89025 RVA: 0x00598254 File Offset: 0x00596454
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int __callDele_EventOnGameServerDataUnsyncNotify(IntPtr l)
	{
		int result;
		try
		{
			PlayerContextBase playerContextBase = (PlayerContextBase)LuaObject.checkSelf(l);
			playerContextBase.m_luaExportHelper.__callDele_EventOnGameServerDataUnsyncNotify();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06015BC2 RID: 89026 RVA: 0x005982A8 File Offset: 0x005964A8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __clearDele_EventOnGameServerDataUnsyncNotify(IntPtr l)
	{
		int result;
		try
		{
			PlayerContextBase playerContextBase = (PlayerContextBase)LuaObject.checkSelf(l);
			playerContextBase.m_luaExportHelper.__clearDele_EventOnGameServerDataUnsyncNotify();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06015BC3 RID: 89027 RVA: 0x005982FC File Offset: 0x005964FC
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int __callDele_EventOnPlayerInfoInitAck(IntPtr l)
	{
		int result;
		try
		{
			PlayerContextBase playerContextBase = (PlayerContextBase)LuaObject.checkSelf(l);
			object obj;
			LuaObject.checkType<object>(l, 2, out obj);
			playerContextBase.m_luaExportHelper.__callDele_EventOnPlayerInfoInitAck(obj);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06015BC4 RID: 89028 RVA: 0x00598358 File Offset: 0x00596558
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __clearDele_EventOnPlayerInfoInitAck(IntPtr l)
	{
		int result;
		try
		{
			PlayerContextBase playerContextBase = (PlayerContextBase)LuaObject.checkSelf(l);
			object obj;
			LuaObject.checkType<object>(l, 2, out obj);
			playerContextBase.m_luaExportHelper.__clearDele_EventOnPlayerInfoInitAck(obj);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06015BC5 RID: 89029 RVA: 0x005983B4 File Offset: 0x005965B4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callDele_EventOnPlayerInfoInitEnd(IntPtr l)
	{
		int result;
		try
		{
			PlayerContextBase playerContextBase = (PlayerContextBase)LuaObject.checkSelf(l);
			playerContextBase.m_luaExportHelper.__callDele_EventOnPlayerInfoInitEnd();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06015BC6 RID: 89030 RVA: 0x00598408 File Offset: 0x00596608
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __clearDele_EventOnPlayerInfoInitEnd(IntPtr l)
	{
		int result;
		try
		{
			PlayerContextBase playerContextBase = (PlayerContextBase)LuaObject.checkSelf(l);
			playerContextBase.m_luaExportHelper.__clearDele_EventOnPlayerInfoInitEnd();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06015BC7 RID: 89031 RVA: 0x0059845C File Offset: 0x0059665C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_EventOnGameServerConnected(IntPtr l)
	{
		int result;
		try
		{
			PlayerContextBase playerContextBase = (PlayerContextBase)LuaObject.checkSelf(l);
			Action value;
			int num = LuaObject.checkDelegate<Action>(l, 2, out value);
			if (num != 0)
			{
				if (num == 1)
				{
					playerContextBase.EventOnGameServerConnected += value;
				}
				else if (num == 2)
				{
					playerContextBase.EventOnGameServerConnected -= value;
				}
			}
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06015BC8 RID: 89032 RVA: 0x005984DC File Offset: 0x005966DC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_EventOnGameServerNetworkError(IntPtr l)
	{
		int result;
		try
		{
			PlayerContextBase playerContextBase = (PlayerContextBase)LuaObject.checkSelf(l);
			Action value;
			int num = LuaObject.checkDelegate<Action>(l, 2, out value);
			if (num != 0)
			{
				if (num == 1)
				{
					playerContextBase.EventOnGameServerNetworkError += value;
				}
				else if (num == 2)
				{
					playerContextBase.EventOnGameServerNetworkError -= value;
				}
			}
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06015BC9 RID: 89033 RVA: 0x0059855C File Offset: 0x0059675C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_EventOnGameServerDisconnected(IntPtr l)
	{
		int result;
		try
		{
			PlayerContextBase playerContextBase = (PlayerContextBase)LuaObject.checkSelf(l);
			Action value;
			int num = LuaObject.checkDelegate<Action>(l, 2, out value);
			if (num != 0)
			{
				if (num == 1)
				{
					playerContextBase.EventOnGameServerDisconnected += value;
				}
				else if (num == 2)
				{
					playerContextBase.EventOnGameServerDisconnected -= value;
				}
			}
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06015BCA RID: 89034 RVA: 0x005985DC File Offset: 0x005967DC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_EventOnLoginByAuthTokenAck(IntPtr l)
	{
		int result;
		try
		{
			PlayerContextBase playerContextBase = (PlayerContextBase)LuaObject.checkSelf(l);
			Func<int, string, bool, bool> value;
			int num = LuaObject.checkDelegate<Func<int, string, bool, bool>>(l, 2, out value);
			if (num != 0)
			{
				if (num == 1)
				{
					playerContextBase.EventOnLoginByAuthTokenAck += value;
				}
				else if (num == 2)
				{
					playerContextBase.EventOnLoginByAuthTokenAck -= value;
				}
			}
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06015BCB RID: 89035 RVA: 0x0059865C File Offset: 0x0059685C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_EventOnLoginBySessionTokenAck(IntPtr l)
	{
		int result;
		try
		{
			PlayerContextBase playerContextBase = (PlayerContextBase)LuaObject.checkSelf(l);
			Func<int, bool> value;
			int num = LuaObject.checkDelegate<Func<int, bool>>(l, 2, out value);
			if (num != 0)
			{
				if (num == 1)
				{
					playerContextBase.EventOnLoginBySessionTokenAck += value;
				}
				else if (num == 2)
				{
					playerContextBase.EventOnLoginBySessionTokenAck -= value;
				}
			}
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06015BCC RID: 89036 RVA: 0x005986DC File Offset: 0x005968DC
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_EventOnGameServerDataUnsyncNotify(IntPtr l)
	{
		int result;
		try
		{
			PlayerContextBase playerContextBase = (PlayerContextBase)LuaObject.checkSelf(l);
			Action value;
			int num = LuaObject.checkDelegate<Action>(l, 2, out value);
			if (num != 0)
			{
				if (num == 1)
				{
					playerContextBase.EventOnGameServerDataUnsyncNotify += value;
				}
				else if (num == 2)
				{
					playerContextBase.EventOnGameServerDataUnsyncNotify -= value;
				}
			}
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06015BCD RID: 89037 RVA: 0x0059875C File Offset: 0x0059695C
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_EventOnPlayerInfoInitAck(IntPtr l)
	{
		int result;
		try
		{
			PlayerContextBase playerContextBase = (PlayerContextBase)LuaObject.checkSelf(l);
			Action<object> value;
			int num = LuaObject.checkDelegate<Action<object>>(l, 2, out value);
			if (num != 0)
			{
				if (num == 1)
				{
					playerContextBase.EventOnPlayerInfoInitAck += value;
				}
				else if (num == 2)
				{
					playerContextBase.EventOnPlayerInfoInitAck -= value;
				}
			}
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06015BCE RID: 89038 RVA: 0x005987DC File Offset: 0x005969DC
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_EventOnPlayerInfoInitEnd(IntPtr l)
	{
		int result;
		try
		{
			PlayerContextBase playerContextBase = (PlayerContextBase)LuaObject.checkSelf(l);
			Action value;
			int num = LuaObject.checkDelegate<Action>(l, 2, out value);
			if (num != 0)
			{
				if (num == 1)
				{
					playerContextBase.EventOnPlayerInfoInitEnd += value;
				}
				else if (num == 2)
				{
					playerContextBase.EventOnPlayerInfoInitEnd -= value;
				}
			}
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06015BCF RID: 89039 RVA: 0x0059885C File Offset: 0x00596A5C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_networkClient(IntPtr l)
	{
		int result;
		try
		{
			PlayerContextBase playerContextBase = (PlayerContextBase)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, playerContextBase.m_luaExportHelper.m_networkClient);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06015BD0 RID: 89040 RVA: 0x005988B4 File Offset: 0x00596AB4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_networkClient(IntPtr l)
	{
		int result;
		try
		{
			PlayerContextBase playerContextBase = (PlayerContextBase)LuaObject.checkSelf(l);
			IPlayerContextNetworkClient networkClient;
			LuaObject.checkType<IPlayerContextNetworkClient>(l, 2, out networkClient);
			playerContextBase.m_luaExportHelper.m_networkClient = networkClient;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06015BD1 RID: 89041 RVA: 0x00598910 File Offset: 0x00596B10
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_m_tinyCorutineHelper(IntPtr l)
	{
		int result;
		try
		{
			PlayerContextBase playerContextBase = (PlayerContextBase)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, playerContextBase.m_luaExportHelper.m_tinyCorutineHelper);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06015BD2 RID: 89042 RVA: 0x00598968 File Offset: 0x00596B68
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_tinyCorutineHelper(IntPtr l)
	{
		int result;
		try
		{
			PlayerContextBase playerContextBase = (PlayerContextBase)LuaObject.checkSelf(l);
			TinyCorutineHelper tinyCorutineHelper;
			LuaObject.checkType<TinyCorutineHelper>(l, 2, out tinyCorutineHelper);
			playerContextBase.m_luaExportHelper.m_tinyCorutineHelper = tinyCorutineHelper;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06015BD3 RID: 89043 RVA: 0x005989C4 File Offset: 0x00596BC4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_fsm(IntPtr l)
	{
		int result;
		try
		{
			PlayerContextBase playerContextBase = (PlayerContextBase)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, playerContextBase.m_luaExportHelper.m_fsm);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06015BD4 RID: 89044 RVA: 0x00598A1C File Offset: 0x00596C1C
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_m_fsm(IntPtr l)
	{
		int result;
		try
		{
			PlayerContextBase playerContextBase = (PlayerContextBase)LuaObject.checkSelf(l);
			PlayerContextStateMachine fsm;
			LuaObject.checkType<PlayerContextStateMachine>(l, 2, out fsm);
			playerContextBase.m_luaExportHelper.m_fsm = fsm;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06015BD5 RID: 89045 RVA: 0x00598A78 File Offset: 0x00596C78
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_deviceId(IntPtr l)
	{
		int result;
		try
		{
			PlayerContextBase playerContextBase = (PlayerContextBase)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, playerContextBase.m_luaExportHelper.m_deviceId);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06015BD6 RID: 89046 RVA: 0x00598AD0 File Offset: 0x00596CD0
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_m_deviceId(IntPtr l)
	{
		int result;
		try
		{
			PlayerContextBase playerContextBase = (PlayerContextBase)LuaObject.checkSelf(l);
			string deviceId;
			LuaObject.checkType(l, 2, out deviceId);
			playerContextBase.m_luaExportHelper.m_deviceId = deviceId;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06015BD7 RID: 89047 RVA: 0x00598B2C File Offset: 0x00596D2C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_clientVersion(IntPtr l)
	{
		int result;
		try
		{
			PlayerContextBase playerContextBase = (PlayerContextBase)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, playerContextBase.m_luaExportHelper.m_clientVersion);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06015BD8 RID: 89048 RVA: 0x00598B84 File Offset: 0x00596D84
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_clientVersion(IntPtr l)
	{
		int result;
		try
		{
			PlayerContextBase playerContextBase = (PlayerContextBase)LuaObject.checkSelf(l);
			string clientVersion;
			LuaObject.checkType(l, 2, out clientVersion);
			playerContextBase.m_luaExportHelper.m_clientVersion = clientVersion;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06015BD9 RID: 89049 RVA: 0x00598BE0 File Offset: 0x00596DE0
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_m_loginChannelId(IntPtr l)
	{
		int result;
		try
		{
			PlayerContextBase playerContextBase = (PlayerContextBase)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, playerContextBase.m_luaExportHelper.m_loginChannelId);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06015BDA RID: 89050 RVA: 0x00598C38 File Offset: 0x00596E38
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_m_loginChannelId(IntPtr l)
	{
		int result;
		try
		{
			PlayerContextBase playerContextBase = (PlayerContextBase)LuaObject.checkSelf(l);
			int loginChannelId;
			LuaObject.checkType(l, 2, out loginChannelId);
			playerContextBase.m_luaExportHelper.m_loginChannelId = loginChannelId;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06015BDB RID: 89051 RVA: 0x00598C94 File Offset: 0x00596E94
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_bornChannelId(IntPtr l)
	{
		int result;
		try
		{
			PlayerContextBase playerContextBase = (PlayerContextBase)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, playerContextBase.m_luaExportHelper.m_bornChannelId);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06015BDC RID: 89052 RVA: 0x00598CEC File Offset: 0x00596EEC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_bornChannelId(IntPtr l)
	{
		int result;
		try
		{
			PlayerContextBase playerContextBase = (PlayerContextBase)LuaObject.checkSelf(l);
			int bornChannelId;
			LuaObject.checkType(l, 2, out bornChannelId);
			playerContextBase.m_luaExportHelper.m_bornChannelId = bornChannelId;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06015BDD RID: 89053 RVA: 0x00598D48 File Offset: 0x00596F48
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_localization(IntPtr l)
	{
		int result;
		try
		{
			PlayerContextBase playerContextBase = (PlayerContextBase)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, playerContextBase.m_luaExportHelper.m_localization);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06015BDE RID: 89054 RVA: 0x00598DA0 File Offset: 0x00596FA0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_localization(IntPtr l)
	{
		int result;
		try
		{
			PlayerContextBase playerContextBase = (PlayerContextBase)LuaObject.checkSelf(l);
			string localization;
			LuaObject.checkType(l, 2, out localization);
			playerContextBase.m_luaExportHelper.m_localization = localization;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06015BDF RID: 89055 RVA: 0x00598DFC File Offset: 0x00596FFC
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_m_sessionToken(IntPtr l)
	{
		int result;
		try
		{
			PlayerContextBase playerContextBase = (PlayerContextBase)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, playerContextBase.m_luaExportHelper.m_sessionToken);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06015BE0 RID: 89056 RVA: 0x00598E54 File Offset: 0x00597054
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_sessionToken(IntPtr l)
	{
		int result;
		try
		{
			PlayerContextBase playerContextBase = (PlayerContextBase)LuaObject.checkSelf(l);
			string sessionToken;
			LuaObject.checkType(l, 2, out sessionToken);
			playerContextBase.m_luaExportHelper.m_sessionToken = sessionToken;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06015BE1 RID: 89057 RVA: 0x00598EB0 File Offset: 0x005970B0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_inited(IntPtr l)
	{
		int result;
		try
		{
			PlayerContextBase playerContextBase = (PlayerContextBase)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, playerContextBase.m_luaExportHelper.m_inited);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06015BE2 RID: 89058 RVA: 0x00598F08 File Offset: 0x00597108
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_inited(IntPtr l)
	{
		int result;
		try
		{
			PlayerContextBase playerContextBase = (PlayerContextBase)LuaObject.checkSelf(l);
			bool inited;
			LuaObject.checkType(l, 2, out inited);
			playerContextBase.m_luaExportHelper.m_inited = inited;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06015BE3 RID: 89059 RVA: 0x00598F64 File Offset: 0x00597164
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_serverTimeSynced(IntPtr l)
	{
		int result;
		try
		{
			PlayerContextBase playerContextBase = (PlayerContextBase)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, playerContextBase.m_luaExportHelper.m_serverTimeSynced);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06015BE4 RID: 89060 RVA: 0x00598FC0 File Offset: 0x005971C0
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_m_serverTimeSynced(IntPtr l)
	{
		int result;
		try
		{
			PlayerContextBase playerContextBase = (PlayerContextBase)LuaObject.checkSelf(l);
			DateTime? serverTimeSynced;
			LuaObject.checkNullable<DateTime>(l, 2, out serverTimeSynced);
			playerContextBase.m_luaExportHelper.m_serverTimeSynced = serverTimeSynced;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06015BE5 RID: 89061 RVA: 0x0059901C File Offset: 0x0059721C
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_m_localTimeAtServerTimeSynced(IntPtr l)
	{
		int result;
		try
		{
			PlayerContextBase playerContextBase = (PlayerContextBase)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, playerContextBase.m_luaExportHelper.m_localTimeAtServerTimeSynced);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06015BE6 RID: 89062 RVA: 0x00599078 File Offset: 0x00597278
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_localTimeAtServerTimeSynced(IntPtr l)
	{
		int result;
		try
		{
			PlayerContextBase playerContextBase = (PlayerContextBase)LuaObject.checkSelf(l);
			DateTime localTimeAtServerTimeSynced;
			LuaObject.checkValueType<DateTime>(l, 2, out localTimeAtServerTimeSynced);
			playerContextBase.m_luaExportHelper.m_localTimeAtServerTimeSynced = localTimeAtServerTimeSynced;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06015BE7 RID: 89063 RVA: 0x005990D4 File Offset: 0x005972D4
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_m_currTickServerTime(IntPtr l)
	{
		int result;
		try
		{
			PlayerContextBase playerContextBase = (PlayerContextBase)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, playerContextBase.m_luaExportHelper.m_currTickServerTime);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06015BE8 RID: 89064 RVA: 0x00599130 File Offset: 0x00597330
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_m_currTickServerTime(IntPtr l)
	{
		int result;
		try
		{
			PlayerContextBase playerContextBase = (PlayerContextBase)LuaObject.checkSelf(l);
			DateTime currTickServerTime;
			LuaObject.checkValueType<DateTime>(l, 2, out currTickServerTime);
			playerContextBase.m_luaExportHelper.m_currTickServerTime = currTickServerTime;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06015BE9 RID: 89065 RVA: 0x0059918C File Offset: 0x0059738C
	[Preserve]
	public static void reg(IntPtr l)
	{
		LuaObject.getTypeTable(l, "BlackJack.BJFramework.Runtime.PlayerContext.PlayerContextBase");
		if (Lua_BlackJack_BJFramework_Runtime_PlayerContext_PlayerContextBase.<>f__mg$cache0 == null)
		{
			Lua_BlackJack_BJFramework_Runtime_PlayerContext_PlayerContextBase.<>f__mg$cache0 = new LuaCSFunction(Lua_BlackJack_BJFramework_Runtime_PlayerContext_PlayerContextBase.IsInited);
		}
		LuaObject.addMember(l, Lua_BlackJack_BJFramework_Runtime_PlayerContext_PlayerContextBase.<>f__mg$cache0);
		if (Lua_BlackJack_BJFramework_Runtime_PlayerContext_PlayerContextBase.<>f__mg$cache1 == null)
		{
			Lua_BlackJack_BJFramework_Runtime_PlayerContext_PlayerContextBase.<>f__mg$cache1 = new LuaCSFunction(Lua_BlackJack_BJFramework_Runtime_PlayerContext_PlayerContextBase.IsDataCacheDirtyByPlayerInfoInitAck);
		}
		LuaObject.addMember(l, Lua_BlackJack_BJFramework_Runtime_PlayerContext_PlayerContextBase.<>f__mg$cache1);
		if (Lua_BlackJack_BJFramework_Runtime_PlayerContext_PlayerContextBase.<>f__mg$cache2 == null)
		{
			Lua_BlackJack_BJFramework_Runtime_PlayerContext_PlayerContextBase.<>f__mg$cache2 = new LuaCSFunction(Lua_BlackJack_BJFramework_Runtime_PlayerContext_PlayerContextBase.IsPlayerInfoInitAck4CheckOnly);
		}
		LuaObject.addMember(l, Lua_BlackJack_BJFramework_Runtime_PlayerContext_PlayerContextBase.<>f__mg$cache2);
		if (Lua_BlackJack_BJFramework_Runtime_PlayerContext_PlayerContextBase.<>f__mg$cache3 == null)
		{
			Lua_BlackJack_BJFramework_Runtime_PlayerContext_PlayerContextBase.<>f__mg$cache3 = new LuaCSFunction(Lua_BlackJack_BJFramework_Runtime_PlayerContext_PlayerContextBase.GetCurrServerTime);
		}
		LuaObject.addMember(l, Lua_BlackJack_BJFramework_Runtime_PlayerContext_PlayerContextBase.<>f__mg$cache3);
		if (Lua_BlackJack_BJFramework_Runtime_PlayerContext_PlayerContextBase.<>f__mg$cache4 == null)
		{
			Lua_BlackJack_BJFramework_Runtime_PlayerContext_PlayerContextBase.<>f__mg$cache4 = new LuaCSFunction(Lua_BlackJack_BJFramework_Runtime_PlayerContext_PlayerContextBase.GetCurrTickServerTime);
		}
		LuaObject.addMember(l, Lua_BlackJack_BJFramework_Runtime_PlayerContext_PlayerContextBase.<>f__mg$cache4);
		if (Lua_BlackJack_BJFramework_Runtime_PlayerContext_PlayerContextBase.<>f__mg$cache5 == null)
		{
			Lua_BlackJack_BJFramework_Runtime_PlayerContext_PlayerContextBase.<>f__mg$cache5 = new LuaCSFunction(Lua_BlackJack_BJFramework_Runtime_PlayerContext_PlayerContextBase.Disconnect);
		}
		LuaObject.addMember(l, Lua_BlackJack_BJFramework_Runtime_PlayerContext_PlayerContextBase.<>f__mg$cache5);
		if (Lua_BlackJack_BJFramework_Runtime_PlayerContext_PlayerContextBase.<>f__mg$cache6 == null)
		{
			Lua_BlackJack_BJFramework_Runtime_PlayerContext_PlayerContextBase.<>f__mg$cache6 = new LuaCSFunction(Lua_BlackJack_BJFramework_Runtime_PlayerContext_PlayerContextBase.StartGameAuthLogin);
		}
		LuaObject.addMember(l, Lua_BlackJack_BJFramework_Runtime_PlayerContext_PlayerContextBase.<>f__mg$cache6);
		if (Lua_BlackJack_BJFramework_Runtime_PlayerContext_PlayerContextBase.<>f__mg$cache7 == null)
		{
			Lua_BlackJack_BJFramework_Runtime_PlayerContext_PlayerContextBase.<>f__mg$cache7 = new LuaCSFunction(Lua_BlackJack_BJFramework_Runtime_PlayerContext_PlayerContextBase.SetSessionToken);
		}
		LuaObject.addMember(l, Lua_BlackJack_BJFramework_Runtime_PlayerContext_PlayerContextBase.<>f__mg$cache7);
		if (Lua_BlackJack_BJFramework_Runtime_PlayerContext_PlayerContextBase.<>f__mg$cache8 == null)
		{
			Lua_BlackJack_BJFramework_Runtime_PlayerContext_PlayerContextBase.<>f__mg$cache8 = new LuaCSFunction(Lua_BlackJack_BJFramework_Runtime_PlayerContext_PlayerContextBase.StartGameSessionLogin);
		}
		LuaObject.addMember(l, Lua_BlackJack_BJFramework_Runtime_PlayerContext_PlayerContextBase.<>f__mg$cache8);
		if (Lua_BlackJack_BJFramework_Runtime_PlayerContext_PlayerContextBase.<>f__mg$cache9 == null)
		{
			Lua_BlackJack_BJFramework_Runtime_PlayerContext_PlayerContextBase.<>f__mg$cache9 = new LuaCSFunction(Lua_BlackJack_BJFramework_Runtime_PlayerContext_PlayerContextBase.SendPlayerInfoInitReq);
		}
		LuaObject.addMember(l, Lua_BlackJack_BJFramework_Runtime_PlayerContext_PlayerContextBase.<>f__mg$cache9);
		if (Lua_BlackJack_BJFramework_Runtime_PlayerContext_PlayerContextBase.<>f__mg$cacheA == null)
		{
			Lua_BlackJack_BJFramework_Runtime_PlayerContext_PlayerContextBase.<>f__mg$cacheA = new LuaCSFunction(Lua_BlackJack_BJFramework_Runtime_PlayerContext_PlayerContextBase.SendPlayerInfoReqOnReloginBySession);
		}
		LuaObject.addMember(l, Lua_BlackJack_BJFramework_Runtime_PlayerContext_PlayerContextBase.<>f__mg$cacheA);
		if (Lua_BlackJack_BJFramework_Runtime_PlayerContext_PlayerContextBase.<>f__mg$cacheB == null)
		{
			Lua_BlackJack_BJFramework_Runtime_PlayerContext_PlayerContextBase.<>f__mg$cacheB = new LuaCSFunction(Lua_BlackJack_BJFramework_Runtime_PlayerContext_PlayerContextBase.SendWorldEnterReqOnReloginBySession);
		}
		LuaObject.addMember(l, Lua_BlackJack_BJFramework_Runtime_PlayerContext_PlayerContextBase.<>f__mg$cacheB);
		if (Lua_BlackJack_BJFramework_Runtime_PlayerContext_PlayerContextBase.<>f__mg$cacheC == null)
		{
			Lua_BlackJack_BJFramework_Runtime_PlayerContext_PlayerContextBase.<>f__mg$cacheC = new LuaCSFunction(Lua_BlackJack_BJFramework_Runtime_PlayerContext_PlayerContextBase.CheckForSessionLogin);
		}
		LuaObject.addMember(l, Lua_BlackJack_BJFramework_Runtime_PlayerContext_PlayerContextBase.<>f__mg$cacheC);
		if (Lua_BlackJack_BJFramework_Runtime_PlayerContext_PlayerContextBase.<>f__mg$cacheD == null)
		{
			Lua_BlackJack_BJFramework_Runtime_PlayerContext_PlayerContextBase.<>f__mg$cacheD = new LuaCSFunction(Lua_BlackJack_BJFramework_Runtime_PlayerContext_PlayerContextBase.GetInstance_s);
		}
		LuaObject.addMember(l, Lua_BlackJack_BJFramework_Runtime_PlayerContext_PlayerContextBase.<>f__mg$cacheD);
		if (Lua_BlackJack_BJFramework_Runtime_PlayerContext_PlayerContextBase.<>f__mg$cacheE == null)
		{
			Lua_BlackJack_BJFramework_Runtime_PlayerContext_PlayerContextBase.<>f__mg$cacheE = new LuaCSFunction(Lua_BlackJack_BJFramework_Runtime_PlayerContext_PlayerContextBase.CreateFakeAuthToken_s);
		}
		LuaObject.addMember(l, Lua_BlackJack_BJFramework_Runtime_PlayerContext_PlayerContextBase.<>f__mg$cacheE);
		if (Lua_BlackJack_BJFramework_Runtime_PlayerContext_PlayerContextBase.<>f__mg$cacheF == null)
		{
			Lua_BlackJack_BJFramework_Runtime_PlayerContext_PlayerContextBase.<>f__mg$cacheF = new LuaCSFunction(Lua_BlackJack_BJFramework_Runtime_PlayerContext_PlayerContextBase.OnPlayerInfoInitEndNtf);
		}
		LuaObject.addMember(l, Lua_BlackJack_BJFramework_Runtime_PlayerContext_PlayerContextBase.<>f__mg$cacheF);
		if (Lua_BlackJack_BJFramework_Runtime_PlayerContext_PlayerContextBase.<>f__mg$cache10 == null)
		{
			Lua_BlackJack_BJFramework_Runtime_PlayerContext_PlayerContextBase.<>f__mg$cache10 = new LuaCSFunction(Lua_BlackJack_BJFramework_Runtime_PlayerContext_PlayerContextBase.SyncServerTime);
		}
		LuaObject.addMember(l, Lua_BlackJack_BJFramework_Runtime_PlayerContext_PlayerContextBase.<>f__mg$cache10);
		if (Lua_BlackJack_BJFramework_Runtime_PlayerContext_PlayerContextBase.<>f__mg$cache11 == null)
		{
			Lua_BlackJack_BJFramework_Runtime_PlayerContext_PlayerContextBase.<>f__mg$cache11 = new LuaCSFunction(Lua_BlackJack_BJFramework_Runtime_PlayerContext_PlayerContextBase.GetDeviceId);
		}
		LuaObject.addMember(l, Lua_BlackJack_BJFramework_Runtime_PlayerContext_PlayerContextBase.<>f__mg$cache11);
		if (Lua_BlackJack_BJFramework_Runtime_PlayerContext_PlayerContextBase.<>f__mg$cache12 == null)
		{
			Lua_BlackJack_BJFramework_Runtime_PlayerContext_PlayerContextBase.<>f__mg$cache12 = new LuaCSFunction(Lua_BlackJack_BJFramework_Runtime_PlayerContext_PlayerContextBase.GetClientVersion);
		}
		LuaObject.addMember(l, Lua_BlackJack_BJFramework_Runtime_PlayerContext_PlayerContextBase.<>f__mg$cache12);
		if (Lua_BlackJack_BJFramework_Runtime_PlayerContext_PlayerContextBase.<>f__mg$cache13 == null)
		{
			Lua_BlackJack_BJFramework_Runtime_PlayerContext_PlayerContextBase.<>f__mg$cache13 = new LuaCSFunction(Lua_BlackJack_BJFramework_Runtime_PlayerContext_PlayerContextBase.OnTimeJumped);
		}
		LuaObject.addMember(l, Lua_BlackJack_BJFramework_Runtime_PlayerContext_PlayerContextBase.<>f__mg$cache13);
		if (Lua_BlackJack_BJFramework_Runtime_PlayerContext_PlayerContextBase.<>f__mg$cache14 == null)
		{
			Lua_BlackJack_BJFramework_Runtime_PlayerContext_PlayerContextBase.<>f__mg$cache14 = new LuaCSFunction(Lua_BlackJack_BJFramework_Runtime_PlayerContext_PlayerContextBase.__callDele_EventOnGameServerConnected);
		}
		LuaObject.addMember(l, Lua_BlackJack_BJFramework_Runtime_PlayerContext_PlayerContextBase.<>f__mg$cache14);
		if (Lua_BlackJack_BJFramework_Runtime_PlayerContext_PlayerContextBase.<>f__mg$cache15 == null)
		{
			Lua_BlackJack_BJFramework_Runtime_PlayerContext_PlayerContextBase.<>f__mg$cache15 = new LuaCSFunction(Lua_BlackJack_BJFramework_Runtime_PlayerContext_PlayerContextBase.__clearDele_EventOnGameServerConnected);
		}
		LuaObject.addMember(l, Lua_BlackJack_BJFramework_Runtime_PlayerContext_PlayerContextBase.<>f__mg$cache15);
		if (Lua_BlackJack_BJFramework_Runtime_PlayerContext_PlayerContextBase.<>f__mg$cache16 == null)
		{
			Lua_BlackJack_BJFramework_Runtime_PlayerContext_PlayerContextBase.<>f__mg$cache16 = new LuaCSFunction(Lua_BlackJack_BJFramework_Runtime_PlayerContext_PlayerContextBase.__callDele_EventOnGameServerNetworkError);
		}
		LuaObject.addMember(l, Lua_BlackJack_BJFramework_Runtime_PlayerContext_PlayerContextBase.<>f__mg$cache16);
		if (Lua_BlackJack_BJFramework_Runtime_PlayerContext_PlayerContextBase.<>f__mg$cache17 == null)
		{
			Lua_BlackJack_BJFramework_Runtime_PlayerContext_PlayerContextBase.<>f__mg$cache17 = new LuaCSFunction(Lua_BlackJack_BJFramework_Runtime_PlayerContext_PlayerContextBase.__clearDele_EventOnGameServerNetworkError);
		}
		LuaObject.addMember(l, Lua_BlackJack_BJFramework_Runtime_PlayerContext_PlayerContextBase.<>f__mg$cache17);
		if (Lua_BlackJack_BJFramework_Runtime_PlayerContext_PlayerContextBase.<>f__mg$cache18 == null)
		{
			Lua_BlackJack_BJFramework_Runtime_PlayerContext_PlayerContextBase.<>f__mg$cache18 = new LuaCSFunction(Lua_BlackJack_BJFramework_Runtime_PlayerContext_PlayerContextBase.__callDele_EventOnGameServerDisconnected);
		}
		LuaObject.addMember(l, Lua_BlackJack_BJFramework_Runtime_PlayerContext_PlayerContextBase.<>f__mg$cache18);
		if (Lua_BlackJack_BJFramework_Runtime_PlayerContext_PlayerContextBase.<>f__mg$cache19 == null)
		{
			Lua_BlackJack_BJFramework_Runtime_PlayerContext_PlayerContextBase.<>f__mg$cache19 = new LuaCSFunction(Lua_BlackJack_BJFramework_Runtime_PlayerContext_PlayerContextBase.__clearDele_EventOnGameServerDisconnected);
		}
		LuaObject.addMember(l, Lua_BlackJack_BJFramework_Runtime_PlayerContext_PlayerContextBase.<>f__mg$cache19);
		if (Lua_BlackJack_BJFramework_Runtime_PlayerContext_PlayerContextBase.<>f__mg$cache1A == null)
		{
			Lua_BlackJack_BJFramework_Runtime_PlayerContext_PlayerContextBase.<>f__mg$cache1A = new LuaCSFunction(Lua_BlackJack_BJFramework_Runtime_PlayerContext_PlayerContextBase.__callDele_EventOnLoginByAuthTokenAck);
		}
		LuaObject.addMember(l, Lua_BlackJack_BJFramework_Runtime_PlayerContext_PlayerContextBase.<>f__mg$cache1A);
		if (Lua_BlackJack_BJFramework_Runtime_PlayerContext_PlayerContextBase.<>f__mg$cache1B == null)
		{
			Lua_BlackJack_BJFramework_Runtime_PlayerContext_PlayerContextBase.<>f__mg$cache1B = new LuaCSFunction(Lua_BlackJack_BJFramework_Runtime_PlayerContext_PlayerContextBase.__clearDele_EventOnLoginByAuthTokenAck);
		}
		LuaObject.addMember(l, Lua_BlackJack_BJFramework_Runtime_PlayerContext_PlayerContextBase.<>f__mg$cache1B);
		if (Lua_BlackJack_BJFramework_Runtime_PlayerContext_PlayerContextBase.<>f__mg$cache1C == null)
		{
			Lua_BlackJack_BJFramework_Runtime_PlayerContext_PlayerContextBase.<>f__mg$cache1C = new LuaCSFunction(Lua_BlackJack_BJFramework_Runtime_PlayerContext_PlayerContextBase.__callDele_EventOnLoginBySessionTokenAck);
		}
		LuaObject.addMember(l, Lua_BlackJack_BJFramework_Runtime_PlayerContext_PlayerContextBase.<>f__mg$cache1C);
		if (Lua_BlackJack_BJFramework_Runtime_PlayerContext_PlayerContextBase.<>f__mg$cache1D == null)
		{
			Lua_BlackJack_BJFramework_Runtime_PlayerContext_PlayerContextBase.<>f__mg$cache1D = new LuaCSFunction(Lua_BlackJack_BJFramework_Runtime_PlayerContext_PlayerContextBase.__clearDele_EventOnLoginBySessionTokenAck);
		}
		LuaObject.addMember(l, Lua_BlackJack_BJFramework_Runtime_PlayerContext_PlayerContextBase.<>f__mg$cache1D);
		if (Lua_BlackJack_BJFramework_Runtime_PlayerContext_PlayerContextBase.<>f__mg$cache1E == null)
		{
			Lua_BlackJack_BJFramework_Runtime_PlayerContext_PlayerContextBase.<>f__mg$cache1E = new LuaCSFunction(Lua_BlackJack_BJFramework_Runtime_PlayerContext_PlayerContextBase.__callDele_EventOnGameServerDataUnsyncNotify);
		}
		LuaObject.addMember(l, Lua_BlackJack_BJFramework_Runtime_PlayerContext_PlayerContextBase.<>f__mg$cache1E);
		if (Lua_BlackJack_BJFramework_Runtime_PlayerContext_PlayerContextBase.<>f__mg$cache1F == null)
		{
			Lua_BlackJack_BJFramework_Runtime_PlayerContext_PlayerContextBase.<>f__mg$cache1F = new LuaCSFunction(Lua_BlackJack_BJFramework_Runtime_PlayerContext_PlayerContextBase.__clearDele_EventOnGameServerDataUnsyncNotify);
		}
		LuaObject.addMember(l, Lua_BlackJack_BJFramework_Runtime_PlayerContext_PlayerContextBase.<>f__mg$cache1F);
		if (Lua_BlackJack_BJFramework_Runtime_PlayerContext_PlayerContextBase.<>f__mg$cache20 == null)
		{
			Lua_BlackJack_BJFramework_Runtime_PlayerContext_PlayerContextBase.<>f__mg$cache20 = new LuaCSFunction(Lua_BlackJack_BJFramework_Runtime_PlayerContext_PlayerContextBase.__callDele_EventOnPlayerInfoInitAck);
		}
		LuaObject.addMember(l, Lua_BlackJack_BJFramework_Runtime_PlayerContext_PlayerContextBase.<>f__mg$cache20);
		if (Lua_BlackJack_BJFramework_Runtime_PlayerContext_PlayerContextBase.<>f__mg$cache21 == null)
		{
			Lua_BlackJack_BJFramework_Runtime_PlayerContext_PlayerContextBase.<>f__mg$cache21 = new LuaCSFunction(Lua_BlackJack_BJFramework_Runtime_PlayerContext_PlayerContextBase.__clearDele_EventOnPlayerInfoInitAck);
		}
		LuaObject.addMember(l, Lua_BlackJack_BJFramework_Runtime_PlayerContext_PlayerContextBase.<>f__mg$cache21);
		if (Lua_BlackJack_BJFramework_Runtime_PlayerContext_PlayerContextBase.<>f__mg$cache22 == null)
		{
			Lua_BlackJack_BJFramework_Runtime_PlayerContext_PlayerContextBase.<>f__mg$cache22 = new LuaCSFunction(Lua_BlackJack_BJFramework_Runtime_PlayerContext_PlayerContextBase.__callDele_EventOnPlayerInfoInitEnd);
		}
		LuaObject.addMember(l, Lua_BlackJack_BJFramework_Runtime_PlayerContext_PlayerContextBase.<>f__mg$cache22);
		if (Lua_BlackJack_BJFramework_Runtime_PlayerContext_PlayerContextBase.<>f__mg$cache23 == null)
		{
			Lua_BlackJack_BJFramework_Runtime_PlayerContext_PlayerContextBase.<>f__mg$cache23 = new LuaCSFunction(Lua_BlackJack_BJFramework_Runtime_PlayerContext_PlayerContextBase.__clearDele_EventOnPlayerInfoInitEnd);
		}
		LuaObject.addMember(l, Lua_BlackJack_BJFramework_Runtime_PlayerContext_PlayerContextBase.<>f__mg$cache23);
		string name = "EventOnGameServerConnected";
		LuaCSFunction get = null;
		if (Lua_BlackJack_BJFramework_Runtime_PlayerContext_PlayerContextBase.<>f__mg$cache24 == null)
		{
			Lua_BlackJack_BJFramework_Runtime_PlayerContext_PlayerContextBase.<>f__mg$cache24 = new LuaCSFunction(Lua_BlackJack_BJFramework_Runtime_PlayerContext_PlayerContextBase.set_EventOnGameServerConnected);
		}
		LuaObject.addMember(l, name, get, Lua_BlackJack_BJFramework_Runtime_PlayerContext_PlayerContextBase.<>f__mg$cache24, true);
		string name2 = "EventOnGameServerNetworkError";
		LuaCSFunction get2 = null;
		if (Lua_BlackJack_BJFramework_Runtime_PlayerContext_PlayerContextBase.<>f__mg$cache25 == null)
		{
			Lua_BlackJack_BJFramework_Runtime_PlayerContext_PlayerContextBase.<>f__mg$cache25 = new LuaCSFunction(Lua_BlackJack_BJFramework_Runtime_PlayerContext_PlayerContextBase.set_EventOnGameServerNetworkError);
		}
		LuaObject.addMember(l, name2, get2, Lua_BlackJack_BJFramework_Runtime_PlayerContext_PlayerContextBase.<>f__mg$cache25, true);
		string name3 = "EventOnGameServerDisconnected";
		LuaCSFunction get3 = null;
		if (Lua_BlackJack_BJFramework_Runtime_PlayerContext_PlayerContextBase.<>f__mg$cache26 == null)
		{
			Lua_BlackJack_BJFramework_Runtime_PlayerContext_PlayerContextBase.<>f__mg$cache26 = new LuaCSFunction(Lua_BlackJack_BJFramework_Runtime_PlayerContext_PlayerContextBase.set_EventOnGameServerDisconnected);
		}
		LuaObject.addMember(l, name3, get3, Lua_BlackJack_BJFramework_Runtime_PlayerContext_PlayerContextBase.<>f__mg$cache26, true);
		string name4 = "EventOnLoginByAuthTokenAck";
		LuaCSFunction get4 = null;
		if (Lua_BlackJack_BJFramework_Runtime_PlayerContext_PlayerContextBase.<>f__mg$cache27 == null)
		{
			Lua_BlackJack_BJFramework_Runtime_PlayerContext_PlayerContextBase.<>f__mg$cache27 = new LuaCSFunction(Lua_BlackJack_BJFramework_Runtime_PlayerContext_PlayerContextBase.set_EventOnLoginByAuthTokenAck);
		}
		LuaObject.addMember(l, name4, get4, Lua_BlackJack_BJFramework_Runtime_PlayerContext_PlayerContextBase.<>f__mg$cache27, true);
		string name5 = "EventOnLoginBySessionTokenAck";
		LuaCSFunction get5 = null;
		if (Lua_BlackJack_BJFramework_Runtime_PlayerContext_PlayerContextBase.<>f__mg$cache28 == null)
		{
			Lua_BlackJack_BJFramework_Runtime_PlayerContext_PlayerContextBase.<>f__mg$cache28 = new LuaCSFunction(Lua_BlackJack_BJFramework_Runtime_PlayerContext_PlayerContextBase.set_EventOnLoginBySessionTokenAck);
		}
		LuaObject.addMember(l, name5, get5, Lua_BlackJack_BJFramework_Runtime_PlayerContext_PlayerContextBase.<>f__mg$cache28, true);
		string name6 = "EventOnGameServerDataUnsyncNotify";
		LuaCSFunction get6 = null;
		if (Lua_BlackJack_BJFramework_Runtime_PlayerContext_PlayerContextBase.<>f__mg$cache29 == null)
		{
			Lua_BlackJack_BJFramework_Runtime_PlayerContext_PlayerContextBase.<>f__mg$cache29 = new LuaCSFunction(Lua_BlackJack_BJFramework_Runtime_PlayerContext_PlayerContextBase.set_EventOnGameServerDataUnsyncNotify);
		}
		LuaObject.addMember(l, name6, get6, Lua_BlackJack_BJFramework_Runtime_PlayerContext_PlayerContextBase.<>f__mg$cache29, true);
		string name7 = "EventOnPlayerInfoInitAck";
		LuaCSFunction get7 = null;
		if (Lua_BlackJack_BJFramework_Runtime_PlayerContext_PlayerContextBase.<>f__mg$cache2A == null)
		{
			Lua_BlackJack_BJFramework_Runtime_PlayerContext_PlayerContextBase.<>f__mg$cache2A = new LuaCSFunction(Lua_BlackJack_BJFramework_Runtime_PlayerContext_PlayerContextBase.set_EventOnPlayerInfoInitAck);
		}
		LuaObject.addMember(l, name7, get7, Lua_BlackJack_BJFramework_Runtime_PlayerContext_PlayerContextBase.<>f__mg$cache2A, true);
		string name8 = "EventOnPlayerInfoInitEnd";
		LuaCSFunction get8 = null;
		if (Lua_BlackJack_BJFramework_Runtime_PlayerContext_PlayerContextBase.<>f__mg$cache2B == null)
		{
			Lua_BlackJack_BJFramework_Runtime_PlayerContext_PlayerContextBase.<>f__mg$cache2B = new LuaCSFunction(Lua_BlackJack_BJFramework_Runtime_PlayerContext_PlayerContextBase.set_EventOnPlayerInfoInitEnd);
		}
		LuaObject.addMember(l, name8, get8, Lua_BlackJack_BJFramework_Runtime_PlayerContext_PlayerContextBase.<>f__mg$cache2B, true);
		string name9 = "m_networkClient";
		if (Lua_BlackJack_BJFramework_Runtime_PlayerContext_PlayerContextBase.<>f__mg$cache2C == null)
		{
			Lua_BlackJack_BJFramework_Runtime_PlayerContext_PlayerContextBase.<>f__mg$cache2C = new LuaCSFunction(Lua_BlackJack_BJFramework_Runtime_PlayerContext_PlayerContextBase.get_m_networkClient);
		}
		LuaCSFunction get9 = Lua_BlackJack_BJFramework_Runtime_PlayerContext_PlayerContextBase.<>f__mg$cache2C;
		if (Lua_BlackJack_BJFramework_Runtime_PlayerContext_PlayerContextBase.<>f__mg$cache2D == null)
		{
			Lua_BlackJack_BJFramework_Runtime_PlayerContext_PlayerContextBase.<>f__mg$cache2D = new LuaCSFunction(Lua_BlackJack_BJFramework_Runtime_PlayerContext_PlayerContextBase.set_m_networkClient);
		}
		LuaObject.addMember(l, name9, get9, Lua_BlackJack_BJFramework_Runtime_PlayerContext_PlayerContextBase.<>f__mg$cache2D, true);
		string name10 = "m_tinyCorutineHelper";
		if (Lua_BlackJack_BJFramework_Runtime_PlayerContext_PlayerContextBase.<>f__mg$cache2E == null)
		{
			Lua_BlackJack_BJFramework_Runtime_PlayerContext_PlayerContextBase.<>f__mg$cache2E = new LuaCSFunction(Lua_BlackJack_BJFramework_Runtime_PlayerContext_PlayerContextBase.get_m_tinyCorutineHelper);
		}
		LuaCSFunction get10 = Lua_BlackJack_BJFramework_Runtime_PlayerContext_PlayerContextBase.<>f__mg$cache2E;
		if (Lua_BlackJack_BJFramework_Runtime_PlayerContext_PlayerContextBase.<>f__mg$cache2F == null)
		{
			Lua_BlackJack_BJFramework_Runtime_PlayerContext_PlayerContextBase.<>f__mg$cache2F = new LuaCSFunction(Lua_BlackJack_BJFramework_Runtime_PlayerContext_PlayerContextBase.set_m_tinyCorutineHelper);
		}
		LuaObject.addMember(l, name10, get10, Lua_BlackJack_BJFramework_Runtime_PlayerContext_PlayerContextBase.<>f__mg$cache2F, true);
		string name11 = "m_fsm";
		if (Lua_BlackJack_BJFramework_Runtime_PlayerContext_PlayerContextBase.<>f__mg$cache30 == null)
		{
			Lua_BlackJack_BJFramework_Runtime_PlayerContext_PlayerContextBase.<>f__mg$cache30 = new LuaCSFunction(Lua_BlackJack_BJFramework_Runtime_PlayerContext_PlayerContextBase.get_m_fsm);
		}
		LuaCSFunction get11 = Lua_BlackJack_BJFramework_Runtime_PlayerContext_PlayerContextBase.<>f__mg$cache30;
		if (Lua_BlackJack_BJFramework_Runtime_PlayerContext_PlayerContextBase.<>f__mg$cache31 == null)
		{
			Lua_BlackJack_BJFramework_Runtime_PlayerContext_PlayerContextBase.<>f__mg$cache31 = new LuaCSFunction(Lua_BlackJack_BJFramework_Runtime_PlayerContext_PlayerContextBase.set_m_fsm);
		}
		LuaObject.addMember(l, name11, get11, Lua_BlackJack_BJFramework_Runtime_PlayerContext_PlayerContextBase.<>f__mg$cache31, true);
		string name12 = "m_deviceId";
		if (Lua_BlackJack_BJFramework_Runtime_PlayerContext_PlayerContextBase.<>f__mg$cache32 == null)
		{
			Lua_BlackJack_BJFramework_Runtime_PlayerContext_PlayerContextBase.<>f__mg$cache32 = new LuaCSFunction(Lua_BlackJack_BJFramework_Runtime_PlayerContext_PlayerContextBase.get_m_deviceId);
		}
		LuaCSFunction get12 = Lua_BlackJack_BJFramework_Runtime_PlayerContext_PlayerContextBase.<>f__mg$cache32;
		if (Lua_BlackJack_BJFramework_Runtime_PlayerContext_PlayerContextBase.<>f__mg$cache33 == null)
		{
			Lua_BlackJack_BJFramework_Runtime_PlayerContext_PlayerContextBase.<>f__mg$cache33 = new LuaCSFunction(Lua_BlackJack_BJFramework_Runtime_PlayerContext_PlayerContextBase.set_m_deviceId);
		}
		LuaObject.addMember(l, name12, get12, Lua_BlackJack_BJFramework_Runtime_PlayerContext_PlayerContextBase.<>f__mg$cache33, true);
		string name13 = "m_clientVersion";
		if (Lua_BlackJack_BJFramework_Runtime_PlayerContext_PlayerContextBase.<>f__mg$cache34 == null)
		{
			Lua_BlackJack_BJFramework_Runtime_PlayerContext_PlayerContextBase.<>f__mg$cache34 = new LuaCSFunction(Lua_BlackJack_BJFramework_Runtime_PlayerContext_PlayerContextBase.get_m_clientVersion);
		}
		LuaCSFunction get13 = Lua_BlackJack_BJFramework_Runtime_PlayerContext_PlayerContextBase.<>f__mg$cache34;
		if (Lua_BlackJack_BJFramework_Runtime_PlayerContext_PlayerContextBase.<>f__mg$cache35 == null)
		{
			Lua_BlackJack_BJFramework_Runtime_PlayerContext_PlayerContextBase.<>f__mg$cache35 = new LuaCSFunction(Lua_BlackJack_BJFramework_Runtime_PlayerContext_PlayerContextBase.set_m_clientVersion);
		}
		LuaObject.addMember(l, name13, get13, Lua_BlackJack_BJFramework_Runtime_PlayerContext_PlayerContextBase.<>f__mg$cache35, true);
		string name14 = "m_loginChannelId";
		if (Lua_BlackJack_BJFramework_Runtime_PlayerContext_PlayerContextBase.<>f__mg$cache36 == null)
		{
			Lua_BlackJack_BJFramework_Runtime_PlayerContext_PlayerContextBase.<>f__mg$cache36 = new LuaCSFunction(Lua_BlackJack_BJFramework_Runtime_PlayerContext_PlayerContextBase.get_m_loginChannelId);
		}
		LuaCSFunction get14 = Lua_BlackJack_BJFramework_Runtime_PlayerContext_PlayerContextBase.<>f__mg$cache36;
		if (Lua_BlackJack_BJFramework_Runtime_PlayerContext_PlayerContextBase.<>f__mg$cache37 == null)
		{
			Lua_BlackJack_BJFramework_Runtime_PlayerContext_PlayerContextBase.<>f__mg$cache37 = new LuaCSFunction(Lua_BlackJack_BJFramework_Runtime_PlayerContext_PlayerContextBase.set_m_loginChannelId);
		}
		LuaObject.addMember(l, name14, get14, Lua_BlackJack_BJFramework_Runtime_PlayerContext_PlayerContextBase.<>f__mg$cache37, true);
		string name15 = "m_bornChannelId";
		if (Lua_BlackJack_BJFramework_Runtime_PlayerContext_PlayerContextBase.<>f__mg$cache38 == null)
		{
			Lua_BlackJack_BJFramework_Runtime_PlayerContext_PlayerContextBase.<>f__mg$cache38 = new LuaCSFunction(Lua_BlackJack_BJFramework_Runtime_PlayerContext_PlayerContextBase.get_m_bornChannelId);
		}
		LuaCSFunction get15 = Lua_BlackJack_BJFramework_Runtime_PlayerContext_PlayerContextBase.<>f__mg$cache38;
		if (Lua_BlackJack_BJFramework_Runtime_PlayerContext_PlayerContextBase.<>f__mg$cache39 == null)
		{
			Lua_BlackJack_BJFramework_Runtime_PlayerContext_PlayerContextBase.<>f__mg$cache39 = new LuaCSFunction(Lua_BlackJack_BJFramework_Runtime_PlayerContext_PlayerContextBase.set_m_bornChannelId);
		}
		LuaObject.addMember(l, name15, get15, Lua_BlackJack_BJFramework_Runtime_PlayerContext_PlayerContextBase.<>f__mg$cache39, true);
		string name16 = "m_localization";
		if (Lua_BlackJack_BJFramework_Runtime_PlayerContext_PlayerContextBase.<>f__mg$cache3A == null)
		{
			Lua_BlackJack_BJFramework_Runtime_PlayerContext_PlayerContextBase.<>f__mg$cache3A = new LuaCSFunction(Lua_BlackJack_BJFramework_Runtime_PlayerContext_PlayerContextBase.get_m_localization);
		}
		LuaCSFunction get16 = Lua_BlackJack_BJFramework_Runtime_PlayerContext_PlayerContextBase.<>f__mg$cache3A;
		if (Lua_BlackJack_BJFramework_Runtime_PlayerContext_PlayerContextBase.<>f__mg$cache3B == null)
		{
			Lua_BlackJack_BJFramework_Runtime_PlayerContext_PlayerContextBase.<>f__mg$cache3B = new LuaCSFunction(Lua_BlackJack_BJFramework_Runtime_PlayerContext_PlayerContextBase.set_m_localization);
		}
		LuaObject.addMember(l, name16, get16, Lua_BlackJack_BJFramework_Runtime_PlayerContext_PlayerContextBase.<>f__mg$cache3B, true);
		string name17 = "m_sessionToken";
		if (Lua_BlackJack_BJFramework_Runtime_PlayerContext_PlayerContextBase.<>f__mg$cache3C == null)
		{
			Lua_BlackJack_BJFramework_Runtime_PlayerContext_PlayerContextBase.<>f__mg$cache3C = new LuaCSFunction(Lua_BlackJack_BJFramework_Runtime_PlayerContext_PlayerContextBase.get_m_sessionToken);
		}
		LuaCSFunction get17 = Lua_BlackJack_BJFramework_Runtime_PlayerContext_PlayerContextBase.<>f__mg$cache3C;
		if (Lua_BlackJack_BJFramework_Runtime_PlayerContext_PlayerContextBase.<>f__mg$cache3D == null)
		{
			Lua_BlackJack_BJFramework_Runtime_PlayerContext_PlayerContextBase.<>f__mg$cache3D = new LuaCSFunction(Lua_BlackJack_BJFramework_Runtime_PlayerContext_PlayerContextBase.set_m_sessionToken);
		}
		LuaObject.addMember(l, name17, get17, Lua_BlackJack_BJFramework_Runtime_PlayerContext_PlayerContextBase.<>f__mg$cache3D, true);
		string name18 = "m_inited";
		if (Lua_BlackJack_BJFramework_Runtime_PlayerContext_PlayerContextBase.<>f__mg$cache3E == null)
		{
			Lua_BlackJack_BJFramework_Runtime_PlayerContext_PlayerContextBase.<>f__mg$cache3E = new LuaCSFunction(Lua_BlackJack_BJFramework_Runtime_PlayerContext_PlayerContextBase.get_m_inited);
		}
		LuaCSFunction get18 = Lua_BlackJack_BJFramework_Runtime_PlayerContext_PlayerContextBase.<>f__mg$cache3E;
		if (Lua_BlackJack_BJFramework_Runtime_PlayerContext_PlayerContextBase.<>f__mg$cache3F == null)
		{
			Lua_BlackJack_BJFramework_Runtime_PlayerContext_PlayerContextBase.<>f__mg$cache3F = new LuaCSFunction(Lua_BlackJack_BJFramework_Runtime_PlayerContext_PlayerContextBase.set_m_inited);
		}
		LuaObject.addMember(l, name18, get18, Lua_BlackJack_BJFramework_Runtime_PlayerContext_PlayerContextBase.<>f__mg$cache3F, true);
		string name19 = "m_serverTimeSynced";
		if (Lua_BlackJack_BJFramework_Runtime_PlayerContext_PlayerContextBase.<>f__mg$cache40 == null)
		{
			Lua_BlackJack_BJFramework_Runtime_PlayerContext_PlayerContextBase.<>f__mg$cache40 = new LuaCSFunction(Lua_BlackJack_BJFramework_Runtime_PlayerContext_PlayerContextBase.get_m_serverTimeSynced);
		}
		LuaCSFunction get19 = Lua_BlackJack_BJFramework_Runtime_PlayerContext_PlayerContextBase.<>f__mg$cache40;
		if (Lua_BlackJack_BJFramework_Runtime_PlayerContext_PlayerContextBase.<>f__mg$cache41 == null)
		{
			Lua_BlackJack_BJFramework_Runtime_PlayerContext_PlayerContextBase.<>f__mg$cache41 = new LuaCSFunction(Lua_BlackJack_BJFramework_Runtime_PlayerContext_PlayerContextBase.set_m_serverTimeSynced);
		}
		LuaObject.addMember(l, name19, get19, Lua_BlackJack_BJFramework_Runtime_PlayerContext_PlayerContextBase.<>f__mg$cache41, true);
		string name20 = "m_localTimeAtServerTimeSynced";
		if (Lua_BlackJack_BJFramework_Runtime_PlayerContext_PlayerContextBase.<>f__mg$cache42 == null)
		{
			Lua_BlackJack_BJFramework_Runtime_PlayerContext_PlayerContextBase.<>f__mg$cache42 = new LuaCSFunction(Lua_BlackJack_BJFramework_Runtime_PlayerContext_PlayerContextBase.get_m_localTimeAtServerTimeSynced);
		}
		LuaCSFunction get20 = Lua_BlackJack_BJFramework_Runtime_PlayerContext_PlayerContextBase.<>f__mg$cache42;
		if (Lua_BlackJack_BJFramework_Runtime_PlayerContext_PlayerContextBase.<>f__mg$cache43 == null)
		{
			Lua_BlackJack_BJFramework_Runtime_PlayerContext_PlayerContextBase.<>f__mg$cache43 = new LuaCSFunction(Lua_BlackJack_BJFramework_Runtime_PlayerContext_PlayerContextBase.set_m_localTimeAtServerTimeSynced);
		}
		LuaObject.addMember(l, name20, get20, Lua_BlackJack_BJFramework_Runtime_PlayerContext_PlayerContextBase.<>f__mg$cache43, true);
		string name21 = "m_currTickServerTime";
		if (Lua_BlackJack_BJFramework_Runtime_PlayerContext_PlayerContextBase.<>f__mg$cache44 == null)
		{
			Lua_BlackJack_BJFramework_Runtime_PlayerContext_PlayerContextBase.<>f__mg$cache44 = new LuaCSFunction(Lua_BlackJack_BJFramework_Runtime_PlayerContext_PlayerContextBase.get_m_currTickServerTime);
		}
		LuaCSFunction get21 = Lua_BlackJack_BJFramework_Runtime_PlayerContext_PlayerContextBase.<>f__mg$cache44;
		if (Lua_BlackJack_BJFramework_Runtime_PlayerContext_PlayerContextBase.<>f__mg$cache45 == null)
		{
			Lua_BlackJack_BJFramework_Runtime_PlayerContext_PlayerContextBase.<>f__mg$cache45 = new LuaCSFunction(Lua_BlackJack_BJFramework_Runtime_PlayerContext_PlayerContextBase.set_m_currTickServerTime);
		}
		LuaObject.addMember(l, name21, get21, Lua_BlackJack_BJFramework_Runtime_PlayerContext_PlayerContextBase.<>f__mg$cache45, true);
		LuaObject.createTypeMetatable(l, null, typeof(PlayerContextBase));
	}

	// Token: 0x0400C35D RID: 50013
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache0;

	// Token: 0x0400C35E RID: 50014
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1;

	// Token: 0x0400C35F RID: 50015
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2;

	// Token: 0x0400C360 RID: 50016
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3;

	// Token: 0x0400C361 RID: 50017
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache4;

	// Token: 0x0400C362 RID: 50018
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache5;

	// Token: 0x0400C363 RID: 50019
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache6;

	// Token: 0x0400C364 RID: 50020
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache7;

	// Token: 0x0400C365 RID: 50021
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache8;

	// Token: 0x0400C366 RID: 50022
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache9;

	// Token: 0x0400C367 RID: 50023
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheA;

	// Token: 0x0400C368 RID: 50024
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheB;

	// Token: 0x0400C369 RID: 50025
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheC;

	// Token: 0x0400C36A RID: 50026
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheD;

	// Token: 0x0400C36B RID: 50027
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheE;

	// Token: 0x0400C36C RID: 50028
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheF;

	// Token: 0x0400C36D RID: 50029
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache10;

	// Token: 0x0400C36E RID: 50030
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache11;

	// Token: 0x0400C36F RID: 50031
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache12;

	// Token: 0x0400C370 RID: 50032
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache13;

	// Token: 0x0400C371 RID: 50033
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache14;

	// Token: 0x0400C372 RID: 50034
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache15;

	// Token: 0x0400C373 RID: 50035
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache16;

	// Token: 0x0400C374 RID: 50036
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache17;

	// Token: 0x0400C375 RID: 50037
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache18;

	// Token: 0x0400C376 RID: 50038
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache19;

	// Token: 0x0400C377 RID: 50039
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1A;

	// Token: 0x0400C378 RID: 50040
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1B;

	// Token: 0x0400C379 RID: 50041
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1C;

	// Token: 0x0400C37A RID: 50042
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1D;

	// Token: 0x0400C37B RID: 50043
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1E;

	// Token: 0x0400C37C RID: 50044
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1F;

	// Token: 0x0400C37D RID: 50045
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache20;

	// Token: 0x0400C37E RID: 50046
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache21;

	// Token: 0x0400C37F RID: 50047
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache22;

	// Token: 0x0400C380 RID: 50048
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache23;

	// Token: 0x0400C381 RID: 50049
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache24;

	// Token: 0x0400C382 RID: 50050
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache25;

	// Token: 0x0400C383 RID: 50051
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache26;

	// Token: 0x0400C384 RID: 50052
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache27;

	// Token: 0x0400C385 RID: 50053
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache28;

	// Token: 0x0400C386 RID: 50054
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache29;

	// Token: 0x0400C387 RID: 50055
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2A;

	// Token: 0x0400C388 RID: 50056
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2B;

	// Token: 0x0400C389 RID: 50057
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2C;

	// Token: 0x0400C38A RID: 50058
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2D;

	// Token: 0x0400C38B RID: 50059
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2E;

	// Token: 0x0400C38C RID: 50060
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2F;

	// Token: 0x0400C38D RID: 50061
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache30;

	// Token: 0x0400C38E RID: 50062
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache31;

	// Token: 0x0400C38F RID: 50063
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache32;

	// Token: 0x0400C390 RID: 50064
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache33;

	// Token: 0x0400C391 RID: 50065
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache34;

	// Token: 0x0400C392 RID: 50066
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache35;

	// Token: 0x0400C393 RID: 50067
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache36;

	// Token: 0x0400C394 RID: 50068
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache37;

	// Token: 0x0400C395 RID: 50069
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache38;

	// Token: 0x0400C396 RID: 50070
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache39;

	// Token: 0x0400C397 RID: 50071
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3A;

	// Token: 0x0400C398 RID: 50072
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3B;

	// Token: 0x0400C399 RID: 50073
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3C;

	// Token: 0x0400C39A RID: 50074
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3D;

	// Token: 0x0400C39B RID: 50075
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3E;

	// Token: 0x0400C39C RID: 50076
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3F;

	// Token: 0x0400C39D RID: 50077
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache40;

	// Token: 0x0400C39E RID: 50078
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache41;

	// Token: 0x0400C39F RID: 50079
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache42;

	// Token: 0x0400C3A0 RID: 50080
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache43;

	// Token: 0x0400C3A1 RID: 50081
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache44;

	// Token: 0x0400C3A2 RID: 50082
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache45;
}
