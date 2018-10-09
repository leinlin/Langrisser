using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using BlackJack.BJFramework.Runtime.UI;
using BlackJack.ConfigData;
using BlackJack.ProjectL.PlayerContext;
using BlackJack.ProjectL.UI;
using SLua;
using UnityEngine.Scripting;

// Token: 0x0200149B RID: 5275
[Preserve]
public class Lua_BlackJack_ProjectL_UI_GuildUITask : LuaObject
{
	// Token: 0x0601E887 RID: 125063 RVA: 0x009DBADC File Offset: 0x009D9CDC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int constructor(IntPtr l)
	{
		int result;
		try
		{
			string name;
			LuaObject.checkType(l, 2, out name);
			GuildUITask o = new GuildUITask(name);
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

	// Token: 0x0601E888 RID: 125064 RVA: 0x009DBB30 File Offset: 0x009D9D30
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int ReturnPrevUITaskWrap(IntPtr l)
	{
		int result;
		try
		{
			GuildUITask guildUITask = (GuildUITask)LuaObject.checkSelf(l);
			guildUITask.ReturnPrevUITaskWrap();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601E889 RID: 125065 RVA: 0x009DBB7C File Offset: 0x009D9D7C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int LoadRes(IntPtr l)
	{
		int result;
		try
		{
			GuildUITask guildUITask = (GuildUITask)LuaObject.checkSelf(l);
			List<string> assetList;
			LuaObject.checkType<List<string>>(l, 2, out assetList);
			Action onComplete;
			LuaObject.checkDelegate<Action>(l, 3, out onComplete);
			guildUITask.LoadRes(assetList, onComplete);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601E88A RID: 125066 RVA: 0x009DBBE0 File Offset: 0x009D9DE0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int UpdateView(IntPtr l)
	{
		int result;
		try
		{
			GuildUITask guildUITask = (GuildUITask)LuaObject.checkSelf(l);
			guildUITask.m_luaExportHelper.UpdateView();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601E88B RID: 125067 RVA: 0x009DBC34 File Offset: 0x009D9E34
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int InitAllUIControllers(IntPtr l)
	{
		int result;
		try
		{
			GuildUITask guildUITask = (GuildUITask)LuaObject.checkSelf(l);
			guildUITask.m_luaExportHelper.InitAllUIControllers();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601E88C RID: 125068 RVA: 0x009DBC88 File Offset: 0x009D9E88
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_OnStart(IntPtr l)
	{
		int result;
		try
		{
			GuildUITask guildUITask = (GuildUITask)LuaObject.checkSelf(l);
			UIIntent intent;
			LuaObject.checkType<UIIntent>(l, 2, out intent);
			bool b = guildUITask.m_luaExportHelper.__callBase_OnStart(intent);
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

	// Token: 0x0601E88D RID: 125069 RVA: 0x009DBCF0 File Offset: 0x009D9EF0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_OnStop(IntPtr l)
	{
		int result;
		try
		{
			GuildUITask guildUITask = (GuildUITask)LuaObject.checkSelf(l);
			guildUITask.m_luaExportHelper.__callBase_OnStop();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601E88E RID: 125070 RVA: 0x009DBD44 File Offset: 0x009D9F44
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int __callBase_OnPause(IntPtr l)
	{
		int result;
		try
		{
			GuildUITask guildUITask = (GuildUITask)LuaObject.checkSelf(l);
			guildUITask.m_luaExportHelper.__callBase_OnPause();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601E88F RID: 125071 RVA: 0x009DBD98 File Offset: 0x009D9F98
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_OnResume(IntPtr l)
	{
		int result;
		try
		{
			GuildUITask guildUITask = (GuildUITask)LuaObject.checkSelf(l);
			UIIntent intent;
			LuaObject.checkType<UIIntent>(l, 2, out intent);
			bool b = guildUITask.m_luaExportHelper.__callBase_OnResume(intent);
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

	// Token: 0x0601E890 RID: 125072 RVA: 0x009DBE00 File Offset: 0x009DA000
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_OnNewIntent(IntPtr l)
	{
		int result;
		try
		{
			GuildUITask guildUITask = (GuildUITask)LuaObject.checkSelf(l);
			UIIntent intent;
			LuaObject.checkType<UIIntent>(l, 2, out intent);
			bool b = guildUITask.m_luaExportHelper.__callBase_OnNewIntent(intent);
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

	// Token: 0x0601E891 RID: 125073 RVA: 0x009DBE68 File Offset: 0x009DA068
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int __callBase_EnableUIInput(IntPtr l)
	{
		int result;
		try
		{
			GuildUITask guildUITask = (GuildUITask)LuaObject.checkSelf(l);
			bool isEnable;
			LuaObject.checkType(l, 2, out isEnable);
			bool? isGlobalEnable;
			LuaObject.checkNullable<bool>(l, 3, out isGlobalEnable);
			guildUITask.m_luaExportHelper.__callBase_EnableUIInput(isEnable, isGlobalEnable);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601E892 RID: 125074 RVA: 0x009DBED4 File Offset: 0x009DA0D4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_IsNeedLoadDynamicRes(IntPtr l)
	{
		int result;
		try
		{
			GuildUITask guildUITask = (GuildUITask)LuaObject.checkSelf(l);
			bool b = guildUITask.m_luaExportHelper.__callBase_IsNeedLoadDynamicRes();
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

	// Token: 0x0601E893 RID: 125075 RVA: 0x009DBF30 File Offset: 0x009DA130
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_CollectAllDynamicResForLoad(IntPtr l)
	{
		int result;
		try
		{
			GuildUITask guildUITask = (GuildUITask)LuaObject.checkSelf(l);
			List<string> o = guildUITask.m_luaExportHelper.__callBase_CollectAllDynamicResForLoad();
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

	// Token: 0x0601E894 RID: 125076 RVA: 0x009DBF8C File Offset: 0x009DA18C
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int __callBase_RegisterPlayerContextEvents(IntPtr l)
	{
		int result;
		try
		{
			GuildUITask guildUITask = (GuildUITask)LuaObject.checkSelf(l);
			guildUITask.m_luaExportHelper.__callBase_RegisterPlayerContextEvents();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601E895 RID: 125077 RVA: 0x009DBFE0 File Offset: 0x009DA1E0
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int __callBase_UnregisterPlayerContextEvents(IntPtr l)
	{
		int result;
		try
		{
			GuildUITask guildUITask = (GuildUITask)LuaObject.checkSelf(l);
			guildUITask.m_luaExportHelper.__callBase_UnregisterPlayerContextEvents();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601E896 RID: 125078 RVA: 0x009DC034 File Offset: 0x009DA234
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int __callBase_PostUpdateView(IntPtr l)
	{
		int result;
		try
		{
			GuildUITask guildUITask = (GuildUITask)LuaObject.checkSelf(l);
			guildUITask.m_luaExportHelper.__callBase_PostUpdateView();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601E897 RID: 125079 RVA: 0x009DC088 File Offset: 0x009DA288
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int __callBase_CollectPreloadResourceList(IntPtr l)
	{
		int result;
		try
		{
			GuildUITask guildUITask = (GuildUITask)LuaObject.checkSelf(l);
			guildUITask.m_luaExportHelper.__callBase_CollectPreloadResourceList();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601E898 RID: 125080 RVA: 0x009DC0DC File Offset: 0x009DA2DC
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int __callBase_ClearAssetList(IntPtr l)
	{
		int result;
		try
		{
			GuildUITask guildUITask = (GuildUITask)LuaObject.checkSelf(l);
			guildUITask.m_luaExportHelper.__callBase_ClearAssetList();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601E899 RID: 125081 RVA: 0x009DC130 File Offset: 0x009DA330
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_CollectAsset(IntPtr l)
	{
		int result;
		try
		{
			GuildUITask guildUITask = (GuildUITask)LuaObject.checkSelf(l);
			string assetName;
			LuaObject.checkType(l, 2, out assetName);
			guildUITask.m_luaExportHelper.__callBase_CollectAsset(assetName);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601E89A RID: 125082 RVA: 0x009DC18C File Offset: 0x009DA38C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_CollectSpriteAsset(IntPtr l)
	{
		int result;
		try
		{
			GuildUITask guildUITask = (GuildUITask)LuaObject.checkSelf(l);
			string assetName;
			LuaObject.checkType(l, 2, out assetName);
			guildUITask.m_luaExportHelper.__callBase_CollectSpriteAsset(assetName);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601E89B RID: 125083 RVA: 0x009DC1E8 File Offset: 0x009DA3E8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_CollectFxAsset(IntPtr l)
	{
		int result;
		try
		{
			GuildUITask guildUITask = (GuildUITask)LuaObject.checkSelf(l);
			string assetName;
			LuaObject.checkType(l, 2, out assetName);
			guildUITask.m_luaExportHelper.__callBase_CollectFxAsset(assetName);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601E89C RID: 125084 RVA: 0x009DC244 File Offset: 0x009DA444
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int __callBase_StartLoadCustomAssets(IntPtr l)
	{
		int result;
		try
		{
			GuildUITask guildUITask = (GuildUITask)LuaObject.checkSelf(l);
			Action onLoadCompleted;
			LuaObject.checkDelegate<Action>(l, 2, out onLoadCompleted);
			guildUITask.m_luaExportHelper.__callBase_StartLoadCustomAssets(onLoadCompleted);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601E89D RID: 125085 RVA: 0x009DC2A0 File Offset: 0x009DA4A0
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int __callBase_IsLoadingCustomAssets(IntPtr l)
	{
		int result;
		try
		{
			GuildUITask guildUITask = (GuildUITask)LuaObject.checkSelf(l);
			bool b = guildUITask.m_luaExportHelper.__callBase_IsLoadingCustomAssets();
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

	// Token: 0x0601E89E RID: 125086 RVA: 0x009DC2FC File Offset: 0x009DA4FC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_IsPipeLineRunning(IntPtr l)
	{
		int result;
		try
		{
			GuildUITask guildUITask = (GuildUITask)LuaObject.checkSelf(l);
			bool b = guildUITask.m_luaExportHelper.__callBase_IsPipeLineRunning();
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

	// Token: 0x0601E89F RID: 125087 RVA: 0x009DC358 File Offset: 0x009DA558
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_IsOpeningUI(IntPtr l)
	{
		int result;
		try
		{
			GuildUITask guildUITask = (GuildUITask)LuaObject.checkSelf(l);
			bool b = guildUITask.m_luaExportHelper.__callBase_IsOpeningUI();
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

	// Token: 0x0601E8A0 RID: 125088 RVA: 0x009DC3B4 File Offset: 0x009DA5B4
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int __callBase_ReturnPrevUITask(IntPtr l)
	{
		int result;
		try
		{
			GuildUITask guildUITask = (GuildUITask)LuaObject.checkSelf(l);
			UITaskBase o = guildUITask.m_luaExportHelper.__callBase_ReturnPrevUITask();
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

	// Token: 0x0601E8A1 RID: 125089 RVA: 0x009DC410 File Offset: 0x009DA610
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_ClearUnusedDynamicResourceCache(IntPtr l)
	{
		int result;
		try
		{
			GuildUITask guildUITask = (GuildUITask)LuaObject.checkSelf(l);
			guildUITask.m_luaExportHelper.__callBase_ClearUnusedDynamicResourceCache();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601E8A2 RID: 125090 RVA: 0x009DC464 File Offset: 0x009DA664
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_OnMemoryWarning(IntPtr l)
	{
		int result;
		try
		{
			GuildUITask guildUITask = (GuildUITask)LuaObject.checkSelf(l);
			guildUITask.m_luaExportHelper.__callBase_OnMemoryWarning();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601E8A3 RID: 125091 RVA: 0x009DC4B8 File Offset: 0x009DA6B8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_layerDescArray(IntPtr l)
	{
		int result;
		try
		{
			GuildUITask guildUITask = (GuildUITask)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, guildUITask.m_luaExportHelper.m_layerDescArray);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601E8A4 RID: 125092 RVA: 0x009DC510 File Offset: 0x009DA710
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_layerDescArray(IntPtr l)
	{
		int result;
		try
		{
			GuildUITask guildUITask = (GuildUITask)LuaObject.checkSelf(l);
			UITaskBase.LayerDesc[] layerDescArray;
			LuaObject.checkArray<UITaskBase.LayerDesc>(l, 2, out layerDescArray);
			guildUITask.m_luaExportHelper.m_layerDescArray = layerDescArray;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601E8A5 RID: 125093 RVA: 0x009DC56C File Offset: 0x009DA76C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_uiCtrlDescArray(IntPtr l)
	{
		int result;
		try
		{
			GuildUITask guildUITask = (GuildUITask)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, guildUITask.m_luaExportHelper.m_uiCtrlDescArray);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601E8A6 RID: 125094 RVA: 0x009DC5C4 File Offset: 0x009DA7C4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_uiCtrlDescArray(IntPtr l)
	{
		int result;
		try
		{
			GuildUITask guildUITask = (GuildUITask)LuaObject.checkSelf(l);
			UITaskBase.UIControllerDesc[] uiCtrlDescArray;
			LuaObject.checkArray<UITaskBase.UIControllerDesc>(l, 2, out uiCtrlDescArray);
			guildUITask.m_luaExportHelper.m_uiCtrlDescArray = uiCtrlDescArray;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601E8A7 RID: 125095 RVA: 0x009DC620 File Offset: 0x009DA820
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_playerContext(IntPtr l)
	{
		int result;
		try
		{
			GuildUITask guildUITask = (GuildUITask)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, guildUITask.m_luaExportHelper.m_playerContext);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601E8A8 RID: 125096 RVA: 0x009DC678 File Offset: 0x009DA878
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_playerContext(IntPtr l)
	{
		int result;
		try
		{
			GuildUITask guildUITask = (GuildUITask)LuaObject.checkSelf(l);
			ProjectLPlayerContext playerContext;
			LuaObject.checkType<ProjectLPlayerContext>(l, 2, out playerContext);
			guildUITask.m_luaExportHelper.m_playerContext = playerContext;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601E8A9 RID: 125097 RVA: 0x009DC6D4 File Offset: 0x009DA8D4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_configDataLoader(IntPtr l)
	{
		int result;
		try
		{
			GuildUITask guildUITask = (GuildUITask)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, guildUITask.m_luaExportHelper.m_configDataLoader);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601E8AA RID: 125098 RVA: 0x009DC72C File Offset: 0x009DA92C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_configDataLoader(IntPtr l)
	{
		int result;
		try
		{
			GuildUITask guildUITask = (GuildUITask)LuaObject.checkSelf(l);
			IConfigDataLoader configDataLoader;
			LuaObject.checkType<IConfigDataLoader>(l, 2, out configDataLoader);
			guildUITask.m_luaExportHelper.m_configDataLoader = configDataLoader;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601E8AB RID: 125099 RVA: 0x009DC788 File Offset: 0x009DA988
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_LayerDescArray(IntPtr l)
	{
		int result;
		try
		{
			GuildUITask guildUITask = (GuildUITask)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, guildUITask.m_luaExportHelper.LayerDescArray);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601E8AC RID: 125100 RVA: 0x009DC7E0 File Offset: 0x009DA9E0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_UICtrlDescArray(IntPtr l)
	{
		int result;
		try
		{
			GuildUITask guildUITask = (GuildUITask)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, guildUITask.m_luaExportHelper.UICtrlDescArray);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601E8AD RID: 125101 RVA: 0x009DC838 File Offset: 0x009DAA38
	[Preserve]
	public static void reg(IntPtr l)
	{
		LuaObject.getTypeTable(l, "BlackJack.ProjectL.UI.GuildUITask");
		if (Lua_BlackJack_ProjectL_UI_GuildUITask.<>f__mg$cache0 == null)
		{
			Lua_BlackJack_ProjectL_UI_GuildUITask.<>f__mg$cache0 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_GuildUITask.ReturnPrevUITaskWrap);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_GuildUITask.<>f__mg$cache0);
		if (Lua_BlackJack_ProjectL_UI_GuildUITask.<>f__mg$cache1 == null)
		{
			Lua_BlackJack_ProjectL_UI_GuildUITask.<>f__mg$cache1 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_GuildUITask.LoadRes);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_GuildUITask.<>f__mg$cache1);
		if (Lua_BlackJack_ProjectL_UI_GuildUITask.<>f__mg$cache2 == null)
		{
			Lua_BlackJack_ProjectL_UI_GuildUITask.<>f__mg$cache2 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_GuildUITask.UpdateView);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_GuildUITask.<>f__mg$cache2);
		if (Lua_BlackJack_ProjectL_UI_GuildUITask.<>f__mg$cache3 == null)
		{
			Lua_BlackJack_ProjectL_UI_GuildUITask.<>f__mg$cache3 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_GuildUITask.InitAllUIControllers);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_GuildUITask.<>f__mg$cache3);
		if (Lua_BlackJack_ProjectL_UI_GuildUITask.<>f__mg$cache4 == null)
		{
			Lua_BlackJack_ProjectL_UI_GuildUITask.<>f__mg$cache4 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_GuildUITask.__callBase_OnStart);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_GuildUITask.<>f__mg$cache4);
		if (Lua_BlackJack_ProjectL_UI_GuildUITask.<>f__mg$cache5 == null)
		{
			Lua_BlackJack_ProjectL_UI_GuildUITask.<>f__mg$cache5 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_GuildUITask.__callBase_OnStop);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_GuildUITask.<>f__mg$cache5);
		if (Lua_BlackJack_ProjectL_UI_GuildUITask.<>f__mg$cache6 == null)
		{
			Lua_BlackJack_ProjectL_UI_GuildUITask.<>f__mg$cache6 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_GuildUITask.__callBase_OnPause);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_GuildUITask.<>f__mg$cache6);
		if (Lua_BlackJack_ProjectL_UI_GuildUITask.<>f__mg$cache7 == null)
		{
			Lua_BlackJack_ProjectL_UI_GuildUITask.<>f__mg$cache7 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_GuildUITask.__callBase_OnResume);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_GuildUITask.<>f__mg$cache7);
		if (Lua_BlackJack_ProjectL_UI_GuildUITask.<>f__mg$cache8 == null)
		{
			Lua_BlackJack_ProjectL_UI_GuildUITask.<>f__mg$cache8 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_GuildUITask.__callBase_OnNewIntent);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_GuildUITask.<>f__mg$cache8);
		if (Lua_BlackJack_ProjectL_UI_GuildUITask.<>f__mg$cache9 == null)
		{
			Lua_BlackJack_ProjectL_UI_GuildUITask.<>f__mg$cache9 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_GuildUITask.__callBase_EnableUIInput);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_GuildUITask.<>f__mg$cache9);
		if (Lua_BlackJack_ProjectL_UI_GuildUITask.<>f__mg$cacheA == null)
		{
			Lua_BlackJack_ProjectL_UI_GuildUITask.<>f__mg$cacheA = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_GuildUITask.__callBase_IsNeedLoadDynamicRes);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_GuildUITask.<>f__mg$cacheA);
		if (Lua_BlackJack_ProjectL_UI_GuildUITask.<>f__mg$cacheB == null)
		{
			Lua_BlackJack_ProjectL_UI_GuildUITask.<>f__mg$cacheB = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_GuildUITask.__callBase_CollectAllDynamicResForLoad);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_GuildUITask.<>f__mg$cacheB);
		if (Lua_BlackJack_ProjectL_UI_GuildUITask.<>f__mg$cacheC == null)
		{
			Lua_BlackJack_ProjectL_UI_GuildUITask.<>f__mg$cacheC = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_GuildUITask.__callBase_RegisterPlayerContextEvents);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_GuildUITask.<>f__mg$cacheC);
		if (Lua_BlackJack_ProjectL_UI_GuildUITask.<>f__mg$cacheD == null)
		{
			Lua_BlackJack_ProjectL_UI_GuildUITask.<>f__mg$cacheD = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_GuildUITask.__callBase_UnregisterPlayerContextEvents);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_GuildUITask.<>f__mg$cacheD);
		if (Lua_BlackJack_ProjectL_UI_GuildUITask.<>f__mg$cacheE == null)
		{
			Lua_BlackJack_ProjectL_UI_GuildUITask.<>f__mg$cacheE = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_GuildUITask.__callBase_PostUpdateView);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_GuildUITask.<>f__mg$cacheE);
		if (Lua_BlackJack_ProjectL_UI_GuildUITask.<>f__mg$cacheF == null)
		{
			Lua_BlackJack_ProjectL_UI_GuildUITask.<>f__mg$cacheF = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_GuildUITask.__callBase_CollectPreloadResourceList);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_GuildUITask.<>f__mg$cacheF);
		if (Lua_BlackJack_ProjectL_UI_GuildUITask.<>f__mg$cache10 == null)
		{
			Lua_BlackJack_ProjectL_UI_GuildUITask.<>f__mg$cache10 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_GuildUITask.__callBase_ClearAssetList);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_GuildUITask.<>f__mg$cache10);
		if (Lua_BlackJack_ProjectL_UI_GuildUITask.<>f__mg$cache11 == null)
		{
			Lua_BlackJack_ProjectL_UI_GuildUITask.<>f__mg$cache11 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_GuildUITask.__callBase_CollectAsset);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_GuildUITask.<>f__mg$cache11);
		if (Lua_BlackJack_ProjectL_UI_GuildUITask.<>f__mg$cache12 == null)
		{
			Lua_BlackJack_ProjectL_UI_GuildUITask.<>f__mg$cache12 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_GuildUITask.__callBase_CollectSpriteAsset);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_GuildUITask.<>f__mg$cache12);
		if (Lua_BlackJack_ProjectL_UI_GuildUITask.<>f__mg$cache13 == null)
		{
			Lua_BlackJack_ProjectL_UI_GuildUITask.<>f__mg$cache13 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_GuildUITask.__callBase_CollectFxAsset);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_GuildUITask.<>f__mg$cache13);
		if (Lua_BlackJack_ProjectL_UI_GuildUITask.<>f__mg$cache14 == null)
		{
			Lua_BlackJack_ProjectL_UI_GuildUITask.<>f__mg$cache14 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_GuildUITask.__callBase_StartLoadCustomAssets);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_GuildUITask.<>f__mg$cache14);
		if (Lua_BlackJack_ProjectL_UI_GuildUITask.<>f__mg$cache15 == null)
		{
			Lua_BlackJack_ProjectL_UI_GuildUITask.<>f__mg$cache15 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_GuildUITask.__callBase_IsLoadingCustomAssets);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_GuildUITask.<>f__mg$cache15);
		if (Lua_BlackJack_ProjectL_UI_GuildUITask.<>f__mg$cache16 == null)
		{
			Lua_BlackJack_ProjectL_UI_GuildUITask.<>f__mg$cache16 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_GuildUITask.__callBase_IsPipeLineRunning);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_GuildUITask.<>f__mg$cache16);
		if (Lua_BlackJack_ProjectL_UI_GuildUITask.<>f__mg$cache17 == null)
		{
			Lua_BlackJack_ProjectL_UI_GuildUITask.<>f__mg$cache17 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_GuildUITask.__callBase_IsOpeningUI);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_GuildUITask.<>f__mg$cache17);
		if (Lua_BlackJack_ProjectL_UI_GuildUITask.<>f__mg$cache18 == null)
		{
			Lua_BlackJack_ProjectL_UI_GuildUITask.<>f__mg$cache18 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_GuildUITask.__callBase_ReturnPrevUITask);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_GuildUITask.<>f__mg$cache18);
		if (Lua_BlackJack_ProjectL_UI_GuildUITask.<>f__mg$cache19 == null)
		{
			Lua_BlackJack_ProjectL_UI_GuildUITask.<>f__mg$cache19 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_GuildUITask.__callBase_ClearUnusedDynamicResourceCache);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_GuildUITask.<>f__mg$cache19);
		if (Lua_BlackJack_ProjectL_UI_GuildUITask.<>f__mg$cache1A == null)
		{
			Lua_BlackJack_ProjectL_UI_GuildUITask.<>f__mg$cache1A = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_GuildUITask.__callBase_OnMemoryWarning);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_GuildUITask.<>f__mg$cache1A);
		string name = "m_layerDescArray";
		if (Lua_BlackJack_ProjectL_UI_GuildUITask.<>f__mg$cache1B == null)
		{
			Lua_BlackJack_ProjectL_UI_GuildUITask.<>f__mg$cache1B = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_GuildUITask.get_m_layerDescArray);
		}
		LuaCSFunction get = Lua_BlackJack_ProjectL_UI_GuildUITask.<>f__mg$cache1B;
		if (Lua_BlackJack_ProjectL_UI_GuildUITask.<>f__mg$cache1C == null)
		{
			Lua_BlackJack_ProjectL_UI_GuildUITask.<>f__mg$cache1C = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_GuildUITask.set_m_layerDescArray);
		}
		LuaObject.addMember(l, name, get, Lua_BlackJack_ProjectL_UI_GuildUITask.<>f__mg$cache1C, true);
		string name2 = "m_uiCtrlDescArray";
		if (Lua_BlackJack_ProjectL_UI_GuildUITask.<>f__mg$cache1D == null)
		{
			Lua_BlackJack_ProjectL_UI_GuildUITask.<>f__mg$cache1D = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_GuildUITask.get_m_uiCtrlDescArray);
		}
		LuaCSFunction get2 = Lua_BlackJack_ProjectL_UI_GuildUITask.<>f__mg$cache1D;
		if (Lua_BlackJack_ProjectL_UI_GuildUITask.<>f__mg$cache1E == null)
		{
			Lua_BlackJack_ProjectL_UI_GuildUITask.<>f__mg$cache1E = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_GuildUITask.set_m_uiCtrlDescArray);
		}
		LuaObject.addMember(l, name2, get2, Lua_BlackJack_ProjectL_UI_GuildUITask.<>f__mg$cache1E, true);
		string name3 = "m_playerContext";
		if (Lua_BlackJack_ProjectL_UI_GuildUITask.<>f__mg$cache1F == null)
		{
			Lua_BlackJack_ProjectL_UI_GuildUITask.<>f__mg$cache1F = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_GuildUITask.get_m_playerContext);
		}
		LuaCSFunction get3 = Lua_BlackJack_ProjectL_UI_GuildUITask.<>f__mg$cache1F;
		if (Lua_BlackJack_ProjectL_UI_GuildUITask.<>f__mg$cache20 == null)
		{
			Lua_BlackJack_ProjectL_UI_GuildUITask.<>f__mg$cache20 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_GuildUITask.set_m_playerContext);
		}
		LuaObject.addMember(l, name3, get3, Lua_BlackJack_ProjectL_UI_GuildUITask.<>f__mg$cache20, true);
		string name4 = "m_configDataLoader";
		if (Lua_BlackJack_ProjectL_UI_GuildUITask.<>f__mg$cache21 == null)
		{
			Lua_BlackJack_ProjectL_UI_GuildUITask.<>f__mg$cache21 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_GuildUITask.get_m_configDataLoader);
		}
		LuaCSFunction get4 = Lua_BlackJack_ProjectL_UI_GuildUITask.<>f__mg$cache21;
		if (Lua_BlackJack_ProjectL_UI_GuildUITask.<>f__mg$cache22 == null)
		{
			Lua_BlackJack_ProjectL_UI_GuildUITask.<>f__mg$cache22 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_GuildUITask.set_m_configDataLoader);
		}
		LuaObject.addMember(l, name4, get4, Lua_BlackJack_ProjectL_UI_GuildUITask.<>f__mg$cache22, true);
		string name5 = "LayerDescArray";
		if (Lua_BlackJack_ProjectL_UI_GuildUITask.<>f__mg$cache23 == null)
		{
			Lua_BlackJack_ProjectL_UI_GuildUITask.<>f__mg$cache23 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_GuildUITask.get_LayerDescArray);
		}
		LuaObject.addMember(l, name5, Lua_BlackJack_ProjectL_UI_GuildUITask.<>f__mg$cache23, null, true);
		string name6 = "UICtrlDescArray";
		if (Lua_BlackJack_ProjectL_UI_GuildUITask.<>f__mg$cache24 == null)
		{
			Lua_BlackJack_ProjectL_UI_GuildUITask.<>f__mg$cache24 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_GuildUITask.get_UICtrlDescArray);
		}
		LuaObject.addMember(l, name6, Lua_BlackJack_ProjectL_UI_GuildUITask.<>f__mg$cache24, null, true);
		if (Lua_BlackJack_ProjectL_UI_GuildUITask.<>f__mg$cache25 == null)
		{
			Lua_BlackJack_ProjectL_UI_GuildUITask.<>f__mg$cache25 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_GuildUITask.constructor);
		}
		LuaObject.createTypeMetatable(l, Lua_BlackJack_ProjectL_UI_GuildUITask.<>f__mg$cache25, typeof(GuildUITask), typeof(UITask));
	}

	// Token: 0x04014933 RID: 84275
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache0;

	// Token: 0x04014934 RID: 84276
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1;

	// Token: 0x04014935 RID: 84277
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2;

	// Token: 0x04014936 RID: 84278
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3;

	// Token: 0x04014937 RID: 84279
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache4;

	// Token: 0x04014938 RID: 84280
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache5;

	// Token: 0x04014939 RID: 84281
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache6;

	// Token: 0x0401493A RID: 84282
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache7;

	// Token: 0x0401493B RID: 84283
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache8;

	// Token: 0x0401493C RID: 84284
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache9;

	// Token: 0x0401493D RID: 84285
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheA;

	// Token: 0x0401493E RID: 84286
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheB;

	// Token: 0x0401493F RID: 84287
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheC;

	// Token: 0x04014940 RID: 84288
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheD;

	// Token: 0x04014941 RID: 84289
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheE;

	// Token: 0x04014942 RID: 84290
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheF;

	// Token: 0x04014943 RID: 84291
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache10;

	// Token: 0x04014944 RID: 84292
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache11;

	// Token: 0x04014945 RID: 84293
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache12;

	// Token: 0x04014946 RID: 84294
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache13;

	// Token: 0x04014947 RID: 84295
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache14;

	// Token: 0x04014948 RID: 84296
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache15;

	// Token: 0x04014949 RID: 84297
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache16;

	// Token: 0x0401494A RID: 84298
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache17;

	// Token: 0x0401494B RID: 84299
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache18;

	// Token: 0x0401494C RID: 84300
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache19;

	// Token: 0x0401494D RID: 84301
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1A;

	// Token: 0x0401494E RID: 84302
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1B;

	// Token: 0x0401494F RID: 84303
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1C;

	// Token: 0x04014950 RID: 84304
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1D;

	// Token: 0x04014951 RID: 84305
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1E;

	// Token: 0x04014952 RID: 84306
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1F;

	// Token: 0x04014953 RID: 84307
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache20;

	// Token: 0x04014954 RID: 84308
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache21;

	// Token: 0x04014955 RID: 84309
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache22;

	// Token: 0x04014956 RID: 84310
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache23;

	// Token: 0x04014957 RID: 84311
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache24;

	// Token: 0x04014958 RID: 84312
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache25;
}
