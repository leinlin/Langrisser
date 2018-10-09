using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using BlackJack.BJFramework.Runtime.UI;
using BlackJack.ConfigData;
using BlackJack.ProjectL.Common;
using BlackJack.ProjectL.PlayerContext;
using BlackJack.ProjectL.UI;
using SLua;
using UnityEngine.Scripting;

// Token: 0x02001546 RID: 5446
[Preserve]
public class Lua_BlackJack_ProjectL_UI_RaidLevelUITask : LuaObject
{
	// Token: 0x06020904 RID: 133380 RVA: 0x00ADECBC File Offset: 0x00ADCEBC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int constructor(IntPtr l)
	{
		int result;
		try
		{
			string name;
			LuaObject.checkType(l, 2, out name);
			RaidLevelUITask o = new RaidLevelUITask(name);
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

	// Token: 0x06020905 RID: 133381 RVA: 0x00ADED10 File Offset: 0x00ADCF10
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int OnStart(IntPtr l)
	{
		int result;
		try
		{
			RaidLevelUITask raidLevelUITask = (RaidLevelUITask)LuaObject.checkSelf(l);
			UIIntent intent;
			LuaObject.checkType<UIIntent>(l, 2, out intent);
			bool b = raidLevelUITask.m_luaExportHelper.OnStart(intent);
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

	// Token: 0x06020906 RID: 133382 RVA: 0x00ADED78 File Offset: 0x00ADCF78
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int OnResume(IntPtr l)
	{
		int result;
		try
		{
			RaidLevelUITask raidLevelUITask = (RaidLevelUITask)LuaObject.checkSelf(l);
			UIIntent intent;
			LuaObject.checkType<UIIntent>(l, 2, out intent);
			bool b = raidLevelUITask.m_luaExportHelper.OnResume(intent);
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

	// Token: 0x06020907 RID: 133383 RVA: 0x00ADEDE0 File Offset: 0x00ADCFE0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int InitDataFromUIIntent(IntPtr l)
	{
		int result;
		try
		{
			RaidLevelUITask raidLevelUITask = (RaidLevelUITask)LuaObject.checkSelf(l);
			UIIntent intent;
			LuaObject.checkType<UIIntent>(l, 2, out intent);
			raidLevelUITask.m_luaExportHelper.InitDataFromUIIntent(intent);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06020908 RID: 133384 RVA: 0x00ADEE3C File Offset: 0x00ADD03C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int InitAllUIControllers(IntPtr l)
	{
		int result;
		try
		{
			RaidLevelUITask raidLevelUITask = (RaidLevelUITask)LuaObject.checkSelf(l);
			raidLevelUITask.m_luaExportHelper.InitAllUIControllers();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06020909 RID: 133385 RVA: 0x00ADEE90 File Offset: 0x00ADD090
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int ClearAllContextAndRes(IntPtr l)
	{
		int result;
		try
		{
			RaidLevelUITask raidLevelUITask = (RaidLevelUITask)LuaObject.checkSelf(l);
			raidLevelUITask.m_luaExportHelper.ClearAllContextAndRes();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0602090A RID: 133386 RVA: 0x00ADEEE4 File Offset: 0x00ADD0E4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int UpdateView(IntPtr l)
	{
		int result;
		try
		{
			RaidLevelUITask raidLevelUITask = (RaidLevelUITask)LuaObject.checkSelf(l);
			raidLevelUITask.m_luaExportHelper.UpdateView();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0602090B RID: 133387 RVA: 0x00ADEF38 File Offset: 0x00ADD138
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int RaidLevelInfoUIController_OnClose(IntPtr l)
	{
		int result;
		try
		{
			RaidLevelUITask raidLevelUITask = (RaidLevelUITask)LuaObject.checkSelf(l);
			raidLevelUITask.m_luaExportHelper.RaidLevelInfoUIController_OnClose();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0602090C RID: 133388 RVA: 0x00ADEF8C File Offset: 0x00ADD18C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int RaidLevelInfoUIController_RaidAgain(IntPtr l)
	{
		int result;
		try
		{
			RaidLevelUITask raidLevelUITask = (RaidLevelUITask)LuaObject.checkSelf(l);
			raidLevelUITask.m_luaExportHelper.RaidLevelInfoUIController_RaidAgain();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0602090D RID: 133389 RVA: 0x00ADEFE0 File Offset: 0x00ADD1E0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int StartRiftLevelRaidNetTask(IntPtr l)
	{
		int result;
		try
		{
			RaidLevelUITask raidLevelUITask = (RaidLevelUITask)LuaObject.checkSelf(l);
			int levelID;
			LuaObject.checkType(l, 2, out levelID);
			int count;
			LuaObject.checkType(l, 3, out count);
			raidLevelUITask.m_luaExportHelper.StartRiftLevelRaidNetTask(levelID, count);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0602090E RID: 133390 RVA: 0x00ADF04C File Offset: 0x00ADD24C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int StartHeroDungeonLevelRaidNetTask(IntPtr l)
	{
		int result;
		try
		{
			RaidLevelUITask raidLevelUITask = (RaidLevelUITask)LuaObject.checkSelf(l);
			int levelID;
			LuaObject.checkType(l, 2, out levelID);
			int count;
			LuaObject.checkType(l, 3, out count);
			raidLevelUITask.m_luaExportHelper.StartHeroDungeonLevelRaidNetTask(levelID, count);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0602090F RID: 133391 RVA: 0x00ADF0B8 File Offset: 0x00ADD2B8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_OnStart(IntPtr l)
	{
		int result;
		try
		{
			RaidLevelUITask raidLevelUITask = (RaidLevelUITask)LuaObject.checkSelf(l);
			UIIntent intent;
			LuaObject.checkType<UIIntent>(l, 2, out intent);
			bool b = raidLevelUITask.m_luaExportHelper.__callBase_OnStart(intent);
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

	// Token: 0x06020910 RID: 133392 RVA: 0x00ADF120 File Offset: 0x00ADD320
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_OnStop(IntPtr l)
	{
		int result;
		try
		{
			RaidLevelUITask raidLevelUITask = (RaidLevelUITask)LuaObject.checkSelf(l);
			raidLevelUITask.m_luaExportHelper.__callBase_OnStop();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06020911 RID: 133393 RVA: 0x00ADF174 File Offset: 0x00ADD374
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_OnPause(IntPtr l)
	{
		int result;
		try
		{
			RaidLevelUITask raidLevelUITask = (RaidLevelUITask)LuaObject.checkSelf(l);
			raidLevelUITask.m_luaExportHelper.__callBase_OnPause();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06020912 RID: 133394 RVA: 0x00ADF1C8 File Offset: 0x00ADD3C8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_OnResume(IntPtr l)
	{
		int result;
		try
		{
			RaidLevelUITask raidLevelUITask = (RaidLevelUITask)LuaObject.checkSelf(l);
			UIIntent intent;
			LuaObject.checkType<UIIntent>(l, 2, out intent);
			bool b = raidLevelUITask.m_luaExportHelper.__callBase_OnResume(intent);
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

	// Token: 0x06020913 RID: 133395 RVA: 0x00ADF230 File Offset: 0x00ADD430
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_OnNewIntent(IntPtr l)
	{
		int result;
		try
		{
			RaidLevelUITask raidLevelUITask = (RaidLevelUITask)LuaObject.checkSelf(l);
			UIIntent intent;
			LuaObject.checkType<UIIntent>(l, 2, out intent);
			bool b = raidLevelUITask.m_luaExportHelper.__callBase_OnNewIntent(intent);
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

	// Token: 0x06020914 RID: 133396 RVA: 0x00ADF298 File Offset: 0x00ADD498
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_EnableUIInput(IntPtr l)
	{
		int result;
		try
		{
			RaidLevelUITask raidLevelUITask = (RaidLevelUITask)LuaObject.checkSelf(l);
			bool isEnable;
			LuaObject.checkType(l, 2, out isEnable);
			bool? isGlobalEnable;
			LuaObject.checkNullable<bool>(l, 3, out isGlobalEnable);
			raidLevelUITask.m_luaExportHelper.__callBase_EnableUIInput(isEnable, isGlobalEnable);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06020915 RID: 133397 RVA: 0x00ADF304 File Offset: 0x00ADD504
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_IsNeedLoadDynamicRes(IntPtr l)
	{
		int result;
		try
		{
			RaidLevelUITask raidLevelUITask = (RaidLevelUITask)LuaObject.checkSelf(l);
			bool b = raidLevelUITask.m_luaExportHelper.__callBase_IsNeedLoadDynamicRes();
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

	// Token: 0x06020916 RID: 133398 RVA: 0x00ADF360 File Offset: 0x00ADD560
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_CollectAllDynamicResForLoad(IntPtr l)
	{
		int result;
		try
		{
			RaidLevelUITask raidLevelUITask = (RaidLevelUITask)LuaObject.checkSelf(l);
			List<string> o = raidLevelUITask.m_luaExportHelper.__callBase_CollectAllDynamicResForLoad();
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

	// Token: 0x06020917 RID: 133399 RVA: 0x00ADF3BC File Offset: 0x00ADD5BC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_RegisterPlayerContextEvents(IntPtr l)
	{
		int result;
		try
		{
			RaidLevelUITask raidLevelUITask = (RaidLevelUITask)LuaObject.checkSelf(l);
			raidLevelUITask.m_luaExportHelper.__callBase_RegisterPlayerContextEvents();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06020918 RID: 133400 RVA: 0x00ADF410 File Offset: 0x00ADD610
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_UnregisterPlayerContextEvents(IntPtr l)
	{
		int result;
		try
		{
			RaidLevelUITask raidLevelUITask = (RaidLevelUITask)LuaObject.checkSelf(l);
			raidLevelUITask.m_luaExportHelper.__callBase_UnregisterPlayerContextEvents();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06020919 RID: 133401 RVA: 0x00ADF464 File Offset: 0x00ADD664
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_PostUpdateView(IntPtr l)
	{
		int result;
		try
		{
			RaidLevelUITask raidLevelUITask = (RaidLevelUITask)LuaObject.checkSelf(l);
			raidLevelUITask.m_luaExportHelper.__callBase_PostUpdateView();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0602091A RID: 133402 RVA: 0x00ADF4B8 File Offset: 0x00ADD6B8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_CollectPreloadResourceList(IntPtr l)
	{
		int result;
		try
		{
			RaidLevelUITask raidLevelUITask = (RaidLevelUITask)LuaObject.checkSelf(l);
			raidLevelUITask.m_luaExportHelper.__callBase_CollectPreloadResourceList();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0602091B RID: 133403 RVA: 0x00ADF50C File Offset: 0x00ADD70C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_ClearAssetList(IntPtr l)
	{
		int result;
		try
		{
			RaidLevelUITask raidLevelUITask = (RaidLevelUITask)LuaObject.checkSelf(l);
			raidLevelUITask.m_luaExportHelper.__callBase_ClearAssetList();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0602091C RID: 133404 RVA: 0x00ADF560 File Offset: 0x00ADD760
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_CollectAsset(IntPtr l)
	{
		int result;
		try
		{
			RaidLevelUITask raidLevelUITask = (RaidLevelUITask)LuaObject.checkSelf(l);
			string assetName;
			LuaObject.checkType(l, 2, out assetName);
			raidLevelUITask.m_luaExportHelper.__callBase_CollectAsset(assetName);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0602091D RID: 133405 RVA: 0x00ADF5BC File Offset: 0x00ADD7BC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_CollectSpriteAsset(IntPtr l)
	{
		int result;
		try
		{
			RaidLevelUITask raidLevelUITask = (RaidLevelUITask)LuaObject.checkSelf(l);
			string assetName;
			LuaObject.checkType(l, 2, out assetName);
			raidLevelUITask.m_luaExportHelper.__callBase_CollectSpriteAsset(assetName);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0602091E RID: 133406 RVA: 0x00ADF618 File Offset: 0x00ADD818
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_CollectFxAsset(IntPtr l)
	{
		int result;
		try
		{
			RaidLevelUITask raidLevelUITask = (RaidLevelUITask)LuaObject.checkSelf(l);
			string assetName;
			LuaObject.checkType(l, 2, out assetName);
			raidLevelUITask.m_luaExportHelper.__callBase_CollectFxAsset(assetName);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0602091F RID: 133407 RVA: 0x00ADF674 File Offset: 0x00ADD874
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_StartLoadCustomAssets(IntPtr l)
	{
		int result;
		try
		{
			RaidLevelUITask raidLevelUITask = (RaidLevelUITask)LuaObject.checkSelf(l);
			Action onLoadCompleted;
			LuaObject.checkDelegate<Action>(l, 2, out onLoadCompleted);
			raidLevelUITask.m_luaExportHelper.__callBase_StartLoadCustomAssets(onLoadCompleted);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06020920 RID: 133408 RVA: 0x00ADF6D0 File Offset: 0x00ADD8D0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_IsLoadingCustomAssets(IntPtr l)
	{
		int result;
		try
		{
			RaidLevelUITask raidLevelUITask = (RaidLevelUITask)LuaObject.checkSelf(l);
			bool b = raidLevelUITask.m_luaExportHelper.__callBase_IsLoadingCustomAssets();
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

	// Token: 0x06020921 RID: 133409 RVA: 0x00ADF72C File Offset: 0x00ADD92C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_IsPipeLineRunning(IntPtr l)
	{
		int result;
		try
		{
			RaidLevelUITask raidLevelUITask = (RaidLevelUITask)LuaObject.checkSelf(l);
			bool b = raidLevelUITask.m_luaExportHelper.__callBase_IsPipeLineRunning();
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

	// Token: 0x06020922 RID: 133410 RVA: 0x00ADF788 File Offset: 0x00ADD988
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_IsOpeningUI(IntPtr l)
	{
		int result;
		try
		{
			RaidLevelUITask raidLevelUITask = (RaidLevelUITask)LuaObject.checkSelf(l);
			bool b = raidLevelUITask.m_luaExportHelper.__callBase_IsOpeningUI();
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

	// Token: 0x06020923 RID: 133411 RVA: 0x00ADF7E4 File Offset: 0x00ADD9E4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_ReturnPrevUITask(IntPtr l)
	{
		int result;
		try
		{
			RaidLevelUITask raidLevelUITask = (RaidLevelUITask)LuaObject.checkSelf(l);
			UITaskBase o = raidLevelUITask.m_luaExportHelper.__callBase_ReturnPrevUITask();
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

	// Token: 0x06020924 RID: 133412 RVA: 0x00ADF840 File Offset: 0x00ADDA40
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_ClearUnusedDynamicResourceCache(IntPtr l)
	{
		int result;
		try
		{
			RaidLevelUITask raidLevelUITask = (RaidLevelUITask)LuaObject.checkSelf(l);
			raidLevelUITask.m_luaExportHelper.__callBase_ClearUnusedDynamicResourceCache();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06020925 RID: 133413 RVA: 0x00ADF894 File Offset: 0x00ADDA94
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_OnMemoryWarning(IntPtr l)
	{
		int result;
		try
		{
			RaidLevelUITask raidLevelUITask = (RaidLevelUITask)LuaObject.checkSelf(l);
			raidLevelUITask.m_luaExportHelper.__callBase_OnMemoryWarning();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06020926 RID: 133414 RVA: 0x00ADF8E8 File Offset: 0x00ADDAE8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callDele_EventOnClose(IntPtr l)
	{
		int result;
		try
		{
			RaidLevelUITask raidLevelUITask = (RaidLevelUITask)LuaObject.checkSelf(l);
			raidLevelUITask.m_luaExportHelper.__callDele_EventOnClose();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06020927 RID: 133415 RVA: 0x00ADF93C File Offset: 0x00ADDB3C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __clearDele_EventOnClose(IntPtr l)
	{
		int result;
		try
		{
			RaidLevelUITask raidLevelUITask = (RaidLevelUITask)LuaObject.checkSelf(l);
			raidLevelUITask.m_luaExportHelper.__clearDele_EventOnClose();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06020928 RID: 133416 RVA: 0x00ADF990 File Offset: 0x00ADDB90
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callDele_EventOnRiftRaidComplete(IntPtr l)
	{
		int result;
		try
		{
			RaidLevelUITask raidLevelUITask = (RaidLevelUITask)LuaObject.checkSelf(l);
			int obj;
			LuaObject.checkType(l, 2, out obj);
			raidLevelUITask.m_luaExportHelper.__callDele_EventOnRiftRaidComplete(obj);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06020929 RID: 133417 RVA: 0x00ADF9EC File Offset: 0x00ADDBEC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __clearDele_EventOnRiftRaidComplete(IntPtr l)
	{
		int result;
		try
		{
			RaidLevelUITask raidLevelUITask = (RaidLevelUITask)LuaObject.checkSelf(l);
			int obj;
			LuaObject.checkType(l, 2, out obj);
			raidLevelUITask.m_luaExportHelper.__clearDele_EventOnRiftRaidComplete(obj);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0602092A RID: 133418 RVA: 0x00ADFA48 File Offset: 0x00ADDC48
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callDele_EventOnHeroDungeonRaidComplete(IntPtr l)
	{
		int result;
		try
		{
			RaidLevelUITask raidLevelUITask = (RaidLevelUITask)LuaObject.checkSelf(l);
			int obj;
			LuaObject.checkType(l, 2, out obj);
			raidLevelUITask.m_luaExportHelper.__callDele_EventOnHeroDungeonRaidComplete(obj);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0602092B RID: 133419 RVA: 0x00ADFAA4 File Offset: 0x00ADDCA4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __clearDele_EventOnHeroDungeonRaidComplete(IntPtr l)
	{
		int result;
		try
		{
			RaidLevelUITask raidLevelUITask = (RaidLevelUITask)LuaObject.checkSelf(l);
			int obj;
			LuaObject.checkType(l, 2, out obj);
			raidLevelUITask.m_luaExportHelper.__clearDele_EventOnHeroDungeonRaidComplete(obj);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0602092C RID: 133420 RVA: 0x00ADFB00 File Offset: 0x00ADDD00
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_EventOnClose(IntPtr l)
	{
		int result;
		try
		{
			RaidLevelUITask raidLevelUITask = (RaidLevelUITask)LuaObject.checkSelf(l);
			Action value;
			int num = LuaObject.checkDelegate<Action>(l, 2, out value);
			if (num != 0)
			{
				if (num == 1)
				{
					raidLevelUITask.EventOnClose += value;
				}
				else if (num == 2)
				{
					raidLevelUITask.EventOnClose -= value;
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

	// Token: 0x0602092D RID: 133421 RVA: 0x00ADFB80 File Offset: 0x00ADDD80
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_EventOnRiftRaidComplete(IntPtr l)
	{
		int result;
		try
		{
			RaidLevelUITask raidLevelUITask = (RaidLevelUITask)LuaObject.checkSelf(l);
			Action<int> value;
			int num = LuaObject.checkDelegate<Action<int>>(l, 2, out value);
			if (num != 0)
			{
				if (num == 1)
				{
					raidLevelUITask.EventOnRiftRaidComplete += value;
				}
				else if (num == 2)
				{
					raidLevelUITask.EventOnRiftRaidComplete -= value;
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

	// Token: 0x0602092E RID: 133422 RVA: 0x00ADFC00 File Offset: 0x00ADDE00
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_EventOnHeroDungeonRaidComplete(IntPtr l)
	{
		int result;
		try
		{
			RaidLevelUITask raidLevelUITask = (RaidLevelUITask)LuaObject.checkSelf(l);
			Action<int> value;
			int num = LuaObject.checkDelegate<Action<int>>(l, 2, out value);
			if (num != 0)
			{
				if (num == 1)
				{
					raidLevelUITask.EventOnHeroDungeonRaidComplete += value;
				}
				else if (num == 2)
				{
					raidLevelUITask.EventOnHeroDungeonRaidComplete -= value;
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

	// Token: 0x0602092F RID: 133423 RVA: 0x00ADFC80 File Offset: 0x00ADDE80
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_layerDescArray(IntPtr l)
	{
		int result;
		try
		{
			RaidLevelUITask raidLevelUITask = (RaidLevelUITask)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, raidLevelUITask.m_luaExportHelper.m_layerDescArray);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06020930 RID: 133424 RVA: 0x00ADFCD8 File Offset: 0x00ADDED8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_layerDescArray(IntPtr l)
	{
		int result;
		try
		{
			RaidLevelUITask raidLevelUITask = (RaidLevelUITask)LuaObject.checkSelf(l);
			UITaskBase.LayerDesc[] layerDescArray;
			LuaObject.checkArray<UITaskBase.LayerDesc>(l, 2, out layerDescArray);
			raidLevelUITask.m_luaExportHelper.m_layerDescArray = layerDescArray;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06020931 RID: 133425 RVA: 0x00ADFD34 File Offset: 0x00ADDF34
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_uiCtrlDescArray(IntPtr l)
	{
		int result;
		try
		{
			RaidLevelUITask raidLevelUITask = (RaidLevelUITask)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, raidLevelUITask.m_luaExportHelper.m_uiCtrlDescArray);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06020932 RID: 133426 RVA: 0x00ADFD8C File Offset: 0x00ADDF8C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_uiCtrlDescArray(IntPtr l)
	{
		int result;
		try
		{
			RaidLevelUITask raidLevelUITask = (RaidLevelUITask)LuaObject.checkSelf(l);
			UITaskBase.UIControllerDesc[] uiCtrlDescArray;
			LuaObject.checkArray<UITaskBase.UIControllerDesc>(l, 2, out uiCtrlDescArray);
			raidLevelUITask.m_luaExportHelper.m_uiCtrlDescArray = uiCtrlDescArray;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06020933 RID: 133427 RVA: 0x00ADFDE8 File Offset: 0x00ADDFE8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_raidLevelUIController(IntPtr l)
	{
		int result;
		try
		{
			RaidLevelUITask raidLevelUITask = (RaidLevelUITask)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, raidLevelUITask.m_luaExportHelper.m_raidLevelUIController);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06020934 RID: 133428 RVA: 0x00ADFE40 File Offset: 0x00ADE040
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_raidLevelUIController(IntPtr l)
	{
		int result;
		try
		{
			RaidLevelUITask raidLevelUITask = (RaidLevelUITask)LuaObject.checkSelf(l);
			RaidLevelUIController raidLevelUIController;
			LuaObject.checkType<RaidLevelUIController>(l, 2, out raidLevelUIController);
			raidLevelUITask.m_luaExportHelper.m_raidLevelUIController = raidLevelUIController;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06020935 RID: 133429 RVA: 0x00ADFE9C File Offset: 0x00ADE09C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_battleReward(IntPtr l)
	{
		int result;
		try
		{
			RaidLevelUITask raidLevelUITask = (RaidLevelUITask)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, raidLevelUITask.m_luaExportHelper.m_battleReward);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06020936 RID: 133430 RVA: 0x00ADFEF4 File Offset: 0x00ADE0F4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_battleReward(IntPtr l)
	{
		int result;
		try
		{
			RaidLevelUITask raidLevelUITask = (RaidLevelUITask)LuaObject.checkSelf(l);
			BattleReward battleReward;
			LuaObject.checkType<BattleReward>(l, 2, out battleReward);
			raidLevelUITask.m_luaExportHelper.m_battleReward = battleReward;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06020937 RID: 133431 RVA: 0x00ADFF50 File Offset: 0x00ADE150
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_extraReward(IntPtr l)
	{
		int result;
		try
		{
			RaidLevelUITask raidLevelUITask = (RaidLevelUITask)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, raidLevelUITask.m_luaExportHelper.m_extraReward);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06020938 RID: 133432 RVA: 0x00ADFFA8 File Offset: 0x00ADE1A8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_extraReward(IntPtr l)
	{
		int result;
		try
		{
			RaidLevelUITask raidLevelUITask = (RaidLevelUITask)LuaObject.checkSelf(l);
			List<Goods> extraReward;
			LuaObject.checkType<List<Goods>>(l, 2, out extraReward);
			raidLevelUITask.m_luaExportHelper.m_extraReward = extraReward;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06020939 RID: 133433 RVA: 0x00AE0004 File Offset: 0x00ADE204
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_riftLevelID(IntPtr l)
	{
		int result;
		try
		{
			RaidLevelUITask raidLevelUITask = (RaidLevelUITask)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, raidLevelUITask.m_luaExportHelper.m_riftLevelID);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0602093A RID: 133434 RVA: 0x00AE005C File Offset: 0x00ADE25C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_riftLevelID(IntPtr l)
	{
		int result;
		try
		{
			RaidLevelUITask raidLevelUITask = (RaidLevelUITask)LuaObject.checkSelf(l);
			int riftLevelID;
			LuaObject.checkType(l, 2, out riftLevelID);
			raidLevelUITask.m_luaExportHelper.m_riftLevelID = riftLevelID;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0602093B RID: 133435 RVA: 0x00AE00B8 File Offset: 0x00ADE2B8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_heroDungeonLevelID(IntPtr l)
	{
		int result;
		try
		{
			RaidLevelUITask raidLevelUITask = (RaidLevelUITask)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, raidLevelUITask.m_luaExportHelper.m_heroDungeonLevelID);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0602093C RID: 133436 RVA: 0x00AE0110 File Offset: 0x00ADE310
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_heroDungeonLevelID(IntPtr l)
	{
		int result;
		try
		{
			RaidLevelUITask raidLevelUITask = (RaidLevelUITask)LuaObject.checkSelf(l);
			int heroDungeonLevelID;
			LuaObject.checkType(l, 2, out heroDungeonLevelID);
			raidLevelUITask.m_luaExportHelper.m_heroDungeonLevelID = heroDungeonLevelID;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0602093D RID: 133437 RVA: 0x00AE016C File Offset: 0x00ADE36C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_battleType(IntPtr l)
	{
		int result;
		try
		{
			RaidLevelUITask raidLevelUITask = (RaidLevelUITask)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushEnum(l, (int)raidLevelUITask.m_luaExportHelper.m_battleType);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0602093E RID: 133438 RVA: 0x00AE01C4 File Offset: 0x00ADE3C4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_battleType(IntPtr l)
	{
		int result;
		try
		{
			RaidLevelUITask raidLevelUITask = (RaidLevelUITask)LuaObject.checkSelf(l);
			BattleType battleType;
			LuaObject.checkEnum<BattleType>(l, 2, out battleType);
			raidLevelUITask.m_luaExportHelper.m_battleType = battleType;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0602093F RID: 133439 RVA: 0x00AE0220 File Offset: 0x00ADE420
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_needGoods(IntPtr l)
	{
		int result;
		try
		{
			RaidLevelUITask raidLevelUITask = (RaidLevelUITask)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, raidLevelUITask.m_luaExportHelper.m_needGoods);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06020940 RID: 133440 RVA: 0x00AE0278 File Offset: 0x00ADE478
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_needGoods(IntPtr l)
	{
		int result;
		try
		{
			RaidLevelUITask raidLevelUITask = (RaidLevelUITask)LuaObject.checkSelf(l);
			NeedGoods needGoods;
			LuaObject.checkType<NeedGoods>(l, 2, out needGoods);
			raidLevelUITask.m_luaExportHelper.m_needGoods = needGoods;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06020941 RID: 133441 RVA: 0x00AE02D4 File Offset: 0x00ADE4D4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_playerContext(IntPtr l)
	{
		int result;
		try
		{
			RaidLevelUITask raidLevelUITask = (RaidLevelUITask)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, raidLevelUITask.m_luaExportHelper.m_playerContext);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06020942 RID: 133442 RVA: 0x00AE032C File Offset: 0x00ADE52C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_playerContext(IntPtr l)
	{
		int result;
		try
		{
			RaidLevelUITask raidLevelUITask = (RaidLevelUITask)LuaObject.checkSelf(l);
			ProjectLPlayerContext playerContext;
			LuaObject.checkType<ProjectLPlayerContext>(l, 2, out playerContext);
			raidLevelUITask.m_luaExportHelper.m_playerContext = playerContext;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06020943 RID: 133443 RVA: 0x00AE0388 File Offset: 0x00ADE588
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_configDataLoader(IntPtr l)
	{
		int result;
		try
		{
			RaidLevelUITask raidLevelUITask = (RaidLevelUITask)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, raidLevelUITask.m_luaExportHelper.m_configDataLoader);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06020944 RID: 133444 RVA: 0x00AE03E0 File Offset: 0x00ADE5E0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_configDataLoader(IntPtr l)
	{
		int result;
		try
		{
			RaidLevelUITask raidLevelUITask = (RaidLevelUITask)LuaObject.checkSelf(l);
			IConfigDataLoader configDataLoader;
			LuaObject.checkType<IConfigDataLoader>(l, 2, out configDataLoader);
			raidLevelUITask.m_luaExportHelper.m_configDataLoader = configDataLoader;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06020945 RID: 133445 RVA: 0x00AE043C File Offset: 0x00ADE63C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_LayerDescArray(IntPtr l)
	{
		int result;
		try
		{
			RaidLevelUITask raidLevelUITask = (RaidLevelUITask)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, raidLevelUITask.m_luaExportHelper.LayerDescArray);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06020946 RID: 133446 RVA: 0x00AE0494 File Offset: 0x00ADE694
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_UICtrlDescArray(IntPtr l)
	{
		int result;
		try
		{
			RaidLevelUITask raidLevelUITask = (RaidLevelUITask)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, raidLevelUITask.m_luaExportHelper.UICtrlDescArray);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06020947 RID: 133447 RVA: 0x00AE04EC File Offset: 0x00ADE6EC
	[Preserve]
	public static void reg(IntPtr l)
	{
		LuaObject.getTypeTable(l, "BlackJack.ProjectL.UI.RaidLevelUITask");
		if (Lua_BlackJack_ProjectL_UI_RaidLevelUITask.<>f__mg$cache0 == null)
		{
			Lua_BlackJack_ProjectL_UI_RaidLevelUITask.<>f__mg$cache0 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_RaidLevelUITask.OnStart);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_RaidLevelUITask.<>f__mg$cache0);
		if (Lua_BlackJack_ProjectL_UI_RaidLevelUITask.<>f__mg$cache1 == null)
		{
			Lua_BlackJack_ProjectL_UI_RaidLevelUITask.<>f__mg$cache1 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_RaidLevelUITask.OnResume);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_RaidLevelUITask.<>f__mg$cache1);
		if (Lua_BlackJack_ProjectL_UI_RaidLevelUITask.<>f__mg$cache2 == null)
		{
			Lua_BlackJack_ProjectL_UI_RaidLevelUITask.<>f__mg$cache2 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_RaidLevelUITask.InitDataFromUIIntent);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_RaidLevelUITask.<>f__mg$cache2);
		if (Lua_BlackJack_ProjectL_UI_RaidLevelUITask.<>f__mg$cache3 == null)
		{
			Lua_BlackJack_ProjectL_UI_RaidLevelUITask.<>f__mg$cache3 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_RaidLevelUITask.InitAllUIControllers);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_RaidLevelUITask.<>f__mg$cache3);
		if (Lua_BlackJack_ProjectL_UI_RaidLevelUITask.<>f__mg$cache4 == null)
		{
			Lua_BlackJack_ProjectL_UI_RaidLevelUITask.<>f__mg$cache4 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_RaidLevelUITask.ClearAllContextAndRes);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_RaidLevelUITask.<>f__mg$cache4);
		if (Lua_BlackJack_ProjectL_UI_RaidLevelUITask.<>f__mg$cache5 == null)
		{
			Lua_BlackJack_ProjectL_UI_RaidLevelUITask.<>f__mg$cache5 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_RaidLevelUITask.UpdateView);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_RaidLevelUITask.<>f__mg$cache5);
		if (Lua_BlackJack_ProjectL_UI_RaidLevelUITask.<>f__mg$cache6 == null)
		{
			Lua_BlackJack_ProjectL_UI_RaidLevelUITask.<>f__mg$cache6 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_RaidLevelUITask.RaidLevelInfoUIController_OnClose);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_RaidLevelUITask.<>f__mg$cache6);
		if (Lua_BlackJack_ProjectL_UI_RaidLevelUITask.<>f__mg$cache7 == null)
		{
			Lua_BlackJack_ProjectL_UI_RaidLevelUITask.<>f__mg$cache7 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_RaidLevelUITask.RaidLevelInfoUIController_RaidAgain);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_RaidLevelUITask.<>f__mg$cache7);
		if (Lua_BlackJack_ProjectL_UI_RaidLevelUITask.<>f__mg$cache8 == null)
		{
			Lua_BlackJack_ProjectL_UI_RaidLevelUITask.<>f__mg$cache8 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_RaidLevelUITask.StartRiftLevelRaidNetTask);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_RaidLevelUITask.<>f__mg$cache8);
		if (Lua_BlackJack_ProjectL_UI_RaidLevelUITask.<>f__mg$cache9 == null)
		{
			Lua_BlackJack_ProjectL_UI_RaidLevelUITask.<>f__mg$cache9 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_RaidLevelUITask.StartHeroDungeonLevelRaidNetTask);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_RaidLevelUITask.<>f__mg$cache9);
		if (Lua_BlackJack_ProjectL_UI_RaidLevelUITask.<>f__mg$cacheA == null)
		{
			Lua_BlackJack_ProjectL_UI_RaidLevelUITask.<>f__mg$cacheA = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_RaidLevelUITask.__callBase_OnStart);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_RaidLevelUITask.<>f__mg$cacheA);
		if (Lua_BlackJack_ProjectL_UI_RaidLevelUITask.<>f__mg$cacheB == null)
		{
			Lua_BlackJack_ProjectL_UI_RaidLevelUITask.<>f__mg$cacheB = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_RaidLevelUITask.__callBase_OnStop);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_RaidLevelUITask.<>f__mg$cacheB);
		if (Lua_BlackJack_ProjectL_UI_RaidLevelUITask.<>f__mg$cacheC == null)
		{
			Lua_BlackJack_ProjectL_UI_RaidLevelUITask.<>f__mg$cacheC = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_RaidLevelUITask.__callBase_OnPause);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_RaidLevelUITask.<>f__mg$cacheC);
		if (Lua_BlackJack_ProjectL_UI_RaidLevelUITask.<>f__mg$cacheD == null)
		{
			Lua_BlackJack_ProjectL_UI_RaidLevelUITask.<>f__mg$cacheD = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_RaidLevelUITask.__callBase_OnResume);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_RaidLevelUITask.<>f__mg$cacheD);
		if (Lua_BlackJack_ProjectL_UI_RaidLevelUITask.<>f__mg$cacheE == null)
		{
			Lua_BlackJack_ProjectL_UI_RaidLevelUITask.<>f__mg$cacheE = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_RaidLevelUITask.__callBase_OnNewIntent);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_RaidLevelUITask.<>f__mg$cacheE);
		if (Lua_BlackJack_ProjectL_UI_RaidLevelUITask.<>f__mg$cacheF == null)
		{
			Lua_BlackJack_ProjectL_UI_RaidLevelUITask.<>f__mg$cacheF = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_RaidLevelUITask.__callBase_EnableUIInput);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_RaidLevelUITask.<>f__mg$cacheF);
		if (Lua_BlackJack_ProjectL_UI_RaidLevelUITask.<>f__mg$cache10 == null)
		{
			Lua_BlackJack_ProjectL_UI_RaidLevelUITask.<>f__mg$cache10 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_RaidLevelUITask.__callBase_IsNeedLoadDynamicRes);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_RaidLevelUITask.<>f__mg$cache10);
		if (Lua_BlackJack_ProjectL_UI_RaidLevelUITask.<>f__mg$cache11 == null)
		{
			Lua_BlackJack_ProjectL_UI_RaidLevelUITask.<>f__mg$cache11 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_RaidLevelUITask.__callBase_CollectAllDynamicResForLoad);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_RaidLevelUITask.<>f__mg$cache11);
		if (Lua_BlackJack_ProjectL_UI_RaidLevelUITask.<>f__mg$cache12 == null)
		{
			Lua_BlackJack_ProjectL_UI_RaidLevelUITask.<>f__mg$cache12 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_RaidLevelUITask.__callBase_RegisterPlayerContextEvents);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_RaidLevelUITask.<>f__mg$cache12);
		if (Lua_BlackJack_ProjectL_UI_RaidLevelUITask.<>f__mg$cache13 == null)
		{
			Lua_BlackJack_ProjectL_UI_RaidLevelUITask.<>f__mg$cache13 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_RaidLevelUITask.__callBase_UnregisterPlayerContextEvents);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_RaidLevelUITask.<>f__mg$cache13);
		if (Lua_BlackJack_ProjectL_UI_RaidLevelUITask.<>f__mg$cache14 == null)
		{
			Lua_BlackJack_ProjectL_UI_RaidLevelUITask.<>f__mg$cache14 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_RaidLevelUITask.__callBase_PostUpdateView);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_RaidLevelUITask.<>f__mg$cache14);
		if (Lua_BlackJack_ProjectL_UI_RaidLevelUITask.<>f__mg$cache15 == null)
		{
			Lua_BlackJack_ProjectL_UI_RaidLevelUITask.<>f__mg$cache15 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_RaidLevelUITask.__callBase_CollectPreloadResourceList);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_RaidLevelUITask.<>f__mg$cache15);
		if (Lua_BlackJack_ProjectL_UI_RaidLevelUITask.<>f__mg$cache16 == null)
		{
			Lua_BlackJack_ProjectL_UI_RaidLevelUITask.<>f__mg$cache16 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_RaidLevelUITask.__callBase_ClearAssetList);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_RaidLevelUITask.<>f__mg$cache16);
		if (Lua_BlackJack_ProjectL_UI_RaidLevelUITask.<>f__mg$cache17 == null)
		{
			Lua_BlackJack_ProjectL_UI_RaidLevelUITask.<>f__mg$cache17 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_RaidLevelUITask.__callBase_CollectAsset);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_RaidLevelUITask.<>f__mg$cache17);
		if (Lua_BlackJack_ProjectL_UI_RaidLevelUITask.<>f__mg$cache18 == null)
		{
			Lua_BlackJack_ProjectL_UI_RaidLevelUITask.<>f__mg$cache18 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_RaidLevelUITask.__callBase_CollectSpriteAsset);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_RaidLevelUITask.<>f__mg$cache18);
		if (Lua_BlackJack_ProjectL_UI_RaidLevelUITask.<>f__mg$cache19 == null)
		{
			Lua_BlackJack_ProjectL_UI_RaidLevelUITask.<>f__mg$cache19 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_RaidLevelUITask.__callBase_CollectFxAsset);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_RaidLevelUITask.<>f__mg$cache19);
		if (Lua_BlackJack_ProjectL_UI_RaidLevelUITask.<>f__mg$cache1A == null)
		{
			Lua_BlackJack_ProjectL_UI_RaidLevelUITask.<>f__mg$cache1A = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_RaidLevelUITask.__callBase_StartLoadCustomAssets);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_RaidLevelUITask.<>f__mg$cache1A);
		if (Lua_BlackJack_ProjectL_UI_RaidLevelUITask.<>f__mg$cache1B == null)
		{
			Lua_BlackJack_ProjectL_UI_RaidLevelUITask.<>f__mg$cache1B = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_RaidLevelUITask.__callBase_IsLoadingCustomAssets);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_RaidLevelUITask.<>f__mg$cache1B);
		if (Lua_BlackJack_ProjectL_UI_RaidLevelUITask.<>f__mg$cache1C == null)
		{
			Lua_BlackJack_ProjectL_UI_RaidLevelUITask.<>f__mg$cache1C = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_RaidLevelUITask.__callBase_IsPipeLineRunning);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_RaidLevelUITask.<>f__mg$cache1C);
		if (Lua_BlackJack_ProjectL_UI_RaidLevelUITask.<>f__mg$cache1D == null)
		{
			Lua_BlackJack_ProjectL_UI_RaidLevelUITask.<>f__mg$cache1D = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_RaidLevelUITask.__callBase_IsOpeningUI);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_RaidLevelUITask.<>f__mg$cache1D);
		if (Lua_BlackJack_ProjectL_UI_RaidLevelUITask.<>f__mg$cache1E == null)
		{
			Lua_BlackJack_ProjectL_UI_RaidLevelUITask.<>f__mg$cache1E = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_RaidLevelUITask.__callBase_ReturnPrevUITask);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_RaidLevelUITask.<>f__mg$cache1E);
		if (Lua_BlackJack_ProjectL_UI_RaidLevelUITask.<>f__mg$cache1F == null)
		{
			Lua_BlackJack_ProjectL_UI_RaidLevelUITask.<>f__mg$cache1F = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_RaidLevelUITask.__callBase_ClearUnusedDynamicResourceCache);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_RaidLevelUITask.<>f__mg$cache1F);
		if (Lua_BlackJack_ProjectL_UI_RaidLevelUITask.<>f__mg$cache20 == null)
		{
			Lua_BlackJack_ProjectL_UI_RaidLevelUITask.<>f__mg$cache20 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_RaidLevelUITask.__callBase_OnMemoryWarning);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_RaidLevelUITask.<>f__mg$cache20);
		if (Lua_BlackJack_ProjectL_UI_RaidLevelUITask.<>f__mg$cache21 == null)
		{
			Lua_BlackJack_ProjectL_UI_RaidLevelUITask.<>f__mg$cache21 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_RaidLevelUITask.__callDele_EventOnClose);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_RaidLevelUITask.<>f__mg$cache21);
		if (Lua_BlackJack_ProjectL_UI_RaidLevelUITask.<>f__mg$cache22 == null)
		{
			Lua_BlackJack_ProjectL_UI_RaidLevelUITask.<>f__mg$cache22 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_RaidLevelUITask.__clearDele_EventOnClose);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_RaidLevelUITask.<>f__mg$cache22);
		if (Lua_BlackJack_ProjectL_UI_RaidLevelUITask.<>f__mg$cache23 == null)
		{
			Lua_BlackJack_ProjectL_UI_RaidLevelUITask.<>f__mg$cache23 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_RaidLevelUITask.__callDele_EventOnRiftRaidComplete);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_RaidLevelUITask.<>f__mg$cache23);
		if (Lua_BlackJack_ProjectL_UI_RaidLevelUITask.<>f__mg$cache24 == null)
		{
			Lua_BlackJack_ProjectL_UI_RaidLevelUITask.<>f__mg$cache24 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_RaidLevelUITask.__clearDele_EventOnRiftRaidComplete);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_RaidLevelUITask.<>f__mg$cache24);
		if (Lua_BlackJack_ProjectL_UI_RaidLevelUITask.<>f__mg$cache25 == null)
		{
			Lua_BlackJack_ProjectL_UI_RaidLevelUITask.<>f__mg$cache25 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_RaidLevelUITask.__callDele_EventOnHeroDungeonRaidComplete);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_RaidLevelUITask.<>f__mg$cache25);
		if (Lua_BlackJack_ProjectL_UI_RaidLevelUITask.<>f__mg$cache26 == null)
		{
			Lua_BlackJack_ProjectL_UI_RaidLevelUITask.<>f__mg$cache26 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_RaidLevelUITask.__clearDele_EventOnHeroDungeonRaidComplete);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_RaidLevelUITask.<>f__mg$cache26);
		string name = "EventOnClose";
		LuaCSFunction get = null;
		if (Lua_BlackJack_ProjectL_UI_RaidLevelUITask.<>f__mg$cache27 == null)
		{
			Lua_BlackJack_ProjectL_UI_RaidLevelUITask.<>f__mg$cache27 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_RaidLevelUITask.set_EventOnClose);
		}
		LuaObject.addMember(l, name, get, Lua_BlackJack_ProjectL_UI_RaidLevelUITask.<>f__mg$cache27, true);
		string name2 = "EventOnRiftRaidComplete";
		LuaCSFunction get2 = null;
		if (Lua_BlackJack_ProjectL_UI_RaidLevelUITask.<>f__mg$cache28 == null)
		{
			Lua_BlackJack_ProjectL_UI_RaidLevelUITask.<>f__mg$cache28 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_RaidLevelUITask.set_EventOnRiftRaidComplete);
		}
		LuaObject.addMember(l, name2, get2, Lua_BlackJack_ProjectL_UI_RaidLevelUITask.<>f__mg$cache28, true);
		string name3 = "EventOnHeroDungeonRaidComplete";
		LuaCSFunction get3 = null;
		if (Lua_BlackJack_ProjectL_UI_RaidLevelUITask.<>f__mg$cache29 == null)
		{
			Lua_BlackJack_ProjectL_UI_RaidLevelUITask.<>f__mg$cache29 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_RaidLevelUITask.set_EventOnHeroDungeonRaidComplete);
		}
		LuaObject.addMember(l, name3, get3, Lua_BlackJack_ProjectL_UI_RaidLevelUITask.<>f__mg$cache29, true);
		string name4 = "m_layerDescArray";
		if (Lua_BlackJack_ProjectL_UI_RaidLevelUITask.<>f__mg$cache2A == null)
		{
			Lua_BlackJack_ProjectL_UI_RaidLevelUITask.<>f__mg$cache2A = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_RaidLevelUITask.get_m_layerDescArray);
		}
		LuaCSFunction get4 = Lua_BlackJack_ProjectL_UI_RaidLevelUITask.<>f__mg$cache2A;
		if (Lua_BlackJack_ProjectL_UI_RaidLevelUITask.<>f__mg$cache2B == null)
		{
			Lua_BlackJack_ProjectL_UI_RaidLevelUITask.<>f__mg$cache2B = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_RaidLevelUITask.set_m_layerDescArray);
		}
		LuaObject.addMember(l, name4, get4, Lua_BlackJack_ProjectL_UI_RaidLevelUITask.<>f__mg$cache2B, true);
		string name5 = "m_uiCtrlDescArray";
		if (Lua_BlackJack_ProjectL_UI_RaidLevelUITask.<>f__mg$cache2C == null)
		{
			Lua_BlackJack_ProjectL_UI_RaidLevelUITask.<>f__mg$cache2C = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_RaidLevelUITask.get_m_uiCtrlDescArray);
		}
		LuaCSFunction get5 = Lua_BlackJack_ProjectL_UI_RaidLevelUITask.<>f__mg$cache2C;
		if (Lua_BlackJack_ProjectL_UI_RaidLevelUITask.<>f__mg$cache2D == null)
		{
			Lua_BlackJack_ProjectL_UI_RaidLevelUITask.<>f__mg$cache2D = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_RaidLevelUITask.set_m_uiCtrlDescArray);
		}
		LuaObject.addMember(l, name5, get5, Lua_BlackJack_ProjectL_UI_RaidLevelUITask.<>f__mg$cache2D, true);
		string name6 = "m_raidLevelUIController";
		if (Lua_BlackJack_ProjectL_UI_RaidLevelUITask.<>f__mg$cache2E == null)
		{
			Lua_BlackJack_ProjectL_UI_RaidLevelUITask.<>f__mg$cache2E = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_RaidLevelUITask.get_m_raidLevelUIController);
		}
		LuaCSFunction get6 = Lua_BlackJack_ProjectL_UI_RaidLevelUITask.<>f__mg$cache2E;
		if (Lua_BlackJack_ProjectL_UI_RaidLevelUITask.<>f__mg$cache2F == null)
		{
			Lua_BlackJack_ProjectL_UI_RaidLevelUITask.<>f__mg$cache2F = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_RaidLevelUITask.set_m_raidLevelUIController);
		}
		LuaObject.addMember(l, name6, get6, Lua_BlackJack_ProjectL_UI_RaidLevelUITask.<>f__mg$cache2F, true);
		string name7 = "m_battleReward";
		if (Lua_BlackJack_ProjectL_UI_RaidLevelUITask.<>f__mg$cache30 == null)
		{
			Lua_BlackJack_ProjectL_UI_RaidLevelUITask.<>f__mg$cache30 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_RaidLevelUITask.get_m_battleReward);
		}
		LuaCSFunction get7 = Lua_BlackJack_ProjectL_UI_RaidLevelUITask.<>f__mg$cache30;
		if (Lua_BlackJack_ProjectL_UI_RaidLevelUITask.<>f__mg$cache31 == null)
		{
			Lua_BlackJack_ProjectL_UI_RaidLevelUITask.<>f__mg$cache31 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_RaidLevelUITask.set_m_battleReward);
		}
		LuaObject.addMember(l, name7, get7, Lua_BlackJack_ProjectL_UI_RaidLevelUITask.<>f__mg$cache31, true);
		string name8 = "m_extraReward";
		if (Lua_BlackJack_ProjectL_UI_RaidLevelUITask.<>f__mg$cache32 == null)
		{
			Lua_BlackJack_ProjectL_UI_RaidLevelUITask.<>f__mg$cache32 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_RaidLevelUITask.get_m_extraReward);
		}
		LuaCSFunction get8 = Lua_BlackJack_ProjectL_UI_RaidLevelUITask.<>f__mg$cache32;
		if (Lua_BlackJack_ProjectL_UI_RaidLevelUITask.<>f__mg$cache33 == null)
		{
			Lua_BlackJack_ProjectL_UI_RaidLevelUITask.<>f__mg$cache33 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_RaidLevelUITask.set_m_extraReward);
		}
		LuaObject.addMember(l, name8, get8, Lua_BlackJack_ProjectL_UI_RaidLevelUITask.<>f__mg$cache33, true);
		string name9 = "m_riftLevelID";
		if (Lua_BlackJack_ProjectL_UI_RaidLevelUITask.<>f__mg$cache34 == null)
		{
			Lua_BlackJack_ProjectL_UI_RaidLevelUITask.<>f__mg$cache34 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_RaidLevelUITask.get_m_riftLevelID);
		}
		LuaCSFunction get9 = Lua_BlackJack_ProjectL_UI_RaidLevelUITask.<>f__mg$cache34;
		if (Lua_BlackJack_ProjectL_UI_RaidLevelUITask.<>f__mg$cache35 == null)
		{
			Lua_BlackJack_ProjectL_UI_RaidLevelUITask.<>f__mg$cache35 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_RaidLevelUITask.set_m_riftLevelID);
		}
		LuaObject.addMember(l, name9, get9, Lua_BlackJack_ProjectL_UI_RaidLevelUITask.<>f__mg$cache35, true);
		string name10 = "m_heroDungeonLevelID";
		if (Lua_BlackJack_ProjectL_UI_RaidLevelUITask.<>f__mg$cache36 == null)
		{
			Lua_BlackJack_ProjectL_UI_RaidLevelUITask.<>f__mg$cache36 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_RaidLevelUITask.get_m_heroDungeonLevelID);
		}
		LuaCSFunction get10 = Lua_BlackJack_ProjectL_UI_RaidLevelUITask.<>f__mg$cache36;
		if (Lua_BlackJack_ProjectL_UI_RaidLevelUITask.<>f__mg$cache37 == null)
		{
			Lua_BlackJack_ProjectL_UI_RaidLevelUITask.<>f__mg$cache37 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_RaidLevelUITask.set_m_heroDungeonLevelID);
		}
		LuaObject.addMember(l, name10, get10, Lua_BlackJack_ProjectL_UI_RaidLevelUITask.<>f__mg$cache37, true);
		string name11 = "m_battleType";
		if (Lua_BlackJack_ProjectL_UI_RaidLevelUITask.<>f__mg$cache38 == null)
		{
			Lua_BlackJack_ProjectL_UI_RaidLevelUITask.<>f__mg$cache38 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_RaidLevelUITask.get_m_battleType);
		}
		LuaCSFunction get11 = Lua_BlackJack_ProjectL_UI_RaidLevelUITask.<>f__mg$cache38;
		if (Lua_BlackJack_ProjectL_UI_RaidLevelUITask.<>f__mg$cache39 == null)
		{
			Lua_BlackJack_ProjectL_UI_RaidLevelUITask.<>f__mg$cache39 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_RaidLevelUITask.set_m_battleType);
		}
		LuaObject.addMember(l, name11, get11, Lua_BlackJack_ProjectL_UI_RaidLevelUITask.<>f__mg$cache39, true);
		string name12 = "m_needGoods";
		if (Lua_BlackJack_ProjectL_UI_RaidLevelUITask.<>f__mg$cache3A == null)
		{
			Lua_BlackJack_ProjectL_UI_RaidLevelUITask.<>f__mg$cache3A = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_RaidLevelUITask.get_m_needGoods);
		}
		LuaCSFunction get12 = Lua_BlackJack_ProjectL_UI_RaidLevelUITask.<>f__mg$cache3A;
		if (Lua_BlackJack_ProjectL_UI_RaidLevelUITask.<>f__mg$cache3B == null)
		{
			Lua_BlackJack_ProjectL_UI_RaidLevelUITask.<>f__mg$cache3B = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_RaidLevelUITask.set_m_needGoods);
		}
		LuaObject.addMember(l, name12, get12, Lua_BlackJack_ProjectL_UI_RaidLevelUITask.<>f__mg$cache3B, true);
		string name13 = "m_playerContext";
		if (Lua_BlackJack_ProjectL_UI_RaidLevelUITask.<>f__mg$cache3C == null)
		{
			Lua_BlackJack_ProjectL_UI_RaidLevelUITask.<>f__mg$cache3C = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_RaidLevelUITask.get_m_playerContext);
		}
		LuaCSFunction get13 = Lua_BlackJack_ProjectL_UI_RaidLevelUITask.<>f__mg$cache3C;
		if (Lua_BlackJack_ProjectL_UI_RaidLevelUITask.<>f__mg$cache3D == null)
		{
			Lua_BlackJack_ProjectL_UI_RaidLevelUITask.<>f__mg$cache3D = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_RaidLevelUITask.set_m_playerContext);
		}
		LuaObject.addMember(l, name13, get13, Lua_BlackJack_ProjectL_UI_RaidLevelUITask.<>f__mg$cache3D, true);
		string name14 = "m_configDataLoader";
		if (Lua_BlackJack_ProjectL_UI_RaidLevelUITask.<>f__mg$cache3E == null)
		{
			Lua_BlackJack_ProjectL_UI_RaidLevelUITask.<>f__mg$cache3E = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_RaidLevelUITask.get_m_configDataLoader);
		}
		LuaCSFunction get14 = Lua_BlackJack_ProjectL_UI_RaidLevelUITask.<>f__mg$cache3E;
		if (Lua_BlackJack_ProjectL_UI_RaidLevelUITask.<>f__mg$cache3F == null)
		{
			Lua_BlackJack_ProjectL_UI_RaidLevelUITask.<>f__mg$cache3F = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_RaidLevelUITask.set_m_configDataLoader);
		}
		LuaObject.addMember(l, name14, get14, Lua_BlackJack_ProjectL_UI_RaidLevelUITask.<>f__mg$cache3F, true);
		string name15 = "LayerDescArray";
		if (Lua_BlackJack_ProjectL_UI_RaidLevelUITask.<>f__mg$cache40 == null)
		{
			Lua_BlackJack_ProjectL_UI_RaidLevelUITask.<>f__mg$cache40 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_RaidLevelUITask.get_LayerDescArray);
		}
		LuaObject.addMember(l, name15, Lua_BlackJack_ProjectL_UI_RaidLevelUITask.<>f__mg$cache40, null, true);
		string name16 = "UICtrlDescArray";
		if (Lua_BlackJack_ProjectL_UI_RaidLevelUITask.<>f__mg$cache41 == null)
		{
			Lua_BlackJack_ProjectL_UI_RaidLevelUITask.<>f__mg$cache41 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_RaidLevelUITask.get_UICtrlDescArray);
		}
		LuaObject.addMember(l, name16, Lua_BlackJack_ProjectL_UI_RaidLevelUITask.<>f__mg$cache41, null, true);
		if (Lua_BlackJack_ProjectL_UI_RaidLevelUITask.<>f__mg$cache42 == null)
		{
			Lua_BlackJack_ProjectL_UI_RaidLevelUITask.<>f__mg$cache42 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_RaidLevelUITask.constructor);
		}
		LuaObject.createTypeMetatable(l, Lua_BlackJack_ProjectL_UI_RaidLevelUITask.<>f__mg$cache42, typeof(RaidLevelUITask), typeof(UITask));
	}

	// Token: 0x0401685A RID: 92250
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache0;

	// Token: 0x0401685B RID: 92251
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1;

	// Token: 0x0401685C RID: 92252
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2;

	// Token: 0x0401685D RID: 92253
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3;

	// Token: 0x0401685E RID: 92254
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache4;

	// Token: 0x0401685F RID: 92255
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache5;

	// Token: 0x04016860 RID: 92256
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache6;

	// Token: 0x04016861 RID: 92257
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache7;

	// Token: 0x04016862 RID: 92258
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache8;

	// Token: 0x04016863 RID: 92259
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache9;

	// Token: 0x04016864 RID: 92260
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheA;

	// Token: 0x04016865 RID: 92261
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheB;

	// Token: 0x04016866 RID: 92262
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheC;

	// Token: 0x04016867 RID: 92263
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheD;

	// Token: 0x04016868 RID: 92264
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheE;

	// Token: 0x04016869 RID: 92265
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheF;

	// Token: 0x0401686A RID: 92266
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache10;

	// Token: 0x0401686B RID: 92267
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache11;

	// Token: 0x0401686C RID: 92268
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache12;

	// Token: 0x0401686D RID: 92269
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache13;

	// Token: 0x0401686E RID: 92270
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache14;

	// Token: 0x0401686F RID: 92271
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache15;

	// Token: 0x04016870 RID: 92272
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache16;

	// Token: 0x04016871 RID: 92273
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache17;

	// Token: 0x04016872 RID: 92274
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache18;

	// Token: 0x04016873 RID: 92275
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache19;

	// Token: 0x04016874 RID: 92276
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1A;

	// Token: 0x04016875 RID: 92277
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1B;

	// Token: 0x04016876 RID: 92278
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1C;

	// Token: 0x04016877 RID: 92279
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1D;

	// Token: 0x04016878 RID: 92280
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1E;

	// Token: 0x04016879 RID: 92281
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1F;

	// Token: 0x0401687A RID: 92282
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache20;

	// Token: 0x0401687B RID: 92283
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache21;

	// Token: 0x0401687C RID: 92284
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache22;

	// Token: 0x0401687D RID: 92285
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache23;

	// Token: 0x0401687E RID: 92286
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache24;

	// Token: 0x0401687F RID: 92287
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache25;

	// Token: 0x04016880 RID: 92288
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache26;

	// Token: 0x04016881 RID: 92289
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache27;

	// Token: 0x04016882 RID: 92290
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache28;

	// Token: 0x04016883 RID: 92291
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache29;

	// Token: 0x04016884 RID: 92292
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2A;

	// Token: 0x04016885 RID: 92293
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2B;

	// Token: 0x04016886 RID: 92294
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2C;

	// Token: 0x04016887 RID: 92295
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2D;

	// Token: 0x04016888 RID: 92296
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2E;

	// Token: 0x04016889 RID: 92297
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2F;

	// Token: 0x0401688A RID: 92298
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache30;

	// Token: 0x0401688B RID: 92299
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache31;

	// Token: 0x0401688C RID: 92300
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache32;

	// Token: 0x0401688D RID: 92301
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache33;

	// Token: 0x0401688E RID: 92302
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache34;

	// Token: 0x0401688F RID: 92303
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache35;

	// Token: 0x04016890 RID: 92304
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache36;

	// Token: 0x04016891 RID: 92305
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache37;

	// Token: 0x04016892 RID: 92306
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache38;

	// Token: 0x04016893 RID: 92307
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache39;

	// Token: 0x04016894 RID: 92308
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3A;

	// Token: 0x04016895 RID: 92309
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3B;

	// Token: 0x04016896 RID: 92310
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3C;

	// Token: 0x04016897 RID: 92311
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3D;

	// Token: 0x04016898 RID: 92312
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3E;

	// Token: 0x04016899 RID: 92313
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3F;

	// Token: 0x0401689A RID: 92314
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache40;

	// Token: 0x0401689B RID: 92315
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache41;

	// Token: 0x0401689C RID: 92316
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache42;
}
