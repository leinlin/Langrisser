using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using BlackJack.BJFramework.Runtime.UI;
using BlackJack.ConfigData;
using BlackJack.ProjectL.UI;
using SLua;
using UnityEngine.Scripting;

// Token: 0x020015BE RID: 5566
[Preserve]
public class Lua_BlackJack_ProjectL_UI_TreasureMapUITask : LuaObject
{
	// Token: 0x06021D4C RID: 138572 RVA: 0x00B80D14 File Offset: 0x00B7EF14
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int constructor(IntPtr l)
	{
		int result;
		try
		{
			string name;
			LuaObject.checkType(l, 2, out name);
			TreasureMapUITask o = new TreasureMapUITask(name);
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

	// Token: 0x06021D4D RID: 138573 RVA: 0x00B80D68 File Offset: 0x00B7EF68
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int IsNeedLoadDynamicRes(IntPtr l)
	{
		int result;
		try
		{
			TreasureMapUITask treasureMapUITask = (TreasureMapUITask)LuaObject.checkSelf(l);
			bool b = treasureMapUITask.m_luaExportHelper.IsNeedLoadDynamicRes();
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

	// Token: 0x06021D4E RID: 138574 RVA: 0x00B80DC4 File Offset: 0x00B7EFC4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int InitAllUIControllers(IntPtr l)
	{
		int result;
		try
		{
			TreasureMapUITask treasureMapUITask = (TreasureMapUITask)LuaObject.checkSelf(l);
			treasureMapUITask.m_luaExportHelper.InitAllUIControllers();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06021D4F RID: 138575 RVA: 0x00B80E18 File Offset: 0x00B7F018
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int ClearAllContextAndRes(IntPtr l)
	{
		int result;
		try
		{
			TreasureMapUITask treasureMapUITask = (TreasureMapUITask)LuaObject.checkSelf(l);
			treasureMapUITask.m_luaExportHelper.ClearAllContextAndRes();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06021D50 RID: 138576 RVA: 0x00B80E6C File Offset: 0x00B7F06C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int InitTreasureMapUIController(IntPtr l)
	{
		int result;
		try
		{
			TreasureMapUITask treasureMapUITask = (TreasureMapUITask)LuaObject.checkSelf(l);
			treasureMapUITask.m_luaExportHelper.InitTreasureMapUIController();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06021D51 RID: 138577 RVA: 0x00B80EC0 File Offset: 0x00B7F0C0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int UninitTreasureMapUIController(IntPtr l)
	{
		int result;
		try
		{
			TreasureMapUITask treasureMapUITask = (TreasureMapUITask)LuaObject.checkSelf(l);
			treasureMapUITask.m_luaExportHelper.UninitTreasureMapUIController();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06021D52 RID: 138578 RVA: 0x00B80F14 File Offset: 0x00B7F114
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int UpdateView(IntPtr l)
	{
		int result;
		try
		{
			TreasureMapUITask treasureMapUITask = (TreasureMapUITask)LuaObject.checkSelf(l);
			treasureMapUITask.m_luaExportHelper.UpdateView();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06021D53 RID: 138579 RVA: 0x00B80F68 File Offset: 0x00B7F168
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int TreasureMapUIController_OnReturn(IntPtr l)
	{
		int result;
		try
		{
			TreasureMapUITask treasureMapUITask = (TreasureMapUITask)LuaObject.checkSelf(l);
			treasureMapUITask.m_luaExportHelper.TreasureMapUIController_OnReturn();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06021D54 RID: 138580 RVA: 0x00B80FBC File Offset: 0x00B7F1BC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int TreasureMapUIController_OnShowHelp(IntPtr l)
	{
		int result;
		try
		{
			TreasureMapUITask treasureMapUITask = (TreasureMapUITask)LuaObject.checkSelf(l);
			treasureMapUITask.m_luaExportHelper.TreasureMapUIController_OnShowHelp();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06021D55 RID: 138581 RVA: 0x00B81010 File Offset: 0x00B7F210
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int TreasureMapUIController_OnAddTicket(IntPtr l)
	{
		int result;
		try
		{
			TreasureMapUITask treasureMapUITask = (TreasureMapUITask)LuaObject.checkSelf(l);
			treasureMapUITask.m_luaExportHelper.TreasureMapUIController_OnAddTicket();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06021D56 RID: 138582 RVA: 0x00B81064 File Offset: 0x00B7F264
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int TreasureMapUIcontroller_OnStartTreasureLevel(IntPtr l)
	{
		int result;
		try
		{
			TreasureMapUITask treasureMapUITask = (TreasureMapUITask)LuaObject.checkSelf(l);
			ConfigDataTreasureLevelInfo levelInfo;
			LuaObject.checkType<ConfigDataTreasureLevelInfo>(l, 2, out levelInfo);
			treasureMapUITask.m_luaExportHelper.TreasureMapUIcontroller_OnStartTreasureLevel(levelInfo);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06021D57 RID: 138583 RVA: 0x00B810C0 File Offset: 0x00B7F2C0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_OnStart(IntPtr l)
	{
		int result;
		try
		{
			TreasureMapUITask treasureMapUITask = (TreasureMapUITask)LuaObject.checkSelf(l);
			UIIntent intent;
			LuaObject.checkType<UIIntent>(l, 2, out intent);
			bool b = treasureMapUITask.m_luaExportHelper.__callBase_OnStart(intent);
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

	// Token: 0x06021D58 RID: 138584 RVA: 0x00B81128 File Offset: 0x00B7F328
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_OnStop(IntPtr l)
	{
		int result;
		try
		{
			TreasureMapUITask treasureMapUITask = (TreasureMapUITask)LuaObject.checkSelf(l);
			treasureMapUITask.m_luaExportHelper.__callBase_OnStop();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06021D59 RID: 138585 RVA: 0x00B8117C File Offset: 0x00B7F37C
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int __callBase_OnPause(IntPtr l)
	{
		int result;
		try
		{
			TreasureMapUITask treasureMapUITask = (TreasureMapUITask)LuaObject.checkSelf(l);
			treasureMapUITask.m_luaExportHelper.__callBase_OnPause();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06021D5A RID: 138586 RVA: 0x00B811D0 File Offset: 0x00B7F3D0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_OnResume(IntPtr l)
	{
		int result;
		try
		{
			TreasureMapUITask treasureMapUITask = (TreasureMapUITask)LuaObject.checkSelf(l);
			UIIntent intent;
			LuaObject.checkType<UIIntent>(l, 2, out intent);
			bool b = treasureMapUITask.m_luaExportHelper.__callBase_OnResume(intent);
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

	// Token: 0x06021D5B RID: 138587 RVA: 0x00B81238 File Offset: 0x00B7F438
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_OnNewIntent(IntPtr l)
	{
		int result;
		try
		{
			TreasureMapUITask treasureMapUITask = (TreasureMapUITask)LuaObject.checkSelf(l);
			UIIntent intent;
			LuaObject.checkType<UIIntent>(l, 2, out intent);
			bool b = treasureMapUITask.m_luaExportHelper.__callBase_OnNewIntent(intent);
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

	// Token: 0x06021D5C RID: 138588 RVA: 0x00B812A0 File Offset: 0x00B7F4A0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_EnableUIInput(IntPtr l)
	{
		int result;
		try
		{
			TreasureMapUITask treasureMapUITask = (TreasureMapUITask)LuaObject.checkSelf(l);
			bool isEnable;
			LuaObject.checkType(l, 2, out isEnable);
			bool? isGlobalEnable;
			LuaObject.checkNullable<bool>(l, 3, out isGlobalEnable);
			treasureMapUITask.m_luaExportHelper.__callBase_EnableUIInput(isEnable, isGlobalEnable);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06021D5D RID: 138589 RVA: 0x00B8130C File Offset: 0x00B7F50C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_IsNeedLoadDynamicRes(IntPtr l)
	{
		int result;
		try
		{
			TreasureMapUITask treasureMapUITask = (TreasureMapUITask)LuaObject.checkSelf(l);
			bool b = treasureMapUITask.m_luaExportHelper.__callBase_IsNeedLoadDynamicRes();
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

	// Token: 0x06021D5E RID: 138590 RVA: 0x00B81368 File Offset: 0x00B7F568
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_CollectAllDynamicResForLoad(IntPtr l)
	{
		int result;
		try
		{
			TreasureMapUITask treasureMapUITask = (TreasureMapUITask)LuaObject.checkSelf(l);
			List<string> o = treasureMapUITask.m_luaExportHelper.__callBase_CollectAllDynamicResForLoad();
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

	// Token: 0x06021D5F RID: 138591 RVA: 0x00B813C4 File Offset: 0x00B7F5C4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_RegisterPlayerContextEvents(IntPtr l)
	{
		int result;
		try
		{
			TreasureMapUITask treasureMapUITask = (TreasureMapUITask)LuaObject.checkSelf(l);
			treasureMapUITask.m_luaExportHelper.__callBase_RegisterPlayerContextEvents();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06021D60 RID: 138592 RVA: 0x00B81418 File Offset: 0x00B7F618
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_UnregisterPlayerContextEvents(IntPtr l)
	{
		int result;
		try
		{
			TreasureMapUITask treasureMapUITask = (TreasureMapUITask)LuaObject.checkSelf(l);
			treasureMapUITask.m_luaExportHelper.__callBase_UnregisterPlayerContextEvents();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06021D61 RID: 138593 RVA: 0x00B8146C File Offset: 0x00B7F66C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_PostUpdateView(IntPtr l)
	{
		int result;
		try
		{
			TreasureMapUITask treasureMapUITask = (TreasureMapUITask)LuaObject.checkSelf(l);
			treasureMapUITask.m_luaExportHelper.__callBase_PostUpdateView();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06021D62 RID: 138594 RVA: 0x00B814C0 File Offset: 0x00B7F6C0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_CollectPreloadResourceList(IntPtr l)
	{
		int result;
		try
		{
			TreasureMapUITask treasureMapUITask = (TreasureMapUITask)LuaObject.checkSelf(l);
			treasureMapUITask.m_luaExportHelper.__callBase_CollectPreloadResourceList();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06021D63 RID: 138595 RVA: 0x00B81514 File Offset: 0x00B7F714
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int __callBase_ClearAssetList(IntPtr l)
	{
		int result;
		try
		{
			TreasureMapUITask treasureMapUITask = (TreasureMapUITask)LuaObject.checkSelf(l);
			treasureMapUITask.m_luaExportHelper.__callBase_ClearAssetList();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06021D64 RID: 138596 RVA: 0x00B81568 File Offset: 0x00B7F768
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_CollectAsset(IntPtr l)
	{
		int result;
		try
		{
			TreasureMapUITask treasureMapUITask = (TreasureMapUITask)LuaObject.checkSelf(l);
			string assetName;
			LuaObject.checkType(l, 2, out assetName);
			treasureMapUITask.m_luaExportHelper.__callBase_CollectAsset(assetName);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06021D65 RID: 138597 RVA: 0x00B815C4 File Offset: 0x00B7F7C4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_CollectSpriteAsset(IntPtr l)
	{
		int result;
		try
		{
			TreasureMapUITask treasureMapUITask = (TreasureMapUITask)LuaObject.checkSelf(l);
			string assetName;
			LuaObject.checkType(l, 2, out assetName);
			treasureMapUITask.m_luaExportHelper.__callBase_CollectSpriteAsset(assetName);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06021D66 RID: 138598 RVA: 0x00B81620 File Offset: 0x00B7F820
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_CollectFxAsset(IntPtr l)
	{
		int result;
		try
		{
			TreasureMapUITask treasureMapUITask = (TreasureMapUITask)LuaObject.checkSelf(l);
			string assetName;
			LuaObject.checkType(l, 2, out assetName);
			treasureMapUITask.m_luaExportHelper.__callBase_CollectFxAsset(assetName);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06021D67 RID: 138599 RVA: 0x00B8167C File Offset: 0x00B7F87C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_StartLoadCustomAssets(IntPtr l)
	{
		int result;
		try
		{
			TreasureMapUITask treasureMapUITask = (TreasureMapUITask)LuaObject.checkSelf(l);
			Action onLoadCompleted;
			LuaObject.checkDelegate<Action>(l, 2, out onLoadCompleted);
			treasureMapUITask.m_luaExportHelper.__callBase_StartLoadCustomAssets(onLoadCompleted);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06021D68 RID: 138600 RVA: 0x00B816D8 File Offset: 0x00B7F8D8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_IsLoadingCustomAssets(IntPtr l)
	{
		int result;
		try
		{
			TreasureMapUITask treasureMapUITask = (TreasureMapUITask)LuaObject.checkSelf(l);
			bool b = treasureMapUITask.m_luaExportHelper.__callBase_IsLoadingCustomAssets();
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

	// Token: 0x06021D69 RID: 138601 RVA: 0x00B81734 File Offset: 0x00B7F934
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_IsPipeLineRunning(IntPtr l)
	{
		int result;
		try
		{
			TreasureMapUITask treasureMapUITask = (TreasureMapUITask)LuaObject.checkSelf(l);
			bool b = treasureMapUITask.m_luaExportHelper.__callBase_IsPipeLineRunning();
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

	// Token: 0x06021D6A RID: 138602 RVA: 0x00B81790 File Offset: 0x00B7F990
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_IsOpeningUI(IntPtr l)
	{
		int result;
		try
		{
			TreasureMapUITask treasureMapUITask = (TreasureMapUITask)LuaObject.checkSelf(l);
			bool b = treasureMapUITask.m_luaExportHelper.__callBase_IsOpeningUI();
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

	// Token: 0x06021D6B RID: 138603 RVA: 0x00B817EC File Offset: 0x00B7F9EC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_ReturnPrevUITask(IntPtr l)
	{
		int result;
		try
		{
			TreasureMapUITask treasureMapUITask = (TreasureMapUITask)LuaObject.checkSelf(l);
			UITaskBase o = treasureMapUITask.m_luaExportHelper.__callBase_ReturnPrevUITask();
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

	// Token: 0x06021D6C RID: 138604 RVA: 0x00B81848 File Offset: 0x00B7FA48
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_ClearUnusedDynamicResourceCache(IntPtr l)
	{
		int result;
		try
		{
			TreasureMapUITask treasureMapUITask = (TreasureMapUITask)LuaObject.checkSelf(l);
			treasureMapUITask.m_luaExportHelper.__callBase_ClearUnusedDynamicResourceCache();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06021D6D RID: 138605 RVA: 0x00B8189C File Offset: 0x00B7FA9C
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int __callBase_OnMemoryWarning(IntPtr l)
	{
		int result;
		try
		{
			TreasureMapUITask treasureMapUITask = (TreasureMapUITask)LuaObject.checkSelf(l);
			treasureMapUITask.m_luaExportHelper.__callBase_OnMemoryWarning();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06021D6E RID: 138606 RVA: 0x00B818F0 File Offset: 0x00B7FAF0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_layerDescArray(IntPtr l)
	{
		int result;
		try
		{
			TreasureMapUITask treasureMapUITask = (TreasureMapUITask)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, treasureMapUITask.m_luaExportHelper.m_layerDescArray);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06021D6F RID: 138607 RVA: 0x00B81948 File Offset: 0x00B7FB48
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_layerDescArray(IntPtr l)
	{
		int result;
		try
		{
			TreasureMapUITask treasureMapUITask = (TreasureMapUITask)LuaObject.checkSelf(l);
			UITaskBase.LayerDesc[] layerDescArray;
			LuaObject.checkArray<UITaskBase.LayerDesc>(l, 2, out layerDescArray);
			treasureMapUITask.m_luaExportHelper.m_layerDescArray = layerDescArray;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06021D70 RID: 138608 RVA: 0x00B819A4 File Offset: 0x00B7FBA4
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_m_uiCtrlDescArray(IntPtr l)
	{
		int result;
		try
		{
			TreasureMapUITask treasureMapUITask = (TreasureMapUITask)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, treasureMapUITask.m_luaExportHelper.m_uiCtrlDescArray);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06021D71 RID: 138609 RVA: 0x00B819FC File Offset: 0x00B7FBFC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_uiCtrlDescArray(IntPtr l)
	{
		int result;
		try
		{
			TreasureMapUITask treasureMapUITask = (TreasureMapUITask)LuaObject.checkSelf(l);
			UITaskBase.UIControllerDesc[] uiCtrlDescArray;
			LuaObject.checkArray<UITaskBase.UIControllerDesc>(l, 2, out uiCtrlDescArray);
			treasureMapUITask.m_luaExportHelper.m_uiCtrlDescArray = uiCtrlDescArray;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06021D72 RID: 138610 RVA: 0x00B81A58 File Offset: 0x00B7FC58
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_m_treasureMapUIController(IntPtr l)
	{
		int result;
		try
		{
			TreasureMapUITask treasureMapUITask = (TreasureMapUITask)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, treasureMapUITask.m_luaExportHelper.m_treasureMapUIController);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06021D73 RID: 138611 RVA: 0x00B81AB0 File Offset: 0x00B7FCB0
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_m_treasureMapUIController(IntPtr l)
	{
		int result;
		try
		{
			TreasureMapUITask treasureMapUITask = (TreasureMapUITask)LuaObject.checkSelf(l);
			TreasureMapUIController treasureMapUIController;
			LuaObject.checkType<TreasureMapUIController>(l, 2, out treasureMapUIController);
			treasureMapUITask.m_luaExportHelper.m_treasureMapUIController = treasureMapUIController;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06021D74 RID: 138612 RVA: 0x00B81B0C File Offset: 0x00B7FD0C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_playerResourceUIController(IntPtr l)
	{
		int result;
		try
		{
			TreasureMapUITask treasureMapUITask = (TreasureMapUITask)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, treasureMapUITask.m_luaExportHelper.m_playerResourceUIController);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06021D75 RID: 138613 RVA: 0x00B81B64 File Offset: 0x00B7FD64
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_playerResourceUIController(IntPtr l)
	{
		int result;
		try
		{
			TreasureMapUITask treasureMapUITask = (TreasureMapUITask)LuaObject.checkSelf(l);
			PlayerResourceUIController playerResourceUIController;
			LuaObject.checkType<PlayerResourceUIController>(l, 2, out playerResourceUIController);
			treasureMapUITask.m_luaExportHelper.m_playerResourceUIController = playerResourceUIController;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06021D76 RID: 138614 RVA: 0x00B81BC0 File Offset: 0x00B7FDC0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_LayerDescArray(IntPtr l)
	{
		int result;
		try
		{
			TreasureMapUITask treasureMapUITask = (TreasureMapUITask)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, treasureMapUITask.m_luaExportHelper.LayerDescArray);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06021D77 RID: 138615 RVA: 0x00B81C18 File Offset: 0x00B7FE18
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_UICtrlDescArray(IntPtr l)
	{
		int result;
		try
		{
			TreasureMapUITask treasureMapUITask = (TreasureMapUITask)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, treasureMapUITask.m_luaExportHelper.UICtrlDescArray);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06021D78 RID: 138616 RVA: 0x00B81C70 File Offset: 0x00B7FE70
	[Preserve]
	public static void reg(IntPtr l)
	{
		LuaObject.getTypeTable(l, "BlackJack.ProjectL.UI.TreasureMapUITask");
		if (Lua_BlackJack_ProjectL_UI_TreasureMapUITask.<>f__mg$cache0 == null)
		{
			Lua_BlackJack_ProjectL_UI_TreasureMapUITask.<>f__mg$cache0 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_TreasureMapUITask.IsNeedLoadDynamicRes);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_TreasureMapUITask.<>f__mg$cache0);
		if (Lua_BlackJack_ProjectL_UI_TreasureMapUITask.<>f__mg$cache1 == null)
		{
			Lua_BlackJack_ProjectL_UI_TreasureMapUITask.<>f__mg$cache1 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_TreasureMapUITask.InitAllUIControllers);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_TreasureMapUITask.<>f__mg$cache1);
		if (Lua_BlackJack_ProjectL_UI_TreasureMapUITask.<>f__mg$cache2 == null)
		{
			Lua_BlackJack_ProjectL_UI_TreasureMapUITask.<>f__mg$cache2 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_TreasureMapUITask.ClearAllContextAndRes);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_TreasureMapUITask.<>f__mg$cache2);
		if (Lua_BlackJack_ProjectL_UI_TreasureMapUITask.<>f__mg$cache3 == null)
		{
			Lua_BlackJack_ProjectL_UI_TreasureMapUITask.<>f__mg$cache3 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_TreasureMapUITask.InitTreasureMapUIController);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_TreasureMapUITask.<>f__mg$cache3);
		if (Lua_BlackJack_ProjectL_UI_TreasureMapUITask.<>f__mg$cache4 == null)
		{
			Lua_BlackJack_ProjectL_UI_TreasureMapUITask.<>f__mg$cache4 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_TreasureMapUITask.UninitTreasureMapUIController);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_TreasureMapUITask.<>f__mg$cache4);
		if (Lua_BlackJack_ProjectL_UI_TreasureMapUITask.<>f__mg$cache5 == null)
		{
			Lua_BlackJack_ProjectL_UI_TreasureMapUITask.<>f__mg$cache5 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_TreasureMapUITask.UpdateView);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_TreasureMapUITask.<>f__mg$cache5);
		if (Lua_BlackJack_ProjectL_UI_TreasureMapUITask.<>f__mg$cache6 == null)
		{
			Lua_BlackJack_ProjectL_UI_TreasureMapUITask.<>f__mg$cache6 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_TreasureMapUITask.TreasureMapUIController_OnReturn);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_TreasureMapUITask.<>f__mg$cache6);
		if (Lua_BlackJack_ProjectL_UI_TreasureMapUITask.<>f__mg$cache7 == null)
		{
			Lua_BlackJack_ProjectL_UI_TreasureMapUITask.<>f__mg$cache7 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_TreasureMapUITask.TreasureMapUIController_OnShowHelp);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_TreasureMapUITask.<>f__mg$cache7);
		if (Lua_BlackJack_ProjectL_UI_TreasureMapUITask.<>f__mg$cache8 == null)
		{
			Lua_BlackJack_ProjectL_UI_TreasureMapUITask.<>f__mg$cache8 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_TreasureMapUITask.TreasureMapUIController_OnAddTicket);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_TreasureMapUITask.<>f__mg$cache8);
		if (Lua_BlackJack_ProjectL_UI_TreasureMapUITask.<>f__mg$cache9 == null)
		{
			Lua_BlackJack_ProjectL_UI_TreasureMapUITask.<>f__mg$cache9 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_TreasureMapUITask.TreasureMapUIcontroller_OnStartTreasureLevel);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_TreasureMapUITask.<>f__mg$cache9);
		if (Lua_BlackJack_ProjectL_UI_TreasureMapUITask.<>f__mg$cacheA == null)
		{
			Lua_BlackJack_ProjectL_UI_TreasureMapUITask.<>f__mg$cacheA = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_TreasureMapUITask.__callBase_OnStart);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_TreasureMapUITask.<>f__mg$cacheA);
		if (Lua_BlackJack_ProjectL_UI_TreasureMapUITask.<>f__mg$cacheB == null)
		{
			Lua_BlackJack_ProjectL_UI_TreasureMapUITask.<>f__mg$cacheB = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_TreasureMapUITask.__callBase_OnStop);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_TreasureMapUITask.<>f__mg$cacheB);
		if (Lua_BlackJack_ProjectL_UI_TreasureMapUITask.<>f__mg$cacheC == null)
		{
			Lua_BlackJack_ProjectL_UI_TreasureMapUITask.<>f__mg$cacheC = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_TreasureMapUITask.__callBase_OnPause);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_TreasureMapUITask.<>f__mg$cacheC);
		if (Lua_BlackJack_ProjectL_UI_TreasureMapUITask.<>f__mg$cacheD == null)
		{
			Lua_BlackJack_ProjectL_UI_TreasureMapUITask.<>f__mg$cacheD = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_TreasureMapUITask.__callBase_OnResume);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_TreasureMapUITask.<>f__mg$cacheD);
		if (Lua_BlackJack_ProjectL_UI_TreasureMapUITask.<>f__mg$cacheE == null)
		{
			Lua_BlackJack_ProjectL_UI_TreasureMapUITask.<>f__mg$cacheE = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_TreasureMapUITask.__callBase_OnNewIntent);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_TreasureMapUITask.<>f__mg$cacheE);
		if (Lua_BlackJack_ProjectL_UI_TreasureMapUITask.<>f__mg$cacheF == null)
		{
			Lua_BlackJack_ProjectL_UI_TreasureMapUITask.<>f__mg$cacheF = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_TreasureMapUITask.__callBase_EnableUIInput);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_TreasureMapUITask.<>f__mg$cacheF);
		if (Lua_BlackJack_ProjectL_UI_TreasureMapUITask.<>f__mg$cache10 == null)
		{
			Lua_BlackJack_ProjectL_UI_TreasureMapUITask.<>f__mg$cache10 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_TreasureMapUITask.__callBase_IsNeedLoadDynamicRes);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_TreasureMapUITask.<>f__mg$cache10);
		if (Lua_BlackJack_ProjectL_UI_TreasureMapUITask.<>f__mg$cache11 == null)
		{
			Lua_BlackJack_ProjectL_UI_TreasureMapUITask.<>f__mg$cache11 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_TreasureMapUITask.__callBase_CollectAllDynamicResForLoad);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_TreasureMapUITask.<>f__mg$cache11);
		if (Lua_BlackJack_ProjectL_UI_TreasureMapUITask.<>f__mg$cache12 == null)
		{
			Lua_BlackJack_ProjectL_UI_TreasureMapUITask.<>f__mg$cache12 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_TreasureMapUITask.__callBase_RegisterPlayerContextEvents);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_TreasureMapUITask.<>f__mg$cache12);
		if (Lua_BlackJack_ProjectL_UI_TreasureMapUITask.<>f__mg$cache13 == null)
		{
			Lua_BlackJack_ProjectL_UI_TreasureMapUITask.<>f__mg$cache13 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_TreasureMapUITask.__callBase_UnregisterPlayerContextEvents);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_TreasureMapUITask.<>f__mg$cache13);
		if (Lua_BlackJack_ProjectL_UI_TreasureMapUITask.<>f__mg$cache14 == null)
		{
			Lua_BlackJack_ProjectL_UI_TreasureMapUITask.<>f__mg$cache14 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_TreasureMapUITask.__callBase_PostUpdateView);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_TreasureMapUITask.<>f__mg$cache14);
		if (Lua_BlackJack_ProjectL_UI_TreasureMapUITask.<>f__mg$cache15 == null)
		{
			Lua_BlackJack_ProjectL_UI_TreasureMapUITask.<>f__mg$cache15 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_TreasureMapUITask.__callBase_CollectPreloadResourceList);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_TreasureMapUITask.<>f__mg$cache15);
		if (Lua_BlackJack_ProjectL_UI_TreasureMapUITask.<>f__mg$cache16 == null)
		{
			Lua_BlackJack_ProjectL_UI_TreasureMapUITask.<>f__mg$cache16 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_TreasureMapUITask.__callBase_ClearAssetList);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_TreasureMapUITask.<>f__mg$cache16);
		if (Lua_BlackJack_ProjectL_UI_TreasureMapUITask.<>f__mg$cache17 == null)
		{
			Lua_BlackJack_ProjectL_UI_TreasureMapUITask.<>f__mg$cache17 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_TreasureMapUITask.__callBase_CollectAsset);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_TreasureMapUITask.<>f__mg$cache17);
		if (Lua_BlackJack_ProjectL_UI_TreasureMapUITask.<>f__mg$cache18 == null)
		{
			Lua_BlackJack_ProjectL_UI_TreasureMapUITask.<>f__mg$cache18 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_TreasureMapUITask.__callBase_CollectSpriteAsset);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_TreasureMapUITask.<>f__mg$cache18);
		if (Lua_BlackJack_ProjectL_UI_TreasureMapUITask.<>f__mg$cache19 == null)
		{
			Lua_BlackJack_ProjectL_UI_TreasureMapUITask.<>f__mg$cache19 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_TreasureMapUITask.__callBase_CollectFxAsset);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_TreasureMapUITask.<>f__mg$cache19);
		if (Lua_BlackJack_ProjectL_UI_TreasureMapUITask.<>f__mg$cache1A == null)
		{
			Lua_BlackJack_ProjectL_UI_TreasureMapUITask.<>f__mg$cache1A = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_TreasureMapUITask.__callBase_StartLoadCustomAssets);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_TreasureMapUITask.<>f__mg$cache1A);
		if (Lua_BlackJack_ProjectL_UI_TreasureMapUITask.<>f__mg$cache1B == null)
		{
			Lua_BlackJack_ProjectL_UI_TreasureMapUITask.<>f__mg$cache1B = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_TreasureMapUITask.__callBase_IsLoadingCustomAssets);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_TreasureMapUITask.<>f__mg$cache1B);
		if (Lua_BlackJack_ProjectL_UI_TreasureMapUITask.<>f__mg$cache1C == null)
		{
			Lua_BlackJack_ProjectL_UI_TreasureMapUITask.<>f__mg$cache1C = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_TreasureMapUITask.__callBase_IsPipeLineRunning);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_TreasureMapUITask.<>f__mg$cache1C);
		if (Lua_BlackJack_ProjectL_UI_TreasureMapUITask.<>f__mg$cache1D == null)
		{
			Lua_BlackJack_ProjectL_UI_TreasureMapUITask.<>f__mg$cache1D = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_TreasureMapUITask.__callBase_IsOpeningUI);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_TreasureMapUITask.<>f__mg$cache1D);
		if (Lua_BlackJack_ProjectL_UI_TreasureMapUITask.<>f__mg$cache1E == null)
		{
			Lua_BlackJack_ProjectL_UI_TreasureMapUITask.<>f__mg$cache1E = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_TreasureMapUITask.__callBase_ReturnPrevUITask);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_TreasureMapUITask.<>f__mg$cache1E);
		if (Lua_BlackJack_ProjectL_UI_TreasureMapUITask.<>f__mg$cache1F == null)
		{
			Lua_BlackJack_ProjectL_UI_TreasureMapUITask.<>f__mg$cache1F = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_TreasureMapUITask.__callBase_ClearUnusedDynamicResourceCache);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_TreasureMapUITask.<>f__mg$cache1F);
		if (Lua_BlackJack_ProjectL_UI_TreasureMapUITask.<>f__mg$cache20 == null)
		{
			Lua_BlackJack_ProjectL_UI_TreasureMapUITask.<>f__mg$cache20 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_TreasureMapUITask.__callBase_OnMemoryWarning);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_TreasureMapUITask.<>f__mg$cache20);
		string name = "m_layerDescArray";
		if (Lua_BlackJack_ProjectL_UI_TreasureMapUITask.<>f__mg$cache21 == null)
		{
			Lua_BlackJack_ProjectL_UI_TreasureMapUITask.<>f__mg$cache21 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_TreasureMapUITask.get_m_layerDescArray);
		}
		LuaCSFunction get = Lua_BlackJack_ProjectL_UI_TreasureMapUITask.<>f__mg$cache21;
		if (Lua_BlackJack_ProjectL_UI_TreasureMapUITask.<>f__mg$cache22 == null)
		{
			Lua_BlackJack_ProjectL_UI_TreasureMapUITask.<>f__mg$cache22 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_TreasureMapUITask.set_m_layerDescArray);
		}
		LuaObject.addMember(l, name, get, Lua_BlackJack_ProjectL_UI_TreasureMapUITask.<>f__mg$cache22, true);
		string name2 = "m_uiCtrlDescArray";
		if (Lua_BlackJack_ProjectL_UI_TreasureMapUITask.<>f__mg$cache23 == null)
		{
			Lua_BlackJack_ProjectL_UI_TreasureMapUITask.<>f__mg$cache23 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_TreasureMapUITask.get_m_uiCtrlDescArray);
		}
		LuaCSFunction get2 = Lua_BlackJack_ProjectL_UI_TreasureMapUITask.<>f__mg$cache23;
		if (Lua_BlackJack_ProjectL_UI_TreasureMapUITask.<>f__mg$cache24 == null)
		{
			Lua_BlackJack_ProjectL_UI_TreasureMapUITask.<>f__mg$cache24 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_TreasureMapUITask.set_m_uiCtrlDescArray);
		}
		LuaObject.addMember(l, name2, get2, Lua_BlackJack_ProjectL_UI_TreasureMapUITask.<>f__mg$cache24, true);
		string name3 = "m_treasureMapUIController";
		if (Lua_BlackJack_ProjectL_UI_TreasureMapUITask.<>f__mg$cache25 == null)
		{
			Lua_BlackJack_ProjectL_UI_TreasureMapUITask.<>f__mg$cache25 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_TreasureMapUITask.get_m_treasureMapUIController);
		}
		LuaCSFunction get3 = Lua_BlackJack_ProjectL_UI_TreasureMapUITask.<>f__mg$cache25;
		if (Lua_BlackJack_ProjectL_UI_TreasureMapUITask.<>f__mg$cache26 == null)
		{
			Lua_BlackJack_ProjectL_UI_TreasureMapUITask.<>f__mg$cache26 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_TreasureMapUITask.set_m_treasureMapUIController);
		}
		LuaObject.addMember(l, name3, get3, Lua_BlackJack_ProjectL_UI_TreasureMapUITask.<>f__mg$cache26, true);
		string name4 = "m_playerResourceUIController";
		if (Lua_BlackJack_ProjectL_UI_TreasureMapUITask.<>f__mg$cache27 == null)
		{
			Lua_BlackJack_ProjectL_UI_TreasureMapUITask.<>f__mg$cache27 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_TreasureMapUITask.get_m_playerResourceUIController);
		}
		LuaCSFunction get4 = Lua_BlackJack_ProjectL_UI_TreasureMapUITask.<>f__mg$cache27;
		if (Lua_BlackJack_ProjectL_UI_TreasureMapUITask.<>f__mg$cache28 == null)
		{
			Lua_BlackJack_ProjectL_UI_TreasureMapUITask.<>f__mg$cache28 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_TreasureMapUITask.set_m_playerResourceUIController);
		}
		LuaObject.addMember(l, name4, get4, Lua_BlackJack_ProjectL_UI_TreasureMapUITask.<>f__mg$cache28, true);
		string name5 = "LayerDescArray";
		if (Lua_BlackJack_ProjectL_UI_TreasureMapUITask.<>f__mg$cache29 == null)
		{
			Lua_BlackJack_ProjectL_UI_TreasureMapUITask.<>f__mg$cache29 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_TreasureMapUITask.get_LayerDescArray);
		}
		LuaObject.addMember(l, name5, Lua_BlackJack_ProjectL_UI_TreasureMapUITask.<>f__mg$cache29, null, true);
		string name6 = "UICtrlDescArray";
		if (Lua_BlackJack_ProjectL_UI_TreasureMapUITask.<>f__mg$cache2A == null)
		{
			Lua_BlackJack_ProjectL_UI_TreasureMapUITask.<>f__mg$cache2A = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_TreasureMapUITask.get_UICtrlDescArray);
		}
		LuaObject.addMember(l, name6, Lua_BlackJack_ProjectL_UI_TreasureMapUITask.<>f__mg$cache2A, null, true);
		if (Lua_BlackJack_ProjectL_UI_TreasureMapUITask.<>f__mg$cache2B == null)
		{
			Lua_BlackJack_ProjectL_UI_TreasureMapUITask.<>f__mg$cache2B = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_TreasureMapUITask.constructor);
		}
		LuaObject.createTypeMetatable(l, Lua_BlackJack_ProjectL_UI_TreasureMapUITask.<>f__mg$cache2B, typeof(TreasureMapUITask), typeof(UITask));
	}

	// Token: 0x04017BB2 RID: 97202
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache0;

	// Token: 0x04017BB3 RID: 97203
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1;

	// Token: 0x04017BB4 RID: 97204
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2;

	// Token: 0x04017BB5 RID: 97205
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3;

	// Token: 0x04017BB6 RID: 97206
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache4;

	// Token: 0x04017BB7 RID: 97207
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache5;

	// Token: 0x04017BB8 RID: 97208
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache6;

	// Token: 0x04017BB9 RID: 97209
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache7;

	// Token: 0x04017BBA RID: 97210
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache8;

	// Token: 0x04017BBB RID: 97211
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache9;

	// Token: 0x04017BBC RID: 97212
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheA;

	// Token: 0x04017BBD RID: 97213
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheB;

	// Token: 0x04017BBE RID: 97214
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheC;

	// Token: 0x04017BBF RID: 97215
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheD;

	// Token: 0x04017BC0 RID: 97216
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheE;

	// Token: 0x04017BC1 RID: 97217
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheF;

	// Token: 0x04017BC2 RID: 97218
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache10;

	// Token: 0x04017BC3 RID: 97219
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache11;

	// Token: 0x04017BC4 RID: 97220
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache12;

	// Token: 0x04017BC5 RID: 97221
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache13;

	// Token: 0x04017BC6 RID: 97222
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache14;

	// Token: 0x04017BC7 RID: 97223
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache15;

	// Token: 0x04017BC8 RID: 97224
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache16;

	// Token: 0x04017BC9 RID: 97225
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache17;

	// Token: 0x04017BCA RID: 97226
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache18;

	// Token: 0x04017BCB RID: 97227
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache19;

	// Token: 0x04017BCC RID: 97228
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1A;

	// Token: 0x04017BCD RID: 97229
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1B;

	// Token: 0x04017BCE RID: 97230
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1C;

	// Token: 0x04017BCF RID: 97231
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1D;

	// Token: 0x04017BD0 RID: 97232
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1E;

	// Token: 0x04017BD1 RID: 97233
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1F;

	// Token: 0x04017BD2 RID: 97234
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache20;

	// Token: 0x04017BD3 RID: 97235
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache21;

	// Token: 0x04017BD4 RID: 97236
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache22;

	// Token: 0x04017BD5 RID: 97237
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache23;

	// Token: 0x04017BD6 RID: 97238
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache24;

	// Token: 0x04017BD7 RID: 97239
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache25;

	// Token: 0x04017BD8 RID: 97240
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache26;

	// Token: 0x04017BD9 RID: 97241
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache27;

	// Token: 0x04017BDA RID: 97242
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache28;

	// Token: 0x04017BDB RID: 97243
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache29;

	// Token: 0x04017BDC RID: 97244
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2A;

	// Token: 0x04017BDD RID: 97245
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2B;
}
