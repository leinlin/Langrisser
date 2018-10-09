using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using BlackJack.BJFramework.Runtime.UI;
using BlackJack.ConfigData;
using BlackJack.ProjectL.UI;
using SLua;
using UnityEngine.Scripting;

// Token: 0x02001362 RID: 4962
[Preserve]
public class Lua_BlackJack_ProjectL_UI_AnikiUITask : LuaObject
{
	// Token: 0x0601ABDF RID: 109535 RVA: 0x007F9994 File Offset: 0x007F7B94
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int constructor(IntPtr l)
	{
		int result;
		try
		{
			string name;
			LuaObject.checkType(l, 2, out name);
			AnikiUITask o = new AnikiUITask(name);
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

	// Token: 0x0601ABE0 RID: 109536 RVA: 0x007F99E8 File Offset: 0x007F7BE8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int OnStart(IntPtr l)
	{
		int result;
		try
		{
			AnikiUITask anikiUITask = (AnikiUITask)LuaObject.checkSelf(l);
			UIIntent intent;
			LuaObject.checkType<UIIntent>(l, 2, out intent);
			bool b = anikiUITask.m_luaExportHelper.OnStart(intent);
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

	// Token: 0x0601ABE1 RID: 109537 RVA: 0x007F9A50 File Offset: 0x007F7C50
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int OnResume(IntPtr l)
	{
		int result;
		try
		{
			AnikiUITask anikiUITask = (AnikiUITask)LuaObject.checkSelf(l);
			UIIntent intent;
			LuaObject.checkType<UIIntent>(l, 2, out intent);
			bool b = anikiUITask.m_luaExportHelper.OnResume(intent);
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

	// Token: 0x0601ABE2 RID: 109538 RVA: 0x007F9AB8 File Offset: 0x007F7CB8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int InitDataFromUIIntent(IntPtr l)
	{
		int result;
		try
		{
			AnikiUITask anikiUITask = (AnikiUITask)LuaObject.checkSelf(l);
			UIIntent intent;
			LuaObject.checkType<UIIntent>(l, 2, out intent);
			anikiUITask.m_luaExportHelper.InitDataFromUIIntent(intent);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601ABE3 RID: 109539 RVA: 0x007F9B14 File Offset: 0x007F7D14
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int IsNeedLoadDynamicRes(IntPtr l)
	{
		int result;
		try
		{
			AnikiUITask anikiUITask = (AnikiUITask)LuaObject.checkSelf(l);
			bool b = anikiUITask.m_luaExportHelper.IsNeedLoadDynamicRes();
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

	// Token: 0x0601ABE4 RID: 109540 RVA: 0x007F9B70 File Offset: 0x007F7D70
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int InitAllUIControllers(IntPtr l)
	{
		int result;
		try
		{
			AnikiUITask anikiUITask = (AnikiUITask)LuaObject.checkSelf(l);
			anikiUITask.m_luaExportHelper.InitAllUIControllers();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601ABE5 RID: 109541 RVA: 0x007F9BC4 File Offset: 0x007F7DC4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int ClearAllContextAndRes(IntPtr l)
	{
		int result;
		try
		{
			AnikiUITask anikiUITask = (AnikiUITask)LuaObject.checkSelf(l);
			anikiUITask.m_luaExportHelper.ClearAllContextAndRes();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601ABE6 RID: 109542 RVA: 0x007F9C18 File Offset: 0x007F7E18
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int InitAnikiUIController(IntPtr l)
	{
		int result;
		try
		{
			AnikiUITask anikiUITask = (AnikiUITask)LuaObject.checkSelf(l);
			anikiUITask.m_luaExportHelper.InitAnikiUIController();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601ABE7 RID: 109543 RVA: 0x007F9C6C File Offset: 0x007F7E6C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int UninitAnikiUIController(IntPtr l)
	{
		int result;
		try
		{
			AnikiUITask anikiUITask = (AnikiUITask)LuaObject.checkSelf(l);
			anikiUITask.m_luaExportHelper.UninitAnikiUIController();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601ABE8 RID: 109544 RVA: 0x007F9CC0 File Offset: 0x007F7EC0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int UpdateView(IntPtr l)
	{
		int result;
		try
		{
			AnikiUITask anikiUITask = (AnikiUITask)LuaObject.checkSelf(l);
			anikiUITask.m_luaExportHelper.UpdateView();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601ABE9 RID: 109545 RVA: 0x007F9D14 File Offset: 0x007F7F14
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int UpdateAnikiLevels(IntPtr l)
	{
		int result;
		try
		{
			AnikiUITask anikiUITask = (AnikiUITask)LuaObject.checkSelf(l);
			ConfigDataAnikiGymInfo anikiGymInfo;
			LuaObject.checkType<ConfigDataAnikiGymInfo>(l, 2, out anikiGymInfo);
			anikiUITask.m_luaExportHelper.UpdateAnikiLevels(anikiGymInfo);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601ABEA RID: 109546 RVA: 0x007F9D70 File Offset: 0x007F7F70
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int AnikiUIController_OnReturn(IntPtr l)
	{
		int result;
		try
		{
			AnikiUITask anikiUITask = (AnikiUITask)LuaObject.checkSelf(l);
			anikiUITask.m_luaExportHelper.AnikiUIController_OnReturn();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601ABEB RID: 109547 RVA: 0x007F9DC4 File Offset: 0x007F7FC4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int AnikiUIController_OnShowHelp(IntPtr l)
	{
		int result;
		try
		{
			AnikiUITask anikiUITask = (AnikiUITask)LuaObject.checkSelf(l);
			anikiUITask.m_luaExportHelper.AnikiUIController_OnShowHelp();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601ABEC RID: 109548 RVA: 0x007F9E18 File Offset: 0x007F8018
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int AnikiUIController_OnAddTicket(IntPtr l)
	{
		int result;
		try
		{
			AnikiUITask anikiUITask = (AnikiUITask)LuaObject.checkSelf(l);
			anikiUITask.m_luaExportHelper.AnikiUIController_OnAddTicket();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601ABED RID: 109549 RVA: 0x007F9E6C File Offset: 0x007F806C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int AnikiUIController_OnShowTeam(IntPtr l)
	{
		int result;
		try
		{
			AnikiUITask anikiUITask = (AnikiUITask)LuaObject.checkSelf(l);
			anikiUITask.m_luaExportHelper.AnikiUIController_OnShowTeam();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601ABEE RID: 109550 RVA: 0x007F9EC0 File Offset: 0x007F80C0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int TeamUITask_OnLoadAllResCompleted(IntPtr l)
	{
		int result;
		try
		{
			AnikiUITask anikiUITask = (AnikiUITask)LuaObject.checkSelf(l);
			anikiUITask.m_luaExportHelper.TeamUITask_OnLoadAllResCompleted();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601ABEF RID: 109551 RVA: 0x007F9F14 File Offset: 0x007F8114
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int AnikiUIController_OnSelectAnikiGym(IntPtr l)
	{
		int result;
		try
		{
			AnikiUITask anikiUITask = (AnikiUITask)LuaObject.checkSelf(l);
			ConfigDataAnikiGymInfo anikiGymInfo;
			LuaObject.checkType<ConfigDataAnikiGymInfo>(l, 2, out anikiGymInfo);
			anikiUITask.m_luaExportHelper.AnikiUIController_OnSelectAnikiGym(anikiGymInfo);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601ABF0 RID: 109552 RVA: 0x007F9F70 File Offset: 0x007F8170
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int AnikiUIController_OnStartAnikiLevel(IntPtr l)
	{
		int result;
		try
		{
			AnikiUITask anikiUITask = (AnikiUITask)LuaObject.checkSelf(l);
			ConfigDataAnikiLevelInfo levelInfo;
			LuaObject.checkType<ConfigDataAnikiLevelInfo>(l, 2, out levelInfo);
			anikiUITask.m_luaExportHelper.AnikiUIController_OnStartAnikiLevel(levelInfo);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601ABF1 RID: 109553 RVA: 0x007F9FCC File Offset: 0x007F81CC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_OnStart(IntPtr l)
	{
		int result;
		try
		{
			AnikiUITask anikiUITask = (AnikiUITask)LuaObject.checkSelf(l);
			UIIntent intent;
			LuaObject.checkType<UIIntent>(l, 2, out intent);
			bool b = anikiUITask.m_luaExportHelper.__callBase_OnStart(intent);
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

	// Token: 0x0601ABF2 RID: 109554 RVA: 0x007FA034 File Offset: 0x007F8234
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_OnStop(IntPtr l)
	{
		int result;
		try
		{
			AnikiUITask anikiUITask = (AnikiUITask)LuaObject.checkSelf(l);
			anikiUITask.m_luaExportHelper.__callBase_OnStop();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601ABF3 RID: 109555 RVA: 0x007FA088 File Offset: 0x007F8288
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_OnPause(IntPtr l)
	{
		int result;
		try
		{
			AnikiUITask anikiUITask = (AnikiUITask)LuaObject.checkSelf(l);
			anikiUITask.m_luaExportHelper.__callBase_OnPause();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601ABF4 RID: 109556 RVA: 0x007FA0DC File Offset: 0x007F82DC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_OnResume(IntPtr l)
	{
		int result;
		try
		{
			AnikiUITask anikiUITask = (AnikiUITask)LuaObject.checkSelf(l);
			UIIntent intent;
			LuaObject.checkType<UIIntent>(l, 2, out intent);
			bool b = anikiUITask.m_luaExportHelper.__callBase_OnResume(intent);
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

	// Token: 0x0601ABF5 RID: 109557 RVA: 0x007FA144 File Offset: 0x007F8344
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_OnNewIntent(IntPtr l)
	{
		int result;
		try
		{
			AnikiUITask anikiUITask = (AnikiUITask)LuaObject.checkSelf(l);
			UIIntent intent;
			LuaObject.checkType<UIIntent>(l, 2, out intent);
			bool b = anikiUITask.m_luaExportHelper.__callBase_OnNewIntent(intent);
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

	// Token: 0x0601ABF6 RID: 109558 RVA: 0x007FA1AC File Offset: 0x007F83AC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_EnableUIInput(IntPtr l)
	{
		int result;
		try
		{
			AnikiUITask anikiUITask = (AnikiUITask)LuaObject.checkSelf(l);
			bool isEnable;
			LuaObject.checkType(l, 2, out isEnable);
			bool? isGlobalEnable;
			LuaObject.checkNullable<bool>(l, 3, out isGlobalEnable);
			anikiUITask.m_luaExportHelper.__callBase_EnableUIInput(isEnable, isGlobalEnable);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601ABF7 RID: 109559 RVA: 0x007FA218 File Offset: 0x007F8418
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_IsNeedLoadDynamicRes(IntPtr l)
	{
		int result;
		try
		{
			AnikiUITask anikiUITask = (AnikiUITask)LuaObject.checkSelf(l);
			bool b = anikiUITask.m_luaExportHelper.__callBase_IsNeedLoadDynamicRes();
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

	// Token: 0x0601ABF8 RID: 109560 RVA: 0x007FA274 File Offset: 0x007F8474
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_CollectAllDynamicResForLoad(IntPtr l)
	{
		int result;
		try
		{
			AnikiUITask anikiUITask = (AnikiUITask)LuaObject.checkSelf(l);
			List<string> o = anikiUITask.m_luaExportHelper.__callBase_CollectAllDynamicResForLoad();
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

	// Token: 0x0601ABF9 RID: 109561 RVA: 0x007FA2D0 File Offset: 0x007F84D0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_RegisterPlayerContextEvents(IntPtr l)
	{
		int result;
		try
		{
			AnikiUITask anikiUITask = (AnikiUITask)LuaObject.checkSelf(l);
			anikiUITask.m_luaExportHelper.__callBase_RegisterPlayerContextEvents();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601ABFA RID: 109562 RVA: 0x007FA324 File Offset: 0x007F8524
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_UnregisterPlayerContextEvents(IntPtr l)
	{
		int result;
		try
		{
			AnikiUITask anikiUITask = (AnikiUITask)LuaObject.checkSelf(l);
			anikiUITask.m_luaExportHelper.__callBase_UnregisterPlayerContextEvents();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601ABFB RID: 109563 RVA: 0x007FA378 File Offset: 0x007F8578
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_PostUpdateView(IntPtr l)
	{
		int result;
		try
		{
			AnikiUITask anikiUITask = (AnikiUITask)LuaObject.checkSelf(l);
			anikiUITask.m_luaExportHelper.__callBase_PostUpdateView();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601ABFC RID: 109564 RVA: 0x007FA3CC File Offset: 0x007F85CC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_CollectPreloadResourceList(IntPtr l)
	{
		int result;
		try
		{
			AnikiUITask anikiUITask = (AnikiUITask)LuaObject.checkSelf(l);
			anikiUITask.m_luaExportHelper.__callBase_CollectPreloadResourceList();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601ABFD RID: 109565 RVA: 0x007FA420 File Offset: 0x007F8620
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_ClearAssetList(IntPtr l)
	{
		int result;
		try
		{
			AnikiUITask anikiUITask = (AnikiUITask)LuaObject.checkSelf(l);
			anikiUITask.m_luaExportHelper.__callBase_ClearAssetList();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601ABFE RID: 109566 RVA: 0x007FA474 File Offset: 0x007F8674
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_CollectAsset(IntPtr l)
	{
		int result;
		try
		{
			AnikiUITask anikiUITask = (AnikiUITask)LuaObject.checkSelf(l);
			string assetName;
			LuaObject.checkType(l, 2, out assetName);
			anikiUITask.m_luaExportHelper.__callBase_CollectAsset(assetName);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601ABFF RID: 109567 RVA: 0x007FA4D0 File Offset: 0x007F86D0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_CollectSpriteAsset(IntPtr l)
	{
		int result;
		try
		{
			AnikiUITask anikiUITask = (AnikiUITask)LuaObject.checkSelf(l);
			string assetName;
			LuaObject.checkType(l, 2, out assetName);
			anikiUITask.m_luaExportHelper.__callBase_CollectSpriteAsset(assetName);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601AC00 RID: 109568 RVA: 0x007FA52C File Offset: 0x007F872C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_CollectFxAsset(IntPtr l)
	{
		int result;
		try
		{
			AnikiUITask anikiUITask = (AnikiUITask)LuaObject.checkSelf(l);
			string assetName;
			LuaObject.checkType(l, 2, out assetName);
			anikiUITask.m_luaExportHelper.__callBase_CollectFxAsset(assetName);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601AC01 RID: 109569 RVA: 0x007FA588 File Offset: 0x007F8788
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_StartLoadCustomAssets(IntPtr l)
	{
		int result;
		try
		{
			AnikiUITask anikiUITask = (AnikiUITask)LuaObject.checkSelf(l);
			Action onLoadCompleted;
			LuaObject.checkDelegate<Action>(l, 2, out onLoadCompleted);
			anikiUITask.m_luaExportHelper.__callBase_StartLoadCustomAssets(onLoadCompleted);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601AC02 RID: 109570 RVA: 0x007FA5E4 File Offset: 0x007F87E4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_IsLoadingCustomAssets(IntPtr l)
	{
		int result;
		try
		{
			AnikiUITask anikiUITask = (AnikiUITask)LuaObject.checkSelf(l);
			bool b = anikiUITask.m_luaExportHelper.__callBase_IsLoadingCustomAssets();
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

	// Token: 0x0601AC03 RID: 109571 RVA: 0x007FA640 File Offset: 0x007F8840
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_IsPipeLineRunning(IntPtr l)
	{
		int result;
		try
		{
			AnikiUITask anikiUITask = (AnikiUITask)LuaObject.checkSelf(l);
			bool b = anikiUITask.m_luaExportHelper.__callBase_IsPipeLineRunning();
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

	// Token: 0x0601AC04 RID: 109572 RVA: 0x007FA69C File Offset: 0x007F889C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_IsOpeningUI(IntPtr l)
	{
		int result;
		try
		{
			AnikiUITask anikiUITask = (AnikiUITask)LuaObject.checkSelf(l);
			bool b = anikiUITask.m_luaExportHelper.__callBase_IsOpeningUI();
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

	// Token: 0x0601AC05 RID: 109573 RVA: 0x007FA6F8 File Offset: 0x007F88F8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_ReturnPrevUITask(IntPtr l)
	{
		int result;
		try
		{
			AnikiUITask anikiUITask = (AnikiUITask)LuaObject.checkSelf(l);
			UITaskBase o = anikiUITask.m_luaExportHelper.__callBase_ReturnPrevUITask();
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

	// Token: 0x0601AC06 RID: 109574 RVA: 0x007FA754 File Offset: 0x007F8954
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_ClearUnusedDynamicResourceCache(IntPtr l)
	{
		int result;
		try
		{
			AnikiUITask anikiUITask = (AnikiUITask)LuaObject.checkSelf(l);
			anikiUITask.m_luaExportHelper.__callBase_ClearUnusedDynamicResourceCache();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601AC07 RID: 109575 RVA: 0x007FA7A8 File Offset: 0x007F89A8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_OnMemoryWarning(IntPtr l)
	{
		int result;
		try
		{
			AnikiUITask anikiUITask = (AnikiUITask)LuaObject.checkSelf(l);
			anikiUITask.m_luaExportHelper.__callBase_OnMemoryWarning();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601AC08 RID: 109576 RVA: 0x007FA7FC File Offset: 0x007F89FC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_layerDescArray(IntPtr l)
	{
		int result;
		try
		{
			AnikiUITask anikiUITask = (AnikiUITask)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, anikiUITask.m_luaExportHelper.m_layerDescArray);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601AC09 RID: 109577 RVA: 0x007FA854 File Offset: 0x007F8A54
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_layerDescArray(IntPtr l)
	{
		int result;
		try
		{
			AnikiUITask anikiUITask = (AnikiUITask)LuaObject.checkSelf(l);
			UITaskBase.LayerDesc[] layerDescArray;
			LuaObject.checkArray<UITaskBase.LayerDesc>(l, 2, out layerDescArray);
			anikiUITask.m_luaExportHelper.m_layerDescArray = layerDescArray;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601AC0A RID: 109578 RVA: 0x007FA8B0 File Offset: 0x007F8AB0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_uiCtrlDescArray(IntPtr l)
	{
		int result;
		try
		{
			AnikiUITask anikiUITask = (AnikiUITask)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, anikiUITask.m_luaExportHelper.m_uiCtrlDescArray);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601AC0B RID: 109579 RVA: 0x007FA908 File Offset: 0x007F8B08
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_uiCtrlDescArray(IntPtr l)
	{
		int result;
		try
		{
			AnikiUITask anikiUITask = (AnikiUITask)LuaObject.checkSelf(l);
			UITaskBase.UIControllerDesc[] uiCtrlDescArray;
			LuaObject.checkArray<UITaskBase.UIControllerDesc>(l, 2, out uiCtrlDescArray);
			anikiUITask.m_luaExportHelper.m_uiCtrlDescArray = uiCtrlDescArray;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601AC0C RID: 109580 RVA: 0x007FA964 File Offset: 0x007F8B64
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_anikiUIController(IntPtr l)
	{
		int result;
		try
		{
			AnikiUITask anikiUITask = (AnikiUITask)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, anikiUITask.m_luaExportHelper.m_anikiUIController);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601AC0D RID: 109581 RVA: 0x007FA9BC File Offset: 0x007F8BBC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_anikiUIController(IntPtr l)
	{
		int result;
		try
		{
			AnikiUITask anikiUITask = (AnikiUITask)LuaObject.checkSelf(l);
			AnikiUIController anikiUIController;
			LuaObject.checkType<AnikiUIController>(l, 2, out anikiUIController);
			anikiUITask.m_luaExportHelper.m_anikiUIController = anikiUIController;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601AC0E RID: 109582 RVA: 0x007FAA18 File Offset: 0x007F8C18
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_playerResourceUIController(IntPtr l)
	{
		int result;
		try
		{
			AnikiUITask anikiUITask = (AnikiUITask)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, anikiUITask.m_luaExportHelper.m_playerResourceUIController);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601AC0F RID: 109583 RVA: 0x007FAA70 File Offset: 0x007F8C70
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_playerResourceUIController(IntPtr l)
	{
		int result;
		try
		{
			AnikiUITask anikiUITask = (AnikiUITask)LuaObject.checkSelf(l);
			PlayerResourceUIController playerResourceUIController;
			LuaObject.checkType<PlayerResourceUIController>(l, 2, out playerResourceUIController);
			anikiUITask.m_luaExportHelper.m_playerResourceUIController = playerResourceUIController;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601AC10 RID: 109584 RVA: 0x007FAACC File Offset: 0x007F8CCC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_anikiGymInfo(IntPtr l)
	{
		int result;
		try
		{
			AnikiUITask anikiUITask = (AnikiUITask)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, anikiUITask.m_luaExportHelper.m_anikiGymInfo);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601AC11 RID: 109585 RVA: 0x007FAB24 File Offset: 0x007F8D24
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_anikiGymInfo(IntPtr l)
	{
		int result;
		try
		{
			AnikiUITask anikiUITask = (AnikiUITask)LuaObject.checkSelf(l);
			ConfigDataAnikiGymInfo anikiGymInfo;
			LuaObject.checkType<ConfigDataAnikiGymInfo>(l, 2, out anikiGymInfo);
			anikiUITask.m_luaExportHelper.m_anikiGymInfo = anikiGymInfo;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601AC12 RID: 109586 RVA: 0x007FAB80 File Offset: 0x007F8D80
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_LayerDescArray(IntPtr l)
	{
		int result;
		try
		{
			AnikiUITask anikiUITask = (AnikiUITask)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, anikiUITask.m_luaExportHelper.LayerDescArray);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601AC13 RID: 109587 RVA: 0x007FABD8 File Offset: 0x007F8DD8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_UICtrlDescArray(IntPtr l)
	{
		int result;
		try
		{
			AnikiUITask anikiUITask = (AnikiUITask)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, anikiUITask.m_luaExportHelper.UICtrlDescArray);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601AC14 RID: 109588 RVA: 0x007FAC30 File Offset: 0x007F8E30
	[Preserve]
	public static void reg(IntPtr l)
	{
		LuaObject.getTypeTable(l, "BlackJack.ProjectL.UI.AnikiUITask");
		if (Lua_BlackJack_ProjectL_UI_AnikiUITask.<>f__mg$cache0 == null)
		{
			Lua_BlackJack_ProjectL_UI_AnikiUITask.<>f__mg$cache0 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_AnikiUITask.OnStart);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_AnikiUITask.<>f__mg$cache0);
		if (Lua_BlackJack_ProjectL_UI_AnikiUITask.<>f__mg$cache1 == null)
		{
			Lua_BlackJack_ProjectL_UI_AnikiUITask.<>f__mg$cache1 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_AnikiUITask.OnResume);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_AnikiUITask.<>f__mg$cache1);
		if (Lua_BlackJack_ProjectL_UI_AnikiUITask.<>f__mg$cache2 == null)
		{
			Lua_BlackJack_ProjectL_UI_AnikiUITask.<>f__mg$cache2 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_AnikiUITask.InitDataFromUIIntent);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_AnikiUITask.<>f__mg$cache2);
		if (Lua_BlackJack_ProjectL_UI_AnikiUITask.<>f__mg$cache3 == null)
		{
			Lua_BlackJack_ProjectL_UI_AnikiUITask.<>f__mg$cache3 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_AnikiUITask.IsNeedLoadDynamicRes);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_AnikiUITask.<>f__mg$cache3);
		if (Lua_BlackJack_ProjectL_UI_AnikiUITask.<>f__mg$cache4 == null)
		{
			Lua_BlackJack_ProjectL_UI_AnikiUITask.<>f__mg$cache4 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_AnikiUITask.InitAllUIControllers);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_AnikiUITask.<>f__mg$cache4);
		if (Lua_BlackJack_ProjectL_UI_AnikiUITask.<>f__mg$cache5 == null)
		{
			Lua_BlackJack_ProjectL_UI_AnikiUITask.<>f__mg$cache5 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_AnikiUITask.ClearAllContextAndRes);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_AnikiUITask.<>f__mg$cache5);
		if (Lua_BlackJack_ProjectL_UI_AnikiUITask.<>f__mg$cache6 == null)
		{
			Lua_BlackJack_ProjectL_UI_AnikiUITask.<>f__mg$cache6 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_AnikiUITask.InitAnikiUIController);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_AnikiUITask.<>f__mg$cache6);
		if (Lua_BlackJack_ProjectL_UI_AnikiUITask.<>f__mg$cache7 == null)
		{
			Lua_BlackJack_ProjectL_UI_AnikiUITask.<>f__mg$cache7 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_AnikiUITask.UninitAnikiUIController);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_AnikiUITask.<>f__mg$cache7);
		if (Lua_BlackJack_ProjectL_UI_AnikiUITask.<>f__mg$cache8 == null)
		{
			Lua_BlackJack_ProjectL_UI_AnikiUITask.<>f__mg$cache8 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_AnikiUITask.UpdateView);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_AnikiUITask.<>f__mg$cache8);
		if (Lua_BlackJack_ProjectL_UI_AnikiUITask.<>f__mg$cache9 == null)
		{
			Lua_BlackJack_ProjectL_UI_AnikiUITask.<>f__mg$cache9 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_AnikiUITask.UpdateAnikiLevels);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_AnikiUITask.<>f__mg$cache9);
		if (Lua_BlackJack_ProjectL_UI_AnikiUITask.<>f__mg$cacheA == null)
		{
			Lua_BlackJack_ProjectL_UI_AnikiUITask.<>f__mg$cacheA = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_AnikiUITask.AnikiUIController_OnReturn);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_AnikiUITask.<>f__mg$cacheA);
		if (Lua_BlackJack_ProjectL_UI_AnikiUITask.<>f__mg$cacheB == null)
		{
			Lua_BlackJack_ProjectL_UI_AnikiUITask.<>f__mg$cacheB = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_AnikiUITask.AnikiUIController_OnShowHelp);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_AnikiUITask.<>f__mg$cacheB);
		if (Lua_BlackJack_ProjectL_UI_AnikiUITask.<>f__mg$cacheC == null)
		{
			Lua_BlackJack_ProjectL_UI_AnikiUITask.<>f__mg$cacheC = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_AnikiUITask.AnikiUIController_OnAddTicket);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_AnikiUITask.<>f__mg$cacheC);
		if (Lua_BlackJack_ProjectL_UI_AnikiUITask.<>f__mg$cacheD == null)
		{
			Lua_BlackJack_ProjectL_UI_AnikiUITask.<>f__mg$cacheD = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_AnikiUITask.AnikiUIController_OnShowTeam);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_AnikiUITask.<>f__mg$cacheD);
		if (Lua_BlackJack_ProjectL_UI_AnikiUITask.<>f__mg$cacheE == null)
		{
			Lua_BlackJack_ProjectL_UI_AnikiUITask.<>f__mg$cacheE = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_AnikiUITask.TeamUITask_OnLoadAllResCompleted);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_AnikiUITask.<>f__mg$cacheE);
		if (Lua_BlackJack_ProjectL_UI_AnikiUITask.<>f__mg$cacheF == null)
		{
			Lua_BlackJack_ProjectL_UI_AnikiUITask.<>f__mg$cacheF = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_AnikiUITask.AnikiUIController_OnSelectAnikiGym);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_AnikiUITask.<>f__mg$cacheF);
		if (Lua_BlackJack_ProjectL_UI_AnikiUITask.<>f__mg$cache10 == null)
		{
			Lua_BlackJack_ProjectL_UI_AnikiUITask.<>f__mg$cache10 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_AnikiUITask.AnikiUIController_OnStartAnikiLevel);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_AnikiUITask.<>f__mg$cache10);
		if (Lua_BlackJack_ProjectL_UI_AnikiUITask.<>f__mg$cache11 == null)
		{
			Lua_BlackJack_ProjectL_UI_AnikiUITask.<>f__mg$cache11 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_AnikiUITask.__callBase_OnStart);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_AnikiUITask.<>f__mg$cache11);
		if (Lua_BlackJack_ProjectL_UI_AnikiUITask.<>f__mg$cache12 == null)
		{
			Lua_BlackJack_ProjectL_UI_AnikiUITask.<>f__mg$cache12 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_AnikiUITask.__callBase_OnStop);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_AnikiUITask.<>f__mg$cache12);
		if (Lua_BlackJack_ProjectL_UI_AnikiUITask.<>f__mg$cache13 == null)
		{
			Lua_BlackJack_ProjectL_UI_AnikiUITask.<>f__mg$cache13 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_AnikiUITask.__callBase_OnPause);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_AnikiUITask.<>f__mg$cache13);
		if (Lua_BlackJack_ProjectL_UI_AnikiUITask.<>f__mg$cache14 == null)
		{
			Lua_BlackJack_ProjectL_UI_AnikiUITask.<>f__mg$cache14 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_AnikiUITask.__callBase_OnResume);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_AnikiUITask.<>f__mg$cache14);
		if (Lua_BlackJack_ProjectL_UI_AnikiUITask.<>f__mg$cache15 == null)
		{
			Lua_BlackJack_ProjectL_UI_AnikiUITask.<>f__mg$cache15 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_AnikiUITask.__callBase_OnNewIntent);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_AnikiUITask.<>f__mg$cache15);
		if (Lua_BlackJack_ProjectL_UI_AnikiUITask.<>f__mg$cache16 == null)
		{
			Lua_BlackJack_ProjectL_UI_AnikiUITask.<>f__mg$cache16 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_AnikiUITask.__callBase_EnableUIInput);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_AnikiUITask.<>f__mg$cache16);
		if (Lua_BlackJack_ProjectL_UI_AnikiUITask.<>f__mg$cache17 == null)
		{
			Lua_BlackJack_ProjectL_UI_AnikiUITask.<>f__mg$cache17 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_AnikiUITask.__callBase_IsNeedLoadDynamicRes);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_AnikiUITask.<>f__mg$cache17);
		if (Lua_BlackJack_ProjectL_UI_AnikiUITask.<>f__mg$cache18 == null)
		{
			Lua_BlackJack_ProjectL_UI_AnikiUITask.<>f__mg$cache18 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_AnikiUITask.__callBase_CollectAllDynamicResForLoad);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_AnikiUITask.<>f__mg$cache18);
		if (Lua_BlackJack_ProjectL_UI_AnikiUITask.<>f__mg$cache19 == null)
		{
			Lua_BlackJack_ProjectL_UI_AnikiUITask.<>f__mg$cache19 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_AnikiUITask.__callBase_RegisterPlayerContextEvents);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_AnikiUITask.<>f__mg$cache19);
		if (Lua_BlackJack_ProjectL_UI_AnikiUITask.<>f__mg$cache1A == null)
		{
			Lua_BlackJack_ProjectL_UI_AnikiUITask.<>f__mg$cache1A = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_AnikiUITask.__callBase_UnregisterPlayerContextEvents);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_AnikiUITask.<>f__mg$cache1A);
		if (Lua_BlackJack_ProjectL_UI_AnikiUITask.<>f__mg$cache1B == null)
		{
			Lua_BlackJack_ProjectL_UI_AnikiUITask.<>f__mg$cache1B = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_AnikiUITask.__callBase_PostUpdateView);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_AnikiUITask.<>f__mg$cache1B);
		if (Lua_BlackJack_ProjectL_UI_AnikiUITask.<>f__mg$cache1C == null)
		{
			Lua_BlackJack_ProjectL_UI_AnikiUITask.<>f__mg$cache1C = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_AnikiUITask.__callBase_CollectPreloadResourceList);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_AnikiUITask.<>f__mg$cache1C);
		if (Lua_BlackJack_ProjectL_UI_AnikiUITask.<>f__mg$cache1D == null)
		{
			Lua_BlackJack_ProjectL_UI_AnikiUITask.<>f__mg$cache1D = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_AnikiUITask.__callBase_ClearAssetList);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_AnikiUITask.<>f__mg$cache1D);
		if (Lua_BlackJack_ProjectL_UI_AnikiUITask.<>f__mg$cache1E == null)
		{
			Lua_BlackJack_ProjectL_UI_AnikiUITask.<>f__mg$cache1E = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_AnikiUITask.__callBase_CollectAsset);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_AnikiUITask.<>f__mg$cache1E);
		if (Lua_BlackJack_ProjectL_UI_AnikiUITask.<>f__mg$cache1F == null)
		{
			Lua_BlackJack_ProjectL_UI_AnikiUITask.<>f__mg$cache1F = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_AnikiUITask.__callBase_CollectSpriteAsset);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_AnikiUITask.<>f__mg$cache1F);
		if (Lua_BlackJack_ProjectL_UI_AnikiUITask.<>f__mg$cache20 == null)
		{
			Lua_BlackJack_ProjectL_UI_AnikiUITask.<>f__mg$cache20 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_AnikiUITask.__callBase_CollectFxAsset);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_AnikiUITask.<>f__mg$cache20);
		if (Lua_BlackJack_ProjectL_UI_AnikiUITask.<>f__mg$cache21 == null)
		{
			Lua_BlackJack_ProjectL_UI_AnikiUITask.<>f__mg$cache21 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_AnikiUITask.__callBase_StartLoadCustomAssets);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_AnikiUITask.<>f__mg$cache21);
		if (Lua_BlackJack_ProjectL_UI_AnikiUITask.<>f__mg$cache22 == null)
		{
			Lua_BlackJack_ProjectL_UI_AnikiUITask.<>f__mg$cache22 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_AnikiUITask.__callBase_IsLoadingCustomAssets);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_AnikiUITask.<>f__mg$cache22);
		if (Lua_BlackJack_ProjectL_UI_AnikiUITask.<>f__mg$cache23 == null)
		{
			Lua_BlackJack_ProjectL_UI_AnikiUITask.<>f__mg$cache23 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_AnikiUITask.__callBase_IsPipeLineRunning);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_AnikiUITask.<>f__mg$cache23);
		if (Lua_BlackJack_ProjectL_UI_AnikiUITask.<>f__mg$cache24 == null)
		{
			Lua_BlackJack_ProjectL_UI_AnikiUITask.<>f__mg$cache24 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_AnikiUITask.__callBase_IsOpeningUI);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_AnikiUITask.<>f__mg$cache24);
		if (Lua_BlackJack_ProjectL_UI_AnikiUITask.<>f__mg$cache25 == null)
		{
			Lua_BlackJack_ProjectL_UI_AnikiUITask.<>f__mg$cache25 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_AnikiUITask.__callBase_ReturnPrevUITask);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_AnikiUITask.<>f__mg$cache25);
		if (Lua_BlackJack_ProjectL_UI_AnikiUITask.<>f__mg$cache26 == null)
		{
			Lua_BlackJack_ProjectL_UI_AnikiUITask.<>f__mg$cache26 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_AnikiUITask.__callBase_ClearUnusedDynamicResourceCache);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_AnikiUITask.<>f__mg$cache26);
		if (Lua_BlackJack_ProjectL_UI_AnikiUITask.<>f__mg$cache27 == null)
		{
			Lua_BlackJack_ProjectL_UI_AnikiUITask.<>f__mg$cache27 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_AnikiUITask.__callBase_OnMemoryWarning);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_AnikiUITask.<>f__mg$cache27);
		string name = "m_layerDescArray";
		if (Lua_BlackJack_ProjectL_UI_AnikiUITask.<>f__mg$cache28 == null)
		{
			Lua_BlackJack_ProjectL_UI_AnikiUITask.<>f__mg$cache28 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_AnikiUITask.get_m_layerDescArray);
		}
		LuaCSFunction get = Lua_BlackJack_ProjectL_UI_AnikiUITask.<>f__mg$cache28;
		if (Lua_BlackJack_ProjectL_UI_AnikiUITask.<>f__mg$cache29 == null)
		{
			Lua_BlackJack_ProjectL_UI_AnikiUITask.<>f__mg$cache29 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_AnikiUITask.set_m_layerDescArray);
		}
		LuaObject.addMember(l, name, get, Lua_BlackJack_ProjectL_UI_AnikiUITask.<>f__mg$cache29, true);
		string name2 = "m_uiCtrlDescArray";
		if (Lua_BlackJack_ProjectL_UI_AnikiUITask.<>f__mg$cache2A == null)
		{
			Lua_BlackJack_ProjectL_UI_AnikiUITask.<>f__mg$cache2A = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_AnikiUITask.get_m_uiCtrlDescArray);
		}
		LuaCSFunction get2 = Lua_BlackJack_ProjectL_UI_AnikiUITask.<>f__mg$cache2A;
		if (Lua_BlackJack_ProjectL_UI_AnikiUITask.<>f__mg$cache2B == null)
		{
			Lua_BlackJack_ProjectL_UI_AnikiUITask.<>f__mg$cache2B = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_AnikiUITask.set_m_uiCtrlDescArray);
		}
		LuaObject.addMember(l, name2, get2, Lua_BlackJack_ProjectL_UI_AnikiUITask.<>f__mg$cache2B, true);
		string name3 = "m_anikiUIController";
		if (Lua_BlackJack_ProjectL_UI_AnikiUITask.<>f__mg$cache2C == null)
		{
			Lua_BlackJack_ProjectL_UI_AnikiUITask.<>f__mg$cache2C = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_AnikiUITask.get_m_anikiUIController);
		}
		LuaCSFunction get3 = Lua_BlackJack_ProjectL_UI_AnikiUITask.<>f__mg$cache2C;
		if (Lua_BlackJack_ProjectL_UI_AnikiUITask.<>f__mg$cache2D == null)
		{
			Lua_BlackJack_ProjectL_UI_AnikiUITask.<>f__mg$cache2D = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_AnikiUITask.set_m_anikiUIController);
		}
		LuaObject.addMember(l, name3, get3, Lua_BlackJack_ProjectL_UI_AnikiUITask.<>f__mg$cache2D, true);
		string name4 = "m_playerResourceUIController";
		if (Lua_BlackJack_ProjectL_UI_AnikiUITask.<>f__mg$cache2E == null)
		{
			Lua_BlackJack_ProjectL_UI_AnikiUITask.<>f__mg$cache2E = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_AnikiUITask.get_m_playerResourceUIController);
		}
		LuaCSFunction get4 = Lua_BlackJack_ProjectL_UI_AnikiUITask.<>f__mg$cache2E;
		if (Lua_BlackJack_ProjectL_UI_AnikiUITask.<>f__mg$cache2F == null)
		{
			Lua_BlackJack_ProjectL_UI_AnikiUITask.<>f__mg$cache2F = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_AnikiUITask.set_m_playerResourceUIController);
		}
		LuaObject.addMember(l, name4, get4, Lua_BlackJack_ProjectL_UI_AnikiUITask.<>f__mg$cache2F, true);
		string name5 = "m_anikiGymInfo";
		if (Lua_BlackJack_ProjectL_UI_AnikiUITask.<>f__mg$cache30 == null)
		{
			Lua_BlackJack_ProjectL_UI_AnikiUITask.<>f__mg$cache30 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_AnikiUITask.get_m_anikiGymInfo);
		}
		LuaCSFunction get5 = Lua_BlackJack_ProjectL_UI_AnikiUITask.<>f__mg$cache30;
		if (Lua_BlackJack_ProjectL_UI_AnikiUITask.<>f__mg$cache31 == null)
		{
			Lua_BlackJack_ProjectL_UI_AnikiUITask.<>f__mg$cache31 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_AnikiUITask.set_m_anikiGymInfo);
		}
		LuaObject.addMember(l, name5, get5, Lua_BlackJack_ProjectL_UI_AnikiUITask.<>f__mg$cache31, true);
		string name6 = "LayerDescArray";
		if (Lua_BlackJack_ProjectL_UI_AnikiUITask.<>f__mg$cache32 == null)
		{
			Lua_BlackJack_ProjectL_UI_AnikiUITask.<>f__mg$cache32 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_AnikiUITask.get_LayerDescArray);
		}
		LuaObject.addMember(l, name6, Lua_BlackJack_ProjectL_UI_AnikiUITask.<>f__mg$cache32, null, true);
		string name7 = "UICtrlDescArray";
		if (Lua_BlackJack_ProjectL_UI_AnikiUITask.<>f__mg$cache33 == null)
		{
			Lua_BlackJack_ProjectL_UI_AnikiUITask.<>f__mg$cache33 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_AnikiUITask.get_UICtrlDescArray);
		}
		LuaObject.addMember(l, name7, Lua_BlackJack_ProjectL_UI_AnikiUITask.<>f__mg$cache33, null, true);
		if (Lua_BlackJack_ProjectL_UI_AnikiUITask.<>f__mg$cache34 == null)
		{
			Lua_BlackJack_ProjectL_UI_AnikiUITask.<>f__mg$cache34 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_AnikiUITask.constructor);
		}
		LuaObject.createTypeMetatable(l, Lua_BlackJack_ProjectL_UI_AnikiUITask.<>f__mg$cache34, typeof(AnikiUITask), typeof(UITask));
	}

	// Token: 0x04010EFD RID: 69373
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache0;

	// Token: 0x04010EFE RID: 69374
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1;

	// Token: 0x04010EFF RID: 69375
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2;

	// Token: 0x04010F00 RID: 69376
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3;

	// Token: 0x04010F01 RID: 69377
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache4;

	// Token: 0x04010F02 RID: 69378
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache5;

	// Token: 0x04010F03 RID: 69379
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache6;

	// Token: 0x04010F04 RID: 69380
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache7;

	// Token: 0x04010F05 RID: 69381
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache8;

	// Token: 0x04010F06 RID: 69382
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache9;

	// Token: 0x04010F07 RID: 69383
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheA;

	// Token: 0x04010F08 RID: 69384
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheB;

	// Token: 0x04010F09 RID: 69385
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheC;

	// Token: 0x04010F0A RID: 69386
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheD;

	// Token: 0x04010F0B RID: 69387
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheE;

	// Token: 0x04010F0C RID: 69388
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheF;

	// Token: 0x04010F0D RID: 69389
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache10;

	// Token: 0x04010F0E RID: 69390
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache11;

	// Token: 0x04010F0F RID: 69391
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache12;

	// Token: 0x04010F10 RID: 69392
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache13;

	// Token: 0x04010F11 RID: 69393
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache14;

	// Token: 0x04010F12 RID: 69394
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache15;

	// Token: 0x04010F13 RID: 69395
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache16;

	// Token: 0x04010F14 RID: 69396
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache17;

	// Token: 0x04010F15 RID: 69397
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache18;

	// Token: 0x04010F16 RID: 69398
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache19;

	// Token: 0x04010F17 RID: 69399
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1A;

	// Token: 0x04010F18 RID: 69400
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1B;

	// Token: 0x04010F19 RID: 69401
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1C;

	// Token: 0x04010F1A RID: 69402
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1D;

	// Token: 0x04010F1B RID: 69403
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1E;

	// Token: 0x04010F1C RID: 69404
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1F;

	// Token: 0x04010F1D RID: 69405
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache20;

	// Token: 0x04010F1E RID: 69406
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache21;

	// Token: 0x04010F1F RID: 69407
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache22;

	// Token: 0x04010F20 RID: 69408
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache23;

	// Token: 0x04010F21 RID: 69409
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache24;

	// Token: 0x04010F22 RID: 69410
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache25;

	// Token: 0x04010F23 RID: 69411
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache26;

	// Token: 0x04010F24 RID: 69412
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache27;

	// Token: 0x04010F25 RID: 69413
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache28;

	// Token: 0x04010F26 RID: 69414
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache29;

	// Token: 0x04010F27 RID: 69415
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2A;

	// Token: 0x04010F28 RID: 69416
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2B;

	// Token: 0x04010F29 RID: 69417
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2C;

	// Token: 0x04010F2A RID: 69418
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2D;

	// Token: 0x04010F2B RID: 69419
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2E;

	// Token: 0x04010F2C RID: 69420
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2F;

	// Token: 0x04010F2D RID: 69421
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache30;

	// Token: 0x04010F2E RID: 69422
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache31;

	// Token: 0x04010F2F RID: 69423
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache32;

	// Token: 0x04010F30 RID: 69424
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache33;

	// Token: 0x04010F31 RID: 69425
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache34;
}
