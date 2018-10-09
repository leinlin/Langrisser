using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using BlackJack.BJFramework.Runtime.UI;
using BlackJack.ConfigData;
using BlackJack.ProjectL.UI;
using SLua;
using UnityEngine.Scripting;

// Token: 0x02001498 RID: 5272
[Preserve]
public class Lua_BlackJack_ProjectL_UI_GuildRaidUITask : LuaObject
{
	// Token: 0x0601E853 RID: 125011 RVA: 0x009DA3EC File Offset: 0x009D85EC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int constructor(IntPtr l)
	{
		int result;
		try
		{
			string name;
			LuaObject.checkType(l, 2, out name);
			GuildRaidUITask o = new GuildRaidUITask(name);
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

	// Token: 0x0601E854 RID: 125012 RVA: 0x009DA440 File Offset: 0x009D8640
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int IsNeedLoadDynamicRes(IntPtr l)
	{
		int result;
		try
		{
			GuildRaidUITask guildRaidUITask = (GuildRaidUITask)LuaObject.checkSelf(l);
			bool b = guildRaidUITask.m_luaExportHelper.IsNeedLoadDynamicRes();
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

	// Token: 0x0601E855 RID: 125013 RVA: 0x009DA49C File Offset: 0x009D869C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int InitAllUIControllers(IntPtr l)
	{
		int result;
		try
		{
			GuildRaidUITask guildRaidUITask = (GuildRaidUITask)LuaObject.checkSelf(l);
			guildRaidUITask.m_luaExportHelper.InitAllUIControllers();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601E856 RID: 125014 RVA: 0x009DA4F0 File Offset: 0x009D86F0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int ClearAllContextAndRes(IntPtr l)
	{
		int result;
		try
		{
			GuildRaidUITask guildRaidUITask = (GuildRaidUITask)LuaObject.checkSelf(l);
			guildRaidUITask.m_luaExportHelper.ClearAllContextAndRes();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601E857 RID: 125015 RVA: 0x009DA544 File Offset: 0x009D8744
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int UpdateView(IntPtr l)
	{
		int result;
		try
		{
			GuildRaidUITask guildRaidUITask = (GuildRaidUITask)LuaObject.checkSelf(l);
			guildRaidUITask.m_luaExportHelper.UpdateView();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601E858 RID: 125016 RVA: 0x009DA598 File Offset: 0x009D8798
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int OnClose(IntPtr l)
	{
		int result;
		try
		{
			GuildRaidUITask guildRaidUITask = (GuildRaidUITask)LuaObject.checkSelf(l);
			guildRaidUITask.m_luaExportHelper.OnClose();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601E859 RID: 125017 RVA: 0x009DA5EC File Offset: 0x009D87EC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int GuildRaidUIController_OnGuildRaidListItemClick(IntPtr l)
	{
		int result;
		try
		{
			GuildRaidUITask guildRaidUITask = (GuildRaidUITask)LuaObject.checkSelf(l);
			ConfigDataGuildMassiveCombatDifficultyInfo info;
			LuaObject.checkType<ConfigDataGuildMassiveCombatDifficultyInfo>(l, 2, out info);
			guildRaidUITask.m_luaExportHelper.GuildRaidUIController_OnGuildRaidListItemClick(info);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601E85A RID: 125018 RVA: 0x009DA648 File Offset: 0x009D8848
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int GotoGuildMassiveCombatUITask(IntPtr l)
	{
		int result;
		try
		{
			GuildRaidUITask guildRaidUITask = (GuildRaidUITask)LuaObject.checkSelf(l);
			guildRaidUITask.m_luaExportHelper.GotoGuildMassiveCombatUITask();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601E85B RID: 125019 RVA: 0x009DA69C File Offset: 0x009D889C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int GuildMassiveCombatUITask_OnLoadAllResCompleted(IntPtr l)
	{
		int result;
		try
		{
			GuildRaidUITask guildRaidUITask = (GuildRaidUITask)LuaObject.checkSelf(l);
			guildRaidUITask.m_luaExportHelper.GuildMassiveCombatUITask_OnLoadAllResCompleted();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601E85C RID: 125020 RVA: 0x009DA6F0 File Offset: 0x009D88F0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_OnStart(IntPtr l)
	{
		int result;
		try
		{
			GuildRaidUITask guildRaidUITask = (GuildRaidUITask)LuaObject.checkSelf(l);
			UIIntent intent;
			LuaObject.checkType<UIIntent>(l, 2, out intent);
			bool b = guildRaidUITask.m_luaExportHelper.__callBase_OnStart(intent);
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

	// Token: 0x0601E85D RID: 125021 RVA: 0x009DA758 File Offset: 0x009D8958
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_OnStop(IntPtr l)
	{
		int result;
		try
		{
			GuildRaidUITask guildRaidUITask = (GuildRaidUITask)LuaObject.checkSelf(l);
			guildRaidUITask.m_luaExportHelper.__callBase_OnStop();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601E85E RID: 125022 RVA: 0x009DA7AC File Offset: 0x009D89AC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_OnPause(IntPtr l)
	{
		int result;
		try
		{
			GuildRaidUITask guildRaidUITask = (GuildRaidUITask)LuaObject.checkSelf(l);
			guildRaidUITask.m_luaExportHelper.__callBase_OnPause();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601E85F RID: 125023 RVA: 0x009DA800 File Offset: 0x009D8A00
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_OnResume(IntPtr l)
	{
		int result;
		try
		{
			GuildRaidUITask guildRaidUITask = (GuildRaidUITask)LuaObject.checkSelf(l);
			UIIntent intent;
			LuaObject.checkType<UIIntent>(l, 2, out intent);
			bool b = guildRaidUITask.m_luaExportHelper.__callBase_OnResume(intent);
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

	// Token: 0x0601E860 RID: 125024 RVA: 0x009DA868 File Offset: 0x009D8A68
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_OnNewIntent(IntPtr l)
	{
		int result;
		try
		{
			GuildRaidUITask guildRaidUITask = (GuildRaidUITask)LuaObject.checkSelf(l);
			UIIntent intent;
			LuaObject.checkType<UIIntent>(l, 2, out intent);
			bool b = guildRaidUITask.m_luaExportHelper.__callBase_OnNewIntent(intent);
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

	// Token: 0x0601E861 RID: 125025 RVA: 0x009DA8D0 File Offset: 0x009D8AD0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_EnableUIInput(IntPtr l)
	{
		int result;
		try
		{
			GuildRaidUITask guildRaidUITask = (GuildRaidUITask)LuaObject.checkSelf(l);
			bool isEnable;
			LuaObject.checkType(l, 2, out isEnable);
			bool? isGlobalEnable;
			LuaObject.checkNullable<bool>(l, 3, out isGlobalEnable);
			guildRaidUITask.m_luaExportHelper.__callBase_EnableUIInput(isEnable, isGlobalEnable);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601E862 RID: 125026 RVA: 0x009DA93C File Offset: 0x009D8B3C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_IsNeedLoadDynamicRes(IntPtr l)
	{
		int result;
		try
		{
			GuildRaidUITask guildRaidUITask = (GuildRaidUITask)LuaObject.checkSelf(l);
			bool b = guildRaidUITask.m_luaExportHelper.__callBase_IsNeedLoadDynamicRes();
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

	// Token: 0x0601E863 RID: 125027 RVA: 0x009DA998 File Offset: 0x009D8B98
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_CollectAllDynamicResForLoad(IntPtr l)
	{
		int result;
		try
		{
			GuildRaidUITask guildRaidUITask = (GuildRaidUITask)LuaObject.checkSelf(l);
			List<string> o = guildRaidUITask.m_luaExportHelper.__callBase_CollectAllDynamicResForLoad();
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

	// Token: 0x0601E864 RID: 125028 RVA: 0x009DA9F4 File Offset: 0x009D8BF4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_RegisterPlayerContextEvents(IntPtr l)
	{
		int result;
		try
		{
			GuildRaidUITask guildRaidUITask = (GuildRaidUITask)LuaObject.checkSelf(l);
			guildRaidUITask.m_luaExportHelper.__callBase_RegisterPlayerContextEvents();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601E865 RID: 125029 RVA: 0x009DAA48 File Offset: 0x009D8C48
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_UnregisterPlayerContextEvents(IntPtr l)
	{
		int result;
		try
		{
			GuildRaidUITask guildRaidUITask = (GuildRaidUITask)LuaObject.checkSelf(l);
			guildRaidUITask.m_luaExportHelper.__callBase_UnregisterPlayerContextEvents();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601E866 RID: 125030 RVA: 0x009DAA9C File Offset: 0x009D8C9C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_PostUpdateView(IntPtr l)
	{
		int result;
		try
		{
			GuildRaidUITask guildRaidUITask = (GuildRaidUITask)LuaObject.checkSelf(l);
			guildRaidUITask.m_luaExportHelper.__callBase_PostUpdateView();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601E867 RID: 125031 RVA: 0x009DAAF0 File Offset: 0x009D8CF0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_CollectPreloadResourceList(IntPtr l)
	{
		int result;
		try
		{
			GuildRaidUITask guildRaidUITask = (GuildRaidUITask)LuaObject.checkSelf(l);
			guildRaidUITask.m_luaExportHelper.__callBase_CollectPreloadResourceList();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601E868 RID: 125032 RVA: 0x009DAB44 File Offset: 0x009D8D44
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_ClearAssetList(IntPtr l)
	{
		int result;
		try
		{
			GuildRaidUITask guildRaidUITask = (GuildRaidUITask)LuaObject.checkSelf(l);
			guildRaidUITask.m_luaExportHelper.__callBase_ClearAssetList();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601E869 RID: 125033 RVA: 0x009DAB98 File Offset: 0x009D8D98
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int __callBase_CollectAsset(IntPtr l)
	{
		int result;
		try
		{
			GuildRaidUITask guildRaidUITask = (GuildRaidUITask)LuaObject.checkSelf(l);
			string assetName;
			LuaObject.checkType(l, 2, out assetName);
			guildRaidUITask.m_luaExportHelper.__callBase_CollectAsset(assetName);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601E86A RID: 125034 RVA: 0x009DABF4 File Offset: 0x009D8DF4
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int __callBase_CollectSpriteAsset(IntPtr l)
	{
		int result;
		try
		{
			GuildRaidUITask guildRaidUITask = (GuildRaidUITask)LuaObject.checkSelf(l);
			string assetName;
			LuaObject.checkType(l, 2, out assetName);
			guildRaidUITask.m_luaExportHelper.__callBase_CollectSpriteAsset(assetName);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601E86B RID: 125035 RVA: 0x009DAC50 File Offset: 0x009D8E50
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int __callBase_CollectFxAsset(IntPtr l)
	{
		int result;
		try
		{
			GuildRaidUITask guildRaidUITask = (GuildRaidUITask)LuaObject.checkSelf(l);
			string assetName;
			LuaObject.checkType(l, 2, out assetName);
			guildRaidUITask.m_luaExportHelper.__callBase_CollectFxAsset(assetName);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601E86C RID: 125036 RVA: 0x009DACAC File Offset: 0x009D8EAC
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int __callBase_StartLoadCustomAssets(IntPtr l)
	{
		int result;
		try
		{
			GuildRaidUITask guildRaidUITask = (GuildRaidUITask)LuaObject.checkSelf(l);
			Action onLoadCompleted;
			LuaObject.checkDelegate<Action>(l, 2, out onLoadCompleted);
			guildRaidUITask.m_luaExportHelper.__callBase_StartLoadCustomAssets(onLoadCompleted);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601E86D RID: 125037 RVA: 0x009DAD08 File Offset: 0x009D8F08
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_IsLoadingCustomAssets(IntPtr l)
	{
		int result;
		try
		{
			GuildRaidUITask guildRaidUITask = (GuildRaidUITask)LuaObject.checkSelf(l);
			bool b = guildRaidUITask.m_luaExportHelper.__callBase_IsLoadingCustomAssets();
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

	// Token: 0x0601E86E RID: 125038 RVA: 0x009DAD64 File Offset: 0x009D8F64
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_IsPipeLineRunning(IntPtr l)
	{
		int result;
		try
		{
			GuildRaidUITask guildRaidUITask = (GuildRaidUITask)LuaObject.checkSelf(l);
			bool b = guildRaidUITask.m_luaExportHelper.__callBase_IsPipeLineRunning();
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

	// Token: 0x0601E86F RID: 125039 RVA: 0x009DADC0 File Offset: 0x009D8FC0
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int __callBase_IsOpeningUI(IntPtr l)
	{
		int result;
		try
		{
			GuildRaidUITask guildRaidUITask = (GuildRaidUITask)LuaObject.checkSelf(l);
			bool b = guildRaidUITask.m_luaExportHelper.__callBase_IsOpeningUI();
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

	// Token: 0x0601E870 RID: 125040 RVA: 0x009DAE1C File Offset: 0x009D901C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_ReturnPrevUITask(IntPtr l)
	{
		int result;
		try
		{
			GuildRaidUITask guildRaidUITask = (GuildRaidUITask)LuaObject.checkSelf(l);
			UITaskBase o = guildRaidUITask.m_luaExportHelper.__callBase_ReturnPrevUITask();
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

	// Token: 0x0601E871 RID: 125041 RVA: 0x009DAE78 File Offset: 0x009D9078
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int __callBase_ClearUnusedDynamicResourceCache(IntPtr l)
	{
		int result;
		try
		{
			GuildRaidUITask guildRaidUITask = (GuildRaidUITask)LuaObject.checkSelf(l);
			guildRaidUITask.m_luaExportHelper.__callBase_ClearUnusedDynamicResourceCache();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601E872 RID: 125042 RVA: 0x009DAECC File Offset: 0x009D90CC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_OnMemoryWarning(IntPtr l)
	{
		int result;
		try
		{
			GuildRaidUITask guildRaidUITask = (GuildRaidUITask)LuaObject.checkSelf(l);
			guildRaidUITask.m_luaExportHelper.__callBase_OnMemoryWarning();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601E873 RID: 125043 RVA: 0x009DAF20 File Offset: 0x009D9120
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_m_layerDescArray(IntPtr l)
	{
		int result;
		try
		{
			GuildRaidUITask guildRaidUITask = (GuildRaidUITask)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, guildRaidUITask.m_luaExportHelper.m_layerDescArray);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601E874 RID: 125044 RVA: 0x009DAF78 File Offset: 0x009D9178
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_layerDescArray(IntPtr l)
	{
		int result;
		try
		{
			GuildRaidUITask guildRaidUITask = (GuildRaidUITask)LuaObject.checkSelf(l);
			UITaskBase.LayerDesc[] layerDescArray;
			LuaObject.checkArray<UITaskBase.LayerDesc>(l, 2, out layerDescArray);
			guildRaidUITask.m_luaExportHelper.m_layerDescArray = layerDescArray;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601E875 RID: 125045 RVA: 0x009DAFD4 File Offset: 0x009D91D4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_uiCtrlDescArray(IntPtr l)
	{
		int result;
		try
		{
			GuildRaidUITask guildRaidUITask = (GuildRaidUITask)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, guildRaidUITask.m_luaExportHelper.m_uiCtrlDescArray);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601E876 RID: 125046 RVA: 0x009DB02C File Offset: 0x009D922C
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_m_uiCtrlDescArray(IntPtr l)
	{
		int result;
		try
		{
			GuildRaidUITask guildRaidUITask = (GuildRaidUITask)LuaObject.checkSelf(l);
			UITaskBase.UIControllerDesc[] uiCtrlDescArray;
			LuaObject.checkArray<UITaskBase.UIControllerDesc>(l, 2, out uiCtrlDescArray);
			guildRaidUITask.m_luaExportHelper.m_uiCtrlDescArray = uiCtrlDescArray;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601E877 RID: 125047 RVA: 0x009DB088 File Offset: 0x009D9288
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_m_guildRaidUIController(IntPtr l)
	{
		int result;
		try
		{
			GuildRaidUITask guildRaidUITask = (GuildRaidUITask)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, guildRaidUITask.m_luaExportHelper.m_guildRaidUIController);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601E878 RID: 125048 RVA: 0x009DB0E0 File Offset: 0x009D92E0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_guildRaidUIController(IntPtr l)
	{
		int result;
		try
		{
			GuildRaidUITask guildRaidUITask = (GuildRaidUITask)LuaObject.checkSelf(l);
			GuildRaidUIController guildRaidUIController;
			LuaObject.checkType<GuildRaidUIController>(l, 2, out guildRaidUIController);
			guildRaidUITask.m_luaExportHelper.m_guildRaidUIController = guildRaidUIController;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601E879 RID: 125049 RVA: 0x009DB13C File Offset: 0x009D933C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_LayerDescArray(IntPtr l)
	{
		int result;
		try
		{
			GuildRaidUITask guildRaidUITask = (GuildRaidUITask)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, guildRaidUITask.m_luaExportHelper.LayerDescArray);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601E87A RID: 125050 RVA: 0x009DB194 File Offset: 0x009D9394
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_UICtrlDescArray(IntPtr l)
	{
		int result;
		try
		{
			GuildRaidUITask guildRaidUITask = (GuildRaidUITask)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, guildRaidUITask.m_luaExportHelper.UICtrlDescArray);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601E87B RID: 125051 RVA: 0x009DB1EC File Offset: 0x009D93EC
	[Preserve]
	public static void reg(IntPtr l)
	{
		LuaObject.getTypeTable(l, "BlackJack.ProjectL.UI.GuildRaidUITask");
		if (Lua_BlackJack_ProjectL_UI_GuildRaidUITask.<>f__mg$cache0 == null)
		{
			Lua_BlackJack_ProjectL_UI_GuildRaidUITask.<>f__mg$cache0 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_GuildRaidUITask.IsNeedLoadDynamicRes);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_GuildRaidUITask.<>f__mg$cache0);
		if (Lua_BlackJack_ProjectL_UI_GuildRaidUITask.<>f__mg$cache1 == null)
		{
			Lua_BlackJack_ProjectL_UI_GuildRaidUITask.<>f__mg$cache1 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_GuildRaidUITask.InitAllUIControllers);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_GuildRaidUITask.<>f__mg$cache1);
		if (Lua_BlackJack_ProjectL_UI_GuildRaidUITask.<>f__mg$cache2 == null)
		{
			Lua_BlackJack_ProjectL_UI_GuildRaidUITask.<>f__mg$cache2 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_GuildRaidUITask.ClearAllContextAndRes);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_GuildRaidUITask.<>f__mg$cache2);
		if (Lua_BlackJack_ProjectL_UI_GuildRaidUITask.<>f__mg$cache3 == null)
		{
			Lua_BlackJack_ProjectL_UI_GuildRaidUITask.<>f__mg$cache3 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_GuildRaidUITask.UpdateView);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_GuildRaidUITask.<>f__mg$cache3);
		if (Lua_BlackJack_ProjectL_UI_GuildRaidUITask.<>f__mg$cache4 == null)
		{
			Lua_BlackJack_ProjectL_UI_GuildRaidUITask.<>f__mg$cache4 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_GuildRaidUITask.OnClose);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_GuildRaidUITask.<>f__mg$cache4);
		if (Lua_BlackJack_ProjectL_UI_GuildRaidUITask.<>f__mg$cache5 == null)
		{
			Lua_BlackJack_ProjectL_UI_GuildRaidUITask.<>f__mg$cache5 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_GuildRaidUITask.GuildRaidUIController_OnGuildRaidListItemClick);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_GuildRaidUITask.<>f__mg$cache5);
		if (Lua_BlackJack_ProjectL_UI_GuildRaidUITask.<>f__mg$cache6 == null)
		{
			Lua_BlackJack_ProjectL_UI_GuildRaidUITask.<>f__mg$cache6 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_GuildRaidUITask.GotoGuildMassiveCombatUITask);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_GuildRaidUITask.<>f__mg$cache6);
		if (Lua_BlackJack_ProjectL_UI_GuildRaidUITask.<>f__mg$cache7 == null)
		{
			Lua_BlackJack_ProjectL_UI_GuildRaidUITask.<>f__mg$cache7 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_GuildRaidUITask.GuildMassiveCombatUITask_OnLoadAllResCompleted);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_GuildRaidUITask.<>f__mg$cache7);
		if (Lua_BlackJack_ProjectL_UI_GuildRaidUITask.<>f__mg$cache8 == null)
		{
			Lua_BlackJack_ProjectL_UI_GuildRaidUITask.<>f__mg$cache8 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_GuildRaidUITask.__callBase_OnStart);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_GuildRaidUITask.<>f__mg$cache8);
		if (Lua_BlackJack_ProjectL_UI_GuildRaidUITask.<>f__mg$cache9 == null)
		{
			Lua_BlackJack_ProjectL_UI_GuildRaidUITask.<>f__mg$cache9 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_GuildRaidUITask.__callBase_OnStop);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_GuildRaidUITask.<>f__mg$cache9);
		if (Lua_BlackJack_ProjectL_UI_GuildRaidUITask.<>f__mg$cacheA == null)
		{
			Lua_BlackJack_ProjectL_UI_GuildRaidUITask.<>f__mg$cacheA = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_GuildRaidUITask.__callBase_OnPause);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_GuildRaidUITask.<>f__mg$cacheA);
		if (Lua_BlackJack_ProjectL_UI_GuildRaidUITask.<>f__mg$cacheB == null)
		{
			Lua_BlackJack_ProjectL_UI_GuildRaidUITask.<>f__mg$cacheB = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_GuildRaidUITask.__callBase_OnResume);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_GuildRaidUITask.<>f__mg$cacheB);
		if (Lua_BlackJack_ProjectL_UI_GuildRaidUITask.<>f__mg$cacheC == null)
		{
			Lua_BlackJack_ProjectL_UI_GuildRaidUITask.<>f__mg$cacheC = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_GuildRaidUITask.__callBase_OnNewIntent);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_GuildRaidUITask.<>f__mg$cacheC);
		if (Lua_BlackJack_ProjectL_UI_GuildRaidUITask.<>f__mg$cacheD == null)
		{
			Lua_BlackJack_ProjectL_UI_GuildRaidUITask.<>f__mg$cacheD = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_GuildRaidUITask.__callBase_EnableUIInput);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_GuildRaidUITask.<>f__mg$cacheD);
		if (Lua_BlackJack_ProjectL_UI_GuildRaidUITask.<>f__mg$cacheE == null)
		{
			Lua_BlackJack_ProjectL_UI_GuildRaidUITask.<>f__mg$cacheE = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_GuildRaidUITask.__callBase_IsNeedLoadDynamicRes);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_GuildRaidUITask.<>f__mg$cacheE);
		if (Lua_BlackJack_ProjectL_UI_GuildRaidUITask.<>f__mg$cacheF == null)
		{
			Lua_BlackJack_ProjectL_UI_GuildRaidUITask.<>f__mg$cacheF = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_GuildRaidUITask.__callBase_CollectAllDynamicResForLoad);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_GuildRaidUITask.<>f__mg$cacheF);
		if (Lua_BlackJack_ProjectL_UI_GuildRaidUITask.<>f__mg$cache10 == null)
		{
			Lua_BlackJack_ProjectL_UI_GuildRaidUITask.<>f__mg$cache10 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_GuildRaidUITask.__callBase_RegisterPlayerContextEvents);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_GuildRaidUITask.<>f__mg$cache10);
		if (Lua_BlackJack_ProjectL_UI_GuildRaidUITask.<>f__mg$cache11 == null)
		{
			Lua_BlackJack_ProjectL_UI_GuildRaidUITask.<>f__mg$cache11 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_GuildRaidUITask.__callBase_UnregisterPlayerContextEvents);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_GuildRaidUITask.<>f__mg$cache11);
		if (Lua_BlackJack_ProjectL_UI_GuildRaidUITask.<>f__mg$cache12 == null)
		{
			Lua_BlackJack_ProjectL_UI_GuildRaidUITask.<>f__mg$cache12 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_GuildRaidUITask.__callBase_PostUpdateView);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_GuildRaidUITask.<>f__mg$cache12);
		if (Lua_BlackJack_ProjectL_UI_GuildRaidUITask.<>f__mg$cache13 == null)
		{
			Lua_BlackJack_ProjectL_UI_GuildRaidUITask.<>f__mg$cache13 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_GuildRaidUITask.__callBase_CollectPreloadResourceList);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_GuildRaidUITask.<>f__mg$cache13);
		if (Lua_BlackJack_ProjectL_UI_GuildRaidUITask.<>f__mg$cache14 == null)
		{
			Lua_BlackJack_ProjectL_UI_GuildRaidUITask.<>f__mg$cache14 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_GuildRaidUITask.__callBase_ClearAssetList);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_GuildRaidUITask.<>f__mg$cache14);
		if (Lua_BlackJack_ProjectL_UI_GuildRaidUITask.<>f__mg$cache15 == null)
		{
			Lua_BlackJack_ProjectL_UI_GuildRaidUITask.<>f__mg$cache15 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_GuildRaidUITask.__callBase_CollectAsset);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_GuildRaidUITask.<>f__mg$cache15);
		if (Lua_BlackJack_ProjectL_UI_GuildRaidUITask.<>f__mg$cache16 == null)
		{
			Lua_BlackJack_ProjectL_UI_GuildRaidUITask.<>f__mg$cache16 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_GuildRaidUITask.__callBase_CollectSpriteAsset);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_GuildRaidUITask.<>f__mg$cache16);
		if (Lua_BlackJack_ProjectL_UI_GuildRaidUITask.<>f__mg$cache17 == null)
		{
			Lua_BlackJack_ProjectL_UI_GuildRaidUITask.<>f__mg$cache17 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_GuildRaidUITask.__callBase_CollectFxAsset);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_GuildRaidUITask.<>f__mg$cache17);
		if (Lua_BlackJack_ProjectL_UI_GuildRaidUITask.<>f__mg$cache18 == null)
		{
			Lua_BlackJack_ProjectL_UI_GuildRaidUITask.<>f__mg$cache18 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_GuildRaidUITask.__callBase_StartLoadCustomAssets);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_GuildRaidUITask.<>f__mg$cache18);
		if (Lua_BlackJack_ProjectL_UI_GuildRaidUITask.<>f__mg$cache19 == null)
		{
			Lua_BlackJack_ProjectL_UI_GuildRaidUITask.<>f__mg$cache19 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_GuildRaidUITask.__callBase_IsLoadingCustomAssets);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_GuildRaidUITask.<>f__mg$cache19);
		if (Lua_BlackJack_ProjectL_UI_GuildRaidUITask.<>f__mg$cache1A == null)
		{
			Lua_BlackJack_ProjectL_UI_GuildRaidUITask.<>f__mg$cache1A = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_GuildRaidUITask.__callBase_IsPipeLineRunning);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_GuildRaidUITask.<>f__mg$cache1A);
		if (Lua_BlackJack_ProjectL_UI_GuildRaidUITask.<>f__mg$cache1B == null)
		{
			Lua_BlackJack_ProjectL_UI_GuildRaidUITask.<>f__mg$cache1B = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_GuildRaidUITask.__callBase_IsOpeningUI);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_GuildRaidUITask.<>f__mg$cache1B);
		if (Lua_BlackJack_ProjectL_UI_GuildRaidUITask.<>f__mg$cache1C == null)
		{
			Lua_BlackJack_ProjectL_UI_GuildRaidUITask.<>f__mg$cache1C = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_GuildRaidUITask.__callBase_ReturnPrevUITask);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_GuildRaidUITask.<>f__mg$cache1C);
		if (Lua_BlackJack_ProjectL_UI_GuildRaidUITask.<>f__mg$cache1D == null)
		{
			Lua_BlackJack_ProjectL_UI_GuildRaidUITask.<>f__mg$cache1D = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_GuildRaidUITask.__callBase_ClearUnusedDynamicResourceCache);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_GuildRaidUITask.<>f__mg$cache1D);
		if (Lua_BlackJack_ProjectL_UI_GuildRaidUITask.<>f__mg$cache1E == null)
		{
			Lua_BlackJack_ProjectL_UI_GuildRaidUITask.<>f__mg$cache1E = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_GuildRaidUITask.__callBase_OnMemoryWarning);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_GuildRaidUITask.<>f__mg$cache1E);
		string name = "m_layerDescArray";
		if (Lua_BlackJack_ProjectL_UI_GuildRaidUITask.<>f__mg$cache1F == null)
		{
			Lua_BlackJack_ProjectL_UI_GuildRaidUITask.<>f__mg$cache1F = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_GuildRaidUITask.get_m_layerDescArray);
		}
		LuaCSFunction get = Lua_BlackJack_ProjectL_UI_GuildRaidUITask.<>f__mg$cache1F;
		if (Lua_BlackJack_ProjectL_UI_GuildRaidUITask.<>f__mg$cache20 == null)
		{
			Lua_BlackJack_ProjectL_UI_GuildRaidUITask.<>f__mg$cache20 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_GuildRaidUITask.set_m_layerDescArray);
		}
		LuaObject.addMember(l, name, get, Lua_BlackJack_ProjectL_UI_GuildRaidUITask.<>f__mg$cache20, true);
		string name2 = "m_uiCtrlDescArray";
		if (Lua_BlackJack_ProjectL_UI_GuildRaidUITask.<>f__mg$cache21 == null)
		{
			Lua_BlackJack_ProjectL_UI_GuildRaidUITask.<>f__mg$cache21 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_GuildRaidUITask.get_m_uiCtrlDescArray);
		}
		LuaCSFunction get2 = Lua_BlackJack_ProjectL_UI_GuildRaidUITask.<>f__mg$cache21;
		if (Lua_BlackJack_ProjectL_UI_GuildRaidUITask.<>f__mg$cache22 == null)
		{
			Lua_BlackJack_ProjectL_UI_GuildRaidUITask.<>f__mg$cache22 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_GuildRaidUITask.set_m_uiCtrlDescArray);
		}
		LuaObject.addMember(l, name2, get2, Lua_BlackJack_ProjectL_UI_GuildRaidUITask.<>f__mg$cache22, true);
		string name3 = "m_guildRaidUIController";
		if (Lua_BlackJack_ProjectL_UI_GuildRaidUITask.<>f__mg$cache23 == null)
		{
			Lua_BlackJack_ProjectL_UI_GuildRaidUITask.<>f__mg$cache23 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_GuildRaidUITask.get_m_guildRaidUIController);
		}
		LuaCSFunction get3 = Lua_BlackJack_ProjectL_UI_GuildRaidUITask.<>f__mg$cache23;
		if (Lua_BlackJack_ProjectL_UI_GuildRaidUITask.<>f__mg$cache24 == null)
		{
			Lua_BlackJack_ProjectL_UI_GuildRaidUITask.<>f__mg$cache24 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_GuildRaidUITask.set_m_guildRaidUIController);
		}
		LuaObject.addMember(l, name3, get3, Lua_BlackJack_ProjectL_UI_GuildRaidUITask.<>f__mg$cache24, true);
		string name4 = "LayerDescArray";
		if (Lua_BlackJack_ProjectL_UI_GuildRaidUITask.<>f__mg$cache25 == null)
		{
			Lua_BlackJack_ProjectL_UI_GuildRaidUITask.<>f__mg$cache25 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_GuildRaidUITask.get_LayerDescArray);
		}
		LuaObject.addMember(l, name4, Lua_BlackJack_ProjectL_UI_GuildRaidUITask.<>f__mg$cache25, null, true);
		string name5 = "UICtrlDescArray";
		if (Lua_BlackJack_ProjectL_UI_GuildRaidUITask.<>f__mg$cache26 == null)
		{
			Lua_BlackJack_ProjectL_UI_GuildRaidUITask.<>f__mg$cache26 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_GuildRaidUITask.get_UICtrlDescArray);
		}
		LuaObject.addMember(l, name5, Lua_BlackJack_ProjectL_UI_GuildRaidUITask.<>f__mg$cache26, null, true);
		if (Lua_BlackJack_ProjectL_UI_GuildRaidUITask.<>f__mg$cache27 == null)
		{
			Lua_BlackJack_ProjectL_UI_GuildRaidUITask.<>f__mg$cache27 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_GuildRaidUITask.constructor);
		}
		LuaObject.createTypeMetatable(l, Lua_BlackJack_ProjectL_UI_GuildRaidUITask.<>f__mg$cache27, typeof(GuildRaidUITask), typeof(UITask));
	}

	// Token: 0x04014905 RID: 84229
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache0;

	// Token: 0x04014906 RID: 84230
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1;

	// Token: 0x04014907 RID: 84231
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2;

	// Token: 0x04014908 RID: 84232
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3;

	// Token: 0x04014909 RID: 84233
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache4;

	// Token: 0x0401490A RID: 84234
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache5;

	// Token: 0x0401490B RID: 84235
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache6;

	// Token: 0x0401490C RID: 84236
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache7;

	// Token: 0x0401490D RID: 84237
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache8;

	// Token: 0x0401490E RID: 84238
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache9;

	// Token: 0x0401490F RID: 84239
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheA;

	// Token: 0x04014910 RID: 84240
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheB;

	// Token: 0x04014911 RID: 84241
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheC;

	// Token: 0x04014912 RID: 84242
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheD;

	// Token: 0x04014913 RID: 84243
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheE;

	// Token: 0x04014914 RID: 84244
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheF;

	// Token: 0x04014915 RID: 84245
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache10;

	// Token: 0x04014916 RID: 84246
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache11;

	// Token: 0x04014917 RID: 84247
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache12;

	// Token: 0x04014918 RID: 84248
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache13;

	// Token: 0x04014919 RID: 84249
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache14;

	// Token: 0x0401491A RID: 84250
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache15;

	// Token: 0x0401491B RID: 84251
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache16;

	// Token: 0x0401491C RID: 84252
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache17;

	// Token: 0x0401491D RID: 84253
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache18;

	// Token: 0x0401491E RID: 84254
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache19;

	// Token: 0x0401491F RID: 84255
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1A;

	// Token: 0x04014920 RID: 84256
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1B;

	// Token: 0x04014921 RID: 84257
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1C;

	// Token: 0x04014922 RID: 84258
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1D;

	// Token: 0x04014923 RID: 84259
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1E;

	// Token: 0x04014924 RID: 84260
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1F;

	// Token: 0x04014925 RID: 84261
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache20;

	// Token: 0x04014926 RID: 84262
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache21;

	// Token: 0x04014927 RID: 84263
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache22;

	// Token: 0x04014928 RID: 84264
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache23;

	// Token: 0x04014929 RID: 84265
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache24;

	// Token: 0x0401492A RID: 84266
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache25;

	// Token: 0x0401492B RID: 84267
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache26;

	// Token: 0x0401492C RID: 84268
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache27;
}
