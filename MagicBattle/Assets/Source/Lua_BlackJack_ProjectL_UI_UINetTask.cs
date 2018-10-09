using System;
using System.Runtime.CompilerServices;
using BlackJack.BJFramework.Runtime.TaskNs;
using BlackJack.BJFramework.Runtime.UI;
using BlackJack.ProjectL.UI;
using SLua;
using UnityEngine.Scripting;

// Token: 0x020015C1 RID: 5569
[Preserve]
public class Lua_BlackJack_ProjectL_UI_UINetTask : LuaObject
{
	// Token: 0x06021DD9 RID: 138713 RVA: 0x00B84BE0 File Offset: 0x00B82DE0
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
			UINetTask o = new UINetTask(timeout, blockedUITask, autoRetry);
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

	// Token: 0x06021DDA RID: 138714 RVA: 0x00B84C50 File Offset: 0x00B82E50
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int OnStart(IntPtr l)
	{
		int result;
		try
		{
			UINetTask uinetTask = (UINetTask)LuaObject.checkSelf(l);
			object param;
			LuaObject.checkType<object>(l, 2, out param);
			bool b = uinetTask.m_luaExportHelper.OnStart(param);
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

	// Token: 0x06021DDB RID: 138715 RVA: 0x00B84CB8 File Offset: 0x00B82EB8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int OnStop(IntPtr l)
	{
		int result;
		try
		{
			UINetTask uinetTask = (UINetTask)LuaObject.checkSelf(l);
			uinetTask.m_luaExportHelper.OnStop();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06021DDC RID: 138716 RVA: 0x00B84D0C File Offset: 0x00B82F0C
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int OnTimeOut(IntPtr l)
	{
		int result;
		try
		{
			UINetTask uinetTask = (UINetTask)LuaObject.checkSelf(l);
			uinetTask.m_luaExportHelper.OnTimeOut();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06021DDD RID: 138717 RVA: 0x00B84D60 File Offset: 0x00B82F60
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int OnReLoginSuccess(IntPtr l)
	{
		int result;
		try
		{
			UINetTask uinetTask = (UINetTask)LuaObject.checkSelf(l);
			uinetTask.m_luaExportHelper.OnReLoginSuccess();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06021DDE RID: 138718 RVA: 0x00B84DB4 File Offset: 0x00B82FB4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_OnStart(IntPtr l)
	{
		int result;
		try
		{
			UINetTask uinetTask = (UINetTask)LuaObject.checkSelf(l);
			object param;
			LuaObject.checkType<object>(l, 2, out param);
			bool b = uinetTask.m_luaExportHelper.__callBase_OnStart(param);
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

	// Token: 0x06021DDF RID: 138719 RVA: 0x00B84E1C File Offset: 0x00B8301C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_OnStop(IntPtr l)
	{
		int result;
		try
		{
			UINetTask uinetTask = (UINetTask)LuaObject.checkSelf(l);
			uinetTask.m_luaExportHelper.__callBase_OnStop();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06021DE0 RID: 138720 RVA: 0x00B84E70 File Offset: 0x00B83070
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_OnPause(IntPtr l)
	{
		int result;
		try
		{
			UINetTask uinetTask = (UINetTask)LuaObject.checkSelf(l);
			uinetTask.m_luaExportHelper.__callBase_OnPause();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06021DE1 RID: 138721 RVA: 0x00B84EC4 File Offset: 0x00B830C4
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int __callBase_OnResume(IntPtr l)
	{
		int result;
		try
		{
			UINetTask uinetTask = (UINetTask)LuaObject.checkSelf(l);
			object param;
			LuaObject.checkType<object>(l, 2, out param);
			bool b = uinetTask.m_luaExportHelper.__callBase_OnResume(param);
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

	// Token: 0x06021DE2 RID: 138722 RVA: 0x00B84F2C File Offset: 0x00B8312C
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int __callBase_StartNetWorking(IntPtr l)
	{
		int result;
		try
		{
			UINetTask uinetTask = (UINetTask)LuaObject.checkSelf(l);
			bool b = uinetTask.m_luaExportHelper.__callBase_StartNetWorking();
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

	// Token: 0x06021DE3 RID: 138723 RVA: 0x00B84F88 File Offset: 0x00B83188
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int __callBase_OnTransactionComplete(IntPtr l)
	{
		int result;
		try
		{
			UINetTask uinetTask = (UINetTask)LuaObject.checkSelf(l);
			uinetTask.m_luaExportHelper.__callBase_OnTransactionComplete();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06021DE4 RID: 138724 RVA: 0x00B84FDC File Offset: 0x00B831DC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_RegisterNetworkEvent(IntPtr l)
	{
		int result;
		try
		{
			UINetTask uinetTask = (UINetTask)LuaObject.checkSelf(l);
			uinetTask.m_luaExportHelper.__callBase_RegisterNetworkEvent();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06021DE5 RID: 138725 RVA: 0x00B85030 File Offset: 0x00B83230
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int __callBase_UnregisterNetworkEvent(IntPtr l)
	{
		int result;
		try
		{
			UINetTask uinetTask = (UINetTask)LuaObject.checkSelf(l);
			uinetTask.m_luaExportHelper.__callBase_UnregisterNetworkEvent();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06021DE6 RID: 138726 RVA: 0x00B85084 File Offset: 0x00B83284
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int __callBase_OnTick(IntPtr l)
	{
		int result;
		try
		{
			UINetTask uinetTask = (UINetTask)LuaObject.checkSelf(l);
			uinetTask.m_luaExportHelper.__callBase_OnTick();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06021DE7 RID: 138727 RVA: 0x00B850D8 File Offset: 0x00B832D8
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int __callBase_OnTimeOut(IntPtr l)
	{
		int result;
		try
		{
			UINetTask uinetTask = (UINetTask)LuaObject.checkSelf(l);
			uinetTask.m_luaExportHelper.__callBase_OnTimeOut();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06021DE8 RID: 138728 RVA: 0x00B8512C File Offset: 0x00B8332C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_OnGameServerDataUnsyncNotify(IntPtr l)
	{
		int result;
		try
		{
			UINetTask uinetTask = (UINetTask)LuaObject.checkSelf(l);
			uinetTask.m_luaExportHelper.__callBase_OnGameServerDataUnsyncNotify();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06021DE9 RID: 138729 RVA: 0x00B85180 File Offset: 0x00B83380
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_OnGameServerNetworkError(IntPtr l)
	{
		int result;
		try
		{
			UINetTask uinetTask = (UINetTask)LuaObject.checkSelf(l);
			uinetTask.m_luaExportHelper.__callBase_OnGameServerNetworkError();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06021DEA RID: 138730 RVA: 0x00B851D4 File Offset: 0x00B833D4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_OnGameServerDisconnected(IntPtr l)
	{
		int result;
		try
		{
			UINetTask uinetTask = (UINetTask)LuaObject.checkSelf(l);
			uinetTask.m_luaExportHelper.__callBase_OnGameServerDisconnected();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06021DEB RID: 138731 RVA: 0x00B85228 File Offset: 0x00B83428
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_OnNetworkError(IntPtr l)
	{
		int result;
		try
		{
			UINetTask uinetTask = (UINetTask)LuaObject.checkSelf(l);
			uinetTask.m_luaExportHelper.__callBase_OnNetworkError();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06021DEC RID: 138732 RVA: 0x00B8527C File Offset: 0x00B8347C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_OnReLoginSuccess(IntPtr l)
	{
		int result;
		try
		{
			UINetTask uinetTask = (UINetTask)LuaObject.checkSelf(l);
			uinetTask.m_luaExportHelper.__callBase_OnReLoginSuccess();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06021DED RID: 138733 RVA: 0x00B852D0 File Offset: 0x00B834D0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_OnUIManagerReturnToLoginUI(IntPtr l)
	{
		int result;
		try
		{
			UINetTask uinetTask = (UINetTask)LuaObject.checkSelf(l);
			bool obj;
			LuaObject.checkType(l, 2, out obj);
			uinetTask.m_luaExportHelper.__callBase_OnUIManagerReturnToLoginUI(obj);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06021DEE RID: 138734 RVA: 0x00B8532C File Offset: 0x00B8352C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_isDisableInput(IntPtr l)
	{
		int result;
		try
		{
			UINetTask uinetTask = (UINetTask)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, uinetTask.m_luaExportHelper.m_isDisableInput);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06021DEF RID: 138735 RVA: 0x00B85384 File Offset: 0x00B83584
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_isDisableInput(IntPtr l)
	{
		int result;
		try
		{
			UINetTask uinetTask = (UINetTask)LuaObject.checkSelf(l);
			bool isDisableInput;
			LuaObject.checkType(l, 2, out isDisableInput);
			uinetTask.m_luaExportHelper.m_isDisableInput = isDisableInput;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06021DF0 RID: 138736 RVA: 0x00B853E0 File Offset: 0x00B835E0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_Result(IntPtr l)
	{
		int result;
		try
		{
			UINetTask uinetTask = (UINetTask)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, uinetTask.Result);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06021DF1 RID: 138737 RVA: 0x00B85434 File Offset: 0x00B83634
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_Result(IntPtr l)
	{
		int result2;
		try
		{
			UINetTask uinetTask = (UINetTask)LuaObject.checkSelf(l);
			int result;
			LuaObject.checkType(l, 2, out result);
			uinetTask.m_luaExportHelper.Result = result;
			LuaObject.pushValue(l, true);
			result2 = 1;
		}
		catch (Exception e)
		{
			result2 = LuaObject.error(l, e);
		}
		return result2;
	}

	// Token: 0x06021DF2 RID: 138738 RVA: 0x00B85490 File Offset: 0x00B83690
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_IsReloginSuccess(IntPtr l)
	{
		int result;
		try
		{
			UINetTask uinetTask = (UINetTask)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, uinetTask.IsReloginSuccess);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06021DF3 RID: 138739 RVA: 0x00B854E4 File Offset: 0x00B836E4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_IsReloginSuccess(IntPtr l)
	{
		int result;
		try
		{
			UINetTask uinetTask = (UINetTask)LuaObject.checkSelf(l);
			bool isReloginSuccess;
			LuaObject.checkType(l, 2, out isReloginSuccess);
			uinetTask.m_luaExportHelper.IsReloginSuccess = isReloginSuccess;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06021DF4 RID: 138740 RVA: 0x00B85540 File Offset: 0x00B83740
	[Preserve]
	public static void reg(IntPtr l)
	{
		LuaObject.getTypeTable(l, "BlackJack.ProjectL.UI.UINetTask");
		if (Lua_BlackJack_ProjectL_UI_UINetTask.<>f__mg$cache0 == null)
		{
			Lua_BlackJack_ProjectL_UI_UINetTask.<>f__mg$cache0 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_UINetTask.OnStart);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_UINetTask.<>f__mg$cache0);
		if (Lua_BlackJack_ProjectL_UI_UINetTask.<>f__mg$cache1 == null)
		{
			Lua_BlackJack_ProjectL_UI_UINetTask.<>f__mg$cache1 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_UINetTask.OnStop);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_UINetTask.<>f__mg$cache1);
		if (Lua_BlackJack_ProjectL_UI_UINetTask.<>f__mg$cache2 == null)
		{
			Lua_BlackJack_ProjectL_UI_UINetTask.<>f__mg$cache2 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_UINetTask.OnTimeOut);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_UINetTask.<>f__mg$cache2);
		if (Lua_BlackJack_ProjectL_UI_UINetTask.<>f__mg$cache3 == null)
		{
			Lua_BlackJack_ProjectL_UI_UINetTask.<>f__mg$cache3 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_UINetTask.OnReLoginSuccess);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_UINetTask.<>f__mg$cache3);
		if (Lua_BlackJack_ProjectL_UI_UINetTask.<>f__mg$cache4 == null)
		{
			Lua_BlackJack_ProjectL_UI_UINetTask.<>f__mg$cache4 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_UINetTask.__callBase_OnStart);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_UINetTask.<>f__mg$cache4);
		if (Lua_BlackJack_ProjectL_UI_UINetTask.<>f__mg$cache5 == null)
		{
			Lua_BlackJack_ProjectL_UI_UINetTask.<>f__mg$cache5 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_UINetTask.__callBase_OnStop);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_UINetTask.<>f__mg$cache5);
		if (Lua_BlackJack_ProjectL_UI_UINetTask.<>f__mg$cache6 == null)
		{
			Lua_BlackJack_ProjectL_UI_UINetTask.<>f__mg$cache6 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_UINetTask.__callBase_OnPause);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_UINetTask.<>f__mg$cache6);
		if (Lua_BlackJack_ProjectL_UI_UINetTask.<>f__mg$cache7 == null)
		{
			Lua_BlackJack_ProjectL_UI_UINetTask.<>f__mg$cache7 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_UINetTask.__callBase_OnResume);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_UINetTask.<>f__mg$cache7);
		if (Lua_BlackJack_ProjectL_UI_UINetTask.<>f__mg$cache8 == null)
		{
			Lua_BlackJack_ProjectL_UI_UINetTask.<>f__mg$cache8 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_UINetTask.__callBase_StartNetWorking);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_UINetTask.<>f__mg$cache8);
		if (Lua_BlackJack_ProjectL_UI_UINetTask.<>f__mg$cache9 == null)
		{
			Lua_BlackJack_ProjectL_UI_UINetTask.<>f__mg$cache9 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_UINetTask.__callBase_OnTransactionComplete);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_UINetTask.<>f__mg$cache9);
		if (Lua_BlackJack_ProjectL_UI_UINetTask.<>f__mg$cacheA == null)
		{
			Lua_BlackJack_ProjectL_UI_UINetTask.<>f__mg$cacheA = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_UINetTask.__callBase_RegisterNetworkEvent);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_UINetTask.<>f__mg$cacheA);
		if (Lua_BlackJack_ProjectL_UI_UINetTask.<>f__mg$cacheB == null)
		{
			Lua_BlackJack_ProjectL_UI_UINetTask.<>f__mg$cacheB = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_UINetTask.__callBase_UnregisterNetworkEvent);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_UINetTask.<>f__mg$cacheB);
		if (Lua_BlackJack_ProjectL_UI_UINetTask.<>f__mg$cacheC == null)
		{
			Lua_BlackJack_ProjectL_UI_UINetTask.<>f__mg$cacheC = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_UINetTask.__callBase_OnTick);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_UINetTask.<>f__mg$cacheC);
		if (Lua_BlackJack_ProjectL_UI_UINetTask.<>f__mg$cacheD == null)
		{
			Lua_BlackJack_ProjectL_UI_UINetTask.<>f__mg$cacheD = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_UINetTask.__callBase_OnTimeOut);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_UINetTask.<>f__mg$cacheD);
		if (Lua_BlackJack_ProjectL_UI_UINetTask.<>f__mg$cacheE == null)
		{
			Lua_BlackJack_ProjectL_UI_UINetTask.<>f__mg$cacheE = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_UINetTask.__callBase_OnGameServerDataUnsyncNotify);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_UINetTask.<>f__mg$cacheE);
		if (Lua_BlackJack_ProjectL_UI_UINetTask.<>f__mg$cacheF == null)
		{
			Lua_BlackJack_ProjectL_UI_UINetTask.<>f__mg$cacheF = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_UINetTask.__callBase_OnGameServerNetworkError);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_UINetTask.<>f__mg$cacheF);
		if (Lua_BlackJack_ProjectL_UI_UINetTask.<>f__mg$cache10 == null)
		{
			Lua_BlackJack_ProjectL_UI_UINetTask.<>f__mg$cache10 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_UINetTask.__callBase_OnGameServerDisconnected);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_UINetTask.<>f__mg$cache10);
		if (Lua_BlackJack_ProjectL_UI_UINetTask.<>f__mg$cache11 == null)
		{
			Lua_BlackJack_ProjectL_UI_UINetTask.<>f__mg$cache11 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_UINetTask.__callBase_OnNetworkError);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_UINetTask.<>f__mg$cache11);
		if (Lua_BlackJack_ProjectL_UI_UINetTask.<>f__mg$cache12 == null)
		{
			Lua_BlackJack_ProjectL_UI_UINetTask.<>f__mg$cache12 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_UINetTask.__callBase_OnReLoginSuccess);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_UINetTask.<>f__mg$cache12);
		if (Lua_BlackJack_ProjectL_UI_UINetTask.<>f__mg$cache13 == null)
		{
			Lua_BlackJack_ProjectL_UI_UINetTask.<>f__mg$cache13 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_UINetTask.__callBase_OnUIManagerReturnToLoginUI);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_UINetTask.<>f__mg$cache13);
		string name = "m_isDisableInput";
		if (Lua_BlackJack_ProjectL_UI_UINetTask.<>f__mg$cache14 == null)
		{
			Lua_BlackJack_ProjectL_UI_UINetTask.<>f__mg$cache14 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_UINetTask.get_m_isDisableInput);
		}
		LuaCSFunction get = Lua_BlackJack_ProjectL_UI_UINetTask.<>f__mg$cache14;
		if (Lua_BlackJack_ProjectL_UI_UINetTask.<>f__mg$cache15 == null)
		{
			Lua_BlackJack_ProjectL_UI_UINetTask.<>f__mg$cache15 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_UINetTask.set_m_isDisableInput);
		}
		LuaObject.addMember(l, name, get, Lua_BlackJack_ProjectL_UI_UINetTask.<>f__mg$cache15, true);
		string name2 = "Result";
		if (Lua_BlackJack_ProjectL_UI_UINetTask.<>f__mg$cache16 == null)
		{
			Lua_BlackJack_ProjectL_UI_UINetTask.<>f__mg$cache16 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_UINetTask.get_Result);
		}
		LuaCSFunction get2 = Lua_BlackJack_ProjectL_UI_UINetTask.<>f__mg$cache16;
		if (Lua_BlackJack_ProjectL_UI_UINetTask.<>f__mg$cache17 == null)
		{
			Lua_BlackJack_ProjectL_UI_UINetTask.<>f__mg$cache17 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_UINetTask.set_Result);
		}
		LuaObject.addMember(l, name2, get2, Lua_BlackJack_ProjectL_UI_UINetTask.<>f__mg$cache17, true);
		string name3 = "IsReloginSuccess";
		if (Lua_BlackJack_ProjectL_UI_UINetTask.<>f__mg$cache18 == null)
		{
			Lua_BlackJack_ProjectL_UI_UINetTask.<>f__mg$cache18 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_UINetTask.get_IsReloginSuccess);
		}
		LuaCSFunction get3 = Lua_BlackJack_ProjectL_UI_UINetTask.<>f__mg$cache18;
		if (Lua_BlackJack_ProjectL_UI_UINetTask.<>f__mg$cache19 == null)
		{
			Lua_BlackJack_ProjectL_UI_UINetTask.<>f__mg$cache19 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_UINetTask.set_IsReloginSuccess);
		}
		LuaObject.addMember(l, name3, get3, Lua_BlackJack_ProjectL_UI_UINetTask.<>f__mg$cache19, true);
		if (Lua_BlackJack_ProjectL_UI_UINetTask.<>f__mg$cache1A == null)
		{
			Lua_BlackJack_ProjectL_UI_UINetTask.<>f__mg$cache1A = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_UINetTask.constructor);
		}
		LuaObject.createTypeMetatable(l, Lua_BlackJack_ProjectL_UI_UINetTask.<>f__mg$cache1A, typeof(UINetTask), typeof(NetWorkTransactionTask));
	}

	// Token: 0x04017C39 RID: 97337
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache0;

	// Token: 0x04017C3A RID: 97338
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1;

	// Token: 0x04017C3B RID: 97339
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2;

	// Token: 0x04017C3C RID: 97340
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3;

	// Token: 0x04017C3D RID: 97341
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache4;

	// Token: 0x04017C3E RID: 97342
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache5;

	// Token: 0x04017C3F RID: 97343
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache6;

	// Token: 0x04017C40 RID: 97344
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache7;

	// Token: 0x04017C41 RID: 97345
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache8;

	// Token: 0x04017C42 RID: 97346
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache9;

	// Token: 0x04017C43 RID: 97347
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheA;

	// Token: 0x04017C44 RID: 97348
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheB;

	// Token: 0x04017C45 RID: 97349
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheC;

	// Token: 0x04017C46 RID: 97350
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheD;

	// Token: 0x04017C47 RID: 97351
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheE;

	// Token: 0x04017C48 RID: 97352
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheF;

	// Token: 0x04017C49 RID: 97353
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache10;

	// Token: 0x04017C4A RID: 97354
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache11;

	// Token: 0x04017C4B RID: 97355
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache12;

	// Token: 0x04017C4C RID: 97356
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache13;

	// Token: 0x04017C4D RID: 97357
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache14;

	// Token: 0x04017C4E RID: 97358
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache15;

	// Token: 0x04017C4F RID: 97359
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache16;

	// Token: 0x04017C50 RID: 97360
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache17;

	// Token: 0x04017C51 RID: 97361
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache18;

	// Token: 0x04017C52 RID: 97362
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache19;

	// Token: 0x04017C53 RID: 97363
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1A;
}
