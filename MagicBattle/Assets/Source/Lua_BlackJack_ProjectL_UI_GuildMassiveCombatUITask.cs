using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using BlackJack.BJFramework.Runtime.UI;
using BlackJack.ProjectL.Common;
using BlackJack.ProjectL.UI;
using SLua;
using UnityEngine.Scripting;

// Token: 0x02001490 RID: 5264
[Preserve]
public class Lua_BlackJack_ProjectL_UI_GuildMassiveCombatUITask : LuaObject
{
	// Token: 0x0601E798 RID: 124824 RVA: 0x009D4820 File Offset: 0x009D2A20
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int constructor(IntPtr l)
	{
		int result;
		try
		{
			string name;
			LuaObject.checkType(l, 2, out name);
			GuildMassiveCombatUITask o = new GuildMassiveCombatUITask(name);
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

	// Token: 0x0601E799 RID: 124825 RVA: 0x009D4874 File Offset: 0x009D2A74
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int IsNeedLoadDynamicRes(IntPtr l)
	{
		int result;
		try
		{
			GuildMassiveCombatUITask guildMassiveCombatUITask = (GuildMassiveCombatUITask)LuaObject.checkSelf(l);
			bool b = guildMassiveCombatUITask.m_luaExportHelper.IsNeedLoadDynamicRes();
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

	// Token: 0x0601E79A RID: 124826 RVA: 0x009D48D0 File Offset: 0x009D2AD0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int InitAllUIControllers(IntPtr l)
	{
		int result;
		try
		{
			GuildMassiveCombatUITask guildMassiveCombatUITask = (GuildMassiveCombatUITask)LuaObject.checkSelf(l);
			guildMassiveCombatUITask.m_luaExportHelper.InitAllUIControllers();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601E79B RID: 124827 RVA: 0x009D4924 File Offset: 0x009D2B24
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int ClearAllContextAndRes(IntPtr l)
	{
		int result;
		try
		{
			GuildMassiveCombatUITask guildMassiveCombatUITask = (GuildMassiveCombatUITask)LuaObject.checkSelf(l);
			guildMassiveCombatUITask.m_luaExportHelper.ClearAllContextAndRes();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601E79C RID: 124828 RVA: 0x009D4978 File Offset: 0x009D2B78
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int UpdateView(IntPtr l)
	{
		int result;
		try
		{
			GuildMassiveCombatUITask guildMassiveCombatUITask = (GuildMassiveCombatUITask)LuaObject.checkSelf(l);
			guildMassiveCombatUITask.m_luaExportHelper.UpdateView();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601E79D RID: 124829 RVA: 0x009D49CC File Offset: 0x009D2BCC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int StartTeamRoomInfoUITask(IntPtr l)
	{
		int result;
		try
		{
			GuildMassiveCombatUITask guildMassiveCombatUITask = (GuildMassiveCombatUITask)LuaObject.checkSelf(l);
			guildMassiveCombatUITask.m_luaExportHelper.StartTeamRoomInfoUITask();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601E79E RID: 124830 RVA: 0x009D4A20 File Offset: 0x009D2C20
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int OnClose(IntPtr l)
	{
		int result;
		try
		{
			GuildMassiveCombatUITask guildMassiveCombatUITask = (GuildMassiveCombatUITask)LuaObject.checkSelf(l);
			guildMassiveCombatUITask.m_luaExportHelper.OnClose();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601E79F RID: 124831 RVA: 0x009D4A74 File Offset: 0x009D2C74
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int GuildMassiveCombatUIController_OnGiveUpButtonClick(IntPtr l)
	{
		int result;
		try
		{
			GuildMassiveCombatUITask guildMassiveCombatUITask = (GuildMassiveCombatUITask)LuaObject.checkSelf(l);
			guildMassiveCombatUITask.m_luaExportHelper.GuildMassiveCombatUIController_OnGiveUpButtonClick();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601E7A0 RID: 124832 RVA: 0x009D4AC8 File Offset: 0x009D2CC8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int GuildMassiveCombatUIController_OnSingleBattle(IntPtr l)
	{
		int result;
		try
		{
			GuildMassiveCombatUITask guildMassiveCombatUITask = (GuildMassiveCombatUITask)LuaObject.checkSelf(l);
			GuildMassiveCombatStronghold strongHold;
			LuaObject.checkType<GuildMassiveCombatStronghold>(l, 2, out strongHold);
			guildMassiveCombatUITask.m_luaExportHelper.GuildMassiveCombatUIController_OnSingleBattle(strongHold);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601E7A1 RID: 124833 RVA: 0x009D4B24 File Offset: 0x009D2D24
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int GuildMassiveCombatUIController_OnTeamBattle(IntPtr l)
	{
		int result;
		try
		{
			GuildMassiveCombatUITask guildMassiveCombatUITask = (GuildMassiveCombatUITask)LuaObject.checkSelf(l);
			GuildMassiveCombatStronghold strongHold;
			LuaObject.checkType<GuildMassiveCombatStronghold>(l, 2, out strongHold);
			guildMassiveCombatUITask.m_luaExportHelper.GuildMassiveCombatUIController_OnTeamBattle(strongHold);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601E7A2 RID: 124834 RVA: 0x009D4B80 File Offset: 0x009D2D80
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_OnStart(IntPtr l)
	{
		int result;
		try
		{
			GuildMassiveCombatUITask guildMassiveCombatUITask = (GuildMassiveCombatUITask)LuaObject.checkSelf(l);
			UIIntent intent;
			LuaObject.checkType<UIIntent>(l, 2, out intent);
			bool b = guildMassiveCombatUITask.m_luaExportHelper.__callBase_OnStart(intent);
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

	// Token: 0x0601E7A3 RID: 124835 RVA: 0x009D4BE8 File Offset: 0x009D2DE8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_OnStop(IntPtr l)
	{
		int result;
		try
		{
			GuildMassiveCombatUITask guildMassiveCombatUITask = (GuildMassiveCombatUITask)LuaObject.checkSelf(l);
			guildMassiveCombatUITask.m_luaExportHelper.__callBase_OnStop();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601E7A4 RID: 124836 RVA: 0x009D4C3C File Offset: 0x009D2E3C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_OnPause(IntPtr l)
	{
		int result;
		try
		{
			GuildMassiveCombatUITask guildMassiveCombatUITask = (GuildMassiveCombatUITask)LuaObject.checkSelf(l);
			guildMassiveCombatUITask.m_luaExportHelper.__callBase_OnPause();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601E7A5 RID: 124837 RVA: 0x009D4C90 File Offset: 0x009D2E90
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_OnResume(IntPtr l)
	{
		int result;
		try
		{
			GuildMassiveCombatUITask guildMassiveCombatUITask = (GuildMassiveCombatUITask)LuaObject.checkSelf(l);
			UIIntent intent;
			LuaObject.checkType<UIIntent>(l, 2, out intent);
			bool b = guildMassiveCombatUITask.m_luaExportHelper.__callBase_OnResume(intent);
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

	// Token: 0x0601E7A6 RID: 124838 RVA: 0x009D4CF8 File Offset: 0x009D2EF8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_OnNewIntent(IntPtr l)
	{
		int result;
		try
		{
			GuildMassiveCombatUITask guildMassiveCombatUITask = (GuildMassiveCombatUITask)LuaObject.checkSelf(l);
			UIIntent intent;
			LuaObject.checkType<UIIntent>(l, 2, out intent);
			bool b = guildMassiveCombatUITask.m_luaExportHelper.__callBase_OnNewIntent(intent);
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

	// Token: 0x0601E7A7 RID: 124839 RVA: 0x009D4D60 File Offset: 0x009D2F60
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_EnableUIInput(IntPtr l)
	{
		int result;
		try
		{
			GuildMassiveCombatUITask guildMassiveCombatUITask = (GuildMassiveCombatUITask)LuaObject.checkSelf(l);
			bool isEnable;
			LuaObject.checkType(l, 2, out isEnable);
			bool? isGlobalEnable;
			LuaObject.checkNullable<bool>(l, 3, out isGlobalEnable);
			guildMassiveCombatUITask.m_luaExportHelper.__callBase_EnableUIInput(isEnable, isGlobalEnable);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601E7A8 RID: 124840 RVA: 0x009D4DCC File Offset: 0x009D2FCC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_IsNeedLoadDynamicRes(IntPtr l)
	{
		int result;
		try
		{
			GuildMassiveCombatUITask guildMassiveCombatUITask = (GuildMassiveCombatUITask)LuaObject.checkSelf(l);
			bool b = guildMassiveCombatUITask.m_luaExportHelper.__callBase_IsNeedLoadDynamicRes();
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

	// Token: 0x0601E7A9 RID: 124841 RVA: 0x009D4E28 File Offset: 0x009D3028
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_CollectAllDynamicResForLoad(IntPtr l)
	{
		int result;
		try
		{
			GuildMassiveCombatUITask guildMassiveCombatUITask = (GuildMassiveCombatUITask)LuaObject.checkSelf(l);
			List<string> o = guildMassiveCombatUITask.m_luaExportHelper.__callBase_CollectAllDynamicResForLoad();
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

	// Token: 0x0601E7AA RID: 124842 RVA: 0x009D4E84 File Offset: 0x009D3084
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int __callBase_RegisterPlayerContextEvents(IntPtr l)
	{
		int result;
		try
		{
			GuildMassiveCombatUITask guildMassiveCombatUITask = (GuildMassiveCombatUITask)LuaObject.checkSelf(l);
			guildMassiveCombatUITask.m_luaExportHelper.__callBase_RegisterPlayerContextEvents();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601E7AB RID: 124843 RVA: 0x009D4ED8 File Offset: 0x009D30D8
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int __callBase_UnregisterPlayerContextEvents(IntPtr l)
	{
		int result;
		try
		{
			GuildMassiveCombatUITask guildMassiveCombatUITask = (GuildMassiveCombatUITask)LuaObject.checkSelf(l);
			guildMassiveCombatUITask.m_luaExportHelper.__callBase_UnregisterPlayerContextEvents();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601E7AC RID: 124844 RVA: 0x009D4F2C File Offset: 0x009D312C
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int __callBase_PostUpdateView(IntPtr l)
	{
		int result;
		try
		{
			GuildMassiveCombatUITask guildMassiveCombatUITask = (GuildMassiveCombatUITask)LuaObject.checkSelf(l);
			guildMassiveCombatUITask.m_luaExportHelper.__callBase_PostUpdateView();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601E7AD RID: 124845 RVA: 0x009D4F80 File Offset: 0x009D3180
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_CollectPreloadResourceList(IntPtr l)
	{
		int result;
		try
		{
			GuildMassiveCombatUITask guildMassiveCombatUITask = (GuildMassiveCombatUITask)LuaObject.checkSelf(l);
			guildMassiveCombatUITask.m_luaExportHelper.__callBase_CollectPreloadResourceList();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601E7AE RID: 124846 RVA: 0x009D4FD4 File Offset: 0x009D31D4
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int __callBase_ClearAssetList(IntPtr l)
	{
		int result;
		try
		{
			GuildMassiveCombatUITask guildMassiveCombatUITask = (GuildMassiveCombatUITask)LuaObject.checkSelf(l);
			guildMassiveCombatUITask.m_luaExportHelper.__callBase_ClearAssetList();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601E7AF RID: 124847 RVA: 0x009D5028 File Offset: 0x009D3228
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int __callBase_CollectAsset(IntPtr l)
	{
		int result;
		try
		{
			GuildMassiveCombatUITask guildMassiveCombatUITask = (GuildMassiveCombatUITask)LuaObject.checkSelf(l);
			string assetName;
			LuaObject.checkType(l, 2, out assetName);
			guildMassiveCombatUITask.m_luaExportHelper.__callBase_CollectAsset(assetName);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601E7B0 RID: 124848 RVA: 0x009D5084 File Offset: 0x009D3284
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_CollectSpriteAsset(IntPtr l)
	{
		int result;
		try
		{
			GuildMassiveCombatUITask guildMassiveCombatUITask = (GuildMassiveCombatUITask)LuaObject.checkSelf(l);
			string assetName;
			LuaObject.checkType(l, 2, out assetName);
			guildMassiveCombatUITask.m_luaExportHelper.__callBase_CollectSpriteAsset(assetName);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601E7B1 RID: 124849 RVA: 0x009D50E0 File Offset: 0x009D32E0
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int __callBase_CollectFxAsset(IntPtr l)
	{
		int result;
		try
		{
			GuildMassiveCombatUITask guildMassiveCombatUITask = (GuildMassiveCombatUITask)LuaObject.checkSelf(l);
			string assetName;
			LuaObject.checkType(l, 2, out assetName);
			guildMassiveCombatUITask.m_luaExportHelper.__callBase_CollectFxAsset(assetName);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601E7B2 RID: 124850 RVA: 0x009D513C File Offset: 0x009D333C
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int __callBase_StartLoadCustomAssets(IntPtr l)
	{
		int result;
		try
		{
			GuildMassiveCombatUITask guildMassiveCombatUITask = (GuildMassiveCombatUITask)LuaObject.checkSelf(l);
			Action onLoadCompleted;
			LuaObject.checkDelegate<Action>(l, 2, out onLoadCompleted);
			guildMassiveCombatUITask.m_luaExportHelper.__callBase_StartLoadCustomAssets(onLoadCompleted);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601E7B3 RID: 124851 RVA: 0x009D5198 File Offset: 0x009D3398
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int __callBase_IsLoadingCustomAssets(IntPtr l)
	{
		int result;
		try
		{
			GuildMassiveCombatUITask guildMassiveCombatUITask = (GuildMassiveCombatUITask)LuaObject.checkSelf(l);
			bool b = guildMassiveCombatUITask.m_luaExportHelper.__callBase_IsLoadingCustomAssets();
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

	// Token: 0x0601E7B4 RID: 124852 RVA: 0x009D51F4 File Offset: 0x009D33F4
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int __callBase_IsPipeLineRunning(IntPtr l)
	{
		int result;
		try
		{
			GuildMassiveCombatUITask guildMassiveCombatUITask = (GuildMassiveCombatUITask)LuaObject.checkSelf(l);
			bool b = guildMassiveCombatUITask.m_luaExportHelper.__callBase_IsPipeLineRunning();
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

	// Token: 0x0601E7B5 RID: 124853 RVA: 0x009D5250 File Offset: 0x009D3450
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_IsOpeningUI(IntPtr l)
	{
		int result;
		try
		{
			GuildMassiveCombatUITask guildMassiveCombatUITask = (GuildMassiveCombatUITask)LuaObject.checkSelf(l);
			bool b = guildMassiveCombatUITask.m_luaExportHelper.__callBase_IsOpeningUI();
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

	// Token: 0x0601E7B6 RID: 124854 RVA: 0x009D52AC File Offset: 0x009D34AC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_ReturnPrevUITask(IntPtr l)
	{
		int result;
		try
		{
			GuildMassiveCombatUITask guildMassiveCombatUITask = (GuildMassiveCombatUITask)LuaObject.checkSelf(l);
			UITaskBase o = guildMassiveCombatUITask.m_luaExportHelper.__callBase_ReturnPrevUITask();
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

	// Token: 0x0601E7B7 RID: 124855 RVA: 0x009D5308 File Offset: 0x009D3508
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_ClearUnusedDynamicResourceCache(IntPtr l)
	{
		int result;
		try
		{
			GuildMassiveCombatUITask guildMassiveCombatUITask = (GuildMassiveCombatUITask)LuaObject.checkSelf(l);
			guildMassiveCombatUITask.m_luaExportHelper.__callBase_ClearUnusedDynamicResourceCache();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601E7B8 RID: 124856 RVA: 0x009D535C File Offset: 0x009D355C
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int __callBase_OnMemoryWarning(IntPtr l)
	{
		int result;
		try
		{
			GuildMassiveCombatUITask guildMassiveCombatUITask = (GuildMassiveCombatUITask)LuaObject.checkSelf(l);
			guildMassiveCombatUITask.m_luaExportHelper.__callBase_OnMemoryWarning();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601E7B9 RID: 124857 RVA: 0x009D53B0 File Offset: 0x009D35B0
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_m_layerDescArray(IntPtr l)
	{
		int result;
		try
		{
			GuildMassiveCombatUITask guildMassiveCombatUITask = (GuildMassiveCombatUITask)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, guildMassiveCombatUITask.m_luaExportHelper.m_layerDescArray);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601E7BA RID: 124858 RVA: 0x009D5408 File Offset: 0x009D3608
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_layerDescArray(IntPtr l)
	{
		int result;
		try
		{
			GuildMassiveCombatUITask guildMassiveCombatUITask = (GuildMassiveCombatUITask)LuaObject.checkSelf(l);
			UITaskBase.LayerDesc[] layerDescArray;
			LuaObject.checkArray<UITaskBase.LayerDesc>(l, 2, out layerDescArray);
			guildMassiveCombatUITask.m_luaExportHelper.m_layerDescArray = layerDescArray;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601E7BB RID: 124859 RVA: 0x009D5464 File Offset: 0x009D3664
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_uiCtrlDescArray(IntPtr l)
	{
		int result;
		try
		{
			GuildMassiveCombatUITask guildMassiveCombatUITask = (GuildMassiveCombatUITask)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, guildMassiveCombatUITask.m_luaExportHelper.m_uiCtrlDescArray);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601E7BC RID: 124860 RVA: 0x009D54BC File Offset: 0x009D36BC
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_m_uiCtrlDescArray(IntPtr l)
	{
		int result;
		try
		{
			GuildMassiveCombatUITask guildMassiveCombatUITask = (GuildMassiveCombatUITask)LuaObject.checkSelf(l);
			UITaskBase.UIControllerDesc[] uiCtrlDescArray;
			LuaObject.checkArray<UITaskBase.UIControllerDesc>(l, 2, out uiCtrlDescArray);
			guildMassiveCombatUITask.m_luaExportHelper.m_uiCtrlDescArray = uiCtrlDescArray;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601E7BD RID: 124861 RVA: 0x009D5518 File Offset: 0x009D3718
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_m_guildMassiveCombatUIController(IntPtr l)
	{
		int result;
		try
		{
			GuildMassiveCombatUITask guildMassiveCombatUITask = (GuildMassiveCombatUITask)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, guildMassiveCombatUITask.m_luaExportHelper.m_guildMassiveCombatUIController);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601E7BE RID: 124862 RVA: 0x009D5570 File Offset: 0x009D3770
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_m_guildMassiveCombatUIController(IntPtr l)
	{
		int result;
		try
		{
			GuildMassiveCombatUITask guildMassiveCombatUITask = (GuildMassiveCombatUITask)LuaObject.checkSelf(l);
			GuildMassiveCombatUIController guildMassiveCombatUIController;
			LuaObject.checkType<GuildMassiveCombatUIController>(l, 2, out guildMassiveCombatUIController);
			guildMassiveCombatUITask.m_luaExportHelper.m_guildMassiveCombatUIController = guildMassiveCombatUIController;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601E7BF RID: 124863 RVA: 0x009D55CC File Offset: 0x009D37CC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_LayerDescArray(IntPtr l)
	{
		int result;
		try
		{
			GuildMassiveCombatUITask guildMassiveCombatUITask = (GuildMassiveCombatUITask)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, guildMassiveCombatUITask.m_luaExportHelper.LayerDescArray);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601E7C0 RID: 124864 RVA: 0x009D5624 File Offset: 0x009D3824
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_UICtrlDescArray(IntPtr l)
	{
		int result;
		try
		{
			GuildMassiveCombatUITask guildMassiveCombatUITask = (GuildMassiveCombatUITask)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, guildMassiveCombatUITask.m_luaExportHelper.UICtrlDescArray);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601E7C1 RID: 124865 RVA: 0x009D567C File Offset: 0x009D387C
	[Preserve]
	public static void reg(IntPtr l)
	{
		LuaObject.getTypeTable(l, "BlackJack.ProjectL.UI.GuildMassiveCombatUITask");
		if (Lua_BlackJack_ProjectL_UI_GuildMassiveCombatUITask.<>f__mg$cache0 == null)
		{
			Lua_BlackJack_ProjectL_UI_GuildMassiveCombatUITask.<>f__mg$cache0 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_GuildMassiveCombatUITask.IsNeedLoadDynamicRes);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_GuildMassiveCombatUITask.<>f__mg$cache0);
		if (Lua_BlackJack_ProjectL_UI_GuildMassiveCombatUITask.<>f__mg$cache1 == null)
		{
			Lua_BlackJack_ProjectL_UI_GuildMassiveCombatUITask.<>f__mg$cache1 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_GuildMassiveCombatUITask.InitAllUIControllers);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_GuildMassiveCombatUITask.<>f__mg$cache1);
		if (Lua_BlackJack_ProjectL_UI_GuildMassiveCombatUITask.<>f__mg$cache2 == null)
		{
			Lua_BlackJack_ProjectL_UI_GuildMassiveCombatUITask.<>f__mg$cache2 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_GuildMassiveCombatUITask.ClearAllContextAndRes);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_GuildMassiveCombatUITask.<>f__mg$cache2);
		if (Lua_BlackJack_ProjectL_UI_GuildMassiveCombatUITask.<>f__mg$cache3 == null)
		{
			Lua_BlackJack_ProjectL_UI_GuildMassiveCombatUITask.<>f__mg$cache3 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_GuildMassiveCombatUITask.UpdateView);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_GuildMassiveCombatUITask.<>f__mg$cache3);
		if (Lua_BlackJack_ProjectL_UI_GuildMassiveCombatUITask.<>f__mg$cache4 == null)
		{
			Lua_BlackJack_ProjectL_UI_GuildMassiveCombatUITask.<>f__mg$cache4 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_GuildMassiveCombatUITask.StartTeamRoomInfoUITask);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_GuildMassiveCombatUITask.<>f__mg$cache4);
		if (Lua_BlackJack_ProjectL_UI_GuildMassiveCombatUITask.<>f__mg$cache5 == null)
		{
			Lua_BlackJack_ProjectL_UI_GuildMassiveCombatUITask.<>f__mg$cache5 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_GuildMassiveCombatUITask.OnClose);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_GuildMassiveCombatUITask.<>f__mg$cache5);
		if (Lua_BlackJack_ProjectL_UI_GuildMassiveCombatUITask.<>f__mg$cache6 == null)
		{
			Lua_BlackJack_ProjectL_UI_GuildMassiveCombatUITask.<>f__mg$cache6 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_GuildMassiveCombatUITask.GuildMassiveCombatUIController_OnGiveUpButtonClick);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_GuildMassiveCombatUITask.<>f__mg$cache6);
		if (Lua_BlackJack_ProjectL_UI_GuildMassiveCombatUITask.<>f__mg$cache7 == null)
		{
			Lua_BlackJack_ProjectL_UI_GuildMassiveCombatUITask.<>f__mg$cache7 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_GuildMassiveCombatUITask.GuildMassiveCombatUIController_OnSingleBattle);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_GuildMassiveCombatUITask.<>f__mg$cache7);
		if (Lua_BlackJack_ProjectL_UI_GuildMassiveCombatUITask.<>f__mg$cache8 == null)
		{
			Lua_BlackJack_ProjectL_UI_GuildMassiveCombatUITask.<>f__mg$cache8 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_GuildMassiveCombatUITask.GuildMassiveCombatUIController_OnTeamBattle);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_GuildMassiveCombatUITask.<>f__mg$cache8);
		if (Lua_BlackJack_ProjectL_UI_GuildMassiveCombatUITask.<>f__mg$cache9 == null)
		{
			Lua_BlackJack_ProjectL_UI_GuildMassiveCombatUITask.<>f__mg$cache9 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_GuildMassiveCombatUITask.__callBase_OnStart);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_GuildMassiveCombatUITask.<>f__mg$cache9);
		if (Lua_BlackJack_ProjectL_UI_GuildMassiveCombatUITask.<>f__mg$cacheA == null)
		{
			Lua_BlackJack_ProjectL_UI_GuildMassiveCombatUITask.<>f__mg$cacheA = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_GuildMassiveCombatUITask.__callBase_OnStop);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_GuildMassiveCombatUITask.<>f__mg$cacheA);
		if (Lua_BlackJack_ProjectL_UI_GuildMassiveCombatUITask.<>f__mg$cacheB == null)
		{
			Lua_BlackJack_ProjectL_UI_GuildMassiveCombatUITask.<>f__mg$cacheB = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_GuildMassiveCombatUITask.__callBase_OnPause);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_GuildMassiveCombatUITask.<>f__mg$cacheB);
		if (Lua_BlackJack_ProjectL_UI_GuildMassiveCombatUITask.<>f__mg$cacheC == null)
		{
			Lua_BlackJack_ProjectL_UI_GuildMassiveCombatUITask.<>f__mg$cacheC = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_GuildMassiveCombatUITask.__callBase_OnResume);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_GuildMassiveCombatUITask.<>f__mg$cacheC);
		if (Lua_BlackJack_ProjectL_UI_GuildMassiveCombatUITask.<>f__mg$cacheD == null)
		{
			Lua_BlackJack_ProjectL_UI_GuildMassiveCombatUITask.<>f__mg$cacheD = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_GuildMassiveCombatUITask.__callBase_OnNewIntent);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_GuildMassiveCombatUITask.<>f__mg$cacheD);
		if (Lua_BlackJack_ProjectL_UI_GuildMassiveCombatUITask.<>f__mg$cacheE == null)
		{
			Lua_BlackJack_ProjectL_UI_GuildMassiveCombatUITask.<>f__mg$cacheE = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_GuildMassiveCombatUITask.__callBase_EnableUIInput);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_GuildMassiveCombatUITask.<>f__mg$cacheE);
		if (Lua_BlackJack_ProjectL_UI_GuildMassiveCombatUITask.<>f__mg$cacheF == null)
		{
			Lua_BlackJack_ProjectL_UI_GuildMassiveCombatUITask.<>f__mg$cacheF = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_GuildMassiveCombatUITask.__callBase_IsNeedLoadDynamicRes);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_GuildMassiveCombatUITask.<>f__mg$cacheF);
		if (Lua_BlackJack_ProjectL_UI_GuildMassiveCombatUITask.<>f__mg$cache10 == null)
		{
			Lua_BlackJack_ProjectL_UI_GuildMassiveCombatUITask.<>f__mg$cache10 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_GuildMassiveCombatUITask.__callBase_CollectAllDynamicResForLoad);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_GuildMassiveCombatUITask.<>f__mg$cache10);
		if (Lua_BlackJack_ProjectL_UI_GuildMassiveCombatUITask.<>f__mg$cache11 == null)
		{
			Lua_BlackJack_ProjectL_UI_GuildMassiveCombatUITask.<>f__mg$cache11 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_GuildMassiveCombatUITask.__callBase_RegisterPlayerContextEvents);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_GuildMassiveCombatUITask.<>f__mg$cache11);
		if (Lua_BlackJack_ProjectL_UI_GuildMassiveCombatUITask.<>f__mg$cache12 == null)
		{
			Lua_BlackJack_ProjectL_UI_GuildMassiveCombatUITask.<>f__mg$cache12 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_GuildMassiveCombatUITask.__callBase_UnregisterPlayerContextEvents);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_GuildMassiveCombatUITask.<>f__mg$cache12);
		if (Lua_BlackJack_ProjectL_UI_GuildMassiveCombatUITask.<>f__mg$cache13 == null)
		{
			Lua_BlackJack_ProjectL_UI_GuildMassiveCombatUITask.<>f__mg$cache13 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_GuildMassiveCombatUITask.__callBase_PostUpdateView);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_GuildMassiveCombatUITask.<>f__mg$cache13);
		if (Lua_BlackJack_ProjectL_UI_GuildMassiveCombatUITask.<>f__mg$cache14 == null)
		{
			Lua_BlackJack_ProjectL_UI_GuildMassiveCombatUITask.<>f__mg$cache14 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_GuildMassiveCombatUITask.__callBase_CollectPreloadResourceList);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_GuildMassiveCombatUITask.<>f__mg$cache14);
		if (Lua_BlackJack_ProjectL_UI_GuildMassiveCombatUITask.<>f__mg$cache15 == null)
		{
			Lua_BlackJack_ProjectL_UI_GuildMassiveCombatUITask.<>f__mg$cache15 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_GuildMassiveCombatUITask.__callBase_ClearAssetList);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_GuildMassiveCombatUITask.<>f__mg$cache15);
		if (Lua_BlackJack_ProjectL_UI_GuildMassiveCombatUITask.<>f__mg$cache16 == null)
		{
			Lua_BlackJack_ProjectL_UI_GuildMassiveCombatUITask.<>f__mg$cache16 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_GuildMassiveCombatUITask.__callBase_CollectAsset);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_GuildMassiveCombatUITask.<>f__mg$cache16);
		if (Lua_BlackJack_ProjectL_UI_GuildMassiveCombatUITask.<>f__mg$cache17 == null)
		{
			Lua_BlackJack_ProjectL_UI_GuildMassiveCombatUITask.<>f__mg$cache17 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_GuildMassiveCombatUITask.__callBase_CollectSpriteAsset);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_GuildMassiveCombatUITask.<>f__mg$cache17);
		if (Lua_BlackJack_ProjectL_UI_GuildMassiveCombatUITask.<>f__mg$cache18 == null)
		{
			Lua_BlackJack_ProjectL_UI_GuildMassiveCombatUITask.<>f__mg$cache18 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_GuildMassiveCombatUITask.__callBase_CollectFxAsset);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_GuildMassiveCombatUITask.<>f__mg$cache18);
		if (Lua_BlackJack_ProjectL_UI_GuildMassiveCombatUITask.<>f__mg$cache19 == null)
		{
			Lua_BlackJack_ProjectL_UI_GuildMassiveCombatUITask.<>f__mg$cache19 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_GuildMassiveCombatUITask.__callBase_StartLoadCustomAssets);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_GuildMassiveCombatUITask.<>f__mg$cache19);
		if (Lua_BlackJack_ProjectL_UI_GuildMassiveCombatUITask.<>f__mg$cache1A == null)
		{
			Lua_BlackJack_ProjectL_UI_GuildMassiveCombatUITask.<>f__mg$cache1A = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_GuildMassiveCombatUITask.__callBase_IsLoadingCustomAssets);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_GuildMassiveCombatUITask.<>f__mg$cache1A);
		if (Lua_BlackJack_ProjectL_UI_GuildMassiveCombatUITask.<>f__mg$cache1B == null)
		{
			Lua_BlackJack_ProjectL_UI_GuildMassiveCombatUITask.<>f__mg$cache1B = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_GuildMassiveCombatUITask.__callBase_IsPipeLineRunning);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_GuildMassiveCombatUITask.<>f__mg$cache1B);
		if (Lua_BlackJack_ProjectL_UI_GuildMassiveCombatUITask.<>f__mg$cache1C == null)
		{
			Lua_BlackJack_ProjectL_UI_GuildMassiveCombatUITask.<>f__mg$cache1C = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_GuildMassiveCombatUITask.__callBase_IsOpeningUI);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_GuildMassiveCombatUITask.<>f__mg$cache1C);
		if (Lua_BlackJack_ProjectL_UI_GuildMassiveCombatUITask.<>f__mg$cache1D == null)
		{
			Lua_BlackJack_ProjectL_UI_GuildMassiveCombatUITask.<>f__mg$cache1D = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_GuildMassiveCombatUITask.__callBase_ReturnPrevUITask);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_GuildMassiveCombatUITask.<>f__mg$cache1D);
		if (Lua_BlackJack_ProjectL_UI_GuildMassiveCombatUITask.<>f__mg$cache1E == null)
		{
			Lua_BlackJack_ProjectL_UI_GuildMassiveCombatUITask.<>f__mg$cache1E = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_GuildMassiveCombatUITask.__callBase_ClearUnusedDynamicResourceCache);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_GuildMassiveCombatUITask.<>f__mg$cache1E);
		if (Lua_BlackJack_ProjectL_UI_GuildMassiveCombatUITask.<>f__mg$cache1F == null)
		{
			Lua_BlackJack_ProjectL_UI_GuildMassiveCombatUITask.<>f__mg$cache1F = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_GuildMassiveCombatUITask.__callBase_OnMemoryWarning);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_GuildMassiveCombatUITask.<>f__mg$cache1F);
		string name = "m_layerDescArray";
		if (Lua_BlackJack_ProjectL_UI_GuildMassiveCombatUITask.<>f__mg$cache20 == null)
		{
			Lua_BlackJack_ProjectL_UI_GuildMassiveCombatUITask.<>f__mg$cache20 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_GuildMassiveCombatUITask.get_m_layerDescArray);
		}
		LuaCSFunction get = Lua_BlackJack_ProjectL_UI_GuildMassiveCombatUITask.<>f__mg$cache20;
		if (Lua_BlackJack_ProjectL_UI_GuildMassiveCombatUITask.<>f__mg$cache21 == null)
		{
			Lua_BlackJack_ProjectL_UI_GuildMassiveCombatUITask.<>f__mg$cache21 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_GuildMassiveCombatUITask.set_m_layerDescArray);
		}
		LuaObject.addMember(l, name, get, Lua_BlackJack_ProjectL_UI_GuildMassiveCombatUITask.<>f__mg$cache21, true);
		string name2 = "m_uiCtrlDescArray";
		if (Lua_BlackJack_ProjectL_UI_GuildMassiveCombatUITask.<>f__mg$cache22 == null)
		{
			Lua_BlackJack_ProjectL_UI_GuildMassiveCombatUITask.<>f__mg$cache22 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_GuildMassiveCombatUITask.get_m_uiCtrlDescArray);
		}
		LuaCSFunction get2 = Lua_BlackJack_ProjectL_UI_GuildMassiveCombatUITask.<>f__mg$cache22;
		if (Lua_BlackJack_ProjectL_UI_GuildMassiveCombatUITask.<>f__mg$cache23 == null)
		{
			Lua_BlackJack_ProjectL_UI_GuildMassiveCombatUITask.<>f__mg$cache23 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_GuildMassiveCombatUITask.set_m_uiCtrlDescArray);
		}
		LuaObject.addMember(l, name2, get2, Lua_BlackJack_ProjectL_UI_GuildMassiveCombatUITask.<>f__mg$cache23, true);
		string name3 = "m_guildMassiveCombatUIController";
		if (Lua_BlackJack_ProjectL_UI_GuildMassiveCombatUITask.<>f__mg$cache24 == null)
		{
			Lua_BlackJack_ProjectL_UI_GuildMassiveCombatUITask.<>f__mg$cache24 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_GuildMassiveCombatUITask.get_m_guildMassiveCombatUIController);
		}
		LuaCSFunction get3 = Lua_BlackJack_ProjectL_UI_GuildMassiveCombatUITask.<>f__mg$cache24;
		if (Lua_BlackJack_ProjectL_UI_GuildMassiveCombatUITask.<>f__mg$cache25 == null)
		{
			Lua_BlackJack_ProjectL_UI_GuildMassiveCombatUITask.<>f__mg$cache25 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_GuildMassiveCombatUITask.set_m_guildMassiveCombatUIController);
		}
		LuaObject.addMember(l, name3, get3, Lua_BlackJack_ProjectL_UI_GuildMassiveCombatUITask.<>f__mg$cache25, true);
		string name4 = "LayerDescArray";
		if (Lua_BlackJack_ProjectL_UI_GuildMassiveCombatUITask.<>f__mg$cache26 == null)
		{
			Lua_BlackJack_ProjectL_UI_GuildMassiveCombatUITask.<>f__mg$cache26 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_GuildMassiveCombatUITask.get_LayerDescArray);
		}
		LuaObject.addMember(l, name4, Lua_BlackJack_ProjectL_UI_GuildMassiveCombatUITask.<>f__mg$cache26, null, true);
		string name5 = "UICtrlDescArray";
		if (Lua_BlackJack_ProjectL_UI_GuildMassiveCombatUITask.<>f__mg$cache27 == null)
		{
			Lua_BlackJack_ProjectL_UI_GuildMassiveCombatUITask.<>f__mg$cache27 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_GuildMassiveCombatUITask.get_UICtrlDescArray);
		}
		LuaObject.addMember(l, name5, Lua_BlackJack_ProjectL_UI_GuildMassiveCombatUITask.<>f__mg$cache27, null, true);
		if (Lua_BlackJack_ProjectL_UI_GuildMassiveCombatUITask.<>f__mg$cache28 == null)
		{
			Lua_BlackJack_ProjectL_UI_GuildMassiveCombatUITask.<>f__mg$cache28 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_GuildMassiveCombatUITask.constructor);
		}
		LuaObject.createTypeMetatable(l, Lua_BlackJack_ProjectL_UI_GuildMassiveCombatUITask.<>f__mg$cache28, typeof(GuildMassiveCombatUITask), typeof(UITask));
	}

	// Token: 0x0401485A RID: 84058
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache0;

	// Token: 0x0401485B RID: 84059
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1;

	// Token: 0x0401485C RID: 84060
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2;

	// Token: 0x0401485D RID: 84061
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3;

	// Token: 0x0401485E RID: 84062
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache4;

	// Token: 0x0401485F RID: 84063
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache5;

	// Token: 0x04014860 RID: 84064
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache6;

	// Token: 0x04014861 RID: 84065
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache7;

	// Token: 0x04014862 RID: 84066
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache8;

	// Token: 0x04014863 RID: 84067
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache9;

	// Token: 0x04014864 RID: 84068
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheA;

	// Token: 0x04014865 RID: 84069
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheB;

	// Token: 0x04014866 RID: 84070
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheC;

	// Token: 0x04014867 RID: 84071
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheD;

	// Token: 0x04014868 RID: 84072
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheE;

	// Token: 0x04014869 RID: 84073
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheF;

	// Token: 0x0401486A RID: 84074
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache10;

	// Token: 0x0401486B RID: 84075
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache11;

	// Token: 0x0401486C RID: 84076
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache12;

	// Token: 0x0401486D RID: 84077
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache13;

	// Token: 0x0401486E RID: 84078
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache14;

	// Token: 0x0401486F RID: 84079
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache15;

	// Token: 0x04014870 RID: 84080
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache16;

	// Token: 0x04014871 RID: 84081
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache17;

	// Token: 0x04014872 RID: 84082
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache18;

	// Token: 0x04014873 RID: 84083
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache19;

	// Token: 0x04014874 RID: 84084
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1A;

	// Token: 0x04014875 RID: 84085
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1B;

	// Token: 0x04014876 RID: 84086
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1C;

	// Token: 0x04014877 RID: 84087
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1D;

	// Token: 0x04014878 RID: 84088
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1E;

	// Token: 0x04014879 RID: 84089
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1F;

	// Token: 0x0401487A RID: 84090
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache20;

	// Token: 0x0401487B RID: 84091
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache21;

	// Token: 0x0401487C RID: 84092
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache22;

	// Token: 0x0401487D RID: 84093
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache23;

	// Token: 0x0401487E RID: 84094
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache24;

	// Token: 0x0401487F RID: 84095
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache25;

	// Token: 0x04014880 RID: 84096
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache26;

	// Token: 0x04014881 RID: 84097
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache27;

	// Token: 0x04014882 RID: 84098
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache28;
}
