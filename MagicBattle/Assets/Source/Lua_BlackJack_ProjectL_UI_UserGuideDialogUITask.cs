using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using BlackJack.BJFramework.Runtime.UI;
using BlackJack.ConfigData;
using BlackJack.ProjectL.UI;
using SLua;
using UnityEngine.Scripting;

// Token: 0x020015D4 RID: 5588
[Preserve]
public class Lua_BlackJack_ProjectL_UI_UserGuideDialogUITask : LuaObject
{
	// Token: 0x0602211C RID: 139548 RVA: 0x00B9E8D0 File Offset: 0x00B9CAD0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int constructor(IntPtr l)
	{
		int result;
		try
		{
			string name;
			LuaObject.checkType(l, 2, out name);
			UserGuideDialogUITask o = new UserGuideDialogUITask(name);
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

	// Token: 0x0602211D RID: 139549 RVA: 0x00B9E924 File Offset: 0x00B9CB24
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int OnStart(IntPtr l)
	{
		int result;
		try
		{
			UserGuideDialogUITask userGuideDialogUITask = (UserGuideDialogUITask)LuaObject.checkSelf(l);
			UIIntent intent;
			LuaObject.checkType<UIIntent>(l, 2, out intent);
			bool b = userGuideDialogUITask.m_luaExportHelper.OnStart(intent);
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

	// Token: 0x0602211E RID: 139550 RVA: 0x00B9E98C File Offset: 0x00B9CB8C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int OnResume(IntPtr l)
	{
		int result;
		try
		{
			UserGuideDialogUITask userGuideDialogUITask = (UserGuideDialogUITask)LuaObject.checkSelf(l);
			UIIntent intent;
			LuaObject.checkType<UIIntent>(l, 2, out intent);
			bool b = userGuideDialogUITask.m_luaExportHelper.OnResume(intent);
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

	// Token: 0x0602211F RID: 139551 RVA: 0x00B9E9F4 File Offset: 0x00B9CBF4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int InitDataFromUIIntent(IntPtr l)
	{
		int result;
		try
		{
			UserGuideDialogUITask userGuideDialogUITask = (UserGuideDialogUITask)LuaObject.checkSelf(l);
			UIIntent intent;
			LuaObject.checkType<UIIntent>(l, 2, out intent);
			userGuideDialogUITask.m_luaExportHelper.InitDataFromUIIntent(intent);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06022120 RID: 139552 RVA: 0x00B9EA50 File Offset: 0x00B9CC50
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int IsNeedLoadDynamicRes(IntPtr l)
	{
		int result;
		try
		{
			UserGuideDialogUITask userGuideDialogUITask = (UserGuideDialogUITask)LuaObject.checkSelf(l);
			bool b = userGuideDialogUITask.m_luaExportHelper.IsNeedLoadDynamicRes();
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

	// Token: 0x06022121 RID: 139553 RVA: 0x00B9EAAC File Offset: 0x00B9CCAC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int InitAllUIControllers(IntPtr l)
	{
		int result;
		try
		{
			UserGuideDialogUITask userGuideDialogUITask = (UserGuideDialogUITask)LuaObject.checkSelf(l);
			userGuideDialogUITask.m_luaExportHelper.InitAllUIControllers();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06022122 RID: 139554 RVA: 0x00B9EB00 File Offset: 0x00B9CD00
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int ClearAllContextAndRes(IntPtr l)
	{
		int result;
		try
		{
			UserGuideDialogUITask userGuideDialogUITask = (UserGuideDialogUITask)LuaObject.checkSelf(l);
			userGuideDialogUITask.m_luaExportHelper.ClearAllContextAndRes();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06022123 RID: 139555 RVA: 0x00B9EB54 File Offset: 0x00B9CD54
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int OnMemoryWarning(IntPtr l)
	{
		int result;
		try
		{
			UserGuideDialogUITask userGuideDialogUITask = (UserGuideDialogUITask)LuaObject.checkSelf(l);
			userGuideDialogUITask.m_luaExportHelper.OnMemoryWarning();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06022124 RID: 139556 RVA: 0x00B9EBA8 File Offset: 0x00B9CDA8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int UpdateView(IntPtr l)
	{
		int result;
		try
		{
			UserGuideDialogUITask userGuideDialogUITask = (UserGuideDialogUITask)LuaObject.checkSelf(l);
			userGuideDialogUITask.m_luaExportHelper.UpdateView();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06022125 RID: 139557 RVA: 0x00B9EBFC File Offset: 0x00B9CDFC
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int InitUserGuideDialogUIController(IntPtr l)
	{
		int result;
		try
		{
			UserGuideDialogUITask userGuideDialogUITask = (UserGuideDialogUITask)LuaObject.checkSelf(l);
			userGuideDialogUITask.m_luaExportHelper.InitUserGuideDialogUIController();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06022126 RID: 139558 RVA: 0x00B9EC50 File Offset: 0x00B9CE50
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int UninitUserGuideDialogUIController(IntPtr l)
	{
		int result;
		try
		{
			UserGuideDialogUITask userGuideDialogUITask = (UserGuideDialogUITask)LuaObject.checkSelf(l);
			userGuideDialogUITask.m_luaExportHelper.UninitUserGuideDialogUIController();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06022127 RID: 139559 RVA: 0x00B9ECA4 File Offset: 0x00B9CEA4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int UserGuideUIController_OnNext(IntPtr l)
	{
		int result;
		try
		{
			UserGuideDialogUITask userGuideDialogUITask = (UserGuideDialogUITask)LuaObject.checkSelf(l);
			userGuideDialogUITask.m_luaExportHelper.UserGuideUIController_OnNext();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06022128 RID: 139560 RVA: 0x00B9ECF8 File Offset: 0x00B9CEF8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int UserGuideUIController_OnClose(IntPtr l)
	{
		int result;
		try
		{
			UserGuideDialogUITask userGuideDialogUITask = (UserGuideDialogUITask)LuaObject.checkSelf(l);
			userGuideDialogUITask.m_luaExportHelper.UserGuideUIController_OnClose();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06022129 RID: 139561 RVA: 0x00B9ED4C File Offset: 0x00B9CF4C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_OnStart(IntPtr l)
	{
		int result;
		try
		{
			UserGuideDialogUITask userGuideDialogUITask = (UserGuideDialogUITask)LuaObject.checkSelf(l);
			UIIntent intent;
			LuaObject.checkType<UIIntent>(l, 2, out intent);
			bool b = userGuideDialogUITask.m_luaExportHelper.__callBase_OnStart(intent);
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

	// Token: 0x0602212A RID: 139562 RVA: 0x00B9EDB4 File Offset: 0x00B9CFB4
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int __callBase_OnStop(IntPtr l)
	{
		int result;
		try
		{
			UserGuideDialogUITask userGuideDialogUITask = (UserGuideDialogUITask)LuaObject.checkSelf(l);
			userGuideDialogUITask.m_luaExportHelper.__callBase_OnStop();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0602212B RID: 139563 RVA: 0x00B9EE08 File Offset: 0x00B9D008
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int __callBase_OnPause(IntPtr l)
	{
		int result;
		try
		{
			UserGuideDialogUITask userGuideDialogUITask = (UserGuideDialogUITask)LuaObject.checkSelf(l);
			userGuideDialogUITask.m_luaExportHelper.__callBase_OnPause();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0602212C RID: 139564 RVA: 0x00B9EE5C File Offset: 0x00B9D05C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_OnResume(IntPtr l)
	{
		int result;
		try
		{
			UserGuideDialogUITask userGuideDialogUITask = (UserGuideDialogUITask)LuaObject.checkSelf(l);
			UIIntent intent;
			LuaObject.checkType<UIIntent>(l, 2, out intent);
			bool b = userGuideDialogUITask.m_luaExportHelper.__callBase_OnResume(intent);
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

	// Token: 0x0602212D RID: 139565 RVA: 0x00B9EEC4 File Offset: 0x00B9D0C4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_OnNewIntent(IntPtr l)
	{
		int result;
		try
		{
			UserGuideDialogUITask userGuideDialogUITask = (UserGuideDialogUITask)LuaObject.checkSelf(l);
			UIIntent intent;
			LuaObject.checkType<UIIntent>(l, 2, out intent);
			bool b = userGuideDialogUITask.m_luaExportHelper.__callBase_OnNewIntent(intent);
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

	// Token: 0x0602212E RID: 139566 RVA: 0x00B9EF2C File Offset: 0x00B9D12C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_EnableUIInput(IntPtr l)
	{
		int result;
		try
		{
			UserGuideDialogUITask userGuideDialogUITask = (UserGuideDialogUITask)LuaObject.checkSelf(l);
			bool isEnable;
			LuaObject.checkType(l, 2, out isEnable);
			bool? isGlobalEnable;
			LuaObject.checkNullable<bool>(l, 3, out isGlobalEnable);
			userGuideDialogUITask.m_luaExportHelper.__callBase_EnableUIInput(isEnable, isGlobalEnable);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0602212F RID: 139567 RVA: 0x00B9EF98 File Offset: 0x00B9D198
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int __callBase_IsNeedLoadDynamicRes(IntPtr l)
	{
		int result;
		try
		{
			UserGuideDialogUITask userGuideDialogUITask = (UserGuideDialogUITask)LuaObject.checkSelf(l);
			bool b = userGuideDialogUITask.m_luaExportHelper.__callBase_IsNeedLoadDynamicRes();
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

	// Token: 0x06022130 RID: 139568 RVA: 0x00B9EFF4 File Offset: 0x00B9D1F4
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int __callBase_CollectAllDynamicResForLoad(IntPtr l)
	{
		int result;
		try
		{
			UserGuideDialogUITask userGuideDialogUITask = (UserGuideDialogUITask)LuaObject.checkSelf(l);
			List<string> o = userGuideDialogUITask.m_luaExportHelper.__callBase_CollectAllDynamicResForLoad();
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

	// Token: 0x06022131 RID: 139569 RVA: 0x00B9F050 File Offset: 0x00B9D250
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_RegisterPlayerContextEvents(IntPtr l)
	{
		int result;
		try
		{
			UserGuideDialogUITask userGuideDialogUITask = (UserGuideDialogUITask)LuaObject.checkSelf(l);
			userGuideDialogUITask.m_luaExportHelper.__callBase_RegisterPlayerContextEvents();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06022132 RID: 139570 RVA: 0x00B9F0A4 File Offset: 0x00B9D2A4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_UnregisterPlayerContextEvents(IntPtr l)
	{
		int result;
		try
		{
			UserGuideDialogUITask userGuideDialogUITask = (UserGuideDialogUITask)LuaObject.checkSelf(l);
			userGuideDialogUITask.m_luaExportHelper.__callBase_UnregisterPlayerContextEvents();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06022133 RID: 139571 RVA: 0x00B9F0F8 File Offset: 0x00B9D2F8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_PostUpdateView(IntPtr l)
	{
		int result;
		try
		{
			UserGuideDialogUITask userGuideDialogUITask = (UserGuideDialogUITask)LuaObject.checkSelf(l);
			userGuideDialogUITask.m_luaExportHelper.__callBase_PostUpdateView();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06022134 RID: 139572 RVA: 0x00B9F14C File Offset: 0x00B9D34C
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int __callBase_CollectPreloadResourceList(IntPtr l)
	{
		int result;
		try
		{
			UserGuideDialogUITask userGuideDialogUITask = (UserGuideDialogUITask)LuaObject.checkSelf(l);
			userGuideDialogUITask.m_luaExportHelper.__callBase_CollectPreloadResourceList();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06022135 RID: 139573 RVA: 0x00B9F1A0 File Offset: 0x00B9D3A0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_ClearAssetList(IntPtr l)
	{
		int result;
		try
		{
			UserGuideDialogUITask userGuideDialogUITask = (UserGuideDialogUITask)LuaObject.checkSelf(l);
			userGuideDialogUITask.m_luaExportHelper.__callBase_ClearAssetList();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06022136 RID: 139574 RVA: 0x00B9F1F4 File Offset: 0x00B9D3F4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_CollectAsset(IntPtr l)
	{
		int result;
		try
		{
			UserGuideDialogUITask userGuideDialogUITask = (UserGuideDialogUITask)LuaObject.checkSelf(l);
			string assetName;
			LuaObject.checkType(l, 2, out assetName);
			userGuideDialogUITask.m_luaExportHelper.__callBase_CollectAsset(assetName);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06022137 RID: 139575 RVA: 0x00B9F250 File Offset: 0x00B9D450
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_CollectSpriteAsset(IntPtr l)
	{
		int result;
		try
		{
			UserGuideDialogUITask userGuideDialogUITask = (UserGuideDialogUITask)LuaObject.checkSelf(l);
			string assetName;
			LuaObject.checkType(l, 2, out assetName);
			userGuideDialogUITask.m_luaExportHelper.__callBase_CollectSpriteAsset(assetName);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06022138 RID: 139576 RVA: 0x00B9F2AC File Offset: 0x00B9D4AC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_CollectFxAsset(IntPtr l)
	{
		int result;
		try
		{
			UserGuideDialogUITask userGuideDialogUITask = (UserGuideDialogUITask)LuaObject.checkSelf(l);
			string assetName;
			LuaObject.checkType(l, 2, out assetName);
			userGuideDialogUITask.m_luaExportHelper.__callBase_CollectFxAsset(assetName);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06022139 RID: 139577 RVA: 0x00B9F308 File Offset: 0x00B9D508
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_StartLoadCustomAssets(IntPtr l)
	{
		int result;
		try
		{
			UserGuideDialogUITask userGuideDialogUITask = (UserGuideDialogUITask)LuaObject.checkSelf(l);
			Action onLoadCompleted;
			LuaObject.checkDelegate<Action>(l, 2, out onLoadCompleted);
			userGuideDialogUITask.m_luaExportHelper.__callBase_StartLoadCustomAssets(onLoadCompleted);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0602213A RID: 139578 RVA: 0x00B9F364 File Offset: 0x00B9D564
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int __callBase_IsLoadingCustomAssets(IntPtr l)
	{
		int result;
		try
		{
			UserGuideDialogUITask userGuideDialogUITask = (UserGuideDialogUITask)LuaObject.checkSelf(l);
			bool b = userGuideDialogUITask.m_luaExportHelper.__callBase_IsLoadingCustomAssets();
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

	// Token: 0x0602213B RID: 139579 RVA: 0x00B9F3C0 File Offset: 0x00B9D5C0
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int __callBase_IsPipeLineRunning(IntPtr l)
	{
		int result;
		try
		{
			UserGuideDialogUITask userGuideDialogUITask = (UserGuideDialogUITask)LuaObject.checkSelf(l);
			bool b = userGuideDialogUITask.m_luaExportHelper.__callBase_IsPipeLineRunning();
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

	// Token: 0x0602213C RID: 139580 RVA: 0x00B9F41C File Offset: 0x00B9D61C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_IsOpeningUI(IntPtr l)
	{
		int result;
		try
		{
			UserGuideDialogUITask userGuideDialogUITask = (UserGuideDialogUITask)LuaObject.checkSelf(l);
			bool b = userGuideDialogUITask.m_luaExportHelper.__callBase_IsOpeningUI();
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

	// Token: 0x0602213D RID: 139581 RVA: 0x00B9F478 File Offset: 0x00B9D678
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_ReturnPrevUITask(IntPtr l)
	{
		int result;
		try
		{
			UserGuideDialogUITask userGuideDialogUITask = (UserGuideDialogUITask)LuaObject.checkSelf(l);
			UITaskBase o = userGuideDialogUITask.m_luaExportHelper.__callBase_ReturnPrevUITask();
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

	// Token: 0x0602213E RID: 139582 RVA: 0x00B9F4D4 File Offset: 0x00B9D6D4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_ClearUnusedDynamicResourceCache(IntPtr l)
	{
		int result;
		try
		{
			UserGuideDialogUITask userGuideDialogUITask = (UserGuideDialogUITask)LuaObject.checkSelf(l);
			userGuideDialogUITask.m_luaExportHelper.__callBase_ClearUnusedDynamicResourceCache();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0602213F RID: 139583 RVA: 0x00B9F528 File Offset: 0x00B9D728
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_OnMemoryWarning(IntPtr l)
	{
		int result;
		try
		{
			UserGuideDialogUITask userGuideDialogUITask = (UserGuideDialogUITask)LuaObject.checkSelf(l);
			userGuideDialogUITask.m_luaExportHelper.__callBase_OnMemoryWarning();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06022140 RID: 139584 RVA: 0x00B9F57C File Offset: 0x00B9D77C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callDele_EventOnClose(IntPtr l)
	{
		int result;
		try
		{
			UserGuideDialogUITask userGuideDialogUITask = (UserGuideDialogUITask)LuaObject.checkSelf(l);
			userGuideDialogUITask.m_luaExportHelper.__callDele_EventOnClose();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06022141 RID: 139585 RVA: 0x00B9F5D0 File Offset: 0x00B9D7D0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __clearDele_EventOnClose(IntPtr l)
	{
		int result;
		try
		{
			UserGuideDialogUITask userGuideDialogUITask = (UserGuideDialogUITask)LuaObject.checkSelf(l);
			userGuideDialogUITask.m_luaExportHelper.__clearDele_EventOnClose();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06022142 RID: 139586 RVA: 0x00B9F624 File Offset: 0x00B9D824
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callDele_EventOnUserGuideClose(IntPtr l)
	{
		int result;
		try
		{
			UserGuideDialogUITask userGuideDialogUITask = (UserGuideDialogUITask)LuaObject.checkSelf(l);
			userGuideDialogUITask.m_luaExportHelper.__callDele_EventOnUserGuideClose();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06022143 RID: 139587 RVA: 0x00B9F678 File Offset: 0x00B9D878
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __clearDele_EventOnUserGuideClose(IntPtr l)
	{
		int result;
		try
		{
			UserGuideDialogUITask userGuideDialogUITask = (UserGuideDialogUITask)LuaObject.checkSelf(l);
			userGuideDialogUITask.m_luaExportHelper.__clearDele_EventOnUserGuideClose();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06022144 RID: 139588 RVA: 0x00B9F6CC File Offset: 0x00B9D8CC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_EventOnClose(IntPtr l)
	{
		int result;
		try
		{
			UserGuideDialogUITask userGuideDialogUITask = (UserGuideDialogUITask)LuaObject.checkSelf(l);
			Action value;
			int num = LuaObject.checkDelegate<Action>(l, 2, out value);
			if (num != 0)
			{
				if (num == 1)
				{
					userGuideDialogUITask.EventOnClose += value;
				}
				else if (num == 2)
				{
					userGuideDialogUITask.EventOnClose -= value;
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

	// Token: 0x06022145 RID: 139589 RVA: 0x00B9F74C File Offset: 0x00B9D94C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_EventOnUserGuideClose(IntPtr l)
	{
		int result;
		try
		{
			UserGuideDialogUITask userGuideDialogUITask = (UserGuideDialogUITask)LuaObject.checkSelf(l);
			Action value;
			int num = LuaObject.checkDelegate<Action>(l, 2, out value);
			if (num != 0)
			{
				if (num == 1)
				{
					userGuideDialogUITask.EventOnUserGuideClose += value;
				}
				else if (num == 2)
				{
					userGuideDialogUITask.EventOnUserGuideClose -= value;
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

	// Token: 0x06022146 RID: 139590 RVA: 0x00B9F7CC File Offset: 0x00B9D9CC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_layerDescArray(IntPtr l)
	{
		int result;
		try
		{
			UserGuideDialogUITask userGuideDialogUITask = (UserGuideDialogUITask)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, userGuideDialogUITask.m_luaExportHelper.m_layerDescArray);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06022147 RID: 139591 RVA: 0x00B9F824 File Offset: 0x00B9DA24
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_layerDescArray(IntPtr l)
	{
		int result;
		try
		{
			UserGuideDialogUITask userGuideDialogUITask = (UserGuideDialogUITask)LuaObject.checkSelf(l);
			UITaskBase.LayerDesc[] layerDescArray;
			LuaObject.checkArray<UITaskBase.LayerDesc>(l, 2, out layerDescArray);
			userGuideDialogUITask.m_luaExportHelper.m_layerDescArray = layerDescArray;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06022148 RID: 139592 RVA: 0x00B9F880 File Offset: 0x00B9DA80
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_uiCtrlDescArray(IntPtr l)
	{
		int result;
		try
		{
			UserGuideDialogUITask userGuideDialogUITask = (UserGuideDialogUITask)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, userGuideDialogUITask.m_luaExportHelper.m_uiCtrlDescArray);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06022149 RID: 139593 RVA: 0x00B9F8D8 File Offset: 0x00B9DAD8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_uiCtrlDescArray(IntPtr l)
	{
		int result;
		try
		{
			UserGuideDialogUITask userGuideDialogUITask = (UserGuideDialogUITask)LuaObject.checkSelf(l);
			UITaskBase.UIControllerDesc[] uiCtrlDescArray;
			LuaObject.checkArray<UITaskBase.UIControllerDesc>(l, 2, out uiCtrlDescArray);
			userGuideDialogUITask.m_luaExportHelper.m_uiCtrlDescArray = uiCtrlDescArray;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0602214A RID: 139594 RVA: 0x00B9F934 File Offset: 0x00B9DB34
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_userGuideDialogUIController(IntPtr l)
	{
		int result;
		try
		{
			UserGuideDialogUITask userGuideDialogUITask = (UserGuideDialogUITask)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, userGuideDialogUITask.m_luaExportHelper.m_userGuideDialogUIController);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0602214B RID: 139595 RVA: 0x00B9F98C File Offset: 0x00B9DB8C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_userGuideDialogUIController(IntPtr l)
	{
		int result;
		try
		{
			UserGuideDialogUITask userGuideDialogUITask = (UserGuideDialogUITask)LuaObject.checkSelf(l);
			UserGuideDialogUIController userGuideDialogUIController;
			LuaObject.checkType<UserGuideDialogUIController>(l, 2, out userGuideDialogUIController);
			userGuideDialogUITask.m_luaExportHelper.m_userGuideDialogUIController = userGuideDialogUIController;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0602214C RID: 139596 RVA: 0x00B9F9E8 File Offset: 0x00B9DBE8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_userGuideDialogInfo(IntPtr l)
	{
		int result;
		try
		{
			UserGuideDialogUITask userGuideDialogUITask = (UserGuideDialogUITask)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, userGuideDialogUITask.m_luaExportHelper.m_userGuideDialogInfo);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0602214D RID: 139597 RVA: 0x00B9FA40 File Offset: 0x00B9DC40
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_userGuideDialogInfo(IntPtr l)
	{
		int result;
		try
		{
			UserGuideDialogUITask userGuideDialogUITask = (UserGuideDialogUITask)LuaObject.checkSelf(l);
			ConfigDataUserGuideDialogInfo userGuideDialogInfo;
			LuaObject.checkType<ConfigDataUserGuideDialogInfo>(l, 2, out userGuideDialogInfo);
			userGuideDialogUITask.m_luaExportHelper.m_userGuideDialogInfo = userGuideDialogInfo;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0602214E RID: 139598 RVA: 0x00B9FA9C File Offset: 0x00B9DC9C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_LayerDescArray(IntPtr l)
	{
		int result;
		try
		{
			UserGuideDialogUITask userGuideDialogUITask = (UserGuideDialogUITask)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, userGuideDialogUITask.m_luaExportHelper.LayerDescArray);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0602214F RID: 139599 RVA: 0x00B9FAF4 File Offset: 0x00B9DCF4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_UICtrlDescArray(IntPtr l)
	{
		int result;
		try
		{
			UserGuideDialogUITask userGuideDialogUITask = (UserGuideDialogUITask)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, userGuideDialogUITask.m_luaExportHelper.UICtrlDescArray);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06022150 RID: 139600 RVA: 0x00B9FB4C File Offset: 0x00B9DD4C
	[Preserve]
	public static void reg(IntPtr l)
	{
		LuaObject.getTypeTable(l, "BlackJack.ProjectL.UI.UserGuideDialogUITask");
		if (Lua_BlackJack_ProjectL_UI_UserGuideDialogUITask.<>f__mg$cache0 == null)
		{
			Lua_BlackJack_ProjectL_UI_UserGuideDialogUITask.<>f__mg$cache0 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_UserGuideDialogUITask.OnStart);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_UserGuideDialogUITask.<>f__mg$cache0);
		if (Lua_BlackJack_ProjectL_UI_UserGuideDialogUITask.<>f__mg$cache1 == null)
		{
			Lua_BlackJack_ProjectL_UI_UserGuideDialogUITask.<>f__mg$cache1 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_UserGuideDialogUITask.OnResume);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_UserGuideDialogUITask.<>f__mg$cache1);
		if (Lua_BlackJack_ProjectL_UI_UserGuideDialogUITask.<>f__mg$cache2 == null)
		{
			Lua_BlackJack_ProjectL_UI_UserGuideDialogUITask.<>f__mg$cache2 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_UserGuideDialogUITask.InitDataFromUIIntent);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_UserGuideDialogUITask.<>f__mg$cache2);
		if (Lua_BlackJack_ProjectL_UI_UserGuideDialogUITask.<>f__mg$cache3 == null)
		{
			Lua_BlackJack_ProjectL_UI_UserGuideDialogUITask.<>f__mg$cache3 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_UserGuideDialogUITask.IsNeedLoadDynamicRes);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_UserGuideDialogUITask.<>f__mg$cache3);
		if (Lua_BlackJack_ProjectL_UI_UserGuideDialogUITask.<>f__mg$cache4 == null)
		{
			Lua_BlackJack_ProjectL_UI_UserGuideDialogUITask.<>f__mg$cache4 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_UserGuideDialogUITask.InitAllUIControllers);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_UserGuideDialogUITask.<>f__mg$cache4);
		if (Lua_BlackJack_ProjectL_UI_UserGuideDialogUITask.<>f__mg$cache5 == null)
		{
			Lua_BlackJack_ProjectL_UI_UserGuideDialogUITask.<>f__mg$cache5 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_UserGuideDialogUITask.ClearAllContextAndRes);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_UserGuideDialogUITask.<>f__mg$cache5);
		if (Lua_BlackJack_ProjectL_UI_UserGuideDialogUITask.<>f__mg$cache6 == null)
		{
			Lua_BlackJack_ProjectL_UI_UserGuideDialogUITask.<>f__mg$cache6 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_UserGuideDialogUITask.OnMemoryWarning);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_UserGuideDialogUITask.<>f__mg$cache6);
		if (Lua_BlackJack_ProjectL_UI_UserGuideDialogUITask.<>f__mg$cache7 == null)
		{
			Lua_BlackJack_ProjectL_UI_UserGuideDialogUITask.<>f__mg$cache7 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_UserGuideDialogUITask.UpdateView);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_UserGuideDialogUITask.<>f__mg$cache7);
		if (Lua_BlackJack_ProjectL_UI_UserGuideDialogUITask.<>f__mg$cache8 == null)
		{
			Lua_BlackJack_ProjectL_UI_UserGuideDialogUITask.<>f__mg$cache8 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_UserGuideDialogUITask.InitUserGuideDialogUIController);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_UserGuideDialogUITask.<>f__mg$cache8);
		if (Lua_BlackJack_ProjectL_UI_UserGuideDialogUITask.<>f__mg$cache9 == null)
		{
			Lua_BlackJack_ProjectL_UI_UserGuideDialogUITask.<>f__mg$cache9 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_UserGuideDialogUITask.UninitUserGuideDialogUIController);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_UserGuideDialogUITask.<>f__mg$cache9);
		if (Lua_BlackJack_ProjectL_UI_UserGuideDialogUITask.<>f__mg$cacheA == null)
		{
			Lua_BlackJack_ProjectL_UI_UserGuideDialogUITask.<>f__mg$cacheA = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_UserGuideDialogUITask.UserGuideUIController_OnNext);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_UserGuideDialogUITask.<>f__mg$cacheA);
		if (Lua_BlackJack_ProjectL_UI_UserGuideDialogUITask.<>f__mg$cacheB == null)
		{
			Lua_BlackJack_ProjectL_UI_UserGuideDialogUITask.<>f__mg$cacheB = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_UserGuideDialogUITask.UserGuideUIController_OnClose);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_UserGuideDialogUITask.<>f__mg$cacheB);
		if (Lua_BlackJack_ProjectL_UI_UserGuideDialogUITask.<>f__mg$cacheC == null)
		{
			Lua_BlackJack_ProjectL_UI_UserGuideDialogUITask.<>f__mg$cacheC = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_UserGuideDialogUITask.__callBase_OnStart);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_UserGuideDialogUITask.<>f__mg$cacheC);
		if (Lua_BlackJack_ProjectL_UI_UserGuideDialogUITask.<>f__mg$cacheD == null)
		{
			Lua_BlackJack_ProjectL_UI_UserGuideDialogUITask.<>f__mg$cacheD = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_UserGuideDialogUITask.__callBase_OnStop);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_UserGuideDialogUITask.<>f__mg$cacheD);
		if (Lua_BlackJack_ProjectL_UI_UserGuideDialogUITask.<>f__mg$cacheE == null)
		{
			Lua_BlackJack_ProjectL_UI_UserGuideDialogUITask.<>f__mg$cacheE = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_UserGuideDialogUITask.__callBase_OnPause);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_UserGuideDialogUITask.<>f__mg$cacheE);
		if (Lua_BlackJack_ProjectL_UI_UserGuideDialogUITask.<>f__mg$cacheF == null)
		{
			Lua_BlackJack_ProjectL_UI_UserGuideDialogUITask.<>f__mg$cacheF = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_UserGuideDialogUITask.__callBase_OnResume);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_UserGuideDialogUITask.<>f__mg$cacheF);
		if (Lua_BlackJack_ProjectL_UI_UserGuideDialogUITask.<>f__mg$cache10 == null)
		{
			Lua_BlackJack_ProjectL_UI_UserGuideDialogUITask.<>f__mg$cache10 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_UserGuideDialogUITask.__callBase_OnNewIntent);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_UserGuideDialogUITask.<>f__mg$cache10);
		if (Lua_BlackJack_ProjectL_UI_UserGuideDialogUITask.<>f__mg$cache11 == null)
		{
			Lua_BlackJack_ProjectL_UI_UserGuideDialogUITask.<>f__mg$cache11 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_UserGuideDialogUITask.__callBase_EnableUIInput);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_UserGuideDialogUITask.<>f__mg$cache11);
		if (Lua_BlackJack_ProjectL_UI_UserGuideDialogUITask.<>f__mg$cache12 == null)
		{
			Lua_BlackJack_ProjectL_UI_UserGuideDialogUITask.<>f__mg$cache12 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_UserGuideDialogUITask.__callBase_IsNeedLoadDynamicRes);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_UserGuideDialogUITask.<>f__mg$cache12);
		if (Lua_BlackJack_ProjectL_UI_UserGuideDialogUITask.<>f__mg$cache13 == null)
		{
			Lua_BlackJack_ProjectL_UI_UserGuideDialogUITask.<>f__mg$cache13 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_UserGuideDialogUITask.__callBase_CollectAllDynamicResForLoad);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_UserGuideDialogUITask.<>f__mg$cache13);
		if (Lua_BlackJack_ProjectL_UI_UserGuideDialogUITask.<>f__mg$cache14 == null)
		{
			Lua_BlackJack_ProjectL_UI_UserGuideDialogUITask.<>f__mg$cache14 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_UserGuideDialogUITask.__callBase_RegisterPlayerContextEvents);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_UserGuideDialogUITask.<>f__mg$cache14);
		if (Lua_BlackJack_ProjectL_UI_UserGuideDialogUITask.<>f__mg$cache15 == null)
		{
			Lua_BlackJack_ProjectL_UI_UserGuideDialogUITask.<>f__mg$cache15 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_UserGuideDialogUITask.__callBase_UnregisterPlayerContextEvents);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_UserGuideDialogUITask.<>f__mg$cache15);
		if (Lua_BlackJack_ProjectL_UI_UserGuideDialogUITask.<>f__mg$cache16 == null)
		{
			Lua_BlackJack_ProjectL_UI_UserGuideDialogUITask.<>f__mg$cache16 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_UserGuideDialogUITask.__callBase_PostUpdateView);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_UserGuideDialogUITask.<>f__mg$cache16);
		if (Lua_BlackJack_ProjectL_UI_UserGuideDialogUITask.<>f__mg$cache17 == null)
		{
			Lua_BlackJack_ProjectL_UI_UserGuideDialogUITask.<>f__mg$cache17 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_UserGuideDialogUITask.__callBase_CollectPreloadResourceList);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_UserGuideDialogUITask.<>f__mg$cache17);
		if (Lua_BlackJack_ProjectL_UI_UserGuideDialogUITask.<>f__mg$cache18 == null)
		{
			Lua_BlackJack_ProjectL_UI_UserGuideDialogUITask.<>f__mg$cache18 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_UserGuideDialogUITask.__callBase_ClearAssetList);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_UserGuideDialogUITask.<>f__mg$cache18);
		if (Lua_BlackJack_ProjectL_UI_UserGuideDialogUITask.<>f__mg$cache19 == null)
		{
			Lua_BlackJack_ProjectL_UI_UserGuideDialogUITask.<>f__mg$cache19 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_UserGuideDialogUITask.__callBase_CollectAsset);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_UserGuideDialogUITask.<>f__mg$cache19);
		if (Lua_BlackJack_ProjectL_UI_UserGuideDialogUITask.<>f__mg$cache1A == null)
		{
			Lua_BlackJack_ProjectL_UI_UserGuideDialogUITask.<>f__mg$cache1A = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_UserGuideDialogUITask.__callBase_CollectSpriteAsset);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_UserGuideDialogUITask.<>f__mg$cache1A);
		if (Lua_BlackJack_ProjectL_UI_UserGuideDialogUITask.<>f__mg$cache1B == null)
		{
			Lua_BlackJack_ProjectL_UI_UserGuideDialogUITask.<>f__mg$cache1B = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_UserGuideDialogUITask.__callBase_CollectFxAsset);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_UserGuideDialogUITask.<>f__mg$cache1B);
		if (Lua_BlackJack_ProjectL_UI_UserGuideDialogUITask.<>f__mg$cache1C == null)
		{
			Lua_BlackJack_ProjectL_UI_UserGuideDialogUITask.<>f__mg$cache1C = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_UserGuideDialogUITask.__callBase_StartLoadCustomAssets);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_UserGuideDialogUITask.<>f__mg$cache1C);
		if (Lua_BlackJack_ProjectL_UI_UserGuideDialogUITask.<>f__mg$cache1D == null)
		{
			Lua_BlackJack_ProjectL_UI_UserGuideDialogUITask.<>f__mg$cache1D = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_UserGuideDialogUITask.__callBase_IsLoadingCustomAssets);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_UserGuideDialogUITask.<>f__mg$cache1D);
		if (Lua_BlackJack_ProjectL_UI_UserGuideDialogUITask.<>f__mg$cache1E == null)
		{
			Lua_BlackJack_ProjectL_UI_UserGuideDialogUITask.<>f__mg$cache1E = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_UserGuideDialogUITask.__callBase_IsPipeLineRunning);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_UserGuideDialogUITask.<>f__mg$cache1E);
		if (Lua_BlackJack_ProjectL_UI_UserGuideDialogUITask.<>f__mg$cache1F == null)
		{
			Lua_BlackJack_ProjectL_UI_UserGuideDialogUITask.<>f__mg$cache1F = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_UserGuideDialogUITask.__callBase_IsOpeningUI);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_UserGuideDialogUITask.<>f__mg$cache1F);
		if (Lua_BlackJack_ProjectL_UI_UserGuideDialogUITask.<>f__mg$cache20 == null)
		{
			Lua_BlackJack_ProjectL_UI_UserGuideDialogUITask.<>f__mg$cache20 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_UserGuideDialogUITask.__callBase_ReturnPrevUITask);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_UserGuideDialogUITask.<>f__mg$cache20);
		if (Lua_BlackJack_ProjectL_UI_UserGuideDialogUITask.<>f__mg$cache21 == null)
		{
			Lua_BlackJack_ProjectL_UI_UserGuideDialogUITask.<>f__mg$cache21 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_UserGuideDialogUITask.__callBase_ClearUnusedDynamicResourceCache);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_UserGuideDialogUITask.<>f__mg$cache21);
		if (Lua_BlackJack_ProjectL_UI_UserGuideDialogUITask.<>f__mg$cache22 == null)
		{
			Lua_BlackJack_ProjectL_UI_UserGuideDialogUITask.<>f__mg$cache22 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_UserGuideDialogUITask.__callBase_OnMemoryWarning);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_UserGuideDialogUITask.<>f__mg$cache22);
		if (Lua_BlackJack_ProjectL_UI_UserGuideDialogUITask.<>f__mg$cache23 == null)
		{
			Lua_BlackJack_ProjectL_UI_UserGuideDialogUITask.<>f__mg$cache23 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_UserGuideDialogUITask.__callDele_EventOnClose);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_UserGuideDialogUITask.<>f__mg$cache23);
		if (Lua_BlackJack_ProjectL_UI_UserGuideDialogUITask.<>f__mg$cache24 == null)
		{
			Lua_BlackJack_ProjectL_UI_UserGuideDialogUITask.<>f__mg$cache24 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_UserGuideDialogUITask.__clearDele_EventOnClose);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_UserGuideDialogUITask.<>f__mg$cache24);
		if (Lua_BlackJack_ProjectL_UI_UserGuideDialogUITask.<>f__mg$cache25 == null)
		{
			Lua_BlackJack_ProjectL_UI_UserGuideDialogUITask.<>f__mg$cache25 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_UserGuideDialogUITask.__callDele_EventOnUserGuideClose);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_UserGuideDialogUITask.<>f__mg$cache25);
		if (Lua_BlackJack_ProjectL_UI_UserGuideDialogUITask.<>f__mg$cache26 == null)
		{
			Lua_BlackJack_ProjectL_UI_UserGuideDialogUITask.<>f__mg$cache26 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_UserGuideDialogUITask.__clearDele_EventOnUserGuideClose);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_UserGuideDialogUITask.<>f__mg$cache26);
		string name = "EventOnClose";
		LuaCSFunction get = null;
		if (Lua_BlackJack_ProjectL_UI_UserGuideDialogUITask.<>f__mg$cache27 == null)
		{
			Lua_BlackJack_ProjectL_UI_UserGuideDialogUITask.<>f__mg$cache27 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_UserGuideDialogUITask.set_EventOnClose);
		}
		LuaObject.addMember(l, name, get, Lua_BlackJack_ProjectL_UI_UserGuideDialogUITask.<>f__mg$cache27, true);
		string name2 = "EventOnUserGuideClose";
		LuaCSFunction get2 = null;
		if (Lua_BlackJack_ProjectL_UI_UserGuideDialogUITask.<>f__mg$cache28 == null)
		{
			Lua_BlackJack_ProjectL_UI_UserGuideDialogUITask.<>f__mg$cache28 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_UserGuideDialogUITask.set_EventOnUserGuideClose);
		}
		LuaObject.addMember(l, name2, get2, Lua_BlackJack_ProjectL_UI_UserGuideDialogUITask.<>f__mg$cache28, true);
		string name3 = "m_layerDescArray";
		if (Lua_BlackJack_ProjectL_UI_UserGuideDialogUITask.<>f__mg$cache29 == null)
		{
			Lua_BlackJack_ProjectL_UI_UserGuideDialogUITask.<>f__mg$cache29 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_UserGuideDialogUITask.get_m_layerDescArray);
		}
		LuaCSFunction get3 = Lua_BlackJack_ProjectL_UI_UserGuideDialogUITask.<>f__mg$cache29;
		if (Lua_BlackJack_ProjectL_UI_UserGuideDialogUITask.<>f__mg$cache2A == null)
		{
			Lua_BlackJack_ProjectL_UI_UserGuideDialogUITask.<>f__mg$cache2A = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_UserGuideDialogUITask.set_m_layerDescArray);
		}
		LuaObject.addMember(l, name3, get3, Lua_BlackJack_ProjectL_UI_UserGuideDialogUITask.<>f__mg$cache2A, true);
		string name4 = "m_uiCtrlDescArray";
		if (Lua_BlackJack_ProjectL_UI_UserGuideDialogUITask.<>f__mg$cache2B == null)
		{
			Lua_BlackJack_ProjectL_UI_UserGuideDialogUITask.<>f__mg$cache2B = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_UserGuideDialogUITask.get_m_uiCtrlDescArray);
		}
		LuaCSFunction get4 = Lua_BlackJack_ProjectL_UI_UserGuideDialogUITask.<>f__mg$cache2B;
		if (Lua_BlackJack_ProjectL_UI_UserGuideDialogUITask.<>f__mg$cache2C == null)
		{
			Lua_BlackJack_ProjectL_UI_UserGuideDialogUITask.<>f__mg$cache2C = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_UserGuideDialogUITask.set_m_uiCtrlDescArray);
		}
		LuaObject.addMember(l, name4, get4, Lua_BlackJack_ProjectL_UI_UserGuideDialogUITask.<>f__mg$cache2C, true);
		string name5 = "m_userGuideDialogUIController";
		if (Lua_BlackJack_ProjectL_UI_UserGuideDialogUITask.<>f__mg$cache2D == null)
		{
			Lua_BlackJack_ProjectL_UI_UserGuideDialogUITask.<>f__mg$cache2D = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_UserGuideDialogUITask.get_m_userGuideDialogUIController);
		}
		LuaCSFunction get5 = Lua_BlackJack_ProjectL_UI_UserGuideDialogUITask.<>f__mg$cache2D;
		if (Lua_BlackJack_ProjectL_UI_UserGuideDialogUITask.<>f__mg$cache2E == null)
		{
			Lua_BlackJack_ProjectL_UI_UserGuideDialogUITask.<>f__mg$cache2E = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_UserGuideDialogUITask.set_m_userGuideDialogUIController);
		}
		LuaObject.addMember(l, name5, get5, Lua_BlackJack_ProjectL_UI_UserGuideDialogUITask.<>f__mg$cache2E, true);
		string name6 = "m_userGuideDialogInfo";
		if (Lua_BlackJack_ProjectL_UI_UserGuideDialogUITask.<>f__mg$cache2F == null)
		{
			Lua_BlackJack_ProjectL_UI_UserGuideDialogUITask.<>f__mg$cache2F = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_UserGuideDialogUITask.get_m_userGuideDialogInfo);
		}
		LuaCSFunction get6 = Lua_BlackJack_ProjectL_UI_UserGuideDialogUITask.<>f__mg$cache2F;
		if (Lua_BlackJack_ProjectL_UI_UserGuideDialogUITask.<>f__mg$cache30 == null)
		{
			Lua_BlackJack_ProjectL_UI_UserGuideDialogUITask.<>f__mg$cache30 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_UserGuideDialogUITask.set_m_userGuideDialogInfo);
		}
		LuaObject.addMember(l, name6, get6, Lua_BlackJack_ProjectL_UI_UserGuideDialogUITask.<>f__mg$cache30, true);
		string name7 = "LayerDescArray";
		if (Lua_BlackJack_ProjectL_UI_UserGuideDialogUITask.<>f__mg$cache31 == null)
		{
			Lua_BlackJack_ProjectL_UI_UserGuideDialogUITask.<>f__mg$cache31 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_UserGuideDialogUITask.get_LayerDescArray);
		}
		LuaObject.addMember(l, name7, Lua_BlackJack_ProjectL_UI_UserGuideDialogUITask.<>f__mg$cache31, null, true);
		string name8 = "UICtrlDescArray";
		if (Lua_BlackJack_ProjectL_UI_UserGuideDialogUITask.<>f__mg$cache32 == null)
		{
			Lua_BlackJack_ProjectL_UI_UserGuideDialogUITask.<>f__mg$cache32 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_UserGuideDialogUITask.get_UICtrlDescArray);
		}
		LuaObject.addMember(l, name8, Lua_BlackJack_ProjectL_UI_UserGuideDialogUITask.<>f__mg$cache32, null, true);
		if (Lua_BlackJack_ProjectL_UI_UserGuideDialogUITask.<>f__mg$cache33 == null)
		{
			Lua_BlackJack_ProjectL_UI_UserGuideDialogUITask.<>f__mg$cache33 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_UserGuideDialogUITask.constructor);
		}
		LuaObject.createTypeMetatable(l, Lua_BlackJack_ProjectL_UI_UserGuideDialogUITask.<>f__mg$cache33, typeof(UserGuideDialogUITask), typeof(UITask));
	}

	// Token: 0x04017F56 RID: 98134
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache0;

	// Token: 0x04017F57 RID: 98135
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1;

	// Token: 0x04017F58 RID: 98136
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2;

	// Token: 0x04017F59 RID: 98137
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3;

	// Token: 0x04017F5A RID: 98138
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache4;

	// Token: 0x04017F5B RID: 98139
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache5;

	// Token: 0x04017F5C RID: 98140
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache6;

	// Token: 0x04017F5D RID: 98141
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache7;

	// Token: 0x04017F5E RID: 98142
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache8;

	// Token: 0x04017F5F RID: 98143
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache9;

	// Token: 0x04017F60 RID: 98144
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheA;

	// Token: 0x04017F61 RID: 98145
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheB;

	// Token: 0x04017F62 RID: 98146
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheC;

	// Token: 0x04017F63 RID: 98147
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheD;

	// Token: 0x04017F64 RID: 98148
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheE;

	// Token: 0x04017F65 RID: 98149
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheF;

	// Token: 0x04017F66 RID: 98150
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache10;

	// Token: 0x04017F67 RID: 98151
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache11;

	// Token: 0x04017F68 RID: 98152
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache12;

	// Token: 0x04017F69 RID: 98153
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache13;

	// Token: 0x04017F6A RID: 98154
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache14;

	// Token: 0x04017F6B RID: 98155
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache15;

	// Token: 0x04017F6C RID: 98156
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache16;

	// Token: 0x04017F6D RID: 98157
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache17;

	// Token: 0x04017F6E RID: 98158
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache18;

	// Token: 0x04017F6F RID: 98159
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache19;

	// Token: 0x04017F70 RID: 98160
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1A;

	// Token: 0x04017F71 RID: 98161
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1B;

	// Token: 0x04017F72 RID: 98162
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1C;

	// Token: 0x04017F73 RID: 98163
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1D;

	// Token: 0x04017F74 RID: 98164
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1E;

	// Token: 0x04017F75 RID: 98165
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1F;

	// Token: 0x04017F76 RID: 98166
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache20;

	// Token: 0x04017F77 RID: 98167
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache21;

	// Token: 0x04017F78 RID: 98168
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache22;

	// Token: 0x04017F79 RID: 98169
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache23;

	// Token: 0x04017F7A RID: 98170
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache24;

	// Token: 0x04017F7B RID: 98171
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache25;

	// Token: 0x04017F7C RID: 98172
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache26;

	// Token: 0x04017F7D RID: 98173
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache27;

	// Token: 0x04017F7E RID: 98174
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache28;

	// Token: 0x04017F7F RID: 98175
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache29;

	// Token: 0x04017F80 RID: 98176
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2A;

	// Token: 0x04017F81 RID: 98177
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2B;

	// Token: 0x04017F82 RID: 98178
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2C;

	// Token: 0x04017F83 RID: 98179
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2D;

	// Token: 0x04017F84 RID: 98180
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2E;

	// Token: 0x04017F85 RID: 98181
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2F;

	// Token: 0x04017F86 RID: 98182
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache30;

	// Token: 0x04017F87 RID: 98183
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache31;

	// Token: 0x04017F88 RID: 98184
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache32;

	// Token: 0x04017F89 RID: 98185
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache33;
}
