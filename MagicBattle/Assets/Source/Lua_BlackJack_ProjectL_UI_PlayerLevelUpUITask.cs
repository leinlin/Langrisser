using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using BlackJack.BJFramework.Runtime.UI;
using BlackJack.ProjectL.UI;
using SLua;
using UnityEngine.Scripting;

// Token: 0x0200152E RID: 5422
[Preserve]
public class Lua_BlackJack_ProjectL_UI_PlayerLevelUpUITask : LuaObject
{
	// Token: 0x060203EC RID: 132076 RVA: 0x00AB5FDC File Offset: 0x00AB41DC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int constructor(IntPtr l)
	{
		int result;
		try
		{
			string name;
			LuaObject.checkType(l, 2, out name);
			PlayerLevelUpUITask o = new PlayerLevelUpUITask(name);
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

	// Token: 0x060203ED RID: 132077 RVA: 0x00AB6030 File Offset: 0x00AB4230
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int StartUITask_s(IntPtr l)
	{
		int result;
		try
		{
			int oldLevel;
			LuaObject.checkType(l, 1, out oldLevel);
			int newLevel;
			LuaObject.checkType(l, 2, out newLevel);
			PlayerLevelUpUITask o = PlayerLevelUpUITask.StartUITask(oldLevel, newLevel);
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

	// Token: 0x060203EE RID: 132078 RVA: 0x00AB6090 File Offset: 0x00AB4290
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int OnStart(IntPtr l)
	{
		int result;
		try
		{
			PlayerLevelUpUITask playerLevelUpUITask = (PlayerLevelUpUITask)LuaObject.checkSelf(l);
			UIIntent intent;
			LuaObject.checkType<UIIntent>(l, 2, out intent);
			bool b = playerLevelUpUITask.m_luaExportHelper.OnStart(intent);
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

	// Token: 0x060203EF RID: 132079 RVA: 0x00AB60F8 File Offset: 0x00AB42F8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int OnResume(IntPtr l)
	{
		int result;
		try
		{
			PlayerLevelUpUITask playerLevelUpUITask = (PlayerLevelUpUITask)LuaObject.checkSelf(l);
			UIIntent intent;
			LuaObject.checkType<UIIntent>(l, 2, out intent);
			bool b = playerLevelUpUITask.m_luaExportHelper.OnResume(intent);
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

	// Token: 0x060203F0 RID: 132080 RVA: 0x00AB6160 File Offset: 0x00AB4360
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int InitAllUIControllers(IntPtr l)
	{
		int result;
		try
		{
			PlayerLevelUpUITask playerLevelUpUITask = (PlayerLevelUpUITask)LuaObject.checkSelf(l);
			playerLevelUpUITask.m_luaExportHelper.InitAllUIControllers();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060203F1 RID: 132081 RVA: 0x00AB61B4 File Offset: 0x00AB43B4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int ClearAllContextAndRes(IntPtr l)
	{
		int result;
		try
		{
			PlayerLevelUpUITask playerLevelUpUITask = (PlayerLevelUpUITask)LuaObject.checkSelf(l);
			playerLevelUpUITask.m_luaExportHelper.ClearAllContextAndRes();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060203F2 RID: 132082 RVA: 0x00AB6208 File Offset: 0x00AB4408
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int UpdateView(IntPtr l)
	{
		int result;
		try
		{
			PlayerLevelUpUITask playerLevelUpUITask = (PlayerLevelUpUITask)LuaObject.checkSelf(l);
			playerLevelUpUITask.m_luaExportHelper.UpdateView();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060203F3 RID: 132083 RVA: 0x00AB625C File Offset: 0x00AB445C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int OnClose(IntPtr l)
	{
		int result;
		try
		{
			PlayerLevelUpUITask playerLevelUpUITask = (PlayerLevelUpUITask)LuaObject.checkSelf(l);
			playerLevelUpUITask.m_luaExportHelper.OnClose();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060203F4 RID: 132084 RVA: 0x00AB62B0 File Offset: 0x00AB44B0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int InitDataFromUIIntent(IntPtr l)
	{
		int result;
		try
		{
			PlayerLevelUpUITask playerLevelUpUITask = (PlayerLevelUpUITask)LuaObject.checkSelf(l);
			UIIntent intent;
			LuaObject.checkType<UIIntent>(l, 2, out intent);
			playerLevelUpUITask.m_luaExportHelper.InitDataFromUIIntent(intent);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060203F5 RID: 132085 RVA: 0x00AB630C File Offset: 0x00AB450C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_OnStart(IntPtr l)
	{
		int result;
		try
		{
			PlayerLevelUpUITask playerLevelUpUITask = (PlayerLevelUpUITask)LuaObject.checkSelf(l);
			UIIntent intent;
			LuaObject.checkType<UIIntent>(l, 2, out intent);
			bool b = playerLevelUpUITask.m_luaExportHelper.__callBase_OnStart(intent);
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

	// Token: 0x060203F6 RID: 132086 RVA: 0x00AB6374 File Offset: 0x00AB4574
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_OnStop(IntPtr l)
	{
		int result;
		try
		{
			PlayerLevelUpUITask playerLevelUpUITask = (PlayerLevelUpUITask)LuaObject.checkSelf(l);
			playerLevelUpUITask.m_luaExportHelper.__callBase_OnStop();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060203F7 RID: 132087 RVA: 0x00AB63C8 File Offset: 0x00AB45C8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_OnPause(IntPtr l)
	{
		int result;
		try
		{
			PlayerLevelUpUITask playerLevelUpUITask = (PlayerLevelUpUITask)LuaObject.checkSelf(l);
			playerLevelUpUITask.m_luaExportHelper.__callBase_OnPause();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060203F8 RID: 132088 RVA: 0x00AB641C File Offset: 0x00AB461C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_OnResume(IntPtr l)
	{
		int result;
		try
		{
			PlayerLevelUpUITask playerLevelUpUITask = (PlayerLevelUpUITask)LuaObject.checkSelf(l);
			UIIntent intent;
			LuaObject.checkType<UIIntent>(l, 2, out intent);
			bool b = playerLevelUpUITask.m_luaExportHelper.__callBase_OnResume(intent);
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

	// Token: 0x060203F9 RID: 132089 RVA: 0x00AB6484 File Offset: 0x00AB4684
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_OnNewIntent(IntPtr l)
	{
		int result;
		try
		{
			PlayerLevelUpUITask playerLevelUpUITask = (PlayerLevelUpUITask)LuaObject.checkSelf(l);
			UIIntent intent;
			LuaObject.checkType<UIIntent>(l, 2, out intent);
			bool b = playerLevelUpUITask.m_luaExportHelper.__callBase_OnNewIntent(intent);
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

	// Token: 0x060203FA RID: 132090 RVA: 0x00AB64EC File Offset: 0x00AB46EC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_EnableUIInput(IntPtr l)
	{
		int result;
		try
		{
			PlayerLevelUpUITask playerLevelUpUITask = (PlayerLevelUpUITask)LuaObject.checkSelf(l);
			bool isEnable;
			LuaObject.checkType(l, 2, out isEnable);
			bool? isGlobalEnable;
			LuaObject.checkNullable<bool>(l, 3, out isGlobalEnable);
			playerLevelUpUITask.m_luaExportHelper.__callBase_EnableUIInput(isEnable, isGlobalEnable);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060203FB RID: 132091 RVA: 0x00AB6558 File Offset: 0x00AB4758
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_IsNeedLoadDynamicRes(IntPtr l)
	{
		int result;
		try
		{
			PlayerLevelUpUITask playerLevelUpUITask = (PlayerLevelUpUITask)LuaObject.checkSelf(l);
			bool b = playerLevelUpUITask.m_luaExportHelper.__callBase_IsNeedLoadDynamicRes();
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

	// Token: 0x060203FC RID: 132092 RVA: 0x00AB65B4 File Offset: 0x00AB47B4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_CollectAllDynamicResForLoad(IntPtr l)
	{
		int result;
		try
		{
			PlayerLevelUpUITask playerLevelUpUITask = (PlayerLevelUpUITask)LuaObject.checkSelf(l);
			List<string> o = playerLevelUpUITask.m_luaExportHelper.__callBase_CollectAllDynamicResForLoad();
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

	// Token: 0x060203FD RID: 132093 RVA: 0x00AB6610 File Offset: 0x00AB4810
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_RegisterPlayerContextEvents(IntPtr l)
	{
		int result;
		try
		{
			PlayerLevelUpUITask playerLevelUpUITask = (PlayerLevelUpUITask)LuaObject.checkSelf(l);
			playerLevelUpUITask.m_luaExportHelper.__callBase_RegisterPlayerContextEvents();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060203FE RID: 132094 RVA: 0x00AB6664 File Offset: 0x00AB4864
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_UnregisterPlayerContextEvents(IntPtr l)
	{
		int result;
		try
		{
			PlayerLevelUpUITask playerLevelUpUITask = (PlayerLevelUpUITask)LuaObject.checkSelf(l);
			playerLevelUpUITask.m_luaExportHelper.__callBase_UnregisterPlayerContextEvents();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060203FF RID: 132095 RVA: 0x00AB66B8 File Offset: 0x00AB48B8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_PostUpdateView(IntPtr l)
	{
		int result;
		try
		{
			PlayerLevelUpUITask playerLevelUpUITask = (PlayerLevelUpUITask)LuaObject.checkSelf(l);
			playerLevelUpUITask.m_luaExportHelper.__callBase_PostUpdateView();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06020400 RID: 132096 RVA: 0x00AB670C File Offset: 0x00AB490C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_CollectPreloadResourceList(IntPtr l)
	{
		int result;
		try
		{
			PlayerLevelUpUITask playerLevelUpUITask = (PlayerLevelUpUITask)LuaObject.checkSelf(l);
			playerLevelUpUITask.m_luaExportHelper.__callBase_CollectPreloadResourceList();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06020401 RID: 132097 RVA: 0x00AB6760 File Offset: 0x00AB4960
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_ClearAssetList(IntPtr l)
	{
		int result;
		try
		{
			PlayerLevelUpUITask playerLevelUpUITask = (PlayerLevelUpUITask)LuaObject.checkSelf(l);
			playerLevelUpUITask.m_luaExportHelper.__callBase_ClearAssetList();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06020402 RID: 132098 RVA: 0x00AB67B4 File Offset: 0x00AB49B4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_CollectAsset(IntPtr l)
	{
		int result;
		try
		{
			PlayerLevelUpUITask playerLevelUpUITask = (PlayerLevelUpUITask)LuaObject.checkSelf(l);
			string assetName;
			LuaObject.checkType(l, 2, out assetName);
			playerLevelUpUITask.m_luaExportHelper.__callBase_CollectAsset(assetName);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06020403 RID: 132099 RVA: 0x00AB6810 File Offset: 0x00AB4A10
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_CollectSpriteAsset(IntPtr l)
	{
		int result;
		try
		{
			PlayerLevelUpUITask playerLevelUpUITask = (PlayerLevelUpUITask)LuaObject.checkSelf(l);
			string assetName;
			LuaObject.checkType(l, 2, out assetName);
			playerLevelUpUITask.m_luaExportHelper.__callBase_CollectSpriteAsset(assetName);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06020404 RID: 132100 RVA: 0x00AB686C File Offset: 0x00AB4A6C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_CollectFxAsset(IntPtr l)
	{
		int result;
		try
		{
			PlayerLevelUpUITask playerLevelUpUITask = (PlayerLevelUpUITask)LuaObject.checkSelf(l);
			string assetName;
			LuaObject.checkType(l, 2, out assetName);
			playerLevelUpUITask.m_luaExportHelper.__callBase_CollectFxAsset(assetName);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06020405 RID: 132101 RVA: 0x00AB68C8 File Offset: 0x00AB4AC8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_StartLoadCustomAssets(IntPtr l)
	{
		int result;
		try
		{
			PlayerLevelUpUITask playerLevelUpUITask = (PlayerLevelUpUITask)LuaObject.checkSelf(l);
			Action onLoadCompleted;
			LuaObject.checkDelegate<Action>(l, 2, out onLoadCompleted);
			playerLevelUpUITask.m_luaExportHelper.__callBase_StartLoadCustomAssets(onLoadCompleted);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06020406 RID: 132102 RVA: 0x00AB6924 File Offset: 0x00AB4B24
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_IsLoadingCustomAssets(IntPtr l)
	{
		int result;
		try
		{
			PlayerLevelUpUITask playerLevelUpUITask = (PlayerLevelUpUITask)LuaObject.checkSelf(l);
			bool b = playerLevelUpUITask.m_luaExportHelper.__callBase_IsLoadingCustomAssets();
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

	// Token: 0x06020407 RID: 132103 RVA: 0x00AB6980 File Offset: 0x00AB4B80
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_IsPipeLineRunning(IntPtr l)
	{
		int result;
		try
		{
			PlayerLevelUpUITask playerLevelUpUITask = (PlayerLevelUpUITask)LuaObject.checkSelf(l);
			bool b = playerLevelUpUITask.m_luaExportHelper.__callBase_IsPipeLineRunning();
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

	// Token: 0x06020408 RID: 132104 RVA: 0x00AB69DC File Offset: 0x00AB4BDC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_IsOpeningUI(IntPtr l)
	{
		int result;
		try
		{
			PlayerLevelUpUITask playerLevelUpUITask = (PlayerLevelUpUITask)LuaObject.checkSelf(l);
			bool b = playerLevelUpUITask.m_luaExportHelper.__callBase_IsOpeningUI();
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

	// Token: 0x06020409 RID: 132105 RVA: 0x00AB6A38 File Offset: 0x00AB4C38
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_ReturnPrevUITask(IntPtr l)
	{
		int result;
		try
		{
			PlayerLevelUpUITask playerLevelUpUITask = (PlayerLevelUpUITask)LuaObject.checkSelf(l);
			UITaskBase o = playerLevelUpUITask.m_luaExportHelper.__callBase_ReturnPrevUITask();
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

	// Token: 0x0602040A RID: 132106 RVA: 0x00AB6A94 File Offset: 0x00AB4C94
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_ClearUnusedDynamicResourceCache(IntPtr l)
	{
		int result;
		try
		{
			PlayerLevelUpUITask playerLevelUpUITask = (PlayerLevelUpUITask)LuaObject.checkSelf(l);
			playerLevelUpUITask.m_luaExportHelper.__callBase_ClearUnusedDynamicResourceCache();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0602040B RID: 132107 RVA: 0x00AB6AE8 File Offset: 0x00AB4CE8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_OnMemoryWarning(IntPtr l)
	{
		int result;
		try
		{
			PlayerLevelUpUITask playerLevelUpUITask = (PlayerLevelUpUITask)LuaObject.checkSelf(l);
			playerLevelUpUITask.m_luaExportHelper.__callBase_OnMemoryWarning();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0602040C RID: 132108 RVA: 0x00AB6B3C File Offset: 0x00AB4D3C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callDele_EventOnClose(IntPtr l)
	{
		int result;
		try
		{
			PlayerLevelUpUITask playerLevelUpUITask = (PlayerLevelUpUITask)LuaObject.checkSelf(l);
			playerLevelUpUITask.m_luaExportHelper.__callDele_EventOnClose();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0602040D RID: 132109 RVA: 0x00AB6B90 File Offset: 0x00AB4D90
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __clearDele_EventOnClose(IntPtr l)
	{
		int result;
		try
		{
			PlayerLevelUpUITask playerLevelUpUITask = (PlayerLevelUpUITask)LuaObject.checkSelf(l);
			playerLevelUpUITask.m_luaExportHelper.__clearDele_EventOnClose();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0602040E RID: 132110 RVA: 0x00AB6BE4 File Offset: 0x00AB4DE4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_EventOnClose(IntPtr l)
	{
		int result;
		try
		{
			PlayerLevelUpUITask playerLevelUpUITask = (PlayerLevelUpUITask)LuaObject.checkSelf(l);
			Action value;
			int num = LuaObject.checkDelegate<Action>(l, 2, out value);
			if (num != 0)
			{
				if (num == 1)
				{
					playerLevelUpUITask.EventOnClose += value;
				}
				else if (num == 2)
				{
					playerLevelUpUITask.EventOnClose -= value;
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

	// Token: 0x0602040F RID: 132111 RVA: 0x00AB6C64 File Offset: 0x00AB4E64
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_ParamKey_OldPlayerLevel(IntPtr l)
	{
		int result;
		try
		{
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, PlayerLevelUpUITask.LuaExportHelper.ParamKey_OldPlayerLevel);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06020410 RID: 132112 RVA: 0x00AB6CAC File Offset: 0x00AB4EAC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_ParamKey_NewPlayerLevel(IntPtr l)
	{
		int result;
		try
		{
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, PlayerLevelUpUITask.LuaExportHelper.ParamKey_NewPlayerLevel);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06020411 RID: 132113 RVA: 0x00AB6CF4 File Offset: 0x00AB4EF4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_layerDescArray(IntPtr l)
	{
		int result;
		try
		{
			PlayerLevelUpUITask playerLevelUpUITask = (PlayerLevelUpUITask)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, playerLevelUpUITask.m_luaExportHelper.m_layerDescArray);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06020412 RID: 132114 RVA: 0x00AB6D4C File Offset: 0x00AB4F4C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_layerDescArray(IntPtr l)
	{
		int result;
		try
		{
			PlayerLevelUpUITask playerLevelUpUITask = (PlayerLevelUpUITask)LuaObject.checkSelf(l);
			UITaskBase.LayerDesc[] layerDescArray;
			LuaObject.checkArray<UITaskBase.LayerDesc>(l, 2, out layerDescArray);
			playerLevelUpUITask.m_luaExportHelper.m_layerDescArray = layerDescArray;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06020413 RID: 132115 RVA: 0x00AB6DA8 File Offset: 0x00AB4FA8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_uiCtrlDescArray(IntPtr l)
	{
		int result;
		try
		{
			PlayerLevelUpUITask playerLevelUpUITask = (PlayerLevelUpUITask)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, playerLevelUpUITask.m_luaExportHelper.m_uiCtrlDescArray);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06020414 RID: 132116 RVA: 0x00AB6E00 File Offset: 0x00AB5000
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_uiCtrlDescArray(IntPtr l)
	{
		int result;
		try
		{
			PlayerLevelUpUITask playerLevelUpUITask = (PlayerLevelUpUITask)LuaObject.checkSelf(l);
			UITaskBase.UIControllerDesc[] uiCtrlDescArray;
			LuaObject.checkArray<UITaskBase.UIControllerDesc>(l, 2, out uiCtrlDescArray);
			playerLevelUpUITask.m_luaExportHelper.m_uiCtrlDescArray = uiCtrlDescArray;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06020415 RID: 132117 RVA: 0x00AB6E5C File Offset: 0x00AB505C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_playerLevelUpUIController(IntPtr l)
	{
		int result;
		try
		{
			PlayerLevelUpUITask playerLevelUpUITask = (PlayerLevelUpUITask)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, playerLevelUpUITask.m_luaExportHelper.m_playerLevelUpUIController);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06020416 RID: 132118 RVA: 0x00AB6EB4 File Offset: 0x00AB50B4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_playerLevelUpUIController(IntPtr l)
	{
		int result;
		try
		{
			PlayerLevelUpUITask playerLevelUpUITask = (PlayerLevelUpUITask)LuaObject.checkSelf(l);
			PlayerLevelUpUIController playerLevelUpUIController;
			LuaObject.checkType<PlayerLevelUpUIController>(l, 2, out playerLevelUpUIController);
			playerLevelUpUITask.m_luaExportHelper.m_playerLevelUpUIController = playerLevelUpUIController;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06020417 RID: 132119 RVA: 0x00AB6F10 File Offset: 0x00AB5110
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_oldPlayerLevel(IntPtr l)
	{
		int result;
		try
		{
			PlayerLevelUpUITask playerLevelUpUITask = (PlayerLevelUpUITask)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, playerLevelUpUITask.m_luaExportHelper.m_oldPlayerLevel);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06020418 RID: 132120 RVA: 0x00AB6F68 File Offset: 0x00AB5168
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_oldPlayerLevel(IntPtr l)
	{
		int result;
		try
		{
			PlayerLevelUpUITask playerLevelUpUITask = (PlayerLevelUpUITask)LuaObject.checkSelf(l);
			int oldPlayerLevel;
			LuaObject.checkType(l, 2, out oldPlayerLevel);
			playerLevelUpUITask.m_luaExportHelper.m_oldPlayerLevel = oldPlayerLevel;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06020419 RID: 132121 RVA: 0x00AB6FC4 File Offset: 0x00AB51C4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_newPlayerLevel(IntPtr l)
	{
		int result;
		try
		{
			PlayerLevelUpUITask playerLevelUpUITask = (PlayerLevelUpUITask)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, playerLevelUpUITask.m_luaExportHelper.m_newPlayerLevel);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0602041A RID: 132122 RVA: 0x00AB701C File Offset: 0x00AB521C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_newPlayerLevel(IntPtr l)
	{
		int result;
		try
		{
			PlayerLevelUpUITask playerLevelUpUITask = (PlayerLevelUpUITask)LuaObject.checkSelf(l);
			int newPlayerLevel;
			LuaObject.checkType(l, 2, out newPlayerLevel);
			playerLevelUpUITask.m_luaExportHelper.m_newPlayerLevel = newPlayerLevel;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0602041B RID: 132123 RVA: 0x00AB7078 File Offset: 0x00AB5278
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_LayerDescArray(IntPtr l)
	{
		int result;
		try
		{
			PlayerLevelUpUITask playerLevelUpUITask = (PlayerLevelUpUITask)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, playerLevelUpUITask.m_luaExportHelper.LayerDescArray);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0602041C RID: 132124 RVA: 0x00AB70D0 File Offset: 0x00AB52D0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_UICtrlDescArray(IntPtr l)
	{
		int result;
		try
		{
			PlayerLevelUpUITask playerLevelUpUITask = (PlayerLevelUpUITask)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, playerLevelUpUITask.m_luaExportHelper.UICtrlDescArray);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0602041D RID: 132125 RVA: 0x00AB7128 File Offset: 0x00AB5328
	[Preserve]
	public static void reg(IntPtr l)
	{
		LuaObject.getTypeTable(l, "BlackJack.ProjectL.UI.PlayerLevelUpUITask");
		if (Lua_BlackJack_ProjectL_UI_PlayerLevelUpUITask.<>f__mg$cache0 == null)
		{
			Lua_BlackJack_ProjectL_UI_PlayerLevelUpUITask.<>f__mg$cache0 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_PlayerLevelUpUITask.StartUITask_s);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_PlayerLevelUpUITask.<>f__mg$cache0);
		if (Lua_BlackJack_ProjectL_UI_PlayerLevelUpUITask.<>f__mg$cache1 == null)
		{
			Lua_BlackJack_ProjectL_UI_PlayerLevelUpUITask.<>f__mg$cache1 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_PlayerLevelUpUITask.OnStart);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_PlayerLevelUpUITask.<>f__mg$cache1);
		if (Lua_BlackJack_ProjectL_UI_PlayerLevelUpUITask.<>f__mg$cache2 == null)
		{
			Lua_BlackJack_ProjectL_UI_PlayerLevelUpUITask.<>f__mg$cache2 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_PlayerLevelUpUITask.OnResume);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_PlayerLevelUpUITask.<>f__mg$cache2);
		if (Lua_BlackJack_ProjectL_UI_PlayerLevelUpUITask.<>f__mg$cache3 == null)
		{
			Lua_BlackJack_ProjectL_UI_PlayerLevelUpUITask.<>f__mg$cache3 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_PlayerLevelUpUITask.InitAllUIControllers);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_PlayerLevelUpUITask.<>f__mg$cache3);
		if (Lua_BlackJack_ProjectL_UI_PlayerLevelUpUITask.<>f__mg$cache4 == null)
		{
			Lua_BlackJack_ProjectL_UI_PlayerLevelUpUITask.<>f__mg$cache4 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_PlayerLevelUpUITask.ClearAllContextAndRes);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_PlayerLevelUpUITask.<>f__mg$cache4);
		if (Lua_BlackJack_ProjectL_UI_PlayerLevelUpUITask.<>f__mg$cache5 == null)
		{
			Lua_BlackJack_ProjectL_UI_PlayerLevelUpUITask.<>f__mg$cache5 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_PlayerLevelUpUITask.UpdateView);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_PlayerLevelUpUITask.<>f__mg$cache5);
		if (Lua_BlackJack_ProjectL_UI_PlayerLevelUpUITask.<>f__mg$cache6 == null)
		{
			Lua_BlackJack_ProjectL_UI_PlayerLevelUpUITask.<>f__mg$cache6 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_PlayerLevelUpUITask.OnClose);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_PlayerLevelUpUITask.<>f__mg$cache6);
		if (Lua_BlackJack_ProjectL_UI_PlayerLevelUpUITask.<>f__mg$cache7 == null)
		{
			Lua_BlackJack_ProjectL_UI_PlayerLevelUpUITask.<>f__mg$cache7 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_PlayerLevelUpUITask.InitDataFromUIIntent);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_PlayerLevelUpUITask.<>f__mg$cache7);
		if (Lua_BlackJack_ProjectL_UI_PlayerLevelUpUITask.<>f__mg$cache8 == null)
		{
			Lua_BlackJack_ProjectL_UI_PlayerLevelUpUITask.<>f__mg$cache8 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_PlayerLevelUpUITask.__callBase_OnStart);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_PlayerLevelUpUITask.<>f__mg$cache8);
		if (Lua_BlackJack_ProjectL_UI_PlayerLevelUpUITask.<>f__mg$cache9 == null)
		{
			Lua_BlackJack_ProjectL_UI_PlayerLevelUpUITask.<>f__mg$cache9 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_PlayerLevelUpUITask.__callBase_OnStop);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_PlayerLevelUpUITask.<>f__mg$cache9);
		if (Lua_BlackJack_ProjectL_UI_PlayerLevelUpUITask.<>f__mg$cacheA == null)
		{
			Lua_BlackJack_ProjectL_UI_PlayerLevelUpUITask.<>f__mg$cacheA = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_PlayerLevelUpUITask.__callBase_OnPause);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_PlayerLevelUpUITask.<>f__mg$cacheA);
		if (Lua_BlackJack_ProjectL_UI_PlayerLevelUpUITask.<>f__mg$cacheB == null)
		{
			Lua_BlackJack_ProjectL_UI_PlayerLevelUpUITask.<>f__mg$cacheB = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_PlayerLevelUpUITask.__callBase_OnResume);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_PlayerLevelUpUITask.<>f__mg$cacheB);
		if (Lua_BlackJack_ProjectL_UI_PlayerLevelUpUITask.<>f__mg$cacheC == null)
		{
			Lua_BlackJack_ProjectL_UI_PlayerLevelUpUITask.<>f__mg$cacheC = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_PlayerLevelUpUITask.__callBase_OnNewIntent);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_PlayerLevelUpUITask.<>f__mg$cacheC);
		if (Lua_BlackJack_ProjectL_UI_PlayerLevelUpUITask.<>f__mg$cacheD == null)
		{
			Lua_BlackJack_ProjectL_UI_PlayerLevelUpUITask.<>f__mg$cacheD = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_PlayerLevelUpUITask.__callBase_EnableUIInput);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_PlayerLevelUpUITask.<>f__mg$cacheD);
		if (Lua_BlackJack_ProjectL_UI_PlayerLevelUpUITask.<>f__mg$cacheE == null)
		{
			Lua_BlackJack_ProjectL_UI_PlayerLevelUpUITask.<>f__mg$cacheE = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_PlayerLevelUpUITask.__callBase_IsNeedLoadDynamicRes);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_PlayerLevelUpUITask.<>f__mg$cacheE);
		if (Lua_BlackJack_ProjectL_UI_PlayerLevelUpUITask.<>f__mg$cacheF == null)
		{
			Lua_BlackJack_ProjectL_UI_PlayerLevelUpUITask.<>f__mg$cacheF = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_PlayerLevelUpUITask.__callBase_CollectAllDynamicResForLoad);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_PlayerLevelUpUITask.<>f__mg$cacheF);
		if (Lua_BlackJack_ProjectL_UI_PlayerLevelUpUITask.<>f__mg$cache10 == null)
		{
			Lua_BlackJack_ProjectL_UI_PlayerLevelUpUITask.<>f__mg$cache10 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_PlayerLevelUpUITask.__callBase_RegisterPlayerContextEvents);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_PlayerLevelUpUITask.<>f__mg$cache10);
		if (Lua_BlackJack_ProjectL_UI_PlayerLevelUpUITask.<>f__mg$cache11 == null)
		{
			Lua_BlackJack_ProjectL_UI_PlayerLevelUpUITask.<>f__mg$cache11 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_PlayerLevelUpUITask.__callBase_UnregisterPlayerContextEvents);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_PlayerLevelUpUITask.<>f__mg$cache11);
		if (Lua_BlackJack_ProjectL_UI_PlayerLevelUpUITask.<>f__mg$cache12 == null)
		{
			Lua_BlackJack_ProjectL_UI_PlayerLevelUpUITask.<>f__mg$cache12 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_PlayerLevelUpUITask.__callBase_PostUpdateView);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_PlayerLevelUpUITask.<>f__mg$cache12);
		if (Lua_BlackJack_ProjectL_UI_PlayerLevelUpUITask.<>f__mg$cache13 == null)
		{
			Lua_BlackJack_ProjectL_UI_PlayerLevelUpUITask.<>f__mg$cache13 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_PlayerLevelUpUITask.__callBase_CollectPreloadResourceList);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_PlayerLevelUpUITask.<>f__mg$cache13);
		if (Lua_BlackJack_ProjectL_UI_PlayerLevelUpUITask.<>f__mg$cache14 == null)
		{
			Lua_BlackJack_ProjectL_UI_PlayerLevelUpUITask.<>f__mg$cache14 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_PlayerLevelUpUITask.__callBase_ClearAssetList);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_PlayerLevelUpUITask.<>f__mg$cache14);
		if (Lua_BlackJack_ProjectL_UI_PlayerLevelUpUITask.<>f__mg$cache15 == null)
		{
			Lua_BlackJack_ProjectL_UI_PlayerLevelUpUITask.<>f__mg$cache15 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_PlayerLevelUpUITask.__callBase_CollectAsset);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_PlayerLevelUpUITask.<>f__mg$cache15);
		if (Lua_BlackJack_ProjectL_UI_PlayerLevelUpUITask.<>f__mg$cache16 == null)
		{
			Lua_BlackJack_ProjectL_UI_PlayerLevelUpUITask.<>f__mg$cache16 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_PlayerLevelUpUITask.__callBase_CollectSpriteAsset);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_PlayerLevelUpUITask.<>f__mg$cache16);
		if (Lua_BlackJack_ProjectL_UI_PlayerLevelUpUITask.<>f__mg$cache17 == null)
		{
			Lua_BlackJack_ProjectL_UI_PlayerLevelUpUITask.<>f__mg$cache17 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_PlayerLevelUpUITask.__callBase_CollectFxAsset);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_PlayerLevelUpUITask.<>f__mg$cache17);
		if (Lua_BlackJack_ProjectL_UI_PlayerLevelUpUITask.<>f__mg$cache18 == null)
		{
			Lua_BlackJack_ProjectL_UI_PlayerLevelUpUITask.<>f__mg$cache18 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_PlayerLevelUpUITask.__callBase_StartLoadCustomAssets);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_PlayerLevelUpUITask.<>f__mg$cache18);
		if (Lua_BlackJack_ProjectL_UI_PlayerLevelUpUITask.<>f__mg$cache19 == null)
		{
			Lua_BlackJack_ProjectL_UI_PlayerLevelUpUITask.<>f__mg$cache19 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_PlayerLevelUpUITask.__callBase_IsLoadingCustomAssets);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_PlayerLevelUpUITask.<>f__mg$cache19);
		if (Lua_BlackJack_ProjectL_UI_PlayerLevelUpUITask.<>f__mg$cache1A == null)
		{
			Lua_BlackJack_ProjectL_UI_PlayerLevelUpUITask.<>f__mg$cache1A = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_PlayerLevelUpUITask.__callBase_IsPipeLineRunning);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_PlayerLevelUpUITask.<>f__mg$cache1A);
		if (Lua_BlackJack_ProjectL_UI_PlayerLevelUpUITask.<>f__mg$cache1B == null)
		{
			Lua_BlackJack_ProjectL_UI_PlayerLevelUpUITask.<>f__mg$cache1B = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_PlayerLevelUpUITask.__callBase_IsOpeningUI);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_PlayerLevelUpUITask.<>f__mg$cache1B);
		if (Lua_BlackJack_ProjectL_UI_PlayerLevelUpUITask.<>f__mg$cache1C == null)
		{
			Lua_BlackJack_ProjectL_UI_PlayerLevelUpUITask.<>f__mg$cache1C = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_PlayerLevelUpUITask.__callBase_ReturnPrevUITask);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_PlayerLevelUpUITask.<>f__mg$cache1C);
		if (Lua_BlackJack_ProjectL_UI_PlayerLevelUpUITask.<>f__mg$cache1D == null)
		{
			Lua_BlackJack_ProjectL_UI_PlayerLevelUpUITask.<>f__mg$cache1D = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_PlayerLevelUpUITask.__callBase_ClearUnusedDynamicResourceCache);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_PlayerLevelUpUITask.<>f__mg$cache1D);
		if (Lua_BlackJack_ProjectL_UI_PlayerLevelUpUITask.<>f__mg$cache1E == null)
		{
			Lua_BlackJack_ProjectL_UI_PlayerLevelUpUITask.<>f__mg$cache1E = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_PlayerLevelUpUITask.__callBase_OnMemoryWarning);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_PlayerLevelUpUITask.<>f__mg$cache1E);
		if (Lua_BlackJack_ProjectL_UI_PlayerLevelUpUITask.<>f__mg$cache1F == null)
		{
			Lua_BlackJack_ProjectL_UI_PlayerLevelUpUITask.<>f__mg$cache1F = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_PlayerLevelUpUITask.__callDele_EventOnClose);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_PlayerLevelUpUITask.<>f__mg$cache1F);
		if (Lua_BlackJack_ProjectL_UI_PlayerLevelUpUITask.<>f__mg$cache20 == null)
		{
			Lua_BlackJack_ProjectL_UI_PlayerLevelUpUITask.<>f__mg$cache20 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_PlayerLevelUpUITask.__clearDele_EventOnClose);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_PlayerLevelUpUITask.<>f__mg$cache20);
		string name = "EventOnClose";
		LuaCSFunction get = null;
		if (Lua_BlackJack_ProjectL_UI_PlayerLevelUpUITask.<>f__mg$cache21 == null)
		{
			Lua_BlackJack_ProjectL_UI_PlayerLevelUpUITask.<>f__mg$cache21 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_PlayerLevelUpUITask.set_EventOnClose);
		}
		LuaObject.addMember(l, name, get, Lua_BlackJack_ProjectL_UI_PlayerLevelUpUITask.<>f__mg$cache21, true);
		string name2 = "ParamKey_OldPlayerLevel";
		if (Lua_BlackJack_ProjectL_UI_PlayerLevelUpUITask.<>f__mg$cache22 == null)
		{
			Lua_BlackJack_ProjectL_UI_PlayerLevelUpUITask.<>f__mg$cache22 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_PlayerLevelUpUITask.get_ParamKey_OldPlayerLevel);
		}
		LuaObject.addMember(l, name2, Lua_BlackJack_ProjectL_UI_PlayerLevelUpUITask.<>f__mg$cache22, null, false);
		string name3 = "ParamKey_NewPlayerLevel";
		if (Lua_BlackJack_ProjectL_UI_PlayerLevelUpUITask.<>f__mg$cache23 == null)
		{
			Lua_BlackJack_ProjectL_UI_PlayerLevelUpUITask.<>f__mg$cache23 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_PlayerLevelUpUITask.get_ParamKey_NewPlayerLevel);
		}
		LuaObject.addMember(l, name3, Lua_BlackJack_ProjectL_UI_PlayerLevelUpUITask.<>f__mg$cache23, null, false);
		string name4 = "m_layerDescArray";
		if (Lua_BlackJack_ProjectL_UI_PlayerLevelUpUITask.<>f__mg$cache24 == null)
		{
			Lua_BlackJack_ProjectL_UI_PlayerLevelUpUITask.<>f__mg$cache24 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_PlayerLevelUpUITask.get_m_layerDescArray);
		}
		LuaCSFunction get2 = Lua_BlackJack_ProjectL_UI_PlayerLevelUpUITask.<>f__mg$cache24;
		if (Lua_BlackJack_ProjectL_UI_PlayerLevelUpUITask.<>f__mg$cache25 == null)
		{
			Lua_BlackJack_ProjectL_UI_PlayerLevelUpUITask.<>f__mg$cache25 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_PlayerLevelUpUITask.set_m_layerDescArray);
		}
		LuaObject.addMember(l, name4, get2, Lua_BlackJack_ProjectL_UI_PlayerLevelUpUITask.<>f__mg$cache25, true);
		string name5 = "m_uiCtrlDescArray";
		if (Lua_BlackJack_ProjectL_UI_PlayerLevelUpUITask.<>f__mg$cache26 == null)
		{
			Lua_BlackJack_ProjectL_UI_PlayerLevelUpUITask.<>f__mg$cache26 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_PlayerLevelUpUITask.get_m_uiCtrlDescArray);
		}
		LuaCSFunction get3 = Lua_BlackJack_ProjectL_UI_PlayerLevelUpUITask.<>f__mg$cache26;
		if (Lua_BlackJack_ProjectL_UI_PlayerLevelUpUITask.<>f__mg$cache27 == null)
		{
			Lua_BlackJack_ProjectL_UI_PlayerLevelUpUITask.<>f__mg$cache27 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_PlayerLevelUpUITask.set_m_uiCtrlDescArray);
		}
		LuaObject.addMember(l, name5, get3, Lua_BlackJack_ProjectL_UI_PlayerLevelUpUITask.<>f__mg$cache27, true);
		string name6 = "m_playerLevelUpUIController";
		if (Lua_BlackJack_ProjectL_UI_PlayerLevelUpUITask.<>f__mg$cache28 == null)
		{
			Lua_BlackJack_ProjectL_UI_PlayerLevelUpUITask.<>f__mg$cache28 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_PlayerLevelUpUITask.get_m_playerLevelUpUIController);
		}
		LuaCSFunction get4 = Lua_BlackJack_ProjectL_UI_PlayerLevelUpUITask.<>f__mg$cache28;
		if (Lua_BlackJack_ProjectL_UI_PlayerLevelUpUITask.<>f__mg$cache29 == null)
		{
			Lua_BlackJack_ProjectL_UI_PlayerLevelUpUITask.<>f__mg$cache29 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_PlayerLevelUpUITask.set_m_playerLevelUpUIController);
		}
		LuaObject.addMember(l, name6, get4, Lua_BlackJack_ProjectL_UI_PlayerLevelUpUITask.<>f__mg$cache29, true);
		string name7 = "m_oldPlayerLevel";
		if (Lua_BlackJack_ProjectL_UI_PlayerLevelUpUITask.<>f__mg$cache2A == null)
		{
			Lua_BlackJack_ProjectL_UI_PlayerLevelUpUITask.<>f__mg$cache2A = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_PlayerLevelUpUITask.get_m_oldPlayerLevel);
		}
		LuaCSFunction get5 = Lua_BlackJack_ProjectL_UI_PlayerLevelUpUITask.<>f__mg$cache2A;
		if (Lua_BlackJack_ProjectL_UI_PlayerLevelUpUITask.<>f__mg$cache2B == null)
		{
			Lua_BlackJack_ProjectL_UI_PlayerLevelUpUITask.<>f__mg$cache2B = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_PlayerLevelUpUITask.set_m_oldPlayerLevel);
		}
		LuaObject.addMember(l, name7, get5, Lua_BlackJack_ProjectL_UI_PlayerLevelUpUITask.<>f__mg$cache2B, true);
		string name8 = "m_newPlayerLevel";
		if (Lua_BlackJack_ProjectL_UI_PlayerLevelUpUITask.<>f__mg$cache2C == null)
		{
			Lua_BlackJack_ProjectL_UI_PlayerLevelUpUITask.<>f__mg$cache2C = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_PlayerLevelUpUITask.get_m_newPlayerLevel);
		}
		LuaCSFunction get6 = Lua_BlackJack_ProjectL_UI_PlayerLevelUpUITask.<>f__mg$cache2C;
		if (Lua_BlackJack_ProjectL_UI_PlayerLevelUpUITask.<>f__mg$cache2D == null)
		{
			Lua_BlackJack_ProjectL_UI_PlayerLevelUpUITask.<>f__mg$cache2D = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_PlayerLevelUpUITask.set_m_newPlayerLevel);
		}
		LuaObject.addMember(l, name8, get6, Lua_BlackJack_ProjectL_UI_PlayerLevelUpUITask.<>f__mg$cache2D, true);
		string name9 = "LayerDescArray";
		if (Lua_BlackJack_ProjectL_UI_PlayerLevelUpUITask.<>f__mg$cache2E == null)
		{
			Lua_BlackJack_ProjectL_UI_PlayerLevelUpUITask.<>f__mg$cache2E = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_PlayerLevelUpUITask.get_LayerDescArray);
		}
		LuaObject.addMember(l, name9, Lua_BlackJack_ProjectL_UI_PlayerLevelUpUITask.<>f__mg$cache2E, null, true);
		string name10 = "UICtrlDescArray";
		if (Lua_BlackJack_ProjectL_UI_PlayerLevelUpUITask.<>f__mg$cache2F == null)
		{
			Lua_BlackJack_ProjectL_UI_PlayerLevelUpUITask.<>f__mg$cache2F = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_PlayerLevelUpUITask.get_UICtrlDescArray);
		}
		LuaObject.addMember(l, name10, Lua_BlackJack_ProjectL_UI_PlayerLevelUpUITask.<>f__mg$cache2F, null, true);
		if (Lua_BlackJack_ProjectL_UI_PlayerLevelUpUITask.<>f__mg$cache30 == null)
		{
			Lua_BlackJack_ProjectL_UI_PlayerLevelUpUITask.<>f__mg$cache30 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_PlayerLevelUpUITask.constructor);
		}
		LuaObject.createTypeMetatable(l, Lua_BlackJack_ProjectL_UI_PlayerLevelUpUITask.<>f__mg$cache30, typeof(PlayerLevelUpUITask), typeof(UITask));
	}

	// Token: 0x04016372 RID: 90994
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache0;

	// Token: 0x04016373 RID: 90995
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1;

	// Token: 0x04016374 RID: 90996
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2;

	// Token: 0x04016375 RID: 90997
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3;

	// Token: 0x04016376 RID: 90998
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache4;

	// Token: 0x04016377 RID: 90999
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache5;

	// Token: 0x04016378 RID: 91000
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache6;

	// Token: 0x04016379 RID: 91001
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache7;

	// Token: 0x0401637A RID: 91002
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache8;

	// Token: 0x0401637B RID: 91003
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache9;

	// Token: 0x0401637C RID: 91004
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheA;

	// Token: 0x0401637D RID: 91005
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheB;

	// Token: 0x0401637E RID: 91006
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheC;

	// Token: 0x0401637F RID: 91007
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheD;

	// Token: 0x04016380 RID: 91008
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheE;

	// Token: 0x04016381 RID: 91009
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheF;

	// Token: 0x04016382 RID: 91010
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache10;

	// Token: 0x04016383 RID: 91011
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache11;

	// Token: 0x04016384 RID: 91012
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache12;

	// Token: 0x04016385 RID: 91013
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache13;

	// Token: 0x04016386 RID: 91014
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache14;

	// Token: 0x04016387 RID: 91015
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache15;

	// Token: 0x04016388 RID: 91016
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache16;

	// Token: 0x04016389 RID: 91017
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache17;

	// Token: 0x0401638A RID: 91018
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache18;

	// Token: 0x0401638B RID: 91019
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache19;

	// Token: 0x0401638C RID: 91020
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1A;

	// Token: 0x0401638D RID: 91021
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1B;

	// Token: 0x0401638E RID: 91022
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1C;

	// Token: 0x0401638F RID: 91023
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1D;

	// Token: 0x04016390 RID: 91024
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1E;

	// Token: 0x04016391 RID: 91025
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1F;

	// Token: 0x04016392 RID: 91026
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache20;

	// Token: 0x04016393 RID: 91027
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache21;

	// Token: 0x04016394 RID: 91028
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache22;

	// Token: 0x04016395 RID: 91029
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache23;

	// Token: 0x04016396 RID: 91030
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache24;

	// Token: 0x04016397 RID: 91031
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache25;

	// Token: 0x04016398 RID: 91032
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache26;

	// Token: 0x04016399 RID: 91033
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache27;

	// Token: 0x0401639A RID: 91034
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache28;

	// Token: 0x0401639B RID: 91035
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache29;

	// Token: 0x0401639C RID: 91036
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2A;

	// Token: 0x0401639D RID: 91037
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2B;

	// Token: 0x0401639E RID: 91038
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2C;

	// Token: 0x0401639F RID: 91039
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2D;

	// Token: 0x040163A0 RID: 91040
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2E;

	// Token: 0x040163A1 RID: 91041
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2F;

	// Token: 0x040163A2 RID: 91042
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache30;
}
