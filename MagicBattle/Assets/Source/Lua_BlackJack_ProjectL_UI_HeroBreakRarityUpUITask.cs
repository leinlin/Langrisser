using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using BlackJack.BJFramework.Runtime.UI;
using BlackJack.ProjectL.UI;
using SLua;
using UnityEngine.Scripting;

// Token: 0x020014A6 RID: 5286
[Preserve]
public class Lua_BlackJack_ProjectL_UI_HeroBreakRarityUpUITask : LuaObject
{
	// Token: 0x0601E9D4 RID: 125396 RVA: 0x009E5B30 File Offset: 0x009E3D30
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int constructor(IntPtr l)
	{
		int result;
		try
		{
			string name;
			LuaObject.checkType(l, 2, out name);
			HeroBreakRarityUpUITask o = new HeroBreakRarityUpUITask(name);
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

	// Token: 0x0601E9D5 RID: 125397 RVA: 0x009E5B84 File Offset: 0x009E3D84
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int StartUITask_s(IntPtr l)
	{
		int result;
		try
		{
			UIIntent uiIntent;
			LuaObject.checkType<UIIntent>(l, 1, out uiIntent);
			int heroId;
			LuaObject.checkType(l, 2, out heroId);
			HeroBreakRarityUpUITask.StartUITask(uiIntent, heroId);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601E9D6 RID: 125398 RVA: 0x009E5BDC File Offset: 0x009E3DDC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int HeroBreakRarityUpUITask_OnLoadAllResCompleted_s(IntPtr l)
	{
		int result;
		try
		{
			HeroBreakRarityUpUITask.HeroBreakRarityUpUITask_OnLoadAllResCompleted();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601E9D7 RID: 125399 RVA: 0x009E5C1C File Offset: 0x009E3E1C
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int IsNeedLoadDynamicRes(IntPtr l)
	{
		int result;
		try
		{
			HeroBreakRarityUpUITask heroBreakRarityUpUITask = (HeroBreakRarityUpUITask)LuaObject.checkSelf(l);
			bool b = heroBreakRarityUpUITask.m_luaExportHelper.IsNeedLoadDynamicRes();
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

	// Token: 0x0601E9D8 RID: 125400 RVA: 0x009E5C78 File Offset: 0x009E3E78
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int InitAllUIControllers(IntPtr l)
	{
		int result;
		try
		{
			HeroBreakRarityUpUITask heroBreakRarityUpUITask = (HeroBreakRarityUpUITask)LuaObject.checkSelf(l);
			heroBreakRarityUpUITask.m_luaExportHelper.InitAllUIControllers();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601E9D9 RID: 125401 RVA: 0x009E5CCC File Offset: 0x009E3ECC
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int ClearAllContextAndRes(IntPtr l)
	{
		int result;
		try
		{
			HeroBreakRarityUpUITask heroBreakRarityUpUITask = (HeroBreakRarityUpUITask)LuaObject.checkSelf(l);
			heroBreakRarityUpUITask.m_luaExportHelper.ClearAllContextAndRes();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601E9DA RID: 125402 RVA: 0x009E5D20 File Offset: 0x009E3F20
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int UpdateView(IntPtr l)
	{
		int result;
		try
		{
			HeroBreakRarityUpUITask heroBreakRarityUpUITask = (HeroBreakRarityUpUITask)LuaObject.checkSelf(l);
			heroBreakRarityUpUITask.m_luaExportHelper.UpdateView();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601E9DB RID: 125403 RVA: 0x009E5D74 File Offset: 0x009E3F74
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int OnClose(IntPtr l)
	{
		int result;
		try
		{
			HeroBreakRarityUpUITask heroBreakRarityUpUITask = (HeroBreakRarityUpUITask)LuaObject.checkSelf(l);
			heroBreakRarityUpUITask.m_luaExportHelper.OnClose();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601E9DC RID: 125404 RVA: 0x009E5DC8 File Offset: 0x009E3FC8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_OnStart(IntPtr l)
	{
		int result;
		try
		{
			HeroBreakRarityUpUITask heroBreakRarityUpUITask = (HeroBreakRarityUpUITask)LuaObject.checkSelf(l);
			UIIntent intent;
			LuaObject.checkType<UIIntent>(l, 2, out intent);
			bool b = heroBreakRarityUpUITask.m_luaExportHelper.__callBase_OnStart(intent);
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

	// Token: 0x0601E9DD RID: 125405 RVA: 0x009E5E30 File Offset: 0x009E4030
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_OnStop(IntPtr l)
	{
		int result;
		try
		{
			HeroBreakRarityUpUITask heroBreakRarityUpUITask = (HeroBreakRarityUpUITask)LuaObject.checkSelf(l);
			heroBreakRarityUpUITask.m_luaExportHelper.__callBase_OnStop();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601E9DE RID: 125406 RVA: 0x009E5E84 File Offset: 0x009E4084
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_OnPause(IntPtr l)
	{
		int result;
		try
		{
			HeroBreakRarityUpUITask heroBreakRarityUpUITask = (HeroBreakRarityUpUITask)LuaObject.checkSelf(l);
			heroBreakRarityUpUITask.m_luaExportHelper.__callBase_OnPause();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601E9DF RID: 125407 RVA: 0x009E5ED8 File Offset: 0x009E40D8
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int __callBase_OnResume(IntPtr l)
	{
		int result;
		try
		{
			HeroBreakRarityUpUITask heroBreakRarityUpUITask = (HeroBreakRarityUpUITask)LuaObject.checkSelf(l);
			UIIntent intent;
			LuaObject.checkType<UIIntent>(l, 2, out intent);
			bool b = heroBreakRarityUpUITask.m_luaExportHelper.__callBase_OnResume(intent);
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

	// Token: 0x0601E9E0 RID: 125408 RVA: 0x009E5F40 File Offset: 0x009E4140
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int __callBase_OnNewIntent(IntPtr l)
	{
		int result;
		try
		{
			HeroBreakRarityUpUITask heroBreakRarityUpUITask = (HeroBreakRarityUpUITask)LuaObject.checkSelf(l);
			UIIntent intent;
			LuaObject.checkType<UIIntent>(l, 2, out intent);
			bool b = heroBreakRarityUpUITask.m_luaExportHelper.__callBase_OnNewIntent(intent);
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

	// Token: 0x0601E9E1 RID: 125409 RVA: 0x009E5FA8 File Offset: 0x009E41A8
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int __callBase_EnableUIInput(IntPtr l)
	{
		int result;
		try
		{
			HeroBreakRarityUpUITask heroBreakRarityUpUITask = (HeroBreakRarityUpUITask)LuaObject.checkSelf(l);
			bool isEnable;
			LuaObject.checkType(l, 2, out isEnable);
			bool? isGlobalEnable;
			LuaObject.checkNullable<bool>(l, 3, out isGlobalEnable);
			heroBreakRarityUpUITask.m_luaExportHelper.__callBase_EnableUIInput(isEnable, isGlobalEnable);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601E9E2 RID: 125410 RVA: 0x009E6014 File Offset: 0x009E4214
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_IsNeedLoadDynamicRes(IntPtr l)
	{
		int result;
		try
		{
			HeroBreakRarityUpUITask heroBreakRarityUpUITask = (HeroBreakRarityUpUITask)LuaObject.checkSelf(l);
			bool b = heroBreakRarityUpUITask.m_luaExportHelper.__callBase_IsNeedLoadDynamicRes();
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

	// Token: 0x0601E9E3 RID: 125411 RVA: 0x009E6070 File Offset: 0x009E4270
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_CollectAllDynamicResForLoad(IntPtr l)
	{
		int result;
		try
		{
			HeroBreakRarityUpUITask heroBreakRarityUpUITask = (HeroBreakRarityUpUITask)LuaObject.checkSelf(l);
			List<string> o = heroBreakRarityUpUITask.m_luaExportHelper.__callBase_CollectAllDynamicResForLoad();
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

	// Token: 0x0601E9E4 RID: 125412 RVA: 0x009E60CC File Offset: 0x009E42CC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_RegisterPlayerContextEvents(IntPtr l)
	{
		int result;
		try
		{
			HeroBreakRarityUpUITask heroBreakRarityUpUITask = (HeroBreakRarityUpUITask)LuaObject.checkSelf(l);
			heroBreakRarityUpUITask.m_luaExportHelper.__callBase_RegisterPlayerContextEvents();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601E9E5 RID: 125413 RVA: 0x009E6120 File Offset: 0x009E4320
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_UnregisterPlayerContextEvents(IntPtr l)
	{
		int result;
		try
		{
			HeroBreakRarityUpUITask heroBreakRarityUpUITask = (HeroBreakRarityUpUITask)LuaObject.checkSelf(l);
			heroBreakRarityUpUITask.m_luaExportHelper.__callBase_UnregisterPlayerContextEvents();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601E9E6 RID: 125414 RVA: 0x009E6174 File Offset: 0x009E4374
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int __callBase_PostUpdateView(IntPtr l)
	{
		int result;
		try
		{
			HeroBreakRarityUpUITask heroBreakRarityUpUITask = (HeroBreakRarityUpUITask)LuaObject.checkSelf(l);
			heroBreakRarityUpUITask.m_luaExportHelper.__callBase_PostUpdateView();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601E9E7 RID: 125415 RVA: 0x009E61C8 File Offset: 0x009E43C8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_CollectPreloadResourceList(IntPtr l)
	{
		int result;
		try
		{
			HeroBreakRarityUpUITask heroBreakRarityUpUITask = (HeroBreakRarityUpUITask)LuaObject.checkSelf(l);
			heroBreakRarityUpUITask.m_luaExportHelper.__callBase_CollectPreloadResourceList();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601E9E8 RID: 125416 RVA: 0x009E621C File Offset: 0x009E441C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_ClearAssetList(IntPtr l)
	{
		int result;
		try
		{
			HeroBreakRarityUpUITask heroBreakRarityUpUITask = (HeroBreakRarityUpUITask)LuaObject.checkSelf(l);
			heroBreakRarityUpUITask.m_luaExportHelper.__callBase_ClearAssetList();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601E9E9 RID: 125417 RVA: 0x009E6270 File Offset: 0x009E4470
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_CollectAsset(IntPtr l)
	{
		int result;
		try
		{
			HeroBreakRarityUpUITask heroBreakRarityUpUITask = (HeroBreakRarityUpUITask)LuaObject.checkSelf(l);
			string assetName;
			LuaObject.checkType(l, 2, out assetName);
			heroBreakRarityUpUITask.m_luaExportHelper.__callBase_CollectAsset(assetName);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601E9EA RID: 125418 RVA: 0x009E62CC File Offset: 0x009E44CC
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int __callBase_CollectSpriteAsset(IntPtr l)
	{
		int result;
		try
		{
			HeroBreakRarityUpUITask heroBreakRarityUpUITask = (HeroBreakRarityUpUITask)LuaObject.checkSelf(l);
			string assetName;
			LuaObject.checkType(l, 2, out assetName);
			heroBreakRarityUpUITask.m_luaExportHelper.__callBase_CollectSpriteAsset(assetName);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601E9EB RID: 125419 RVA: 0x009E6328 File Offset: 0x009E4528
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_CollectFxAsset(IntPtr l)
	{
		int result;
		try
		{
			HeroBreakRarityUpUITask heroBreakRarityUpUITask = (HeroBreakRarityUpUITask)LuaObject.checkSelf(l);
			string assetName;
			LuaObject.checkType(l, 2, out assetName);
			heroBreakRarityUpUITask.m_luaExportHelper.__callBase_CollectFxAsset(assetName);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601E9EC RID: 125420 RVA: 0x009E6384 File Offset: 0x009E4584
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int __callBase_StartLoadCustomAssets(IntPtr l)
	{
		int result;
		try
		{
			HeroBreakRarityUpUITask heroBreakRarityUpUITask = (HeroBreakRarityUpUITask)LuaObject.checkSelf(l);
			Action onLoadCompleted;
			LuaObject.checkDelegate<Action>(l, 2, out onLoadCompleted);
			heroBreakRarityUpUITask.m_luaExportHelper.__callBase_StartLoadCustomAssets(onLoadCompleted);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601E9ED RID: 125421 RVA: 0x009E63E0 File Offset: 0x009E45E0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_IsLoadingCustomAssets(IntPtr l)
	{
		int result;
		try
		{
			HeroBreakRarityUpUITask heroBreakRarityUpUITask = (HeroBreakRarityUpUITask)LuaObject.checkSelf(l);
			bool b = heroBreakRarityUpUITask.m_luaExportHelper.__callBase_IsLoadingCustomAssets();
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

	// Token: 0x0601E9EE RID: 125422 RVA: 0x009E643C File Offset: 0x009E463C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_IsPipeLineRunning(IntPtr l)
	{
		int result;
		try
		{
			HeroBreakRarityUpUITask heroBreakRarityUpUITask = (HeroBreakRarityUpUITask)LuaObject.checkSelf(l);
			bool b = heroBreakRarityUpUITask.m_luaExportHelper.__callBase_IsPipeLineRunning();
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

	// Token: 0x0601E9EF RID: 125423 RVA: 0x009E6498 File Offset: 0x009E4698
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_IsOpeningUI(IntPtr l)
	{
		int result;
		try
		{
			HeroBreakRarityUpUITask heroBreakRarityUpUITask = (HeroBreakRarityUpUITask)LuaObject.checkSelf(l);
			bool b = heroBreakRarityUpUITask.m_luaExportHelper.__callBase_IsOpeningUI();
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

	// Token: 0x0601E9F0 RID: 125424 RVA: 0x009E64F4 File Offset: 0x009E46F4
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int __callBase_ReturnPrevUITask(IntPtr l)
	{
		int result;
		try
		{
			HeroBreakRarityUpUITask heroBreakRarityUpUITask = (HeroBreakRarityUpUITask)LuaObject.checkSelf(l);
			UITaskBase o = heroBreakRarityUpUITask.m_luaExportHelper.__callBase_ReturnPrevUITask();
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

	// Token: 0x0601E9F1 RID: 125425 RVA: 0x009E6550 File Offset: 0x009E4750
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_ClearUnusedDynamicResourceCache(IntPtr l)
	{
		int result;
		try
		{
			HeroBreakRarityUpUITask heroBreakRarityUpUITask = (HeroBreakRarityUpUITask)LuaObject.checkSelf(l);
			heroBreakRarityUpUITask.m_luaExportHelper.__callBase_ClearUnusedDynamicResourceCache();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601E9F2 RID: 125426 RVA: 0x009E65A4 File Offset: 0x009E47A4
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int __callBase_OnMemoryWarning(IntPtr l)
	{
		int result;
		try
		{
			HeroBreakRarityUpUITask heroBreakRarityUpUITask = (HeroBreakRarityUpUITask)LuaObject.checkSelf(l);
			heroBreakRarityUpUITask.m_luaExportHelper.__callBase_OnMemoryWarning();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601E9F3 RID: 125427 RVA: 0x009E65F8 File Offset: 0x009E47F8
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_m_layerDescArray(IntPtr l)
	{
		int result;
		try
		{
			HeroBreakRarityUpUITask heroBreakRarityUpUITask = (HeroBreakRarityUpUITask)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, heroBreakRarityUpUITask.m_luaExportHelper.m_layerDescArray);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601E9F4 RID: 125428 RVA: 0x009E6650 File Offset: 0x009E4850
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_m_layerDescArray(IntPtr l)
	{
		int result;
		try
		{
			HeroBreakRarityUpUITask heroBreakRarityUpUITask = (HeroBreakRarityUpUITask)LuaObject.checkSelf(l);
			UITaskBase.LayerDesc[] layerDescArray;
			LuaObject.checkArray<UITaskBase.LayerDesc>(l, 2, out layerDescArray);
			heroBreakRarityUpUITask.m_luaExportHelper.m_layerDescArray = layerDescArray;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601E9F5 RID: 125429 RVA: 0x009E66AC File Offset: 0x009E48AC
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_m_uiCtrlDescArray(IntPtr l)
	{
		int result;
		try
		{
			HeroBreakRarityUpUITask heroBreakRarityUpUITask = (HeroBreakRarityUpUITask)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, heroBreakRarityUpUITask.m_luaExportHelper.m_uiCtrlDescArray);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601E9F6 RID: 125430 RVA: 0x009E6704 File Offset: 0x009E4904
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_uiCtrlDescArray(IntPtr l)
	{
		int result;
		try
		{
			HeroBreakRarityUpUITask heroBreakRarityUpUITask = (HeroBreakRarityUpUITask)LuaObject.checkSelf(l);
			UITaskBase.UIControllerDesc[] uiCtrlDescArray;
			LuaObject.checkArray<UITaskBase.UIControllerDesc>(l, 2, out uiCtrlDescArray);
			heroBreakRarityUpUITask.m_luaExportHelper.m_uiCtrlDescArray = uiCtrlDescArray;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601E9F7 RID: 125431 RVA: 0x009E6760 File Offset: 0x009E4960
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_heroBreakRarityUpUIController(IntPtr l)
	{
		int result;
		try
		{
			HeroBreakRarityUpUITask heroBreakRarityUpUITask = (HeroBreakRarityUpUITask)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, heroBreakRarityUpUITask.m_luaExportHelper.m_heroBreakRarityUpUIController);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601E9F8 RID: 125432 RVA: 0x009E67B8 File Offset: 0x009E49B8
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_m_heroBreakRarityUpUIController(IntPtr l)
	{
		int result;
		try
		{
			HeroBreakRarityUpUITask heroBreakRarityUpUITask = (HeroBreakRarityUpUITask)LuaObject.checkSelf(l);
			HeroBreakRarityUpUIController heroBreakRarityUpUIController;
			LuaObject.checkType<HeroBreakRarityUpUIController>(l, 2, out heroBreakRarityUpUIController);
			heroBreakRarityUpUITask.m_luaExportHelper.m_heroBreakRarityUpUIController = heroBreakRarityUpUIController;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601E9F9 RID: 125433 RVA: 0x009E6814 File Offset: 0x009E4A14
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_heroId(IntPtr l)
	{
		int result;
		try
		{
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, HeroBreakRarityUpUITask.LuaExportHelper.m_heroId);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601E9FA RID: 125434 RVA: 0x009E685C File Offset: 0x009E4A5C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_heroId(IntPtr l)
	{
		int result;
		try
		{
			int heroId;
			LuaObject.checkType(l, 2, out heroId);
			HeroBreakRarityUpUITask.LuaExportHelper.m_heroId = heroId;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601E9FB RID: 125435 RVA: 0x009E68A8 File Offset: 0x009E4AA8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_LayerDescArray(IntPtr l)
	{
		int result;
		try
		{
			HeroBreakRarityUpUITask heroBreakRarityUpUITask = (HeroBreakRarityUpUITask)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, heroBreakRarityUpUITask.m_luaExportHelper.LayerDescArray);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601E9FC RID: 125436 RVA: 0x009E6900 File Offset: 0x009E4B00
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_UICtrlDescArray(IntPtr l)
	{
		int result;
		try
		{
			HeroBreakRarityUpUITask heroBreakRarityUpUITask = (HeroBreakRarityUpUITask)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, heroBreakRarityUpUITask.m_luaExportHelper.UICtrlDescArray);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601E9FD RID: 125437 RVA: 0x009E6958 File Offset: 0x009E4B58
	[Preserve]
	public static void reg(IntPtr l)
	{
		LuaObject.getTypeTable(l, "BlackJack.ProjectL.UI.HeroBreakRarityUpUITask");
		if (Lua_BlackJack_ProjectL_UI_HeroBreakRarityUpUITask.<>f__mg$cache0 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroBreakRarityUpUITask.<>f__mg$cache0 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroBreakRarityUpUITask.StartUITask_s);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_HeroBreakRarityUpUITask.<>f__mg$cache0);
		if (Lua_BlackJack_ProjectL_UI_HeroBreakRarityUpUITask.<>f__mg$cache1 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroBreakRarityUpUITask.<>f__mg$cache1 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroBreakRarityUpUITask.HeroBreakRarityUpUITask_OnLoadAllResCompleted_s);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_HeroBreakRarityUpUITask.<>f__mg$cache1);
		if (Lua_BlackJack_ProjectL_UI_HeroBreakRarityUpUITask.<>f__mg$cache2 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroBreakRarityUpUITask.<>f__mg$cache2 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroBreakRarityUpUITask.IsNeedLoadDynamicRes);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_HeroBreakRarityUpUITask.<>f__mg$cache2);
		if (Lua_BlackJack_ProjectL_UI_HeroBreakRarityUpUITask.<>f__mg$cache3 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroBreakRarityUpUITask.<>f__mg$cache3 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroBreakRarityUpUITask.InitAllUIControllers);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_HeroBreakRarityUpUITask.<>f__mg$cache3);
		if (Lua_BlackJack_ProjectL_UI_HeroBreakRarityUpUITask.<>f__mg$cache4 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroBreakRarityUpUITask.<>f__mg$cache4 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroBreakRarityUpUITask.ClearAllContextAndRes);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_HeroBreakRarityUpUITask.<>f__mg$cache4);
		if (Lua_BlackJack_ProjectL_UI_HeroBreakRarityUpUITask.<>f__mg$cache5 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroBreakRarityUpUITask.<>f__mg$cache5 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroBreakRarityUpUITask.UpdateView);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_HeroBreakRarityUpUITask.<>f__mg$cache5);
		if (Lua_BlackJack_ProjectL_UI_HeroBreakRarityUpUITask.<>f__mg$cache6 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroBreakRarityUpUITask.<>f__mg$cache6 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroBreakRarityUpUITask.OnClose);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_HeroBreakRarityUpUITask.<>f__mg$cache6);
		if (Lua_BlackJack_ProjectL_UI_HeroBreakRarityUpUITask.<>f__mg$cache7 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroBreakRarityUpUITask.<>f__mg$cache7 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroBreakRarityUpUITask.__callBase_OnStart);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_HeroBreakRarityUpUITask.<>f__mg$cache7);
		if (Lua_BlackJack_ProjectL_UI_HeroBreakRarityUpUITask.<>f__mg$cache8 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroBreakRarityUpUITask.<>f__mg$cache8 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroBreakRarityUpUITask.__callBase_OnStop);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_HeroBreakRarityUpUITask.<>f__mg$cache8);
		if (Lua_BlackJack_ProjectL_UI_HeroBreakRarityUpUITask.<>f__mg$cache9 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroBreakRarityUpUITask.<>f__mg$cache9 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroBreakRarityUpUITask.__callBase_OnPause);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_HeroBreakRarityUpUITask.<>f__mg$cache9);
		if (Lua_BlackJack_ProjectL_UI_HeroBreakRarityUpUITask.<>f__mg$cacheA == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroBreakRarityUpUITask.<>f__mg$cacheA = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroBreakRarityUpUITask.__callBase_OnResume);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_HeroBreakRarityUpUITask.<>f__mg$cacheA);
		if (Lua_BlackJack_ProjectL_UI_HeroBreakRarityUpUITask.<>f__mg$cacheB == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroBreakRarityUpUITask.<>f__mg$cacheB = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroBreakRarityUpUITask.__callBase_OnNewIntent);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_HeroBreakRarityUpUITask.<>f__mg$cacheB);
		if (Lua_BlackJack_ProjectL_UI_HeroBreakRarityUpUITask.<>f__mg$cacheC == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroBreakRarityUpUITask.<>f__mg$cacheC = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroBreakRarityUpUITask.__callBase_EnableUIInput);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_HeroBreakRarityUpUITask.<>f__mg$cacheC);
		if (Lua_BlackJack_ProjectL_UI_HeroBreakRarityUpUITask.<>f__mg$cacheD == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroBreakRarityUpUITask.<>f__mg$cacheD = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroBreakRarityUpUITask.__callBase_IsNeedLoadDynamicRes);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_HeroBreakRarityUpUITask.<>f__mg$cacheD);
		if (Lua_BlackJack_ProjectL_UI_HeroBreakRarityUpUITask.<>f__mg$cacheE == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroBreakRarityUpUITask.<>f__mg$cacheE = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroBreakRarityUpUITask.__callBase_CollectAllDynamicResForLoad);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_HeroBreakRarityUpUITask.<>f__mg$cacheE);
		if (Lua_BlackJack_ProjectL_UI_HeroBreakRarityUpUITask.<>f__mg$cacheF == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroBreakRarityUpUITask.<>f__mg$cacheF = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroBreakRarityUpUITask.__callBase_RegisterPlayerContextEvents);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_HeroBreakRarityUpUITask.<>f__mg$cacheF);
		if (Lua_BlackJack_ProjectL_UI_HeroBreakRarityUpUITask.<>f__mg$cache10 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroBreakRarityUpUITask.<>f__mg$cache10 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroBreakRarityUpUITask.__callBase_UnregisterPlayerContextEvents);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_HeroBreakRarityUpUITask.<>f__mg$cache10);
		if (Lua_BlackJack_ProjectL_UI_HeroBreakRarityUpUITask.<>f__mg$cache11 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroBreakRarityUpUITask.<>f__mg$cache11 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroBreakRarityUpUITask.__callBase_PostUpdateView);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_HeroBreakRarityUpUITask.<>f__mg$cache11);
		if (Lua_BlackJack_ProjectL_UI_HeroBreakRarityUpUITask.<>f__mg$cache12 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroBreakRarityUpUITask.<>f__mg$cache12 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroBreakRarityUpUITask.__callBase_CollectPreloadResourceList);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_HeroBreakRarityUpUITask.<>f__mg$cache12);
		if (Lua_BlackJack_ProjectL_UI_HeroBreakRarityUpUITask.<>f__mg$cache13 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroBreakRarityUpUITask.<>f__mg$cache13 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroBreakRarityUpUITask.__callBase_ClearAssetList);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_HeroBreakRarityUpUITask.<>f__mg$cache13);
		if (Lua_BlackJack_ProjectL_UI_HeroBreakRarityUpUITask.<>f__mg$cache14 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroBreakRarityUpUITask.<>f__mg$cache14 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroBreakRarityUpUITask.__callBase_CollectAsset);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_HeroBreakRarityUpUITask.<>f__mg$cache14);
		if (Lua_BlackJack_ProjectL_UI_HeroBreakRarityUpUITask.<>f__mg$cache15 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroBreakRarityUpUITask.<>f__mg$cache15 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroBreakRarityUpUITask.__callBase_CollectSpriteAsset);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_HeroBreakRarityUpUITask.<>f__mg$cache15);
		if (Lua_BlackJack_ProjectL_UI_HeroBreakRarityUpUITask.<>f__mg$cache16 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroBreakRarityUpUITask.<>f__mg$cache16 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroBreakRarityUpUITask.__callBase_CollectFxAsset);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_HeroBreakRarityUpUITask.<>f__mg$cache16);
		if (Lua_BlackJack_ProjectL_UI_HeroBreakRarityUpUITask.<>f__mg$cache17 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroBreakRarityUpUITask.<>f__mg$cache17 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroBreakRarityUpUITask.__callBase_StartLoadCustomAssets);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_HeroBreakRarityUpUITask.<>f__mg$cache17);
		if (Lua_BlackJack_ProjectL_UI_HeroBreakRarityUpUITask.<>f__mg$cache18 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroBreakRarityUpUITask.<>f__mg$cache18 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroBreakRarityUpUITask.__callBase_IsLoadingCustomAssets);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_HeroBreakRarityUpUITask.<>f__mg$cache18);
		if (Lua_BlackJack_ProjectL_UI_HeroBreakRarityUpUITask.<>f__mg$cache19 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroBreakRarityUpUITask.<>f__mg$cache19 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroBreakRarityUpUITask.__callBase_IsPipeLineRunning);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_HeroBreakRarityUpUITask.<>f__mg$cache19);
		if (Lua_BlackJack_ProjectL_UI_HeroBreakRarityUpUITask.<>f__mg$cache1A == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroBreakRarityUpUITask.<>f__mg$cache1A = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroBreakRarityUpUITask.__callBase_IsOpeningUI);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_HeroBreakRarityUpUITask.<>f__mg$cache1A);
		if (Lua_BlackJack_ProjectL_UI_HeroBreakRarityUpUITask.<>f__mg$cache1B == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroBreakRarityUpUITask.<>f__mg$cache1B = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroBreakRarityUpUITask.__callBase_ReturnPrevUITask);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_HeroBreakRarityUpUITask.<>f__mg$cache1B);
		if (Lua_BlackJack_ProjectL_UI_HeroBreakRarityUpUITask.<>f__mg$cache1C == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroBreakRarityUpUITask.<>f__mg$cache1C = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroBreakRarityUpUITask.__callBase_ClearUnusedDynamicResourceCache);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_HeroBreakRarityUpUITask.<>f__mg$cache1C);
		if (Lua_BlackJack_ProjectL_UI_HeroBreakRarityUpUITask.<>f__mg$cache1D == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroBreakRarityUpUITask.<>f__mg$cache1D = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroBreakRarityUpUITask.__callBase_OnMemoryWarning);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_HeroBreakRarityUpUITask.<>f__mg$cache1D);
		string name = "m_layerDescArray";
		if (Lua_BlackJack_ProjectL_UI_HeroBreakRarityUpUITask.<>f__mg$cache1E == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroBreakRarityUpUITask.<>f__mg$cache1E = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroBreakRarityUpUITask.get_m_layerDescArray);
		}
		LuaCSFunction get = Lua_BlackJack_ProjectL_UI_HeroBreakRarityUpUITask.<>f__mg$cache1E;
		if (Lua_BlackJack_ProjectL_UI_HeroBreakRarityUpUITask.<>f__mg$cache1F == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroBreakRarityUpUITask.<>f__mg$cache1F = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroBreakRarityUpUITask.set_m_layerDescArray);
		}
		LuaObject.addMember(l, name, get, Lua_BlackJack_ProjectL_UI_HeroBreakRarityUpUITask.<>f__mg$cache1F, true);
		string name2 = "m_uiCtrlDescArray";
		if (Lua_BlackJack_ProjectL_UI_HeroBreakRarityUpUITask.<>f__mg$cache20 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroBreakRarityUpUITask.<>f__mg$cache20 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroBreakRarityUpUITask.get_m_uiCtrlDescArray);
		}
		LuaCSFunction get2 = Lua_BlackJack_ProjectL_UI_HeroBreakRarityUpUITask.<>f__mg$cache20;
		if (Lua_BlackJack_ProjectL_UI_HeroBreakRarityUpUITask.<>f__mg$cache21 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroBreakRarityUpUITask.<>f__mg$cache21 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroBreakRarityUpUITask.set_m_uiCtrlDescArray);
		}
		LuaObject.addMember(l, name2, get2, Lua_BlackJack_ProjectL_UI_HeroBreakRarityUpUITask.<>f__mg$cache21, true);
		string name3 = "m_heroBreakRarityUpUIController";
		if (Lua_BlackJack_ProjectL_UI_HeroBreakRarityUpUITask.<>f__mg$cache22 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroBreakRarityUpUITask.<>f__mg$cache22 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroBreakRarityUpUITask.get_m_heroBreakRarityUpUIController);
		}
		LuaCSFunction get3 = Lua_BlackJack_ProjectL_UI_HeroBreakRarityUpUITask.<>f__mg$cache22;
		if (Lua_BlackJack_ProjectL_UI_HeroBreakRarityUpUITask.<>f__mg$cache23 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroBreakRarityUpUITask.<>f__mg$cache23 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroBreakRarityUpUITask.set_m_heroBreakRarityUpUIController);
		}
		LuaObject.addMember(l, name3, get3, Lua_BlackJack_ProjectL_UI_HeroBreakRarityUpUITask.<>f__mg$cache23, true);
		string name4 = "m_heroId";
		if (Lua_BlackJack_ProjectL_UI_HeroBreakRarityUpUITask.<>f__mg$cache24 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroBreakRarityUpUITask.<>f__mg$cache24 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroBreakRarityUpUITask.get_m_heroId);
		}
		LuaCSFunction get4 = Lua_BlackJack_ProjectL_UI_HeroBreakRarityUpUITask.<>f__mg$cache24;
		if (Lua_BlackJack_ProjectL_UI_HeroBreakRarityUpUITask.<>f__mg$cache25 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroBreakRarityUpUITask.<>f__mg$cache25 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroBreakRarityUpUITask.set_m_heroId);
		}
		LuaObject.addMember(l, name4, get4, Lua_BlackJack_ProjectL_UI_HeroBreakRarityUpUITask.<>f__mg$cache25, false);
		string name5 = "LayerDescArray";
		if (Lua_BlackJack_ProjectL_UI_HeroBreakRarityUpUITask.<>f__mg$cache26 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroBreakRarityUpUITask.<>f__mg$cache26 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroBreakRarityUpUITask.get_LayerDescArray);
		}
		LuaObject.addMember(l, name5, Lua_BlackJack_ProjectL_UI_HeroBreakRarityUpUITask.<>f__mg$cache26, null, true);
		string name6 = "UICtrlDescArray";
		if (Lua_BlackJack_ProjectL_UI_HeroBreakRarityUpUITask.<>f__mg$cache27 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroBreakRarityUpUITask.<>f__mg$cache27 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroBreakRarityUpUITask.get_UICtrlDescArray);
		}
		LuaObject.addMember(l, name6, Lua_BlackJack_ProjectL_UI_HeroBreakRarityUpUITask.<>f__mg$cache27, null, true);
		if (Lua_BlackJack_ProjectL_UI_HeroBreakRarityUpUITask.<>f__mg$cache28 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroBreakRarityUpUITask.<>f__mg$cache28 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroBreakRarityUpUITask.constructor);
		}
		LuaObject.createTypeMetatable(l, Lua_BlackJack_ProjectL_UI_HeroBreakRarityUpUITask.<>f__mg$cache28, typeof(HeroBreakRarityUpUITask), typeof(UITask));
	}

	// Token: 0x04014A6A RID: 84586
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache0;

	// Token: 0x04014A6B RID: 84587
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1;

	// Token: 0x04014A6C RID: 84588
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2;

	// Token: 0x04014A6D RID: 84589
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3;

	// Token: 0x04014A6E RID: 84590
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache4;

	// Token: 0x04014A6F RID: 84591
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache5;

	// Token: 0x04014A70 RID: 84592
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache6;

	// Token: 0x04014A71 RID: 84593
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache7;

	// Token: 0x04014A72 RID: 84594
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache8;

	// Token: 0x04014A73 RID: 84595
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache9;

	// Token: 0x04014A74 RID: 84596
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheA;

	// Token: 0x04014A75 RID: 84597
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheB;

	// Token: 0x04014A76 RID: 84598
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheC;

	// Token: 0x04014A77 RID: 84599
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheD;

	// Token: 0x04014A78 RID: 84600
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheE;

	// Token: 0x04014A79 RID: 84601
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheF;

	// Token: 0x04014A7A RID: 84602
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache10;

	// Token: 0x04014A7B RID: 84603
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache11;

	// Token: 0x04014A7C RID: 84604
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache12;

	// Token: 0x04014A7D RID: 84605
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache13;

	// Token: 0x04014A7E RID: 84606
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache14;

	// Token: 0x04014A7F RID: 84607
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache15;

	// Token: 0x04014A80 RID: 84608
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache16;

	// Token: 0x04014A81 RID: 84609
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache17;

	// Token: 0x04014A82 RID: 84610
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache18;

	// Token: 0x04014A83 RID: 84611
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache19;

	// Token: 0x04014A84 RID: 84612
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1A;

	// Token: 0x04014A85 RID: 84613
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1B;

	// Token: 0x04014A86 RID: 84614
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1C;

	// Token: 0x04014A87 RID: 84615
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1D;

	// Token: 0x04014A88 RID: 84616
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1E;

	// Token: 0x04014A89 RID: 84617
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1F;

	// Token: 0x04014A8A RID: 84618
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache20;

	// Token: 0x04014A8B RID: 84619
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache21;

	// Token: 0x04014A8C RID: 84620
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache22;

	// Token: 0x04014A8D RID: 84621
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache23;

	// Token: 0x04014A8E RID: 84622
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache24;

	// Token: 0x04014A8F RID: 84623
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache25;

	// Token: 0x04014A90 RID: 84624
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache26;

	// Token: 0x04014A91 RID: 84625
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache27;

	// Token: 0x04014A92 RID: 84626
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache28;
}
