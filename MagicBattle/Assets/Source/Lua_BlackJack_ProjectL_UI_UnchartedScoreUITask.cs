using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using BlackJack.BJFramework.Runtime.UI;
using BlackJack.ConfigData;
using BlackJack.ProjectL.Common;
using BlackJack.ProjectL.UI;
using SLua;
using UnityEngine.Scripting;

// Token: 0x020015CD RID: 5581
[Preserve]
public class Lua_BlackJack_ProjectL_UI_UnchartedScoreUITask : LuaObject
{
	// Token: 0x06021FCF RID: 139215 RVA: 0x00B944F4 File Offset: 0x00B926F4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int constructor(IntPtr l)
	{
		int result;
		try
		{
			string name;
			LuaObject.checkType(l, 2, out name);
			UnchartedScoreUITask o = new UnchartedScoreUITask(name);
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

	// Token: 0x06021FD0 RID: 139216 RVA: 0x00B94548 File Offset: 0x00B92748
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int OnStart(IntPtr l)
	{
		int result;
		try
		{
			UnchartedScoreUITask unchartedScoreUITask = (UnchartedScoreUITask)LuaObject.checkSelf(l);
			UIIntent intent;
			LuaObject.checkType<UIIntent>(l, 2, out intent);
			bool b = unchartedScoreUITask.m_luaExportHelper.OnStart(intent);
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

	// Token: 0x06021FD1 RID: 139217 RVA: 0x00B945B0 File Offset: 0x00B927B0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int OnResume(IntPtr l)
	{
		int result;
		try
		{
			UnchartedScoreUITask unchartedScoreUITask = (UnchartedScoreUITask)LuaObject.checkSelf(l);
			UIIntent intent;
			LuaObject.checkType<UIIntent>(l, 2, out intent);
			bool b = unchartedScoreUITask.m_luaExportHelper.OnResume(intent);
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

	// Token: 0x06021FD2 RID: 139218 RVA: 0x00B94618 File Offset: 0x00B92818
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int InitDataFromUIIntent(IntPtr l)
	{
		int result;
		try
		{
			UnchartedScoreUITask unchartedScoreUITask = (UnchartedScoreUITask)LuaObject.checkSelf(l);
			UIIntent intent;
			LuaObject.checkType<UIIntent>(l, 2, out intent);
			unchartedScoreUITask.m_luaExportHelper.InitDataFromUIIntent(intent);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06021FD3 RID: 139219 RVA: 0x00B94674 File Offset: 0x00B92874
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int IsNeedLoadDynamicRes(IntPtr l)
	{
		int result;
		try
		{
			UnchartedScoreUITask unchartedScoreUITask = (UnchartedScoreUITask)LuaObject.checkSelf(l);
			bool b = unchartedScoreUITask.m_luaExportHelper.IsNeedLoadDynamicRes();
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

	// Token: 0x06021FD4 RID: 139220 RVA: 0x00B946D0 File Offset: 0x00B928D0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int InitAllUIControllers(IntPtr l)
	{
		int result;
		try
		{
			UnchartedScoreUITask unchartedScoreUITask = (UnchartedScoreUITask)LuaObject.checkSelf(l);
			unchartedScoreUITask.m_luaExportHelper.InitAllUIControllers();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06021FD5 RID: 139221 RVA: 0x00B94724 File Offset: 0x00B92924
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int ClearAllContextAndRes(IntPtr l)
	{
		int result;
		try
		{
			UnchartedScoreUITask unchartedScoreUITask = (UnchartedScoreUITask)LuaObject.checkSelf(l);
			unchartedScoreUITask.m_luaExportHelper.ClearAllContextAndRes();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06021FD6 RID: 139222 RVA: 0x00B94778 File Offset: 0x00B92978
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int InitUnchartedScoreUIController(IntPtr l)
	{
		int result;
		try
		{
			UnchartedScoreUITask unchartedScoreUITask = (UnchartedScoreUITask)LuaObject.checkSelf(l);
			unchartedScoreUITask.m_luaExportHelper.InitUnchartedScoreUIController();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06021FD7 RID: 139223 RVA: 0x00B947CC File Offset: 0x00B929CC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int UninitUnchartedScoreUIController(IntPtr l)
	{
		int result;
		try
		{
			UnchartedScoreUITask unchartedScoreUITask = (UnchartedScoreUITask)LuaObject.checkSelf(l);
			unchartedScoreUITask.m_luaExportHelper.UninitUnchartedScoreUIController();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06021FD8 RID: 139224 RVA: 0x00B94820 File Offset: 0x00B92A20
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int UpdateView(IntPtr l)
	{
		int result;
		try
		{
			UnchartedScoreUITask unchartedScoreUITask = (UnchartedScoreUITask)LuaObject.checkSelf(l);
			unchartedScoreUITask.m_luaExportHelper.UpdateView();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06021FD9 RID: 139225 RVA: 0x00B94874 File Offset: 0x00B92A74
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int UnchartedScoreUIController_OnReturn(IntPtr l)
	{
		int result;
		try
		{
			UnchartedScoreUITask unchartedScoreUITask = (UnchartedScoreUITask)LuaObject.checkSelf(l);
			unchartedScoreUITask.m_luaExportHelper.UnchartedScoreUIController_OnReturn();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06021FDA RID: 139226 RVA: 0x00B948C8 File Offset: 0x00B92AC8
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int UnchartedScoreUIController_OnShowHelp(IntPtr l)
	{
		int result;
		try
		{
			UnchartedScoreUITask unchartedScoreUITask = (UnchartedScoreUITask)LuaObject.checkSelf(l);
			unchartedScoreUITask.m_luaExportHelper.UnchartedScoreUIController_OnShowHelp();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06021FDB RID: 139227 RVA: 0x00B9491C File Offset: 0x00B92B1C
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int UnchartedScoreUIController_OnShowTeam(IntPtr l)
	{
		int result;
		try
		{
			UnchartedScoreUITask unchartedScoreUITask = (UnchartedScoreUITask)LuaObject.checkSelf(l);
			unchartedScoreUITask.m_luaExportHelper.UnchartedScoreUIController_OnShowTeam();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06021FDC RID: 139228 RVA: 0x00B94970 File Offset: 0x00B92B70
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int TeamUITask_OnLoadAllResCompleted(IntPtr l)
	{
		int result;
		try
		{
			UnchartedScoreUITask unchartedScoreUITask = (UnchartedScoreUITask)LuaObject.checkSelf(l);
			unchartedScoreUITask.m_luaExportHelper.TeamUITask_OnLoadAllResCompleted();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06021FDD RID: 139229 RVA: 0x00B949C4 File Offset: 0x00B92BC4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int UnchartedScoreUIController_EventOnChangeBattleType(IntPtr l)
	{
		int result;
		try
		{
			UnchartedScoreUITask unchartedScoreUITask = (UnchartedScoreUITask)LuaObject.checkSelf(l);
			BattleType battleType;
			LuaObject.checkEnum<BattleType>(l, 2, out battleType);
			unchartedScoreUITask.m_luaExportHelper.UnchartedScoreUIController_EventOnChangeBattleType(battleType);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06021FDE RID: 139230 RVA: 0x00B94A20 File Offset: 0x00B92C20
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int UnchartedScoreUIController_OnStartUnchartedScoreLevel(IntPtr l)
	{
		int result;
		try
		{
			UnchartedScoreUITask unchartedScoreUITask = (UnchartedScoreUITask)LuaObject.checkSelf(l);
			ConfigDataScoreLevelInfo levelInfo;
			LuaObject.checkType<ConfigDataScoreLevelInfo>(l, 2, out levelInfo);
			unchartedScoreUITask.m_luaExportHelper.UnchartedScoreUIController_OnStartUnchartedScoreLevel(levelInfo);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06021FDF RID: 139231 RVA: 0x00B94A7C File Offset: 0x00B92C7C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int UnchartedScoreUIController_OnStartUnchartedChallengeLevel(IntPtr l)
	{
		int result;
		try
		{
			UnchartedScoreUITask unchartedScoreUITask = (UnchartedScoreUITask)LuaObject.checkSelf(l);
			ConfigDataChallengeLevelInfo levelInfo;
			LuaObject.checkType<ConfigDataChallengeLevelInfo>(l, 2, out levelInfo);
			unchartedScoreUITask.m_luaExportHelper.UnchartedScoreUIController_OnStartUnchartedChallengeLevel(levelInfo);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06021FE0 RID: 139232 RVA: 0x00B94AD8 File Offset: 0x00B92CD8
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int __callBase_OnStart(IntPtr l)
	{
		int result;
		try
		{
			UnchartedScoreUITask unchartedScoreUITask = (UnchartedScoreUITask)LuaObject.checkSelf(l);
			UIIntent intent;
			LuaObject.checkType<UIIntent>(l, 2, out intent);
			bool b = unchartedScoreUITask.m_luaExportHelper.__callBase_OnStart(intent);
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

	// Token: 0x06021FE1 RID: 139233 RVA: 0x00B94B40 File Offset: 0x00B92D40
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_OnStop(IntPtr l)
	{
		int result;
		try
		{
			UnchartedScoreUITask unchartedScoreUITask = (UnchartedScoreUITask)LuaObject.checkSelf(l);
			unchartedScoreUITask.m_luaExportHelper.__callBase_OnStop();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06021FE2 RID: 139234 RVA: 0x00B94B94 File Offset: 0x00B92D94
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_OnPause(IntPtr l)
	{
		int result;
		try
		{
			UnchartedScoreUITask unchartedScoreUITask = (UnchartedScoreUITask)LuaObject.checkSelf(l);
			unchartedScoreUITask.m_luaExportHelper.__callBase_OnPause();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06021FE3 RID: 139235 RVA: 0x00B94BE8 File Offset: 0x00B92DE8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_OnResume(IntPtr l)
	{
		int result;
		try
		{
			UnchartedScoreUITask unchartedScoreUITask = (UnchartedScoreUITask)LuaObject.checkSelf(l);
			UIIntent intent;
			LuaObject.checkType<UIIntent>(l, 2, out intent);
			bool b = unchartedScoreUITask.m_luaExportHelper.__callBase_OnResume(intent);
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

	// Token: 0x06021FE4 RID: 139236 RVA: 0x00B94C50 File Offset: 0x00B92E50
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_OnNewIntent(IntPtr l)
	{
		int result;
		try
		{
			UnchartedScoreUITask unchartedScoreUITask = (UnchartedScoreUITask)LuaObject.checkSelf(l);
			UIIntent intent;
			LuaObject.checkType<UIIntent>(l, 2, out intent);
			bool b = unchartedScoreUITask.m_luaExportHelper.__callBase_OnNewIntent(intent);
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

	// Token: 0x06021FE5 RID: 139237 RVA: 0x00B94CB8 File Offset: 0x00B92EB8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_EnableUIInput(IntPtr l)
	{
		int result;
		try
		{
			UnchartedScoreUITask unchartedScoreUITask = (UnchartedScoreUITask)LuaObject.checkSelf(l);
			bool isEnable;
			LuaObject.checkType(l, 2, out isEnable);
			bool? isGlobalEnable;
			LuaObject.checkNullable<bool>(l, 3, out isGlobalEnable);
			unchartedScoreUITask.m_luaExportHelper.__callBase_EnableUIInput(isEnable, isGlobalEnable);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06021FE6 RID: 139238 RVA: 0x00B94D24 File Offset: 0x00B92F24
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int __callBase_IsNeedLoadDynamicRes(IntPtr l)
	{
		int result;
		try
		{
			UnchartedScoreUITask unchartedScoreUITask = (UnchartedScoreUITask)LuaObject.checkSelf(l);
			bool b = unchartedScoreUITask.m_luaExportHelper.__callBase_IsNeedLoadDynamicRes();
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

	// Token: 0x06021FE7 RID: 139239 RVA: 0x00B94D80 File Offset: 0x00B92F80
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_CollectAllDynamicResForLoad(IntPtr l)
	{
		int result;
		try
		{
			UnchartedScoreUITask unchartedScoreUITask = (UnchartedScoreUITask)LuaObject.checkSelf(l);
			List<string> o = unchartedScoreUITask.m_luaExportHelper.__callBase_CollectAllDynamicResForLoad();
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

	// Token: 0x06021FE8 RID: 139240 RVA: 0x00B94DDC File Offset: 0x00B92FDC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_RegisterPlayerContextEvents(IntPtr l)
	{
		int result;
		try
		{
			UnchartedScoreUITask unchartedScoreUITask = (UnchartedScoreUITask)LuaObject.checkSelf(l);
			unchartedScoreUITask.m_luaExportHelper.__callBase_RegisterPlayerContextEvents();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06021FE9 RID: 139241 RVA: 0x00B94E30 File Offset: 0x00B93030
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_UnregisterPlayerContextEvents(IntPtr l)
	{
		int result;
		try
		{
			UnchartedScoreUITask unchartedScoreUITask = (UnchartedScoreUITask)LuaObject.checkSelf(l);
			unchartedScoreUITask.m_luaExportHelper.__callBase_UnregisterPlayerContextEvents();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06021FEA RID: 139242 RVA: 0x00B94E84 File Offset: 0x00B93084
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_PostUpdateView(IntPtr l)
	{
		int result;
		try
		{
			UnchartedScoreUITask unchartedScoreUITask = (UnchartedScoreUITask)LuaObject.checkSelf(l);
			unchartedScoreUITask.m_luaExportHelper.__callBase_PostUpdateView();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06021FEB RID: 139243 RVA: 0x00B94ED8 File Offset: 0x00B930D8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_CollectPreloadResourceList(IntPtr l)
	{
		int result;
		try
		{
			UnchartedScoreUITask unchartedScoreUITask = (UnchartedScoreUITask)LuaObject.checkSelf(l);
			unchartedScoreUITask.m_luaExportHelper.__callBase_CollectPreloadResourceList();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06021FEC RID: 139244 RVA: 0x00B94F2C File Offset: 0x00B9312C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_ClearAssetList(IntPtr l)
	{
		int result;
		try
		{
			UnchartedScoreUITask unchartedScoreUITask = (UnchartedScoreUITask)LuaObject.checkSelf(l);
			unchartedScoreUITask.m_luaExportHelper.__callBase_ClearAssetList();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06021FED RID: 139245 RVA: 0x00B94F80 File Offset: 0x00B93180
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_CollectAsset(IntPtr l)
	{
		int result;
		try
		{
			UnchartedScoreUITask unchartedScoreUITask = (UnchartedScoreUITask)LuaObject.checkSelf(l);
			string assetName;
			LuaObject.checkType(l, 2, out assetName);
			unchartedScoreUITask.m_luaExportHelper.__callBase_CollectAsset(assetName);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06021FEE RID: 139246 RVA: 0x00B94FDC File Offset: 0x00B931DC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_CollectSpriteAsset(IntPtr l)
	{
		int result;
		try
		{
			UnchartedScoreUITask unchartedScoreUITask = (UnchartedScoreUITask)LuaObject.checkSelf(l);
			string assetName;
			LuaObject.checkType(l, 2, out assetName);
			unchartedScoreUITask.m_luaExportHelper.__callBase_CollectSpriteAsset(assetName);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06021FEF RID: 139247 RVA: 0x00B95038 File Offset: 0x00B93238
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_CollectFxAsset(IntPtr l)
	{
		int result;
		try
		{
			UnchartedScoreUITask unchartedScoreUITask = (UnchartedScoreUITask)LuaObject.checkSelf(l);
			string assetName;
			LuaObject.checkType(l, 2, out assetName);
			unchartedScoreUITask.m_luaExportHelper.__callBase_CollectFxAsset(assetName);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06021FF0 RID: 139248 RVA: 0x00B95094 File Offset: 0x00B93294
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_StartLoadCustomAssets(IntPtr l)
	{
		int result;
		try
		{
			UnchartedScoreUITask unchartedScoreUITask = (UnchartedScoreUITask)LuaObject.checkSelf(l);
			Action onLoadCompleted;
			LuaObject.checkDelegate<Action>(l, 2, out onLoadCompleted);
			unchartedScoreUITask.m_luaExportHelper.__callBase_StartLoadCustomAssets(onLoadCompleted);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06021FF1 RID: 139249 RVA: 0x00B950F0 File Offset: 0x00B932F0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_IsLoadingCustomAssets(IntPtr l)
	{
		int result;
		try
		{
			UnchartedScoreUITask unchartedScoreUITask = (UnchartedScoreUITask)LuaObject.checkSelf(l);
			bool b = unchartedScoreUITask.m_luaExportHelper.__callBase_IsLoadingCustomAssets();
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

	// Token: 0x06021FF2 RID: 139250 RVA: 0x00B9514C File Offset: 0x00B9334C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_IsPipeLineRunning(IntPtr l)
	{
		int result;
		try
		{
			UnchartedScoreUITask unchartedScoreUITask = (UnchartedScoreUITask)LuaObject.checkSelf(l);
			bool b = unchartedScoreUITask.m_luaExportHelper.__callBase_IsPipeLineRunning();
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

	// Token: 0x06021FF3 RID: 139251 RVA: 0x00B951A8 File Offset: 0x00B933A8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_IsOpeningUI(IntPtr l)
	{
		int result;
		try
		{
			UnchartedScoreUITask unchartedScoreUITask = (UnchartedScoreUITask)LuaObject.checkSelf(l);
			bool b = unchartedScoreUITask.m_luaExportHelper.__callBase_IsOpeningUI();
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

	// Token: 0x06021FF4 RID: 139252 RVA: 0x00B95204 File Offset: 0x00B93404
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_ReturnPrevUITask(IntPtr l)
	{
		int result;
		try
		{
			UnchartedScoreUITask unchartedScoreUITask = (UnchartedScoreUITask)LuaObject.checkSelf(l);
			UITaskBase o = unchartedScoreUITask.m_luaExportHelper.__callBase_ReturnPrevUITask();
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

	// Token: 0x06021FF5 RID: 139253 RVA: 0x00B95260 File Offset: 0x00B93460
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int __callBase_ClearUnusedDynamicResourceCache(IntPtr l)
	{
		int result;
		try
		{
			UnchartedScoreUITask unchartedScoreUITask = (UnchartedScoreUITask)LuaObject.checkSelf(l);
			unchartedScoreUITask.m_luaExportHelper.__callBase_ClearUnusedDynamicResourceCache();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06021FF6 RID: 139254 RVA: 0x00B952B4 File Offset: 0x00B934B4
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int __callBase_OnMemoryWarning(IntPtr l)
	{
		int result;
		try
		{
			UnchartedScoreUITask unchartedScoreUITask = (UnchartedScoreUITask)LuaObject.checkSelf(l);
			unchartedScoreUITask.m_luaExportHelper.__callBase_OnMemoryWarning();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06021FF7 RID: 139255 RVA: 0x00B95308 File Offset: 0x00B93508
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_layerDescArray(IntPtr l)
	{
		int result;
		try
		{
			UnchartedScoreUITask unchartedScoreUITask = (UnchartedScoreUITask)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, unchartedScoreUITask.m_luaExportHelper.m_layerDescArray);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06021FF8 RID: 139256 RVA: 0x00B95360 File Offset: 0x00B93560
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_layerDescArray(IntPtr l)
	{
		int result;
		try
		{
			UnchartedScoreUITask unchartedScoreUITask = (UnchartedScoreUITask)LuaObject.checkSelf(l);
			UITaskBase.LayerDesc[] layerDescArray;
			LuaObject.checkArray<UITaskBase.LayerDesc>(l, 2, out layerDescArray);
			unchartedScoreUITask.m_luaExportHelper.m_layerDescArray = layerDescArray;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06021FF9 RID: 139257 RVA: 0x00B953BC File Offset: 0x00B935BC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_uiCtrlDescArray(IntPtr l)
	{
		int result;
		try
		{
			UnchartedScoreUITask unchartedScoreUITask = (UnchartedScoreUITask)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, unchartedScoreUITask.m_luaExportHelper.m_uiCtrlDescArray);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06021FFA RID: 139258 RVA: 0x00B95414 File Offset: 0x00B93614
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_m_uiCtrlDescArray(IntPtr l)
	{
		int result;
		try
		{
			UnchartedScoreUITask unchartedScoreUITask = (UnchartedScoreUITask)LuaObject.checkSelf(l);
			UITaskBase.UIControllerDesc[] uiCtrlDescArray;
			LuaObject.checkArray<UITaskBase.UIControllerDesc>(l, 2, out uiCtrlDescArray);
			unchartedScoreUITask.m_luaExportHelper.m_uiCtrlDescArray = uiCtrlDescArray;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06021FFB RID: 139259 RVA: 0x00B95470 File Offset: 0x00B93670
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_unchartedScoreUIController(IntPtr l)
	{
		int result;
		try
		{
			UnchartedScoreUITask unchartedScoreUITask = (UnchartedScoreUITask)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, unchartedScoreUITask.m_luaExportHelper.m_unchartedScoreUIController);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06021FFC RID: 139260 RVA: 0x00B954C8 File Offset: 0x00B936C8
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_m_unchartedScoreUIController(IntPtr l)
	{
		int result;
		try
		{
			UnchartedScoreUITask unchartedScoreUITask = (UnchartedScoreUITask)LuaObject.checkSelf(l);
			UnchartedScoreUIController unchartedScoreUIController;
			LuaObject.checkType<UnchartedScoreUIController>(l, 2, out unchartedScoreUIController);
			unchartedScoreUITask.m_luaExportHelper.m_unchartedScoreUIController = unchartedScoreUIController;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06021FFD RID: 139261 RVA: 0x00B95524 File Offset: 0x00B93724
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_playerResourceUIController(IntPtr l)
	{
		int result;
		try
		{
			UnchartedScoreUITask unchartedScoreUITask = (UnchartedScoreUITask)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, unchartedScoreUITask.m_luaExportHelper.m_playerResourceUIController);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06021FFE RID: 139262 RVA: 0x00B9557C File Offset: 0x00B9377C
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_m_playerResourceUIController(IntPtr l)
	{
		int result;
		try
		{
			UnchartedScoreUITask unchartedScoreUITask = (UnchartedScoreUITask)LuaObject.checkSelf(l);
			PlayerResourceUIController playerResourceUIController;
			LuaObject.checkType<PlayerResourceUIController>(l, 2, out playerResourceUIController);
			unchartedScoreUITask.m_luaExportHelper.m_playerResourceUIController = playerResourceUIController;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06021FFF RID: 139263 RVA: 0x00B955D8 File Offset: 0x00B937D8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_unchartedScoreInfo(IntPtr l)
	{
		int result;
		try
		{
			UnchartedScoreUITask unchartedScoreUITask = (UnchartedScoreUITask)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, unchartedScoreUITask.m_luaExportHelper.m_unchartedScoreInfo);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06022000 RID: 139264 RVA: 0x00B95630 File Offset: 0x00B93830
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_unchartedScoreInfo(IntPtr l)
	{
		int result;
		try
		{
			UnchartedScoreUITask unchartedScoreUITask = (UnchartedScoreUITask)LuaObject.checkSelf(l);
			ConfigDataUnchartedScoreInfo unchartedScoreInfo;
			LuaObject.checkType<ConfigDataUnchartedScoreInfo>(l, 2, out unchartedScoreInfo);
			unchartedScoreUITask.m_luaExportHelper.m_unchartedScoreInfo = unchartedScoreInfo;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06022001 RID: 139265 RVA: 0x00B9568C File Offset: 0x00B9388C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_unchartedScoreModelInfo(IntPtr l)
	{
		int result;
		try
		{
			UnchartedScoreUITask unchartedScoreUITask = (UnchartedScoreUITask)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, unchartedScoreUITask.m_luaExportHelper.m_unchartedScoreModelInfo);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06022002 RID: 139266 RVA: 0x00B956E4 File Offset: 0x00B938E4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_unchartedScoreModelInfo(IntPtr l)
	{
		int result;
		try
		{
			UnchartedScoreUITask unchartedScoreUITask = (UnchartedScoreUITask)LuaObject.checkSelf(l);
			ConfigDataUnchartedScoreModelInfo unchartedScoreModelInfo;
			LuaObject.checkType<ConfigDataUnchartedScoreModelInfo>(l, 2, out unchartedScoreModelInfo);
			unchartedScoreUITask.m_luaExportHelper.m_unchartedScoreModelInfo = unchartedScoreModelInfo;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06022003 RID: 139267 RVA: 0x00B95740 File Offset: 0x00B93940
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_battleType(IntPtr l)
	{
		int result;
		try
		{
			UnchartedScoreUITask unchartedScoreUITask = (UnchartedScoreUITask)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushEnum(l, (int)unchartedScoreUITask.m_luaExportHelper.m_battleType);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06022004 RID: 139268 RVA: 0x00B95798 File Offset: 0x00B93998
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_battleType(IntPtr l)
	{
		int result;
		try
		{
			UnchartedScoreUITask unchartedScoreUITask = (UnchartedScoreUITask)LuaObject.checkSelf(l);
			BattleType battleType;
			LuaObject.checkEnum<BattleType>(l, 2, out battleType);
			unchartedScoreUITask.m_luaExportHelper.m_battleType = battleType;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06022005 RID: 139269 RVA: 0x00B957F4 File Offset: 0x00B939F4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_LayerDescArray(IntPtr l)
	{
		int result;
		try
		{
			UnchartedScoreUITask unchartedScoreUITask = (UnchartedScoreUITask)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, unchartedScoreUITask.m_luaExportHelper.LayerDescArray);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06022006 RID: 139270 RVA: 0x00B9584C File Offset: 0x00B93A4C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_UICtrlDescArray(IntPtr l)
	{
		int result;
		try
		{
			UnchartedScoreUITask unchartedScoreUITask = (UnchartedScoreUITask)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, unchartedScoreUITask.m_luaExportHelper.UICtrlDescArray);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06022007 RID: 139271 RVA: 0x00B958A4 File Offset: 0x00B93AA4
	[Preserve]
	public static void reg(IntPtr l)
	{
		LuaObject.getTypeTable(l, "BlackJack.ProjectL.UI.UnchartedScoreUITask");
		if (Lua_BlackJack_ProjectL_UI_UnchartedScoreUITask.<>f__mg$cache0 == null)
		{
			Lua_BlackJack_ProjectL_UI_UnchartedScoreUITask.<>f__mg$cache0 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_UnchartedScoreUITask.OnStart);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_UnchartedScoreUITask.<>f__mg$cache0);
		if (Lua_BlackJack_ProjectL_UI_UnchartedScoreUITask.<>f__mg$cache1 == null)
		{
			Lua_BlackJack_ProjectL_UI_UnchartedScoreUITask.<>f__mg$cache1 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_UnchartedScoreUITask.OnResume);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_UnchartedScoreUITask.<>f__mg$cache1);
		if (Lua_BlackJack_ProjectL_UI_UnchartedScoreUITask.<>f__mg$cache2 == null)
		{
			Lua_BlackJack_ProjectL_UI_UnchartedScoreUITask.<>f__mg$cache2 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_UnchartedScoreUITask.InitDataFromUIIntent);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_UnchartedScoreUITask.<>f__mg$cache2);
		if (Lua_BlackJack_ProjectL_UI_UnchartedScoreUITask.<>f__mg$cache3 == null)
		{
			Lua_BlackJack_ProjectL_UI_UnchartedScoreUITask.<>f__mg$cache3 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_UnchartedScoreUITask.IsNeedLoadDynamicRes);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_UnchartedScoreUITask.<>f__mg$cache3);
		if (Lua_BlackJack_ProjectL_UI_UnchartedScoreUITask.<>f__mg$cache4 == null)
		{
			Lua_BlackJack_ProjectL_UI_UnchartedScoreUITask.<>f__mg$cache4 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_UnchartedScoreUITask.InitAllUIControllers);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_UnchartedScoreUITask.<>f__mg$cache4);
		if (Lua_BlackJack_ProjectL_UI_UnchartedScoreUITask.<>f__mg$cache5 == null)
		{
			Lua_BlackJack_ProjectL_UI_UnchartedScoreUITask.<>f__mg$cache5 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_UnchartedScoreUITask.ClearAllContextAndRes);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_UnchartedScoreUITask.<>f__mg$cache5);
		if (Lua_BlackJack_ProjectL_UI_UnchartedScoreUITask.<>f__mg$cache6 == null)
		{
			Lua_BlackJack_ProjectL_UI_UnchartedScoreUITask.<>f__mg$cache6 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_UnchartedScoreUITask.InitUnchartedScoreUIController);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_UnchartedScoreUITask.<>f__mg$cache6);
		if (Lua_BlackJack_ProjectL_UI_UnchartedScoreUITask.<>f__mg$cache7 == null)
		{
			Lua_BlackJack_ProjectL_UI_UnchartedScoreUITask.<>f__mg$cache7 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_UnchartedScoreUITask.UninitUnchartedScoreUIController);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_UnchartedScoreUITask.<>f__mg$cache7);
		if (Lua_BlackJack_ProjectL_UI_UnchartedScoreUITask.<>f__mg$cache8 == null)
		{
			Lua_BlackJack_ProjectL_UI_UnchartedScoreUITask.<>f__mg$cache8 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_UnchartedScoreUITask.UpdateView);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_UnchartedScoreUITask.<>f__mg$cache8);
		if (Lua_BlackJack_ProjectL_UI_UnchartedScoreUITask.<>f__mg$cache9 == null)
		{
			Lua_BlackJack_ProjectL_UI_UnchartedScoreUITask.<>f__mg$cache9 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_UnchartedScoreUITask.UnchartedScoreUIController_OnReturn);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_UnchartedScoreUITask.<>f__mg$cache9);
		if (Lua_BlackJack_ProjectL_UI_UnchartedScoreUITask.<>f__mg$cacheA == null)
		{
			Lua_BlackJack_ProjectL_UI_UnchartedScoreUITask.<>f__mg$cacheA = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_UnchartedScoreUITask.UnchartedScoreUIController_OnShowHelp);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_UnchartedScoreUITask.<>f__mg$cacheA);
		if (Lua_BlackJack_ProjectL_UI_UnchartedScoreUITask.<>f__mg$cacheB == null)
		{
			Lua_BlackJack_ProjectL_UI_UnchartedScoreUITask.<>f__mg$cacheB = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_UnchartedScoreUITask.UnchartedScoreUIController_OnShowTeam);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_UnchartedScoreUITask.<>f__mg$cacheB);
		if (Lua_BlackJack_ProjectL_UI_UnchartedScoreUITask.<>f__mg$cacheC == null)
		{
			Lua_BlackJack_ProjectL_UI_UnchartedScoreUITask.<>f__mg$cacheC = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_UnchartedScoreUITask.TeamUITask_OnLoadAllResCompleted);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_UnchartedScoreUITask.<>f__mg$cacheC);
		if (Lua_BlackJack_ProjectL_UI_UnchartedScoreUITask.<>f__mg$cacheD == null)
		{
			Lua_BlackJack_ProjectL_UI_UnchartedScoreUITask.<>f__mg$cacheD = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_UnchartedScoreUITask.UnchartedScoreUIController_EventOnChangeBattleType);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_UnchartedScoreUITask.<>f__mg$cacheD);
		if (Lua_BlackJack_ProjectL_UI_UnchartedScoreUITask.<>f__mg$cacheE == null)
		{
			Lua_BlackJack_ProjectL_UI_UnchartedScoreUITask.<>f__mg$cacheE = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_UnchartedScoreUITask.UnchartedScoreUIController_OnStartUnchartedScoreLevel);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_UnchartedScoreUITask.<>f__mg$cacheE);
		if (Lua_BlackJack_ProjectL_UI_UnchartedScoreUITask.<>f__mg$cacheF == null)
		{
			Lua_BlackJack_ProjectL_UI_UnchartedScoreUITask.<>f__mg$cacheF = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_UnchartedScoreUITask.UnchartedScoreUIController_OnStartUnchartedChallengeLevel);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_UnchartedScoreUITask.<>f__mg$cacheF);
		if (Lua_BlackJack_ProjectL_UI_UnchartedScoreUITask.<>f__mg$cache10 == null)
		{
			Lua_BlackJack_ProjectL_UI_UnchartedScoreUITask.<>f__mg$cache10 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_UnchartedScoreUITask.__callBase_OnStart);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_UnchartedScoreUITask.<>f__mg$cache10);
		if (Lua_BlackJack_ProjectL_UI_UnchartedScoreUITask.<>f__mg$cache11 == null)
		{
			Lua_BlackJack_ProjectL_UI_UnchartedScoreUITask.<>f__mg$cache11 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_UnchartedScoreUITask.__callBase_OnStop);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_UnchartedScoreUITask.<>f__mg$cache11);
		if (Lua_BlackJack_ProjectL_UI_UnchartedScoreUITask.<>f__mg$cache12 == null)
		{
			Lua_BlackJack_ProjectL_UI_UnchartedScoreUITask.<>f__mg$cache12 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_UnchartedScoreUITask.__callBase_OnPause);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_UnchartedScoreUITask.<>f__mg$cache12);
		if (Lua_BlackJack_ProjectL_UI_UnchartedScoreUITask.<>f__mg$cache13 == null)
		{
			Lua_BlackJack_ProjectL_UI_UnchartedScoreUITask.<>f__mg$cache13 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_UnchartedScoreUITask.__callBase_OnResume);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_UnchartedScoreUITask.<>f__mg$cache13);
		if (Lua_BlackJack_ProjectL_UI_UnchartedScoreUITask.<>f__mg$cache14 == null)
		{
			Lua_BlackJack_ProjectL_UI_UnchartedScoreUITask.<>f__mg$cache14 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_UnchartedScoreUITask.__callBase_OnNewIntent);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_UnchartedScoreUITask.<>f__mg$cache14);
		if (Lua_BlackJack_ProjectL_UI_UnchartedScoreUITask.<>f__mg$cache15 == null)
		{
			Lua_BlackJack_ProjectL_UI_UnchartedScoreUITask.<>f__mg$cache15 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_UnchartedScoreUITask.__callBase_EnableUIInput);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_UnchartedScoreUITask.<>f__mg$cache15);
		if (Lua_BlackJack_ProjectL_UI_UnchartedScoreUITask.<>f__mg$cache16 == null)
		{
			Lua_BlackJack_ProjectL_UI_UnchartedScoreUITask.<>f__mg$cache16 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_UnchartedScoreUITask.__callBase_IsNeedLoadDynamicRes);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_UnchartedScoreUITask.<>f__mg$cache16);
		if (Lua_BlackJack_ProjectL_UI_UnchartedScoreUITask.<>f__mg$cache17 == null)
		{
			Lua_BlackJack_ProjectL_UI_UnchartedScoreUITask.<>f__mg$cache17 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_UnchartedScoreUITask.__callBase_CollectAllDynamicResForLoad);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_UnchartedScoreUITask.<>f__mg$cache17);
		if (Lua_BlackJack_ProjectL_UI_UnchartedScoreUITask.<>f__mg$cache18 == null)
		{
			Lua_BlackJack_ProjectL_UI_UnchartedScoreUITask.<>f__mg$cache18 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_UnchartedScoreUITask.__callBase_RegisterPlayerContextEvents);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_UnchartedScoreUITask.<>f__mg$cache18);
		if (Lua_BlackJack_ProjectL_UI_UnchartedScoreUITask.<>f__mg$cache19 == null)
		{
			Lua_BlackJack_ProjectL_UI_UnchartedScoreUITask.<>f__mg$cache19 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_UnchartedScoreUITask.__callBase_UnregisterPlayerContextEvents);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_UnchartedScoreUITask.<>f__mg$cache19);
		if (Lua_BlackJack_ProjectL_UI_UnchartedScoreUITask.<>f__mg$cache1A == null)
		{
			Lua_BlackJack_ProjectL_UI_UnchartedScoreUITask.<>f__mg$cache1A = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_UnchartedScoreUITask.__callBase_PostUpdateView);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_UnchartedScoreUITask.<>f__mg$cache1A);
		if (Lua_BlackJack_ProjectL_UI_UnchartedScoreUITask.<>f__mg$cache1B == null)
		{
			Lua_BlackJack_ProjectL_UI_UnchartedScoreUITask.<>f__mg$cache1B = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_UnchartedScoreUITask.__callBase_CollectPreloadResourceList);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_UnchartedScoreUITask.<>f__mg$cache1B);
		if (Lua_BlackJack_ProjectL_UI_UnchartedScoreUITask.<>f__mg$cache1C == null)
		{
			Lua_BlackJack_ProjectL_UI_UnchartedScoreUITask.<>f__mg$cache1C = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_UnchartedScoreUITask.__callBase_ClearAssetList);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_UnchartedScoreUITask.<>f__mg$cache1C);
		if (Lua_BlackJack_ProjectL_UI_UnchartedScoreUITask.<>f__mg$cache1D == null)
		{
			Lua_BlackJack_ProjectL_UI_UnchartedScoreUITask.<>f__mg$cache1D = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_UnchartedScoreUITask.__callBase_CollectAsset);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_UnchartedScoreUITask.<>f__mg$cache1D);
		if (Lua_BlackJack_ProjectL_UI_UnchartedScoreUITask.<>f__mg$cache1E == null)
		{
			Lua_BlackJack_ProjectL_UI_UnchartedScoreUITask.<>f__mg$cache1E = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_UnchartedScoreUITask.__callBase_CollectSpriteAsset);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_UnchartedScoreUITask.<>f__mg$cache1E);
		if (Lua_BlackJack_ProjectL_UI_UnchartedScoreUITask.<>f__mg$cache1F == null)
		{
			Lua_BlackJack_ProjectL_UI_UnchartedScoreUITask.<>f__mg$cache1F = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_UnchartedScoreUITask.__callBase_CollectFxAsset);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_UnchartedScoreUITask.<>f__mg$cache1F);
		if (Lua_BlackJack_ProjectL_UI_UnchartedScoreUITask.<>f__mg$cache20 == null)
		{
			Lua_BlackJack_ProjectL_UI_UnchartedScoreUITask.<>f__mg$cache20 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_UnchartedScoreUITask.__callBase_StartLoadCustomAssets);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_UnchartedScoreUITask.<>f__mg$cache20);
		if (Lua_BlackJack_ProjectL_UI_UnchartedScoreUITask.<>f__mg$cache21 == null)
		{
			Lua_BlackJack_ProjectL_UI_UnchartedScoreUITask.<>f__mg$cache21 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_UnchartedScoreUITask.__callBase_IsLoadingCustomAssets);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_UnchartedScoreUITask.<>f__mg$cache21);
		if (Lua_BlackJack_ProjectL_UI_UnchartedScoreUITask.<>f__mg$cache22 == null)
		{
			Lua_BlackJack_ProjectL_UI_UnchartedScoreUITask.<>f__mg$cache22 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_UnchartedScoreUITask.__callBase_IsPipeLineRunning);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_UnchartedScoreUITask.<>f__mg$cache22);
		if (Lua_BlackJack_ProjectL_UI_UnchartedScoreUITask.<>f__mg$cache23 == null)
		{
			Lua_BlackJack_ProjectL_UI_UnchartedScoreUITask.<>f__mg$cache23 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_UnchartedScoreUITask.__callBase_IsOpeningUI);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_UnchartedScoreUITask.<>f__mg$cache23);
		if (Lua_BlackJack_ProjectL_UI_UnchartedScoreUITask.<>f__mg$cache24 == null)
		{
			Lua_BlackJack_ProjectL_UI_UnchartedScoreUITask.<>f__mg$cache24 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_UnchartedScoreUITask.__callBase_ReturnPrevUITask);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_UnchartedScoreUITask.<>f__mg$cache24);
		if (Lua_BlackJack_ProjectL_UI_UnchartedScoreUITask.<>f__mg$cache25 == null)
		{
			Lua_BlackJack_ProjectL_UI_UnchartedScoreUITask.<>f__mg$cache25 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_UnchartedScoreUITask.__callBase_ClearUnusedDynamicResourceCache);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_UnchartedScoreUITask.<>f__mg$cache25);
		if (Lua_BlackJack_ProjectL_UI_UnchartedScoreUITask.<>f__mg$cache26 == null)
		{
			Lua_BlackJack_ProjectL_UI_UnchartedScoreUITask.<>f__mg$cache26 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_UnchartedScoreUITask.__callBase_OnMemoryWarning);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_UnchartedScoreUITask.<>f__mg$cache26);
		string name = "m_layerDescArray";
		if (Lua_BlackJack_ProjectL_UI_UnchartedScoreUITask.<>f__mg$cache27 == null)
		{
			Lua_BlackJack_ProjectL_UI_UnchartedScoreUITask.<>f__mg$cache27 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_UnchartedScoreUITask.get_m_layerDescArray);
		}
		LuaCSFunction get = Lua_BlackJack_ProjectL_UI_UnchartedScoreUITask.<>f__mg$cache27;
		if (Lua_BlackJack_ProjectL_UI_UnchartedScoreUITask.<>f__mg$cache28 == null)
		{
			Lua_BlackJack_ProjectL_UI_UnchartedScoreUITask.<>f__mg$cache28 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_UnchartedScoreUITask.set_m_layerDescArray);
		}
		LuaObject.addMember(l, name, get, Lua_BlackJack_ProjectL_UI_UnchartedScoreUITask.<>f__mg$cache28, true);
		string name2 = "m_uiCtrlDescArray";
		if (Lua_BlackJack_ProjectL_UI_UnchartedScoreUITask.<>f__mg$cache29 == null)
		{
			Lua_BlackJack_ProjectL_UI_UnchartedScoreUITask.<>f__mg$cache29 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_UnchartedScoreUITask.get_m_uiCtrlDescArray);
		}
		LuaCSFunction get2 = Lua_BlackJack_ProjectL_UI_UnchartedScoreUITask.<>f__mg$cache29;
		if (Lua_BlackJack_ProjectL_UI_UnchartedScoreUITask.<>f__mg$cache2A == null)
		{
			Lua_BlackJack_ProjectL_UI_UnchartedScoreUITask.<>f__mg$cache2A = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_UnchartedScoreUITask.set_m_uiCtrlDescArray);
		}
		LuaObject.addMember(l, name2, get2, Lua_BlackJack_ProjectL_UI_UnchartedScoreUITask.<>f__mg$cache2A, true);
		string name3 = "m_unchartedScoreUIController";
		if (Lua_BlackJack_ProjectL_UI_UnchartedScoreUITask.<>f__mg$cache2B == null)
		{
			Lua_BlackJack_ProjectL_UI_UnchartedScoreUITask.<>f__mg$cache2B = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_UnchartedScoreUITask.get_m_unchartedScoreUIController);
		}
		LuaCSFunction get3 = Lua_BlackJack_ProjectL_UI_UnchartedScoreUITask.<>f__mg$cache2B;
		if (Lua_BlackJack_ProjectL_UI_UnchartedScoreUITask.<>f__mg$cache2C == null)
		{
			Lua_BlackJack_ProjectL_UI_UnchartedScoreUITask.<>f__mg$cache2C = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_UnchartedScoreUITask.set_m_unchartedScoreUIController);
		}
		LuaObject.addMember(l, name3, get3, Lua_BlackJack_ProjectL_UI_UnchartedScoreUITask.<>f__mg$cache2C, true);
		string name4 = "m_playerResourceUIController";
		if (Lua_BlackJack_ProjectL_UI_UnchartedScoreUITask.<>f__mg$cache2D == null)
		{
			Lua_BlackJack_ProjectL_UI_UnchartedScoreUITask.<>f__mg$cache2D = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_UnchartedScoreUITask.get_m_playerResourceUIController);
		}
		LuaCSFunction get4 = Lua_BlackJack_ProjectL_UI_UnchartedScoreUITask.<>f__mg$cache2D;
		if (Lua_BlackJack_ProjectL_UI_UnchartedScoreUITask.<>f__mg$cache2E == null)
		{
			Lua_BlackJack_ProjectL_UI_UnchartedScoreUITask.<>f__mg$cache2E = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_UnchartedScoreUITask.set_m_playerResourceUIController);
		}
		LuaObject.addMember(l, name4, get4, Lua_BlackJack_ProjectL_UI_UnchartedScoreUITask.<>f__mg$cache2E, true);
		string name5 = "m_unchartedScoreInfo";
		if (Lua_BlackJack_ProjectL_UI_UnchartedScoreUITask.<>f__mg$cache2F == null)
		{
			Lua_BlackJack_ProjectL_UI_UnchartedScoreUITask.<>f__mg$cache2F = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_UnchartedScoreUITask.get_m_unchartedScoreInfo);
		}
		LuaCSFunction get5 = Lua_BlackJack_ProjectL_UI_UnchartedScoreUITask.<>f__mg$cache2F;
		if (Lua_BlackJack_ProjectL_UI_UnchartedScoreUITask.<>f__mg$cache30 == null)
		{
			Lua_BlackJack_ProjectL_UI_UnchartedScoreUITask.<>f__mg$cache30 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_UnchartedScoreUITask.set_m_unchartedScoreInfo);
		}
		LuaObject.addMember(l, name5, get5, Lua_BlackJack_ProjectL_UI_UnchartedScoreUITask.<>f__mg$cache30, true);
		string name6 = "m_unchartedScoreModelInfo";
		if (Lua_BlackJack_ProjectL_UI_UnchartedScoreUITask.<>f__mg$cache31 == null)
		{
			Lua_BlackJack_ProjectL_UI_UnchartedScoreUITask.<>f__mg$cache31 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_UnchartedScoreUITask.get_m_unchartedScoreModelInfo);
		}
		LuaCSFunction get6 = Lua_BlackJack_ProjectL_UI_UnchartedScoreUITask.<>f__mg$cache31;
		if (Lua_BlackJack_ProjectL_UI_UnchartedScoreUITask.<>f__mg$cache32 == null)
		{
			Lua_BlackJack_ProjectL_UI_UnchartedScoreUITask.<>f__mg$cache32 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_UnchartedScoreUITask.set_m_unchartedScoreModelInfo);
		}
		LuaObject.addMember(l, name6, get6, Lua_BlackJack_ProjectL_UI_UnchartedScoreUITask.<>f__mg$cache32, true);
		string name7 = "m_battleType";
		if (Lua_BlackJack_ProjectL_UI_UnchartedScoreUITask.<>f__mg$cache33 == null)
		{
			Lua_BlackJack_ProjectL_UI_UnchartedScoreUITask.<>f__mg$cache33 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_UnchartedScoreUITask.get_m_battleType);
		}
		LuaCSFunction get7 = Lua_BlackJack_ProjectL_UI_UnchartedScoreUITask.<>f__mg$cache33;
		if (Lua_BlackJack_ProjectL_UI_UnchartedScoreUITask.<>f__mg$cache34 == null)
		{
			Lua_BlackJack_ProjectL_UI_UnchartedScoreUITask.<>f__mg$cache34 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_UnchartedScoreUITask.set_m_battleType);
		}
		LuaObject.addMember(l, name7, get7, Lua_BlackJack_ProjectL_UI_UnchartedScoreUITask.<>f__mg$cache34, true);
		string name8 = "LayerDescArray";
		if (Lua_BlackJack_ProjectL_UI_UnchartedScoreUITask.<>f__mg$cache35 == null)
		{
			Lua_BlackJack_ProjectL_UI_UnchartedScoreUITask.<>f__mg$cache35 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_UnchartedScoreUITask.get_LayerDescArray);
		}
		LuaObject.addMember(l, name8, Lua_BlackJack_ProjectL_UI_UnchartedScoreUITask.<>f__mg$cache35, null, true);
		string name9 = "UICtrlDescArray";
		if (Lua_BlackJack_ProjectL_UI_UnchartedScoreUITask.<>f__mg$cache36 == null)
		{
			Lua_BlackJack_ProjectL_UI_UnchartedScoreUITask.<>f__mg$cache36 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_UnchartedScoreUITask.get_UICtrlDescArray);
		}
		LuaObject.addMember(l, name9, Lua_BlackJack_ProjectL_UI_UnchartedScoreUITask.<>f__mg$cache36, null, true);
		if (Lua_BlackJack_ProjectL_UI_UnchartedScoreUITask.<>f__mg$cache37 == null)
		{
			Lua_BlackJack_ProjectL_UI_UnchartedScoreUITask.<>f__mg$cache37 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_UnchartedScoreUITask.constructor);
		}
		LuaObject.createTypeMetatable(l, Lua_BlackJack_ProjectL_UI_UnchartedScoreUITask.<>f__mg$cache37, typeof(UnchartedScoreUITask), typeof(UITask));
	}

	// Token: 0x04017E17 RID: 97815
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache0;

	// Token: 0x04017E18 RID: 97816
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1;

	// Token: 0x04017E19 RID: 97817
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2;

	// Token: 0x04017E1A RID: 97818
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3;

	// Token: 0x04017E1B RID: 97819
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache4;

	// Token: 0x04017E1C RID: 97820
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache5;

	// Token: 0x04017E1D RID: 97821
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache6;

	// Token: 0x04017E1E RID: 97822
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache7;

	// Token: 0x04017E1F RID: 97823
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache8;

	// Token: 0x04017E20 RID: 97824
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache9;

	// Token: 0x04017E21 RID: 97825
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheA;

	// Token: 0x04017E22 RID: 97826
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheB;

	// Token: 0x04017E23 RID: 97827
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheC;

	// Token: 0x04017E24 RID: 97828
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheD;

	// Token: 0x04017E25 RID: 97829
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheE;

	// Token: 0x04017E26 RID: 97830
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheF;

	// Token: 0x04017E27 RID: 97831
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache10;

	// Token: 0x04017E28 RID: 97832
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache11;

	// Token: 0x04017E29 RID: 97833
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache12;

	// Token: 0x04017E2A RID: 97834
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache13;

	// Token: 0x04017E2B RID: 97835
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache14;

	// Token: 0x04017E2C RID: 97836
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache15;

	// Token: 0x04017E2D RID: 97837
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache16;

	// Token: 0x04017E2E RID: 97838
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache17;

	// Token: 0x04017E2F RID: 97839
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache18;

	// Token: 0x04017E30 RID: 97840
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache19;

	// Token: 0x04017E31 RID: 97841
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1A;

	// Token: 0x04017E32 RID: 97842
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1B;

	// Token: 0x04017E33 RID: 97843
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1C;

	// Token: 0x04017E34 RID: 97844
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1D;

	// Token: 0x04017E35 RID: 97845
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1E;

	// Token: 0x04017E36 RID: 97846
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1F;

	// Token: 0x04017E37 RID: 97847
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache20;

	// Token: 0x04017E38 RID: 97848
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache21;

	// Token: 0x04017E39 RID: 97849
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache22;

	// Token: 0x04017E3A RID: 97850
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache23;

	// Token: 0x04017E3B RID: 97851
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache24;

	// Token: 0x04017E3C RID: 97852
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache25;

	// Token: 0x04017E3D RID: 97853
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache26;

	// Token: 0x04017E3E RID: 97854
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache27;

	// Token: 0x04017E3F RID: 97855
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache28;

	// Token: 0x04017E40 RID: 97856
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache29;

	// Token: 0x04017E41 RID: 97857
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2A;

	// Token: 0x04017E42 RID: 97858
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2B;

	// Token: 0x04017E43 RID: 97859
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2C;

	// Token: 0x04017E44 RID: 97860
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2D;

	// Token: 0x04017E45 RID: 97861
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2E;

	// Token: 0x04017E46 RID: 97862
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2F;

	// Token: 0x04017E47 RID: 97863
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache30;

	// Token: 0x04017E48 RID: 97864
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache31;

	// Token: 0x04017E49 RID: 97865
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache32;

	// Token: 0x04017E4A RID: 97866
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache33;

	// Token: 0x04017E4B RID: 97867
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache34;

	// Token: 0x04017E4C RID: 97868
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache35;

	// Token: 0x04017E4D RID: 97869
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache36;

	// Token: 0x04017E4E RID: 97870
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache37;
}
