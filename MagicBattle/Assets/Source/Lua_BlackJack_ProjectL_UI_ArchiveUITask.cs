using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using BlackJack.BJFramework.Runtime.UI;
using BlackJack.ProjectL.UI;
using SLua;
using UnityEngine.Scripting;

// Token: 0x02001367 RID: 4967
[Preserve]
public class Lua_BlackJack_ProjectL_UI_ArchiveUITask : LuaObject
{
	// Token: 0x0601ACD8 RID: 109784 RVA: 0x008015A4 File Offset: 0x007FF7A4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int constructor(IntPtr l)
	{
		int result;
		try
		{
			string name;
			LuaObject.checkType(l, 2, out name);
			ArchiveUITask o = new ArchiveUITask(name);
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

	// Token: 0x0601ACD9 RID: 109785 RVA: 0x008015F8 File Offset: 0x007FF7F8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int CustomLoadAsset(IntPtr l)
	{
		int result;
		try
		{
			ArchiveUITask archiveUITask = (ArchiveUITask)LuaObject.checkSelf(l);
			Action collectionCallback;
			LuaObject.checkDelegate<Action>(l, 2, out collectionCallback);
			Action finishCallback;
			LuaObject.checkDelegate<Action>(l, 3, out finishCallback);
			archiveUITask.CustomLoadAsset(collectionCallback, finishCallback);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601ACDA RID: 109786 RVA: 0x0080165C File Offset: 0x007FF85C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int CollectAssetWrap(IntPtr l)
	{
		int result;
		try
		{
			ArchiveUITask archiveUITask = (ArchiveUITask)LuaObject.checkSelf(l);
			string assetName;
			LuaObject.checkType(l, 2, out assetName);
			archiveUITask.CollectAssetWrap(assetName);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601ACDB RID: 109787 RVA: 0x008016B4 File Offset: 0x007FF8B4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int CollectSpriteAssetWrap(IntPtr l)
	{
		int result;
		try
		{
			ArchiveUITask archiveUITask = (ArchiveUITask)LuaObject.checkSelf(l);
			string assetName;
			LuaObject.checkType(l, 2, out assetName);
			archiveUITask.CollectSpriteAssetWrap(assetName);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601ACDC RID: 109788 RVA: 0x0080170C File Offset: 0x007FF90C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int ReturnLastTask(IntPtr l)
	{
		int result;
		try
		{
			ArchiveUITask archiveUITask = (ArchiveUITask)LuaObject.checkSelf(l);
			archiveUITask.ReturnLastTask();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601ACDD RID: 109789 RVA: 0x00801758 File Offset: 0x007FF958
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int InitAllUIControllers(IntPtr l)
	{
		int result;
		try
		{
			ArchiveUITask archiveUITask = (ArchiveUITask)LuaObject.checkSelf(l);
			archiveUITask.m_luaExportHelper.InitAllUIControllers();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601ACDE RID: 109790 RVA: 0x008017AC File Offset: 0x007FF9AC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int InitLayerStateOnLoadAllResCompleted(IntPtr l)
	{
		int result;
		try
		{
			ArchiveUITask archiveUITask = (ArchiveUITask)LuaObject.checkSelf(l);
			archiveUITask.m_luaExportHelper.InitLayerStateOnLoadAllResCompleted();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601ACDF RID: 109791 RVA: 0x00801800 File Offset: 0x007FFA00
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int OnMemoryWarning(IntPtr l)
	{
		int result;
		try
		{
			ArchiveUITask archiveUITask = (ArchiveUITask)LuaObject.checkSelf(l);
			archiveUITask.m_luaExportHelper.OnMemoryWarning();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601ACE0 RID: 109792 RVA: 0x00801854 File Offset: 0x007FFA54
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int UpdateView(IntPtr l)
	{
		int result;
		try
		{
			ArchiveUITask archiveUITask = (ArchiveUITask)LuaObject.checkSelf(l);
			archiveUITask.m_luaExportHelper.UpdateView();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601ACE1 RID: 109793 RVA: 0x008018A8 File Offset: 0x007FFAA8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_OnStart(IntPtr l)
	{
		int result;
		try
		{
			ArchiveUITask archiveUITask = (ArchiveUITask)LuaObject.checkSelf(l);
			UIIntent intent;
			LuaObject.checkType<UIIntent>(l, 2, out intent);
			bool b = archiveUITask.m_luaExportHelper.__callBase_OnStart(intent);
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

	// Token: 0x0601ACE2 RID: 109794 RVA: 0x00801910 File Offset: 0x007FFB10
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_OnStop(IntPtr l)
	{
		int result;
		try
		{
			ArchiveUITask archiveUITask = (ArchiveUITask)LuaObject.checkSelf(l);
			archiveUITask.m_luaExportHelper.__callBase_OnStop();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601ACE3 RID: 109795 RVA: 0x00801964 File Offset: 0x007FFB64
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_OnPause(IntPtr l)
	{
		int result;
		try
		{
			ArchiveUITask archiveUITask = (ArchiveUITask)LuaObject.checkSelf(l);
			archiveUITask.m_luaExportHelper.__callBase_OnPause();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601ACE4 RID: 109796 RVA: 0x008019B8 File Offset: 0x007FFBB8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_OnResume(IntPtr l)
	{
		int result;
		try
		{
			ArchiveUITask archiveUITask = (ArchiveUITask)LuaObject.checkSelf(l);
			UIIntent intent;
			LuaObject.checkType<UIIntent>(l, 2, out intent);
			bool b = archiveUITask.m_luaExportHelper.__callBase_OnResume(intent);
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

	// Token: 0x0601ACE5 RID: 109797 RVA: 0x00801A20 File Offset: 0x007FFC20
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_OnNewIntent(IntPtr l)
	{
		int result;
		try
		{
			ArchiveUITask archiveUITask = (ArchiveUITask)LuaObject.checkSelf(l);
			UIIntent intent;
			LuaObject.checkType<UIIntent>(l, 2, out intent);
			bool b = archiveUITask.m_luaExportHelper.__callBase_OnNewIntent(intent);
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

	// Token: 0x0601ACE6 RID: 109798 RVA: 0x00801A88 File Offset: 0x007FFC88
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_EnableUIInput(IntPtr l)
	{
		int result;
		try
		{
			ArchiveUITask archiveUITask = (ArchiveUITask)LuaObject.checkSelf(l);
			bool isEnable;
			LuaObject.checkType(l, 2, out isEnable);
			bool? isGlobalEnable;
			LuaObject.checkNullable<bool>(l, 3, out isGlobalEnable);
			archiveUITask.m_luaExportHelper.__callBase_EnableUIInput(isEnable, isGlobalEnable);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601ACE7 RID: 109799 RVA: 0x00801AF4 File Offset: 0x007FFCF4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_IsNeedLoadDynamicRes(IntPtr l)
	{
		int result;
		try
		{
			ArchiveUITask archiveUITask = (ArchiveUITask)LuaObject.checkSelf(l);
			bool b = archiveUITask.m_luaExportHelper.__callBase_IsNeedLoadDynamicRes();
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

	// Token: 0x0601ACE8 RID: 109800 RVA: 0x00801B50 File Offset: 0x007FFD50
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_CollectAllDynamicResForLoad(IntPtr l)
	{
		int result;
		try
		{
			ArchiveUITask archiveUITask = (ArchiveUITask)LuaObject.checkSelf(l);
			List<string> o = archiveUITask.m_luaExportHelper.__callBase_CollectAllDynamicResForLoad();
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

	// Token: 0x0601ACE9 RID: 109801 RVA: 0x00801BAC File Offset: 0x007FFDAC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_RegisterPlayerContextEvents(IntPtr l)
	{
		int result;
		try
		{
			ArchiveUITask archiveUITask = (ArchiveUITask)LuaObject.checkSelf(l);
			archiveUITask.m_luaExportHelper.__callBase_RegisterPlayerContextEvents();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601ACEA RID: 109802 RVA: 0x00801C00 File Offset: 0x007FFE00
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_UnregisterPlayerContextEvents(IntPtr l)
	{
		int result;
		try
		{
			ArchiveUITask archiveUITask = (ArchiveUITask)LuaObject.checkSelf(l);
			archiveUITask.m_luaExportHelper.__callBase_UnregisterPlayerContextEvents();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601ACEB RID: 109803 RVA: 0x00801C54 File Offset: 0x007FFE54
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_PostUpdateView(IntPtr l)
	{
		int result;
		try
		{
			ArchiveUITask archiveUITask = (ArchiveUITask)LuaObject.checkSelf(l);
			archiveUITask.m_luaExportHelper.__callBase_PostUpdateView();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601ACEC RID: 109804 RVA: 0x00801CA8 File Offset: 0x007FFEA8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_CollectPreloadResourceList(IntPtr l)
	{
		int result;
		try
		{
			ArchiveUITask archiveUITask = (ArchiveUITask)LuaObject.checkSelf(l);
			archiveUITask.m_luaExportHelper.__callBase_CollectPreloadResourceList();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601ACED RID: 109805 RVA: 0x00801CFC File Offset: 0x007FFEFC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_ClearAssetList(IntPtr l)
	{
		int result;
		try
		{
			ArchiveUITask archiveUITask = (ArchiveUITask)LuaObject.checkSelf(l);
			archiveUITask.m_luaExportHelper.__callBase_ClearAssetList();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601ACEE RID: 109806 RVA: 0x00801D50 File Offset: 0x007FFF50
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_CollectAsset(IntPtr l)
	{
		int result;
		try
		{
			ArchiveUITask archiveUITask = (ArchiveUITask)LuaObject.checkSelf(l);
			string assetName;
			LuaObject.checkType(l, 2, out assetName);
			archiveUITask.m_luaExportHelper.__callBase_CollectAsset(assetName);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601ACEF RID: 109807 RVA: 0x00801DAC File Offset: 0x007FFFAC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_CollectSpriteAsset(IntPtr l)
	{
		int result;
		try
		{
			ArchiveUITask archiveUITask = (ArchiveUITask)LuaObject.checkSelf(l);
			string assetName;
			LuaObject.checkType(l, 2, out assetName);
			archiveUITask.m_luaExportHelper.__callBase_CollectSpriteAsset(assetName);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601ACF0 RID: 109808 RVA: 0x00801E08 File Offset: 0x00800008
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_CollectFxAsset(IntPtr l)
	{
		int result;
		try
		{
			ArchiveUITask archiveUITask = (ArchiveUITask)LuaObject.checkSelf(l);
			string assetName;
			LuaObject.checkType(l, 2, out assetName);
			archiveUITask.m_luaExportHelper.__callBase_CollectFxAsset(assetName);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601ACF1 RID: 109809 RVA: 0x00801E64 File Offset: 0x00800064
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_StartLoadCustomAssets(IntPtr l)
	{
		int result;
		try
		{
			ArchiveUITask archiveUITask = (ArchiveUITask)LuaObject.checkSelf(l);
			Action onLoadCompleted;
			LuaObject.checkDelegate<Action>(l, 2, out onLoadCompleted);
			archiveUITask.m_luaExportHelper.__callBase_StartLoadCustomAssets(onLoadCompleted);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601ACF2 RID: 109810 RVA: 0x00801EC0 File Offset: 0x008000C0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_IsLoadingCustomAssets(IntPtr l)
	{
		int result;
		try
		{
			ArchiveUITask archiveUITask = (ArchiveUITask)LuaObject.checkSelf(l);
			bool b = archiveUITask.m_luaExportHelper.__callBase_IsLoadingCustomAssets();
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

	// Token: 0x0601ACF3 RID: 109811 RVA: 0x00801F1C File Offset: 0x0080011C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_IsPipeLineRunning(IntPtr l)
	{
		int result;
		try
		{
			ArchiveUITask archiveUITask = (ArchiveUITask)LuaObject.checkSelf(l);
			bool b = archiveUITask.m_luaExportHelper.__callBase_IsPipeLineRunning();
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

	// Token: 0x0601ACF4 RID: 109812 RVA: 0x00801F78 File Offset: 0x00800178
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_IsOpeningUI(IntPtr l)
	{
		int result;
		try
		{
			ArchiveUITask archiveUITask = (ArchiveUITask)LuaObject.checkSelf(l);
			bool b = archiveUITask.m_luaExportHelper.__callBase_IsOpeningUI();
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

	// Token: 0x0601ACF5 RID: 109813 RVA: 0x00801FD4 File Offset: 0x008001D4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_ReturnPrevUITask(IntPtr l)
	{
		int result;
		try
		{
			ArchiveUITask archiveUITask = (ArchiveUITask)LuaObject.checkSelf(l);
			UITaskBase o = archiveUITask.m_luaExportHelper.__callBase_ReturnPrevUITask();
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

	// Token: 0x0601ACF6 RID: 109814 RVA: 0x00802030 File Offset: 0x00800230
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_ClearUnusedDynamicResourceCache(IntPtr l)
	{
		int result;
		try
		{
			ArchiveUITask archiveUITask = (ArchiveUITask)LuaObject.checkSelf(l);
			archiveUITask.m_luaExportHelper.__callBase_ClearUnusedDynamicResourceCache();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601ACF7 RID: 109815 RVA: 0x00802084 File Offset: 0x00800284
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_OnMemoryWarning(IntPtr l)
	{
		int result;
		try
		{
			ArchiveUITask archiveUITask = (ArchiveUITask)LuaObject.checkSelf(l);
			archiveUITask.m_luaExportHelper.__callBase_OnMemoryWarning();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601ACF8 RID: 109816 RVA: 0x008020D8 File Offset: 0x008002D8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_layerDescArray(IntPtr l)
	{
		int result;
		try
		{
			ArchiveUITask archiveUITask = (ArchiveUITask)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, archiveUITask.m_luaExportHelper.m_layerDescArray);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601ACF9 RID: 109817 RVA: 0x00802130 File Offset: 0x00800330
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_layerDescArray(IntPtr l)
	{
		int result;
		try
		{
			ArchiveUITask archiveUITask = (ArchiveUITask)LuaObject.checkSelf(l);
			UITaskBase.LayerDesc[] layerDescArray;
			LuaObject.checkArray<UITaskBase.LayerDesc>(l, 2, out layerDescArray);
			archiveUITask.m_luaExportHelper.m_layerDescArray = layerDescArray;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601ACFA RID: 109818 RVA: 0x0080218C File Offset: 0x0080038C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_uiCtrlDescArray(IntPtr l)
	{
		int result;
		try
		{
			ArchiveUITask archiveUITask = (ArchiveUITask)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, archiveUITask.m_luaExportHelper.m_uiCtrlDescArray);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601ACFB RID: 109819 RVA: 0x008021E4 File Offset: 0x008003E4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_uiCtrlDescArray(IntPtr l)
	{
		int result;
		try
		{
			ArchiveUITask archiveUITask = (ArchiveUITask)LuaObject.checkSelf(l);
			UITaskBase.UIControllerDesc[] uiCtrlDescArray;
			LuaObject.checkArray<UITaskBase.UIControllerDesc>(l, 2, out uiCtrlDescArray);
			archiveUITask.m_luaExportHelper.m_uiCtrlDescArray = uiCtrlDescArray;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601ACFC RID: 109820 RVA: 0x00802240 File Offset: 0x00800440
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_manualUIController(IntPtr l)
	{
		int result;
		try
		{
			ArchiveUITask archiveUITask = (ArchiveUITask)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, archiveUITask.m_manualUIController);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601ACFD RID: 109821 RVA: 0x00802294 File Offset: 0x00800494
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_manualUIController(IntPtr l)
	{
		int result;
		try
		{
			ArchiveUITask archiveUITask = (ArchiveUITask)LuaObject.checkSelf(l);
			ManualUIController manualUIController;
			LuaObject.checkType<ManualUIController>(l, 2, out manualUIController);
			archiveUITask.m_manualUIController = manualUIController;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601ACFE RID: 109822 RVA: 0x008022EC File Offset: 0x008004EC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_heroArchiveUIController(IntPtr l)
	{
		int result;
		try
		{
			ArchiveUITask archiveUITask = (ArchiveUITask)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, archiveUITask.m_heroArchiveUIController);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601ACFF RID: 109823 RVA: 0x00802340 File Offset: 0x00800540
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_heroArchiveUIController(IntPtr l)
	{
		int result;
		try
		{
			ArchiveUITask archiveUITask = (ArchiveUITask)LuaObject.checkSelf(l);
			HeroArchiveUIController heroArchiveUIController;
			LuaObject.checkType<HeroArchiveUIController>(l, 2, out heroArchiveUIController);
			archiveUITask.m_heroArchiveUIController = heroArchiveUIController;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601AD00 RID: 109824 RVA: 0x00802398 File Offset: 0x00800598
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_equipmentArchiveUIController(IntPtr l)
	{
		int result;
		try
		{
			ArchiveUITask archiveUITask = (ArchiveUITask)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, archiveUITask.m_equipmentArchiveUIController);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601AD01 RID: 109825 RVA: 0x008023EC File Offset: 0x008005EC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_equipmentArchiveUIController(IntPtr l)
	{
		int result;
		try
		{
			ArchiveUITask archiveUITask = (ArchiveUITask)LuaObject.checkSelf(l);
			EquipmentArchiveUIController equipmentArchiveUIController;
			LuaObject.checkType<EquipmentArchiveUIController>(l, 2, out equipmentArchiveUIController);
			archiveUITask.m_equipmentArchiveUIController = equipmentArchiveUIController;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601AD02 RID: 109826 RVA: 0x00802444 File Offset: 0x00800644
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_heroShowUIController(IntPtr l)
	{
		int result;
		try
		{
			ArchiveUITask archiveUITask = (ArchiveUITask)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, archiveUITask.m_heroShowUIController);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601AD03 RID: 109827 RVA: 0x00802498 File Offset: 0x00800698
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_heroShowUIController(IntPtr l)
	{
		int result;
		try
		{
			ArchiveUITask archiveUITask = (ArchiveUITask)LuaObject.checkSelf(l);
			HeroShowUIController heroShowUIController;
			LuaObject.checkType<HeroShowUIController>(l, 2, out heroShowUIController);
			archiveUITask.m_heroShowUIController = heroShowUIController;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601AD04 RID: 109828 RVA: 0x008024F0 File Offset: 0x008006F0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_LayerDescArray(IntPtr l)
	{
		int result;
		try
		{
			ArchiveUITask archiveUITask = (ArchiveUITask)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, archiveUITask.m_luaExportHelper.LayerDescArray);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601AD05 RID: 109829 RVA: 0x00802548 File Offset: 0x00800748
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_UICtrlDescArray(IntPtr l)
	{
		int result;
		try
		{
			ArchiveUITask archiveUITask = (ArchiveUITask)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, archiveUITask.m_luaExportHelper.UICtrlDescArray);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601AD06 RID: 109830 RVA: 0x008025A0 File Offset: 0x008007A0
	[Preserve]
	public static void reg(IntPtr l)
	{
		LuaObject.getTypeTable(l, "BlackJack.ProjectL.UI.ArchiveUITask");
		if (Lua_BlackJack_ProjectL_UI_ArchiveUITask.<>f__mg$cache0 == null)
		{
			Lua_BlackJack_ProjectL_UI_ArchiveUITask.<>f__mg$cache0 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ArchiveUITask.CustomLoadAsset);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_ArchiveUITask.<>f__mg$cache0);
		if (Lua_BlackJack_ProjectL_UI_ArchiveUITask.<>f__mg$cache1 == null)
		{
			Lua_BlackJack_ProjectL_UI_ArchiveUITask.<>f__mg$cache1 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ArchiveUITask.CollectAssetWrap);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_ArchiveUITask.<>f__mg$cache1);
		if (Lua_BlackJack_ProjectL_UI_ArchiveUITask.<>f__mg$cache2 == null)
		{
			Lua_BlackJack_ProjectL_UI_ArchiveUITask.<>f__mg$cache2 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ArchiveUITask.CollectSpriteAssetWrap);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_ArchiveUITask.<>f__mg$cache2);
		if (Lua_BlackJack_ProjectL_UI_ArchiveUITask.<>f__mg$cache3 == null)
		{
			Lua_BlackJack_ProjectL_UI_ArchiveUITask.<>f__mg$cache3 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ArchiveUITask.ReturnLastTask);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_ArchiveUITask.<>f__mg$cache3);
		if (Lua_BlackJack_ProjectL_UI_ArchiveUITask.<>f__mg$cache4 == null)
		{
			Lua_BlackJack_ProjectL_UI_ArchiveUITask.<>f__mg$cache4 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ArchiveUITask.InitAllUIControllers);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_ArchiveUITask.<>f__mg$cache4);
		if (Lua_BlackJack_ProjectL_UI_ArchiveUITask.<>f__mg$cache5 == null)
		{
			Lua_BlackJack_ProjectL_UI_ArchiveUITask.<>f__mg$cache5 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ArchiveUITask.InitLayerStateOnLoadAllResCompleted);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_ArchiveUITask.<>f__mg$cache5);
		if (Lua_BlackJack_ProjectL_UI_ArchiveUITask.<>f__mg$cache6 == null)
		{
			Lua_BlackJack_ProjectL_UI_ArchiveUITask.<>f__mg$cache6 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ArchiveUITask.OnMemoryWarning);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_ArchiveUITask.<>f__mg$cache6);
		if (Lua_BlackJack_ProjectL_UI_ArchiveUITask.<>f__mg$cache7 == null)
		{
			Lua_BlackJack_ProjectL_UI_ArchiveUITask.<>f__mg$cache7 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ArchiveUITask.UpdateView);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_ArchiveUITask.<>f__mg$cache7);
		if (Lua_BlackJack_ProjectL_UI_ArchiveUITask.<>f__mg$cache8 == null)
		{
			Lua_BlackJack_ProjectL_UI_ArchiveUITask.<>f__mg$cache8 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ArchiveUITask.__callBase_OnStart);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_ArchiveUITask.<>f__mg$cache8);
		if (Lua_BlackJack_ProjectL_UI_ArchiveUITask.<>f__mg$cache9 == null)
		{
			Lua_BlackJack_ProjectL_UI_ArchiveUITask.<>f__mg$cache9 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ArchiveUITask.__callBase_OnStop);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_ArchiveUITask.<>f__mg$cache9);
		if (Lua_BlackJack_ProjectL_UI_ArchiveUITask.<>f__mg$cacheA == null)
		{
			Lua_BlackJack_ProjectL_UI_ArchiveUITask.<>f__mg$cacheA = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ArchiveUITask.__callBase_OnPause);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_ArchiveUITask.<>f__mg$cacheA);
		if (Lua_BlackJack_ProjectL_UI_ArchiveUITask.<>f__mg$cacheB == null)
		{
			Lua_BlackJack_ProjectL_UI_ArchiveUITask.<>f__mg$cacheB = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ArchiveUITask.__callBase_OnResume);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_ArchiveUITask.<>f__mg$cacheB);
		if (Lua_BlackJack_ProjectL_UI_ArchiveUITask.<>f__mg$cacheC == null)
		{
			Lua_BlackJack_ProjectL_UI_ArchiveUITask.<>f__mg$cacheC = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ArchiveUITask.__callBase_OnNewIntent);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_ArchiveUITask.<>f__mg$cacheC);
		if (Lua_BlackJack_ProjectL_UI_ArchiveUITask.<>f__mg$cacheD == null)
		{
			Lua_BlackJack_ProjectL_UI_ArchiveUITask.<>f__mg$cacheD = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ArchiveUITask.__callBase_EnableUIInput);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_ArchiveUITask.<>f__mg$cacheD);
		if (Lua_BlackJack_ProjectL_UI_ArchiveUITask.<>f__mg$cacheE == null)
		{
			Lua_BlackJack_ProjectL_UI_ArchiveUITask.<>f__mg$cacheE = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ArchiveUITask.__callBase_IsNeedLoadDynamicRes);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_ArchiveUITask.<>f__mg$cacheE);
		if (Lua_BlackJack_ProjectL_UI_ArchiveUITask.<>f__mg$cacheF == null)
		{
			Lua_BlackJack_ProjectL_UI_ArchiveUITask.<>f__mg$cacheF = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ArchiveUITask.__callBase_CollectAllDynamicResForLoad);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_ArchiveUITask.<>f__mg$cacheF);
		if (Lua_BlackJack_ProjectL_UI_ArchiveUITask.<>f__mg$cache10 == null)
		{
			Lua_BlackJack_ProjectL_UI_ArchiveUITask.<>f__mg$cache10 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ArchiveUITask.__callBase_RegisterPlayerContextEvents);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_ArchiveUITask.<>f__mg$cache10);
		if (Lua_BlackJack_ProjectL_UI_ArchiveUITask.<>f__mg$cache11 == null)
		{
			Lua_BlackJack_ProjectL_UI_ArchiveUITask.<>f__mg$cache11 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ArchiveUITask.__callBase_UnregisterPlayerContextEvents);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_ArchiveUITask.<>f__mg$cache11);
		if (Lua_BlackJack_ProjectL_UI_ArchiveUITask.<>f__mg$cache12 == null)
		{
			Lua_BlackJack_ProjectL_UI_ArchiveUITask.<>f__mg$cache12 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ArchiveUITask.__callBase_PostUpdateView);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_ArchiveUITask.<>f__mg$cache12);
		if (Lua_BlackJack_ProjectL_UI_ArchiveUITask.<>f__mg$cache13 == null)
		{
			Lua_BlackJack_ProjectL_UI_ArchiveUITask.<>f__mg$cache13 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ArchiveUITask.__callBase_CollectPreloadResourceList);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_ArchiveUITask.<>f__mg$cache13);
		if (Lua_BlackJack_ProjectL_UI_ArchiveUITask.<>f__mg$cache14 == null)
		{
			Lua_BlackJack_ProjectL_UI_ArchiveUITask.<>f__mg$cache14 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ArchiveUITask.__callBase_ClearAssetList);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_ArchiveUITask.<>f__mg$cache14);
		if (Lua_BlackJack_ProjectL_UI_ArchiveUITask.<>f__mg$cache15 == null)
		{
			Lua_BlackJack_ProjectL_UI_ArchiveUITask.<>f__mg$cache15 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ArchiveUITask.__callBase_CollectAsset);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_ArchiveUITask.<>f__mg$cache15);
		if (Lua_BlackJack_ProjectL_UI_ArchiveUITask.<>f__mg$cache16 == null)
		{
			Lua_BlackJack_ProjectL_UI_ArchiveUITask.<>f__mg$cache16 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ArchiveUITask.__callBase_CollectSpriteAsset);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_ArchiveUITask.<>f__mg$cache16);
		if (Lua_BlackJack_ProjectL_UI_ArchiveUITask.<>f__mg$cache17 == null)
		{
			Lua_BlackJack_ProjectL_UI_ArchiveUITask.<>f__mg$cache17 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ArchiveUITask.__callBase_CollectFxAsset);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_ArchiveUITask.<>f__mg$cache17);
		if (Lua_BlackJack_ProjectL_UI_ArchiveUITask.<>f__mg$cache18 == null)
		{
			Lua_BlackJack_ProjectL_UI_ArchiveUITask.<>f__mg$cache18 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ArchiveUITask.__callBase_StartLoadCustomAssets);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_ArchiveUITask.<>f__mg$cache18);
		if (Lua_BlackJack_ProjectL_UI_ArchiveUITask.<>f__mg$cache19 == null)
		{
			Lua_BlackJack_ProjectL_UI_ArchiveUITask.<>f__mg$cache19 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ArchiveUITask.__callBase_IsLoadingCustomAssets);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_ArchiveUITask.<>f__mg$cache19);
		if (Lua_BlackJack_ProjectL_UI_ArchiveUITask.<>f__mg$cache1A == null)
		{
			Lua_BlackJack_ProjectL_UI_ArchiveUITask.<>f__mg$cache1A = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ArchiveUITask.__callBase_IsPipeLineRunning);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_ArchiveUITask.<>f__mg$cache1A);
		if (Lua_BlackJack_ProjectL_UI_ArchiveUITask.<>f__mg$cache1B == null)
		{
			Lua_BlackJack_ProjectL_UI_ArchiveUITask.<>f__mg$cache1B = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ArchiveUITask.__callBase_IsOpeningUI);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_ArchiveUITask.<>f__mg$cache1B);
		if (Lua_BlackJack_ProjectL_UI_ArchiveUITask.<>f__mg$cache1C == null)
		{
			Lua_BlackJack_ProjectL_UI_ArchiveUITask.<>f__mg$cache1C = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ArchiveUITask.__callBase_ReturnPrevUITask);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_ArchiveUITask.<>f__mg$cache1C);
		if (Lua_BlackJack_ProjectL_UI_ArchiveUITask.<>f__mg$cache1D == null)
		{
			Lua_BlackJack_ProjectL_UI_ArchiveUITask.<>f__mg$cache1D = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ArchiveUITask.__callBase_ClearUnusedDynamicResourceCache);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_ArchiveUITask.<>f__mg$cache1D);
		if (Lua_BlackJack_ProjectL_UI_ArchiveUITask.<>f__mg$cache1E == null)
		{
			Lua_BlackJack_ProjectL_UI_ArchiveUITask.<>f__mg$cache1E = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ArchiveUITask.__callBase_OnMemoryWarning);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_ArchiveUITask.<>f__mg$cache1E);
		string name = "m_layerDescArray";
		if (Lua_BlackJack_ProjectL_UI_ArchiveUITask.<>f__mg$cache1F == null)
		{
			Lua_BlackJack_ProjectL_UI_ArchiveUITask.<>f__mg$cache1F = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ArchiveUITask.get_m_layerDescArray);
		}
		LuaCSFunction get = Lua_BlackJack_ProjectL_UI_ArchiveUITask.<>f__mg$cache1F;
		if (Lua_BlackJack_ProjectL_UI_ArchiveUITask.<>f__mg$cache20 == null)
		{
			Lua_BlackJack_ProjectL_UI_ArchiveUITask.<>f__mg$cache20 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ArchiveUITask.set_m_layerDescArray);
		}
		LuaObject.addMember(l, name, get, Lua_BlackJack_ProjectL_UI_ArchiveUITask.<>f__mg$cache20, true);
		string name2 = "m_uiCtrlDescArray";
		if (Lua_BlackJack_ProjectL_UI_ArchiveUITask.<>f__mg$cache21 == null)
		{
			Lua_BlackJack_ProjectL_UI_ArchiveUITask.<>f__mg$cache21 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ArchiveUITask.get_m_uiCtrlDescArray);
		}
		LuaCSFunction get2 = Lua_BlackJack_ProjectL_UI_ArchiveUITask.<>f__mg$cache21;
		if (Lua_BlackJack_ProjectL_UI_ArchiveUITask.<>f__mg$cache22 == null)
		{
			Lua_BlackJack_ProjectL_UI_ArchiveUITask.<>f__mg$cache22 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ArchiveUITask.set_m_uiCtrlDescArray);
		}
		LuaObject.addMember(l, name2, get2, Lua_BlackJack_ProjectL_UI_ArchiveUITask.<>f__mg$cache22, true);
		string name3 = "m_manualUIController";
		if (Lua_BlackJack_ProjectL_UI_ArchiveUITask.<>f__mg$cache23 == null)
		{
			Lua_BlackJack_ProjectL_UI_ArchiveUITask.<>f__mg$cache23 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ArchiveUITask.get_m_manualUIController);
		}
		LuaCSFunction get3 = Lua_BlackJack_ProjectL_UI_ArchiveUITask.<>f__mg$cache23;
		if (Lua_BlackJack_ProjectL_UI_ArchiveUITask.<>f__mg$cache24 == null)
		{
			Lua_BlackJack_ProjectL_UI_ArchiveUITask.<>f__mg$cache24 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ArchiveUITask.set_m_manualUIController);
		}
		LuaObject.addMember(l, name3, get3, Lua_BlackJack_ProjectL_UI_ArchiveUITask.<>f__mg$cache24, true);
		string name4 = "m_heroArchiveUIController";
		if (Lua_BlackJack_ProjectL_UI_ArchiveUITask.<>f__mg$cache25 == null)
		{
			Lua_BlackJack_ProjectL_UI_ArchiveUITask.<>f__mg$cache25 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ArchiveUITask.get_m_heroArchiveUIController);
		}
		LuaCSFunction get4 = Lua_BlackJack_ProjectL_UI_ArchiveUITask.<>f__mg$cache25;
		if (Lua_BlackJack_ProjectL_UI_ArchiveUITask.<>f__mg$cache26 == null)
		{
			Lua_BlackJack_ProjectL_UI_ArchiveUITask.<>f__mg$cache26 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ArchiveUITask.set_m_heroArchiveUIController);
		}
		LuaObject.addMember(l, name4, get4, Lua_BlackJack_ProjectL_UI_ArchiveUITask.<>f__mg$cache26, true);
		string name5 = "m_equipmentArchiveUIController";
		if (Lua_BlackJack_ProjectL_UI_ArchiveUITask.<>f__mg$cache27 == null)
		{
			Lua_BlackJack_ProjectL_UI_ArchiveUITask.<>f__mg$cache27 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ArchiveUITask.get_m_equipmentArchiveUIController);
		}
		LuaCSFunction get5 = Lua_BlackJack_ProjectL_UI_ArchiveUITask.<>f__mg$cache27;
		if (Lua_BlackJack_ProjectL_UI_ArchiveUITask.<>f__mg$cache28 == null)
		{
			Lua_BlackJack_ProjectL_UI_ArchiveUITask.<>f__mg$cache28 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ArchiveUITask.set_m_equipmentArchiveUIController);
		}
		LuaObject.addMember(l, name5, get5, Lua_BlackJack_ProjectL_UI_ArchiveUITask.<>f__mg$cache28, true);
		string name6 = "m_heroShowUIController";
		if (Lua_BlackJack_ProjectL_UI_ArchiveUITask.<>f__mg$cache29 == null)
		{
			Lua_BlackJack_ProjectL_UI_ArchiveUITask.<>f__mg$cache29 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ArchiveUITask.get_m_heroShowUIController);
		}
		LuaCSFunction get6 = Lua_BlackJack_ProjectL_UI_ArchiveUITask.<>f__mg$cache29;
		if (Lua_BlackJack_ProjectL_UI_ArchiveUITask.<>f__mg$cache2A == null)
		{
			Lua_BlackJack_ProjectL_UI_ArchiveUITask.<>f__mg$cache2A = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ArchiveUITask.set_m_heroShowUIController);
		}
		LuaObject.addMember(l, name6, get6, Lua_BlackJack_ProjectL_UI_ArchiveUITask.<>f__mg$cache2A, true);
		string name7 = "LayerDescArray";
		if (Lua_BlackJack_ProjectL_UI_ArchiveUITask.<>f__mg$cache2B == null)
		{
			Lua_BlackJack_ProjectL_UI_ArchiveUITask.<>f__mg$cache2B = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ArchiveUITask.get_LayerDescArray);
		}
		LuaObject.addMember(l, name7, Lua_BlackJack_ProjectL_UI_ArchiveUITask.<>f__mg$cache2B, null, true);
		string name8 = "UICtrlDescArray";
		if (Lua_BlackJack_ProjectL_UI_ArchiveUITask.<>f__mg$cache2C == null)
		{
			Lua_BlackJack_ProjectL_UI_ArchiveUITask.<>f__mg$cache2C = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ArchiveUITask.get_UICtrlDescArray);
		}
		LuaObject.addMember(l, name8, Lua_BlackJack_ProjectL_UI_ArchiveUITask.<>f__mg$cache2C, null, true);
		if (Lua_BlackJack_ProjectL_UI_ArchiveUITask.<>f__mg$cache2D == null)
		{
			Lua_BlackJack_ProjectL_UI_ArchiveUITask.<>f__mg$cache2D = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ArchiveUITask.constructor);
		}
		LuaObject.createTypeMetatable(l, Lua_BlackJack_ProjectL_UI_ArchiveUITask.<>f__mg$cache2D, typeof(ArchiveUITask), typeof(UITask));
	}

	// Token: 0x04010FEC RID: 69612
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache0;

	// Token: 0x04010FED RID: 69613
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1;

	// Token: 0x04010FEE RID: 69614
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2;

	// Token: 0x04010FEF RID: 69615
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3;

	// Token: 0x04010FF0 RID: 69616
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache4;

	// Token: 0x04010FF1 RID: 69617
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache5;

	// Token: 0x04010FF2 RID: 69618
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache6;

	// Token: 0x04010FF3 RID: 69619
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache7;

	// Token: 0x04010FF4 RID: 69620
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache8;

	// Token: 0x04010FF5 RID: 69621
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache9;

	// Token: 0x04010FF6 RID: 69622
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheA;

	// Token: 0x04010FF7 RID: 69623
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheB;

	// Token: 0x04010FF8 RID: 69624
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheC;

	// Token: 0x04010FF9 RID: 69625
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheD;

	// Token: 0x04010FFA RID: 69626
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheE;

	// Token: 0x04010FFB RID: 69627
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheF;

	// Token: 0x04010FFC RID: 69628
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache10;

	// Token: 0x04010FFD RID: 69629
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache11;

	// Token: 0x04010FFE RID: 69630
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache12;

	// Token: 0x04010FFF RID: 69631
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache13;

	// Token: 0x04011000 RID: 69632
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache14;

	// Token: 0x04011001 RID: 69633
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache15;

	// Token: 0x04011002 RID: 69634
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache16;

	// Token: 0x04011003 RID: 69635
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache17;

	// Token: 0x04011004 RID: 69636
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache18;

	// Token: 0x04011005 RID: 69637
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache19;

	// Token: 0x04011006 RID: 69638
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1A;

	// Token: 0x04011007 RID: 69639
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1B;

	// Token: 0x04011008 RID: 69640
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1C;

	// Token: 0x04011009 RID: 69641
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1D;

	// Token: 0x0401100A RID: 69642
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1E;

	// Token: 0x0401100B RID: 69643
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1F;

	// Token: 0x0401100C RID: 69644
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache20;

	// Token: 0x0401100D RID: 69645
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache21;

	// Token: 0x0401100E RID: 69646
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache22;

	// Token: 0x0401100F RID: 69647
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache23;

	// Token: 0x04011010 RID: 69648
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache24;

	// Token: 0x04011011 RID: 69649
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache25;

	// Token: 0x04011012 RID: 69650
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache26;

	// Token: 0x04011013 RID: 69651
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache27;

	// Token: 0x04011014 RID: 69652
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache28;

	// Token: 0x04011015 RID: 69653
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache29;

	// Token: 0x04011016 RID: 69654
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2A;

	// Token: 0x04011017 RID: 69655
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2B;

	// Token: 0x04011018 RID: 69656
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2C;

	// Token: 0x04011019 RID: 69657
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2D;
}
