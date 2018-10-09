using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using BlackJack.BJFramework.Runtime.UI;
using BlackJack.ProjectL.PlayerContext;
using BlackJack.ProjectL.UI;
using SLua;
using UnityEngine.Scripting;

// Token: 0x020013F2 RID: 5106
[Preserve]
public class Lua_BlackJack_ProjectL_UI_ChestUITask : LuaObject
{
	// Token: 0x0601CAF1 RID: 117489 RVA: 0x008F08F4 File Offset: 0x008EEAF4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int constructor(IntPtr l)
	{
		int result;
		try
		{
			string name;
			LuaObject.checkType(l, 2, out name);
			ChestUITask o = new ChestUITask(name);
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

	// Token: 0x0601CAF2 RID: 117490 RVA: 0x008F0948 File Offset: 0x008EEB48
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int StartUITask_s(IntPtr l)
	{
		int result;
		try
		{
			BattleReward reward;
			LuaObject.checkType<BattleReward>(l, 1, out reward);
			bool isFirstWin;
			LuaObject.checkType(l, 2, out isFirstWin);
			bool isAutoOpen;
			LuaObject.checkType(l, 3, out isAutoOpen);
			ChestUITask o = ChestUITask.StartUITask(reward, isFirstWin, isAutoOpen);
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

	// Token: 0x0601CAF3 RID: 117491 RVA: 0x008F09B8 File Offset: 0x008EEBB8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int OnStart(IntPtr l)
	{
		int result;
		try
		{
			ChestUITask chestUITask = (ChestUITask)LuaObject.checkSelf(l);
			UIIntent intent;
			LuaObject.checkType<UIIntent>(l, 2, out intent);
			bool b = chestUITask.m_luaExportHelper.OnStart(intent);
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

	// Token: 0x0601CAF4 RID: 117492 RVA: 0x008F0A20 File Offset: 0x008EEC20
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int OnResume(IntPtr l)
	{
		int result;
		try
		{
			ChestUITask chestUITask = (ChestUITask)LuaObject.checkSelf(l);
			UIIntent intent;
			LuaObject.checkType<UIIntent>(l, 2, out intent);
			bool b = chestUITask.m_luaExportHelper.OnResume(intent);
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

	// Token: 0x0601CAF5 RID: 117493 RVA: 0x008F0A88 File Offset: 0x008EEC88
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int InitDataFromUIIntent(IntPtr l)
	{
		int result;
		try
		{
			ChestUITask chestUITask = (ChestUITask)LuaObject.checkSelf(l);
			UIIntent intent;
			LuaObject.checkType<UIIntent>(l, 2, out intent);
			chestUITask.m_luaExportHelper.InitDataFromUIIntent(intent);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601CAF6 RID: 117494 RVA: 0x008F0AE4 File Offset: 0x008EECE4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int IsNeedLoadDynamicRes(IntPtr l)
	{
		int result;
		try
		{
			ChestUITask chestUITask = (ChestUITask)LuaObject.checkSelf(l);
			bool b = chestUITask.m_luaExportHelper.IsNeedLoadDynamicRes();
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

	// Token: 0x0601CAF7 RID: 117495 RVA: 0x008F0B40 File Offset: 0x008EED40
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int InitAllUIControllers(IntPtr l)
	{
		int result;
		try
		{
			ChestUITask chestUITask = (ChestUITask)LuaObject.checkSelf(l);
			chestUITask.m_luaExportHelper.InitAllUIControllers();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601CAF8 RID: 117496 RVA: 0x008F0B94 File Offset: 0x008EED94
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int ClearAllContextAndRes(IntPtr l)
	{
		int result;
		try
		{
			ChestUITask chestUITask = (ChestUITask)LuaObject.checkSelf(l);
			chestUITask.m_luaExportHelper.ClearAllContextAndRes();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601CAF9 RID: 117497 RVA: 0x008F0BE8 File Offset: 0x008EEDE8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int UpdateView(IntPtr l)
	{
		int result;
		try
		{
			ChestUITask chestUITask = (ChestUITask)LuaObject.checkSelf(l);
			chestUITask.m_luaExportHelper.UpdateView();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601CAFA RID: 117498 RVA: 0x008F0C3C File Offset: 0x008EEE3C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int ChestUIController_OnClose(IntPtr l)
	{
		int result;
		try
		{
			ChestUITask chestUITask = (ChestUITask)LuaObject.checkSelf(l);
			chestUITask.m_luaExportHelper.ChestUIController_OnClose();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601CAFB RID: 117499 RVA: 0x008F0C90 File Offset: 0x008EEE90
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_OnStart(IntPtr l)
	{
		int result;
		try
		{
			ChestUITask chestUITask = (ChestUITask)LuaObject.checkSelf(l);
			UIIntent intent;
			LuaObject.checkType<UIIntent>(l, 2, out intent);
			bool b = chestUITask.m_luaExportHelper.__callBase_OnStart(intent);
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

	// Token: 0x0601CAFC RID: 117500 RVA: 0x008F0CF8 File Offset: 0x008EEEF8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_OnStop(IntPtr l)
	{
		int result;
		try
		{
			ChestUITask chestUITask = (ChestUITask)LuaObject.checkSelf(l);
			chestUITask.m_luaExportHelper.__callBase_OnStop();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601CAFD RID: 117501 RVA: 0x008F0D4C File Offset: 0x008EEF4C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_OnPause(IntPtr l)
	{
		int result;
		try
		{
			ChestUITask chestUITask = (ChestUITask)LuaObject.checkSelf(l);
			chestUITask.m_luaExportHelper.__callBase_OnPause();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601CAFE RID: 117502 RVA: 0x008F0DA0 File Offset: 0x008EEFA0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_OnResume(IntPtr l)
	{
		int result;
		try
		{
			ChestUITask chestUITask = (ChestUITask)LuaObject.checkSelf(l);
			UIIntent intent;
			LuaObject.checkType<UIIntent>(l, 2, out intent);
			bool b = chestUITask.m_luaExportHelper.__callBase_OnResume(intent);
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

	// Token: 0x0601CAFF RID: 117503 RVA: 0x008F0E08 File Offset: 0x008EF008
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_OnNewIntent(IntPtr l)
	{
		int result;
		try
		{
			ChestUITask chestUITask = (ChestUITask)LuaObject.checkSelf(l);
			UIIntent intent;
			LuaObject.checkType<UIIntent>(l, 2, out intent);
			bool b = chestUITask.m_luaExportHelper.__callBase_OnNewIntent(intent);
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

	// Token: 0x0601CB00 RID: 117504 RVA: 0x008F0E70 File Offset: 0x008EF070
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_EnableUIInput(IntPtr l)
	{
		int result;
		try
		{
			ChestUITask chestUITask = (ChestUITask)LuaObject.checkSelf(l);
			bool isEnable;
			LuaObject.checkType(l, 2, out isEnable);
			bool? isGlobalEnable;
			LuaObject.checkNullable<bool>(l, 3, out isGlobalEnable);
			chestUITask.m_luaExportHelper.__callBase_EnableUIInput(isEnable, isGlobalEnable);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601CB01 RID: 117505 RVA: 0x008F0EDC File Offset: 0x008EF0DC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_IsNeedLoadDynamicRes(IntPtr l)
	{
		int result;
		try
		{
			ChestUITask chestUITask = (ChestUITask)LuaObject.checkSelf(l);
			bool b = chestUITask.m_luaExportHelper.__callBase_IsNeedLoadDynamicRes();
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

	// Token: 0x0601CB02 RID: 117506 RVA: 0x008F0F38 File Offset: 0x008EF138
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_CollectAllDynamicResForLoad(IntPtr l)
	{
		int result;
		try
		{
			ChestUITask chestUITask = (ChestUITask)LuaObject.checkSelf(l);
			List<string> o = chestUITask.m_luaExportHelper.__callBase_CollectAllDynamicResForLoad();
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

	// Token: 0x0601CB03 RID: 117507 RVA: 0x008F0F94 File Offset: 0x008EF194
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_RegisterPlayerContextEvents(IntPtr l)
	{
		int result;
		try
		{
			ChestUITask chestUITask = (ChestUITask)LuaObject.checkSelf(l);
			chestUITask.m_luaExportHelper.__callBase_RegisterPlayerContextEvents();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601CB04 RID: 117508 RVA: 0x008F0FE8 File Offset: 0x008EF1E8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_UnregisterPlayerContextEvents(IntPtr l)
	{
		int result;
		try
		{
			ChestUITask chestUITask = (ChestUITask)LuaObject.checkSelf(l);
			chestUITask.m_luaExportHelper.__callBase_UnregisterPlayerContextEvents();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601CB05 RID: 117509 RVA: 0x008F103C File Offset: 0x008EF23C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_PostUpdateView(IntPtr l)
	{
		int result;
		try
		{
			ChestUITask chestUITask = (ChestUITask)LuaObject.checkSelf(l);
			chestUITask.m_luaExportHelper.__callBase_PostUpdateView();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601CB06 RID: 117510 RVA: 0x008F1090 File Offset: 0x008EF290
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_CollectPreloadResourceList(IntPtr l)
	{
		int result;
		try
		{
			ChestUITask chestUITask = (ChestUITask)LuaObject.checkSelf(l);
			chestUITask.m_luaExportHelper.__callBase_CollectPreloadResourceList();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601CB07 RID: 117511 RVA: 0x008F10E4 File Offset: 0x008EF2E4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_ClearAssetList(IntPtr l)
	{
		int result;
		try
		{
			ChestUITask chestUITask = (ChestUITask)LuaObject.checkSelf(l);
			chestUITask.m_luaExportHelper.__callBase_ClearAssetList();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601CB08 RID: 117512 RVA: 0x008F1138 File Offset: 0x008EF338
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_CollectAsset(IntPtr l)
	{
		int result;
		try
		{
			ChestUITask chestUITask = (ChestUITask)LuaObject.checkSelf(l);
			string assetName;
			LuaObject.checkType(l, 2, out assetName);
			chestUITask.m_luaExportHelper.__callBase_CollectAsset(assetName);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601CB09 RID: 117513 RVA: 0x008F1194 File Offset: 0x008EF394
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_CollectSpriteAsset(IntPtr l)
	{
		int result;
		try
		{
			ChestUITask chestUITask = (ChestUITask)LuaObject.checkSelf(l);
			string assetName;
			LuaObject.checkType(l, 2, out assetName);
			chestUITask.m_luaExportHelper.__callBase_CollectSpriteAsset(assetName);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601CB0A RID: 117514 RVA: 0x008F11F0 File Offset: 0x008EF3F0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_CollectFxAsset(IntPtr l)
	{
		int result;
		try
		{
			ChestUITask chestUITask = (ChestUITask)LuaObject.checkSelf(l);
			string assetName;
			LuaObject.checkType(l, 2, out assetName);
			chestUITask.m_luaExportHelper.__callBase_CollectFxAsset(assetName);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601CB0B RID: 117515 RVA: 0x008F124C File Offset: 0x008EF44C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_StartLoadCustomAssets(IntPtr l)
	{
		int result;
		try
		{
			ChestUITask chestUITask = (ChestUITask)LuaObject.checkSelf(l);
			Action onLoadCompleted;
			LuaObject.checkDelegate<Action>(l, 2, out onLoadCompleted);
			chestUITask.m_luaExportHelper.__callBase_StartLoadCustomAssets(onLoadCompleted);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601CB0C RID: 117516 RVA: 0x008F12A8 File Offset: 0x008EF4A8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_IsLoadingCustomAssets(IntPtr l)
	{
		int result;
		try
		{
			ChestUITask chestUITask = (ChestUITask)LuaObject.checkSelf(l);
			bool b = chestUITask.m_luaExportHelper.__callBase_IsLoadingCustomAssets();
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

	// Token: 0x0601CB0D RID: 117517 RVA: 0x008F1304 File Offset: 0x008EF504
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_IsPipeLineRunning(IntPtr l)
	{
		int result;
		try
		{
			ChestUITask chestUITask = (ChestUITask)LuaObject.checkSelf(l);
			bool b = chestUITask.m_luaExportHelper.__callBase_IsPipeLineRunning();
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

	// Token: 0x0601CB0E RID: 117518 RVA: 0x008F1360 File Offset: 0x008EF560
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_IsOpeningUI(IntPtr l)
	{
		int result;
		try
		{
			ChestUITask chestUITask = (ChestUITask)LuaObject.checkSelf(l);
			bool b = chestUITask.m_luaExportHelper.__callBase_IsOpeningUI();
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

	// Token: 0x0601CB0F RID: 117519 RVA: 0x008F13BC File Offset: 0x008EF5BC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_ReturnPrevUITask(IntPtr l)
	{
		int result;
		try
		{
			ChestUITask chestUITask = (ChestUITask)LuaObject.checkSelf(l);
			UITaskBase o = chestUITask.m_luaExportHelper.__callBase_ReturnPrevUITask();
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

	// Token: 0x0601CB10 RID: 117520 RVA: 0x008F1418 File Offset: 0x008EF618
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_ClearUnusedDynamicResourceCache(IntPtr l)
	{
		int result;
		try
		{
			ChestUITask chestUITask = (ChestUITask)LuaObject.checkSelf(l);
			chestUITask.m_luaExportHelper.__callBase_ClearUnusedDynamicResourceCache();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601CB11 RID: 117521 RVA: 0x008F146C File Offset: 0x008EF66C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_OnMemoryWarning(IntPtr l)
	{
		int result;
		try
		{
			ChestUITask chestUITask = (ChestUITask)LuaObject.checkSelf(l);
			chestUITask.m_luaExportHelper.__callBase_OnMemoryWarning();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601CB12 RID: 117522 RVA: 0x008F14C0 File Offset: 0x008EF6C0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callDele_EventOnClose(IntPtr l)
	{
		int result;
		try
		{
			ChestUITask chestUITask = (ChestUITask)LuaObject.checkSelf(l);
			chestUITask.m_luaExportHelper.__callDele_EventOnClose();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601CB13 RID: 117523 RVA: 0x008F1514 File Offset: 0x008EF714
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __clearDele_EventOnClose(IntPtr l)
	{
		int result;
		try
		{
			ChestUITask chestUITask = (ChestUITask)LuaObject.checkSelf(l);
			chestUITask.m_luaExportHelper.__clearDele_EventOnClose();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601CB14 RID: 117524 RVA: 0x008F1568 File Offset: 0x008EF768
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_EventOnClose(IntPtr l)
	{
		int result;
		try
		{
			ChestUITask chestUITask = (ChestUITask)LuaObject.checkSelf(l);
			Action value;
			int num = LuaObject.checkDelegate<Action>(l, 2, out value);
			if (num != 0)
			{
				if (num == 1)
				{
					chestUITask.EventOnClose += value;
				}
				else if (num == 2)
				{
					chestUITask.EventOnClose -= value;
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

	// Token: 0x0601CB15 RID: 117525 RVA: 0x008F15E8 File Offset: 0x008EF7E8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_layerDescArray(IntPtr l)
	{
		int result;
		try
		{
			ChestUITask chestUITask = (ChestUITask)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, chestUITask.m_luaExportHelper.m_layerDescArray);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601CB16 RID: 117526 RVA: 0x008F1640 File Offset: 0x008EF840
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_layerDescArray(IntPtr l)
	{
		int result;
		try
		{
			ChestUITask chestUITask = (ChestUITask)LuaObject.checkSelf(l);
			UITaskBase.LayerDesc[] layerDescArray;
			LuaObject.checkArray<UITaskBase.LayerDesc>(l, 2, out layerDescArray);
			chestUITask.m_luaExportHelper.m_layerDescArray = layerDescArray;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601CB17 RID: 117527 RVA: 0x008F169C File Offset: 0x008EF89C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_uiCtrlDescArray(IntPtr l)
	{
		int result;
		try
		{
			ChestUITask chestUITask = (ChestUITask)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, chestUITask.m_luaExportHelper.m_uiCtrlDescArray);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601CB18 RID: 117528 RVA: 0x008F16F4 File Offset: 0x008EF8F4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_uiCtrlDescArray(IntPtr l)
	{
		int result;
		try
		{
			ChestUITask chestUITask = (ChestUITask)LuaObject.checkSelf(l);
			UITaskBase.UIControllerDesc[] uiCtrlDescArray;
			LuaObject.checkArray<UITaskBase.UIControllerDesc>(l, 2, out uiCtrlDescArray);
			chestUITask.m_luaExportHelper.m_uiCtrlDescArray = uiCtrlDescArray;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601CB19 RID: 117529 RVA: 0x008F1750 File Offset: 0x008EF950
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_ParamKey_BattleReward(IntPtr l)
	{
		int result;
		try
		{
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, ChestUITask.LuaExportHelper.ParamKey_BattleReward);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601CB1A RID: 117530 RVA: 0x008F1798 File Offset: 0x008EF998
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_ParamKey_IsFirstWin(IntPtr l)
	{
		int result;
		try
		{
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, ChestUITask.LuaExportHelper.ParamKey_IsFirstWin);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601CB1B RID: 117531 RVA: 0x008F17E0 File Offset: 0x008EF9E0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_ParamKey_IsAutoOpen(IntPtr l)
	{
		int result;
		try
		{
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, ChestUITask.LuaExportHelper.ParamKey_IsAutoOpen);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601CB1C RID: 117532 RVA: 0x008F1828 File Offset: 0x008EFA28
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_battleReward(IntPtr l)
	{
		int result;
		try
		{
			ChestUITask chestUITask = (ChestUITask)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, chestUITask.m_luaExportHelper.m_battleReward);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601CB1D RID: 117533 RVA: 0x008F1880 File Offset: 0x008EFA80
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_battleReward(IntPtr l)
	{
		int result;
		try
		{
			ChestUITask chestUITask = (ChestUITask)LuaObject.checkSelf(l);
			BattleReward battleReward;
			LuaObject.checkType<BattleReward>(l, 2, out battleReward);
			chestUITask.m_luaExportHelper.m_battleReward = battleReward;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601CB1E RID: 117534 RVA: 0x008F18DC File Offset: 0x008EFADC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_isFirstWin(IntPtr l)
	{
		int result;
		try
		{
			ChestUITask chestUITask = (ChestUITask)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, chestUITask.m_luaExportHelper.m_isFirstWin);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601CB1F RID: 117535 RVA: 0x008F1934 File Offset: 0x008EFB34
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_isFirstWin(IntPtr l)
	{
		int result;
		try
		{
			ChestUITask chestUITask = (ChestUITask)LuaObject.checkSelf(l);
			bool isFirstWin;
			LuaObject.checkType(l, 2, out isFirstWin);
			chestUITask.m_luaExportHelper.m_isFirstWin = isFirstWin;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601CB20 RID: 117536 RVA: 0x008F1990 File Offset: 0x008EFB90
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_isAutoOpen(IntPtr l)
	{
		int result;
		try
		{
			ChestUITask chestUITask = (ChestUITask)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, chestUITask.m_luaExportHelper.m_isAutoOpen);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601CB21 RID: 117537 RVA: 0x008F19E8 File Offset: 0x008EFBE8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_isAutoOpen(IntPtr l)
	{
		int result;
		try
		{
			ChestUITask chestUITask = (ChestUITask)LuaObject.checkSelf(l);
			bool isAutoOpen;
			LuaObject.checkType(l, 2, out isAutoOpen);
			chestUITask.m_luaExportHelper.m_isAutoOpen = isAutoOpen;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601CB22 RID: 117538 RVA: 0x008F1A44 File Offset: 0x008EFC44
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_chestUIController(IntPtr l)
	{
		int result;
		try
		{
			ChestUITask chestUITask = (ChestUITask)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, chestUITask.m_luaExportHelper.m_chestUIController);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601CB23 RID: 117539 RVA: 0x008F1A9C File Offset: 0x008EFC9C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_chestUIController(IntPtr l)
	{
		int result;
		try
		{
			ChestUITask chestUITask = (ChestUITask)LuaObject.checkSelf(l);
			ChestUIController chestUIController;
			LuaObject.checkType<ChestUIController>(l, 2, out chestUIController);
			chestUITask.m_luaExportHelper.m_chestUIController = chestUIController;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601CB24 RID: 117540 RVA: 0x008F1AF8 File Offset: 0x008EFCF8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_LayerDescArray(IntPtr l)
	{
		int result;
		try
		{
			ChestUITask chestUITask = (ChestUITask)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, chestUITask.m_luaExportHelper.LayerDescArray);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601CB25 RID: 117541 RVA: 0x008F1B50 File Offset: 0x008EFD50
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_UICtrlDescArray(IntPtr l)
	{
		int result;
		try
		{
			ChestUITask chestUITask = (ChestUITask)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, chestUITask.m_luaExportHelper.UICtrlDescArray);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601CB26 RID: 117542 RVA: 0x008F1BA8 File Offset: 0x008EFDA8
	[Preserve]
	public static void reg(IntPtr l)
	{
		LuaObject.getTypeTable(l, "BlackJack.ProjectL.UI.ChestUITask");
		if (Lua_BlackJack_ProjectL_UI_ChestUITask.<>f__mg$cache0 == null)
		{
			Lua_BlackJack_ProjectL_UI_ChestUITask.<>f__mg$cache0 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ChestUITask.StartUITask_s);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_ChestUITask.<>f__mg$cache0);
		if (Lua_BlackJack_ProjectL_UI_ChestUITask.<>f__mg$cache1 == null)
		{
			Lua_BlackJack_ProjectL_UI_ChestUITask.<>f__mg$cache1 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ChestUITask.OnStart);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_ChestUITask.<>f__mg$cache1);
		if (Lua_BlackJack_ProjectL_UI_ChestUITask.<>f__mg$cache2 == null)
		{
			Lua_BlackJack_ProjectL_UI_ChestUITask.<>f__mg$cache2 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ChestUITask.OnResume);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_ChestUITask.<>f__mg$cache2);
		if (Lua_BlackJack_ProjectL_UI_ChestUITask.<>f__mg$cache3 == null)
		{
			Lua_BlackJack_ProjectL_UI_ChestUITask.<>f__mg$cache3 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ChestUITask.InitDataFromUIIntent);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_ChestUITask.<>f__mg$cache3);
		if (Lua_BlackJack_ProjectL_UI_ChestUITask.<>f__mg$cache4 == null)
		{
			Lua_BlackJack_ProjectL_UI_ChestUITask.<>f__mg$cache4 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ChestUITask.IsNeedLoadDynamicRes);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_ChestUITask.<>f__mg$cache4);
		if (Lua_BlackJack_ProjectL_UI_ChestUITask.<>f__mg$cache5 == null)
		{
			Lua_BlackJack_ProjectL_UI_ChestUITask.<>f__mg$cache5 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ChestUITask.InitAllUIControllers);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_ChestUITask.<>f__mg$cache5);
		if (Lua_BlackJack_ProjectL_UI_ChestUITask.<>f__mg$cache6 == null)
		{
			Lua_BlackJack_ProjectL_UI_ChestUITask.<>f__mg$cache6 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ChestUITask.ClearAllContextAndRes);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_ChestUITask.<>f__mg$cache6);
		if (Lua_BlackJack_ProjectL_UI_ChestUITask.<>f__mg$cache7 == null)
		{
			Lua_BlackJack_ProjectL_UI_ChestUITask.<>f__mg$cache7 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ChestUITask.UpdateView);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_ChestUITask.<>f__mg$cache7);
		if (Lua_BlackJack_ProjectL_UI_ChestUITask.<>f__mg$cache8 == null)
		{
			Lua_BlackJack_ProjectL_UI_ChestUITask.<>f__mg$cache8 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ChestUITask.ChestUIController_OnClose);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_ChestUITask.<>f__mg$cache8);
		if (Lua_BlackJack_ProjectL_UI_ChestUITask.<>f__mg$cache9 == null)
		{
			Lua_BlackJack_ProjectL_UI_ChestUITask.<>f__mg$cache9 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ChestUITask.__callBase_OnStart);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_ChestUITask.<>f__mg$cache9);
		if (Lua_BlackJack_ProjectL_UI_ChestUITask.<>f__mg$cacheA == null)
		{
			Lua_BlackJack_ProjectL_UI_ChestUITask.<>f__mg$cacheA = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ChestUITask.__callBase_OnStop);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_ChestUITask.<>f__mg$cacheA);
		if (Lua_BlackJack_ProjectL_UI_ChestUITask.<>f__mg$cacheB == null)
		{
			Lua_BlackJack_ProjectL_UI_ChestUITask.<>f__mg$cacheB = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ChestUITask.__callBase_OnPause);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_ChestUITask.<>f__mg$cacheB);
		if (Lua_BlackJack_ProjectL_UI_ChestUITask.<>f__mg$cacheC == null)
		{
			Lua_BlackJack_ProjectL_UI_ChestUITask.<>f__mg$cacheC = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ChestUITask.__callBase_OnResume);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_ChestUITask.<>f__mg$cacheC);
		if (Lua_BlackJack_ProjectL_UI_ChestUITask.<>f__mg$cacheD == null)
		{
			Lua_BlackJack_ProjectL_UI_ChestUITask.<>f__mg$cacheD = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ChestUITask.__callBase_OnNewIntent);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_ChestUITask.<>f__mg$cacheD);
		if (Lua_BlackJack_ProjectL_UI_ChestUITask.<>f__mg$cacheE == null)
		{
			Lua_BlackJack_ProjectL_UI_ChestUITask.<>f__mg$cacheE = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ChestUITask.__callBase_EnableUIInput);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_ChestUITask.<>f__mg$cacheE);
		if (Lua_BlackJack_ProjectL_UI_ChestUITask.<>f__mg$cacheF == null)
		{
			Lua_BlackJack_ProjectL_UI_ChestUITask.<>f__mg$cacheF = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ChestUITask.__callBase_IsNeedLoadDynamicRes);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_ChestUITask.<>f__mg$cacheF);
		if (Lua_BlackJack_ProjectL_UI_ChestUITask.<>f__mg$cache10 == null)
		{
			Lua_BlackJack_ProjectL_UI_ChestUITask.<>f__mg$cache10 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ChestUITask.__callBase_CollectAllDynamicResForLoad);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_ChestUITask.<>f__mg$cache10);
		if (Lua_BlackJack_ProjectL_UI_ChestUITask.<>f__mg$cache11 == null)
		{
			Lua_BlackJack_ProjectL_UI_ChestUITask.<>f__mg$cache11 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ChestUITask.__callBase_RegisterPlayerContextEvents);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_ChestUITask.<>f__mg$cache11);
		if (Lua_BlackJack_ProjectL_UI_ChestUITask.<>f__mg$cache12 == null)
		{
			Lua_BlackJack_ProjectL_UI_ChestUITask.<>f__mg$cache12 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ChestUITask.__callBase_UnregisterPlayerContextEvents);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_ChestUITask.<>f__mg$cache12);
		if (Lua_BlackJack_ProjectL_UI_ChestUITask.<>f__mg$cache13 == null)
		{
			Lua_BlackJack_ProjectL_UI_ChestUITask.<>f__mg$cache13 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ChestUITask.__callBase_PostUpdateView);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_ChestUITask.<>f__mg$cache13);
		if (Lua_BlackJack_ProjectL_UI_ChestUITask.<>f__mg$cache14 == null)
		{
			Lua_BlackJack_ProjectL_UI_ChestUITask.<>f__mg$cache14 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ChestUITask.__callBase_CollectPreloadResourceList);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_ChestUITask.<>f__mg$cache14);
		if (Lua_BlackJack_ProjectL_UI_ChestUITask.<>f__mg$cache15 == null)
		{
			Lua_BlackJack_ProjectL_UI_ChestUITask.<>f__mg$cache15 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ChestUITask.__callBase_ClearAssetList);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_ChestUITask.<>f__mg$cache15);
		if (Lua_BlackJack_ProjectL_UI_ChestUITask.<>f__mg$cache16 == null)
		{
			Lua_BlackJack_ProjectL_UI_ChestUITask.<>f__mg$cache16 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ChestUITask.__callBase_CollectAsset);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_ChestUITask.<>f__mg$cache16);
		if (Lua_BlackJack_ProjectL_UI_ChestUITask.<>f__mg$cache17 == null)
		{
			Lua_BlackJack_ProjectL_UI_ChestUITask.<>f__mg$cache17 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ChestUITask.__callBase_CollectSpriteAsset);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_ChestUITask.<>f__mg$cache17);
		if (Lua_BlackJack_ProjectL_UI_ChestUITask.<>f__mg$cache18 == null)
		{
			Lua_BlackJack_ProjectL_UI_ChestUITask.<>f__mg$cache18 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ChestUITask.__callBase_CollectFxAsset);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_ChestUITask.<>f__mg$cache18);
		if (Lua_BlackJack_ProjectL_UI_ChestUITask.<>f__mg$cache19 == null)
		{
			Lua_BlackJack_ProjectL_UI_ChestUITask.<>f__mg$cache19 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ChestUITask.__callBase_StartLoadCustomAssets);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_ChestUITask.<>f__mg$cache19);
		if (Lua_BlackJack_ProjectL_UI_ChestUITask.<>f__mg$cache1A == null)
		{
			Lua_BlackJack_ProjectL_UI_ChestUITask.<>f__mg$cache1A = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ChestUITask.__callBase_IsLoadingCustomAssets);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_ChestUITask.<>f__mg$cache1A);
		if (Lua_BlackJack_ProjectL_UI_ChestUITask.<>f__mg$cache1B == null)
		{
			Lua_BlackJack_ProjectL_UI_ChestUITask.<>f__mg$cache1B = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ChestUITask.__callBase_IsPipeLineRunning);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_ChestUITask.<>f__mg$cache1B);
		if (Lua_BlackJack_ProjectL_UI_ChestUITask.<>f__mg$cache1C == null)
		{
			Lua_BlackJack_ProjectL_UI_ChestUITask.<>f__mg$cache1C = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ChestUITask.__callBase_IsOpeningUI);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_ChestUITask.<>f__mg$cache1C);
		if (Lua_BlackJack_ProjectL_UI_ChestUITask.<>f__mg$cache1D == null)
		{
			Lua_BlackJack_ProjectL_UI_ChestUITask.<>f__mg$cache1D = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ChestUITask.__callBase_ReturnPrevUITask);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_ChestUITask.<>f__mg$cache1D);
		if (Lua_BlackJack_ProjectL_UI_ChestUITask.<>f__mg$cache1E == null)
		{
			Lua_BlackJack_ProjectL_UI_ChestUITask.<>f__mg$cache1E = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ChestUITask.__callBase_ClearUnusedDynamicResourceCache);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_ChestUITask.<>f__mg$cache1E);
		if (Lua_BlackJack_ProjectL_UI_ChestUITask.<>f__mg$cache1F == null)
		{
			Lua_BlackJack_ProjectL_UI_ChestUITask.<>f__mg$cache1F = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ChestUITask.__callBase_OnMemoryWarning);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_ChestUITask.<>f__mg$cache1F);
		if (Lua_BlackJack_ProjectL_UI_ChestUITask.<>f__mg$cache20 == null)
		{
			Lua_BlackJack_ProjectL_UI_ChestUITask.<>f__mg$cache20 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ChestUITask.__callDele_EventOnClose);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_ChestUITask.<>f__mg$cache20);
		if (Lua_BlackJack_ProjectL_UI_ChestUITask.<>f__mg$cache21 == null)
		{
			Lua_BlackJack_ProjectL_UI_ChestUITask.<>f__mg$cache21 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ChestUITask.__clearDele_EventOnClose);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_ChestUITask.<>f__mg$cache21);
		string name = "EventOnClose";
		LuaCSFunction get = null;
		if (Lua_BlackJack_ProjectL_UI_ChestUITask.<>f__mg$cache22 == null)
		{
			Lua_BlackJack_ProjectL_UI_ChestUITask.<>f__mg$cache22 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ChestUITask.set_EventOnClose);
		}
		LuaObject.addMember(l, name, get, Lua_BlackJack_ProjectL_UI_ChestUITask.<>f__mg$cache22, true);
		string name2 = "m_layerDescArray";
		if (Lua_BlackJack_ProjectL_UI_ChestUITask.<>f__mg$cache23 == null)
		{
			Lua_BlackJack_ProjectL_UI_ChestUITask.<>f__mg$cache23 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ChestUITask.get_m_layerDescArray);
		}
		LuaCSFunction get2 = Lua_BlackJack_ProjectL_UI_ChestUITask.<>f__mg$cache23;
		if (Lua_BlackJack_ProjectL_UI_ChestUITask.<>f__mg$cache24 == null)
		{
			Lua_BlackJack_ProjectL_UI_ChestUITask.<>f__mg$cache24 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ChestUITask.set_m_layerDescArray);
		}
		LuaObject.addMember(l, name2, get2, Lua_BlackJack_ProjectL_UI_ChestUITask.<>f__mg$cache24, true);
		string name3 = "m_uiCtrlDescArray";
		if (Lua_BlackJack_ProjectL_UI_ChestUITask.<>f__mg$cache25 == null)
		{
			Lua_BlackJack_ProjectL_UI_ChestUITask.<>f__mg$cache25 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ChestUITask.get_m_uiCtrlDescArray);
		}
		LuaCSFunction get3 = Lua_BlackJack_ProjectL_UI_ChestUITask.<>f__mg$cache25;
		if (Lua_BlackJack_ProjectL_UI_ChestUITask.<>f__mg$cache26 == null)
		{
			Lua_BlackJack_ProjectL_UI_ChestUITask.<>f__mg$cache26 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ChestUITask.set_m_uiCtrlDescArray);
		}
		LuaObject.addMember(l, name3, get3, Lua_BlackJack_ProjectL_UI_ChestUITask.<>f__mg$cache26, true);
		string name4 = "ParamKey_BattleReward";
		if (Lua_BlackJack_ProjectL_UI_ChestUITask.<>f__mg$cache27 == null)
		{
			Lua_BlackJack_ProjectL_UI_ChestUITask.<>f__mg$cache27 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ChestUITask.get_ParamKey_BattleReward);
		}
		LuaObject.addMember(l, name4, Lua_BlackJack_ProjectL_UI_ChestUITask.<>f__mg$cache27, null, false);
		string name5 = "ParamKey_IsFirstWin";
		if (Lua_BlackJack_ProjectL_UI_ChestUITask.<>f__mg$cache28 == null)
		{
			Lua_BlackJack_ProjectL_UI_ChestUITask.<>f__mg$cache28 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ChestUITask.get_ParamKey_IsFirstWin);
		}
		LuaObject.addMember(l, name5, Lua_BlackJack_ProjectL_UI_ChestUITask.<>f__mg$cache28, null, false);
		string name6 = "ParamKey_IsAutoOpen";
		if (Lua_BlackJack_ProjectL_UI_ChestUITask.<>f__mg$cache29 == null)
		{
			Lua_BlackJack_ProjectL_UI_ChestUITask.<>f__mg$cache29 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ChestUITask.get_ParamKey_IsAutoOpen);
		}
		LuaObject.addMember(l, name6, Lua_BlackJack_ProjectL_UI_ChestUITask.<>f__mg$cache29, null, false);
		string name7 = "m_battleReward";
		if (Lua_BlackJack_ProjectL_UI_ChestUITask.<>f__mg$cache2A == null)
		{
			Lua_BlackJack_ProjectL_UI_ChestUITask.<>f__mg$cache2A = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ChestUITask.get_m_battleReward);
		}
		LuaCSFunction get4 = Lua_BlackJack_ProjectL_UI_ChestUITask.<>f__mg$cache2A;
		if (Lua_BlackJack_ProjectL_UI_ChestUITask.<>f__mg$cache2B == null)
		{
			Lua_BlackJack_ProjectL_UI_ChestUITask.<>f__mg$cache2B = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ChestUITask.set_m_battleReward);
		}
		LuaObject.addMember(l, name7, get4, Lua_BlackJack_ProjectL_UI_ChestUITask.<>f__mg$cache2B, true);
		string name8 = "m_isFirstWin";
		if (Lua_BlackJack_ProjectL_UI_ChestUITask.<>f__mg$cache2C == null)
		{
			Lua_BlackJack_ProjectL_UI_ChestUITask.<>f__mg$cache2C = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ChestUITask.get_m_isFirstWin);
		}
		LuaCSFunction get5 = Lua_BlackJack_ProjectL_UI_ChestUITask.<>f__mg$cache2C;
		if (Lua_BlackJack_ProjectL_UI_ChestUITask.<>f__mg$cache2D == null)
		{
			Lua_BlackJack_ProjectL_UI_ChestUITask.<>f__mg$cache2D = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ChestUITask.set_m_isFirstWin);
		}
		LuaObject.addMember(l, name8, get5, Lua_BlackJack_ProjectL_UI_ChestUITask.<>f__mg$cache2D, true);
		string name9 = "m_isAutoOpen";
		if (Lua_BlackJack_ProjectL_UI_ChestUITask.<>f__mg$cache2E == null)
		{
			Lua_BlackJack_ProjectL_UI_ChestUITask.<>f__mg$cache2E = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ChestUITask.get_m_isAutoOpen);
		}
		LuaCSFunction get6 = Lua_BlackJack_ProjectL_UI_ChestUITask.<>f__mg$cache2E;
		if (Lua_BlackJack_ProjectL_UI_ChestUITask.<>f__mg$cache2F == null)
		{
			Lua_BlackJack_ProjectL_UI_ChestUITask.<>f__mg$cache2F = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ChestUITask.set_m_isAutoOpen);
		}
		LuaObject.addMember(l, name9, get6, Lua_BlackJack_ProjectL_UI_ChestUITask.<>f__mg$cache2F, true);
		string name10 = "m_chestUIController";
		if (Lua_BlackJack_ProjectL_UI_ChestUITask.<>f__mg$cache30 == null)
		{
			Lua_BlackJack_ProjectL_UI_ChestUITask.<>f__mg$cache30 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ChestUITask.get_m_chestUIController);
		}
		LuaCSFunction get7 = Lua_BlackJack_ProjectL_UI_ChestUITask.<>f__mg$cache30;
		if (Lua_BlackJack_ProjectL_UI_ChestUITask.<>f__mg$cache31 == null)
		{
			Lua_BlackJack_ProjectL_UI_ChestUITask.<>f__mg$cache31 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ChestUITask.set_m_chestUIController);
		}
		LuaObject.addMember(l, name10, get7, Lua_BlackJack_ProjectL_UI_ChestUITask.<>f__mg$cache31, true);
		string name11 = "LayerDescArray";
		if (Lua_BlackJack_ProjectL_UI_ChestUITask.<>f__mg$cache32 == null)
		{
			Lua_BlackJack_ProjectL_UI_ChestUITask.<>f__mg$cache32 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ChestUITask.get_LayerDescArray);
		}
		LuaObject.addMember(l, name11, Lua_BlackJack_ProjectL_UI_ChestUITask.<>f__mg$cache32, null, true);
		string name12 = "UICtrlDescArray";
		if (Lua_BlackJack_ProjectL_UI_ChestUITask.<>f__mg$cache33 == null)
		{
			Lua_BlackJack_ProjectL_UI_ChestUITask.<>f__mg$cache33 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ChestUITask.get_UICtrlDescArray);
		}
		LuaObject.addMember(l, name12, Lua_BlackJack_ProjectL_UI_ChestUITask.<>f__mg$cache33, null, true);
		if (Lua_BlackJack_ProjectL_UI_ChestUITask.<>f__mg$cache34 == null)
		{
			Lua_BlackJack_ProjectL_UI_ChestUITask.<>f__mg$cache34 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ChestUITask.constructor);
		}
		LuaObject.createTypeMetatable(l, Lua_BlackJack_ProjectL_UI_ChestUITask.<>f__mg$cache34, typeof(ChestUITask), typeof(UITask));
	}

	// Token: 0x04012CEF RID: 77039
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache0;

	// Token: 0x04012CF0 RID: 77040
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1;

	// Token: 0x04012CF1 RID: 77041
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2;

	// Token: 0x04012CF2 RID: 77042
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3;

	// Token: 0x04012CF3 RID: 77043
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache4;

	// Token: 0x04012CF4 RID: 77044
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache5;

	// Token: 0x04012CF5 RID: 77045
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache6;

	// Token: 0x04012CF6 RID: 77046
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache7;

	// Token: 0x04012CF7 RID: 77047
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache8;

	// Token: 0x04012CF8 RID: 77048
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache9;

	// Token: 0x04012CF9 RID: 77049
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheA;

	// Token: 0x04012CFA RID: 77050
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheB;

	// Token: 0x04012CFB RID: 77051
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheC;

	// Token: 0x04012CFC RID: 77052
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheD;

	// Token: 0x04012CFD RID: 77053
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheE;

	// Token: 0x04012CFE RID: 77054
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheF;

	// Token: 0x04012CFF RID: 77055
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache10;

	// Token: 0x04012D00 RID: 77056
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache11;

	// Token: 0x04012D01 RID: 77057
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache12;

	// Token: 0x04012D02 RID: 77058
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache13;

	// Token: 0x04012D03 RID: 77059
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache14;

	// Token: 0x04012D04 RID: 77060
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache15;

	// Token: 0x04012D05 RID: 77061
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache16;

	// Token: 0x04012D06 RID: 77062
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache17;

	// Token: 0x04012D07 RID: 77063
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache18;

	// Token: 0x04012D08 RID: 77064
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache19;

	// Token: 0x04012D09 RID: 77065
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1A;

	// Token: 0x04012D0A RID: 77066
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1B;

	// Token: 0x04012D0B RID: 77067
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1C;

	// Token: 0x04012D0C RID: 77068
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1D;

	// Token: 0x04012D0D RID: 77069
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1E;

	// Token: 0x04012D0E RID: 77070
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1F;

	// Token: 0x04012D0F RID: 77071
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache20;

	// Token: 0x04012D10 RID: 77072
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache21;

	// Token: 0x04012D11 RID: 77073
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache22;

	// Token: 0x04012D12 RID: 77074
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache23;

	// Token: 0x04012D13 RID: 77075
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache24;

	// Token: 0x04012D14 RID: 77076
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache25;

	// Token: 0x04012D15 RID: 77077
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache26;

	// Token: 0x04012D16 RID: 77078
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache27;

	// Token: 0x04012D17 RID: 77079
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache28;

	// Token: 0x04012D18 RID: 77080
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache29;

	// Token: 0x04012D19 RID: 77081
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2A;

	// Token: 0x04012D1A RID: 77082
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2B;

	// Token: 0x04012D1B RID: 77083
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2C;

	// Token: 0x04012D1C RID: 77084
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2D;

	// Token: 0x04012D1D RID: 77085
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2E;

	// Token: 0x04012D1E RID: 77086
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2F;

	// Token: 0x04012D1F RID: 77087
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache30;

	// Token: 0x04012D20 RID: 77088
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache31;

	// Token: 0x04012D21 RID: 77089
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache32;

	// Token: 0x04012D22 RID: 77090
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache33;

	// Token: 0x04012D23 RID: 77091
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache34;
}
