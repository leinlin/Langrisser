using System;
using System.Runtime.CompilerServices;
using BlackJack.BJFramework.Runtime.UI;
using BlackJack.ProjectL.UI;
using SLua;
using UnityEngine.Scripting;

// Token: 0x02001559 RID: 5465
[Preserve]
public class Lua_BlackJack_ProjectL_UI_ReloginUITask : LuaObject
{
	// Token: 0x06020AA6 RID: 133798 RVA: 0x00AEB47C File Offset: 0x00AE967C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int constructor(IntPtr l)
	{
		int result;
		try
		{
			string name;
			LuaObject.checkType(l, 2, out name);
			ReloginUITask o = new ReloginUITask(name);
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

	// Token: 0x06020AA7 RID: 133799 RVA: 0x00AEB4D0 File Offset: 0x00AE96D0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int OnStart(IntPtr l)
	{
		int result;
		try
		{
			ReloginUITask reloginUITask = (ReloginUITask)LuaObject.checkSelf(l);
			UIIntent intent;
			LuaObject.checkType<UIIntent>(l, 2, out intent);
			bool b = reloginUITask.m_luaExportHelper.OnStart(intent);
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

	// Token: 0x06020AA8 RID: 133800 RVA: 0x00AEB538 File Offset: 0x00AE9738
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int InitAllUIControllers(IntPtr l)
	{
		int result;
		try
		{
			ReloginUITask reloginUITask = (ReloginUITask)LuaObject.checkSelf(l);
			reloginUITask.m_luaExportHelper.InitAllUIControllers();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06020AA9 RID: 133801 RVA: 0x00AEB58C File Offset: 0x00AE978C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int ClearAllContextAndRes(IntPtr l)
	{
		int result;
		try
		{
			ReloginUITask reloginUITask = (ReloginUITask)LuaObject.checkSelf(l);
			reloginUITask.m_luaExportHelper.ClearAllContextAndRes();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06020AAA RID: 133802 RVA: 0x00AEB5E0 File Offset: 0x00AE97E0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int StartRelogin(IntPtr l)
	{
		int result;
		try
		{
			ReloginUITask reloginUITask = (ReloginUITask)LuaObject.checkSelf(l);
			reloginUITask.m_luaExportHelper.StartRelogin();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06020AAB RID: 133803 RVA: 0x00AEB634 File Offset: 0x00AE9834
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int UpdateView(IntPtr l)
	{
		int result;
		try
		{
			ReloginUITask reloginUITask = (ReloginUITask)LuaObject.checkSelf(l);
			reloginUITask.m_luaExportHelper.UpdateView();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06020AAC RID: 133804 RVA: 0x00AEB688 File Offset: 0x00AE9888
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int ShowErrorMsg(IntPtr l)
	{
		int result;
		try
		{
			ReloginUITask reloginUITask = (ReloginUITask)LuaObject.checkSelf(l);
			string key;
			LuaObject.checkType(l, 2, out key);
			reloginUITask.m_luaExportHelper.ShowErrorMsg(key);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06020AAD RID: 133805 RVA: 0x00AEB6E4 File Offset: 0x00AE98E4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int OnRetryLoginButtonClicked(IntPtr l)
	{
		int result;
		try
		{
			ReloginUITask reloginUITask = (ReloginUITask)LuaObject.checkSelf(l);
			UIControllerBase ctrl;
			LuaObject.checkType<UIControllerBase>(l, 2, out ctrl);
			reloginUITask.m_luaExportHelper.OnRetryLoginButtonClicked(ctrl);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06020AAE RID: 133806 RVA: 0x00AEB740 File Offset: 0x00AE9940
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int OnReturnToLoginConfirmButtonClicked(IntPtr l)
	{
		int result;
		try
		{
			ReloginUITask reloginUITask = (ReloginUITask)LuaObject.checkSelf(l);
			UIControllerBase ctrl;
			LuaObject.checkType<UIControllerBase>(l, 2, out ctrl);
			reloginUITask.m_luaExportHelper.OnReturnToLoginConfirmButtonClicked(ctrl);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06020AAF RID: 133807 RVA: 0x00AEB79C File Offset: 0x00AE999C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_InitlizeBeforeManagerStartIt(IntPtr l)
	{
		int result;
		try
		{
			ReloginUITask reloginUITask = (ReloginUITask)LuaObject.checkSelf(l);
			reloginUITask.m_luaExportHelper.__callBase_InitlizeBeforeManagerStartIt();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06020AB0 RID: 133808 RVA: 0x00AEB7F0 File Offset: 0x00AE99F0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_OnStart(IntPtr l)
	{
		int result;
		try
		{
			ReloginUITask reloginUITask = (ReloginUITask)LuaObject.checkSelf(l);
			UIIntent intent;
			LuaObject.checkType<UIIntent>(l, 2, out intent);
			bool b = reloginUITask.m_luaExportHelper.__callBase_OnStart(intent);
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

	// Token: 0x06020AB1 RID: 133809 RVA: 0x00AEB858 File Offset: 0x00AE9A58
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_OnNewIntent(IntPtr l)
	{
		int result;
		try
		{
			ReloginUITask reloginUITask = (ReloginUITask)LuaObject.checkSelf(l);
			UIIntent intent;
			LuaObject.checkType<UIIntent>(l, 2, out intent);
			bool b = reloginUITask.m_luaExportHelper.__callBase_OnNewIntent(intent);
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

	// Token: 0x06020AB2 RID: 133810 RVA: 0x00AEB8C0 File Offset: 0x00AE9AC0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_OnStop(IntPtr l)
	{
		int result;
		try
		{
			ReloginUITask reloginUITask = (ReloginUITask)LuaObject.checkSelf(l);
			reloginUITask.m_luaExportHelper.__callBase_OnStop();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06020AB3 RID: 133811 RVA: 0x00AEB914 File Offset: 0x00AE9B14
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_StartRelogin(IntPtr l)
	{
		int result;
		try
		{
			ReloginUITask reloginUITask = (ReloginUITask)LuaObject.checkSelf(l);
			reloginUITask.m_luaExportHelper.__callBase_StartRelogin();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06020AB4 RID: 133812 RVA: 0x00AEB968 File Offset: 0x00AE9B68
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_ShowErrorMsg(IntPtr l)
	{
		int result;
		try
		{
			ReloginUITask reloginUITask = (ReloginUITask)LuaObject.checkSelf(l);
			string key;
			LuaObject.checkType(l, 2, out key);
			reloginUITask.m_luaExportHelper.__callBase_ShowErrorMsg(key);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06020AB5 RID: 133813 RVA: 0x00AEB9C4 File Offset: 0x00AE9BC4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_ShowWaitForReloginConfirmUI(IntPtr l)
	{
		int result;
		try
		{
			ReloginUITask reloginUITask = (ReloginUITask)LuaObject.checkSelf(l);
			reloginUITask.m_luaExportHelper.__callBase_ShowWaitForReloginConfirmUI();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06020AB6 RID: 133814 RVA: 0x00AEBA18 File Offset: 0x00AE9C18
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_ShowWaitForReloginProcessingUI(IntPtr l)
	{
		int result;
		try
		{
			ReloginUITask reloginUITask = (ReloginUITask)LuaObject.checkSelf(l);
			reloginUITask.m_luaExportHelper.__callBase_ShowWaitForReloginProcessingUI();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06020AB7 RID: 133815 RVA: 0x00AEBA6C File Offset: 0x00AE9C6C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_ShowWaitReturnToLoginConfirmUI(IntPtr l)
	{
		int result;
		try
		{
			ReloginUITask reloginUITask = (ReloginUITask)LuaObject.checkSelf(l);
			reloginUITask.m_luaExportHelper.__callBase_ShowWaitReturnToLoginConfirmUI();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06020AB8 RID: 133816 RVA: 0x00AEBAC0 File Offset: 0x00AE9CC0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_OnRetryLoginButtonClicked(IntPtr l)
	{
		int result;
		try
		{
			ReloginUITask reloginUITask = (ReloginUITask)LuaObject.checkSelf(l);
			UIControllerBase ctrl;
			LuaObject.checkType<UIControllerBase>(l, 2, out ctrl);
			reloginUITask.m_luaExportHelper.__callBase_OnRetryLoginButtonClicked(ctrl);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06020AB9 RID: 133817 RVA: 0x00AEBB1C File Offset: 0x00AE9D1C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_OnReturnToLoginConfirmButtonClicked(IntPtr l)
	{
		int result;
		try
		{
			ReloginUITask reloginUITask = (ReloginUITask)LuaObject.checkSelf(l);
			UIControllerBase ctrl;
			LuaObject.checkType<UIControllerBase>(l, 2, out ctrl);
			reloginUITask.m_luaExportHelper.__callBase_OnReturnToLoginConfirmButtonClicked(ctrl);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06020ABA RID: 133818 RVA: 0x00AEBB78 File Offset: 0x00AE9D78
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_IsNeedCheckLocalDataCache(IntPtr l)
	{
		int result;
		try
		{
			ReloginUITask reloginUITask = (ReloginUITask)LuaObject.checkSelf(l);
			bool b = reloginUITask.m_luaExportHelper.__callBase_IsNeedCheckLocalDataCache();
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

	// Token: 0x06020ABB RID: 133819 RVA: 0x00AEBBD4 File Offset: 0x00AE9DD4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_RegisterNetworkEvent(IntPtr l)
	{
		int result;
		try
		{
			ReloginUITask reloginUITask = (ReloginUITask)LuaObject.checkSelf(l);
			reloginUITask.m_luaExportHelper.__callBase_RegisterNetworkEvent();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06020ABC RID: 133820 RVA: 0x00AEBC28 File Offset: 0x00AE9E28
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_UnregisterNetworkEvent(IntPtr l)
	{
		int result;
		try
		{
			ReloginUITask reloginUITask = (ReloginUITask)LuaObject.checkSelf(l);
			reloginUITask.m_luaExportHelper.__callBase_UnregisterNetworkEvent();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06020ABD RID: 133821 RVA: 0x00AEBC7C File Offset: 0x00AE9E7C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_OnLoginBySessionTokenAck(IntPtr l)
	{
		int result2;
		try
		{
			ReloginUITask reloginUITask = (ReloginUITask)LuaObject.checkSelf(l);
			int result;
			LuaObject.checkType(l, 2, out result);
			bool b = reloginUITask.m_luaExportHelper.__callBase_OnLoginBySessionTokenAck(result);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, b);
			result2 = 2;
		}
		catch (Exception e)
		{
			result2 = LuaObject.error(l, e);
		}
		return result2;
	}

	// Token: 0x06020ABE RID: 133822 RVA: 0x00AEBCE4 File Offset: 0x00AE9EE4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_OnPlayerInfoInitAck(IntPtr l)
	{
		int result;
		try
		{
			ReloginUITask reloginUITask = (ReloginUITask)LuaObject.checkSelf(l);
			object msg;
			LuaObject.checkType<object>(l, 2, out msg);
			reloginUITask.m_luaExportHelper.__callBase_OnPlayerInfoInitAck(msg);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06020ABF RID: 133823 RVA: 0x00AEBD40 File Offset: 0x00AE9F40
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_OnPlayerInfoInitEnd(IntPtr l)
	{
		int result;
		try
		{
			ReloginUITask reloginUITask = (ReloginUITask)LuaObject.checkSelf(l);
			reloginUITask.m_luaExportHelper.__callBase_OnPlayerInfoInitEnd();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06020AC0 RID: 133824 RVA: 0x00AEBD94 File Offset: 0x00AE9F94
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_OnGameServerDataUnsyncNotify(IntPtr l)
	{
		int result;
		try
		{
			ReloginUITask reloginUITask = (ReloginUITask)LuaObject.checkSelf(l);
			reloginUITask.m_luaExportHelper.__callBase_OnGameServerDataUnsyncNotify();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06020AC1 RID: 133825 RVA: 0x00AEBDE8 File Offset: 0x00AE9FE8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_OnGameServerNetworkError(IntPtr l)
	{
		int result;
		try
		{
			ReloginUITask reloginUITask = (ReloginUITask)LuaObject.checkSelf(l);
			reloginUITask.m_luaExportHelper.__callBase_OnGameServerNetworkError();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06020AC2 RID: 133826 RVA: 0x00AEBE3C File Offset: 0x00AEA03C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_OnGameServerDisconnected(IntPtr l)
	{
		int result;
		try
		{
			ReloginUITask reloginUITask = (ReloginUITask)LuaObject.checkSelf(l);
			reloginUITask.m_luaExportHelper.__callBase_OnGameServerDisconnected();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06020AC3 RID: 133827 RVA: 0x00AEBE90 File Offset: 0x00AEA090
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callDele_s_prevReloginSuccessCallBack_s(IntPtr l)
	{
		int result;
		try
		{
			ReloginUITask.LuaExportHelper.__callDele_s_prevReloginSuccessCallBack();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06020AC4 RID: 133828 RVA: 0x00AEBED0 File Offset: 0x00AEA0D0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __clearDele_s_prevReloginSuccessCallBack_s(IntPtr l)
	{
		int result;
		try
		{
			ReloginUITask.LuaExportHelper.__clearDele_s_prevReloginSuccessCallBack();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06020AC5 RID: 133829 RVA: 0x00AEBF10 File Offset: 0x00AEA110
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_layerDescArray(IntPtr l)
	{
		int result;
		try
		{
			ReloginUITask reloginUITask = (ReloginUITask)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, reloginUITask.m_luaExportHelper.m_layerDescArray);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06020AC6 RID: 133830 RVA: 0x00AEBF68 File Offset: 0x00AEA168
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_layerDescArray(IntPtr l)
	{
		int result;
		try
		{
			ReloginUITask reloginUITask = (ReloginUITask)LuaObject.checkSelf(l);
			UITaskBase.LayerDesc[] layerDescArray;
			LuaObject.checkArray<UITaskBase.LayerDesc>(l, 2, out layerDescArray);
			reloginUITask.m_luaExportHelper.m_layerDescArray = layerDescArray;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06020AC7 RID: 133831 RVA: 0x00AEBFC4 File Offset: 0x00AEA1C4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_uiCtrlDescArray(IntPtr l)
	{
		int result;
		try
		{
			ReloginUITask reloginUITask = (ReloginUITask)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, reloginUITask.m_luaExportHelper.m_uiCtrlDescArray);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06020AC8 RID: 133832 RVA: 0x00AEC01C File Offset: 0x00AEA21C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_uiCtrlDescArray(IntPtr l)
	{
		int result;
		try
		{
			ReloginUITask reloginUITask = (ReloginUITask)LuaObject.checkSelf(l);
			UITaskBase.UIControllerDesc[] uiCtrlDescArray;
			LuaObject.checkArray<UITaskBase.UIControllerDesc>(l, 2, out uiCtrlDescArray);
			reloginUITask.m_luaExportHelper.m_uiCtrlDescArray = uiCtrlDescArray;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06020AC9 RID: 133833 RVA: 0x00AEC078 File Offset: 0x00AEA278
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_reloginUIController(IntPtr l)
	{
		int result;
		try
		{
			ReloginUITask reloginUITask = (ReloginUITask)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, reloginUITask.m_luaExportHelper.m_reloginUIController);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06020ACA RID: 133834 RVA: 0x00AEC0D0 File Offset: 0x00AEA2D0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_reloginUIController(IntPtr l)
	{
		int result;
		try
		{
			ReloginUITask reloginUITask = (ReloginUITask)LuaObject.checkSelf(l);
			ReloginUIController reloginUIController;
			LuaObject.checkType<ReloginUIController>(l, 2, out reloginUIController);
			reloginUITask.m_luaExportHelper.m_reloginUIController = reloginUIController;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06020ACB RID: 133835 RVA: 0x00AEC12C File Offset: 0x00AEA32C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_isAutoRelogin(IntPtr l)
	{
		int result;
		try
		{
			ReloginUITask reloginUITask = (ReloginUITask)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, reloginUITask.m_luaExportHelper.m_isAutoRelogin);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06020ACC RID: 133836 RVA: 0x00AEC184 File Offset: 0x00AEA384
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_isAutoRelogin(IntPtr l)
	{
		int result;
		try
		{
			ReloginUITask reloginUITask = (ReloginUITask)LuaObject.checkSelf(l);
			bool isAutoRelogin;
			LuaObject.checkType(l, 2, out isAutoRelogin);
			reloginUITask.m_luaExportHelper.m_isAutoRelogin = isAutoRelogin;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06020ACD RID: 133837 RVA: 0x00AEC1E0 File Offset: 0x00AEA3E0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_s_prevReloginSuccessCallBack(IntPtr l)
	{
		int result;
		try
		{
			Action action;
			int num = LuaObject.checkDelegate<Action>(l, 2, out action);
			if (num == 0)
			{
				ReloginUITask.LuaExportHelper.s_prevReloginSuccessCallBack = action;
			}
			else if (num == 1)
			{
				ReloginUITask.LuaExportHelper.s_prevReloginSuccessCallBack = (Action)Delegate.Combine(ReloginUITask.LuaExportHelper.s_prevReloginSuccessCallBack, action);
			}
			else if (num == 2)
			{
				ReloginUITask.LuaExportHelper.s_prevReloginSuccessCallBack = (Action)Delegate.Remove(ReloginUITask.LuaExportHelper.s_prevReloginSuccessCallBack, action);
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

	// Token: 0x06020ACE RID: 133838 RVA: 0x00AEC274 File Offset: 0x00AEA474
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_s_isEnable(IntPtr l)
	{
		int result;
		try
		{
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, ReloginUITask.LuaExportHelper.s_isEnable);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06020ACF RID: 133839 RVA: 0x00AEC2BC File Offset: 0x00AEA4BC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_s_isEnable(IntPtr l)
	{
		int result;
		try
		{
			bool s_isEnable;
			LuaObject.checkType(l, 2, out s_isEnable);
			ReloginUITask.LuaExportHelper.s_isEnable = s_isEnable;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06020AD0 RID: 133840 RVA: 0x00AEC308 File Offset: 0x00AEA508
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_Enable(IntPtr l)
	{
		int result;
		try
		{
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, ReloginUITask.Enable);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06020AD1 RID: 133841 RVA: 0x00AEC350 File Offset: 0x00AEA550
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_Enable(IntPtr l)
	{
		int result;
		try
		{
			bool enable;
			LuaObject.checkType(l, 2, out enable);
			ReloginUITask.Enable = enable;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06020AD2 RID: 133842 RVA: 0x00AEC39C File Offset: 0x00AEA59C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_LayerDescArray(IntPtr l)
	{
		int result;
		try
		{
			ReloginUITask reloginUITask = (ReloginUITask)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, reloginUITask.m_luaExportHelper.LayerDescArray);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06020AD3 RID: 133843 RVA: 0x00AEC3F4 File Offset: 0x00AEA5F4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_UICtrlDescArray(IntPtr l)
	{
		int result;
		try
		{
			ReloginUITask reloginUITask = (ReloginUITask)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, reloginUITask.m_luaExportHelper.UICtrlDescArray);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06020AD4 RID: 133844 RVA: 0x00AEC44C File Offset: 0x00AEA64C
	[Preserve]
	public static void reg(IntPtr l)
	{
		LuaObject.getTypeTable(l, "BlackJack.ProjectL.UI.ReloginUITask");
		if (Lua_BlackJack_ProjectL_UI_ReloginUITask.<>f__mg$cache0 == null)
		{
			Lua_BlackJack_ProjectL_UI_ReloginUITask.<>f__mg$cache0 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ReloginUITask.OnStart);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_ReloginUITask.<>f__mg$cache0);
		if (Lua_BlackJack_ProjectL_UI_ReloginUITask.<>f__mg$cache1 == null)
		{
			Lua_BlackJack_ProjectL_UI_ReloginUITask.<>f__mg$cache1 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ReloginUITask.InitAllUIControllers);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_ReloginUITask.<>f__mg$cache1);
		if (Lua_BlackJack_ProjectL_UI_ReloginUITask.<>f__mg$cache2 == null)
		{
			Lua_BlackJack_ProjectL_UI_ReloginUITask.<>f__mg$cache2 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ReloginUITask.ClearAllContextAndRes);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_ReloginUITask.<>f__mg$cache2);
		if (Lua_BlackJack_ProjectL_UI_ReloginUITask.<>f__mg$cache3 == null)
		{
			Lua_BlackJack_ProjectL_UI_ReloginUITask.<>f__mg$cache3 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ReloginUITask.StartRelogin);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_ReloginUITask.<>f__mg$cache3);
		if (Lua_BlackJack_ProjectL_UI_ReloginUITask.<>f__mg$cache4 == null)
		{
			Lua_BlackJack_ProjectL_UI_ReloginUITask.<>f__mg$cache4 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ReloginUITask.UpdateView);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_ReloginUITask.<>f__mg$cache4);
		if (Lua_BlackJack_ProjectL_UI_ReloginUITask.<>f__mg$cache5 == null)
		{
			Lua_BlackJack_ProjectL_UI_ReloginUITask.<>f__mg$cache5 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ReloginUITask.ShowErrorMsg);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_ReloginUITask.<>f__mg$cache5);
		if (Lua_BlackJack_ProjectL_UI_ReloginUITask.<>f__mg$cache6 == null)
		{
			Lua_BlackJack_ProjectL_UI_ReloginUITask.<>f__mg$cache6 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ReloginUITask.OnRetryLoginButtonClicked);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_ReloginUITask.<>f__mg$cache6);
		if (Lua_BlackJack_ProjectL_UI_ReloginUITask.<>f__mg$cache7 == null)
		{
			Lua_BlackJack_ProjectL_UI_ReloginUITask.<>f__mg$cache7 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ReloginUITask.OnReturnToLoginConfirmButtonClicked);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_ReloginUITask.<>f__mg$cache7);
		if (Lua_BlackJack_ProjectL_UI_ReloginUITask.<>f__mg$cache8 == null)
		{
			Lua_BlackJack_ProjectL_UI_ReloginUITask.<>f__mg$cache8 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ReloginUITask.__callBase_InitlizeBeforeManagerStartIt);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_ReloginUITask.<>f__mg$cache8);
		if (Lua_BlackJack_ProjectL_UI_ReloginUITask.<>f__mg$cache9 == null)
		{
			Lua_BlackJack_ProjectL_UI_ReloginUITask.<>f__mg$cache9 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ReloginUITask.__callBase_OnStart);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_ReloginUITask.<>f__mg$cache9);
		if (Lua_BlackJack_ProjectL_UI_ReloginUITask.<>f__mg$cacheA == null)
		{
			Lua_BlackJack_ProjectL_UI_ReloginUITask.<>f__mg$cacheA = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ReloginUITask.__callBase_OnNewIntent);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_ReloginUITask.<>f__mg$cacheA);
		if (Lua_BlackJack_ProjectL_UI_ReloginUITask.<>f__mg$cacheB == null)
		{
			Lua_BlackJack_ProjectL_UI_ReloginUITask.<>f__mg$cacheB = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ReloginUITask.__callBase_OnStop);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_ReloginUITask.<>f__mg$cacheB);
		if (Lua_BlackJack_ProjectL_UI_ReloginUITask.<>f__mg$cacheC == null)
		{
			Lua_BlackJack_ProjectL_UI_ReloginUITask.<>f__mg$cacheC = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ReloginUITask.__callBase_StartRelogin);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_ReloginUITask.<>f__mg$cacheC);
		if (Lua_BlackJack_ProjectL_UI_ReloginUITask.<>f__mg$cacheD == null)
		{
			Lua_BlackJack_ProjectL_UI_ReloginUITask.<>f__mg$cacheD = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ReloginUITask.__callBase_ShowErrorMsg);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_ReloginUITask.<>f__mg$cacheD);
		if (Lua_BlackJack_ProjectL_UI_ReloginUITask.<>f__mg$cacheE == null)
		{
			Lua_BlackJack_ProjectL_UI_ReloginUITask.<>f__mg$cacheE = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ReloginUITask.__callBase_ShowWaitForReloginConfirmUI);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_ReloginUITask.<>f__mg$cacheE);
		if (Lua_BlackJack_ProjectL_UI_ReloginUITask.<>f__mg$cacheF == null)
		{
			Lua_BlackJack_ProjectL_UI_ReloginUITask.<>f__mg$cacheF = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ReloginUITask.__callBase_ShowWaitForReloginProcessingUI);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_ReloginUITask.<>f__mg$cacheF);
		if (Lua_BlackJack_ProjectL_UI_ReloginUITask.<>f__mg$cache10 == null)
		{
			Lua_BlackJack_ProjectL_UI_ReloginUITask.<>f__mg$cache10 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ReloginUITask.__callBase_ShowWaitReturnToLoginConfirmUI);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_ReloginUITask.<>f__mg$cache10);
		if (Lua_BlackJack_ProjectL_UI_ReloginUITask.<>f__mg$cache11 == null)
		{
			Lua_BlackJack_ProjectL_UI_ReloginUITask.<>f__mg$cache11 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ReloginUITask.__callBase_OnRetryLoginButtonClicked);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_ReloginUITask.<>f__mg$cache11);
		if (Lua_BlackJack_ProjectL_UI_ReloginUITask.<>f__mg$cache12 == null)
		{
			Lua_BlackJack_ProjectL_UI_ReloginUITask.<>f__mg$cache12 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ReloginUITask.__callBase_OnReturnToLoginConfirmButtonClicked);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_ReloginUITask.<>f__mg$cache12);
		if (Lua_BlackJack_ProjectL_UI_ReloginUITask.<>f__mg$cache13 == null)
		{
			Lua_BlackJack_ProjectL_UI_ReloginUITask.<>f__mg$cache13 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ReloginUITask.__callBase_IsNeedCheckLocalDataCache);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_ReloginUITask.<>f__mg$cache13);
		if (Lua_BlackJack_ProjectL_UI_ReloginUITask.<>f__mg$cache14 == null)
		{
			Lua_BlackJack_ProjectL_UI_ReloginUITask.<>f__mg$cache14 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ReloginUITask.__callBase_RegisterNetworkEvent);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_ReloginUITask.<>f__mg$cache14);
		if (Lua_BlackJack_ProjectL_UI_ReloginUITask.<>f__mg$cache15 == null)
		{
			Lua_BlackJack_ProjectL_UI_ReloginUITask.<>f__mg$cache15 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ReloginUITask.__callBase_UnregisterNetworkEvent);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_ReloginUITask.<>f__mg$cache15);
		if (Lua_BlackJack_ProjectL_UI_ReloginUITask.<>f__mg$cache16 == null)
		{
			Lua_BlackJack_ProjectL_UI_ReloginUITask.<>f__mg$cache16 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ReloginUITask.__callBase_OnLoginBySessionTokenAck);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_ReloginUITask.<>f__mg$cache16);
		if (Lua_BlackJack_ProjectL_UI_ReloginUITask.<>f__mg$cache17 == null)
		{
			Lua_BlackJack_ProjectL_UI_ReloginUITask.<>f__mg$cache17 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ReloginUITask.__callBase_OnPlayerInfoInitAck);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_ReloginUITask.<>f__mg$cache17);
		if (Lua_BlackJack_ProjectL_UI_ReloginUITask.<>f__mg$cache18 == null)
		{
			Lua_BlackJack_ProjectL_UI_ReloginUITask.<>f__mg$cache18 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ReloginUITask.__callBase_OnPlayerInfoInitEnd);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_ReloginUITask.<>f__mg$cache18);
		if (Lua_BlackJack_ProjectL_UI_ReloginUITask.<>f__mg$cache19 == null)
		{
			Lua_BlackJack_ProjectL_UI_ReloginUITask.<>f__mg$cache19 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ReloginUITask.__callBase_OnGameServerDataUnsyncNotify);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_ReloginUITask.<>f__mg$cache19);
		if (Lua_BlackJack_ProjectL_UI_ReloginUITask.<>f__mg$cache1A == null)
		{
			Lua_BlackJack_ProjectL_UI_ReloginUITask.<>f__mg$cache1A = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ReloginUITask.__callBase_OnGameServerNetworkError);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_ReloginUITask.<>f__mg$cache1A);
		if (Lua_BlackJack_ProjectL_UI_ReloginUITask.<>f__mg$cache1B == null)
		{
			Lua_BlackJack_ProjectL_UI_ReloginUITask.<>f__mg$cache1B = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ReloginUITask.__callBase_OnGameServerDisconnected);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_ReloginUITask.<>f__mg$cache1B);
		if (Lua_BlackJack_ProjectL_UI_ReloginUITask.<>f__mg$cache1C == null)
		{
			Lua_BlackJack_ProjectL_UI_ReloginUITask.<>f__mg$cache1C = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ReloginUITask.__callDele_s_prevReloginSuccessCallBack_s);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_ReloginUITask.<>f__mg$cache1C);
		if (Lua_BlackJack_ProjectL_UI_ReloginUITask.<>f__mg$cache1D == null)
		{
			Lua_BlackJack_ProjectL_UI_ReloginUITask.<>f__mg$cache1D = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ReloginUITask.__clearDele_s_prevReloginSuccessCallBack_s);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_ReloginUITask.<>f__mg$cache1D);
		string name = "m_layerDescArray";
		if (Lua_BlackJack_ProjectL_UI_ReloginUITask.<>f__mg$cache1E == null)
		{
			Lua_BlackJack_ProjectL_UI_ReloginUITask.<>f__mg$cache1E = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ReloginUITask.get_m_layerDescArray);
		}
		LuaCSFunction get = Lua_BlackJack_ProjectL_UI_ReloginUITask.<>f__mg$cache1E;
		if (Lua_BlackJack_ProjectL_UI_ReloginUITask.<>f__mg$cache1F == null)
		{
			Lua_BlackJack_ProjectL_UI_ReloginUITask.<>f__mg$cache1F = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ReloginUITask.set_m_layerDescArray);
		}
		LuaObject.addMember(l, name, get, Lua_BlackJack_ProjectL_UI_ReloginUITask.<>f__mg$cache1F, true);
		string name2 = "m_uiCtrlDescArray";
		if (Lua_BlackJack_ProjectL_UI_ReloginUITask.<>f__mg$cache20 == null)
		{
			Lua_BlackJack_ProjectL_UI_ReloginUITask.<>f__mg$cache20 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ReloginUITask.get_m_uiCtrlDescArray);
		}
		LuaCSFunction get2 = Lua_BlackJack_ProjectL_UI_ReloginUITask.<>f__mg$cache20;
		if (Lua_BlackJack_ProjectL_UI_ReloginUITask.<>f__mg$cache21 == null)
		{
			Lua_BlackJack_ProjectL_UI_ReloginUITask.<>f__mg$cache21 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ReloginUITask.set_m_uiCtrlDescArray);
		}
		LuaObject.addMember(l, name2, get2, Lua_BlackJack_ProjectL_UI_ReloginUITask.<>f__mg$cache21, true);
		string name3 = "m_reloginUIController";
		if (Lua_BlackJack_ProjectL_UI_ReloginUITask.<>f__mg$cache22 == null)
		{
			Lua_BlackJack_ProjectL_UI_ReloginUITask.<>f__mg$cache22 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ReloginUITask.get_m_reloginUIController);
		}
		LuaCSFunction get3 = Lua_BlackJack_ProjectL_UI_ReloginUITask.<>f__mg$cache22;
		if (Lua_BlackJack_ProjectL_UI_ReloginUITask.<>f__mg$cache23 == null)
		{
			Lua_BlackJack_ProjectL_UI_ReloginUITask.<>f__mg$cache23 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ReloginUITask.set_m_reloginUIController);
		}
		LuaObject.addMember(l, name3, get3, Lua_BlackJack_ProjectL_UI_ReloginUITask.<>f__mg$cache23, true);
		string name4 = "m_isAutoRelogin";
		if (Lua_BlackJack_ProjectL_UI_ReloginUITask.<>f__mg$cache24 == null)
		{
			Lua_BlackJack_ProjectL_UI_ReloginUITask.<>f__mg$cache24 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ReloginUITask.get_m_isAutoRelogin);
		}
		LuaCSFunction get4 = Lua_BlackJack_ProjectL_UI_ReloginUITask.<>f__mg$cache24;
		if (Lua_BlackJack_ProjectL_UI_ReloginUITask.<>f__mg$cache25 == null)
		{
			Lua_BlackJack_ProjectL_UI_ReloginUITask.<>f__mg$cache25 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ReloginUITask.set_m_isAutoRelogin);
		}
		LuaObject.addMember(l, name4, get4, Lua_BlackJack_ProjectL_UI_ReloginUITask.<>f__mg$cache25, true);
		string name5 = "s_prevReloginSuccessCallBack";
		LuaCSFunction get5 = null;
		if (Lua_BlackJack_ProjectL_UI_ReloginUITask.<>f__mg$cache26 == null)
		{
			Lua_BlackJack_ProjectL_UI_ReloginUITask.<>f__mg$cache26 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ReloginUITask.set_s_prevReloginSuccessCallBack);
		}
		LuaObject.addMember(l, name5, get5, Lua_BlackJack_ProjectL_UI_ReloginUITask.<>f__mg$cache26, false);
		string name6 = "s_isEnable";
		if (Lua_BlackJack_ProjectL_UI_ReloginUITask.<>f__mg$cache27 == null)
		{
			Lua_BlackJack_ProjectL_UI_ReloginUITask.<>f__mg$cache27 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ReloginUITask.get_s_isEnable);
		}
		LuaCSFunction get6 = Lua_BlackJack_ProjectL_UI_ReloginUITask.<>f__mg$cache27;
		if (Lua_BlackJack_ProjectL_UI_ReloginUITask.<>f__mg$cache28 == null)
		{
			Lua_BlackJack_ProjectL_UI_ReloginUITask.<>f__mg$cache28 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ReloginUITask.set_s_isEnable);
		}
		LuaObject.addMember(l, name6, get6, Lua_BlackJack_ProjectL_UI_ReloginUITask.<>f__mg$cache28, false);
		string name7 = "Enable";
		if (Lua_BlackJack_ProjectL_UI_ReloginUITask.<>f__mg$cache29 == null)
		{
			Lua_BlackJack_ProjectL_UI_ReloginUITask.<>f__mg$cache29 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ReloginUITask.get_Enable);
		}
		LuaCSFunction get7 = Lua_BlackJack_ProjectL_UI_ReloginUITask.<>f__mg$cache29;
		if (Lua_BlackJack_ProjectL_UI_ReloginUITask.<>f__mg$cache2A == null)
		{
			Lua_BlackJack_ProjectL_UI_ReloginUITask.<>f__mg$cache2A = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ReloginUITask.set_Enable);
		}
		LuaObject.addMember(l, name7, get7, Lua_BlackJack_ProjectL_UI_ReloginUITask.<>f__mg$cache2A, false);
		string name8 = "LayerDescArray";
		if (Lua_BlackJack_ProjectL_UI_ReloginUITask.<>f__mg$cache2B == null)
		{
			Lua_BlackJack_ProjectL_UI_ReloginUITask.<>f__mg$cache2B = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ReloginUITask.get_LayerDescArray);
		}
		LuaObject.addMember(l, name8, Lua_BlackJack_ProjectL_UI_ReloginUITask.<>f__mg$cache2B, null, true);
		string name9 = "UICtrlDescArray";
		if (Lua_BlackJack_ProjectL_UI_ReloginUITask.<>f__mg$cache2C == null)
		{
			Lua_BlackJack_ProjectL_UI_ReloginUITask.<>f__mg$cache2C = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ReloginUITask.get_UICtrlDescArray);
		}
		LuaObject.addMember(l, name9, Lua_BlackJack_ProjectL_UI_ReloginUITask.<>f__mg$cache2C, null, true);
		if (Lua_BlackJack_ProjectL_UI_ReloginUITask.<>f__mg$cache2D == null)
		{
			Lua_BlackJack_ProjectL_UI_ReloginUITask.<>f__mg$cache2D = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ReloginUITask.constructor);
		}
		LuaObject.createTypeMetatable(l, Lua_BlackJack_ProjectL_UI_ReloginUITask.<>f__mg$cache2D, typeof(ReloginUITask), typeof(ReloginBySessionUITaskBase));
	}

	// Token: 0x040169D6 RID: 92630
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache0;

	// Token: 0x040169D7 RID: 92631
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1;

	// Token: 0x040169D8 RID: 92632
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2;

	// Token: 0x040169D9 RID: 92633
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3;

	// Token: 0x040169DA RID: 92634
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache4;

	// Token: 0x040169DB RID: 92635
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache5;

	// Token: 0x040169DC RID: 92636
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache6;

	// Token: 0x040169DD RID: 92637
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache7;

	// Token: 0x040169DE RID: 92638
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache8;

	// Token: 0x040169DF RID: 92639
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache9;

	// Token: 0x040169E0 RID: 92640
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheA;

	// Token: 0x040169E1 RID: 92641
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheB;

	// Token: 0x040169E2 RID: 92642
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheC;

	// Token: 0x040169E3 RID: 92643
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheD;

	// Token: 0x040169E4 RID: 92644
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheE;

	// Token: 0x040169E5 RID: 92645
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheF;

	// Token: 0x040169E6 RID: 92646
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache10;

	// Token: 0x040169E7 RID: 92647
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache11;

	// Token: 0x040169E8 RID: 92648
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache12;

	// Token: 0x040169E9 RID: 92649
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache13;

	// Token: 0x040169EA RID: 92650
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache14;

	// Token: 0x040169EB RID: 92651
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache15;

	// Token: 0x040169EC RID: 92652
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache16;

	// Token: 0x040169ED RID: 92653
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache17;

	// Token: 0x040169EE RID: 92654
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache18;

	// Token: 0x040169EF RID: 92655
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache19;

	// Token: 0x040169F0 RID: 92656
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1A;

	// Token: 0x040169F1 RID: 92657
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1B;

	// Token: 0x040169F2 RID: 92658
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1C;

	// Token: 0x040169F3 RID: 92659
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1D;

	// Token: 0x040169F4 RID: 92660
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1E;

	// Token: 0x040169F5 RID: 92661
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1F;

	// Token: 0x040169F6 RID: 92662
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache20;

	// Token: 0x040169F7 RID: 92663
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache21;

	// Token: 0x040169F8 RID: 92664
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache22;

	// Token: 0x040169F9 RID: 92665
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache23;

	// Token: 0x040169FA RID: 92666
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache24;

	// Token: 0x040169FB RID: 92667
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache25;

	// Token: 0x040169FC RID: 92668
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache26;

	// Token: 0x040169FD RID: 92669
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache27;

	// Token: 0x040169FE RID: 92670
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache28;

	// Token: 0x040169FF RID: 92671
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache29;

	// Token: 0x04016A00 RID: 92672
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2A;

	// Token: 0x04016A01 RID: 92673
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2B;

	// Token: 0x04016A02 RID: 92674
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2C;

	// Token: 0x04016A03 RID: 92675
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2D;
}
