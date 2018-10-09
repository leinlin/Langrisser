using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using BlackJack.BJFramework.Runtime.UI;
using BlackJack.ConfigData;
using BlackJack.ProjectL.Common;
using BlackJack.ProjectL.PlayerContext;
using BlackJack.ProjectL.UI;
using SLua;
using UnityEngine.Scripting;

// Token: 0x020013A3 RID: 5027
[Preserve]
public class Lua_BlackJack_ProjectL_UI_BattleLevelInfoUITask : LuaObject
{
	// Token: 0x0601B903 RID: 112899 RVA: 0x00862588 File Offset: 0x00860788
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int constructor(IntPtr l)
	{
		int result;
		try
		{
			string name;
			LuaObject.checkType(l, 2, out name);
			BattleLevelInfoUITask o = new BattleLevelInfoUITask(name);
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

	// Token: 0x0601B904 RID: 112900 RVA: 0x008625DC File Offset: 0x008607DC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int OnStart(IntPtr l)
	{
		int result;
		try
		{
			BattleLevelInfoUITask battleLevelInfoUITask = (BattleLevelInfoUITask)LuaObject.checkSelf(l);
			UIIntent intent;
			LuaObject.checkType<UIIntent>(l, 2, out intent);
			bool b = battleLevelInfoUITask.m_luaExportHelper.OnStart(intent);
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

	// Token: 0x0601B905 RID: 112901 RVA: 0x00862644 File Offset: 0x00860844
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int OnResume(IntPtr l)
	{
		int result;
		try
		{
			BattleLevelInfoUITask battleLevelInfoUITask = (BattleLevelInfoUITask)LuaObject.checkSelf(l);
			UIIntent intent;
			LuaObject.checkType<UIIntent>(l, 2, out intent);
			bool b = battleLevelInfoUITask.m_luaExportHelper.OnResume(intent);
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

	// Token: 0x0601B906 RID: 112902 RVA: 0x008626AC File Offset: 0x008608AC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int InitDataFromUIIntent(IntPtr l)
	{
		int result;
		try
		{
			BattleLevelInfoUITask battleLevelInfoUITask = (BattleLevelInfoUITask)LuaObject.checkSelf(l);
			UIIntent intent;
			LuaObject.checkType<UIIntent>(l, 2, out intent);
			battleLevelInfoUITask.m_luaExportHelper.InitDataFromUIIntent(intent);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601B907 RID: 112903 RVA: 0x00862708 File Offset: 0x00860908
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int IsNeedLoadDynamicRes(IntPtr l)
	{
		int result;
		try
		{
			BattleLevelInfoUITask battleLevelInfoUITask = (BattleLevelInfoUITask)LuaObject.checkSelf(l);
			bool b = battleLevelInfoUITask.m_luaExportHelper.IsNeedLoadDynamicRes();
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

	// Token: 0x0601B908 RID: 112904 RVA: 0x00862764 File Offset: 0x00860964
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int InitAllUIControllers(IntPtr l)
	{
		int result;
		try
		{
			BattleLevelInfoUITask battleLevelInfoUITask = (BattleLevelInfoUITask)LuaObject.checkSelf(l);
			battleLevelInfoUITask.m_luaExportHelper.InitAllUIControllers();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601B909 RID: 112905 RVA: 0x008627B8 File Offset: 0x008609B8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int ClearAllContextAndRes(IntPtr l)
	{
		int result;
		try
		{
			BattleLevelInfoUITask battleLevelInfoUITask = (BattleLevelInfoUITask)LuaObject.checkSelf(l);
			battleLevelInfoUITask.m_luaExportHelper.ClearAllContextAndRes();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601B90A RID: 112906 RVA: 0x0086280C File Offset: 0x00860A0C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int UpdateView(IntPtr l)
	{
		int result;
		try
		{
			BattleLevelInfoUITask battleLevelInfoUITask = (BattleLevelInfoUITask)LuaObject.checkSelf(l);
			battleLevelInfoUITask.m_luaExportHelper.UpdateView();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601B90B RID: 112907 RVA: 0x00862860 File Offset: 0x00860A60
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int UpdateRiftLevelInfo(IntPtr l)
	{
		int result;
		try
		{
			BattleLevelInfoUITask battleLevelInfoUITask = (BattleLevelInfoUITask)LuaObject.checkSelf(l);
			ConfigDataRiftLevelInfo levelInfo;
			LuaObject.checkType<ConfigDataRiftLevelInfo>(l, 2, out levelInfo);
			battleLevelInfoUITask.m_luaExportHelper.UpdateRiftLevelInfo(levelInfo);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601B90C RID: 112908 RVA: 0x008628BC File Offset: 0x00860ABC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int UpdateHeroDungeonLevelInfo(IntPtr l)
	{
		int result;
		try
		{
			BattleLevelInfoUITask battleLevelInfoUITask = (BattleLevelInfoUITask)LuaObject.checkSelf(l);
			ConfigDataHeroDungeonLevelInfo levelInfo;
			LuaObject.checkType<ConfigDataHeroDungeonLevelInfo>(l, 2, out levelInfo);
			battleLevelInfoUITask.m_luaExportHelper.UpdateHeroDungeonLevelInfo(levelInfo);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601B90D RID: 112909 RVA: 0x00862918 File Offset: 0x00860B18
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int StartRiftRaidLevelUITask(IntPtr l)
	{
		int result;
		try
		{
			BattleLevelInfoUITask battleLevelInfoUITask = (BattleLevelInfoUITask)LuaObject.checkSelf(l);
			int riftLevelID;
			LuaObject.checkType(l, 2, out riftLevelID);
			BattleReward reward;
			LuaObject.checkType<BattleReward>(l, 3, out reward);
			List<Goods> extraReward;
			LuaObject.checkType<List<Goods>>(l, 4, out extraReward);
			NeedGoods needGoods;
			LuaObject.checkType<NeedGoods>(l, 5, out needGoods);
			battleLevelInfoUITask.m_luaExportHelper.StartRiftRaidLevelUITask(riftLevelID, reward, extraReward, needGoods);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601B90E RID: 112910 RVA: 0x0086299C File Offset: 0x00860B9C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int StartHeroDungeonLevelRaidUITask(IntPtr l)
	{
		int result;
		try
		{
			BattleLevelInfoUITask battleLevelInfoUITask = (BattleLevelInfoUITask)LuaObject.checkSelf(l);
			int heroDungeonLevelID;
			LuaObject.checkType(l, 2, out heroDungeonLevelID);
			BattleReward reward;
			LuaObject.checkType<BattleReward>(l, 3, out reward);
			List<Goods> extraReward;
			LuaObject.checkType<List<Goods>>(l, 4, out extraReward);
			battleLevelInfoUITask.m_luaExportHelper.StartHeroDungeonLevelRaidUITask(heroDungeonLevelID, reward, extraReward);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601B90F RID: 112911 RVA: 0x00862A14 File Offset: 0x00860C14
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int RaidUITask_OnLoadAllResCompleted(IntPtr l)
	{
		int result;
		try
		{
			BattleLevelInfoUITask battleLevelInfoUITask = (BattleLevelInfoUITask)LuaObject.checkSelf(l);
			battleLevelInfoUITask.m_luaExportHelper.RaidUITask_OnLoadAllResCompleted();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601B910 RID: 112912 RVA: 0x00862A68 File Offset: 0x00860C68
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int StartRiftLevelRaidNetTask(IntPtr l)
	{
		int result;
		try
		{
			BattleLevelInfoUITask battleLevelInfoUITask = (BattleLevelInfoUITask)LuaObject.checkSelf(l);
			int levelId;
			LuaObject.checkType(l, 2, out levelId);
			int count;
			LuaObject.checkType(l, 3, out count);
			battleLevelInfoUITask.m_luaExportHelper.StartRiftLevelRaidNetTask(levelId, count);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601B911 RID: 112913 RVA: 0x00862AD4 File Offset: 0x00860CD4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int StartHeroDungeonLevelRaidNetTask(IntPtr l)
	{
		int result;
		try
		{
			BattleLevelInfoUITask battleLevelInfoUITask = (BattleLevelInfoUITask)LuaObject.checkSelf(l);
			int levelId;
			LuaObject.checkType(l, 2, out levelId);
			int count;
			LuaObject.checkType(l, 3, out count);
			battleLevelInfoUITask.m_luaExportHelper.StartHeroDungeonLevelRaidNetTask(levelId, count);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601B912 RID: 112914 RVA: 0x00862B40 File Offset: 0x00860D40
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int BattleLevelInfoUIController_OnStartBattle(IntPtr l)
	{
		int result;
		try
		{
			BattleLevelInfoUITask battleLevelInfoUITask = (BattleLevelInfoUITask)LuaObject.checkSelf(l);
			battleLevelInfoUITask.m_luaExportHelper.BattleLevelInfoUIController_OnStartBattle();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601B913 RID: 112915 RVA: 0x00862B94 File Offset: 0x00860D94
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int BattleLevelInfoUIController_OnRaidBattle(IntPtr l)
	{
		int result;
		try
		{
			BattleLevelInfoUITask battleLevelInfoUITask = (BattleLevelInfoUITask)LuaObject.checkSelf(l);
			int count;
			LuaObject.checkType(l, 2, out count);
			battleLevelInfoUITask.m_luaExportHelper.BattleLevelInfoUIController_OnRaidBattle(count);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601B914 RID: 112916 RVA: 0x00862BF0 File Offset: 0x00860DF0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int BattleLevelInfoUIController_OnShowAchievement(IntPtr l)
	{
		int result;
		try
		{
			BattleLevelInfoUITask battleLevelInfoUITask = (BattleLevelInfoUITask)LuaObject.checkSelf(l);
			battleLevelInfoUITask.m_luaExportHelper.BattleLevelInfoUIController_OnShowAchievement();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601B915 RID: 112917 RVA: 0x00862C44 File Offset: 0x00860E44
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int BattleLevelInfoUIController_OnClose(IntPtr l)
	{
		int result;
		try
		{
			BattleLevelInfoUITask battleLevelInfoUITask = (BattleLevelInfoUITask)LuaObject.checkSelf(l);
			battleLevelInfoUITask.m_luaExportHelper.BattleLevelInfoUIController_OnClose();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601B916 RID: 112918 RVA: 0x00862C98 File Offset: 0x00860E98
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int RaidLevelUITask_OnRiftRaidClose(IntPtr l)
	{
		int result;
		try
		{
			BattleLevelInfoUITask battleLevelInfoUITask = (BattleLevelInfoUITask)LuaObject.checkSelf(l);
			battleLevelInfoUITask.m_luaExportHelper.RaidLevelUITask_OnRiftRaidClose();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601B917 RID: 112919 RVA: 0x00862CEC File Offset: 0x00860EEC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int RaidLevelUITask_OnHeroDungeonRaidClose(IntPtr l)
	{
		int result;
		try
		{
			BattleLevelInfoUITask battleLevelInfoUITask = (BattleLevelInfoUITask)LuaObject.checkSelf(l);
			battleLevelInfoUITask.m_luaExportHelper.RaidLevelUITask_OnHeroDungeonRaidClose();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601B918 RID: 112920 RVA: 0x00862D40 File Offset: 0x00860F40
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int RaidLevelUITask_OnRiftRaidComplete(IntPtr l)
	{
		int result;
		try
		{
			BattleLevelInfoUITask battleLevelInfoUITask = (BattleLevelInfoUITask)LuaObject.checkSelf(l);
			int levelId;
			LuaObject.checkType(l, 2, out levelId);
			battleLevelInfoUITask.m_luaExportHelper.RaidLevelUITask_OnRiftRaidComplete(levelId);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601B919 RID: 112921 RVA: 0x00862D9C File Offset: 0x00860F9C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int RaidLevelUITask_OnHeroDungeonRaidComplete(IntPtr l)
	{
		int result;
		try
		{
			BattleLevelInfoUITask battleLevelInfoUITask = (BattleLevelInfoUITask)LuaObject.checkSelf(l);
			int levelId;
			LuaObject.checkType(l, 2, out levelId);
			battleLevelInfoUITask.m_luaExportHelper.RaidLevelUITask_OnHeroDungeonRaidComplete(levelId);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601B91A RID: 112922 RVA: 0x00862DF8 File Offset: 0x00860FF8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_OnStart(IntPtr l)
	{
		int result;
		try
		{
			BattleLevelInfoUITask battleLevelInfoUITask = (BattleLevelInfoUITask)LuaObject.checkSelf(l);
			UIIntent intent;
			LuaObject.checkType<UIIntent>(l, 2, out intent);
			bool b = battleLevelInfoUITask.m_luaExportHelper.__callBase_OnStart(intent);
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

	// Token: 0x0601B91B RID: 112923 RVA: 0x00862E60 File Offset: 0x00861060
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_OnStop(IntPtr l)
	{
		int result;
		try
		{
			BattleLevelInfoUITask battleLevelInfoUITask = (BattleLevelInfoUITask)LuaObject.checkSelf(l);
			battleLevelInfoUITask.m_luaExportHelper.__callBase_OnStop();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601B91C RID: 112924 RVA: 0x00862EB4 File Offset: 0x008610B4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_OnPause(IntPtr l)
	{
		int result;
		try
		{
			BattleLevelInfoUITask battleLevelInfoUITask = (BattleLevelInfoUITask)LuaObject.checkSelf(l);
			battleLevelInfoUITask.m_luaExportHelper.__callBase_OnPause();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601B91D RID: 112925 RVA: 0x00862F08 File Offset: 0x00861108
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_OnResume(IntPtr l)
	{
		int result;
		try
		{
			BattleLevelInfoUITask battleLevelInfoUITask = (BattleLevelInfoUITask)LuaObject.checkSelf(l);
			UIIntent intent;
			LuaObject.checkType<UIIntent>(l, 2, out intent);
			bool b = battleLevelInfoUITask.m_luaExportHelper.__callBase_OnResume(intent);
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

	// Token: 0x0601B91E RID: 112926 RVA: 0x00862F70 File Offset: 0x00861170
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_OnNewIntent(IntPtr l)
	{
		int result;
		try
		{
			BattleLevelInfoUITask battleLevelInfoUITask = (BattleLevelInfoUITask)LuaObject.checkSelf(l);
			UIIntent intent;
			LuaObject.checkType<UIIntent>(l, 2, out intent);
			bool b = battleLevelInfoUITask.m_luaExportHelper.__callBase_OnNewIntent(intent);
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

	// Token: 0x0601B91F RID: 112927 RVA: 0x00862FD8 File Offset: 0x008611D8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_EnableUIInput(IntPtr l)
	{
		int result;
		try
		{
			BattleLevelInfoUITask battleLevelInfoUITask = (BattleLevelInfoUITask)LuaObject.checkSelf(l);
			bool isEnable;
			LuaObject.checkType(l, 2, out isEnable);
			bool? isGlobalEnable;
			LuaObject.checkNullable<bool>(l, 3, out isGlobalEnable);
			battleLevelInfoUITask.m_luaExportHelper.__callBase_EnableUIInput(isEnable, isGlobalEnable);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601B920 RID: 112928 RVA: 0x00863044 File Offset: 0x00861244
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_IsNeedLoadDynamicRes(IntPtr l)
	{
		int result;
		try
		{
			BattleLevelInfoUITask battleLevelInfoUITask = (BattleLevelInfoUITask)LuaObject.checkSelf(l);
			bool b = battleLevelInfoUITask.m_luaExportHelper.__callBase_IsNeedLoadDynamicRes();
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

	// Token: 0x0601B921 RID: 112929 RVA: 0x008630A0 File Offset: 0x008612A0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_CollectAllDynamicResForLoad(IntPtr l)
	{
		int result;
		try
		{
			BattleLevelInfoUITask battleLevelInfoUITask = (BattleLevelInfoUITask)LuaObject.checkSelf(l);
			List<string> o = battleLevelInfoUITask.m_luaExportHelper.__callBase_CollectAllDynamicResForLoad();
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

	// Token: 0x0601B922 RID: 112930 RVA: 0x008630FC File Offset: 0x008612FC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_RegisterPlayerContextEvents(IntPtr l)
	{
		int result;
		try
		{
			BattleLevelInfoUITask battleLevelInfoUITask = (BattleLevelInfoUITask)LuaObject.checkSelf(l);
			battleLevelInfoUITask.m_luaExportHelper.__callBase_RegisterPlayerContextEvents();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601B923 RID: 112931 RVA: 0x00863150 File Offset: 0x00861350
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_UnregisterPlayerContextEvents(IntPtr l)
	{
		int result;
		try
		{
			BattleLevelInfoUITask battleLevelInfoUITask = (BattleLevelInfoUITask)LuaObject.checkSelf(l);
			battleLevelInfoUITask.m_luaExportHelper.__callBase_UnregisterPlayerContextEvents();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601B924 RID: 112932 RVA: 0x008631A4 File Offset: 0x008613A4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_PostUpdateView(IntPtr l)
	{
		int result;
		try
		{
			BattleLevelInfoUITask battleLevelInfoUITask = (BattleLevelInfoUITask)LuaObject.checkSelf(l);
			battleLevelInfoUITask.m_luaExportHelper.__callBase_PostUpdateView();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601B925 RID: 112933 RVA: 0x008631F8 File Offset: 0x008613F8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_CollectPreloadResourceList(IntPtr l)
	{
		int result;
		try
		{
			BattleLevelInfoUITask battleLevelInfoUITask = (BattleLevelInfoUITask)LuaObject.checkSelf(l);
			battleLevelInfoUITask.m_luaExportHelper.__callBase_CollectPreloadResourceList();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601B926 RID: 112934 RVA: 0x0086324C File Offset: 0x0086144C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_ClearAssetList(IntPtr l)
	{
		int result;
		try
		{
			BattleLevelInfoUITask battleLevelInfoUITask = (BattleLevelInfoUITask)LuaObject.checkSelf(l);
			battleLevelInfoUITask.m_luaExportHelper.__callBase_ClearAssetList();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601B927 RID: 112935 RVA: 0x008632A0 File Offset: 0x008614A0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_CollectAsset(IntPtr l)
	{
		int result;
		try
		{
			BattleLevelInfoUITask battleLevelInfoUITask = (BattleLevelInfoUITask)LuaObject.checkSelf(l);
			string assetName;
			LuaObject.checkType(l, 2, out assetName);
			battleLevelInfoUITask.m_luaExportHelper.__callBase_CollectAsset(assetName);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601B928 RID: 112936 RVA: 0x008632FC File Offset: 0x008614FC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_CollectSpriteAsset(IntPtr l)
	{
		int result;
		try
		{
			BattleLevelInfoUITask battleLevelInfoUITask = (BattleLevelInfoUITask)LuaObject.checkSelf(l);
			string assetName;
			LuaObject.checkType(l, 2, out assetName);
			battleLevelInfoUITask.m_luaExportHelper.__callBase_CollectSpriteAsset(assetName);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601B929 RID: 112937 RVA: 0x00863358 File Offset: 0x00861558
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_CollectFxAsset(IntPtr l)
	{
		int result;
		try
		{
			BattleLevelInfoUITask battleLevelInfoUITask = (BattleLevelInfoUITask)LuaObject.checkSelf(l);
			string assetName;
			LuaObject.checkType(l, 2, out assetName);
			battleLevelInfoUITask.m_luaExportHelper.__callBase_CollectFxAsset(assetName);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601B92A RID: 112938 RVA: 0x008633B4 File Offset: 0x008615B4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_StartLoadCustomAssets(IntPtr l)
	{
		int result;
		try
		{
			BattleLevelInfoUITask battleLevelInfoUITask = (BattleLevelInfoUITask)LuaObject.checkSelf(l);
			Action onLoadCompleted;
			LuaObject.checkDelegate<Action>(l, 2, out onLoadCompleted);
			battleLevelInfoUITask.m_luaExportHelper.__callBase_StartLoadCustomAssets(onLoadCompleted);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601B92B RID: 112939 RVA: 0x00863410 File Offset: 0x00861610
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_IsLoadingCustomAssets(IntPtr l)
	{
		int result;
		try
		{
			BattleLevelInfoUITask battleLevelInfoUITask = (BattleLevelInfoUITask)LuaObject.checkSelf(l);
			bool b = battleLevelInfoUITask.m_luaExportHelper.__callBase_IsLoadingCustomAssets();
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

	// Token: 0x0601B92C RID: 112940 RVA: 0x0086346C File Offset: 0x0086166C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_IsPipeLineRunning(IntPtr l)
	{
		int result;
		try
		{
			BattleLevelInfoUITask battleLevelInfoUITask = (BattleLevelInfoUITask)LuaObject.checkSelf(l);
			bool b = battleLevelInfoUITask.m_luaExportHelper.__callBase_IsPipeLineRunning();
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

	// Token: 0x0601B92D RID: 112941 RVA: 0x008634C8 File Offset: 0x008616C8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_IsOpeningUI(IntPtr l)
	{
		int result;
		try
		{
			BattleLevelInfoUITask battleLevelInfoUITask = (BattleLevelInfoUITask)LuaObject.checkSelf(l);
			bool b = battleLevelInfoUITask.m_luaExportHelper.__callBase_IsOpeningUI();
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

	// Token: 0x0601B92E RID: 112942 RVA: 0x00863524 File Offset: 0x00861724
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_ReturnPrevUITask(IntPtr l)
	{
		int result;
		try
		{
			BattleLevelInfoUITask battleLevelInfoUITask = (BattleLevelInfoUITask)LuaObject.checkSelf(l);
			UITaskBase o = battleLevelInfoUITask.m_luaExportHelper.__callBase_ReturnPrevUITask();
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

	// Token: 0x0601B92F RID: 112943 RVA: 0x00863580 File Offset: 0x00861780
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_ClearUnusedDynamicResourceCache(IntPtr l)
	{
		int result;
		try
		{
			BattleLevelInfoUITask battleLevelInfoUITask = (BattleLevelInfoUITask)LuaObject.checkSelf(l);
			battleLevelInfoUITask.m_luaExportHelper.__callBase_ClearUnusedDynamicResourceCache();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601B930 RID: 112944 RVA: 0x008635D4 File Offset: 0x008617D4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_OnMemoryWarning(IntPtr l)
	{
		int result;
		try
		{
			BattleLevelInfoUITask battleLevelInfoUITask = (BattleLevelInfoUITask)LuaObject.checkSelf(l);
			battleLevelInfoUITask.m_luaExportHelper.__callBase_OnMemoryWarning();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601B931 RID: 112945 RVA: 0x00863628 File Offset: 0x00861828
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callDele_EventOnClose(IntPtr l)
	{
		int result;
		try
		{
			BattleLevelInfoUITask battleLevelInfoUITask = (BattleLevelInfoUITask)LuaObject.checkSelf(l);
			battleLevelInfoUITask.m_luaExportHelper.__callDele_EventOnClose();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601B932 RID: 112946 RVA: 0x0086367C File Offset: 0x0086187C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __clearDele_EventOnClose(IntPtr l)
	{
		int result;
		try
		{
			BattleLevelInfoUITask battleLevelInfoUITask = (BattleLevelInfoUITask)LuaObject.checkSelf(l);
			battleLevelInfoUITask.m_luaExportHelper.__clearDele_EventOnClose();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601B933 RID: 112947 RVA: 0x008636D0 File Offset: 0x008618D0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callDele_EventOnRiftRaidComplete(IntPtr l)
	{
		int result;
		try
		{
			BattleLevelInfoUITask battleLevelInfoUITask = (BattleLevelInfoUITask)LuaObject.checkSelf(l);
			int obj;
			LuaObject.checkType(l, 2, out obj);
			battleLevelInfoUITask.m_luaExportHelper.__callDele_EventOnRiftRaidComplete(obj);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601B934 RID: 112948 RVA: 0x0086372C File Offset: 0x0086192C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __clearDele_EventOnRiftRaidComplete(IntPtr l)
	{
		int result;
		try
		{
			BattleLevelInfoUITask battleLevelInfoUITask = (BattleLevelInfoUITask)LuaObject.checkSelf(l);
			int obj;
			LuaObject.checkType(l, 2, out obj);
			battleLevelInfoUITask.m_luaExportHelper.__clearDele_EventOnRiftRaidComplete(obj);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601B935 RID: 112949 RVA: 0x00863788 File Offset: 0x00861988
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callDele_EventOnHeroDungeonRaidComplete(IntPtr l)
	{
		int result;
		try
		{
			BattleLevelInfoUITask battleLevelInfoUITask = (BattleLevelInfoUITask)LuaObject.checkSelf(l);
			int obj;
			LuaObject.checkType(l, 2, out obj);
			battleLevelInfoUITask.m_luaExportHelper.__callDele_EventOnHeroDungeonRaidComplete(obj);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601B936 RID: 112950 RVA: 0x008637E4 File Offset: 0x008619E4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __clearDele_EventOnHeroDungeonRaidComplete(IntPtr l)
	{
		int result;
		try
		{
			BattleLevelInfoUITask battleLevelInfoUITask = (BattleLevelInfoUITask)LuaObject.checkSelf(l);
			int obj;
			LuaObject.checkType(l, 2, out obj);
			battleLevelInfoUITask.m_luaExportHelper.__clearDele_EventOnHeroDungeonRaidComplete(obj);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601B937 RID: 112951 RVA: 0x00863840 File Offset: 0x00861A40
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_EventOnClose(IntPtr l)
	{
		int result;
		try
		{
			BattleLevelInfoUITask battleLevelInfoUITask = (BattleLevelInfoUITask)LuaObject.checkSelf(l);
			Action value;
			int num = LuaObject.checkDelegate<Action>(l, 2, out value);
			if (num != 0)
			{
				if (num == 1)
				{
					battleLevelInfoUITask.EventOnClose += value;
				}
				else if (num == 2)
				{
					battleLevelInfoUITask.EventOnClose -= value;
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

	// Token: 0x0601B938 RID: 112952 RVA: 0x008638C0 File Offset: 0x00861AC0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_EventOnRiftRaidComplete(IntPtr l)
	{
		int result;
		try
		{
			BattleLevelInfoUITask battleLevelInfoUITask = (BattleLevelInfoUITask)LuaObject.checkSelf(l);
			Action<int> value;
			int num = LuaObject.checkDelegate<Action<int>>(l, 2, out value);
			if (num != 0)
			{
				if (num == 1)
				{
					battleLevelInfoUITask.EventOnRiftRaidComplete += value;
				}
				else if (num == 2)
				{
					battleLevelInfoUITask.EventOnRiftRaidComplete -= value;
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

	// Token: 0x0601B939 RID: 112953 RVA: 0x00863940 File Offset: 0x00861B40
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_EventOnHeroDungeonRaidComplete(IntPtr l)
	{
		int result;
		try
		{
			BattleLevelInfoUITask battleLevelInfoUITask = (BattleLevelInfoUITask)LuaObject.checkSelf(l);
			Action<int> value;
			int num = LuaObject.checkDelegate<Action<int>>(l, 2, out value);
			if (num != 0)
			{
				if (num == 1)
				{
					battleLevelInfoUITask.EventOnHeroDungeonRaidComplete += value;
				}
				else if (num == 2)
				{
					battleLevelInfoUITask.EventOnHeroDungeonRaidComplete -= value;
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

	// Token: 0x0601B93A RID: 112954 RVA: 0x008639C0 File Offset: 0x00861BC0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_layerDescArray(IntPtr l)
	{
		int result;
		try
		{
			BattleLevelInfoUITask battleLevelInfoUITask = (BattleLevelInfoUITask)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, battleLevelInfoUITask.m_luaExportHelper.m_layerDescArray);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601B93B RID: 112955 RVA: 0x00863A18 File Offset: 0x00861C18
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_layerDescArray(IntPtr l)
	{
		int result;
		try
		{
			BattleLevelInfoUITask battleLevelInfoUITask = (BattleLevelInfoUITask)LuaObject.checkSelf(l);
			UITaskBase.LayerDesc[] layerDescArray;
			LuaObject.checkArray<UITaskBase.LayerDesc>(l, 2, out layerDescArray);
			battleLevelInfoUITask.m_luaExportHelper.m_layerDescArray = layerDescArray;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601B93C RID: 112956 RVA: 0x00863A74 File Offset: 0x00861C74
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_uiCtrlDescArray(IntPtr l)
	{
		int result;
		try
		{
			BattleLevelInfoUITask battleLevelInfoUITask = (BattleLevelInfoUITask)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, battleLevelInfoUITask.m_luaExportHelper.m_uiCtrlDescArray);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601B93D RID: 112957 RVA: 0x00863ACC File Offset: 0x00861CCC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_uiCtrlDescArray(IntPtr l)
	{
		int result;
		try
		{
			BattleLevelInfoUITask battleLevelInfoUITask = (BattleLevelInfoUITask)LuaObject.checkSelf(l);
			UITaskBase.UIControllerDesc[] uiCtrlDescArray;
			LuaObject.checkArray<UITaskBase.UIControllerDesc>(l, 2, out uiCtrlDescArray);
			battleLevelInfoUITask.m_luaExportHelper.m_uiCtrlDescArray = uiCtrlDescArray;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601B93E RID: 112958 RVA: 0x00863B28 File Offset: 0x00861D28
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_battleLevelInfoUIController(IntPtr l)
	{
		int result;
		try
		{
			BattleLevelInfoUITask battleLevelInfoUITask = (BattleLevelInfoUITask)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, battleLevelInfoUITask.m_luaExportHelper.m_battleLevelInfoUIController);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601B93F RID: 112959 RVA: 0x00863B80 File Offset: 0x00861D80
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_battleLevelInfoUIController(IntPtr l)
	{
		int result;
		try
		{
			BattleLevelInfoUITask battleLevelInfoUITask = (BattleLevelInfoUITask)LuaObject.checkSelf(l);
			BattleLevelInfoUIController battleLevelInfoUIController;
			LuaObject.checkType<BattleLevelInfoUIController>(l, 2, out battleLevelInfoUIController);
			battleLevelInfoUITask.m_luaExportHelper.m_battleLevelInfoUIController = battleLevelInfoUIController;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601B940 RID: 112960 RVA: 0x00863BDC File Offset: 0x00861DDC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_raidLevelUITask(IntPtr l)
	{
		int result;
		try
		{
			BattleLevelInfoUITask battleLevelInfoUITask = (BattleLevelInfoUITask)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, battleLevelInfoUITask.m_luaExportHelper.m_raidLevelUITask);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601B941 RID: 112961 RVA: 0x00863C34 File Offset: 0x00861E34
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_raidLevelUITask(IntPtr l)
	{
		int result;
		try
		{
			BattleLevelInfoUITask battleLevelInfoUITask = (BattleLevelInfoUITask)LuaObject.checkSelf(l);
			RaidLevelUITask raidLevelUITask;
			LuaObject.checkType<RaidLevelUITask>(l, 2, out raidLevelUITask);
			battleLevelInfoUITask.m_luaExportHelper.m_raidLevelUITask = raidLevelUITask;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601B942 RID: 112962 RVA: 0x00863C90 File Offset: 0x00861E90
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_riftLevelInfo(IntPtr l)
	{
		int result;
		try
		{
			BattleLevelInfoUITask battleLevelInfoUITask = (BattleLevelInfoUITask)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, battleLevelInfoUITask.m_luaExportHelper.m_riftLevelInfo);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601B943 RID: 112963 RVA: 0x00863CE8 File Offset: 0x00861EE8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_riftLevelInfo(IntPtr l)
	{
		int result;
		try
		{
			BattleLevelInfoUITask battleLevelInfoUITask = (BattleLevelInfoUITask)LuaObject.checkSelf(l);
			ConfigDataRiftLevelInfo riftLevelInfo;
			LuaObject.checkType<ConfigDataRiftLevelInfo>(l, 2, out riftLevelInfo);
			battleLevelInfoUITask.m_luaExportHelper.m_riftLevelInfo = riftLevelInfo;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601B944 RID: 112964 RVA: 0x00863D44 File Offset: 0x00861F44
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_heroDungeonLevelInfo(IntPtr l)
	{
		int result;
		try
		{
			BattleLevelInfoUITask battleLevelInfoUITask = (BattleLevelInfoUITask)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, battleLevelInfoUITask.m_luaExportHelper.m_heroDungeonLevelInfo);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601B945 RID: 112965 RVA: 0x00863D9C File Offset: 0x00861F9C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_heroDungeonLevelInfo(IntPtr l)
	{
		int result;
		try
		{
			BattleLevelInfoUITask battleLevelInfoUITask = (BattleLevelInfoUITask)LuaObject.checkSelf(l);
			ConfigDataHeroDungeonLevelInfo heroDungeonLevelInfo;
			LuaObject.checkType<ConfigDataHeroDungeonLevelInfo>(l, 2, out heroDungeonLevelInfo);
			battleLevelInfoUITask.m_luaExportHelper.m_heroDungeonLevelInfo = heroDungeonLevelInfo;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601B946 RID: 112966 RVA: 0x00863DF8 File Offset: 0x00861FF8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_battleType(IntPtr l)
	{
		int result;
		try
		{
			BattleLevelInfoUITask battleLevelInfoUITask = (BattleLevelInfoUITask)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushEnum(l, (int)battleLevelInfoUITask.m_luaExportHelper.m_battleType);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601B947 RID: 112967 RVA: 0x00863E50 File Offset: 0x00862050
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_battleType(IntPtr l)
	{
		int result;
		try
		{
			BattleLevelInfoUITask battleLevelInfoUITask = (BattleLevelInfoUITask)LuaObject.checkSelf(l);
			BattleType battleType;
			LuaObject.checkEnum<BattleType>(l, 2, out battleType);
			battleLevelInfoUITask.m_luaExportHelper.m_battleType = battleType;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601B948 RID: 112968 RVA: 0x00863EAC File Offset: 0x008620AC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_needGoods(IntPtr l)
	{
		int result;
		try
		{
			BattleLevelInfoUITask battleLevelInfoUITask = (BattleLevelInfoUITask)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, battleLevelInfoUITask.m_luaExportHelper.m_needGoods);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601B949 RID: 112969 RVA: 0x00863F04 File Offset: 0x00862104
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_needGoods(IntPtr l)
	{
		int result;
		try
		{
			BattleLevelInfoUITask battleLevelInfoUITask = (BattleLevelInfoUITask)LuaObject.checkSelf(l);
			NeedGoods needGoods;
			LuaObject.checkType<NeedGoods>(l, 2, out needGoods);
			battleLevelInfoUITask.m_luaExportHelper.m_needGoods = needGoods;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601B94A RID: 112970 RVA: 0x00863F60 File Offset: 0x00862160
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_needOpenTween(IntPtr l)
	{
		int result;
		try
		{
			BattleLevelInfoUITask battleLevelInfoUITask = (BattleLevelInfoUITask)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, battleLevelInfoUITask.m_luaExportHelper.m_needOpenTween);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601B94B RID: 112971 RVA: 0x00863FB8 File Offset: 0x008621B8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_needOpenTween(IntPtr l)
	{
		int result;
		try
		{
			BattleLevelInfoUITask battleLevelInfoUITask = (BattleLevelInfoUITask)LuaObject.checkSelf(l);
			bool needOpenTween;
			LuaObject.checkType(l, 2, out needOpenTween);
			battleLevelInfoUITask.m_luaExportHelper.m_needOpenTween = needOpenTween;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601B94C RID: 112972 RVA: 0x00864014 File Offset: 0x00862214
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_LayerDescArray(IntPtr l)
	{
		int result;
		try
		{
			BattleLevelInfoUITask battleLevelInfoUITask = (BattleLevelInfoUITask)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, battleLevelInfoUITask.m_luaExportHelper.LayerDescArray);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601B94D RID: 112973 RVA: 0x0086406C File Offset: 0x0086226C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_UICtrlDescArray(IntPtr l)
	{
		int result;
		try
		{
			BattleLevelInfoUITask battleLevelInfoUITask = (BattleLevelInfoUITask)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, battleLevelInfoUITask.m_luaExportHelper.UICtrlDescArray);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601B94E RID: 112974 RVA: 0x008640C4 File Offset: 0x008622C4
	[Preserve]
	public static void reg(IntPtr l)
	{
		LuaObject.getTypeTable(l, "BlackJack.ProjectL.UI.BattleLevelInfoUITask");
		if (Lua_BlackJack_ProjectL_UI_BattleLevelInfoUITask.<>f__mg$cache0 == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleLevelInfoUITask.<>f__mg$cache0 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleLevelInfoUITask.OnStart);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_BattleLevelInfoUITask.<>f__mg$cache0);
		if (Lua_BlackJack_ProjectL_UI_BattleLevelInfoUITask.<>f__mg$cache1 == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleLevelInfoUITask.<>f__mg$cache1 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleLevelInfoUITask.OnResume);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_BattleLevelInfoUITask.<>f__mg$cache1);
		if (Lua_BlackJack_ProjectL_UI_BattleLevelInfoUITask.<>f__mg$cache2 == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleLevelInfoUITask.<>f__mg$cache2 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleLevelInfoUITask.InitDataFromUIIntent);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_BattleLevelInfoUITask.<>f__mg$cache2);
		if (Lua_BlackJack_ProjectL_UI_BattleLevelInfoUITask.<>f__mg$cache3 == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleLevelInfoUITask.<>f__mg$cache3 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleLevelInfoUITask.IsNeedLoadDynamicRes);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_BattleLevelInfoUITask.<>f__mg$cache3);
		if (Lua_BlackJack_ProjectL_UI_BattleLevelInfoUITask.<>f__mg$cache4 == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleLevelInfoUITask.<>f__mg$cache4 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleLevelInfoUITask.InitAllUIControllers);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_BattleLevelInfoUITask.<>f__mg$cache4);
		if (Lua_BlackJack_ProjectL_UI_BattleLevelInfoUITask.<>f__mg$cache5 == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleLevelInfoUITask.<>f__mg$cache5 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleLevelInfoUITask.ClearAllContextAndRes);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_BattleLevelInfoUITask.<>f__mg$cache5);
		if (Lua_BlackJack_ProjectL_UI_BattleLevelInfoUITask.<>f__mg$cache6 == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleLevelInfoUITask.<>f__mg$cache6 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleLevelInfoUITask.UpdateView);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_BattleLevelInfoUITask.<>f__mg$cache6);
		if (Lua_BlackJack_ProjectL_UI_BattleLevelInfoUITask.<>f__mg$cache7 == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleLevelInfoUITask.<>f__mg$cache7 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleLevelInfoUITask.UpdateRiftLevelInfo);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_BattleLevelInfoUITask.<>f__mg$cache7);
		if (Lua_BlackJack_ProjectL_UI_BattleLevelInfoUITask.<>f__mg$cache8 == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleLevelInfoUITask.<>f__mg$cache8 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleLevelInfoUITask.UpdateHeroDungeonLevelInfo);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_BattleLevelInfoUITask.<>f__mg$cache8);
		if (Lua_BlackJack_ProjectL_UI_BattleLevelInfoUITask.<>f__mg$cache9 == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleLevelInfoUITask.<>f__mg$cache9 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleLevelInfoUITask.StartRiftRaidLevelUITask);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_BattleLevelInfoUITask.<>f__mg$cache9);
		if (Lua_BlackJack_ProjectL_UI_BattleLevelInfoUITask.<>f__mg$cacheA == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleLevelInfoUITask.<>f__mg$cacheA = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleLevelInfoUITask.StartHeroDungeonLevelRaidUITask);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_BattleLevelInfoUITask.<>f__mg$cacheA);
		if (Lua_BlackJack_ProjectL_UI_BattleLevelInfoUITask.<>f__mg$cacheB == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleLevelInfoUITask.<>f__mg$cacheB = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleLevelInfoUITask.RaidUITask_OnLoadAllResCompleted);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_BattleLevelInfoUITask.<>f__mg$cacheB);
		if (Lua_BlackJack_ProjectL_UI_BattleLevelInfoUITask.<>f__mg$cacheC == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleLevelInfoUITask.<>f__mg$cacheC = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleLevelInfoUITask.StartRiftLevelRaidNetTask);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_BattleLevelInfoUITask.<>f__mg$cacheC);
		if (Lua_BlackJack_ProjectL_UI_BattleLevelInfoUITask.<>f__mg$cacheD == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleLevelInfoUITask.<>f__mg$cacheD = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleLevelInfoUITask.StartHeroDungeonLevelRaidNetTask);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_BattleLevelInfoUITask.<>f__mg$cacheD);
		if (Lua_BlackJack_ProjectL_UI_BattleLevelInfoUITask.<>f__mg$cacheE == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleLevelInfoUITask.<>f__mg$cacheE = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleLevelInfoUITask.BattleLevelInfoUIController_OnStartBattle);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_BattleLevelInfoUITask.<>f__mg$cacheE);
		if (Lua_BlackJack_ProjectL_UI_BattleLevelInfoUITask.<>f__mg$cacheF == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleLevelInfoUITask.<>f__mg$cacheF = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleLevelInfoUITask.BattleLevelInfoUIController_OnRaidBattle);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_BattleLevelInfoUITask.<>f__mg$cacheF);
		if (Lua_BlackJack_ProjectL_UI_BattleLevelInfoUITask.<>f__mg$cache10 == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleLevelInfoUITask.<>f__mg$cache10 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleLevelInfoUITask.BattleLevelInfoUIController_OnShowAchievement);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_BattleLevelInfoUITask.<>f__mg$cache10);
		if (Lua_BlackJack_ProjectL_UI_BattleLevelInfoUITask.<>f__mg$cache11 == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleLevelInfoUITask.<>f__mg$cache11 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleLevelInfoUITask.BattleLevelInfoUIController_OnClose);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_BattleLevelInfoUITask.<>f__mg$cache11);
		if (Lua_BlackJack_ProjectL_UI_BattleLevelInfoUITask.<>f__mg$cache12 == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleLevelInfoUITask.<>f__mg$cache12 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleLevelInfoUITask.RaidLevelUITask_OnRiftRaidClose);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_BattleLevelInfoUITask.<>f__mg$cache12);
		if (Lua_BlackJack_ProjectL_UI_BattleLevelInfoUITask.<>f__mg$cache13 == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleLevelInfoUITask.<>f__mg$cache13 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleLevelInfoUITask.RaidLevelUITask_OnHeroDungeonRaidClose);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_BattleLevelInfoUITask.<>f__mg$cache13);
		if (Lua_BlackJack_ProjectL_UI_BattleLevelInfoUITask.<>f__mg$cache14 == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleLevelInfoUITask.<>f__mg$cache14 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleLevelInfoUITask.RaidLevelUITask_OnRiftRaidComplete);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_BattleLevelInfoUITask.<>f__mg$cache14);
		if (Lua_BlackJack_ProjectL_UI_BattleLevelInfoUITask.<>f__mg$cache15 == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleLevelInfoUITask.<>f__mg$cache15 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleLevelInfoUITask.RaidLevelUITask_OnHeroDungeonRaidComplete);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_BattleLevelInfoUITask.<>f__mg$cache15);
		if (Lua_BlackJack_ProjectL_UI_BattleLevelInfoUITask.<>f__mg$cache16 == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleLevelInfoUITask.<>f__mg$cache16 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleLevelInfoUITask.__callBase_OnStart);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_BattleLevelInfoUITask.<>f__mg$cache16);
		if (Lua_BlackJack_ProjectL_UI_BattleLevelInfoUITask.<>f__mg$cache17 == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleLevelInfoUITask.<>f__mg$cache17 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleLevelInfoUITask.__callBase_OnStop);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_BattleLevelInfoUITask.<>f__mg$cache17);
		if (Lua_BlackJack_ProjectL_UI_BattleLevelInfoUITask.<>f__mg$cache18 == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleLevelInfoUITask.<>f__mg$cache18 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleLevelInfoUITask.__callBase_OnPause);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_BattleLevelInfoUITask.<>f__mg$cache18);
		if (Lua_BlackJack_ProjectL_UI_BattleLevelInfoUITask.<>f__mg$cache19 == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleLevelInfoUITask.<>f__mg$cache19 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleLevelInfoUITask.__callBase_OnResume);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_BattleLevelInfoUITask.<>f__mg$cache19);
		if (Lua_BlackJack_ProjectL_UI_BattleLevelInfoUITask.<>f__mg$cache1A == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleLevelInfoUITask.<>f__mg$cache1A = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleLevelInfoUITask.__callBase_OnNewIntent);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_BattleLevelInfoUITask.<>f__mg$cache1A);
		if (Lua_BlackJack_ProjectL_UI_BattleLevelInfoUITask.<>f__mg$cache1B == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleLevelInfoUITask.<>f__mg$cache1B = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleLevelInfoUITask.__callBase_EnableUIInput);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_BattleLevelInfoUITask.<>f__mg$cache1B);
		if (Lua_BlackJack_ProjectL_UI_BattleLevelInfoUITask.<>f__mg$cache1C == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleLevelInfoUITask.<>f__mg$cache1C = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleLevelInfoUITask.__callBase_IsNeedLoadDynamicRes);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_BattleLevelInfoUITask.<>f__mg$cache1C);
		if (Lua_BlackJack_ProjectL_UI_BattleLevelInfoUITask.<>f__mg$cache1D == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleLevelInfoUITask.<>f__mg$cache1D = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleLevelInfoUITask.__callBase_CollectAllDynamicResForLoad);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_BattleLevelInfoUITask.<>f__mg$cache1D);
		if (Lua_BlackJack_ProjectL_UI_BattleLevelInfoUITask.<>f__mg$cache1E == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleLevelInfoUITask.<>f__mg$cache1E = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleLevelInfoUITask.__callBase_RegisterPlayerContextEvents);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_BattleLevelInfoUITask.<>f__mg$cache1E);
		if (Lua_BlackJack_ProjectL_UI_BattleLevelInfoUITask.<>f__mg$cache1F == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleLevelInfoUITask.<>f__mg$cache1F = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleLevelInfoUITask.__callBase_UnregisterPlayerContextEvents);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_BattleLevelInfoUITask.<>f__mg$cache1F);
		if (Lua_BlackJack_ProjectL_UI_BattleLevelInfoUITask.<>f__mg$cache20 == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleLevelInfoUITask.<>f__mg$cache20 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleLevelInfoUITask.__callBase_PostUpdateView);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_BattleLevelInfoUITask.<>f__mg$cache20);
		if (Lua_BlackJack_ProjectL_UI_BattleLevelInfoUITask.<>f__mg$cache21 == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleLevelInfoUITask.<>f__mg$cache21 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleLevelInfoUITask.__callBase_CollectPreloadResourceList);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_BattleLevelInfoUITask.<>f__mg$cache21);
		if (Lua_BlackJack_ProjectL_UI_BattleLevelInfoUITask.<>f__mg$cache22 == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleLevelInfoUITask.<>f__mg$cache22 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleLevelInfoUITask.__callBase_ClearAssetList);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_BattleLevelInfoUITask.<>f__mg$cache22);
		if (Lua_BlackJack_ProjectL_UI_BattleLevelInfoUITask.<>f__mg$cache23 == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleLevelInfoUITask.<>f__mg$cache23 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleLevelInfoUITask.__callBase_CollectAsset);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_BattleLevelInfoUITask.<>f__mg$cache23);
		if (Lua_BlackJack_ProjectL_UI_BattleLevelInfoUITask.<>f__mg$cache24 == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleLevelInfoUITask.<>f__mg$cache24 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleLevelInfoUITask.__callBase_CollectSpriteAsset);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_BattleLevelInfoUITask.<>f__mg$cache24);
		if (Lua_BlackJack_ProjectL_UI_BattleLevelInfoUITask.<>f__mg$cache25 == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleLevelInfoUITask.<>f__mg$cache25 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleLevelInfoUITask.__callBase_CollectFxAsset);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_BattleLevelInfoUITask.<>f__mg$cache25);
		if (Lua_BlackJack_ProjectL_UI_BattleLevelInfoUITask.<>f__mg$cache26 == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleLevelInfoUITask.<>f__mg$cache26 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleLevelInfoUITask.__callBase_StartLoadCustomAssets);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_BattleLevelInfoUITask.<>f__mg$cache26);
		if (Lua_BlackJack_ProjectL_UI_BattleLevelInfoUITask.<>f__mg$cache27 == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleLevelInfoUITask.<>f__mg$cache27 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleLevelInfoUITask.__callBase_IsLoadingCustomAssets);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_BattleLevelInfoUITask.<>f__mg$cache27);
		if (Lua_BlackJack_ProjectL_UI_BattleLevelInfoUITask.<>f__mg$cache28 == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleLevelInfoUITask.<>f__mg$cache28 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleLevelInfoUITask.__callBase_IsPipeLineRunning);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_BattleLevelInfoUITask.<>f__mg$cache28);
		if (Lua_BlackJack_ProjectL_UI_BattleLevelInfoUITask.<>f__mg$cache29 == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleLevelInfoUITask.<>f__mg$cache29 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleLevelInfoUITask.__callBase_IsOpeningUI);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_BattleLevelInfoUITask.<>f__mg$cache29);
		if (Lua_BlackJack_ProjectL_UI_BattleLevelInfoUITask.<>f__mg$cache2A == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleLevelInfoUITask.<>f__mg$cache2A = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleLevelInfoUITask.__callBase_ReturnPrevUITask);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_BattleLevelInfoUITask.<>f__mg$cache2A);
		if (Lua_BlackJack_ProjectL_UI_BattleLevelInfoUITask.<>f__mg$cache2B == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleLevelInfoUITask.<>f__mg$cache2B = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleLevelInfoUITask.__callBase_ClearUnusedDynamicResourceCache);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_BattleLevelInfoUITask.<>f__mg$cache2B);
		if (Lua_BlackJack_ProjectL_UI_BattleLevelInfoUITask.<>f__mg$cache2C == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleLevelInfoUITask.<>f__mg$cache2C = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleLevelInfoUITask.__callBase_OnMemoryWarning);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_BattleLevelInfoUITask.<>f__mg$cache2C);
		if (Lua_BlackJack_ProjectL_UI_BattleLevelInfoUITask.<>f__mg$cache2D == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleLevelInfoUITask.<>f__mg$cache2D = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleLevelInfoUITask.__callDele_EventOnClose);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_BattleLevelInfoUITask.<>f__mg$cache2D);
		if (Lua_BlackJack_ProjectL_UI_BattleLevelInfoUITask.<>f__mg$cache2E == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleLevelInfoUITask.<>f__mg$cache2E = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleLevelInfoUITask.__clearDele_EventOnClose);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_BattleLevelInfoUITask.<>f__mg$cache2E);
		if (Lua_BlackJack_ProjectL_UI_BattleLevelInfoUITask.<>f__mg$cache2F == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleLevelInfoUITask.<>f__mg$cache2F = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleLevelInfoUITask.__callDele_EventOnRiftRaidComplete);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_BattleLevelInfoUITask.<>f__mg$cache2F);
		if (Lua_BlackJack_ProjectL_UI_BattleLevelInfoUITask.<>f__mg$cache30 == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleLevelInfoUITask.<>f__mg$cache30 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleLevelInfoUITask.__clearDele_EventOnRiftRaidComplete);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_BattleLevelInfoUITask.<>f__mg$cache30);
		if (Lua_BlackJack_ProjectL_UI_BattleLevelInfoUITask.<>f__mg$cache31 == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleLevelInfoUITask.<>f__mg$cache31 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleLevelInfoUITask.__callDele_EventOnHeroDungeonRaidComplete);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_BattleLevelInfoUITask.<>f__mg$cache31);
		if (Lua_BlackJack_ProjectL_UI_BattleLevelInfoUITask.<>f__mg$cache32 == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleLevelInfoUITask.<>f__mg$cache32 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleLevelInfoUITask.__clearDele_EventOnHeroDungeonRaidComplete);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_BattleLevelInfoUITask.<>f__mg$cache32);
		string name = "EventOnClose";
		LuaCSFunction get = null;
		if (Lua_BlackJack_ProjectL_UI_BattleLevelInfoUITask.<>f__mg$cache33 == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleLevelInfoUITask.<>f__mg$cache33 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleLevelInfoUITask.set_EventOnClose);
		}
		LuaObject.addMember(l, name, get, Lua_BlackJack_ProjectL_UI_BattleLevelInfoUITask.<>f__mg$cache33, true);
		string name2 = "EventOnRiftRaidComplete";
		LuaCSFunction get2 = null;
		if (Lua_BlackJack_ProjectL_UI_BattleLevelInfoUITask.<>f__mg$cache34 == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleLevelInfoUITask.<>f__mg$cache34 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleLevelInfoUITask.set_EventOnRiftRaidComplete);
		}
		LuaObject.addMember(l, name2, get2, Lua_BlackJack_ProjectL_UI_BattleLevelInfoUITask.<>f__mg$cache34, true);
		string name3 = "EventOnHeroDungeonRaidComplete";
		LuaCSFunction get3 = null;
		if (Lua_BlackJack_ProjectL_UI_BattleLevelInfoUITask.<>f__mg$cache35 == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleLevelInfoUITask.<>f__mg$cache35 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleLevelInfoUITask.set_EventOnHeroDungeonRaidComplete);
		}
		LuaObject.addMember(l, name3, get3, Lua_BlackJack_ProjectL_UI_BattleLevelInfoUITask.<>f__mg$cache35, true);
		string name4 = "m_layerDescArray";
		if (Lua_BlackJack_ProjectL_UI_BattleLevelInfoUITask.<>f__mg$cache36 == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleLevelInfoUITask.<>f__mg$cache36 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleLevelInfoUITask.get_m_layerDescArray);
		}
		LuaCSFunction get4 = Lua_BlackJack_ProjectL_UI_BattleLevelInfoUITask.<>f__mg$cache36;
		if (Lua_BlackJack_ProjectL_UI_BattleLevelInfoUITask.<>f__mg$cache37 == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleLevelInfoUITask.<>f__mg$cache37 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleLevelInfoUITask.set_m_layerDescArray);
		}
		LuaObject.addMember(l, name4, get4, Lua_BlackJack_ProjectL_UI_BattleLevelInfoUITask.<>f__mg$cache37, true);
		string name5 = "m_uiCtrlDescArray";
		if (Lua_BlackJack_ProjectL_UI_BattleLevelInfoUITask.<>f__mg$cache38 == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleLevelInfoUITask.<>f__mg$cache38 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleLevelInfoUITask.get_m_uiCtrlDescArray);
		}
		LuaCSFunction get5 = Lua_BlackJack_ProjectL_UI_BattleLevelInfoUITask.<>f__mg$cache38;
		if (Lua_BlackJack_ProjectL_UI_BattleLevelInfoUITask.<>f__mg$cache39 == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleLevelInfoUITask.<>f__mg$cache39 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleLevelInfoUITask.set_m_uiCtrlDescArray);
		}
		LuaObject.addMember(l, name5, get5, Lua_BlackJack_ProjectL_UI_BattleLevelInfoUITask.<>f__mg$cache39, true);
		string name6 = "m_battleLevelInfoUIController";
		if (Lua_BlackJack_ProjectL_UI_BattleLevelInfoUITask.<>f__mg$cache3A == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleLevelInfoUITask.<>f__mg$cache3A = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleLevelInfoUITask.get_m_battleLevelInfoUIController);
		}
		LuaCSFunction get6 = Lua_BlackJack_ProjectL_UI_BattleLevelInfoUITask.<>f__mg$cache3A;
		if (Lua_BlackJack_ProjectL_UI_BattleLevelInfoUITask.<>f__mg$cache3B == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleLevelInfoUITask.<>f__mg$cache3B = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleLevelInfoUITask.set_m_battleLevelInfoUIController);
		}
		LuaObject.addMember(l, name6, get6, Lua_BlackJack_ProjectL_UI_BattleLevelInfoUITask.<>f__mg$cache3B, true);
		string name7 = "m_raidLevelUITask";
		if (Lua_BlackJack_ProjectL_UI_BattleLevelInfoUITask.<>f__mg$cache3C == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleLevelInfoUITask.<>f__mg$cache3C = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleLevelInfoUITask.get_m_raidLevelUITask);
		}
		LuaCSFunction get7 = Lua_BlackJack_ProjectL_UI_BattleLevelInfoUITask.<>f__mg$cache3C;
		if (Lua_BlackJack_ProjectL_UI_BattleLevelInfoUITask.<>f__mg$cache3D == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleLevelInfoUITask.<>f__mg$cache3D = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleLevelInfoUITask.set_m_raidLevelUITask);
		}
		LuaObject.addMember(l, name7, get7, Lua_BlackJack_ProjectL_UI_BattleLevelInfoUITask.<>f__mg$cache3D, true);
		string name8 = "m_riftLevelInfo";
		if (Lua_BlackJack_ProjectL_UI_BattleLevelInfoUITask.<>f__mg$cache3E == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleLevelInfoUITask.<>f__mg$cache3E = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleLevelInfoUITask.get_m_riftLevelInfo);
		}
		LuaCSFunction get8 = Lua_BlackJack_ProjectL_UI_BattleLevelInfoUITask.<>f__mg$cache3E;
		if (Lua_BlackJack_ProjectL_UI_BattleLevelInfoUITask.<>f__mg$cache3F == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleLevelInfoUITask.<>f__mg$cache3F = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleLevelInfoUITask.set_m_riftLevelInfo);
		}
		LuaObject.addMember(l, name8, get8, Lua_BlackJack_ProjectL_UI_BattleLevelInfoUITask.<>f__mg$cache3F, true);
		string name9 = "m_heroDungeonLevelInfo";
		if (Lua_BlackJack_ProjectL_UI_BattleLevelInfoUITask.<>f__mg$cache40 == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleLevelInfoUITask.<>f__mg$cache40 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleLevelInfoUITask.get_m_heroDungeonLevelInfo);
		}
		LuaCSFunction get9 = Lua_BlackJack_ProjectL_UI_BattleLevelInfoUITask.<>f__mg$cache40;
		if (Lua_BlackJack_ProjectL_UI_BattleLevelInfoUITask.<>f__mg$cache41 == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleLevelInfoUITask.<>f__mg$cache41 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleLevelInfoUITask.set_m_heroDungeonLevelInfo);
		}
		LuaObject.addMember(l, name9, get9, Lua_BlackJack_ProjectL_UI_BattleLevelInfoUITask.<>f__mg$cache41, true);
		string name10 = "m_battleType";
		if (Lua_BlackJack_ProjectL_UI_BattleLevelInfoUITask.<>f__mg$cache42 == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleLevelInfoUITask.<>f__mg$cache42 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleLevelInfoUITask.get_m_battleType);
		}
		LuaCSFunction get10 = Lua_BlackJack_ProjectL_UI_BattleLevelInfoUITask.<>f__mg$cache42;
		if (Lua_BlackJack_ProjectL_UI_BattleLevelInfoUITask.<>f__mg$cache43 == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleLevelInfoUITask.<>f__mg$cache43 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleLevelInfoUITask.set_m_battleType);
		}
		LuaObject.addMember(l, name10, get10, Lua_BlackJack_ProjectL_UI_BattleLevelInfoUITask.<>f__mg$cache43, true);
		string name11 = "m_needGoods";
		if (Lua_BlackJack_ProjectL_UI_BattleLevelInfoUITask.<>f__mg$cache44 == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleLevelInfoUITask.<>f__mg$cache44 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleLevelInfoUITask.get_m_needGoods);
		}
		LuaCSFunction get11 = Lua_BlackJack_ProjectL_UI_BattleLevelInfoUITask.<>f__mg$cache44;
		if (Lua_BlackJack_ProjectL_UI_BattleLevelInfoUITask.<>f__mg$cache45 == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleLevelInfoUITask.<>f__mg$cache45 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleLevelInfoUITask.set_m_needGoods);
		}
		LuaObject.addMember(l, name11, get11, Lua_BlackJack_ProjectL_UI_BattleLevelInfoUITask.<>f__mg$cache45, true);
		string name12 = "m_needOpenTween";
		if (Lua_BlackJack_ProjectL_UI_BattleLevelInfoUITask.<>f__mg$cache46 == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleLevelInfoUITask.<>f__mg$cache46 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleLevelInfoUITask.get_m_needOpenTween);
		}
		LuaCSFunction get12 = Lua_BlackJack_ProjectL_UI_BattleLevelInfoUITask.<>f__mg$cache46;
		if (Lua_BlackJack_ProjectL_UI_BattleLevelInfoUITask.<>f__mg$cache47 == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleLevelInfoUITask.<>f__mg$cache47 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleLevelInfoUITask.set_m_needOpenTween);
		}
		LuaObject.addMember(l, name12, get12, Lua_BlackJack_ProjectL_UI_BattleLevelInfoUITask.<>f__mg$cache47, true);
		string name13 = "LayerDescArray";
		if (Lua_BlackJack_ProjectL_UI_BattleLevelInfoUITask.<>f__mg$cache48 == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleLevelInfoUITask.<>f__mg$cache48 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleLevelInfoUITask.get_LayerDescArray);
		}
		LuaObject.addMember(l, name13, Lua_BlackJack_ProjectL_UI_BattleLevelInfoUITask.<>f__mg$cache48, null, true);
		string name14 = "UICtrlDescArray";
		if (Lua_BlackJack_ProjectL_UI_BattleLevelInfoUITask.<>f__mg$cache49 == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleLevelInfoUITask.<>f__mg$cache49 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleLevelInfoUITask.get_UICtrlDescArray);
		}
		LuaObject.addMember(l, name14, Lua_BlackJack_ProjectL_UI_BattleLevelInfoUITask.<>f__mg$cache49, null, true);
		if (Lua_BlackJack_ProjectL_UI_BattleLevelInfoUITask.<>f__mg$cache4A == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleLevelInfoUITask.<>f__mg$cache4A = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleLevelInfoUITask.constructor);
		}
		LuaObject.createTypeMetatable(l, Lua_BlackJack_ProjectL_UI_BattleLevelInfoUITask.<>f__mg$cache4A, typeof(BattleLevelInfoUITask), typeof(UITask));
	}

	// Token: 0x04011B9F RID: 72607
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache0;

	// Token: 0x04011BA0 RID: 72608
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1;

	// Token: 0x04011BA1 RID: 72609
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2;

	// Token: 0x04011BA2 RID: 72610
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3;

	// Token: 0x04011BA3 RID: 72611
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache4;

	// Token: 0x04011BA4 RID: 72612
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache5;

	// Token: 0x04011BA5 RID: 72613
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache6;

	// Token: 0x04011BA6 RID: 72614
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache7;

	// Token: 0x04011BA7 RID: 72615
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache8;

	// Token: 0x04011BA8 RID: 72616
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache9;

	// Token: 0x04011BA9 RID: 72617
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheA;

	// Token: 0x04011BAA RID: 72618
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheB;

	// Token: 0x04011BAB RID: 72619
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheC;

	// Token: 0x04011BAC RID: 72620
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheD;

	// Token: 0x04011BAD RID: 72621
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheE;

	// Token: 0x04011BAE RID: 72622
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheF;

	// Token: 0x04011BAF RID: 72623
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache10;

	// Token: 0x04011BB0 RID: 72624
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache11;

	// Token: 0x04011BB1 RID: 72625
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache12;

	// Token: 0x04011BB2 RID: 72626
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache13;

	// Token: 0x04011BB3 RID: 72627
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache14;

	// Token: 0x04011BB4 RID: 72628
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache15;

	// Token: 0x04011BB5 RID: 72629
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache16;

	// Token: 0x04011BB6 RID: 72630
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache17;

	// Token: 0x04011BB7 RID: 72631
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache18;

	// Token: 0x04011BB8 RID: 72632
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache19;

	// Token: 0x04011BB9 RID: 72633
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1A;

	// Token: 0x04011BBA RID: 72634
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1B;

	// Token: 0x04011BBB RID: 72635
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1C;

	// Token: 0x04011BBC RID: 72636
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1D;

	// Token: 0x04011BBD RID: 72637
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1E;

	// Token: 0x04011BBE RID: 72638
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1F;

	// Token: 0x04011BBF RID: 72639
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache20;

	// Token: 0x04011BC0 RID: 72640
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache21;

	// Token: 0x04011BC1 RID: 72641
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache22;

	// Token: 0x04011BC2 RID: 72642
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache23;

	// Token: 0x04011BC3 RID: 72643
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache24;

	// Token: 0x04011BC4 RID: 72644
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache25;

	// Token: 0x04011BC5 RID: 72645
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache26;

	// Token: 0x04011BC6 RID: 72646
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache27;

	// Token: 0x04011BC7 RID: 72647
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache28;

	// Token: 0x04011BC8 RID: 72648
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache29;

	// Token: 0x04011BC9 RID: 72649
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2A;

	// Token: 0x04011BCA RID: 72650
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2B;

	// Token: 0x04011BCB RID: 72651
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2C;

	// Token: 0x04011BCC RID: 72652
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2D;

	// Token: 0x04011BCD RID: 72653
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2E;

	// Token: 0x04011BCE RID: 72654
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2F;

	// Token: 0x04011BCF RID: 72655
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache30;

	// Token: 0x04011BD0 RID: 72656
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache31;

	// Token: 0x04011BD1 RID: 72657
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache32;

	// Token: 0x04011BD2 RID: 72658
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache33;

	// Token: 0x04011BD3 RID: 72659
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache34;

	// Token: 0x04011BD4 RID: 72660
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache35;

	// Token: 0x04011BD5 RID: 72661
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache36;

	// Token: 0x04011BD6 RID: 72662
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache37;

	// Token: 0x04011BD7 RID: 72663
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache38;

	// Token: 0x04011BD8 RID: 72664
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache39;

	// Token: 0x04011BD9 RID: 72665
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3A;

	// Token: 0x04011BDA RID: 72666
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3B;

	// Token: 0x04011BDB RID: 72667
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3C;

	// Token: 0x04011BDC RID: 72668
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3D;

	// Token: 0x04011BDD RID: 72669
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3E;

	// Token: 0x04011BDE RID: 72670
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3F;

	// Token: 0x04011BDF RID: 72671
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache40;

	// Token: 0x04011BE0 RID: 72672
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache41;

	// Token: 0x04011BE1 RID: 72673
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache42;

	// Token: 0x04011BE2 RID: 72674
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache43;

	// Token: 0x04011BE3 RID: 72675
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache44;

	// Token: 0x04011BE4 RID: 72676
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache45;

	// Token: 0x04011BE5 RID: 72677
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache46;

	// Token: 0x04011BE6 RID: 72678
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache47;

	// Token: 0x04011BE7 RID: 72679
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache48;

	// Token: 0x04011BE8 RID: 72680
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache49;

	// Token: 0x04011BE9 RID: 72681
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache4A;
}
