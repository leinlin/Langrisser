using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using BlackJack.BJFramework.Runtime.UI;
using BlackJack.ConfigData;
using BlackJack.ProjectL.UI;
using SLua;
using UnityEngine.Scripting;

// Token: 0x020014DB RID: 5339
[Preserve]
public class Lua_BlackJack_ProjectL_UI_HeroPhantomUITask : LuaObject
{
	// Token: 0x0601F6AE RID: 128686 RVA: 0x00A4CD14 File Offset: 0x00A4AF14
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int constructor(IntPtr l)
	{
		int result;
		try
		{
			string name;
			LuaObject.checkType(l, 2, out name);
			HeroPhantomUITask o = new HeroPhantomUITask(name);
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

	// Token: 0x0601F6AF RID: 128687 RVA: 0x00A4CD68 File Offset: 0x00A4AF68
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int OnStart(IntPtr l)
	{
		int result;
		try
		{
			HeroPhantomUITask heroPhantomUITask = (HeroPhantomUITask)LuaObject.checkSelf(l);
			UIIntent intent;
			LuaObject.checkType<UIIntent>(l, 2, out intent);
			bool b = heroPhantomUITask.m_luaExportHelper.OnStart(intent);
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

	// Token: 0x0601F6B0 RID: 128688 RVA: 0x00A4CDD0 File Offset: 0x00A4AFD0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int OnResume(IntPtr l)
	{
		int result;
		try
		{
			HeroPhantomUITask heroPhantomUITask = (HeroPhantomUITask)LuaObject.checkSelf(l);
			UIIntent intent;
			LuaObject.checkType<UIIntent>(l, 2, out intent);
			bool b = heroPhantomUITask.m_luaExportHelper.OnResume(intent);
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

	// Token: 0x0601F6B1 RID: 128689 RVA: 0x00A4CE38 File Offset: 0x00A4B038
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int InitDataFromUIIntent(IntPtr l)
	{
		int result;
		try
		{
			HeroPhantomUITask heroPhantomUITask = (HeroPhantomUITask)LuaObject.checkSelf(l);
			UIIntent intent;
			LuaObject.checkType<UIIntent>(l, 2, out intent);
			heroPhantomUITask.m_luaExportHelper.InitDataFromUIIntent(intent);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601F6B2 RID: 128690 RVA: 0x00A4CE94 File Offset: 0x00A4B094
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int IsNeedLoadDynamicRes(IntPtr l)
	{
		int result;
		try
		{
			HeroPhantomUITask heroPhantomUITask = (HeroPhantomUITask)LuaObject.checkSelf(l);
			bool b = heroPhantomUITask.m_luaExportHelper.IsNeedLoadDynamicRes();
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

	// Token: 0x0601F6B3 RID: 128691 RVA: 0x00A4CEF0 File Offset: 0x00A4B0F0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int InitAllUIControllers(IntPtr l)
	{
		int result;
		try
		{
			HeroPhantomUITask heroPhantomUITask = (HeroPhantomUITask)LuaObject.checkSelf(l);
			heroPhantomUITask.m_luaExportHelper.InitAllUIControllers();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601F6B4 RID: 128692 RVA: 0x00A4CF44 File Offset: 0x00A4B144
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int ClearAllContextAndRes(IntPtr l)
	{
		int result;
		try
		{
			HeroPhantomUITask heroPhantomUITask = (HeroPhantomUITask)LuaObject.checkSelf(l);
			heroPhantomUITask.m_luaExportHelper.ClearAllContextAndRes();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601F6B5 RID: 128693 RVA: 0x00A4CF98 File Offset: 0x00A4B198
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int InitHeroPhantomUIController(IntPtr l)
	{
		int result;
		try
		{
			HeroPhantomUITask heroPhantomUITask = (HeroPhantomUITask)LuaObject.checkSelf(l);
			heroPhantomUITask.m_luaExportHelper.InitHeroPhantomUIController();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601F6B6 RID: 128694 RVA: 0x00A4CFEC File Offset: 0x00A4B1EC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int UninitHeroPhantomUIController(IntPtr l)
	{
		int result;
		try
		{
			HeroPhantomUITask heroPhantomUITask = (HeroPhantomUITask)LuaObject.checkSelf(l);
			heroPhantomUITask.m_luaExportHelper.UninitHeroPhantomUIController();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601F6B7 RID: 128695 RVA: 0x00A4D040 File Offset: 0x00A4B240
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int UpdateView(IntPtr l)
	{
		int result;
		try
		{
			HeroPhantomUITask heroPhantomUITask = (HeroPhantomUITask)LuaObject.checkSelf(l);
			heroPhantomUITask.m_luaExportHelper.UpdateView();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601F6B8 RID: 128696 RVA: 0x00A4D094 File Offset: 0x00A4B294
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int UpdateHeroPhantomLevels(IntPtr l)
	{
		int result;
		try
		{
			HeroPhantomUITask heroPhantomUITask = (HeroPhantomUITask)LuaObject.checkSelf(l);
			ConfigDataHeroPhantomInfo heroPhantomInfo;
			LuaObject.checkType<ConfigDataHeroPhantomInfo>(l, 2, out heroPhantomInfo);
			heroPhantomUITask.m_luaExportHelper.UpdateHeroPhantomLevels(heroPhantomInfo);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601F6B9 RID: 128697 RVA: 0x00A4D0F0 File Offset: 0x00A4B2F0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int HeroPhantomUIController_OnReturn(IntPtr l)
	{
		int result;
		try
		{
			HeroPhantomUITask heroPhantomUITask = (HeroPhantomUITask)LuaObject.checkSelf(l);
			heroPhantomUITask.m_luaExportHelper.HeroPhantomUIController_OnReturn();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601F6BA RID: 128698 RVA: 0x00A4D144 File Offset: 0x00A4B344
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int HeroPhantomUIController_OnHelp(IntPtr l)
	{
		int result;
		try
		{
			HeroPhantomUITask heroPhantomUITask = (HeroPhantomUITask)LuaObject.checkSelf(l);
			heroPhantomUITask.m_luaExportHelper.HeroPhantomUIController_OnHelp();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601F6BB RID: 128699 RVA: 0x00A4D198 File Offset: 0x00A4B398
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int HeroPhantomUIController_OnStartHeroTrainningLevel(IntPtr l)
	{
		int result;
		try
		{
			HeroPhantomUITask heroPhantomUITask = (HeroPhantomUITask)LuaObject.checkSelf(l);
			ConfigDataHeroPhantomLevelInfo levelInfo;
			LuaObject.checkType<ConfigDataHeroPhantomLevelInfo>(l, 2, out levelInfo);
			heroPhantomUITask.m_luaExportHelper.HeroPhantomUIController_OnStartHeroTrainningLevel(levelInfo);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601F6BC RID: 128700 RVA: 0x00A4D1F4 File Offset: 0x00A4B3F4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_OnStart(IntPtr l)
	{
		int result;
		try
		{
			HeroPhantomUITask heroPhantomUITask = (HeroPhantomUITask)LuaObject.checkSelf(l);
			UIIntent intent;
			LuaObject.checkType<UIIntent>(l, 2, out intent);
			bool b = heroPhantomUITask.m_luaExportHelper.__callBase_OnStart(intent);
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

	// Token: 0x0601F6BD RID: 128701 RVA: 0x00A4D25C File Offset: 0x00A4B45C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_OnStop(IntPtr l)
	{
		int result;
		try
		{
			HeroPhantomUITask heroPhantomUITask = (HeroPhantomUITask)LuaObject.checkSelf(l);
			heroPhantomUITask.m_luaExportHelper.__callBase_OnStop();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601F6BE RID: 128702 RVA: 0x00A4D2B0 File Offset: 0x00A4B4B0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_OnPause(IntPtr l)
	{
		int result;
		try
		{
			HeroPhantomUITask heroPhantomUITask = (HeroPhantomUITask)LuaObject.checkSelf(l);
			heroPhantomUITask.m_luaExportHelper.__callBase_OnPause();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601F6BF RID: 128703 RVA: 0x00A4D304 File Offset: 0x00A4B504
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_OnResume(IntPtr l)
	{
		int result;
		try
		{
			HeroPhantomUITask heroPhantomUITask = (HeroPhantomUITask)LuaObject.checkSelf(l);
			UIIntent intent;
			LuaObject.checkType<UIIntent>(l, 2, out intent);
			bool b = heroPhantomUITask.m_luaExportHelper.__callBase_OnResume(intent);
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

	// Token: 0x0601F6C0 RID: 128704 RVA: 0x00A4D36C File Offset: 0x00A4B56C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_OnNewIntent(IntPtr l)
	{
		int result;
		try
		{
			HeroPhantomUITask heroPhantomUITask = (HeroPhantomUITask)LuaObject.checkSelf(l);
			UIIntent intent;
			LuaObject.checkType<UIIntent>(l, 2, out intent);
			bool b = heroPhantomUITask.m_luaExportHelper.__callBase_OnNewIntent(intent);
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

	// Token: 0x0601F6C1 RID: 128705 RVA: 0x00A4D3D4 File Offset: 0x00A4B5D4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_EnableUIInput(IntPtr l)
	{
		int result;
		try
		{
			HeroPhantomUITask heroPhantomUITask = (HeroPhantomUITask)LuaObject.checkSelf(l);
			bool isEnable;
			LuaObject.checkType(l, 2, out isEnable);
			bool? isGlobalEnable;
			LuaObject.checkNullable<bool>(l, 3, out isGlobalEnable);
			heroPhantomUITask.m_luaExportHelper.__callBase_EnableUIInput(isEnable, isGlobalEnable);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601F6C2 RID: 128706 RVA: 0x00A4D440 File Offset: 0x00A4B640
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_IsNeedLoadDynamicRes(IntPtr l)
	{
		int result;
		try
		{
			HeroPhantomUITask heroPhantomUITask = (HeroPhantomUITask)LuaObject.checkSelf(l);
			bool b = heroPhantomUITask.m_luaExportHelper.__callBase_IsNeedLoadDynamicRes();
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

	// Token: 0x0601F6C3 RID: 128707 RVA: 0x00A4D49C File Offset: 0x00A4B69C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_CollectAllDynamicResForLoad(IntPtr l)
	{
		int result;
		try
		{
			HeroPhantomUITask heroPhantomUITask = (HeroPhantomUITask)LuaObject.checkSelf(l);
			List<string> o = heroPhantomUITask.m_luaExportHelper.__callBase_CollectAllDynamicResForLoad();
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

	// Token: 0x0601F6C4 RID: 128708 RVA: 0x00A4D4F8 File Offset: 0x00A4B6F8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_RegisterPlayerContextEvents(IntPtr l)
	{
		int result;
		try
		{
			HeroPhantomUITask heroPhantomUITask = (HeroPhantomUITask)LuaObject.checkSelf(l);
			heroPhantomUITask.m_luaExportHelper.__callBase_RegisterPlayerContextEvents();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601F6C5 RID: 128709 RVA: 0x00A4D54C File Offset: 0x00A4B74C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_UnregisterPlayerContextEvents(IntPtr l)
	{
		int result;
		try
		{
			HeroPhantomUITask heroPhantomUITask = (HeroPhantomUITask)LuaObject.checkSelf(l);
			heroPhantomUITask.m_luaExportHelper.__callBase_UnregisterPlayerContextEvents();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601F6C6 RID: 128710 RVA: 0x00A4D5A0 File Offset: 0x00A4B7A0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_PostUpdateView(IntPtr l)
	{
		int result;
		try
		{
			HeroPhantomUITask heroPhantomUITask = (HeroPhantomUITask)LuaObject.checkSelf(l);
			heroPhantomUITask.m_luaExportHelper.__callBase_PostUpdateView();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601F6C7 RID: 128711 RVA: 0x00A4D5F4 File Offset: 0x00A4B7F4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_CollectPreloadResourceList(IntPtr l)
	{
		int result;
		try
		{
			HeroPhantomUITask heroPhantomUITask = (HeroPhantomUITask)LuaObject.checkSelf(l);
			heroPhantomUITask.m_luaExportHelper.__callBase_CollectPreloadResourceList();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601F6C8 RID: 128712 RVA: 0x00A4D648 File Offset: 0x00A4B848
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_ClearAssetList(IntPtr l)
	{
		int result;
		try
		{
			HeroPhantomUITask heroPhantomUITask = (HeroPhantomUITask)LuaObject.checkSelf(l);
			heroPhantomUITask.m_luaExportHelper.__callBase_ClearAssetList();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601F6C9 RID: 128713 RVA: 0x00A4D69C File Offset: 0x00A4B89C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_CollectAsset(IntPtr l)
	{
		int result;
		try
		{
			HeroPhantomUITask heroPhantomUITask = (HeroPhantomUITask)LuaObject.checkSelf(l);
			string assetName;
			LuaObject.checkType(l, 2, out assetName);
			heroPhantomUITask.m_luaExportHelper.__callBase_CollectAsset(assetName);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601F6CA RID: 128714 RVA: 0x00A4D6F8 File Offset: 0x00A4B8F8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_CollectSpriteAsset(IntPtr l)
	{
		int result;
		try
		{
			HeroPhantomUITask heroPhantomUITask = (HeroPhantomUITask)LuaObject.checkSelf(l);
			string assetName;
			LuaObject.checkType(l, 2, out assetName);
			heroPhantomUITask.m_luaExportHelper.__callBase_CollectSpriteAsset(assetName);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601F6CB RID: 128715 RVA: 0x00A4D754 File Offset: 0x00A4B954
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_CollectFxAsset(IntPtr l)
	{
		int result;
		try
		{
			HeroPhantomUITask heroPhantomUITask = (HeroPhantomUITask)LuaObject.checkSelf(l);
			string assetName;
			LuaObject.checkType(l, 2, out assetName);
			heroPhantomUITask.m_luaExportHelper.__callBase_CollectFxAsset(assetName);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601F6CC RID: 128716 RVA: 0x00A4D7B0 File Offset: 0x00A4B9B0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_StartLoadCustomAssets(IntPtr l)
	{
		int result;
		try
		{
			HeroPhantomUITask heroPhantomUITask = (HeroPhantomUITask)LuaObject.checkSelf(l);
			Action onLoadCompleted;
			LuaObject.checkDelegate<Action>(l, 2, out onLoadCompleted);
			heroPhantomUITask.m_luaExportHelper.__callBase_StartLoadCustomAssets(onLoadCompleted);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601F6CD RID: 128717 RVA: 0x00A4D80C File Offset: 0x00A4BA0C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_IsLoadingCustomAssets(IntPtr l)
	{
		int result;
		try
		{
			HeroPhantomUITask heroPhantomUITask = (HeroPhantomUITask)LuaObject.checkSelf(l);
			bool b = heroPhantomUITask.m_luaExportHelper.__callBase_IsLoadingCustomAssets();
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

	// Token: 0x0601F6CE RID: 128718 RVA: 0x00A4D868 File Offset: 0x00A4BA68
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_IsPipeLineRunning(IntPtr l)
	{
		int result;
		try
		{
			HeroPhantomUITask heroPhantomUITask = (HeroPhantomUITask)LuaObject.checkSelf(l);
			bool b = heroPhantomUITask.m_luaExportHelper.__callBase_IsPipeLineRunning();
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

	// Token: 0x0601F6CF RID: 128719 RVA: 0x00A4D8C4 File Offset: 0x00A4BAC4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_IsOpeningUI(IntPtr l)
	{
		int result;
		try
		{
			HeroPhantomUITask heroPhantomUITask = (HeroPhantomUITask)LuaObject.checkSelf(l);
			bool b = heroPhantomUITask.m_luaExportHelper.__callBase_IsOpeningUI();
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

	// Token: 0x0601F6D0 RID: 128720 RVA: 0x00A4D920 File Offset: 0x00A4BB20
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_ReturnPrevUITask(IntPtr l)
	{
		int result;
		try
		{
			HeroPhantomUITask heroPhantomUITask = (HeroPhantomUITask)LuaObject.checkSelf(l);
			UITaskBase o = heroPhantomUITask.m_luaExportHelper.__callBase_ReturnPrevUITask();
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

	// Token: 0x0601F6D1 RID: 128721 RVA: 0x00A4D97C File Offset: 0x00A4BB7C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_ClearUnusedDynamicResourceCache(IntPtr l)
	{
		int result;
		try
		{
			HeroPhantomUITask heroPhantomUITask = (HeroPhantomUITask)LuaObject.checkSelf(l);
			heroPhantomUITask.m_luaExportHelper.__callBase_ClearUnusedDynamicResourceCache();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601F6D2 RID: 128722 RVA: 0x00A4D9D0 File Offset: 0x00A4BBD0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_OnMemoryWarning(IntPtr l)
	{
		int result;
		try
		{
			HeroPhantomUITask heroPhantomUITask = (HeroPhantomUITask)LuaObject.checkSelf(l);
			heroPhantomUITask.m_luaExportHelper.__callBase_OnMemoryWarning();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601F6D3 RID: 128723 RVA: 0x00A4DA24 File Offset: 0x00A4BC24
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_layerDescArray(IntPtr l)
	{
		int result;
		try
		{
			HeroPhantomUITask heroPhantomUITask = (HeroPhantomUITask)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, heroPhantomUITask.m_luaExportHelper.m_layerDescArray);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601F6D4 RID: 128724 RVA: 0x00A4DA7C File Offset: 0x00A4BC7C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_layerDescArray(IntPtr l)
	{
		int result;
		try
		{
			HeroPhantomUITask heroPhantomUITask = (HeroPhantomUITask)LuaObject.checkSelf(l);
			UITaskBase.LayerDesc[] layerDescArray;
			LuaObject.checkArray<UITaskBase.LayerDesc>(l, 2, out layerDescArray);
			heroPhantomUITask.m_luaExportHelper.m_layerDescArray = layerDescArray;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601F6D5 RID: 128725 RVA: 0x00A4DAD8 File Offset: 0x00A4BCD8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_uiCtrlDescArray(IntPtr l)
	{
		int result;
		try
		{
			HeroPhantomUITask heroPhantomUITask = (HeroPhantomUITask)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, heroPhantomUITask.m_luaExportHelper.m_uiCtrlDescArray);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601F6D6 RID: 128726 RVA: 0x00A4DB30 File Offset: 0x00A4BD30
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_uiCtrlDescArray(IntPtr l)
	{
		int result;
		try
		{
			HeroPhantomUITask heroPhantomUITask = (HeroPhantomUITask)LuaObject.checkSelf(l);
			UITaskBase.UIControllerDesc[] uiCtrlDescArray;
			LuaObject.checkArray<UITaskBase.UIControllerDesc>(l, 2, out uiCtrlDescArray);
			heroPhantomUITask.m_luaExportHelper.m_uiCtrlDescArray = uiCtrlDescArray;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601F6D7 RID: 128727 RVA: 0x00A4DB8C File Offset: 0x00A4BD8C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_heroPhantomUIController(IntPtr l)
	{
		int result;
		try
		{
			HeroPhantomUITask heroPhantomUITask = (HeroPhantomUITask)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, heroPhantomUITask.m_luaExportHelper.m_heroPhantomUIController);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601F6D8 RID: 128728 RVA: 0x00A4DBE4 File Offset: 0x00A4BDE4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_heroPhantomUIController(IntPtr l)
	{
		int result;
		try
		{
			HeroPhantomUITask heroPhantomUITask = (HeroPhantomUITask)LuaObject.checkSelf(l);
			HeroPhantomUIController heroPhantomUIController;
			LuaObject.checkType<HeroPhantomUIController>(l, 2, out heroPhantomUIController);
			heroPhantomUITask.m_luaExportHelper.m_heroPhantomUIController = heroPhantomUIController;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601F6D9 RID: 128729 RVA: 0x00A4DC40 File Offset: 0x00A4BE40
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_playerResourceUIController(IntPtr l)
	{
		int result;
		try
		{
			HeroPhantomUITask heroPhantomUITask = (HeroPhantomUITask)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, heroPhantomUITask.m_luaExportHelper.m_playerResourceUIController);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601F6DA RID: 128730 RVA: 0x00A4DC98 File Offset: 0x00A4BE98
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_playerResourceUIController(IntPtr l)
	{
		int result;
		try
		{
			HeroPhantomUITask heroPhantomUITask = (HeroPhantomUITask)LuaObject.checkSelf(l);
			PlayerResourceUIController playerResourceUIController;
			LuaObject.checkType<PlayerResourceUIController>(l, 2, out playerResourceUIController);
			heroPhantomUITask.m_luaExportHelper.m_playerResourceUIController = playerResourceUIController;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601F6DB RID: 128731 RVA: 0x00A4DCF4 File Offset: 0x00A4BEF4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_heroPhantomInfo(IntPtr l)
	{
		int result;
		try
		{
			HeroPhantomUITask heroPhantomUITask = (HeroPhantomUITask)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, heroPhantomUITask.m_luaExportHelper.m_heroPhantomInfo);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601F6DC RID: 128732 RVA: 0x00A4DD4C File Offset: 0x00A4BF4C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_heroPhantomInfo(IntPtr l)
	{
		int result;
		try
		{
			HeroPhantomUITask heroPhantomUITask = (HeroPhantomUITask)LuaObject.checkSelf(l);
			ConfigDataHeroPhantomInfo heroPhantomInfo;
			LuaObject.checkType<ConfigDataHeroPhantomInfo>(l, 2, out heroPhantomInfo);
			heroPhantomUITask.m_luaExportHelper.m_heroPhantomInfo = heroPhantomInfo;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601F6DD RID: 128733 RVA: 0x00A4DDA8 File Offset: 0x00A4BFA8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_LayerDescArray(IntPtr l)
	{
		int result;
		try
		{
			HeroPhantomUITask heroPhantomUITask = (HeroPhantomUITask)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, heroPhantomUITask.m_luaExportHelper.LayerDescArray);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601F6DE RID: 128734 RVA: 0x00A4DE00 File Offset: 0x00A4C000
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_UICtrlDescArray(IntPtr l)
	{
		int result;
		try
		{
			HeroPhantomUITask heroPhantomUITask = (HeroPhantomUITask)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, heroPhantomUITask.m_luaExportHelper.UICtrlDescArray);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601F6DF RID: 128735 RVA: 0x00A4DE58 File Offset: 0x00A4C058
	[Preserve]
	public static void reg(IntPtr l)
	{
		LuaObject.getTypeTable(l, "BlackJack.ProjectL.UI.HeroPhantomUITask");
		if (Lua_BlackJack_ProjectL_UI_HeroPhantomUITask.<>f__mg$cache0 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroPhantomUITask.<>f__mg$cache0 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroPhantomUITask.OnStart);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_HeroPhantomUITask.<>f__mg$cache0);
		if (Lua_BlackJack_ProjectL_UI_HeroPhantomUITask.<>f__mg$cache1 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroPhantomUITask.<>f__mg$cache1 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroPhantomUITask.OnResume);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_HeroPhantomUITask.<>f__mg$cache1);
		if (Lua_BlackJack_ProjectL_UI_HeroPhantomUITask.<>f__mg$cache2 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroPhantomUITask.<>f__mg$cache2 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroPhantomUITask.InitDataFromUIIntent);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_HeroPhantomUITask.<>f__mg$cache2);
		if (Lua_BlackJack_ProjectL_UI_HeroPhantomUITask.<>f__mg$cache3 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroPhantomUITask.<>f__mg$cache3 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroPhantomUITask.IsNeedLoadDynamicRes);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_HeroPhantomUITask.<>f__mg$cache3);
		if (Lua_BlackJack_ProjectL_UI_HeroPhantomUITask.<>f__mg$cache4 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroPhantomUITask.<>f__mg$cache4 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroPhantomUITask.InitAllUIControllers);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_HeroPhantomUITask.<>f__mg$cache4);
		if (Lua_BlackJack_ProjectL_UI_HeroPhantomUITask.<>f__mg$cache5 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroPhantomUITask.<>f__mg$cache5 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroPhantomUITask.ClearAllContextAndRes);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_HeroPhantomUITask.<>f__mg$cache5);
		if (Lua_BlackJack_ProjectL_UI_HeroPhantomUITask.<>f__mg$cache6 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroPhantomUITask.<>f__mg$cache6 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroPhantomUITask.InitHeroPhantomUIController);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_HeroPhantomUITask.<>f__mg$cache6);
		if (Lua_BlackJack_ProjectL_UI_HeroPhantomUITask.<>f__mg$cache7 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroPhantomUITask.<>f__mg$cache7 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroPhantomUITask.UninitHeroPhantomUIController);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_HeroPhantomUITask.<>f__mg$cache7);
		if (Lua_BlackJack_ProjectL_UI_HeroPhantomUITask.<>f__mg$cache8 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroPhantomUITask.<>f__mg$cache8 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroPhantomUITask.UpdateView);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_HeroPhantomUITask.<>f__mg$cache8);
		if (Lua_BlackJack_ProjectL_UI_HeroPhantomUITask.<>f__mg$cache9 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroPhantomUITask.<>f__mg$cache9 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroPhantomUITask.UpdateHeroPhantomLevels);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_HeroPhantomUITask.<>f__mg$cache9);
		if (Lua_BlackJack_ProjectL_UI_HeroPhantomUITask.<>f__mg$cacheA == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroPhantomUITask.<>f__mg$cacheA = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroPhantomUITask.HeroPhantomUIController_OnReturn);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_HeroPhantomUITask.<>f__mg$cacheA);
		if (Lua_BlackJack_ProjectL_UI_HeroPhantomUITask.<>f__mg$cacheB == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroPhantomUITask.<>f__mg$cacheB = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroPhantomUITask.HeroPhantomUIController_OnHelp);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_HeroPhantomUITask.<>f__mg$cacheB);
		if (Lua_BlackJack_ProjectL_UI_HeroPhantomUITask.<>f__mg$cacheC == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroPhantomUITask.<>f__mg$cacheC = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroPhantomUITask.HeroPhantomUIController_OnStartHeroTrainningLevel);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_HeroPhantomUITask.<>f__mg$cacheC);
		if (Lua_BlackJack_ProjectL_UI_HeroPhantomUITask.<>f__mg$cacheD == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroPhantomUITask.<>f__mg$cacheD = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroPhantomUITask.__callBase_OnStart);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_HeroPhantomUITask.<>f__mg$cacheD);
		if (Lua_BlackJack_ProjectL_UI_HeroPhantomUITask.<>f__mg$cacheE == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroPhantomUITask.<>f__mg$cacheE = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroPhantomUITask.__callBase_OnStop);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_HeroPhantomUITask.<>f__mg$cacheE);
		if (Lua_BlackJack_ProjectL_UI_HeroPhantomUITask.<>f__mg$cacheF == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroPhantomUITask.<>f__mg$cacheF = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroPhantomUITask.__callBase_OnPause);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_HeroPhantomUITask.<>f__mg$cacheF);
		if (Lua_BlackJack_ProjectL_UI_HeroPhantomUITask.<>f__mg$cache10 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroPhantomUITask.<>f__mg$cache10 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroPhantomUITask.__callBase_OnResume);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_HeroPhantomUITask.<>f__mg$cache10);
		if (Lua_BlackJack_ProjectL_UI_HeroPhantomUITask.<>f__mg$cache11 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroPhantomUITask.<>f__mg$cache11 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroPhantomUITask.__callBase_OnNewIntent);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_HeroPhantomUITask.<>f__mg$cache11);
		if (Lua_BlackJack_ProjectL_UI_HeroPhantomUITask.<>f__mg$cache12 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroPhantomUITask.<>f__mg$cache12 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroPhantomUITask.__callBase_EnableUIInput);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_HeroPhantomUITask.<>f__mg$cache12);
		if (Lua_BlackJack_ProjectL_UI_HeroPhantomUITask.<>f__mg$cache13 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroPhantomUITask.<>f__mg$cache13 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroPhantomUITask.__callBase_IsNeedLoadDynamicRes);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_HeroPhantomUITask.<>f__mg$cache13);
		if (Lua_BlackJack_ProjectL_UI_HeroPhantomUITask.<>f__mg$cache14 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroPhantomUITask.<>f__mg$cache14 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroPhantomUITask.__callBase_CollectAllDynamicResForLoad);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_HeroPhantomUITask.<>f__mg$cache14);
		if (Lua_BlackJack_ProjectL_UI_HeroPhantomUITask.<>f__mg$cache15 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroPhantomUITask.<>f__mg$cache15 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroPhantomUITask.__callBase_RegisterPlayerContextEvents);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_HeroPhantomUITask.<>f__mg$cache15);
		if (Lua_BlackJack_ProjectL_UI_HeroPhantomUITask.<>f__mg$cache16 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroPhantomUITask.<>f__mg$cache16 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroPhantomUITask.__callBase_UnregisterPlayerContextEvents);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_HeroPhantomUITask.<>f__mg$cache16);
		if (Lua_BlackJack_ProjectL_UI_HeroPhantomUITask.<>f__mg$cache17 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroPhantomUITask.<>f__mg$cache17 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroPhantomUITask.__callBase_PostUpdateView);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_HeroPhantomUITask.<>f__mg$cache17);
		if (Lua_BlackJack_ProjectL_UI_HeroPhantomUITask.<>f__mg$cache18 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroPhantomUITask.<>f__mg$cache18 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroPhantomUITask.__callBase_CollectPreloadResourceList);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_HeroPhantomUITask.<>f__mg$cache18);
		if (Lua_BlackJack_ProjectL_UI_HeroPhantomUITask.<>f__mg$cache19 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroPhantomUITask.<>f__mg$cache19 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroPhantomUITask.__callBase_ClearAssetList);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_HeroPhantomUITask.<>f__mg$cache19);
		if (Lua_BlackJack_ProjectL_UI_HeroPhantomUITask.<>f__mg$cache1A == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroPhantomUITask.<>f__mg$cache1A = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroPhantomUITask.__callBase_CollectAsset);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_HeroPhantomUITask.<>f__mg$cache1A);
		if (Lua_BlackJack_ProjectL_UI_HeroPhantomUITask.<>f__mg$cache1B == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroPhantomUITask.<>f__mg$cache1B = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroPhantomUITask.__callBase_CollectSpriteAsset);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_HeroPhantomUITask.<>f__mg$cache1B);
		if (Lua_BlackJack_ProjectL_UI_HeroPhantomUITask.<>f__mg$cache1C == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroPhantomUITask.<>f__mg$cache1C = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroPhantomUITask.__callBase_CollectFxAsset);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_HeroPhantomUITask.<>f__mg$cache1C);
		if (Lua_BlackJack_ProjectL_UI_HeroPhantomUITask.<>f__mg$cache1D == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroPhantomUITask.<>f__mg$cache1D = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroPhantomUITask.__callBase_StartLoadCustomAssets);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_HeroPhantomUITask.<>f__mg$cache1D);
		if (Lua_BlackJack_ProjectL_UI_HeroPhantomUITask.<>f__mg$cache1E == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroPhantomUITask.<>f__mg$cache1E = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroPhantomUITask.__callBase_IsLoadingCustomAssets);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_HeroPhantomUITask.<>f__mg$cache1E);
		if (Lua_BlackJack_ProjectL_UI_HeroPhantomUITask.<>f__mg$cache1F == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroPhantomUITask.<>f__mg$cache1F = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroPhantomUITask.__callBase_IsPipeLineRunning);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_HeroPhantomUITask.<>f__mg$cache1F);
		if (Lua_BlackJack_ProjectL_UI_HeroPhantomUITask.<>f__mg$cache20 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroPhantomUITask.<>f__mg$cache20 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroPhantomUITask.__callBase_IsOpeningUI);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_HeroPhantomUITask.<>f__mg$cache20);
		if (Lua_BlackJack_ProjectL_UI_HeroPhantomUITask.<>f__mg$cache21 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroPhantomUITask.<>f__mg$cache21 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroPhantomUITask.__callBase_ReturnPrevUITask);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_HeroPhantomUITask.<>f__mg$cache21);
		if (Lua_BlackJack_ProjectL_UI_HeroPhantomUITask.<>f__mg$cache22 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroPhantomUITask.<>f__mg$cache22 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroPhantomUITask.__callBase_ClearUnusedDynamicResourceCache);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_HeroPhantomUITask.<>f__mg$cache22);
		if (Lua_BlackJack_ProjectL_UI_HeroPhantomUITask.<>f__mg$cache23 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroPhantomUITask.<>f__mg$cache23 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroPhantomUITask.__callBase_OnMemoryWarning);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_HeroPhantomUITask.<>f__mg$cache23);
		string name = "m_layerDescArray";
		if (Lua_BlackJack_ProjectL_UI_HeroPhantomUITask.<>f__mg$cache24 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroPhantomUITask.<>f__mg$cache24 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroPhantomUITask.get_m_layerDescArray);
		}
		LuaCSFunction get = Lua_BlackJack_ProjectL_UI_HeroPhantomUITask.<>f__mg$cache24;
		if (Lua_BlackJack_ProjectL_UI_HeroPhantomUITask.<>f__mg$cache25 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroPhantomUITask.<>f__mg$cache25 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroPhantomUITask.set_m_layerDescArray);
		}
		LuaObject.addMember(l, name, get, Lua_BlackJack_ProjectL_UI_HeroPhantomUITask.<>f__mg$cache25, true);
		string name2 = "m_uiCtrlDescArray";
		if (Lua_BlackJack_ProjectL_UI_HeroPhantomUITask.<>f__mg$cache26 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroPhantomUITask.<>f__mg$cache26 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroPhantomUITask.get_m_uiCtrlDescArray);
		}
		LuaCSFunction get2 = Lua_BlackJack_ProjectL_UI_HeroPhantomUITask.<>f__mg$cache26;
		if (Lua_BlackJack_ProjectL_UI_HeroPhantomUITask.<>f__mg$cache27 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroPhantomUITask.<>f__mg$cache27 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroPhantomUITask.set_m_uiCtrlDescArray);
		}
		LuaObject.addMember(l, name2, get2, Lua_BlackJack_ProjectL_UI_HeroPhantomUITask.<>f__mg$cache27, true);
		string name3 = "m_heroPhantomUIController";
		if (Lua_BlackJack_ProjectL_UI_HeroPhantomUITask.<>f__mg$cache28 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroPhantomUITask.<>f__mg$cache28 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroPhantomUITask.get_m_heroPhantomUIController);
		}
		LuaCSFunction get3 = Lua_BlackJack_ProjectL_UI_HeroPhantomUITask.<>f__mg$cache28;
		if (Lua_BlackJack_ProjectL_UI_HeroPhantomUITask.<>f__mg$cache29 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroPhantomUITask.<>f__mg$cache29 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroPhantomUITask.set_m_heroPhantomUIController);
		}
		LuaObject.addMember(l, name3, get3, Lua_BlackJack_ProjectL_UI_HeroPhantomUITask.<>f__mg$cache29, true);
		string name4 = "m_playerResourceUIController";
		if (Lua_BlackJack_ProjectL_UI_HeroPhantomUITask.<>f__mg$cache2A == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroPhantomUITask.<>f__mg$cache2A = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroPhantomUITask.get_m_playerResourceUIController);
		}
		LuaCSFunction get4 = Lua_BlackJack_ProjectL_UI_HeroPhantomUITask.<>f__mg$cache2A;
		if (Lua_BlackJack_ProjectL_UI_HeroPhantomUITask.<>f__mg$cache2B == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroPhantomUITask.<>f__mg$cache2B = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroPhantomUITask.set_m_playerResourceUIController);
		}
		LuaObject.addMember(l, name4, get4, Lua_BlackJack_ProjectL_UI_HeroPhantomUITask.<>f__mg$cache2B, true);
		string name5 = "m_heroPhantomInfo";
		if (Lua_BlackJack_ProjectL_UI_HeroPhantomUITask.<>f__mg$cache2C == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroPhantomUITask.<>f__mg$cache2C = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroPhantomUITask.get_m_heroPhantomInfo);
		}
		LuaCSFunction get5 = Lua_BlackJack_ProjectL_UI_HeroPhantomUITask.<>f__mg$cache2C;
		if (Lua_BlackJack_ProjectL_UI_HeroPhantomUITask.<>f__mg$cache2D == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroPhantomUITask.<>f__mg$cache2D = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroPhantomUITask.set_m_heroPhantomInfo);
		}
		LuaObject.addMember(l, name5, get5, Lua_BlackJack_ProjectL_UI_HeroPhantomUITask.<>f__mg$cache2D, true);
		string name6 = "LayerDescArray";
		if (Lua_BlackJack_ProjectL_UI_HeroPhantomUITask.<>f__mg$cache2E == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroPhantomUITask.<>f__mg$cache2E = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroPhantomUITask.get_LayerDescArray);
		}
		LuaObject.addMember(l, name6, Lua_BlackJack_ProjectL_UI_HeroPhantomUITask.<>f__mg$cache2E, null, true);
		string name7 = "UICtrlDescArray";
		if (Lua_BlackJack_ProjectL_UI_HeroPhantomUITask.<>f__mg$cache2F == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroPhantomUITask.<>f__mg$cache2F = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroPhantomUITask.get_UICtrlDescArray);
		}
		LuaObject.addMember(l, name7, Lua_BlackJack_ProjectL_UI_HeroPhantomUITask.<>f__mg$cache2F, null, true);
		if (Lua_BlackJack_ProjectL_UI_HeroPhantomUITask.<>f__mg$cache30 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroPhantomUITask.<>f__mg$cache30 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroPhantomUITask.constructor);
		}
		LuaObject.createTypeMetatable(l, Lua_BlackJack_ProjectL_UI_HeroPhantomUITask.<>f__mg$cache30, typeof(HeroPhantomUITask), typeof(UITask));
	}

	// Token: 0x040156DA RID: 87770
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache0;

	// Token: 0x040156DB RID: 87771
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1;

	// Token: 0x040156DC RID: 87772
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2;

	// Token: 0x040156DD RID: 87773
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3;

	// Token: 0x040156DE RID: 87774
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache4;

	// Token: 0x040156DF RID: 87775
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache5;

	// Token: 0x040156E0 RID: 87776
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache6;

	// Token: 0x040156E1 RID: 87777
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache7;

	// Token: 0x040156E2 RID: 87778
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache8;

	// Token: 0x040156E3 RID: 87779
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache9;

	// Token: 0x040156E4 RID: 87780
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheA;

	// Token: 0x040156E5 RID: 87781
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheB;

	// Token: 0x040156E6 RID: 87782
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheC;

	// Token: 0x040156E7 RID: 87783
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheD;

	// Token: 0x040156E8 RID: 87784
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheE;

	// Token: 0x040156E9 RID: 87785
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheF;

	// Token: 0x040156EA RID: 87786
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache10;

	// Token: 0x040156EB RID: 87787
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache11;

	// Token: 0x040156EC RID: 87788
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache12;

	// Token: 0x040156ED RID: 87789
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache13;

	// Token: 0x040156EE RID: 87790
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache14;

	// Token: 0x040156EF RID: 87791
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache15;

	// Token: 0x040156F0 RID: 87792
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache16;

	// Token: 0x040156F1 RID: 87793
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache17;

	// Token: 0x040156F2 RID: 87794
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache18;

	// Token: 0x040156F3 RID: 87795
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache19;

	// Token: 0x040156F4 RID: 87796
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1A;

	// Token: 0x040156F5 RID: 87797
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1B;

	// Token: 0x040156F6 RID: 87798
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1C;

	// Token: 0x040156F7 RID: 87799
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1D;

	// Token: 0x040156F8 RID: 87800
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1E;

	// Token: 0x040156F9 RID: 87801
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1F;

	// Token: 0x040156FA RID: 87802
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache20;

	// Token: 0x040156FB RID: 87803
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache21;

	// Token: 0x040156FC RID: 87804
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache22;

	// Token: 0x040156FD RID: 87805
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache23;

	// Token: 0x040156FE RID: 87806
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache24;

	// Token: 0x040156FF RID: 87807
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache25;

	// Token: 0x04015700 RID: 87808
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache26;

	// Token: 0x04015701 RID: 87809
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache27;

	// Token: 0x04015702 RID: 87810
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache28;

	// Token: 0x04015703 RID: 87811
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache29;

	// Token: 0x04015704 RID: 87812
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2A;

	// Token: 0x04015705 RID: 87813
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2B;

	// Token: 0x04015706 RID: 87814
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2C;

	// Token: 0x04015707 RID: 87815
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2D;

	// Token: 0x04015708 RID: 87816
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2E;

	// Token: 0x04015709 RID: 87817
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2F;

	// Token: 0x0401570A RID: 87818
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache30;
}
