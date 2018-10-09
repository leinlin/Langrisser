using System;
using System.Runtime.CompilerServices;
using BlackJack.BJFramework.Runtime.TaskNs;
using BlackJack.BJFramework.Runtime.UI;
using SLua;
using UnityEngine.Scripting;

// Token: 0x02001123 RID: 4387
[Preserve]
public class Lua_BlackJack_BJFramework_Runtime_TaskNs_NetWorkTransactionTask : LuaObject
{
	// Token: 0x06015CCD RID: 89293 RVA: 0x005A0310 File Offset: 0x0059E510
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int constructor(IntPtr l)
	{
		int result;
		try
		{
			float timeout;
			LuaObject.checkType(l, 2, out timeout);
			UITaskBase blockedUITask;
			LuaObject.checkType<UITaskBase>(l, 3, out blockedUITask);
			bool autoRetry;
			LuaObject.checkType(l, 4, out autoRetry);
			NetWorkTransactionTask o = new NetWorkTransactionTask(timeout, blockedUITask, autoRetry);
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

	// Token: 0x06015CCE RID: 89294 RVA: 0x005A0380 File Offset: 0x0059E580
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int OnStart(IntPtr l)
	{
		int result;
		try
		{
			NetWorkTransactionTask netWorkTransactionTask = (NetWorkTransactionTask)LuaObject.checkSelf(l);
			object param;
			LuaObject.checkType<object>(l, 2, out param);
			bool b = netWorkTransactionTask.m_luaExportHelper.OnStart(param);
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

	// Token: 0x06015CCF RID: 89295 RVA: 0x005A03E8 File Offset: 0x0059E5E8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int OnStop(IntPtr l)
	{
		int result;
		try
		{
			NetWorkTransactionTask netWorkTransactionTask = (NetWorkTransactionTask)LuaObject.checkSelf(l);
			netWorkTransactionTask.m_luaExportHelper.OnStop();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06015CD0 RID: 89296 RVA: 0x005A043C File Offset: 0x0059E63C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int OnPause(IntPtr l)
	{
		int result;
		try
		{
			NetWorkTransactionTask netWorkTransactionTask = (NetWorkTransactionTask)LuaObject.checkSelf(l);
			netWorkTransactionTask.m_luaExportHelper.OnPause();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06015CD1 RID: 89297 RVA: 0x005A0490 File Offset: 0x0059E690
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int OnResume(IntPtr l)
	{
		int result;
		try
		{
			NetWorkTransactionTask netWorkTransactionTask = (NetWorkTransactionTask)LuaObject.checkSelf(l);
			object param;
			LuaObject.checkType<object>(l, 2, out param);
			bool b = netWorkTransactionTask.m_luaExportHelper.OnResume(param);
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

	// Token: 0x06015CD2 RID: 89298 RVA: 0x005A04F8 File Offset: 0x0059E6F8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int StartNetWorking(IntPtr l)
	{
		int result;
		try
		{
			NetWorkTransactionTask netWorkTransactionTask = (NetWorkTransactionTask)LuaObject.checkSelf(l);
			bool b = netWorkTransactionTask.m_luaExportHelper.StartNetWorking();
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

	// Token: 0x06015CD3 RID: 89299 RVA: 0x005A0554 File Offset: 0x0059E754
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int OnTransactionComplete(IntPtr l)
	{
		int result;
		try
		{
			NetWorkTransactionTask netWorkTransactionTask = (NetWorkTransactionTask)LuaObject.checkSelf(l);
			netWorkTransactionTask.m_luaExportHelper.OnTransactionComplete();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06015CD4 RID: 89300 RVA: 0x005A05A8 File Offset: 0x0059E7A8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int RegisterNetworkEvent(IntPtr l)
	{
		int result;
		try
		{
			NetWorkTransactionTask netWorkTransactionTask = (NetWorkTransactionTask)LuaObject.checkSelf(l);
			netWorkTransactionTask.m_luaExportHelper.RegisterNetworkEvent();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06015CD5 RID: 89301 RVA: 0x005A05FC File Offset: 0x0059E7FC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int UnregisterNetworkEvent(IntPtr l)
	{
		int result;
		try
		{
			NetWorkTransactionTask netWorkTransactionTask = (NetWorkTransactionTask)LuaObject.checkSelf(l);
			netWorkTransactionTask.m_luaExportHelper.UnregisterNetworkEvent();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06015CD6 RID: 89302 RVA: 0x005A0650 File Offset: 0x0059E850
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int OnTick(IntPtr l)
	{
		int result;
		try
		{
			NetWorkTransactionTask netWorkTransactionTask = (NetWorkTransactionTask)LuaObject.checkSelf(l);
			netWorkTransactionTask.m_luaExportHelper.OnTick();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06015CD7 RID: 89303 RVA: 0x005A06A4 File Offset: 0x0059E8A4
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int OnTimeOut(IntPtr l)
	{
		int result;
		try
		{
			NetWorkTransactionTask netWorkTransactionTask = (NetWorkTransactionTask)LuaObject.checkSelf(l);
			netWorkTransactionTask.m_luaExportHelper.OnTimeOut();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06015CD8 RID: 89304 RVA: 0x005A06F8 File Offset: 0x0059E8F8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int OnGameServerDataUnsyncNotify(IntPtr l)
	{
		int result;
		try
		{
			NetWorkTransactionTask netWorkTransactionTask = (NetWorkTransactionTask)LuaObject.checkSelf(l);
			netWorkTransactionTask.m_luaExportHelper.OnGameServerDataUnsyncNotify();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06015CD9 RID: 89305 RVA: 0x005A074C File Offset: 0x0059E94C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int OnGameServerNetworkError(IntPtr l)
	{
		int result;
		try
		{
			NetWorkTransactionTask netWorkTransactionTask = (NetWorkTransactionTask)LuaObject.checkSelf(l);
			netWorkTransactionTask.m_luaExportHelper.OnGameServerNetworkError();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06015CDA RID: 89306 RVA: 0x005A07A0 File Offset: 0x0059E9A0
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int OnGameServerDisconnected(IntPtr l)
	{
		int result;
		try
		{
			NetWorkTransactionTask netWorkTransactionTask = (NetWorkTransactionTask)LuaObject.checkSelf(l);
			netWorkTransactionTask.m_luaExportHelper.OnGameServerDisconnected();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06015CDB RID: 89307 RVA: 0x005A07F4 File Offset: 0x0059E9F4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int OnNetworkError(IntPtr l)
	{
		int result;
		try
		{
			NetWorkTransactionTask netWorkTransactionTask = (NetWorkTransactionTask)LuaObject.checkSelf(l);
			netWorkTransactionTask.m_luaExportHelper.OnNetworkError();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06015CDC RID: 89308 RVA: 0x005A0848 File Offset: 0x0059EA48
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int OnReLoginSuccess(IntPtr l)
	{
		int result;
		try
		{
			NetWorkTransactionTask netWorkTransactionTask = (NetWorkTransactionTask)LuaObject.checkSelf(l);
			netWorkTransactionTask.m_luaExportHelper.OnReLoginSuccess();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06015CDD RID: 89309 RVA: 0x005A089C File Offset: 0x0059EA9C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int OnUIManagerReturnToLoginUI(IntPtr l)
	{
		int result;
		try
		{
			NetWorkTransactionTask netWorkTransactionTask = (NetWorkTransactionTask)LuaObject.checkSelf(l);
			bool obj;
			LuaObject.checkType(l, 2, out obj);
			netWorkTransactionTask.m_luaExportHelper.OnUIManagerReturnToLoginUI(obj);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06015CDE RID: 89310 RVA: 0x005A08F8 File Offset: 0x0059EAF8
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int __callBase_Start(IntPtr l)
	{
		int result;
		try
		{
			NetWorkTransactionTask netWorkTransactionTask = (NetWorkTransactionTask)LuaObject.checkSelf(l);
			object param;
			LuaObject.checkType<object>(l, 2, out param);
			bool b = netWorkTransactionTask.m_luaExportHelper.__callBase_Start(param);
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

	// Token: 0x06015CDF RID: 89311 RVA: 0x005A0960 File Offset: 0x0059EB60
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_Stop(IntPtr l)
	{
		int result;
		try
		{
			NetWorkTransactionTask netWorkTransactionTask = (NetWorkTransactionTask)LuaObject.checkSelf(l);
			netWorkTransactionTask.m_luaExportHelper.__callBase_Stop();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06015CE0 RID: 89312 RVA: 0x005A09B4 File Offset: 0x0059EBB4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_Pause(IntPtr l)
	{
		int result;
		try
		{
			NetWorkTransactionTask netWorkTransactionTask = (NetWorkTransactionTask)LuaObject.checkSelf(l);
			netWorkTransactionTask.m_luaExportHelper.__callBase_Pause();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06015CE1 RID: 89313 RVA: 0x005A0A08 File Offset: 0x0059EC08
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_Resume(IntPtr l)
	{
		int result;
		try
		{
			NetWorkTransactionTask netWorkTransactionTask = (NetWorkTransactionTask)LuaObject.checkSelf(l);
			object param;
			LuaObject.checkType<object>(l, 2, out param);
			bool b = netWorkTransactionTask.m_luaExportHelper.__callBase_Resume(param);
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

	// Token: 0x06015CE2 RID: 89314 RVA: 0x005A0A70 File Offset: 0x0059EC70
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_ClearOnStopEvent(IntPtr l)
	{
		int result;
		try
		{
			NetWorkTransactionTask netWorkTransactionTask = (NetWorkTransactionTask)LuaObject.checkSelf(l);
			netWorkTransactionTask.m_luaExportHelper.__callBase_ClearOnStopEvent();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06015CE3 RID: 89315 RVA: 0x005A0AC4 File Offset: 0x0059ECC4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_ExecAfterTicks(IntPtr l)
	{
		int result;
		try
		{
			NetWorkTransactionTask netWorkTransactionTask = (NetWorkTransactionTask)LuaObject.checkSelf(l);
			Action action;
			LuaObject.checkDelegate<Action>(l, 2, out action);
			ulong delayTickCount;
			LuaObject.checkType(l, 3, out delayTickCount);
			netWorkTransactionTask.m_luaExportHelper.__callBase_ExecAfterTicks(action, delayTickCount);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06015CE4 RID: 89316 RVA: 0x005A0B30 File Offset: 0x0059ED30
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_OnStart(IntPtr l)
	{
		int result;
		try
		{
			NetWorkTransactionTask netWorkTransactionTask = (NetWorkTransactionTask)LuaObject.checkSelf(l);
			object param;
			LuaObject.checkType<object>(l, 2, out param);
			bool b = netWorkTransactionTask.m_luaExportHelper.__callBase_OnStart(param);
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

	// Token: 0x06015CE5 RID: 89317 RVA: 0x005A0B98 File Offset: 0x0059ED98
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_OnPause(IntPtr l)
	{
		int result;
		try
		{
			NetWorkTransactionTask netWorkTransactionTask = (NetWorkTransactionTask)LuaObject.checkSelf(l);
			netWorkTransactionTask.m_luaExportHelper.__callBase_OnPause();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06015CE6 RID: 89318 RVA: 0x005A0BEC File Offset: 0x0059EDEC
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int __callBase_OnResume(IntPtr l)
	{
		int result;
		try
		{
			NetWorkTransactionTask netWorkTransactionTask = (NetWorkTransactionTask)LuaObject.checkSelf(l);
			object param;
			LuaObject.checkType<object>(l, 2, out param);
			bool b = netWorkTransactionTask.m_luaExportHelper.__callBase_OnResume(param);
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

	// Token: 0x06015CE7 RID: 89319 RVA: 0x005A0C54 File Offset: 0x0059EE54
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_OnStop(IntPtr l)
	{
		int result;
		try
		{
			NetWorkTransactionTask netWorkTransactionTask = (NetWorkTransactionTask)LuaObject.checkSelf(l);
			netWorkTransactionTask.m_luaExportHelper.__callBase_OnStop();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06015CE8 RID: 89320 RVA: 0x005A0CA8 File Offset: 0x0059EEA8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_OnTick(IntPtr l)
	{
		int result;
		try
		{
			NetWorkTransactionTask netWorkTransactionTask = (NetWorkTransactionTask)LuaObject.checkSelf(l);
			netWorkTransactionTask.m_luaExportHelper.__callBase_OnTick();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06015CE9 RID: 89321 RVA: 0x005A0CFC File Offset: 0x0059EEFC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_ToString(IntPtr l)
	{
		int result;
		try
		{
			NetWorkTransactionTask netWorkTransactionTask = (NetWorkTransactionTask)LuaObject.checkSelf(l);
			string s = netWorkTransactionTask.m_luaExportHelper.__callBase_ToString();
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

	// Token: 0x06015CEA RID: 89322 RVA: 0x005A0D58 File Offset: 0x0059EF58
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int __callDele_EventShowUIWaiting_s(IntPtr l)
	{
		int result;
		try
		{
			bool obj;
			LuaObject.checkType(l, 1, out obj);
			NetWorkTransactionTask.LuaExportHelper.__callDele_EventShowUIWaiting(obj);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06015CEB RID: 89323 RVA: 0x005A0DA4 File Offset: 0x0059EFA4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __clearDele_EventShowUIWaiting_s(IntPtr l)
	{
		int result;
		try
		{
			bool obj;
			LuaObject.checkType(l, 1, out obj);
			NetWorkTransactionTask.LuaExportHelper.__clearDele_EventShowUIWaiting(obj);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06015CEC RID: 89324 RVA: 0x005A0DF0 File Offset: 0x0059EFF0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callDele_EventReturnToLoginUI_s(IntPtr l)
	{
		int result;
		try
		{
			bool obj;
			LuaObject.checkType(l, 1, out obj);
			NetWorkTransactionTask.LuaExportHelper.__callDele_EventReturnToLoginUI(obj);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06015CED RID: 89325 RVA: 0x005A0E3C File Offset: 0x0059F03C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __clearDele_EventReturnToLoginUI_s(IntPtr l)
	{
		int result;
		try
		{
			bool obj;
			LuaObject.checkType(l, 1, out obj);
			NetWorkTransactionTask.LuaExportHelper.__clearDele_EventReturnToLoginUI(obj);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06015CEE RID: 89326 RVA: 0x005A0E88 File Offset: 0x0059F088
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callDele_EventReLoginBySession_s(IntPtr l)
	{
		int result;
		try
		{
			Action obj;
			LuaObject.checkDelegate<Action>(l, 1, out obj);
			NetWorkTransactionTask.LuaExportHelper.__callDele_EventReLoginBySession(obj);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06015CEF RID: 89327 RVA: 0x005A0ED4 File Offset: 0x0059F0D4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __clearDele_EventReLoginBySession_s(IntPtr l)
	{
		int result;
		try
		{
			Action obj;
			LuaObject.checkDelegate<Action>(l, 1, out obj);
			NetWorkTransactionTask.LuaExportHelper.__clearDele_EventReLoginBySession(obj);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06015CF0 RID: 89328 RVA: 0x005A0F20 File Offset: 0x0059F120
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_blockedUITask(IntPtr l)
	{
		int result;
		try
		{
			NetWorkTransactionTask netWorkTransactionTask = (NetWorkTransactionTask)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, netWorkTransactionTask.m_luaExportHelper.m_blockedUITask);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06015CF1 RID: 89329 RVA: 0x005A0F78 File Offset: 0x0059F178
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_blockedUITask(IntPtr l)
	{
		int result;
		try
		{
			NetWorkTransactionTask netWorkTransactionTask = (NetWorkTransactionTask)LuaObject.checkSelf(l);
			UITaskBase blockedUITask;
			LuaObject.checkType<UITaskBase>(l, 2, out blockedUITask);
			netWorkTransactionTask.m_luaExportHelper.m_blockedUITask = blockedUITask;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06015CF2 RID: 89330 RVA: 0x005A0FD4 File Offset: 0x0059F1D4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_autoRetry(IntPtr l)
	{
		int result;
		try
		{
			NetWorkTransactionTask netWorkTransactionTask = (NetWorkTransactionTask)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, netWorkTransactionTask.m_luaExportHelper.m_autoRetry);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06015CF3 RID: 89331 RVA: 0x005A102C File Offset: 0x0059F22C
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_m_autoRetry(IntPtr l)
	{
		int result;
		try
		{
			NetWorkTransactionTask netWorkTransactionTask = (NetWorkTransactionTask)LuaObject.checkSelf(l);
			bool autoRetry;
			LuaObject.checkType(l, 2, out autoRetry);
			netWorkTransactionTask.m_luaExportHelper.m_autoRetry = autoRetry;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06015CF4 RID: 89332 RVA: 0x005A1088 File Offset: 0x0059F288
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_timeout(IntPtr l)
	{
		int result;
		try
		{
			NetWorkTransactionTask netWorkTransactionTask = (NetWorkTransactionTask)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, netWorkTransactionTask.m_luaExportHelper.m_timeout);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06015CF5 RID: 89333 RVA: 0x005A10E0 File Offset: 0x0059F2E0
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_m_timeout(IntPtr l)
	{
		int result;
		try
		{
			NetWorkTransactionTask netWorkTransactionTask = (NetWorkTransactionTask)LuaObject.checkSelf(l);
			float timeout;
			LuaObject.checkType(l, 2, out timeout);
			netWorkTransactionTask.m_luaExportHelper.m_timeout = timeout;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06015CF6 RID: 89334 RVA: 0x005A113C File Offset: 0x0059F33C
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_m_isTimeOuted(IntPtr l)
	{
		int result;
		try
		{
			NetWorkTransactionTask netWorkTransactionTask = (NetWorkTransactionTask)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, netWorkTransactionTask.m_luaExportHelper.m_isTimeOuted);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06015CF7 RID: 89335 RVA: 0x005A1194 File Offset: 0x0059F394
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_m_isTimeOuted(IntPtr l)
	{
		int result;
		try
		{
			NetWorkTransactionTask netWorkTransactionTask = (NetWorkTransactionTask)LuaObject.checkSelf(l);
			bool isTimeOuted;
			LuaObject.checkType(l, 2, out isTimeOuted);
			netWorkTransactionTask.m_luaExportHelper.m_isTimeOuted = isTimeOuted;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06015CF8 RID: 89336 RVA: 0x005A11F0 File Offset: 0x0059F3F0
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_m_timeoutTime(IntPtr l)
	{
		int result;
		try
		{
			NetWorkTransactionTask netWorkTransactionTask = (NetWorkTransactionTask)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, netWorkTransactionTask.m_luaExportHelper.m_timeoutTime);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06015CF9 RID: 89337 RVA: 0x005A124C File Offset: 0x0059F44C
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_m_timeoutTime(IntPtr l)
	{
		int result;
		try
		{
			NetWorkTransactionTask netWorkTransactionTask = (NetWorkTransactionTask)LuaObject.checkSelf(l);
			DateTime? timeoutTime;
			LuaObject.checkNullable<DateTime>(l, 2, out timeoutTime);
			netWorkTransactionTask.m_luaExportHelper.m_timeoutTime = timeoutTime;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06015CFA RID: 89338 RVA: 0x005A12A8 File Offset: 0x0059F4A8
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_m_showWaitingUITime(IntPtr l)
	{
		int result;
		try
		{
			NetWorkTransactionTask netWorkTransactionTask = (NetWorkTransactionTask)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, netWorkTransactionTask.m_luaExportHelper.m_showWaitingUITime);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06015CFB RID: 89339 RVA: 0x005A1304 File Offset: 0x0059F504
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_showWaitingUITime(IntPtr l)
	{
		int result;
		try
		{
			NetWorkTransactionTask netWorkTransactionTask = (NetWorkTransactionTask)LuaObject.checkSelf(l);
			DateTime showWaitingUITime;
			LuaObject.checkValueType<DateTime>(l, 2, out showWaitingUITime);
			netWorkTransactionTask.m_luaExportHelper.m_showWaitingUITime = showWaitingUITime;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06015CFC RID: 89340 RVA: 0x005A1360 File Offset: 0x0059F560
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_isUIWaitingShown(IntPtr l)
	{
		int result;
		try
		{
			NetWorkTransactionTask netWorkTransactionTask = (NetWorkTransactionTask)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, netWorkTransactionTask.m_luaExportHelper.m_isUIWaitingShown);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06015CFD RID: 89341 RVA: 0x005A13B8 File Offset: 0x0059F5B8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_isUIWaitingShown(IntPtr l)
	{
		int result;
		try
		{
			NetWorkTransactionTask netWorkTransactionTask = (NetWorkTransactionTask)LuaObject.checkSelf(l);
			bool isUIWaitingShown;
			LuaObject.checkType(l, 2, out isUIWaitingShown);
			netWorkTransactionTask.m_luaExportHelper.m_isUIWaitingShown = isUIWaitingShown;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06015CFE RID: 89342 RVA: 0x005A1414 File Offset: 0x0059F614
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_m_isReturnToLoginByDirtyData(IntPtr l)
	{
		int result;
		try
		{
			NetWorkTransactionTask netWorkTransactionTask = (NetWorkTransactionTask)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, netWorkTransactionTask.m_luaExportHelper.m_isReturnToLoginByDirtyData);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06015CFF RID: 89343 RVA: 0x005A146C File Offset: 0x0059F66C
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_m_isReturnToLoginByDirtyData(IntPtr l)
	{
		int result;
		try
		{
			NetWorkTransactionTask netWorkTransactionTask = (NetWorkTransactionTask)LuaObject.checkSelf(l);
			bool isReturnToLoginByDirtyData;
			LuaObject.checkType(l, 2, out isReturnToLoginByDirtyData);
			netWorkTransactionTask.m_luaExportHelper.m_isReturnToLoginByDirtyData = isReturnToLoginByDirtyData;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06015D00 RID: 89344 RVA: 0x005A14C8 File Offset: 0x0059F6C8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_isLaunchedReloginUITask(IntPtr l)
	{
		int result;
		try
		{
			NetWorkTransactionTask netWorkTransactionTask = (NetWorkTransactionTask)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, netWorkTransactionTask.m_luaExportHelper.m_isLaunchedReloginUITask);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06015D01 RID: 89345 RVA: 0x005A1520 File Offset: 0x0059F720
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_m_isLaunchedReloginUITask(IntPtr l)
	{
		int result;
		try
		{
			NetWorkTransactionTask netWorkTransactionTask = (NetWorkTransactionTask)LuaObject.checkSelf(l);
			bool isLaunchedReloginUITask;
			LuaObject.checkType(l, 2, out isLaunchedReloginUITask);
			netWorkTransactionTask.m_luaExportHelper.m_isLaunchedReloginUITask = isLaunchedReloginUITask;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06015D02 RID: 89346 RVA: 0x005A157C File Offset: 0x0059F77C
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_m_delayTimeForUIWaiting(IntPtr l)
	{
		int result;
		try
		{
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, NetWorkTransactionTask.m_delayTimeForUIWaiting);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06015D03 RID: 89347 RVA: 0x005A15C4 File Offset: 0x0059F7C4
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_m_delayTimeForUIWaiting(IntPtr l)
	{
		int result;
		try
		{
			int delayTimeForUIWaiting;
			LuaObject.checkType(l, 2, out delayTimeForUIWaiting);
			NetWorkTransactionTask.m_delayTimeForUIWaiting = delayTimeForUIWaiting;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06015D04 RID: 89348 RVA: 0x005A1610 File Offset: 0x0059F810
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_TimeOutForEditor(IntPtr l)
	{
		int result;
		try
		{
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, 60f);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06015D05 RID: 89349 RVA: 0x005A1658 File Offset: 0x0059F858
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_EventShowUIWaiting(IntPtr l)
	{
		int result;
		try
		{
			Action<bool> value;
			int num = LuaObject.checkDelegate<Action<bool>>(l, 2, out value);
			if (num != 0)
			{
				if (num == 1)
				{
					NetWorkTransactionTask.EventShowUIWaiting += value;
				}
				else if (num == 2)
				{
					NetWorkTransactionTask.EventShowUIWaiting -= value;
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

	// Token: 0x06015D06 RID: 89350 RVA: 0x005A16C8 File Offset: 0x0059F8C8
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_EventReturnToLoginUI(IntPtr l)
	{
		int result;
		try
		{
			Action<bool> value;
			int num = LuaObject.checkDelegate<Action<bool>>(l, 2, out value);
			if (num != 0)
			{
				if (num == 1)
				{
					NetWorkTransactionTask.EventReturnToLoginUI += value;
				}
				else if (num == 2)
				{
					NetWorkTransactionTask.EventReturnToLoginUI -= value;
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

	// Token: 0x06015D07 RID: 89351 RVA: 0x005A1738 File Offset: 0x0059F938
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_EventReLoginBySession(IntPtr l)
	{
		int result;
		try
		{
			Action<Action> value;
			int num = LuaObject.checkDelegate<Action<Action>>(l, 2, out value);
			if (num != 0)
			{
				if (num == 1)
				{
					NetWorkTransactionTask.EventReLoginBySession += value;
				}
				else if (num == 2)
				{
					NetWorkTransactionTask.EventReLoginBySession -= value;
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

	// Token: 0x06015D08 RID: 89352 RVA: 0x005A17A8 File Offset: 0x0059F9A8
	[Preserve]
	public static void reg(IntPtr l)
	{
		LuaObject.getTypeTable(l, "BlackJack.BJFramework.Runtime.TaskNs.NetWorkTransactionTask");
		if (Lua_BlackJack_BJFramework_Runtime_TaskNs_NetWorkTransactionTask.<>f__mg$cache0 == null)
		{
			Lua_BlackJack_BJFramework_Runtime_TaskNs_NetWorkTransactionTask.<>f__mg$cache0 = new LuaCSFunction(Lua_BlackJack_BJFramework_Runtime_TaskNs_NetWorkTransactionTask.OnStart);
		}
		LuaObject.addMember(l, Lua_BlackJack_BJFramework_Runtime_TaskNs_NetWorkTransactionTask.<>f__mg$cache0);
		if (Lua_BlackJack_BJFramework_Runtime_TaskNs_NetWorkTransactionTask.<>f__mg$cache1 == null)
		{
			Lua_BlackJack_BJFramework_Runtime_TaskNs_NetWorkTransactionTask.<>f__mg$cache1 = new LuaCSFunction(Lua_BlackJack_BJFramework_Runtime_TaskNs_NetWorkTransactionTask.OnStop);
		}
		LuaObject.addMember(l, Lua_BlackJack_BJFramework_Runtime_TaskNs_NetWorkTransactionTask.<>f__mg$cache1);
		if (Lua_BlackJack_BJFramework_Runtime_TaskNs_NetWorkTransactionTask.<>f__mg$cache2 == null)
		{
			Lua_BlackJack_BJFramework_Runtime_TaskNs_NetWorkTransactionTask.<>f__mg$cache2 = new LuaCSFunction(Lua_BlackJack_BJFramework_Runtime_TaskNs_NetWorkTransactionTask.OnPause);
		}
		LuaObject.addMember(l, Lua_BlackJack_BJFramework_Runtime_TaskNs_NetWorkTransactionTask.<>f__mg$cache2);
		if (Lua_BlackJack_BJFramework_Runtime_TaskNs_NetWorkTransactionTask.<>f__mg$cache3 == null)
		{
			Lua_BlackJack_BJFramework_Runtime_TaskNs_NetWorkTransactionTask.<>f__mg$cache3 = new LuaCSFunction(Lua_BlackJack_BJFramework_Runtime_TaskNs_NetWorkTransactionTask.OnResume);
		}
		LuaObject.addMember(l, Lua_BlackJack_BJFramework_Runtime_TaskNs_NetWorkTransactionTask.<>f__mg$cache3);
		if (Lua_BlackJack_BJFramework_Runtime_TaskNs_NetWorkTransactionTask.<>f__mg$cache4 == null)
		{
			Lua_BlackJack_BJFramework_Runtime_TaskNs_NetWorkTransactionTask.<>f__mg$cache4 = new LuaCSFunction(Lua_BlackJack_BJFramework_Runtime_TaskNs_NetWorkTransactionTask.StartNetWorking);
		}
		LuaObject.addMember(l, Lua_BlackJack_BJFramework_Runtime_TaskNs_NetWorkTransactionTask.<>f__mg$cache4);
		if (Lua_BlackJack_BJFramework_Runtime_TaskNs_NetWorkTransactionTask.<>f__mg$cache5 == null)
		{
			Lua_BlackJack_BJFramework_Runtime_TaskNs_NetWorkTransactionTask.<>f__mg$cache5 = new LuaCSFunction(Lua_BlackJack_BJFramework_Runtime_TaskNs_NetWorkTransactionTask.OnTransactionComplete);
		}
		LuaObject.addMember(l, Lua_BlackJack_BJFramework_Runtime_TaskNs_NetWorkTransactionTask.<>f__mg$cache5);
		if (Lua_BlackJack_BJFramework_Runtime_TaskNs_NetWorkTransactionTask.<>f__mg$cache6 == null)
		{
			Lua_BlackJack_BJFramework_Runtime_TaskNs_NetWorkTransactionTask.<>f__mg$cache6 = new LuaCSFunction(Lua_BlackJack_BJFramework_Runtime_TaskNs_NetWorkTransactionTask.RegisterNetworkEvent);
		}
		LuaObject.addMember(l, Lua_BlackJack_BJFramework_Runtime_TaskNs_NetWorkTransactionTask.<>f__mg$cache6);
		if (Lua_BlackJack_BJFramework_Runtime_TaskNs_NetWorkTransactionTask.<>f__mg$cache7 == null)
		{
			Lua_BlackJack_BJFramework_Runtime_TaskNs_NetWorkTransactionTask.<>f__mg$cache7 = new LuaCSFunction(Lua_BlackJack_BJFramework_Runtime_TaskNs_NetWorkTransactionTask.UnregisterNetworkEvent);
		}
		LuaObject.addMember(l, Lua_BlackJack_BJFramework_Runtime_TaskNs_NetWorkTransactionTask.<>f__mg$cache7);
		if (Lua_BlackJack_BJFramework_Runtime_TaskNs_NetWorkTransactionTask.<>f__mg$cache8 == null)
		{
			Lua_BlackJack_BJFramework_Runtime_TaskNs_NetWorkTransactionTask.<>f__mg$cache8 = new LuaCSFunction(Lua_BlackJack_BJFramework_Runtime_TaskNs_NetWorkTransactionTask.OnTick);
		}
		LuaObject.addMember(l, Lua_BlackJack_BJFramework_Runtime_TaskNs_NetWorkTransactionTask.<>f__mg$cache8);
		if (Lua_BlackJack_BJFramework_Runtime_TaskNs_NetWorkTransactionTask.<>f__mg$cache9 == null)
		{
			Lua_BlackJack_BJFramework_Runtime_TaskNs_NetWorkTransactionTask.<>f__mg$cache9 = new LuaCSFunction(Lua_BlackJack_BJFramework_Runtime_TaskNs_NetWorkTransactionTask.OnTimeOut);
		}
		LuaObject.addMember(l, Lua_BlackJack_BJFramework_Runtime_TaskNs_NetWorkTransactionTask.<>f__mg$cache9);
		if (Lua_BlackJack_BJFramework_Runtime_TaskNs_NetWorkTransactionTask.<>f__mg$cacheA == null)
		{
			Lua_BlackJack_BJFramework_Runtime_TaskNs_NetWorkTransactionTask.<>f__mg$cacheA = new LuaCSFunction(Lua_BlackJack_BJFramework_Runtime_TaskNs_NetWorkTransactionTask.OnGameServerDataUnsyncNotify);
		}
		LuaObject.addMember(l, Lua_BlackJack_BJFramework_Runtime_TaskNs_NetWorkTransactionTask.<>f__mg$cacheA);
		if (Lua_BlackJack_BJFramework_Runtime_TaskNs_NetWorkTransactionTask.<>f__mg$cacheB == null)
		{
			Lua_BlackJack_BJFramework_Runtime_TaskNs_NetWorkTransactionTask.<>f__mg$cacheB = new LuaCSFunction(Lua_BlackJack_BJFramework_Runtime_TaskNs_NetWorkTransactionTask.OnGameServerNetworkError);
		}
		LuaObject.addMember(l, Lua_BlackJack_BJFramework_Runtime_TaskNs_NetWorkTransactionTask.<>f__mg$cacheB);
		if (Lua_BlackJack_BJFramework_Runtime_TaskNs_NetWorkTransactionTask.<>f__mg$cacheC == null)
		{
			Lua_BlackJack_BJFramework_Runtime_TaskNs_NetWorkTransactionTask.<>f__mg$cacheC = new LuaCSFunction(Lua_BlackJack_BJFramework_Runtime_TaskNs_NetWorkTransactionTask.OnGameServerDisconnected);
		}
		LuaObject.addMember(l, Lua_BlackJack_BJFramework_Runtime_TaskNs_NetWorkTransactionTask.<>f__mg$cacheC);
		if (Lua_BlackJack_BJFramework_Runtime_TaskNs_NetWorkTransactionTask.<>f__mg$cacheD == null)
		{
			Lua_BlackJack_BJFramework_Runtime_TaskNs_NetWorkTransactionTask.<>f__mg$cacheD = new LuaCSFunction(Lua_BlackJack_BJFramework_Runtime_TaskNs_NetWorkTransactionTask.OnNetworkError);
		}
		LuaObject.addMember(l, Lua_BlackJack_BJFramework_Runtime_TaskNs_NetWorkTransactionTask.<>f__mg$cacheD);
		if (Lua_BlackJack_BJFramework_Runtime_TaskNs_NetWorkTransactionTask.<>f__mg$cacheE == null)
		{
			Lua_BlackJack_BJFramework_Runtime_TaskNs_NetWorkTransactionTask.<>f__mg$cacheE = new LuaCSFunction(Lua_BlackJack_BJFramework_Runtime_TaskNs_NetWorkTransactionTask.OnReLoginSuccess);
		}
		LuaObject.addMember(l, Lua_BlackJack_BJFramework_Runtime_TaskNs_NetWorkTransactionTask.<>f__mg$cacheE);
		if (Lua_BlackJack_BJFramework_Runtime_TaskNs_NetWorkTransactionTask.<>f__mg$cacheF == null)
		{
			Lua_BlackJack_BJFramework_Runtime_TaskNs_NetWorkTransactionTask.<>f__mg$cacheF = new LuaCSFunction(Lua_BlackJack_BJFramework_Runtime_TaskNs_NetWorkTransactionTask.OnUIManagerReturnToLoginUI);
		}
		LuaObject.addMember(l, Lua_BlackJack_BJFramework_Runtime_TaskNs_NetWorkTransactionTask.<>f__mg$cacheF);
		if (Lua_BlackJack_BJFramework_Runtime_TaskNs_NetWorkTransactionTask.<>f__mg$cache10 == null)
		{
			Lua_BlackJack_BJFramework_Runtime_TaskNs_NetWorkTransactionTask.<>f__mg$cache10 = new LuaCSFunction(Lua_BlackJack_BJFramework_Runtime_TaskNs_NetWorkTransactionTask.__callBase_Start);
		}
		LuaObject.addMember(l, Lua_BlackJack_BJFramework_Runtime_TaskNs_NetWorkTransactionTask.<>f__mg$cache10);
		if (Lua_BlackJack_BJFramework_Runtime_TaskNs_NetWorkTransactionTask.<>f__mg$cache11 == null)
		{
			Lua_BlackJack_BJFramework_Runtime_TaskNs_NetWorkTransactionTask.<>f__mg$cache11 = new LuaCSFunction(Lua_BlackJack_BJFramework_Runtime_TaskNs_NetWorkTransactionTask.__callBase_Stop);
		}
		LuaObject.addMember(l, Lua_BlackJack_BJFramework_Runtime_TaskNs_NetWorkTransactionTask.<>f__mg$cache11);
		if (Lua_BlackJack_BJFramework_Runtime_TaskNs_NetWorkTransactionTask.<>f__mg$cache12 == null)
		{
			Lua_BlackJack_BJFramework_Runtime_TaskNs_NetWorkTransactionTask.<>f__mg$cache12 = new LuaCSFunction(Lua_BlackJack_BJFramework_Runtime_TaskNs_NetWorkTransactionTask.__callBase_Pause);
		}
		LuaObject.addMember(l, Lua_BlackJack_BJFramework_Runtime_TaskNs_NetWorkTransactionTask.<>f__mg$cache12);
		if (Lua_BlackJack_BJFramework_Runtime_TaskNs_NetWorkTransactionTask.<>f__mg$cache13 == null)
		{
			Lua_BlackJack_BJFramework_Runtime_TaskNs_NetWorkTransactionTask.<>f__mg$cache13 = new LuaCSFunction(Lua_BlackJack_BJFramework_Runtime_TaskNs_NetWorkTransactionTask.__callBase_Resume);
		}
		LuaObject.addMember(l, Lua_BlackJack_BJFramework_Runtime_TaskNs_NetWorkTransactionTask.<>f__mg$cache13);
		if (Lua_BlackJack_BJFramework_Runtime_TaskNs_NetWorkTransactionTask.<>f__mg$cache14 == null)
		{
			Lua_BlackJack_BJFramework_Runtime_TaskNs_NetWorkTransactionTask.<>f__mg$cache14 = new LuaCSFunction(Lua_BlackJack_BJFramework_Runtime_TaskNs_NetWorkTransactionTask.__callBase_ClearOnStopEvent);
		}
		LuaObject.addMember(l, Lua_BlackJack_BJFramework_Runtime_TaskNs_NetWorkTransactionTask.<>f__mg$cache14);
		if (Lua_BlackJack_BJFramework_Runtime_TaskNs_NetWorkTransactionTask.<>f__mg$cache15 == null)
		{
			Lua_BlackJack_BJFramework_Runtime_TaskNs_NetWorkTransactionTask.<>f__mg$cache15 = new LuaCSFunction(Lua_BlackJack_BJFramework_Runtime_TaskNs_NetWorkTransactionTask.__callBase_ExecAfterTicks);
		}
		LuaObject.addMember(l, Lua_BlackJack_BJFramework_Runtime_TaskNs_NetWorkTransactionTask.<>f__mg$cache15);
		if (Lua_BlackJack_BJFramework_Runtime_TaskNs_NetWorkTransactionTask.<>f__mg$cache16 == null)
		{
			Lua_BlackJack_BJFramework_Runtime_TaskNs_NetWorkTransactionTask.<>f__mg$cache16 = new LuaCSFunction(Lua_BlackJack_BJFramework_Runtime_TaskNs_NetWorkTransactionTask.__callBase_OnStart);
		}
		LuaObject.addMember(l, Lua_BlackJack_BJFramework_Runtime_TaskNs_NetWorkTransactionTask.<>f__mg$cache16);
		if (Lua_BlackJack_BJFramework_Runtime_TaskNs_NetWorkTransactionTask.<>f__mg$cache17 == null)
		{
			Lua_BlackJack_BJFramework_Runtime_TaskNs_NetWorkTransactionTask.<>f__mg$cache17 = new LuaCSFunction(Lua_BlackJack_BJFramework_Runtime_TaskNs_NetWorkTransactionTask.__callBase_OnPause);
		}
		LuaObject.addMember(l, Lua_BlackJack_BJFramework_Runtime_TaskNs_NetWorkTransactionTask.<>f__mg$cache17);
		if (Lua_BlackJack_BJFramework_Runtime_TaskNs_NetWorkTransactionTask.<>f__mg$cache18 == null)
		{
			Lua_BlackJack_BJFramework_Runtime_TaskNs_NetWorkTransactionTask.<>f__mg$cache18 = new LuaCSFunction(Lua_BlackJack_BJFramework_Runtime_TaskNs_NetWorkTransactionTask.__callBase_OnResume);
		}
		LuaObject.addMember(l, Lua_BlackJack_BJFramework_Runtime_TaskNs_NetWorkTransactionTask.<>f__mg$cache18);
		if (Lua_BlackJack_BJFramework_Runtime_TaskNs_NetWorkTransactionTask.<>f__mg$cache19 == null)
		{
			Lua_BlackJack_BJFramework_Runtime_TaskNs_NetWorkTransactionTask.<>f__mg$cache19 = new LuaCSFunction(Lua_BlackJack_BJFramework_Runtime_TaskNs_NetWorkTransactionTask.__callBase_OnStop);
		}
		LuaObject.addMember(l, Lua_BlackJack_BJFramework_Runtime_TaskNs_NetWorkTransactionTask.<>f__mg$cache19);
		if (Lua_BlackJack_BJFramework_Runtime_TaskNs_NetWorkTransactionTask.<>f__mg$cache1A == null)
		{
			Lua_BlackJack_BJFramework_Runtime_TaskNs_NetWorkTransactionTask.<>f__mg$cache1A = new LuaCSFunction(Lua_BlackJack_BJFramework_Runtime_TaskNs_NetWorkTransactionTask.__callBase_OnTick);
		}
		LuaObject.addMember(l, Lua_BlackJack_BJFramework_Runtime_TaskNs_NetWorkTransactionTask.<>f__mg$cache1A);
		if (Lua_BlackJack_BJFramework_Runtime_TaskNs_NetWorkTransactionTask.<>f__mg$cache1B == null)
		{
			Lua_BlackJack_BJFramework_Runtime_TaskNs_NetWorkTransactionTask.<>f__mg$cache1B = new LuaCSFunction(Lua_BlackJack_BJFramework_Runtime_TaskNs_NetWorkTransactionTask.__callBase_ToString);
		}
		LuaObject.addMember(l, Lua_BlackJack_BJFramework_Runtime_TaskNs_NetWorkTransactionTask.<>f__mg$cache1B);
		if (Lua_BlackJack_BJFramework_Runtime_TaskNs_NetWorkTransactionTask.<>f__mg$cache1C == null)
		{
			Lua_BlackJack_BJFramework_Runtime_TaskNs_NetWorkTransactionTask.<>f__mg$cache1C = new LuaCSFunction(Lua_BlackJack_BJFramework_Runtime_TaskNs_NetWorkTransactionTask.__callDele_EventShowUIWaiting_s);
		}
		LuaObject.addMember(l, Lua_BlackJack_BJFramework_Runtime_TaskNs_NetWorkTransactionTask.<>f__mg$cache1C);
		if (Lua_BlackJack_BJFramework_Runtime_TaskNs_NetWorkTransactionTask.<>f__mg$cache1D == null)
		{
			Lua_BlackJack_BJFramework_Runtime_TaskNs_NetWorkTransactionTask.<>f__mg$cache1D = new LuaCSFunction(Lua_BlackJack_BJFramework_Runtime_TaskNs_NetWorkTransactionTask.__clearDele_EventShowUIWaiting_s);
		}
		LuaObject.addMember(l, Lua_BlackJack_BJFramework_Runtime_TaskNs_NetWorkTransactionTask.<>f__mg$cache1D);
		if (Lua_BlackJack_BJFramework_Runtime_TaskNs_NetWorkTransactionTask.<>f__mg$cache1E == null)
		{
			Lua_BlackJack_BJFramework_Runtime_TaskNs_NetWorkTransactionTask.<>f__mg$cache1E = new LuaCSFunction(Lua_BlackJack_BJFramework_Runtime_TaskNs_NetWorkTransactionTask.__callDele_EventReturnToLoginUI_s);
		}
		LuaObject.addMember(l, Lua_BlackJack_BJFramework_Runtime_TaskNs_NetWorkTransactionTask.<>f__mg$cache1E);
		if (Lua_BlackJack_BJFramework_Runtime_TaskNs_NetWorkTransactionTask.<>f__mg$cache1F == null)
		{
			Lua_BlackJack_BJFramework_Runtime_TaskNs_NetWorkTransactionTask.<>f__mg$cache1F = new LuaCSFunction(Lua_BlackJack_BJFramework_Runtime_TaskNs_NetWorkTransactionTask.__clearDele_EventReturnToLoginUI_s);
		}
		LuaObject.addMember(l, Lua_BlackJack_BJFramework_Runtime_TaskNs_NetWorkTransactionTask.<>f__mg$cache1F);
		if (Lua_BlackJack_BJFramework_Runtime_TaskNs_NetWorkTransactionTask.<>f__mg$cache20 == null)
		{
			Lua_BlackJack_BJFramework_Runtime_TaskNs_NetWorkTransactionTask.<>f__mg$cache20 = new LuaCSFunction(Lua_BlackJack_BJFramework_Runtime_TaskNs_NetWorkTransactionTask.__callDele_EventReLoginBySession_s);
		}
		LuaObject.addMember(l, Lua_BlackJack_BJFramework_Runtime_TaskNs_NetWorkTransactionTask.<>f__mg$cache20);
		if (Lua_BlackJack_BJFramework_Runtime_TaskNs_NetWorkTransactionTask.<>f__mg$cache21 == null)
		{
			Lua_BlackJack_BJFramework_Runtime_TaskNs_NetWorkTransactionTask.<>f__mg$cache21 = new LuaCSFunction(Lua_BlackJack_BJFramework_Runtime_TaskNs_NetWorkTransactionTask.__clearDele_EventReLoginBySession_s);
		}
		LuaObject.addMember(l, Lua_BlackJack_BJFramework_Runtime_TaskNs_NetWorkTransactionTask.<>f__mg$cache21);
		string name = "m_blockedUITask";
		if (Lua_BlackJack_BJFramework_Runtime_TaskNs_NetWorkTransactionTask.<>f__mg$cache22 == null)
		{
			Lua_BlackJack_BJFramework_Runtime_TaskNs_NetWorkTransactionTask.<>f__mg$cache22 = new LuaCSFunction(Lua_BlackJack_BJFramework_Runtime_TaskNs_NetWorkTransactionTask.get_m_blockedUITask);
		}
		LuaCSFunction get = Lua_BlackJack_BJFramework_Runtime_TaskNs_NetWorkTransactionTask.<>f__mg$cache22;
		if (Lua_BlackJack_BJFramework_Runtime_TaskNs_NetWorkTransactionTask.<>f__mg$cache23 == null)
		{
			Lua_BlackJack_BJFramework_Runtime_TaskNs_NetWorkTransactionTask.<>f__mg$cache23 = new LuaCSFunction(Lua_BlackJack_BJFramework_Runtime_TaskNs_NetWorkTransactionTask.set_m_blockedUITask);
		}
		LuaObject.addMember(l, name, get, Lua_BlackJack_BJFramework_Runtime_TaskNs_NetWorkTransactionTask.<>f__mg$cache23, true);
		string name2 = "m_autoRetry";
		if (Lua_BlackJack_BJFramework_Runtime_TaskNs_NetWorkTransactionTask.<>f__mg$cache24 == null)
		{
			Lua_BlackJack_BJFramework_Runtime_TaskNs_NetWorkTransactionTask.<>f__mg$cache24 = new LuaCSFunction(Lua_BlackJack_BJFramework_Runtime_TaskNs_NetWorkTransactionTask.get_m_autoRetry);
		}
		LuaCSFunction get2 = Lua_BlackJack_BJFramework_Runtime_TaskNs_NetWorkTransactionTask.<>f__mg$cache24;
		if (Lua_BlackJack_BJFramework_Runtime_TaskNs_NetWorkTransactionTask.<>f__mg$cache25 == null)
		{
			Lua_BlackJack_BJFramework_Runtime_TaskNs_NetWorkTransactionTask.<>f__mg$cache25 = new LuaCSFunction(Lua_BlackJack_BJFramework_Runtime_TaskNs_NetWorkTransactionTask.set_m_autoRetry);
		}
		LuaObject.addMember(l, name2, get2, Lua_BlackJack_BJFramework_Runtime_TaskNs_NetWorkTransactionTask.<>f__mg$cache25, true);
		string name3 = "m_timeout";
		if (Lua_BlackJack_BJFramework_Runtime_TaskNs_NetWorkTransactionTask.<>f__mg$cache26 == null)
		{
			Lua_BlackJack_BJFramework_Runtime_TaskNs_NetWorkTransactionTask.<>f__mg$cache26 = new LuaCSFunction(Lua_BlackJack_BJFramework_Runtime_TaskNs_NetWorkTransactionTask.get_m_timeout);
		}
		LuaCSFunction get3 = Lua_BlackJack_BJFramework_Runtime_TaskNs_NetWorkTransactionTask.<>f__mg$cache26;
		if (Lua_BlackJack_BJFramework_Runtime_TaskNs_NetWorkTransactionTask.<>f__mg$cache27 == null)
		{
			Lua_BlackJack_BJFramework_Runtime_TaskNs_NetWorkTransactionTask.<>f__mg$cache27 = new LuaCSFunction(Lua_BlackJack_BJFramework_Runtime_TaskNs_NetWorkTransactionTask.set_m_timeout);
		}
		LuaObject.addMember(l, name3, get3, Lua_BlackJack_BJFramework_Runtime_TaskNs_NetWorkTransactionTask.<>f__mg$cache27, true);
		string name4 = "m_isTimeOuted";
		if (Lua_BlackJack_BJFramework_Runtime_TaskNs_NetWorkTransactionTask.<>f__mg$cache28 == null)
		{
			Lua_BlackJack_BJFramework_Runtime_TaskNs_NetWorkTransactionTask.<>f__mg$cache28 = new LuaCSFunction(Lua_BlackJack_BJFramework_Runtime_TaskNs_NetWorkTransactionTask.get_m_isTimeOuted);
		}
		LuaCSFunction get4 = Lua_BlackJack_BJFramework_Runtime_TaskNs_NetWorkTransactionTask.<>f__mg$cache28;
		if (Lua_BlackJack_BJFramework_Runtime_TaskNs_NetWorkTransactionTask.<>f__mg$cache29 == null)
		{
			Lua_BlackJack_BJFramework_Runtime_TaskNs_NetWorkTransactionTask.<>f__mg$cache29 = new LuaCSFunction(Lua_BlackJack_BJFramework_Runtime_TaskNs_NetWorkTransactionTask.set_m_isTimeOuted);
		}
		LuaObject.addMember(l, name4, get4, Lua_BlackJack_BJFramework_Runtime_TaskNs_NetWorkTransactionTask.<>f__mg$cache29, true);
		string name5 = "m_timeoutTime";
		if (Lua_BlackJack_BJFramework_Runtime_TaskNs_NetWorkTransactionTask.<>f__mg$cache2A == null)
		{
			Lua_BlackJack_BJFramework_Runtime_TaskNs_NetWorkTransactionTask.<>f__mg$cache2A = new LuaCSFunction(Lua_BlackJack_BJFramework_Runtime_TaskNs_NetWorkTransactionTask.get_m_timeoutTime);
		}
		LuaCSFunction get5 = Lua_BlackJack_BJFramework_Runtime_TaskNs_NetWorkTransactionTask.<>f__mg$cache2A;
		if (Lua_BlackJack_BJFramework_Runtime_TaskNs_NetWorkTransactionTask.<>f__mg$cache2B == null)
		{
			Lua_BlackJack_BJFramework_Runtime_TaskNs_NetWorkTransactionTask.<>f__mg$cache2B = new LuaCSFunction(Lua_BlackJack_BJFramework_Runtime_TaskNs_NetWorkTransactionTask.set_m_timeoutTime);
		}
		LuaObject.addMember(l, name5, get5, Lua_BlackJack_BJFramework_Runtime_TaskNs_NetWorkTransactionTask.<>f__mg$cache2B, true);
		string name6 = "m_showWaitingUITime";
		if (Lua_BlackJack_BJFramework_Runtime_TaskNs_NetWorkTransactionTask.<>f__mg$cache2C == null)
		{
			Lua_BlackJack_BJFramework_Runtime_TaskNs_NetWorkTransactionTask.<>f__mg$cache2C = new LuaCSFunction(Lua_BlackJack_BJFramework_Runtime_TaskNs_NetWorkTransactionTask.get_m_showWaitingUITime);
		}
		LuaCSFunction get6 = Lua_BlackJack_BJFramework_Runtime_TaskNs_NetWorkTransactionTask.<>f__mg$cache2C;
		if (Lua_BlackJack_BJFramework_Runtime_TaskNs_NetWorkTransactionTask.<>f__mg$cache2D == null)
		{
			Lua_BlackJack_BJFramework_Runtime_TaskNs_NetWorkTransactionTask.<>f__mg$cache2D = new LuaCSFunction(Lua_BlackJack_BJFramework_Runtime_TaskNs_NetWorkTransactionTask.set_m_showWaitingUITime);
		}
		LuaObject.addMember(l, name6, get6, Lua_BlackJack_BJFramework_Runtime_TaskNs_NetWorkTransactionTask.<>f__mg$cache2D, true);
		string name7 = "m_isUIWaitingShown";
		if (Lua_BlackJack_BJFramework_Runtime_TaskNs_NetWorkTransactionTask.<>f__mg$cache2E == null)
		{
			Lua_BlackJack_BJFramework_Runtime_TaskNs_NetWorkTransactionTask.<>f__mg$cache2E = new LuaCSFunction(Lua_BlackJack_BJFramework_Runtime_TaskNs_NetWorkTransactionTask.get_m_isUIWaitingShown);
		}
		LuaCSFunction get7 = Lua_BlackJack_BJFramework_Runtime_TaskNs_NetWorkTransactionTask.<>f__mg$cache2E;
		if (Lua_BlackJack_BJFramework_Runtime_TaskNs_NetWorkTransactionTask.<>f__mg$cache2F == null)
		{
			Lua_BlackJack_BJFramework_Runtime_TaskNs_NetWorkTransactionTask.<>f__mg$cache2F = new LuaCSFunction(Lua_BlackJack_BJFramework_Runtime_TaskNs_NetWorkTransactionTask.set_m_isUIWaitingShown);
		}
		LuaObject.addMember(l, name7, get7, Lua_BlackJack_BJFramework_Runtime_TaskNs_NetWorkTransactionTask.<>f__mg$cache2F, true);
		string name8 = "m_isReturnToLoginByDirtyData";
		if (Lua_BlackJack_BJFramework_Runtime_TaskNs_NetWorkTransactionTask.<>f__mg$cache30 == null)
		{
			Lua_BlackJack_BJFramework_Runtime_TaskNs_NetWorkTransactionTask.<>f__mg$cache30 = new LuaCSFunction(Lua_BlackJack_BJFramework_Runtime_TaskNs_NetWorkTransactionTask.get_m_isReturnToLoginByDirtyData);
		}
		LuaCSFunction get8 = Lua_BlackJack_BJFramework_Runtime_TaskNs_NetWorkTransactionTask.<>f__mg$cache30;
		if (Lua_BlackJack_BJFramework_Runtime_TaskNs_NetWorkTransactionTask.<>f__mg$cache31 == null)
		{
			Lua_BlackJack_BJFramework_Runtime_TaskNs_NetWorkTransactionTask.<>f__mg$cache31 = new LuaCSFunction(Lua_BlackJack_BJFramework_Runtime_TaskNs_NetWorkTransactionTask.set_m_isReturnToLoginByDirtyData);
		}
		LuaObject.addMember(l, name8, get8, Lua_BlackJack_BJFramework_Runtime_TaskNs_NetWorkTransactionTask.<>f__mg$cache31, true);
		string name9 = "m_isLaunchedReloginUITask";
		if (Lua_BlackJack_BJFramework_Runtime_TaskNs_NetWorkTransactionTask.<>f__mg$cache32 == null)
		{
			Lua_BlackJack_BJFramework_Runtime_TaskNs_NetWorkTransactionTask.<>f__mg$cache32 = new LuaCSFunction(Lua_BlackJack_BJFramework_Runtime_TaskNs_NetWorkTransactionTask.get_m_isLaunchedReloginUITask);
		}
		LuaCSFunction get9 = Lua_BlackJack_BJFramework_Runtime_TaskNs_NetWorkTransactionTask.<>f__mg$cache32;
		if (Lua_BlackJack_BJFramework_Runtime_TaskNs_NetWorkTransactionTask.<>f__mg$cache33 == null)
		{
			Lua_BlackJack_BJFramework_Runtime_TaskNs_NetWorkTransactionTask.<>f__mg$cache33 = new LuaCSFunction(Lua_BlackJack_BJFramework_Runtime_TaskNs_NetWorkTransactionTask.set_m_isLaunchedReloginUITask);
		}
		LuaObject.addMember(l, name9, get9, Lua_BlackJack_BJFramework_Runtime_TaskNs_NetWorkTransactionTask.<>f__mg$cache33, true);
		string name10 = "m_delayTimeForUIWaiting";
		if (Lua_BlackJack_BJFramework_Runtime_TaskNs_NetWorkTransactionTask.<>f__mg$cache34 == null)
		{
			Lua_BlackJack_BJFramework_Runtime_TaskNs_NetWorkTransactionTask.<>f__mg$cache34 = new LuaCSFunction(Lua_BlackJack_BJFramework_Runtime_TaskNs_NetWorkTransactionTask.get_m_delayTimeForUIWaiting);
		}
		LuaCSFunction get10 = Lua_BlackJack_BJFramework_Runtime_TaskNs_NetWorkTransactionTask.<>f__mg$cache34;
		if (Lua_BlackJack_BJFramework_Runtime_TaskNs_NetWorkTransactionTask.<>f__mg$cache35 == null)
		{
			Lua_BlackJack_BJFramework_Runtime_TaskNs_NetWorkTransactionTask.<>f__mg$cache35 = new LuaCSFunction(Lua_BlackJack_BJFramework_Runtime_TaskNs_NetWorkTransactionTask.set_m_delayTimeForUIWaiting);
		}
		LuaObject.addMember(l, name10, get10, Lua_BlackJack_BJFramework_Runtime_TaskNs_NetWorkTransactionTask.<>f__mg$cache35, false);
		string name11 = "TimeOutForEditor";
		if (Lua_BlackJack_BJFramework_Runtime_TaskNs_NetWorkTransactionTask.<>f__mg$cache36 == null)
		{
			Lua_BlackJack_BJFramework_Runtime_TaskNs_NetWorkTransactionTask.<>f__mg$cache36 = new LuaCSFunction(Lua_BlackJack_BJFramework_Runtime_TaskNs_NetWorkTransactionTask.get_TimeOutForEditor);
		}
		LuaObject.addMember(l, name11, Lua_BlackJack_BJFramework_Runtime_TaskNs_NetWorkTransactionTask.<>f__mg$cache36, null, false);
		string name12 = "EventShowUIWaiting";
		LuaCSFunction get11 = null;
		if (Lua_BlackJack_BJFramework_Runtime_TaskNs_NetWorkTransactionTask.<>f__mg$cache37 == null)
		{
			Lua_BlackJack_BJFramework_Runtime_TaskNs_NetWorkTransactionTask.<>f__mg$cache37 = new LuaCSFunction(Lua_BlackJack_BJFramework_Runtime_TaskNs_NetWorkTransactionTask.set_EventShowUIWaiting);
		}
		LuaObject.addMember(l, name12, get11, Lua_BlackJack_BJFramework_Runtime_TaskNs_NetWorkTransactionTask.<>f__mg$cache37, false);
		string name13 = "EventReturnToLoginUI";
		LuaCSFunction get12 = null;
		if (Lua_BlackJack_BJFramework_Runtime_TaskNs_NetWorkTransactionTask.<>f__mg$cache38 == null)
		{
			Lua_BlackJack_BJFramework_Runtime_TaskNs_NetWorkTransactionTask.<>f__mg$cache38 = new LuaCSFunction(Lua_BlackJack_BJFramework_Runtime_TaskNs_NetWorkTransactionTask.set_EventReturnToLoginUI);
		}
		LuaObject.addMember(l, name13, get12, Lua_BlackJack_BJFramework_Runtime_TaskNs_NetWorkTransactionTask.<>f__mg$cache38, false);
		string name14 = "EventReLoginBySession";
		LuaCSFunction get13 = null;
		if (Lua_BlackJack_BJFramework_Runtime_TaskNs_NetWorkTransactionTask.<>f__mg$cache39 == null)
		{
			Lua_BlackJack_BJFramework_Runtime_TaskNs_NetWorkTransactionTask.<>f__mg$cache39 = new LuaCSFunction(Lua_BlackJack_BJFramework_Runtime_TaskNs_NetWorkTransactionTask.set_EventReLoginBySession);
		}
		LuaObject.addMember(l, name14, get13, Lua_BlackJack_BJFramework_Runtime_TaskNs_NetWorkTransactionTask.<>f__mg$cache39, false);
		if (Lua_BlackJack_BJFramework_Runtime_TaskNs_NetWorkTransactionTask.<>f__mg$cache3A == null)
		{
			Lua_BlackJack_BJFramework_Runtime_TaskNs_NetWorkTransactionTask.<>f__mg$cache3A = new LuaCSFunction(Lua_BlackJack_BJFramework_Runtime_TaskNs_NetWorkTransactionTask.constructor);
		}
		LuaObject.createTypeMetatable(l, Lua_BlackJack_BJFramework_Runtime_TaskNs_NetWorkTransactionTask.<>f__mg$cache3A, typeof(NetWorkTransactionTask), typeof(Task));
	}

	// Token: 0x0400C469 RID: 50281
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache0;

	// Token: 0x0400C46A RID: 50282
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1;

	// Token: 0x0400C46B RID: 50283
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2;

	// Token: 0x0400C46C RID: 50284
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3;

	// Token: 0x0400C46D RID: 50285
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache4;

	// Token: 0x0400C46E RID: 50286
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache5;

	// Token: 0x0400C46F RID: 50287
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache6;

	// Token: 0x0400C470 RID: 50288
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache7;

	// Token: 0x0400C471 RID: 50289
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache8;

	// Token: 0x0400C472 RID: 50290
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache9;

	// Token: 0x0400C473 RID: 50291
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheA;

	// Token: 0x0400C474 RID: 50292
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheB;

	// Token: 0x0400C475 RID: 50293
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheC;

	// Token: 0x0400C476 RID: 50294
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheD;

	// Token: 0x0400C477 RID: 50295
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheE;

	// Token: 0x0400C478 RID: 50296
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheF;

	// Token: 0x0400C479 RID: 50297
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache10;

	// Token: 0x0400C47A RID: 50298
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache11;

	// Token: 0x0400C47B RID: 50299
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache12;

	// Token: 0x0400C47C RID: 50300
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache13;

	// Token: 0x0400C47D RID: 50301
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache14;

	// Token: 0x0400C47E RID: 50302
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache15;

	// Token: 0x0400C47F RID: 50303
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache16;

	// Token: 0x0400C480 RID: 50304
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache17;

	// Token: 0x0400C481 RID: 50305
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache18;

	// Token: 0x0400C482 RID: 50306
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache19;

	// Token: 0x0400C483 RID: 50307
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1A;

	// Token: 0x0400C484 RID: 50308
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1B;

	// Token: 0x0400C485 RID: 50309
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1C;

	// Token: 0x0400C486 RID: 50310
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1D;

	// Token: 0x0400C487 RID: 50311
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1E;

	// Token: 0x0400C488 RID: 50312
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1F;

	// Token: 0x0400C489 RID: 50313
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache20;

	// Token: 0x0400C48A RID: 50314
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache21;

	// Token: 0x0400C48B RID: 50315
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache22;

	// Token: 0x0400C48C RID: 50316
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache23;

	// Token: 0x0400C48D RID: 50317
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache24;

	// Token: 0x0400C48E RID: 50318
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache25;

	// Token: 0x0400C48F RID: 50319
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache26;

	// Token: 0x0400C490 RID: 50320
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache27;

	// Token: 0x0400C491 RID: 50321
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache28;

	// Token: 0x0400C492 RID: 50322
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache29;

	// Token: 0x0400C493 RID: 50323
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2A;

	// Token: 0x0400C494 RID: 50324
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2B;

	// Token: 0x0400C495 RID: 50325
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2C;

	// Token: 0x0400C496 RID: 50326
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2D;

	// Token: 0x0400C497 RID: 50327
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2E;

	// Token: 0x0400C498 RID: 50328
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2F;

	// Token: 0x0400C499 RID: 50329
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache30;

	// Token: 0x0400C49A RID: 50330
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache31;

	// Token: 0x0400C49B RID: 50331
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache32;

	// Token: 0x0400C49C RID: 50332
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache33;

	// Token: 0x0400C49D RID: 50333
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache34;

	// Token: 0x0400C49E RID: 50334
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache35;

	// Token: 0x0400C49F RID: 50335
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache36;

	// Token: 0x0400C4A0 RID: 50336
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache37;

	// Token: 0x0400C4A1 RID: 50337
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache38;

	// Token: 0x0400C4A2 RID: 50338
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache39;

	// Token: 0x0400C4A3 RID: 50339
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3A;
}
