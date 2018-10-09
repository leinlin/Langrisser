using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using BlackJack.BJFramework.Runtime.UI;
using BlackJack.ConfigData;
using BlackJack.ProjectL.Common;
using BlackJack.ProjectL.PlayerContext;
using BlackJack.ProjectL.UI;
using SLua;
using UnityEngine.Scripting;

// Token: 0x020014D3 RID: 5331
[Preserve]
public class Lua_BlackJack_ProjectL_UI_HeroListUITask : LuaObject
{
	// Token: 0x0601F519 RID: 128281 RVA: 0x00A40364 File Offset: 0x00A3E564
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int constructor(IntPtr l)
	{
		int result;
		try
		{
			string name;
			LuaObject.checkType(l, 2, out name);
			HeroListUITask o = new HeroListUITask(name);
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

	// Token: 0x0601F51A RID: 128282 RVA: 0x00A403B8 File Offset: 0x00A3E5B8
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int HeroCharChangeTask_OnSkinChangedPreview(IntPtr l)
	{
		int result;
		try
		{
			HeroListUITask heroListUITask = (HeroListUITask)LuaObject.checkSelf(l);
			string spinePath;
			LuaObject.checkType(l, 2, out spinePath);
			int heroSkinId;
			LuaObject.checkType(l, 3, out heroSkinId);
			heroListUITask.HeroCharChangeTask_OnSkinChangedPreview(spinePath, heroSkinId);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601F51B RID: 128283 RVA: 0x00A4041C File Offset: 0x00A3E61C
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int HeroCharChangeTask_EventOnClose(IntPtr l)
	{
		int result;
		try
		{
			HeroListUITask heroListUITask = (HeroListUITask)LuaObject.checkSelf(l);
			heroListUITask.HeroCharChangeTask_EventOnClose();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601F51C RID: 128284 RVA: 0x00A40468 File Offset: 0x00A3E668
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int HeroCharChangeTask_OnAddSkinTicket(IntPtr l)
	{
		int result;
		try
		{
			HeroListUITask heroListUITask = (HeroListUITask)LuaObject.checkSelf(l);
			heroListUITask.HeroCharChangeTask_OnAddSkinTicket();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601F51D RID: 128285 RVA: 0x00A404B4 File Offset: 0x00A3E6B4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int StoreSoldierSkinDetailUITask_EventOnBuySuccessEnd(IntPtr l)
	{
		int result;
		try
		{
			HeroListUITask heroListUITask = (HeroListUITask)LuaObject.checkSelf(l);
			heroListUITask.StoreSoldierSkinDetailUITask_EventOnBuySuccessEnd();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601F51E RID: 128286 RVA: 0x00A40500 File Offset: 0x00A3E700
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int StoreSoldierSkinDetailUITask_EventOnClose(IntPtr l)
	{
		int result;
		try
		{
			HeroListUITask heroListUITask = (HeroListUITask)LuaObject.checkSelf(l);
			heroListUITask.StoreSoldierSkinDetailUITask_EventOnClose();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601F51F RID: 128287 RVA: 0x00A4054C File Offset: 0x00A3E74C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int OnStart(IntPtr l)
	{
		int result;
		try
		{
			HeroListUITask heroListUITask = (HeroListUITask)LuaObject.checkSelf(l);
			UIIntent intent;
			LuaObject.checkType<UIIntent>(l, 2, out intent);
			bool b = heroListUITask.m_luaExportHelper.OnStart(intent);
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

	// Token: 0x0601F520 RID: 128288 RVA: 0x00A405B4 File Offset: 0x00A3E7B4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int OnStop(IntPtr l)
	{
		int result;
		try
		{
			HeroListUITask heroListUITask = (HeroListUITask)LuaObject.checkSelf(l);
			heroListUITask.m_luaExportHelper.OnStop();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601F521 RID: 128289 RVA: 0x00A40608 File Offset: 0x00A3E808
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int SaveUIStateToIntent(IntPtr l)
	{
		int result;
		try
		{
			HeroListUITask heroListUITask = (HeroListUITask)LuaObject.checkSelf(l);
			heroListUITask.m_luaExportHelper.SaveUIStateToIntent();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601F522 RID: 128290 RVA: 0x00A4065C File Offset: 0x00A3E85C
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int GetUIStateFromIntent(IntPtr l)
	{
		int result;
		try
		{
			HeroListUITask heroListUITask = (HeroListUITask)LuaObject.checkSelf(l);
			UIIntent uiIntent;
			LuaObject.checkType<UIIntent>(l, 2, out uiIntent);
			heroListUITask.m_luaExportHelper.GetUIStateFromIntent(uiIntent);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601F523 RID: 128291 RVA: 0x00A406B8 File Offset: 0x00A3E8B8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int IsNeedLoadDynamicRes(IntPtr l)
	{
		int result;
		try
		{
			HeroListUITask heroListUITask = (HeroListUITask)LuaObject.checkSelf(l);
			bool b = heroListUITask.m_luaExportHelper.IsNeedLoadDynamicRes();
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

	// Token: 0x0601F524 RID: 128292 RVA: 0x00A40714 File Offset: 0x00A3E914
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int UpdataHeroListData(IntPtr l)
	{
		int result;
		try
		{
			HeroListUITask heroListUITask = (HeroListUITask)LuaObject.checkSelf(l);
			heroListUITask.m_luaExportHelper.UpdataHeroListData();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601F525 RID: 128293 RVA: 0x00A40768 File Offset: 0x00A3E968
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int UpdateHeroCardData(IntPtr l)
	{
		int result;
		try
		{
			HeroListUITask heroListUITask = (HeroListUITask)LuaObject.checkSelf(l);
			heroListUITask.m_luaExportHelper.UpdateHeroCardData();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601F526 RID: 128294 RVA: 0x00A407BC File Offset: 0x00A3E9BC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int UpdateCurrentHeroData(IntPtr l)
	{
		int result;
		try
		{
			HeroListUITask heroListUITask = (HeroListUITask)LuaObject.checkSelf(l);
			heroListUITask.m_luaExportHelper.UpdateCurrentHeroData();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601F527 RID: 128295 RVA: 0x00A40810 File Offset: 0x00A3EA10
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int UpdateSoldierModeData(IntPtr l)
	{
		int result;
		try
		{
			HeroListUITask heroListUITask = (HeroListUITask)LuaObject.checkSelf(l);
			heroListUITask.m_luaExportHelper.UpdateSoldierModeData();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601F528 RID: 128296 RVA: 0x00A40864 File Offset: 0x00A3EA64
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int UpdateJobModeData(IntPtr l)
	{
		int result;
		try
		{
			HeroListUITask heroListUITask = (HeroListUITask)LuaObject.checkSelf(l);
			heroListUITask.m_luaExportHelper.UpdateJobModeData();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601F529 RID: 128297 RVA: 0x00A408B8 File Offset: 0x00A3EAB8
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int HeroListItemCompare(IntPtr l)
	{
		int result;
		try
		{
			HeroListUITask heroListUITask = (HeroListUITask)LuaObject.checkSelf(l);
			Hero h;
			LuaObject.checkType<Hero>(l, 2, out h);
			Hero h2;
			LuaObject.checkType<Hero>(l, 3, out h2);
			int i = heroListUITask.m_luaExportHelper.HeroListItemCompare(h, h2);
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

	// Token: 0x0601F52A RID: 128298 RVA: 0x00A4092C File Offset: 0x00A3EB2C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int IsNeedLoadStaticRes(IntPtr l)
	{
		int result;
		try
		{
			HeroListUITask heroListUITask = (HeroListUITask)LuaObject.checkSelf(l);
			bool b = heroListUITask.m_luaExportHelper.IsNeedLoadStaticRes();
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

	// Token: 0x0601F52B RID: 128299 RVA: 0x00A40988 File Offset: 0x00A3EB88
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int CollectAllStaticResDescForLoad(IntPtr l)
	{
		int result;
		try
		{
			HeroListUITask heroListUITask = (HeroListUITask)LuaObject.checkSelf(l);
			List<UITaskBase.LayerDesc> o = heroListUITask.m_luaExportHelper.CollectAllStaticResDescForLoad();
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

	// Token: 0x0601F52C RID: 128300 RVA: 0x00A409E4 File Offset: 0x00A3EBE4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int CreateLayerDescByIndex(IntPtr l)
	{
		int result;
		try
		{
			HeroListUITask heroListUITask = (HeroListUITask)LuaObject.checkSelf(l);
			int index;
			LuaObject.checkType(l, 2, out index);
			UITaskBase.LayerDesc o = heroListUITask.m_luaExportHelper.CreateLayerDescByIndex(index);
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

	// Token: 0x0601F52D RID: 128301 RVA: 0x00A40A4C File Offset: 0x00A3EC4C
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int InitAllUIControllers(IntPtr l)
	{
		int result;
		try
		{
			HeroListUITask heroListUITask = (HeroListUITask)LuaObject.checkSelf(l);
			heroListUITask.m_luaExportHelper.InitAllUIControllers();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601F52E RID: 128302 RVA: 0x00A40AA0 File Offset: 0x00A3ECA0
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int ClearAllContextAndRes(IntPtr l)
	{
		int result;
		try
		{
			HeroListUITask heroListUITask = (HeroListUITask)LuaObject.checkSelf(l);
			heroListUITask.m_luaExportHelper.ClearAllContextAndRes();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601F52F RID: 128303 RVA: 0x00A40AF4 File Offset: 0x00A3ECF4
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int UpdateViewOnHeroChanged(IntPtr l)
	{
		int result;
		try
		{
			HeroListUITask heroListUITask = (HeroListUITask)LuaObject.checkSelf(l);
			int pos;
			LuaObject.checkType(l, 2, out pos);
			bool isUnlockHero;
			LuaObject.checkType(l, 3, out isUnlockHero);
			bool isNeedStopCoroutine;
			LuaObject.checkType(l, 4, out isNeedStopCoroutine);
			int lastHeroId;
			LuaObject.checkType(l, 5, out lastHeroId);
			heroListUITask.m_luaExportHelper.UpdateViewOnHeroChanged(pos, isUnlockHero, isNeedStopCoroutine, lastHeroId);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601F530 RID: 128304 RVA: 0x00A40B78 File Offset: 0x00A3ED78
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int StartUpdatePiplineInHeroListTask(IntPtr l)
	{
		int result;
		try
		{
			HeroListUITask heroListUITask = (HeroListUITask)LuaObject.checkSelf(l);
			heroListUITask.m_luaExportHelper.StartUpdatePiplineInHeroListTask();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601F531 RID: 128305 RVA: 0x00A40BCC File Offset: 0x00A3EDCC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int OnMemoryWarning(IntPtr l)
	{
		int result;
		try
		{
			HeroListUITask heroListUITask = (HeroListUITask)LuaObject.checkSelf(l);
			heroListUITask.m_luaExportHelper.OnMemoryWarning();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601F532 RID: 128306 RVA: 0x00A40C20 File Offset: 0x00A3EE20
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int UpdateView(IntPtr l)
	{
		int result;
		try
		{
			HeroListUITask heroListUITask = (HeroListUITask)LuaObject.checkSelf(l);
			heroListUITask.m_luaExportHelper.UpdateView();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601F533 RID: 128307 RVA: 0x00A40C74 File Offset: 0x00A3EE74
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int PushLayerByCurState(IntPtr l)
	{
		int result;
		try
		{
			HeroListUITask heroListUITask = (HeroListUITask)LuaObject.checkSelf(l);
			heroListUITask.m_luaExportHelper.PushLayerByCurState();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601F534 RID: 128308 RVA: 0x00A40CC8 File Offset: 0x00A3EEC8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int PushLayerByIndex(IntPtr l)
	{
		int result;
		try
		{
			HeroListUITask heroListUITask = (HeroListUITask)LuaObject.checkSelf(l);
			int index;
			LuaObject.checkType(l, 2, out index);
			heroListUITask.m_luaExportHelper.PushLayerByIndex(index);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601F535 RID: 128309 RVA: 0x00A40D24 File Offset: 0x00A3EF24
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int CheckConflictBetweenLayer(IntPtr l)
	{
		int result;
		try
		{
			HeroListUITask heroListUITask = (HeroListUITask)LuaObject.checkSelf(l);
			int layerIndex;
			LuaObject.checkType(l, 2, out layerIndex);
			heroListUITask.m_luaExportHelper.CheckConflictBetweenLayer(layerIndex);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601F536 RID: 128310 RVA: 0x00A40D80 File Offset: 0x00A3EF80
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int HeroDetailUIController_OnSetDetailState(IntPtr l)
	{
		int result;
		try
		{
			HeroListUITask heroListUITask = (HeroListUITask)LuaObject.checkSelf(l);
			string mode;
			LuaObject.checkType(l, 2, out mode);
			heroListUITask.m_luaExportHelper.HeroDetailUIController_OnSetDetailState(mode);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601F537 RID: 128311 RVA: 0x00A40DDC File Offset: 0x00A3EFDC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int SetTabCommonUIStateByName(IntPtr l)
	{
		int result;
		try
		{
			HeroListUITask heroListUITask = (HeroListUITask)LuaObject.checkSelf(l);
			string modeName;
			LuaObject.checkType(l, 2, out modeName);
			string stateName;
			LuaObject.checkType(l, 3, out stateName);
			heroListUITask.m_luaExportHelper.SetTabCommonUIStateByName(modeName, stateName);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601F538 RID: 128312 RVA: 0x00A40E48 File Offset: 0x00A3F048
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int HeroListUIController_SetHeroList(IntPtr l)
	{
		int result;
		try
		{
			HeroListUITask heroListUITask = (HeroListUITask)LuaObject.checkSelf(l);
			List<Hero> unlockedList;
			LuaObject.checkType<List<Hero>>(l, 2, out unlockedList);
			List<Hero> lockedList;
			LuaObject.checkType<List<Hero>>(l, 3, out lockedList);
			heroListUITask.m_luaExportHelper.HeroListUIController_SetHeroList(unlockedList, lockedList);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601F539 RID: 128313 RVA: 0x00A40EB4 File Offset: 0x00A3F0B4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int HeroListUIController_OnReturn(IntPtr l)
	{
		int result;
		try
		{
			HeroListUITask heroListUITask = (HeroListUITask)LuaObject.checkSelf(l);
			heroListUITask.m_luaExportHelper.HeroListUIController_OnReturn();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601F53A RID: 128314 RVA: 0x00A40F08 File Offset: 0x00A3F108
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int HeroListUIController_OnAddHero(IntPtr l)
	{
		int result;
		try
		{
			HeroListUITask heroListUITask = (HeroListUITask)LuaObject.checkSelf(l);
			string str;
			LuaObject.checkType(l, 2, out str);
			heroListUITask.m_luaExportHelper.HeroListUIController_OnAddHero(str);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601F53B RID: 128315 RVA: 0x00A40F64 File Offset: 0x00A3F164
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int HeroListUIController_OnHeroCompose(IntPtr l)
	{
		int result;
		try
		{
			HeroListUITask heroListUITask = (HeroListUITask)LuaObject.checkSelf(l);
			int heroId;
			LuaObject.checkType(l, 2, out heroId);
			Action onSucceed;
			LuaObject.checkDelegate<Action>(l, 3, out onSucceed);
			heroListUITask.m_luaExportHelper.HeroListUIController_OnHeroCompose(heroId, onSucceed);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601F53C RID: 128316 RVA: 0x00A40FD0 File Offset: 0x00A3F1D0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int HeroDetailLifeUIController_OnVoiceItemClick(IntPtr l)
	{
		int result;
		try
		{
			HeroListUITask heroListUITask = (HeroListUITask)LuaObject.checkSelf(l);
			int heroPerformanceId;
			LuaObject.checkType(l, 2, out heroPerformanceId);
			heroListUITask.m_luaExportHelper.HeroDetailLifeUIController_OnVoiceItemClick(heroPerformanceId);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601F53D RID: 128317 RVA: 0x00A4102C File Offset: 0x00A3F22C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int HeroDetailSelectSkillUIController_OnHeroSkillsSelect(IntPtr l)
	{
		int result;
		try
		{
			HeroListUITask heroListUITask = (HeroListUITask)LuaObject.checkSelf(l);
			int heroId;
			LuaObject.checkType(l, 2, out heroId);
			List<int> skillIds;
			LuaObject.checkType<List<int>>(l, 3, out skillIds);
			bool isSkillChanged;
			LuaObject.checkType(l, 4, out isSkillChanged);
			heroListUITask.m_luaExportHelper.HeroDetailSelectSkillUIController_OnHeroSkillsSelect(heroId, skillIds, isSkillChanged);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601F53E RID: 128318 RVA: 0x00A410A4 File Offset: 0x00A3F2A4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int HeroDetailSoldierUIController_OnHeroSoldierSelect(IntPtr l)
	{
		int result;
		try
		{
			HeroListUITask heroListUITask = (HeroListUITask)LuaObject.checkSelf(l);
			int heroId;
			LuaObject.checkType(l, 2, out heroId);
			int soldierId;
			LuaObject.checkType(l, 3, out soldierId);
			Action onSucceed;
			LuaObject.checkDelegate<Action>(l, 4, out onSucceed);
			heroListUITask.m_luaExportHelper.HeroDetailSoldierUIController_OnHeroSoldierSelect(heroId, soldierId, onSucceed);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601F53F RID: 128319 RVA: 0x00A4111C File Offset: 0x00A3F31C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int HeroDetailSoldierUIController_OnGotoDrill(IntPtr l)
	{
		int result;
		try
		{
			HeroListUITask heroListUITask = (HeroListUITask)LuaObject.checkSelf(l);
			int techId;
			LuaObject.checkType(l, 2, out techId);
			heroListUITask.m_luaExportHelper.HeroDetailSoldierUIController_OnGotoDrill(techId);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601F540 RID: 128320 RVA: 0x00A41178 File Offset: 0x00A3F378
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int HeroDetailSoldierUIController_OnGotoJobTransfer(IntPtr l)
	{
		int result;
		try
		{
			HeroListUITask heroListUITask = (HeroListUITask)LuaObject.checkSelf(l);
			ConfigDataJobConnectionInfo jobConnectionInfo;
			LuaObject.checkType<ConfigDataJobConnectionInfo>(l, 2, out jobConnectionInfo);
			heroListUITask.m_luaExportHelper.HeroDetailSoldierUIController_OnGotoJobTransfer(jobConnectionInfo);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601F541 RID: 128321 RVA: 0x00A411D4 File Offset: 0x00A3F3D4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int HeroDetailJobUIController_OnJobLvUpgrade(IntPtr l)
	{
		int result;
		try
		{
			HeroListUITask heroListUITask = (HeroListUITask)LuaObject.checkSelf(l);
			int heroId;
			LuaObject.checkType(l, 2, out heroId);
			int jobConnectionId;
			LuaObject.checkType(l, 3, out jobConnectionId);
			Action onSucceed;
			LuaObject.checkDelegate<Action>(l, 4, out onSucceed);
			heroListUITask.m_luaExportHelper.HeroDetailJobUIController_OnJobLvUpgrade(heroId, jobConnectionId, onSucceed);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601F542 RID: 128322 RVA: 0x00A4124C File Offset: 0x00A3F44C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int HeroDetailAddExpUIController_OnHeroAddExp(IntPtr l)
	{
		int result;
		try
		{
			HeroListUITask heroListUITask = (HeroListUITask)LuaObject.checkSelf(l);
			int heroId;
			LuaObject.checkType(l, 2, out heroId);
			BagItemBase bagItem;
			LuaObject.checkType<BagItemBase>(l, 3, out bagItem);
			int count;
			LuaObject.checkType(l, 4, out count);
			Action onFinished;
			LuaObject.checkDelegate<Action>(l, 5, out onFinished);
			heroListUITask.m_luaExportHelper.HeroDetailAddExpUIController_OnHeroAddExp(heroId, bagItem, count, onFinished);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601F543 RID: 128323 RVA: 0x00A412D0 File Offset: 0x00A3F4D0
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int HeroDetailAddExpUIController_OnReturn(IntPtr l)
	{
		int result;
		try
		{
			HeroListUITask heroListUITask = (HeroListUITask)LuaObject.checkSelf(l);
			heroListUITask.m_luaExportHelper.HeroDetailAddExpUIController_OnReturn();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601F544 RID: 128324 RVA: 0x00A41324 File Offset: 0x00A3F524
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int HeroListUIController_OnDetail(IntPtr l)
	{
		int result;
		try
		{
			HeroListUITask heroListUITask = (HeroListUITask)LuaObject.checkSelf(l);
			heroListUITask.m_luaExportHelper.HeroListUIController_OnDetail();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601F545 RID: 128325 RVA: 0x00A41378 File Offset: 0x00A3F578
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int HeroDetailUIController_OnReturn(IntPtr l)
	{
		int result;
		try
		{
			HeroListUITask heroListUITask = (HeroListUITask)LuaObject.checkSelf(l);
			heroListUITask.m_luaExportHelper.HeroDetailUIController_OnReturn();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601F546 RID: 128326 RVA: 0x00A413CC File Offset: 0x00A3F5CC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int HeroListUIController_OnHeroBreak(IntPtr l)
	{
		int result;
		try
		{
			HeroListUITask heroListUITask = (HeroListUITask)LuaObject.checkSelf(l);
			int id;
			LuaObject.checkType(l, 2, out id);
			heroListUITask.m_luaExportHelper.HeroListUIController_OnHeroBreak(id);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601F547 RID: 128327 RVA: 0x00A41428 File Offset: 0x00A3F628
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int HeroDetailUIController_OnJobTransfer(IntPtr l)
	{
		int result;
		try
		{
			HeroListUITask heroListUITask = (HeroListUITask)LuaObject.checkSelf(l);
			heroListUITask.m_luaExportHelper.HeroDetailUIController_OnJobTransfer();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601F548 RID: 128328 RVA: 0x00A4147C File Offset: 0x00A3F67C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int HeroJobTransferUITask_OnLoadAllResCompleted(IntPtr l)
	{
		int result;
		try
		{
			HeroListUITask heroListUITask = (HeroListUITask)LuaObject.checkSelf(l);
			heroListUITask.m_luaExportHelper.HeroJobTransferUITask_OnLoadAllResCompleted();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601F549 RID: 128329 RVA: 0x00A414D0 File Offset: 0x00A3F6D0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int HeroListUIController_OnComment(IntPtr l)
	{
		int result;
		try
		{
			HeroListUITask heroListUITask = (HeroListUITask)LuaObject.checkSelf(l);
			heroListUITask.m_luaExportHelper.HeroListUIController_OnComment();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601F54A RID: 128330 RVA: 0x00A41524 File Offset: 0x00A3F724
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int HeroCommentUITask_OnLoadAllResCompleted(IntPtr l)
	{
		int result;
		try
		{
			HeroListUITask heroListUITask = (HeroListUITask)LuaObject.checkSelf(l);
			heroListUITask.m_luaExportHelper.HeroCommentUITask_OnLoadAllResCompleted();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601F54B RID: 128331 RVA: 0x00A41578 File Offset: 0x00A3F778
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int HeroDetailEquipmentUIController_OnGotoEquipmentDepot(IntPtr l)
	{
		int result;
		try
		{
			HeroListUITask heroListUITask = (HeroListUITask)LuaObject.checkSelf(l);
			int slot;
			LuaObject.checkType(l, 2, out slot);
			ulong equipmentInstanceId;
			LuaObject.checkType(l, 3, out equipmentInstanceId);
			heroListUITask.m_luaExportHelper.HeroDetailEquipmentUIController_OnGotoEquipmentDepot(slot, equipmentInstanceId);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601F54C RID: 128332 RVA: 0x00A415E4 File Offset: 0x00A3F7E4
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int EquipmentDepotUITask_OnLoadAllResCompleted(IntPtr l)
	{
		int result;
		try
		{
			HeroListUITask heroListUITask = (HeroListUITask)LuaObject.checkSelf(l);
			heroListUITask.m_luaExportHelper.EquipmentDepotUITask_OnLoadAllResCompleted();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601F54D RID: 128333 RVA: 0x00A41638 File Offset: 0x00A3F838
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int HeroDetailEquipmentUIController_OnGotoEquipmentForge(IntPtr l)
	{
		int result;
		try
		{
			HeroListUITask heroListUITask = (HeroListUITask)LuaObject.checkSelf(l);
			int slot;
			LuaObject.checkType(l, 2, out slot);
			ulong equipmentInstanceId;
			LuaObject.checkType(l, 3, out equipmentInstanceId);
			heroListUITask.m_luaExportHelper.HeroDetailEquipmentUIController_OnGotoEquipmentForge(slot, equipmentInstanceId);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601F54E RID: 128334 RVA: 0x00A416A4 File Offset: 0x00A3F8A4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int EquipmentForgeUITask_OnLoadAllResCompleted(IntPtr l)
	{
		int result;
		try
		{
			HeroListUITask heroListUITask = (HeroListUITask)LuaObject.checkSelf(l);
			heroListUITask.m_luaExportHelper.EquipmentForgeUITask_OnLoadAllResCompleted();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601F54F RID: 128335 RVA: 0x00A416F8 File Offset: 0x00A3F8F8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int HeroDetailEquipmentUIController_OnEquipmentTakeOff(IntPtr l)
	{
		int result;
		try
		{
			HeroListUITask heroListUITask = (HeroListUITask)LuaObject.checkSelf(l);
			int heroId;
			LuaObject.checkType(l, 2, out heroId);
			int slot;
			LuaObject.checkType(l, 3, out slot);
			heroListUITask.m_luaExportHelper.HeroDetailEquipmentUIController_OnEquipmentTakeOff(heroId, slot);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601F550 RID: 128336 RVA: 0x00A41764 File Offset: 0x00A3F964
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int HeroDetailEquipmentUIController_OnLockButtonClick(IntPtr l)
	{
		int result;
		try
		{
			HeroListUITask heroListUITask = (HeroListUITask)LuaObject.checkSelf(l);
			ulong instanceId;
			LuaObject.checkType(l, 2, out instanceId);
			int slot;
			LuaObject.checkType(l, 3, out slot);
			Action onSucceed;
			LuaObject.checkDelegate<Action>(l, 4, out onSucceed);
			heroListUITask.m_luaExportHelper.HeroDetailEquipmentUIController_OnLockButtonClick(instanceId, slot, onSucceed);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601F551 RID: 128337 RVA: 0x00A417DC File Offset: 0x00A3F9DC
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int HeroDetailEquipmentUIController_OnAutoEquip(IntPtr l)
	{
		int result;
		try
		{
			HeroListUITask heroListUITask = (HeroListUITask)LuaObject.checkSelf(l);
			int heroId;
			LuaObject.checkType(l, 2, out heroId);
			Action onSucceed;
			LuaObject.checkDelegate<Action>(l, 3, out onSucceed);
			heroListUITask.m_luaExportHelper.HeroDetailEquipmentUIController_OnAutoEquip(heroId, onSucceed);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601F552 RID: 128338 RVA: 0x00A41848 File Offset: 0x00A3FA48
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int HeroDetailEquipmentUIController_OnAutoRemove(IntPtr l)
	{
		int result;
		try
		{
			HeroListUITask heroListUITask = (HeroListUITask)LuaObject.checkSelf(l);
			int heroId;
			LuaObject.checkType(l, 2, out heroId);
			heroListUITask.m_luaExportHelper.HeroDetailEquipmentUIController_OnAutoRemove(heroId);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601F553 RID: 128339 RVA: 0x00A418A4 File Offset: 0x00A3FAA4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int Hero_OnShowGetPath(IntPtr l)
	{
		int result;
		try
		{
			HeroListUITask heroListUITask = (HeroListUITask)LuaObject.checkSelf(l);
			GoodsType goodsType;
			LuaObject.checkEnum<GoodsType>(l, 2, out goodsType);
			int goodsId;
			LuaObject.checkType(l, 3, out goodsId);
			int needCount;
			LuaObject.checkType(l, 4, out needCount);
			heroListUITask.m_luaExportHelper.Hero_OnShowGetPath(goodsType, goodsId, needCount);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601F554 RID: 128340 RVA: 0x00A4191C File Offset: 0x00A3FB1C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int HeroListUIController_OnGotoEquipmentTab(IntPtr l)
	{
		int result;
		try
		{
			HeroListUITask heroListUITask = (HeroListUITask)LuaObject.checkSelf(l);
			heroListUITask.m_luaExportHelper.HeroListUIController_OnGotoEquipmentTab();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601F555 RID: 128341 RVA: 0x00A41970 File Offset: 0x00A3FB70
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int HeroListUIController_OnGotoJobTab(IntPtr l)
	{
		int result;
		try
		{
			HeroListUITask heroListUITask = (HeroListUITask)LuaObject.checkSelf(l);
			heroListUITask.m_luaExportHelper.HeroListUIController_OnGotoJobTab();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601F556 RID: 128342 RVA: 0x00A419C4 File Offset: 0x00A3FBC4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int HeroListUIController_OnSortToggleClick(IntPtr l)
	{
		int result;
		try
		{
			HeroListUITask heroListUITask = (HeroListUITask)LuaObject.checkSelf(l);
			HeroListUIController.HeroSortType type;
			LuaObject.checkEnum<HeroListUIController.HeroSortType>(l, 2, out type);
			heroListUITask.m_luaExportHelper.HeroListUIController_OnSortToggleClick(type);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601F557 RID: 128343 RVA: 0x00A41A20 File Offset: 0x00A3FC20
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int CloseHeroCharChangeTask(IntPtr l)
	{
		int result;
		try
		{
			HeroListUITask heroListUITask = (HeroListUITask)LuaObject.checkSelf(l);
			Action closeFinisdhAction;
			LuaObject.checkDelegate<Action>(l, 2, out closeFinisdhAction);
			heroListUITask.m_luaExportHelper.CloseHeroCharChangeTask(closeFinisdhAction);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601F558 RID: 128344 RVA: 0x00A41A7C File Offset: 0x00A3FC7C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int HeroListUIController_OnHeroCharSkinChangeButtonClick(IntPtr l)
	{
		int result;
		try
		{
			HeroListUITask heroListUITask = (HeroListUITask)LuaObject.checkSelf(l);
			heroListUITask.m_luaExportHelper.HeroListUIController_OnHeroCharSkinChangeButtonClick();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601F559 RID: 128345 RVA: 0x00A41AD0 File Offset: 0x00A3FCD0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int HeroListUIController_OnHeroCharClick(IntPtr l)
	{
		int result;
		try
		{
			HeroListUITask heroListUITask = (HeroListUITask)LuaObject.checkSelf(l);
			heroListUITask.m_luaExportHelper.HeroListUIController_OnHeroCharClick();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601F55A RID: 128346 RVA: 0x00A41B24 File Offset: 0x00A3FD24
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int HeroListUIController_OnGoToMemoryExtractionStore(IntPtr l)
	{
		int result;
		try
		{
			HeroListUITask heroListUITask = (HeroListUITask)LuaObject.checkSelf(l);
			heroListUITask.m_luaExportHelper.HeroListUIController_OnGoToMemoryExtractionStore();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601F55B RID: 128347 RVA: 0x00A41B78 File Offset: 0x00A3FD78
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int Hero_OnGotoGetPath(IntPtr l)
	{
		int result;
		try
		{
			HeroListUITask heroListUITask = (HeroListUITask)LuaObject.checkSelf(l);
			GetPathData getPath;
			LuaObject.checkType<GetPathData>(l, 2, out getPath);
			NeedGoods needGoods;
			LuaObject.checkType<NeedGoods>(l, 3, out needGoods);
			heroListUITask.m_luaExportHelper.Hero_OnGotoGetPath(getPath, needGoods);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601F55C RID: 128348 RVA: 0x00A41BE4 File Offset: 0x00A3FDE4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int HeroDetailSoldierUIController_OnSkinInfoButtonClick(IntPtr l)
	{
		int result;
		try
		{
			HeroListUITask heroListUITask = (HeroListUITask)LuaObject.checkSelf(l);
			ConfigDataSoldierInfo soldierInfo;
			LuaObject.checkType<ConfigDataSoldierInfo>(l, 2, out soldierInfo);
			heroListUITask.m_luaExportHelper.HeroDetailSoldierUIController_OnSkinInfoButtonClick(soldierInfo);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601F55D RID: 128349 RVA: 0x00A41C40 File Offset: 0x00A3FE40
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int HeroDetailInfoUIController_OnSkinInfoButtonClick(IntPtr l)
	{
		int result;
		try
		{
			HeroListUITask heroListUITask = (HeroListUITask)LuaObject.checkSelf(l);
			heroListUITask.m_luaExportHelper.HeroDetailInfoUIController_OnSkinInfoButtonClick();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601F55E RID: 128350 RVA: 0x00A41C94 File Offset: 0x00A3FE94
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int HeroSoldierSkinUITask_EventOnReturn(IntPtr l)
	{
		int result;
		try
		{
			HeroListUITask heroListUITask = (HeroListUITask)LuaObject.checkSelf(l);
			heroListUITask.m_luaExportHelper.HeroSoldierSkinUITask_EventOnReturn();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601F55F RID: 128351 RVA: 0x00A41CE8 File Offset: 0x00A3FEE8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int HeroDetailInfoUIController_OnJobUpButtonClick(IntPtr l)
	{
		int result;
		try
		{
			HeroListUITask heroListUITask = (HeroListUITask)LuaObject.checkSelf(l);
			heroListUITask.m_luaExportHelper.HeroDetailInfoUIController_OnJobUpButtonClick();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601F560 RID: 128352 RVA: 0x00A41D3C File Offset: 0x00A3FF3C
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int __callBase_OnStart(IntPtr l)
	{
		int result;
		try
		{
			HeroListUITask heroListUITask = (HeroListUITask)LuaObject.checkSelf(l);
			UIIntent intent;
			LuaObject.checkType<UIIntent>(l, 2, out intent);
			bool b = heroListUITask.m_luaExportHelper.__callBase_OnStart(intent);
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

	// Token: 0x0601F561 RID: 128353 RVA: 0x00A41DA4 File Offset: 0x00A3FFA4
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int __callBase_OnStop(IntPtr l)
	{
		int result;
		try
		{
			HeroListUITask heroListUITask = (HeroListUITask)LuaObject.checkSelf(l);
			heroListUITask.m_luaExportHelper.__callBase_OnStop();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601F562 RID: 128354 RVA: 0x00A41DF8 File Offset: 0x00A3FFF8
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int __callBase_OnPause(IntPtr l)
	{
		int result;
		try
		{
			HeroListUITask heroListUITask = (HeroListUITask)LuaObject.checkSelf(l);
			heroListUITask.m_luaExportHelper.__callBase_OnPause();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601F563 RID: 128355 RVA: 0x00A41E4C File Offset: 0x00A4004C
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int __callBase_OnResume(IntPtr l)
	{
		int result;
		try
		{
			HeroListUITask heroListUITask = (HeroListUITask)LuaObject.checkSelf(l);
			UIIntent intent;
			LuaObject.checkType<UIIntent>(l, 2, out intent);
			bool b = heroListUITask.m_luaExportHelper.__callBase_OnResume(intent);
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

	// Token: 0x0601F564 RID: 128356 RVA: 0x00A41EB4 File Offset: 0x00A400B4
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int __callBase_OnNewIntent(IntPtr l)
	{
		int result;
		try
		{
			HeroListUITask heroListUITask = (HeroListUITask)LuaObject.checkSelf(l);
			UIIntent intent;
			LuaObject.checkType<UIIntent>(l, 2, out intent);
			bool b = heroListUITask.m_luaExportHelper.__callBase_OnNewIntent(intent);
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

	// Token: 0x0601F565 RID: 128357 RVA: 0x00A41F1C File Offset: 0x00A4011C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_EnableUIInput(IntPtr l)
	{
		int result;
		try
		{
			HeroListUITask heroListUITask = (HeroListUITask)LuaObject.checkSelf(l);
			bool isEnable;
			LuaObject.checkType(l, 2, out isEnable);
			bool? isGlobalEnable;
			LuaObject.checkNullable<bool>(l, 3, out isGlobalEnable);
			heroListUITask.m_luaExportHelper.__callBase_EnableUIInput(isEnable, isGlobalEnable);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601F566 RID: 128358 RVA: 0x00A41F88 File Offset: 0x00A40188
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_IsNeedLoadDynamicRes(IntPtr l)
	{
		int result;
		try
		{
			HeroListUITask heroListUITask = (HeroListUITask)LuaObject.checkSelf(l);
			bool b = heroListUITask.m_luaExportHelper.__callBase_IsNeedLoadDynamicRes();
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

	// Token: 0x0601F567 RID: 128359 RVA: 0x00A41FE4 File Offset: 0x00A401E4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_CollectAllDynamicResForLoad(IntPtr l)
	{
		int result;
		try
		{
			HeroListUITask heroListUITask = (HeroListUITask)LuaObject.checkSelf(l);
			List<string> o = heroListUITask.m_luaExportHelper.__callBase_CollectAllDynamicResForLoad();
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

	// Token: 0x0601F568 RID: 128360 RVA: 0x00A42040 File Offset: 0x00A40240
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int __callBase_RegisterPlayerContextEvents(IntPtr l)
	{
		int result;
		try
		{
			HeroListUITask heroListUITask = (HeroListUITask)LuaObject.checkSelf(l);
			heroListUITask.m_luaExportHelper.__callBase_RegisterPlayerContextEvents();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601F569 RID: 128361 RVA: 0x00A42094 File Offset: 0x00A40294
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int __callBase_UnregisterPlayerContextEvents(IntPtr l)
	{
		int result;
		try
		{
			HeroListUITask heroListUITask = (HeroListUITask)LuaObject.checkSelf(l);
			heroListUITask.m_luaExportHelper.__callBase_UnregisterPlayerContextEvents();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601F56A RID: 128362 RVA: 0x00A420E8 File Offset: 0x00A402E8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_PostUpdateView(IntPtr l)
	{
		int result;
		try
		{
			HeroListUITask heroListUITask = (HeroListUITask)LuaObject.checkSelf(l);
			heroListUITask.m_luaExportHelper.__callBase_PostUpdateView();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601F56B RID: 128363 RVA: 0x00A4213C File Offset: 0x00A4033C
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int __callBase_CollectPreloadResourceList(IntPtr l)
	{
		int result;
		try
		{
			HeroListUITask heroListUITask = (HeroListUITask)LuaObject.checkSelf(l);
			heroListUITask.m_luaExportHelper.__callBase_CollectPreloadResourceList();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601F56C RID: 128364 RVA: 0x00A42190 File Offset: 0x00A40390
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_ClearAssetList(IntPtr l)
	{
		int result;
		try
		{
			HeroListUITask heroListUITask = (HeroListUITask)LuaObject.checkSelf(l);
			heroListUITask.m_luaExportHelper.__callBase_ClearAssetList();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601F56D RID: 128365 RVA: 0x00A421E4 File Offset: 0x00A403E4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_CollectAsset(IntPtr l)
	{
		int result;
		try
		{
			HeroListUITask heroListUITask = (HeroListUITask)LuaObject.checkSelf(l);
			string assetName;
			LuaObject.checkType(l, 2, out assetName);
			heroListUITask.m_luaExportHelper.__callBase_CollectAsset(assetName);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601F56E RID: 128366 RVA: 0x00A42240 File Offset: 0x00A40440
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_CollectSpriteAsset(IntPtr l)
	{
		int result;
		try
		{
			HeroListUITask heroListUITask = (HeroListUITask)LuaObject.checkSelf(l);
			string assetName;
			LuaObject.checkType(l, 2, out assetName);
			heroListUITask.m_luaExportHelper.__callBase_CollectSpriteAsset(assetName);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601F56F RID: 128367 RVA: 0x00A4229C File Offset: 0x00A4049C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_CollectFxAsset(IntPtr l)
	{
		int result;
		try
		{
			HeroListUITask heroListUITask = (HeroListUITask)LuaObject.checkSelf(l);
			string assetName;
			LuaObject.checkType(l, 2, out assetName);
			heroListUITask.m_luaExportHelper.__callBase_CollectFxAsset(assetName);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601F570 RID: 128368 RVA: 0x00A422F8 File Offset: 0x00A404F8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_StartLoadCustomAssets(IntPtr l)
	{
		int result;
		try
		{
			HeroListUITask heroListUITask = (HeroListUITask)LuaObject.checkSelf(l);
			Action onLoadCompleted;
			LuaObject.checkDelegate<Action>(l, 2, out onLoadCompleted);
			heroListUITask.m_luaExportHelper.__callBase_StartLoadCustomAssets(onLoadCompleted);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601F571 RID: 128369 RVA: 0x00A42354 File Offset: 0x00A40554
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_IsLoadingCustomAssets(IntPtr l)
	{
		int result;
		try
		{
			HeroListUITask heroListUITask = (HeroListUITask)LuaObject.checkSelf(l);
			bool b = heroListUITask.m_luaExportHelper.__callBase_IsLoadingCustomAssets();
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

	// Token: 0x0601F572 RID: 128370 RVA: 0x00A423B0 File Offset: 0x00A405B0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_IsPipeLineRunning(IntPtr l)
	{
		int result;
		try
		{
			HeroListUITask heroListUITask = (HeroListUITask)LuaObject.checkSelf(l);
			bool b = heroListUITask.m_luaExportHelper.__callBase_IsPipeLineRunning();
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

	// Token: 0x0601F573 RID: 128371 RVA: 0x00A4240C File Offset: 0x00A4060C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_IsOpeningUI(IntPtr l)
	{
		int result;
		try
		{
			HeroListUITask heroListUITask = (HeroListUITask)LuaObject.checkSelf(l);
			bool b = heroListUITask.m_luaExportHelper.__callBase_IsOpeningUI();
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

	// Token: 0x0601F574 RID: 128372 RVA: 0x00A42468 File Offset: 0x00A40668
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_ReturnPrevUITask(IntPtr l)
	{
		int result;
		try
		{
			HeroListUITask heroListUITask = (HeroListUITask)LuaObject.checkSelf(l);
			UITaskBase o = heroListUITask.m_luaExportHelper.__callBase_ReturnPrevUITask();
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

	// Token: 0x0601F575 RID: 128373 RVA: 0x00A424C4 File Offset: 0x00A406C4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_ClearUnusedDynamicResourceCache(IntPtr l)
	{
		int result;
		try
		{
			HeroListUITask heroListUITask = (HeroListUITask)LuaObject.checkSelf(l);
			heroListUITask.m_luaExportHelper.__callBase_ClearUnusedDynamicResourceCache();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601F576 RID: 128374 RVA: 0x00A42518 File Offset: 0x00A40718
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_OnMemoryWarning(IntPtr l)
	{
		int result;
		try
		{
			HeroListUITask heroListUITask = (HeroListUITask)LuaObject.checkSelf(l);
			heroListUITask.m_luaExportHelper.__callBase_OnMemoryWarning();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601F577 RID: 128375 RVA: 0x00A4256C File Offset: 0x00A4076C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_layerDescArray(IntPtr l)
	{
		int result;
		try
		{
			HeroListUITask heroListUITask = (HeroListUITask)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, heroListUITask.m_luaExportHelper.m_layerDescArray);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601F578 RID: 128376 RVA: 0x00A425C4 File Offset: 0x00A407C4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_layerDescArray(IntPtr l)
	{
		int result;
		try
		{
			HeroListUITask heroListUITask = (HeroListUITask)LuaObject.checkSelf(l);
			UITaskBase.LayerDesc[] layerDescArray;
			LuaObject.checkArray<UITaskBase.LayerDesc>(l, 2, out layerDescArray);
			heroListUITask.m_luaExportHelper.m_layerDescArray = layerDescArray;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601F579 RID: 128377 RVA: 0x00A42620 File Offset: 0x00A40820
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_uiCtrlDescArray(IntPtr l)
	{
		int result;
		try
		{
			HeroListUITask heroListUITask = (HeroListUITask)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, heroListUITask.m_luaExportHelper.m_uiCtrlDescArray);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601F57A RID: 128378 RVA: 0x00A42678 File Offset: 0x00A40878
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_uiCtrlDescArray(IntPtr l)
	{
		int result;
		try
		{
			HeroListUITask heroListUITask = (HeroListUITask)LuaObject.checkSelf(l);
			UITaskBase.UIControllerDesc[] uiCtrlDescArray;
			LuaObject.checkArray<UITaskBase.UIControllerDesc>(l, 2, out uiCtrlDescArray);
			heroListUITask.m_luaExportHelper.m_uiCtrlDescArray = uiCtrlDescArray;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601F57B RID: 128379 RVA: 0x00A426D4 File Offset: 0x00A408D4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_heroListUIController(IntPtr l)
	{
		int result;
		try
		{
			HeroListUITask heroListUITask = (HeroListUITask)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, heroListUITask.m_luaExportHelper.m_heroListUIController);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601F57C RID: 128380 RVA: 0x00A4272C File Offset: 0x00A4092C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_heroListUIController(IntPtr l)
	{
		int result;
		try
		{
			HeroListUITask heroListUITask = (HeroListUITask)LuaObject.checkSelf(l);
			HeroListUIController heroListUIController;
			LuaObject.checkType<HeroListUIController>(l, 2, out heroListUIController);
			heroListUITask.m_luaExportHelper.m_heroListUIController = heroListUIController;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601F57D RID: 128381 RVA: 0x00A42788 File Offset: 0x00A40988
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_heroDetailUIController(IntPtr l)
	{
		int result;
		try
		{
			HeroListUITask heroListUITask = (HeroListUITask)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, heroListUITask.m_luaExportHelper.m_heroDetailUIController);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601F57E RID: 128382 RVA: 0x00A427E0 File Offset: 0x00A409E0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_heroDetailUIController(IntPtr l)
	{
		int result;
		try
		{
			HeroListUITask heroListUITask = (HeroListUITask)LuaObject.checkSelf(l);
			HeroDetailUIController heroDetailUIController;
			LuaObject.checkType<HeroDetailUIController>(l, 2, out heroDetailUIController);
			heroListUITask.m_luaExportHelper.m_heroDetailUIController = heroDetailUIController;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601F57F RID: 128383 RVA: 0x00A4283C File Offset: 0x00A40A3C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_heroDetailJobUIController(IntPtr l)
	{
		int result;
		try
		{
			HeroListUITask heroListUITask = (HeroListUITask)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, heroListUITask.m_luaExportHelper.m_heroDetailJobUIController);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601F580 RID: 128384 RVA: 0x00A42894 File Offset: 0x00A40A94
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_heroDetailJobUIController(IntPtr l)
	{
		int result;
		try
		{
			HeroListUITask heroListUITask = (HeroListUITask)LuaObject.checkSelf(l);
			HeroDetailJobUIController heroDetailJobUIController;
			LuaObject.checkType<HeroDetailJobUIController>(l, 2, out heroDetailJobUIController);
			heroListUITask.m_luaExportHelper.m_heroDetailJobUIController = heroDetailJobUIController;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601F581 RID: 128385 RVA: 0x00A428F0 File Offset: 0x00A40AF0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_heroDetailInfoUIController(IntPtr l)
	{
		int result;
		try
		{
			HeroListUITask heroListUITask = (HeroListUITask)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, heroListUITask.m_luaExportHelper.m_heroDetailInfoUIController);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601F582 RID: 128386 RVA: 0x00A42948 File Offset: 0x00A40B48
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_heroDetailInfoUIController(IntPtr l)
	{
		int result;
		try
		{
			HeroListUITask heroListUITask = (HeroListUITask)LuaObject.checkSelf(l);
			HeroDetailInfoUIController heroDetailInfoUIController;
			LuaObject.checkType<HeroDetailInfoUIController>(l, 2, out heroDetailInfoUIController);
			heroListUITask.m_luaExportHelper.m_heroDetailInfoUIController = heroDetailInfoUIController;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601F583 RID: 128387 RVA: 0x00A429A4 File Offset: 0x00A40BA4
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_m_heroDetailAddExpUIController(IntPtr l)
	{
		int result;
		try
		{
			HeroListUITask heroListUITask = (HeroListUITask)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, heroListUITask.m_luaExportHelper.m_heroDetailAddExpUIController);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601F584 RID: 128388 RVA: 0x00A429FC File Offset: 0x00A40BFC
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_m_heroDetailAddExpUIController(IntPtr l)
	{
		int result;
		try
		{
			HeroListUITask heroListUITask = (HeroListUITask)LuaObject.checkSelf(l);
			HeroDetailAddExpUIController heroDetailAddExpUIController;
			LuaObject.checkType<HeroDetailAddExpUIController>(l, 2, out heroDetailAddExpUIController);
			heroListUITask.m_luaExportHelper.m_heroDetailAddExpUIController = heroDetailAddExpUIController;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601F585 RID: 128389 RVA: 0x00A42A58 File Offset: 0x00A40C58
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_heroDetailSoldierUIController(IntPtr l)
	{
		int result;
		try
		{
			HeroListUITask heroListUITask = (HeroListUITask)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, heroListUITask.m_luaExportHelper.m_heroDetailSoldierUIController);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601F586 RID: 128390 RVA: 0x00A42AB0 File Offset: 0x00A40CB0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_heroDetailSoldierUIController(IntPtr l)
	{
		int result;
		try
		{
			HeroListUITask heroListUITask = (HeroListUITask)LuaObject.checkSelf(l);
			HeroDetailSoldierUIController heroDetailSoldierUIController;
			LuaObject.checkType<HeroDetailSoldierUIController>(l, 2, out heroDetailSoldierUIController);
			heroListUITask.m_luaExportHelper.m_heroDetailSoldierUIController = heroDetailSoldierUIController;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601F587 RID: 128391 RVA: 0x00A42B0C File Offset: 0x00A40D0C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_heroDetailLifeUIController(IntPtr l)
	{
		int result;
		try
		{
			HeroListUITask heroListUITask = (HeroListUITask)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, heroListUITask.m_luaExportHelper.m_heroDetailLifeUIController);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601F588 RID: 128392 RVA: 0x00A42B64 File Offset: 0x00A40D64
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_m_heroDetailLifeUIController(IntPtr l)
	{
		int result;
		try
		{
			HeroListUITask heroListUITask = (HeroListUITask)LuaObject.checkSelf(l);
			HeroDetailLifeUIController heroDetailLifeUIController;
			LuaObject.checkType<HeroDetailLifeUIController>(l, 2, out heroDetailLifeUIController);
			heroListUITask.m_luaExportHelper.m_heroDetailLifeUIController = heroDetailLifeUIController;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601F589 RID: 128393 RVA: 0x00A42BC0 File Offset: 0x00A40DC0
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_m_heroDetailEquipmentUIController(IntPtr l)
	{
		int result;
		try
		{
			HeroListUITask heroListUITask = (HeroListUITask)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, heroListUITask.m_luaExportHelper.m_heroDetailEquipmentUIController);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601F58A RID: 128394 RVA: 0x00A42C18 File Offset: 0x00A40E18
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_heroDetailEquipmentUIController(IntPtr l)
	{
		int result;
		try
		{
			HeroListUITask heroListUITask = (HeroListUITask)LuaObject.checkSelf(l);
			HeroDetailEquipmentUIController heroDetailEquipmentUIController;
			LuaObject.checkType<HeroDetailEquipmentUIController>(l, 2, out heroDetailEquipmentUIController);
			heroListUITask.m_luaExportHelper.m_heroDetailEquipmentUIController = heroDetailEquipmentUIController;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601F58B RID: 128395 RVA: 0x00A42C74 File Offset: 0x00A40E74
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_m_heroDetailSelectSkillUIController(IntPtr l)
	{
		int result;
		try
		{
			HeroListUITask heroListUITask = (HeroListUITask)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, heroListUITask.m_luaExportHelper.m_heroDetailSelectSkillUIController);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601F58C RID: 128396 RVA: 0x00A42CCC File Offset: 0x00A40ECC
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_m_heroDetailSelectSkillUIController(IntPtr l)
	{
		int result;
		try
		{
			HeroListUITask heroListUITask = (HeroListUITask)LuaObject.checkSelf(l);
			HeroDetailSelectSkillUIController heroDetailSelectSkillUIController;
			LuaObject.checkType<HeroDetailSelectSkillUIController>(l, 2, out heroDetailSelectSkillUIController);
			heroListUITask.m_luaExportHelper.m_heroDetailSelectSkillUIController = heroDetailSelectSkillUIController;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601F58D RID: 128397 RVA: 0x00A42D28 File Offset: 0x00A40F28
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_m_heroJobTransferUITask(IntPtr l)
	{
		int result;
		try
		{
			HeroListUITask heroListUITask = (HeroListUITask)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, heroListUITask.m_luaExportHelper.m_heroJobTransferUITask);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601F58E RID: 128398 RVA: 0x00A42D80 File Offset: 0x00A40F80
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_heroJobTransferUITask(IntPtr l)
	{
		int result;
		try
		{
			HeroListUITask heroListUITask = (HeroListUITask)LuaObject.checkSelf(l);
			HeroJobTransferUITask heroJobTransferUITask;
			LuaObject.checkType<HeroJobTransferUITask>(l, 2, out heroJobTransferUITask);
			heroListUITask.m_luaExportHelper.m_heroJobTransferUITask = heroJobTransferUITask;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601F58F RID: 128399 RVA: 0x00A42DDC File Offset: 0x00A40FDC
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_m_heroCharChangeTask(IntPtr l)
	{
		int result;
		try
		{
			HeroListUITask heroListUITask = (HeroListUITask)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, heroListUITask.m_luaExportHelper.m_heroCharChangeTask);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601F590 RID: 128400 RVA: 0x00A42E34 File Offset: 0x00A41034
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_m_heroCharChangeTask(IntPtr l)
	{
		int result;
		try
		{
			HeroListUITask heroListUITask = (HeroListUITask)LuaObject.checkSelf(l);
			HeroSkinChangeUITask heroCharChangeTask;
			LuaObject.checkType<HeroSkinChangeUITask>(l, 2, out heroCharChangeTask);
			heroListUITask.m_luaExportHelper.m_heroCharChangeTask = heroCharChangeTask;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601F591 RID: 128401 RVA: 0x00A42E90 File Offset: 0x00A41090
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_m_storeSoldierSkinDetailUITask(IntPtr l)
	{
		int result;
		try
		{
			HeroListUITask heroListUITask = (HeroListUITask)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, heroListUITask.m_luaExportHelper.m_storeSoldierSkinDetailUITask);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601F592 RID: 128402 RVA: 0x00A42EE8 File Offset: 0x00A410E8
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_m_storeSoldierSkinDetailUITask(IntPtr l)
	{
		int result;
		try
		{
			HeroListUITask heroListUITask = (HeroListUITask)LuaObject.checkSelf(l);
			StoreSoldierSkinDetailUITask storeSoldierSkinDetailUITask;
			LuaObject.checkType<StoreSoldierSkinDetailUITask>(l, 2, out storeSoldierSkinDetailUITask);
			heroListUITask.m_luaExportHelper.m_storeSoldierSkinDetailUITask = storeSoldierSkinDetailUITask;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601F593 RID: 128403 RVA: 0x00A42F44 File Offset: 0x00A41144
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_ListMode(IntPtr l)
	{
		int result;
		try
		{
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, "List");
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601F594 RID: 128404 RVA: 0x00A42F8C File Offset: 0x00A4118C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_DetailInfoMode(IntPtr l)
	{
		int result;
		try
		{
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, "DetailInfo");
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601F595 RID: 128405 RVA: 0x00A42FD4 File Offset: 0x00A411D4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_DetailJobMode(IntPtr l)
	{
		int result;
		try
		{
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, "DetailJob");
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601F596 RID: 128406 RVA: 0x00A4301C File Offset: 0x00A4121C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_DetailSoldierMode(IntPtr l)
	{
		int result;
		try
		{
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, "DetailSoldier");
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601F597 RID: 128407 RVA: 0x00A43064 File Offset: 0x00A41264
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_DetailEquipmentMode(IntPtr l)
	{
		int result;
		try
		{
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, "DetailEquipment");
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601F598 RID: 128408 RVA: 0x00A430AC File Offset: 0x00A412AC
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_DetailLifeMode(IntPtr l)
	{
		int result;
		try
		{
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, "DetailLife");
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601F599 RID: 128409 RVA: 0x00A430F4 File Offset: 0x00A412F4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_DetailSelectSkillMode(IntPtr l)
	{
		int result;
		try
		{
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, "DetailSelectSkill");
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601F59A RID: 128410 RVA: 0x00A4313C File Offset: 0x00A4133C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_DetailAddExpMode(IntPtr l)
	{
		int result;
		try
		{
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, "DetailAddExp");
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601F59B RID: 128411 RVA: 0x00A43184 File Offset: 0x00A41384
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_stateName(IntPtr l)
	{
		int result;
		try
		{
			HeroListUITask heroListUITask = (HeroListUITask)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, heroListUITask.m_luaExportHelper.m_stateName);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601F59C RID: 128412 RVA: 0x00A431DC File Offset: 0x00A413DC
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_m_stateName(IntPtr l)
	{
		int result;
		try
		{
			HeroListUITask heroListUITask = (HeroListUITask)LuaObject.checkSelf(l);
			string stateName;
			LuaObject.checkType(l, 2, out stateName);
			heroListUITask.m_luaExportHelper.m_stateName = stateName;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601F59D RID: 128413 RVA: 0x00A43238 File Offset: 0x00A41438
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_m_lastMode(IntPtr l)
	{
		int result;
		try
		{
			HeroListUITask heroListUITask = (HeroListUITask)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, heroListUITask.m_luaExportHelper.m_lastMode);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601F59E RID: 128414 RVA: 0x00A43290 File Offset: 0x00A41490
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_m_lastMode(IntPtr l)
	{
		int result;
		try
		{
			HeroListUITask heroListUITask = (HeroListUITask)LuaObject.checkSelf(l);
			string lastMode;
			LuaObject.checkType(l, 2, out lastMode);
			heroListUITask.m_luaExportHelper.m_lastMode = lastMode;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601F59F RID: 128415 RVA: 0x00A432EC File Offset: 0x00A414EC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_curMode(IntPtr l)
	{
		int result;
		try
		{
			HeroListUITask heroListUITask = (HeroListUITask)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, heroListUITask.m_luaExportHelper.m_curMode);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601F5A0 RID: 128416 RVA: 0x00A43344 File Offset: 0x00A41544
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_curMode(IntPtr l)
	{
		int result;
		try
		{
			HeroListUITask heroListUITask = (HeroListUITask)LuaObject.checkSelf(l);
			string curMode;
			LuaObject.checkType(l, 2, out curMode);
			heroListUITask.m_luaExportHelper.m_curMode = curMode;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601F5A1 RID: 128417 RVA: 0x00A433A0 File Offset: 0x00A415A0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_lockedList(IntPtr l)
	{
		int result;
		try
		{
			HeroListUITask heroListUITask = (HeroListUITask)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, heroListUITask.m_luaExportHelper.m_lockedList);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601F5A2 RID: 128418 RVA: 0x00A433F8 File Offset: 0x00A415F8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_lockedList(IntPtr l)
	{
		int result;
		try
		{
			HeroListUITask heroListUITask = (HeroListUITask)LuaObject.checkSelf(l);
			List<Hero> lockedList;
			LuaObject.checkType<List<Hero>>(l, 2, out lockedList);
			heroListUITask.m_luaExportHelper.m_lockedList = lockedList;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601F5A3 RID: 128419 RVA: 0x00A43454 File Offset: 0x00A41654
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_curHeroList(IntPtr l)
	{
		int result;
		try
		{
			HeroListUITask heroListUITask = (HeroListUITask)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, heroListUITask.m_luaExportHelper.m_curHeroList);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601F5A4 RID: 128420 RVA: 0x00A434AC File Offset: 0x00A416AC
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_m_curHeroList(IntPtr l)
	{
		int result;
		try
		{
			HeroListUITask heroListUITask = (HeroListUITask)LuaObject.checkSelf(l);
			List<Hero> curHeroList;
			LuaObject.checkType<List<Hero>>(l, 2, out curHeroList);
			heroListUITask.m_luaExportHelper.m_curHeroList = curHeroList;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601F5A5 RID: 128421 RVA: 0x00A43508 File Offset: 0x00A41708
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_unlockedList(IntPtr l)
	{
		int result;
		try
		{
			HeroListUITask heroListUITask = (HeroListUITask)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, heroListUITask.m_luaExportHelper.m_unlockedList);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601F5A6 RID: 128422 RVA: 0x00A43560 File Offset: 0x00A41760
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_unlockedList(IntPtr l)
	{
		int result;
		try
		{
			HeroListUITask heroListUITask = (HeroListUITask)LuaObject.checkSelf(l);
			List<Hero> unlockedList;
			LuaObject.checkType<List<Hero>>(l, 2, out unlockedList);
			heroListUITask.m_luaExportHelper.m_unlockedList = unlockedList;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601F5A7 RID: 128423 RVA: 0x00A435BC File Offset: 0x00A417BC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_curHeroPos(IntPtr l)
	{
		int result;
		try
		{
			HeroListUITask heroListUITask = (HeroListUITask)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, heroListUITask.m_luaExportHelper.m_curHeroPos);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601F5A8 RID: 128424 RVA: 0x00A43614 File Offset: 0x00A41814
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_curHeroPos(IntPtr l)
	{
		int result;
		try
		{
			HeroListUITask heroListUITask = (HeroListUITask)LuaObject.checkSelf(l);
			int curHeroPos;
			LuaObject.checkType(l, 2, out curHeroPos);
			heroListUITask.m_luaExportHelper.m_curHeroPos = curHeroPos;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601F5A9 RID: 128425 RVA: 0x00A43670 File Offset: 0x00A41870
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_curLayerDescIndex(IntPtr l)
	{
		int result;
		try
		{
			HeroListUITask heroListUITask = (HeroListUITask)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, heroListUITask.m_luaExportHelper.m_curLayerDescIndex);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601F5AA RID: 128426 RVA: 0x00A436C8 File Offset: 0x00A418C8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_curLayerDescIndex(IntPtr l)
	{
		int result;
		try
		{
			HeroListUITask heroListUITask = (HeroListUITask)LuaObject.checkSelf(l);
			int curLayerDescIndex;
			LuaObject.checkType(l, 2, out curLayerDescIndex);
			heroListUITask.m_luaExportHelper.m_curLayerDescIndex = curLayerDescIndex;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601F5AB RID: 128427 RVA: 0x00A43724 File Offset: 0x00A41924
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_lastHeroId(IntPtr l)
	{
		int result;
		try
		{
			HeroListUITask heroListUITask = (HeroListUITask)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, heroListUITask.m_luaExportHelper.m_lastHeroId);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601F5AC RID: 128428 RVA: 0x00A4377C File Offset: 0x00A4197C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_lastHeroId(IntPtr l)
	{
		int result;
		try
		{
			HeroListUITask heroListUITask = (HeroListUITask)LuaObject.checkSelf(l);
			int lastHeroId;
			LuaObject.checkType(l, 2, out lastHeroId);
			heroListUITask.m_luaExportHelper.m_lastHeroId = lastHeroId;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601F5AD RID: 128429 RVA: 0x00A437D8 File Offset: 0x00A419D8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_isUnlockHero(IntPtr l)
	{
		int result;
		try
		{
			HeroListUITask heroListUITask = (HeroListUITask)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, heroListUITask.m_luaExportHelper.m_isUnlockHero);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601F5AE RID: 128430 RVA: 0x00A43830 File Offset: 0x00A41A30
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_isUnlockHero(IntPtr l)
	{
		int result;
		try
		{
			HeroListUITask heroListUITask = (HeroListUITask)LuaObject.checkSelf(l);
			bool isUnlockHero;
			LuaObject.checkType(l, 2, out isUnlockHero);
			heroListUITask.m_luaExportHelper.m_isUnlockHero = isUnlockHero;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601F5AF RID: 128431 RVA: 0x00A4388C File Offset: 0x00A41A8C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_isDetailLayerOpen(IntPtr l)
	{
		int result;
		try
		{
			HeroListUITask heroListUITask = (HeroListUITask)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, heroListUITask.m_luaExportHelper.m_isDetailLayerOpen);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601F5B0 RID: 128432 RVA: 0x00A438E4 File Offset: 0x00A41AE4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_isDetailLayerOpen(IntPtr l)
	{
		int result;
		try
		{
			HeroListUITask heroListUITask = (HeroListUITask)LuaObject.checkSelf(l);
			bool isDetailLayerOpen;
			LuaObject.checkType(l, 2, out isDetailLayerOpen);
			heroListUITask.m_luaExportHelper.m_isDetailLayerOpen = isDetailLayerOpen;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601F5B1 RID: 128433 RVA: 0x00A43940 File Offset: 0x00A41B40
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_curHeroSortType(IntPtr l)
	{
		int result;
		try
		{
			HeroListUITask heroListUITask = (HeroListUITask)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushEnum(l, (int)heroListUITask.m_luaExportHelper.m_curHeroSortType);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601F5B2 RID: 128434 RVA: 0x00A43998 File Offset: 0x00A41B98
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_curHeroSortType(IntPtr l)
	{
		int result;
		try
		{
			HeroListUITask heroListUITask = (HeroListUITask)LuaObject.checkSelf(l);
			HeroListUIController.HeroSortType curHeroSortType;
			LuaObject.checkEnum<HeroListUIController.HeroSortType>(l, 2, out curHeroSortType);
			heroListUITask.m_luaExportHelper.m_curHeroSortType = curHeroSortType;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601F5B3 RID: 128435 RVA: 0x00A439F4 File Offset: 0x00A41BF4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_playerContext(IntPtr l)
	{
		int result;
		try
		{
			HeroListUITask heroListUITask = (HeroListUITask)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, heroListUITask.m_luaExportHelper.m_playerContext);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601F5B4 RID: 128436 RVA: 0x00A43A4C File Offset: 0x00A41C4C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_playerContext(IntPtr l)
	{
		int result;
		try
		{
			HeroListUITask heroListUITask = (HeroListUITask)LuaObject.checkSelf(l);
			ProjectLPlayerContext playerContext;
			LuaObject.checkType<ProjectLPlayerContext>(l, 2, out playerContext);
			heroListUITask.m_luaExportHelper.m_playerContext = playerContext;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601F5B5 RID: 128437 RVA: 0x00A43AA8 File Offset: 0x00A41CA8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_configDataLoader(IntPtr l)
	{
		int result;
		try
		{
			HeroListUITask heroListUITask = (HeroListUITask)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, heroListUITask.m_luaExportHelper.m_configDataLoader);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601F5B6 RID: 128438 RVA: 0x00A43B00 File Offset: 0x00A41D00
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_configDataLoader(IntPtr l)
	{
		int result;
		try
		{
			HeroListUITask heroListUITask = (HeroListUITask)LuaObject.checkSelf(l);
			IConfigDataLoader configDataLoader;
			LuaObject.checkType<IConfigDataLoader>(l, 2, out configDataLoader);
			heroListUITask.m_luaExportHelper.m_configDataLoader = configDataLoader;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601F5B7 RID: 128439 RVA: 0x00A43B5C File Offset: 0x00A41D5C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_LayerDescArray(IntPtr l)
	{
		int result;
		try
		{
			HeroListUITask heroListUITask = (HeroListUITask)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, heroListUITask.m_luaExportHelper.LayerDescArray);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601F5B8 RID: 128440 RVA: 0x00A43BB4 File Offset: 0x00A41DB4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_UICtrlDescArray(IntPtr l)
	{
		int result;
		try
		{
			HeroListUITask heroListUITask = (HeroListUITask)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, heroListUITask.m_luaExportHelper.UICtrlDescArray);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601F5B9 RID: 128441 RVA: 0x00A43C0C File Offset: 0x00A41E0C
	[Preserve]
	public static void reg(IntPtr l)
	{
		LuaObject.getTypeTable(l, "BlackJack.ProjectL.UI.HeroListUITask");
		if (Lua_BlackJack_ProjectL_UI_HeroListUITask.<>f__mg$cache0 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroListUITask.<>f__mg$cache0 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroListUITask.HeroCharChangeTask_OnSkinChangedPreview);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_HeroListUITask.<>f__mg$cache0);
		if (Lua_BlackJack_ProjectL_UI_HeroListUITask.<>f__mg$cache1 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroListUITask.<>f__mg$cache1 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroListUITask.HeroCharChangeTask_EventOnClose);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_HeroListUITask.<>f__mg$cache1);
		if (Lua_BlackJack_ProjectL_UI_HeroListUITask.<>f__mg$cache2 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroListUITask.<>f__mg$cache2 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroListUITask.HeroCharChangeTask_OnAddSkinTicket);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_HeroListUITask.<>f__mg$cache2);
		if (Lua_BlackJack_ProjectL_UI_HeroListUITask.<>f__mg$cache3 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroListUITask.<>f__mg$cache3 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroListUITask.StoreSoldierSkinDetailUITask_EventOnBuySuccessEnd);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_HeroListUITask.<>f__mg$cache3);
		if (Lua_BlackJack_ProjectL_UI_HeroListUITask.<>f__mg$cache4 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroListUITask.<>f__mg$cache4 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroListUITask.StoreSoldierSkinDetailUITask_EventOnClose);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_HeroListUITask.<>f__mg$cache4);
		if (Lua_BlackJack_ProjectL_UI_HeroListUITask.<>f__mg$cache5 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroListUITask.<>f__mg$cache5 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroListUITask.OnStart);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_HeroListUITask.<>f__mg$cache5);
		if (Lua_BlackJack_ProjectL_UI_HeroListUITask.<>f__mg$cache6 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroListUITask.<>f__mg$cache6 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroListUITask.OnStop);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_HeroListUITask.<>f__mg$cache6);
		if (Lua_BlackJack_ProjectL_UI_HeroListUITask.<>f__mg$cache7 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroListUITask.<>f__mg$cache7 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroListUITask.SaveUIStateToIntent);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_HeroListUITask.<>f__mg$cache7);
		if (Lua_BlackJack_ProjectL_UI_HeroListUITask.<>f__mg$cache8 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroListUITask.<>f__mg$cache8 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroListUITask.GetUIStateFromIntent);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_HeroListUITask.<>f__mg$cache8);
		if (Lua_BlackJack_ProjectL_UI_HeroListUITask.<>f__mg$cache9 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroListUITask.<>f__mg$cache9 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroListUITask.IsNeedLoadDynamicRes);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_HeroListUITask.<>f__mg$cache9);
		if (Lua_BlackJack_ProjectL_UI_HeroListUITask.<>f__mg$cacheA == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroListUITask.<>f__mg$cacheA = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroListUITask.UpdataHeroListData);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_HeroListUITask.<>f__mg$cacheA);
		if (Lua_BlackJack_ProjectL_UI_HeroListUITask.<>f__mg$cacheB == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroListUITask.<>f__mg$cacheB = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroListUITask.UpdateHeroCardData);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_HeroListUITask.<>f__mg$cacheB);
		if (Lua_BlackJack_ProjectL_UI_HeroListUITask.<>f__mg$cacheC == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroListUITask.<>f__mg$cacheC = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroListUITask.UpdateCurrentHeroData);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_HeroListUITask.<>f__mg$cacheC);
		if (Lua_BlackJack_ProjectL_UI_HeroListUITask.<>f__mg$cacheD == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroListUITask.<>f__mg$cacheD = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroListUITask.UpdateSoldierModeData);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_HeroListUITask.<>f__mg$cacheD);
		if (Lua_BlackJack_ProjectL_UI_HeroListUITask.<>f__mg$cacheE == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroListUITask.<>f__mg$cacheE = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroListUITask.UpdateJobModeData);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_HeroListUITask.<>f__mg$cacheE);
		if (Lua_BlackJack_ProjectL_UI_HeroListUITask.<>f__mg$cacheF == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroListUITask.<>f__mg$cacheF = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroListUITask.HeroListItemCompare);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_HeroListUITask.<>f__mg$cacheF);
		if (Lua_BlackJack_ProjectL_UI_HeroListUITask.<>f__mg$cache10 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroListUITask.<>f__mg$cache10 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroListUITask.IsNeedLoadStaticRes);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_HeroListUITask.<>f__mg$cache10);
		if (Lua_BlackJack_ProjectL_UI_HeroListUITask.<>f__mg$cache11 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroListUITask.<>f__mg$cache11 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroListUITask.CollectAllStaticResDescForLoad);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_HeroListUITask.<>f__mg$cache11);
		if (Lua_BlackJack_ProjectL_UI_HeroListUITask.<>f__mg$cache12 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroListUITask.<>f__mg$cache12 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroListUITask.CreateLayerDescByIndex);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_HeroListUITask.<>f__mg$cache12);
		if (Lua_BlackJack_ProjectL_UI_HeroListUITask.<>f__mg$cache13 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroListUITask.<>f__mg$cache13 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroListUITask.InitAllUIControllers);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_HeroListUITask.<>f__mg$cache13);
		if (Lua_BlackJack_ProjectL_UI_HeroListUITask.<>f__mg$cache14 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroListUITask.<>f__mg$cache14 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroListUITask.ClearAllContextAndRes);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_HeroListUITask.<>f__mg$cache14);
		if (Lua_BlackJack_ProjectL_UI_HeroListUITask.<>f__mg$cache15 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroListUITask.<>f__mg$cache15 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroListUITask.UpdateViewOnHeroChanged);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_HeroListUITask.<>f__mg$cache15);
		if (Lua_BlackJack_ProjectL_UI_HeroListUITask.<>f__mg$cache16 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroListUITask.<>f__mg$cache16 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroListUITask.StartUpdatePiplineInHeroListTask);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_HeroListUITask.<>f__mg$cache16);
		if (Lua_BlackJack_ProjectL_UI_HeroListUITask.<>f__mg$cache17 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroListUITask.<>f__mg$cache17 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroListUITask.OnMemoryWarning);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_HeroListUITask.<>f__mg$cache17);
		if (Lua_BlackJack_ProjectL_UI_HeroListUITask.<>f__mg$cache18 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroListUITask.<>f__mg$cache18 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroListUITask.UpdateView);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_HeroListUITask.<>f__mg$cache18);
		if (Lua_BlackJack_ProjectL_UI_HeroListUITask.<>f__mg$cache19 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroListUITask.<>f__mg$cache19 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroListUITask.PushLayerByCurState);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_HeroListUITask.<>f__mg$cache19);
		if (Lua_BlackJack_ProjectL_UI_HeroListUITask.<>f__mg$cache1A == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroListUITask.<>f__mg$cache1A = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroListUITask.PushLayerByIndex);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_HeroListUITask.<>f__mg$cache1A);
		if (Lua_BlackJack_ProjectL_UI_HeroListUITask.<>f__mg$cache1B == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroListUITask.<>f__mg$cache1B = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroListUITask.CheckConflictBetweenLayer);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_HeroListUITask.<>f__mg$cache1B);
		if (Lua_BlackJack_ProjectL_UI_HeroListUITask.<>f__mg$cache1C == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroListUITask.<>f__mg$cache1C = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroListUITask.HeroDetailUIController_OnSetDetailState);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_HeroListUITask.<>f__mg$cache1C);
		if (Lua_BlackJack_ProjectL_UI_HeroListUITask.<>f__mg$cache1D == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroListUITask.<>f__mg$cache1D = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroListUITask.SetTabCommonUIStateByName);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_HeroListUITask.<>f__mg$cache1D);
		if (Lua_BlackJack_ProjectL_UI_HeroListUITask.<>f__mg$cache1E == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroListUITask.<>f__mg$cache1E = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroListUITask.HeroListUIController_SetHeroList);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_HeroListUITask.<>f__mg$cache1E);
		if (Lua_BlackJack_ProjectL_UI_HeroListUITask.<>f__mg$cache1F == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroListUITask.<>f__mg$cache1F = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroListUITask.HeroListUIController_OnReturn);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_HeroListUITask.<>f__mg$cache1F);
		if (Lua_BlackJack_ProjectL_UI_HeroListUITask.<>f__mg$cache20 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroListUITask.<>f__mg$cache20 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroListUITask.HeroListUIController_OnAddHero);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_HeroListUITask.<>f__mg$cache20);
		if (Lua_BlackJack_ProjectL_UI_HeroListUITask.<>f__mg$cache21 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroListUITask.<>f__mg$cache21 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroListUITask.HeroListUIController_OnHeroCompose);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_HeroListUITask.<>f__mg$cache21);
		if (Lua_BlackJack_ProjectL_UI_HeroListUITask.<>f__mg$cache22 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroListUITask.<>f__mg$cache22 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroListUITask.HeroDetailLifeUIController_OnVoiceItemClick);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_HeroListUITask.<>f__mg$cache22);
		if (Lua_BlackJack_ProjectL_UI_HeroListUITask.<>f__mg$cache23 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroListUITask.<>f__mg$cache23 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroListUITask.HeroDetailSelectSkillUIController_OnHeroSkillsSelect);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_HeroListUITask.<>f__mg$cache23);
		if (Lua_BlackJack_ProjectL_UI_HeroListUITask.<>f__mg$cache24 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroListUITask.<>f__mg$cache24 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroListUITask.HeroDetailSoldierUIController_OnHeroSoldierSelect);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_HeroListUITask.<>f__mg$cache24);
		if (Lua_BlackJack_ProjectL_UI_HeroListUITask.<>f__mg$cache25 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroListUITask.<>f__mg$cache25 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroListUITask.HeroDetailSoldierUIController_OnGotoDrill);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_HeroListUITask.<>f__mg$cache25);
		if (Lua_BlackJack_ProjectL_UI_HeroListUITask.<>f__mg$cache26 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroListUITask.<>f__mg$cache26 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroListUITask.HeroDetailSoldierUIController_OnGotoJobTransfer);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_HeroListUITask.<>f__mg$cache26);
		if (Lua_BlackJack_ProjectL_UI_HeroListUITask.<>f__mg$cache27 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroListUITask.<>f__mg$cache27 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroListUITask.HeroDetailJobUIController_OnJobLvUpgrade);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_HeroListUITask.<>f__mg$cache27);
		if (Lua_BlackJack_ProjectL_UI_HeroListUITask.<>f__mg$cache28 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroListUITask.<>f__mg$cache28 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroListUITask.HeroDetailAddExpUIController_OnHeroAddExp);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_HeroListUITask.<>f__mg$cache28);
		if (Lua_BlackJack_ProjectL_UI_HeroListUITask.<>f__mg$cache29 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroListUITask.<>f__mg$cache29 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroListUITask.HeroDetailAddExpUIController_OnReturn);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_HeroListUITask.<>f__mg$cache29);
		if (Lua_BlackJack_ProjectL_UI_HeroListUITask.<>f__mg$cache2A == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroListUITask.<>f__mg$cache2A = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroListUITask.HeroListUIController_OnDetail);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_HeroListUITask.<>f__mg$cache2A);
		if (Lua_BlackJack_ProjectL_UI_HeroListUITask.<>f__mg$cache2B == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroListUITask.<>f__mg$cache2B = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroListUITask.HeroDetailUIController_OnReturn);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_HeroListUITask.<>f__mg$cache2B);
		if (Lua_BlackJack_ProjectL_UI_HeroListUITask.<>f__mg$cache2C == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroListUITask.<>f__mg$cache2C = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroListUITask.HeroListUIController_OnHeroBreak);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_HeroListUITask.<>f__mg$cache2C);
		if (Lua_BlackJack_ProjectL_UI_HeroListUITask.<>f__mg$cache2D == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroListUITask.<>f__mg$cache2D = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroListUITask.HeroDetailUIController_OnJobTransfer);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_HeroListUITask.<>f__mg$cache2D);
		if (Lua_BlackJack_ProjectL_UI_HeroListUITask.<>f__mg$cache2E == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroListUITask.<>f__mg$cache2E = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroListUITask.HeroJobTransferUITask_OnLoadAllResCompleted);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_HeroListUITask.<>f__mg$cache2E);
		if (Lua_BlackJack_ProjectL_UI_HeroListUITask.<>f__mg$cache2F == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroListUITask.<>f__mg$cache2F = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroListUITask.HeroListUIController_OnComment);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_HeroListUITask.<>f__mg$cache2F);
		if (Lua_BlackJack_ProjectL_UI_HeroListUITask.<>f__mg$cache30 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroListUITask.<>f__mg$cache30 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroListUITask.HeroCommentUITask_OnLoadAllResCompleted);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_HeroListUITask.<>f__mg$cache30);
		if (Lua_BlackJack_ProjectL_UI_HeroListUITask.<>f__mg$cache31 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroListUITask.<>f__mg$cache31 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroListUITask.HeroDetailEquipmentUIController_OnGotoEquipmentDepot);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_HeroListUITask.<>f__mg$cache31);
		if (Lua_BlackJack_ProjectL_UI_HeroListUITask.<>f__mg$cache32 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroListUITask.<>f__mg$cache32 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroListUITask.EquipmentDepotUITask_OnLoadAllResCompleted);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_HeroListUITask.<>f__mg$cache32);
		if (Lua_BlackJack_ProjectL_UI_HeroListUITask.<>f__mg$cache33 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroListUITask.<>f__mg$cache33 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroListUITask.HeroDetailEquipmentUIController_OnGotoEquipmentForge);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_HeroListUITask.<>f__mg$cache33);
		if (Lua_BlackJack_ProjectL_UI_HeroListUITask.<>f__mg$cache34 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroListUITask.<>f__mg$cache34 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroListUITask.EquipmentForgeUITask_OnLoadAllResCompleted);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_HeroListUITask.<>f__mg$cache34);
		if (Lua_BlackJack_ProjectL_UI_HeroListUITask.<>f__mg$cache35 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroListUITask.<>f__mg$cache35 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroListUITask.HeroDetailEquipmentUIController_OnEquipmentTakeOff);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_HeroListUITask.<>f__mg$cache35);
		if (Lua_BlackJack_ProjectL_UI_HeroListUITask.<>f__mg$cache36 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroListUITask.<>f__mg$cache36 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroListUITask.HeroDetailEquipmentUIController_OnLockButtonClick);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_HeroListUITask.<>f__mg$cache36);
		if (Lua_BlackJack_ProjectL_UI_HeroListUITask.<>f__mg$cache37 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroListUITask.<>f__mg$cache37 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroListUITask.HeroDetailEquipmentUIController_OnAutoEquip);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_HeroListUITask.<>f__mg$cache37);
		if (Lua_BlackJack_ProjectL_UI_HeroListUITask.<>f__mg$cache38 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroListUITask.<>f__mg$cache38 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroListUITask.HeroDetailEquipmentUIController_OnAutoRemove);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_HeroListUITask.<>f__mg$cache38);
		if (Lua_BlackJack_ProjectL_UI_HeroListUITask.<>f__mg$cache39 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroListUITask.<>f__mg$cache39 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroListUITask.Hero_OnShowGetPath);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_HeroListUITask.<>f__mg$cache39);
		if (Lua_BlackJack_ProjectL_UI_HeroListUITask.<>f__mg$cache3A == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroListUITask.<>f__mg$cache3A = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroListUITask.HeroListUIController_OnGotoEquipmentTab);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_HeroListUITask.<>f__mg$cache3A);
		if (Lua_BlackJack_ProjectL_UI_HeroListUITask.<>f__mg$cache3B == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroListUITask.<>f__mg$cache3B = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroListUITask.HeroListUIController_OnGotoJobTab);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_HeroListUITask.<>f__mg$cache3B);
		if (Lua_BlackJack_ProjectL_UI_HeroListUITask.<>f__mg$cache3C == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroListUITask.<>f__mg$cache3C = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroListUITask.HeroListUIController_OnSortToggleClick);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_HeroListUITask.<>f__mg$cache3C);
		if (Lua_BlackJack_ProjectL_UI_HeroListUITask.<>f__mg$cache3D == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroListUITask.<>f__mg$cache3D = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroListUITask.CloseHeroCharChangeTask);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_HeroListUITask.<>f__mg$cache3D);
		if (Lua_BlackJack_ProjectL_UI_HeroListUITask.<>f__mg$cache3E == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroListUITask.<>f__mg$cache3E = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroListUITask.HeroListUIController_OnHeroCharSkinChangeButtonClick);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_HeroListUITask.<>f__mg$cache3E);
		if (Lua_BlackJack_ProjectL_UI_HeroListUITask.<>f__mg$cache3F == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroListUITask.<>f__mg$cache3F = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroListUITask.HeroListUIController_OnHeroCharClick);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_HeroListUITask.<>f__mg$cache3F);
		if (Lua_BlackJack_ProjectL_UI_HeroListUITask.<>f__mg$cache40 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroListUITask.<>f__mg$cache40 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroListUITask.HeroListUIController_OnGoToMemoryExtractionStore);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_HeroListUITask.<>f__mg$cache40);
		if (Lua_BlackJack_ProjectL_UI_HeroListUITask.<>f__mg$cache41 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroListUITask.<>f__mg$cache41 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroListUITask.Hero_OnGotoGetPath);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_HeroListUITask.<>f__mg$cache41);
		if (Lua_BlackJack_ProjectL_UI_HeroListUITask.<>f__mg$cache42 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroListUITask.<>f__mg$cache42 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroListUITask.HeroDetailSoldierUIController_OnSkinInfoButtonClick);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_HeroListUITask.<>f__mg$cache42);
		if (Lua_BlackJack_ProjectL_UI_HeroListUITask.<>f__mg$cache43 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroListUITask.<>f__mg$cache43 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroListUITask.HeroDetailInfoUIController_OnSkinInfoButtonClick);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_HeroListUITask.<>f__mg$cache43);
		if (Lua_BlackJack_ProjectL_UI_HeroListUITask.<>f__mg$cache44 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroListUITask.<>f__mg$cache44 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroListUITask.HeroSoldierSkinUITask_EventOnReturn);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_HeroListUITask.<>f__mg$cache44);
		if (Lua_BlackJack_ProjectL_UI_HeroListUITask.<>f__mg$cache45 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroListUITask.<>f__mg$cache45 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroListUITask.HeroDetailInfoUIController_OnJobUpButtonClick);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_HeroListUITask.<>f__mg$cache45);
		if (Lua_BlackJack_ProjectL_UI_HeroListUITask.<>f__mg$cache46 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroListUITask.<>f__mg$cache46 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroListUITask.__callBase_OnStart);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_HeroListUITask.<>f__mg$cache46);
		if (Lua_BlackJack_ProjectL_UI_HeroListUITask.<>f__mg$cache47 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroListUITask.<>f__mg$cache47 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroListUITask.__callBase_OnStop);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_HeroListUITask.<>f__mg$cache47);
		if (Lua_BlackJack_ProjectL_UI_HeroListUITask.<>f__mg$cache48 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroListUITask.<>f__mg$cache48 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroListUITask.__callBase_OnPause);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_HeroListUITask.<>f__mg$cache48);
		if (Lua_BlackJack_ProjectL_UI_HeroListUITask.<>f__mg$cache49 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroListUITask.<>f__mg$cache49 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroListUITask.__callBase_OnResume);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_HeroListUITask.<>f__mg$cache49);
		if (Lua_BlackJack_ProjectL_UI_HeroListUITask.<>f__mg$cache4A == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroListUITask.<>f__mg$cache4A = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroListUITask.__callBase_OnNewIntent);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_HeroListUITask.<>f__mg$cache4A);
		if (Lua_BlackJack_ProjectL_UI_HeroListUITask.<>f__mg$cache4B == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroListUITask.<>f__mg$cache4B = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroListUITask.__callBase_EnableUIInput);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_HeroListUITask.<>f__mg$cache4B);
		if (Lua_BlackJack_ProjectL_UI_HeroListUITask.<>f__mg$cache4C == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroListUITask.<>f__mg$cache4C = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroListUITask.__callBase_IsNeedLoadDynamicRes);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_HeroListUITask.<>f__mg$cache4C);
		if (Lua_BlackJack_ProjectL_UI_HeroListUITask.<>f__mg$cache4D == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroListUITask.<>f__mg$cache4D = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroListUITask.__callBase_CollectAllDynamicResForLoad);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_HeroListUITask.<>f__mg$cache4D);
		if (Lua_BlackJack_ProjectL_UI_HeroListUITask.<>f__mg$cache4E == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroListUITask.<>f__mg$cache4E = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroListUITask.__callBase_RegisterPlayerContextEvents);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_HeroListUITask.<>f__mg$cache4E);
		if (Lua_BlackJack_ProjectL_UI_HeroListUITask.<>f__mg$cache4F == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroListUITask.<>f__mg$cache4F = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroListUITask.__callBase_UnregisterPlayerContextEvents);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_HeroListUITask.<>f__mg$cache4F);
		if (Lua_BlackJack_ProjectL_UI_HeroListUITask.<>f__mg$cache50 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroListUITask.<>f__mg$cache50 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroListUITask.__callBase_PostUpdateView);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_HeroListUITask.<>f__mg$cache50);
		if (Lua_BlackJack_ProjectL_UI_HeroListUITask.<>f__mg$cache51 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroListUITask.<>f__mg$cache51 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroListUITask.__callBase_CollectPreloadResourceList);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_HeroListUITask.<>f__mg$cache51);
		if (Lua_BlackJack_ProjectL_UI_HeroListUITask.<>f__mg$cache52 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroListUITask.<>f__mg$cache52 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroListUITask.__callBase_ClearAssetList);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_HeroListUITask.<>f__mg$cache52);
		if (Lua_BlackJack_ProjectL_UI_HeroListUITask.<>f__mg$cache53 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroListUITask.<>f__mg$cache53 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroListUITask.__callBase_CollectAsset);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_HeroListUITask.<>f__mg$cache53);
		if (Lua_BlackJack_ProjectL_UI_HeroListUITask.<>f__mg$cache54 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroListUITask.<>f__mg$cache54 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroListUITask.__callBase_CollectSpriteAsset);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_HeroListUITask.<>f__mg$cache54);
		if (Lua_BlackJack_ProjectL_UI_HeroListUITask.<>f__mg$cache55 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroListUITask.<>f__mg$cache55 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroListUITask.__callBase_CollectFxAsset);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_HeroListUITask.<>f__mg$cache55);
		if (Lua_BlackJack_ProjectL_UI_HeroListUITask.<>f__mg$cache56 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroListUITask.<>f__mg$cache56 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroListUITask.__callBase_StartLoadCustomAssets);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_HeroListUITask.<>f__mg$cache56);
		if (Lua_BlackJack_ProjectL_UI_HeroListUITask.<>f__mg$cache57 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroListUITask.<>f__mg$cache57 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroListUITask.__callBase_IsLoadingCustomAssets);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_HeroListUITask.<>f__mg$cache57);
		if (Lua_BlackJack_ProjectL_UI_HeroListUITask.<>f__mg$cache58 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroListUITask.<>f__mg$cache58 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroListUITask.__callBase_IsPipeLineRunning);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_HeroListUITask.<>f__mg$cache58);
		if (Lua_BlackJack_ProjectL_UI_HeroListUITask.<>f__mg$cache59 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroListUITask.<>f__mg$cache59 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroListUITask.__callBase_IsOpeningUI);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_HeroListUITask.<>f__mg$cache59);
		if (Lua_BlackJack_ProjectL_UI_HeroListUITask.<>f__mg$cache5A == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroListUITask.<>f__mg$cache5A = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroListUITask.__callBase_ReturnPrevUITask);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_HeroListUITask.<>f__mg$cache5A);
		if (Lua_BlackJack_ProjectL_UI_HeroListUITask.<>f__mg$cache5B == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroListUITask.<>f__mg$cache5B = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroListUITask.__callBase_ClearUnusedDynamicResourceCache);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_HeroListUITask.<>f__mg$cache5B);
		if (Lua_BlackJack_ProjectL_UI_HeroListUITask.<>f__mg$cache5C == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroListUITask.<>f__mg$cache5C = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroListUITask.__callBase_OnMemoryWarning);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_HeroListUITask.<>f__mg$cache5C);
		string name = "m_layerDescArray";
		if (Lua_BlackJack_ProjectL_UI_HeroListUITask.<>f__mg$cache5D == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroListUITask.<>f__mg$cache5D = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroListUITask.get_m_layerDescArray);
		}
		LuaCSFunction get = Lua_BlackJack_ProjectL_UI_HeroListUITask.<>f__mg$cache5D;
		if (Lua_BlackJack_ProjectL_UI_HeroListUITask.<>f__mg$cache5E == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroListUITask.<>f__mg$cache5E = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroListUITask.set_m_layerDescArray);
		}
		LuaObject.addMember(l, name, get, Lua_BlackJack_ProjectL_UI_HeroListUITask.<>f__mg$cache5E, true);
		string name2 = "m_uiCtrlDescArray";
		if (Lua_BlackJack_ProjectL_UI_HeroListUITask.<>f__mg$cache5F == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroListUITask.<>f__mg$cache5F = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroListUITask.get_m_uiCtrlDescArray);
		}
		LuaCSFunction get2 = Lua_BlackJack_ProjectL_UI_HeroListUITask.<>f__mg$cache5F;
		if (Lua_BlackJack_ProjectL_UI_HeroListUITask.<>f__mg$cache60 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroListUITask.<>f__mg$cache60 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroListUITask.set_m_uiCtrlDescArray);
		}
		LuaObject.addMember(l, name2, get2, Lua_BlackJack_ProjectL_UI_HeroListUITask.<>f__mg$cache60, true);
		string name3 = "m_heroListUIController";
		if (Lua_BlackJack_ProjectL_UI_HeroListUITask.<>f__mg$cache61 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroListUITask.<>f__mg$cache61 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroListUITask.get_m_heroListUIController);
		}
		LuaCSFunction get3 = Lua_BlackJack_ProjectL_UI_HeroListUITask.<>f__mg$cache61;
		if (Lua_BlackJack_ProjectL_UI_HeroListUITask.<>f__mg$cache62 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroListUITask.<>f__mg$cache62 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroListUITask.set_m_heroListUIController);
		}
		LuaObject.addMember(l, name3, get3, Lua_BlackJack_ProjectL_UI_HeroListUITask.<>f__mg$cache62, true);
		string name4 = "m_heroDetailUIController";
		if (Lua_BlackJack_ProjectL_UI_HeroListUITask.<>f__mg$cache63 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroListUITask.<>f__mg$cache63 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroListUITask.get_m_heroDetailUIController);
		}
		LuaCSFunction get4 = Lua_BlackJack_ProjectL_UI_HeroListUITask.<>f__mg$cache63;
		if (Lua_BlackJack_ProjectL_UI_HeroListUITask.<>f__mg$cache64 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroListUITask.<>f__mg$cache64 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroListUITask.set_m_heroDetailUIController);
		}
		LuaObject.addMember(l, name4, get4, Lua_BlackJack_ProjectL_UI_HeroListUITask.<>f__mg$cache64, true);
		string name5 = "m_heroDetailJobUIController";
		if (Lua_BlackJack_ProjectL_UI_HeroListUITask.<>f__mg$cache65 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroListUITask.<>f__mg$cache65 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroListUITask.get_m_heroDetailJobUIController);
		}
		LuaCSFunction get5 = Lua_BlackJack_ProjectL_UI_HeroListUITask.<>f__mg$cache65;
		if (Lua_BlackJack_ProjectL_UI_HeroListUITask.<>f__mg$cache66 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroListUITask.<>f__mg$cache66 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroListUITask.set_m_heroDetailJobUIController);
		}
		LuaObject.addMember(l, name5, get5, Lua_BlackJack_ProjectL_UI_HeroListUITask.<>f__mg$cache66, true);
		string name6 = "m_heroDetailInfoUIController";
		if (Lua_BlackJack_ProjectL_UI_HeroListUITask.<>f__mg$cache67 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroListUITask.<>f__mg$cache67 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroListUITask.get_m_heroDetailInfoUIController);
		}
		LuaCSFunction get6 = Lua_BlackJack_ProjectL_UI_HeroListUITask.<>f__mg$cache67;
		if (Lua_BlackJack_ProjectL_UI_HeroListUITask.<>f__mg$cache68 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroListUITask.<>f__mg$cache68 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroListUITask.set_m_heroDetailInfoUIController);
		}
		LuaObject.addMember(l, name6, get6, Lua_BlackJack_ProjectL_UI_HeroListUITask.<>f__mg$cache68, true);
		string name7 = "m_heroDetailAddExpUIController";
		if (Lua_BlackJack_ProjectL_UI_HeroListUITask.<>f__mg$cache69 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroListUITask.<>f__mg$cache69 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroListUITask.get_m_heroDetailAddExpUIController);
		}
		LuaCSFunction get7 = Lua_BlackJack_ProjectL_UI_HeroListUITask.<>f__mg$cache69;
		if (Lua_BlackJack_ProjectL_UI_HeroListUITask.<>f__mg$cache6A == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroListUITask.<>f__mg$cache6A = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroListUITask.set_m_heroDetailAddExpUIController);
		}
		LuaObject.addMember(l, name7, get7, Lua_BlackJack_ProjectL_UI_HeroListUITask.<>f__mg$cache6A, true);
		string name8 = "m_heroDetailSoldierUIController";
		if (Lua_BlackJack_ProjectL_UI_HeroListUITask.<>f__mg$cache6B == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroListUITask.<>f__mg$cache6B = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroListUITask.get_m_heroDetailSoldierUIController);
		}
		LuaCSFunction get8 = Lua_BlackJack_ProjectL_UI_HeroListUITask.<>f__mg$cache6B;
		if (Lua_BlackJack_ProjectL_UI_HeroListUITask.<>f__mg$cache6C == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroListUITask.<>f__mg$cache6C = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroListUITask.set_m_heroDetailSoldierUIController);
		}
		LuaObject.addMember(l, name8, get8, Lua_BlackJack_ProjectL_UI_HeroListUITask.<>f__mg$cache6C, true);
		string name9 = "m_heroDetailLifeUIController";
		if (Lua_BlackJack_ProjectL_UI_HeroListUITask.<>f__mg$cache6D == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroListUITask.<>f__mg$cache6D = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroListUITask.get_m_heroDetailLifeUIController);
		}
		LuaCSFunction get9 = Lua_BlackJack_ProjectL_UI_HeroListUITask.<>f__mg$cache6D;
		if (Lua_BlackJack_ProjectL_UI_HeroListUITask.<>f__mg$cache6E == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroListUITask.<>f__mg$cache6E = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroListUITask.set_m_heroDetailLifeUIController);
		}
		LuaObject.addMember(l, name9, get9, Lua_BlackJack_ProjectL_UI_HeroListUITask.<>f__mg$cache6E, true);
		string name10 = "m_heroDetailEquipmentUIController";
		if (Lua_BlackJack_ProjectL_UI_HeroListUITask.<>f__mg$cache6F == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroListUITask.<>f__mg$cache6F = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroListUITask.get_m_heroDetailEquipmentUIController);
		}
		LuaCSFunction get10 = Lua_BlackJack_ProjectL_UI_HeroListUITask.<>f__mg$cache6F;
		if (Lua_BlackJack_ProjectL_UI_HeroListUITask.<>f__mg$cache70 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroListUITask.<>f__mg$cache70 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroListUITask.set_m_heroDetailEquipmentUIController);
		}
		LuaObject.addMember(l, name10, get10, Lua_BlackJack_ProjectL_UI_HeroListUITask.<>f__mg$cache70, true);
		string name11 = "m_heroDetailSelectSkillUIController";
		if (Lua_BlackJack_ProjectL_UI_HeroListUITask.<>f__mg$cache71 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroListUITask.<>f__mg$cache71 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroListUITask.get_m_heroDetailSelectSkillUIController);
		}
		LuaCSFunction get11 = Lua_BlackJack_ProjectL_UI_HeroListUITask.<>f__mg$cache71;
		if (Lua_BlackJack_ProjectL_UI_HeroListUITask.<>f__mg$cache72 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroListUITask.<>f__mg$cache72 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroListUITask.set_m_heroDetailSelectSkillUIController);
		}
		LuaObject.addMember(l, name11, get11, Lua_BlackJack_ProjectL_UI_HeroListUITask.<>f__mg$cache72, true);
		string name12 = "m_heroJobTransferUITask";
		if (Lua_BlackJack_ProjectL_UI_HeroListUITask.<>f__mg$cache73 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroListUITask.<>f__mg$cache73 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroListUITask.get_m_heroJobTransferUITask);
		}
		LuaCSFunction get12 = Lua_BlackJack_ProjectL_UI_HeroListUITask.<>f__mg$cache73;
		if (Lua_BlackJack_ProjectL_UI_HeroListUITask.<>f__mg$cache74 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroListUITask.<>f__mg$cache74 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroListUITask.set_m_heroJobTransferUITask);
		}
		LuaObject.addMember(l, name12, get12, Lua_BlackJack_ProjectL_UI_HeroListUITask.<>f__mg$cache74, true);
		string name13 = "m_heroCharChangeTask";
		if (Lua_BlackJack_ProjectL_UI_HeroListUITask.<>f__mg$cache75 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroListUITask.<>f__mg$cache75 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroListUITask.get_m_heroCharChangeTask);
		}
		LuaCSFunction get13 = Lua_BlackJack_ProjectL_UI_HeroListUITask.<>f__mg$cache75;
		if (Lua_BlackJack_ProjectL_UI_HeroListUITask.<>f__mg$cache76 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroListUITask.<>f__mg$cache76 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroListUITask.set_m_heroCharChangeTask);
		}
		LuaObject.addMember(l, name13, get13, Lua_BlackJack_ProjectL_UI_HeroListUITask.<>f__mg$cache76, true);
		string name14 = "m_storeSoldierSkinDetailUITask";
		if (Lua_BlackJack_ProjectL_UI_HeroListUITask.<>f__mg$cache77 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroListUITask.<>f__mg$cache77 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroListUITask.get_m_storeSoldierSkinDetailUITask);
		}
		LuaCSFunction get14 = Lua_BlackJack_ProjectL_UI_HeroListUITask.<>f__mg$cache77;
		if (Lua_BlackJack_ProjectL_UI_HeroListUITask.<>f__mg$cache78 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroListUITask.<>f__mg$cache78 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroListUITask.set_m_storeSoldierSkinDetailUITask);
		}
		LuaObject.addMember(l, name14, get14, Lua_BlackJack_ProjectL_UI_HeroListUITask.<>f__mg$cache78, true);
		string name15 = "ListMode";
		if (Lua_BlackJack_ProjectL_UI_HeroListUITask.<>f__mg$cache79 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroListUITask.<>f__mg$cache79 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroListUITask.get_ListMode);
		}
		LuaObject.addMember(l, name15, Lua_BlackJack_ProjectL_UI_HeroListUITask.<>f__mg$cache79, null, false);
		string name16 = "DetailInfoMode";
		if (Lua_BlackJack_ProjectL_UI_HeroListUITask.<>f__mg$cache7A == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroListUITask.<>f__mg$cache7A = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroListUITask.get_DetailInfoMode);
		}
		LuaObject.addMember(l, name16, Lua_BlackJack_ProjectL_UI_HeroListUITask.<>f__mg$cache7A, null, false);
		string name17 = "DetailJobMode";
		if (Lua_BlackJack_ProjectL_UI_HeroListUITask.<>f__mg$cache7B == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroListUITask.<>f__mg$cache7B = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroListUITask.get_DetailJobMode);
		}
		LuaObject.addMember(l, name17, Lua_BlackJack_ProjectL_UI_HeroListUITask.<>f__mg$cache7B, null, false);
		string name18 = "DetailSoldierMode";
		if (Lua_BlackJack_ProjectL_UI_HeroListUITask.<>f__mg$cache7C == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroListUITask.<>f__mg$cache7C = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroListUITask.get_DetailSoldierMode);
		}
		LuaObject.addMember(l, name18, Lua_BlackJack_ProjectL_UI_HeroListUITask.<>f__mg$cache7C, null, false);
		string name19 = "DetailEquipmentMode";
		if (Lua_BlackJack_ProjectL_UI_HeroListUITask.<>f__mg$cache7D == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroListUITask.<>f__mg$cache7D = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroListUITask.get_DetailEquipmentMode);
		}
		LuaObject.addMember(l, name19, Lua_BlackJack_ProjectL_UI_HeroListUITask.<>f__mg$cache7D, null, false);
		string name20 = "DetailLifeMode";
		if (Lua_BlackJack_ProjectL_UI_HeroListUITask.<>f__mg$cache7E == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroListUITask.<>f__mg$cache7E = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroListUITask.get_DetailLifeMode);
		}
		LuaObject.addMember(l, name20, Lua_BlackJack_ProjectL_UI_HeroListUITask.<>f__mg$cache7E, null, false);
		string name21 = "DetailSelectSkillMode";
		if (Lua_BlackJack_ProjectL_UI_HeroListUITask.<>f__mg$cache7F == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroListUITask.<>f__mg$cache7F = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroListUITask.get_DetailSelectSkillMode);
		}
		LuaObject.addMember(l, name21, Lua_BlackJack_ProjectL_UI_HeroListUITask.<>f__mg$cache7F, null, false);
		string name22 = "DetailAddExpMode";
		if (Lua_BlackJack_ProjectL_UI_HeroListUITask.<>f__mg$cache80 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroListUITask.<>f__mg$cache80 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroListUITask.get_DetailAddExpMode);
		}
		LuaObject.addMember(l, name22, Lua_BlackJack_ProjectL_UI_HeroListUITask.<>f__mg$cache80, null, false);
		string name23 = "m_stateName";
		if (Lua_BlackJack_ProjectL_UI_HeroListUITask.<>f__mg$cache81 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroListUITask.<>f__mg$cache81 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroListUITask.get_m_stateName);
		}
		LuaCSFunction get15 = Lua_BlackJack_ProjectL_UI_HeroListUITask.<>f__mg$cache81;
		if (Lua_BlackJack_ProjectL_UI_HeroListUITask.<>f__mg$cache82 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroListUITask.<>f__mg$cache82 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroListUITask.set_m_stateName);
		}
		LuaObject.addMember(l, name23, get15, Lua_BlackJack_ProjectL_UI_HeroListUITask.<>f__mg$cache82, true);
		string name24 = "m_lastMode";
		if (Lua_BlackJack_ProjectL_UI_HeroListUITask.<>f__mg$cache83 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroListUITask.<>f__mg$cache83 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroListUITask.get_m_lastMode);
		}
		LuaCSFunction get16 = Lua_BlackJack_ProjectL_UI_HeroListUITask.<>f__mg$cache83;
		if (Lua_BlackJack_ProjectL_UI_HeroListUITask.<>f__mg$cache84 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroListUITask.<>f__mg$cache84 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroListUITask.set_m_lastMode);
		}
		LuaObject.addMember(l, name24, get16, Lua_BlackJack_ProjectL_UI_HeroListUITask.<>f__mg$cache84, true);
		string name25 = "m_curMode";
		if (Lua_BlackJack_ProjectL_UI_HeroListUITask.<>f__mg$cache85 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroListUITask.<>f__mg$cache85 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroListUITask.get_m_curMode);
		}
		LuaCSFunction get17 = Lua_BlackJack_ProjectL_UI_HeroListUITask.<>f__mg$cache85;
		if (Lua_BlackJack_ProjectL_UI_HeroListUITask.<>f__mg$cache86 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroListUITask.<>f__mg$cache86 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroListUITask.set_m_curMode);
		}
		LuaObject.addMember(l, name25, get17, Lua_BlackJack_ProjectL_UI_HeroListUITask.<>f__mg$cache86, true);
		string name26 = "m_lockedList";
		if (Lua_BlackJack_ProjectL_UI_HeroListUITask.<>f__mg$cache87 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroListUITask.<>f__mg$cache87 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroListUITask.get_m_lockedList);
		}
		LuaCSFunction get18 = Lua_BlackJack_ProjectL_UI_HeroListUITask.<>f__mg$cache87;
		if (Lua_BlackJack_ProjectL_UI_HeroListUITask.<>f__mg$cache88 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroListUITask.<>f__mg$cache88 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroListUITask.set_m_lockedList);
		}
		LuaObject.addMember(l, name26, get18, Lua_BlackJack_ProjectL_UI_HeroListUITask.<>f__mg$cache88, true);
		string name27 = "m_curHeroList";
		if (Lua_BlackJack_ProjectL_UI_HeroListUITask.<>f__mg$cache89 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroListUITask.<>f__mg$cache89 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroListUITask.get_m_curHeroList);
		}
		LuaCSFunction get19 = Lua_BlackJack_ProjectL_UI_HeroListUITask.<>f__mg$cache89;
		if (Lua_BlackJack_ProjectL_UI_HeroListUITask.<>f__mg$cache8A == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroListUITask.<>f__mg$cache8A = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroListUITask.set_m_curHeroList);
		}
		LuaObject.addMember(l, name27, get19, Lua_BlackJack_ProjectL_UI_HeroListUITask.<>f__mg$cache8A, true);
		string name28 = "m_unlockedList";
		if (Lua_BlackJack_ProjectL_UI_HeroListUITask.<>f__mg$cache8B == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroListUITask.<>f__mg$cache8B = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroListUITask.get_m_unlockedList);
		}
		LuaCSFunction get20 = Lua_BlackJack_ProjectL_UI_HeroListUITask.<>f__mg$cache8B;
		if (Lua_BlackJack_ProjectL_UI_HeroListUITask.<>f__mg$cache8C == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroListUITask.<>f__mg$cache8C = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroListUITask.set_m_unlockedList);
		}
		LuaObject.addMember(l, name28, get20, Lua_BlackJack_ProjectL_UI_HeroListUITask.<>f__mg$cache8C, true);
		string name29 = "m_curHeroPos";
		if (Lua_BlackJack_ProjectL_UI_HeroListUITask.<>f__mg$cache8D == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroListUITask.<>f__mg$cache8D = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroListUITask.get_m_curHeroPos);
		}
		LuaCSFunction get21 = Lua_BlackJack_ProjectL_UI_HeroListUITask.<>f__mg$cache8D;
		if (Lua_BlackJack_ProjectL_UI_HeroListUITask.<>f__mg$cache8E == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroListUITask.<>f__mg$cache8E = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroListUITask.set_m_curHeroPos);
		}
		LuaObject.addMember(l, name29, get21, Lua_BlackJack_ProjectL_UI_HeroListUITask.<>f__mg$cache8E, true);
		string name30 = "m_curLayerDescIndex";
		if (Lua_BlackJack_ProjectL_UI_HeroListUITask.<>f__mg$cache8F == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroListUITask.<>f__mg$cache8F = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroListUITask.get_m_curLayerDescIndex);
		}
		LuaCSFunction get22 = Lua_BlackJack_ProjectL_UI_HeroListUITask.<>f__mg$cache8F;
		if (Lua_BlackJack_ProjectL_UI_HeroListUITask.<>f__mg$cache90 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroListUITask.<>f__mg$cache90 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroListUITask.set_m_curLayerDescIndex);
		}
		LuaObject.addMember(l, name30, get22, Lua_BlackJack_ProjectL_UI_HeroListUITask.<>f__mg$cache90, true);
		string name31 = "m_lastHeroId";
		if (Lua_BlackJack_ProjectL_UI_HeroListUITask.<>f__mg$cache91 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroListUITask.<>f__mg$cache91 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroListUITask.get_m_lastHeroId);
		}
		LuaCSFunction get23 = Lua_BlackJack_ProjectL_UI_HeroListUITask.<>f__mg$cache91;
		if (Lua_BlackJack_ProjectL_UI_HeroListUITask.<>f__mg$cache92 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroListUITask.<>f__mg$cache92 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroListUITask.set_m_lastHeroId);
		}
		LuaObject.addMember(l, name31, get23, Lua_BlackJack_ProjectL_UI_HeroListUITask.<>f__mg$cache92, true);
		string name32 = "m_isUnlockHero";
		if (Lua_BlackJack_ProjectL_UI_HeroListUITask.<>f__mg$cache93 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroListUITask.<>f__mg$cache93 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroListUITask.get_m_isUnlockHero);
		}
		LuaCSFunction get24 = Lua_BlackJack_ProjectL_UI_HeroListUITask.<>f__mg$cache93;
		if (Lua_BlackJack_ProjectL_UI_HeroListUITask.<>f__mg$cache94 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroListUITask.<>f__mg$cache94 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroListUITask.set_m_isUnlockHero);
		}
		LuaObject.addMember(l, name32, get24, Lua_BlackJack_ProjectL_UI_HeroListUITask.<>f__mg$cache94, true);
		string name33 = "m_isDetailLayerOpen";
		if (Lua_BlackJack_ProjectL_UI_HeroListUITask.<>f__mg$cache95 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroListUITask.<>f__mg$cache95 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroListUITask.get_m_isDetailLayerOpen);
		}
		LuaCSFunction get25 = Lua_BlackJack_ProjectL_UI_HeroListUITask.<>f__mg$cache95;
		if (Lua_BlackJack_ProjectL_UI_HeroListUITask.<>f__mg$cache96 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroListUITask.<>f__mg$cache96 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroListUITask.set_m_isDetailLayerOpen);
		}
		LuaObject.addMember(l, name33, get25, Lua_BlackJack_ProjectL_UI_HeroListUITask.<>f__mg$cache96, true);
		string name34 = "m_curHeroSortType";
		if (Lua_BlackJack_ProjectL_UI_HeroListUITask.<>f__mg$cache97 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroListUITask.<>f__mg$cache97 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroListUITask.get_m_curHeroSortType);
		}
		LuaCSFunction get26 = Lua_BlackJack_ProjectL_UI_HeroListUITask.<>f__mg$cache97;
		if (Lua_BlackJack_ProjectL_UI_HeroListUITask.<>f__mg$cache98 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroListUITask.<>f__mg$cache98 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroListUITask.set_m_curHeroSortType);
		}
		LuaObject.addMember(l, name34, get26, Lua_BlackJack_ProjectL_UI_HeroListUITask.<>f__mg$cache98, true);
		string name35 = "m_playerContext";
		if (Lua_BlackJack_ProjectL_UI_HeroListUITask.<>f__mg$cache99 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroListUITask.<>f__mg$cache99 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroListUITask.get_m_playerContext);
		}
		LuaCSFunction get27 = Lua_BlackJack_ProjectL_UI_HeroListUITask.<>f__mg$cache99;
		if (Lua_BlackJack_ProjectL_UI_HeroListUITask.<>f__mg$cache9A == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroListUITask.<>f__mg$cache9A = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroListUITask.set_m_playerContext);
		}
		LuaObject.addMember(l, name35, get27, Lua_BlackJack_ProjectL_UI_HeroListUITask.<>f__mg$cache9A, true);
		string name36 = "m_configDataLoader";
		if (Lua_BlackJack_ProjectL_UI_HeroListUITask.<>f__mg$cache9B == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroListUITask.<>f__mg$cache9B = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroListUITask.get_m_configDataLoader);
		}
		LuaCSFunction get28 = Lua_BlackJack_ProjectL_UI_HeroListUITask.<>f__mg$cache9B;
		if (Lua_BlackJack_ProjectL_UI_HeroListUITask.<>f__mg$cache9C == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroListUITask.<>f__mg$cache9C = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroListUITask.set_m_configDataLoader);
		}
		LuaObject.addMember(l, name36, get28, Lua_BlackJack_ProjectL_UI_HeroListUITask.<>f__mg$cache9C, true);
		string name37 = "LayerDescArray";
		if (Lua_BlackJack_ProjectL_UI_HeroListUITask.<>f__mg$cache9D == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroListUITask.<>f__mg$cache9D = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroListUITask.get_LayerDescArray);
		}
		LuaObject.addMember(l, name37, Lua_BlackJack_ProjectL_UI_HeroListUITask.<>f__mg$cache9D, null, true);
		string name38 = "UICtrlDescArray";
		if (Lua_BlackJack_ProjectL_UI_HeroListUITask.<>f__mg$cache9E == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroListUITask.<>f__mg$cache9E = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroListUITask.get_UICtrlDescArray);
		}
		LuaObject.addMember(l, name38, Lua_BlackJack_ProjectL_UI_HeroListUITask.<>f__mg$cache9E, null, true);
		if (Lua_BlackJack_ProjectL_UI_HeroListUITask.<>f__mg$cache9F == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroListUITask.<>f__mg$cache9F = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroListUITask.constructor);
		}
		LuaObject.createTypeMetatable(l, Lua_BlackJack_ProjectL_UI_HeroListUITask.<>f__mg$cache9F, typeof(HeroListUITask), typeof(UITask));
	}

	// Token: 0x04015555 RID: 87381
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache0;

	// Token: 0x04015556 RID: 87382
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1;

	// Token: 0x04015557 RID: 87383
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2;

	// Token: 0x04015558 RID: 87384
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3;

	// Token: 0x04015559 RID: 87385
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache4;

	// Token: 0x0401555A RID: 87386
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache5;

	// Token: 0x0401555B RID: 87387
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache6;

	// Token: 0x0401555C RID: 87388
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache7;

	// Token: 0x0401555D RID: 87389
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache8;

	// Token: 0x0401555E RID: 87390
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache9;

	// Token: 0x0401555F RID: 87391
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheA;

	// Token: 0x04015560 RID: 87392
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheB;

	// Token: 0x04015561 RID: 87393
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheC;

	// Token: 0x04015562 RID: 87394
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheD;

	// Token: 0x04015563 RID: 87395
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheE;

	// Token: 0x04015564 RID: 87396
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheF;

	// Token: 0x04015565 RID: 87397
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache10;

	// Token: 0x04015566 RID: 87398
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache11;

	// Token: 0x04015567 RID: 87399
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache12;

	// Token: 0x04015568 RID: 87400
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache13;

	// Token: 0x04015569 RID: 87401
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache14;

	// Token: 0x0401556A RID: 87402
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache15;

	// Token: 0x0401556B RID: 87403
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache16;

	// Token: 0x0401556C RID: 87404
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache17;

	// Token: 0x0401556D RID: 87405
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache18;

	// Token: 0x0401556E RID: 87406
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache19;

	// Token: 0x0401556F RID: 87407
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1A;

	// Token: 0x04015570 RID: 87408
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1B;

	// Token: 0x04015571 RID: 87409
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1C;

	// Token: 0x04015572 RID: 87410
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1D;

	// Token: 0x04015573 RID: 87411
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1E;

	// Token: 0x04015574 RID: 87412
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1F;

	// Token: 0x04015575 RID: 87413
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache20;

	// Token: 0x04015576 RID: 87414
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache21;

	// Token: 0x04015577 RID: 87415
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache22;

	// Token: 0x04015578 RID: 87416
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache23;

	// Token: 0x04015579 RID: 87417
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache24;

	// Token: 0x0401557A RID: 87418
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache25;

	// Token: 0x0401557B RID: 87419
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache26;

	// Token: 0x0401557C RID: 87420
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache27;

	// Token: 0x0401557D RID: 87421
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache28;

	// Token: 0x0401557E RID: 87422
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache29;

	// Token: 0x0401557F RID: 87423
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2A;

	// Token: 0x04015580 RID: 87424
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2B;

	// Token: 0x04015581 RID: 87425
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2C;

	// Token: 0x04015582 RID: 87426
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2D;

	// Token: 0x04015583 RID: 87427
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2E;

	// Token: 0x04015584 RID: 87428
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2F;

	// Token: 0x04015585 RID: 87429
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache30;

	// Token: 0x04015586 RID: 87430
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache31;

	// Token: 0x04015587 RID: 87431
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache32;

	// Token: 0x04015588 RID: 87432
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache33;

	// Token: 0x04015589 RID: 87433
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache34;

	// Token: 0x0401558A RID: 87434
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache35;

	// Token: 0x0401558B RID: 87435
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache36;

	// Token: 0x0401558C RID: 87436
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache37;

	// Token: 0x0401558D RID: 87437
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache38;

	// Token: 0x0401558E RID: 87438
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache39;

	// Token: 0x0401558F RID: 87439
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3A;

	// Token: 0x04015590 RID: 87440
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3B;

	// Token: 0x04015591 RID: 87441
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3C;

	// Token: 0x04015592 RID: 87442
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3D;

	// Token: 0x04015593 RID: 87443
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3E;

	// Token: 0x04015594 RID: 87444
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3F;

	// Token: 0x04015595 RID: 87445
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache40;

	// Token: 0x04015596 RID: 87446
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache41;

	// Token: 0x04015597 RID: 87447
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache42;

	// Token: 0x04015598 RID: 87448
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache43;

	// Token: 0x04015599 RID: 87449
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache44;

	// Token: 0x0401559A RID: 87450
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache45;

	// Token: 0x0401559B RID: 87451
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache46;

	// Token: 0x0401559C RID: 87452
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache47;

	// Token: 0x0401559D RID: 87453
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache48;

	// Token: 0x0401559E RID: 87454
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache49;

	// Token: 0x0401559F RID: 87455
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache4A;

	// Token: 0x040155A0 RID: 87456
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache4B;

	// Token: 0x040155A1 RID: 87457
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache4C;

	// Token: 0x040155A2 RID: 87458
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache4D;

	// Token: 0x040155A3 RID: 87459
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache4E;

	// Token: 0x040155A4 RID: 87460
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache4F;

	// Token: 0x040155A5 RID: 87461
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache50;

	// Token: 0x040155A6 RID: 87462
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache51;

	// Token: 0x040155A7 RID: 87463
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache52;

	// Token: 0x040155A8 RID: 87464
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache53;

	// Token: 0x040155A9 RID: 87465
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache54;

	// Token: 0x040155AA RID: 87466
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache55;

	// Token: 0x040155AB RID: 87467
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache56;

	// Token: 0x040155AC RID: 87468
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache57;

	// Token: 0x040155AD RID: 87469
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache58;

	// Token: 0x040155AE RID: 87470
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache59;

	// Token: 0x040155AF RID: 87471
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache5A;

	// Token: 0x040155B0 RID: 87472
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache5B;

	// Token: 0x040155B1 RID: 87473
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache5C;

	// Token: 0x040155B2 RID: 87474
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache5D;

	// Token: 0x040155B3 RID: 87475
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache5E;

	// Token: 0x040155B4 RID: 87476
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache5F;

	// Token: 0x040155B5 RID: 87477
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache60;

	// Token: 0x040155B6 RID: 87478
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache61;

	// Token: 0x040155B7 RID: 87479
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache62;

	// Token: 0x040155B8 RID: 87480
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache63;

	// Token: 0x040155B9 RID: 87481
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache64;

	// Token: 0x040155BA RID: 87482
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache65;

	// Token: 0x040155BB RID: 87483
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache66;

	// Token: 0x040155BC RID: 87484
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache67;

	// Token: 0x040155BD RID: 87485
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache68;

	// Token: 0x040155BE RID: 87486
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache69;

	// Token: 0x040155BF RID: 87487
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache6A;

	// Token: 0x040155C0 RID: 87488
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache6B;

	// Token: 0x040155C1 RID: 87489
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache6C;

	// Token: 0x040155C2 RID: 87490
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache6D;

	// Token: 0x040155C3 RID: 87491
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache6E;

	// Token: 0x040155C4 RID: 87492
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache6F;

	// Token: 0x040155C5 RID: 87493
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache70;

	// Token: 0x040155C6 RID: 87494
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache71;

	// Token: 0x040155C7 RID: 87495
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache72;

	// Token: 0x040155C8 RID: 87496
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache73;

	// Token: 0x040155C9 RID: 87497
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache74;

	// Token: 0x040155CA RID: 87498
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache75;

	// Token: 0x040155CB RID: 87499
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache76;

	// Token: 0x040155CC RID: 87500
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache77;

	// Token: 0x040155CD RID: 87501
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache78;

	// Token: 0x040155CE RID: 87502
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache79;

	// Token: 0x040155CF RID: 87503
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache7A;

	// Token: 0x040155D0 RID: 87504
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache7B;

	// Token: 0x040155D1 RID: 87505
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache7C;

	// Token: 0x040155D2 RID: 87506
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache7D;

	// Token: 0x040155D3 RID: 87507
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache7E;

	// Token: 0x040155D4 RID: 87508
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache7F;

	// Token: 0x040155D5 RID: 87509
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache80;

	// Token: 0x040155D6 RID: 87510
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache81;

	// Token: 0x040155D7 RID: 87511
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache82;

	// Token: 0x040155D8 RID: 87512
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache83;

	// Token: 0x040155D9 RID: 87513
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache84;

	// Token: 0x040155DA RID: 87514
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache85;

	// Token: 0x040155DB RID: 87515
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache86;

	// Token: 0x040155DC RID: 87516
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache87;

	// Token: 0x040155DD RID: 87517
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache88;

	// Token: 0x040155DE RID: 87518
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache89;

	// Token: 0x040155DF RID: 87519
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache8A;

	// Token: 0x040155E0 RID: 87520
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache8B;

	// Token: 0x040155E1 RID: 87521
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache8C;

	// Token: 0x040155E2 RID: 87522
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache8D;

	// Token: 0x040155E3 RID: 87523
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache8E;

	// Token: 0x040155E4 RID: 87524
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache8F;

	// Token: 0x040155E5 RID: 87525
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache90;

	// Token: 0x040155E6 RID: 87526
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache91;

	// Token: 0x040155E7 RID: 87527
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache92;

	// Token: 0x040155E8 RID: 87528
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache93;

	// Token: 0x040155E9 RID: 87529
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache94;

	// Token: 0x040155EA RID: 87530
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache95;

	// Token: 0x040155EB RID: 87531
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache96;

	// Token: 0x040155EC RID: 87532
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache97;

	// Token: 0x040155ED RID: 87533
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache98;

	// Token: 0x040155EE RID: 87534
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache99;

	// Token: 0x040155EF RID: 87535
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache9A;

	// Token: 0x040155F0 RID: 87536
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache9B;

	// Token: 0x040155F1 RID: 87537
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache9C;

	// Token: 0x040155F2 RID: 87538
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache9D;

	// Token: 0x040155F3 RID: 87539
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache9E;

	// Token: 0x040155F4 RID: 87540
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache9F;
}
