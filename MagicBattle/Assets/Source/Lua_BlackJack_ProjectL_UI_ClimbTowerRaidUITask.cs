using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using BlackJack.BJFramework.Runtime.UI;
using BlackJack.ProjectL.PlayerContext;
using BlackJack.ProjectL.UI;
using SLua;
using UnityEngine.Scripting;

// Token: 0x020013FB RID: 5115
[Preserve]
public class Lua_BlackJack_ProjectL_UI_ClimbTowerRaidUITask : LuaObject
{
	// Token: 0x0601CBF5 RID: 117749 RVA: 0x008F8904 File Offset: 0x008F6B04
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int constructor(IntPtr l)
	{
		int result;
		try
		{
			string name;
			LuaObject.checkType(l, 2, out name);
			ClimbTowerRaidUITask o = new ClimbTowerRaidUITask(name);
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

	// Token: 0x0601CBF6 RID: 117750 RVA: 0x008F8958 File Offset: 0x008F6B58
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int OnStart(IntPtr l)
	{
		int result;
		try
		{
			ClimbTowerRaidUITask climbTowerRaidUITask = (ClimbTowerRaidUITask)LuaObject.checkSelf(l);
			UIIntent intent;
			LuaObject.checkType<UIIntent>(l, 2, out intent);
			bool b = climbTowerRaidUITask.m_luaExportHelper.OnStart(intent);
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

	// Token: 0x0601CBF7 RID: 117751 RVA: 0x008F89C0 File Offset: 0x008F6BC0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int OnResume(IntPtr l)
	{
		int result;
		try
		{
			ClimbTowerRaidUITask climbTowerRaidUITask = (ClimbTowerRaidUITask)LuaObject.checkSelf(l);
			UIIntent intent;
			LuaObject.checkType<UIIntent>(l, 2, out intent);
			bool b = climbTowerRaidUITask.m_luaExportHelper.OnResume(intent);
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

	// Token: 0x0601CBF8 RID: 117752 RVA: 0x008F8A28 File Offset: 0x008F6C28
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int InitDataFromUIIntent(IntPtr l)
	{
		int result;
		try
		{
			ClimbTowerRaidUITask climbTowerRaidUITask = (ClimbTowerRaidUITask)LuaObject.checkSelf(l);
			UIIntent intent;
			LuaObject.checkType<UIIntent>(l, 2, out intent);
			climbTowerRaidUITask.m_luaExportHelper.InitDataFromUIIntent(intent);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601CBF9 RID: 117753 RVA: 0x008F8A84 File Offset: 0x008F6C84
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int InitAllUIControllers(IntPtr l)
	{
		int result;
		try
		{
			ClimbTowerRaidUITask climbTowerRaidUITask = (ClimbTowerRaidUITask)LuaObject.checkSelf(l);
			climbTowerRaidUITask.m_luaExportHelper.InitAllUIControllers();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601CBFA RID: 117754 RVA: 0x008F8AD8 File Offset: 0x008F6CD8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int ClearAllContextAndRes(IntPtr l)
	{
		int result;
		try
		{
			ClimbTowerRaidUITask climbTowerRaidUITask = (ClimbTowerRaidUITask)LuaObject.checkSelf(l);
			climbTowerRaidUITask.m_luaExportHelper.ClearAllContextAndRes();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601CBFB RID: 117755 RVA: 0x008F8B2C File Offset: 0x008F6D2C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int UpdateView(IntPtr l)
	{
		int result;
		try
		{
			ClimbTowerRaidUITask climbTowerRaidUITask = (ClimbTowerRaidUITask)LuaObject.checkSelf(l);
			climbTowerRaidUITask.m_luaExportHelper.UpdateView();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601CBFC RID: 117756 RVA: 0x008F8B80 File Offset: 0x008F6D80
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int ClimbTowerRaidInfoUIController_OnClose(IntPtr l)
	{
		int result;
		try
		{
			ClimbTowerRaidUITask climbTowerRaidUITask = (ClimbTowerRaidUITask)LuaObject.checkSelf(l);
			climbTowerRaidUITask.m_luaExportHelper.ClimbTowerRaidInfoUIController_OnClose();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601CBFD RID: 117757 RVA: 0x008F8BD4 File Offset: 0x008F6DD4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_OnStart(IntPtr l)
	{
		int result;
		try
		{
			ClimbTowerRaidUITask climbTowerRaidUITask = (ClimbTowerRaidUITask)LuaObject.checkSelf(l);
			UIIntent intent;
			LuaObject.checkType<UIIntent>(l, 2, out intent);
			bool b = climbTowerRaidUITask.m_luaExportHelper.__callBase_OnStart(intent);
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

	// Token: 0x0601CBFE RID: 117758 RVA: 0x008F8C3C File Offset: 0x008F6E3C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_OnStop(IntPtr l)
	{
		int result;
		try
		{
			ClimbTowerRaidUITask climbTowerRaidUITask = (ClimbTowerRaidUITask)LuaObject.checkSelf(l);
			climbTowerRaidUITask.m_luaExportHelper.__callBase_OnStop();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601CBFF RID: 117759 RVA: 0x008F8C90 File Offset: 0x008F6E90
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_OnPause(IntPtr l)
	{
		int result;
		try
		{
			ClimbTowerRaidUITask climbTowerRaidUITask = (ClimbTowerRaidUITask)LuaObject.checkSelf(l);
			climbTowerRaidUITask.m_luaExportHelper.__callBase_OnPause();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601CC00 RID: 117760 RVA: 0x008F8CE4 File Offset: 0x008F6EE4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_OnResume(IntPtr l)
	{
		int result;
		try
		{
			ClimbTowerRaidUITask climbTowerRaidUITask = (ClimbTowerRaidUITask)LuaObject.checkSelf(l);
			UIIntent intent;
			LuaObject.checkType<UIIntent>(l, 2, out intent);
			bool b = climbTowerRaidUITask.m_luaExportHelper.__callBase_OnResume(intent);
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

	// Token: 0x0601CC01 RID: 117761 RVA: 0x008F8D4C File Offset: 0x008F6F4C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_OnNewIntent(IntPtr l)
	{
		int result;
		try
		{
			ClimbTowerRaidUITask climbTowerRaidUITask = (ClimbTowerRaidUITask)LuaObject.checkSelf(l);
			UIIntent intent;
			LuaObject.checkType<UIIntent>(l, 2, out intent);
			bool b = climbTowerRaidUITask.m_luaExportHelper.__callBase_OnNewIntent(intent);
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

	// Token: 0x0601CC02 RID: 117762 RVA: 0x008F8DB4 File Offset: 0x008F6FB4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_EnableUIInput(IntPtr l)
	{
		int result;
		try
		{
			ClimbTowerRaidUITask climbTowerRaidUITask = (ClimbTowerRaidUITask)LuaObject.checkSelf(l);
			bool isEnable;
			LuaObject.checkType(l, 2, out isEnable);
			bool? isGlobalEnable;
			LuaObject.checkNullable<bool>(l, 3, out isGlobalEnable);
			climbTowerRaidUITask.m_luaExportHelper.__callBase_EnableUIInput(isEnable, isGlobalEnable);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601CC03 RID: 117763 RVA: 0x008F8E20 File Offset: 0x008F7020
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_IsNeedLoadDynamicRes(IntPtr l)
	{
		int result;
		try
		{
			ClimbTowerRaidUITask climbTowerRaidUITask = (ClimbTowerRaidUITask)LuaObject.checkSelf(l);
			bool b = climbTowerRaidUITask.m_luaExportHelper.__callBase_IsNeedLoadDynamicRes();
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

	// Token: 0x0601CC04 RID: 117764 RVA: 0x008F8E7C File Offset: 0x008F707C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_CollectAllDynamicResForLoad(IntPtr l)
	{
		int result;
		try
		{
			ClimbTowerRaidUITask climbTowerRaidUITask = (ClimbTowerRaidUITask)LuaObject.checkSelf(l);
			List<string> o = climbTowerRaidUITask.m_luaExportHelper.__callBase_CollectAllDynamicResForLoad();
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

	// Token: 0x0601CC05 RID: 117765 RVA: 0x008F8ED8 File Offset: 0x008F70D8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_RegisterPlayerContextEvents(IntPtr l)
	{
		int result;
		try
		{
			ClimbTowerRaidUITask climbTowerRaidUITask = (ClimbTowerRaidUITask)LuaObject.checkSelf(l);
			climbTowerRaidUITask.m_luaExportHelper.__callBase_RegisterPlayerContextEvents();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601CC06 RID: 117766 RVA: 0x008F8F2C File Offset: 0x008F712C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_UnregisterPlayerContextEvents(IntPtr l)
	{
		int result;
		try
		{
			ClimbTowerRaidUITask climbTowerRaidUITask = (ClimbTowerRaidUITask)LuaObject.checkSelf(l);
			climbTowerRaidUITask.m_luaExportHelper.__callBase_UnregisterPlayerContextEvents();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601CC07 RID: 117767 RVA: 0x008F8F80 File Offset: 0x008F7180
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_PostUpdateView(IntPtr l)
	{
		int result;
		try
		{
			ClimbTowerRaidUITask climbTowerRaidUITask = (ClimbTowerRaidUITask)LuaObject.checkSelf(l);
			climbTowerRaidUITask.m_luaExportHelper.__callBase_PostUpdateView();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601CC08 RID: 117768 RVA: 0x008F8FD4 File Offset: 0x008F71D4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_CollectPreloadResourceList(IntPtr l)
	{
		int result;
		try
		{
			ClimbTowerRaidUITask climbTowerRaidUITask = (ClimbTowerRaidUITask)LuaObject.checkSelf(l);
			climbTowerRaidUITask.m_luaExportHelper.__callBase_CollectPreloadResourceList();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601CC09 RID: 117769 RVA: 0x008F9028 File Offset: 0x008F7228
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_ClearAssetList(IntPtr l)
	{
		int result;
		try
		{
			ClimbTowerRaidUITask climbTowerRaidUITask = (ClimbTowerRaidUITask)LuaObject.checkSelf(l);
			climbTowerRaidUITask.m_luaExportHelper.__callBase_ClearAssetList();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601CC0A RID: 117770 RVA: 0x008F907C File Offset: 0x008F727C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_CollectAsset(IntPtr l)
	{
		int result;
		try
		{
			ClimbTowerRaidUITask climbTowerRaidUITask = (ClimbTowerRaidUITask)LuaObject.checkSelf(l);
			string assetName;
			LuaObject.checkType(l, 2, out assetName);
			climbTowerRaidUITask.m_luaExportHelper.__callBase_CollectAsset(assetName);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601CC0B RID: 117771 RVA: 0x008F90D8 File Offset: 0x008F72D8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_CollectSpriteAsset(IntPtr l)
	{
		int result;
		try
		{
			ClimbTowerRaidUITask climbTowerRaidUITask = (ClimbTowerRaidUITask)LuaObject.checkSelf(l);
			string assetName;
			LuaObject.checkType(l, 2, out assetName);
			climbTowerRaidUITask.m_luaExportHelper.__callBase_CollectSpriteAsset(assetName);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601CC0C RID: 117772 RVA: 0x008F9134 File Offset: 0x008F7334
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_CollectFxAsset(IntPtr l)
	{
		int result;
		try
		{
			ClimbTowerRaidUITask climbTowerRaidUITask = (ClimbTowerRaidUITask)LuaObject.checkSelf(l);
			string assetName;
			LuaObject.checkType(l, 2, out assetName);
			climbTowerRaidUITask.m_luaExportHelper.__callBase_CollectFxAsset(assetName);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601CC0D RID: 117773 RVA: 0x008F9190 File Offset: 0x008F7390
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_StartLoadCustomAssets(IntPtr l)
	{
		int result;
		try
		{
			ClimbTowerRaidUITask climbTowerRaidUITask = (ClimbTowerRaidUITask)LuaObject.checkSelf(l);
			Action onLoadCompleted;
			LuaObject.checkDelegate<Action>(l, 2, out onLoadCompleted);
			climbTowerRaidUITask.m_luaExportHelper.__callBase_StartLoadCustomAssets(onLoadCompleted);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601CC0E RID: 117774 RVA: 0x008F91EC File Offset: 0x008F73EC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_IsLoadingCustomAssets(IntPtr l)
	{
		int result;
		try
		{
			ClimbTowerRaidUITask climbTowerRaidUITask = (ClimbTowerRaidUITask)LuaObject.checkSelf(l);
			bool b = climbTowerRaidUITask.m_luaExportHelper.__callBase_IsLoadingCustomAssets();
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

	// Token: 0x0601CC0F RID: 117775 RVA: 0x008F9248 File Offset: 0x008F7448
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_IsPipeLineRunning(IntPtr l)
	{
		int result;
		try
		{
			ClimbTowerRaidUITask climbTowerRaidUITask = (ClimbTowerRaidUITask)LuaObject.checkSelf(l);
			bool b = climbTowerRaidUITask.m_luaExportHelper.__callBase_IsPipeLineRunning();
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

	// Token: 0x0601CC10 RID: 117776 RVA: 0x008F92A4 File Offset: 0x008F74A4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_IsOpeningUI(IntPtr l)
	{
		int result;
		try
		{
			ClimbTowerRaidUITask climbTowerRaidUITask = (ClimbTowerRaidUITask)LuaObject.checkSelf(l);
			bool b = climbTowerRaidUITask.m_luaExportHelper.__callBase_IsOpeningUI();
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

	// Token: 0x0601CC11 RID: 117777 RVA: 0x008F9300 File Offset: 0x008F7500
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_ReturnPrevUITask(IntPtr l)
	{
		int result;
		try
		{
			ClimbTowerRaidUITask climbTowerRaidUITask = (ClimbTowerRaidUITask)LuaObject.checkSelf(l);
			UITaskBase o = climbTowerRaidUITask.m_luaExportHelper.__callBase_ReturnPrevUITask();
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

	// Token: 0x0601CC12 RID: 117778 RVA: 0x008F935C File Offset: 0x008F755C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_ClearUnusedDynamicResourceCache(IntPtr l)
	{
		int result;
		try
		{
			ClimbTowerRaidUITask climbTowerRaidUITask = (ClimbTowerRaidUITask)LuaObject.checkSelf(l);
			climbTowerRaidUITask.m_luaExportHelper.__callBase_ClearUnusedDynamicResourceCache();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601CC13 RID: 117779 RVA: 0x008F93B0 File Offset: 0x008F75B0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_OnMemoryWarning(IntPtr l)
	{
		int result;
		try
		{
			ClimbTowerRaidUITask climbTowerRaidUITask = (ClimbTowerRaidUITask)LuaObject.checkSelf(l);
			climbTowerRaidUITask.m_luaExportHelper.__callBase_OnMemoryWarning();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601CC14 RID: 117780 RVA: 0x008F9404 File Offset: 0x008F7604
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callDele_EventOnClose(IntPtr l)
	{
		int result;
		try
		{
			ClimbTowerRaidUITask climbTowerRaidUITask = (ClimbTowerRaidUITask)LuaObject.checkSelf(l);
			climbTowerRaidUITask.m_luaExportHelper.__callDele_EventOnClose();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601CC15 RID: 117781 RVA: 0x008F9458 File Offset: 0x008F7658
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __clearDele_EventOnClose(IntPtr l)
	{
		int result;
		try
		{
			ClimbTowerRaidUITask climbTowerRaidUITask = (ClimbTowerRaidUITask)LuaObject.checkSelf(l);
			climbTowerRaidUITask.m_luaExportHelper.__clearDele_EventOnClose();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601CC16 RID: 117782 RVA: 0x008F94AC File Offset: 0x008F76AC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_EventOnClose(IntPtr l)
	{
		int result;
		try
		{
			ClimbTowerRaidUITask climbTowerRaidUITask = (ClimbTowerRaidUITask)LuaObject.checkSelf(l);
			Action value;
			int num = LuaObject.checkDelegate<Action>(l, 2, out value);
			if (num != 0)
			{
				if (num == 1)
				{
					climbTowerRaidUITask.EventOnClose += value;
				}
				else if (num == 2)
				{
					climbTowerRaidUITask.EventOnClose -= value;
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

	// Token: 0x0601CC17 RID: 117783 RVA: 0x008F952C File Offset: 0x008F772C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_layerDescArray(IntPtr l)
	{
		int result;
		try
		{
			ClimbTowerRaidUITask climbTowerRaidUITask = (ClimbTowerRaidUITask)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, climbTowerRaidUITask.m_luaExportHelper.m_layerDescArray);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601CC18 RID: 117784 RVA: 0x008F9584 File Offset: 0x008F7784
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_layerDescArray(IntPtr l)
	{
		int result;
		try
		{
			ClimbTowerRaidUITask climbTowerRaidUITask = (ClimbTowerRaidUITask)LuaObject.checkSelf(l);
			UITaskBase.LayerDesc[] layerDescArray;
			LuaObject.checkArray<UITaskBase.LayerDesc>(l, 2, out layerDescArray);
			climbTowerRaidUITask.m_luaExportHelper.m_layerDescArray = layerDescArray;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601CC19 RID: 117785 RVA: 0x008F95E0 File Offset: 0x008F77E0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_uiCtrlDescArray(IntPtr l)
	{
		int result;
		try
		{
			ClimbTowerRaidUITask climbTowerRaidUITask = (ClimbTowerRaidUITask)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, climbTowerRaidUITask.m_luaExportHelper.m_uiCtrlDescArray);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601CC1A RID: 117786 RVA: 0x008F9638 File Offset: 0x008F7838
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_uiCtrlDescArray(IntPtr l)
	{
		int result;
		try
		{
			ClimbTowerRaidUITask climbTowerRaidUITask = (ClimbTowerRaidUITask)LuaObject.checkSelf(l);
			UITaskBase.UIControllerDesc[] uiCtrlDescArray;
			LuaObject.checkArray<UITaskBase.UIControllerDesc>(l, 2, out uiCtrlDescArray);
			climbTowerRaidUITask.m_luaExportHelper.m_uiCtrlDescArray = uiCtrlDescArray;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601CC1B RID: 117787 RVA: 0x008F9694 File Offset: 0x008F7894
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_climbTowerRaidUIController(IntPtr l)
	{
		int result;
		try
		{
			ClimbTowerRaidUITask climbTowerRaidUITask = (ClimbTowerRaidUITask)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, climbTowerRaidUITask.m_luaExportHelper.m_climbTowerRaidUIController);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601CC1C RID: 117788 RVA: 0x008F96EC File Offset: 0x008F78EC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_climbTowerRaidUIController(IntPtr l)
	{
		int result;
		try
		{
			ClimbTowerRaidUITask climbTowerRaidUITask = (ClimbTowerRaidUITask)LuaObject.checkSelf(l);
			ClimbTowerRaidUIController climbTowerRaidUIController;
			LuaObject.checkType<ClimbTowerRaidUIController>(l, 2, out climbTowerRaidUIController);
			climbTowerRaidUITask.m_luaExportHelper.m_climbTowerRaidUIController = climbTowerRaidUIController;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601CC1D RID: 117789 RVA: 0x008F9748 File Offset: 0x008F7948
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_battleReward(IntPtr l)
	{
		int result;
		try
		{
			ClimbTowerRaidUITask climbTowerRaidUITask = (ClimbTowerRaidUITask)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, climbTowerRaidUITask.m_luaExportHelper.m_battleReward);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601CC1E RID: 117790 RVA: 0x008F97A0 File Offset: 0x008F79A0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_battleReward(IntPtr l)
	{
		int result;
		try
		{
			ClimbTowerRaidUITask climbTowerRaidUITask = (ClimbTowerRaidUITask)LuaObject.checkSelf(l);
			BattleReward battleReward;
			LuaObject.checkType<BattleReward>(l, 2, out battleReward);
			climbTowerRaidUITask.m_luaExportHelper.m_battleReward = battleReward;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601CC1F RID: 117791 RVA: 0x008F97FC File Offset: 0x008F79FC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_LayerDescArray(IntPtr l)
	{
		int result;
		try
		{
			ClimbTowerRaidUITask climbTowerRaidUITask = (ClimbTowerRaidUITask)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, climbTowerRaidUITask.m_luaExportHelper.LayerDescArray);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601CC20 RID: 117792 RVA: 0x008F9854 File Offset: 0x008F7A54
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_UICtrlDescArray(IntPtr l)
	{
		int result;
		try
		{
			ClimbTowerRaidUITask climbTowerRaidUITask = (ClimbTowerRaidUITask)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, climbTowerRaidUITask.m_luaExportHelper.UICtrlDescArray);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601CC21 RID: 117793 RVA: 0x008F98AC File Offset: 0x008F7AAC
	[Preserve]
	public static void reg(IntPtr l)
	{
		LuaObject.getTypeTable(l, "BlackJack.ProjectL.UI.ClimbTowerRaidUITask");
		if (Lua_BlackJack_ProjectL_UI_ClimbTowerRaidUITask.<>f__mg$cache0 == null)
		{
			Lua_BlackJack_ProjectL_UI_ClimbTowerRaidUITask.<>f__mg$cache0 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ClimbTowerRaidUITask.OnStart);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_ClimbTowerRaidUITask.<>f__mg$cache0);
		if (Lua_BlackJack_ProjectL_UI_ClimbTowerRaidUITask.<>f__mg$cache1 == null)
		{
			Lua_BlackJack_ProjectL_UI_ClimbTowerRaidUITask.<>f__mg$cache1 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ClimbTowerRaidUITask.OnResume);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_ClimbTowerRaidUITask.<>f__mg$cache1);
		if (Lua_BlackJack_ProjectL_UI_ClimbTowerRaidUITask.<>f__mg$cache2 == null)
		{
			Lua_BlackJack_ProjectL_UI_ClimbTowerRaidUITask.<>f__mg$cache2 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ClimbTowerRaidUITask.InitDataFromUIIntent);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_ClimbTowerRaidUITask.<>f__mg$cache2);
		if (Lua_BlackJack_ProjectL_UI_ClimbTowerRaidUITask.<>f__mg$cache3 == null)
		{
			Lua_BlackJack_ProjectL_UI_ClimbTowerRaidUITask.<>f__mg$cache3 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ClimbTowerRaidUITask.InitAllUIControllers);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_ClimbTowerRaidUITask.<>f__mg$cache3);
		if (Lua_BlackJack_ProjectL_UI_ClimbTowerRaidUITask.<>f__mg$cache4 == null)
		{
			Lua_BlackJack_ProjectL_UI_ClimbTowerRaidUITask.<>f__mg$cache4 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ClimbTowerRaidUITask.ClearAllContextAndRes);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_ClimbTowerRaidUITask.<>f__mg$cache4);
		if (Lua_BlackJack_ProjectL_UI_ClimbTowerRaidUITask.<>f__mg$cache5 == null)
		{
			Lua_BlackJack_ProjectL_UI_ClimbTowerRaidUITask.<>f__mg$cache5 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ClimbTowerRaidUITask.UpdateView);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_ClimbTowerRaidUITask.<>f__mg$cache5);
		if (Lua_BlackJack_ProjectL_UI_ClimbTowerRaidUITask.<>f__mg$cache6 == null)
		{
			Lua_BlackJack_ProjectL_UI_ClimbTowerRaidUITask.<>f__mg$cache6 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ClimbTowerRaidUITask.ClimbTowerRaidInfoUIController_OnClose);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_ClimbTowerRaidUITask.<>f__mg$cache6);
		if (Lua_BlackJack_ProjectL_UI_ClimbTowerRaidUITask.<>f__mg$cache7 == null)
		{
			Lua_BlackJack_ProjectL_UI_ClimbTowerRaidUITask.<>f__mg$cache7 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ClimbTowerRaidUITask.__callBase_OnStart);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_ClimbTowerRaidUITask.<>f__mg$cache7);
		if (Lua_BlackJack_ProjectL_UI_ClimbTowerRaidUITask.<>f__mg$cache8 == null)
		{
			Lua_BlackJack_ProjectL_UI_ClimbTowerRaidUITask.<>f__mg$cache8 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ClimbTowerRaidUITask.__callBase_OnStop);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_ClimbTowerRaidUITask.<>f__mg$cache8);
		if (Lua_BlackJack_ProjectL_UI_ClimbTowerRaidUITask.<>f__mg$cache9 == null)
		{
			Lua_BlackJack_ProjectL_UI_ClimbTowerRaidUITask.<>f__mg$cache9 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ClimbTowerRaidUITask.__callBase_OnPause);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_ClimbTowerRaidUITask.<>f__mg$cache9);
		if (Lua_BlackJack_ProjectL_UI_ClimbTowerRaidUITask.<>f__mg$cacheA == null)
		{
			Lua_BlackJack_ProjectL_UI_ClimbTowerRaidUITask.<>f__mg$cacheA = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ClimbTowerRaidUITask.__callBase_OnResume);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_ClimbTowerRaidUITask.<>f__mg$cacheA);
		if (Lua_BlackJack_ProjectL_UI_ClimbTowerRaidUITask.<>f__mg$cacheB == null)
		{
			Lua_BlackJack_ProjectL_UI_ClimbTowerRaidUITask.<>f__mg$cacheB = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ClimbTowerRaidUITask.__callBase_OnNewIntent);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_ClimbTowerRaidUITask.<>f__mg$cacheB);
		if (Lua_BlackJack_ProjectL_UI_ClimbTowerRaidUITask.<>f__mg$cacheC == null)
		{
			Lua_BlackJack_ProjectL_UI_ClimbTowerRaidUITask.<>f__mg$cacheC = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ClimbTowerRaidUITask.__callBase_EnableUIInput);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_ClimbTowerRaidUITask.<>f__mg$cacheC);
		if (Lua_BlackJack_ProjectL_UI_ClimbTowerRaidUITask.<>f__mg$cacheD == null)
		{
			Lua_BlackJack_ProjectL_UI_ClimbTowerRaidUITask.<>f__mg$cacheD = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ClimbTowerRaidUITask.__callBase_IsNeedLoadDynamicRes);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_ClimbTowerRaidUITask.<>f__mg$cacheD);
		if (Lua_BlackJack_ProjectL_UI_ClimbTowerRaidUITask.<>f__mg$cacheE == null)
		{
			Lua_BlackJack_ProjectL_UI_ClimbTowerRaidUITask.<>f__mg$cacheE = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ClimbTowerRaidUITask.__callBase_CollectAllDynamicResForLoad);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_ClimbTowerRaidUITask.<>f__mg$cacheE);
		if (Lua_BlackJack_ProjectL_UI_ClimbTowerRaidUITask.<>f__mg$cacheF == null)
		{
			Lua_BlackJack_ProjectL_UI_ClimbTowerRaidUITask.<>f__mg$cacheF = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ClimbTowerRaidUITask.__callBase_RegisterPlayerContextEvents);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_ClimbTowerRaidUITask.<>f__mg$cacheF);
		if (Lua_BlackJack_ProjectL_UI_ClimbTowerRaidUITask.<>f__mg$cache10 == null)
		{
			Lua_BlackJack_ProjectL_UI_ClimbTowerRaidUITask.<>f__mg$cache10 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ClimbTowerRaidUITask.__callBase_UnregisterPlayerContextEvents);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_ClimbTowerRaidUITask.<>f__mg$cache10);
		if (Lua_BlackJack_ProjectL_UI_ClimbTowerRaidUITask.<>f__mg$cache11 == null)
		{
			Lua_BlackJack_ProjectL_UI_ClimbTowerRaidUITask.<>f__mg$cache11 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ClimbTowerRaidUITask.__callBase_PostUpdateView);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_ClimbTowerRaidUITask.<>f__mg$cache11);
		if (Lua_BlackJack_ProjectL_UI_ClimbTowerRaidUITask.<>f__mg$cache12 == null)
		{
			Lua_BlackJack_ProjectL_UI_ClimbTowerRaidUITask.<>f__mg$cache12 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ClimbTowerRaidUITask.__callBase_CollectPreloadResourceList);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_ClimbTowerRaidUITask.<>f__mg$cache12);
		if (Lua_BlackJack_ProjectL_UI_ClimbTowerRaidUITask.<>f__mg$cache13 == null)
		{
			Lua_BlackJack_ProjectL_UI_ClimbTowerRaidUITask.<>f__mg$cache13 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ClimbTowerRaidUITask.__callBase_ClearAssetList);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_ClimbTowerRaidUITask.<>f__mg$cache13);
		if (Lua_BlackJack_ProjectL_UI_ClimbTowerRaidUITask.<>f__mg$cache14 == null)
		{
			Lua_BlackJack_ProjectL_UI_ClimbTowerRaidUITask.<>f__mg$cache14 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ClimbTowerRaidUITask.__callBase_CollectAsset);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_ClimbTowerRaidUITask.<>f__mg$cache14);
		if (Lua_BlackJack_ProjectL_UI_ClimbTowerRaidUITask.<>f__mg$cache15 == null)
		{
			Lua_BlackJack_ProjectL_UI_ClimbTowerRaidUITask.<>f__mg$cache15 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ClimbTowerRaidUITask.__callBase_CollectSpriteAsset);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_ClimbTowerRaidUITask.<>f__mg$cache15);
		if (Lua_BlackJack_ProjectL_UI_ClimbTowerRaidUITask.<>f__mg$cache16 == null)
		{
			Lua_BlackJack_ProjectL_UI_ClimbTowerRaidUITask.<>f__mg$cache16 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ClimbTowerRaidUITask.__callBase_CollectFxAsset);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_ClimbTowerRaidUITask.<>f__mg$cache16);
		if (Lua_BlackJack_ProjectL_UI_ClimbTowerRaidUITask.<>f__mg$cache17 == null)
		{
			Lua_BlackJack_ProjectL_UI_ClimbTowerRaidUITask.<>f__mg$cache17 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ClimbTowerRaidUITask.__callBase_StartLoadCustomAssets);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_ClimbTowerRaidUITask.<>f__mg$cache17);
		if (Lua_BlackJack_ProjectL_UI_ClimbTowerRaidUITask.<>f__mg$cache18 == null)
		{
			Lua_BlackJack_ProjectL_UI_ClimbTowerRaidUITask.<>f__mg$cache18 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ClimbTowerRaidUITask.__callBase_IsLoadingCustomAssets);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_ClimbTowerRaidUITask.<>f__mg$cache18);
		if (Lua_BlackJack_ProjectL_UI_ClimbTowerRaidUITask.<>f__mg$cache19 == null)
		{
			Lua_BlackJack_ProjectL_UI_ClimbTowerRaidUITask.<>f__mg$cache19 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ClimbTowerRaidUITask.__callBase_IsPipeLineRunning);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_ClimbTowerRaidUITask.<>f__mg$cache19);
		if (Lua_BlackJack_ProjectL_UI_ClimbTowerRaidUITask.<>f__mg$cache1A == null)
		{
			Lua_BlackJack_ProjectL_UI_ClimbTowerRaidUITask.<>f__mg$cache1A = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ClimbTowerRaidUITask.__callBase_IsOpeningUI);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_ClimbTowerRaidUITask.<>f__mg$cache1A);
		if (Lua_BlackJack_ProjectL_UI_ClimbTowerRaidUITask.<>f__mg$cache1B == null)
		{
			Lua_BlackJack_ProjectL_UI_ClimbTowerRaidUITask.<>f__mg$cache1B = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ClimbTowerRaidUITask.__callBase_ReturnPrevUITask);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_ClimbTowerRaidUITask.<>f__mg$cache1B);
		if (Lua_BlackJack_ProjectL_UI_ClimbTowerRaidUITask.<>f__mg$cache1C == null)
		{
			Lua_BlackJack_ProjectL_UI_ClimbTowerRaidUITask.<>f__mg$cache1C = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ClimbTowerRaidUITask.__callBase_ClearUnusedDynamicResourceCache);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_ClimbTowerRaidUITask.<>f__mg$cache1C);
		if (Lua_BlackJack_ProjectL_UI_ClimbTowerRaidUITask.<>f__mg$cache1D == null)
		{
			Lua_BlackJack_ProjectL_UI_ClimbTowerRaidUITask.<>f__mg$cache1D = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ClimbTowerRaidUITask.__callBase_OnMemoryWarning);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_ClimbTowerRaidUITask.<>f__mg$cache1D);
		if (Lua_BlackJack_ProjectL_UI_ClimbTowerRaidUITask.<>f__mg$cache1E == null)
		{
			Lua_BlackJack_ProjectL_UI_ClimbTowerRaidUITask.<>f__mg$cache1E = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ClimbTowerRaidUITask.__callDele_EventOnClose);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_ClimbTowerRaidUITask.<>f__mg$cache1E);
		if (Lua_BlackJack_ProjectL_UI_ClimbTowerRaidUITask.<>f__mg$cache1F == null)
		{
			Lua_BlackJack_ProjectL_UI_ClimbTowerRaidUITask.<>f__mg$cache1F = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ClimbTowerRaidUITask.__clearDele_EventOnClose);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_ClimbTowerRaidUITask.<>f__mg$cache1F);
		string name = "EventOnClose";
		LuaCSFunction get = null;
		if (Lua_BlackJack_ProjectL_UI_ClimbTowerRaidUITask.<>f__mg$cache20 == null)
		{
			Lua_BlackJack_ProjectL_UI_ClimbTowerRaidUITask.<>f__mg$cache20 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ClimbTowerRaidUITask.set_EventOnClose);
		}
		LuaObject.addMember(l, name, get, Lua_BlackJack_ProjectL_UI_ClimbTowerRaidUITask.<>f__mg$cache20, true);
		string name2 = "m_layerDescArray";
		if (Lua_BlackJack_ProjectL_UI_ClimbTowerRaidUITask.<>f__mg$cache21 == null)
		{
			Lua_BlackJack_ProjectL_UI_ClimbTowerRaidUITask.<>f__mg$cache21 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ClimbTowerRaidUITask.get_m_layerDescArray);
		}
		LuaCSFunction get2 = Lua_BlackJack_ProjectL_UI_ClimbTowerRaidUITask.<>f__mg$cache21;
		if (Lua_BlackJack_ProjectL_UI_ClimbTowerRaidUITask.<>f__mg$cache22 == null)
		{
			Lua_BlackJack_ProjectL_UI_ClimbTowerRaidUITask.<>f__mg$cache22 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ClimbTowerRaidUITask.set_m_layerDescArray);
		}
		LuaObject.addMember(l, name2, get2, Lua_BlackJack_ProjectL_UI_ClimbTowerRaidUITask.<>f__mg$cache22, true);
		string name3 = "m_uiCtrlDescArray";
		if (Lua_BlackJack_ProjectL_UI_ClimbTowerRaidUITask.<>f__mg$cache23 == null)
		{
			Lua_BlackJack_ProjectL_UI_ClimbTowerRaidUITask.<>f__mg$cache23 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ClimbTowerRaidUITask.get_m_uiCtrlDescArray);
		}
		LuaCSFunction get3 = Lua_BlackJack_ProjectL_UI_ClimbTowerRaidUITask.<>f__mg$cache23;
		if (Lua_BlackJack_ProjectL_UI_ClimbTowerRaidUITask.<>f__mg$cache24 == null)
		{
			Lua_BlackJack_ProjectL_UI_ClimbTowerRaidUITask.<>f__mg$cache24 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ClimbTowerRaidUITask.set_m_uiCtrlDescArray);
		}
		LuaObject.addMember(l, name3, get3, Lua_BlackJack_ProjectL_UI_ClimbTowerRaidUITask.<>f__mg$cache24, true);
		string name4 = "m_climbTowerRaidUIController";
		if (Lua_BlackJack_ProjectL_UI_ClimbTowerRaidUITask.<>f__mg$cache25 == null)
		{
			Lua_BlackJack_ProjectL_UI_ClimbTowerRaidUITask.<>f__mg$cache25 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ClimbTowerRaidUITask.get_m_climbTowerRaidUIController);
		}
		LuaCSFunction get4 = Lua_BlackJack_ProjectL_UI_ClimbTowerRaidUITask.<>f__mg$cache25;
		if (Lua_BlackJack_ProjectL_UI_ClimbTowerRaidUITask.<>f__mg$cache26 == null)
		{
			Lua_BlackJack_ProjectL_UI_ClimbTowerRaidUITask.<>f__mg$cache26 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ClimbTowerRaidUITask.set_m_climbTowerRaidUIController);
		}
		LuaObject.addMember(l, name4, get4, Lua_BlackJack_ProjectL_UI_ClimbTowerRaidUITask.<>f__mg$cache26, true);
		string name5 = "m_battleReward";
		if (Lua_BlackJack_ProjectL_UI_ClimbTowerRaidUITask.<>f__mg$cache27 == null)
		{
			Lua_BlackJack_ProjectL_UI_ClimbTowerRaidUITask.<>f__mg$cache27 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ClimbTowerRaidUITask.get_m_battleReward);
		}
		LuaCSFunction get5 = Lua_BlackJack_ProjectL_UI_ClimbTowerRaidUITask.<>f__mg$cache27;
		if (Lua_BlackJack_ProjectL_UI_ClimbTowerRaidUITask.<>f__mg$cache28 == null)
		{
			Lua_BlackJack_ProjectL_UI_ClimbTowerRaidUITask.<>f__mg$cache28 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ClimbTowerRaidUITask.set_m_battleReward);
		}
		LuaObject.addMember(l, name5, get5, Lua_BlackJack_ProjectL_UI_ClimbTowerRaidUITask.<>f__mg$cache28, true);
		string name6 = "LayerDescArray";
		if (Lua_BlackJack_ProjectL_UI_ClimbTowerRaidUITask.<>f__mg$cache29 == null)
		{
			Lua_BlackJack_ProjectL_UI_ClimbTowerRaidUITask.<>f__mg$cache29 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ClimbTowerRaidUITask.get_LayerDescArray);
		}
		LuaObject.addMember(l, name6, Lua_BlackJack_ProjectL_UI_ClimbTowerRaidUITask.<>f__mg$cache29, null, true);
		string name7 = "UICtrlDescArray";
		if (Lua_BlackJack_ProjectL_UI_ClimbTowerRaidUITask.<>f__mg$cache2A == null)
		{
			Lua_BlackJack_ProjectL_UI_ClimbTowerRaidUITask.<>f__mg$cache2A = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ClimbTowerRaidUITask.get_UICtrlDescArray);
		}
		LuaObject.addMember(l, name7, Lua_BlackJack_ProjectL_UI_ClimbTowerRaidUITask.<>f__mg$cache2A, null, true);
		if (Lua_BlackJack_ProjectL_UI_ClimbTowerRaidUITask.<>f__mg$cache2B == null)
		{
			Lua_BlackJack_ProjectL_UI_ClimbTowerRaidUITask.<>f__mg$cache2B = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ClimbTowerRaidUITask.constructor);
		}
		LuaObject.createTypeMetatable(l, Lua_BlackJack_ProjectL_UI_ClimbTowerRaidUITask.<>f__mg$cache2B, typeof(ClimbTowerRaidUITask), typeof(UITask));
	}

	// Token: 0x04012DE1 RID: 77281
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache0;

	// Token: 0x04012DE2 RID: 77282
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1;

	// Token: 0x04012DE3 RID: 77283
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2;

	// Token: 0x04012DE4 RID: 77284
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3;

	// Token: 0x04012DE5 RID: 77285
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache4;

	// Token: 0x04012DE6 RID: 77286
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache5;

	// Token: 0x04012DE7 RID: 77287
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache6;

	// Token: 0x04012DE8 RID: 77288
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache7;

	// Token: 0x04012DE9 RID: 77289
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache8;

	// Token: 0x04012DEA RID: 77290
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache9;

	// Token: 0x04012DEB RID: 77291
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheA;

	// Token: 0x04012DEC RID: 77292
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheB;

	// Token: 0x04012DED RID: 77293
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheC;

	// Token: 0x04012DEE RID: 77294
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheD;

	// Token: 0x04012DEF RID: 77295
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheE;

	// Token: 0x04012DF0 RID: 77296
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheF;

	// Token: 0x04012DF1 RID: 77297
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache10;

	// Token: 0x04012DF2 RID: 77298
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache11;

	// Token: 0x04012DF3 RID: 77299
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache12;

	// Token: 0x04012DF4 RID: 77300
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache13;

	// Token: 0x04012DF5 RID: 77301
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache14;

	// Token: 0x04012DF6 RID: 77302
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache15;

	// Token: 0x04012DF7 RID: 77303
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache16;

	// Token: 0x04012DF8 RID: 77304
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache17;

	// Token: 0x04012DF9 RID: 77305
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache18;

	// Token: 0x04012DFA RID: 77306
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache19;

	// Token: 0x04012DFB RID: 77307
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1A;

	// Token: 0x04012DFC RID: 77308
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1B;

	// Token: 0x04012DFD RID: 77309
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1C;

	// Token: 0x04012DFE RID: 77310
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1D;

	// Token: 0x04012DFF RID: 77311
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1E;

	// Token: 0x04012E00 RID: 77312
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1F;

	// Token: 0x04012E01 RID: 77313
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache20;

	// Token: 0x04012E02 RID: 77314
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache21;

	// Token: 0x04012E03 RID: 77315
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache22;

	// Token: 0x04012E04 RID: 77316
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache23;

	// Token: 0x04012E05 RID: 77317
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache24;

	// Token: 0x04012E06 RID: 77318
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache25;

	// Token: 0x04012E07 RID: 77319
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache26;

	// Token: 0x04012E08 RID: 77320
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache27;

	// Token: 0x04012E09 RID: 77321
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache28;

	// Token: 0x04012E0A RID: 77322
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache29;

	// Token: 0x04012E0B RID: 77323
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2A;

	// Token: 0x04012E0C RID: 77324
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2B;
}
