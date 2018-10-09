using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using BlackJack.BJFramework.Runtime.Scene;
using BlackJack.BJFramework.Runtime.UI;
using BlackJack.ProjectL.UI;
using SLua;
using UnityEngine.Scripting;

// Token: 0x020015C2 RID: 5570
[Preserve]
public class Lua_BlackJack_ProjectL_UI_UITask : LuaObject
{
	// Token: 0x06021DF6 RID: 138742 RVA: 0x00B85928 File Offset: 0x00B83B28
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int constructor(IntPtr l)
	{
		int result;
		try
		{
			string name;
			LuaObject.checkType(l, 2, out name);
			UITask o = new UITask(name);
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

	// Token: 0x06021DF7 RID: 138743 RVA: 0x00B8597C File Offset: 0x00B83B7C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int OnNewIntent(IntPtr l)
	{
		int result;
		try
		{
			UITask uitask = (UITask)LuaObject.checkSelf(l);
			UIIntent intent;
			LuaObject.checkType<UIIntent>(l, 2, out intent);
			bool b = uitask.OnNewIntent(intent);
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

	// Token: 0x06021DF8 RID: 138744 RVA: 0x00B859E0 File Offset: 0x00B83BE0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int EnableUIInput(IntPtr l)
	{
		int result;
		try
		{
			UITask uitask = (UITask)LuaObject.checkSelf(l);
			bool isEnable;
			LuaObject.checkType(l, 2, out isEnable);
			bool? isGlobalEnable;
			LuaObject.checkNullable<bool>(l, 3, out isGlobalEnable);
			uitask.EnableUIInput(isEnable, isGlobalEnable);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06021DF9 RID: 138745 RVA: 0x00B85A44 File Offset: 0x00B83C44
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int OnStart(IntPtr l)
	{
		int result;
		try
		{
			UITask uitask = (UITask)LuaObject.checkSelf(l);
			UIIntent intent;
			LuaObject.checkType<UIIntent>(l, 2, out intent);
			bool b = uitask.m_luaExportHelper.OnStart(intent);
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

	// Token: 0x06021DFA RID: 138746 RVA: 0x00B85AAC File Offset: 0x00B83CAC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int OnStop(IntPtr l)
	{
		int result;
		try
		{
			UITask uitask = (UITask)LuaObject.checkSelf(l);
			uitask.m_luaExportHelper.OnStop();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06021DFB RID: 138747 RVA: 0x00B85B00 File Offset: 0x00B83D00
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int OnPause(IntPtr l)
	{
		int result;
		try
		{
			UITask uitask = (UITask)LuaObject.checkSelf(l);
			uitask.m_luaExportHelper.OnPause();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06021DFC RID: 138748 RVA: 0x00B85B54 File Offset: 0x00B83D54
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int OnResume(IntPtr l)
	{
		int result;
		try
		{
			UITask uitask = (UITask)LuaObject.checkSelf(l);
			UIIntent intent;
			LuaObject.checkType<UIIntent>(l, 2, out intent);
			bool b = uitask.m_luaExportHelper.OnResume(intent);
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

	// Token: 0x06021DFD RID: 138749 RVA: 0x00B85BBC File Offset: 0x00B83DBC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int IsNeedLoadDynamicRes(IntPtr l)
	{
		int result;
		try
		{
			UITask uitask = (UITask)LuaObject.checkSelf(l);
			bool b = uitask.m_luaExportHelper.IsNeedLoadDynamicRes();
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

	// Token: 0x06021DFE RID: 138750 RVA: 0x00B85C18 File Offset: 0x00B83E18
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int CollectAllDynamicResForLoad(IntPtr l)
	{
		int result;
		try
		{
			UITask uitask = (UITask)LuaObject.checkSelf(l);
			List<string> o = uitask.m_luaExportHelper.CollectAllDynamicResForLoad();
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

	// Token: 0x06021DFF RID: 138751 RVA: 0x00B85C74 File Offset: 0x00B83E74
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int RegisterPlayerContextEvents(IntPtr l)
	{
		int result;
		try
		{
			UITask uitask = (UITask)LuaObject.checkSelf(l);
			uitask.m_luaExportHelper.RegisterPlayerContextEvents();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06021E00 RID: 138752 RVA: 0x00B85CC8 File Offset: 0x00B83EC8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int UnregisterPlayerContextEvents(IntPtr l)
	{
		int result;
		try
		{
			UITask uitask = (UITask)LuaObject.checkSelf(l);
			uitask.m_luaExportHelper.UnregisterPlayerContextEvents();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06021E01 RID: 138753 RVA: 0x00B85D1C File Offset: 0x00B83F1C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int PostUpdateView(IntPtr l)
	{
		int result;
		try
		{
			UITask uitask = (UITask)LuaObject.checkSelf(l);
			uitask.m_luaExportHelper.PostUpdateView();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06021E02 RID: 138754 RVA: 0x00B85D70 File Offset: 0x00B83F70
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int CollectPreloadResourceList(IntPtr l)
	{
		int result;
		try
		{
			UITask uitask = (UITask)LuaObject.checkSelf(l);
			uitask.m_luaExportHelper.CollectPreloadResourceList();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06021E03 RID: 138755 RVA: 0x00B85DC4 File Offset: 0x00B83FC4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int ClearAssetList(IntPtr l)
	{
		int result;
		try
		{
			UITask uitask = (UITask)LuaObject.checkSelf(l);
			uitask.m_luaExportHelper.ClearAssetList();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06021E04 RID: 138756 RVA: 0x00B85E18 File Offset: 0x00B84018
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int CollectAsset(IntPtr l)
	{
		int result;
		try
		{
			UITask uitask = (UITask)LuaObject.checkSelf(l);
			string assetName;
			LuaObject.checkType(l, 2, out assetName);
			uitask.m_luaExportHelper.CollectAsset(assetName);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06021E05 RID: 138757 RVA: 0x00B85E74 File Offset: 0x00B84074
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int CollectSpriteAsset(IntPtr l)
	{
		int result;
		try
		{
			UITask uitask = (UITask)LuaObject.checkSelf(l);
			string assetName;
			LuaObject.checkType(l, 2, out assetName);
			uitask.m_luaExportHelper.CollectSpriteAsset(assetName);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06021E06 RID: 138758 RVA: 0x00B85ED0 File Offset: 0x00B840D0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int CollectFxAsset(IntPtr l)
	{
		int result;
		try
		{
			UITask uitask = (UITask)LuaObject.checkSelf(l);
			string assetName;
			LuaObject.checkType(l, 2, out assetName);
			uitask.m_luaExportHelper.CollectFxAsset(assetName);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06021E07 RID: 138759 RVA: 0x00B85F2C File Offset: 0x00B8412C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int StartLoadCustomRes(IntPtr l)
	{
		int result;
		try
		{
			UITask uitask = (UITask)LuaObject.checkSelf(l);
			List<string> resPathList;
			LuaObject.checkType<List<string>>(l, 2, out resPathList);
			Action onLoadCompleted;
			LuaObject.checkDelegate<Action>(l, 3, out onLoadCompleted);
			uitask.m_luaExportHelper.StartLoadCustomRes(resPathList, onLoadCompleted);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06021E08 RID: 138760 RVA: 0x00B85F98 File Offset: 0x00B84198
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int StartLoadCustomAssets(IntPtr l)
	{
		int result;
		try
		{
			UITask uitask = (UITask)LuaObject.checkSelf(l);
			Action onLoadCompleted;
			LuaObject.checkDelegate<Action>(l, 2, out onLoadCompleted);
			uitask.m_luaExportHelper.StartLoadCustomAssets(onLoadCompleted);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06021E09 RID: 138761 RVA: 0x00B85FF4 File Offset: 0x00B841F4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int IsLoadingCustomAssets(IntPtr l)
	{
		int result;
		try
		{
			UITask uitask = (UITask)LuaObject.checkSelf(l);
			bool b = uitask.m_luaExportHelper.IsLoadingCustomAssets();
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

	// Token: 0x06021E0A RID: 138762 RVA: 0x00B86050 File Offset: 0x00B84250
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int IsPipeLineRunning(IntPtr l)
	{
		int result;
		try
		{
			UITask uitask = (UITask)LuaObject.checkSelf(l);
			bool b = uitask.m_luaExportHelper.IsPipeLineRunning();
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

	// Token: 0x06021E0B RID: 138763 RVA: 0x00B860AC File Offset: 0x00B842AC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int IsOpeningUI(IntPtr l)
	{
		int result;
		try
		{
			UITask uitask = (UITask)LuaObject.checkSelf(l);
			bool b = uitask.m_luaExportHelper.IsOpeningUI();
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

	// Token: 0x06021E0C RID: 138764 RVA: 0x00B86108 File Offset: 0x00B84308
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int ReturnPrevUITask(IntPtr l)
	{
		int result;
		try
		{
			UITask uitask = (UITask)LuaObject.checkSelf(l);
			UITaskBase o = uitask.m_luaExportHelper.ReturnPrevUITask();
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

	// Token: 0x06021E0D RID: 138765 RVA: 0x00B86164 File Offset: 0x00B84364
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int ClearUnusedDynamicResourceCache(IntPtr l)
	{
		int result;
		try
		{
			UITask uitask = (UITask)LuaObject.checkSelf(l);
			uitask.m_luaExportHelper.ClearUnusedDynamicResourceCache();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06021E0E RID: 138766 RVA: 0x00B861B8 File Offset: 0x00B843B8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int OnMemoryWarning(IntPtr l)
	{
		int result;
		try
		{
			UITask uitask = (UITask)LuaObject.checkSelf(l);
			uitask.m_luaExportHelper.OnMemoryWarning();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06021E0F RID: 138767 RVA: 0x00B8620C File Offset: 0x00B8440C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_InitlizeBeforeManagerStartIt(IntPtr l)
	{
		int result;
		try
		{
			UITask uitask = (UITask)LuaObject.checkSelf(l);
			uitask.m_luaExportHelper.__callBase_InitlizeBeforeManagerStartIt();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06021E10 RID: 138768 RVA: 0x00B86260 File Offset: 0x00B84460
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_PrepareForStartOrResume(IntPtr l)
	{
		int result;
		try
		{
			UITask uitask = (UITask)LuaObject.checkSelf(l);
			UIIntent intent;
			LuaObject.checkType<UIIntent>(l, 2, out intent);
			Action<bool> onPrepareEnd;
			LuaObject.checkDelegate<Action<bool>>(l, 3, out onPrepareEnd);
			uitask.m_luaExportHelper.__callBase_PrepareForStartOrResume(intent, onPrepareEnd);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06021E11 RID: 138769 RVA: 0x00B862CC File Offset: 0x00B844CC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_OnStart(IntPtr l)
	{
		int result;
		try
		{
			int total = LuaDLL.lua_gettop(l);
			if (LuaObject.matchType(l, total, 2, typeof(object)))
			{
				UITask uitask = (UITask)LuaObject.checkSelf(l);
				object param;
				LuaObject.checkType<object>(l, 2, out param);
				bool b = uitask.m_luaExportHelper.__callBase_OnStart(param);
				LuaObject.pushValue(l, true);
				LuaObject.pushValue(l, b);
				result = 2;
			}
			else if (LuaObject.matchType(l, total, 2, typeof(UIIntent)))
			{
				UITask uitask2 = (UITask)LuaObject.checkSelf(l);
				UIIntent intent;
				LuaObject.checkType<UIIntent>(l, 2, out intent);
				bool b2 = uitask2.m_luaExportHelper.__callBase_OnStart(intent);
				LuaObject.pushValue(l, true);
				LuaObject.pushValue(l, b2);
				result = 2;
			}
			else
			{
				LuaObject.pushValue(l, false);
				LuaDLL.lua_pushstring(l, "No matched override function __callBase_OnStart to call");
				result = 2;
			}
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06021E12 RID: 138770 RVA: 0x00B863C4 File Offset: 0x00B845C4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_GetPipeLineCtx(IntPtr l)
	{
		int result;
		try
		{
			UITask uitask = (UITask)LuaObject.checkSelf(l);
			UITaskPipeLineCtx o = uitask.m_luaExportHelper.__callBase_GetPipeLineCtx();
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

	// Token: 0x06021E13 RID: 138771 RVA: 0x00B86420 File Offset: 0x00B84620
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_CreatePipeLineCtx(IntPtr l)
	{
		int result;
		try
		{
			UITask uitask = (UITask)LuaObject.checkSelf(l);
			UITaskPipeLineCtx o = uitask.m_luaExportHelper.__callBase_CreatePipeLineCtx();
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

	// Token: 0x06021E14 RID: 138772 RVA: 0x00B8647C File Offset: 0x00B8467C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_OnStop(IntPtr l)
	{
		int result;
		try
		{
			UITask uitask = (UITask)LuaObject.checkSelf(l);
			uitask.m_luaExportHelper.__callBase_OnStop();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06021E15 RID: 138773 RVA: 0x00B864D0 File Offset: 0x00B846D0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_OnPause(IntPtr l)
	{
		int result;
		try
		{
			UITask uitask = (UITask)LuaObject.checkSelf(l);
			uitask.m_luaExportHelper.__callBase_OnPause();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06021E16 RID: 138774 RVA: 0x00B86524 File Offset: 0x00B84724
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_OnResume(IntPtr l)
	{
		int result;
		try
		{
			int total = LuaDLL.lua_gettop(l);
			if (LuaObject.matchType(l, total, 2, typeof(object)))
			{
				UITask uitask = (UITask)LuaObject.checkSelf(l);
				object param;
				LuaObject.checkType<object>(l, 2, out param);
				bool b = uitask.m_luaExportHelper.__callBase_OnResume(param);
				LuaObject.pushValue(l, true);
				LuaObject.pushValue(l, b);
				result = 2;
			}
			else if (LuaObject.matchType(l, total, 2, typeof(UIIntent)))
			{
				UITask uitask2 = (UITask)LuaObject.checkSelf(l);
				UIIntent intent;
				LuaObject.checkType<UIIntent>(l, 2, out intent);
				bool b2 = uitask2.m_luaExportHelper.__callBase_OnResume(intent);
				LuaObject.pushValue(l, true);
				LuaObject.pushValue(l, b2);
				result = 2;
			}
			else
			{
				LuaObject.pushValue(l, false);
				LuaDLL.lua_pushstring(l, "No matched override function __callBase_OnResume to call");
				result = 2;
			}
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06021E17 RID: 138775 RVA: 0x00B8661C File Offset: 0x00B8481C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_OnNewIntent(IntPtr l)
	{
		int result;
		try
		{
			UITask uitask = (UITask)LuaObject.checkSelf(l);
			UIIntent intent;
			LuaObject.checkType<UIIntent>(l, 2, out intent);
			bool b = uitask.m_luaExportHelper.__callBase_OnNewIntent(intent);
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

	// Token: 0x06021E18 RID: 138776 RVA: 0x00B86684 File Offset: 0x00B84884
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_StartUpdatePipeLine(IntPtr l)
	{
		int result;
		try
		{
			UITask uitask = (UITask)LuaObject.checkSelf(l);
			UIIntent intent;
			LuaObject.checkType<UIIntent>(l, 2, out intent);
			bool onlyUpdateView;
			LuaObject.checkType(l, 3, out onlyUpdateView);
			bool canBeSkip;
			LuaObject.checkType(l, 4, out canBeSkip);
			bool enableQueue;
			LuaObject.checkType(l, 5, out enableQueue);
			bool b = uitask.m_luaExportHelper.__callBase_StartUpdatePipeLine(intent, onlyUpdateView, canBeSkip, enableQueue);
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

	// Token: 0x06021E19 RID: 138777 RVA: 0x00B86714 File Offset: 0x00B84914
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_NeedSkipUpdatePipeLine(IntPtr l)
	{
		int result;
		try
		{
			UITask uitask = (UITask)LuaObject.checkSelf(l);
			UIIntent intent;
			LuaObject.checkType<UIIntent>(l, 2, out intent);
			bool onlyUpdateView;
			LuaObject.checkType(l, 3, out onlyUpdateView);
			bool b = uitask.m_luaExportHelper.__callBase_NeedSkipUpdatePipeLine(intent, onlyUpdateView);
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

	// Token: 0x06021E1A RID: 138778 RVA: 0x00B86788 File Offset: 0x00B84988
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_IsNeedUpdateDataCache(IntPtr l)
	{
		int result;
		try
		{
			UITask uitask = (UITask)LuaObject.checkSelf(l);
			bool b = uitask.m_luaExportHelper.__callBase_IsNeedUpdateDataCache();
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

	// Token: 0x06021E1B RID: 138779 RVA: 0x00B867E4 File Offset: 0x00B849E4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_UpdateDataCache(IntPtr l)
	{
		int result;
		try
		{
			UITask uitask = (UITask)LuaObject.checkSelf(l);
			uitask.m_luaExportHelper.__callBase_UpdateDataCache();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06021E1C RID: 138780 RVA: 0x00B86838 File Offset: 0x00B84A38
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_IsNeedLoadStaticRes(IntPtr l)
	{
		int result;
		try
		{
			UITask uitask = (UITask)LuaObject.checkSelf(l);
			bool b = uitask.m_luaExportHelper.__callBase_IsNeedLoadStaticRes();
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

	// Token: 0x06021E1D RID: 138781 RVA: 0x00B86894 File Offset: 0x00B84A94
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_StartLoadStaticRes(IntPtr l)
	{
		int result;
		try
		{
			UITask uitask = (UITask)LuaObject.checkSelf(l);
			uitask.m_luaExportHelper.__callBase_StartLoadStaticRes();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06021E1E RID: 138782 RVA: 0x00B868E8 File Offset: 0x00B84AE8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_CheckLayerDescArray(IntPtr l)
	{
		int result;
		try
		{
			UITask uitask = (UITask)LuaObject.checkSelf(l);
			List<UITaskBase.LayerDesc> layerDescArray;
			LuaObject.checkType<List<UITaskBase.LayerDesc>>(l, 2, out layerDescArray);
			uitask.m_luaExportHelper.__callBase_CheckLayerDescArray(layerDescArray);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06021E1F RID: 138783 RVA: 0x00B86944 File Offset: 0x00B84B44
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_OnLoadStaticResCompleted(IntPtr l)
	{
		int result;
		try
		{
			UITask uitask = (UITask)LuaObject.checkSelf(l);
			uitask.m_luaExportHelper.__callBase_OnLoadStaticResCompleted();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06021E20 RID: 138784 RVA: 0x00B86998 File Offset: 0x00B84B98
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_IsNeedLoadDynamicRes(IntPtr l)
	{
		int result;
		try
		{
			UITask uitask = (UITask)LuaObject.checkSelf(l);
			bool b = uitask.m_luaExportHelper.__callBase_IsNeedLoadDynamicRes();
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

	// Token: 0x06021E21 RID: 138785 RVA: 0x00B869F4 File Offset: 0x00B84BF4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_StartLoadDynamicRes(IntPtr l)
	{
		int result;
		try
		{
			UITask uitask = (UITask)LuaObject.checkSelf(l);
			uitask.m_luaExportHelper.__callBase_StartLoadDynamicRes();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06021E22 RID: 138786 RVA: 0x00B86A48 File Offset: 0x00B84C48
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_CollectAllDynamicResForLoad(IntPtr l)
	{
		int result;
		try
		{
			UITask uitask = (UITask)LuaObject.checkSelf(l);
			List<string> o = uitask.m_luaExportHelper.__callBase_CollectAllDynamicResForLoad();
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

	// Token: 0x06021E23 RID: 138787 RVA: 0x00B86AA4 File Offset: 0x00B84CA4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_CollectAllStaticResDescForLoad(IntPtr l)
	{
		int result;
		try
		{
			UITask uitask = (UITask)LuaObject.checkSelf(l);
			List<UITaskBase.LayerDesc> o = uitask.m_luaExportHelper.__callBase_CollectAllStaticResDescForLoad();
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

	// Token: 0x06021E24 RID: 138788 RVA: 0x00B86B00 File Offset: 0x00B84D00
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_CalculateDynamicResReallyNeedLoad(IntPtr l)
	{
		int result;
		try
		{
			UITask uitask = (UITask)LuaObject.checkSelf(l);
			List<string> resPathList;
			LuaObject.checkType<List<string>>(l, 2, out resPathList);
			HashSet<string> o = uitask.m_luaExportHelper.__callBase_CalculateDynamicResReallyNeedLoad(resPathList);
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

	// Token: 0x06021E25 RID: 138789 RVA: 0x00B86B68 File Offset: 0x00B84D68
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_OnLoadDynamicResCompleted(IntPtr l)
	{
		int result;
		try
		{
			UITask uitask = (UITask)LuaObject.checkSelf(l);
			uitask.m_luaExportHelper.__callBase_OnLoadDynamicResCompleted();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06021E26 RID: 138790 RVA: 0x00B86BBC File Offset: 0x00B84DBC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_RedirectPipLineOnAllResReady(IntPtr l)
	{
		int result;
		try
		{
			UITask uitask = (UITask)LuaObject.checkSelf(l);
			Action callBack;
			LuaObject.checkDelegate<Action>(l, 2, out callBack);
			uitask.m_luaExportHelper.__callBase_RedirectPipLineOnAllResReady(callBack);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06021E27 RID: 138791 RVA: 0x00B86C18 File Offset: 0x00B84E18
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_OnLoadAllResCompleted(IntPtr l)
	{
		int result;
		try
		{
			UITask uitask = (UITask)LuaObject.checkSelf(l);
			uitask.m_luaExportHelper.__callBase_OnLoadAllResCompleted();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06021E28 RID: 138792 RVA: 0x00B86C6C File Offset: 0x00B84E6C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_ReturnFromRedirectPipLineOnLoadAllResCompleted(IntPtr l)
	{
		int result;
		try
		{
			UITask uitask = (UITask)LuaObject.checkSelf(l);
			uitask.m_luaExportHelper.__callBase_ReturnFromRedirectPipLineOnLoadAllResCompleted();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06021E29 RID: 138793 RVA: 0x00B86CC0 File Offset: 0x00B84EC0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_InitLayerStateOnLoadAllResCompleted(IntPtr l)
	{
		int result;
		try
		{
			UITask uitask = (UITask)LuaObject.checkSelf(l);
			uitask.m_luaExportHelper.__callBase_InitLayerStateOnLoadAllResCompleted();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06021E2A RID: 138794 RVA: 0x00B86D14 File Offset: 0x00B84F14
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_InitAllUIControllers(IntPtr l)
	{
		int result;
		try
		{
			UITask uitask = (UITask)LuaObject.checkSelf(l);
			uitask.m_luaExportHelper.__callBase_InitAllUIControllers();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06021E2B RID: 138795 RVA: 0x00B86D68 File Offset: 0x00B84F68
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_PostOnLoadAllResCompleted(IntPtr l)
	{
		int result;
		try
		{
			UITask uitask = (UITask)LuaObject.checkSelf(l);
			uitask.m_luaExportHelper.__callBase_PostOnLoadAllResCompleted();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06021E2C RID: 138796 RVA: 0x00B86DBC File Offset: 0x00B84FBC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_IsLoadAllResCompleted(IntPtr l)
	{
		int result;
		try
		{
			UITask uitask = (UITask)LuaObject.checkSelf(l);
			bool b = uitask.m_luaExportHelper.__callBase_IsLoadAllResCompleted();
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

	// Token: 0x06021E2D RID: 138797 RVA: 0x00B86E18 File Offset: 0x00B85018
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_StartUpdateView(IntPtr l)
	{
		int result;
		try
		{
			UITask uitask = (UITask)LuaObject.checkSelf(l);
			uitask.m_luaExportHelper.__callBase_StartUpdateView();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06021E2E RID: 138798 RVA: 0x00B86E6C File Offset: 0x00B8506C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_UpdateView(IntPtr l)
	{
		int result;
		try
		{
			UITask uitask = (UITask)LuaObject.checkSelf(l);
			uitask.m_luaExportHelper.__callBase_UpdateView();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06021E2F RID: 138799 RVA: 0x00B86EC0 File Offset: 0x00B850C0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_RegUpdateViewPlayingEffect(IntPtr l)
	{
		int result;
		try
		{
			UITask uitask = (UITask)LuaObject.checkSelf(l);
			string name;
			LuaObject.checkType(l, 2, out name);
			int timeout;
			LuaObject.checkType(l, 3, out timeout);
			Action<string> onTimeOut;
			LuaObject.checkDelegate<Action<string>>(l, 4, out onTimeOut);
			uitask.m_luaExportHelper.__callBase_RegUpdateViewPlayingEffect(name, timeout, onTimeOut);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06021E30 RID: 138800 RVA: 0x00B86F38 File Offset: 0x00B85138
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_UnregUpdateViewPlayingEffect(IntPtr l)
	{
		int result;
		try
		{
			UITask uitask = (UITask)LuaObject.checkSelf(l);
			string name;
			LuaObject.checkType(l, 2, out name);
			bool isTimeOut;
			LuaObject.checkType(l, 3, out isTimeOut);
			uitask.m_luaExportHelper.__callBase_UnregUpdateViewPlayingEffect(name, isTimeOut);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06021E31 RID: 138801 RVA: 0x00B86FA4 File Offset: 0x00B851A4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_PostUpdateView(IntPtr l)
	{
		int result;
		try
		{
			UITask uitask = (UITask)LuaObject.checkSelf(l);
			uitask.m_luaExportHelper.__callBase_PostUpdateView();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06021E32 RID: 138802 RVA: 0x00B86FF8 File Offset: 0x00B851F8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_PostUpdateViewBeforeClearContext(IntPtr l)
	{
		int result;
		try
		{
			UITask uitask = (UITask)LuaObject.checkSelf(l);
			uitask.m_luaExportHelper.__callBase_PostUpdateViewBeforeClearContext();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06021E33 RID: 138803 RVA: 0x00B8704C File Offset: 0x00B8524C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_HideAllView(IntPtr l)
	{
		int result;
		try
		{
			UITask uitask = (UITask)LuaObject.checkSelf(l);
			uitask.m_luaExportHelper.__callBase_HideAllView();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06021E34 RID: 138804 RVA: 0x00B870A0 File Offset: 0x00B852A0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_ClearAllContextAndRes(IntPtr l)
	{
		int result;
		try
		{
			UITask uitask = (UITask)LuaObject.checkSelf(l);
			uitask.m_luaExportHelper.__callBase_ClearAllContextAndRes();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06021E35 RID: 138805 RVA: 0x00B870F4 File Offset: 0x00B852F4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_SaveContextInIntentOnPause(IntPtr l)
	{
		int result;
		try
		{
			UITask uitask = (UITask)LuaObject.checkSelf(l);
			uitask.m_luaExportHelper.__callBase_SaveContextInIntentOnPause();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06021E36 RID: 138806 RVA: 0x00B87148 File Offset: 0x00B85348
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_ClearContextOnPause(IntPtr l)
	{
		int result;
		try
		{
			UITask uitask = (UITask)LuaObject.checkSelf(l);
			uitask.m_luaExportHelper.__callBase_ClearContextOnPause();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06021E37 RID: 138807 RVA: 0x00B8719C File Offset: 0x00B8539C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_ClearContextOnIntentChange(IntPtr l)
	{
		int result;
		try
		{
			UITask uitask = (UITask)LuaObject.checkSelf(l);
			UIIntent newIntent;
			LuaObject.checkType<UIIntent>(l, 2, out newIntent);
			uitask.m_luaExportHelper.__callBase_ClearContextOnIntentChange(newIntent);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06021E38 RID: 138808 RVA: 0x00B871F8 File Offset: 0x00B853F8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_ClearContextOnUpdateViewEnd(IntPtr l)
	{
		int result;
		try
		{
			UITask uitask = (UITask)LuaObject.checkSelf(l);
			uitask.m_luaExportHelper.__callBase_ClearContextOnUpdateViewEnd();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06021E39 RID: 138809 RVA: 0x00B8724C File Offset: 0x00B8544C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_EnableUIInput(IntPtr l)
	{
		int result;
		try
		{
			UITask uitask = (UITask)LuaObject.checkSelf(l);
			bool isEnable;
			LuaObject.checkType(l, 2, out isEnable);
			bool? isGlobalEnable;
			LuaObject.checkNullable<bool>(l, 3, out isGlobalEnable);
			uitask.m_luaExportHelper.__callBase_EnableUIInput(isEnable, isGlobalEnable);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06021E3A RID: 138810 RVA: 0x00B872B8 File Offset: 0x00B854B8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_GetLayerDescByName(IntPtr l)
	{
		int result;
		try
		{
			UITask uitask = (UITask)LuaObject.checkSelf(l);
			string name;
			LuaObject.checkType(l, 2, out name);
			UITaskBase.LayerDesc o = uitask.m_luaExportHelper.__callBase_GetLayerDescByName(name);
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

	// Token: 0x06021E3B RID: 138811 RVA: 0x00B87320 File Offset: 0x00B85520
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_GetLayerByName(IntPtr l)
	{
		int result;
		try
		{
			UITask uitask = (UITask)LuaObject.checkSelf(l);
			string name;
			LuaObject.checkType(l, 2, out name);
			SceneLayerBase o = uitask.m_luaExportHelper.__callBase_GetLayerByName(name);
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

	// Token: 0x06021E3C RID: 138812 RVA: 0x00B87388 File Offset: 0x00B85588
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_RegisterModesDefine(IntPtr l)
	{
		int result;
		try
		{
			UITask uitask = (UITask)LuaObject.checkSelf(l);
			string defaultMode;
			LuaObject.checkType(l, 2, out defaultMode);
			string[] modes;
			LuaObject.checkArray<string>(l, 3, out modes);
			uitask.m_luaExportHelper.__callBase_RegisterModesDefine(defaultMode, modes);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06021E3D RID: 138813 RVA: 0x00B873F4 File Offset: 0x00B855F4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_SetCurrentMode(IntPtr l)
	{
		int result;
		try
		{
			UITask uitask = (UITask)LuaObject.checkSelf(l);
			string mode;
			LuaObject.checkType(l, 2, out mode);
			bool b = uitask.m_luaExportHelper.__callBase_SetCurrentMode(mode);
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

	// Token: 0x06021E3E RID: 138814 RVA: 0x00B8745C File Offset: 0x00B8565C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_SetIsNeedPauseTimeOut(IntPtr l)
	{
		int result;
		try
		{
			UITask uitask = (UITask)LuaObject.checkSelf(l);
			bool isNeed;
			LuaObject.checkType(l, 2, out isNeed);
			uitask.m_luaExportHelper.__callBase_SetIsNeedPauseTimeOut(isNeed);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06021E3F RID: 138815 RVA: 0x00B874B8 File Offset: 0x00B856B8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_OnTick(IntPtr l)
	{
		int result;
		try
		{
			UITask uitask = (UITask)LuaObject.checkSelf(l);
			uitask.m_luaExportHelper.__callBase_OnTick();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06021E40 RID: 138816 RVA: 0x00B8750C File Offset: 0x00B8570C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_PostDelayTimeExecuteAction(IntPtr l)
	{
		int result;
		try
		{
			UITask uitask = (UITask)LuaObject.checkSelf(l);
			Action action;
			LuaObject.checkDelegate<Action>(l, 2, out action);
			float delaySeconds;
			LuaObject.checkType(l, 3, out delaySeconds);
			uitask.m_luaExportHelper.__callBase_PostDelayTimeExecuteAction(action, delaySeconds);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06021E41 RID: 138817 RVA: 0x00B87578 File Offset: 0x00B85778
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_PostDelayTicksExecuteAction(IntPtr l)
	{
		int result;
		try
		{
			UITask uitask = (UITask)LuaObject.checkSelf(l);
			Action action;
			LuaObject.checkDelegate<Action>(l, 2, out action);
			ulong delayTickCount;
			LuaObject.checkType(l, 3, out delayTickCount);
			uitask.m_luaExportHelper.__callBase_PostDelayTicksExecuteAction(action, delayTickCount);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06021E42 RID: 138818 RVA: 0x00B875E4 File Offset: 0x00B857E4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_SetTag(IntPtr l)
	{
		int result;
		try
		{
			UITask uitask = (UITask)LuaObject.checkSelf(l);
			string tag;
			LuaObject.checkType(l, 2, out tag);
			uitask.m_luaExportHelper.__callBase_SetTag(tag);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06021E43 RID: 138819 RVA: 0x00B87640 File Offset: 0x00B85840
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_HasTag(IntPtr l)
	{
		int result;
		try
		{
			UITask uitask = (UITask)LuaObject.checkSelf(l);
			string tag;
			LuaObject.checkType(l, 2, out tag);
			bool b = uitask.m_luaExportHelper.__callBase_HasTag(tag);
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

	// Token: 0x06021E44 RID: 138820 RVA: 0x00B876A8 File Offset: 0x00B858A8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_assets(IntPtr l)
	{
		int result;
		try
		{
			UITask uitask = (UITask)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, uitask.m_luaExportHelper.m_assets);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06021E45 RID: 138821 RVA: 0x00B87700 File Offset: 0x00B85900
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_assets(IntPtr l)
	{
		int result;
		try
		{
			UITask uitask = (UITask)LuaObject.checkSelf(l);
			List<string> assets;
			LuaObject.checkType<List<string>>(l, 2, out assets);
			uitask.m_luaExportHelper.m_assets = assets;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06021E46 RID: 138822 RVA: 0x00B8775C File Offset: 0x00B8595C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_loadingCustomResCorutineCount(IntPtr l)
	{
		int result;
		try
		{
			UITask uitask = (UITask)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, uitask.m_luaExportHelper.m_loadingCustomResCorutineCount);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06021E47 RID: 138823 RVA: 0x00B877B4 File Offset: 0x00B859B4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_loadingCustomResCorutineCount(IntPtr l)
	{
		int result;
		try
		{
			UITask uitask = (UITask)LuaObject.checkSelf(l);
			int loadingCustomResCorutineCount;
			LuaObject.checkType(l, 2, out loadingCustomResCorutineCount);
			uitask.m_luaExportHelper.m_loadingCustomResCorutineCount = loadingCustomResCorutineCount;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06021E48 RID: 138824 RVA: 0x00B87810 File Offset: 0x00B85A10
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_isOpeningUI(IntPtr l)
	{
		int result;
		try
		{
			UITask uitask = (UITask)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, uitask.m_luaExportHelper.m_isOpeningUI);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06021E49 RID: 138825 RVA: 0x00B87868 File Offset: 0x00B85A68
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_isOpeningUI(IntPtr l)
	{
		int result;
		try
		{
			UITask uitask = (UITask)LuaObject.checkSelf(l);
			bool isOpeningUI;
			LuaObject.checkType(l, 2, out isOpeningUI);
			uitask.m_luaExportHelper.m_isOpeningUI = isOpeningUI;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06021E4A RID: 138826 RVA: 0x00B878C4 File Offset: 0x00B85AC4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_isNeedRegisterPlayerContextEvents(IntPtr l)
	{
		int result;
		try
		{
			UITask uitask = (UITask)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, uitask.m_luaExportHelper.m_isNeedRegisterPlayerContextEvents);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06021E4B RID: 138827 RVA: 0x00B8791C File Offset: 0x00B85B1C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_isNeedRegisterPlayerContextEvents(IntPtr l)
	{
		int result;
		try
		{
			UITask uitask = (UITask)LuaObject.checkSelf(l);
			bool isNeedRegisterPlayerContextEvents;
			LuaObject.checkType(l, 2, out isNeedRegisterPlayerContextEvents);
			uitask.m_luaExportHelper.m_isNeedRegisterPlayerContextEvents = isNeedRegisterPlayerContextEvents;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06021E4C RID: 138828 RVA: 0x00B87978 File Offset: 0x00B85B78
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_isPlayerContextEventsRegistered(IntPtr l)
	{
		int result;
		try
		{
			UITask uitask = (UITask)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, uitask.m_luaExportHelper.m_isPlayerContextEventsRegistered);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06021E4D RID: 138829 RVA: 0x00B879D0 File Offset: 0x00B85BD0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_isPlayerContextEventsRegistered(IntPtr l)
	{
		int result;
		try
		{
			UITask uitask = (UITask)LuaObject.checkSelf(l);
			bool isPlayerContextEventsRegistered;
			LuaObject.checkType(l, 2, out isPlayerContextEventsRegistered);
			uitask.m_luaExportHelper.m_isPlayerContextEventsRegistered = isPlayerContextEventsRegistered;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06021E4E RID: 138830 RVA: 0x00B87A2C File Offset: 0x00B85C2C
	[Preserve]
	public static void reg(IntPtr l)
	{
		LuaObject.getTypeTable(l, "BlackJack.ProjectL.UI.UITask");
		if (Lua_BlackJack_ProjectL_UI_UITask.<>f__mg$cache0 == null)
		{
			Lua_BlackJack_ProjectL_UI_UITask.<>f__mg$cache0 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_UITask.OnNewIntent);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_UITask.<>f__mg$cache0);
		if (Lua_BlackJack_ProjectL_UI_UITask.<>f__mg$cache1 == null)
		{
			Lua_BlackJack_ProjectL_UI_UITask.<>f__mg$cache1 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_UITask.EnableUIInput);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_UITask.<>f__mg$cache1);
		if (Lua_BlackJack_ProjectL_UI_UITask.<>f__mg$cache2 == null)
		{
			Lua_BlackJack_ProjectL_UI_UITask.<>f__mg$cache2 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_UITask.OnStart);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_UITask.<>f__mg$cache2);
		if (Lua_BlackJack_ProjectL_UI_UITask.<>f__mg$cache3 == null)
		{
			Lua_BlackJack_ProjectL_UI_UITask.<>f__mg$cache3 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_UITask.OnStop);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_UITask.<>f__mg$cache3);
		if (Lua_BlackJack_ProjectL_UI_UITask.<>f__mg$cache4 == null)
		{
			Lua_BlackJack_ProjectL_UI_UITask.<>f__mg$cache4 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_UITask.OnPause);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_UITask.<>f__mg$cache4);
		if (Lua_BlackJack_ProjectL_UI_UITask.<>f__mg$cache5 == null)
		{
			Lua_BlackJack_ProjectL_UI_UITask.<>f__mg$cache5 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_UITask.OnResume);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_UITask.<>f__mg$cache5);
		if (Lua_BlackJack_ProjectL_UI_UITask.<>f__mg$cache6 == null)
		{
			Lua_BlackJack_ProjectL_UI_UITask.<>f__mg$cache6 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_UITask.IsNeedLoadDynamicRes);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_UITask.<>f__mg$cache6);
		if (Lua_BlackJack_ProjectL_UI_UITask.<>f__mg$cache7 == null)
		{
			Lua_BlackJack_ProjectL_UI_UITask.<>f__mg$cache7 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_UITask.CollectAllDynamicResForLoad);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_UITask.<>f__mg$cache7);
		if (Lua_BlackJack_ProjectL_UI_UITask.<>f__mg$cache8 == null)
		{
			Lua_BlackJack_ProjectL_UI_UITask.<>f__mg$cache8 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_UITask.RegisterPlayerContextEvents);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_UITask.<>f__mg$cache8);
		if (Lua_BlackJack_ProjectL_UI_UITask.<>f__mg$cache9 == null)
		{
			Lua_BlackJack_ProjectL_UI_UITask.<>f__mg$cache9 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_UITask.UnregisterPlayerContextEvents);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_UITask.<>f__mg$cache9);
		if (Lua_BlackJack_ProjectL_UI_UITask.<>f__mg$cacheA == null)
		{
			Lua_BlackJack_ProjectL_UI_UITask.<>f__mg$cacheA = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_UITask.PostUpdateView);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_UITask.<>f__mg$cacheA);
		if (Lua_BlackJack_ProjectL_UI_UITask.<>f__mg$cacheB == null)
		{
			Lua_BlackJack_ProjectL_UI_UITask.<>f__mg$cacheB = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_UITask.CollectPreloadResourceList);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_UITask.<>f__mg$cacheB);
		if (Lua_BlackJack_ProjectL_UI_UITask.<>f__mg$cacheC == null)
		{
			Lua_BlackJack_ProjectL_UI_UITask.<>f__mg$cacheC = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_UITask.ClearAssetList);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_UITask.<>f__mg$cacheC);
		if (Lua_BlackJack_ProjectL_UI_UITask.<>f__mg$cacheD == null)
		{
			Lua_BlackJack_ProjectL_UI_UITask.<>f__mg$cacheD = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_UITask.CollectAsset);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_UITask.<>f__mg$cacheD);
		if (Lua_BlackJack_ProjectL_UI_UITask.<>f__mg$cacheE == null)
		{
			Lua_BlackJack_ProjectL_UI_UITask.<>f__mg$cacheE = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_UITask.CollectSpriteAsset);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_UITask.<>f__mg$cacheE);
		if (Lua_BlackJack_ProjectL_UI_UITask.<>f__mg$cacheF == null)
		{
			Lua_BlackJack_ProjectL_UI_UITask.<>f__mg$cacheF = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_UITask.CollectFxAsset);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_UITask.<>f__mg$cacheF);
		if (Lua_BlackJack_ProjectL_UI_UITask.<>f__mg$cache10 == null)
		{
			Lua_BlackJack_ProjectL_UI_UITask.<>f__mg$cache10 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_UITask.StartLoadCustomRes);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_UITask.<>f__mg$cache10);
		if (Lua_BlackJack_ProjectL_UI_UITask.<>f__mg$cache11 == null)
		{
			Lua_BlackJack_ProjectL_UI_UITask.<>f__mg$cache11 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_UITask.StartLoadCustomAssets);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_UITask.<>f__mg$cache11);
		if (Lua_BlackJack_ProjectL_UI_UITask.<>f__mg$cache12 == null)
		{
			Lua_BlackJack_ProjectL_UI_UITask.<>f__mg$cache12 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_UITask.IsLoadingCustomAssets);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_UITask.<>f__mg$cache12);
		if (Lua_BlackJack_ProjectL_UI_UITask.<>f__mg$cache13 == null)
		{
			Lua_BlackJack_ProjectL_UI_UITask.<>f__mg$cache13 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_UITask.IsPipeLineRunning);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_UITask.<>f__mg$cache13);
		if (Lua_BlackJack_ProjectL_UI_UITask.<>f__mg$cache14 == null)
		{
			Lua_BlackJack_ProjectL_UI_UITask.<>f__mg$cache14 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_UITask.IsOpeningUI);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_UITask.<>f__mg$cache14);
		if (Lua_BlackJack_ProjectL_UI_UITask.<>f__mg$cache15 == null)
		{
			Lua_BlackJack_ProjectL_UI_UITask.<>f__mg$cache15 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_UITask.ReturnPrevUITask);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_UITask.<>f__mg$cache15);
		if (Lua_BlackJack_ProjectL_UI_UITask.<>f__mg$cache16 == null)
		{
			Lua_BlackJack_ProjectL_UI_UITask.<>f__mg$cache16 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_UITask.ClearUnusedDynamicResourceCache);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_UITask.<>f__mg$cache16);
		if (Lua_BlackJack_ProjectL_UI_UITask.<>f__mg$cache17 == null)
		{
			Lua_BlackJack_ProjectL_UI_UITask.<>f__mg$cache17 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_UITask.OnMemoryWarning);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_UITask.<>f__mg$cache17);
		if (Lua_BlackJack_ProjectL_UI_UITask.<>f__mg$cache18 == null)
		{
			Lua_BlackJack_ProjectL_UI_UITask.<>f__mg$cache18 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_UITask.__callBase_InitlizeBeforeManagerStartIt);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_UITask.<>f__mg$cache18);
		if (Lua_BlackJack_ProjectL_UI_UITask.<>f__mg$cache19 == null)
		{
			Lua_BlackJack_ProjectL_UI_UITask.<>f__mg$cache19 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_UITask.__callBase_PrepareForStartOrResume);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_UITask.<>f__mg$cache19);
		if (Lua_BlackJack_ProjectL_UI_UITask.<>f__mg$cache1A == null)
		{
			Lua_BlackJack_ProjectL_UI_UITask.<>f__mg$cache1A = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_UITask.__callBase_OnStart);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_UITask.<>f__mg$cache1A);
		if (Lua_BlackJack_ProjectL_UI_UITask.<>f__mg$cache1B == null)
		{
			Lua_BlackJack_ProjectL_UI_UITask.<>f__mg$cache1B = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_UITask.__callBase_GetPipeLineCtx);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_UITask.<>f__mg$cache1B);
		if (Lua_BlackJack_ProjectL_UI_UITask.<>f__mg$cache1C == null)
		{
			Lua_BlackJack_ProjectL_UI_UITask.<>f__mg$cache1C = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_UITask.__callBase_CreatePipeLineCtx);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_UITask.<>f__mg$cache1C);
		if (Lua_BlackJack_ProjectL_UI_UITask.<>f__mg$cache1D == null)
		{
			Lua_BlackJack_ProjectL_UI_UITask.<>f__mg$cache1D = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_UITask.__callBase_OnStop);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_UITask.<>f__mg$cache1D);
		if (Lua_BlackJack_ProjectL_UI_UITask.<>f__mg$cache1E == null)
		{
			Lua_BlackJack_ProjectL_UI_UITask.<>f__mg$cache1E = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_UITask.__callBase_OnPause);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_UITask.<>f__mg$cache1E);
		if (Lua_BlackJack_ProjectL_UI_UITask.<>f__mg$cache1F == null)
		{
			Lua_BlackJack_ProjectL_UI_UITask.<>f__mg$cache1F = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_UITask.__callBase_OnResume);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_UITask.<>f__mg$cache1F);
		if (Lua_BlackJack_ProjectL_UI_UITask.<>f__mg$cache20 == null)
		{
			Lua_BlackJack_ProjectL_UI_UITask.<>f__mg$cache20 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_UITask.__callBase_OnNewIntent);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_UITask.<>f__mg$cache20);
		if (Lua_BlackJack_ProjectL_UI_UITask.<>f__mg$cache21 == null)
		{
			Lua_BlackJack_ProjectL_UI_UITask.<>f__mg$cache21 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_UITask.__callBase_StartUpdatePipeLine);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_UITask.<>f__mg$cache21);
		if (Lua_BlackJack_ProjectL_UI_UITask.<>f__mg$cache22 == null)
		{
			Lua_BlackJack_ProjectL_UI_UITask.<>f__mg$cache22 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_UITask.__callBase_NeedSkipUpdatePipeLine);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_UITask.<>f__mg$cache22);
		if (Lua_BlackJack_ProjectL_UI_UITask.<>f__mg$cache23 == null)
		{
			Lua_BlackJack_ProjectL_UI_UITask.<>f__mg$cache23 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_UITask.__callBase_IsNeedUpdateDataCache);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_UITask.<>f__mg$cache23);
		if (Lua_BlackJack_ProjectL_UI_UITask.<>f__mg$cache24 == null)
		{
			Lua_BlackJack_ProjectL_UI_UITask.<>f__mg$cache24 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_UITask.__callBase_UpdateDataCache);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_UITask.<>f__mg$cache24);
		if (Lua_BlackJack_ProjectL_UI_UITask.<>f__mg$cache25 == null)
		{
			Lua_BlackJack_ProjectL_UI_UITask.<>f__mg$cache25 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_UITask.__callBase_IsNeedLoadStaticRes);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_UITask.<>f__mg$cache25);
		if (Lua_BlackJack_ProjectL_UI_UITask.<>f__mg$cache26 == null)
		{
			Lua_BlackJack_ProjectL_UI_UITask.<>f__mg$cache26 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_UITask.__callBase_StartLoadStaticRes);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_UITask.<>f__mg$cache26);
		if (Lua_BlackJack_ProjectL_UI_UITask.<>f__mg$cache27 == null)
		{
			Lua_BlackJack_ProjectL_UI_UITask.<>f__mg$cache27 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_UITask.__callBase_CheckLayerDescArray);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_UITask.<>f__mg$cache27);
		if (Lua_BlackJack_ProjectL_UI_UITask.<>f__mg$cache28 == null)
		{
			Lua_BlackJack_ProjectL_UI_UITask.<>f__mg$cache28 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_UITask.__callBase_OnLoadStaticResCompleted);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_UITask.<>f__mg$cache28);
		if (Lua_BlackJack_ProjectL_UI_UITask.<>f__mg$cache29 == null)
		{
			Lua_BlackJack_ProjectL_UI_UITask.<>f__mg$cache29 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_UITask.__callBase_IsNeedLoadDynamicRes);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_UITask.<>f__mg$cache29);
		if (Lua_BlackJack_ProjectL_UI_UITask.<>f__mg$cache2A == null)
		{
			Lua_BlackJack_ProjectL_UI_UITask.<>f__mg$cache2A = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_UITask.__callBase_StartLoadDynamicRes);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_UITask.<>f__mg$cache2A);
		if (Lua_BlackJack_ProjectL_UI_UITask.<>f__mg$cache2B == null)
		{
			Lua_BlackJack_ProjectL_UI_UITask.<>f__mg$cache2B = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_UITask.__callBase_CollectAllDynamicResForLoad);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_UITask.<>f__mg$cache2B);
		if (Lua_BlackJack_ProjectL_UI_UITask.<>f__mg$cache2C == null)
		{
			Lua_BlackJack_ProjectL_UI_UITask.<>f__mg$cache2C = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_UITask.__callBase_CollectAllStaticResDescForLoad);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_UITask.<>f__mg$cache2C);
		if (Lua_BlackJack_ProjectL_UI_UITask.<>f__mg$cache2D == null)
		{
			Lua_BlackJack_ProjectL_UI_UITask.<>f__mg$cache2D = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_UITask.__callBase_CalculateDynamicResReallyNeedLoad);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_UITask.<>f__mg$cache2D);
		if (Lua_BlackJack_ProjectL_UI_UITask.<>f__mg$cache2E == null)
		{
			Lua_BlackJack_ProjectL_UI_UITask.<>f__mg$cache2E = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_UITask.__callBase_OnLoadDynamicResCompleted);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_UITask.<>f__mg$cache2E);
		if (Lua_BlackJack_ProjectL_UI_UITask.<>f__mg$cache2F == null)
		{
			Lua_BlackJack_ProjectL_UI_UITask.<>f__mg$cache2F = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_UITask.__callBase_RedirectPipLineOnAllResReady);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_UITask.<>f__mg$cache2F);
		if (Lua_BlackJack_ProjectL_UI_UITask.<>f__mg$cache30 == null)
		{
			Lua_BlackJack_ProjectL_UI_UITask.<>f__mg$cache30 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_UITask.__callBase_OnLoadAllResCompleted);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_UITask.<>f__mg$cache30);
		if (Lua_BlackJack_ProjectL_UI_UITask.<>f__mg$cache31 == null)
		{
			Lua_BlackJack_ProjectL_UI_UITask.<>f__mg$cache31 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_UITask.__callBase_ReturnFromRedirectPipLineOnLoadAllResCompleted);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_UITask.<>f__mg$cache31);
		if (Lua_BlackJack_ProjectL_UI_UITask.<>f__mg$cache32 == null)
		{
			Lua_BlackJack_ProjectL_UI_UITask.<>f__mg$cache32 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_UITask.__callBase_InitLayerStateOnLoadAllResCompleted);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_UITask.<>f__mg$cache32);
		if (Lua_BlackJack_ProjectL_UI_UITask.<>f__mg$cache33 == null)
		{
			Lua_BlackJack_ProjectL_UI_UITask.<>f__mg$cache33 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_UITask.__callBase_InitAllUIControllers);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_UITask.<>f__mg$cache33);
		if (Lua_BlackJack_ProjectL_UI_UITask.<>f__mg$cache34 == null)
		{
			Lua_BlackJack_ProjectL_UI_UITask.<>f__mg$cache34 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_UITask.__callBase_PostOnLoadAllResCompleted);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_UITask.<>f__mg$cache34);
		if (Lua_BlackJack_ProjectL_UI_UITask.<>f__mg$cache35 == null)
		{
			Lua_BlackJack_ProjectL_UI_UITask.<>f__mg$cache35 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_UITask.__callBase_IsLoadAllResCompleted);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_UITask.<>f__mg$cache35);
		if (Lua_BlackJack_ProjectL_UI_UITask.<>f__mg$cache36 == null)
		{
			Lua_BlackJack_ProjectL_UI_UITask.<>f__mg$cache36 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_UITask.__callBase_StartUpdateView);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_UITask.<>f__mg$cache36);
		if (Lua_BlackJack_ProjectL_UI_UITask.<>f__mg$cache37 == null)
		{
			Lua_BlackJack_ProjectL_UI_UITask.<>f__mg$cache37 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_UITask.__callBase_UpdateView);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_UITask.<>f__mg$cache37);
		if (Lua_BlackJack_ProjectL_UI_UITask.<>f__mg$cache38 == null)
		{
			Lua_BlackJack_ProjectL_UI_UITask.<>f__mg$cache38 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_UITask.__callBase_RegUpdateViewPlayingEffect);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_UITask.<>f__mg$cache38);
		if (Lua_BlackJack_ProjectL_UI_UITask.<>f__mg$cache39 == null)
		{
			Lua_BlackJack_ProjectL_UI_UITask.<>f__mg$cache39 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_UITask.__callBase_UnregUpdateViewPlayingEffect);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_UITask.<>f__mg$cache39);
		if (Lua_BlackJack_ProjectL_UI_UITask.<>f__mg$cache3A == null)
		{
			Lua_BlackJack_ProjectL_UI_UITask.<>f__mg$cache3A = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_UITask.__callBase_PostUpdateView);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_UITask.<>f__mg$cache3A);
		if (Lua_BlackJack_ProjectL_UI_UITask.<>f__mg$cache3B == null)
		{
			Lua_BlackJack_ProjectL_UI_UITask.<>f__mg$cache3B = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_UITask.__callBase_PostUpdateViewBeforeClearContext);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_UITask.<>f__mg$cache3B);
		if (Lua_BlackJack_ProjectL_UI_UITask.<>f__mg$cache3C == null)
		{
			Lua_BlackJack_ProjectL_UI_UITask.<>f__mg$cache3C = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_UITask.__callBase_HideAllView);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_UITask.<>f__mg$cache3C);
		if (Lua_BlackJack_ProjectL_UI_UITask.<>f__mg$cache3D == null)
		{
			Lua_BlackJack_ProjectL_UI_UITask.<>f__mg$cache3D = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_UITask.__callBase_ClearAllContextAndRes);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_UITask.<>f__mg$cache3D);
		if (Lua_BlackJack_ProjectL_UI_UITask.<>f__mg$cache3E == null)
		{
			Lua_BlackJack_ProjectL_UI_UITask.<>f__mg$cache3E = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_UITask.__callBase_SaveContextInIntentOnPause);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_UITask.<>f__mg$cache3E);
		if (Lua_BlackJack_ProjectL_UI_UITask.<>f__mg$cache3F == null)
		{
			Lua_BlackJack_ProjectL_UI_UITask.<>f__mg$cache3F = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_UITask.__callBase_ClearContextOnPause);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_UITask.<>f__mg$cache3F);
		if (Lua_BlackJack_ProjectL_UI_UITask.<>f__mg$cache40 == null)
		{
			Lua_BlackJack_ProjectL_UI_UITask.<>f__mg$cache40 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_UITask.__callBase_ClearContextOnIntentChange);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_UITask.<>f__mg$cache40);
		if (Lua_BlackJack_ProjectL_UI_UITask.<>f__mg$cache41 == null)
		{
			Lua_BlackJack_ProjectL_UI_UITask.<>f__mg$cache41 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_UITask.__callBase_ClearContextOnUpdateViewEnd);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_UITask.<>f__mg$cache41);
		if (Lua_BlackJack_ProjectL_UI_UITask.<>f__mg$cache42 == null)
		{
			Lua_BlackJack_ProjectL_UI_UITask.<>f__mg$cache42 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_UITask.__callBase_EnableUIInput);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_UITask.<>f__mg$cache42);
		if (Lua_BlackJack_ProjectL_UI_UITask.<>f__mg$cache43 == null)
		{
			Lua_BlackJack_ProjectL_UI_UITask.<>f__mg$cache43 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_UITask.__callBase_GetLayerDescByName);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_UITask.<>f__mg$cache43);
		if (Lua_BlackJack_ProjectL_UI_UITask.<>f__mg$cache44 == null)
		{
			Lua_BlackJack_ProjectL_UI_UITask.<>f__mg$cache44 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_UITask.__callBase_GetLayerByName);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_UITask.<>f__mg$cache44);
		if (Lua_BlackJack_ProjectL_UI_UITask.<>f__mg$cache45 == null)
		{
			Lua_BlackJack_ProjectL_UI_UITask.<>f__mg$cache45 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_UITask.__callBase_RegisterModesDefine);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_UITask.<>f__mg$cache45);
		if (Lua_BlackJack_ProjectL_UI_UITask.<>f__mg$cache46 == null)
		{
			Lua_BlackJack_ProjectL_UI_UITask.<>f__mg$cache46 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_UITask.__callBase_SetCurrentMode);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_UITask.<>f__mg$cache46);
		if (Lua_BlackJack_ProjectL_UI_UITask.<>f__mg$cache47 == null)
		{
			Lua_BlackJack_ProjectL_UI_UITask.<>f__mg$cache47 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_UITask.__callBase_SetIsNeedPauseTimeOut);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_UITask.<>f__mg$cache47);
		if (Lua_BlackJack_ProjectL_UI_UITask.<>f__mg$cache48 == null)
		{
			Lua_BlackJack_ProjectL_UI_UITask.<>f__mg$cache48 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_UITask.__callBase_OnTick);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_UITask.<>f__mg$cache48);
		if (Lua_BlackJack_ProjectL_UI_UITask.<>f__mg$cache49 == null)
		{
			Lua_BlackJack_ProjectL_UI_UITask.<>f__mg$cache49 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_UITask.__callBase_PostDelayTimeExecuteAction);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_UITask.<>f__mg$cache49);
		if (Lua_BlackJack_ProjectL_UI_UITask.<>f__mg$cache4A == null)
		{
			Lua_BlackJack_ProjectL_UI_UITask.<>f__mg$cache4A = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_UITask.__callBase_PostDelayTicksExecuteAction);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_UITask.<>f__mg$cache4A);
		if (Lua_BlackJack_ProjectL_UI_UITask.<>f__mg$cache4B == null)
		{
			Lua_BlackJack_ProjectL_UI_UITask.<>f__mg$cache4B = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_UITask.__callBase_SetTag);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_UITask.<>f__mg$cache4B);
		if (Lua_BlackJack_ProjectL_UI_UITask.<>f__mg$cache4C == null)
		{
			Lua_BlackJack_ProjectL_UI_UITask.<>f__mg$cache4C = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_UITask.__callBase_HasTag);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_UITask.<>f__mg$cache4C);
		string name = "m_assets";
		if (Lua_BlackJack_ProjectL_UI_UITask.<>f__mg$cache4D == null)
		{
			Lua_BlackJack_ProjectL_UI_UITask.<>f__mg$cache4D = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_UITask.get_m_assets);
		}
		LuaCSFunction get = Lua_BlackJack_ProjectL_UI_UITask.<>f__mg$cache4D;
		if (Lua_BlackJack_ProjectL_UI_UITask.<>f__mg$cache4E == null)
		{
			Lua_BlackJack_ProjectL_UI_UITask.<>f__mg$cache4E = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_UITask.set_m_assets);
		}
		LuaObject.addMember(l, name, get, Lua_BlackJack_ProjectL_UI_UITask.<>f__mg$cache4E, true);
		string name2 = "m_loadingCustomResCorutineCount";
		if (Lua_BlackJack_ProjectL_UI_UITask.<>f__mg$cache4F == null)
		{
			Lua_BlackJack_ProjectL_UI_UITask.<>f__mg$cache4F = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_UITask.get_m_loadingCustomResCorutineCount);
		}
		LuaCSFunction get2 = Lua_BlackJack_ProjectL_UI_UITask.<>f__mg$cache4F;
		if (Lua_BlackJack_ProjectL_UI_UITask.<>f__mg$cache50 == null)
		{
			Lua_BlackJack_ProjectL_UI_UITask.<>f__mg$cache50 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_UITask.set_m_loadingCustomResCorutineCount);
		}
		LuaObject.addMember(l, name2, get2, Lua_BlackJack_ProjectL_UI_UITask.<>f__mg$cache50, true);
		string name3 = "m_isOpeningUI";
		if (Lua_BlackJack_ProjectL_UI_UITask.<>f__mg$cache51 == null)
		{
			Lua_BlackJack_ProjectL_UI_UITask.<>f__mg$cache51 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_UITask.get_m_isOpeningUI);
		}
		LuaCSFunction get3 = Lua_BlackJack_ProjectL_UI_UITask.<>f__mg$cache51;
		if (Lua_BlackJack_ProjectL_UI_UITask.<>f__mg$cache52 == null)
		{
			Lua_BlackJack_ProjectL_UI_UITask.<>f__mg$cache52 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_UITask.set_m_isOpeningUI);
		}
		LuaObject.addMember(l, name3, get3, Lua_BlackJack_ProjectL_UI_UITask.<>f__mg$cache52, true);
		string name4 = "m_isNeedRegisterPlayerContextEvents";
		if (Lua_BlackJack_ProjectL_UI_UITask.<>f__mg$cache53 == null)
		{
			Lua_BlackJack_ProjectL_UI_UITask.<>f__mg$cache53 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_UITask.get_m_isNeedRegisterPlayerContextEvents);
		}
		LuaCSFunction get4 = Lua_BlackJack_ProjectL_UI_UITask.<>f__mg$cache53;
		if (Lua_BlackJack_ProjectL_UI_UITask.<>f__mg$cache54 == null)
		{
			Lua_BlackJack_ProjectL_UI_UITask.<>f__mg$cache54 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_UITask.set_m_isNeedRegisterPlayerContextEvents);
		}
		LuaObject.addMember(l, name4, get4, Lua_BlackJack_ProjectL_UI_UITask.<>f__mg$cache54, true);
		string name5 = "m_isPlayerContextEventsRegistered";
		if (Lua_BlackJack_ProjectL_UI_UITask.<>f__mg$cache55 == null)
		{
			Lua_BlackJack_ProjectL_UI_UITask.<>f__mg$cache55 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_UITask.get_m_isPlayerContextEventsRegistered);
		}
		LuaCSFunction get5 = Lua_BlackJack_ProjectL_UI_UITask.<>f__mg$cache55;
		if (Lua_BlackJack_ProjectL_UI_UITask.<>f__mg$cache56 == null)
		{
			Lua_BlackJack_ProjectL_UI_UITask.<>f__mg$cache56 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_UITask.set_m_isPlayerContextEventsRegistered);
		}
		LuaObject.addMember(l, name5, get5, Lua_BlackJack_ProjectL_UI_UITask.<>f__mg$cache56, true);
		if (Lua_BlackJack_ProjectL_UI_UITask.<>f__mg$cache57 == null)
		{
			Lua_BlackJack_ProjectL_UI_UITask.<>f__mg$cache57 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_UITask.constructor);
		}
		LuaObject.createTypeMetatable(l, Lua_BlackJack_ProjectL_UI_UITask.<>f__mg$cache57, typeof(UITask), typeof(UITaskBase));
	}

	// Token: 0x04017C54 RID: 97364
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache0;

	// Token: 0x04017C55 RID: 97365
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1;

	// Token: 0x04017C56 RID: 97366
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2;

	// Token: 0x04017C57 RID: 97367
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3;

	// Token: 0x04017C58 RID: 97368
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache4;

	// Token: 0x04017C59 RID: 97369
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache5;

	// Token: 0x04017C5A RID: 97370
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache6;

	// Token: 0x04017C5B RID: 97371
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache7;

	// Token: 0x04017C5C RID: 97372
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache8;

	// Token: 0x04017C5D RID: 97373
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache9;

	// Token: 0x04017C5E RID: 97374
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheA;

	// Token: 0x04017C5F RID: 97375
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheB;

	// Token: 0x04017C60 RID: 97376
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheC;

	// Token: 0x04017C61 RID: 97377
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheD;

	// Token: 0x04017C62 RID: 97378
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheE;

	// Token: 0x04017C63 RID: 97379
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheF;

	// Token: 0x04017C64 RID: 97380
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache10;

	// Token: 0x04017C65 RID: 97381
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache11;

	// Token: 0x04017C66 RID: 97382
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache12;

	// Token: 0x04017C67 RID: 97383
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache13;

	// Token: 0x04017C68 RID: 97384
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache14;

	// Token: 0x04017C69 RID: 97385
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache15;

	// Token: 0x04017C6A RID: 97386
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache16;

	// Token: 0x04017C6B RID: 97387
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache17;

	// Token: 0x04017C6C RID: 97388
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache18;

	// Token: 0x04017C6D RID: 97389
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache19;

	// Token: 0x04017C6E RID: 97390
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1A;

	// Token: 0x04017C6F RID: 97391
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1B;

	// Token: 0x04017C70 RID: 97392
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1C;

	// Token: 0x04017C71 RID: 97393
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1D;

	// Token: 0x04017C72 RID: 97394
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1E;

	// Token: 0x04017C73 RID: 97395
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1F;

	// Token: 0x04017C74 RID: 97396
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache20;

	// Token: 0x04017C75 RID: 97397
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache21;

	// Token: 0x04017C76 RID: 97398
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache22;

	// Token: 0x04017C77 RID: 97399
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache23;

	// Token: 0x04017C78 RID: 97400
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache24;

	// Token: 0x04017C79 RID: 97401
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache25;

	// Token: 0x04017C7A RID: 97402
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache26;

	// Token: 0x04017C7B RID: 97403
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache27;

	// Token: 0x04017C7C RID: 97404
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache28;

	// Token: 0x04017C7D RID: 97405
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache29;

	// Token: 0x04017C7E RID: 97406
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2A;

	// Token: 0x04017C7F RID: 97407
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2B;

	// Token: 0x04017C80 RID: 97408
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2C;

	// Token: 0x04017C81 RID: 97409
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2D;

	// Token: 0x04017C82 RID: 97410
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2E;

	// Token: 0x04017C83 RID: 97411
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2F;

	// Token: 0x04017C84 RID: 97412
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache30;

	// Token: 0x04017C85 RID: 97413
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache31;

	// Token: 0x04017C86 RID: 97414
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache32;

	// Token: 0x04017C87 RID: 97415
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache33;

	// Token: 0x04017C88 RID: 97416
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache34;

	// Token: 0x04017C89 RID: 97417
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache35;

	// Token: 0x04017C8A RID: 97418
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache36;

	// Token: 0x04017C8B RID: 97419
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache37;

	// Token: 0x04017C8C RID: 97420
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache38;

	// Token: 0x04017C8D RID: 97421
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache39;

	// Token: 0x04017C8E RID: 97422
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3A;

	// Token: 0x04017C8F RID: 97423
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3B;

	// Token: 0x04017C90 RID: 97424
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3C;

	// Token: 0x04017C91 RID: 97425
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3D;

	// Token: 0x04017C92 RID: 97426
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3E;

	// Token: 0x04017C93 RID: 97427
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3F;

	// Token: 0x04017C94 RID: 97428
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache40;

	// Token: 0x04017C95 RID: 97429
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache41;

	// Token: 0x04017C96 RID: 97430
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache42;

	// Token: 0x04017C97 RID: 97431
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache43;

	// Token: 0x04017C98 RID: 97432
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache44;

	// Token: 0x04017C99 RID: 97433
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache45;

	// Token: 0x04017C9A RID: 97434
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache46;

	// Token: 0x04017C9B RID: 97435
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache47;

	// Token: 0x04017C9C RID: 97436
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache48;

	// Token: 0x04017C9D RID: 97437
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache49;

	// Token: 0x04017C9E RID: 97438
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache4A;

	// Token: 0x04017C9F RID: 97439
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache4B;

	// Token: 0x04017CA0 RID: 97440
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache4C;

	// Token: 0x04017CA1 RID: 97441
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache4D;

	// Token: 0x04017CA2 RID: 97442
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache4E;

	// Token: 0x04017CA3 RID: 97443
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache4F;

	// Token: 0x04017CA4 RID: 97444
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache50;

	// Token: 0x04017CA5 RID: 97445
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache51;

	// Token: 0x04017CA6 RID: 97446
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache52;

	// Token: 0x04017CA7 RID: 97447
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache53;

	// Token: 0x04017CA8 RID: 97448
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache54;

	// Token: 0x04017CA9 RID: 97449
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache55;

	// Token: 0x04017CAA RID: 97450
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache56;

	// Token: 0x04017CAB RID: 97451
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache57;
}
