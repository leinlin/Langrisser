using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using BlackJack.BJFramework.Runtime.UI;
using BlackJack.ConfigData;
using BlackJack.ProjectL.UI;
using SLua;
using UnityEngine.Scripting;

// Token: 0x020015E4 RID: 5604
[Preserve]
public class Lua_BlackJack_ProjectL_UI_WorldEventMissionUITask : LuaObject
{
	// Token: 0x0602240C RID: 140300 RVA: 0x00BB58B8 File Offset: 0x00BB3AB8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int constructor(IntPtr l)
	{
		int result;
		try
		{
			string name;
			LuaObject.checkType(l, 2, out name);
			WorldEventMissionUITask o = new WorldEventMissionUITask(name);
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

	// Token: 0x0602240D RID: 140301 RVA: 0x00BB590C File Offset: 0x00BB3B0C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int OnStart(IntPtr l)
	{
		int result;
		try
		{
			WorldEventMissionUITask worldEventMissionUITask = (WorldEventMissionUITask)LuaObject.checkSelf(l);
			UIIntent intent;
			LuaObject.checkType<UIIntent>(l, 2, out intent);
			bool b = worldEventMissionUITask.m_luaExportHelper.OnStart(intent);
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

	// Token: 0x0602240E RID: 140302 RVA: 0x00BB5974 File Offset: 0x00BB3B74
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int OnResume(IntPtr l)
	{
		int result;
		try
		{
			WorldEventMissionUITask worldEventMissionUITask = (WorldEventMissionUITask)LuaObject.checkSelf(l);
			UIIntent intent;
			LuaObject.checkType<UIIntent>(l, 2, out intent);
			bool b = worldEventMissionUITask.m_luaExportHelper.OnResume(intent);
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

	// Token: 0x0602240F RID: 140303 RVA: 0x00BB59DC File Offset: 0x00BB3BDC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int InitDataFromUIIntent(IntPtr l)
	{
		int result;
		try
		{
			WorldEventMissionUITask worldEventMissionUITask = (WorldEventMissionUITask)LuaObject.checkSelf(l);
			UIIntent intent;
			LuaObject.checkType<UIIntent>(l, 2, out intent);
			worldEventMissionUITask.m_luaExportHelper.InitDataFromUIIntent(intent);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06022410 RID: 140304 RVA: 0x00BB5A38 File Offset: 0x00BB3C38
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int IsNeedLoadDynamicRes(IntPtr l)
	{
		int result;
		try
		{
			WorldEventMissionUITask worldEventMissionUITask = (WorldEventMissionUITask)LuaObject.checkSelf(l);
			bool b = worldEventMissionUITask.m_luaExportHelper.IsNeedLoadDynamicRes();
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

	// Token: 0x06022411 RID: 140305 RVA: 0x00BB5A94 File Offset: 0x00BB3C94
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int InitAllUIControllers(IntPtr l)
	{
		int result;
		try
		{
			WorldEventMissionUITask worldEventMissionUITask = (WorldEventMissionUITask)LuaObject.checkSelf(l);
			worldEventMissionUITask.m_luaExportHelper.InitAllUIControllers();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06022412 RID: 140306 RVA: 0x00BB5AE8 File Offset: 0x00BB3CE8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int ClearAllContextAndRes(IntPtr l)
	{
		int result;
		try
		{
			WorldEventMissionUITask worldEventMissionUITask = (WorldEventMissionUITask)LuaObject.checkSelf(l);
			worldEventMissionUITask.m_luaExportHelper.ClearAllContextAndRes();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06022413 RID: 140307 RVA: 0x00BB5B3C File Offset: 0x00BB3D3C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int InitWorldEventMissionUIController(IntPtr l)
	{
		int result;
		try
		{
			WorldEventMissionUITask worldEventMissionUITask = (WorldEventMissionUITask)LuaObject.checkSelf(l);
			worldEventMissionUITask.m_luaExportHelper.InitWorldEventMissionUIController();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06022414 RID: 140308 RVA: 0x00BB5B90 File Offset: 0x00BB3D90
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int UninitEventMissionUIController(IntPtr l)
	{
		int result;
		try
		{
			WorldEventMissionUITask worldEventMissionUITask = (WorldEventMissionUITask)LuaObject.checkSelf(l);
			worldEventMissionUITask.m_luaExportHelper.UninitEventMissionUIController();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06022415 RID: 140309 RVA: 0x00BB5BE4 File Offset: 0x00BB3DE4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int UpdateView(IntPtr l)
	{
		int result;
		try
		{
			WorldEventMissionUITask worldEventMissionUITask = (WorldEventMissionUITask)LuaObject.checkSelf(l);
			worldEventMissionUITask.m_luaExportHelper.UpdateView();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06022416 RID: 140310 RVA: 0x00BB5C38 File Offset: 0x00BB3E38
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int WorldEventMissionUIController_OnEnterMission(IntPtr l)
	{
		int result;
		try
		{
			WorldEventMissionUITask worldEventMissionUITask = (WorldEventMissionUITask)LuaObject.checkSelf(l);
			worldEventMissionUITask.m_luaExportHelper.WorldEventMissionUIController_OnEnterMission();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06022417 RID: 140311 RVA: 0x00BB5C8C File Offset: 0x00BB3E8C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int WorldEventMissionUIController_OnClose(IntPtr l)
	{
		int result;
		try
		{
			WorldEventMissionUITask worldEventMissionUITask = (WorldEventMissionUITask)LuaObject.checkSelf(l);
			worldEventMissionUITask.m_luaExportHelper.WorldEventMissionUIController_OnClose();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06022418 RID: 140312 RVA: 0x00BB5CE0 File Offset: 0x00BB3EE0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_OnStart(IntPtr l)
	{
		int result;
		try
		{
			WorldEventMissionUITask worldEventMissionUITask = (WorldEventMissionUITask)LuaObject.checkSelf(l);
			UIIntent intent;
			LuaObject.checkType<UIIntent>(l, 2, out intent);
			bool b = worldEventMissionUITask.m_luaExportHelper.__callBase_OnStart(intent);
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

	// Token: 0x06022419 RID: 140313 RVA: 0x00BB5D48 File Offset: 0x00BB3F48
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_OnStop(IntPtr l)
	{
		int result;
		try
		{
			WorldEventMissionUITask worldEventMissionUITask = (WorldEventMissionUITask)LuaObject.checkSelf(l);
			worldEventMissionUITask.m_luaExportHelper.__callBase_OnStop();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0602241A RID: 140314 RVA: 0x00BB5D9C File Offset: 0x00BB3F9C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_OnPause(IntPtr l)
	{
		int result;
		try
		{
			WorldEventMissionUITask worldEventMissionUITask = (WorldEventMissionUITask)LuaObject.checkSelf(l);
			worldEventMissionUITask.m_luaExportHelper.__callBase_OnPause();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0602241B RID: 140315 RVA: 0x00BB5DF0 File Offset: 0x00BB3FF0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_OnResume(IntPtr l)
	{
		int result;
		try
		{
			WorldEventMissionUITask worldEventMissionUITask = (WorldEventMissionUITask)LuaObject.checkSelf(l);
			UIIntent intent;
			LuaObject.checkType<UIIntent>(l, 2, out intent);
			bool b = worldEventMissionUITask.m_luaExportHelper.__callBase_OnResume(intent);
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

	// Token: 0x0602241C RID: 140316 RVA: 0x00BB5E58 File Offset: 0x00BB4058
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_OnNewIntent(IntPtr l)
	{
		int result;
		try
		{
			WorldEventMissionUITask worldEventMissionUITask = (WorldEventMissionUITask)LuaObject.checkSelf(l);
			UIIntent intent;
			LuaObject.checkType<UIIntent>(l, 2, out intent);
			bool b = worldEventMissionUITask.m_luaExportHelper.__callBase_OnNewIntent(intent);
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

	// Token: 0x0602241D RID: 140317 RVA: 0x00BB5EC0 File Offset: 0x00BB40C0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_EnableUIInput(IntPtr l)
	{
		int result;
		try
		{
			WorldEventMissionUITask worldEventMissionUITask = (WorldEventMissionUITask)LuaObject.checkSelf(l);
			bool isEnable;
			LuaObject.checkType(l, 2, out isEnable);
			bool? isGlobalEnable;
			LuaObject.checkNullable<bool>(l, 3, out isGlobalEnable);
			worldEventMissionUITask.m_luaExportHelper.__callBase_EnableUIInput(isEnable, isGlobalEnable);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0602241E RID: 140318 RVA: 0x00BB5F2C File Offset: 0x00BB412C
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int __callBase_IsNeedLoadDynamicRes(IntPtr l)
	{
		int result;
		try
		{
			WorldEventMissionUITask worldEventMissionUITask = (WorldEventMissionUITask)LuaObject.checkSelf(l);
			bool b = worldEventMissionUITask.m_luaExportHelper.__callBase_IsNeedLoadDynamicRes();
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

	// Token: 0x0602241F RID: 140319 RVA: 0x00BB5F88 File Offset: 0x00BB4188
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_CollectAllDynamicResForLoad(IntPtr l)
	{
		int result;
		try
		{
			WorldEventMissionUITask worldEventMissionUITask = (WorldEventMissionUITask)LuaObject.checkSelf(l);
			List<string> o = worldEventMissionUITask.m_luaExportHelper.__callBase_CollectAllDynamicResForLoad();
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

	// Token: 0x06022420 RID: 140320 RVA: 0x00BB5FE4 File Offset: 0x00BB41E4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_RegisterPlayerContextEvents(IntPtr l)
	{
		int result;
		try
		{
			WorldEventMissionUITask worldEventMissionUITask = (WorldEventMissionUITask)LuaObject.checkSelf(l);
			worldEventMissionUITask.m_luaExportHelper.__callBase_RegisterPlayerContextEvents();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06022421 RID: 140321 RVA: 0x00BB6038 File Offset: 0x00BB4238
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_UnregisterPlayerContextEvents(IntPtr l)
	{
		int result;
		try
		{
			WorldEventMissionUITask worldEventMissionUITask = (WorldEventMissionUITask)LuaObject.checkSelf(l);
			worldEventMissionUITask.m_luaExportHelper.__callBase_UnregisterPlayerContextEvents();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06022422 RID: 140322 RVA: 0x00BB608C File Offset: 0x00BB428C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_PostUpdateView(IntPtr l)
	{
		int result;
		try
		{
			WorldEventMissionUITask worldEventMissionUITask = (WorldEventMissionUITask)LuaObject.checkSelf(l);
			worldEventMissionUITask.m_luaExportHelper.__callBase_PostUpdateView();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06022423 RID: 140323 RVA: 0x00BB60E0 File Offset: 0x00BB42E0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_CollectPreloadResourceList(IntPtr l)
	{
		int result;
		try
		{
			WorldEventMissionUITask worldEventMissionUITask = (WorldEventMissionUITask)LuaObject.checkSelf(l);
			worldEventMissionUITask.m_luaExportHelper.__callBase_CollectPreloadResourceList();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06022424 RID: 140324 RVA: 0x00BB6134 File Offset: 0x00BB4334
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_ClearAssetList(IntPtr l)
	{
		int result;
		try
		{
			WorldEventMissionUITask worldEventMissionUITask = (WorldEventMissionUITask)LuaObject.checkSelf(l);
			worldEventMissionUITask.m_luaExportHelper.__callBase_ClearAssetList();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06022425 RID: 140325 RVA: 0x00BB6188 File Offset: 0x00BB4388
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_CollectAsset(IntPtr l)
	{
		int result;
		try
		{
			WorldEventMissionUITask worldEventMissionUITask = (WorldEventMissionUITask)LuaObject.checkSelf(l);
			string assetName;
			LuaObject.checkType(l, 2, out assetName);
			worldEventMissionUITask.m_luaExportHelper.__callBase_CollectAsset(assetName);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06022426 RID: 140326 RVA: 0x00BB61E4 File Offset: 0x00BB43E4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_CollectSpriteAsset(IntPtr l)
	{
		int result;
		try
		{
			WorldEventMissionUITask worldEventMissionUITask = (WorldEventMissionUITask)LuaObject.checkSelf(l);
			string assetName;
			LuaObject.checkType(l, 2, out assetName);
			worldEventMissionUITask.m_luaExportHelper.__callBase_CollectSpriteAsset(assetName);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06022427 RID: 140327 RVA: 0x00BB6240 File Offset: 0x00BB4440
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_CollectFxAsset(IntPtr l)
	{
		int result;
		try
		{
			WorldEventMissionUITask worldEventMissionUITask = (WorldEventMissionUITask)LuaObject.checkSelf(l);
			string assetName;
			LuaObject.checkType(l, 2, out assetName);
			worldEventMissionUITask.m_luaExportHelper.__callBase_CollectFxAsset(assetName);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06022428 RID: 140328 RVA: 0x00BB629C File Offset: 0x00BB449C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_StartLoadCustomAssets(IntPtr l)
	{
		int result;
		try
		{
			WorldEventMissionUITask worldEventMissionUITask = (WorldEventMissionUITask)LuaObject.checkSelf(l);
			Action onLoadCompleted;
			LuaObject.checkDelegate<Action>(l, 2, out onLoadCompleted);
			worldEventMissionUITask.m_luaExportHelper.__callBase_StartLoadCustomAssets(onLoadCompleted);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06022429 RID: 140329 RVA: 0x00BB62F8 File Offset: 0x00BB44F8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_IsLoadingCustomAssets(IntPtr l)
	{
		int result;
		try
		{
			WorldEventMissionUITask worldEventMissionUITask = (WorldEventMissionUITask)LuaObject.checkSelf(l);
			bool b = worldEventMissionUITask.m_luaExportHelper.__callBase_IsLoadingCustomAssets();
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

	// Token: 0x0602242A RID: 140330 RVA: 0x00BB6354 File Offset: 0x00BB4554
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_IsPipeLineRunning(IntPtr l)
	{
		int result;
		try
		{
			WorldEventMissionUITask worldEventMissionUITask = (WorldEventMissionUITask)LuaObject.checkSelf(l);
			bool b = worldEventMissionUITask.m_luaExportHelper.__callBase_IsPipeLineRunning();
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

	// Token: 0x0602242B RID: 140331 RVA: 0x00BB63B0 File Offset: 0x00BB45B0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_IsOpeningUI(IntPtr l)
	{
		int result;
		try
		{
			WorldEventMissionUITask worldEventMissionUITask = (WorldEventMissionUITask)LuaObject.checkSelf(l);
			bool b = worldEventMissionUITask.m_luaExportHelper.__callBase_IsOpeningUI();
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

	// Token: 0x0602242C RID: 140332 RVA: 0x00BB640C File Offset: 0x00BB460C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_ReturnPrevUITask(IntPtr l)
	{
		int result;
		try
		{
			WorldEventMissionUITask worldEventMissionUITask = (WorldEventMissionUITask)LuaObject.checkSelf(l);
			UITaskBase o = worldEventMissionUITask.m_luaExportHelper.__callBase_ReturnPrevUITask();
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

	// Token: 0x0602242D RID: 140333 RVA: 0x00BB6468 File Offset: 0x00BB4668
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_ClearUnusedDynamicResourceCache(IntPtr l)
	{
		int result;
		try
		{
			WorldEventMissionUITask worldEventMissionUITask = (WorldEventMissionUITask)LuaObject.checkSelf(l);
			worldEventMissionUITask.m_luaExportHelper.__callBase_ClearUnusedDynamicResourceCache();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0602242E RID: 140334 RVA: 0x00BB64BC File Offset: 0x00BB46BC
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int __callBase_OnMemoryWarning(IntPtr l)
	{
		int result;
		try
		{
			WorldEventMissionUITask worldEventMissionUITask = (WorldEventMissionUITask)LuaObject.checkSelf(l);
			worldEventMissionUITask.m_luaExportHelper.__callBase_OnMemoryWarning();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0602242F RID: 140335 RVA: 0x00BB6510 File Offset: 0x00BB4710
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callDele_EventOnEnterMission(IntPtr l)
	{
		int result;
		try
		{
			WorldEventMissionUITask worldEventMissionUITask = (WorldEventMissionUITask)LuaObject.checkSelf(l);
			worldEventMissionUITask.m_luaExportHelper.__callDele_EventOnEnterMission();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06022430 RID: 140336 RVA: 0x00BB6564 File Offset: 0x00BB4764
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __clearDele_EventOnEnterMission(IntPtr l)
	{
		int result;
		try
		{
			WorldEventMissionUITask worldEventMissionUITask = (WorldEventMissionUITask)LuaObject.checkSelf(l);
			worldEventMissionUITask.m_luaExportHelper.__clearDele_EventOnEnterMission();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06022431 RID: 140337 RVA: 0x00BB65B8 File Offset: 0x00BB47B8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callDele_EventOnClose(IntPtr l)
	{
		int result;
		try
		{
			WorldEventMissionUITask worldEventMissionUITask = (WorldEventMissionUITask)LuaObject.checkSelf(l);
			worldEventMissionUITask.m_luaExportHelper.__callDele_EventOnClose();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06022432 RID: 140338 RVA: 0x00BB660C File Offset: 0x00BB480C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __clearDele_EventOnClose(IntPtr l)
	{
		int result;
		try
		{
			WorldEventMissionUITask worldEventMissionUITask = (WorldEventMissionUITask)LuaObject.checkSelf(l);
			worldEventMissionUITask.m_luaExportHelper.__clearDele_EventOnClose();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06022433 RID: 140339 RVA: 0x00BB6660 File Offset: 0x00BB4860
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_EventOnEnterMission(IntPtr l)
	{
		int result;
		try
		{
			WorldEventMissionUITask worldEventMissionUITask = (WorldEventMissionUITask)LuaObject.checkSelf(l);
			Action value;
			int num = LuaObject.checkDelegate<Action>(l, 2, out value);
			if (num != 0)
			{
				if (num == 1)
				{
					worldEventMissionUITask.EventOnEnterMission += value;
				}
				else if (num == 2)
				{
					worldEventMissionUITask.EventOnEnterMission -= value;
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

	// Token: 0x06022434 RID: 140340 RVA: 0x00BB66E0 File Offset: 0x00BB48E0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_EventOnClose(IntPtr l)
	{
		int result;
		try
		{
			WorldEventMissionUITask worldEventMissionUITask = (WorldEventMissionUITask)LuaObject.checkSelf(l);
			Action value;
			int num = LuaObject.checkDelegate<Action>(l, 2, out value);
			if (num != 0)
			{
				if (num == 1)
				{
					worldEventMissionUITask.EventOnClose += value;
				}
				else if (num == 2)
				{
					worldEventMissionUITask.EventOnClose -= value;
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

	// Token: 0x06022435 RID: 140341 RVA: 0x00BB6760 File Offset: 0x00BB4960
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_layerDescArray(IntPtr l)
	{
		int result;
		try
		{
			WorldEventMissionUITask worldEventMissionUITask = (WorldEventMissionUITask)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, worldEventMissionUITask.m_luaExportHelper.m_layerDescArray);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06022436 RID: 140342 RVA: 0x00BB67B8 File Offset: 0x00BB49B8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_layerDescArray(IntPtr l)
	{
		int result;
		try
		{
			WorldEventMissionUITask worldEventMissionUITask = (WorldEventMissionUITask)LuaObject.checkSelf(l);
			UITaskBase.LayerDesc[] layerDescArray;
			LuaObject.checkArray<UITaskBase.LayerDesc>(l, 2, out layerDescArray);
			worldEventMissionUITask.m_luaExportHelper.m_layerDescArray = layerDescArray;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06022437 RID: 140343 RVA: 0x00BB6814 File Offset: 0x00BB4A14
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_uiCtrlDescArray(IntPtr l)
	{
		int result;
		try
		{
			WorldEventMissionUITask worldEventMissionUITask = (WorldEventMissionUITask)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, worldEventMissionUITask.m_luaExportHelper.m_uiCtrlDescArray);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06022438 RID: 140344 RVA: 0x00BB686C File Offset: 0x00BB4A6C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_uiCtrlDescArray(IntPtr l)
	{
		int result;
		try
		{
			WorldEventMissionUITask worldEventMissionUITask = (WorldEventMissionUITask)LuaObject.checkSelf(l);
			UITaskBase.UIControllerDesc[] uiCtrlDescArray;
			LuaObject.checkArray<UITaskBase.UIControllerDesc>(l, 2, out uiCtrlDescArray);
			worldEventMissionUITask.m_luaExportHelper.m_uiCtrlDescArray = uiCtrlDescArray;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06022439 RID: 140345 RVA: 0x00BB68C8 File Offset: 0x00BB4AC8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_worldEventMissionUIController(IntPtr l)
	{
		int result;
		try
		{
			WorldEventMissionUITask worldEventMissionUITask = (WorldEventMissionUITask)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, worldEventMissionUITask.m_luaExportHelper.m_worldEventMissionUIController);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0602243A RID: 140346 RVA: 0x00BB6920 File Offset: 0x00BB4B20
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_worldEventMissionUIController(IntPtr l)
	{
		int result;
		try
		{
			WorldEventMissionUITask worldEventMissionUITask = (WorldEventMissionUITask)LuaObject.checkSelf(l);
			WorldEventMissionUIController worldEventMissionUIController;
			LuaObject.checkType<WorldEventMissionUIController>(l, 2, out worldEventMissionUIController);
			worldEventMissionUITask.m_luaExportHelper.m_worldEventMissionUIController = worldEventMissionUIController;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0602243B RID: 140347 RVA: 0x00BB697C File Offset: 0x00BB4B7C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_eventInfo(IntPtr l)
	{
		int result;
		try
		{
			WorldEventMissionUITask worldEventMissionUITask = (WorldEventMissionUITask)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, worldEventMissionUITask.m_luaExportHelper.m_eventInfo);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0602243C RID: 140348 RVA: 0x00BB69D4 File Offset: 0x00BB4BD4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_eventInfo(IntPtr l)
	{
		int result;
		try
		{
			WorldEventMissionUITask worldEventMissionUITask = (WorldEventMissionUITask)LuaObject.checkSelf(l);
			ConfigDataEventInfo eventInfo;
			LuaObject.checkType<ConfigDataEventInfo>(l, 2, out eventInfo);
			worldEventMissionUITask.m_luaExportHelper.m_eventInfo = eventInfo;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0602243D RID: 140349 RVA: 0x00BB6A30 File Offset: 0x00BB4C30
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_LayerDescArray(IntPtr l)
	{
		int result;
		try
		{
			WorldEventMissionUITask worldEventMissionUITask = (WorldEventMissionUITask)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, worldEventMissionUITask.m_luaExportHelper.LayerDescArray);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0602243E RID: 140350 RVA: 0x00BB6A88 File Offset: 0x00BB4C88
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_UICtrlDescArray(IntPtr l)
	{
		int result;
		try
		{
			WorldEventMissionUITask worldEventMissionUITask = (WorldEventMissionUITask)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, worldEventMissionUITask.m_luaExportHelper.UICtrlDescArray);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0602243F RID: 140351 RVA: 0x00BB6AE0 File Offset: 0x00BB4CE0
	[Preserve]
	public static void reg(IntPtr l)
	{
		LuaObject.getTypeTable(l, "BlackJack.ProjectL.UI.WorldEventMissionUITask");
		if (Lua_BlackJack_ProjectL_UI_WorldEventMissionUITask.<>f__mg$cache0 == null)
		{
			Lua_BlackJack_ProjectL_UI_WorldEventMissionUITask.<>f__mg$cache0 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_WorldEventMissionUITask.OnStart);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_WorldEventMissionUITask.<>f__mg$cache0);
		if (Lua_BlackJack_ProjectL_UI_WorldEventMissionUITask.<>f__mg$cache1 == null)
		{
			Lua_BlackJack_ProjectL_UI_WorldEventMissionUITask.<>f__mg$cache1 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_WorldEventMissionUITask.OnResume);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_WorldEventMissionUITask.<>f__mg$cache1);
		if (Lua_BlackJack_ProjectL_UI_WorldEventMissionUITask.<>f__mg$cache2 == null)
		{
			Lua_BlackJack_ProjectL_UI_WorldEventMissionUITask.<>f__mg$cache2 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_WorldEventMissionUITask.InitDataFromUIIntent);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_WorldEventMissionUITask.<>f__mg$cache2);
		if (Lua_BlackJack_ProjectL_UI_WorldEventMissionUITask.<>f__mg$cache3 == null)
		{
			Lua_BlackJack_ProjectL_UI_WorldEventMissionUITask.<>f__mg$cache3 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_WorldEventMissionUITask.IsNeedLoadDynamicRes);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_WorldEventMissionUITask.<>f__mg$cache3);
		if (Lua_BlackJack_ProjectL_UI_WorldEventMissionUITask.<>f__mg$cache4 == null)
		{
			Lua_BlackJack_ProjectL_UI_WorldEventMissionUITask.<>f__mg$cache4 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_WorldEventMissionUITask.InitAllUIControllers);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_WorldEventMissionUITask.<>f__mg$cache4);
		if (Lua_BlackJack_ProjectL_UI_WorldEventMissionUITask.<>f__mg$cache5 == null)
		{
			Lua_BlackJack_ProjectL_UI_WorldEventMissionUITask.<>f__mg$cache5 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_WorldEventMissionUITask.ClearAllContextAndRes);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_WorldEventMissionUITask.<>f__mg$cache5);
		if (Lua_BlackJack_ProjectL_UI_WorldEventMissionUITask.<>f__mg$cache6 == null)
		{
			Lua_BlackJack_ProjectL_UI_WorldEventMissionUITask.<>f__mg$cache6 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_WorldEventMissionUITask.InitWorldEventMissionUIController);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_WorldEventMissionUITask.<>f__mg$cache6);
		if (Lua_BlackJack_ProjectL_UI_WorldEventMissionUITask.<>f__mg$cache7 == null)
		{
			Lua_BlackJack_ProjectL_UI_WorldEventMissionUITask.<>f__mg$cache7 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_WorldEventMissionUITask.UninitEventMissionUIController);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_WorldEventMissionUITask.<>f__mg$cache7);
		if (Lua_BlackJack_ProjectL_UI_WorldEventMissionUITask.<>f__mg$cache8 == null)
		{
			Lua_BlackJack_ProjectL_UI_WorldEventMissionUITask.<>f__mg$cache8 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_WorldEventMissionUITask.UpdateView);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_WorldEventMissionUITask.<>f__mg$cache8);
		if (Lua_BlackJack_ProjectL_UI_WorldEventMissionUITask.<>f__mg$cache9 == null)
		{
			Lua_BlackJack_ProjectL_UI_WorldEventMissionUITask.<>f__mg$cache9 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_WorldEventMissionUITask.WorldEventMissionUIController_OnEnterMission);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_WorldEventMissionUITask.<>f__mg$cache9);
		if (Lua_BlackJack_ProjectL_UI_WorldEventMissionUITask.<>f__mg$cacheA == null)
		{
			Lua_BlackJack_ProjectL_UI_WorldEventMissionUITask.<>f__mg$cacheA = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_WorldEventMissionUITask.WorldEventMissionUIController_OnClose);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_WorldEventMissionUITask.<>f__mg$cacheA);
		if (Lua_BlackJack_ProjectL_UI_WorldEventMissionUITask.<>f__mg$cacheB == null)
		{
			Lua_BlackJack_ProjectL_UI_WorldEventMissionUITask.<>f__mg$cacheB = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_WorldEventMissionUITask.__callBase_OnStart);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_WorldEventMissionUITask.<>f__mg$cacheB);
		if (Lua_BlackJack_ProjectL_UI_WorldEventMissionUITask.<>f__mg$cacheC == null)
		{
			Lua_BlackJack_ProjectL_UI_WorldEventMissionUITask.<>f__mg$cacheC = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_WorldEventMissionUITask.__callBase_OnStop);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_WorldEventMissionUITask.<>f__mg$cacheC);
		if (Lua_BlackJack_ProjectL_UI_WorldEventMissionUITask.<>f__mg$cacheD == null)
		{
			Lua_BlackJack_ProjectL_UI_WorldEventMissionUITask.<>f__mg$cacheD = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_WorldEventMissionUITask.__callBase_OnPause);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_WorldEventMissionUITask.<>f__mg$cacheD);
		if (Lua_BlackJack_ProjectL_UI_WorldEventMissionUITask.<>f__mg$cacheE == null)
		{
			Lua_BlackJack_ProjectL_UI_WorldEventMissionUITask.<>f__mg$cacheE = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_WorldEventMissionUITask.__callBase_OnResume);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_WorldEventMissionUITask.<>f__mg$cacheE);
		if (Lua_BlackJack_ProjectL_UI_WorldEventMissionUITask.<>f__mg$cacheF == null)
		{
			Lua_BlackJack_ProjectL_UI_WorldEventMissionUITask.<>f__mg$cacheF = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_WorldEventMissionUITask.__callBase_OnNewIntent);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_WorldEventMissionUITask.<>f__mg$cacheF);
		if (Lua_BlackJack_ProjectL_UI_WorldEventMissionUITask.<>f__mg$cache10 == null)
		{
			Lua_BlackJack_ProjectL_UI_WorldEventMissionUITask.<>f__mg$cache10 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_WorldEventMissionUITask.__callBase_EnableUIInput);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_WorldEventMissionUITask.<>f__mg$cache10);
		if (Lua_BlackJack_ProjectL_UI_WorldEventMissionUITask.<>f__mg$cache11 == null)
		{
			Lua_BlackJack_ProjectL_UI_WorldEventMissionUITask.<>f__mg$cache11 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_WorldEventMissionUITask.__callBase_IsNeedLoadDynamicRes);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_WorldEventMissionUITask.<>f__mg$cache11);
		if (Lua_BlackJack_ProjectL_UI_WorldEventMissionUITask.<>f__mg$cache12 == null)
		{
			Lua_BlackJack_ProjectL_UI_WorldEventMissionUITask.<>f__mg$cache12 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_WorldEventMissionUITask.__callBase_CollectAllDynamicResForLoad);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_WorldEventMissionUITask.<>f__mg$cache12);
		if (Lua_BlackJack_ProjectL_UI_WorldEventMissionUITask.<>f__mg$cache13 == null)
		{
			Lua_BlackJack_ProjectL_UI_WorldEventMissionUITask.<>f__mg$cache13 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_WorldEventMissionUITask.__callBase_RegisterPlayerContextEvents);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_WorldEventMissionUITask.<>f__mg$cache13);
		if (Lua_BlackJack_ProjectL_UI_WorldEventMissionUITask.<>f__mg$cache14 == null)
		{
			Lua_BlackJack_ProjectL_UI_WorldEventMissionUITask.<>f__mg$cache14 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_WorldEventMissionUITask.__callBase_UnregisterPlayerContextEvents);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_WorldEventMissionUITask.<>f__mg$cache14);
		if (Lua_BlackJack_ProjectL_UI_WorldEventMissionUITask.<>f__mg$cache15 == null)
		{
			Lua_BlackJack_ProjectL_UI_WorldEventMissionUITask.<>f__mg$cache15 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_WorldEventMissionUITask.__callBase_PostUpdateView);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_WorldEventMissionUITask.<>f__mg$cache15);
		if (Lua_BlackJack_ProjectL_UI_WorldEventMissionUITask.<>f__mg$cache16 == null)
		{
			Lua_BlackJack_ProjectL_UI_WorldEventMissionUITask.<>f__mg$cache16 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_WorldEventMissionUITask.__callBase_CollectPreloadResourceList);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_WorldEventMissionUITask.<>f__mg$cache16);
		if (Lua_BlackJack_ProjectL_UI_WorldEventMissionUITask.<>f__mg$cache17 == null)
		{
			Lua_BlackJack_ProjectL_UI_WorldEventMissionUITask.<>f__mg$cache17 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_WorldEventMissionUITask.__callBase_ClearAssetList);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_WorldEventMissionUITask.<>f__mg$cache17);
		if (Lua_BlackJack_ProjectL_UI_WorldEventMissionUITask.<>f__mg$cache18 == null)
		{
			Lua_BlackJack_ProjectL_UI_WorldEventMissionUITask.<>f__mg$cache18 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_WorldEventMissionUITask.__callBase_CollectAsset);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_WorldEventMissionUITask.<>f__mg$cache18);
		if (Lua_BlackJack_ProjectL_UI_WorldEventMissionUITask.<>f__mg$cache19 == null)
		{
			Lua_BlackJack_ProjectL_UI_WorldEventMissionUITask.<>f__mg$cache19 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_WorldEventMissionUITask.__callBase_CollectSpriteAsset);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_WorldEventMissionUITask.<>f__mg$cache19);
		if (Lua_BlackJack_ProjectL_UI_WorldEventMissionUITask.<>f__mg$cache1A == null)
		{
			Lua_BlackJack_ProjectL_UI_WorldEventMissionUITask.<>f__mg$cache1A = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_WorldEventMissionUITask.__callBase_CollectFxAsset);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_WorldEventMissionUITask.<>f__mg$cache1A);
		if (Lua_BlackJack_ProjectL_UI_WorldEventMissionUITask.<>f__mg$cache1B == null)
		{
			Lua_BlackJack_ProjectL_UI_WorldEventMissionUITask.<>f__mg$cache1B = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_WorldEventMissionUITask.__callBase_StartLoadCustomAssets);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_WorldEventMissionUITask.<>f__mg$cache1B);
		if (Lua_BlackJack_ProjectL_UI_WorldEventMissionUITask.<>f__mg$cache1C == null)
		{
			Lua_BlackJack_ProjectL_UI_WorldEventMissionUITask.<>f__mg$cache1C = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_WorldEventMissionUITask.__callBase_IsLoadingCustomAssets);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_WorldEventMissionUITask.<>f__mg$cache1C);
		if (Lua_BlackJack_ProjectL_UI_WorldEventMissionUITask.<>f__mg$cache1D == null)
		{
			Lua_BlackJack_ProjectL_UI_WorldEventMissionUITask.<>f__mg$cache1D = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_WorldEventMissionUITask.__callBase_IsPipeLineRunning);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_WorldEventMissionUITask.<>f__mg$cache1D);
		if (Lua_BlackJack_ProjectL_UI_WorldEventMissionUITask.<>f__mg$cache1E == null)
		{
			Lua_BlackJack_ProjectL_UI_WorldEventMissionUITask.<>f__mg$cache1E = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_WorldEventMissionUITask.__callBase_IsOpeningUI);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_WorldEventMissionUITask.<>f__mg$cache1E);
		if (Lua_BlackJack_ProjectL_UI_WorldEventMissionUITask.<>f__mg$cache1F == null)
		{
			Lua_BlackJack_ProjectL_UI_WorldEventMissionUITask.<>f__mg$cache1F = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_WorldEventMissionUITask.__callBase_ReturnPrevUITask);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_WorldEventMissionUITask.<>f__mg$cache1F);
		if (Lua_BlackJack_ProjectL_UI_WorldEventMissionUITask.<>f__mg$cache20 == null)
		{
			Lua_BlackJack_ProjectL_UI_WorldEventMissionUITask.<>f__mg$cache20 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_WorldEventMissionUITask.__callBase_ClearUnusedDynamicResourceCache);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_WorldEventMissionUITask.<>f__mg$cache20);
		if (Lua_BlackJack_ProjectL_UI_WorldEventMissionUITask.<>f__mg$cache21 == null)
		{
			Lua_BlackJack_ProjectL_UI_WorldEventMissionUITask.<>f__mg$cache21 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_WorldEventMissionUITask.__callBase_OnMemoryWarning);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_WorldEventMissionUITask.<>f__mg$cache21);
		if (Lua_BlackJack_ProjectL_UI_WorldEventMissionUITask.<>f__mg$cache22 == null)
		{
			Lua_BlackJack_ProjectL_UI_WorldEventMissionUITask.<>f__mg$cache22 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_WorldEventMissionUITask.__callDele_EventOnEnterMission);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_WorldEventMissionUITask.<>f__mg$cache22);
		if (Lua_BlackJack_ProjectL_UI_WorldEventMissionUITask.<>f__mg$cache23 == null)
		{
			Lua_BlackJack_ProjectL_UI_WorldEventMissionUITask.<>f__mg$cache23 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_WorldEventMissionUITask.__clearDele_EventOnEnterMission);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_WorldEventMissionUITask.<>f__mg$cache23);
		if (Lua_BlackJack_ProjectL_UI_WorldEventMissionUITask.<>f__mg$cache24 == null)
		{
			Lua_BlackJack_ProjectL_UI_WorldEventMissionUITask.<>f__mg$cache24 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_WorldEventMissionUITask.__callDele_EventOnClose);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_WorldEventMissionUITask.<>f__mg$cache24);
		if (Lua_BlackJack_ProjectL_UI_WorldEventMissionUITask.<>f__mg$cache25 == null)
		{
			Lua_BlackJack_ProjectL_UI_WorldEventMissionUITask.<>f__mg$cache25 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_WorldEventMissionUITask.__clearDele_EventOnClose);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_WorldEventMissionUITask.<>f__mg$cache25);
		string name = "EventOnEnterMission";
		LuaCSFunction get = null;
		if (Lua_BlackJack_ProjectL_UI_WorldEventMissionUITask.<>f__mg$cache26 == null)
		{
			Lua_BlackJack_ProjectL_UI_WorldEventMissionUITask.<>f__mg$cache26 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_WorldEventMissionUITask.set_EventOnEnterMission);
		}
		LuaObject.addMember(l, name, get, Lua_BlackJack_ProjectL_UI_WorldEventMissionUITask.<>f__mg$cache26, true);
		string name2 = "EventOnClose";
		LuaCSFunction get2 = null;
		if (Lua_BlackJack_ProjectL_UI_WorldEventMissionUITask.<>f__mg$cache27 == null)
		{
			Lua_BlackJack_ProjectL_UI_WorldEventMissionUITask.<>f__mg$cache27 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_WorldEventMissionUITask.set_EventOnClose);
		}
		LuaObject.addMember(l, name2, get2, Lua_BlackJack_ProjectL_UI_WorldEventMissionUITask.<>f__mg$cache27, true);
		string name3 = "m_layerDescArray";
		if (Lua_BlackJack_ProjectL_UI_WorldEventMissionUITask.<>f__mg$cache28 == null)
		{
			Lua_BlackJack_ProjectL_UI_WorldEventMissionUITask.<>f__mg$cache28 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_WorldEventMissionUITask.get_m_layerDescArray);
		}
		LuaCSFunction get3 = Lua_BlackJack_ProjectL_UI_WorldEventMissionUITask.<>f__mg$cache28;
		if (Lua_BlackJack_ProjectL_UI_WorldEventMissionUITask.<>f__mg$cache29 == null)
		{
			Lua_BlackJack_ProjectL_UI_WorldEventMissionUITask.<>f__mg$cache29 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_WorldEventMissionUITask.set_m_layerDescArray);
		}
		LuaObject.addMember(l, name3, get3, Lua_BlackJack_ProjectL_UI_WorldEventMissionUITask.<>f__mg$cache29, true);
		string name4 = "m_uiCtrlDescArray";
		if (Lua_BlackJack_ProjectL_UI_WorldEventMissionUITask.<>f__mg$cache2A == null)
		{
			Lua_BlackJack_ProjectL_UI_WorldEventMissionUITask.<>f__mg$cache2A = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_WorldEventMissionUITask.get_m_uiCtrlDescArray);
		}
		LuaCSFunction get4 = Lua_BlackJack_ProjectL_UI_WorldEventMissionUITask.<>f__mg$cache2A;
		if (Lua_BlackJack_ProjectL_UI_WorldEventMissionUITask.<>f__mg$cache2B == null)
		{
			Lua_BlackJack_ProjectL_UI_WorldEventMissionUITask.<>f__mg$cache2B = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_WorldEventMissionUITask.set_m_uiCtrlDescArray);
		}
		LuaObject.addMember(l, name4, get4, Lua_BlackJack_ProjectL_UI_WorldEventMissionUITask.<>f__mg$cache2B, true);
		string name5 = "m_worldEventMissionUIController";
		if (Lua_BlackJack_ProjectL_UI_WorldEventMissionUITask.<>f__mg$cache2C == null)
		{
			Lua_BlackJack_ProjectL_UI_WorldEventMissionUITask.<>f__mg$cache2C = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_WorldEventMissionUITask.get_m_worldEventMissionUIController);
		}
		LuaCSFunction get5 = Lua_BlackJack_ProjectL_UI_WorldEventMissionUITask.<>f__mg$cache2C;
		if (Lua_BlackJack_ProjectL_UI_WorldEventMissionUITask.<>f__mg$cache2D == null)
		{
			Lua_BlackJack_ProjectL_UI_WorldEventMissionUITask.<>f__mg$cache2D = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_WorldEventMissionUITask.set_m_worldEventMissionUIController);
		}
		LuaObject.addMember(l, name5, get5, Lua_BlackJack_ProjectL_UI_WorldEventMissionUITask.<>f__mg$cache2D, true);
		string name6 = "m_eventInfo";
		if (Lua_BlackJack_ProjectL_UI_WorldEventMissionUITask.<>f__mg$cache2E == null)
		{
			Lua_BlackJack_ProjectL_UI_WorldEventMissionUITask.<>f__mg$cache2E = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_WorldEventMissionUITask.get_m_eventInfo);
		}
		LuaCSFunction get6 = Lua_BlackJack_ProjectL_UI_WorldEventMissionUITask.<>f__mg$cache2E;
		if (Lua_BlackJack_ProjectL_UI_WorldEventMissionUITask.<>f__mg$cache2F == null)
		{
			Lua_BlackJack_ProjectL_UI_WorldEventMissionUITask.<>f__mg$cache2F = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_WorldEventMissionUITask.set_m_eventInfo);
		}
		LuaObject.addMember(l, name6, get6, Lua_BlackJack_ProjectL_UI_WorldEventMissionUITask.<>f__mg$cache2F, true);
		string name7 = "LayerDescArray";
		if (Lua_BlackJack_ProjectL_UI_WorldEventMissionUITask.<>f__mg$cache30 == null)
		{
			Lua_BlackJack_ProjectL_UI_WorldEventMissionUITask.<>f__mg$cache30 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_WorldEventMissionUITask.get_LayerDescArray);
		}
		LuaObject.addMember(l, name7, Lua_BlackJack_ProjectL_UI_WorldEventMissionUITask.<>f__mg$cache30, null, true);
		string name8 = "UICtrlDescArray";
		if (Lua_BlackJack_ProjectL_UI_WorldEventMissionUITask.<>f__mg$cache31 == null)
		{
			Lua_BlackJack_ProjectL_UI_WorldEventMissionUITask.<>f__mg$cache31 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_WorldEventMissionUITask.get_UICtrlDescArray);
		}
		LuaObject.addMember(l, name8, Lua_BlackJack_ProjectL_UI_WorldEventMissionUITask.<>f__mg$cache31, null, true);
		if (Lua_BlackJack_ProjectL_UI_WorldEventMissionUITask.<>f__mg$cache32 == null)
		{
			Lua_BlackJack_ProjectL_UI_WorldEventMissionUITask.<>f__mg$cache32 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_WorldEventMissionUITask.constructor);
		}
		LuaObject.createTypeMetatable(l, Lua_BlackJack_ProjectL_UI_WorldEventMissionUITask.<>f__mg$cache32, typeof(WorldEventMissionUITask), typeof(UITask));
	}

	// Token: 0x04018226 RID: 98854
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache0;

	// Token: 0x04018227 RID: 98855
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1;

	// Token: 0x04018228 RID: 98856
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2;

	// Token: 0x04018229 RID: 98857
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3;

	// Token: 0x0401822A RID: 98858
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache4;

	// Token: 0x0401822B RID: 98859
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache5;

	// Token: 0x0401822C RID: 98860
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache6;

	// Token: 0x0401822D RID: 98861
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache7;

	// Token: 0x0401822E RID: 98862
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache8;

	// Token: 0x0401822F RID: 98863
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache9;

	// Token: 0x04018230 RID: 98864
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheA;

	// Token: 0x04018231 RID: 98865
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheB;

	// Token: 0x04018232 RID: 98866
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheC;

	// Token: 0x04018233 RID: 98867
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheD;

	// Token: 0x04018234 RID: 98868
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheE;

	// Token: 0x04018235 RID: 98869
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheF;

	// Token: 0x04018236 RID: 98870
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache10;

	// Token: 0x04018237 RID: 98871
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache11;

	// Token: 0x04018238 RID: 98872
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache12;

	// Token: 0x04018239 RID: 98873
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache13;

	// Token: 0x0401823A RID: 98874
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache14;

	// Token: 0x0401823B RID: 98875
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache15;

	// Token: 0x0401823C RID: 98876
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache16;

	// Token: 0x0401823D RID: 98877
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache17;

	// Token: 0x0401823E RID: 98878
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache18;

	// Token: 0x0401823F RID: 98879
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache19;

	// Token: 0x04018240 RID: 98880
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1A;

	// Token: 0x04018241 RID: 98881
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1B;

	// Token: 0x04018242 RID: 98882
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1C;

	// Token: 0x04018243 RID: 98883
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1D;

	// Token: 0x04018244 RID: 98884
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1E;

	// Token: 0x04018245 RID: 98885
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1F;

	// Token: 0x04018246 RID: 98886
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache20;

	// Token: 0x04018247 RID: 98887
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache21;

	// Token: 0x04018248 RID: 98888
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache22;

	// Token: 0x04018249 RID: 98889
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache23;

	// Token: 0x0401824A RID: 98890
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache24;

	// Token: 0x0401824B RID: 98891
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache25;

	// Token: 0x0401824C RID: 98892
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache26;

	// Token: 0x0401824D RID: 98893
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache27;

	// Token: 0x0401824E RID: 98894
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache28;

	// Token: 0x0401824F RID: 98895
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache29;

	// Token: 0x04018250 RID: 98896
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2A;

	// Token: 0x04018251 RID: 98897
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2B;

	// Token: 0x04018252 RID: 98898
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2C;

	// Token: 0x04018253 RID: 98899
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2D;

	// Token: 0x04018254 RID: 98900
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2E;

	// Token: 0x04018255 RID: 98901
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2F;

	// Token: 0x04018256 RID: 98902
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache30;

	// Token: 0x04018257 RID: 98903
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache31;

	// Token: 0x04018258 RID: 98904
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache32;
}
