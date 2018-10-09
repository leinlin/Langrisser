using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using BlackJack.BJFramework.Runtime.UI;
using BlackJack.ProjectL.UI;
using SLua;
using UnityEngine.Scripting;

// Token: 0x020014A4 RID: 5284
[Preserve]
public class Lua_BlackJack_ProjectL_UI_HeroBreakEffectUITask : LuaObject
{
	// Token: 0x0601E984 RID: 125316 RVA: 0x009E33E8 File Offset: 0x009E15E8
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int constructor(IntPtr l)
	{
		int result;
		try
		{
			string name;
			LuaObject.checkType(l, 2, out name);
			HeroBreakEffectUITask o = new HeroBreakEffectUITask(name);
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

	// Token: 0x0601E985 RID: 125317 RVA: 0x009E343C File Offset: 0x009E163C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int StartUITask_s(IntPtr l)
	{
		int result;
		try
		{
			UIIntent uiIntent;
			LuaObject.checkType<UIIntent>(l, 1, out uiIntent);
			int heroId;
			LuaObject.checkType(l, 2, out heroId);
			HeroBreakEffectUITask.StartUITask(uiIntent, heroId);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601E986 RID: 125318 RVA: 0x009E3494 File Offset: 0x009E1694
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int HeroBreakEffectUITask_OnLoadAllResCompleted_s(IntPtr l)
	{
		int result;
		try
		{
			HeroBreakEffectUITask.HeroBreakEffectUITask_OnLoadAllResCompleted();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601E987 RID: 125319 RVA: 0x009E34D4 File Offset: 0x009E16D4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int IsNeedLoadDynamicRes(IntPtr l)
	{
		int result;
		try
		{
			HeroBreakEffectUITask heroBreakEffectUITask = (HeroBreakEffectUITask)LuaObject.checkSelf(l);
			bool b = heroBreakEffectUITask.m_luaExportHelper.IsNeedLoadDynamicRes();
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

	// Token: 0x0601E988 RID: 125320 RVA: 0x009E3530 File Offset: 0x009E1730
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int InitAllUIControllers(IntPtr l)
	{
		int result;
		try
		{
			HeroBreakEffectUITask heroBreakEffectUITask = (HeroBreakEffectUITask)LuaObject.checkSelf(l);
			heroBreakEffectUITask.m_luaExportHelper.InitAllUIControllers();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601E989 RID: 125321 RVA: 0x009E3584 File Offset: 0x009E1784
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int ClearAllContextAndRes(IntPtr l)
	{
		int result;
		try
		{
			HeroBreakEffectUITask heroBreakEffectUITask = (HeroBreakEffectUITask)LuaObject.checkSelf(l);
			heroBreakEffectUITask.m_luaExportHelper.ClearAllContextAndRes();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601E98A RID: 125322 RVA: 0x009E35D8 File Offset: 0x009E17D8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int UpdateView(IntPtr l)
	{
		int result;
		try
		{
			HeroBreakEffectUITask heroBreakEffectUITask = (HeroBreakEffectUITask)LuaObject.checkSelf(l);
			heroBreakEffectUITask.m_luaExportHelper.UpdateView();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601E98B RID: 125323 RVA: 0x009E362C File Offset: 0x009E182C
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int OnClose(IntPtr l)
	{
		int result;
		try
		{
			HeroBreakEffectUITask heroBreakEffectUITask = (HeroBreakEffectUITask)LuaObject.checkSelf(l);
			heroBreakEffectUITask.m_luaExportHelper.OnClose();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601E98C RID: 125324 RVA: 0x009E3680 File Offset: 0x009E1880
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int __callBase_OnStart(IntPtr l)
	{
		int result;
		try
		{
			HeroBreakEffectUITask heroBreakEffectUITask = (HeroBreakEffectUITask)LuaObject.checkSelf(l);
			UIIntent intent;
			LuaObject.checkType<UIIntent>(l, 2, out intent);
			bool b = heroBreakEffectUITask.m_luaExportHelper.__callBase_OnStart(intent);
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

	// Token: 0x0601E98D RID: 125325 RVA: 0x009E36E8 File Offset: 0x009E18E8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_OnStop(IntPtr l)
	{
		int result;
		try
		{
			HeroBreakEffectUITask heroBreakEffectUITask = (HeroBreakEffectUITask)LuaObject.checkSelf(l);
			heroBreakEffectUITask.m_luaExportHelper.__callBase_OnStop();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601E98E RID: 125326 RVA: 0x009E373C File Offset: 0x009E193C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_OnPause(IntPtr l)
	{
		int result;
		try
		{
			HeroBreakEffectUITask heroBreakEffectUITask = (HeroBreakEffectUITask)LuaObject.checkSelf(l);
			heroBreakEffectUITask.m_luaExportHelper.__callBase_OnPause();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601E98F RID: 125327 RVA: 0x009E3790 File Offset: 0x009E1990
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_OnResume(IntPtr l)
	{
		int result;
		try
		{
			HeroBreakEffectUITask heroBreakEffectUITask = (HeroBreakEffectUITask)LuaObject.checkSelf(l);
			UIIntent intent;
			LuaObject.checkType<UIIntent>(l, 2, out intent);
			bool b = heroBreakEffectUITask.m_luaExportHelper.__callBase_OnResume(intent);
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

	// Token: 0x0601E990 RID: 125328 RVA: 0x009E37F8 File Offset: 0x009E19F8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_OnNewIntent(IntPtr l)
	{
		int result;
		try
		{
			HeroBreakEffectUITask heroBreakEffectUITask = (HeroBreakEffectUITask)LuaObject.checkSelf(l);
			UIIntent intent;
			LuaObject.checkType<UIIntent>(l, 2, out intent);
			bool b = heroBreakEffectUITask.m_luaExportHelper.__callBase_OnNewIntent(intent);
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

	// Token: 0x0601E991 RID: 125329 RVA: 0x009E3860 File Offset: 0x009E1A60
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_EnableUIInput(IntPtr l)
	{
		int result;
		try
		{
			HeroBreakEffectUITask heroBreakEffectUITask = (HeroBreakEffectUITask)LuaObject.checkSelf(l);
			bool isEnable;
			LuaObject.checkType(l, 2, out isEnable);
			bool? isGlobalEnable;
			LuaObject.checkNullable<bool>(l, 3, out isGlobalEnable);
			heroBreakEffectUITask.m_luaExportHelper.__callBase_EnableUIInput(isEnable, isGlobalEnable);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601E992 RID: 125330 RVA: 0x009E38CC File Offset: 0x009E1ACC
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int __callBase_IsNeedLoadDynamicRes(IntPtr l)
	{
		int result;
		try
		{
			HeroBreakEffectUITask heroBreakEffectUITask = (HeroBreakEffectUITask)LuaObject.checkSelf(l);
			bool b = heroBreakEffectUITask.m_luaExportHelper.__callBase_IsNeedLoadDynamicRes();
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

	// Token: 0x0601E993 RID: 125331 RVA: 0x009E3928 File Offset: 0x009E1B28
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_CollectAllDynamicResForLoad(IntPtr l)
	{
		int result;
		try
		{
			HeroBreakEffectUITask heroBreakEffectUITask = (HeroBreakEffectUITask)LuaObject.checkSelf(l);
			List<string> o = heroBreakEffectUITask.m_luaExportHelper.__callBase_CollectAllDynamicResForLoad();
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

	// Token: 0x0601E994 RID: 125332 RVA: 0x009E3984 File Offset: 0x009E1B84
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_RegisterPlayerContextEvents(IntPtr l)
	{
		int result;
		try
		{
			HeroBreakEffectUITask heroBreakEffectUITask = (HeroBreakEffectUITask)LuaObject.checkSelf(l);
			heroBreakEffectUITask.m_luaExportHelper.__callBase_RegisterPlayerContextEvents();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601E995 RID: 125333 RVA: 0x009E39D8 File Offset: 0x009E1BD8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_UnregisterPlayerContextEvents(IntPtr l)
	{
		int result;
		try
		{
			HeroBreakEffectUITask heroBreakEffectUITask = (HeroBreakEffectUITask)LuaObject.checkSelf(l);
			heroBreakEffectUITask.m_luaExportHelper.__callBase_UnregisterPlayerContextEvents();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601E996 RID: 125334 RVA: 0x009E3A2C File Offset: 0x009E1C2C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_PostUpdateView(IntPtr l)
	{
		int result;
		try
		{
			HeroBreakEffectUITask heroBreakEffectUITask = (HeroBreakEffectUITask)LuaObject.checkSelf(l);
			heroBreakEffectUITask.m_luaExportHelper.__callBase_PostUpdateView();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601E997 RID: 125335 RVA: 0x009E3A80 File Offset: 0x009E1C80
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_CollectPreloadResourceList(IntPtr l)
	{
		int result;
		try
		{
			HeroBreakEffectUITask heroBreakEffectUITask = (HeroBreakEffectUITask)LuaObject.checkSelf(l);
			heroBreakEffectUITask.m_luaExportHelper.__callBase_CollectPreloadResourceList();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601E998 RID: 125336 RVA: 0x009E3AD4 File Offset: 0x009E1CD4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_ClearAssetList(IntPtr l)
	{
		int result;
		try
		{
			HeroBreakEffectUITask heroBreakEffectUITask = (HeroBreakEffectUITask)LuaObject.checkSelf(l);
			heroBreakEffectUITask.m_luaExportHelper.__callBase_ClearAssetList();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601E999 RID: 125337 RVA: 0x009E3B28 File Offset: 0x009E1D28
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_CollectAsset(IntPtr l)
	{
		int result;
		try
		{
			HeroBreakEffectUITask heroBreakEffectUITask = (HeroBreakEffectUITask)LuaObject.checkSelf(l);
			string assetName;
			LuaObject.checkType(l, 2, out assetName);
			heroBreakEffectUITask.m_luaExportHelper.__callBase_CollectAsset(assetName);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601E99A RID: 125338 RVA: 0x009E3B84 File Offset: 0x009E1D84
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_CollectSpriteAsset(IntPtr l)
	{
		int result;
		try
		{
			HeroBreakEffectUITask heroBreakEffectUITask = (HeroBreakEffectUITask)LuaObject.checkSelf(l);
			string assetName;
			LuaObject.checkType(l, 2, out assetName);
			heroBreakEffectUITask.m_luaExportHelper.__callBase_CollectSpriteAsset(assetName);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601E99B RID: 125339 RVA: 0x009E3BE0 File Offset: 0x009E1DE0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_CollectFxAsset(IntPtr l)
	{
		int result;
		try
		{
			HeroBreakEffectUITask heroBreakEffectUITask = (HeroBreakEffectUITask)LuaObject.checkSelf(l);
			string assetName;
			LuaObject.checkType(l, 2, out assetName);
			heroBreakEffectUITask.m_luaExportHelper.__callBase_CollectFxAsset(assetName);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601E99C RID: 125340 RVA: 0x009E3C3C File Offset: 0x009E1E3C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_StartLoadCustomAssets(IntPtr l)
	{
		int result;
		try
		{
			HeroBreakEffectUITask heroBreakEffectUITask = (HeroBreakEffectUITask)LuaObject.checkSelf(l);
			Action onLoadCompleted;
			LuaObject.checkDelegate<Action>(l, 2, out onLoadCompleted);
			heroBreakEffectUITask.m_luaExportHelper.__callBase_StartLoadCustomAssets(onLoadCompleted);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601E99D RID: 125341 RVA: 0x009E3C98 File Offset: 0x009E1E98
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int __callBase_IsLoadingCustomAssets(IntPtr l)
	{
		int result;
		try
		{
			HeroBreakEffectUITask heroBreakEffectUITask = (HeroBreakEffectUITask)LuaObject.checkSelf(l);
			bool b = heroBreakEffectUITask.m_luaExportHelper.__callBase_IsLoadingCustomAssets();
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

	// Token: 0x0601E99E RID: 125342 RVA: 0x009E3CF4 File Offset: 0x009E1EF4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_IsPipeLineRunning(IntPtr l)
	{
		int result;
		try
		{
			HeroBreakEffectUITask heroBreakEffectUITask = (HeroBreakEffectUITask)LuaObject.checkSelf(l);
			bool b = heroBreakEffectUITask.m_luaExportHelper.__callBase_IsPipeLineRunning();
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

	// Token: 0x0601E99F RID: 125343 RVA: 0x009E3D50 File Offset: 0x009E1F50
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int __callBase_IsOpeningUI(IntPtr l)
	{
		int result;
		try
		{
			HeroBreakEffectUITask heroBreakEffectUITask = (HeroBreakEffectUITask)LuaObject.checkSelf(l);
			bool b = heroBreakEffectUITask.m_luaExportHelper.__callBase_IsOpeningUI();
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

	// Token: 0x0601E9A0 RID: 125344 RVA: 0x009E3DAC File Offset: 0x009E1FAC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_ReturnPrevUITask(IntPtr l)
	{
		int result;
		try
		{
			HeroBreakEffectUITask heroBreakEffectUITask = (HeroBreakEffectUITask)LuaObject.checkSelf(l);
			UITaskBase o = heroBreakEffectUITask.m_luaExportHelper.__callBase_ReturnPrevUITask();
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

	// Token: 0x0601E9A1 RID: 125345 RVA: 0x009E3E08 File Offset: 0x009E2008
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_ClearUnusedDynamicResourceCache(IntPtr l)
	{
		int result;
		try
		{
			HeroBreakEffectUITask heroBreakEffectUITask = (HeroBreakEffectUITask)LuaObject.checkSelf(l);
			heroBreakEffectUITask.m_luaExportHelper.__callBase_ClearUnusedDynamicResourceCache();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601E9A2 RID: 125346 RVA: 0x009E3E5C File Offset: 0x009E205C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_OnMemoryWarning(IntPtr l)
	{
		int result;
		try
		{
			HeroBreakEffectUITask heroBreakEffectUITask = (HeroBreakEffectUITask)LuaObject.checkSelf(l);
			heroBreakEffectUITask.m_luaExportHelper.__callBase_OnMemoryWarning();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601E9A3 RID: 125347 RVA: 0x009E3EB0 File Offset: 0x009E20B0
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_m_layerDescArray(IntPtr l)
	{
		int result;
		try
		{
			HeroBreakEffectUITask heroBreakEffectUITask = (HeroBreakEffectUITask)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, heroBreakEffectUITask.m_luaExportHelper.m_layerDescArray);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601E9A4 RID: 125348 RVA: 0x009E3F08 File Offset: 0x009E2108
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_layerDescArray(IntPtr l)
	{
		int result;
		try
		{
			HeroBreakEffectUITask heroBreakEffectUITask = (HeroBreakEffectUITask)LuaObject.checkSelf(l);
			UITaskBase.LayerDesc[] layerDescArray;
			LuaObject.checkArray<UITaskBase.LayerDesc>(l, 2, out layerDescArray);
			heroBreakEffectUITask.m_luaExportHelper.m_layerDescArray = layerDescArray;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601E9A5 RID: 125349 RVA: 0x009E3F64 File Offset: 0x009E2164
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_uiCtrlDescArray(IntPtr l)
	{
		int result;
		try
		{
			HeroBreakEffectUITask heroBreakEffectUITask = (HeroBreakEffectUITask)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, heroBreakEffectUITask.m_luaExportHelper.m_uiCtrlDescArray);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601E9A6 RID: 125350 RVA: 0x009E3FBC File Offset: 0x009E21BC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_uiCtrlDescArray(IntPtr l)
	{
		int result;
		try
		{
			HeroBreakEffectUITask heroBreakEffectUITask = (HeroBreakEffectUITask)LuaObject.checkSelf(l);
			UITaskBase.UIControllerDesc[] uiCtrlDescArray;
			LuaObject.checkArray<UITaskBase.UIControllerDesc>(l, 2, out uiCtrlDescArray);
			heroBreakEffectUITask.m_luaExportHelper.m_uiCtrlDescArray = uiCtrlDescArray;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601E9A7 RID: 125351 RVA: 0x009E4018 File Offset: 0x009E2218
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_heroBreakEffectUIController(IntPtr l)
	{
		int result;
		try
		{
			HeroBreakEffectUITask heroBreakEffectUITask = (HeroBreakEffectUITask)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, heroBreakEffectUITask.m_luaExportHelper.m_heroBreakEffectUIController);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601E9A8 RID: 125352 RVA: 0x009E4070 File Offset: 0x009E2270
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_heroBreakEffectUIController(IntPtr l)
	{
		int result;
		try
		{
			HeroBreakEffectUITask heroBreakEffectUITask = (HeroBreakEffectUITask)LuaObject.checkSelf(l);
			HeroBreakEffectUIController heroBreakEffectUIController;
			LuaObject.checkType<HeroBreakEffectUIController>(l, 2, out heroBreakEffectUIController);
			heroBreakEffectUITask.m_luaExportHelper.m_heroBreakEffectUIController = heroBreakEffectUIController;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601E9A9 RID: 125353 RVA: 0x009E40CC File Offset: 0x009E22CC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_heroId(IntPtr l)
	{
		int result;
		try
		{
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, HeroBreakEffectUITask.LuaExportHelper.m_heroId);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601E9AA RID: 125354 RVA: 0x009E4114 File Offset: 0x009E2314
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_heroId(IntPtr l)
	{
		int result;
		try
		{
			int heroId;
			LuaObject.checkType(l, 2, out heroId);
			HeroBreakEffectUITask.LuaExportHelper.m_heroId = heroId;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601E9AB RID: 125355 RVA: 0x009E4160 File Offset: 0x009E2360
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_preUiIntent(IntPtr l)
	{
		int result;
		try
		{
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, HeroBreakEffectUITask.LuaExportHelper.m_preUiIntent);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601E9AC RID: 125356 RVA: 0x009E41A8 File Offset: 0x009E23A8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_preUiIntent(IntPtr l)
	{
		int result;
		try
		{
			UIIntent preUiIntent;
			LuaObject.checkType<UIIntent>(l, 2, out preUiIntent);
			HeroBreakEffectUITask.LuaExportHelper.m_preUiIntent = preUiIntent;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601E9AD RID: 125357 RVA: 0x009E41F4 File Offset: 0x009E23F4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_LayerDescArray(IntPtr l)
	{
		int result;
		try
		{
			HeroBreakEffectUITask heroBreakEffectUITask = (HeroBreakEffectUITask)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, heroBreakEffectUITask.m_luaExportHelper.LayerDescArray);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601E9AE RID: 125358 RVA: 0x009E424C File Offset: 0x009E244C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_UICtrlDescArray(IntPtr l)
	{
		int result;
		try
		{
			HeroBreakEffectUITask heroBreakEffectUITask = (HeroBreakEffectUITask)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, heroBreakEffectUITask.m_luaExportHelper.UICtrlDescArray);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601E9AF RID: 125359 RVA: 0x009E42A4 File Offset: 0x009E24A4
	[Preserve]
	public static void reg(IntPtr l)
	{
		LuaObject.getTypeTable(l, "BlackJack.ProjectL.UI.HeroBreakEffectUITask");
		if (Lua_BlackJack_ProjectL_UI_HeroBreakEffectUITask.<>f__mg$cache0 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroBreakEffectUITask.<>f__mg$cache0 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroBreakEffectUITask.StartUITask_s);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_HeroBreakEffectUITask.<>f__mg$cache0);
		if (Lua_BlackJack_ProjectL_UI_HeroBreakEffectUITask.<>f__mg$cache1 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroBreakEffectUITask.<>f__mg$cache1 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroBreakEffectUITask.HeroBreakEffectUITask_OnLoadAllResCompleted_s);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_HeroBreakEffectUITask.<>f__mg$cache1);
		if (Lua_BlackJack_ProjectL_UI_HeroBreakEffectUITask.<>f__mg$cache2 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroBreakEffectUITask.<>f__mg$cache2 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroBreakEffectUITask.IsNeedLoadDynamicRes);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_HeroBreakEffectUITask.<>f__mg$cache2);
		if (Lua_BlackJack_ProjectL_UI_HeroBreakEffectUITask.<>f__mg$cache3 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroBreakEffectUITask.<>f__mg$cache3 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroBreakEffectUITask.InitAllUIControllers);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_HeroBreakEffectUITask.<>f__mg$cache3);
		if (Lua_BlackJack_ProjectL_UI_HeroBreakEffectUITask.<>f__mg$cache4 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroBreakEffectUITask.<>f__mg$cache4 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroBreakEffectUITask.ClearAllContextAndRes);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_HeroBreakEffectUITask.<>f__mg$cache4);
		if (Lua_BlackJack_ProjectL_UI_HeroBreakEffectUITask.<>f__mg$cache5 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroBreakEffectUITask.<>f__mg$cache5 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroBreakEffectUITask.UpdateView);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_HeroBreakEffectUITask.<>f__mg$cache5);
		if (Lua_BlackJack_ProjectL_UI_HeroBreakEffectUITask.<>f__mg$cache6 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroBreakEffectUITask.<>f__mg$cache6 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroBreakEffectUITask.OnClose);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_HeroBreakEffectUITask.<>f__mg$cache6);
		if (Lua_BlackJack_ProjectL_UI_HeroBreakEffectUITask.<>f__mg$cache7 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroBreakEffectUITask.<>f__mg$cache7 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroBreakEffectUITask.__callBase_OnStart);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_HeroBreakEffectUITask.<>f__mg$cache7);
		if (Lua_BlackJack_ProjectL_UI_HeroBreakEffectUITask.<>f__mg$cache8 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroBreakEffectUITask.<>f__mg$cache8 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroBreakEffectUITask.__callBase_OnStop);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_HeroBreakEffectUITask.<>f__mg$cache8);
		if (Lua_BlackJack_ProjectL_UI_HeroBreakEffectUITask.<>f__mg$cache9 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroBreakEffectUITask.<>f__mg$cache9 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroBreakEffectUITask.__callBase_OnPause);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_HeroBreakEffectUITask.<>f__mg$cache9);
		if (Lua_BlackJack_ProjectL_UI_HeroBreakEffectUITask.<>f__mg$cacheA == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroBreakEffectUITask.<>f__mg$cacheA = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroBreakEffectUITask.__callBase_OnResume);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_HeroBreakEffectUITask.<>f__mg$cacheA);
		if (Lua_BlackJack_ProjectL_UI_HeroBreakEffectUITask.<>f__mg$cacheB == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroBreakEffectUITask.<>f__mg$cacheB = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroBreakEffectUITask.__callBase_OnNewIntent);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_HeroBreakEffectUITask.<>f__mg$cacheB);
		if (Lua_BlackJack_ProjectL_UI_HeroBreakEffectUITask.<>f__mg$cacheC == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroBreakEffectUITask.<>f__mg$cacheC = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroBreakEffectUITask.__callBase_EnableUIInput);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_HeroBreakEffectUITask.<>f__mg$cacheC);
		if (Lua_BlackJack_ProjectL_UI_HeroBreakEffectUITask.<>f__mg$cacheD == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroBreakEffectUITask.<>f__mg$cacheD = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroBreakEffectUITask.__callBase_IsNeedLoadDynamicRes);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_HeroBreakEffectUITask.<>f__mg$cacheD);
		if (Lua_BlackJack_ProjectL_UI_HeroBreakEffectUITask.<>f__mg$cacheE == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroBreakEffectUITask.<>f__mg$cacheE = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroBreakEffectUITask.__callBase_CollectAllDynamicResForLoad);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_HeroBreakEffectUITask.<>f__mg$cacheE);
		if (Lua_BlackJack_ProjectL_UI_HeroBreakEffectUITask.<>f__mg$cacheF == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroBreakEffectUITask.<>f__mg$cacheF = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroBreakEffectUITask.__callBase_RegisterPlayerContextEvents);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_HeroBreakEffectUITask.<>f__mg$cacheF);
		if (Lua_BlackJack_ProjectL_UI_HeroBreakEffectUITask.<>f__mg$cache10 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroBreakEffectUITask.<>f__mg$cache10 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroBreakEffectUITask.__callBase_UnregisterPlayerContextEvents);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_HeroBreakEffectUITask.<>f__mg$cache10);
		if (Lua_BlackJack_ProjectL_UI_HeroBreakEffectUITask.<>f__mg$cache11 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroBreakEffectUITask.<>f__mg$cache11 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroBreakEffectUITask.__callBase_PostUpdateView);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_HeroBreakEffectUITask.<>f__mg$cache11);
		if (Lua_BlackJack_ProjectL_UI_HeroBreakEffectUITask.<>f__mg$cache12 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroBreakEffectUITask.<>f__mg$cache12 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroBreakEffectUITask.__callBase_CollectPreloadResourceList);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_HeroBreakEffectUITask.<>f__mg$cache12);
		if (Lua_BlackJack_ProjectL_UI_HeroBreakEffectUITask.<>f__mg$cache13 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroBreakEffectUITask.<>f__mg$cache13 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroBreakEffectUITask.__callBase_ClearAssetList);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_HeroBreakEffectUITask.<>f__mg$cache13);
		if (Lua_BlackJack_ProjectL_UI_HeroBreakEffectUITask.<>f__mg$cache14 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroBreakEffectUITask.<>f__mg$cache14 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroBreakEffectUITask.__callBase_CollectAsset);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_HeroBreakEffectUITask.<>f__mg$cache14);
		if (Lua_BlackJack_ProjectL_UI_HeroBreakEffectUITask.<>f__mg$cache15 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroBreakEffectUITask.<>f__mg$cache15 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroBreakEffectUITask.__callBase_CollectSpriteAsset);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_HeroBreakEffectUITask.<>f__mg$cache15);
		if (Lua_BlackJack_ProjectL_UI_HeroBreakEffectUITask.<>f__mg$cache16 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroBreakEffectUITask.<>f__mg$cache16 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroBreakEffectUITask.__callBase_CollectFxAsset);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_HeroBreakEffectUITask.<>f__mg$cache16);
		if (Lua_BlackJack_ProjectL_UI_HeroBreakEffectUITask.<>f__mg$cache17 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroBreakEffectUITask.<>f__mg$cache17 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroBreakEffectUITask.__callBase_StartLoadCustomAssets);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_HeroBreakEffectUITask.<>f__mg$cache17);
		if (Lua_BlackJack_ProjectL_UI_HeroBreakEffectUITask.<>f__mg$cache18 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroBreakEffectUITask.<>f__mg$cache18 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroBreakEffectUITask.__callBase_IsLoadingCustomAssets);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_HeroBreakEffectUITask.<>f__mg$cache18);
		if (Lua_BlackJack_ProjectL_UI_HeroBreakEffectUITask.<>f__mg$cache19 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroBreakEffectUITask.<>f__mg$cache19 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroBreakEffectUITask.__callBase_IsPipeLineRunning);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_HeroBreakEffectUITask.<>f__mg$cache19);
		if (Lua_BlackJack_ProjectL_UI_HeroBreakEffectUITask.<>f__mg$cache1A == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroBreakEffectUITask.<>f__mg$cache1A = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroBreakEffectUITask.__callBase_IsOpeningUI);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_HeroBreakEffectUITask.<>f__mg$cache1A);
		if (Lua_BlackJack_ProjectL_UI_HeroBreakEffectUITask.<>f__mg$cache1B == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroBreakEffectUITask.<>f__mg$cache1B = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroBreakEffectUITask.__callBase_ReturnPrevUITask);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_HeroBreakEffectUITask.<>f__mg$cache1B);
		if (Lua_BlackJack_ProjectL_UI_HeroBreakEffectUITask.<>f__mg$cache1C == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroBreakEffectUITask.<>f__mg$cache1C = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroBreakEffectUITask.__callBase_ClearUnusedDynamicResourceCache);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_HeroBreakEffectUITask.<>f__mg$cache1C);
		if (Lua_BlackJack_ProjectL_UI_HeroBreakEffectUITask.<>f__mg$cache1D == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroBreakEffectUITask.<>f__mg$cache1D = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroBreakEffectUITask.__callBase_OnMemoryWarning);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_HeroBreakEffectUITask.<>f__mg$cache1D);
		string name = "m_layerDescArray";
		if (Lua_BlackJack_ProjectL_UI_HeroBreakEffectUITask.<>f__mg$cache1E == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroBreakEffectUITask.<>f__mg$cache1E = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroBreakEffectUITask.get_m_layerDescArray);
		}
		LuaCSFunction get = Lua_BlackJack_ProjectL_UI_HeroBreakEffectUITask.<>f__mg$cache1E;
		if (Lua_BlackJack_ProjectL_UI_HeroBreakEffectUITask.<>f__mg$cache1F == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroBreakEffectUITask.<>f__mg$cache1F = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroBreakEffectUITask.set_m_layerDescArray);
		}
		LuaObject.addMember(l, name, get, Lua_BlackJack_ProjectL_UI_HeroBreakEffectUITask.<>f__mg$cache1F, true);
		string name2 = "m_uiCtrlDescArray";
		if (Lua_BlackJack_ProjectL_UI_HeroBreakEffectUITask.<>f__mg$cache20 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroBreakEffectUITask.<>f__mg$cache20 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroBreakEffectUITask.get_m_uiCtrlDescArray);
		}
		LuaCSFunction get2 = Lua_BlackJack_ProjectL_UI_HeroBreakEffectUITask.<>f__mg$cache20;
		if (Lua_BlackJack_ProjectL_UI_HeroBreakEffectUITask.<>f__mg$cache21 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroBreakEffectUITask.<>f__mg$cache21 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroBreakEffectUITask.set_m_uiCtrlDescArray);
		}
		LuaObject.addMember(l, name2, get2, Lua_BlackJack_ProjectL_UI_HeroBreakEffectUITask.<>f__mg$cache21, true);
		string name3 = "m_heroBreakEffectUIController";
		if (Lua_BlackJack_ProjectL_UI_HeroBreakEffectUITask.<>f__mg$cache22 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroBreakEffectUITask.<>f__mg$cache22 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroBreakEffectUITask.get_m_heroBreakEffectUIController);
		}
		LuaCSFunction get3 = Lua_BlackJack_ProjectL_UI_HeroBreakEffectUITask.<>f__mg$cache22;
		if (Lua_BlackJack_ProjectL_UI_HeroBreakEffectUITask.<>f__mg$cache23 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroBreakEffectUITask.<>f__mg$cache23 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroBreakEffectUITask.set_m_heroBreakEffectUIController);
		}
		LuaObject.addMember(l, name3, get3, Lua_BlackJack_ProjectL_UI_HeroBreakEffectUITask.<>f__mg$cache23, true);
		string name4 = "m_heroId";
		if (Lua_BlackJack_ProjectL_UI_HeroBreakEffectUITask.<>f__mg$cache24 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroBreakEffectUITask.<>f__mg$cache24 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroBreakEffectUITask.get_m_heroId);
		}
		LuaCSFunction get4 = Lua_BlackJack_ProjectL_UI_HeroBreakEffectUITask.<>f__mg$cache24;
		if (Lua_BlackJack_ProjectL_UI_HeroBreakEffectUITask.<>f__mg$cache25 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroBreakEffectUITask.<>f__mg$cache25 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroBreakEffectUITask.set_m_heroId);
		}
		LuaObject.addMember(l, name4, get4, Lua_BlackJack_ProjectL_UI_HeroBreakEffectUITask.<>f__mg$cache25, false);
		string name5 = "m_preUiIntent";
		if (Lua_BlackJack_ProjectL_UI_HeroBreakEffectUITask.<>f__mg$cache26 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroBreakEffectUITask.<>f__mg$cache26 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroBreakEffectUITask.get_m_preUiIntent);
		}
		LuaCSFunction get5 = Lua_BlackJack_ProjectL_UI_HeroBreakEffectUITask.<>f__mg$cache26;
		if (Lua_BlackJack_ProjectL_UI_HeroBreakEffectUITask.<>f__mg$cache27 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroBreakEffectUITask.<>f__mg$cache27 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroBreakEffectUITask.set_m_preUiIntent);
		}
		LuaObject.addMember(l, name5, get5, Lua_BlackJack_ProjectL_UI_HeroBreakEffectUITask.<>f__mg$cache27, false);
		string name6 = "LayerDescArray";
		if (Lua_BlackJack_ProjectL_UI_HeroBreakEffectUITask.<>f__mg$cache28 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroBreakEffectUITask.<>f__mg$cache28 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroBreakEffectUITask.get_LayerDescArray);
		}
		LuaObject.addMember(l, name6, Lua_BlackJack_ProjectL_UI_HeroBreakEffectUITask.<>f__mg$cache28, null, true);
		string name7 = "UICtrlDescArray";
		if (Lua_BlackJack_ProjectL_UI_HeroBreakEffectUITask.<>f__mg$cache29 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroBreakEffectUITask.<>f__mg$cache29 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroBreakEffectUITask.get_UICtrlDescArray);
		}
		LuaObject.addMember(l, name7, Lua_BlackJack_ProjectL_UI_HeroBreakEffectUITask.<>f__mg$cache29, null, true);
		if (Lua_BlackJack_ProjectL_UI_HeroBreakEffectUITask.<>f__mg$cache2A == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroBreakEffectUITask.<>f__mg$cache2A = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroBreakEffectUITask.constructor);
		}
		LuaObject.createTypeMetatable(l, Lua_BlackJack_ProjectL_UI_HeroBreakEffectUITask.<>f__mg$cache2A, typeof(HeroBreakEffectUITask), typeof(UITask));
	}

	// Token: 0x04014A1E RID: 84510
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache0;

	// Token: 0x04014A1F RID: 84511
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1;

	// Token: 0x04014A20 RID: 84512
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2;

	// Token: 0x04014A21 RID: 84513
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3;

	// Token: 0x04014A22 RID: 84514
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache4;

	// Token: 0x04014A23 RID: 84515
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache5;

	// Token: 0x04014A24 RID: 84516
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache6;

	// Token: 0x04014A25 RID: 84517
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache7;

	// Token: 0x04014A26 RID: 84518
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache8;

	// Token: 0x04014A27 RID: 84519
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache9;

	// Token: 0x04014A28 RID: 84520
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheA;

	// Token: 0x04014A29 RID: 84521
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheB;

	// Token: 0x04014A2A RID: 84522
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheC;

	// Token: 0x04014A2B RID: 84523
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheD;

	// Token: 0x04014A2C RID: 84524
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheE;

	// Token: 0x04014A2D RID: 84525
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheF;

	// Token: 0x04014A2E RID: 84526
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache10;

	// Token: 0x04014A2F RID: 84527
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache11;

	// Token: 0x04014A30 RID: 84528
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache12;

	// Token: 0x04014A31 RID: 84529
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache13;

	// Token: 0x04014A32 RID: 84530
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache14;

	// Token: 0x04014A33 RID: 84531
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache15;

	// Token: 0x04014A34 RID: 84532
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache16;

	// Token: 0x04014A35 RID: 84533
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache17;

	// Token: 0x04014A36 RID: 84534
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache18;

	// Token: 0x04014A37 RID: 84535
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache19;

	// Token: 0x04014A38 RID: 84536
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1A;

	// Token: 0x04014A39 RID: 84537
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1B;

	// Token: 0x04014A3A RID: 84538
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1C;

	// Token: 0x04014A3B RID: 84539
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1D;

	// Token: 0x04014A3C RID: 84540
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1E;

	// Token: 0x04014A3D RID: 84541
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1F;

	// Token: 0x04014A3E RID: 84542
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache20;

	// Token: 0x04014A3F RID: 84543
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache21;

	// Token: 0x04014A40 RID: 84544
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache22;

	// Token: 0x04014A41 RID: 84545
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache23;

	// Token: 0x04014A42 RID: 84546
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache24;

	// Token: 0x04014A43 RID: 84547
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache25;

	// Token: 0x04014A44 RID: 84548
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache26;

	// Token: 0x04014A45 RID: 84549
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache27;

	// Token: 0x04014A46 RID: 84550
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache28;

	// Token: 0x04014A47 RID: 84551
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache29;

	// Token: 0x04014A48 RID: 84552
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2A;
}
