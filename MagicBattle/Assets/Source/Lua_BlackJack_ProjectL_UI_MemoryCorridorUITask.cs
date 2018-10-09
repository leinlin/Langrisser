using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using BlackJack.BJFramework.Runtime.UI;
using BlackJack.ConfigData;
using BlackJack.ProjectL.UI;
using SLua;
using UnityEngine.Scripting;

// Token: 0x0200150D RID: 5389
[Preserve]
public class Lua_BlackJack_ProjectL_UI_MemoryCorridorUITask : LuaObject
{
	// Token: 0x0601FEBF RID: 130751 RVA: 0x00A8CA70 File Offset: 0x00A8AC70
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int constructor(IntPtr l)
	{
		int result;
		try
		{
			string name;
			LuaObject.checkType(l, 2, out name);
			MemoryCorridorUITask o = new MemoryCorridorUITask(name);
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

	// Token: 0x0601FEC0 RID: 130752 RVA: 0x00A8CAC4 File Offset: 0x00A8ACC4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int OnStart(IntPtr l)
	{
		int result;
		try
		{
			MemoryCorridorUITask memoryCorridorUITask = (MemoryCorridorUITask)LuaObject.checkSelf(l);
			UIIntent intent;
			LuaObject.checkType<UIIntent>(l, 2, out intent);
			bool b = memoryCorridorUITask.m_luaExportHelper.OnStart(intent);
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

	// Token: 0x0601FEC1 RID: 130753 RVA: 0x00A8CB2C File Offset: 0x00A8AD2C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int OnResume(IntPtr l)
	{
		int result;
		try
		{
			MemoryCorridorUITask memoryCorridorUITask = (MemoryCorridorUITask)LuaObject.checkSelf(l);
			UIIntent intent;
			LuaObject.checkType<UIIntent>(l, 2, out intent);
			bool b = memoryCorridorUITask.m_luaExportHelper.OnResume(intent);
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

	// Token: 0x0601FEC2 RID: 130754 RVA: 0x00A8CB94 File Offset: 0x00A8AD94
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int InitDataFromUIIntent(IntPtr l)
	{
		int result;
		try
		{
			MemoryCorridorUITask memoryCorridorUITask = (MemoryCorridorUITask)LuaObject.checkSelf(l);
			UIIntent intent;
			LuaObject.checkType<UIIntent>(l, 2, out intent);
			memoryCorridorUITask.m_luaExportHelper.InitDataFromUIIntent(intent);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601FEC3 RID: 130755 RVA: 0x00A8CBF0 File Offset: 0x00A8ADF0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int IsNeedLoadDynamicRes(IntPtr l)
	{
		int result;
		try
		{
			MemoryCorridorUITask memoryCorridorUITask = (MemoryCorridorUITask)LuaObject.checkSelf(l);
			bool b = memoryCorridorUITask.m_luaExportHelper.IsNeedLoadDynamicRes();
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

	// Token: 0x0601FEC4 RID: 130756 RVA: 0x00A8CC4C File Offset: 0x00A8AE4C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int InitAllUIControllers(IntPtr l)
	{
		int result;
		try
		{
			MemoryCorridorUITask memoryCorridorUITask = (MemoryCorridorUITask)LuaObject.checkSelf(l);
			memoryCorridorUITask.m_luaExportHelper.InitAllUIControllers();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601FEC5 RID: 130757 RVA: 0x00A8CCA0 File Offset: 0x00A8AEA0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int ClearAllContextAndRes(IntPtr l)
	{
		int result;
		try
		{
			MemoryCorridorUITask memoryCorridorUITask = (MemoryCorridorUITask)LuaObject.checkSelf(l);
			memoryCorridorUITask.m_luaExportHelper.ClearAllContextAndRes();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601FEC6 RID: 130758 RVA: 0x00A8CCF4 File Offset: 0x00A8AEF4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int InitMemoryCorridorUIController(IntPtr l)
	{
		int result;
		try
		{
			MemoryCorridorUITask memoryCorridorUITask = (MemoryCorridorUITask)LuaObject.checkSelf(l);
			memoryCorridorUITask.m_luaExportHelper.InitMemoryCorridorUIController();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601FEC7 RID: 130759 RVA: 0x00A8CD48 File Offset: 0x00A8AF48
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int UninitMemoryCorridorUIController(IntPtr l)
	{
		int result;
		try
		{
			MemoryCorridorUITask memoryCorridorUITask = (MemoryCorridorUITask)LuaObject.checkSelf(l);
			memoryCorridorUITask.m_luaExportHelper.UninitMemoryCorridorUIController();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601FEC8 RID: 130760 RVA: 0x00A8CD9C File Offset: 0x00A8AF9C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int OnMemoryWarning(IntPtr l)
	{
		int result;
		try
		{
			MemoryCorridorUITask memoryCorridorUITask = (MemoryCorridorUITask)LuaObject.checkSelf(l);
			memoryCorridorUITask.m_luaExportHelper.OnMemoryWarning();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601FEC9 RID: 130761 RVA: 0x00A8CDF0 File Offset: 0x00A8AFF0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int UpdateView(IntPtr l)
	{
		int result;
		try
		{
			MemoryCorridorUITask memoryCorridorUITask = (MemoryCorridorUITask)LuaObject.checkSelf(l);
			memoryCorridorUITask.m_luaExportHelper.UpdateView();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601FECA RID: 130762 RVA: 0x00A8CE44 File Offset: 0x00A8B044
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int MemoryCorridorUIController_OnReturn(IntPtr l)
	{
		int result;
		try
		{
			MemoryCorridorUITask memoryCorridorUITask = (MemoryCorridorUITask)LuaObject.checkSelf(l);
			memoryCorridorUITask.m_luaExportHelper.MemoryCorridorUIController_OnReturn();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601FECB RID: 130763 RVA: 0x00A8CE98 File Offset: 0x00A8B098
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int MemoryCorridorUIController_OnShowHelp(IntPtr l)
	{
		int result;
		try
		{
			MemoryCorridorUITask memoryCorridorUITask = (MemoryCorridorUITask)LuaObject.checkSelf(l);
			memoryCorridorUITask.m_luaExportHelper.MemoryCorridorUIController_OnShowHelp();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601FECC RID: 130764 RVA: 0x00A8CEEC File Offset: 0x00A8B0EC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int MemoryCorridorUIController_OnAddTicket(IntPtr l)
	{
		int result;
		try
		{
			MemoryCorridorUITask memoryCorridorUITask = (MemoryCorridorUITask)LuaObject.checkSelf(l);
			memoryCorridorUITask.m_luaExportHelper.MemoryCorridorUIController_OnAddTicket();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601FECD RID: 130765 RVA: 0x00A8CF40 File Offset: 0x00A8B140
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int MemoryCorridorUIController_OnShowTeam(IntPtr l)
	{
		int result;
		try
		{
			MemoryCorridorUITask memoryCorridorUITask = (MemoryCorridorUITask)LuaObject.checkSelf(l);
			memoryCorridorUITask.m_luaExportHelper.MemoryCorridorUIController_OnShowTeam();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601FECE RID: 130766 RVA: 0x00A8CF94 File Offset: 0x00A8B194
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int TeamUITask_OnLoadAllResCompleted(IntPtr l)
	{
		int result;
		try
		{
			MemoryCorridorUITask memoryCorridorUITask = (MemoryCorridorUITask)LuaObject.checkSelf(l);
			memoryCorridorUITask.m_luaExportHelper.TeamUITask_OnLoadAllResCompleted();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601FECF RID: 130767 RVA: 0x00A8CFE8 File Offset: 0x00A8B1E8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int MemoryCorridorUIController_OnStartMemoryCorridorLevel(IntPtr l)
	{
		int result;
		try
		{
			MemoryCorridorUITask memoryCorridorUITask = (MemoryCorridorUITask)LuaObject.checkSelf(l);
			ConfigDataMemoryCorridorLevelInfo levelInfo;
			LuaObject.checkType<ConfigDataMemoryCorridorLevelInfo>(l, 2, out levelInfo);
			memoryCorridorUITask.m_luaExportHelper.MemoryCorridorUIController_OnStartMemoryCorridorLevel(levelInfo);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601FED0 RID: 130768 RVA: 0x00A8D044 File Offset: 0x00A8B244
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_OnStart(IntPtr l)
	{
		int result;
		try
		{
			MemoryCorridorUITask memoryCorridorUITask = (MemoryCorridorUITask)LuaObject.checkSelf(l);
			UIIntent intent;
			LuaObject.checkType<UIIntent>(l, 2, out intent);
			bool b = memoryCorridorUITask.m_luaExportHelper.__callBase_OnStart(intent);
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

	// Token: 0x0601FED1 RID: 130769 RVA: 0x00A8D0AC File Offset: 0x00A8B2AC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_OnStop(IntPtr l)
	{
		int result;
		try
		{
			MemoryCorridorUITask memoryCorridorUITask = (MemoryCorridorUITask)LuaObject.checkSelf(l);
			memoryCorridorUITask.m_luaExportHelper.__callBase_OnStop();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601FED2 RID: 130770 RVA: 0x00A8D100 File Offset: 0x00A8B300
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_OnPause(IntPtr l)
	{
		int result;
		try
		{
			MemoryCorridorUITask memoryCorridorUITask = (MemoryCorridorUITask)LuaObject.checkSelf(l);
			memoryCorridorUITask.m_luaExportHelper.__callBase_OnPause();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601FED3 RID: 130771 RVA: 0x00A8D154 File Offset: 0x00A8B354
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_OnResume(IntPtr l)
	{
		int result;
		try
		{
			MemoryCorridorUITask memoryCorridorUITask = (MemoryCorridorUITask)LuaObject.checkSelf(l);
			UIIntent intent;
			LuaObject.checkType<UIIntent>(l, 2, out intent);
			bool b = memoryCorridorUITask.m_luaExportHelper.__callBase_OnResume(intent);
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

	// Token: 0x0601FED4 RID: 130772 RVA: 0x00A8D1BC File Offset: 0x00A8B3BC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_OnNewIntent(IntPtr l)
	{
		int result;
		try
		{
			MemoryCorridorUITask memoryCorridorUITask = (MemoryCorridorUITask)LuaObject.checkSelf(l);
			UIIntent intent;
			LuaObject.checkType<UIIntent>(l, 2, out intent);
			bool b = memoryCorridorUITask.m_luaExportHelper.__callBase_OnNewIntent(intent);
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

	// Token: 0x0601FED5 RID: 130773 RVA: 0x00A8D224 File Offset: 0x00A8B424
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_EnableUIInput(IntPtr l)
	{
		int result;
		try
		{
			MemoryCorridorUITask memoryCorridorUITask = (MemoryCorridorUITask)LuaObject.checkSelf(l);
			bool isEnable;
			LuaObject.checkType(l, 2, out isEnable);
			bool? isGlobalEnable;
			LuaObject.checkNullable<bool>(l, 3, out isGlobalEnable);
			memoryCorridorUITask.m_luaExportHelper.__callBase_EnableUIInput(isEnable, isGlobalEnable);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601FED6 RID: 130774 RVA: 0x00A8D290 File Offset: 0x00A8B490
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_IsNeedLoadDynamicRes(IntPtr l)
	{
		int result;
		try
		{
			MemoryCorridorUITask memoryCorridorUITask = (MemoryCorridorUITask)LuaObject.checkSelf(l);
			bool b = memoryCorridorUITask.m_luaExportHelper.__callBase_IsNeedLoadDynamicRes();
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

	// Token: 0x0601FED7 RID: 130775 RVA: 0x00A8D2EC File Offset: 0x00A8B4EC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_CollectAllDynamicResForLoad(IntPtr l)
	{
		int result;
		try
		{
			MemoryCorridorUITask memoryCorridorUITask = (MemoryCorridorUITask)LuaObject.checkSelf(l);
			List<string> o = memoryCorridorUITask.m_luaExportHelper.__callBase_CollectAllDynamicResForLoad();
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

	// Token: 0x0601FED8 RID: 130776 RVA: 0x00A8D348 File Offset: 0x00A8B548
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_RegisterPlayerContextEvents(IntPtr l)
	{
		int result;
		try
		{
			MemoryCorridorUITask memoryCorridorUITask = (MemoryCorridorUITask)LuaObject.checkSelf(l);
			memoryCorridorUITask.m_luaExportHelper.__callBase_RegisterPlayerContextEvents();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601FED9 RID: 130777 RVA: 0x00A8D39C File Offset: 0x00A8B59C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_UnregisterPlayerContextEvents(IntPtr l)
	{
		int result;
		try
		{
			MemoryCorridorUITask memoryCorridorUITask = (MemoryCorridorUITask)LuaObject.checkSelf(l);
			memoryCorridorUITask.m_luaExportHelper.__callBase_UnregisterPlayerContextEvents();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601FEDA RID: 130778 RVA: 0x00A8D3F0 File Offset: 0x00A8B5F0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_PostUpdateView(IntPtr l)
	{
		int result;
		try
		{
			MemoryCorridorUITask memoryCorridorUITask = (MemoryCorridorUITask)LuaObject.checkSelf(l);
			memoryCorridorUITask.m_luaExportHelper.__callBase_PostUpdateView();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601FEDB RID: 130779 RVA: 0x00A8D444 File Offset: 0x00A8B644
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_CollectPreloadResourceList(IntPtr l)
	{
		int result;
		try
		{
			MemoryCorridorUITask memoryCorridorUITask = (MemoryCorridorUITask)LuaObject.checkSelf(l);
			memoryCorridorUITask.m_luaExportHelper.__callBase_CollectPreloadResourceList();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601FEDC RID: 130780 RVA: 0x00A8D498 File Offset: 0x00A8B698
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_ClearAssetList(IntPtr l)
	{
		int result;
		try
		{
			MemoryCorridorUITask memoryCorridorUITask = (MemoryCorridorUITask)LuaObject.checkSelf(l);
			memoryCorridorUITask.m_luaExportHelper.__callBase_ClearAssetList();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601FEDD RID: 130781 RVA: 0x00A8D4EC File Offset: 0x00A8B6EC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_CollectAsset(IntPtr l)
	{
		int result;
		try
		{
			MemoryCorridorUITask memoryCorridorUITask = (MemoryCorridorUITask)LuaObject.checkSelf(l);
			string assetName;
			LuaObject.checkType(l, 2, out assetName);
			memoryCorridorUITask.m_luaExportHelper.__callBase_CollectAsset(assetName);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601FEDE RID: 130782 RVA: 0x00A8D548 File Offset: 0x00A8B748
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_CollectSpriteAsset(IntPtr l)
	{
		int result;
		try
		{
			MemoryCorridorUITask memoryCorridorUITask = (MemoryCorridorUITask)LuaObject.checkSelf(l);
			string assetName;
			LuaObject.checkType(l, 2, out assetName);
			memoryCorridorUITask.m_luaExportHelper.__callBase_CollectSpriteAsset(assetName);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601FEDF RID: 130783 RVA: 0x00A8D5A4 File Offset: 0x00A8B7A4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_CollectFxAsset(IntPtr l)
	{
		int result;
		try
		{
			MemoryCorridorUITask memoryCorridorUITask = (MemoryCorridorUITask)LuaObject.checkSelf(l);
			string assetName;
			LuaObject.checkType(l, 2, out assetName);
			memoryCorridorUITask.m_luaExportHelper.__callBase_CollectFxAsset(assetName);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601FEE0 RID: 130784 RVA: 0x00A8D600 File Offset: 0x00A8B800
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_StartLoadCustomAssets(IntPtr l)
	{
		int result;
		try
		{
			MemoryCorridorUITask memoryCorridorUITask = (MemoryCorridorUITask)LuaObject.checkSelf(l);
			Action onLoadCompleted;
			LuaObject.checkDelegate<Action>(l, 2, out onLoadCompleted);
			memoryCorridorUITask.m_luaExportHelper.__callBase_StartLoadCustomAssets(onLoadCompleted);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601FEE1 RID: 130785 RVA: 0x00A8D65C File Offset: 0x00A8B85C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_IsLoadingCustomAssets(IntPtr l)
	{
		int result;
		try
		{
			MemoryCorridorUITask memoryCorridorUITask = (MemoryCorridorUITask)LuaObject.checkSelf(l);
			bool b = memoryCorridorUITask.m_luaExportHelper.__callBase_IsLoadingCustomAssets();
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

	// Token: 0x0601FEE2 RID: 130786 RVA: 0x00A8D6B8 File Offset: 0x00A8B8B8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_IsPipeLineRunning(IntPtr l)
	{
		int result;
		try
		{
			MemoryCorridorUITask memoryCorridorUITask = (MemoryCorridorUITask)LuaObject.checkSelf(l);
			bool b = memoryCorridorUITask.m_luaExportHelper.__callBase_IsPipeLineRunning();
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

	// Token: 0x0601FEE3 RID: 130787 RVA: 0x00A8D714 File Offset: 0x00A8B914
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_IsOpeningUI(IntPtr l)
	{
		int result;
		try
		{
			MemoryCorridorUITask memoryCorridorUITask = (MemoryCorridorUITask)LuaObject.checkSelf(l);
			bool b = memoryCorridorUITask.m_luaExportHelper.__callBase_IsOpeningUI();
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

	// Token: 0x0601FEE4 RID: 130788 RVA: 0x00A8D770 File Offset: 0x00A8B970
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_ReturnPrevUITask(IntPtr l)
	{
		int result;
		try
		{
			MemoryCorridorUITask memoryCorridorUITask = (MemoryCorridorUITask)LuaObject.checkSelf(l);
			UITaskBase o = memoryCorridorUITask.m_luaExportHelper.__callBase_ReturnPrevUITask();
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

	// Token: 0x0601FEE5 RID: 130789 RVA: 0x00A8D7CC File Offset: 0x00A8B9CC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_ClearUnusedDynamicResourceCache(IntPtr l)
	{
		int result;
		try
		{
			MemoryCorridorUITask memoryCorridorUITask = (MemoryCorridorUITask)LuaObject.checkSelf(l);
			memoryCorridorUITask.m_luaExportHelper.__callBase_ClearUnusedDynamicResourceCache();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601FEE6 RID: 130790 RVA: 0x00A8D820 File Offset: 0x00A8BA20
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_OnMemoryWarning(IntPtr l)
	{
		int result;
		try
		{
			MemoryCorridorUITask memoryCorridorUITask = (MemoryCorridorUITask)LuaObject.checkSelf(l);
			memoryCorridorUITask.m_luaExportHelper.__callBase_OnMemoryWarning();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601FEE7 RID: 130791 RVA: 0x00A8D874 File Offset: 0x00A8BA74
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_layerDescArray(IntPtr l)
	{
		int result;
		try
		{
			MemoryCorridorUITask memoryCorridorUITask = (MemoryCorridorUITask)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, memoryCorridorUITask.m_luaExportHelper.m_layerDescArray);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601FEE8 RID: 130792 RVA: 0x00A8D8CC File Offset: 0x00A8BACC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_layerDescArray(IntPtr l)
	{
		int result;
		try
		{
			MemoryCorridorUITask memoryCorridorUITask = (MemoryCorridorUITask)LuaObject.checkSelf(l);
			UITaskBase.LayerDesc[] layerDescArray;
			LuaObject.checkArray<UITaskBase.LayerDesc>(l, 2, out layerDescArray);
			memoryCorridorUITask.m_luaExportHelper.m_layerDescArray = layerDescArray;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601FEE9 RID: 130793 RVA: 0x00A8D928 File Offset: 0x00A8BB28
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_uiCtrlDescArray(IntPtr l)
	{
		int result;
		try
		{
			MemoryCorridorUITask memoryCorridorUITask = (MemoryCorridorUITask)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, memoryCorridorUITask.m_luaExportHelper.m_uiCtrlDescArray);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601FEEA RID: 130794 RVA: 0x00A8D980 File Offset: 0x00A8BB80
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_uiCtrlDescArray(IntPtr l)
	{
		int result;
		try
		{
			MemoryCorridorUITask memoryCorridorUITask = (MemoryCorridorUITask)LuaObject.checkSelf(l);
			UITaskBase.UIControllerDesc[] uiCtrlDescArray;
			LuaObject.checkArray<UITaskBase.UIControllerDesc>(l, 2, out uiCtrlDescArray);
			memoryCorridorUITask.m_luaExportHelper.m_uiCtrlDescArray = uiCtrlDescArray;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601FEEB RID: 130795 RVA: 0x00A8D9DC File Offset: 0x00A8BBDC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_memoryCorridorUIController(IntPtr l)
	{
		int result;
		try
		{
			MemoryCorridorUITask memoryCorridorUITask = (MemoryCorridorUITask)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, memoryCorridorUITask.m_luaExportHelper.m_memoryCorridorUIController);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601FEEC RID: 130796 RVA: 0x00A8DA34 File Offset: 0x00A8BC34
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_memoryCorridorUIController(IntPtr l)
	{
		int result;
		try
		{
			MemoryCorridorUITask memoryCorridorUITask = (MemoryCorridorUITask)LuaObject.checkSelf(l);
			MemoryCorridorUIController memoryCorridorUIController;
			LuaObject.checkType<MemoryCorridorUIController>(l, 2, out memoryCorridorUIController);
			memoryCorridorUITask.m_luaExportHelper.m_memoryCorridorUIController = memoryCorridorUIController;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601FEED RID: 130797 RVA: 0x00A8DA90 File Offset: 0x00A8BC90
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_playerResourceUIController(IntPtr l)
	{
		int result;
		try
		{
			MemoryCorridorUITask memoryCorridorUITask = (MemoryCorridorUITask)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, memoryCorridorUITask.m_luaExportHelper.m_playerResourceUIController);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601FEEE RID: 130798 RVA: 0x00A8DAE8 File Offset: 0x00A8BCE8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_playerResourceUIController(IntPtr l)
	{
		int result;
		try
		{
			MemoryCorridorUITask memoryCorridorUITask = (MemoryCorridorUITask)LuaObject.checkSelf(l);
			PlayerResourceUIController playerResourceUIController;
			LuaObject.checkType<PlayerResourceUIController>(l, 2, out playerResourceUIController);
			memoryCorridorUITask.m_luaExportHelper.m_playerResourceUIController = playerResourceUIController;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601FEEF RID: 130799 RVA: 0x00A8DB44 File Offset: 0x00A8BD44
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_memoryCorridorInfo(IntPtr l)
	{
		int result;
		try
		{
			MemoryCorridorUITask memoryCorridorUITask = (MemoryCorridorUITask)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, memoryCorridorUITask.m_luaExportHelper.m_memoryCorridorInfo);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601FEF0 RID: 130800 RVA: 0x00A8DB9C File Offset: 0x00A8BD9C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_memoryCorridorInfo(IntPtr l)
	{
		int result;
		try
		{
			MemoryCorridorUITask memoryCorridorUITask = (MemoryCorridorUITask)LuaObject.checkSelf(l);
			ConfigDataMemoryCorridorInfo memoryCorridorInfo;
			LuaObject.checkType<ConfigDataMemoryCorridorInfo>(l, 2, out memoryCorridorInfo);
			memoryCorridorUITask.m_luaExportHelper.m_memoryCorridorInfo = memoryCorridorInfo;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601FEF1 RID: 130801 RVA: 0x00A8DBF8 File Offset: 0x00A8BDF8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_LayerDescArray(IntPtr l)
	{
		int result;
		try
		{
			MemoryCorridorUITask memoryCorridorUITask = (MemoryCorridorUITask)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, memoryCorridorUITask.m_luaExportHelper.LayerDescArray);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601FEF2 RID: 130802 RVA: 0x00A8DC50 File Offset: 0x00A8BE50
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_UICtrlDescArray(IntPtr l)
	{
		int result;
		try
		{
			MemoryCorridorUITask memoryCorridorUITask = (MemoryCorridorUITask)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, memoryCorridorUITask.m_luaExportHelper.UICtrlDescArray);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601FEF3 RID: 130803 RVA: 0x00A8DCA8 File Offset: 0x00A8BEA8
	[Preserve]
	public static void reg(IntPtr l)
	{
		LuaObject.getTypeTable(l, "BlackJack.ProjectL.UI.MemoryCorridorUITask");
		if (Lua_BlackJack_ProjectL_UI_MemoryCorridorUITask.<>f__mg$cache0 == null)
		{
			Lua_BlackJack_ProjectL_UI_MemoryCorridorUITask.<>f__mg$cache0 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_MemoryCorridorUITask.OnStart);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_MemoryCorridorUITask.<>f__mg$cache0);
		if (Lua_BlackJack_ProjectL_UI_MemoryCorridorUITask.<>f__mg$cache1 == null)
		{
			Lua_BlackJack_ProjectL_UI_MemoryCorridorUITask.<>f__mg$cache1 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_MemoryCorridorUITask.OnResume);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_MemoryCorridorUITask.<>f__mg$cache1);
		if (Lua_BlackJack_ProjectL_UI_MemoryCorridorUITask.<>f__mg$cache2 == null)
		{
			Lua_BlackJack_ProjectL_UI_MemoryCorridorUITask.<>f__mg$cache2 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_MemoryCorridorUITask.InitDataFromUIIntent);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_MemoryCorridorUITask.<>f__mg$cache2);
		if (Lua_BlackJack_ProjectL_UI_MemoryCorridorUITask.<>f__mg$cache3 == null)
		{
			Lua_BlackJack_ProjectL_UI_MemoryCorridorUITask.<>f__mg$cache3 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_MemoryCorridorUITask.IsNeedLoadDynamicRes);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_MemoryCorridorUITask.<>f__mg$cache3);
		if (Lua_BlackJack_ProjectL_UI_MemoryCorridorUITask.<>f__mg$cache4 == null)
		{
			Lua_BlackJack_ProjectL_UI_MemoryCorridorUITask.<>f__mg$cache4 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_MemoryCorridorUITask.InitAllUIControllers);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_MemoryCorridorUITask.<>f__mg$cache4);
		if (Lua_BlackJack_ProjectL_UI_MemoryCorridorUITask.<>f__mg$cache5 == null)
		{
			Lua_BlackJack_ProjectL_UI_MemoryCorridorUITask.<>f__mg$cache5 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_MemoryCorridorUITask.ClearAllContextAndRes);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_MemoryCorridorUITask.<>f__mg$cache5);
		if (Lua_BlackJack_ProjectL_UI_MemoryCorridorUITask.<>f__mg$cache6 == null)
		{
			Lua_BlackJack_ProjectL_UI_MemoryCorridorUITask.<>f__mg$cache6 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_MemoryCorridorUITask.InitMemoryCorridorUIController);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_MemoryCorridorUITask.<>f__mg$cache6);
		if (Lua_BlackJack_ProjectL_UI_MemoryCorridorUITask.<>f__mg$cache7 == null)
		{
			Lua_BlackJack_ProjectL_UI_MemoryCorridorUITask.<>f__mg$cache7 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_MemoryCorridorUITask.UninitMemoryCorridorUIController);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_MemoryCorridorUITask.<>f__mg$cache7);
		if (Lua_BlackJack_ProjectL_UI_MemoryCorridorUITask.<>f__mg$cache8 == null)
		{
			Lua_BlackJack_ProjectL_UI_MemoryCorridorUITask.<>f__mg$cache8 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_MemoryCorridorUITask.OnMemoryWarning);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_MemoryCorridorUITask.<>f__mg$cache8);
		if (Lua_BlackJack_ProjectL_UI_MemoryCorridorUITask.<>f__mg$cache9 == null)
		{
			Lua_BlackJack_ProjectL_UI_MemoryCorridorUITask.<>f__mg$cache9 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_MemoryCorridorUITask.UpdateView);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_MemoryCorridorUITask.<>f__mg$cache9);
		if (Lua_BlackJack_ProjectL_UI_MemoryCorridorUITask.<>f__mg$cacheA == null)
		{
			Lua_BlackJack_ProjectL_UI_MemoryCorridorUITask.<>f__mg$cacheA = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_MemoryCorridorUITask.MemoryCorridorUIController_OnReturn);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_MemoryCorridorUITask.<>f__mg$cacheA);
		if (Lua_BlackJack_ProjectL_UI_MemoryCorridorUITask.<>f__mg$cacheB == null)
		{
			Lua_BlackJack_ProjectL_UI_MemoryCorridorUITask.<>f__mg$cacheB = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_MemoryCorridorUITask.MemoryCorridorUIController_OnShowHelp);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_MemoryCorridorUITask.<>f__mg$cacheB);
		if (Lua_BlackJack_ProjectL_UI_MemoryCorridorUITask.<>f__mg$cacheC == null)
		{
			Lua_BlackJack_ProjectL_UI_MemoryCorridorUITask.<>f__mg$cacheC = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_MemoryCorridorUITask.MemoryCorridorUIController_OnAddTicket);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_MemoryCorridorUITask.<>f__mg$cacheC);
		if (Lua_BlackJack_ProjectL_UI_MemoryCorridorUITask.<>f__mg$cacheD == null)
		{
			Lua_BlackJack_ProjectL_UI_MemoryCorridorUITask.<>f__mg$cacheD = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_MemoryCorridorUITask.MemoryCorridorUIController_OnShowTeam);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_MemoryCorridorUITask.<>f__mg$cacheD);
		if (Lua_BlackJack_ProjectL_UI_MemoryCorridorUITask.<>f__mg$cacheE == null)
		{
			Lua_BlackJack_ProjectL_UI_MemoryCorridorUITask.<>f__mg$cacheE = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_MemoryCorridorUITask.TeamUITask_OnLoadAllResCompleted);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_MemoryCorridorUITask.<>f__mg$cacheE);
		if (Lua_BlackJack_ProjectL_UI_MemoryCorridorUITask.<>f__mg$cacheF == null)
		{
			Lua_BlackJack_ProjectL_UI_MemoryCorridorUITask.<>f__mg$cacheF = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_MemoryCorridorUITask.MemoryCorridorUIController_OnStartMemoryCorridorLevel);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_MemoryCorridorUITask.<>f__mg$cacheF);
		if (Lua_BlackJack_ProjectL_UI_MemoryCorridorUITask.<>f__mg$cache10 == null)
		{
			Lua_BlackJack_ProjectL_UI_MemoryCorridorUITask.<>f__mg$cache10 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_MemoryCorridorUITask.__callBase_OnStart);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_MemoryCorridorUITask.<>f__mg$cache10);
		if (Lua_BlackJack_ProjectL_UI_MemoryCorridorUITask.<>f__mg$cache11 == null)
		{
			Lua_BlackJack_ProjectL_UI_MemoryCorridorUITask.<>f__mg$cache11 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_MemoryCorridorUITask.__callBase_OnStop);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_MemoryCorridorUITask.<>f__mg$cache11);
		if (Lua_BlackJack_ProjectL_UI_MemoryCorridorUITask.<>f__mg$cache12 == null)
		{
			Lua_BlackJack_ProjectL_UI_MemoryCorridorUITask.<>f__mg$cache12 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_MemoryCorridorUITask.__callBase_OnPause);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_MemoryCorridorUITask.<>f__mg$cache12);
		if (Lua_BlackJack_ProjectL_UI_MemoryCorridorUITask.<>f__mg$cache13 == null)
		{
			Lua_BlackJack_ProjectL_UI_MemoryCorridorUITask.<>f__mg$cache13 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_MemoryCorridorUITask.__callBase_OnResume);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_MemoryCorridorUITask.<>f__mg$cache13);
		if (Lua_BlackJack_ProjectL_UI_MemoryCorridorUITask.<>f__mg$cache14 == null)
		{
			Lua_BlackJack_ProjectL_UI_MemoryCorridorUITask.<>f__mg$cache14 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_MemoryCorridorUITask.__callBase_OnNewIntent);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_MemoryCorridorUITask.<>f__mg$cache14);
		if (Lua_BlackJack_ProjectL_UI_MemoryCorridorUITask.<>f__mg$cache15 == null)
		{
			Lua_BlackJack_ProjectL_UI_MemoryCorridorUITask.<>f__mg$cache15 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_MemoryCorridorUITask.__callBase_EnableUIInput);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_MemoryCorridorUITask.<>f__mg$cache15);
		if (Lua_BlackJack_ProjectL_UI_MemoryCorridorUITask.<>f__mg$cache16 == null)
		{
			Lua_BlackJack_ProjectL_UI_MemoryCorridorUITask.<>f__mg$cache16 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_MemoryCorridorUITask.__callBase_IsNeedLoadDynamicRes);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_MemoryCorridorUITask.<>f__mg$cache16);
		if (Lua_BlackJack_ProjectL_UI_MemoryCorridorUITask.<>f__mg$cache17 == null)
		{
			Lua_BlackJack_ProjectL_UI_MemoryCorridorUITask.<>f__mg$cache17 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_MemoryCorridorUITask.__callBase_CollectAllDynamicResForLoad);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_MemoryCorridorUITask.<>f__mg$cache17);
		if (Lua_BlackJack_ProjectL_UI_MemoryCorridorUITask.<>f__mg$cache18 == null)
		{
			Lua_BlackJack_ProjectL_UI_MemoryCorridorUITask.<>f__mg$cache18 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_MemoryCorridorUITask.__callBase_RegisterPlayerContextEvents);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_MemoryCorridorUITask.<>f__mg$cache18);
		if (Lua_BlackJack_ProjectL_UI_MemoryCorridorUITask.<>f__mg$cache19 == null)
		{
			Lua_BlackJack_ProjectL_UI_MemoryCorridorUITask.<>f__mg$cache19 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_MemoryCorridorUITask.__callBase_UnregisterPlayerContextEvents);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_MemoryCorridorUITask.<>f__mg$cache19);
		if (Lua_BlackJack_ProjectL_UI_MemoryCorridorUITask.<>f__mg$cache1A == null)
		{
			Lua_BlackJack_ProjectL_UI_MemoryCorridorUITask.<>f__mg$cache1A = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_MemoryCorridorUITask.__callBase_PostUpdateView);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_MemoryCorridorUITask.<>f__mg$cache1A);
		if (Lua_BlackJack_ProjectL_UI_MemoryCorridorUITask.<>f__mg$cache1B == null)
		{
			Lua_BlackJack_ProjectL_UI_MemoryCorridorUITask.<>f__mg$cache1B = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_MemoryCorridorUITask.__callBase_CollectPreloadResourceList);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_MemoryCorridorUITask.<>f__mg$cache1B);
		if (Lua_BlackJack_ProjectL_UI_MemoryCorridorUITask.<>f__mg$cache1C == null)
		{
			Lua_BlackJack_ProjectL_UI_MemoryCorridorUITask.<>f__mg$cache1C = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_MemoryCorridorUITask.__callBase_ClearAssetList);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_MemoryCorridorUITask.<>f__mg$cache1C);
		if (Lua_BlackJack_ProjectL_UI_MemoryCorridorUITask.<>f__mg$cache1D == null)
		{
			Lua_BlackJack_ProjectL_UI_MemoryCorridorUITask.<>f__mg$cache1D = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_MemoryCorridorUITask.__callBase_CollectAsset);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_MemoryCorridorUITask.<>f__mg$cache1D);
		if (Lua_BlackJack_ProjectL_UI_MemoryCorridorUITask.<>f__mg$cache1E == null)
		{
			Lua_BlackJack_ProjectL_UI_MemoryCorridorUITask.<>f__mg$cache1E = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_MemoryCorridorUITask.__callBase_CollectSpriteAsset);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_MemoryCorridorUITask.<>f__mg$cache1E);
		if (Lua_BlackJack_ProjectL_UI_MemoryCorridorUITask.<>f__mg$cache1F == null)
		{
			Lua_BlackJack_ProjectL_UI_MemoryCorridorUITask.<>f__mg$cache1F = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_MemoryCorridorUITask.__callBase_CollectFxAsset);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_MemoryCorridorUITask.<>f__mg$cache1F);
		if (Lua_BlackJack_ProjectL_UI_MemoryCorridorUITask.<>f__mg$cache20 == null)
		{
			Lua_BlackJack_ProjectL_UI_MemoryCorridorUITask.<>f__mg$cache20 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_MemoryCorridorUITask.__callBase_StartLoadCustomAssets);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_MemoryCorridorUITask.<>f__mg$cache20);
		if (Lua_BlackJack_ProjectL_UI_MemoryCorridorUITask.<>f__mg$cache21 == null)
		{
			Lua_BlackJack_ProjectL_UI_MemoryCorridorUITask.<>f__mg$cache21 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_MemoryCorridorUITask.__callBase_IsLoadingCustomAssets);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_MemoryCorridorUITask.<>f__mg$cache21);
		if (Lua_BlackJack_ProjectL_UI_MemoryCorridorUITask.<>f__mg$cache22 == null)
		{
			Lua_BlackJack_ProjectL_UI_MemoryCorridorUITask.<>f__mg$cache22 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_MemoryCorridorUITask.__callBase_IsPipeLineRunning);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_MemoryCorridorUITask.<>f__mg$cache22);
		if (Lua_BlackJack_ProjectL_UI_MemoryCorridorUITask.<>f__mg$cache23 == null)
		{
			Lua_BlackJack_ProjectL_UI_MemoryCorridorUITask.<>f__mg$cache23 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_MemoryCorridorUITask.__callBase_IsOpeningUI);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_MemoryCorridorUITask.<>f__mg$cache23);
		if (Lua_BlackJack_ProjectL_UI_MemoryCorridorUITask.<>f__mg$cache24 == null)
		{
			Lua_BlackJack_ProjectL_UI_MemoryCorridorUITask.<>f__mg$cache24 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_MemoryCorridorUITask.__callBase_ReturnPrevUITask);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_MemoryCorridorUITask.<>f__mg$cache24);
		if (Lua_BlackJack_ProjectL_UI_MemoryCorridorUITask.<>f__mg$cache25 == null)
		{
			Lua_BlackJack_ProjectL_UI_MemoryCorridorUITask.<>f__mg$cache25 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_MemoryCorridorUITask.__callBase_ClearUnusedDynamicResourceCache);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_MemoryCorridorUITask.<>f__mg$cache25);
		if (Lua_BlackJack_ProjectL_UI_MemoryCorridorUITask.<>f__mg$cache26 == null)
		{
			Lua_BlackJack_ProjectL_UI_MemoryCorridorUITask.<>f__mg$cache26 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_MemoryCorridorUITask.__callBase_OnMemoryWarning);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_MemoryCorridorUITask.<>f__mg$cache26);
		string name = "m_layerDescArray";
		if (Lua_BlackJack_ProjectL_UI_MemoryCorridorUITask.<>f__mg$cache27 == null)
		{
			Lua_BlackJack_ProjectL_UI_MemoryCorridorUITask.<>f__mg$cache27 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_MemoryCorridorUITask.get_m_layerDescArray);
		}
		LuaCSFunction get = Lua_BlackJack_ProjectL_UI_MemoryCorridorUITask.<>f__mg$cache27;
		if (Lua_BlackJack_ProjectL_UI_MemoryCorridorUITask.<>f__mg$cache28 == null)
		{
			Lua_BlackJack_ProjectL_UI_MemoryCorridorUITask.<>f__mg$cache28 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_MemoryCorridorUITask.set_m_layerDescArray);
		}
		LuaObject.addMember(l, name, get, Lua_BlackJack_ProjectL_UI_MemoryCorridorUITask.<>f__mg$cache28, true);
		string name2 = "m_uiCtrlDescArray";
		if (Lua_BlackJack_ProjectL_UI_MemoryCorridorUITask.<>f__mg$cache29 == null)
		{
			Lua_BlackJack_ProjectL_UI_MemoryCorridorUITask.<>f__mg$cache29 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_MemoryCorridorUITask.get_m_uiCtrlDescArray);
		}
		LuaCSFunction get2 = Lua_BlackJack_ProjectL_UI_MemoryCorridorUITask.<>f__mg$cache29;
		if (Lua_BlackJack_ProjectL_UI_MemoryCorridorUITask.<>f__mg$cache2A == null)
		{
			Lua_BlackJack_ProjectL_UI_MemoryCorridorUITask.<>f__mg$cache2A = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_MemoryCorridorUITask.set_m_uiCtrlDescArray);
		}
		LuaObject.addMember(l, name2, get2, Lua_BlackJack_ProjectL_UI_MemoryCorridorUITask.<>f__mg$cache2A, true);
		string name3 = "m_memoryCorridorUIController";
		if (Lua_BlackJack_ProjectL_UI_MemoryCorridorUITask.<>f__mg$cache2B == null)
		{
			Lua_BlackJack_ProjectL_UI_MemoryCorridorUITask.<>f__mg$cache2B = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_MemoryCorridorUITask.get_m_memoryCorridorUIController);
		}
		LuaCSFunction get3 = Lua_BlackJack_ProjectL_UI_MemoryCorridorUITask.<>f__mg$cache2B;
		if (Lua_BlackJack_ProjectL_UI_MemoryCorridorUITask.<>f__mg$cache2C == null)
		{
			Lua_BlackJack_ProjectL_UI_MemoryCorridorUITask.<>f__mg$cache2C = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_MemoryCorridorUITask.set_m_memoryCorridorUIController);
		}
		LuaObject.addMember(l, name3, get3, Lua_BlackJack_ProjectL_UI_MemoryCorridorUITask.<>f__mg$cache2C, true);
		string name4 = "m_playerResourceUIController";
		if (Lua_BlackJack_ProjectL_UI_MemoryCorridorUITask.<>f__mg$cache2D == null)
		{
			Lua_BlackJack_ProjectL_UI_MemoryCorridorUITask.<>f__mg$cache2D = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_MemoryCorridorUITask.get_m_playerResourceUIController);
		}
		LuaCSFunction get4 = Lua_BlackJack_ProjectL_UI_MemoryCorridorUITask.<>f__mg$cache2D;
		if (Lua_BlackJack_ProjectL_UI_MemoryCorridorUITask.<>f__mg$cache2E == null)
		{
			Lua_BlackJack_ProjectL_UI_MemoryCorridorUITask.<>f__mg$cache2E = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_MemoryCorridorUITask.set_m_playerResourceUIController);
		}
		LuaObject.addMember(l, name4, get4, Lua_BlackJack_ProjectL_UI_MemoryCorridorUITask.<>f__mg$cache2E, true);
		string name5 = "m_memoryCorridorInfo";
		if (Lua_BlackJack_ProjectL_UI_MemoryCorridorUITask.<>f__mg$cache2F == null)
		{
			Lua_BlackJack_ProjectL_UI_MemoryCorridorUITask.<>f__mg$cache2F = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_MemoryCorridorUITask.get_m_memoryCorridorInfo);
		}
		LuaCSFunction get5 = Lua_BlackJack_ProjectL_UI_MemoryCorridorUITask.<>f__mg$cache2F;
		if (Lua_BlackJack_ProjectL_UI_MemoryCorridorUITask.<>f__mg$cache30 == null)
		{
			Lua_BlackJack_ProjectL_UI_MemoryCorridorUITask.<>f__mg$cache30 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_MemoryCorridorUITask.set_m_memoryCorridorInfo);
		}
		LuaObject.addMember(l, name5, get5, Lua_BlackJack_ProjectL_UI_MemoryCorridorUITask.<>f__mg$cache30, true);
		string name6 = "LayerDescArray";
		if (Lua_BlackJack_ProjectL_UI_MemoryCorridorUITask.<>f__mg$cache31 == null)
		{
			Lua_BlackJack_ProjectL_UI_MemoryCorridorUITask.<>f__mg$cache31 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_MemoryCorridorUITask.get_LayerDescArray);
		}
		LuaObject.addMember(l, name6, Lua_BlackJack_ProjectL_UI_MemoryCorridorUITask.<>f__mg$cache31, null, true);
		string name7 = "UICtrlDescArray";
		if (Lua_BlackJack_ProjectL_UI_MemoryCorridorUITask.<>f__mg$cache32 == null)
		{
			Lua_BlackJack_ProjectL_UI_MemoryCorridorUITask.<>f__mg$cache32 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_MemoryCorridorUITask.get_UICtrlDescArray);
		}
		LuaObject.addMember(l, name7, Lua_BlackJack_ProjectL_UI_MemoryCorridorUITask.<>f__mg$cache32, null, true);
		if (Lua_BlackJack_ProjectL_UI_MemoryCorridorUITask.<>f__mg$cache33 == null)
		{
			Lua_BlackJack_ProjectL_UI_MemoryCorridorUITask.<>f__mg$cache33 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_MemoryCorridorUITask.constructor);
		}
		LuaObject.createTypeMetatable(l, Lua_BlackJack_ProjectL_UI_MemoryCorridorUITask.<>f__mg$cache33, typeof(MemoryCorridorUITask), typeof(UITask));
	}

	// Token: 0x04015E87 RID: 89735
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache0;

	// Token: 0x04015E88 RID: 89736
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1;

	// Token: 0x04015E89 RID: 89737
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2;

	// Token: 0x04015E8A RID: 89738
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3;

	// Token: 0x04015E8B RID: 89739
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache4;

	// Token: 0x04015E8C RID: 89740
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache5;

	// Token: 0x04015E8D RID: 89741
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache6;

	// Token: 0x04015E8E RID: 89742
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache7;

	// Token: 0x04015E8F RID: 89743
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache8;

	// Token: 0x04015E90 RID: 89744
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache9;

	// Token: 0x04015E91 RID: 89745
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheA;

	// Token: 0x04015E92 RID: 89746
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheB;

	// Token: 0x04015E93 RID: 89747
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheC;

	// Token: 0x04015E94 RID: 89748
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheD;

	// Token: 0x04015E95 RID: 89749
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheE;

	// Token: 0x04015E96 RID: 89750
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheF;

	// Token: 0x04015E97 RID: 89751
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache10;

	// Token: 0x04015E98 RID: 89752
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache11;

	// Token: 0x04015E99 RID: 89753
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache12;

	// Token: 0x04015E9A RID: 89754
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache13;

	// Token: 0x04015E9B RID: 89755
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache14;

	// Token: 0x04015E9C RID: 89756
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache15;

	// Token: 0x04015E9D RID: 89757
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache16;

	// Token: 0x04015E9E RID: 89758
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache17;

	// Token: 0x04015E9F RID: 89759
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache18;

	// Token: 0x04015EA0 RID: 89760
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache19;

	// Token: 0x04015EA1 RID: 89761
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1A;

	// Token: 0x04015EA2 RID: 89762
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1B;

	// Token: 0x04015EA3 RID: 89763
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1C;

	// Token: 0x04015EA4 RID: 89764
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1D;

	// Token: 0x04015EA5 RID: 89765
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1E;

	// Token: 0x04015EA6 RID: 89766
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1F;

	// Token: 0x04015EA7 RID: 89767
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache20;

	// Token: 0x04015EA8 RID: 89768
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache21;

	// Token: 0x04015EA9 RID: 89769
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache22;

	// Token: 0x04015EAA RID: 89770
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache23;

	// Token: 0x04015EAB RID: 89771
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache24;

	// Token: 0x04015EAC RID: 89772
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache25;

	// Token: 0x04015EAD RID: 89773
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache26;

	// Token: 0x04015EAE RID: 89774
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache27;

	// Token: 0x04015EAF RID: 89775
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache28;

	// Token: 0x04015EB0 RID: 89776
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache29;

	// Token: 0x04015EB1 RID: 89777
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2A;

	// Token: 0x04015EB2 RID: 89778
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2B;

	// Token: 0x04015EB3 RID: 89779
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2C;

	// Token: 0x04015EB4 RID: 89780
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2D;

	// Token: 0x04015EB5 RID: 89781
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2E;

	// Token: 0x04015EB6 RID: 89782
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2F;

	// Token: 0x04015EB7 RID: 89783
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache30;

	// Token: 0x04015EB8 RID: 89784
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache31;

	// Token: 0x04015EB9 RID: 89785
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache32;

	// Token: 0x04015EBA RID: 89786
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache33;
}
