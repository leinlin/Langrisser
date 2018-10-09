using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using BlackJack.BJFramework.Runtime.UI;
using BlackJack.ConfigData;
using BlackJack.ProjectL.UI;
using BlackJack.ProjectLBasic;
using SLua;
using UnityEngine.Scripting;

// Token: 0x020013A1 RID: 5025
[Preserve]
public class Lua_BlackJack_ProjectL_UI_BattleDialogUITask : LuaObject
{
	// Token: 0x0601B859 RID: 112729 RVA: 0x0085D100 File Offset: 0x0085B300
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int constructor(IntPtr l)
	{
		int result;
		try
		{
			string name;
			LuaObject.checkType(l, 2, out name);
			BattleDialogUITask o = new BattleDialogUITask(name);
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

	// Token: 0x0601B85A RID: 112730 RVA: 0x0085D154 File Offset: 0x0085B354
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int OnStart(IntPtr l)
	{
		int result;
		try
		{
			BattleDialogUITask battleDialogUITask = (BattleDialogUITask)LuaObject.checkSelf(l);
			UIIntent intent;
			LuaObject.checkType<UIIntent>(l, 2, out intent);
			bool b = battleDialogUITask.m_luaExportHelper.OnStart(intent);
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

	// Token: 0x0601B85B RID: 112731 RVA: 0x0085D1BC File Offset: 0x0085B3BC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int OnResume(IntPtr l)
	{
		int result;
		try
		{
			BattleDialogUITask battleDialogUITask = (BattleDialogUITask)LuaObject.checkSelf(l);
			UIIntent intent;
			LuaObject.checkType<UIIntent>(l, 2, out intent);
			bool b = battleDialogUITask.m_luaExportHelper.OnResume(intent);
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

	// Token: 0x0601B85C RID: 112732 RVA: 0x0085D224 File Offset: 0x0085B424
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int InitDataFromUIIntent(IntPtr l)
	{
		int result;
		try
		{
			BattleDialogUITask battleDialogUITask = (BattleDialogUITask)LuaObject.checkSelf(l);
			UIIntent intent;
			LuaObject.checkType<UIIntent>(l, 2, out intent);
			battleDialogUITask.m_luaExportHelper.InitDataFromUIIntent(intent);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601B85D RID: 112733 RVA: 0x0085D280 File Offset: 0x0085B480
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int IsNeedLoadDynamicRes(IntPtr l)
	{
		int result;
		try
		{
			BattleDialogUITask battleDialogUITask = (BattleDialogUITask)LuaObject.checkSelf(l);
			bool b = battleDialogUITask.m_luaExportHelper.IsNeedLoadDynamicRes();
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

	// Token: 0x0601B85E RID: 112734 RVA: 0x0085D2DC File Offset: 0x0085B4DC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int InitAllUIControllers(IntPtr l)
	{
		int result;
		try
		{
			BattleDialogUITask battleDialogUITask = (BattleDialogUITask)LuaObject.checkSelf(l);
			battleDialogUITask.m_luaExportHelper.InitAllUIControllers();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601B85F RID: 112735 RVA: 0x0085D330 File Offset: 0x0085B530
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int ClearAllContextAndRes(IntPtr l)
	{
		int result;
		try
		{
			BattleDialogUITask battleDialogUITask = (BattleDialogUITask)LuaObject.checkSelf(l);
			battleDialogUITask.m_luaExportHelper.ClearAllContextAndRes();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601B860 RID: 112736 RVA: 0x0085D384 File Offset: 0x0085B584
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int OnMemoryWarning(IntPtr l)
	{
		int result;
		try
		{
			BattleDialogUITask battleDialogUITask = (BattleDialogUITask)LuaObject.checkSelf(l);
			battleDialogUITask.m_luaExportHelper.OnMemoryWarning();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601B861 RID: 112737 RVA: 0x0085D3D8 File Offset: 0x0085B5D8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int UpdateView(IntPtr l)
	{
		int result;
		try
		{
			BattleDialogUITask battleDialogUITask = (BattleDialogUITask)LuaObject.checkSelf(l);
			battleDialogUITask.m_luaExportHelper.UpdateView();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601B862 RID: 112738 RVA: 0x0085D42C File Offset: 0x0085B62C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int InitBattleDialogUIController(IntPtr l)
	{
		int result;
		try
		{
			BattleDialogUITask battleDialogUITask = (BattleDialogUITask)LuaObject.checkSelf(l);
			battleDialogUITask.m_luaExportHelper.InitBattleDialogUIController();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601B863 RID: 112739 RVA: 0x0085D480 File Offset: 0x0085B680
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int UninitBattleDialogUIController(IntPtr l)
	{
		int result;
		try
		{
			BattleDialogUITask battleDialogUITask = (BattleDialogUITask)LuaObject.checkSelf(l);
			battleDialogUITask.m_luaExportHelper.UninitBattleDialogUIController();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601B864 RID: 112740 RVA: 0x0085D4D4 File Offset: 0x0085B6D4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int BattleDialogUIController_OnSkip(IntPtr l)
	{
		int result;
		try
		{
			BattleDialogUITask battleDialogUITask = (BattleDialogUITask)LuaObject.checkSelf(l);
			battleDialogUITask.m_luaExportHelper.BattleDialogUIController_OnSkip();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601B865 RID: 112741 RVA: 0x0085D528 File Offset: 0x0085B728
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int SkipDialogDialogBoxCallback(IntPtr l)
	{
		int result;
		try
		{
			BattleDialogUITask battleDialogUITask = (BattleDialogUITask)LuaObject.checkSelf(l);
			DialogBoxResult r;
			LuaObject.checkEnum<DialogBoxResult>(l, 2, out r);
			battleDialogUITask.m_luaExportHelper.SkipDialogDialogBoxCallback(r);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601B866 RID: 112742 RVA: 0x0085D584 File Offset: 0x0085B784
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int BattleDialogUIController_OnNext(IntPtr l)
	{
		int result;
		try
		{
			BattleDialogUITask battleDialogUITask = (BattleDialogUITask)LuaObject.checkSelf(l);
			battleDialogUITask.m_luaExportHelper.BattleDialogUIController_OnNext();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601B867 RID: 112743 RVA: 0x0085D5D8 File Offset: 0x0085B7D8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int BattleDialogUIController_OnClose(IntPtr l)
	{
		int result;
		try
		{
			BattleDialogUITask battleDialogUITask = (BattleDialogUITask)LuaObject.checkSelf(l);
			battleDialogUITask.m_luaExportHelper.BattleDialogUIController_OnClose();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601B868 RID: 112744 RVA: 0x0085D62C File Offset: 0x0085B82C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_OnStart(IntPtr l)
	{
		int result;
		try
		{
			BattleDialogUITask battleDialogUITask = (BattleDialogUITask)LuaObject.checkSelf(l);
			UIIntent intent;
			LuaObject.checkType<UIIntent>(l, 2, out intent);
			bool b = battleDialogUITask.m_luaExportHelper.__callBase_OnStart(intent);
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

	// Token: 0x0601B869 RID: 112745 RVA: 0x0085D694 File Offset: 0x0085B894
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_OnStop(IntPtr l)
	{
		int result;
		try
		{
			BattleDialogUITask battleDialogUITask = (BattleDialogUITask)LuaObject.checkSelf(l);
			battleDialogUITask.m_luaExportHelper.__callBase_OnStop();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601B86A RID: 112746 RVA: 0x0085D6E8 File Offset: 0x0085B8E8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_OnPause(IntPtr l)
	{
		int result;
		try
		{
			BattleDialogUITask battleDialogUITask = (BattleDialogUITask)LuaObject.checkSelf(l);
			battleDialogUITask.m_luaExportHelper.__callBase_OnPause();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601B86B RID: 112747 RVA: 0x0085D73C File Offset: 0x0085B93C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_OnResume(IntPtr l)
	{
		int result;
		try
		{
			BattleDialogUITask battleDialogUITask = (BattleDialogUITask)LuaObject.checkSelf(l);
			UIIntent intent;
			LuaObject.checkType<UIIntent>(l, 2, out intent);
			bool b = battleDialogUITask.m_luaExportHelper.__callBase_OnResume(intent);
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

	// Token: 0x0601B86C RID: 112748 RVA: 0x0085D7A4 File Offset: 0x0085B9A4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_OnNewIntent(IntPtr l)
	{
		int result;
		try
		{
			BattleDialogUITask battleDialogUITask = (BattleDialogUITask)LuaObject.checkSelf(l);
			UIIntent intent;
			LuaObject.checkType<UIIntent>(l, 2, out intent);
			bool b = battleDialogUITask.m_luaExportHelper.__callBase_OnNewIntent(intent);
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

	// Token: 0x0601B86D RID: 112749 RVA: 0x0085D80C File Offset: 0x0085BA0C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_EnableUIInput(IntPtr l)
	{
		int result;
		try
		{
			BattleDialogUITask battleDialogUITask = (BattleDialogUITask)LuaObject.checkSelf(l);
			bool isEnable;
			LuaObject.checkType(l, 2, out isEnable);
			bool? isGlobalEnable;
			LuaObject.checkNullable<bool>(l, 3, out isGlobalEnable);
			battleDialogUITask.m_luaExportHelper.__callBase_EnableUIInput(isEnable, isGlobalEnable);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601B86E RID: 112750 RVA: 0x0085D878 File Offset: 0x0085BA78
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_IsNeedLoadDynamicRes(IntPtr l)
	{
		int result;
		try
		{
			BattleDialogUITask battleDialogUITask = (BattleDialogUITask)LuaObject.checkSelf(l);
			bool b = battleDialogUITask.m_luaExportHelper.__callBase_IsNeedLoadDynamicRes();
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

	// Token: 0x0601B86F RID: 112751 RVA: 0x0085D8D4 File Offset: 0x0085BAD4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_CollectAllDynamicResForLoad(IntPtr l)
	{
		int result;
		try
		{
			BattleDialogUITask battleDialogUITask = (BattleDialogUITask)LuaObject.checkSelf(l);
			List<string> o = battleDialogUITask.m_luaExportHelper.__callBase_CollectAllDynamicResForLoad();
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

	// Token: 0x0601B870 RID: 112752 RVA: 0x0085D930 File Offset: 0x0085BB30
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_RegisterPlayerContextEvents(IntPtr l)
	{
		int result;
		try
		{
			BattleDialogUITask battleDialogUITask = (BattleDialogUITask)LuaObject.checkSelf(l);
			battleDialogUITask.m_luaExportHelper.__callBase_RegisterPlayerContextEvents();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601B871 RID: 112753 RVA: 0x0085D984 File Offset: 0x0085BB84
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_UnregisterPlayerContextEvents(IntPtr l)
	{
		int result;
		try
		{
			BattleDialogUITask battleDialogUITask = (BattleDialogUITask)LuaObject.checkSelf(l);
			battleDialogUITask.m_luaExportHelper.__callBase_UnregisterPlayerContextEvents();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601B872 RID: 112754 RVA: 0x0085D9D8 File Offset: 0x0085BBD8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_PostUpdateView(IntPtr l)
	{
		int result;
		try
		{
			BattleDialogUITask battleDialogUITask = (BattleDialogUITask)LuaObject.checkSelf(l);
			battleDialogUITask.m_luaExportHelper.__callBase_PostUpdateView();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601B873 RID: 112755 RVA: 0x0085DA2C File Offset: 0x0085BC2C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_CollectPreloadResourceList(IntPtr l)
	{
		int result;
		try
		{
			BattleDialogUITask battleDialogUITask = (BattleDialogUITask)LuaObject.checkSelf(l);
			battleDialogUITask.m_luaExportHelper.__callBase_CollectPreloadResourceList();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601B874 RID: 112756 RVA: 0x0085DA80 File Offset: 0x0085BC80
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_ClearAssetList(IntPtr l)
	{
		int result;
		try
		{
			BattleDialogUITask battleDialogUITask = (BattleDialogUITask)LuaObject.checkSelf(l);
			battleDialogUITask.m_luaExportHelper.__callBase_ClearAssetList();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601B875 RID: 112757 RVA: 0x0085DAD4 File Offset: 0x0085BCD4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_CollectAsset(IntPtr l)
	{
		int result;
		try
		{
			BattleDialogUITask battleDialogUITask = (BattleDialogUITask)LuaObject.checkSelf(l);
			string assetName;
			LuaObject.checkType(l, 2, out assetName);
			battleDialogUITask.m_luaExportHelper.__callBase_CollectAsset(assetName);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601B876 RID: 112758 RVA: 0x0085DB30 File Offset: 0x0085BD30
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_CollectSpriteAsset(IntPtr l)
	{
		int result;
		try
		{
			BattleDialogUITask battleDialogUITask = (BattleDialogUITask)LuaObject.checkSelf(l);
			string assetName;
			LuaObject.checkType(l, 2, out assetName);
			battleDialogUITask.m_luaExportHelper.__callBase_CollectSpriteAsset(assetName);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601B877 RID: 112759 RVA: 0x0085DB8C File Offset: 0x0085BD8C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_CollectFxAsset(IntPtr l)
	{
		int result;
		try
		{
			BattleDialogUITask battleDialogUITask = (BattleDialogUITask)LuaObject.checkSelf(l);
			string assetName;
			LuaObject.checkType(l, 2, out assetName);
			battleDialogUITask.m_luaExportHelper.__callBase_CollectFxAsset(assetName);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601B878 RID: 112760 RVA: 0x0085DBE8 File Offset: 0x0085BDE8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_StartLoadCustomAssets(IntPtr l)
	{
		int result;
		try
		{
			BattleDialogUITask battleDialogUITask = (BattleDialogUITask)LuaObject.checkSelf(l);
			Action onLoadCompleted;
			LuaObject.checkDelegate<Action>(l, 2, out onLoadCompleted);
			battleDialogUITask.m_luaExportHelper.__callBase_StartLoadCustomAssets(onLoadCompleted);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601B879 RID: 112761 RVA: 0x0085DC44 File Offset: 0x0085BE44
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_IsLoadingCustomAssets(IntPtr l)
	{
		int result;
		try
		{
			BattleDialogUITask battleDialogUITask = (BattleDialogUITask)LuaObject.checkSelf(l);
			bool b = battleDialogUITask.m_luaExportHelper.__callBase_IsLoadingCustomAssets();
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

	// Token: 0x0601B87A RID: 112762 RVA: 0x0085DCA0 File Offset: 0x0085BEA0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_IsPipeLineRunning(IntPtr l)
	{
		int result;
		try
		{
			BattleDialogUITask battleDialogUITask = (BattleDialogUITask)LuaObject.checkSelf(l);
			bool b = battleDialogUITask.m_luaExportHelper.__callBase_IsPipeLineRunning();
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

	// Token: 0x0601B87B RID: 112763 RVA: 0x0085DCFC File Offset: 0x0085BEFC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_IsOpeningUI(IntPtr l)
	{
		int result;
		try
		{
			BattleDialogUITask battleDialogUITask = (BattleDialogUITask)LuaObject.checkSelf(l);
			bool b = battleDialogUITask.m_luaExportHelper.__callBase_IsOpeningUI();
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

	// Token: 0x0601B87C RID: 112764 RVA: 0x0085DD58 File Offset: 0x0085BF58
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_ReturnPrevUITask(IntPtr l)
	{
		int result;
		try
		{
			BattleDialogUITask battleDialogUITask = (BattleDialogUITask)LuaObject.checkSelf(l);
			UITaskBase o = battleDialogUITask.m_luaExportHelper.__callBase_ReturnPrevUITask();
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

	// Token: 0x0601B87D RID: 112765 RVA: 0x0085DDB4 File Offset: 0x0085BFB4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_ClearUnusedDynamicResourceCache(IntPtr l)
	{
		int result;
		try
		{
			BattleDialogUITask battleDialogUITask = (BattleDialogUITask)LuaObject.checkSelf(l);
			battleDialogUITask.m_luaExportHelper.__callBase_ClearUnusedDynamicResourceCache();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601B87E RID: 112766 RVA: 0x0085DE08 File Offset: 0x0085C008
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_OnMemoryWarning(IntPtr l)
	{
		int result;
		try
		{
			BattleDialogUITask battleDialogUITask = (BattleDialogUITask)LuaObject.checkSelf(l);
			battleDialogUITask.m_luaExportHelper.__callBase_OnMemoryWarning();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601B87F RID: 112767 RVA: 0x0085DE5C File Offset: 0x0085C05C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callDele_EventOnClose(IntPtr l)
	{
		int result;
		try
		{
			BattleDialogUITask battleDialogUITask = (BattleDialogUITask)LuaObject.checkSelf(l);
			bool obj;
			LuaObject.checkType(l, 2, out obj);
			battleDialogUITask.m_luaExportHelper.__callDele_EventOnClose(obj);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601B880 RID: 112768 RVA: 0x0085DEB8 File Offset: 0x0085C0B8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __clearDele_EventOnClose(IntPtr l)
	{
		int result;
		try
		{
			BattleDialogUITask battleDialogUITask = (BattleDialogUITask)LuaObject.checkSelf(l);
			bool obj;
			LuaObject.checkType(l, 2, out obj);
			battleDialogUITask.m_luaExportHelper.__clearDele_EventOnClose(obj);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601B881 RID: 112769 RVA: 0x0085DF14 File Offset: 0x0085C114
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callDele_EventOnUserGuideClose(IntPtr l)
	{
		int result;
		try
		{
			BattleDialogUITask battleDialogUITask = (BattleDialogUITask)LuaObject.checkSelf(l);
			battleDialogUITask.m_luaExportHelper.__callDele_EventOnUserGuideClose();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601B882 RID: 112770 RVA: 0x0085DF68 File Offset: 0x0085C168
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __clearDele_EventOnUserGuideClose(IntPtr l)
	{
		int result;
		try
		{
			BattleDialogUITask battleDialogUITask = (BattleDialogUITask)LuaObject.checkSelf(l);
			battleDialogUITask.m_luaExportHelper.__clearDele_EventOnUserGuideClose();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601B883 RID: 112771 RVA: 0x0085DFBC File Offset: 0x0085C1BC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_EventOnClose(IntPtr l)
	{
		int result;
		try
		{
			BattleDialogUITask battleDialogUITask = (BattleDialogUITask)LuaObject.checkSelf(l);
			Action<bool> value;
			int num = LuaObject.checkDelegate<Action<bool>>(l, 2, out value);
			if (num != 0)
			{
				if (num == 1)
				{
					battleDialogUITask.EventOnClose += value;
				}
				else if (num == 2)
				{
					battleDialogUITask.EventOnClose -= value;
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

	// Token: 0x0601B884 RID: 112772 RVA: 0x0085E03C File Offset: 0x0085C23C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_EventOnUserGuideClose(IntPtr l)
	{
		int result;
		try
		{
			BattleDialogUITask battleDialogUITask = (BattleDialogUITask)LuaObject.checkSelf(l);
			Action value;
			int num = LuaObject.checkDelegate<Action>(l, 2, out value);
			if (num != 0)
			{
				if (num == 1)
				{
					battleDialogUITask.EventOnUserGuideClose += value;
				}
				else if (num == 2)
				{
					battleDialogUITask.EventOnUserGuideClose -= value;
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

	// Token: 0x0601B885 RID: 112773 RVA: 0x0085E0BC File Offset: 0x0085C2BC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_layerDescArray(IntPtr l)
	{
		int result;
		try
		{
			BattleDialogUITask battleDialogUITask = (BattleDialogUITask)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, battleDialogUITask.m_luaExportHelper.m_layerDescArray);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601B886 RID: 112774 RVA: 0x0085E114 File Offset: 0x0085C314
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_layerDescArray(IntPtr l)
	{
		int result;
		try
		{
			BattleDialogUITask battleDialogUITask = (BattleDialogUITask)LuaObject.checkSelf(l);
			UITaskBase.LayerDesc[] layerDescArray;
			LuaObject.checkArray<UITaskBase.LayerDesc>(l, 2, out layerDescArray);
			battleDialogUITask.m_luaExportHelper.m_layerDescArray = layerDescArray;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601B887 RID: 112775 RVA: 0x0085E170 File Offset: 0x0085C370
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_uiCtrlDescArray(IntPtr l)
	{
		int result;
		try
		{
			BattleDialogUITask battleDialogUITask = (BattleDialogUITask)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, battleDialogUITask.m_luaExportHelper.m_uiCtrlDescArray);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601B888 RID: 112776 RVA: 0x0085E1C8 File Offset: 0x0085C3C8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_uiCtrlDescArray(IntPtr l)
	{
		int result;
		try
		{
			BattleDialogUITask battleDialogUITask = (BattleDialogUITask)LuaObject.checkSelf(l);
			UITaskBase.UIControllerDesc[] uiCtrlDescArray;
			LuaObject.checkArray<UITaskBase.UIControllerDesc>(l, 2, out uiCtrlDescArray);
			battleDialogUITask.m_luaExportHelper.m_uiCtrlDescArray = uiCtrlDescArray;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601B889 RID: 112777 RVA: 0x0085E224 File Offset: 0x0085C424
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_battleDialogUIController(IntPtr l)
	{
		int result;
		try
		{
			BattleDialogUITask battleDialogUITask = (BattleDialogUITask)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, battleDialogUITask.m_luaExportHelper.m_battleDialogUIController);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601B88A RID: 112778 RVA: 0x0085E27C File Offset: 0x0085C47C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_battleDialogUIController(IntPtr l)
	{
		int result;
		try
		{
			BattleDialogUITask battleDialogUITask = (BattleDialogUITask)LuaObject.checkSelf(l);
			BattleDialogUIController battleDialogUIController;
			LuaObject.checkType<BattleDialogUIController>(l, 2, out battleDialogUIController);
			battleDialogUITask.m_luaExportHelper.m_battleDialogUIController = battleDialogUIController;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601B88B RID: 112779 RVA: 0x0085E2D8 File Offset: 0x0085C4D8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_battleDialogInfo(IntPtr l)
	{
		int result;
		try
		{
			BattleDialogUITask battleDialogUITask = (BattleDialogUITask)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, battleDialogUITask.m_luaExportHelper.m_battleDialogInfo);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601B88C RID: 112780 RVA: 0x0085E330 File Offset: 0x0085C530
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_battleDialogInfo(IntPtr l)
	{
		int result;
		try
		{
			BattleDialogUITask battleDialogUITask = (BattleDialogUITask)LuaObject.checkSelf(l);
			ConfigDataBattleDialogInfo battleDialogInfo;
			LuaObject.checkType<ConfigDataBattleDialogInfo>(l, 2, out battleDialogInfo);
			battleDialogUITask.m_luaExportHelper.m_battleDialogInfo = battleDialogInfo;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601B88D RID: 112781 RVA: 0x0085E38C File Offset: 0x0085C58C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_isSkipClose(IntPtr l)
	{
		int result;
		try
		{
			BattleDialogUITask battleDialogUITask = (BattleDialogUITask)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, battleDialogUITask.m_luaExportHelper.m_isSkipClose);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601B88E RID: 112782 RVA: 0x0085E3E4 File Offset: 0x0085C5E4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_isSkipClose(IntPtr l)
	{
		int result;
		try
		{
			BattleDialogUITask battleDialogUITask = (BattleDialogUITask)LuaObject.checkSelf(l);
			bool isSkipClose;
			LuaObject.checkType(l, 2, out isSkipClose);
			battleDialogUITask.m_luaExportHelper.m_isSkipClose = isSkipClose;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601B88F RID: 112783 RVA: 0x0085E440 File Offset: 0x0085C640
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_LayerDescArray(IntPtr l)
	{
		int result;
		try
		{
			BattleDialogUITask battleDialogUITask = (BattleDialogUITask)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, battleDialogUITask.m_luaExportHelper.LayerDescArray);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601B890 RID: 112784 RVA: 0x0085E498 File Offset: 0x0085C698
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_UICtrlDescArray(IntPtr l)
	{
		int result;
		try
		{
			BattleDialogUITask battleDialogUITask = (BattleDialogUITask)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, battleDialogUITask.m_luaExportHelper.UICtrlDescArray);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601B891 RID: 112785 RVA: 0x0085E4F0 File Offset: 0x0085C6F0
	[Preserve]
	public static void reg(IntPtr l)
	{
		LuaObject.getTypeTable(l, "BlackJack.ProjectL.UI.BattleDialogUITask");
		if (Lua_BlackJack_ProjectL_UI_BattleDialogUITask.<>f__mg$cache0 == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleDialogUITask.<>f__mg$cache0 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleDialogUITask.OnStart);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_BattleDialogUITask.<>f__mg$cache0);
		if (Lua_BlackJack_ProjectL_UI_BattleDialogUITask.<>f__mg$cache1 == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleDialogUITask.<>f__mg$cache1 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleDialogUITask.OnResume);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_BattleDialogUITask.<>f__mg$cache1);
		if (Lua_BlackJack_ProjectL_UI_BattleDialogUITask.<>f__mg$cache2 == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleDialogUITask.<>f__mg$cache2 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleDialogUITask.InitDataFromUIIntent);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_BattleDialogUITask.<>f__mg$cache2);
		if (Lua_BlackJack_ProjectL_UI_BattleDialogUITask.<>f__mg$cache3 == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleDialogUITask.<>f__mg$cache3 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleDialogUITask.IsNeedLoadDynamicRes);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_BattleDialogUITask.<>f__mg$cache3);
		if (Lua_BlackJack_ProjectL_UI_BattleDialogUITask.<>f__mg$cache4 == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleDialogUITask.<>f__mg$cache4 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleDialogUITask.InitAllUIControllers);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_BattleDialogUITask.<>f__mg$cache4);
		if (Lua_BlackJack_ProjectL_UI_BattleDialogUITask.<>f__mg$cache5 == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleDialogUITask.<>f__mg$cache5 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleDialogUITask.ClearAllContextAndRes);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_BattleDialogUITask.<>f__mg$cache5);
		if (Lua_BlackJack_ProjectL_UI_BattleDialogUITask.<>f__mg$cache6 == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleDialogUITask.<>f__mg$cache6 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleDialogUITask.OnMemoryWarning);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_BattleDialogUITask.<>f__mg$cache6);
		if (Lua_BlackJack_ProjectL_UI_BattleDialogUITask.<>f__mg$cache7 == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleDialogUITask.<>f__mg$cache7 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleDialogUITask.UpdateView);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_BattleDialogUITask.<>f__mg$cache7);
		if (Lua_BlackJack_ProjectL_UI_BattleDialogUITask.<>f__mg$cache8 == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleDialogUITask.<>f__mg$cache8 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleDialogUITask.InitBattleDialogUIController);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_BattleDialogUITask.<>f__mg$cache8);
		if (Lua_BlackJack_ProjectL_UI_BattleDialogUITask.<>f__mg$cache9 == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleDialogUITask.<>f__mg$cache9 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleDialogUITask.UninitBattleDialogUIController);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_BattleDialogUITask.<>f__mg$cache9);
		if (Lua_BlackJack_ProjectL_UI_BattleDialogUITask.<>f__mg$cacheA == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleDialogUITask.<>f__mg$cacheA = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleDialogUITask.BattleDialogUIController_OnSkip);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_BattleDialogUITask.<>f__mg$cacheA);
		if (Lua_BlackJack_ProjectL_UI_BattleDialogUITask.<>f__mg$cacheB == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleDialogUITask.<>f__mg$cacheB = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleDialogUITask.SkipDialogDialogBoxCallback);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_BattleDialogUITask.<>f__mg$cacheB);
		if (Lua_BlackJack_ProjectL_UI_BattleDialogUITask.<>f__mg$cacheC == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleDialogUITask.<>f__mg$cacheC = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleDialogUITask.BattleDialogUIController_OnNext);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_BattleDialogUITask.<>f__mg$cacheC);
		if (Lua_BlackJack_ProjectL_UI_BattleDialogUITask.<>f__mg$cacheD == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleDialogUITask.<>f__mg$cacheD = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleDialogUITask.BattleDialogUIController_OnClose);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_BattleDialogUITask.<>f__mg$cacheD);
		if (Lua_BlackJack_ProjectL_UI_BattleDialogUITask.<>f__mg$cacheE == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleDialogUITask.<>f__mg$cacheE = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleDialogUITask.__callBase_OnStart);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_BattleDialogUITask.<>f__mg$cacheE);
		if (Lua_BlackJack_ProjectL_UI_BattleDialogUITask.<>f__mg$cacheF == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleDialogUITask.<>f__mg$cacheF = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleDialogUITask.__callBase_OnStop);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_BattleDialogUITask.<>f__mg$cacheF);
		if (Lua_BlackJack_ProjectL_UI_BattleDialogUITask.<>f__mg$cache10 == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleDialogUITask.<>f__mg$cache10 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleDialogUITask.__callBase_OnPause);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_BattleDialogUITask.<>f__mg$cache10);
		if (Lua_BlackJack_ProjectL_UI_BattleDialogUITask.<>f__mg$cache11 == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleDialogUITask.<>f__mg$cache11 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleDialogUITask.__callBase_OnResume);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_BattleDialogUITask.<>f__mg$cache11);
		if (Lua_BlackJack_ProjectL_UI_BattleDialogUITask.<>f__mg$cache12 == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleDialogUITask.<>f__mg$cache12 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleDialogUITask.__callBase_OnNewIntent);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_BattleDialogUITask.<>f__mg$cache12);
		if (Lua_BlackJack_ProjectL_UI_BattleDialogUITask.<>f__mg$cache13 == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleDialogUITask.<>f__mg$cache13 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleDialogUITask.__callBase_EnableUIInput);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_BattleDialogUITask.<>f__mg$cache13);
		if (Lua_BlackJack_ProjectL_UI_BattleDialogUITask.<>f__mg$cache14 == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleDialogUITask.<>f__mg$cache14 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleDialogUITask.__callBase_IsNeedLoadDynamicRes);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_BattleDialogUITask.<>f__mg$cache14);
		if (Lua_BlackJack_ProjectL_UI_BattleDialogUITask.<>f__mg$cache15 == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleDialogUITask.<>f__mg$cache15 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleDialogUITask.__callBase_CollectAllDynamicResForLoad);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_BattleDialogUITask.<>f__mg$cache15);
		if (Lua_BlackJack_ProjectL_UI_BattleDialogUITask.<>f__mg$cache16 == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleDialogUITask.<>f__mg$cache16 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleDialogUITask.__callBase_RegisterPlayerContextEvents);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_BattleDialogUITask.<>f__mg$cache16);
		if (Lua_BlackJack_ProjectL_UI_BattleDialogUITask.<>f__mg$cache17 == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleDialogUITask.<>f__mg$cache17 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleDialogUITask.__callBase_UnregisterPlayerContextEvents);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_BattleDialogUITask.<>f__mg$cache17);
		if (Lua_BlackJack_ProjectL_UI_BattleDialogUITask.<>f__mg$cache18 == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleDialogUITask.<>f__mg$cache18 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleDialogUITask.__callBase_PostUpdateView);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_BattleDialogUITask.<>f__mg$cache18);
		if (Lua_BlackJack_ProjectL_UI_BattleDialogUITask.<>f__mg$cache19 == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleDialogUITask.<>f__mg$cache19 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleDialogUITask.__callBase_CollectPreloadResourceList);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_BattleDialogUITask.<>f__mg$cache19);
		if (Lua_BlackJack_ProjectL_UI_BattleDialogUITask.<>f__mg$cache1A == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleDialogUITask.<>f__mg$cache1A = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleDialogUITask.__callBase_ClearAssetList);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_BattleDialogUITask.<>f__mg$cache1A);
		if (Lua_BlackJack_ProjectL_UI_BattleDialogUITask.<>f__mg$cache1B == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleDialogUITask.<>f__mg$cache1B = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleDialogUITask.__callBase_CollectAsset);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_BattleDialogUITask.<>f__mg$cache1B);
		if (Lua_BlackJack_ProjectL_UI_BattleDialogUITask.<>f__mg$cache1C == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleDialogUITask.<>f__mg$cache1C = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleDialogUITask.__callBase_CollectSpriteAsset);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_BattleDialogUITask.<>f__mg$cache1C);
		if (Lua_BlackJack_ProjectL_UI_BattleDialogUITask.<>f__mg$cache1D == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleDialogUITask.<>f__mg$cache1D = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleDialogUITask.__callBase_CollectFxAsset);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_BattleDialogUITask.<>f__mg$cache1D);
		if (Lua_BlackJack_ProjectL_UI_BattleDialogUITask.<>f__mg$cache1E == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleDialogUITask.<>f__mg$cache1E = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleDialogUITask.__callBase_StartLoadCustomAssets);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_BattleDialogUITask.<>f__mg$cache1E);
		if (Lua_BlackJack_ProjectL_UI_BattleDialogUITask.<>f__mg$cache1F == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleDialogUITask.<>f__mg$cache1F = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleDialogUITask.__callBase_IsLoadingCustomAssets);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_BattleDialogUITask.<>f__mg$cache1F);
		if (Lua_BlackJack_ProjectL_UI_BattleDialogUITask.<>f__mg$cache20 == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleDialogUITask.<>f__mg$cache20 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleDialogUITask.__callBase_IsPipeLineRunning);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_BattleDialogUITask.<>f__mg$cache20);
		if (Lua_BlackJack_ProjectL_UI_BattleDialogUITask.<>f__mg$cache21 == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleDialogUITask.<>f__mg$cache21 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleDialogUITask.__callBase_IsOpeningUI);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_BattleDialogUITask.<>f__mg$cache21);
		if (Lua_BlackJack_ProjectL_UI_BattleDialogUITask.<>f__mg$cache22 == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleDialogUITask.<>f__mg$cache22 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleDialogUITask.__callBase_ReturnPrevUITask);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_BattleDialogUITask.<>f__mg$cache22);
		if (Lua_BlackJack_ProjectL_UI_BattleDialogUITask.<>f__mg$cache23 == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleDialogUITask.<>f__mg$cache23 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleDialogUITask.__callBase_ClearUnusedDynamicResourceCache);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_BattleDialogUITask.<>f__mg$cache23);
		if (Lua_BlackJack_ProjectL_UI_BattleDialogUITask.<>f__mg$cache24 == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleDialogUITask.<>f__mg$cache24 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleDialogUITask.__callBase_OnMemoryWarning);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_BattleDialogUITask.<>f__mg$cache24);
		if (Lua_BlackJack_ProjectL_UI_BattleDialogUITask.<>f__mg$cache25 == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleDialogUITask.<>f__mg$cache25 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleDialogUITask.__callDele_EventOnClose);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_BattleDialogUITask.<>f__mg$cache25);
		if (Lua_BlackJack_ProjectL_UI_BattleDialogUITask.<>f__mg$cache26 == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleDialogUITask.<>f__mg$cache26 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleDialogUITask.__clearDele_EventOnClose);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_BattleDialogUITask.<>f__mg$cache26);
		if (Lua_BlackJack_ProjectL_UI_BattleDialogUITask.<>f__mg$cache27 == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleDialogUITask.<>f__mg$cache27 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleDialogUITask.__callDele_EventOnUserGuideClose);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_BattleDialogUITask.<>f__mg$cache27);
		if (Lua_BlackJack_ProjectL_UI_BattleDialogUITask.<>f__mg$cache28 == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleDialogUITask.<>f__mg$cache28 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleDialogUITask.__clearDele_EventOnUserGuideClose);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_BattleDialogUITask.<>f__mg$cache28);
		string name = "EventOnClose";
		LuaCSFunction get = null;
		if (Lua_BlackJack_ProjectL_UI_BattleDialogUITask.<>f__mg$cache29 == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleDialogUITask.<>f__mg$cache29 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleDialogUITask.set_EventOnClose);
		}
		LuaObject.addMember(l, name, get, Lua_BlackJack_ProjectL_UI_BattleDialogUITask.<>f__mg$cache29, true);
		string name2 = "EventOnUserGuideClose";
		LuaCSFunction get2 = null;
		if (Lua_BlackJack_ProjectL_UI_BattleDialogUITask.<>f__mg$cache2A == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleDialogUITask.<>f__mg$cache2A = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleDialogUITask.set_EventOnUserGuideClose);
		}
		LuaObject.addMember(l, name2, get2, Lua_BlackJack_ProjectL_UI_BattleDialogUITask.<>f__mg$cache2A, true);
		string name3 = "m_layerDescArray";
		if (Lua_BlackJack_ProjectL_UI_BattleDialogUITask.<>f__mg$cache2B == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleDialogUITask.<>f__mg$cache2B = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleDialogUITask.get_m_layerDescArray);
		}
		LuaCSFunction get3 = Lua_BlackJack_ProjectL_UI_BattleDialogUITask.<>f__mg$cache2B;
		if (Lua_BlackJack_ProjectL_UI_BattleDialogUITask.<>f__mg$cache2C == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleDialogUITask.<>f__mg$cache2C = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleDialogUITask.set_m_layerDescArray);
		}
		LuaObject.addMember(l, name3, get3, Lua_BlackJack_ProjectL_UI_BattleDialogUITask.<>f__mg$cache2C, true);
		string name4 = "m_uiCtrlDescArray";
		if (Lua_BlackJack_ProjectL_UI_BattleDialogUITask.<>f__mg$cache2D == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleDialogUITask.<>f__mg$cache2D = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleDialogUITask.get_m_uiCtrlDescArray);
		}
		LuaCSFunction get4 = Lua_BlackJack_ProjectL_UI_BattleDialogUITask.<>f__mg$cache2D;
		if (Lua_BlackJack_ProjectL_UI_BattleDialogUITask.<>f__mg$cache2E == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleDialogUITask.<>f__mg$cache2E = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleDialogUITask.set_m_uiCtrlDescArray);
		}
		LuaObject.addMember(l, name4, get4, Lua_BlackJack_ProjectL_UI_BattleDialogUITask.<>f__mg$cache2E, true);
		string name5 = "m_battleDialogUIController";
		if (Lua_BlackJack_ProjectL_UI_BattleDialogUITask.<>f__mg$cache2F == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleDialogUITask.<>f__mg$cache2F = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleDialogUITask.get_m_battleDialogUIController);
		}
		LuaCSFunction get5 = Lua_BlackJack_ProjectL_UI_BattleDialogUITask.<>f__mg$cache2F;
		if (Lua_BlackJack_ProjectL_UI_BattleDialogUITask.<>f__mg$cache30 == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleDialogUITask.<>f__mg$cache30 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleDialogUITask.set_m_battleDialogUIController);
		}
		LuaObject.addMember(l, name5, get5, Lua_BlackJack_ProjectL_UI_BattleDialogUITask.<>f__mg$cache30, true);
		string name6 = "m_battleDialogInfo";
		if (Lua_BlackJack_ProjectL_UI_BattleDialogUITask.<>f__mg$cache31 == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleDialogUITask.<>f__mg$cache31 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleDialogUITask.get_m_battleDialogInfo);
		}
		LuaCSFunction get6 = Lua_BlackJack_ProjectL_UI_BattleDialogUITask.<>f__mg$cache31;
		if (Lua_BlackJack_ProjectL_UI_BattleDialogUITask.<>f__mg$cache32 == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleDialogUITask.<>f__mg$cache32 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleDialogUITask.set_m_battleDialogInfo);
		}
		LuaObject.addMember(l, name6, get6, Lua_BlackJack_ProjectL_UI_BattleDialogUITask.<>f__mg$cache32, true);
		string name7 = "m_isSkipClose";
		if (Lua_BlackJack_ProjectL_UI_BattleDialogUITask.<>f__mg$cache33 == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleDialogUITask.<>f__mg$cache33 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleDialogUITask.get_m_isSkipClose);
		}
		LuaCSFunction get7 = Lua_BlackJack_ProjectL_UI_BattleDialogUITask.<>f__mg$cache33;
		if (Lua_BlackJack_ProjectL_UI_BattleDialogUITask.<>f__mg$cache34 == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleDialogUITask.<>f__mg$cache34 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleDialogUITask.set_m_isSkipClose);
		}
		LuaObject.addMember(l, name7, get7, Lua_BlackJack_ProjectL_UI_BattleDialogUITask.<>f__mg$cache34, true);
		string name8 = "LayerDescArray";
		if (Lua_BlackJack_ProjectL_UI_BattleDialogUITask.<>f__mg$cache35 == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleDialogUITask.<>f__mg$cache35 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleDialogUITask.get_LayerDescArray);
		}
		LuaObject.addMember(l, name8, Lua_BlackJack_ProjectL_UI_BattleDialogUITask.<>f__mg$cache35, null, true);
		string name9 = "UICtrlDescArray";
		if (Lua_BlackJack_ProjectL_UI_BattleDialogUITask.<>f__mg$cache36 == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleDialogUITask.<>f__mg$cache36 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleDialogUITask.get_UICtrlDescArray);
		}
		LuaObject.addMember(l, name9, Lua_BlackJack_ProjectL_UI_BattleDialogUITask.<>f__mg$cache36, null, true);
		if (Lua_BlackJack_ProjectL_UI_BattleDialogUITask.<>f__mg$cache37 == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleDialogUITask.<>f__mg$cache37 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleDialogUITask.constructor);
		}
		LuaObject.createTypeMetatable(l, Lua_BlackJack_ProjectL_UI_BattleDialogUITask.<>f__mg$cache37, typeof(BattleDialogUITask), typeof(UITask));
	}

	// Token: 0x04011AF9 RID: 72441
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache0;

	// Token: 0x04011AFA RID: 72442
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1;

	// Token: 0x04011AFB RID: 72443
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2;

	// Token: 0x04011AFC RID: 72444
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3;

	// Token: 0x04011AFD RID: 72445
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache4;

	// Token: 0x04011AFE RID: 72446
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache5;

	// Token: 0x04011AFF RID: 72447
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache6;

	// Token: 0x04011B00 RID: 72448
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache7;

	// Token: 0x04011B01 RID: 72449
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache8;

	// Token: 0x04011B02 RID: 72450
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache9;

	// Token: 0x04011B03 RID: 72451
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheA;

	// Token: 0x04011B04 RID: 72452
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheB;

	// Token: 0x04011B05 RID: 72453
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheC;

	// Token: 0x04011B06 RID: 72454
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheD;

	// Token: 0x04011B07 RID: 72455
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheE;

	// Token: 0x04011B08 RID: 72456
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheF;

	// Token: 0x04011B09 RID: 72457
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache10;

	// Token: 0x04011B0A RID: 72458
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache11;

	// Token: 0x04011B0B RID: 72459
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache12;

	// Token: 0x04011B0C RID: 72460
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache13;

	// Token: 0x04011B0D RID: 72461
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache14;

	// Token: 0x04011B0E RID: 72462
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache15;

	// Token: 0x04011B0F RID: 72463
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache16;

	// Token: 0x04011B10 RID: 72464
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache17;

	// Token: 0x04011B11 RID: 72465
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache18;

	// Token: 0x04011B12 RID: 72466
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache19;

	// Token: 0x04011B13 RID: 72467
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1A;

	// Token: 0x04011B14 RID: 72468
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1B;

	// Token: 0x04011B15 RID: 72469
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1C;

	// Token: 0x04011B16 RID: 72470
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1D;

	// Token: 0x04011B17 RID: 72471
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1E;

	// Token: 0x04011B18 RID: 72472
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1F;

	// Token: 0x04011B19 RID: 72473
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache20;

	// Token: 0x04011B1A RID: 72474
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache21;

	// Token: 0x04011B1B RID: 72475
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache22;

	// Token: 0x04011B1C RID: 72476
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache23;

	// Token: 0x04011B1D RID: 72477
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache24;

	// Token: 0x04011B1E RID: 72478
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache25;

	// Token: 0x04011B1F RID: 72479
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache26;

	// Token: 0x04011B20 RID: 72480
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache27;

	// Token: 0x04011B21 RID: 72481
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache28;

	// Token: 0x04011B22 RID: 72482
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache29;

	// Token: 0x04011B23 RID: 72483
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2A;

	// Token: 0x04011B24 RID: 72484
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2B;

	// Token: 0x04011B25 RID: 72485
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2C;

	// Token: 0x04011B26 RID: 72486
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2D;

	// Token: 0x04011B27 RID: 72487
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2E;

	// Token: 0x04011B28 RID: 72488
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2F;

	// Token: 0x04011B29 RID: 72489
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache30;

	// Token: 0x04011B2A RID: 72490
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache31;

	// Token: 0x04011B2B RID: 72491
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache32;

	// Token: 0x04011B2C RID: 72492
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache33;

	// Token: 0x04011B2D RID: 72493
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache34;

	// Token: 0x04011B2E RID: 72494
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache35;

	// Token: 0x04011B2F RID: 72495
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache36;

	// Token: 0x04011B30 RID: 72496
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache37;
}
