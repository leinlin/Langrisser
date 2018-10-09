using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using BlackJack.BJFramework.Runtime.UI;
using BlackJack.ProjectL.UI;
using SLua;
using UnityEngine.Scripting;

// Token: 0x0200138C RID: 5004
[Preserve]
public class Lua_BlackJack_ProjectL_UI_ARUITask : LuaObject
{
	// Token: 0x0601B460 RID: 111712 RVA: 0x0083D608 File Offset: 0x0083B808
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int constructor(IntPtr l)
	{
		int result;
		try
		{
			string name;
			LuaObject.checkType(l, 2, out name);
			ARUITask o = new ARUITask(name);
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

	// Token: 0x0601B461 RID: 111713 RVA: 0x0083D65C File Offset: 0x0083B85C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int CustomLoadAsset(IntPtr l)
	{
		int result;
		try
		{
			ARUITask aruitask = (ARUITask)LuaObject.checkSelf(l);
			Action collectionCallback;
			LuaObject.checkDelegate<Action>(l, 2, out collectionCallback);
			Action finishCallback;
			LuaObject.checkDelegate<Action>(l, 3, out finishCallback);
			aruitask.CustomLoadAsset(collectionCallback, finishCallback);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601B462 RID: 111714 RVA: 0x0083D6C0 File Offset: 0x0083B8C0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int CollectAssetWrap(IntPtr l)
	{
		int result;
		try
		{
			ARUITask aruitask = (ARUITask)LuaObject.checkSelf(l);
			string assetName;
			LuaObject.checkType(l, 2, out assetName);
			aruitask.CollectAssetWrap(assetName);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601B463 RID: 111715 RVA: 0x0083D718 File Offset: 0x0083B918
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int ReturnLastTask(IntPtr l)
	{
		int result;
		try
		{
			ARUITask aruitask = (ARUITask)LuaObject.checkSelf(l);
			aruitask.ReturnLastTask();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601B464 RID: 111716 RVA: 0x0083D764 File Offset: 0x0083B964
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int InitAllUIControllers(IntPtr l)
	{
		int result;
		try
		{
			ARUITask aruitask = (ARUITask)LuaObject.checkSelf(l);
			aruitask.m_luaExportHelper.InitAllUIControllers();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601B465 RID: 111717 RVA: 0x0083D7B8 File Offset: 0x0083B9B8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int InitLayerStateOnLoadAllResCompleted(IntPtr l)
	{
		int result;
		try
		{
			ARUITask aruitask = (ARUITask)LuaObject.checkSelf(l);
			aruitask.m_luaExportHelper.InitLayerStateOnLoadAllResCompleted();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601B466 RID: 111718 RVA: 0x0083D80C File Offset: 0x0083BA0C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int OnStart(IntPtr l)
	{
		int result;
		try
		{
			ARUITask aruitask = (ARUITask)LuaObject.checkSelf(l);
			UIIntent intent;
			LuaObject.checkType<UIIntent>(l, 2, out intent);
			bool b = aruitask.m_luaExportHelper.OnStart(intent);
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

	// Token: 0x0601B467 RID: 111719 RVA: 0x0083D874 File Offset: 0x0083BA74
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int UpdateView(IntPtr l)
	{
		int result;
		try
		{
			ARUITask aruitask = (ARUITask)LuaObject.checkSelf(l);
			aruitask.m_luaExportHelper.UpdateView();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601B468 RID: 111720 RVA: 0x0083D8C8 File Offset: 0x0083BAC8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int OnResume(IntPtr l)
	{
		int result;
		try
		{
			ARUITask aruitask = (ARUITask)LuaObject.checkSelf(l);
			UIIntent intent;
			LuaObject.checkType<UIIntent>(l, 2, out intent);
			bool b = aruitask.m_luaExportHelper.OnResume(intent);
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

	// Token: 0x0601B469 RID: 111721 RVA: 0x0083D930 File Offset: 0x0083BB30
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int OnStop(IntPtr l)
	{
		int result;
		try
		{
			ARUITask aruitask = (ARUITask)LuaObject.checkSelf(l);
			aruitask.m_luaExportHelper.OnStop();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601B46A RID: 111722 RVA: 0x0083D984 File Offset: 0x0083BB84
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_OnStart(IntPtr l)
	{
		int result;
		try
		{
			ARUITask aruitask = (ARUITask)LuaObject.checkSelf(l);
			UIIntent intent;
			LuaObject.checkType<UIIntent>(l, 2, out intent);
			bool b = aruitask.m_luaExportHelper.__callBase_OnStart(intent);
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

	// Token: 0x0601B46B RID: 111723 RVA: 0x0083D9EC File Offset: 0x0083BBEC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_OnStop(IntPtr l)
	{
		int result;
		try
		{
			ARUITask aruitask = (ARUITask)LuaObject.checkSelf(l);
			aruitask.m_luaExportHelper.__callBase_OnStop();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601B46C RID: 111724 RVA: 0x0083DA40 File Offset: 0x0083BC40
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_OnPause(IntPtr l)
	{
		int result;
		try
		{
			ARUITask aruitask = (ARUITask)LuaObject.checkSelf(l);
			aruitask.m_luaExportHelper.__callBase_OnPause();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601B46D RID: 111725 RVA: 0x0083DA94 File Offset: 0x0083BC94
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_OnResume(IntPtr l)
	{
		int result;
		try
		{
			ARUITask aruitask = (ARUITask)LuaObject.checkSelf(l);
			UIIntent intent;
			LuaObject.checkType<UIIntent>(l, 2, out intent);
			bool b = aruitask.m_luaExportHelper.__callBase_OnResume(intent);
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

	// Token: 0x0601B46E RID: 111726 RVA: 0x0083DAFC File Offset: 0x0083BCFC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_OnNewIntent(IntPtr l)
	{
		int result;
		try
		{
			ARUITask aruitask = (ARUITask)LuaObject.checkSelf(l);
			UIIntent intent;
			LuaObject.checkType<UIIntent>(l, 2, out intent);
			bool b = aruitask.m_luaExportHelper.__callBase_OnNewIntent(intent);
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

	// Token: 0x0601B46F RID: 111727 RVA: 0x0083DB64 File Offset: 0x0083BD64
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_EnableUIInput(IntPtr l)
	{
		int result;
		try
		{
			ARUITask aruitask = (ARUITask)LuaObject.checkSelf(l);
			bool isEnable;
			LuaObject.checkType(l, 2, out isEnable);
			bool? isGlobalEnable;
			LuaObject.checkNullable<bool>(l, 3, out isGlobalEnable);
			aruitask.m_luaExportHelper.__callBase_EnableUIInput(isEnable, isGlobalEnable);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601B470 RID: 111728 RVA: 0x0083DBD0 File Offset: 0x0083BDD0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_IsNeedLoadDynamicRes(IntPtr l)
	{
		int result;
		try
		{
			ARUITask aruitask = (ARUITask)LuaObject.checkSelf(l);
			bool b = aruitask.m_luaExportHelper.__callBase_IsNeedLoadDynamicRes();
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

	// Token: 0x0601B471 RID: 111729 RVA: 0x0083DC2C File Offset: 0x0083BE2C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_CollectAllDynamicResForLoad(IntPtr l)
	{
		int result;
		try
		{
			ARUITask aruitask = (ARUITask)LuaObject.checkSelf(l);
			List<string> o = aruitask.m_luaExportHelper.__callBase_CollectAllDynamicResForLoad();
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

	// Token: 0x0601B472 RID: 111730 RVA: 0x0083DC88 File Offset: 0x0083BE88
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_RegisterPlayerContextEvents(IntPtr l)
	{
		int result;
		try
		{
			ARUITask aruitask = (ARUITask)LuaObject.checkSelf(l);
			aruitask.m_luaExportHelper.__callBase_RegisterPlayerContextEvents();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601B473 RID: 111731 RVA: 0x0083DCDC File Offset: 0x0083BEDC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_UnregisterPlayerContextEvents(IntPtr l)
	{
		int result;
		try
		{
			ARUITask aruitask = (ARUITask)LuaObject.checkSelf(l);
			aruitask.m_luaExportHelper.__callBase_UnregisterPlayerContextEvents();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601B474 RID: 111732 RVA: 0x0083DD30 File Offset: 0x0083BF30
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_PostUpdateView(IntPtr l)
	{
		int result;
		try
		{
			ARUITask aruitask = (ARUITask)LuaObject.checkSelf(l);
			aruitask.m_luaExportHelper.__callBase_PostUpdateView();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601B475 RID: 111733 RVA: 0x0083DD84 File Offset: 0x0083BF84
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_CollectPreloadResourceList(IntPtr l)
	{
		int result;
		try
		{
			ARUITask aruitask = (ARUITask)LuaObject.checkSelf(l);
			aruitask.m_luaExportHelper.__callBase_CollectPreloadResourceList();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601B476 RID: 111734 RVA: 0x0083DDD8 File Offset: 0x0083BFD8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_ClearAssetList(IntPtr l)
	{
		int result;
		try
		{
			ARUITask aruitask = (ARUITask)LuaObject.checkSelf(l);
			aruitask.m_luaExportHelper.__callBase_ClearAssetList();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601B477 RID: 111735 RVA: 0x0083DE2C File Offset: 0x0083C02C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_CollectAsset(IntPtr l)
	{
		int result;
		try
		{
			ARUITask aruitask = (ARUITask)LuaObject.checkSelf(l);
			string assetName;
			LuaObject.checkType(l, 2, out assetName);
			aruitask.m_luaExportHelper.__callBase_CollectAsset(assetName);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601B478 RID: 111736 RVA: 0x0083DE88 File Offset: 0x0083C088
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_CollectSpriteAsset(IntPtr l)
	{
		int result;
		try
		{
			ARUITask aruitask = (ARUITask)LuaObject.checkSelf(l);
			string assetName;
			LuaObject.checkType(l, 2, out assetName);
			aruitask.m_luaExportHelper.__callBase_CollectSpriteAsset(assetName);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601B479 RID: 111737 RVA: 0x0083DEE4 File Offset: 0x0083C0E4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_CollectFxAsset(IntPtr l)
	{
		int result;
		try
		{
			ARUITask aruitask = (ARUITask)LuaObject.checkSelf(l);
			string assetName;
			LuaObject.checkType(l, 2, out assetName);
			aruitask.m_luaExportHelper.__callBase_CollectFxAsset(assetName);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601B47A RID: 111738 RVA: 0x0083DF40 File Offset: 0x0083C140
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_StartLoadCustomAssets(IntPtr l)
	{
		int result;
		try
		{
			ARUITask aruitask = (ARUITask)LuaObject.checkSelf(l);
			Action onLoadCompleted;
			LuaObject.checkDelegate<Action>(l, 2, out onLoadCompleted);
			aruitask.m_luaExportHelper.__callBase_StartLoadCustomAssets(onLoadCompleted);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601B47B RID: 111739 RVA: 0x0083DF9C File Offset: 0x0083C19C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_IsLoadingCustomAssets(IntPtr l)
	{
		int result;
		try
		{
			ARUITask aruitask = (ARUITask)LuaObject.checkSelf(l);
			bool b = aruitask.m_luaExportHelper.__callBase_IsLoadingCustomAssets();
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

	// Token: 0x0601B47C RID: 111740 RVA: 0x0083DFF8 File Offset: 0x0083C1F8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_IsPipeLineRunning(IntPtr l)
	{
		int result;
		try
		{
			ARUITask aruitask = (ARUITask)LuaObject.checkSelf(l);
			bool b = aruitask.m_luaExportHelper.__callBase_IsPipeLineRunning();
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

	// Token: 0x0601B47D RID: 111741 RVA: 0x0083E054 File Offset: 0x0083C254
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_IsOpeningUI(IntPtr l)
	{
		int result;
		try
		{
			ARUITask aruitask = (ARUITask)LuaObject.checkSelf(l);
			bool b = aruitask.m_luaExportHelper.__callBase_IsOpeningUI();
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

	// Token: 0x0601B47E RID: 111742 RVA: 0x0083E0B0 File Offset: 0x0083C2B0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_ReturnPrevUITask(IntPtr l)
	{
		int result;
		try
		{
			ARUITask aruitask = (ARUITask)LuaObject.checkSelf(l);
			UITaskBase o = aruitask.m_luaExportHelper.__callBase_ReturnPrevUITask();
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

	// Token: 0x0601B47F RID: 111743 RVA: 0x0083E10C File Offset: 0x0083C30C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_ClearUnusedDynamicResourceCache(IntPtr l)
	{
		int result;
		try
		{
			ARUITask aruitask = (ARUITask)LuaObject.checkSelf(l);
			aruitask.m_luaExportHelper.__callBase_ClearUnusedDynamicResourceCache();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601B480 RID: 111744 RVA: 0x0083E160 File Offset: 0x0083C360
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_OnMemoryWarning(IntPtr l)
	{
		int result;
		try
		{
			ARUITask aruitask = (ARUITask)LuaObject.checkSelf(l);
			aruitask.m_luaExportHelper.__callBase_OnMemoryWarning();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601B481 RID: 111745 RVA: 0x0083E1B4 File Offset: 0x0083C3B4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_layerDescArray(IntPtr l)
	{
		int result;
		try
		{
			ARUITask aruitask = (ARUITask)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, aruitask.m_luaExportHelper.m_layerDescArray);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601B482 RID: 111746 RVA: 0x0083E20C File Offset: 0x0083C40C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_layerDescArray(IntPtr l)
	{
		int result;
		try
		{
			ARUITask aruitask = (ARUITask)LuaObject.checkSelf(l);
			UITaskBase.LayerDesc[] layerDescArray;
			LuaObject.checkArray<UITaskBase.LayerDesc>(l, 2, out layerDescArray);
			aruitask.m_luaExportHelper.m_layerDescArray = layerDescArray;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601B483 RID: 111747 RVA: 0x0083E268 File Offset: 0x0083C468
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_uiCtrlDescArray(IntPtr l)
	{
		int result;
		try
		{
			ARUITask aruitask = (ARUITask)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, aruitask.m_luaExportHelper.m_uiCtrlDescArray);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601B484 RID: 111748 RVA: 0x0083E2C0 File Offset: 0x0083C4C0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_uiCtrlDescArray(IntPtr l)
	{
		int result;
		try
		{
			ARUITask aruitask = (ARUITask)LuaObject.checkSelf(l);
			UITaskBase.UIControllerDesc[] uiCtrlDescArray;
			LuaObject.checkArray<UITaskBase.UIControllerDesc>(l, 2, out uiCtrlDescArray);
			aruitask.m_luaExportHelper.m_uiCtrlDescArray = uiCtrlDescArray;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601B485 RID: 111749 RVA: 0x0083E31C File Offset: 0x0083C51C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_arShowUIController(IntPtr l)
	{
		int result;
		try
		{
			ARUITask aruitask = (ARUITask)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, aruitask.m_luaExportHelper.m_arShowUIController);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601B486 RID: 111750 RVA: 0x0083E374 File Offset: 0x0083C574
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_arShowUIController(IntPtr l)
	{
		int result;
		try
		{
			ARUITask aruitask = (ARUITask)LuaObject.checkSelf(l);
			ARShowUIController arShowUIController;
			LuaObject.checkType<ARShowUIController>(l, 2, out arShowUIController);
			aruitask.m_luaExportHelper.m_arShowUIController = arShowUIController;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601B487 RID: 111751 RVA: 0x0083E3D0 File Offset: 0x0083C5D0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_arShowSceneController(IntPtr l)
	{
		int result;
		try
		{
			ARUITask aruitask = (ARUITask)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, aruitask.m_luaExportHelper.m_arShowSceneController);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601B488 RID: 111752 RVA: 0x0083E428 File Offset: 0x0083C628
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_arShowSceneController(IntPtr l)
	{
		int result;
		try
		{
			ARUITask aruitask = (ARUITask)LuaObject.checkSelf(l);
			ARShowSceneController arShowSceneController;
			LuaObject.checkType<ARShowSceneController>(l, 2, out arShowSceneController);
			aruitask.m_luaExportHelper.m_arShowSceneController = arShowSceneController;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601B489 RID: 111753 RVA: 0x0083E484 File Offset: 0x0083C684
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_LayerDescArray(IntPtr l)
	{
		int result;
		try
		{
			ARUITask aruitask = (ARUITask)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, aruitask.m_luaExportHelper.LayerDescArray);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601B48A RID: 111754 RVA: 0x0083E4DC File Offset: 0x0083C6DC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_UICtrlDescArray(IntPtr l)
	{
		int result;
		try
		{
			ARUITask aruitask = (ARUITask)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, aruitask.m_luaExportHelper.UICtrlDescArray);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601B48B RID: 111755 RVA: 0x0083E534 File Offset: 0x0083C734
	[Preserve]
	public static void reg(IntPtr l)
	{
		LuaObject.getTypeTable(l, "BlackJack.ProjectL.UI.ARUITask");
		if (Lua_BlackJack_ProjectL_UI_ARUITask.<>f__mg$cache0 == null)
		{
			Lua_BlackJack_ProjectL_UI_ARUITask.<>f__mg$cache0 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ARUITask.CustomLoadAsset);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_ARUITask.<>f__mg$cache0);
		if (Lua_BlackJack_ProjectL_UI_ARUITask.<>f__mg$cache1 == null)
		{
			Lua_BlackJack_ProjectL_UI_ARUITask.<>f__mg$cache1 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ARUITask.CollectAssetWrap);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_ARUITask.<>f__mg$cache1);
		if (Lua_BlackJack_ProjectL_UI_ARUITask.<>f__mg$cache2 == null)
		{
			Lua_BlackJack_ProjectL_UI_ARUITask.<>f__mg$cache2 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ARUITask.ReturnLastTask);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_ARUITask.<>f__mg$cache2);
		if (Lua_BlackJack_ProjectL_UI_ARUITask.<>f__mg$cache3 == null)
		{
			Lua_BlackJack_ProjectL_UI_ARUITask.<>f__mg$cache3 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ARUITask.InitAllUIControllers);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_ARUITask.<>f__mg$cache3);
		if (Lua_BlackJack_ProjectL_UI_ARUITask.<>f__mg$cache4 == null)
		{
			Lua_BlackJack_ProjectL_UI_ARUITask.<>f__mg$cache4 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ARUITask.InitLayerStateOnLoadAllResCompleted);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_ARUITask.<>f__mg$cache4);
		if (Lua_BlackJack_ProjectL_UI_ARUITask.<>f__mg$cache5 == null)
		{
			Lua_BlackJack_ProjectL_UI_ARUITask.<>f__mg$cache5 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ARUITask.OnStart);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_ARUITask.<>f__mg$cache5);
		if (Lua_BlackJack_ProjectL_UI_ARUITask.<>f__mg$cache6 == null)
		{
			Lua_BlackJack_ProjectL_UI_ARUITask.<>f__mg$cache6 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ARUITask.UpdateView);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_ARUITask.<>f__mg$cache6);
		if (Lua_BlackJack_ProjectL_UI_ARUITask.<>f__mg$cache7 == null)
		{
			Lua_BlackJack_ProjectL_UI_ARUITask.<>f__mg$cache7 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ARUITask.OnResume);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_ARUITask.<>f__mg$cache7);
		if (Lua_BlackJack_ProjectL_UI_ARUITask.<>f__mg$cache8 == null)
		{
			Lua_BlackJack_ProjectL_UI_ARUITask.<>f__mg$cache8 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ARUITask.OnStop);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_ARUITask.<>f__mg$cache8);
		if (Lua_BlackJack_ProjectL_UI_ARUITask.<>f__mg$cache9 == null)
		{
			Lua_BlackJack_ProjectL_UI_ARUITask.<>f__mg$cache9 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ARUITask.__callBase_OnStart);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_ARUITask.<>f__mg$cache9);
		if (Lua_BlackJack_ProjectL_UI_ARUITask.<>f__mg$cacheA == null)
		{
			Lua_BlackJack_ProjectL_UI_ARUITask.<>f__mg$cacheA = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ARUITask.__callBase_OnStop);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_ARUITask.<>f__mg$cacheA);
		if (Lua_BlackJack_ProjectL_UI_ARUITask.<>f__mg$cacheB == null)
		{
			Lua_BlackJack_ProjectL_UI_ARUITask.<>f__mg$cacheB = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ARUITask.__callBase_OnPause);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_ARUITask.<>f__mg$cacheB);
		if (Lua_BlackJack_ProjectL_UI_ARUITask.<>f__mg$cacheC == null)
		{
			Lua_BlackJack_ProjectL_UI_ARUITask.<>f__mg$cacheC = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ARUITask.__callBase_OnResume);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_ARUITask.<>f__mg$cacheC);
		if (Lua_BlackJack_ProjectL_UI_ARUITask.<>f__mg$cacheD == null)
		{
			Lua_BlackJack_ProjectL_UI_ARUITask.<>f__mg$cacheD = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ARUITask.__callBase_OnNewIntent);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_ARUITask.<>f__mg$cacheD);
		if (Lua_BlackJack_ProjectL_UI_ARUITask.<>f__mg$cacheE == null)
		{
			Lua_BlackJack_ProjectL_UI_ARUITask.<>f__mg$cacheE = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ARUITask.__callBase_EnableUIInput);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_ARUITask.<>f__mg$cacheE);
		if (Lua_BlackJack_ProjectL_UI_ARUITask.<>f__mg$cacheF == null)
		{
			Lua_BlackJack_ProjectL_UI_ARUITask.<>f__mg$cacheF = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ARUITask.__callBase_IsNeedLoadDynamicRes);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_ARUITask.<>f__mg$cacheF);
		if (Lua_BlackJack_ProjectL_UI_ARUITask.<>f__mg$cache10 == null)
		{
			Lua_BlackJack_ProjectL_UI_ARUITask.<>f__mg$cache10 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ARUITask.__callBase_CollectAllDynamicResForLoad);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_ARUITask.<>f__mg$cache10);
		if (Lua_BlackJack_ProjectL_UI_ARUITask.<>f__mg$cache11 == null)
		{
			Lua_BlackJack_ProjectL_UI_ARUITask.<>f__mg$cache11 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ARUITask.__callBase_RegisterPlayerContextEvents);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_ARUITask.<>f__mg$cache11);
		if (Lua_BlackJack_ProjectL_UI_ARUITask.<>f__mg$cache12 == null)
		{
			Lua_BlackJack_ProjectL_UI_ARUITask.<>f__mg$cache12 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ARUITask.__callBase_UnregisterPlayerContextEvents);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_ARUITask.<>f__mg$cache12);
		if (Lua_BlackJack_ProjectL_UI_ARUITask.<>f__mg$cache13 == null)
		{
			Lua_BlackJack_ProjectL_UI_ARUITask.<>f__mg$cache13 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ARUITask.__callBase_PostUpdateView);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_ARUITask.<>f__mg$cache13);
		if (Lua_BlackJack_ProjectL_UI_ARUITask.<>f__mg$cache14 == null)
		{
			Lua_BlackJack_ProjectL_UI_ARUITask.<>f__mg$cache14 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ARUITask.__callBase_CollectPreloadResourceList);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_ARUITask.<>f__mg$cache14);
		if (Lua_BlackJack_ProjectL_UI_ARUITask.<>f__mg$cache15 == null)
		{
			Lua_BlackJack_ProjectL_UI_ARUITask.<>f__mg$cache15 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ARUITask.__callBase_ClearAssetList);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_ARUITask.<>f__mg$cache15);
		if (Lua_BlackJack_ProjectL_UI_ARUITask.<>f__mg$cache16 == null)
		{
			Lua_BlackJack_ProjectL_UI_ARUITask.<>f__mg$cache16 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ARUITask.__callBase_CollectAsset);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_ARUITask.<>f__mg$cache16);
		if (Lua_BlackJack_ProjectL_UI_ARUITask.<>f__mg$cache17 == null)
		{
			Lua_BlackJack_ProjectL_UI_ARUITask.<>f__mg$cache17 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ARUITask.__callBase_CollectSpriteAsset);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_ARUITask.<>f__mg$cache17);
		if (Lua_BlackJack_ProjectL_UI_ARUITask.<>f__mg$cache18 == null)
		{
			Lua_BlackJack_ProjectL_UI_ARUITask.<>f__mg$cache18 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ARUITask.__callBase_CollectFxAsset);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_ARUITask.<>f__mg$cache18);
		if (Lua_BlackJack_ProjectL_UI_ARUITask.<>f__mg$cache19 == null)
		{
			Lua_BlackJack_ProjectL_UI_ARUITask.<>f__mg$cache19 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ARUITask.__callBase_StartLoadCustomAssets);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_ARUITask.<>f__mg$cache19);
		if (Lua_BlackJack_ProjectL_UI_ARUITask.<>f__mg$cache1A == null)
		{
			Lua_BlackJack_ProjectL_UI_ARUITask.<>f__mg$cache1A = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ARUITask.__callBase_IsLoadingCustomAssets);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_ARUITask.<>f__mg$cache1A);
		if (Lua_BlackJack_ProjectL_UI_ARUITask.<>f__mg$cache1B == null)
		{
			Lua_BlackJack_ProjectL_UI_ARUITask.<>f__mg$cache1B = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ARUITask.__callBase_IsPipeLineRunning);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_ARUITask.<>f__mg$cache1B);
		if (Lua_BlackJack_ProjectL_UI_ARUITask.<>f__mg$cache1C == null)
		{
			Lua_BlackJack_ProjectL_UI_ARUITask.<>f__mg$cache1C = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ARUITask.__callBase_IsOpeningUI);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_ARUITask.<>f__mg$cache1C);
		if (Lua_BlackJack_ProjectL_UI_ARUITask.<>f__mg$cache1D == null)
		{
			Lua_BlackJack_ProjectL_UI_ARUITask.<>f__mg$cache1D = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ARUITask.__callBase_ReturnPrevUITask);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_ARUITask.<>f__mg$cache1D);
		if (Lua_BlackJack_ProjectL_UI_ARUITask.<>f__mg$cache1E == null)
		{
			Lua_BlackJack_ProjectL_UI_ARUITask.<>f__mg$cache1E = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ARUITask.__callBase_ClearUnusedDynamicResourceCache);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_ARUITask.<>f__mg$cache1E);
		if (Lua_BlackJack_ProjectL_UI_ARUITask.<>f__mg$cache1F == null)
		{
			Lua_BlackJack_ProjectL_UI_ARUITask.<>f__mg$cache1F = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ARUITask.__callBase_OnMemoryWarning);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_ARUITask.<>f__mg$cache1F);
		string name = "m_layerDescArray";
		if (Lua_BlackJack_ProjectL_UI_ARUITask.<>f__mg$cache20 == null)
		{
			Lua_BlackJack_ProjectL_UI_ARUITask.<>f__mg$cache20 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ARUITask.get_m_layerDescArray);
		}
		LuaCSFunction get = Lua_BlackJack_ProjectL_UI_ARUITask.<>f__mg$cache20;
		if (Lua_BlackJack_ProjectL_UI_ARUITask.<>f__mg$cache21 == null)
		{
			Lua_BlackJack_ProjectL_UI_ARUITask.<>f__mg$cache21 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ARUITask.set_m_layerDescArray);
		}
		LuaObject.addMember(l, name, get, Lua_BlackJack_ProjectL_UI_ARUITask.<>f__mg$cache21, true);
		string name2 = "m_uiCtrlDescArray";
		if (Lua_BlackJack_ProjectL_UI_ARUITask.<>f__mg$cache22 == null)
		{
			Lua_BlackJack_ProjectL_UI_ARUITask.<>f__mg$cache22 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ARUITask.get_m_uiCtrlDescArray);
		}
		LuaCSFunction get2 = Lua_BlackJack_ProjectL_UI_ARUITask.<>f__mg$cache22;
		if (Lua_BlackJack_ProjectL_UI_ARUITask.<>f__mg$cache23 == null)
		{
			Lua_BlackJack_ProjectL_UI_ARUITask.<>f__mg$cache23 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ARUITask.set_m_uiCtrlDescArray);
		}
		LuaObject.addMember(l, name2, get2, Lua_BlackJack_ProjectL_UI_ARUITask.<>f__mg$cache23, true);
		string name3 = "m_arShowUIController";
		if (Lua_BlackJack_ProjectL_UI_ARUITask.<>f__mg$cache24 == null)
		{
			Lua_BlackJack_ProjectL_UI_ARUITask.<>f__mg$cache24 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ARUITask.get_m_arShowUIController);
		}
		LuaCSFunction get3 = Lua_BlackJack_ProjectL_UI_ARUITask.<>f__mg$cache24;
		if (Lua_BlackJack_ProjectL_UI_ARUITask.<>f__mg$cache25 == null)
		{
			Lua_BlackJack_ProjectL_UI_ARUITask.<>f__mg$cache25 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ARUITask.set_m_arShowUIController);
		}
		LuaObject.addMember(l, name3, get3, Lua_BlackJack_ProjectL_UI_ARUITask.<>f__mg$cache25, true);
		string name4 = "m_arShowSceneController";
		if (Lua_BlackJack_ProjectL_UI_ARUITask.<>f__mg$cache26 == null)
		{
			Lua_BlackJack_ProjectL_UI_ARUITask.<>f__mg$cache26 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ARUITask.get_m_arShowSceneController);
		}
		LuaCSFunction get4 = Lua_BlackJack_ProjectL_UI_ARUITask.<>f__mg$cache26;
		if (Lua_BlackJack_ProjectL_UI_ARUITask.<>f__mg$cache27 == null)
		{
			Lua_BlackJack_ProjectL_UI_ARUITask.<>f__mg$cache27 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ARUITask.set_m_arShowSceneController);
		}
		LuaObject.addMember(l, name4, get4, Lua_BlackJack_ProjectL_UI_ARUITask.<>f__mg$cache27, true);
		string name5 = "LayerDescArray";
		if (Lua_BlackJack_ProjectL_UI_ARUITask.<>f__mg$cache28 == null)
		{
			Lua_BlackJack_ProjectL_UI_ARUITask.<>f__mg$cache28 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ARUITask.get_LayerDescArray);
		}
		LuaObject.addMember(l, name5, Lua_BlackJack_ProjectL_UI_ARUITask.<>f__mg$cache28, null, true);
		string name6 = "UICtrlDescArray";
		if (Lua_BlackJack_ProjectL_UI_ARUITask.<>f__mg$cache29 == null)
		{
			Lua_BlackJack_ProjectL_UI_ARUITask.<>f__mg$cache29 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ARUITask.get_UICtrlDescArray);
		}
		LuaObject.addMember(l, name6, Lua_BlackJack_ProjectL_UI_ARUITask.<>f__mg$cache29, null, true);
		if (Lua_BlackJack_ProjectL_UI_ARUITask.<>f__mg$cache2A == null)
		{
			Lua_BlackJack_ProjectL_UI_ARUITask.<>f__mg$cache2A = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ARUITask.constructor);
		}
		LuaObject.createTypeMetatable(l, Lua_BlackJack_ProjectL_UI_ARUITask.<>f__mg$cache2A, typeof(ARUITask), typeof(UITask));
	}

	// Token: 0x0401172A RID: 71466
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache0;

	// Token: 0x0401172B RID: 71467
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1;

	// Token: 0x0401172C RID: 71468
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2;

	// Token: 0x0401172D RID: 71469
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3;

	// Token: 0x0401172E RID: 71470
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache4;

	// Token: 0x0401172F RID: 71471
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache5;

	// Token: 0x04011730 RID: 71472
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache6;

	// Token: 0x04011731 RID: 71473
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache7;

	// Token: 0x04011732 RID: 71474
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache8;

	// Token: 0x04011733 RID: 71475
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache9;

	// Token: 0x04011734 RID: 71476
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheA;

	// Token: 0x04011735 RID: 71477
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheB;

	// Token: 0x04011736 RID: 71478
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheC;

	// Token: 0x04011737 RID: 71479
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheD;

	// Token: 0x04011738 RID: 71480
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheE;

	// Token: 0x04011739 RID: 71481
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheF;

	// Token: 0x0401173A RID: 71482
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache10;

	// Token: 0x0401173B RID: 71483
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache11;

	// Token: 0x0401173C RID: 71484
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache12;

	// Token: 0x0401173D RID: 71485
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache13;

	// Token: 0x0401173E RID: 71486
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache14;

	// Token: 0x0401173F RID: 71487
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache15;

	// Token: 0x04011740 RID: 71488
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache16;

	// Token: 0x04011741 RID: 71489
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache17;

	// Token: 0x04011742 RID: 71490
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache18;

	// Token: 0x04011743 RID: 71491
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache19;

	// Token: 0x04011744 RID: 71492
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1A;

	// Token: 0x04011745 RID: 71493
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1B;

	// Token: 0x04011746 RID: 71494
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1C;

	// Token: 0x04011747 RID: 71495
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1D;

	// Token: 0x04011748 RID: 71496
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1E;

	// Token: 0x04011749 RID: 71497
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1F;

	// Token: 0x0401174A RID: 71498
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache20;

	// Token: 0x0401174B RID: 71499
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache21;

	// Token: 0x0401174C RID: 71500
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache22;

	// Token: 0x0401174D RID: 71501
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache23;

	// Token: 0x0401174E RID: 71502
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache24;

	// Token: 0x0401174F RID: 71503
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache25;

	// Token: 0x04011750 RID: 71504
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache26;

	// Token: 0x04011751 RID: 71505
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache27;

	// Token: 0x04011752 RID: 71506
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache28;

	// Token: 0x04011753 RID: 71507
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache29;

	// Token: 0x04011754 RID: 71508
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2A;
}
