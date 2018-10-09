using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using BlackJack.BJFramework.Runtime.TaskNs;
using BlackJack.BJFramework.Runtime.UI;
using BlackJack.ConfigData;
using BlackJack.ProjectL.Common;
using BlackJack.ProjectL.PlayerContext;
using BlackJack.ProjectL.UI;
using SLua;
using UnityEngine.Scripting;

// Token: 0x020013B5 RID: 5045
[Preserve]
public class Lua_BlackJack_ProjectL_UI_BattleResultUITask : LuaObject
{
	// Token: 0x0601BE98 RID: 114328 RVA: 0x0088ECC0 File Offset: 0x0088CEC0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int constructor(IntPtr l)
	{
		int result;
		try
		{
			string name;
			LuaObject.checkType(l, 2, out name);
			BattleResultUITask o = new BattleResultUITask(name);
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

	// Token: 0x0601BE99 RID: 114329 RVA: 0x0088ED14 File Offset: 0x0088CF14
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int StartUITask_s(IntPtr l)
	{
		int result;
		try
		{
			BattleType battleType;
			LuaObject.checkEnum<BattleType>(l, 1, out battleType);
			List<int> heroIds;
			LuaObject.checkType<List<int>>(l, 2, out heroIds);
			int stars;
			LuaObject.checkType(l, 3, out stars);
			int starTurnMax;
			LuaObject.checkType(l, 4, out starTurnMax);
			int starDeadMax;
			LuaObject.checkType(l, 5, out starDeadMax);
			int turn;
			LuaObject.checkType(l, 6, out turn);
			BattleReward battleReward;
			LuaObject.checkType<BattleReward>(l, 7, out battleReward);
			bool isFirstWin;
			LuaObject.checkType(l, 8, out isFirstWin);
			List<int> gotAchievements;
			LuaObject.checkType<List<int>>(l, 9, out gotAchievements);
			BattleLevelAchievement[] achievements;
			LuaObject.checkArray<BattleLevelAchievement>(l, 10, out achievements);
			BattleResultUITask o = BattleResultUITask.StartUITask(battleType, heroIds, stars, starTurnMax, starDeadMax, turn, battleReward, isFirstWin, gotAchievements, achievements);
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

	// Token: 0x0601BE9A RID: 114330 RVA: 0x0088EDD8 File Offset: 0x0088CFD8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int OnStart(IntPtr l)
	{
		int result;
		try
		{
			BattleResultUITask battleResultUITask = (BattleResultUITask)LuaObject.checkSelf(l);
			UIIntent intent;
			LuaObject.checkType<UIIntent>(l, 2, out intent);
			bool b = battleResultUITask.m_luaExportHelper.OnStart(intent);
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

	// Token: 0x0601BE9B RID: 114331 RVA: 0x0088EE40 File Offset: 0x0088D040
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int OnResume(IntPtr l)
	{
		int result;
		try
		{
			BattleResultUITask battleResultUITask = (BattleResultUITask)LuaObject.checkSelf(l);
			UIIntent intent;
			LuaObject.checkType<UIIntent>(l, 2, out intent);
			bool b = battleResultUITask.m_luaExportHelper.OnResume(intent);
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

	// Token: 0x0601BE9C RID: 114332 RVA: 0x0088EEA8 File Offset: 0x0088D0A8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int InitDataFromUIIntent(IntPtr l)
	{
		int result;
		try
		{
			BattleResultUITask battleResultUITask = (BattleResultUITask)LuaObject.checkSelf(l);
			UIIntent intent;
			LuaObject.checkType<UIIntent>(l, 2, out intent);
			battleResultUITask.m_luaExportHelper.InitDataFromUIIntent(intent);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601BE9D RID: 114333 RVA: 0x0088EF04 File Offset: 0x0088D104
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int IsNeedLoadDynamicRes(IntPtr l)
	{
		int result;
		try
		{
			BattleResultUITask battleResultUITask = (BattleResultUITask)LuaObject.checkSelf(l);
			bool b = battleResultUITask.m_luaExportHelper.IsNeedLoadDynamicRes();
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

	// Token: 0x0601BE9E RID: 114334 RVA: 0x0088EF60 File Offset: 0x0088D160
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int InitAllUIControllers(IntPtr l)
	{
		int result;
		try
		{
			BattleResultUITask battleResultUITask = (BattleResultUITask)LuaObject.checkSelf(l);
			battleResultUITask.m_luaExportHelper.InitAllUIControllers();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601BE9F RID: 114335 RVA: 0x0088EFB4 File Offset: 0x0088D1B4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int ClearAllContextAndRes(IntPtr l)
	{
		int result;
		try
		{
			BattleResultUITask battleResultUITask = (BattleResultUITask)LuaObject.checkSelf(l);
			battleResultUITask.m_luaExportHelper.ClearAllContextAndRes();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601BEA0 RID: 114336 RVA: 0x0088F008 File Offset: 0x0088D208
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int UpdateView(IntPtr l)
	{
		int result;
		try
		{
			BattleResultUITask battleResultUITask = (BattleResultUITask)LuaObject.checkSelf(l);
			battleResultUITask.m_luaExportHelper.UpdateView();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601BEA1 RID: 114337 RVA: 0x0088F05C File Offset: 0x0088D25C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int BattleResultUIController_OnClose(IntPtr l)
	{
		int result;
		try
		{
			BattleResultUITask battleResultUITask = (BattleResultUITask)LuaObject.checkSelf(l);
			battleResultUITask.m_luaExportHelper.BattleResultUIController_OnClose();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601BEA2 RID: 114338 RVA: 0x0088F0B0 File Offset: 0x0088D2B0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int StartChestUITask(IntPtr l)
	{
		int result;
		try
		{
			BattleResultUITask battleResultUITask = (BattleResultUITask)LuaObject.checkSelf(l);
			battleResultUITask.m_luaExportHelper.StartChestUITask();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601BEA3 RID: 114339 RVA: 0x0088F104 File Offset: 0x0088D304
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int ChestUITask_OnStop(IntPtr l)
	{
		int result;
		try
		{
			BattleResultUITask battleResultUITask = (BattleResultUITask)LuaObject.checkSelf(l);
			Task task;
			LuaObject.checkType<Task>(l, 2, out task);
			battleResultUITask.m_luaExportHelper.ChestUITask_OnStop(task);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601BEA4 RID: 114340 RVA: 0x0088F160 File Offset: 0x0088D360
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int ChestUITask_OnClose(IntPtr l)
	{
		int result;
		try
		{
			BattleResultUITask battleResultUITask = (BattleResultUITask)LuaObject.checkSelf(l);
			battleResultUITask.m_luaExportHelper.ChestUITask_OnClose();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601BEA5 RID: 114341 RVA: 0x0088F1B4 File Offset: 0x0088D3B4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int StartBattleResultScoreUITask(IntPtr l)
	{
		int result;
		try
		{
			BattleResultUITask battleResultUITask = (BattleResultUITask)LuaObject.checkSelf(l);
			battleResultUITask.m_luaExportHelper.StartBattleResultScoreUITask();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601BEA6 RID: 114342 RVA: 0x0088F208 File Offset: 0x0088D408
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int BattleResultScoreUITask_OnStop(IntPtr l)
	{
		int result;
		try
		{
			BattleResultUITask battleResultUITask = (BattleResultUITask)LuaObject.checkSelf(l);
			Task task;
			LuaObject.checkType<Task>(l, 2, out task);
			battleResultUITask.m_luaExportHelper.BattleResultScoreUITask_OnStop(task);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601BEA7 RID: 114343 RVA: 0x0088F264 File Offset: 0x0088D464
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int BattleResultScoreUITask_OnClose(IntPtr l)
	{
		int result;
		try
		{
			BattleResultUITask battleResultUITask = (BattleResultUITask)LuaObject.checkSelf(l);
			battleResultUITask.m_luaExportHelper.BattleResultScoreUITask_OnClose();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601BEA8 RID: 114344 RVA: 0x0088F2B8 File Offset: 0x0088D4B8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_OnStart(IntPtr l)
	{
		int result;
		try
		{
			BattleResultUITask battleResultUITask = (BattleResultUITask)LuaObject.checkSelf(l);
			UIIntent intent;
			LuaObject.checkType<UIIntent>(l, 2, out intent);
			bool b = battleResultUITask.m_luaExportHelper.__callBase_OnStart(intent);
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

	// Token: 0x0601BEA9 RID: 114345 RVA: 0x0088F320 File Offset: 0x0088D520
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int __callBase_OnStop(IntPtr l)
	{
		int result;
		try
		{
			BattleResultUITask battleResultUITask = (BattleResultUITask)LuaObject.checkSelf(l);
			battleResultUITask.m_luaExportHelper.__callBase_OnStop();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601BEAA RID: 114346 RVA: 0x0088F374 File Offset: 0x0088D574
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_OnPause(IntPtr l)
	{
		int result;
		try
		{
			BattleResultUITask battleResultUITask = (BattleResultUITask)LuaObject.checkSelf(l);
			battleResultUITask.m_luaExportHelper.__callBase_OnPause();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601BEAB RID: 114347 RVA: 0x0088F3C8 File Offset: 0x0088D5C8
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int __callBase_OnResume(IntPtr l)
	{
		int result;
		try
		{
			BattleResultUITask battleResultUITask = (BattleResultUITask)LuaObject.checkSelf(l);
			UIIntent intent;
			LuaObject.checkType<UIIntent>(l, 2, out intent);
			bool b = battleResultUITask.m_luaExportHelper.__callBase_OnResume(intent);
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

	// Token: 0x0601BEAC RID: 114348 RVA: 0x0088F430 File Offset: 0x0088D630
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int __callBase_OnNewIntent(IntPtr l)
	{
		int result;
		try
		{
			BattleResultUITask battleResultUITask = (BattleResultUITask)LuaObject.checkSelf(l);
			UIIntent intent;
			LuaObject.checkType<UIIntent>(l, 2, out intent);
			bool b = battleResultUITask.m_luaExportHelper.__callBase_OnNewIntent(intent);
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

	// Token: 0x0601BEAD RID: 114349 RVA: 0x0088F498 File Offset: 0x0088D698
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int __callBase_EnableUIInput(IntPtr l)
	{
		int result;
		try
		{
			BattleResultUITask battleResultUITask = (BattleResultUITask)LuaObject.checkSelf(l);
			bool isEnable;
			LuaObject.checkType(l, 2, out isEnable);
			bool? isGlobalEnable;
			LuaObject.checkNullable<bool>(l, 3, out isGlobalEnable);
			battleResultUITask.m_luaExportHelper.__callBase_EnableUIInput(isEnable, isGlobalEnable);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601BEAE RID: 114350 RVA: 0x0088F504 File Offset: 0x0088D704
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_IsNeedLoadDynamicRes(IntPtr l)
	{
		int result;
		try
		{
			BattleResultUITask battleResultUITask = (BattleResultUITask)LuaObject.checkSelf(l);
			bool b = battleResultUITask.m_luaExportHelper.__callBase_IsNeedLoadDynamicRes();
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

	// Token: 0x0601BEAF RID: 114351 RVA: 0x0088F560 File Offset: 0x0088D760
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_CollectAllDynamicResForLoad(IntPtr l)
	{
		int result;
		try
		{
			BattleResultUITask battleResultUITask = (BattleResultUITask)LuaObject.checkSelf(l);
			List<string> o = battleResultUITask.m_luaExportHelper.__callBase_CollectAllDynamicResForLoad();
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

	// Token: 0x0601BEB0 RID: 114352 RVA: 0x0088F5BC File Offset: 0x0088D7BC
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int __callBase_RegisterPlayerContextEvents(IntPtr l)
	{
		int result;
		try
		{
			BattleResultUITask battleResultUITask = (BattleResultUITask)LuaObject.checkSelf(l);
			battleResultUITask.m_luaExportHelper.__callBase_RegisterPlayerContextEvents();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601BEB1 RID: 114353 RVA: 0x0088F610 File Offset: 0x0088D810
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_UnregisterPlayerContextEvents(IntPtr l)
	{
		int result;
		try
		{
			BattleResultUITask battleResultUITask = (BattleResultUITask)LuaObject.checkSelf(l);
			battleResultUITask.m_luaExportHelper.__callBase_UnregisterPlayerContextEvents();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601BEB2 RID: 114354 RVA: 0x0088F664 File Offset: 0x0088D864
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_PostUpdateView(IntPtr l)
	{
		int result;
		try
		{
			BattleResultUITask battleResultUITask = (BattleResultUITask)LuaObject.checkSelf(l);
			battleResultUITask.m_luaExportHelper.__callBase_PostUpdateView();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601BEB3 RID: 114355 RVA: 0x0088F6B8 File Offset: 0x0088D8B8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_CollectPreloadResourceList(IntPtr l)
	{
		int result;
		try
		{
			BattleResultUITask battleResultUITask = (BattleResultUITask)LuaObject.checkSelf(l);
			battleResultUITask.m_luaExportHelper.__callBase_CollectPreloadResourceList();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601BEB4 RID: 114356 RVA: 0x0088F70C File Offset: 0x0088D90C
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int __callBase_ClearAssetList(IntPtr l)
	{
		int result;
		try
		{
			BattleResultUITask battleResultUITask = (BattleResultUITask)LuaObject.checkSelf(l);
			battleResultUITask.m_luaExportHelper.__callBase_ClearAssetList();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601BEB5 RID: 114357 RVA: 0x0088F760 File Offset: 0x0088D960
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_CollectAsset(IntPtr l)
	{
		int result;
		try
		{
			BattleResultUITask battleResultUITask = (BattleResultUITask)LuaObject.checkSelf(l);
			string assetName;
			LuaObject.checkType(l, 2, out assetName);
			battleResultUITask.m_luaExportHelper.__callBase_CollectAsset(assetName);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601BEB6 RID: 114358 RVA: 0x0088F7BC File Offset: 0x0088D9BC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_CollectSpriteAsset(IntPtr l)
	{
		int result;
		try
		{
			BattleResultUITask battleResultUITask = (BattleResultUITask)LuaObject.checkSelf(l);
			string assetName;
			LuaObject.checkType(l, 2, out assetName);
			battleResultUITask.m_luaExportHelper.__callBase_CollectSpriteAsset(assetName);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601BEB7 RID: 114359 RVA: 0x0088F818 File Offset: 0x0088DA18
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_CollectFxAsset(IntPtr l)
	{
		int result;
		try
		{
			BattleResultUITask battleResultUITask = (BattleResultUITask)LuaObject.checkSelf(l);
			string assetName;
			LuaObject.checkType(l, 2, out assetName);
			battleResultUITask.m_luaExportHelper.__callBase_CollectFxAsset(assetName);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601BEB8 RID: 114360 RVA: 0x0088F874 File Offset: 0x0088DA74
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_StartLoadCustomAssets(IntPtr l)
	{
		int result;
		try
		{
			BattleResultUITask battleResultUITask = (BattleResultUITask)LuaObject.checkSelf(l);
			Action onLoadCompleted;
			LuaObject.checkDelegate<Action>(l, 2, out onLoadCompleted);
			battleResultUITask.m_luaExportHelper.__callBase_StartLoadCustomAssets(onLoadCompleted);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601BEB9 RID: 114361 RVA: 0x0088F8D0 File Offset: 0x0088DAD0
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int __callBase_IsLoadingCustomAssets(IntPtr l)
	{
		int result;
		try
		{
			BattleResultUITask battleResultUITask = (BattleResultUITask)LuaObject.checkSelf(l);
			bool b = battleResultUITask.m_luaExportHelper.__callBase_IsLoadingCustomAssets();
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

	// Token: 0x0601BEBA RID: 114362 RVA: 0x0088F92C File Offset: 0x0088DB2C
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int __callBase_IsPipeLineRunning(IntPtr l)
	{
		int result;
		try
		{
			BattleResultUITask battleResultUITask = (BattleResultUITask)LuaObject.checkSelf(l);
			bool b = battleResultUITask.m_luaExportHelper.__callBase_IsPipeLineRunning();
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

	// Token: 0x0601BEBB RID: 114363 RVA: 0x0088F988 File Offset: 0x0088DB88
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int __callBase_IsOpeningUI(IntPtr l)
	{
		int result;
		try
		{
			BattleResultUITask battleResultUITask = (BattleResultUITask)LuaObject.checkSelf(l);
			bool b = battleResultUITask.m_luaExportHelper.__callBase_IsOpeningUI();
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

	// Token: 0x0601BEBC RID: 114364 RVA: 0x0088F9E4 File Offset: 0x0088DBE4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_ReturnPrevUITask(IntPtr l)
	{
		int result;
		try
		{
			BattleResultUITask battleResultUITask = (BattleResultUITask)LuaObject.checkSelf(l);
			UITaskBase o = battleResultUITask.m_luaExportHelper.__callBase_ReturnPrevUITask();
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

	// Token: 0x0601BEBD RID: 114365 RVA: 0x0088FA40 File Offset: 0x0088DC40
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int __callBase_ClearUnusedDynamicResourceCache(IntPtr l)
	{
		int result;
		try
		{
			BattleResultUITask battleResultUITask = (BattleResultUITask)LuaObject.checkSelf(l);
			battleResultUITask.m_luaExportHelper.__callBase_ClearUnusedDynamicResourceCache();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601BEBE RID: 114366 RVA: 0x0088FA94 File Offset: 0x0088DC94
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_OnMemoryWarning(IntPtr l)
	{
		int result;
		try
		{
			BattleResultUITask battleResultUITask = (BattleResultUITask)LuaObject.checkSelf(l);
			battleResultUITask.m_luaExportHelper.__callBase_OnMemoryWarning();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601BEBF RID: 114367 RVA: 0x0088FAE8 File Offset: 0x0088DCE8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callDele_EventOnClose(IntPtr l)
	{
		int result;
		try
		{
			BattleResultUITask battleResultUITask = (BattleResultUITask)LuaObject.checkSelf(l);
			battleResultUITask.m_luaExportHelper.__callDele_EventOnClose();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601BEC0 RID: 114368 RVA: 0x0088FB3C File Offset: 0x0088DD3C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __clearDele_EventOnClose(IntPtr l)
	{
		int result;
		try
		{
			BattleResultUITask battleResultUITask = (BattleResultUITask)LuaObject.checkSelf(l);
			battleResultUITask.m_luaExportHelper.__clearDele_EventOnClose();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601BEC1 RID: 114369 RVA: 0x0088FB90 File Offset: 0x0088DD90
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_EventOnClose(IntPtr l)
	{
		int result;
		try
		{
			BattleResultUITask battleResultUITask = (BattleResultUITask)LuaObject.checkSelf(l);
			Action value;
			int num = LuaObject.checkDelegate<Action>(l, 2, out value);
			if (num != 0)
			{
				if (num == 1)
				{
					battleResultUITask.EventOnClose += value;
				}
				else if (num == 2)
				{
					battleResultUITask.EventOnClose -= value;
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

	// Token: 0x0601BEC2 RID: 114370 RVA: 0x0088FC10 File Offset: 0x0088DE10
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_m_layerDescArray(IntPtr l)
	{
		int result;
		try
		{
			BattleResultUITask battleResultUITask = (BattleResultUITask)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, battleResultUITask.m_luaExportHelper.m_layerDescArray);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601BEC3 RID: 114371 RVA: 0x0088FC68 File Offset: 0x0088DE68
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_m_layerDescArray(IntPtr l)
	{
		int result;
		try
		{
			BattleResultUITask battleResultUITask = (BattleResultUITask)LuaObject.checkSelf(l);
			UITaskBase.LayerDesc[] layerDescArray;
			LuaObject.checkArray<UITaskBase.LayerDesc>(l, 2, out layerDescArray);
			battleResultUITask.m_luaExportHelper.m_layerDescArray = layerDescArray;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601BEC4 RID: 114372 RVA: 0x0088FCC4 File Offset: 0x0088DEC4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_uiCtrlDescArray(IntPtr l)
	{
		int result;
		try
		{
			BattleResultUITask battleResultUITask = (BattleResultUITask)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, battleResultUITask.m_luaExportHelper.m_uiCtrlDescArray);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601BEC5 RID: 114373 RVA: 0x0088FD1C File Offset: 0x0088DF1C
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_m_uiCtrlDescArray(IntPtr l)
	{
		int result;
		try
		{
			BattleResultUITask battleResultUITask = (BattleResultUITask)LuaObject.checkSelf(l);
			UITaskBase.UIControllerDesc[] uiCtrlDescArray;
			LuaObject.checkArray<UITaskBase.UIControllerDesc>(l, 2, out uiCtrlDescArray);
			battleResultUITask.m_luaExportHelper.m_uiCtrlDescArray = uiCtrlDescArray;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601BEC6 RID: 114374 RVA: 0x0088FD78 File Offset: 0x0088DF78
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_m_battleResultUIController(IntPtr l)
	{
		int result;
		try
		{
			BattleResultUITask battleResultUITask = (BattleResultUITask)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, battleResultUITask.m_luaExportHelper.m_battleResultUIController);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601BEC7 RID: 114375 RVA: 0x0088FDD0 File Offset: 0x0088DFD0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_battleResultUIController(IntPtr l)
	{
		int result;
		try
		{
			BattleResultUITask battleResultUITask = (BattleResultUITask)LuaObject.checkSelf(l);
			BattleResultUIController battleResultUIController;
			LuaObject.checkType<BattleResultUIController>(l, 2, out battleResultUIController);
			battleResultUITask.m_luaExportHelper.m_battleResultUIController = battleResultUIController;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601BEC8 RID: 114376 RVA: 0x0088FE2C File Offset: 0x0088E02C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_battleType(IntPtr l)
	{
		int result;
		try
		{
			BattleResultUITask battleResultUITask = (BattleResultUITask)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushEnum(l, (int)battleResultUITask.m_luaExportHelper.m_battleType);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601BEC9 RID: 114377 RVA: 0x0088FE84 File Offset: 0x0088E084
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_m_battleType(IntPtr l)
	{
		int result;
		try
		{
			BattleResultUITask battleResultUITask = (BattleResultUITask)LuaObject.checkSelf(l);
			BattleType battleType;
			LuaObject.checkEnum<BattleType>(l, 2, out battleType);
			battleResultUITask.m_luaExportHelper.m_battleType = battleType;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601BECA RID: 114378 RVA: 0x0088FEE0 File Offset: 0x0088E0E0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_heros(IntPtr l)
	{
		int result;
		try
		{
			BattleResultUITask battleResultUITask = (BattleResultUITask)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, battleResultUITask.m_luaExportHelper.m_heros);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601BECB RID: 114379 RVA: 0x0088FF38 File Offset: 0x0088E138
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_heros(IntPtr l)
	{
		int result;
		try
		{
			BattleResultUITask battleResultUITask = (BattleResultUITask)LuaObject.checkSelf(l);
			List<Hero> heros;
			LuaObject.checkType<List<Hero>>(l, 2, out heros);
			battleResultUITask.m_luaExportHelper.m_heros = heros;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601BECC RID: 114380 RVA: 0x0088FF94 File Offset: 0x0088E194
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_stars(IntPtr l)
	{
		int result;
		try
		{
			BattleResultUITask battleResultUITask = (BattleResultUITask)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, battleResultUITask.m_luaExportHelper.m_stars);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601BECD RID: 114381 RVA: 0x0088FFEC File Offset: 0x0088E1EC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_stars(IntPtr l)
	{
		int result;
		try
		{
			BattleResultUITask battleResultUITask = (BattleResultUITask)LuaObject.checkSelf(l);
			int stars;
			LuaObject.checkType(l, 2, out stars);
			battleResultUITask.m_luaExportHelper.m_stars = stars;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601BECE RID: 114382 RVA: 0x00890048 File Offset: 0x0088E248
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_m_starTurnMax(IntPtr l)
	{
		int result;
		try
		{
			BattleResultUITask battleResultUITask = (BattleResultUITask)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, battleResultUITask.m_luaExportHelper.m_starTurnMax);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601BECF RID: 114383 RVA: 0x008900A0 File Offset: 0x0088E2A0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_starTurnMax(IntPtr l)
	{
		int result;
		try
		{
			BattleResultUITask battleResultUITask = (BattleResultUITask)LuaObject.checkSelf(l);
			int starTurnMax;
			LuaObject.checkType(l, 2, out starTurnMax);
			battleResultUITask.m_luaExportHelper.m_starTurnMax = starTurnMax;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601BED0 RID: 114384 RVA: 0x008900FC File Offset: 0x0088E2FC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_starDeadMax(IntPtr l)
	{
		int result;
		try
		{
			BattleResultUITask battleResultUITask = (BattleResultUITask)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, battleResultUITask.m_luaExportHelper.m_starDeadMax);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601BED1 RID: 114385 RVA: 0x00890154 File Offset: 0x0088E354
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_starDeadMax(IntPtr l)
	{
		int result;
		try
		{
			BattleResultUITask battleResultUITask = (BattleResultUITask)LuaObject.checkSelf(l);
			int starDeadMax;
			LuaObject.checkType(l, 2, out starDeadMax);
			battleResultUITask.m_luaExportHelper.m_starDeadMax = starDeadMax;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601BED2 RID: 114386 RVA: 0x008901B0 File Offset: 0x0088E3B0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_turn(IntPtr l)
	{
		int result;
		try
		{
			BattleResultUITask battleResultUITask = (BattleResultUITask)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, battleResultUITask.m_luaExportHelper.m_turn);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601BED3 RID: 114387 RVA: 0x00890208 File Offset: 0x0088E408
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_turn(IntPtr l)
	{
		int result;
		try
		{
			BattleResultUITask battleResultUITask = (BattleResultUITask)LuaObject.checkSelf(l);
			int turn;
			LuaObject.checkType(l, 2, out turn);
			battleResultUITask.m_luaExportHelper.m_turn = turn;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601BED4 RID: 114388 RVA: 0x00890264 File Offset: 0x0088E464
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_m_battleReward(IntPtr l)
	{
		int result;
		try
		{
			BattleResultUITask battleResultUITask = (BattleResultUITask)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, battleResultUITask.m_luaExportHelper.m_battleReward);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601BED5 RID: 114389 RVA: 0x008902BC File Offset: 0x0088E4BC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_battleReward(IntPtr l)
	{
		int result;
		try
		{
			BattleResultUITask battleResultUITask = (BattleResultUITask)LuaObject.checkSelf(l);
			BattleReward battleReward;
			LuaObject.checkType<BattleReward>(l, 2, out battleReward);
			battleResultUITask.m_luaExportHelper.m_battleReward = battleReward;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601BED6 RID: 114390 RVA: 0x00890318 File Offset: 0x0088E518
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_isFirstWin(IntPtr l)
	{
		int result;
		try
		{
			BattleResultUITask battleResultUITask = (BattleResultUITask)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, battleResultUITask.m_luaExportHelper.m_isFirstWin);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601BED7 RID: 114391 RVA: 0x00890370 File Offset: 0x0088E570
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_isFirstWin(IntPtr l)
	{
		int result;
		try
		{
			BattleResultUITask battleResultUITask = (BattleResultUITask)LuaObject.checkSelf(l);
			bool isFirstWin;
			LuaObject.checkType(l, 2, out isFirstWin);
			battleResultUITask.m_luaExportHelper.m_isFirstWin = isFirstWin;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601BED8 RID: 114392 RVA: 0x008903CC File Offset: 0x0088E5CC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_gotAchievements(IntPtr l)
	{
		int result;
		try
		{
			BattleResultUITask battleResultUITask = (BattleResultUITask)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, battleResultUITask.m_luaExportHelper.m_gotAchievements);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601BED9 RID: 114393 RVA: 0x00890424 File Offset: 0x0088E624
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_gotAchievements(IntPtr l)
	{
		int result;
		try
		{
			BattleResultUITask battleResultUITask = (BattleResultUITask)LuaObject.checkSelf(l);
			List<int> gotAchievements;
			LuaObject.checkType<List<int>>(l, 2, out gotAchievements);
			battleResultUITask.m_luaExportHelper.m_gotAchievements = gotAchievements;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601BEDA RID: 114394 RVA: 0x00890480 File Offset: 0x0088E680
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_m_achievements(IntPtr l)
	{
		int result;
		try
		{
			BattleResultUITask battleResultUITask = (BattleResultUITask)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, battleResultUITask.m_luaExportHelper.m_achievements);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601BEDB RID: 114395 RVA: 0x008904D8 File Offset: 0x0088E6D8
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_m_achievements(IntPtr l)
	{
		int result;
		try
		{
			BattleResultUITask battleResultUITask = (BattleResultUITask)LuaObject.checkSelf(l);
			BattleLevelAchievement[] achievements;
			LuaObject.checkArray<BattleLevelAchievement>(l, 2, out achievements);
			battleResultUITask.m_luaExportHelper.m_achievements = achievements;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601BEDC RID: 114396 RVA: 0x00890534 File Offset: 0x0088E734
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_chestUITask(IntPtr l)
	{
		int result;
		try
		{
			BattleResultUITask battleResultUITask = (BattleResultUITask)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, battleResultUITask.m_luaExportHelper.m_chestUITask);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601BEDD RID: 114397 RVA: 0x0089058C File Offset: 0x0088E78C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_chestUITask(IntPtr l)
	{
		int result;
		try
		{
			BattleResultUITask battleResultUITask = (BattleResultUITask)LuaObject.checkSelf(l);
			ChestUITask chestUITask;
			LuaObject.checkType<ChestUITask>(l, 2, out chestUITask);
			battleResultUITask.m_luaExportHelper.m_chestUITask = chestUITask;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601BEDE RID: 114398 RVA: 0x008905E8 File Offset: 0x0088E7E8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_battleResultScoreUITask(IntPtr l)
	{
		int result;
		try
		{
			BattleResultUITask battleResultUITask = (BattleResultUITask)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, battleResultUITask.m_luaExportHelper.m_battleResultScoreUITask);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601BEDF RID: 114399 RVA: 0x00890640 File Offset: 0x0088E840
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_battleResultScoreUITask(IntPtr l)
	{
		int result;
		try
		{
			BattleResultUITask battleResultUITask = (BattleResultUITask)LuaObject.checkSelf(l);
			BattleResultScoreUITask battleResultScoreUITask;
			LuaObject.checkType<BattleResultScoreUITask>(l, 2, out battleResultScoreUITask);
			battleResultUITask.m_luaExportHelper.m_battleResultScoreUITask = battleResultScoreUITask;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601BEE0 RID: 114400 RVA: 0x0089069C File Offset: 0x0088E89C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_LayerDescArray(IntPtr l)
	{
		int result;
		try
		{
			BattleResultUITask battleResultUITask = (BattleResultUITask)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, battleResultUITask.m_luaExportHelper.LayerDescArray);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601BEE1 RID: 114401 RVA: 0x008906F4 File Offset: 0x0088E8F4
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_UICtrlDescArray(IntPtr l)
	{
		int result;
		try
		{
			BattleResultUITask battleResultUITask = (BattleResultUITask)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, battleResultUITask.m_luaExportHelper.UICtrlDescArray);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601BEE2 RID: 114402 RVA: 0x0089074C File Offset: 0x0088E94C
	[Preserve]
	public static void reg(IntPtr l)
	{
		LuaObject.getTypeTable(l, "BlackJack.ProjectL.UI.BattleResultUITask");
		if (Lua_BlackJack_ProjectL_UI_BattleResultUITask.<>f__mg$cache0 == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleResultUITask.<>f__mg$cache0 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleResultUITask.StartUITask_s);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_BattleResultUITask.<>f__mg$cache0);
		if (Lua_BlackJack_ProjectL_UI_BattleResultUITask.<>f__mg$cache1 == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleResultUITask.<>f__mg$cache1 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleResultUITask.OnStart);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_BattleResultUITask.<>f__mg$cache1);
		if (Lua_BlackJack_ProjectL_UI_BattleResultUITask.<>f__mg$cache2 == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleResultUITask.<>f__mg$cache2 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleResultUITask.OnResume);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_BattleResultUITask.<>f__mg$cache2);
		if (Lua_BlackJack_ProjectL_UI_BattleResultUITask.<>f__mg$cache3 == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleResultUITask.<>f__mg$cache3 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleResultUITask.InitDataFromUIIntent);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_BattleResultUITask.<>f__mg$cache3);
		if (Lua_BlackJack_ProjectL_UI_BattleResultUITask.<>f__mg$cache4 == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleResultUITask.<>f__mg$cache4 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleResultUITask.IsNeedLoadDynamicRes);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_BattleResultUITask.<>f__mg$cache4);
		if (Lua_BlackJack_ProjectL_UI_BattleResultUITask.<>f__mg$cache5 == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleResultUITask.<>f__mg$cache5 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleResultUITask.InitAllUIControllers);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_BattleResultUITask.<>f__mg$cache5);
		if (Lua_BlackJack_ProjectL_UI_BattleResultUITask.<>f__mg$cache6 == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleResultUITask.<>f__mg$cache6 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleResultUITask.ClearAllContextAndRes);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_BattleResultUITask.<>f__mg$cache6);
		if (Lua_BlackJack_ProjectL_UI_BattleResultUITask.<>f__mg$cache7 == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleResultUITask.<>f__mg$cache7 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleResultUITask.UpdateView);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_BattleResultUITask.<>f__mg$cache7);
		if (Lua_BlackJack_ProjectL_UI_BattleResultUITask.<>f__mg$cache8 == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleResultUITask.<>f__mg$cache8 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleResultUITask.BattleResultUIController_OnClose);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_BattleResultUITask.<>f__mg$cache8);
		if (Lua_BlackJack_ProjectL_UI_BattleResultUITask.<>f__mg$cache9 == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleResultUITask.<>f__mg$cache9 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleResultUITask.StartChestUITask);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_BattleResultUITask.<>f__mg$cache9);
		if (Lua_BlackJack_ProjectL_UI_BattleResultUITask.<>f__mg$cacheA == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleResultUITask.<>f__mg$cacheA = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleResultUITask.ChestUITask_OnStop);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_BattleResultUITask.<>f__mg$cacheA);
		if (Lua_BlackJack_ProjectL_UI_BattleResultUITask.<>f__mg$cacheB == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleResultUITask.<>f__mg$cacheB = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleResultUITask.ChestUITask_OnClose);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_BattleResultUITask.<>f__mg$cacheB);
		if (Lua_BlackJack_ProjectL_UI_BattleResultUITask.<>f__mg$cacheC == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleResultUITask.<>f__mg$cacheC = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleResultUITask.StartBattleResultScoreUITask);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_BattleResultUITask.<>f__mg$cacheC);
		if (Lua_BlackJack_ProjectL_UI_BattleResultUITask.<>f__mg$cacheD == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleResultUITask.<>f__mg$cacheD = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleResultUITask.BattleResultScoreUITask_OnStop);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_BattleResultUITask.<>f__mg$cacheD);
		if (Lua_BlackJack_ProjectL_UI_BattleResultUITask.<>f__mg$cacheE == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleResultUITask.<>f__mg$cacheE = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleResultUITask.BattleResultScoreUITask_OnClose);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_BattleResultUITask.<>f__mg$cacheE);
		if (Lua_BlackJack_ProjectL_UI_BattleResultUITask.<>f__mg$cacheF == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleResultUITask.<>f__mg$cacheF = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleResultUITask.__callBase_OnStart);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_BattleResultUITask.<>f__mg$cacheF);
		if (Lua_BlackJack_ProjectL_UI_BattleResultUITask.<>f__mg$cache10 == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleResultUITask.<>f__mg$cache10 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleResultUITask.__callBase_OnStop);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_BattleResultUITask.<>f__mg$cache10);
		if (Lua_BlackJack_ProjectL_UI_BattleResultUITask.<>f__mg$cache11 == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleResultUITask.<>f__mg$cache11 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleResultUITask.__callBase_OnPause);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_BattleResultUITask.<>f__mg$cache11);
		if (Lua_BlackJack_ProjectL_UI_BattleResultUITask.<>f__mg$cache12 == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleResultUITask.<>f__mg$cache12 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleResultUITask.__callBase_OnResume);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_BattleResultUITask.<>f__mg$cache12);
		if (Lua_BlackJack_ProjectL_UI_BattleResultUITask.<>f__mg$cache13 == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleResultUITask.<>f__mg$cache13 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleResultUITask.__callBase_OnNewIntent);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_BattleResultUITask.<>f__mg$cache13);
		if (Lua_BlackJack_ProjectL_UI_BattleResultUITask.<>f__mg$cache14 == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleResultUITask.<>f__mg$cache14 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleResultUITask.__callBase_EnableUIInput);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_BattleResultUITask.<>f__mg$cache14);
		if (Lua_BlackJack_ProjectL_UI_BattleResultUITask.<>f__mg$cache15 == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleResultUITask.<>f__mg$cache15 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleResultUITask.__callBase_IsNeedLoadDynamicRes);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_BattleResultUITask.<>f__mg$cache15);
		if (Lua_BlackJack_ProjectL_UI_BattleResultUITask.<>f__mg$cache16 == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleResultUITask.<>f__mg$cache16 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleResultUITask.__callBase_CollectAllDynamicResForLoad);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_BattleResultUITask.<>f__mg$cache16);
		if (Lua_BlackJack_ProjectL_UI_BattleResultUITask.<>f__mg$cache17 == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleResultUITask.<>f__mg$cache17 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleResultUITask.__callBase_RegisterPlayerContextEvents);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_BattleResultUITask.<>f__mg$cache17);
		if (Lua_BlackJack_ProjectL_UI_BattleResultUITask.<>f__mg$cache18 == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleResultUITask.<>f__mg$cache18 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleResultUITask.__callBase_UnregisterPlayerContextEvents);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_BattleResultUITask.<>f__mg$cache18);
		if (Lua_BlackJack_ProjectL_UI_BattleResultUITask.<>f__mg$cache19 == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleResultUITask.<>f__mg$cache19 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleResultUITask.__callBase_PostUpdateView);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_BattleResultUITask.<>f__mg$cache19);
		if (Lua_BlackJack_ProjectL_UI_BattleResultUITask.<>f__mg$cache1A == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleResultUITask.<>f__mg$cache1A = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleResultUITask.__callBase_CollectPreloadResourceList);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_BattleResultUITask.<>f__mg$cache1A);
		if (Lua_BlackJack_ProjectL_UI_BattleResultUITask.<>f__mg$cache1B == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleResultUITask.<>f__mg$cache1B = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleResultUITask.__callBase_ClearAssetList);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_BattleResultUITask.<>f__mg$cache1B);
		if (Lua_BlackJack_ProjectL_UI_BattleResultUITask.<>f__mg$cache1C == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleResultUITask.<>f__mg$cache1C = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleResultUITask.__callBase_CollectAsset);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_BattleResultUITask.<>f__mg$cache1C);
		if (Lua_BlackJack_ProjectL_UI_BattleResultUITask.<>f__mg$cache1D == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleResultUITask.<>f__mg$cache1D = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleResultUITask.__callBase_CollectSpriteAsset);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_BattleResultUITask.<>f__mg$cache1D);
		if (Lua_BlackJack_ProjectL_UI_BattleResultUITask.<>f__mg$cache1E == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleResultUITask.<>f__mg$cache1E = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleResultUITask.__callBase_CollectFxAsset);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_BattleResultUITask.<>f__mg$cache1E);
		if (Lua_BlackJack_ProjectL_UI_BattleResultUITask.<>f__mg$cache1F == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleResultUITask.<>f__mg$cache1F = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleResultUITask.__callBase_StartLoadCustomAssets);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_BattleResultUITask.<>f__mg$cache1F);
		if (Lua_BlackJack_ProjectL_UI_BattleResultUITask.<>f__mg$cache20 == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleResultUITask.<>f__mg$cache20 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleResultUITask.__callBase_IsLoadingCustomAssets);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_BattleResultUITask.<>f__mg$cache20);
		if (Lua_BlackJack_ProjectL_UI_BattleResultUITask.<>f__mg$cache21 == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleResultUITask.<>f__mg$cache21 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleResultUITask.__callBase_IsPipeLineRunning);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_BattleResultUITask.<>f__mg$cache21);
		if (Lua_BlackJack_ProjectL_UI_BattleResultUITask.<>f__mg$cache22 == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleResultUITask.<>f__mg$cache22 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleResultUITask.__callBase_IsOpeningUI);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_BattleResultUITask.<>f__mg$cache22);
		if (Lua_BlackJack_ProjectL_UI_BattleResultUITask.<>f__mg$cache23 == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleResultUITask.<>f__mg$cache23 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleResultUITask.__callBase_ReturnPrevUITask);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_BattleResultUITask.<>f__mg$cache23);
		if (Lua_BlackJack_ProjectL_UI_BattleResultUITask.<>f__mg$cache24 == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleResultUITask.<>f__mg$cache24 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleResultUITask.__callBase_ClearUnusedDynamicResourceCache);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_BattleResultUITask.<>f__mg$cache24);
		if (Lua_BlackJack_ProjectL_UI_BattleResultUITask.<>f__mg$cache25 == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleResultUITask.<>f__mg$cache25 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleResultUITask.__callBase_OnMemoryWarning);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_BattleResultUITask.<>f__mg$cache25);
		if (Lua_BlackJack_ProjectL_UI_BattleResultUITask.<>f__mg$cache26 == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleResultUITask.<>f__mg$cache26 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleResultUITask.__callDele_EventOnClose);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_BattleResultUITask.<>f__mg$cache26);
		if (Lua_BlackJack_ProjectL_UI_BattleResultUITask.<>f__mg$cache27 == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleResultUITask.<>f__mg$cache27 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleResultUITask.__clearDele_EventOnClose);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_BattleResultUITask.<>f__mg$cache27);
		string name = "EventOnClose";
		LuaCSFunction get = null;
		if (Lua_BlackJack_ProjectL_UI_BattleResultUITask.<>f__mg$cache28 == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleResultUITask.<>f__mg$cache28 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleResultUITask.set_EventOnClose);
		}
		LuaObject.addMember(l, name, get, Lua_BlackJack_ProjectL_UI_BattleResultUITask.<>f__mg$cache28, true);
		string name2 = "m_layerDescArray";
		if (Lua_BlackJack_ProjectL_UI_BattleResultUITask.<>f__mg$cache29 == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleResultUITask.<>f__mg$cache29 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleResultUITask.get_m_layerDescArray);
		}
		LuaCSFunction get2 = Lua_BlackJack_ProjectL_UI_BattleResultUITask.<>f__mg$cache29;
		if (Lua_BlackJack_ProjectL_UI_BattleResultUITask.<>f__mg$cache2A == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleResultUITask.<>f__mg$cache2A = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleResultUITask.set_m_layerDescArray);
		}
		LuaObject.addMember(l, name2, get2, Lua_BlackJack_ProjectL_UI_BattleResultUITask.<>f__mg$cache2A, true);
		string name3 = "m_uiCtrlDescArray";
		if (Lua_BlackJack_ProjectL_UI_BattleResultUITask.<>f__mg$cache2B == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleResultUITask.<>f__mg$cache2B = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleResultUITask.get_m_uiCtrlDescArray);
		}
		LuaCSFunction get3 = Lua_BlackJack_ProjectL_UI_BattleResultUITask.<>f__mg$cache2B;
		if (Lua_BlackJack_ProjectL_UI_BattleResultUITask.<>f__mg$cache2C == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleResultUITask.<>f__mg$cache2C = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleResultUITask.set_m_uiCtrlDescArray);
		}
		LuaObject.addMember(l, name3, get3, Lua_BlackJack_ProjectL_UI_BattleResultUITask.<>f__mg$cache2C, true);
		string name4 = "m_battleResultUIController";
		if (Lua_BlackJack_ProjectL_UI_BattleResultUITask.<>f__mg$cache2D == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleResultUITask.<>f__mg$cache2D = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleResultUITask.get_m_battleResultUIController);
		}
		LuaCSFunction get4 = Lua_BlackJack_ProjectL_UI_BattleResultUITask.<>f__mg$cache2D;
		if (Lua_BlackJack_ProjectL_UI_BattleResultUITask.<>f__mg$cache2E == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleResultUITask.<>f__mg$cache2E = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleResultUITask.set_m_battleResultUIController);
		}
		LuaObject.addMember(l, name4, get4, Lua_BlackJack_ProjectL_UI_BattleResultUITask.<>f__mg$cache2E, true);
		string name5 = "m_battleType";
		if (Lua_BlackJack_ProjectL_UI_BattleResultUITask.<>f__mg$cache2F == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleResultUITask.<>f__mg$cache2F = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleResultUITask.get_m_battleType);
		}
		LuaCSFunction get5 = Lua_BlackJack_ProjectL_UI_BattleResultUITask.<>f__mg$cache2F;
		if (Lua_BlackJack_ProjectL_UI_BattleResultUITask.<>f__mg$cache30 == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleResultUITask.<>f__mg$cache30 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleResultUITask.set_m_battleType);
		}
		LuaObject.addMember(l, name5, get5, Lua_BlackJack_ProjectL_UI_BattleResultUITask.<>f__mg$cache30, true);
		string name6 = "m_heros";
		if (Lua_BlackJack_ProjectL_UI_BattleResultUITask.<>f__mg$cache31 == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleResultUITask.<>f__mg$cache31 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleResultUITask.get_m_heros);
		}
		LuaCSFunction get6 = Lua_BlackJack_ProjectL_UI_BattleResultUITask.<>f__mg$cache31;
		if (Lua_BlackJack_ProjectL_UI_BattleResultUITask.<>f__mg$cache32 == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleResultUITask.<>f__mg$cache32 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleResultUITask.set_m_heros);
		}
		LuaObject.addMember(l, name6, get6, Lua_BlackJack_ProjectL_UI_BattleResultUITask.<>f__mg$cache32, true);
		string name7 = "m_stars";
		if (Lua_BlackJack_ProjectL_UI_BattleResultUITask.<>f__mg$cache33 == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleResultUITask.<>f__mg$cache33 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleResultUITask.get_m_stars);
		}
		LuaCSFunction get7 = Lua_BlackJack_ProjectL_UI_BattleResultUITask.<>f__mg$cache33;
		if (Lua_BlackJack_ProjectL_UI_BattleResultUITask.<>f__mg$cache34 == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleResultUITask.<>f__mg$cache34 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleResultUITask.set_m_stars);
		}
		LuaObject.addMember(l, name7, get7, Lua_BlackJack_ProjectL_UI_BattleResultUITask.<>f__mg$cache34, true);
		string name8 = "m_starTurnMax";
		if (Lua_BlackJack_ProjectL_UI_BattleResultUITask.<>f__mg$cache35 == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleResultUITask.<>f__mg$cache35 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleResultUITask.get_m_starTurnMax);
		}
		LuaCSFunction get8 = Lua_BlackJack_ProjectL_UI_BattleResultUITask.<>f__mg$cache35;
		if (Lua_BlackJack_ProjectL_UI_BattleResultUITask.<>f__mg$cache36 == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleResultUITask.<>f__mg$cache36 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleResultUITask.set_m_starTurnMax);
		}
		LuaObject.addMember(l, name8, get8, Lua_BlackJack_ProjectL_UI_BattleResultUITask.<>f__mg$cache36, true);
		string name9 = "m_starDeadMax";
		if (Lua_BlackJack_ProjectL_UI_BattleResultUITask.<>f__mg$cache37 == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleResultUITask.<>f__mg$cache37 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleResultUITask.get_m_starDeadMax);
		}
		LuaCSFunction get9 = Lua_BlackJack_ProjectL_UI_BattleResultUITask.<>f__mg$cache37;
		if (Lua_BlackJack_ProjectL_UI_BattleResultUITask.<>f__mg$cache38 == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleResultUITask.<>f__mg$cache38 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleResultUITask.set_m_starDeadMax);
		}
		LuaObject.addMember(l, name9, get9, Lua_BlackJack_ProjectL_UI_BattleResultUITask.<>f__mg$cache38, true);
		string name10 = "m_turn";
		if (Lua_BlackJack_ProjectL_UI_BattleResultUITask.<>f__mg$cache39 == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleResultUITask.<>f__mg$cache39 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleResultUITask.get_m_turn);
		}
		LuaCSFunction get10 = Lua_BlackJack_ProjectL_UI_BattleResultUITask.<>f__mg$cache39;
		if (Lua_BlackJack_ProjectL_UI_BattleResultUITask.<>f__mg$cache3A == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleResultUITask.<>f__mg$cache3A = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleResultUITask.set_m_turn);
		}
		LuaObject.addMember(l, name10, get10, Lua_BlackJack_ProjectL_UI_BattleResultUITask.<>f__mg$cache3A, true);
		string name11 = "m_battleReward";
		if (Lua_BlackJack_ProjectL_UI_BattleResultUITask.<>f__mg$cache3B == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleResultUITask.<>f__mg$cache3B = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleResultUITask.get_m_battleReward);
		}
		LuaCSFunction get11 = Lua_BlackJack_ProjectL_UI_BattleResultUITask.<>f__mg$cache3B;
		if (Lua_BlackJack_ProjectL_UI_BattleResultUITask.<>f__mg$cache3C == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleResultUITask.<>f__mg$cache3C = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleResultUITask.set_m_battleReward);
		}
		LuaObject.addMember(l, name11, get11, Lua_BlackJack_ProjectL_UI_BattleResultUITask.<>f__mg$cache3C, true);
		string name12 = "m_isFirstWin";
		if (Lua_BlackJack_ProjectL_UI_BattleResultUITask.<>f__mg$cache3D == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleResultUITask.<>f__mg$cache3D = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleResultUITask.get_m_isFirstWin);
		}
		LuaCSFunction get12 = Lua_BlackJack_ProjectL_UI_BattleResultUITask.<>f__mg$cache3D;
		if (Lua_BlackJack_ProjectL_UI_BattleResultUITask.<>f__mg$cache3E == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleResultUITask.<>f__mg$cache3E = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleResultUITask.set_m_isFirstWin);
		}
		LuaObject.addMember(l, name12, get12, Lua_BlackJack_ProjectL_UI_BattleResultUITask.<>f__mg$cache3E, true);
		string name13 = "m_gotAchievements";
		if (Lua_BlackJack_ProjectL_UI_BattleResultUITask.<>f__mg$cache3F == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleResultUITask.<>f__mg$cache3F = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleResultUITask.get_m_gotAchievements);
		}
		LuaCSFunction get13 = Lua_BlackJack_ProjectL_UI_BattleResultUITask.<>f__mg$cache3F;
		if (Lua_BlackJack_ProjectL_UI_BattleResultUITask.<>f__mg$cache40 == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleResultUITask.<>f__mg$cache40 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleResultUITask.set_m_gotAchievements);
		}
		LuaObject.addMember(l, name13, get13, Lua_BlackJack_ProjectL_UI_BattleResultUITask.<>f__mg$cache40, true);
		string name14 = "m_achievements";
		if (Lua_BlackJack_ProjectL_UI_BattleResultUITask.<>f__mg$cache41 == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleResultUITask.<>f__mg$cache41 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleResultUITask.get_m_achievements);
		}
		LuaCSFunction get14 = Lua_BlackJack_ProjectL_UI_BattleResultUITask.<>f__mg$cache41;
		if (Lua_BlackJack_ProjectL_UI_BattleResultUITask.<>f__mg$cache42 == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleResultUITask.<>f__mg$cache42 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleResultUITask.set_m_achievements);
		}
		LuaObject.addMember(l, name14, get14, Lua_BlackJack_ProjectL_UI_BattleResultUITask.<>f__mg$cache42, true);
		string name15 = "m_chestUITask";
		if (Lua_BlackJack_ProjectL_UI_BattleResultUITask.<>f__mg$cache43 == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleResultUITask.<>f__mg$cache43 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleResultUITask.get_m_chestUITask);
		}
		LuaCSFunction get15 = Lua_BlackJack_ProjectL_UI_BattleResultUITask.<>f__mg$cache43;
		if (Lua_BlackJack_ProjectL_UI_BattleResultUITask.<>f__mg$cache44 == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleResultUITask.<>f__mg$cache44 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleResultUITask.set_m_chestUITask);
		}
		LuaObject.addMember(l, name15, get15, Lua_BlackJack_ProjectL_UI_BattleResultUITask.<>f__mg$cache44, true);
		string name16 = "m_battleResultScoreUITask";
		if (Lua_BlackJack_ProjectL_UI_BattleResultUITask.<>f__mg$cache45 == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleResultUITask.<>f__mg$cache45 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleResultUITask.get_m_battleResultScoreUITask);
		}
		LuaCSFunction get16 = Lua_BlackJack_ProjectL_UI_BattleResultUITask.<>f__mg$cache45;
		if (Lua_BlackJack_ProjectL_UI_BattleResultUITask.<>f__mg$cache46 == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleResultUITask.<>f__mg$cache46 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleResultUITask.set_m_battleResultScoreUITask);
		}
		LuaObject.addMember(l, name16, get16, Lua_BlackJack_ProjectL_UI_BattleResultUITask.<>f__mg$cache46, true);
		string name17 = "LayerDescArray";
		if (Lua_BlackJack_ProjectL_UI_BattleResultUITask.<>f__mg$cache47 == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleResultUITask.<>f__mg$cache47 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleResultUITask.get_LayerDescArray);
		}
		LuaObject.addMember(l, name17, Lua_BlackJack_ProjectL_UI_BattleResultUITask.<>f__mg$cache47, null, true);
		string name18 = "UICtrlDescArray";
		if (Lua_BlackJack_ProjectL_UI_BattleResultUITask.<>f__mg$cache48 == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleResultUITask.<>f__mg$cache48 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleResultUITask.get_UICtrlDescArray);
		}
		LuaObject.addMember(l, name18, Lua_BlackJack_ProjectL_UI_BattleResultUITask.<>f__mg$cache48, null, true);
		if (Lua_BlackJack_ProjectL_UI_BattleResultUITask.<>f__mg$cache49 == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleResultUITask.<>f__mg$cache49 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleResultUITask.constructor);
		}
		LuaObject.createTypeMetatable(l, Lua_BlackJack_ProjectL_UI_BattleResultUITask.<>f__mg$cache49, typeof(BattleResultUITask), typeof(UITask));
	}

	// Token: 0x04012110 RID: 74000
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache0;

	// Token: 0x04012111 RID: 74001
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1;

	// Token: 0x04012112 RID: 74002
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2;

	// Token: 0x04012113 RID: 74003
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3;

	// Token: 0x04012114 RID: 74004
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache4;

	// Token: 0x04012115 RID: 74005
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache5;

	// Token: 0x04012116 RID: 74006
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache6;

	// Token: 0x04012117 RID: 74007
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache7;

	// Token: 0x04012118 RID: 74008
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache8;

	// Token: 0x04012119 RID: 74009
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache9;

	// Token: 0x0401211A RID: 74010
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheA;

	// Token: 0x0401211B RID: 74011
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheB;

	// Token: 0x0401211C RID: 74012
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheC;

	// Token: 0x0401211D RID: 74013
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheD;

	// Token: 0x0401211E RID: 74014
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheE;

	// Token: 0x0401211F RID: 74015
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheF;

	// Token: 0x04012120 RID: 74016
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache10;

	// Token: 0x04012121 RID: 74017
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache11;

	// Token: 0x04012122 RID: 74018
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache12;

	// Token: 0x04012123 RID: 74019
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache13;

	// Token: 0x04012124 RID: 74020
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache14;

	// Token: 0x04012125 RID: 74021
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache15;

	// Token: 0x04012126 RID: 74022
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache16;

	// Token: 0x04012127 RID: 74023
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache17;

	// Token: 0x04012128 RID: 74024
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache18;

	// Token: 0x04012129 RID: 74025
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache19;

	// Token: 0x0401212A RID: 74026
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1A;

	// Token: 0x0401212B RID: 74027
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1B;

	// Token: 0x0401212C RID: 74028
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1C;

	// Token: 0x0401212D RID: 74029
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1D;

	// Token: 0x0401212E RID: 74030
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1E;

	// Token: 0x0401212F RID: 74031
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1F;

	// Token: 0x04012130 RID: 74032
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache20;

	// Token: 0x04012131 RID: 74033
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache21;

	// Token: 0x04012132 RID: 74034
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache22;

	// Token: 0x04012133 RID: 74035
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache23;

	// Token: 0x04012134 RID: 74036
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache24;

	// Token: 0x04012135 RID: 74037
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache25;

	// Token: 0x04012136 RID: 74038
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache26;

	// Token: 0x04012137 RID: 74039
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache27;

	// Token: 0x04012138 RID: 74040
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache28;

	// Token: 0x04012139 RID: 74041
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache29;

	// Token: 0x0401213A RID: 74042
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2A;

	// Token: 0x0401213B RID: 74043
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2B;

	// Token: 0x0401213C RID: 74044
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2C;

	// Token: 0x0401213D RID: 74045
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2D;

	// Token: 0x0401213E RID: 74046
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2E;

	// Token: 0x0401213F RID: 74047
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2F;

	// Token: 0x04012140 RID: 74048
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache30;

	// Token: 0x04012141 RID: 74049
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache31;

	// Token: 0x04012142 RID: 74050
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache32;

	// Token: 0x04012143 RID: 74051
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache33;

	// Token: 0x04012144 RID: 74052
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache34;

	// Token: 0x04012145 RID: 74053
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache35;

	// Token: 0x04012146 RID: 74054
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache36;

	// Token: 0x04012147 RID: 74055
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache37;

	// Token: 0x04012148 RID: 74056
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache38;

	// Token: 0x04012149 RID: 74057
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache39;

	// Token: 0x0401214A RID: 74058
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3A;

	// Token: 0x0401214B RID: 74059
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3B;

	// Token: 0x0401214C RID: 74060
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3C;

	// Token: 0x0401214D RID: 74061
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3D;

	// Token: 0x0401214E RID: 74062
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3E;

	// Token: 0x0401214F RID: 74063
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3F;

	// Token: 0x04012150 RID: 74064
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache40;

	// Token: 0x04012151 RID: 74065
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache41;

	// Token: 0x04012152 RID: 74066
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache42;

	// Token: 0x04012153 RID: 74067
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache43;

	// Token: 0x04012154 RID: 74068
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache44;

	// Token: 0x04012155 RID: 74069
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache45;

	// Token: 0x04012156 RID: 74070
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache46;

	// Token: 0x04012157 RID: 74071
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache47;

	// Token: 0x04012158 RID: 74072
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache48;

	// Token: 0x04012159 RID: 74073
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache49;
}
