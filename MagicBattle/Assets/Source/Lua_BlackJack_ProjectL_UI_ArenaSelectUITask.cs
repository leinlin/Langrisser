using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using BlackJack.BJFramework.Runtime.UI;
using BlackJack.ProjectL.UI;
using SLua;
using UnityEngine.Scripting;

// Token: 0x02001382 RID: 4994
[Preserve]
public class Lua_BlackJack_ProjectL_UI_ArenaSelectUITask : LuaObject
{
	// Token: 0x0601B071 RID: 110705 RVA: 0x0081E31C File Offset: 0x0081C51C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int constructor(IntPtr l)
	{
		int result;
		try
		{
			string name;
			LuaObject.checkType(l, 2, out name);
			ArenaSelectUITask o = new ArenaSelectUITask(name);
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

	// Token: 0x0601B072 RID: 110706 RVA: 0x0081E370 File Offset: 0x0081C570
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int OnResume(IntPtr l)
	{
		int result;
		try
		{
			ArenaSelectUITask arenaSelectUITask = (ArenaSelectUITask)LuaObject.checkSelf(l);
			UIIntent intent;
			LuaObject.checkType<UIIntent>(l, 2, out intent);
			bool b = arenaSelectUITask.m_luaExportHelper.OnResume(intent);
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

	// Token: 0x0601B073 RID: 110707 RVA: 0x0081E3D8 File Offset: 0x0081C5D8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int InitAllUIControllers(IntPtr l)
	{
		int result;
		try
		{
			ArenaSelectUITask arenaSelectUITask = (ArenaSelectUITask)LuaObject.checkSelf(l);
			arenaSelectUITask.m_luaExportHelper.InitAllUIControllers();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601B074 RID: 110708 RVA: 0x0081E42C File Offset: 0x0081C62C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int ClearAllContextAndRes(IntPtr l)
	{
		int result;
		try
		{
			ArenaSelectUITask arenaSelectUITask = (ArenaSelectUITask)LuaObject.checkSelf(l);
			arenaSelectUITask.m_luaExportHelper.ClearAllContextAndRes();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601B075 RID: 110709 RVA: 0x0081E480 File Offset: 0x0081C680
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int InitArenaSelectUIController(IntPtr l)
	{
		int result;
		try
		{
			ArenaSelectUITask arenaSelectUITask = (ArenaSelectUITask)LuaObject.checkSelf(l);
			arenaSelectUITask.m_luaExportHelper.InitArenaSelectUIController();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601B076 RID: 110710 RVA: 0x0081E4D4 File Offset: 0x0081C6D4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int UninitArenaSelectUIController(IntPtr l)
	{
		int result;
		try
		{
			ArenaSelectUITask arenaSelectUITask = (ArenaSelectUITask)LuaObject.checkSelf(l);
			arenaSelectUITask.m_luaExportHelper.UninitArenaSelectUIController();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601B077 RID: 110711 RVA: 0x0081E528 File Offset: 0x0081C728
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int UpdateView(IntPtr l)
	{
		int result;
		try
		{
			ArenaSelectUITask arenaSelectUITask = (ArenaSelectUITask)LuaObject.checkSelf(l);
			arenaSelectUITask.m_luaExportHelper.UpdateView();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601B078 RID: 110712 RVA: 0x0081E57C File Offset: 0x0081C77C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int ArenaSelectUIController_OnShowOfflineArena(IntPtr l)
	{
		int result;
		try
		{
			ArenaSelectUITask arenaSelectUITask = (ArenaSelectUITask)LuaObject.checkSelf(l);
			arenaSelectUITask.m_luaExportHelper.ArenaSelectUIController_OnShowOfflineArena();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601B079 RID: 110713 RVA: 0x0081E5D0 File Offset: 0x0081C7D0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int ArenaSelectUIController_OnShowOnlineArena(IntPtr l)
	{
		int result;
		try
		{
			ArenaSelectUITask arenaSelectUITask = (ArenaSelectUITask)LuaObject.checkSelf(l);
			arenaSelectUITask.m_luaExportHelper.ArenaSelectUIController_OnShowOnlineArena();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601B07A RID: 110714 RVA: 0x0081E624 File Offset: 0x0081C824
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int ArenaSelectUIController_OnClose(IntPtr l)
	{
		int result;
		try
		{
			ArenaSelectUITask arenaSelectUITask = (ArenaSelectUITask)LuaObject.checkSelf(l);
			arenaSelectUITask.m_luaExportHelper.ArenaSelectUIController_OnClose();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601B07B RID: 110715 RVA: 0x0081E678 File Offset: 0x0081C878
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_OnStart(IntPtr l)
	{
		int result;
		try
		{
			ArenaSelectUITask arenaSelectUITask = (ArenaSelectUITask)LuaObject.checkSelf(l);
			UIIntent intent;
			LuaObject.checkType<UIIntent>(l, 2, out intent);
			bool b = arenaSelectUITask.m_luaExportHelper.__callBase_OnStart(intent);
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

	// Token: 0x0601B07C RID: 110716 RVA: 0x0081E6E0 File Offset: 0x0081C8E0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_OnStop(IntPtr l)
	{
		int result;
		try
		{
			ArenaSelectUITask arenaSelectUITask = (ArenaSelectUITask)LuaObject.checkSelf(l);
			arenaSelectUITask.m_luaExportHelper.__callBase_OnStop();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601B07D RID: 110717 RVA: 0x0081E734 File Offset: 0x0081C934
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_OnPause(IntPtr l)
	{
		int result;
		try
		{
			ArenaSelectUITask arenaSelectUITask = (ArenaSelectUITask)LuaObject.checkSelf(l);
			arenaSelectUITask.m_luaExportHelper.__callBase_OnPause();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601B07E RID: 110718 RVA: 0x0081E788 File Offset: 0x0081C988
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_OnResume(IntPtr l)
	{
		int result;
		try
		{
			ArenaSelectUITask arenaSelectUITask = (ArenaSelectUITask)LuaObject.checkSelf(l);
			UIIntent intent;
			LuaObject.checkType<UIIntent>(l, 2, out intent);
			bool b = arenaSelectUITask.m_luaExportHelper.__callBase_OnResume(intent);
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

	// Token: 0x0601B07F RID: 110719 RVA: 0x0081E7F0 File Offset: 0x0081C9F0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_OnNewIntent(IntPtr l)
	{
		int result;
		try
		{
			ArenaSelectUITask arenaSelectUITask = (ArenaSelectUITask)LuaObject.checkSelf(l);
			UIIntent intent;
			LuaObject.checkType<UIIntent>(l, 2, out intent);
			bool b = arenaSelectUITask.m_luaExportHelper.__callBase_OnNewIntent(intent);
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

	// Token: 0x0601B080 RID: 110720 RVA: 0x0081E858 File Offset: 0x0081CA58
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_EnableUIInput(IntPtr l)
	{
		int result;
		try
		{
			ArenaSelectUITask arenaSelectUITask = (ArenaSelectUITask)LuaObject.checkSelf(l);
			bool isEnable;
			LuaObject.checkType(l, 2, out isEnable);
			bool? isGlobalEnable;
			LuaObject.checkNullable<bool>(l, 3, out isGlobalEnable);
			arenaSelectUITask.m_luaExportHelper.__callBase_EnableUIInput(isEnable, isGlobalEnable);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601B081 RID: 110721 RVA: 0x0081E8C4 File Offset: 0x0081CAC4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_IsNeedLoadDynamicRes(IntPtr l)
	{
		int result;
		try
		{
			ArenaSelectUITask arenaSelectUITask = (ArenaSelectUITask)LuaObject.checkSelf(l);
			bool b = arenaSelectUITask.m_luaExportHelper.__callBase_IsNeedLoadDynamicRes();
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

	// Token: 0x0601B082 RID: 110722 RVA: 0x0081E920 File Offset: 0x0081CB20
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_CollectAllDynamicResForLoad(IntPtr l)
	{
		int result;
		try
		{
			ArenaSelectUITask arenaSelectUITask = (ArenaSelectUITask)LuaObject.checkSelf(l);
			List<string> o = arenaSelectUITask.m_luaExportHelper.__callBase_CollectAllDynamicResForLoad();
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

	// Token: 0x0601B083 RID: 110723 RVA: 0x0081E97C File Offset: 0x0081CB7C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_RegisterPlayerContextEvents(IntPtr l)
	{
		int result;
		try
		{
			ArenaSelectUITask arenaSelectUITask = (ArenaSelectUITask)LuaObject.checkSelf(l);
			arenaSelectUITask.m_luaExportHelper.__callBase_RegisterPlayerContextEvents();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601B084 RID: 110724 RVA: 0x0081E9D0 File Offset: 0x0081CBD0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_UnregisterPlayerContextEvents(IntPtr l)
	{
		int result;
		try
		{
			ArenaSelectUITask arenaSelectUITask = (ArenaSelectUITask)LuaObject.checkSelf(l);
			arenaSelectUITask.m_luaExportHelper.__callBase_UnregisterPlayerContextEvents();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601B085 RID: 110725 RVA: 0x0081EA24 File Offset: 0x0081CC24
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_PostUpdateView(IntPtr l)
	{
		int result;
		try
		{
			ArenaSelectUITask arenaSelectUITask = (ArenaSelectUITask)LuaObject.checkSelf(l);
			arenaSelectUITask.m_luaExportHelper.__callBase_PostUpdateView();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601B086 RID: 110726 RVA: 0x0081EA78 File Offset: 0x0081CC78
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_CollectPreloadResourceList(IntPtr l)
	{
		int result;
		try
		{
			ArenaSelectUITask arenaSelectUITask = (ArenaSelectUITask)LuaObject.checkSelf(l);
			arenaSelectUITask.m_luaExportHelper.__callBase_CollectPreloadResourceList();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601B087 RID: 110727 RVA: 0x0081EACC File Offset: 0x0081CCCC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_ClearAssetList(IntPtr l)
	{
		int result;
		try
		{
			ArenaSelectUITask arenaSelectUITask = (ArenaSelectUITask)LuaObject.checkSelf(l);
			arenaSelectUITask.m_luaExportHelper.__callBase_ClearAssetList();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601B088 RID: 110728 RVA: 0x0081EB20 File Offset: 0x0081CD20
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_CollectAsset(IntPtr l)
	{
		int result;
		try
		{
			ArenaSelectUITask arenaSelectUITask = (ArenaSelectUITask)LuaObject.checkSelf(l);
			string assetName;
			LuaObject.checkType(l, 2, out assetName);
			arenaSelectUITask.m_luaExportHelper.__callBase_CollectAsset(assetName);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601B089 RID: 110729 RVA: 0x0081EB7C File Offset: 0x0081CD7C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_CollectSpriteAsset(IntPtr l)
	{
		int result;
		try
		{
			ArenaSelectUITask arenaSelectUITask = (ArenaSelectUITask)LuaObject.checkSelf(l);
			string assetName;
			LuaObject.checkType(l, 2, out assetName);
			arenaSelectUITask.m_luaExportHelper.__callBase_CollectSpriteAsset(assetName);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601B08A RID: 110730 RVA: 0x0081EBD8 File Offset: 0x0081CDD8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_CollectFxAsset(IntPtr l)
	{
		int result;
		try
		{
			ArenaSelectUITask arenaSelectUITask = (ArenaSelectUITask)LuaObject.checkSelf(l);
			string assetName;
			LuaObject.checkType(l, 2, out assetName);
			arenaSelectUITask.m_luaExportHelper.__callBase_CollectFxAsset(assetName);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601B08B RID: 110731 RVA: 0x0081EC34 File Offset: 0x0081CE34
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_StartLoadCustomAssets(IntPtr l)
	{
		int result;
		try
		{
			ArenaSelectUITask arenaSelectUITask = (ArenaSelectUITask)LuaObject.checkSelf(l);
			Action onLoadCompleted;
			LuaObject.checkDelegate<Action>(l, 2, out onLoadCompleted);
			arenaSelectUITask.m_luaExportHelper.__callBase_StartLoadCustomAssets(onLoadCompleted);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601B08C RID: 110732 RVA: 0x0081EC90 File Offset: 0x0081CE90
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_IsLoadingCustomAssets(IntPtr l)
	{
		int result;
		try
		{
			ArenaSelectUITask arenaSelectUITask = (ArenaSelectUITask)LuaObject.checkSelf(l);
			bool b = arenaSelectUITask.m_luaExportHelper.__callBase_IsLoadingCustomAssets();
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

	// Token: 0x0601B08D RID: 110733 RVA: 0x0081ECEC File Offset: 0x0081CEEC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_IsPipeLineRunning(IntPtr l)
	{
		int result;
		try
		{
			ArenaSelectUITask arenaSelectUITask = (ArenaSelectUITask)LuaObject.checkSelf(l);
			bool b = arenaSelectUITask.m_luaExportHelper.__callBase_IsPipeLineRunning();
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

	// Token: 0x0601B08E RID: 110734 RVA: 0x0081ED48 File Offset: 0x0081CF48
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_IsOpeningUI(IntPtr l)
	{
		int result;
		try
		{
			ArenaSelectUITask arenaSelectUITask = (ArenaSelectUITask)LuaObject.checkSelf(l);
			bool b = arenaSelectUITask.m_luaExportHelper.__callBase_IsOpeningUI();
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

	// Token: 0x0601B08F RID: 110735 RVA: 0x0081EDA4 File Offset: 0x0081CFA4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_ReturnPrevUITask(IntPtr l)
	{
		int result;
		try
		{
			ArenaSelectUITask arenaSelectUITask = (ArenaSelectUITask)LuaObject.checkSelf(l);
			UITaskBase o = arenaSelectUITask.m_luaExportHelper.__callBase_ReturnPrevUITask();
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

	// Token: 0x0601B090 RID: 110736 RVA: 0x0081EE00 File Offset: 0x0081D000
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_ClearUnusedDynamicResourceCache(IntPtr l)
	{
		int result;
		try
		{
			ArenaSelectUITask arenaSelectUITask = (ArenaSelectUITask)LuaObject.checkSelf(l);
			arenaSelectUITask.m_luaExportHelper.__callBase_ClearUnusedDynamicResourceCache();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601B091 RID: 110737 RVA: 0x0081EE54 File Offset: 0x0081D054
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_OnMemoryWarning(IntPtr l)
	{
		int result;
		try
		{
			ArenaSelectUITask arenaSelectUITask = (ArenaSelectUITask)LuaObject.checkSelf(l);
			arenaSelectUITask.m_luaExportHelper.__callBase_OnMemoryWarning();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601B092 RID: 110738 RVA: 0x0081EEA8 File Offset: 0x0081D0A8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callDele_EventOnShowArena(IntPtr l)
	{
		int result;
		try
		{
			ArenaSelectUITask arenaSelectUITask = (ArenaSelectUITask)LuaObject.checkSelf(l);
			ArenaUIType arg;
			LuaObject.checkEnum<ArenaUIType>(l, 2, out arg);
			bool arg2;
			LuaObject.checkType(l, 3, out arg2);
			UIIntent arg3;
			LuaObject.checkType<UIIntent>(l, 4, out arg3);
			arenaSelectUITask.m_luaExportHelper.__callDele_EventOnShowArena(arg, arg2, arg3);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601B093 RID: 110739 RVA: 0x0081EF20 File Offset: 0x0081D120
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __clearDele_EventOnShowArena(IntPtr l)
	{
		int result;
		try
		{
			ArenaSelectUITask arenaSelectUITask = (ArenaSelectUITask)LuaObject.checkSelf(l);
			ArenaUIType arg;
			LuaObject.checkEnum<ArenaUIType>(l, 2, out arg);
			bool arg2;
			LuaObject.checkType(l, 3, out arg2);
			UIIntent arg3;
			LuaObject.checkType<UIIntent>(l, 4, out arg3);
			arenaSelectUITask.m_luaExportHelper.__clearDele_EventOnShowArena(arg, arg2, arg3);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601B094 RID: 110740 RVA: 0x0081EF98 File Offset: 0x0081D198
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_EventOnShowArena(IntPtr l)
	{
		int result;
		try
		{
			ArenaSelectUITask arenaSelectUITask = (ArenaSelectUITask)LuaObject.checkSelf(l);
			Action<ArenaUIType, bool, UIIntent> value;
			int num = LuaObject.checkDelegate<Action<ArenaUIType, bool, UIIntent>>(l, 2, out value);
			if (num != 0)
			{
				if (num == 1)
				{
					arenaSelectUITask.EventOnShowArena += value;
				}
				else if (num == 2)
				{
					arenaSelectUITask.EventOnShowArena -= value;
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

	// Token: 0x0601B095 RID: 110741 RVA: 0x0081F018 File Offset: 0x0081D218
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_layerDescArray(IntPtr l)
	{
		int result;
		try
		{
			ArenaSelectUITask arenaSelectUITask = (ArenaSelectUITask)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, arenaSelectUITask.m_luaExportHelper.m_layerDescArray);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601B096 RID: 110742 RVA: 0x0081F070 File Offset: 0x0081D270
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_layerDescArray(IntPtr l)
	{
		int result;
		try
		{
			ArenaSelectUITask arenaSelectUITask = (ArenaSelectUITask)LuaObject.checkSelf(l);
			UITaskBase.LayerDesc[] layerDescArray;
			LuaObject.checkArray<UITaskBase.LayerDesc>(l, 2, out layerDescArray);
			arenaSelectUITask.m_luaExportHelper.m_layerDescArray = layerDescArray;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601B097 RID: 110743 RVA: 0x0081F0CC File Offset: 0x0081D2CC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_uiCtrlDescArray(IntPtr l)
	{
		int result;
		try
		{
			ArenaSelectUITask arenaSelectUITask = (ArenaSelectUITask)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, arenaSelectUITask.m_luaExportHelper.m_uiCtrlDescArray);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601B098 RID: 110744 RVA: 0x0081F124 File Offset: 0x0081D324
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_uiCtrlDescArray(IntPtr l)
	{
		int result;
		try
		{
			ArenaSelectUITask arenaSelectUITask = (ArenaSelectUITask)LuaObject.checkSelf(l);
			UITaskBase.UIControllerDesc[] uiCtrlDescArray;
			LuaObject.checkArray<UITaskBase.UIControllerDesc>(l, 2, out uiCtrlDescArray);
			arenaSelectUITask.m_luaExportHelper.m_uiCtrlDescArray = uiCtrlDescArray;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601B099 RID: 110745 RVA: 0x0081F180 File Offset: 0x0081D380
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_arenaSelectUIController(IntPtr l)
	{
		int result;
		try
		{
			ArenaSelectUITask arenaSelectUITask = (ArenaSelectUITask)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, arenaSelectUITask.m_luaExportHelper.m_arenaSelectUIController);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601B09A RID: 110746 RVA: 0x0081F1D8 File Offset: 0x0081D3D8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_arenaSelectUIController(IntPtr l)
	{
		int result;
		try
		{
			ArenaSelectUITask arenaSelectUITask = (ArenaSelectUITask)LuaObject.checkSelf(l);
			ArenaSelectUIController arenaSelectUIController;
			LuaObject.checkType<ArenaSelectUIController>(l, 2, out arenaSelectUIController);
			arenaSelectUITask.m_luaExportHelper.m_arenaSelectUIController = arenaSelectUIController;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601B09B RID: 110747 RVA: 0x0081F234 File Offset: 0x0081D434
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_isBattleReport(IntPtr l)
	{
		int result;
		try
		{
			ArenaSelectUITask arenaSelectUITask = (ArenaSelectUITask)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, arenaSelectUITask.m_luaExportHelper.m_isBattleReport);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601B09C RID: 110748 RVA: 0x0081F28C File Offset: 0x0081D48C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_isBattleReport(IntPtr l)
	{
		int result;
		try
		{
			ArenaSelectUITask arenaSelectUITask = (ArenaSelectUITask)LuaObject.checkSelf(l);
			bool isBattleReport;
			LuaObject.checkType(l, 2, out isBattleReport);
			arenaSelectUITask.m_luaExportHelper.m_isBattleReport = isBattleReport;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601B09D RID: 110749 RVA: 0x0081F2E8 File Offset: 0x0081D4E8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_LayerDescArray(IntPtr l)
	{
		int result;
		try
		{
			ArenaSelectUITask arenaSelectUITask = (ArenaSelectUITask)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, arenaSelectUITask.m_luaExportHelper.LayerDescArray);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601B09E RID: 110750 RVA: 0x0081F340 File Offset: 0x0081D540
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_UICtrlDescArray(IntPtr l)
	{
		int result;
		try
		{
			ArenaSelectUITask arenaSelectUITask = (ArenaSelectUITask)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, arenaSelectUITask.m_luaExportHelper.UICtrlDescArray);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601B09F RID: 110751 RVA: 0x0081F398 File Offset: 0x0081D598
	[Preserve]
	public static void reg(IntPtr l)
	{
		LuaObject.getTypeTable(l, "BlackJack.ProjectL.UI.ArenaSelectUITask");
		if (Lua_BlackJack_ProjectL_UI_ArenaSelectUITask.<>f__mg$cache0 == null)
		{
			Lua_BlackJack_ProjectL_UI_ArenaSelectUITask.<>f__mg$cache0 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ArenaSelectUITask.OnResume);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_ArenaSelectUITask.<>f__mg$cache0);
		if (Lua_BlackJack_ProjectL_UI_ArenaSelectUITask.<>f__mg$cache1 == null)
		{
			Lua_BlackJack_ProjectL_UI_ArenaSelectUITask.<>f__mg$cache1 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ArenaSelectUITask.InitAllUIControllers);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_ArenaSelectUITask.<>f__mg$cache1);
		if (Lua_BlackJack_ProjectL_UI_ArenaSelectUITask.<>f__mg$cache2 == null)
		{
			Lua_BlackJack_ProjectL_UI_ArenaSelectUITask.<>f__mg$cache2 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ArenaSelectUITask.ClearAllContextAndRes);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_ArenaSelectUITask.<>f__mg$cache2);
		if (Lua_BlackJack_ProjectL_UI_ArenaSelectUITask.<>f__mg$cache3 == null)
		{
			Lua_BlackJack_ProjectL_UI_ArenaSelectUITask.<>f__mg$cache3 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ArenaSelectUITask.InitArenaSelectUIController);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_ArenaSelectUITask.<>f__mg$cache3);
		if (Lua_BlackJack_ProjectL_UI_ArenaSelectUITask.<>f__mg$cache4 == null)
		{
			Lua_BlackJack_ProjectL_UI_ArenaSelectUITask.<>f__mg$cache4 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ArenaSelectUITask.UninitArenaSelectUIController);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_ArenaSelectUITask.<>f__mg$cache4);
		if (Lua_BlackJack_ProjectL_UI_ArenaSelectUITask.<>f__mg$cache5 == null)
		{
			Lua_BlackJack_ProjectL_UI_ArenaSelectUITask.<>f__mg$cache5 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ArenaSelectUITask.UpdateView);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_ArenaSelectUITask.<>f__mg$cache5);
		if (Lua_BlackJack_ProjectL_UI_ArenaSelectUITask.<>f__mg$cache6 == null)
		{
			Lua_BlackJack_ProjectL_UI_ArenaSelectUITask.<>f__mg$cache6 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ArenaSelectUITask.ArenaSelectUIController_OnShowOfflineArena);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_ArenaSelectUITask.<>f__mg$cache6);
		if (Lua_BlackJack_ProjectL_UI_ArenaSelectUITask.<>f__mg$cache7 == null)
		{
			Lua_BlackJack_ProjectL_UI_ArenaSelectUITask.<>f__mg$cache7 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ArenaSelectUITask.ArenaSelectUIController_OnShowOnlineArena);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_ArenaSelectUITask.<>f__mg$cache7);
		if (Lua_BlackJack_ProjectL_UI_ArenaSelectUITask.<>f__mg$cache8 == null)
		{
			Lua_BlackJack_ProjectL_UI_ArenaSelectUITask.<>f__mg$cache8 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ArenaSelectUITask.ArenaSelectUIController_OnClose);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_ArenaSelectUITask.<>f__mg$cache8);
		if (Lua_BlackJack_ProjectL_UI_ArenaSelectUITask.<>f__mg$cache9 == null)
		{
			Lua_BlackJack_ProjectL_UI_ArenaSelectUITask.<>f__mg$cache9 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ArenaSelectUITask.__callBase_OnStart);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_ArenaSelectUITask.<>f__mg$cache9);
		if (Lua_BlackJack_ProjectL_UI_ArenaSelectUITask.<>f__mg$cacheA == null)
		{
			Lua_BlackJack_ProjectL_UI_ArenaSelectUITask.<>f__mg$cacheA = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ArenaSelectUITask.__callBase_OnStop);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_ArenaSelectUITask.<>f__mg$cacheA);
		if (Lua_BlackJack_ProjectL_UI_ArenaSelectUITask.<>f__mg$cacheB == null)
		{
			Lua_BlackJack_ProjectL_UI_ArenaSelectUITask.<>f__mg$cacheB = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ArenaSelectUITask.__callBase_OnPause);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_ArenaSelectUITask.<>f__mg$cacheB);
		if (Lua_BlackJack_ProjectL_UI_ArenaSelectUITask.<>f__mg$cacheC == null)
		{
			Lua_BlackJack_ProjectL_UI_ArenaSelectUITask.<>f__mg$cacheC = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ArenaSelectUITask.__callBase_OnResume);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_ArenaSelectUITask.<>f__mg$cacheC);
		if (Lua_BlackJack_ProjectL_UI_ArenaSelectUITask.<>f__mg$cacheD == null)
		{
			Lua_BlackJack_ProjectL_UI_ArenaSelectUITask.<>f__mg$cacheD = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ArenaSelectUITask.__callBase_OnNewIntent);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_ArenaSelectUITask.<>f__mg$cacheD);
		if (Lua_BlackJack_ProjectL_UI_ArenaSelectUITask.<>f__mg$cacheE == null)
		{
			Lua_BlackJack_ProjectL_UI_ArenaSelectUITask.<>f__mg$cacheE = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ArenaSelectUITask.__callBase_EnableUIInput);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_ArenaSelectUITask.<>f__mg$cacheE);
		if (Lua_BlackJack_ProjectL_UI_ArenaSelectUITask.<>f__mg$cacheF == null)
		{
			Lua_BlackJack_ProjectL_UI_ArenaSelectUITask.<>f__mg$cacheF = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ArenaSelectUITask.__callBase_IsNeedLoadDynamicRes);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_ArenaSelectUITask.<>f__mg$cacheF);
		if (Lua_BlackJack_ProjectL_UI_ArenaSelectUITask.<>f__mg$cache10 == null)
		{
			Lua_BlackJack_ProjectL_UI_ArenaSelectUITask.<>f__mg$cache10 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ArenaSelectUITask.__callBase_CollectAllDynamicResForLoad);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_ArenaSelectUITask.<>f__mg$cache10);
		if (Lua_BlackJack_ProjectL_UI_ArenaSelectUITask.<>f__mg$cache11 == null)
		{
			Lua_BlackJack_ProjectL_UI_ArenaSelectUITask.<>f__mg$cache11 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ArenaSelectUITask.__callBase_RegisterPlayerContextEvents);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_ArenaSelectUITask.<>f__mg$cache11);
		if (Lua_BlackJack_ProjectL_UI_ArenaSelectUITask.<>f__mg$cache12 == null)
		{
			Lua_BlackJack_ProjectL_UI_ArenaSelectUITask.<>f__mg$cache12 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ArenaSelectUITask.__callBase_UnregisterPlayerContextEvents);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_ArenaSelectUITask.<>f__mg$cache12);
		if (Lua_BlackJack_ProjectL_UI_ArenaSelectUITask.<>f__mg$cache13 == null)
		{
			Lua_BlackJack_ProjectL_UI_ArenaSelectUITask.<>f__mg$cache13 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ArenaSelectUITask.__callBase_PostUpdateView);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_ArenaSelectUITask.<>f__mg$cache13);
		if (Lua_BlackJack_ProjectL_UI_ArenaSelectUITask.<>f__mg$cache14 == null)
		{
			Lua_BlackJack_ProjectL_UI_ArenaSelectUITask.<>f__mg$cache14 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ArenaSelectUITask.__callBase_CollectPreloadResourceList);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_ArenaSelectUITask.<>f__mg$cache14);
		if (Lua_BlackJack_ProjectL_UI_ArenaSelectUITask.<>f__mg$cache15 == null)
		{
			Lua_BlackJack_ProjectL_UI_ArenaSelectUITask.<>f__mg$cache15 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ArenaSelectUITask.__callBase_ClearAssetList);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_ArenaSelectUITask.<>f__mg$cache15);
		if (Lua_BlackJack_ProjectL_UI_ArenaSelectUITask.<>f__mg$cache16 == null)
		{
			Lua_BlackJack_ProjectL_UI_ArenaSelectUITask.<>f__mg$cache16 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ArenaSelectUITask.__callBase_CollectAsset);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_ArenaSelectUITask.<>f__mg$cache16);
		if (Lua_BlackJack_ProjectL_UI_ArenaSelectUITask.<>f__mg$cache17 == null)
		{
			Lua_BlackJack_ProjectL_UI_ArenaSelectUITask.<>f__mg$cache17 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ArenaSelectUITask.__callBase_CollectSpriteAsset);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_ArenaSelectUITask.<>f__mg$cache17);
		if (Lua_BlackJack_ProjectL_UI_ArenaSelectUITask.<>f__mg$cache18 == null)
		{
			Lua_BlackJack_ProjectL_UI_ArenaSelectUITask.<>f__mg$cache18 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ArenaSelectUITask.__callBase_CollectFxAsset);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_ArenaSelectUITask.<>f__mg$cache18);
		if (Lua_BlackJack_ProjectL_UI_ArenaSelectUITask.<>f__mg$cache19 == null)
		{
			Lua_BlackJack_ProjectL_UI_ArenaSelectUITask.<>f__mg$cache19 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ArenaSelectUITask.__callBase_StartLoadCustomAssets);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_ArenaSelectUITask.<>f__mg$cache19);
		if (Lua_BlackJack_ProjectL_UI_ArenaSelectUITask.<>f__mg$cache1A == null)
		{
			Lua_BlackJack_ProjectL_UI_ArenaSelectUITask.<>f__mg$cache1A = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ArenaSelectUITask.__callBase_IsLoadingCustomAssets);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_ArenaSelectUITask.<>f__mg$cache1A);
		if (Lua_BlackJack_ProjectL_UI_ArenaSelectUITask.<>f__mg$cache1B == null)
		{
			Lua_BlackJack_ProjectL_UI_ArenaSelectUITask.<>f__mg$cache1B = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ArenaSelectUITask.__callBase_IsPipeLineRunning);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_ArenaSelectUITask.<>f__mg$cache1B);
		if (Lua_BlackJack_ProjectL_UI_ArenaSelectUITask.<>f__mg$cache1C == null)
		{
			Lua_BlackJack_ProjectL_UI_ArenaSelectUITask.<>f__mg$cache1C = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ArenaSelectUITask.__callBase_IsOpeningUI);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_ArenaSelectUITask.<>f__mg$cache1C);
		if (Lua_BlackJack_ProjectL_UI_ArenaSelectUITask.<>f__mg$cache1D == null)
		{
			Lua_BlackJack_ProjectL_UI_ArenaSelectUITask.<>f__mg$cache1D = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ArenaSelectUITask.__callBase_ReturnPrevUITask);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_ArenaSelectUITask.<>f__mg$cache1D);
		if (Lua_BlackJack_ProjectL_UI_ArenaSelectUITask.<>f__mg$cache1E == null)
		{
			Lua_BlackJack_ProjectL_UI_ArenaSelectUITask.<>f__mg$cache1E = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ArenaSelectUITask.__callBase_ClearUnusedDynamicResourceCache);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_ArenaSelectUITask.<>f__mg$cache1E);
		if (Lua_BlackJack_ProjectL_UI_ArenaSelectUITask.<>f__mg$cache1F == null)
		{
			Lua_BlackJack_ProjectL_UI_ArenaSelectUITask.<>f__mg$cache1F = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ArenaSelectUITask.__callBase_OnMemoryWarning);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_ArenaSelectUITask.<>f__mg$cache1F);
		if (Lua_BlackJack_ProjectL_UI_ArenaSelectUITask.<>f__mg$cache20 == null)
		{
			Lua_BlackJack_ProjectL_UI_ArenaSelectUITask.<>f__mg$cache20 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ArenaSelectUITask.__callDele_EventOnShowArena);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_ArenaSelectUITask.<>f__mg$cache20);
		if (Lua_BlackJack_ProjectL_UI_ArenaSelectUITask.<>f__mg$cache21 == null)
		{
			Lua_BlackJack_ProjectL_UI_ArenaSelectUITask.<>f__mg$cache21 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ArenaSelectUITask.__clearDele_EventOnShowArena);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_ArenaSelectUITask.<>f__mg$cache21);
		string name = "EventOnShowArena";
		LuaCSFunction get = null;
		if (Lua_BlackJack_ProjectL_UI_ArenaSelectUITask.<>f__mg$cache22 == null)
		{
			Lua_BlackJack_ProjectL_UI_ArenaSelectUITask.<>f__mg$cache22 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ArenaSelectUITask.set_EventOnShowArena);
		}
		LuaObject.addMember(l, name, get, Lua_BlackJack_ProjectL_UI_ArenaSelectUITask.<>f__mg$cache22, true);
		string name2 = "m_layerDescArray";
		if (Lua_BlackJack_ProjectL_UI_ArenaSelectUITask.<>f__mg$cache23 == null)
		{
			Lua_BlackJack_ProjectL_UI_ArenaSelectUITask.<>f__mg$cache23 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ArenaSelectUITask.get_m_layerDescArray);
		}
		LuaCSFunction get2 = Lua_BlackJack_ProjectL_UI_ArenaSelectUITask.<>f__mg$cache23;
		if (Lua_BlackJack_ProjectL_UI_ArenaSelectUITask.<>f__mg$cache24 == null)
		{
			Lua_BlackJack_ProjectL_UI_ArenaSelectUITask.<>f__mg$cache24 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ArenaSelectUITask.set_m_layerDescArray);
		}
		LuaObject.addMember(l, name2, get2, Lua_BlackJack_ProjectL_UI_ArenaSelectUITask.<>f__mg$cache24, true);
		string name3 = "m_uiCtrlDescArray";
		if (Lua_BlackJack_ProjectL_UI_ArenaSelectUITask.<>f__mg$cache25 == null)
		{
			Lua_BlackJack_ProjectL_UI_ArenaSelectUITask.<>f__mg$cache25 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ArenaSelectUITask.get_m_uiCtrlDescArray);
		}
		LuaCSFunction get3 = Lua_BlackJack_ProjectL_UI_ArenaSelectUITask.<>f__mg$cache25;
		if (Lua_BlackJack_ProjectL_UI_ArenaSelectUITask.<>f__mg$cache26 == null)
		{
			Lua_BlackJack_ProjectL_UI_ArenaSelectUITask.<>f__mg$cache26 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ArenaSelectUITask.set_m_uiCtrlDescArray);
		}
		LuaObject.addMember(l, name3, get3, Lua_BlackJack_ProjectL_UI_ArenaSelectUITask.<>f__mg$cache26, true);
		string name4 = "m_arenaSelectUIController";
		if (Lua_BlackJack_ProjectL_UI_ArenaSelectUITask.<>f__mg$cache27 == null)
		{
			Lua_BlackJack_ProjectL_UI_ArenaSelectUITask.<>f__mg$cache27 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ArenaSelectUITask.get_m_arenaSelectUIController);
		}
		LuaCSFunction get4 = Lua_BlackJack_ProjectL_UI_ArenaSelectUITask.<>f__mg$cache27;
		if (Lua_BlackJack_ProjectL_UI_ArenaSelectUITask.<>f__mg$cache28 == null)
		{
			Lua_BlackJack_ProjectL_UI_ArenaSelectUITask.<>f__mg$cache28 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ArenaSelectUITask.set_m_arenaSelectUIController);
		}
		LuaObject.addMember(l, name4, get4, Lua_BlackJack_ProjectL_UI_ArenaSelectUITask.<>f__mg$cache28, true);
		string name5 = "m_isBattleReport";
		if (Lua_BlackJack_ProjectL_UI_ArenaSelectUITask.<>f__mg$cache29 == null)
		{
			Lua_BlackJack_ProjectL_UI_ArenaSelectUITask.<>f__mg$cache29 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ArenaSelectUITask.get_m_isBattleReport);
		}
		LuaCSFunction get5 = Lua_BlackJack_ProjectL_UI_ArenaSelectUITask.<>f__mg$cache29;
		if (Lua_BlackJack_ProjectL_UI_ArenaSelectUITask.<>f__mg$cache2A == null)
		{
			Lua_BlackJack_ProjectL_UI_ArenaSelectUITask.<>f__mg$cache2A = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ArenaSelectUITask.set_m_isBattleReport);
		}
		LuaObject.addMember(l, name5, get5, Lua_BlackJack_ProjectL_UI_ArenaSelectUITask.<>f__mg$cache2A, true);
		string name6 = "LayerDescArray";
		if (Lua_BlackJack_ProjectL_UI_ArenaSelectUITask.<>f__mg$cache2B == null)
		{
			Lua_BlackJack_ProjectL_UI_ArenaSelectUITask.<>f__mg$cache2B = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ArenaSelectUITask.get_LayerDescArray);
		}
		LuaObject.addMember(l, name6, Lua_BlackJack_ProjectL_UI_ArenaSelectUITask.<>f__mg$cache2B, null, true);
		string name7 = "UICtrlDescArray";
		if (Lua_BlackJack_ProjectL_UI_ArenaSelectUITask.<>f__mg$cache2C == null)
		{
			Lua_BlackJack_ProjectL_UI_ArenaSelectUITask.<>f__mg$cache2C = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ArenaSelectUITask.get_UICtrlDescArray);
		}
		LuaObject.addMember(l, name7, Lua_BlackJack_ProjectL_UI_ArenaSelectUITask.<>f__mg$cache2C, null, true);
		if (Lua_BlackJack_ProjectL_UI_ArenaSelectUITask.<>f__mg$cache2D == null)
		{
			Lua_BlackJack_ProjectL_UI_ArenaSelectUITask.<>f__mg$cache2D = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ArenaSelectUITask.constructor);
		}
		LuaObject.createTypeMetatable(l, Lua_BlackJack_ProjectL_UI_ArenaSelectUITask.<>f__mg$cache2D, typeof(ArenaSelectUITask), typeof(UITask));
	}

	// Token: 0x0401134F RID: 70479
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache0;

	// Token: 0x04011350 RID: 70480
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1;

	// Token: 0x04011351 RID: 70481
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2;

	// Token: 0x04011352 RID: 70482
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3;

	// Token: 0x04011353 RID: 70483
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache4;

	// Token: 0x04011354 RID: 70484
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache5;

	// Token: 0x04011355 RID: 70485
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache6;

	// Token: 0x04011356 RID: 70486
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache7;

	// Token: 0x04011357 RID: 70487
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache8;

	// Token: 0x04011358 RID: 70488
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache9;

	// Token: 0x04011359 RID: 70489
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheA;

	// Token: 0x0401135A RID: 70490
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheB;

	// Token: 0x0401135B RID: 70491
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheC;

	// Token: 0x0401135C RID: 70492
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheD;

	// Token: 0x0401135D RID: 70493
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheE;

	// Token: 0x0401135E RID: 70494
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheF;

	// Token: 0x0401135F RID: 70495
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache10;

	// Token: 0x04011360 RID: 70496
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache11;

	// Token: 0x04011361 RID: 70497
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache12;

	// Token: 0x04011362 RID: 70498
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache13;

	// Token: 0x04011363 RID: 70499
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache14;

	// Token: 0x04011364 RID: 70500
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache15;

	// Token: 0x04011365 RID: 70501
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache16;

	// Token: 0x04011366 RID: 70502
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache17;

	// Token: 0x04011367 RID: 70503
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache18;

	// Token: 0x04011368 RID: 70504
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache19;

	// Token: 0x04011369 RID: 70505
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1A;

	// Token: 0x0401136A RID: 70506
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1B;

	// Token: 0x0401136B RID: 70507
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1C;

	// Token: 0x0401136C RID: 70508
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1D;

	// Token: 0x0401136D RID: 70509
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1E;

	// Token: 0x0401136E RID: 70510
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1F;

	// Token: 0x0401136F RID: 70511
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache20;

	// Token: 0x04011370 RID: 70512
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache21;

	// Token: 0x04011371 RID: 70513
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache22;

	// Token: 0x04011372 RID: 70514
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache23;

	// Token: 0x04011373 RID: 70515
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache24;

	// Token: 0x04011374 RID: 70516
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache25;

	// Token: 0x04011375 RID: 70517
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache26;

	// Token: 0x04011376 RID: 70518
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache27;

	// Token: 0x04011377 RID: 70519
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache28;

	// Token: 0x04011378 RID: 70520
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache29;

	// Token: 0x04011379 RID: 70521
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2A;

	// Token: 0x0401137A RID: 70522
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2B;

	// Token: 0x0401137B RID: 70523
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2C;

	// Token: 0x0401137C RID: 70524
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2D;
}
