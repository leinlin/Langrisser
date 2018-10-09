using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using BlackJack.BJFramework.Runtime.UI;
using BlackJack.ConfigData;
using BlackJack.ProjectL.Common;
using BlackJack.ProjectL.UI;
using SLua;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.Scripting;

// Token: 0x02001374 RID: 4980
[Preserve]
public class Lua_BlackJack_ProjectL_UI_ArenaDefendUITask : LuaObject
{
	// Token: 0x0601AF01 RID: 110337 RVA: 0x00812C20 File Offset: 0x00810E20
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int constructor(IntPtr l)
	{
		int result;
		try
		{
			string name;
			LuaObject.checkType(l, 2, out name);
			ArenaDefendUITask o = new ArenaDefendUITask(name);
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

	// Token: 0x0601AF02 RID: 110338 RVA: 0x00812C74 File Offset: 0x00810E74
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int IsNeedLoadDynamicRes(IntPtr l)
	{
		int result;
		try
		{
			ArenaDefendUITask arenaDefendUITask = (ArenaDefendUITask)LuaObject.checkSelf(l);
			bool b = arenaDefendUITask.m_luaExportHelper.IsNeedLoadDynamicRes();
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

	// Token: 0x0601AF03 RID: 110339 RVA: 0x00812CD0 File Offset: 0x00810ED0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int CollectBattlefieldAssets(IntPtr l)
	{
		int result;
		try
		{
			ArenaDefendUITask arenaDefendUITask = (ArenaDefendUITask)LuaObject.checkSelf(l);
			ConfigDataBattlefieldInfo battlefieldInfo;
			LuaObject.checkType<ConfigDataBattlefieldInfo>(l, 2, out battlefieldInfo);
			arenaDefendUITask.m_luaExportHelper.CollectBattlefieldAssets(battlefieldInfo);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601AF04 RID: 110340 RVA: 0x00812D2C File Offset: 0x00810F2C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int CollectHeroAndSoldierModelAssets(IntPtr l)
	{
		int result;
		try
		{
			ArenaDefendUITask arenaDefendUITask = (ArenaDefendUITask)LuaObject.checkSelf(l);
			BattleHero hero;
			LuaObject.checkType<BattleHero>(l, 2, out hero);
			arenaDefendUITask.m_luaExportHelper.CollectHeroAndSoldierModelAssets(hero);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601AF05 RID: 110341 RVA: 0x00812D88 File Offset: 0x00810F88
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int CollectHeadImageAssets(IntPtr l)
	{
		int result;
		try
		{
			ArenaDefendUITask arenaDefendUITask = (ArenaDefendUITask)LuaObject.checkSelf(l);
			ConfigDataCharImageInfo charImageInfo;
			LuaObject.checkType<ConfigDataCharImageInfo>(l, 2, out charImageInfo);
			arenaDefendUITask.m_luaExportHelper.CollectHeadImageAssets(charImageInfo);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601AF06 RID: 110342 RVA: 0x00812DE4 File Offset: 0x00810FE4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int InitLayerStateOnLoadAllResCompleted(IntPtr l)
	{
		int result;
		try
		{
			ArenaDefendUITask arenaDefendUITask = (ArenaDefendUITask)LuaObject.checkSelf(l);
			arenaDefendUITask.m_luaExportHelper.InitLayerStateOnLoadAllResCompleted();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601AF07 RID: 110343 RVA: 0x00812E38 File Offset: 0x00811038
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int InitAllUIControllers(IntPtr l)
	{
		int result;
		try
		{
			ArenaDefendUITask arenaDefendUITask = (ArenaDefendUITask)LuaObject.checkSelf(l);
			arenaDefendUITask.m_luaExportHelper.InitAllUIControllers();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601AF08 RID: 110344 RVA: 0x00812E8C File Offset: 0x0081108C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int ClearAllContextAndRes(IntPtr l)
	{
		int result;
		try
		{
			ArenaDefendUITask arenaDefendUITask = (ArenaDefendUITask)LuaObject.checkSelf(l);
			arenaDefendUITask.m_luaExportHelper.ClearAllContextAndRes();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601AF09 RID: 110345 RVA: 0x00812EE0 File Offset: 0x008110E0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int InitArenaDefendUIController(IntPtr l)
	{
		int result;
		try
		{
			ArenaDefendUITask arenaDefendUITask = (ArenaDefendUITask)LuaObject.checkSelf(l);
			arenaDefendUITask.m_luaExportHelper.InitArenaDefendUIController();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601AF0A RID: 110346 RVA: 0x00812F34 File Offset: 0x00811134
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int UninitArenaDefendUIController(IntPtr l)
	{
		int result;
		try
		{
			ArenaDefendUITask arenaDefendUITask = (ArenaDefendUITask)LuaObject.checkSelf(l);
			arenaDefendUITask.m_luaExportHelper.UninitArenaDefendUIController();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601AF0B RID: 110347 RVA: 0x00812F88 File Offset: 0x00811188
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int OnMemoryWarning(IntPtr l)
	{
		int result;
		try
		{
			ArenaDefendUITask arenaDefendUITask = (ArenaDefendUITask)LuaObject.checkSelf(l);
			arenaDefendUITask.m_luaExportHelper.OnMemoryWarning();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601AF0C RID: 110348 RVA: 0x00812FDC File Offset: 0x008111DC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int UpdateView(IntPtr l)
	{
		int result;
		try
		{
			ArenaDefendUITask arenaDefendUITask = (ArenaDefendUITask)LuaObject.checkSelf(l);
			arenaDefendUITask.m_luaExportHelper.UpdateView();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601AF0D RID: 110349 RVA: 0x00813030 File Offset: 0x00811230
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int OnTick(IntPtr l)
	{
		int result;
		try
		{
			ArenaDefendUITask arenaDefendUITask = (ArenaDefendUITask)LuaObject.checkSelf(l);
			arenaDefendUITask.m_luaExportHelper.OnTick();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601AF0E RID: 110350 RVA: 0x00813084 File Offset: 0x00811284
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int SetupStageActors(IntPtr l)
	{
		int result;
		try
		{
			ArenaDefendUITask arenaDefendUITask = (ArenaDefendUITask)LuaObject.checkSelf(l);
			arenaDefendUITask.m_luaExportHelper.SetupStageActors();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601AF0F RID: 110351 RVA: 0x008130D8 File Offset: 0x008112D8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int ShowStagePositions(IntPtr l)
	{
		int result;
		try
		{
			ArenaDefendUITask arenaDefendUITask = (ArenaDefendUITask)LuaObject.checkSelf(l);
			arenaDefendUITask.m_luaExportHelper.ShowStagePositions();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601AF10 RID: 110352 RVA: 0x0081312C File Offset: 0x0081132C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int ClearMapAndActors(IntPtr l)
	{
		int result;
		try
		{
			ArenaDefendUITask arenaDefendUITask = (ArenaDefendUITask)LuaObject.checkSelf(l);
			arenaDefendUITask.m_luaExportHelper.ClearMapAndActors();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601AF11 RID: 110353 RVA: 0x00813180 File Offset: 0x00811380
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int ArenaDefendUIController_OnReturn(IntPtr l)
	{
		int result;
		try
		{
			ArenaDefendUITask arenaDefendUITask = (ArenaDefendUITask)LuaObject.checkSelf(l);
			arenaDefendUITask.m_luaExportHelper.ArenaDefendUIController_OnReturn();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601AF12 RID: 110354 RVA: 0x008131D4 File Offset: 0x008113D4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int ArenaDefendUIController_OnSave(IntPtr l)
	{
		int result;
		try
		{
			ArenaDefendUITask arenaDefendUITask = (ArenaDefendUITask)LuaObject.checkSelf(l);
			arenaDefendUITask.m_luaExportHelper.ArenaDefendUIController_OnSave();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601AF13 RID: 110355 RVA: 0x00813228 File Offset: 0x00811428
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int ArenaDefendUIController_OnShowActionOrderPanel(IntPtr l)
	{
		int result;
		try
		{
			ArenaDefendUITask arenaDefendUITask = (ArenaDefendUITask)LuaObject.checkSelf(l);
			arenaDefendUITask.m_luaExportHelper.ArenaDefendUIController_OnShowActionOrderPanel();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601AF14 RID: 110356 RVA: 0x0081327C File Offset: 0x0081147C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int UpdateStageHeroActionValues(IntPtr l)
	{
		int result;
		try
		{
			ArenaDefendUITask arenaDefendUITask = (ArenaDefendUITask)LuaObject.checkSelf(l);
			arenaDefendUITask.m_luaExportHelper.UpdateStageHeroActionValues();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601AF15 RID: 110357 RVA: 0x008132D0 File Offset: 0x008114D0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int ArenaDefendUIController_OnShowMapPanel(IntPtr l)
	{
		int result;
		try
		{
			ArenaDefendUITask arenaDefendUITask = (ArenaDefendUITask)LuaObject.checkSelf(l);
			arenaDefendUITask.m_luaExportHelper.ArenaDefendUIController_OnShowMapPanel();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601AF16 RID: 110358 RVA: 0x00813324 File Offset: 0x00811524
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int ArenaDefendUIController_OnShowDefendRulePanel(IntPtr l)
	{
		int result;
		try
		{
			ArenaDefendUITask arenaDefendUITask = (ArenaDefendUITask)LuaObject.checkSelf(l);
			arenaDefendUITask.m_luaExportHelper.ArenaDefendUIController_OnShowDefendRulePanel();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601AF17 RID: 110359 RVA: 0x00813378 File Offset: 0x00811578
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int ArenaDefendUIController_OnConfirmActionOrder(IntPtr l)
	{
		int result;
		try
		{
			ArenaDefendUITask arenaDefendUITask = (ArenaDefendUITask)LuaObject.checkSelf(l);
			arenaDefendUITask.m_luaExportHelper.ArenaDefendUIController_OnConfirmActionOrder();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601AF18 RID: 110360 RVA: 0x008133CC File Offset: 0x008115CC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int ArenaDefendUIController_OnConfirmMap(IntPtr l)
	{
		int result;
		try
		{
			ArenaDefendUITask arenaDefendUITask = (ArenaDefendUITask)LuaObject.checkSelf(l);
			int index;
			LuaObject.checkType(l, 2, out index);
			arenaDefendUITask.m_luaExportHelper.ArenaDefendUIController_OnConfirmMap(index);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601AF19 RID: 110361 RVA: 0x00813428 File Offset: 0x00811628
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int ArenaDefendUIController_OnConfirmDefendRule(IntPtr l)
	{
		int result;
		try
		{
			ArenaDefendUITask arenaDefendUITask = (ArenaDefendUITask)LuaObject.checkSelf(l);
			int index;
			LuaObject.checkType(l, 2, out index);
			arenaDefendUITask.m_luaExportHelper.ArenaDefendUIController_OnConfirmDefendRule(index);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601AF1A RID: 110362 RVA: 0x00813484 File Offset: 0x00811684
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int ArenaDefendUIController_OnShowMyActorInfo(IntPtr l)
	{
		int result;
		try
		{
			ArenaDefendUITask arenaDefendUITask = (ArenaDefendUITask)LuaObject.checkSelf(l);
			BattleHero hero;
			LuaObject.checkType<BattleHero>(l, 2, out hero);
			arenaDefendUITask.m_luaExportHelper.ArenaDefendUIController_OnShowMyActorInfo(hero);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601AF1B RID: 110363 RVA: 0x008134E0 File Offset: 0x008116E0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int ArenaDefendUIController_OnHideActorInfo(IntPtr l)
	{
		int result;
		try
		{
			ArenaDefendUITask arenaDefendUITask = (ArenaDefendUITask)LuaObject.checkSelf(l);
			arenaDefendUITask.m_luaExportHelper.ArenaDefendUIController_OnHideActorInfo();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601AF1C RID: 110364 RVA: 0x00813534 File Offset: 0x00811734
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int ArenaDefendUIController_OnStageActorChange(IntPtr l)
	{
		int result;
		try
		{
			ArenaDefendUITask arenaDefendUITask = (ArenaDefendUITask)LuaObject.checkSelf(l);
			arenaDefendUITask.m_luaExportHelper.ArenaDefendUIController_OnStageActorChange();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601AF1D RID: 110365 RVA: 0x00813588 File Offset: 0x00811788
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int UpdateBattlePower(IntPtr l)
	{
		int result;
		try
		{
			ArenaDefendUITask arenaDefendUITask = (ArenaDefendUITask)LuaObject.checkSelf(l);
			arenaDefendUITask.m_luaExportHelper.UpdateBattlePower();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601AF1E RID: 110366 RVA: 0x008135DC File Offset: 0x008117DC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int ArenaDefendUIController_OnHeroOnStage(IntPtr l)
	{
		int result;
		try
		{
			ArenaDefendUITask arenaDefendUITask = (ArenaDefendUITask)LuaObject.checkSelf(l);
			BattleHero hero;
			LuaObject.checkType<BattleHero>(l, 2, out hero);
			GridPosition pos;
			LuaObject.checkValueType<GridPosition>(l, 3, out pos);
			arenaDefendUITask.m_luaExportHelper.ArenaDefendUIController_OnHeroOnStage(hero, pos);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601AF1F RID: 110367 RVA: 0x00813648 File Offset: 0x00811848
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int ArenaDefendUIController_OnActorOffStage(IntPtr l)
	{
		int result;
		try
		{
			ArenaDefendUITask arenaDefendUITask = (ArenaDefendUITask)LuaObject.checkSelf(l);
			ArenaDefendActor sa;
			LuaObject.checkType<ArenaDefendActor>(l, 2, out sa);
			arenaDefendUITask.m_luaExportHelper.ArenaDefendUIController_OnActorOffStage(sa);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601AF20 RID: 110368 RVA: 0x008136A4 File Offset: 0x008118A4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int ArenaDefendUIController_OnStageActorMove(IntPtr l)
	{
		int result;
		try
		{
			ArenaDefendUITask arenaDefendUITask = (ArenaDefendUITask)LuaObject.checkSelf(l);
			ArenaDefendActor sa;
			LuaObject.checkType<ArenaDefendActor>(l, 2, out sa);
			GridPosition p;
			LuaObject.checkValueType<GridPosition>(l, 3, out p);
			arenaDefendUITask.m_luaExportHelper.ArenaDefendUIController_OnStageActorMove(sa, p);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601AF21 RID: 110369 RVA: 0x00813710 File Offset: 0x00811910
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int ArenaDefendUIController_OnStageActorSwap(IntPtr l)
	{
		int result;
		try
		{
			ArenaDefendUITask arenaDefendUITask = (ArenaDefendUITask)LuaObject.checkSelf(l);
			ArenaDefendActor sa;
			LuaObject.checkType<ArenaDefendActor>(l, 2, out sa);
			ArenaDefendActor sa2;
			LuaObject.checkType<ArenaDefendActor>(l, 3, out sa2);
			arenaDefendUITask.m_luaExportHelper.ArenaDefendUIController_OnStageActorSwap(sa, sa2);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601AF22 RID: 110370 RVA: 0x0081377C File Offset: 0x0081197C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int ArenaDefendUIController_OnPointerDown(IntPtr l)
	{
		int result;
		try
		{
			ArenaDefendUITask arenaDefendUITask = (ArenaDefendUITask)LuaObject.checkSelf(l);
			PointerEventData.InputButton button;
			LuaObject.checkEnum<PointerEventData.InputButton>(l, 2, out button);
			Vector2 position;
			LuaObject.checkType(l, 3, out position);
			arenaDefendUITask.m_luaExportHelper.ArenaDefendUIController_OnPointerDown(button, position);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601AF23 RID: 110371 RVA: 0x008137E8 File Offset: 0x008119E8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int ArenaDefendUIController_OnPointerUp(IntPtr l)
	{
		int result;
		try
		{
			ArenaDefendUITask arenaDefendUITask = (ArenaDefendUITask)LuaObject.checkSelf(l);
			PointerEventData.InputButton button;
			LuaObject.checkEnum<PointerEventData.InputButton>(l, 2, out button);
			Vector2 position;
			LuaObject.checkType(l, 3, out position);
			arenaDefendUITask.m_luaExportHelper.ArenaDefendUIController_OnPointerUp(button, position);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601AF24 RID: 110372 RVA: 0x00813854 File Offset: 0x00811A54
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int ArenaDefendUIController_OnPointerClick(IntPtr l)
	{
		int result;
		try
		{
			ArenaDefendUITask arenaDefendUITask = (ArenaDefendUITask)LuaObject.checkSelf(l);
			PointerEventData.InputButton button;
			LuaObject.checkEnum<PointerEventData.InputButton>(l, 2, out button);
			Vector2 position;
			LuaObject.checkType(l, 3, out position);
			arenaDefendUITask.m_luaExportHelper.ArenaDefendUIController_OnPointerClick(button, position);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601AF25 RID: 110373 RVA: 0x008138C0 File Offset: 0x00811AC0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int BattlePrepareActorInfoUIController_OnShowSelectSoldierPanel(IntPtr l)
	{
		int result;
		try
		{
			ArenaDefendUITask arenaDefendUITask = (ArenaDefendUITask)LuaObject.checkSelf(l);
			BattleHero hero;
			LuaObject.checkType<BattleHero>(l, 2, out hero);
			arenaDefendUITask.m_luaExportHelper.BattlePrepareActorInfoUIController_OnShowSelectSoldierPanel(hero);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601AF26 RID: 110374 RVA: 0x0081391C File Offset: 0x00811B1C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int BattlePrepareActorInfoUIController_OnChangeSkill(IntPtr l)
	{
		int result;
		try
		{
			ArenaDefendUITask arenaDefendUITask = (ArenaDefendUITask)LuaObject.checkSelf(l);
			BattleHero hero;
			LuaObject.checkType<BattleHero>(l, 2, out hero);
			List<int> skillIds;
			LuaObject.checkType<List<int>>(l, 3, out skillIds);
			arenaDefendUITask.m_luaExportHelper.BattlePrepareActorInfoUIController_OnChangeSkill(hero, skillIds);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601AF27 RID: 110375 RVA: 0x00813988 File Offset: 0x00811B88
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int BattlePrepareActorInfoUIController_OnChangeSoldier(IntPtr l)
	{
		int result;
		try
		{
			ArenaDefendUITask arenaDefendUITask = (ArenaDefendUITask)LuaObject.checkSelf(l);
			BattleHero hero;
			LuaObject.checkType<BattleHero>(l, 2, out hero);
			int soldierId;
			LuaObject.checkType(l, 3, out soldierId);
			arenaDefendUITask.m_luaExportHelper.BattlePrepareActorInfoUIController_OnChangeSoldier(hero, soldierId);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601AF28 RID: 110376 RVA: 0x008139F4 File Offset: 0x00811BF4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int ArenaDefendSceneUIController_OnPointerDown(IntPtr l)
	{
		int result;
		try
		{
			ArenaDefendUITask arenaDefendUITask = (ArenaDefendUITask)LuaObject.checkSelf(l);
			PointerEventData eventData;
			LuaObject.checkType<PointerEventData>(l, 2, out eventData);
			arenaDefendUITask.m_luaExportHelper.ArenaDefendSceneUIController_OnPointerDown(eventData);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601AF29 RID: 110377 RVA: 0x00813A50 File Offset: 0x00811C50
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int ArenaDefendSceneUIController_OnPointerUp(IntPtr l)
	{
		int result;
		try
		{
			ArenaDefendUITask arenaDefendUITask = (ArenaDefendUITask)LuaObject.checkSelf(l);
			PointerEventData eventData;
			LuaObject.checkType<PointerEventData>(l, 2, out eventData);
			arenaDefendUITask.m_luaExportHelper.ArenaDefendSceneUIController_OnPointerUp(eventData);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601AF2A RID: 110378 RVA: 0x00813AAC File Offset: 0x00811CAC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int ArenaDefendSceneUIController_OnPointerClick(IntPtr l)
	{
		int result;
		try
		{
			ArenaDefendUITask arenaDefendUITask = (ArenaDefendUITask)LuaObject.checkSelf(l);
			PointerEventData eventData;
			LuaObject.checkType<PointerEventData>(l, 2, out eventData);
			arenaDefendUITask.m_luaExportHelper.ArenaDefendSceneUIController_OnPointerClick(eventData);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601AF2B RID: 110379 RVA: 0x00813B08 File Offset: 0x00811D08
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int ArenaDefendSceneUIController_OnBeginDrag(IntPtr l)
	{
		int result;
		try
		{
			ArenaDefendUITask arenaDefendUITask = (ArenaDefendUITask)LuaObject.checkSelf(l);
			PointerEventData eventData;
			LuaObject.checkType<PointerEventData>(l, 2, out eventData);
			arenaDefendUITask.m_luaExportHelper.ArenaDefendSceneUIController_OnBeginDrag(eventData);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601AF2C RID: 110380 RVA: 0x00813B64 File Offset: 0x00811D64
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int ArenaDefendSceneUIController_OnEndDrag(IntPtr l)
	{
		int result;
		try
		{
			ArenaDefendUITask arenaDefendUITask = (ArenaDefendUITask)LuaObject.checkSelf(l);
			PointerEventData eventData;
			LuaObject.checkType<PointerEventData>(l, 2, out eventData);
			arenaDefendUITask.m_luaExportHelper.ArenaDefendSceneUIController_OnEndDrag(eventData);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601AF2D RID: 110381 RVA: 0x00813BC0 File Offset: 0x00811DC0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int ArenaDefendSceneUIController_OnDrag(IntPtr l)
	{
		int result;
		try
		{
			ArenaDefendUITask arenaDefendUITask = (ArenaDefendUITask)LuaObject.checkSelf(l);
			PointerEventData eventData;
			LuaObject.checkType<PointerEventData>(l, 2, out eventData);
			arenaDefendUITask.m_luaExportHelper.ArenaDefendSceneUIController_OnDrag(eventData);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601AF2E RID: 110382 RVA: 0x00813C1C File Offset: 0x00811E1C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_OnStart(IntPtr l)
	{
		int result;
		try
		{
			ArenaDefendUITask arenaDefendUITask = (ArenaDefendUITask)LuaObject.checkSelf(l);
			UIIntent intent;
			LuaObject.checkType<UIIntent>(l, 2, out intent);
			bool b = arenaDefendUITask.m_luaExportHelper.__callBase_OnStart(intent);
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

	// Token: 0x0601AF2F RID: 110383 RVA: 0x00813C84 File Offset: 0x00811E84
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_OnStop(IntPtr l)
	{
		int result;
		try
		{
			ArenaDefendUITask arenaDefendUITask = (ArenaDefendUITask)LuaObject.checkSelf(l);
			arenaDefendUITask.m_luaExportHelper.__callBase_OnStop();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601AF30 RID: 110384 RVA: 0x00813CD8 File Offset: 0x00811ED8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_OnPause(IntPtr l)
	{
		int result;
		try
		{
			ArenaDefendUITask arenaDefendUITask = (ArenaDefendUITask)LuaObject.checkSelf(l);
			arenaDefendUITask.m_luaExportHelper.__callBase_OnPause();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601AF31 RID: 110385 RVA: 0x00813D2C File Offset: 0x00811F2C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_OnResume(IntPtr l)
	{
		int result;
		try
		{
			ArenaDefendUITask arenaDefendUITask = (ArenaDefendUITask)LuaObject.checkSelf(l);
			UIIntent intent;
			LuaObject.checkType<UIIntent>(l, 2, out intent);
			bool b = arenaDefendUITask.m_luaExportHelper.__callBase_OnResume(intent);
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

	// Token: 0x0601AF32 RID: 110386 RVA: 0x00813D94 File Offset: 0x00811F94
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_OnNewIntent(IntPtr l)
	{
		int result;
		try
		{
			ArenaDefendUITask arenaDefendUITask = (ArenaDefendUITask)LuaObject.checkSelf(l);
			UIIntent intent;
			LuaObject.checkType<UIIntent>(l, 2, out intent);
			bool b = arenaDefendUITask.m_luaExportHelper.__callBase_OnNewIntent(intent);
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

	// Token: 0x0601AF33 RID: 110387 RVA: 0x00813DFC File Offset: 0x00811FFC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_EnableUIInput(IntPtr l)
	{
		int result;
		try
		{
			ArenaDefendUITask arenaDefendUITask = (ArenaDefendUITask)LuaObject.checkSelf(l);
			bool isEnable;
			LuaObject.checkType(l, 2, out isEnable);
			bool? isGlobalEnable;
			LuaObject.checkNullable<bool>(l, 3, out isGlobalEnable);
			arenaDefendUITask.m_luaExportHelper.__callBase_EnableUIInput(isEnable, isGlobalEnable);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601AF34 RID: 110388 RVA: 0x00813E68 File Offset: 0x00812068
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_IsNeedLoadDynamicRes(IntPtr l)
	{
		int result;
		try
		{
			ArenaDefendUITask arenaDefendUITask = (ArenaDefendUITask)LuaObject.checkSelf(l);
			bool b = arenaDefendUITask.m_luaExportHelper.__callBase_IsNeedLoadDynamicRes();
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

	// Token: 0x0601AF35 RID: 110389 RVA: 0x00813EC4 File Offset: 0x008120C4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_CollectAllDynamicResForLoad(IntPtr l)
	{
		int result;
		try
		{
			ArenaDefendUITask arenaDefendUITask = (ArenaDefendUITask)LuaObject.checkSelf(l);
			List<string> o = arenaDefendUITask.m_luaExportHelper.__callBase_CollectAllDynamicResForLoad();
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

	// Token: 0x0601AF36 RID: 110390 RVA: 0x00813F20 File Offset: 0x00812120
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_RegisterPlayerContextEvents(IntPtr l)
	{
		int result;
		try
		{
			ArenaDefendUITask arenaDefendUITask = (ArenaDefendUITask)LuaObject.checkSelf(l);
			arenaDefendUITask.m_luaExportHelper.__callBase_RegisterPlayerContextEvents();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601AF37 RID: 110391 RVA: 0x00813F74 File Offset: 0x00812174
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_UnregisterPlayerContextEvents(IntPtr l)
	{
		int result;
		try
		{
			ArenaDefendUITask arenaDefendUITask = (ArenaDefendUITask)LuaObject.checkSelf(l);
			arenaDefendUITask.m_luaExportHelper.__callBase_UnregisterPlayerContextEvents();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601AF38 RID: 110392 RVA: 0x00813FC8 File Offset: 0x008121C8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_PostUpdateView(IntPtr l)
	{
		int result;
		try
		{
			ArenaDefendUITask arenaDefendUITask = (ArenaDefendUITask)LuaObject.checkSelf(l);
			arenaDefendUITask.m_luaExportHelper.__callBase_PostUpdateView();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601AF39 RID: 110393 RVA: 0x0081401C File Offset: 0x0081221C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_CollectPreloadResourceList(IntPtr l)
	{
		int result;
		try
		{
			ArenaDefendUITask arenaDefendUITask = (ArenaDefendUITask)LuaObject.checkSelf(l);
			arenaDefendUITask.m_luaExportHelper.__callBase_CollectPreloadResourceList();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601AF3A RID: 110394 RVA: 0x00814070 File Offset: 0x00812270
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_ClearAssetList(IntPtr l)
	{
		int result;
		try
		{
			ArenaDefendUITask arenaDefendUITask = (ArenaDefendUITask)LuaObject.checkSelf(l);
			arenaDefendUITask.m_luaExportHelper.__callBase_ClearAssetList();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601AF3B RID: 110395 RVA: 0x008140C4 File Offset: 0x008122C4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_CollectAsset(IntPtr l)
	{
		int result;
		try
		{
			ArenaDefendUITask arenaDefendUITask = (ArenaDefendUITask)LuaObject.checkSelf(l);
			string assetName;
			LuaObject.checkType(l, 2, out assetName);
			arenaDefendUITask.m_luaExportHelper.__callBase_CollectAsset(assetName);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601AF3C RID: 110396 RVA: 0x00814120 File Offset: 0x00812320
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_CollectSpriteAsset(IntPtr l)
	{
		int result;
		try
		{
			ArenaDefendUITask arenaDefendUITask = (ArenaDefendUITask)LuaObject.checkSelf(l);
			string assetName;
			LuaObject.checkType(l, 2, out assetName);
			arenaDefendUITask.m_luaExportHelper.__callBase_CollectSpriteAsset(assetName);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601AF3D RID: 110397 RVA: 0x0081417C File Offset: 0x0081237C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_CollectFxAsset(IntPtr l)
	{
		int result;
		try
		{
			ArenaDefendUITask arenaDefendUITask = (ArenaDefendUITask)LuaObject.checkSelf(l);
			string assetName;
			LuaObject.checkType(l, 2, out assetName);
			arenaDefendUITask.m_luaExportHelper.__callBase_CollectFxAsset(assetName);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601AF3E RID: 110398 RVA: 0x008141D8 File Offset: 0x008123D8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_StartLoadCustomAssets(IntPtr l)
	{
		int result;
		try
		{
			ArenaDefendUITask arenaDefendUITask = (ArenaDefendUITask)LuaObject.checkSelf(l);
			Action onLoadCompleted;
			LuaObject.checkDelegate<Action>(l, 2, out onLoadCompleted);
			arenaDefendUITask.m_luaExportHelper.__callBase_StartLoadCustomAssets(onLoadCompleted);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601AF3F RID: 110399 RVA: 0x00814234 File Offset: 0x00812434
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_IsLoadingCustomAssets(IntPtr l)
	{
		int result;
		try
		{
			ArenaDefendUITask arenaDefendUITask = (ArenaDefendUITask)LuaObject.checkSelf(l);
			bool b = arenaDefendUITask.m_luaExportHelper.__callBase_IsLoadingCustomAssets();
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

	// Token: 0x0601AF40 RID: 110400 RVA: 0x00814290 File Offset: 0x00812490
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_IsPipeLineRunning(IntPtr l)
	{
		int result;
		try
		{
			ArenaDefendUITask arenaDefendUITask = (ArenaDefendUITask)LuaObject.checkSelf(l);
			bool b = arenaDefendUITask.m_luaExportHelper.__callBase_IsPipeLineRunning();
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

	// Token: 0x0601AF41 RID: 110401 RVA: 0x008142EC File Offset: 0x008124EC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_IsOpeningUI(IntPtr l)
	{
		int result;
		try
		{
			ArenaDefendUITask arenaDefendUITask = (ArenaDefendUITask)LuaObject.checkSelf(l);
			bool b = arenaDefendUITask.m_luaExportHelper.__callBase_IsOpeningUI();
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

	// Token: 0x0601AF42 RID: 110402 RVA: 0x00814348 File Offset: 0x00812548
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_ReturnPrevUITask(IntPtr l)
	{
		int result;
		try
		{
			ArenaDefendUITask arenaDefendUITask = (ArenaDefendUITask)LuaObject.checkSelf(l);
			UITaskBase o = arenaDefendUITask.m_luaExportHelper.__callBase_ReturnPrevUITask();
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

	// Token: 0x0601AF43 RID: 110403 RVA: 0x008143A4 File Offset: 0x008125A4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_ClearUnusedDynamicResourceCache(IntPtr l)
	{
		int result;
		try
		{
			ArenaDefendUITask arenaDefendUITask = (ArenaDefendUITask)LuaObject.checkSelf(l);
			arenaDefendUITask.m_luaExportHelper.__callBase_ClearUnusedDynamicResourceCache();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601AF44 RID: 110404 RVA: 0x008143F8 File Offset: 0x008125F8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_OnMemoryWarning(IntPtr l)
	{
		int result;
		try
		{
			ArenaDefendUITask arenaDefendUITask = (ArenaDefendUITask)LuaObject.checkSelf(l);
			arenaDefendUITask.m_luaExportHelper.__callBase_OnMemoryWarning();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601AF45 RID: 110405 RVA: 0x0081444C File Offset: 0x0081264C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int CompareHero_s(IntPtr l)
	{
		int result;
		try
		{
			BattleHero h;
			LuaObject.checkType<BattleHero>(l, 1, out h);
			BattleHero h2;
			LuaObject.checkType<BattleHero>(l, 2, out h2);
			int i = ArenaDefendUITask.LuaExportHelper.CompareHero(h, h2);
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

	// Token: 0x0601AF46 RID: 110406 RVA: 0x008144AC File Offset: 0x008126AC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int CompareHeroActionValue_s(IntPtr l)
	{
		int result;
		try
		{
			BattleHero hero;
			LuaObject.checkType<BattleHero>(l, 1, out hero);
			BattleHero hero2;
			LuaObject.checkType<BattleHero>(l, 2, out hero2);
			int i = ArenaDefendUITask.LuaExportHelper.CompareHeroActionValue(hero, hero2);
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

	// Token: 0x0601AF47 RID: 110407 RVA: 0x0081450C File Offset: 0x0081270C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_layerDescArray(IntPtr l)
	{
		int result;
		try
		{
			ArenaDefendUITask arenaDefendUITask = (ArenaDefendUITask)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, arenaDefendUITask.m_luaExportHelper.m_layerDescArray);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601AF48 RID: 110408 RVA: 0x00814564 File Offset: 0x00812764
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_layerDescArray(IntPtr l)
	{
		int result;
		try
		{
			ArenaDefendUITask arenaDefendUITask = (ArenaDefendUITask)LuaObject.checkSelf(l);
			UITaskBase.LayerDesc[] layerDescArray;
			LuaObject.checkArray<UITaskBase.LayerDesc>(l, 2, out layerDescArray);
			arenaDefendUITask.m_luaExportHelper.m_layerDescArray = layerDescArray;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601AF49 RID: 110409 RVA: 0x008145C0 File Offset: 0x008127C0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_uiCtrlDescArray(IntPtr l)
	{
		int result;
		try
		{
			ArenaDefendUITask arenaDefendUITask = (ArenaDefendUITask)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, arenaDefendUITask.m_luaExportHelper.m_uiCtrlDescArray);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601AF4A RID: 110410 RVA: 0x00814618 File Offset: 0x00812818
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_uiCtrlDescArray(IntPtr l)
	{
		int result;
		try
		{
			ArenaDefendUITask arenaDefendUITask = (ArenaDefendUITask)LuaObject.checkSelf(l);
			UITaskBase.UIControllerDesc[] uiCtrlDescArray;
			LuaObject.checkArray<UITaskBase.UIControllerDesc>(l, 2, out uiCtrlDescArray);
			arenaDefendUITask.m_luaExportHelper.m_uiCtrlDescArray = uiCtrlDescArray;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601AF4B RID: 110411 RVA: 0x00814674 File Offset: 0x00812874
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_arenaDefendUIController(IntPtr l)
	{
		int result;
		try
		{
			ArenaDefendUITask arenaDefendUITask = (ArenaDefendUITask)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, arenaDefendUITask.m_luaExportHelper.m_arenaDefendUIController);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601AF4C RID: 110412 RVA: 0x008146CC File Offset: 0x008128CC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_arenaDefendUIController(IntPtr l)
	{
		int result;
		try
		{
			ArenaDefendUITask arenaDefendUITask = (ArenaDefendUITask)LuaObject.checkSelf(l);
			ArenaDefendUIController arenaDefendUIController;
			LuaObject.checkType<ArenaDefendUIController>(l, 2, out arenaDefendUIController);
			arenaDefendUITask.m_luaExportHelper.m_arenaDefendUIController = arenaDefendUIController;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601AF4D RID: 110413 RVA: 0x00814728 File Offset: 0x00812928
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_arenaDefendMapUIController(IntPtr l)
	{
		int result;
		try
		{
			ArenaDefendUITask arenaDefendUITask = (ArenaDefendUITask)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, arenaDefendUITask.m_luaExportHelper.m_arenaDefendMapUIController);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601AF4E RID: 110414 RVA: 0x00814780 File Offset: 0x00812980
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_arenaDefendMapUIController(IntPtr l)
	{
		int result;
		try
		{
			ArenaDefendUITask arenaDefendUITask = (ArenaDefendUITask)LuaObject.checkSelf(l);
			ArenaDefendMapUIController arenaDefendMapUIController;
			LuaObject.checkType<ArenaDefendMapUIController>(l, 2, out arenaDefendMapUIController);
			arenaDefendUITask.m_luaExportHelper.m_arenaDefendMapUIController = arenaDefendMapUIController;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601AF4F RID: 110415 RVA: 0x008147DC File Offset: 0x008129DC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_arenaDefendSceneUIController(IntPtr l)
	{
		int result;
		try
		{
			ArenaDefendUITask arenaDefendUITask = (ArenaDefendUITask)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, arenaDefendUITask.m_luaExportHelper.m_arenaDefendSceneUIController);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601AF50 RID: 110416 RVA: 0x00814834 File Offset: 0x00812A34
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_arenaDefendSceneUIController(IntPtr l)
	{
		int result;
		try
		{
			ArenaDefendUITask arenaDefendUITask = (ArenaDefendUITask)LuaObject.checkSelf(l);
			ArenaDefendSceneUIController arenaDefendSceneUIController;
			LuaObject.checkType<ArenaDefendSceneUIController>(l, 2, out arenaDefendSceneUIController);
			arenaDefendUITask.m_luaExportHelper.m_arenaDefendSceneUIController = arenaDefendSceneUIController;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601AF51 RID: 110417 RVA: 0x00814890 File Offset: 0x00812A90
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_battlePrepareActorInfoUIController(IntPtr l)
	{
		int result;
		try
		{
			ArenaDefendUITask arenaDefendUITask = (ArenaDefendUITask)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, arenaDefendUITask.m_luaExportHelper.m_battlePrepareActorInfoUIController);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601AF52 RID: 110418 RVA: 0x008148E8 File Offset: 0x00812AE8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_battlePrepareActorInfoUIController(IntPtr l)
	{
		int result;
		try
		{
			ArenaDefendUITask arenaDefendUITask = (ArenaDefendUITask)LuaObject.checkSelf(l);
			BattlePrepareActorInfoUIController battlePrepareActorInfoUIController;
			LuaObject.checkType<BattlePrepareActorInfoUIController>(l, 2, out battlePrepareActorInfoUIController);
			arenaDefendUITask.m_luaExportHelper.m_battlePrepareActorInfoUIController = battlePrepareActorInfoUIController;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601AF53 RID: 110419 RVA: 0x00814944 File Offset: 0x00812B44
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_arenaDefendBattle(IntPtr l)
	{
		int result;
		try
		{
			ArenaDefendUITask arenaDefendUITask = (ArenaDefendUITask)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, arenaDefendUITask.m_luaExportHelper.m_arenaDefendBattle);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601AF54 RID: 110420 RVA: 0x0081499C File Offset: 0x00812B9C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_arenaDefendBattle(IntPtr l)
	{
		int result;
		try
		{
			ArenaDefendUITask arenaDefendUITask = (ArenaDefendUITask)LuaObject.checkSelf(l);
			ArenaDefendBattle arenaDefendBattle;
			LuaObject.checkType<ArenaDefendBattle>(l, 2, out arenaDefendBattle);
			arenaDefendUITask.m_luaExportHelper.m_arenaDefendBattle = arenaDefendBattle;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601AF55 RID: 110421 RVA: 0x008149F8 File Offset: 0x00812BF8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_defendPositions(IntPtr l)
	{
		int result;
		try
		{
			ArenaDefendUITask arenaDefendUITask = (ArenaDefendUITask)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, arenaDefendUITask.m_luaExportHelper.m_defendPositions);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601AF56 RID: 110422 RVA: 0x00814A50 File Offset: 0x00812C50
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_defendPositions(IntPtr l)
	{
		int result;
		try
		{
			ArenaDefendUITask arenaDefendUITask = (ArenaDefendUITask)LuaObject.checkSelf(l);
			List<GridPosition> defendPositions;
			LuaObject.checkType<List<GridPosition>>(l, 2, out defendPositions);
			arenaDefendUITask.m_luaExportHelper.m_defendPositions = defendPositions;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601AF57 RID: 110423 RVA: 0x00814AAC File Offset: 0x00812CAC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_attackPositions(IntPtr l)
	{
		int result;
		try
		{
			ArenaDefendUITask arenaDefendUITask = (ArenaDefendUITask)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, arenaDefendUITask.m_luaExportHelper.m_attackPositions);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601AF58 RID: 110424 RVA: 0x00814B04 File Offset: 0x00812D04
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_attackPositions(IntPtr l)
	{
		int result;
		try
		{
			ArenaDefendUITask arenaDefendUITask = (ArenaDefendUITask)LuaObject.checkSelf(l);
			List<GridPosition> attackPositions;
			LuaObject.checkType<List<GridPosition>>(l, 2, out attackPositions);
			arenaDefendUITask.m_luaExportHelper.m_attackPositions = attackPositions;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601AF59 RID: 110425 RVA: 0x00814B60 File Offset: 0x00812D60
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_arenaBattleInfos(IntPtr l)
	{
		int result;
		try
		{
			ArenaDefendUITask arenaDefendUITask = (ArenaDefendUITask)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, arenaDefendUITask.m_luaExportHelper.m_arenaBattleInfos);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601AF5A RID: 110426 RVA: 0x00814BB8 File Offset: 0x00812DB8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_arenaBattleInfos(IntPtr l)
	{
		int result;
		try
		{
			ArenaDefendUITask arenaDefendUITask = (ArenaDefendUITask)LuaObject.checkSelf(l);
			List<ConfigDataArenaBattleInfo> arenaBattleInfos;
			LuaObject.checkType<List<ConfigDataArenaBattleInfo>>(l, 2, out arenaBattleInfos);
			arenaDefendUITask.m_luaExportHelper.m_arenaBattleInfos = arenaBattleInfos;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601AF5B RID: 110427 RVA: 0x00814C14 File Offset: 0x00812E14
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_defendRuleInfos(IntPtr l)
	{
		int result;
		try
		{
			ArenaDefendUITask arenaDefendUITask = (ArenaDefendUITask)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, arenaDefendUITask.m_luaExportHelper.m_defendRuleInfos);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601AF5C RID: 110428 RVA: 0x00814C6C File Offset: 0x00812E6C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_defendRuleInfos(IntPtr l)
	{
		int result;
		try
		{
			ArenaDefendUITask arenaDefendUITask = (ArenaDefendUITask)LuaObject.checkSelf(l);
			List<ConfigDataArenaDefendRuleInfo> defendRuleInfos;
			LuaObject.checkType<List<ConfigDataArenaDefendRuleInfo>>(l, 2, out defendRuleInfos);
			arenaDefendUITask.m_luaExportHelper.m_defendRuleInfos = defendRuleInfos;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601AF5D RID: 110429 RVA: 0x00814CC8 File Offset: 0x00812EC8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_playerBattleHeros(IntPtr l)
	{
		int result;
		try
		{
			ArenaDefendUITask arenaDefendUITask = (ArenaDefendUITask)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, arenaDefendUITask.m_luaExportHelper.m_playerBattleHeros);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601AF5E RID: 110430 RVA: 0x00814D20 File Offset: 0x00812F20
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_playerBattleHeros(IntPtr l)
	{
		int result;
		try
		{
			ArenaDefendUITask arenaDefendUITask = (ArenaDefendUITask)LuaObject.checkSelf(l);
			List<BattleHero> playerBattleHeros;
			LuaObject.checkType<List<BattleHero>>(l, 2, out playerBattleHeros);
			arenaDefendUITask.m_luaExportHelper.m_playerBattleHeros = playerBattleHeros;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601AF5F RID: 110431 RVA: 0x00814D7C File Offset: 0x00812F7C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_defendStageHeros(IntPtr l)
	{
		int result;
		try
		{
			ArenaDefendUITask arenaDefendUITask = (ArenaDefendUITask)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, arenaDefendUITask.m_luaExportHelper.m_defendStageHeros);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601AF60 RID: 110432 RVA: 0x00814DD4 File Offset: 0x00812FD4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_defendStageHeros(IntPtr l)
	{
		int result;
		try
		{
			ArenaDefendUITask arenaDefendUITask = (ArenaDefendUITask)LuaObject.checkSelf(l);
			List<BattleHero> defendStageHeros;
			LuaObject.checkType<List<BattleHero>>(l, 2, out defendStageHeros);
			arenaDefendUITask.m_luaExportHelper.m_defendStageHeros = defendStageHeros;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601AF61 RID: 110433 RVA: 0x00814E30 File Offset: 0x00813030
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_trainingTechs(IntPtr l)
	{
		int result;
		try
		{
			ArenaDefendUITask arenaDefendUITask = (ArenaDefendUITask)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, arenaDefendUITask.m_luaExportHelper.m_trainingTechs);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601AF62 RID: 110434 RVA: 0x00814E88 File Offset: 0x00813088
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_trainingTechs(IntPtr l)
	{
		int result;
		try
		{
			ArenaDefendUITask arenaDefendUITask = (ArenaDefendUITask)LuaObject.checkSelf(l);
			List<TrainingTech> trainingTechs;
			LuaObject.checkType<List<TrainingTech>>(l, 2, out trainingTechs);
			arenaDefendUITask.m_luaExportHelper.m_trainingTechs = trainingTechs;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601AF63 RID: 110435 RVA: 0x00814EE4 File Offset: 0x008130E4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_curBattleIndex(IntPtr l)
	{
		int result;
		try
		{
			ArenaDefendUITask arenaDefendUITask = (ArenaDefendUITask)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, arenaDefendUITask.m_luaExportHelper.m_curBattleIndex);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601AF64 RID: 110436 RVA: 0x00814F3C File Offset: 0x0081313C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_curBattleIndex(IntPtr l)
	{
		int result;
		try
		{
			ArenaDefendUITask arenaDefendUITask = (ArenaDefendUITask)LuaObject.checkSelf(l);
			int curBattleIndex;
			LuaObject.checkType(l, 2, out curBattleIndex);
			arenaDefendUITask.m_luaExportHelper.m_curBattleIndex = curBattleIndex;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601AF65 RID: 110437 RVA: 0x00814F98 File Offset: 0x00813198
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_curDefendRuleIndex(IntPtr l)
	{
		int result;
		try
		{
			ArenaDefendUITask arenaDefendUITask = (ArenaDefendUITask)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, arenaDefendUITask.m_luaExportHelper.m_curDefendRuleIndex);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601AF66 RID: 110438 RVA: 0x00814FF0 File Offset: 0x008131F0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_curDefendRuleIndex(IntPtr l)
	{
		int result;
		try
		{
			ArenaDefendUITask arenaDefendUITask = (ArenaDefendUITask)LuaObject.checkSelf(l);
			int curDefendRuleIndex;
			LuaObject.checkType(l, 2, out curDefendRuleIndex);
			arenaDefendUITask.m_luaExportHelper.m_curDefendRuleIndex = curDefendRuleIndex;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601AF67 RID: 110439 RVA: 0x0081504C File Offset: 0x0081324C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_configDataLoader(IntPtr l)
	{
		int result;
		try
		{
			ArenaDefendUITask arenaDefendUITask = (ArenaDefendUITask)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, arenaDefendUITask.m_luaExportHelper.m_configDataLoader);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601AF68 RID: 110440 RVA: 0x008150A4 File Offset: 0x008132A4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_configDataLoader(IntPtr l)
	{
		int result;
		try
		{
			ArenaDefendUITask arenaDefendUITask = (ArenaDefendUITask)LuaObject.checkSelf(l);
			IConfigDataLoader configDataLoader;
			LuaObject.checkType<IConfigDataLoader>(l, 2, out configDataLoader);
			arenaDefendUITask.m_luaExportHelper.m_configDataLoader = configDataLoader;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601AF69 RID: 110441 RVA: 0x00815100 File Offset: 0x00813300
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_LayerDescArray(IntPtr l)
	{
		int result;
		try
		{
			ArenaDefendUITask arenaDefendUITask = (ArenaDefendUITask)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, arenaDefendUITask.m_luaExportHelper.LayerDescArray);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601AF6A RID: 110442 RVA: 0x00815158 File Offset: 0x00813358
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_UICtrlDescArray(IntPtr l)
	{
		int result;
		try
		{
			ArenaDefendUITask arenaDefendUITask = (ArenaDefendUITask)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, arenaDefendUITask.m_luaExportHelper.UICtrlDescArray);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601AF6B RID: 110443 RVA: 0x008151B0 File Offset: 0x008133B0
	[Preserve]
	public static void reg(IntPtr l)
	{
		LuaObject.getTypeTable(l, "BlackJack.ProjectL.UI.ArenaDefendUITask");
		if (Lua_BlackJack_ProjectL_UI_ArenaDefendUITask.<>f__mg$cache0 == null)
		{
			Lua_BlackJack_ProjectL_UI_ArenaDefendUITask.<>f__mg$cache0 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ArenaDefendUITask.IsNeedLoadDynamicRes);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_ArenaDefendUITask.<>f__mg$cache0);
		if (Lua_BlackJack_ProjectL_UI_ArenaDefendUITask.<>f__mg$cache1 == null)
		{
			Lua_BlackJack_ProjectL_UI_ArenaDefendUITask.<>f__mg$cache1 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ArenaDefendUITask.CollectBattlefieldAssets);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_ArenaDefendUITask.<>f__mg$cache1);
		if (Lua_BlackJack_ProjectL_UI_ArenaDefendUITask.<>f__mg$cache2 == null)
		{
			Lua_BlackJack_ProjectL_UI_ArenaDefendUITask.<>f__mg$cache2 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ArenaDefendUITask.CollectHeroAndSoldierModelAssets);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_ArenaDefendUITask.<>f__mg$cache2);
		if (Lua_BlackJack_ProjectL_UI_ArenaDefendUITask.<>f__mg$cache3 == null)
		{
			Lua_BlackJack_ProjectL_UI_ArenaDefendUITask.<>f__mg$cache3 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ArenaDefendUITask.CollectHeadImageAssets);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_ArenaDefendUITask.<>f__mg$cache3);
		if (Lua_BlackJack_ProjectL_UI_ArenaDefendUITask.<>f__mg$cache4 == null)
		{
			Lua_BlackJack_ProjectL_UI_ArenaDefendUITask.<>f__mg$cache4 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ArenaDefendUITask.InitLayerStateOnLoadAllResCompleted);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_ArenaDefendUITask.<>f__mg$cache4);
		if (Lua_BlackJack_ProjectL_UI_ArenaDefendUITask.<>f__mg$cache5 == null)
		{
			Lua_BlackJack_ProjectL_UI_ArenaDefendUITask.<>f__mg$cache5 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ArenaDefendUITask.InitAllUIControllers);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_ArenaDefendUITask.<>f__mg$cache5);
		if (Lua_BlackJack_ProjectL_UI_ArenaDefendUITask.<>f__mg$cache6 == null)
		{
			Lua_BlackJack_ProjectL_UI_ArenaDefendUITask.<>f__mg$cache6 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ArenaDefendUITask.ClearAllContextAndRes);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_ArenaDefendUITask.<>f__mg$cache6);
		if (Lua_BlackJack_ProjectL_UI_ArenaDefendUITask.<>f__mg$cache7 == null)
		{
			Lua_BlackJack_ProjectL_UI_ArenaDefendUITask.<>f__mg$cache7 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ArenaDefendUITask.InitArenaDefendUIController);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_ArenaDefendUITask.<>f__mg$cache7);
		if (Lua_BlackJack_ProjectL_UI_ArenaDefendUITask.<>f__mg$cache8 == null)
		{
			Lua_BlackJack_ProjectL_UI_ArenaDefendUITask.<>f__mg$cache8 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ArenaDefendUITask.UninitArenaDefendUIController);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_ArenaDefendUITask.<>f__mg$cache8);
		if (Lua_BlackJack_ProjectL_UI_ArenaDefendUITask.<>f__mg$cache9 == null)
		{
			Lua_BlackJack_ProjectL_UI_ArenaDefendUITask.<>f__mg$cache9 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ArenaDefendUITask.OnMemoryWarning);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_ArenaDefendUITask.<>f__mg$cache9);
		if (Lua_BlackJack_ProjectL_UI_ArenaDefendUITask.<>f__mg$cacheA == null)
		{
			Lua_BlackJack_ProjectL_UI_ArenaDefendUITask.<>f__mg$cacheA = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ArenaDefendUITask.UpdateView);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_ArenaDefendUITask.<>f__mg$cacheA);
		if (Lua_BlackJack_ProjectL_UI_ArenaDefendUITask.<>f__mg$cacheB == null)
		{
			Lua_BlackJack_ProjectL_UI_ArenaDefendUITask.<>f__mg$cacheB = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ArenaDefendUITask.OnTick);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_ArenaDefendUITask.<>f__mg$cacheB);
		if (Lua_BlackJack_ProjectL_UI_ArenaDefendUITask.<>f__mg$cacheC == null)
		{
			Lua_BlackJack_ProjectL_UI_ArenaDefendUITask.<>f__mg$cacheC = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ArenaDefendUITask.SetupStageActors);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_ArenaDefendUITask.<>f__mg$cacheC);
		if (Lua_BlackJack_ProjectL_UI_ArenaDefendUITask.<>f__mg$cacheD == null)
		{
			Lua_BlackJack_ProjectL_UI_ArenaDefendUITask.<>f__mg$cacheD = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ArenaDefendUITask.ShowStagePositions);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_ArenaDefendUITask.<>f__mg$cacheD);
		if (Lua_BlackJack_ProjectL_UI_ArenaDefendUITask.<>f__mg$cacheE == null)
		{
			Lua_BlackJack_ProjectL_UI_ArenaDefendUITask.<>f__mg$cacheE = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ArenaDefendUITask.ClearMapAndActors);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_ArenaDefendUITask.<>f__mg$cacheE);
		if (Lua_BlackJack_ProjectL_UI_ArenaDefendUITask.<>f__mg$cacheF == null)
		{
			Lua_BlackJack_ProjectL_UI_ArenaDefendUITask.<>f__mg$cacheF = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ArenaDefendUITask.ArenaDefendUIController_OnReturn);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_ArenaDefendUITask.<>f__mg$cacheF);
		if (Lua_BlackJack_ProjectL_UI_ArenaDefendUITask.<>f__mg$cache10 == null)
		{
			Lua_BlackJack_ProjectL_UI_ArenaDefendUITask.<>f__mg$cache10 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ArenaDefendUITask.ArenaDefendUIController_OnSave);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_ArenaDefendUITask.<>f__mg$cache10);
		if (Lua_BlackJack_ProjectL_UI_ArenaDefendUITask.<>f__mg$cache11 == null)
		{
			Lua_BlackJack_ProjectL_UI_ArenaDefendUITask.<>f__mg$cache11 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ArenaDefendUITask.ArenaDefendUIController_OnShowActionOrderPanel);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_ArenaDefendUITask.<>f__mg$cache11);
		if (Lua_BlackJack_ProjectL_UI_ArenaDefendUITask.<>f__mg$cache12 == null)
		{
			Lua_BlackJack_ProjectL_UI_ArenaDefendUITask.<>f__mg$cache12 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ArenaDefendUITask.UpdateStageHeroActionValues);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_ArenaDefendUITask.<>f__mg$cache12);
		if (Lua_BlackJack_ProjectL_UI_ArenaDefendUITask.<>f__mg$cache13 == null)
		{
			Lua_BlackJack_ProjectL_UI_ArenaDefendUITask.<>f__mg$cache13 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ArenaDefendUITask.ArenaDefendUIController_OnShowMapPanel);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_ArenaDefendUITask.<>f__mg$cache13);
		if (Lua_BlackJack_ProjectL_UI_ArenaDefendUITask.<>f__mg$cache14 == null)
		{
			Lua_BlackJack_ProjectL_UI_ArenaDefendUITask.<>f__mg$cache14 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ArenaDefendUITask.ArenaDefendUIController_OnShowDefendRulePanel);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_ArenaDefendUITask.<>f__mg$cache14);
		if (Lua_BlackJack_ProjectL_UI_ArenaDefendUITask.<>f__mg$cache15 == null)
		{
			Lua_BlackJack_ProjectL_UI_ArenaDefendUITask.<>f__mg$cache15 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ArenaDefendUITask.ArenaDefendUIController_OnConfirmActionOrder);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_ArenaDefendUITask.<>f__mg$cache15);
		if (Lua_BlackJack_ProjectL_UI_ArenaDefendUITask.<>f__mg$cache16 == null)
		{
			Lua_BlackJack_ProjectL_UI_ArenaDefendUITask.<>f__mg$cache16 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ArenaDefendUITask.ArenaDefendUIController_OnConfirmMap);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_ArenaDefendUITask.<>f__mg$cache16);
		if (Lua_BlackJack_ProjectL_UI_ArenaDefendUITask.<>f__mg$cache17 == null)
		{
			Lua_BlackJack_ProjectL_UI_ArenaDefendUITask.<>f__mg$cache17 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ArenaDefendUITask.ArenaDefendUIController_OnConfirmDefendRule);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_ArenaDefendUITask.<>f__mg$cache17);
		if (Lua_BlackJack_ProjectL_UI_ArenaDefendUITask.<>f__mg$cache18 == null)
		{
			Lua_BlackJack_ProjectL_UI_ArenaDefendUITask.<>f__mg$cache18 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ArenaDefendUITask.ArenaDefendUIController_OnShowMyActorInfo);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_ArenaDefendUITask.<>f__mg$cache18);
		if (Lua_BlackJack_ProjectL_UI_ArenaDefendUITask.<>f__mg$cache19 == null)
		{
			Lua_BlackJack_ProjectL_UI_ArenaDefendUITask.<>f__mg$cache19 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ArenaDefendUITask.ArenaDefendUIController_OnHideActorInfo);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_ArenaDefendUITask.<>f__mg$cache19);
		if (Lua_BlackJack_ProjectL_UI_ArenaDefendUITask.<>f__mg$cache1A == null)
		{
			Lua_BlackJack_ProjectL_UI_ArenaDefendUITask.<>f__mg$cache1A = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ArenaDefendUITask.ArenaDefendUIController_OnStageActorChange);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_ArenaDefendUITask.<>f__mg$cache1A);
		if (Lua_BlackJack_ProjectL_UI_ArenaDefendUITask.<>f__mg$cache1B == null)
		{
			Lua_BlackJack_ProjectL_UI_ArenaDefendUITask.<>f__mg$cache1B = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ArenaDefendUITask.UpdateBattlePower);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_ArenaDefendUITask.<>f__mg$cache1B);
		if (Lua_BlackJack_ProjectL_UI_ArenaDefendUITask.<>f__mg$cache1C == null)
		{
			Lua_BlackJack_ProjectL_UI_ArenaDefendUITask.<>f__mg$cache1C = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ArenaDefendUITask.ArenaDefendUIController_OnHeroOnStage);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_ArenaDefendUITask.<>f__mg$cache1C);
		if (Lua_BlackJack_ProjectL_UI_ArenaDefendUITask.<>f__mg$cache1D == null)
		{
			Lua_BlackJack_ProjectL_UI_ArenaDefendUITask.<>f__mg$cache1D = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ArenaDefendUITask.ArenaDefendUIController_OnActorOffStage);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_ArenaDefendUITask.<>f__mg$cache1D);
		if (Lua_BlackJack_ProjectL_UI_ArenaDefendUITask.<>f__mg$cache1E == null)
		{
			Lua_BlackJack_ProjectL_UI_ArenaDefendUITask.<>f__mg$cache1E = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ArenaDefendUITask.ArenaDefendUIController_OnStageActorMove);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_ArenaDefendUITask.<>f__mg$cache1E);
		if (Lua_BlackJack_ProjectL_UI_ArenaDefendUITask.<>f__mg$cache1F == null)
		{
			Lua_BlackJack_ProjectL_UI_ArenaDefendUITask.<>f__mg$cache1F = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ArenaDefendUITask.ArenaDefendUIController_OnStageActorSwap);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_ArenaDefendUITask.<>f__mg$cache1F);
		if (Lua_BlackJack_ProjectL_UI_ArenaDefendUITask.<>f__mg$cache20 == null)
		{
			Lua_BlackJack_ProjectL_UI_ArenaDefendUITask.<>f__mg$cache20 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ArenaDefendUITask.ArenaDefendUIController_OnPointerDown);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_ArenaDefendUITask.<>f__mg$cache20);
		if (Lua_BlackJack_ProjectL_UI_ArenaDefendUITask.<>f__mg$cache21 == null)
		{
			Lua_BlackJack_ProjectL_UI_ArenaDefendUITask.<>f__mg$cache21 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ArenaDefendUITask.ArenaDefendUIController_OnPointerUp);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_ArenaDefendUITask.<>f__mg$cache21);
		if (Lua_BlackJack_ProjectL_UI_ArenaDefendUITask.<>f__mg$cache22 == null)
		{
			Lua_BlackJack_ProjectL_UI_ArenaDefendUITask.<>f__mg$cache22 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ArenaDefendUITask.ArenaDefendUIController_OnPointerClick);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_ArenaDefendUITask.<>f__mg$cache22);
		if (Lua_BlackJack_ProjectL_UI_ArenaDefendUITask.<>f__mg$cache23 == null)
		{
			Lua_BlackJack_ProjectL_UI_ArenaDefendUITask.<>f__mg$cache23 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ArenaDefendUITask.BattlePrepareActorInfoUIController_OnShowSelectSoldierPanel);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_ArenaDefendUITask.<>f__mg$cache23);
		if (Lua_BlackJack_ProjectL_UI_ArenaDefendUITask.<>f__mg$cache24 == null)
		{
			Lua_BlackJack_ProjectL_UI_ArenaDefendUITask.<>f__mg$cache24 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ArenaDefendUITask.BattlePrepareActorInfoUIController_OnChangeSkill);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_ArenaDefendUITask.<>f__mg$cache24);
		if (Lua_BlackJack_ProjectL_UI_ArenaDefendUITask.<>f__mg$cache25 == null)
		{
			Lua_BlackJack_ProjectL_UI_ArenaDefendUITask.<>f__mg$cache25 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ArenaDefendUITask.BattlePrepareActorInfoUIController_OnChangeSoldier);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_ArenaDefendUITask.<>f__mg$cache25);
		if (Lua_BlackJack_ProjectL_UI_ArenaDefendUITask.<>f__mg$cache26 == null)
		{
			Lua_BlackJack_ProjectL_UI_ArenaDefendUITask.<>f__mg$cache26 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ArenaDefendUITask.ArenaDefendSceneUIController_OnPointerDown);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_ArenaDefendUITask.<>f__mg$cache26);
		if (Lua_BlackJack_ProjectL_UI_ArenaDefendUITask.<>f__mg$cache27 == null)
		{
			Lua_BlackJack_ProjectL_UI_ArenaDefendUITask.<>f__mg$cache27 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ArenaDefendUITask.ArenaDefendSceneUIController_OnPointerUp);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_ArenaDefendUITask.<>f__mg$cache27);
		if (Lua_BlackJack_ProjectL_UI_ArenaDefendUITask.<>f__mg$cache28 == null)
		{
			Lua_BlackJack_ProjectL_UI_ArenaDefendUITask.<>f__mg$cache28 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ArenaDefendUITask.ArenaDefendSceneUIController_OnPointerClick);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_ArenaDefendUITask.<>f__mg$cache28);
		if (Lua_BlackJack_ProjectL_UI_ArenaDefendUITask.<>f__mg$cache29 == null)
		{
			Lua_BlackJack_ProjectL_UI_ArenaDefendUITask.<>f__mg$cache29 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ArenaDefendUITask.ArenaDefendSceneUIController_OnBeginDrag);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_ArenaDefendUITask.<>f__mg$cache29);
		if (Lua_BlackJack_ProjectL_UI_ArenaDefendUITask.<>f__mg$cache2A == null)
		{
			Lua_BlackJack_ProjectL_UI_ArenaDefendUITask.<>f__mg$cache2A = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ArenaDefendUITask.ArenaDefendSceneUIController_OnEndDrag);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_ArenaDefendUITask.<>f__mg$cache2A);
		if (Lua_BlackJack_ProjectL_UI_ArenaDefendUITask.<>f__mg$cache2B == null)
		{
			Lua_BlackJack_ProjectL_UI_ArenaDefendUITask.<>f__mg$cache2B = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ArenaDefendUITask.ArenaDefendSceneUIController_OnDrag);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_ArenaDefendUITask.<>f__mg$cache2B);
		if (Lua_BlackJack_ProjectL_UI_ArenaDefendUITask.<>f__mg$cache2C == null)
		{
			Lua_BlackJack_ProjectL_UI_ArenaDefendUITask.<>f__mg$cache2C = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ArenaDefendUITask.__callBase_OnStart);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_ArenaDefendUITask.<>f__mg$cache2C);
		if (Lua_BlackJack_ProjectL_UI_ArenaDefendUITask.<>f__mg$cache2D == null)
		{
			Lua_BlackJack_ProjectL_UI_ArenaDefendUITask.<>f__mg$cache2D = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ArenaDefendUITask.__callBase_OnStop);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_ArenaDefendUITask.<>f__mg$cache2D);
		if (Lua_BlackJack_ProjectL_UI_ArenaDefendUITask.<>f__mg$cache2E == null)
		{
			Lua_BlackJack_ProjectL_UI_ArenaDefendUITask.<>f__mg$cache2E = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ArenaDefendUITask.__callBase_OnPause);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_ArenaDefendUITask.<>f__mg$cache2E);
		if (Lua_BlackJack_ProjectL_UI_ArenaDefendUITask.<>f__mg$cache2F == null)
		{
			Lua_BlackJack_ProjectL_UI_ArenaDefendUITask.<>f__mg$cache2F = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ArenaDefendUITask.__callBase_OnResume);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_ArenaDefendUITask.<>f__mg$cache2F);
		if (Lua_BlackJack_ProjectL_UI_ArenaDefendUITask.<>f__mg$cache30 == null)
		{
			Lua_BlackJack_ProjectL_UI_ArenaDefendUITask.<>f__mg$cache30 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ArenaDefendUITask.__callBase_OnNewIntent);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_ArenaDefendUITask.<>f__mg$cache30);
		if (Lua_BlackJack_ProjectL_UI_ArenaDefendUITask.<>f__mg$cache31 == null)
		{
			Lua_BlackJack_ProjectL_UI_ArenaDefendUITask.<>f__mg$cache31 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ArenaDefendUITask.__callBase_EnableUIInput);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_ArenaDefendUITask.<>f__mg$cache31);
		if (Lua_BlackJack_ProjectL_UI_ArenaDefendUITask.<>f__mg$cache32 == null)
		{
			Lua_BlackJack_ProjectL_UI_ArenaDefendUITask.<>f__mg$cache32 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ArenaDefendUITask.__callBase_IsNeedLoadDynamicRes);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_ArenaDefendUITask.<>f__mg$cache32);
		if (Lua_BlackJack_ProjectL_UI_ArenaDefendUITask.<>f__mg$cache33 == null)
		{
			Lua_BlackJack_ProjectL_UI_ArenaDefendUITask.<>f__mg$cache33 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ArenaDefendUITask.__callBase_CollectAllDynamicResForLoad);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_ArenaDefendUITask.<>f__mg$cache33);
		if (Lua_BlackJack_ProjectL_UI_ArenaDefendUITask.<>f__mg$cache34 == null)
		{
			Lua_BlackJack_ProjectL_UI_ArenaDefendUITask.<>f__mg$cache34 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ArenaDefendUITask.__callBase_RegisterPlayerContextEvents);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_ArenaDefendUITask.<>f__mg$cache34);
		if (Lua_BlackJack_ProjectL_UI_ArenaDefendUITask.<>f__mg$cache35 == null)
		{
			Lua_BlackJack_ProjectL_UI_ArenaDefendUITask.<>f__mg$cache35 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ArenaDefendUITask.__callBase_UnregisterPlayerContextEvents);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_ArenaDefendUITask.<>f__mg$cache35);
		if (Lua_BlackJack_ProjectL_UI_ArenaDefendUITask.<>f__mg$cache36 == null)
		{
			Lua_BlackJack_ProjectL_UI_ArenaDefendUITask.<>f__mg$cache36 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ArenaDefendUITask.__callBase_PostUpdateView);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_ArenaDefendUITask.<>f__mg$cache36);
		if (Lua_BlackJack_ProjectL_UI_ArenaDefendUITask.<>f__mg$cache37 == null)
		{
			Lua_BlackJack_ProjectL_UI_ArenaDefendUITask.<>f__mg$cache37 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ArenaDefendUITask.__callBase_CollectPreloadResourceList);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_ArenaDefendUITask.<>f__mg$cache37);
		if (Lua_BlackJack_ProjectL_UI_ArenaDefendUITask.<>f__mg$cache38 == null)
		{
			Lua_BlackJack_ProjectL_UI_ArenaDefendUITask.<>f__mg$cache38 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ArenaDefendUITask.__callBase_ClearAssetList);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_ArenaDefendUITask.<>f__mg$cache38);
		if (Lua_BlackJack_ProjectL_UI_ArenaDefendUITask.<>f__mg$cache39 == null)
		{
			Lua_BlackJack_ProjectL_UI_ArenaDefendUITask.<>f__mg$cache39 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ArenaDefendUITask.__callBase_CollectAsset);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_ArenaDefendUITask.<>f__mg$cache39);
		if (Lua_BlackJack_ProjectL_UI_ArenaDefendUITask.<>f__mg$cache3A == null)
		{
			Lua_BlackJack_ProjectL_UI_ArenaDefendUITask.<>f__mg$cache3A = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ArenaDefendUITask.__callBase_CollectSpriteAsset);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_ArenaDefendUITask.<>f__mg$cache3A);
		if (Lua_BlackJack_ProjectL_UI_ArenaDefendUITask.<>f__mg$cache3B == null)
		{
			Lua_BlackJack_ProjectL_UI_ArenaDefendUITask.<>f__mg$cache3B = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ArenaDefendUITask.__callBase_CollectFxAsset);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_ArenaDefendUITask.<>f__mg$cache3B);
		if (Lua_BlackJack_ProjectL_UI_ArenaDefendUITask.<>f__mg$cache3C == null)
		{
			Lua_BlackJack_ProjectL_UI_ArenaDefendUITask.<>f__mg$cache3C = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ArenaDefendUITask.__callBase_StartLoadCustomAssets);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_ArenaDefendUITask.<>f__mg$cache3C);
		if (Lua_BlackJack_ProjectL_UI_ArenaDefendUITask.<>f__mg$cache3D == null)
		{
			Lua_BlackJack_ProjectL_UI_ArenaDefendUITask.<>f__mg$cache3D = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ArenaDefendUITask.__callBase_IsLoadingCustomAssets);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_ArenaDefendUITask.<>f__mg$cache3D);
		if (Lua_BlackJack_ProjectL_UI_ArenaDefendUITask.<>f__mg$cache3E == null)
		{
			Lua_BlackJack_ProjectL_UI_ArenaDefendUITask.<>f__mg$cache3E = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ArenaDefendUITask.__callBase_IsPipeLineRunning);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_ArenaDefendUITask.<>f__mg$cache3E);
		if (Lua_BlackJack_ProjectL_UI_ArenaDefendUITask.<>f__mg$cache3F == null)
		{
			Lua_BlackJack_ProjectL_UI_ArenaDefendUITask.<>f__mg$cache3F = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ArenaDefendUITask.__callBase_IsOpeningUI);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_ArenaDefendUITask.<>f__mg$cache3F);
		if (Lua_BlackJack_ProjectL_UI_ArenaDefendUITask.<>f__mg$cache40 == null)
		{
			Lua_BlackJack_ProjectL_UI_ArenaDefendUITask.<>f__mg$cache40 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ArenaDefendUITask.__callBase_ReturnPrevUITask);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_ArenaDefendUITask.<>f__mg$cache40);
		if (Lua_BlackJack_ProjectL_UI_ArenaDefendUITask.<>f__mg$cache41 == null)
		{
			Lua_BlackJack_ProjectL_UI_ArenaDefendUITask.<>f__mg$cache41 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ArenaDefendUITask.__callBase_ClearUnusedDynamicResourceCache);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_ArenaDefendUITask.<>f__mg$cache41);
		if (Lua_BlackJack_ProjectL_UI_ArenaDefendUITask.<>f__mg$cache42 == null)
		{
			Lua_BlackJack_ProjectL_UI_ArenaDefendUITask.<>f__mg$cache42 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ArenaDefendUITask.__callBase_OnMemoryWarning);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_ArenaDefendUITask.<>f__mg$cache42);
		if (Lua_BlackJack_ProjectL_UI_ArenaDefendUITask.<>f__mg$cache43 == null)
		{
			Lua_BlackJack_ProjectL_UI_ArenaDefendUITask.<>f__mg$cache43 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ArenaDefendUITask.CompareHero_s);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_ArenaDefendUITask.<>f__mg$cache43);
		if (Lua_BlackJack_ProjectL_UI_ArenaDefendUITask.<>f__mg$cache44 == null)
		{
			Lua_BlackJack_ProjectL_UI_ArenaDefendUITask.<>f__mg$cache44 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ArenaDefendUITask.CompareHeroActionValue_s);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_ArenaDefendUITask.<>f__mg$cache44);
		string name = "m_layerDescArray";
		if (Lua_BlackJack_ProjectL_UI_ArenaDefendUITask.<>f__mg$cache45 == null)
		{
			Lua_BlackJack_ProjectL_UI_ArenaDefendUITask.<>f__mg$cache45 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ArenaDefendUITask.get_m_layerDescArray);
		}
		LuaCSFunction get = Lua_BlackJack_ProjectL_UI_ArenaDefendUITask.<>f__mg$cache45;
		if (Lua_BlackJack_ProjectL_UI_ArenaDefendUITask.<>f__mg$cache46 == null)
		{
			Lua_BlackJack_ProjectL_UI_ArenaDefendUITask.<>f__mg$cache46 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ArenaDefendUITask.set_m_layerDescArray);
		}
		LuaObject.addMember(l, name, get, Lua_BlackJack_ProjectL_UI_ArenaDefendUITask.<>f__mg$cache46, true);
		string name2 = "m_uiCtrlDescArray";
		if (Lua_BlackJack_ProjectL_UI_ArenaDefendUITask.<>f__mg$cache47 == null)
		{
			Lua_BlackJack_ProjectL_UI_ArenaDefendUITask.<>f__mg$cache47 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ArenaDefendUITask.get_m_uiCtrlDescArray);
		}
		LuaCSFunction get2 = Lua_BlackJack_ProjectL_UI_ArenaDefendUITask.<>f__mg$cache47;
		if (Lua_BlackJack_ProjectL_UI_ArenaDefendUITask.<>f__mg$cache48 == null)
		{
			Lua_BlackJack_ProjectL_UI_ArenaDefendUITask.<>f__mg$cache48 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ArenaDefendUITask.set_m_uiCtrlDescArray);
		}
		LuaObject.addMember(l, name2, get2, Lua_BlackJack_ProjectL_UI_ArenaDefendUITask.<>f__mg$cache48, true);
		string name3 = "m_arenaDefendUIController";
		if (Lua_BlackJack_ProjectL_UI_ArenaDefendUITask.<>f__mg$cache49 == null)
		{
			Lua_BlackJack_ProjectL_UI_ArenaDefendUITask.<>f__mg$cache49 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ArenaDefendUITask.get_m_arenaDefendUIController);
		}
		LuaCSFunction get3 = Lua_BlackJack_ProjectL_UI_ArenaDefendUITask.<>f__mg$cache49;
		if (Lua_BlackJack_ProjectL_UI_ArenaDefendUITask.<>f__mg$cache4A == null)
		{
			Lua_BlackJack_ProjectL_UI_ArenaDefendUITask.<>f__mg$cache4A = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ArenaDefendUITask.set_m_arenaDefendUIController);
		}
		LuaObject.addMember(l, name3, get3, Lua_BlackJack_ProjectL_UI_ArenaDefendUITask.<>f__mg$cache4A, true);
		string name4 = "m_arenaDefendMapUIController";
		if (Lua_BlackJack_ProjectL_UI_ArenaDefendUITask.<>f__mg$cache4B == null)
		{
			Lua_BlackJack_ProjectL_UI_ArenaDefendUITask.<>f__mg$cache4B = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ArenaDefendUITask.get_m_arenaDefendMapUIController);
		}
		LuaCSFunction get4 = Lua_BlackJack_ProjectL_UI_ArenaDefendUITask.<>f__mg$cache4B;
		if (Lua_BlackJack_ProjectL_UI_ArenaDefendUITask.<>f__mg$cache4C == null)
		{
			Lua_BlackJack_ProjectL_UI_ArenaDefendUITask.<>f__mg$cache4C = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ArenaDefendUITask.set_m_arenaDefendMapUIController);
		}
		LuaObject.addMember(l, name4, get4, Lua_BlackJack_ProjectL_UI_ArenaDefendUITask.<>f__mg$cache4C, true);
		string name5 = "m_arenaDefendSceneUIController";
		if (Lua_BlackJack_ProjectL_UI_ArenaDefendUITask.<>f__mg$cache4D == null)
		{
			Lua_BlackJack_ProjectL_UI_ArenaDefendUITask.<>f__mg$cache4D = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ArenaDefendUITask.get_m_arenaDefendSceneUIController);
		}
		LuaCSFunction get5 = Lua_BlackJack_ProjectL_UI_ArenaDefendUITask.<>f__mg$cache4D;
		if (Lua_BlackJack_ProjectL_UI_ArenaDefendUITask.<>f__mg$cache4E == null)
		{
			Lua_BlackJack_ProjectL_UI_ArenaDefendUITask.<>f__mg$cache4E = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ArenaDefendUITask.set_m_arenaDefendSceneUIController);
		}
		LuaObject.addMember(l, name5, get5, Lua_BlackJack_ProjectL_UI_ArenaDefendUITask.<>f__mg$cache4E, true);
		string name6 = "m_battlePrepareActorInfoUIController";
		if (Lua_BlackJack_ProjectL_UI_ArenaDefendUITask.<>f__mg$cache4F == null)
		{
			Lua_BlackJack_ProjectL_UI_ArenaDefendUITask.<>f__mg$cache4F = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ArenaDefendUITask.get_m_battlePrepareActorInfoUIController);
		}
		LuaCSFunction get6 = Lua_BlackJack_ProjectL_UI_ArenaDefendUITask.<>f__mg$cache4F;
		if (Lua_BlackJack_ProjectL_UI_ArenaDefendUITask.<>f__mg$cache50 == null)
		{
			Lua_BlackJack_ProjectL_UI_ArenaDefendUITask.<>f__mg$cache50 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ArenaDefendUITask.set_m_battlePrepareActorInfoUIController);
		}
		LuaObject.addMember(l, name6, get6, Lua_BlackJack_ProjectL_UI_ArenaDefendUITask.<>f__mg$cache50, true);
		string name7 = "m_arenaDefendBattle";
		if (Lua_BlackJack_ProjectL_UI_ArenaDefendUITask.<>f__mg$cache51 == null)
		{
			Lua_BlackJack_ProjectL_UI_ArenaDefendUITask.<>f__mg$cache51 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ArenaDefendUITask.get_m_arenaDefendBattle);
		}
		LuaCSFunction get7 = Lua_BlackJack_ProjectL_UI_ArenaDefendUITask.<>f__mg$cache51;
		if (Lua_BlackJack_ProjectL_UI_ArenaDefendUITask.<>f__mg$cache52 == null)
		{
			Lua_BlackJack_ProjectL_UI_ArenaDefendUITask.<>f__mg$cache52 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ArenaDefendUITask.set_m_arenaDefendBattle);
		}
		LuaObject.addMember(l, name7, get7, Lua_BlackJack_ProjectL_UI_ArenaDefendUITask.<>f__mg$cache52, true);
		string name8 = "m_defendPositions";
		if (Lua_BlackJack_ProjectL_UI_ArenaDefendUITask.<>f__mg$cache53 == null)
		{
			Lua_BlackJack_ProjectL_UI_ArenaDefendUITask.<>f__mg$cache53 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ArenaDefendUITask.get_m_defendPositions);
		}
		LuaCSFunction get8 = Lua_BlackJack_ProjectL_UI_ArenaDefendUITask.<>f__mg$cache53;
		if (Lua_BlackJack_ProjectL_UI_ArenaDefendUITask.<>f__mg$cache54 == null)
		{
			Lua_BlackJack_ProjectL_UI_ArenaDefendUITask.<>f__mg$cache54 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ArenaDefendUITask.set_m_defendPositions);
		}
		LuaObject.addMember(l, name8, get8, Lua_BlackJack_ProjectL_UI_ArenaDefendUITask.<>f__mg$cache54, true);
		string name9 = "m_attackPositions";
		if (Lua_BlackJack_ProjectL_UI_ArenaDefendUITask.<>f__mg$cache55 == null)
		{
			Lua_BlackJack_ProjectL_UI_ArenaDefendUITask.<>f__mg$cache55 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ArenaDefendUITask.get_m_attackPositions);
		}
		LuaCSFunction get9 = Lua_BlackJack_ProjectL_UI_ArenaDefendUITask.<>f__mg$cache55;
		if (Lua_BlackJack_ProjectL_UI_ArenaDefendUITask.<>f__mg$cache56 == null)
		{
			Lua_BlackJack_ProjectL_UI_ArenaDefendUITask.<>f__mg$cache56 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ArenaDefendUITask.set_m_attackPositions);
		}
		LuaObject.addMember(l, name9, get9, Lua_BlackJack_ProjectL_UI_ArenaDefendUITask.<>f__mg$cache56, true);
		string name10 = "m_arenaBattleInfos";
		if (Lua_BlackJack_ProjectL_UI_ArenaDefendUITask.<>f__mg$cache57 == null)
		{
			Lua_BlackJack_ProjectL_UI_ArenaDefendUITask.<>f__mg$cache57 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ArenaDefendUITask.get_m_arenaBattleInfos);
		}
		LuaCSFunction get10 = Lua_BlackJack_ProjectL_UI_ArenaDefendUITask.<>f__mg$cache57;
		if (Lua_BlackJack_ProjectL_UI_ArenaDefendUITask.<>f__mg$cache58 == null)
		{
			Lua_BlackJack_ProjectL_UI_ArenaDefendUITask.<>f__mg$cache58 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ArenaDefendUITask.set_m_arenaBattleInfos);
		}
		LuaObject.addMember(l, name10, get10, Lua_BlackJack_ProjectL_UI_ArenaDefendUITask.<>f__mg$cache58, true);
		string name11 = "m_defendRuleInfos";
		if (Lua_BlackJack_ProjectL_UI_ArenaDefendUITask.<>f__mg$cache59 == null)
		{
			Lua_BlackJack_ProjectL_UI_ArenaDefendUITask.<>f__mg$cache59 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ArenaDefendUITask.get_m_defendRuleInfos);
		}
		LuaCSFunction get11 = Lua_BlackJack_ProjectL_UI_ArenaDefendUITask.<>f__mg$cache59;
		if (Lua_BlackJack_ProjectL_UI_ArenaDefendUITask.<>f__mg$cache5A == null)
		{
			Lua_BlackJack_ProjectL_UI_ArenaDefendUITask.<>f__mg$cache5A = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ArenaDefendUITask.set_m_defendRuleInfos);
		}
		LuaObject.addMember(l, name11, get11, Lua_BlackJack_ProjectL_UI_ArenaDefendUITask.<>f__mg$cache5A, true);
		string name12 = "m_playerBattleHeros";
		if (Lua_BlackJack_ProjectL_UI_ArenaDefendUITask.<>f__mg$cache5B == null)
		{
			Lua_BlackJack_ProjectL_UI_ArenaDefendUITask.<>f__mg$cache5B = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ArenaDefendUITask.get_m_playerBattleHeros);
		}
		LuaCSFunction get12 = Lua_BlackJack_ProjectL_UI_ArenaDefendUITask.<>f__mg$cache5B;
		if (Lua_BlackJack_ProjectL_UI_ArenaDefendUITask.<>f__mg$cache5C == null)
		{
			Lua_BlackJack_ProjectL_UI_ArenaDefendUITask.<>f__mg$cache5C = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ArenaDefendUITask.set_m_playerBattleHeros);
		}
		LuaObject.addMember(l, name12, get12, Lua_BlackJack_ProjectL_UI_ArenaDefendUITask.<>f__mg$cache5C, true);
		string name13 = "m_defendStageHeros";
		if (Lua_BlackJack_ProjectL_UI_ArenaDefendUITask.<>f__mg$cache5D == null)
		{
			Lua_BlackJack_ProjectL_UI_ArenaDefendUITask.<>f__mg$cache5D = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ArenaDefendUITask.get_m_defendStageHeros);
		}
		LuaCSFunction get13 = Lua_BlackJack_ProjectL_UI_ArenaDefendUITask.<>f__mg$cache5D;
		if (Lua_BlackJack_ProjectL_UI_ArenaDefendUITask.<>f__mg$cache5E == null)
		{
			Lua_BlackJack_ProjectL_UI_ArenaDefendUITask.<>f__mg$cache5E = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ArenaDefendUITask.set_m_defendStageHeros);
		}
		LuaObject.addMember(l, name13, get13, Lua_BlackJack_ProjectL_UI_ArenaDefendUITask.<>f__mg$cache5E, true);
		string name14 = "m_trainingTechs";
		if (Lua_BlackJack_ProjectL_UI_ArenaDefendUITask.<>f__mg$cache5F == null)
		{
			Lua_BlackJack_ProjectL_UI_ArenaDefendUITask.<>f__mg$cache5F = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ArenaDefendUITask.get_m_trainingTechs);
		}
		LuaCSFunction get14 = Lua_BlackJack_ProjectL_UI_ArenaDefendUITask.<>f__mg$cache5F;
		if (Lua_BlackJack_ProjectL_UI_ArenaDefendUITask.<>f__mg$cache60 == null)
		{
			Lua_BlackJack_ProjectL_UI_ArenaDefendUITask.<>f__mg$cache60 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ArenaDefendUITask.set_m_trainingTechs);
		}
		LuaObject.addMember(l, name14, get14, Lua_BlackJack_ProjectL_UI_ArenaDefendUITask.<>f__mg$cache60, true);
		string name15 = "m_curBattleIndex";
		if (Lua_BlackJack_ProjectL_UI_ArenaDefendUITask.<>f__mg$cache61 == null)
		{
			Lua_BlackJack_ProjectL_UI_ArenaDefendUITask.<>f__mg$cache61 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ArenaDefendUITask.get_m_curBattleIndex);
		}
		LuaCSFunction get15 = Lua_BlackJack_ProjectL_UI_ArenaDefendUITask.<>f__mg$cache61;
		if (Lua_BlackJack_ProjectL_UI_ArenaDefendUITask.<>f__mg$cache62 == null)
		{
			Lua_BlackJack_ProjectL_UI_ArenaDefendUITask.<>f__mg$cache62 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ArenaDefendUITask.set_m_curBattleIndex);
		}
		LuaObject.addMember(l, name15, get15, Lua_BlackJack_ProjectL_UI_ArenaDefendUITask.<>f__mg$cache62, true);
		string name16 = "m_curDefendRuleIndex";
		if (Lua_BlackJack_ProjectL_UI_ArenaDefendUITask.<>f__mg$cache63 == null)
		{
			Lua_BlackJack_ProjectL_UI_ArenaDefendUITask.<>f__mg$cache63 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ArenaDefendUITask.get_m_curDefendRuleIndex);
		}
		LuaCSFunction get16 = Lua_BlackJack_ProjectL_UI_ArenaDefendUITask.<>f__mg$cache63;
		if (Lua_BlackJack_ProjectL_UI_ArenaDefendUITask.<>f__mg$cache64 == null)
		{
			Lua_BlackJack_ProjectL_UI_ArenaDefendUITask.<>f__mg$cache64 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ArenaDefendUITask.set_m_curDefendRuleIndex);
		}
		LuaObject.addMember(l, name16, get16, Lua_BlackJack_ProjectL_UI_ArenaDefendUITask.<>f__mg$cache64, true);
		string name17 = "m_configDataLoader";
		if (Lua_BlackJack_ProjectL_UI_ArenaDefendUITask.<>f__mg$cache65 == null)
		{
			Lua_BlackJack_ProjectL_UI_ArenaDefendUITask.<>f__mg$cache65 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ArenaDefendUITask.get_m_configDataLoader);
		}
		LuaCSFunction get17 = Lua_BlackJack_ProjectL_UI_ArenaDefendUITask.<>f__mg$cache65;
		if (Lua_BlackJack_ProjectL_UI_ArenaDefendUITask.<>f__mg$cache66 == null)
		{
			Lua_BlackJack_ProjectL_UI_ArenaDefendUITask.<>f__mg$cache66 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ArenaDefendUITask.set_m_configDataLoader);
		}
		LuaObject.addMember(l, name17, get17, Lua_BlackJack_ProjectL_UI_ArenaDefendUITask.<>f__mg$cache66, true);
		string name18 = "LayerDescArray";
		if (Lua_BlackJack_ProjectL_UI_ArenaDefendUITask.<>f__mg$cache67 == null)
		{
			Lua_BlackJack_ProjectL_UI_ArenaDefendUITask.<>f__mg$cache67 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ArenaDefendUITask.get_LayerDescArray);
		}
		LuaObject.addMember(l, name18, Lua_BlackJack_ProjectL_UI_ArenaDefendUITask.<>f__mg$cache67, null, true);
		string name19 = "UICtrlDescArray";
		if (Lua_BlackJack_ProjectL_UI_ArenaDefendUITask.<>f__mg$cache68 == null)
		{
			Lua_BlackJack_ProjectL_UI_ArenaDefendUITask.<>f__mg$cache68 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ArenaDefendUITask.get_UICtrlDescArray);
		}
		LuaObject.addMember(l, name19, Lua_BlackJack_ProjectL_UI_ArenaDefendUITask.<>f__mg$cache68, null, true);
		if (Lua_BlackJack_ProjectL_UI_ArenaDefendUITask.<>f__mg$cache69 == null)
		{
			Lua_BlackJack_ProjectL_UI_ArenaDefendUITask.<>f__mg$cache69 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ArenaDefendUITask.constructor);
		}
		LuaObject.createTypeMetatable(l, Lua_BlackJack_ProjectL_UI_ArenaDefendUITask.<>f__mg$cache69, typeof(ArenaDefendUITask), typeof(UITask));
	}

	// Token: 0x040111FB RID: 70139
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache0;

	// Token: 0x040111FC RID: 70140
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1;

	// Token: 0x040111FD RID: 70141
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2;

	// Token: 0x040111FE RID: 70142
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3;

	// Token: 0x040111FF RID: 70143
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache4;

	// Token: 0x04011200 RID: 70144
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache5;

	// Token: 0x04011201 RID: 70145
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache6;

	// Token: 0x04011202 RID: 70146
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache7;

	// Token: 0x04011203 RID: 70147
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache8;

	// Token: 0x04011204 RID: 70148
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache9;

	// Token: 0x04011205 RID: 70149
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheA;

	// Token: 0x04011206 RID: 70150
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheB;

	// Token: 0x04011207 RID: 70151
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheC;

	// Token: 0x04011208 RID: 70152
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheD;

	// Token: 0x04011209 RID: 70153
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheE;

	// Token: 0x0401120A RID: 70154
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheF;

	// Token: 0x0401120B RID: 70155
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache10;

	// Token: 0x0401120C RID: 70156
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache11;

	// Token: 0x0401120D RID: 70157
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache12;

	// Token: 0x0401120E RID: 70158
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache13;

	// Token: 0x0401120F RID: 70159
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache14;

	// Token: 0x04011210 RID: 70160
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache15;

	// Token: 0x04011211 RID: 70161
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache16;

	// Token: 0x04011212 RID: 70162
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache17;

	// Token: 0x04011213 RID: 70163
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache18;

	// Token: 0x04011214 RID: 70164
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache19;

	// Token: 0x04011215 RID: 70165
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1A;

	// Token: 0x04011216 RID: 70166
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1B;

	// Token: 0x04011217 RID: 70167
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1C;

	// Token: 0x04011218 RID: 70168
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1D;

	// Token: 0x04011219 RID: 70169
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1E;

	// Token: 0x0401121A RID: 70170
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1F;

	// Token: 0x0401121B RID: 70171
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache20;

	// Token: 0x0401121C RID: 70172
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache21;

	// Token: 0x0401121D RID: 70173
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache22;

	// Token: 0x0401121E RID: 70174
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache23;

	// Token: 0x0401121F RID: 70175
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache24;

	// Token: 0x04011220 RID: 70176
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache25;

	// Token: 0x04011221 RID: 70177
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache26;

	// Token: 0x04011222 RID: 70178
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache27;

	// Token: 0x04011223 RID: 70179
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache28;

	// Token: 0x04011224 RID: 70180
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache29;

	// Token: 0x04011225 RID: 70181
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2A;

	// Token: 0x04011226 RID: 70182
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2B;

	// Token: 0x04011227 RID: 70183
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2C;

	// Token: 0x04011228 RID: 70184
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2D;

	// Token: 0x04011229 RID: 70185
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2E;

	// Token: 0x0401122A RID: 70186
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2F;

	// Token: 0x0401122B RID: 70187
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache30;

	// Token: 0x0401122C RID: 70188
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache31;

	// Token: 0x0401122D RID: 70189
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache32;

	// Token: 0x0401122E RID: 70190
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache33;

	// Token: 0x0401122F RID: 70191
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache34;

	// Token: 0x04011230 RID: 70192
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache35;

	// Token: 0x04011231 RID: 70193
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache36;

	// Token: 0x04011232 RID: 70194
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache37;

	// Token: 0x04011233 RID: 70195
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache38;

	// Token: 0x04011234 RID: 70196
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache39;

	// Token: 0x04011235 RID: 70197
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3A;

	// Token: 0x04011236 RID: 70198
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3B;

	// Token: 0x04011237 RID: 70199
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3C;

	// Token: 0x04011238 RID: 70200
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3D;

	// Token: 0x04011239 RID: 70201
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3E;

	// Token: 0x0401123A RID: 70202
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3F;

	// Token: 0x0401123B RID: 70203
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache40;

	// Token: 0x0401123C RID: 70204
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache41;

	// Token: 0x0401123D RID: 70205
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache42;

	// Token: 0x0401123E RID: 70206
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache43;

	// Token: 0x0401123F RID: 70207
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache44;

	// Token: 0x04011240 RID: 70208
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache45;

	// Token: 0x04011241 RID: 70209
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache46;

	// Token: 0x04011242 RID: 70210
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache47;

	// Token: 0x04011243 RID: 70211
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache48;

	// Token: 0x04011244 RID: 70212
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache49;

	// Token: 0x04011245 RID: 70213
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache4A;

	// Token: 0x04011246 RID: 70214
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache4B;

	// Token: 0x04011247 RID: 70215
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache4C;

	// Token: 0x04011248 RID: 70216
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache4D;

	// Token: 0x04011249 RID: 70217
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache4E;

	// Token: 0x0401124A RID: 70218
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache4F;

	// Token: 0x0401124B RID: 70219
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache50;

	// Token: 0x0401124C RID: 70220
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache51;

	// Token: 0x0401124D RID: 70221
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache52;

	// Token: 0x0401124E RID: 70222
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache53;

	// Token: 0x0401124F RID: 70223
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache54;

	// Token: 0x04011250 RID: 70224
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache55;

	// Token: 0x04011251 RID: 70225
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache56;

	// Token: 0x04011252 RID: 70226
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache57;

	// Token: 0x04011253 RID: 70227
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache58;

	// Token: 0x04011254 RID: 70228
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache59;

	// Token: 0x04011255 RID: 70229
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache5A;

	// Token: 0x04011256 RID: 70230
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache5B;

	// Token: 0x04011257 RID: 70231
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache5C;

	// Token: 0x04011258 RID: 70232
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache5D;

	// Token: 0x04011259 RID: 70233
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache5E;

	// Token: 0x0401125A RID: 70234
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache5F;

	// Token: 0x0401125B RID: 70235
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache60;

	// Token: 0x0401125C RID: 70236
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache61;

	// Token: 0x0401125D RID: 70237
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache62;

	// Token: 0x0401125E RID: 70238
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache63;

	// Token: 0x0401125F RID: 70239
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache64;

	// Token: 0x04011260 RID: 70240
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache65;

	// Token: 0x04011261 RID: 70241
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache66;

	// Token: 0x04011262 RID: 70242
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache67;

	// Token: 0x04011263 RID: 70243
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache68;

	// Token: 0x04011264 RID: 70244
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache69;
}
