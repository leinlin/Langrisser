using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using BlackJack.BJFramework.Runtime.UI;
using BlackJack.ProjectL.UI;
using SLua;
using UnityEngine.Scripting;

// Token: 0x02001364 RID: 4964
[Preserve]
public class Lua_BlackJack_ProjectL_UI_AppScoreUITask : LuaObject
{
	// Token: 0x0601AC35 RID: 109621 RVA: 0x007FC450 File Offset: 0x007FA650
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int constructor(IntPtr l)
	{
		int result;
		try
		{
			string name;
			LuaObject.checkType(l, 2, out name);
			AppScoreUITask o = new AppScoreUITask(name);
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

	// Token: 0x0601AC36 RID: 109622 RVA: 0x007FC4A4 File Offset: 0x007FA6A4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int ShowAppScoreUI_s(IntPtr l)
	{
		int result;
		try
		{
			UIIntent currIntent;
			LuaObject.checkType<UIIntent>(l, 1, out currIntent);
			AppScoreUITask.ShowAppScoreUI(currIntent);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601AC37 RID: 109623 RVA: 0x007FC4F0 File Offset: 0x007FA6F0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int CanScore_s(IntPtr l)
	{
		int result;
		try
		{
			bool b = AppScoreUITask.CanScore();
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

	// Token: 0x0601AC38 RID: 109624 RVA: 0x007FC538 File Offset: 0x007FA738
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int InitAllUIControllers(IntPtr l)
	{
		int result;
		try
		{
			AppScoreUITask appScoreUITask = (AppScoreUITask)LuaObject.checkSelf(l);
			appScoreUITask.m_luaExportHelper.InitAllUIControllers();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601AC39 RID: 109625 RVA: 0x007FC58C File Offset: 0x007FA78C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int ClearAllContextAndRes(IntPtr l)
	{
		int result;
		try
		{
			AppScoreUITask appScoreUITask = (AppScoreUITask)LuaObject.checkSelf(l);
			appScoreUITask.m_luaExportHelper.ClearAllContextAndRes();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601AC3A RID: 109626 RVA: 0x007FC5E0 File Offset: 0x007FA7E0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int UpdateView(IntPtr l)
	{
		int result;
		try
		{
			AppScoreUITask appScoreUITask = (AppScoreUITask)LuaObject.checkSelf(l);
			appScoreUITask.m_luaExportHelper.UpdateView();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601AC3B RID: 109627 RVA: 0x007FC634 File Offset: 0x007FA834
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int AppScoreUIController_OnGoScore(IntPtr l)
	{
		int result;
		try
		{
			AppScoreUITask appScoreUITask = (AppScoreUITask)LuaObject.checkSelf(l);
			appScoreUITask.m_luaExportHelper.AppScoreUIController_OnGoScore();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601AC3C RID: 109628 RVA: 0x007FC688 File Offset: 0x007FA888
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int AppScoreUIController_OnCloseAppScore(IntPtr l)
	{
		int result;
		try
		{
			AppScoreUITask appScoreUITask = (AppScoreUITask)LuaObject.checkSelf(l);
			appScoreUITask.m_luaExportHelper.AppScoreUIController_OnCloseAppScore();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601AC3D RID: 109629 RVA: 0x007FC6DC File Offset: 0x007FA8DC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int CloseSelf(IntPtr l)
	{
		int result;
		try
		{
			AppScoreUITask appScoreUITask = (AppScoreUITask)LuaObject.checkSelf(l);
			appScoreUITask.m_luaExportHelper.CloseSelf();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601AC3E RID: 109630 RVA: 0x007FC730 File Offset: 0x007FA930
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_OnStart(IntPtr l)
	{
		int result;
		try
		{
			AppScoreUITask appScoreUITask = (AppScoreUITask)LuaObject.checkSelf(l);
			UIIntent intent;
			LuaObject.checkType<UIIntent>(l, 2, out intent);
			bool b = appScoreUITask.m_luaExportHelper.__callBase_OnStart(intent);
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

	// Token: 0x0601AC3F RID: 109631 RVA: 0x007FC798 File Offset: 0x007FA998
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_OnStop(IntPtr l)
	{
		int result;
		try
		{
			AppScoreUITask appScoreUITask = (AppScoreUITask)LuaObject.checkSelf(l);
			appScoreUITask.m_luaExportHelper.__callBase_OnStop();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601AC40 RID: 109632 RVA: 0x007FC7EC File Offset: 0x007FA9EC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_OnPause(IntPtr l)
	{
		int result;
		try
		{
			AppScoreUITask appScoreUITask = (AppScoreUITask)LuaObject.checkSelf(l);
			appScoreUITask.m_luaExportHelper.__callBase_OnPause();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601AC41 RID: 109633 RVA: 0x007FC840 File Offset: 0x007FAA40
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_OnResume(IntPtr l)
	{
		int result;
		try
		{
			AppScoreUITask appScoreUITask = (AppScoreUITask)LuaObject.checkSelf(l);
			UIIntent intent;
			LuaObject.checkType<UIIntent>(l, 2, out intent);
			bool b = appScoreUITask.m_luaExportHelper.__callBase_OnResume(intent);
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

	// Token: 0x0601AC42 RID: 109634 RVA: 0x007FC8A8 File Offset: 0x007FAAA8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_OnNewIntent(IntPtr l)
	{
		int result;
		try
		{
			AppScoreUITask appScoreUITask = (AppScoreUITask)LuaObject.checkSelf(l);
			UIIntent intent;
			LuaObject.checkType<UIIntent>(l, 2, out intent);
			bool b = appScoreUITask.m_luaExportHelper.__callBase_OnNewIntent(intent);
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

	// Token: 0x0601AC43 RID: 109635 RVA: 0x007FC910 File Offset: 0x007FAB10
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_EnableUIInput(IntPtr l)
	{
		int result;
		try
		{
			AppScoreUITask appScoreUITask = (AppScoreUITask)LuaObject.checkSelf(l);
			bool isEnable;
			LuaObject.checkType(l, 2, out isEnable);
			bool? isGlobalEnable;
			LuaObject.checkNullable<bool>(l, 3, out isGlobalEnable);
			appScoreUITask.m_luaExportHelper.__callBase_EnableUIInput(isEnable, isGlobalEnable);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601AC44 RID: 109636 RVA: 0x007FC97C File Offset: 0x007FAB7C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_IsNeedLoadDynamicRes(IntPtr l)
	{
		int result;
		try
		{
			AppScoreUITask appScoreUITask = (AppScoreUITask)LuaObject.checkSelf(l);
			bool b = appScoreUITask.m_luaExportHelper.__callBase_IsNeedLoadDynamicRes();
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

	// Token: 0x0601AC45 RID: 109637 RVA: 0x007FC9D8 File Offset: 0x007FABD8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_CollectAllDynamicResForLoad(IntPtr l)
	{
		int result;
		try
		{
			AppScoreUITask appScoreUITask = (AppScoreUITask)LuaObject.checkSelf(l);
			List<string> o = appScoreUITask.m_luaExportHelper.__callBase_CollectAllDynamicResForLoad();
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

	// Token: 0x0601AC46 RID: 109638 RVA: 0x007FCA34 File Offset: 0x007FAC34
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_RegisterPlayerContextEvents(IntPtr l)
	{
		int result;
		try
		{
			AppScoreUITask appScoreUITask = (AppScoreUITask)LuaObject.checkSelf(l);
			appScoreUITask.m_luaExportHelper.__callBase_RegisterPlayerContextEvents();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601AC47 RID: 109639 RVA: 0x007FCA88 File Offset: 0x007FAC88
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_UnregisterPlayerContextEvents(IntPtr l)
	{
		int result;
		try
		{
			AppScoreUITask appScoreUITask = (AppScoreUITask)LuaObject.checkSelf(l);
			appScoreUITask.m_luaExportHelper.__callBase_UnregisterPlayerContextEvents();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601AC48 RID: 109640 RVA: 0x007FCADC File Offset: 0x007FACDC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_PostUpdateView(IntPtr l)
	{
		int result;
		try
		{
			AppScoreUITask appScoreUITask = (AppScoreUITask)LuaObject.checkSelf(l);
			appScoreUITask.m_luaExportHelper.__callBase_PostUpdateView();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601AC49 RID: 109641 RVA: 0x007FCB30 File Offset: 0x007FAD30
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_CollectPreloadResourceList(IntPtr l)
	{
		int result;
		try
		{
			AppScoreUITask appScoreUITask = (AppScoreUITask)LuaObject.checkSelf(l);
			appScoreUITask.m_luaExportHelper.__callBase_CollectPreloadResourceList();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601AC4A RID: 109642 RVA: 0x007FCB84 File Offset: 0x007FAD84
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_ClearAssetList(IntPtr l)
	{
		int result;
		try
		{
			AppScoreUITask appScoreUITask = (AppScoreUITask)LuaObject.checkSelf(l);
			appScoreUITask.m_luaExportHelper.__callBase_ClearAssetList();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601AC4B RID: 109643 RVA: 0x007FCBD8 File Offset: 0x007FADD8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_CollectAsset(IntPtr l)
	{
		int result;
		try
		{
			AppScoreUITask appScoreUITask = (AppScoreUITask)LuaObject.checkSelf(l);
			string assetName;
			LuaObject.checkType(l, 2, out assetName);
			appScoreUITask.m_luaExportHelper.__callBase_CollectAsset(assetName);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601AC4C RID: 109644 RVA: 0x007FCC34 File Offset: 0x007FAE34
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_CollectSpriteAsset(IntPtr l)
	{
		int result;
		try
		{
			AppScoreUITask appScoreUITask = (AppScoreUITask)LuaObject.checkSelf(l);
			string assetName;
			LuaObject.checkType(l, 2, out assetName);
			appScoreUITask.m_luaExportHelper.__callBase_CollectSpriteAsset(assetName);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601AC4D RID: 109645 RVA: 0x007FCC90 File Offset: 0x007FAE90
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_CollectFxAsset(IntPtr l)
	{
		int result;
		try
		{
			AppScoreUITask appScoreUITask = (AppScoreUITask)LuaObject.checkSelf(l);
			string assetName;
			LuaObject.checkType(l, 2, out assetName);
			appScoreUITask.m_luaExportHelper.__callBase_CollectFxAsset(assetName);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601AC4E RID: 109646 RVA: 0x007FCCEC File Offset: 0x007FAEEC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_StartLoadCustomAssets(IntPtr l)
	{
		int result;
		try
		{
			AppScoreUITask appScoreUITask = (AppScoreUITask)LuaObject.checkSelf(l);
			Action onLoadCompleted;
			LuaObject.checkDelegate<Action>(l, 2, out onLoadCompleted);
			appScoreUITask.m_luaExportHelper.__callBase_StartLoadCustomAssets(onLoadCompleted);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601AC4F RID: 109647 RVA: 0x007FCD48 File Offset: 0x007FAF48
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_IsLoadingCustomAssets(IntPtr l)
	{
		int result;
		try
		{
			AppScoreUITask appScoreUITask = (AppScoreUITask)LuaObject.checkSelf(l);
			bool b = appScoreUITask.m_luaExportHelper.__callBase_IsLoadingCustomAssets();
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

	// Token: 0x0601AC50 RID: 109648 RVA: 0x007FCDA4 File Offset: 0x007FAFA4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_IsPipeLineRunning(IntPtr l)
	{
		int result;
		try
		{
			AppScoreUITask appScoreUITask = (AppScoreUITask)LuaObject.checkSelf(l);
			bool b = appScoreUITask.m_luaExportHelper.__callBase_IsPipeLineRunning();
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

	// Token: 0x0601AC51 RID: 109649 RVA: 0x007FCE00 File Offset: 0x007FB000
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_IsOpeningUI(IntPtr l)
	{
		int result;
		try
		{
			AppScoreUITask appScoreUITask = (AppScoreUITask)LuaObject.checkSelf(l);
			bool b = appScoreUITask.m_luaExportHelper.__callBase_IsOpeningUI();
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

	// Token: 0x0601AC52 RID: 109650 RVA: 0x007FCE5C File Offset: 0x007FB05C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_ReturnPrevUITask(IntPtr l)
	{
		int result;
		try
		{
			AppScoreUITask appScoreUITask = (AppScoreUITask)LuaObject.checkSelf(l);
			UITaskBase o = appScoreUITask.m_luaExportHelper.__callBase_ReturnPrevUITask();
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

	// Token: 0x0601AC53 RID: 109651 RVA: 0x007FCEB8 File Offset: 0x007FB0B8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_ClearUnusedDynamicResourceCache(IntPtr l)
	{
		int result;
		try
		{
			AppScoreUITask appScoreUITask = (AppScoreUITask)LuaObject.checkSelf(l);
			appScoreUITask.m_luaExportHelper.__callBase_ClearUnusedDynamicResourceCache();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601AC54 RID: 109652 RVA: 0x007FCF0C File Offset: 0x007FB10C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_OnMemoryWarning(IntPtr l)
	{
		int result;
		try
		{
			AppScoreUITask appScoreUITask = (AppScoreUITask)LuaObject.checkSelf(l);
			appScoreUITask.m_luaExportHelper.__callBase_OnMemoryWarning();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601AC55 RID: 109653 RVA: 0x007FCF60 File Offset: 0x007FB160
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callDele_EventOnClose(IntPtr l)
	{
		int result;
		try
		{
			AppScoreUITask appScoreUITask = (AppScoreUITask)LuaObject.checkSelf(l);
			appScoreUITask.m_luaExportHelper.__callDele_EventOnClose();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601AC56 RID: 109654 RVA: 0x007FCFB4 File Offset: 0x007FB1B4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __clearDele_EventOnClose(IntPtr l)
	{
		int result;
		try
		{
			AppScoreUITask appScoreUITask = (AppScoreUITask)LuaObject.checkSelf(l);
			appScoreUITask.m_luaExportHelper.__clearDele_EventOnClose();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601AC57 RID: 109655 RVA: 0x007FD008 File Offset: 0x007FB208
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_EventOnClose(IntPtr l)
	{
		int result;
		try
		{
			AppScoreUITask appScoreUITask = (AppScoreUITask)LuaObject.checkSelf(l);
			Action value;
			int num = LuaObject.checkDelegate<Action>(l, 2, out value);
			if (num != 0)
			{
				if (num == 1)
				{
					appScoreUITask.EventOnClose += value;
				}
				else if (num == 2)
				{
					appScoreUITask.EventOnClose -= value;
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

	// Token: 0x0601AC58 RID: 109656 RVA: 0x007FD088 File Offset: 0x007FB288
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_appScoreUIController(IntPtr l)
	{
		int result;
		try
		{
			AppScoreUITask appScoreUITask = (AppScoreUITask)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, appScoreUITask.m_luaExportHelper.m_appScoreUIController);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601AC59 RID: 109657 RVA: 0x007FD0E0 File Offset: 0x007FB2E0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_appScoreUIController(IntPtr l)
	{
		int result;
		try
		{
			AppScoreUITask appScoreUITask = (AppScoreUITask)LuaObject.checkSelf(l);
			AppScoreUIController appScoreUIController;
			LuaObject.checkType<AppScoreUIController>(l, 2, out appScoreUIController);
			appScoreUITask.m_luaExportHelper.m_appScoreUIController = appScoreUIController;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601AC5A RID: 109658 RVA: 0x007FD13C File Offset: 0x007FB33C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_layerDescArray(IntPtr l)
	{
		int result;
		try
		{
			AppScoreUITask appScoreUITask = (AppScoreUITask)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, appScoreUITask.m_luaExportHelper.m_layerDescArray);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601AC5B RID: 109659 RVA: 0x007FD194 File Offset: 0x007FB394
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_layerDescArray(IntPtr l)
	{
		int result;
		try
		{
			AppScoreUITask appScoreUITask = (AppScoreUITask)LuaObject.checkSelf(l);
			UITaskBase.LayerDesc[] layerDescArray;
			LuaObject.checkArray<UITaskBase.LayerDesc>(l, 2, out layerDescArray);
			appScoreUITask.m_luaExportHelper.m_layerDescArray = layerDescArray;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601AC5C RID: 109660 RVA: 0x007FD1F0 File Offset: 0x007FB3F0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_uiCtrlDescArray(IntPtr l)
	{
		int result;
		try
		{
			AppScoreUITask appScoreUITask = (AppScoreUITask)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, appScoreUITask.m_luaExportHelper.m_uiCtrlDescArray);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601AC5D RID: 109661 RVA: 0x007FD248 File Offset: 0x007FB448
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_uiCtrlDescArray(IntPtr l)
	{
		int result;
		try
		{
			AppScoreUITask appScoreUITask = (AppScoreUITask)LuaObject.checkSelf(l);
			UITaskBase.UIControllerDesc[] uiCtrlDescArray;
			LuaObject.checkArray<UITaskBase.UIControllerDesc>(l, 2, out uiCtrlDescArray);
			appScoreUITask.m_luaExportHelper.m_uiCtrlDescArray = uiCtrlDescArray;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601AC5E RID: 109662 RVA: 0x007FD2A4 File Offset: 0x007FB4A4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_APPSCORE_RIFTID(IntPtr l)
	{
		int result;
		try
		{
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, 104);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601AC5F RID: 109663 RVA: 0x007FD2E8 File Offset: 0x007FB4E8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_SHOW_APPSCORE_KEY(IntPtr l)
	{
		int result;
		try
		{
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, "SHOW_APPSCORE");
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601AC60 RID: 109664 RVA: 0x007FD330 File Offset: 0x007FB530
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_LayerDescArray(IntPtr l)
	{
		int result;
		try
		{
			AppScoreUITask appScoreUITask = (AppScoreUITask)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, appScoreUITask.m_luaExportHelper.LayerDescArray);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601AC61 RID: 109665 RVA: 0x007FD388 File Offset: 0x007FB588
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_UICtrlDescArray(IntPtr l)
	{
		int result;
		try
		{
			AppScoreUITask appScoreUITask = (AppScoreUITask)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, appScoreUITask.m_luaExportHelper.UICtrlDescArray);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601AC62 RID: 109666 RVA: 0x007FD3E0 File Offset: 0x007FB5E0
	[Preserve]
	public static void reg(IntPtr l)
	{
		LuaObject.getTypeTable(l, "BlackJack.ProjectL.UI.AppScoreUITask");
		if (Lua_BlackJack_ProjectL_UI_AppScoreUITask.<>f__mg$cache0 == null)
		{
			Lua_BlackJack_ProjectL_UI_AppScoreUITask.<>f__mg$cache0 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_AppScoreUITask.ShowAppScoreUI_s);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_AppScoreUITask.<>f__mg$cache0);
		if (Lua_BlackJack_ProjectL_UI_AppScoreUITask.<>f__mg$cache1 == null)
		{
			Lua_BlackJack_ProjectL_UI_AppScoreUITask.<>f__mg$cache1 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_AppScoreUITask.CanScore_s);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_AppScoreUITask.<>f__mg$cache1);
		if (Lua_BlackJack_ProjectL_UI_AppScoreUITask.<>f__mg$cache2 == null)
		{
			Lua_BlackJack_ProjectL_UI_AppScoreUITask.<>f__mg$cache2 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_AppScoreUITask.InitAllUIControllers);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_AppScoreUITask.<>f__mg$cache2);
		if (Lua_BlackJack_ProjectL_UI_AppScoreUITask.<>f__mg$cache3 == null)
		{
			Lua_BlackJack_ProjectL_UI_AppScoreUITask.<>f__mg$cache3 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_AppScoreUITask.ClearAllContextAndRes);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_AppScoreUITask.<>f__mg$cache3);
		if (Lua_BlackJack_ProjectL_UI_AppScoreUITask.<>f__mg$cache4 == null)
		{
			Lua_BlackJack_ProjectL_UI_AppScoreUITask.<>f__mg$cache4 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_AppScoreUITask.UpdateView);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_AppScoreUITask.<>f__mg$cache4);
		if (Lua_BlackJack_ProjectL_UI_AppScoreUITask.<>f__mg$cache5 == null)
		{
			Lua_BlackJack_ProjectL_UI_AppScoreUITask.<>f__mg$cache5 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_AppScoreUITask.AppScoreUIController_OnGoScore);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_AppScoreUITask.<>f__mg$cache5);
		if (Lua_BlackJack_ProjectL_UI_AppScoreUITask.<>f__mg$cache6 == null)
		{
			Lua_BlackJack_ProjectL_UI_AppScoreUITask.<>f__mg$cache6 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_AppScoreUITask.AppScoreUIController_OnCloseAppScore);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_AppScoreUITask.<>f__mg$cache6);
		if (Lua_BlackJack_ProjectL_UI_AppScoreUITask.<>f__mg$cache7 == null)
		{
			Lua_BlackJack_ProjectL_UI_AppScoreUITask.<>f__mg$cache7 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_AppScoreUITask.CloseSelf);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_AppScoreUITask.<>f__mg$cache7);
		if (Lua_BlackJack_ProjectL_UI_AppScoreUITask.<>f__mg$cache8 == null)
		{
			Lua_BlackJack_ProjectL_UI_AppScoreUITask.<>f__mg$cache8 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_AppScoreUITask.__callBase_OnStart);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_AppScoreUITask.<>f__mg$cache8);
		if (Lua_BlackJack_ProjectL_UI_AppScoreUITask.<>f__mg$cache9 == null)
		{
			Lua_BlackJack_ProjectL_UI_AppScoreUITask.<>f__mg$cache9 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_AppScoreUITask.__callBase_OnStop);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_AppScoreUITask.<>f__mg$cache9);
		if (Lua_BlackJack_ProjectL_UI_AppScoreUITask.<>f__mg$cacheA == null)
		{
			Lua_BlackJack_ProjectL_UI_AppScoreUITask.<>f__mg$cacheA = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_AppScoreUITask.__callBase_OnPause);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_AppScoreUITask.<>f__mg$cacheA);
		if (Lua_BlackJack_ProjectL_UI_AppScoreUITask.<>f__mg$cacheB == null)
		{
			Lua_BlackJack_ProjectL_UI_AppScoreUITask.<>f__mg$cacheB = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_AppScoreUITask.__callBase_OnResume);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_AppScoreUITask.<>f__mg$cacheB);
		if (Lua_BlackJack_ProjectL_UI_AppScoreUITask.<>f__mg$cacheC == null)
		{
			Lua_BlackJack_ProjectL_UI_AppScoreUITask.<>f__mg$cacheC = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_AppScoreUITask.__callBase_OnNewIntent);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_AppScoreUITask.<>f__mg$cacheC);
		if (Lua_BlackJack_ProjectL_UI_AppScoreUITask.<>f__mg$cacheD == null)
		{
			Lua_BlackJack_ProjectL_UI_AppScoreUITask.<>f__mg$cacheD = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_AppScoreUITask.__callBase_EnableUIInput);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_AppScoreUITask.<>f__mg$cacheD);
		if (Lua_BlackJack_ProjectL_UI_AppScoreUITask.<>f__mg$cacheE == null)
		{
			Lua_BlackJack_ProjectL_UI_AppScoreUITask.<>f__mg$cacheE = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_AppScoreUITask.__callBase_IsNeedLoadDynamicRes);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_AppScoreUITask.<>f__mg$cacheE);
		if (Lua_BlackJack_ProjectL_UI_AppScoreUITask.<>f__mg$cacheF == null)
		{
			Lua_BlackJack_ProjectL_UI_AppScoreUITask.<>f__mg$cacheF = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_AppScoreUITask.__callBase_CollectAllDynamicResForLoad);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_AppScoreUITask.<>f__mg$cacheF);
		if (Lua_BlackJack_ProjectL_UI_AppScoreUITask.<>f__mg$cache10 == null)
		{
			Lua_BlackJack_ProjectL_UI_AppScoreUITask.<>f__mg$cache10 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_AppScoreUITask.__callBase_RegisterPlayerContextEvents);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_AppScoreUITask.<>f__mg$cache10);
		if (Lua_BlackJack_ProjectL_UI_AppScoreUITask.<>f__mg$cache11 == null)
		{
			Lua_BlackJack_ProjectL_UI_AppScoreUITask.<>f__mg$cache11 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_AppScoreUITask.__callBase_UnregisterPlayerContextEvents);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_AppScoreUITask.<>f__mg$cache11);
		if (Lua_BlackJack_ProjectL_UI_AppScoreUITask.<>f__mg$cache12 == null)
		{
			Lua_BlackJack_ProjectL_UI_AppScoreUITask.<>f__mg$cache12 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_AppScoreUITask.__callBase_PostUpdateView);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_AppScoreUITask.<>f__mg$cache12);
		if (Lua_BlackJack_ProjectL_UI_AppScoreUITask.<>f__mg$cache13 == null)
		{
			Lua_BlackJack_ProjectL_UI_AppScoreUITask.<>f__mg$cache13 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_AppScoreUITask.__callBase_CollectPreloadResourceList);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_AppScoreUITask.<>f__mg$cache13);
		if (Lua_BlackJack_ProjectL_UI_AppScoreUITask.<>f__mg$cache14 == null)
		{
			Lua_BlackJack_ProjectL_UI_AppScoreUITask.<>f__mg$cache14 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_AppScoreUITask.__callBase_ClearAssetList);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_AppScoreUITask.<>f__mg$cache14);
		if (Lua_BlackJack_ProjectL_UI_AppScoreUITask.<>f__mg$cache15 == null)
		{
			Lua_BlackJack_ProjectL_UI_AppScoreUITask.<>f__mg$cache15 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_AppScoreUITask.__callBase_CollectAsset);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_AppScoreUITask.<>f__mg$cache15);
		if (Lua_BlackJack_ProjectL_UI_AppScoreUITask.<>f__mg$cache16 == null)
		{
			Lua_BlackJack_ProjectL_UI_AppScoreUITask.<>f__mg$cache16 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_AppScoreUITask.__callBase_CollectSpriteAsset);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_AppScoreUITask.<>f__mg$cache16);
		if (Lua_BlackJack_ProjectL_UI_AppScoreUITask.<>f__mg$cache17 == null)
		{
			Lua_BlackJack_ProjectL_UI_AppScoreUITask.<>f__mg$cache17 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_AppScoreUITask.__callBase_CollectFxAsset);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_AppScoreUITask.<>f__mg$cache17);
		if (Lua_BlackJack_ProjectL_UI_AppScoreUITask.<>f__mg$cache18 == null)
		{
			Lua_BlackJack_ProjectL_UI_AppScoreUITask.<>f__mg$cache18 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_AppScoreUITask.__callBase_StartLoadCustomAssets);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_AppScoreUITask.<>f__mg$cache18);
		if (Lua_BlackJack_ProjectL_UI_AppScoreUITask.<>f__mg$cache19 == null)
		{
			Lua_BlackJack_ProjectL_UI_AppScoreUITask.<>f__mg$cache19 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_AppScoreUITask.__callBase_IsLoadingCustomAssets);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_AppScoreUITask.<>f__mg$cache19);
		if (Lua_BlackJack_ProjectL_UI_AppScoreUITask.<>f__mg$cache1A == null)
		{
			Lua_BlackJack_ProjectL_UI_AppScoreUITask.<>f__mg$cache1A = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_AppScoreUITask.__callBase_IsPipeLineRunning);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_AppScoreUITask.<>f__mg$cache1A);
		if (Lua_BlackJack_ProjectL_UI_AppScoreUITask.<>f__mg$cache1B == null)
		{
			Lua_BlackJack_ProjectL_UI_AppScoreUITask.<>f__mg$cache1B = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_AppScoreUITask.__callBase_IsOpeningUI);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_AppScoreUITask.<>f__mg$cache1B);
		if (Lua_BlackJack_ProjectL_UI_AppScoreUITask.<>f__mg$cache1C == null)
		{
			Lua_BlackJack_ProjectL_UI_AppScoreUITask.<>f__mg$cache1C = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_AppScoreUITask.__callBase_ReturnPrevUITask);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_AppScoreUITask.<>f__mg$cache1C);
		if (Lua_BlackJack_ProjectL_UI_AppScoreUITask.<>f__mg$cache1D == null)
		{
			Lua_BlackJack_ProjectL_UI_AppScoreUITask.<>f__mg$cache1D = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_AppScoreUITask.__callBase_ClearUnusedDynamicResourceCache);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_AppScoreUITask.<>f__mg$cache1D);
		if (Lua_BlackJack_ProjectL_UI_AppScoreUITask.<>f__mg$cache1E == null)
		{
			Lua_BlackJack_ProjectL_UI_AppScoreUITask.<>f__mg$cache1E = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_AppScoreUITask.__callBase_OnMemoryWarning);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_AppScoreUITask.<>f__mg$cache1E);
		if (Lua_BlackJack_ProjectL_UI_AppScoreUITask.<>f__mg$cache1F == null)
		{
			Lua_BlackJack_ProjectL_UI_AppScoreUITask.<>f__mg$cache1F = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_AppScoreUITask.__callDele_EventOnClose);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_AppScoreUITask.<>f__mg$cache1F);
		if (Lua_BlackJack_ProjectL_UI_AppScoreUITask.<>f__mg$cache20 == null)
		{
			Lua_BlackJack_ProjectL_UI_AppScoreUITask.<>f__mg$cache20 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_AppScoreUITask.__clearDele_EventOnClose);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_AppScoreUITask.<>f__mg$cache20);
		string name = "EventOnClose";
		LuaCSFunction get = null;
		if (Lua_BlackJack_ProjectL_UI_AppScoreUITask.<>f__mg$cache21 == null)
		{
			Lua_BlackJack_ProjectL_UI_AppScoreUITask.<>f__mg$cache21 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_AppScoreUITask.set_EventOnClose);
		}
		LuaObject.addMember(l, name, get, Lua_BlackJack_ProjectL_UI_AppScoreUITask.<>f__mg$cache21, true);
		string name2 = "m_appScoreUIController";
		if (Lua_BlackJack_ProjectL_UI_AppScoreUITask.<>f__mg$cache22 == null)
		{
			Lua_BlackJack_ProjectL_UI_AppScoreUITask.<>f__mg$cache22 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_AppScoreUITask.get_m_appScoreUIController);
		}
		LuaCSFunction get2 = Lua_BlackJack_ProjectL_UI_AppScoreUITask.<>f__mg$cache22;
		if (Lua_BlackJack_ProjectL_UI_AppScoreUITask.<>f__mg$cache23 == null)
		{
			Lua_BlackJack_ProjectL_UI_AppScoreUITask.<>f__mg$cache23 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_AppScoreUITask.set_m_appScoreUIController);
		}
		LuaObject.addMember(l, name2, get2, Lua_BlackJack_ProjectL_UI_AppScoreUITask.<>f__mg$cache23, true);
		string name3 = "m_layerDescArray";
		if (Lua_BlackJack_ProjectL_UI_AppScoreUITask.<>f__mg$cache24 == null)
		{
			Lua_BlackJack_ProjectL_UI_AppScoreUITask.<>f__mg$cache24 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_AppScoreUITask.get_m_layerDescArray);
		}
		LuaCSFunction get3 = Lua_BlackJack_ProjectL_UI_AppScoreUITask.<>f__mg$cache24;
		if (Lua_BlackJack_ProjectL_UI_AppScoreUITask.<>f__mg$cache25 == null)
		{
			Lua_BlackJack_ProjectL_UI_AppScoreUITask.<>f__mg$cache25 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_AppScoreUITask.set_m_layerDescArray);
		}
		LuaObject.addMember(l, name3, get3, Lua_BlackJack_ProjectL_UI_AppScoreUITask.<>f__mg$cache25, true);
		string name4 = "m_uiCtrlDescArray";
		if (Lua_BlackJack_ProjectL_UI_AppScoreUITask.<>f__mg$cache26 == null)
		{
			Lua_BlackJack_ProjectL_UI_AppScoreUITask.<>f__mg$cache26 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_AppScoreUITask.get_m_uiCtrlDescArray);
		}
		LuaCSFunction get4 = Lua_BlackJack_ProjectL_UI_AppScoreUITask.<>f__mg$cache26;
		if (Lua_BlackJack_ProjectL_UI_AppScoreUITask.<>f__mg$cache27 == null)
		{
			Lua_BlackJack_ProjectL_UI_AppScoreUITask.<>f__mg$cache27 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_AppScoreUITask.set_m_uiCtrlDescArray);
		}
		LuaObject.addMember(l, name4, get4, Lua_BlackJack_ProjectL_UI_AppScoreUITask.<>f__mg$cache27, true);
		string name5 = "APPSCORE_RIFTID";
		if (Lua_BlackJack_ProjectL_UI_AppScoreUITask.<>f__mg$cache28 == null)
		{
			Lua_BlackJack_ProjectL_UI_AppScoreUITask.<>f__mg$cache28 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_AppScoreUITask.get_APPSCORE_RIFTID);
		}
		LuaObject.addMember(l, name5, Lua_BlackJack_ProjectL_UI_AppScoreUITask.<>f__mg$cache28, null, false);
		string name6 = "SHOW_APPSCORE_KEY";
		if (Lua_BlackJack_ProjectL_UI_AppScoreUITask.<>f__mg$cache29 == null)
		{
			Lua_BlackJack_ProjectL_UI_AppScoreUITask.<>f__mg$cache29 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_AppScoreUITask.get_SHOW_APPSCORE_KEY);
		}
		LuaObject.addMember(l, name6, Lua_BlackJack_ProjectL_UI_AppScoreUITask.<>f__mg$cache29, null, false);
		string name7 = "LayerDescArray";
		if (Lua_BlackJack_ProjectL_UI_AppScoreUITask.<>f__mg$cache2A == null)
		{
			Lua_BlackJack_ProjectL_UI_AppScoreUITask.<>f__mg$cache2A = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_AppScoreUITask.get_LayerDescArray);
		}
		LuaObject.addMember(l, name7, Lua_BlackJack_ProjectL_UI_AppScoreUITask.<>f__mg$cache2A, null, true);
		string name8 = "UICtrlDescArray";
		if (Lua_BlackJack_ProjectL_UI_AppScoreUITask.<>f__mg$cache2B == null)
		{
			Lua_BlackJack_ProjectL_UI_AppScoreUITask.<>f__mg$cache2B = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_AppScoreUITask.get_UICtrlDescArray);
		}
		LuaObject.addMember(l, name8, Lua_BlackJack_ProjectL_UI_AppScoreUITask.<>f__mg$cache2B, null, true);
		if (Lua_BlackJack_ProjectL_UI_AppScoreUITask.<>f__mg$cache2C == null)
		{
			Lua_BlackJack_ProjectL_UI_AppScoreUITask.<>f__mg$cache2C = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_AppScoreUITask.constructor);
		}
		LuaObject.createTypeMetatable(l, Lua_BlackJack_ProjectL_UI_AppScoreUITask.<>f__mg$cache2C, typeof(AppScoreUITask), typeof(UITask));
	}

	// Token: 0x04010F4F RID: 69455
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache0;

	// Token: 0x04010F50 RID: 69456
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1;

	// Token: 0x04010F51 RID: 69457
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2;

	// Token: 0x04010F52 RID: 69458
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3;

	// Token: 0x04010F53 RID: 69459
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache4;

	// Token: 0x04010F54 RID: 69460
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache5;

	// Token: 0x04010F55 RID: 69461
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache6;

	// Token: 0x04010F56 RID: 69462
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache7;

	// Token: 0x04010F57 RID: 69463
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache8;

	// Token: 0x04010F58 RID: 69464
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache9;

	// Token: 0x04010F59 RID: 69465
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheA;

	// Token: 0x04010F5A RID: 69466
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheB;

	// Token: 0x04010F5B RID: 69467
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheC;

	// Token: 0x04010F5C RID: 69468
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheD;

	// Token: 0x04010F5D RID: 69469
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheE;

	// Token: 0x04010F5E RID: 69470
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheF;

	// Token: 0x04010F5F RID: 69471
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache10;

	// Token: 0x04010F60 RID: 69472
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache11;

	// Token: 0x04010F61 RID: 69473
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache12;

	// Token: 0x04010F62 RID: 69474
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache13;

	// Token: 0x04010F63 RID: 69475
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache14;

	// Token: 0x04010F64 RID: 69476
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache15;

	// Token: 0x04010F65 RID: 69477
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache16;

	// Token: 0x04010F66 RID: 69478
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache17;

	// Token: 0x04010F67 RID: 69479
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache18;

	// Token: 0x04010F68 RID: 69480
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache19;

	// Token: 0x04010F69 RID: 69481
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1A;

	// Token: 0x04010F6A RID: 69482
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1B;

	// Token: 0x04010F6B RID: 69483
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1C;

	// Token: 0x04010F6C RID: 69484
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1D;

	// Token: 0x04010F6D RID: 69485
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1E;

	// Token: 0x04010F6E RID: 69486
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1F;

	// Token: 0x04010F6F RID: 69487
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache20;

	// Token: 0x04010F70 RID: 69488
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache21;

	// Token: 0x04010F71 RID: 69489
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache22;

	// Token: 0x04010F72 RID: 69490
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache23;

	// Token: 0x04010F73 RID: 69491
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache24;

	// Token: 0x04010F74 RID: 69492
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache25;

	// Token: 0x04010F75 RID: 69493
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache26;

	// Token: 0x04010F76 RID: 69494
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache27;

	// Token: 0x04010F77 RID: 69495
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache28;

	// Token: 0x04010F78 RID: 69496
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache29;

	// Token: 0x04010F79 RID: 69497
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2A;

	// Token: 0x04010F7A RID: 69498
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2B;

	// Token: 0x04010F7B RID: 69499
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2C;
}
