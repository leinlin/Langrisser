using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using BlackJack.BJFramework.Runtime.UI;
using BlackJack.ConfigData;
using BlackJack.ProjectL.UI;
using PD.SDK;
using SLua;
using UnityEngine;
using UnityEngine.Scripting;

// Token: 0x020014FC RID: 5372
[Preserve]
public class Lua_BlackJack_ProjectL_UI_LoginUITask : LuaObject
{
	// Token: 0x0601FBFA RID: 130042 RVA: 0x00A771A0 File Offset: 0x00A753A0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int constructor(IntPtr l)
	{
		int result;
		try
		{
			string name;
			LuaObject.checkType(l, 2, out name);
			LoginUITask o = new LoginUITask(name);
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

	// Token: 0x0601FBFB RID: 130043 RVA: 0x00A771F4 File Offset: 0x00A753F4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int ShowDialogBox(IntPtr l)
	{
		int result;
		try
		{
			LoginUITask loginUITask = (LoginUITask)LuaObject.checkSelf(l);
			StringTableId strID;
			LuaObject.checkEnum<StringTableId>(l, 2, out strID);
			loginUITask.ShowDialogBox(strID);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601FBFC RID: 130044 RVA: 0x00A7724C File Offset: 0x00A7544C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int UpdateLoginPCClientButton(IntPtr l)
	{
		int result;
		try
		{
			LoginUITask loginUITask = (LoginUITask)LuaObject.checkSelf(l);
			loginUITask.UpdateLoginPCClientButton();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601FBFD RID: 130045 RVA: 0x00A77298 File Offset: 0x00A75498
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int UpdateGMUserFlag(IntPtr l)
	{
		int result;
		try
		{
			LoginUITask loginUITask = (LoginUITask)LuaObject.checkSelf(l);
			LoginUITask.ServerInfo si;
			LuaObject.checkType<LoginUITask.ServerInfo>(l, 2, out si);
			loginUITask.UpdateGMUserFlag(si);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601FBFE RID: 130046 RVA: 0x00A772F0 File Offset: 0x00A754F0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int GetSDKPlatformUserID(IntPtr l)
	{
		int result;
		try
		{
			LoginUITask loginUITask = (LoginUITask)LuaObject.checkSelf(l);
			LoginUITask.ServerInfo si;
			LuaObject.checkType<LoginUITask.ServerInfo>(l, 2, out si);
			IEnumerator sdkplatformUserID = loginUITask.GetSDKPlatformUserID(si);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, sdkplatformUserID);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601FBFF RID: 130047 RVA: 0x00A77354 File Offset: 0x00A75554
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int ShowWaitingNet(IntPtr l)
	{
		int result;
		try
		{
			LoginUITask loginUITask = (LoginUITask)LuaObject.checkSelf(l);
			bool show;
			LuaObject.checkType(l, 2, out show);
			loginUITask.ShowWaitingNet(show);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601FC00 RID: 130048 RVA: 0x00A773AC File Offset: 0x00A755AC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int ShowMessage(IntPtr l)
	{
		int result;
		try
		{
			LoginUITask loginUITask = (LoginUITask)LuaObject.checkSelf(l);
			StringTableId id;
			LuaObject.checkEnum<StringTableId>(l, 2, out id);
			int time;
			LuaObject.checkType(l, 3, out time);
			bool isOverride;
			LuaObject.checkType(l, 4, out isOverride);
			loginUITask.ShowMessage(id, time, isOverride);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601FC01 RID: 130049 RVA: 0x00A77420 File Offset: 0x00A75620
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int SaveSessionTokenCache(IntPtr l)
	{
		int result;
		try
		{
			LoginUITask loginUITask = (LoginUITask)LuaObject.checkSelf(l);
			string sessionToken;
			LuaObject.checkType(l, 2, out sessionToken);
			loginUITask.SaveSessionTokenCache(sessionToken);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601FC02 RID: 130050 RVA: 0x00A77478 File Offset: 0x00A75678
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int GetSessionTokenCache(IntPtr l)
	{
		int result;
		try
		{
			LoginUITask loginUITask = (LoginUITask)LuaObject.checkSelf(l);
			string sessionTokenCache = loginUITask.GetSessionTokenCache();
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, sessionTokenCache);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601FC03 RID: 130051 RVA: 0x00A774CC File Offset: 0x00A756CC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int ClearSessionTokenCache(IntPtr l)
	{
		int result;
		try
		{
			LoginUITask loginUITask = (LoginUITask)LuaObject.checkSelf(l);
			loginUITask.ClearSessionTokenCache();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601FC04 RID: 130052 RVA: 0x00A77518 File Offset: 0x00A75718
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int PDSDK_OnQRLoginSuccess(IntPtr l)
	{
		int result;
		try
		{
			LoginUITask loginUITask = (LoginUITask)LuaObject.checkSelf(l);
			string msg;
			LuaObject.checkType(l, 2, out msg);
			loginUITask.PDSDK_OnQRLoginSuccess(msg);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601FC05 RID: 130053 RVA: 0x00A77570 File Offset: 0x00A75770
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int PDSDK_OnQRLoginFailed(IntPtr l)
	{
		int result;
		try
		{
			LoginUITask loginUITask = (LoginUITask)LuaObject.checkSelf(l);
			string msg;
			LuaObject.checkType(l, 2, out msg);
			loginUITask.PDSDK_OnQRLoginFailed(msg);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601FC06 RID: 130054 RVA: 0x00A775C8 File Offset: 0x00A757C8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int PDSDK_OnQRLoginCancel(IntPtr l)
	{
		int result;
		try
		{
			LoginUITask loginUITask = (LoginUITask)LuaObject.checkSelf(l);
			string msg;
			LuaObject.checkType(l, 2, out msg);
			loginUITask.PDSDK_OnQRLoginCancel(msg);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601FC07 RID: 130055 RVA: 0x00A77620 File Offset: 0x00A75820
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int PDSK_OnLoginFailed(IntPtr l)
	{
		int result;
		try
		{
			LoginUITask loginUITask = (LoginUITask)LuaObject.checkSelf(l);
			loginUITask.PDSK_OnLoginFailed();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601FC08 RID: 130056 RVA: 0x00A7766C File Offset: 0x00A7586C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int PDSDK_OnLoginSuccess(IntPtr l)
	{
		int result;
		try
		{
			LoginUITask loginUITask = (LoginUITask)LuaObject.checkSelf(l);
			LoginSuccessMsg msg;
			LuaObject.checkValueType<LoginSuccessMsg>(l, 2, out msg);
			loginUITask.PDSDK_OnLoginSuccess(msg);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601FC09 RID: 130057 RVA: 0x00A776C4 File Offset: 0x00A758C4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int Relogin_s(IntPtr l)
	{
		int result;
		try
		{
			LoginUITask.Relogin();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601FC0A RID: 130058 RVA: 0x00A77704 File Offset: 0x00A75904
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int ReturnToLoginAndSwitchUser_s(IntPtr l)
	{
		int result;
		try
		{
			LoginUITask.ReturnToLoginAndSwitchUser();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601FC0B RID: 130059 RVA: 0x00A77744 File Offset: 0x00A75944
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int GetServerInfoByBornChannelID_s(IntPtr l)
	{
		int result;
		try
		{
			int bornChannelID;
			LuaObject.checkType(l, 1, out bornChannelID);
			LoginUITask.ServerInfo serverInfoByBornChannelID = LoginUITask.GetServerInfoByBornChannelID(bornChannelID);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, serverInfoByBornChannelID);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601FC0C RID: 130060 RVA: 0x00A77798 File Offset: 0x00A75998
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int SetLocalPushNotifications_s(IntPtr l)
	{
		int result;
		try
		{
			LoginUITask.SetLocalPushNotifications();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601FC0D RID: 130061 RVA: 0x00A777D8 File Offset: 0x00A759D8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int DeleteExpiredLogFiles_s(IntPtr l)
	{
		int result;
		try
		{
			string logFolder;
			LuaObject.checkType(l, 1, out logFolder);
			int days;
			LuaObject.checkType(l, 2, out days);
			LoginUITask.DeleteExpiredLogFiles(logFolder, days);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601FC0E RID: 130062 RVA: 0x00A77830 File Offset: 0x00A75A30
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int CheckClientVersion_s(IntPtr l)
	{
		int result;
		try
		{
			IEnumerator o = LoginUITask.CheckClientVersion();
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

	// Token: 0x0601FC0F RID: 130063 RVA: 0x00A77878 File Offset: 0x00A75A78
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int GetCurrentSelectServerInfo_s(IntPtr l)
	{
		int result;
		try
		{
			LoginUITask.ServerInfo currentSelectServerInfo = LoginUITask.GetCurrentSelectServerInfo();
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, currentSelectServerInfo);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601FC10 RID: 130064 RVA: 0x00A778C0 File Offset: 0x00A75AC0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int PDSDK_OnLogoutSuccess_s(IntPtr l)
	{
		int result;
		try
		{
			LoginUITask.PDSDK_OnLogoutSuccess();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601FC11 RID: 130065 RVA: 0x00A77900 File Offset: 0x00A75B00
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int PDSDK_OnSwitchUserSuccess_s(IntPtr l)
	{
		int result;
		try
		{
			LoginSuccessMsg msg;
			LuaObject.checkValueType<LoginSuccessMsg>(l, 1, out msg);
			LoginUITask.PDSDK_OnSwitchUserSuccess(msg);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601FC12 RID: 130066 RVA: 0x00A7794C File Offset: 0x00A75B4C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int CheckServerMaitainState_s(IntPtr l)
	{
		int result;
		try
		{
			LoginUITask.CheckServerMaitainState();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601FC13 RID: 130067 RVA: 0x00A7798C File Offset: 0x00A75B8C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int IsNeedLoadDynamicRes(IntPtr l)
	{
		int result;
		try
		{
			LoginUITask loginUITask = (LoginUITask)LuaObject.checkSelf(l);
			bool b = loginUITask.m_luaExportHelper.IsNeedLoadDynamicRes();
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

	// Token: 0x0601FC14 RID: 130068 RVA: 0x00A779E8 File Offset: 0x00A75BE8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int CollectAllDynamicResForLoad(IntPtr l)
	{
		int result;
		try
		{
			LoginUITask loginUITask = (LoginUITask)LuaObject.checkSelf(l);
			List<string> o = loginUITask.m_luaExportHelper.CollectAllDynamicResForLoad();
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

	// Token: 0x0601FC15 RID: 130069 RVA: 0x00A77A44 File Offset: 0x00A75C44
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int PostOnLoadAllResCompleted(IntPtr l)
	{
		int result;
		try
		{
			LoginUITask loginUITask = (LoginUITask)LuaObject.checkSelf(l);
			loginUITask.m_luaExportHelper.PostOnLoadAllResCompleted();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601FC16 RID: 130070 RVA: 0x00A77A98 File Offset: 0x00A75C98
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int InitLayerStateOnLoadAllResCompleted(IntPtr l)
	{
		int result;
		try
		{
			LoginUITask loginUITask = (LoginUITask)LuaObject.checkSelf(l);
			loginUITask.m_luaExportHelper.InitLayerStateOnLoadAllResCompleted();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601FC17 RID: 130071 RVA: 0x00A77AEC File Offset: 0x00A75CEC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int InitAllUIControllers(IntPtr l)
	{
		int result;
		try
		{
			LoginUITask loginUITask = (LoginUITask)LuaObject.checkSelf(l);
			loginUITask.m_luaExportHelper.InitAllUIControllers();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601FC18 RID: 130072 RVA: 0x00A77B40 File Offset: 0x00A75D40
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int StartCoroutineKeepUpdatingServerList(IntPtr l)
	{
		int result;
		try
		{
			LoginUITask loginUITask = (LoginUITask)LuaObject.checkSelf(l);
			loginUITask.m_luaExportHelper.StartCoroutineKeepUpdatingServerList();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601FC19 RID: 130073 RVA: 0x00A77B94 File Offset: 0x00A75D94
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int ClearAllContextAndRes(IntPtr l)
	{
		int result;
		try
		{
			LoginUITask loginUITask = (LoginUITask)LuaObject.checkSelf(l);
			loginUITask.m_luaExportHelper.ClearAllContextAndRes();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601FC1A RID: 130074 RVA: 0x00A77BE8 File Offset: 0x00A75DE8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int ServerListUIController_OnServerListClosed(IntPtr l)
	{
		int result;
		try
		{
			LoginUITask loginUITask = (LoginUITask)LuaObject.checkSelf(l);
			int selectedServerID;
			LuaObject.checkType(l, 2, out selectedServerID);
			loginUITask.m_luaExportHelper.ServerListUIController_OnServerListClosed(selectedServerID);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601FC1B RID: 130075 RVA: 0x00A77C44 File Offset: 0x00A75E44
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int OnStart(IntPtr l)
	{
		int result;
		try
		{
			LoginUITask loginUITask = (LoginUITask)LuaObject.checkSelf(l);
			UIIntent intent;
			LuaObject.checkType<UIIntent>(l, 2, out intent);
			bool b = loginUITask.m_luaExportHelper.OnStart(intent);
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

	// Token: 0x0601FC1C RID: 130076 RVA: 0x00A77CAC File Offset: 0x00A75EAC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int OnStop(IntPtr l)
	{
		int result;
		try
		{
			LoginUITask loginUITask = (LoginUITask)LuaObject.checkSelf(l);
			loginUITask.m_luaExportHelper.OnStop();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601FC1D RID: 130077 RVA: 0x00A77D00 File Offset: 0x00A75F00
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int OnResume(IntPtr l)
	{
		int result;
		try
		{
			LoginUITask loginUITask = (LoginUITask)LuaObject.checkSelf(l);
			UIIntent intent;
			LuaObject.checkType<UIIntent>(l, 2, out intent);
			bool b = loginUITask.m_luaExportHelper.OnResume(intent);
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

	// Token: 0x0601FC1E RID: 130078 RVA: 0x00A77D68 File Offset: 0x00A75F68
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int OnTick(IntPtr l)
	{
		int result;
		try
		{
			LoginUITask loginUITask = (LoginUITask)LuaObject.checkSelf(l);
			loginUITask.m_luaExportHelper.OnTick();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601FC1F RID: 130079 RVA: 0x00A77DBC File Offset: 0x00A75FBC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int UpdateView(IntPtr l)
	{
		int result;
		try
		{
			LoginUITask loginUITask = (LoginUITask)LuaObject.checkSelf(l);
			loginUITask.m_luaExportHelper.UpdateView();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601FC20 RID: 130080 RVA: 0x00A77E10 File Offset: 0x00A76010
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int PostUpdateView(IntPtr l)
	{
		int result;
		try
		{
			LoginUITask loginUITask = (LoginUITask)LuaObject.checkSelf(l);
			loginUITask.m_luaExportHelper.PostUpdateView();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601FC21 RID: 130081 RVA: 0x00A77E64 File Offset: 0x00A76064
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int StopEntryUITask(IntPtr l)
	{
		int result;
		try
		{
			LoginUITask loginUITask = (LoginUITask)LuaObject.checkSelf(l);
			loginUITask.m_luaExportHelper.StopEntryUITask();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601FC22 RID: 130082 RVA: 0x00A77EB8 File Offset: 0x00A760B8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int DownloadServerListFile(IntPtr l)
	{
		int result;
		try
		{
			LoginUITask loginUITask = (LoginUITask)LuaObject.checkSelf(l);
			loginUITask.m_luaExportHelper.DownloadServerListFile();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601FC23 RID: 130083 RVA: 0x00A77F0C File Offset: 0x00A7610C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int DownloadAnnounceFile(IntPtr l)
	{
		int result;
		try
		{
			LoginUITask loginUITask = (LoginUITask)LuaObject.checkSelf(l);
			bool isShow;
			LuaObject.checkType(l, 2, out isShow);
			loginUITask.m_luaExportHelper.DownloadAnnounceFile(isShow);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601FC24 RID: 130084 RVA: 0x00A77F68 File Offset: 0x00A76168
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int DownloadGMUserIDs(IntPtr l)
	{
		int result;
		try
		{
			LoginUITask loginUITask = (LoginUITask)LuaObject.checkSelf(l);
			loginUITask.m_luaExportHelper.DownloadGMUserIDs();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601FC25 RID: 130085 RVA: 0x00A77FBC File Offset: 0x00A761BC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int ParseGMUserIDsText(IntPtr l)
	{
		int result;
		try
		{
			LoginUITask loginUITask = (LoginUITask)LuaObject.checkSelf(l);
			string text;
			LuaObject.checkType(l, 2, out text);
			loginUITask.m_luaExportHelper.ParseGMUserIDsText(text);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601FC26 RID: 130086 RVA: 0x00A78018 File Offset: 0x00A76218
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int IsSdkIDCanLoginPCClient(IntPtr l)
	{
		int result;
		try
		{
			LoginUITask loginUITask = (LoginUITask)LuaObject.checkSelf(l);
			string sdkChannelID;
			LuaObject.checkType(l, 2, out sdkChannelID);
			bool b = loginUITask.m_luaExportHelper.IsSdkIDCanLoginPCClient(sdkChannelID);
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

	// Token: 0x0601FC27 RID: 130087 RVA: 0x00A78080 File Offset: 0x00A76280
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int UpdateLocalConfigGMUser(IntPtr l)
	{
		int result;
		try
		{
			LoginUITask loginUITask = (LoginUITask)LuaObject.checkSelf(l);
			loginUITask.m_luaExportHelper.UpdateLocalConfigGMUser();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601FC28 RID: 130088 RVA: 0x00A780D4 File Offset: 0x00A762D4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int ReqExistChars(IntPtr l)
	{
		int result;
		try
		{
			LoginUITask loginUITask = (LoginUITask)LuaObject.checkSelf(l);
			loginUITask.m_luaExportHelper.ReqExistChars();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601FC29 RID: 130089 RVA: 0x00A78128 File Offset: 0x00A76328
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int LaunchEnterGameUIWithGameSettingTokenAndServer(IntPtr l)
	{
		int result;
		try
		{
			LoginUITask loginUITask = (LoginUITask)LuaObject.checkSelf(l);
			loginUITask.m_luaExportHelper.LaunchEnterGameUIWithGameSettingTokenAndServer();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601FC2A RID: 130090 RVA: 0x00A7817C File Offset: 0x00A7637C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int LaunchEnterGameUIWithUIInputAccountAndServer(IntPtr l)
	{
		int result;
		try
		{
			LoginUITask loginUITask = (LoginUITask)LuaObject.checkSelf(l);
			loginUITask.m_luaExportHelper.LaunchEnterGameUIWithUIInputAccountAndServer();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601FC2B RID: 130091 RVA: 0x00A781D0 File Offset: 0x00A763D0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int DownloadGameServerLoginAnnouncement(IntPtr l)
	{
		int result;
		try
		{
			LoginUITask loginUITask = (LoginUITask)LuaObject.checkSelf(l);
			Action<bool> onEnd;
			LuaObject.checkDelegate<Action<bool>>(l, 2, out onEnd);
			IEnumerator o = loginUITask.m_luaExportHelper.DownloadGameServerLoginAnnouncement(onEnd);
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

	// Token: 0x0601FC2C RID: 130092 RVA: 0x00A78238 File Offset: 0x00A76438
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int ShowGameServerLoginAnnouncementUI(IntPtr l)
	{
		int result;
		try
		{
			LoginUITask loginUITask = (LoginUITask)LuaObject.checkSelf(l);
			loginUITask.m_luaExportHelper.ShowGameServerLoginAnnouncementUI();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601FC2D RID: 130093 RVA: 0x00A7828C File Offset: 0x00A7648C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int ShowEnterGameUI(IntPtr l)
	{
		int result;
		try
		{
			LoginUITask loginUITask = (LoginUITask)LuaObject.checkSelf(l);
			loginUITask.m_luaExportHelper.ShowEnterGameUI();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601FC2E RID: 130094 RVA: 0x00A782E0 File Offset: 0x00A764E0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int StartLoginAgentLogin(IntPtr l)
	{
		int result;
		try
		{
			LoginUITask loginUITask = (LoginUITask)LuaObject.checkSelf(l);
			Action<int, string, string> onEnd;
			LuaObject.checkDelegate<Action<int, string, string>>(l, 2, out onEnd);
			IEnumerator o = loginUITask.m_luaExportHelper.StartLoginAgentLogin(onEnd);
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

	// Token: 0x0601FC2F RID: 130095 RVA: 0x00A78348 File Offset: 0x00A76548
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int OnLoginByAuthTokenAck(IntPtr l)
	{
		int result;
		try
		{
			LoginUITask loginUITask = (LoginUITask)LuaObject.checkSelf(l);
			int ret;
			LuaObject.checkType(l, 2, out ret);
			string sessionToken;
			LuaObject.checkType(l, 3, out sessionToken);
			bool needRedirect;
			LuaObject.checkType(l, 4, out needRedirect);
			bool b = loginUITask.m_luaExportHelper.OnLoginByAuthTokenAck(ret, sessionToken, needRedirect);
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

	// Token: 0x0601FC30 RID: 130096 RVA: 0x00A783CC File Offset: 0x00A765CC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int DelayEnableInput(IntPtr l)
	{
		int result;
		try
		{
			LoginUITask loginUITask = (LoginUITask)LuaObject.checkSelf(l);
			bool isEnable;
			LuaObject.checkType(l, 2, out isEnable);
			float delaySeconds;
			LuaObject.checkType(l, 3, out delaySeconds);
			IEnumerator o = loginUITask.m_luaExportHelper.DelayEnableInput(isEnable, delaySeconds);
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

	// Token: 0x0601FC31 RID: 130097 RVA: 0x00A78440 File Offset: 0x00A76640
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int OnLoginBySessionTokenAck(IntPtr l)
	{
		int result;
		try
		{
			LoginUITask loginUITask = (LoginUITask)LuaObject.checkSelf(l);
			int ret;
			LuaObject.checkType(l, 2, out ret);
			bool b = loginUITask.m_luaExportHelper.OnLoginBySessionTokenAck(ret);
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

	// Token: 0x0601FC32 RID: 130098 RVA: 0x00A784A8 File Offset: 0x00A766A8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int LoginBySessionTokenAgain(IntPtr l)
	{
		int result;
		try
		{
			LoginUITask loginUITask = (LoginUITask)LuaObject.checkSelf(l);
			IEnumerator o = loginUITask.m_luaExportHelper.LoginBySessionTokenAgain();
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

	// Token: 0x0601FC33 RID: 130099 RVA: 0x00A78504 File Offset: 0x00A76704
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int StartPlayerInfoInitReq(IntPtr l)
	{
		int result;
		try
		{
			LoginUITask loginUITask = (LoginUITask)LuaObject.checkSelf(l);
			loginUITask.m_luaExportHelper.StartPlayerInfoInitReq();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601FC34 RID: 130100 RVA: 0x00A78558 File Offset: 0x00A76758
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int OnPlayerInfoInitEnd(IntPtr l)
	{
		int result;
		try
		{
			LoginUITask loginUITask = (LoginUITask)LuaObject.checkSelf(l);
			loginUITask.m_luaExportHelper.OnPlayerInfoInitEnd();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601FC35 RID: 130101 RVA: 0x00A785AC File Offset: 0x00A767AC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int PlayerContext_OnGameServerNetworkError(IntPtr l)
	{
		int result;
		try
		{
			LoginUITask loginUITask = (LoginUITask)LuaObject.checkSelf(l);
			loginUITask.m_luaExportHelper.PlayerContext_OnGameServerNetworkError();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601FC36 RID: 130102 RVA: 0x00A78600 File Offset: 0x00A76800
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int LauncheMainUI(IntPtr l)
	{
		int result;
		try
		{
			LoginUITask loginUITask = (LoginUITask)LuaObject.checkSelf(l);
			loginUITask.m_luaExportHelper.LauncheMainUI();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601FC37 RID: 130103 RVA: 0x00A78654 File Offset: 0x00A76854
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int OnWaitingMsgAckOutTime(IntPtr l)
	{
		int result;
		try
		{
			LoginUITask loginUITask = (LoginUITask)LuaObject.checkSelf(l);
			loginUITask.m_luaExportHelper.OnWaitingMsgAckOutTime();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601FC38 RID: 130104 RVA: 0x00A786A8 File Offset: 0x00A768A8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int OnGameServerConnected(IntPtr l)
	{
		int result;
		try
		{
			LoginUITask loginUITask = (LoginUITask)LuaObject.checkSelf(l);
			loginUITask.m_luaExportHelper.OnGameServerConnected();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601FC39 RID: 130105 RVA: 0x00A786FC File Offset: 0x00A768FC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int OnGameServerNetworkError(IntPtr l)
	{
		int result;
		try
		{
			LoginUITask loginUITask = (LoginUITask)LuaObject.checkSelf(l);
			loginUITask.m_luaExportHelper.OnGameServerNetworkError();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601FC3A RID: 130106 RVA: 0x00A78750 File Offset: 0x00A76950
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int ShowCreateCharacterUI(IntPtr l)
	{
		int result;
		try
		{
			LoginUITask loginUITask = (LoginUITask)LuaObject.checkSelf(l);
			loginUITask.m_luaExportHelper.ShowCreateCharacterUI();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601FC3B RID: 130107 RVA: 0x00A787A4 File Offset: 0x00A769A4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int StartCreateCharacterReq(IntPtr l)
	{
		int result;
		try
		{
			LoginUITask loginUITask = (LoginUITask)LuaObject.checkSelf(l);
			loginUITask.m_luaExportHelper.StartCreateCharacterReq();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601FC3C RID: 130108 RVA: 0x00A787F8 File Offset: 0x00A769F8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int IsSessionTokenValid(IntPtr l)
	{
		int result;
		try
		{
			LoginUITask loginUITask = (LoginUITask)LuaObject.checkSelf(l);
			string sessionToken;
			LuaObject.checkType(l, 2, out sessionToken);
			bool b = loginUITask.m_luaExportHelper.IsSessionTokenValid(sessionToken);
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

	// Token: 0x0601FC3D RID: 130109 RVA: 0x00A78860 File Offset: 0x00A76A60
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int SaveLoginInfo(IntPtr l)
	{
		int result;
		try
		{
			LoginUITask loginUITask = (LoginUITask)LuaObject.checkSelf(l);
			loginUITask.m_luaExportHelper.SaveLoginInfo();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601FC3E RID: 130110 RVA: 0x00A788B4 File Offset: 0x00A76AB4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int CreateRandomName(IntPtr l)
	{
		int result;
		try
		{
			LoginUITask loginUITask = (LoginUITask)LuaObject.checkSelf(l);
			string s = loginUITask.m_luaExportHelper.CreateRandomName();
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

	// Token: 0x0601FC3F RID: 130111 RVA: 0x00A78910 File Offset: 0x00A76B10
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int EnableInput(IntPtr l)
	{
		int result;
		try
		{
			LoginUITask loginUITask = (LoginUITask)LuaObject.checkSelf(l);
			bool isEnable;
			LuaObject.checkType(l, 2, out isEnable);
			loginUITask.m_luaExportHelper.EnableInput(isEnable);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601FC40 RID: 130112 RVA: 0x00A7896C File Offset: 0x00A76B6C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int PDLogin(IntPtr l)
	{
		int result;
		try
		{
			LoginUITask loginUITask = (LoginUITask)LuaObject.checkSelf(l);
			loginUITask.m_luaExportHelper.PDLogin();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601FC41 RID: 130113 RVA: 0x00A789C0 File Offset: 0x00A76BC0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int LoginUIController_OnLoginPCClient(IntPtr l)
	{
		int result;
		try
		{
			LoginUITask loginUITask = (LoginUITask)LuaObject.checkSelf(l);
			loginUITask.m_luaExportHelper.LoginUIController_OnLoginPCClient();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601FC42 RID: 130114 RVA: 0x00A78A14 File Offset: 0x00A76C14
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int PDSDK_OnInitFailed(IntPtr l)
	{
		int result;
		try
		{
			LoginUITask loginUITask = (LoginUITask)LuaObject.checkSelf(l);
			loginUITask.m_luaExportHelper.PDSDK_OnInitFailed();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601FC43 RID: 130115 RVA: 0x00A78A68 File Offset: 0x00A76C68
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int PDSDK_OnInitSucess(IntPtr l)
	{
		int result;
		try
		{
			LoginUITask loginUITask = (LoginUITask)LuaObject.checkSelf(l);
			loginUITask.m_luaExportHelper.PDSDK_OnInitSucess();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601FC44 RID: 130116 RVA: 0x00A78ABC File Offset: 0x00A76CBC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int ClearSDKUserIDOfAllServer(IntPtr l)
	{
		int result;
		try
		{
			LoginUITask loginUITask = (LoginUITask)LuaObject.checkSelf(l);
			loginUITask.m_luaExportHelper.ClearSDKUserIDOfAllServer();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601FC45 RID: 130117 RVA: 0x00A78B10 File Offset: 0x00A76D10
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int ParseLoginAgentAck(IntPtr l)
	{
		int result;
		try
		{
			LoginUITask loginUITask = (LoginUITask)LuaObject.checkSelf(l);
			string ackText;
			LuaObject.checkType(l, 2, out ackText);
			string s;
			LuaObject.checkType(l, 3, out s);
			string s2;
			LuaObject.checkType(l, 4, out s2);
			string s3;
			LuaObject.checkType(l, 5, out s3);
			string s4;
			LuaObject.checkType(l, 6, out s4);
			string s5;
			LuaObject.checkType(l, 7, out s5);
			bool b = loginUITask.m_luaExportHelper.ParseLoginAgentAck(ackText, ref s, ref s2, ref s3, ref s4, ref s5);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, b);
			LuaObject.pushValue(l, s);
			LuaObject.pushValue(l, s2);
			LuaObject.pushValue(l, s3);
			LuaObject.pushValue(l, s4);
			LuaObject.pushValue(l, s5);
			result = 7;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601FC46 RID: 130118 RVA: 0x00A78BE0 File Offset: 0x00A76DE0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int LoginAgent(IntPtr l)
	{
		int result;
		try
		{
			LoginUITask loginUITask = (LoginUITask)LuaObject.checkSelf(l);
			string svrUrl;
			LuaObject.checkType(l, 2, out svrUrl);
			string data;
			LuaObject.checkType(l, 3, out data);
			string opcode;
			LuaObject.checkType(l, 4, out opcode);
			string channel_id;
			LuaObject.checkType(l, 5, out channel_id);
			string customparams;
			LuaObject.checkType(l, 6, out customparams);
			IEnumerator o = loginUITask.m_luaExportHelper.LoginAgent(svrUrl, data, opcode, channel_id, customparams);
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

	// Token: 0x0601FC47 RID: 130119 RVA: 0x00A78C7C File Offset: 0x00A76E7C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int SetPlatformInfoToServerList(IntPtr l)
	{
		int result;
		try
		{
			LoginUITask loginUITask = (LoginUITask)LuaObject.checkSelf(l);
			string loginAgentUrl;
			LuaObject.checkType(l, 2, out loginAgentUrl);
			string platformName;
			LuaObject.checkType(l, 3, out platformName);
			string platformUserID;
			LuaObject.checkType(l, 4, out platformUserID);
			loginUITask.m_luaExportHelper.SetPlatformInfoToServerList(loginAgentUrl, platformName, platformUserID);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601FC48 RID: 130120 RVA: 0x00A78CF4 File Offset: 0x00A76EF4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int LoginUIController_OnOpenUserCenter(IntPtr l)
	{
		int result;
		try
		{
			LoginUITask loginUITask = (LoginUITask)LuaObject.checkSelf(l);
			loginUITask.m_luaExportHelper.LoginUIController_OnOpenUserCenter();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601FC49 RID: 130121 RVA: 0x00A78D48 File Offset: 0x00A76F48
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int SwitchUserAccount(IntPtr l)
	{
		int result;
		try
		{
			LoginUITask loginUITask = (LoginUITask)LuaObject.checkSelf(l);
			IEnumerator o = loginUITask.m_luaExportHelper.SwitchUserAccount();
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

	// Token: 0x0601FC4A RID: 130122 RVA: 0x00A78DA4 File Offset: 0x00A76FA4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int LoginUIController_OnAccountTextChanged(IntPtr l)
	{
		int result;
		try
		{
			LoginUITask loginUITask = (LoginUITask)LuaObject.checkSelf(l);
			string text;
			LuaObject.checkType(l, 2, out text);
			loginUITask.m_luaExportHelper.LoginUIController_OnAccountTextChanged(text);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601FC4B RID: 130123 RVA: 0x00A78E00 File Offset: 0x00A77000
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int LoginUIController_OnSaveServerConfig(IntPtr l)
	{
		int result;
		try
		{
			LoginUITask loginUITask = (LoginUITask)LuaObject.checkSelf(l);
			loginUITask.m_luaExportHelper.LoginUIController_OnSaveServerConfig();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601FC4C RID: 130124 RVA: 0x00A78E54 File Offset: 0x00A77054
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int LoginUIController_OnCloseAnnouncePanel(IntPtr l)
	{
		int result;
		try
		{
			LoginUITask loginUITask = (LoginUITask)LuaObject.checkSelf(l);
			loginUITask.m_luaExportHelper.LoginUIController_OnCloseAnnouncePanel();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601FC4D RID: 130125 RVA: 0x00A78EA8 File Offset: 0x00A770A8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int LoginUIController_OnOpenAnnouncePanel(IntPtr l)
	{
		int result;
		try
		{
			LoginUITask loginUITask = (LoginUITask)LuaObject.checkSelf(l);
			loginUITask.m_luaExportHelper.LoginUIController_OnOpenAnnouncePanel();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601FC4E RID: 130126 RVA: 0x00A78EFC File Offset: 0x00A770FC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int LoginUIController_OnSelectServerClick(IntPtr l)
	{
		int result;
		try
		{
			LoginUITask loginUITask = (LoginUITask)LuaObject.checkSelf(l);
			loginUITask.m_luaExportHelper.LoginUIController_OnSelectServerClick();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601FC4F RID: 130127 RVA: 0x00A78F50 File Offset: 0x00A77150
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int IsNeedLoadStaticRes(IntPtr l)
	{
		int result;
		try
		{
			LoginUITask loginUITask = (LoginUITask)LuaObject.checkSelf(l);
			bool b = loginUITask.m_luaExportHelper.IsNeedLoadStaticRes();
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

	// Token: 0x0601FC50 RID: 130128 RVA: 0x00A78FAC File Offset: 0x00A771AC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int CollectAllStaticResDescForLoad(IntPtr l)
	{
		int result;
		try
		{
			LoginUITask loginUITask = (LoginUITask)LuaObject.checkSelf(l);
			List<UITaskBase.LayerDesc> o = loginUITask.m_luaExportHelper.CollectAllStaticResDescForLoad();
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

	// Token: 0x0601FC51 RID: 130129 RVA: 0x00A79008 File Offset: 0x00A77208
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int ShowServerListUI(IntPtr l)
	{
		int result;
		try
		{
			LoginUITask loginUITask = (LoginUITask)LuaObject.checkSelf(l);
			bool isShow;
			LuaObject.checkType(l, 2, out isShow);
			loginUITask.m_luaExportHelper.ShowServerListUI(isShow);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601FC52 RID: 130130 RVA: 0x00A79064 File Offset: 0x00A77264
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int KeepUpdatingServerList(IntPtr l)
	{
		int result;
		try
		{
			LoginUITask loginUITask = (LoginUITask)LuaObject.checkSelf(l);
			IEnumerator o = loginUITask.m_luaExportHelper.KeepUpdatingServerList();
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

	// Token: 0x0601FC53 RID: 130131 RVA: 0x00A790C0 File Offset: 0x00A772C0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int LoginUIController_OnLogin(IntPtr l)
	{
		int result;
		try
		{
			LoginUITask loginUITask = (LoginUITask)LuaObject.checkSelf(l);
			loginUITask.m_luaExportHelper.LoginUIController_OnLogin();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601FC54 RID: 130132 RVA: 0x00A79114 File Offset: 0x00A77314
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int CreateCharacterUIController_OnCreate(IntPtr l)
	{
		int result;
		try
		{
			LoginUITask loginUITask = (LoginUITask)LuaObject.checkSelf(l);
			loginUITask.m_luaExportHelper.CreateCharacterUIController_OnCreate();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601FC55 RID: 130133 RVA: 0x00A79168 File Offset: 0x00A77368
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int CreateCharacterUIController_OnAutoName(IntPtr l)
	{
		int result;
		try
		{
			LoginUITask loginUITask = (LoginUITask)LuaObject.checkSelf(l);
			loginUITask.m_luaExportHelper.CreateCharacterUIController_OnAutoName();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601FC56 RID: 130134 RVA: 0x00A791BC File Offset: 0x00A773BC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int UpdateServerList(IntPtr l)
	{
		int result;
		try
		{
			LoginUITask loginUITask = (LoginUITask)LuaObject.checkSelf(l);
			loginUITask.m_luaExportHelper.UpdateServerList();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601FC57 RID: 130135 RVA: 0x00A79210 File Offset: 0x00A77410
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_OnStop(IntPtr l)
	{
		int result;
		try
		{
			LoginUITask loginUITask = (LoginUITask)LuaObject.checkSelf(l);
			loginUITask.m_luaExportHelper.__callBase_OnStop();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601FC58 RID: 130136 RVA: 0x00A79264 File Offset: 0x00A77464
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_PostUpdateView(IntPtr l)
	{
		int result;
		try
		{
			LoginUITask loginUITask = (LoginUITask)LuaObject.checkSelf(l);
			loginUITask.m_luaExportHelper.__callBase_PostUpdateView();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601FC59 RID: 130137 RVA: 0x00A792B8 File Offset: 0x00A774B8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_IsSDKLogin(IntPtr l)
	{
		int result;
		try
		{
			LoginUITask loginUITask = (LoginUITask)LuaObject.checkSelf(l);
			bool b = loginUITask.m_luaExportHelper.__callBase_IsSDKLogin();
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

	// Token: 0x0601FC5A RID: 130138 RVA: 0x00A79314 File Offset: 0x00A77514
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_IsEditorTestLogin(IntPtr l)
	{
		int result;
		try
		{
			LoginUITask loginUITask = (LoginUITask)LuaObject.checkSelf(l);
			bool b = loginUITask.m_luaExportHelper.__callBase_IsEditorTestLogin();
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

	// Token: 0x0601FC5B RID: 130139 RVA: 0x00A79370 File Offset: 0x00A77570
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_StartInitSDK(IntPtr l)
	{
		int result;
		try
		{
			LoginUITask loginUITask = (LoginUITask)LuaObject.checkSelf(l);
			loginUITask.m_luaExportHelper.__callBase_StartInitSDK();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601FC5C RID: 130140 RVA: 0x00A793C4 File Offset: 0x00A775C4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_OnSDKInitEnd(IntPtr l)
	{
		int result;
		try
		{
			LoginUITask loginUITask = (LoginUITask)LuaObject.checkSelf(l);
			bool isSuccess;
			LuaObject.checkType(l, 2, out isSuccess);
			loginUITask.m_luaExportHelper.__callBase_OnSDKInitEnd(isSuccess);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601FC5D RID: 130141 RVA: 0x00A79420 File Offset: 0x00A77620
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_StartSDKLogin(IntPtr l)
	{
		int result;
		try
		{
			LoginUITask loginUITask = (LoginUITask)LuaObject.checkSelf(l);
			loginUITask.m_luaExportHelper.__callBase_StartSDKLogin();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601FC5E RID: 130142 RVA: 0x00A79474 File Offset: 0x00A77674
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_OnSDKLoginEnd(IntPtr l)
	{
		int result;
		try
		{
			LoginUITask loginUITask = (LoginUITask)LuaObject.checkSelf(l);
			bool isSuccess;
			LuaObject.checkType(l, 2, out isSuccess);
			loginUITask.m_luaExportHelper.__callBase_OnSDKLoginEnd(isSuccess);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601FC5F RID: 130143 RVA: 0x00A794D0 File Offset: 0x00A776D0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_PostSDKLogin(IntPtr l)
	{
		int result;
		try
		{
			LoginUITask loginUITask = (LoginUITask)LuaObject.checkSelf(l);
			loginUITask.m_luaExportHelper.__callBase_PostSDKLogin();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601FC60 RID: 130144 RVA: 0x00A79524 File Offset: 0x00A77724
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_IsNeedSelectServer(IntPtr l)
	{
		int result;
		try
		{
			LoginUITask loginUITask = (LoginUITask)LuaObject.checkSelf(l);
			bool b = loginUITask.m_luaExportHelper.__callBase_IsNeedSelectServer();
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

	// Token: 0x0601FC61 RID: 130145 RVA: 0x00A79580 File Offset: 0x00A77780
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_LaunchServerListUI(IntPtr l)
	{
		int result;
		try
		{
			LoginUITask loginUITask = (LoginUITask)LuaObject.checkSelf(l);
			loginUITask.m_luaExportHelper.__callBase_LaunchServerListUI();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601FC62 RID: 130146 RVA: 0x00A795D4 File Offset: 0x00A777D4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_DownloadServerList(IntPtr l)
	{
		int result;
		try
		{
			LoginUITask loginUITask = (LoginUITask)LuaObject.checkSelf(l);
			Action<bool> onEnd;
			LuaObject.checkDelegate<Action<bool>>(l, 2, out onEnd);
			IEnumerator o = loginUITask.m_luaExportHelper.__callBase_DownloadServerList(onEnd);
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

	// Token: 0x0601FC63 RID: 130147 RVA: 0x00A7963C File Offset: 0x00A7783C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_OnDownloadServerListEnd(IntPtr l)
	{
		int result;
		try
		{
			LoginUITask loginUITask = (LoginUITask)LuaObject.checkSelf(l);
			bool isSuccess;
			LuaObject.checkType(l, 2, out isSuccess);
			loginUITask.m_luaExportHelper.__callBase_OnDownloadServerListEnd(isSuccess);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601FC64 RID: 130148 RVA: 0x00A79698 File Offset: 0x00A77898
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_ShowServerListUI(IntPtr l)
	{
		int result;
		try
		{
			LoginUITask loginUITask = (LoginUITask)LuaObject.checkSelf(l);
			loginUITask.m_luaExportHelper.__callBase_ShowServerListUI();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601FC65 RID: 130149 RVA: 0x00A796EC File Offset: 0x00A778EC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_OnGameServerConfirmed(IntPtr l)
	{
		int result;
		try
		{
			LoginUITask loginUITask = (LoginUITask)LuaObject.checkSelf(l);
			string serverId;
			LuaObject.checkType(l, 2, out serverId);
			loginUITask.m_luaExportHelper.__callBase_OnGameServerConfirmed(serverId);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601FC66 RID: 130150 RVA: 0x00A79748 File Offset: 0x00A77948
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_InitServerCtxByServerID(IntPtr l)
	{
		int result;
		try
		{
			LoginUITask loginUITask = (LoginUITask)LuaObject.checkSelf(l);
			string serverId;
			LuaObject.checkType(l, 2, out serverId);
			loginUITask.m_luaExportHelper.__callBase_InitServerCtxByServerID(serverId);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601FC67 RID: 130151 RVA: 0x00A797A4 File Offset: 0x00A779A4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_GetLastLoginedServerID(IntPtr l)
	{
		int result;
		try
		{
			LoginUITask loginUITask = (LoginUITask)LuaObject.checkSelf(l);
			string s = loginUITask.m_luaExportHelper.__callBase_GetLastLoginedServerID();
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

	// Token: 0x0601FC68 RID: 130152 RVA: 0x00A79800 File Offset: 0x00A77A00
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_LaunchEnterGameUI(IntPtr l)
	{
		int result;
		try
		{
			LoginUITask loginUITask = (LoginUITask)LuaObject.checkSelf(l);
			loginUITask.m_luaExportHelper.__callBase_LaunchEnterGameUI();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601FC69 RID: 130153 RVA: 0x00A79854 File Offset: 0x00A77A54
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_LaunchEnterGameUIWithGameSettingTokenAndServer(IntPtr l)
	{
		int result;
		try
		{
			LoginUITask loginUITask = (LoginUITask)LuaObject.checkSelf(l);
			loginUITask.m_luaExportHelper.__callBase_LaunchEnterGameUIWithGameSettingTokenAndServer();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601FC6A RID: 130154 RVA: 0x00A798A8 File Offset: 0x00A77AA8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_LaunchEnterGameUIWithUIInputAccountAndServer(IntPtr l)
	{
		int result;
		try
		{
			LoginUITask loginUITask = (LoginUITask)LuaObject.checkSelf(l);
			loginUITask.m_luaExportHelper.__callBase_LaunchEnterGameUIWithUIInputAccountAndServer();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601FC6B RID: 130155 RVA: 0x00A798FC File Offset: 0x00A77AFC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_LoadLastLoginWithUIInputInfo(IntPtr l)
	{
		int result;
		try
		{
			LoginUITask loginUITask = (LoginUITask)LuaObject.checkSelf(l);
			string s;
			string s2;
			int i;
			bool b = loginUITask.m_luaExportHelper.__callBase_LoadLastLoginWithUIInputInfo(out s, out s2, out i);
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

	// Token: 0x0601FC6C RID: 130156 RVA: 0x00A79978 File Offset: 0x00A77B78
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_DownloadGameServerLoginAnnouncement(IntPtr l)
	{
		int result;
		try
		{
			LoginUITask loginUITask = (LoginUITask)LuaObject.checkSelf(l);
			Action<bool> onEnd;
			LuaObject.checkDelegate<Action<bool>>(l, 2, out onEnd);
			IEnumerator o = loginUITask.m_luaExportHelper.__callBase_DownloadGameServerLoginAnnouncement(onEnd);
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

	// Token: 0x0601FC6D RID: 130157 RVA: 0x00A799E0 File Offset: 0x00A77BE0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_OnDownloadGameServerLoginAnnouncementEnd(IntPtr l)
	{
		int result;
		try
		{
			LoginUITask loginUITask = (LoginUITask)LuaObject.checkSelf(l);
			bool isSuccess;
			LuaObject.checkType(l, 2, out isSuccess);
			loginUITask.m_luaExportHelper.__callBase_OnDownloadGameServerLoginAnnouncementEnd(isSuccess);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601FC6E RID: 130158 RVA: 0x00A79A3C File Offset: 0x00A77C3C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_ShowGameServerLoginAnnouncementUI(IntPtr l)
	{
		int result;
		try
		{
			LoginUITask loginUITask = (LoginUITask)LuaObject.checkSelf(l);
			loginUITask.m_luaExportHelper.__callBase_ShowGameServerLoginAnnouncementUI();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601FC6F RID: 130159 RVA: 0x00A79A90 File Offset: 0x00A77C90
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_ShowEnterGameUI(IntPtr l)
	{
		int result;
		try
		{
			LoginUITask loginUITask = (LoginUITask)LuaObject.checkSelf(l);
			loginUITask.m_luaExportHelper.__callBase_ShowEnterGameUI();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601FC70 RID: 130160 RVA: 0x00A79AE4 File Offset: 0x00A77CE4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_OnEnterGameConfirmed(IntPtr l)
	{
		int result;
		try
		{
			LoginUITask loginUITask = (LoginUITask)LuaObject.checkSelf(l);
			loginUITask.m_luaExportHelper.__callBase_OnEnterGameConfirmed();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601FC71 RID: 130161 RVA: 0x00A79B38 File Offset: 0x00A77D38
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_StartLoginAgentLogin(IntPtr l)
	{
		int result;
		try
		{
			LoginUITask loginUITask = (LoginUITask)LuaObject.checkSelf(l);
			Action<int, string, string> onEnd;
			LuaObject.checkDelegate<Action<int, string, string>>(l, 2, out onEnd);
			IEnumerator o = loginUITask.m_luaExportHelper.__callBase_StartLoginAgentLogin(onEnd);
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

	// Token: 0x0601FC72 RID: 130162 RVA: 0x00A79BA0 File Offset: 0x00A77DA0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_LoginAgentLoginEnd(IntPtr l)
	{
		int result;
		try
		{
			LoginUITask loginUITask = (LoginUITask)LuaObject.checkSelf(l);
			int errCode;
			LuaObject.checkType(l, 2, out errCode);
			string loginUserId;
			LuaObject.checkType(l, 3, out loginUserId);
			string authToken;
			LuaObject.checkType(l, 4, out authToken);
			loginUITask.m_luaExportHelper.__callBase_LoginAgentLoginEnd(errCode, loginUserId, authToken);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601FC73 RID: 130163 RVA: 0x00A79C18 File Offset: 0x00A77E18
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_StartAuthLogin(IntPtr l)
	{
		int result;
		try
		{
			LoginUITask loginUITask = (LoginUITask)LuaObject.checkSelf(l);
			loginUITask.m_luaExportHelper.__callBase_StartAuthLogin();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601FC74 RID: 130164 RVA: 0x00A79C6C File Offset: 0x00A77E6C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_StartSessionLogin(IntPtr l)
	{
		int result;
		try
		{
			LoginUITask loginUITask = (LoginUITask)LuaObject.checkSelf(l);
			loginUITask.m_luaExportHelper.__callBase_StartSessionLogin();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601FC75 RID: 130165 RVA: 0x00A79CC0 File Offset: 0x00A77EC0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_StartPlayerInfoInitReq(IntPtr l)
	{
		int result;
		try
		{
			LoginUITask loginUITask = (LoginUITask)LuaObject.checkSelf(l);
			loginUITask.m_luaExportHelper.__callBase_StartPlayerInfoInitReq();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601FC76 RID: 130166 RVA: 0x00A79D14 File Offset: 0x00A77F14
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_LauncheMainUI(IntPtr l)
	{
		int result;
		try
		{
			LoginUITask loginUITask = (LoginUITask)LuaObject.checkSelf(l);
			loginUITask.m_luaExportHelper.__callBase_LauncheMainUI();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601FC77 RID: 130167 RVA: 0x00A79D68 File Offset: 0x00A77F68
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_OnWaitingMsgAckOutTime(IntPtr l)
	{
		int result;
		try
		{
			LoginUITask loginUITask = (LoginUITask)LuaObject.checkSelf(l);
			loginUITask.m_luaExportHelper.__callBase_OnWaitingMsgAckOutTime();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601FC78 RID: 130168 RVA: 0x00A79DBC File Offset: 0x00A77FBC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_StartWaitingMsgAck(IntPtr l)
	{
		int result;
		try
		{
			LoginUITask loginUITask = (LoginUITask)LuaObject.checkSelf(l);
			float waitTime;
			LuaObject.checkType(l, 2, out waitTime);
			loginUITask.m_luaExportHelper.__callBase_StartWaitingMsgAck(waitTime);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601FC79 RID: 130169 RVA: 0x00A79E18 File Offset: 0x00A78018
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_StopWaitingMsgAck(IntPtr l)
	{
		int result;
		try
		{
			LoginUITask loginUITask = (LoginUITask)LuaObject.checkSelf(l);
			loginUITask.m_luaExportHelper.__callBase_StopWaitingMsgAck();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601FC7A RID: 130170 RVA: 0x00A79E6C File Offset: 0x00A7806C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_ClearGameServerLoginState(IntPtr l)
	{
		int result;
		try
		{
			LoginUITask loginUITask = (LoginUITask)LuaObject.checkSelf(l);
			loginUITask.m_luaExportHelper.__callBase_ClearGameServerLoginState();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601FC7B RID: 130171 RVA: 0x00A79EC0 File Offset: 0x00A780C0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_OnTick(IntPtr l)
	{
		int result;
		try
		{
			LoginUITask loginUITask = (LoginUITask)LuaObject.checkSelf(l);
			loginUITask.m_luaExportHelper.__callBase_OnTick();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601FC7C RID: 130172 RVA: 0x00A79F14 File Offset: 0x00A78114
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_OnGameServerConnected(IntPtr l)
	{
		int result;
		try
		{
			LoginUITask loginUITask = (LoginUITask)LuaObject.checkSelf(l);
			loginUITask.m_luaExportHelper.__callBase_OnGameServerConnected();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601FC7D RID: 130173 RVA: 0x00A79F68 File Offset: 0x00A78168
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_OnGameServerDisconnected(IntPtr l)
	{
		int result;
		try
		{
			LoginUITask loginUITask = (LoginUITask)LuaObject.checkSelf(l);
			loginUITask.m_luaExportHelper.__callBase_OnGameServerDisconnected();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601FC7E RID: 130174 RVA: 0x00A79FBC File Offset: 0x00A781BC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_OnGameServerNetworkError(IntPtr l)
	{
		int result;
		try
		{
			LoginUITask loginUITask = (LoginUITask)LuaObject.checkSelf(l);
			loginUITask.m_luaExportHelper.__callBase_OnGameServerNetworkError();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601FC7F RID: 130175 RVA: 0x00A7A010 File Offset: 0x00A78210
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_OnLoginByAuthTokenAck(IntPtr l)
	{
		int result;
		try
		{
			LoginUITask loginUITask = (LoginUITask)LuaObject.checkSelf(l);
			int ret;
			LuaObject.checkType(l, 2, out ret);
			string sessionToken;
			LuaObject.checkType(l, 3, out sessionToken);
			bool needRedirect;
			LuaObject.checkType(l, 4, out needRedirect);
			bool b = loginUITask.m_luaExportHelper.__callBase_OnLoginByAuthTokenAck(ret, sessionToken, needRedirect);
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

	// Token: 0x0601FC80 RID: 130176 RVA: 0x00A7A094 File Offset: 0x00A78294
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_OnLoginBySessionTokenAck(IntPtr l)
	{
		int result;
		try
		{
			LoginUITask loginUITask = (LoginUITask)LuaObject.checkSelf(l);
			int ret;
			LuaObject.checkType(l, 2, out ret);
			bool b = loginUITask.m_luaExportHelper.__callBase_OnLoginBySessionTokenAck(ret);
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

	// Token: 0x0601FC81 RID: 130177 RVA: 0x00A7A0FC File Offset: 0x00A782FC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_OnConfigDataMD5InfoNtf(IntPtr l)
	{
		int result;
		try
		{
			LoginUITask loginUITask = (LoginUITask)LuaObject.checkSelf(l);
			string fileNameWithErrorMD;
			LuaObject.checkType(l, 2, out fileNameWithErrorMD);
			string localMD;
			LuaObject.checkType(l, 3, out localMD);
			string serverMD;
			LuaObject.checkType(l, 4, out serverMD);
			loginUITask.m_luaExportHelper.__callBase_OnConfigDataMD5InfoNtf(fileNameWithErrorMD, localMD, serverMD);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601FC82 RID: 130178 RVA: 0x00A7A174 File Offset: 0x00A78374
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_OnPlayerInfoInitEnd(IntPtr l)
	{
		int result;
		try
		{
			LoginUITask loginUITask = (LoginUITask)LuaObject.checkSelf(l);
			loginUITask.m_luaExportHelper.__callBase_OnPlayerInfoInitEnd();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601FC83 RID: 130179 RVA: 0x00A7A1C8 File Offset: 0x00A783C8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int InitializeGlobals_s(IntPtr l)
	{
		int result;
		try
		{
			LoginUITask.LuaExportHelper.InitializeGlobals();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601FC84 RID: 130180 RVA: 0x00A7A208 File Offset: 0x00A78408
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int InitLocalConfig_s(IntPtr l)
	{
		int result;
		try
		{
			LoginUITask.LuaExportHelper.InitLocalConfig();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601FC85 RID: 130181 RVA: 0x00A7A248 File Offset: 0x00A78448
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int LogSystemInfo_s(IntPtr l)
	{
		int result;
		try
		{
			LoginUITask.LuaExportHelper.LogSystemInfo();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601FC86 RID: 130182 RVA: 0x00A7A288 File Offset: 0x00A78488
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int GetPushNotificationTime_s(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataDailyPushNotification cfg;
			LuaObject.checkType<ConfigDataDailyPushNotification>(l, 1, out cfg);
			DateTime pushNotificationTime = LoginUITask.LuaExportHelper.GetPushNotificationTime(cfg);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, pushNotificationTime);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601FC87 RID: 130183 RVA: 0x00A7A2E0 File Offset: 0x00A784E0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int GetRecentLoginServerList_s(IntPtr l)
	{
		int result;
		try
		{
			List<LoginUITask.ServerInfo> recentLoginServerList = LoginUITask.LuaExportHelper.GetRecentLoginServerList();
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, recentLoginServerList);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601FC88 RID: 130184 RVA: 0x00A7A328 File Offset: 0x00A78528
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int GetStartGameOrCreateRoleJsonString_s(IntPtr l)
	{
		int result;
		try
		{
			string rolenameProperty;
			LuaObject.checkType(l, 1, out rolenameProperty);
			string startGameOrCreateRoleJsonString = LoginUITask.LuaExportHelper.GetStartGameOrCreateRoleJsonString(rolenameProperty);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, startGameOrCreateRoleJsonString);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601FC89 RID: 130185 RVA: 0x00A7A37C File Offset: 0x00A7857C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int Co_UnloadAssetsAndStartPreloadUITask_s(IntPtr l)
	{
		int result;
		try
		{
			IEnumerator o = LoginUITask.LuaExportHelper.Co_UnloadAssetsAndStartPreloadUITask();
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

	// Token: 0x0601FC8A RID: 130186 RVA: 0x00A7A3C4 File Offset: 0x00A785C4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int NetWorkTransactionTask_OnReLoginBySession_s(IntPtr l)
	{
		int result;
		try
		{
			Action action;
			LuaObject.checkDelegate<Action>(l, 1, out action);
			LoginUITask.LuaExportHelper.NetWorkTransactionTask_OnReLoginBySession(action);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601FC8B RID: 130187 RVA: 0x00A7A410 File Offset: 0x00A78610
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int NetWorkTransactionTask_ReturnToLoginUI_s(IntPtr l)
	{
		int result;
		try
		{
			bool isDataDirty;
			LuaObject.checkType(l, 1, out isDataDirty);
			LoginUITask.LuaExportHelper.NetWorkTransactionTask_ReturnToLoginUI(isDataDirty);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601FC8C RID: 130188 RVA: 0x00A7A45C File Offset: 0x00A7865C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int ParseServerListText_s(IntPtr l)
	{
		int result;
		try
		{
			string serverListText;
			LuaObject.checkType(l, 1, out serverListText);
			LoginUITask.LuaExportHelper.ParseServerListText(serverListText);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601FC8D RID: 130189 RVA: 0x00A7A4A8 File Offset: 0x00A786A8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int ParseServerOpenDateTime_s(IntPtr l)
	{
		int result;
		try
		{
			string dt;
			LuaObject.checkType(l, 1, out dt);
			string s = LoginUITask.LuaExportHelper.ParseServerOpenDateTime(dt);
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

	// Token: 0x0601FC8E RID: 130190 RVA: 0x00A7A4FC File Offset: 0x00A786FC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int NetWorkTransactionTask_OnEventShowUIWaiting_s(IntPtr l)
	{
		int result;
		try
		{
			bool show;
			LuaObject.checkType(l, 1, out show);
			LoginUITask.LuaExportHelper.NetWorkTransactionTask_OnEventShowUIWaiting(show);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601FC8F RID: 130191 RVA: 0x00A7A548 File Offset: 0x00A78748
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_layerDescArray(IntPtr l)
	{
		int result;
		try
		{
			LoginUITask loginUITask = (LoginUITask)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, loginUITask.m_luaExportHelper.m_layerDescArray);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601FC90 RID: 130192 RVA: 0x00A7A5A0 File Offset: 0x00A787A0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_layerDescArray(IntPtr l)
	{
		int result;
		try
		{
			LoginUITask loginUITask = (LoginUITask)LuaObject.checkSelf(l);
			UITaskBase.LayerDesc[] layerDescArray;
			LuaObject.checkArray<UITaskBase.LayerDesc>(l, 2, out layerDescArray);
			loginUITask.m_luaExportHelper.m_layerDescArray = layerDescArray;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601FC91 RID: 130193 RVA: 0x00A7A5FC File Offset: 0x00A787FC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_uiCtrlDescArray(IntPtr l)
	{
		int result;
		try
		{
			LoginUITask loginUITask = (LoginUITask)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, loginUITask.m_luaExportHelper.m_uiCtrlDescArray);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601FC92 RID: 130194 RVA: 0x00A7A654 File Offset: 0x00A78854
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_uiCtrlDescArray(IntPtr l)
	{
		int result;
		try
		{
			LoginUITask loginUITask = (LoginUITask)LuaObject.checkSelf(l);
			UITaskBase.UIControllerDesc[] uiCtrlDescArray;
			LuaObject.checkArray<UITaskBase.UIControllerDesc>(l, 2, out uiCtrlDescArray);
			loginUITask.m_luaExportHelper.m_uiCtrlDescArray = uiCtrlDescArray;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601FC93 RID: 130195 RVA: 0x00A7A6B0 File Offset: 0x00A788B0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_loginAgentCoroutine(IntPtr l)
	{
		int result;
		try
		{
			LoginUITask loginUITask = (LoginUITask)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, loginUITask.m_luaExportHelper.m_loginAgentCoroutine);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601FC94 RID: 130196 RVA: 0x00A7A708 File Offset: 0x00A78908
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_loginAgentCoroutine(IntPtr l)
	{
		int result;
		try
		{
			LoginUITask loginUITask = (LoginUITask)LuaObject.checkSelf(l);
			Coroutine loginAgentCoroutine;
			LuaObject.checkType<Coroutine>(l, 2, out loginAgentCoroutine);
			loginUITask.m_luaExportHelper.m_loginAgentCoroutine = loginAgentCoroutine;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601FC95 RID: 130197 RVA: 0x00A7A764 File Offset: 0x00A78964
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_loginUIController(IntPtr l)
	{
		int result;
		try
		{
			LoginUITask loginUITask = (LoginUITask)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, loginUITask.m_luaExportHelper.m_loginUIController);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601FC96 RID: 130198 RVA: 0x00A7A7BC File Offset: 0x00A789BC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_loginUIController(IntPtr l)
	{
		int result;
		try
		{
			LoginUITask loginUITask = (LoginUITask)LuaObject.checkSelf(l);
			LoginUIController loginUIController;
			LuaObject.checkType<LoginUIController>(l, 2, out loginUIController);
			loginUITask.m_luaExportHelper.m_loginUIController = loginUIController;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601FC97 RID: 130199 RVA: 0x00A7A818 File Offset: 0x00A78A18
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_serverListUIController(IntPtr l)
	{
		int result;
		try
		{
			LoginUITask loginUITask = (LoginUITask)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, loginUITask.m_luaExportHelper.m_serverListUIController);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601FC98 RID: 130200 RVA: 0x00A7A870 File Offset: 0x00A78A70
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_serverListUIController(IntPtr l)
	{
		int result;
		try
		{
			LoginUITask loginUITask = (LoginUITask)LuaObject.checkSelf(l);
			ServerListUIController serverListUIController;
			LuaObject.checkType<ServerListUIController>(l, 2, out serverListUIController);
			loginUITask.m_luaExportHelper.m_serverListUIController = serverListUIController;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601FC99 RID: 130201 RVA: 0x00A7A8CC File Offset: 0x00A78ACC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_createCharaterUIController(IntPtr l)
	{
		int result;
		try
		{
			LoginUITask loginUITask = (LoginUITask)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, loginUITask.m_luaExportHelper.m_createCharaterUIController);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601FC9A RID: 130202 RVA: 0x00A7A924 File Offset: 0x00A78B24
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_createCharaterUIController(IntPtr l)
	{
		int result;
		try
		{
			LoginUITask loginUITask = (LoginUITask)LuaObject.checkSelf(l);
			CreateCharacterUIController createCharaterUIController;
			LuaObject.checkType<CreateCharacterUIController>(l, 2, out createCharaterUIController);
			loginUITask.m_luaExportHelper.m_createCharaterUIController = createCharaterUIController;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601FC9B RID: 130203 RVA: 0x00A7A980 File Offset: 0x00A78B80
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_loginCommonUIController(IntPtr l)
	{
		int result;
		try
		{
			LoginUITask loginUITask = (LoginUITask)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, loginUITask.m_luaExportHelper.m_loginCommonUIController);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601FC9C RID: 130204 RVA: 0x00A7A9D8 File Offset: 0x00A78BD8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_loginCommonUIController(IntPtr l)
	{
		int result;
		try
		{
			LoginUITask loginUITask = (LoginUITask)LuaObject.checkSelf(l);
			LoginCommonUIController loginCommonUIController;
			LuaObject.checkType<LoginCommonUIController>(l, 2, out loginCommonUIController);
			loginUITask.m_luaExportHelper.m_loginCommonUIController = loginCommonUIController;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601FC9D RID: 130205 RVA: 0x00A7AA34 File Offset: 0x00A78C34
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_retryLoginByAuthTokenCount(IntPtr l)
	{
		int result;
		try
		{
			LoginUITask loginUITask = (LoginUITask)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, loginUITask.m_luaExportHelper.m_retryLoginByAuthTokenCount);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601FC9E RID: 130206 RVA: 0x00A7AA8C File Offset: 0x00A78C8C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_retryLoginByAuthTokenCount(IntPtr l)
	{
		int result;
		try
		{
			LoginUITask loginUITask = (LoginUITask)LuaObject.checkSelf(l);
			int retryLoginByAuthTokenCount;
			LuaObject.checkType(l, 2, out retryLoginByAuthTokenCount);
			loginUITask.m_luaExportHelper.m_retryLoginByAuthTokenCount = retryLoginByAuthTokenCount;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601FC9F RID: 130207 RVA: 0x00A7AAE8 File Offset: 0x00A78CE8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_retryLoginBySessionTokenCount(IntPtr l)
	{
		int result;
		try
		{
			LoginUITask loginUITask = (LoginUITask)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, loginUITask.m_luaExportHelper.m_retryLoginBySessionTokenCount);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601FCA0 RID: 130208 RVA: 0x00A7AB40 File Offset: 0x00A78D40
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_retryLoginBySessionTokenCount(IntPtr l)
	{
		int result;
		try
		{
			LoginUITask loginUITask = (LoginUITask)LuaObject.checkSelf(l);
			int retryLoginBySessionTokenCount;
			LuaObject.checkType(l, 2, out retryLoginBySessionTokenCount);
			loginUITask.m_luaExportHelper.m_retryLoginBySessionTokenCount = retryLoginBySessionTokenCount;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601FCA1 RID: 130209 RVA: 0x00A7AB9C File Offset: 0x00A78D9C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_assets(IntPtr l)
	{
		int result;
		try
		{
			LoginUITask loginUITask = (LoginUITask)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, loginUITask.m_luaExportHelper.m_assets);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601FCA2 RID: 130210 RVA: 0x00A7ABF4 File Offset: 0x00A78DF4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_assets(IntPtr l)
	{
		int result;
		try
		{
			LoginUITask loginUITask = (LoginUITask)LuaObject.checkSelf(l);
			List<string> assets;
			LuaObject.checkType<List<string>>(l, 2, out assets);
			loginUITask.m_luaExportHelper.m_assets = assets;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601FCA3 RID: 130211 RVA: 0x00A7AC50 File Offset: 0x00A78E50
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_randomNameHead(IntPtr l)
	{
		int result;
		try
		{
			LoginUITask loginUITask = (LoginUITask)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, loginUITask.m_luaExportHelper.m_randomNameHead);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601FCA4 RID: 130212 RVA: 0x00A7ACA8 File Offset: 0x00A78EA8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_randomNameHead(IntPtr l)
	{
		int result;
		try
		{
			LoginUITask loginUITask = (LoginUITask)LuaObject.checkSelf(l);
			List<string> randomNameHead;
			LuaObject.checkType<List<string>>(l, 2, out randomNameHead);
			loginUITask.m_luaExportHelper.m_randomNameHead = randomNameHead;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601FCA5 RID: 130213 RVA: 0x00A7AD04 File Offset: 0x00A78F04
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_randomNameMiddle(IntPtr l)
	{
		int result;
		try
		{
			LoginUITask loginUITask = (LoginUITask)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, loginUITask.m_luaExportHelper.m_randomNameMiddle);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601FCA6 RID: 130214 RVA: 0x00A7AD5C File Offset: 0x00A78F5C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_randomNameMiddle(IntPtr l)
	{
		int result;
		try
		{
			LoginUITask loginUITask = (LoginUITask)LuaObject.checkSelf(l);
			List<string> randomNameMiddle;
			LuaObject.checkType<List<string>>(l, 2, out randomNameMiddle);
			loginUITask.m_luaExportHelper.m_randomNameMiddle = randomNameMiddle;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601FCA7 RID: 130215 RVA: 0x00A7ADB8 File Offset: 0x00A78FB8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_randomNameTail(IntPtr l)
	{
		int result;
		try
		{
			LoginUITask loginUITask = (LoginUITask)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, loginUITask.m_luaExportHelper.m_randomNameTail);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601FCA8 RID: 130216 RVA: 0x00A7AE10 File Offset: 0x00A79010
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_randomNameTail(IntPtr l)
	{
		int result;
		try
		{
			LoginUITask loginUITask = (LoginUITask)LuaObject.checkSelf(l);
			List<string> randomNameTail;
			LuaObject.checkType<List<string>>(l, 2, out randomNameTail);
			loginUITask.m_luaExportHelper.m_randomNameTail = randomNameTail;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601FCA9 RID: 130217 RVA: 0x00A7AE6C File Offset: 0x00A7906C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_randomNameRandom(IntPtr l)
	{
		int result;
		try
		{
			LoginUITask loginUITask = (LoginUITask)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, loginUITask.m_luaExportHelper.m_randomNameRandom);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601FCAA RID: 130218 RVA: 0x00A7AEC4 File Offset: 0x00A790C4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_randomNameRandom(IntPtr l)
	{
		int result;
		try
		{
			LoginUITask loginUITask = (LoginUITask)LuaObject.checkSelf(l);
			System.Random randomNameRandom;
			LuaObject.checkType<System.Random>(l, 2, out randomNameRandom);
			loginUITask.m_luaExportHelper.m_randomNameRandom = randomNameRandom;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601FCAB RID: 130219 RVA: 0x00A7AF20 File Offset: 0x00A79120
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_configDataLoader(IntPtr l)
	{
		int result;
		try
		{
			LoginUITask loginUITask = (LoginUITask)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, loginUITask.m_luaExportHelper.m_configDataLoader);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601FCAC RID: 130220 RVA: 0x00A7AF78 File Offset: 0x00A79178
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_configDataLoader(IntPtr l)
	{
		int result;
		try
		{
			LoginUITask loginUITask = (LoginUITask)LuaObject.checkSelf(l);
			ClientConfigDataLoader configDataLoader;
			LuaObject.checkType<ClientConfigDataLoader>(l, 2, out configDataLoader);
			loginUITask.m_luaExportHelper.m_configDataLoader = configDataLoader;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601FCAD RID: 130221 RVA: 0x00A7AFD4 File Offset: 0x00A791D4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_s_isGlobalInitialized(IntPtr l)
	{
		int result;
		try
		{
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, LoginUITask.LuaExportHelper.s_isGlobalInitialized);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601FCAE RID: 130222 RVA: 0x00A7B01C File Offset: 0x00A7921C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_s_isGlobalInitialized(IntPtr l)
	{
		int result;
		try
		{
			bool s_isGlobalInitialized;
			LuaObject.checkType(l, 2, out s_isGlobalInitialized);
			LoginUITask.LuaExportHelper.s_isGlobalInitialized = s_isGlobalInitialized;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601FCAF RID: 130223 RVA: 0x00A7B068 File Offset: 0x00A79268
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_s_localConfigPath(IntPtr l)
	{
		int result;
		try
		{
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, LoginUITask.LuaExportHelper.s_localConfigPath);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601FCB0 RID: 130224 RVA: 0x00A7B0B0 File Offset: 0x00A792B0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_s_localConfigPath(IntPtr l)
	{
		int result;
		try
		{
			string s_localConfigPath;
			LuaObject.checkType(l, 2, out s_localConfigPath);
			LoginUITask.LuaExportHelper.s_localConfigPath = s_localConfigPath;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601FCB1 RID: 130225 RVA: 0x00A7B0FC File Offset: 0x00A792FC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_loadConfigFailedMessage(IntPtr l)
	{
		int result;
		try
		{
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, LoginUITask.LuaExportHelper.m_loadConfigFailedMessage);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601FCB2 RID: 130226 RVA: 0x00A7B144 File Offset: 0x00A79344
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_loadConfigFailedMessage(IntPtr l)
	{
		int result;
		try
		{
			string loadConfigFailedMessage;
			LuaObject.checkType(l, 2, out loadConfigFailedMessage);
			LoginUITask.LuaExportHelper.m_loadConfigFailedMessage = loadConfigFailedMessage;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601FCB3 RID: 130227 RVA: 0x00A7B190 File Offset: 0x00A79390
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_curLoadingLayers(IntPtr l)
	{
		int result;
		try
		{
			LoginUITask loginUITask = (LoginUITask)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, loginUITask.m_luaExportHelper.m_curLoadingLayers);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601FCB4 RID: 130228 RVA: 0x00A7B1E8 File Offset: 0x00A793E8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_curLoadingLayers(IntPtr l)
	{
		int result;
		try
		{
			LoginUITask loginUITask = (LoginUITask)LuaObject.checkSelf(l);
			List<UITaskBase.LayerDesc> curLoadingLayers;
			LuaObject.checkType<List<UITaskBase.LayerDesc>>(l, 2, out curLoadingLayers);
			loginUITask.m_luaExportHelper.m_curLoadingLayers = curLoadingLayers;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601FCB5 RID: 130229 RVA: 0x00A7B244 File Offset: 0x00A79444
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_serverListText(IntPtr l)
	{
		int result;
		try
		{
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, LoginUITask.LuaExportHelper.m_serverListText);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601FCB6 RID: 130230 RVA: 0x00A7B28C File Offset: 0x00A7948C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_serverListText(IntPtr l)
	{
		int result;
		try
		{
			string serverListText;
			LuaObject.checkType(l, 2, out serverListText);
			LoginUITask.LuaExportHelper.m_serverListText = serverListText;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601FCB7 RID: 130231 RVA: 0x00A7B2D8 File Offset: 0x00A794D8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_serverlist(IntPtr l)
	{
		int result;
		try
		{
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, LoginUITask.LuaExportHelper.m_serverlist);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601FCB8 RID: 130232 RVA: 0x00A7B320 File Offset: 0x00A79520
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_serverlist(IntPtr l)
	{
		int result;
		try
		{
			List<LoginUITask.ServerInfo> serverlist;
			LuaObject.checkType<List<LoginUITask.ServerInfo>>(l, 2, out serverlist);
			LoginUITask.LuaExportHelper.m_serverlist = serverlist;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601FCB9 RID: 130233 RVA: 0x00A7B36C File Offset: 0x00A7956C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_isRecentLoginServerIDInServerlist(IntPtr l)
	{
		int result;
		try
		{
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, LoginUITask.LuaExportHelper.m_isRecentLoginServerIDInServerlist);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601FCBA RID: 130234 RVA: 0x00A7B3B4 File Offset: 0x00A795B4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_isRecentLoginServerIDInServerlist(IntPtr l)
	{
		int result;
		try
		{
			bool isRecentLoginServerIDInServerlist;
			LuaObject.checkType(l, 2, out isRecentLoginServerIDInServerlist);
			LoginUITask.LuaExportHelper.m_isRecentLoginServerIDInServerlist = isRecentLoginServerIDInServerlist;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601FCBB RID: 130235 RVA: 0x00A7B400 File Offset: 0x00A79600
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_curSelectServerID(IntPtr l)
	{
		int result;
		try
		{
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, LoginUITask.LuaExportHelper.m_curSelectServerID);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601FCBC RID: 130236 RVA: 0x00A7B448 File Offset: 0x00A79648
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_curSelectServerID(IntPtr l)
	{
		int result;
		try
		{
			int curSelectServerID;
			LuaObject.checkType(l, 2, out curSelectServerID);
			LoginUITask.LuaExportHelper.m_curSelectServerID = curSelectServerID;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601FCBD RID: 130237 RVA: 0x00A7B494 File Offset: 0x00A79694
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_recommendServerIndex(IntPtr l)
	{
		int result;
		try
		{
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, LoginUITask.LuaExportHelper.m_recommendServerIndex);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601FCBE RID: 130238 RVA: 0x00A7B4DC File Offset: 0x00A796DC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_recommendServerIndex(IntPtr l)
	{
		int result;
		try
		{
			int recommendServerIndex;
			LuaObject.checkType(l, 2, out recommendServerIndex);
			LoginUITask.LuaExportHelper.m_recommendServerIndex = recommendServerIndex;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601FCBF RID: 130239 RVA: 0x00A7B528 File Offset: 0x00A79728
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_totalRecommandWeight(IntPtr l)
	{
		int result;
		try
		{
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, LoginUITask.LuaExportHelper.m_totalRecommandWeight);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601FCC0 RID: 130240 RVA: 0x00A7B570 File Offset: 0x00A79770
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_totalRecommandWeight(IntPtr l)
	{
		int result;
		try
		{
			float totalRecommandWeight;
			LuaObject.checkType(l, 2, out totalRecommandWeight);
			LoginUITask.LuaExportHelper.m_totalRecommandWeight = totalRecommandWeight;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601FCC1 RID: 130241 RVA: 0x00A7B5BC File Offset: 0x00A797BC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_exsitCharsInfo(IntPtr l)
	{
		int result;
		try
		{
			LoginUITask loginUITask = (LoginUITask)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, loginUITask.m_luaExportHelper.m_exsitCharsInfo);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601FCC2 RID: 130242 RVA: 0x00A7B614 File Offset: 0x00A79814
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_exsitCharsInfo(IntPtr l)
	{
		int result;
		try
		{
			LoginUITask loginUITask = (LoginUITask)LuaObject.checkSelf(l);
			List<LoginUITask.ExistCharInfo> exsitCharsInfo;
			LuaObject.checkType<List<LoginUITask.ExistCharInfo>>(l, 2, out exsitCharsInfo);
			loginUITask.m_luaExportHelper.m_exsitCharsInfo = exsitCharsInfo;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601FCC3 RID: 130243 RVA: 0x00A7B670 File Offset: 0x00A79870
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_isOpeningUI(IntPtr l)
	{
		int result;
		try
		{
			LoginUITask loginUITask = (LoginUITask)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, loginUITask.m_luaExportHelper.m_isOpeningUI);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601FCC4 RID: 130244 RVA: 0x00A7B6C8 File Offset: 0x00A798C8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_isOpeningUI(IntPtr l)
	{
		int result;
		try
		{
			LoginUITask loginUITask = (LoginUITask)LuaObject.checkSelf(l);
			bool isOpeningUI;
			LuaObject.checkType(l, 2, out isOpeningUI);
			loginUITask.m_luaExportHelper.m_isOpeningUI = isOpeningUI;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601FCC5 RID: 130245 RVA: 0x00A7B724 File Offset: 0x00A79924
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_curLoginAgnetUrl(IntPtr l)
	{
		int result;
		try
		{
			LoginUITask loginUITask = (LoginUITask)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, loginUITask.m_luaExportHelper.m_curLoginAgnetUrl);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601FCC6 RID: 130246 RVA: 0x00A7B77C File Offset: 0x00A7997C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_curLoginAgnetUrl(IntPtr l)
	{
		int result;
		try
		{
			LoginUITask loginUITask = (LoginUITask)LuaObject.checkSelf(l);
			string curLoginAgnetUrl;
			LuaObject.checkType(l, 2, out curLoginAgnetUrl);
			loginUITask.m_luaExportHelper.m_curLoginAgnetUrl = curLoginAgnetUrl;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601FCC7 RID: 130247 RVA: 0x00A7B7D8 File Offset: 0x00A799D8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_CustomParams(IntPtr l)
	{
		int result;
		try
		{
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, "menghuanmonizhan");
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601FCC8 RID: 130248 RVA: 0x00A7B820 File Offset: 0x00A79A20
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_messageDuration(IntPtr l)
	{
		int result;
		try
		{
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, 3);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601FCC9 RID: 130249 RVA: 0x00A7B864 File Offset: 0x00A79A64
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_ignoreNetworkErrorOnce(IntPtr l)
	{
		int result;
		try
		{
			LoginUITask loginUITask = (LoginUITask)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, loginUITask.m_luaExportHelper.m_ignoreNetworkErrorOnce);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601FCCA RID: 130250 RVA: 0x00A7B8BC File Offset: 0x00A79ABC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_ignoreNetworkErrorOnce(IntPtr l)
	{
		int result;
		try
		{
			LoginUITask loginUITask = (LoginUITask)LuaObject.checkSelf(l);
			bool ignoreNetworkErrorOnce;
			LuaObject.checkType(l, 2, out ignoreNetworkErrorOnce);
			loginUITask.m_luaExportHelper.m_ignoreNetworkErrorOnce = ignoreNetworkErrorOnce;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601FCCB RID: 130251 RVA: 0x00A7B918 File Offset: 0x00A79B18
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_gmUserIDs(IntPtr l)
	{
		int result;
		try
		{
			LoginUITask loginUITask = (LoginUITask)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, loginUITask.m_luaExportHelper.m_gmUserIDs);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601FCCC RID: 130252 RVA: 0x00A7B970 File Offset: 0x00A79B70
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_gmUserIDs(IntPtr l)
	{
		int result;
		try
		{
			LoginUITask loginUITask = (LoginUITask)LuaObject.checkSelf(l);
			Dictionary<string, HashSet<string>> gmUserIDs;
			LuaObject.checkType<Dictionary<string, HashSet<string>>>(l, 2, out gmUserIDs);
			loginUITask.m_luaExportHelper.m_gmUserIDs = gmUserIDs;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601FCCD RID: 130253 RVA: 0x00A7B9CC File Offset: 0x00A79BCC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_isGMUser(IntPtr l)
	{
		int result;
		try
		{
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, LoginUITask.LuaExportHelper.m_isGMUser);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601FCCE RID: 130254 RVA: 0x00A7BA14 File Offset: 0x00A79C14
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_isGMUser(IntPtr l)
	{
		int result;
		try
		{
			bool isGMUser;
			LuaObject.checkType(l, 2, out isGMUser);
			LoginUITask.LuaExportHelper.m_isGMUser = isGMUser;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601FCCF RID: 130255 RVA: 0x00A7BA60 File Offset: 0x00A79C60
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_isGettingSDKPlatformUserID(IntPtr l)
	{
		int result;
		try
		{
			LoginUITask loginUITask = (LoginUITask)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, loginUITask.m_luaExportHelper.m_isGettingSDKPlatformUserID);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601FCD0 RID: 130256 RVA: 0x00A7BAB8 File Offset: 0x00A79CB8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_isGettingSDKPlatformUserID(IntPtr l)
	{
		int result;
		try
		{
			LoginUITask loginUITask = (LoginUITask)LuaObject.checkSelf(l);
			bool isGettingSDKPlatformUserID;
			LuaObject.checkType(l, 2, out isGettingSDKPlatformUserID);
			loginUITask.m_luaExportHelper.m_isGettingSDKPlatformUserID = isGettingSDKPlatformUserID;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601FCD1 RID: 130257 RVA: 0x00A7BB14 File Offset: 0x00A79D14
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_pdsdkLoginReturnData(IntPtr l)
	{
		int result;
		try
		{
			LoginUITask loginUITask = (LoginUITask)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, loginUITask.m_luaExportHelper.m_pdsdkLoginReturnData);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601FCD2 RID: 130258 RVA: 0x00A7BB6C File Offset: 0x00A79D6C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_pdsdkLoginReturnData(IntPtr l)
	{
		int result;
		try
		{
			LoginUITask loginUITask = (LoginUITask)LuaObject.checkSelf(l);
			string pdsdkLoginReturnData;
			LuaObject.checkType(l, 2, out pdsdkLoginReturnData);
			loginUITask.m_luaExportHelper.m_pdsdkLoginReturnData = pdsdkLoginReturnData;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601FCD3 RID: 130259 RVA: 0x00A7BBC8 File Offset: 0x00A79DC8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_pdsdkLoginReturnOpcode(IntPtr l)
	{
		int result;
		try
		{
			LoginUITask loginUITask = (LoginUITask)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, loginUITask.m_luaExportHelper.m_pdsdkLoginReturnOpcode);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601FCD4 RID: 130260 RVA: 0x00A7BC20 File Offset: 0x00A79E20
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_pdsdkLoginReturnOpcode(IntPtr l)
	{
		int result;
		try
		{
			LoginUITask loginUITask = (LoginUITask)LuaObject.checkSelf(l);
			string pdsdkLoginReturnOpcode;
			LuaObject.checkType(l, 2, out pdsdkLoginReturnOpcode);
			loginUITask.m_luaExportHelper.m_pdsdkLoginReturnOpcode = pdsdkLoginReturnOpcode;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601FCD5 RID: 130261 RVA: 0x00A7BC7C File Offset: 0x00A79E7C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_pdsdkLoginReturnChannelID(IntPtr l)
	{
		int result;
		try
		{
			LoginUITask loginUITask = (LoginUITask)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, loginUITask.m_luaExportHelper.m_pdsdkLoginReturnChannelID);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601FCD6 RID: 130262 RVA: 0x00A7BCD4 File Offset: 0x00A79ED4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_pdsdkLoginReturnChannelID(IntPtr l)
	{
		int result;
		try
		{
			LoginUITask loginUITask = (LoginUITask)LuaObject.checkSelf(l);
			string pdsdkLoginReturnChannelID;
			LuaObject.checkType(l, 2, out pdsdkLoginReturnChannelID);
			loginUITask.m_luaExportHelper.m_pdsdkLoginReturnChannelID = pdsdkLoginReturnChannelID;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601FCD7 RID: 130263 RVA: 0x00A7BD30 File Offset: 0x00A79F30
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_pdsdkLoginReturnCustomParams(IntPtr l)
	{
		int result;
		try
		{
			LoginUITask loginUITask = (LoginUITask)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, loginUITask.m_luaExportHelper.m_pdsdkLoginReturnCustomParams);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601FCD8 RID: 130264 RVA: 0x00A7BD88 File Offset: 0x00A79F88
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_pdsdkLoginReturnCustomParams(IntPtr l)
	{
		int result;
		try
		{
			LoginUITask loginUITask = (LoginUITask)LuaObject.checkSelf(l);
			string pdsdkLoginReturnCustomParams;
			LuaObject.checkType(l, 2, out pdsdkLoginReturnCustomParams);
			loginUITask.m_luaExportHelper.m_pdsdkLoginReturnCustomParams = pdsdkLoginReturnCustomParams;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601FCD9 RID: 130265 RVA: 0x00A7BDE4 File Offset: 0x00A79FE4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_isAutoRelogin(IntPtr l)
	{
		int result;
		try
		{
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, LoginUITask.LuaExportHelper.m_isAutoRelogin);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601FCDA RID: 130266 RVA: 0x00A7BE2C File Offset: 0x00A7A02C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_isAutoRelogin(IntPtr l)
	{
		int result;
		try
		{
			bool isAutoRelogin;
			LuaObject.checkType(l, 2, out isAutoRelogin);
			LoginUITask.LuaExportHelper.m_isAutoRelogin = isAutoRelogin;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601FCDB RID: 130267 RVA: 0x00A7BE78 File Offset: 0x00A7A078
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_isReturnToLoginAndSwitchUser(IntPtr l)
	{
		int result;
		try
		{
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, LoginUITask.LuaExportHelper.m_isReturnToLoginAndSwitchUser);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601FCDC RID: 130268 RVA: 0x00A7BEC0 File Offset: 0x00A7A0C0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_isReturnToLoginAndSwitchUser(IntPtr l)
	{
		int result;
		try
		{
			bool isReturnToLoginAndSwitchUser;
			LuaObject.checkType(l, 2, out isReturnToLoginAndSwitchUser);
			LoginUITask.LuaExportHelper.m_isReturnToLoginAndSwitchUser = isReturnToLoginAndSwitchUser;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601FCDD RID: 130269 RVA: 0x00A7BF0C File Offset: 0x00A7A10C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_isReturnToLoginAndOnLoginSuccess(IntPtr l)
	{
		int result;
		try
		{
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, LoginUITask.LuaExportHelper.m_isReturnToLoginAndOnLoginSuccess);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601FCDE RID: 130270 RVA: 0x00A7BF54 File Offset: 0x00A7A154
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_isReturnToLoginAndOnLoginSuccess(IntPtr l)
	{
		int result;
		try
		{
			bool isReturnToLoginAndOnLoginSuccess;
			LuaObject.checkType(l, 2, out isReturnToLoginAndOnLoginSuccess);
			LoginUITask.LuaExportHelper.m_isReturnToLoginAndOnLoginSuccess = isReturnToLoginAndOnLoginSuccess;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601FCDF RID: 130271 RVA: 0x00A7BFA0 File Offset: 0x00A7A1A0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_onSwitchUserSuccessMsg(IntPtr l)
	{
		int result;
		try
		{
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, LoginUITask.LuaExportHelper.m_onSwitchUserSuccessMsg);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601FCE0 RID: 130272 RVA: 0x00A7BFEC File Offset: 0x00A7A1EC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_onSwitchUserSuccessMsg(IntPtr l)
	{
		int result;
		try
		{
			LoginSuccessMsg onSwitchUserSuccessMsg;
			LuaObject.checkValueType<LoginSuccessMsg>(l, 2, out onSwitchUserSuccessMsg);
			LoginUITask.LuaExportHelper.m_onSwitchUserSuccessMsg = onSwitchUserSuccessMsg;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601FCE1 RID: 130273 RVA: 0x00A7C038 File Offset: 0x00A7A238
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_isNewRole(IntPtr l)
	{
		int result;
		try
		{
			LoginUITask loginUITask = (LoginUITask)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, loginUITask.m_luaExportHelper.m_isNewRole);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601FCE2 RID: 130274 RVA: 0x00A7C090 File Offset: 0x00A7A290
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_isNewRole(IntPtr l)
	{
		int result;
		try
		{
			LoginUITask loginUITask = (LoginUITask)LuaObject.checkSelf(l);
			bool isNewRole;
			LuaObject.checkType(l, 2, out isNewRole);
			loginUITask.m_luaExportHelper.m_isNewRole = isNewRole;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601FCE3 RID: 130275 RVA: 0x00A7C0EC File Offset: 0x00A7A2EC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_downloadServerListCoroutine(IntPtr l)
	{
		int result;
		try
		{
			LoginUITask loginUITask = (LoginUITask)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, loginUITask.m_luaExportHelper.m_downloadServerListCoroutine);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601FCE4 RID: 130276 RVA: 0x00A7C144 File Offset: 0x00A7A344
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_downloadServerListCoroutine(IntPtr l)
	{
		int result;
		try
		{
			LoginUITask loginUITask = (LoginUITask)LuaObject.checkSelf(l);
			Coroutine downloadServerListCoroutine;
			LuaObject.checkType<Coroutine>(l, 2, out downloadServerListCoroutine);
			loginUITask.m_luaExportHelper.m_downloadServerListCoroutine = downloadServerListCoroutine;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601FCE5 RID: 130277 RVA: 0x00A7C1A0 File Offset: 0x00A7A3A0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_isClearSessionFailed(IntPtr l)
	{
		int result;
		try
		{
			LoginUITask loginUITask = (LoginUITask)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, loginUITask.m_luaExportHelper.m_isClearSessionFailed);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601FCE6 RID: 130278 RVA: 0x00A7C1F8 File Offset: 0x00A7A3F8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_isClearSessionFailed(IntPtr l)
	{
		int result;
		try
		{
			LoginUITask loginUITask = (LoginUITask)LuaObject.checkSelf(l);
			bool isClearSessionFailed;
			LuaObject.checkType(l, 2, out isClearSessionFailed);
			loginUITask.m_luaExportHelper.m_isClearSessionFailed = isClearSessionFailed;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601FCE7 RID: 130279 RVA: 0x00A7C254 File Offset: 0x00A7A454
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_ServerList(IntPtr l)
	{
		int result;
		try
		{
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, LoginUITask.ServerList);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601FCE8 RID: 130280 RVA: 0x00A7C29C File Offset: 0x00A7A49C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_ShouldUsePDSDK(IntPtr l)
	{
		int result;
		try
		{
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, LoginUITask.LuaExportHelper.ShouldUsePDSDK);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601FCE9 RID: 130281 RVA: 0x00A7C2E4 File Offset: 0x00A7A4E4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_RecommendServerIndex(IntPtr l)
	{
		int result;
		try
		{
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, LoginUITask.RecommendServerIndex);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601FCEA RID: 130282 RVA: 0x00A7C32C File Offset: 0x00A7A52C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_IsGMUser(IntPtr l)
	{
		int result;
		try
		{
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, LoginUITask.IsGMUser);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601FCEB RID: 130283 RVA: 0x00A7C374 File Offset: 0x00A7A574
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_PDSDKStartGameJsonString(IntPtr l)
	{
		int result;
		try
		{
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, LoginUITask.PDSDKStartGameJsonString);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601FCEC RID: 130284 RVA: 0x00A7C3BC File Offset: 0x00A7A5BC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_PDSDKGameRoleJsonString(IntPtr l)
	{
		int result;
		try
		{
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, LoginUITask.PDSDKGameRoleJsonString);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601FCED RID: 130285 RVA: 0x00A7C404 File Offset: 0x00A7A604
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_SessionTokenCacheFileName(IntPtr l)
	{
		int result;
		try
		{
			LoginUITask loginUITask = (LoginUITask)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, loginUITask.m_luaExportHelper.SessionTokenCacheFileName);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601FCEE RID: 130286 RVA: 0x00A7C45C File Offset: 0x00A7A65C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_SessionAccountInfo(IntPtr l)
	{
		int result;
		try
		{
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, LoginUITask.SessionAccountInfo);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601FCEF RID: 130287 RVA: 0x00A7C4A4 File Offset: 0x00A7A6A4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_FindAInstance(IntPtr l)
	{
		int result;
		try
		{
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, LoginUITask.FindAInstance);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601FCF0 RID: 130288 RVA: 0x00A7C4EC File Offset: 0x00A7A6EC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_LayerDescArray(IntPtr l)
	{
		int result;
		try
		{
			LoginUITask loginUITask = (LoginUITask)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, loginUITask.m_luaExportHelper.LayerDescArray);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601FCF1 RID: 130289 RVA: 0x00A7C544 File Offset: 0x00A7A744
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_UICtrlDescArray(IntPtr l)
	{
		int result;
		try
		{
			LoginUITask loginUITask = (LoginUITask)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, loginUITask.m_luaExportHelper.UICtrlDescArray);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601FCF2 RID: 130290 RVA: 0x00A7C59C File Offset: 0x00A7A79C
	[Preserve]
	public static void reg(IntPtr l)
	{
		LuaObject.getTypeTable(l, "BlackJack.ProjectL.UI.LoginUITask");
		if (Lua_BlackJack_ProjectL_UI_LoginUITask.<>f__mg$cache0 == null)
		{
			Lua_BlackJack_ProjectL_UI_LoginUITask.<>f__mg$cache0 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_LoginUITask.ShowDialogBox);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_LoginUITask.<>f__mg$cache0);
		if (Lua_BlackJack_ProjectL_UI_LoginUITask.<>f__mg$cache1 == null)
		{
			Lua_BlackJack_ProjectL_UI_LoginUITask.<>f__mg$cache1 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_LoginUITask.UpdateLoginPCClientButton);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_LoginUITask.<>f__mg$cache1);
		if (Lua_BlackJack_ProjectL_UI_LoginUITask.<>f__mg$cache2 == null)
		{
			Lua_BlackJack_ProjectL_UI_LoginUITask.<>f__mg$cache2 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_LoginUITask.UpdateGMUserFlag);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_LoginUITask.<>f__mg$cache2);
		if (Lua_BlackJack_ProjectL_UI_LoginUITask.<>f__mg$cache3 == null)
		{
			Lua_BlackJack_ProjectL_UI_LoginUITask.<>f__mg$cache3 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_LoginUITask.GetSDKPlatformUserID);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_LoginUITask.<>f__mg$cache3);
		if (Lua_BlackJack_ProjectL_UI_LoginUITask.<>f__mg$cache4 == null)
		{
			Lua_BlackJack_ProjectL_UI_LoginUITask.<>f__mg$cache4 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_LoginUITask.ShowWaitingNet);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_LoginUITask.<>f__mg$cache4);
		if (Lua_BlackJack_ProjectL_UI_LoginUITask.<>f__mg$cache5 == null)
		{
			Lua_BlackJack_ProjectL_UI_LoginUITask.<>f__mg$cache5 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_LoginUITask.ShowMessage);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_LoginUITask.<>f__mg$cache5);
		if (Lua_BlackJack_ProjectL_UI_LoginUITask.<>f__mg$cache6 == null)
		{
			Lua_BlackJack_ProjectL_UI_LoginUITask.<>f__mg$cache6 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_LoginUITask.SaveSessionTokenCache);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_LoginUITask.<>f__mg$cache6);
		if (Lua_BlackJack_ProjectL_UI_LoginUITask.<>f__mg$cache7 == null)
		{
			Lua_BlackJack_ProjectL_UI_LoginUITask.<>f__mg$cache7 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_LoginUITask.GetSessionTokenCache);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_LoginUITask.<>f__mg$cache7);
		if (Lua_BlackJack_ProjectL_UI_LoginUITask.<>f__mg$cache8 == null)
		{
			Lua_BlackJack_ProjectL_UI_LoginUITask.<>f__mg$cache8 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_LoginUITask.ClearSessionTokenCache);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_LoginUITask.<>f__mg$cache8);
		if (Lua_BlackJack_ProjectL_UI_LoginUITask.<>f__mg$cache9 == null)
		{
			Lua_BlackJack_ProjectL_UI_LoginUITask.<>f__mg$cache9 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_LoginUITask.PDSDK_OnQRLoginSuccess);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_LoginUITask.<>f__mg$cache9);
		if (Lua_BlackJack_ProjectL_UI_LoginUITask.<>f__mg$cacheA == null)
		{
			Lua_BlackJack_ProjectL_UI_LoginUITask.<>f__mg$cacheA = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_LoginUITask.PDSDK_OnQRLoginFailed);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_LoginUITask.<>f__mg$cacheA);
		if (Lua_BlackJack_ProjectL_UI_LoginUITask.<>f__mg$cacheB == null)
		{
			Lua_BlackJack_ProjectL_UI_LoginUITask.<>f__mg$cacheB = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_LoginUITask.PDSDK_OnQRLoginCancel);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_LoginUITask.<>f__mg$cacheB);
		if (Lua_BlackJack_ProjectL_UI_LoginUITask.<>f__mg$cacheC == null)
		{
			Lua_BlackJack_ProjectL_UI_LoginUITask.<>f__mg$cacheC = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_LoginUITask.PDSK_OnLoginFailed);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_LoginUITask.<>f__mg$cacheC);
		if (Lua_BlackJack_ProjectL_UI_LoginUITask.<>f__mg$cacheD == null)
		{
			Lua_BlackJack_ProjectL_UI_LoginUITask.<>f__mg$cacheD = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_LoginUITask.PDSDK_OnLoginSuccess);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_LoginUITask.<>f__mg$cacheD);
		if (Lua_BlackJack_ProjectL_UI_LoginUITask.<>f__mg$cacheE == null)
		{
			Lua_BlackJack_ProjectL_UI_LoginUITask.<>f__mg$cacheE = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_LoginUITask.Relogin_s);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_LoginUITask.<>f__mg$cacheE);
		if (Lua_BlackJack_ProjectL_UI_LoginUITask.<>f__mg$cacheF == null)
		{
			Lua_BlackJack_ProjectL_UI_LoginUITask.<>f__mg$cacheF = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_LoginUITask.ReturnToLoginAndSwitchUser_s);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_LoginUITask.<>f__mg$cacheF);
		if (Lua_BlackJack_ProjectL_UI_LoginUITask.<>f__mg$cache10 == null)
		{
			Lua_BlackJack_ProjectL_UI_LoginUITask.<>f__mg$cache10 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_LoginUITask.GetServerInfoByBornChannelID_s);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_LoginUITask.<>f__mg$cache10);
		if (Lua_BlackJack_ProjectL_UI_LoginUITask.<>f__mg$cache11 == null)
		{
			Lua_BlackJack_ProjectL_UI_LoginUITask.<>f__mg$cache11 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_LoginUITask.SetLocalPushNotifications_s);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_LoginUITask.<>f__mg$cache11);
		if (Lua_BlackJack_ProjectL_UI_LoginUITask.<>f__mg$cache12 == null)
		{
			Lua_BlackJack_ProjectL_UI_LoginUITask.<>f__mg$cache12 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_LoginUITask.DeleteExpiredLogFiles_s);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_LoginUITask.<>f__mg$cache12);
		if (Lua_BlackJack_ProjectL_UI_LoginUITask.<>f__mg$cache13 == null)
		{
			Lua_BlackJack_ProjectL_UI_LoginUITask.<>f__mg$cache13 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_LoginUITask.CheckClientVersion_s);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_LoginUITask.<>f__mg$cache13);
		if (Lua_BlackJack_ProjectL_UI_LoginUITask.<>f__mg$cache14 == null)
		{
			Lua_BlackJack_ProjectL_UI_LoginUITask.<>f__mg$cache14 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_LoginUITask.GetCurrentSelectServerInfo_s);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_LoginUITask.<>f__mg$cache14);
		if (Lua_BlackJack_ProjectL_UI_LoginUITask.<>f__mg$cache15 == null)
		{
			Lua_BlackJack_ProjectL_UI_LoginUITask.<>f__mg$cache15 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_LoginUITask.PDSDK_OnLogoutSuccess_s);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_LoginUITask.<>f__mg$cache15);
		if (Lua_BlackJack_ProjectL_UI_LoginUITask.<>f__mg$cache16 == null)
		{
			Lua_BlackJack_ProjectL_UI_LoginUITask.<>f__mg$cache16 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_LoginUITask.PDSDK_OnSwitchUserSuccess_s);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_LoginUITask.<>f__mg$cache16);
		if (Lua_BlackJack_ProjectL_UI_LoginUITask.<>f__mg$cache17 == null)
		{
			Lua_BlackJack_ProjectL_UI_LoginUITask.<>f__mg$cache17 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_LoginUITask.CheckServerMaitainState_s);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_LoginUITask.<>f__mg$cache17);
		if (Lua_BlackJack_ProjectL_UI_LoginUITask.<>f__mg$cache18 == null)
		{
			Lua_BlackJack_ProjectL_UI_LoginUITask.<>f__mg$cache18 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_LoginUITask.IsNeedLoadDynamicRes);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_LoginUITask.<>f__mg$cache18);
		if (Lua_BlackJack_ProjectL_UI_LoginUITask.<>f__mg$cache19 == null)
		{
			Lua_BlackJack_ProjectL_UI_LoginUITask.<>f__mg$cache19 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_LoginUITask.CollectAllDynamicResForLoad);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_LoginUITask.<>f__mg$cache19);
		if (Lua_BlackJack_ProjectL_UI_LoginUITask.<>f__mg$cache1A == null)
		{
			Lua_BlackJack_ProjectL_UI_LoginUITask.<>f__mg$cache1A = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_LoginUITask.PostOnLoadAllResCompleted);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_LoginUITask.<>f__mg$cache1A);
		if (Lua_BlackJack_ProjectL_UI_LoginUITask.<>f__mg$cache1B == null)
		{
			Lua_BlackJack_ProjectL_UI_LoginUITask.<>f__mg$cache1B = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_LoginUITask.InitLayerStateOnLoadAllResCompleted);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_LoginUITask.<>f__mg$cache1B);
		if (Lua_BlackJack_ProjectL_UI_LoginUITask.<>f__mg$cache1C == null)
		{
			Lua_BlackJack_ProjectL_UI_LoginUITask.<>f__mg$cache1C = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_LoginUITask.InitAllUIControllers);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_LoginUITask.<>f__mg$cache1C);
		if (Lua_BlackJack_ProjectL_UI_LoginUITask.<>f__mg$cache1D == null)
		{
			Lua_BlackJack_ProjectL_UI_LoginUITask.<>f__mg$cache1D = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_LoginUITask.StartCoroutineKeepUpdatingServerList);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_LoginUITask.<>f__mg$cache1D);
		if (Lua_BlackJack_ProjectL_UI_LoginUITask.<>f__mg$cache1E == null)
		{
			Lua_BlackJack_ProjectL_UI_LoginUITask.<>f__mg$cache1E = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_LoginUITask.ClearAllContextAndRes);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_LoginUITask.<>f__mg$cache1E);
		if (Lua_BlackJack_ProjectL_UI_LoginUITask.<>f__mg$cache1F == null)
		{
			Lua_BlackJack_ProjectL_UI_LoginUITask.<>f__mg$cache1F = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_LoginUITask.ServerListUIController_OnServerListClosed);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_LoginUITask.<>f__mg$cache1F);
		if (Lua_BlackJack_ProjectL_UI_LoginUITask.<>f__mg$cache20 == null)
		{
			Lua_BlackJack_ProjectL_UI_LoginUITask.<>f__mg$cache20 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_LoginUITask.OnStart);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_LoginUITask.<>f__mg$cache20);
		if (Lua_BlackJack_ProjectL_UI_LoginUITask.<>f__mg$cache21 == null)
		{
			Lua_BlackJack_ProjectL_UI_LoginUITask.<>f__mg$cache21 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_LoginUITask.OnStop);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_LoginUITask.<>f__mg$cache21);
		if (Lua_BlackJack_ProjectL_UI_LoginUITask.<>f__mg$cache22 == null)
		{
			Lua_BlackJack_ProjectL_UI_LoginUITask.<>f__mg$cache22 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_LoginUITask.OnResume);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_LoginUITask.<>f__mg$cache22);
		if (Lua_BlackJack_ProjectL_UI_LoginUITask.<>f__mg$cache23 == null)
		{
			Lua_BlackJack_ProjectL_UI_LoginUITask.<>f__mg$cache23 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_LoginUITask.OnTick);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_LoginUITask.<>f__mg$cache23);
		if (Lua_BlackJack_ProjectL_UI_LoginUITask.<>f__mg$cache24 == null)
		{
			Lua_BlackJack_ProjectL_UI_LoginUITask.<>f__mg$cache24 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_LoginUITask.UpdateView);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_LoginUITask.<>f__mg$cache24);
		if (Lua_BlackJack_ProjectL_UI_LoginUITask.<>f__mg$cache25 == null)
		{
			Lua_BlackJack_ProjectL_UI_LoginUITask.<>f__mg$cache25 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_LoginUITask.PostUpdateView);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_LoginUITask.<>f__mg$cache25);
		if (Lua_BlackJack_ProjectL_UI_LoginUITask.<>f__mg$cache26 == null)
		{
			Lua_BlackJack_ProjectL_UI_LoginUITask.<>f__mg$cache26 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_LoginUITask.StopEntryUITask);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_LoginUITask.<>f__mg$cache26);
		if (Lua_BlackJack_ProjectL_UI_LoginUITask.<>f__mg$cache27 == null)
		{
			Lua_BlackJack_ProjectL_UI_LoginUITask.<>f__mg$cache27 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_LoginUITask.DownloadServerListFile);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_LoginUITask.<>f__mg$cache27);
		if (Lua_BlackJack_ProjectL_UI_LoginUITask.<>f__mg$cache28 == null)
		{
			Lua_BlackJack_ProjectL_UI_LoginUITask.<>f__mg$cache28 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_LoginUITask.DownloadAnnounceFile);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_LoginUITask.<>f__mg$cache28);
		if (Lua_BlackJack_ProjectL_UI_LoginUITask.<>f__mg$cache29 == null)
		{
			Lua_BlackJack_ProjectL_UI_LoginUITask.<>f__mg$cache29 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_LoginUITask.DownloadGMUserIDs);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_LoginUITask.<>f__mg$cache29);
		if (Lua_BlackJack_ProjectL_UI_LoginUITask.<>f__mg$cache2A == null)
		{
			Lua_BlackJack_ProjectL_UI_LoginUITask.<>f__mg$cache2A = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_LoginUITask.ParseGMUserIDsText);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_LoginUITask.<>f__mg$cache2A);
		if (Lua_BlackJack_ProjectL_UI_LoginUITask.<>f__mg$cache2B == null)
		{
			Lua_BlackJack_ProjectL_UI_LoginUITask.<>f__mg$cache2B = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_LoginUITask.IsSdkIDCanLoginPCClient);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_LoginUITask.<>f__mg$cache2B);
		if (Lua_BlackJack_ProjectL_UI_LoginUITask.<>f__mg$cache2C == null)
		{
			Lua_BlackJack_ProjectL_UI_LoginUITask.<>f__mg$cache2C = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_LoginUITask.UpdateLocalConfigGMUser);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_LoginUITask.<>f__mg$cache2C);
		if (Lua_BlackJack_ProjectL_UI_LoginUITask.<>f__mg$cache2D == null)
		{
			Lua_BlackJack_ProjectL_UI_LoginUITask.<>f__mg$cache2D = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_LoginUITask.ReqExistChars);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_LoginUITask.<>f__mg$cache2D);
		if (Lua_BlackJack_ProjectL_UI_LoginUITask.<>f__mg$cache2E == null)
		{
			Lua_BlackJack_ProjectL_UI_LoginUITask.<>f__mg$cache2E = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_LoginUITask.LaunchEnterGameUIWithGameSettingTokenAndServer);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_LoginUITask.<>f__mg$cache2E);
		if (Lua_BlackJack_ProjectL_UI_LoginUITask.<>f__mg$cache2F == null)
		{
			Lua_BlackJack_ProjectL_UI_LoginUITask.<>f__mg$cache2F = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_LoginUITask.LaunchEnterGameUIWithUIInputAccountAndServer);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_LoginUITask.<>f__mg$cache2F);
		if (Lua_BlackJack_ProjectL_UI_LoginUITask.<>f__mg$cache30 == null)
		{
			Lua_BlackJack_ProjectL_UI_LoginUITask.<>f__mg$cache30 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_LoginUITask.DownloadGameServerLoginAnnouncement);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_LoginUITask.<>f__mg$cache30);
		if (Lua_BlackJack_ProjectL_UI_LoginUITask.<>f__mg$cache31 == null)
		{
			Lua_BlackJack_ProjectL_UI_LoginUITask.<>f__mg$cache31 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_LoginUITask.ShowGameServerLoginAnnouncementUI);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_LoginUITask.<>f__mg$cache31);
		if (Lua_BlackJack_ProjectL_UI_LoginUITask.<>f__mg$cache32 == null)
		{
			Lua_BlackJack_ProjectL_UI_LoginUITask.<>f__mg$cache32 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_LoginUITask.ShowEnterGameUI);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_LoginUITask.<>f__mg$cache32);
		if (Lua_BlackJack_ProjectL_UI_LoginUITask.<>f__mg$cache33 == null)
		{
			Lua_BlackJack_ProjectL_UI_LoginUITask.<>f__mg$cache33 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_LoginUITask.StartLoginAgentLogin);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_LoginUITask.<>f__mg$cache33);
		if (Lua_BlackJack_ProjectL_UI_LoginUITask.<>f__mg$cache34 == null)
		{
			Lua_BlackJack_ProjectL_UI_LoginUITask.<>f__mg$cache34 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_LoginUITask.OnLoginByAuthTokenAck);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_LoginUITask.<>f__mg$cache34);
		if (Lua_BlackJack_ProjectL_UI_LoginUITask.<>f__mg$cache35 == null)
		{
			Lua_BlackJack_ProjectL_UI_LoginUITask.<>f__mg$cache35 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_LoginUITask.DelayEnableInput);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_LoginUITask.<>f__mg$cache35);
		if (Lua_BlackJack_ProjectL_UI_LoginUITask.<>f__mg$cache36 == null)
		{
			Lua_BlackJack_ProjectL_UI_LoginUITask.<>f__mg$cache36 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_LoginUITask.OnLoginBySessionTokenAck);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_LoginUITask.<>f__mg$cache36);
		if (Lua_BlackJack_ProjectL_UI_LoginUITask.<>f__mg$cache37 == null)
		{
			Lua_BlackJack_ProjectL_UI_LoginUITask.<>f__mg$cache37 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_LoginUITask.LoginBySessionTokenAgain);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_LoginUITask.<>f__mg$cache37);
		if (Lua_BlackJack_ProjectL_UI_LoginUITask.<>f__mg$cache38 == null)
		{
			Lua_BlackJack_ProjectL_UI_LoginUITask.<>f__mg$cache38 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_LoginUITask.StartPlayerInfoInitReq);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_LoginUITask.<>f__mg$cache38);
		if (Lua_BlackJack_ProjectL_UI_LoginUITask.<>f__mg$cache39 == null)
		{
			Lua_BlackJack_ProjectL_UI_LoginUITask.<>f__mg$cache39 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_LoginUITask.OnPlayerInfoInitEnd);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_LoginUITask.<>f__mg$cache39);
		if (Lua_BlackJack_ProjectL_UI_LoginUITask.<>f__mg$cache3A == null)
		{
			Lua_BlackJack_ProjectL_UI_LoginUITask.<>f__mg$cache3A = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_LoginUITask.PlayerContext_OnGameServerNetworkError);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_LoginUITask.<>f__mg$cache3A);
		if (Lua_BlackJack_ProjectL_UI_LoginUITask.<>f__mg$cache3B == null)
		{
			Lua_BlackJack_ProjectL_UI_LoginUITask.<>f__mg$cache3B = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_LoginUITask.LauncheMainUI);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_LoginUITask.<>f__mg$cache3B);
		if (Lua_BlackJack_ProjectL_UI_LoginUITask.<>f__mg$cache3C == null)
		{
			Lua_BlackJack_ProjectL_UI_LoginUITask.<>f__mg$cache3C = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_LoginUITask.OnWaitingMsgAckOutTime);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_LoginUITask.<>f__mg$cache3C);
		if (Lua_BlackJack_ProjectL_UI_LoginUITask.<>f__mg$cache3D == null)
		{
			Lua_BlackJack_ProjectL_UI_LoginUITask.<>f__mg$cache3D = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_LoginUITask.OnGameServerConnected);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_LoginUITask.<>f__mg$cache3D);
		if (Lua_BlackJack_ProjectL_UI_LoginUITask.<>f__mg$cache3E == null)
		{
			Lua_BlackJack_ProjectL_UI_LoginUITask.<>f__mg$cache3E = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_LoginUITask.OnGameServerNetworkError);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_LoginUITask.<>f__mg$cache3E);
		if (Lua_BlackJack_ProjectL_UI_LoginUITask.<>f__mg$cache3F == null)
		{
			Lua_BlackJack_ProjectL_UI_LoginUITask.<>f__mg$cache3F = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_LoginUITask.ShowCreateCharacterUI);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_LoginUITask.<>f__mg$cache3F);
		if (Lua_BlackJack_ProjectL_UI_LoginUITask.<>f__mg$cache40 == null)
		{
			Lua_BlackJack_ProjectL_UI_LoginUITask.<>f__mg$cache40 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_LoginUITask.StartCreateCharacterReq);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_LoginUITask.<>f__mg$cache40);
		if (Lua_BlackJack_ProjectL_UI_LoginUITask.<>f__mg$cache41 == null)
		{
			Lua_BlackJack_ProjectL_UI_LoginUITask.<>f__mg$cache41 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_LoginUITask.IsSessionTokenValid);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_LoginUITask.<>f__mg$cache41);
		if (Lua_BlackJack_ProjectL_UI_LoginUITask.<>f__mg$cache42 == null)
		{
			Lua_BlackJack_ProjectL_UI_LoginUITask.<>f__mg$cache42 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_LoginUITask.SaveLoginInfo);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_LoginUITask.<>f__mg$cache42);
		if (Lua_BlackJack_ProjectL_UI_LoginUITask.<>f__mg$cache43 == null)
		{
			Lua_BlackJack_ProjectL_UI_LoginUITask.<>f__mg$cache43 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_LoginUITask.CreateRandomName);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_LoginUITask.<>f__mg$cache43);
		if (Lua_BlackJack_ProjectL_UI_LoginUITask.<>f__mg$cache44 == null)
		{
			Lua_BlackJack_ProjectL_UI_LoginUITask.<>f__mg$cache44 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_LoginUITask.EnableInput);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_LoginUITask.<>f__mg$cache44);
		if (Lua_BlackJack_ProjectL_UI_LoginUITask.<>f__mg$cache45 == null)
		{
			Lua_BlackJack_ProjectL_UI_LoginUITask.<>f__mg$cache45 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_LoginUITask.PDLogin);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_LoginUITask.<>f__mg$cache45);
		if (Lua_BlackJack_ProjectL_UI_LoginUITask.<>f__mg$cache46 == null)
		{
			Lua_BlackJack_ProjectL_UI_LoginUITask.<>f__mg$cache46 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_LoginUITask.LoginUIController_OnLoginPCClient);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_LoginUITask.<>f__mg$cache46);
		if (Lua_BlackJack_ProjectL_UI_LoginUITask.<>f__mg$cache47 == null)
		{
			Lua_BlackJack_ProjectL_UI_LoginUITask.<>f__mg$cache47 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_LoginUITask.PDSDK_OnInitFailed);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_LoginUITask.<>f__mg$cache47);
		if (Lua_BlackJack_ProjectL_UI_LoginUITask.<>f__mg$cache48 == null)
		{
			Lua_BlackJack_ProjectL_UI_LoginUITask.<>f__mg$cache48 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_LoginUITask.PDSDK_OnInitSucess);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_LoginUITask.<>f__mg$cache48);
		if (Lua_BlackJack_ProjectL_UI_LoginUITask.<>f__mg$cache49 == null)
		{
			Lua_BlackJack_ProjectL_UI_LoginUITask.<>f__mg$cache49 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_LoginUITask.ClearSDKUserIDOfAllServer);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_LoginUITask.<>f__mg$cache49);
		if (Lua_BlackJack_ProjectL_UI_LoginUITask.<>f__mg$cache4A == null)
		{
			Lua_BlackJack_ProjectL_UI_LoginUITask.<>f__mg$cache4A = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_LoginUITask.ParseLoginAgentAck);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_LoginUITask.<>f__mg$cache4A);
		if (Lua_BlackJack_ProjectL_UI_LoginUITask.<>f__mg$cache4B == null)
		{
			Lua_BlackJack_ProjectL_UI_LoginUITask.<>f__mg$cache4B = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_LoginUITask.LoginAgent);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_LoginUITask.<>f__mg$cache4B);
		if (Lua_BlackJack_ProjectL_UI_LoginUITask.<>f__mg$cache4C == null)
		{
			Lua_BlackJack_ProjectL_UI_LoginUITask.<>f__mg$cache4C = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_LoginUITask.SetPlatformInfoToServerList);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_LoginUITask.<>f__mg$cache4C);
		if (Lua_BlackJack_ProjectL_UI_LoginUITask.<>f__mg$cache4D == null)
		{
			Lua_BlackJack_ProjectL_UI_LoginUITask.<>f__mg$cache4D = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_LoginUITask.LoginUIController_OnOpenUserCenter);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_LoginUITask.<>f__mg$cache4D);
		if (Lua_BlackJack_ProjectL_UI_LoginUITask.<>f__mg$cache4E == null)
		{
			Lua_BlackJack_ProjectL_UI_LoginUITask.<>f__mg$cache4E = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_LoginUITask.SwitchUserAccount);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_LoginUITask.<>f__mg$cache4E);
		if (Lua_BlackJack_ProjectL_UI_LoginUITask.<>f__mg$cache4F == null)
		{
			Lua_BlackJack_ProjectL_UI_LoginUITask.<>f__mg$cache4F = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_LoginUITask.LoginUIController_OnAccountTextChanged);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_LoginUITask.<>f__mg$cache4F);
		if (Lua_BlackJack_ProjectL_UI_LoginUITask.<>f__mg$cache50 == null)
		{
			Lua_BlackJack_ProjectL_UI_LoginUITask.<>f__mg$cache50 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_LoginUITask.LoginUIController_OnSaveServerConfig);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_LoginUITask.<>f__mg$cache50);
		if (Lua_BlackJack_ProjectL_UI_LoginUITask.<>f__mg$cache51 == null)
		{
			Lua_BlackJack_ProjectL_UI_LoginUITask.<>f__mg$cache51 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_LoginUITask.LoginUIController_OnCloseAnnouncePanel);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_LoginUITask.<>f__mg$cache51);
		if (Lua_BlackJack_ProjectL_UI_LoginUITask.<>f__mg$cache52 == null)
		{
			Lua_BlackJack_ProjectL_UI_LoginUITask.<>f__mg$cache52 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_LoginUITask.LoginUIController_OnOpenAnnouncePanel);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_LoginUITask.<>f__mg$cache52);
		if (Lua_BlackJack_ProjectL_UI_LoginUITask.<>f__mg$cache53 == null)
		{
			Lua_BlackJack_ProjectL_UI_LoginUITask.<>f__mg$cache53 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_LoginUITask.LoginUIController_OnSelectServerClick);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_LoginUITask.<>f__mg$cache53);
		if (Lua_BlackJack_ProjectL_UI_LoginUITask.<>f__mg$cache54 == null)
		{
			Lua_BlackJack_ProjectL_UI_LoginUITask.<>f__mg$cache54 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_LoginUITask.IsNeedLoadStaticRes);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_LoginUITask.<>f__mg$cache54);
		if (Lua_BlackJack_ProjectL_UI_LoginUITask.<>f__mg$cache55 == null)
		{
			Lua_BlackJack_ProjectL_UI_LoginUITask.<>f__mg$cache55 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_LoginUITask.CollectAllStaticResDescForLoad);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_LoginUITask.<>f__mg$cache55);
		if (Lua_BlackJack_ProjectL_UI_LoginUITask.<>f__mg$cache56 == null)
		{
			Lua_BlackJack_ProjectL_UI_LoginUITask.<>f__mg$cache56 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_LoginUITask.ShowServerListUI);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_LoginUITask.<>f__mg$cache56);
		if (Lua_BlackJack_ProjectL_UI_LoginUITask.<>f__mg$cache57 == null)
		{
			Lua_BlackJack_ProjectL_UI_LoginUITask.<>f__mg$cache57 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_LoginUITask.KeepUpdatingServerList);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_LoginUITask.<>f__mg$cache57);
		if (Lua_BlackJack_ProjectL_UI_LoginUITask.<>f__mg$cache58 == null)
		{
			Lua_BlackJack_ProjectL_UI_LoginUITask.<>f__mg$cache58 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_LoginUITask.LoginUIController_OnLogin);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_LoginUITask.<>f__mg$cache58);
		if (Lua_BlackJack_ProjectL_UI_LoginUITask.<>f__mg$cache59 == null)
		{
			Lua_BlackJack_ProjectL_UI_LoginUITask.<>f__mg$cache59 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_LoginUITask.CreateCharacterUIController_OnCreate);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_LoginUITask.<>f__mg$cache59);
		if (Lua_BlackJack_ProjectL_UI_LoginUITask.<>f__mg$cache5A == null)
		{
			Lua_BlackJack_ProjectL_UI_LoginUITask.<>f__mg$cache5A = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_LoginUITask.CreateCharacterUIController_OnAutoName);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_LoginUITask.<>f__mg$cache5A);
		if (Lua_BlackJack_ProjectL_UI_LoginUITask.<>f__mg$cache5B == null)
		{
			Lua_BlackJack_ProjectL_UI_LoginUITask.<>f__mg$cache5B = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_LoginUITask.UpdateServerList);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_LoginUITask.<>f__mg$cache5B);
		if (Lua_BlackJack_ProjectL_UI_LoginUITask.<>f__mg$cache5C == null)
		{
			Lua_BlackJack_ProjectL_UI_LoginUITask.<>f__mg$cache5C = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_LoginUITask.__callBase_OnStop);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_LoginUITask.<>f__mg$cache5C);
		if (Lua_BlackJack_ProjectL_UI_LoginUITask.<>f__mg$cache5D == null)
		{
			Lua_BlackJack_ProjectL_UI_LoginUITask.<>f__mg$cache5D = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_LoginUITask.__callBase_PostUpdateView);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_LoginUITask.<>f__mg$cache5D);
		if (Lua_BlackJack_ProjectL_UI_LoginUITask.<>f__mg$cache5E == null)
		{
			Lua_BlackJack_ProjectL_UI_LoginUITask.<>f__mg$cache5E = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_LoginUITask.__callBase_IsSDKLogin);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_LoginUITask.<>f__mg$cache5E);
		if (Lua_BlackJack_ProjectL_UI_LoginUITask.<>f__mg$cache5F == null)
		{
			Lua_BlackJack_ProjectL_UI_LoginUITask.<>f__mg$cache5F = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_LoginUITask.__callBase_IsEditorTestLogin);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_LoginUITask.<>f__mg$cache5F);
		if (Lua_BlackJack_ProjectL_UI_LoginUITask.<>f__mg$cache60 == null)
		{
			Lua_BlackJack_ProjectL_UI_LoginUITask.<>f__mg$cache60 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_LoginUITask.__callBase_StartInitSDK);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_LoginUITask.<>f__mg$cache60);
		if (Lua_BlackJack_ProjectL_UI_LoginUITask.<>f__mg$cache61 == null)
		{
			Lua_BlackJack_ProjectL_UI_LoginUITask.<>f__mg$cache61 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_LoginUITask.__callBase_OnSDKInitEnd);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_LoginUITask.<>f__mg$cache61);
		if (Lua_BlackJack_ProjectL_UI_LoginUITask.<>f__mg$cache62 == null)
		{
			Lua_BlackJack_ProjectL_UI_LoginUITask.<>f__mg$cache62 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_LoginUITask.__callBase_StartSDKLogin);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_LoginUITask.<>f__mg$cache62);
		if (Lua_BlackJack_ProjectL_UI_LoginUITask.<>f__mg$cache63 == null)
		{
			Lua_BlackJack_ProjectL_UI_LoginUITask.<>f__mg$cache63 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_LoginUITask.__callBase_OnSDKLoginEnd);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_LoginUITask.<>f__mg$cache63);
		if (Lua_BlackJack_ProjectL_UI_LoginUITask.<>f__mg$cache64 == null)
		{
			Lua_BlackJack_ProjectL_UI_LoginUITask.<>f__mg$cache64 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_LoginUITask.__callBase_PostSDKLogin);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_LoginUITask.<>f__mg$cache64);
		if (Lua_BlackJack_ProjectL_UI_LoginUITask.<>f__mg$cache65 == null)
		{
			Lua_BlackJack_ProjectL_UI_LoginUITask.<>f__mg$cache65 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_LoginUITask.__callBase_IsNeedSelectServer);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_LoginUITask.<>f__mg$cache65);
		if (Lua_BlackJack_ProjectL_UI_LoginUITask.<>f__mg$cache66 == null)
		{
			Lua_BlackJack_ProjectL_UI_LoginUITask.<>f__mg$cache66 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_LoginUITask.__callBase_LaunchServerListUI);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_LoginUITask.<>f__mg$cache66);
		if (Lua_BlackJack_ProjectL_UI_LoginUITask.<>f__mg$cache67 == null)
		{
			Lua_BlackJack_ProjectL_UI_LoginUITask.<>f__mg$cache67 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_LoginUITask.__callBase_DownloadServerList);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_LoginUITask.<>f__mg$cache67);
		if (Lua_BlackJack_ProjectL_UI_LoginUITask.<>f__mg$cache68 == null)
		{
			Lua_BlackJack_ProjectL_UI_LoginUITask.<>f__mg$cache68 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_LoginUITask.__callBase_OnDownloadServerListEnd);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_LoginUITask.<>f__mg$cache68);
		if (Lua_BlackJack_ProjectL_UI_LoginUITask.<>f__mg$cache69 == null)
		{
			Lua_BlackJack_ProjectL_UI_LoginUITask.<>f__mg$cache69 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_LoginUITask.__callBase_ShowServerListUI);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_LoginUITask.<>f__mg$cache69);
		if (Lua_BlackJack_ProjectL_UI_LoginUITask.<>f__mg$cache6A == null)
		{
			Lua_BlackJack_ProjectL_UI_LoginUITask.<>f__mg$cache6A = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_LoginUITask.__callBase_OnGameServerConfirmed);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_LoginUITask.<>f__mg$cache6A);
		if (Lua_BlackJack_ProjectL_UI_LoginUITask.<>f__mg$cache6B == null)
		{
			Lua_BlackJack_ProjectL_UI_LoginUITask.<>f__mg$cache6B = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_LoginUITask.__callBase_InitServerCtxByServerID);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_LoginUITask.<>f__mg$cache6B);
		if (Lua_BlackJack_ProjectL_UI_LoginUITask.<>f__mg$cache6C == null)
		{
			Lua_BlackJack_ProjectL_UI_LoginUITask.<>f__mg$cache6C = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_LoginUITask.__callBase_GetLastLoginedServerID);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_LoginUITask.<>f__mg$cache6C);
		if (Lua_BlackJack_ProjectL_UI_LoginUITask.<>f__mg$cache6D == null)
		{
			Lua_BlackJack_ProjectL_UI_LoginUITask.<>f__mg$cache6D = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_LoginUITask.__callBase_LaunchEnterGameUI);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_LoginUITask.<>f__mg$cache6D);
		if (Lua_BlackJack_ProjectL_UI_LoginUITask.<>f__mg$cache6E == null)
		{
			Lua_BlackJack_ProjectL_UI_LoginUITask.<>f__mg$cache6E = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_LoginUITask.__callBase_LaunchEnterGameUIWithGameSettingTokenAndServer);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_LoginUITask.<>f__mg$cache6E);
		if (Lua_BlackJack_ProjectL_UI_LoginUITask.<>f__mg$cache6F == null)
		{
			Lua_BlackJack_ProjectL_UI_LoginUITask.<>f__mg$cache6F = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_LoginUITask.__callBase_LaunchEnterGameUIWithUIInputAccountAndServer);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_LoginUITask.<>f__mg$cache6F);
		if (Lua_BlackJack_ProjectL_UI_LoginUITask.<>f__mg$cache70 == null)
		{
			Lua_BlackJack_ProjectL_UI_LoginUITask.<>f__mg$cache70 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_LoginUITask.__callBase_LoadLastLoginWithUIInputInfo);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_LoginUITask.<>f__mg$cache70);
		if (Lua_BlackJack_ProjectL_UI_LoginUITask.<>f__mg$cache71 == null)
		{
			Lua_BlackJack_ProjectL_UI_LoginUITask.<>f__mg$cache71 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_LoginUITask.__callBase_DownloadGameServerLoginAnnouncement);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_LoginUITask.<>f__mg$cache71);
		if (Lua_BlackJack_ProjectL_UI_LoginUITask.<>f__mg$cache72 == null)
		{
			Lua_BlackJack_ProjectL_UI_LoginUITask.<>f__mg$cache72 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_LoginUITask.__callBase_OnDownloadGameServerLoginAnnouncementEnd);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_LoginUITask.<>f__mg$cache72);
		if (Lua_BlackJack_ProjectL_UI_LoginUITask.<>f__mg$cache73 == null)
		{
			Lua_BlackJack_ProjectL_UI_LoginUITask.<>f__mg$cache73 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_LoginUITask.__callBase_ShowGameServerLoginAnnouncementUI);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_LoginUITask.<>f__mg$cache73);
		if (Lua_BlackJack_ProjectL_UI_LoginUITask.<>f__mg$cache74 == null)
		{
			Lua_BlackJack_ProjectL_UI_LoginUITask.<>f__mg$cache74 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_LoginUITask.__callBase_ShowEnterGameUI);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_LoginUITask.<>f__mg$cache74);
		if (Lua_BlackJack_ProjectL_UI_LoginUITask.<>f__mg$cache75 == null)
		{
			Lua_BlackJack_ProjectL_UI_LoginUITask.<>f__mg$cache75 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_LoginUITask.__callBase_OnEnterGameConfirmed);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_LoginUITask.<>f__mg$cache75);
		if (Lua_BlackJack_ProjectL_UI_LoginUITask.<>f__mg$cache76 == null)
		{
			Lua_BlackJack_ProjectL_UI_LoginUITask.<>f__mg$cache76 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_LoginUITask.__callBase_StartLoginAgentLogin);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_LoginUITask.<>f__mg$cache76);
		if (Lua_BlackJack_ProjectL_UI_LoginUITask.<>f__mg$cache77 == null)
		{
			Lua_BlackJack_ProjectL_UI_LoginUITask.<>f__mg$cache77 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_LoginUITask.__callBase_LoginAgentLoginEnd);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_LoginUITask.<>f__mg$cache77);
		if (Lua_BlackJack_ProjectL_UI_LoginUITask.<>f__mg$cache78 == null)
		{
			Lua_BlackJack_ProjectL_UI_LoginUITask.<>f__mg$cache78 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_LoginUITask.__callBase_StartAuthLogin);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_LoginUITask.<>f__mg$cache78);
		if (Lua_BlackJack_ProjectL_UI_LoginUITask.<>f__mg$cache79 == null)
		{
			Lua_BlackJack_ProjectL_UI_LoginUITask.<>f__mg$cache79 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_LoginUITask.__callBase_StartSessionLogin);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_LoginUITask.<>f__mg$cache79);
		if (Lua_BlackJack_ProjectL_UI_LoginUITask.<>f__mg$cache7A == null)
		{
			Lua_BlackJack_ProjectL_UI_LoginUITask.<>f__mg$cache7A = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_LoginUITask.__callBase_StartPlayerInfoInitReq);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_LoginUITask.<>f__mg$cache7A);
		if (Lua_BlackJack_ProjectL_UI_LoginUITask.<>f__mg$cache7B == null)
		{
			Lua_BlackJack_ProjectL_UI_LoginUITask.<>f__mg$cache7B = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_LoginUITask.__callBase_LauncheMainUI);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_LoginUITask.<>f__mg$cache7B);
		if (Lua_BlackJack_ProjectL_UI_LoginUITask.<>f__mg$cache7C == null)
		{
			Lua_BlackJack_ProjectL_UI_LoginUITask.<>f__mg$cache7C = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_LoginUITask.__callBase_OnWaitingMsgAckOutTime);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_LoginUITask.<>f__mg$cache7C);
		if (Lua_BlackJack_ProjectL_UI_LoginUITask.<>f__mg$cache7D == null)
		{
			Lua_BlackJack_ProjectL_UI_LoginUITask.<>f__mg$cache7D = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_LoginUITask.__callBase_StartWaitingMsgAck);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_LoginUITask.<>f__mg$cache7D);
		if (Lua_BlackJack_ProjectL_UI_LoginUITask.<>f__mg$cache7E == null)
		{
			Lua_BlackJack_ProjectL_UI_LoginUITask.<>f__mg$cache7E = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_LoginUITask.__callBase_StopWaitingMsgAck);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_LoginUITask.<>f__mg$cache7E);
		if (Lua_BlackJack_ProjectL_UI_LoginUITask.<>f__mg$cache7F == null)
		{
			Lua_BlackJack_ProjectL_UI_LoginUITask.<>f__mg$cache7F = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_LoginUITask.__callBase_ClearGameServerLoginState);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_LoginUITask.<>f__mg$cache7F);
		if (Lua_BlackJack_ProjectL_UI_LoginUITask.<>f__mg$cache80 == null)
		{
			Lua_BlackJack_ProjectL_UI_LoginUITask.<>f__mg$cache80 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_LoginUITask.__callBase_OnTick);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_LoginUITask.<>f__mg$cache80);
		if (Lua_BlackJack_ProjectL_UI_LoginUITask.<>f__mg$cache81 == null)
		{
			Lua_BlackJack_ProjectL_UI_LoginUITask.<>f__mg$cache81 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_LoginUITask.__callBase_OnGameServerConnected);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_LoginUITask.<>f__mg$cache81);
		if (Lua_BlackJack_ProjectL_UI_LoginUITask.<>f__mg$cache82 == null)
		{
			Lua_BlackJack_ProjectL_UI_LoginUITask.<>f__mg$cache82 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_LoginUITask.__callBase_OnGameServerDisconnected);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_LoginUITask.<>f__mg$cache82);
		if (Lua_BlackJack_ProjectL_UI_LoginUITask.<>f__mg$cache83 == null)
		{
			Lua_BlackJack_ProjectL_UI_LoginUITask.<>f__mg$cache83 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_LoginUITask.__callBase_OnGameServerNetworkError);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_LoginUITask.<>f__mg$cache83);
		if (Lua_BlackJack_ProjectL_UI_LoginUITask.<>f__mg$cache84 == null)
		{
			Lua_BlackJack_ProjectL_UI_LoginUITask.<>f__mg$cache84 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_LoginUITask.__callBase_OnLoginByAuthTokenAck);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_LoginUITask.<>f__mg$cache84);
		if (Lua_BlackJack_ProjectL_UI_LoginUITask.<>f__mg$cache85 == null)
		{
			Lua_BlackJack_ProjectL_UI_LoginUITask.<>f__mg$cache85 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_LoginUITask.__callBase_OnLoginBySessionTokenAck);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_LoginUITask.<>f__mg$cache85);
		if (Lua_BlackJack_ProjectL_UI_LoginUITask.<>f__mg$cache86 == null)
		{
			Lua_BlackJack_ProjectL_UI_LoginUITask.<>f__mg$cache86 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_LoginUITask.__callBase_OnConfigDataMD5InfoNtf);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_LoginUITask.<>f__mg$cache86);
		if (Lua_BlackJack_ProjectL_UI_LoginUITask.<>f__mg$cache87 == null)
		{
			Lua_BlackJack_ProjectL_UI_LoginUITask.<>f__mg$cache87 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_LoginUITask.__callBase_OnPlayerInfoInitEnd);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_LoginUITask.<>f__mg$cache87);
		if (Lua_BlackJack_ProjectL_UI_LoginUITask.<>f__mg$cache88 == null)
		{
			Lua_BlackJack_ProjectL_UI_LoginUITask.<>f__mg$cache88 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_LoginUITask.InitializeGlobals_s);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_LoginUITask.<>f__mg$cache88);
		if (Lua_BlackJack_ProjectL_UI_LoginUITask.<>f__mg$cache89 == null)
		{
			Lua_BlackJack_ProjectL_UI_LoginUITask.<>f__mg$cache89 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_LoginUITask.InitLocalConfig_s);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_LoginUITask.<>f__mg$cache89);
		if (Lua_BlackJack_ProjectL_UI_LoginUITask.<>f__mg$cache8A == null)
		{
			Lua_BlackJack_ProjectL_UI_LoginUITask.<>f__mg$cache8A = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_LoginUITask.LogSystemInfo_s);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_LoginUITask.<>f__mg$cache8A);
		if (Lua_BlackJack_ProjectL_UI_LoginUITask.<>f__mg$cache8B == null)
		{
			Lua_BlackJack_ProjectL_UI_LoginUITask.<>f__mg$cache8B = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_LoginUITask.GetPushNotificationTime_s);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_LoginUITask.<>f__mg$cache8B);
		if (Lua_BlackJack_ProjectL_UI_LoginUITask.<>f__mg$cache8C == null)
		{
			Lua_BlackJack_ProjectL_UI_LoginUITask.<>f__mg$cache8C = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_LoginUITask.GetRecentLoginServerList_s);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_LoginUITask.<>f__mg$cache8C);
		if (Lua_BlackJack_ProjectL_UI_LoginUITask.<>f__mg$cache8D == null)
		{
			Lua_BlackJack_ProjectL_UI_LoginUITask.<>f__mg$cache8D = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_LoginUITask.GetStartGameOrCreateRoleJsonString_s);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_LoginUITask.<>f__mg$cache8D);
		if (Lua_BlackJack_ProjectL_UI_LoginUITask.<>f__mg$cache8E == null)
		{
			Lua_BlackJack_ProjectL_UI_LoginUITask.<>f__mg$cache8E = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_LoginUITask.Co_UnloadAssetsAndStartPreloadUITask_s);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_LoginUITask.<>f__mg$cache8E);
		if (Lua_BlackJack_ProjectL_UI_LoginUITask.<>f__mg$cache8F == null)
		{
			Lua_BlackJack_ProjectL_UI_LoginUITask.<>f__mg$cache8F = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_LoginUITask.NetWorkTransactionTask_OnReLoginBySession_s);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_LoginUITask.<>f__mg$cache8F);
		if (Lua_BlackJack_ProjectL_UI_LoginUITask.<>f__mg$cache90 == null)
		{
			Lua_BlackJack_ProjectL_UI_LoginUITask.<>f__mg$cache90 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_LoginUITask.NetWorkTransactionTask_ReturnToLoginUI_s);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_LoginUITask.<>f__mg$cache90);
		if (Lua_BlackJack_ProjectL_UI_LoginUITask.<>f__mg$cache91 == null)
		{
			Lua_BlackJack_ProjectL_UI_LoginUITask.<>f__mg$cache91 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_LoginUITask.ParseServerListText_s);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_LoginUITask.<>f__mg$cache91);
		if (Lua_BlackJack_ProjectL_UI_LoginUITask.<>f__mg$cache92 == null)
		{
			Lua_BlackJack_ProjectL_UI_LoginUITask.<>f__mg$cache92 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_LoginUITask.ParseServerOpenDateTime_s);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_LoginUITask.<>f__mg$cache92);
		if (Lua_BlackJack_ProjectL_UI_LoginUITask.<>f__mg$cache93 == null)
		{
			Lua_BlackJack_ProjectL_UI_LoginUITask.<>f__mg$cache93 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_LoginUITask.NetWorkTransactionTask_OnEventShowUIWaiting_s);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_LoginUITask.<>f__mg$cache93);
		string name = "m_layerDescArray";
		if (Lua_BlackJack_ProjectL_UI_LoginUITask.<>f__mg$cache94 == null)
		{
			Lua_BlackJack_ProjectL_UI_LoginUITask.<>f__mg$cache94 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_LoginUITask.get_m_layerDescArray);
		}
		LuaCSFunction get = Lua_BlackJack_ProjectL_UI_LoginUITask.<>f__mg$cache94;
		if (Lua_BlackJack_ProjectL_UI_LoginUITask.<>f__mg$cache95 == null)
		{
			Lua_BlackJack_ProjectL_UI_LoginUITask.<>f__mg$cache95 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_LoginUITask.set_m_layerDescArray);
		}
		LuaObject.addMember(l, name, get, Lua_BlackJack_ProjectL_UI_LoginUITask.<>f__mg$cache95, true);
		string name2 = "m_uiCtrlDescArray";
		if (Lua_BlackJack_ProjectL_UI_LoginUITask.<>f__mg$cache96 == null)
		{
			Lua_BlackJack_ProjectL_UI_LoginUITask.<>f__mg$cache96 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_LoginUITask.get_m_uiCtrlDescArray);
		}
		LuaCSFunction get2 = Lua_BlackJack_ProjectL_UI_LoginUITask.<>f__mg$cache96;
		if (Lua_BlackJack_ProjectL_UI_LoginUITask.<>f__mg$cache97 == null)
		{
			Lua_BlackJack_ProjectL_UI_LoginUITask.<>f__mg$cache97 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_LoginUITask.set_m_uiCtrlDescArray);
		}
		LuaObject.addMember(l, name2, get2, Lua_BlackJack_ProjectL_UI_LoginUITask.<>f__mg$cache97, true);
		string name3 = "m_loginAgentCoroutine";
		if (Lua_BlackJack_ProjectL_UI_LoginUITask.<>f__mg$cache98 == null)
		{
			Lua_BlackJack_ProjectL_UI_LoginUITask.<>f__mg$cache98 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_LoginUITask.get_m_loginAgentCoroutine);
		}
		LuaCSFunction get3 = Lua_BlackJack_ProjectL_UI_LoginUITask.<>f__mg$cache98;
		if (Lua_BlackJack_ProjectL_UI_LoginUITask.<>f__mg$cache99 == null)
		{
			Lua_BlackJack_ProjectL_UI_LoginUITask.<>f__mg$cache99 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_LoginUITask.set_m_loginAgentCoroutine);
		}
		LuaObject.addMember(l, name3, get3, Lua_BlackJack_ProjectL_UI_LoginUITask.<>f__mg$cache99, true);
		string name4 = "m_loginUIController";
		if (Lua_BlackJack_ProjectL_UI_LoginUITask.<>f__mg$cache9A == null)
		{
			Lua_BlackJack_ProjectL_UI_LoginUITask.<>f__mg$cache9A = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_LoginUITask.get_m_loginUIController);
		}
		LuaCSFunction get4 = Lua_BlackJack_ProjectL_UI_LoginUITask.<>f__mg$cache9A;
		if (Lua_BlackJack_ProjectL_UI_LoginUITask.<>f__mg$cache9B == null)
		{
			Lua_BlackJack_ProjectL_UI_LoginUITask.<>f__mg$cache9B = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_LoginUITask.set_m_loginUIController);
		}
		LuaObject.addMember(l, name4, get4, Lua_BlackJack_ProjectL_UI_LoginUITask.<>f__mg$cache9B, true);
		string name5 = "m_serverListUIController";
		if (Lua_BlackJack_ProjectL_UI_LoginUITask.<>f__mg$cache9C == null)
		{
			Lua_BlackJack_ProjectL_UI_LoginUITask.<>f__mg$cache9C = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_LoginUITask.get_m_serverListUIController);
		}
		LuaCSFunction get5 = Lua_BlackJack_ProjectL_UI_LoginUITask.<>f__mg$cache9C;
		if (Lua_BlackJack_ProjectL_UI_LoginUITask.<>f__mg$cache9D == null)
		{
			Lua_BlackJack_ProjectL_UI_LoginUITask.<>f__mg$cache9D = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_LoginUITask.set_m_serverListUIController);
		}
		LuaObject.addMember(l, name5, get5, Lua_BlackJack_ProjectL_UI_LoginUITask.<>f__mg$cache9D, true);
		string name6 = "m_createCharaterUIController";
		if (Lua_BlackJack_ProjectL_UI_LoginUITask.<>f__mg$cache9E == null)
		{
			Lua_BlackJack_ProjectL_UI_LoginUITask.<>f__mg$cache9E = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_LoginUITask.get_m_createCharaterUIController);
		}
		LuaCSFunction get6 = Lua_BlackJack_ProjectL_UI_LoginUITask.<>f__mg$cache9E;
		if (Lua_BlackJack_ProjectL_UI_LoginUITask.<>f__mg$cache9F == null)
		{
			Lua_BlackJack_ProjectL_UI_LoginUITask.<>f__mg$cache9F = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_LoginUITask.set_m_createCharaterUIController);
		}
		LuaObject.addMember(l, name6, get6, Lua_BlackJack_ProjectL_UI_LoginUITask.<>f__mg$cache9F, true);
		string name7 = "m_loginCommonUIController";
		if (Lua_BlackJack_ProjectL_UI_LoginUITask.<>f__mg$cacheA0 == null)
		{
			Lua_BlackJack_ProjectL_UI_LoginUITask.<>f__mg$cacheA0 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_LoginUITask.get_m_loginCommonUIController);
		}
		LuaCSFunction get7 = Lua_BlackJack_ProjectL_UI_LoginUITask.<>f__mg$cacheA0;
		if (Lua_BlackJack_ProjectL_UI_LoginUITask.<>f__mg$cacheA1 == null)
		{
			Lua_BlackJack_ProjectL_UI_LoginUITask.<>f__mg$cacheA1 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_LoginUITask.set_m_loginCommonUIController);
		}
		LuaObject.addMember(l, name7, get7, Lua_BlackJack_ProjectL_UI_LoginUITask.<>f__mg$cacheA1, true);
		string name8 = "m_retryLoginByAuthTokenCount";
		if (Lua_BlackJack_ProjectL_UI_LoginUITask.<>f__mg$cacheA2 == null)
		{
			Lua_BlackJack_ProjectL_UI_LoginUITask.<>f__mg$cacheA2 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_LoginUITask.get_m_retryLoginByAuthTokenCount);
		}
		LuaCSFunction get8 = Lua_BlackJack_ProjectL_UI_LoginUITask.<>f__mg$cacheA2;
		if (Lua_BlackJack_ProjectL_UI_LoginUITask.<>f__mg$cacheA3 == null)
		{
			Lua_BlackJack_ProjectL_UI_LoginUITask.<>f__mg$cacheA3 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_LoginUITask.set_m_retryLoginByAuthTokenCount);
		}
		LuaObject.addMember(l, name8, get8, Lua_BlackJack_ProjectL_UI_LoginUITask.<>f__mg$cacheA3, true);
		string name9 = "m_retryLoginBySessionTokenCount";
		if (Lua_BlackJack_ProjectL_UI_LoginUITask.<>f__mg$cacheA4 == null)
		{
			Lua_BlackJack_ProjectL_UI_LoginUITask.<>f__mg$cacheA4 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_LoginUITask.get_m_retryLoginBySessionTokenCount);
		}
		LuaCSFunction get9 = Lua_BlackJack_ProjectL_UI_LoginUITask.<>f__mg$cacheA4;
		if (Lua_BlackJack_ProjectL_UI_LoginUITask.<>f__mg$cacheA5 == null)
		{
			Lua_BlackJack_ProjectL_UI_LoginUITask.<>f__mg$cacheA5 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_LoginUITask.set_m_retryLoginBySessionTokenCount);
		}
		LuaObject.addMember(l, name9, get9, Lua_BlackJack_ProjectL_UI_LoginUITask.<>f__mg$cacheA5, true);
		string name10 = "m_assets";
		if (Lua_BlackJack_ProjectL_UI_LoginUITask.<>f__mg$cacheA6 == null)
		{
			Lua_BlackJack_ProjectL_UI_LoginUITask.<>f__mg$cacheA6 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_LoginUITask.get_m_assets);
		}
		LuaCSFunction get10 = Lua_BlackJack_ProjectL_UI_LoginUITask.<>f__mg$cacheA6;
		if (Lua_BlackJack_ProjectL_UI_LoginUITask.<>f__mg$cacheA7 == null)
		{
			Lua_BlackJack_ProjectL_UI_LoginUITask.<>f__mg$cacheA7 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_LoginUITask.set_m_assets);
		}
		LuaObject.addMember(l, name10, get10, Lua_BlackJack_ProjectL_UI_LoginUITask.<>f__mg$cacheA7, true);
		string name11 = "m_randomNameHead";
		if (Lua_BlackJack_ProjectL_UI_LoginUITask.<>f__mg$cacheA8 == null)
		{
			Lua_BlackJack_ProjectL_UI_LoginUITask.<>f__mg$cacheA8 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_LoginUITask.get_m_randomNameHead);
		}
		LuaCSFunction get11 = Lua_BlackJack_ProjectL_UI_LoginUITask.<>f__mg$cacheA8;
		if (Lua_BlackJack_ProjectL_UI_LoginUITask.<>f__mg$cacheA9 == null)
		{
			Lua_BlackJack_ProjectL_UI_LoginUITask.<>f__mg$cacheA9 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_LoginUITask.set_m_randomNameHead);
		}
		LuaObject.addMember(l, name11, get11, Lua_BlackJack_ProjectL_UI_LoginUITask.<>f__mg$cacheA9, true);
		string name12 = "m_randomNameMiddle";
		if (Lua_BlackJack_ProjectL_UI_LoginUITask.<>f__mg$cacheAA == null)
		{
			Lua_BlackJack_ProjectL_UI_LoginUITask.<>f__mg$cacheAA = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_LoginUITask.get_m_randomNameMiddle);
		}
		LuaCSFunction get12 = Lua_BlackJack_ProjectL_UI_LoginUITask.<>f__mg$cacheAA;
		if (Lua_BlackJack_ProjectL_UI_LoginUITask.<>f__mg$cacheAB == null)
		{
			Lua_BlackJack_ProjectL_UI_LoginUITask.<>f__mg$cacheAB = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_LoginUITask.set_m_randomNameMiddle);
		}
		LuaObject.addMember(l, name12, get12, Lua_BlackJack_ProjectL_UI_LoginUITask.<>f__mg$cacheAB, true);
		string name13 = "m_randomNameTail";
		if (Lua_BlackJack_ProjectL_UI_LoginUITask.<>f__mg$cacheAC == null)
		{
			Lua_BlackJack_ProjectL_UI_LoginUITask.<>f__mg$cacheAC = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_LoginUITask.get_m_randomNameTail);
		}
		LuaCSFunction get13 = Lua_BlackJack_ProjectL_UI_LoginUITask.<>f__mg$cacheAC;
		if (Lua_BlackJack_ProjectL_UI_LoginUITask.<>f__mg$cacheAD == null)
		{
			Lua_BlackJack_ProjectL_UI_LoginUITask.<>f__mg$cacheAD = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_LoginUITask.set_m_randomNameTail);
		}
		LuaObject.addMember(l, name13, get13, Lua_BlackJack_ProjectL_UI_LoginUITask.<>f__mg$cacheAD, true);
		string name14 = "m_randomNameRandom";
		if (Lua_BlackJack_ProjectL_UI_LoginUITask.<>f__mg$cacheAE == null)
		{
			Lua_BlackJack_ProjectL_UI_LoginUITask.<>f__mg$cacheAE = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_LoginUITask.get_m_randomNameRandom);
		}
		LuaCSFunction get14 = Lua_BlackJack_ProjectL_UI_LoginUITask.<>f__mg$cacheAE;
		if (Lua_BlackJack_ProjectL_UI_LoginUITask.<>f__mg$cacheAF == null)
		{
			Lua_BlackJack_ProjectL_UI_LoginUITask.<>f__mg$cacheAF = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_LoginUITask.set_m_randomNameRandom);
		}
		LuaObject.addMember(l, name14, get14, Lua_BlackJack_ProjectL_UI_LoginUITask.<>f__mg$cacheAF, true);
		string name15 = "m_configDataLoader";
		if (Lua_BlackJack_ProjectL_UI_LoginUITask.<>f__mg$cacheB0 == null)
		{
			Lua_BlackJack_ProjectL_UI_LoginUITask.<>f__mg$cacheB0 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_LoginUITask.get_m_configDataLoader);
		}
		LuaCSFunction get15 = Lua_BlackJack_ProjectL_UI_LoginUITask.<>f__mg$cacheB0;
		if (Lua_BlackJack_ProjectL_UI_LoginUITask.<>f__mg$cacheB1 == null)
		{
			Lua_BlackJack_ProjectL_UI_LoginUITask.<>f__mg$cacheB1 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_LoginUITask.set_m_configDataLoader);
		}
		LuaObject.addMember(l, name15, get15, Lua_BlackJack_ProjectL_UI_LoginUITask.<>f__mg$cacheB1, true);
		string name16 = "s_isGlobalInitialized";
		if (Lua_BlackJack_ProjectL_UI_LoginUITask.<>f__mg$cacheB2 == null)
		{
			Lua_BlackJack_ProjectL_UI_LoginUITask.<>f__mg$cacheB2 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_LoginUITask.get_s_isGlobalInitialized);
		}
		LuaCSFunction get16 = Lua_BlackJack_ProjectL_UI_LoginUITask.<>f__mg$cacheB2;
		if (Lua_BlackJack_ProjectL_UI_LoginUITask.<>f__mg$cacheB3 == null)
		{
			Lua_BlackJack_ProjectL_UI_LoginUITask.<>f__mg$cacheB3 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_LoginUITask.set_s_isGlobalInitialized);
		}
		LuaObject.addMember(l, name16, get16, Lua_BlackJack_ProjectL_UI_LoginUITask.<>f__mg$cacheB3, false);
		string name17 = "s_localConfigPath";
		if (Lua_BlackJack_ProjectL_UI_LoginUITask.<>f__mg$cacheB4 == null)
		{
			Lua_BlackJack_ProjectL_UI_LoginUITask.<>f__mg$cacheB4 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_LoginUITask.get_s_localConfigPath);
		}
		LuaCSFunction get17 = Lua_BlackJack_ProjectL_UI_LoginUITask.<>f__mg$cacheB4;
		if (Lua_BlackJack_ProjectL_UI_LoginUITask.<>f__mg$cacheB5 == null)
		{
			Lua_BlackJack_ProjectL_UI_LoginUITask.<>f__mg$cacheB5 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_LoginUITask.set_s_localConfigPath);
		}
		LuaObject.addMember(l, name17, get17, Lua_BlackJack_ProjectL_UI_LoginUITask.<>f__mg$cacheB5, false);
		string name18 = "m_loadConfigFailedMessage";
		if (Lua_BlackJack_ProjectL_UI_LoginUITask.<>f__mg$cacheB6 == null)
		{
			Lua_BlackJack_ProjectL_UI_LoginUITask.<>f__mg$cacheB6 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_LoginUITask.get_m_loadConfigFailedMessage);
		}
		LuaCSFunction get18 = Lua_BlackJack_ProjectL_UI_LoginUITask.<>f__mg$cacheB6;
		if (Lua_BlackJack_ProjectL_UI_LoginUITask.<>f__mg$cacheB7 == null)
		{
			Lua_BlackJack_ProjectL_UI_LoginUITask.<>f__mg$cacheB7 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_LoginUITask.set_m_loadConfigFailedMessage);
		}
		LuaObject.addMember(l, name18, get18, Lua_BlackJack_ProjectL_UI_LoginUITask.<>f__mg$cacheB7, false);
		string name19 = "m_curLoadingLayers";
		if (Lua_BlackJack_ProjectL_UI_LoginUITask.<>f__mg$cacheB8 == null)
		{
			Lua_BlackJack_ProjectL_UI_LoginUITask.<>f__mg$cacheB8 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_LoginUITask.get_m_curLoadingLayers);
		}
		LuaCSFunction get19 = Lua_BlackJack_ProjectL_UI_LoginUITask.<>f__mg$cacheB8;
		if (Lua_BlackJack_ProjectL_UI_LoginUITask.<>f__mg$cacheB9 == null)
		{
			Lua_BlackJack_ProjectL_UI_LoginUITask.<>f__mg$cacheB9 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_LoginUITask.set_m_curLoadingLayers);
		}
		LuaObject.addMember(l, name19, get19, Lua_BlackJack_ProjectL_UI_LoginUITask.<>f__mg$cacheB9, true);
		string name20 = "m_serverListText";
		if (Lua_BlackJack_ProjectL_UI_LoginUITask.<>f__mg$cacheBA == null)
		{
			Lua_BlackJack_ProjectL_UI_LoginUITask.<>f__mg$cacheBA = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_LoginUITask.get_m_serverListText);
		}
		LuaCSFunction get20 = Lua_BlackJack_ProjectL_UI_LoginUITask.<>f__mg$cacheBA;
		if (Lua_BlackJack_ProjectL_UI_LoginUITask.<>f__mg$cacheBB == null)
		{
			Lua_BlackJack_ProjectL_UI_LoginUITask.<>f__mg$cacheBB = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_LoginUITask.set_m_serverListText);
		}
		LuaObject.addMember(l, name20, get20, Lua_BlackJack_ProjectL_UI_LoginUITask.<>f__mg$cacheBB, false);
		string name21 = "m_serverlist";
		if (Lua_BlackJack_ProjectL_UI_LoginUITask.<>f__mg$cacheBC == null)
		{
			Lua_BlackJack_ProjectL_UI_LoginUITask.<>f__mg$cacheBC = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_LoginUITask.get_m_serverlist);
		}
		LuaCSFunction get21 = Lua_BlackJack_ProjectL_UI_LoginUITask.<>f__mg$cacheBC;
		if (Lua_BlackJack_ProjectL_UI_LoginUITask.<>f__mg$cacheBD == null)
		{
			Lua_BlackJack_ProjectL_UI_LoginUITask.<>f__mg$cacheBD = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_LoginUITask.set_m_serverlist);
		}
		LuaObject.addMember(l, name21, get21, Lua_BlackJack_ProjectL_UI_LoginUITask.<>f__mg$cacheBD, false);
		string name22 = "m_isRecentLoginServerIDInServerlist";
		if (Lua_BlackJack_ProjectL_UI_LoginUITask.<>f__mg$cacheBE == null)
		{
			Lua_BlackJack_ProjectL_UI_LoginUITask.<>f__mg$cacheBE = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_LoginUITask.get_m_isRecentLoginServerIDInServerlist);
		}
		LuaCSFunction get22 = Lua_BlackJack_ProjectL_UI_LoginUITask.<>f__mg$cacheBE;
		if (Lua_BlackJack_ProjectL_UI_LoginUITask.<>f__mg$cacheBF == null)
		{
			Lua_BlackJack_ProjectL_UI_LoginUITask.<>f__mg$cacheBF = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_LoginUITask.set_m_isRecentLoginServerIDInServerlist);
		}
		LuaObject.addMember(l, name22, get22, Lua_BlackJack_ProjectL_UI_LoginUITask.<>f__mg$cacheBF, false);
		string name23 = "m_curSelectServerID";
		if (Lua_BlackJack_ProjectL_UI_LoginUITask.<>f__mg$cacheC0 == null)
		{
			Lua_BlackJack_ProjectL_UI_LoginUITask.<>f__mg$cacheC0 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_LoginUITask.get_m_curSelectServerID);
		}
		LuaCSFunction get23 = Lua_BlackJack_ProjectL_UI_LoginUITask.<>f__mg$cacheC0;
		if (Lua_BlackJack_ProjectL_UI_LoginUITask.<>f__mg$cacheC1 == null)
		{
			Lua_BlackJack_ProjectL_UI_LoginUITask.<>f__mg$cacheC1 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_LoginUITask.set_m_curSelectServerID);
		}
		LuaObject.addMember(l, name23, get23, Lua_BlackJack_ProjectL_UI_LoginUITask.<>f__mg$cacheC1, false);
		string name24 = "m_recommendServerIndex";
		if (Lua_BlackJack_ProjectL_UI_LoginUITask.<>f__mg$cacheC2 == null)
		{
			Lua_BlackJack_ProjectL_UI_LoginUITask.<>f__mg$cacheC2 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_LoginUITask.get_m_recommendServerIndex);
		}
		LuaCSFunction get24 = Lua_BlackJack_ProjectL_UI_LoginUITask.<>f__mg$cacheC2;
		if (Lua_BlackJack_ProjectL_UI_LoginUITask.<>f__mg$cacheC3 == null)
		{
			Lua_BlackJack_ProjectL_UI_LoginUITask.<>f__mg$cacheC3 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_LoginUITask.set_m_recommendServerIndex);
		}
		LuaObject.addMember(l, name24, get24, Lua_BlackJack_ProjectL_UI_LoginUITask.<>f__mg$cacheC3, false);
		string name25 = "m_totalRecommandWeight";
		if (Lua_BlackJack_ProjectL_UI_LoginUITask.<>f__mg$cacheC4 == null)
		{
			Lua_BlackJack_ProjectL_UI_LoginUITask.<>f__mg$cacheC4 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_LoginUITask.get_m_totalRecommandWeight);
		}
		LuaCSFunction get25 = Lua_BlackJack_ProjectL_UI_LoginUITask.<>f__mg$cacheC4;
		if (Lua_BlackJack_ProjectL_UI_LoginUITask.<>f__mg$cacheC5 == null)
		{
			Lua_BlackJack_ProjectL_UI_LoginUITask.<>f__mg$cacheC5 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_LoginUITask.set_m_totalRecommandWeight);
		}
		LuaObject.addMember(l, name25, get25, Lua_BlackJack_ProjectL_UI_LoginUITask.<>f__mg$cacheC5, false);
		string name26 = "m_exsitCharsInfo";
		if (Lua_BlackJack_ProjectL_UI_LoginUITask.<>f__mg$cacheC6 == null)
		{
			Lua_BlackJack_ProjectL_UI_LoginUITask.<>f__mg$cacheC6 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_LoginUITask.get_m_exsitCharsInfo);
		}
		LuaCSFunction get26 = Lua_BlackJack_ProjectL_UI_LoginUITask.<>f__mg$cacheC6;
		if (Lua_BlackJack_ProjectL_UI_LoginUITask.<>f__mg$cacheC7 == null)
		{
			Lua_BlackJack_ProjectL_UI_LoginUITask.<>f__mg$cacheC7 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_LoginUITask.set_m_exsitCharsInfo);
		}
		LuaObject.addMember(l, name26, get26, Lua_BlackJack_ProjectL_UI_LoginUITask.<>f__mg$cacheC7, true);
		string name27 = "m_isOpeningUI";
		if (Lua_BlackJack_ProjectL_UI_LoginUITask.<>f__mg$cacheC8 == null)
		{
			Lua_BlackJack_ProjectL_UI_LoginUITask.<>f__mg$cacheC8 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_LoginUITask.get_m_isOpeningUI);
		}
		LuaCSFunction get27 = Lua_BlackJack_ProjectL_UI_LoginUITask.<>f__mg$cacheC8;
		if (Lua_BlackJack_ProjectL_UI_LoginUITask.<>f__mg$cacheC9 == null)
		{
			Lua_BlackJack_ProjectL_UI_LoginUITask.<>f__mg$cacheC9 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_LoginUITask.set_m_isOpeningUI);
		}
		LuaObject.addMember(l, name27, get27, Lua_BlackJack_ProjectL_UI_LoginUITask.<>f__mg$cacheC9, true);
		string name28 = "m_curLoginAgnetUrl";
		if (Lua_BlackJack_ProjectL_UI_LoginUITask.<>f__mg$cacheCA == null)
		{
			Lua_BlackJack_ProjectL_UI_LoginUITask.<>f__mg$cacheCA = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_LoginUITask.get_m_curLoginAgnetUrl);
		}
		LuaCSFunction get28 = Lua_BlackJack_ProjectL_UI_LoginUITask.<>f__mg$cacheCA;
		if (Lua_BlackJack_ProjectL_UI_LoginUITask.<>f__mg$cacheCB == null)
		{
			Lua_BlackJack_ProjectL_UI_LoginUITask.<>f__mg$cacheCB = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_LoginUITask.set_m_curLoginAgnetUrl);
		}
		LuaObject.addMember(l, name28, get28, Lua_BlackJack_ProjectL_UI_LoginUITask.<>f__mg$cacheCB, true);
		string name29 = "CustomParams";
		if (Lua_BlackJack_ProjectL_UI_LoginUITask.<>f__mg$cacheCC == null)
		{
			Lua_BlackJack_ProjectL_UI_LoginUITask.<>f__mg$cacheCC = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_LoginUITask.get_CustomParams);
		}
		LuaObject.addMember(l, name29, Lua_BlackJack_ProjectL_UI_LoginUITask.<>f__mg$cacheCC, null, false);
		string name30 = "m_messageDuration";
		if (Lua_BlackJack_ProjectL_UI_LoginUITask.<>f__mg$cacheCD == null)
		{
			Lua_BlackJack_ProjectL_UI_LoginUITask.<>f__mg$cacheCD = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_LoginUITask.get_m_messageDuration);
		}
		LuaObject.addMember(l, name30, Lua_BlackJack_ProjectL_UI_LoginUITask.<>f__mg$cacheCD, null, false);
		string name31 = "m_ignoreNetworkErrorOnce";
		if (Lua_BlackJack_ProjectL_UI_LoginUITask.<>f__mg$cacheCE == null)
		{
			Lua_BlackJack_ProjectL_UI_LoginUITask.<>f__mg$cacheCE = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_LoginUITask.get_m_ignoreNetworkErrorOnce);
		}
		LuaCSFunction get29 = Lua_BlackJack_ProjectL_UI_LoginUITask.<>f__mg$cacheCE;
		if (Lua_BlackJack_ProjectL_UI_LoginUITask.<>f__mg$cacheCF == null)
		{
			Lua_BlackJack_ProjectL_UI_LoginUITask.<>f__mg$cacheCF = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_LoginUITask.set_m_ignoreNetworkErrorOnce);
		}
		LuaObject.addMember(l, name31, get29, Lua_BlackJack_ProjectL_UI_LoginUITask.<>f__mg$cacheCF, true);
		string name32 = "m_gmUserIDs";
		if (Lua_BlackJack_ProjectL_UI_LoginUITask.<>f__mg$cacheD0 == null)
		{
			Lua_BlackJack_ProjectL_UI_LoginUITask.<>f__mg$cacheD0 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_LoginUITask.get_m_gmUserIDs);
		}
		LuaCSFunction get30 = Lua_BlackJack_ProjectL_UI_LoginUITask.<>f__mg$cacheD0;
		if (Lua_BlackJack_ProjectL_UI_LoginUITask.<>f__mg$cacheD1 == null)
		{
			Lua_BlackJack_ProjectL_UI_LoginUITask.<>f__mg$cacheD1 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_LoginUITask.set_m_gmUserIDs);
		}
		LuaObject.addMember(l, name32, get30, Lua_BlackJack_ProjectL_UI_LoginUITask.<>f__mg$cacheD1, true);
		string name33 = "m_isGMUser";
		if (Lua_BlackJack_ProjectL_UI_LoginUITask.<>f__mg$cacheD2 == null)
		{
			Lua_BlackJack_ProjectL_UI_LoginUITask.<>f__mg$cacheD2 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_LoginUITask.get_m_isGMUser);
		}
		LuaCSFunction get31 = Lua_BlackJack_ProjectL_UI_LoginUITask.<>f__mg$cacheD2;
		if (Lua_BlackJack_ProjectL_UI_LoginUITask.<>f__mg$cacheD3 == null)
		{
			Lua_BlackJack_ProjectL_UI_LoginUITask.<>f__mg$cacheD3 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_LoginUITask.set_m_isGMUser);
		}
		LuaObject.addMember(l, name33, get31, Lua_BlackJack_ProjectL_UI_LoginUITask.<>f__mg$cacheD3, false);
		string name34 = "m_isGettingSDKPlatformUserID";
		if (Lua_BlackJack_ProjectL_UI_LoginUITask.<>f__mg$cacheD4 == null)
		{
			Lua_BlackJack_ProjectL_UI_LoginUITask.<>f__mg$cacheD4 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_LoginUITask.get_m_isGettingSDKPlatformUserID);
		}
		LuaCSFunction get32 = Lua_BlackJack_ProjectL_UI_LoginUITask.<>f__mg$cacheD4;
		if (Lua_BlackJack_ProjectL_UI_LoginUITask.<>f__mg$cacheD5 == null)
		{
			Lua_BlackJack_ProjectL_UI_LoginUITask.<>f__mg$cacheD5 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_LoginUITask.set_m_isGettingSDKPlatformUserID);
		}
		LuaObject.addMember(l, name34, get32, Lua_BlackJack_ProjectL_UI_LoginUITask.<>f__mg$cacheD5, true);
		string name35 = "m_pdsdkLoginReturnData";
		if (Lua_BlackJack_ProjectL_UI_LoginUITask.<>f__mg$cacheD6 == null)
		{
			Lua_BlackJack_ProjectL_UI_LoginUITask.<>f__mg$cacheD6 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_LoginUITask.get_m_pdsdkLoginReturnData);
		}
		LuaCSFunction get33 = Lua_BlackJack_ProjectL_UI_LoginUITask.<>f__mg$cacheD6;
		if (Lua_BlackJack_ProjectL_UI_LoginUITask.<>f__mg$cacheD7 == null)
		{
			Lua_BlackJack_ProjectL_UI_LoginUITask.<>f__mg$cacheD7 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_LoginUITask.set_m_pdsdkLoginReturnData);
		}
		LuaObject.addMember(l, name35, get33, Lua_BlackJack_ProjectL_UI_LoginUITask.<>f__mg$cacheD7, true);
		string name36 = "m_pdsdkLoginReturnOpcode";
		if (Lua_BlackJack_ProjectL_UI_LoginUITask.<>f__mg$cacheD8 == null)
		{
			Lua_BlackJack_ProjectL_UI_LoginUITask.<>f__mg$cacheD8 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_LoginUITask.get_m_pdsdkLoginReturnOpcode);
		}
		LuaCSFunction get34 = Lua_BlackJack_ProjectL_UI_LoginUITask.<>f__mg$cacheD8;
		if (Lua_BlackJack_ProjectL_UI_LoginUITask.<>f__mg$cacheD9 == null)
		{
			Lua_BlackJack_ProjectL_UI_LoginUITask.<>f__mg$cacheD9 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_LoginUITask.set_m_pdsdkLoginReturnOpcode);
		}
		LuaObject.addMember(l, name36, get34, Lua_BlackJack_ProjectL_UI_LoginUITask.<>f__mg$cacheD9, true);
		string name37 = "m_pdsdkLoginReturnChannelID";
		if (Lua_BlackJack_ProjectL_UI_LoginUITask.<>f__mg$cacheDA == null)
		{
			Lua_BlackJack_ProjectL_UI_LoginUITask.<>f__mg$cacheDA = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_LoginUITask.get_m_pdsdkLoginReturnChannelID);
		}
		LuaCSFunction get35 = Lua_BlackJack_ProjectL_UI_LoginUITask.<>f__mg$cacheDA;
		if (Lua_BlackJack_ProjectL_UI_LoginUITask.<>f__mg$cacheDB == null)
		{
			Lua_BlackJack_ProjectL_UI_LoginUITask.<>f__mg$cacheDB = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_LoginUITask.set_m_pdsdkLoginReturnChannelID);
		}
		LuaObject.addMember(l, name37, get35, Lua_BlackJack_ProjectL_UI_LoginUITask.<>f__mg$cacheDB, true);
		string name38 = "m_pdsdkLoginReturnCustomParams";
		if (Lua_BlackJack_ProjectL_UI_LoginUITask.<>f__mg$cacheDC == null)
		{
			Lua_BlackJack_ProjectL_UI_LoginUITask.<>f__mg$cacheDC = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_LoginUITask.get_m_pdsdkLoginReturnCustomParams);
		}
		LuaCSFunction get36 = Lua_BlackJack_ProjectL_UI_LoginUITask.<>f__mg$cacheDC;
		if (Lua_BlackJack_ProjectL_UI_LoginUITask.<>f__mg$cacheDD == null)
		{
			Lua_BlackJack_ProjectL_UI_LoginUITask.<>f__mg$cacheDD = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_LoginUITask.set_m_pdsdkLoginReturnCustomParams);
		}
		LuaObject.addMember(l, name38, get36, Lua_BlackJack_ProjectL_UI_LoginUITask.<>f__mg$cacheDD, true);
		string name39 = "m_isAutoRelogin";
		if (Lua_BlackJack_ProjectL_UI_LoginUITask.<>f__mg$cacheDE == null)
		{
			Lua_BlackJack_ProjectL_UI_LoginUITask.<>f__mg$cacheDE = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_LoginUITask.get_m_isAutoRelogin);
		}
		LuaCSFunction get37 = Lua_BlackJack_ProjectL_UI_LoginUITask.<>f__mg$cacheDE;
		if (Lua_BlackJack_ProjectL_UI_LoginUITask.<>f__mg$cacheDF == null)
		{
			Lua_BlackJack_ProjectL_UI_LoginUITask.<>f__mg$cacheDF = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_LoginUITask.set_m_isAutoRelogin);
		}
		LuaObject.addMember(l, name39, get37, Lua_BlackJack_ProjectL_UI_LoginUITask.<>f__mg$cacheDF, false);
		string name40 = "m_isReturnToLoginAndSwitchUser";
		if (Lua_BlackJack_ProjectL_UI_LoginUITask.<>f__mg$cacheE0 == null)
		{
			Lua_BlackJack_ProjectL_UI_LoginUITask.<>f__mg$cacheE0 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_LoginUITask.get_m_isReturnToLoginAndSwitchUser);
		}
		LuaCSFunction get38 = Lua_BlackJack_ProjectL_UI_LoginUITask.<>f__mg$cacheE0;
		if (Lua_BlackJack_ProjectL_UI_LoginUITask.<>f__mg$cacheE1 == null)
		{
			Lua_BlackJack_ProjectL_UI_LoginUITask.<>f__mg$cacheE1 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_LoginUITask.set_m_isReturnToLoginAndSwitchUser);
		}
		LuaObject.addMember(l, name40, get38, Lua_BlackJack_ProjectL_UI_LoginUITask.<>f__mg$cacheE1, false);
		string name41 = "m_isReturnToLoginAndOnLoginSuccess";
		if (Lua_BlackJack_ProjectL_UI_LoginUITask.<>f__mg$cacheE2 == null)
		{
			Lua_BlackJack_ProjectL_UI_LoginUITask.<>f__mg$cacheE2 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_LoginUITask.get_m_isReturnToLoginAndOnLoginSuccess);
		}
		LuaCSFunction get39 = Lua_BlackJack_ProjectL_UI_LoginUITask.<>f__mg$cacheE2;
		if (Lua_BlackJack_ProjectL_UI_LoginUITask.<>f__mg$cacheE3 == null)
		{
			Lua_BlackJack_ProjectL_UI_LoginUITask.<>f__mg$cacheE3 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_LoginUITask.set_m_isReturnToLoginAndOnLoginSuccess);
		}
		LuaObject.addMember(l, name41, get39, Lua_BlackJack_ProjectL_UI_LoginUITask.<>f__mg$cacheE3, false);
		string name42 = "m_onSwitchUserSuccessMsg";
		if (Lua_BlackJack_ProjectL_UI_LoginUITask.<>f__mg$cacheE4 == null)
		{
			Lua_BlackJack_ProjectL_UI_LoginUITask.<>f__mg$cacheE4 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_LoginUITask.get_m_onSwitchUserSuccessMsg);
		}
		LuaCSFunction get40 = Lua_BlackJack_ProjectL_UI_LoginUITask.<>f__mg$cacheE4;
		if (Lua_BlackJack_ProjectL_UI_LoginUITask.<>f__mg$cacheE5 == null)
		{
			Lua_BlackJack_ProjectL_UI_LoginUITask.<>f__mg$cacheE5 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_LoginUITask.set_m_onSwitchUserSuccessMsg);
		}
		LuaObject.addMember(l, name42, get40, Lua_BlackJack_ProjectL_UI_LoginUITask.<>f__mg$cacheE5, false);
		string name43 = "m_isNewRole";
		if (Lua_BlackJack_ProjectL_UI_LoginUITask.<>f__mg$cacheE6 == null)
		{
			Lua_BlackJack_ProjectL_UI_LoginUITask.<>f__mg$cacheE6 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_LoginUITask.get_m_isNewRole);
		}
		LuaCSFunction get41 = Lua_BlackJack_ProjectL_UI_LoginUITask.<>f__mg$cacheE6;
		if (Lua_BlackJack_ProjectL_UI_LoginUITask.<>f__mg$cacheE7 == null)
		{
			Lua_BlackJack_ProjectL_UI_LoginUITask.<>f__mg$cacheE7 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_LoginUITask.set_m_isNewRole);
		}
		LuaObject.addMember(l, name43, get41, Lua_BlackJack_ProjectL_UI_LoginUITask.<>f__mg$cacheE7, true);
		string name44 = "m_downloadServerListCoroutine";
		if (Lua_BlackJack_ProjectL_UI_LoginUITask.<>f__mg$cacheE8 == null)
		{
			Lua_BlackJack_ProjectL_UI_LoginUITask.<>f__mg$cacheE8 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_LoginUITask.get_m_downloadServerListCoroutine);
		}
		LuaCSFunction get42 = Lua_BlackJack_ProjectL_UI_LoginUITask.<>f__mg$cacheE8;
		if (Lua_BlackJack_ProjectL_UI_LoginUITask.<>f__mg$cacheE9 == null)
		{
			Lua_BlackJack_ProjectL_UI_LoginUITask.<>f__mg$cacheE9 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_LoginUITask.set_m_downloadServerListCoroutine);
		}
		LuaObject.addMember(l, name44, get42, Lua_BlackJack_ProjectL_UI_LoginUITask.<>f__mg$cacheE9, true);
		string name45 = "m_isClearSessionFailed";
		if (Lua_BlackJack_ProjectL_UI_LoginUITask.<>f__mg$cacheEA == null)
		{
			Lua_BlackJack_ProjectL_UI_LoginUITask.<>f__mg$cacheEA = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_LoginUITask.get_m_isClearSessionFailed);
		}
		LuaCSFunction get43 = Lua_BlackJack_ProjectL_UI_LoginUITask.<>f__mg$cacheEA;
		if (Lua_BlackJack_ProjectL_UI_LoginUITask.<>f__mg$cacheEB == null)
		{
			Lua_BlackJack_ProjectL_UI_LoginUITask.<>f__mg$cacheEB = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_LoginUITask.set_m_isClearSessionFailed);
		}
		LuaObject.addMember(l, name45, get43, Lua_BlackJack_ProjectL_UI_LoginUITask.<>f__mg$cacheEB, true);
		string name46 = "ServerList";
		if (Lua_BlackJack_ProjectL_UI_LoginUITask.<>f__mg$cacheEC == null)
		{
			Lua_BlackJack_ProjectL_UI_LoginUITask.<>f__mg$cacheEC = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_LoginUITask.get_ServerList);
		}
		LuaObject.addMember(l, name46, Lua_BlackJack_ProjectL_UI_LoginUITask.<>f__mg$cacheEC, null, false);
		string name47 = "ShouldUsePDSDK";
		if (Lua_BlackJack_ProjectL_UI_LoginUITask.<>f__mg$cacheED == null)
		{
			Lua_BlackJack_ProjectL_UI_LoginUITask.<>f__mg$cacheED = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_LoginUITask.get_ShouldUsePDSDK);
		}
		LuaObject.addMember(l, name47, Lua_BlackJack_ProjectL_UI_LoginUITask.<>f__mg$cacheED, null, false);
		string name48 = "RecommendServerIndex";
		if (Lua_BlackJack_ProjectL_UI_LoginUITask.<>f__mg$cacheEE == null)
		{
			Lua_BlackJack_ProjectL_UI_LoginUITask.<>f__mg$cacheEE = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_LoginUITask.get_RecommendServerIndex);
		}
		LuaObject.addMember(l, name48, Lua_BlackJack_ProjectL_UI_LoginUITask.<>f__mg$cacheEE, null, false);
		string name49 = "IsGMUser";
		if (Lua_BlackJack_ProjectL_UI_LoginUITask.<>f__mg$cacheEF == null)
		{
			Lua_BlackJack_ProjectL_UI_LoginUITask.<>f__mg$cacheEF = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_LoginUITask.get_IsGMUser);
		}
		LuaObject.addMember(l, name49, Lua_BlackJack_ProjectL_UI_LoginUITask.<>f__mg$cacheEF, null, false);
		string name50 = "PDSDKStartGameJsonString";
		if (Lua_BlackJack_ProjectL_UI_LoginUITask.<>f__mg$cacheF0 == null)
		{
			Lua_BlackJack_ProjectL_UI_LoginUITask.<>f__mg$cacheF0 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_LoginUITask.get_PDSDKStartGameJsonString);
		}
		LuaObject.addMember(l, name50, Lua_BlackJack_ProjectL_UI_LoginUITask.<>f__mg$cacheF0, null, false);
		string name51 = "PDSDKGameRoleJsonString";
		if (Lua_BlackJack_ProjectL_UI_LoginUITask.<>f__mg$cacheF1 == null)
		{
			Lua_BlackJack_ProjectL_UI_LoginUITask.<>f__mg$cacheF1 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_LoginUITask.get_PDSDKGameRoleJsonString);
		}
		LuaObject.addMember(l, name51, Lua_BlackJack_ProjectL_UI_LoginUITask.<>f__mg$cacheF1, null, false);
		string name52 = "SessionTokenCacheFileName";
		if (Lua_BlackJack_ProjectL_UI_LoginUITask.<>f__mg$cacheF2 == null)
		{
			Lua_BlackJack_ProjectL_UI_LoginUITask.<>f__mg$cacheF2 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_LoginUITask.get_SessionTokenCacheFileName);
		}
		LuaObject.addMember(l, name52, Lua_BlackJack_ProjectL_UI_LoginUITask.<>f__mg$cacheF2, null, true);
		string name53 = "SessionAccountInfo";
		if (Lua_BlackJack_ProjectL_UI_LoginUITask.<>f__mg$cacheF3 == null)
		{
			Lua_BlackJack_ProjectL_UI_LoginUITask.<>f__mg$cacheF3 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_LoginUITask.get_SessionAccountInfo);
		}
		LuaObject.addMember(l, name53, Lua_BlackJack_ProjectL_UI_LoginUITask.<>f__mg$cacheF3, null, false);
		string name54 = "FindAInstance";
		if (Lua_BlackJack_ProjectL_UI_LoginUITask.<>f__mg$cacheF4 == null)
		{
			Lua_BlackJack_ProjectL_UI_LoginUITask.<>f__mg$cacheF4 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_LoginUITask.get_FindAInstance);
		}
		LuaObject.addMember(l, name54, Lua_BlackJack_ProjectL_UI_LoginUITask.<>f__mg$cacheF4, null, false);
		string name55 = "LayerDescArray";
		if (Lua_BlackJack_ProjectL_UI_LoginUITask.<>f__mg$cacheF5 == null)
		{
			Lua_BlackJack_ProjectL_UI_LoginUITask.<>f__mg$cacheF5 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_LoginUITask.get_LayerDescArray);
		}
		LuaObject.addMember(l, name55, Lua_BlackJack_ProjectL_UI_LoginUITask.<>f__mg$cacheF5, null, true);
		string name56 = "UICtrlDescArray";
		if (Lua_BlackJack_ProjectL_UI_LoginUITask.<>f__mg$cacheF6 == null)
		{
			Lua_BlackJack_ProjectL_UI_LoginUITask.<>f__mg$cacheF6 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_LoginUITask.get_UICtrlDescArray);
		}
		LuaObject.addMember(l, name56, Lua_BlackJack_ProjectL_UI_LoginUITask.<>f__mg$cacheF6, null, true);
		if (Lua_BlackJack_ProjectL_UI_LoginUITask.<>f__mg$cacheF7 == null)
		{
			Lua_BlackJack_ProjectL_UI_LoginUITask.<>f__mg$cacheF7 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_LoginUITask.constructor);
		}
		LuaObject.createTypeMetatable(l, Lua_BlackJack_ProjectL_UI_LoginUITask.<>f__mg$cacheF7, typeof(LoginUITask), typeof(LoginUITaskBase));
	}

	// Token: 0x04015BE4 RID: 89060
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache0;

	// Token: 0x04015BE5 RID: 89061
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1;

	// Token: 0x04015BE6 RID: 89062
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2;

	// Token: 0x04015BE7 RID: 89063
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3;

	// Token: 0x04015BE8 RID: 89064
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache4;

	// Token: 0x04015BE9 RID: 89065
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache5;

	// Token: 0x04015BEA RID: 89066
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache6;

	// Token: 0x04015BEB RID: 89067
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache7;

	// Token: 0x04015BEC RID: 89068
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache8;

	// Token: 0x04015BED RID: 89069
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache9;

	// Token: 0x04015BEE RID: 89070
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheA;

	// Token: 0x04015BEF RID: 89071
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheB;

	// Token: 0x04015BF0 RID: 89072
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheC;

	// Token: 0x04015BF1 RID: 89073
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheD;

	// Token: 0x04015BF2 RID: 89074
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheE;

	// Token: 0x04015BF3 RID: 89075
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheF;

	// Token: 0x04015BF4 RID: 89076
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache10;

	// Token: 0x04015BF5 RID: 89077
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache11;

	// Token: 0x04015BF6 RID: 89078
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache12;

	// Token: 0x04015BF7 RID: 89079
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache13;

	// Token: 0x04015BF8 RID: 89080
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache14;

	// Token: 0x04015BF9 RID: 89081
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache15;

	// Token: 0x04015BFA RID: 89082
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache16;

	// Token: 0x04015BFB RID: 89083
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache17;

	// Token: 0x04015BFC RID: 89084
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache18;

	// Token: 0x04015BFD RID: 89085
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache19;

	// Token: 0x04015BFE RID: 89086
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1A;

	// Token: 0x04015BFF RID: 89087
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1B;

	// Token: 0x04015C00 RID: 89088
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1C;

	// Token: 0x04015C01 RID: 89089
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1D;

	// Token: 0x04015C02 RID: 89090
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1E;

	// Token: 0x04015C03 RID: 89091
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1F;

	// Token: 0x04015C04 RID: 89092
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache20;

	// Token: 0x04015C05 RID: 89093
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache21;

	// Token: 0x04015C06 RID: 89094
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache22;

	// Token: 0x04015C07 RID: 89095
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache23;

	// Token: 0x04015C08 RID: 89096
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache24;

	// Token: 0x04015C09 RID: 89097
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache25;

	// Token: 0x04015C0A RID: 89098
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache26;

	// Token: 0x04015C0B RID: 89099
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache27;

	// Token: 0x04015C0C RID: 89100
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache28;

	// Token: 0x04015C0D RID: 89101
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache29;

	// Token: 0x04015C0E RID: 89102
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2A;

	// Token: 0x04015C0F RID: 89103
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2B;

	// Token: 0x04015C10 RID: 89104
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2C;

	// Token: 0x04015C11 RID: 89105
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2D;

	// Token: 0x04015C12 RID: 89106
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2E;

	// Token: 0x04015C13 RID: 89107
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2F;

	// Token: 0x04015C14 RID: 89108
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache30;

	// Token: 0x04015C15 RID: 89109
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache31;

	// Token: 0x04015C16 RID: 89110
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache32;

	// Token: 0x04015C17 RID: 89111
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache33;

	// Token: 0x04015C18 RID: 89112
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache34;

	// Token: 0x04015C19 RID: 89113
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache35;

	// Token: 0x04015C1A RID: 89114
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache36;

	// Token: 0x04015C1B RID: 89115
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache37;

	// Token: 0x04015C1C RID: 89116
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache38;

	// Token: 0x04015C1D RID: 89117
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache39;

	// Token: 0x04015C1E RID: 89118
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3A;

	// Token: 0x04015C1F RID: 89119
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3B;

	// Token: 0x04015C20 RID: 89120
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3C;

	// Token: 0x04015C21 RID: 89121
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3D;

	// Token: 0x04015C22 RID: 89122
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3E;

	// Token: 0x04015C23 RID: 89123
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3F;

	// Token: 0x04015C24 RID: 89124
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache40;

	// Token: 0x04015C25 RID: 89125
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache41;

	// Token: 0x04015C26 RID: 89126
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache42;

	// Token: 0x04015C27 RID: 89127
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache43;

	// Token: 0x04015C28 RID: 89128
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache44;

	// Token: 0x04015C29 RID: 89129
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache45;

	// Token: 0x04015C2A RID: 89130
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache46;

	// Token: 0x04015C2B RID: 89131
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache47;

	// Token: 0x04015C2C RID: 89132
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache48;

	// Token: 0x04015C2D RID: 89133
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache49;

	// Token: 0x04015C2E RID: 89134
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache4A;

	// Token: 0x04015C2F RID: 89135
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache4B;

	// Token: 0x04015C30 RID: 89136
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache4C;

	// Token: 0x04015C31 RID: 89137
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache4D;

	// Token: 0x04015C32 RID: 89138
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache4E;

	// Token: 0x04015C33 RID: 89139
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache4F;

	// Token: 0x04015C34 RID: 89140
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache50;

	// Token: 0x04015C35 RID: 89141
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache51;

	// Token: 0x04015C36 RID: 89142
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache52;

	// Token: 0x04015C37 RID: 89143
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache53;

	// Token: 0x04015C38 RID: 89144
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache54;

	// Token: 0x04015C39 RID: 89145
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache55;

	// Token: 0x04015C3A RID: 89146
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache56;

	// Token: 0x04015C3B RID: 89147
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache57;

	// Token: 0x04015C3C RID: 89148
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache58;

	// Token: 0x04015C3D RID: 89149
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache59;

	// Token: 0x04015C3E RID: 89150
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache5A;

	// Token: 0x04015C3F RID: 89151
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache5B;

	// Token: 0x04015C40 RID: 89152
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache5C;

	// Token: 0x04015C41 RID: 89153
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache5D;

	// Token: 0x04015C42 RID: 89154
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache5E;

	// Token: 0x04015C43 RID: 89155
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache5F;

	// Token: 0x04015C44 RID: 89156
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache60;

	// Token: 0x04015C45 RID: 89157
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache61;

	// Token: 0x04015C46 RID: 89158
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache62;

	// Token: 0x04015C47 RID: 89159
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache63;

	// Token: 0x04015C48 RID: 89160
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache64;

	// Token: 0x04015C49 RID: 89161
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache65;

	// Token: 0x04015C4A RID: 89162
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache66;

	// Token: 0x04015C4B RID: 89163
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache67;

	// Token: 0x04015C4C RID: 89164
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache68;

	// Token: 0x04015C4D RID: 89165
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache69;

	// Token: 0x04015C4E RID: 89166
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache6A;

	// Token: 0x04015C4F RID: 89167
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache6B;

	// Token: 0x04015C50 RID: 89168
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache6C;

	// Token: 0x04015C51 RID: 89169
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache6D;

	// Token: 0x04015C52 RID: 89170
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache6E;

	// Token: 0x04015C53 RID: 89171
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache6F;

	// Token: 0x04015C54 RID: 89172
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache70;

	// Token: 0x04015C55 RID: 89173
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache71;

	// Token: 0x04015C56 RID: 89174
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache72;

	// Token: 0x04015C57 RID: 89175
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache73;

	// Token: 0x04015C58 RID: 89176
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache74;

	// Token: 0x04015C59 RID: 89177
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache75;

	// Token: 0x04015C5A RID: 89178
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache76;

	// Token: 0x04015C5B RID: 89179
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache77;

	// Token: 0x04015C5C RID: 89180
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache78;

	// Token: 0x04015C5D RID: 89181
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache79;

	// Token: 0x04015C5E RID: 89182
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache7A;

	// Token: 0x04015C5F RID: 89183
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache7B;

	// Token: 0x04015C60 RID: 89184
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache7C;

	// Token: 0x04015C61 RID: 89185
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache7D;

	// Token: 0x04015C62 RID: 89186
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache7E;

	// Token: 0x04015C63 RID: 89187
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache7F;

	// Token: 0x04015C64 RID: 89188
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache80;

	// Token: 0x04015C65 RID: 89189
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache81;

	// Token: 0x04015C66 RID: 89190
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache82;

	// Token: 0x04015C67 RID: 89191
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache83;

	// Token: 0x04015C68 RID: 89192
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache84;

	// Token: 0x04015C69 RID: 89193
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache85;

	// Token: 0x04015C6A RID: 89194
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache86;

	// Token: 0x04015C6B RID: 89195
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache87;

	// Token: 0x04015C6C RID: 89196
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache88;

	// Token: 0x04015C6D RID: 89197
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache89;

	// Token: 0x04015C6E RID: 89198
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache8A;

	// Token: 0x04015C6F RID: 89199
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache8B;

	// Token: 0x04015C70 RID: 89200
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache8C;

	// Token: 0x04015C71 RID: 89201
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache8D;

	// Token: 0x04015C72 RID: 89202
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache8E;

	// Token: 0x04015C73 RID: 89203
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache8F;

	// Token: 0x04015C74 RID: 89204
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache90;

	// Token: 0x04015C75 RID: 89205
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache91;

	// Token: 0x04015C76 RID: 89206
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache92;

	// Token: 0x04015C77 RID: 89207
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache93;

	// Token: 0x04015C78 RID: 89208
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache94;

	// Token: 0x04015C79 RID: 89209
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache95;

	// Token: 0x04015C7A RID: 89210
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache96;

	// Token: 0x04015C7B RID: 89211
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache97;

	// Token: 0x04015C7C RID: 89212
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache98;

	// Token: 0x04015C7D RID: 89213
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache99;

	// Token: 0x04015C7E RID: 89214
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache9A;

	// Token: 0x04015C7F RID: 89215
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache9B;

	// Token: 0x04015C80 RID: 89216
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache9C;

	// Token: 0x04015C81 RID: 89217
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache9D;

	// Token: 0x04015C82 RID: 89218
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache9E;

	// Token: 0x04015C83 RID: 89219
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache9F;

	// Token: 0x04015C84 RID: 89220
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheA0;

	// Token: 0x04015C85 RID: 89221
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheA1;

	// Token: 0x04015C86 RID: 89222
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheA2;

	// Token: 0x04015C87 RID: 89223
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheA3;

	// Token: 0x04015C88 RID: 89224
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheA4;

	// Token: 0x04015C89 RID: 89225
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheA5;

	// Token: 0x04015C8A RID: 89226
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheA6;

	// Token: 0x04015C8B RID: 89227
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheA7;

	// Token: 0x04015C8C RID: 89228
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheA8;

	// Token: 0x04015C8D RID: 89229
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheA9;

	// Token: 0x04015C8E RID: 89230
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheAA;

	// Token: 0x04015C8F RID: 89231
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheAB;

	// Token: 0x04015C90 RID: 89232
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheAC;

	// Token: 0x04015C91 RID: 89233
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheAD;

	// Token: 0x04015C92 RID: 89234
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheAE;

	// Token: 0x04015C93 RID: 89235
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheAF;

	// Token: 0x04015C94 RID: 89236
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheB0;

	// Token: 0x04015C95 RID: 89237
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheB1;

	// Token: 0x04015C96 RID: 89238
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheB2;

	// Token: 0x04015C97 RID: 89239
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheB3;

	// Token: 0x04015C98 RID: 89240
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheB4;

	// Token: 0x04015C99 RID: 89241
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheB5;

	// Token: 0x04015C9A RID: 89242
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheB6;

	// Token: 0x04015C9B RID: 89243
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheB7;

	// Token: 0x04015C9C RID: 89244
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheB8;

	// Token: 0x04015C9D RID: 89245
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheB9;

	// Token: 0x04015C9E RID: 89246
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheBA;

	// Token: 0x04015C9F RID: 89247
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheBB;

	// Token: 0x04015CA0 RID: 89248
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheBC;

	// Token: 0x04015CA1 RID: 89249
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheBD;

	// Token: 0x04015CA2 RID: 89250
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheBE;

	// Token: 0x04015CA3 RID: 89251
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheBF;

	// Token: 0x04015CA4 RID: 89252
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheC0;

	// Token: 0x04015CA5 RID: 89253
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheC1;

	// Token: 0x04015CA6 RID: 89254
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheC2;

	// Token: 0x04015CA7 RID: 89255
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheC3;

	// Token: 0x04015CA8 RID: 89256
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheC4;

	// Token: 0x04015CA9 RID: 89257
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheC5;

	// Token: 0x04015CAA RID: 89258
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheC6;

	// Token: 0x04015CAB RID: 89259
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheC7;

	// Token: 0x04015CAC RID: 89260
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheC8;

	// Token: 0x04015CAD RID: 89261
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheC9;

	// Token: 0x04015CAE RID: 89262
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheCA;

	// Token: 0x04015CAF RID: 89263
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheCB;

	// Token: 0x04015CB0 RID: 89264
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheCC;

	// Token: 0x04015CB1 RID: 89265
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheCD;

	// Token: 0x04015CB2 RID: 89266
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheCE;

	// Token: 0x04015CB3 RID: 89267
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheCF;

	// Token: 0x04015CB4 RID: 89268
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheD0;

	// Token: 0x04015CB5 RID: 89269
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheD1;

	// Token: 0x04015CB6 RID: 89270
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheD2;

	// Token: 0x04015CB7 RID: 89271
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheD3;

	// Token: 0x04015CB8 RID: 89272
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheD4;

	// Token: 0x04015CB9 RID: 89273
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheD5;

	// Token: 0x04015CBA RID: 89274
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheD6;

	// Token: 0x04015CBB RID: 89275
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheD7;

	// Token: 0x04015CBC RID: 89276
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheD8;

	// Token: 0x04015CBD RID: 89277
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheD9;

	// Token: 0x04015CBE RID: 89278
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheDA;

	// Token: 0x04015CBF RID: 89279
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheDB;

	// Token: 0x04015CC0 RID: 89280
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheDC;

	// Token: 0x04015CC1 RID: 89281
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheDD;

	// Token: 0x04015CC2 RID: 89282
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheDE;

	// Token: 0x04015CC3 RID: 89283
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheDF;

	// Token: 0x04015CC4 RID: 89284
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheE0;

	// Token: 0x04015CC5 RID: 89285
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheE1;

	// Token: 0x04015CC6 RID: 89286
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheE2;

	// Token: 0x04015CC7 RID: 89287
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheE3;

	// Token: 0x04015CC8 RID: 89288
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheE4;

	// Token: 0x04015CC9 RID: 89289
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheE5;

	// Token: 0x04015CCA RID: 89290
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheE6;

	// Token: 0x04015CCB RID: 89291
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheE7;

	// Token: 0x04015CCC RID: 89292
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheE8;

	// Token: 0x04015CCD RID: 89293
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheE9;

	// Token: 0x04015CCE RID: 89294
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheEA;

	// Token: 0x04015CCF RID: 89295
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheEB;

	// Token: 0x04015CD0 RID: 89296
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheEC;

	// Token: 0x04015CD1 RID: 89297
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheED;

	// Token: 0x04015CD2 RID: 89298
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheEE;

	// Token: 0x04015CD3 RID: 89299
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheEF;

	// Token: 0x04015CD4 RID: 89300
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheF0;

	// Token: 0x04015CD5 RID: 89301
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheF1;

	// Token: 0x04015CD6 RID: 89302
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheF2;

	// Token: 0x04015CD7 RID: 89303
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheF3;

	// Token: 0x04015CD8 RID: 89304
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheF4;

	// Token: 0x04015CD9 RID: 89305
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheF5;

	// Token: 0x04015CDA RID: 89306
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheF6;

	// Token: 0x04015CDB RID: 89307
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheF7;
}
