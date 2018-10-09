using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using BlackJack.BJFramework.Runtime.UI;
using BlackJack.ConfigData;
using BlackJack.ProjectL.UI;
using SLua;
using UnityEngine.Scripting;

// Token: 0x020014ED RID: 5357
[Preserve]
public class Lua_BlackJack_ProjectL_UI_HeroTrainningUITask : LuaObject
{
	// Token: 0x0601F9BA RID: 129466 RVA: 0x00A65564 File Offset: 0x00A63764
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int constructor(IntPtr l)
	{
		int result;
		try
		{
			string name;
			LuaObject.checkType(l, 2, out name);
			HeroTrainningUITask o = new HeroTrainningUITask(name);
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

	// Token: 0x0601F9BB RID: 129467 RVA: 0x00A655B8 File Offset: 0x00A637B8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int OnStart(IntPtr l)
	{
		int result;
		try
		{
			HeroTrainningUITask heroTrainningUITask = (HeroTrainningUITask)LuaObject.checkSelf(l);
			UIIntent intent;
			LuaObject.checkType<UIIntent>(l, 2, out intent);
			bool b = heroTrainningUITask.m_luaExportHelper.OnStart(intent);
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

	// Token: 0x0601F9BC RID: 129468 RVA: 0x00A65620 File Offset: 0x00A63820
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int OnResume(IntPtr l)
	{
		int result;
		try
		{
			HeroTrainningUITask heroTrainningUITask = (HeroTrainningUITask)LuaObject.checkSelf(l);
			UIIntent intent;
			LuaObject.checkType<UIIntent>(l, 2, out intent);
			bool b = heroTrainningUITask.m_luaExportHelper.OnResume(intent);
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

	// Token: 0x0601F9BD RID: 129469 RVA: 0x00A65688 File Offset: 0x00A63888
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int InitDataFromUIIntent(IntPtr l)
	{
		int result;
		try
		{
			HeroTrainningUITask heroTrainningUITask = (HeroTrainningUITask)LuaObject.checkSelf(l);
			UIIntent intent;
			LuaObject.checkType<UIIntent>(l, 2, out intent);
			heroTrainningUITask.m_luaExportHelper.InitDataFromUIIntent(intent);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601F9BE RID: 129470 RVA: 0x00A656E4 File Offset: 0x00A638E4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int IsNeedLoadDynamicRes(IntPtr l)
	{
		int result;
		try
		{
			HeroTrainningUITask heroTrainningUITask = (HeroTrainningUITask)LuaObject.checkSelf(l);
			bool b = heroTrainningUITask.m_luaExportHelper.IsNeedLoadDynamicRes();
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

	// Token: 0x0601F9BF RID: 129471 RVA: 0x00A65740 File Offset: 0x00A63940
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int InitAllUIControllers(IntPtr l)
	{
		int result;
		try
		{
			HeroTrainningUITask heroTrainningUITask = (HeroTrainningUITask)LuaObject.checkSelf(l);
			heroTrainningUITask.m_luaExportHelper.InitAllUIControllers();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601F9C0 RID: 129472 RVA: 0x00A65794 File Offset: 0x00A63994
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int ClearAllContextAndRes(IntPtr l)
	{
		int result;
		try
		{
			HeroTrainningUITask heroTrainningUITask = (HeroTrainningUITask)LuaObject.checkSelf(l);
			heroTrainningUITask.m_luaExportHelper.ClearAllContextAndRes();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601F9C1 RID: 129473 RVA: 0x00A657E8 File Offset: 0x00A639E8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int InitHeroTrainningUIController(IntPtr l)
	{
		int result;
		try
		{
			HeroTrainningUITask heroTrainningUITask = (HeroTrainningUITask)LuaObject.checkSelf(l);
			heroTrainningUITask.m_luaExportHelper.InitHeroTrainningUIController();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601F9C2 RID: 129474 RVA: 0x00A6583C File Offset: 0x00A63A3C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int UninitHeroTrainningUIController(IntPtr l)
	{
		int result;
		try
		{
			HeroTrainningUITask heroTrainningUITask = (HeroTrainningUITask)LuaObject.checkSelf(l);
			heroTrainningUITask.m_luaExportHelper.UninitHeroTrainningUIController();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601F9C3 RID: 129475 RVA: 0x00A65890 File Offset: 0x00A63A90
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int UpdateView(IntPtr l)
	{
		int result;
		try
		{
			HeroTrainningUITask heroTrainningUITask = (HeroTrainningUITask)LuaObject.checkSelf(l);
			heroTrainningUITask.m_luaExportHelper.UpdateView();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601F9C4 RID: 129476 RVA: 0x00A658E4 File Offset: 0x00A63AE4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int HeroTrainningUIController_OnReturn(IntPtr l)
	{
		int result;
		try
		{
			HeroTrainningUITask heroTrainningUITask = (HeroTrainningUITask)LuaObject.checkSelf(l);
			heroTrainningUITask.m_luaExportHelper.HeroTrainningUIController_OnReturn();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601F9C5 RID: 129477 RVA: 0x00A65938 File Offset: 0x00A63B38
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int HeroTrainningUIController_OnShowHelp(IntPtr l)
	{
		int result;
		try
		{
			HeroTrainningUITask heroTrainningUITask = (HeroTrainningUITask)LuaObject.checkSelf(l);
			heroTrainningUITask.m_luaExportHelper.HeroTrainningUIController_OnShowHelp();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601F9C6 RID: 129478 RVA: 0x00A6598C File Offset: 0x00A63B8C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int HeroTrainningUIController_OnShowTeam(IntPtr l)
	{
		int result;
		try
		{
			HeroTrainningUITask heroTrainningUITask = (HeroTrainningUITask)LuaObject.checkSelf(l);
			heroTrainningUITask.m_luaExportHelper.HeroTrainningUIController_OnShowTeam();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601F9C7 RID: 129479 RVA: 0x00A659E0 File Offset: 0x00A63BE0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int TeamUITask_OnLoadAllResCompleted(IntPtr l)
	{
		int result;
		try
		{
			HeroTrainningUITask heroTrainningUITask = (HeroTrainningUITask)LuaObject.checkSelf(l);
			heroTrainningUITask.m_luaExportHelper.TeamUITask_OnLoadAllResCompleted();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601F9C8 RID: 129480 RVA: 0x00A65A34 File Offset: 0x00A63C34
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int HeroTrainningUIController_OnStartHeroTrainningLevel(IntPtr l)
	{
		int result;
		try
		{
			HeroTrainningUITask heroTrainningUITask = (HeroTrainningUITask)LuaObject.checkSelf(l);
			ConfigDataHeroTrainningLevelInfo levelInfo;
			LuaObject.checkType<ConfigDataHeroTrainningLevelInfo>(l, 2, out levelInfo);
			heroTrainningUITask.m_luaExportHelper.HeroTrainningUIController_OnStartHeroTrainningLevel(levelInfo);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601F9C9 RID: 129481 RVA: 0x00A65A90 File Offset: 0x00A63C90
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_OnStart(IntPtr l)
	{
		int result;
		try
		{
			HeroTrainningUITask heroTrainningUITask = (HeroTrainningUITask)LuaObject.checkSelf(l);
			UIIntent intent;
			LuaObject.checkType<UIIntent>(l, 2, out intent);
			bool b = heroTrainningUITask.m_luaExportHelper.__callBase_OnStart(intent);
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

	// Token: 0x0601F9CA RID: 129482 RVA: 0x00A65AF8 File Offset: 0x00A63CF8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_OnStop(IntPtr l)
	{
		int result;
		try
		{
			HeroTrainningUITask heroTrainningUITask = (HeroTrainningUITask)LuaObject.checkSelf(l);
			heroTrainningUITask.m_luaExportHelper.__callBase_OnStop();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601F9CB RID: 129483 RVA: 0x00A65B4C File Offset: 0x00A63D4C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_OnPause(IntPtr l)
	{
		int result;
		try
		{
			HeroTrainningUITask heroTrainningUITask = (HeroTrainningUITask)LuaObject.checkSelf(l);
			heroTrainningUITask.m_luaExportHelper.__callBase_OnPause();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601F9CC RID: 129484 RVA: 0x00A65BA0 File Offset: 0x00A63DA0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_OnResume(IntPtr l)
	{
		int result;
		try
		{
			HeroTrainningUITask heroTrainningUITask = (HeroTrainningUITask)LuaObject.checkSelf(l);
			UIIntent intent;
			LuaObject.checkType<UIIntent>(l, 2, out intent);
			bool b = heroTrainningUITask.m_luaExportHelper.__callBase_OnResume(intent);
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

	// Token: 0x0601F9CD RID: 129485 RVA: 0x00A65C08 File Offset: 0x00A63E08
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_OnNewIntent(IntPtr l)
	{
		int result;
		try
		{
			HeroTrainningUITask heroTrainningUITask = (HeroTrainningUITask)LuaObject.checkSelf(l);
			UIIntent intent;
			LuaObject.checkType<UIIntent>(l, 2, out intent);
			bool b = heroTrainningUITask.m_luaExportHelper.__callBase_OnNewIntent(intent);
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

	// Token: 0x0601F9CE RID: 129486 RVA: 0x00A65C70 File Offset: 0x00A63E70
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_EnableUIInput(IntPtr l)
	{
		int result;
		try
		{
			HeroTrainningUITask heroTrainningUITask = (HeroTrainningUITask)LuaObject.checkSelf(l);
			bool isEnable;
			LuaObject.checkType(l, 2, out isEnable);
			bool? isGlobalEnable;
			LuaObject.checkNullable<bool>(l, 3, out isGlobalEnable);
			heroTrainningUITask.m_luaExportHelper.__callBase_EnableUIInput(isEnable, isGlobalEnable);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601F9CF RID: 129487 RVA: 0x00A65CDC File Offset: 0x00A63EDC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_IsNeedLoadDynamicRes(IntPtr l)
	{
		int result;
		try
		{
			HeroTrainningUITask heroTrainningUITask = (HeroTrainningUITask)LuaObject.checkSelf(l);
			bool b = heroTrainningUITask.m_luaExportHelper.__callBase_IsNeedLoadDynamicRes();
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

	// Token: 0x0601F9D0 RID: 129488 RVA: 0x00A65D38 File Offset: 0x00A63F38
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_CollectAllDynamicResForLoad(IntPtr l)
	{
		int result;
		try
		{
			HeroTrainningUITask heroTrainningUITask = (HeroTrainningUITask)LuaObject.checkSelf(l);
			List<string> o = heroTrainningUITask.m_luaExportHelper.__callBase_CollectAllDynamicResForLoad();
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

	// Token: 0x0601F9D1 RID: 129489 RVA: 0x00A65D94 File Offset: 0x00A63F94
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_RegisterPlayerContextEvents(IntPtr l)
	{
		int result;
		try
		{
			HeroTrainningUITask heroTrainningUITask = (HeroTrainningUITask)LuaObject.checkSelf(l);
			heroTrainningUITask.m_luaExportHelper.__callBase_RegisterPlayerContextEvents();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601F9D2 RID: 129490 RVA: 0x00A65DE8 File Offset: 0x00A63FE8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_UnregisterPlayerContextEvents(IntPtr l)
	{
		int result;
		try
		{
			HeroTrainningUITask heroTrainningUITask = (HeroTrainningUITask)LuaObject.checkSelf(l);
			heroTrainningUITask.m_luaExportHelper.__callBase_UnregisterPlayerContextEvents();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601F9D3 RID: 129491 RVA: 0x00A65E3C File Offset: 0x00A6403C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_PostUpdateView(IntPtr l)
	{
		int result;
		try
		{
			HeroTrainningUITask heroTrainningUITask = (HeroTrainningUITask)LuaObject.checkSelf(l);
			heroTrainningUITask.m_luaExportHelper.__callBase_PostUpdateView();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601F9D4 RID: 129492 RVA: 0x00A65E90 File Offset: 0x00A64090
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_CollectPreloadResourceList(IntPtr l)
	{
		int result;
		try
		{
			HeroTrainningUITask heroTrainningUITask = (HeroTrainningUITask)LuaObject.checkSelf(l);
			heroTrainningUITask.m_luaExportHelper.__callBase_CollectPreloadResourceList();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601F9D5 RID: 129493 RVA: 0x00A65EE4 File Offset: 0x00A640E4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_ClearAssetList(IntPtr l)
	{
		int result;
		try
		{
			HeroTrainningUITask heroTrainningUITask = (HeroTrainningUITask)LuaObject.checkSelf(l);
			heroTrainningUITask.m_luaExportHelper.__callBase_ClearAssetList();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601F9D6 RID: 129494 RVA: 0x00A65F38 File Offset: 0x00A64138
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_CollectAsset(IntPtr l)
	{
		int result;
		try
		{
			HeroTrainningUITask heroTrainningUITask = (HeroTrainningUITask)LuaObject.checkSelf(l);
			string assetName;
			LuaObject.checkType(l, 2, out assetName);
			heroTrainningUITask.m_luaExportHelper.__callBase_CollectAsset(assetName);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601F9D7 RID: 129495 RVA: 0x00A65F94 File Offset: 0x00A64194
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_CollectSpriteAsset(IntPtr l)
	{
		int result;
		try
		{
			HeroTrainningUITask heroTrainningUITask = (HeroTrainningUITask)LuaObject.checkSelf(l);
			string assetName;
			LuaObject.checkType(l, 2, out assetName);
			heroTrainningUITask.m_luaExportHelper.__callBase_CollectSpriteAsset(assetName);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601F9D8 RID: 129496 RVA: 0x00A65FF0 File Offset: 0x00A641F0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_CollectFxAsset(IntPtr l)
	{
		int result;
		try
		{
			HeroTrainningUITask heroTrainningUITask = (HeroTrainningUITask)LuaObject.checkSelf(l);
			string assetName;
			LuaObject.checkType(l, 2, out assetName);
			heroTrainningUITask.m_luaExportHelper.__callBase_CollectFxAsset(assetName);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601F9D9 RID: 129497 RVA: 0x00A6604C File Offset: 0x00A6424C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_StartLoadCustomAssets(IntPtr l)
	{
		int result;
		try
		{
			HeroTrainningUITask heroTrainningUITask = (HeroTrainningUITask)LuaObject.checkSelf(l);
			Action onLoadCompleted;
			LuaObject.checkDelegate<Action>(l, 2, out onLoadCompleted);
			heroTrainningUITask.m_luaExportHelper.__callBase_StartLoadCustomAssets(onLoadCompleted);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601F9DA RID: 129498 RVA: 0x00A660A8 File Offset: 0x00A642A8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_IsLoadingCustomAssets(IntPtr l)
	{
		int result;
		try
		{
			HeroTrainningUITask heroTrainningUITask = (HeroTrainningUITask)LuaObject.checkSelf(l);
			bool b = heroTrainningUITask.m_luaExportHelper.__callBase_IsLoadingCustomAssets();
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

	// Token: 0x0601F9DB RID: 129499 RVA: 0x00A66104 File Offset: 0x00A64304
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_IsPipeLineRunning(IntPtr l)
	{
		int result;
		try
		{
			HeroTrainningUITask heroTrainningUITask = (HeroTrainningUITask)LuaObject.checkSelf(l);
			bool b = heroTrainningUITask.m_luaExportHelper.__callBase_IsPipeLineRunning();
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

	// Token: 0x0601F9DC RID: 129500 RVA: 0x00A66160 File Offset: 0x00A64360
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_IsOpeningUI(IntPtr l)
	{
		int result;
		try
		{
			HeroTrainningUITask heroTrainningUITask = (HeroTrainningUITask)LuaObject.checkSelf(l);
			bool b = heroTrainningUITask.m_luaExportHelper.__callBase_IsOpeningUI();
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

	// Token: 0x0601F9DD RID: 129501 RVA: 0x00A661BC File Offset: 0x00A643BC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_ReturnPrevUITask(IntPtr l)
	{
		int result;
		try
		{
			HeroTrainningUITask heroTrainningUITask = (HeroTrainningUITask)LuaObject.checkSelf(l);
			UITaskBase o = heroTrainningUITask.m_luaExportHelper.__callBase_ReturnPrevUITask();
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

	// Token: 0x0601F9DE RID: 129502 RVA: 0x00A66218 File Offset: 0x00A64418
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_ClearUnusedDynamicResourceCache(IntPtr l)
	{
		int result;
		try
		{
			HeroTrainningUITask heroTrainningUITask = (HeroTrainningUITask)LuaObject.checkSelf(l);
			heroTrainningUITask.m_luaExportHelper.__callBase_ClearUnusedDynamicResourceCache();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601F9DF RID: 129503 RVA: 0x00A6626C File Offset: 0x00A6446C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_OnMemoryWarning(IntPtr l)
	{
		int result;
		try
		{
			HeroTrainningUITask heroTrainningUITask = (HeroTrainningUITask)LuaObject.checkSelf(l);
			heroTrainningUITask.m_luaExportHelper.__callBase_OnMemoryWarning();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601F9E0 RID: 129504 RVA: 0x00A662C0 File Offset: 0x00A644C0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_layerDescArray(IntPtr l)
	{
		int result;
		try
		{
			HeroTrainningUITask heroTrainningUITask = (HeroTrainningUITask)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, heroTrainningUITask.m_luaExportHelper.m_layerDescArray);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601F9E1 RID: 129505 RVA: 0x00A66318 File Offset: 0x00A64518
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_layerDescArray(IntPtr l)
	{
		int result;
		try
		{
			HeroTrainningUITask heroTrainningUITask = (HeroTrainningUITask)LuaObject.checkSelf(l);
			UITaskBase.LayerDesc[] layerDescArray;
			LuaObject.checkArray<UITaskBase.LayerDesc>(l, 2, out layerDescArray);
			heroTrainningUITask.m_luaExportHelper.m_layerDescArray = layerDescArray;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601F9E2 RID: 129506 RVA: 0x00A66374 File Offset: 0x00A64574
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_uiCtrlDescArray(IntPtr l)
	{
		int result;
		try
		{
			HeroTrainningUITask heroTrainningUITask = (HeroTrainningUITask)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, heroTrainningUITask.m_luaExportHelper.m_uiCtrlDescArray);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601F9E3 RID: 129507 RVA: 0x00A663CC File Offset: 0x00A645CC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_uiCtrlDescArray(IntPtr l)
	{
		int result;
		try
		{
			HeroTrainningUITask heroTrainningUITask = (HeroTrainningUITask)LuaObject.checkSelf(l);
			UITaskBase.UIControllerDesc[] uiCtrlDescArray;
			LuaObject.checkArray<UITaskBase.UIControllerDesc>(l, 2, out uiCtrlDescArray);
			heroTrainningUITask.m_luaExportHelper.m_uiCtrlDescArray = uiCtrlDescArray;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601F9E4 RID: 129508 RVA: 0x00A66428 File Offset: 0x00A64628
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_heroTrainningUIController(IntPtr l)
	{
		int result;
		try
		{
			HeroTrainningUITask heroTrainningUITask = (HeroTrainningUITask)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, heroTrainningUITask.m_luaExportHelper.m_heroTrainningUIController);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601F9E5 RID: 129509 RVA: 0x00A66480 File Offset: 0x00A64680
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_heroTrainningUIController(IntPtr l)
	{
		int result;
		try
		{
			HeroTrainningUITask heroTrainningUITask = (HeroTrainningUITask)LuaObject.checkSelf(l);
			HeroTrainningUIController heroTrainningUIController;
			LuaObject.checkType<HeroTrainningUIController>(l, 2, out heroTrainningUIController);
			heroTrainningUITask.m_luaExportHelper.m_heroTrainningUIController = heroTrainningUIController;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601F9E6 RID: 129510 RVA: 0x00A664DC File Offset: 0x00A646DC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_playerResourceUIController(IntPtr l)
	{
		int result;
		try
		{
			HeroTrainningUITask heroTrainningUITask = (HeroTrainningUITask)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, heroTrainningUITask.m_luaExportHelper.m_playerResourceUIController);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601F9E7 RID: 129511 RVA: 0x00A66534 File Offset: 0x00A64734
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_playerResourceUIController(IntPtr l)
	{
		int result;
		try
		{
			HeroTrainningUITask heroTrainningUITask = (HeroTrainningUITask)LuaObject.checkSelf(l);
			PlayerResourceUIController playerResourceUIController;
			LuaObject.checkType<PlayerResourceUIController>(l, 2, out playerResourceUIController);
			heroTrainningUITask.m_luaExportHelper.m_playerResourceUIController = playerResourceUIController;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601F9E8 RID: 129512 RVA: 0x00A66590 File Offset: 0x00A64790
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_heroTrainningInfo(IntPtr l)
	{
		int result;
		try
		{
			HeroTrainningUITask heroTrainningUITask = (HeroTrainningUITask)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, heroTrainningUITask.m_luaExportHelper.m_heroTrainningInfo);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601F9E9 RID: 129513 RVA: 0x00A665E8 File Offset: 0x00A647E8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_heroTrainningInfo(IntPtr l)
	{
		int result;
		try
		{
			HeroTrainningUITask heroTrainningUITask = (HeroTrainningUITask)LuaObject.checkSelf(l);
			ConfigDataHeroTrainningInfo heroTrainningInfo;
			LuaObject.checkType<ConfigDataHeroTrainningInfo>(l, 2, out heroTrainningInfo);
			heroTrainningUITask.m_luaExportHelper.m_heroTrainningInfo = heroTrainningInfo;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601F9EA RID: 129514 RVA: 0x00A66644 File Offset: 0x00A64844
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_LayerDescArray(IntPtr l)
	{
		int result;
		try
		{
			HeroTrainningUITask heroTrainningUITask = (HeroTrainningUITask)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, heroTrainningUITask.m_luaExportHelper.LayerDescArray);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601F9EB RID: 129515 RVA: 0x00A6669C File Offset: 0x00A6489C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_UICtrlDescArray(IntPtr l)
	{
		int result;
		try
		{
			HeroTrainningUITask heroTrainningUITask = (HeroTrainningUITask)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, heroTrainningUITask.m_luaExportHelper.UICtrlDescArray);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601F9EC RID: 129516 RVA: 0x00A666F4 File Offset: 0x00A648F4
	[Preserve]
	public static void reg(IntPtr l)
	{
		LuaObject.getTypeTable(l, "BlackJack.ProjectL.UI.HeroTrainningUITask");
		if (Lua_BlackJack_ProjectL_UI_HeroTrainningUITask.<>f__mg$cache0 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroTrainningUITask.<>f__mg$cache0 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroTrainningUITask.OnStart);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_HeroTrainningUITask.<>f__mg$cache0);
		if (Lua_BlackJack_ProjectL_UI_HeroTrainningUITask.<>f__mg$cache1 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroTrainningUITask.<>f__mg$cache1 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroTrainningUITask.OnResume);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_HeroTrainningUITask.<>f__mg$cache1);
		if (Lua_BlackJack_ProjectL_UI_HeroTrainningUITask.<>f__mg$cache2 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroTrainningUITask.<>f__mg$cache2 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroTrainningUITask.InitDataFromUIIntent);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_HeroTrainningUITask.<>f__mg$cache2);
		if (Lua_BlackJack_ProjectL_UI_HeroTrainningUITask.<>f__mg$cache3 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroTrainningUITask.<>f__mg$cache3 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroTrainningUITask.IsNeedLoadDynamicRes);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_HeroTrainningUITask.<>f__mg$cache3);
		if (Lua_BlackJack_ProjectL_UI_HeroTrainningUITask.<>f__mg$cache4 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroTrainningUITask.<>f__mg$cache4 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroTrainningUITask.InitAllUIControllers);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_HeroTrainningUITask.<>f__mg$cache4);
		if (Lua_BlackJack_ProjectL_UI_HeroTrainningUITask.<>f__mg$cache5 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroTrainningUITask.<>f__mg$cache5 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroTrainningUITask.ClearAllContextAndRes);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_HeroTrainningUITask.<>f__mg$cache5);
		if (Lua_BlackJack_ProjectL_UI_HeroTrainningUITask.<>f__mg$cache6 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroTrainningUITask.<>f__mg$cache6 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroTrainningUITask.InitHeroTrainningUIController);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_HeroTrainningUITask.<>f__mg$cache6);
		if (Lua_BlackJack_ProjectL_UI_HeroTrainningUITask.<>f__mg$cache7 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroTrainningUITask.<>f__mg$cache7 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroTrainningUITask.UninitHeroTrainningUIController);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_HeroTrainningUITask.<>f__mg$cache7);
		if (Lua_BlackJack_ProjectL_UI_HeroTrainningUITask.<>f__mg$cache8 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroTrainningUITask.<>f__mg$cache8 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroTrainningUITask.UpdateView);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_HeroTrainningUITask.<>f__mg$cache8);
		if (Lua_BlackJack_ProjectL_UI_HeroTrainningUITask.<>f__mg$cache9 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroTrainningUITask.<>f__mg$cache9 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroTrainningUITask.HeroTrainningUIController_OnReturn);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_HeroTrainningUITask.<>f__mg$cache9);
		if (Lua_BlackJack_ProjectL_UI_HeroTrainningUITask.<>f__mg$cacheA == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroTrainningUITask.<>f__mg$cacheA = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroTrainningUITask.HeroTrainningUIController_OnShowHelp);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_HeroTrainningUITask.<>f__mg$cacheA);
		if (Lua_BlackJack_ProjectL_UI_HeroTrainningUITask.<>f__mg$cacheB == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroTrainningUITask.<>f__mg$cacheB = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroTrainningUITask.HeroTrainningUIController_OnShowTeam);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_HeroTrainningUITask.<>f__mg$cacheB);
		if (Lua_BlackJack_ProjectL_UI_HeroTrainningUITask.<>f__mg$cacheC == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroTrainningUITask.<>f__mg$cacheC = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroTrainningUITask.TeamUITask_OnLoadAllResCompleted);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_HeroTrainningUITask.<>f__mg$cacheC);
		if (Lua_BlackJack_ProjectL_UI_HeroTrainningUITask.<>f__mg$cacheD == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroTrainningUITask.<>f__mg$cacheD = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroTrainningUITask.HeroTrainningUIController_OnStartHeroTrainningLevel);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_HeroTrainningUITask.<>f__mg$cacheD);
		if (Lua_BlackJack_ProjectL_UI_HeroTrainningUITask.<>f__mg$cacheE == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroTrainningUITask.<>f__mg$cacheE = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroTrainningUITask.__callBase_OnStart);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_HeroTrainningUITask.<>f__mg$cacheE);
		if (Lua_BlackJack_ProjectL_UI_HeroTrainningUITask.<>f__mg$cacheF == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroTrainningUITask.<>f__mg$cacheF = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroTrainningUITask.__callBase_OnStop);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_HeroTrainningUITask.<>f__mg$cacheF);
		if (Lua_BlackJack_ProjectL_UI_HeroTrainningUITask.<>f__mg$cache10 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroTrainningUITask.<>f__mg$cache10 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroTrainningUITask.__callBase_OnPause);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_HeroTrainningUITask.<>f__mg$cache10);
		if (Lua_BlackJack_ProjectL_UI_HeroTrainningUITask.<>f__mg$cache11 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroTrainningUITask.<>f__mg$cache11 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroTrainningUITask.__callBase_OnResume);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_HeroTrainningUITask.<>f__mg$cache11);
		if (Lua_BlackJack_ProjectL_UI_HeroTrainningUITask.<>f__mg$cache12 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroTrainningUITask.<>f__mg$cache12 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroTrainningUITask.__callBase_OnNewIntent);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_HeroTrainningUITask.<>f__mg$cache12);
		if (Lua_BlackJack_ProjectL_UI_HeroTrainningUITask.<>f__mg$cache13 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroTrainningUITask.<>f__mg$cache13 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroTrainningUITask.__callBase_EnableUIInput);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_HeroTrainningUITask.<>f__mg$cache13);
		if (Lua_BlackJack_ProjectL_UI_HeroTrainningUITask.<>f__mg$cache14 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroTrainningUITask.<>f__mg$cache14 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroTrainningUITask.__callBase_IsNeedLoadDynamicRes);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_HeroTrainningUITask.<>f__mg$cache14);
		if (Lua_BlackJack_ProjectL_UI_HeroTrainningUITask.<>f__mg$cache15 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroTrainningUITask.<>f__mg$cache15 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroTrainningUITask.__callBase_CollectAllDynamicResForLoad);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_HeroTrainningUITask.<>f__mg$cache15);
		if (Lua_BlackJack_ProjectL_UI_HeroTrainningUITask.<>f__mg$cache16 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroTrainningUITask.<>f__mg$cache16 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroTrainningUITask.__callBase_RegisterPlayerContextEvents);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_HeroTrainningUITask.<>f__mg$cache16);
		if (Lua_BlackJack_ProjectL_UI_HeroTrainningUITask.<>f__mg$cache17 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroTrainningUITask.<>f__mg$cache17 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroTrainningUITask.__callBase_UnregisterPlayerContextEvents);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_HeroTrainningUITask.<>f__mg$cache17);
		if (Lua_BlackJack_ProjectL_UI_HeroTrainningUITask.<>f__mg$cache18 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroTrainningUITask.<>f__mg$cache18 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroTrainningUITask.__callBase_PostUpdateView);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_HeroTrainningUITask.<>f__mg$cache18);
		if (Lua_BlackJack_ProjectL_UI_HeroTrainningUITask.<>f__mg$cache19 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroTrainningUITask.<>f__mg$cache19 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroTrainningUITask.__callBase_CollectPreloadResourceList);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_HeroTrainningUITask.<>f__mg$cache19);
		if (Lua_BlackJack_ProjectL_UI_HeroTrainningUITask.<>f__mg$cache1A == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroTrainningUITask.<>f__mg$cache1A = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroTrainningUITask.__callBase_ClearAssetList);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_HeroTrainningUITask.<>f__mg$cache1A);
		if (Lua_BlackJack_ProjectL_UI_HeroTrainningUITask.<>f__mg$cache1B == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroTrainningUITask.<>f__mg$cache1B = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroTrainningUITask.__callBase_CollectAsset);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_HeroTrainningUITask.<>f__mg$cache1B);
		if (Lua_BlackJack_ProjectL_UI_HeroTrainningUITask.<>f__mg$cache1C == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroTrainningUITask.<>f__mg$cache1C = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroTrainningUITask.__callBase_CollectSpriteAsset);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_HeroTrainningUITask.<>f__mg$cache1C);
		if (Lua_BlackJack_ProjectL_UI_HeroTrainningUITask.<>f__mg$cache1D == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroTrainningUITask.<>f__mg$cache1D = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroTrainningUITask.__callBase_CollectFxAsset);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_HeroTrainningUITask.<>f__mg$cache1D);
		if (Lua_BlackJack_ProjectL_UI_HeroTrainningUITask.<>f__mg$cache1E == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroTrainningUITask.<>f__mg$cache1E = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroTrainningUITask.__callBase_StartLoadCustomAssets);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_HeroTrainningUITask.<>f__mg$cache1E);
		if (Lua_BlackJack_ProjectL_UI_HeroTrainningUITask.<>f__mg$cache1F == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroTrainningUITask.<>f__mg$cache1F = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroTrainningUITask.__callBase_IsLoadingCustomAssets);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_HeroTrainningUITask.<>f__mg$cache1F);
		if (Lua_BlackJack_ProjectL_UI_HeroTrainningUITask.<>f__mg$cache20 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroTrainningUITask.<>f__mg$cache20 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroTrainningUITask.__callBase_IsPipeLineRunning);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_HeroTrainningUITask.<>f__mg$cache20);
		if (Lua_BlackJack_ProjectL_UI_HeroTrainningUITask.<>f__mg$cache21 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroTrainningUITask.<>f__mg$cache21 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroTrainningUITask.__callBase_IsOpeningUI);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_HeroTrainningUITask.<>f__mg$cache21);
		if (Lua_BlackJack_ProjectL_UI_HeroTrainningUITask.<>f__mg$cache22 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroTrainningUITask.<>f__mg$cache22 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroTrainningUITask.__callBase_ReturnPrevUITask);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_HeroTrainningUITask.<>f__mg$cache22);
		if (Lua_BlackJack_ProjectL_UI_HeroTrainningUITask.<>f__mg$cache23 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroTrainningUITask.<>f__mg$cache23 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroTrainningUITask.__callBase_ClearUnusedDynamicResourceCache);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_HeroTrainningUITask.<>f__mg$cache23);
		if (Lua_BlackJack_ProjectL_UI_HeroTrainningUITask.<>f__mg$cache24 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroTrainningUITask.<>f__mg$cache24 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroTrainningUITask.__callBase_OnMemoryWarning);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_HeroTrainningUITask.<>f__mg$cache24);
		string name = "m_layerDescArray";
		if (Lua_BlackJack_ProjectL_UI_HeroTrainningUITask.<>f__mg$cache25 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroTrainningUITask.<>f__mg$cache25 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroTrainningUITask.get_m_layerDescArray);
		}
		LuaCSFunction get = Lua_BlackJack_ProjectL_UI_HeroTrainningUITask.<>f__mg$cache25;
		if (Lua_BlackJack_ProjectL_UI_HeroTrainningUITask.<>f__mg$cache26 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroTrainningUITask.<>f__mg$cache26 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroTrainningUITask.set_m_layerDescArray);
		}
		LuaObject.addMember(l, name, get, Lua_BlackJack_ProjectL_UI_HeroTrainningUITask.<>f__mg$cache26, true);
		string name2 = "m_uiCtrlDescArray";
		if (Lua_BlackJack_ProjectL_UI_HeroTrainningUITask.<>f__mg$cache27 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroTrainningUITask.<>f__mg$cache27 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroTrainningUITask.get_m_uiCtrlDescArray);
		}
		LuaCSFunction get2 = Lua_BlackJack_ProjectL_UI_HeroTrainningUITask.<>f__mg$cache27;
		if (Lua_BlackJack_ProjectL_UI_HeroTrainningUITask.<>f__mg$cache28 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroTrainningUITask.<>f__mg$cache28 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroTrainningUITask.set_m_uiCtrlDescArray);
		}
		LuaObject.addMember(l, name2, get2, Lua_BlackJack_ProjectL_UI_HeroTrainningUITask.<>f__mg$cache28, true);
		string name3 = "m_heroTrainningUIController";
		if (Lua_BlackJack_ProjectL_UI_HeroTrainningUITask.<>f__mg$cache29 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroTrainningUITask.<>f__mg$cache29 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroTrainningUITask.get_m_heroTrainningUIController);
		}
		LuaCSFunction get3 = Lua_BlackJack_ProjectL_UI_HeroTrainningUITask.<>f__mg$cache29;
		if (Lua_BlackJack_ProjectL_UI_HeroTrainningUITask.<>f__mg$cache2A == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroTrainningUITask.<>f__mg$cache2A = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroTrainningUITask.set_m_heroTrainningUIController);
		}
		LuaObject.addMember(l, name3, get3, Lua_BlackJack_ProjectL_UI_HeroTrainningUITask.<>f__mg$cache2A, true);
		string name4 = "m_playerResourceUIController";
		if (Lua_BlackJack_ProjectL_UI_HeroTrainningUITask.<>f__mg$cache2B == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroTrainningUITask.<>f__mg$cache2B = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroTrainningUITask.get_m_playerResourceUIController);
		}
		LuaCSFunction get4 = Lua_BlackJack_ProjectL_UI_HeroTrainningUITask.<>f__mg$cache2B;
		if (Lua_BlackJack_ProjectL_UI_HeroTrainningUITask.<>f__mg$cache2C == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroTrainningUITask.<>f__mg$cache2C = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroTrainningUITask.set_m_playerResourceUIController);
		}
		LuaObject.addMember(l, name4, get4, Lua_BlackJack_ProjectL_UI_HeroTrainningUITask.<>f__mg$cache2C, true);
		string name5 = "m_heroTrainningInfo";
		if (Lua_BlackJack_ProjectL_UI_HeroTrainningUITask.<>f__mg$cache2D == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroTrainningUITask.<>f__mg$cache2D = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroTrainningUITask.get_m_heroTrainningInfo);
		}
		LuaCSFunction get5 = Lua_BlackJack_ProjectL_UI_HeroTrainningUITask.<>f__mg$cache2D;
		if (Lua_BlackJack_ProjectL_UI_HeroTrainningUITask.<>f__mg$cache2E == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroTrainningUITask.<>f__mg$cache2E = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroTrainningUITask.set_m_heroTrainningInfo);
		}
		LuaObject.addMember(l, name5, get5, Lua_BlackJack_ProjectL_UI_HeroTrainningUITask.<>f__mg$cache2E, true);
		string name6 = "LayerDescArray";
		if (Lua_BlackJack_ProjectL_UI_HeroTrainningUITask.<>f__mg$cache2F == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroTrainningUITask.<>f__mg$cache2F = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroTrainningUITask.get_LayerDescArray);
		}
		LuaObject.addMember(l, name6, Lua_BlackJack_ProjectL_UI_HeroTrainningUITask.<>f__mg$cache2F, null, true);
		string name7 = "UICtrlDescArray";
		if (Lua_BlackJack_ProjectL_UI_HeroTrainningUITask.<>f__mg$cache30 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroTrainningUITask.<>f__mg$cache30 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroTrainningUITask.get_UICtrlDescArray);
		}
		LuaObject.addMember(l, name7, Lua_BlackJack_ProjectL_UI_HeroTrainningUITask.<>f__mg$cache30, null, true);
		if (Lua_BlackJack_ProjectL_UI_HeroTrainningUITask.<>f__mg$cache31 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroTrainningUITask.<>f__mg$cache31 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroTrainningUITask.constructor);
		}
		LuaObject.createTypeMetatable(l, Lua_BlackJack_ProjectL_UI_HeroTrainningUITask.<>f__mg$cache31, typeof(HeroTrainningUITask), typeof(UITask));
	}

	// Token: 0x040159C2 RID: 88514
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache0;

	// Token: 0x040159C3 RID: 88515
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1;

	// Token: 0x040159C4 RID: 88516
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2;

	// Token: 0x040159C5 RID: 88517
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3;

	// Token: 0x040159C6 RID: 88518
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache4;

	// Token: 0x040159C7 RID: 88519
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache5;

	// Token: 0x040159C8 RID: 88520
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache6;

	// Token: 0x040159C9 RID: 88521
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache7;

	// Token: 0x040159CA RID: 88522
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache8;

	// Token: 0x040159CB RID: 88523
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache9;

	// Token: 0x040159CC RID: 88524
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheA;

	// Token: 0x040159CD RID: 88525
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheB;

	// Token: 0x040159CE RID: 88526
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheC;

	// Token: 0x040159CF RID: 88527
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheD;

	// Token: 0x040159D0 RID: 88528
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheE;

	// Token: 0x040159D1 RID: 88529
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheF;

	// Token: 0x040159D2 RID: 88530
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache10;

	// Token: 0x040159D3 RID: 88531
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache11;

	// Token: 0x040159D4 RID: 88532
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache12;

	// Token: 0x040159D5 RID: 88533
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache13;

	// Token: 0x040159D6 RID: 88534
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache14;

	// Token: 0x040159D7 RID: 88535
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache15;

	// Token: 0x040159D8 RID: 88536
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache16;

	// Token: 0x040159D9 RID: 88537
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache17;

	// Token: 0x040159DA RID: 88538
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache18;

	// Token: 0x040159DB RID: 88539
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache19;

	// Token: 0x040159DC RID: 88540
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1A;

	// Token: 0x040159DD RID: 88541
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1B;

	// Token: 0x040159DE RID: 88542
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1C;

	// Token: 0x040159DF RID: 88543
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1D;

	// Token: 0x040159E0 RID: 88544
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1E;

	// Token: 0x040159E1 RID: 88545
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1F;

	// Token: 0x040159E2 RID: 88546
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache20;

	// Token: 0x040159E3 RID: 88547
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache21;

	// Token: 0x040159E4 RID: 88548
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache22;

	// Token: 0x040159E5 RID: 88549
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache23;

	// Token: 0x040159E6 RID: 88550
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache24;

	// Token: 0x040159E7 RID: 88551
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache25;

	// Token: 0x040159E8 RID: 88552
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache26;

	// Token: 0x040159E9 RID: 88553
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache27;

	// Token: 0x040159EA RID: 88554
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache28;

	// Token: 0x040159EB RID: 88555
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache29;

	// Token: 0x040159EC RID: 88556
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2A;

	// Token: 0x040159ED RID: 88557
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2B;

	// Token: 0x040159EE RID: 88558
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2C;

	// Token: 0x040159EF RID: 88559
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2D;

	// Token: 0x040159F0 RID: 88560
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2E;

	// Token: 0x040159F1 RID: 88561
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2F;

	// Token: 0x040159F2 RID: 88562
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache30;

	// Token: 0x040159F3 RID: 88563
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache31;
}
