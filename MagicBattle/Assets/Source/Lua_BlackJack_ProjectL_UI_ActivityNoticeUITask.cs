using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using BlackJack.BJFramework.Runtime.UI;
using BlackJack.ProjectL.PlayerContext;
using BlackJack.ProjectL.UI;
using SLua;
using UnityEngine.Scripting;

// Token: 0x02001356 RID: 4950
[Preserve]
public class Lua_BlackJack_ProjectL_UI_ActivityNoticeUITask : LuaObject
{
	// Token: 0x0601A9A0 RID: 108960 RVA: 0x007E7C9C File Offset: 0x007E5E9C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int constructor(IntPtr l)
	{
		int result;
		try
		{
			string name;
			LuaObject.checkType(l, 2, out name);
			ActivityNoticeUITask o = new ActivityNoticeUITask(name);
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

	// Token: 0x0601A9A1 RID: 108961 RVA: 0x007E7CF0 File Offset: 0x007E5EF0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int InitAllUIControllers(IntPtr l)
	{
		int result;
		try
		{
			ActivityNoticeUITask activityNoticeUITask = (ActivityNoticeUITask)LuaObject.checkSelf(l);
			activityNoticeUITask.m_luaExportHelper.InitAllUIControllers();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601A9A2 RID: 108962 RVA: 0x007E7D44 File Offset: 0x007E5F44
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int ClearAllContextAndRes(IntPtr l)
	{
		int result;
		try
		{
			ActivityNoticeUITask activityNoticeUITask = (ActivityNoticeUITask)LuaObject.checkSelf(l);
			activityNoticeUITask.m_luaExportHelper.ClearAllContextAndRes();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601A9A3 RID: 108963 RVA: 0x007E7D98 File Offset: 0x007E5F98
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int IsNeedLoadDynamicRes(IntPtr l)
	{
		int result;
		try
		{
			ActivityNoticeUITask activityNoticeUITask = (ActivityNoticeUITask)LuaObject.checkSelf(l);
			bool b = activityNoticeUITask.m_luaExportHelper.IsNeedLoadDynamicRes();
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

	// Token: 0x0601A9A4 RID: 108964 RVA: 0x007E7DF4 File Offset: 0x007E5FF4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int UpdateView(IntPtr l)
	{
		int result;
		try
		{
			ActivityNoticeUITask activityNoticeUITask = (ActivityNoticeUITask)LuaObject.checkSelf(l);
			activityNoticeUITask.m_luaExportHelper.UpdateView();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601A9A5 RID: 108965 RVA: 0x007E7E48 File Offset: 0x007E6048
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int ActivityNoticeUIController_ActivityClick(IntPtr l)
	{
		int result;
		try
		{
			ActivityNoticeUITask activityNoticeUITask = (ActivityNoticeUITask)LuaObject.checkSelf(l);
			int activityId;
			LuaObject.checkType(l, 2, out activityId);
			activityNoticeUITask.m_luaExportHelper.ActivityNoticeUIController_ActivityClick(activityId);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601A9A6 RID: 108966 RVA: 0x007E7EA4 File Offset: 0x007E60A4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int ActivityNoticeUIController_CloseButtonClick(IntPtr l)
	{
		int result;
		try
		{
			ActivityNoticeUITask activityNoticeUITask = (ActivityNoticeUITask)LuaObject.checkSelf(l);
			activityNoticeUITask.m_luaExportHelper.ActivityNoticeUIController_CloseButtonClick();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601A9A7 RID: 108967 RVA: 0x007E7EF8 File Offset: 0x007E60F8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_OnStart(IntPtr l)
	{
		int result;
		try
		{
			ActivityNoticeUITask activityNoticeUITask = (ActivityNoticeUITask)LuaObject.checkSelf(l);
			UIIntent intent;
			LuaObject.checkType<UIIntent>(l, 2, out intent);
			bool b = activityNoticeUITask.m_luaExportHelper.__callBase_OnStart(intent);
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

	// Token: 0x0601A9A8 RID: 108968 RVA: 0x007E7F60 File Offset: 0x007E6160
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_OnStop(IntPtr l)
	{
		int result;
		try
		{
			ActivityNoticeUITask activityNoticeUITask = (ActivityNoticeUITask)LuaObject.checkSelf(l);
			activityNoticeUITask.m_luaExportHelper.__callBase_OnStop();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601A9A9 RID: 108969 RVA: 0x007E7FB4 File Offset: 0x007E61B4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_OnPause(IntPtr l)
	{
		int result;
		try
		{
			ActivityNoticeUITask activityNoticeUITask = (ActivityNoticeUITask)LuaObject.checkSelf(l);
			activityNoticeUITask.m_luaExportHelper.__callBase_OnPause();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601A9AA RID: 108970 RVA: 0x007E8008 File Offset: 0x007E6208
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_OnResume(IntPtr l)
	{
		int result;
		try
		{
			ActivityNoticeUITask activityNoticeUITask = (ActivityNoticeUITask)LuaObject.checkSelf(l);
			UIIntent intent;
			LuaObject.checkType<UIIntent>(l, 2, out intent);
			bool b = activityNoticeUITask.m_luaExportHelper.__callBase_OnResume(intent);
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

	// Token: 0x0601A9AB RID: 108971 RVA: 0x007E8070 File Offset: 0x007E6270
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_OnNewIntent(IntPtr l)
	{
		int result;
		try
		{
			ActivityNoticeUITask activityNoticeUITask = (ActivityNoticeUITask)LuaObject.checkSelf(l);
			UIIntent intent;
			LuaObject.checkType<UIIntent>(l, 2, out intent);
			bool b = activityNoticeUITask.m_luaExportHelper.__callBase_OnNewIntent(intent);
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

	// Token: 0x0601A9AC RID: 108972 RVA: 0x007E80D8 File Offset: 0x007E62D8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_EnableUIInput(IntPtr l)
	{
		int result;
		try
		{
			ActivityNoticeUITask activityNoticeUITask = (ActivityNoticeUITask)LuaObject.checkSelf(l);
			bool isEnable;
			LuaObject.checkType(l, 2, out isEnable);
			bool? isGlobalEnable;
			LuaObject.checkNullable<bool>(l, 3, out isGlobalEnable);
			activityNoticeUITask.m_luaExportHelper.__callBase_EnableUIInput(isEnable, isGlobalEnable);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601A9AD RID: 108973 RVA: 0x007E8144 File Offset: 0x007E6344
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_IsNeedLoadDynamicRes(IntPtr l)
	{
		int result;
		try
		{
			ActivityNoticeUITask activityNoticeUITask = (ActivityNoticeUITask)LuaObject.checkSelf(l);
			bool b = activityNoticeUITask.m_luaExportHelper.__callBase_IsNeedLoadDynamicRes();
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

	// Token: 0x0601A9AE RID: 108974 RVA: 0x007E81A0 File Offset: 0x007E63A0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_CollectAllDynamicResForLoad(IntPtr l)
	{
		int result;
		try
		{
			ActivityNoticeUITask activityNoticeUITask = (ActivityNoticeUITask)LuaObject.checkSelf(l);
			List<string> o = activityNoticeUITask.m_luaExportHelper.__callBase_CollectAllDynamicResForLoad();
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

	// Token: 0x0601A9AF RID: 108975 RVA: 0x007E81FC File Offset: 0x007E63FC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_RegisterPlayerContextEvents(IntPtr l)
	{
		int result;
		try
		{
			ActivityNoticeUITask activityNoticeUITask = (ActivityNoticeUITask)LuaObject.checkSelf(l);
			activityNoticeUITask.m_luaExportHelper.__callBase_RegisterPlayerContextEvents();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601A9B0 RID: 108976 RVA: 0x007E8250 File Offset: 0x007E6450
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_UnregisterPlayerContextEvents(IntPtr l)
	{
		int result;
		try
		{
			ActivityNoticeUITask activityNoticeUITask = (ActivityNoticeUITask)LuaObject.checkSelf(l);
			activityNoticeUITask.m_luaExportHelper.__callBase_UnregisterPlayerContextEvents();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601A9B1 RID: 108977 RVA: 0x007E82A4 File Offset: 0x007E64A4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_PostUpdateView(IntPtr l)
	{
		int result;
		try
		{
			ActivityNoticeUITask activityNoticeUITask = (ActivityNoticeUITask)LuaObject.checkSelf(l);
			activityNoticeUITask.m_luaExportHelper.__callBase_PostUpdateView();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601A9B2 RID: 108978 RVA: 0x007E82F8 File Offset: 0x007E64F8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_CollectPreloadResourceList(IntPtr l)
	{
		int result;
		try
		{
			ActivityNoticeUITask activityNoticeUITask = (ActivityNoticeUITask)LuaObject.checkSelf(l);
			activityNoticeUITask.m_luaExportHelper.__callBase_CollectPreloadResourceList();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601A9B3 RID: 108979 RVA: 0x007E834C File Offset: 0x007E654C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_ClearAssetList(IntPtr l)
	{
		int result;
		try
		{
			ActivityNoticeUITask activityNoticeUITask = (ActivityNoticeUITask)LuaObject.checkSelf(l);
			activityNoticeUITask.m_luaExportHelper.__callBase_ClearAssetList();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601A9B4 RID: 108980 RVA: 0x007E83A0 File Offset: 0x007E65A0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_CollectAsset(IntPtr l)
	{
		int result;
		try
		{
			ActivityNoticeUITask activityNoticeUITask = (ActivityNoticeUITask)LuaObject.checkSelf(l);
			string assetName;
			LuaObject.checkType(l, 2, out assetName);
			activityNoticeUITask.m_luaExportHelper.__callBase_CollectAsset(assetName);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601A9B5 RID: 108981 RVA: 0x007E83FC File Offset: 0x007E65FC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_CollectSpriteAsset(IntPtr l)
	{
		int result;
		try
		{
			ActivityNoticeUITask activityNoticeUITask = (ActivityNoticeUITask)LuaObject.checkSelf(l);
			string assetName;
			LuaObject.checkType(l, 2, out assetName);
			activityNoticeUITask.m_luaExportHelper.__callBase_CollectSpriteAsset(assetName);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601A9B6 RID: 108982 RVA: 0x007E8458 File Offset: 0x007E6658
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_CollectFxAsset(IntPtr l)
	{
		int result;
		try
		{
			ActivityNoticeUITask activityNoticeUITask = (ActivityNoticeUITask)LuaObject.checkSelf(l);
			string assetName;
			LuaObject.checkType(l, 2, out assetName);
			activityNoticeUITask.m_luaExportHelper.__callBase_CollectFxAsset(assetName);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601A9B7 RID: 108983 RVA: 0x007E84B4 File Offset: 0x007E66B4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_StartLoadCustomAssets(IntPtr l)
	{
		int result;
		try
		{
			ActivityNoticeUITask activityNoticeUITask = (ActivityNoticeUITask)LuaObject.checkSelf(l);
			Action onLoadCompleted;
			LuaObject.checkDelegate<Action>(l, 2, out onLoadCompleted);
			activityNoticeUITask.m_luaExportHelper.__callBase_StartLoadCustomAssets(onLoadCompleted);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601A9B8 RID: 108984 RVA: 0x007E8510 File Offset: 0x007E6710
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_IsLoadingCustomAssets(IntPtr l)
	{
		int result;
		try
		{
			ActivityNoticeUITask activityNoticeUITask = (ActivityNoticeUITask)LuaObject.checkSelf(l);
			bool b = activityNoticeUITask.m_luaExportHelper.__callBase_IsLoadingCustomAssets();
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

	// Token: 0x0601A9B9 RID: 108985 RVA: 0x007E856C File Offset: 0x007E676C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_IsPipeLineRunning(IntPtr l)
	{
		int result;
		try
		{
			ActivityNoticeUITask activityNoticeUITask = (ActivityNoticeUITask)LuaObject.checkSelf(l);
			bool b = activityNoticeUITask.m_luaExportHelper.__callBase_IsPipeLineRunning();
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

	// Token: 0x0601A9BA RID: 108986 RVA: 0x007E85C8 File Offset: 0x007E67C8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_IsOpeningUI(IntPtr l)
	{
		int result;
		try
		{
			ActivityNoticeUITask activityNoticeUITask = (ActivityNoticeUITask)LuaObject.checkSelf(l);
			bool b = activityNoticeUITask.m_luaExportHelper.__callBase_IsOpeningUI();
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

	// Token: 0x0601A9BB RID: 108987 RVA: 0x007E8624 File Offset: 0x007E6824
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_ReturnPrevUITask(IntPtr l)
	{
		int result;
		try
		{
			ActivityNoticeUITask activityNoticeUITask = (ActivityNoticeUITask)LuaObject.checkSelf(l);
			UITaskBase o = activityNoticeUITask.m_luaExportHelper.__callBase_ReturnPrevUITask();
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

	// Token: 0x0601A9BC RID: 108988 RVA: 0x007E8680 File Offset: 0x007E6880
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_ClearUnusedDynamicResourceCache(IntPtr l)
	{
		int result;
		try
		{
			ActivityNoticeUITask activityNoticeUITask = (ActivityNoticeUITask)LuaObject.checkSelf(l);
			activityNoticeUITask.m_luaExportHelper.__callBase_ClearUnusedDynamicResourceCache();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601A9BD RID: 108989 RVA: 0x007E86D4 File Offset: 0x007E68D4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_OnMemoryWarning(IntPtr l)
	{
		int result;
		try
		{
			ActivityNoticeUITask activityNoticeUITask = (ActivityNoticeUITask)LuaObject.checkSelf(l);
			activityNoticeUITask.m_luaExportHelper.__callBase_OnMemoryWarning();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601A9BE RID: 108990 RVA: 0x007E8728 File Offset: 0x007E6928
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_layerDescArray(IntPtr l)
	{
		int result;
		try
		{
			ActivityNoticeUITask activityNoticeUITask = (ActivityNoticeUITask)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, activityNoticeUITask.m_luaExportHelper.m_layerDescArray);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601A9BF RID: 108991 RVA: 0x007E8780 File Offset: 0x007E6980
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_layerDescArray(IntPtr l)
	{
		int result;
		try
		{
			ActivityNoticeUITask activityNoticeUITask = (ActivityNoticeUITask)LuaObject.checkSelf(l);
			UITaskBase.LayerDesc[] layerDescArray;
			LuaObject.checkArray<UITaskBase.LayerDesc>(l, 2, out layerDescArray);
			activityNoticeUITask.m_luaExportHelper.m_layerDescArray = layerDescArray;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601A9C0 RID: 108992 RVA: 0x007E87DC File Offset: 0x007E69DC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_uiCtrlDescArray(IntPtr l)
	{
		int result;
		try
		{
			ActivityNoticeUITask activityNoticeUITask = (ActivityNoticeUITask)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, activityNoticeUITask.m_luaExportHelper.m_uiCtrlDescArray);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601A9C1 RID: 108993 RVA: 0x007E8834 File Offset: 0x007E6A34
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_uiCtrlDescArray(IntPtr l)
	{
		int result;
		try
		{
			ActivityNoticeUITask activityNoticeUITask = (ActivityNoticeUITask)LuaObject.checkSelf(l);
			UITaskBase.UIControllerDesc[] uiCtrlDescArray;
			LuaObject.checkArray<UITaskBase.UIControllerDesc>(l, 2, out uiCtrlDescArray);
			activityNoticeUITask.m_luaExportHelper.m_uiCtrlDescArray = uiCtrlDescArray;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601A9C2 RID: 108994 RVA: 0x007E8890 File Offset: 0x007E6A90
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_activityNoticeUICtrl(IntPtr l)
	{
		int result;
		try
		{
			ActivityNoticeUITask activityNoticeUITask = (ActivityNoticeUITask)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, activityNoticeUITask.m_luaExportHelper.m_activityNoticeUICtrl);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601A9C3 RID: 108995 RVA: 0x007E88E8 File Offset: 0x007E6AE8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_activityNoticeUICtrl(IntPtr l)
	{
		int result;
		try
		{
			ActivityNoticeUITask activityNoticeUITask = (ActivityNoticeUITask)LuaObject.checkSelf(l);
			ActivityNoticeUIController activityNoticeUICtrl;
			LuaObject.checkType<ActivityNoticeUIController>(l, 2, out activityNoticeUICtrl);
			activityNoticeUITask.m_luaExportHelper.m_activityNoticeUICtrl = activityNoticeUICtrl;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601A9C4 RID: 108996 RVA: 0x007E8944 File Offset: 0x007E6B44
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_playerCtx(IntPtr l)
	{
		int result;
		try
		{
			ActivityNoticeUITask activityNoticeUITask = (ActivityNoticeUITask)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, activityNoticeUITask.m_luaExportHelper.m_playerCtx);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601A9C5 RID: 108997 RVA: 0x007E899C File Offset: 0x007E6B9C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_playerCtx(IntPtr l)
	{
		int result;
		try
		{
			ActivityNoticeUITask activityNoticeUITask = (ActivityNoticeUITask)LuaObject.checkSelf(l);
			ProjectLPlayerContext playerCtx;
			LuaObject.checkType<ProjectLPlayerContext>(l, 2, out playerCtx);
			activityNoticeUITask.m_luaExportHelper.m_playerCtx = playerCtx;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601A9C6 RID: 108998 RVA: 0x007E89F8 File Offset: 0x007E6BF8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_LayerDescArray(IntPtr l)
	{
		int result;
		try
		{
			ActivityNoticeUITask activityNoticeUITask = (ActivityNoticeUITask)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, activityNoticeUITask.m_luaExportHelper.LayerDescArray);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601A9C7 RID: 108999 RVA: 0x007E8A50 File Offset: 0x007E6C50
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_UICtrlDescArray(IntPtr l)
	{
		int result;
		try
		{
			ActivityNoticeUITask activityNoticeUITask = (ActivityNoticeUITask)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, activityNoticeUITask.m_luaExportHelper.UICtrlDescArray);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601A9C8 RID: 109000 RVA: 0x007E8AA8 File Offset: 0x007E6CA8
	[Preserve]
	public static void reg(IntPtr l)
	{
		LuaObject.getTypeTable(l, "BlackJack.ProjectL.UI.ActivityNoticeUITask");
		if (Lua_BlackJack_ProjectL_UI_ActivityNoticeUITask.<>f__mg$cache0 == null)
		{
			Lua_BlackJack_ProjectL_UI_ActivityNoticeUITask.<>f__mg$cache0 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ActivityNoticeUITask.InitAllUIControllers);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_ActivityNoticeUITask.<>f__mg$cache0);
		if (Lua_BlackJack_ProjectL_UI_ActivityNoticeUITask.<>f__mg$cache1 == null)
		{
			Lua_BlackJack_ProjectL_UI_ActivityNoticeUITask.<>f__mg$cache1 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ActivityNoticeUITask.ClearAllContextAndRes);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_ActivityNoticeUITask.<>f__mg$cache1);
		if (Lua_BlackJack_ProjectL_UI_ActivityNoticeUITask.<>f__mg$cache2 == null)
		{
			Lua_BlackJack_ProjectL_UI_ActivityNoticeUITask.<>f__mg$cache2 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ActivityNoticeUITask.IsNeedLoadDynamicRes);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_ActivityNoticeUITask.<>f__mg$cache2);
		if (Lua_BlackJack_ProjectL_UI_ActivityNoticeUITask.<>f__mg$cache3 == null)
		{
			Lua_BlackJack_ProjectL_UI_ActivityNoticeUITask.<>f__mg$cache3 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ActivityNoticeUITask.UpdateView);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_ActivityNoticeUITask.<>f__mg$cache3);
		if (Lua_BlackJack_ProjectL_UI_ActivityNoticeUITask.<>f__mg$cache4 == null)
		{
			Lua_BlackJack_ProjectL_UI_ActivityNoticeUITask.<>f__mg$cache4 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ActivityNoticeUITask.ActivityNoticeUIController_ActivityClick);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_ActivityNoticeUITask.<>f__mg$cache4);
		if (Lua_BlackJack_ProjectL_UI_ActivityNoticeUITask.<>f__mg$cache5 == null)
		{
			Lua_BlackJack_ProjectL_UI_ActivityNoticeUITask.<>f__mg$cache5 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ActivityNoticeUITask.ActivityNoticeUIController_CloseButtonClick);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_ActivityNoticeUITask.<>f__mg$cache5);
		if (Lua_BlackJack_ProjectL_UI_ActivityNoticeUITask.<>f__mg$cache6 == null)
		{
			Lua_BlackJack_ProjectL_UI_ActivityNoticeUITask.<>f__mg$cache6 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ActivityNoticeUITask.__callBase_OnStart);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_ActivityNoticeUITask.<>f__mg$cache6);
		if (Lua_BlackJack_ProjectL_UI_ActivityNoticeUITask.<>f__mg$cache7 == null)
		{
			Lua_BlackJack_ProjectL_UI_ActivityNoticeUITask.<>f__mg$cache7 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ActivityNoticeUITask.__callBase_OnStop);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_ActivityNoticeUITask.<>f__mg$cache7);
		if (Lua_BlackJack_ProjectL_UI_ActivityNoticeUITask.<>f__mg$cache8 == null)
		{
			Lua_BlackJack_ProjectL_UI_ActivityNoticeUITask.<>f__mg$cache8 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ActivityNoticeUITask.__callBase_OnPause);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_ActivityNoticeUITask.<>f__mg$cache8);
		if (Lua_BlackJack_ProjectL_UI_ActivityNoticeUITask.<>f__mg$cache9 == null)
		{
			Lua_BlackJack_ProjectL_UI_ActivityNoticeUITask.<>f__mg$cache9 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ActivityNoticeUITask.__callBase_OnResume);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_ActivityNoticeUITask.<>f__mg$cache9);
		if (Lua_BlackJack_ProjectL_UI_ActivityNoticeUITask.<>f__mg$cacheA == null)
		{
			Lua_BlackJack_ProjectL_UI_ActivityNoticeUITask.<>f__mg$cacheA = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ActivityNoticeUITask.__callBase_OnNewIntent);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_ActivityNoticeUITask.<>f__mg$cacheA);
		if (Lua_BlackJack_ProjectL_UI_ActivityNoticeUITask.<>f__mg$cacheB == null)
		{
			Lua_BlackJack_ProjectL_UI_ActivityNoticeUITask.<>f__mg$cacheB = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ActivityNoticeUITask.__callBase_EnableUIInput);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_ActivityNoticeUITask.<>f__mg$cacheB);
		if (Lua_BlackJack_ProjectL_UI_ActivityNoticeUITask.<>f__mg$cacheC == null)
		{
			Lua_BlackJack_ProjectL_UI_ActivityNoticeUITask.<>f__mg$cacheC = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ActivityNoticeUITask.__callBase_IsNeedLoadDynamicRes);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_ActivityNoticeUITask.<>f__mg$cacheC);
		if (Lua_BlackJack_ProjectL_UI_ActivityNoticeUITask.<>f__mg$cacheD == null)
		{
			Lua_BlackJack_ProjectL_UI_ActivityNoticeUITask.<>f__mg$cacheD = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ActivityNoticeUITask.__callBase_CollectAllDynamicResForLoad);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_ActivityNoticeUITask.<>f__mg$cacheD);
		if (Lua_BlackJack_ProjectL_UI_ActivityNoticeUITask.<>f__mg$cacheE == null)
		{
			Lua_BlackJack_ProjectL_UI_ActivityNoticeUITask.<>f__mg$cacheE = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ActivityNoticeUITask.__callBase_RegisterPlayerContextEvents);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_ActivityNoticeUITask.<>f__mg$cacheE);
		if (Lua_BlackJack_ProjectL_UI_ActivityNoticeUITask.<>f__mg$cacheF == null)
		{
			Lua_BlackJack_ProjectL_UI_ActivityNoticeUITask.<>f__mg$cacheF = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ActivityNoticeUITask.__callBase_UnregisterPlayerContextEvents);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_ActivityNoticeUITask.<>f__mg$cacheF);
		if (Lua_BlackJack_ProjectL_UI_ActivityNoticeUITask.<>f__mg$cache10 == null)
		{
			Lua_BlackJack_ProjectL_UI_ActivityNoticeUITask.<>f__mg$cache10 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ActivityNoticeUITask.__callBase_PostUpdateView);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_ActivityNoticeUITask.<>f__mg$cache10);
		if (Lua_BlackJack_ProjectL_UI_ActivityNoticeUITask.<>f__mg$cache11 == null)
		{
			Lua_BlackJack_ProjectL_UI_ActivityNoticeUITask.<>f__mg$cache11 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ActivityNoticeUITask.__callBase_CollectPreloadResourceList);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_ActivityNoticeUITask.<>f__mg$cache11);
		if (Lua_BlackJack_ProjectL_UI_ActivityNoticeUITask.<>f__mg$cache12 == null)
		{
			Lua_BlackJack_ProjectL_UI_ActivityNoticeUITask.<>f__mg$cache12 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ActivityNoticeUITask.__callBase_ClearAssetList);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_ActivityNoticeUITask.<>f__mg$cache12);
		if (Lua_BlackJack_ProjectL_UI_ActivityNoticeUITask.<>f__mg$cache13 == null)
		{
			Lua_BlackJack_ProjectL_UI_ActivityNoticeUITask.<>f__mg$cache13 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ActivityNoticeUITask.__callBase_CollectAsset);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_ActivityNoticeUITask.<>f__mg$cache13);
		if (Lua_BlackJack_ProjectL_UI_ActivityNoticeUITask.<>f__mg$cache14 == null)
		{
			Lua_BlackJack_ProjectL_UI_ActivityNoticeUITask.<>f__mg$cache14 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ActivityNoticeUITask.__callBase_CollectSpriteAsset);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_ActivityNoticeUITask.<>f__mg$cache14);
		if (Lua_BlackJack_ProjectL_UI_ActivityNoticeUITask.<>f__mg$cache15 == null)
		{
			Lua_BlackJack_ProjectL_UI_ActivityNoticeUITask.<>f__mg$cache15 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ActivityNoticeUITask.__callBase_CollectFxAsset);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_ActivityNoticeUITask.<>f__mg$cache15);
		if (Lua_BlackJack_ProjectL_UI_ActivityNoticeUITask.<>f__mg$cache16 == null)
		{
			Lua_BlackJack_ProjectL_UI_ActivityNoticeUITask.<>f__mg$cache16 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ActivityNoticeUITask.__callBase_StartLoadCustomAssets);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_ActivityNoticeUITask.<>f__mg$cache16);
		if (Lua_BlackJack_ProjectL_UI_ActivityNoticeUITask.<>f__mg$cache17 == null)
		{
			Lua_BlackJack_ProjectL_UI_ActivityNoticeUITask.<>f__mg$cache17 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ActivityNoticeUITask.__callBase_IsLoadingCustomAssets);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_ActivityNoticeUITask.<>f__mg$cache17);
		if (Lua_BlackJack_ProjectL_UI_ActivityNoticeUITask.<>f__mg$cache18 == null)
		{
			Lua_BlackJack_ProjectL_UI_ActivityNoticeUITask.<>f__mg$cache18 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ActivityNoticeUITask.__callBase_IsPipeLineRunning);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_ActivityNoticeUITask.<>f__mg$cache18);
		if (Lua_BlackJack_ProjectL_UI_ActivityNoticeUITask.<>f__mg$cache19 == null)
		{
			Lua_BlackJack_ProjectL_UI_ActivityNoticeUITask.<>f__mg$cache19 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ActivityNoticeUITask.__callBase_IsOpeningUI);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_ActivityNoticeUITask.<>f__mg$cache19);
		if (Lua_BlackJack_ProjectL_UI_ActivityNoticeUITask.<>f__mg$cache1A == null)
		{
			Lua_BlackJack_ProjectL_UI_ActivityNoticeUITask.<>f__mg$cache1A = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ActivityNoticeUITask.__callBase_ReturnPrevUITask);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_ActivityNoticeUITask.<>f__mg$cache1A);
		if (Lua_BlackJack_ProjectL_UI_ActivityNoticeUITask.<>f__mg$cache1B == null)
		{
			Lua_BlackJack_ProjectL_UI_ActivityNoticeUITask.<>f__mg$cache1B = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ActivityNoticeUITask.__callBase_ClearUnusedDynamicResourceCache);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_ActivityNoticeUITask.<>f__mg$cache1B);
		if (Lua_BlackJack_ProjectL_UI_ActivityNoticeUITask.<>f__mg$cache1C == null)
		{
			Lua_BlackJack_ProjectL_UI_ActivityNoticeUITask.<>f__mg$cache1C = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ActivityNoticeUITask.__callBase_OnMemoryWarning);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_ActivityNoticeUITask.<>f__mg$cache1C);
		string name = "m_layerDescArray";
		if (Lua_BlackJack_ProjectL_UI_ActivityNoticeUITask.<>f__mg$cache1D == null)
		{
			Lua_BlackJack_ProjectL_UI_ActivityNoticeUITask.<>f__mg$cache1D = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ActivityNoticeUITask.get_m_layerDescArray);
		}
		LuaCSFunction get = Lua_BlackJack_ProjectL_UI_ActivityNoticeUITask.<>f__mg$cache1D;
		if (Lua_BlackJack_ProjectL_UI_ActivityNoticeUITask.<>f__mg$cache1E == null)
		{
			Lua_BlackJack_ProjectL_UI_ActivityNoticeUITask.<>f__mg$cache1E = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ActivityNoticeUITask.set_m_layerDescArray);
		}
		LuaObject.addMember(l, name, get, Lua_BlackJack_ProjectL_UI_ActivityNoticeUITask.<>f__mg$cache1E, true);
		string name2 = "m_uiCtrlDescArray";
		if (Lua_BlackJack_ProjectL_UI_ActivityNoticeUITask.<>f__mg$cache1F == null)
		{
			Lua_BlackJack_ProjectL_UI_ActivityNoticeUITask.<>f__mg$cache1F = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ActivityNoticeUITask.get_m_uiCtrlDescArray);
		}
		LuaCSFunction get2 = Lua_BlackJack_ProjectL_UI_ActivityNoticeUITask.<>f__mg$cache1F;
		if (Lua_BlackJack_ProjectL_UI_ActivityNoticeUITask.<>f__mg$cache20 == null)
		{
			Lua_BlackJack_ProjectL_UI_ActivityNoticeUITask.<>f__mg$cache20 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ActivityNoticeUITask.set_m_uiCtrlDescArray);
		}
		LuaObject.addMember(l, name2, get2, Lua_BlackJack_ProjectL_UI_ActivityNoticeUITask.<>f__mg$cache20, true);
		string name3 = "m_activityNoticeUICtrl";
		if (Lua_BlackJack_ProjectL_UI_ActivityNoticeUITask.<>f__mg$cache21 == null)
		{
			Lua_BlackJack_ProjectL_UI_ActivityNoticeUITask.<>f__mg$cache21 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ActivityNoticeUITask.get_m_activityNoticeUICtrl);
		}
		LuaCSFunction get3 = Lua_BlackJack_ProjectL_UI_ActivityNoticeUITask.<>f__mg$cache21;
		if (Lua_BlackJack_ProjectL_UI_ActivityNoticeUITask.<>f__mg$cache22 == null)
		{
			Lua_BlackJack_ProjectL_UI_ActivityNoticeUITask.<>f__mg$cache22 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ActivityNoticeUITask.set_m_activityNoticeUICtrl);
		}
		LuaObject.addMember(l, name3, get3, Lua_BlackJack_ProjectL_UI_ActivityNoticeUITask.<>f__mg$cache22, true);
		string name4 = "m_playerCtx";
		if (Lua_BlackJack_ProjectL_UI_ActivityNoticeUITask.<>f__mg$cache23 == null)
		{
			Lua_BlackJack_ProjectL_UI_ActivityNoticeUITask.<>f__mg$cache23 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ActivityNoticeUITask.get_m_playerCtx);
		}
		LuaCSFunction get4 = Lua_BlackJack_ProjectL_UI_ActivityNoticeUITask.<>f__mg$cache23;
		if (Lua_BlackJack_ProjectL_UI_ActivityNoticeUITask.<>f__mg$cache24 == null)
		{
			Lua_BlackJack_ProjectL_UI_ActivityNoticeUITask.<>f__mg$cache24 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ActivityNoticeUITask.set_m_playerCtx);
		}
		LuaObject.addMember(l, name4, get4, Lua_BlackJack_ProjectL_UI_ActivityNoticeUITask.<>f__mg$cache24, true);
		string name5 = "LayerDescArray";
		if (Lua_BlackJack_ProjectL_UI_ActivityNoticeUITask.<>f__mg$cache25 == null)
		{
			Lua_BlackJack_ProjectL_UI_ActivityNoticeUITask.<>f__mg$cache25 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ActivityNoticeUITask.get_LayerDescArray);
		}
		LuaObject.addMember(l, name5, Lua_BlackJack_ProjectL_UI_ActivityNoticeUITask.<>f__mg$cache25, null, true);
		string name6 = "UICtrlDescArray";
		if (Lua_BlackJack_ProjectL_UI_ActivityNoticeUITask.<>f__mg$cache26 == null)
		{
			Lua_BlackJack_ProjectL_UI_ActivityNoticeUITask.<>f__mg$cache26 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ActivityNoticeUITask.get_UICtrlDescArray);
		}
		LuaObject.addMember(l, name6, Lua_BlackJack_ProjectL_UI_ActivityNoticeUITask.<>f__mg$cache26, null, true);
		if (Lua_BlackJack_ProjectL_UI_ActivityNoticeUITask.<>f__mg$cache27 == null)
		{
			Lua_BlackJack_ProjectL_UI_ActivityNoticeUITask.<>f__mg$cache27 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ActivityNoticeUITask.constructor);
		}
		LuaObject.createTypeMetatable(l, Lua_BlackJack_ProjectL_UI_ActivityNoticeUITask.<>f__mg$cache27, typeof(ActivityNoticeUITask), typeof(UITask));
	}

	// Token: 0x04010CD6 RID: 68822
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache0;

	// Token: 0x04010CD7 RID: 68823
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1;

	// Token: 0x04010CD8 RID: 68824
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2;

	// Token: 0x04010CD9 RID: 68825
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3;

	// Token: 0x04010CDA RID: 68826
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache4;

	// Token: 0x04010CDB RID: 68827
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache5;

	// Token: 0x04010CDC RID: 68828
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache6;

	// Token: 0x04010CDD RID: 68829
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache7;

	// Token: 0x04010CDE RID: 68830
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache8;

	// Token: 0x04010CDF RID: 68831
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache9;

	// Token: 0x04010CE0 RID: 68832
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheA;

	// Token: 0x04010CE1 RID: 68833
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheB;

	// Token: 0x04010CE2 RID: 68834
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheC;

	// Token: 0x04010CE3 RID: 68835
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheD;

	// Token: 0x04010CE4 RID: 68836
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheE;

	// Token: 0x04010CE5 RID: 68837
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheF;

	// Token: 0x04010CE6 RID: 68838
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache10;

	// Token: 0x04010CE7 RID: 68839
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache11;

	// Token: 0x04010CE8 RID: 68840
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache12;

	// Token: 0x04010CE9 RID: 68841
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache13;

	// Token: 0x04010CEA RID: 68842
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache14;

	// Token: 0x04010CEB RID: 68843
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache15;

	// Token: 0x04010CEC RID: 68844
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache16;

	// Token: 0x04010CED RID: 68845
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache17;

	// Token: 0x04010CEE RID: 68846
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache18;

	// Token: 0x04010CEF RID: 68847
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache19;

	// Token: 0x04010CF0 RID: 68848
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1A;

	// Token: 0x04010CF1 RID: 68849
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1B;

	// Token: 0x04010CF2 RID: 68850
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1C;

	// Token: 0x04010CF3 RID: 68851
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1D;

	// Token: 0x04010CF4 RID: 68852
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1E;

	// Token: 0x04010CF5 RID: 68853
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1F;

	// Token: 0x04010CF6 RID: 68854
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache20;

	// Token: 0x04010CF7 RID: 68855
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache21;

	// Token: 0x04010CF8 RID: 68856
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache22;

	// Token: 0x04010CF9 RID: 68857
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache23;

	// Token: 0x04010CFA RID: 68858
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache24;

	// Token: 0x04010CFB RID: 68859
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache25;

	// Token: 0x04010CFC RID: 68860
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache26;

	// Token: 0x04010CFD RID: 68861
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache27;
}
