using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using BlackJack.BJFramework.Runtime.UI;
using BlackJack.ConfigData;
using BlackJack.ProjectL.UI;
using SLua;
using UnityEngine.Scripting;

// Token: 0x0200145E RID: 5214
[Preserve]
public class Lua_BlackJack_ProjectL_UI_GetPathUITask : LuaObject
{
	// Token: 0x0601E1C3 RID: 123331 RVA: 0x009A6CC4 File Offset: 0x009A4EC4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int constructor(IntPtr l)
	{
		int result;
		try
		{
			string name;
			LuaObject.checkType(l, 2, out name);
			GetPathUITask o = new GetPathUITask(name);
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

	// Token: 0x0601E1C4 RID: 123332 RVA: 0x009A6D18 File Offset: 0x009A4F18
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int StartUITask_s(IntPtr l)
	{
		int result;
		try
		{
			GoodsType goodsType;
			LuaObject.checkEnum<GoodsType>(l, 1, out goodsType);
			int goodsId;
			LuaObject.checkType(l, 2, out goodsId);
			Action<GetPathData, NeedGoods> onGotoGetPath;
			LuaObject.checkDelegate<Action<GetPathData, NeedGoods>>(l, 3, out onGotoGetPath);
			int goodsNeedCount;
			LuaObject.checkType(l, 4, out goodsNeedCount);
			GetPathUITask o = GetPathUITask.StartUITask(goodsType, goodsId, onGotoGetPath, goodsNeedCount);
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

	// Token: 0x0601E1C5 RID: 123333 RVA: 0x009A6D94 File Offset: 0x009A4F94
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int InitAllUIControllers(IntPtr l)
	{
		int result;
		try
		{
			GetPathUITask getPathUITask = (GetPathUITask)LuaObject.checkSelf(l);
			getPathUITask.m_luaExportHelper.InitAllUIControllers();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601E1C6 RID: 123334 RVA: 0x009A6DE8 File Offset: 0x009A4FE8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int ClearAllContextAndRes(IntPtr l)
	{
		int result;
		try
		{
			GetPathUITask getPathUITask = (GetPathUITask)LuaObject.checkSelf(l);
			getPathUITask.m_luaExportHelper.ClearAllContextAndRes();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601E1C7 RID: 123335 RVA: 0x009A6E3C File Offset: 0x009A503C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int OnStart(IntPtr l)
	{
		int result;
		try
		{
			GetPathUITask getPathUITask = (GetPathUITask)LuaObject.checkSelf(l);
			UIIntent intent;
			LuaObject.checkType<UIIntent>(l, 2, out intent);
			bool b = getPathUITask.m_luaExportHelper.OnStart(intent);
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

	// Token: 0x0601E1C8 RID: 123336 RVA: 0x009A6EA4 File Offset: 0x009A50A4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int OnResume(IntPtr l)
	{
		int result;
		try
		{
			GetPathUITask getPathUITask = (GetPathUITask)LuaObject.checkSelf(l);
			UIIntent intent;
			LuaObject.checkType<UIIntent>(l, 2, out intent);
			bool b = getPathUITask.m_luaExportHelper.OnResume(intent);
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

	// Token: 0x0601E1C9 RID: 123337 RVA: 0x009A6F0C File Offset: 0x009A510C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int InitDataFromUIIntent(IntPtr l)
	{
		int result;
		try
		{
			GetPathUITask getPathUITask = (GetPathUITask)LuaObject.checkSelf(l);
			UIIntent intent;
			LuaObject.checkType<UIIntent>(l, 2, out intent);
			getPathUITask.m_luaExportHelper.InitDataFromUIIntent(intent);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601E1CA RID: 123338 RVA: 0x009A6F68 File Offset: 0x009A5168
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int UpdateView(IntPtr l)
	{
		int result;
		try
		{
			GetPathUITask getPathUITask = (GetPathUITask)LuaObject.checkSelf(l);
			getPathUITask.m_luaExportHelper.UpdateView();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601E1CB RID: 123339 RVA: 0x009A6FBC File Offset: 0x009A51BC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int GetPathUIController_OnClose(IntPtr l)
	{
		int result;
		try
		{
			GetPathUITask getPathUITask = (GetPathUITask)LuaObject.checkSelf(l);
			getPathUITask.m_luaExportHelper.GetPathUIController_OnClose();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601E1CC RID: 123340 RVA: 0x009A7010 File Offset: 0x009A5210
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int GetPathUIController_OnGotoButtonClick(IntPtr l)
	{
		int result;
		try
		{
			GetPathUITask getPathUITask = (GetPathUITask)LuaObject.checkSelf(l);
			GetPathData getPathInfo;
			LuaObject.checkType<GetPathData>(l, 2, out getPathInfo);
			getPathUITask.m_luaExportHelper.GetPathUIController_OnGotoButtonClick(getPathInfo);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601E1CD RID: 123341 RVA: 0x009A706C File Offset: 0x009A526C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_OnStart(IntPtr l)
	{
		int result;
		try
		{
			GetPathUITask getPathUITask = (GetPathUITask)LuaObject.checkSelf(l);
			UIIntent intent;
			LuaObject.checkType<UIIntent>(l, 2, out intent);
			bool b = getPathUITask.m_luaExportHelper.__callBase_OnStart(intent);
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

	// Token: 0x0601E1CE RID: 123342 RVA: 0x009A70D4 File Offset: 0x009A52D4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_OnStop(IntPtr l)
	{
		int result;
		try
		{
			GetPathUITask getPathUITask = (GetPathUITask)LuaObject.checkSelf(l);
			getPathUITask.m_luaExportHelper.__callBase_OnStop();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601E1CF RID: 123343 RVA: 0x009A7128 File Offset: 0x009A5328
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_OnPause(IntPtr l)
	{
		int result;
		try
		{
			GetPathUITask getPathUITask = (GetPathUITask)LuaObject.checkSelf(l);
			getPathUITask.m_luaExportHelper.__callBase_OnPause();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601E1D0 RID: 123344 RVA: 0x009A717C File Offset: 0x009A537C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_OnResume(IntPtr l)
	{
		int result;
		try
		{
			GetPathUITask getPathUITask = (GetPathUITask)LuaObject.checkSelf(l);
			UIIntent intent;
			LuaObject.checkType<UIIntent>(l, 2, out intent);
			bool b = getPathUITask.m_luaExportHelper.__callBase_OnResume(intent);
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

	// Token: 0x0601E1D1 RID: 123345 RVA: 0x009A71E4 File Offset: 0x009A53E4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_OnNewIntent(IntPtr l)
	{
		int result;
		try
		{
			GetPathUITask getPathUITask = (GetPathUITask)LuaObject.checkSelf(l);
			UIIntent intent;
			LuaObject.checkType<UIIntent>(l, 2, out intent);
			bool b = getPathUITask.m_luaExportHelper.__callBase_OnNewIntent(intent);
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

	// Token: 0x0601E1D2 RID: 123346 RVA: 0x009A724C File Offset: 0x009A544C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_EnableUIInput(IntPtr l)
	{
		int result;
		try
		{
			GetPathUITask getPathUITask = (GetPathUITask)LuaObject.checkSelf(l);
			bool isEnable;
			LuaObject.checkType(l, 2, out isEnable);
			bool? isGlobalEnable;
			LuaObject.checkNullable<bool>(l, 3, out isGlobalEnable);
			getPathUITask.m_luaExportHelper.__callBase_EnableUIInput(isEnable, isGlobalEnable);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601E1D3 RID: 123347 RVA: 0x009A72B8 File Offset: 0x009A54B8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_IsNeedLoadDynamicRes(IntPtr l)
	{
		int result;
		try
		{
			GetPathUITask getPathUITask = (GetPathUITask)LuaObject.checkSelf(l);
			bool b = getPathUITask.m_luaExportHelper.__callBase_IsNeedLoadDynamicRes();
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

	// Token: 0x0601E1D4 RID: 123348 RVA: 0x009A7314 File Offset: 0x009A5514
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_CollectAllDynamicResForLoad(IntPtr l)
	{
		int result;
		try
		{
			GetPathUITask getPathUITask = (GetPathUITask)LuaObject.checkSelf(l);
			List<string> o = getPathUITask.m_luaExportHelper.__callBase_CollectAllDynamicResForLoad();
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

	// Token: 0x0601E1D5 RID: 123349 RVA: 0x009A7370 File Offset: 0x009A5570
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_RegisterPlayerContextEvents(IntPtr l)
	{
		int result;
		try
		{
			GetPathUITask getPathUITask = (GetPathUITask)LuaObject.checkSelf(l);
			getPathUITask.m_luaExportHelper.__callBase_RegisterPlayerContextEvents();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601E1D6 RID: 123350 RVA: 0x009A73C4 File Offset: 0x009A55C4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_UnregisterPlayerContextEvents(IntPtr l)
	{
		int result;
		try
		{
			GetPathUITask getPathUITask = (GetPathUITask)LuaObject.checkSelf(l);
			getPathUITask.m_luaExportHelper.__callBase_UnregisterPlayerContextEvents();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601E1D7 RID: 123351 RVA: 0x009A7418 File Offset: 0x009A5618
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_PostUpdateView(IntPtr l)
	{
		int result;
		try
		{
			GetPathUITask getPathUITask = (GetPathUITask)LuaObject.checkSelf(l);
			getPathUITask.m_luaExportHelper.__callBase_PostUpdateView();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601E1D8 RID: 123352 RVA: 0x009A746C File Offset: 0x009A566C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_CollectPreloadResourceList(IntPtr l)
	{
		int result;
		try
		{
			GetPathUITask getPathUITask = (GetPathUITask)LuaObject.checkSelf(l);
			getPathUITask.m_luaExportHelper.__callBase_CollectPreloadResourceList();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601E1D9 RID: 123353 RVA: 0x009A74C0 File Offset: 0x009A56C0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_ClearAssetList(IntPtr l)
	{
		int result;
		try
		{
			GetPathUITask getPathUITask = (GetPathUITask)LuaObject.checkSelf(l);
			getPathUITask.m_luaExportHelper.__callBase_ClearAssetList();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601E1DA RID: 123354 RVA: 0x009A7514 File Offset: 0x009A5714
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_CollectAsset(IntPtr l)
	{
		int result;
		try
		{
			GetPathUITask getPathUITask = (GetPathUITask)LuaObject.checkSelf(l);
			string assetName;
			LuaObject.checkType(l, 2, out assetName);
			getPathUITask.m_luaExportHelper.__callBase_CollectAsset(assetName);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601E1DB RID: 123355 RVA: 0x009A7570 File Offset: 0x009A5770
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_CollectSpriteAsset(IntPtr l)
	{
		int result;
		try
		{
			GetPathUITask getPathUITask = (GetPathUITask)LuaObject.checkSelf(l);
			string assetName;
			LuaObject.checkType(l, 2, out assetName);
			getPathUITask.m_luaExportHelper.__callBase_CollectSpriteAsset(assetName);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601E1DC RID: 123356 RVA: 0x009A75CC File Offset: 0x009A57CC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_CollectFxAsset(IntPtr l)
	{
		int result;
		try
		{
			GetPathUITask getPathUITask = (GetPathUITask)LuaObject.checkSelf(l);
			string assetName;
			LuaObject.checkType(l, 2, out assetName);
			getPathUITask.m_luaExportHelper.__callBase_CollectFxAsset(assetName);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601E1DD RID: 123357 RVA: 0x009A7628 File Offset: 0x009A5828
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_StartLoadCustomAssets(IntPtr l)
	{
		int result;
		try
		{
			GetPathUITask getPathUITask = (GetPathUITask)LuaObject.checkSelf(l);
			Action onLoadCompleted;
			LuaObject.checkDelegate<Action>(l, 2, out onLoadCompleted);
			getPathUITask.m_luaExportHelper.__callBase_StartLoadCustomAssets(onLoadCompleted);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601E1DE RID: 123358 RVA: 0x009A7684 File Offset: 0x009A5884
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_IsLoadingCustomAssets(IntPtr l)
	{
		int result;
		try
		{
			GetPathUITask getPathUITask = (GetPathUITask)LuaObject.checkSelf(l);
			bool b = getPathUITask.m_luaExportHelper.__callBase_IsLoadingCustomAssets();
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

	// Token: 0x0601E1DF RID: 123359 RVA: 0x009A76E0 File Offset: 0x009A58E0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_IsPipeLineRunning(IntPtr l)
	{
		int result;
		try
		{
			GetPathUITask getPathUITask = (GetPathUITask)LuaObject.checkSelf(l);
			bool b = getPathUITask.m_luaExportHelper.__callBase_IsPipeLineRunning();
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

	// Token: 0x0601E1E0 RID: 123360 RVA: 0x009A773C File Offset: 0x009A593C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_IsOpeningUI(IntPtr l)
	{
		int result;
		try
		{
			GetPathUITask getPathUITask = (GetPathUITask)LuaObject.checkSelf(l);
			bool b = getPathUITask.m_luaExportHelper.__callBase_IsOpeningUI();
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

	// Token: 0x0601E1E1 RID: 123361 RVA: 0x009A7798 File Offset: 0x009A5998
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_ReturnPrevUITask(IntPtr l)
	{
		int result;
		try
		{
			GetPathUITask getPathUITask = (GetPathUITask)LuaObject.checkSelf(l);
			UITaskBase o = getPathUITask.m_luaExportHelper.__callBase_ReturnPrevUITask();
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

	// Token: 0x0601E1E2 RID: 123362 RVA: 0x009A77F4 File Offset: 0x009A59F4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_ClearUnusedDynamicResourceCache(IntPtr l)
	{
		int result;
		try
		{
			GetPathUITask getPathUITask = (GetPathUITask)LuaObject.checkSelf(l);
			getPathUITask.m_luaExportHelper.__callBase_ClearUnusedDynamicResourceCache();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601E1E3 RID: 123363 RVA: 0x009A7848 File Offset: 0x009A5A48
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_OnMemoryWarning(IntPtr l)
	{
		int result;
		try
		{
			GetPathUITask getPathUITask = (GetPathUITask)LuaObject.checkSelf(l);
			getPathUITask.m_luaExportHelper.__callBase_OnMemoryWarning();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601E1E4 RID: 123364 RVA: 0x009A789C File Offset: 0x009A5A9C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callDele_m_onGotoGetPathAction(IntPtr l)
	{
		int result;
		try
		{
			GetPathUITask getPathUITask = (GetPathUITask)LuaObject.checkSelf(l);
			GetPathData arg;
			LuaObject.checkType<GetPathData>(l, 2, out arg);
			NeedGoods arg2;
			LuaObject.checkType<NeedGoods>(l, 3, out arg2);
			getPathUITask.m_luaExportHelper.__callDele_m_onGotoGetPathAction(arg, arg2);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601E1E5 RID: 123365 RVA: 0x009A7908 File Offset: 0x009A5B08
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __clearDele_m_onGotoGetPathAction(IntPtr l)
	{
		int result;
		try
		{
			GetPathUITask getPathUITask = (GetPathUITask)LuaObject.checkSelf(l);
			GetPathData arg;
			LuaObject.checkType<GetPathData>(l, 2, out arg);
			NeedGoods arg2;
			LuaObject.checkType<NeedGoods>(l, 3, out arg2);
			getPathUITask.m_luaExportHelper.__clearDele_m_onGotoGetPathAction(arg, arg2);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601E1E6 RID: 123366 RVA: 0x009A7974 File Offset: 0x009A5B74
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_ParamKey_Type(IntPtr l)
	{
		int result;
		try
		{
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, GetPathUITask.LuaExportHelper.ParamKey_Type);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601E1E7 RID: 123367 RVA: 0x009A79BC File Offset: 0x009A5BBC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_ParamKey_Id(IntPtr l)
	{
		int result;
		try
		{
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, GetPathUITask.LuaExportHelper.ParamKey_Id);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601E1E8 RID: 123368 RVA: 0x009A7A04 File Offset: 0x009A5C04
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_ParamKey_Count(IntPtr l)
	{
		int result;
		try
		{
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, GetPathUITask.LuaExportHelper.ParamKey_Count);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601E1E9 RID: 123369 RVA: 0x009A7A4C File Offset: 0x009A5C4C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_ParamKey_OnGotoGetPath(IntPtr l)
	{
		int result;
		try
		{
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, GetPathUITask.LuaExportHelper.ParamKey_OnGotoGetPath);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601E1EA RID: 123370 RVA: 0x009A7A94 File Offset: 0x009A5C94
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_goodsType(IntPtr l)
	{
		int result;
		try
		{
			GetPathUITask getPathUITask = (GetPathUITask)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushEnum(l, (int)getPathUITask.m_luaExportHelper.m_goodsType);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601E1EB RID: 123371 RVA: 0x009A7AEC File Offset: 0x009A5CEC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_goodsType(IntPtr l)
	{
		int result;
		try
		{
			GetPathUITask getPathUITask = (GetPathUITask)LuaObject.checkSelf(l);
			GoodsType goodsType;
			LuaObject.checkEnum<GoodsType>(l, 2, out goodsType);
			getPathUITask.m_luaExportHelper.m_goodsType = goodsType;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601E1EC RID: 123372 RVA: 0x009A7B48 File Offset: 0x009A5D48
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_goodsID(IntPtr l)
	{
		int result;
		try
		{
			GetPathUITask getPathUITask = (GetPathUITask)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, getPathUITask.m_luaExportHelper.m_goodsID);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601E1ED RID: 123373 RVA: 0x009A7BA0 File Offset: 0x009A5DA0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_goodsID(IntPtr l)
	{
		int result;
		try
		{
			GetPathUITask getPathUITask = (GetPathUITask)LuaObject.checkSelf(l);
			int goodsID;
			LuaObject.checkType(l, 2, out goodsID);
			getPathUITask.m_luaExportHelper.m_goodsID = goodsID;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601E1EE RID: 123374 RVA: 0x009A7BFC File Offset: 0x009A5DFC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_goodsNeedCount(IntPtr l)
	{
		int result;
		try
		{
			GetPathUITask getPathUITask = (GetPathUITask)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, getPathUITask.m_luaExportHelper.m_goodsNeedCount);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601E1EF RID: 123375 RVA: 0x009A7C54 File Offset: 0x009A5E54
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_goodsNeedCount(IntPtr l)
	{
		int result;
		try
		{
			GetPathUITask getPathUITask = (GetPathUITask)LuaObject.checkSelf(l);
			int goodsNeedCount;
			LuaObject.checkType(l, 2, out goodsNeedCount);
			getPathUITask.m_luaExportHelper.m_goodsNeedCount = goodsNeedCount;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601E1F0 RID: 123376 RVA: 0x009A7CB0 File Offset: 0x009A5EB0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_onGotoGetPathAction(IntPtr l)
	{
		int result;
		try
		{
			GetPathUITask getPathUITask = (GetPathUITask)LuaObject.checkSelf(l);
			Action<GetPathData, NeedGoods> action;
			int num = LuaObject.checkDelegate<Action<GetPathData, NeedGoods>>(l, 2, out action);
			if (num == 0)
			{
				getPathUITask.m_luaExportHelper.m_onGotoGetPathAction = action;
			}
			else if (num == 1)
			{
				GetPathUITask.LuaExportHelper luaExportHelper = getPathUITask.m_luaExportHelper;
				luaExportHelper.m_onGotoGetPathAction = (Action<GetPathData, NeedGoods>)Delegate.Combine(luaExportHelper.m_onGotoGetPathAction, action);
			}
			else if (num == 2)
			{
				GetPathUITask.LuaExportHelper luaExportHelper2 = getPathUITask.m_luaExportHelper;
				luaExportHelper2.m_onGotoGetPathAction = (Action<GetPathData, NeedGoods>)Delegate.Remove(luaExportHelper2.m_onGotoGetPathAction, action);
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

	// Token: 0x0601E1F1 RID: 123377 RVA: 0x009A7D64 File Offset: 0x009A5F64
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_layerDescArray(IntPtr l)
	{
		int result;
		try
		{
			GetPathUITask getPathUITask = (GetPathUITask)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, getPathUITask.m_luaExportHelper.m_layerDescArray);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601E1F2 RID: 123378 RVA: 0x009A7DBC File Offset: 0x009A5FBC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_layerDescArray(IntPtr l)
	{
		int result;
		try
		{
			GetPathUITask getPathUITask = (GetPathUITask)LuaObject.checkSelf(l);
			UITaskBase.LayerDesc[] layerDescArray;
			LuaObject.checkArray<UITaskBase.LayerDesc>(l, 2, out layerDescArray);
			getPathUITask.m_luaExportHelper.m_layerDescArray = layerDescArray;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601E1F3 RID: 123379 RVA: 0x009A7E18 File Offset: 0x009A6018
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_uiCtrlDescArray(IntPtr l)
	{
		int result;
		try
		{
			GetPathUITask getPathUITask = (GetPathUITask)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, getPathUITask.m_luaExportHelper.m_uiCtrlDescArray);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601E1F4 RID: 123380 RVA: 0x009A7E70 File Offset: 0x009A6070
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_uiCtrlDescArray(IntPtr l)
	{
		int result;
		try
		{
			GetPathUITask getPathUITask = (GetPathUITask)LuaObject.checkSelf(l);
			UITaskBase.UIControllerDesc[] uiCtrlDescArray;
			LuaObject.checkArray<UITaskBase.UIControllerDesc>(l, 2, out uiCtrlDescArray);
			getPathUITask.m_luaExportHelper.m_uiCtrlDescArray = uiCtrlDescArray;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601E1F5 RID: 123381 RVA: 0x009A7ECC File Offset: 0x009A60CC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_getPathUIController(IntPtr l)
	{
		int result;
		try
		{
			GetPathUITask getPathUITask = (GetPathUITask)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, getPathUITask.m_luaExportHelper.m_getPathUIController);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601E1F6 RID: 123382 RVA: 0x009A7F24 File Offset: 0x009A6124
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_getPathUIController(IntPtr l)
	{
		int result;
		try
		{
			GetPathUITask getPathUITask = (GetPathUITask)LuaObject.checkSelf(l);
			GetPathUIController getPathUIController;
			LuaObject.checkType<GetPathUIController>(l, 2, out getPathUIController);
			getPathUITask.m_luaExportHelper.m_getPathUIController = getPathUIController;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601E1F7 RID: 123383 RVA: 0x009A7F80 File Offset: 0x009A6180
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_LayerDescArray(IntPtr l)
	{
		int result;
		try
		{
			GetPathUITask getPathUITask = (GetPathUITask)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, getPathUITask.m_luaExportHelper.LayerDescArray);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601E1F8 RID: 123384 RVA: 0x009A7FD8 File Offset: 0x009A61D8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_UICtrlDescArray(IntPtr l)
	{
		int result;
		try
		{
			GetPathUITask getPathUITask = (GetPathUITask)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, getPathUITask.m_luaExportHelper.UICtrlDescArray);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601E1F9 RID: 123385 RVA: 0x009A8030 File Offset: 0x009A6230
	[Preserve]
	public static void reg(IntPtr l)
	{
		LuaObject.getTypeTable(l, "BlackJack.ProjectL.UI.GetPathUITask");
		if (Lua_BlackJack_ProjectL_UI_GetPathUITask.<>f__mg$cache0 == null)
		{
			Lua_BlackJack_ProjectL_UI_GetPathUITask.<>f__mg$cache0 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_GetPathUITask.StartUITask_s);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_GetPathUITask.<>f__mg$cache0);
		if (Lua_BlackJack_ProjectL_UI_GetPathUITask.<>f__mg$cache1 == null)
		{
			Lua_BlackJack_ProjectL_UI_GetPathUITask.<>f__mg$cache1 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_GetPathUITask.InitAllUIControllers);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_GetPathUITask.<>f__mg$cache1);
		if (Lua_BlackJack_ProjectL_UI_GetPathUITask.<>f__mg$cache2 == null)
		{
			Lua_BlackJack_ProjectL_UI_GetPathUITask.<>f__mg$cache2 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_GetPathUITask.ClearAllContextAndRes);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_GetPathUITask.<>f__mg$cache2);
		if (Lua_BlackJack_ProjectL_UI_GetPathUITask.<>f__mg$cache3 == null)
		{
			Lua_BlackJack_ProjectL_UI_GetPathUITask.<>f__mg$cache3 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_GetPathUITask.OnStart);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_GetPathUITask.<>f__mg$cache3);
		if (Lua_BlackJack_ProjectL_UI_GetPathUITask.<>f__mg$cache4 == null)
		{
			Lua_BlackJack_ProjectL_UI_GetPathUITask.<>f__mg$cache4 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_GetPathUITask.OnResume);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_GetPathUITask.<>f__mg$cache4);
		if (Lua_BlackJack_ProjectL_UI_GetPathUITask.<>f__mg$cache5 == null)
		{
			Lua_BlackJack_ProjectL_UI_GetPathUITask.<>f__mg$cache5 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_GetPathUITask.InitDataFromUIIntent);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_GetPathUITask.<>f__mg$cache5);
		if (Lua_BlackJack_ProjectL_UI_GetPathUITask.<>f__mg$cache6 == null)
		{
			Lua_BlackJack_ProjectL_UI_GetPathUITask.<>f__mg$cache6 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_GetPathUITask.UpdateView);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_GetPathUITask.<>f__mg$cache6);
		if (Lua_BlackJack_ProjectL_UI_GetPathUITask.<>f__mg$cache7 == null)
		{
			Lua_BlackJack_ProjectL_UI_GetPathUITask.<>f__mg$cache7 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_GetPathUITask.GetPathUIController_OnClose);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_GetPathUITask.<>f__mg$cache7);
		if (Lua_BlackJack_ProjectL_UI_GetPathUITask.<>f__mg$cache8 == null)
		{
			Lua_BlackJack_ProjectL_UI_GetPathUITask.<>f__mg$cache8 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_GetPathUITask.GetPathUIController_OnGotoButtonClick);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_GetPathUITask.<>f__mg$cache8);
		if (Lua_BlackJack_ProjectL_UI_GetPathUITask.<>f__mg$cache9 == null)
		{
			Lua_BlackJack_ProjectL_UI_GetPathUITask.<>f__mg$cache9 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_GetPathUITask.__callBase_OnStart);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_GetPathUITask.<>f__mg$cache9);
		if (Lua_BlackJack_ProjectL_UI_GetPathUITask.<>f__mg$cacheA == null)
		{
			Lua_BlackJack_ProjectL_UI_GetPathUITask.<>f__mg$cacheA = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_GetPathUITask.__callBase_OnStop);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_GetPathUITask.<>f__mg$cacheA);
		if (Lua_BlackJack_ProjectL_UI_GetPathUITask.<>f__mg$cacheB == null)
		{
			Lua_BlackJack_ProjectL_UI_GetPathUITask.<>f__mg$cacheB = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_GetPathUITask.__callBase_OnPause);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_GetPathUITask.<>f__mg$cacheB);
		if (Lua_BlackJack_ProjectL_UI_GetPathUITask.<>f__mg$cacheC == null)
		{
			Lua_BlackJack_ProjectL_UI_GetPathUITask.<>f__mg$cacheC = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_GetPathUITask.__callBase_OnResume);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_GetPathUITask.<>f__mg$cacheC);
		if (Lua_BlackJack_ProjectL_UI_GetPathUITask.<>f__mg$cacheD == null)
		{
			Lua_BlackJack_ProjectL_UI_GetPathUITask.<>f__mg$cacheD = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_GetPathUITask.__callBase_OnNewIntent);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_GetPathUITask.<>f__mg$cacheD);
		if (Lua_BlackJack_ProjectL_UI_GetPathUITask.<>f__mg$cacheE == null)
		{
			Lua_BlackJack_ProjectL_UI_GetPathUITask.<>f__mg$cacheE = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_GetPathUITask.__callBase_EnableUIInput);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_GetPathUITask.<>f__mg$cacheE);
		if (Lua_BlackJack_ProjectL_UI_GetPathUITask.<>f__mg$cacheF == null)
		{
			Lua_BlackJack_ProjectL_UI_GetPathUITask.<>f__mg$cacheF = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_GetPathUITask.__callBase_IsNeedLoadDynamicRes);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_GetPathUITask.<>f__mg$cacheF);
		if (Lua_BlackJack_ProjectL_UI_GetPathUITask.<>f__mg$cache10 == null)
		{
			Lua_BlackJack_ProjectL_UI_GetPathUITask.<>f__mg$cache10 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_GetPathUITask.__callBase_CollectAllDynamicResForLoad);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_GetPathUITask.<>f__mg$cache10);
		if (Lua_BlackJack_ProjectL_UI_GetPathUITask.<>f__mg$cache11 == null)
		{
			Lua_BlackJack_ProjectL_UI_GetPathUITask.<>f__mg$cache11 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_GetPathUITask.__callBase_RegisterPlayerContextEvents);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_GetPathUITask.<>f__mg$cache11);
		if (Lua_BlackJack_ProjectL_UI_GetPathUITask.<>f__mg$cache12 == null)
		{
			Lua_BlackJack_ProjectL_UI_GetPathUITask.<>f__mg$cache12 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_GetPathUITask.__callBase_UnregisterPlayerContextEvents);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_GetPathUITask.<>f__mg$cache12);
		if (Lua_BlackJack_ProjectL_UI_GetPathUITask.<>f__mg$cache13 == null)
		{
			Lua_BlackJack_ProjectL_UI_GetPathUITask.<>f__mg$cache13 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_GetPathUITask.__callBase_PostUpdateView);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_GetPathUITask.<>f__mg$cache13);
		if (Lua_BlackJack_ProjectL_UI_GetPathUITask.<>f__mg$cache14 == null)
		{
			Lua_BlackJack_ProjectL_UI_GetPathUITask.<>f__mg$cache14 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_GetPathUITask.__callBase_CollectPreloadResourceList);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_GetPathUITask.<>f__mg$cache14);
		if (Lua_BlackJack_ProjectL_UI_GetPathUITask.<>f__mg$cache15 == null)
		{
			Lua_BlackJack_ProjectL_UI_GetPathUITask.<>f__mg$cache15 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_GetPathUITask.__callBase_ClearAssetList);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_GetPathUITask.<>f__mg$cache15);
		if (Lua_BlackJack_ProjectL_UI_GetPathUITask.<>f__mg$cache16 == null)
		{
			Lua_BlackJack_ProjectL_UI_GetPathUITask.<>f__mg$cache16 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_GetPathUITask.__callBase_CollectAsset);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_GetPathUITask.<>f__mg$cache16);
		if (Lua_BlackJack_ProjectL_UI_GetPathUITask.<>f__mg$cache17 == null)
		{
			Lua_BlackJack_ProjectL_UI_GetPathUITask.<>f__mg$cache17 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_GetPathUITask.__callBase_CollectSpriteAsset);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_GetPathUITask.<>f__mg$cache17);
		if (Lua_BlackJack_ProjectL_UI_GetPathUITask.<>f__mg$cache18 == null)
		{
			Lua_BlackJack_ProjectL_UI_GetPathUITask.<>f__mg$cache18 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_GetPathUITask.__callBase_CollectFxAsset);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_GetPathUITask.<>f__mg$cache18);
		if (Lua_BlackJack_ProjectL_UI_GetPathUITask.<>f__mg$cache19 == null)
		{
			Lua_BlackJack_ProjectL_UI_GetPathUITask.<>f__mg$cache19 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_GetPathUITask.__callBase_StartLoadCustomAssets);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_GetPathUITask.<>f__mg$cache19);
		if (Lua_BlackJack_ProjectL_UI_GetPathUITask.<>f__mg$cache1A == null)
		{
			Lua_BlackJack_ProjectL_UI_GetPathUITask.<>f__mg$cache1A = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_GetPathUITask.__callBase_IsLoadingCustomAssets);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_GetPathUITask.<>f__mg$cache1A);
		if (Lua_BlackJack_ProjectL_UI_GetPathUITask.<>f__mg$cache1B == null)
		{
			Lua_BlackJack_ProjectL_UI_GetPathUITask.<>f__mg$cache1B = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_GetPathUITask.__callBase_IsPipeLineRunning);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_GetPathUITask.<>f__mg$cache1B);
		if (Lua_BlackJack_ProjectL_UI_GetPathUITask.<>f__mg$cache1C == null)
		{
			Lua_BlackJack_ProjectL_UI_GetPathUITask.<>f__mg$cache1C = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_GetPathUITask.__callBase_IsOpeningUI);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_GetPathUITask.<>f__mg$cache1C);
		if (Lua_BlackJack_ProjectL_UI_GetPathUITask.<>f__mg$cache1D == null)
		{
			Lua_BlackJack_ProjectL_UI_GetPathUITask.<>f__mg$cache1D = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_GetPathUITask.__callBase_ReturnPrevUITask);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_GetPathUITask.<>f__mg$cache1D);
		if (Lua_BlackJack_ProjectL_UI_GetPathUITask.<>f__mg$cache1E == null)
		{
			Lua_BlackJack_ProjectL_UI_GetPathUITask.<>f__mg$cache1E = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_GetPathUITask.__callBase_ClearUnusedDynamicResourceCache);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_GetPathUITask.<>f__mg$cache1E);
		if (Lua_BlackJack_ProjectL_UI_GetPathUITask.<>f__mg$cache1F == null)
		{
			Lua_BlackJack_ProjectL_UI_GetPathUITask.<>f__mg$cache1F = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_GetPathUITask.__callBase_OnMemoryWarning);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_GetPathUITask.<>f__mg$cache1F);
		if (Lua_BlackJack_ProjectL_UI_GetPathUITask.<>f__mg$cache20 == null)
		{
			Lua_BlackJack_ProjectL_UI_GetPathUITask.<>f__mg$cache20 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_GetPathUITask.__callDele_m_onGotoGetPathAction);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_GetPathUITask.<>f__mg$cache20);
		if (Lua_BlackJack_ProjectL_UI_GetPathUITask.<>f__mg$cache21 == null)
		{
			Lua_BlackJack_ProjectL_UI_GetPathUITask.<>f__mg$cache21 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_GetPathUITask.__clearDele_m_onGotoGetPathAction);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_GetPathUITask.<>f__mg$cache21);
		string name = "ParamKey_Type";
		if (Lua_BlackJack_ProjectL_UI_GetPathUITask.<>f__mg$cache22 == null)
		{
			Lua_BlackJack_ProjectL_UI_GetPathUITask.<>f__mg$cache22 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_GetPathUITask.get_ParamKey_Type);
		}
		LuaObject.addMember(l, name, Lua_BlackJack_ProjectL_UI_GetPathUITask.<>f__mg$cache22, null, false);
		string name2 = "ParamKey_Id";
		if (Lua_BlackJack_ProjectL_UI_GetPathUITask.<>f__mg$cache23 == null)
		{
			Lua_BlackJack_ProjectL_UI_GetPathUITask.<>f__mg$cache23 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_GetPathUITask.get_ParamKey_Id);
		}
		LuaObject.addMember(l, name2, Lua_BlackJack_ProjectL_UI_GetPathUITask.<>f__mg$cache23, null, false);
		string name3 = "ParamKey_Count";
		if (Lua_BlackJack_ProjectL_UI_GetPathUITask.<>f__mg$cache24 == null)
		{
			Lua_BlackJack_ProjectL_UI_GetPathUITask.<>f__mg$cache24 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_GetPathUITask.get_ParamKey_Count);
		}
		LuaObject.addMember(l, name3, Lua_BlackJack_ProjectL_UI_GetPathUITask.<>f__mg$cache24, null, false);
		string name4 = "ParamKey_OnGotoGetPath";
		if (Lua_BlackJack_ProjectL_UI_GetPathUITask.<>f__mg$cache25 == null)
		{
			Lua_BlackJack_ProjectL_UI_GetPathUITask.<>f__mg$cache25 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_GetPathUITask.get_ParamKey_OnGotoGetPath);
		}
		LuaObject.addMember(l, name4, Lua_BlackJack_ProjectL_UI_GetPathUITask.<>f__mg$cache25, null, false);
		string name5 = "m_goodsType";
		if (Lua_BlackJack_ProjectL_UI_GetPathUITask.<>f__mg$cache26 == null)
		{
			Lua_BlackJack_ProjectL_UI_GetPathUITask.<>f__mg$cache26 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_GetPathUITask.get_m_goodsType);
		}
		LuaCSFunction get = Lua_BlackJack_ProjectL_UI_GetPathUITask.<>f__mg$cache26;
		if (Lua_BlackJack_ProjectL_UI_GetPathUITask.<>f__mg$cache27 == null)
		{
			Lua_BlackJack_ProjectL_UI_GetPathUITask.<>f__mg$cache27 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_GetPathUITask.set_m_goodsType);
		}
		LuaObject.addMember(l, name5, get, Lua_BlackJack_ProjectL_UI_GetPathUITask.<>f__mg$cache27, true);
		string name6 = "m_goodsID";
		if (Lua_BlackJack_ProjectL_UI_GetPathUITask.<>f__mg$cache28 == null)
		{
			Lua_BlackJack_ProjectL_UI_GetPathUITask.<>f__mg$cache28 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_GetPathUITask.get_m_goodsID);
		}
		LuaCSFunction get2 = Lua_BlackJack_ProjectL_UI_GetPathUITask.<>f__mg$cache28;
		if (Lua_BlackJack_ProjectL_UI_GetPathUITask.<>f__mg$cache29 == null)
		{
			Lua_BlackJack_ProjectL_UI_GetPathUITask.<>f__mg$cache29 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_GetPathUITask.set_m_goodsID);
		}
		LuaObject.addMember(l, name6, get2, Lua_BlackJack_ProjectL_UI_GetPathUITask.<>f__mg$cache29, true);
		string name7 = "m_goodsNeedCount";
		if (Lua_BlackJack_ProjectL_UI_GetPathUITask.<>f__mg$cache2A == null)
		{
			Lua_BlackJack_ProjectL_UI_GetPathUITask.<>f__mg$cache2A = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_GetPathUITask.get_m_goodsNeedCount);
		}
		LuaCSFunction get3 = Lua_BlackJack_ProjectL_UI_GetPathUITask.<>f__mg$cache2A;
		if (Lua_BlackJack_ProjectL_UI_GetPathUITask.<>f__mg$cache2B == null)
		{
			Lua_BlackJack_ProjectL_UI_GetPathUITask.<>f__mg$cache2B = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_GetPathUITask.set_m_goodsNeedCount);
		}
		LuaObject.addMember(l, name7, get3, Lua_BlackJack_ProjectL_UI_GetPathUITask.<>f__mg$cache2B, true);
		string name8 = "m_onGotoGetPathAction";
		LuaCSFunction get4 = null;
		if (Lua_BlackJack_ProjectL_UI_GetPathUITask.<>f__mg$cache2C == null)
		{
			Lua_BlackJack_ProjectL_UI_GetPathUITask.<>f__mg$cache2C = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_GetPathUITask.set_m_onGotoGetPathAction);
		}
		LuaObject.addMember(l, name8, get4, Lua_BlackJack_ProjectL_UI_GetPathUITask.<>f__mg$cache2C, true);
		string name9 = "m_layerDescArray";
		if (Lua_BlackJack_ProjectL_UI_GetPathUITask.<>f__mg$cache2D == null)
		{
			Lua_BlackJack_ProjectL_UI_GetPathUITask.<>f__mg$cache2D = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_GetPathUITask.get_m_layerDescArray);
		}
		LuaCSFunction get5 = Lua_BlackJack_ProjectL_UI_GetPathUITask.<>f__mg$cache2D;
		if (Lua_BlackJack_ProjectL_UI_GetPathUITask.<>f__mg$cache2E == null)
		{
			Lua_BlackJack_ProjectL_UI_GetPathUITask.<>f__mg$cache2E = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_GetPathUITask.set_m_layerDescArray);
		}
		LuaObject.addMember(l, name9, get5, Lua_BlackJack_ProjectL_UI_GetPathUITask.<>f__mg$cache2E, true);
		string name10 = "m_uiCtrlDescArray";
		if (Lua_BlackJack_ProjectL_UI_GetPathUITask.<>f__mg$cache2F == null)
		{
			Lua_BlackJack_ProjectL_UI_GetPathUITask.<>f__mg$cache2F = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_GetPathUITask.get_m_uiCtrlDescArray);
		}
		LuaCSFunction get6 = Lua_BlackJack_ProjectL_UI_GetPathUITask.<>f__mg$cache2F;
		if (Lua_BlackJack_ProjectL_UI_GetPathUITask.<>f__mg$cache30 == null)
		{
			Lua_BlackJack_ProjectL_UI_GetPathUITask.<>f__mg$cache30 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_GetPathUITask.set_m_uiCtrlDescArray);
		}
		LuaObject.addMember(l, name10, get6, Lua_BlackJack_ProjectL_UI_GetPathUITask.<>f__mg$cache30, true);
		string name11 = "m_getPathUIController";
		if (Lua_BlackJack_ProjectL_UI_GetPathUITask.<>f__mg$cache31 == null)
		{
			Lua_BlackJack_ProjectL_UI_GetPathUITask.<>f__mg$cache31 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_GetPathUITask.get_m_getPathUIController);
		}
		LuaCSFunction get7 = Lua_BlackJack_ProjectL_UI_GetPathUITask.<>f__mg$cache31;
		if (Lua_BlackJack_ProjectL_UI_GetPathUITask.<>f__mg$cache32 == null)
		{
			Lua_BlackJack_ProjectL_UI_GetPathUITask.<>f__mg$cache32 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_GetPathUITask.set_m_getPathUIController);
		}
		LuaObject.addMember(l, name11, get7, Lua_BlackJack_ProjectL_UI_GetPathUITask.<>f__mg$cache32, true);
		string name12 = "LayerDescArray";
		if (Lua_BlackJack_ProjectL_UI_GetPathUITask.<>f__mg$cache33 == null)
		{
			Lua_BlackJack_ProjectL_UI_GetPathUITask.<>f__mg$cache33 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_GetPathUITask.get_LayerDescArray);
		}
		LuaObject.addMember(l, name12, Lua_BlackJack_ProjectL_UI_GetPathUITask.<>f__mg$cache33, null, true);
		string name13 = "UICtrlDescArray";
		if (Lua_BlackJack_ProjectL_UI_GetPathUITask.<>f__mg$cache34 == null)
		{
			Lua_BlackJack_ProjectL_UI_GetPathUITask.<>f__mg$cache34 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_GetPathUITask.get_UICtrlDescArray);
		}
		LuaObject.addMember(l, name13, Lua_BlackJack_ProjectL_UI_GetPathUITask.<>f__mg$cache34, null, true);
		if (Lua_BlackJack_ProjectL_UI_GetPathUITask.<>f__mg$cache35 == null)
		{
			Lua_BlackJack_ProjectL_UI_GetPathUITask.<>f__mg$cache35 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_GetPathUITask.constructor);
		}
		LuaObject.createTypeMetatable(l, Lua_BlackJack_ProjectL_UI_GetPathUITask.<>f__mg$cache35, typeof(GetPathUITask), typeof(UITask));
	}

	// Token: 0x040142E9 RID: 82665
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache0;

	// Token: 0x040142EA RID: 82666
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1;

	// Token: 0x040142EB RID: 82667
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2;

	// Token: 0x040142EC RID: 82668
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3;

	// Token: 0x040142ED RID: 82669
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache4;

	// Token: 0x040142EE RID: 82670
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache5;

	// Token: 0x040142EF RID: 82671
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache6;

	// Token: 0x040142F0 RID: 82672
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache7;

	// Token: 0x040142F1 RID: 82673
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache8;

	// Token: 0x040142F2 RID: 82674
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache9;

	// Token: 0x040142F3 RID: 82675
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheA;

	// Token: 0x040142F4 RID: 82676
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheB;

	// Token: 0x040142F5 RID: 82677
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheC;

	// Token: 0x040142F6 RID: 82678
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheD;

	// Token: 0x040142F7 RID: 82679
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheE;

	// Token: 0x040142F8 RID: 82680
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheF;

	// Token: 0x040142F9 RID: 82681
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache10;

	// Token: 0x040142FA RID: 82682
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache11;

	// Token: 0x040142FB RID: 82683
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache12;

	// Token: 0x040142FC RID: 82684
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache13;

	// Token: 0x040142FD RID: 82685
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache14;

	// Token: 0x040142FE RID: 82686
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache15;

	// Token: 0x040142FF RID: 82687
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache16;

	// Token: 0x04014300 RID: 82688
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache17;

	// Token: 0x04014301 RID: 82689
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache18;

	// Token: 0x04014302 RID: 82690
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache19;

	// Token: 0x04014303 RID: 82691
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1A;

	// Token: 0x04014304 RID: 82692
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1B;

	// Token: 0x04014305 RID: 82693
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1C;

	// Token: 0x04014306 RID: 82694
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1D;

	// Token: 0x04014307 RID: 82695
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1E;

	// Token: 0x04014308 RID: 82696
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1F;

	// Token: 0x04014309 RID: 82697
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache20;

	// Token: 0x0401430A RID: 82698
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache21;

	// Token: 0x0401430B RID: 82699
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache22;

	// Token: 0x0401430C RID: 82700
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache23;

	// Token: 0x0401430D RID: 82701
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache24;

	// Token: 0x0401430E RID: 82702
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache25;

	// Token: 0x0401430F RID: 82703
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache26;

	// Token: 0x04014310 RID: 82704
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache27;

	// Token: 0x04014311 RID: 82705
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache28;

	// Token: 0x04014312 RID: 82706
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache29;

	// Token: 0x04014313 RID: 82707
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2A;

	// Token: 0x04014314 RID: 82708
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2B;

	// Token: 0x04014315 RID: 82709
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2C;

	// Token: 0x04014316 RID: 82710
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2D;

	// Token: 0x04014317 RID: 82711
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2E;

	// Token: 0x04014318 RID: 82712
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2F;

	// Token: 0x04014319 RID: 82713
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache30;

	// Token: 0x0401431A RID: 82714
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache31;

	// Token: 0x0401431B RID: 82715
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache32;

	// Token: 0x0401431C RID: 82716
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache33;

	// Token: 0x0401431D RID: 82717
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache34;

	// Token: 0x0401431E RID: 82718
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache35;
}
