using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using BlackJack.ConfigData;
using BlackJack.ProjectL.Common;
using BlackJack.ProjectL.PlayerContext;
using BlackJack.ProjectL.Protocol;
using SLua;
using UnityEngine.Scripting;

// Token: 0x020012CF RID: 4815
[Preserve]
public class Lua_BlackJack_ProjectL_PlayerContext_LevelComponent : LuaObject
{
	// Token: 0x06019637 RID: 103991 RVA: 0x0074D1B4 File Offset: 0x0074B3B4
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int constructor(IntPtr l)
	{
		int result;
		try
		{
			LevelComponent o = new LevelComponent();
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

	// Token: 0x06019638 RID: 103992 RVA: 0x0074D1FC File Offset: 0x0074B3FC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int Init(IntPtr l)
	{
		int result;
		try
		{
			LevelComponent levelComponent = (LevelComponent)LuaObject.checkSelf(l);
			levelComponent.Init();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06019639 RID: 103993 RVA: 0x0074D248 File Offset: 0x0074B448
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int PostInit(IntPtr l)
	{
		int result;
		try
		{
			LevelComponent levelComponent = (LevelComponent)LuaObject.checkSelf(l);
			levelComponent.PostInit();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601963A RID: 103994 RVA: 0x0074D294 File Offset: 0x0074B494
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int DeInit(IntPtr l)
	{
		int result;
		try
		{
			LevelComponent levelComponent = (LevelComponent)LuaObject.checkSelf(l);
			levelComponent.DeInit();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601963B RID: 103995 RVA: 0x0074D2E0 File Offset: 0x0074B4E0
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int Tick(IntPtr l)
	{
		int result;
		try
		{
			LevelComponent levelComponent = (LevelComponent)LuaObject.checkSelf(l);
			uint deltaMillisecond;
			LuaObject.checkType(l, 2, out deltaMillisecond);
			levelComponent.Tick(deltaMillisecond);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601963C RID: 103996 RVA: 0x0074D338 File Offset: 0x0074B538
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int DeSerialize(IntPtr l)
	{
		int result;
		try
		{
			LevelComponent levelComponent = (LevelComponent)LuaObject.checkSelf(l);
			DSLevelNtf msg;
			LuaObject.checkType<DSLevelNtf>(l, 2, out msg);
			levelComponent.DeSerialize(msg);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601963D RID: 103997 RVA: 0x0074D390 File Offset: 0x0074B590
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int GetDSVersion(IntPtr l)
	{
		int result;
		try
		{
			LevelComponent levelComponent = (LevelComponent)LuaObject.checkSelf(l);
			ushort dsversion = levelComponent.GetDSVersion();
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, dsversion);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601963E RID: 103998 RVA: 0x0074D3E4 File Offset: 0x0074B5E4
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int CanAttackScenario(IntPtr l)
	{
		int result;
		try
		{
			int num = LuaDLL.lua_gettop(l);
			if (num == 2)
			{
				LevelComponent levelComponent = (LevelComponent)LuaObject.checkSelf(l);
				ConfigDataScenarioInfo secenarioInfo;
				LuaObject.checkType<ConfigDataScenarioInfo>(l, 2, out secenarioInfo);
				int i = levelComponent.CanAttackScenario(secenarioInfo);
				LuaObject.pushValue(l, true);
				LuaObject.pushValue(l, i);
				result = 2;
			}
			else if (num == 4)
			{
				LevelComponent levelComponent2 = (LevelComponent)LuaObject.checkSelf(l);
				ConfigDataScenarioInfo scenarioInfo;
				LuaObject.checkType<ConfigDataScenarioInfo>(l, 2, out scenarioInfo);
				bool scenarioFinished;
				LuaObject.checkType(l, 3, out scenarioFinished);
				bool checkBag;
				LuaObject.checkType(l, 4, out checkBag);
				int i2 = levelComponent2.CanAttackScenario(scenarioInfo, scenarioFinished, checkBag);
				LuaObject.pushValue(l, true);
				LuaObject.pushValue(l, i2);
				result = 2;
			}
			else
			{
				LuaObject.pushValue(l, false);
				LuaDLL.lua_pushstring(l, "No matched override function CanAttackScenario to call");
				result = 2;
			}
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601963F RID: 103999 RVA: 0x0074D4C8 File Offset: 0x0074B6C8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int CanAttackEventWayPoint(IntPtr l)
	{
		int result;
		try
		{
			LevelComponent levelComponent = (LevelComponent)LuaObject.checkSelf(l);
			ConfigDataWaypointInfo wayPointInfo;
			LuaObject.checkType<ConfigDataWaypointInfo>(l, 2, out wayPointInfo);
			int i = levelComponent.CanAttackEventWayPoint(wayPointInfo);
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

	// Token: 0x06019640 RID: 104000 RVA: 0x0074D52C File Offset: 0x0074B72C
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int SetBattleWayPointSuccessful(IntPtr l)
	{
		int result;
		try
		{
			LevelComponent levelComponent = (LevelComponent)LuaObject.checkSelf(l);
			ConfigDataWaypointInfo wayPointInfo;
			LuaObject.checkType<ConfigDataWaypointInfo>(l, 2, out wayPointInfo);
			List<int> battleTreasures;
			LuaObject.checkType<List<int>>(l, 3, out battleTreasures);
			levelComponent.SetBattleWayPointSuccessful(wayPointInfo, battleTreasures);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06019641 RID: 104001 RVA: 0x0074D590 File Offset: 0x0074B790
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int IsRegionOpen(IntPtr l)
	{
		int result;
		try
		{
			LevelComponent levelComponent = (LevelComponent)LuaObject.checkSelf(l);
			int regionId;
			LuaObject.checkType(l, 2, out regionId);
			bool b = levelComponent.IsRegionOpen(regionId);
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

	// Token: 0x06019642 RID: 104002 RVA: 0x0074D5F4 File Offset: 0x0074B7F4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int GetWaypointStatus(IntPtr l)
	{
		int result;
		try
		{
			LevelComponent levelComponent = (LevelComponent)LuaObject.checkSelf(l);
			int waypointId;
			LuaObject.checkType(l, 2, out waypointId);
			WayPointStatus waypointStatus = levelComponent.GetWaypointStatus(waypointId);
			LuaObject.pushValue(l, true);
			LuaObject.pushEnum(l, (int)waypointStatus);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06019643 RID: 104003 RVA: 0x0074D658 File Offset: 0x0074B858
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int GetPlayerCurrentWaypointInfo(IntPtr l)
	{
		int result;
		try
		{
			LevelComponent levelComponent = (LevelComponent)LuaObject.checkSelf(l);
			ConfigDataWaypointInfo playerCurrentWaypointInfo = levelComponent.GetPlayerCurrentWaypointInfo();
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, playerCurrentWaypointInfo);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06019644 RID: 104004 RVA: 0x0074D6AC File Offset: 0x0074B8AC
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int GetLastFinishedScenarioInfo(IntPtr l)
	{
		int result;
		try
		{
			LevelComponent levelComponent = (LevelComponent)LuaObject.checkSelf(l);
			ConfigDataScenarioInfo lastFinishedScenarioInfo = levelComponent.GetLastFinishedScenarioInfo();
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, lastFinishedScenarioInfo);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06019645 RID: 104005 RVA: 0x0074D700 File Offset: 0x0074B900
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int SetFinishedScenario(IntPtr l)
	{
		int result;
		try
		{
			LevelComponent levelComponent = (LevelComponent)LuaObject.checkSelf(l);
			ConfigDataScenarioInfo finishedScenario;
			LuaObject.checkType<ConfigDataScenarioInfo>(l, 2, out finishedScenario);
			levelComponent.SetFinishedScenario(finishedScenario);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06019646 RID: 104006 RVA: 0x0074D758 File Offset: 0x0074B958
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int FinishBattleWayPoint(IntPtr l)
	{
		int result2;
		try
		{
			LevelComponent levelComponent = (LevelComponent)LuaObject.checkSelf(l);
			int wayPointId;
			LuaObject.checkType(l, 2, out wayPointId);
			bool isWin;
			LuaObject.checkType(l, 3, out isWin);
			int result;
			LuaObject.checkType(l, 4, out result);
			List<int> battleTreasureIds;
			LuaObject.checkType<List<int>>(l, 5, out battleTreasureIds);
			int i = levelComponent.FinishBattleWayPoint(wayPointId, isWin, result, battleTreasureIds);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, i);
			result2 = 2;
		}
		catch (Exception e)
		{
			result2 = LuaObject.error(l, e);
		}
		return result2;
	}

	// Token: 0x06019647 RID: 104007 RVA: 0x0074D7E0 File Offset: 0x0074B9E0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int HandleDialogEvent(IntPtr l)
	{
		int result;
		try
		{
			LevelComponent levelComponent = (LevelComponent)LuaObject.checkSelf(l);
			ConfigDataWaypointInfo wayPointInfo;
			LuaObject.checkType<ConfigDataWaypointInfo>(l, 2, out wayPointInfo);
			List<Goods> itemRewards;
			LuaObject.checkType<List<Goods>>(l, 3, out itemRewards);
			int playerExpReward;
			LuaObject.checkType(l, 4, out playerExpReward);
			int goldReward;
			LuaObject.checkType(l, 5, out goldReward);
			int energyCost;
			LuaObject.checkType(l, 6, out energyCost);
			int scenarioId;
			LuaObject.checkType(l, 7, out scenarioId);
			int i = levelComponent.m_luaExportHelper.HandleDialogEvent(wayPointInfo, itemRewards, playerExpReward, goldReward, energyCost, scenarioId);
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

	// Token: 0x06019648 RID: 104008 RVA: 0x0074D888 File Offset: 0x0074BA88
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int HandleTresureEvent(IntPtr l)
	{
		int result;
		try
		{
			LevelComponent levelComponent = (LevelComponent)LuaObject.checkSelf(l);
			int wayPointId;
			LuaObject.checkType(l, 2, out wayPointId);
			ConfigDataEventInfo eventInfo;
			LuaObject.checkType<ConfigDataEventInfo>(l, 3, out eventInfo);
			int i = levelComponent.m_luaExportHelper.HandleTresureEvent(wayPointId, eventInfo);
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

	// Token: 0x06019649 RID: 104009 RVA: 0x0074D8FC File Offset: 0x0074BAFC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_GetName(IntPtr l)
	{
		int result;
		try
		{
			LevelComponent levelComponent = (LevelComponent)LuaObject.checkSelf(l);
			string s = levelComponent.m_luaExportHelper.__callBase_GetName();
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, s);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601964A RID: 104010 RVA: 0x0074D958 File Offset: 0x0074BB58
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_Init(IntPtr l)
	{
		int result;
		try
		{
			LevelComponent levelComponent = (LevelComponent)LuaObject.checkSelf(l);
			levelComponent.m_luaExportHelper.__callBase_Init();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601964B RID: 104011 RVA: 0x0074D9AC File Offset: 0x0074BBAC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_PostInit(IntPtr l)
	{
		int result;
		try
		{
			LevelComponent levelComponent = (LevelComponent)LuaObject.checkSelf(l);
			levelComponent.m_luaExportHelper.__callBase_PostInit();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601964C RID: 104012 RVA: 0x0074DA00 File Offset: 0x0074BC00
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_DeInit(IntPtr l)
	{
		int result;
		try
		{
			LevelComponent levelComponent = (LevelComponent)LuaObject.checkSelf(l);
			levelComponent.m_luaExportHelper.__callBase_DeInit();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601964D RID: 104013 RVA: 0x0074DA54 File Offset: 0x0074BC54
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_Tick(IntPtr l)
	{
		int result;
		try
		{
			LevelComponent levelComponent = (LevelComponent)LuaObject.checkSelf(l);
			uint deltaMillisecond;
			LuaObject.checkType(l, 2, out deltaMillisecond);
			levelComponent.m_luaExportHelper.__callBase_Tick(deltaMillisecond);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601964E RID: 104014 RVA: 0x0074DAB0 File Offset: 0x0074BCB0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_PostDeSerialize(IntPtr l)
	{
		int result;
		try
		{
			LevelComponent levelComponent = (LevelComponent)LuaObject.checkSelf(l);
			levelComponent.m_luaExportHelper.__callBase_PostDeSerialize();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601964F RID: 104015 RVA: 0x0074DB04 File Offset: 0x0074BD04
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_IsWayPointArrived(IntPtr l)
	{
		int result;
		try
		{
			LevelComponent levelComponent = (LevelComponent)LuaObject.checkSelf(l);
			int wayPointId;
			LuaObject.checkType(l, 2, out wayPointId);
			bool b = levelComponent.m_luaExportHelper.__callBase_IsWayPointArrived(wayPointId);
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

	// Token: 0x06019650 RID: 104016 RVA: 0x0074DB6C File Offset: 0x0074BD6C
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int __callBase_OutPutRandomEventOperateLog(IntPtr l)
	{
		int result;
		try
		{
			LevelComponent levelComponent = (LevelComponent)LuaObject.checkSelf(l);
			int eventId;
			LuaObject.checkType(l, 2, out eventId);
			RandomEventStatus status;
			LuaObject.checkEnum<RandomEventStatus>(l, 3, out status);
			List<Goods> rewards;
			LuaObject.checkType<List<Goods>>(l, 4, out rewards);
			levelComponent.m_luaExportHelper.__callBase_OutPutRandomEventOperateLog(eventId, status, rewards);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06019651 RID: 104017 RVA: 0x0074DBE4 File Offset: 0x0074BDE4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_InitLevelInfo(IntPtr l)
	{
		int result;
		try
		{
			LevelComponent levelComponent = (LevelComponent)LuaObject.checkSelf(l);
			List<int> arrivedWayPoints;
			LuaObject.checkType<List<int>>(l, 2, out arrivedWayPoints);
			levelComponent.m_luaExportHelper.__callBase_InitLevelInfo(arrivedWayPoints);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06019652 RID: 104018 RVA: 0x0074DC40 File Offset: 0x0074BE40
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_SetArrivedWayPoint(IntPtr l)
	{
		int result;
		try
		{
			LevelComponent levelComponent = (LevelComponent)LuaObject.checkSelf(l);
			int wayPointId;
			LuaObject.checkType(l, 2, out wayPointId);
			levelComponent.m_luaExportHelper.__callBase_SetArrivedWayPoint(wayPointId);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06019653 RID: 104019 RVA: 0x0074DC9C File Offset: 0x0074BE9C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_ArriveWayPoint(IntPtr l)
	{
		int result;
		try
		{
			LevelComponent levelComponent = (LevelComponent)LuaObject.checkSelf(l);
			int wayPointId;
			LuaObject.checkType(l, 2, out wayPointId);
			levelComponent.m_luaExportHelper.__callBase_ArriveWayPoint(wayPointId);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06019654 RID: 104020 RVA: 0x0074DCF8 File Offset: 0x0074BEF8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_HasFirstWayPointWithScenario(IntPtr l)
	{
		int result;
		try
		{
			LevelComponent levelComponent = (LevelComponent)LuaObject.checkSelf(l);
			bool b = levelComponent.m_luaExportHelper.__callBase_HasFirstWayPointWithScenario();
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

	// Token: 0x06019655 RID: 104021 RVA: 0x0074DD54 File Offset: 0x0074BF54
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int __callBase_AddCanMovePublicWayPoint(IntPtr l)
	{
		int result;
		try
		{
			LevelComponent levelComponent = (LevelComponent)LuaObject.checkSelf(l);
			int newId;
			LuaObject.checkType(l, 2, out newId);
			levelComponent.m_luaExportHelper.__callBase_AddCanMovePublicWayPoint(newId);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06019656 RID: 104022 RVA: 0x0074DDB0 File Offset: 0x0074BFB0
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int __callBase_SetFinishedScenario(IntPtr l)
	{
		int result;
		try
		{
			LevelComponent levelComponent = (LevelComponent)LuaObject.checkSelf(l);
			ConfigDataScenarioInfo scenarioInfo;
			LuaObject.checkType<ConfigDataScenarioInfo>(l, 2, out scenarioInfo);
			levelComponent.m_luaExportHelper.__callBase_SetFinishedScenario(scenarioInfo);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06019657 RID: 104023 RVA: 0x0074DE0C File Offset: 0x0074C00C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_GetLastFinishedScenarioId(IntPtr l)
	{
		int result;
		try
		{
			LevelComponent levelComponent = (LevelComponent)LuaObject.checkSelf(l);
			int i = levelComponent.m_luaExportHelper.__callBase_GetLastFinishedScenarioId();
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

	// Token: 0x06019658 RID: 104024 RVA: 0x0074DE68 File Offset: 0x0074C068
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_IsScenarioCompleted(IntPtr l)
	{
		int result;
		try
		{
			LevelComponent levelComponent = (LevelComponent)LuaObject.checkSelf(l);
			int scenarioId;
			LuaObject.checkType(l, 2, out scenarioId);
			bool b = levelComponent.m_luaExportHelper.__callBase_IsScenarioCompleted(scenarioId);
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

	// Token: 0x06019659 RID: 104025 RVA: 0x0074DED0 File Offset: 0x0074C0D0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_GetScenarioId(IntPtr l)
	{
		int result;
		try
		{
			LevelComponent levelComponent = (LevelComponent)LuaObject.checkSelf(l);
			int i = levelComponent.m_luaExportHelper.__callBase_GetScenarioId();
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

	// Token: 0x0601965A RID: 104026 RVA: 0x0074DF2C File Offset: 0x0074C12C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_SetBattleWayPointSuccessful(IntPtr l)
	{
		int result;
		try
		{
			LevelComponent levelComponent = (LevelComponent)LuaObject.checkSelf(l);
			ConfigDataWaypointInfo wayPointInfo;
			LuaObject.checkType<ConfigDataWaypointInfo>(l, 2, out wayPointInfo);
			List<int> battleTreasures;
			LuaObject.checkType<List<int>>(l, 3, out battleTreasures);
			levelComponent.m_luaExportHelper.__callBase_SetBattleWayPointSuccessful(wayPointInfo, battleTreasures);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601965B RID: 104027 RVA: 0x0074DF98 File Offset: 0x0074C198
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_IsSetRandomEvent(IntPtr l)
	{
		int result;
		try
		{
			LevelComponent levelComponent = (LevelComponent)LuaObject.checkSelf(l);
			int wayPointId;
			LuaObject.checkType(l, 2, out wayPointId);
			bool b = levelComponent.m_luaExportHelper.__callBase_IsSetRandomEvent(wayPointId);
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

	// Token: 0x0601965C RID: 104028 RVA: 0x0074E000 File Offset: 0x0074C200
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_MoveToWayPoint(IntPtr l)
	{
		int result;
		try
		{
			LevelComponent levelComponent = (LevelComponent)LuaObject.checkSelf(l);
			int waypointId;
			LuaObject.checkType(l, 2, out waypointId);
			int i = levelComponent.m_luaExportHelper.__callBase_MoveToWayPoint(waypointId);
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

	// Token: 0x0601965D RID: 104029 RVA: 0x0074E068 File Offset: 0x0074C268
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int __callBase_HandleWayPoint(IntPtr l)
	{
		int result;
		try
		{
			LevelComponent levelComponent = (LevelComponent)LuaObject.checkSelf(l);
			ConfigDataWaypointInfo wayPointInfo;
			LuaObject.checkType<ConfigDataWaypointInfo>(l, 2, out wayPointInfo);
			int i = levelComponent.m_luaExportHelper.__callBase_HandleWayPoint(wayPointInfo);
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

	// Token: 0x0601965E RID: 104030 RVA: 0x0074E0D0 File Offset: 0x0074C2D0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_InitRandomEvents(IntPtr l)
	{
		int result;
		try
		{
			LevelComponent levelComponent = (LevelComponent)LuaObject.checkSelf(l);
			List<RandomEvent> randomEvents;
			LuaObject.checkType<List<RandomEvent>>(l, 2, out randomEvents);
			levelComponent.m_luaExportHelper.__callBase_InitRandomEvents(randomEvents);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601965F RID: 104031 RVA: 0x0074E12C File Offset: 0x0074C32C
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int __callBase_GetEventExpiredTime(IntPtr l)
	{
		int result;
		try
		{
			LevelComponent levelComponent = (LevelComponent)LuaObject.checkSelf(l);
			int eventId;
			LuaObject.checkType(l, 2, out eventId);
			long i = levelComponent.m_luaExportHelper.__callBase_GetEventExpiredTime(eventId);
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

	// Token: 0x06019660 RID: 104032 RVA: 0x0074E194 File Offset: 0x0074C394
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int __callBase_GetEventLives(IntPtr l)
	{
		int result;
		try
		{
			LevelComponent levelComponent = (LevelComponent)LuaObject.checkSelf(l);
			int eventId;
			LuaObject.checkType(l, 2, out eventId);
			int i = levelComponent.m_luaExportHelper.__callBase_GetEventLives(eventId);
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

	// Token: 0x06019661 RID: 104033 RVA: 0x0074E1FC File Offset: 0x0074C3FC
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int __callBase_IsRandomEventTimeOut(IntPtr l)
	{
		int result;
		try
		{
			LevelComponent levelComponent = (LevelComponent)LuaObject.checkSelf(l);
			RandomEvent randomEvent;
			LuaObject.checkType<RandomEvent>(l, 2, out randomEvent);
			bool b = levelComponent.m_luaExportHelper.__callBase_IsRandomEventTimeOut(randomEvent);
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

	// Token: 0x06019662 RID: 104034 RVA: 0x0074E264 File Offset: 0x0074C464
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int __callBase_IsRandomEventDead(IntPtr l)
	{
		int result;
		try
		{
			LevelComponent levelComponent = (LevelComponent)LuaObject.checkSelf(l);
			RandomEvent randomEvent;
			LuaObject.checkType<RandomEvent>(l, 2, out randomEvent);
			bool b = levelComponent.m_luaExportHelper.__callBase_IsRandomEventDead(randomEvent);
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

	// Token: 0x06019663 RID: 104035 RVA: 0x0074E2CC File Offset: 0x0074C4CC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_RemoveRandomEvent(IntPtr l)
	{
		int result;
		try
		{
			LevelComponent levelComponent = (LevelComponent)LuaObject.checkSelf(l);
			RandomEvent randomEvent;
			LuaObject.checkType<RandomEvent>(l, 2, out randomEvent);
			levelComponent.m_luaExportHelper.__callBase_RemoveRandomEvent(randomEvent);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06019664 RID: 104036 RVA: 0x0074E328 File Offset: 0x0074C528
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_AddRandomEvent(IntPtr l)
	{
		int result;
		try
		{
			LevelComponent levelComponent = (LevelComponent)LuaObject.checkSelf(l);
			RandomEvent randomEvent;
			LuaObject.checkType<RandomEvent>(l, 2, out randomEvent);
			levelComponent.m_luaExportHelper.__callBase_AddRandomEvent(randomEvent);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06019665 RID: 104037 RVA: 0x0074E384 File Offset: 0x0074C584
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_CanUnLockScenario(IntPtr l)
	{
		int result;
		try
		{
			LevelComponent levelComponent = (LevelComponent)LuaObject.checkSelf(l);
			ConfigDataScenarioInfo scenarioInfo;
			LuaObject.checkType<ConfigDataScenarioInfo>(l, 2, out scenarioInfo);
			int i = levelComponent.m_luaExportHelper.__callBase_CanUnLockScenario(scenarioInfo);
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

	// Token: 0x06019666 RID: 104038 RVA: 0x0074E3EC File Offset: 0x0074C5EC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_HandleScenario(IntPtr l)
	{
		int result;
		try
		{
			LevelComponent levelComponent = (LevelComponent)LuaObject.checkSelf(l);
			int scenarioId;
			LuaObject.checkType(l, 2, out scenarioId);
			bool checkBag;
			LuaObject.checkType(l, 3, out checkBag);
			int i = levelComponent.m_luaExportHelper.__callBase_HandleScenario(scenarioId, checkBag);
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

	// Token: 0x06019667 RID: 104039 RVA: 0x0074E460 File Offset: 0x0074C660
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int __callBase_IsScenarioFinished(IntPtr l)
	{
		int result;
		try
		{
			int total = LuaDLL.lua_gettop(l);
			if (LuaObject.matchType(l, total, 2, typeof(ConfigDataScenarioInfo)))
			{
				LevelComponent levelComponent = (LevelComponent)LuaObject.checkSelf(l);
				ConfigDataScenarioInfo secenarioInfo;
				LuaObject.checkType<ConfigDataScenarioInfo>(l, 2, out secenarioInfo);
				bool b = levelComponent.m_luaExportHelper.__callBase_IsScenarioFinished(secenarioInfo);
				LuaObject.pushValue(l, true);
				LuaObject.pushValue(l, b);
				result = 2;
			}
			else if (LuaObject.matchType(l, total, 2, typeof(int)))
			{
				LevelComponent levelComponent2 = (LevelComponent)LuaObject.checkSelf(l);
				int scenarioId;
				LuaObject.checkType(l, 2, out scenarioId);
				bool b2 = levelComponent2.m_luaExportHelper.__callBase_IsScenarioFinished(scenarioId);
				LuaObject.pushValue(l, true);
				LuaObject.pushValue(l, b2);
				result = 2;
			}
			else
			{
				LuaObject.pushValue(l, false);
				LuaDLL.lua_pushstring(l, "No matched override function __callBase_IsScenarioFinished to call");
				result = 2;
			}
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06019668 RID: 104040 RVA: 0x0074E558 File Offset: 0x0074C758
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int __callBase_IsScenarioInWaypoint(IntPtr l)
	{
		int result;
		try
		{
			LevelComponent levelComponent = (LevelComponent)LuaObject.checkSelf(l);
			int waypointId;
			LuaObject.checkType(l, 2, out waypointId);
			bool b = levelComponent.m_luaExportHelper.__callBase_IsScenarioInWaypoint(waypointId);
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

	// Token: 0x06019669 RID: 104041 RVA: 0x0074E5C0 File Offset: 0x0074C7C0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_GetRandomEvent(IntPtr l)
	{
		int result;
		try
		{
			LevelComponent levelComponent = (LevelComponent)LuaObject.checkSelf(l);
			int wayPointId;
			LuaObject.checkType(l, 2, out wayPointId);
			RandomEvent o = levelComponent.m_luaExportHelper.__callBase_GetRandomEvent(wayPointId);
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

	// Token: 0x0601966A RID: 104042 RVA: 0x0074E628 File Offset: 0x0074C828
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_GetEventId(IntPtr l)
	{
		int result;
		try
		{
			LevelComponent levelComponent = (LevelComponent)LuaObject.checkSelf(l);
			ConfigDataWaypointInfo wayPointInfo;
			LuaObject.checkType<ConfigDataWaypointInfo>(l, 2, out wayPointInfo);
			int i = levelComponent.m_luaExportHelper.__callBase_GetEventId(wayPointInfo);
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

	// Token: 0x0601966B RID: 104043 RVA: 0x0074E690 File Offset: 0x0074C890
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int __callBase_CheckGameFunctionOpenByGM(IntPtr l)
	{
		int result;
		try
		{
			LevelComponent levelComponent = (LevelComponent)LuaObject.checkSelf(l);
			GameFunctionType gameFunctionTypeId;
			LuaObject.checkEnum<GameFunctionType>(l, 2, out gameFunctionTypeId);
			int i = levelComponent.m_luaExportHelper.__callBase_CheckGameFunctionOpenByGM(gameFunctionTypeId);
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

	// Token: 0x0601966C RID: 104044 RVA: 0x0074E6F8 File Offset: 0x0074C8F8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_OnEventComplete(IntPtr l)
	{
		int result;
		try
		{
			LevelComponent levelComponent = (LevelComponent)LuaObject.checkSelf(l);
			int wayPointId;
			LuaObject.checkType(l, 2, out wayPointId);
			RandomEvent randomEvent;
			LuaObject.checkType<RandomEvent>(l, 3, out randomEvent);
			levelComponent.m_luaExportHelper.__callBase_OnEventComplete(wayPointId, randomEvent);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601966D RID: 104045 RVA: 0x0074E764 File Offset: 0x0074C964
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int __callBase_HandleDialogEvent(IntPtr l)
	{
		int result;
		try
		{
			LevelComponent levelComponent = (LevelComponent)LuaObject.checkSelf(l);
			ConfigDataWaypointInfo wayPointInfo;
			LuaObject.checkType<ConfigDataWaypointInfo>(l, 2, out wayPointInfo);
			List<Goods> itemRewards;
			LuaObject.checkType<List<Goods>>(l, 3, out itemRewards);
			int expReward;
			LuaObject.checkType(l, 4, out expReward);
			int goldReward;
			LuaObject.checkType(l, 5, out goldReward);
			int energyCost;
			LuaObject.checkType(l, 6, out energyCost);
			int scenarioId;
			LuaObject.checkType(l, 7, out scenarioId);
			int i = levelComponent.m_luaExportHelper.__callBase_HandleDialogEvent(wayPointInfo, itemRewards, expReward, goldReward, energyCost, scenarioId);
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

	// Token: 0x0601966E RID: 104046 RVA: 0x0074E80C File Offset: 0x0074CA0C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_HandleTresureEvent(IntPtr l)
	{
		int result;
		try
		{
			LevelComponent levelComponent = (LevelComponent)LuaObject.checkSelf(l);
			int wayPointId;
			LuaObject.checkType(l, 2, out wayPointId);
			ConfigDataEventInfo eventInfo;
			LuaObject.checkType<ConfigDataEventInfo>(l, 3, out eventInfo);
			int i = levelComponent.m_luaExportHelper.__callBase_HandleTresureEvent(wayPointId, eventInfo);
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

	// Token: 0x0601966F RID: 104047 RVA: 0x0074E880 File Offset: 0x0074CA80
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_GetEventRewards(IntPtr l)
	{
		int result;
		try
		{
			LevelComponent levelComponent = (LevelComponent)LuaObject.checkSelf(l);
			ConfigDataEventInfo eventInfo;
			LuaObject.checkType<ConfigDataEventInfo>(l, 2, out eventInfo);
			List<Goods> o = levelComponent.m_luaExportHelper.__callBase_GetEventRewards(eventInfo);
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

	// Token: 0x06019670 RID: 104048 RVA: 0x0074E8E8 File Offset: 0x0074CAE8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_CanAttackScenario(IntPtr l)
	{
		int result;
		try
		{
			LevelComponent levelComponent = (LevelComponent)LuaObject.checkSelf(l);
			ConfigDataScenarioInfo scenarioInfo;
			LuaObject.checkType<ConfigDataScenarioInfo>(l, 2, out scenarioInfo);
			bool scenarioFinished;
			LuaObject.checkType(l, 3, out scenarioFinished);
			bool checkBag;
			LuaObject.checkType(l, 4, out checkBag);
			int i = levelComponent.m_luaExportHelper.__callBase_CanAttackScenario(scenarioInfo, scenarioFinished, checkBag);
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

	// Token: 0x06019671 RID: 104049 RVA: 0x0074E96C File Offset: 0x0074CB6C
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int __callBase_CanAttackEventWayPoint(IntPtr l)
	{
		int result;
		try
		{
			LevelComponent levelComponent = (LevelComponent)LuaObject.checkSelf(l);
			int wayPointdId;
			LuaObject.checkType(l, 2, out wayPointdId);
			ConfigDataEventInfo eventyInfo;
			LuaObject.checkType<ConfigDataEventInfo>(l, 3, out eventyInfo);
			int i = levelComponent.m_luaExportHelper.__callBase_CanAttackEventWayPoint(wayPointdId, eventyInfo);
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

	// Token: 0x06019672 RID: 104050 RVA: 0x0074E9E0 File Offset: 0x0074CBE0
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int __callBase_CanMoveToWayPoint(IntPtr l)
	{
		int result;
		try
		{
			LevelComponent levelComponent = (LevelComponent)LuaObject.checkSelf(l);
			int destWayPointId;
			LuaObject.checkType(l, 2, out destWayPointId);
			int i = levelComponent.m_luaExportHelper.__callBase_CanMoveToWayPoint(destWayPointId);
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

	// Token: 0x06019673 RID: 104051 RVA: 0x0074EA48 File Offset: 0x0074CC48
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_CanMoveToWayPointExistRandomEvent(IntPtr l)
	{
		int result;
		try
		{
			LevelComponent levelComponent = (LevelComponent)LuaObject.checkSelf(l);
			int destWayPointId;
			LuaObject.checkType(l, 2, out destWayPointId);
			int i = levelComponent.m_luaExportHelper.__callBase_CanMoveToWayPointExistRandomEvent(destWayPointId);
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

	// Token: 0x06019674 RID: 104052 RVA: 0x0074EAB0 File Offset: 0x0074CCB0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_OnCompleteWayPointEvent(IntPtr l)
	{
		int result;
		try
		{
			LevelComponent levelComponent = (LevelComponent)LuaObject.checkSelf(l);
			levelComponent.m_luaExportHelper.__callBase_OnCompleteWayPointEvent();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06019675 RID: 104053 RVA: 0x0074EB04 File Offset: 0x0074CD04
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int __callBase_IsRegionOpen(IntPtr l)
	{
		int result;
		try
		{
			LevelComponent levelComponent = (LevelComponent)LuaObject.checkSelf(l);
			ConfigDataRegionInfo regionInfo;
			LuaObject.checkType<ConfigDataRegionInfo>(l, 2, out regionInfo);
			bool b = levelComponent.m_luaExportHelper.__callBase_IsRegionOpen(regionInfo);
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

	// Token: 0x06019676 RID: 104054 RVA: 0x0074EB6C File Offset: 0x0074CD6C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_OnOpenRegion(IntPtr l)
	{
		int result;
		try
		{
			LevelComponent levelComponent = (LevelComponent)LuaObject.checkSelf(l);
			ConfigDataRegionInfo regionInfo;
			LuaObject.checkType<ConfigDataRegionInfo>(l, 2, out regionInfo);
			levelComponent.m_luaExportHelper.__callBase_OnOpenRegion(regionInfo);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06019677 RID: 104055 RVA: 0x0074EBC8 File Offset: 0x0074CDC8
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int __callBase_GetWayPointStatus(IntPtr l)
	{
		int result;
		try
		{
			LevelComponent levelComponent = (LevelComponent)LuaObject.checkSelf(l);
			int wayPointId;
			LuaObject.checkType(l, 2, out wayPointId);
			WayPointStatus e = levelComponent.m_luaExportHelper.__callBase_GetWayPointStatus(wayPointId);
			LuaObject.pushValue(l, true);
			LuaObject.pushEnum(l, (int)e);
			result = 2;
		}
		catch (Exception e2)
		{
			result = LuaObject.error(l, e2);
		}
		return result;
	}

	// Token: 0x06019678 RID: 104056 RVA: 0x0074EC30 File Offset: 0x0074CE30
	[Preserve]
	public static void reg(IntPtr l)
	{
		LuaObject.getTypeTable(l, "BlackJack.ProjectL.PlayerContext.LevelComponent");
		if (Lua_BlackJack_ProjectL_PlayerContext_LevelComponent.<>f__mg$cache0 == null)
		{
			Lua_BlackJack_ProjectL_PlayerContext_LevelComponent.<>f__mg$cache0 = new LuaCSFunction(Lua_BlackJack_ProjectL_PlayerContext_LevelComponent.Init);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_PlayerContext_LevelComponent.<>f__mg$cache0);
		if (Lua_BlackJack_ProjectL_PlayerContext_LevelComponent.<>f__mg$cache1 == null)
		{
			Lua_BlackJack_ProjectL_PlayerContext_LevelComponent.<>f__mg$cache1 = new LuaCSFunction(Lua_BlackJack_ProjectL_PlayerContext_LevelComponent.PostInit);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_PlayerContext_LevelComponent.<>f__mg$cache1);
		if (Lua_BlackJack_ProjectL_PlayerContext_LevelComponent.<>f__mg$cache2 == null)
		{
			Lua_BlackJack_ProjectL_PlayerContext_LevelComponent.<>f__mg$cache2 = new LuaCSFunction(Lua_BlackJack_ProjectL_PlayerContext_LevelComponent.DeInit);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_PlayerContext_LevelComponent.<>f__mg$cache2);
		if (Lua_BlackJack_ProjectL_PlayerContext_LevelComponent.<>f__mg$cache3 == null)
		{
			Lua_BlackJack_ProjectL_PlayerContext_LevelComponent.<>f__mg$cache3 = new LuaCSFunction(Lua_BlackJack_ProjectL_PlayerContext_LevelComponent.Tick);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_PlayerContext_LevelComponent.<>f__mg$cache3);
		if (Lua_BlackJack_ProjectL_PlayerContext_LevelComponent.<>f__mg$cache4 == null)
		{
			Lua_BlackJack_ProjectL_PlayerContext_LevelComponent.<>f__mg$cache4 = new LuaCSFunction(Lua_BlackJack_ProjectL_PlayerContext_LevelComponent.DeSerialize);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_PlayerContext_LevelComponent.<>f__mg$cache4);
		if (Lua_BlackJack_ProjectL_PlayerContext_LevelComponent.<>f__mg$cache5 == null)
		{
			Lua_BlackJack_ProjectL_PlayerContext_LevelComponent.<>f__mg$cache5 = new LuaCSFunction(Lua_BlackJack_ProjectL_PlayerContext_LevelComponent.GetDSVersion);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_PlayerContext_LevelComponent.<>f__mg$cache5);
		if (Lua_BlackJack_ProjectL_PlayerContext_LevelComponent.<>f__mg$cache6 == null)
		{
			Lua_BlackJack_ProjectL_PlayerContext_LevelComponent.<>f__mg$cache6 = new LuaCSFunction(Lua_BlackJack_ProjectL_PlayerContext_LevelComponent.CanAttackScenario);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_PlayerContext_LevelComponent.<>f__mg$cache6);
		if (Lua_BlackJack_ProjectL_PlayerContext_LevelComponent.<>f__mg$cache7 == null)
		{
			Lua_BlackJack_ProjectL_PlayerContext_LevelComponent.<>f__mg$cache7 = new LuaCSFunction(Lua_BlackJack_ProjectL_PlayerContext_LevelComponent.CanAttackEventWayPoint);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_PlayerContext_LevelComponent.<>f__mg$cache7);
		if (Lua_BlackJack_ProjectL_PlayerContext_LevelComponent.<>f__mg$cache8 == null)
		{
			Lua_BlackJack_ProjectL_PlayerContext_LevelComponent.<>f__mg$cache8 = new LuaCSFunction(Lua_BlackJack_ProjectL_PlayerContext_LevelComponent.SetBattleWayPointSuccessful);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_PlayerContext_LevelComponent.<>f__mg$cache8);
		if (Lua_BlackJack_ProjectL_PlayerContext_LevelComponent.<>f__mg$cache9 == null)
		{
			Lua_BlackJack_ProjectL_PlayerContext_LevelComponent.<>f__mg$cache9 = new LuaCSFunction(Lua_BlackJack_ProjectL_PlayerContext_LevelComponent.IsRegionOpen);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_PlayerContext_LevelComponent.<>f__mg$cache9);
		if (Lua_BlackJack_ProjectL_PlayerContext_LevelComponent.<>f__mg$cacheA == null)
		{
			Lua_BlackJack_ProjectL_PlayerContext_LevelComponent.<>f__mg$cacheA = new LuaCSFunction(Lua_BlackJack_ProjectL_PlayerContext_LevelComponent.GetWaypointStatus);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_PlayerContext_LevelComponent.<>f__mg$cacheA);
		if (Lua_BlackJack_ProjectL_PlayerContext_LevelComponent.<>f__mg$cacheB == null)
		{
			Lua_BlackJack_ProjectL_PlayerContext_LevelComponent.<>f__mg$cacheB = new LuaCSFunction(Lua_BlackJack_ProjectL_PlayerContext_LevelComponent.GetPlayerCurrentWaypointInfo);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_PlayerContext_LevelComponent.<>f__mg$cacheB);
		if (Lua_BlackJack_ProjectL_PlayerContext_LevelComponent.<>f__mg$cacheC == null)
		{
			Lua_BlackJack_ProjectL_PlayerContext_LevelComponent.<>f__mg$cacheC = new LuaCSFunction(Lua_BlackJack_ProjectL_PlayerContext_LevelComponent.GetLastFinishedScenarioInfo);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_PlayerContext_LevelComponent.<>f__mg$cacheC);
		if (Lua_BlackJack_ProjectL_PlayerContext_LevelComponent.<>f__mg$cacheD == null)
		{
			Lua_BlackJack_ProjectL_PlayerContext_LevelComponent.<>f__mg$cacheD = new LuaCSFunction(Lua_BlackJack_ProjectL_PlayerContext_LevelComponent.SetFinishedScenario);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_PlayerContext_LevelComponent.<>f__mg$cacheD);
		if (Lua_BlackJack_ProjectL_PlayerContext_LevelComponent.<>f__mg$cacheE == null)
		{
			Lua_BlackJack_ProjectL_PlayerContext_LevelComponent.<>f__mg$cacheE = new LuaCSFunction(Lua_BlackJack_ProjectL_PlayerContext_LevelComponent.FinishBattleWayPoint);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_PlayerContext_LevelComponent.<>f__mg$cacheE);
		if (Lua_BlackJack_ProjectL_PlayerContext_LevelComponent.<>f__mg$cacheF == null)
		{
			Lua_BlackJack_ProjectL_PlayerContext_LevelComponent.<>f__mg$cacheF = new LuaCSFunction(Lua_BlackJack_ProjectL_PlayerContext_LevelComponent.HandleDialogEvent);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_PlayerContext_LevelComponent.<>f__mg$cacheF);
		if (Lua_BlackJack_ProjectL_PlayerContext_LevelComponent.<>f__mg$cache10 == null)
		{
			Lua_BlackJack_ProjectL_PlayerContext_LevelComponent.<>f__mg$cache10 = new LuaCSFunction(Lua_BlackJack_ProjectL_PlayerContext_LevelComponent.HandleTresureEvent);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_PlayerContext_LevelComponent.<>f__mg$cache10);
		if (Lua_BlackJack_ProjectL_PlayerContext_LevelComponent.<>f__mg$cache11 == null)
		{
			Lua_BlackJack_ProjectL_PlayerContext_LevelComponent.<>f__mg$cache11 = new LuaCSFunction(Lua_BlackJack_ProjectL_PlayerContext_LevelComponent.__callBase_GetName);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_PlayerContext_LevelComponent.<>f__mg$cache11);
		if (Lua_BlackJack_ProjectL_PlayerContext_LevelComponent.<>f__mg$cache12 == null)
		{
			Lua_BlackJack_ProjectL_PlayerContext_LevelComponent.<>f__mg$cache12 = new LuaCSFunction(Lua_BlackJack_ProjectL_PlayerContext_LevelComponent.__callBase_Init);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_PlayerContext_LevelComponent.<>f__mg$cache12);
		if (Lua_BlackJack_ProjectL_PlayerContext_LevelComponent.<>f__mg$cache13 == null)
		{
			Lua_BlackJack_ProjectL_PlayerContext_LevelComponent.<>f__mg$cache13 = new LuaCSFunction(Lua_BlackJack_ProjectL_PlayerContext_LevelComponent.__callBase_PostInit);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_PlayerContext_LevelComponent.<>f__mg$cache13);
		if (Lua_BlackJack_ProjectL_PlayerContext_LevelComponent.<>f__mg$cache14 == null)
		{
			Lua_BlackJack_ProjectL_PlayerContext_LevelComponent.<>f__mg$cache14 = new LuaCSFunction(Lua_BlackJack_ProjectL_PlayerContext_LevelComponent.__callBase_DeInit);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_PlayerContext_LevelComponent.<>f__mg$cache14);
		if (Lua_BlackJack_ProjectL_PlayerContext_LevelComponent.<>f__mg$cache15 == null)
		{
			Lua_BlackJack_ProjectL_PlayerContext_LevelComponent.<>f__mg$cache15 = new LuaCSFunction(Lua_BlackJack_ProjectL_PlayerContext_LevelComponent.__callBase_Tick);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_PlayerContext_LevelComponent.<>f__mg$cache15);
		if (Lua_BlackJack_ProjectL_PlayerContext_LevelComponent.<>f__mg$cache16 == null)
		{
			Lua_BlackJack_ProjectL_PlayerContext_LevelComponent.<>f__mg$cache16 = new LuaCSFunction(Lua_BlackJack_ProjectL_PlayerContext_LevelComponent.__callBase_PostDeSerialize);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_PlayerContext_LevelComponent.<>f__mg$cache16);
		if (Lua_BlackJack_ProjectL_PlayerContext_LevelComponent.<>f__mg$cache17 == null)
		{
			Lua_BlackJack_ProjectL_PlayerContext_LevelComponent.<>f__mg$cache17 = new LuaCSFunction(Lua_BlackJack_ProjectL_PlayerContext_LevelComponent.__callBase_IsWayPointArrived);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_PlayerContext_LevelComponent.<>f__mg$cache17);
		if (Lua_BlackJack_ProjectL_PlayerContext_LevelComponent.<>f__mg$cache18 == null)
		{
			Lua_BlackJack_ProjectL_PlayerContext_LevelComponent.<>f__mg$cache18 = new LuaCSFunction(Lua_BlackJack_ProjectL_PlayerContext_LevelComponent.__callBase_OutPutRandomEventOperateLog);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_PlayerContext_LevelComponent.<>f__mg$cache18);
		if (Lua_BlackJack_ProjectL_PlayerContext_LevelComponent.<>f__mg$cache19 == null)
		{
			Lua_BlackJack_ProjectL_PlayerContext_LevelComponent.<>f__mg$cache19 = new LuaCSFunction(Lua_BlackJack_ProjectL_PlayerContext_LevelComponent.__callBase_InitLevelInfo);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_PlayerContext_LevelComponent.<>f__mg$cache19);
		if (Lua_BlackJack_ProjectL_PlayerContext_LevelComponent.<>f__mg$cache1A == null)
		{
			Lua_BlackJack_ProjectL_PlayerContext_LevelComponent.<>f__mg$cache1A = new LuaCSFunction(Lua_BlackJack_ProjectL_PlayerContext_LevelComponent.__callBase_SetArrivedWayPoint);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_PlayerContext_LevelComponent.<>f__mg$cache1A);
		if (Lua_BlackJack_ProjectL_PlayerContext_LevelComponent.<>f__mg$cache1B == null)
		{
			Lua_BlackJack_ProjectL_PlayerContext_LevelComponent.<>f__mg$cache1B = new LuaCSFunction(Lua_BlackJack_ProjectL_PlayerContext_LevelComponent.__callBase_ArriveWayPoint);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_PlayerContext_LevelComponent.<>f__mg$cache1B);
		if (Lua_BlackJack_ProjectL_PlayerContext_LevelComponent.<>f__mg$cache1C == null)
		{
			Lua_BlackJack_ProjectL_PlayerContext_LevelComponent.<>f__mg$cache1C = new LuaCSFunction(Lua_BlackJack_ProjectL_PlayerContext_LevelComponent.__callBase_HasFirstWayPointWithScenario);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_PlayerContext_LevelComponent.<>f__mg$cache1C);
		if (Lua_BlackJack_ProjectL_PlayerContext_LevelComponent.<>f__mg$cache1D == null)
		{
			Lua_BlackJack_ProjectL_PlayerContext_LevelComponent.<>f__mg$cache1D = new LuaCSFunction(Lua_BlackJack_ProjectL_PlayerContext_LevelComponent.__callBase_AddCanMovePublicWayPoint);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_PlayerContext_LevelComponent.<>f__mg$cache1D);
		if (Lua_BlackJack_ProjectL_PlayerContext_LevelComponent.<>f__mg$cache1E == null)
		{
			Lua_BlackJack_ProjectL_PlayerContext_LevelComponent.<>f__mg$cache1E = new LuaCSFunction(Lua_BlackJack_ProjectL_PlayerContext_LevelComponent.__callBase_SetFinishedScenario);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_PlayerContext_LevelComponent.<>f__mg$cache1E);
		if (Lua_BlackJack_ProjectL_PlayerContext_LevelComponent.<>f__mg$cache1F == null)
		{
			Lua_BlackJack_ProjectL_PlayerContext_LevelComponent.<>f__mg$cache1F = new LuaCSFunction(Lua_BlackJack_ProjectL_PlayerContext_LevelComponent.__callBase_GetLastFinishedScenarioId);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_PlayerContext_LevelComponent.<>f__mg$cache1F);
		if (Lua_BlackJack_ProjectL_PlayerContext_LevelComponent.<>f__mg$cache20 == null)
		{
			Lua_BlackJack_ProjectL_PlayerContext_LevelComponent.<>f__mg$cache20 = new LuaCSFunction(Lua_BlackJack_ProjectL_PlayerContext_LevelComponent.__callBase_IsScenarioCompleted);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_PlayerContext_LevelComponent.<>f__mg$cache20);
		if (Lua_BlackJack_ProjectL_PlayerContext_LevelComponent.<>f__mg$cache21 == null)
		{
			Lua_BlackJack_ProjectL_PlayerContext_LevelComponent.<>f__mg$cache21 = new LuaCSFunction(Lua_BlackJack_ProjectL_PlayerContext_LevelComponent.__callBase_GetScenarioId);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_PlayerContext_LevelComponent.<>f__mg$cache21);
		if (Lua_BlackJack_ProjectL_PlayerContext_LevelComponent.<>f__mg$cache22 == null)
		{
			Lua_BlackJack_ProjectL_PlayerContext_LevelComponent.<>f__mg$cache22 = new LuaCSFunction(Lua_BlackJack_ProjectL_PlayerContext_LevelComponent.__callBase_SetBattleWayPointSuccessful);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_PlayerContext_LevelComponent.<>f__mg$cache22);
		if (Lua_BlackJack_ProjectL_PlayerContext_LevelComponent.<>f__mg$cache23 == null)
		{
			Lua_BlackJack_ProjectL_PlayerContext_LevelComponent.<>f__mg$cache23 = new LuaCSFunction(Lua_BlackJack_ProjectL_PlayerContext_LevelComponent.__callBase_IsSetRandomEvent);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_PlayerContext_LevelComponent.<>f__mg$cache23);
		if (Lua_BlackJack_ProjectL_PlayerContext_LevelComponent.<>f__mg$cache24 == null)
		{
			Lua_BlackJack_ProjectL_PlayerContext_LevelComponent.<>f__mg$cache24 = new LuaCSFunction(Lua_BlackJack_ProjectL_PlayerContext_LevelComponent.__callBase_MoveToWayPoint);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_PlayerContext_LevelComponent.<>f__mg$cache24);
		if (Lua_BlackJack_ProjectL_PlayerContext_LevelComponent.<>f__mg$cache25 == null)
		{
			Lua_BlackJack_ProjectL_PlayerContext_LevelComponent.<>f__mg$cache25 = new LuaCSFunction(Lua_BlackJack_ProjectL_PlayerContext_LevelComponent.__callBase_HandleWayPoint);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_PlayerContext_LevelComponent.<>f__mg$cache25);
		if (Lua_BlackJack_ProjectL_PlayerContext_LevelComponent.<>f__mg$cache26 == null)
		{
			Lua_BlackJack_ProjectL_PlayerContext_LevelComponent.<>f__mg$cache26 = new LuaCSFunction(Lua_BlackJack_ProjectL_PlayerContext_LevelComponent.__callBase_InitRandomEvents);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_PlayerContext_LevelComponent.<>f__mg$cache26);
		if (Lua_BlackJack_ProjectL_PlayerContext_LevelComponent.<>f__mg$cache27 == null)
		{
			Lua_BlackJack_ProjectL_PlayerContext_LevelComponent.<>f__mg$cache27 = new LuaCSFunction(Lua_BlackJack_ProjectL_PlayerContext_LevelComponent.__callBase_GetEventExpiredTime);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_PlayerContext_LevelComponent.<>f__mg$cache27);
		if (Lua_BlackJack_ProjectL_PlayerContext_LevelComponent.<>f__mg$cache28 == null)
		{
			Lua_BlackJack_ProjectL_PlayerContext_LevelComponent.<>f__mg$cache28 = new LuaCSFunction(Lua_BlackJack_ProjectL_PlayerContext_LevelComponent.__callBase_GetEventLives);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_PlayerContext_LevelComponent.<>f__mg$cache28);
		if (Lua_BlackJack_ProjectL_PlayerContext_LevelComponent.<>f__mg$cache29 == null)
		{
			Lua_BlackJack_ProjectL_PlayerContext_LevelComponent.<>f__mg$cache29 = new LuaCSFunction(Lua_BlackJack_ProjectL_PlayerContext_LevelComponent.__callBase_IsRandomEventTimeOut);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_PlayerContext_LevelComponent.<>f__mg$cache29);
		if (Lua_BlackJack_ProjectL_PlayerContext_LevelComponent.<>f__mg$cache2A == null)
		{
			Lua_BlackJack_ProjectL_PlayerContext_LevelComponent.<>f__mg$cache2A = new LuaCSFunction(Lua_BlackJack_ProjectL_PlayerContext_LevelComponent.__callBase_IsRandomEventDead);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_PlayerContext_LevelComponent.<>f__mg$cache2A);
		if (Lua_BlackJack_ProjectL_PlayerContext_LevelComponent.<>f__mg$cache2B == null)
		{
			Lua_BlackJack_ProjectL_PlayerContext_LevelComponent.<>f__mg$cache2B = new LuaCSFunction(Lua_BlackJack_ProjectL_PlayerContext_LevelComponent.__callBase_RemoveRandomEvent);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_PlayerContext_LevelComponent.<>f__mg$cache2B);
		if (Lua_BlackJack_ProjectL_PlayerContext_LevelComponent.<>f__mg$cache2C == null)
		{
			Lua_BlackJack_ProjectL_PlayerContext_LevelComponent.<>f__mg$cache2C = new LuaCSFunction(Lua_BlackJack_ProjectL_PlayerContext_LevelComponent.__callBase_AddRandomEvent);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_PlayerContext_LevelComponent.<>f__mg$cache2C);
		if (Lua_BlackJack_ProjectL_PlayerContext_LevelComponent.<>f__mg$cache2D == null)
		{
			Lua_BlackJack_ProjectL_PlayerContext_LevelComponent.<>f__mg$cache2D = new LuaCSFunction(Lua_BlackJack_ProjectL_PlayerContext_LevelComponent.__callBase_CanUnLockScenario);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_PlayerContext_LevelComponent.<>f__mg$cache2D);
		if (Lua_BlackJack_ProjectL_PlayerContext_LevelComponent.<>f__mg$cache2E == null)
		{
			Lua_BlackJack_ProjectL_PlayerContext_LevelComponent.<>f__mg$cache2E = new LuaCSFunction(Lua_BlackJack_ProjectL_PlayerContext_LevelComponent.__callBase_HandleScenario);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_PlayerContext_LevelComponent.<>f__mg$cache2E);
		if (Lua_BlackJack_ProjectL_PlayerContext_LevelComponent.<>f__mg$cache2F == null)
		{
			Lua_BlackJack_ProjectL_PlayerContext_LevelComponent.<>f__mg$cache2F = new LuaCSFunction(Lua_BlackJack_ProjectL_PlayerContext_LevelComponent.__callBase_IsScenarioFinished);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_PlayerContext_LevelComponent.<>f__mg$cache2F);
		if (Lua_BlackJack_ProjectL_PlayerContext_LevelComponent.<>f__mg$cache30 == null)
		{
			Lua_BlackJack_ProjectL_PlayerContext_LevelComponent.<>f__mg$cache30 = new LuaCSFunction(Lua_BlackJack_ProjectL_PlayerContext_LevelComponent.__callBase_IsScenarioInWaypoint);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_PlayerContext_LevelComponent.<>f__mg$cache30);
		if (Lua_BlackJack_ProjectL_PlayerContext_LevelComponent.<>f__mg$cache31 == null)
		{
			Lua_BlackJack_ProjectL_PlayerContext_LevelComponent.<>f__mg$cache31 = new LuaCSFunction(Lua_BlackJack_ProjectL_PlayerContext_LevelComponent.__callBase_GetRandomEvent);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_PlayerContext_LevelComponent.<>f__mg$cache31);
		if (Lua_BlackJack_ProjectL_PlayerContext_LevelComponent.<>f__mg$cache32 == null)
		{
			Lua_BlackJack_ProjectL_PlayerContext_LevelComponent.<>f__mg$cache32 = new LuaCSFunction(Lua_BlackJack_ProjectL_PlayerContext_LevelComponent.__callBase_GetEventId);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_PlayerContext_LevelComponent.<>f__mg$cache32);
		if (Lua_BlackJack_ProjectL_PlayerContext_LevelComponent.<>f__mg$cache33 == null)
		{
			Lua_BlackJack_ProjectL_PlayerContext_LevelComponent.<>f__mg$cache33 = new LuaCSFunction(Lua_BlackJack_ProjectL_PlayerContext_LevelComponent.__callBase_CheckGameFunctionOpenByGM);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_PlayerContext_LevelComponent.<>f__mg$cache33);
		if (Lua_BlackJack_ProjectL_PlayerContext_LevelComponent.<>f__mg$cache34 == null)
		{
			Lua_BlackJack_ProjectL_PlayerContext_LevelComponent.<>f__mg$cache34 = new LuaCSFunction(Lua_BlackJack_ProjectL_PlayerContext_LevelComponent.__callBase_OnEventComplete);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_PlayerContext_LevelComponent.<>f__mg$cache34);
		if (Lua_BlackJack_ProjectL_PlayerContext_LevelComponent.<>f__mg$cache35 == null)
		{
			Lua_BlackJack_ProjectL_PlayerContext_LevelComponent.<>f__mg$cache35 = new LuaCSFunction(Lua_BlackJack_ProjectL_PlayerContext_LevelComponent.__callBase_HandleDialogEvent);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_PlayerContext_LevelComponent.<>f__mg$cache35);
		if (Lua_BlackJack_ProjectL_PlayerContext_LevelComponent.<>f__mg$cache36 == null)
		{
			Lua_BlackJack_ProjectL_PlayerContext_LevelComponent.<>f__mg$cache36 = new LuaCSFunction(Lua_BlackJack_ProjectL_PlayerContext_LevelComponent.__callBase_HandleTresureEvent);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_PlayerContext_LevelComponent.<>f__mg$cache36);
		if (Lua_BlackJack_ProjectL_PlayerContext_LevelComponent.<>f__mg$cache37 == null)
		{
			Lua_BlackJack_ProjectL_PlayerContext_LevelComponent.<>f__mg$cache37 = new LuaCSFunction(Lua_BlackJack_ProjectL_PlayerContext_LevelComponent.__callBase_GetEventRewards);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_PlayerContext_LevelComponent.<>f__mg$cache37);
		if (Lua_BlackJack_ProjectL_PlayerContext_LevelComponent.<>f__mg$cache38 == null)
		{
			Lua_BlackJack_ProjectL_PlayerContext_LevelComponent.<>f__mg$cache38 = new LuaCSFunction(Lua_BlackJack_ProjectL_PlayerContext_LevelComponent.__callBase_CanAttackScenario);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_PlayerContext_LevelComponent.<>f__mg$cache38);
		if (Lua_BlackJack_ProjectL_PlayerContext_LevelComponent.<>f__mg$cache39 == null)
		{
			Lua_BlackJack_ProjectL_PlayerContext_LevelComponent.<>f__mg$cache39 = new LuaCSFunction(Lua_BlackJack_ProjectL_PlayerContext_LevelComponent.__callBase_CanAttackEventWayPoint);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_PlayerContext_LevelComponent.<>f__mg$cache39);
		if (Lua_BlackJack_ProjectL_PlayerContext_LevelComponent.<>f__mg$cache3A == null)
		{
			Lua_BlackJack_ProjectL_PlayerContext_LevelComponent.<>f__mg$cache3A = new LuaCSFunction(Lua_BlackJack_ProjectL_PlayerContext_LevelComponent.__callBase_CanMoveToWayPoint);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_PlayerContext_LevelComponent.<>f__mg$cache3A);
		if (Lua_BlackJack_ProjectL_PlayerContext_LevelComponent.<>f__mg$cache3B == null)
		{
			Lua_BlackJack_ProjectL_PlayerContext_LevelComponent.<>f__mg$cache3B = new LuaCSFunction(Lua_BlackJack_ProjectL_PlayerContext_LevelComponent.__callBase_CanMoveToWayPointExistRandomEvent);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_PlayerContext_LevelComponent.<>f__mg$cache3B);
		if (Lua_BlackJack_ProjectL_PlayerContext_LevelComponent.<>f__mg$cache3C == null)
		{
			Lua_BlackJack_ProjectL_PlayerContext_LevelComponent.<>f__mg$cache3C = new LuaCSFunction(Lua_BlackJack_ProjectL_PlayerContext_LevelComponent.__callBase_OnCompleteWayPointEvent);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_PlayerContext_LevelComponent.<>f__mg$cache3C);
		if (Lua_BlackJack_ProjectL_PlayerContext_LevelComponent.<>f__mg$cache3D == null)
		{
			Lua_BlackJack_ProjectL_PlayerContext_LevelComponent.<>f__mg$cache3D = new LuaCSFunction(Lua_BlackJack_ProjectL_PlayerContext_LevelComponent.__callBase_IsRegionOpen);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_PlayerContext_LevelComponent.<>f__mg$cache3D);
		if (Lua_BlackJack_ProjectL_PlayerContext_LevelComponent.<>f__mg$cache3E == null)
		{
			Lua_BlackJack_ProjectL_PlayerContext_LevelComponent.<>f__mg$cache3E = new LuaCSFunction(Lua_BlackJack_ProjectL_PlayerContext_LevelComponent.__callBase_OnOpenRegion);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_PlayerContext_LevelComponent.<>f__mg$cache3E);
		if (Lua_BlackJack_ProjectL_PlayerContext_LevelComponent.<>f__mg$cache3F == null)
		{
			Lua_BlackJack_ProjectL_PlayerContext_LevelComponent.<>f__mg$cache3F = new LuaCSFunction(Lua_BlackJack_ProjectL_PlayerContext_LevelComponent.__callBase_GetWayPointStatus);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_PlayerContext_LevelComponent.<>f__mg$cache3F);
		if (Lua_BlackJack_ProjectL_PlayerContext_LevelComponent.<>f__mg$cache40 == null)
		{
			Lua_BlackJack_ProjectL_PlayerContext_LevelComponent.<>f__mg$cache40 = new LuaCSFunction(Lua_BlackJack_ProjectL_PlayerContext_LevelComponent.constructor);
		}
		LuaObject.createTypeMetatable(l, Lua_BlackJack_ProjectL_PlayerContext_LevelComponent.<>f__mg$cache40, typeof(LevelComponent), typeof(LevelComponentCommon));
	}

	// Token: 0x0400FA7B RID: 64123
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache0;

	// Token: 0x0400FA7C RID: 64124
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1;

	// Token: 0x0400FA7D RID: 64125
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2;

	// Token: 0x0400FA7E RID: 64126
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3;

	// Token: 0x0400FA7F RID: 64127
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache4;

	// Token: 0x0400FA80 RID: 64128
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache5;

	// Token: 0x0400FA81 RID: 64129
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache6;

	// Token: 0x0400FA82 RID: 64130
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache7;

	// Token: 0x0400FA83 RID: 64131
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache8;

	// Token: 0x0400FA84 RID: 64132
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache9;

	// Token: 0x0400FA85 RID: 64133
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheA;

	// Token: 0x0400FA86 RID: 64134
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheB;

	// Token: 0x0400FA87 RID: 64135
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheC;

	// Token: 0x0400FA88 RID: 64136
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheD;

	// Token: 0x0400FA89 RID: 64137
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheE;

	// Token: 0x0400FA8A RID: 64138
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheF;

	// Token: 0x0400FA8B RID: 64139
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache10;

	// Token: 0x0400FA8C RID: 64140
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache11;

	// Token: 0x0400FA8D RID: 64141
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache12;

	// Token: 0x0400FA8E RID: 64142
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache13;

	// Token: 0x0400FA8F RID: 64143
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache14;

	// Token: 0x0400FA90 RID: 64144
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache15;

	// Token: 0x0400FA91 RID: 64145
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache16;

	// Token: 0x0400FA92 RID: 64146
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache17;

	// Token: 0x0400FA93 RID: 64147
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache18;

	// Token: 0x0400FA94 RID: 64148
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache19;

	// Token: 0x0400FA95 RID: 64149
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1A;

	// Token: 0x0400FA96 RID: 64150
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1B;

	// Token: 0x0400FA97 RID: 64151
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1C;

	// Token: 0x0400FA98 RID: 64152
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1D;

	// Token: 0x0400FA99 RID: 64153
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1E;

	// Token: 0x0400FA9A RID: 64154
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1F;

	// Token: 0x0400FA9B RID: 64155
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache20;

	// Token: 0x0400FA9C RID: 64156
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache21;

	// Token: 0x0400FA9D RID: 64157
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache22;

	// Token: 0x0400FA9E RID: 64158
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache23;

	// Token: 0x0400FA9F RID: 64159
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache24;

	// Token: 0x0400FAA0 RID: 64160
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache25;

	// Token: 0x0400FAA1 RID: 64161
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache26;

	// Token: 0x0400FAA2 RID: 64162
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache27;

	// Token: 0x0400FAA3 RID: 64163
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache28;

	// Token: 0x0400FAA4 RID: 64164
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache29;

	// Token: 0x0400FAA5 RID: 64165
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2A;

	// Token: 0x0400FAA6 RID: 64166
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2B;

	// Token: 0x0400FAA7 RID: 64167
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2C;

	// Token: 0x0400FAA8 RID: 64168
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2D;

	// Token: 0x0400FAA9 RID: 64169
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2E;

	// Token: 0x0400FAAA RID: 64170
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2F;

	// Token: 0x0400FAAB RID: 64171
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache30;

	// Token: 0x0400FAAC RID: 64172
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache31;

	// Token: 0x0400FAAD RID: 64173
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache32;

	// Token: 0x0400FAAE RID: 64174
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache33;

	// Token: 0x0400FAAF RID: 64175
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache34;

	// Token: 0x0400FAB0 RID: 64176
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache35;

	// Token: 0x0400FAB1 RID: 64177
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache36;

	// Token: 0x0400FAB2 RID: 64178
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache37;

	// Token: 0x0400FAB3 RID: 64179
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache38;

	// Token: 0x0400FAB4 RID: 64180
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache39;

	// Token: 0x0400FAB5 RID: 64181
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3A;

	// Token: 0x0400FAB6 RID: 64182
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3B;

	// Token: 0x0400FAB7 RID: 64183
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3C;

	// Token: 0x0400FAB8 RID: 64184
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3D;

	// Token: 0x0400FAB9 RID: 64185
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3E;

	// Token: 0x0400FABA RID: 64186
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3F;

	// Token: 0x0400FABB RID: 64187
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache40;
}
