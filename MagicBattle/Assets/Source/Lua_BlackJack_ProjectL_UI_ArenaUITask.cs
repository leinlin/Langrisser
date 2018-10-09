using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using BlackJack.BJFramework.Runtime.TaskNs;
using BlackJack.BJFramework.Runtime.UI;
using BlackJack.ConfigData;
using BlackJack.ProjectL.Common;
using BlackJack.ProjectL.UI;
using SLua;
using UnityEngine.Scripting;

// Token: 0x02001386 RID: 4998
[Preserve]
public class Lua_BlackJack_ProjectL_UI_ArenaUITask : LuaObject
{
	// Token: 0x0601B2A8 RID: 111272 RVA: 0x0082FA58 File Offset: 0x0082DC58
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int constructor(IntPtr l)
	{
		int result;
		try
		{
			string name;
			LuaObject.checkType(l, 2, out name);
			ArenaUITask o = new ArenaUITask(name);
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

	// Token: 0x0601B2A9 RID: 111273 RVA: 0x0082FAAC File Offset: 0x0082DCAC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int OnStart(IntPtr l)
	{
		int result;
		try
		{
			ArenaUITask arenaUITask = (ArenaUITask)LuaObject.checkSelf(l);
			UIIntent intent;
			LuaObject.checkType<UIIntent>(l, 2, out intent);
			bool b = arenaUITask.m_luaExportHelper.OnStart(intent);
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

	// Token: 0x0601B2AA RID: 111274 RVA: 0x0082FB14 File Offset: 0x0082DD14
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int OnResume(IntPtr l)
	{
		int result;
		try
		{
			ArenaUITask arenaUITask = (ArenaUITask)LuaObject.checkSelf(l);
			UIIntent intent;
			LuaObject.checkType<UIIntent>(l, 2, out intent);
			bool b = arenaUITask.m_luaExportHelper.OnResume(intent);
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

	// Token: 0x0601B2AB RID: 111275 RVA: 0x0082FB7C File Offset: 0x0082DD7C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int InitDataFromUIIntent(IntPtr l)
	{
		int result;
		try
		{
			ArenaUITask arenaUITask = (ArenaUITask)LuaObject.checkSelf(l);
			UIIntent intent;
			LuaObject.checkType<UIIntent>(l, 2, out intent);
			arenaUITask.m_luaExportHelper.InitDataFromUIIntent(intent);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601B2AC RID: 111276 RVA: 0x0082FBD8 File Offset: 0x0082DDD8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int IsNeedLoadDynamicRes(IntPtr l)
	{
		int result;
		try
		{
			ArenaUITask arenaUITask = (ArenaUITask)LuaObject.checkSelf(l);
			bool b = arenaUITask.m_luaExportHelper.IsNeedLoadDynamicRes();
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

	// Token: 0x0601B2AD RID: 111277 RVA: 0x0082FC34 File Offset: 0x0082DE34
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int CollectPlayerHeadAssets(IntPtr l)
	{
		int result;
		try
		{
			ArenaUITask arenaUITask = (ArenaUITask)LuaObject.checkSelf(l);
			int playerHeadIconId;
			LuaObject.checkType(l, 2, out playerHeadIconId);
			arenaUITask.m_luaExportHelper.CollectPlayerHeadAssets(playerHeadIconId);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601B2AE RID: 111278 RVA: 0x0082FC90 File Offset: 0x0082DE90
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int CollectHeroModelAssets(IntPtr l)
	{
		int result;
		try
		{
			ArenaUITask arenaUITask = (ArenaUITask)LuaObject.checkSelf(l);
			List<BattleHero> heros;
			LuaObject.checkType<List<BattleHero>>(l, 2, out heros);
			arenaUITask.m_luaExportHelper.CollectHeroModelAssets(heros);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601B2AF RID: 111279 RVA: 0x0082FCEC File Offset: 0x0082DEEC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int InitAllUIControllers(IntPtr l)
	{
		int result;
		try
		{
			ArenaUITask arenaUITask = (ArenaUITask)LuaObject.checkSelf(l);
			arenaUITask.m_luaExportHelper.InitAllUIControllers();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601B2B0 RID: 111280 RVA: 0x0082FD40 File Offset: 0x0082DF40
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int ClearAllContextAndRes(IntPtr l)
	{
		int result;
		try
		{
			ArenaUITask arenaUITask = (ArenaUITask)LuaObject.checkSelf(l);
			arenaUITask.m_luaExportHelper.ClearAllContextAndRes();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601B2B1 RID: 111281 RVA: 0x0082FD94 File Offset: 0x0082DF94
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int RegisterPlayerContextEvents(IntPtr l)
	{
		int result;
		try
		{
			ArenaUITask arenaUITask = (ArenaUITask)LuaObject.checkSelf(l);
			arenaUITask.m_luaExportHelper.RegisterPlayerContextEvents();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601B2B2 RID: 111282 RVA: 0x0082FDE8 File Offset: 0x0082DFE8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int UnregisterPlayerContextEvents(IntPtr l)
	{
		int result;
		try
		{
			ArenaUITask arenaUITask = (ArenaUITask)LuaObject.checkSelf(l);
			arenaUITask.m_luaExportHelper.UnregisterPlayerContextEvents();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601B2B3 RID: 111283 RVA: 0x0082FE3C File Offset: 0x0082E03C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int OnStop(IntPtr l)
	{
		int result;
		try
		{
			ArenaUITask arenaUITask = (ArenaUITask)LuaObject.checkSelf(l);
			arenaUITask.m_luaExportHelper.OnStop();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601B2B4 RID: 111284 RVA: 0x0082FE90 File Offset: 0x0082E090
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int InitArenaUIController(IntPtr l)
	{
		int result;
		try
		{
			ArenaUITask arenaUITask = (ArenaUITask)LuaObject.checkSelf(l);
			arenaUITask.m_luaExportHelper.InitArenaUIController();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601B2B5 RID: 111285 RVA: 0x0082FEE4 File Offset: 0x0082E0E4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int UninitArenaUIController(IntPtr l)
	{
		int result;
		try
		{
			ArenaUITask arenaUITask = (ArenaUITask)LuaObject.checkSelf(l);
			arenaUITask.m_luaExportHelper.UninitArenaUIController();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601B2B6 RID: 111286 RVA: 0x0082FF38 File Offset: 0x0082E138
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int OnMemoryWarning(IntPtr l)
	{
		int result;
		try
		{
			ArenaUITask arenaUITask = (ArenaUITask)LuaObject.checkSelf(l);
			arenaUITask.m_luaExportHelper.OnMemoryWarning();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601B2B7 RID: 111287 RVA: 0x0082FF8C File Offset: 0x0082E18C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int OnTick(IntPtr l)
	{
		int result;
		try
		{
			ArenaUITask arenaUITask = (ArenaUITask)LuaObject.checkSelf(l);
			arenaUITask.m_luaExportHelper.OnTick();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601B2B8 RID: 111288 RVA: 0x0082FFE0 File Offset: 0x0082E1E0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int UpdateView(IntPtr l)
	{
		int result;
		try
		{
			ArenaUITask arenaUITask = (ArenaUITask)LuaObject.checkSelf(l);
			arenaUITask.m_luaExportHelper.UpdateView();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601B2B9 RID: 111289 RVA: 0x00830034 File Offset: 0x0082E234
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int UpdatePlayerInfo(IntPtr l)
	{
		int result;
		try
		{
			ArenaUITask arenaUITask = (ArenaUITask)LuaObject.checkSelf(l);
			arenaUITask.m_luaExportHelper.UpdatePlayerInfo();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601B2BA RID: 111290 RVA: 0x00830088 File Offset: 0x0082E288
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int UpdateBattlePower(IntPtr l)
	{
		int result;
		try
		{
			ArenaUITask arenaUITask = (ArenaUITask)LuaObject.checkSelf(l);
			arenaUITask.m_luaExportHelper.UpdateBattlePower();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601B2BB RID: 111291 RVA: 0x008300DC File Offset: 0x0082E2DC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int StartArenaBattleReportBasicDataGetNetTask(IntPtr l)
	{
		int result;
		try
		{
			ArenaUITask arenaUITask = (ArenaUITask)LuaObject.checkSelf(l);
			ArenaUIType arenaUIType;
			LuaObject.checkEnum<ArenaUIType>(l, 2, out arenaUIType);
			arenaUITask.m_luaExportHelper.StartArenaBattleReportBasicDataGetNetTask(arenaUIType);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601B2BC RID: 111292 RVA: 0x00830138 File Offset: 0x0082E338
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int PlayerResourceUIController_OnAddCrystal(IntPtr l)
	{
		int result;
		try
		{
			ArenaUITask arenaUITask = (ArenaUITask)LuaObject.checkSelf(l);
			arenaUITask.m_luaExportHelper.PlayerResourceUIController_OnAddCrystal();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601B2BD RID: 111293 RVA: 0x0083018C File Offset: 0x0082E38C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int ArenaUIController_OnDefend(IntPtr l)
	{
		int result;
		try
		{
			ArenaUITask arenaUITask = (ArenaUITask)LuaObject.checkSelf(l);
			arenaUITask.m_luaExportHelper.ArenaUIController_OnDefend();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601B2BE RID: 111294 RVA: 0x008301E0 File Offset: 0x0082E3E0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int ArenaDefendUITask_OnLoadAllResCompleted(IntPtr l)
	{
		int result;
		try
		{
			ArenaUITask arenaUITask = (ArenaUITask)LuaObject.checkSelf(l);
			arenaUITask.m_luaExportHelper.ArenaDefendUITask_OnLoadAllResCompleted();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601B2BF RID: 111295 RVA: 0x00830234 File Offset: 0x0082E434
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int ArenaUIController_OnReturn(IntPtr l)
	{
		int result;
		try
		{
			ArenaUITask arenaUITask = (ArenaUITask)LuaObject.checkSelf(l);
			arenaUITask.m_luaExportHelper.ArenaUIController_OnReturn();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601B2C0 RID: 111296 RVA: 0x00830288 File Offset: 0x0082E488
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int ArenaUIController_OnShowHelp(IntPtr l)
	{
		int result;
		try
		{
			ArenaUITask arenaUITask = (ArenaUITask)LuaObject.checkSelf(l);
			arenaUITask.m_luaExportHelper.ArenaUIController_OnShowHelp();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601B2C1 RID: 111297 RVA: 0x008302DC File Offset: 0x0082E4DC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int ArenaUIController_OnShowBuyArenaTicket(IntPtr l)
	{
		int result;
		try
		{
			ArenaUITask arenaUITask = (ArenaUITask)LuaObject.checkSelf(l);
			arenaUITask.m_luaExportHelper.ArenaUIController_OnShowBuyArenaTicket();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601B2C2 RID: 111298 RVA: 0x00830330 File Offset: 0x0082E530
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int ArenaUIController_OnBuyArenaTicket(IntPtr l)
	{
		int result;
		try
		{
			ArenaUITask arenaUITask = (ArenaUITask)LuaObject.checkSelf(l);
			arenaUITask.m_luaExportHelper.ArenaUIController_OnBuyArenaTicket();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601B2C3 RID: 111299 RVA: 0x00830384 File Offset: 0x0082E584
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int ArenaUIController_OnSwitchOnlineOffline(IntPtr l)
	{
		int result;
		try
		{
			ArenaUITask arenaUITask = (ArenaUITask)LuaObject.checkSelf(l);
			arenaUITask.m_luaExportHelper.ArenaUIController_OnSwitchOnlineOffline();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601B2C4 RID: 111300 RVA: 0x008303D8 File Offset: 0x0082E5D8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int ChestUITask_OnStop(IntPtr l)
	{
		int result;
		try
		{
			ArenaUITask arenaUITask = (ArenaUITask)LuaObject.checkSelf(l);
			Task task;
			LuaObject.checkType<Task>(l, 2, out task);
			arenaUITask.m_luaExportHelper.ChestUITask_OnStop(task);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601B2C5 RID: 111301 RVA: 0x00830434 File Offset: 0x0082E634
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int ChestUITask_OnClose(IntPtr l)
	{
		int result;
		try
		{
			ArenaUITask arenaUITask = (ArenaUITask)LuaObject.checkSelf(l);
			arenaUITask.m_luaExportHelper.ChestUITask_OnClose();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601B2C6 RID: 111302 RVA: 0x00830488 File Offset: 0x0082E688
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int CollectOfflineArenaAssets(IntPtr l)
	{
		int result;
		try
		{
			ArenaUITask arenaUITask = (ArenaUITask)LuaObject.checkSelf(l);
			arenaUITask.m_luaExportHelper.CollectOfflineArenaAssets();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601B2C7 RID: 111303 RVA: 0x008304DC File Offset: 0x0082E6DC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int UpdateOfflineArena(IntPtr l)
	{
		int result;
		try
		{
			ArenaUITask arenaUITask = (ArenaUITask)LuaObject.checkSelf(l);
			arenaUITask.m_luaExportHelper.UpdateOfflineArena();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601B2C8 RID: 111304 RVA: 0x00830530 File Offset: 0x0082E730
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int UpdateOfflineArenaOpponentRefreshTime(IntPtr l)
	{
		int result;
		try
		{
			ArenaUITask arenaUITask = (ArenaUITask)LuaObject.checkSelf(l);
			arenaUITask.m_luaExportHelper.UpdateOfflineArenaOpponentRefreshTime();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601B2C9 RID: 111305 RVA: 0x00830584 File Offset: 0x0082E784
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int FlushOfflineTopRankPlayers(IntPtr l)
	{
		int result;
		try
		{
			ArenaUITask arenaUITask = (ArenaUITask)LuaObject.checkSelf(l);
			arenaUITask.m_luaExportHelper.FlushOfflineTopRankPlayers();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601B2CA RID: 111306 RVA: 0x008305D8 File Offset: 0x0082E7D8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int AutoGetOfflineVictoryPointReward(IntPtr l)
	{
		int result;
		try
		{
			ArenaUITask arenaUITask = (ArenaUITask)LuaObject.checkSelf(l);
			arenaUITask.m_luaExportHelper.AutoGetOfflineVictoryPointReward();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601B2CB RID: 111307 RVA: 0x0083062C File Offset: 0x0082E82C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int ArenaUIController_OnShowOfflinePanel(IntPtr l)
	{
		int result;
		try
		{
			ArenaUITask arenaUITask = (ArenaUITask)LuaObject.checkSelf(l);
			OfflineArenaPanelType panelType;
			LuaObject.checkEnum<OfflineArenaPanelType>(l, 2, out panelType);
			arenaUITask.m_luaExportHelper.ArenaUIController_OnShowOfflinePanel(panelType);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601B2CC RID: 111308 RVA: 0x00830688 File Offset: 0x0082E888
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int ArenaUIController_OnGainOfflineVictoryPointsReward(IntPtr l)
	{
		int result;
		try
		{
			ArenaUITask arenaUITask = (ArenaUITask)LuaObject.checkSelf(l);
			int idx;
			LuaObject.checkType(l, 2, out idx);
			arenaUITask.m_luaExportHelper.ArenaUIController_OnGainOfflineVictoryPointsReward(idx);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601B2CD RID: 111309 RVA: 0x008306E4 File Offset: 0x0082E8E4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int ArenaUIController_OnShowOfflineArenaOpponent(IntPtr l)
	{
		int result;
		try
		{
			ArenaUITask arenaUITask = (ArenaUITask)LuaObject.checkSelf(l);
			int idx;
			LuaObject.checkType(l, 2, out idx);
			arenaUITask.m_luaExportHelper.ArenaUIController_OnShowOfflineArenaOpponent(idx);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601B2CE RID: 111310 RVA: 0x00830740 File Offset: 0x0082E940
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int ArenaUIController_OnAttackOfflineArenaOpponent(IntPtr l)
	{
		int result;
		try
		{
			ArenaUITask arenaUITask = (ArenaUITask)LuaObject.checkSelf(l);
			bool autoBattle;
			LuaObject.checkType(l, 2, out autoBattle);
			arenaUITask.m_luaExportHelper.ArenaUIController_OnAttackOfflineArenaOpponent(autoBattle);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601B2CF RID: 111311 RVA: 0x0083079C File Offset: 0x0082E99C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int ArenaUIController_OnShowRevengeOfflineArenaOpponent(IntPtr l)
	{
		int result;
		try
		{
			ArenaUITask arenaUITask = (ArenaUITask)LuaObject.checkSelf(l);
			ArenaBattleReport battleReport;
			LuaObject.checkType<ArenaBattleReport>(l, 2, out battleReport);
			arenaUITask.m_luaExportHelper.ArenaUIController_OnShowRevengeOfflineArenaOpponent(battleReport);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601B2D0 RID: 111312 RVA: 0x008307F8 File Offset: 0x0082E9F8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int ArenaUIController_OnRevengeOfflineArenaOpponent(IntPtr l)
	{
		int result;
		try
		{
			ArenaUITask arenaUITask = (ArenaUITask)LuaObject.checkSelf(l);
			bool autoBattle;
			LuaObject.checkType(l, 2, out autoBattle);
			arenaUITask.m_luaExportHelper.ArenaUIController_OnRevengeOfflineArenaOpponent(autoBattle);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601B2D1 RID: 111313 RVA: 0x00830854 File Offset: 0x0082EA54
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int ArenaUIController_OnOfflineBattleReportReplay(IntPtr l)
	{
		int result;
		try
		{
			ArenaUITask arenaUITask = (ArenaUITask)LuaObject.checkSelf(l);
			ArenaBattleReport battleReport;
			LuaObject.checkType<ArenaBattleReport>(l, 2, out battleReport);
			arenaUITask.m_luaExportHelper.ArenaUIController_OnOfflineBattleReportReplay(battleReport);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601B2D2 RID: 111314 RVA: 0x008308B0 File Offset: 0x0082EAB0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int PlayerContext_OnArenaFlushOpponentsNtf(IntPtr l)
	{
		int result;
		try
		{
			ArenaUITask arenaUITask = (ArenaUITask)LuaObject.checkSelf(l);
			arenaUITask.m_luaExportHelper.PlayerContext_OnArenaFlushOpponentsNtf();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601B2D3 RID: 111315 RVA: 0x00830904 File Offset: 0x0082EB04
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int CollectOnlineArenaAssets(IntPtr l)
	{
		int result;
		try
		{
			ArenaUITask arenaUITask = (ArenaUITask)LuaObject.checkSelf(l);
			arenaUITask.m_luaExportHelper.CollectOnlineArenaAssets();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601B2D4 RID: 111316 RVA: 0x00830958 File Offset: 0x0082EB58
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int UpdateOnlineArena(IntPtr l)
	{
		int result;
		try
		{
			ArenaUITask arenaUITask = (ArenaUITask)LuaObject.checkSelf(l);
			arenaUITask.m_luaExportHelper.UpdateOnlineArena();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601B2D5 RID: 111317 RVA: 0x008309AC File Offset: 0x0082EBAC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int UpdateOnlineMatchingTime(IntPtr l)
	{
		int result;
		try
		{
			ArenaUITask arenaUITask = (ArenaUITask)LuaObject.checkSelf(l);
			arenaUITask.m_luaExportHelper.UpdateOnlineMatchingTime();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601B2D6 RID: 111318 RVA: 0x00830A00 File Offset: 0x0082EC00
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int UpdateLadderMode(IntPtr l)
	{
		int result;
		try
		{
			ArenaUITask arenaUITask = (ArenaUITask)LuaObject.checkSelf(l);
			arenaUITask.m_luaExportHelper.UpdateLadderMode();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601B2D7 RID: 111319 RVA: 0x00830A54 File Offset: 0x0082EC54
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int FlushOnlineTopRankPlayers(IntPtr l)
	{
		int result;
		try
		{
			ArenaUITask arenaUITask = (ArenaUITask)LuaObject.checkSelf(l);
			bool isGlobal;
			LuaObject.checkType(l, 2, out isGlobal);
			arenaUITask.m_luaExportHelper.FlushOnlineTopRankPlayers(isGlobal);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601B2D8 RID: 111320 RVA: 0x00830AB0 File Offset: 0x0082ECB0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int StartRealTimePVPGetInfoNetTask(IntPtr l)
	{
		int result;
		try
		{
			ArenaUITask arenaUITask = (ArenaUITask)LuaObject.checkSelf(l);
			Action<int> onEnd;
			LuaObject.checkDelegate<Action<int>>(l, 2, out onEnd);
			arenaUITask.m_luaExportHelper.StartRealTimePVPGetInfoNetTask(onEnd);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601B2D9 RID: 111321 RVA: 0x00830B0C File Offset: 0x0082ED0C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int StartRealTimePVPGetTopPlayersNetTask(IntPtr l)
	{
		int result;
		try
		{
			ArenaUITask arenaUITask = (ArenaUITask)LuaObject.checkSelf(l);
			bool isGlobal;
			LuaObject.checkType(l, 2, out isGlobal);
			arenaUITask.m_luaExportHelper.StartRealTimePVPGetTopPlayersNetTask(isGlobal);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601B2DA RID: 111322 RVA: 0x00830B68 File Offset: 0x0082ED68
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int AutoGetOnlineWeekWinReward(IntPtr l)
	{
		int result;
		try
		{
			ArenaUITask arenaUITask = (ArenaUITask)LuaObject.checkSelf(l);
			arenaUITask.m_luaExportHelper.AutoGetOnlineWeekWinReward();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601B2DB RID: 111323 RVA: 0x00830BBC File Offset: 0x0082EDBC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int StartRealTimePVPWaitingForOpponentNetTask(IntPtr l)
	{
		int result;
		try
		{
			ArenaUITask arenaUITask = (ArenaUITask)LuaObject.checkSelf(l);
			BattleMode mode;
			LuaObject.checkEnum<BattleMode>(l, 2, out mode);
			arenaUITask.m_luaExportHelper.StartRealTimePVPWaitingForOpponentNetTask(mode);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601B2DC RID: 111324 RVA: 0x00830C18 File Offset: 0x0082EE18
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int StartMatchiing(IntPtr l)
	{
		int result;
		try
		{
			ArenaUITask arenaUITask = (ArenaUITask)LuaObject.checkSelf(l);
			BattleMode mode;
			LuaObject.checkEnum<BattleMode>(l, 2, out mode);
			arenaUITask.m_luaExportHelper.StartMatchiing(mode);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601B2DD RID: 111325 RVA: 0x00830C74 File Offset: 0x0082EE74
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int ArenaUIController_OnShowOnlinePanel(IntPtr l)
	{
		int result;
		try
		{
			ArenaUITask arenaUITask = (ArenaUITask)LuaObject.checkSelf(l);
			OnlineArenaPanelType panelType;
			LuaObject.checkEnum<OnlineArenaPanelType>(l, 2, out panelType);
			arenaUITask.m_luaExportHelper.ArenaUIController_OnShowOnlinePanel(panelType);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601B2DE RID: 111326 RVA: 0x00830CD0 File Offset: 0x0082EED0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int ArenaUIController_OnGainOnlineWeekWinReward(IntPtr l)
	{
		int result;
		try
		{
			ArenaUITask arenaUITask = (ArenaUITask)LuaObject.checkSelf(l);
			int bonusId;
			LuaObject.checkType(l, 2, out bonusId);
			arenaUITask.m_luaExportHelper.ArenaUIController_OnGainOnlineWeekWinReward(bonusId);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601B2DF RID: 111327 RVA: 0x00830D2C File Offset: 0x0082EF2C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int ArenaUIController_OnOnlineBattleReportReplay(IntPtr l)
	{
		int result;
		try
		{
			ArenaUITask arenaUITask = (ArenaUITask)LuaObject.checkSelf(l);
			RealTimePVPBattleReport battleReport;
			LuaObject.checkType<RealTimePVPBattleReport>(l, 2, out battleReport);
			arenaUITask.m_luaExportHelper.ArenaUIController_OnOnlineBattleReportReplay(battleReport);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601B2E0 RID: 111328 RVA: 0x00830D88 File Offset: 0x0082EF88
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int ArenaUIController_OnLadderChallenge(IntPtr l)
	{
		int result;
		try
		{
			ArenaUITask arenaUITask = (ArenaUITask)LuaObject.checkSelf(l);
			arenaUITask.m_luaExportHelper.ArenaUIController_OnLadderChallenge();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601B2E1 RID: 111329 RVA: 0x00830DDC File Offset: 0x0082EFDC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int ArenaUIController_OnCasualChallenge(IntPtr l)
	{
		int result;
		try
		{
			ArenaUITask arenaUITask = (ArenaUITask)LuaObject.checkSelf(l);
			arenaUITask.m_luaExportHelper.ArenaUIController_OnCasualChallenge();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601B2E2 RID: 111330 RVA: 0x00830E30 File Offset: 0x0082F030
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int ArenaUIController_OnMatchingCancel(IntPtr l)
	{
		int result;
		try
		{
			ArenaUITask arenaUITask = (ArenaUITask)LuaObject.checkSelf(l);
			arenaUITask.m_luaExportHelper.ArenaUIController_OnMatchingCancel();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601B2E3 RID: 111331 RVA: 0x00830E84 File Offset: 0x0082F084
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int PlayerContext_OnRealTimePVPMatchupNtf(IntPtr l)
	{
		int result2;
		try
		{
			ArenaUITask arenaUITask = (ArenaUITask)LuaObject.checkSelf(l);
			int result;
			LuaObject.checkType(l, 2, out result);
			arenaUITask.m_luaExportHelper.PlayerContext_OnRealTimePVPMatchupNtf(result);
			LuaObject.pushValue(l, true);
			result2 = 1;
		}
		catch (Exception e)
		{
			result2 = LuaObject.error(l, e);
		}
		return result2;
	}

	// Token: 0x0601B2E4 RID: 111332 RVA: 0x00830EE0 File Offset: 0x0082F0E0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_OnStart(IntPtr l)
	{
		int result;
		try
		{
			ArenaUITask arenaUITask = (ArenaUITask)LuaObject.checkSelf(l);
			UIIntent intent;
			LuaObject.checkType<UIIntent>(l, 2, out intent);
			bool b = arenaUITask.m_luaExportHelper.__callBase_OnStart(intent);
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

	// Token: 0x0601B2E5 RID: 111333 RVA: 0x00830F48 File Offset: 0x0082F148
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_OnStop(IntPtr l)
	{
		int result;
		try
		{
			ArenaUITask arenaUITask = (ArenaUITask)LuaObject.checkSelf(l);
			arenaUITask.m_luaExportHelper.__callBase_OnStop();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601B2E6 RID: 111334 RVA: 0x00830F9C File Offset: 0x0082F19C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_OnPause(IntPtr l)
	{
		int result;
		try
		{
			ArenaUITask arenaUITask = (ArenaUITask)LuaObject.checkSelf(l);
			arenaUITask.m_luaExportHelper.__callBase_OnPause();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601B2E7 RID: 111335 RVA: 0x00830FF0 File Offset: 0x0082F1F0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_OnResume(IntPtr l)
	{
		int result;
		try
		{
			ArenaUITask arenaUITask = (ArenaUITask)LuaObject.checkSelf(l);
			UIIntent intent;
			LuaObject.checkType<UIIntent>(l, 2, out intent);
			bool b = arenaUITask.m_luaExportHelper.__callBase_OnResume(intent);
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

	// Token: 0x0601B2E8 RID: 111336 RVA: 0x00831058 File Offset: 0x0082F258
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_OnNewIntent(IntPtr l)
	{
		int result;
		try
		{
			ArenaUITask arenaUITask = (ArenaUITask)LuaObject.checkSelf(l);
			UIIntent intent;
			LuaObject.checkType<UIIntent>(l, 2, out intent);
			bool b = arenaUITask.m_luaExportHelper.__callBase_OnNewIntent(intent);
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

	// Token: 0x0601B2E9 RID: 111337 RVA: 0x008310C0 File Offset: 0x0082F2C0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_EnableUIInput(IntPtr l)
	{
		int result;
		try
		{
			ArenaUITask arenaUITask = (ArenaUITask)LuaObject.checkSelf(l);
			bool isEnable;
			LuaObject.checkType(l, 2, out isEnable);
			bool? isGlobalEnable;
			LuaObject.checkNullable<bool>(l, 3, out isGlobalEnable);
			arenaUITask.m_luaExportHelper.__callBase_EnableUIInput(isEnable, isGlobalEnable);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601B2EA RID: 111338 RVA: 0x0083112C File Offset: 0x0082F32C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_IsNeedLoadDynamicRes(IntPtr l)
	{
		int result;
		try
		{
			ArenaUITask arenaUITask = (ArenaUITask)LuaObject.checkSelf(l);
			bool b = arenaUITask.m_luaExportHelper.__callBase_IsNeedLoadDynamicRes();
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

	// Token: 0x0601B2EB RID: 111339 RVA: 0x00831188 File Offset: 0x0082F388
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_CollectAllDynamicResForLoad(IntPtr l)
	{
		int result;
		try
		{
			ArenaUITask arenaUITask = (ArenaUITask)LuaObject.checkSelf(l);
			List<string> o = arenaUITask.m_luaExportHelper.__callBase_CollectAllDynamicResForLoad();
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

	// Token: 0x0601B2EC RID: 111340 RVA: 0x008311E4 File Offset: 0x0082F3E4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_RegisterPlayerContextEvents(IntPtr l)
	{
		int result;
		try
		{
			ArenaUITask arenaUITask = (ArenaUITask)LuaObject.checkSelf(l);
			arenaUITask.m_luaExportHelper.__callBase_RegisterPlayerContextEvents();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601B2ED RID: 111341 RVA: 0x00831238 File Offset: 0x0082F438
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_UnregisterPlayerContextEvents(IntPtr l)
	{
		int result;
		try
		{
			ArenaUITask arenaUITask = (ArenaUITask)LuaObject.checkSelf(l);
			arenaUITask.m_luaExportHelper.__callBase_UnregisterPlayerContextEvents();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601B2EE RID: 111342 RVA: 0x0083128C File Offset: 0x0082F48C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_PostUpdateView(IntPtr l)
	{
		int result;
		try
		{
			ArenaUITask arenaUITask = (ArenaUITask)LuaObject.checkSelf(l);
			arenaUITask.m_luaExportHelper.__callBase_PostUpdateView();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601B2EF RID: 111343 RVA: 0x008312E0 File Offset: 0x0082F4E0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_CollectPreloadResourceList(IntPtr l)
	{
		int result;
		try
		{
			ArenaUITask arenaUITask = (ArenaUITask)LuaObject.checkSelf(l);
			arenaUITask.m_luaExportHelper.__callBase_CollectPreloadResourceList();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601B2F0 RID: 111344 RVA: 0x00831334 File Offset: 0x0082F534
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_ClearAssetList(IntPtr l)
	{
		int result;
		try
		{
			ArenaUITask arenaUITask = (ArenaUITask)LuaObject.checkSelf(l);
			arenaUITask.m_luaExportHelper.__callBase_ClearAssetList();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601B2F1 RID: 111345 RVA: 0x00831388 File Offset: 0x0082F588
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_CollectAsset(IntPtr l)
	{
		int result;
		try
		{
			ArenaUITask arenaUITask = (ArenaUITask)LuaObject.checkSelf(l);
			string assetName;
			LuaObject.checkType(l, 2, out assetName);
			arenaUITask.m_luaExportHelper.__callBase_CollectAsset(assetName);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601B2F2 RID: 111346 RVA: 0x008313E4 File Offset: 0x0082F5E4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_CollectSpriteAsset(IntPtr l)
	{
		int result;
		try
		{
			ArenaUITask arenaUITask = (ArenaUITask)LuaObject.checkSelf(l);
			string assetName;
			LuaObject.checkType(l, 2, out assetName);
			arenaUITask.m_luaExportHelper.__callBase_CollectSpriteAsset(assetName);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601B2F3 RID: 111347 RVA: 0x00831440 File Offset: 0x0082F640
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_CollectFxAsset(IntPtr l)
	{
		int result;
		try
		{
			ArenaUITask arenaUITask = (ArenaUITask)LuaObject.checkSelf(l);
			string assetName;
			LuaObject.checkType(l, 2, out assetName);
			arenaUITask.m_luaExportHelper.__callBase_CollectFxAsset(assetName);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601B2F4 RID: 111348 RVA: 0x0083149C File Offset: 0x0082F69C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_StartLoadCustomAssets(IntPtr l)
	{
		int result;
		try
		{
			ArenaUITask arenaUITask = (ArenaUITask)LuaObject.checkSelf(l);
			Action onLoadCompleted;
			LuaObject.checkDelegate<Action>(l, 2, out onLoadCompleted);
			arenaUITask.m_luaExportHelper.__callBase_StartLoadCustomAssets(onLoadCompleted);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601B2F5 RID: 111349 RVA: 0x008314F8 File Offset: 0x0082F6F8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_IsLoadingCustomAssets(IntPtr l)
	{
		int result;
		try
		{
			ArenaUITask arenaUITask = (ArenaUITask)LuaObject.checkSelf(l);
			bool b = arenaUITask.m_luaExportHelper.__callBase_IsLoadingCustomAssets();
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

	// Token: 0x0601B2F6 RID: 111350 RVA: 0x00831554 File Offset: 0x0082F754
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_IsPipeLineRunning(IntPtr l)
	{
		int result;
		try
		{
			ArenaUITask arenaUITask = (ArenaUITask)LuaObject.checkSelf(l);
			bool b = arenaUITask.m_luaExportHelper.__callBase_IsPipeLineRunning();
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

	// Token: 0x0601B2F7 RID: 111351 RVA: 0x008315B0 File Offset: 0x0082F7B0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_IsOpeningUI(IntPtr l)
	{
		int result;
		try
		{
			ArenaUITask arenaUITask = (ArenaUITask)LuaObject.checkSelf(l);
			bool b = arenaUITask.m_luaExportHelper.__callBase_IsOpeningUI();
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

	// Token: 0x0601B2F8 RID: 111352 RVA: 0x0083160C File Offset: 0x0082F80C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_ReturnPrevUITask(IntPtr l)
	{
		int result;
		try
		{
			ArenaUITask arenaUITask = (ArenaUITask)LuaObject.checkSelf(l);
			UITaskBase o = arenaUITask.m_luaExportHelper.__callBase_ReturnPrevUITask();
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

	// Token: 0x0601B2F9 RID: 111353 RVA: 0x00831668 File Offset: 0x0082F868
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_ClearUnusedDynamicResourceCache(IntPtr l)
	{
		int result;
		try
		{
			ArenaUITask arenaUITask = (ArenaUITask)LuaObject.checkSelf(l);
			arenaUITask.m_luaExportHelper.__callBase_ClearUnusedDynamicResourceCache();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601B2FA RID: 111354 RVA: 0x008316BC File Offset: 0x0082F8BC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_OnMemoryWarning(IntPtr l)
	{
		int result;
		try
		{
			ArenaUITask arenaUITask = (ArenaUITask)LuaObject.checkSelf(l);
			arenaUITask.m_luaExportHelper.__callBase_OnMemoryWarning();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601B2FB RID: 111355 RVA: 0x00831710 File Offset: 0x0082F910
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callDele_EventOnStartArenaBattle(IntPtr l)
	{
		int result;
		try
		{
			ArenaUITask arenaUITask = (ArenaUITask)LuaObject.checkSelf(l);
			bool obj;
			LuaObject.checkType(l, 2, out obj);
			arenaUITask.m_luaExportHelper.__callDele_EventOnStartArenaBattle(obj);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601B2FC RID: 111356 RVA: 0x0083176C File Offset: 0x0082F96C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __clearDele_EventOnStartArenaBattle(IntPtr l)
	{
		int result;
		try
		{
			ArenaUITask arenaUITask = (ArenaUITask)LuaObject.checkSelf(l);
			bool obj;
			LuaObject.checkType(l, 2, out obj);
			arenaUITask.m_luaExportHelper.__clearDele_EventOnStartArenaBattle(obj);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601B2FD RID: 111357 RVA: 0x008317C8 File Offset: 0x0082F9C8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callDele_EventOnStartArenaBattleReplay(IntPtr l)
	{
		int result;
		try
		{
			ArenaUITask arenaUITask = (ArenaUITask)LuaObject.checkSelf(l);
			ArenaBattleReport obj;
			LuaObject.checkType<ArenaBattleReport>(l, 2, out obj);
			arenaUITask.m_luaExportHelper.__callDele_EventOnStartArenaBattleReplay(obj);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601B2FE RID: 111358 RVA: 0x00831824 File Offset: 0x0082FA24
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __clearDele_EventOnStartArenaBattleReplay(IntPtr l)
	{
		int result;
		try
		{
			ArenaUITask arenaUITask = (ArenaUITask)LuaObject.checkSelf(l);
			ArenaBattleReport obj;
			LuaObject.checkType<ArenaBattleReport>(l, 2, out obj);
			arenaUITask.m_luaExportHelper.__clearDele_EventOnStartArenaBattleReplay(obj);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601B2FF RID: 111359 RVA: 0x00831880 File Offset: 0x0082FA80
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callDele_EventOnStartRealTimePVPBattleReplay(IntPtr l)
	{
		int result;
		try
		{
			ArenaUITask arenaUITask = (ArenaUITask)LuaObject.checkSelf(l);
			RealTimePVPBattleReport obj;
			LuaObject.checkType<RealTimePVPBattleReport>(l, 2, out obj);
			arenaUITask.m_luaExportHelper.__callDele_EventOnStartRealTimePVPBattleReplay(obj);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601B300 RID: 111360 RVA: 0x008318DC File Offset: 0x0082FADC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __clearDele_EventOnStartRealTimePVPBattleReplay(IntPtr l)
	{
		int result;
		try
		{
			ArenaUITask arenaUITask = (ArenaUITask)LuaObject.checkSelf(l);
			RealTimePVPBattleReport obj;
			LuaObject.checkType<RealTimePVPBattleReport>(l, 2, out obj);
			arenaUITask.m_luaExportHelper.__clearDele_EventOnStartRealTimePVPBattleReplay(obj);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601B301 RID: 111361 RVA: 0x00831938 File Offset: 0x0082FB38
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int CompareHeroBattlePower_s(IntPtr l)
	{
		int result;
		try
		{
			Hero h;
			LuaObject.checkType<Hero>(l, 1, out h);
			Hero h2;
			LuaObject.checkType<Hero>(l, 2, out h2);
			int i = ArenaUITask.LuaExportHelper.CompareHeroBattlePower(h, h2);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, i);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601B302 RID: 111362 RVA: 0x00831998 File Offset: 0x0082FB98
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int CompareArenaBattleReportsByCreateTime_s(IntPtr l)
	{
		int result;
		try
		{
			ArenaBattleReport r;
			LuaObject.checkType<ArenaBattleReport>(l, 1, out r);
			ArenaBattleReport r2;
			LuaObject.checkType<ArenaBattleReport>(l, 2, out r2);
			int i = ArenaUITask.LuaExportHelper.CompareArenaBattleReportsByCreateTime(r, r2);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, i);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601B303 RID: 111363 RVA: 0x008319F8 File Offset: 0x0082FBF8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int CompareRealTimePVPBattleReportsByCreateTime_s(IntPtr l)
	{
		int result;
		try
		{
			RealTimePVPBattleReport r;
			LuaObject.checkType<RealTimePVPBattleReport>(l, 1, out r);
			RealTimePVPBattleReport r2;
			LuaObject.checkType<RealTimePVPBattleReport>(l, 2, out r2);
			int i = ArenaUITask.LuaExportHelper.CompareRealTimePVPBattleReportsByCreateTime(r, r2);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, i);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601B304 RID: 111364 RVA: 0x00831A58 File Offset: 0x0082FC58
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int IsBattleReportAttackerGiveup_s(IntPtr l)
	{
		int result;
		try
		{
			ArenaBattleReport battleReport;
			LuaObject.checkType<ArenaBattleReport>(l, 1, out battleReport);
			bool b = ArenaUITask.LuaExportHelper.IsBattleReportAttackerGiveup(battleReport);
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

	// Token: 0x0601B305 RID: 111365 RVA: 0x00831AAC File Offset: 0x0082FCAC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int IsBattleReportPlayerGiveup_s(IntPtr l)
	{
		int result;
		try
		{
			RealTimePVPBattleReport battleReport;
			LuaObject.checkType<RealTimePVPBattleReport>(l, 1, out battleReport);
			int i;
			bool b = ArenaUITask.LuaExportHelper.IsBattleReportPlayerGiveup(battleReport, out i);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, b);
			LuaObject.pushValue(l, i);
			result = 3;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601B306 RID: 111366 RVA: 0x00831B0C File Offset: 0x0082FD0C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_EventOnStartArenaBattle(IntPtr l)
	{
		int result;
		try
		{
			ArenaUITask arenaUITask = (ArenaUITask)LuaObject.checkSelf(l);
			Action<bool> value;
			int num = LuaObject.checkDelegate<Action<bool>>(l, 2, out value);
			if (num != 0)
			{
				if (num == 1)
				{
					arenaUITask.EventOnStartArenaBattle += value;
				}
				else if (num == 2)
				{
					arenaUITask.EventOnStartArenaBattle -= value;
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

	// Token: 0x0601B307 RID: 111367 RVA: 0x00831B8C File Offset: 0x0082FD8C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_EventOnStartArenaBattleReplay(IntPtr l)
	{
		int result;
		try
		{
			ArenaUITask arenaUITask = (ArenaUITask)LuaObject.checkSelf(l);
			Action<ArenaBattleReport> value;
			int num = LuaObject.checkDelegate<Action<ArenaBattleReport>>(l, 2, out value);
			if (num != 0)
			{
				if (num == 1)
				{
					arenaUITask.EventOnStartArenaBattleReplay += value;
				}
				else if (num == 2)
				{
					arenaUITask.EventOnStartArenaBattleReplay -= value;
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

	// Token: 0x0601B308 RID: 111368 RVA: 0x00831C0C File Offset: 0x0082FE0C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_EventOnStartRealTimePVPBattleReplay(IntPtr l)
	{
		int result;
		try
		{
			ArenaUITask arenaUITask = (ArenaUITask)LuaObject.checkSelf(l);
			Action<RealTimePVPBattleReport> value;
			int num = LuaObject.checkDelegate<Action<RealTimePVPBattleReport>>(l, 2, out value);
			if (num != 0)
			{
				if (num == 1)
				{
					arenaUITask.EventOnStartRealTimePVPBattleReplay += value;
				}
				else if (num == 2)
				{
					arenaUITask.EventOnStartRealTimePVPBattleReplay -= value;
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

	// Token: 0x0601B309 RID: 111369 RVA: 0x00831C8C File Offset: 0x0082FE8C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_layerDescArray(IntPtr l)
	{
		int result;
		try
		{
			ArenaUITask arenaUITask = (ArenaUITask)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, arenaUITask.m_luaExportHelper.m_layerDescArray);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601B30A RID: 111370 RVA: 0x00831CE4 File Offset: 0x0082FEE4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_layerDescArray(IntPtr l)
	{
		int result;
		try
		{
			ArenaUITask arenaUITask = (ArenaUITask)LuaObject.checkSelf(l);
			UITaskBase.LayerDesc[] layerDescArray;
			LuaObject.checkArray<UITaskBase.LayerDesc>(l, 2, out layerDescArray);
			arenaUITask.m_luaExportHelper.m_layerDescArray = layerDescArray;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601B30B RID: 111371 RVA: 0x00831D40 File Offset: 0x0082FF40
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_uiCtrlDescArray(IntPtr l)
	{
		int result;
		try
		{
			ArenaUITask arenaUITask = (ArenaUITask)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, arenaUITask.m_luaExportHelper.m_uiCtrlDescArray);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601B30C RID: 111372 RVA: 0x00831D98 File Offset: 0x0082FF98
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_uiCtrlDescArray(IntPtr l)
	{
		int result;
		try
		{
			ArenaUITask arenaUITask = (ArenaUITask)LuaObject.checkSelf(l);
			UITaskBase.UIControllerDesc[] uiCtrlDescArray;
			LuaObject.checkArray<UITaskBase.UIControllerDesc>(l, 2, out uiCtrlDescArray);
			arenaUITask.m_luaExportHelper.m_uiCtrlDescArray = uiCtrlDescArray;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601B30D RID: 111373 RVA: 0x00831DF4 File Offset: 0x0082FFF4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_arenaUIController(IntPtr l)
	{
		int result;
		try
		{
			ArenaUITask arenaUITask = (ArenaUITask)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, arenaUITask.m_luaExportHelper.m_arenaUIController);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601B30E RID: 111374 RVA: 0x00831E4C File Offset: 0x0083004C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_arenaUIController(IntPtr l)
	{
		int result;
		try
		{
			ArenaUITask arenaUITask = (ArenaUITask)LuaObject.checkSelf(l);
			ArenaUIController arenaUIController;
			LuaObject.checkType<ArenaUIController>(l, 2, out arenaUIController);
			arenaUITask.m_luaExportHelper.m_arenaUIController = arenaUIController;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601B30F RID: 111375 RVA: 0x00831EA8 File Offset: 0x008300A8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_playerResourceUIController(IntPtr l)
	{
		int result;
		try
		{
			ArenaUITask arenaUITask = (ArenaUITask)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, arenaUITask.m_luaExportHelper.m_playerResourceUIController);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601B310 RID: 111376 RVA: 0x00831F00 File Offset: 0x00830100
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_playerResourceUIController(IntPtr l)
	{
		int result;
		try
		{
			ArenaUITask arenaUITask = (ArenaUITask)LuaObject.checkSelf(l);
			PlayerResourceUIController playerResourceUIController;
			LuaObject.checkType<PlayerResourceUIController>(l, 2, out playerResourceUIController);
			arenaUITask.m_luaExportHelper.m_playerResourceUIController = playerResourceUIController;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601B311 RID: 111377 RVA: 0x00831F5C File Offset: 0x0083015C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_arenaDefendUITask(IntPtr l)
	{
		int result;
		try
		{
			ArenaUITask arenaUITask = (ArenaUITask)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, arenaUITask.m_luaExportHelper.m_arenaDefendUITask);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601B312 RID: 111378 RVA: 0x00831FB4 File Offset: 0x008301B4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_arenaDefendUITask(IntPtr l)
	{
		int result;
		try
		{
			ArenaUITask arenaUITask = (ArenaUITask)LuaObject.checkSelf(l);
			ArenaDefendUITask arenaDefendUITask;
			LuaObject.checkType<ArenaDefendUITask>(l, 2, out arenaDefendUITask);
			arenaUITask.m_luaExportHelper.m_arenaDefendUITask = arenaDefendUITask;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601B313 RID: 111379 RVA: 0x00832010 File Offset: 0x00830210
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_chestUITask(IntPtr l)
	{
		int result;
		try
		{
			ArenaUITask arenaUITask = (ArenaUITask)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, arenaUITask.m_luaExportHelper.m_chestUITask);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601B314 RID: 111380 RVA: 0x00832068 File Offset: 0x00830268
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_chestUITask(IntPtr l)
	{
		int result;
		try
		{
			ArenaUITask arenaUITask = (ArenaUITask)LuaObject.checkSelf(l);
			ChestUITask chestUITask;
			LuaObject.checkType<ChestUITask>(l, 2, out chestUITask);
			arenaUITask.m_luaExportHelper.m_chestUITask = chestUITask;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601B315 RID: 111381 RVA: 0x008320C4 File Offset: 0x008302C4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_realTimePVPDans(IntPtr l)
	{
		int result;
		try
		{
			ArenaUITask arenaUITask = (ArenaUITask)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, arenaUITask.m_luaExportHelper.m_realTimePVPDans);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601B316 RID: 111382 RVA: 0x0083211C File Offset: 0x0083031C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_realTimePVPDans(IntPtr l)
	{
		int result;
		try
		{
			ArenaUITask arenaUITask = (ArenaUITask)LuaObject.checkSelf(l);
			List<ConfigDataRealTimePVPDanInfo> realTimePVPDans;
			LuaObject.checkType<List<ConfigDataRealTimePVPDanInfo>>(l, 2, out realTimePVPDans);
			arenaUITask.m_luaExportHelper.m_realTimePVPDans = realTimePVPDans;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601B317 RID: 111383 RVA: 0x00832178 File Offset: 0x00830378
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_arenaOpponents(IntPtr l)
	{
		int result;
		try
		{
			ArenaUITask arenaUITask = (ArenaUITask)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, arenaUITask.m_luaExportHelper.m_arenaOpponents);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601B318 RID: 111384 RVA: 0x008321D0 File Offset: 0x008303D0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_arenaOpponents(IntPtr l)
	{
		int result;
		try
		{
			ArenaUITask arenaUITask = (ArenaUITask)LuaObject.checkSelf(l);
			List<ArenaOpponent> arenaOpponents;
			LuaObject.checkType<List<ArenaOpponent>>(l, 2, out arenaOpponents);
			arenaUITask.m_luaExportHelper.m_arenaOpponents = arenaOpponents;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601B319 RID: 111385 RVA: 0x0083222C File Offset: 0x0083042C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_offlineArenaBattleReport(IntPtr l)
	{
		int result;
		try
		{
			ArenaUITask arenaUITask = (ArenaUITask)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, arenaUITask.m_luaExportHelper.m_offlineArenaBattleReport);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601B31A RID: 111386 RVA: 0x00832284 File Offset: 0x00830484
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_offlineArenaBattleReport(IntPtr l)
	{
		int result;
		try
		{
			ArenaUITask arenaUITask = (ArenaUITask)LuaObject.checkSelf(l);
			List<ArenaBattleReport> offlineArenaBattleReport;
			LuaObject.checkType<List<ArenaBattleReport>>(l, 2, out offlineArenaBattleReport);
			arenaUITask.m_luaExportHelper.m_offlineArenaBattleReport = offlineArenaBattleReport;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601B31B RID: 111387 RVA: 0x008322E0 File Offset: 0x008304E0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_onlineArenaBattleReport(IntPtr l)
	{
		int result;
		try
		{
			ArenaUITask arenaUITask = (ArenaUITask)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, arenaUITask.m_luaExportHelper.m_onlineArenaBattleReport);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601B31C RID: 111388 RVA: 0x00832338 File Offset: 0x00830538
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_onlineArenaBattleReport(IntPtr l)
	{
		int result;
		try
		{
			ArenaUITask arenaUITask = (ArenaUITask)LuaObject.checkSelf(l);
			List<RealTimePVPBattleReport> onlineArenaBattleReport;
			LuaObject.checkType<List<RealTimePVPBattleReport>>(l, 2, out onlineArenaBattleReport);
			arenaUITask.m_luaExportHelper.m_onlineArenaBattleReport = onlineArenaBattleReport;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601B31D RID: 111389 RVA: 0x00832394 File Offset: 0x00830594
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_onlineArenaPromotionBattleReport(IntPtr l)
	{
		int result;
		try
		{
			ArenaUITask arenaUITask = (ArenaUITask)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, arenaUITask.m_luaExportHelper.m_onlineArenaPromotionBattleReport);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601B31E RID: 111390 RVA: 0x008323EC File Offset: 0x008305EC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_onlineArenaPromotionBattleReport(IntPtr l)
	{
		int result;
		try
		{
			ArenaUITask arenaUITask = (ArenaUITask)LuaObject.checkSelf(l);
			List<RealTimePVPBattleReport> onlineArenaPromotionBattleReport;
			LuaObject.checkType<List<RealTimePVPBattleReport>>(l, 2, out onlineArenaPromotionBattleReport);
			arenaUITask.m_luaExportHelper.m_onlineArenaPromotionBattleReport = onlineArenaPromotionBattleReport;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601B31F RID: 111391 RVA: 0x00832448 File Offset: 0x00830648
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_offlinePanelType(IntPtr l)
	{
		int result;
		try
		{
			ArenaUITask arenaUITask = (ArenaUITask)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushEnum(l, (int)arenaUITask.m_luaExportHelper.m_offlinePanelType);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601B320 RID: 111392 RVA: 0x008324A0 File Offset: 0x008306A0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_offlinePanelType(IntPtr l)
	{
		int result;
		try
		{
			ArenaUITask arenaUITask = (ArenaUITask)LuaObject.checkSelf(l);
			OfflineArenaPanelType offlinePanelType;
			LuaObject.checkEnum<OfflineArenaPanelType>(l, 2, out offlinePanelType);
			arenaUITask.m_luaExportHelper.m_offlinePanelType = offlinePanelType;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601B321 RID: 111393 RVA: 0x008324FC File Offset: 0x008306FC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_onlinePanelType(IntPtr l)
	{
		int result;
		try
		{
			ArenaUITask arenaUITask = (ArenaUITask)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushEnum(l, (int)arenaUITask.m_luaExportHelper.m_onlinePanelType);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601B322 RID: 111394 RVA: 0x00832554 File Offset: 0x00830754
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_onlinePanelType(IntPtr l)
	{
		int result;
		try
		{
			ArenaUITask arenaUITask = (ArenaUITask)LuaObject.checkSelf(l);
			OnlineArenaPanelType onlinePanelType;
			LuaObject.checkEnum<OnlineArenaPanelType>(l, 2, out onlinePanelType);
			arenaUITask.m_luaExportHelper.m_onlinePanelType = onlinePanelType;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601B323 RID: 111395 RVA: 0x008325B0 File Offset: 0x008307B0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_arenaUIType(IntPtr l)
	{
		int result;
		try
		{
			ArenaUITask arenaUITask = (ArenaUITask)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushEnum(l, (int)arenaUITask.m_luaExportHelper.m_arenaUIType);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601B324 RID: 111396 RVA: 0x00832608 File Offset: 0x00830808
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_arenaUIType(IntPtr l)
	{
		int result;
		try
		{
			ArenaUITask arenaUITask = (ArenaUITask)LuaObject.checkSelf(l);
			ArenaUIType arenaUIType;
			LuaObject.checkEnum<ArenaUIType>(l, 2, out arenaUIType);
			arenaUITask.m_luaExportHelper.m_arenaUIType = arenaUIType;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601B325 RID: 111397 RVA: 0x00832664 File Offset: 0x00830864
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_curArenaOpponentIndex(IntPtr l)
	{
		int result;
		try
		{
			ArenaUITask arenaUITask = (ArenaUITask)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, arenaUITask.m_luaExportHelper.m_curArenaOpponentIndex);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601B326 RID: 111398 RVA: 0x008326BC File Offset: 0x008308BC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_curArenaOpponentIndex(IntPtr l)
	{
		int result;
		try
		{
			ArenaUITask arenaUITask = (ArenaUITask)LuaObject.checkSelf(l);
			int curArenaOpponentIndex;
			LuaObject.checkType(l, 2, out curArenaOpponentIndex);
			arenaUITask.m_luaExportHelper.m_curArenaOpponentIndex = curArenaOpponentIndex;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601B327 RID: 111399 RVA: 0x00832718 File Offset: 0x00830918
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_curArenaBattleReport(IntPtr l)
	{
		int result;
		try
		{
			ArenaUITask arenaUITask = (ArenaUITask)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, arenaUITask.m_luaExportHelper.m_curArenaBattleReport);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601B328 RID: 111400 RVA: 0x00832770 File Offset: 0x00830970
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_curArenaBattleReport(IntPtr l)
	{
		int result;
		try
		{
			ArenaUITask arenaUITask = (ArenaUITask)LuaObject.checkSelf(l);
			ArenaBattleReport curArenaBattleReport;
			LuaObject.checkType<ArenaBattleReport>(l, 2, out curArenaBattleReport);
			arenaUITask.m_luaExportHelper.m_curArenaBattleReport = curArenaBattleReport;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601B329 RID: 111401 RVA: 0x008327CC File Offset: 0x008309CC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_canFlushOfflineTopRankPlayers(IntPtr l)
	{
		int result;
		try
		{
			ArenaUITask arenaUITask = (ArenaUITask)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, arenaUITask.m_luaExportHelper.m_canFlushOfflineTopRankPlayers);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601B32A RID: 111402 RVA: 0x00832824 File Offset: 0x00830A24
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_canFlushOfflineTopRankPlayers(IntPtr l)
	{
		int result;
		try
		{
			ArenaUITask arenaUITask = (ArenaUITask)LuaObject.checkSelf(l);
			bool canFlushOfflineTopRankPlayers;
			LuaObject.checkType(l, 2, out canFlushOfflineTopRankPlayers);
			arenaUITask.m_luaExportHelper.m_canFlushOfflineTopRankPlayers = canFlushOfflineTopRankPlayers;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601B32B RID: 111403 RVA: 0x00832880 File Offset: 0x00830A80
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_canFlushOnlineGlobalTopRankPlayers(IntPtr l)
	{
		int result;
		try
		{
			ArenaUITask arenaUITask = (ArenaUITask)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, arenaUITask.m_luaExportHelper.m_canFlushOnlineGlobalTopRankPlayers);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601B32C RID: 111404 RVA: 0x008328D8 File Offset: 0x00830AD8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_canFlushOnlineGlobalTopRankPlayers(IntPtr l)
	{
		int result;
		try
		{
			ArenaUITask arenaUITask = (ArenaUITask)LuaObject.checkSelf(l);
			bool canFlushOnlineGlobalTopRankPlayers;
			LuaObject.checkType(l, 2, out canFlushOnlineGlobalTopRankPlayers);
			arenaUITask.m_luaExportHelper.m_canFlushOnlineGlobalTopRankPlayers = canFlushOnlineGlobalTopRankPlayers;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601B32D RID: 111405 RVA: 0x00832934 File Offset: 0x00830B34
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_canFlushOnlineLocalTopRankPlayers(IntPtr l)
	{
		int result;
		try
		{
			ArenaUITask arenaUITask = (ArenaUITask)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, arenaUITask.m_luaExportHelper.m_canFlushOnlineLocalTopRankPlayers);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601B32E RID: 111406 RVA: 0x0083298C File Offset: 0x00830B8C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_canFlushOnlineLocalTopRankPlayers(IntPtr l)
	{
		int result;
		try
		{
			ArenaUITask arenaUITask = (ArenaUITask)LuaObject.checkSelf(l);
			bool canFlushOnlineLocalTopRankPlayers;
			LuaObject.checkType(l, 2, out canFlushOnlineLocalTopRankPlayers);
			arenaUITask.m_luaExportHelper.m_canFlushOnlineLocalTopRankPlayers = canFlushOnlineLocalTopRankPlayers;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601B32F RID: 111407 RVA: 0x008329E8 File Offset: 0x00830BE8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_isSwitchingOfflineOnline(IntPtr l)
	{
		int result;
		try
		{
			ArenaUITask arenaUITask = (ArenaUITask)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, arenaUITask.m_luaExportHelper.m_isSwitchingOfflineOnline);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601B330 RID: 111408 RVA: 0x00832A40 File Offset: 0x00830C40
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_isSwitchingOfflineOnline(IntPtr l)
	{
		int result;
		try
		{
			ArenaUITask arenaUITask = (ArenaUITask)LuaObject.checkSelf(l);
			bool isSwitchingOfflineOnline;
			LuaObject.checkType(l, 2, out isSwitchingOfflineOnline);
			arenaUITask.m_luaExportHelper.m_isSwitchingOfflineOnline = isSwitchingOfflineOnline;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601B331 RID: 111409 RVA: 0x00832A9C File Offset: 0x00830C9C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_nowSeconds(IntPtr l)
	{
		int result;
		try
		{
			ArenaUITask arenaUITask = (ArenaUITask)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, arenaUITask.m_luaExportHelper.m_nowSeconds);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601B332 RID: 111410 RVA: 0x00832AF4 File Offset: 0x00830CF4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_nowSeconds(IntPtr l)
	{
		int result;
		try
		{
			ArenaUITask arenaUITask = (ArenaUITask)LuaObject.checkSelf(l);
			int nowSeconds;
			LuaObject.checkType(l, 2, out nowSeconds);
			arenaUITask.m_luaExportHelper.m_nowSeconds = nowSeconds;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601B333 RID: 111411 RVA: 0x00832B50 File Offset: 0x00830D50
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_matchingUIBeginTime(IntPtr l)
	{
		int result;
		try
		{
			ArenaUITask arenaUITask = (ArenaUITask)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, arenaUITask.m_luaExportHelper.m_matchingUIBeginTime);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601B334 RID: 111412 RVA: 0x00832BAC File Offset: 0x00830DAC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_matchingUIBeginTime(IntPtr l)
	{
		int result;
		try
		{
			ArenaUITask arenaUITask = (ArenaUITask)LuaObject.checkSelf(l);
			DateTime matchingUIBeginTime;
			LuaObject.checkValueType<DateTime>(l, 2, out matchingUIBeginTime);
			arenaUITask.m_luaExportHelper.m_matchingUIBeginTime = matchingUIBeginTime;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601B335 RID: 111413 RVA: 0x00832C08 File Offset: 0x00830E08
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_matchingReqSendTime(IntPtr l)
	{
		int result;
		try
		{
			ArenaUITask arenaUITask = (ArenaUITask)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, arenaUITask.m_luaExportHelper.m_matchingReqSendTime);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601B336 RID: 111414 RVA: 0x00832C64 File Offset: 0x00830E64
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_matchingReqSendTime(IntPtr l)
	{
		int result;
		try
		{
			ArenaUITask arenaUITask = (ArenaUITask)LuaObject.checkSelf(l);
			DateTime matchingReqSendTime;
			LuaObject.checkValueType<DateTime>(l, 2, out matchingReqSendTime);
			arenaUITask.m_luaExportHelper.m_matchingReqSendTime = matchingReqSendTime;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601B337 RID: 111415 RVA: 0x00832CC0 File Offset: 0x00830EC0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_matchingBattleMode(IntPtr l)
	{
		int result;
		try
		{
			ArenaUITask arenaUITask = (ArenaUITask)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushEnum(l, (int)arenaUITask.m_luaExportHelper.m_matchingBattleMode);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601B338 RID: 111416 RVA: 0x00832D18 File Offset: 0x00830F18
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_matchingBattleMode(IntPtr l)
	{
		int result;
		try
		{
			ArenaUITask arenaUITask = (ArenaUITask)LuaObject.checkSelf(l);
			BattleMode matchingBattleMode;
			LuaObject.checkEnum<BattleMode>(l, 2, out matchingBattleMode);
			arenaUITask.m_luaExportHelper.m_matchingBattleMode = matchingBattleMode;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601B339 RID: 111417 RVA: 0x00832D74 File Offset: 0x00830F74
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_isNeedCheckOnline(IntPtr l)
	{
		int result;
		try
		{
			ArenaUITask arenaUITask = (ArenaUITask)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, arenaUITask.m_luaExportHelper.m_isNeedCheckOnline);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601B33A RID: 111418 RVA: 0x00832DCC File Offset: 0x00830FCC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_isNeedCheckOnline(IntPtr l)
	{
		int result;
		try
		{
			ArenaUITask arenaUITask = (ArenaUITask)LuaObject.checkSelf(l);
			bool isNeedCheckOnline;
			LuaObject.checkType(l, 2, out isNeedCheckOnline);
			arenaUITask.m_luaExportHelper.m_isNeedCheckOnline = isNeedCheckOnline;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601B33B RID: 111419 RVA: 0x00832E28 File Offset: 0x00831028
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_LayerDescArray(IntPtr l)
	{
		int result;
		try
		{
			ArenaUITask arenaUITask = (ArenaUITask)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, arenaUITask.m_luaExportHelper.LayerDescArray);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601B33C RID: 111420 RVA: 0x00832E80 File Offset: 0x00831080
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_UICtrlDescArray(IntPtr l)
	{
		int result;
		try
		{
			ArenaUITask arenaUITask = (ArenaUITask)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, arenaUITask.m_luaExportHelper.UICtrlDescArray);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601B33D RID: 111421 RVA: 0x00832ED8 File Offset: 0x008310D8
	[Preserve]
	public static void reg(IntPtr l)
	{
		LuaObject.getTypeTable(l, "BlackJack.ProjectL.UI.ArenaUITask");
		if (Lua_BlackJack_ProjectL_UI_ArenaUITask.<>f__mg$cache0 == null)
		{
			Lua_BlackJack_ProjectL_UI_ArenaUITask.<>f__mg$cache0 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ArenaUITask.OnStart);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_ArenaUITask.<>f__mg$cache0);
		if (Lua_BlackJack_ProjectL_UI_ArenaUITask.<>f__mg$cache1 == null)
		{
			Lua_BlackJack_ProjectL_UI_ArenaUITask.<>f__mg$cache1 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ArenaUITask.OnResume);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_ArenaUITask.<>f__mg$cache1);
		if (Lua_BlackJack_ProjectL_UI_ArenaUITask.<>f__mg$cache2 == null)
		{
			Lua_BlackJack_ProjectL_UI_ArenaUITask.<>f__mg$cache2 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ArenaUITask.InitDataFromUIIntent);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_ArenaUITask.<>f__mg$cache2);
		if (Lua_BlackJack_ProjectL_UI_ArenaUITask.<>f__mg$cache3 == null)
		{
			Lua_BlackJack_ProjectL_UI_ArenaUITask.<>f__mg$cache3 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ArenaUITask.IsNeedLoadDynamicRes);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_ArenaUITask.<>f__mg$cache3);
		if (Lua_BlackJack_ProjectL_UI_ArenaUITask.<>f__mg$cache4 == null)
		{
			Lua_BlackJack_ProjectL_UI_ArenaUITask.<>f__mg$cache4 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ArenaUITask.CollectPlayerHeadAssets);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_ArenaUITask.<>f__mg$cache4);
		if (Lua_BlackJack_ProjectL_UI_ArenaUITask.<>f__mg$cache5 == null)
		{
			Lua_BlackJack_ProjectL_UI_ArenaUITask.<>f__mg$cache5 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ArenaUITask.CollectHeroModelAssets);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_ArenaUITask.<>f__mg$cache5);
		if (Lua_BlackJack_ProjectL_UI_ArenaUITask.<>f__mg$cache6 == null)
		{
			Lua_BlackJack_ProjectL_UI_ArenaUITask.<>f__mg$cache6 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ArenaUITask.InitAllUIControllers);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_ArenaUITask.<>f__mg$cache6);
		if (Lua_BlackJack_ProjectL_UI_ArenaUITask.<>f__mg$cache7 == null)
		{
			Lua_BlackJack_ProjectL_UI_ArenaUITask.<>f__mg$cache7 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ArenaUITask.ClearAllContextAndRes);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_ArenaUITask.<>f__mg$cache7);
		if (Lua_BlackJack_ProjectL_UI_ArenaUITask.<>f__mg$cache8 == null)
		{
			Lua_BlackJack_ProjectL_UI_ArenaUITask.<>f__mg$cache8 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ArenaUITask.RegisterPlayerContextEvents);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_ArenaUITask.<>f__mg$cache8);
		if (Lua_BlackJack_ProjectL_UI_ArenaUITask.<>f__mg$cache9 == null)
		{
			Lua_BlackJack_ProjectL_UI_ArenaUITask.<>f__mg$cache9 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ArenaUITask.UnregisterPlayerContextEvents);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_ArenaUITask.<>f__mg$cache9);
		if (Lua_BlackJack_ProjectL_UI_ArenaUITask.<>f__mg$cacheA == null)
		{
			Lua_BlackJack_ProjectL_UI_ArenaUITask.<>f__mg$cacheA = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ArenaUITask.OnStop);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_ArenaUITask.<>f__mg$cacheA);
		if (Lua_BlackJack_ProjectL_UI_ArenaUITask.<>f__mg$cacheB == null)
		{
			Lua_BlackJack_ProjectL_UI_ArenaUITask.<>f__mg$cacheB = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ArenaUITask.InitArenaUIController);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_ArenaUITask.<>f__mg$cacheB);
		if (Lua_BlackJack_ProjectL_UI_ArenaUITask.<>f__mg$cacheC == null)
		{
			Lua_BlackJack_ProjectL_UI_ArenaUITask.<>f__mg$cacheC = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ArenaUITask.UninitArenaUIController);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_ArenaUITask.<>f__mg$cacheC);
		if (Lua_BlackJack_ProjectL_UI_ArenaUITask.<>f__mg$cacheD == null)
		{
			Lua_BlackJack_ProjectL_UI_ArenaUITask.<>f__mg$cacheD = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ArenaUITask.OnMemoryWarning);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_ArenaUITask.<>f__mg$cacheD);
		if (Lua_BlackJack_ProjectL_UI_ArenaUITask.<>f__mg$cacheE == null)
		{
			Lua_BlackJack_ProjectL_UI_ArenaUITask.<>f__mg$cacheE = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ArenaUITask.OnTick);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_ArenaUITask.<>f__mg$cacheE);
		if (Lua_BlackJack_ProjectL_UI_ArenaUITask.<>f__mg$cacheF == null)
		{
			Lua_BlackJack_ProjectL_UI_ArenaUITask.<>f__mg$cacheF = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ArenaUITask.UpdateView);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_ArenaUITask.<>f__mg$cacheF);
		if (Lua_BlackJack_ProjectL_UI_ArenaUITask.<>f__mg$cache10 == null)
		{
			Lua_BlackJack_ProjectL_UI_ArenaUITask.<>f__mg$cache10 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ArenaUITask.UpdatePlayerInfo);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_ArenaUITask.<>f__mg$cache10);
		if (Lua_BlackJack_ProjectL_UI_ArenaUITask.<>f__mg$cache11 == null)
		{
			Lua_BlackJack_ProjectL_UI_ArenaUITask.<>f__mg$cache11 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ArenaUITask.UpdateBattlePower);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_ArenaUITask.<>f__mg$cache11);
		if (Lua_BlackJack_ProjectL_UI_ArenaUITask.<>f__mg$cache12 == null)
		{
			Lua_BlackJack_ProjectL_UI_ArenaUITask.<>f__mg$cache12 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ArenaUITask.StartArenaBattleReportBasicDataGetNetTask);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_ArenaUITask.<>f__mg$cache12);
		if (Lua_BlackJack_ProjectL_UI_ArenaUITask.<>f__mg$cache13 == null)
		{
			Lua_BlackJack_ProjectL_UI_ArenaUITask.<>f__mg$cache13 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ArenaUITask.PlayerResourceUIController_OnAddCrystal);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_ArenaUITask.<>f__mg$cache13);
		if (Lua_BlackJack_ProjectL_UI_ArenaUITask.<>f__mg$cache14 == null)
		{
			Lua_BlackJack_ProjectL_UI_ArenaUITask.<>f__mg$cache14 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ArenaUITask.ArenaUIController_OnDefend);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_ArenaUITask.<>f__mg$cache14);
		if (Lua_BlackJack_ProjectL_UI_ArenaUITask.<>f__mg$cache15 == null)
		{
			Lua_BlackJack_ProjectL_UI_ArenaUITask.<>f__mg$cache15 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ArenaUITask.ArenaDefendUITask_OnLoadAllResCompleted);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_ArenaUITask.<>f__mg$cache15);
		if (Lua_BlackJack_ProjectL_UI_ArenaUITask.<>f__mg$cache16 == null)
		{
			Lua_BlackJack_ProjectL_UI_ArenaUITask.<>f__mg$cache16 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ArenaUITask.ArenaUIController_OnReturn);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_ArenaUITask.<>f__mg$cache16);
		if (Lua_BlackJack_ProjectL_UI_ArenaUITask.<>f__mg$cache17 == null)
		{
			Lua_BlackJack_ProjectL_UI_ArenaUITask.<>f__mg$cache17 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ArenaUITask.ArenaUIController_OnShowHelp);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_ArenaUITask.<>f__mg$cache17);
		if (Lua_BlackJack_ProjectL_UI_ArenaUITask.<>f__mg$cache18 == null)
		{
			Lua_BlackJack_ProjectL_UI_ArenaUITask.<>f__mg$cache18 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ArenaUITask.ArenaUIController_OnShowBuyArenaTicket);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_ArenaUITask.<>f__mg$cache18);
		if (Lua_BlackJack_ProjectL_UI_ArenaUITask.<>f__mg$cache19 == null)
		{
			Lua_BlackJack_ProjectL_UI_ArenaUITask.<>f__mg$cache19 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ArenaUITask.ArenaUIController_OnBuyArenaTicket);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_ArenaUITask.<>f__mg$cache19);
		if (Lua_BlackJack_ProjectL_UI_ArenaUITask.<>f__mg$cache1A == null)
		{
			Lua_BlackJack_ProjectL_UI_ArenaUITask.<>f__mg$cache1A = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ArenaUITask.ArenaUIController_OnSwitchOnlineOffline);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_ArenaUITask.<>f__mg$cache1A);
		if (Lua_BlackJack_ProjectL_UI_ArenaUITask.<>f__mg$cache1B == null)
		{
			Lua_BlackJack_ProjectL_UI_ArenaUITask.<>f__mg$cache1B = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ArenaUITask.ChestUITask_OnStop);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_ArenaUITask.<>f__mg$cache1B);
		if (Lua_BlackJack_ProjectL_UI_ArenaUITask.<>f__mg$cache1C == null)
		{
			Lua_BlackJack_ProjectL_UI_ArenaUITask.<>f__mg$cache1C = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ArenaUITask.ChestUITask_OnClose);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_ArenaUITask.<>f__mg$cache1C);
		if (Lua_BlackJack_ProjectL_UI_ArenaUITask.<>f__mg$cache1D == null)
		{
			Lua_BlackJack_ProjectL_UI_ArenaUITask.<>f__mg$cache1D = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ArenaUITask.CollectOfflineArenaAssets);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_ArenaUITask.<>f__mg$cache1D);
		if (Lua_BlackJack_ProjectL_UI_ArenaUITask.<>f__mg$cache1E == null)
		{
			Lua_BlackJack_ProjectL_UI_ArenaUITask.<>f__mg$cache1E = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ArenaUITask.UpdateOfflineArena);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_ArenaUITask.<>f__mg$cache1E);
		if (Lua_BlackJack_ProjectL_UI_ArenaUITask.<>f__mg$cache1F == null)
		{
			Lua_BlackJack_ProjectL_UI_ArenaUITask.<>f__mg$cache1F = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ArenaUITask.UpdateOfflineArenaOpponentRefreshTime);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_ArenaUITask.<>f__mg$cache1F);
		if (Lua_BlackJack_ProjectL_UI_ArenaUITask.<>f__mg$cache20 == null)
		{
			Lua_BlackJack_ProjectL_UI_ArenaUITask.<>f__mg$cache20 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ArenaUITask.FlushOfflineTopRankPlayers);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_ArenaUITask.<>f__mg$cache20);
		if (Lua_BlackJack_ProjectL_UI_ArenaUITask.<>f__mg$cache21 == null)
		{
			Lua_BlackJack_ProjectL_UI_ArenaUITask.<>f__mg$cache21 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ArenaUITask.AutoGetOfflineVictoryPointReward);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_ArenaUITask.<>f__mg$cache21);
		if (Lua_BlackJack_ProjectL_UI_ArenaUITask.<>f__mg$cache22 == null)
		{
			Lua_BlackJack_ProjectL_UI_ArenaUITask.<>f__mg$cache22 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ArenaUITask.ArenaUIController_OnShowOfflinePanel);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_ArenaUITask.<>f__mg$cache22);
		if (Lua_BlackJack_ProjectL_UI_ArenaUITask.<>f__mg$cache23 == null)
		{
			Lua_BlackJack_ProjectL_UI_ArenaUITask.<>f__mg$cache23 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ArenaUITask.ArenaUIController_OnGainOfflineVictoryPointsReward);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_ArenaUITask.<>f__mg$cache23);
		if (Lua_BlackJack_ProjectL_UI_ArenaUITask.<>f__mg$cache24 == null)
		{
			Lua_BlackJack_ProjectL_UI_ArenaUITask.<>f__mg$cache24 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ArenaUITask.ArenaUIController_OnShowOfflineArenaOpponent);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_ArenaUITask.<>f__mg$cache24);
		if (Lua_BlackJack_ProjectL_UI_ArenaUITask.<>f__mg$cache25 == null)
		{
			Lua_BlackJack_ProjectL_UI_ArenaUITask.<>f__mg$cache25 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ArenaUITask.ArenaUIController_OnAttackOfflineArenaOpponent);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_ArenaUITask.<>f__mg$cache25);
		if (Lua_BlackJack_ProjectL_UI_ArenaUITask.<>f__mg$cache26 == null)
		{
			Lua_BlackJack_ProjectL_UI_ArenaUITask.<>f__mg$cache26 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ArenaUITask.ArenaUIController_OnShowRevengeOfflineArenaOpponent);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_ArenaUITask.<>f__mg$cache26);
		if (Lua_BlackJack_ProjectL_UI_ArenaUITask.<>f__mg$cache27 == null)
		{
			Lua_BlackJack_ProjectL_UI_ArenaUITask.<>f__mg$cache27 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ArenaUITask.ArenaUIController_OnRevengeOfflineArenaOpponent);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_ArenaUITask.<>f__mg$cache27);
		if (Lua_BlackJack_ProjectL_UI_ArenaUITask.<>f__mg$cache28 == null)
		{
			Lua_BlackJack_ProjectL_UI_ArenaUITask.<>f__mg$cache28 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ArenaUITask.ArenaUIController_OnOfflineBattleReportReplay);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_ArenaUITask.<>f__mg$cache28);
		if (Lua_BlackJack_ProjectL_UI_ArenaUITask.<>f__mg$cache29 == null)
		{
			Lua_BlackJack_ProjectL_UI_ArenaUITask.<>f__mg$cache29 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ArenaUITask.PlayerContext_OnArenaFlushOpponentsNtf);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_ArenaUITask.<>f__mg$cache29);
		if (Lua_BlackJack_ProjectL_UI_ArenaUITask.<>f__mg$cache2A == null)
		{
			Lua_BlackJack_ProjectL_UI_ArenaUITask.<>f__mg$cache2A = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ArenaUITask.CollectOnlineArenaAssets);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_ArenaUITask.<>f__mg$cache2A);
		if (Lua_BlackJack_ProjectL_UI_ArenaUITask.<>f__mg$cache2B == null)
		{
			Lua_BlackJack_ProjectL_UI_ArenaUITask.<>f__mg$cache2B = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ArenaUITask.UpdateOnlineArena);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_ArenaUITask.<>f__mg$cache2B);
		if (Lua_BlackJack_ProjectL_UI_ArenaUITask.<>f__mg$cache2C == null)
		{
			Lua_BlackJack_ProjectL_UI_ArenaUITask.<>f__mg$cache2C = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ArenaUITask.UpdateOnlineMatchingTime);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_ArenaUITask.<>f__mg$cache2C);
		if (Lua_BlackJack_ProjectL_UI_ArenaUITask.<>f__mg$cache2D == null)
		{
			Lua_BlackJack_ProjectL_UI_ArenaUITask.<>f__mg$cache2D = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ArenaUITask.UpdateLadderMode);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_ArenaUITask.<>f__mg$cache2D);
		if (Lua_BlackJack_ProjectL_UI_ArenaUITask.<>f__mg$cache2E == null)
		{
			Lua_BlackJack_ProjectL_UI_ArenaUITask.<>f__mg$cache2E = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ArenaUITask.FlushOnlineTopRankPlayers);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_ArenaUITask.<>f__mg$cache2E);
		if (Lua_BlackJack_ProjectL_UI_ArenaUITask.<>f__mg$cache2F == null)
		{
			Lua_BlackJack_ProjectL_UI_ArenaUITask.<>f__mg$cache2F = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ArenaUITask.StartRealTimePVPGetInfoNetTask);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_ArenaUITask.<>f__mg$cache2F);
		if (Lua_BlackJack_ProjectL_UI_ArenaUITask.<>f__mg$cache30 == null)
		{
			Lua_BlackJack_ProjectL_UI_ArenaUITask.<>f__mg$cache30 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ArenaUITask.StartRealTimePVPGetTopPlayersNetTask);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_ArenaUITask.<>f__mg$cache30);
		if (Lua_BlackJack_ProjectL_UI_ArenaUITask.<>f__mg$cache31 == null)
		{
			Lua_BlackJack_ProjectL_UI_ArenaUITask.<>f__mg$cache31 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ArenaUITask.AutoGetOnlineWeekWinReward);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_ArenaUITask.<>f__mg$cache31);
		if (Lua_BlackJack_ProjectL_UI_ArenaUITask.<>f__mg$cache32 == null)
		{
			Lua_BlackJack_ProjectL_UI_ArenaUITask.<>f__mg$cache32 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ArenaUITask.StartRealTimePVPWaitingForOpponentNetTask);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_ArenaUITask.<>f__mg$cache32);
		if (Lua_BlackJack_ProjectL_UI_ArenaUITask.<>f__mg$cache33 == null)
		{
			Lua_BlackJack_ProjectL_UI_ArenaUITask.<>f__mg$cache33 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ArenaUITask.StartMatchiing);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_ArenaUITask.<>f__mg$cache33);
		if (Lua_BlackJack_ProjectL_UI_ArenaUITask.<>f__mg$cache34 == null)
		{
			Lua_BlackJack_ProjectL_UI_ArenaUITask.<>f__mg$cache34 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ArenaUITask.ArenaUIController_OnShowOnlinePanel);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_ArenaUITask.<>f__mg$cache34);
		if (Lua_BlackJack_ProjectL_UI_ArenaUITask.<>f__mg$cache35 == null)
		{
			Lua_BlackJack_ProjectL_UI_ArenaUITask.<>f__mg$cache35 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ArenaUITask.ArenaUIController_OnGainOnlineWeekWinReward);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_ArenaUITask.<>f__mg$cache35);
		if (Lua_BlackJack_ProjectL_UI_ArenaUITask.<>f__mg$cache36 == null)
		{
			Lua_BlackJack_ProjectL_UI_ArenaUITask.<>f__mg$cache36 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ArenaUITask.ArenaUIController_OnOnlineBattleReportReplay);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_ArenaUITask.<>f__mg$cache36);
		if (Lua_BlackJack_ProjectL_UI_ArenaUITask.<>f__mg$cache37 == null)
		{
			Lua_BlackJack_ProjectL_UI_ArenaUITask.<>f__mg$cache37 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ArenaUITask.ArenaUIController_OnLadderChallenge);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_ArenaUITask.<>f__mg$cache37);
		if (Lua_BlackJack_ProjectL_UI_ArenaUITask.<>f__mg$cache38 == null)
		{
			Lua_BlackJack_ProjectL_UI_ArenaUITask.<>f__mg$cache38 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ArenaUITask.ArenaUIController_OnCasualChallenge);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_ArenaUITask.<>f__mg$cache38);
		if (Lua_BlackJack_ProjectL_UI_ArenaUITask.<>f__mg$cache39 == null)
		{
			Lua_BlackJack_ProjectL_UI_ArenaUITask.<>f__mg$cache39 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ArenaUITask.ArenaUIController_OnMatchingCancel);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_ArenaUITask.<>f__mg$cache39);
		if (Lua_BlackJack_ProjectL_UI_ArenaUITask.<>f__mg$cache3A == null)
		{
			Lua_BlackJack_ProjectL_UI_ArenaUITask.<>f__mg$cache3A = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ArenaUITask.PlayerContext_OnRealTimePVPMatchupNtf);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_ArenaUITask.<>f__mg$cache3A);
		if (Lua_BlackJack_ProjectL_UI_ArenaUITask.<>f__mg$cache3B == null)
		{
			Lua_BlackJack_ProjectL_UI_ArenaUITask.<>f__mg$cache3B = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ArenaUITask.__callBase_OnStart);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_ArenaUITask.<>f__mg$cache3B);
		if (Lua_BlackJack_ProjectL_UI_ArenaUITask.<>f__mg$cache3C == null)
		{
			Lua_BlackJack_ProjectL_UI_ArenaUITask.<>f__mg$cache3C = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ArenaUITask.__callBase_OnStop);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_ArenaUITask.<>f__mg$cache3C);
		if (Lua_BlackJack_ProjectL_UI_ArenaUITask.<>f__mg$cache3D == null)
		{
			Lua_BlackJack_ProjectL_UI_ArenaUITask.<>f__mg$cache3D = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ArenaUITask.__callBase_OnPause);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_ArenaUITask.<>f__mg$cache3D);
		if (Lua_BlackJack_ProjectL_UI_ArenaUITask.<>f__mg$cache3E == null)
		{
			Lua_BlackJack_ProjectL_UI_ArenaUITask.<>f__mg$cache3E = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ArenaUITask.__callBase_OnResume);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_ArenaUITask.<>f__mg$cache3E);
		if (Lua_BlackJack_ProjectL_UI_ArenaUITask.<>f__mg$cache3F == null)
		{
			Lua_BlackJack_ProjectL_UI_ArenaUITask.<>f__mg$cache3F = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ArenaUITask.__callBase_OnNewIntent);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_ArenaUITask.<>f__mg$cache3F);
		if (Lua_BlackJack_ProjectL_UI_ArenaUITask.<>f__mg$cache40 == null)
		{
			Lua_BlackJack_ProjectL_UI_ArenaUITask.<>f__mg$cache40 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ArenaUITask.__callBase_EnableUIInput);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_ArenaUITask.<>f__mg$cache40);
		if (Lua_BlackJack_ProjectL_UI_ArenaUITask.<>f__mg$cache41 == null)
		{
			Lua_BlackJack_ProjectL_UI_ArenaUITask.<>f__mg$cache41 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ArenaUITask.__callBase_IsNeedLoadDynamicRes);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_ArenaUITask.<>f__mg$cache41);
		if (Lua_BlackJack_ProjectL_UI_ArenaUITask.<>f__mg$cache42 == null)
		{
			Lua_BlackJack_ProjectL_UI_ArenaUITask.<>f__mg$cache42 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ArenaUITask.__callBase_CollectAllDynamicResForLoad);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_ArenaUITask.<>f__mg$cache42);
		if (Lua_BlackJack_ProjectL_UI_ArenaUITask.<>f__mg$cache43 == null)
		{
			Lua_BlackJack_ProjectL_UI_ArenaUITask.<>f__mg$cache43 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ArenaUITask.__callBase_RegisterPlayerContextEvents);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_ArenaUITask.<>f__mg$cache43);
		if (Lua_BlackJack_ProjectL_UI_ArenaUITask.<>f__mg$cache44 == null)
		{
			Lua_BlackJack_ProjectL_UI_ArenaUITask.<>f__mg$cache44 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ArenaUITask.__callBase_UnregisterPlayerContextEvents);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_ArenaUITask.<>f__mg$cache44);
		if (Lua_BlackJack_ProjectL_UI_ArenaUITask.<>f__mg$cache45 == null)
		{
			Lua_BlackJack_ProjectL_UI_ArenaUITask.<>f__mg$cache45 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ArenaUITask.__callBase_PostUpdateView);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_ArenaUITask.<>f__mg$cache45);
		if (Lua_BlackJack_ProjectL_UI_ArenaUITask.<>f__mg$cache46 == null)
		{
			Lua_BlackJack_ProjectL_UI_ArenaUITask.<>f__mg$cache46 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ArenaUITask.__callBase_CollectPreloadResourceList);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_ArenaUITask.<>f__mg$cache46);
		if (Lua_BlackJack_ProjectL_UI_ArenaUITask.<>f__mg$cache47 == null)
		{
			Lua_BlackJack_ProjectL_UI_ArenaUITask.<>f__mg$cache47 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ArenaUITask.__callBase_ClearAssetList);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_ArenaUITask.<>f__mg$cache47);
		if (Lua_BlackJack_ProjectL_UI_ArenaUITask.<>f__mg$cache48 == null)
		{
			Lua_BlackJack_ProjectL_UI_ArenaUITask.<>f__mg$cache48 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ArenaUITask.__callBase_CollectAsset);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_ArenaUITask.<>f__mg$cache48);
		if (Lua_BlackJack_ProjectL_UI_ArenaUITask.<>f__mg$cache49 == null)
		{
			Lua_BlackJack_ProjectL_UI_ArenaUITask.<>f__mg$cache49 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ArenaUITask.__callBase_CollectSpriteAsset);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_ArenaUITask.<>f__mg$cache49);
		if (Lua_BlackJack_ProjectL_UI_ArenaUITask.<>f__mg$cache4A == null)
		{
			Lua_BlackJack_ProjectL_UI_ArenaUITask.<>f__mg$cache4A = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ArenaUITask.__callBase_CollectFxAsset);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_ArenaUITask.<>f__mg$cache4A);
		if (Lua_BlackJack_ProjectL_UI_ArenaUITask.<>f__mg$cache4B == null)
		{
			Lua_BlackJack_ProjectL_UI_ArenaUITask.<>f__mg$cache4B = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ArenaUITask.__callBase_StartLoadCustomAssets);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_ArenaUITask.<>f__mg$cache4B);
		if (Lua_BlackJack_ProjectL_UI_ArenaUITask.<>f__mg$cache4C == null)
		{
			Lua_BlackJack_ProjectL_UI_ArenaUITask.<>f__mg$cache4C = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ArenaUITask.__callBase_IsLoadingCustomAssets);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_ArenaUITask.<>f__mg$cache4C);
		if (Lua_BlackJack_ProjectL_UI_ArenaUITask.<>f__mg$cache4D == null)
		{
			Lua_BlackJack_ProjectL_UI_ArenaUITask.<>f__mg$cache4D = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ArenaUITask.__callBase_IsPipeLineRunning);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_ArenaUITask.<>f__mg$cache4D);
		if (Lua_BlackJack_ProjectL_UI_ArenaUITask.<>f__mg$cache4E == null)
		{
			Lua_BlackJack_ProjectL_UI_ArenaUITask.<>f__mg$cache4E = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ArenaUITask.__callBase_IsOpeningUI);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_ArenaUITask.<>f__mg$cache4E);
		if (Lua_BlackJack_ProjectL_UI_ArenaUITask.<>f__mg$cache4F == null)
		{
			Lua_BlackJack_ProjectL_UI_ArenaUITask.<>f__mg$cache4F = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ArenaUITask.__callBase_ReturnPrevUITask);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_ArenaUITask.<>f__mg$cache4F);
		if (Lua_BlackJack_ProjectL_UI_ArenaUITask.<>f__mg$cache50 == null)
		{
			Lua_BlackJack_ProjectL_UI_ArenaUITask.<>f__mg$cache50 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ArenaUITask.__callBase_ClearUnusedDynamicResourceCache);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_ArenaUITask.<>f__mg$cache50);
		if (Lua_BlackJack_ProjectL_UI_ArenaUITask.<>f__mg$cache51 == null)
		{
			Lua_BlackJack_ProjectL_UI_ArenaUITask.<>f__mg$cache51 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ArenaUITask.__callBase_OnMemoryWarning);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_ArenaUITask.<>f__mg$cache51);
		if (Lua_BlackJack_ProjectL_UI_ArenaUITask.<>f__mg$cache52 == null)
		{
			Lua_BlackJack_ProjectL_UI_ArenaUITask.<>f__mg$cache52 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ArenaUITask.__callDele_EventOnStartArenaBattle);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_ArenaUITask.<>f__mg$cache52);
		if (Lua_BlackJack_ProjectL_UI_ArenaUITask.<>f__mg$cache53 == null)
		{
			Lua_BlackJack_ProjectL_UI_ArenaUITask.<>f__mg$cache53 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ArenaUITask.__clearDele_EventOnStartArenaBattle);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_ArenaUITask.<>f__mg$cache53);
		if (Lua_BlackJack_ProjectL_UI_ArenaUITask.<>f__mg$cache54 == null)
		{
			Lua_BlackJack_ProjectL_UI_ArenaUITask.<>f__mg$cache54 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ArenaUITask.__callDele_EventOnStartArenaBattleReplay);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_ArenaUITask.<>f__mg$cache54);
		if (Lua_BlackJack_ProjectL_UI_ArenaUITask.<>f__mg$cache55 == null)
		{
			Lua_BlackJack_ProjectL_UI_ArenaUITask.<>f__mg$cache55 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ArenaUITask.__clearDele_EventOnStartArenaBattleReplay);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_ArenaUITask.<>f__mg$cache55);
		if (Lua_BlackJack_ProjectL_UI_ArenaUITask.<>f__mg$cache56 == null)
		{
			Lua_BlackJack_ProjectL_UI_ArenaUITask.<>f__mg$cache56 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ArenaUITask.__callDele_EventOnStartRealTimePVPBattleReplay);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_ArenaUITask.<>f__mg$cache56);
		if (Lua_BlackJack_ProjectL_UI_ArenaUITask.<>f__mg$cache57 == null)
		{
			Lua_BlackJack_ProjectL_UI_ArenaUITask.<>f__mg$cache57 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ArenaUITask.__clearDele_EventOnStartRealTimePVPBattleReplay);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_ArenaUITask.<>f__mg$cache57);
		if (Lua_BlackJack_ProjectL_UI_ArenaUITask.<>f__mg$cache58 == null)
		{
			Lua_BlackJack_ProjectL_UI_ArenaUITask.<>f__mg$cache58 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ArenaUITask.CompareHeroBattlePower_s);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_ArenaUITask.<>f__mg$cache58);
		if (Lua_BlackJack_ProjectL_UI_ArenaUITask.<>f__mg$cache59 == null)
		{
			Lua_BlackJack_ProjectL_UI_ArenaUITask.<>f__mg$cache59 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ArenaUITask.CompareArenaBattleReportsByCreateTime_s);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_ArenaUITask.<>f__mg$cache59);
		if (Lua_BlackJack_ProjectL_UI_ArenaUITask.<>f__mg$cache5A == null)
		{
			Lua_BlackJack_ProjectL_UI_ArenaUITask.<>f__mg$cache5A = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ArenaUITask.CompareRealTimePVPBattleReportsByCreateTime_s);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_ArenaUITask.<>f__mg$cache5A);
		if (Lua_BlackJack_ProjectL_UI_ArenaUITask.<>f__mg$cache5B == null)
		{
			Lua_BlackJack_ProjectL_UI_ArenaUITask.<>f__mg$cache5B = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ArenaUITask.IsBattleReportAttackerGiveup_s);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_ArenaUITask.<>f__mg$cache5B);
		if (Lua_BlackJack_ProjectL_UI_ArenaUITask.<>f__mg$cache5C == null)
		{
			Lua_BlackJack_ProjectL_UI_ArenaUITask.<>f__mg$cache5C = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ArenaUITask.IsBattleReportPlayerGiveup_s);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_ArenaUITask.<>f__mg$cache5C);
		string name = "EventOnStartArenaBattle";
		LuaCSFunction get = null;
		if (Lua_BlackJack_ProjectL_UI_ArenaUITask.<>f__mg$cache5D == null)
		{
			Lua_BlackJack_ProjectL_UI_ArenaUITask.<>f__mg$cache5D = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ArenaUITask.set_EventOnStartArenaBattle);
		}
		LuaObject.addMember(l, name, get, Lua_BlackJack_ProjectL_UI_ArenaUITask.<>f__mg$cache5D, true);
		string name2 = "EventOnStartArenaBattleReplay";
		LuaCSFunction get2 = null;
		if (Lua_BlackJack_ProjectL_UI_ArenaUITask.<>f__mg$cache5E == null)
		{
			Lua_BlackJack_ProjectL_UI_ArenaUITask.<>f__mg$cache5E = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ArenaUITask.set_EventOnStartArenaBattleReplay);
		}
		LuaObject.addMember(l, name2, get2, Lua_BlackJack_ProjectL_UI_ArenaUITask.<>f__mg$cache5E, true);
		string name3 = "EventOnStartRealTimePVPBattleReplay";
		LuaCSFunction get3 = null;
		if (Lua_BlackJack_ProjectL_UI_ArenaUITask.<>f__mg$cache5F == null)
		{
			Lua_BlackJack_ProjectL_UI_ArenaUITask.<>f__mg$cache5F = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ArenaUITask.set_EventOnStartRealTimePVPBattleReplay);
		}
		LuaObject.addMember(l, name3, get3, Lua_BlackJack_ProjectL_UI_ArenaUITask.<>f__mg$cache5F, true);
		string name4 = "m_layerDescArray";
		if (Lua_BlackJack_ProjectL_UI_ArenaUITask.<>f__mg$cache60 == null)
		{
			Lua_BlackJack_ProjectL_UI_ArenaUITask.<>f__mg$cache60 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ArenaUITask.get_m_layerDescArray);
		}
		LuaCSFunction get4 = Lua_BlackJack_ProjectL_UI_ArenaUITask.<>f__mg$cache60;
		if (Lua_BlackJack_ProjectL_UI_ArenaUITask.<>f__mg$cache61 == null)
		{
			Lua_BlackJack_ProjectL_UI_ArenaUITask.<>f__mg$cache61 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ArenaUITask.set_m_layerDescArray);
		}
		LuaObject.addMember(l, name4, get4, Lua_BlackJack_ProjectL_UI_ArenaUITask.<>f__mg$cache61, true);
		string name5 = "m_uiCtrlDescArray";
		if (Lua_BlackJack_ProjectL_UI_ArenaUITask.<>f__mg$cache62 == null)
		{
			Lua_BlackJack_ProjectL_UI_ArenaUITask.<>f__mg$cache62 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ArenaUITask.get_m_uiCtrlDescArray);
		}
		LuaCSFunction get5 = Lua_BlackJack_ProjectL_UI_ArenaUITask.<>f__mg$cache62;
		if (Lua_BlackJack_ProjectL_UI_ArenaUITask.<>f__mg$cache63 == null)
		{
			Lua_BlackJack_ProjectL_UI_ArenaUITask.<>f__mg$cache63 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ArenaUITask.set_m_uiCtrlDescArray);
		}
		LuaObject.addMember(l, name5, get5, Lua_BlackJack_ProjectL_UI_ArenaUITask.<>f__mg$cache63, true);
		string name6 = "m_arenaUIController";
		if (Lua_BlackJack_ProjectL_UI_ArenaUITask.<>f__mg$cache64 == null)
		{
			Lua_BlackJack_ProjectL_UI_ArenaUITask.<>f__mg$cache64 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ArenaUITask.get_m_arenaUIController);
		}
		LuaCSFunction get6 = Lua_BlackJack_ProjectL_UI_ArenaUITask.<>f__mg$cache64;
		if (Lua_BlackJack_ProjectL_UI_ArenaUITask.<>f__mg$cache65 == null)
		{
			Lua_BlackJack_ProjectL_UI_ArenaUITask.<>f__mg$cache65 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ArenaUITask.set_m_arenaUIController);
		}
		LuaObject.addMember(l, name6, get6, Lua_BlackJack_ProjectL_UI_ArenaUITask.<>f__mg$cache65, true);
		string name7 = "m_playerResourceUIController";
		if (Lua_BlackJack_ProjectL_UI_ArenaUITask.<>f__mg$cache66 == null)
		{
			Lua_BlackJack_ProjectL_UI_ArenaUITask.<>f__mg$cache66 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ArenaUITask.get_m_playerResourceUIController);
		}
		LuaCSFunction get7 = Lua_BlackJack_ProjectL_UI_ArenaUITask.<>f__mg$cache66;
		if (Lua_BlackJack_ProjectL_UI_ArenaUITask.<>f__mg$cache67 == null)
		{
			Lua_BlackJack_ProjectL_UI_ArenaUITask.<>f__mg$cache67 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ArenaUITask.set_m_playerResourceUIController);
		}
		LuaObject.addMember(l, name7, get7, Lua_BlackJack_ProjectL_UI_ArenaUITask.<>f__mg$cache67, true);
		string name8 = "m_arenaDefendUITask";
		if (Lua_BlackJack_ProjectL_UI_ArenaUITask.<>f__mg$cache68 == null)
		{
			Lua_BlackJack_ProjectL_UI_ArenaUITask.<>f__mg$cache68 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ArenaUITask.get_m_arenaDefendUITask);
		}
		LuaCSFunction get8 = Lua_BlackJack_ProjectL_UI_ArenaUITask.<>f__mg$cache68;
		if (Lua_BlackJack_ProjectL_UI_ArenaUITask.<>f__mg$cache69 == null)
		{
			Lua_BlackJack_ProjectL_UI_ArenaUITask.<>f__mg$cache69 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ArenaUITask.set_m_arenaDefendUITask);
		}
		LuaObject.addMember(l, name8, get8, Lua_BlackJack_ProjectL_UI_ArenaUITask.<>f__mg$cache69, true);
		string name9 = "m_chestUITask";
		if (Lua_BlackJack_ProjectL_UI_ArenaUITask.<>f__mg$cache6A == null)
		{
			Lua_BlackJack_ProjectL_UI_ArenaUITask.<>f__mg$cache6A = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ArenaUITask.get_m_chestUITask);
		}
		LuaCSFunction get9 = Lua_BlackJack_ProjectL_UI_ArenaUITask.<>f__mg$cache6A;
		if (Lua_BlackJack_ProjectL_UI_ArenaUITask.<>f__mg$cache6B == null)
		{
			Lua_BlackJack_ProjectL_UI_ArenaUITask.<>f__mg$cache6B = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ArenaUITask.set_m_chestUITask);
		}
		LuaObject.addMember(l, name9, get9, Lua_BlackJack_ProjectL_UI_ArenaUITask.<>f__mg$cache6B, true);
		string name10 = "m_realTimePVPDans";
		if (Lua_BlackJack_ProjectL_UI_ArenaUITask.<>f__mg$cache6C == null)
		{
			Lua_BlackJack_ProjectL_UI_ArenaUITask.<>f__mg$cache6C = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ArenaUITask.get_m_realTimePVPDans);
		}
		LuaCSFunction get10 = Lua_BlackJack_ProjectL_UI_ArenaUITask.<>f__mg$cache6C;
		if (Lua_BlackJack_ProjectL_UI_ArenaUITask.<>f__mg$cache6D == null)
		{
			Lua_BlackJack_ProjectL_UI_ArenaUITask.<>f__mg$cache6D = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ArenaUITask.set_m_realTimePVPDans);
		}
		LuaObject.addMember(l, name10, get10, Lua_BlackJack_ProjectL_UI_ArenaUITask.<>f__mg$cache6D, true);
		string name11 = "m_arenaOpponents";
		if (Lua_BlackJack_ProjectL_UI_ArenaUITask.<>f__mg$cache6E == null)
		{
			Lua_BlackJack_ProjectL_UI_ArenaUITask.<>f__mg$cache6E = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ArenaUITask.get_m_arenaOpponents);
		}
		LuaCSFunction get11 = Lua_BlackJack_ProjectL_UI_ArenaUITask.<>f__mg$cache6E;
		if (Lua_BlackJack_ProjectL_UI_ArenaUITask.<>f__mg$cache6F == null)
		{
			Lua_BlackJack_ProjectL_UI_ArenaUITask.<>f__mg$cache6F = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ArenaUITask.set_m_arenaOpponents);
		}
		LuaObject.addMember(l, name11, get11, Lua_BlackJack_ProjectL_UI_ArenaUITask.<>f__mg$cache6F, true);
		string name12 = "m_offlineArenaBattleReport";
		if (Lua_BlackJack_ProjectL_UI_ArenaUITask.<>f__mg$cache70 == null)
		{
			Lua_BlackJack_ProjectL_UI_ArenaUITask.<>f__mg$cache70 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ArenaUITask.get_m_offlineArenaBattleReport);
		}
		LuaCSFunction get12 = Lua_BlackJack_ProjectL_UI_ArenaUITask.<>f__mg$cache70;
		if (Lua_BlackJack_ProjectL_UI_ArenaUITask.<>f__mg$cache71 == null)
		{
			Lua_BlackJack_ProjectL_UI_ArenaUITask.<>f__mg$cache71 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ArenaUITask.set_m_offlineArenaBattleReport);
		}
		LuaObject.addMember(l, name12, get12, Lua_BlackJack_ProjectL_UI_ArenaUITask.<>f__mg$cache71, true);
		string name13 = "m_onlineArenaBattleReport";
		if (Lua_BlackJack_ProjectL_UI_ArenaUITask.<>f__mg$cache72 == null)
		{
			Lua_BlackJack_ProjectL_UI_ArenaUITask.<>f__mg$cache72 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ArenaUITask.get_m_onlineArenaBattleReport);
		}
		LuaCSFunction get13 = Lua_BlackJack_ProjectL_UI_ArenaUITask.<>f__mg$cache72;
		if (Lua_BlackJack_ProjectL_UI_ArenaUITask.<>f__mg$cache73 == null)
		{
			Lua_BlackJack_ProjectL_UI_ArenaUITask.<>f__mg$cache73 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ArenaUITask.set_m_onlineArenaBattleReport);
		}
		LuaObject.addMember(l, name13, get13, Lua_BlackJack_ProjectL_UI_ArenaUITask.<>f__mg$cache73, true);
		string name14 = "m_onlineArenaPromotionBattleReport";
		if (Lua_BlackJack_ProjectL_UI_ArenaUITask.<>f__mg$cache74 == null)
		{
			Lua_BlackJack_ProjectL_UI_ArenaUITask.<>f__mg$cache74 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ArenaUITask.get_m_onlineArenaPromotionBattleReport);
		}
		LuaCSFunction get14 = Lua_BlackJack_ProjectL_UI_ArenaUITask.<>f__mg$cache74;
		if (Lua_BlackJack_ProjectL_UI_ArenaUITask.<>f__mg$cache75 == null)
		{
			Lua_BlackJack_ProjectL_UI_ArenaUITask.<>f__mg$cache75 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ArenaUITask.set_m_onlineArenaPromotionBattleReport);
		}
		LuaObject.addMember(l, name14, get14, Lua_BlackJack_ProjectL_UI_ArenaUITask.<>f__mg$cache75, true);
		string name15 = "m_offlinePanelType";
		if (Lua_BlackJack_ProjectL_UI_ArenaUITask.<>f__mg$cache76 == null)
		{
			Lua_BlackJack_ProjectL_UI_ArenaUITask.<>f__mg$cache76 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ArenaUITask.get_m_offlinePanelType);
		}
		LuaCSFunction get15 = Lua_BlackJack_ProjectL_UI_ArenaUITask.<>f__mg$cache76;
		if (Lua_BlackJack_ProjectL_UI_ArenaUITask.<>f__mg$cache77 == null)
		{
			Lua_BlackJack_ProjectL_UI_ArenaUITask.<>f__mg$cache77 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ArenaUITask.set_m_offlinePanelType);
		}
		LuaObject.addMember(l, name15, get15, Lua_BlackJack_ProjectL_UI_ArenaUITask.<>f__mg$cache77, true);
		string name16 = "m_onlinePanelType";
		if (Lua_BlackJack_ProjectL_UI_ArenaUITask.<>f__mg$cache78 == null)
		{
			Lua_BlackJack_ProjectL_UI_ArenaUITask.<>f__mg$cache78 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ArenaUITask.get_m_onlinePanelType);
		}
		LuaCSFunction get16 = Lua_BlackJack_ProjectL_UI_ArenaUITask.<>f__mg$cache78;
		if (Lua_BlackJack_ProjectL_UI_ArenaUITask.<>f__mg$cache79 == null)
		{
			Lua_BlackJack_ProjectL_UI_ArenaUITask.<>f__mg$cache79 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ArenaUITask.set_m_onlinePanelType);
		}
		LuaObject.addMember(l, name16, get16, Lua_BlackJack_ProjectL_UI_ArenaUITask.<>f__mg$cache79, true);
		string name17 = "m_arenaUIType";
		if (Lua_BlackJack_ProjectL_UI_ArenaUITask.<>f__mg$cache7A == null)
		{
			Lua_BlackJack_ProjectL_UI_ArenaUITask.<>f__mg$cache7A = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ArenaUITask.get_m_arenaUIType);
		}
		LuaCSFunction get17 = Lua_BlackJack_ProjectL_UI_ArenaUITask.<>f__mg$cache7A;
		if (Lua_BlackJack_ProjectL_UI_ArenaUITask.<>f__mg$cache7B == null)
		{
			Lua_BlackJack_ProjectL_UI_ArenaUITask.<>f__mg$cache7B = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ArenaUITask.set_m_arenaUIType);
		}
		LuaObject.addMember(l, name17, get17, Lua_BlackJack_ProjectL_UI_ArenaUITask.<>f__mg$cache7B, true);
		string name18 = "m_curArenaOpponentIndex";
		if (Lua_BlackJack_ProjectL_UI_ArenaUITask.<>f__mg$cache7C == null)
		{
			Lua_BlackJack_ProjectL_UI_ArenaUITask.<>f__mg$cache7C = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ArenaUITask.get_m_curArenaOpponentIndex);
		}
		LuaCSFunction get18 = Lua_BlackJack_ProjectL_UI_ArenaUITask.<>f__mg$cache7C;
		if (Lua_BlackJack_ProjectL_UI_ArenaUITask.<>f__mg$cache7D == null)
		{
			Lua_BlackJack_ProjectL_UI_ArenaUITask.<>f__mg$cache7D = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ArenaUITask.set_m_curArenaOpponentIndex);
		}
		LuaObject.addMember(l, name18, get18, Lua_BlackJack_ProjectL_UI_ArenaUITask.<>f__mg$cache7D, true);
		string name19 = "m_curArenaBattleReport";
		if (Lua_BlackJack_ProjectL_UI_ArenaUITask.<>f__mg$cache7E == null)
		{
			Lua_BlackJack_ProjectL_UI_ArenaUITask.<>f__mg$cache7E = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ArenaUITask.get_m_curArenaBattleReport);
		}
		LuaCSFunction get19 = Lua_BlackJack_ProjectL_UI_ArenaUITask.<>f__mg$cache7E;
		if (Lua_BlackJack_ProjectL_UI_ArenaUITask.<>f__mg$cache7F == null)
		{
			Lua_BlackJack_ProjectL_UI_ArenaUITask.<>f__mg$cache7F = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ArenaUITask.set_m_curArenaBattleReport);
		}
		LuaObject.addMember(l, name19, get19, Lua_BlackJack_ProjectL_UI_ArenaUITask.<>f__mg$cache7F, true);
		string name20 = "m_canFlushOfflineTopRankPlayers";
		if (Lua_BlackJack_ProjectL_UI_ArenaUITask.<>f__mg$cache80 == null)
		{
			Lua_BlackJack_ProjectL_UI_ArenaUITask.<>f__mg$cache80 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ArenaUITask.get_m_canFlushOfflineTopRankPlayers);
		}
		LuaCSFunction get20 = Lua_BlackJack_ProjectL_UI_ArenaUITask.<>f__mg$cache80;
		if (Lua_BlackJack_ProjectL_UI_ArenaUITask.<>f__mg$cache81 == null)
		{
			Lua_BlackJack_ProjectL_UI_ArenaUITask.<>f__mg$cache81 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ArenaUITask.set_m_canFlushOfflineTopRankPlayers);
		}
		LuaObject.addMember(l, name20, get20, Lua_BlackJack_ProjectL_UI_ArenaUITask.<>f__mg$cache81, true);
		string name21 = "m_canFlushOnlineGlobalTopRankPlayers";
		if (Lua_BlackJack_ProjectL_UI_ArenaUITask.<>f__mg$cache82 == null)
		{
			Lua_BlackJack_ProjectL_UI_ArenaUITask.<>f__mg$cache82 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ArenaUITask.get_m_canFlushOnlineGlobalTopRankPlayers);
		}
		LuaCSFunction get21 = Lua_BlackJack_ProjectL_UI_ArenaUITask.<>f__mg$cache82;
		if (Lua_BlackJack_ProjectL_UI_ArenaUITask.<>f__mg$cache83 == null)
		{
			Lua_BlackJack_ProjectL_UI_ArenaUITask.<>f__mg$cache83 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ArenaUITask.set_m_canFlushOnlineGlobalTopRankPlayers);
		}
		LuaObject.addMember(l, name21, get21, Lua_BlackJack_ProjectL_UI_ArenaUITask.<>f__mg$cache83, true);
		string name22 = "m_canFlushOnlineLocalTopRankPlayers";
		if (Lua_BlackJack_ProjectL_UI_ArenaUITask.<>f__mg$cache84 == null)
		{
			Lua_BlackJack_ProjectL_UI_ArenaUITask.<>f__mg$cache84 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ArenaUITask.get_m_canFlushOnlineLocalTopRankPlayers);
		}
		LuaCSFunction get22 = Lua_BlackJack_ProjectL_UI_ArenaUITask.<>f__mg$cache84;
		if (Lua_BlackJack_ProjectL_UI_ArenaUITask.<>f__mg$cache85 == null)
		{
			Lua_BlackJack_ProjectL_UI_ArenaUITask.<>f__mg$cache85 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ArenaUITask.set_m_canFlushOnlineLocalTopRankPlayers);
		}
		LuaObject.addMember(l, name22, get22, Lua_BlackJack_ProjectL_UI_ArenaUITask.<>f__mg$cache85, true);
		string name23 = "m_isSwitchingOfflineOnline";
		if (Lua_BlackJack_ProjectL_UI_ArenaUITask.<>f__mg$cache86 == null)
		{
			Lua_BlackJack_ProjectL_UI_ArenaUITask.<>f__mg$cache86 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ArenaUITask.get_m_isSwitchingOfflineOnline);
		}
		LuaCSFunction get23 = Lua_BlackJack_ProjectL_UI_ArenaUITask.<>f__mg$cache86;
		if (Lua_BlackJack_ProjectL_UI_ArenaUITask.<>f__mg$cache87 == null)
		{
			Lua_BlackJack_ProjectL_UI_ArenaUITask.<>f__mg$cache87 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ArenaUITask.set_m_isSwitchingOfflineOnline);
		}
		LuaObject.addMember(l, name23, get23, Lua_BlackJack_ProjectL_UI_ArenaUITask.<>f__mg$cache87, true);
		string name24 = "m_nowSeconds";
		if (Lua_BlackJack_ProjectL_UI_ArenaUITask.<>f__mg$cache88 == null)
		{
			Lua_BlackJack_ProjectL_UI_ArenaUITask.<>f__mg$cache88 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ArenaUITask.get_m_nowSeconds);
		}
		LuaCSFunction get24 = Lua_BlackJack_ProjectL_UI_ArenaUITask.<>f__mg$cache88;
		if (Lua_BlackJack_ProjectL_UI_ArenaUITask.<>f__mg$cache89 == null)
		{
			Lua_BlackJack_ProjectL_UI_ArenaUITask.<>f__mg$cache89 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ArenaUITask.set_m_nowSeconds);
		}
		LuaObject.addMember(l, name24, get24, Lua_BlackJack_ProjectL_UI_ArenaUITask.<>f__mg$cache89, true);
		string name25 = "m_matchingUIBeginTime";
		if (Lua_BlackJack_ProjectL_UI_ArenaUITask.<>f__mg$cache8A == null)
		{
			Lua_BlackJack_ProjectL_UI_ArenaUITask.<>f__mg$cache8A = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ArenaUITask.get_m_matchingUIBeginTime);
		}
		LuaCSFunction get25 = Lua_BlackJack_ProjectL_UI_ArenaUITask.<>f__mg$cache8A;
		if (Lua_BlackJack_ProjectL_UI_ArenaUITask.<>f__mg$cache8B == null)
		{
			Lua_BlackJack_ProjectL_UI_ArenaUITask.<>f__mg$cache8B = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ArenaUITask.set_m_matchingUIBeginTime);
		}
		LuaObject.addMember(l, name25, get25, Lua_BlackJack_ProjectL_UI_ArenaUITask.<>f__mg$cache8B, true);
		string name26 = "m_matchingReqSendTime";
		if (Lua_BlackJack_ProjectL_UI_ArenaUITask.<>f__mg$cache8C == null)
		{
			Lua_BlackJack_ProjectL_UI_ArenaUITask.<>f__mg$cache8C = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ArenaUITask.get_m_matchingReqSendTime);
		}
		LuaCSFunction get26 = Lua_BlackJack_ProjectL_UI_ArenaUITask.<>f__mg$cache8C;
		if (Lua_BlackJack_ProjectL_UI_ArenaUITask.<>f__mg$cache8D == null)
		{
			Lua_BlackJack_ProjectL_UI_ArenaUITask.<>f__mg$cache8D = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ArenaUITask.set_m_matchingReqSendTime);
		}
		LuaObject.addMember(l, name26, get26, Lua_BlackJack_ProjectL_UI_ArenaUITask.<>f__mg$cache8D, true);
		string name27 = "m_matchingBattleMode";
		if (Lua_BlackJack_ProjectL_UI_ArenaUITask.<>f__mg$cache8E == null)
		{
			Lua_BlackJack_ProjectL_UI_ArenaUITask.<>f__mg$cache8E = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ArenaUITask.get_m_matchingBattleMode);
		}
		LuaCSFunction get27 = Lua_BlackJack_ProjectL_UI_ArenaUITask.<>f__mg$cache8E;
		if (Lua_BlackJack_ProjectL_UI_ArenaUITask.<>f__mg$cache8F == null)
		{
			Lua_BlackJack_ProjectL_UI_ArenaUITask.<>f__mg$cache8F = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ArenaUITask.set_m_matchingBattleMode);
		}
		LuaObject.addMember(l, name27, get27, Lua_BlackJack_ProjectL_UI_ArenaUITask.<>f__mg$cache8F, true);
		string name28 = "m_isNeedCheckOnline";
		if (Lua_BlackJack_ProjectL_UI_ArenaUITask.<>f__mg$cache90 == null)
		{
			Lua_BlackJack_ProjectL_UI_ArenaUITask.<>f__mg$cache90 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ArenaUITask.get_m_isNeedCheckOnline);
		}
		LuaCSFunction get28 = Lua_BlackJack_ProjectL_UI_ArenaUITask.<>f__mg$cache90;
		if (Lua_BlackJack_ProjectL_UI_ArenaUITask.<>f__mg$cache91 == null)
		{
			Lua_BlackJack_ProjectL_UI_ArenaUITask.<>f__mg$cache91 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ArenaUITask.set_m_isNeedCheckOnline);
		}
		LuaObject.addMember(l, name28, get28, Lua_BlackJack_ProjectL_UI_ArenaUITask.<>f__mg$cache91, true);
		string name29 = "LayerDescArray";
		if (Lua_BlackJack_ProjectL_UI_ArenaUITask.<>f__mg$cache92 == null)
		{
			Lua_BlackJack_ProjectL_UI_ArenaUITask.<>f__mg$cache92 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ArenaUITask.get_LayerDescArray);
		}
		LuaObject.addMember(l, name29, Lua_BlackJack_ProjectL_UI_ArenaUITask.<>f__mg$cache92, null, true);
		string name30 = "UICtrlDescArray";
		if (Lua_BlackJack_ProjectL_UI_ArenaUITask.<>f__mg$cache93 == null)
		{
			Lua_BlackJack_ProjectL_UI_ArenaUITask.<>f__mg$cache93 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ArenaUITask.get_UICtrlDescArray);
		}
		LuaObject.addMember(l, name30, Lua_BlackJack_ProjectL_UI_ArenaUITask.<>f__mg$cache93, null, true);
		if (Lua_BlackJack_ProjectL_UI_ArenaUITask.<>f__mg$cache94 == null)
		{
			Lua_BlackJack_ProjectL_UI_ArenaUITask.<>f__mg$cache94 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ArenaUITask.constructor);
		}
		LuaObject.createTypeMetatable(l, Lua_BlackJack_ProjectL_UI_ArenaUITask.<>f__mg$cache94, typeof(ArenaUITask), typeof(UITask));
	}

	// Token: 0x0401157E RID: 71038
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache0;

	// Token: 0x0401157F RID: 71039
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1;

	// Token: 0x04011580 RID: 71040
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2;

	// Token: 0x04011581 RID: 71041
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3;

	// Token: 0x04011582 RID: 71042
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache4;

	// Token: 0x04011583 RID: 71043
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache5;

	// Token: 0x04011584 RID: 71044
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache6;

	// Token: 0x04011585 RID: 71045
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache7;

	// Token: 0x04011586 RID: 71046
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache8;

	// Token: 0x04011587 RID: 71047
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache9;

	// Token: 0x04011588 RID: 71048
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheA;

	// Token: 0x04011589 RID: 71049
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheB;

	// Token: 0x0401158A RID: 71050
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheC;

	// Token: 0x0401158B RID: 71051
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheD;

	// Token: 0x0401158C RID: 71052
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheE;

	// Token: 0x0401158D RID: 71053
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheF;

	// Token: 0x0401158E RID: 71054
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache10;

	// Token: 0x0401158F RID: 71055
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache11;

	// Token: 0x04011590 RID: 71056
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache12;

	// Token: 0x04011591 RID: 71057
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache13;

	// Token: 0x04011592 RID: 71058
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache14;

	// Token: 0x04011593 RID: 71059
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache15;

	// Token: 0x04011594 RID: 71060
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache16;

	// Token: 0x04011595 RID: 71061
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache17;

	// Token: 0x04011596 RID: 71062
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache18;

	// Token: 0x04011597 RID: 71063
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache19;

	// Token: 0x04011598 RID: 71064
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1A;

	// Token: 0x04011599 RID: 71065
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1B;

	// Token: 0x0401159A RID: 71066
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1C;

	// Token: 0x0401159B RID: 71067
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1D;

	// Token: 0x0401159C RID: 71068
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1E;

	// Token: 0x0401159D RID: 71069
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1F;

	// Token: 0x0401159E RID: 71070
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache20;

	// Token: 0x0401159F RID: 71071
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache21;

	// Token: 0x040115A0 RID: 71072
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache22;

	// Token: 0x040115A1 RID: 71073
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache23;

	// Token: 0x040115A2 RID: 71074
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache24;

	// Token: 0x040115A3 RID: 71075
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache25;

	// Token: 0x040115A4 RID: 71076
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache26;

	// Token: 0x040115A5 RID: 71077
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache27;

	// Token: 0x040115A6 RID: 71078
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache28;

	// Token: 0x040115A7 RID: 71079
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache29;

	// Token: 0x040115A8 RID: 71080
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2A;

	// Token: 0x040115A9 RID: 71081
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2B;

	// Token: 0x040115AA RID: 71082
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2C;

	// Token: 0x040115AB RID: 71083
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2D;

	// Token: 0x040115AC RID: 71084
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2E;

	// Token: 0x040115AD RID: 71085
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2F;

	// Token: 0x040115AE RID: 71086
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache30;

	// Token: 0x040115AF RID: 71087
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache31;

	// Token: 0x040115B0 RID: 71088
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache32;

	// Token: 0x040115B1 RID: 71089
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache33;

	// Token: 0x040115B2 RID: 71090
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache34;

	// Token: 0x040115B3 RID: 71091
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache35;

	// Token: 0x040115B4 RID: 71092
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache36;

	// Token: 0x040115B5 RID: 71093
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache37;

	// Token: 0x040115B6 RID: 71094
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache38;

	// Token: 0x040115B7 RID: 71095
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache39;

	// Token: 0x040115B8 RID: 71096
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3A;

	// Token: 0x040115B9 RID: 71097
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3B;

	// Token: 0x040115BA RID: 71098
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3C;

	// Token: 0x040115BB RID: 71099
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3D;

	// Token: 0x040115BC RID: 71100
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3E;

	// Token: 0x040115BD RID: 71101
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3F;

	// Token: 0x040115BE RID: 71102
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache40;

	// Token: 0x040115BF RID: 71103
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache41;

	// Token: 0x040115C0 RID: 71104
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache42;

	// Token: 0x040115C1 RID: 71105
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache43;

	// Token: 0x040115C2 RID: 71106
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache44;

	// Token: 0x040115C3 RID: 71107
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache45;

	// Token: 0x040115C4 RID: 71108
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache46;

	// Token: 0x040115C5 RID: 71109
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache47;

	// Token: 0x040115C6 RID: 71110
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache48;

	// Token: 0x040115C7 RID: 71111
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache49;

	// Token: 0x040115C8 RID: 71112
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache4A;

	// Token: 0x040115C9 RID: 71113
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache4B;

	// Token: 0x040115CA RID: 71114
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache4C;

	// Token: 0x040115CB RID: 71115
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache4D;

	// Token: 0x040115CC RID: 71116
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache4E;

	// Token: 0x040115CD RID: 71117
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache4F;

	// Token: 0x040115CE RID: 71118
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache50;

	// Token: 0x040115CF RID: 71119
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache51;

	// Token: 0x040115D0 RID: 71120
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache52;

	// Token: 0x040115D1 RID: 71121
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache53;

	// Token: 0x040115D2 RID: 71122
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache54;

	// Token: 0x040115D3 RID: 71123
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache55;

	// Token: 0x040115D4 RID: 71124
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache56;

	// Token: 0x040115D5 RID: 71125
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache57;

	// Token: 0x040115D6 RID: 71126
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache58;

	// Token: 0x040115D7 RID: 71127
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache59;

	// Token: 0x040115D8 RID: 71128
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache5A;

	// Token: 0x040115D9 RID: 71129
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache5B;

	// Token: 0x040115DA RID: 71130
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache5C;

	// Token: 0x040115DB RID: 71131
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache5D;

	// Token: 0x040115DC RID: 71132
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache5E;

	// Token: 0x040115DD RID: 71133
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache5F;

	// Token: 0x040115DE RID: 71134
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache60;

	// Token: 0x040115DF RID: 71135
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache61;

	// Token: 0x040115E0 RID: 71136
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache62;

	// Token: 0x040115E1 RID: 71137
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache63;

	// Token: 0x040115E2 RID: 71138
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache64;

	// Token: 0x040115E3 RID: 71139
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache65;

	// Token: 0x040115E4 RID: 71140
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache66;

	// Token: 0x040115E5 RID: 71141
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache67;

	// Token: 0x040115E6 RID: 71142
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache68;

	// Token: 0x040115E7 RID: 71143
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache69;

	// Token: 0x040115E8 RID: 71144
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache6A;

	// Token: 0x040115E9 RID: 71145
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache6B;

	// Token: 0x040115EA RID: 71146
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache6C;

	// Token: 0x040115EB RID: 71147
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache6D;

	// Token: 0x040115EC RID: 71148
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache6E;

	// Token: 0x040115ED RID: 71149
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache6F;

	// Token: 0x040115EE RID: 71150
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache70;

	// Token: 0x040115EF RID: 71151
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache71;

	// Token: 0x040115F0 RID: 71152
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache72;

	// Token: 0x040115F1 RID: 71153
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache73;

	// Token: 0x040115F2 RID: 71154
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache74;

	// Token: 0x040115F3 RID: 71155
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache75;

	// Token: 0x040115F4 RID: 71156
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache76;

	// Token: 0x040115F5 RID: 71157
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache77;

	// Token: 0x040115F6 RID: 71158
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache78;

	// Token: 0x040115F7 RID: 71159
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache79;

	// Token: 0x040115F8 RID: 71160
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache7A;

	// Token: 0x040115F9 RID: 71161
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache7B;

	// Token: 0x040115FA RID: 71162
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache7C;

	// Token: 0x040115FB RID: 71163
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache7D;

	// Token: 0x040115FC RID: 71164
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache7E;

	// Token: 0x040115FD RID: 71165
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache7F;

	// Token: 0x040115FE RID: 71166
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache80;

	// Token: 0x040115FF RID: 71167
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache81;

	// Token: 0x04011600 RID: 71168
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache82;

	// Token: 0x04011601 RID: 71169
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache83;

	// Token: 0x04011602 RID: 71170
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache84;

	// Token: 0x04011603 RID: 71171
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache85;

	// Token: 0x04011604 RID: 71172
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache86;

	// Token: 0x04011605 RID: 71173
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache87;

	// Token: 0x04011606 RID: 71174
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache88;

	// Token: 0x04011607 RID: 71175
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache89;

	// Token: 0x04011608 RID: 71176
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache8A;

	// Token: 0x04011609 RID: 71177
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache8B;

	// Token: 0x0401160A RID: 71178
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache8C;

	// Token: 0x0401160B RID: 71179
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache8D;

	// Token: 0x0401160C RID: 71180
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache8E;

	// Token: 0x0401160D RID: 71181
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache8F;

	// Token: 0x0401160E RID: 71182
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache90;

	// Token: 0x0401160F RID: 71183
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache91;

	// Token: 0x04011610 RID: 71184
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache92;

	// Token: 0x04011611 RID: 71185
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache93;

	// Token: 0x04011612 RID: 71186
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache94;
}
