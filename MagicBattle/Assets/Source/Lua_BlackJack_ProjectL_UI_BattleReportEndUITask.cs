using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using BlackJack.BJFramework.Runtime.UI;
using BlackJack.ProjectL.Common;
using BlackJack.ProjectL.UI;
using SLua;
using UnityEngine.Scripting;

// Token: 0x020013B1 RID: 5041
[Preserve]
public class Lua_BlackJack_ProjectL_UI_BattleReportEndUITask : LuaObject
{
	// Token: 0x0601BD77 RID: 114039 RVA: 0x00885B48 File Offset: 0x00883D48
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int constructor(IntPtr l)
	{
		int result;
		try
		{
			string name;
			LuaObject.checkType(l, 2, out name);
			BattleReportEndUITask o = new BattleReportEndUITask(name);
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

	// Token: 0x0601BD78 RID: 114040 RVA: 0x00885B9C File Offset: 0x00883D9C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int StartUITask_s(IntPtr l)
	{
		int result;
		try
		{
			int total = LuaDLL.lua_gettop(l);
			if (LuaObject.matchType(l, total, 1, typeof(ArenaBattleReport)))
			{
				ArenaBattleReport battleReport;
				LuaObject.checkType<ArenaBattleReport>(l, 1, out battleReport);
				BattleReportEndUITask o = BattleReportEndUITask.StartUITask(battleReport);
				LuaObject.pushValue(l, true);
				LuaObject.pushValue(l, o);
				result = 2;
			}
			else if (LuaObject.matchType(l, total, 1, typeof(RealTimePVPBattleReport)))
			{
				RealTimePVPBattleReport battleReport2;
				LuaObject.checkType<RealTimePVPBattleReport>(l, 1, out battleReport2);
				BattleReportEndUITask o2 = BattleReportEndUITask.StartUITask(battleReport2);
				LuaObject.pushValue(l, true);
				LuaObject.pushValue(l, o2);
				result = 2;
			}
			else
			{
				LuaObject.pushValue(l, false);
				LuaDLL.lua_pushstring(l, "No matched override function StartUITask to call");
				result = 2;
			}
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601BD79 RID: 114041 RVA: 0x00885C68 File Offset: 0x00883E68
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int OnStart(IntPtr l)
	{
		int result;
		try
		{
			BattleReportEndUITask battleReportEndUITask = (BattleReportEndUITask)LuaObject.checkSelf(l);
			UIIntent intent;
			LuaObject.checkType<UIIntent>(l, 2, out intent);
			bool b = battleReportEndUITask.m_luaExportHelper.OnStart(intent);
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

	// Token: 0x0601BD7A RID: 114042 RVA: 0x00885CD0 File Offset: 0x00883ED0
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int OnResume(IntPtr l)
	{
		int result;
		try
		{
			BattleReportEndUITask battleReportEndUITask = (BattleReportEndUITask)LuaObject.checkSelf(l);
			UIIntent intent;
			LuaObject.checkType<UIIntent>(l, 2, out intent);
			bool b = battleReportEndUITask.m_luaExportHelper.OnResume(intent);
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

	// Token: 0x0601BD7B RID: 114043 RVA: 0x00885D38 File Offset: 0x00883F38
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int InitDataFromUIIntent(IntPtr l)
	{
		int result;
		try
		{
			BattleReportEndUITask battleReportEndUITask = (BattleReportEndUITask)LuaObject.checkSelf(l);
			UIIntent intent;
			LuaObject.checkType<UIIntent>(l, 2, out intent);
			battleReportEndUITask.m_luaExportHelper.InitDataFromUIIntent(intent);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601BD7C RID: 114044 RVA: 0x00885D94 File Offset: 0x00883F94
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int InitAllUIControllers(IntPtr l)
	{
		int result;
		try
		{
			BattleReportEndUITask battleReportEndUITask = (BattleReportEndUITask)LuaObject.checkSelf(l);
			battleReportEndUITask.m_luaExportHelper.InitAllUIControllers();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601BD7D RID: 114045 RVA: 0x00885DE8 File Offset: 0x00883FE8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int ClearAllContextAndRes(IntPtr l)
	{
		int result;
		try
		{
			BattleReportEndUITask battleReportEndUITask = (BattleReportEndUITask)LuaObject.checkSelf(l);
			battleReportEndUITask.m_luaExportHelper.ClearAllContextAndRes();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601BD7E RID: 114046 RVA: 0x00885E3C File Offset: 0x0088403C
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int UpdateView(IntPtr l)
	{
		int result;
		try
		{
			BattleReportEndUITask battleReportEndUITask = (BattleReportEndUITask)LuaObject.checkSelf(l);
			battleReportEndUITask.m_luaExportHelper.UpdateView();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601BD7F RID: 114047 RVA: 0x00885E90 File Offset: 0x00884090
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int BattleReportEndUIController_OnClose(IntPtr l)
	{
		int result;
		try
		{
			BattleReportEndUITask battleReportEndUITask = (BattleReportEndUITask)LuaObject.checkSelf(l);
			battleReportEndUITask.m_luaExportHelper.BattleReportEndUIController_OnClose();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601BD80 RID: 114048 RVA: 0x00885EE4 File Offset: 0x008840E4
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int BattleReportEndUIController_OnPlayAgain(IntPtr l)
	{
		int result;
		try
		{
			BattleReportEndUITask battleReportEndUITask = (BattleReportEndUITask)LuaObject.checkSelf(l);
			battleReportEndUITask.m_luaExportHelper.BattleReportEndUIController_OnPlayAgain();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601BD81 RID: 114049 RVA: 0x00885F38 File Offset: 0x00884138
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_OnStart(IntPtr l)
	{
		int result;
		try
		{
			BattleReportEndUITask battleReportEndUITask = (BattleReportEndUITask)LuaObject.checkSelf(l);
			UIIntent intent;
			LuaObject.checkType<UIIntent>(l, 2, out intent);
			bool b = battleReportEndUITask.m_luaExportHelper.__callBase_OnStart(intent);
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

	// Token: 0x0601BD82 RID: 114050 RVA: 0x00885FA0 File Offset: 0x008841A0
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int __callBase_OnStop(IntPtr l)
	{
		int result;
		try
		{
			BattleReportEndUITask battleReportEndUITask = (BattleReportEndUITask)LuaObject.checkSelf(l);
			battleReportEndUITask.m_luaExportHelper.__callBase_OnStop();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601BD83 RID: 114051 RVA: 0x00885FF4 File Offset: 0x008841F4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_OnPause(IntPtr l)
	{
		int result;
		try
		{
			BattleReportEndUITask battleReportEndUITask = (BattleReportEndUITask)LuaObject.checkSelf(l);
			battleReportEndUITask.m_luaExportHelper.__callBase_OnPause();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601BD84 RID: 114052 RVA: 0x00886048 File Offset: 0x00884248
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_OnResume(IntPtr l)
	{
		int result;
		try
		{
			BattleReportEndUITask battleReportEndUITask = (BattleReportEndUITask)LuaObject.checkSelf(l);
			UIIntent intent;
			LuaObject.checkType<UIIntent>(l, 2, out intent);
			bool b = battleReportEndUITask.m_luaExportHelper.__callBase_OnResume(intent);
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

	// Token: 0x0601BD85 RID: 114053 RVA: 0x008860B0 File Offset: 0x008842B0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_OnNewIntent(IntPtr l)
	{
		int result;
		try
		{
			BattleReportEndUITask battleReportEndUITask = (BattleReportEndUITask)LuaObject.checkSelf(l);
			UIIntent intent;
			LuaObject.checkType<UIIntent>(l, 2, out intent);
			bool b = battleReportEndUITask.m_luaExportHelper.__callBase_OnNewIntent(intent);
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

	// Token: 0x0601BD86 RID: 114054 RVA: 0x00886118 File Offset: 0x00884318
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_EnableUIInput(IntPtr l)
	{
		int result;
		try
		{
			BattleReportEndUITask battleReportEndUITask = (BattleReportEndUITask)LuaObject.checkSelf(l);
			bool isEnable;
			LuaObject.checkType(l, 2, out isEnable);
			bool? isGlobalEnable;
			LuaObject.checkNullable<bool>(l, 3, out isGlobalEnable);
			battleReportEndUITask.m_luaExportHelper.__callBase_EnableUIInput(isEnable, isGlobalEnable);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601BD87 RID: 114055 RVA: 0x00886184 File Offset: 0x00884384
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_IsNeedLoadDynamicRes(IntPtr l)
	{
		int result;
		try
		{
			BattleReportEndUITask battleReportEndUITask = (BattleReportEndUITask)LuaObject.checkSelf(l);
			bool b = battleReportEndUITask.m_luaExportHelper.__callBase_IsNeedLoadDynamicRes();
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

	// Token: 0x0601BD88 RID: 114056 RVA: 0x008861E0 File Offset: 0x008843E0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_CollectAllDynamicResForLoad(IntPtr l)
	{
		int result;
		try
		{
			BattleReportEndUITask battleReportEndUITask = (BattleReportEndUITask)LuaObject.checkSelf(l);
			List<string> o = battleReportEndUITask.m_luaExportHelper.__callBase_CollectAllDynamicResForLoad();
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

	// Token: 0x0601BD89 RID: 114057 RVA: 0x0088623C File Offset: 0x0088443C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_RegisterPlayerContextEvents(IntPtr l)
	{
		int result;
		try
		{
			BattleReportEndUITask battleReportEndUITask = (BattleReportEndUITask)LuaObject.checkSelf(l);
			battleReportEndUITask.m_luaExportHelper.__callBase_RegisterPlayerContextEvents();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601BD8A RID: 114058 RVA: 0x00886290 File Offset: 0x00884490
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_UnregisterPlayerContextEvents(IntPtr l)
	{
		int result;
		try
		{
			BattleReportEndUITask battleReportEndUITask = (BattleReportEndUITask)LuaObject.checkSelf(l);
			battleReportEndUITask.m_luaExportHelper.__callBase_UnregisterPlayerContextEvents();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601BD8B RID: 114059 RVA: 0x008862E4 File Offset: 0x008844E4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_PostUpdateView(IntPtr l)
	{
		int result;
		try
		{
			BattleReportEndUITask battleReportEndUITask = (BattleReportEndUITask)LuaObject.checkSelf(l);
			battleReportEndUITask.m_luaExportHelper.__callBase_PostUpdateView();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601BD8C RID: 114060 RVA: 0x00886338 File Offset: 0x00884538
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_CollectPreloadResourceList(IntPtr l)
	{
		int result;
		try
		{
			BattleReportEndUITask battleReportEndUITask = (BattleReportEndUITask)LuaObject.checkSelf(l);
			battleReportEndUITask.m_luaExportHelper.__callBase_CollectPreloadResourceList();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601BD8D RID: 114061 RVA: 0x0088638C File Offset: 0x0088458C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_ClearAssetList(IntPtr l)
	{
		int result;
		try
		{
			BattleReportEndUITask battleReportEndUITask = (BattleReportEndUITask)LuaObject.checkSelf(l);
			battleReportEndUITask.m_luaExportHelper.__callBase_ClearAssetList();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601BD8E RID: 114062 RVA: 0x008863E0 File Offset: 0x008845E0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_CollectAsset(IntPtr l)
	{
		int result;
		try
		{
			BattleReportEndUITask battleReportEndUITask = (BattleReportEndUITask)LuaObject.checkSelf(l);
			string assetName;
			LuaObject.checkType(l, 2, out assetName);
			battleReportEndUITask.m_luaExportHelper.__callBase_CollectAsset(assetName);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601BD8F RID: 114063 RVA: 0x0088643C File Offset: 0x0088463C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_CollectSpriteAsset(IntPtr l)
	{
		int result;
		try
		{
			BattleReportEndUITask battleReportEndUITask = (BattleReportEndUITask)LuaObject.checkSelf(l);
			string assetName;
			LuaObject.checkType(l, 2, out assetName);
			battleReportEndUITask.m_luaExportHelper.__callBase_CollectSpriteAsset(assetName);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601BD90 RID: 114064 RVA: 0x00886498 File Offset: 0x00884698
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_CollectFxAsset(IntPtr l)
	{
		int result;
		try
		{
			BattleReportEndUITask battleReportEndUITask = (BattleReportEndUITask)LuaObject.checkSelf(l);
			string assetName;
			LuaObject.checkType(l, 2, out assetName);
			battleReportEndUITask.m_luaExportHelper.__callBase_CollectFxAsset(assetName);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601BD91 RID: 114065 RVA: 0x008864F4 File Offset: 0x008846F4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_StartLoadCustomAssets(IntPtr l)
	{
		int result;
		try
		{
			BattleReportEndUITask battleReportEndUITask = (BattleReportEndUITask)LuaObject.checkSelf(l);
			Action onLoadCompleted;
			LuaObject.checkDelegate<Action>(l, 2, out onLoadCompleted);
			battleReportEndUITask.m_luaExportHelper.__callBase_StartLoadCustomAssets(onLoadCompleted);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601BD92 RID: 114066 RVA: 0x00886550 File Offset: 0x00884750
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_IsLoadingCustomAssets(IntPtr l)
	{
		int result;
		try
		{
			BattleReportEndUITask battleReportEndUITask = (BattleReportEndUITask)LuaObject.checkSelf(l);
			bool b = battleReportEndUITask.m_luaExportHelper.__callBase_IsLoadingCustomAssets();
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

	// Token: 0x0601BD93 RID: 114067 RVA: 0x008865AC File Offset: 0x008847AC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_IsPipeLineRunning(IntPtr l)
	{
		int result;
		try
		{
			BattleReportEndUITask battleReportEndUITask = (BattleReportEndUITask)LuaObject.checkSelf(l);
			bool b = battleReportEndUITask.m_luaExportHelper.__callBase_IsPipeLineRunning();
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

	// Token: 0x0601BD94 RID: 114068 RVA: 0x00886608 File Offset: 0x00884808
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_IsOpeningUI(IntPtr l)
	{
		int result;
		try
		{
			BattleReportEndUITask battleReportEndUITask = (BattleReportEndUITask)LuaObject.checkSelf(l);
			bool b = battleReportEndUITask.m_luaExportHelper.__callBase_IsOpeningUI();
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

	// Token: 0x0601BD95 RID: 114069 RVA: 0x00886664 File Offset: 0x00884864
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_ReturnPrevUITask(IntPtr l)
	{
		int result;
		try
		{
			BattleReportEndUITask battleReportEndUITask = (BattleReportEndUITask)LuaObject.checkSelf(l);
			UITaskBase o = battleReportEndUITask.m_luaExportHelper.__callBase_ReturnPrevUITask();
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

	// Token: 0x0601BD96 RID: 114070 RVA: 0x008866C0 File Offset: 0x008848C0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_ClearUnusedDynamicResourceCache(IntPtr l)
	{
		int result;
		try
		{
			BattleReportEndUITask battleReportEndUITask = (BattleReportEndUITask)LuaObject.checkSelf(l);
			battleReportEndUITask.m_luaExportHelper.__callBase_ClearUnusedDynamicResourceCache();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601BD97 RID: 114071 RVA: 0x00886714 File Offset: 0x00884914
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_OnMemoryWarning(IntPtr l)
	{
		int result;
		try
		{
			BattleReportEndUITask battleReportEndUITask = (BattleReportEndUITask)LuaObject.checkSelf(l);
			battleReportEndUITask.m_luaExportHelper.__callBase_OnMemoryWarning();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601BD98 RID: 114072 RVA: 0x00886768 File Offset: 0x00884968
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callDele_EventOnPlayAgain(IntPtr l)
	{
		int result;
		try
		{
			BattleReportEndUITask battleReportEndUITask = (BattleReportEndUITask)LuaObject.checkSelf(l);
			battleReportEndUITask.m_luaExportHelper.__callDele_EventOnPlayAgain();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601BD99 RID: 114073 RVA: 0x008867BC File Offset: 0x008849BC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __clearDele_EventOnPlayAgain(IntPtr l)
	{
		int result;
		try
		{
			BattleReportEndUITask battleReportEndUITask = (BattleReportEndUITask)LuaObject.checkSelf(l);
			battleReportEndUITask.m_luaExportHelper.__clearDele_EventOnPlayAgain();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601BD9A RID: 114074 RVA: 0x00886810 File Offset: 0x00884A10
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callDele_EventOnClose(IntPtr l)
	{
		int result;
		try
		{
			BattleReportEndUITask battleReportEndUITask = (BattleReportEndUITask)LuaObject.checkSelf(l);
			battleReportEndUITask.m_luaExportHelper.__callDele_EventOnClose();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601BD9B RID: 114075 RVA: 0x00886864 File Offset: 0x00884A64
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __clearDele_EventOnClose(IntPtr l)
	{
		int result;
		try
		{
			BattleReportEndUITask battleReportEndUITask = (BattleReportEndUITask)LuaObject.checkSelf(l);
			battleReportEndUITask.m_luaExportHelper.__clearDele_EventOnClose();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601BD9C RID: 114076 RVA: 0x008868B8 File Offset: 0x00884AB8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_EventOnPlayAgain(IntPtr l)
	{
		int result;
		try
		{
			BattleReportEndUITask battleReportEndUITask = (BattleReportEndUITask)LuaObject.checkSelf(l);
			Action value;
			int num = LuaObject.checkDelegate<Action>(l, 2, out value);
			if (num != 0)
			{
				if (num == 1)
				{
					battleReportEndUITask.EventOnPlayAgain += value;
				}
				else if (num == 2)
				{
					battleReportEndUITask.EventOnPlayAgain -= value;
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

	// Token: 0x0601BD9D RID: 114077 RVA: 0x00886938 File Offset: 0x00884B38
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_EventOnClose(IntPtr l)
	{
		int result;
		try
		{
			BattleReportEndUITask battleReportEndUITask = (BattleReportEndUITask)LuaObject.checkSelf(l);
			Action value;
			int num = LuaObject.checkDelegate<Action>(l, 2, out value);
			if (num != 0)
			{
				if (num == 1)
				{
					battleReportEndUITask.EventOnClose += value;
				}
				else if (num == 2)
				{
					battleReportEndUITask.EventOnClose -= value;
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

	// Token: 0x0601BD9E RID: 114078 RVA: 0x008869B8 File Offset: 0x00884BB8
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_m_layerDescArray(IntPtr l)
	{
		int result;
		try
		{
			BattleReportEndUITask battleReportEndUITask = (BattleReportEndUITask)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, battleReportEndUITask.m_luaExportHelper.m_layerDescArray);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601BD9F RID: 114079 RVA: 0x00886A10 File Offset: 0x00884C10
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_layerDescArray(IntPtr l)
	{
		int result;
		try
		{
			BattleReportEndUITask battleReportEndUITask = (BattleReportEndUITask)LuaObject.checkSelf(l);
			UITaskBase.LayerDesc[] layerDescArray;
			LuaObject.checkArray<UITaskBase.LayerDesc>(l, 2, out layerDescArray);
			battleReportEndUITask.m_luaExportHelper.m_layerDescArray = layerDescArray;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601BDA0 RID: 114080 RVA: 0x00886A6C File Offset: 0x00884C6C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_uiCtrlDescArray(IntPtr l)
	{
		int result;
		try
		{
			BattleReportEndUITask battleReportEndUITask = (BattleReportEndUITask)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, battleReportEndUITask.m_luaExportHelper.m_uiCtrlDescArray);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601BDA1 RID: 114081 RVA: 0x00886AC4 File Offset: 0x00884CC4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_uiCtrlDescArray(IntPtr l)
	{
		int result;
		try
		{
			BattleReportEndUITask battleReportEndUITask = (BattleReportEndUITask)LuaObject.checkSelf(l);
			UITaskBase.UIControllerDesc[] uiCtrlDescArray;
			LuaObject.checkArray<UITaskBase.UIControllerDesc>(l, 2, out uiCtrlDescArray);
			battleReportEndUITask.m_luaExportHelper.m_uiCtrlDescArray = uiCtrlDescArray;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601BDA2 RID: 114082 RVA: 0x00886B20 File Offset: 0x00884D20
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_battleReportEndUIController(IntPtr l)
	{
		int result;
		try
		{
			BattleReportEndUITask battleReportEndUITask = (BattleReportEndUITask)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, battleReportEndUITask.m_luaExportHelper.m_battleReportEndUIController);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601BDA3 RID: 114083 RVA: 0x00886B78 File Offset: 0x00884D78
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_battleReportEndUIController(IntPtr l)
	{
		int result;
		try
		{
			BattleReportEndUITask battleReportEndUITask = (BattleReportEndUITask)LuaObject.checkSelf(l);
			BattleReportEndUIController battleReportEndUIController;
			LuaObject.checkType<BattleReportEndUIController>(l, 2, out battleReportEndUIController);
			battleReportEndUITask.m_luaExportHelper.m_battleReportEndUIController = battleReportEndUIController;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601BDA4 RID: 114084 RVA: 0x00886BD4 File Offset: 0x00884DD4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_arenaBattleReport(IntPtr l)
	{
		int result;
		try
		{
			BattleReportEndUITask battleReportEndUITask = (BattleReportEndUITask)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, battleReportEndUITask.m_luaExportHelper.m_arenaBattleReport);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601BDA5 RID: 114085 RVA: 0x00886C2C File Offset: 0x00884E2C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_arenaBattleReport(IntPtr l)
	{
		int result;
		try
		{
			BattleReportEndUITask battleReportEndUITask = (BattleReportEndUITask)LuaObject.checkSelf(l);
			ArenaBattleReport arenaBattleReport;
			LuaObject.checkType<ArenaBattleReport>(l, 2, out arenaBattleReport);
			battleReportEndUITask.m_luaExportHelper.m_arenaBattleReport = arenaBattleReport;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601BDA6 RID: 114086 RVA: 0x00886C88 File Offset: 0x00884E88
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_realtimePVPBattleReport(IntPtr l)
	{
		int result;
		try
		{
			BattleReportEndUITask battleReportEndUITask = (BattleReportEndUITask)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, battleReportEndUITask.m_luaExportHelper.m_realtimePVPBattleReport);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601BDA7 RID: 114087 RVA: 0x00886CE0 File Offset: 0x00884EE0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_realtimePVPBattleReport(IntPtr l)
	{
		int result;
		try
		{
			BattleReportEndUITask battleReportEndUITask = (BattleReportEndUITask)LuaObject.checkSelf(l);
			RealTimePVPBattleReport realtimePVPBattleReport;
			LuaObject.checkType<RealTimePVPBattleReport>(l, 2, out realtimePVPBattleReport);
			battleReportEndUITask.m_luaExportHelper.m_realtimePVPBattleReport = realtimePVPBattleReport;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601BDA8 RID: 114088 RVA: 0x00886D3C File Offset: 0x00884F3C
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_LayerDescArray(IntPtr l)
	{
		int result;
		try
		{
			BattleReportEndUITask battleReportEndUITask = (BattleReportEndUITask)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, battleReportEndUITask.m_luaExportHelper.LayerDescArray);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601BDA9 RID: 114089 RVA: 0x00886D94 File Offset: 0x00884F94
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_UICtrlDescArray(IntPtr l)
	{
		int result;
		try
		{
			BattleReportEndUITask battleReportEndUITask = (BattleReportEndUITask)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, battleReportEndUITask.m_luaExportHelper.UICtrlDescArray);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601BDAA RID: 114090 RVA: 0x00886DEC File Offset: 0x00884FEC
	[Preserve]
	public static void reg(IntPtr l)
	{
		LuaObject.getTypeTable(l, "BlackJack.ProjectL.UI.BattleReportEndUITask");
		if (Lua_BlackJack_ProjectL_UI_BattleReportEndUITask.<>f__mg$cache0 == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleReportEndUITask.<>f__mg$cache0 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleReportEndUITask.StartUITask_s);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_BattleReportEndUITask.<>f__mg$cache0);
		if (Lua_BlackJack_ProjectL_UI_BattleReportEndUITask.<>f__mg$cache1 == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleReportEndUITask.<>f__mg$cache1 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleReportEndUITask.OnStart);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_BattleReportEndUITask.<>f__mg$cache1);
		if (Lua_BlackJack_ProjectL_UI_BattleReportEndUITask.<>f__mg$cache2 == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleReportEndUITask.<>f__mg$cache2 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleReportEndUITask.OnResume);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_BattleReportEndUITask.<>f__mg$cache2);
		if (Lua_BlackJack_ProjectL_UI_BattleReportEndUITask.<>f__mg$cache3 == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleReportEndUITask.<>f__mg$cache3 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleReportEndUITask.InitDataFromUIIntent);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_BattleReportEndUITask.<>f__mg$cache3);
		if (Lua_BlackJack_ProjectL_UI_BattleReportEndUITask.<>f__mg$cache4 == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleReportEndUITask.<>f__mg$cache4 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleReportEndUITask.InitAllUIControllers);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_BattleReportEndUITask.<>f__mg$cache4);
		if (Lua_BlackJack_ProjectL_UI_BattleReportEndUITask.<>f__mg$cache5 == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleReportEndUITask.<>f__mg$cache5 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleReportEndUITask.ClearAllContextAndRes);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_BattleReportEndUITask.<>f__mg$cache5);
		if (Lua_BlackJack_ProjectL_UI_BattleReportEndUITask.<>f__mg$cache6 == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleReportEndUITask.<>f__mg$cache6 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleReportEndUITask.UpdateView);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_BattleReportEndUITask.<>f__mg$cache6);
		if (Lua_BlackJack_ProjectL_UI_BattleReportEndUITask.<>f__mg$cache7 == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleReportEndUITask.<>f__mg$cache7 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleReportEndUITask.BattleReportEndUIController_OnClose);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_BattleReportEndUITask.<>f__mg$cache7);
		if (Lua_BlackJack_ProjectL_UI_BattleReportEndUITask.<>f__mg$cache8 == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleReportEndUITask.<>f__mg$cache8 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleReportEndUITask.BattleReportEndUIController_OnPlayAgain);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_BattleReportEndUITask.<>f__mg$cache8);
		if (Lua_BlackJack_ProjectL_UI_BattleReportEndUITask.<>f__mg$cache9 == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleReportEndUITask.<>f__mg$cache9 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleReportEndUITask.__callBase_OnStart);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_BattleReportEndUITask.<>f__mg$cache9);
		if (Lua_BlackJack_ProjectL_UI_BattleReportEndUITask.<>f__mg$cacheA == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleReportEndUITask.<>f__mg$cacheA = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleReportEndUITask.__callBase_OnStop);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_BattleReportEndUITask.<>f__mg$cacheA);
		if (Lua_BlackJack_ProjectL_UI_BattleReportEndUITask.<>f__mg$cacheB == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleReportEndUITask.<>f__mg$cacheB = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleReportEndUITask.__callBase_OnPause);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_BattleReportEndUITask.<>f__mg$cacheB);
		if (Lua_BlackJack_ProjectL_UI_BattleReportEndUITask.<>f__mg$cacheC == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleReportEndUITask.<>f__mg$cacheC = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleReportEndUITask.__callBase_OnResume);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_BattleReportEndUITask.<>f__mg$cacheC);
		if (Lua_BlackJack_ProjectL_UI_BattleReportEndUITask.<>f__mg$cacheD == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleReportEndUITask.<>f__mg$cacheD = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleReportEndUITask.__callBase_OnNewIntent);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_BattleReportEndUITask.<>f__mg$cacheD);
		if (Lua_BlackJack_ProjectL_UI_BattleReportEndUITask.<>f__mg$cacheE == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleReportEndUITask.<>f__mg$cacheE = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleReportEndUITask.__callBase_EnableUIInput);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_BattleReportEndUITask.<>f__mg$cacheE);
		if (Lua_BlackJack_ProjectL_UI_BattleReportEndUITask.<>f__mg$cacheF == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleReportEndUITask.<>f__mg$cacheF = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleReportEndUITask.__callBase_IsNeedLoadDynamicRes);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_BattleReportEndUITask.<>f__mg$cacheF);
		if (Lua_BlackJack_ProjectL_UI_BattleReportEndUITask.<>f__mg$cache10 == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleReportEndUITask.<>f__mg$cache10 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleReportEndUITask.__callBase_CollectAllDynamicResForLoad);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_BattleReportEndUITask.<>f__mg$cache10);
		if (Lua_BlackJack_ProjectL_UI_BattleReportEndUITask.<>f__mg$cache11 == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleReportEndUITask.<>f__mg$cache11 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleReportEndUITask.__callBase_RegisterPlayerContextEvents);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_BattleReportEndUITask.<>f__mg$cache11);
		if (Lua_BlackJack_ProjectL_UI_BattleReportEndUITask.<>f__mg$cache12 == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleReportEndUITask.<>f__mg$cache12 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleReportEndUITask.__callBase_UnregisterPlayerContextEvents);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_BattleReportEndUITask.<>f__mg$cache12);
		if (Lua_BlackJack_ProjectL_UI_BattleReportEndUITask.<>f__mg$cache13 == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleReportEndUITask.<>f__mg$cache13 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleReportEndUITask.__callBase_PostUpdateView);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_BattleReportEndUITask.<>f__mg$cache13);
		if (Lua_BlackJack_ProjectL_UI_BattleReportEndUITask.<>f__mg$cache14 == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleReportEndUITask.<>f__mg$cache14 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleReportEndUITask.__callBase_CollectPreloadResourceList);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_BattleReportEndUITask.<>f__mg$cache14);
		if (Lua_BlackJack_ProjectL_UI_BattleReportEndUITask.<>f__mg$cache15 == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleReportEndUITask.<>f__mg$cache15 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleReportEndUITask.__callBase_ClearAssetList);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_BattleReportEndUITask.<>f__mg$cache15);
		if (Lua_BlackJack_ProjectL_UI_BattleReportEndUITask.<>f__mg$cache16 == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleReportEndUITask.<>f__mg$cache16 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleReportEndUITask.__callBase_CollectAsset);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_BattleReportEndUITask.<>f__mg$cache16);
		if (Lua_BlackJack_ProjectL_UI_BattleReportEndUITask.<>f__mg$cache17 == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleReportEndUITask.<>f__mg$cache17 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleReportEndUITask.__callBase_CollectSpriteAsset);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_BattleReportEndUITask.<>f__mg$cache17);
		if (Lua_BlackJack_ProjectL_UI_BattleReportEndUITask.<>f__mg$cache18 == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleReportEndUITask.<>f__mg$cache18 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleReportEndUITask.__callBase_CollectFxAsset);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_BattleReportEndUITask.<>f__mg$cache18);
		if (Lua_BlackJack_ProjectL_UI_BattleReportEndUITask.<>f__mg$cache19 == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleReportEndUITask.<>f__mg$cache19 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleReportEndUITask.__callBase_StartLoadCustomAssets);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_BattleReportEndUITask.<>f__mg$cache19);
		if (Lua_BlackJack_ProjectL_UI_BattleReportEndUITask.<>f__mg$cache1A == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleReportEndUITask.<>f__mg$cache1A = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleReportEndUITask.__callBase_IsLoadingCustomAssets);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_BattleReportEndUITask.<>f__mg$cache1A);
		if (Lua_BlackJack_ProjectL_UI_BattleReportEndUITask.<>f__mg$cache1B == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleReportEndUITask.<>f__mg$cache1B = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleReportEndUITask.__callBase_IsPipeLineRunning);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_BattleReportEndUITask.<>f__mg$cache1B);
		if (Lua_BlackJack_ProjectL_UI_BattleReportEndUITask.<>f__mg$cache1C == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleReportEndUITask.<>f__mg$cache1C = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleReportEndUITask.__callBase_IsOpeningUI);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_BattleReportEndUITask.<>f__mg$cache1C);
		if (Lua_BlackJack_ProjectL_UI_BattleReportEndUITask.<>f__mg$cache1D == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleReportEndUITask.<>f__mg$cache1D = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleReportEndUITask.__callBase_ReturnPrevUITask);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_BattleReportEndUITask.<>f__mg$cache1D);
		if (Lua_BlackJack_ProjectL_UI_BattleReportEndUITask.<>f__mg$cache1E == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleReportEndUITask.<>f__mg$cache1E = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleReportEndUITask.__callBase_ClearUnusedDynamicResourceCache);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_BattleReportEndUITask.<>f__mg$cache1E);
		if (Lua_BlackJack_ProjectL_UI_BattleReportEndUITask.<>f__mg$cache1F == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleReportEndUITask.<>f__mg$cache1F = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleReportEndUITask.__callBase_OnMemoryWarning);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_BattleReportEndUITask.<>f__mg$cache1F);
		if (Lua_BlackJack_ProjectL_UI_BattleReportEndUITask.<>f__mg$cache20 == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleReportEndUITask.<>f__mg$cache20 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleReportEndUITask.__callDele_EventOnPlayAgain);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_BattleReportEndUITask.<>f__mg$cache20);
		if (Lua_BlackJack_ProjectL_UI_BattleReportEndUITask.<>f__mg$cache21 == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleReportEndUITask.<>f__mg$cache21 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleReportEndUITask.__clearDele_EventOnPlayAgain);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_BattleReportEndUITask.<>f__mg$cache21);
		if (Lua_BlackJack_ProjectL_UI_BattleReportEndUITask.<>f__mg$cache22 == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleReportEndUITask.<>f__mg$cache22 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleReportEndUITask.__callDele_EventOnClose);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_BattleReportEndUITask.<>f__mg$cache22);
		if (Lua_BlackJack_ProjectL_UI_BattleReportEndUITask.<>f__mg$cache23 == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleReportEndUITask.<>f__mg$cache23 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleReportEndUITask.__clearDele_EventOnClose);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_BattleReportEndUITask.<>f__mg$cache23);
		string name = "EventOnPlayAgain";
		LuaCSFunction get = null;
		if (Lua_BlackJack_ProjectL_UI_BattleReportEndUITask.<>f__mg$cache24 == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleReportEndUITask.<>f__mg$cache24 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleReportEndUITask.set_EventOnPlayAgain);
		}
		LuaObject.addMember(l, name, get, Lua_BlackJack_ProjectL_UI_BattleReportEndUITask.<>f__mg$cache24, true);
		string name2 = "EventOnClose";
		LuaCSFunction get2 = null;
		if (Lua_BlackJack_ProjectL_UI_BattleReportEndUITask.<>f__mg$cache25 == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleReportEndUITask.<>f__mg$cache25 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleReportEndUITask.set_EventOnClose);
		}
		LuaObject.addMember(l, name2, get2, Lua_BlackJack_ProjectL_UI_BattleReportEndUITask.<>f__mg$cache25, true);
		string name3 = "m_layerDescArray";
		if (Lua_BlackJack_ProjectL_UI_BattleReportEndUITask.<>f__mg$cache26 == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleReportEndUITask.<>f__mg$cache26 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleReportEndUITask.get_m_layerDescArray);
		}
		LuaCSFunction get3 = Lua_BlackJack_ProjectL_UI_BattleReportEndUITask.<>f__mg$cache26;
		if (Lua_BlackJack_ProjectL_UI_BattleReportEndUITask.<>f__mg$cache27 == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleReportEndUITask.<>f__mg$cache27 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleReportEndUITask.set_m_layerDescArray);
		}
		LuaObject.addMember(l, name3, get3, Lua_BlackJack_ProjectL_UI_BattleReportEndUITask.<>f__mg$cache27, true);
		string name4 = "m_uiCtrlDescArray";
		if (Lua_BlackJack_ProjectL_UI_BattleReportEndUITask.<>f__mg$cache28 == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleReportEndUITask.<>f__mg$cache28 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleReportEndUITask.get_m_uiCtrlDescArray);
		}
		LuaCSFunction get4 = Lua_BlackJack_ProjectL_UI_BattleReportEndUITask.<>f__mg$cache28;
		if (Lua_BlackJack_ProjectL_UI_BattleReportEndUITask.<>f__mg$cache29 == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleReportEndUITask.<>f__mg$cache29 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleReportEndUITask.set_m_uiCtrlDescArray);
		}
		LuaObject.addMember(l, name4, get4, Lua_BlackJack_ProjectL_UI_BattleReportEndUITask.<>f__mg$cache29, true);
		string name5 = "m_battleReportEndUIController";
		if (Lua_BlackJack_ProjectL_UI_BattleReportEndUITask.<>f__mg$cache2A == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleReportEndUITask.<>f__mg$cache2A = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleReportEndUITask.get_m_battleReportEndUIController);
		}
		LuaCSFunction get5 = Lua_BlackJack_ProjectL_UI_BattleReportEndUITask.<>f__mg$cache2A;
		if (Lua_BlackJack_ProjectL_UI_BattleReportEndUITask.<>f__mg$cache2B == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleReportEndUITask.<>f__mg$cache2B = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleReportEndUITask.set_m_battleReportEndUIController);
		}
		LuaObject.addMember(l, name5, get5, Lua_BlackJack_ProjectL_UI_BattleReportEndUITask.<>f__mg$cache2B, true);
		string name6 = "m_arenaBattleReport";
		if (Lua_BlackJack_ProjectL_UI_BattleReportEndUITask.<>f__mg$cache2C == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleReportEndUITask.<>f__mg$cache2C = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleReportEndUITask.get_m_arenaBattleReport);
		}
		LuaCSFunction get6 = Lua_BlackJack_ProjectL_UI_BattleReportEndUITask.<>f__mg$cache2C;
		if (Lua_BlackJack_ProjectL_UI_BattleReportEndUITask.<>f__mg$cache2D == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleReportEndUITask.<>f__mg$cache2D = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleReportEndUITask.set_m_arenaBattleReport);
		}
		LuaObject.addMember(l, name6, get6, Lua_BlackJack_ProjectL_UI_BattleReportEndUITask.<>f__mg$cache2D, true);
		string name7 = "m_realtimePVPBattleReport";
		if (Lua_BlackJack_ProjectL_UI_BattleReportEndUITask.<>f__mg$cache2E == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleReportEndUITask.<>f__mg$cache2E = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleReportEndUITask.get_m_realtimePVPBattleReport);
		}
		LuaCSFunction get7 = Lua_BlackJack_ProjectL_UI_BattleReportEndUITask.<>f__mg$cache2E;
		if (Lua_BlackJack_ProjectL_UI_BattleReportEndUITask.<>f__mg$cache2F == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleReportEndUITask.<>f__mg$cache2F = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleReportEndUITask.set_m_realtimePVPBattleReport);
		}
		LuaObject.addMember(l, name7, get7, Lua_BlackJack_ProjectL_UI_BattleReportEndUITask.<>f__mg$cache2F, true);
		string name8 = "LayerDescArray";
		if (Lua_BlackJack_ProjectL_UI_BattleReportEndUITask.<>f__mg$cache30 == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleReportEndUITask.<>f__mg$cache30 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleReportEndUITask.get_LayerDescArray);
		}
		LuaObject.addMember(l, name8, Lua_BlackJack_ProjectL_UI_BattleReportEndUITask.<>f__mg$cache30, null, true);
		string name9 = "UICtrlDescArray";
		if (Lua_BlackJack_ProjectL_UI_BattleReportEndUITask.<>f__mg$cache31 == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleReportEndUITask.<>f__mg$cache31 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleReportEndUITask.get_UICtrlDescArray);
		}
		LuaObject.addMember(l, name9, Lua_BlackJack_ProjectL_UI_BattleReportEndUITask.<>f__mg$cache31, null, true);
		if (Lua_BlackJack_ProjectL_UI_BattleReportEndUITask.<>f__mg$cache32 == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleReportEndUITask.<>f__mg$cache32 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleReportEndUITask.constructor);
		}
		LuaObject.createTypeMetatable(l, Lua_BlackJack_ProjectL_UI_BattleReportEndUITask.<>f__mg$cache32, typeof(BattleReportEndUITask), typeof(UITask));
	}

	// Token: 0x04011FF7 RID: 73719
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache0;

	// Token: 0x04011FF8 RID: 73720
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1;

	// Token: 0x04011FF9 RID: 73721
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2;

	// Token: 0x04011FFA RID: 73722
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3;

	// Token: 0x04011FFB RID: 73723
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache4;

	// Token: 0x04011FFC RID: 73724
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache5;

	// Token: 0x04011FFD RID: 73725
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache6;

	// Token: 0x04011FFE RID: 73726
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache7;

	// Token: 0x04011FFF RID: 73727
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache8;

	// Token: 0x04012000 RID: 73728
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache9;

	// Token: 0x04012001 RID: 73729
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheA;

	// Token: 0x04012002 RID: 73730
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheB;

	// Token: 0x04012003 RID: 73731
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheC;

	// Token: 0x04012004 RID: 73732
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheD;

	// Token: 0x04012005 RID: 73733
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheE;

	// Token: 0x04012006 RID: 73734
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheF;

	// Token: 0x04012007 RID: 73735
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache10;

	// Token: 0x04012008 RID: 73736
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache11;

	// Token: 0x04012009 RID: 73737
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache12;

	// Token: 0x0401200A RID: 73738
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache13;

	// Token: 0x0401200B RID: 73739
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache14;

	// Token: 0x0401200C RID: 73740
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache15;

	// Token: 0x0401200D RID: 73741
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache16;

	// Token: 0x0401200E RID: 73742
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache17;

	// Token: 0x0401200F RID: 73743
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache18;

	// Token: 0x04012010 RID: 73744
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache19;

	// Token: 0x04012011 RID: 73745
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1A;

	// Token: 0x04012012 RID: 73746
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1B;

	// Token: 0x04012013 RID: 73747
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1C;

	// Token: 0x04012014 RID: 73748
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1D;

	// Token: 0x04012015 RID: 73749
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1E;

	// Token: 0x04012016 RID: 73750
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1F;

	// Token: 0x04012017 RID: 73751
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache20;

	// Token: 0x04012018 RID: 73752
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache21;

	// Token: 0x04012019 RID: 73753
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache22;

	// Token: 0x0401201A RID: 73754
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache23;

	// Token: 0x0401201B RID: 73755
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache24;

	// Token: 0x0401201C RID: 73756
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache25;

	// Token: 0x0401201D RID: 73757
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache26;

	// Token: 0x0401201E RID: 73758
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache27;

	// Token: 0x0401201F RID: 73759
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache28;

	// Token: 0x04012020 RID: 73760
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache29;

	// Token: 0x04012021 RID: 73761
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2A;

	// Token: 0x04012022 RID: 73762
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2B;

	// Token: 0x04012023 RID: 73763
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2C;

	// Token: 0x04012024 RID: 73764
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2D;

	// Token: 0x04012025 RID: 73765
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2E;

	// Token: 0x04012026 RID: 73766
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2F;

	// Token: 0x04012027 RID: 73767
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache30;

	// Token: 0x04012028 RID: 73768
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache31;

	// Token: 0x04012029 RID: 73769
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache32;
}
