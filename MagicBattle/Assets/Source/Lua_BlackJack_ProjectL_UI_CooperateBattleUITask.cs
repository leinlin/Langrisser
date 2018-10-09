using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using BlackJack.BJFramework.Runtime.UI;
using BlackJack.ConfigData;
using BlackJack.ProjectL.UI;
using SLua;
using UnityEngine.Scripting;

// Token: 0x02001409 RID: 5129
[Preserve]
public class Lua_BlackJack_ProjectL_UI_CooperateBattleUITask : LuaObject
{
	// Token: 0x0601CF72 RID: 118642 RVA: 0x00914984 File Offset: 0x00912B84
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int constructor(IntPtr l)
	{
		int result;
		try
		{
			string name;
			LuaObject.checkType(l, 2, out name);
			CooperateBattleUITask o = new CooperateBattleUITask(name);
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

	// Token: 0x0601CF73 RID: 118643 RVA: 0x009149D8 File Offset: 0x00912BD8
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int OnStart(IntPtr l)
	{
		int result;
		try
		{
			CooperateBattleUITask cooperateBattleUITask = (CooperateBattleUITask)LuaObject.checkSelf(l);
			UIIntent intent;
			LuaObject.checkType<UIIntent>(l, 2, out intent);
			bool b = cooperateBattleUITask.m_luaExportHelper.OnStart(intent);
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

	// Token: 0x0601CF74 RID: 118644 RVA: 0x00914A40 File Offset: 0x00912C40
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int OnResume(IntPtr l)
	{
		int result;
		try
		{
			CooperateBattleUITask cooperateBattleUITask = (CooperateBattleUITask)LuaObject.checkSelf(l);
			UIIntent intent;
			LuaObject.checkType<UIIntent>(l, 2, out intent);
			bool b = cooperateBattleUITask.m_luaExportHelper.OnResume(intent);
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

	// Token: 0x0601CF75 RID: 118645 RVA: 0x00914AA8 File Offset: 0x00912CA8
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int InitDataFromUIIntent(IntPtr l)
	{
		int result;
		try
		{
			CooperateBattleUITask cooperateBattleUITask = (CooperateBattleUITask)LuaObject.checkSelf(l);
			UIIntent intent;
			LuaObject.checkType<UIIntent>(l, 2, out intent);
			cooperateBattleUITask.m_luaExportHelper.InitDataFromUIIntent(intent);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601CF76 RID: 118646 RVA: 0x00914B04 File Offset: 0x00912D04
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int IsNeedLoadDynamicRes(IntPtr l)
	{
		int result;
		try
		{
			CooperateBattleUITask cooperateBattleUITask = (CooperateBattleUITask)LuaObject.checkSelf(l);
			bool b = cooperateBattleUITask.m_luaExportHelper.IsNeedLoadDynamicRes();
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

	// Token: 0x0601CF77 RID: 118647 RVA: 0x00914B60 File Offset: 0x00912D60
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int InitAllUIControllers(IntPtr l)
	{
		int result;
		try
		{
			CooperateBattleUITask cooperateBattleUITask = (CooperateBattleUITask)LuaObject.checkSelf(l);
			cooperateBattleUITask.m_luaExportHelper.InitAllUIControllers();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601CF78 RID: 118648 RVA: 0x00914BB4 File Offset: 0x00912DB4
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int ClearAllContextAndRes(IntPtr l)
	{
		int result;
		try
		{
			CooperateBattleUITask cooperateBattleUITask = (CooperateBattleUITask)LuaObject.checkSelf(l);
			cooperateBattleUITask.m_luaExportHelper.ClearAllContextAndRes();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601CF79 RID: 118649 RVA: 0x00914C08 File Offset: 0x00912E08
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int InitCooperateBattleUIController(IntPtr l)
	{
		int result;
		try
		{
			CooperateBattleUITask cooperateBattleUITask = (CooperateBattleUITask)LuaObject.checkSelf(l);
			cooperateBattleUITask.m_luaExportHelper.InitCooperateBattleUIController();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601CF7A RID: 118650 RVA: 0x00914C5C File Offset: 0x00912E5C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int UninitCooperateBattleUIController(IntPtr l)
	{
		int result;
		try
		{
			CooperateBattleUITask cooperateBattleUITask = (CooperateBattleUITask)LuaObject.checkSelf(l);
			cooperateBattleUITask.m_luaExportHelper.UninitCooperateBattleUIController();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601CF7B RID: 118651 RVA: 0x00914CB0 File Offset: 0x00912EB0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int UpdateView(IntPtr l)
	{
		int result;
		try
		{
			CooperateBattleUITask cooperateBattleUITask = (CooperateBattleUITask)LuaObject.checkSelf(l);
			cooperateBattleUITask.m_luaExportHelper.UpdateView();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601CF7C RID: 118652 RVA: 0x00914D04 File Offset: 0x00912F04
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int CooperateBattleUIController_OnReturn(IntPtr l)
	{
		int result;
		try
		{
			CooperateBattleUITask cooperateBattleUITask = (CooperateBattleUITask)LuaObject.checkSelf(l);
			cooperateBattleUITask.m_luaExportHelper.CooperateBattleUIController_OnReturn();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601CF7D RID: 118653 RVA: 0x00914D58 File Offset: 0x00912F58
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int CooperateBattleUIController_OnShowHelp(IntPtr l)
	{
		int result;
		try
		{
			CooperateBattleUITask cooperateBattleUITask = (CooperateBattleUITask)LuaObject.checkSelf(l);
			cooperateBattleUITask.m_luaExportHelper.CooperateBattleUIController_OnShowHelp();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601CF7E RID: 118654 RVA: 0x00914DAC File Offset: 0x00912FAC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int CooperateBattleUIController_OnAddTicket(IntPtr l)
	{
		int result;
		try
		{
			CooperateBattleUITask cooperateBattleUITask = (CooperateBattleUITask)LuaObject.checkSelf(l);
			cooperateBattleUITask.m_luaExportHelper.CooperateBattleUIController_OnAddTicket();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601CF7F RID: 118655 RVA: 0x00914E00 File Offset: 0x00913000
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int CooperateBattleUIController_OnShowTeam(IntPtr l)
	{
		int result;
		try
		{
			CooperateBattleUITask cooperateBattleUITask = (CooperateBattleUITask)LuaObject.checkSelf(l);
			cooperateBattleUITask.m_luaExportHelper.CooperateBattleUIController_OnShowTeam();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601CF80 RID: 118656 RVA: 0x00914E54 File Offset: 0x00913054
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int TeamUITask_OnLoadAllResCompleted(IntPtr l)
	{
		int result;
		try
		{
			CooperateBattleUITask cooperateBattleUITask = (CooperateBattleUITask)LuaObject.checkSelf(l);
			cooperateBattleUITask.m_luaExportHelper.TeamUITask_OnLoadAllResCompleted();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601CF81 RID: 118657 RVA: 0x00914EA8 File Offset: 0x009130A8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int CooperateBattleUIController_OnStartCooperateBattleLevel(IntPtr l)
	{
		int result;
		try
		{
			CooperateBattleUITask cooperateBattleUITask = (CooperateBattleUITask)LuaObject.checkSelf(l);
			ConfigDataCooperateBattleLevelInfo levelInfo;
			LuaObject.checkType<ConfigDataCooperateBattleLevelInfo>(l, 2, out levelInfo);
			cooperateBattleUITask.m_luaExportHelper.CooperateBattleUIController_OnStartCooperateBattleLevel(levelInfo);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601CF82 RID: 118658 RVA: 0x00914F04 File Offset: 0x00913104
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_OnStart(IntPtr l)
	{
		int result;
		try
		{
			CooperateBattleUITask cooperateBattleUITask = (CooperateBattleUITask)LuaObject.checkSelf(l);
			UIIntent intent;
			LuaObject.checkType<UIIntent>(l, 2, out intent);
			bool b = cooperateBattleUITask.m_luaExportHelper.__callBase_OnStart(intent);
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

	// Token: 0x0601CF83 RID: 118659 RVA: 0x00914F6C File Offset: 0x0091316C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_OnStop(IntPtr l)
	{
		int result;
		try
		{
			CooperateBattleUITask cooperateBattleUITask = (CooperateBattleUITask)LuaObject.checkSelf(l);
			cooperateBattleUITask.m_luaExportHelper.__callBase_OnStop();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601CF84 RID: 118660 RVA: 0x00914FC0 File Offset: 0x009131C0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_OnPause(IntPtr l)
	{
		int result;
		try
		{
			CooperateBattleUITask cooperateBattleUITask = (CooperateBattleUITask)LuaObject.checkSelf(l);
			cooperateBattleUITask.m_luaExportHelper.__callBase_OnPause();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601CF85 RID: 118661 RVA: 0x00915014 File Offset: 0x00913214
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int __callBase_OnResume(IntPtr l)
	{
		int result;
		try
		{
			CooperateBattleUITask cooperateBattleUITask = (CooperateBattleUITask)LuaObject.checkSelf(l);
			UIIntent intent;
			LuaObject.checkType<UIIntent>(l, 2, out intent);
			bool b = cooperateBattleUITask.m_luaExportHelper.__callBase_OnResume(intent);
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

	// Token: 0x0601CF86 RID: 118662 RVA: 0x0091507C File Offset: 0x0091327C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_OnNewIntent(IntPtr l)
	{
		int result;
		try
		{
			CooperateBattleUITask cooperateBattleUITask = (CooperateBattleUITask)LuaObject.checkSelf(l);
			UIIntent intent;
			LuaObject.checkType<UIIntent>(l, 2, out intent);
			bool b = cooperateBattleUITask.m_luaExportHelper.__callBase_OnNewIntent(intent);
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

	// Token: 0x0601CF87 RID: 118663 RVA: 0x009150E4 File Offset: 0x009132E4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_EnableUIInput(IntPtr l)
	{
		int result;
		try
		{
			CooperateBattleUITask cooperateBattleUITask = (CooperateBattleUITask)LuaObject.checkSelf(l);
			bool isEnable;
			LuaObject.checkType(l, 2, out isEnable);
			bool? isGlobalEnable;
			LuaObject.checkNullable<bool>(l, 3, out isGlobalEnable);
			cooperateBattleUITask.m_luaExportHelper.__callBase_EnableUIInput(isEnable, isGlobalEnable);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601CF88 RID: 118664 RVA: 0x00915150 File Offset: 0x00913350
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_IsNeedLoadDynamicRes(IntPtr l)
	{
		int result;
		try
		{
			CooperateBattleUITask cooperateBattleUITask = (CooperateBattleUITask)LuaObject.checkSelf(l);
			bool b = cooperateBattleUITask.m_luaExportHelper.__callBase_IsNeedLoadDynamicRes();
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

	// Token: 0x0601CF89 RID: 118665 RVA: 0x009151AC File Offset: 0x009133AC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_CollectAllDynamicResForLoad(IntPtr l)
	{
		int result;
		try
		{
			CooperateBattleUITask cooperateBattleUITask = (CooperateBattleUITask)LuaObject.checkSelf(l);
			List<string> o = cooperateBattleUITask.m_luaExportHelper.__callBase_CollectAllDynamicResForLoad();
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

	// Token: 0x0601CF8A RID: 118666 RVA: 0x00915208 File Offset: 0x00913408
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_RegisterPlayerContextEvents(IntPtr l)
	{
		int result;
		try
		{
			CooperateBattleUITask cooperateBattleUITask = (CooperateBattleUITask)LuaObject.checkSelf(l);
			cooperateBattleUITask.m_luaExportHelper.__callBase_RegisterPlayerContextEvents();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601CF8B RID: 118667 RVA: 0x0091525C File Offset: 0x0091345C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_UnregisterPlayerContextEvents(IntPtr l)
	{
		int result;
		try
		{
			CooperateBattleUITask cooperateBattleUITask = (CooperateBattleUITask)LuaObject.checkSelf(l);
			cooperateBattleUITask.m_luaExportHelper.__callBase_UnregisterPlayerContextEvents();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601CF8C RID: 118668 RVA: 0x009152B0 File Offset: 0x009134B0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_PostUpdateView(IntPtr l)
	{
		int result;
		try
		{
			CooperateBattleUITask cooperateBattleUITask = (CooperateBattleUITask)LuaObject.checkSelf(l);
			cooperateBattleUITask.m_luaExportHelper.__callBase_PostUpdateView();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601CF8D RID: 118669 RVA: 0x00915304 File Offset: 0x00913504
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_CollectPreloadResourceList(IntPtr l)
	{
		int result;
		try
		{
			CooperateBattleUITask cooperateBattleUITask = (CooperateBattleUITask)LuaObject.checkSelf(l);
			cooperateBattleUITask.m_luaExportHelper.__callBase_CollectPreloadResourceList();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601CF8E RID: 118670 RVA: 0x00915358 File Offset: 0x00913558
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_ClearAssetList(IntPtr l)
	{
		int result;
		try
		{
			CooperateBattleUITask cooperateBattleUITask = (CooperateBattleUITask)LuaObject.checkSelf(l);
			cooperateBattleUITask.m_luaExportHelper.__callBase_ClearAssetList();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601CF8F RID: 118671 RVA: 0x009153AC File Offset: 0x009135AC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_CollectAsset(IntPtr l)
	{
		int result;
		try
		{
			CooperateBattleUITask cooperateBattleUITask = (CooperateBattleUITask)LuaObject.checkSelf(l);
			string assetName;
			LuaObject.checkType(l, 2, out assetName);
			cooperateBattleUITask.m_luaExportHelper.__callBase_CollectAsset(assetName);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601CF90 RID: 118672 RVA: 0x00915408 File Offset: 0x00913608
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_CollectSpriteAsset(IntPtr l)
	{
		int result;
		try
		{
			CooperateBattleUITask cooperateBattleUITask = (CooperateBattleUITask)LuaObject.checkSelf(l);
			string assetName;
			LuaObject.checkType(l, 2, out assetName);
			cooperateBattleUITask.m_luaExportHelper.__callBase_CollectSpriteAsset(assetName);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601CF91 RID: 118673 RVA: 0x00915464 File Offset: 0x00913664
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_CollectFxAsset(IntPtr l)
	{
		int result;
		try
		{
			CooperateBattleUITask cooperateBattleUITask = (CooperateBattleUITask)LuaObject.checkSelf(l);
			string assetName;
			LuaObject.checkType(l, 2, out assetName);
			cooperateBattleUITask.m_luaExportHelper.__callBase_CollectFxAsset(assetName);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601CF92 RID: 118674 RVA: 0x009154C0 File Offset: 0x009136C0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_StartLoadCustomAssets(IntPtr l)
	{
		int result;
		try
		{
			CooperateBattleUITask cooperateBattleUITask = (CooperateBattleUITask)LuaObject.checkSelf(l);
			Action onLoadCompleted;
			LuaObject.checkDelegate<Action>(l, 2, out onLoadCompleted);
			cooperateBattleUITask.m_luaExportHelper.__callBase_StartLoadCustomAssets(onLoadCompleted);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601CF93 RID: 118675 RVA: 0x0091551C File Offset: 0x0091371C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_IsLoadingCustomAssets(IntPtr l)
	{
		int result;
		try
		{
			CooperateBattleUITask cooperateBattleUITask = (CooperateBattleUITask)LuaObject.checkSelf(l);
			bool b = cooperateBattleUITask.m_luaExportHelper.__callBase_IsLoadingCustomAssets();
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

	// Token: 0x0601CF94 RID: 118676 RVA: 0x00915578 File Offset: 0x00913778
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_IsPipeLineRunning(IntPtr l)
	{
		int result;
		try
		{
			CooperateBattleUITask cooperateBattleUITask = (CooperateBattleUITask)LuaObject.checkSelf(l);
			bool b = cooperateBattleUITask.m_luaExportHelper.__callBase_IsPipeLineRunning();
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

	// Token: 0x0601CF95 RID: 118677 RVA: 0x009155D4 File Offset: 0x009137D4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_IsOpeningUI(IntPtr l)
	{
		int result;
		try
		{
			CooperateBattleUITask cooperateBattleUITask = (CooperateBattleUITask)LuaObject.checkSelf(l);
			bool b = cooperateBattleUITask.m_luaExportHelper.__callBase_IsOpeningUI();
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

	// Token: 0x0601CF96 RID: 118678 RVA: 0x00915630 File Offset: 0x00913830
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_ReturnPrevUITask(IntPtr l)
	{
		int result;
		try
		{
			CooperateBattleUITask cooperateBattleUITask = (CooperateBattleUITask)LuaObject.checkSelf(l);
			UITaskBase o = cooperateBattleUITask.m_luaExportHelper.__callBase_ReturnPrevUITask();
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

	// Token: 0x0601CF97 RID: 118679 RVA: 0x0091568C File Offset: 0x0091388C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_ClearUnusedDynamicResourceCache(IntPtr l)
	{
		int result;
		try
		{
			CooperateBattleUITask cooperateBattleUITask = (CooperateBattleUITask)LuaObject.checkSelf(l);
			cooperateBattleUITask.m_luaExportHelper.__callBase_ClearUnusedDynamicResourceCache();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601CF98 RID: 118680 RVA: 0x009156E0 File Offset: 0x009138E0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_OnMemoryWarning(IntPtr l)
	{
		int result;
		try
		{
			CooperateBattleUITask cooperateBattleUITask = (CooperateBattleUITask)LuaObject.checkSelf(l);
			cooperateBattleUITask.m_luaExportHelper.__callBase_OnMemoryWarning();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601CF99 RID: 118681 RVA: 0x00915734 File Offset: 0x00913934
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_layerDescArray(IntPtr l)
	{
		int result;
		try
		{
			CooperateBattleUITask cooperateBattleUITask = (CooperateBattleUITask)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, cooperateBattleUITask.m_luaExportHelper.m_layerDescArray);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601CF9A RID: 118682 RVA: 0x0091578C File Offset: 0x0091398C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_layerDescArray(IntPtr l)
	{
		int result;
		try
		{
			CooperateBattleUITask cooperateBattleUITask = (CooperateBattleUITask)LuaObject.checkSelf(l);
			UITaskBase.LayerDesc[] layerDescArray;
			LuaObject.checkArray<UITaskBase.LayerDesc>(l, 2, out layerDescArray);
			cooperateBattleUITask.m_luaExportHelper.m_layerDescArray = layerDescArray;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601CF9B RID: 118683 RVA: 0x009157E8 File Offset: 0x009139E8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_uiCtrlDescArray(IntPtr l)
	{
		int result;
		try
		{
			CooperateBattleUITask cooperateBattleUITask = (CooperateBattleUITask)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, cooperateBattleUITask.m_luaExportHelper.m_uiCtrlDescArray);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601CF9C RID: 118684 RVA: 0x00915840 File Offset: 0x00913A40
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_uiCtrlDescArray(IntPtr l)
	{
		int result;
		try
		{
			CooperateBattleUITask cooperateBattleUITask = (CooperateBattleUITask)LuaObject.checkSelf(l);
			UITaskBase.UIControllerDesc[] uiCtrlDescArray;
			LuaObject.checkArray<UITaskBase.UIControllerDesc>(l, 2, out uiCtrlDescArray);
			cooperateBattleUITask.m_luaExportHelper.m_uiCtrlDescArray = uiCtrlDescArray;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601CF9D RID: 118685 RVA: 0x0091589C File Offset: 0x00913A9C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_cooperateBattleUIController(IntPtr l)
	{
		int result;
		try
		{
			CooperateBattleUITask cooperateBattleUITask = (CooperateBattleUITask)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, cooperateBattleUITask.m_luaExportHelper.m_cooperateBattleUIController);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601CF9E RID: 118686 RVA: 0x009158F4 File Offset: 0x00913AF4
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_m_cooperateBattleUIController(IntPtr l)
	{
		int result;
		try
		{
			CooperateBattleUITask cooperateBattleUITask = (CooperateBattleUITask)LuaObject.checkSelf(l);
			CooperateBattleUIController cooperateBattleUIController;
			LuaObject.checkType<CooperateBattleUIController>(l, 2, out cooperateBattleUIController);
			cooperateBattleUITask.m_luaExportHelper.m_cooperateBattleUIController = cooperateBattleUIController;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601CF9F RID: 118687 RVA: 0x00915950 File Offset: 0x00913B50
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_playerResourceUIController(IntPtr l)
	{
		int result;
		try
		{
			CooperateBattleUITask cooperateBattleUITask = (CooperateBattleUITask)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, cooperateBattleUITask.m_luaExportHelper.m_playerResourceUIController);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601CFA0 RID: 118688 RVA: 0x009159A8 File Offset: 0x00913BA8
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_m_playerResourceUIController(IntPtr l)
	{
		int result;
		try
		{
			CooperateBattleUITask cooperateBattleUITask = (CooperateBattleUITask)LuaObject.checkSelf(l);
			PlayerResourceUIController playerResourceUIController;
			LuaObject.checkType<PlayerResourceUIController>(l, 2, out playerResourceUIController);
			cooperateBattleUITask.m_luaExportHelper.m_playerResourceUIController = playerResourceUIController;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601CFA1 RID: 118689 RVA: 0x00915A04 File Offset: 0x00913C04
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_cooperateBattleInfo(IntPtr l)
	{
		int result;
		try
		{
			CooperateBattleUITask cooperateBattleUITask = (CooperateBattleUITask)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, cooperateBattleUITask.m_luaExportHelper.m_cooperateBattleInfo);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601CFA2 RID: 118690 RVA: 0x00915A5C File Offset: 0x00913C5C
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_m_cooperateBattleInfo(IntPtr l)
	{
		int result;
		try
		{
			CooperateBattleUITask cooperateBattleUITask = (CooperateBattleUITask)LuaObject.checkSelf(l);
			ConfigDataCooperateBattleInfo cooperateBattleInfo;
			LuaObject.checkType<ConfigDataCooperateBattleInfo>(l, 2, out cooperateBattleInfo);
			cooperateBattleUITask.m_luaExportHelper.m_cooperateBattleInfo = cooperateBattleInfo;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601CFA3 RID: 118691 RVA: 0x00915AB8 File Offset: 0x00913CB8
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_LayerDescArray(IntPtr l)
	{
		int result;
		try
		{
			CooperateBattleUITask cooperateBattleUITask = (CooperateBattleUITask)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, cooperateBattleUITask.m_luaExportHelper.LayerDescArray);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601CFA4 RID: 118692 RVA: 0x00915B10 File Offset: 0x00913D10
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_UICtrlDescArray(IntPtr l)
	{
		int result;
		try
		{
			CooperateBattleUITask cooperateBattleUITask = (CooperateBattleUITask)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, cooperateBattleUITask.m_luaExportHelper.UICtrlDescArray);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601CFA5 RID: 118693 RVA: 0x00915B68 File Offset: 0x00913D68
	[Preserve]
	public static void reg(IntPtr l)
	{
		LuaObject.getTypeTable(l, "BlackJack.ProjectL.UI.CooperateBattleUITask");
		if (Lua_BlackJack_ProjectL_UI_CooperateBattleUITask.<>f__mg$cache0 == null)
		{
			Lua_BlackJack_ProjectL_UI_CooperateBattleUITask.<>f__mg$cache0 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_CooperateBattleUITask.OnStart);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_CooperateBattleUITask.<>f__mg$cache0);
		if (Lua_BlackJack_ProjectL_UI_CooperateBattleUITask.<>f__mg$cache1 == null)
		{
			Lua_BlackJack_ProjectL_UI_CooperateBattleUITask.<>f__mg$cache1 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_CooperateBattleUITask.OnResume);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_CooperateBattleUITask.<>f__mg$cache1);
		if (Lua_BlackJack_ProjectL_UI_CooperateBattleUITask.<>f__mg$cache2 == null)
		{
			Lua_BlackJack_ProjectL_UI_CooperateBattleUITask.<>f__mg$cache2 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_CooperateBattleUITask.InitDataFromUIIntent);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_CooperateBattleUITask.<>f__mg$cache2);
		if (Lua_BlackJack_ProjectL_UI_CooperateBattleUITask.<>f__mg$cache3 == null)
		{
			Lua_BlackJack_ProjectL_UI_CooperateBattleUITask.<>f__mg$cache3 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_CooperateBattleUITask.IsNeedLoadDynamicRes);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_CooperateBattleUITask.<>f__mg$cache3);
		if (Lua_BlackJack_ProjectL_UI_CooperateBattleUITask.<>f__mg$cache4 == null)
		{
			Lua_BlackJack_ProjectL_UI_CooperateBattleUITask.<>f__mg$cache4 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_CooperateBattleUITask.InitAllUIControllers);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_CooperateBattleUITask.<>f__mg$cache4);
		if (Lua_BlackJack_ProjectL_UI_CooperateBattleUITask.<>f__mg$cache5 == null)
		{
			Lua_BlackJack_ProjectL_UI_CooperateBattleUITask.<>f__mg$cache5 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_CooperateBattleUITask.ClearAllContextAndRes);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_CooperateBattleUITask.<>f__mg$cache5);
		if (Lua_BlackJack_ProjectL_UI_CooperateBattleUITask.<>f__mg$cache6 == null)
		{
			Lua_BlackJack_ProjectL_UI_CooperateBattleUITask.<>f__mg$cache6 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_CooperateBattleUITask.InitCooperateBattleUIController);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_CooperateBattleUITask.<>f__mg$cache6);
		if (Lua_BlackJack_ProjectL_UI_CooperateBattleUITask.<>f__mg$cache7 == null)
		{
			Lua_BlackJack_ProjectL_UI_CooperateBattleUITask.<>f__mg$cache7 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_CooperateBattleUITask.UninitCooperateBattleUIController);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_CooperateBattleUITask.<>f__mg$cache7);
		if (Lua_BlackJack_ProjectL_UI_CooperateBattleUITask.<>f__mg$cache8 == null)
		{
			Lua_BlackJack_ProjectL_UI_CooperateBattleUITask.<>f__mg$cache8 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_CooperateBattleUITask.UpdateView);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_CooperateBattleUITask.<>f__mg$cache8);
		if (Lua_BlackJack_ProjectL_UI_CooperateBattleUITask.<>f__mg$cache9 == null)
		{
			Lua_BlackJack_ProjectL_UI_CooperateBattleUITask.<>f__mg$cache9 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_CooperateBattleUITask.CooperateBattleUIController_OnReturn);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_CooperateBattleUITask.<>f__mg$cache9);
		if (Lua_BlackJack_ProjectL_UI_CooperateBattleUITask.<>f__mg$cacheA == null)
		{
			Lua_BlackJack_ProjectL_UI_CooperateBattleUITask.<>f__mg$cacheA = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_CooperateBattleUITask.CooperateBattleUIController_OnShowHelp);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_CooperateBattleUITask.<>f__mg$cacheA);
		if (Lua_BlackJack_ProjectL_UI_CooperateBattleUITask.<>f__mg$cacheB == null)
		{
			Lua_BlackJack_ProjectL_UI_CooperateBattleUITask.<>f__mg$cacheB = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_CooperateBattleUITask.CooperateBattleUIController_OnAddTicket);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_CooperateBattleUITask.<>f__mg$cacheB);
		if (Lua_BlackJack_ProjectL_UI_CooperateBattleUITask.<>f__mg$cacheC == null)
		{
			Lua_BlackJack_ProjectL_UI_CooperateBattleUITask.<>f__mg$cacheC = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_CooperateBattleUITask.CooperateBattleUIController_OnShowTeam);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_CooperateBattleUITask.<>f__mg$cacheC);
		if (Lua_BlackJack_ProjectL_UI_CooperateBattleUITask.<>f__mg$cacheD == null)
		{
			Lua_BlackJack_ProjectL_UI_CooperateBattleUITask.<>f__mg$cacheD = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_CooperateBattleUITask.TeamUITask_OnLoadAllResCompleted);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_CooperateBattleUITask.<>f__mg$cacheD);
		if (Lua_BlackJack_ProjectL_UI_CooperateBattleUITask.<>f__mg$cacheE == null)
		{
			Lua_BlackJack_ProjectL_UI_CooperateBattleUITask.<>f__mg$cacheE = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_CooperateBattleUITask.CooperateBattleUIController_OnStartCooperateBattleLevel);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_CooperateBattleUITask.<>f__mg$cacheE);
		if (Lua_BlackJack_ProjectL_UI_CooperateBattleUITask.<>f__mg$cacheF == null)
		{
			Lua_BlackJack_ProjectL_UI_CooperateBattleUITask.<>f__mg$cacheF = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_CooperateBattleUITask.__callBase_OnStart);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_CooperateBattleUITask.<>f__mg$cacheF);
		if (Lua_BlackJack_ProjectL_UI_CooperateBattleUITask.<>f__mg$cache10 == null)
		{
			Lua_BlackJack_ProjectL_UI_CooperateBattleUITask.<>f__mg$cache10 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_CooperateBattleUITask.__callBase_OnStop);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_CooperateBattleUITask.<>f__mg$cache10);
		if (Lua_BlackJack_ProjectL_UI_CooperateBattleUITask.<>f__mg$cache11 == null)
		{
			Lua_BlackJack_ProjectL_UI_CooperateBattleUITask.<>f__mg$cache11 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_CooperateBattleUITask.__callBase_OnPause);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_CooperateBattleUITask.<>f__mg$cache11);
		if (Lua_BlackJack_ProjectL_UI_CooperateBattleUITask.<>f__mg$cache12 == null)
		{
			Lua_BlackJack_ProjectL_UI_CooperateBattleUITask.<>f__mg$cache12 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_CooperateBattleUITask.__callBase_OnResume);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_CooperateBattleUITask.<>f__mg$cache12);
		if (Lua_BlackJack_ProjectL_UI_CooperateBattleUITask.<>f__mg$cache13 == null)
		{
			Lua_BlackJack_ProjectL_UI_CooperateBattleUITask.<>f__mg$cache13 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_CooperateBattleUITask.__callBase_OnNewIntent);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_CooperateBattleUITask.<>f__mg$cache13);
		if (Lua_BlackJack_ProjectL_UI_CooperateBattleUITask.<>f__mg$cache14 == null)
		{
			Lua_BlackJack_ProjectL_UI_CooperateBattleUITask.<>f__mg$cache14 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_CooperateBattleUITask.__callBase_EnableUIInput);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_CooperateBattleUITask.<>f__mg$cache14);
		if (Lua_BlackJack_ProjectL_UI_CooperateBattleUITask.<>f__mg$cache15 == null)
		{
			Lua_BlackJack_ProjectL_UI_CooperateBattleUITask.<>f__mg$cache15 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_CooperateBattleUITask.__callBase_IsNeedLoadDynamicRes);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_CooperateBattleUITask.<>f__mg$cache15);
		if (Lua_BlackJack_ProjectL_UI_CooperateBattleUITask.<>f__mg$cache16 == null)
		{
			Lua_BlackJack_ProjectL_UI_CooperateBattleUITask.<>f__mg$cache16 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_CooperateBattleUITask.__callBase_CollectAllDynamicResForLoad);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_CooperateBattleUITask.<>f__mg$cache16);
		if (Lua_BlackJack_ProjectL_UI_CooperateBattleUITask.<>f__mg$cache17 == null)
		{
			Lua_BlackJack_ProjectL_UI_CooperateBattleUITask.<>f__mg$cache17 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_CooperateBattleUITask.__callBase_RegisterPlayerContextEvents);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_CooperateBattleUITask.<>f__mg$cache17);
		if (Lua_BlackJack_ProjectL_UI_CooperateBattleUITask.<>f__mg$cache18 == null)
		{
			Lua_BlackJack_ProjectL_UI_CooperateBattleUITask.<>f__mg$cache18 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_CooperateBattleUITask.__callBase_UnregisterPlayerContextEvents);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_CooperateBattleUITask.<>f__mg$cache18);
		if (Lua_BlackJack_ProjectL_UI_CooperateBattleUITask.<>f__mg$cache19 == null)
		{
			Lua_BlackJack_ProjectL_UI_CooperateBattleUITask.<>f__mg$cache19 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_CooperateBattleUITask.__callBase_PostUpdateView);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_CooperateBattleUITask.<>f__mg$cache19);
		if (Lua_BlackJack_ProjectL_UI_CooperateBattleUITask.<>f__mg$cache1A == null)
		{
			Lua_BlackJack_ProjectL_UI_CooperateBattleUITask.<>f__mg$cache1A = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_CooperateBattleUITask.__callBase_CollectPreloadResourceList);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_CooperateBattleUITask.<>f__mg$cache1A);
		if (Lua_BlackJack_ProjectL_UI_CooperateBattleUITask.<>f__mg$cache1B == null)
		{
			Lua_BlackJack_ProjectL_UI_CooperateBattleUITask.<>f__mg$cache1B = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_CooperateBattleUITask.__callBase_ClearAssetList);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_CooperateBattleUITask.<>f__mg$cache1B);
		if (Lua_BlackJack_ProjectL_UI_CooperateBattleUITask.<>f__mg$cache1C == null)
		{
			Lua_BlackJack_ProjectL_UI_CooperateBattleUITask.<>f__mg$cache1C = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_CooperateBattleUITask.__callBase_CollectAsset);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_CooperateBattleUITask.<>f__mg$cache1C);
		if (Lua_BlackJack_ProjectL_UI_CooperateBattleUITask.<>f__mg$cache1D == null)
		{
			Lua_BlackJack_ProjectL_UI_CooperateBattleUITask.<>f__mg$cache1D = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_CooperateBattleUITask.__callBase_CollectSpriteAsset);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_CooperateBattleUITask.<>f__mg$cache1D);
		if (Lua_BlackJack_ProjectL_UI_CooperateBattleUITask.<>f__mg$cache1E == null)
		{
			Lua_BlackJack_ProjectL_UI_CooperateBattleUITask.<>f__mg$cache1E = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_CooperateBattleUITask.__callBase_CollectFxAsset);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_CooperateBattleUITask.<>f__mg$cache1E);
		if (Lua_BlackJack_ProjectL_UI_CooperateBattleUITask.<>f__mg$cache1F == null)
		{
			Lua_BlackJack_ProjectL_UI_CooperateBattleUITask.<>f__mg$cache1F = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_CooperateBattleUITask.__callBase_StartLoadCustomAssets);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_CooperateBattleUITask.<>f__mg$cache1F);
		if (Lua_BlackJack_ProjectL_UI_CooperateBattleUITask.<>f__mg$cache20 == null)
		{
			Lua_BlackJack_ProjectL_UI_CooperateBattleUITask.<>f__mg$cache20 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_CooperateBattleUITask.__callBase_IsLoadingCustomAssets);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_CooperateBattleUITask.<>f__mg$cache20);
		if (Lua_BlackJack_ProjectL_UI_CooperateBattleUITask.<>f__mg$cache21 == null)
		{
			Lua_BlackJack_ProjectL_UI_CooperateBattleUITask.<>f__mg$cache21 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_CooperateBattleUITask.__callBase_IsPipeLineRunning);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_CooperateBattleUITask.<>f__mg$cache21);
		if (Lua_BlackJack_ProjectL_UI_CooperateBattleUITask.<>f__mg$cache22 == null)
		{
			Lua_BlackJack_ProjectL_UI_CooperateBattleUITask.<>f__mg$cache22 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_CooperateBattleUITask.__callBase_IsOpeningUI);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_CooperateBattleUITask.<>f__mg$cache22);
		if (Lua_BlackJack_ProjectL_UI_CooperateBattleUITask.<>f__mg$cache23 == null)
		{
			Lua_BlackJack_ProjectL_UI_CooperateBattleUITask.<>f__mg$cache23 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_CooperateBattleUITask.__callBase_ReturnPrevUITask);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_CooperateBattleUITask.<>f__mg$cache23);
		if (Lua_BlackJack_ProjectL_UI_CooperateBattleUITask.<>f__mg$cache24 == null)
		{
			Lua_BlackJack_ProjectL_UI_CooperateBattleUITask.<>f__mg$cache24 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_CooperateBattleUITask.__callBase_ClearUnusedDynamicResourceCache);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_CooperateBattleUITask.<>f__mg$cache24);
		if (Lua_BlackJack_ProjectL_UI_CooperateBattleUITask.<>f__mg$cache25 == null)
		{
			Lua_BlackJack_ProjectL_UI_CooperateBattleUITask.<>f__mg$cache25 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_CooperateBattleUITask.__callBase_OnMemoryWarning);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_CooperateBattleUITask.<>f__mg$cache25);
		string name = "m_layerDescArray";
		if (Lua_BlackJack_ProjectL_UI_CooperateBattleUITask.<>f__mg$cache26 == null)
		{
			Lua_BlackJack_ProjectL_UI_CooperateBattleUITask.<>f__mg$cache26 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_CooperateBattleUITask.get_m_layerDescArray);
		}
		LuaCSFunction get = Lua_BlackJack_ProjectL_UI_CooperateBattleUITask.<>f__mg$cache26;
		if (Lua_BlackJack_ProjectL_UI_CooperateBattleUITask.<>f__mg$cache27 == null)
		{
			Lua_BlackJack_ProjectL_UI_CooperateBattleUITask.<>f__mg$cache27 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_CooperateBattleUITask.set_m_layerDescArray);
		}
		LuaObject.addMember(l, name, get, Lua_BlackJack_ProjectL_UI_CooperateBattleUITask.<>f__mg$cache27, true);
		string name2 = "m_uiCtrlDescArray";
		if (Lua_BlackJack_ProjectL_UI_CooperateBattleUITask.<>f__mg$cache28 == null)
		{
			Lua_BlackJack_ProjectL_UI_CooperateBattleUITask.<>f__mg$cache28 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_CooperateBattleUITask.get_m_uiCtrlDescArray);
		}
		LuaCSFunction get2 = Lua_BlackJack_ProjectL_UI_CooperateBattleUITask.<>f__mg$cache28;
		if (Lua_BlackJack_ProjectL_UI_CooperateBattleUITask.<>f__mg$cache29 == null)
		{
			Lua_BlackJack_ProjectL_UI_CooperateBattleUITask.<>f__mg$cache29 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_CooperateBattleUITask.set_m_uiCtrlDescArray);
		}
		LuaObject.addMember(l, name2, get2, Lua_BlackJack_ProjectL_UI_CooperateBattleUITask.<>f__mg$cache29, true);
		string name3 = "m_cooperateBattleUIController";
		if (Lua_BlackJack_ProjectL_UI_CooperateBattleUITask.<>f__mg$cache2A == null)
		{
			Lua_BlackJack_ProjectL_UI_CooperateBattleUITask.<>f__mg$cache2A = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_CooperateBattleUITask.get_m_cooperateBattleUIController);
		}
		LuaCSFunction get3 = Lua_BlackJack_ProjectL_UI_CooperateBattleUITask.<>f__mg$cache2A;
		if (Lua_BlackJack_ProjectL_UI_CooperateBattleUITask.<>f__mg$cache2B == null)
		{
			Lua_BlackJack_ProjectL_UI_CooperateBattleUITask.<>f__mg$cache2B = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_CooperateBattleUITask.set_m_cooperateBattleUIController);
		}
		LuaObject.addMember(l, name3, get3, Lua_BlackJack_ProjectL_UI_CooperateBattleUITask.<>f__mg$cache2B, true);
		string name4 = "m_playerResourceUIController";
		if (Lua_BlackJack_ProjectL_UI_CooperateBattleUITask.<>f__mg$cache2C == null)
		{
			Lua_BlackJack_ProjectL_UI_CooperateBattleUITask.<>f__mg$cache2C = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_CooperateBattleUITask.get_m_playerResourceUIController);
		}
		LuaCSFunction get4 = Lua_BlackJack_ProjectL_UI_CooperateBattleUITask.<>f__mg$cache2C;
		if (Lua_BlackJack_ProjectL_UI_CooperateBattleUITask.<>f__mg$cache2D == null)
		{
			Lua_BlackJack_ProjectL_UI_CooperateBattleUITask.<>f__mg$cache2D = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_CooperateBattleUITask.set_m_playerResourceUIController);
		}
		LuaObject.addMember(l, name4, get4, Lua_BlackJack_ProjectL_UI_CooperateBattleUITask.<>f__mg$cache2D, true);
		string name5 = "m_cooperateBattleInfo";
		if (Lua_BlackJack_ProjectL_UI_CooperateBattleUITask.<>f__mg$cache2E == null)
		{
			Lua_BlackJack_ProjectL_UI_CooperateBattleUITask.<>f__mg$cache2E = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_CooperateBattleUITask.get_m_cooperateBattleInfo);
		}
		LuaCSFunction get5 = Lua_BlackJack_ProjectL_UI_CooperateBattleUITask.<>f__mg$cache2E;
		if (Lua_BlackJack_ProjectL_UI_CooperateBattleUITask.<>f__mg$cache2F == null)
		{
			Lua_BlackJack_ProjectL_UI_CooperateBattleUITask.<>f__mg$cache2F = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_CooperateBattleUITask.set_m_cooperateBattleInfo);
		}
		LuaObject.addMember(l, name5, get5, Lua_BlackJack_ProjectL_UI_CooperateBattleUITask.<>f__mg$cache2F, true);
		string name6 = "LayerDescArray";
		if (Lua_BlackJack_ProjectL_UI_CooperateBattleUITask.<>f__mg$cache30 == null)
		{
			Lua_BlackJack_ProjectL_UI_CooperateBattleUITask.<>f__mg$cache30 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_CooperateBattleUITask.get_LayerDescArray);
		}
		LuaObject.addMember(l, name6, Lua_BlackJack_ProjectL_UI_CooperateBattleUITask.<>f__mg$cache30, null, true);
		string name7 = "UICtrlDescArray";
		if (Lua_BlackJack_ProjectL_UI_CooperateBattleUITask.<>f__mg$cache31 == null)
		{
			Lua_BlackJack_ProjectL_UI_CooperateBattleUITask.<>f__mg$cache31 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_CooperateBattleUITask.get_UICtrlDescArray);
		}
		LuaObject.addMember(l, name7, Lua_BlackJack_ProjectL_UI_CooperateBattleUITask.<>f__mg$cache31, null, true);
		if (Lua_BlackJack_ProjectL_UI_CooperateBattleUITask.<>f__mg$cache32 == null)
		{
			Lua_BlackJack_ProjectL_UI_CooperateBattleUITask.<>f__mg$cache32 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_CooperateBattleUITask.constructor);
		}
		LuaObject.createTypeMetatable(l, Lua_BlackJack_ProjectL_UI_CooperateBattleUITask.<>f__mg$cache32, typeof(CooperateBattleUITask), typeof(UITask));
	}

	// Token: 0x04013142 RID: 78146
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache0;

	// Token: 0x04013143 RID: 78147
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1;

	// Token: 0x04013144 RID: 78148
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2;

	// Token: 0x04013145 RID: 78149
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3;

	// Token: 0x04013146 RID: 78150
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache4;

	// Token: 0x04013147 RID: 78151
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache5;

	// Token: 0x04013148 RID: 78152
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache6;

	// Token: 0x04013149 RID: 78153
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache7;

	// Token: 0x0401314A RID: 78154
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache8;

	// Token: 0x0401314B RID: 78155
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache9;

	// Token: 0x0401314C RID: 78156
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheA;

	// Token: 0x0401314D RID: 78157
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheB;

	// Token: 0x0401314E RID: 78158
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheC;

	// Token: 0x0401314F RID: 78159
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheD;

	// Token: 0x04013150 RID: 78160
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheE;

	// Token: 0x04013151 RID: 78161
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheF;

	// Token: 0x04013152 RID: 78162
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache10;

	// Token: 0x04013153 RID: 78163
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache11;

	// Token: 0x04013154 RID: 78164
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache12;

	// Token: 0x04013155 RID: 78165
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache13;

	// Token: 0x04013156 RID: 78166
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache14;

	// Token: 0x04013157 RID: 78167
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache15;

	// Token: 0x04013158 RID: 78168
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache16;

	// Token: 0x04013159 RID: 78169
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache17;

	// Token: 0x0401315A RID: 78170
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache18;

	// Token: 0x0401315B RID: 78171
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache19;

	// Token: 0x0401315C RID: 78172
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1A;

	// Token: 0x0401315D RID: 78173
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1B;

	// Token: 0x0401315E RID: 78174
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1C;

	// Token: 0x0401315F RID: 78175
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1D;

	// Token: 0x04013160 RID: 78176
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1E;

	// Token: 0x04013161 RID: 78177
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1F;

	// Token: 0x04013162 RID: 78178
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache20;

	// Token: 0x04013163 RID: 78179
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache21;

	// Token: 0x04013164 RID: 78180
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache22;

	// Token: 0x04013165 RID: 78181
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache23;

	// Token: 0x04013166 RID: 78182
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache24;

	// Token: 0x04013167 RID: 78183
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache25;

	// Token: 0x04013168 RID: 78184
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache26;

	// Token: 0x04013169 RID: 78185
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache27;

	// Token: 0x0401316A RID: 78186
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache28;

	// Token: 0x0401316B RID: 78187
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache29;

	// Token: 0x0401316C RID: 78188
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2A;

	// Token: 0x0401316D RID: 78189
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2B;

	// Token: 0x0401316E RID: 78190
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2C;

	// Token: 0x0401316F RID: 78191
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2D;

	// Token: 0x04013170 RID: 78192
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2E;

	// Token: 0x04013171 RID: 78193
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2F;

	// Token: 0x04013172 RID: 78194
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache30;

	// Token: 0x04013173 RID: 78195
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache31;

	// Token: 0x04013174 RID: 78196
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache32;
}
