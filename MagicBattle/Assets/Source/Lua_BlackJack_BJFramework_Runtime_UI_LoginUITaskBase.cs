using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using BlackJack.BJFramework.Runtime.Scene;
using BlackJack.BJFramework.Runtime.UI;
using SLua;
using UnityEngine.Scripting;

// Token: 0x02001126 RID: 4390
[Preserve]
public class Lua_BlackJack_BJFramework_Runtime_UI_LoginUITaskBase : LuaObject
{
	// Token: 0x06015D37 RID: 89399 RVA: 0x005A3518 File Offset: 0x005A1718
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int OnStop(IntPtr l)
	{
		int result;
		try
		{
			LoginUITaskBase loginUITaskBase = (LoginUITaskBase)LuaObject.checkSelf(l);
			loginUITaskBase.m_luaExportHelper.OnStop();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06015D38 RID: 89400 RVA: 0x005A356C File Offset: 0x005A176C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int PostUpdateView(IntPtr l)
	{
		int result;
		try
		{
			LoginUITaskBase loginUITaskBase = (LoginUITaskBase)LuaObject.checkSelf(l);
			loginUITaskBase.m_luaExportHelper.PostUpdateView();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06015D39 RID: 89401 RVA: 0x005A35C0 File Offset: 0x005A17C0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int IsSDKLogin(IntPtr l)
	{
		int result;
		try
		{
			LoginUITaskBase loginUITaskBase = (LoginUITaskBase)LuaObject.checkSelf(l);
			bool b = loginUITaskBase.m_luaExportHelper.IsSDKLogin();
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

	// Token: 0x06015D3A RID: 89402 RVA: 0x005A361C File Offset: 0x005A181C
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int IsEditorTestLogin(IntPtr l)
	{
		int result;
		try
		{
			LoginUITaskBase loginUITaskBase = (LoginUITaskBase)LuaObject.checkSelf(l);
			bool b = loginUITaskBase.m_luaExportHelper.IsEditorTestLogin();
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

	// Token: 0x06015D3B RID: 89403 RVA: 0x005A3678 File Offset: 0x005A1878
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int StartInitSDK(IntPtr l)
	{
		int result;
		try
		{
			LoginUITaskBase loginUITaskBase = (LoginUITaskBase)LuaObject.checkSelf(l);
			loginUITaskBase.m_luaExportHelper.StartInitSDK();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06015D3C RID: 89404 RVA: 0x005A36CC File Offset: 0x005A18CC
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int OnSDKInitEnd(IntPtr l)
	{
		int result;
		try
		{
			LoginUITaskBase loginUITaskBase = (LoginUITaskBase)LuaObject.checkSelf(l);
			bool isSuccess;
			LuaObject.checkType(l, 2, out isSuccess);
			loginUITaskBase.m_luaExportHelper.OnSDKInitEnd(isSuccess);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06015D3D RID: 89405 RVA: 0x005A3728 File Offset: 0x005A1928
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int StartSDKLogin(IntPtr l)
	{
		int result;
		try
		{
			LoginUITaskBase loginUITaskBase = (LoginUITaskBase)LuaObject.checkSelf(l);
			loginUITaskBase.m_luaExportHelper.StartSDKLogin();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06015D3E RID: 89406 RVA: 0x005A377C File Offset: 0x005A197C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int OnSDKLoginEnd(IntPtr l)
	{
		int result;
		try
		{
			LoginUITaskBase loginUITaskBase = (LoginUITaskBase)LuaObject.checkSelf(l);
			bool isSuccess;
			LuaObject.checkType(l, 2, out isSuccess);
			loginUITaskBase.m_luaExportHelper.OnSDKLoginEnd(isSuccess);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06015D3F RID: 89407 RVA: 0x005A37D8 File Offset: 0x005A19D8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int PostSDKLogin(IntPtr l)
	{
		int result;
		try
		{
			LoginUITaskBase loginUITaskBase = (LoginUITaskBase)LuaObject.checkSelf(l);
			loginUITaskBase.m_luaExportHelper.PostSDKLogin();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06015D40 RID: 89408 RVA: 0x005A382C File Offset: 0x005A1A2C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int IsNeedSelectServer(IntPtr l)
	{
		int result;
		try
		{
			LoginUITaskBase loginUITaskBase = (LoginUITaskBase)LuaObject.checkSelf(l);
			bool b = loginUITaskBase.m_luaExportHelper.IsNeedSelectServer();
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

	// Token: 0x06015D41 RID: 89409 RVA: 0x005A3888 File Offset: 0x005A1A88
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int LaunchServerListUI(IntPtr l)
	{
		int result;
		try
		{
			LoginUITaskBase loginUITaskBase = (LoginUITaskBase)LuaObject.checkSelf(l);
			loginUITaskBase.m_luaExportHelper.LaunchServerListUI();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06015D42 RID: 89410 RVA: 0x005A38DC File Offset: 0x005A1ADC
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int DownloadServerList(IntPtr l)
	{
		int result;
		try
		{
			LoginUITaskBase loginUITaskBase = (LoginUITaskBase)LuaObject.checkSelf(l);
			Action<bool> onEnd;
			LuaObject.checkDelegate<Action<bool>>(l, 2, out onEnd);
			IEnumerator o = loginUITaskBase.m_luaExportHelper.DownloadServerList(onEnd);
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

	// Token: 0x06015D43 RID: 89411 RVA: 0x005A3944 File Offset: 0x005A1B44
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int OnDownloadServerListEnd(IntPtr l)
	{
		int result;
		try
		{
			LoginUITaskBase loginUITaskBase = (LoginUITaskBase)LuaObject.checkSelf(l);
			bool isSuccess;
			LuaObject.checkType(l, 2, out isSuccess);
			loginUITaskBase.m_luaExportHelper.OnDownloadServerListEnd(isSuccess);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06015D44 RID: 89412 RVA: 0x005A39A0 File Offset: 0x005A1BA0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int ShowServerListUI(IntPtr l)
	{
		int result;
		try
		{
			LoginUITaskBase loginUITaskBase = (LoginUITaskBase)LuaObject.checkSelf(l);
			loginUITaskBase.m_luaExportHelper.ShowServerListUI();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06015D45 RID: 89413 RVA: 0x005A39F4 File Offset: 0x005A1BF4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int OnGameServerConfirmed(IntPtr l)
	{
		int result;
		try
		{
			LoginUITaskBase loginUITaskBase = (LoginUITaskBase)LuaObject.checkSelf(l);
			string serverId;
			LuaObject.checkType(l, 2, out serverId);
			loginUITaskBase.m_luaExportHelper.OnGameServerConfirmed(serverId);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06015D46 RID: 89414 RVA: 0x005A3A50 File Offset: 0x005A1C50
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int InitServerCtxByServerID(IntPtr l)
	{
		int result;
		try
		{
			LoginUITaskBase loginUITaskBase = (LoginUITaskBase)LuaObject.checkSelf(l);
			string serverId;
			LuaObject.checkType(l, 2, out serverId);
			loginUITaskBase.m_luaExportHelper.InitServerCtxByServerID(serverId);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06015D47 RID: 89415 RVA: 0x005A3AAC File Offset: 0x005A1CAC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int GetLastLoginedServerID(IntPtr l)
	{
		int result;
		try
		{
			LoginUITaskBase loginUITaskBase = (LoginUITaskBase)LuaObject.checkSelf(l);
			string lastLoginedServerID = loginUITaskBase.m_luaExportHelper.GetLastLoginedServerID();
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, lastLoginedServerID);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06015D48 RID: 89416 RVA: 0x005A3B08 File Offset: 0x005A1D08
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int LaunchEnterGameUI(IntPtr l)
	{
		int result;
		try
		{
			LoginUITaskBase loginUITaskBase = (LoginUITaskBase)LuaObject.checkSelf(l);
			loginUITaskBase.m_luaExportHelper.LaunchEnterGameUI();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06015D49 RID: 89417 RVA: 0x005A3B5C File Offset: 0x005A1D5C
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int LaunchEnterGameUIWithGameSettingTokenAndServer(IntPtr l)
	{
		int result;
		try
		{
			LoginUITaskBase loginUITaskBase = (LoginUITaskBase)LuaObject.checkSelf(l);
			loginUITaskBase.m_luaExportHelper.LaunchEnterGameUIWithGameSettingTokenAndServer();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06015D4A RID: 89418 RVA: 0x005A3BB0 File Offset: 0x005A1DB0
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int LaunchEnterGameUIWithUIInputAccountAndServer(IntPtr l)
	{
		int result;
		try
		{
			LoginUITaskBase loginUITaskBase = (LoginUITaskBase)LuaObject.checkSelf(l);
			loginUITaskBase.m_luaExportHelper.LaunchEnterGameUIWithUIInputAccountAndServer();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06015D4B RID: 89419 RVA: 0x005A3C04 File Offset: 0x005A1E04
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int LoadLastLoginWithUIInputInfo(IntPtr l)
	{
		int result;
		try
		{
			LoginUITaskBase loginUITaskBase = (LoginUITaskBase)LuaObject.checkSelf(l);
			string s;
			string s2;
			int i;
			bool b = loginUITaskBase.m_luaExportHelper.LoadLastLoginWithUIInputInfo(out s, out s2, out i);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, b);
			LuaObject.pushValue(l, s);
			LuaObject.pushValue(l, s2);
			LuaObject.pushValue(l, i);
			result = 5;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06015D4C RID: 89420 RVA: 0x005A3C80 File Offset: 0x005A1E80
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int DownloadGameServerLoginAnnouncement(IntPtr l)
	{
		int result;
		try
		{
			LoginUITaskBase loginUITaskBase = (LoginUITaskBase)LuaObject.checkSelf(l);
			Action<bool> onEnd;
			LuaObject.checkDelegate<Action<bool>>(l, 2, out onEnd);
			IEnumerator o = loginUITaskBase.m_luaExportHelper.DownloadGameServerLoginAnnouncement(onEnd);
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

	// Token: 0x06015D4D RID: 89421 RVA: 0x005A3CE8 File Offset: 0x005A1EE8
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int OnDownloadGameServerLoginAnnouncementEnd(IntPtr l)
	{
		int result;
		try
		{
			LoginUITaskBase loginUITaskBase = (LoginUITaskBase)LuaObject.checkSelf(l);
			bool isSuccess;
			LuaObject.checkType(l, 2, out isSuccess);
			loginUITaskBase.m_luaExportHelper.OnDownloadGameServerLoginAnnouncementEnd(isSuccess);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06015D4E RID: 89422 RVA: 0x005A3D44 File Offset: 0x005A1F44
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int ShowGameServerLoginAnnouncementUI(IntPtr l)
	{
		int result;
		try
		{
			LoginUITaskBase loginUITaskBase = (LoginUITaskBase)LuaObject.checkSelf(l);
			loginUITaskBase.m_luaExportHelper.ShowGameServerLoginAnnouncementUI();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06015D4F RID: 89423 RVA: 0x005A3D98 File Offset: 0x005A1F98
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int ShowEnterGameUI(IntPtr l)
	{
		int result;
		try
		{
			LoginUITaskBase loginUITaskBase = (LoginUITaskBase)LuaObject.checkSelf(l);
			loginUITaskBase.m_luaExportHelper.ShowEnterGameUI();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06015D50 RID: 89424 RVA: 0x005A3DEC File Offset: 0x005A1FEC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int OnEnterGameConfirmed(IntPtr l)
	{
		int result;
		try
		{
			LoginUITaskBase loginUITaskBase = (LoginUITaskBase)LuaObject.checkSelf(l);
			loginUITaskBase.m_luaExportHelper.OnEnterGameConfirmed();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06015D51 RID: 89425 RVA: 0x005A3E40 File Offset: 0x005A2040
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int StartLoginAgentLogin(IntPtr l)
	{
		int result;
		try
		{
			LoginUITaskBase loginUITaskBase = (LoginUITaskBase)LuaObject.checkSelf(l);
			Action<int, string, string> onEnd;
			LuaObject.checkDelegate<Action<int, string, string>>(l, 2, out onEnd);
			IEnumerator o = loginUITaskBase.m_luaExportHelper.StartLoginAgentLogin(onEnd);
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

	// Token: 0x06015D52 RID: 89426 RVA: 0x005A3EA8 File Offset: 0x005A20A8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int LoginAgentLoginEnd(IntPtr l)
	{
		int result;
		try
		{
			LoginUITaskBase loginUITaskBase = (LoginUITaskBase)LuaObject.checkSelf(l);
			int errCode;
			LuaObject.checkType(l, 2, out errCode);
			string loginUserId;
			LuaObject.checkType(l, 3, out loginUserId);
			string authToken;
			LuaObject.checkType(l, 4, out authToken);
			loginUITaskBase.m_luaExportHelper.LoginAgentLoginEnd(errCode, loginUserId, authToken);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06015D53 RID: 89427 RVA: 0x005A3F20 File Offset: 0x005A2120
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int StartAuthLogin(IntPtr l)
	{
		int result;
		try
		{
			LoginUITaskBase loginUITaskBase = (LoginUITaskBase)LuaObject.checkSelf(l);
			loginUITaskBase.m_luaExportHelper.StartAuthLogin();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06015D54 RID: 89428 RVA: 0x005A3F74 File Offset: 0x005A2174
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int StartSessionLogin(IntPtr l)
	{
		int result;
		try
		{
			LoginUITaskBase loginUITaskBase = (LoginUITaskBase)LuaObject.checkSelf(l);
			loginUITaskBase.m_luaExportHelper.StartSessionLogin();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06015D55 RID: 89429 RVA: 0x005A3FC8 File Offset: 0x005A21C8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int StartPlayerInfoInitReq(IntPtr l)
	{
		int result;
		try
		{
			LoginUITaskBase loginUITaskBase = (LoginUITaskBase)LuaObject.checkSelf(l);
			loginUITaskBase.m_luaExportHelper.StartPlayerInfoInitReq();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06015D56 RID: 89430 RVA: 0x005A401C File Offset: 0x005A221C
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int LauncheMainUI(IntPtr l)
	{
		int result;
		try
		{
			LoginUITaskBase loginUITaskBase = (LoginUITaskBase)LuaObject.checkSelf(l);
			loginUITaskBase.m_luaExportHelper.LauncheMainUI();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06015D57 RID: 89431 RVA: 0x005A4070 File Offset: 0x005A2270
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int OnWaitingMsgAckOutTime(IntPtr l)
	{
		int result;
		try
		{
			LoginUITaskBase loginUITaskBase = (LoginUITaskBase)LuaObject.checkSelf(l);
			loginUITaskBase.m_luaExportHelper.OnWaitingMsgAckOutTime();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06015D58 RID: 89432 RVA: 0x005A40C4 File Offset: 0x005A22C4
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int StartWaitingMsgAck(IntPtr l)
	{
		int result;
		try
		{
			LoginUITaskBase loginUITaskBase = (LoginUITaskBase)LuaObject.checkSelf(l);
			float waitTime;
			LuaObject.checkType(l, 2, out waitTime);
			loginUITaskBase.m_luaExportHelper.StartWaitingMsgAck(waitTime);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06015D59 RID: 89433 RVA: 0x005A4120 File Offset: 0x005A2320
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int StopWaitingMsgAck(IntPtr l)
	{
		int result;
		try
		{
			LoginUITaskBase loginUITaskBase = (LoginUITaskBase)LuaObject.checkSelf(l);
			loginUITaskBase.m_luaExportHelper.StopWaitingMsgAck();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06015D5A RID: 89434 RVA: 0x005A4174 File Offset: 0x005A2374
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int ClearGameServerLoginState(IntPtr l)
	{
		int result;
		try
		{
			LoginUITaskBase loginUITaskBase = (LoginUITaskBase)LuaObject.checkSelf(l);
			loginUITaskBase.m_luaExportHelper.ClearGameServerLoginState();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06015D5B RID: 89435 RVA: 0x005A41C8 File Offset: 0x005A23C8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int OnTick(IntPtr l)
	{
		int result;
		try
		{
			LoginUITaskBase loginUITaskBase = (LoginUITaskBase)LuaObject.checkSelf(l);
			loginUITaskBase.m_luaExportHelper.OnTick();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06015D5C RID: 89436 RVA: 0x005A421C File Offset: 0x005A241C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int OnGameServerConnected(IntPtr l)
	{
		int result;
		try
		{
			LoginUITaskBase loginUITaskBase = (LoginUITaskBase)LuaObject.checkSelf(l);
			loginUITaskBase.m_luaExportHelper.OnGameServerConnected();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06015D5D RID: 89437 RVA: 0x005A4270 File Offset: 0x005A2470
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int OnGameServerDisconnected(IntPtr l)
	{
		int result;
		try
		{
			LoginUITaskBase loginUITaskBase = (LoginUITaskBase)LuaObject.checkSelf(l);
			loginUITaskBase.m_luaExportHelper.OnGameServerDisconnected();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06015D5E RID: 89438 RVA: 0x005A42C4 File Offset: 0x005A24C4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int OnGameServerNetworkError(IntPtr l)
	{
		int result;
		try
		{
			LoginUITaskBase loginUITaskBase = (LoginUITaskBase)LuaObject.checkSelf(l);
			loginUITaskBase.m_luaExportHelper.OnGameServerNetworkError();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06015D5F RID: 89439 RVA: 0x005A4318 File Offset: 0x005A2518
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int OnLoginByAuthTokenAck(IntPtr l)
	{
		int result;
		try
		{
			LoginUITaskBase loginUITaskBase = (LoginUITaskBase)LuaObject.checkSelf(l);
			int ret;
			LuaObject.checkType(l, 2, out ret);
			string sessionToken;
			LuaObject.checkType(l, 3, out sessionToken);
			bool needRedirect;
			LuaObject.checkType(l, 4, out needRedirect);
			bool b = loginUITaskBase.m_luaExportHelper.OnLoginByAuthTokenAck(ret, sessionToken, needRedirect);
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

	// Token: 0x06015D60 RID: 89440 RVA: 0x005A439C File Offset: 0x005A259C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int OnLoginBySessionTokenAck(IntPtr l)
	{
		int result;
		try
		{
			LoginUITaskBase loginUITaskBase = (LoginUITaskBase)LuaObject.checkSelf(l);
			int ret;
			LuaObject.checkType(l, 2, out ret);
			bool b = loginUITaskBase.m_luaExportHelper.OnLoginBySessionTokenAck(ret);
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

	// Token: 0x06015D61 RID: 89441 RVA: 0x005A4404 File Offset: 0x005A2604
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int OnConfigDataMD5InfoNtf(IntPtr l)
	{
		int result;
		try
		{
			LoginUITaskBase loginUITaskBase = (LoginUITaskBase)LuaObject.checkSelf(l);
			string fileNameWithErrorMD;
			LuaObject.checkType(l, 2, out fileNameWithErrorMD);
			string localMD;
			LuaObject.checkType(l, 3, out localMD);
			string serverMD;
			LuaObject.checkType(l, 4, out serverMD);
			loginUITaskBase.m_luaExportHelper.OnConfigDataMD5InfoNtf(fileNameWithErrorMD, localMD, serverMD);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06015D62 RID: 89442 RVA: 0x005A447C File Offset: 0x005A267C
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int OnPlayerInfoInitEnd(IntPtr l)
	{
		int result;
		try
		{
			LoginUITaskBase loginUITaskBase = (LoginUITaskBase)LuaObject.checkSelf(l);
			loginUITaskBase.m_luaExportHelper.OnPlayerInfoInitEnd();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06015D63 RID: 89443 RVA: 0x005A44D0 File Offset: 0x005A26D0
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int RegisterNetEvent(IntPtr l)
	{
		int result;
		try
		{
			LoginUITaskBase loginUITaskBase = (LoginUITaskBase)LuaObject.checkSelf(l);
			loginUITaskBase.m_luaExportHelper.RegisterNetEvent();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06015D64 RID: 89444 RVA: 0x005A4524 File Offset: 0x005A2724
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int UnRegisterNetEvent(IntPtr l)
	{
		int result;
		try
		{
			LoginUITaskBase loginUITaskBase = (LoginUITaskBase)LuaObject.checkSelf(l);
			loginUITaskBase.m_luaExportHelper.UnRegisterNetEvent();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06015D65 RID: 89445 RVA: 0x005A4578 File Offset: 0x005A2778
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_InitlizeBeforeManagerStartIt(IntPtr l)
	{
		int result;
		try
		{
			LoginUITaskBase loginUITaskBase = (LoginUITaskBase)LuaObject.checkSelf(l);
			loginUITaskBase.m_luaExportHelper.__callBase_InitlizeBeforeManagerStartIt();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06015D66 RID: 89446 RVA: 0x005A45CC File Offset: 0x005A27CC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_PrepareForStartOrResume(IntPtr l)
	{
		int result;
		try
		{
			LoginUITaskBase loginUITaskBase = (LoginUITaskBase)LuaObject.checkSelf(l);
			UIIntent intent;
			LuaObject.checkType<UIIntent>(l, 2, out intent);
			Action<bool> onPrepareEnd;
			LuaObject.checkDelegate<Action<bool>>(l, 3, out onPrepareEnd);
			loginUITaskBase.m_luaExportHelper.__callBase_PrepareForStartOrResume(intent, onPrepareEnd);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06015D67 RID: 89447 RVA: 0x005A4638 File Offset: 0x005A2838
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int __callBase_OnStart(IntPtr l)
	{
		int result;
		try
		{
			int total = LuaDLL.lua_gettop(l);
			if (LuaObject.matchType(l, total, 2, typeof(object)))
			{
				LoginUITaskBase loginUITaskBase = (LoginUITaskBase)LuaObject.checkSelf(l);
				object param;
				LuaObject.checkType<object>(l, 2, out param);
				bool b = loginUITaskBase.m_luaExportHelper.__callBase_OnStart(param);
				LuaObject.pushValue(l, true);
				LuaObject.pushValue(l, b);
				result = 2;
			}
			else if (LuaObject.matchType(l, total, 2, typeof(UIIntent)))
			{
				LoginUITaskBase loginUITaskBase2 = (LoginUITaskBase)LuaObject.checkSelf(l);
				UIIntent intent;
				LuaObject.checkType<UIIntent>(l, 2, out intent);
				bool b2 = loginUITaskBase2.m_luaExportHelper.__callBase_OnStart(intent);
				LuaObject.pushValue(l, true);
				LuaObject.pushValue(l, b2);
				result = 2;
			}
			else
			{
				LuaObject.pushValue(l, false);
				LuaDLL.lua_pushstring(l, "No matched override function __callBase_OnStart to call");
				result = 2;
			}
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06015D68 RID: 89448 RVA: 0x005A4730 File Offset: 0x005A2930
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_GetPipeLineCtx(IntPtr l)
	{
		int result;
		try
		{
			LoginUITaskBase loginUITaskBase = (LoginUITaskBase)LuaObject.checkSelf(l);
			UITaskPipeLineCtx o = loginUITaskBase.m_luaExportHelper.__callBase_GetPipeLineCtx();
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

	// Token: 0x06015D69 RID: 89449 RVA: 0x005A478C File Offset: 0x005A298C
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int __callBase_CreatePipeLineCtx(IntPtr l)
	{
		int result;
		try
		{
			LoginUITaskBase loginUITaskBase = (LoginUITaskBase)LuaObject.checkSelf(l);
			UITaskPipeLineCtx o = loginUITaskBase.m_luaExportHelper.__callBase_CreatePipeLineCtx();
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

	// Token: 0x06015D6A RID: 89450 RVA: 0x005A47E8 File Offset: 0x005A29E8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_OnStop(IntPtr l)
	{
		int result;
		try
		{
			LoginUITaskBase loginUITaskBase = (LoginUITaskBase)LuaObject.checkSelf(l);
			loginUITaskBase.m_luaExportHelper.__callBase_OnStop();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06015D6B RID: 89451 RVA: 0x005A483C File Offset: 0x005A2A3C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_OnPause(IntPtr l)
	{
		int result;
		try
		{
			LoginUITaskBase loginUITaskBase = (LoginUITaskBase)LuaObject.checkSelf(l);
			loginUITaskBase.m_luaExportHelper.__callBase_OnPause();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06015D6C RID: 89452 RVA: 0x005A4890 File Offset: 0x005A2A90
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_OnResume(IntPtr l)
	{
		int result;
		try
		{
			int total = LuaDLL.lua_gettop(l);
			if (LuaObject.matchType(l, total, 2, typeof(object)))
			{
				LoginUITaskBase loginUITaskBase = (LoginUITaskBase)LuaObject.checkSelf(l);
				object param;
				LuaObject.checkType<object>(l, 2, out param);
				bool b = loginUITaskBase.m_luaExportHelper.__callBase_OnResume(param);
				LuaObject.pushValue(l, true);
				LuaObject.pushValue(l, b);
				result = 2;
			}
			else if (LuaObject.matchType(l, total, 2, typeof(UIIntent)))
			{
				LoginUITaskBase loginUITaskBase2 = (LoginUITaskBase)LuaObject.checkSelf(l);
				UIIntent intent;
				LuaObject.checkType<UIIntent>(l, 2, out intent);
				bool b2 = loginUITaskBase2.m_luaExportHelper.__callBase_OnResume(intent);
				LuaObject.pushValue(l, true);
				LuaObject.pushValue(l, b2);
				result = 2;
			}
			else
			{
				LuaObject.pushValue(l, false);
				LuaDLL.lua_pushstring(l, "No matched override function __callBase_OnResume to call");
				result = 2;
			}
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06015D6D RID: 89453 RVA: 0x005A4988 File Offset: 0x005A2B88
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_OnNewIntent(IntPtr l)
	{
		int result;
		try
		{
			LoginUITaskBase loginUITaskBase = (LoginUITaskBase)LuaObject.checkSelf(l);
			UIIntent intent;
			LuaObject.checkType<UIIntent>(l, 2, out intent);
			bool b = loginUITaskBase.m_luaExportHelper.__callBase_OnNewIntent(intent);
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

	// Token: 0x06015D6E RID: 89454 RVA: 0x005A49F0 File Offset: 0x005A2BF0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_StartUpdatePipeLine(IntPtr l)
	{
		int result;
		try
		{
			LoginUITaskBase loginUITaskBase = (LoginUITaskBase)LuaObject.checkSelf(l);
			UIIntent intent;
			LuaObject.checkType<UIIntent>(l, 2, out intent);
			bool onlyUpdateView;
			LuaObject.checkType(l, 3, out onlyUpdateView);
			bool canBeSkip;
			LuaObject.checkType(l, 4, out canBeSkip);
			bool enableQueue;
			LuaObject.checkType(l, 5, out enableQueue);
			bool b = loginUITaskBase.m_luaExportHelper.__callBase_StartUpdatePipeLine(intent, onlyUpdateView, canBeSkip, enableQueue);
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

	// Token: 0x06015D6F RID: 89455 RVA: 0x005A4A80 File Offset: 0x005A2C80
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_NeedSkipUpdatePipeLine(IntPtr l)
	{
		int result;
		try
		{
			LoginUITaskBase loginUITaskBase = (LoginUITaskBase)LuaObject.checkSelf(l);
			UIIntent intent;
			LuaObject.checkType<UIIntent>(l, 2, out intent);
			bool onlyUpdateView;
			LuaObject.checkType(l, 3, out onlyUpdateView);
			bool b = loginUITaskBase.m_luaExportHelper.__callBase_NeedSkipUpdatePipeLine(intent, onlyUpdateView);
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

	// Token: 0x06015D70 RID: 89456 RVA: 0x005A4AF4 File Offset: 0x005A2CF4
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int __callBase_IsNeedUpdateDataCache(IntPtr l)
	{
		int result;
		try
		{
			LoginUITaskBase loginUITaskBase = (LoginUITaskBase)LuaObject.checkSelf(l);
			bool b = loginUITaskBase.m_luaExportHelper.__callBase_IsNeedUpdateDataCache();
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

	// Token: 0x06015D71 RID: 89457 RVA: 0x005A4B50 File Offset: 0x005A2D50
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int __callBase_UpdateDataCache(IntPtr l)
	{
		int result;
		try
		{
			LoginUITaskBase loginUITaskBase = (LoginUITaskBase)LuaObject.checkSelf(l);
			loginUITaskBase.m_luaExportHelper.__callBase_UpdateDataCache();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06015D72 RID: 89458 RVA: 0x005A4BA4 File Offset: 0x005A2DA4
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int __callBase_IsNeedLoadStaticRes(IntPtr l)
	{
		int result;
		try
		{
			LoginUITaskBase loginUITaskBase = (LoginUITaskBase)LuaObject.checkSelf(l);
			bool b = loginUITaskBase.m_luaExportHelper.__callBase_IsNeedLoadStaticRes();
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

	// Token: 0x06015D73 RID: 89459 RVA: 0x005A4C00 File Offset: 0x005A2E00
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_StartLoadStaticRes(IntPtr l)
	{
		int result;
		try
		{
			LoginUITaskBase loginUITaskBase = (LoginUITaskBase)LuaObject.checkSelf(l);
			loginUITaskBase.m_luaExportHelper.__callBase_StartLoadStaticRes();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06015D74 RID: 89460 RVA: 0x005A4C54 File Offset: 0x005A2E54
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int __callBase_CheckLayerDescArray(IntPtr l)
	{
		int result;
		try
		{
			LoginUITaskBase loginUITaskBase = (LoginUITaskBase)LuaObject.checkSelf(l);
			List<UITaskBase.LayerDesc> layerDescArray;
			LuaObject.checkType<List<UITaskBase.LayerDesc>>(l, 2, out layerDescArray);
			loginUITaskBase.m_luaExportHelper.__callBase_CheckLayerDescArray(layerDescArray);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06015D75 RID: 89461 RVA: 0x005A4CB0 File Offset: 0x005A2EB0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_OnLoadStaticResCompleted(IntPtr l)
	{
		int result;
		try
		{
			LoginUITaskBase loginUITaskBase = (LoginUITaskBase)LuaObject.checkSelf(l);
			loginUITaskBase.m_luaExportHelper.__callBase_OnLoadStaticResCompleted();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06015D76 RID: 89462 RVA: 0x005A4D04 File Offset: 0x005A2F04
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int __callBase_IsNeedLoadDynamicRes(IntPtr l)
	{
		int result;
		try
		{
			LoginUITaskBase loginUITaskBase = (LoginUITaskBase)LuaObject.checkSelf(l);
			bool b = loginUITaskBase.m_luaExportHelper.__callBase_IsNeedLoadDynamicRes();
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

	// Token: 0x06015D77 RID: 89463 RVA: 0x005A4D60 File Offset: 0x005A2F60
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int __callBase_StartLoadDynamicRes(IntPtr l)
	{
		int result;
		try
		{
			LoginUITaskBase loginUITaskBase = (LoginUITaskBase)LuaObject.checkSelf(l);
			loginUITaskBase.m_luaExportHelper.__callBase_StartLoadDynamicRes();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06015D78 RID: 89464 RVA: 0x005A4DB4 File Offset: 0x005A2FB4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_CollectAllDynamicResForLoad(IntPtr l)
	{
		int result;
		try
		{
			LoginUITaskBase loginUITaskBase = (LoginUITaskBase)LuaObject.checkSelf(l);
			List<string> o = loginUITaskBase.m_luaExportHelper.__callBase_CollectAllDynamicResForLoad();
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

	// Token: 0x06015D79 RID: 89465 RVA: 0x005A4E10 File Offset: 0x005A3010
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int __callBase_CollectAllStaticResDescForLoad(IntPtr l)
	{
		int result;
		try
		{
			LoginUITaskBase loginUITaskBase = (LoginUITaskBase)LuaObject.checkSelf(l);
			List<UITaskBase.LayerDesc> o = loginUITaskBase.m_luaExportHelper.__callBase_CollectAllStaticResDescForLoad();
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

	// Token: 0x06015D7A RID: 89466 RVA: 0x005A4E6C File Offset: 0x005A306C
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int __callBase_CalculateDynamicResReallyNeedLoad(IntPtr l)
	{
		int result;
		try
		{
			LoginUITaskBase loginUITaskBase = (LoginUITaskBase)LuaObject.checkSelf(l);
			List<string> resPathList;
			LuaObject.checkType<List<string>>(l, 2, out resPathList);
			HashSet<string> o = loginUITaskBase.m_luaExportHelper.__callBase_CalculateDynamicResReallyNeedLoad(resPathList);
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

	// Token: 0x06015D7B RID: 89467 RVA: 0x005A4ED4 File Offset: 0x005A30D4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_OnLoadDynamicResCompleted(IntPtr l)
	{
		int result;
		try
		{
			LoginUITaskBase loginUITaskBase = (LoginUITaskBase)LuaObject.checkSelf(l);
			loginUITaskBase.m_luaExportHelper.__callBase_OnLoadDynamicResCompleted();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06015D7C RID: 89468 RVA: 0x005A4F28 File Offset: 0x005A3128
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_RedirectPipLineOnAllResReady(IntPtr l)
	{
		int result;
		try
		{
			LoginUITaskBase loginUITaskBase = (LoginUITaskBase)LuaObject.checkSelf(l);
			Action callBack;
			LuaObject.checkDelegate<Action>(l, 2, out callBack);
			loginUITaskBase.m_luaExportHelper.__callBase_RedirectPipLineOnAllResReady(callBack);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06015D7D RID: 89469 RVA: 0x005A4F84 File Offset: 0x005A3184
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_OnLoadAllResCompleted(IntPtr l)
	{
		int result;
		try
		{
			LoginUITaskBase loginUITaskBase = (LoginUITaskBase)LuaObject.checkSelf(l);
			loginUITaskBase.m_luaExportHelper.__callBase_OnLoadAllResCompleted();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06015D7E RID: 89470 RVA: 0x005A4FD8 File Offset: 0x005A31D8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_ReturnFromRedirectPipLineOnLoadAllResCompleted(IntPtr l)
	{
		int result;
		try
		{
			LoginUITaskBase loginUITaskBase = (LoginUITaskBase)LuaObject.checkSelf(l);
			loginUITaskBase.m_luaExportHelper.__callBase_ReturnFromRedirectPipLineOnLoadAllResCompleted();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06015D7F RID: 89471 RVA: 0x005A502C File Offset: 0x005A322C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_InitLayerStateOnLoadAllResCompleted(IntPtr l)
	{
		int result;
		try
		{
			LoginUITaskBase loginUITaskBase = (LoginUITaskBase)LuaObject.checkSelf(l);
			loginUITaskBase.m_luaExportHelper.__callBase_InitLayerStateOnLoadAllResCompleted();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06015D80 RID: 89472 RVA: 0x005A5080 File Offset: 0x005A3280
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int __callBase_InitAllUIControllers(IntPtr l)
	{
		int result;
		try
		{
			LoginUITaskBase loginUITaskBase = (LoginUITaskBase)LuaObject.checkSelf(l);
			loginUITaskBase.m_luaExportHelper.__callBase_InitAllUIControllers();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06015D81 RID: 89473 RVA: 0x005A50D4 File Offset: 0x005A32D4
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int __callBase_PostOnLoadAllResCompleted(IntPtr l)
	{
		int result;
		try
		{
			LoginUITaskBase loginUITaskBase = (LoginUITaskBase)LuaObject.checkSelf(l);
			loginUITaskBase.m_luaExportHelper.__callBase_PostOnLoadAllResCompleted();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06015D82 RID: 89474 RVA: 0x005A5128 File Offset: 0x005A3328
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_IsLoadAllResCompleted(IntPtr l)
	{
		int result;
		try
		{
			LoginUITaskBase loginUITaskBase = (LoginUITaskBase)LuaObject.checkSelf(l);
			bool b = loginUITaskBase.m_luaExportHelper.__callBase_IsLoadAllResCompleted();
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

	// Token: 0x06015D83 RID: 89475 RVA: 0x005A5184 File Offset: 0x005A3384
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int __callBase_StartUpdateView(IntPtr l)
	{
		int result;
		try
		{
			LoginUITaskBase loginUITaskBase = (LoginUITaskBase)LuaObject.checkSelf(l);
			loginUITaskBase.m_luaExportHelper.__callBase_StartUpdateView();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06015D84 RID: 89476 RVA: 0x005A51D8 File Offset: 0x005A33D8
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int __callBase_UpdateView(IntPtr l)
	{
		int result;
		try
		{
			LoginUITaskBase loginUITaskBase = (LoginUITaskBase)LuaObject.checkSelf(l);
			loginUITaskBase.m_luaExportHelper.__callBase_UpdateView();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06015D85 RID: 89477 RVA: 0x005A522C File Offset: 0x005A342C
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int __callBase_RegUpdateViewPlayingEffect(IntPtr l)
	{
		int result;
		try
		{
			LoginUITaskBase loginUITaskBase = (LoginUITaskBase)LuaObject.checkSelf(l);
			string name;
			LuaObject.checkType(l, 2, out name);
			int timeout;
			LuaObject.checkType(l, 3, out timeout);
			Action<string> onTimeOut;
			LuaObject.checkDelegate<Action<string>>(l, 4, out onTimeOut);
			loginUITaskBase.m_luaExportHelper.__callBase_RegUpdateViewPlayingEffect(name, timeout, onTimeOut);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06015D86 RID: 89478 RVA: 0x005A52A4 File Offset: 0x005A34A4
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int __callBase_UnregUpdateViewPlayingEffect(IntPtr l)
	{
		int result;
		try
		{
			LoginUITaskBase loginUITaskBase = (LoginUITaskBase)LuaObject.checkSelf(l);
			string name;
			LuaObject.checkType(l, 2, out name);
			bool isTimeOut;
			LuaObject.checkType(l, 3, out isTimeOut);
			loginUITaskBase.m_luaExportHelper.__callBase_UnregUpdateViewPlayingEffect(name, isTimeOut);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06015D87 RID: 89479 RVA: 0x005A5310 File Offset: 0x005A3510
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int __callBase_PostUpdateView(IntPtr l)
	{
		int result;
		try
		{
			LoginUITaskBase loginUITaskBase = (LoginUITaskBase)LuaObject.checkSelf(l);
			loginUITaskBase.m_luaExportHelper.__callBase_PostUpdateView();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06015D88 RID: 89480 RVA: 0x005A5364 File Offset: 0x005A3564
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int __callBase_PostUpdateViewBeforeClearContext(IntPtr l)
	{
		int result;
		try
		{
			LoginUITaskBase loginUITaskBase = (LoginUITaskBase)LuaObject.checkSelf(l);
			loginUITaskBase.m_luaExportHelper.__callBase_PostUpdateViewBeforeClearContext();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06015D89 RID: 89481 RVA: 0x005A53B8 File Offset: 0x005A35B8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_HideAllView(IntPtr l)
	{
		int result;
		try
		{
			LoginUITaskBase loginUITaskBase = (LoginUITaskBase)LuaObject.checkSelf(l);
			loginUITaskBase.m_luaExportHelper.__callBase_HideAllView();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06015D8A RID: 89482 RVA: 0x005A540C File Offset: 0x005A360C
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int __callBase_ClearAllContextAndRes(IntPtr l)
	{
		int result;
		try
		{
			LoginUITaskBase loginUITaskBase = (LoginUITaskBase)LuaObject.checkSelf(l);
			loginUITaskBase.m_luaExportHelper.__callBase_ClearAllContextAndRes();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06015D8B RID: 89483 RVA: 0x005A5460 File Offset: 0x005A3660
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_SaveContextInIntentOnPause(IntPtr l)
	{
		int result;
		try
		{
			LoginUITaskBase loginUITaskBase = (LoginUITaskBase)LuaObject.checkSelf(l);
			loginUITaskBase.m_luaExportHelper.__callBase_SaveContextInIntentOnPause();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06015D8C RID: 89484 RVA: 0x005A54B4 File Offset: 0x005A36B4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_ClearContextOnPause(IntPtr l)
	{
		int result;
		try
		{
			LoginUITaskBase loginUITaskBase = (LoginUITaskBase)LuaObject.checkSelf(l);
			loginUITaskBase.m_luaExportHelper.__callBase_ClearContextOnPause();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06015D8D RID: 89485 RVA: 0x005A5508 File Offset: 0x005A3708
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int __callBase_ClearContextOnIntentChange(IntPtr l)
	{
		int result;
		try
		{
			LoginUITaskBase loginUITaskBase = (LoginUITaskBase)LuaObject.checkSelf(l);
			UIIntent newIntent;
			LuaObject.checkType<UIIntent>(l, 2, out newIntent);
			loginUITaskBase.m_luaExportHelper.__callBase_ClearContextOnIntentChange(newIntent);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06015D8E RID: 89486 RVA: 0x005A5564 File Offset: 0x005A3764
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int __callBase_ClearContextOnUpdateViewEnd(IntPtr l)
	{
		int result;
		try
		{
			LoginUITaskBase loginUITaskBase = (LoginUITaskBase)LuaObject.checkSelf(l);
			loginUITaskBase.m_luaExportHelper.__callBase_ClearContextOnUpdateViewEnd();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06015D8F RID: 89487 RVA: 0x005A55B8 File Offset: 0x005A37B8
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int __callBase_EnableUIInput(IntPtr l)
	{
		int result;
		try
		{
			LoginUITaskBase loginUITaskBase = (LoginUITaskBase)LuaObject.checkSelf(l);
			bool isEnable;
			LuaObject.checkType(l, 2, out isEnable);
			bool? isGlobalEnable;
			LuaObject.checkNullable<bool>(l, 3, out isGlobalEnable);
			loginUITaskBase.m_luaExportHelper.__callBase_EnableUIInput(isEnable, isGlobalEnable);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06015D90 RID: 89488 RVA: 0x005A5624 File Offset: 0x005A3824
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int __callBase_GetLayerDescByName(IntPtr l)
	{
		int result;
		try
		{
			LoginUITaskBase loginUITaskBase = (LoginUITaskBase)LuaObject.checkSelf(l);
			string name;
			LuaObject.checkType(l, 2, out name);
			UITaskBase.LayerDesc o = loginUITaskBase.m_luaExportHelper.__callBase_GetLayerDescByName(name);
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

	// Token: 0x06015D91 RID: 89489 RVA: 0x005A568C File Offset: 0x005A388C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_GetLayerByName(IntPtr l)
	{
		int result;
		try
		{
			LoginUITaskBase loginUITaskBase = (LoginUITaskBase)LuaObject.checkSelf(l);
			string name;
			LuaObject.checkType(l, 2, out name);
			SceneLayerBase o = loginUITaskBase.m_luaExportHelper.__callBase_GetLayerByName(name);
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

	// Token: 0x06015D92 RID: 89490 RVA: 0x005A56F4 File Offset: 0x005A38F4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_RegisterModesDefine(IntPtr l)
	{
		int result;
		try
		{
			LoginUITaskBase loginUITaskBase = (LoginUITaskBase)LuaObject.checkSelf(l);
			string defaultMode;
			LuaObject.checkType(l, 2, out defaultMode);
			string[] modes;
			LuaObject.checkArray<string>(l, 3, out modes);
			loginUITaskBase.m_luaExportHelper.__callBase_RegisterModesDefine(defaultMode, modes);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06015D93 RID: 89491 RVA: 0x005A5760 File Offset: 0x005A3960
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_SetCurrentMode(IntPtr l)
	{
		int result;
		try
		{
			LoginUITaskBase loginUITaskBase = (LoginUITaskBase)LuaObject.checkSelf(l);
			string mode;
			LuaObject.checkType(l, 2, out mode);
			bool b = loginUITaskBase.m_luaExportHelper.__callBase_SetCurrentMode(mode);
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

	// Token: 0x06015D94 RID: 89492 RVA: 0x005A57C8 File Offset: 0x005A39C8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_SetIsNeedPauseTimeOut(IntPtr l)
	{
		int result;
		try
		{
			LoginUITaskBase loginUITaskBase = (LoginUITaskBase)LuaObject.checkSelf(l);
			bool isNeed;
			LuaObject.checkType(l, 2, out isNeed);
			loginUITaskBase.m_luaExportHelper.__callBase_SetIsNeedPauseTimeOut(isNeed);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06015D95 RID: 89493 RVA: 0x005A5824 File Offset: 0x005A3A24
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_OnTick(IntPtr l)
	{
		int result;
		try
		{
			LoginUITaskBase loginUITaskBase = (LoginUITaskBase)LuaObject.checkSelf(l);
			loginUITaskBase.m_luaExportHelper.__callBase_OnTick();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06015D96 RID: 89494 RVA: 0x005A5878 File Offset: 0x005A3A78
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_PostDelayTimeExecuteAction(IntPtr l)
	{
		int result;
		try
		{
			LoginUITaskBase loginUITaskBase = (LoginUITaskBase)LuaObject.checkSelf(l);
			Action action;
			LuaObject.checkDelegate<Action>(l, 2, out action);
			float delaySeconds;
			LuaObject.checkType(l, 3, out delaySeconds);
			loginUITaskBase.m_luaExportHelper.__callBase_PostDelayTimeExecuteAction(action, delaySeconds);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06015D97 RID: 89495 RVA: 0x005A58E4 File Offset: 0x005A3AE4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_PostDelayTicksExecuteAction(IntPtr l)
	{
		int result;
		try
		{
			LoginUITaskBase loginUITaskBase = (LoginUITaskBase)LuaObject.checkSelf(l);
			Action action;
			LuaObject.checkDelegate<Action>(l, 2, out action);
			ulong delayTickCount;
			LuaObject.checkType(l, 3, out delayTickCount);
			loginUITaskBase.m_luaExportHelper.__callBase_PostDelayTicksExecuteAction(action, delayTickCount);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06015D98 RID: 89496 RVA: 0x005A5950 File Offset: 0x005A3B50
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_SetTag(IntPtr l)
	{
		int result;
		try
		{
			LoginUITaskBase loginUITaskBase = (LoginUITaskBase)LuaObject.checkSelf(l);
			string tag;
			LuaObject.checkType(l, 2, out tag);
			loginUITaskBase.m_luaExportHelper.__callBase_SetTag(tag);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06015D99 RID: 89497 RVA: 0x005A59AC File Offset: 0x005A3BAC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_HasTag(IntPtr l)
	{
		int result;
		try
		{
			LoginUITaskBase loginUITaskBase = (LoginUITaskBase)LuaObject.checkSelf(l);
			string tag;
			LuaObject.checkType(l, 2, out tag);
			bool b = loginUITaskBase.m_luaExportHelper.__callBase_HasTag(tag);
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

	// Token: 0x06015D9A RID: 89498 RVA: 0x005A5A14 File Offset: 0x005A3C14
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_loginTaskState(IntPtr l)
	{
		int result;
		try
		{
			LoginUITaskBase loginUITaskBase = (LoginUITaskBase)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushEnum(l, (int)loginUITaskBase.m_luaExportHelper.m_loginTaskState);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06015D9B RID: 89499 RVA: 0x005A5A6C File Offset: 0x005A3C6C
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_m_loginTaskState(IntPtr l)
	{
		int result;
		try
		{
			LoginUITaskBase loginUITaskBase = (LoginUITaskBase)LuaObject.checkSelf(l);
			LoginUITaskBase.LoginState loginTaskState;
			LuaObject.checkEnum<LoginUITaskBase.LoginState>(l, 2, out loginTaskState);
			loginUITaskBase.m_luaExportHelper.m_loginTaskState = loginTaskState;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06015D9C RID: 89500 RVA: 0x005A5AC8 File Offset: 0x005A3CC8
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_m_authLoginServerAddress(IntPtr l)
	{
		int result;
		try
		{
			LoginUITaskBase loginUITaskBase = (LoginUITaskBase)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, loginUITaskBase.m_luaExportHelper.m_authLoginServerAddress);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06015D9D RID: 89501 RVA: 0x005A5B20 File Offset: 0x005A3D20
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_authLoginServerAddress(IntPtr l)
	{
		int result;
		try
		{
			LoginUITaskBase loginUITaskBase = (LoginUITaskBase)LuaObject.checkSelf(l);
			string authLoginServerAddress;
			LuaObject.checkType(l, 2, out authLoginServerAddress);
			loginUITaskBase.m_luaExportHelper.m_authLoginServerAddress = authLoginServerAddress;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06015D9E RID: 89502 RVA: 0x005A5B7C File Offset: 0x005A3D7C
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_m_authLoginServerPort(IntPtr l)
	{
		int result;
		try
		{
			LoginUITaskBase loginUITaskBase = (LoginUITaskBase)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, loginUITaskBase.m_luaExportHelper.m_authLoginServerPort);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06015D9F RID: 89503 RVA: 0x005A5BD4 File Offset: 0x005A3DD4
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_m_authLoginServerPort(IntPtr l)
	{
		int result;
		try
		{
			LoginUITaskBase loginUITaskBase = (LoginUITaskBase)LuaObject.checkSelf(l);
			int authLoginServerPort;
			LuaObject.checkType(l, 2, out authLoginServerPort);
			loginUITaskBase.m_luaExportHelper.m_authLoginServerPort = authLoginServerPort;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06015DA0 RID: 89504 RVA: 0x005A5C30 File Offset: 0x005A3E30
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_m_authtoken(IntPtr l)
	{
		int result;
		try
		{
			LoginUITaskBase loginUITaskBase = (LoginUITaskBase)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, loginUITaskBase.m_luaExportHelper.m_authtoken);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06015DA1 RID: 89505 RVA: 0x005A5C88 File Offset: 0x005A3E88
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_m_authtoken(IntPtr l)
	{
		int result;
		try
		{
			LoginUITaskBase loginUITaskBase = (LoginUITaskBase)LuaObject.checkSelf(l);
			string authtoken;
			LuaObject.checkType(l, 2, out authtoken);
			loginUITaskBase.m_luaExportHelper.m_authtoken = authtoken;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06015DA2 RID: 89506 RVA: 0x005A5CE4 File Offset: 0x005A3EE4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_gameUserId(IntPtr l)
	{
		int result;
		try
		{
			LoginUITaskBase loginUITaskBase = (LoginUITaskBase)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, loginUITaskBase.m_luaExportHelper.m_gameUserId);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06015DA3 RID: 89507 RVA: 0x005A5D3C File Offset: 0x005A3F3C
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_m_gameUserId(IntPtr l)
	{
		int result;
		try
		{
			LoginUITaskBase loginUITaskBase = (LoginUITaskBase)LuaObject.checkSelf(l);
			string gameUserId;
			LuaObject.checkType(l, 2, out gameUserId);
			loginUITaskBase.m_luaExportHelper.m_gameUserId = gameUserId;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06015DA4 RID: 89508 RVA: 0x005A5D98 File Offset: 0x005A3F98
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_loginChannelId(IntPtr l)
	{
		int result;
		try
		{
			LoginUITaskBase loginUITaskBase = (LoginUITaskBase)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, loginUITaskBase.m_luaExportHelper.m_loginChannelId);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06015DA5 RID: 89509 RVA: 0x005A5DF0 File Offset: 0x005A3FF0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_loginChannelId(IntPtr l)
	{
		int result;
		try
		{
			LoginUITaskBase loginUITaskBase = (LoginUITaskBase)LuaObject.checkSelf(l);
			int loginChannelId;
			LuaObject.checkType(l, 2, out loginChannelId);
			loginUITaskBase.m_luaExportHelper.m_loginChannelId = loginChannelId;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06015DA6 RID: 89510 RVA: 0x005A5E4C File Offset: 0x005A404C
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_m_bornChannelId(IntPtr l)
	{
		int result;
		try
		{
			LoginUITaskBase loginUITaskBase = (LoginUITaskBase)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, loginUITaskBase.m_luaExportHelper.m_bornChannelId);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06015DA7 RID: 89511 RVA: 0x005A5EA4 File Offset: 0x005A40A4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_bornChannelId(IntPtr l)
	{
		int result;
		try
		{
			LoginUITaskBase loginUITaskBase = (LoginUITaskBase)LuaObject.checkSelf(l);
			int bornChannelId;
			LuaObject.checkType(l, 2, out bornChannelId);
			loginUITaskBase.m_luaExportHelper.m_bornChannelId = bornChannelId;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06015DA8 RID: 89512 RVA: 0x005A5F00 File Offset: 0x005A4100
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_m_lastSessionToken(IntPtr l)
	{
		int result;
		try
		{
			LoginUITaskBase loginUITaskBase = (LoginUITaskBase)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, loginUITaskBase.m_luaExportHelper.m_lastSessionToken);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06015DA9 RID: 89513 RVA: 0x005A5F58 File Offset: 0x005A4158
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_lastSessionToken(IntPtr l)
	{
		int result;
		try
		{
			LoginUITaskBase loginUITaskBase = (LoginUITaskBase)LuaObject.checkSelf(l);
			string lastSessionToken;
			LuaObject.checkType(l, 2, out lastSessionToken);
			loginUITaskBase.m_luaExportHelper.m_lastSessionToken = lastSessionToken;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06015DAA RID: 89514 RVA: 0x005A5FB4 File Offset: 0x005A41B4
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_m_isWaitingForMsgAck(IntPtr l)
	{
		int result;
		try
		{
			LoginUITaskBase loginUITaskBase = (LoginUITaskBase)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, loginUITaskBase.m_luaExportHelper.m_isWaitingForMsgAck);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06015DAB RID: 89515 RVA: 0x005A600C File Offset: 0x005A420C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_isWaitingForMsgAck(IntPtr l)
	{
		int result;
		try
		{
			LoginUITaskBase loginUITaskBase = (LoginUITaskBase)LuaObject.checkSelf(l);
			bool isWaitingForMsgAck;
			LuaObject.checkType(l, 2, out isWaitingForMsgAck);
			loginUITaskBase.m_luaExportHelper.m_isWaitingForMsgAck = isWaitingForMsgAck;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06015DAC RID: 89516 RVA: 0x005A6068 File Offset: 0x005A4268
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_m_timeOutTime(IntPtr l)
	{
		int result;
		try
		{
			LoginUITaskBase loginUITaskBase = (LoginUITaskBase)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, loginUITaskBase.m_luaExportHelper.m_timeOutTime);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06015DAD RID: 89517 RVA: 0x005A60C4 File Offset: 0x005A42C4
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_m_timeOutTime(IntPtr l)
	{
		int result;
		try
		{
			LoginUITaskBase loginUITaskBase = (LoginUITaskBase)LuaObject.checkSelf(l);
			DateTime timeOutTime;
			LuaObject.checkValueType<DateTime>(l, 2, out timeOutTime);
			loginUITaskBase.m_luaExportHelper.m_timeOutTime = timeOutTime;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06015DAE RID: 89518 RVA: 0x005A6120 File Offset: 0x005A4320
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_m_timeoutDelayTime(IntPtr l)
	{
		int result;
		try
		{
			LoginUITaskBase loginUITaskBase = (LoginUITaskBase)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, loginUITaskBase.m_luaExportHelper.m_timeoutDelayTime);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06015DAF RID: 89519 RVA: 0x005A6178 File Offset: 0x005A4378
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_m_timeoutDelayTime(IntPtr l)
	{
		int result;
		try
		{
			LoginUITaskBase loginUITaskBase = (LoginUITaskBase)LuaObject.checkSelf(l);
			float timeoutDelayTime;
			LuaObject.checkType(l, 2, out timeoutDelayTime);
			loginUITaskBase.m_luaExportHelper.m_timeoutDelayTime = timeoutDelayTime;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06015DB0 RID: 89520 RVA: 0x005A61D4 File Offset: 0x005A43D4
	[Preserve]
	public static void reg(IntPtr l)
	{
		LuaObject.getTypeTable(l, "BlackJack.BJFramework.Runtime.UI.LoginUITaskBase");
		if (Lua_BlackJack_BJFramework_Runtime_UI_LoginUITaskBase.<>f__mg$cache0 == null)
		{
			Lua_BlackJack_BJFramework_Runtime_UI_LoginUITaskBase.<>f__mg$cache0 = new LuaCSFunction(Lua_BlackJack_BJFramework_Runtime_UI_LoginUITaskBase.OnStop);
		}
		LuaObject.addMember(l, Lua_BlackJack_BJFramework_Runtime_UI_LoginUITaskBase.<>f__mg$cache0);
		if (Lua_BlackJack_BJFramework_Runtime_UI_LoginUITaskBase.<>f__mg$cache1 == null)
		{
			Lua_BlackJack_BJFramework_Runtime_UI_LoginUITaskBase.<>f__mg$cache1 = new LuaCSFunction(Lua_BlackJack_BJFramework_Runtime_UI_LoginUITaskBase.PostUpdateView);
		}
		LuaObject.addMember(l, Lua_BlackJack_BJFramework_Runtime_UI_LoginUITaskBase.<>f__mg$cache1);
		if (Lua_BlackJack_BJFramework_Runtime_UI_LoginUITaskBase.<>f__mg$cache2 == null)
		{
			Lua_BlackJack_BJFramework_Runtime_UI_LoginUITaskBase.<>f__mg$cache2 = new LuaCSFunction(Lua_BlackJack_BJFramework_Runtime_UI_LoginUITaskBase.IsSDKLogin);
		}
		LuaObject.addMember(l, Lua_BlackJack_BJFramework_Runtime_UI_LoginUITaskBase.<>f__mg$cache2);
		if (Lua_BlackJack_BJFramework_Runtime_UI_LoginUITaskBase.<>f__mg$cache3 == null)
		{
			Lua_BlackJack_BJFramework_Runtime_UI_LoginUITaskBase.<>f__mg$cache3 = new LuaCSFunction(Lua_BlackJack_BJFramework_Runtime_UI_LoginUITaskBase.IsEditorTestLogin);
		}
		LuaObject.addMember(l, Lua_BlackJack_BJFramework_Runtime_UI_LoginUITaskBase.<>f__mg$cache3);
		if (Lua_BlackJack_BJFramework_Runtime_UI_LoginUITaskBase.<>f__mg$cache4 == null)
		{
			Lua_BlackJack_BJFramework_Runtime_UI_LoginUITaskBase.<>f__mg$cache4 = new LuaCSFunction(Lua_BlackJack_BJFramework_Runtime_UI_LoginUITaskBase.StartInitSDK);
		}
		LuaObject.addMember(l, Lua_BlackJack_BJFramework_Runtime_UI_LoginUITaskBase.<>f__mg$cache4);
		if (Lua_BlackJack_BJFramework_Runtime_UI_LoginUITaskBase.<>f__mg$cache5 == null)
		{
			Lua_BlackJack_BJFramework_Runtime_UI_LoginUITaskBase.<>f__mg$cache5 = new LuaCSFunction(Lua_BlackJack_BJFramework_Runtime_UI_LoginUITaskBase.OnSDKInitEnd);
		}
		LuaObject.addMember(l, Lua_BlackJack_BJFramework_Runtime_UI_LoginUITaskBase.<>f__mg$cache5);
		if (Lua_BlackJack_BJFramework_Runtime_UI_LoginUITaskBase.<>f__mg$cache6 == null)
		{
			Lua_BlackJack_BJFramework_Runtime_UI_LoginUITaskBase.<>f__mg$cache6 = new LuaCSFunction(Lua_BlackJack_BJFramework_Runtime_UI_LoginUITaskBase.StartSDKLogin);
		}
		LuaObject.addMember(l, Lua_BlackJack_BJFramework_Runtime_UI_LoginUITaskBase.<>f__mg$cache6);
		if (Lua_BlackJack_BJFramework_Runtime_UI_LoginUITaskBase.<>f__mg$cache7 == null)
		{
			Lua_BlackJack_BJFramework_Runtime_UI_LoginUITaskBase.<>f__mg$cache7 = new LuaCSFunction(Lua_BlackJack_BJFramework_Runtime_UI_LoginUITaskBase.OnSDKLoginEnd);
		}
		LuaObject.addMember(l, Lua_BlackJack_BJFramework_Runtime_UI_LoginUITaskBase.<>f__mg$cache7);
		if (Lua_BlackJack_BJFramework_Runtime_UI_LoginUITaskBase.<>f__mg$cache8 == null)
		{
			Lua_BlackJack_BJFramework_Runtime_UI_LoginUITaskBase.<>f__mg$cache8 = new LuaCSFunction(Lua_BlackJack_BJFramework_Runtime_UI_LoginUITaskBase.PostSDKLogin);
		}
		LuaObject.addMember(l, Lua_BlackJack_BJFramework_Runtime_UI_LoginUITaskBase.<>f__mg$cache8);
		if (Lua_BlackJack_BJFramework_Runtime_UI_LoginUITaskBase.<>f__mg$cache9 == null)
		{
			Lua_BlackJack_BJFramework_Runtime_UI_LoginUITaskBase.<>f__mg$cache9 = new LuaCSFunction(Lua_BlackJack_BJFramework_Runtime_UI_LoginUITaskBase.IsNeedSelectServer);
		}
		LuaObject.addMember(l, Lua_BlackJack_BJFramework_Runtime_UI_LoginUITaskBase.<>f__mg$cache9);
		if (Lua_BlackJack_BJFramework_Runtime_UI_LoginUITaskBase.<>f__mg$cacheA == null)
		{
			Lua_BlackJack_BJFramework_Runtime_UI_LoginUITaskBase.<>f__mg$cacheA = new LuaCSFunction(Lua_BlackJack_BJFramework_Runtime_UI_LoginUITaskBase.LaunchServerListUI);
		}
		LuaObject.addMember(l, Lua_BlackJack_BJFramework_Runtime_UI_LoginUITaskBase.<>f__mg$cacheA);
		if (Lua_BlackJack_BJFramework_Runtime_UI_LoginUITaskBase.<>f__mg$cacheB == null)
		{
			Lua_BlackJack_BJFramework_Runtime_UI_LoginUITaskBase.<>f__mg$cacheB = new LuaCSFunction(Lua_BlackJack_BJFramework_Runtime_UI_LoginUITaskBase.DownloadServerList);
		}
		LuaObject.addMember(l, Lua_BlackJack_BJFramework_Runtime_UI_LoginUITaskBase.<>f__mg$cacheB);
		if (Lua_BlackJack_BJFramework_Runtime_UI_LoginUITaskBase.<>f__mg$cacheC == null)
		{
			Lua_BlackJack_BJFramework_Runtime_UI_LoginUITaskBase.<>f__mg$cacheC = new LuaCSFunction(Lua_BlackJack_BJFramework_Runtime_UI_LoginUITaskBase.OnDownloadServerListEnd);
		}
		LuaObject.addMember(l, Lua_BlackJack_BJFramework_Runtime_UI_LoginUITaskBase.<>f__mg$cacheC);
		if (Lua_BlackJack_BJFramework_Runtime_UI_LoginUITaskBase.<>f__mg$cacheD == null)
		{
			Lua_BlackJack_BJFramework_Runtime_UI_LoginUITaskBase.<>f__mg$cacheD = new LuaCSFunction(Lua_BlackJack_BJFramework_Runtime_UI_LoginUITaskBase.ShowServerListUI);
		}
		LuaObject.addMember(l, Lua_BlackJack_BJFramework_Runtime_UI_LoginUITaskBase.<>f__mg$cacheD);
		if (Lua_BlackJack_BJFramework_Runtime_UI_LoginUITaskBase.<>f__mg$cacheE == null)
		{
			Lua_BlackJack_BJFramework_Runtime_UI_LoginUITaskBase.<>f__mg$cacheE = new LuaCSFunction(Lua_BlackJack_BJFramework_Runtime_UI_LoginUITaskBase.OnGameServerConfirmed);
		}
		LuaObject.addMember(l, Lua_BlackJack_BJFramework_Runtime_UI_LoginUITaskBase.<>f__mg$cacheE);
		if (Lua_BlackJack_BJFramework_Runtime_UI_LoginUITaskBase.<>f__mg$cacheF == null)
		{
			Lua_BlackJack_BJFramework_Runtime_UI_LoginUITaskBase.<>f__mg$cacheF = new LuaCSFunction(Lua_BlackJack_BJFramework_Runtime_UI_LoginUITaskBase.InitServerCtxByServerID);
		}
		LuaObject.addMember(l, Lua_BlackJack_BJFramework_Runtime_UI_LoginUITaskBase.<>f__mg$cacheF);
		if (Lua_BlackJack_BJFramework_Runtime_UI_LoginUITaskBase.<>f__mg$cache10 == null)
		{
			Lua_BlackJack_BJFramework_Runtime_UI_LoginUITaskBase.<>f__mg$cache10 = new LuaCSFunction(Lua_BlackJack_BJFramework_Runtime_UI_LoginUITaskBase.GetLastLoginedServerID);
		}
		LuaObject.addMember(l, Lua_BlackJack_BJFramework_Runtime_UI_LoginUITaskBase.<>f__mg$cache10);
		if (Lua_BlackJack_BJFramework_Runtime_UI_LoginUITaskBase.<>f__mg$cache11 == null)
		{
			Lua_BlackJack_BJFramework_Runtime_UI_LoginUITaskBase.<>f__mg$cache11 = new LuaCSFunction(Lua_BlackJack_BJFramework_Runtime_UI_LoginUITaskBase.LaunchEnterGameUI);
		}
		LuaObject.addMember(l, Lua_BlackJack_BJFramework_Runtime_UI_LoginUITaskBase.<>f__mg$cache11);
		if (Lua_BlackJack_BJFramework_Runtime_UI_LoginUITaskBase.<>f__mg$cache12 == null)
		{
			Lua_BlackJack_BJFramework_Runtime_UI_LoginUITaskBase.<>f__mg$cache12 = new LuaCSFunction(Lua_BlackJack_BJFramework_Runtime_UI_LoginUITaskBase.LaunchEnterGameUIWithGameSettingTokenAndServer);
		}
		LuaObject.addMember(l, Lua_BlackJack_BJFramework_Runtime_UI_LoginUITaskBase.<>f__mg$cache12);
		if (Lua_BlackJack_BJFramework_Runtime_UI_LoginUITaskBase.<>f__mg$cache13 == null)
		{
			Lua_BlackJack_BJFramework_Runtime_UI_LoginUITaskBase.<>f__mg$cache13 = new LuaCSFunction(Lua_BlackJack_BJFramework_Runtime_UI_LoginUITaskBase.LaunchEnterGameUIWithUIInputAccountAndServer);
		}
		LuaObject.addMember(l, Lua_BlackJack_BJFramework_Runtime_UI_LoginUITaskBase.<>f__mg$cache13);
		if (Lua_BlackJack_BJFramework_Runtime_UI_LoginUITaskBase.<>f__mg$cache14 == null)
		{
			Lua_BlackJack_BJFramework_Runtime_UI_LoginUITaskBase.<>f__mg$cache14 = new LuaCSFunction(Lua_BlackJack_BJFramework_Runtime_UI_LoginUITaskBase.LoadLastLoginWithUIInputInfo);
		}
		LuaObject.addMember(l, Lua_BlackJack_BJFramework_Runtime_UI_LoginUITaskBase.<>f__mg$cache14);
		if (Lua_BlackJack_BJFramework_Runtime_UI_LoginUITaskBase.<>f__mg$cache15 == null)
		{
			Lua_BlackJack_BJFramework_Runtime_UI_LoginUITaskBase.<>f__mg$cache15 = new LuaCSFunction(Lua_BlackJack_BJFramework_Runtime_UI_LoginUITaskBase.DownloadGameServerLoginAnnouncement);
		}
		LuaObject.addMember(l, Lua_BlackJack_BJFramework_Runtime_UI_LoginUITaskBase.<>f__mg$cache15);
		if (Lua_BlackJack_BJFramework_Runtime_UI_LoginUITaskBase.<>f__mg$cache16 == null)
		{
			Lua_BlackJack_BJFramework_Runtime_UI_LoginUITaskBase.<>f__mg$cache16 = new LuaCSFunction(Lua_BlackJack_BJFramework_Runtime_UI_LoginUITaskBase.OnDownloadGameServerLoginAnnouncementEnd);
		}
		LuaObject.addMember(l, Lua_BlackJack_BJFramework_Runtime_UI_LoginUITaskBase.<>f__mg$cache16);
		if (Lua_BlackJack_BJFramework_Runtime_UI_LoginUITaskBase.<>f__mg$cache17 == null)
		{
			Lua_BlackJack_BJFramework_Runtime_UI_LoginUITaskBase.<>f__mg$cache17 = new LuaCSFunction(Lua_BlackJack_BJFramework_Runtime_UI_LoginUITaskBase.ShowGameServerLoginAnnouncementUI);
		}
		LuaObject.addMember(l, Lua_BlackJack_BJFramework_Runtime_UI_LoginUITaskBase.<>f__mg$cache17);
		if (Lua_BlackJack_BJFramework_Runtime_UI_LoginUITaskBase.<>f__mg$cache18 == null)
		{
			Lua_BlackJack_BJFramework_Runtime_UI_LoginUITaskBase.<>f__mg$cache18 = new LuaCSFunction(Lua_BlackJack_BJFramework_Runtime_UI_LoginUITaskBase.ShowEnterGameUI);
		}
		LuaObject.addMember(l, Lua_BlackJack_BJFramework_Runtime_UI_LoginUITaskBase.<>f__mg$cache18);
		if (Lua_BlackJack_BJFramework_Runtime_UI_LoginUITaskBase.<>f__mg$cache19 == null)
		{
			Lua_BlackJack_BJFramework_Runtime_UI_LoginUITaskBase.<>f__mg$cache19 = new LuaCSFunction(Lua_BlackJack_BJFramework_Runtime_UI_LoginUITaskBase.OnEnterGameConfirmed);
		}
		LuaObject.addMember(l, Lua_BlackJack_BJFramework_Runtime_UI_LoginUITaskBase.<>f__mg$cache19);
		if (Lua_BlackJack_BJFramework_Runtime_UI_LoginUITaskBase.<>f__mg$cache1A == null)
		{
			Lua_BlackJack_BJFramework_Runtime_UI_LoginUITaskBase.<>f__mg$cache1A = new LuaCSFunction(Lua_BlackJack_BJFramework_Runtime_UI_LoginUITaskBase.StartLoginAgentLogin);
		}
		LuaObject.addMember(l, Lua_BlackJack_BJFramework_Runtime_UI_LoginUITaskBase.<>f__mg$cache1A);
		if (Lua_BlackJack_BJFramework_Runtime_UI_LoginUITaskBase.<>f__mg$cache1B == null)
		{
			Lua_BlackJack_BJFramework_Runtime_UI_LoginUITaskBase.<>f__mg$cache1B = new LuaCSFunction(Lua_BlackJack_BJFramework_Runtime_UI_LoginUITaskBase.LoginAgentLoginEnd);
		}
		LuaObject.addMember(l, Lua_BlackJack_BJFramework_Runtime_UI_LoginUITaskBase.<>f__mg$cache1B);
		if (Lua_BlackJack_BJFramework_Runtime_UI_LoginUITaskBase.<>f__mg$cache1C == null)
		{
			Lua_BlackJack_BJFramework_Runtime_UI_LoginUITaskBase.<>f__mg$cache1C = new LuaCSFunction(Lua_BlackJack_BJFramework_Runtime_UI_LoginUITaskBase.StartAuthLogin);
		}
		LuaObject.addMember(l, Lua_BlackJack_BJFramework_Runtime_UI_LoginUITaskBase.<>f__mg$cache1C);
		if (Lua_BlackJack_BJFramework_Runtime_UI_LoginUITaskBase.<>f__mg$cache1D == null)
		{
			Lua_BlackJack_BJFramework_Runtime_UI_LoginUITaskBase.<>f__mg$cache1D = new LuaCSFunction(Lua_BlackJack_BJFramework_Runtime_UI_LoginUITaskBase.StartSessionLogin);
		}
		LuaObject.addMember(l, Lua_BlackJack_BJFramework_Runtime_UI_LoginUITaskBase.<>f__mg$cache1D);
		if (Lua_BlackJack_BJFramework_Runtime_UI_LoginUITaskBase.<>f__mg$cache1E == null)
		{
			Lua_BlackJack_BJFramework_Runtime_UI_LoginUITaskBase.<>f__mg$cache1E = new LuaCSFunction(Lua_BlackJack_BJFramework_Runtime_UI_LoginUITaskBase.StartPlayerInfoInitReq);
		}
		LuaObject.addMember(l, Lua_BlackJack_BJFramework_Runtime_UI_LoginUITaskBase.<>f__mg$cache1E);
		if (Lua_BlackJack_BJFramework_Runtime_UI_LoginUITaskBase.<>f__mg$cache1F == null)
		{
			Lua_BlackJack_BJFramework_Runtime_UI_LoginUITaskBase.<>f__mg$cache1F = new LuaCSFunction(Lua_BlackJack_BJFramework_Runtime_UI_LoginUITaskBase.LauncheMainUI);
		}
		LuaObject.addMember(l, Lua_BlackJack_BJFramework_Runtime_UI_LoginUITaskBase.<>f__mg$cache1F);
		if (Lua_BlackJack_BJFramework_Runtime_UI_LoginUITaskBase.<>f__mg$cache20 == null)
		{
			Lua_BlackJack_BJFramework_Runtime_UI_LoginUITaskBase.<>f__mg$cache20 = new LuaCSFunction(Lua_BlackJack_BJFramework_Runtime_UI_LoginUITaskBase.OnWaitingMsgAckOutTime);
		}
		LuaObject.addMember(l, Lua_BlackJack_BJFramework_Runtime_UI_LoginUITaskBase.<>f__mg$cache20);
		if (Lua_BlackJack_BJFramework_Runtime_UI_LoginUITaskBase.<>f__mg$cache21 == null)
		{
			Lua_BlackJack_BJFramework_Runtime_UI_LoginUITaskBase.<>f__mg$cache21 = new LuaCSFunction(Lua_BlackJack_BJFramework_Runtime_UI_LoginUITaskBase.StartWaitingMsgAck);
		}
		LuaObject.addMember(l, Lua_BlackJack_BJFramework_Runtime_UI_LoginUITaskBase.<>f__mg$cache21);
		if (Lua_BlackJack_BJFramework_Runtime_UI_LoginUITaskBase.<>f__mg$cache22 == null)
		{
			Lua_BlackJack_BJFramework_Runtime_UI_LoginUITaskBase.<>f__mg$cache22 = new LuaCSFunction(Lua_BlackJack_BJFramework_Runtime_UI_LoginUITaskBase.StopWaitingMsgAck);
		}
		LuaObject.addMember(l, Lua_BlackJack_BJFramework_Runtime_UI_LoginUITaskBase.<>f__mg$cache22);
		if (Lua_BlackJack_BJFramework_Runtime_UI_LoginUITaskBase.<>f__mg$cache23 == null)
		{
			Lua_BlackJack_BJFramework_Runtime_UI_LoginUITaskBase.<>f__mg$cache23 = new LuaCSFunction(Lua_BlackJack_BJFramework_Runtime_UI_LoginUITaskBase.ClearGameServerLoginState);
		}
		LuaObject.addMember(l, Lua_BlackJack_BJFramework_Runtime_UI_LoginUITaskBase.<>f__mg$cache23);
		if (Lua_BlackJack_BJFramework_Runtime_UI_LoginUITaskBase.<>f__mg$cache24 == null)
		{
			Lua_BlackJack_BJFramework_Runtime_UI_LoginUITaskBase.<>f__mg$cache24 = new LuaCSFunction(Lua_BlackJack_BJFramework_Runtime_UI_LoginUITaskBase.OnTick);
		}
		LuaObject.addMember(l, Lua_BlackJack_BJFramework_Runtime_UI_LoginUITaskBase.<>f__mg$cache24);
		if (Lua_BlackJack_BJFramework_Runtime_UI_LoginUITaskBase.<>f__mg$cache25 == null)
		{
			Lua_BlackJack_BJFramework_Runtime_UI_LoginUITaskBase.<>f__mg$cache25 = new LuaCSFunction(Lua_BlackJack_BJFramework_Runtime_UI_LoginUITaskBase.OnGameServerConnected);
		}
		LuaObject.addMember(l, Lua_BlackJack_BJFramework_Runtime_UI_LoginUITaskBase.<>f__mg$cache25);
		if (Lua_BlackJack_BJFramework_Runtime_UI_LoginUITaskBase.<>f__mg$cache26 == null)
		{
			Lua_BlackJack_BJFramework_Runtime_UI_LoginUITaskBase.<>f__mg$cache26 = new LuaCSFunction(Lua_BlackJack_BJFramework_Runtime_UI_LoginUITaskBase.OnGameServerDisconnected);
		}
		LuaObject.addMember(l, Lua_BlackJack_BJFramework_Runtime_UI_LoginUITaskBase.<>f__mg$cache26);
		if (Lua_BlackJack_BJFramework_Runtime_UI_LoginUITaskBase.<>f__mg$cache27 == null)
		{
			Lua_BlackJack_BJFramework_Runtime_UI_LoginUITaskBase.<>f__mg$cache27 = new LuaCSFunction(Lua_BlackJack_BJFramework_Runtime_UI_LoginUITaskBase.OnGameServerNetworkError);
		}
		LuaObject.addMember(l, Lua_BlackJack_BJFramework_Runtime_UI_LoginUITaskBase.<>f__mg$cache27);
		if (Lua_BlackJack_BJFramework_Runtime_UI_LoginUITaskBase.<>f__mg$cache28 == null)
		{
			Lua_BlackJack_BJFramework_Runtime_UI_LoginUITaskBase.<>f__mg$cache28 = new LuaCSFunction(Lua_BlackJack_BJFramework_Runtime_UI_LoginUITaskBase.OnLoginByAuthTokenAck);
		}
		LuaObject.addMember(l, Lua_BlackJack_BJFramework_Runtime_UI_LoginUITaskBase.<>f__mg$cache28);
		if (Lua_BlackJack_BJFramework_Runtime_UI_LoginUITaskBase.<>f__mg$cache29 == null)
		{
			Lua_BlackJack_BJFramework_Runtime_UI_LoginUITaskBase.<>f__mg$cache29 = new LuaCSFunction(Lua_BlackJack_BJFramework_Runtime_UI_LoginUITaskBase.OnLoginBySessionTokenAck);
		}
		LuaObject.addMember(l, Lua_BlackJack_BJFramework_Runtime_UI_LoginUITaskBase.<>f__mg$cache29);
		if (Lua_BlackJack_BJFramework_Runtime_UI_LoginUITaskBase.<>f__mg$cache2A == null)
		{
			Lua_BlackJack_BJFramework_Runtime_UI_LoginUITaskBase.<>f__mg$cache2A = new LuaCSFunction(Lua_BlackJack_BJFramework_Runtime_UI_LoginUITaskBase.OnConfigDataMD5InfoNtf);
		}
		LuaObject.addMember(l, Lua_BlackJack_BJFramework_Runtime_UI_LoginUITaskBase.<>f__mg$cache2A);
		if (Lua_BlackJack_BJFramework_Runtime_UI_LoginUITaskBase.<>f__mg$cache2B == null)
		{
			Lua_BlackJack_BJFramework_Runtime_UI_LoginUITaskBase.<>f__mg$cache2B = new LuaCSFunction(Lua_BlackJack_BJFramework_Runtime_UI_LoginUITaskBase.OnPlayerInfoInitEnd);
		}
		LuaObject.addMember(l, Lua_BlackJack_BJFramework_Runtime_UI_LoginUITaskBase.<>f__mg$cache2B);
		if (Lua_BlackJack_BJFramework_Runtime_UI_LoginUITaskBase.<>f__mg$cache2C == null)
		{
			Lua_BlackJack_BJFramework_Runtime_UI_LoginUITaskBase.<>f__mg$cache2C = new LuaCSFunction(Lua_BlackJack_BJFramework_Runtime_UI_LoginUITaskBase.RegisterNetEvent);
		}
		LuaObject.addMember(l, Lua_BlackJack_BJFramework_Runtime_UI_LoginUITaskBase.<>f__mg$cache2C);
		if (Lua_BlackJack_BJFramework_Runtime_UI_LoginUITaskBase.<>f__mg$cache2D == null)
		{
			Lua_BlackJack_BJFramework_Runtime_UI_LoginUITaskBase.<>f__mg$cache2D = new LuaCSFunction(Lua_BlackJack_BJFramework_Runtime_UI_LoginUITaskBase.UnRegisterNetEvent);
		}
		LuaObject.addMember(l, Lua_BlackJack_BJFramework_Runtime_UI_LoginUITaskBase.<>f__mg$cache2D);
		if (Lua_BlackJack_BJFramework_Runtime_UI_LoginUITaskBase.<>f__mg$cache2E == null)
		{
			Lua_BlackJack_BJFramework_Runtime_UI_LoginUITaskBase.<>f__mg$cache2E = new LuaCSFunction(Lua_BlackJack_BJFramework_Runtime_UI_LoginUITaskBase.__callBase_InitlizeBeforeManagerStartIt);
		}
		LuaObject.addMember(l, Lua_BlackJack_BJFramework_Runtime_UI_LoginUITaskBase.<>f__mg$cache2E);
		if (Lua_BlackJack_BJFramework_Runtime_UI_LoginUITaskBase.<>f__mg$cache2F == null)
		{
			Lua_BlackJack_BJFramework_Runtime_UI_LoginUITaskBase.<>f__mg$cache2F = new LuaCSFunction(Lua_BlackJack_BJFramework_Runtime_UI_LoginUITaskBase.__callBase_PrepareForStartOrResume);
		}
		LuaObject.addMember(l, Lua_BlackJack_BJFramework_Runtime_UI_LoginUITaskBase.<>f__mg$cache2F);
		if (Lua_BlackJack_BJFramework_Runtime_UI_LoginUITaskBase.<>f__mg$cache30 == null)
		{
			Lua_BlackJack_BJFramework_Runtime_UI_LoginUITaskBase.<>f__mg$cache30 = new LuaCSFunction(Lua_BlackJack_BJFramework_Runtime_UI_LoginUITaskBase.__callBase_OnStart);
		}
		LuaObject.addMember(l, Lua_BlackJack_BJFramework_Runtime_UI_LoginUITaskBase.<>f__mg$cache30);
		if (Lua_BlackJack_BJFramework_Runtime_UI_LoginUITaskBase.<>f__mg$cache31 == null)
		{
			Lua_BlackJack_BJFramework_Runtime_UI_LoginUITaskBase.<>f__mg$cache31 = new LuaCSFunction(Lua_BlackJack_BJFramework_Runtime_UI_LoginUITaskBase.__callBase_GetPipeLineCtx);
		}
		LuaObject.addMember(l, Lua_BlackJack_BJFramework_Runtime_UI_LoginUITaskBase.<>f__mg$cache31);
		if (Lua_BlackJack_BJFramework_Runtime_UI_LoginUITaskBase.<>f__mg$cache32 == null)
		{
			Lua_BlackJack_BJFramework_Runtime_UI_LoginUITaskBase.<>f__mg$cache32 = new LuaCSFunction(Lua_BlackJack_BJFramework_Runtime_UI_LoginUITaskBase.__callBase_CreatePipeLineCtx);
		}
		LuaObject.addMember(l, Lua_BlackJack_BJFramework_Runtime_UI_LoginUITaskBase.<>f__mg$cache32);
		if (Lua_BlackJack_BJFramework_Runtime_UI_LoginUITaskBase.<>f__mg$cache33 == null)
		{
			Lua_BlackJack_BJFramework_Runtime_UI_LoginUITaskBase.<>f__mg$cache33 = new LuaCSFunction(Lua_BlackJack_BJFramework_Runtime_UI_LoginUITaskBase.__callBase_OnStop);
		}
		LuaObject.addMember(l, Lua_BlackJack_BJFramework_Runtime_UI_LoginUITaskBase.<>f__mg$cache33);
		if (Lua_BlackJack_BJFramework_Runtime_UI_LoginUITaskBase.<>f__mg$cache34 == null)
		{
			Lua_BlackJack_BJFramework_Runtime_UI_LoginUITaskBase.<>f__mg$cache34 = new LuaCSFunction(Lua_BlackJack_BJFramework_Runtime_UI_LoginUITaskBase.__callBase_OnPause);
		}
		LuaObject.addMember(l, Lua_BlackJack_BJFramework_Runtime_UI_LoginUITaskBase.<>f__mg$cache34);
		if (Lua_BlackJack_BJFramework_Runtime_UI_LoginUITaskBase.<>f__mg$cache35 == null)
		{
			Lua_BlackJack_BJFramework_Runtime_UI_LoginUITaskBase.<>f__mg$cache35 = new LuaCSFunction(Lua_BlackJack_BJFramework_Runtime_UI_LoginUITaskBase.__callBase_OnResume);
		}
		LuaObject.addMember(l, Lua_BlackJack_BJFramework_Runtime_UI_LoginUITaskBase.<>f__mg$cache35);
		if (Lua_BlackJack_BJFramework_Runtime_UI_LoginUITaskBase.<>f__mg$cache36 == null)
		{
			Lua_BlackJack_BJFramework_Runtime_UI_LoginUITaskBase.<>f__mg$cache36 = new LuaCSFunction(Lua_BlackJack_BJFramework_Runtime_UI_LoginUITaskBase.__callBase_OnNewIntent);
		}
		LuaObject.addMember(l, Lua_BlackJack_BJFramework_Runtime_UI_LoginUITaskBase.<>f__mg$cache36);
		if (Lua_BlackJack_BJFramework_Runtime_UI_LoginUITaskBase.<>f__mg$cache37 == null)
		{
			Lua_BlackJack_BJFramework_Runtime_UI_LoginUITaskBase.<>f__mg$cache37 = new LuaCSFunction(Lua_BlackJack_BJFramework_Runtime_UI_LoginUITaskBase.__callBase_StartUpdatePipeLine);
		}
		LuaObject.addMember(l, Lua_BlackJack_BJFramework_Runtime_UI_LoginUITaskBase.<>f__mg$cache37);
		if (Lua_BlackJack_BJFramework_Runtime_UI_LoginUITaskBase.<>f__mg$cache38 == null)
		{
			Lua_BlackJack_BJFramework_Runtime_UI_LoginUITaskBase.<>f__mg$cache38 = new LuaCSFunction(Lua_BlackJack_BJFramework_Runtime_UI_LoginUITaskBase.__callBase_NeedSkipUpdatePipeLine);
		}
		LuaObject.addMember(l, Lua_BlackJack_BJFramework_Runtime_UI_LoginUITaskBase.<>f__mg$cache38);
		if (Lua_BlackJack_BJFramework_Runtime_UI_LoginUITaskBase.<>f__mg$cache39 == null)
		{
			Lua_BlackJack_BJFramework_Runtime_UI_LoginUITaskBase.<>f__mg$cache39 = new LuaCSFunction(Lua_BlackJack_BJFramework_Runtime_UI_LoginUITaskBase.__callBase_IsNeedUpdateDataCache);
		}
		LuaObject.addMember(l, Lua_BlackJack_BJFramework_Runtime_UI_LoginUITaskBase.<>f__mg$cache39);
		if (Lua_BlackJack_BJFramework_Runtime_UI_LoginUITaskBase.<>f__mg$cache3A == null)
		{
			Lua_BlackJack_BJFramework_Runtime_UI_LoginUITaskBase.<>f__mg$cache3A = new LuaCSFunction(Lua_BlackJack_BJFramework_Runtime_UI_LoginUITaskBase.__callBase_UpdateDataCache);
		}
		LuaObject.addMember(l, Lua_BlackJack_BJFramework_Runtime_UI_LoginUITaskBase.<>f__mg$cache3A);
		if (Lua_BlackJack_BJFramework_Runtime_UI_LoginUITaskBase.<>f__mg$cache3B == null)
		{
			Lua_BlackJack_BJFramework_Runtime_UI_LoginUITaskBase.<>f__mg$cache3B = new LuaCSFunction(Lua_BlackJack_BJFramework_Runtime_UI_LoginUITaskBase.__callBase_IsNeedLoadStaticRes);
		}
		LuaObject.addMember(l, Lua_BlackJack_BJFramework_Runtime_UI_LoginUITaskBase.<>f__mg$cache3B);
		if (Lua_BlackJack_BJFramework_Runtime_UI_LoginUITaskBase.<>f__mg$cache3C == null)
		{
			Lua_BlackJack_BJFramework_Runtime_UI_LoginUITaskBase.<>f__mg$cache3C = new LuaCSFunction(Lua_BlackJack_BJFramework_Runtime_UI_LoginUITaskBase.__callBase_StartLoadStaticRes);
		}
		LuaObject.addMember(l, Lua_BlackJack_BJFramework_Runtime_UI_LoginUITaskBase.<>f__mg$cache3C);
		if (Lua_BlackJack_BJFramework_Runtime_UI_LoginUITaskBase.<>f__mg$cache3D == null)
		{
			Lua_BlackJack_BJFramework_Runtime_UI_LoginUITaskBase.<>f__mg$cache3D = new LuaCSFunction(Lua_BlackJack_BJFramework_Runtime_UI_LoginUITaskBase.__callBase_CheckLayerDescArray);
		}
		LuaObject.addMember(l, Lua_BlackJack_BJFramework_Runtime_UI_LoginUITaskBase.<>f__mg$cache3D);
		if (Lua_BlackJack_BJFramework_Runtime_UI_LoginUITaskBase.<>f__mg$cache3E == null)
		{
			Lua_BlackJack_BJFramework_Runtime_UI_LoginUITaskBase.<>f__mg$cache3E = new LuaCSFunction(Lua_BlackJack_BJFramework_Runtime_UI_LoginUITaskBase.__callBase_OnLoadStaticResCompleted);
		}
		LuaObject.addMember(l, Lua_BlackJack_BJFramework_Runtime_UI_LoginUITaskBase.<>f__mg$cache3E);
		if (Lua_BlackJack_BJFramework_Runtime_UI_LoginUITaskBase.<>f__mg$cache3F == null)
		{
			Lua_BlackJack_BJFramework_Runtime_UI_LoginUITaskBase.<>f__mg$cache3F = new LuaCSFunction(Lua_BlackJack_BJFramework_Runtime_UI_LoginUITaskBase.__callBase_IsNeedLoadDynamicRes);
		}
		LuaObject.addMember(l, Lua_BlackJack_BJFramework_Runtime_UI_LoginUITaskBase.<>f__mg$cache3F);
		if (Lua_BlackJack_BJFramework_Runtime_UI_LoginUITaskBase.<>f__mg$cache40 == null)
		{
			Lua_BlackJack_BJFramework_Runtime_UI_LoginUITaskBase.<>f__mg$cache40 = new LuaCSFunction(Lua_BlackJack_BJFramework_Runtime_UI_LoginUITaskBase.__callBase_StartLoadDynamicRes);
		}
		LuaObject.addMember(l, Lua_BlackJack_BJFramework_Runtime_UI_LoginUITaskBase.<>f__mg$cache40);
		if (Lua_BlackJack_BJFramework_Runtime_UI_LoginUITaskBase.<>f__mg$cache41 == null)
		{
			Lua_BlackJack_BJFramework_Runtime_UI_LoginUITaskBase.<>f__mg$cache41 = new LuaCSFunction(Lua_BlackJack_BJFramework_Runtime_UI_LoginUITaskBase.__callBase_CollectAllDynamicResForLoad);
		}
		LuaObject.addMember(l, Lua_BlackJack_BJFramework_Runtime_UI_LoginUITaskBase.<>f__mg$cache41);
		if (Lua_BlackJack_BJFramework_Runtime_UI_LoginUITaskBase.<>f__mg$cache42 == null)
		{
			Lua_BlackJack_BJFramework_Runtime_UI_LoginUITaskBase.<>f__mg$cache42 = new LuaCSFunction(Lua_BlackJack_BJFramework_Runtime_UI_LoginUITaskBase.__callBase_CollectAllStaticResDescForLoad);
		}
		LuaObject.addMember(l, Lua_BlackJack_BJFramework_Runtime_UI_LoginUITaskBase.<>f__mg$cache42);
		if (Lua_BlackJack_BJFramework_Runtime_UI_LoginUITaskBase.<>f__mg$cache43 == null)
		{
			Lua_BlackJack_BJFramework_Runtime_UI_LoginUITaskBase.<>f__mg$cache43 = new LuaCSFunction(Lua_BlackJack_BJFramework_Runtime_UI_LoginUITaskBase.__callBase_CalculateDynamicResReallyNeedLoad);
		}
		LuaObject.addMember(l, Lua_BlackJack_BJFramework_Runtime_UI_LoginUITaskBase.<>f__mg$cache43);
		if (Lua_BlackJack_BJFramework_Runtime_UI_LoginUITaskBase.<>f__mg$cache44 == null)
		{
			Lua_BlackJack_BJFramework_Runtime_UI_LoginUITaskBase.<>f__mg$cache44 = new LuaCSFunction(Lua_BlackJack_BJFramework_Runtime_UI_LoginUITaskBase.__callBase_OnLoadDynamicResCompleted);
		}
		LuaObject.addMember(l, Lua_BlackJack_BJFramework_Runtime_UI_LoginUITaskBase.<>f__mg$cache44);
		if (Lua_BlackJack_BJFramework_Runtime_UI_LoginUITaskBase.<>f__mg$cache45 == null)
		{
			Lua_BlackJack_BJFramework_Runtime_UI_LoginUITaskBase.<>f__mg$cache45 = new LuaCSFunction(Lua_BlackJack_BJFramework_Runtime_UI_LoginUITaskBase.__callBase_RedirectPipLineOnAllResReady);
		}
		LuaObject.addMember(l, Lua_BlackJack_BJFramework_Runtime_UI_LoginUITaskBase.<>f__mg$cache45);
		if (Lua_BlackJack_BJFramework_Runtime_UI_LoginUITaskBase.<>f__mg$cache46 == null)
		{
			Lua_BlackJack_BJFramework_Runtime_UI_LoginUITaskBase.<>f__mg$cache46 = new LuaCSFunction(Lua_BlackJack_BJFramework_Runtime_UI_LoginUITaskBase.__callBase_OnLoadAllResCompleted);
		}
		LuaObject.addMember(l, Lua_BlackJack_BJFramework_Runtime_UI_LoginUITaskBase.<>f__mg$cache46);
		if (Lua_BlackJack_BJFramework_Runtime_UI_LoginUITaskBase.<>f__mg$cache47 == null)
		{
			Lua_BlackJack_BJFramework_Runtime_UI_LoginUITaskBase.<>f__mg$cache47 = new LuaCSFunction(Lua_BlackJack_BJFramework_Runtime_UI_LoginUITaskBase.__callBase_ReturnFromRedirectPipLineOnLoadAllResCompleted);
		}
		LuaObject.addMember(l, Lua_BlackJack_BJFramework_Runtime_UI_LoginUITaskBase.<>f__mg$cache47);
		if (Lua_BlackJack_BJFramework_Runtime_UI_LoginUITaskBase.<>f__mg$cache48 == null)
		{
			Lua_BlackJack_BJFramework_Runtime_UI_LoginUITaskBase.<>f__mg$cache48 = new LuaCSFunction(Lua_BlackJack_BJFramework_Runtime_UI_LoginUITaskBase.__callBase_InitLayerStateOnLoadAllResCompleted);
		}
		LuaObject.addMember(l, Lua_BlackJack_BJFramework_Runtime_UI_LoginUITaskBase.<>f__mg$cache48);
		if (Lua_BlackJack_BJFramework_Runtime_UI_LoginUITaskBase.<>f__mg$cache49 == null)
		{
			Lua_BlackJack_BJFramework_Runtime_UI_LoginUITaskBase.<>f__mg$cache49 = new LuaCSFunction(Lua_BlackJack_BJFramework_Runtime_UI_LoginUITaskBase.__callBase_InitAllUIControllers);
		}
		LuaObject.addMember(l, Lua_BlackJack_BJFramework_Runtime_UI_LoginUITaskBase.<>f__mg$cache49);
		if (Lua_BlackJack_BJFramework_Runtime_UI_LoginUITaskBase.<>f__mg$cache4A == null)
		{
			Lua_BlackJack_BJFramework_Runtime_UI_LoginUITaskBase.<>f__mg$cache4A = new LuaCSFunction(Lua_BlackJack_BJFramework_Runtime_UI_LoginUITaskBase.__callBase_PostOnLoadAllResCompleted);
		}
		LuaObject.addMember(l, Lua_BlackJack_BJFramework_Runtime_UI_LoginUITaskBase.<>f__mg$cache4A);
		if (Lua_BlackJack_BJFramework_Runtime_UI_LoginUITaskBase.<>f__mg$cache4B == null)
		{
			Lua_BlackJack_BJFramework_Runtime_UI_LoginUITaskBase.<>f__mg$cache4B = new LuaCSFunction(Lua_BlackJack_BJFramework_Runtime_UI_LoginUITaskBase.__callBase_IsLoadAllResCompleted);
		}
		LuaObject.addMember(l, Lua_BlackJack_BJFramework_Runtime_UI_LoginUITaskBase.<>f__mg$cache4B);
		if (Lua_BlackJack_BJFramework_Runtime_UI_LoginUITaskBase.<>f__mg$cache4C == null)
		{
			Lua_BlackJack_BJFramework_Runtime_UI_LoginUITaskBase.<>f__mg$cache4C = new LuaCSFunction(Lua_BlackJack_BJFramework_Runtime_UI_LoginUITaskBase.__callBase_StartUpdateView);
		}
		LuaObject.addMember(l, Lua_BlackJack_BJFramework_Runtime_UI_LoginUITaskBase.<>f__mg$cache4C);
		if (Lua_BlackJack_BJFramework_Runtime_UI_LoginUITaskBase.<>f__mg$cache4D == null)
		{
			Lua_BlackJack_BJFramework_Runtime_UI_LoginUITaskBase.<>f__mg$cache4D = new LuaCSFunction(Lua_BlackJack_BJFramework_Runtime_UI_LoginUITaskBase.__callBase_UpdateView);
		}
		LuaObject.addMember(l, Lua_BlackJack_BJFramework_Runtime_UI_LoginUITaskBase.<>f__mg$cache4D);
		if (Lua_BlackJack_BJFramework_Runtime_UI_LoginUITaskBase.<>f__mg$cache4E == null)
		{
			Lua_BlackJack_BJFramework_Runtime_UI_LoginUITaskBase.<>f__mg$cache4E = new LuaCSFunction(Lua_BlackJack_BJFramework_Runtime_UI_LoginUITaskBase.__callBase_RegUpdateViewPlayingEffect);
		}
		LuaObject.addMember(l, Lua_BlackJack_BJFramework_Runtime_UI_LoginUITaskBase.<>f__mg$cache4E);
		if (Lua_BlackJack_BJFramework_Runtime_UI_LoginUITaskBase.<>f__mg$cache4F == null)
		{
			Lua_BlackJack_BJFramework_Runtime_UI_LoginUITaskBase.<>f__mg$cache4F = new LuaCSFunction(Lua_BlackJack_BJFramework_Runtime_UI_LoginUITaskBase.__callBase_UnregUpdateViewPlayingEffect);
		}
		LuaObject.addMember(l, Lua_BlackJack_BJFramework_Runtime_UI_LoginUITaskBase.<>f__mg$cache4F);
		if (Lua_BlackJack_BJFramework_Runtime_UI_LoginUITaskBase.<>f__mg$cache50 == null)
		{
			Lua_BlackJack_BJFramework_Runtime_UI_LoginUITaskBase.<>f__mg$cache50 = new LuaCSFunction(Lua_BlackJack_BJFramework_Runtime_UI_LoginUITaskBase.__callBase_PostUpdateView);
		}
		LuaObject.addMember(l, Lua_BlackJack_BJFramework_Runtime_UI_LoginUITaskBase.<>f__mg$cache50);
		if (Lua_BlackJack_BJFramework_Runtime_UI_LoginUITaskBase.<>f__mg$cache51 == null)
		{
			Lua_BlackJack_BJFramework_Runtime_UI_LoginUITaskBase.<>f__mg$cache51 = new LuaCSFunction(Lua_BlackJack_BJFramework_Runtime_UI_LoginUITaskBase.__callBase_PostUpdateViewBeforeClearContext);
		}
		LuaObject.addMember(l, Lua_BlackJack_BJFramework_Runtime_UI_LoginUITaskBase.<>f__mg$cache51);
		if (Lua_BlackJack_BJFramework_Runtime_UI_LoginUITaskBase.<>f__mg$cache52 == null)
		{
			Lua_BlackJack_BJFramework_Runtime_UI_LoginUITaskBase.<>f__mg$cache52 = new LuaCSFunction(Lua_BlackJack_BJFramework_Runtime_UI_LoginUITaskBase.__callBase_HideAllView);
		}
		LuaObject.addMember(l, Lua_BlackJack_BJFramework_Runtime_UI_LoginUITaskBase.<>f__mg$cache52);
		if (Lua_BlackJack_BJFramework_Runtime_UI_LoginUITaskBase.<>f__mg$cache53 == null)
		{
			Lua_BlackJack_BJFramework_Runtime_UI_LoginUITaskBase.<>f__mg$cache53 = new LuaCSFunction(Lua_BlackJack_BJFramework_Runtime_UI_LoginUITaskBase.__callBase_ClearAllContextAndRes);
		}
		LuaObject.addMember(l, Lua_BlackJack_BJFramework_Runtime_UI_LoginUITaskBase.<>f__mg$cache53);
		if (Lua_BlackJack_BJFramework_Runtime_UI_LoginUITaskBase.<>f__mg$cache54 == null)
		{
			Lua_BlackJack_BJFramework_Runtime_UI_LoginUITaskBase.<>f__mg$cache54 = new LuaCSFunction(Lua_BlackJack_BJFramework_Runtime_UI_LoginUITaskBase.__callBase_SaveContextInIntentOnPause);
		}
		LuaObject.addMember(l, Lua_BlackJack_BJFramework_Runtime_UI_LoginUITaskBase.<>f__mg$cache54);
		if (Lua_BlackJack_BJFramework_Runtime_UI_LoginUITaskBase.<>f__mg$cache55 == null)
		{
			Lua_BlackJack_BJFramework_Runtime_UI_LoginUITaskBase.<>f__mg$cache55 = new LuaCSFunction(Lua_BlackJack_BJFramework_Runtime_UI_LoginUITaskBase.__callBase_ClearContextOnPause);
		}
		LuaObject.addMember(l, Lua_BlackJack_BJFramework_Runtime_UI_LoginUITaskBase.<>f__mg$cache55);
		if (Lua_BlackJack_BJFramework_Runtime_UI_LoginUITaskBase.<>f__mg$cache56 == null)
		{
			Lua_BlackJack_BJFramework_Runtime_UI_LoginUITaskBase.<>f__mg$cache56 = new LuaCSFunction(Lua_BlackJack_BJFramework_Runtime_UI_LoginUITaskBase.__callBase_ClearContextOnIntentChange);
		}
		LuaObject.addMember(l, Lua_BlackJack_BJFramework_Runtime_UI_LoginUITaskBase.<>f__mg$cache56);
		if (Lua_BlackJack_BJFramework_Runtime_UI_LoginUITaskBase.<>f__mg$cache57 == null)
		{
			Lua_BlackJack_BJFramework_Runtime_UI_LoginUITaskBase.<>f__mg$cache57 = new LuaCSFunction(Lua_BlackJack_BJFramework_Runtime_UI_LoginUITaskBase.__callBase_ClearContextOnUpdateViewEnd);
		}
		LuaObject.addMember(l, Lua_BlackJack_BJFramework_Runtime_UI_LoginUITaskBase.<>f__mg$cache57);
		if (Lua_BlackJack_BJFramework_Runtime_UI_LoginUITaskBase.<>f__mg$cache58 == null)
		{
			Lua_BlackJack_BJFramework_Runtime_UI_LoginUITaskBase.<>f__mg$cache58 = new LuaCSFunction(Lua_BlackJack_BJFramework_Runtime_UI_LoginUITaskBase.__callBase_EnableUIInput);
		}
		LuaObject.addMember(l, Lua_BlackJack_BJFramework_Runtime_UI_LoginUITaskBase.<>f__mg$cache58);
		if (Lua_BlackJack_BJFramework_Runtime_UI_LoginUITaskBase.<>f__mg$cache59 == null)
		{
			Lua_BlackJack_BJFramework_Runtime_UI_LoginUITaskBase.<>f__mg$cache59 = new LuaCSFunction(Lua_BlackJack_BJFramework_Runtime_UI_LoginUITaskBase.__callBase_GetLayerDescByName);
		}
		LuaObject.addMember(l, Lua_BlackJack_BJFramework_Runtime_UI_LoginUITaskBase.<>f__mg$cache59);
		if (Lua_BlackJack_BJFramework_Runtime_UI_LoginUITaskBase.<>f__mg$cache5A == null)
		{
			Lua_BlackJack_BJFramework_Runtime_UI_LoginUITaskBase.<>f__mg$cache5A = new LuaCSFunction(Lua_BlackJack_BJFramework_Runtime_UI_LoginUITaskBase.__callBase_GetLayerByName);
		}
		LuaObject.addMember(l, Lua_BlackJack_BJFramework_Runtime_UI_LoginUITaskBase.<>f__mg$cache5A);
		if (Lua_BlackJack_BJFramework_Runtime_UI_LoginUITaskBase.<>f__mg$cache5B == null)
		{
			Lua_BlackJack_BJFramework_Runtime_UI_LoginUITaskBase.<>f__mg$cache5B = new LuaCSFunction(Lua_BlackJack_BJFramework_Runtime_UI_LoginUITaskBase.__callBase_RegisterModesDefine);
		}
		LuaObject.addMember(l, Lua_BlackJack_BJFramework_Runtime_UI_LoginUITaskBase.<>f__mg$cache5B);
		if (Lua_BlackJack_BJFramework_Runtime_UI_LoginUITaskBase.<>f__mg$cache5C == null)
		{
			Lua_BlackJack_BJFramework_Runtime_UI_LoginUITaskBase.<>f__mg$cache5C = new LuaCSFunction(Lua_BlackJack_BJFramework_Runtime_UI_LoginUITaskBase.__callBase_SetCurrentMode);
		}
		LuaObject.addMember(l, Lua_BlackJack_BJFramework_Runtime_UI_LoginUITaskBase.<>f__mg$cache5C);
		if (Lua_BlackJack_BJFramework_Runtime_UI_LoginUITaskBase.<>f__mg$cache5D == null)
		{
			Lua_BlackJack_BJFramework_Runtime_UI_LoginUITaskBase.<>f__mg$cache5D = new LuaCSFunction(Lua_BlackJack_BJFramework_Runtime_UI_LoginUITaskBase.__callBase_SetIsNeedPauseTimeOut);
		}
		LuaObject.addMember(l, Lua_BlackJack_BJFramework_Runtime_UI_LoginUITaskBase.<>f__mg$cache5D);
		if (Lua_BlackJack_BJFramework_Runtime_UI_LoginUITaskBase.<>f__mg$cache5E == null)
		{
			Lua_BlackJack_BJFramework_Runtime_UI_LoginUITaskBase.<>f__mg$cache5E = new LuaCSFunction(Lua_BlackJack_BJFramework_Runtime_UI_LoginUITaskBase.__callBase_OnTick);
		}
		LuaObject.addMember(l, Lua_BlackJack_BJFramework_Runtime_UI_LoginUITaskBase.<>f__mg$cache5E);
		if (Lua_BlackJack_BJFramework_Runtime_UI_LoginUITaskBase.<>f__mg$cache5F == null)
		{
			Lua_BlackJack_BJFramework_Runtime_UI_LoginUITaskBase.<>f__mg$cache5F = new LuaCSFunction(Lua_BlackJack_BJFramework_Runtime_UI_LoginUITaskBase.__callBase_PostDelayTimeExecuteAction);
		}
		LuaObject.addMember(l, Lua_BlackJack_BJFramework_Runtime_UI_LoginUITaskBase.<>f__mg$cache5F);
		if (Lua_BlackJack_BJFramework_Runtime_UI_LoginUITaskBase.<>f__mg$cache60 == null)
		{
			Lua_BlackJack_BJFramework_Runtime_UI_LoginUITaskBase.<>f__mg$cache60 = new LuaCSFunction(Lua_BlackJack_BJFramework_Runtime_UI_LoginUITaskBase.__callBase_PostDelayTicksExecuteAction);
		}
		LuaObject.addMember(l, Lua_BlackJack_BJFramework_Runtime_UI_LoginUITaskBase.<>f__mg$cache60);
		if (Lua_BlackJack_BJFramework_Runtime_UI_LoginUITaskBase.<>f__mg$cache61 == null)
		{
			Lua_BlackJack_BJFramework_Runtime_UI_LoginUITaskBase.<>f__mg$cache61 = new LuaCSFunction(Lua_BlackJack_BJFramework_Runtime_UI_LoginUITaskBase.__callBase_SetTag);
		}
		LuaObject.addMember(l, Lua_BlackJack_BJFramework_Runtime_UI_LoginUITaskBase.<>f__mg$cache61);
		if (Lua_BlackJack_BJFramework_Runtime_UI_LoginUITaskBase.<>f__mg$cache62 == null)
		{
			Lua_BlackJack_BJFramework_Runtime_UI_LoginUITaskBase.<>f__mg$cache62 = new LuaCSFunction(Lua_BlackJack_BJFramework_Runtime_UI_LoginUITaskBase.__callBase_HasTag);
		}
		LuaObject.addMember(l, Lua_BlackJack_BJFramework_Runtime_UI_LoginUITaskBase.<>f__mg$cache62);
		string name = "m_loginTaskState";
		if (Lua_BlackJack_BJFramework_Runtime_UI_LoginUITaskBase.<>f__mg$cache63 == null)
		{
			Lua_BlackJack_BJFramework_Runtime_UI_LoginUITaskBase.<>f__mg$cache63 = new LuaCSFunction(Lua_BlackJack_BJFramework_Runtime_UI_LoginUITaskBase.get_m_loginTaskState);
		}
		LuaCSFunction get = Lua_BlackJack_BJFramework_Runtime_UI_LoginUITaskBase.<>f__mg$cache63;
		if (Lua_BlackJack_BJFramework_Runtime_UI_LoginUITaskBase.<>f__mg$cache64 == null)
		{
			Lua_BlackJack_BJFramework_Runtime_UI_LoginUITaskBase.<>f__mg$cache64 = new LuaCSFunction(Lua_BlackJack_BJFramework_Runtime_UI_LoginUITaskBase.set_m_loginTaskState);
		}
		LuaObject.addMember(l, name, get, Lua_BlackJack_BJFramework_Runtime_UI_LoginUITaskBase.<>f__mg$cache64, true);
		string name2 = "m_authLoginServerAddress";
		if (Lua_BlackJack_BJFramework_Runtime_UI_LoginUITaskBase.<>f__mg$cache65 == null)
		{
			Lua_BlackJack_BJFramework_Runtime_UI_LoginUITaskBase.<>f__mg$cache65 = new LuaCSFunction(Lua_BlackJack_BJFramework_Runtime_UI_LoginUITaskBase.get_m_authLoginServerAddress);
		}
		LuaCSFunction get2 = Lua_BlackJack_BJFramework_Runtime_UI_LoginUITaskBase.<>f__mg$cache65;
		if (Lua_BlackJack_BJFramework_Runtime_UI_LoginUITaskBase.<>f__mg$cache66 == null)
		{
			Lua_BlackJack_BJFramework_Runtime_UI_LoginUITaskBase.<>f__mg$cache66 = new LuaCSFunction(Lua_BlackJack_BJFramework_Runtime_UI_LoginUITaskBase.set_m_authLoginServerAddress);
		}
		LuaObject.addMember(l, name2, get2, Lua_BlackJack_BJFramework_Runtime_UI_LoginUITaskBase.<>f__mg$cache66, true);
		string name3 = "m_authLoginServerPort";
		if (Lua_BlackJack_BJFramework_Runtime_UI_LoginUITaskBase.<>f__mg$cache67 == null)
		{
			Lua_BlackJack_BJFramework_Runtime_UI_LoginUITaskBase.<>f__mg$cache67 = new LuaCSFunction(Lua_BlackJack_BJFramework_Runtime_UI_LoginUITaskBase.get_m_authLoginServerPort);
		}
		LuaCSFunction get3 = Lua_BlackJack_BJFramework_Runtime_UI_LoginUITaskBase.<>f__mg$cache67;
		if (Lua_BlackJack_BJFramework_Runtime_UI_LoginUITaskBase.<>f__mg$cache68 == null)
		{
			Lua_BlackJack_BJFramework_Runtime_UI_LoginUITaskBase.<>f__mg$cache68 = new LuaCSFunction(Lua_BlackJack_BJFramework_Runtime_UI_LoginUITaskBase.set_m_authLoginServerPort);
		}
		LuaObject.addMember(l, name3, get3, Lua_BlackJack_BJFramework_Runtime_UI_LoginUITaskBase.<>f__mg$cache68, true);
		string name4 = "m_authtoken";
		if (Lua_BlackJack_BJFramework_Runtime_UI_LoginUITaskBase.<>f__mg$cache69 == null)
		{
			Lua_BlackJack_BJFramework_Runtime_UI_LoginUITaskBase.<>f__mg$cache69 = new LuaCSFunction(Lua_BlackJack_BJFramework_Runtime_UI_LoginUITaskBase.get_m_authtoken);
		}
		LuaCSFunction get4 = Lua_BlackJack_BJFramework_Runtime_UI_LoginUITaskBase.<>f__mg$cache69;
		if (Lua_BlackJack_BJFramework_Runtime_UI_LoginUITaskBase.<>f__mg$cache6A == null)
		{
			Lua_BlackJack_BJFramework_Runtime_UI_LoginUITaskBase.<>f__mg$cache6A = new LuaCSFunction(Lua_BlackJack_BJFramework_Runtime_UI_LoginUITaskBase.set_m_authtoken);
		}
		LuaObject.addMember(l, name4, get4, Lua_BlackJack_BJFramework_Runtime_UI_LoginUITaskBase.<>f__mg$cache6A, true);
		string name5 = "m_gameUserId";
		if (Lua_BlackJack_BJFramework_Runtime_UI_LoginUITaskBase.<>f__mg$cache6B == null)
		{
			Lua_BlackJack_BJFramework_Runtime_UI_LoginUITaskBase.<>f__mg$cache6B = new LuaCSFunction(Lua_BlackJack_BJFramework_Runtime_UI_LoginUITaskBase.get_m_gameUserId);
		}
		LuaCSFunction get5 = Lua_BlackJack_BJFramework_Runtime_UI_LoginUITaskBase.<>f__mg$cache6B;
		if (Lua_BlackJack_BJFramework_Runtime_UI_LoginUITaskBase.<>f__mg$cache6C == null)
		{
			Lua_BlackJack_BJFramework_Runtime_UI_LoginUITaskBase.<>f__mg$cache6C = new LuaCSFunction(Lua_BlackJack_BJFramework_Runtime_UI_LoginUITaskBase.set_m_gameUserId);
		}
		LuaObject.addMember(l, name5, get5, Lua_BlackJack_BJFramework_Runtime_UI_LoginUITaskBase.<>f__mg$cache6C, true);
		string name6 = "m_loginChannelId";
		if (Lua_BlackJack_BJFramework_Runtime_UI_LoginUITaskBase.<>f__mg$cache6D == null)
		{
			Lua_BlackJack_BJFramework_Runtime_UI_LoginUITaskBase.<>f__mg$cache6D = new LuaCSFunction(Lua_BlackJack_BJFramework_Runtime_UI_LoginUITaskBase.get_m_loginChannelId);
		}
		LuaCSFunction get6 = Lua_BlackJack_BJFramework_Runtime_UI_LoginUITaskBase.<>f__mg$cache6D;
		if (Lua_BlackJack_BJFramework_Runtime_UI_LoginUITaskBase.<>f__mg$cache6E == null)
		{
			Lua_BlackJack_BJFramework_Runtime_UI_LoginUITaskBase.<>f__mg$cache6E = new LuaCSFunction(Lua_BlackJack_BJFramework_Runtime_UI_LoginUITaskBase.set_m_loginChannelId);
		}
		LuaObject.addMember(l, name6, get6, Lua_BlackJack_BJFramework_Runtime_UI_LoginUITaskBase.<>f__mg$cache6E, true);
		string name7 = "m_bornChannelId";
		if (Lua_BlackJack_BJFramework_Runtime_UI_LoginUITaskBase.<>f__mg$cache6F == null)
		{
			Lua_BlackJack_BJFramework_Runtime_UI_LoginUITaskBase.<>f__mg$cache6F = new LuaCSFunction(Lua_BlackJack_BJFramework_Runtime_UI_LoginUITaskBase.get_m_bornChannelId);
		}
		LuaCSFunction get7 = Lua_BlackJack_BJFramework_Runtime_UI_LoginUITaskBase.<>f__mg$cache6F;
		if (Lua_BlackJack_BJFramework_Runtime_UI_LoginUITaskBase.<>f__mg$cache70 == null)
		{
			Lua_BlackJack_BJFramework_Runtime_UI_LoginUITaskBase.<>f__mg$cache70 = new LuaCSFunction(Lua_BlackJack_BJFramework_Runtime_UI_LoginUITaskBase.set_m_bornChannelId);
		}
		LuaObject.addMember(l, name7, get7, Lua_BlackJack_BJFramework_Runtime_UI_LoginUITaskBase.<>f__mg$cache70, true);
		string name8 = "m_lastSessionToken";
		if (Lua_BlackJack_BJFramework_Runtime_UI_LoginUITaskBase.<>f__mg$cache71 == null)
		{
			Lua_BlackJack_BJFramework_Runtime_UI_LoginUITaskBase.<>f__mg$cache71 = new LuaCSFunction(Lua_BlackJack_BJFramework_Runtime_UI_LoginUITaskBase.get_m_lastSessionToken);
		}
		LuaCSFunction get8 = Lua_BlackJack_BJFramework_Runtime_UI_LoginUITaskBase.<>f__mg$cache71;
		if (Lua_BlackJack_BJFramework_Runtime_UI_LoginUITaskBase.<>f__mg$cache72 == null)
		{
			Lua_BlackJack_BJFramework_Runtime_UI_LoginUITaskBase.<>f__mg$cache72 = new LuaCSFunction(Lua_BlackJack_BJFramework_Runtime_UI_LoginUITaskBase.set_m_lastSessionToken);
		}
		LuaObject.addMember(l, name8, get8, Lua_BlackJack_BJFramework_Runtime_UI_LoginUITaskBase.<>f__mg$cache72, true);
		string name9 = "m_isWaitingForMsgAck";
		if (Lua_BlackJack_BJFramework_Runtime_UI_LoginUITaskBase.<>f__mg$cache73 == null)
		{
			Lua_BlackJack_BJFramework_Runtime_UI_LoginUITaskBase.<>f__mg$cache73 = new LuaCSFunction(Lua_BlackJack_BJFramework_Runtime_UI_LoginUITaskBase.get_m_isWaitingForMsgAck);
		}
		LuaCSFunction get9 = Lua_BlackJack_BJFramework_Runtime_UI_LoginUITaskBase.<>f__mg$cache73;
		if (Lua_BlackJack_BJFramework_Runtime_UI_LoginUITaskBase.<>f__mg$cache74 == null)
		{
			Lua_BlackJack_BJFramework_Runtime_UI_LoginUITaskBase.<>f__mg$cache74 = new LuaCSFunction(Lua_BlackJack_BJFramework_Runtime_UI_LoginUITaskBase.set_m_isWaitingForMsgAck);
		}
		LuaObject.addMember(l, name9, get9, Lua_BlackJack_BJFramework_Runtime_UI_LoginUITaskBase.<>f__mg$cache74, true);
		string name10 = "m_timeOutTime";
		if (Lua_BlackJack_BJFramework_Runtime_UI_LoginUITaskBase.<>f__mg$cache75 == null)
		{
			Lua_BlackJack_BJFramework_Runtime_UI_LoginUITaskBase.<>f__mg$cache75 = new LuaCSFunction(Lua_BlackJack_BJFramework_Runtime_UI_LoginUITaskBase.get_m_timeOutTime);
		}
		LuaCSFunction get10 = Lua_BlackJack_BJFramework_Runtime_UI_LoginUITaskBase.<>f__mg$cache75;
		if (Lua_BlackJack_BJFramework_Runtime_UI_LoginUITaskBase.<>f__mg$cache76 == null)
		{
			Lua_BlackJack_BJFramework_Runtime_UI_LoginUITaskBase.<>f__mg$cache76 = new LuaCSFunction(Lua_BlackJack_BJFramework_Runtime_UI_LoginUITaskBase.set_m_timeOutTime);
		}
		LuaObject.addMember(l, name10, get10, Lua_BlackJack_BJFramework_Runtime_UI_LoginUITaskBase.<>f__mg$cache76, true);
		string name11 = "m_timeoutDelayTime";
		if (Lua_BlackJack_BJFramework_Runtime_UI_LoginUITaskBase.<>f__mg$cache77 == null)
		{
			Lua_BlackJack_BJFramework_Runtime_UI_LoginUITaskBase.<>f__mg$cache77 = new LuaCSFunction(Lua_BlackJack_BJFramework_Runtime_UI_LoginUITaskBase.get_m_timeoutDelayTime);
		}
		LuaCSFunction get11 = Lua_BlackJack_BJFramework_Runtime_UI_LoginUITaskBase.<>f__mg$cache77;
		if (Lua_BlackJack_BJFramework_Runtime_UI_LoginUITaskBase.<>f__mg$cache78 == null)
		{
			Lua_BlackJack_BJFramework_Runtime_UI_LoginUITaskBase.<>f__mg$cache78 = new LuaCSFunction(Lua_BlackJack_BJFramework_Runtime_UI_LoginUITaskBase.set_m_timeoutDelayTime);
		}
		LuaObject.addMember(l, name11, get11, Lua_BlackJack_BJFramework_Runtime_UI_LoginUITaskBase.<>f__mg$cache78, true);
		LuaObject.createTypeMetatable(l, null, typeof(LoginUITaskBase), typeof(UITaskBase));
	}

	// Token: 0x0400C4CD RID: 50381
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache0;

	// Token: 0x0400C4CE RID: 50382
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1;

	// Token: 0x0400C4CF RID: 50383
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2;

	// Token: 0x0400C4D0 RID: 50384
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3;

	// Token: 0x0400C4D1 RID: 50385
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache4;

	// Token: 0x0400C4D2 RID: 50386
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache5;

	// Token: 0x0400C4D3 RID: 50387
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache6;

	// Token: 0x0400C4D4 RID: 50388
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache7;

	// Token: 0x0400C4D5 RID: 50389
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache8;

	// Token: 0x0400C4D6 RID: 50390
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache9;

	// Token: 0x0400C4D7 RID: 50391
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheA;

	// Token: 0x0400C4D8 RID: 50392
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheB;

	// Token: 0x0400C4D9 RID: 50393
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheC;

	// Token: 0x0400C4DA RID: 50394
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheD;

	// Token: 0x0400C4DB RID: 50395
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheE;

	// Token: 0x0400C4DC RID: 50396
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheF;

	// Token: 0x0400C4DD RID: 50397
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache10;

	// Token: 0x0400C4DE RID: 50398
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache11;

	// Token: 0x0400C4DF RID: 50399
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache12;

	// Token: 0x0400C4E0 RID: 50400
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache13;

	// Token: 0x0400C4E1 RID: 50401
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache14;

	// Token: 0x0400C4E2 RID: 50402
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache15;

	// Token: 0x0400C4E3 RID: 50403
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache16;

	// Token: 0x0400C4E4 RID: 50404
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache17;

	// Token: 0x0400C4E5 RID: 50405
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache18;

	// Token: 0x0400C4E6 RID: 50406
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache19;

	// Token: 0x0400C4E7 RID: 50407
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1A;

	// Token: 0x0400C4E8 RID: 50408
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1B;

	// Token: 0x0400C4E9 RID: 50409
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1C;

	// Token: 0x0400C4EA RID: 50410
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1D;

	// Token: 0x0400C4EB RID: 50411
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1E;

	// Token: 0x0400C4EC RID: 50412
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1F;

	// Token: 0x0400C4ED RID: 50413
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache20;

	// Token: 0x0400C4EE RID: 50414
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache21;

	// Token: 0x0400C4EF RID: 50415
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache22;

	// Token: 0x0400C4F0 RID: 50416
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache23;

	// Token: 0x0400C4F1 RID: 50417
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache24;

	// Token: 0x0400C4F2 RID: 50418
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache25;

	// Token: 0x0400C4F3 RID: 50419
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache26;

	// Token: 0x0400C4F4 RID: 50420
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache27;

	// Token: 0x0400C4F5 RID: 50421
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache28;

	// Token: 0x0400C4F6 RID: 50422
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache29;

	// Token: 0x0400C4F7 RID: 50423
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2A;

	// Token: 0x0400C4F8 RID: 50424
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2B;

	// Token: 0x0400C4F9 RID: 50425
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2C;

	// Token: 0x0400C4FA RID: 50426
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2D;

	// Token: 0x0400C4FB RID: 50427
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2E;

	// Token: 0x0400C4FC RID: 50428
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2F;

	// Token: 0x0400C4FD RID: 50429
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache30;

	// Token: 0x0400C4FE RID: 50430
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache31;

	// Token: 0x0400C4FF RID: 50431
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache32;

	// Token: 0x0400C500 RID: 50432
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache33;

	// Token: 0x0400C501 RID: 50433
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache34;

	// Token: 0x0400C502 RID: 50434
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache35;

	// Token: 0x0400C503 RID: 50435
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache36;

	// Token: 0x0400C504 RID: 50436
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache37;

	// Token: 0x0400C505 RID: 50437
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache38;

	// Token: 0x0400C506 RID: 50438
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache39;

	// Token: 0x0400C507 RID: 50439
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3A;

	// Token: 0x0400C508 RID: 50440
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3B;

	// Token: 0x0400C509 RID: 50441
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3C;

	// Token: 0x0400C50A RID: 50442
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3D;

	// Token: 0x0400C50B RID: 50443
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3E;

	// Token: 0x0400C50C RID: 50444
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3F;

	// Token: 0x0400C50D RID: 50445
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache40;

	// Token: 0x0400C50E RID: 50446
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache41;

	// Token: 0x0400C50F RID: 50447
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache42;

	// Token: 0x0400C510 RID: 50448
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache43;

	// Token: 0x0400C511 RID: 50449
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache44;

	// Token: 0x0400C512 RID: 50450
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache45;

	// Token: 0x0400C513 RID: 50451
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache46;

	// Token: 0x0400C514 RID: 50452
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache47;

	// Token: 0x0400C515 RID: 50453
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache48;

	// Token: 0x0400C516 RID: 50454
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache49;

	// Token: 0x0400C517 RID: 50455
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache4A;

	// Token: 0x0400C518 RID: 50456
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache4B;

	// Token: 0x0400C519 RID: 50457
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache4C;

	// Token: 0x0400C51A RID: 50458
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache4D;

	// Token: 0x0400C51B RID: 50459
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache4E;

	// Token: 0x0400C51C RID: 50460
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache4F;

	// Token: 0x0400C51D RID: 50461
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache50;

	// Token: 0x0400C51E RID: 50462
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache51;

	// Token: 0x0400C51F RID: 50463
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache52;

	// Token: 0x0400C520 RID: 50464
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache53;

	// Token: 0x0400C521 RID: 50465
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache54;

	// Token: 0x0400C522 RID: 50466
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache55;

	// Token: 0x0400C523 RID: 50467
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache56;

	// Token: 0x0400C524 RID: 50468
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache57;

	// Token: 0x0400C525 RID: 50469
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache58;

	// Token: 0x0400C526 RID: 50470
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache59;

	// Token: 0x0400C527 RID: 50471
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache5A;

	// Token: 0x0400C528 RID: 50472
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache5B;

	// Token: 0x0400C529 RID: 50473
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache5C;

	// Token: 0x0400C52A RID: 50474
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache5D;

	// Token: 0x0400C52B RID: 50475
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache5E;

	// Token: 0x0400C52C RID: 50476
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache5F;

	// Token: 0x0400C52D RID: 50477
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache60;

	// Token: 0x0400C52E RID: 50478
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache61;

	// Token: 0x0400C52F RID: 50479
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache62;

	// Token: 0x0400C530 RID: 50480
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache63;

	// Token: 0x0400C531 RID: 50481
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache64;

	// Token: 0x0400C532 RID: 50482
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache65;

	// Token: 0x0400C533 RID: 50483
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache66;

	// Token: 0x0400C534 RID: 50484
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache67;

	// Token: 0x0400C535 RID: 50485
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache68;

	// Token: 0x0400C536 RID: 50486
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache69;

	// Token: 0x0400C537 RID: 50487
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache6A;

	// Token: 0x0400C538 RID: 50488
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache6B;

	// Token: 0x0400C539 RID: 50489
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache6C;

	// Token: 0x0400C53A RID: 50490
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache6D;

	// Token: 0x0400C53B RID: 50491
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache6E;

	// Token: 0x0400C53C RID: 50492
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache6F;

	// Token: 0x0400C53D RID: 50493
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache70;

	// Token: 0x0400C53E RID: 50494
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache71;

	// Token: 0x0400C53F RID: 50495
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache72;

	// Token: 0x0400C540 RID: 50496
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache73;

	// Token: 0x0400C541 RID: 50497
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache74;

	// Token: 0x0400C542 RID: 50498
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache75;

	// Token: 0x0400C543 RID: 50499
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache76;

	// Token: 0x0400C544 RID: 50500
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache77;

	// Token: 0x0400C545 RID: 50501
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache78;
}
