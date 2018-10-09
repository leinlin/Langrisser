using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using BlackJack.BJFramework.Runtime.UI;
using BlackJack.ProjectL.UI;
using SLua;
using UnityEngine.Scripting;

// Token: 0x02001473 RID: 5235
[Preserve]
public class Lua_BlackJack_ProjectL_UI_GuildGameListUITask : LuaObject
{
	// Token: 0x0601E437 RID: 123959 RVA: 0x009BA2EC File Offset: 0x009B84EC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int constructor(IntPtr l)
	{
		int result;
		try
		{
			string name;
			LuaObject.checkType(l, 2, out name);
			GuildGameListUITask o = new GuildGameListUITask(name);
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

	// Token: 0x0601E438 RID: 123960 RVA: 0x009BA340 File Offset: 0x009B8540
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int IsNeedLoadDynamicRes(IntPtr l)
	{
		int result;
		try
		{
			GuildGameListUITask guildGameListUITask = (GuildGameListUITask)LuaObject.checkSelf(l);
			bool b = guildGameListUITask.m_luaExportHelper.IsNeedLoadDynamicRes();
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

	// Token: 0x0601E439 RID: 123961 RVA: 0x009BA39C File Offset: 0x009B859C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int InitAllUIControllers(IntPtr l)
	{
		int result;
		try
		{
			GuildGameListUITask guildGameListUITask = (GuildGameListUITask)LuaObject.checkSelf(l);
			guildGameListUITask.m_luaExportHelper.InitAllUIControllers();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601E43A RID: 123962 RVA: 0x009BA3F0 File Offset: 0x009B85F0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int ClearAllContextAndRes(IntPtr l)
	{
		int result;
		try
		{
			GuildGameListUITask guildGameListUITask = (GuildGameListUITask)LuaObject.checkSelf(l);
			guildGameListUITask.m_luaExportHelper.ClearAllContextAndRes();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601E43B RID: 123963 RVA: 0x009BA444 File Offset: 0x009B8644
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int UpdateView(IntPtr l)
	{
		int result;
		try
		{
			GuildGameListUITask guildGameListUITask = (GuildGameListUITask)LuaObject.checkSelf(l);
			guildGameListUITask.m_luaExportHelper.UpdateView();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601E43C RID: 123964 RVA: 0x009BA498 File Offset: 0x009B8698
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int PostUpdateView(IntPtr l)
	{
		int result;
		try
		{
			GuildGameListUITask guildGameListUITask = (GuildGameListUITask)LuaObject.checkSelf(l);
			guildGameListUITask.m_luaExportHelper.PostUpdateView();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601E43D RID: 123965 RVA: 0x009BA4EC File Offset: 0x009B86EC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int OnClose(IntPtr l)
	{
		int result;
		try
		{
			GuildGameListUITask guildGameListUITask = (GuildGameListUITask)LuaObject.checkSelf(l);
			guildGameListUITask.m_luaExportHelper.OnClose();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601E43E RID: 123966 RVA: 0x009BA540 File Offset: 0x009B8740
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int GuildGameListUIController_OnGuildPlayListItemClick(IntPtr l)
	{
		int result;
		try
		{
			GuildGameListUITask guildGameListUITask = (GuildGameListUITask)LuaObject.checkSelf(l);
			guildGameListUITask.m_luaExportHelper.GuildGameListUIController_OnGuildPlayListItemClick();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601E43F RID: 123967 RVA: 0x009BA594 File Offset: 0x009B8794
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int GuildRaidUITask_OnLoadAllResCompleted(IntPtr l)
	{
		int result;
		try
		{
			GuildGameListUITask guildGameListUITask = (GuildGameListUITask)LuaObject.checkSelf(l);
			guildGameListUITask.m_luaExportHelper.GuildRaidUITask_OnLoadAllResCompleted();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601E440 RID: 123968 RVA: 0x009BA5E8 File Offset: 0x009B87E8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int GuildMassiveCombatUITask_OnLoadAllResCompleted(IntPtr l)
	{
		int result;
		try
		{
			GuildGameListUITask guildGameListUITask = (GuildGameListUITask)LuaObject.checkSelf(l);
			guildGameListUITask.m_luaExportHelper.GuildMassiveCombatUITask_OnLoadAllResCompleted();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601E441 RID: 123969 RVA: 0x009BA63C File Offset: 0x009B883C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_OnStart(IntPtr l)
	{
		int result;
		try
		{
			GuildGameListUITask guildGameListUITask = (GuildGameListUITask)LuaObject.checkSelf(l);
			UIIntent intent;
			LuaObject.checkType<UIIntent>(l, 2, out intent);
			bool b = guildGameListUITask.m_luaExportHelper.__callBase_OnStart(intent);
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

	// Token: 0x0601E442 RID: 123970 RVA: 0x009BA6A4 File Offset: 0x009B88A4
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int __callBase_OnStop(IntPtr l)
	{
		int result;
		try
		{
			GuildGameListUITask guildGameListUITask = (GuildGameListUITask)LuaObject.checkSelf(l);
			guildGameListUITask.m_luaExportHelper.__callBase_OnStop();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601E443 RID: 123971 RVA: 0x009BA6F8 File Offset: 0x009B88F8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_OnPause(IntPtr l)
	{
		int result;
		try
		{
			GuildGameListUITask guildGameListUITask = (GuildGameListUITask)LuaObject.checkSelf(l);
			guildGameListUITask.m_luaExportHelper.__callBase_OnPause();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601E444 RID: 123972 RVA: 0x009BA74C File Offset: 0x009B894C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_OnResume(IntPtr l)
	{
		int result;
		try
		{
			GuildGameListUITask guildGameListUITask = (GuildGameListUITask)LuaObject.checkSelf(l);
			UIIntent intent;
			LuaObject.checkType<UIIntent>(l, 2, out intent);
			bool b = guildGameListUITask.m_luaExportHelper.__callBase_OnResume(intent);
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

	// Token: 0x0601E445 RID: 123973 RVA: 0x009BA7B4 File Offset: 0x009B89B4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_OnNewIntent(IntPtr l)
	{
		int result;
		try
		{
			GuildGameListUITask guildGameListUITask = (GuildGameListUITask)LuaObject.checkSelf(l);
			UIIntent intent;
			LuaObject.checkType<UIIntent>(l, 2, out intent);
			bool b = guildGameListUITask.m_luaExportHelper.__callBase_OnNewIntent(intent);
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

	// Token: 0x0601E446 RID: 123974 RVA: 0x009BA81C File Offset: 0x009B8A1C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_EnableUIInput(IntPtr l)
	{
		int result;
		try
		{
			GuildGameListUITask guildGameListUITask = (GuildGameListUITask)LuaObject.checkSelf(l);
			bool isEnable;
			LuaObject.checkType(l, 2, out isEnable);
			bool? isGlobalEnable;
			LuaObject.checkNullable<bool>(l, 3, out isGlobalEnable);
			guildGameListUITask.m_luaExportHelper.__callBase_EnableUIInput(isEnable, isGlobalEnable);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601E447 RID: 123975 RVA: 0x009BA888 File Offset: 0x009B8A88
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_IsNeedLoadDynamicRes(IntPtr l)
	{
		int result;
		try
		{
			GuildGameListUITask guildGameListUITask = (GuildGameListUITask)LuaObject.checkSelf(l);
			bool b = guildGameListUITask.m_luaExportHelper.__callBase_IsNeedLoadDynamicRes();
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

	// Token: 0x0601E448 RID: 123976 RVA: 0x009BA8E4 File Offset: 0x009B8AE4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_CollectAllDynamicResForLoad(IntPtr l)
	{
		int result;
		try
		{
			GuildGameListUITask guildGameListUITask = (GuildGameListUITask)LuaObject.checkSelf(l);
			List<string> o = guildGameListUITask.m_luaExportHelper.__callBase_CollectAllDynamicResForLoad();
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

	// Token: 0x0601E449 RID: 123977 RVA: 0x009BA940 File Offset: 0x009B8B40
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_RegisterPlayerContextEvents(IntPtr l)
	{
		int result;
		try
		{
			GuildGameListUITask guildGameListUITask = (GuildGameListUITask)LuaObject.checkSelf(l);
			guildGameListUITask.m_luaExportHelper.__callBase_RegisterPlayerContextEvents();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601E44A RID: 123978 RVA: 0x009BA994 File Offset: 0x009B8B94
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_UnregisterPlayerContextEvents(IntPtr l)
	{
		int result;
		try
		{
			GuildGameListUITask guildGameListUITask = (GuildGameListUITask)LuaObject.checkSelf(l);
			guildGameListUITask.m_luaExportHelper.__callBase_UnregisterPlayerContextEvents();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601E44B RID: 123979 RVA: 0x009BA9E8 File Offset: 0x009B8BE8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_PostUpdateView(IntPtr l)
	{
		int result;
		try
		{
			GuildGameListUITask guildGameListUITask = (GuildGameListUITask)LuaObject.checkSelf(l);
			guildGameListUITask.m_luaExportHelper.__callBase_PostUpdateView();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601E44C RID: 123980 RVA: 0x009BAA3C File Offset: 0x009B8C3C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_CollectPreloadResourceList(IntPtr l)
	{
		int result;
		try
		{
			GuildGameListUITask guildGameListUITask = (GuildGameListUITask)LuaObject.checkSelf(l);
			guildGameListUITask.m_luaExportHelper.__callBase_CollectPreloadResourceList();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601E44D RID: 123981 RVA: 0x009BAA90 File Offset: 0x009B8C90
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_ClearAssetList(IntPtr l)
	{
		int result;
		try
		{
			GuildGameListUITask guildGameListUITask = (GuildGameListUITask)LuaObject.checkSelf(l);
			guildGameListUITask.m_luaExportHelper.__callBase_ClearAssetList();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601E44E RID: 123982 RVA: 0x009BAAE4 File Offset: 0x009B8CE4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_CollectAsset(IntPtr l)
	{
		int result;
		try
		{
			GuildGameListUITask guildGameListUITask = (GuildGameListUITask)LuaObject.checkSelf(l);
			string assetName;
			LuaObject.checkType(l, 2, out assetName);
			guildGameListUITask.m_luaExportHelper.__callBase_CollectAsset(assetName);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601E44F RID: 123983 RVA: 0x009BAB40 File Offset: 0x009B8D40
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_CollectSpriteAsset(IntPtr l)
	{
		int result;
		try
		{
			GuildGameListUITask guildGameListUITask = (GuildGameListUITask)LuaObject.checkSelf(l);
			string assetName;
			LuaObject.checkType(l, 2, out assetName);
			guildGameListUITask.m_luaExportHelper.__callBase_CollectSpriteAsset(assetName);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601E450 RID: 123984 RVA: 0x009BAB9C File Offset: 0x009B8D9C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_CollectFxAsset(IntPtr l)
	{
		int result;
		try
		{
			GuildGameListUITask guildGameListUITask = (GuildGameListUITask)LuaObject.checkSelf(l);
			string assetName;
			LuaObject.checkType(l, 2, out assetName);
			guildGameListUITask.m_luaExportHelper.__callBase_CollectFxAsset(assetName);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601E451 RID: 123985 RVA: 0x009BABF8 File Offset: 0x009B8DF8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_StartLoadCustomAssets(IntPtr l)
	{
		int result;
		try
		{
			GuildGameListUITask guildGameListUITask = (GuildGameListUITask)LuaObject.checkSelf(l);
			Action onLoadCompleted;
			LuaObject.checkDelegate<Action>(l, 2, out onLoadCompleted);
			guildGameListUITask.m_luaExportHelper.__callBase_StartLoadCustomAssets(onLoadCompleted);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601E452 RID: 123986 RVA: 0x009BAC54 File Offset: 0x009B8E54
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_IsLoadingCustomAssets(IntPtr l)
	{
		int result;
		try
		{
			GuildGameListUITask guildGameListUITask = (GuildGameListUITask)LuaObject.checkSelf(l);
			bool b = guildGameListUITask.m_luaExportHelper.__callBase_IsLoadingCustomAssets();
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

	// Token: 0x0601E453 RID: 123987 RVA: 0x009BACB0 File Offset: 0x009B8EB0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_IsPipeLineRunning(IntPtr l)
	{
		int result;
		try
		{
			GuildGameListUITask guildGameListUITask = (GuildGameListUITask)LuaObject.checkSelf(l);
			bool b = guildGameListUITask.m_luaExportHelper.__callBase_IsPipeLineRunning();
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

	// Token: 0x0601E454 RID: 123988 RVA: 0x009BAD0C File Offset: 0x009B8F0C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_IsOpeningUI(IntPtr l)
	{
		int result;
		try
		{
			GuildGameListUITask guildGameListUITask = (GuildGameListUITask)LuaObject.checkSelf(l);
			bool b = guildGameListUITask.m_luaExportHelper.__callBase_IsOpeningUI();
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

	// Token: 0x0601E455 RID: 123989 RVA: 0x009BAD68 File Offset: 0x009B8F68
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_ReturnPrevUITask(IntPtr l)
	{
		int result;
		try
		{
			GuildGameListUITask guildGameListUITask = (GuildGameListUITask)LuaObject.checkSelf(l);
			UITaskBase o = guildGameListUITask.m_luaExportHelper.__callBase_ReturnPrevUITask();
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

	// Token: 0x0601E456 RID: 123990 RVA: 0x009BADC4 File Offset: 0x009B8FC4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_ClearUnusedDynamicResourceCache(IntPtr l)
	{
		int result;
		try
		{
			GuildGameListUITask guildGameListUITask = (GuildGameListUITask)LuaObject.checkSelf(l);
			guildGameListUITask.m_luaExportHelper.__callBase_ClearUnusedDynamicResourceCache();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601E457 RID: 123991 RVA: 0x009BAE18 File Offset: 0x009B9018
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_OnMemoryWarning(IntPtr l)
	{
		int result;
		try
		{
			GuildGameListUITask guildGameListUITask = (GuildGameListUITask)LuaObject.checkSelf(l);
			guildGameListUITask.m_luaExportHelper.__callBase_OnMemoryWarning();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601E458 RID: 123992 RVA: 0x009BAE6C File Offset: 0x009B906C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_layerDescArray(IntPtr l)
	{
		int result;
		try
		{
			GuildGameListUITask guildGameListUITask = (GuildGameListUITask)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, guildGameListUITask.m_luaExportHelper.m_layerDescArray);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601E459 RID: 123993 RVA: 0x009BAEC4 File Offset: 0x009B90C4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_layerDescArray(IntPtr l)
	{
		int result;
		try
		{
			GuildGameListUITask guildGameListUITask = (GuildGameListUITask)LuaObject.checkSelf(l);
			UITaskBase.LayerDesc[] layerDescArray;
			LuaObject.checkArray<UITaskBase.LayerDesc>(l, 2, out layerDescArray);
			guildGameListUITask.m_luaExportHelper.m_layerDescArray = layerDescArray;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601E45A RID: 123994 RVA: 0x009BAF20 File Offset: 0x009B9120
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_uiCtrlDescArray(IntPtr l)
	{
		int result;
		try
		{
			GuildGameListUITask guildGameListUITask = (GuildGameListUITask)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, guildGameListUITask.m_luaExportHelper.m_uiCtrlDescArray);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601E45B RID: 123995 RVA: 0x009BAF78 File Offset: 0x009B9178
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_uiCtrlDescArray(IntPtr l)
	{
		int result;
		try
		{
			GuildGameListUITask guildGameListUITask = (GuildGameListUITask)LuaObject.checkSelf(l);
			UITaskBase.UIControllerDesc[] uiCtrlDescArray;
			LuaObject.checkArray<UITaskBase.UIControllerDesc>(l, 2, out uiCtrlDescArray);
			guildGameListUITask.m_luaExportHelper.m_uiCtrlDescArray = uiCtrlDescArray;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601E45C RID: 123996 RVA: 0x009BAFD4 File Offset: 0x009B91D4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_guildGameListUIController(IntPtr l)
	{
		int result;
		try
		{
			GuildGameListUITask guildGameListUITask = (GuildGameListUITask)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, guildGameListUITask.m_luaExportHelper.m_guildGameListUIController);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601E45D RID: 123997 RVA: 0x009BB02C File Offset: 0x009B922C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_guildGameListUIController(IntPtr l)
	{
		int result;
		try
		{
			GuildGameListUITask guildGameListUITask = (GuildGameListUITask)LuaObject.checkSelf(l);
			GuildGameListUIController guildGameListUIController;
			LuaObject.checkType<GuildGameListUIController>(l, 2, out guildGameListUIController);
			guildGameListUITask.m_luaExportHelper.m_guildGameListUIController = guildGameListUIController;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601E45E RID: 123998 RVA: 0x009BB088 File Offset: 0x009B9288
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_LayerDescArray(IntPtr l)
	{
		int result;
		try
		{
			GuildGameListUITask guildGameListUITask = (GuildGameListUITask)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, guildGameListUITask.m_luaExportHelper.LayerDescArray);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601E45F RID: 123999 RVA: 0x009BB0E0 File Offset: 0x009B92E0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_UICtrlDescArray(IntPtr l)
	{
		int result;
		try
		{
			GuildGameListUITask guildGameListUITask = (GuildGameListUITask)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, guildGameListUITask.m_luaExportHelper.UICtrlDescArray);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601E460 RID: 124000 RVA: 0x009BB138 File Offset: 0x009B9338
	[Preserve]
	public static void reg(IntPtr l)
	{
		LuaObject.getTypeTable(l, "BlackJack.ProjectL.UI.GuildGameListUITask");
		if (Lua_BlackJack_ProjectL_UI_GuildGameListUITask.<>f__mg$cache0 == null)
		{
			Lua_BlackJack_ProjectL_UI_GuildGameListUITask.<>f__mg$cache0 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_GuildGameListUITask.IsNeedLoadDynamicRes);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_GuildGameListUITask.<>f__mg$cache0);
		if (Lua_BlackJack_ProjectL_UI_GuildGameListUITask.<>f__mg$cache1 == null)
		{
			Lua_BlackJack_ProjectL_UI_GuildGameListUITask.<>f__mg$cache1 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_GuildGameListUITask.InitAllUIControllers);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_GuildGameListUITask.<>f__mg$cache1);
		if (Lua_BlackJack_ProjectL_UI_GuildGameListUITask.<>f__mg$cache2 == null)
		{
			Lua_BlackJack_ProjectL_UI_GuildGameListUITask.<>f__mg$cache2 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_GuildGameListUITask.ClearAllContextAndRes);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_GuildGameListUITask.<>f__mg$cache2);
		if (Lua_BlackJack_ProjectL_UI_GuildGameListUITask.<>f__mg$cache3 == null)
		{
			Lua_BlackJack_ProjectL_UI_GuildGameListUITask.<>f__mg$cache3 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_GuildGameListUITask.UpdateView);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_GuildGameListUITask.<>f__mg$cache3);
		if (Lua_BlackJack_ProjectL_UI_GuildGameListUITask.<>f__mg$cache4 == null)
		{
			Lua_BlackJack_ProjectL_UI_GuildGameListUITask.<>f__mg$cache4 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_GuildGameListUITask.PostUpdateView);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_GuildGameListUITask.<>f__mg$cache4);
		if (Lua_BlackJack_ProjectL_UI_GuildGameListUITask.<>f__mg$cache5 == null)
		{
			Lua_BlackJack_ProjectL_UI_GuildGameListUITask.<>f__mg$cache5 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_GuildGameListUITask.OnClose);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_GuildGameListUITask.<>f__mg$cache5);
		if (Lua_BlackJack_ProjectL_UI_GuildGameListUITask.<>f__mg$cache6 == null)
		{
			Lua_BlackJack_ProjectL_UI_GuildGameListUITask.<>f__mg$cache6 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_GuildGameListUITask.GuildGameListUIController_OnGuildPlayListItemClick);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_GuildGameListUITask.<>f__mg$cache6);
		if (Lua_BlackJack_ProjectL_UI_GuildGameListUITask.<>f__mg$cache7 == null)
		{
			Lua_BlackJack_ProjectL_UI_GuildGameListUITask.<>f__mg$cache7 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_GuildGameListUITask.GuildRaidUITask_OnLoadAllResCompleted);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_GuildGameListUITask.<>f__mg$cache7);
		if (Lua_BlackJack_ProjectL_UI_GuildGameListUITask.<>f__mg$cache8 == null)
		{
			Lua_BlackJack_ProjectL_UI_GuildGameListUITask.<>f__mg$cache8 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_GuildGameListUITask.GuildMassiveCombatUITask_OnLoadAllResCompleted);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_GuildGameListUITask.<>f__mg$cache8);
		if (Lua_BlackJack_ProjectL_UI_GuildGameListUITask.<>f__mg$cache9 == null)
		{
			Lua_BlackJack_ProjectL_UI_GuildGameListUITask.<>f__mg$cache9 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_GuildGameListUITask.__callBase_OnStart);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_GuildGameListUITask.<>f__mg$cache9);
		if (Lua_BlackJack_ProjectL_UI_GuildGameListUITask.<>f__mg$cacheA == null)
		{
			Lua_BlackJack_ProjectL_UI_GuildGameListUITask.<>f__mg$cacheA = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_GuildGameListUITask.__callBase_OnStop);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_GuildGameListUITask.<>f__mg$cacheA);
		if (Lua_BlackJack_ProjectL_UI_GuildGameListUITask.<>f__mg$cacheB == null)
		{
			Lua_BlackJack_ProjectL_UI_GuildGameListUITask.<>f__mg$cacheB = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_GuildGameListUITask.__callBase_OnPause);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_GuildGameListUITask.<>f__mg$cacheB);
		if (Lua_BlackJack_ProjectL_UI_GuildGameListUITask.<>f__mg$cacheC == null)
		{
			Lua_BlackJack_ProjectL_UI_GuildGameListUITask.<>f__mg$cacheC = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_GuildGameListUITask.__callBase_OnResume);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_GuildGameListUITask.<>f__mg$cacheC);
		if (Lua_BlackJack_ProjectL_UI_GuildGameListUITask.<>f__mg$cacheD == null)
		{
			Lua_BlackJack_ProjectL_UI_GuildGameListUITask.<>f__mg$cacheD = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_GuildGameListUITask.__callBase_OnNewIntent);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_GuildGameListUITask.<>f__mg$cacheD);
		if (Lua_BlackJack_ProjectL_UI_GuildGameListUITask.<>f__mg$cacheE == null)
		{
			Lua_BlackJack_ProjectL_UI_GuildGameListUITask.<>f__mg$cacheE = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_GuildGameListUITask.__callBase_EnableUIInput);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_GuildGameListUITask.<>f__mg$cacheE);
		if (Lua_BlackJack_ProjectL_UI_GuildGameListUITask.<>f__mg$cacheF == null)
		{
			Lua_BlackJack_ProjectL_UI_GuildGameListUITask.<>f__mg$cacheF = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_GuildGameListUITask.__callBase_IsNeedLoadDynamicRes);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_GuildGameListUITask.<>f__mg$cacheF);
		if (Lua_BlackJack_ProjectL_UI_GuildGameListUITask.<>f__mg$cache10 == null)
		{
			Lua_BlackJack_ProjectL_UI_GuildGameListUITask.<>f__mg$cache10 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_GuildGameListUITask.__callBase_CollectAllDynamicResForLoad);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_GuildGameListUITask.<>f__mg$cache10);
		if (Lua_BlackJack_ProjectL_UI_GuildGameListUITask.<>f__mg$cache11 == null)
		{
			Lua_BlackJack_ProjectL_UI_GuildGameListUITask.<>f__mg$cache11 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_GuildGameListUITask.__callBase_RegisterPlayerContextEvents);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_GuildGameListUITask.<>f__mg$cache11);
		if (Lua_BlackJack_ProjectL_UI_GuildGameListUITask.<>f__mg$cache12 == null)
		{
			Lua_BlackJack_ProjectL_UI_GuildGameListUITask.<>f__mg$cache12 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_GuildGameListUITask.__callBase_UnregisterPlayerContextEvents);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_GuildGameListUITask.<>f__mg$cache12);
		if (Lua_BlackJack_ProjectL_UI_GuildGameListUITask.<>f__mg$cache13 == null)
		{
			Lua_BlackJack_ProjectL_UI_GuildGameListUITask.<>f__mg$cache13 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_GuildGameListUITask.__callBase_PostUpdateView);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_GuildGameListUITask.<>f__mg$cache13);
		if (Lua_BlackJack_ProjectL_UI_GuildGameListUITask.<>f__mg$cache14 == null)
		{
			Lua_BlackJack_ProjectL_UI_GuildGameListUITask.<>f__mg$cache14 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_GuildGameListUITask.__callBase_CollectPreloadResourceList);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_GuildGameListUITask.<>f__mg$cache14);
		if (Lua_BlackJack_ProjectL_UI_GuildGameListUITask.<>f__mg$cache15 == null)
		{
			Lua_BlackJack_ProjectL_UI_GuildGameListUITask.<>f__mg$cache15 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_GuildGameListUITask.__callBase_ClearAssetList);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_GuildGameListUITask.<>f__mg$cache15);
		if (Lua_BlackJack_ProjectL_UI_GuildGameListUITask.<>f__mg$cache16 == null)
		{
			Lua_BlackJack_ProjectL_UI_GuildGameListUITask.<>f__mg$cache16 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_GuildGameListUITask.__callBase_CollectAsset);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_GuildGameListUITask.<>f__mg$cache16);
		if (Lua_BlackJack_ProjectL_UI_GuildGameListUITask.<>f__mg$cache17 == null)
		{
			Lua_BlackJack_ProjectL_UI_GuildGameListUITask.<>f__mg$cache17 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_GuildGameListUITask.__callBase_CollectSpriteAsset);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_GuildGameListUITask.<>f__mg$cache17);
		if (Lua_BlackJack_ProjectL_UI_GuildGameListUITask.<>f__mg$cache18 == null)
		{
			Lua_BlackJack_ProjectL_UI_GuildGameListUITask.<>f__mg$cache18 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_GuildGameListUITask.__callBase_CollectFxAsset);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_GuildGameListUITask.<>f__mg$cache18);
		if (Lua_BlackJack_ProjectL_UI_GuildGameListUITask.<>f__mg$cache19 == null)
		{
			Lua_BlackJack_ProjectL_UI_GuildGameListUITask.<>f__mg$cache19 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_GuildGameListUITask.__callBase_StartLoadCustomAssets);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_GuildGameListUITask.<>f__mg$cache19);
		if (Lua_BlackJack_ProjectL_UI_GuildGameListUITask.<>f__mg$cache1A == null)
		{
			Lua_BlackJack_ProjectL_UI_GuildGameListUITask.<>f__mg$cache1A = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_GuildGameListUITask.__callBase_IsLoadingCustomAssets);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_GuildGameListUITask.<>f__mg$cache1A);
		if (Lua_BlackJack_ProjectL_UI_GuildGameListUITask.<>f__mg$cache1B == null)
		{
			Lua_BlackJack_ProjectL_UI_GuildGameListUITask.<>f__mg$cache1B = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_GuildGameListUITask.__callBase_IsPipeLineRunning);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_GuildGameListUITask.<>f__mg$cache1B);
		if (Lua_BlackJack_ProjectL_UI_GuildGameListUITask.<>f__mg$cache1C == null)
		{
			Lua_BlackJack_ProjectL_UI_GuildGameListUITask.<>f__mg$cache1C = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_GuildGameListUITask.__callBase_IsOpeningUI);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_GuildGameListUITask.<>f__mg$cache1C);
		if (Lua_BlackJack_ProjectL_UI_GuildGameListUITask.<>f__mg$cache1D == null)
		{
			Lua_BlackJack_ProjectL_UI_GuildGameListUITask.<>f__mg$cache1D = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_GuildGameListUITask.__callBase_ReturnPrevUITask);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_GuildGameListUITask.<>f__mg$cache1D);
		if (Lua_BlackJack_ProjectL_UI_GuildGameListUITask.<>f__mg$cache1E == null)
		{
			Lua_BlackJack_ProjectL_UI_GuildGameListUITask.<>f__mg$cache1E = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_GuildGameListUITask.__callBase_ClearUnusedDynamicResourceCache);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_GuildGameListUITask.<>f__mg$cache1E);
		if (Lua_BlackJack_ProjectL_UI_GuildGameListUITask.<>f__mg$cache1F == null)
		{
			Lua_BlackJack_ProjectL_UI_GuildGameListUITask.<>f__mg$cache1F = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_GuildGameListUITask.__callBase_OnMemoryWarning);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_GuildGameListUITask.<>f__mg$cache1F);
		string name = "m_layerDescArray";
		if (Lua_BlackJack_ProjectL_UI_GuildGameListUITask.<>f__mg$cache20 == null)
		{
			Lua_BlackJack_ProjectL_UI_GuildGameListUITask.<>f__mg$cache20 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_GuildGameListUITask.get_m_layerDescArray);
		}
		LuaCSFunction get = Lua_BlackJack_ProjectL_UI_GuildGameListUITask.<>f__mg$cache20;
		if (Lua_BlackJack_ProjectL_UI_GuildGameListUITask.<>f__mg$cache21 == null)
		{
			Lua_BlackJack_ProjectL_UI_GuildGameListUITask.<>f__mg$cache21 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_GuildGameListUITask.set_m_layerDescArray);
		}
		LuaObject.addMember(l, name, get, Lua_BlackJack_ProjectL_UI_GuildGameListUITask.<>f__mg$cache21, true);
		string name2 = "m_uiCtrlDescArray";
		if (Lua_BlackJack_ProjectL_UI_GuildGameListUITask.<>f__mg$cache22 == null)
		{
			Lua_BlackJack_ProjectL_UI_GuildGameListUITask.<>f__mg$cache22 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_GuildGameListUITask.get_m_uiCtrlDescArray);
		}
		LuaCSFunction get2 = Lua_BlackJack_ProjectL_UI_GuildGameListUITask.<>f__mg$cache22;
		if (Lua_BlackJack_ProjectL_UI_GuildGameListUITask.<>f__mg$cache23 == null)
		{
			Lua_BlackJack_ProjectL_UI_GuildGameListUITask.<>f__mg$cache23 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_GuildGameListUITask.set_m_uiCtrlDescArray);
		}
		LuaObject.addMember(l, name2, get2, Lua_BlackJack_ProjectL_UI_GuildGameListUITask.<>f__mg$cache23, true);
		string name3 = "m_guildGameListUIController";
		if (Lua_BlackJack_ProjectL_UI_GuildGameListUITask.<>f__mg$cache24 == null)
		{
			Lua_BlackJack_ProjectL_UI_GuildGameListUITask.<>f__mg$cache24 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_GuildGameListUITask.get_m_guildGameListUIController);
		}
		LuaCSFunction get3 = Lua_BlackJack_ProjectL_UI_GuildGameListUITask.<>f__mg$cache24;
		if (Lua_BlackJack_ProjectL_UI_GuildGameListUITask.<>f__mg$cache25 == null)
		{
			Lua_BlackJack_ProjectL_UI_GuildGameListUITask.<>f__mg$cache25 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_GuildGameListUITask.set_m_guildGameListUIController);
		}
		LuaObject.addMember(l, name3, get3, Lua_BlackJack_ProjectL_UI_GuildGameListUITask.<>f__mg$cache25, true);
		string name4 = "LayerDescArray";
		if (Lua_BlackJack_ProjectL_UI_GuildGameListUITask.<>f__mg$cache26 == null)
		{
			Lua_BlackJack_ProjectL_UI_GuildGameListUITask.<>f__mg$cache26 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_GuildGameListUITask.get_LayerDescArray);
		}
		LuaObject.addMember(l, name4, Lua_BlackJack_ProjectL_UI_GuildGameListUITask.<>f__mg$cache26, null, true);
		string name5 = "UICtrlDescArray";
		if (Lua_BlackJack_ProjectL_UI_GuildGameListUITask.<>f__mg$cache27 == null)
		{
			Lua_BlackJack_ProjectL_UI_GuildGameListUITask.<>f__mg$cache27 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_GuildGameListUITask.get_UICtrlDescArray);
		}
		LuaObject.addMember(l, name5, Lua_BlackJack_ProjectL_UI_GuildGameListUITask.<>f__mg$cache27, null, true);
		if (Lua_BlackJack_ProjectL_UI_GuildGameListUITask.<>f__mg$cache28 == null)
		{
			Lua_BlackJack_ProjectL_UI_GuildGameListUITask.<>f__mg$cache28 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_GuildGameListUITask.constructor);
		}
		LuaObject.createTypeMetatable(l, Lua_BlackJack_ProjectL_UI_GuildGameListUITask.<>f__mg$cache28, typeof(GuildGameListUITask), typeof(UITask));
	}

	// Token: 0x04014533 RID: 83251
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache0;

	// Token: 0x04014534 RID: 83252
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1;

	// Token: 0x04014535 RID: 83253
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2;

	// Token: 0x04014536 RID: 83254
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3;

	// Token: 0x04014537 RID: 83255
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache4;

	// Token: 0x04014538 RID: 83256
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache5;

	// Token: 0x04014539 RID: 83257
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache6;

	// Token: 0x0401453A RID: 83258
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache7;

	// Token: 0x0401453B RID: 83259
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache8;

	// Token: 0x0401453C RID: 83260
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache9;

	// Token: 0x0401453D RID: 83261
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheA;

	// Token: 0x0401453E RID: 83262
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheB;

	// Token: 0x0401453F RID: 83263
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheC;

	// Token: 0x04014540 RID: 83264
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheD;

	// Token: 0x04014541 RID: 83265
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheE;

	// Token: 0x04014542 RID: 83266
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheF;

	// Token: 0x04014543 RID: 83267
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache10;

	// Token: 0x04014544 RID: 83268
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache11;

	// Token: 0x04014545 RID: 83269
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache12;

	// Token: 0x04014546 RID: 83270
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache13;

	// Token: 0x04014547 RID: 83271
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache14;

	// Token: 0x04014548 RID: 83272
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache15;

	// Token: 0x04014549 RID: 83273
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache16;

	// Token: 0x0401454A RID: 83274
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache17;

	// Token: 0x0401454B RID: 83275
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache18;

	// Token: 0x0401454C RID: 83276
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache19;

	// Token: 0x0401454D RID: 83277
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1A;

	// Token: 0x0401454E RID: 83278
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1B;

	// Token: 0x0401454F RID: 83279
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1C;

	// Token: 0x04014550 RID: 83280
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1D;

	// Token: 0x04014551 RID: 83281
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1E;

	// Token: 0x04014552 RID: 83282
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1F;

	// Token: 0x04014553 RID: 83283
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache20;

	// Token: 0x04014554 RID: 83284
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache21;

	// Token: 0x04014555 RID: 83285
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache22;

	// Token: 0x04014556 RID: 83286
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache23;

	// Token: 0x04014557 RID: 83287
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache24;

	// Token: 0x04014558 RID: 83288
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache25;

	// Token: 0x04014559 RID: 83289
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache26;

	// Token: 0x0401455A RID: 83290
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache27;

	// Token: 0x0401455B RID: 83291
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache28;
}
