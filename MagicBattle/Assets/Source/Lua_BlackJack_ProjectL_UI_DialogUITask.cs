using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using BlackJack.BJFramework.Runtime.UI;
using BlackJack.ConfigData;
using BlackJack.ProjectL.UI;
using BlackJack.ProjectLBasic;
using SLua;
using UnityEngine.Scripting;

// Token: 0x02001417 RID: 5143
[Preserve]
public class Lua_BlackJack_ProjectL_UI_DialogUITask : LuaObject
{
	// Token: 0x0601D1D3 RID: 119251 RVA: 0x00927E34 File Offset: 0x00926034
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int constructor(IntPtr l)
	{
		int result;
		try
		{
			string name;
			LuaObject.checkType(l, 2, out name);
			DialogUITask o = new DialogUITask(name);
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

	// Token: 0x0601D1D4 RID: 119252 RVA: 0x00927E88 File Offset: 0x00926088
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int OnStart(IntPtr l)
	{
		int result;
		try
		{
			DialogUITask dialogUITask = (DialogUITask)LuaObject.checkSelf(l);
			UIIntent intent;
			LuaObject.checkType<UIIntent>(l, 2, out intent);
			bool b = dialogUITask.m_luaExportHelper.OnStart(intent);
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

	// Token: 0x0601D1D5 RID: 119253 RVA: 0x00927EF0 File Offset: 0x009260F0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int OnResume(IntPtr l)
	{
		int result;
		try
		{
			DialogUITask dialogUITask = (DialogUITask)LuaObject.checkSelf(l);
			UIIntent intent;
			LuaObject.checkType<UIIntent>(l, 2, out intent);
			bool b = dialogUITask.m_luaExportHelper.OnResume(intent);
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

	// Token: 0x0601D1D6 RID: 119254 RVA: 0x00927F58 File Offset: 0x00926158
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int InitDataFromUIIntent(IntPtr l)
	{
		int result;
		try
		{
			DialogUITask dialogUITask = (DialogUITask)LuaObject.checkSelf(l);
			UIIntent intent;
			LuaObject.checkType<UIIntent>(l, 2, out intent);
			dialogUITask.m_luaExportHelper.InitDataFromUIIntent(intent);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D1D7 RID: 119255 RVA: 0x00927FB4 File Offset: 0x009261B4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int IsNeedLoadDynamicRes(IntPtr l)
	{
		int result;
		try
		{
			DialogUITask dialogUITask = (DialogUITask)LuaObject.checkSelf(l);
			bool b = dialogUITask.m_luaExportHelper.IsNeedLoadDynamicRes();
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

	// Token: 0x0601D1D8 RID: 119256 RVA: 0x00928010 File Offset: 0x00926210
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int InitAllUIControllers(IntPtr l)
	{
		int result;
		try
		{
			DialogUITask dialogUITask = (DialogUITask)LuaObject.checkSelf(l);
			dialogUITask.m_luaExportHelper.InitAllUIControllers();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D1D9 RID: 119257 RVA: 0x00928064 File Offset: 0x00926264
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int ClearAllContextAndRes(IntPtr l)
	{
		int result;
		try
		{
			DialogUITask dialogUITask = (DialogUITask)LuaObject.checkSelf(l);
			dialogUITask.m_luaExportHelper.ClearAllContextAndRes();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D1DA RID: 119258 RVA: 0x009280B8 File Offset: 0x009262B8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int OnMemoryWarning(IntPtr l)
	{
		int result;
		try
		{
			DialogUITask dialogUITask = (DialogUITask)LuaObject.checkSelf(l);
			dialogUITask.m_luaExportHelper.OnMemoryWarning();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D1DB RID: 119259 RVA: 0x0092810C File Offset: 0x0092630C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int UpdateView(IntPtr l)
	{
		int result;
		try
		{
			DialogUITask dialogUITask = (DialogUITask)LuaObject.checkSelf(l);
			dialogUITask.m_luaExportHelper.UpdateView();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D1DC RID: 119260 RVA: 0x00928160 File Offset: 0x00926360
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int InitDialogUIController(IntPtr l)
	{
		int result;
		try
		{
			DialogUITask dialogUITask = (DialogUITask)LuaObject.checkSelf(l);
			dialogUITask.m_luaExportHelper.InitDialogUIController();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D1DD RID: 119261 RVA: 0x009281B4 File Offset: 0x009263B4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int UninitDialogUIController(IntPtr l)
	{
		int result;
		try
		{
			DialogUITask dialogUITask = (DialogUITask)LuaObject.checkSelf(l);
			dialogUITask.m_luaExportHelper.UninitDialogUIController();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D1DE RID: 119262 RVA: 0x00928208 File Offset: 0x00926408
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int DialogUIController_OnSkip(IntPtr l)
	{
		int result;
		try
		{
			DialogUITask dialogUITask = (DialogUITask)LuaObject.checkSelf(l);
			dialogUITask.m_luaExportHelper.DialogUIController_OnSkip();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D1DF RID: 119263 RVA: 0x0092825C File Offset: 0x0092645C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int SkipDialogDialogBoxCallback(IntPtr l)
	{
		int result;
		try
		{
			DialogUITask dialogUITask = (DialogUITask)LuaObject.checkSelf(l);
			DialogBoxResult r;
			LuaObject.checkEnum<DialogBoxResult>(l, 2, out r);
			dialogUITask.m_luaExportHelper.SkipDialogDialogBoxCallback(r);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D1E0 RID: 119264 RVA: 0x009282B8 File Offset: 0x009264B8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int DialogUIController_OnNext(IntPtr l)
	{
		int result;
		try
		{
			DialogUITask dialogUITask = (DialogUITask)LuaObject.checkSelf(l);
			bool needBGChangeTween;
			LuaObject.checkType(l, 2, out needBGChangeTween);
			dialogUITask.m_luaExportHelper.DialogUIController_OnNext(needBGChangeTween);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D1E1 RID: 119265 RVA: 0x00928314 File Offset: 0x00926514
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int DialogUIController_OnClose(IntPtr l)
	{
		int result;
		try
		{
			DialogUITask dialogUITask = (DialogUITask)LuaObject.checkSelf(l);
			dialogUITask.m_luaExportHelper.DialogUIController_OnClose();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D1E2 RID: 119266 RVA: 0x00928368 File Offset: 0x00926568
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_OnStart(IntPtr l)
	{
		int result;
		try
		{
			DialogUITask dialogUITask = (DialogUITask)LuaObject.checkSelf(l);
			UIIntent intent;
			LuaObject.checkType<UIIntent>(l, 2, out intent);
			bool b = dialogUITask.m_luaExportHelper.__callBase_OnStart(intent);
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

	// Token: 0x0601D1E3 RID: 119267 RVA: 0x009283D0 File Offset: 0x009265D0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_OnStop(IntPtr l)
	{
		int result;
		try
		{
			DialogUITask dialogUITask = (DialogUITask)LuaObject.checkSelf(l);
			dialogUITask.m_luaExportHelper.__callBase_OnStop();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D1E4 RID: 119268 RVA: 0x00928424 File Offset: 0x00926624
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_OnPause(IntPtr l)
	{
		int result;
		try
		{
			DialogUITask dialogUITask = (DialogUITask)LuaObject.checkSelf(l);
			dialogUITask.m_luaExportHelper.__callBase_OnPause();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D1E5 RID: 119269 RVA: 0x00928478 File Offset: 0x00926678
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_OnResume(IntPtr l)
	{
		int result;
		try
		{
			DialogUITask dialogUITask = (DialogUITask)LuaObject.checkSelf(l);
			UIIntent intent;
			LuaObject.checkType<UIIntent>(l, 2, out intent);
			bool b = dialogUITask.m_luaExportHelper.__callBase_OnResume(intent);
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

	// Token: 0x0601D1E6 RID: 119270 RVA: 0x009284E0 File Offset: 0x009266E0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_OnNewIntent(IntPtr l)
	{
		int result;
		try
		{
			DialogUITask dialogUITask = (DialogUITask)LuaObject.checkSelf(l);
			UIIntent intent;
			LuaObject.checkType<UIIntent>(l, 2, out intent);
			bool b = dialogUITask.m_luaExportHelper.__callBase_OnNewIntent(intent);
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

	// Token: 0x0601D1E7 RID: 119271 RVA: 0x00928548 File Offset: 0x00926748
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_EnableUIInput(IntPtr l)
	{
		int result;
		try
		{
			DialogUITask dialogUITask = (DialogUITask)LuaObject.checkSelf(l);
			bool isEnable;
			LuaObject.checkType(l, 2, out isEnable);
			bool? isGlobalEnable;
			LuaObject.checkNullable<bool>(l, 3, out isGlobalEnable);
			dialogUITask.m_luaExportHelper.__callBase_EnableUIInput(isEnable, isGlobalEnable);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D1E8 RID: 119272 RVA: 0x009285B4 File Offset: 0x009267B4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_IsNeedLoadDynamicRes(IntPtr l)
	{
		int result;
		try
		{
			DialogUITask dialogUITask = (DialogUITask)LuaObject.checkSelf(l);
			bool b = dialogUITask.m_luaExportHelper.__callBase_IsNeedLoadDynamicRes();
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

	// Token: 0x0601D1E9 RID: 119273 RVA: 0x00928610 File Offset: 0x00926810
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_CollectAllDynamicResForLoad(IntPtr l)
	{
		int result;
		try
		{
			DialogUITask dialogUITask = (DialogUITask)LuaObject.checkSelf(l);
			List<string> o = dialogUITask.m_luaExportHelper.__callBase_CollectAllDynamicResForLoad();
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

	// Token: 0x0601D1EA RID: 119274 RVA: 0x0092866C File Offset: 0x0092686C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_RegisterPlayerContextEvents(IntPtr l)
	{
		int result;
		try
		{
			DialogUITask dialogUITask = (DialogUITask)LuaObject.checkSelf(l);
			dialogUITask.m_luaExportHelper.__callBase_RegisterPlayerContextEvents();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D1EB RID: 119275 RVA: 0x009286C0 File Offset: 0x009268C0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_UnregisterPlayerContextEvents(IntPtr l)
	{
		int result;
		try
		{
			DialogUITask dialogUITask = (DialogUITask)LuaObject.checkSelf(l);
			dialogUITask.m_luaExportHelper.__callBase_UnregisterPlayerContextEvents();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D1EC RID: 119276 RVA: 0x00928714 File Offset: 0x00926914
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_PostUpdateView(IntPtr l)
	{
		int result;
		try
		{
			DialogUITask dialogUITask = (DialogUITask)LuaObject.checkSelf(l);
			dialogUITask.m_luaExportHelper.__callBase_PostUpdateView();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D1ED RID: 119277 RVA: 0x00928768 File Offset: 0x00926968
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_CollectPreloadResourceList(IntPtr l)
	{
		int result;
		try
		{
			DialogUITask dialogUITask = (DialogUITask)LuaObject.checkSelf(l);
			dialogUITask.m_luaExportHelper.__callBase_CollectPreloadResourceList();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D1EE RID: 119278 RVA: 0x009287BC File Offset: 0x009269BC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_ClearAssetList(IntPtr l)
	{
		int result;
		try
		{
			DialogUITask dialogUITask = (DialogUITask)LuaObject.checkSelf(l);
			dialogUITask.m_luaExportHelper.__callBase_ClearAssetList();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D1EF RID: 119279 RVA: 0x00928810 File Offset: 0x00926A10
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_CollectAsset(IntPtr l)
	{
		int result;
		try
		{
			DialogUITask dialogUITask = (DialogUITask)LuaObject.checkSelf(l);
			string assetName;
			LuaObject.checkType(l, 2, out assetName);
			dialogUITask.m_luaExportHelper.__callBase_CollectAsset(assetName);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D1F0 RID: 119280 RVA: 0x0092886C File Offset: 0x00926A6C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_CollectSpriteAsset(IntPtr l)
	{
		int result;
		try
		{
			DialogUITask dialogUITask = (DialogUITask)LuaObject.checkSelf(l);
			string assetName;
			LuaObject.checkType(l, 2, out assetName);
			dialogUITask.m_luaExportHelper.__callBase_CollectSpriteAsset(assetName);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D1F1 RID: 119281 RVA: 0x009288C8 File Offset: 0x00926AC8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_CollectFxAsset(IntPtr l)
	{
		int result;
		try
		{
			DialogUITask dialogUITask = (DialogUITask)LuaObject.checkSelf(l);
			string assetName;
			LuaObject.checkType(l, 2, out assetName);
			dialogUITask.m_luaExportHelper.__callBase_CollectFxAsset(assetName);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D1F2 RID: 119282 RVA: 0x00928924 File Offset: 0x00926B24
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_StartLoadCustomAssets(IntPtr l)
	{
		int result;
		try
		{
			DialogUITask dialogUITask = (DialogUITask)LuaObject.checkSelf(l);
			Action onLoadCompleted;
			LuaObject.checkDelegate<Action>(l, 2, out onLoadCompleted);
			dialogUITask.m_luaExportHelper.__callBase_StartLoadCustomAssets(onLoadCompleted);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D1F3 RID: 119283 RVA: 0x00928980 File Offset: 0x00926B80
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_IsLoadingCustomAssets(IntPtr l)
	{
		int result;
		try
		{
			DialogUITask dialogUITask = (DialogUITask)LuaObject.checkSelf(l);
			bool b = dialogUITask.m_luaExportHelper.__callBase_IsLoadingCustomAssets();
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

	// Token: 0x0601D1F4 RID: 119284 RVA: 0x009289DC File Offset: 0x00926BDC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_IsPipeLineRunning(IntPtr l)
	{
		int result;
		try
		{
			DialogUITask dialogUITask = (DialogUITask)LuaObject.checkSelf(l);
			bool b = dialogUITask.m_luaExportHelper.__callBase_IsPipeLineRunning();
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

	// Token: 0x0601D1F5 RID: 119285 RVA: 0x00928A38 File Offset: 0x00926C38
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_IsOpeningUI(IntPtr l)
	{
		int result;
		try
		{
			DialogUITask dialogUITask = (DialogUITask)LuaObject.checkSelf(l);
			bool b = dialogUITask.m_luaExportHelper.__callBase_IsOpeningUI();
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

	// Token: 0x0601D1F6 RID: 119286 RVA: 0x00928A94 File Offset: 0x00926C94
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_ReturnPrevUITask(IntPtr l)
	{
		int result;
		try
		{
			DialogUITask dialogUITask = (DialogUITask)LuaObject.checkSelf(l);
			UITaskBase o = dialogUITask.m_luaExportHelper.__callBase_ReturnPrevUITask();
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

	// Token: 0x0601D1F7 RID: 119287 RVA: 0x00928AF0 File Offset: 0x00926CF0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_ClearUnusedDynamicResourceCache(IntPtr l)
	{
		int result;
		try
		{
			DialogUITask dialogUITask = (DialogUITask)LuaObject.checkSelf(l);
			dialogUITask.m_luaExportHelper.__callBase_ClearUnusedDynamicResourceCache();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D1F8 RID: 119288 RVA: 0x00928B44 File Offset: 0x00926D44
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_OnMemoryWarning(IntPtr l)
	{
		int result;
		try
		{
			DialogUITask dialogUITask = (DialogUITask)LuaObject.checkSelf(l);
			dialogUITask.m_luaExportHelper.__callBase_OnMemoryWarning();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D1F9 RID: 119289 RVA: 0x00928B98 File Offset: 0x00926D98
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callDele_EventOnClose(IntPtr l)
	{
		int result;
		try
		{
			DialogUITask dialogUITask = (DialogUITask)LuaObject.checkSelf(l);
			bool obj;
			LuaObject.checkType(l, 2, out obj);
			dialogUITask.m_luaExportHelper.__callDele_EventOnClose(obj);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D1FA RID: 119290 RVA: 0x00928BF4 File Offset: 0x00926DF4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __clearDele_EventOnClose(IntPtr l)
	{
		int result;
		try
		{
			DialogUITask dialogUITask = (DialogUITask)LuaObject.checkSelf(l);
			bool obj;
			LuaObject.checkType(l, 2, out obj);
			dialogUITask.m_luaExportHelper.__clearDele_EventOnClose(obj);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D1FB RID: 119291 RVA: 0x00928C50 File Offset: 0x00926E50
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_EventOnClose(IntPtr l)
	{
		int result;
		try
		{
			DialogUITask dialogUITask = (DialogUITask)LuaObject.checkSelf(l);
			Action<bool> value;
			int num = LuaObject.checkDelegate<Action<bool>>(l, 2, out value);
			if (num != 0)
			{
				if (num == 1)
				{
					dialogUITask.EventOnClose += value;
				}
				else if (num == 2)
				{
					dialogUITask.EventOnClose -= value;
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

	// Token: 0x0601D1FC RID: 119292 RVA: 0x00928CD0 File Offset: 0x00926ED0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_layerDescArray(IntPtr l)
	{
		int result;
		try
		{
			DialogUITask dialogUITask = (DialogUITask)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, dialogUITask.m_luaExportHelper.m_layerDescArray);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D1FD RID: 119293 RVA: 0x00928D28 File Offset: 0x00926F28
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_layerDescArray(IntPtr l)
	{
		int result;
		try
		{
			DialogUITask dialogUITask = (DialogUITask)LuaObject.checkSelf(l);
			UITaskBase.LayerDesc[] layerDescArray;
			LuaObject.checkArray<UITaskBase.LayerDesc>(l, 2, out layerDescArray);
			dialogUITask.m_luaExportHelper.m_layerDescArray = layerDescArray;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D1FE RID: 119294 RVA: 0x00928D84 File Offset: 0x00926F84
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_m_uiCtrlDescArray(IntPtr l)
	{
		int result;
		try
		{
			DialogUITask dialogUITask = (DialogUITask)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, dialogUITask.m_luaExportHelper.m_uiCtrlDescArray);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D1FF RID: 119295 RVA: 0x00928DDC File Offset: 0x00926FDC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_uiCtrlDescArray(IntPtr l)
	{
		int result;
		try
		{
			DialogUITask dialogUITask = (DialogUITask)LuaObject.checkSelf(l);
			UITaskBase.UIControllerDesc[] uiCtrlDescArray;
			LuaObject.checkArray<UITaskBase.UIControllerDesc>(l, 2, out uiCtrlDescArray);
			dialogUITask.m_luaExportHelper.m_uiCtrlDescArray = uiCtrlDescArray;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D200 RID: 119296 RVA: 0x00928E38 File Offset: 0x00927038
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_dialogUIController(IntPtr l)
	{
		int result;
		try
		{
			DialogUITask dialogUITask = (DialogUITask)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, dialogUITask.m_luaExportHelper.m_dialogUIController);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D201 RID: 119297 RVA: 0x00928E90 File Offset: 0x00927090
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_dialogUIController(IntPtr l)
	{
		int result;
		try
		{
			DialogUITask dialogUITask = (DialogUITask)LuaObject.checkSelf(l);
			DialogUIController dialogUIController;
			LuaObject.checkType<DialogUIController>(l, 2, out dialogUIController);
			dialogUITask.m_luaExportHelper.m_dialogUIController = dialogUIController;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D202 RID: 119298 RVA: 0x00928EEC File Offset: 0x009270EC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_dialogInfo(IntPtr l)
	{
		int result;
		try
		{
			DialogUITask dialogUITask = (DialogUITask)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, dialogUITask.m_luaExportHelper.m_dialogInfo);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D203 RID: 119299 RVA: 0x00928F44 File Offset: 0x00927144
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_dialogInfo(IntPtr l)
	{
		int result;
		try
		{
			DialogUITask dialogUITask = (DialogUITask)LuaObject.checkSelf(l);
			ConfigDataDialogInfo dialogInfo;
			LuaObject.checkType<ConfigDataDialogInfo>(l, 2, out dialogInfo);
			dialogUITask.m_luaExportHelper.m_dialogInfo = dialogInfo;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D204 RID: 119300 RVA: 0x00928FA0 File Offset: 0x009271A0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_needBGChangeTween(IntPtr l)
	{
		int result;
		try
		{
			DialogUITask dialogUITask = (DialogUITask)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, dialogUITask.m_luaExportHelper.m_needBGChangeTween);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D205 RID: 119301 RVA: 0x00928FF8 File Offset: 0x009271F8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_needBGChangeTween(IntPtr l)
	{
		int result;
		try
		{
			DialogUITask dialogUITask = (DialogUITask)LuaObject.checkSelf(l);
			bool needBGChangeTween;
			LuaObject.checkType(l, 2, out needBGChangeTween);
			dialogUITask.m_luaExportHelper.m_needBGChangeTween = needBGChangeTween;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D206 RID: 119302 RVA: 0x00929054 File Offset: 0x00927254
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_isSkipClose(IntPtr l)
	{
		int result;
		try
		{
			DialogUITask dialogUITask = (DialogUITask)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, dialogUITask.m_luaExportHelper.m_isSkipClose);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D207 RID: 119303 RVA: 0x009290AC File Offset: 0x009272AC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_isSkipClose(IntPtr l)
	{
		int result;
		try
		{
			DialogUITask dialogUITask = (DialogUITask)LuaObject.checkSelf(l);
			bool isSkipClose;
			LuaObject.checkType(l, 2, out isSkipClose);
			dialogUITask.m_luaExportHelper.m_isSkipClose = isSkipClose;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D208 RID: 119304 RVA: 0x00929108 File Offset: 0x00927308
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_LayerDescArray(IntPtr l)
	{
		int result;
		try
		{
			DialogUITask dialogUITask = (DialogUITask)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, dialogUITask.m_luaExportHelper.LayerDescArray);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D209 RID: 119305 RVA: 0x00929160 File Offset: 0x00927360
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_UICtrlDescArray(IntPtr l)
	{
		int result;
		try
		{
			DialogUITask dialogUITask = (DialogUITask)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, dialogUITask.m_luaExportHelper.UICtrlDescArray);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D20A RID: 119306 RVA: 0x009291B8 File Offset: 0x009273B8
	[Preserve]
	public static void reg(IntPtr l)
	{
		LuaObject.getTypeTable(l, "BlackJack.ProjectL.UI.DialogUITask");
		if (Lua_BlackJack_ProjectL_UI_DialogUITask.<>f__mg$cache0 == null)
		{
			Lua_BlackJack_ProjectL_UI_DialogUITask.<>f__mg$cache0 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_DialogUITask.OnStart);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_DialogUITask.<>f__mg$cache0);
		if (Lua_BlackJack_ProjectL_UI_DialogUITask.<>f__mg$cache1 == null)
		{
			Lua_BlackJack_ProjectL_UI_DialogUITask.<>f__mg$cache1 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_DialogUITask.OnResume);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_DialogUITask.<>f__mg$cache1);
		if (Lua_BlackJack_ProjectL_UI_DialogUITask.<>f__mg$cache2 == null)
		{
			Lua_BlackJack_ProjectL_UI_DialogUITask.<>f__mg$cache2 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_DialogUITask.InitDataFromUIIntent);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_DialogUITask.<>f__mg$cache2);
		if (Lua_BlackJack_ProjectL_UI_DialogUITask.<>f__mg$cache3 == null)
		{
			Lua_BlackJack_ProjectL_UI_DialogUITask.<>f__mg$cache3 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_DialogUITask.IsNeedLoadDynamicRes);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_DialogUITask.<>f__mg$cache3);
		if (Lua_BlackJack_ProjectL_UI_DialogUITask.<>f__mg$cache4 == null)
		{
			Lua_BlackJack_ProjectL_UI_DialogUITask.<>f__mg$cache4 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_DialogUITask.InitAllUIControllers);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_DialogUITask.<>f__mg$cache4);
		if (Lua_BlackJack_ProjectL_UI_DialogUITask.<>f__mg$cache5 == null)
		{
			Lua_BlackJack_ProjectL_UI_DialogUITask.<>f__mg$cache5 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_DialogUITask.ClearAllContextAndRes);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_DialogUITask.<>f__mg$cache5);
		if (Lua_BlackJack_ProjectL_UI_DialogUITask.<>f__mg$cache6 == null)
		{
			Lua_BlackJack_ProjectL_UI_DialogUITask.<>f__mg$cache6 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_DialogUITask.OnMemoryWarning);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_DialogUITask.<>f__mg$cache6);
		if (Lua_BlackJack_ProjectL_UI_DialogUITask.<>f__mg$cache7 == null)
		{
			Lua_BlackJack_ProjectL_UI_DialogUITask.<>f__mg$cache7 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_DialogUITask.UpdateView);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_DialogUITask.<>f__mg$cache7);
		if (Lua_BlackJack_ProjectL_UI_DialogUITask.<>f__mg$cache8 == null)
		{
			Lua_BlackJack_ProjectL_UI_DialogUITask.<>f__mg$cache8 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_DialogUITask.InitDialogUIController);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_DialogUITask.<>f__mg$cache8);
		if (Lua_BlackJack_ProjectL_UI_DialogUITask.<>f__mg$cache9 == null)
		{
			Lua_BlackJack_ProjectL_UI_DialogUITask.<>f__mg$cache9 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_DialogUITask.UninitDialogUIController);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_DialogUITask.<>f__mg$cache9);
		if (Lua_BlackJack_ProjectL_UI_DialogUITask.<>f__mg$cacheA == null)
		{
			Lua_BlackJack_ProjectL_UI_DialogUITask.<>f__mg$cacheA = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_DialogUITask.DialogUIController_OnSkip);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_DialogUITask.<>f__mg$cacheA);
		if (Lua_BlackJack_ProjectL_UI_DialogUITask.<>f__mg$cacheB == null)
		{
			Lua_BlackJack_ProjectL_UI_DialogUITask.<>f__mg$cacheB = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_DialogUITask.SkipDialogDialogBoxCallback);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_DialogUITask.<>f__mg$cacheB);
		if (Lua_BlackJack_ProjectL_UI_DialogUITask.<>f__mg$cacheC == null)
		{
			Lua_BlackJack_ProjectL_UI_DialogUITask.<>f__mg$cacheC = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_DialogUITask.DialogUIController_OnNext);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_DialogUITask.<>f__mg$cacheC);
		if (Lua_BlackJack_ProjectL_UI_DialogUITask.<>f__mg$cacheD == null)
		{
			Lua_BlackJack_ProjectL_UI_DialogUITask.<>f__mg$cacheD = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_DialogUITask.DialogUIController_OnClose);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_DialogUITask.<>f__mg$cacheD);
		if (Lua_BlackJack_ProjectL_UI_DialogUITask.<>f__mg$cacheE == null)
		{
			Lua_BlackJack_ProjectL_UI_DialogUITask.<>f__mg$cacheE = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_DialogUITask.__callBase_OnStart);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_DialogUITask.<>f__mg$cacheE);
		if (Lua_BlackJack_ProjectL_UI_DialogUITask.<>f__mg$cacheF == null)
		{
			Lua_BlackJack_ProjectL_UI_DialogUITask.<>f__mg$cacheF = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_DialogUITask.__callBase_OnStop);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_DialogUITask.<>f__mg$cacheF);
		if (Lua_BlackJack_ProjectL_UI_DialogUITask.<>f__mg$cache10 == null)
		{
			Lua_BlackJack_ProjectL_UI_DialogUITask.<>f__mg$cache10 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_DialogUITask.__callBase_OnPause);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_DialogUITask.<>f__mg$cache10);
		if (Lua_BlackJack_ProjectL_UI_DialogUITask.<>f__mg$cache11 == null)
		{
			Lua_BlackJack_ProjectL_UI_DialogUITask.<>f__mg$cache11 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_DialogUITask.__callBase_OnResume);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_DialogUITask.<>f__mg$cache11);
		if (Lua_BlackJack_ProjectL_UI_DialogUITask.<>f__mg$cache12 == null)
		{
			Lua_BlackJack_ProjectL_UI_DialogUITask.<>f__mg$cache12 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_DialogUITask.__callBase_OnNewIntent);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_DialogUITask.<>f__mg$cache12);
		if (Lua_BlackJack_ProjectL_UI_DialogUITask.<>f__mg$cache13 == null)
		{
			Lua_BlackJack_ProjectL_UI_DialogUITask.<>f__mg$cache13 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_DialogUITask.__callBase_EnableUIInput);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_DialogUITask.<>f__mg$cache13);
		if (Lua_BlackJack_ProjectL_UI_DialogUITask.<>f__mg$cache14 == null)
		{
			Lua_BlackJack_ProjectL_UI_DialogUITask.<>f__mg$cache14 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_DialogUITask.__callBase_IsNeedLoadDynamicRes);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_DialogUITask.<>f__mg$cache14);
		if (Lua_BlackJack_ProjectL_UI_DialogUITask.<>f__mg$cache15 == null)
		{
			Lua_BlackJack_ProjectL_UI_DialogUITask.<>f__mg$cache15 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_DialogUITask.__callBase_CollectAllDynamicResForLoad);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_DialogUITask.<>f__mg$cache15);
		if (Lua_BlackJack_ProjectL_UI_DialogUITask.<>f__mg$cache16 == null)
		{
			Lua_BlackJack_ProjectL_UI_DialogUITask.<>f__mg$cache16 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_DialogUITask.__callBase_RegisterPlayerContextEvents);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_DialogUITask.<>f__mg$cache16);
		if (Lua_BlackJack_ProjectL_UI_DialogUITask.<>f__mg$cache17 == null)
		{
			Lua_BlackJack_ProjectL_UI_DialogUITask.<>f__mg$cache17 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_DialogUITask.__callBase_UnregisterPlayerContextEvents);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_DialogUITask.<>f__mg$cache17);
		if (Lua_BlackJack_ProjectL_UI_DialogUITask.<>f__mg$cache18 == null)
		{
			Lua_BlackJack_ProjectL_UI_DialogUITask.<>f__mg$cache18 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_DialogUITask.__callBase_PostUpdateView);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_DialogUITask.<>f__mg$cache18);
		if (Lua_BlackJack_ProjectL_UI_DialogUITask.<>f__mg$cache19 == null)
		{
			Lua_BlackJack_ProjectL_UI_DialogUITask.<>f__mg$cache19 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_DialogUITask.__callBase_CollectPreloadResourceList);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_DialogUITask.<>f__mg$cache19);
		if (Lua_BlackJack_ProjectL_UI_DialogUITask.<>f__mg$cache1A == null)
		{
			Lua_BlackJack_ProjectL_UI_DialogUITask.<>f__mg$cache1A = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_DialogUITask.__callBase_ClearAssetList);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_DialogUITask.<>f__mg$cache1A);
		if (Lua_BlackJack_ProjectL_UI_DialogUITask.<>f__mg$cache1B == null)
		{
			Lua_BlackJack_ProjectL_UI_DialogUITask.<>f__mg$cache1B = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_DialogUITask.__callBase_CollectAsset);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_DialogUITask.<>f__mg$cache1B);
		if (Lua_BlackJack_ProjectL_UI_DialogUITask.<>f__mg$cache1C == null)
		{
			Lua_BlackJack_ProjectL_UI_DialogUITask.<>f__mg$cache1C = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_DialogUITask.__callBase_CollectSpriteAsset);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_DialogUITask.<>f__mg$cache1C);
		if (Lua_BlackJack_ProjectL_UI_DialogUITask.<>f__mg$cache1D == null)
		{
			Lua_BlackJack_ProjectL_UI_DialogUITask.<>f__mg$cache1D = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_DialogUITask.__callBase_CollectFxAsset);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_DialogUITask.<>f__mg$cache1D);
		if (Lua_BlackJack_ProjectL_UI_DialogUITask.<>f__mg$cache1E == null)
		{
			Lua_BlackJack_ProjectL_UI_DialogUITask.<>f__mg$cache1E = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_DialogUITask.__callBase_StartLoadCustomAssets);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_DialogUITask.<>f__mg$cache1E);
		if (Lua_BlackJack_ProjectL_UI_DialogUITask.<>f__mg$cache1F == null)
		{
			Lua_BlackJack_ProjectL_UI_DialogUITask.<>f__mg$cache1F = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_DialogUITask.__callBase_IsLoadingCustomAssets);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_DialogUITask.<>f__mg$cache1F);
		if (Lua_BlackJack_ProjectL_UI_DialogUITask.<>f__mg$cache20 == null)
		{
			Lua_BlackJack_ProjectL_UI_DialogUITask.<>f__mg$cache20 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_DialogUITask.__callBase_IsPipeLineRunning);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_DialogUITask.<>f__mg$cache20);
		if (Lua_BlackJack_ProjectL_UI_DialogUITask.<>f__mg$cache21 == null)
		{
			Lua_BlackJack_ProjectL_UI_DialogUITask.<>f__mg$cache21 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_DialogUITask.__callBase_IsOpeningUI);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_DialogUITask.<>f__mg$cache21);
		if (Lua_BlackJack_ProjectL_UI_DialogUITask.<>f__mg$cache22 == null)
		{
			Lua_BlackJack_ProjectL_UI_DialogUITask.<>f__mg$cache22 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_DialogUITask.__callBase_ReturnPrevUITask);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_DialogUITask.<>f__mg$cache22);
		if (Lua_BlackJack_ProjectL_UI_DialogUITask.<>f__mg$cache23 == null)
		{
			Lua_BlackJack_ProjectL_UI_DialogUITask.<>f__mg$cache23 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_DialogUITask.__callBase_ClearUnusedDynamicResourceCache);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_DialogUITask.<>f__mg$cache23);
		if (Lua_BlackJack_ProjectL_UI_DialogUITask.<>f__mg$cache24 == null)
		{
			Lua_BlackJack_ProjectL_UI_DialogUITask.<>f__mg$cache24 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_DialogUITask.__callBase_OnMemoryWarning);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_DialogUITask.<>f__mg$cache24);
		if (Lua_BlackJack_ProjectL_UI_DialogUITask.<>f__mg$cache25 == null)
		{
			Lua_BlackJack_ProjectL_UI_DialogUITask.<>f__mg$cache25 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_DialogUITask.__callDele_EventOnClose);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_DialogUITask.<>f__mg$cache25);
		if (Lua_BlackJack_ProjectL_UI_DialogUITask.<>f__mg$cache26 == null)
		{
			Lua_BlackJack_ProjectL_UI_DialogUITask.<>f__mg$cache26 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_DialogUITask.__clearDele_EventOnClose);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_DialogUITask.<>f__mg$cache26);
		string name = "EventOnClose";
		LuaCSFunction get = null;
		if (Lua_BlackJack_ProjectL_UI_DialogUITask.<>f__mg$cache27 == null)
		{
			Lua_BlackJack_ProjectL_UI_DialogUITask.<>f__mg$cache27 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_DialogUITask.set_EventOnClose);
		}
		LuaObject.addMember(l, name, get, Lua_BlackJack_ProjectL_UI_DialogUITask.<>f__mg$cache27, true);
		string name2 = "m_layerDescArray";
		if (Lua_BlackJack_ProjectL_UI_DialogUITask.<>f__mg$cache28 == null)
		{
			Lua_BlackJack_ProjectL_UI_DialogUITask.<>f__mg$cache28 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_DialogUITask.get_m_layerDescArray);
		}
		LuaCSFunction get2 = Lua_BlackJack_ProjectL_UI_DialogUITask.<>f__mg$cache28;
		if (Lua_BlackJack_ProjectL_UI_DialogUITask.<>f__mg$cache29 == null)
		{
			Lua_BlackJack_ProjectL_UI_DialogUITask.<>f__mg$cache29 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_DialogUITask.set_m_layerDescArray);
		}
		LuaObject.addMember(l, name2, get2, Lua_BlackJack_ProjectL_UI_DialogUITask.<>f__mg$cache29, true);
		string name3 = "m_uiCtrlDescArray";
		if (Lua_BlackJack_ProjectL_UI_DialogUITask.<>f__mg$cache2A == null)
		{
			Lua_BlackJack_ProjectL_UI_DialogUITask.<>f__mg$cache2A = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_DialogUITask.get_m_uiCtrlDescArray);
		}
		LuaCSFunction get3 = Lua_BlackJack_ProjectL_UI_DialogUITask.<>f__mg$cache2A;
		if (Lua_BlackJack_ProjectL_UI_DialogUITask.<>f__mg$cache2B == null)
		{
			Lua_BlackJack_ProjectL_UI_DialogUITask.<>f__mg$cache2B = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_DialogUITask.set_m_uiCtrlDescArray);
		}
		LuaObject.addMember(l, name3, get3, Lua_BlackJack_ProjectL_UI_DialogUITask.<>f__mg$cache2B, true);
		string name4 = "m_dialogUIController";
		if (Lua_BlackJack_ProjectL_UI_DialogUITask.<>f__mg$cache2C == null)
		{
			Lua_BlackJack_ProjectL_UI_DialogUITask.<>f__mg$cache2C = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_DialogUITask.get_m_dialogUIController);
		}
		LuaCSFunction get4 = Lua_BlackJack_ProjectL_UI_DialogUITask.<>f__mg$cache2C;
		if (Lua_BlackJack_ProjectL_UI_DialogUITask.<>f__mg$cache2D == null)
		{
			Lua_BlackJack_ProjectL_UI_DialogUITask.<>f__mg$cache2D = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_DialogUITask.set_m_dialogUIController);
		}
		LuaObject.addMember(l, name4, get4, Lua_BlackJack_ProjectL_UI_DialogUITask.<>f__mg$cache2D, true);
		string name5 = "m_dialogInfo";
		if (Lua_BlackJack_ProjectL_UI_DialogUITask.<>f__mg$cache2E == null)
		{
			Lua_BlackJack_ProjectL_UI_DialogUITask.<>f__mg$cache2E = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_DialogUITask.get_m_dialogInfo);
		}
		LuaCSFunction get5 = Lua_BlackJack_ProjectL_UI_DialogUITask.<>f__mg$cache2E;
		if (Lua_BlackJack_ProjectL_UI_DialogUITask.<>f__mg$cache2F == null)
		{
			Lua_BlackJack_ProjectL_UI_DialogUITask.<>f__mg$cache2F = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_DialogUITask.set_m_dialogInfo);
		}
		LuaObject.addMember(l, name5, get5, Lua_BlackJack_ProjectL_UI_DialogUITask.<>f__mg$cache2F, true);
		string name6 = "m_needBGChangeTween";
		if (Lua_BlackJack_ProjectL_UI_DialogUITask.<>f__mg$cache30 == null)
		{
			Lua_BlackJack_ProjectL_UI_DialogUITask.<>f__mg$cache30 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_DialogUITask.get_m_needBGChangeTween);
		}
		LuaCSFunction get6 = Lua_BlackJack_ProjectL_UI_DialogUITask.<>f__mg$cache30;
		if (Lua_BlackJack_ProjectL_UI_DialogUITask.<>f__mg$cache31 == null)
		{
			Lua_BlackJack_ProjectL_UI_DialogUITask.<>f__mg$cache31 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_DialogUITask.set_m_needBGChangeTween);
		}
		LuaObject.addMember(l, name6, get6, Lua_BlackJack_ProjectL_UI_DialogUITask.<>f__mg$cache31, true);
		string name7 = "m_isSkipClose";
		if (Lua_BlackJack_ProjectL_UI_DialogUITask.<>f__mg$cache32 == null)
		{
			Lua_BlackJack_ProjectL_UI_DialogUITask.<>f__mg$cache32 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_DialogUITask.get_m_isSkipClose);
		}
		LuaCSFunction get7 = Lua_BlackJack_ProjectL_UI_DialogUITask.<>f__mg$cache32;
		if (Lua_BlackJack_ProjectL_UI_DialogUITask.<>f__mg$cache33 == null)
		{
			Lua_BlackJack_ProjectL_UI_DialogUITask.<>f__mg$cache33 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_DialogUITask.set_m_isSkipClose);
		}
		LuaObject.addMember(l, name7, get7, Lua_BlackJack_ProjectL_UI_DialogUITask.<>f__mg$cache33, true);
		string name8 = "LayerDescArray";
		if (Lua_BlackJack_ProjectL_UI_DialogUITask.<>f__mg$cache34 == null)
		{
			Lua_BlackJack_ProjectL_UI_DialogUITask.<>f__mg$cache34 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_DialogUITask.get_LayerDescArray);
		}
		LuaObject.addMember(l, name8, Lua_BlackJack_ProjectL_UI_DialogUITask.<>f__mg$cache34, null, true);
		string name9 = "UICtrlDescArray";
		if (Lua_BlackJack_ProjectL_UI_DialogUITask.<>f__mg$cache35 == null)
		{
			Lua_BlackJack_ProjectL_UI_DialogUITask.<>f__mg$cache35 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_DialogUITask.get_UICtrlDescArray);
		}
		LuaObject.addMember(l, name9, Lua_BlackJack_ProjectL_UI_DialogUITask.<>f__mg$cache35, null, true);
		if (Lua_BlackJack_ProjectL_UI_DialogUITask.<>f__mg$cache36 == null)
		{
			Lua_BlackJack_ProjectL_UI_DialogUITask.<>f__mg$cache36 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_DialogUITask.constructor);
		}
		LuaObject.createTypeMetatable(l, Lua_BlackJack_ProjectL_UI_DialogUITask.<>f__mg$cache36, typeof(DialogUITask), typeof(UITask));
	}

	// Token: 0x04013387 RID: 78727
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache0;

	// Token: 0x04013388 RID: 78728
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1;

	// Token: 0x04013389 RID: 78729
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2;

	// Token: 0x0401338A RID: 78730
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3;

	// Token: 0x0401338B RID: 78731
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache4;

	// Token: 0x0401338C RID: 78732
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache5;

	// Token: 0x0401338D RID: 78733
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache6;

	// Token: 0x0401338E RID: 78734
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache7;

	// Token: 0x0401338F RID: 78735
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache8;

	// Token: 0x04013390 RID: 78736
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache9;

	// Token: 0x04013391 RID: 78737
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheA;

	// Token: 0x04013392 RID: 78738
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheB;

	// Token: 0x04013393 RID: 78739
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheC;

	// Token: 0x04013394 RID: 78740
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheD;

	// Token: 0x04013395 RID: 78741
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheE;

	// Token: 0x04013396 RID: 78742
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheF;

	// Token: 0x04013397 RID: 78743
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache10;

	// Token: 0x04013398 RID: 78744
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache11;

	// Token: 0x04013399 RID: 78745
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache12;

	// Token: 0x0401339A RID: 78746
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache13;

	// Token: 0x0401339B RID: 78747
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache14;

	// Token: 0x0401339C RID: 78748
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache15;

	// Token: 0x0401339D RID: 78749
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache16;

	// Token: 0x0401339E RID: 78750
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache17;

	// Token: 0x0401339F RID: 78751
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache18;

	// Token: 0x040133A0 RID: 78752
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache19;

	// Token: 0x040133A1 RID: 78753
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1A;

	// Token: 0x040133A2 RID: 78754
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1B;

	// Token: 0x040133A3 RID: 78755
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1C;

	// Token: 0x040133A4 RID: 78756
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1D;

	// Token: 0x040133A5 RID: 78757
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1E;

	// Token: 0x040133A6 RID: 78758
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1F;

	// Token: 0x040133A7 RID: 78759
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache20;

	// Token: 0x040133A8 RID: 78760
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache21;

	// Token: 0x040133A9 RID: 78761
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache22;

	// Token: 0x040133AA RID: 78762
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache23;

	// Token: 0x040133AB RID: 78763
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache24;

	// Token: 0x040133AC RID: 78764
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache25;

	// Token: 0x040133AD RID: 78765
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache26;

	// Token: 0x040133AE RID: 78766
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache27;

	// Token: 0x040133AF RID: 78767
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache28;

	// Token: 0x040133B0 RID: 78768
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache29;

	// Token: 0x040133B1 RID: 78769
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2A;

	// Token: 0x040133B2 RID: 78770
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2B;

	// Token: 0x040133B3 RID: 78771
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2C;

	// Token: 0x040133B4 RID: 78772
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2D;

	// Token: 0x040133B5 RID: 78773
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2E;

	// Token: 0x040133B6 RID: 78774
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2F;

	// Token: 0x040133B7 RID: 78775
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache30;

	// Token: 0x040133B8 RID: 78776
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache31;

	// Token: 0x040133B9 RID: 78777
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache32;

	// Token: 0x040133BA RID: 78778
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache33;

	// Token: 0x040133BB RID: 78779
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache34;

	// Token: 0x040133BC RID: 78780
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache35;

	// Token: 0x040133BD RID: 78781
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache36;
}
