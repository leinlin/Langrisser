using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using BlackJack.BJFramework.Runtime.UI;
using BlackJack.ConfigData;
using BlackJack.ProjectL.UI;
using SLua;
using UnityEngine.Scripting;

// Token: 0x020013F8 RID: 5112
[Preserve]
public class Lua_BlackJack_ProjectL_UI_ClimbTowerLevelInfoUITask : LuaObject
{
	// Token: 0x0601CB8D RID: 117645 RVA: 0x008F55E8 File Offset: 0x008F37E8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int constructor(IntPtr l)
	{
		int result;
		try
		{
			string name;
			LuaObject.checkType(l, 2, out name);
			ClimbTowerLevelInfoUITask o = new ClimbTowerLevelInfoUITask(name);
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

	// Token: 0x0601CB8E RID: 117646 RVA: 0x008F563C File Offset: 0x008F383C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int OnStart(IntPtr l)
	{
		int result;
		try
		{
			ClimbTowerLevelInfoUITask climbTowerLevelInfoUITask = (ClimbTowerLevelInfoUITask)LuaObject.checkSelf(l);
			UIIntent intent;
			LuaObject.checkType<UIIntent>(l, 2, out intent);
			bool b = climbTowerLevelInfoUITask.m_luaExportHelper.OnStart(intent);
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

	// Token: 0x0601CB8F RID: 117647 RVA: 0x008F56A4 File Offset: 0x008F38A4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int OnResume(IntPtr l)
	{
		int result;
		try
		{
			ClimbTowerLevelInfoUITask climbTowerLevelInfoUITask = (ClimbTowerLevelInfoUITask)LuaObject.checkSelf(l);
			UIIntent intent;
			LuaObject.checkType<UIIntent>(l, 2, out intent);
			bool b = climbTowerLevelInfoUITask.m_luaExportHelper.OnResume(intent);
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

	// Token: 0x0601CB90 RID: 117648 RVA: 0x008F570C File Offset: 0x008F390C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int InitDataFromUIIntent(IntPtr l)
	{
		int result;
		try
		{
			ClimbTowerLevelInfoUITask climbTowerLevelInfoUITask = (ClimbTowerLevelInfoUITask)LuaObject.checkSelf(l);
			UIIntent intent;
			LuaObject.checkType<UIIntent>(l, 2, out intent);
			climbTowerLevelInfoUITask.m_luaExportHelper.InitDataFromUIIntent(intent);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601CB91 RID: 117649 RVA: 0x008F5768 File Offset: 0x008F3968
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int IsNeedLoadDynamicRes(IntPtr l)
	{
		int result;
		try
		{
			ClimbTowerLevelInfoUITask climbTowerLevelInfoUITask = (ClimbTowerLevelInfoUITask)LuaObject.checkSelf(l);
			bool b = climbTowerLevelInfoUITask.m_luaExportHelper.IsNeedLoadDynamicRes();
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

	// Token: 0x0601CB92 RID: 117650 RVA: 0x008F57C4 File Offset: 0x008F39C4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int InitAllUIControllers(IntPtr l)
	{
		int result;
		try
		{
			ClimbTowerLevelInfoUITask climbTowerLevelInfoUITask = (ClimbTowerLevelInfoUITask)LuaObject.checkSelf(l);
			climbTowerLevelInfoUITask.m_luaExportHelper.InitAllUIControllers();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601CB93 RID: 117651 RVA: 0x008F5818 File Offset: 0x008F3A18
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int ClearAllContextAndRes(IntPtr l)
	{
		int result;
		try
		{
			ClimbTowerLevelInfoUITask climbTowerLevelInfoUITask = (ClimbTowerLevelInfoUITask)LuaObject.checkSelf(l);
			climbTowerLevelInfoUITask.m_luaExportHelper.ClearAllContextAndRes();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601CB94 RID: 117652 RVA: 0x008F586C File Offset: 0x008F3A6C
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int UpdateView(IntPtr l)
	{
		int result;
		try
		{
			ClimbTowerLevelInfoUITask climbTowerLevelInfoUITask = (ClimbTowerLevelInfoUITask)LuaObject.checkSelf(l);
			climbTowerLevelInfoUITask.m_luaExportHelper.UpdateView();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601CB95 RID: 117653 RVA: 0x008F58C0 File Offset: 0x008F3AC0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int ClimbTowerLevelInfoUIController_OnStartBattle(IntPtr l)
	{
		int result;
		try
		{
			ClimbTowerLevelInfoUITask climbTowerLevelInfoUITask = (ClimbTowerLevelInfoUITask)LuaObject.checkSelf(l);
			climbTowerLevelInfoUITask.m_luaExportHelper.ClimbTowerLevelInfoUIController_OnStartBattle();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601CB96 RID: 117654 RVA: 0x008F5914 File Offset: 0x008F3B14
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int ClimbTowerLevelInfoUIController_OnClose(IntPtr l)
	{
		int result;
		try
		{
			ClimbTowerLevelInfoUITask climbTowerLevelInfoUITask = (ClimbTowerLevelInfoUITask)LuaObject.checkSelf(l);
			climbTowerLevelInfoUITask.m_luaExportHelper.ClimbTowerLevelInfoUIController_OnClose();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601CB97 RID: 117655 RVA: 0x008F5968 File Offset: 0x008F3B68
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_OnStart(IntPtr l)
	{
		int result;
		try
		{
			ClimbTowerLevelInfoUITask climbTowerLevelInfoUITask = (ClimbTowerLevelInfoUITask)LuaObject.checkSelf(l);
			UIIntent intent;
			LuaObject.checkType<UIIntent>(l, 2, out intent);
			bool b = climbTowerLevelInfoUITask.m_luaExportHelper.__callBase_OnStart(intent);
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

	// Token: 0x0601CB98 RID: 117656 RVA: 0x008F59D0 File Offset: 0x008F3BD0
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int __callBase_OnStop(IntPtr l)
	{
		int result;
		try
		{
			ClimbTowerLevelInfoUITask climbTowerLevelInfoUITask = (ClimbTowerLevelInfoUITask)LuaObject.checkSelf(l);
			climbTowerLevelInfoUITask.m_luaExportHelper.__callBase_OnStop();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601CB99 RID: 117657 RVA: 0x008F5A24 File Offset: 0x008F3C24
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_OnPause(IntPtr l)
	{
		int result;
		try
		{
			ClimbTowerLevelInfoUITask climbTowerLevelInfoUITask = (ClimbTowerLevelInfoUITask)LuaObject.checkSelf(l);
			climbTowerLevelInfoUITask.m_luaExportHelper.__callBase_OnPause();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601CB9A RID: 117658 RVA: 0x008F5A78 File Offset: 0x008F3C78
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_OnResume(IntPtr l)
	{
		int result;
		try
		{
			ClimbTowerLevelInfoUITask climbTowerLevelInfoUITask = (ClimbTowerLevelInfoUITask)LuaObject.checkSelf(l);
			UIIntent intent;
			LuaObject.checkType<UIIntent>(l, 2, out intent);
			bool b = climbTowerLevelInfoUITask.m_luaExportHelper.__callBase_OnResume(intent);
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

	// Token: 0x0601CB9B RID: 117659 RVA: 0x008F5AE0 File Offset: 0x008F3CE0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_OnNewIntent(IntPtr l)
	{
		int result;
		try
		{
			ClimbTowerLevelInfoUITask climbTowerLevelInfoUITask = (ClimbTowerLevelInfoUITask)LuaObject.checkSelf(l);
			UIIntent intent;
			LuaObject.checkType<UIIntent>(l, 2, out intent);
			bool b = climbTowerLevelInfoUITask.m_luaExportHelper.__callBase_OnNewIntent(intent);
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

	// Token: 0x0601CB9C RID: 117660 RVA: 0x008F5B48 File Offset: 0x008F3D48
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_EnableUIInput(IntPtr l)
	{
		int result;
		try
		{
			ClimbTowerLevelInfoUITask climbTowerLevelInfoUITask = (ClimbTowerLevelInfoUITask)LuaObject.checkSelf(l);
			bool isEnable;
			LuaObject.checkType(l, 2, out isEnable);
			bool? isGlobalEnable;
			LuaObject.checkNullable<bool>(l, 3, out isGlobalEnable);
			climbTowerLevelInfoUITask.m_luaExportHelper.__callBase_EnableUIInput(isEnable, isGlobalEnable);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601CB9D RID: 117661 RVA: 0x008F5BB4 File Offset: 0x008F3DB4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_IsNeedLoadDynamicRes(IntPtr l)
	{
		int result;
		try
		{
			ClimbTowerLevelInfoUITask climbTowerLevelInfoUITask = (ClimbTowerLevelInfoUITask)LuaObject.checkSelf(l);
			bool b = climbTowerLevelInfoUITask.m_luaExportHelper.__callBase_IsNeedLoadDynamicRes();
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

	// Token: 0x0601CB9E RID: 117662 RVA: 0x008F5C10 File Offset: 0x008F3E10
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_CollectAllDynamicResForLoad(IntPtr l)
	{
		int result;
		try
		{
			ClimbTowerLevelInfoUITask climbTowerLevelInfoUITask = (ClimbTowerLevelInfoUITask)LuaObject.checkSelf(l);
			List<string> o = climbTowerLevelInfoUITask.m_luaExportHelper.__callBase_CollectAllDynamicResForLoad();
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

	// Token: 0x0601CB9F RID: 117663 RVA: 0x008F5C6C File Offset: 0x008F3E6C
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int __callBase_RegisterPlayerContextEvents(IntPtr l)
	{
		int result;
		try
		{
			ClimbTowerLevelInfoUITask climbTowerLevelInfoUITask = (ClimbTowerLevelInfoUITask)LuaObject.checkSelf(l);
			climbTowerLevelInfoUITask.m_luaExportHelper.__callBase_RegisterPlayerContextEvents();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601CBA0 RID: 117664 RVA: 0x008F5CC0 File Offset: 0x008F3EC0
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int __callBase_UnregisterPlayerContextEvents(IntPtr l)
	{
		int result;
		try
		{
			ClimbTowerLevelInfoUITask climbTowerLevelInfoUITask = (ClimbTowerLevelInfoUITask)LuaObject.checkSelf(l);
			climbTowerLevelInfoUITask.m_luaExportHelper.__callBase_UnregisterPlayerContextEvents();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601CBA1 RID: 117665 RVA: 0x008F5D14 File Offset: 0x008F3F14
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_PostUpdateView(IntPtr l)
	{
		int result;
		try
		{
			ClimbTowerLevelInfoUITask climbTowerLevelInfoUITask = (ClimbTowerLevelInfoUITask)LuaObject.checkSelf(l);
			climbTowerLevelInfoUITask.m_luaExportHelper.__callBase_PostUpdateView();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601CBA2 RID: 117666 RVA: 0x008F5D68 File Offset: 0x008F3F68
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_CollectPreloadResourceList(IntPtr l)
	{
		int result;
		try
		{
			ClimbTowerLevelInfoUITask climbTowerLevelInfoUITask = (ClimbTowerLevelInfoUITask)LuaObject.checkSelf(l);
			climbTowerLevelInfoUITask.m_luaExportHelper.__callBase_CollectPreloadResourceList();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601CBA3 RID: 117667 RVA: 0x008F5DBC File Offset: 0x008F3FBC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_ClearAssetList(IntPtr l)
	{
		int result;
		try
		{
			ClimbTowerLevelInfoUITask climbTowerLevelInfoUITask = (ClimbTowerLevelInfoUITask)LuaObject.checkSelf(l);
			climbTowerLevelInfoUITask.m_luaExportHelper.__callBase_ClearAssetList();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601CBA4 RID: 117668 RVA: 0x008F5E10 File Offset: 0x008F4010
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_CollectAsset(IntPtr l)
	{
		int result;
		try
		{
			ClimbTowerLevelInfoUITask climbTowerLevelInfoUITask = (ClimbTowerLevelInfoUITask)LuaObject.checkSelf(l);
			string assetName;
			LuaObject.checkType(l, 2, out assetName);
			climbTowerLevelInfoUITask.m_luaExportHelper.__callBase_CollectAsset(assetName);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601CBA5 RID: 117669 RVA: 0x008F5E6C File Offset: 0x008F406C
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int __callBase_CollectSpriteAsset(IntPtr l)
	{
		int result;
		try
		{
			ClimbTowerLevelInfoUITask climbTowerLevelInfoUITask = (ClimbTowerLevelInfoUITask)LuaObject.checkSelf(l);
			string assetName;
			LuaObject.checkType(l, 2, out assetName);
			climbTowerLevelInfoUITask.m_luaExportHelper.__callBase_CollectSpriteAsset(assetName);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601CBA6 RID: 117670 RVA: 0x008F5EC8 File Offset: 0x008F40C8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_CollectFxAsset(IntPtr l)
	{
		int result;
		try
		{
			ClimbTowerLevelInfoUITask climbTowerLevelInfoUITask = (ClimbTowerLevelInfoUITask)LuaObject.checkSelf(l);
			string assetName;
			LuaObject.checkType(l, 2, out assetName);
			climbTowerLevelInfoUITask.m_luaExportHelper.__callBase_CollectFxAsset(assetName);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601CBA7 RID: 117671 RVA: 0x008F5F24 File Offset: 0x008F4124
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_StartLoadCustomAssets(IntPtr l)
	{
		int result;
		try
		{
			ClimbTowerLevelInfoUITask climbTowerLevelInfoUITask = (ClimbTowerLevelInfoUITask)LuaObject.checkSelf(l);
			Action onLoadCompleted;
			LuaObject.checkDelegate<Action>(l, 2, out onLoadCompleted);
			climbTowerLevelInfoUITask.m_luaExportHelper.__callBase_StartLoadCustomAssets(onLoadCompleted);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601CBA8 RID: 117672 RVA: 0x008F5F80 File Offset: 0x008F4180
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int __callBase_IsLoadingCustomAssets(IntPtr l)
	{
		int result;
		try
		{
			ClimbTowerLevelInfoUITask climbTowerLevelInfoUITask = (ClimbTowerLevelInfoUITask)LuaObject.checkSelf(l);
			bool b = climbTowerLevelInfoUITask.m_luaExportHelper.__callBase_IsLoadingCustomAssets();
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

	// Token: 0x0601CBA9 RID: 117673 RVA: 0x008F5FDC File Offset: 0x008F41DC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_IsPipeLineRunning(IntPtr l)
	{
		int result;
		try
		{
			ClimbTowerLevelInfoUITask climbTowerLevelInfoUITask = (ClimbTowerLevelInfoUITask)LuaObject.checkSelf(l);
			bool b = climbTowerLevelInfoUITask.m_luaExportHelper.__callBase_IsPipeLineRunning();
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

	// Token: 0x0601CBAA RID: 117674 RVA: 0x008F6038 File Offset: 0x008F4238
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int __callBase_IsOpeningUI(IntPtr l)
	{
		int result;
		try
		{
			ClimbTowerLevelInfoUITask climbTowerLevelInfoUITask = (ClimbTowerLevelInfoUITask)LuaObject.checkSelf(l);
			bool b = climbTowerLevelInfoUITask.m_luaExportHelper.__callBase_IsOpeningUI();
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

	// Token: 0x0601CBAB RID: 117675 RVA: 0x008F6094 File Offset: 0x008F4294
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int __callBase_ReturnPrevUITask(IntPtr l)
	{
		int result;
		try
		{
			ClimbTowerLevelInfoUITask climbTowerLevelInfoUITask = (ClimbTowerLevelInfoUITask)LuaObject.checkSelf(l);
			UITaskBase o = climbTowerLevelInfoUITask.m_luaExportHelper.__callBase_ReturnPrevUITask();
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

	// Token: 0x0601CBAC RID: 117676 RVA: 0x008F60F0 File Offset: 0x008F42F0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_ClearUnusedDynamicResourceCache(IntPtr l)
	{
		int result;
		try
		{
			ClimbTowerLevelInfoUITask climbTowerLevelInfoUITask = (ClimbTowerLevelInfoUITask)LuaObject.checkSelf(l);
			climbTowerLevelInfoUITask.m_luaExportHelper.__callBase_ClearUnusedDynamicResourceCache();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601CBAD RID: 117677 RVA: 0x008F6144 File Offset: 0x008F4344
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_OnMemoryWarning(IntPtr l)
	{
		int result;
		try
		{
			ClimbTowerLevelInfoUITask climbTowerLevelInfoUITask = (ClimbTowerLevelInfoUITask)LuaObject.checkSelf(l);
			climbTowerLevelInfoUITask.m_luaExportHelper.__callBase_OnMemoryWarning();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601CBAE RID: 117678 RVA: 0x008F6198 File Offset: 0x008F4398
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callDele_EventOnClose(IntPtr l)
	{
		int result;
		try
		{
			ClimbTowerLevelInfoUITask climbTowerLevelInfoUITask = (ClimbTowerLevelInfoUITask)LuaObject.checkSelf(l);
			climbTowerLevelInfoUITask.m_luaExportHelper.__callDele_EventOnClose();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601CBAF RID: 117679 RVA: 0x008F61EC File Offset: 0x008F43EC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __clearDele_EventOnClose(IntPtr l)
	{
		int result;
		try
		{
			ClimbTowerLevelInfoUITask climbTowerLevelInfoUITask = (ClimbTowerLevelInfoUITask)LuaObject.checkSelf(l);
			climbTowerLevelInfoUITask.m_luaExportHelper.__clearDele_EventOnClose();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601CBB0 RID: 117680 RVA: 0x008F6240 File Offset: 0x008F4440
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_EventOnClose(IntPtr l)
	{
		int result;
		try
		{
			ClimbTowerLevelInfoUITask climbTowerLevelInfoUITask = (ClimbTowerLevelInfoUITask)LuaObject.checkSelf(l);
			Action value;
			int num = LuaObject.checkDelegate<Action>(l, 2, out value);
			if (num != 0)
			{
				if (num == 1)
				{
					climbTowerLevelInfoUITask.EventOnClose += value;
				}
				else if (num == 2)
				{
					climbTowerLevelInfoUITask.EventOnClose -= value;
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

	// Token: 0x0601CBB1 RID: 117681 RVA: 0x008F62C0 File Offset: 0x008F44C0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_layerDescArray(IntPtr l)
	{
		int result;
		try
		{
			ClimbTowerLevelInfoUITask climbTowerLevelInfoUITask = (ClimbTowerLevelInfoUITask)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, climbTowerLevelInfoUITask.m_luaExportHelper.m_layerDescArray);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601CBB2 RID: 117682 RVA: 0x008F6318 File Offset: 0x008F4518
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_layerDescArray(IntPtr l)
	{
		int result;
		try
		{
			ClimbTowerLevelInfoUITask climbTowerLevelInfoUITask = (ClimbTowerLevelInfoUITask)LuaObject.checkSelf(l);
			UITaskBase.LayerDesc[] layerDescArray;
			LuaObject.checkArray<UITaskBase.LayerDesc>(l, 2, out layerDescArray);
			climbTowerLevelInfoUITask.m_luaExportHelper.m_layerDescArray = layerDescArray;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601CBB3 RID: 117683 RVA: 0x008F6374 File Offset: 0x008F4574
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_uiCtrlDescArray(IntPtr l)
	{
		int result;
		try
		{
			ClimbTowerLevelInfoUITask climbTowerLevelInfoUITask = (ClimbTowerLevelInfoUITask)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, climbTowerLevelInfoUITask.m_luaExportHelper.m_uiCtrlDescArray);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601CBB4 RID: 117684 RVA: 0x008F63CC File Offset: 0x008F45CC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_uiCtrlDescArray(IntPtr l)
	{
		int result;
		try
		{
			ClimbTowerLevelInfoUITask climbTowerLevelInfoUITask = (ClimbTowerLevelInfoUITask)LuaObject.checkSelf(l);
			UITaskBase.UIControllerDesc[] uiCtrlDescArray;
			LuaObject.checkArray<UITaskBase.UIControllerDesc>(l, 2, out uiCtrlDescArray);
			climbTowerLevelInfoUITask.m_luaExportHelper.m_uiCtrlDescArray = uiCtrlDescArray;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601CBB5 RID: 117685 RVA: 0x008F6428 File Offset: 0x008F4628
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_climbTowerLevelInfoUIController(IntPtr l)
	{
		int result;
		try
		{
			ClimbTowerLevelInfoUITask climbTowerLevelInfoUITask = (ClimbTowerLevelInfoUITask)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, climbTowerLevelInfoUITask.m_luaExportHelper.m_climbTowerLevelInfoUIController);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601CBB6 RID: 117686 RVA: 0x008F6480 File Offset: 0x008F4680
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_climbTowerLevelInfoUIController(IntPtr l)
	{
		int result;
		try
		{
			ClimbTowerLevelInfoUITask climbTowerLevelInfoUITask = (ClimbTowerLevelInfoUITask)LuaObject.checkSelf(l);
			ClimbTowerLevelInfoUIController climbTowerLevelInfoUIController;
			LuaObject.checkType<ClimbTowerLevelInfoUIController>(l, 2, out climbTowerLevelInfoUIController);
			climbTowerLevelInfoUITask.m_luaExportHelper.m_climbTowerLevelInfoUIController = climbTowerLevelInfoUIController;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601CBB7 RID: 117687 RVA: 0x008F64DC File Offset: 0x008F46DC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_towerFloorInfo(IntPtr l)
	{
		int result;
		try
		{
			ClimbTowerLevelInfoUITask climbTowerLevelInfoUITask = (ClimbTowerLevelInfoUITask)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, climbTowerLevelInfoUITask.m_luaExportHelper.m_towerFloorInfo);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601CBB8 RID: 117688 RVA: 0x008F6534 File Offset: 0x008F4734
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_towerFloorInfo(IntPtr l)
	{
		int result;
		try
		{
			ClimbTowerLevelInfoUITask climbTowerLevelInfoUITask = (ClimbTowerLevelInfoUITask)LuaObject.checkSelf(l);
			ConfigDataTowerFloorInfo towerFloorInfo;
			LuaObject.checkType<ConfigDataTowerFloorInfo>(l, 2, out towerFloorInfo);
			climbTowerLevelInfoUITask.m_luaExportHelper.m_towerFloorInfo = towerFloorInfo;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601CBB9 RID: 117689 RVA: 0x008F6590 File Offset: 0x008F4790
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_towerLevelInfo(IntPtr l)
	{
		int result;
		try
		{
			ClimbTowerLevelInfoUITask climbTowerLevelInfoUITask = (ClimbTowerLevelInfoUITask)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, climbTowerLevelInfoUITask.m_luaExportHelper.m_towerLevelInfo);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601CBBA RID: 117690 RVA: 0x008F65E8 File Offset: 0x008F47E8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_towerLevelInfo(IntPtr l)
	{
		int result;
		try
		{
			ClimbTowerLevelInfoUITask climbTowerLevelInfoUITask = (ClimbTowerLevelInfoUITask)LuaObject.checkSelf(l);
			ConfigDataTowerLevelInfo towerLevelInfo;
			LuaObject.checkType<ConfigDataTowerLevelInfo>(l, 2, out towerLevelInfo);
			climbTowerLevelInfoUITask.m_luaExportHelper.m_towerLevelInfo = towerLevelInfo;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601CBBB RID: 117691 RVA: 0x008F6644 File Offset: 0x008F4844
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_towerBattleRuleInfo(IntPtr l)
	{
		int result;
		try
		{
			ClimbTowerLevelInfoUITask climbTowerLevelInfoUITask = (ClimbTowerLevelInfoUITask)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, climbTowerLevelInfoUITask.m_luaExportHelper.m_towerBattleRuleInfo);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601CBBC RID: 117692 RVA: 0x008F669C File Offset: 0x008F489C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_towerBattleRuleInfo(IntPtr l)
	{
		int result;
		try
		{
			ClimbTowerLevelInfoUITask climbTowerLevelInfoUITask = (ClimbTowerLevelInfoUITask)LuaObject.checkSelf(l);
			ConfigDataTowerBattleRuleInfo towerBattleRuleInfo;
			LuaObject.checkType<ConfigDataTowerBattleRuleInfo>(l, 2, out towerBattleRuleInfo);
			climbTowerLevelInfoUITask.m_luaExportHelper.m_towerBattleRuleInfo = towerBattleRuleInfo;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601CBBD RID: 117693 RVA: 0x008F66F8 File Offset: 0x008F48F8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_towerBonusHeroGroupInfo(IntPtr l)
	{
		int result;
		try
		{
			ClimbTowerLevelInfoUITask climbTowerLevelInfoUITask = (ClimbTowerLevelInfoUITask)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, climbTowerLevelInfoUITask.m_luaExportHelper.m_towerBonusHeroGroupInfo);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601CBBE RID: 117694 RVA: 0x008F6750 File Offset: 0x008F4950
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_towerBonusHeroGroupInfo(IntPtr l)
	{
		int result;
		try
		{
			ClimbTowerLevelInfoUITask climbTowerLevelInfoUITask = (ClimbTowerLevelInfoUITask)LuaObject.checkSelf(l);
			ConfigDataTowerBonusHeroGroupInfo towerBonusHeroGroupInfo;
			LuaObject.checkType<ConfigDataTowerBonusHeroGroupInfo>(l, 2, out towerBonusHeroGroupInfo);
			climbTowerLevelInfoUITask.m_luaExportHelper.m_towerBonusHeroGroupInfo = towerBonusHeroGroupInfo;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601CBBF RID: 117695 RVA: 0x008F67AC File Offset: 0x008F49AC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_LayerDescArray(IntPtr l)
	{
		int result;
		try
		{
			ClimbTowerLevelInfoUITask climbTowerLevelInfoUITask = (ClimbTowerLevelInfoUITask)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, climbTowerLevelInfoUITask.m_luaExportHelper.LayerDescArray);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601CBC0 RID: 117696 RVA: 0x008F6804 File Offset: 0x008F4A04
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_UICtrlDescArray(IntPtr l)
	{
		int result;
		try
		{
			ClimbTowerLevelInfoUITask climbTowerLevelInfoUITask = (ClimbTowerLevelInfoUITask)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, climbTowerLevelInfoUITask.m_luaExportHelper.UICtrlDescArray);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601CBC1 RID: 117697 RVA: 0x008F685C File Offset: 0x008F4A5C
	[Preserve]
	public static void reg(IntPtr l)
	{
		LuaObject.getTypeTable(l, "BlackJack.ProjectL.UI.ClimbTowerLevelInfoUITask");
		if (Lua_BlackJack_ProjectL_UI_ClimbTowerLevelInfoUITask.<>f__mg$cache0 == null)
		{
			Lua_BlackJack_ProjectL_UI_ClimbTowerLevelInfoUITask.<>f__mg$cache0 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ClimbTowerLevelInfoUITask.OnStart);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_ClimbTowerLevelInfoUITask.<>f__mg$cache0);
		if (Lua_BlackJack_ProjectL_UI_ClimbTowerLevelInfoUITask.<>f__mg$cache1 == null)
		{
			Lua_BlackJack_ProjectL_UI_ClimbTowerLevelInfoUITask.<>f__mg$cache1 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ClimbTowerLevelInfoUITask.OnResume);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_ClimbTowerLevelInfoUITask.<>f__mg$cache1);
		if (Lua_BlackJack_ProjectL_UI_ClimbTowerLevelInfoUITask.<>f__mg$cache2 == null)
		{
			Lua_BlackJack_ProjectL_UI_ClimbTowerLevelInfoUITask.<>f__mg$cache2 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ClimbTowerLevelInfoUITask.InitDataFromUIIntent);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_ClimbTowerLevelInfoUITask.<>f__mg$cache2);
		if (Lua_BlackJack_ProjectL_UI_ClimbTowerLevelInfoUITask.<>f__mg$cache3 == null)
		{
			Lua_BlackJack_ProjectL_UI_ClimbTowerLevelInfoUITask.<>f__mg$cache3 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ClimbTowerLevelInfoUITask.IsNeedLoadDynamicRes);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_ClimbTowerLevelInfoUITask.<>f__mg$cache3);
		if (Lua_BlackJack_ProjectL_UI_ClimbTowerLevelInfoUITask.<>f__mg$cache4 == null)
		{
			Lua_BlackJack_ProjectL_UI_ClimbTowerLevelInfoUITask.<>f__mg$cache4 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ClimbTowerLevelInfoUITask.InitAllUIControllers);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_ClimbTowerLevelInfoUITask.<>f__mg$cache4);
		if (Lua_BlackJack_ProjectL_UI_ClimbTowerLevelInfoUITask.<>f__mg$cache5 == null)
		{
			Lua_BlackJack_ProjectL_UI_ClimbTowerLevelInfoUITask.<>f__mg$cache5 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ClimbTowerLevelInfoUITask.ClearAllContextAndRes);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_ClimbTowerLevelInfoUITask.<>f__mg$cache5);
		if (Lua_BlackJack_ProjectL_UI_ClimbTowerLevelInfoUITask.<>f__mg$cache6 == null)
		{
			Lua_BlackJack_ProjectL_UI_ClimbTowerLevelInfoUITask.<>f__mg$cache6 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ClimbTowerLevelInfoUITask.UpdateView);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_ClimbTowerLevelInfoUITask.<>f__mg$cache6);
		if (Lua_BlackJack_ProjectL_UI_ClimbTowerLevelInfoUITask.<>f__mg$cache7 == null)
		{
			Lua_BlackJack_ProjectL_UI_ClimbTowerLevelInfoUITask.<>f__mg$cache7 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ClimbTowerLevelInfoUITask.ClimbTowerLevelInfoUIController_OnStartBattle);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_ClimbTowerLevelInfoUITask.<>f__mg$cache7);
		if (Lua_BlackJack_ProjectL_UI_ClimbTowerLevelInfoUITask.<>f__mg$cache8 == null)
		{
			Lua_BlackJack_ProjectL_UI_ClimbTowerLevelInfoUITask.<>f__mg$cache8 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ClimbTowerLevelInfoUITask.ClimbTowerLevelInfoUIController_OnClose);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_ClimbTowerLevelInfoUITask.<>f__mg$cache8);
		if (Lua_BlackJack_ProjectL_UI_ClimbTowerLevelInfoUITask.<>f__mg$cache9 == null)
		{
			Lua_BlackJack_ProjectL_UI_ClimbTowerLevelInfoUITask.<>f__mg$cache9 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ClimbTowerLevelInfoUITask.__callBase_OnStart);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_ClimbTowerLevelInfoUITask.<>f__mg$cache9);
		if (Lua_BlackJack_ProjectL_UI_ClimbTowerLevelInfoUITask.<>f__mg$cacheA == null)
		{
			Lua_BlackJack_ProjectL_UI_ClimbTowerLevelInfoUITask.<>f__mg$cacheA = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ClimbTowerLevelInfoUITask.__callBase_OnStop);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_ClimbTowerLevelInfoUITask.<>f__mg$cacheA);
		if (Lua_BlackJack_ProjectL_UI_ClimbTowerLevelInfoUITask.<>f__mg$cacheB == null)
		{
			Lua_BlackJack_ProjectL_UI_ClimbTowerLevelInfoUITask.<>f__mg$cacheB = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ClimbTowerLevelInfoUITask.__callBase_OnPause);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_ClimbTowerLevelInfoUITask.<>f__mg$cacheB);
		if (Lua_BlackJack_ProjectL_UI_ClimbTowerLevelInfoUITask.<>f__mg$cacheC == null)
		{
			Lua_BlackJack_ProjectL_UI_ClimbTowerLevelInfoUITask.<>f__mg$cacheC = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ClimbTowerLevelInfoUITask.__callBase_OnResume);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_ClimbTowerLevelInfoUITask.<>f__mg$cacheC);
		if (Lua_BlackJack_ProjectL_UI_ClimbTowerLevelInfoUITask.<>f__mg$cacheD == null)
		{
			Lua_BlackJack_ProjectL_UI_ClimbTowerLevelInfoUITask.<>f__mg$cacheD = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ClimbTowerLevelInfoUITask.__callBase_OnNewIntent);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_ClimbTowerLevelInfoUITask.<>f__mg$cacheD);
		if (Lua_BlackJack_ProjectL_UI_ClimbTowerLevelInfoUITask.<>f__mg$cacheE == null)
		{
			Lua_BlackJack_ProjectL_UI_ClimbTowerLevelInfoUITask.<>f__mg$cacheE = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ClimbTowerLevelInfoUITask.__callBase_EnableUIInput);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_ClimbTowerLevelInfoUITask.<>f__mg$cacheE);
		if (Lua_BlackJack_ProjectL_UI_ClimbTowerLevelInfoUITask.<>f__mg$cacheF == null)
		{
			Lua_BlackJack_ProjectL_UI_ClimbTowerLevelInfoUITask.<>f__mg$cacheF = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ClimbTowerLevelInfoUITask.__callBase_IsNeedLoadDynamicRes);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_ClimbTowerLevelInfoUITask.<>f__mg$cacheF);
		if (Lua_BlackJack_ProjectL_UI_ClimbTowerLevelInfoUITask.<>f__mg$cache10 == null)
		{
			Lua_BlackJack_ProjectL_UI_ClimbTowerLevelInfoUITask.<>f__mg$cache10 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ClimbTowerLevelInfoUITask.__callBase_CollectAllDynamicResForLoad);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_ClimbTowerLevelInfoUITask.<>f__mg$cache10);
		if (Lua_BlackJack_ProjectL_UI_ClimbTowerLevelInfoUITask.<>f__mg$cache11 == null)
		{
			Lua_BlackJack_ProjectL_UI_ClimbTowerLevelInfoUITask.<>f__mg$cache11 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ClimbTowerLevelInfoUITask.__callBase_RegisterPlayerContextEvents);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_ClimbTowerLevelInfoUITask.<>f__mg$cache11);
		if (Lua_BlackJack_ProjectL_UI_ClimbTowerLevelInfoUITask.<>f__mg$cache12 == null)
		{
			Lua_BlackJack_ProjectL_UI_ClimbTowerLevelInfoUITask.<>f__mg$cache12 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ClimbTowerLevelInfoUITask.__callBase_UnregisterPlayerContextEvents);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_ClimbTowerLevelInfoUITask.<>f__mg$cache12);
		if (Lua_BlackJack_ProjectL_UI_ClimbTowerLevelInfoUITask.<>f__mg$cache13 == null)
		{
			Lua_BlackJack_ProjectL_UI_ClimbTowerLevelInfoUITask.<>f__mg$cache13 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ClimbTowerLevelInfoUITask.__callBase_PostUpdateView);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_ClimbTowerLevelInfoUITask.<>f__mg$cache13);
		if (Lua_BlackJack_ProjectL_UI_ClimbTowerLevelInfoUITask.<>f__mg$cache14 == null)
		{
			Lua_BlackJack_ProjectL_UI_ClimbTowerLevelInfoUITask.<>f__mg$cache14 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ClimbTowerLevelInfoUITask.__callBase_CollectPreloadResourceList);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_ClimbTowerLevelInfoUITask.<>f__mg$cache14);
		if (Lua_BlackJack_ProjectL_UI_ClimbTowerLevelInfoUITask.<>f__mg$cache15 == null)
		{
			Lua_BlackJack_ProjectL_UI_ClimbTowerLevelInfoUITask.<>f__mg$cache15 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ClimbTowerLevelInfoUITask.__callBase_ClearAssetList);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_ClimbTowerLevelInfoUITask.<>f__mg$cache15);
		if (Lua_BlackJack_ProjectL_UI_ClimbTowerLevelInfoUITask.<>f__mg$cache16 == null)
		{
			Lua_BlackJack_ProjectL_UI_ClimbTowerLevelInfoUITask.<>f__mg$cache16 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ClimbTowerLevelInfoUITask.__callBase_CollectAsset);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_ClimbTowerLevelInfoUITask.<>f__mg$cache16);
		if (Lua_BlackJack_ProjectL_UI_ClimbTowerLevelInfoUITask.<>f__mg$cache17 == null)
		{
			Lua_BlackJack_ProjectL_UI_ClimbTowerLevelInfoUITask.<>f__mg$cache17 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ClimbTowerLevelInfoUITask.__callBase_CollectSpriteAsset);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_ClimbTowerLevelInfoUITask.<>f__mg$cache17);
		if (Lua_BlackJack_ProjectL_UI_ClimbTowerLevelInfoUITask.<>f__mg$cache18 == null)
		{
			Lua_BlackJack_ProjectL_UI_ClimbTowerLevelInfoUITask.<>f__mg$cache18 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ClimbTowerLevelInfoUITask.__callBase_CollectFxAsset);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_ClimbTowerLevelInfoUITask.<>f__mg$cache18);
		if (Lua_BlackJack_ProjectL_UI_ClimbTowerLevelInfoUITask.<>f__mg$cache19 == null)
		{
			Lua_BlackJack_ProjectL_UI_ClimbTowerLevelInfoUITask.<>f__mg$cache19 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ClimbTowerLevelInfoUITask.__callBase_StartLoadCustomAssets);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_ClimbTowerLevelInfoUITask.<>f__mg$cache19);
		if (Lua_BlackJack_ProjectL_UI_ClimbTowerLevelInfoUITask.<>f__mg$cache1A == null)
		{
			Lua_BlackJack_ProjectL_UI_ClimbTowerLevelInfoUITask.<>f__mg$cache1A = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ClimbTowerLevelInfoUITask.__callBase_IsLoadingCustomAssets);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_ClimbTowerLevelInfoUITask.<>f__mg$cache1A);
		if (Lua_BlackJack_ProjectL_UI_ClimbTowerLevelInfoUITask.<>f__mg$cache1B == null)
		{
			Lua_BlackJack_ProjectL_UI_ClimbTowerLevelInfoUITask.<>f__mg$cache1B = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ClimbTowerLevelInfoUITask.__callBase_IsPipeLineRunning);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_ClimbTowerLevelInfoUITask.<>f__mg$cache1B);
		if (Lua_BlackJack_ProjectL_UI_ClimbTowerLevelInfoUITask.<>f__mg$cache1C == null)
		{
			Lua_BlackJack_ProjectL_UI_ClimbTowerLevelInfoUITask.<>f__mg$cache1C = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ClimbTowerLevelInfoUITask.__callBase_IsOpeningUI);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_ClimbTowerLevelInfoUITask.<>f__mg$cache1C);
		if (Lua_BlackJack_ProjectL_UI_ClimbTowerLevelInfoUITask.<>f__mg$cache1D == null)
		{
			Lua_BlackJack_ProjectL_UI_ClimbTowerLevelInfoUITask.<>f__mg$cache1D = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ClimbTowerLevelInfoUITask.__callBase_ReturnPrevUITask);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_ClimbTowerLevelInfoUITask.<>f__mg$cache1D);
		if (Lua_BlackJack_ProjectL_UI_ClimbTowerLevelInfoUITask.<>f__mg$cache1E == null)
		{
			Lua_BlackJack_ProjectL_UI_ClimbTowerLevelInfoUITask.<>f__mg$cache1E = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ClimbTowerLevelInfoUITask.__callBase_ClearUnusedDynamicResourceCache);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_ClimbTowerLevelInfoUITask.<>f__mg$cache1E);
		if (Lua_BlackJack_ProjectL_UI_ClimbTowerLevelInfoUITask.<>f__mg$cache1F == null)
		{
			Lua_BlackJack_ProjectL_UI_ClimbTowerLevelInfoUITask.<>f__mg$cache1F = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ClimbTowerLevelInfoUITask.__callBase_OnMemoryWarning);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_ClimbTowerLevelInfoUITask.<>f__mg$cache1F);
		if (Lua_BlackJack_ProjectL_UI_ClimbTowerLevelInfoUITask.<>f__mg$cache20 == null)
		{
			Lua_BlackJack_ProjectL_UI_ClimbTowerLevelInfoUITask.<>f__mg$cache20 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ClimbTowerLevelInfoUITask.__callDele_EventOnClose);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_ClimbTowerLevelInfoUITask.<>f__mg$cache20);
		if (Lua_BlackJack_ProjectL_UI_ClimbTowerLevelInfoUITask.<>f__mg$cache21 == null)
		{
			Lua_BlackJack_ProjectL_UI_ClimbTowerLevelInfoUITask.<>f__mg$cache21 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ClimbTowerLevelInfoUITask.__clearDele_EventOnClose);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_ClimbTowerLevelInfoUITask.<>f__mg$cache21);
		string name = "EventOnClose";
		LuaCSFunction get = null;
		if (Lua_BlackJack_ProjectL_UI_ClimbTowerLevelInfoUITask.<>f__mg$cache22 == null)
		{
			Lua_BlackJack_ProjectL_UI_ClimbTowerLevelInfoUITask.<>f__mg$cache22 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ClimbTowerLevelInfoUITask.set_EventOnClose);
		}
		LuaObject.addMember(l, name, get, Lua_BlackJack_ProjectL_UI_ClimbTowerLevelInfoUITask.<>f__mg$cache22, true);
		string name2 = "m_layerDescArray";
		if (Lua_BlackJack_ProjectL_UI_ClimbTowerLevelInfoUITask.<>f__mg$cache23 == null)
		{
			Lua_BlackJack_ProjectL_UI_ClimbTowerLevelInfoUITask.<>f__mg$cache23 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ClimbTowerLevelInfoUITask.get_m_layerDescArray);
		}
		LuaCSFunction get2 = Lua_BlackJack_ProjectL_UI_ClimbTowerLevelInfoUITask.<>f__mg$cache23;
		if (Lua_BlackJack_ProjectL_UI_ClimbTowerLevelInfoUITask.<>f__mg$cache24 == null)
		{
			Lua_BlackJack_ProjectL_UI_ClimbTowerLevelInfoUITask.<>f__mg$cache24 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ClimbTowerLevelInfoUITask.set_m_layerDescArray);
		}
		LuaObject.addMember(l, name2, get2, Lua_BlackJack_ProjectL_UI_ClimbTowerLevelInfoUITask.<>f__mg$cache24, true);
		string name3 = "m_uiCtrlDescArray";
		if (Lua_BlackJack_ProjectL_UI_ClimbTowerLevelInfoUITask.<>f__mg$cache25 == null)
		{
			Lua_BlackJack_ProjectL_UI_ClimbTowerLevelInfoUITask.<>f__mg$cache25 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ClimbTowerLevelInfoUITask.get_m_uiCtrlDescArray);
		}
		LuaCSFunction get3 = Lua_BlackJack_ProjectL_UI_ClimbTowerLevelInfoUITask.<>f__mg$cache25;
		if (Lua_BlackJack_ProjectL_UI_ClimbTowerLevelInfoUITask.<>f__mg$cache26 == null)
		{
			Lua_BlackJack_ProjectL_UI_ClimbTowerLevelInfoUITask.<>f__mg$cache26 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ClimbTowerLevelInfoUITask.set_m_uiCtrlDescArray);
		}
		LuaObject.addMember(l, name3, get3, Lua_BlackJack_ProjectL_UI_ClimbTowerLevelInfoUITask.<>f__mg$cache26, true);
		string name4 = "m_climbTowerLevelInfoUIController";
		if (Lua_BlackJack_ProjectL_UI_ClimbTowerLevelInfoUITask.<>f__mg$cache27 == null)
		{
			Lua_BlackJack_ProjectL_UI_ClimbTowerLevelInfoUITask.<>f__mg$cache27 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ClimbTowerLevelInfoUITask.get_m_climbTowerLevelInfoUIController);
		}
		LuaCSFunction get4 = Lua_BlackJack_ProjectL_UI_ClimbTowerLevelInfoUITask.<>f__mg$cache27;
		if (Lua_BlackJack_ProjectL_UI_ClimbTowerLevelInfoUITask.<>f__mg$cache28 == null)
		{
			Lua_BlackJack_ProjectL_UI_ClimbTowerLevelInfoUITask.<>f__mg$cache28 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ClimbTowerLevelInfoUITask.set_m_climbTowerLevelInfoUIController);
		}
		LuaObject.addMember(l, name4, get4, Lua_BlackJack_ProjectL_UI_ClimbTowerLevelInfoUITask.<>f__mg$cache28, true);
		string name5 = "m_towerFloorInfo";
		if (Lua_BlackJack_ProjectL_UI_ClimbTowerLevelInfoUITask.<>f__mg$cache29 == null)
		{
			Lua_BlackJack_ProjectL_UI_ClimbTowerLevelInfoUITask.<>f__mg$cache29 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ClimbTowerLevelInfoUITask.get_m_towerFloorInfo);
		}
		LuaCSFunction get5 = Lua_BlackJack_ProjectL_UI_ClimbTowerLevelInfoUITask.<>f__mg$cache29;
		if (Lua_BlackJack_ProjectL_UI_ClimbTowerLevelInfoUITask.<>f__mg$cache2A == null)
		{
			Lua_BlackJack_ProjectL_UI_ClimbTowerLevelInfoUITask.<>f__mg$cache2A = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ClimbTowerLevelInfoUITask.set_m_towerFloorInfo);
		}
		LuaObject.addMember(l, name5, get5, Lua_BlackJack_ProjectL_UI_ClimbTowerLevelInfoUITask.<>f__mg$cache2A, true);
		string name6 = "m_towerLevelInfo";
		if (Lua_BlackJack_ProjectL_UI_ClimbTowerLevelInfoUITask.<>f__mg$cache2B == null)
		{
			Lua_BlackJack_ProjectL_UI_ClimbTowerLevelInfoUITask.<>f__mg$cache2B = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ClimbTowerLevelInfoUITask.get_m_towerLevelInfo);
		}
		LuaCSFunction get6 = Lua_BlackJack_ProjectL_UI_ClimbTowerLevelInfoUITask.<>f__mg$cache2B;
		if (Lua_BlackJack_ProjectL_UI_ClimbTowerLevelInfoUITask.<>f__mg$cache2C == null)
		{
			Lua_BlackJack_ProjectL_UI_ClimbTowerLevelInfoUITask.<>f__mg$cache2C = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ClimbTowerLevelInfoUITask.set_m_towerLevelInfo);
		}
		LuaObject.addMember(l, name6, get6, Lua_BlackJack_ProjectL_UI_ClimbTowerLevelInfoUITask.<>f__mg$cache2C, true);
		string name7 = "m_towerBattleRuleInfo";
		if (Lua_BlackJack_ProjectL_UI_ClimbTowerLevelInfoUITask.<>f__mg$cache2D == null)
		{
			Lua_BlackJack_ProjectL_UI_ClimbTowerLevelInfoUITask.<>f__mg$cache2D = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ClimbTowerLevelInfoUITask.get_m_towerBattleRuleInfo);
		}
		LuaCSFunction get7 = Lua_BlackJack_ProjectL_UI_ClimbTowerLevelInfoUITask.<>f__mg$cache2D;
		if (Lua_BlackJack_ProjectL_UI_ClimbTowerLevelInfoUITask.<>f__mg$cache2E == null)
		{
			Lua_BlackJack_ProjectL_UI_ClimbTowerLevelInfoUITask.<>f__mg$cache2E = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ClimbTowerLevelInfoUITask.set_m_towerBattleRuleInfo);
		}
		LuaObject.addMember(l, name7, get7, Lua_BlackJack_ProjectL_UI_ClimbTowerLevelInfoUITask.<>f__mg$cache2E, true);
		string name8 = "m_towerBonusHeroGroupInfo";
		if (Lua_BlackJack_ProjectL_UI_ClimbTowerLevelInfoUITask.<>f__mg$cache2F == null)
		{
			Lua_BlackJack_ProjectL_UI_ClimbTowerLevelInfoUITask.<>f__mg$cache2F = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ClimbTowerLevelInfoUITask.get_m_towerBonusHeroGroupInfo);
		}
		LuaCSFunction get8 = Lua_BlackJack_ProjectL_UI_ClimbTowerLevelInfoUITask.<>f__mg$cache2F;
		if (Lua_BlackJack_ProjectL_UI_ClimbTowerLevelInfoUITask.<>f__mg$cache30 == null)
		{
			Lua_BlackJack_ProjectL_UI_ClimbTowerLevelInfoUITask.<>f__mg$cache30 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ClimbTowerLevelInfoUITask.set_m_towerBonusHeroGroupInfo);
		}
		LuaObject.addMember(l, name8, get8, Lua_BlackJack_ProjectL_UI_ClimbTowerLevelInfoUITask.<>f__mg$cache30, true);
		string name9 = "LayerDescArray";
		if (Lua_BlackJack_ProjectL_UI_ClimbTowerLevelInfoUITask.<>f__mg$cache31 == null)
		{
			Lua_BlackJack_ProjectL_UI_ClimbTowerLevelInfoUITask.<>f__mg$cache31 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ClimbTowerLevelInfoUITask.get_LayerDescArray);
		}
		LuaObject.addMember(l, name9, Lua_BlackJack_ProjectL_UI_ClimbTowerLevelInfoUITask.<>f__mg$cache31, null, true);
		string name10 = "UICtrlDescArray";
		if (Lua_BlackJack_ProjectL_UI_ClimbTowerLevelInfoUITask.<>f__mg$cache32 == null)
		{
			Lua_BlackJack_ProjectL_UI_ClimbTowerLevelInfoUITask.<>f__mg$cache32 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ClimbTowerLevelInfoUITask.get_UICtrlDescArray);
		}
		LuaObject.addMember(l, name10, Lua_BlackJack_ProjectL_UI_ClimbTowerLevelInfoUITask.<>f__mg$cache32, null, true);
		if (Lua_BlackJack_ProjectL_UI_ClimbTowerLevelInfoUITask.<>f__mg$cache33 == null)
		{
			Lua_BlackJack_ProjectL_UI_ClimbTowerLevelInfoUITask.<>f__mg$cache33 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ClimbTowerLevelInfoUITask.constructor);
		}
		LuaObject.createTypeMetatable(l, Lua_BlackJack_ProjectL_UI_ClimbTowerLevelInfoUITask.<>f__mg$cache33, typeof(ClimbTowerLevelInfoUITask), typeof(UITask));
	}

	// Token: 0x04012D7F RID: 77183
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache0;

	// Token: 0x04012D80 RID: 77184
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1;

	// Token: 0x04012D81 RID: 77185
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2;

	// Token: 0x04012D82 RID: 77186
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3;

	// Token: 0x04012D83 RID: 77187
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache4;

	// Token: 0x04012D84 RID: 77188
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache5;

	// Token: 0x04012D85 RID: 77189
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache6;

	// Token: 0x04012D86 RID: 77190
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache7;

	// Token: 0x04012D87 RID: 77191
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache8;

	// Token: 0x04012D88 RID: 77192
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache9;

	// Token: 0x04012D89 RID: 77193
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheA;

	// Token: 0x04012D8A RID: 77194
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheB;

	// Token: 0x04012D8B RID: 77195
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheC;

	// Token: 0x04012D8C RID: 77196
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheD;

	// Token: 0x04012D8D RID: 77197
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheE;

	// Token: 0x04012D8E RID: 77198
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheF;

	// Token: 0x04012D8F RID: 77199
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache10;

	// Token: 0x04012D90 RID: 77200
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache11;

	// Token: 0x04012D91 RID: 77201
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache12;

	// Token: 0x04012D92 RID: 77202
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache13;

	// Token: 0x04012D93 RID: 77203
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache14;

	// Token: 0x04012D94 RID: 77204
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache15;

	// Token: 0x04012D95 RID: 77205
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache16;

	// Token: 0x04012D96 RID: 77206
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache17;

	// Token: 0x04012D97 RID: 77207
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache18;

	// Token: 0x04012D98 RID: 77208
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache19;

	// Token: 0x04012D99 RID: 77209
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1A;

	// Token: 0x04012D9A RID: 77210
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1B;

	// Token: 0x04012D9B RID: 77211
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1C;

	// Token: 0x04012D9C RID: 77212
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1D;

	// Token: 0x04012D9D RID: 77213
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1E;

	// Token: 0x04012D9E RID: 77214
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1F;

	// Token: 0x04012D9F RID: 77215
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache20;

	// Token: 0x04012DA0 RID: 77216
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache21;

	// Token: 0x04012DA1 RID: 77217
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache22;

	// Token: 0x04012DA2 RID: 77218
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache23;

	// Token: 0x04012DA3 RID: 77219
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache24;

	// Token: 0x04012DA4 RID: 77220
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache25;

	// Token: 0x04012DA5 RID: 77221
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache26;

	// Token: 0x04012DA6 RID: 77222
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache27;

	// Token: 0x04012DA7 RID: 77223
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache28;

	// Token: 0x04012DA8 RID: 77224
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache29;

	// Token: 0x04012DA9 RID: 77225
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2A;

	// Token: 0x04012DAA RID: 77226
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2B;

	// Token: 0x04012DAB RID: 77227
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2C;

	// Token: 0x04012DAC RID: 77228
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2D;

	// Token: 0x04012DAD RID: 77229
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2E;

	// Token: 0x04012DAE RID: 77230
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2F;

	// Token: 0x04012DAF RID: 77231
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache30;

	// Token: 0x04012DB0 RID: 77232
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache31;

	// Token: 0x04012DB1 RID: 77233
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache32;

	// Token: 0x04012DB2 RID: 77234
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache33;
}
