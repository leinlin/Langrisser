using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using BlackJack.BJFramework.Runtime.UI;
using BlackJack.ConfigData;
using BlackJack.ProjectL.UI;
using SLua;
using UnityEngine.Scripting;

// Token: 0x0200151F RID: 5407
[Preserve]
public class Lua_BlackJack_ProjectL_UI_OpenServiceActivityUITask : LuaObject
{
	// Token: 0x06020190 RID: 131472 RVA: 0x00AA307C File Offset: 0x00AA127C
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int constructor(IntPtr l)
	{
		int result;
		try
		{
			string name;
			LuaObject.checkType(l, 2, out name);
			OpenServiceActivityUITask o = new OpenServiceActivityUITask(name);
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

	// Token: 0x06020191 RID: 131473 RVA: 0x00AA30D0 File Offset: 0x00AA12D0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int IsNeedLoadDynamicRes(IntPtr l)
	{
		int result;
		try
		{
			OpenServiceActivityUITask openServiceActivityUITask = (OpenServiceActivityUITask)LuaObject.checkSelf(l);
			bool b = openServiceActivityUITask.m_luaExportHelper.IsNeedLoadDynamicRes();
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

	// Token: 0x06020192 RID: 131474 RVA: 0x00AA312C File Offset: 0x00AA132C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int InitAllUIControllers(IntPtr l)
	{
		int result;
		try
		{
			OpenServiceActivityUITask openServiceActivityUITask = (OpenServiceActivityUITask)LuaObject.checkSelf(l);
			openServiceActivityUITask.m_luaExportHelper.InitAllUIControllers();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06020193 RID: 131475 RVA: 0x00AA3180 File Offset: 0x00AA1380
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int ClearAllContextAndRes(IntPtr l)
	{
		int result;
		try
		{
			OpenServiceActivityUITask openServiceActivityUITask = (OpenServiceActivityUITask)LuaObject.checkSelf(l);
			openServiceActivityUITask.m_luaExportHelper.ClearAllContextAndRes();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06020194 RID: 131476 RVA: 0x00AA31D4 File Offset: 0x00AA13D4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int UpdateView(IntPtr l)
	{
		int result;
		try
		{
			OpenServiceActivityUITask openServiceActivityUITask = (OpenServiceActivityUITask)LuaObject.checkSelf(l);
			openServiceActivityUITask.m_luaExportHelper.UpdateView();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06020195 RID: 131477 RVA: 0x00AA3228 File Offset: 0x00AA1428
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int OpenServiceActivityUIController_OnReturn(IntPtr l)
	{
		int result;
		try
		{
			OpenServiceActivityUITask openServiceActivityUITask = (OpenServiceActivityUITask)LuaObject.checkSelf(l);
			openServiceActivityUITask.m_luaExportHelper.OpenServiceActivityUIController_OnReturn();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06020196 RID: 131478 RVA: 0x00AA327C File Offset: 0x00AA147C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int OpenServiceActivityUIController_OnMissionGoto(IntPtr l)
	{
		int result;
		try
		{
			OpenServiceActivityUITask openServiceActivityUITask = (OpenServiceActivityUITask)LuaObject.checkSelf(l);
			GetPathData getPathInfo;
			LuaObject.checkType<GetPathData>(l, 2, out getPathInfo);
			openServiceActivityUITask.m_luaExportHelper.OpenServiceActivityUIController_OnMissionGoto(getPathInfo);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06020197 RID: 131479 RVA: 0x00AA32D8 File Offset: 0x00AA14D8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int OpenServiceActivityUIController_OnMissionGet(IntPtr l)
	{
		int result;
		try
		{
			OpenServiceActivityUITask openServiceActivityUITask = (OpenServiceActivityUITask)LuaObject.checkSelf(l);
			OpenServiceMissonUIController ctrl;
			LuaObject.checkType<OpenServiceMissonUIController>(l, 2, out ctrl);
			openServiceActivityUITask.m_luaExportHelper.OpenServiceActivityUIController_OnMissionGet(ctrl);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06020198 RID: 131480 RVA: 0x00AA3334 File Offset: 0x00AA1534
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int OpenServiceActivityUIController_OnIntegralGoodsClick(IntPtr l)
	{
		int result;
		try
		{
			OpenServiceActivityUITask openServiceActivityUITask = (OpenServiceActivityUITask)LuaObject.checkSelf(l);
			IntegralGoodsUIController ctrl;
			LuaObject.checkType<IntegralGoodsUIController>(l, 2, out ctrl);
			openServiceActivityUITask.m_luaExportHelper.OpenServiceActivityUIController_OnIntegralGoodsClick(ctrl);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06020199 RID: 131481 RVA: 0x00AA3390 File Offset: 0x00AA1590
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int OnTick(IntPtr l)
	{
		int result;
		try
		{
			OpenServiceActivityUITask openServiceActivityUITask = (OpenServiceActivityUITask)LuaObject.checkSelf(l);
			openServiceActivityUITask.m_luaExportHelper.OnTick();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0602019A RID: 131482 RVA: 0x00AA33E4 File Offset: 0x00AA15E4
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int UpdateTimeText(IntPtr l)
	{
		int result;
		try
		{
			OpenServiceActivityUITask openServiceActivityUITask = (OpenServiceActivityUITask)LuaObject.checkSelf(l);
			openServiceActivityUITask.m_luaExportHelper.UpdateTimeText();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0602019B RID: 131483 RVA: 0x00AA3438 File Offset: 0x00AA1638
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_OnStart(IntPtr l)
	{
		int result;
		try
		{
			OpenServiceActivityUITask openServiceActivityUITask = (OpenServiceActivityUITask)LuaObject.checkSelf(l);
			UIIntent intent;
			LuaObject.checkType<UIIntent>(l, 2, out intent);
			bool b = openServiceActivityUITask.m_luaExportHelper.__callBase_OnStart(intent);
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

	// Token: 0x0602019C RID: 131484 RVA: 0x00AA34A0 File Offset: 0x00AA16A0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_OnStop(IntPtr l)
	{
		int result;
		try
		{
			OpenServiceActivityUITask openServiceActivityUITask = (OpenServiceActivityUITask)LuaObject.checkSelf(l);
			openServiceActivityUITask.m_luaExportHelper.__callBase_OnStop();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0602019D RID: 131485 RVA: 0x00AA34F4 File Offset: 0x00AA16F4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_OnPause(IntPtr l)
	{
		int result;
		try
		{
			OpenServiceActivityUITask openServiceActivityUITask = (OpenServiceActivityUITask)LuaObject.checkSelf(l);
			openServiceActivityUITask.m_luaExportHelper.__callBase_OnPause();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0602019E RID: 131486 RVA: 0x00AA3548 File Offset: 0x00AA1748
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_OnResume(IntPtr l)
	{
		int result;
		try
		{
			OpenServiceActivityUITask openServiceActivityUITask = (OpenServiceActivityUITask)LuaObject.checkSelf(l);
			UIIntent intent;
			LuaObject.checkType<UIIntent>(l, 2, out intent);
			bool b = openServiceActivityUITask.m_luaExportHelper.__callBase_OnResume(intent);
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

	// Token: 0x0602019F RID: 131487 RVA: 0x00AA35B0 File Offset: 0x00AA17B0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_OnNewIntent(IntPtr l)
	{
		int result;
		try
		{
			OpenServiceActivityUITask openServiceActivityUITask = (OpenServiceActivityUITask)LuaObject.checkSelf(l);
			UIIntent intent;
			LuaObject.checkType<UIIntent>(l, 2, out intent);
			bool b = openServiceActivityUITask.m_luaExportHelper.__callBase_OnNewIntent(intent);
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

	// Token: 0x060201A0 RID: 131488 RVA: 0x00AA3618 File Offset: 0x00AA1818
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_EnableUIInput(IntPtr l)
	{
		int result;
		try
		{
			OpenServiceActivityUITask openServiceActivityUITask = (OpenServiceActivityUITask)LuaObject.checkSelf(l);
			bool isEnable;
			LuaObject.checkType(l, 2, out isEnable);
			bool? isGlobalEnable;
			LuaObject.checkNullable<bool>(l, 3, out isGlobalEnable);
			openServiceActivityUITask.m_luaExportHelper.__callBase_EnableUIInput(isEnable, isGlobalEnable);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060201A1 RID: 131489 RVA: 0x00AA3684 File Offset: 0x00AA1884
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_IsNeedLoadDynamicRes(IntPtr l)
	{
		int result;
		try
		{
			OpenServiceActivityUITask openServiceActivityUITask = (OpenServiceActivityUITask)LuaObject.checkSelf(l);
			bool b = openServiceActivityUITask.m_luaExportHelper.__callBase_IsNeedLoadDynamicRes();
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

	// Token: 0x060201A2 RID: 131490 RVA: 0x00AA36E0 File Offset: 0x00AA18E0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_CollectAllDynamicResForLoad(IntPtr l)
	{
		int result;
		try
		{
			OpenServiceActivityUITask openServiceActivityUITask = (OpenServiceActivityUITask)LuaObject.checkSelf(l);
			List<string> o = openServiceActivityUITask.m_luaExportHelper.__callBase_CollectAllDynamicResForLoad();
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

	// Token: 0x060201A3 RID: 131491 RVA: 0x00AA373C File Offset: 0x00AA193C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_RegisterPlayerContextEvents(IntPtr l)
	{
		int result;
		try
		{
			OpenServiceActivityUITask openServiceActivityUITask = (OpenServiceActivityUITask)LuaObject.checkSelf(l);
			openServiceActivityUITask.m_luaExportHelper.__callBase_RegisterPlayerContextEvents();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060201A4 RID: 131492 RVA: 0x00AA3790 File Offset: 0x00AA1990
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_UnregisterPlayerContextEvents(IntPtr l)
	{
		int result;
		try
		{
			OpenServiceActivityUITask openServiceActivityUITask = (OpenServiceActivityUITask)LuaObject.checkSelf(l);
			openServiceActivityUITask.m_luaExportHelper.__callBase_UnregisterPlayerContextEvents();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060201A5 RID: 131493 RVA: 0x00AA37E4 File Offset: 0x00AA19E4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_PostUpdateView(IntPtr l)
	{
		int result;
		try
		{
			OpenServiceActivityUITask openServiceActivityUITask = (OpenServiceActivityUITask)LuaObject.checkSelf(l);
			openServiceActivityUITask.m_luaExportHelper.__callBase_PostUpdateView();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060201A6 RID: 131494 RVA: 0x00AA3838 File Offset: 0x00AA1A38
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_CollectPreloadResourceList(IntPtr l)
	{
		int result;
		try
		{
			OpenServiceActivityUITask openServiceActivityUITask = (OpenServiceActivityUITask)LuaObject.checkSelf(l);
			openServiceActivityUITask.m_luaExportHelper.__callBase_CollectPreloadResourceList();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060201A7 RID: 131495 RVA: 0x00AA388C File Offset: 0x00AA1A8C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_ClearAssetList(IntPtr l)
	{
		int result;
		try
		{
			OpenServiceActivityUITask openServiceActivityUITask = (OpenServiceActivityUITask)LuaObject.checkSelf(l);
			openServiceActivityUITask.m_luaExportHelper.__callBase_ClearAssetList();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060201A8 RID: 131496 RVA: 0x00AA38E0 File Offset: 0x00AA1AE0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_CollectAsset(IntPtr l)
	{
		int result;
		try
		{
			OpenServiceActivityUITask openServiceActivityUITask = (OpenServiceActivityUITask)LuaObject.checkSelf(l);
			string assetName;
			LuaObject.checkType(l, 2, out assetName);
			openServiceActivityUITask.m_luaExportHelper.__callBase_CollectAsset(assetName);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060201A9 RID: 131497 RVA: 0x00AA393C File Offset: 0x00AA1B3C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_CollectSpriteAsset(IntPtr l)
	{
		int result;
		try
		{
			OpenServiceActivityUITask openServiceActivityUITask = (OpenServiceActivityUITask)LuaObject.checkSelf(l);
			string assetName;
			LuaObject.checkType(l, 2, out assetName);
			openServiceActivityUITask.m_luaExportHelper.__callBase_CollectSpriteAsset(assetName);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060201AA RID: 131498 RVA: 0x00AA3998 File Offset: 0x00AA1B98
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_CollectFxAsset(IntPtr l)
	{
		int result;
		try
		{
			OpenServiceActivityUITask openServiceActivityUITask = (OpenServiceActivityUITask)LuaObject.checkSelf(l);
			string assetName;
			LuaObject.checkType(l, 2, out assetName);
			openServiceActivityUITask.m_luaExportHelper.__callBase_CollectFxAsset(assetName);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060201AB RID: 131499 RVA: 0x00AA39F4 File Offset: 0x00AA1BF4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_StartLoadCustomAssets(IntPtr l)
	{
		int result;
		try
		{
			OpenServiceActivityUITask openServiceActivityUITask = (OpenServiceActivityUITask)LuaObject.checkSelf(l);
			Action onLoadCompleted;
			LuaObject.checkDelegate<Action>(l, 2, out onLoadCompleted);
			openServiceActivityUITask.m_luaExportHelper.__callBase_StartLoadCustomAssets(onLoadCompleted);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060201AC RID: 131500 RVA: 0x00AA3A50 File Offset: 0x00AA1C50
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_IsLoadingCustomAssets(IntPtr l)
	{
		int result;
		try
		{
			OpenServiceActivityUITask openServiceActivityUITask = (OpenServiceActivityUITask)LuaObject.checkSelf(l);
			bool b = openServiceActivityUITask.m_luaExportHelper.__callBase_IsLoadingCustomAssets();
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

	// Token: 0x060201AD RID: 131501 RVA: 0x00AA3AAC File Offset: 0x00AA1CAC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_IsPipeLineRunning(IntPtr l)
	{
		int result;
		try
		{
			OpenServiceActivityUITask openServiceActivityUITask = (OpenServiceActivityUITask)LuaObject.checkSelf(l);
			bool b = openServiceActivityUITask.m_luaExportHelper.__callBase_IsPipeLineRunning();
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

	// Token: 0x060201AE RID: 131502 RVA: 0x00AA3B08 File Offset: 0x00AA1D08
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_IsOpeningUI(IntPtr l)
	{
		int result;
		try
		{
			OpenServiceActivityUITask openServiceActivityUITask = (OpenServiceActivityUITask)LuaObject.checkSelf(l);
			bool b = openServiceActivityUITask.m_luaExportHelper.__callBase_IsOpeningUI();
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

	// Token: 0x060201AF RID: 131503 RVA: 0x00AA3B64 File Offset: 0x00AA1D64
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_ReturnPrevUITask(IntPtr l)
	{
		int result;
		try
		{
			OpenServiceActivityUITask openServiceActivityUITask = (OpenServiceActivityUITask)LuaObject.checkSelf(l);
			UITaskBase o = openServiceActivityUITask.m_luaExportHelper.__callBase_ReturnPrevUITask();
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

	// Token: 0x060201B0 RID: 131504 RVA: 0x00AA3BC0 File Offset: 0x00AA1DC0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_ClearUnusedDynamicResourceCache(IntPtr l)
	{
		int result;
		try
		{
			OpenServiceActivityUITask openServiceActivityUITask = (OpenServiceActivityUITask)LuaObject.checkSelf(l);
			openServiceActivityUITask.m_luaExportHelper.__callBase_ClearUnusedDynamicResourceCache();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060201B1 RID: 131505 RVA: 0x00AA3C14 File Offset: 0x00AA1E14
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_OnMemoryWarning(IntPtr l)
	{
		int result;
		try
		{
			OpenServiceActivityUITask openServiceActivityUITask = (OpenServiceActivityUITask)LuaObject.checkSelf(l);
			openServiceActivityUITask.m_luaExportHelper.__callBase_OnMemoryWarning();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060201B2 RID: 131506 RVA: 0x00AA3C68 File Offset: 0x00AA1E68
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_layerDescArray(IntPtr l)
	{
		int result;
		try
		{
			OpenServiceActivityUITask openServiceActivityUITask = (OpenServiceActivityUITask)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, openServiceActivityUITask.m_luaExportHelper.m_layerDescArray);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060201B3 RID: 131507 RVA: 0x00AA3CC0 File Offset: 0x00AA1EC0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_layerDescArray(IntPtr l)
	{
		int result;
		try
		{
			OpenServiceActivityUITask openServiceActivityUITask = (OpenServiceActivityUITask)LuaObject.checkSelf(l);
			UITaskBase.LayerDesc[] layerDescArray;
			LuaObject.checkArray<UITaskBase.LayerDesc>(l, 2, out layerDescArray);
			openServiceActivityUITask.m_luaExportHelper.m_layerDescArray = layerDescArray;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060201B4 RID: 131508 RVA: 0x00AA3D1C File Offset: 0x00AA1F1C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_uiCtrlDescArray(IntPtr l)
	{
		int result;
		try
		{
			OpenServiceActivityUITask openServiceActivityUITask = (OpenServiceActivityUITask)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, openServiceActivityUITask.m_luaExportHelper.m_uiCtrlDescArray);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060201B5 RID: 131509 RVA: 0x00AA3D74 File Offset: 0x00AA1F74
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_uiCtrlDescArray(IntPtr l)
	{
		int result;
		try
		{
			OpenServiceActivityUITask openServiceActivityUITask = (OpenServiceActivityUITask)LuaObject.checkSelf(l);
			UITaskBase.UIControllerDesc[] uiCtrlDescArray;
			LuaObject.checkArray<UITaskBase.UIControllerDesc>(l, 2, out uiCtrlDescArray);
			openServiceActivityUITask.m_luaExportHelper.m_uiCtrlDescArray = uiCtrlDescArray;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060201B6 RID: 131510 RVA: 0x00AA3DD0 File Offset: 0x00AA1FD0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_openServiceActivityUIController(IntPtr l)
	{
		int result;
		try
		{
			OpenServiceActivityUITask openServiceActivityUITask = (OpenServiceActivityUITask)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, openServiceActivityUITask.m_luaExportHelper.m_openServiceActivityUIController);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060201B7 RID: 131511 RVA: 0x00AA3E28 File Offset: 0x00AA2028
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_m_openServiceActivityUIController(IntPtr l)
	{
		int result;
		try
		{
			OpenServiceActivityUITask openServiceActivityUITask = (OpenServiceActivityUITask)LuaObject.checkSelf(l);
			OpenServiceActivityUIController openServiceActivityUIController;
			LuaObject.checkType<OpenServiceActivityUIController>(l, 2, out openServiceActivityUIController);
			openServiceActivityUITask.m_luaExportHelper.m_openServiceActivityUIController = openServiceActivityUIController;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060201B8 RID: 131512 RVA: 0x00AA3E84 File Offset: 0x00AA2084
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_nowSeconds(IntPtr l)
	{
		int result;
		try
		{
			OpenServiceActivityUITask openServiceActivityUITask = (OpenServiceActivityUITask)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, openServiceActivityUITask.m_luaExportHelper.m_nowSeconds);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060201B9 RID: 131513 RVA: 0x00AA3EDC File Offset: 0x00AA20DC
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_m_nowSeconds(IntPtr l)
	{
		int result;
		try
		{
			OpenServiceActivityUITask openServiceActivityUITask = (OpenServiceActivityUITask)LuaObject.checkSelf(l);
			int nowSeconds;
			LuaObject.checkType(l, 2, out nowSeconds);
			openServiceActivityUITask.m_luaExportHelper.m_nowSeconds = nowSeconds;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060201BA RID: 131514 RVA: 0x00AA3F38 File Offset: 0x00AA2138
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_LayerDescArray(IntPtr l)
	{
		int result;
		try
		{
			OpenServiceActivityUITask openServiceActivityUITask = (OpenServiceActivityUITask)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, openServiceActivityUITask.m_luaExportHelper.LayerDescArray);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060201BB RID: 131515 RVA: 0x00AA3F90 File Offset: 0x00AA2190
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_UICtrlDescArray(IntPtr l)
	{
		int result;
		try
		{
			OpenServiceActivityUITask openServiceActivityUITask = (OpenServiceActivityUITask)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, openServiceActivityUITask.m_luaExportHelper.UICtrlDescArray);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060201BC RID: 131516 RVA: 0x00AA3FE8 File Offset: 0x00AA21E8
	[Preserve]
	public static void reg(IntPtr l)
	{
		LuaObject.getTypeTable(l, "BlackJack.ProjectL.UI.OpenServiceActivityUITask");
		if (Lua_BlackJack_ProjectL_UI_OpenServiceActivityUITask.<>f__mg$cache0 == null)
		{
			Lua_BlackJack_ProjectL_UI_OpenServiceActivityUITask.<>f__mg$cache0 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_OpenServiceActivityUITask.IsNeedLoadDynamicRes);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_OpenServiceActivityUITask.<>f__mg$cache0);
		if (Lua_BlackJack_ProjectL_UI_OpenServiceActivityUITask.<>f__mg$cache1 == null)
		{
			Lua_BlackJack_ProjectL_UI_OpenServiceActivityUITask.<>f__mg$cache1 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_OpenServiceActivityUITask.InitAllUIControllers);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_OpenServiceActivityUITask.<>f__mg$cache1);
		if (Lua_BlackJack_ProjectL_UI_OpenServiceActivityUITask.<>f__mg$cache2 == null)
		{
			Lua_BlackJack_ProjectL_UI_OpenServiceActivityUITask.<>f__mg$cache2 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_OpenServiceActivityUITask.ClearAllContextAndRes);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_OpenServiceActivityUITask.<>f__mg$cache2);
		if (Lua_BlackJack_ProjectL_UI_OpenServiceActivityUITask.<>f__mg$cache3 == null)
		{
			Lua_BlackJack_ProjectL_UI_OpenServiceActivityUITask.<>f__mg$cache3 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_OpenServiceActivityUITask.UpdateView);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_OpenServiceActivityUITask.<>f__mg$cache3);
		if (Lua_BlackJack_ProjectL_UI_OpenServiceActivityUITask.<>f__mg$cache4 == null)
		{
			Lua_BlackJack_ProjectL_UI_OpenServiceActivityUITask.<>f__mg$cache4 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_OpenServiceActivityUITask.OpenServiceActivityUIController_OnReturn);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_OpenServiceActivityUITask.<>f__mg$cache4);
		if (Lua_BlackJack_ProjectL_UI_OpenServiceActivityUITask.<>f__mg$cache5 == null)
		{
			Lua_BlackJack_ProjectL_UI_OpenServiceActivityUITask.<>f__mg$cache5 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_OpenServiceActivityUITask.OpenServiceActivityUIController_OnMissionGoto);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_OpenServiceActivityUITask.<>f__mg$cache5);
		if (Lua_BlackJack_ProjectL_UI_OpenServiceActivityUITask.<>f__mg$cache6 == null)
		{
			Lua_BlackJack_ProjectL_UI_OpenServiceActivityUITask.<>f__mg$cache6 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_OpenServiceActivityUITask.OpenServiceActivityUIController_OnMissionGet);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_OpenServiceActivityUITask.<>f__mg$cache6);
		if (Lua_BlackJack_ProjectL_UI_OpenServiceActivityUITask.<>f__mg$cache7 == null)
		{
			Lua_BlackJack_ProjectL_UI_OpenServiceActivityUITask.<>f__mg$cache7 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_OpenServiceActivityUITask.OpenServiceActivityUIController_OnIntegralGoodsClick);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_OpenServiceActivityUITask.<>f__mg$cache7);
		if (Lua_BlackJack_ProjectL_UI_OpenServiceActivityUITask.<>f__mg$cache8 == null)
		{
			Lua_BlackJack_ProjectL_UI_OpenServiceActivityUITask.<>f__mg$cache8 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_OpenServiceActivityUITask.OnTick);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_OpenServiceActivityUITask.<>f__mg$cache8);
		if (Lua_BlackJack_ProjectL_UI_OpenServiceActivityUITask.<>f__mg$cache9 == null)
		{
			Lua_BlackJack_ProjectL_UI_OpenServiceActivityUITask.<>f__mg$cache9 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_OpenServiceActivityUITask.UpdateTimeText);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_OpenServiceActivityUITask.<>f__mg$cache9);
		if (Lua_BlackJack_ProjectL_UI_OpenServiceActivityUITask.<>f__mg$cacheA == null)
		{
			Lua_BlackJack_ProjectL_UI_OpenServiceActivityUITask.<>f__mg$cacheA = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_OpenServiceActivityUITask.__callBase_OnStart);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_OpenServiceActivityUITask.<>f__mg$cacheA);
		if (Lua_BlackJack_ProjectL_UI_OpenServiceActivityUITask.<>f__mg$cacheB == null)
		{
			Lua_BlackJack_ProjectL_UI_OpenServiceActivityUITask.<>f__mg$cacheB = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_OpenServiceActivityUITask.__callBase_OnStop);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_OpenServiceActivityUITask.<>f__mg$cacheB);
		if (Lua_BlackJack_ProjectL_UI_OpenServiceActivityUITask.<>f__mg$cacheC == null)
		{
			Lua_BlackJack_ProjectL_UI_OpenServiceActivityUITask.<>f__mg$cacheC = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_OpenServiceActivityUITask.__callBase_OnPause);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_OpenServiceActivityUITask.<>f__mg$cacheC);
		if (Lua_BlackJack_ProjectL_UI_OpenServiceActivityUITask.<>f__mg$cacheD == null)
		{
			Lua_BlackJack_ProjectL_UI_OpenServiceActivityUITask.<>f__mg$cacheD = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_OpenServiceActivityUITask.__callBase_OnResume);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_OpenServiceActivityUITask.<>f__mg$cacheD);
		if (Lua_BlackJack_ProjectL_UI_OpenServiceActivityUITask.<>f__mg$cacheE == null)
		{
			Lua_BlackJack_ProjectL_UI_OpenServiceActivityUITask.<>f__mg$cacheE = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_OpenServiceActivityUITask.__callBase_OnNewIntent);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_OpenServiceActivityUITask.<>f__mg$cacheE);
		if (Lua_BlackJack_ProjectL_UI_OpenServiceActivityUITask.<>f__mg$cacheF == null)
		{
			Lua_BlackJack_ProjectL_UI_OpenServiceActivityUITask.<>f__mg$cacheF = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_OpenServiceActivityUITask.__callBase_EnableUIInput);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_OpenServiceActivityUITask.<>f__mg$cacheF);
		if (Lua_BlackJack_ProjectL_UI_OpenServiceActivityUITask.<>f__mg$cache10 == null)
		{
			Lua_BlackJack_ProjectL_UI_OpenServiceActivityUITask.<>f__mg$cache10 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_OpenServiceActivityUITask.__callBase_IsNeedLoadDynamicRes);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_OpenServiceActivityUITask.<>f__mg$cache10);
		if (Lua_BlackJack_ProjectL_UI_OpenServiceActivityUITask.<>f__mg$cache11 == null)
		{
			Lua_BlackJack_ProjectL_UI_OpenServiceActivityUITask.<>f__mg$cache11 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_OpenServiceActivityUITask.__callBase_CollectAllDynamicResForLoad);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_OpenServiceActivityUITask.<>f__mg$cache11);
		if (Lua_BlackJack_ProjectL_UI_OpenServiceActivityUITask.<>f__mg$cache12 == null)
		{
			Lua_BlackJack_ProjectL_UI_OpenServiceActivityUITask.<>f__mg$cache12 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_OpenServiceActivityUITask.__callBase_RegisterPlayerContextEvents);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_OpenServiceActivityUITask.<>f__mg$cache12);
		if (Lua_BlackJack_ProjectL_UI_OpenServiceActivityUITask.<>f__mg$cache13 == null)
		{
			Lua_BlackJack_ProjectL_UI_OpenServiceActivityUITask.<>f__mg$cache13 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_OpenServiceActivityUITask.__callBase_UnregisterPlayerContextEvents);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_OpenServiceActivityUITask.<>f__mg$cache13);
		if (Lua_BlackJack_ProjectL_UI_OpenServiceActivityUITask.<>f__mg$cache14 == null)
		{
			Lua_BlackJack_ProjectL_UI_OpenServiceActivityUITask.<>f__mg$cache14 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_OpenServiceActivityUITask.__callBase_PostUpdateView);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_OpenServiceActivityUITask.<>f__mg$cache14);
		if (Lua_BlackJack_ProjectL_UI_OpenServiceActivityUITask.<>f__mg$cache15 == null)
		{
			Lua_BlackJack_ProjectL_UI_OpenServiceActivityUITask.<>f__mg$cache15 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_OpenServiceActivityUITask.__callBase_CollectPreloadResourceList);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_OpenServiceActivityUITask.<>f__mg$cache15);
		if (Lua_BlackJack_ProjectL_UI_OpenServiceActivityUITask.<>f__mg$cache16 == null)
		{
			Lua_BlackJack_ProjectL_UI_OpenServiceActivityUITask.<>f__mg$cache16 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_OpenServiceActivityUITask.__callBase_ClearAssetList);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_OpenServiceActivityUITask.<>f__mg$cache16);
		if (Lua_BlackJack_ProjectL_UI_OpenServiceActivityUITask.<>f__mg$cache17 == null)
		{
			Lua_BlackJack_ProjectL_UI_OpenServiceActivityUITask.<>f__mg$cache17 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_OpenServiceActivityUITask.__callBase_CollectAsset);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_OpenServiceActivityUITask.<>f__mg$cache17);
		if (Lua_BlackJack_ProjectL_UI_OpenServiceActivityUITask.<>f__mg$cache18 == null)
		{
			Lua_BlackJack_ProjectL_UI_OpenServiceActivityUITask.<>f__mg$cache18 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_OpenServiceActivityUITask.__callBase_CollectSpriteAsset);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_OpenServiceActivityUITask.<>f__mg$cache18);
		if (Lua_BlackJack_ProjectL_UI_OpenServiceActivityUITask.<>f__mg$cache19 == null)
		{
			Lua_BlackJack_ProjectL_UI_OpenServiceActivityUITask.<>f__mg$cache19 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_OpenServiceActivityUITask.__callBase_CollectFxAsset);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_OpenServiceActivityUITask.<>f__mg$cache19);
		if (Lua_BlackJack_ProjectL_UI_OpenServiceActivityUITask.<>f__mg$cache1A == null)
		{
			Lua_BlackJack_ProjectL_UI_OpenServiceActivityUITask.<>f__mg$cache1A = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_OpenServiceActivityUITask.__callBase_StartLoadCustomAssets);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_OpenServiceActivityUITask.<>f__mg$cache1A);
		if (Lua_BlackJack_ProjectL_UI_OpenServiceActivityUITask.<>f__mg$cache1B == null)
		{
			Lua_BlackJack_ProjectL_UI_OpenServiceActivityUITask.<>f__mg$cache1B = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_OpenServiceActivityUITask.__callBase_IsLoadingCustomAssets);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_OpenServiceActivityUITask.<>f__mg$cache1B);
		if (Lua_BlackJack_ProjectL_UI_OpenServiceActivityUITask.<>f__mg$cache1C == null)
		{
			Lua_BlackJack_ProjectL_UI_OpenServiceActivityUITask.<>f__mg$cache1C = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_OpenServiceActivityUITask.__callBase_IsPipeLineRunning);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_OpenServiceActivityUITask.<>f__mg$cache1C);
		if (Lua_BlackJack_ProjectL_UI_OpenServiceActivityUITask.<>f__mg$cache1D == null)
		{
			Lua_BlackJack_ProjectL_UI_OpenServiceActivityUITask.<>f__mg$cache1D = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_OpenServiceActivityUITask.__callBase_IsOpeningUI);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_OpenServiceActivityUITask.<>f__mg$cache1D);
		if (Lua_BlackJack_ProjectL_UI_OpenServiceActivityUITask.<>f__mg$cache1E == null)
		{
			Lua_BlackJack_ProjectL_UI_OpenServiceActivityUITask.<>f__mg$cache1E = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_OpenServiceActivityUITask.__callBase_ReturnPrevUITask);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_OpenServiceActivityUITask.<>f__mg$cache1E);
		if (Lua_BlackJack_ProjectL_UI_OpenServiceActivityUITask.<>f__mg$cache1F == null)
		{
			Lua_BlackJack_ProjectL_UI_OpenServiceActivityUITask.<>f__mg$cache1F = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_OpenServiceActivityUITask.__callBase_ClearUnusedDynamicResourceCache);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_OpenServiceActivityUITask.<>f__mg$cache1F);
		if (Lua_BlackJack_ProjectL_UI_OpenServiceActivityUITask.<>f__mg$cache20 == null)
		{
			Lua_BlackJack_ProjectL_UI_OpenServiceActivityUITask.<>f__mg$cache20 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_OpenServiceActivityUITask.__callBase_OnMemoryWarning);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_OpenServiceActivityUITask.<>f__mg$cache20);
		string name = "m_layerDescArray";
		if (Lua_BlackJack_ProjectL_UI_OpenServiceActivityUITask.<>f__mg$cache21 == null)
		{
			Lua_BlackJack_ProjectL_UI_OpenServiceActivityUITask.<>f__mg$cache21 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_OpenServiceActivityUITask.get_m_layerDescArray);
		}
		LuaCSFunction get = Lua_BlackJack_ProjectL_UI_OpenServiceActivityUITask.<>f__mg$cache21;
		if (Lua_BlackJack_ProjectL_UI_OpenServiceActivityUITask.<>f__mg$cache22 == null)
		{
			Lua_BlackJack_ProjectL_UI_OpenServiceActivityUITask.<>f__mg$cache22 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_OpenServiceActivityUITask.set_m_layerDescArray);
		}
		LuaObject.addMember(l, name, get, Lua_BlackJack_ProjectL_UI_OpenServiceActivityUITask.<>f__mg$cache22, true);
		string name2 = "m_uiCtrlDescArray";
		if (Lua_BlackJack_ProjectL_UI_OpenServiceActivityUITask.<>f__mg$cache23 == null)
		{
			Lua_BlackJack_ProjectL_UI_OpenServiceActivityUITask.<>f__mg$cache23 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_OpenServiceActivityUITask.get_m_uiCtrlDescArray);
		}
		LuaCSFunction get2 = Lua_BlackJack_ProjectL_UI_OpenServiceActivityUITask.<>f__mg$cache23;
		if (Lua_BlackJack_ProjectL_UI_OpenServiceActivityUITask.<>f__mg$cache24 == null)
		{
			Lua_BlackJack_ProjectL_UI_OpenServiceActivityUITask.<>f__mg$cache24 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_OpenServiceActivityUITask.set_m_uiCtrlDescArray);
		}
		LuaObject.addMember(l, name2, get2, Lua_BlackJack_ProjectL_UI_OpenServiceActivityUITask.<>f__mg$cache24, true);
		string name3 = "m_openServiceActivityUIController";
		if (Lua_BlackJack_ProjectL_UI_OpenServiceActivityUITask.<>f__mg$cache25 == null)
		{
			Lua_BlackJack_ProjectL_UI_OpenServiceActivityUITask.<>f__mg$cache25 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_OpenServiceActivityUITask.get_m_openServiceActivityUIController);
		}
		LuaCSFunction get3 = Lua_BlackJack_ProjectL_UI_OpenServiceActivityUITask.<>f__mg$cache25;
		if (Lua_BlackJack_ProjectL_UI_OpenServiceActivityUITask.<>f__mg$cache26 == null)
		{
			Lua_BlackJack_ProjectL_UI_OpenServiceActivityUITask.<>f__mg$cache26 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_OpenServiceActivityUITask.set_m_openServiceActivityUIController);
		}
		LuaObject.addMember(l, name3, get3, Lua_BlackJack_ProjectL_UI_OpenServiceActivityUITask.<>f__mg$cache26, true);
		string name4 = "m_nowSeconds";
		if (Lua_BlackJack_ProjectL_UI_OpenServiceActivityUITask.<>f__mg$cache27 == null)
		{
			Lua_BlackJack_ProjectL_UI_OpenServiceActivityUITask.<>f__mg$cache27 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_OpenServiceActivityUITask.get_m_nowSeconds);
		}
		LuaCSFunction get4 = Lua_BlackJack_ProjectL_UI_OpenServiceActivityUITask.<>f__mg$cache27;
		if (Lua_BlackJack_ProjectL_UI_OpenServiceActivityUITask.<>f__mg$cache28 == null)
		{
			Lua_BlackJack_ProjectL_UI_OpenServiceActivityUITask.<>f__mg$cache28 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_OpenServiceActivityUITask.set_m_nowSeconds);
		}
		LuaObject.addMember(l, name4, get4, Lua_BlackJack_ProjectL_UI_OpenServiceActivityUITask.<>f__mg$cache28, true);
		string name5 = "LayerDescArray";
		if (Lua_BlackJack_ProjectL_UI_OpenServiceActivityUITask.<>f__mg$cache29 == null)
		{
			Lua_BlackJack_ProjectL_UI_OpenServiceActivityUITask.<>f__mg$cache29 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_OpenServiceActivityUITask.get_LayerDescArray);
		}
		LuaObject.addMember(l, name5, Lua_BlackJack_ProjectL_UI_OpenServiceActivityUITask.<>f__mg$cache29, null, true);
		string name6 = "UICtrlDescArray";
		if (Lua_BlackJack_ProjectL_UI_OpenServiceActivityUITask.<>f__mg$cache2A == null)
		{
			Lua_BlackJack_ProjectL_UI_OpenServiceActivityUITask.<>f__mg$cache2A = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_OpenServiceActivityUITask.get_UICtrlDescArray);
		}
		LuaObject.addMember(l, name6, Lua_BlackJack_ProjectL_UI_OpenServiceActivityUITask.<>f__mg$cache2A, null, true);
		if (Lua_BlackJack_ProjectL_UI_OpenServiceActivityUITask.<>f__mg$cache2B == null)
		{
			Lua_BlackJack_ProjectL_UI_OpenServiceActivityUITask.<>f__mg$cache2B = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_OpenServiceActivityUITask.constructor);
		}
		LuaObject.createTypeMetatable(l, Lua_BlackJack_ProjectL_UI_OpenServiceActivityUITask.<>f__mg$cache2B, typeof(OpenServiceActivityUITask), typeof(UITask));
	}

	// Token: 0x04016134 RID: 90420
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache0;

	// Token: 0x04016135 RID: 90421
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1;

	// Token: 0x04016136 RID: 90422
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2;

	// Token: 0x04016137 RID: 90423
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3;

	// Token: 0x04016138 RID: 90424
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache4;

	// Token: 0x04016139 RID: 90425
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache5;

	// Token: 0x0401613A RID: 90426
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache6;

	// Token: 0x0401613B RID: 90427
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache7;

	// Token: 0x0401613C RID: 90428
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache8;

	// Token: 0x0401613D RID: 90429
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache9;

	// Token: 0x0401613E RID: 90430
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheA;

	// Token: 0x0401613F RID: 90431
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheB;

	// Token: 0x04016140 RID: 90432
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheC;

	// Token: 0x04016141 RID: 90433
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheD;

	// Token: 0x04016142 RID: 90434
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheE;

	// Token: 0x04016143 RID: 90435
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheF;

	// Token: 0x04016144 RID: 90436
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache10;

	// Token: 0x04016145 RID: 90437
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache11;

	// Token: 0x04016146 RID: 90438
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache12;

	// Token: 0x04016147 RID: 90439
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache13;

	// Token: 0x04016148 RID: 90440
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache14;

	// Token: 0x04016149 RID: 90441
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache15;

	// Token: 0x0401614A RID: 90442
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache16;

	// Token: 0x0401614B RID: 90443
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache17;

	// Token: 0x0401614C RID: 90444
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache18;

	// Token: 0x0401614D RID: 90445
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache19;

	// Token: 0x0401614E RID: 90446
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1A;

	// Token: 0x0401614F RID: 90447
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1B;

	// Token: 0x04016150 RID: 90448
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1C;

	// Token: 0x04016151 RID: 90449
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1D;

	// Token: 0x04016152 RID: 90450
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1E;

	// Token: 0x04016153 RID: 90451
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1F;

	// Token: 0x04016154 RID: 90452
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache20;

	// Token: 0x04016155 RID: 90453
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache21;

	// Token: 0x04016156 RID: 90454
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache22;

	// Token: 0x04016157 RID: 90455
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache23;

	// Token: 0x04016158 RID: 90456
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache24;

	// Token: 0x04016159 RID: 90457
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache25;

	// Token: 0x0401615A RID: 90458
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache26;

	// Token: 0x0401615B RID: 90459
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache27;

	// Token: 0x0401615C RID: 90460
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache28;

	// Token: 0x0401615D RID: 90461
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache29;

	// Token: 0x0401615E RID: 90462
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2A;

	// Token: 0x0401615F RID: 90463
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2B;
}
