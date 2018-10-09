using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using BlackJack.BJFramework.Runtime.UI;
using BlackJack.ProjectL.UI;
using SLua;
using UnityEngine.Scripting;

// Token: 0x0200153B RID: 5435
[Preserve]
public class Lua_BlackJack_ProjectL_UI_PreloadUITask : LuaObject
{
	// Token: 0x06020717 RID: 132887 RVA: 0x00ACF4CC File Offset: 0x00ACD6CC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int constructor(IntPtr l)
	{
		int result;
		try
		{
			string name;
			LuaObject.checkType(l, 2, out name);
			PreloadUITask o = new PreloadUITask(name);
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

	// Token: 0x06020718 RID: 132888 RVA: 0x00ACF520 File Offset: 0x00ACD720
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int OnNewIntent(IntPtr l)
	{
		int result;
		try
		{
			PreloadUITask preloadUITask = (PreloadUITask)LuaObject.checkSelf(l);
			UIIntent intent;
			LuaObject.checkType<UIIntent>(l, 2, out intent);
			bool b = preloadUITask.OnNewIntent(intent);
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

	// Token: 0x06020719 RID: 132889 RVA: 0x00ACF584 File Offset: 0x00ACD784
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int OnLoadDynamicResCompleted(IntPtr l)
	{
		int result;
		try
		{
			PreloadUITask preloadUITask = (PreloadUITask)LuaObject.checkSelf(l);
			preloadUITask.m_luaExportHelper.OnLoadDynamicResCompleted();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0602071A RID: 132890 RVA: 0x00ACF5D8 File Offset: 0x00ACD7D8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int IsNeedLoadDynamicRes(IntPtr l)
	{
		int result;
		try
		{
			PreloadUITask preloadUITask = (PreloadUITask)LuaObject.checkSelf(l);
			bool b = preloadUITask.m_luaExportHelper.IsNeedLoadDynamicRes();
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

	// Token: 0x0602071B RID: 132891 RVA: 0x00ACF634 File Offset: 0x00ACD834
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int PostOnLoadAllResCompleted(IntPtr l)
	{
		int result;
		try
		{
			PreloadUITask preloadUITask = (PreloadUITask)LuaObject.checkSelf(l);
			preloadUITask.m_luaExportHelper.PostOnLoadAllResCompleted();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0602071C RID: 132892 RVA: 0x00ACF688 File Offset: 0x00ACD888
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int InitAllUIControllers(IntPtr l)
	{
		int result;
		try
		{
			PreloadUITask preloadUITask = (PreloadUITask)LuaObject.checkSelf(l);
			preloadUITask.m_luaExportHelper.InitAllUIControllers();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0602071D RID: 132893 RVA: 0x00ACF6DC File Offset: 0x00ACD8DC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int ClearAllContextAndRes(IntPtr l)
	{
		int result;
		try
		{
			PreloadUITask preloadUITask = (PreloadUITask)LuaObject.checkSelf(l);
			preloadUITask.m_luaExportHelper.ClearAllContextAndRes();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0602071E RID: 132894 RVA: 0x00ACF730 File Offset: 0x00ACD930
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int OnStart(IntPtr l)
	{
		int result;
		try
		{
			PreloadUITask preloadUITask = (PreloadUITask)LuaObject.checkSelf(l);
			UIIntent intent;
			LuaObject.checkType<UIIntent>(l, 2, out intent);
			bool b = preloadUITask.m_luaExportHelper.OnStart(intent);
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

	// Token: 0x0602071F RID: 132895 RVA: 0x00ACF798 File Offset: 0x00ACD998
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int OnResume(IntPtr l)
	{
		int result;
		try
		{
			PreloadUITask preloadUITask = (PreloadUITask)LuaObject.checkSelf(l);
			UIIntent intent;
			LuaObject.checkType<UIIntent>(l, 2, out intent);
			bool b = preloadUITask.m_luaExportHelper.OnResume(intent);
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

	// Token: 0x06020720 RID: 132896 RVA: 0x00ACF800 File Offset: 0x00ACDA00
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int OnStop(IntPtr l)
	{
		int result;
		try
		{
			PreloadUITask preloadUITask = (PreloadUITask)LuaObject.checkSelf(l);
			preloadUITask.m_luaExportHelper.OnStop();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06020721 RID: 132897 RVA: 0x00ACF854 File Offset: 0x00ACDA54
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int OnTick(IntPtr l)
	{
		int result;
		try
		{
			PreloadUITask preloadUITask = (PreloadUITask)LuaObject.checkSelf(l);
			preloadUITask.m_luaExportHelper.OnTick();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06020722 RID: 132898 RVA: 0x00ACF8A8 File Offset: 0x00ACDAA8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int UpdateView(IntPtr l)
	{
		int result;
		try
		{
			PreloadUITask preloadUITask = (PreloadUITask)LuaObject.checkSelf(l);
			preloadUITask.m_luaExportHelper.UpdateView();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06020723 RID: 132899 RVA: 0x00ACF8FC File Offset: 0x00ACDAFC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int PostUpdateView(IntPtr l)
	{
		int result;
		try
		{
			PreloadUITask preloadUITask = (PreloadUITask)LuaObject.checkSelf(l);
			preloadUITask.m_luaExportHelper.PostUpdateView();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06020724 RID: 132900 RVA: 0x00ACF950 File Offset: 0x00ACDB50
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int StartLoginUITask(IntPtr l)
	{
		int result;
		try
		{
			PreloadUITask preloadUITask = (PreloadUITask)LuaObject.checkSelf(l);
			preloadUITask.m_luaExportHelper.StartLoginUITask();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06020725 RID: 132901 RVA: 0x00ACF9A4 File Offset: 0x00ACDBA4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_OnStart(IntPtr l)
	{
		int result;
		try
		{
			PreloadUITask preloadUITask = (PreloadUITask)LuaObject.checkSelf(l);
			UIIntent intent;
			LuaObject.checkType<UIIntent>(l, 2, out intent);
			bool b = preloadUITask.m_luaExportHelper.__callBase_OnStart(intent);
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

	// Token: 0x06020726 RID: 132902 RVA: 0x00ACFA0C File Offset: 0x00ACDC0C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_OnStop(IntPtr l)
	{
		int result;
		try
		{
			PreloadUITask preloadUITask = (PreloadUITask)LuaObject.checkSelf(l);
			preloadUITask.m_luaExportHelper.__callBase_OnStop();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06020727 RID: 132903 RVA: 0x00ACFA60 File Offset: 0x00ACDC60
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_OnPause(IntPtr l)
	{
		int result;
		try
		{
			PreloadUITask preloadUITask = (PreloadUITask)LuaObject.checkSelf(l);
			preloadUITask.m_luaExportHelper.__callBase_OnPause();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06020728 RID: 132904 RVA: 0x00ACFAB4 File Offset: 0x00ACDCB4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_OnResume(IntPtr l)
	{
		int result;
		try
		{
			PreloadUITask preloadUITask = (PreloadUITask)LuaObject.checkSelf(l);
			UIIntent intent;
			LuaObject.checkType<UIIntent>(l, 2, out intent);
			bool b = preloadUITask.m_luaExportHelper.__callBase_OnResume(intent);
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

	// Token: 0x06020729 RID: 132905 RVA: 0x00ACFB1C File Offset: 0x00ACDD1C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_OnNewIntent(IntPtr l)
	{
		int result;
		try
		{
			PreloadUITask preloadUITask = (PreloadUITask)LuaObject.checkSelf(l);
			UIIntent intent;
			LuaObject.checkType<UIIntent>(l, 2, out intent);
			bool b = preloadUITask.m_luaExportHelper.__callBase_OnNewIntent(intent);
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

	// Token: 0x0602072A RID: 132906 RVA: 0x00ACFB84 File Offset: 0x00ACDD84
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_EnableUIInput(IntPtr l)
	{
		int result;
		try
		{
			PreloadUITask preloadUITask = (PreloadUITask)LuaObject.checkSelf(l);
			bool isEnable;
			LuaObject.checkType(l, 2, out isEnable);
			bool? isGlobalEnable;
			LuaObject.checkNullable<bool>(l, 3, out isGlobalEnable);
			preloadUITask.m_luaExportHelper.__callBase_EnableUIInput(isEnable, isGlobalEnable);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0602072B RID: 132907 RVA: 0x00ACFBF0 File Offset: 0x00ACDDF0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_IsNeedLoadDynamicRes(IntPtr l)
	{
		int result;
		try
		{
			PreloadUITask preloadUITask = (PreloadUITask)LuaObject.checkSelf(l);
			bool b = preloadUITask.m_luaExportHelper.__callBase_IsNeedLoadDynamicRes();
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

	// Token: 0x0602072C RID: 132908 RVA: 0x00ACFC4C File Offset: 0x00ACDE4C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_CollectAllDynamicResForLoad(IntPtr l)
	{
		int result;
		try
		{
			PreloadUITask preloadUITask = (PreloadUITask)LuaObject.checkSelf(l);
			List<string> o = preloadUITask.m_luaExportHelper.__callBase_CollectAllDynamicResForLoad();
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

	// Token: 0x0602072D RID: 132909 RVA: 0x00ACFCA8 File Offset: 0x00ACDEA8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_RegisterPlayerContextEvents(IntPtr l)
	{
		int result;
		try
		{
			PreloadUITask preloadUITask = (PreloadUITask)LuaObject.checkSelf(l);
			preloadUITask.m_luaExportHelper.__callBase_RegisterPlayerContextEvents();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0602072E RID: 132910 RVA: 0x00ACFCFC File Offset: 0x00ACDEFC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_UnregisterPlayerContextEvents(IntPtr l)
	{
		int result;
		try
		{
			PreloadUITask preloadUITask = (PreloadUITask)LuaObject.checkSelf(l);
			preloadUITask.m_luaExportHelper.__callBase_UnregisterPlayerContextEvents();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0602072F RID: 132911 RVA: 0x00ACFD50 File Offset: 0x00ACDF50
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_PostUpdateView(IntPtr l)
	{
		int result;
		try
		{
			PreloadUITask preloadUITask = (PreloadUITask)LuaObject.checkSelf(l);
			preloadUITask.m_luaExportHelper.__callBase_PostUpdateView();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06020730 RID: 132912 RVA: 0x00ACFDA4 File Offset: 0x00ACDFA4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_CollectPreloadResourceList(IntPtr l)
	{
		int result;
		try
		{
			PreloadUITask preloadUITask = (PreloadUITask)LuaObject.checkSelf(l);
			preloadUITask.m_luaExportHelper.__callBase_CollectPreloadResourceList();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06020731 RID: 132913 RVA: 0x00ACFDF8 File Offset: 0x00ACDFF8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_ClearAssetList(IntPtr l)
	{
		int result;
		try
		{
			PreloadUITask preloadUITask = (PreloadUITask)LuaObject.checkSelf(l);
			preloadUITask.m_luaExportHelper.__callBase_ClearAssetList();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06020732 RID: 132914 RVA: 0x00ACFE4C File Offset: 0x00ACE04C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_CollectAsset(IntPtr l)
	{
		int result;
		try
		{
			PreloadUITask preloadUITask = (PreloadUITask)LuaObject.checkSelf(l);
			string assetName;
			LuaObject.checkType(l, 2, out assetName);
			preloadUITask.m_luaExportHelper.__callBase_CollectAsset(assetName);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06020733 RID: 132915 RVA: 0x00ACFEA8 File Offset: 0x00ACE0A8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_CollectSpriteAsset(IntPtr l)
	{
		int result;
		try
		{
			PreloadUITask preloadUITask = (PreloadUITask)LuaObject.checkSelf(l);
			string assetName;
			LuaObject.checkType(l, 2, out assetName);
			preloadUITask.m_luaExportHelper.__callBase_CollectSpriteAsset(assetName);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06020734 RID: 132916 RVA: 0x00ACFF04 File Offset: 0x00ACE104
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_CollectFxAsset(IntPtr l)
	{
		int result;
		try
		{
			PreloadUITask preloadUITask = (PreloadUITask)LuaObject.checkSelf(l);
			string assetName;
			LuaObject.checkType(l, 2, out assetName);
			preloadUITask.m_luaExportHelper.__callBase_CollectFxAsset(assetName);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06020735 RID: 132917 RVA: 0x00ACFF60 File Offset: 0x00ACE160
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_StartLoadCustomAssets(IntPtr l)
	{
		int result;
		try
		{
			PreloadUITask preloadUITask = (PreloadUITask)LuaObject.checkSelf(l);
			Action onLoadCompleted;
			LuaObject.checkDelegate<Action>(l, 2, out onLoadCompleted);
			preloadUITask.m_luaExportHelper.__callBase_StartLoadCustomAssets(onLoadCompleted);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06020736 RID: 132918 RVA: 0x00ACFFBC File Offset: 0x00ACE1BC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_IsLoadingCustomAssets(IntPtr l)
	{
		int result;
		try
		{
			PreloadUITask preloadUITask = (PreloadUITask)LuaObject.checkSelf(l);
			bool b = preloadUITask.m_luaExportHelper.__callBase_IsLoadingCustomAssets();
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

	// Token: 0x06020737 RID: 132919 RVA: 0x00AD0018 File Offset: 0x00ACE218
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_IsPipeLineRunning(IntPtr l)
	{
		int result;
		try
		{
			PreloadUITask preloadUITask = (PreloadUITask)LuaObject.checkSelf(l);
			bool b = preloadUITask.m_luaExportHelper.__callBase_IsPipeLineRunning();
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

	// Token: 0x06020738 RID: 132920 RVA: 0x00AD0074 File Offset: 0x00ACE274
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_IsOpeningUI(IntPtr l)
	{
		int result;
		try
		{
			PreloadUITask preloadUITask = (PreloadUITask)LuaObject.checkSelf(l);
			bool b = preloadUITask.m_luaExportHelper.__callBase_IsOpeningUI();
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

	// Token: 0x06020739 RID: 132921 RVA: 0x00AD00D0 File Offset: 0x00ACE2D0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_ReturnPrevUITask(IntPtr l)
	{
		int result;
		try
		{
			PreloadUITask preloadUITask = (PreloadUITask)LuaObject.checkSelf(l);
			UITaskBase o = preloadUITask.m_luaExportHelper.__callBase_ReturnPrevUITask();
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

	// Token: 0x0602073A RID: 132922 RVA: 0x00AD012C File Offset: 0x00ACE32C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_ClearUnusedDynamicResourceCache(IntPtr l)
	{
		int result;
		try
		{
			PreloadUITask preloadUITask = (PreloadUITask)LuaObject.checkSelf(l);
			preloadUITask.m_luaExportHelper.__callBase_ClearUnusedDynamicResourceCache();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0602073B RID: 132923 RVA: 0x00AD0180 File Offset: 0x00ACE380
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_OnMemoryWarning(IntPtr l)
	{
		int result;
		try
		{
			PreloadUITask preloadUITask = (PreloadUITask)LuaObject.checkSelf(l);
			preloadUITask.m_luaExportHelper.__callBase_OnMemoryWarning();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0602073C RID: 132924 RVA: 0x00AD01D4 File Offset: 0x00ACE3D4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_layerDescArray(IntPtr l)
	{
		int result;
		try
		{
			PreloadUITask preloadUITask = (PreloadUITask)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, preloadUITask.m_luaExportHelper.m_layerDescArray);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0602073D RID: 132925 RVA: 0x00AD022C File Offset: 0x00ACE42C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_layerDescArray(IntPtr l)
	{
		int result;
		try
		{
			PreloadUITask preloadUITask = (PreloadUITask)LuaObject.checkSelf(l);
			UITaskBase.LayerDesc[] layerDescArray;
			LuaObject.checkArray<UITaskBase.LayerDesc>(l, 2, out layerDescArray);
			preloadUITask.m_luaExportHelper.m_layerDescArray = layerDescArray;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0602073E RID: 132926 RVA: 0x00AD0288 File Offset: 0x00ACE488
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_uiCtrlDescArray(IntPtr l)
	{
		int result;
		try
		{
			PreloadUITask preloadUITask = (PreloadUITask)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, preloadUITask.m_luaExportHelper.m_uiCtrlDescArray);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0602073F RID: 132927 RVA: 0x00AD02E0 File Offset: 0x00ACE4E0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_uiCtrlDescArray(IntPtr l)
	{
		int result;
		try
		{
			PreloadUITask preloadUITask = (PreloadUITask)LuaObject.checkSelf(l);
			UITaskBase.UIControllerDesc[] uiCtrlDescArray;
			LuaObject.checkArray<UITaskBase.UIControllerDesc>(l, 2, out uiCtrlDescArray);
			preloadUITask.m_luaExportHelper.m_uiCtrlDescArray = uiCtrlDescArray;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06020740 RID: 132928 RVA: 0x00AD033C File Offset: 0x00ACE53C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_preloadUIController(IntPtr l)
	{
		int result;
		try
		{
			PreloadUITask preloadUITask = (PreloadUITask)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, preloadUITask.m_luaExportHelper.m_preloadUIController);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06020741 RID: 132929 RVA: 0x00AD0394 File Offset: 0x00ACE594
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_preloadUIController(IntPtr l)
	{
		int result;
		try
		{
			PreloadUITask preloadUITask = (PreloadUITask)LuaObject.checkSelf(l);
			PreloadUIController preloadUIController;
			LuaObject.checkType<PreloadUIController>(l, 2, out preloadUIController);
			preloadUITask.m_luaExportHelper.m_preloadUIController = preloadUIController;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06020742 RID: 132930 RVA: 0x00AD03F0 File Offset: 0x00ACE5F0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_viewState(IntPtr l)
	{
		int result;
		try
		{
			PreloadUITask preloadUITask = (PreloadUITask)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushEnum(l, (int)preloadUITask.m_luaExportHelper.m_viewState);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06020743 RID: 132931 RVA: 0x00AD0448 File Offset: 0x00ACE648
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_viewState(IntPtr l)
	{
		int result;
		try
		{
			PreloadUITask preloadUITask = (PreloadUITask)LuaObject.checkSelf(l);
			PreloadUITask.ViewState viewState;
			LuaObject.checkEnum<PreloadUITask.ViewState>(l, 2, out viewState);
			preloadUITask.m_luaExportHelper.m_viewState = viewState;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06020744 RID: 132932 RVA: 0x00AD04A4 File Offset: 0x00ACE6A4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_LayerDescArray(IntPtr l)
	{
		int result;
		try
		{
			PreloadUITask preloadUITask = (PreloadUITask)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, preloadUITask.m_luaExportHelper.LayerDescArray);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06020745 RID: 132933 RVA: 0x00AD04FC File Offset: 0x00ACE6FC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_UICtrlDescArray(IntPtr l)
	{
		int result;
		try
		{
			PreloadUITask preloadUITask = (PreloadUITask)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, preloadUITask.m_luaExportHelper.UICtrlDescArray);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06020746 RID: 132934 RVA: 0x00AD0554 File Offset: 0x00ACE754
	[Preserve]
	public static void reg(IntPtr l)
	{
		LuaObject.getTypeTable(l, "BlackJack.ProjectL.UI.PreloadUITask");
		if (Lua_BlackJack_ProjectL_UI_PreloadUITask.<>f__mg$cache0 == null)
		{
			Lua_BlackJack_ProjectL_UI_PreloadUITask.<>f__mg$cache0 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_PreloadUITask.OnNewIntent);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_PreloadUITask.<>f__mg$cache0);
		if (Lua_BlackJack_ProjectL_UI_PreloadUITask.<>f__mg$cache1 == null)
		{
			Lua_BlackJack_ProjectL_UI_PreloadUITask.<>f__mg$cache1 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_PreloadUITask.OnLoadDynamicResCompleted);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_PreloadUITask.<>f__mg$cache1);
		if (Lua_BlackJack_ProjectL_UI_PreloadUITask.<>f__mg$cache2 == null)
		{
			Lua_BlackJack_ProjectL_UI_PreloadUITask.<>f__mg$cache2 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_PreloadUITask.IsNeedLoadDynamicRes);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_PreloadUITask.<>f__mg$cache2);
		if (Lua_BlackJack_ProjectL_UI_PreloadUITask.<>f__mg$cache3 == null)
		{
			Lua_BlackJack_ProjectL_UI_PreloadUITask.<>f__mg$cache3 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_PreloadUITask.PostOnLoadAllResCompleted);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_PreloadUITask.<>f__mg$cache3);
		if (Lua_BlackJack_ProjectL_UI_PreloadUITask.<>f__mg$cache4 == null)
		{
			Lua_BlackJack_ProjectL_UI_PreloadUITask.<>f__mg$cache4 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_PreloadUITask.InitAllUIControllers);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_PreloadUITask.<>f__mg$cache4);
		if (Lua_BlackJack_ProjectL_UI_PreloadUITask.<>f__mg$cache5 == null)
		{
			Lua_BlackJack_ProjectL_UI_PreloadUITask.<>f__mg$cache5 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_PreloadUITask.ClearAllContextAndRes);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_PreloadUITask.<>f__mg$cache5);
		if (Lua_BlackJack_ProjectL_UI_PreloadUITask.<>f__mg$cache6 == null)
		{
			Lua_BlackJack_ProjectL_UI_PreloadUITask.<>f__mg$cache6 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_PreloadUITask.OnStart);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_PreloadUITask.<>f__mg$cache6);
		if (Lua_BlackJack_ProjectL_UI_PreloadUITask.<>f__mg$cache7 == null)
		{
			Lua_BlackJack_ProjectL_UI_PreloadUITask.<>f__mg$cache7 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_PreloadUITask.OnResume);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_PreloadUITask.<>f__mg$cache7);
		if (Lua_BlackJack_ProjectL_UI_PreloadUITask.<>f__mg$cache8 == null)
		{
			Lua_BlackJack_ProjectL_UI_PreloadUITask.<>f__mg$cache8 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_PreloadUITask.OnStop);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_PreloadUITask.<>f__mg$cache8);
		if (Lua_BlackJack_ProjectL_UI_PreloadUITask.<>f__mg$cache9 == null)
		{
			Lua_BlackJack_ProjectL_UI_PreloadUITask.<>f__mg$cache9 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_PreloadUITask.OnTick);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_PreloadUITask.<>f__mg$cache9);
		if (Lua_BlackJack_ProjectL_UI_PreloadUITask.<>f__mg$cacheA == null)
		{
			Lua_BlackJack_ProjectL_UI_PreloadUITask.<>f__mg$cacheA = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_PreloadUITask.UpdateView);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_PreloadUITask.<>f__mg$cacheA);
		if (Lua_BlackJack_ProjectL_UI_PreloadUITask.<>f__mg$cacheB == null)
		{
			Lua_BlackJack_ProjectL_UI_PreloadUITask.<>f__mg$cacheB = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_PreloadUITask.PostUpdateView);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_PreloadUITask.<>f__mg$cacheB);
		if (Lua_BlackJack_ProjectL_UI_PreloadUITask.<>f__mg$cacheC == null)
		{
			Lua_BlackJack_ProjectL_UI_PreloadUITask.<>f__mg$cacheC = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_PreloadUITask.StartLoginUITask);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_PreloadUITask.<>f__mg$cacheC);
		if (Lua_BlackJack_ProjectL_UI_PreloadUITask.<>f__mg$cacheD == null)
		{
			Lua_BlackJack_ProjectL_UI_PreloadUITask.<>f__mg$cacheD = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_PreloadUITask.__callBase_OnStart);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_PreloadUITask.<>f__mg$cacheD);
		if (Lua_BlackJack_ProjectL_UI_PreloadUITask.<>f__mg$cacheE == null)
		{
			Lua_BlackJack_ProjectL_UI_PreloadUITask.<>f__mg$cacheE = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_PreloadUITask.__callBase_OnStop);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_PreloadUITask.<>f__mg$cacheE);
		if (Lua_BlackJack_ProjectL_UI_PreloadUITask.<>f__mg$cacheF == null)
		{
			Lua_BlackJack_ProjectL_UI_PreloadUITask.<>f__mg$cacheF = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_PreloadUITask.__callBase_OnPause);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_PreloadUITask.<>f__mg$cacheF);
		if (Lua_BlackJack_ProjectL_UI_PreloadUITask.<>f__mg$cache10 == null)
		{
			Lua_BlackJack_ProjectL_UI_PreloadUITask.<>f__mg$cache10 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_PreloadUITask.__callBase_OnResume);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_PreloadUITask.<>f__mg$cache10);
		if (Lua_BlackJack_ProjectL_UI_PreloadUITask.<>f__mg$cache11 == null)
		{
			Lua_BlackJack_ProjectL_UI_PreloadUITask.<>f__mg$cache11 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_PreloadUITask.__callBase_OnNewIntent);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_PreloadUITask.<>f__mg$cache11);
		if (Lua_BlackJack_ProjectL_UI_PreloadUITask.<>f__mg$cache12 == null)
		{
			Lua_BlackJack_ProjectL_UI_PreloadUITask.<>f__mg$cache12 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_PreloadUITask.__callBase_EnableUIInput);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_PreloadUITask.<>f__mg$cache12);
		if (Lua_BlackJack_ProjectL_UI_PreloadUITask.<>f__mg$cache13 == null)
		{
			Lua_BlackJack_ProjectL_UI_PreloadUITask.<>f__mg$cache13 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_PreloadUITask.__callBase_IsNeedLoadDynamicRes);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_PreloadUITask.<>f__mg$cache13);
		if (Lua_BlackJack_ProjectL_UI_PreloadUITask.<>f__mg$cache14 == null)
		{
			Lua_BlackJack_ProjectL_UI_PreloadUITask.<>f__mg$cache14 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_PreloadUITask.__callBase_CollectAllDynamicResForLoad);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_PreloadUITask.<>f__mg$cache14);
		if (Lua_BlackJack_ProjectL_UI_PreloadUITask.<>f__mg$cache15 == null)
		{
			Lua_BlackJack_ProjectL_UI_PreloadUITask.<>f__mg$cache15 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_PreloadUITask.__callBase_RegisterPlayerContextEvents);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_PreloadUITask.<>f__mg$cache15);
		if (Lua_BlackJack_ProjectL_UI_PreloadUITask.<>f__mg$cache16 == null)
		{
			Lua_BlackJack_ProjectL_UI_PreloadUITask.<>f__mg$cache16 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_PreloadUITask.__callBase_UnregisterPlayerContextEvents);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_PreloadUITask.<>f__mg$cache16);
		if (Lua_BlackJack_ProjectL_UI_PreloadUITask.<>f__mg$cache17 == null)
		{
			Lua_BlackJack_ProjectL_UI_PreloadUITask.<>f__mg$cache17 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_PreloadUITask.__callBase_PostUpdateView);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_PreloadUITask.<>f__mg$cache17);
		if (Lua_BlackJack_ProjectL_UI_PreloadUITask.<>f__mg$cache18 == null)
		{
			Lua_BlackJack_ProjectL_UI_PreloadUITask.<>f__mg$cache18 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_PreloadUITask.__callBase_CollectPreloadResourceList);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_PreloadUITask.<>f__mg$cache18);
		if (Lua_BlackJack_ProjectL_UI_PreloadUITask.<>f__mg$cache19 == null)
		{
			Lua_BlackJack_ProjectL_UI_PreloadUITask.<>f__mg$cache19 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_PreloadUITask.__callBase_ClearAssetList);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_PreloadUITask.<>f__mg$cache19);
		if (Lua_BlackJack_ProjectL_UI_PreloadUITask.<>f__mg$cache1A == null)
		{
			Lua_BlackJack_ProjectL_UI_PreloadUITask.<>f__mg$cache1A = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_PreloadUITask.__callBase_CollectAsset);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_PreloadUITask.<>f__mg$cache1A);
		if (Lua_BlackJack_ProjectL_UI_PreloadUITask.<>f__mg$cache1B == null)
		{
			Lua_BlackJack_ProjectL_UI_PreloadUITask.<>f__mg$cache1B = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_PreloadUITask.__callBase_CollectSpriteAsset);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_PreloadUITask.<>f__mg$cache1B);
		if (Lua_BlackJack_ProjectL_UI_PreloadUITask.<>f__mg$cache1C == null)
		{
			Lua_BlackJack_ProjectL_UI_PreloadUITask.<>f__mg$cache1C = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_PreloadUITask.__callBase_CollectFxAsset);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_PreloadUITask.<>f__mg$cache1C);
		if (Lua_BlackJack_ProjectL_UI_PreloadUITask.<>f__mg$cache1D == null)
		{
			Lua_BlackJack_ProjectL_UI_PreloadUITask.<>f__mg$cache1D = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_PreloadUITask.__callBase_StartLoadCustomAssets);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_PreloadUITask.<>f__mg$cache1D);
		if (Lua_BlackJack_ProjectL_UI_PreloadUITask.<>f__mg$cache1E == null)
		{
			Lua_BlackJack_ProjectL_UI_PreloadUITask.<>f__mg$cache1E = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_PreloadUITask.__callBase_IsLoadingCustomAssets);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_PreloadUITask.<>f__mg$cache1E);
		if (Lua_BlackJack_ProjectL_UI_PreloadUITask.<>f__mg$cache1F == null)
		{
			Lua_BlackJack_ProjectL_UI_PreloadUITask.<>f__mg$cache1F = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_PreloadUITask.__callBase_IsPipeLineRunning);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_PreloadUITask.<>f__mg$cache1F);
		if (Lua_BlackJack_ProjectL_UI_PreloadUITask.<>f__mg$cache20 == null)
		{
			Lua_BlackJack_ProjectL_UI_PreloadUITask.<>f__mg$cache20 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_PreloadUITask.__callBase_IsOpeningUI);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_PreloadUITask.<>f__mg$cache20);
		if (Lua_BlackJack_ProjectL_UI_PreloadUITask.<>f__mg$cache21 == null)
		{
			Lua_BlackJack_ProjectL_UI_PreloadUITask.<>f__mg$cache21 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_PreloadUITask.__callBase_ReturnPrevUITask);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_PreloadUITask.<>f__mg$cache21);
		if (Lua_BlackJack_ProjectL_UI_PreloadUITask.<>f__mg$cache22 == null)
		{
			Lua_BlackJack_ProjectL_UI_PreloadUITask.<>f__mg$cache22 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_PreloadUITask.__callBase_ClearUnusedDynamicResourceCache);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_PreloadUITask.<>f__mg$cache22);
		if (Lua_BlackJack_ProjectL_UI_PreloadUITask.<>f__mg$cache23 == null)
		{
			Lua_BlackJack_ProjectL_UI_PreloadUITask.<>f__mg$cache23 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_PreloadUITask.__callBase_OnMemoryWarning);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_PreloadUITask.<>f__mg$cache23);
		string name = "m_layerDescArray";
		if (Lua_BlackJack_ProjectL_UI_PreloadUITask.<>f__mg$cache24 == null)
		{
			Lua_BlackJack_ProjectL_UI_PreloadUITask.<>f__mg$cache24 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_PreloadUITask.get_m_layerDescArray);
		}
		LuaCSFunction get = Lua_BlackJack_ProjectL_UI_PreloadUITask.<>f__mg$cache24;
		if (Lua_BlackJack_ProjectL_UI_PreloadUITask.<>f__mg$cache25 == null)
		{
			Lua_BlackJack_ProjectL_UI_PreloadUITask.<>f__mg$cache25 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_PreloadUITask.set_m_layerDescArray);
		}
		LuaObject.addMember(l, name, get, Lua_BlackJack_ProjectL_UI_PreloadUITask.<>f__mg$cache25, true);
		string name2 = "m_uiCtrlDescArray";
		if (Lua_BlackJack_ProjectL_UI_PreloadUITask.<>f__mg$cache26 == null)
		{
			Lua_BlackJack_ProjectL_UI_PreloadUITask.<>f__mg$cache26 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_PreloadUITask.get_m_uiCtrlDescArray);
		}
		LuaCSFunction get2 = Lua_BlackJack_ProjectL_UI_PreloadUITask.<>f__mg$cache26;
		if (Lua_BlackJack_ProjectL_UI_PreloadUITask.<>f__mg$cache27 == null)
		{
			Lua_BlackJack_ProjectL_UI_PreloadUITask.<>f__mg$cache27 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_PreloadUITask.set_m_uiCtrlDescArray);
		}
		LuaObject.addMember(l, name2, get2, Lua_BlackJack_ProjectL_UI_PreloadUITask.<>f__mg$cache27, true);
		string name3 = "m_preloadUIController";
		if (Lua_BlackJack_ProjectL_UI_PreloadUITask.<>f__mg$cache28 == null)
		{
			Lua_BlackJack_ProjectL_UI_PreloadUITask.<>f__mg$cache28 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_PreloadUITask.get_m_preloadUIController);
		}
		LuaCSFunction get3 = Lua_BlackJack_ProjectL_UI_PreloadUITask.<>f__mg$cache28;
		if (Lua_BlackJack_ProjectL_UI_PreloadUITask.<>f__mg$cache29 == null)
		{
			Lua_BlackJack_ProjectL_UI_PreloadUITask.<>f__mg$cache29 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_PreloadUITask.set_m_preloadUIController);
		}
		LuaObject.addMember(l, name3, get3, Lua_BlackJack_ProjectL_UI_PreloadUITask.<>f__mg$cache29, true);
		string name4 = "m_viewState";
		if (Lua_BlackJack_ProjectL_UI_PreloadUITask.<>f__mg$cache2A == null)
		{
			Lua_BlackJack_ProjectL_UI_PreloadUITask.<>f__mg$cache2A = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_PreloadUITask.get_m_viewState);
		}
		LuaCSFunction get4 = Lua_BlackJack_ProjectL_UI_PreloadUITask.<>f__mg$cache2A;
		if (Lua_BlackJack_ProjectL_UI_PreloadUITask.<>f__mg$cache2B == null)
		{
			Lua_BlackJack_ProjectL_UI_PreloadUITask.<>f__mg$cache2B = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_PreloadUITask.set_m_viewState);
		}
		LuaObject.addMember(l, name4, get4, Lua_BlackJack_ProjectL_UI_PreloadUITask.<>f__mg$cache2B, true);
		string name5 = "LayerDescArray";
		if (Lua_BlackJack_ProjectL_UI_PreloadUITask.<>f__mg$cache2C == null)
		{
			Lua_BlackJack_ProjectL_UI_PreloadUITask.<>f__mg$cache2C = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_PreloadUITask.get_LayerDescArray);
		}
		LuaObject.addMember(l, name5, Lua_BlackJack_ProjectL_UI_PreloadUITask.<>f__mg$cache2C, null, true);
		string name6 = "UICtrlDescArray";
		if (Lua_BlackJack_ProjectL_UI_PreloadUITask.<>f__mg$cache2D == null)
		{
			Lua_BlackJack_ProjectL_UI_PreloadUITask.<>f__mg$cache2D = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_PreloadUITask.get_UICtrlDescArray);
		}
		LuaObject.addMember(l, name6, Lua_BlackJack_ProjectL_UI_PreloadUITask.<>f__mg$cache2D, null, true);
		if (Lua_BlackJack_ProjectL_UI_PreloadUITask.<>f__mg$cache2E == null)
		{
			Lua_BlackJack_ProjectL_UI_PreloadUITask.<>f__mg$cache2E = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_PreloadUITask.constructor);
		}
		LuaObject.createTypeMetatable(l, Lua_BlackJack_ProjectL_UI_PreloadUITask.<>f__mg$cache2E, typeof(PreloadUITask), typeof(UITask));
	}

	// Token: 0x04016683 RID: 91779
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache0;

	// Token: 0x04016684 RID: 91780
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1;

	// Token: 0x04016685 RID: 91781
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2;

	// Token: 0x04016686 RID: 91782
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3;

	// Token: 0x04016687 RID: 91783
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache4;

	// Token: 0x04016688 RID: 91784
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache5;

	// Token: 0x04016689 RID: 91785
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache6;

	// Token: 0x0401668A RID: 91786
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache7;

	// Token: 0x0401668B RID: 91787
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache8;

	// Token: 0x0401668C RID: 91788
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache9;

	// Token: 0x0401668D RID: 91789
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheA;

	// Token: 0x0401668E RID: 91790
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheB;

	// Token: 0x0401668F RID: 91791
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheC;

	// Token: 0x04016690 RID: 91792
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheD;

	// Token: 0x04016691 RID: 91793
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheE;

	// Token: 0x04016692 RID: 91794
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheF;

	// Token: 0x04016693 RID: 91795
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache10;

	// Token: 0x04016694 RID: 91796
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache11;

	// Token: 0x04016695 RID: 91797
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache12;

	// Token: 0x04016696 RID: 91798
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache13;

	// Token: 0x04016697 RID: 91799
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache14;

	// Token: 0x04016698 RID: 91800
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache15;

	// Token: 0x04016699 RID: 91801
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache16;

	// Token: 0x0401669A RID: 91802
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache17;

	// Token: 0x0401669B RID: 91803
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache18;

	// Token: 0x0401669C RID: 91804
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache19;

	// Token: 0x0401669D RID: 91805
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1A;

	// Token: 0x0401669E RID: 91806
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1B;

	// Token: 0x0401669F RID: 91807
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1C;

	// Token: 0x040166A0 RID: 91808
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1D;

	// Token: 0x040166A1 RID: 91809
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1E;

	// Token: 0x040166A2 RID: 91810
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1F;

	// Token: 0x040166A3 RID: 91811
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache20;

	// Token: 0x040166A4 RID: 91812
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache21;

	// Token: 0x040166A5 RID: 91813
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache22;

	// Token: 0x040166A6 RID: 91814
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache23;

	// Token: 0x040166A7 RID: 91815
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache24;

	// Token: 0x040166A8 RID: 91816
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache25;

	// Token: 0x040166A9 RID: 91817
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache26;

	// Token: 0x040166AA RID: 91818
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache27;

	// Token: 0x040166AB RID: 91819
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache28;

	// Token: 0x040166AC RID: 91820
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache29;

	// Token: 0x040166AD RID: 91821
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2A;

	// Token: 0x040166AE RID: 91822
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2B;

	// Token: 0x040166AF RID: 91823
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2C;

	// Token: 0x040166B0 RID: 91824
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2D;

	// Token: 0x040166B1 RID: 91825
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2E;
}
