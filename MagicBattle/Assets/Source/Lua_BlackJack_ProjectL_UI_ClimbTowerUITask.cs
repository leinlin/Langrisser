using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using BlackJack.BJFramework.Runtime.UI;
using BlackJack.ProjectL.Common;
using BlackJack.ProjectL.PlayerContext;
using BlackJack.ProjectL.UI;
using SLua;
using UnityEngine.Scripting;

// Token: 0x020013FE RID: 5118
[Preserve]
public class Lua_BlackJack_ProjectL_UI_ClimbTowerUITask : LuaObject
{
	// Token: 0x0601CCAE RID: 117934 RVA: 0x008FE65C File Offset: 0x008FC85C
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int constructor(IntPtr l)
	{
		int result;
		try
		{
			string name;
			LuaObject.checkType(l, 2, out name);
			ClimbTowerUITask o = new ClimbTowerUITask(name);
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

	// Token: 0x0601CCAF RID: 117935 RVA: 0x008FE6B0 File Offset: 0x008FC8B0
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int OnStart(IntPtr l)
	{
		int result;
		try
		{
			ClimbTowerUITask climbTowerUITask = (ClimbTowerUITask)LuaObject.checkSelf(l);
			UIIntent intent;
			LuaObject.checkType<UIIntent>(l, 2, out intent);
			bool b = climbTowerUITask.m_luaExportHelper.OnStart(intent);
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

	// Token: 0x0601CCB0 RID: 117936 RVA: 0x008FE718 File Offset: 0x008FC918
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int OnResume(IntPtr l)
	{
		int result;
		try
		{
			ClimbTowerUITask climbTowerUITask = (ClimbTowerUITask)LuaObject.checkSelf(l);
			UIIntent intent;
			LuaObject.checkType<UIIntent>(l, 2, out intent);
			bool b = climbTowerUITask.m_luaExportHelper.OnResume(intent);
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

	// Token: 0x0601CCB1 RID: 117937 RVA: 0x008FE780 File Offset: 0x008FC980
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int InitDataFromUIIntent(IntPtr l)
	{
		int result;
		try
		{
			ClimbTowerUITask climbTowerUITask = (ClimbTowerUITask)LuaObject.checkSelf(l);
			UIIntent intent;
			LuaObject.checkType<UIIntent>(l, 2, out intent);
			climbTowerUITask.m_luaExportHelper.InitDataFromUIIntent(intent);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601CCB2 RID: 117938 RVA: 0x008FE7DC File Offset: 0x008FC9DC
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int IsNeedLoadDynamicRes(IntPtr l)
	{
		int result;
		try
		{
			ClimbTowerUITask climbTowerUITask = (ClimbTowerUITask)LuaObject.checkSelf(l);
			bool b = climbTowerUITask.m_luaExportHelper.IsNeedLoadDynamicRes();
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

	// Token: 0x0601CCB3 RID: 117939 RVA: 0x008FE838 File Offset: 0x008FCA38
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int CollectFloorAssets(IntPtr l)
	{
		int result;
		try
		{
			ClimbTowerUITask climbTowerUITask = (ClimbTowerUITask)LuaObject.checkSelf(l);
			int fromFloorId;
			LuaObject.checkType(l, 2, out fromFloorId);
			climbTowerUITask.m_luaExportHelper.CollectFloorAssets(fromFloorId);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601CCB4 RID: 117940 RVA: 0x008FE894 File Offset: 0x008FCA94
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int InitLayerStateOnLoadAllResCompleted(IntPtr l)
	{
		int result;
		try
		{
			ClimbTowerUITask climbTowerUITask = (ClimbTowerUITask)LuaObject.checkSelf(l);
			climbTowerUITask.m_luaExportHelper.InitLayerStateOnLoadAllResCompleted();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601CCB5 RID: 117941 RVA: 0x008FE8E8 File Offset: 0x008FCAE8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int InitAllUIControllers(IntPtr l)
	{
		int result;
		try
		{
			ClimbTowerUITask climbTowerUITask = (ClimbTowerUITask)LuaObject.checkSelf(l);
			climbTowerUITask.m_luaExportHelper.InitAllUIControllers();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601CCB6 RID: 117942 RVA: 0x008FE93C File Offset: 0x008FCB3C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int ClearAllContextAndRes(IntPtr l)
	{
		int result;
		try
		{
			ClimbTowerUITask climbTowerUITask = (ClimbTowerUITask)LuaObject.checkSelf(l);
			climbTowerUITask.m_luaExportHelper.ClearAllContextAndRes();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601CCB7 RID: 117943 RVA: 0x008FE990 File Offset: 0x008FCB90
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int InitClimbTowerUIController(IntPtr l)
	{
		int result;
		try
		{
			ClimbTowerUITask climbTowerUITask = (ClimbTowerUITask)LuaObject.checkSelf(l);
			climbTowerUITask.m_luaExportHelper.InitClimbTowerUIController();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601CCB8 RID: 117944 RVA: 0x008FE9E4 File Offset: 0x008FCBE4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int UninitClimbTowerUIController(IntPtr l)
	{
		int result;
		try
		{
			ClimbTowerUITask climbTowerUITask = (ClimbTowerUITask)LuaObject.checkSelf(l);
			climbTowerUITask.m_luaExportHelper.UninitClimbTowerUIController();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601CCB9 RID: 117945 RVA: 0x008FEA38 File Offset: 0x008FCC38
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int OnTick(IntPtr l)
	{
		int result;
		try
		{
			ClimbTowerUITask climbTowerUITask = (ClimbTowerUITask)LuaObject.checkSelf(l);
			climbTowerUITask.m_luaExportHelper.OnTick();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601CCBA RID: 117946 RVA: 0x008FEA8C File Offset: 0x008FCC8C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int UpdateView(IntPtr l)
	{
		int result;
		try
		{
			ClimbTowerUITask climbTowerUITask = (ClimbTowerUITask)LuaObject.checkSelf(l);
			climbTowerUITask.m_luaExportHelper.UpdateView();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601CCBB RID: 117947 RVA: 0x008FEAE0 File Offset: 0x008FCCE0
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int UpdateFloors(IntPtr l)
	{
		int result;
		try
		{
			ClimbTowerUITask climbTowerUITask = (ClimbTowerUITask)LuaObject.checkSelf(l);
			int fromFloorId;
			LuaObject.checkType(l, 2, out fromFloorId);
			int finishedFloorId;
			LuaObject.checkType(l, 3, out finishedFloorId);
			climbTowerUITask.m_luaExportHelper.UpdateFloors(fromFloorId, finishedFloorId);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601CCBC RID: 117948 RVA: 0x008FEB4C File Offset: 0x008FCD4C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int UpdateClimbTowerFlushTime(IntPtr l)
	{
		int result;
		try
		{
			ClimbTowerUITask climbTowerUITask = (ClimbTowerUITask)LuaObject.checkSelf(l);
			climbTowerUITask.m_luaExportHelper.UpdateClimbTowerFlushTime();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601CCBD RID: 117949 RVA: 0x008FEBA0 File Offset: 0x008FCDA0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int StartClimbTowerLevelInfoUITask(IntPtr l)
	{
		int result;
		try
		{
			ClimbTowerUITask climbTowerUITask = (ClimbTowerUITask)LuaObject.checkSelf(l);
			climbTowerUITask.m_luaExportHelper.StartClimbTowerLevelInfoUITask();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601CCBE RID: 117950 RVA: 0x008FEBF4 File Offset: 0x008FCDF4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int StartClimbTowerRaidUITask(IntPtr l)
	{
		int result;
		try
		{
			ClimbTowerUITask climbTowerUITask = (ClimbTowerUITask)LuaObject.checkSelf(l);
			BattleReward battleReward;
			LuaObject.checkType<BattleReward>(l, 2, out battleReward);
			climbTowerUITask.m_luaExportHelper.StartClimbTowerRaidUITask(battleReward);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601CCBF RID: 117951 RVA: 0x008FEC50 File Offset: 0x008FCE50
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int ClimbTowerUIController_OnReturn(IntPtr l)
	{
		int result;
		try
		{
			ClimbTowerUITask climbTowerUITask = (ClimbTowerUITask)LuaObject.checkSelf(l);
			climbTowerUITask.m_luaExportHelper.ClimbTowerUIController_OnReturn();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601CCC0 RID: 117952 RVA: 0x008FECA4 File Offset: 0x008FCEA4
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int ClimbTowerUIController_OnShowHelp(IntPtr l)
	{
		int result;
		try
		{
			ClimbTowerUITask climbTowerUITask = (ClimbTowerUITask)LuaObject.checkSelf(l);
			climbTowerUITask.m_luaExportHelper.ClimbTowerUIController_OnShowHelp();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601CCC1 RID: 117953 RVA: 0x008FECF8 File Offset: 0x008FCEF8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int ClimbTowerUIController_OnShowLevelInfo(IntPtr l)
	{
		int result;
		try
		{
			ClimbTowerUITask climbTowerUITask = (ClimbTowerUITask)LuaObject.checkSelf(l);
			climbTowerUITask.m_luaExportHelper.ClimbTowerUIController_OnShowLevelInfo();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601CCC2 RID: 117954 RVA: 0x008FED4C File Offset: 0x008FCF4C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int ClimbTowerUIController_OnShowRaid(IntPtr l)
	{
		int result;
		try
		{
			ClimbTowerUITask climbTowerUITask = (ClimbTowerUITask)LuaObject.checkSelf(l);
			climbTowerUITask.m_luaExportHelper.ClimbTowerUIController_OnShowRaid();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601CCC3 RID: 117955 RVA: 0x008FEDA0 File Offset: 0x008FCFA0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int ClimbTowerUIController_OnConfirmRaid(IntPtr l)
	{
		int result;
		try
		{
			ClimbTowerUITask climbTowerUITask = (ClimbTowerUITask)LuaObject.checkSelf(l);
			climbTowerUITask.m_luaExportHelper.ClimbTowerUIController_OnConfirmRaid();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601CCC4 RID: 117956 RVA: 0x008FEDF4 File Offset: 0x008FCFF4
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int FlushClimbTower(IntPtr l)
	{
		int result;
		try
		{
			ClimbTowerUITask climbTowerUITask = (ClimbTowerUITask)LuaObject.checkSelf(l);
			climbTowerUITask.m_luaExportHelper.FlushClimbTower();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601CCC5 RID: 117957 RVA: 0x008FEE48 File Offset: 0x008FD048
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int PlayerResourceUIController_OnAddGold(IntPtr l)
	{
		int result;
		try
		{
			ClimbTowerUITask climbTowerUITask = (ClimbTowerUITask)LuaObject.checkSelf(l);
			climbTowerUITask.m_luaExportHelper.PlayerResourceUIController_OnAddGold();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601CCC6 RID: 117958 RVA: 0x008FEE9C File Offset: 0x008FD09C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int PlayerResourceUIController_OnAddCrystal(IntPtr l)
	{
		int result;
		try
		{
			ClimbTowerUITask climbTowerUITask = (ClimbTowerUITask)LuaObject.checkSelf(l);
			climbTowerUITask.m_luaExportHelper.PlayerResourceUIController_OnAddCrystal();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601CCC7 RID: 117959 RVA: 0x008FEEF0 File Offset: 0x008FD0F0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int ClimbTowerLevelInfoUITask_OnClose(IntPtr l)
	{
		int result;
		try
		{
			ClimbTowerUITask climbTowerUITask = (ClimbTowerUITask)LuaObject.checkSelf(l);
			climbTowerUITask.m_luaExportHelper.ClimbTowerLevelInfoUITask_OnClose();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601CCC8 RID: 117960 RVA: 0x008FEF44 File Offset: 0x008FD144
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int ClimbTowerRaidUITask_OnClose(IntPtr l)
	{
		int result;
		try
		{
			ClimbTowerUITask climbTowerUITask = (ClimbTowerUITask)LuaObject.checkSelf(l);
			climbTowerUITask.m_luaExportHelper.ClimbTowerRaidUITask_OnClose();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601CCC9 RID: 117961 RVA: 0x008FEF98 File Offset: 0x008FD198
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_OnStart(IntPtr l)
	{
		int result;
		try
		{
			ClimbTowerUITask climbTowerUITask = (ClimbTowerUITask)LuaObject.checkSelf(l);
			UIIntent intent;
			LuaObject.checkType<UIIntent>(l, 2, out intent);
			bool b = climbTowerUITask.m_luaExportHelper.__callBase_OnStart(intent);
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

	// Token: 0x0601CCCA RID: 117962 RVA: 0x008FF000 File Offset: 0x008FD200
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_OnStop(IntPtr l)
	{
		int result;
		try
		{
			ClimbTowerUITask climbTowerUITask = (ClimbTowerUITask)LuaObject.checkSelf(l);
			climbTowerUITask.m_luaExportHelper.__callBase_OnStop();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601CCCB RID: 117963 RVA: 0x008FF054 File Offset: 0x008FD254
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_OnPause(IntPtr l)
	{
		int result;
		try
		{
			ClimbTowerUITask climbTowerUITask = (ClimbTowerUITask)LuaObject.checkSelf(l);
			climbTowerUITask.m_luaExportHelper.__callBase_OnPause();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601CCCC RID: 117964 RVA: 0x008FF0A8 File Offset: 0x008FD2A8
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int __callBase_OnResume(IntPtr l)
	{
		int result;
		try
		{
			ClimbTowerUITask climbTowerUITask = (ClimbTowerUITask)LuaObject.checkSelf(l);
			UIIntent intent;
			LuaObject.checkType<UIIntent>(l, 2, out intent);
			bool b = climbTowerUITask.m_luaExportHelper.__callBase_OnResume(intent);
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

	// Token: 0x0601CCCD RID: 117965 RVA: 0x008FF110 File Offset: 0x008FD310
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int __callBase_OnNewIntent(IntPtr l)
	{
		int result;
		try
		{
			ClimbTowerUITask climbTowerUITask = (ClimbTowerUITask)LuaObject.checkSelf(l);
			UIIntent intent;
			LuaObject.checkType<UIIntent>(l, 2, out intent);
			bool b = climbTowerUITask.m_luaExportHelper.__callBase_OnNewIntent(intent);
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

	// Token: 0x0601CCCE RID: 117966 RVA: 0x008FF178 File Offset: 0x008FD378
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_EnableUIInput(IntPtr l)
	{
		int result;
		try
		{
			ClimbTowerUITask climbTowerUITask = (ClimbTowerUITask)LuaObject.checkSelf(l);
			bool isEnable;
			LuaObject.checkType(l, 2, out isEnable);
			bool? isGlobalEnable;
			LuaObject.checkNullable<bool>(l, 3, out isGlobalEnable);
			climbTowerUITask.m_luaExportHelper.__callBase_EnableUIInput(isEnable, isGlobalEnable);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601CCCF RID: 117967 RVA: 0x008FF1E4 File Offset: 0x008FD3E4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_IsNeedLoadDynamicRes(IntPtr l)
	{
		int result;
		try
		{
			ClimbTowerUITask climbTowerUITask = (ClimbTowerUITask)LuaObject.checkSelf(l);
			bool b = climbTowerUITask.m_luaExportHelper.__callBase_IsNeedLoadDynamicRes();
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

	// Token: 0x0601CCD0 RID: 117968 RVA: 0x008FF240 File Offset: 0x008FD440
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_CollectAllDynamicResForLoad(IntPtr l)
	{
		int result;
		try
		{
			ClimbTowerUITask climbTowerUITask = (ClimbTowerUITask)LuaObject.checkSelf(l);
			List<string> o = climbTowerUITask.m_luaExportHelper.__callBase_CollectAllDynamicResForLoad();
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

	// Token: 0x0601CCD1 RID: 117969 RVA: 0x008FF29C File Offset: 0x008FD49C
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int __callBase_RegisterPlayerContextEvents(IntPtr l)
	{
		int result;
		try
		{
			ClimbTowerUITask climbTowerUITask = (ClimbTowerUITask)LuaObject.checkSelf(l);
			climbTowerUITask.m_luaExportHelper.__callBase_RegisterPlayerContextEvents();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601CCD2 RID: 117970 RVA: 0x008FF2F0 File Offset: 0x008FD4F0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_UnregisterPlayerContextEvents(IntPtr l)
	{
		int result;
		try
		{
			ClimbTowerUITask climbTowerUITask = (ClimbTowerUITask)LuaObject.checkSelf(l);
			climbTowerUITask.m_luaExportHelper.__callBase_UnregisterPlayerContextEvents();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601CCD3 RID: 117971 RVA: 0x008FF344 File Offset: 0x008FD544
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_PostUpdateView(IntPtr l)
	{
		int result;
		try
		{
			ClimbTowerUITask climbTowerUITask = (ClimbTowerUITask)LuaObject.checkSelf(l);
			climbTowerUITask.m_luaExportHelper.__callBase_PostUpdateView();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601CCD4 RID: 117972 RVA: 0x008FF398 File Offset: 0x008FD598
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_CollectPreloadResourceList(IntPtr l)
	{
		int result;
		try
		{
			ClimbTowerUITask climbTowerUITask = (ClimbTowerUITask)LuaObject.checkSelf(l);
			climbTowerUITask.m_luaExportHelper.__callBase_CollectPreloadResourceList();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601CCD5 RID: 117973 RVA: 0x008FF3EC File Offset: 0x008FD5EC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_ClearAssetList(IntPtr l)
	{
		int result;
		try
		{
			ClimbTowerUITask climbTowerUITask = (ClimbTowerUITask)LuaObject.checkSelf(l);
			climbTowerUITask.m_luaExportHelper.__callBase_ClearAssetList();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601CCD6 RID: 117974 RVA: 0x008FF440 File Offset: 0x008FD640
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_CollectAsset(IntPtr l)
	{
		int result;
		try
		{
			ClimbTowerUITask climbTowerUITask = (ClimbTowerUITask)LuaObject.checkSelf(l);
			string assetName;
			LuaObject.checkType(l, 2, out assetName);
			climbTowerUITask.m_luaExportHelper.__callBase_CollectAsset(assetName);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601CCD7 RID: 117975 RVA: 0x008FF49C File Offset: 0x008FD69C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_CollectSpriteAsset(IntPtr l)
	{
		int result;
		try
		{
			ClimbTowerUITask climbTowerUITask = (ClimbTowerUITask)LuaObject.checkSelf(l);
			string assetName;
			LuaObject.checkType(l, 2, out assetName);
			climbTowerUITask.m_luaExportHelper.__callBase_CollectSpriteAsset(assetName);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601CCD8 RID: 117976 RVA: 0x008FF4F8 File Offset: 0x008FD6F8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_CollectFxAsset(IntPtr l)
	{
		int result;
		try
		{
			ClimbTowerUITask climbTowerUITask = (ClimbTowerUITask)LuaObject.checkSelf(l);
			string assetName;
			LuaObject.checkType(l, 2, out assetName);
			climbTowerUITask.m_luaExportHelper.__callBase_CollectFxAsset(assetName);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601CCD9 RID: 117977 RVA: 0x008FF554 File Offset: 0x008FD754
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_StartLoadCustomAssets(IntPtr l)
	{
		int result;
		try
		{
			ClimbTowerUITask climbTowerUITask = (ClimbTowerUITask)LuaObject.checkSelf(l);
			Action onLoadCompleted;
			LuaObject.checkDelegate<Action>(l, 2, out onLoadCompleted);
			climbTowerUITask.m_luaExportHelper.__callBase_StartLoadCustomAssets(onLoadCompleted);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601CCDA RID: 117978 RVA: 0x008FF5B0 File Offset: 0x008FD7B0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_IsLoadingCustomAssets(IntPtr l)
	{
		int result;
		try
		{
			ClimbTowerUITask climbTowerUITask = (ClimbTowerUITask)LuaObject.checkSelf(l);
			bool b = climbTowerUITask.m_luaExportHelper.__callBase_IsLoadingCustomAssets();
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

	// Token: 0x0601CCDB RID: 117979 RVA: 0x008FF60C File Offset: 0x008FD80C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_IsPipeLineRunning(IntPtr l)
	{
		int result;
		try
		{
			ClimbTowerUITask climbTowerUITask = (ClimbTowerUITask)LuaObject.checkSelf(l);
			bool b = climbTowerUITask.m_luaExportHelper.__callBase_IsPipeLineRunning();
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

	// Token: 0x0601CCDC RID: 117980 RVA: 0x008FF668 File Offset: 0x008FD868
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_IsOpeningUI(IntPtr l)
	{
		int result;
		try
		{
			ClimbTowerUITask climbTowerUITask = (ClimbTowerUITask)LuaObject.checkSelf(l);
			bool b = climbTowerUITask.m_luaExportHelper.__callBase_IsOpeningUI();
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

	// Token: 0x0601CCDD RID: 117981 RVA: 0x008FF6C4 File Offset: 0x008FD8C4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_ReturnPrevUITask(IntPtr l)
	{
		int result;
		try
		{
			ClimbTowerUITask climbTowerUITask = (ClimbTowerUITask)LuaObject.checkSelf(l);
			UITaskBase o = climbTowerUITask.m_luaExportHelper.__callBase_ReturnPrevUITask();
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

	// Token: 0x0601CCDE RID: 117982 RVA: 0x008FF720 File Offset: 0x008FD920
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_ClearUnusedDynamicResourceCache(IntPtr l)
	{
		int result;
		try
		{
			ClimbTowerUITask climbTowerUITask = (ClimbTowerUITask)LuaObject.checkSelf(l);
			climbTowerUITask.m_luaExportHelper.__callBase_ClearUnusedDynamicResourceCache();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601CCDF RID: 117983 RVA: 0x008FF774 File Offset: 0x008FD974
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_OnMemoryWarning(IntPtr l)
	{
		int result;
		try
		{
			ClimbTowerUITask climbTowerUITask = (ClimbTowerUITask)LuaObject.checkSelf(l);
			climbTowerUITask.m_luaExportHelper.__callBase_OnMemoryWarning();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601CCE0 RID: 117984 RVA: 0x008FF7C8 File Offset: 0x008FD9C8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int ComputeBigFloorFromFloorId_s(IntPtr l)
	{
		int result;
		try
		{
			int finishedFloorId;
			LuaObject.checkType(l, 1, out finishedFloorId);
			int i = ClimbTowerUITask.LuaExportHelper.ComputeBigFloorFromFloorId(finishedFloorId);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, i);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601CCE1 RID: 117985 RVA: 0x008FF81C File Offset: 0x008FDA1C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_layerDescArray(IntPtr l)
	{
		int result;
		try
		{
			ClimbTowerUITask climbTowerUITask = (ClimbTowerUITask)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, climbTowerUITask.m_luaExportHelper.m_layerDescArray);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601CCE2 RID: 117986 RVA: 0x008FF874 File Offset: 0x008FDA74
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_layerDescArray(IntPtr l)
	{
		int result;
		try
		{
			ClimbTowerUITask climbTowerUITask = (ClimbTowerUITask)LuaObject.checkSelf(l);
			UITaskBase.LayerDesc[] layerDescArray;
			LuaObject.checkArray<UITaskBase.LayerDesc>(l, 2, out layerDescArray);
			climbTowerUITask.m_luaExportHelper.m_layerDescArray = layerDescArray;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601CCE3 RID: 117987 RVA: 0x008FF8D0 File Offset: 0x008FDAD0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_uiCtrlDescArray(IntPtr l)
	{
		int result;
		try
		{
			ClimbTowerUITask climbTowerUITask = (ClimbTowerUITask)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, climbTowerUITask.m_luaExportHelper.m_uiCtrlDescArray);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601CCE4 RID: 117988 RVA: 0x008FF928 File Offset: 0x008FDB28
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_uiCtrlDescArray(IntPtr l)
	{
		int result;
		try
		{
			ClimbTowerUITask climbTowerUITask = (ClimbTowerUITask)LuaObject.checkSelf(l);
			UITaskBase.UIControllerDesc[] uiCtrlDescArray;
			LuaObject.checkArray<UITaskBase.UIControllerDesc>(l, 2, out uiCtrlDescArray);
			climbTowerUITask.m_luaExportHelper.m_uiCtrlDescArray = uiCtrlDescArray;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601CCE5 RID: 117989 RVA: 0x008FF984 File Offset: 0x008FDB84
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_climbTowerUIController(IntPtr l)
	{
		int result;
		try
		{
			ClimbTowerUITask climbTowerUITask = (ClimbTowerUITask)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, climbTowerUITask.m_luaExportHelper.m_climbTowerUIController);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601CCE6 RID: 117990 RVA: 0x008FF9DC File Offset: 0x008FDBDC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_climbTowerUIController(IntPtr l)
	{
		int result;
		try
		{
			ClimbTowerUITask climbTowerUITask = (ClimbTowerUITask)LuaObject.checkSelf(l);
			ClimbTowerUIController climbTowerUIController;
			LuaObject.checkType<ClimbTowerUIController>(l, 2, out climbTowerUIController);
			climbTowerUITask.m_luaExportHelper.m_climbTowerUIController = climbTowerUIController;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601CCE7 RID: 117991 RVA: 0x008FFA38 File Offset: 0x008FDC38
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_playerResourceUIController(IntPtr l)
	{
		int result;
		try
		{
			ClimbTowerUITask climbTowerUITask = (ClimbTowerUITask)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, climbTowerUITask.m_luaExportHelper.m_playerResourceUIController);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601CCE8 RID: 117992 RVA: 0x008FFA90 File Offset: 0x008FDC90
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_playerResourceUIController(IntPtr l)
	{
		int result;
		try
		{
			ClimbTowerUITask climbTowerUITask = (ClimbTowerUITask)LuaObject.checkSelf(l);
			PlayerResourceUIController playerResourceUIController;
			LuaObject.checkType<PlayerResourceUIController>(l, 2, out playerResourceUIController);
			climbTowerUITask.m_luaExportHelper.m_playerResourceUIController = playerResourceUIController;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601CCE9 RID: 117993 RVA: 0x008FFAEC File Offset: 0x008FDCEC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_nowSeconds(IntPtr l)
	{
		int result;
		try
		{
			ClimbTowerUITask climbTowerUITask = (ClimbTowerUITask)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, climbTowerUITask.m_luaExportHelper.m_nowSeconds);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601CCEA RID: 117994 RVA: 0x008FFB44 File Offset: 0x008FDD44
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_nowSeconds(IntPtr l)
	{
		int result;
		try
		{
			ClimbTowerUITask climbTowerUITask = (ClimbTowerUITask)LuaObject.checkSelf(l);
			int nowSeconds;
			LuaObject.checkType(l, 2, out nowSeconds);
			climbTowerUITask.m_luaExportHelper.m_nowSeconds = nowSeconds;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601CCEB RID: 117995 RVA: 0x008FFBA0 File Offset: 0x008FDDA0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_climbTowerLevelInfoUITask(IntPtr l)
	{
		int result;
		try
		{
			ClimbTowerUITask climbTowerUITask = (ClimbTowerUITask)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, climbTowerUITask.m_luaExportHelper.m_climbTowerLevelInfoUITask);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601CCEC RID: 117996 RVA: 0x008FFBF8 File Offset: 0x008FDDF8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_climbTowerLevelInfoUITask(IntPtr l)
	{
		int result;
		try
		{
			ClimbTowerUITask climbTowerUITask = (ClimbTowerUITask)LuaObject.checkSelf(l);
			ClimbTowerLevelInfoUITask climbTowerLevelInfoUITask;
			LuaObject.checkType<ClimbTowerLevelInfoUITask>(l, 2, out climbTowerLevelInfoUITask);
			climbTowerUITask.m_luaExportHelper.m_climbTowerLevelInfoUITask = climbTowerLevelInfoUITask;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601CCED RID: 117997 RVA: 0x008FFC54 File Offset: 0x008FDE54
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_climbTowerRaidUITask(IntPtr l)
	{
		int result;
		try
		{
			ClimbTowerUITask climbTowerUITask = (ClimbTowerUITask)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, climbTowerUITask.m_luaExportHelper.m_climbTowerRaidUITask);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601CCEE RID: 117998 RVA: 0x008FFCAC File Offset: 0x008FDEAC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_climbTowerRaidUITask(IntPtr l)
	{
		int result;
		try
		{
			ClimbTowerUITask climbTowerUITask = (ClimbTowerUITask)LuaObject.checkSelf(l);
			ClimbTowerRaidUITask climbTowerRaidUITask;
			LuaObject.checkType<ClimbTowerRaidUITask>(l, 2, out climbTowerRaidUITask);
			climbTowerUITask.m_luaExportHelper.m_climbTowerRaidUITask = climbTowerRaidUITask;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601CCEF RID: 117999 RVA: 0x008FFD08 File Offset: 0x008FDF08
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_armyRandomNumber(IntPtr l)
	{
		int result;
		try
		{
			ClimbTowerUITask climbTowerUITask = (ClimbTowerUITask)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, climbTowerUITask.m_luaExportHelper.m_armyRandomNumber);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601CCF0 RID: 118000 RVA: 0x008FFD60 File Offset: 0x008FDF60
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_armyRandomNumber(IntPtr l)
	{
		int result;
		try
		{
			ClimbTowerUITask climbTowerUITask = (ClimbTowerUITask)LuaObject.checkSelf(l);
			RandomNumber armyRandomNumber;
			LuaObject.checkType<RandomNumber>(l, 2, out armyRandomNumber);
			climbTowerUITask.m_luaExportHelper.m_armyRandomNumber = armyRandomNumber;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601CCF1 RID: 118001 RVA: 0x008FFDBC File Offset: 0x008FDFBC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_nextCheckClimbTowerFlushTime(IntPtr l)
	{
		int result;
		try
		{
			ClimbTowerUITask climbTowerUITask = (ClimbTowerUITask)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, climbTowerUITask.m_luaExportHelper.m_nextCheckClimbTowerFlushTime);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601CCF2 RID: 118002 RVA: 0x008FFE18 File Offset: 0x008FE018
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_nextCheckClimbTowerFlushTime(IntPtr l)
	{
		int result;
		try
		{
			ClimbTowerUITask climbTowerUITask = (ClimbTowerUITask)LuaObject.checkSelf(l);
			DateTime nextCheckClimbTowerFlushTime;
			LuaObject.checkValueType<DateTime>(l, 2, out nextCheckClimbTowerFlushTime);
			climbTowerUITask.m_luaExportHelper.m_nextCheckClimbTowerFlushTime = nextCheckClimbTowerFlushTime;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601CCF3 RID: 118003 RVA: 0x008FFE74 File Offset: 0x008FE074
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_isRaidClear(IntPtr l)
	{
		int result;
		try
		{
			ClimbTowerUITask climbTowerUITask = (ClimbTowerUITask)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, climbTowerUITask.m_luaExportHelper.m_isRaidClear);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601CCF4 RID: 118004 RVA: 0x008FFECC File Offset: 0x008FE0CC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_isRaidClear(IntPtr l)
	{
		int result;
		try
		{
			ClimbTowerUITask climbTowerUITask = (ClimbTowerUITask)LuaObject.checkSelf(l);
			bool isRaidClear;
			LuaObject.checkType(l, 2, out isRaidClear);
			climbTowerUITask.m_luaExportHelper.m_isRaidClear = isRaidClear;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601CCF5 RID: 118005 RVA: 0x008FFF28 File Offset: 0x008FE128
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_LayerDescArray(IntPtr l)
	{
		int result;
		try
		{
			ClimbTowerUITask climbTowerUITask = (ClimbTowerUITask)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, climbTowerUITask.m_luaExportHelper.LayerDescArray);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601CCF6 RID: 118006 RVA: 0x008FFF80 File Offset: 0x008FE180
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_UICtrlDescArray(IntPtr l)
	{
		int result;
		try
		{
			ClimbTowerUITask climbTowerUITask = (ClimbTowerUITask)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, climbTowerUITask.m_luaExportHelper.UICtrlDescArray);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601CCF7 RID: 118007 RVA: 0x008FFFD8 File Offset: 0x008FE1D8
	[Preserve]
	public static void reg(IntPtr l)
	{
		LuaObject.getTypeTable(l, "BlackJack.ProjectL.UI.ClimbTowerUITask");
		if (Lua_BlackJack_ProjectL_UI_ClimbTowerUITask.<>f__mg$cache0 == null)
		{
			Lua_BlackJack_ProjectL_UI_ClimbTowerUITask.<>f__mg$cache0 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ClimbTowerUITask.OnStart);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_ClimbTowerUITask.<>f__mg$cache0);
		if (Lua_BlackJack_ProjectL_UI_ClimbTowerUITask.<>f__mg$cache1 == null)
		{
			Lua_BlackJack_ProjectL_UI_ClimbTowerUITask.<>f__mg$cache1 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ClimbTowerUITask.OnResume);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_ClimbTowerUITask.<>f__mg$cache1);
		if (Lua_BlackJack_ProjectL_UI_ClimbTowerUITask.<>f__mg$cache2 == null)
		{
			Lua_BlackJack_ProjectL_UI_ClimbTowerUITask.<>f__mg$cache2 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ClimbTowerUITask.InitDataFromUIIntent);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_ClimbTowerUITask.<>f__mg$cache2);
		if (Lua_BlackJack_ProjectL_UI_ClimbTowerUITask.<>f__mg$cache3 == null)
		{
			Lua_BlackJack_ProjectL_UI_ClimbTowerUITask.<>f__mg$cache3 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ClimbTowerUITask.IsNeedLoadDynamicRes);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_ClimbTowerUITask.<>f__mg$cache3);
		if (Lua_BlackJack_ProjectL_UI_ClimbTowerUITask.<>f__mg$cache4 == null)
		{
			Lua_BlackJack_ProjectL_UI_ClimbTowerUITask.<>f__mg$cache4 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ClimbTowerUITask.CollectFloorAssets);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_ClimbTowerUITask.<>f__mg$cache4);
		if (Lua_BlackJack_ProjectL_UI_ClimbTowerUITask.<>f__mg$cache5 == null)
		{
			Lua_BlackJack_ProjectL_UI_ClimbTowerUITask.<>f__mg$cache5 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ClimbTowerUITask.InitLayerStateOnLoadAllResCompleted);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_ClimbTowerUITask.<>f__mg$cache5);
		if (Lua_BlackJack_ProjectL_UI_ClimbTowerUITask.<>f__mg$cache6 == null)
		{
			Lua_BlackJack_ProjectL_UI_ClimbTowerUITask.<>f__mg$cache6 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ClimbTowerUITask.InitAllUIControllers);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_ClimbTowerUITask.<>f__mg$cache6);
		if (Lua_BlackJack_ProjectL_UI_ClimbTowerUITask.<>f__mg$cache7 == null)
		{
			Lua_BlackJack_ProjectL_UI_ClimbTowerUITask.<>f__mg$cache7 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ClimbTowerUITask.ClearAllContextAndRes);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_ClimbTowerUITask.<>f__mg$cache7);
		if (Lua_BlackJack_ProjectL_UI_ClimbTowerUITask.<>f__mg$cache8 == null)
		{
			Lua_BlackJack_ProjectL_UI_ClimbTowerUITask.<>f__mg$cache8 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ClimbTowerUITask.InitClimbTowerUIController);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_ClimbTowerUITask.<>f__mg$cache8);
		if (Lua_BlackJack_ProjectL_UI_ClimbTowerUITask.<>f__mg$cache9 == null)
		{
			Lua_BlackJack_ProjectL_UI_ClimbTowerUITask.<>f__mg$cache9 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ClimbTowerUITask.UninitClimbTowerUIController);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_ClimbTowerUITask.<>f__mg$cache9);
		if (Lua_BlackJack_ProjectL_UI_ClimbTowerUITask.<>f__mg$cacheA == null)
		{
			Lua_BlackJack_ProjectL_UI_ClimbTowerUITask.<>f__mg$cacheA = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ClimbTowerUITask.OnTick);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_ClimbTowerUITask.<>f__mg$cacheA);
		if (Lua_BlackJack_ProjectL_UI_ClimbTowerUITask.<>f__mg$cacheB == null)
		{
			Lua_BlackJack_ProjectL_UI_ClimbTowerUITask.<>f__mg$cacheB = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ClimbTowerUITask.UpdateView);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_ClimbTowerUITask.<>f__mg$cacheB);
		if (Lua_BlackJack_ProjectL_UI_ClimbTowerUITask.<>f__mg$cacheC == null)
		{
			Lua_BlackJack_ProjectL_UI_ClimbTowerUITask.<>f__mg$cacheC = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ClimbTowerUITask.UpdateFloors);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_ClimbTowerUITask.<>f__mg$cacheC);
		if (Lua_BlackJack_ProjectL_UI_ClimbTowerUITask.<>f__mg$cacheD == null)
		{
			Lua_BlackJack_ProjectL_UI_ClimbTowerUITask.<>f__mg$cacheD = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ClimbTowerUITask.UpdateClimbTowerFlushTime);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_ClimbTowerUITask.<>f__mg$cacheD);
		if (Lua_BlackJack_ProjectL_UI_ClimbTowerUITask.<>f__mg$cacheE == null)
		{
			Lua_BlackJack_ProjectL_UI_ClimbTowerUITask.<>f__mg$cacheE = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ClimbTowerUITask.StartClimbTowerLevelInfoUITask);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_ClimbTowerUITask.<>f__mg$cacheE);
		if (Lua_BlackJack_ProjectL_UI_ClimbTowerUITask.<>f__mg$cacheF == null)
		{
			Lua_BlackJack_ProjectL_UI_ClimbTowerUITask.<>f__mg$cacheF = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ClimbTowerUITask.StartClimbTowerRaidUITask);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_ClimbTowerUITask.<>f__mg$cacheF);
		if (Lua_BlackJack_ProjectL_UI_ClimbTowerUITask.<>f__mg$cache10 == null)
		{
			Lua_BlackJack_ProjectL_UI_ClimbTowerUITask.<>f__mg$cache10 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ClimbTowerUITask.ClimbTowerUIController_OnReturn);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_ClimbTowerUITask.<>f__mg$cache10);
		if (Lua_BlackJack_ProjectL_UI_ClimbTowerUITask.<>f__mg$cache11 == null)
		{
			Lua_BlackJack_ProjectL_UI_ClimbTowerUITask.<>f__mg$cache11 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ClimbTowerUITask.ClimbTowerUIController_OnShowHelp);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_ClimbTowerUITask.<>f__mg$cache11);
		if (Lua_BlackJack_ProjectL_UI_ClimbTowerUITask.<>f__mg$cache12 == null)
		{
			Lua_BlackJack_ProjectL_UI_ClimbTowerUITask.<>f__mg$cache12 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ClimbTowerUITask.ClimbTowerUIController_OnShowLevelInfo);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_ClimbTowerUITask.<>f__mg$cache12);
		if (Lua_BlackJack_ProjectL_UI_ClimbTowerUITask.<>f__mg$cache13 == null)
		{
			Lua_BlackJack_ProjectL_UI_ClimbTowerUITask.<>f__mg$cache13 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ClimbTowerUITask.ClimbTowerUIController_OnShowRaid);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_ClimbTowerUITask.<>f__mg$cache13);
		if (Lua_BlackJack_ProjectL_UI_ClimbTowerUITask.<>f__mg$cache14 == null)
		{
			Lua_BlackJack_ProjectL_UI_ClimbTowerUITask.<>f__mg$cache14 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ClimbTowerUITask.ClimbTowerUIController_OnConfirmRaid);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_ClimbTowerUITask.<>f__mg$cache14);
		if (Lua_BlackJack_ProjectL_UI_ClimbTowerUITask.<>f__mg$cache15 == null)
		{
			Lua_BlackJack_ProjectL_UI_ClimbTowerUITask.<>f__mg$cache15 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ClimbTowerUITask.FlushClimbTower);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_ClimbTowerUITask.<>f__mg$cache15);
		if (Lua_BlackJack_ProjectL_UI_ClimbTowerUITask.<>f__mg$cache16 == null)
		{
			Lua_BlackJack_ProjectL_UI_ClimbTowerUITask.<>f__mg$cache16 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ClimbTowerUITask.PlayerResourceUIController_OnAddGold);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_ClimbTowerUITask.<>f__mg$cache16);
		if (Lua_BlackJack_ProjectL_UI_ClimbTowerUITask.<>f__mg$cache17 == null)
		{
			Lua_BlackJack_ProjectL_UI_ClimbTowerUITask.<>f__mg$cache17 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ClimbTowerUITask.PlayerResourceUIController_OnAddCrystal);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_ClimbTowerUITask.<>f__mg$cache17);
		if (Lua_BlackJack_ProjectL_UI_ClimbTowerUITask.<>f__mg$cache18 == null)
		{
			Lua_BlackJack_ProjectL_UI_ClimbTowerUITask.<>f__mg$cache18 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ClimbTowerUITask.ClimbTowerLevelInfoUITask_OnClose);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_ClimbTowerUITask.<>f__mg$cache18);
		if (Lua_BlackJack_ProjectL_UI_ClimbTowerUITask.<>f__mg$cache19 == null)
		{
			Lua_BlackJack_ProjectL_UI_ClimbTowerUITask.<>f__mg$cache19 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ClimbTowerUITask.ClimbTowerRaidUITask_OnClose);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_ClimbTowerUITask.<>f__mg$cache19);
		if (Lua_BlackJack_ProjectL_UI_ClimbTowerUITask.<>f__mg$cache1A == null)
		{
			Lua_BlackJack_ProjectL_UI_ClimbTowerUITask.<>f__mg$cache1A = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ClimbTowerUITask.__callBase_OnStart);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_ClimbTowerUITask.<>f__mg$cache1A);
		if (Lua_BlackJack_ProjectL_UI_ClimbTowerUITask.<>f__mg$cache1B == null)
		{
			Lua_BlackJack_ProjectL_UI_ClimbTowerUITask.<>f__mg$cache1B = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ClimbTowerUITask.__callBase_OnStop);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_ClimbTowerUITask.<>f__mg$cache1B);
		if (Lua_BlackJack_ProjectL_UI_ClimbTowerUITask.<>f__mg$cache1C == null)
		{
			Lua_BlackJack_ProjectL_UI_ClimbTowerUITask.<>f__mg$cache1C = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ClimbTowerUITask.__callBase_OnPause);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_ClimbTowerUITask.<>f__mg$cache1C);
		if (Lua_BlackJack_ProjectL_UI_ClimbTowerUITask.<>f__mg$cache1D == null)
		{
			Lua_BlackJack_ProjectL_UI_ClimbTowerUITask.<>f__mg$cache1D = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ClimbTowerUITask.__callBase_OnResume);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_ClimbTowerUITask.<>f__mg$cache1D);
		if (Lua_BlackJack_ProjectL_UI_ClimbTowerUITask.<>f__mg$cache1E == null)
		{
			Lua_BlackJack_ProjectL_UI_ClimbTowerUITask.<>f__mg$cache1E = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ClimbTowerUITask.__callBase_OnNewIntent);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_ClimbTowerUITask.<>f__mg$cache1E);
		if (Lua_BlackJack_ProjectL_UI_ClimbTowerUITask.<>f__mg$cache1F == null)
		{
			Lua_BlackJack_ProjectL_UI_ClimbTowerUITask.<>f__mg$cache1F = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ClimbTowerUITask.__callBase_EnableUIInput);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_ClimbTowerUITask.<>f__mg$cache1F);
		if (Lua_BlackJack_ProjectL_UI_ClimbTowerUITask.<>f__mg$cache20 == null)
		{
			Lua_BlackJack_ProjectL_UI_ClimbTowerUITask.<>f__mg$cache20 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ClimbTowerUITask.__callBase_IsNeedLoadDynamicRes);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_ClimbTowerUITask.<>f__mg$cache20);
		if (Lua_BlackJack_ProjectL_UI_ClimbTowerUITask.<>f__mg$cache21 == null)
		{
			Lua_BlackJack_ProjectL_UI_ClimbTowerUITask.<>f__mg$cache21 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ClimbTowerUITask.__callBase_CollectAllDynamicResForLoad);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_ClimbTowerUITask.<>f__mg$cache21);
		if (Lua_BlackJack_ProjectL_UI_ClimbTowerUITask.<>f__mg$cache22 == null)
		{
			Lua_BlackJack_ProjectL_UI_ClimbTowerUITask.<>f__mg$cache22 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ClimbTowerUITask.__callBase_RegisterPlayerContextEvents);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_ClimbTowerUITask.<>f__mg$cache22);
		if (Lua_BlackJack_ProjectL_UI_ClimbTowerUITask.<>f__mg$cache23 == null)
		{
			Lua_BlackJack_ProjectL_UI_ClimbTowerUITask.<>f__mg$cache23 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ClimbTowerUITask.__callBase_UnregisterPlayerContextEvents);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_ClimbTowerUITask.<>f__mg$cache23);
		if (Lua_BlackJack_ProjectL_UI_ClimbTowerUITask.<>f__mg$cache24 == null)
		{
			Lua_BlackJack_ProjectL_UI_ClimbTowerUITask.<>f__mg$cache24 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ClimbTowerUITask.__callBase_PostUpdateView);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_ClimbTowerUITask.<>f__mg$cache24);
		if (Lua_BlackJack_ProjectL_UI_ClimbTowerUITask.<>f__mg$cache25 == null)
		{
			Lua_BlackJack_ProjectL_UI_ClimbTowerUITask.<>f__mg$cache25 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ClimbTowerUITask.__callBase_CollectPreloadResourceList);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_ClimbTowerUITask.<>f__mg$cache25);
		if (Lua_BlackJack_ProjectL_UI_ClimbTowerUITask.<>f__mg$cache26 == null)
		{
			Lua_BlackJack_ProjectL_UI_ClimbTowerUITask.<>f__mg$cache26 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ClimbTowerUITask.__callBase_ClearAssetList);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_ClimbTowerUITask.<>f__mg$cache26);
		if (Lua_BlackJack_ProjectL_UI_ClimbTowerUITask.<>f__mg$cache27 == null)
		{
			Lua_BlackJack_ProjectL_UI_ClimbTowerUITask.<>f__mg$cache27 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ClimbTowerUITask.__callBase_CollectAsset);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_ClimbTowerUITask.<>f__mg$cache27);
		if (Lua_BlackJack_ProjectL_UI_ClimbTowerUITask.<>f__mg$cache28 == null)
		{
			Lua_BlackJack_ProjectL_UI_ClimbTowerUITask.<>f__mg$cache28 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ClimbTowerUITask.__callBase_CollectSpriteAsset);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_ClimbTowerUITask.<>f__mg$cache28);
		if (Lua_BlackJack_ProjectL_UI_ClimbTowerUITask.<>f__mg$cache29 == null)
		{
			Lua_BlackJack_ProjectL_UI_ClimbTowerUITask.<>f__mg$cache29 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ClimbTowerUITask.__callBase_CollectFxAsset);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_ClimbTowerUITask.<>f__mg$cache29);
		if (Lua_BlackJack_ProjectL_UI_ClimbTowerUITask.<>f__mg$cache2A == null)
		{
			Lua_BlackJack_ProjectL_UI_ClimbTowerUITask.<>f__mg$cache2A = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ClimbTowerUITask.__callBase_StartLoadCustomAssets);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_ClimbTowerUITask.<>f__mg$cache2A);
		if (Lua_BlackJack_ProjectL_UI_ClimbTowerUITask.<>f__mg$cache2B == null)
		{
			Lua_BlackJack_ProjectL_UI_ClimbTowerUITask.<>f__mg$cache2B = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ClimbTowerUITask.__callBase_IsLoadingCustomAssets);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_ClimbTowerUITask.<>f__mg$cache2B);
		if (Lua_BlackJack_ProjectL_UI_ClimbTowerUITask.<>f__mg$cache2C == null)
		{
			Lua_BlackJack_ProjectL_UI_ClimbTowerUITask.<>f__mg$cache2C = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ClimbTowerUITask.__callBase_IsPipeLineRunning);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_ClimbTowerUITask.<>f__mg$cache2C);
		if (Lua_BlackJack_ProjectL_UI_ClimbTowerUITask.<>f__mg$cache2D == null)
		{
			Lua_BlackJack_ProjectL_UI_ClimbTowerUITask.<>f__mg$cache2D = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ClimbTowerUITask.__callBase_IsOpeningUI);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_ClimbTowerUITask.<>f__mg$cache2D);
		if (Lua_BlackJack_ProjectL_UI_ClimbTowerUITask.<>f__mg$cache2E == null)
		{
			Lua_BlackJack_ProjectL_UI_ClimbTowerUITask.<>f__mg$cache2E = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ClimbTowerUITask.__callBase_ReturnPrevUITask);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_ClimbTowerUITask.<>f__mg$cache2E);
		if (Lua_BlackJack_ProjectL_UI_ClimbTowerUITask.<>f__mg$cache2F == null)
		{
			Lua_BlackJack_ProjectL_UI_ClimbTowerUITask.<>f__mg$cache2F = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ClimbTowerUITask.__callBase_ClearUnusedDynamicResourceCache);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_ClimbTowerUITask.<>f__mg$cache2F);
		if (Lua_BlackJack_ProjectL_UI_ClimbTowerUITask.<>f__mg$cache30 == null)
		{
			Lua_BlackJack_ProjectL_UI_ClimbTowerUITask.<>f__mg$cache30 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ClimbTowerUITask.__callBase_OnMemoryWarning);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_ClimbTowerUITask.<>f__mg$cache30);
		if (Lua_BlackJack_ProjectL_UI_ClimbTowerUITask.<>f__mg$cache31 == null)
		{
			Lua_BlackJack_ProjectL_UI_ClimbTowerUITask.<>f__mg$cache31 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ClimbTowerUITask.ComputeBigFloorFromFloorId_s);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_ClimbTowerUITask.<>f__mg$cache31);
		string name = "m_layerDescArray";
		if (Lua_BlackJack_ProjectL_UI_ClimbTowerUITask.<>f__mg$cache32 == null)
		{
			Lua_BlackJack_ProjectL_UI_ClimbTowerUITask.<>f__mg$cache32 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ClimbTowerUITask.get_m_layerDescArray);
		}
		LuaCSFunction get = Lua_BlackJack_ProjectL_UI_ClimbTowerUITask.<>f__mg$cache32;
		if (Lua_BlackJack_ProjectL_UI_ClimbTowerUITask.<>f__mg$cache33 == null)
		{
			Lua_BlackJack_ProjectL_UI_ClimbTowerUITask.<>f__mg$cache33 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ClimbTowerUITask.set_m_layerDescArray);
		}
		LuaObject.addMember(l, name, get, Lua_BlackJack_ProjectL_UI_ClimbTowerUITask.<>f__mg$cache33, true);
		string name2 = "m_uiCtrlDescArray";
		if (Lua_BlackJack_ProjectL_UI_ClimbTowerUITask.<>f__mg$cache34 == null)
		{
			Lua_BlackJack_ProjectL_UI_ClimbTowerUITask.<>f__mg$cache34 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ClimbTowerUITask.get_m_uiCtrlDescArray);
		}
		LuaCSFunction get2 = Lua_BlackJack_ProjectL_UI_ClimbTowerUITask.<>f__mg$cache34;
		if (Lua_BlackJack_ProjectL_UI_ClimbTowerUITask.<>f__mg$cache35 == null)
		{
			Lua_BlackJack_ProjectL_UI_ClimbTowerUITask.<>f__mg$cache35 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ClimbTowerUITask.set_m_uiCtrlDescArray);
		}
		LuaObject.addMember(l, name2, get2, Lua_BlackJack_ProjectL_UI_ClimbTowerUITask.<>f__mg$cache35, true);
		string name3 = "m_climbTowerUIController";
		if (Lua_BlackJack_ProjectL_UI_ClimbTowerUITask.<>f__mg$cache36 == null)
		{
			Lua_BlackJack_ProjectL_UI_ClimbTowerUITask.<>f__mg$cache36 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ClimbTowerUITask.get_m_climbTowerUIController);
		}
		LuaCSFunction get3 = Lua_BlackJack_ProjectL_UI_ClimbTowerUITask.<>f__mg$cache36;
		if (Lua_BlackJack_ProjectL_UI_ClimbTowerUITask.<>f__mg$cache37 == null)
		{
			Lua_BlackJack_ProjectL_UI_ClimbTowerUITask.<>f__mg$cache37 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ClimbTowerUITask.set_m_climbTowerUIController);
		}
		LuaObject.addMember(l, name3, get3, Lua_BlackJack_ProjectL_UI_ClimbTowerUITask.<>f__mg$cache37, true);
		string name4 = "m_playerResourceUIController";
		if (Lua_BlackJack_ProjectL_UI_ClimbTowerUITask.<>f__mg$cache38 == null)
		{
			Lua_BlackJack_ProjectL_UI_ClimbTowerUITask.<>f__mg$cache38 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ClimbTowerUITask.get_m_playerResourceUIController);
		}
		LuaCSFunction get4 = Lua_BlackJack_ProjectL_UI_ClimbTowerUITask.<>f__mg$cache38;
		if (Lua_BlackJack_ProjectL_UI_ClimbTowerUITask.<>f__mg$cache39 == null)
		{
			Lua_BlackJack_ProjectL_UI_ClimbTowerUITask.<>f__mg$cache39 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ClimbTowerUITask.set_m_playerResourceUIController);
		}
		LuaObject.addMember(l, name4, get4, Lua_BlackJack_ProjectL_UI_ClimbTowerUITask.<>f__mg$cache39, true);
		string name5 = "m_nowSeconds";
		if (Lua_BlackJack_ProjectL_UI_ClimbTowerUITask.<>f__mg$cache3A == null)
		{
			Lua_BlackJack_ProjectL_UI_ClimbTowerUITask.<>f__mg$cache3A = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ClimbTowerUITask.get_m_nowSeconds);
		}
		LuaCSFunction get5 = Lua_BlackJack_ProjectL_UI_ClimbTowerUITask.<>f__mg$cache3A;
		if (Lua_BlackJack_ProjectL_UI_ClimbTowerUITask.<>f__mg$cache3B == null)
		{
			Lua_BlackJack_ProjectL_UI_ClimbTowerUITask.<>f__mg$cache3B = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ClimbTowerUITask.set_m_nowSeconds);
		}
		LuaObject.addMember(l, name5, get5, Lua_BlackJack_ProjectL_UI_ClimbTowerUITask.<>f__mg$cache3B, true);
		string name6 = "m_climbTowerLevelInfoUITask";
		if (Lua_BlackJack_ProjectL_UI_ClimbTowerUITask.<>f__mg$cache3C == null)
		{
			Lua_BlackJack_ProjectL_UI_ClimbTowerUITask.<>f__mg$cache3C = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ClimbTowerUITask.get_m_climbTowerLevelInfoUITask);
		}
		LuaCSFunction get6 = Lua_BlackJack_ProjectL_UI_ClimbTowerUITask.<>f__mg$cache3C;
		if (Lua_BlackJack_ProjectL_UI_ClimbTowerUITask.<>f__mg$cache3D == null)
		{
			Lua_BlackJack_ProjectL_UI_ClimbTowerUITask.<>f__mg$cache3D = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ClimbTowerUITask.set_m_climbTowerLevelInfoUITask);
		}
		LuaObject.addMember(l, name6, get6, Lua_BlackJack_ProjectL_UI_ClimbTowerUITask.<>f__mg$cache3D, true);
		string name7 = "m_climbTowerRaidUITask";
		if (Lua_BlackJack_ProjectL_UI_ClimbTowerUITask.<>f__mg$cache3E == null)
		{
			Lua_BlackJack_ProjectL_UI_ClimbTowerUITask.<>f__mg$cache3E = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ClimbTowerUITask.get_m_climbTowerRaidUITask);
		}
		LuaCSFunction get7 = Lua_BlackJack_ProjectL_UI_ClimbTowerUITask.<>f__mg$cache3E;
		if (Lua_BlackJack_ProjectL_UI_ClimbTowerUITask.<>f__mg$cache3F == null)
		{
			Lua_BlackJack_ProjectL_UI_ClimbTowerUITask.<>f__mg$cache3F = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ClimbTowerUITask.set_m_climbTowerRaidUITask);
		}
		LuaObject.addMember(l, name7, get7, Lua_BlackJack_ProjectL_UI_ClimbTowerUITask.<>f__mg$cache3F, true);
		string name8 = "m_armyRandomNumber";
		if (Lua_BlackJack_ProjectL_UI_ClimbTowerUITask.<>f__mg$cache40 == null)
		{
			Lua_BlackJack_ProjectL_UI_ClimbTowerUITask.<>f__mg$cache40 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ClimbTowerUITask.get_m_armyRandomNumber);
		}
		LuaCSFunction get8 = Lua_BlackJack_ProjectL_UI_ClimbTowerUITask.<>f__mg$cache40;
		if (Lua_BlackJack_ProjectL_UI_ClimbTowerUITask.<>f__mg$cache41 == null)
		{
			Lua_BlackJack_ProjectL_UI_ClimbTowerUITask.<>f__mg$cache41 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ClimbTowerUITask.set_m_armyRandomNumber);
		}
		LuaObject.addMember(l, name8, get8, Lua_BlackJack_ProjectL_UI_ClimbTowerUITask.<>f__mg$cache41, true);
		string name9 = "m_nextCheckClimbTowerFlushTime";
		if (Lua_BlackJack_ProjectL_UI_ClimbTowerUITask.<>f__mg$cache42 == null)
		{
			Lua_BlackJack_ProjectL_UI_ClimbTowerUITask.<>f__mg$cache42 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ClimbTowerUITask.get_m_nextCheckClimbTowerFlushTime);
		}
		LuaCSFunction get9 = Lua_BlackJack_ProjectL_UI_ClimbTowerUITask.<>f__mg$cache42;
		if (Lua_BlackJack_ProjectL_UI_ClimbTowerUITask.<>f__mg$cache43 == null)
		{
			Lua_BlackJack_ProjectL_UI_ClimbTowerUITask.<>f__mg$cache43 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ClimbTowerUITask.set_m_nextCheckClimbTowerFlushTime);
		}
		LuaObject.addMember(l, name9, get9, Lua_BlackJack_ProjectL_UI_ClimbTowerUITask.<>f__mg$cache43, true);
		string name10 = "m_isRaidClear";
		if (Lua_BlackJack_ProjectL_UI_ClimbTowerUITask.<>f__mg$cache44 == null)
		{
			Lua_BlackJack_ProjectL_UI_ClimbTowerUITask.<>f__mg$cache44 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ClimbTowerUITask.get_m_isRaidClear);
		}
		LuaCSFunction get10 = Lua_BlackJack_ProjectL_UI_ClimbTowerUITask.<>f__mg$cache44;
		if (Lua_BlackJack_ProjectL_UI_ClimbTowerUITask.<>f__mg$cache45 == null)
		{
			Lua_BlackJack_ProjectL_UI_ClimbTowerUITask.<>f__mg$cache45 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ClimbTowerUITask.set_m_isRaidClear);
		}
		LuaObject.addMember(l, name10, get10, Lua_BlackJack_ProjectL_UI_ClimbTowerUITask.<>f__mg$cache45, true);
		string name11 = "LayerDescArray";
		if (Lua_BlackJack_ProjectL_UI_ClimbTowerUITask.<>f__mg$cache46 == null)
		{
			Lua_BlackJack_ProjectL_UI_ClimbTowerUITask.<>f__mg$cache46 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ClimbTowerUITask.get_LayerDescArray);
		}
		LuaObject.addMember(l, name11, Lua_BlackJack_ProjectL_UI_ClimbTowerUITask.<>f__mg$cache46, null, true);
		string name12 = "UICtrlDescArray";
		if (Lua_BlackJack_ProjectL_UI_ClimbTowerUITask.<>f__mg$cache47 == null)
		{
			Lua_BlackJack_ProjectL_UI_ClimbTowerUITask.<>f__mg$cache47 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ClimbTowerUITask.get_UICtrlDescArray);
		}
		LuaObject.addMember(l, name12, Lua_BlackJack_ProjectL_UI_ClimbTowerUITask.<>f__mg$cache47, null, true);
		if (Lua_BlackJack_ProjectL_UI_ClimbTowerUITask.<>f__mg$cache48 == null)
		{
			Lua_BlackJack_ProjectL_UI_ClimbTowerUITask.<>f__mg$cache48 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ClimbTowerUITask.constructor);
		}
		LuaObject.createTypeMetatable(l, Lua_BlackJack_ProjectL_UI_ClimbTowerUITask.<>f__mg$cache48, typeof(ClimbTowerUITask), typeof(UITask));
	}

	// Token: 0x04012E94 RID: 77460
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache0;

	// Token: 0x04012E95 RID: 77461
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1;

	// Token: 0x04012E96 RID: 77462
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2;

	// Token: 0x04012E97 RID: 77463
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3;

	// Token: 0x04012E98 RID: 77464
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache4;

	// Token: 0x04012E99 RID: 77465
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache5;

	// Token: 0x04012E9A RID: 77466
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache6;

	// Token: 0x04012E9B RID: 77467
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache7;

	// Token: 0x04012E9C RID: 77468
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache8;

	// Token: 0x04012E9D RID: 77469
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache9;

	// Token: 0x04012E9E RID: 77470
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheA;

	// Token: 0x04012E9F RID: 77471
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheB;

	// Token: 0x04012EA0 RID: 77472
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheC;

	// Token: 0x04012EA1 RID: 77473
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheD;

	// Token: 0x04012EA2 RID: 77474
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheE;

	// Token: 0x04012EA3 RID: 77475
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheF;

	// Token: 0x04012EA4 RID: 77476
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache10;

	// Token: 0x04012EA5 RID: 77477
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache11;

	// Token: 0x04012EA6 RID: 77478
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache12;

	// Token: 0x04012EA7 RID: 77479
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache13;

	// Token: 0x04012EA8 RID: 77480
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache14;

	// Token: 0x04012EA9 RID: 77481
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache15;

	// Token: 0x04012EAA RID: 77482
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache16;

	// Token: 0x04012EAB RID: 77483
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache17;

	// Token: 0x04012EAC RID: 77484
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache18;

	// Token: 0x04012EAD RID: 77485
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache19;

	// Token: 0x04012EAE RID: 77486
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1A;

	// Token: 0x04012EAF RID: 77487
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1B;

	// Token: 0x04012EB0 RID: 77488
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1C;

	// Token: 0x04012EB1 RID: 77489
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1D;

	// Token: 0x04012EB2 RID: 77490
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1E;

	// Token: 0x04012EB3 RID: 77491
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1F;

	// Token: 0x04012EB4 RID: 77492
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache20;

	// Token: 0x04012EB5 RID: 77493
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache21;

	// Token: 0x04012EB6 RID: 77494
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache22;

	// Token: 0x04012EB7 RID: 77495
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache23;

	// Token: 0x04012EB8 RID: 77496
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache24;

	// Token: 0x04012EB9 RID: 77497
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache25;

	// Token: 0x04012EBA RID: 77498
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache26;

	// Token: 0x04012EBB RID: 77499
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache27;

	// Token: 0x04012EBC RID: 77500
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache28;

	// Token: 0x04012EBD RID: 77501
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache29;

	// Token: 0x04012EBE RID: 77502
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2A;

	// Token: 0x04012EBF RID: 77503
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2B;

	// Token: 0x04012EC0 RID: 77504
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2C;

	// Token: 0x04012EC1 RID: 77505
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2D;

	// Token: 0x04012EC2 RID: 77506
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2E;

	// Token: 0x04012EC3 RID: 77507
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2F;

	// Token: 0x04012EC4 RID: 77508
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache30;

	// Token: 0x04012EC5 RID: 77509
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache31;

	// Token: 0x04012EC6 RID: 77510
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache32;

	// Token: 0x04012EC7 RID: 77511
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache33;

	// Token: 0x04012EC8 RID: 77512
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache34;

	// Token: 0x04012EC9 RID: 77513
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache35;

	// Token: 0x04012ECA RID: 77514
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache36;

	// Token: 0x04012ECB RID: 77515
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache37;

	// Token: 0x04012ECC RID: 77516
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache38;

	// Token: 0x04012ECD RID: 77517
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache39;

	// Token: 0x04012ECE RID: 77518
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3A;

	// Token: 0x04012ECF RID: 77519
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3B;

	// Token: 0x04012ED0 RID: 77520
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3C;

	// Token: 0x04012ED1 RID: 77521
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3D;

	// Token: 0x04012ED2 RID: 77522
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3E;

	// Token: 0x04012ED3 RID: 77523
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3F;

	// Token: 0x04012ED4 RID: 77524
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache40;

	// Token: 0x04012ED5 RID: 77525
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache41;

	// Token: 0x04012ED6 RID: 77526
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache42;

	// Token: 0x04012ED7 RID: 77527
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache43;

	// Token: 0x04012ED8 RID: 77528
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache44;

	// Token: 0x04012ED9 RID: 77529
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache45;

	// Token: 0x04012EDA RID: 77530
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache46;

	// Token: 0x04012EDB RID: 77531
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache47;

	// Token: 0x04012EDC RID: 77532
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache48;
}
