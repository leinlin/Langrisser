using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using BlackJack.BJFramework.Runtime.UI;
using BlackJack.ConfigData;
using BlackJack.ProjectL.UI;
using SLua;
using UnityEngine.Scripting;

// Token: 0x020015AE RID: 5550
[Preserve]
public class Lua_BlackJack_ProjectL_UI_TestUITask : LuaObject
{
	// Token: 0x06021B25 RID: 138021 RVA: 0x00B6F954 File Offset: 0x00B6DB54
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int constructor(IntPtr l)
	{
		int result;
		try
		{
			string name;
			LuaObject.checkType(l, 2, out name);
			TestUITask o = new TestUITask(name);
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

	// Token: 0x06021B26 RID: 138022 RVA: 0x00B6F9A8 File Offset: 0x00B6DBA8
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int ReportBug_s(IntPtr l)
	{
		int result;
		try
		{
			string bugDesc;
			LuaObject.checkType(l, 1, out bugDesc);
			double logFileHours;
			LuaObject.checkType(l, 2, out logFileHours);
			IEnumerator o = TestUITask.ReportBug(bugDesc, logFileHours);
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

	// Token: 0x06021B27 RID: 138023 RVA: 0x00B6FA08 File Offset: 0x00B6DC08
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int OnTick(IntPtr l)
	{
		int result;
		try
		{
			TestUITask testUITask = (TestUITask)LuaObject.checkSelf(l);
			testUITask.m_luaExportHelper.OnTick();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06021B28 RID: 138024 RVA: 0x00B6FA5C File Offset: 0x00B6DC5C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int InitAllUIControllers(IntPtr l)
	{
		int result;
		try
		{
			TestUITask testUITask = (TestUITask)LuaObject.checkSelf(l);
			testUITask.m_luaExportHelper.InitAllUIControllers();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06021B29 RID: 138025 RVA: 0x00B6FAB0 File Offset: 0x00B6DCB0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int ClearAllContextAndRes(IntPtr l)
	{
		int result;
		try
		{
			TestUITask testUITask = (TestUITask)LuaObject.checkSelf(l);
			testUITask.m_luaExportHelper.ClearAllContextAndRes();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06021B2A RID: 138026 RVA: 0x00B6FB04 File Offset: 0x00B6DD04
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int InitTestUIController(IntPtr l)
	{
		int result;
		try
		{
			TestUITask testUITask = (TestUITask)LuaObject.checkSelf(l);
			testUITask.m_luaExportHelper.InitTestUIController();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06021B2B RID: 138027 RVA: 0x00B6FB58 File Offset: 0x00B6DD58
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int UninitTestUIController(IntPtr l)
	{
		int result;
		try
		{
			TestUITask testUITask = (TestUITask)LuaObject.checkSelf(l);
			testUITask.m_luaExportHelper.UninitTestUIController();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06021B2C RID: 138028 RVA: 0x00B6FBAC File Offset: 0x00B6DDAC
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int OnReportBug(IntPtr l)
	{
		int result;
		try
		{
			TestUITask testUITask = (TestUITask)LuaObject.checkSelf(l);
			string bugDesc;
			LuaObject.checkType(l, 2, out bugDesc);
			double logFileHours;
			LuaObject.checkType(l, 3, out logFileHours);
			testUITask.m_luaExportHelper.OnReportBug(bugDesc, logFileHours);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06021B2D RID: 138029 RVA: 0x00B6FC18 File Offset: 0x00B6DE18
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int UpdateView(IntPtr l)
	{
		int result;
		try
		{
			TestUITask testUITask = (TestUITask)LuaObject.checkSelf(l);
			testUITask.m_luaExportHelper.UpdateView();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06021B2E RID: 138030 RVA: 0x00B6FC6C File Offset: 0x00B6DE6C
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int UpdateTestList(IntPtr l)
	{
		int result;
		try
		{
			TestUITask testUITask = (TestUITask)LuaObject.checkSelf(l);
			testUITask.m_luaExportHelper.UpdateTestList();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06021B2F RID: 138031 RVA: 0x00B6FCC0 File Offset: 0x00B6DEC0
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int StartDialogUITask(IntPtr l)
	{
		int result;
		try
		{
			TestUITask testUITask = (TestUITask)LuaObject.checkSelf(l);
			ConfigDataDialogInfo dialogInfo;
			LuaObject.checkType<ConfigDataDialogInfo>(l, 2, out dialogInfo);
			testUITask.m_luaExportHelper.StartDialogUITask(dialogInfo);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06021B30 RID: 138032 RVA: 0x00B6FD1C File Offset: 0x00B6DF1C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int StartBattleDialogUITask(IntPtr l)
	{
		int result;
		try
		{
			TestUITask testUITask = (TestUITask)LuaObject.checkSelf(l);
			ConfigDataBattleDialogInfo dialogInfo;
			LuaObject.checkType<ConfigDataBattleDialogInfo>(l, 2, out dialogInfo);
			testUITask.m_luaExportHelper.StartBattleDialogUITask(dialogInfo);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06021B31 RID: 138033 RVA: 0x00B6FD78 File Offset: 0x00B6DF78
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int StartUserGuideDialogUITask(IntPtr l)
	{
		int result;
		try
		{
			TestUITask testUITask = (TestUITask)LuaObject.checkSelf(l);
			ConfigDataUserGuideDialogInfo dialogInfo;
			LuaObject.checkType<ConfigDataUserGuideDialogInfo>(l, 2, out dialogInfo);
			testUITask.m_luaExportHelper.StartUserGuideDialogUITask(dialogInfo);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06021B32 RID: 138034 RVA: 0x00B6FDD4 File Offset: 0x00B6DFD4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int StartGoddessDialogUITask(IntPtr l)
	{
		int result;
		try
		{
			TestUITask testUITask = (TestUITask)LuaObject.checkSelf(l);
			testUITask.m_luaExportHelper.StartGoddessDialogUITask();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06021B33 RID: 138035 RVA: 0x00B6FE28 File Offset: 0x00B6E028
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int TestUIController_OnChangeTestList(IntPtr l)
	{
		int result;
		try
		{
			TestUITask testUITask = (TestUITask)LuaObject.checkSelf(l);
			TestListType listType;
			LuaObject.checkEnum<TestListType>(l, 2, out listType);
			testUITask.m_luaExportHelper.TestUIController_OnChangeTestList(listType);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06021B34 RID: 138036 RVA: 0x00B6FE84 File Offset: 0x00B6E084
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int TestUIController_OnStartTest(IntPtr l)
	{
		int result;
		try
		{
			TestUITask testUITask = (TestUITask)LuaObject.checkSelf(l);
			int id;
			LuaObject.checkType(l, 2, out id);
			testUITask.m_luaExportHelper.TestUIController_OnStartTest(id);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06021B35 RID: 138037 RVA: 0x00B6FEE0 File Offset: 0x00B6E0E0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int TestUIController_OnReturn(IntPtr l)
	{
		int result;
		try
		{
			TestUITask testUITask = (TestUITask)LuaObject.checkSelf(l);
			testUITask.m_luaExportHelper.TestUIController_OnReturn();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06021B36 RID: 138038 RVA: 0x00B6FF34 File Offset: 0x00B6E134
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int TestUIController_OnShowSystemInfo(IntPtr l)
	{
		int result;
		try
		{
			TestUITask testUITask = (TestUITask)LuaObject.checkSelf(l);
			testUITask.m_luaExportHelper.TestUIController_OnShowSystemInfo();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06021B37 RID: 138039 RVA: 0x00B6FF88 File Offset: 0x00B6E188
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int TestUIController_OnCloseSystemInfo(IntPtr l)
	{
		int result;
		try
		{
			TestUITask testUITask = (TestUITask)LuaObject.checkSelf(l);
			testUITask.m_luaExportHelper.TestUIController_OnCloseSystemInfo();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06021B38 RID: 138040 RVA: 0x00B6FFDC File Offset: 0x00B6E1DC
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int TestUIController_OnClearUserGuide(IntPtr l)
	{
		int result;
		try
		{
			TestUITask testUITask = (TestUITask)LuaObject.checkSelf(l);
			testUITask.m_luaExportHelper.TestUIController_OnClearUserGuide();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06021B39 RID: 138041 RVA: 0x00B70030 File Offset: 0x00B6E230
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int TestUIController_OnCompleteUserGuide(IntPtr l)
	{
		int result;
		try
		{
			TestUITask testUITask = (TestUITask)LuaObject.checkSelf(l);
			testUITask.m_luaExportHelper.TestUIController_OnCompleteUserGuide();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06021B3A RID: 138042 RVA: 0x00B70084 File Offset: 0x00B6E284
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int TestUIController_OnClearStage(IntPtr l)
	{
		int result;
		try
		{
			TestUITask testUITask = (TestUITask)LuaObject.checkSelf(l);
			testUITask.m_luaExportHelper.TestUIController_OnClearStage();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06021B3B RID: 138043 RVA: 0x00B700D8 File Offset: 0x00B6E2D8
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int TestUIController_OnShowGoddessDialog(IntPtr l)
	{
		int result;
		try
		{
			TestUITask testUITask = (TestUITask)LuaObject.checkSelf(l);
			testUITask.m_luaExportHelper.TestUIController_OnShowGoddessDialog();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06021B3C RID: 138044 RVA: 0x00B7012C File Offset: 0x00B6E32C
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int __callBase_OnStart(IntPtr l)
	{
		int result;
		try
		{
			TestUITask testUITask = (TestUITask)LuaObject.checkSelf(l);
			UIIntent intent;
			LuaObject.checkType<UIIntent>(l, 2, out intent);
			bool b = testUITask.m_luaExportHelper.__callBase_OnStart(intent);
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

	// Token: 0x06021B3D RID: 138045 RVA: 0x00B70194 File Offset: 0x00B6E394
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_OnStop(IntPtr l)
	{
		int result;
		try
		{
			TestUITask testUITask = (TestUITask)LuaObject.checkSelf(l);
			testUITask.m_luaExportHelper.__callBase_OnStop();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06021B3E RID: 138046 RVA: 0x00B701E8 File Offset: 0x00B6E3E8
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int __callBase_OnPause(IntPtr l)
	{
		int result;
		try
		{
			TestUITask testUITask = (TestUITask)LuaObject.checkSelf(l);
			testUITask.m_luaExportHelper.__callBase_OnPause();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06021B3F RID: 138047 RVA: 0x00B7023C File Offset: 0x00B6E43C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_OnResume(IntPtr l)
	{
		int result;
		try
		{
			TestUITask testUITask = (TestUITask)LuaObject.checkSelf(l);
			UIIntent intent;
			LuaObject.checkType<UIIntent>(l, 2, out intent);
			bool b = testUITask.m_luaExportHelper.__callBase_OnResume(intent);
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

	// Token: 0x06021B40 RID: 138048 RVA: 0x00B702A4 File Offset: 0x00B6E4A4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_OnNewIntent(IntPtr l)
	{
		int result;
		try
		{
			TestUITask testUITask = (TestUITask)LuaObject.checkSelf(l);
			UIIntent intent;
			LuaObject.checkType<UIIntent>(l, 2, out intent);
			bool b = testUITask.m_luaExportHelper.__callBase_OnNewIntent(intent);
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

	// Token: 0x06021B41 RID: 138049 RVA: 0x00B7030C File Offset: 0x00B6E50C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_EnableUIInput(IntPtr l)
	{
		int result;
		try
		{
			TestUITask testUITask = (TestUITask)LuaObject.checkSelf(l);
			bool isEnable;
			LuaObject.checkType(l, 2, out isEnable);
			bool? isGlobalEnable;
			LuaObject.checkNullable<bool>(l, 3, out isGlobalEnable);
			testUITask.m_luaExportHelper.__callBase_EnableUIInput(isEnable, isGlobalEnable);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06021B42 RID: 138050 RVA: 0x00B70378 File Offset: 0x00B6E578
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int __callBase_IsNeedLoadDynamicRes(IntPtr l)
	{
		int result;
		try
		{
			TestUITask testUITask = (TestUITask)LuaObject.checkSelf(l);
			bool b = testUITask.m_luaExportHelper.__callBase_IsNeedLoadDynamicRes();
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

	// Token: 0x06021B43 RID: 138051 RVA: 0x00B703D4 File Offset: 0x00B6E5D4
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int __callBase_CollectAllDynamicResForLoad(IntPtr l)
	{
		int result;
		try
		{
			TestUITask testUITask = (TestUITask)LuaObject.checkSelf(l);
			List<string> o = testUITask.m_luaExportHelper.__callBase_CollectAllDynamicResForLoad();
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

	// Token: 0x06021B44 RID: 138052 RVA: 0x00B70430 File Offset: 0x00B6E630
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_RegisterPlayerContextEvents(IntPtr l)
	{
		int result;
		try
		{
			TestUITask testUITask = (TestUITask)LuaObject.checkSelf(l);
			testUITask.m_luaExportHelper.__callBase_RegisterPlayerContextEvents();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06021B45 RID: 138053 RVA: 0x00B70484 File Offset: 0x00B6E684
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_UnregisterPlayerContextEvents(IntPtr l)
	{
		int result;
		try
		{
			TestUITask testUITask = (TestUITask)LuaObject.checkSelf(l);
			testUITask.m_luaExportHelper.__callBase_UnregisterPlayerContextEvents();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06021B46 RID: 138054 RVA: 0x00B704D8 File Offset: 0x00B6E6D8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_PostUpdateView(IntPtr l)
	{
		int result;
		try
		{
			TestUITask testUITask = (TestUITask)LuaObject.checkSelf(l);
			testUITask.m_luaExportHelper.__callBase_PostUpdateView();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06021B47 RID: 138055 RVA: 0x00B7052C File Offset: 0x00B6E72C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_CollectPreloadResourceList(IntPtr l)
	{
		int result;
		try
		{
			TestUITask testUITask = (TestUITask)LuaObject.checkSelf(l);
			testUITask.m_luaExportHelper.__callBase_CollectPreloadResourceList();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06021B48 RID: 138056 RVA: 0x00B70580 File Offset: 0x00B6E780
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int __callBase_ClearAssetList(IntPtr l)
	{
		int result;
		try
		{
			TestUITask testUITask = (TestUITask)LuaObject.checkSelf(l);
			testUITask.m_luaExportHelper.__callBase_ClearAssetList();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06021B49 RID: 138057 RVA: 0x00B705D4 File Offset: 0x00B6E7D4
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int __callBase_CollectAsset(IntPtr l)
	{
		int result;
		try
		{
			TestUITask testUITask = (TestUITask)LuaObject.checkSelf(l);
			string assetName;
			LuaObject.checkType(l, 2, out assetName);
			testUITask.m_luaExportHelper.__callBase_CollectAsset(assetName);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06021B4A RID: 138058 RVA: 0x00B70630 File Offset: 0x00B6E830
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_CollectSpriteAsset(IntPtr l)
	{
		int result;
		try
		{
			TestUITask testUITask = (TestUITask)LuaObject.checkSelf(l);
			string assetName;
			LuaObject.checkType(l, 2, out assetName);
			testUITask.m_luaExportHelper.__callBase_CollectSpriteAsset(assetName);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06021B4B RID: 138059 RVA: 0x00B7068C File Offset: 0x00B6E88C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_CollectFxAsset(IntPtr l)
	{
		int result;
		try
		{
			TestUITask testUITask = (TestUITask)LuaObject.checkSelf(l);
			string assetName;
			LuaObject.checkType(l, 2, out assetName);
			testUITask.m_luaExportHelper.__callBase_CollectFxAsset(assetName);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06021B4C RID: 138060 RVA: 0x00B706E8 File Offset: 0x00B6E8E8
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int __callBase_StartLoadCustomAssets(IntPtr l)
	{
		int result;
		try
		{
			TestUITask testUITask = (TestUITask)LuaObject.checkSelf(l);
			Action onLoadCompleted;
			LuaObject.checkDelegate<Action>(l, 2, out onLoadCompleted);
			testUITask.m_luaExportHelper.__callBase_StartLoadCustomAssets(onLoadCompleted);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06021B4D RID: 138061 RVA: 0x00B70744 File Offset: 0x00B6E944
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_IsLoadingCustomAssets(IntPtr l)
	{
		int result;
		try
		{
			TestUITask testUITask = (TestUITask)LuaObject.checkSelf(l);
			bool b = testUITask.m_luaExportHelper.__callBase_IsLoadingCustomAssets();
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

	// Token: 0x06021B4E RID: 138062 RVA: 0x00B707A0 File Offset: 0x00B6E9A0
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int __callBase_IsPipeLineRunning(IntPtr l)
	{
		int result;
		try
		{
			TestUITask testUITask = (TestUITask)LuaObject.checkSelf(l);
			bool b = testUITask.m_luaExportHelper.__callBase_IsPipeLineRunning();
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

	// Token: 0x06021B4F RID: 138063 RVA: 0x00B707FC File Offset: 0x00B6E9FC
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int __callBase_IsOpeningUI(IntPtr l)
	{
		int result;
		try
		{
			TestUITask testUITask = (TestUITask)LuaObject.checkSelf(l);
			bool b = testUITask.m_luaExportHelper.__callBase_IsOpeningUI();
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

	// Token: 0x06021B50 RID: 138064 RVA: 0x00B70858 File Offset: 0x00B6EA58
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int __callBase_ReturnPrevUITask(IntPtr l)
	{
		int result;
		try
		{
			TestUITask testUITask = (TestUITask)LuaObject.checkSelf(l);
			UITaskBase o = testUITask.m_luaExportHelper.__callBase_ReturnPrevUITask();
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

	// Token: 0x06021B51 RID: 138065 RVA: 0x00B708B4 File Offset: 0x00B6EAB4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_ClearUnusedDynamicResourceCache(IntPtr l)
	{
		int result;
		try
		{
			TestUITask testUITask = (TestUITask)LuaObject.checkSelf(l);
			testUITask.m_luaExportHelper.__callBase_ClearUnusedDynamicResourceCache();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06021B52 RID: 138066 RVA: 0x00B70908 File Offset: 0x00B6EB08
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int __callBase_OnMemoryWarning(IntPtr l)
	{
		int result;
		try
		{
			TestUITask testUITask = (TestUITask)LuaObject.checkSelf(l);
			testUITask.m_luaExportHelper.__callBase_OnMemoryWarning();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06021B53 RID: 138067 RVA: 0x00B7095C File Offset: 0x00B6EB5C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callDele_EventOnStartBattle(IntPtr l)
	{
		int result;
		try
		{
			TestUITask testUITask = (TestUITask)LuaObject.checkSelf(l);
			ConfigDataBattleInfo obj;
			LuaObject.checkType<ConfigDataBattleInfo>(l, 2, out obj);
			testUITask.m_luaExportHelper.__callDele_EventOnStartBattle(obj);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06021B54 RID: 138068 RVA: 0x00B709B8 File Offset: 0x00B6EBB8
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int __clearDele_EventOnStartBattle(IntPtr l)
	{
		int result;
		try
		{
			TestUITask testUITask = (TestUITask)LuaObject.checkSelf(l);
			ConfigDataBattleInfo obj;
			LuaObject.checkType<ConfigDataBattleInfo>(l, 2, out obj);
			testUITask.m_luaExportHelper.__clearDele_EventOnStartBattle(obj);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06021B55 RID: 138069 RVA: 0x00B70A14 File Offset: 0x00B6EC14
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int UploadFile_s(IntPtr l)
	{
		int result;
		try
		{
			string localFilepath;
			LuaObject.checkType(l, 1, out localFilepath);
			string uploadURL;
			LuaObject.checkType(l, 2, out uploadURL);
			string serverFilename;
			LuaObject.checkType(l, 3, out serverFilename);
			IEnumerator o = TestUITask.LuaExportHelper.UploadFile(localFilepath, uploadURL, serverFilename);
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

	// Token: 0x06021B56 RID: 138070 RVA: 0x00B70A84 File Offset: 0x00B6EC84
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int Byte2HexByte_s(IntPtr l)
	{
		int result;
		try
		{
			byte[] bytes;
			LuaObject.checkArray<byte>(l, 1, out bytes);
			byte[] a = TestUITask.LuaExportHelper.Byte2HexByte(bytes);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, a);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06021B57 RID: 138071 RVA: 0x00B70AD8 File Offset: 0x00B6ECD8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_EventOnStartBattle(IntPtr l)
	{
		int result;
		try
		{
			TestUITask testUITask = (TestUITask)LuaObject.checkSelf(l);
			Action<ConfigDataBattleInfo> value;
			int num = LuaObject.checkDelegate<Action<ConfigDataBattleInfo>>(l, 2, out value);
			if (num != 0)
			{
				if (num == 1)
				{
					testUITask.EventOnStartBattle += value;
				}
				else if (num == 2)
				{
					testUITask.EventOnStartBattle -= value;
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

	// Token: 0x06021B58 RID: 138072 RVA: 0x00B70B58 File Offset: 0x00B6ED58
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_m_layerDescArray(IntPtr l)
	{
		int result;
		try
		{
			TestUITask testUITask = (TestUITask)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, testUITask.m_luaExportHelper.m_layerDescArray);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06021B59 RID: 138073 RVA: 0x00B70BB0 File Offset: 0x00B6EDB0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_layerDescArray(IntPtr l)
	{
		int result;
		try
		{
			TestUITask testUITask = (TestUITask)LuaObject.checkSelf(l);
			UITaskBase.LayerDesc[] layerDescArray;
			LuaObject.checkArray<UITaskBase.LayerDesc>(l, 2, out layerDescArray);
			testUITask.m_luaExportHelper.m_layerDescArray = layerDescArray;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06021B5A RID: 138074 RVA: 0x00B70C0C File Offset: 0x00B6EE0C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_uiCtrlDescArray(IntPtr l)
	{
		int result;
		try
		{
			TestUITask testUITask = (TestUITask)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, testUITask.m_luaExportHelper.m_uiCtrlDescArray);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06021B5B RID: 138075 RVA: 0x00B70C64 File Offset: 0x00B6EE64
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_uiCtrlDescArray(IntPtr l)
	{
		int result;
		try
		{
			TestUITask testUITask = (TestUITask)LuaObject.checkSelf(l);
			UITaskBase.UIControllerDesc[] uiCtrlDescArray;
			LuaObject.checkArray<UITaskBase.UIControllerDesc>(l, 2, out uiCtrlDescArray);
			testUITask.m_luaExportHelper.m_uiCtrlDescArray = uiCtrlDescArray;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06021B5C RID: 138076 RVA: 0x00B70CC0 File Offset: 0x00B6EEC0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_testUIController(IntPtr l)
	{
		int result;
		try
		{
			TestUITask testUITask = (TestUITask)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, testUITask.m_luaExportHelper.m_testUIController);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06021B5D RID: 138077 RVA: 0x00B70D18 File Offset: 0x00B6EF18
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_testUIController(IntPtr l)
	{
		int result;
		try
		{
			TestUITask testUITask = (TestUITask)LuaObject.checkSelf(l);
			TestUIController testUIController;
			LuaObject.checkType<TestUIController>(l, 2, out testUIController);
			testUITask.m_luaExportHelper.m_testUIController = testUIController;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06021B5E RID: 138078 RVA: 0x00B70D74 File Offset: 0x00B6EF74
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_LayerDescArray(IntPtr l)
	{
		int result;
		try
		{
			TestUITask testUITask = (TestUITask)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, testUITask.m_luaExportHelper.LayerDescArray);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06021B5F RID: 138079 RVA: 0x00B70DCC File Offset: 0x00B6EFCC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_UICtrlDescArray(IntPtr l)
	{
		int result;
		try
		{
			TestUITask testUITask = (TestUITask)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, testUITask.m_luaExportHelper.UICtrlDescArray);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06021B60 RID: 138080 RVA: 0x00B70E24 File Offset: 0x00B6F024
	[Preserve]
	public static void reg(IntPtr l)
	{
		LuaObject.getTypeTable(l, "BlackJack.ProjectL.UI.TestUITask");
		if (Lua_BlackJack_ProjectL_UI_TestUITask.<>f__mg$cache0 == null)
		{
			Lua_BlackJack_ProjectL_UI_TestUITask.<>f__mg$cache0 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_TestUITask.ReportBug_s);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_TestUITask.<>f__mg$cache0);
		if (Lua_BlackJack_ProjectL_UI_TestUITask.<>f__mg$cache1 == null)
		{
			Lua_BlackJack_ProjectL_UI_TestUITask.<>f__mg$cache1 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_TestUITask.OnTick);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_TestUITask.<>f__mg$cache1);
		if (Lua_BlackJack_ProjectL_UI_TestUITask.<>f__mg$cache2 == null)
		{
			Lua_BlackJack_ProjectL_UI_TestUITask.<>f__mg$cache2 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_TestUITask.InitAllUIControllers);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_TestUITask.<>f__mg$cache2);
		if (Lua_BlackJack_ProjectL_UI_TestUITask.<>f__mg$cache3 == null)
		{
			Lua_BlackJack_ProjectL_UI_TestUITask.<>f__mg$cache3 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_TestUITask.ClearAllContextAndRes);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_TestUITask.<>f__mg$cache3);
		if (Lua_BlackJack_ProjectL_UI_TestUITask.<>f__mg$cache4 == null)
		{
			Lua_BlackJack_ProjectL_UI_TestUITask.<>f__mg$cache4 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_TestUITask.InitTestUIController);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_TestUITask.<>f__mg$cache4);
		if (Lua_BlackJack_ProjectL_UI_TestUITask.<>f__mg$cache5 == null)
		{
			Lua_BlackJack_ProjectL_UI_TestUITask.<>f__mg$cache5 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_TestUITask.UninitTestUIController);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_TestUITask.<>f__mg$cache5);
		if (Lua_BlackJack_ProjectL_UI_TestUITask.<>f__mg$cache6 == null)
		{
			Lua_BlackJack_ProjectL_UI_TestUITask.<>f__mg$cache6 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_TestUITask.OnReportBug);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_TestUITask.<>f__mg$cache6);
		if (Lua_BlackJack_ProjectL_UI_TestUITask.<>f__mg$cache7 == null)
		{
			Lua_BlackJack_ProjectL_UI_TestUITask.<>f__mg$cache7 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_TestUITask.UpdateView);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_TestUITask.<>f__mg$cache7);
		if (Lua_BlackJack_ProjectL_UI_TestUITask.<>f__mg$cache8 == null)
		{
			Lua_BlackJack_ProjectL_UI_TestUITask.<>f__mg$cache8 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_TestUITask.UpdateTestList);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_TestUITask.<>f__mg$cache8);
		if (Lua_BlackJack_ProjectL_UI_TestUITask.<>f__mg$cache9 == null)
		{
			Lua_BlackJack_ProjectL_UI_TestUITask.<>f__mg$cache9 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_TestUITask.StartDialogUITask);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_TestUITask.<>f__mg$cache9);
		if (Lua_BlackJack_ProjectL_UI_TestUITask.<>f__mg$cacheA == null)
		{
			Lua_BlackJack_ProjectL_UI_TestUITask.<>f__mg$cacheA = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_TestUITask.StartBattleDialogUITask);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_TestUITask.<>f__mg$cacheA);
		if (Lua_BlackJack_ProjectL_UI_TestUITask.<>f__mg$cacheB == null)
		{
			Lua_BlackJack_ProjectL_UI_TestUITask.<>f__mg$cacheB = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_TestUITask.StartUserGuideDialogUITask);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_TestUITask.<>f__mg$cacheB);
		if (Lua_BlackJack_ProjectL_UI_TestUITask.<>f__mg$cacheC == null)
		{
			Lua_BlackJack_ProjectL_UI_TestUITask.<>f__mg$cacheC = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_TestUITask.StartGoddessDialogUITask);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_TestUITask.<>f__mg$cacheC);
		if (Lua_BlackJack_ProjectL_UI_TestUITask.<>f__mg$cacheD == null)
		{
			Lua_BlackJack_ProjectL_UI_TestUITask.<>f__mg$cacheD = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_TestUITask.TestUIController_OnChangeTestList);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_TestUITask.<>f__mg$cacheD);
		if (Lua_BlackJack_ProjectL_UI_TestUITask.<>f__mg$cacheE == null)
		{
			Lua_BlackJack_ProjectL_UI_TestUITask.<>f__mg$cacheE = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_TestUITask.TestUIController_OnStartTest);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_TestUITask.<>f__mg$cacheE);
		if (Lua_BlackJack_ProjectL_UI_TestUITask.<>f__mg$cacheF == null)
		{
			Lua_BlackJack_ProjectL_UI_TestUITask.<>f__mg$cacheF = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_TestUITask.TestUIController_OnReturn);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_TestUITask.<>f__mg$cacheF);
		if (Lua_BlackJack_ProjectL_UI_TestUITask.<>f__mg$cache10 == null)
		{
			Lua_BlackJack_ProjectL_UI_TestUITask.<>f__mg$cache10 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_TestUITask.TestUIController_OnShowSystemInfo);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_TestUITask.<>f__mg$cache10);
		if (Lua_BlackJack_ProjectL_UI_TestUITask.<>f__mg$cache11 == null)
		{
			Lua_BlackJack_ProjectL_UI_TestUITask.<>f__mg$cache11 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_TestUITask.TestUIController_OnCloseSystemInfo);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_TestUITask.<>f__mg$cache11);
		if (Lua_BlackJack_ProjectL_UI_TestUITask.<>f__mg$cache12 == null)
		{
			Lua_BlackJack_ProjectL_UI_TestUITask.<>f__mg$cache12 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_TestUITask.TestUIController_OnClearUserGuide);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_TestUITask.<>f__mg$cache12);
		if (Lua_BlackJack_ProjectL_UI_TestUITask.<>f__mg$cache13 == null)
		{
			Lua_BlackJack_ProjectL_UI_TestUITask.<>f__mg$cache13 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_TestUITask.TestUIController_OnCompleteUserGuide);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_TestUITask.<>f__mg$cache13);
		if (Lua_BlackJack_ProjectL_UI_TestUITask.<>f__mg$cache14 == null)
		{
			Lua_BlackJack_ProjectL_UI_TestUITask.<>f__mg$cache14 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_TestUITask.TestUIController_OnClearStage);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_TestUITask.<>f__mg$cache14);
		if (Lua_BlackJack_ProjectL_UI_TestUITask.<>f__mg$cache15 == null)
		{
			Lua_BlackJack_ProjectL_UI_TestUITask.<>f__mg$cache15 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_TestUITask.TestUIController_OnShowGoddessDialog);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_TestUITask.<>f__mg$cache15);
		if (Lua_BlackJack_ProjectL_UI_TestUITask.<>f__mg$cache16 == null)
		{
			Lua_BlackJack_ProjectL_UI_TestUITask.<>f__mg$cache16 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_TestUITask.__callBase_OnStart);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_TestUITask.<>f__mg$cache16);
		if (Lua_BlackJack_ProjectL_UI_TestUITask.<>f__mg$cache17 == null)
		{
			Lua_BlackJack_ProjectL_UI_TestUITask.<>f__mg$cache17 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_TestUITask.__callBase_OnStop);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_TestUITask.<>f__mg$cache17);
		if (Lua_BlackJack_ProjectL_UI_TestUITask.<>f__mg$cache18 == null)
		{
			Lua_BlackJack_ProjectL_UI_TestUITask.<>f__mg$cache18 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_TestUITask.__callBase_OnPause);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_TestUITask.<>f__mg$cache18);
		if (Lua_BlackJack_ProjectL_UI_TestUITask.<>f__mg$cache19 == null)
		{
			Lua_BlackJack_ProjectL_UI_TestUITask.<>f__mg$cache19 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_TestUITask.__callBase_OnResume);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_TestUITask.<>f__mg$cache19);
		if (Lua_BlackJack_ProjectL_UI_TestUITask.<>f__mg$cache1A == null)
		{
			Lua_BlackJack_ProjectL_UI_TestUITask.<>f__mg$cache1A = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_TestUITask.__callBase_OnNewIntent);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_TestUITask.<>f__mg$cache1A);
		if (Lua_BlackJack_ProjectL_UI_TestUITask.<>f__mg$cache1B == null)
		{
			Lua_BlackJack_ProjectL_UI_TestUITask.<>f__mg$cache1B = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_TestUITask.__callBase_EnableUIInput);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_TestUITask.<>f__mg$cache1B);
		if (Lua_BlackJack_ProjectL_UI_TestUITask.<>f__mg$cache1C == null)
		{
			Lua_BlackJack_ProjectL_UI_TestUITask.<>f__mg$cache1C = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_TestUITask.__callBase_IsNeedLoadDynamicRes);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_TestUITask.<>f__mg$cache1C);
		if (Lua_BlackJack_ProjectL_UI_TestUITask.<>f__mg$cache1D == null)
		{
			Lua_BlackJack_ProjectL_UI_TestUITask.<>f__mg$cache1D = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_TestUITask.__callBase_CollectAllDynamicResForLoad);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_TestUITask.<>f__mg$cache1D);
		if (Lua_BlackJack_ProjectL_UI_TestUITask.<>f__mg$cache1E == null)
		{
			Lua_BlackJack_ProjectL_UI_TestUITask.<>f__mg$cache1E = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_TestUITask.__callBase_RegisterPlayerContextEvents);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_TestUITask.<>f__mg$cache1E);
		if (Lua_BlackJack_ProjectL_UI_TestUITask.<>f__mg$cache1F == null)
		{
			Lua_BlackJack_ProjectL_UI_TestUITask.<>f__mg$cache1F = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_TestUITask.__callBase_UnregisterPlayerContextEvents);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_TestUITask.<>f__mg$cache1F);
		if (Lua_BlackJack_ProjectL_UI_TestUITask.<>f__mg$cache20 == null)
		{
			Lua_BlackJack_ProjectL_UI_TestUITask.<>f__mg$cache20 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_TestUITask.__callBase_PostUpdateView);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_TestUITask.<>f__mg$cache20);
		if (Lua_BlackJack_ProjectL_UI_TestUITask.<>f__mg$cache21 == null)
		{
			Lua_BlackJack_ProjectL_UI_TestUITask.<>f__mg$cache21 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_TestUITask.__callBase_CollectPreloadResourceList);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_TestUITask.<>f__mg$cache21);
		if (Lua_BlackJack_ProjectL_UI_TestUITask.<>f__mg$cache22 == null)
		{
			Lua_BlackJack_ProjectL_UI_TestUITask.<>f__mg$cache22 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_TestUITask.__callBase_ClearAssetList);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_TestUITask.<>f__mg$cache22);
		if (Lua_BlackJack_ProjectL_UI_TestUITask.<>f__mg$cache23 == null)
		{
			Lua_BlackJack_ProjectL_UI_TestUITask.<>f__mg$cache23 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_TestUITask.__callBase_CollectAsset);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_TestUITask.<>f__mg$cache23);
		if (Lua_BlackJack_ProjectL_UI_TestUITask.<>f__mg$cache24 == null)
		{
			Lua_BlackJack_ProjectL_UI_TestUITask.<>f__mg$cache24 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_TestUITask.__callBase_CollectSpriteAsset);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_TestUITask.<>f__mg$cache24);
		if (Lua_BlackJack_ProjectL_UI_TestUITask.<>f__mg$cache25 == null)
		{
			Lua_BlackJack_ProjectL_UI_TestUITask.<>f__mg$cache25 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_TestUITask.__callBase_CollectFxAsset);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_TestUITask.<>f__mg$cache25);
		if (Lua_BlackJack_ProjectL_UI_TestUITask.<>f__mg$cache26 == null)
		{
			Lua_BlackJack_ProjectL_UI_TestUITask.<>f__mg$cache26 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_TestUITask.__callBase_StartLoadCustomAssets);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_TestUITask.<>f__mg$cache26);
		if (Lua_BlackJack_ProjectL_UI_TestUITask.<>f__mg$cache27 == null)
		{
			Lua_BlackJack_ProjectL_UI_TestUITask.<>f__mg$cache27 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_TestUITask.__callBase_IsLoadingCustomAssets);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_TestUITask.<>f__mg$cache27);
		if (Lua_BlackJack_ProjectL_UI_TestUITask.<>f__mg$cache28 == null)
		{
			Lua_BlackJack_ProjectL_UI_TestUITask.<>f__mg$cache28 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_TestUITask.__callBase_IsPipeLineRunning);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_TestUITask.<>f__mg$cache28);
		if (Lua_BlackJack_ProjectL_UI_TestUITask.<>f__mg$cache29 == null)
		{
			Lua_BlackJack_ProjectL_UI_TestUITask.<>f__mg$cache29 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_TestUITask.__callBase_IsOpeningUI);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_TestUITask.<>f__mg$cache29);
		if (Lua_BlackJack_ProjectL_UI_TestUITask.<>f__mg$cache2A == null)
		{
			Lua_BlackJack_ProjectL_UI_TestUITask.<>f__mg$cache2A = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_TestUITask.__callBase_ReturnPrevUITask);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_TestUITask.<>f__mg$cache2A);
		if (Lua_BlackJack_ProjectL_UI_TestUITask.<>f__mg$cache2B == null)
		{
			Lua_BlackJack_ProjectL_UI_TestUITask.<>f__mg$cache2B = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_TestUITask.__callBase_ClearUnusedDynamicResourceCache);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_TestUITask.<>f__mg$cache2B);
		if (Lua_BlackJack_ProjectL_UI_TestUITask.<>f__mg$cache2C == null)
		{
			Lua_BlackJack_ProjectL_UI_TestUITask.<>f__mg$cache2C = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_TestUITask.__callBase_OnMemoryWarning);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_TestUITask.<>f__mg$cache2C);
		if (Lua_BlackJack_ProjectL_UI_TestUITask.<>f__mg$cache2D == null)
		{
			Lua_BlackJack_ProjectL_UI_TestUITask.<>f__mg$cache2D = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_TestUITask.__callDele_EventOnStartBattle);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_TestUITask.<>f__mg$cache2D);
		if (Lua_BlackJack_ProjectL_UI_TestUITask.<>f__mg$cache2E == null)
		{
			Lua_BlackJack_ProjectL_UI_TestUITask.<>f__mg$cache2E = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_TestUITask.__clearDele_EventOnStartBattle);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_TestUITask.<>f__mg$cache2E);
		if (Lua_BlackJack_ProjectL_UI_TestUITask.<>f__mg$cache2F == null)
		{
			Lua_BlackJack_ProjectL_UI_TestUITask.<>f__mg$cache2F = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_TestUITask.UploadFile_s);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_TestUITask.<>f__mg$cache2F);
		if (Lua_BlackJack_ProjectL_UI_TestUITask.<>f__mg$cache30 == null)
		{
			Lua_BlackJack_ProjectL_UI_TestUITask.<>f__mg$cache30 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_TestUITask.Byte2HexByte_s);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_TestUITask.<>f__mg$cache30);
		string name = "EventOnStartBattle";
		LuaCSFunction get = null;
		if (Lua_BlackJack_ProjectL_UI_TestUITask.<>f__mg$cache31 == null)
		{
			Lua_BlackJack_ProjectL_UI_TestUITask.<>f__mg$cache31 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_TestUITask.set_EventOnStartBattle);
		}
		LuaObject.addMember(l, name, get, Lua_BlackJack_ProjectL_UI_TestUITask.<>f__mg$cache31, true);
		string name2 = "m_layerDescArray";
		if (Lua_BlackJack_ProjectL_UI_TestUITask.<>f__mg$cache32 == null)
		{
			Lua_BlackJack_ProjectL_UI_TestUITask.<>f__mg$cache32 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_TestUITask.get_m_layerDescArray);
		}
		LuaCSFunction get2 = Lua_BlackJack_ProjectL_UI_TestUITask.<>f__mg$cache32;
		if (Lua_BlackJack_ProjectL_UI_TestUITask.<>f__mg$cache33 == null)
		{
			Lua_BlackJack_ProjectL_UI_TestUITask.<>f__mg$cache33 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_TestUITask.set_m_layerDescArray);
		}
		LuaObject.addMember(l, name2, get2, Lua_BlackJack_ProjectL_UI_TestUITask.<>f__mg$cache33, true);
		string name3 = "m_uiCtrlDescArray";
		if (Lua_BlackJack_ProjectL_UI_TestUITask.<>f__mg$cache34 == null)
		{
			Lua_BlackJack_ProjectL_UI_TestUITask.<>f__mg$cache34 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_TestUITask.get_m_uiCtrlDescArray);
		}
		LuaCSFunction get3 = Lua_BlackJack_ProjectL_UI_TestUITask.<>f__mg$cache34;
		if (Lua_BlackJack_ProjectL_UI_TestUITask.<>f__mg$cache35 == null)
		{
			Lua_BlackJack_ProjectL_UI_TestUITask.<>f__mg$cache35 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_TestUITask.set_m_uiCtrlDescArray);
		}
		LuaObject.addMember(l, name3, get3, Lua_BlackJack_ProjectL_UI_TestUITask.<>f__mg$cache35, true);
		string name4 = "m_testUIController";
		if (Lua_BlackJack_ProjectL_UI_TestUITask.<>f__mg$cache36 == null)
		{
			Lua_BlackJack_ProjectL_UI_TestUITask.<>f__mg$cache36 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_TestUITask.get_m_testUIController);
		}
		LuaCSFunction get4 = Lua_BlackJack_ProjectL_UI_TestUITask.<>f__mg$cache36;
		if (Lua_BlackJack_ProjectL_UI_TestUITask.<>f__mg$cache37 == null)
		{
			Lua_BlackJack_ProjectL_UI_TestUITask.<>f__mg$cache37 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_TestUITask.set_m_testUIController);
		}
		LuaObject.addMember(l, name4, get4, Lua_BlackJack_ProjectL_UI_TestUITask.<>f__mg$cache37, true);
		string name5 = "LayerDescArray";
		if (Lua_BlackJack_ProjectL_UI_TestUITask.<>f__mg$cache38 == null)
		{
			Lua_BlackJack_ProjectL_UI_TestUITask.<>f__mg$cache38 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_TestUITask.get_LayerDescArray);
		}
		LuaObject.addMember(l, name5, Lua_BlackJack_ProjectL_UI_TestUITask.<>f__mg$cache38, null, true);
		string name6 = "UICtrlDescArray";
		if (Lua_BlackJack_ProjectL_UI_TestUITask.<>f__mg$cache39 == null)
		{
			Lua_BlackJack_ProjectL_UI_TestUITask.<>f__mg$cache39 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_TestUITask.get_UICtrlDescArray);
		}
		LuaObject.addMember(l, name6, Lua_BlackJack_ProjectL_UI_TestUITask.<>f__mg$cache39, null, true);
		if (Lua_BlackJack_ProjectL_UI_TestUITask.<>f__mg$cache3A == null)
		{
			Lua_BlackJack_ProjectL_UI_TestUITask.<>f__mg$cache3A = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_TestUITask.constructor);
		}
		LuaObject.createTypeMetatable(l, Lua_BlackJack_ProjectL_UI_TestUITask.<>f__mg$cache3A, typeof(TestUITask), typeof(UITask));
	}

	// Token: 0x040179AB RID: 96683
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache0;

	// Token: 0x040179AC RID: 96684
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1;

	// Token: 0x040179AD RID: 96685
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2;

	// Token: 0x040179AE RID: 96686
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3;

	// Token: 0x040179AF RID: 96687
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache4;

	// Token: 0x040179B0 RID: 96688
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache5;

	// Token: 0x040179B1 RID: 96689
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache6;

	// Token: 0x040179B2 RID: 96690
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache7;

	// Token: 0x040179B3 RID: 96691
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache8;

	// Token: 0x040179B4 RID: 96692
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache9;

	// Token: 0x040179B5 RID: 96693
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheA;

	// Token: 0x040179B6 RID: 96694
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheB;

	// Token: 0x040179B7 RID: 96695
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheC;

	// Token: 0x040179B8 RID: 96696
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheD;

	// Token: 0x040179B9 RID: 96697
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheE;

	// Token: 0x040179BA RID: 96698
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheF;

	// Token: 0x040179BB RID: 96699
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache10;

	// Token: 0x040179BC RID: 96700
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache11;

	// Token: 0x040179BD RID: 96701
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache12;

	// Token: 0x040179BE RID: 96702
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache13;

	// Token: 0x040179BF RID: 96703
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache14;

	// Token: 0x040179C0 RID: 96704
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache15;

	// Token: 0x040179C1 RID: 96705
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache16;

	// Token: 0x040179C2 RID: 96706
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache17;

	// Token: 0x040179C3 RID: 96707
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache18;

	// Token: 0x040179C4 RID: 96708
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache19;

	// Token: 0x040179C5 RID: 96709
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1A;

	// Token: 0x040179C6 RID: 96710
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1B;

	// Token: 0x040179C7 RID: 96711
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1C;

	// Token: 0x040179C8 RID: 96712
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1D;

	// Token: 0x040179C9 RID: 96713
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1E;

	// Token: 0x040179CA RID: 96714
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1F;

	// Token: 0x040179CB RID: 96715
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache20;

	// Token: 0x040179CC RID: 96716
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache21;

	// Token: 0x040179CD RID: 96717
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache22;

	// Token: 0x040179CE RID: 96718
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache23;

	// Token: 0x040179CF RID: 96719
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache24;

	// Token: 0x040179D0 RID: 96720
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache25;

	// Token: 0x040179D1 RID: 96721
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache26;

	// Token: 0x040179D2 RID: 96722
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache27;

	// Token: 0x040179D3 RID: 96723
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache28;

	// Token: 0x040179D4 RID: 96724
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache29;

	// Token: 0x040179D5 RID: 96725
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2A;

	// Token: 0x040179D6 RID: 96726
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2B;

	// Token: 0x040179D7 RID: 96727
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2C;

	// Token: 0x040179D8 RID: 96728
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2D;

	// Token: 0x040179D9 RID: 96729
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2E;

	// Token: 0x040179DA RID: 96730
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2F;

	// Token: 0x040179DB RID: 96731
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache30;

	// Token: 0x040179DC RID: 96732
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache31;

	// Token: 0x040179DD RID: 96733
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache32;

	// Token: 0x040179DE RID: 96734
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache33;

	// Token: 0x040179DF RID: 96735
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache34;

	// Token: 0x040179E0 RID: 96736
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache35;

	// Token: 0x040179E1 RID: 96737
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache36;

	// Token: 0x040179E2 RID: 96738
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache37;

	// Token: 0x040179E3 RID: 96739
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache38;

	// Token: 0x040179E4 RID: 96740
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache39;

	// Token: 0x040179E5 RID: 96741
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3A;
}
