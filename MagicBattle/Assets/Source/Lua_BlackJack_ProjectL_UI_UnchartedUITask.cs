using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using BlackJack.BJFramework.Runtime.UI;
using BlackJack.ProjectL.Common;
using BlackJack.ProjectL.UI;
using SLua;
using UnityEngine.Scripting;

// Token: 0x020015CF RID: 5583
[Preserve]
public class Lua_BlackJack_ProjectL_UI_UnchartedUITask : LuaObject
{
	// Token: 0x06022075 RID: 139381 RVA: 0x00B9971C File Offset: 0x00B9791C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int constructor(IntPtr l)
	{
		int result;
		try
		{
			string name;
			LuaObject.checkType(l, 2, out name);
			UnchartedUITask o = new UnchartedUITask(name);
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

	// Token: 0x06022076 RID: 139382 RVA: 0x00B99770 File Offset: 0x00B97970
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int IsNeedLoadDynamicRes(IntPtr l)
	{
		int result;
		try
		{
			UnchartedUITask unchartedUITask = (UnchartedUITask)LuaObject.checkSelf(l);
			bool b = unchartedUITask.m_luaExportHelper.IsNeedLoadDynamicRes();
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

	// Token: 0x06022077 RID: 139383 RVA: 0x00B997CC File Offset: 0x00B979CC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int InitAllUIControllers(IntPtr l)
	{
		int result;
		try
		{
			UnchartedUITask unchartedUITask = (UnchartedUITask)LuaObject.checkSelf(l);
			unchartedUITask.m_luaExportHelper.InitAllUIControllers();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06022078 RID: 139384 RVA: 0x00B99820 File Offset: 0x00B97A20
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int ClearAllContextAndRes(IntPtr l)
	{
		int result;
		try
		{
			UnchartedUITask unchartedUITask = (UnchartedUITask)LuaObject.checkSelf(l);
			unchartedUITask.m_luaExportHelper.ClearAllContextAndRes();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06022079 RID: 139385 RVA: 0x00B99874 File Offset: 0x00B97A74
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int InitUnchartedUIController(IntPtr l)
	{
		int result;
		try
		{
			UnchartedUITask unchartedUITask = (UnchartedUITask)LuaObject.checkSelf(l);
			unchartedUITask.m_luaExportHelper.InitUnchartedUIController();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0602207A RID: 139386 RVA: 0x00B998C8 File Offset: 0x00B97AC8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int UninitUnchartedUIController(IntPtr l)
	{
		int result;
		try
		{
			UnchartedUITask unchartedUITask = (UnchartedUITask)LuaObject.checkSelf(l);
			unchartedUITask.m_luaExportHelper.UninitUnchartedUIController();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0602207B RID: 139387 RVA: 0x00B9991C File Offset: 0x00B97B1C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int OnTick(IntPtr l)
	{
		int result;
		try
		{
			UnchartedUITask unchartedUITask = (UnchartedUITask)LuaObject.checkSelf(l);
			unchartedUITask.m_luaExportHelper.OnTick();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0602207C RID: 139388 RVA: 0x00B99970 File Offset: 0x00B97B70
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int UpdateView(IntPtr l)
	{
		int result;
		try
		{
			UnchartedUITask unchartedUITask = (UnchartedUITask)LuaObject.checkSelf(l);
			unchartedUITask.m_luaExportHelper.UpdateView();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0602207D RID: 139389 RVA: 0x00B999C4 File Offset: 0x00B97BC4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int UpdateClimbTowerFlushTime(IntPtr l)
	{
		int result;
		try
		{
			UnchartedUITask unchartedUITask = (UnchartedUITask)LuaObject.checkSelf(l);
			unchartedUITask.m_luaExportHelper.UpdateClimbTowerFlushTime();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0602207E RID: 139390 RVA: 0x00B99A18 File Offset: 0x00B97C18
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int FlushClimbTower(IntPtr l)
	{
		int result;
		try
		{
			UnchartedUITask unchartedUITask = (UnchartedUITask)LuaObject.checkSelf(l);
			unchartedUITask.m_luaExportHelper.FlushClimbTower();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0602207F RID: 139391 RVA: 0x00B99A6C File Offset: 0x00B97C6C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int UnchartedUIController_OnShowUncharted(IntPtr l)
	{
		int result;
		try
		{
			UnchartedUITask unchartedUITask = (UnchartedUITask)LuaObject.checkSelf(l);
			BattleType battleType;
			LuaObject.checkEnum<BattleType>(l, 2, out battleType);
			int chapterId;
			LuaObject.checkType(l, 3, out chapterId);
			unchartedUITask.m_luaExportHelper.UnchartedUIController_OnShowUncharted(battleType, chapterId);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06022080 RID: 139392 RVA: 0x00B99AD8 File Offset: 0x00B97CD8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int UnchartedUIController_OnShowTeam(IntPtr l)
	{
		int result;
		try
		{
			UnchartedUITask unchartedUITask = (UnchartedUITask)LuaObject.checkSelf(l);
			unchartedUITask.m_luaExportHelper.UnchartedUIController_OnShowTeam();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06022081 RID: 139393 RVA: 0x00B99B2C File Offset: 0x00B97D2C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int TeamUITask_OnLoadAllResCompleted(IntPtr l)
	{
		int result;
		try
		{
			UnchartedUITask unchartedUITask = (UnchartedUITask)LuaObject.checkSelf(l);
			unchartedUITask.m_luaExportHelper.TeamUITask_OnLoadAllResCompleted();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06022082 RID: 139394 RVA: 0x00B99B80 File Offset: 0x00B97D80
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int UnchartedUIController_OnReturn(IntPtr l)
	{
		int result;
		try
		{
			UnchartedUITask unchartedUITask = (UnchartedUITask)LuaObject.checkSelf(l);
			unchartedUITask.m_luaExportHelper.UnchartedUIController_OnReturn();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06022083 RID: 139395 RVA: 0x00B99BD4 File Offset: 0x00B97DD4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_OnStart(IntPtr l)
	{
		int result;
		try
		{
			UnchartedUITask unchartedUITask = (UnchartedUITask)LuaObject.checkSelf(l);
			UIIntent intent;
			LuaObject.checkType<UIIntent>(l, 2, out intent);
			bool b = unchartedUITask.m_luaExportHelper.__callBase_OnStart(intent);
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

	// Token: 0x06022084 RID: 139396 RVA: 0x00B99C3C File Offset: 0x00B97E3C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_OnStop(IntPtr l)
	{
		int result;
		try
		{
			UnchartedUITask unchartedUITask = (UnchartedUITask)LuaObject.checkSelf(l);
			unchartedUITask.m_luaExportHelper.__callBase_OnStop();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06022085 RID: 139397 RVA: 0x00B99C90 File Offset: 0x00B97E90
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_OnPause(IntPtr l)
	{
		int result;
		try
		{
			UnchartedUITask unchartedUITask = (UnchartedUITask)LuaObject.checkSelf(l);
			unchartedUITask.m_luaExportHelper.__callBase_OnPause();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06022086 RID: 139398 RVA: 0x00B99CE4 File Offset: 0x00B97EE4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_OnResume(IntPtr l)
	{
		int result;
		try
		{
			UnchartedUITask unchartedUITask = (UnchartedUITask)LuaObject.checkSelf(l);
			UIIntent intent;
			LuaObject.checkType<UIIntent>(l, 2, out intent);
			bool b = unchartedUITask.m_luaExportHelper.__callBase_OnResume(intent);
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

	// Token: 0x06022087 RID: 139399 RVA: 0x00B99D4C File Offset: 0x00B97F4C
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int __callBase_OnNewIntent(IntPtr l)
	{
		int result;
		try
		{
			UnchartedUITask unchartedUITask = (UnchartedUITask)LuaObject.checkSelf(l);
			UIIntent intent;
			LuaObject.checkType<UIIntent>(l, 2, out intent);
			bool b = unchartedUITask.m_luaExportHelper.__callBase_OnNewIntent(intent);
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

	// Token: 0x06022088 RID: 139400 RVA: 0x00B99DB4 File Offset: 0x00B97FB4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_EnableUIInput(IntPtr l)
	{
		int result;
		try
		{
			UnchartedUITask unchartedUITask = (UnchartedUITask)LuaObject.checkSelf(l);
			bool isEnable;
			LuaObject.checkType(l, 2, out isEnable);
			bool? isGlobalEnable;
			LuaObject.checkNullable<bool>(l, 3, out isGlobalEnable);
			unchartedUITask.m_luaExportHelper.__callBase_EnableUIInput(isEnable, isGlobalEnable);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06022089 RID: 139401 RVA: 0x00B99E20 File Offset: 0x00B98020
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_IsNeedLoadDynamicRes(IntPtr l)
	{
		int result;
		try
		{
			UnchartedUITask unchartedUITask = (UnchartedUITask)LuaObject.checkSelf(l);
			bool b = unchartedUITask.m_luaExportHelper.__callBase_IsNeedLoadDynamicRes();
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

	// Token: 0x0602208A RID: 139402 RVA: 0x00B99E7C File Offset: 0x00B9807C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_CollectAllDynamicResForLoad(IntPtr l)
	{
		int result;
		try
		{
			UnchartedUITask unchartedUITask = (UnchartedUITask)LuaObject.checkSelf(l);
			List<string> o = unchartedUITask.m_luaExportHelper.__callBase_CollectAllDynamicResForLoad();
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

	// Token: 0x0602208B RID: 139403 RVA: 0x00B99ED8 File Offset: 0x00B980D8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_RegisterPlayerContextEvents(IntPtr l)
	{
		int result;
		try
		{
			UnchartedUITask unchartedUITask = (UnchartedUITask)LuaObject.checkSelf(l);
			unchartedUITask.m_luaExportHelper.__callBase_RegisterPlayerContextEvents();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0602208C RID: 139404 RVA: 0x00B99F2C File Offset: 0x00B9812C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_UnregisterPlayerContextEvents(IntPtr l)
	{
		int result;
		try
		{
			UnchartedUITask unchartedUITask = (UnchartedUITask)LuaObject.checkSelf(l);
			unchartedUITask.m_luaExportHelper.__callBase_UnregisterPlayerContextEvents();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0602208D RID: 139405 RVA: 0x00B99F80 File Offset: 0x00B98180
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_PostUpdateView(IntPtr l)
	{
		int result;
		try
		{
			UnchartedUITask unchartedUITask = (UnchartedUITask)LuaObject.checkSelf(l);
			unchartedUITask.m_luaExportHelper.__callBase_PostUpdateView();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0602208E RID: 139406 RVA: 0x00B99FD4 File Offset: 0x00B981D4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_CollectPreloadResourceList(IntPtr l)
	{
		int result;
		try
		{
			UnchartedUITask unchartedUITask = (UnchartedUITask)LuaObject.checkSelf(l);
			unchartedUITask.m_luaExportHelper.__callBase_CollectPreloadResourceList();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0602208F RID: 139407 RVA: 0x00B9A028 File Offset: 0x00B98228
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_ClearAssetList(IntPtr l)
	{
		int result;
		try
		{
			UnchartedUITask unchartedUITask = (UnchartedUITask)LuaObject.checkSelf(l);
			unchartedUITask.m_luaExportHelper.__callBase_ClearAssetList();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06022090 RID: 139408 RVA: 0x00B9A07C File Offset: 0x00B9827C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_CollectAsset(IntPtr l)
	{
		int result;
		try
		{
			UnchartedUITask unchartedUITask = (UnchartedUITask)LuaObject.checkSelf(l);
			string assetName;
			LuaObject.checkType(l, 2, out assetName);
			unchartedUITask.m_luaExportHelper.__callBase_CollectAsset(assetName);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06022091 RID: 139409 RVA: 0x00B9A0D8 File Offset: 0x00B982D8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_CollectSpriteAsset(IntPtr l)
	{
		int result;
		try
		{
			UnchartedUITask unchartedUITask = (UnchartedUITask)LuaObject.checkSelf(l);
			string assetName;
			LuaObject.checkType(l, 2, out assetName);
			unchartedUITask.m_luaExportHelper.__callBase_CollectSpriteAsset(assetName);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06022092 RID: 139410 RVA: 0x00B9A134 File Offset: 0x00B98334
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_CollectFxAsset(IntPtr l)
	{
		int result;
		try
		{
			UnchartedUITask unchartedUITask = (UnchartedUITask)LuaObject.checkSelf(l);
			string assetName;
			LuaObject.checkType(l, 2, out assetName);
			unchartedUITask.m_luaExportHelper.__callBase_CollectFxAsset(assetName);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06022093 RID: 139411 RVA: 0x00B9A190 File Offset: 0x00B98390
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_StartLoadCustomAssets(IntPtr l)
	{
		int result;
		try
		{
			UnchartedUITask unchartedUITask = (UnchartedUITask)LuaObject.checkSelf(l);
			Action onLoadCompleted;
			LuaObject.checkDelegate<Action>(l, 2, out onLoadCompleted);
			unchartedUITask.m_luaExportHelper.__callBase_StartLoadCustomAssets(onLoadCompleted);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06022094 RID: 139412 RVA: 0x00B9A1EC File Offset: 0x00B983EC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_IsLoadingCustomAssets(IntPtr l)
	{
		int result;
		try
		{
			UnchartedUITask unchartedUITask = (UnchartedUITask)LuaObject.checkSelf(l);
			bool b = unchartedUITask.m_luaExportHelper.__callBase_IsLoadingCustomAssets();
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

	// Token: 0x06022095 RID: 139413 RVA: 0x00B9A248 File Offset: 0x00B98448
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_IsPipeLineRunning(IntPtr l)
	{
		int result;
		try
		{
			UnchartedUITask unchartedUITask = (UnchartedUITask)LuaObject.checkSelf(l);
			bool b = unchartedUITask.m_luaExportHelper.__callBase_IsPipeLineRunning();
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

	// Token: 0x06022096 RID: 139414 RVA: 0x00B9A2A4 File Offset: 0x00B984A4
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int __callBase_IsOpeningUI(IntPtr l)
	{
		int result;
		try
		{
			UnchartedUITask unchartedUITask = (UnchartedUITask)LuaObject.checkSelf(l);
			bool b = unchartedUITask.m_luaExportHelper.__callBase_IsOpeningUI();
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

	// Token: 0x06022097 RID: 139415 RVA: 0x00B9A300 File Offset: 0x00B98500
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_ReturnPrevUITask(IntPtr l)
	{
		int result;
		try
		{
			UnchartedUITask unchartedUITask = (UnchartedUITask)LuaObject.checkSelf(l);
			UITaskBase o = unchartedUITask.m_luaExportHelper.__callBase_ReturnPrevUITask();
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

	// Token: 0x06022098 RID: 139416 RVA: 0x00B9A35C File Offset: 0x00B9855C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_ClearUnusedDynamicResourceCache(IntPtr l)
	{
		int result;
		try
		{
			UnchartedUITask unchartedUITask = (UnchartedUITask)LuaObject.checkSelf(l);
			unchartedUITask.m_luaExportHelper.__callBase_ClearUnusedDynamicResourceCache();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06022099 RID: 139417 RVA: 0x00B9A3B0 File Offset: 0x00B985B0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_OnMemoryWarning(IntPtr l)
	{
		int result;
		try
		{
			UnchartedUITask unchartedUITask = (UnchartedUITask)LuaObject.checkSelf(l);
			unchartedUITask.m_luaExportHelper.__callBase_OnMemoryWarning();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0602209A RID: 139418 RVA: 0x00B9A404 File Offset: 0x00B98604
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_layerDescArray(IntPtr l)
	{
		int result;
		try
		{
			UnchartedUITask unchartedUITask = (UnchartedUITask)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, unchartedUITask.m_luaExportHelper.m_layerDescArray);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0602209B RID: 139419 RVA: 0x00B9A45C File Offset: 0x00B9865C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_layerDescArray(IntPtr l)
	{
		int result;
		try
		{
			UnchartedUITask unchartedUITask = (UnchartedUITask)LuaObject.checkSelf(l);
			UITaskBase.LayerDesc[] layerDescArray;
			LuaObject.checkArray<UITaskBase.LayerDesc>(l, 2, out layerDescArray);
			unchartedUITask.m_luaExportHelper.m_layerDescArray = layerDescArray;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0602209C RID: 139420 RVA: 0x00B9A4B8 File Offset: 0x00B986B8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_uiCtrlDescArray(IntPtr l)
	{
		int result;
		try
		{
			UnchartedUITask unchartedUITask = (UnchartedUITask)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, unchartedUITask.m_luaExportHelper.m_uiCtrlDescArray);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0602209D RID: 139421 RVA: 0x00B9A510 File Offset: 0x00B98710
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_m_uiCtrlDescArray(IntPtr l)
	{
		int result;
		try
		{
			UnchartedUITask unchartedUITask = (UnchartedUITask)LuaObject.checkSelf(l);
			UITaskBase.UIControllerDesc[] uiCtrlDescArray;
			LuaObject.checkArray<UITaskBase.UIControllerDesc>(l, 2, out uiCtrlDescArray);
			unchartedUITask.m_luaExportHelper.m_uiCtrlDescArray = uiCtrlDescArray;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0602209E RID: 139422 RVA: 0x00B9A56C File Offset: 0x00B9876C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_unchartedUIController(IntPtr l)
	{
		int result;
		try
		{
			UnchartedUITask unchartedUITask = (UnchartedUITask)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, unchartedUITask.m_luaExportHelper.m_unchartedUIController);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0602209F RID: 139423 RVA: 0x00B9A5C4 File Offset: 0x00B987C4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_unchartedUIController(IntPtr l)
	{
		int result;
		try
		{
			UnchartedUITask unchartedUITask = (UnchartedUITask)LuaObject.checkSelf(l);
			UnchartedUIController unchartedUIController;
			LuaObject.checkType<UnchartedUIController>(l, 2, out unchartedUIController);
			unchartedUITask.m_luaExportHelper.m_unchartedUIController = unchartedUIController;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060220A0 RID: 139424 RVA: 0x00B9A620 File Offset: 0x00B98820
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_nowSeconds(IntPtr l)
	{
		int result;
		try
		{
			UnchartedUITask unchartedUITask = (UnchartedUITask)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, unchartedUITask.m_luaExportHelper.m_nowSeconds);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060220A1 RID: 139425 RVA: 0x00B9A678 File Offset: 0x00B98878
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_nowSeconds(IntPtr l)
	{
		int result;
		try
		{
			UnchartedUITask unchartedUITask = (UnchartedUITask)LuaObject.checkSelf(l);
			int nowSeconds;
			LuaObject.checkType(l, 2, out nowSeconds);
			unchartedUITask.m_luaExportHelper.m_nowSeconds = nowSeconds;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060220A2 RID: 139426 RVA: 0x00B9A6D4 File Offset: 0x00B988D4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_nextCheckClimbTowerFlushTime(IntPtr l)
	{
		int result;
		try
		{
			UnchartedUITask unchartedUITask = (UnchartedUITask)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, unchartedUITask.m_luaExportHelper.m_nextCheckClimbTowerFlushTime);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060220A3 RID: 139427 RVA: 0x00B9A730 File Offset: 0x00B98930
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_nextCheckClimbTowerFlushTime(IntPtr l)
	{
		int result;
		try
		{
			UnchartedUITask unchartedUITask = (UnchartedUITask)LuaObject.checkSelf(l);
			DateTime nextCheckClimbTowerFlushTime;
			LuaObject.checkValueType<DateTime>(l, 2, out nextCheckClimbTowerFlushTime);
			unchartedUITask.m_luaExportHelper.m_nextCheckClimbTowerFlushTime = nextCheckClimbTowerFlushTime;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060220A4 RID: 139428 RVA: 0x00B9A78C File Offset: 0x00B9898C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_LayerDescArray(IntPtr l)
	{
		int result;
		try
		{
			UnchartedUITask unchartedUITask = (UnchartedUITask)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, unchartedUITask.m_luaExportHelper.LayerDescArray);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060220A5 RID: 139429 RVA: 0x00B9A7E4 File Offset: 0x00B989E4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_UICtrlDescArray(IntPtr l)
	{
		int result;
		try
		{
			UnchartedUITask unchartedUITask = (UnchartedUITask)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, unchartedUITask.m_luaExportHelper.UICtrlDescArray);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060220A6 RID: 139430 RVA: 0x00B9A83C File Offset: 0x00B98A3C
	[Preserve]
	public static void reg(IntPtr l)
	{
		LuaObject.getTypeTable(l, "BlackJack.ProjectL.UI.UnchartedUITask");
		if (Lua_BlackJack_ProjectL_UI_UnchartedUITask.<>f__mg$cache0 == null)
		{
			Lua_BlackJack_ProjectL_UI_UnchartedUITask.<>f__mg$cache0 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_UnchartedUITask.IsNeedLoadDynamicRes);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_UnchartedUITask.<>f__mg$cache0);
		if (Lua_BlackJack_ProjectL_UI_UnchartedUITask.<>f__mg$cache1 == null)
		{
			Lua_BlackJack_ProjectL_UI_UnchartedUITask.<>f__mg$cache1 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_UnchartedUITask.InitAllUIControllers);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_UnchartedUITask.<>f__mg$cache1);
		if (Lua_BlackJack_ProjectL_UI_UnchartedUITask.<>f__mg$cache2 == null)
		{
			Lua_BlackJack_ProjectL_UI_UnchartedUITask.<>f__mg$cache2 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_UnchartedUITask.ClearAllContextAndRes);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_UnchartedUITask.<>f__mg$cache2);
		if (Lua_BlackJack_ProjectL_UI_UnchartedUITask.<>f__mg$cache3 == null)
		{
			Lua_BlackJack_ProjectL_UI_UnchartedUITask.<>f__mg$cache3 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_UnchartedUITask.InitUnchartedUIController);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_UnchartedUITask.<>f__mg$cache3);
		if (Lua_BlackJack_ProjectL_UI_UnchartedUITask.<>f__mg$cache4 == null)
		{
			Lua_BlackJack_ProjectL_UI_UnchartedUITask.<>f__mg$cache4 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_UnchartedUITask.UninitUnchartedUIController);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_UnchartedUITask.<>f__mg$cache4);
		if (Lua_BlackJack_ProjectL_UI_UnchartedUITask.<>f__mg$cache5 == null)
		{
			Lua_BlackJack_ProjectL_UI_UnchartedUITask.<>f__mg$cache5 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_UnchartedUITask.OnTick);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_UnchartedUITask.<>f__mg$cache5);
		if (Lua_BlackJack_ProjectL_UI_UnchartedUITask.<>f__mg$cache6 == null)
		{
			Lua_BlackJack_ProjectL_UI_UnchartedUITask.<>f__mg$cache6 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_UnchartedUITask.UpdateView);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_UnchartedUITask.<>f__mg$cache6);
		if (Lua_BlackJack_ProjectL_UI_UnchartedUITask.<>f__mg$cache7 == null)
		{
			Lua_BlackJack_ProjectL_UI_UnchartedUITask.<>f__mg$cache7 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_UnchartedUITask.UpdateClimbTowerFlushTime);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_UnchartedUITask.<>f__mg$cache7);
		if (Lua_BlackJack_ProjectL_UI_UnchartedUITask.<>f__mg$cache8 == null)
		{
			Lua_BlackJack_ProjectL_UI_UnchartedUITask.<>f__mg$cache8 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_UnchartedUITask.FlushClimbTower);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_UnchartedUITask.<>f__mg$cache8);
		if (Lua_BlackJack_ProjectL_UI_UnchartedUITask.<>f__mg$cache9 == null)
		{
			Lua_BlackJack_ProjectL_UI_UnchartedUITask.<>f__mg$cache9 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_UnchartedUITask.UnchartedUIController_OnShowUncharted);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_UnchartedUITask.<>f__mg$cache9);
		if (Lua_BlackJack_ProjectL_UI_UnchartedUITask.<>f__mg$cacheA == null)
		{
			Lua_BlackJack_ProjectL_UI_UnchartedUITask.<>f__mg$cacheA = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_UnchartedUITask.UnchartedUIController_OnShowTeam);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_UnchartedUITask.<>f__mg$cacheA);
		if (Lua_BlackJack_ProjectL_UI_UnchartedUITask.<>f__mg$cacheB == null)
		{
			Lua_BlackJack_ProjectL_UI_UnchartedUITask.<>f__mg$cacheB = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_UnchartedUITask.TeamUITask_OnLoadAllResCompleted);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_UnchartedUITask.<>f__mg$cacheB);
		if (Lua_BlackJack_ProjectL_UI_UnchartedUITask.<>f__mg$cacheC == null)
		{
			Lua_BlackJack_ProjectL_UI_UnchartedUITask.<>f__mg$cacheC = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_UnchartedUITask.UnchartedUIController_OnReturn);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_UnchartedUITask.<>f__mg$cacheC);
		if (Lua_BlackJack_ProjectL_UI_UnchartedUITask.<>f__mg$cacheD == null)
		{
			Lua_BlackJack_ProjectL_UI_UnchartedUITask.<>f__mg$cacheD = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_UnchartedUITask.__callBase_OnStart);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_UnchartedUITask.<>f__mg$cacheD);
		if (Lua_BlackJack_ProjectL_UI_UnchartedUITask.<>f__mg$cacheE == null)
		{
			Lua_BlackJack_ProjectL_UI_UnchartedUITask.<>f__mg$cacheE = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_UnchartedUITask.__callBase_OnStop);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_UnchartedUITask.<>f__mg$cacheE);
		if (Lua_BlackJack_ProjectL_UI_UnchartedUITask.<>f__mg$cacheF == null)
		{
			Lua_BlackJack_ProjectL_UI_UnchartedUITask.<>f__mg$cacheF = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_UnchartedUITask.__callBase_OnPause);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_UnchartedUITask.<>f__mg$cacheF);
		if (Lua_BlackJack_ProjectL_UI_UnchartedUITask.<>f__mg$cache10 == null)
		{
			Lua_BlackJack_ProjectL_UI_UnchartedUITask.<>f__mg$cache10 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_UnchartedUITask.__callBase_OnResume);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_UnchartedUITask.<>f__mg$cache10);
		if (Lua_BlackJack_ProjectL_UI_UnchartedUITask.<>f__mg$cache11 == null)
		{
			Lua_BlackJack_ProjectL_UI_UnchartedUITask.<>f__mg$cache11 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_UnchartedUITask.__callBase_OnNewIntent);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_UnchartedUITask.<>f__mg$cache11);
		if (Lua_BlackJack_ProjectL_UI_UnchartedUITask.<>f__mg$cache12 == null)
		{
			Lua_BlackJack_ProjectL_UI_UnchartedUITask.<>f__mg$cache12 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_UnchartedUITask.__callBase_EnableUIInput);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_UnchartedUITask.<>f__mg$cache12);
		if (Lua_BlackJack_ProjectL_UI_UnchartedUITask.<>f__mg$cache13 == null)
		{
			Lua_BlackJack_ProjectL_UI_UnchartedUITask.<>f__mg$cache13 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_UnchartedUITask.__callBase_IsNeedLoadDynamicRes);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_UnchartedUITask.<>f__mg$cache13);
		if (Lua_BlackJack_ProjectL_UI_UnchartedUITask.<>f__mg$cache14 == null)
		{
			Lua_BlackJack_ProjectL_UI_UnchartedUITask.<>f__mg$cache14 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_UnchartedUITask.__callBase_CollectAllDynamicResForLoad);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_UnchartedUITask.<>f__mg$cache14);
		if (Lua_BlackJack_ProjectL_UI_UnchartedUITask.<>f__mg$cache15 == null)
		{
			Lua_BlackJack_ProjectL_UI_UnchartedUITask.<>f__mg$cache15 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_UnchartedUITask.__callBase_RegisterPlayerContextEvents);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_UnchartedUITask.<>f__mg$cache15);
		if (Lua_BlackJack_ProjectL_UI_UnchartedUITask.<>f__mg$cache16 == null)
		{
			Lua_BlackJack_ProjectL_UI_UnchartedUITask.<>f__mg$cache16 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_UnchartedUITask.__callBase_UnregisterPlayerContextEvents);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_UnchartedUITask.<>f__mg$cache16);
		if (Lua_BlackJack_ProjectL_UI_UnchartedUITask.<>f__mg$cache17 == null)
		{
			Lua_BlackJack_ProjectL_UI_UnchartedUITask.<>f__mg$cache17 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_UnchartedUITask.__callBase_PostUpdateView);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_UnchartedUITask.<>f__mg$cache17);
		if (Lua_BlackJack_ProjectL_UI_UnchartedUITask.<>f__mg$cache18 == null)
		{
			Lua_BlackJack_ProjectL_UI_UnchartedUITask.<>f__mg$cache18 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_UnchartedUITask.__callBase_CollectPreloadResourceList);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_UnchartedUITask.<>f__mg$cache18);
		if (Lua_BlackJack_ProjectL_UI_UnchartedUITask.<>f__mg$cache19 == null)
		{
			Lua_BlackJack_ProjectL_UI_UnchartedUITask.<>f__mg$cache19 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_UnchartedUITask.__callBase_ClearAssetList);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_UnchartedUITask.<>f__mg$cache19);
		if (Lua_BlackJack_ProjectL_UI_UnchartedUITask.<>f__mg$cache1A == null)
		{
			Lua_BlackJack_ProjectL_UI_UnchartedUITask.<>f__mg$cache1A = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_UnchartedUITask.__callBase_CollectAsset);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_UnchartedUITask.<>f__mg$cache1A);
		if (Lua_BlackJack_ProjectL_UI_UnchartedUITask.<>f__mg$cache1B == null)
		{
			Lua_BlackJack_ProjectL_UI_UnchartedUITask.<>f__mg$cache1B = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_UnchartedUITask.__callBase_CollectSpriteAsset);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_UnchartedUITask.<>f__mg$cache1B);
		if (Lua_BlackJack_ProjectL_UI_UnchartedUITask.<>f__mg$cache1C == null)
		{
			Lua_BlackJack_ProjectL_UI_UnchartedUITask.<>f__mg$cache1C = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_UnchartedUITask.__callBase_CollectFxAsset);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_UnchartedUITask.<>f__mg$cache1C);
		if (Lua_BlackJack_ProjectL_UI_UnchartedUITask.<>f__mg$cache1D == null)
		{
			Lua_BlackJack_ProjectL_UI_UnchartedUITask.<>f__mg$cache1D = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_UnchartedUITask.__callBase_StartLoadCustomAssets);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_UnchartedUITask.<>f__mg$cache1D);
		if (Lua_BlackJack_ProjectL_UI_UnchartedUITask.<>f__mg$cache1E == null)
		{
			Lua_BlackJack_ProjectL_UI_UnchartedUITask.<>f__mg$cache1E = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_UnchartedUITask.__callBase_IsLoadingCustomAssets);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_UnchartedUITask.<>f__mg$cache1E);
		if (Lua_BlackJack_ProjectL_UI_UnchartedUITask.<>f__mg$cache1F == null)
		{
			Lua_BlackJack_ProjectL_UI_UnchartedUITask.<>f__mg$cache1F = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_UnchartedUITask.__callBase_IsPipeLineRunning);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_UnchartedUITask.<>f__mg$cache1F);
		if (Lua_BlackJack_ProjectL_UI_UnchartedUITask.<>f__mg$cache20 == null)
		{
			Lua_BlackJack_ProjectL_UI_UnchartedUITask.<>f__mg$cache20 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_UnchartedUITask.__callBase_IsOpeningUI);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_UnchartedUITask.<>f__mg$cache20);
		if (Lua_BlackJack_ProjectL_UI_UnchartedUITask.<>f__mg$cache21 == null)
		{
			Lua_BlackJack_ProjectL_UI_UnchartedUITask.<>f__mg$cache21 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_UnchartedUITask.__callBase_ReturnPrevUITask);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_UnchartedUITask.<>f__mg$cache21);
		if (Lua_BlackJack_ProjectL_UI_UnchartedUITask.<>f__mg$cache22 == null)
		{
			Lua_BlackJack_ProjectL_UI_UnchartedUITask.<>f__mg$cache22 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_UnchartedUITask.__callBase_ClearUnusedDynamicResourceCache);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_UnchartedUITask.<>f__mg$cache22);
		if (Lua_BlackJack_ProjectL_UI_UnchartedUITask.<>f__mg$cache23 == null)
		{
			Lua_BlackJack_ProjectL_UI_UnchartedUITask.<>f__mg$cache23 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_UnchartedUITask.__callBase_OnMemoryWarning);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_UnchartedUITask.<>f__mg$cache23);
		string name = "m_layerDescArray";
		if (Lua_BlackJack_ProjectL_UI_UnchartedUITask.<>f__mg$cache24 == null)
		{
			Lua_BlackJack_ProjectL_UI_UnchartedUITask.<>f__mg$cache24 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_UnchartedUITask.get_m_layerDescArray);
		}
		LuaCSFunction get = Lua_BlackJack_ProjectL_UI_UnchartedUITask.<>f__mg$cache24;
		if (Lua_BlackJack_ProjectL_UI_UnchartedUITask.<>f__mg$cache25 == null)
		{
			Lua_BlackJack_ProjectL_UI_UnchartedUITask.<>f__mg$cache25 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_UnchartedUITask.set_m_layerDescArray);
		}
		LuaObject.addMember(l, name, get, Lua_BlackJack_ProjectL_UI_UnchartedUITask.<>f__mg$cache25, true);
		string name2 = "m_uiCtrlDescArray";
		if (Lua_BlackJack_ProjectL_UI_UnchartedUITask.<>f__mg$cache26 == null)
		{
			Lua_BlackJack_ProjectL_UI_UnchartedUITask.<>f__mg$cache26 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_UnchartedUITask.get_m_uiCtrlDescArray);
		}
		LuaCSFunction get2 = Lua_BlackJack_ProjectL_UI_UnchartedUITask.<>f__mg$cache26;
		if (Lua_BlackJack_ProjectL_UI_UnchartedUITask.<>f__mg$cache27 == null)
		{
			Lua_BlackJack_ProjectL_UI_UnchartedUITask.<>f__mg$cache27 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_UnchartedUITask.set_m_uiCtrlDescArray);
		}
		LuaObject.addMember(l, name2, get2, Lua_BlackJack_ProjectL_UI_UnchartedUITask.<>f__mg$cache27, true);
		string name3 = "m_unchartedUIController";
		if (Lua_BlackJack_ProjectL_UI_UnchartedUITask.<>f__mg$cache28 == null)
		{
			Lua_BlackJack_ProjectL_UI_UnchartedUITask.<>f__mg$cache28 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_UnchartedUITask.get_m_unchartedUIController);
		}
		LuaCSFunction get3 = Lua_BlackJack_ProjectL_UI_UnchartedUITask.<>f__mg$cache28;
		if (Lua_BlackJack_ProjectL_UI_UnchartedUITask.<>f__mg$cache29 == null)
		{
			Lua_BlackJack_ProjectL_UI_UnchartedUITask.<>f__mg$cache29 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_UnchartedUITask.set_m_unchartedUIController);
		}
		LuaObject.addMember(l, name3, get3, Lua_BlackJack_ProjectL_UI_UnchartedUITask.<>f__mg$cache29, true);
		string name4 = "m_nowSeconds";
		if (Lua_BlackJack_ProjectL_UI_UnchartedUITask.<>f__mg$cache2A == null)
		{
			Lua_BlackJack_ProjectL_UI_UnchartedUITask.<>f__mg$cache2A = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_UnchartedUITask.get_m_nowSeconds);
		}
		LuaCSFunction get4 = Lua_BlackJack_ProjectL_UI_UnchartedUITask.<>f__mg$cache2A;
		if (Lua_BlackJack_ProjectL_UI_UnchartedUITask.<>f__mg$cache2B == null)
		{
			Lua_BlackJack_ProjectL_UI_UnchartedUITask.<>f__mg$cache2B = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_UnchartedUITask.set_m_nowSeconds);
		}
		LuaObject.addMember(l, name4, get4, Lua_BlackJack_ProjectL_UI_UnchartedUITask.<>f__mg$cache2B, true);
		string name5 = "m_nextCheckClimbTowerFlushTime";
		if (Lua_BlackJack_ProjectL_UI_UnchartedUITask.<>f__mg$cache2C == null)
		{
			Lua_BlackJack_ProjectL_UI_UnchartedUITask.<>f__mg$cache2C = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_UnchartedUITask.get_m_nextCheckClimbTowerFlushTime);
		}
		LuaCSFunction get5 = Lua_BlackJack_ProjectL_UI_UnchartedUITask.<>f__mg$cache2C;
		if (Lua_BlackJack_ProjectL_UI_UnchartedUITask.<>f__mg$cache2D == null)
		{
			Lua_BlackJack_ProjectL_UI_UnchartedUITask.<>f__mg$cache2D = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_UnchartedUITask.set_m_nextCheckClimbTowerFlushTime);
		}
		LuaObject.addMember(l, name5, get5, Lua_BlackJack_ProjectL_UI_UnchartedUITask.<>f__mg$cache2D, true);
		string name6 = "LayerDescArray";
		if (Lua_BlackJack_ProjectL_UI_UnchartedUITask.<>f__mg$cache2E == null)
		{
			Lua_BlackJack_ProjectL_UI_UnchartedUITask.<>f__mg$cache2E = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_UnchartedUITask.get_LayerDescArray);
		}
		LuaObject.addMember(l, name6, Lua_BlackJack_ProjectL_UI_UnchartedUITask.<>f__mg$cache2E, null, true);
		string name7 = "UICtrlDescArray";
		if (Lua_BlackJack_ProjectL_UI_UnchartedUITask.<>f__mg$cache2F == null)
		{
			Lua_BlackJack_ProjectL_UI_UnchartedUITask.<>f__mg$cache2F = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_UnchartedUITask.get_UICtrlDescArray);
		}
		LuaObject.addMember(l, name7, Lua_BlackJack_ProjectL_UI_UnchartedUITask.<>f__mg$cache2F, null, true);
		if (Lua_BlackJack_ProjectL_UI_UnchartedUITask.<>f__mg$cache30 == null)
		{
			Lua_BlackJack_ProjectL_UI_UnchartedUITask.<>f__mg$cache30 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_UnchartedUITask.constructor);
		}
		LuaObject.createTypeMetatable(l, Lua_BlackJack_ProjectL_UI_UnchartedUITask.<>f__mg$cache30, typeof(UnchartedUITask), typeof(UITask));
	}

	// Token: 0x04017EB9 RID: 97977
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache0;

	// Token: 0x04017EBA RID: 97978
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1;

	// Token: 0x04017EBB RID: 97979
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2;

	// Token: 0x04017EBC RID: 97980
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3;

	// Token: 0x04017EBD RID: 97981
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache4;

	// Token: 0x04017EBE RID: 97982
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache5;

	// Token: 0x04017EBF RID: 97983
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache6;

	// Token: 0x04017EC0 RID: 97984
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache7;

	// Token: 0x04017EC1 RID: 97985
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache8;

	// Token: 0x04017EC2 RID: 97986
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache9;

	// Token: 0x04017EC3 RID: 97987
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheA;

	// Token: 0x04017EC4 RID: 97988
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheB;

	// Token: 0x04017EC5 RID: 97989
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheC;

	// Token: 0x04017EC6 RID: 97990
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheD;

	// Token: 0x04017EC7 RID: 97991
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheE;

	// Token: 0x04017EC8 RID: 97992
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheF;

	// Token: 0x04017EC9 RID: 97993
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache10;

	// Token: 0x04017ECA RID: 97994
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache11;

	// Token: 0x04017ECB RID: 97995
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache12;

	// Token: 0x04017ECC RID: 97996
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache13;

	// Token: 0x04017ECD RID: 97997
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache14;

	// Token: 0x04017ECE RID: 97998
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache15;

	// Token: 0x04017ECF RID: 97999
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache16;

	// Token: 0x04017ED0 RID: 98000
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache17;

	// Token: 0x04017ED1 RID: 98001
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache18;

	// Token: 0x04017ED2 RID: 98002
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache19;

	// Token: 0x04017ED3 RID: 98003
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1A;

	// Token: 0x04017ED4 RID: 98004
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1B;

	// Token: 0x04017ED5 RID: 98005
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1C;

	// Token: 0x04017ED6 RID: 98006
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1D;

	// Token: 0x04017ED7 RID: 98007
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1E;

	// Token: 0x04017ED8 RID: 98008
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1F;

	// Token: 0x04017ED9 RID: 98009
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache20;

	// Token: 0x04017EDA RID: 98010
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache21;

	// Token: 0x04017EDB RID: 98011
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache22;

	// Token: 0x04017EDC RID: 98012
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache23;

	// Token: 0x04017EDD RID: 98013
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache24;

	// Token: 0x04017EDE RID: 98014
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache25;

	// Token: 0x04017EDF RID: 98015
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache26;

	// Token: 0x04017EE0 RID: 98016
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache27;

	// Token: 0x04017EE1 RID: 98017
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache28;

	// Token: 0x04017EE2 RID: 98018
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache29;

	// Token: 0x04017EE3 RID: 98019
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2A;

	// Token: 0x04017EE4 RID: 98020
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2B;

	// Token: 0x04017EE5 RID: 98021
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2C;

	// Token: 0x04017EE6 RID: 98022
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2D;

	// Token: 0x04017EE7 RID: 98023
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2E;

	// Token: 0x04017EE8 RID: 98024
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2F;

	// Token: 0x04017EE9 RID: 98025
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache30;
}
