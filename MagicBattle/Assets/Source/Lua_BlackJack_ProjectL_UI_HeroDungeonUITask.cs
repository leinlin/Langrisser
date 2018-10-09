using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using BlackJack.BJFramework.Runtime.TaskNs;
using BlackJack.BJFramework.Runtime.UI;
using BlackJack.ConfigData;
using BlackJack.ProjectL.PlayerContext;
using BlackJack.ProjectL.UI;
using SLua;
using UnityEngine.Scripting;

// Token: 0x020014C0 RID: 5312
[Preserve]
public class Lua_BlackJack_ProjectL_UI_HeroDungeonUITask : LuaObject
{
	// Token: 0x0601F0D2 RID: 127186 RVA: 0x00A1DDA8 File Offset: 0x00A1BFA8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int constructor(IntPtr l)
	{
		int result;
		try
		{
			string name;
			LuaObject.checkType(l, 2, out name);
			HeroDungeonUITask o = new HeroDungeonUITask(name);
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

	// Token: 0x0601F0D3 RID: 127187 RVA: 0x00A1DDFC File Offset: 0x00A1BFFC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int OnStart(IntPtr l)
	{
		int result;
		try
		{
			HeroDungeonUITask heroDungeonUITask = (HeroDungeonUITask)LuaObject.checkSelf(l);
			UIIntent intent;
			LuaObject.checkType<UIIntent>(l, 2, out intent);
			bool b = heroDungeonUITask.m_luaExportHelper.OnStart(intent);
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

	// Token: 0x0601F0D4 RID: 127188 RVA: 0x00A1DE64 File Offset: 0x00A1C064
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int OnResume(IntPtr l)
	{
		int result;
		try
		{
			HeroDungeonUITask heroDungeonUITask = (HeroDungeonUITask)LuaObject.checkSelf(l);
			UIIntent intent;
			LuaObject.checkType<UIIntent>(l, 2, out intent);
			bool b = heroDungeonUITask.m_luaExportHelper.OnResume(intent);
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

	// Token: 0x0601F0D5 RID: 127189 RVA: 0x00A1DECC File Offset: 0x00A1C0CC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int InitDataFromUIIntent(IntPtr l)
	{
		int result;
		try
		{
			HeroDungeonUITask heroDungeonUITask = (HeroDungeonUITask)LuaObject.checkSelf(l);
			UIIntent intent;
			LuaObject.checkType<UIIntent>(l, 2, out intent);
			heroDungeonUITask.m_luaExportHelper.InitDataFromUIIntent(intent);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601F0D6 RID: 127190 RVA: 0x00A1DF28 File Offset: 0x00A1C128
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int InitAllUIControllers(IntPtr l)
	{
		int result;
		try
		{
			HeroDungeonUITask heroDungeonUITask = (HeroDungeonUITask)LuaObject.checkSelf(l);
			heroDungeonUITask.m_luaExportHelper.InitAllUIControllers();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601F0D7 RID: 127191 RVA: 0x00A1DF7C File Offset: 0x00A1C17C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int ClearAllContextAndRes(IntPtr l)
	{
		int result;
		try
		{
			HeroDungeonUITask heroDungeonUITask = (HeroDungeonUITask)LuaObject.checkSelf(l);
			heroDungeonUITask.m_luaExportHelper.ClearAllContextAndRes();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601F0D8 RID: 127192 RVA: 0x00A1DFD0 File Offset: 0x00A1C1D0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int OnMemoryWarning(IntPtr l)
	{
		int result;
		try
		{
			HeroDungeonUITask heroDungeonUITask = (HeroDungeonUITask)LuaObject.checkSelf(l);
			heroDungeonUITask.m_luaExportHelper.OnMemoryWarning();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601F0D9 RID: 127193 RVA: 0x00A1E024 File Offset: 0x00A1C224
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int UpdateView(IntPtr l)
	{
		int result;
		try
		{
			HeroDungeonUITask heroDungeonUITask = (HeroDungeonUITask)LuaObject.checkSelf(l);
			heroDungeonUITask.m_luaExportHelper.UpdateView();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601F0DA RID: 127194 RVA: 0x00A1E078 File Offset: 0x00A1C278
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int IsNeedLoadDynamicRes(IntPtr l)
	{
		int result;
		try
		{
			HeroDungeonUITask heroDungeonUITask = (HeroDungeonUITask)LuaObject.checkSelf(l);
			bool b = heroDungeonUITask.m_luaExportHelper.IsNeedLoadDynamicRes();
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

	// Token: 0x0601F0DB RID: 127195 RVA: 0x00A1E0D4 File Offset: 0x00A1C2D4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int AutoGetStarReward(IntPtr l)
	{
		int result;
		try
		{
			HeroDungeonUITask heroDungeonUITask = (HeroDungeonUITask)LuaObject.checkSelf(l);
			heroDungeonUITask.m_luaExportHelper.AutoGetStarReward();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601F0DC RID: 127196 RVA: 0x00A1E128 File Offset: 0x00A1C328
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int PlayerResourceUIController_OnAddCrystal(IntPtr l)
	{
		int result;
		try
		{
			HeroDungeonUITask heroDungeonUITask = (HeroDungeonUITask)LuaObject.checkSelf(l);
			heroDungeonUITask.m_luaExportHelper.PlayerResourceUIController_OnAddCrystal();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601F0DD RID: 127197 RVA: 0x00A1E17C File Offset: 0x00A1C37C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int HeroDungeonUIController_OnReturn(IntPtr l)
	{
		int result;
		try
		{
			HeroDungeonUITask heroDungeonUITask = (HeroDungeonUITask)LuaObject.checkSelf(l);
			heroDungeonUITask.m_luaExportHelper.HeroDungeonUIController_OnReturn();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601F0DE RID: 127198 RVA: 0x00A1E1D0 File Offset: 0x00A1C3D0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int HeroDungeonUIController_OnShowHelp(IntPtr l)
	{
		int result;
		try
		{
			HeroDungeonUITask heroDungeonUITask = (HeroDungeonUITask)LuaObject.checkSelf(l);
			heroDungeonUITask.m_luaExportHelper.HeroDungeonUIController_OnShowHelp();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601F0DF RID: 127199 RVA: 0x00A1E224 File Offset: 0x00A1C424
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int HeroDungeonUIController_OnGetStarReward(IntPtr l)
	{
		int result;
		try
		{
			HeroDungeonUITask heroDungeonUITask = (HeroDungeonUITask)LuaObject.checkSelf(l);
			int index;
			LuaObject.checkType(l, 2, out index);
			heroDungeonUITask.m_luaExportHelper.HeroDungeonUIController_OnGetStarReward(index);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601F0E0 RID: 127200 RVA: 0x00A1E280 File Offset: 0x00A1C480
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int HeroDungeonUIController_OnSelectDungeonLevel(IntPtr l)
	{
		int result;
		try
		{
			HeroDungeonUITask heroDungeonUITask = (HeroDungeonUITask)LuaObject.checkSelf(l);
			ConfigDataHeroDungeonLevelInfo levelInfo;
			LuaObject.checkType<ConfigDataHeroDungeonLevelInfo>(l, 2, out levelInfo);
			heroDungeonUITask.m_luaExportHelper.HeroDungeonUIController_OnSelectDungeonLevel(levelInfo);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601F0E1 RID: 127201 RVA: 0x00A1E2DC File Offset: 0x00A1C4DC
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int StartHeroDungeonLevelInfoUITask(IntPtr l)
	{
		int result;
		try
		{
			HeroDungeonUITask heroDungeonUITask = (HeroDungeonUITask)LuaObject.checkSelf(l);
			ConfigDataHeroDungeonLevelInfo heroDungeonLevelInfo;
			LuaObject.checkType<ConfigDataHeroDungeonLevelInfo>(l, 2, out heroDungeonLevelInfo);
			heroDungeonUITask.m_luaExportHelper.StartHeroDungeonLevelInfoUITask(heroDungeonLevelInfo);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601F0E2 RID: 127202 RVA: 0x00A1E338 File Offset: 0x00A1C538
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int BattleLevelInfoUITask_OnClose(IntPtr l)
	{
		int result;
		try
		{
			HeroDungeonUITask heroDungeonUITask = (HeroDungeonUITask)LuaObject.checkSelf(l);
			heroDungeonUITask.m_luaExportHelper.BattleLevelInfoUITask_OnClose();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601F0E3 RID: 127203 RVA: 0x00A1E38C File Offset: 0x00A1C58C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int BattleLevelInfoUITask_OnHeroDungeonRaidComplete(IntPtr l)
	{
		int result;
		try
		{
			HeroDungeonUITask heroDungeonUITask = (HeroDungeonUITask)LuaObject.checkSelf(l);
			int levelId;
			LuaObject.checkType(l, 2, out levelId);
			heroDungeonUITask.m_luaExportHelper.BattleLevelInfoUITask_OnHeroDungeonRaidComplete(levelId);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601F0E4 RID: 127204 RVA: 0x00A1E3E8 File Offset: 0x00A1C5E8
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int ChestUITask_OnStop(IntPtr l)
	{
		int result;
		try
		{
			HeroDungeonUITask heroDungeonUITask = (HeroDungeonUITask)LuaObject.checkSelf(l);
			Task task;
			LuaObject.checkType<Task>(l, 2, out task);
			heroDungeonUITask.m_luaExportHelper.ChestUITask_OnStop(task);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601F0E5 RID: 127205 RVA: 0x00A1E444 File Offset: 0x00A1C644
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int ChestUITask_OnClose(IntPtr l)
	{
		int result;
		try
		{
			HeroDungeonUITask heroDungeonUITask = (HeroDungeonUITask)LuaObject.checkSelf(l);
			heroDungeonUITask.m_luaExportHelper.ChestUITask_OnClose();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601F0E6 RID: 127206 RVA: 0x00A1E498 File Offset: 0x00A1C698
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int __callBase_OnStart(IntPtr l)
	{
		int result;
		try
		{
			HeroDungeonUITask heroDungeonUITask = (HeroDungeonUITask)LuaObject.checkSelf(l);
			UIIntent intent;
			LuaObject.checkType<UIIntent>(l, 2, out intent);
			bool b = heroDungeonUITask.m_luaExportHelper.__callBase_OnStart(intent);
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

	// Token: 0x0601F0E7 RID: 127207 RVA: 0x00A1E500 File Offset: 0x00A1C700
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_OnStop(IntPtr l)
	{
		int result;
		try
		{
			HeroDungeonUITask heroDungeonUITask = (HeroDungeonUITask)LuaObject.checkSelf(l);
			heroDungeonUITask.m_luaExportHelper.__callBase_OnStop();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601F0E8 RID: 127208 RVA: 0x00A1E554 File Offset: 0x00A1C754
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_OnPause(IntPtr l)
	{
		int result;
		try
		{
			HeroDungeonUITask heroDungeonUITask = (HeroDungeonUITask)LuaObject.checkSelf(l);
			heroDungeonUITask.m_luaExportHelper.__callBase_OnPause();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601F0E9 RID: 127209 RVA: 0x00A1E5A8 File Offset: 0x00A1C7A8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_OnResume(IntPtr l)
	{
		int result;
		try
		{
			HeroDungeonUITask heroDungeonUITask = (HeroDungeonUITask)LuaObject.checkSelf(l);
			UIIntent intent;
			LuaObject.checkType<UIIntent>(l, 2, out intent);
			bool b = heroDungeonUITask.m_luaExportHelper.__callBase_OnResume(intent);
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

	// Token: 0x0601F0EA RID: 127210 RVA: 0x00A1E610 File Offset: 0x00A1C810
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int __callBase_OnNewIntent(IntPtr l)
	{
		int result;
		try
		{
			HeroDungeonUITask heroDungeonUITask = (HeroDungeonUITask)LuaObject.checkSelf(l);
			UIIntent intent;
			LuaObject.checkType<UIIntent>(l, 2, out intent);
			bool b = heroDungeonUITask.m_luaExportHelper.__callBase_OnNewIntent(intent);
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

	// Token: 0x0601F0EB RID: 127211 RVA: 0x00A1E678 File Offset: 0x00A1C878
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_EnableUIInput(IntPtr l)
	{
		int result;
		try
		{
			HeroDungeonUITask heroDungeonUITask = (HeroDungeonUITask)LuaObject.checkSelf(l);
			bool isEnable;
			LuaObject.checkType(l, 2, out isEnable);
			bool? isGlobalEnable;
			LuaObject.checkNullable<bool>(l, 3, out isGlobalEnable);
			heroDungeonUITask.m_luaExportHelper.__callBase_EnableUIInput(isEnable, isGlobalEnable);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601F0EC RID: 127212 RVA: 0x00A1E6E4 File Offset: 0x00A1C8E4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_IsNeedLoadDynamicRes(IntPtr l)
	{
		int result;
		try
		{
			HeroDungeonUITask heroDungeonUITask = (HeroDungeonUITask)LuaObject.checkSelf(l);
			bool b = heroDungeonUITask.m_luaExportHelper.__callBase_IsNeedLoadDynamicRes();
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

	// Token: 0x0601F0ED RID: 127213 RVA: 0x00A1E740 File Offset: 0x00A1C940
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int __callBase_CollectAllDynamicResForLoad(IntPtr l)
	{
		int result;
		try
		{
			HeroDungeonUITask heroDungeonUITask = (HeroDungeonUITask)LuaObject.checkSelf(l);
			List<string> o = heroDungeonUITask.m_luaExportHelper.__callBase_CollectAllDynamicResForLoad();
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

	// Token: 0x0601F0EE RID: 127214 RVA: 0x00A1E79C File Offset: 0x00A1C99C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_RegisterPlayerContextEvents(IntPtr l)
	{
		int result;
		try
		{
			HeroDungeonUITask heroDungeonUITask = (HeroDungeonUITask)LuaObject.checkSelf(l);
			heroDungeonUITask.m_luaExportHelper.__callBase_RegisterPlayerContextEvents();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601F0EF RID: 127215 RVA: 0x00A1E7F0 File Offset: 0x00A1C9F0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_UnregisterPlayerContextEvents(IntPtr l)
	{
		int result;
		try
		{
			HeroDungeonUITask heroDungeonUITask = (HeroDungeonUITask)LuaObject.checkSelf(l);
			heroDungeonUITask.m_luaExportHelper.__callBase_UnregisterPlayerContextEvents();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601F0F0 RID: 127216 RVA: 0x00A1E844 File Offset: 0x00A1CA44
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int __callBase_PostUpdateView(IntPtr l)
	{
		int result;
		try
		{
			HeroDungeonUITask heroDungeonUITask = (HeroDungeonUITask)LuaObject.checkSelf(l);
			heroDungeonUITask.m_luaExportHelper.__callBase_PostUpdateView();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601F0F1 RID: 127217 RVA: 0x00A1E898 File Offset: 0x00A1CA98
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_CollectPreloadResourceList(IntPtr l)
	{
		int result;
		try
		{
			HeroDungeonUITask heroDungeonUITask = (HeroDungeonUITask)LuaObject.checkSelf(l);
			heroDungeonUITask.m_luaExportHelper.__callBase_CollectPreloadResourceList();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601F0F2 RID: 127218 RVA: 0x00A1E8EC File Offset: 0x00A1CAEC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_ClearAssetList(IntPtr l)
	{
		int result;
		try
		{
			HeroDungeonUITask heroDungeonUITask = (HeroDungeonUITask)LuaObject.checkSelf(l);
			heroDungeonUITask.m_luaExportHelper.__callBase_ClearAssetList();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601F0F3 RID: 127219 RVA: 0x00A1E940 File Offset: 0x00A1CB40
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_CollectAsset(IntPtr l)
	{
		int result;
		try
		{
			HeroDungeonUITask heroDungeonUITask = (HeroDungeonUITask)LuaObject.checkSelf(l);
			string assetName;
			LuaObject.checkType(l, 2, out assetName);
			heroDungeonUITask.m_luaExportHelper.__callBase_CollectAsset(assetName);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601F0F4 RID: 127220 RVA: 0x00A1E99C File Offset: 0x00A1CB9C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_CollectSpriteAsset(IntPtr l)
	{
		int result;
		try
		{
			HeroDungeonUITask heroDungeonUITask = (HeroDungeonUITask)LuaObject.checkSelf(l);
			string assetName;
			LuaObject.checkType(l, 2, out assetName);
			heroDungeonUITask.m_luaExportHelper.__callBase_CollectSpriteAsset(assetName);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601F0F5 RID: 127221 RVA: 0x00A1E9F8 File Offset: 0x00A1CBF8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_CollectFxAsset(IntPtr l)
	{
		int result;
		try
		{
			HeroDungeonUITask heroDungeonUITask = (HeroDungeonUITask)LuaObject.checkSelf(l);
			string assetName;
			LuaObject.checkType(l, 2, out assetName);
			heroDungeonUITask.m_luaExportHelper.__callBase_CollectFxAsset(assetName);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601F0F6 RID: 127222 RVA: 0x00A1EA54 File Offset: 0x00A1CC54
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_StartLoadCustomAssets(IntPtr l)
	{
		int result;
		try
		{
			HeroDungeonUITask heroDungeonUITask = (HeroDungeonUITask)LuaObject.checkSelf(l);
			Action onLoadCompleted;
			LuaObject.checkDelegate<Action>(l, 2, out onLoadCompleted);
			heroDungeonUITask.m_luaExportHelper.__callBase_StartLoadCustomAssets(onLoadCompleted);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601F0F7 RID: 127223 RVA: 0x00A1EAB0 File Offset: 0x00A1CCB0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_IsLoadingCustomAssets(IntPtr l)
	{
		int result;
		try
		{
			HeroDungeonUITask heroDungeonUITask = (HeroDungeonUITask)LuaObject.checkSelf(l);
			bool b = heroDungeonUITask.m_luaExportHelper.__callBase_IsLoadingCustomAssets();
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

	// Token: 0x0601F0F8 RID: 127224 RVA: 0x00A1EB0C File Offset: 0x00A1CD0C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_IsPipeLineRunning(IntPtr l)
	{
		int result;
		try
		{
			HeroDungeonUITask heroDungeonUITask = (HeroDungeonUITask)LuaObject.checkSelf(l);
			bool b = heroDungeonUITask.m_luaExportHelper.__callBase_IsPipeLineRunning();
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

	// Token: 0x0601F0F9 RID: 127225 RVA: 0x00A1EB68 File Offset: 0x00A1CD68
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_IsOpeningUI(IntPtr l)
	{
		int result;
		try
		{
			HeroDungeonUITask heroDungeonUITask = (HeroDungeonUITask)LuaObject.checkSelf(l);
			bool b = heroDungeonUITask.m_luaExportHelper.__callBase_IsOpeningUI();
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

	// Token: 0x0601F0FA RID: 127226 RVA: 0x00A1EBC4 File Offset: 0x00A1CDC4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_ReturnPrevUITask(IntPtr l)
	{
		int result;
		try
		{
			HeroDungeonUITask heroDungeonUITask = (HeroDungeonUITask)LuaObject.checkSelf(l);
			UITaskBase o = heroDungeonUITask.m_luaExportHelper.__callBase_ReturnPrevUITask();
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

	// Token: 0x0601F0FB RID: 127227 RVA: 0x00A1EC20 File Offset: 0x00A1CE20
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_ClearUnusedDynamicResourceCache(IntPtr l)
	{
		int result;
		try
		{
			HeroDungeonUITask heroDungeonUITask = (HeroDungeonUITask)LuaObject.checkSelf(l);
			heroDungeonUITask.m_luaExportHelper.__callBase_ClearUnusedDynamicResourceCache();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601F0FC RID: 127228 RVA: 0x00A1EC74 File Offset: 0x00A1CE74
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_OnMemoryWarning(IntPtr l)
	{
		int result;
		try
		{
			HeroDungeonUITask heroDungeonUITask = (HeroDungeonUITask)LuaObject.checkSelf(l);
			heroDungeonUITask.m_luaExportHelper.__callBase_OnMemoryWarning();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601F0FD RID: 127229 RVA: 0x00A1ECC8 File Offset: 0x00A1CEC8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_layerDescArray(IntPtr l)
	{
		int result;
		try
		{
			HeroDungeonUITask heroDungeonUITask = (HeroDungeonUITask)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, heroDungeonUITask.m_luaExportHelper.m_layerDescArray);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601F0FE RID: 127230 RVA: 0x00A1ED20 File Offset: 0x00A1CF20
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_layerDescArray(IntPtr l)
	{
		int result;
		try
		{
			HeroDungeonUITask heroDungeonUITask = (HeroDungeonUITask)LuaObject.checkSelf(l);
			UITaskBase.LayerDesc[] layerDescArray;
			LuaObject.checkArray<UITaskBase.LayerDesc>(l, 2, out layerDescArray);
			heroDungeonUITask.m_luaExportHelper.m_layerDescArray = layerDescArray;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601F0FF RID: 127231 RVA: 0x00A1ED7C File Offset: 0x00A1CF7C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_uiCtrlDescArray(IntPtr l)
	{
		int result;
		try
		{
			HeroDungeonUITask heroDungeonUITask = (HeroDungeonUITask)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, heroDungeonUITask.m_luaExportHelper.m_uiCtrlDescArray);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601F100 RID: 127232 RVA: 0x00A1EDD4 File Offset: 0x00A1CFD4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_uiCtrlDescArray(IntPtr l)
	{
		int result;
		try
		{
			HeroDungeonUITask heroDungeonUITask = (HeroDungeonUITask)LuaObject.checkSelf(l);
			UITaskBase.UIControllerDesc[] uiCtrlDescArray;
			LuaObject.checkArray<UITaskBase.UIControllerDesc>(l, 2, out uiCtrlDescArray);
			heroDungeonUITask.m_luaExportHelper.m_uiCtrlDescArray = uiCtrlDescArray;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601F101 RID: 127233 RVA: 0x00A1EE30 File Offset: 0x00A1D030
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_heroDungeonUIController(IntPtr l)
	{
		int result;
		try
		{
			HeroDungeonUITask heroDungeonUITask = (HeroDungeonUITask)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, heroDungeonUITask.m_luaExportHelper.m_heroDungeonUIController);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601F102 RID: 127234 RVA: 0x00A1EE88 File Offset: 0x00A1D088
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_heroDungeonUIController(IntPtr l)
	{
		int result;
		try
		{
			HeroDungeonUITask heroDungeonUITask = (HeroDungeonUITask)LuaObject.checkSelf(l);
			HeroDungeonUIController heroDungeonUIController;
			LuaObject.checkType<HeroDungeonUIController>(l, 2, out heroDungeonUIController);
			heroDungeonUITask.m_luaExportHelper.m_heroDungeonUIController = heroDungeonUIController;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601F103 RID: 127235 RVA: 0x00A1EEE4 File Offset: 0x00A1D0E4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_playerResourceUIController(IntPtr l)
	{
		int result;
		try
		{
			HeroDungeonUITask heroDungeonUITask = (HeroDungeonUITask)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, heroDungeonUITask.m_luaExportHelper.m_playerResourceUIController);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601F104 RID: 127236 RVA: 0x00A1EF3C File Offset: 0x00A1D13C
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_m_playerResourceUIController(IntPtr l)
	{
		int result;
		try
		{
			HeroDungeonUITask heroDungeonUITask = (HeroDungeonUITask)LuaObject.checkSelf(l);
			PlayerResourceUIController playerResourceUIController;
			LuaObject.checkType<PlayerResourceUIController>(l, 2, out playerResourceUIController);
			heroDungeonUITask.m_luaExportHelper.m_playerResourceUIController = playerResourceUIController;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601F105 RID: 127237 RVA: 0x00A1EF98 File Offset: 0x00A1D198
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_battleLevelInfoUITask(IntPtr l)
	{
		int result;
		try
		{
			HeroDungeonUITask heroDungeonUITask = (HeroDungeonUITask)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, heroDungeonUITask.m_luaExportHelper.m_battleLevelInfoUITask);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601F106 RID: 127238 RVA: 0x00A1EFF0 File Offset: 0x00A1D1F0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_battleLevelInfoUITask(IntPtr l)
	{
		int result;
		try
		{
			HeroDungeonUITask heroDungeonUITask = (HeroDungeonUITask)LuaObject.checkSelf(l);
			BattleLevelInfoUITask battleLevelInfoUITask;
			LuaObject.checkType<BattleLevelInfoUITask>(l, 2, out battleLevelInfoUITask);
			heroDungeonUITask.m_luaExportHelper.m_battleLevelInfoUITask = battleLevelInfoUITask;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601F107 RID: 127239 RVA: 0x00A1F04C File Offset: 0x00A1D24C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_chestUITask(IntPtr l)
	{
		int result;
		try
		{
			HeroDungeonUITask heroDungeonUITask = (HeroDungeonUITask)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, heroDungeonUITask.m_luaExportHelper.m_chestUITask);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601F108 RID: 127240 RVA: 0x00A1F0A4 File Offset: 0x00A1D2A4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_chestUITask(IntPtr l)
	{
		int result;
		try
		{
			HeroDungeonUITask heroDungeonUITask = (HeroDungeonUITask)LuaObject.checkSelf(l);
			ChestUITask chestUITask;
			LuaObject.checkType<ChestUITask>(l, 2, out chestUITask);
			heroDungeonUITask.m_luaExportHelper.m_chestUITask = chestUITask;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601F109 RID: 127241 RVA: 0x00A1F100 File Offset: 0x00A1D300
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_heroInformationInfo(IntPtr l)
	{
		int result;
		try
		{
			HeroDungeonUITask heroDungeonUITask = (HeroDungeonUITask)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, heroDungeonUITask.m_luaExportHelper.m_heroInformationInfo);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601F10A RID: 127242 RVA: 0x00A1F158 File Offset: 0x00A1D358
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_heroInformationInfo(IntPtr l)
	{
		int result;
		try
		{
			HeroDungeonUITask heroDungeonUITask = (HeroDungeonUITask)LuaObject.checkSelf(l);
			ConfigDataHeroInformationInfo heroInformationInfo;
			LuaObject.checkType<ConfigDataHeroInformationInfo>(l, 2, out heroInformationInfo);
			heroDungeonUITask.m_luaExportHelper.m_heroInformationInfo = heroInformationInfo;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601F10B RID: 127243 RVA: 0x00A1F1B4 File Offset: 0x00A1D3B4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_heroDungeonLevelInfo(IntPtr l)
	{
		int result;
		try
		{
			HeroDungeonUITask heroDungeonUITask = (HeroDungeonUITask)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, heroDungeonUITask.m_luaExportHelper.m_heroDungeonLevelInfo);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601F10C RID: 127244 RVA: 0x00A1F20C File Offset: 0x00A1D40C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_heroDungeonLevelInfo(IntPtr l)
	{
		int result;
		try
		{
			HeroDungeonUITask heroDungeonUITask = (HeroDungeonUITask)LuaObject.checkSelf(l);
			ConfigDataHeroDungeonLevelInfo heroDungeonLevelInfo;
			LuaObject.checkType<ConfigDataHeroDungeonLevelInfo>(l, 2, out heroDungeonLevelInfo);
			heroDungeonUITask.m_luaExportHelper.m_heroDungeonLevelInfo = heroDungeonLevelInfo;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601F10D RID: 127245 RVA: 0x00A1F268 File Offset: 0x00A1D468
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_configDataLoader(IntPtr l)
	{
		int result;
		try
		{
			HeroDungeonUITask heroDungeonUITask = (HeroDungeonUITask)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, heroDungeonUITask.m_luaExportHelper.m_configDataLoader);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601F10E RID: 127246 RVA: 0x00A1F2C0 File Offset: 0x00A1D4C0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_configDataLoader(IntPtr l)
	{
		int result;
		try
		{
			HeroDungeonUITask heroDungeonUITask = (HeroDungeonUITask)LuaObject.checkSelf(l);
			IConfigDataLoader configDataLoader;
			LuaObject.checkType<IConfigDataLoader>(l, 2, out configDataLoader);
			heroDungeonUITask.m_luaExportHelper.m_configDataLoader = configDataLoader;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601F10F RID: 127247 RVA: 0x00A1F31C File Offset: 0x00A1D51C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_playerContext(IntPtr l)
	{
		int result;
		try
		{
			HeroDungeonUITask heroDungeonUITask = (HeroDungeonUITask)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, heroDungeonUITask.m_luaExportHelper.m_playerContext);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601F110 RID: 127248 RVA: 0x00A1F374 File Offset: 0x00A1D574
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_playerContext(IntPtr l)
	{
		int result;
		try
		{
			HeroDungeonUITask heroDungeonUITask = (HeroDungeonUITask)LuaObject.checkSelf(l);
			ProjectLPlayerContext playerContext;
			LuaObject.checkType<ProjectLPlayerContext>(l, 2, out playerContext);
			heroDungeonUITask.m_luaExportHelper.m_playerContext = playerContext;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601F111 RID: 127249 RVA: 0x00A1F3D0 File Offset: 0x00A1D5D0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_LayerDescArray(IntPtr l)
	{
		int result;
		try
		{
			HeroDungeonUITask heroDungeonUITask = (HeroDungeonUITask)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, heroDungeonUITask.m_luaExportHelper.LayerDescArray);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601F112 RID: 127250 RVA: 0x00A1F428 File Offset: 0x00A1D628
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_UICtrlDescArray(IntPtr l)
	{
		int result;
		try
		{
			HeroDungeonUITask heroDungeonUITask = (HeroDungeonUITask)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, heroDungeonUITask.m_luaExportHelper.UICtrlDescArray);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601F113 RID: 127251 RVA: 0x00A1F480 File Offset: 0x00A1D680
	[Preserve]
	public static void reg(IntPtr l)
	{
		LuaObject.getTypeTable(l, "BlackJack.ProjectL.UI.HeroDungeonUITask");
		if (Lua_BlackJack_ProjectL_UI_HeroDungeonUITask.<>f__mg$cache0 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroDungeonUITask.<>f__mg$cache0 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroDungeonUITask.OnStart);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_HeroDungeonUITask.<>f__mg$cache0);
		if (Lua_BlackJack_ProjectL_UI_HeroDungeonUITask.<>f__mg$cache1 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroDungeonUITask.<>f__mg$cache1 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroDungeonUITask.OnResume);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_HeroDungeonUITask.<>f__mg$cache1);
		if (Lua_BlackJack_ProjectL_UI_HeroDungeonUITask.<>f__mg$cache2 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroDungeonUITask.<>f__mg$cache2 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroDungeonUITask.InitDataFromUIIntent);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_HeroDungeonUITask.<>f__mg$cache2);
		if (Lua_BlackJack_ProjectL_UI_HeroDungeonUITask.<>f__mg$cache3 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroDungeonUITask.<>f__mg$cache3 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroDungeonUITask.InitAllUIControllers);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_HeroDungeonUITask.<>f__mg$cache3);
		if (Lua_BlackJack_ProjectL_UI_HeroDungeonUITask.<>f__mg$cache4 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroDungeonUITask.<>f__mg$cache4 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroDungeonUITask.ClearAllContextAndRes);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_HeroDungeonUITask.<>f__mg$cache4);
		if (Lua_BlackJack_ProjectL_UI_HeroDungeonUITask.<>f__mg$cache5 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroDungeonUITask.<>f__mg$cache5 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroDungeonUITask.OnMemoryWarning);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_HeroDungeonUITask.<>f__mg$cache5);
		if (Lua_BlackJack_ProjectL_UI_HeroDungeonUITask.<>f__mg$cache6 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroDungeonUITask.<>f__mg$cache6 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroDungeonUITask.UpdateView);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_HeroDungeonUITask.<>f__mg$cache6);
		if (Lua_BlackJack_ProjectL_UI_HeroDungeonUITask.<>f__mg$cache7 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroDungeonUITask.<>f__mg$cache7 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroDungeonUITask.IsNeedLoadDynamicRes);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_HeroDungeonUITask.<>f__mg$cache7);
		if (Lua_BlackJack_ProjectL_UI_HeroDungeonUITask.<>f__mg$cache8 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroDungeonUITask.<>f__mg$cache8 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroDungeonUITask.AutoGetStarReward);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_HeroDungeonUITask.<>f__mg$cache8);
		if (Lua_BlackJack_ProjectL_UI_HeroDungeonUITask.<>f__mg$cache9 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroDungeonUITask.<>f__mg$cache9 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroDungeonUITask.PlayerResourceUIController_OnAddCrystal);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_HeroDungeonUITask.<>f__mg$cache9);
		if (Lua_BlackJack_ProjectL_UI_HeroDungeonUITask.<>f__mg$cacheA == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroDungeonUITask.<>f__mg$cacheA = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroDungeonUITask.HeroDungeonUIController_OnReturn);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_HeroDungeonUITask.<>f__mg$cacheA);
		if (Lua_BlackJack_ProjectL_UI_HeroDungeonUITask.<>f__mg$cacheB == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroDungeonUITask.<>f__mg$cacheB = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroDungeonUITask.HeroDungeonUIController_OnShowHelp);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_HeroDungeonUITask.<>f__mg$cacheB);
		if (Lua_BlackJack_ProjectL_UI_HeroDungeonUITask.<>f__mg$cacheC == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroDungeonUITask.<>f__mg$cacheC = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroDungeonUITask.HeroDungeonUIController_OnGetStarReward);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_HeroDungeonUITask.<>f__mg$cacheC);
		if (Lua_BlackJack_ProjectL_UI_HeroDungeonUITask.<>f__mg$cacheD == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroDungeonUITask.<>f__mg$cacheD = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroDungeonUITask.HeroDungeonUIController_OnSelectDungeonLevel);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_HeroDungeonUITask.<>f__mg$cacheD);
		if (Lua_BlackJack_ProjectL_UI_HeroDungeonUITask.<>f__mg$cacheE == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroDungeonUITask.<>f__mg$cacheE = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroDungeonUITask.StartHeroDungeonLevelInfoUITask);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_HeroDungeonUITask.<>f__mg$cacheE);
		if (Lua_BlackJack_ProjectL_UI_HeroDungeonUITask.<>f__mg$cacheF == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroDungeonUITask.<>f__mg$cacheF = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroDungeonUITask.BattleLevelInfoUITask_OnClose);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_HeroDungeonUITask.<>f__mg$cacheF);
		if (Lua_BlackJack_ProjectL_UI_HeroDungeonUITask.<>f__mg$cache10 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroDungeonUITask.<>f__mg$cache10 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroDungeonUITask.BattleLevelInfoUITask_OnHeroDungeonRaidComplete);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_HeroDungeonUITask.<>f__mg$cache10);
		if (Lua_BlackJack_ProjectL_UI_HeroDungeonUITask.<>f__mg$cache11 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroDungeonUITask.<>f__mg$cache11 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroDungeonUITask.ChestUITask_OnStop);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_HeroDungeonUITask.<>f__mg$cache11);
		if (Lua_BlackJack_ProjectL_UI_HeroDungeonUITask.<>f__mg$cache12 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroDungeonUITask.<>f__mg$cache12 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroDungeonUITask.ChestUITask_OnClose);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_HeroDungeonUITask.<>f__mg$cache12);
		if (Lua_BlackJack_ProjectL_UI_HeroDungeonUITask.<>f__mg$cache13 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroDungeonUITask.<>f__mg$cache13 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroDungeonUITask.__callBase_OnStart);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_HeroDungeonUITask.<>f__mg$cache13);
		if (Lua_BlackJack_ProjectL_UI_HeroDungeonUITask.<>f__mg$cache14 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroDungeonUITask.<>f__mg$cache14 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroDungeonUITask.__callBase_OnStop);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_HeroDungeonUITask.<>f__mg$cache14);
		if (Lua_BlackJack_ProjectL_UI_HeroDungeonUITask.<>f__mg$cache15 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroDungeonUITask.<>f__mg$cache15 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroDungeonUITask.__callBase_OnPause);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_HeroDungeonUITask.<>f__mg$cache15);
		if (Lua_BlackJack_ProjectL_UI_HeroDungeonUITask.<>f__mg$cache16 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroDungeonUITask.<>f__mg$cache16 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroDungeonUITask.__callBase_OnResume);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_HeroDungeonUITask.<>f__mg$cache16);
		if (Lua_BlackJack_ProjectL_UI_HeroDungeonUITask.<>f__mg$cache17 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroDungeonUITask.<>f__mg$cache17 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroDungeonUITask.__callBase_OnNewIntent);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_HeroDungeonUITask.<>f__mg$cache17);
		if (Lua_BlackJack_ProjectL_UI_HeroDungeonUITask.<>f__mg$cache18 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroDungeonUITask.<>f__mg$cache18 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroDungeonUITask.__callBase_EnableUIInput);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_HeroDungeonUITask.<>f__mg$cache18);
		if (Lua_BlackJack_ProjectL_UI_HeroDungeonUITask.<>f__mg$cache19 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroDungeonUITask.<>f__mg$cache19 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroDungeonUITask.__callBase_IsNeedLoadDynamicRes);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_HeroDungeonUITask.<>f__mg$cache19);
		if (Lua_BlackJack_ProjectL_UI_HeroDungeonUITask.<>f__mg$cache1A == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroDungeonUITask.<>f__mg$cache1A = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroDungeonUITask.__callBase_CollectAllDynamicResForLoad);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_HeroDungeonUITask.<>f__mg$cache1A);
		if (Lua_BlackJack_ProjectL_UI_HeroDungeonUITask.<>f__mg$cache1B == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroDungeonUITask.<>f__mg$cache1B = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroDungeonUITask.__callBase_RegisterPlayerContextEvents);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_HeroDungeonUITask.<>f__mg$cache1B);
		if (Lua_BlackJack_ProjectL_UI_HeroDungeonUITask.<>f__mg$cache1C == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroDungeonUITask.<>f__mg$cache1C = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroDungeonUITask.__callBase_UnregisterPlayerContextEvents);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_HeroDungeonUITask.<>f__mg$cache1C);
		if (Lua_BlackJack_ProjectL_UI_HeroDungeonUITask.<>f__mg$cache1D == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroDungeonUITask.<>f__mg$cache1D = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroDungeonUITask.__callBase_PostUpdateView);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_HeroDungeonUITask.<>f__mg$cache1D);
		if (Lua_BlackJack_ProjectL_UI_HeroDungeonUITask.<>f__mg$cache1E == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroDungeonUITask.<>f__mg$cache1E = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroDungeonUITask.__callBase_CollectPreloadResourceList);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_HeroDungeonUITask.<>f__mg$cache1E);
		if (Lua_BlackJack_ProjectL_UI_HeroDungeonUITask.<>f__mg$cache1F == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroDungeonUITask.<>f__mg$cache1F = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroDungeonUITask.__callBase_ClearAssetList);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_HeroDungeonUITask.<>f__mg$cache1F);
		if (Lua_BlackJack_ProjectL_UI_HeroDungeonUITask.<>f__mg$cache20 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroDungeonUITask.<>f__mg$cache20 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroDungeonUITask.__callBase_CollectAsset);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_HeroDungeonUITask.<>f__mg$cache20);
		if (Lua_BlackJack_ProjectL_UI_HeroDungeonUITask.<>f__mg$cache21 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroDungeonUITask.<>f__mg$cache21 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroDungeonUITask.__callBase_CollectSpriteAsset);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_HeroDungeonUITask.<>f__mg$cache21);
		if (Lua_BlackJack_ProjectL_UI_HeroDungeonUITask.<>f__mg$cache22 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroDungeonUITask.<>f__mg$cache22 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroDungeonUITask.__callBase_CollectFxAsset);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_HeroDungeonUITask.<>f__mg$cache22);
		if (Lua_BlackJack_ProjectL_UI_HeroDungeonUITask.<>f__mg$cache23 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroDungeonUITask.<>f__mg$cache23 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroDungeonUITask.__callBase_StartLoadCustomAssets);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_HeroDungeonUITask.<>f__mg$cache23);
		if (Lua_BlackJack_ProjectL_UI_HeroDungeonUITask.<>f__mg$cache24 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroDungeonUITask.<>f__mg$cache24 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroDungeonUITask.__callBase_IsLoadingCustomAssets);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_HeroDungeonUITask.<>f__mg$cache24);
		if (Lua_BlackJack_ProjectL_UI_HeroDungeonUITask.<>f__mg$cache25 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroDungeonUITask.<>f__mg$cache25 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroDungeonUITask.__callBase_IsPipeLineRunning);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_HeroDungeonUITask.<>f__mg$cache25);
		if (Lua_BlackJack_ProjectL_UI_HeroDungeonUITask.<>f__mg$cache26 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroDungeonUITask.<>f__mg$cache26 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroDungeonUITask.__callBase_IsOpeningUI);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_HeroDungeonUITask.<>f__mg$cache26);
		if (Lua_BlackJack_ProjectL_UI_HeroDungeonUITask.<>f__mg$cache27 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroDungeonUITask.<>f__mg$cache27 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroDungeonUITask.__callBase_ReturnPrevUITask);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_HeroDungeonUITask.<>f__mg$cache27);
		if (Lua_BlackJack_ProjectL_UI_HeroDungeonUITask.<>f__mg$cache28 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroDungeonUITask.<>f__mg$cache28 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroDungeonUITask.__callBase_ClearUnusedDynamicResourceCache);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_HeroDungeonUITask.<>f__mg$cache28);
		if (Lua_BlackJack_ProjectL_UI_HeroDungeonUITask.<>f__mg$cache29 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroDungeonUITask.<>f__mg$cache29 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroDungeonUITask.__callBase_OnMemoryWarning);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_HeroDungeonUITask.<>f__mg$cache29);
		string name = "m_layerDescArray";
		if (Lua_BlackJack_ProjectL_UI_HeroDungeonUITask.<>f__mg$cache2A == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroDungeonUITask.<>f__mg$cache2A = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroDungeonUITask.get_m_layerDescArray);
		}
		LuaCSFunction get = Lua_BlackJack_ProjectL_UI_HeroDungeonUITask.<>f__mg$cache2A;
		if (Lua_BlackJack_ProjectL_UI_HeroDungeonUITask.<>f__mg$cache2B == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroDungeonUITask.<>f__mg$cache2B = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroDungeonUITask.set_m_layerDescArray);
		}
		LuaObject.addMember(l, name, get, Lua_BlackJack_ProjectL_UI_HeroDungeonUITask.<>f__mg$cache2B, true);
		string name2 = "m_uiCtrlDescArray";
		if (Lua_BlackJack_ProjectL_UI_HeroDungeonUITask.<>f__mg$cache2C == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroDungeonUITask.<>f__mg$cache2C = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroDungeonUITask.get_m_uiCtrlDescArray);
		}
		LuaCSFunction get2 = Lua_BlackJack_ProjectL_UI_HeroDungeonUITask.<>f__mg$cache2C;
		if (Lua_BlackJack_ProjectL_UI_HeroDungeonUITask.<>f__mg$cache2D == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroDungeonUITask.<>f__mg$cache2D = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroDungeonUITask.set_m_uiCtrlDescArray);
		}
		LuaObject.addMember(l, name2, get2, Lua_BlackJack_ProjectL_UI_HeroDungeonUITask.<>f__mg$cache2D, true);
		string name3 = "m_heroDungeonUIController";
		if (Lua_BlackJack_ProjectL_UI_HeroDungeonUITask.<>f__mg$cache2E == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroDungeonUITask.<>f__mg$cache2E = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroDungeonUITask.get_m_heroDungeonUIController);
		}
		LuaCSFunction get3 = Lua_BlackJack_ProjectL_UI_HeroDungeonUITask.<>f__mg$cache2E;
		if (Lua_BlackJack_ProjectL_UI_HeroDungeonUITask.<>f__mg$cache2F == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroDungeonUITask.<>f__mg$cache2F = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroDungeonUITask.set_m_heroDungeonUIController);
		}
		LuaObject.addMember(l, name3, get3, Lua_BlackJack_ProjectL_UI_HeroDungeonUITask.<>f__mg$cache2F, true);
		string name4 = "m_playerResourceUIController";
		if (Lua_BlackJack_ProjectL_UI_HeroDungeonUITask.<>f__mg$cache30 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroDungeonUITask.<>f__mg$cache30 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroDungeonUITask.get_m_playerResourceUIController);
		}
		LuaCSFunction get4 = Lua_BlackJack_ProjectL_UI_HeroDungeonUITask.<>f__mg$cache30;
		if (Lua_BlackJack_ProjectL_UI_HeroDungeonUITask.<>f__mg$cache31 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroDungeonUITask.<>f__mg$cache31 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroDungeonUITask.set_m_playerResourceUIController);
		}
		LuaObject.addMember(l, name4, get4, Lua_BlackJack_ProjectL_UI_HeroDungeonUITask.<>f__mg$cache31, true);
		string name5 = "m_battleLevelInfoUITask";
		if (Lua_BlackJack_ProjectL_UI_HeroDungeonUITask.<>f__mg$cache32 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroDungeonUITask.<>f__mg$cache32 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroDungeonUITask.get_m_battleLevelInfoUITask);
		}
		LuaCSFunction get5 = Lua_BlackJack_ProjectL_UI_HeroDungeonUITask.<>f__mg$cache32;
		if (Lua_BlackJack_ProjectL_UI_HeroDungeonUITask.<>f__mg$cache33 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroDungeonUITask.<>f__mg$cache33 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroDungeonUITask.set_m_battleLevelInfoUITask);
		}
		LuaObject.addMember(l, name5, get5, Lua_BlackJack_ProjectL_UI_HeroDungeonUITask.<>f__mg$cache33, true);
		string name6 = "m_chestUITask";
		if (Lua_BlackJack_ProjectL_UI_HeroDungeonUITask.<>f__mg$cache34 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroDungeonUITask.<>f__mg$cache34 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroDungeonUITask.get_m_chestUITask);
		}
		LuaCSFunction get6 = Lua_BlackJack_ProjectL_UI_HeroDungeonUITask.<>f__mg$cache34;
		if (Lua_BlackJack_ProjectL_UI_HeroDungeonUITask.<>f__mg$cache35 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroDungeonUITask.<>f__mg$cache35 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroDungeonUITask.set_m_chestUITask);
		}
		LuaObject.addMember(l, name6, get6, Lua_BlackJack_ProjectL_UI_HeroDungeonUITask.<>f__mg$cache35, true);
		string name7 = "m_heroInformationInfo";
		if (Lua_BlackJack_ProjectL_UI_HeroDungeonUITask.<>f__mg$cache36 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroDungeonUITask.<>f__mg$cache36 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroDungeonUITask.get_m_heroInformationInfo);
		}
		LuaCSFunction get7 = Lua_BlackJack_ProjectL_UI_HeroDungeonUITask.<>f__mg$cache36;
		if (Lua_BlackJack_ProjectL_UI_HeroDungeonUITask.<>f__mg$cache37 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroDungeonUITask.<>f__mg$cache37 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroDungeonUITask.set_m_heroInformationInfo);
		}
		LuaObject.addMember(l, name7, get7, Lua_BlackJack_ProjectL_UI_HeroDungeonUITask.<>f__mg$cache37, true);
		string name8 = "m_heroDungeonLevelInfo";
		if (Lua_BlackJack_ProjectL_UI_HeroDungeonUITask.<>f__mg$cache38 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroDungeonUITask.<>f__mg$cache38 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroDungeonUITask.get_m_heroDungeonLevelInfo);
		}
		LuaCSFunction get8 = Lua_BlackJack_ProjectL_UI_HeroDungeonUITask.<>f__mg$cache38;
		if (Lua_BlackJack_ProjectL_UI_HeroDungeonUITask.<>f__mg$cache39 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroDungeonUITask.<>f__mg$cache39 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroDungeonUITask.set_m_heroDungeonLevelInfo);
		}
		LuaObject.addMember(l, name8, get8, Lua_BlackJack_ProjectL_UI_HeroDungeonUITask.<>f__mg$cache39, true);
		string name9 = "m_configDataLoader";
		if (Lua_BlackJack_ProjectL_UI_HeroDungeonUITask.<>f__mg$cache3A == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroDungeonUITask.<>f__mg$cache3A = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroDungeonUITask.get_m_configDataLoader);
		}
		LuaCSFunction get9 = Lua_BlackJack_ProjectL_UI_HeroDungeonUITask.<>f__mg$cache3A;
		if (Lua_BlackJack_ProjectL_UI_HeroDungeonUITask.<>f__mg$cache3B == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroDungeonUITask.<>f__mg$cache3B = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroDungeonUITask.set_m_configDataLoader);
		}
		LuaObject.addMember(l, name9, get9, Lua_BlackJack_ProjectL_UI_HeroDungeonUITask.<>f__mg$cache3B, true);
		string name10 = "m_playerContext";
		if (Lua_BlackJack_ProjectL_UI_HeroDungeonUITask.<>f__mg$cache3C == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroDungeonUITask.<>f__mg$cache3C = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroDungeonUITask.get_m_playerContext);
		}
		LuaCSFunction get10 = Lua_BlackJack_ProjectL_UI_HeroDungeonUITask.<>f__mg$cache3C;
		if (Lua_BlackJack_ProjectL_UI_HeroDungeonUITask.<>f__mg$cache3D == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroDungeonUITask.<>f__mg$cache3D = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroDungeonUITask.set_m_playerContext);
		}
		LuaObject.addMember(l, name10, get10, Lua_BlackJack_ProjectL_UI_HeroDungeonUITask.<>f__mg$cache3D, true);
		string name11 = "LayerDescArray";
		if (Lua_BlackJack_ProjectL_UI_HeroDungeonUITask.<>f__mg$cache3E == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroDungeonUITask.<>f__mg$cache3E = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroDungeonUITask.get_LayerDescArray);
		}
		LuaObject.addMember(l, name11, Lua_BlackJack_ProjectL_UI_HeroDungeonUITask.<>f__mg$cache3E, null, true);
		string name12 = "UICtrlDescArray";
		if (Lua_BlackJack_ProjectL_UI_HeroDungeonUITask.<>f__mg$cache3F == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroDungeonUITask.<>f__mg$cache3F = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroDungeonUITask.get_UICtrlDescArray);
		}
		LuaObject.addMember(l, name12, Lua_BlackJack_ProjectL_UI_HeroDungeonUITask.<>f__mg$cache3F, null, true);
		if (Lua_BlackJack_ProjectL_UI_HeroDungeonUITask.<>f__mg$cache40 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroDungeonUITask.<>f__mg$cache40 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroDungeonUITask.constructor);
		}
		LuaObject.createTypeMetatable(l, Lua_BlackJack_ProjectL_UI_HeroDungeonUITask.<>f__mg$cache40, typeof(HeroDungeonUITask), typeof(UITask));
	}

	// Token: 0x04015134 RID: 86324
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache0;

	// Token: 0x04015135 RID: 86325
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1;

	// Token: 0x04015136 RID: 86326
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2;

	// Token: 0x04015137 RID: 86327
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3;

	// Token: 0x04015138 RID: 86328
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache4;

	// Token: 0x04015139 RID: 86329
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache5;

	// Token: 0x0401513A RID: 86330
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache6;

	// Token: 0x0401513B RID: 86331
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache7;

	// Token: 0x0401513C RID: 86332
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache8;

	// Token: 0x0401513D RID: 86333
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache9;

	// Token: 0x0401513E RID: 86334
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheA;

	// Token: 0x0401513F RID: 86335
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheB;

	// Token: 0x04015140 RID: 86336
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheC;

	// Token: 0x04015141 RID: 86337
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheD;

	// Token: 0x04015142 RID: 86338
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheE;

	// Token: 0x04015143 RID: 86339
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheF;

	// Token: 0x04015144 RID: 86340
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache10;

	// Token: 0x04015145 RID: 86341
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache11;

	// Token: 0x04015146 RID: 86342
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache12;

	// Token: 0x04015147 RID: 86343
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache13;

	// Token: 0x04015148 RID: 86344
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache14;

	// Token: 0x04015149 RID: 86345
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache15;

	// Token: 0x0401514A RID: 86346
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache16;

	// Token: 0x0401514B RID: 86347
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache17;

	// Token: 0x0401514C RID: 86348
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache18;

	// Token: 0x0401514D RID: 86349
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache19;

	// Token: 0x0401514E RID: 86350
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1A;

	// Token: 0x0401514F RID: 86351
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1B;

	// Token: 0x04015150 RID: 86352
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1C;

	// Token: 0x04015151 RID: 86353
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1D;

	// Token: 0x04015152 RID: 86354
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1E;

	// Token: 0x04015153 RID: 86355
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1F;

	// Token: 0x04015154 RID: 86356
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache20;

	// Token: 0x04015155 RID: 86357
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache21;

	// Token: 0x04015156 RID: 86358
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache22;

	// Token: 0x04015157 RID: 86359
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache23;

	// Token: 0x04015158 RID: 86360
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache24;

	// Token: 0x04015159 RID: 86361
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache25;

	// Token: 0x0401515A RID: 86362
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache26;

	// Token: 0x0401515B RID: 86363
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache27;

	// Token: 0x0401515C RID: 86364
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache28;

	// Token: 0x0401515D RID: 86365
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache29;

	// Token: 0x0401515E RID: 86366
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2A;

	// Token: 0x0401515F RID: 86367
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2B;

	// Token: 0x04015160 RID: 86368
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2C;

	// Token: 0x04015161 RID: 86369
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2D;

	// Token: 0x04015162 RID: 86370
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2E;

	// Token: 0x04015163 RID: 86371
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2F;

	// Token: 0x04015164 RID: 86372
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache30;

	// Token: 0x04015165 RID: 86373
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache31;

	// Token: 0x04015166 RID: 86374
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache32;

	// Token: 0x04015167 RID: 86375
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache33;

	// Token: 0x04015168 RID: 86376
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache34;

	// Token: 0x04015169 RID: 86377
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache35;

	// Token: 0x0401516A RID: 86378
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache36;

	// Token: 0x0401516B RID: 86379
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache37;

	// Token: 0x0401516C RID: 86380
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache38;

	// Token: 0x0401516D RID: 86381
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache39;

	// Token: 0x0401516E RID: 86382
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3A;

	// Token: 0x0401516F RID: 86383
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3B;

	// Token: 0x04015170 RID: 86384
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3C;

	// Token: 0x04015171 RID: 86385
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3D;

	// Token: 0x04015172 RID: 86386
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3E;

	// Token: 0x04015173 RID: 86387
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3F;

	// Token: 0x04015174 RID: 86388
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache40;
}
