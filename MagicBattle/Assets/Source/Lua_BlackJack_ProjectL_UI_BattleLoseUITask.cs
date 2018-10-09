using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using BlackJack.BJFramework.Runtime.UI;
using BlackJack.ProjectL.UI;
using SLua;
using UnityEngine.Scripting;

// Token: 0x020013A5 RID: 5029
[Preserve]
public class Lua_BlackJack_ProjectL_UI_BattleLoseUITask : LuaObject
{
	// Token: 0x0601B966 RID: 112998 RVA: 0x00865788 File Offset: 0x00863988
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int constructor(IntPtr l)
	{
		int result;
		try
		{
			string name;
			LuaObject.checkType(l, 2, out name);
			BattleLoseUITask o = new BattleLoseUITask(name);
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

	// Token: 0x0601B967 RID: 112999 RVA: 0x008657DC File Offset: 0x008639DC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int StartUITask_s(IntPtr l)
	{
		int result;
		try
		{
			BattleLoseUITask o = BattleLoseUITask.StartUITask();
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

	// Token: 0x0601B968 RID: 113000 RVA: 0x00865824 File Offset: 0x00863A24
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int InitAllUIControllers(IntPtr l)
	{
		int result;
		try
		{
			BattleLoseUITask battleLoseUITask = (BattleLoseUITask)LuaObject.checkSelf(l);
			battleLoseUITask.m_luaExportHelper.InitAllUIControllers();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601B969 RID: 113001 RVA: 0x00865878 File Offset: 0x00863A78
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int ClearAllContextAndRes(IntPtr l)
	{
		int result;
		try
		{
			BattleLoseUITask battleLoseUITask = (BattleLoseUITask)LuaObject.checkSelf(l);
			battleLoseUITask.m_luaExportHelper.ClearAllContextAndRes();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601B96A RID: 113002 RVA: 0x008658CC File Offset: 0x00863ACC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int UpdateView(IntPtr l)
	{
		int result;
		try
		{
			BattleLoseUITask battleLoseUITask = (BattleLoseUITask)LuaObject.checkSelf(l);
			battleLoseUITask.m_luaExportHelper.UpdateView();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601B96B RID: 113003 RVA: 0x00865920 File Offset: 0x00863B20
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int BattleLoseUIController_OnClose(IntPtr l)
	{
		int result;
		try
		{
			BattleLoseUITask battleLoseUITask = (BattleLoseUITask)LuaObject.checkSelf(l);
			battleLoseUITask.m_luaExportHelper.BattleLoseUIController_OnClose();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601B96C RID: 113004 RVA: 0x00865974 File Offset: 0x00863B74
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_OnStart(IntPtr l)
	{
		int result;
		try
		{
			BattleLoseUITask battleLoseUITask = (BattleLoseUITask)LuaObject.checkSelf(l);
			UIIntent intent;
			LuaObject.checkType<UIIntent>(l, 2, out intent);
			bool b = battleLoseUITask.m_luaExportHelper.__callBase_OnStart(intent);
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

	// Token: 0x0601B96D RID: 113005 RVA: 0x008659DC File Offset: 0x00863BDC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_OnStop(IntPtr l)
	{
		int result;
		try
		{
			BattleLoseUITask battleLoseUITask = (BattleLoseUITask)LuaObject.checkSelf(l);
			battleLoseUITask.m_luaExportHelper.__callBase_OnStop();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601B96E RID: 113006 RVA: 0x00865A30 File Offset: 0x00863C30
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_OnPause(IntPtr l)
	{
		int result;
		try
		{
			BattleLoseUITask battleLoseUITask = (BattleLoseUITask)LuaObject.checkSelf(l);
			battleLoseUITask.m_luaExportHelper.__callBase_OnPause();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601B96F RID: 113007 RVA: 0x00865A84 File Offset: 0x00863C84
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_OnResume(IntPtr l)
	{
		int result;
		try
		{
			BattleLoseUITask battleLoseUITask = (BattleLoseUITask)LuaObject.checkSelf(l);
			UIIntent intent;
			LuaObject.checkType<UIIntent>(l, 2, out intent);
			bool b = battleLoseUITask.m_luaExportHelper.__callBase_OnResume(intent);
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

	// Token: 0x0601B970 RID: 113008 RVA: 0x00865AEC File Offset: 0x00863CEC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_OnNewIntent(IntPtr l)
	{
		int result;
		try
		{
			BattleLoseUITask battleLoseUITask = (BattleLoseUITask)LuaObject.checkSelf(l);
			UIIntent intent;
			LuaObject.checkType<UIIntent>(l, 2, out intent);
			bool b = battleLoseUITask.m_luaExportHelper.__callBase_OnNewIntent(intent);
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

	// Token: 0x0601B971 RID: 113009 RVA: 0x00865B54 File Offset: 0x00863D54
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_EnableUIInput(IntPtr l)
	{
		int result;
		try
		{
			BattleLoseUITask battleLoseUITask = (BattleLoseUITask)LuaObject.checkSelf(l);
			bool isEnable;
			LuaObject.checkType(l, 2, out isEnable);
			bool? isGlobalEnable;
			LuaObject.checkNullable<bool>(l, 3, out isGlobalEnable);
			battleLoseUITask.m_luaExportHelper.__callBase_EnableUIInput(isEnable, isGlobalEnable);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601B972 RID: 113010 RVA: 0x00865BC0 File Offset: 0x00863DC0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_IsNeedLoadDynamicRes(IntPtr l)
	{
		int result;
		try
		{
			BattleLoseUITask battleLoseUITask = (BattleLoseUITask)LuaObject.checkSelf(l);
			bool b = battleLoseUITask.m_luaExportHelper.__callBase_IsNeedLoadDynamicRes();
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

	// Token: 0x0601B973 RID: 113011 RVA: 0x00865C1C File Offset: 0x00863E1C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_CollectAllDynamicResForLoad(IntPtr l)
	{
		int result;
		try
		{
			BattleLoseUITask battleLoseUITask = (BattleLoseUITask)LuaObject.checkSelf(l);
			List<string> o = battleLoseUITask.m_luaExportHelper.__callBase_CollectAllDynamicResForLoad();
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

	// Token: 0x0601B974 RID: 113012 RVA: 0x00865C78 File Offset: 0x00863E78
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_RegisterPlayerContextEvents(IntPtr l)
	{
		int result;
		try
		{
			BattleLoseUITask battleLoseUITask = (BattleLoseUITask)LuaObject.checkSelf(l);
			battleLoseUITask.m_luaExportHelper.__callBase_RegisterPlayerContextEvents();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601B975 RID: 113013 RVA: 0x00865CCC File Offset: 0x00863ECC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_UnregisterPlayerContextEvents(IntPtr l)
	{
		int result;
		try
		{
			BattleLoseUITask battleLoseUITask = (BattleLoseUITask)LuaObject.checkSelf(l);
			battleLoseUITask.m_luaExportHelper.__callBase_UnregisterPlayerContextEvents();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601B976 RID: 113014 RVA: 0x00865D20 File Offset: 0x00863F20
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_PostUpdateView(IntPtr l)
	{
		int result;
		try
		{
			BattleLoseUITask battleLoseUITask = (BattleLoseUITask)LuaObject.checkSelf(l);
			battleLoseUITask.m_luaExportHelper.__callBase_PostUpdateView();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601B977 RID: 113015 RVA: 0x00865D74 File Offset: 0x00863F74
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_CollectPreloadResourceList(IntPtr l)
	{
		int result;
		try
		{
			BattleLoseUITask battleLoseUITask = (BattleLoseUITask)LuaObject.checkSelf(l);
			battleLoseUITask.m_luaExportHelper.__callBase_CollectPreloadResourceList();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601B978 RID: 113016 RVA: 0x00865DC8 File Offset: 0x00863FC8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_ClearAssetList(IntPtr l)
	{
		int result;
		try
		{
			BattleLoseUITask battleLoseUITask = (BattleLoseUITask)LuaObject.checkSelf(l);
			battleLoseUITask.m_luaExportHelper.__callBase_ClearAssetList();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601B979 RID: 113017 RVA: 0x00865E1C File Offset: 0x0086401C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_CollectAsset(IntPtr l)
	{
		int result;
		try
		{
			BattleLoseUITask battleLoseUITask = (BattleLoseUITask)LuaObject.checkSelf(l);
			string assetName;
			LuaObject.checkType(l, 2, out assetName);
			battleLoseUITask.m_luaExportHelper.__callBase_CollectAsset(assetName);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601B97A RID: 113018 RVA: 0x00865E78 File Offset: 0x00864078
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_CollectSpriteAsset(IntPtr l)
	{
		int result;
		try
		{
			BattleLoseUITask battleLoseUITask = (BattleLoseUITask)LuaObject.checkSelf(l);
			string assetName;
			LuaObject.checkType(l, 2, out assetName);
			battleLoseUITask.m_luaExportHelper.__callBase_CollectSpriteAsset(assetName);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601B97B RID: 113019 RVA: 0x00865ED4 File Offset: 0x008640D4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_CollectFxAsset(IntPtr l)
	{
		int result;
		try
		{
			BattleLoseUITask battleLoseUITask = (BattleLoseUITask)LuaObject.checkSelf(l);
			string assetName;
			LuaObject.checkType(l, 2, out assetName);
			battleLoseUITask.m_luaExportHelper.__callBase_CollectFxAsset(assetName);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601B97C RID: 113020 RVA: 0x00865F30 File Offset: 0x00864130
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_StartLoadCustomAssets(IntPtr l)
	{
		int result;
		try
		{
			BattleLoseUITask battleLoseUITask = (BattleLoseUITask)LuaObject.checkSelf(l);
			Action onLoadCompleted;
			LuaObject.checkDelegate<Action>(l, 2, out onLoadCompleted);
			battleLoseUITask.m_luaExportHelper.__callBase_StartLoadCustomAssets(onLoadCompleted);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601B97D RID: 113021 RVA: 0x00865F8C File Offset: 0x0086418C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_IsLoadingCustomAssets(IntPtr l)
	{
		int result;
		try
		{
			BattleLoseUITask battleLoseUITask = (BattleLoseUITask)LuaObject.checkSelf(l);
			bool b = battleLoseUITask.m_luaExportHelper.__callBase_IsLoadingCustomAssets();
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

	// Token: 0x0601B97E RID: 113022 RVA: 0x00865FE8 File Offset: 0x008641E8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_IsPipeLineRunning(IntPtr l)
	{
		int result;
		try
		{
			BattleLoseUITask battleLoseUITask = (BattleLoseUITask)LuaObject.checkSelf(l);
			bool b = battleLoseUITask.m_luaExportHelper.__callBase_IsPipeLineRunning();
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

	// Token: 0x0601B97F RID: 113023 RVA: 0x00866044 File Offset: 0x00864244
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_IsOpeningUI(IntPtr l)
	{
		int result;
		try
		{
			BattleLoseUITask battleLoseUITask = (BattleLoseUITask)LuaObject.checkSelf(l);
			bool b = battleLoseUITask.m_luaExportHelper.__callBase_IsOpeningUI();
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

	// Token: 0x0601B980 RID: 113024 RVA: 0x008660A0 File Offset: 0x008642A0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_ReturnPrevUITask(IntPtr l)
	{
		int result;
		try
		{
			BattleLoseUITask battleLoseUITask = (BattleLoseUITask)LuaObject.checkSelf(l);
			UITaskBase o = battleLoseUITask.m_luaExportHelper.__callBase_ReturnPrevUITask();
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

	// Token: 0x0601B981 RID: 113025 RVA: 0x008660FC File Offset: 0x008642FC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_ClearUnusedDynamicResourceCache(IntPtr l)
	{
		int result;
		try
		{
			BattleLoseUITask battleLoseUITask = (BattleLoseUITask)LuaObject.checkSelf(l);
			battleLoseUITask.m_luaExportHelper.__callBase_ClearUnusedDynamicResourceCache();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601B982 RID: 113026 RVA: 0x00866150 File Offset: 0x00864350
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_OnMemoryWarning(IntPtr l)
	{
		int result;
		try
		{
			BattleLoseUITask battleLoseUITask = (BattleLoseUITask)LuaObject.checkSelf(l);
			battleLoseUITask.m_luaExportHelper.__callBase_OnMemoryWarning();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601B983 RID: 113027 RVA: 0x008661A4 File Offset: 0x008643A4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callDele_EventOnClose(IntPtr l)
	{
		int result;
		try
		{
			BattleLoseUITask battleLoseUITask = (BattleLoseUITask)LuaObject.checkSelf(l);
			battleLoseUITask.m_luaExportHelper.__callDele_EventOnClose();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601B984 RID: 113028 RVA: 0x008661F8 File Offset: 0x008643F8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __clearDele_EventOnClose(IntPtr l)
	{
		int result;
		try
		{
			BattleLoseUITask battleLoseUITask = (BattleLoseUITask)LuaObject.checkSelf(l);
			battleLoseUITask.m_luaExportHelper.__clearDele_EventOnClose();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601B985 RID: 113029 RVA: 0x0086624C File Offset: 0x0086444C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_EventOnClose(IntPtr l)
	{
		int result;
		try
		{
			BattleLoseUITask battleLoseUITask = (BattleLoseUITask)LuaObject.checkSelf(l);
			Action value;
			int num = LuaObject.checkDelegate<Action>(l, 2, out value);
			if (num != 0)
			{
				if (num == 1)
				{
					battleLoseUITask.EventOnClose += value;
				}
				else if (num == 2)
				{
					battleLoseUITask.EventOnClose -= value;
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

	// Token: 0x0601B986 RID: 113030 RVA: 0x008662CC File Offset: 0x008644CC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_layerDescArray(IntPtr l)
	{
		int result;
		try
		{
			BattleLoseUITask battleLoseUITask = (BattleLoseUITask)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, battleLoseUITask.m_luaExportHelper.m_layerDescArray);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601B987 RID: 113031 RVA: 0x00866324 File Offset: 0x00864524
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_layerDescArray(IntPtr l)
	{
		int result;
		try
		{
			BattleLoseUITask battleLoseUITask = (BattleLoseUITask)LuaObject.checkSelf(l);
			UITaskBase.LayerDesc[] layerDescArray;
			LuaObject.checkArray<UITaskBase.LayerDesc>(l, 2, out layerDescArray);
			battleLoseUITask.m_luaExportHelper.m_layerDescArray = layerDescArray;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601B988 RID: 113032 RVA: 0x00866380 File Offset: 0x00864580
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_uiCtrlDescArray(IntPtr l)
	{
		int result;
		try
		{
			BattleLoseUITask battleLoseUITask = (BattleLoseUITask)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, battleLoseUITask.m_luaExportHelper.m_uiCtrlDescArray);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601B989 RID: 113033 RVA: 0x008663D8 File Offset: 0x008645D8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_uiCtrlDescArray(IntPtr l)
	{
		int result;
		try
		{
			BattleLoseUITask battleLoseUITask = (BattleLoseUITask)LuaObject.checkSelf(l);
			UITaskBase.UIControllerDesc[] uiCtrlDescArray;
			LuaObject.checkArray<UITaskBase.UIControllerDesc>(l, 2, out uiCtrlDescArray);
			battleLoseUITask.m_luaExportHelper.m_uiCtrlDescArray = uiCtrlDescArray;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601B98A RID: 113034 RVA: 0x00866434 File Offset: 0x00864634
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_battleLoseUIController(IntPtr l)
	{
		int result;
		try
		{
			BattleLoseUITask battleLoseUITask = (BattleLoseUITask)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, battleLoseUITask.m_luaExportHelper.m_battleLoseUIController);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601B98B RID: 113035 RVA: 0x0086648C File Offset: 0x0086468C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_battleLoseUIController(IntPtr l)
	{
		int result;
		try
		{
			BattleLoseUITask battleLoseUITask = (BattleLoseUITask)LuaObject.checkSelf(l);
			BattleLoseUIController battleLoseUIController;
			LuaObject.checkType<BattleLoseUIController>(l, 2, out battleLoseUIController);
			battleLoseUITask.m_luaExportHelper.m_battleLoseUIController = battleLoseUIController;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601B98C RID: 113036 RVA: 0x008664E8 File Offset: 0x008646E8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_LayerDescArray(IntPtr l)
	{
		int result;
		try
		{
			BattleLoseUITask battleLoseUITask = (BattleLoseUITask)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, battleLoseUITask.m_luaExportHelper.LayerDescArray);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601B98D RID: 113037 RVA: 0x00866540 File Offset: 0x00864740
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_UICtrlDescArray(IntPtr l)
	{
		int result;
		try
		{
			BattleLoseUITask battleLoseUITask = (BattleLoseUITask)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, battleLoseUITask.m_luaExportHelper.UICtrlDescArray);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601B98E RID: 113038 RVA: 0x00866598 File Offset: 0x00864798
	[Preserve]
	public static void reg(IntPtr l)
	{
		LuaObject.getTypeTable(l, "BlackJack.ProjectL.UI.BattleLoseUITask");
		if (Lua_BlackJack_ProjectL_UI_BattleLoseUITask.<>f__mg$cache0 == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleLoseUITask.<>f__mg$cache0 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleLoseUITask.StartUITask_s);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_BattleLoseUITask.<>f__mg$cache0);
		if (Lua_BlackJack_ProjectL_UI_BattleLoseUITask.<>f__mg$cache1 == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleLoseUITask.<>f__mg$cache1 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleLoseUITask.InitAllUIControllers);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_BattleLoseUITask.<>f__mg$cache1);
		if (Lua_BlackJack_ProjectL_UI_BattleLoseUITask.<>f__mg$cache2 == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleLoseUITask.<>f__mg$cache2 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleLoseUITask.ClearAllContextAndRes);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_BattleLoseUITask.<>f__mg$cache2);
		if (Lua_BlackJack_ProjectL_UI_BattleLoseUITask.<>f__mg$cache3 == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleLoseUITask.<>f__mg$cache3 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleLoseUITask.UpdateView);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_BattleLoseUITask.<>f__mg$cache3);
		if (Lua_BlackJack_ProjectL_UI_BattleLoseUITask.<>f__mg$cache4 == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleLoseUITask.<>f__mg$cache4 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleLoseUITask.BattleLoseUIController_OnClose);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_BattleLoseUITask.<>f__mg$cache4);
		if (Lua_BlackJack_ProjectL_UI_BattleLoseUITask.<>f__mg$cache5 == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleLoseUITask.<>f__mg$cache5 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleLoseUITask.__callBase_OnStart);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_BattleLoseUITask.<>f__mg$cache5);
		if (Lua_BlackJack_ProjectL_UI_BattleLoseUITask.<>f__mg$cache6 == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleLoseUITask.<>f__mg$cache6 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleLoseUITask.__callBase_OnStop);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_BattleLoseUITask.<>f__mg$cache6);
		if (Lua_BlackJack_ProjectL_UI_BattleLoseUITask.<>f__mg$cache7 == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleLoseUITask.<>f__mg$cache7 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleLoseUITask.__callBase_OnPause);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_BattleLoseUITask.<>f__mg$cache7);
		if (Lua_BlackJack_ProjectL_UI_BattleLoseUITask.<>f__mg$cache8 == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleLoseUITask.<>f__mg$cache8 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleLoseUITask.__callBase_OnResume);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_BattleLoseUITask.<>f__mg$cache8);
		if (Lua_BlackJack_ProjectL_UI_BattleLoseUITask.<>f__mg$cache9 == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleLoseUITask.<>f__mg$cache9 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleLoseUITask.__callBase_OnNewIntent);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_BattleLoseUITask.<>f__mg$cache9);
		if (Lua_BlackJack_ProjectL_UI_BattleLoseUITask.<>f__mg$cacheA == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleLoseUITask.<>f__mg$cacheA = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleLoseUITask.__callBase_EnableUIInput);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_BattleLoseUITask.<>f__mg$cacheA);
		if (Lua_BlackJack_ProjectL_UI_BattleLoseUITask.<>f__mg$cacheB == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleLoseUITask.<>f__mg$cacheB = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleLoseUITask.__callBase_IsNeedLoadDynamicRes);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_BattleLoseUITask.<>f__mg$cacheB);
		if (Lua_BlackJack_ProjectL_UI_BattleLoseUITask.<>f__mg$cacheC == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleLoseUITask.<>f__mg$cacheC = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleLoseUITask.__callBase_CollectAllDynamicResForLoad);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_BattleLoseUITask.<>f__mg$cacheC);
		if (Lua_BlackJack_ProjectL_UI_BattleLoseUITask.<>f__mg$cacheD == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleLoseUITask.<>f__mg$cacheD = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleLoseUITask.__callBase_RegisterPlayerContextEvents);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_BattleLoseUITask.<>f__mg$cacheD);
		if (Lua_BlackJack_ProjectL_UI_BattleLoseUITask.<>f__mg$cacheE == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleLoseUITask.<>f__mg$cacheE = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleLoseUITask.__callBase_UnregisterPlayerContextEvents);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_BattleLoseUITask.<>f__mg$cacheE);
		if (Lua_BlackJack_ProjectL_UI_BattleLoseUITask.<>f__mg$cacheF == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleLoseUITask.<>f__mg$cacheF = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleLoseUITask.__callBase_PostUpdateView);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_BattleLoseUITask.<>f__mg$cacheF);
		if (Lua_BlackJack_ProjectL_UI_BattleLoseUITask.<>f__mg$cache10 == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleLoseUITask.<>f__mg$cache10 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleLoseUITask.__callBase_CollectPreloadResourceList);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_BattleLoseUITask.<>f__mg$cache10);
		if (Lua_BlackJack_ProjectL_UI_BattleLoseUITask.<>f__mg$cache11 == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleLoseUITask.<>f__mg$cache11 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleLoseUITask.__callBase_ClearAssetList);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_BattleLoseUITask.<>f__mg$cache11);
		if (Lua_BlackJack_ProjectL_UI_BattleLoseUITask.<>f__mg$cache12 == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleLoseUITask.<>f__mg$cache12 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleLoseUITask.__callBase_CollectAsset);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_BattleLoseUITask.<>f__mg$cache12);
		if (Lua_BlackJack_ProjectL_UI_BattleLoseUITask.<>f__mg$cache13 == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleLoseUITask.<>f__mg$cache13 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleLoseUITask.__callBase_CollectSpriteAsset);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_BattleLoseUITask.<>f__mg$cache13);
		if (Lua_BlackJack_ProjectL_UI_BattleLoseUITask.<>f__mg$cache14 == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleLoseUITask.<>f__mg$cache14 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleLoseUITask.__callBase_CollectFxAsset);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_BattleLoseUITask.<>f__mg$cache14);
		if (Lua_BlackJack_ProjectL_UI_BattleLoseUITask.<>f__mg$cache15 == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleLoseUITask.<>f__mg$cache15 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleLoseUITask.__callBase_StartLoadCustomAssets);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_BattleLoseUITask.<>f__mg$cache15);
		if (Lua_BlackJack_ProjectL_UI_BattleLoseUITask.<>f__mg$cache16 == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleLoseUITask.<>f__mg$cache16 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleLoseUITask.__callBase_IsLoadingCustomAssets);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_BattleLoseUITask.<>f__mg$cache16);
		if (Lua_BlackJack_ProjectL_UI_BattleLoseUITask.<>f__mg$cache17 == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleLoseUITask.<>f__mg$cache17 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleLoseUITask.__callBase_IsPipeLineRunning);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_BattleLoseUITask.<>f__mg$cache17);
		if (Lua_BlackJack_ProjectL_UI_BattleLoseUITask.<>f__mg$cache18 == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleLoseUITask.<>f__mg$cache18 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleLoseUITask.__callBase_IsOpeningUI);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_BattleLoseUITask.<>f__mg$cache18);
		if (Lua_BlackJack_ProjectL_UI_BattleLoseUITask.<>f__mg$cache19 == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleLoseUITask.<>f__mg$cache19 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleLoseUITask.__callBase_ReturnPrevUITask);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_BattleLoseUITask.<>f__mg$cache19);
		if (Lua_BlackJack_ProjectL_UI_BattleLoseUITask.<>f__mg$cache1A == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleLoseUITask.<>f__mg$cache1A = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleLoseUITask.__callBase_ClearUnusedDynamicResourceCache);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_BattleLoseUITask.<>f__mg$cache1A);
		if (Lua_BlackJack_ProjectL_UI_BattleLoseUITask.<>f__mg$cache1B == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleLoseUITask.<>f__mg$cache1B = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleLoseUITask.__callBase_OnMemoryWarning);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_BattleLoseUITask.<>f__mg$cache1B);
		if (Lua_BlackJack_ProjectL_UI_BattleLoseUITask.<>f__mg$cache1C == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleLoseUITask.<>f__mg$cache1C = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleLoseUITask.__callDele_EventOnClose);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_BattleLoseUITask.<>f__mg$cache1C);
		if (Lua_BlackJack_ProjectL_UI_BattleLoseUITask.<>f__mg$cache1D == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleLoseUITask.<>f__mg$cache1D = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleLoseUITask.__clearDele_EventOnClose);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_BattleLoseUITask.<>f__mg$cache1D);
		string name = "EventOnClose";
		LuaCSFunction get = null;
		if (Lua_BlackJack_ProjectL_UI_BattleLoseUITask.<>f__mg$cache1E == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleLoseUITask.<>f__mg$cache1E = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleLoseUITask.set_EventOnClose);
		}
		LuaObject.addMember(l, name, get, Lua_BlackJack_ProjectL_UI_BattleLoseUITask.<>f__mg$cache1E, true);
		string name2 = "m_layerDescArray";
		if (Lua_BlackJack_ProjectL_UI_BattleLoseUITask.<>f__mg$cache1F == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleLoseUITask.<>f__mg$cache1F = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleLoseUITask.get_m_layerDescArray);
		}
		LuaCSFunction get2 = Lua_BlackJack_ProjectL_UI_BattleLoseUITask.<>f__mg$cache1F;
		if (Lua_BlackJack_ProjectL_UI_BattleLoseUITask.<>f__mg$cache20 == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleLoseUITask.<>f__mg$cache20 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleLoseUITask.set_m_layerDescArray);
		}
		LuaObject.addMember(l, name2, get2, Lua_BlackJack_ProjectL_UI_BattleLoseUITask.<>f__mg$cache20, true);
		string name3 = "m_uiCtrlDescArray";
		if (Lua_BlackJack_ProjectL_UI_BattleLoseUITask.<>f__mg$cache21 == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleLoseUITask.<>f__mg$cache21 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleLoseUITask.get_m_uiCtrlDescArray);
		}
		LuaCSFunction get3 = Lua_BlackJack_ProjectL_UI_BattleLoseUITask.<>f__mg$cache21;
		if (Lua_BlackJack_ProjectL_UI_BattleLoseUITask.<>f__mg$cache22 == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleLoseUITask.<>f__mg$cache22 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleLoseUITask.set_m_uiCtrlDescArray);
		}
		LuaObject.addMember(l, name3, get3, Lua_BlackJack_ProjectL_UI_BattleLoseUITask.<>f__mg$cache22, true);
		string name4 = "m_battleLoseUIController";
		if (Lua_BlackJack_ProjectL_UI_BattleLoseUITask.<>f__mg$cache23 == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleLoseUITask.<>f__mg$cache23 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleLoseUITask.get_m_battleLoseUIController);
		}
		LuaCSFunction get4 = Lua_BlackJack_ProjectL_UI_BattleLoseUITask.<>f__mg$cache23;
		if (Lua_BlackJack_ProjectL_UI_BattleLoseUITask.<>f__mg$cache24 == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleLoseUITask.<>f__mg$cache24 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleLoseUITask.set_m_battleLoseUIController);
		}
		LuaObject.addMember(l, name4, get4, Lua_BlackJack_ProjectL_UI_BattleLoseUITask.<>f__mg$cache24, true);
		string name5 = "LayerDescArray";
		if (Lua_BlackJack_ProjectL_UI_BattleLoseUITask.<>f__mg$cache25 == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleLoseUITask.<>f__mg$cache25 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleLoseUITask.get_LayerDescArray);
		}
		LuaObject.addMember(l, name5, Lua_BlackJack_ProjectL_UI_BattleLoseUITask.<>f__mg$cache25, null, true);
		string name6 = "UICtrlDescArray";
		if (Lua_BlackJack_ProjectL_UI_BattleLoseUITask.<>f__mg$cache26 == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleLoseUITask.<>f__mg$cache26 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleLoseUITask.get_UICtrlDescArray);
		}
		LuaObject.addMember(l, name6, Lua_BlackJack_ProjectL_UI_BattleLoseUITask.<>f__mg$cache26, null, true);
		if (Lua_BlackJack_ProjectL_UI_BattleLoseUITask.<>f__mg$cache27 == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleLoseUITask.<>f__mg$cache27 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleLoseUITask.constructor);
		}
		LuaObject.createTypeMetatable(l, Lua_BlackJack_ProjectL_UI_BattleLoseUITask.<>f__mg$cache27, typeof(BattleLoseUITask), typeof(UITask));
	}

	// Token: 0x04011BFE RID: 72702
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache0;

	// Token: 0x04011BFF RID: 72703
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1;

	// Token: 0x04011C00 RID: 72704
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2;

	// Token: 0x04011C01 RID: 72705
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3;

	// Token: 0x04011C02 RID: 72706
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache4;

	// Token: 0x04011C03 RID: 72707
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache5;

	// Token: 0x04011C04 RID: 72708
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache6;

	// Token: 0x04011C05 RID: 72709
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache7;

	// Token: 0x04011C06 RID: 72710
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache8;

	// Token: 0x04011C07 RID: 72711
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache9;

	// Token: 0x04011C08 RID: 72712
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheA;

	// Token: 0x04011C09 RID: 72713
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheB;

	// Token: 0x04011C0A RID: 72714
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheC;

	// Token: 0x04011C0B RID: 72715
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheD;

	// Token: 0x04011C0C RID: 72716
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheE;

	// Token: 0x04011C0D RID: 72717
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheF;

	// Token: 0x04011C0E RID: 72718
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache10;

	// Token: 0x04011C0F RID: 72719
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache11;

	// Token: 0x04011C10 RID: 72720
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache12;

	// Token: 0x04011C11 RID: 72721
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache13;

	// Token: 0x04011C12 RID: 72722
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache14;

	// Token: 0x04011C13 RID: 72723
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache15;

	// Token: 0x04011C14 RID: 72724
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache16;

	// Token: 0x04011C15 RID: 72725
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache17;

	// Token: 0x04011C16 RID: 72726
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache18;

	// Token: 0x04011C17 RID: 72727
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache19;

	// Token: 0x04011C18 RID: 72728
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1A;

	// Token: 0x04011C19 RID: 72729
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1B;

	// Token: 0x04011C1A RID: 72730
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1C;

	// Token: 0x04011C1B RID: 72731
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1D;

	// Token: 0x04011C1C RID: 72732
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1E;

	// Token: 0x04011C1D RID: 72733
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1F;

	// Token: 0x04011C1E RID: 72734
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache20;

	// Token: 0x04011C1F RID: 72735
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache21;

	// Token: 0x04011C20 RID: 72736
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache22;

	// Token: 0x04011C21 RID: 72737
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache23;

	// Token: 0x04011C22 RID: 72738
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache24;

	// Token: 0x04011C23 RID: 72739
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache25;

	// Token: 0x04011C24 RID: 72740
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache26;

	// Token: 0x04011C25 RID: 72741
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache27;
}
