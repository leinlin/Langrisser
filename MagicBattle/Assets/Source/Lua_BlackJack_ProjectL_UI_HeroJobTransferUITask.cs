using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using BlackJack.BJFramework.Runtime.UI;
using BlackJack.ConfigData;
using BlackJack.ProjectL.Common;
using BlackJack.ProjectL.UI;
using SLua;
using UnityEngine.Scripting;

// Token: 0x020014D0 RID: 5328
[Preserve]
public class Lua_BlackJack_ProjectL_UI_HeroJobTransferUITask : LuaObject
{
	// Token: 0x0601F3E9 RID: 127977 RVA: 0x00A36CB0 File Offset: 0x00A34EB0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int constructor(IntPtr l)
	{
		int result;
		try
		{
			string name;
			LuaObject.checkType(l, 2, out name);
			HeroJobTransferUITask o = new HeroJobTransferUITask(name);
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

	// Token: 0x0601F3EA RID: 127978 RVA: 0x00A36D04 File Offset: 0x00A34F04
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int IsNeedLoadDynamicRes(IntPtr l)
	{
		int result;
		try
		{
			HeroJobTransferUITask heroJobTransferUITask = (HeroJobTransferUITask)LuaObject.checkSelf(l);
			bool b = heroJobTransferUITask.m_luaExportHelper.IsNeedLoadDynamicRes();
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

	// Token: 0x0601F3EB RID: 127979 RVA: 0x00A36D60 File Offset: 0x00A34F60
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int InitAllUIControllers(IntPtr l)
	{
		int result;
		try
		{
			HeroJobTransferUITask heroJobTransferUITask = (HeroJobTransferUITask)LuaObject.checkSelf(l);
			heroJobTransferUITask.m_luaExportHelper.InitAllUIControllers();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601F3EC RID: 127980 RVA: 0x00A36DB4 File Offset: 0x00A34FB4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int ClearAllContextAndRes(IntPtr l)
	{
		int result;
		try
		{
			HeroJobTransferUITask heroJobTransferUITask = (HeroJobTransferUITask)LuaObject.checkSelf(l);
			heroJobTransferUITask.m_luaExportHelper.ClearAllContextAndRes();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601F3ED RID: 127981 RVA: 0x00A36E08 File Offset: 0x00A35008
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int OnStart(IntPtr l)
	{
		int result;
		try
		{
			HeroJobTransferUITask heroJobTransferUITask = (HeroJobTransferUITask)LuaObject.checkSelf(l);
			UIIntent intent;
			LuaObject.checkType<UIIntent>(l, 2, out intent);
			bool b = heroJobTransferUITask.m_luaExportHelper.OnStart(intent);
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

	// Token: 0x0601F3EE RID: 127982 RVA: 0x00A36E70 File Offset: 0x00A35070
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int OnResume(IntPtr l)
	{
		int result;
		try
		{
			HeroJobTransferUITask heroJobTransferUITask = (HeroJobTransferUITask)LuaObject.checkSelf(l);
			UIIntent intent;
			LuaObject.checkType<UIIntent>(l, 2, out intent);
			bool b = heroJobTransferUITask.m_luaExportHelper.OnResume(intent);
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

	// Token: 0x0601F3EF RID: 127983 RVA: 0x00A36ED8 File Offset: 0x00A350D8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int InitDataFromUIIntent(IntPtr l)
	{
		int result;
		try
		{
			HeroJobTransferUITask heroJobTransferUITask = (HeroJobTransferUITask)LuaObject.checkSelf(l);
			UIIntent intent;
			LuaObject.checkType<UIIntent>(l, 2, out intent);
			heroJobTransferUITask.m_luaExportHelper.InitDataFromUIIntent(intent);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601F3F0 RID: 127984 RVA: 0x00A36F34 File Offset: 0x00A35134
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int OnMemoryWarning(IntPtr l)
	{
		int result;
		try
		{
			HeroJobTransferUITask heroJobTransferUITask = (HeroJobTransferUITask)LuaObject.checkSelf(l);
			heroJobTransferUITask.m_luaExportHelper.OnMemoryWarning();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601F3F1 RID: 127985 RVA: 0x00A36F88 File Offset: 0x00A35188
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int UpdateView(IntPtr l)
	{
		int result;
		try
		{
			HeroJobTransferUITask heroJobTransferUITask = (HeroJobTransferUITask)LuaObject.checkSelf(l);
			heroJobTransferUITask.m_luaExportHelper.UpdateView();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601F3F2 RID: 127986 RVA: 0x00A36FDC File Offset: 0x00A351DC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int HeroJobTransferUIController_OnReturn(IntPtr l)
	{
		int result;
		try
		{
			HeroJobTransferUITask heroJobTransferUITask = (HeroJobTransferUITask)LuaObject.checkSelf(l);
			heroJobTransferUITask.m_luaExportHelper.HeroJobTransferUIController_OnReturn();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601F3F3 RID: 127987 RVA: 0x00A37030 File Offset: 0x00A35230
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int HeroJobTransferUIController_OnJobTransfer(IntPtr l)
	{
		int result;
		try
		{
			HeroJobTransferUITask heroJobTransferUITask = (HeroJobTransferUITask)LuaObject.checkSelf(l);
			int heroId;
			LuaObject.checkType(l, 2, out heroId);
			int jobConnectionId;
			LuaObject.checkType(l, 3, out jobConnectionId);
			Action onSucceed;
			LuaObject.checkDelegate<Action>(l, 4, out onSucceed);
			heroJobTransferUITask.m_luaExportHelper.HeroJobTransferUIController_OnJobTransfer(heroId, jobConnectionId, onSucceed);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601F3F4 RID: 127988 RVA: 0x00A370A8 File Offset: 0x00A352A8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int HeroJobTransferUIController_OnHeroJobUnlock(IntPtr l)
	{
		int result;
		try
		{
			HeroJobTransferUITask heroJobTransferUITask = (HeroJobTransferUITask)LuaObject.checkSelf(l);
			int heroId;
			LuaObject.checkType(l, 2, out heroId);
			int jobRelatedId;
			LuaObject.checkType(l, 3, out jobRelatedId);
			Action onSucceed;
			LuaObject.checkDelegate<Action>(l, 4, out onSucceed);
			heroJobTransferUITask.m_luaExportHelper.HeroJobTransferUIController_OnHeroJobUnlock(heroId, jobRelatedId, onSucceed);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601F3F5 RID: 127989 RVA: 0x00A37120 File Offset: 0x00A35320
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int HeroJobTransferUIController_OnHeroJobCardClick(IntPtr l)
	{
		int result;
		try
		{
			HeroJobTransferUITask heroJobTransferUITask = (HeroJobTransferUITask)LuaObject.checkSelf(l);
			ConfigDataJobConnectionInfo jci;
			LuaObject.checkType<ConfigDataJobConnectionInfo>(l, 2, out jci);
			heroJobTransferUITask.m_luaExportHelper.HeroJobTransferUIController_OnHeroJobCardClick(jci);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601F3F6 RID: 127990 RVA: 0x00A3717C File Offset: 0x00A3537C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int HeroJobTransferUIController_OnAddGold(IntPtr l)
	{
		int result;
		try
		{
			HeroJobTransferUITask heroJobTransferUITask = (HeroJobTransferUITask)LuaObject.checkSelf(l);
			heroJobTransferUITask.m_luaExportHelper.HeroJobTransferUIController_OnAddGold();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601F3F7 RID: 127991 RVA: 0x00A371D0 File Offset: 0x00A353D0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_OnStart(IntPtr l)
	{
		int result;
		try
		{
			HeroJobTransferUITask heroJobTransferUITask = (HeroJobTransferUITask)LuaObject.checkSelf(l);
			UIIntent intent;
			LuaObject.checkType<UIIntent>(l, 2, out intent);
			bool b = heroJobTransferUITask.m_luaExportHelper.__callBase_OnStart(intent);
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

	// Token: 0x0601F3F8 RID: 127992 RVA: 0x00A37238 File Offset: 0x00A35438
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_OnStop(IntPtr l)
	{
		int result;
		try
		{
			HeroJobTransferUITask heroJobTransferUITask = (HeroJobTransferUITask)LuaObject.checkSelf(l);
			heroJobTransferUITask.m_luaExportHelper.__callBase_OnStop();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601F3F9 RID: 127993 RVA: 0x00A3728C File Offset: 0x00A3548C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_OnPause(IntPtr l)
	{
		int result;
		try
		{
			HeroJobTransferUITask heroJobTransferUITask = (HeroJobTransferUITask)LuaObject.checkSelf(l);
			heroJobTransferUITask.m_luaExportHelper.__callBase_OnPause();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601F3FA RID: 127994 RVA: 0x00A372E0 File Offset: 0x00A354E0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_OnResume(IntPtr l)
	{
		int result;
		try
		{
			HeroJobTransferUITask heroJobTransferUITask = (HeroJobTransferUITask)LuaObject.checkSelf(l);
			UIIntent intent;
			LuaObject.checkType<UIIntent>(l, 2, out intent);
			bool b = heroJobTransferUITask.m_luaExportHelper.__callBase_OnResume(intent);
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

	// Token: 0x0601F3FB RID: 127995 RVA: 0x00A37348 File Offset: 0x00A35548
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_OnNewIntent(IntPtr l)
	{
		int result;
		try
		{
			HeroJobTransferUITask heroJobTransferUITask = (HeroJobTransferUITask)LuaObject.checkSelf(l);
			UIIntent intent;
			LuaObject.checkType<UIIntent>(l, 2, out intent);
			bool b = heroJobTransferUITask.m_luaExportHelper.__callBase_OnNewIntent(intent);
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

	// Token: 0x0601F3FC RID: 127996 RVA: 0x00A373B0 File Offset: 0x00A355B0
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int __callBase_EnableUIInput(IntPtr l)
	{
		int result;
		try
		{
			HeroJobTransferUITask heroJobTransferUITask = (HeroJobTransferUITask)LuaObject.checkSelf(l);
			bool isEnable;
			LuaObject.checkType(l, 2, out isEnable);
			bool? isGlobalEnable;
			LuaObject.checkNullable<bool>(l, 3, out isGlobalEnable);
			heroJobTransferUITask.m_luaExportHelper.__callBase_EnableUIInput(isEnable, isGlobalEnable);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601F3FD RID: 127997 RVA: 0x00A3741C File Offset: 0x00A3561C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_IsNeedLoadDynamicRes(IntPtr l)
	{
		int result;
		try
		{
			HeroJobTransferUITask heroJobTransferUITask = (HeroJobTransferUITask)LuaObject.checkSelf(l);
			bool b = heroJobTransferUITask.m_luaExportHelper.__callBase_IsNeedLoadDynamicRes();
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

	// Token: 0x0601F3FE RID: 127998 RVA: 0x00A37478 File Offset: 0x00A35678
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_CollectAllDynamicResForLoad(IntPtr l)
	{
		int result;
		try
		{
			HeroJobTransferUITask heroJobTransferUITask = (HeroJobTransferUITask)LuaObject.checkSelf(l);
			List<string> o = heroJobTransferUITask.m_luaExportHelper.__callBase_CollectAllDynamicResForLoad();
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

	// Token: 0x0601F3FF RID: 127999 RVA: 0x00A374D4 File Offset: 0x00A356D4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_RegisterPlayerContextEvents(IntPtr l)
	{
		int result;
		try
		{
			HeroJobTransferUITask heroJobTransferUITask = (HeroJobTransferUITask)LuaObject.checkSelf(l);
			heroJobTransferUITask.m_luaExportHelper.__callBase_RegisterPlayerContextEvents();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601F400 RID: 128000 RVA: 0x00A37528 File Offset: 0x00A35728
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_UnregisterPlayerContextEvents(IntPtr l)
	{
		int result;
		try
		{
			HeroJobTransferUITask heroJobTransferUITask = (HeroJobTransferUITask)LuaObject.checkSelf(l);
			heroJobTransferUITask.m_luaExportHelper.__callBase_UnregisterPlayerContextEvents();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601F401 RID: 128001 RVA: 0x00A3757C File Offset: 0x00A3577C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_PostUpdateView(IntPtr l)
	{
		int result;
		try
		{
			HeroJobTransferUITask heroJobTransferUITask = (HeroJobTransferUITask)LuaObject.checkSelf(l);
			heroJobTransferUITask.m_luaExportHelper.__callBase_PostUpdateView();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601F402 RID: 128002 RVA: 0x00A375D0 File Offset: 0x00A357D0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_CollectPreloadResourceList(IntPtr l)
	{
		int result;
		try
		{
			HeroJobTransferUITask heroJobTransferUITask = (HeroJobTransferUITask)LuaObject.checkSelf(l);
			heroJobTransferUITask.m_luaExportHelper.__callBase_CollectPreloadResourceList();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601F403 RID: 128003 RVA: 0x00A37624 File Offset: 0x00A35824
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_ClearAssetList(IntPtr l)
	{
		int result;
		try
		{
			HeroJobTransferUITask heroJobTransferUITask = (HeroJobTransferUITask)LuaObject.checkSelf(l);
			heroJobTransferUITask.m_luaExportHelper.__callBase_ClearAssetList();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601F404 RID: 128004 RVA: 0x00A37678 File Offset: 0x00A35878
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_CollectAsset(IntPtr l)
	{
		int result;
		try
		{
			HeroJobTransferUITask heroJobTransferUITask = (HeroJobTransferUITask)LuaObject.checkSelf(l);
			string assetName;
			LuaObject.checkType(l, 2, out assetName);
			heroJobTransferUITask.m_luaExportHelper.__callBase_CollectAsset(assetName);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601F405 RID: 128005 RVA: 0x00A376D4 File Offset: 0x00A358D4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_CollectSpriteAsset(IntPtr l)
	{
		int result;
		try
		{
			HeroJobTransferUITask heroJobTransferUITask = (HeroJobTransferUITask)LuaObject.checkSelf(l);
			string assetName;
			LuaObject.checkType(l, 2, out assetName);
			heroJobTransferUITask.m_luaExportHelper.__callBase_CollectSpriteAsset(assetName);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601F406 RID: 128006 RVA: 0x00A37730 File Offset: 0x00A35930
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_CollectFxAsset(IntPtr l)
	{
		int result;
		try
		{
			HeroJobTransferUITask heroJobTransferUITask = (HeroJobTransferUITask)LuaObject.checkSelf(l);
			string assetName;
			LuaObject.checkType(l, 2, out assetName);
			heroJobTransferUITask.m_luaExportHelper.__callBase_CollectFxAsset(assetName);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601F407 RID: 128007 RVA: 0x00A3778C File Offset: 0x00A3598C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_StartLoadCustomAssets(IntPtr l)
	{
		int result;
		try
		{
			HeroJobTransferUITask heroJobTransferUITask = (HeroJobTransferUITask)LuaObject.checkSelf(l);
			Action onLoadCompleted;
			LuaObject.checkDelegate<Action>(l, 2, out onLoadCompleted);
			heroJobTransferUITask.m_luaExportHelper.__callBase_StartLoadCustomAssets(onLoadCompleted);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601F408 RID: 128008 RVA: 0x00A377E8 File Offset: 0x00A359E8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_IsLoadingCustomAssets(IntPtr l)
	{
		int result;
		try
		{
			HeroJobTransferUITask heroJobTransferUITask = (HeroJobTransferUITask)LuaObject.checkSelf(l);
			bool b = heroJobTransferUITask.m_luaExportHelper.__callBase_IsLoadingCustomAssets();
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

	// Token: 0x0601F409 RID: 128009 RVA: 0x00A37844 File Offset: 0x00A35A44
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_IsPipeLineRunning(IntPtr l)
	{
		int result;
		try
		{
			HeroJobTransferUITask heroJobTransferUITask = (HeroJobTransferUITask)LuaObject.checkSelf(l);
			bool b = heroJobTransferUITask.m_luaExportHelper.__callBase_IsPipeLineRunning();
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

	// Token: 0x0601F40A RID: 128010 RVA: 0x00A378A0 File Offset: 0x00A35AA0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_IsOpeningUI(IntPtr l)
	{
		int result;
		try
		{
			HeroJobTransferUITask heroJobTransferUITask = (HeroJobTransferUITask)LuaObject.checkSelf(l);
			bool b = heroJobTransferUITask.m_luaExportHelper.__callBase_IsOpeningUI();
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

	// Token: 0x0601F40B RID: 128011 RVA: 0x00A378FC File Offset: 0x00A35AFC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_ReturnPrevUITask(IntPtr l)
	{
		int result;
		try
		{
			HeroJobTransferUITask heroJobTransferUITask = (HeroJobTransferUITask)LuaObject.checkSelf(l);
			UITaskBase o = heroJobTransferUITask.m_luaExportHelper.__callBase_ReturnPrevUITask();
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

	// Token: 0x0601F40C RID: 128012 RVA: 0x00A37958 File Offset: 0x00A35B58
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_ClearUnusedDynamicResourceCache(IntPtr l)
	{
		int result;
		try
		{
			HeroJobTransferUITask heroJobTransferUITask = (HeroJobTransferUITask)LuaObject.checkSelf(l);
			heroJobTransferUITask.m_luaExportHelper.__callBase_ClearUnusedDynamicResourceCache();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601F40D RID: 128013 RVA: 0x00A379AC File Offset: 0x00A35BAC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_OnMemoryWarning(IntPtr l)
	{
		int result;
		try
		{
			HeroJobTransferUITask heroJobTransferUITask = (HeroJobTransferUITask)LuaObject.checkSelf(l);
			heroJobTransferUITask.m_luaExportHelper.__callBase_OnMemoryWarning();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601F40E RID: 128014 RVA: 0x00A37A00 File Offset: 0x00A35C00
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_layerDescArray(IntPtr l)
	{
		int result;
		try
		{
			HeroJobTransferUITask heroJobTransferUITask = (HeroJobTransferUITask)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, heroJobTransferUITask.m_luaExportHelper.m_layerDescArray);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601F40F RID: 128015 RVA: 0x00A37A58 File Offset: 0x00A35C58
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_layerDescArray(IntPtr l)
	{
		int result;
		try
		{
			HeroJobTransferUITask heroJobTransferUITask = (HeroJobTransferUITask)LuaObject.checkSelf(l);
			UITaskBase.LayerDesc[] layerDescArray;
			LuaObject.checkArray<UITaskBase.LayerDesc>(l, 2, out layerDescArray);
			heroJobTransferUITask.m_luaExportHelper.m_layerDescArray = layerDescArray;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601F410 RID: 128016 RVA: 0x00A37AB4 File Offset: 0x00A35CB4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_uiCtrlDescArray(IntPtr l)
	{
		int result;
		try
		{
			HeroJobTransferUITask heroJobTransferUITask = (HeroJobTransferUITask)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, heroJobTransferUITask.m_luaExportHelper.m_uiCtrlDescArray);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601F411 RID: 128017 RVA: 0x00A37B0C File Offset: 0x00A35D0C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_uiCtrlDescArray(IntPtr l)
	{
		int result;
		try
		{
			HeroJobTransferUITask heroJobTransferUITask = (HeroJobTransferUITask)LuaObject.checkSelf(l);
			UITaskBase.UIControllerDesc[] uiCtrlDescArray;
			LuaObject.checkArray<UITaskBase.UIControllerDesc>(l, 2, out uiCtrlDescArray);
			heroJobTransferUITask.m_luaExportHelper.m_uiCtrlDescArray = uiCtrlDescArray;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601F412 RID: 128018 RVA: 0x00A37B68 File Offset: 0x00A35D68
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_hero(IntPtr l)
	{
		int result;
		try
		{
			HeroJobTransferUITask heroJobTransferUITask = (HeroJobTransferUITask)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, heroJobTransferUITask.m_luaExportHelper.m_hero);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601F413 RID: 128019 RVA: 0x00A37BC0 File Offset: 0x00A35DC0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_hero(IntPtr l)
	{
		int result;
		try
		{
			HeroJobTransferUITask heroJobTransferUITask = (HeroJobTransferUITask)LuaObject.checkSelf(l);
			Hero hero;
			LuaObject.checkType<Hero>(l, 2, out hero);
			heroJobTransferUITask.m_luaExportHelper.m_hero = hero;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601F414 RID: 128020 RVA: 0x00A37C1C File Offset: 0x00A35E1C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_curJobConnectionInfo(IntPtr l)
	{
		int result;
		try
		{
			HeroJobTransferUITask heroJobTransferUITask = (HeroJobTransferUITask)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, heroJobTransferUITask.m_luaExportHelper.m_curJobConnectionInfo);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601F415 RID: 128021 RVA: 0x00A37C74 File Offset: 0x00A35E74
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_curJobConnectionInfo(IntPtr l)
	{
		int result;
		try
		{
			HeroJobTransferUITask heroJobTransferUITask = (HeroJobTransferUITask)LuaObject.checkSelf(l);
			ConfigDataJobConnectionInfo curJobConnectionInfo;
			LuaObject.checkType<ConfigDataJobConnectionInfo>(l, 2, out curJobConnectionInfo);
			heroJobTransferUITask.m_luaExportHelper.m_curJobConnectionInfo = curJobConnectionInfo;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601F416 RID: 128022 RVA: 0x00A37CD0 File Offset: 0x00A35ED0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_heroJobTransferUIController(IntPtr l)
	{
		int result;
		try
		{
			HeroJobTransferUITask heroJobTransferUITask = (HeroJobTransferUITask)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, heroJobTransferUITask.m_luaExportHelper.m_heroJobTransferUIController);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601F417 RID: 128023 RVA: 0x00A37D28 File Offset: 0x00A35F28
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_heroJobTransferUIController(IntPtr l)
	{
		int result;
		try
		{
			HeroJobTransferUITask heroJobTransferUITask = (HeroJobTransferUITask)LuaObject.checkSelf(l);
			HeroJobTransferUIController heroJobTransferUIController;
			LuaObject.checkType<HeroJobTransferUIController>(l, 2, out heroJobTransferUIController);
			heroJobTransferUITask.m_luaExportHelper.m_heroJobTransferUIController = heroJobTransferUIController;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601F418 RID: 128024 RVA: 0x00A37D84 File Offset: 0x00A35F84
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_LayerDescArray(IntPtr l)
	{
		int result;
		try
		{
			HeroJobTransferUITask heroJobTransferUITask = (HeroJobTransferUITask)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, heroJobTransferUITask.m_luaExportHelper.LayerDescArray);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601F419 RID: 128025 RVA: 0x00A37DDC File Offset: 0x00A35FDC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_UICtrlDescArray(IntPtr l)
	{
		int result;
		try
		{
			HeroJobTransferUITask heroJobTransferUITask = (HeroJobTransferUITask)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, heroJobTransferUITask.m_luaExportHelper.UICtrlDescArray);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601F41A RID: 128026 RVA: 0x00A37E34 File Offset: 0x00A36034
	[Preserve]
	public static void reg(IntPtr l)
	{
		LuaObject.getTypeTable(l, "BlackJack.ProjectL.UI.HeroJobTransferUITask");
		if (Lua_BlackJack_ProjectL_UI_HeroJobTransferUITask.<>f__mg$cache0 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroJobTransferUITask.<>f__mg$cache0 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroJobTransferUITask.IsNeedLoadDynamicRes);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_HeroJobTransferUITask.<>f__mg$cache0);
		if (Lua_BlackJack_ProjectL_UI_HeroJobTransferUITask.<>f__mg$cache1 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroJobTransferUITask.<>f__mg$cache1 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroJobTransferUITask.InitAllUIControllers);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_HeroJobTransferUITask.<>f__mg$cache1);
		if (Lua_BlackJack_ProjectL_UI_HeroJobTransferUITask.<>f__mg$cache2 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroJobTransferUITask.<>f__mg$cache2 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroJobTransferUITask.ClearAllContextAndRes);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_HeroJobTransferUITask.<>f__mg$cache2);
		if (Lua_BlackJack_ProjectL_UI_HeroJobTransferUITask.<>f__mg$cache3 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroJobTransferUITask.<>f__mg$cache3 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroJobTransferUITask.OnStart);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_HeroJobTransferUITask.<>f__mg$cache3);
		if (Lua_BlackJack_ProjectL_UI_HeroJobTransferUITask.<>f__mg$cache4 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroJobTransferUITask.<>f__mg$cache4 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroJobTransferUITask.OnResume);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_HeroJobTransferUITask.<>f__mg$cache4);
		if (Lua_BlackJack_ProjectL_UI_HeroJobTransferUITask.<>f__mg$cache5 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroJobTransferUITask.<>f__mg$cache5 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroJobTransferUITask.InitDataFromUIIntent);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_HeroJobTransferUITask.<>f__mg$cache5);
		if (Lua_BlackJack_ProjectL_UI_HeroJobTransferUITask.<>f__mg$cache6 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroJobTransferUITask.<>f__mg$cache6 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroJobTransferUITask.OnMemoryWarning);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_HeroJobTransferUITask.<>f__mg$cache6);
		if (Lua_BlackJack_ProjectL_UI_HeroJobTransferUITask.<>f__mg$cache7 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroJobTransferUITask.<>f__mg$cache7 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroJobTransferUITask.UpdateView);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_HeroJobTransferUITask.<>f__mg$cache7);
		if (Lua_BlackJack_ProjectL_UI_HeroJobTransferUITask.<>f__mg$cache8 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroJobTransferUITask.<>f__mg$cache8 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroJobTransferUITask.HeroJobTransferUIController_OnReturn);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_HeroJobTransferUITask.<>f__mg$cache8);
		if (Lua_BlackJack_ProjectL_UI_HeroJobTransferUITask.<>f__mg$cache9 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroJobTransferUITask.<>f__mg$cache9 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroJobTransferUITask.HeroJobTransferUIController_OnJobTransfer);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_HeroJobTransferUITask.<>f__mg$cache9);
		if (Lua_BlackJack_ProjectL_UI_HeroJobTransferUITask.<>f__mg$cacheA == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroJobTransferUITask.<>f__mg$cacheA = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroJobTransferUITask.HeroJobTransferUIController_OnHeroJobUnlock);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_HeroJobTransferUITask.<>f__mg$cacheA);
		if (Lua_BlackJack_ProjectL_UI_HeroJobTransferUITask.<>f__mg$cacheB == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroJobTransferUITask.<>f__mg$cacheB = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroJobTransferUITask.HeroJobTransferUIController_OnHeroJobCardClick);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_HeroJobTransferUITask.<>f__mg$cacheB);
		if (Lua_BlackJack_ProjectL_UI_HeroJobTransferUITask.<>f__mg$cacheC == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroJobTransferUITask.<>f__mg$cacheC = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroJobTransferUITask.HeroJobTransferUIController_OnAddGold);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_HeroJobTransferUITask.<>f__mg$cacheC);
		if (Lua_BlackJack_ProjectL_UI_HeroJobTransferUITask.<>f__mg$cacheD == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroJobTransferUITask.<>f__mg$cacheD = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroJobTransferUITask.__callBase_OnStart);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_HeroJobTransferUITask.<>f__mg$cacheD);
		if (Lua_BlackJack_ProjectL_UI_HeroJobTransferUITask.<>f__mg$cacheE == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroJobTransferUITask.<>f__mg$cacheE = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroJobTransferUITask.__callBase_OnStop);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_HeroJobTransferUITask.<>f__mg$cacheE);
		if (Lua_BlackJack_ProjectL_UI_HeroJobTransferUITask.<>f__mg$cacheF == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroJobTransferUITask.<>f__mg$cacheF = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroJobTransferUITask.__callBase_OnPause);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_HeroJobTransferUITask.<>f__mg$cacheF);
		if (Lua_BlackJack_ProjectL_UI_HeroJobTransferUITask.<>f__mg$cache10 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroJobTransferUITask.<>f__mg$cache10 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroJobTransferUITask.__callBase_OnResume);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_HeroJobTransferUITask.<>f__mg$cache10);
		if (Lua_BlackJack_ProjectL_UI_HeroJobTransferUITask.<>f__mg$cache11 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroJobTransferUITask.<>f__mg$cache11 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroJobTransferUITask.__callBase_OnNewIntent);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_HeroJobTransferUITask.<>f__mg$cache11);
		if (Lua_BlackJack_ProjectL_UI_HeroJobTransferUITask.<>f__mg$cache12 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroJobTransferUITask.<>f__mg$cache12 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroJobTransferUITask.__callBase_EnableUIInput);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_HeroJobTransferUITask.<>f__mg$cache12);
		if (Lua_BlackJack_ProjectL_UI_HeroJobTransferUITask.<>f__mg$cache13 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroJobTransferUITask.<>f__mg$cache13 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroJobTransferUITask.__callBase_IsNeedLoadDynamicRes);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_HeroJobTransferUITask.<>f__mg$cache13);
		if (Lua_BlackJack_ProjectL_UI_HeroJobTransferUITask.<>f__mg$cache14 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroJobTransferUITask.<>f__mg$cache14 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroJobTransferUITask.__callBase_CollectAllDynamicResForLoad);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_HeroJobTransferUITask.<>f__mg$cache14);
		if (Lua_BlackJack_ProjectL_UI_HeroJobTransferUITask.<>f__mg$cache15 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroJobTransferUITask.<>f__mg$cache15 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroJobTransferUITask.__callBase_RegisterPlayerContextEvents);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_HeroJobTransferUITask.<>f__mg$cache15);
		if (Lua_BlackJack_ProjectL_UI_HeroJobTransferUITask.<>f__mg$cache16 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroJobTransferUITask.<>f__mg$cache16 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroJobTransferUITask.__callBase_UnregisterPlayerContextEvents);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_HeroJobTransferUITask.<>f__mg$cache16);
		if (Lua_BlackJack_ProjectL_UI_HeroJobTransferUITask.<>f__mg$cache17 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroJobTransferUITask.<>f__mg$cache17 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroJobTransferUITask.__callBase_PostUpdateView);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_HeroJobTransferUITask.<>f__mg$cache17);
		if (Lua_BlackJack_ProjectL_UI_HeroJobTransferUITask.<>f__mg$cache18 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroJobTransferUITask.<>f__mg$cache18 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroJobTransferUITask.__callBase_CollectPreloadResourceList);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_HeroJobTransferUITask.<>f__mg$cache18);
		if (Lua_BlackJack_ProjectL_UI_HeroJobTransferUITask.<>f__mg$cache19 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroJobTransferUITask.<>f__mg$cache19 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroJobTransferUITask.__callBase_ClearAssetList);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_HeroJobTransferUITask.<>f__mg$cache19);
		if (Lua_BlackJack_ProjectL_UI_HeroJobTransferUITask.<>f__mg$cache1A == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroJobTransferUITask.<>f__mg$cache1A = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroJobTransferUITask.__callBase_CollectAsset);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_HeroJobTransferUITask.<>f__mg$cache1A);
		if (Lua_BlackJack_ProjectL_UI_HeroJobTransferUITask.<>f__mg$cache1B == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroJobTransferUITask.<>f__mg$cache1B = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroJobTransferUITask.__callBase_CollectSpriteAsset);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_HeroJobTransferUITask.<>f__mg$cache1B);
		if (Lua_BlackJack_ProjectL_UI_HeroJobTransferUITask.<>f__mg$cache1C == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroJobTransferUITask.<>f__mg$cache1C = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroJobTransferUITask.__callBase_CollectFxAsset);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_HeroJobTransferUITask.<>f__mg$cache1C);
		if (Lua_BlackJack_ProjectL_UI_HeroJobTransferUITask.<>f__mg$cache1D == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroJobTransferUITask.<>f__mg$cache1D = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroJobTransferUITask.__callBase_StartLoadCustomAssets);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_HeroJobTransferUITask.<>f__mg$cache1D);
		if (Lua_BlackJack_ProjectL_UI_HeroJobTransferUITask.<>f__mg$cache1E == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroJobTransferUITask.<>f__mg$cache1E = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroJobTransferUITask.__callBase_IsLoadingCustomAssets);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_HeroJobTransferUITask.<>f__mg$cache1E);
		if (Lua_BlackJack_ProjectL_UI_HeroJobTransferUITask.<>f__mg$cache1F == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroJobTransferUITask.<>f__mg$cache1F = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroJobTransferUITask.__callBase_IsPipeLineRunning);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_HeroJobTransferUITask.<>f__mg$cache1F);
		if (Lua_BlackJack_ProjectL_UI_HeroJobTransferUITask.<>f__mg$cache20 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroJobTransferUITask.<>f__mg$cache20 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroJobTransferUITask.__callBase_IsOpeningUI);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_HeroJobTransferUITask.<>f__mg$cache20);
		if (Lua_BlackJack_ProjectL_UI_HeroJobTransferUITask.<>f__mg$cache21 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroJobTransferUITask.<>f__mg$cache21 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroJobTransferUITask.__callBase_ReturnPrevUITask);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_HeroJobTransferUITask.<>f__mg$cache21);
		if (Lua_BlackJack_ProjectL_UI_HeroJobTransferUITask.<>f__mg$cache22 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroJobTransferUITask.<>f__mg$cache22 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroJobTransferUITask.__callBase_ClearUnusedDynamicResourceCache);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_HeroJobTransferUITask.<>f__mg$cache22);
		if (Lua_BlackJack_ProjectL_UI_HeroJobTransferUITask.<>f__mg$cache23 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroJobTransferUITask.<>f__mg$cache23 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroJobTransferUITask.__callBase_OnMemoryWarning);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_HeroJobTransferUITask.<>f__mg$cache23);
		string name = "m_layerDescArray";
		if (Lua_BlackJack_ProjectL_UI_HeroJobTransferUITask.<>f__mg$cache24 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroJobTransferUITask.<>f__mg$cache24 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroJobTransferUITask.get_m_layerDescArray);
		}
		LuaCSFunction get = Lua_BlackJack_ProjectL_UI_HeroJobTransferUITask.<>f__mg$cache24;
		if (Lua_BlackJack_ProjectL_UI_HeroJobTransferUITask.<>f__mg$cache25 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroJobTransferUITask.<>f__mg$cache25 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroJobTransferUITask.set_m_layerDescArray);
		}
		LuaObject.addMember(l, name, get, Lua_BlackJack_ProjectL_UI_HeroJobTransferUITask.<>f__mg$cache25, true);
		string name2 = "m_uiCtrlDescArray";
		if (Lua_BlackJack_ProjectL_UI_HeroJobTransferUITask.<>f__mg$cache26 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroJobTransferUITask.<>f__mg$cache26 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroJobTransferUITask.get_m_uiCtrlDescArray);
		}
		LuaCSFunction get2 = Lua_BlackJack_ProjectL_UI_HeroJobTransferUITask.<>f__mg$cache26;
		if (Lua_BlackJack_ProjectL_UI_HeroJobTransferUITask.<>f__mg$cache27 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroJobTransferUITask.<>f__mg$cache27 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroJobTransferUITask.set_m_uiCtrlDescArray);
		}
		LuaObject.addMember(l, name2, get2, Lua_BlackJack_ProjectL_UI_HeroJobTransferUITask.<>f__mg$cache27, true);
		string name3 = "m_hero";
		if (Lua_BlackJack_ProjectL_UI_HeroJobTransferUITask.<>f__mg$cache28 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroJobTransferUITask.<>f__mg$cache28 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroJobTransferUITask.get_m_hero);
		}
		LuaCSFunction get3 = Lua_BlackJack_ProjectL_UI_HeroJobTransferUITask.<>f__mg$cache28;
		if (Lua_BlackJack_ProjectL_UI_HeroJobTransferUITask.<>f__mg$cache29 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroJobTransferUITask.<>f__mg$cache29 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroJobTransferUITask.set_m_hero);
		}
		LuaObject.addMember(l, name3, get3, Lua_BlackJack_ProjectL_UI_HeroJobTransferUITask.<>f__mg$cache29, true);
		string name4 = "m_curJobConnectionInfo";
		if (Lua_BlackJack_ProjectL_UI_HeroJobTransferUITask.<>f__mg$cache2A == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroJobTransferUITask.<>f__mg$cache2A = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroJobTransferUITask.get_m_curJobConnectionInfo);
		}
		LuaCSFunction get4 = Lua_BlackJack_ProjectL_UI_HeroJobTransferUITask.<>f__mg$cache2A;
		if (Lua_BlackJack_ProjectL_UI_HeroJobTransferUITask.<>f__mg$cache2B == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroJobTransferUITask.<>f__mg$cache2B = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroJobTransferUITask.set_m_curJobConnectionInfo);
		}
		LuaObject.addMember(l, name4, get4, Lua_BlackJack_ProjectL_UI_HeroJobTransferUITask.<>f__mg$cache2B, true);
		string name5 = "m_heroJobTransferUIController";
		if (Lua_BlackJack_ProjectL_UI_HeroJobTransferUITask.<>f__mg$cache2C == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroJobTransferUITask.<>f__mg$cache2C = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroJobTransferUITask.get_m_heroJobTransferUIController);
		}
		LuaCSFunction get5 = Lua_BlackJack_ProjectL_UI_HeroJobTransferUITask.<>f__mg$cache2C;
		if (Lua_BlackJack_ProjectL_UI_HeroJobTransferUITask.<>f__mg$cache2D == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroJobTransferUITask.<>f__mg$cache2D = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroJobTransferUITask.set_m_heroJobTransferUIController);
		}
		LuaObject.addMember(l, name5, get5, Lua_BlackJack_ProjectL_UI_HeroJobTransferUITask.<>f__mg$cache2D, true);
		string name6 = "LayerDescArray";
		if (Lua_BlackJack_ProjectL_UI_HeroJobTransferUITask.<>f__mg$cache2E == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroJobTransferUITask.<>f__mg$cache2E = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroJobTransferUITask.get_LayerDescArray);
		}
		LuaObject.addMember(l, name6, Lua_BlackJack_ProjectL_UI_HeroJobTransferUITask.<>f__mg$cache2E, null, true);
		string name7 = "UICtrlDescArray";
		if (Lua_BlackJack_ProjectL_UI_HeroJobTransferUITask.<>f__mg$cache2F == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroJobTransferUITask.<>f__mg$cache2F = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroJobTransferUITask.get_UICtrlDescArray);
		}
		LuaObject.addMember(l, name7, Lua_BlackJack_ProjectL_UI_HeroJobTransferUITask.<>f__mg$cache2F, null, true);
		if (Lua_BlackJack_ProjectL_UI_HeroJobTransferUITask.<>f__mg$cache30 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroJobTransferUITask.<>f__mg$cache30 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroJobTransferUITask.constructor);
		}
		LuaObject.createTypeMetatable(l, Lua_BlackJack_ProjectL_UI_HeroJobTransferUITask.<>f__mg$cache30, typeof(HeroJobTransferUITask), typeof(UITask));
	}

	// Token: 0x0401542B RID: 87083
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache0;

	// Token: 0x0401542C RID: 87084
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1;

	// Token: 0x0401542D RID: 87085
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2;

	// Token: 0x0401542E RID: 87086
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3;

	// Token: 0x0401542F RID: 87087
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache4;

	// Token: 0x04015430 RID: 87088
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache5;

	// Token: 0x04015431 RID: 87089
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache6;

	// Token: 0x04015432 RID: 87090
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache7;

	// Token: 0x04015433 RID: 87091
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache8;

	// Token: 0x04015434 RID: 87092
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache9;

	// Token: 0x04015435 RID: 87093
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheA;

	// Token: 0x04015436 RID: 87094
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheB;

	// Token: 0x04015437 RID: 87095
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheC;

	// Token: 0x04015438 RID: 87096
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheD;

	// Token: 0x04015439 RID: 87097
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheE;

	// Token: 0x0401543A RID: 87098
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheF;

	// Token: 0x0401543B RID: 87099
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache10;

	// Token: 0x0401543C RID: 87100
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache11;

	// Token: 0x0401543D RID: 87101
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache12;

	// Token: 0x0401543E RID: 87102
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache13;

	// Token: 0x0401543F RID: 87103
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache14;

	// Token: 0x04015440 RID: 87104
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache15;

	// Token: 0x04015441 RID: 87105
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache16;

	// Token: 0x04015442 RID: 87106
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache17;

	// Token: 0x04015443 RID: 87107
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache18;

	// Token: 0x04015444 RID: 87108
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache19;

	// Token: 0x04015445 RID: 87109
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1A;

	// Token: 0x04015446 RID: 87110
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1B;

	// Token: 0x04015447 RID: 87111
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1C;

	// Token: 0x04015448 RID: 87112
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1D;

	// Token: 0x04015449 RID: 87113
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1E;

	// Token: 0x0401544A RID: 87114
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1F;

	// Token: 0x0401544B RID: 87115
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache20;

	// Token: 0x0401544C RID: 87116
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache21;

	// Token: 0x0401544D RID: 87117
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache22;

	// Token: 0x0401544E RID: 87118
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache23;

	// Token: 0x0401544F RID: 87119
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache24;

	// Token: 0x04015450 RID: 87120
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache25;

	// Token: 0x04015451 RID: 87121
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache26;

	// Token: 0x04015452 RID: 87122
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache27;

	// Token: 0x04015453 RID: 87123
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache28;

	// Token: 0x04015454 RID: 87124
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache29;

	// Token: 0x04015455 RID: 87125
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2A;

	// Token: 0x04015456 RID: 87126
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2B;

	// Token: 0x04015457 RID: 87127
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2C;

	// Token: 0x04015458 RID: 87128
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2D;

	// Token: 0x04015459 RID: 87129
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2E;

	// Token: 0x0401545A RID: 87130
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2F;

	// Token: 0x0401545B RID: 87131
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache30;
}
