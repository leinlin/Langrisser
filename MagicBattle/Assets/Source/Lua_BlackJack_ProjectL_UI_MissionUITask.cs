using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using BlackJack.BJFramework.Runtime.UI;
using BlackJack.ConfigData;
using BlackJack.ProjectL.UI;
using SLua;
using UnityEngine.Scripting;

// Token: 0x02001512 RID: 5394
[Preserve]
public class Lua_BlackJack_ProjectL_UI_MissionUITask : LuaObject
{
	// Token: 0x0601FFB0 RID: 130992 RVA: 0x00A943B8 File Offset: 0x00A925B8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int constructor(IntPtr l)
	{
		int result;
		try
		{
			string name;
			LuaObject.checkType(l, 2, out name);
			MissionUITask o = new MissionUITask(name);
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

	// Token: 0x0601FFB1 RID: 130993 RVA: 0x00A9440C File Offset: 0x00A9260C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int IsNeedLoadDynamicRes(IntPtr l)
	{
		int result;
		try
		{
			MissionUITask missionUITask = (MissionUITask)LuaObject.checkSelf(l);
			bool b = missionUITask.m_luaExportHelper.IsNeedLoadDynamicRes();
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

	// Token: 0x0601FFB2 RID: 130994 RVA: 0x00A94468 File Offset: 0x00A92668
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int InitAllUIControllers(IntPtr l)
	{
		int result;
		try
		{
			MissionUITask missionUITask = (MissionUITask)LuaObject.checkSelf(l);
			missionUITask.m_luaExportHelper.InitAllUIControllers();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601FFB3 RID: 130995 RVA: 0x00A944BC File Offset: 0x00A926BC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int ClearAllContextAndRes(IntPtr l)
	{
		int result;
		try
		{
			MissionUITask missionUITask = (MissionUITask)LuaObject.checkSelf(l);
			missionUITask.m_luaExportHelper.ClearAllContextAndRes();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601FFB4 RID: 130996 RVA: 0x00A94510 File Offset: 0x00A92710
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int OnStart(IntPtr l)
	{
		int result;
		try
		{
			MissionUITask missionUITask = (MissionUITask)LuaObject.checkSelf(l);
			UIIntent intent;
			LuaObject.checkType<UIIntent>(l, 2, out intent);
			bool b = missionUITask.m_luaExportHelper.OnStart(intent);
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

	// Token: 0x0601FFB5 RID: 130997 RVA: 0x00A94578 File Offset: 0x00A92778
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int OnStop(IntPtr l)
	{
		int result;
		try
		{
			MissionUITask missionUITask = (MissionUITask)LuaObject.checkSelf(l);
			missionUITask.m_luaExportHelper.OnStop();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601FFB6 RID: 130998 RVA: 0x00A945CC File Offset: 0x00A927CC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int UpdateView(IntPtr l)
	{
		int result;
		try
		{
			MissionUITask missionUITask = (MissionUITask)LuaObject.checkSelf(l);
			missionUITask.m_luaExportHelper.UpdateView();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601FFB7 RID: 130999 RVA: 0x00A94620 File Offset: 0x00A92820
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int MissionUIController_OnClose(IntPtr l)
	{
		int result;
		try
		{
			MissionUITask missionUITask = (MissionUITask)LuaObject.checkSelf(l);
			missionUITask.m_luaExportHelper.MissionUIController_OnClose();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601FFB8 RID: 131000 RVA: 0x00A94674 File Offset: 0x00A92874
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int MissionUIController_OnGetReward(IntPtr l)
	{
		int result;
		try
		{
			MissionUITask missionUITask = (MissionUITask)LuaObject.checkSelf(l);
			int missionId;
			LuaObject.checkType(l, 2, out missionId);
			Action onSucceed;
			LuaObject.checkDelegate<Action>(l, 3, out onSucceed);
			missionUITask.m_luaExportHelper.MissionUIController_OnGetReward(missionId, onSucceed);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601FFB9 RID: 131001 RVA: 0x00A946E0 File Offset: 0x00A928E0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int MissionUIController_OnShowGotoLayer(IntPtr l)
	{
		int result;
		try
		{
			MissionUITask missionUITask = (MissionUITask)LuaObject.checkSelf(l);
			GetPathData getPathInfo;
			LuaObject.checkType<GetPathData>(l, 2, out getPathInfo);
			missionUITask.m_luaExportHelper.MissionUIController_OnShowGotoLayer(getPathInfo);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601FFBA RID: 131002 RVA: 0x00A9473C File Offset: 0x00A9293C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_OnStart(IntPtr l)
	{
		int result;
		try
		{
			MissionUITask missionUITask = (MissionUITask)LuaObject.checkSelf(l);
			UIIntent intent;
			LuaObject.checkType<UIIntent>(l, 2, out intent);
			bool b = missionUITask.m_luaExportHelper.__callBase_OnStart(intent);
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

	// Token: 0x0601FFBB RID: 131003 RVA: 0x00A947A4 File Offset: 0x00A929A4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_OnStop(IntPtr l)
	{
		int result;
		try
		{
			MissionUITask missionUITask = (MissionUITask)LuaObject.checkSelf(l);
			missionUITask.m_luaExportHelper.__callBase_OnStop();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601FFBC RID: 131004 RVA: 0x00A947F8 File Offset: 0x00A929F8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_OnPause(IntPtr l)
	{
		int result;
		try
		{
			MissionUITask missionUITask = (MissionUITask)LuaObject.checkSelf(l);
			missionUITask.m_luaExportHelper.__callBase_OnPause();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601FFBD RID: 131005 RVA: 0x00A9484C File Offset: 0x00A92A4C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_OnResume(IntPtr l)
	{
		int result;
		try
		{
			MissionUITask missionUITask = (MissionUITask)LuaObject.checkSelf(l);
			UIIntent intent;
			LuaObject.checkType<UIIntent>(l, 2, out intent);
			bool b = missionUITask.m_luaExportHelper.__callBase_OnResume(intent);
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

	// Token: 0x0601FFBE RID: 131006 RVA: 0x00A948B4 File Offset: 0x00A92AB4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_OnNewIntent(IntPtr l)
	{
		int result;
		try
		{
			MissionUITask missionUITask = (MissionUITask)LuaObject.checkSelf(l);
			UIIntent intent;
			LuaObject.checkType<UIIntent>(l, 2, out intent);
			bool b = missionUITask.m_luaExportHelper.__callBase_OnNewIntent(intent);
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

	// Token: 0x0601FFBF RID: 131007 RVA: 0x00A9491C File Offset: 0x00A92B1C
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int __callBase_EnableUIInput(IntPtr l)
	{
		int result;
		try
		{
			MissionUITask missionUITask = (MissionUITask)LuaObject.checkSelf(l);
			bool isEnable;
			LuaObject.checkType(l, 2, out isEnable);
			bool? isGlobalEnable;
			LuaObject.checkNullable<bool>(l, 3, out isGlobalEnable);
			missionUITask.m_luaExportHelper.__callBase_EnableUIInput(isEnable, isGlobalEnable);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601FFC0 RID: 131008 RVA: 0x00A94988 File Offset: 0x00A92B88
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int __callBase_IsNeedLoadDynamicRes(IntPtr l)
	{
		int result;
		try
		{
			MissionUITask missionUITask = (MissionUITask)LuaObject.checkSelf(l);
			bool b = missionUITask.m_luaExportHelper.__callBase_IsNeedLoadDynamicRes();
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

	// Token: 0x0601FFC1 RID: 131009 RVA: 0x00A949E4 File Offset: 0x00A92BE4
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int __callBase_CollectAllDynamicResForLoad(IntPtr l)
	{
		int result;
		try
		{
			MissionUITask missionUITask = (MissionUITask)LuaObject.checkSelf(l);
			List<string> o = missionUITask.m_luaExportHelper.__callBase_CollectAllDynamicResForLoad();
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

	// Token: 0x0601FFC2 RID: 131010 RVA: 0x00A94A40 File Offset: 0x00A92C40
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_RegisterPlayerContextEvents(IntPtr l)
	{
		int result;
		try
		{
			MissionUITask missionUITask = (MissionUITask)LuaObject.checkSelf(l);
			missionUITask.m_luaExportHelper.__callBase_RegisterPlayerContextEvents();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601FFC3 RID: 131011 RVA: 0x00A94A94 File Offset: 0x00A92C94
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_UnregisterPlayerContextEvents(IntPtr l)
	{
		int result;
		try
		{
			MissionUITask missionUITask = (MissionUITask)LuaObject.checkSelf(l);
			missionUITask.m_luaExportHelper.__callBase_UnregisterPlayerContextEvents();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601FFC4 RID: 131012 RVA: 0x00A94AE8 File Offset: 0x00A92CE8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_PostUpdateView(IntPtr l)
	{
		int result;
		try
		{
			MissionUITask missionUITask = (MissionUITask)LuaObject.checkSelf(l);
			missionUITask.m_luaExportHelper.__callBase_PostUpdateView();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601FFC5 RID: 131013 RVA: 0x00A94B3C File Offset: 0x00A92D3C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_CollectPreloadResourceList(IntPtr l)
	{
		int result;
		try
		{
			MissionUITask missionUITask = (MissionUITask)LuaObject.checkSelf(l);
			missionUITask.m_luaExportHelper.__callBase_CollectPreloadResourceList();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601FFC6 RID: 131014 RVA: 0x00A94B90 File Offset: 0x00A92D90
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int __callBase_ClearAssetList(IntPtr l)
	{
		int result;
		try
		{
			MissionUITask missionUITask = (MissionUITask)LuaObject.checkSelf(l);
			missionUITask.m_luaExportHelper.__callBase_ClearAssetList();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601FFC7 RID: 131015 RVA: 0x00A94BE4 File Offset: 0x00A92DE4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_CollectAsset(IntPtr l)
	{
		int result;
		try
		{
			MissionUITask missionUITask = (MissionUITask)LuaObject.checkSelf(l);
			string assetName;
			LuaObject.checkType(l, 2, out assetName);
			missionUITask.m_luaExportHelper.__callBase_CollectAsset(assetName);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601FFC8 RID: 131016 RVA: 0x00A94C40 File Offset: 0x00A92E40
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_CollectSpriteAsset(IntPtr l)
	{
		int result;
		try
		{
			MissionUITask missionUITask = (MissionUITask)LuaObject.checkSelf(l);
			string assetName;
			LuaObject.checkType(l, 2, out assetName);
			missionUITask.m_luaExportHelper.__callBase_CollectSpriteAsset(assetName);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601FFC9 RID: 131017 RVA: 0x00A94C9C File Offset: 0x00A92E9C
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int __callBase_CollectFxAsset(IntPtr l)
	{
		int result;
		try
		{
			MissionUITask missionUITask = (MissionUITask)LuaObject.checkSelf(l);
			string assetName;
			LuaObject.checkType(l, 2, out assetName);
			missionUITask.m_luaExportHelper.__callBase_CollectFxAsset(assetName);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601FFCA RID: 131018 RVA: 0x00A94CF8 File Offset: 0x00A92EF8
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int __callBase_StartLoadCustomAssets(IntPtr l)
	{
		int result;
		try
		{
			MissionUITask missionUITask = (MissionUITask)LuaObject.checkSelf(l);
			Action onLoadCompleted;
			LuaObject.checkDelegate<Action>(l, 2, out onLoadCompleted);
			missionUITask.m_luaExportHelper.__callBase_StartLoadCustomAssets(onLoadCompleted);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601FFCB RID: 131019 RVA: 0x00A94D54 File Offset: 0x00A92F54
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_IsLoadingCustomAssets(IntPtr l)
	{
		int result;
		try
		{
			MissionUITask missionUITask = (MissionUITask)LuaObject.checkSelf(l);
			bool b = missionUITask.m_luaExportHelper.__callBase_IsLoadingCustomAssets();
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

	// Token: 0x0601FFCC RID: 131020 RVA: 0x00A94DB0 File Offset: 0x00A92FB0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_IsPipeLineRunning(IntPtr l)
	{
		int result;
		try
		{
			MissionUITask missionUITask = (MissionUITask)LuaObject.checkSelf(l);
			bool b = missionUITask.m_luaExportHelper.__callBase_IsPipeLineRunning();
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

	// Token: 0x0601FFCD RID: 131021 RVA: 0x00A94E0C File Offset: 0x00A9300C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_IsOpeningUI(IntPtr l)
	{
		int result;
		try
		{
			MissionUITask missionUITask = (MissionUITask)LuaObject.checkSelf(l);
			bool b = missionUITask.m_luaExportHelper.__callBase_IsOpeningUI();
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

	// Token: 0x0601FFCE RID: 131022 RVA: 0x00A94E68 File Offset: 0x00A93068
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_ReturnPrevUITask(IntPtr l)
	{
		int result;
		try
		{
			MissionUITask missionUITask = (MissionUITask)LuaObject.checkSelf(l);
			UITaskBase o = missionUITask.m_luaExportHelper.__callBase_ReturnPrevUITask();
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

	// Token: 0x0601FFCF RID: 131023 RVA: 0x00A94EC4 File Offset: 0x00A930C4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_ClearUnusedDynamicResourceCache(IntPtr l)
	{
		int result;
		try
		{
			MissionUITask missionUITask = (MissionUITask)LuaObject.checkSelf(l);
			missionUITask.m_luaExportHelper.__callBase_ClearUnusedDynamicResourceCache();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601FFD0 RID: 131024 RVA: 0x00A94F18 File Offset: 0x00A93118
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_OnMemoryWarning(IntPtr l)
	{
		int result;
		try
		{
			MissionUITask missionUITask = (MissionUITask)LuaObject.checkSelf(l);
			missionUITask.m_luaExportHelper.__callBase_OnMemoryWarning();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601FFD1 RID: 131025 RVA: 0x00A94F6C File Offset: 0x00A9316C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_layerDescArray(IntPtr l)
	{
		int result;
		try
		{
			MissionUITask missionUITask = (MissionUITask)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, missionUITask.m_luaExportHelper.m_layerDescArray);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601FFD2 RID: 131026 RVA: 0x00A94FC4 File Offset: 0x00A931C4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_layerDescArray(IntPtr l)
	{
		int result;
		try
		{
			MissionUITask missionUITask = (MissionUITask)LuaObject.checkSelf(l);
			UITaskBase.LayerDesc[] layerDescArray;
			LuaObject.checkArray<UITaskBase.LayerDesc>(l, 2, out layerDescArray);
			missionUITask.m_luaExportHelper.m_layerDescArray = layerDescArray;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601FFD3 RID: 131027 RVA: 0x00A95020 File Offset: 0x00A93220
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_m_uiCtrlDescArray(IntPtr l)
	{
		int result;
		try
		{
			MissionUITask missionUITask = (MissionUITask)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, missionUITask.m_luaExportHelper.m_uiCtrlDescArray);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601FFD4 RID: 131028 RVA: 0x00A95078 File Offset: 0x00A93278
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_uiCtrlDescArray(IntPtr l)
	{
		int result;
		try
		{
			MissionUITask missionUITask = (MissionUITask)LuaObject.checkSelf(l);
			UITaskBase.UIControllerDesc[] uiCtrlDescArray;
			LuaObject.checkArray<UITaskBase.UIControllerDesc>(l, 2, out uiCtrlDescArray);
			missionUITask.m_luaExportHelper.m_uiCtrlDescArray = uiCtrlDescArray;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601FFD5 RID: 131029 RVA: 0x00A950D4 File Offset: 0x00A932D4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_missionUIController(IntPtr l)
	{
		int result;
		try
		{
			MissionUITask missionUITask = (MissionUITask)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, missionUITask.m_luaExportHelper.m_missionUIController);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601FFD6 RID: 131030 RVA: 0x00A9512C File Offset: 0x00A9332C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_missionUIController(IntPtr l)
	{
		int result;
		try
		{
			MissionUITask missionUITask = (MissionUITask)LuaObject.checkSelf(l);
			MissionUIController missionUIController;
			LuaObject.checkType<MissionUIController>(l, 2, out missionUIController);
			missionUITask.m_luaExportHelper.m_missionUIController = missionUIController;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601FFD7 RID: 131031 RVA: 0x00A95188 File Offset: 0x00A93388
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_LayerDescArray(IntPtr l)
	{
		int result;
		try
		{
			MissionUITask missionUITask = (MissionUITask)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, missionUITask.m_luaExportHelper.LayerDescArray);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601FFD8 RID: 131032 RVA: 0x00A951E0 File Offset: 0x00A933E0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_UICtrlDescArray(IntPtr l)
	{
		int result;
		try
		{
			MissionUITask missionUITask = (MissionUITask)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, missionUITask.m_luaExportHelper.UICtrlDescArray);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601FFD9 RID: 131033 RVA: 0x00A95238 File Offset: 0x00A93438
	[Preserve]
	public static void reg(IntPtr l)
	{
		LuaObject.getTypeTable(l, "BlackJack.ProjectL.UI.MissionUITask");
		if (Lua_BlackJack_ProjectL_UI_MissionUITask.<>f__mg$cache0 == null)
		{
			Lua_BlackJack_ProjectL_UI_MissionUITask.<>f__mg$cache0 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_MissionUITask.IsNeedLoadDynamicRes);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_MissionUITask.<>f__mg$cache0);
		if (Lua_BlackJack_ProjectL_UI_MissionUITask.<>f__mg$cache1 == null)
		{
			Lua_BlackJack_ProjectL_UI_MissionUITask.<>f__mg$cache1 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_MissionUITask.InitAllUIControllers);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_MissionUITask.<>f__mg$cache1);
		if (Lua_BlackJack_ProjectL_UI_MissionUITask.<>f__mg$cache2 == null)
		{
			Lua_BlackJack_ProjectL_UI_MissionUITask.<>f__mg$cache2 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_MissionUITask.ClearAllContextAndRes);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_MissionUITask.<>f__mg$cache2);
		if (Lua_BlackJack_ProjectL_UI_MissionUITask.<>f__mg$cache3 == null)
		{
			Lua_BlackJack_ProjectL_UI_MissionUITask.<>f__mg$cache3 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_MissionUITask.OnStart);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_MissionUITask.<>f__mg$cache3);
		if (Lua_BlackJack_ProjectL_UI_MissionUITask.<>f__mg$cache4 == null)
		{
			Lua_BlackJack_ProjectL_UI_MissionUITask.<>f__mg$cache4 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_MissionUITask.OnStop);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_MissionUITask.<>f__mg$cache4);
		if (Lua_BlackJack_ProjectL_UI_MissionUITask.<>f__mg$cache5 == null)
		{
			Lua_BlackJack_ProjectL_UI_MissionUITask.<>f__mg$cache5 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_MissionUITask.UpdateView);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_MissionUITask.<>f__mg$cache5);
		if (Lua_BlackJack_ProjectL_UI_MissionUITask.<>f__mg$cache6 == null)
		{
			Lua_BlackJack_ProjectL_UI_MissionUITask.<>f__mg$cache6 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_MissionUITask.MissionUIController_OnClose);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_MissionUITask.<>f__mg$cache6);
		if (Lua_BlackJack_ProjectL_UI_MissionUITask.<>f__mg$cache7 == null)
		{
			Lua_BlackJack_ProjectL_UI_MissionUITask.<>f__mg$cache7 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_MissionUITask.MissionUIController_OnGetReward);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_MissionUITask.<>f__mg$cache7);
		if (Lua_BlackJack_ProjectL_UI_MissionUITask.<>f__mg$cache8 == null)
		{
			Lua_BlackJack_ProjectL_UI_MissionUITask.<>f__mg$cache8 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_MissionUITask.MissionUIController_OnShowGotoLayer);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_MissionUITask.<>f__mg$cache8);
		if (Lua_BlackJack_ProjectL_UI_MissionUITask.<>f__mg$cache9 == null)
		{
			Lua_BlackJack_ProjectL_UI_MissionUITask.<>f__mg$cache9 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_MissionUITask.__callBase_OnStart);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_MissionUITask.<>f__mg$cache9);
		if (Lua_BlackJack_ProjectL_UI_MissionUITask.<>f__mg$cacheA == null)
		{
			Lua_BlackJack_ProjectL_UI_MissionUITask.<>f__mg$cacheA = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_MissionUITask.__callBase_OnStop);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_MissionUITask.<>f__mg$cacheA);
		if (Lua_BlackJack_ProjectL_UI_MissionUITask.<>f__mg$cacheB == null)
		{
			Lua_BlackJack_ProjectL_UI_MissionUITask.<>f__mg$cacheB = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_MissionUITask.__callBase_OnPause);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_MissionUITask.<>f__mg$cacheB);
		if (Lua_BlackJack_ProjectL_UI_MissionUITask.<>f__mg$cacheC == null)
		{
			Lua_BlackJack_ProjectL_UI_MissionUITask.<>f__mg$cacheC = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_MissionUITask.__callBase_OnResume);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_MissionUITask.<>f__mg$cacheC);
		if (Lua_BlackJack_ProjectL_UI_MissionUITask.<>f__mg$cacheD == null)
		{
			Lua_BlackJack_ProjectL_UI_MissionUITask.<>f__mg$cacheD = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_MissionUITask.__callBase_OnNewIntent);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_MissionUITask.<>f__mg$cacheD);
		if (Lua_BlackJack_ProjectL_UI_MissionUITask.<>f__mg$cacheE == null)
		{
			Lua_BlackJack_ProjectL_UI_MissionUITask.<>f__mg$cacheE = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_MissionUITask.__callBase_EnableUIInput);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_MissionUITask.<>f__mg$cacheE);
		if (Lua_BlackJack_ProjectL_UI_MissionUITask.<>f__mg$cacheF == null)
		{
			Lua_BlackJack_ProjectL_UI_MissionUITask.<>f__mg$cacheF = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_MissionUITask.__callBase_IsNeedLoadDynamicRes);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_MissionUITask.<>f__mg$cacheF);
		if (Lua_BlackJack_ProjectL_UI_MissionUITask.<>f__mg$cache10 == null)
		{
			Lua_BlackJack_ProjectL_UI_MissionUITask.<>f__mg$cache10 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_MissionUITask.__callBase_CollectAllDynamicResForLoad);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_MissionUITask.<>f__mg$cache10);
		if (Lua_BlackJack_ProjectL_UI_MissionUITask.<>f__mg$cache11 == null)
		{
			Lua_BlackJack_ProjectL_UI_MissionUITask.<>f__mg$cache11 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_MissionUITask.__callBase_RegisterPlayerContextEvents);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_MissionUITask.<>f__mg$cache11);
		if (Lua_BlackJack_ProjectL_UI_MissionUITask.<>f__mg$cache12 == null)
		{
			Lua_BlackJack_ProjectL_UI_MissionUITask.<>f__mg$cache12 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_MissionUITask.__callBase_UnregisterPlayerContextEvents);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_MissionUITask.<>f__mg$cache12);
		if (Lua_BlackJack_ProjectL_UI_MissionUITask.<>f__mg$cache13 == null)
		{
			Lua_BlackJack_ProjectL_UI_MissionUITask.<>f__mg$cache13 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_MissionUITask.__callBase_PostUpdateView);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_MissionUITask.<>f__mg$cache13);
		if (Lua_BlackJack_ProjectL_UI_MissionUITask.<>f__mg$cache14 == null)
		{
			Lua_BlackJack_ProjectL_UI_MissionUITask.<>f__mg$cache14 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_MissionUITask.__callBase_CollectPreloadResourceList);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_MissionUITask.<>f__mg$cache14);
		if (Lua_BlackJack_ProjectL_UI_MissionUITask.<>f__mg$cache15 == null)
		{
			Lua_BlackJack_ProjectL_UI_MissionUITask.<>f__mg$cache15 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_MissionUITask.__callBase_ClearAssetList);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_MissionUITask.<>f__mg$cache15);
		if (Lua_BlackJack_ProjectL_UI_MissionUITask.<>f__mg$cache16 == null)
		{
			Lua_BlackJack_ProjectL_UI_MissionUITask.<>f__mg$cache16 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_MissionUITask.__callBase_CollectAsset);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_MissionUITask.<>f__mg$cache16);
		if (Lua_BlackJack_ProjectL_UI_MissionUITask.<>f__mg$cache17 == null)
		{
			Lua_BlackJack_ProjectL_UI_MissionUITask.<>f__mg$cache17 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_MissionUITask.__callBase_CollectSpriteAsset);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_MissionUITask.<>f__mg$cache17);
		if (Lua_BlackJack_ProjectL_UI_MissionUITask.<>f__mg$cache18 == null)
		{
			Lua_BlackJack_ProjectL_UI_MissionUITask.<>f__mg$cache18 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_MissionUITask.__callBase_CollectFxAsset);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_MissionUITask.<>f__mg$cache18);
		if (Lua_BlackJack_ProjectL_UI_MissionUITask.<>f__mg$cache19 == null)
		{
			Lua_BlackJack_ProjectL_UI_MissionUITask.<>f__mg$cache19 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_MissionUITask.__callBase_StartLoadCustomAssets);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_MissionUITask.<>f__mg$cache19);
		if (Lua_BlackJack_ProjectL_UI_MissionUITask.<>f__mg$cache1A == null)
		{
			Lua_BlackJack_ProjectL_UI_MissionUITask.<>f__mg$cache1A = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_MissionUITask.__callBase_IsLoadingCustomAssets);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_MissionUITask.<>f__mg$cache1A);
		if (Lua_BlackJack_ProjectL_UI_MissionUITask.<>f__mg$cache1B == null)
		{
			Lua_BlackJack_ProjectL_UI_MissionUITask.<>f__mg$cache1B = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_MissionUITask.__callBase_IsPipeLineRunning);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_MissionUITask.<>f__mg$cache1B);
		if (Lua_BlackJack_ProjectL_UI_MissionUITask.<>f__mg$cache1C == null)
		{
			Lua_BlackJack_ProjectL_UI_MissionUITask.<>f__mg$cache1C = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_MissionUITask.__callBase_IsOpeningUI);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_MissionUITask.<>f__mg$cache1C);
		if (Lua_BlackJack_ProjectL_UI_MissionUITask.<>f__mg$cache1D == null)
		{
			Lua_BlackJack_ProjectL_UI_MissionUITask.<>f__mg$cache1D = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_MissionUITask.__callBase_ReturnPrevUITask);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_MissionUITask.<>f__mg$cache1D);
		if (Lua_BlackJack_ProjectL_UI_MissionUITask.<>f__mg$cache1E == null)
		{
			Lua_BlackJack_ProjectL_UI_MissionUITask.<>f__mg$cache1E = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_MissionUITask.__callBase_ClearUnusedDynamicResourceCache);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_MissionUITask.<>f__mg$cache1E);
		if (Lua_BlackJack_ProjectL_UI_MissionUITask.<>f__mg$cache1F == null)
		{
			Lua_BlackJack_ProjectL_UI_MissionUITask.<>f__mg$cache1F = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_MissionUITask.__callBase_OnMemoryWarning);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_MissionUITask.<>f__mg$cache1F);
		string name = "m_layerDescArray";
		if (Lua_BlackJack_ProjectL_UI_MissionUITask.<>f__mg$cache20 == null)
		{
			Lua_BlackJack_ProjectL_UI_MissionUITask.<>f__mg$cache20 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_MissionUITask.get_m_layerDescArray);
		}
		LuaCSFunction get = Lua_BlackJack_ProjectL_UI_MissionUITask.<>f__mg$cache20;
		if (Lua_BlackJack_ProjectL_UI_MissionUITask.<>f__mg$cache21 == null)
		{
			Lua_BlackJack_ProjectL_UI_MissionUITask.<>f__mg$cache21 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_MissionUITask.set_m_layerDescArray);
		}
		LuaObject.addMember(l, name, get, Lua_BlackJack_ProjectL_UI_MissionUITask.<>f__mg$cache21, true);
		string name2 = "m_uiCtrlDescArray";
		if (Lua_BlackJack_ProjectL_UI_MissionUITask.<>f__mg$cache22 == null)
		{
			Lua_BlackJack_ProjectL_UI_MissionUITask.<>f__mg$cache22 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_MissionUITask.get_m_uiCtrlDescArray);
		}
		LuaCSFunction get2 = Lua_BlackJack_ProjectL_UI_MissionUITask.<>f__mg$cache22;
		if (Lua_BlackJack_ProjectL_UI_MissionUITask.<>f__mg$cache23 == null)
		{
			Lua_BlackJack_ProjectL_UI_MissionUITask.<>f__mg$cache23 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_MissionUITask.set_m_uiCtrlDescArray);
		}
		LuaObject.addMember(l, name2, get2, Lua_BlackJack_ProjectL_UI_MissionUITask.<>f__mg$cache23, true);
		string name3 = "m_missionUIController";
		if (Lua_BlackJack_ProjectL_UI_MissionUITask.<>f__mg$cache24 == null)
		{
			Lua_BlackJack_ProjectL_UI_MissionUITask.<>f__mg$cache24 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_MissionUITask.get_m_missionUIController);
		}
		LuaCSFunction get3 = Lua_BlackJack_ProjectL_UI_MissionUITask.<>f__mg$cache24;
		if (Lua_BlackJack_ProjectL_UI_MissionUITask.<>f__mg$cache25 == null)
		{
			Lua_BlackJack_ProjectL_UI_MissionUITask.<>f__mg$cache25 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_MissionUITask.set_m_missionUIController);
		}
		LuaObject.addMember(l, name3, get3, Lua_BlackJack_ProjectL_UI_MissionUITask.<>f__mg$cache25, true);
		string name4 = "LayerDescArray";
		if (Lua_BlackJack_ProjectL_UI_MissionUITask.<>f__mg$cache26 == null)
		{
			Lua_BlackJack_ProjectL_UI_MissionUITask.<>f__mg$cache26 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_MissionUITask.get_LayerDescArray);
		}
		LuaObject.addMember(l, name4, Lua_BlackJack_ProjectL_UI_MissionUITask.<>f__mg$cache26, null, true);
		string name5 = "UICtrlDescArray";
		if (Lua_BlackJack_ProjectL_UI_MissionUITask.<>f__mg$cache27 == null)
		{
			Lua_BlackJack_ProjectL_UI_MissionUITask.<>f__mg$cache27 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_MissionUITask.get_UICtrlDescArray);
		}
		LuaObject.addMember(l, name5, Lua_BlackJack_ProjectL_UI_MissionUITask.<>f__mg$cache27, null, true);
		if (Lua_BlackJack_ProjectL_UI_MissionUITask.<>f__mg$cache28 == null)
		{
			Lua_BlackJack_ProjectL_UI_MissionUITask.<>f__mg$cache28 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_MissionUITask.constructor);
		}
		LuaObject.createTypeMetatable(l, Lua_BlackJack_ProjectL_UI_MissionUITask.<>f__mg$cache28, typeof(MissionUITask), typeof(UITask));
	}

	// Token: 0x04015F6E RID: 89966
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache0;

	// Token: 0x04015F6F RID: 89967
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1;

	// Token: 0x04015F70 RID: 89968
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2;

	// Token: 0x04015F71 RID: 89969
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3;

	// Token: 0x04015F72 RID: 89970
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache4;

	// Token: 0x04015F73 RID: 89971
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache5;

	// Token: 0x04015F74 RID: 89972
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache6;

	// Token: 0x04015F75 RID: 89973
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache7;

	// Token: 0x04015F76 RID: 89974
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache8;

	// Token: 0x04015F77 RID: 89975
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache9;

	// Token: 0x04015F78 RID: 89976
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheA;

	// Token: 0x04015F79 RID: 89977
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheB;

	// Token: 0x04015F7A RID: 89978
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheC;

	// Token: 0x04015F7B RID: 89979
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheD;

	// Token: 0x04015F7C RID: 89980
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheE;

	// Token: 0x04015F7D RID: 89981
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheF;

	// Token: 0x04015F7E RID: 89982
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache10;

	// Token: 0x04015F7F RID: 89983
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache11;

	// Token: 0x04015F80 RID: 89984
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache12;

	// Token: 0x04015F81 RID: 89985
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache13;

	// Token: 0x04015F82 RID: 89986
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache14;

	// Token: 0x04015F83 RID: 89987
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache15;

	// Token: 0x04015F84 RID: 89988
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache16;

	// Token: 0x04015F85 RID: 89989
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache17;

	// Token: 0x04015F86 RID: 89990
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache18;

	// Token: 0x04015F87 RID: 89991
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache19;

	// Token: 0x04015F88 RID: 89992
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1A;

	// Token: 0x04015F89 RID: 89993
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1B;

	// Token: 0x04015F8A RID: 89994
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1C;

	// Token: 0x04015F8B RID: 89995
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1D;

	// Token: 0x04015F8C RID: 89996
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1E;

	// Token: 0x04015F8D RID: 89997
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1F;

	// Token: 0x04015F8E RID: 89998
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache20;

	// Token: 0x04015F8F RID: 89999
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache21;

	// Token: 0x04015F90 RID: 90000
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache22;

	// Token: 0x04015F91 RID: 90001
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache23;

	// Token: 0x04015F92 RID: 90002
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache24;

	// Token: 0x04015F93 RID: 90003
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache25;

	// Token: 0x04015F94 RID: 90004
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache26;

	// Token: 0x04015F95 RID: 90005
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache27;

	// Token: 0x04015F96 RID: 90006
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache28;
}
