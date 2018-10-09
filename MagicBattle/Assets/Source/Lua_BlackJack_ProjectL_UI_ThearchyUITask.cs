using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using BlackJack.BJFramework.Runtime.UI;
using BlackJack.ConfigData;
using BlackJack.ProjectL.UI;
using SLua;
using UnityEngine.Scripting;

// Token: 0x020015B3 RID: 5555
[Preserve]
public class Lua_BlackJack_ProjectL_UI_ThearchyUITask : LuaObject
{
	// Token: 0x06021BDC RID: 138204 RVA: 0x00B753EC File Offset: 0x00B735EC
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int constructor(IntPtr l)
	{
		int result;
		try
		{
			string name;
			LuaObject.checkType(l, 2, out name);
			ThearchyUITask o = new ThearchyUITask(name);
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

	// Token: 0x06021BDD RID: 138205 RVA: 0x00B75440 File Offset: 0x00B73640
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int OnStart(IntPtr l)
	{
		int result;
		try
		{
			ThearchyUITask thearchyUITask = (ThearchyUITask)LuaObject.checkSelf(l);
			UIIntent intent;
			LuaObject.checkType<UIIntent>(l, 2, out intent);
			bool b = thearchyUITask.m_luaExportHelper.OnStart(intent);
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

	// Token: 0x06021BDE RID: 138206 RVA: 0x00B754A8 File Offset: 0x00B736A8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int OnResume(IntPtr l)
	{
		int result;
		try
		{
			ThearchyUITask thearchyUITask = (ThearchyUITask)LuaObject.checkSelf(l);
			UIIntent intent;
			LuaObject.checkType<UIIntent>(l, 2, out intent);
			bool b = thearchyUITask.m_luaExportHelper.OnResume(intent);
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

	// Token: 0x06021BDF RID: 138207 RVA: 0x00B75510 File Offset: 0x00B73710
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int InitDataFromUIIntent(IntPtr l)
	{
		int result;
		try
		{
			ThearchyUITask thearchyUITask = (ThearchyUITask)LuaObject.checkSelf(l);
			UIIntent intent;
			LuaObject.checkType<UIIntent>(l, 2, out intent);
			thearchyUITask.m_luaExportHelper.InitDataFromUIIntent(intent);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06021BE0 RID: 138208 RVA: 0x00B7556C File Offset: 0x00B7376C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int IsNeedLoadDynamicRes(IntPtr l)
	{
		int result;
		try
		{
			ThearchyUITask thearchyUITask = (ThearchyUITask)LuaObject.checkSelf(l);
			bool b = thearchyUITask.m_luaExportHelper.IsNeedLoadDynamicRes();
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

	// Token: 0x06021BE1 RID: 138209 RVA: 0x00B755C8 File Offset: 0x00B737C8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int InitAllUIControllers(IntPtr l)
	{
		int result;
		try
		{
			ThearchyUITask thearchyUITask = (ThearchyUITask)LuaObject.checkSelf(l);
			thearchyUITask.m_luaExportHelper.InitAllUIControllers();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06021BE2 RID: 138210 RVA: 0x00B7561C File Offset: 0x00B7381C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int ClearAllContextAndRes(IntPtr l)
	{
		int result;
		try
		{
			ThearchyUITask thearchyUITask = (ThearchyUITask)LuaObject.checkSelf(l);
			thearchyUITask.m_luaExportHelper.ClearAllContextAndRes();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06021BE3 RID: 138211 RVA: 0x00B75670 File Offset: 0x00B73870
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int InitThearchyUIController(IntPtr l)
	{
		int result;
		try
		{
			ThearchyUITask thearchyUITask = (ThearchyUITask)LuaObject.checkSelf(l);
			thearchyUITask.m_luaExportHelper.InitThearchyUIController();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06021BE4 RID: 138212 RVA: 0x00B756C4 File Offset: 0x00B738C4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int UninitThearchyUIController(IntPtr l)
	{
		int result;
		try
		{
			ThearchyUITask thearchyUITask = (ThearchyUITask)LuaObject.checkSelf(l);
			thearchyUITask.m_luaExportHelper.UninitThearchyUIController();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06021BE5 RID: 138213 RVA: 0x00B75718 File Offset: 0x00B73918
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int UpdateView(IntPtr l)
	{
		int result;
		try
		{
			ThearchyUITask thearchyUITask = (ThearchyUITask)LuaObject.checkSelf(l);
			thearchyUITask.m_luaExportHelper.UpdateView();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06021BE6 RID: 138214 RVA: 0x00B7576C File Offset: 0x00B7396C
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int ThearchyUIController_OnReturn(IntPtr l)
	{
		int result;
		try
		{
			ThearchyUITask thearchyUITask = (ThearchyUITask)LuaObject.checkSelf(l);
			thearchyUITask.m_luaExportHelper.ThearchyUIController_OnReturn();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06021BE7 RID: 138215 RVA: 0x00B757C0 File Offset: 0x00B739C0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int ThearchyUIController_OnShowHelp(IntPtr l)
	{
		int result;
		try
		{
			ThearchyUITask thearchyUITask = (ThearchyUITask)LuaObject.checkSelf(l);
			thearchyUITask.m_luaExportHelper.ThearchyUIController_OnShowHelp();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06021BE8 RID: 138216 RVA: 0x00B75814 File Offset: 0x00B73A14
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int ThearchyUIController_OnAddTicket(IntPtr l)
	{
		int result;
		try
		{
			ThearchyUITask thearchyUITask = (ThearchyUITask)LuaObject.checkSelf(l);
			thearchyUITask.m_luaExportHelper.ThearchyUIController_OnAddTicket();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06021BE9 RID: 138217 RVA: 0x00B75868 File Offset: 0x00B73A68
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int ThearchyUIController_OnShowTeam(IntPtr l)
	{
		int result;
		try
		{
			ThearchyUITask thearchyUITask = (ThearchyUITask)LuaObject.checkSelf(l);
			thearchyUITask.m_luaExportHelper.ThearchyUIController_OnShowTeam();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06021BEA RID: 138218 RVA: 0x00B758BC File Offset: 0x00B73ABC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int TeamUITask_OnLoadAllResCompleted(IntPtr l)
	{
		int result;
		try
		{
			ThearchyUITask thearchyUITask = (ThearchyUITask)LuaObject.checkSelf(l);
			thearchyUITask.m_luaExportHelper.TeamUITask_OnLoadAllResCompleted();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06021BEB RID: 138219 RVA: 0x00B75910 File Offset: 0x00B73B10
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int ThearchyUIController_OnStartThearchyLevel(IntPtr l)
	{
		int result;
		try
		{
			ThearchyUITask thearchyUITask = (ThearchyUITask)LuaObject.checkSelf(l);
			ConfigDataThearchyTrialLevelInfo levelInfo;
			LuaObject.checkType<ConfigDataThearchyTrialLevelInfo>(l, 2, out levelInfo);
			thearchyUITask.m_luaExportHelper.ThearchyUIController_OnStartThearchyLevel(levelInfo);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06021BEC RID: 138220 RVA: 0x00B7596C File Offset: 0x00B73B6C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_OnStart(IntPtr l)
	{
		int result;
		try
		{
			ThearchyUITask thearchyUITask = (ThearchyUITask)LuaObject.checkSelf(l);
			UIIntent intent;
			LuaObject.checkType<UIIntent>(l, 2, out intent);
			bool b = thearchyUITask.m_luaExportHelper.__callBase_OnStart(intent);
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

	// Token: 0x06021BED RID: 138221 RVA: 0x00B759D4 File Offset: 0x00B73BD4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_OnStop(IntPtr l)
	{
		int result;
		try
		{
			ThearchyUITask thearchyUITask = (ThearchyUITask)LuaObject.checkSelf(l);
			thearchyUITask.m_luaExportHelper.__callBase_OnStop();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06021BEE RID: 138222 RVA: 0x00B75A28 File Offset: 0x00B73C28
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_OnPause(IntPtr l)
	{
		int result;
		try
		{
			ThearchyUITask thearchyUITask = (ThearchyUITask)LuaObject.checkSelf(l);
			thearchyUITask.m_luaExportHelper.__callBase_OnPause();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06021BEF RID: 138223 RVA: 0x00B75A7C File Offset: 0x00B73C7C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_OnResume(IntPtr l)
	{
		int result;
		try
		{
			ThearchyUITask thearchyUITask = (ThearchyUITask)LuaObject.checkSelf(l);
			UIIntent intent;
			LuaObject.checkType<UIIntent>(l, 2, out intent);
			bool b = thearchyUITask.m_luaExportHelper.__callBase_OnResume(intent);
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

	// Token: 0x06021BF0 RID: 138224 RVA: 0x00B75AE4 File Offset: 0x00B73CE4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_OnNewIntent(IntPtr l)
	{
		int result;
		try
		{
			ThearchyUITask thearchyUITask = (ThearchyUITask)LuaObject.checkSelf(l);
			UIIntent intent;
			LuaObject.checkType<UIIntent>(l, 2, out intent);
			bool b = thearchyUITask.m_luaExportHelper.__callBase_OnNewIntent(intent);
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

	// Token: 0x06021BF1 RID: 138225 RVA: 0x00B75B4C File Offset: 0x00B73D4C
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int __callBase_EnableUIInput(IntPtr l)
	{
		int result;
		try
		{
			ThearchyUITask thearchyUITask = (ThearchyUITask)LuaObject.checkSelf(l);
			bool isEnable;
			LuaObject.checkType(l, 2, out isEnable);
			bool? isGlobalEnable;
			LuaObject.checkNullable<bool>(l, 3, out isGlobalEnable);
			thearchyUITask.m_luaExportHelper.__callBase_EnableUIInput(isEnable, isGlobalEnable);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06021BF2 RID: 138226 RVA: 0x00B75BB8 File Offset: 0x00B73DB8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_IsNeedLoadDynamicRes(IntPtr l)
	{
		int result;
		try
		{
			ThearchyUITask thearchyUITask = (ThearchyUITask)LuaObject.checkSelf(l);
			bool b = thearchyUITask.m_luaExportHelper.__callBase_IsNeedLoadDynamicRes();
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

	// Token: 0x06021BF3 RID: 138227 RVA: 0x00B75C14 File Offset: 0x00B73E14
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_CollectAllDynamicResForLoad(IntPtr l)
	{
		int result;
		try
		{
			ThearchyUITask thearchyUITask = (ThearchyUITask)LuaObject.checkSelf(l);
			List<string> o = thearchyUITask.m_luaExportHelper.__callBase_CollectAllDynamicResForLoad();
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

	// Token: 0x06021BF4 RID: 138228 RVA: 0x00B75C70 File Offset: 0x00B73E70
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_RegisterPlayerContextEvents(IntPtr l)
	{
		int result;
		try
		{
			ThearchyUITask thearchyUITask = (ThearchyUITask)LuaObject.checkSelf(l);
			thearchyUITask.m_luaExportHelper.__callBase_RegisterPlayerContextEvents();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06021BF5 RID: 138229 RVA: 0x00B75CC4 File Offset: 0x00B73EC4
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int __callBase_UnregisterPlayerContextEvents(IntPtr l)
	{
		int result;
		try
		{
			ThearchyUITask thearchyUITask = (ThearchyUITask)LuaObject.checkSelf(l);
			thearchyUITask.m_luaExportHelper.__callBase_UnregisterPlayerContextEvents();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06021BF6 RID: 138230 RVA: 0x00B75D18 File Offset: 0x00B73F18
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_PostUpdateView(IntPtr l)
	{
		int result;
		try
		{
			ThearchyUITask thearchyUITask = (ThearchyUITask)LuaObject.checkSelf(l);
			thearchyUITask.m_luaExportHelper.__callBase_PostUpdateView();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06021BF7 RID: 138231 RVA: 0x00B75D6C File Offset: 0x00B73F6C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_CollectPreloadResourceList(IntPtr l)
	{
		int result;
		try
		{
			ThearchyUITask thearchyUITask = (ThearchyUITask)LuaObject.checkSelf(l);
			thearchyUITask.m_luaExportHelper.__callBase_CollectPreloadResourceList();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06021BF8 RID: 138232 RVA: 0x00B75DC0 File Offset: 0x00B73FC0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_ClearAssetList(IntPtr l)
	{
		int result;
		try
		{
			ThearchyUITask thearchyUITask = (ThearchyUITask)LuaObject.checkSelf(l);
			thearchyUITask.m_luaExportHelper.__callBase_ClearAssetList();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06021BF9 RID: 138233 RVA: 0x00B75E14 File Offset: 0x00B74014
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_CollectAsset(IntPtr l)
	{
		int result;
		try
		{
			ThearchyUITask thearchyUITask = (ThearchyUITask)LuaObject.checkSelf(l);
			string assetName;
			LuaObject.checkType(l, 2, out assetName);
			thearchyUITask.m_luaExportHelper.__callBase_CollectAsset(assetName);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06021BFA RID: 138234 RVA: 0x00B75E70 File Offset: 0x00B74070
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_CollectSpriteAsset(IntPtr l)
	{
		int result;
		try
		{
			ThearchyUITask thearchyUITask = (ThearchyUITask)LuaObject.checkSelf(l);
			string assetName;
			LuaObject.checkType(l, 2, out assetName);
			thearchyUITask.m_luaExportHelper.__callBase_CollectSpriteAsset(assetName);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06021BFB RID: 138235 RVA: 0x00B75ECC File Offset: 0x00B740CC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_CollectFxAsset(IntPtr l)
	{
		int result;
		try
		{
			ThearchyUITask thearchyUITask = (ThearchyUITask)LuaObject.checkSelf(l);
			string assetName;
			LuaObject.checkType(l, 2, out assetName);
			thearchyUITask.m_luaExportHelper.__callBase_CollectFxAsset(assetName);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06021BFC RID: 138236 RVA: 0x00B75F28 File Offset: 0x00B74128
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_StartLoadCustomAssets(IntPtr l)
	{
		int result;
		try
		{
			ThearchyUITask thearchyUITask = (ThearchyUITask)LuaObject.checkSelf(l);
			Action onLoadCompleted;
			LuaObject.checkDelegate<Action>(l, 2, out onLoadCompleted);
			thearchyUITask.m_luaExportHelper.__callBase_StartLoadCustomAssets(onLoadCompleted);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06021BFD RID: 138237 RVA: 0x00B75F84 File Offset: 0x00B74184
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_IsLoadingCustomAssets(IntPtr l)
	{
		int result;
		try
		{
			ThearchyUITask thearchyUITask = (ThearchyUITask)LuaObject.checkSelf(l);
			bool b = thearchyUITask.m_luaExportHelper.__callBase_IsLoadingCustomAssets();
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

	// Token: 0x06021BFE RID: 138238 RVA: 0x00B75FE0 File Offset: 0x00B741E0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_IsPipeLineRunning(IntPtr l)
	{
		int result;
		try
		{
			ThearchyUITask thearchyUITask = (ThearchyUITask)LuaObject.checkSelf(l);
			bool b = thearchyUITask.m_luaExportHelper.__callBase_IsPipeLineRunning();
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

	// Token: 0x06021BFF RID: 138239 RVA: 0x00B7603C File Offset: 0x00B7423C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_IsOpeningUI(IntPtr l)
	{
		int result;
		try
		{
			ThearchyUITask thearchyUITask = (ThearchyUITask)LuaObject.checkSelf(l);
			bool b = thearchyUITask.m_luaExportHelper.__callBase_IsOpeningUI();
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

	// Token: 0x06021C00 RID: 138240 RVA: 0x00B76098 File Offset: 0x00B74298
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_ReturnPrevUITask(IntPtr l)
	{
		int result;
		try
		{
			ThearchyUITask thearchyUITask = (ThearchyUITask)LuaObject.checkSelf(l);
			UITaskBase o = thearchyUITask.m_luaExportHelper.__callBase_ReturnPrevUITask();
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

	// Token: 0x06021C01 RID: 138241 RVA: 0x00B760F4 File Offset: 0x00B742F4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_ClearUnusedDynamicResourceCache(IntPtr l)
	{
		int result;
		try
		{
			ThearchyUITask thearchyUITask = (ThearchyUITask)LuaObject.checkSelf(l);
			thearchyUITask.m_luaExportHelper.__callBase_ClearUnusedDynamicResourceCache();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06021C02 RID: 138242 RVA: 0x00B76148 File Offset: 0x00B74348
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_OnMemoryWarning(IntPtr l)
	{
		int result;
		try
		{
			ThearchyUITask thearchyUITask = (ThearchyUITask)LuaObject.checkSelf(l);
			thearchyUITask.m_luaExportHelper.__callBase_OnMemoryWarning();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06021C03 RID: 138243 RVA: 0x00B7619C File Offset: 0x00B7439C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_layerDescArray(IntPtr l)
	{
		int result;
		try
		{
			ThearchyUITask thearchyUITask = (ThearchyUITask)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, thearchyUITask.m_luaExportHelper.m_layerDescArray);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06021C04 RID: 138244 RVA: 0x00B761F4 File Offset: 0x00B743F4
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_m_layerDescArray(IntPtr l)
	{
		int result;
		try
		{
			ThearchyUITask thearchyUITask = (ThearchyUITask)LuaObject.checkSelf(l);
			UITaskBase.LayerDesc[] layerDescArray;
			LuaObject.checkArray<UITaskBase.LayerDesc>(l, 2, out layerDescArray);
			thearchyUITask.m_luaExportHelper.m_layerDescArray = layerDescArray;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06021C05 RID: 138245 RVA: 0x00B76250 File Offset: 0x00B74450
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_uiCtrlDescArray(IntPtr l)
	{
		int result;
		try
		{
			ThearchyUITask thearchyUITask = (ThearchyUITask)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, thearchyUITask.m_luaExportHelper.m_uiCtrlDescArray);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06021C06 RID: 138246 RVA: 0x00B762A8 File Offset: 0x00B744A8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_uiCtrlDescArray(IntPtr l)
	{
		int result;
		try
		{
			ThearchyUITask thearchyUITask = (ThearchyUITask)LuaObject.checkSelf(l);
			UITaskBase.UIControllerDesc[] uiCtrlDescArray;
			LuaObject.checkArray<UITaskBase.UIControllerDesc>(l, 2, out uiCtrlDescArray);
			thearchyUITask.m_luaExportHelper.m_uiCtrlDescArray = uiCtrlDescArray;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06021C07 RID: 138247 RVA: 0x00B76304 File Offset: 0x00B74504
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_thearchyUIController(IntPtr l)
	{
		int result;
		try
		{
			ThearchyUITask thearchyUITask = (ThearchyUITask)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, thearchyUITask.m_luaExportHelper.m_thearchyUIController);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06021C08 RID: 138248 RVA: 0x00B7635C File Offset: 0x00B7455C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_thearchyUIController(IntPtr l)
	{
		int result;
		try
		{
			ThearchyUITask thearchyUITask = (ThearchyUITask)LuaObject.checkSelf(l);
			ThearchyUIController thearchyUIController;
			LuaObject.checkType<ThearchyUIController>(l, 2, out thearchyUIController);
			thearchyUITask.m_luaExportHelper.m_thearchyUIController = thearchyUIController;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06021C09 RID: 138249 RVA: 0x00B763B8 File Offset: 0x00B745B8
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_m_playerResourceUIController(IntPtr l)
	{
		int result;
		try
		{
			ThearchyUITask thearchyUITask = (ThearchyUITask)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, thearchyUITask.m_luaExportHelper.m_playerResourceUIController);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06021C0A RID: 138250 RVA: 0x00B76410 File Offset: 0x00B74610
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_m_playerResourceUIController(IntPtr l)
	{
		int result;
		try
		{
			ThearchyUITask thearchyUITask = (ThearchyUITask)LuaObject.checkSelf(l);
			PlayerResourceUIController playerResourceUIController;
			LuaObject.checkType<PlayerResourceUIController>(l, 2, out playerResourceUIController);
			thearchyUITask.m_luaExportHelper.m_playerResourceUIController = playerResourceUIController;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06021C0B RID: 138251 RVA: 0x00B7646C File Offset: 0x00B7466C
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_m_thearchyTrialInfo(IntPtr l)
	{
		int result;
		try
		{
			ThearchyUITask thearchyUITask = (ThearchyUITask)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, thearchyUITask.m_luaExportHelper.m_thearchyTrialInfo);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06021C0C RID: 138252 RVA: 0x00B764C4 File Offset: 0x00B746C4
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_m_thearchyTrialInfo(IntPtr l)
	{
		int result;
		try
		{
			ThearchyUITask thearchyUITask = (ThearchyUITask)LuaObject.checkSelf(l);
			ConfigDataThearchyTrialInfo thearchyTrialInfo;
			LuaObject.checkType<ConfigDataThearchyTrialInfo>(l, 2, out thearchyTrialInfo);
			thearchyUITask.m_luaExportHelper.m_thearchyTrialInfo = thearchyTrialInfo;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06021C0D RID: 138253 RVA: 0x00B76520 File Offset: 0x00B74720
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_LayerDescArray(IntPtr l)
	{
		int result;
		try
		{
			ThearchyUITask thearchyUITask = (ThearchyUITask)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, thearchyUITask.m_luaExportHelper.LayerDescArray);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06021C0E RID: 138254 RVA: 0x00B76578 File Offset: 0x00B74778
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_UICtrlDescArray(IntPtr l)
	{
		int result;
		try
		{
			ThearchyUITask thearchyUITask = (ThearchyUITask)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, thearchyUITask.m_luaExportHelper.UICtrlDescArray);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06021C0F RID: 138255 RVA: 0x00B765D0 File Offset: 0x00B747D0
	[Preserve]
	public static void reg(IntPtr l)
	{
		LuaObject.getTypeTable(l, "BlackJack.ProjectL.UI.ThearchyUITask");
		if (Lua_BlackJack_ProjectL_UI_ThearchyUITask.<>f__mg$cache0 == null)
		{
			Lua_BlackJack_ProjectL_UI_ThearchyUITask.<>f__mg$cache0 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ThearchyUITask.OnStart);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_ThearchyUITask.<>f__mg$cache0);
		if (Lua_BlackJack_ProjectL_UI_ThearchyUITask.<>f__mg$cache1 == null)
		{
			Lua_BlackJack_ProjectL_UI_ThearchyUITask.<>f__mg$cache1 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ThearchyUITask.OnResume);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_ThearchyUITask.<>f__mg$cache1);
		if (Lua_BlackJack_ProjectL_UI_ThearchyUITask.<>f__mg$cache2 == null)
		{
			Lua_BlackJack_ProjectL_UI_ThearchyUITask.<>f__mg$cache2 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ThearchyUITask.InitDataFromUIIntent);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_ThearchyUITask.<>f__mg$cache2);
		if (Lua_BlackJack_ProjectL_UI_ThearchyUITask.<>f__mg$cache3 == null)
		{
			Lua_BlackJack_ProjectL_UI_ThearchyUITask.<>f__mg$cache3 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ThearchyUITask.IsNeedLoadDynamicRes);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_ThearchyUITask.<>f__mg$cache3);
		if (Lua_BlackJack_ProjectL_UI_ThearchyUITask.<>f__mg$cache4 == null)
		{
			Lua_BlackJack_ProjectL_UI_ThearchyUITask.<>f__mg$cache4 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ThearchyUITask.InitAllUIControllers);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_ThearchyUITask.<>f__mg$cache4);
		if (Lua_BlackJack_ProjectL_UI_ThearchyUITask.<>f__mg$cache5 == null)
		{
			Lua_BlackJack_ProjectL_UI_ThearchyUITask.<>f__mg$cache5 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ThearchyUITask.ClearAllContextAndRes);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_ThearchyUITask.<>f__mg$cache5);
		if (Lua_BlackJack_ProjectL_UI_ThearchyUITask.<>f__mg$cache6 == null)
		{
			Lua_BlackJack_ProjectL_UI_ThearchyUITask.<>f__mg$cache6 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ThearchyUITask.InitThearchyUIController);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_ThearchyUITask.<>f__mg$cache6);
		if (Lua_BlackJack_ProjectL_UI_ThearchyUITask.<>f__mg$cache7 == null)
		{
			Lua_BlackJack_ProjectL_UI_ThearchyUITask.<>f__mg$cache7 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ThearchyUITask.UninitThearchyUIController);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_ThearchyUITask.<>f__mg$cache7);
		if (Lua_BlackJack_ProjectL_UI_ThearchyUITask.<>f__mg$cache8 == null)
		{
			Lua_BlackJack_ProjectL_UI_ThearchyUITask.<>f__mg$cache8 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ThearchyUITask.UpdateView);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_ThearchyUITask.<>f__mg$cache8);
		if (Lua_BlackJack_ProjectL_UI_ThearchyUITask.<>f__mg$cache9 == null)
		{
			Lua_BlackJack_ProjectL_UI_ThearchyUITask.<>f__mg$cache9 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ThearchyUITask.ThearchyUIController_OnReturn);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_ThearchyUITask.<>f__mg$cache9);
		if (Lua_BlackJack_ProjectL_UI_ThearchyUITask.<>f__mg$cacheA == null)
		{
			Lua_BlackJack_ProjectL_UI_ThearchyUITask.<>f__mg$cacheA = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ThearchyUITask.ThearchyUIController_OnShowHelp);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_ThearchyUITask.<>f__mg$cacheA);
		if (Lua_BlackJack_ProjectL_UI_ThearchyUITask.<>f__mg$cacheB == null)
		{
			Lua_BlackJack_ProjectL_UI_ThearchyUITask.<>f__mg$cacheB = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ThearchyUITask.ThearchyUIController_OnAddTicket);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_ThearchyUITask.<>f__mg$cacheB);
		if (Lua_BlackJack_ProjectL_UI_ThearchyUITask.<>f__mg$cacheC == null)
		{
			Lua_BlackJack_ProjectL_UI_ThearchyUITask.<>f__mg$cacheC = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ThearchyUITask.ThearchyUIController_OnShowTeam);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_ThearchyUITask.<>f__mg$cacheC);
		if (Lua_BlackJack_ProjectL_UI_ThearchyUITask.<>f__mg$cacheD == null)
		{
			Lua_BlackJack_ProjectL_UI_ThearchyUITask.<>f__mg$cacheD = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ThearchyUITask.TeamUITask_OnLoadAllResCompleted);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_ThearchyUITask.<>f__mg$cacheD);
		if (Lua_BlackJack_ProjectL_UI_ThearchyUITask.<>f__mg$cacheE == null)
		{
			Lua_BlackJack_ProjectL_UI_ThearchyUITask.<>f__mg$cacheE = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ThearchyUITask.ThearchyUIController_OnStartThearchyLevel);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_ThearchyUITask.<>f__mg$cacheE);
		if (Lua_BlackJack_ProjectL_UI_ThearchyUITask.<>f__mg$cacheF == null)
		{
			Lua_BlackJack_ProjectL_UI_ThearchyUITask.<>f__mg$cacheF = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ThearchyUITask.__callBase_OnStart);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_ThearchyUITask.<>f__mg$cacheF);
		if (Lua_BlackJack_ProjectL_UI_ThearchyUITask.<>f__mg$cache10 == null)
		{
			Lua_BlackJack_ProjectL_UI_ThearchyUITask.<>f__mg$cache10 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ThearchyUITask.__callBase_OnStop);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_ThearchyUITask.<>f__mg$cache10);
		if (Lua_BlackJack_ProjectL_UI_ThearchyUITask.<>f__mg$cache11 == null)
		{
			Lua_BlackJack_ProjectL_UI_ThearchyUITask.<>f__mg$cache11 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ThearchyUITask.__callBase_OnPause);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_ThearchyUITask.<>f__mg$cache11);
		if (Lua_BlackJack_ProjectL_UI_ThearchyUITask.<>f__mg$cache12 == null)
		{
			Lua_BlackJack_ProjectL_UI_ThearchyUITask.<>f__mg$cache12 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ThearchyUITask.__callBase_OnResume);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_ThearchyUITask.<>f__mg$cache12);
		if (Lua_BlackJack_ProjectL_UI_ThearchyUITask.<>f__mg$cache13 == null)
		{
			Lua_BlackJack_ProjectL_UI_ThearchyUITask.<>f__mg$cache13 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ThearchyUITask.__callBase_OnNewIntent);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_ThearchyUITask.<>f__mg$cache13);
		if (Lua_BlackJack_ProjectL_UI_ThearchyUITask.<>f__mg$cache14 == null)
		{
			Lua_BlackJack_ProjectL_UI_ThearchyUITask.<>f__mg$cache14 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ThearchyUITask.__callBase_EnableUIInput);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_ThearchyUITask.<>f__mg$cache14);
		if (Lua_BlackJack_ProjectL_UI_ThearchyUITask.<>f__mg$cache15 == null)
		{
			Lua_BlackJack_ProjectL_UI_ThearchyUITask.<>f__mg$cache15 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ThearchyUITask.__callBase_IsNeedLoadDynamicRes);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_ThearchyUITask.<>f__mg$cache15);
		if (Lua_BlackJack_ProjectL_UI_ThearchyUITask.<>f__mg$cache16 == null)
		{
			Lua_BlackJack_ProjectL_UI_ThearchyUITask.<>f__mg$cache16 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ThearchyUITask.__callBase_CollectAllDynamicResForLoad);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_ThearchyUITask.<>f__mg$cache16);
		if (Lua_BlackJack_ProjectL_UI_ThearchyUITask.<>f__mg$cache17 == null)
		{
			Lua_BlackJack_ProjectL_UI_ThearchyUITask.<>f__mg$cache17 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ThearchyUITask.__callBase_RegisterPlayerContextEvents);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_ThearchyUITask.<>f__mg$cache17);
		if (Lua_BlackJack_ProjectL_UI_ThearchyUITask.<>f__mg$cache18 == null)
		{
			Lua_BlackJack_ProjectL_UI_ThearchyUITask.<>f__mg$cache18 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ThearchyUITask.__callBase_UnregisterPlayerContextEvents);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_ThearchyUITask.<>f__mg$cache18);
		if (Lua_BlackJack_ProjectL_UI_ThearchyUITask.<>f__mg$cache19 == null)
		{
			Lua_BlackJack_ProjectL_UI_ThearchyUITask.<>f__mg$cache19 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ThearchyUITask.__callBase_PostUpdateView);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_ThearchyUITask.<>f__mg$cache19);
		if (Lua_BlackJack_ProjectL_UI_ThearchyUITask.<>f__mg$cache1A == null)
		{
			Lua_BlackJack_ProjectL_UI_ThearchyUITask.<>f__mg$cache1A = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ThearchyUITask.__callBase_CollectPreloadResourceList);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_ThearchyUITask.<>f__mg$cache1A);
		if (Lua_BlackJack_ProjectL_UI_ThearchyUITask.<>f__mg$cache1B == null)
		{
			Lua_BlackJack_ProjectL_UI_ThearchyUITask.<>f__mg$cache1B = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ThearchyUITask.__callBase_ClearAssetList);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_ThearchyUITask.<>f__mg$cache1B);
		if (Lua_BlackJack_ProjectL_UI_ThearchyUITask.<>f__mg$cache1C == null)
		{
			Lua_BlackJack_ProjectL_UI_ThearchyUITask.<>f__mg$cache1C = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ThearchyUITask.__callBase_CollectAsset);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_ThearchyUITask.<>f__mg$cache1C);
		if (Lua_BlackJack_ProjectL_UI_ThearchyUITask.<>f__mg$cache1D == null)
		{
			Lua_BlackJack_ProjectL_UI_ThearchyUITask.<>f__mg$cache1D = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ThearchyUITask.__callBase_CollectSpriteAsset);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_ThearchyUITask.<>f__mg$cache1D);
		if (Lua_BlackJack_ProjectL_UI_ThearchyUITask.<>f__mg$cache1E == null)
		{
			Lua_BlackJack_ProjectL_UI_ThearchyUITask.<>f__mg$cache1E = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ThearchyUITask.__callBase_CollectFxAsset);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_ThearchyUITask.<>f__mg$cache1E);
		if (Lua_BlackJack_ProjectL_UI_ThearchyUITask.<>f__mg$cache1F == null)
		{
			Lua_BlackJack_ProjectL_UI_ThearchyUITask.<>f__mg$cache1F = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ThearchyUITask.__callBase_StartLoadCustomAssets);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_ThearchyUITask.<>f__mg$cache1F);
		if (Lua_BlackJack_ProjectL_UI_ThearchyUITask.<>f__mg$cache20 == null)
		{
			Lua_BlackJack_ProjectL_UI_ThearchyUITask.<>f__mg$cache20 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ThearchyUITask.__callBase_IsLoadingCustomAssets);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_ThearchyUITask.<>f__mg$cache20);
		if (Lua_BlackJack_ProjectL_UI_ThearchyUITask.<>f__mg$cache21 == null)
		{
			Lua_BlackJack_ProjectL_UI_ThearchyUITask.<>f__mg$cache21 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ThearchyUITask.__callBase_IsPipeLineRunning);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_ThearchyUITask.<>f__mg$cache21);
		if (Lua_BlackJack_ProjectL_UI_ThearchyUITask.<>f__mg$cache22 == null)
		{
			Lua_BlackJack_ProjectL_UI_ThearchyUITask.<>f__mg$cache22 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ThearchyUITask.__callBase_IsOpeningUI);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_ThearchyUITask.<>f__mg$cache22);
		if (Lua_BlackJack_ProjectL_UI_ThearchyUITask.<>f__mg$cache23 == null)
		{
			Lua_BlackJack_ProjectL_UI_ThearchyUITask.<>f__mg$cache23 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ThearchyUITask.__callBase_ReturnPrevUITask);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_ThearchyUITask.<>f__mg$cache23);
		if (Lua_BlackJack_ProjectL_UI_ThearchyUITask.<>f__mg$cache24 == null)
		{
			Lua_BlackJack_ProjectL_UI_ThearchyUITask.<>f__mg$cache24 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ThearchyUITask.__callBase_ClearUnusedDynamicResourceCache);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_ThearchyUITask.<>f__mg$cache24);
		if (Lua_BlackJack_ProjectL_UI_ThearchyUITask.<>f__mg$cache25 == null)
		{
			Lua_BlackJack_ProjectL_UI_ThearchyUITask.<>f__mg$cache25 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ThearchyUITask.__callBase_OnMemoryWarning);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_ThearchyUITask.<>f__mg$cache25);
		string name = "m_layerDescArray";
		if (Lua_BlackJack_ProjectL_UI_ThearchyUITask.<>f__mg$cache26 == null)
		{
			Lua_BlackJack_ProjectL_UI_ThearchyUITask.<>f__mg$cache26 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ThearchyUITask.get_m_layerDescArray);
		}
		LuaCSFunction get = Lua_BlackJack_ProjectL_UI_ThearchyUITask.<>f__mg$cache26;
		if (Lua_BlackJack_ProjectL_UI_ThearchyUITask.<>f__mg$cache27 == null)
		{
			Lua_BlackJack_ProjectL_UI_ThearchyUITask.<>f__mg$cache27 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ThearchyUITask.set_m_layerDescArray);
		}
		LuaObject.addMember(l, name, get, Lua_BlackJack_ProjectL_UI_ThearchyUITask.<>f__mg$cache27, true);
		string name2 = "m_uiCtrlDescArray";
		if (Lua_BlackJack_ProjectL_UI_ThearchyUITask.<>f__mg$cache28 == null)
		{
			Lua_BlackJack_ProjectL_UI_ThearchyUITask.<>f__mg$cache28 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ThearchyUITask.get_m_uiCtrlDescArray);
		}
		LuaCSFunction get2 = Lua_BlackJack_ProjectL_UI_ThearchyUITask.<>f__mg$cache28;
		if (Lua_BlackJack_ProjectL_UI_ThearchyUITask.<>f__mg$cache29 == null)
		{
			Lua_BlackJack_ProjectL_UI_ThearchyUITask.<>f__mg$cache29 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ThearchyUITask.set_m_uiCtrlDescArray);
		}
		LuaObject.addMember(l, name2, get2, Lua_BlackJack_ProjectL_UI_ThearchyUITask.<>f__mg$cache29, true);
		string name3 = "m_thearchyUIController";
		if (Lua_BlackJack_ProjectL_UI_ThearchyUITask.<>f__mg$cache2A == null)
		{
			Lua_BlackJack_ProjectL_UI_ThearchyUITask.<>f__mg$cache2A = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ThearchyUITask.get_m_thearchyUIController);
		}
		LuaCSFunction get3 = Lua_BlackJack_ProjectL_UI_ThearchyUITask.<>f__mg$cache2A;
		if (Lua_BlackJack_ProjectL_UI_ThearchyUITask.<>f__mg$cache2B == null)
		{
			Lua_BlackJack_ProjectL_UI_ThearchyUITask.<>f__mg$cache2B = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ThearchyUITask.set_m_thearchyUIController);
		}
		LuaObject.addMember(l, name3, get3, Lua_BlackJack_ProjectL_UI_ThearchyUITask.<>f__mg$cache2B, true);
		string name4 = "m_playerResourceUIController";
		if (Lua_BlackJack_ProjectL_UI_ThearchyUITask.<>f__mg$cache2C == null)
		{
			Lua_BlackJack_ProjectL_UI_ThearchyUITask.<>f__mg$cache2C = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ThearchyUITask.get_m_playerResourceUIController);
		}
		LuaCSFunction get4 = Lua_BlackJack_ProjectL_UI_ThearchyUITask.<>f__mg$cache2C;
		if (Lua_BlackJack_ProjectL_UI_ThearchyUITask.<>f__mg$cache2D == null)
		{
			Lua_BlackJack_ProjectL_UI_ThearchyUITask.<>f__mg$cache2D = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ThearchyUITask.set_m_playerResourceUIController);
		}
		LuaObject.addMember(l, name4, get4, Lua_BlackJack_ProjectL_UI_ThearchyUITask.<>f__mg$cache2D, true);
		string name5 = "m_thearchyTrialInfo";
		if (Lua_BlackJack_ProjectL_UI_ThearchyUITask.<>f__mg$cache2E == null)
		{
			Lua_BlackJack_ProjectL_UI_ThearchyUITask.<>f__mg$cache2E = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ThearchyUITask.get_m_thearchyTrialInfo);
		}
		LuaCSFunction get5 = Lua_BlackJack_ProjectL_UI_ThearchyUITask.<>f__mg$cache2E;
		if (Lua_BlackJack_ProjectL_UI_ThearchyUITask.<>f__mg$cache2F == null)
		{
			Lua_BlackJack_ProjectL_UI_ThearchyUITask.<>f__mg$cache2F = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ThearchyUITask.set_m_thearchyTrialInfo);
		}
		LuaObject.addMember(l, name5, get5, Lua_BlackJack_ProjectL_UI_ThearchyUITask.<>f__mg$cache2F, true);
		string name6 = "LayerDescArray";
		if (Lua_BlackJack_ProjectL_UI_ThearchyUITask.<>f__mg$cache30 == null)
		{
			Lua_BlackJack_ProjectL_UI_ThearchyUITask.<>f__mg$cache30 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ThearchyUITask.get_LayerDescArray);
		}
		LuaObject.addMember(l, name6, Lua_BlackJack_ProjectL_UI_ThearchyUITask.<>f__mg$cache30, null, true);
		string name7 = "UICtrlDescArray";
		if (Lua_BlackJack_ProjectL_UI_ThearchyUITask.<>f__mg$cache31 == null)
		{
			Lua_BlackJack_ProjectL_UI_ThearchyUITask.<>f__mg$cache31 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ThearchyUITask.get_UICtrlDescArray);
		}
		LuaObject.addMember(l, name7, Lua_BlackJack_ProjectL_UI_ThearchyUITask.<>f__mg$cache31, null, true);
		if (Lua_BlackJack_ProjectL_UI_ThearchyUITask.<>f__mg$cache32 == null)
		{
			Lua_BlackJack_ProjectL_UI_ThearchyUITask.<>f__mg$cache32 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ThearchyUITask.constructor);
		}
		LuaObject.createTypeMetatable(l, Lua_BlackJack_ProjectL_UI_ThearchyUITask.<>f__mg$cache32, typeof(ThearchyUITask), typeof(UITask));
	}

	// Token: 0x04017A58 RID: 96856
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache0;

	// Token: 0x04017A59 RID: 96857
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1;

	// Token: 0x04017A5A RID: 96858
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2;

	// Token: 0x04017A5B RID: 96859
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3;

	// Token: 0x04017A5C RID: 96860
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache4;

	// Token: 0x04017A5D RID: 96861
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache5;

	// Token: 0x04017A5E RID: 96862
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache6;

	// Token: 0x04017A5F RID: 96863
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache7;

	// Token: 0x04017A60 RID: 96864
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache8;

	// Token: 0x04017A61 RID: 96865
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache9;

	// Token: 0x04017A62 RID: 96866
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheA;

	// Token: 0x04017A63 RID: 96867
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheB;

	// Token: 0x04017A64 RID: 96868
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheC;

	// Token: 0x04017A65 RID: 96869
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheD;

	// Token: 0x04017A66 RID: 96870
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheE;

	// Token: 0x04017A67 RID: 96871
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheF;

	// Token: 0x04017A68 RID: 96872
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache10;

	// Token: 0x04017A69 RID: 96873
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache11;

	// Token: 0x04017A6A RID: 96874
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache12;

	// Token: 0x04017A6B RID: 96875
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache13;

	// Token: 0x04017A6C RID: 96876
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache14;

	// Token: 0x04017A6D RID: 96877
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache15;

	// Token: 0x04017A6E RID: 96878
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache16;

	// Token: 0x04017A6F RID: 96879
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache17;

	// Token: 0x04017A70 RID: 96880
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache18;

	// Token: 0x04017A71 RID: 96881
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache19;

	// Token: 0x04017A72 RID: 96882
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1A;

	// Token: 0x04017A73 RID: 96883
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1B;

	// Token: 0x04017A74 RID: 96884
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1C;

	// Token: 0x04017A75 RID: 96885
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1D;

	// Token: 0x04017A76 RID: 96886
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1E;

	// Token: 0x04017A77 RID: 96887
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1F;

	// Token: 0x04017A78 RID: 96888
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache20;

	// Token: 0x04017A79 RID: 96889
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache21;

	// Token: 0x04017A7A RID: 96890
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache22;

	// Token: 0x04017A7B RID: 96891
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache23;

	// Token: 0x04017A7C RID: 96892
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache24;

	// Token: 0x04017A7D RID: 96893
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache25;

	// Token: 0x04017A7E RID: 96894
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache26;

	// Token: 0x04017A7F RID: 96895
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache27;

	// Token: 0x04017A80 RID: 96896
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache28;

	// Token: 0x04017A81 RID: 96897
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache29;

	// Token: 0x04017A82 RID: 96898
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2A;

	// Token: 0x04017A83 RID: 96899
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2B;

	// Token: 0x04017A84 RID: 96900
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2C;

	// Token: 0x04017A85 RID: 96901
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2D;

	// Token: 0x04017A86 RID: 96902
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2E;

	// Token: 0x04017A87 RID: 96903
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2F;

	// Token: 0x04017A88 RID: 96904
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache30;

	// Token: 0x04017A89 RID: 96905
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache31;

	// Token: 0x04017A8A RID: 96906
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache32;
}
