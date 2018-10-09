using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using BlackJack.ConfigData;
using BlackJack.ProjectL.Common;
using SLua;
using UnityEngine.Scripting;

// Token: 0x0200124A RID: 4682
[Preserve]
public class Lua_BlackJack_ProjectL_Common_LevelComponentCommon : LuaObject
{
	// Token: 0x06018542 RID: 99650 RVA: 0x006CDF6C File Offset: 0x006CC16C
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int constructor(IntPtr l)
	{
		int result;
		try
		{
			LevelComponentCommon o = new LevelComponentCommon();
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

	// Token: 0x06018543 RID: 99651 RVA: 0x006CDFB4 File Offset: 0x006CC1B4
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int GetName(IntPtr l)
	{
		int result;
		try
		{
			LevelComponentCommon levelComponentCommon = (LevelComponentCommon)LuaObject.checkSelf(l);
			string name = levelComponentCommon.GetName();
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, name);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06018544 RID: 99652 RVA: 0x006CE008 File Offset: 0x006CC208
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int Init(IntPtr l)
	{
		int result;
		try
		{
			LevelComponentCommon levelComponentCommon = (LevelComponentCommon)LuaObject.checkSelf(l);
			levelComponentCommon.Init();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06018545 RID: 99653 RVA: 0x006CE054 File Offset: 0x006CC254
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int PostInit(IntPtr l)
	{
		int result;
		try
		{
			LevelComponentCommon levelComponentCommon = (LevelComponentCommon)LuaObject.checkSelf(l);
			levelComponentCommon.PostInit();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06018546 RID: 99654 RVA: 0x006CE0A0 File Offset: 0x006CC2A0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int DeInit(IntPtr l)
	{
		int result;
		try
		{
			LevelComponentCommon levelComponentCommon = (LevelComponentCommon)LuaObject.checkSelf(l);
			levelComponentCommon.DeInit();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06018547 RID: 99655 RVA: 0x006CE0EC File Offset: 0x006CC2EC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int Tick(IntPtr l)
	{
		int result;
		try
		{
			LevelComponentCommon levelComponentCommon = (LevelComponentCommon)LuaObject.checkSelf(l);
			uint deltaMillisecond;
			LuaObject.checkType(l, 2, out deltaMillisecond);
			levelComponentCommon.Tick(deltaMillisecond);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06018548 RID: 99656 RVA: 0x006CE144 File Offset: 0x006CC344
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int PostDeSerialize(IntPtr l)
	{
		int result;
		try
		{
			LevelComponentCommon levelComponentCommon = (LevelComponentCommon)LuaObject.checkSelf(l);
			levelComponentCommon.PostDeSerialize();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06018549 RID: 99657 RVA: 0x006CE190 File Offset: 0x006CC390
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int IsWayPointArrived(IntPtr l)
	{
		int result;
		try
		{
			LevelComponentCommon levelComponentCommon = (LevelComponentCommon)LuaObject.checkSelf(l);
			int wayPointId;
			LuaObject.checkType(l, 2, out wayPointId);
			bool b = levelComponentCommon.IsWayPointArrived(wayPointId);
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

	// Token: 0x0601854A RID: 99658 RVA: 0x006CE1F4 File Offset: 0x006CC3F4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int ArriveWayPoint(IntPtr l)
	{
		int result;
		try
		{
			LevelComponentCommon levelComponentCommon = (LevelComponentCommon)LuaObject.checkSelf(l);
			int wayPointId;
			LuaObject.checkType(l, 2, out wayPointId);
			levelComponentCommon.ArriveWayPoint(wayPointId);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601854B RID: 99659 RVA: 0x006CE24C File Offset: 0x006CC44C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int AddCanMovePublicWayPoint(IntPtr l)
	{
		int result;
		try
		{
			LevelComponentCommon levelComponentCommon = (LevelComponentCommon)LuaObject.checkSelf(l);
			int newId;
			LuaObject.checkType(l, 2, out newId);
			levelComponentCommon.AddCanMovePublicWayPoint(newId);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601854C RID: 99660 RVA: 0x006CE2A4 File Offset: 0x006CC4A4
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int SetFinishedScenario(IntPtr l)
	{
		int result;
		try
		{
			LevelComponentCommon levelComponentCommon = (LevelComponentCommon)LuaObject.checkSelf(l);
			ConfigDataScenarioInfo finishedScenario;
			LuaObject.checkType<ConfigDataScenarioInfo>(l, 2, out finishedScenario);
			levelComponentCommon.SetFinishedScenario(finishedScenario);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601854D RID: 99661 RVA: 0x006CE2FC File Offset: 0x006CC4FC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int GetLastFinishedScenarioId(IntPtr l)
	{
		int result;
		try
		{
			LevelComponentCommon levelComponentCommon = (LevelComponentCommon)LuaObject.checkSelf(l);
			int lastFinishedScenarioId = levelComponentCommon.GetLastFinishedScenarioId();
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, lastFinishedScenarioId);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601854E RID: 99662 RVA: 0x006CE350 File Offset: 0x006CC550
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int IsScenarioCompleted(IntPtr l)
	{
		int result;
		try
		{
			LevelComponentCommon levelComponentCommon = (LevelComponentCommon)LuaObject.checkSelf(l);
			int scenarioId;
			LuaObject.checkType(l, 2, out scenarioId);
			bool b = levelComponentCommon.IsScenarioCompleted(scenarioId);
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

	// Token: 0x0601854F RID: 99663 RVA: 0x006CE3B4 File Offset: 0x006CC5B4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int GetScenarioId(IntPtr l)
	{
		int result;
		try
		{
			LevelComponentCommon levelComponentCommon = (LevelComponentCommon)LuaObject.checkSelf(l);
			int scenarioId = levelComponentCommon.GetScenarioId();
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, scenarioId);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06018550 RID: 99664 RVA: 0x006CE408 File Offset: 0x006CC608
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int SetBattleWayPointSuccessful(IntPtr l)
	{
		int result;
		try
		{
			LevelComponentCommon levelComponentCommon = (LevelComponentCommon)LuaObject.checkSelf(l);
			ConfigDataWaypointInfo wayPointInfo;
			LuaObject.checkType<ConfigDataWaypointInfo>(l, 2, out wayPointInfo);
			List<int> battleTreasures;
			LuaObject.checkType<List<int>>(l, 3, out battleTreasures);
			levelComponentCommon.SetBattleWayPointSuccessful(wayPointInfo, battleTreasures);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06018551 RID: 99665 RVA: 0x006CE46C File Offset: 0x006CC66C
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int IsSetRandomEvent(IntPtr l)
	{
		int result;
		try
		{
			LevelComponentCommon levelComponentCommon = (LevelComponentCommon)LuaObject.checkSelf(l);
			int wayPointId;
			LuaObject.checkType(l, 2, out wayPointId);
			bool b = levelComponentCommon.IsSetRandomEvent(wayPointId);
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

	// Token: 0x06018552 RID: 99666 RVA: 0x006CE4D0 File Offset: 0x006CC6D0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int MoveToWayPoint(IntPtr l)
	{
		int result;
		try
		{
			LevelComponentCommon levelComponentCommon = (LevelComponentCommon)LuaObject.checkSelf(l);
			int waypointId;
			LuaObject.checkType(l, 2, out waypointId);
			int i = levelComponentCommon.MoveToWayPoint(waypointId);
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

	// Token: 0x06018553 RID: 99667 RVA: 0x006CE534 File Offset: 0x006CC734
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int HandleWayPoint(IntPtr l)
	{
		int result;
		try
		{
			LevelComponentCommon levelComponentCommon = (LevelComponentCommon)LuaObject.checkSelf(l);
			ConfigDataWaypointInfo wayPointInfo;
			LuaObject.checkType<ConfigDataWaypointInfo>(l, 2, out wayPointInfo);
			int i = levelComponentCommon.HandleWayPoint(wayPointInfo);
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

	// Token: 0x06018554 RID: 99668 RVA: 0x006CE598 File Offset: 0x006CC798
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int IsRandomEventTimeOut(IntPtr l)
	{
		int result;
		try
		{
			LevelComponentCommon levelComponentCommon = (LevelComponentCommon)LuaObject.checkSelf(l);
			RandomEvent randomEvent;
			LuaObject.checkType<RandomEvent>(l, 2, out randomEvent);
			bool b = levelComponentCommon.IsRandomEventTimeOut(randomEvent);
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

	// Token: 0x06018555 RID: 99669 RVA: 0x006CE5FC File Offset: 0x006CC7FC
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int IsRandomEventDead(IntPtr l)
	{
		int result;
		try
		{
			LevelComponentCommon levelComponentCommon = (LevelComponentCommon)LuaObject.checkSelf(l);
			RandomEvent randomEvent;
			LuaObject.checkType<RandomEvent>(l, 2, out randomEvent);
			bool b = levelComponentCommon.IsRandomEventDead(randomEvent);
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

	// Token: 0x06018556 RID: 99670 RVA: 0x006CE660 File Offset: 0x006CC860
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int RemoveRandomEvent(IntPtr l)
	{
		int result;
		try
		{
			LevelComponentCommon levelComponentCommon = (LevelComponentCommon)LuaObject.checkSelf(l);
			RandomEvent randomEvent;
			LuaObject.checkType<RandomEvent>(l, 2, out randomEvent);
			levelComponentCommon.RemoveRandomEvent(randomEvent);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06018557 RID: 99671 RVA: 0x006CE6B8 File Offset: 0x006CC8B8
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int AddRandomEvent(IntPtr l)
	{
		int result;
		try
		{
			LevelComponentCommon levelComponentCommon = (LevelComponentCommon)LuaObject.checkSelf(l);
			RandomEvent randomEvent;
			LuaObject.checkType<RandomEvent>(l, 2, out randomEvent);
			levelComponentCommon.AddRandomEvent(randomEvent);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06018558 RID: 99672 RVA: 0x006CE710 File Offset: 0x006CC910
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int CanUnLockScenario(IntPtr l)
	{
		int result;
		try
		{
			LevelComponentCommon levelComponentCommon = (LevelComponentCommon)LuaObject.checkSelf(l);
			ConfigDataScenarioInfo scenarioInfo;
			LuaObject.checkType<ConfigDataScenarioInfo>(l, 2, out scenarioInfo);
			int i = levelComponentCommon.CanUnLockScenario(scenarioInfo);
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

	// Token: 0x06018559 RID: 99673 RVA: 0x006CE774 File Offset: 0x006CC974
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int HandleScenario(IntPtr l)
	{
		int result;
		try
		{
			LevelComponentCommon levelComponentCommon = (LevelComponentCommon)LuaObject.checkSelf(l);
			int scenarioId;
			LuaObject.checkType(l, 2, out scenarioId);
			bool checkBag;
			LuaObject.checkType(l, 3, out checkBag);
			int i = levelComponentCommon.HandleScenario(scenarioId, checkBag);
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

	// Token: 0x0601855A RID: 99674 RVA: 0x006CE7E4 File Offset: 0x006CC9E4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int IsScenarioFinished(IntPtr l)
	{
		int result;
		try
		{
			LevelComponentCommon levelComponentCommon = (LevelComponentCommon)LuaObject.checkSelf(l);
			int scenarioId;
			LuaObject.checkType(l, 2, out scenarioId);
			bool b = levelComponentCommon.IsScenarioFinished(scenarioId);
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

	// Token: 0x0601855B RID: 99675 RVA: 0x006CE848 File Offset: 0x006CCA48
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int IsScenarioInWaypoint(IntPtr l)
	{
		int result;
		try
		{
			LevelComponentCommon levelComponentCommon = (LevelComponentCommon)LuaObject.checkSelf(l);
			int waypointId;
			LuaObject.checkType(l, 2, out waypointId);
			bool b = levelComponentCommon.IsScenarioInWaypoint(waypointId);
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

	// Token: 0x0601855C RID: 99676 RVA: 0x006CE8AC File Offset: 0x006CCAAC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int GetRandomEvent(IntPtr l)
	{
		int result;
		try
		{
			LevelComponentCommon levelComponentCommon = (LevelComponentCommon)LuaObject.checkSelf(l);
			int wayPointId;
			LuaObject.checkType(l, 2, out wayPointId);
			RandomEvent randomEvent = levelComponentCommon.GetRandomEvent(wayPointId);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, randomEvent);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601855D RID: 99677 RVA: 0x006CE910 File Offset: 0x006CCB10
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int GetEventId(IntPtr l)
	{
		int result;
		try
		{
			LevelComponentCommon levelComponentCommon = (LevelComponentCommon)LuaObject.checkSelf(l);
			ConfigDataWaypointInfo wayPointInfo;
			LuaObject.checkType<ConfigDataWaypointInfo>(l, 2, out wayPointInfo);
			int eventId = levelComponentCommon.GetEventId(wayPointInfo);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, eventId);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601855E RID: 99678 RVA: 0x006CE974 File Offset: 0x006CCB74
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int OnEventComplete(IntPtr l)
	{
		int result;
		try
		{
			LevelComponentCommon levelComponentCommon = (LevelComponentCommon)LuaObject.checkSelf(l);
			int wayPointId;
			LuaObject.checkType(l, 2, out wayPointId);
			RandomEvent randomEvent;
			LuaObject.checkType<RandomEvent>(l, 3, out randomEvent);
			levelComponentCommon.OnEventComplete(wayPointId, randomEvent);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601855F RID: 99679 RVA: 0x006CE9D8 File Offset: 0x006CCBD8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int CanAttackScenario(IntPtr l)
	{
		int result;
		try
		{
			LevelComponentCommon levelComponentCommon = (LevelComponentCommon)LuaObject.checkSelf(l);
			ConfigDataScenarioInfo scenarioInfo;
			LuaObject.checkType<ConfigDataScenarioInfo>(l, 2, out scenarioInfo);
			bool scenarioFinished;
			LuaObject.checkType(l, 3, out scenarioFinished);
			bool checkBag;
			LuaObject.checkType(l, 4, out checkBag);
			int i = levelComponentCommon.CanAttackScenario(scenarioInfo, scenarioFinished, checkBag);
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

	// Token: 0x06018560 RID: 99680 RVA: 0x006CEA54 File Offset: 0x006CCC54
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int CanAttackEventWayPoint(IntPtr l)
	{
		int result;
		try
		{
			LevelComponentCommon levelComponentCommon = (LevelComponentCommon)LuaObject.checkSelf(l);
			int wayPointdId;
			LuaObject.checkType(l, 2, out wayPointdId);
			ConfigDataEventInfo eventyInfo;
			LuaObject.checkType<ConfigDataEventInfo>(l, 3, out eventyInfo);
			int i = levelComponentCommon.CanAttackEventWayPoint(wayPointdId, eventyInfo);
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

	// Token: 0x06018561 RID: 99681 RVA: 0x006CEAC4 File Offset: 0x006CCCC4
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int OnCompleteWayPointEvent(IntPtr l)
	{
		int result;
		try
		{
			LevelComponentCommon levelComponentCommon = (LevelComponentCommon)LuaObject.checkSelf(l);
			levelComponentCommon.OnCompleteWayPointEvent();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06018562 RID: 99682 RVA: 0x006CEB10 File Offset: 0x006CCD10
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int IsRegionOpen(IntPtr l)
	{
		int result;
		try
		{
			LevelComponentCommon levelComponentCommon = (LevelComponentCommon)LuaObject.checkSelf(l);
			ConfigDataRegionInfo regionInfo;
			LuaObject.checkType<ConfigDataRegionInfo>(l, 2, out regionInfo);
			bool b = levelComponentCommon.IsRegionOpen(regionInfo);
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

	// Token: 0x06018563 RID: 99683 RVA: 0x006CEB74 File Offset: 0x006CCD74
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int GetWayPointStatus(IntPtr l)
	{
		int result;
		try
		{
			LevelComponentCommon levelComponentCommon = (LevelComponentCommon)LuaObject.checkSelf(l);
			int wayPointId;
			LuaObject.checkType(l, 2, out wayPointId);
			WayPointStatus wayPointStatus = levelComponentCommon.GetWayPointStatus(wayPointId);
			LuaObject.pushValue(l, true);
			LuaObject.pushEnum(l, (int)wayPointStatus);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06018564 RID: 99684 RVA: 0x006CEBD8 File Offset: 0x006CCDD8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int OutPutRandomEventOperateLog(IntPtr l)
	{
		int result;
		try
		{
			LevelComponentCommon levelComponentCommon = (LevelComponentCommon)LuaObject.checkSelf(l);
			int eventId;
			LuaObject.checkType(l, 2, out eventId);
			RandomEventStatus status;
			LuaObject.checkEnum<RandomEventStatus>(l, 3, out status);
			List<Goods> rewards;
			LuaObject.checkType<List<Goods>>(l, 4, out rewards);
			levelComponentCommon.m_luaExportHelper.OutPutRandomEventOperateLog(eventId, status, rewards);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06018565 RID: 99685 RVA: 0x006CEC50 File Offset: 0x006CCE50
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int InitLevelInfo(IntPtr l)
	{
		int result;
		try
		{
			LevelComponentCommon levelComponentCommon = (LevelComponentCommon)LuaObject.checkSelf(l);
			List<int> arrivedWayPoints;
			LuaObject.checkType<List<int>>(l, 2, out arrivedWayPoints);
			levelComponentCommon.m_luaExportHelper.InitLevelInfo(arrivedWayPoints);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06018566 RID: 99686 RVA: 0x006CECAC File Offset: 0x006CCEAC
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int SetArrivedWayPoint(IntPtr l)
	{
		int result;
		try
		{
			LevelComponentCommon levelComponentCommon = (LevelComponentCommon)LuaObject.checkSelf(l);
			int arrivedWayPoint;
			LuaObject.checkType(l, 2, out arrivedWayPoint);
			levelComponentCommon.m_luaExportHelper.SetArrivedWayPoint(arrivedWayPoint);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06018567 RID: 99687 RVA: 0x006CED08 File Offset: 0x006CCF08
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int HasFirstWayPointWithScenario(IntPtr l)
	{
		int result;
		try
		{
			LevelComponentCommon levelComponentCommon = (LevelComponentCommon)LuaObject.checkSelf(l);
			bool b = levelComponentCommon.m_luaExportHelper.HasFirstWayPointWithScenario();
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

	// Token: 0x06018568 RID: 99688 RVA: 0x006CED64 File Offset: 0x006CCF64
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int IsExistRandomEvent(IntPtr l)
	{
		int result;
		try
		{
			LevelComponentCommon levelComponentCommon = (LevelComponentCommon)LuaObject.checkSelf(l);
			bool b = levelComponentCommon.m_luaExportHelper.IsExistRandomEvent();
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

	// Token: 0x06018569 RID: 99689 RVA: 0x006CEDC0 File Offset: 0x006CCFC0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int InitRandomEvents(IntPtr l)
	{
		int result;
		try
		{
			LevelComponentCommon levelComponentCommon = (LevelComponentCommon)LuaObject.checkSelf(l);
			List<RandomEvent> randomEvents;
			LuaObject.checkType<List<RandomEvent>>(l, 2, out randomEvents);
			levelComponentCommon.m_luaExportHelper.InitRandomEvents(randomEvents);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601856A RID: 99690 RVA: 0x006CEE1C File Offset: 0x006CD01C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int PreInitRandomEvent(IntPtr l)
	{
		int result;
		try
		{
			LevelComponentCommon levelComponentCommon = (LevelComponentCommon)LuaObject.checkSelf(l);
			RandomEvent randomEvent;
			LuaObject.checkType<RandomEvent>(l, 2, out randomEvent);
			levelComponentCommon.m_luaExportHelper.PreInitRandomEvent(randomEvent);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601856B RID: 99691 RVA: 0x006CEE78 File Offset: 0x006CD078
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int GetEventExpiredTime(IntPtr l)
	{
		int result;
		try
		{
			LevelComponentCommon levelComponentCommon = (LevelComponentCommon)LuaObject.checkSelf(l);
			int eventId;
			LuaObject.checkType(l, 2, out eventId);
			long eventExpiredTime = levelComponentCommon.m_luaExportHelper.GetEventExpiredTime(eventId);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, eventExpiredTime);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601856C RID: 99692 RVA: 0x006CEEE0 File Offset: 0x006CD0E0
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int GetEventLives(IntPtr l)
	{
		int result;
		try
		{
			LevelComponentCommon levelComponentCommon = (LevelComponentCommon)LuaObject.checkSelf(l);
			int eventId;
			LuaObject.checkType(l, 2, out eventId);
			int eventLives = levelComponentCommon.m_luaExportHelper.GetEventLives(eventId);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, eventLives);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601856D RID: 99693 RVA: 0x006CEF48 File Offset: 0x006CD148
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int CheckGameFunctionOpenByGM(IntPtr l)
	{
		int result;
		try
		{
			LevelComponentCommon levelComponentCommon = (LevelComponentCommon)LuaObject.checkSelf(l);
			GameFunctionType gameFunctionTypeId;
			LuaObject.checkEnum<GameFunctionType>(l, 2, out gameFunctionTypeId);
			int i = levelComponentCommon.m_luaExportHelper.CheckGameFunctionOpenByGM(gameFunctionTypeId);
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

	// Token: 0x0601856E RID: 99694 RVA: 0x006CEFB0 File Offset: 0x006CD1B0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int HandleEventWayPoint(IntPtr l)
	{
		int result;
		try
		{
			LevelComponentCommon levelComponentCommon = (LevelComponentCommon)LuaObject.checkSelf(l);
			ConfigDataWaypointInfo wayPointInfo;
			LuaObject.checkType<ConfigDataWaypointInfo>(l, 2, out wayPointInfo);
			int i = levelComponentCommon.m_luaExportHelper.HandleEventWayPoint(wayPointInfo);
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

	// Token: 0x0601856F RID: 99695 RVA: 0x006CF018 File Offset: 0x006CD218
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int HandleDialogEvent(IntPtr l)
	{
		int result;
		try
		{
			LevelComponentCommon levelComponentCommon = (LevelComponentCommon)LuaObject.checkSelf(l);
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
			int i = levelComponentCommon.m_luaExportHelper.HandleDialogEvent(wayPointInfo, itemRewards, expReward, goldReward, energyCost, scenarioId);
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

	// Token: 0x06018570 RID: 99696 RVA: 0x006CF0C0 File Offset: 0x006CD2C0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int HandleTresureEvent(IntPtr l)
	{
		int result;
		try
		{
			LevelComponentCommon levelComponentCommon = (LevelComponentCommon)LuaObject.checkSelf(l);
			int wayPointId;
			LuaObject.checkType(l, 2, out wayPointId);
			ConfigDataEventInfo eventInfo;
			LuaObject.checkType<ConfigDataEventInfo>(l, 3, out eventInfo);
			int i = levelComponentCommon.m_luaExportHelper.HandleTresureEvent(wayPointId, eventInfo);
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

	// Token: 0x06018571 RID: 99697 RVA: 0x006CF134 File Offset: 0x006CD334
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int GetEventRewards(IntPtr l)
	{
		int result;
		try
		{
			LevelComponentCommon levelComponentCommon = (LevelComponentCommon)LuaObject.checkSelf(l);
			ConfigDataEventInfo eventInfo;
			LuaObject.checkType<ConfigDataEventInfo>(l, 2, out eventInfo);
			List<Goods> eventRewards = levelComponentCommon.m_luaExportHelper.GetEventRewards(eventInfo);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, eventRewards);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06018572 RID: 99698 RVA: 0x006CF19C File Offset: 0x006CD39C
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int AttackScenario(IntPtr l)
	{
		int result;
		try
		{
			LevelComponentCommon levelComponentCommon = (LevelComponentCommon)LuaObject.checkSelf(l);
			ConfigDataScenarioInfo secenarioInfo;
			LuaObject.checkType<ConfigDataScenarioInfo>(l, 2, out secenarioInfo);
			bool scenarioFinished;
			LuaObject.checkType(l, 3, out scenarioFinished);
			bool checkBag;
			LuaObject.checkType(l, 4, out checkBag);
			int i = levelComponentCommon.m_luaExportHelper.AttackScenario(secenarioInfo, scenarioFinished, checkBag);
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

	// Token: 0x06018573 RID: 99699 RVA: 0x006CF220 File Offset: 0x006CD420
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int HandleAttackWayPointEvent(IntPtr l)
	{
		int result;
		try
		{
			LevelComponentCommon levelComponentCommon = (LevelComponentCommon)LuaObject.checkSelf(l);
			int wayPointId;
			LuaObject.checkType(l, 2, out wayPointId);
			ConfigDataEventInfo eventInfo;
			LuaObject.checkType<ConfigDataEventInfo>(l, 3, out eventInfo);
			int i = levelComponentCommon.m_luaExportHelper.HandleAttackWayPointEvent(wayPointId, eventInfo);
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

	// Token: 0x06018574 RID: 99700 RVA: 0x006CF294 File Offset: 0x006CD494
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int AttackEventWayPoint(IntPtr l)
	{
		int result;
		try
		{
			LevelComponentCommon levelComponentCommon = (LevelComponentCommon)LuaObject.checkSelf(l);
			int wayPointId;
			LuaObject.checkType(l, 2, out wayPointId);
			ConfigDataEventInfo eventyInfo;
			LuaObject.checkType<ConfigDataEventInfo>(l, 3, out eventyInfo);
			int i = levelComponentCommon.m_luaExportHelper.AttackEventWayPoint(wayPointId, eventyInfo);
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

	// Token: 0x06018575 RID: 99701 RVA: 0x006CF308 File Offset: 0x006CD508
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int CanMoveToWayPoint(IntPtr l)
	{
		int result;
		try
		{
			LevelComponentCommon levelComponentCommon = (LevelComponentCommon)LuaObject.checkSelf(l);
			int destWayPointId;
			LuaObject.checkType(l, 2, out destWayPointId);
			int i = levelComponentCommon.m_luaExportHelper.CanMoveToWayPoint(destWayPointId);
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

	// Token: 0x06018576 RID: 99702 RVA: 0x006CF370 File Offset: 0x006CD570
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int CanMoveToWayPointExistRandomEvent(IntPtr l)
	{
		int result;
		try
		{
			LevelComponentCommon levelComponentCommon = (LevelComponentCommon)LuaObject.checkSelf(l);
			int destWayPointId;
			LuaObject.checkType(l, 2, out destWayPointId);
			int i = levelComponentCommon.m_luaExportHelper.CanMoveToWayPointExistRandomEvent(destWayPointId);
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

	// Token: 0x06018577 RID: 99703 RVA: 0x006CF3D8 File Offset: 0x006CD5D8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int OnOpenRegion(IntPtr l)
	{
		int result;
		try
		{
			LevelComponentCommon levelComponentCommon = (LevelComponentCommon)LuaObject.checkSelf(l);
			ConfigDataRegionInfo regionInfo;
			LuaObject.checkType<ConfigDataRegionInfo>(l, 2, out regionInfo);
			levelComponentCommon.m_luaExportHelper.OnOpenRegion(regionInfo);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06018578 RID: 99704 RVA: 0x006CF434 File Offset: 0x006CD634
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callDele_CompleteEventMissionEvent(IntPtr l)
	{
		int result;
		try
		{
			LevelComponentCommon levelComponentCommon = (LevelComponentCommon)LuaObject.checkSelf(l);
			bool obj;
			LuaObject.checkType(l, 2, out obj);
			levelComponentCommon.m_luaExportHelper.__callDele_CompleteEventMissionEvent(obj);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06018579 RID: 99705 RVA: 0x006CF490 File Offset: 0x006CD690
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int __clearDele_CompleteEventMissionEvent(IntPtr l)
	{
		int result;
		try
		{
			LevelComponentCommon levelComponentCommon = (LevelComponentCommon)LuaObject.checkSelf(l);
			bool obj;
			LuaObject.checkType(l, 2, out obj);
			levelComponentCommon.m_luaExportHelper.__clearDele_CompleteEventMissionEvent(obj);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601857A RID: 99706 RVA: 0x006CF4EC File Offset: 0x006CD6EC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callDele_CompleteScenarioMissionEvent(IntPtr l)
	{
		int result;
		try
		{
			LevelComponentCommon levelComponentCommon = (LevelComponentCommon)LuaObject.checkSelf(l);
			int obj;
			LuaObject.checkType(l, 2, out obj);
			levelComponentCommon.m_luaExportHelper.__callDele_CompleteScenarioMissionEvent(obj);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601857B RID: 99707 RVA: 0x006CF548 File Offset: 0x006CD748
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __clearDele_CompleteScenarioMissionEvent(IntPtr l)
	{
		int result;
		try
		{
			LevelComponentCommon levelComponentCommon = (LevelComponentCommon)LuaObject.checkSelf(l);
			int obj;
			LuaObject.checkType(l, 2, out obj);
			levelComponentCommon.m_luaExportHelper.__clearDele_CompleteScenarioMissionEvent(obj);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601857C RID: 99708 RVA: 0x006CF5A4 File Offset: 0x006CD7A4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callDele_CompleteNewScenarioMissionEvent(IntPtr l)
	{
		int result;
		try
		{
			LevelComponentCommon levelComponentCommon = (LevelComponentCommon)LuaObject.checkSelf(l);
			int obj;
			LuaObject.checkType(l, 2, out obj);
			levelComponentCommon.m_luaExportHelper.__callDele_CompleteNewScenarioMissionEvent(obj);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601857D RID: 99709 RVA: 0x006CF600 File Offset: 0x006CD800
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int __clearDele_CompleteNewScenarioMissionEvent(IntPtr l)
	{
		int result;
		try
		{
			LevelComponentCommon levelComponentCommon = (LevelComponentCommon)LuaObject.checkSelf(l);
			int obj;
			LuaObject.checkType(l, 2, out obj);
			levelComponentCommon.m_luaExportHelper.__clearDele_CompleteNewScenarioMissionEvent(obj);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601857E RID: 99710 RVA: 0x006CF65C File Offset: 0x006CD85C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_configDataLoader(IntPtr l)
	{
		int result;
		try
		{
			LevelComponentCommon levelComponentCommon = (LevelComponentCommon)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, levelComponentCommon.m_luaExportHelper.m_configDataLoader);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601857F RID: 99711 RVA: 0x006CF6B4 File Offset: 0x006CD8B4
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_m_configDataLoader(IntPtr l)
	{
		int result;
		try
		{
			LevelComponentCommon levelComponentCommon = (LevelComponentCommon)LuaObject.checkSelf(l);
			IConfigDataLoader configDataLoader;
			LuaObject.checkType<IConfigDataLoader>(l, 2, out configDataLoader);
			levelComponentCommon.m_luaExportHelper.m_configDataLoader = configDataLoader;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06018580 RID: 99712 RVA: 0x006CF710 File Offset: 0x006CD910
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_bag(IntPtr l)
	{
		int result;
		try
		{
			LevelComponentCommon levelComponentCommon = (LevelComponentCommon)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, levelComponentCommon.m_luaExportHelper.m_bag);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06018581 RID: 99713 RVA: 0x006CF768 File Offset: 0x006CD968
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_bag(IntPtr l)
	{
		int result;
		try
		{
			LevelComponentCommon levelComponentCommon = (LevelComponentCommon)LuaObject.checkSelf(l);
			BagComponentCommon bag;
			LuaObject.checkType<BagComponentCommon>(l, 2, out bag);
			levelComponentCommon.m_luaExportHelper.m_bag = bag;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06018582 RID: 99714 RVA: 0x006CF7C4 File Offset: 0x006CD9C4
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_m_basicInfo(IntPtr l)
	{
		int result;
		try
		{
			LevelComponentCommon levelComponentCommon = (LevelComponentCommon)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, levelComponentCommon.m_luaExportHelper.m_basicInfo);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06018583 RID: 99715 RVA: 0x006CF81C File Offset: 0x006CDA1C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_basicInfo(IntPtr l)
	{
		int result;
		try
		{
			LevelComponentCommon levelComponentCommon = (LevelComponentCommon)LuaObject.checkSelf(l);
			PlayerBasicInfoComponentCommon basicInfo;
			LuaObject.checkType<PlayerBasicInfoComponentCommon>(l, 2, out basicInfo);
			levelComponentCommon.m_luaExportHelper.m_basicInfo = basicInfo;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06018584 RID: 99716 RVA: 0x006CF878 File Offset: 0x006CDA78
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_rift(IntPtr l)
	{
		int result;
		try
		{
			LevelComponentCommon levelComponentCommon = (LevelComponentCommon)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, levelComponentCommon.m_luaExportHelper.m_rift);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06018585 RID: 99717 RVA: 0x006CF8D0 File Offset: 0x006CDAD0
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_m_rift(IntPtr l)
	{
		int result;
		try
		{
			LevelComponentCommon levelComponentCommon = (LevelComponentCommon)LuaObject.checkSelf(l);
			RiftComponentCommon rift;
			LuaObject.checkType<RiftComponentCommon>(l, 2, out rift);
			levelComponentCommon.m_luaExportHelper.m_rift = rift;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06018586 RID: 99718 RVA: 0x006CF92C File Offset: 0x006CDB2C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_battle(IntPtr l)
	{
		int result;
		try
		{
			LevelComponentCommon levelComponentCommon = (LevelComponentCommon)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, levelComponentCommon.m_luaExportHelper.m_battle);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06018587 RID: 99719 RVA: 0x006CF984 File Offset: 0x006CDB84
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_m_battle(IntPtr l)
	{
		int result;
		try
		{
			LevelComponentCommon levelComponentCommon = (LevelComponentCommon)LuaObject.checkSelf(l);
			BattleComponentCommon battle;
			LuaObject.checkType<BattleComponentCommon>(l, 2, out battle);
			levelComponentCommon.m_luaExportHelper.m_battle = battle;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06018588 RID: 99720 RVA: 0x006CF9E0 File Offset: 0x006CDBE0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_hero(IntPtr l)
	{
		int result;
		try
		{
			LevelComponentCommon levelComponentCommon = (LevelComponentCommon)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, levelComponentCommon.m_luaExportHelper.m_hero);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06018589 RID: 99721 RVA: 0x006CFA38 File Offset: 0x006CDC38
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_hero(IntPtr l)
	{
		int result;
		try
		{
			LevelComponentCommon levelComponentCommon = (LevelComponentCommon)LuaObject.checkSelf(l);
			HeroComponentCommon hero;
			LuaObject.checkType<HeroComponentCommon>(l, 2, out hero);
			levelComponentCommon.m_luaExportHelper.m_hero = hero;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601858A RID: 99722 RVA: 0x006CFA94 File Offset: 0x006CDC94
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_m_levelDS(IntPtr l)
	{
		int result;
		try
		{
			LevelComponentCommon levelComponentCommon = (LevelComponentCommon)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, levelComponentCommon.m_luaExportHelper.m_levelDS);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601858B RID: 99723 RVA: 0x006CFAEC File Offset: 0x006CDCEC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_levelDS(IntPtr l)
	{
		int result;
		try
		{
			LevelComponentCommon levelComponentCommon = (LevelComponentCommon)LuaObject.checkSelf(l);
			DataSectionLevel levelDS;
			LuaObject.checkType<DataSectionLevel>(l, 2, out levelDS);
			levelComponentCommon.m_luaExportHelper.m_levelDS = levelDS;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601858C RID: 99724 RVA: 0x006CFB48 File Offset: 0x006CDD48
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_CompleteEventMissionEvent(IntPtr l)
	{
		int result;
		try
		{
			LevelComponentCommon levelComponentCommon = (LevelComponentCommon)LuaObject.checkSelf(l);
			Action<bool> value;
			int num = LuaObject.checkDelegate<Action<bool>>(l, 2, out value);
			if (num != 0)
			{
				if (num == 1)
				{
					levelComponentCommon.CompleteEventMissionEvent += value;
				}
				else if (num == 2)
				{
					levelComponentCommon.CompleteEventMissionEvent -= value;
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

	// Token: 0x0601858D RID: 99725 RVA: 0x006CFBC8 File Offset: 0x006CDDC8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_CompleteScenarioMissionEvent(IntPtr l)
	{
		int result;
		try
		{
			LevelComponentCommon levelComponentCommon = (LevelComponentCommon)LuaObject.checkSelf(l);
			Action<int> value;
			int num = LuaObject.checkDelegate<Action<int>>(l, 2, out value);
			if (num != 0)
			{
				if (num == 1)
				{
					levelComponentCommon.CompleteScenarioMissionEvent += value;
				}
				else if (num == 2)
				{
					levelComponentCommon.CompleteScenarioMissionEvent -= value;
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

	// Token: 0x0601858E RID: 99726 RVA: 0x006CFC48 File Offset: 0x006CDE48
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_CompleteNewScenarioMissionEvent(IntPtr l)
	{
		int result;
		try
		{
			LevelComponentCommon levelComponentCommon = (LevelComponentCommon)LuaObject.checkSelf(l);
			Action<int> value;
			int num = LuaObject.checkDelegate<Action<int>>(l, 2, out value);
			if (num != 0)
			{
				if (num == 1)
				{
					levelComponentCommon.CompleteNewScenarioMissionEvent += value;
				}
				else if (num == 2)
				{
					levelComponentCommon.CompleteNewScenarioMissionEvent -= value;
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

	// Token: 0x0601858F RID: 99727 RVA: 0x006CFCC8 File Offset: 0x006CDEC8
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_Owner(IntPtr l)
	{
		int result;
		try
		{
			LevelComponentCommon levelComponentCommon = (LevelComponentCommon)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, levelComponentCommon.Owner);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06018590 RID: 99728 RVA: 0x006CFD1C File Offset: 0x006CDF1C
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_Owner(IntPtr l)
	{
		int result;
		try
		{
			LevelComponentCommon levelComponentCommon = (LevelComponentCommon)LuaObject.checkSelf(l);
			IComponentOwner owner;
			LuaObject.checkType<IComponentOwner>(l, 2, out owner);
			levelComponentCommon.Owner = owner;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06018591 RID: 99729 RVA: 0x006CFD74 File Offset: 0x006CDF74
	[Preserve]
	public static void reg(IntPtr l)
	{
		LuaObject.getTypeTable(l, "BlackJack.ProjectL.Common.LevelComponentCommon");
		if (Lua_BlackJack_ProjectL_Common_LevelComponentCommon.<>f__mg$cache0 == null)
		{
			Lua_BlackJack_ProjectL_Common_LevelComponentCommon.<>f__mg$cache0 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_LevelComponentCommon.GetName);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_LevelComponentCommon.<>f__mg$cache0);
		if (Lua_BlackJack_ProjectL_Common_LevelComponentCommon.<>f__mg$cache1 == null)
		{
			Lua_BlackJack_ProjectL_Common_LevelComponentCommon.<>f__mg$cache1 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_LevelComponentCommon.Init);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_LevelComponentCommon.<>f__mg$cache1);
		if (Lua_BlackJack_ProjectL_Common_LevelComponentCommon.<>f__mg$cache2 == null)
		{
			Lua_BlackJack_ProjectL_Common_LevelComponentCommon.<>f__mg$cache2 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_LevelComponentCommon.PostInit);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_LevelComponentCommon.<>f__mg$cache2);
		if (Lua_BlackJack_ProjectL_Common_LevelComponentCommon.<>f__mg$cache3 == null)
		{
			Lua_BlackJack_ProjectL_Common_LevelComponentCommon.<>f__mg$cache3 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_LevelComponentCommon.DeInit);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_LevelComponentCommon.<>f__mg$cache3);
		if (Lua_BlackJack_ProjectL_Common_LevelComponentCommon.<>f__mg$cache4 == null)
		{
			Lua_BlackJack_ProjectL_Common_LevelComponentCommon.<>f__mg$cache4 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_LevelComponentCommon.Tick);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_LevelComponentCommon.<>f__mg$cache4);
		if (Lua_BlackJack_ProjectL_Common_LevelComponentCommon.<>f__mg$cache5 == null)
		{
			Lua_BlackJack_ProjectL_Common_LevelComponentCommon.<>f__mg$cache5 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_LevelComponentCommon.PostDeSerialize);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_LevelComponentCommon.<>f__mg$cache5);
		if (Lua_BlackJack_ProjectL_Common_LevelComponentCommon.<>f__mg$cache6 == null)
		{
			Lua_BlackJack_ProjectL_Common_LevelComponentCommon.<>f__mg$cache6 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_LevelComponentCommon.IsWayPointArrived);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_LevelComponentCommon.<>f__mg$cache6);
		if (Lua_BlackJack_ProjectL_Common_LevelComponentCommon.<>f__mg$cache7 == null)
		{
			Lua_BlackJack_ProjectL_Common_LevelComponentCommon.<>f__mg$cache7 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_LevelComponentCommon.ArriveWayPoint);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_LevelComponentCommon.<>f__mg$cache7);
		if (Lua_BlackJack_ProjectL_Common_LevelComponentCommon.<>f__mg$cache8 == null)
		{
			Lua_BlackJack_ProjectL_Common_LevelComponentCommon.<>f__mg$cache8 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_LevelComponentCommon.AddCanMovePublicWayPoint);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_LevelComponentCommon.<>f__mg$cache8);
		if (Lua_BlackJack_ProjectL_Common_LevelComponentCommon.<>f__mg$cache9 == null)
		{
			Lua_BlackJack_ProjectL_Common_LevelComponentCommon.<>f__mg$cache9 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_LevelComponentCommon.SetFinishedScenario);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_LevelComponentCommon.<>f__mg$cache9);
		if (Lua_BlackJack_ProjectL_Common_LevelComponentCommon.<>f__mg$cacheA == null)
		{
			Lua_BlackJack_ProjectL_Common_LevelComponentCommon.<>f__mg$cacheA = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_LevelComponentCommon.GetLastFinishedScenarioId);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_LevelComponentCommon.<>f__mg$cacheA);
		if (Lua_BlackJack_ProjectL_Common_LevelComponentCommon.<>f__mg$cacheB == null)
		{
			Lua_BlackJack_ProjectL_Common_LevelComponentCommon.<>f__mg$cacheB = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_LevelComponentCommon.IsScenarioCompleted);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_LevelComponentCommon.<>f__mg$cacheB);
		if (Lua_BlackJack_ProjectL_Common_LevelComponentCommon.<>f__mg$cacheC == null)
		{
			Lua_BlackJack_ProjectL_Common_LevelComponentCommon.<>f__mg$cacheC = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_LevelComponentCommon.GetScenarioId);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_LevelComponentCommon.<>f__mg$cacheC);
		if (Lua_BlackJack_ProjectL_Common_LevelComponentCommon.<>f__mg$cacheD == null)
		{
			Lua_BlackJack_ProjectL_Common_LevelComponentCommon.<>f__mg$cacheD = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_LevelComponentCommon.SetBattleWayPointSuccessful);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_LevelComponentCommon.<>f__mg$cacheD);
		if (Lua_BlackJack_ProjectL_Common_LevelComponentCommon.<>f__mg$cacheE == null)
		{
			Lua_BlackJack_ProjectL_Common_LevelComponentCommon.<>f__mg$cacheE = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_LevelComponentCommon.IsSetRandomEvent);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_LevelComponentCommon.<>f__mg$cacheE);
		if (Lua_BlackJack_ProjectL_Common_LevelComponentCommon.<>f__mg$cacheF == null)
		{
			Lua_BlackJack_ProjectL_Common_LevelComponentCommon.<>f__mg$cacheF = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_LevelComponentCommon.MoveToWayPoint);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_LevelComponentCommon.<>f__mg$cacheF);
		if (Lua_BlackJack_ProjectL_Common_LevelComponentCommon.<>f__mg$cache10 == null)
		{
			Lua_BlackJack_ProjectL_Common_LevelComponentCommon.<>f__mg$cache10 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_LevelComponentCommon.HandleWayPoint);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_LevelComponentCommon.<>f__mg$cache10);
		if (Lua_BlackJack_ProjectL_Common_LevelComponentCommon.<>f__mg$cache11 == null)
		{
			Lua_BlackJack_ProjectL_Common_LevelComponentCommon.<>f__mg$cache11 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_LevelComponentCommon.IsRandomEventTimeOut);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_LevelComponentCommon.<>f__mg$cache11);
		if (Lua_BlackJack_ProjectL_Common_LevelComponentCommon.<>f__mg$cache12 == null)
		{
			Lua_BlackJack_ProjectL_Common_LevelComponentCommon.<>f__mg$cache12 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_LevelComponentCommon.IsRandomEventDead);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_LevelComponentCommon.<>f__mg$cache12);
		if (Lua_BlackJack_ProjectL_Common_LevelComponentCommon.<>f__mg$cache13 == null)
		{
			Lua_BlackJack_ProjectL_Common_LevelComponentCommon.<>f__mg$cache13 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_LevelComponentCommon.RemoveRandomEvent);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_LevelComponentCommon.<>f__mg$cache13);
		if (Lua_BlackJack_ProjectL_Common_LevelComponentCommon.<>f__mg$cache14 == null)
		{
			Lua_BlackJack_ProjectL_Common_LevelComponentCommon.<>f__mg$cache14 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_LevelComponentCommon.AddRandomEvent);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_LevelComponentCommon.<>f__mg$cache14);
		if (Lua_BlackJack_ProjectL_Common_LevelComponentCommon.<>f__mg$cache15 == null)
		{
			Lua_BlackJack_ProjectL_Common_LevelComponentCommon.<>f__mg$cache15 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_LevelComponentCommon.CanUnLockScenario);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_LevelComponentCommon.<>f__mg$cache15);
		if (Lua_BlackJack_ProjectL_Common_LevelComponentCommon.<>f__mg$cache16 == null)
		{
			Lua_BlackJack_ProjectL_Common_LevelComponentCommon.<>f__mg$cache16 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_LevelComponentCommon.HandleScenario);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_LevelComponentCommon.<>f__mg$cache16);
		if (Lua_BlackJack_ProjectL_Common_LevelComponentCommon.<>f__mg$cache17 == null)
		{
			Lua_BlackJack_ProjectL_Common_LevelComponentCommon.<>f__mg$cache17 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_LevelComponentCommon.IsScenarioFinished);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_LevelComponentCommon.<>f__mg$cache17);
		if (Lua_BlackJack_ProjectL_Common_LevelComponentCommon.<>f__mg$cache18 == null)
		{
			Lua_BlackJack_ProjectL_Common_LevelComponentCommon.<>f__mg$cache18 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_LevelComponentCommon.IsScenarioInWaypoint);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_LevelComponentCommon.<>f__mg$cache18);
		if (Lua_BlackJack_ProjectL_Common_LevelComponentCommon.<>f__mg$cache19 == null)
		{
			Lua_BlackJack_ProjectL_Common_LevelComponentCommon.<>f__mg$cache19 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_LevelComponentCommon.GetRandomEvent);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_LevelComponentCommon.<>f__mg$cache19);
		if (Lua_BlackJack_ProjectL_Common_LevelComponentCommon.<>f__mg$cache1A == null)
		{
			Lua_BlackJack_ProjectL_Common_LevelComponentCommon.<>f__mg$cache1A = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_LevelComponentCommon.GetEventId);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_LevelComponentCommon.<>f__mg$cache1A);
		if (Lua_BlackJack_ProjectL_Common_LevelComponentCommon.<>f__mg$cache1B == null)
		{
			Lua_BlackJack_ProjectL_Common_LevelComponentCommon.<>f__mg$cache1B = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_LevelComponentCommon.OnEventComplete);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_LevelComponentCommon.<>f__mg$cache1B);
		if (Lua_BlackJack_ProjectL_Common_LevelComponentCommon.<>f__mg$cache1C == null)
		{
			Lua_BlackJack_ProjectL_Common_LevelComponentCommon.<>f__mg$cache1C = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_LevelComponentCommon.CanAttackScenario);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_LevelComponentCommon.<>f__mg$cache1C);
		if (Lua_BlackJack_ProjectL_Common_LevelComponentCommon.<>f__mg$cache1D == null)
		{
			Lua_BlackJack_ProjectL_Common_LevelComponentCommon.<>f__mg$cache1D = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_LevelComponentCommon.CanAttackEventWayPoint);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_LevelComponentCommon.<>f__mg$cache1D);
		if (Lua_BlackJack_ProjectL_Common_LevelComponentCommon.<>f__mg$cache1E == null)
		{
			Lua_BlackJack_ProjectL_Common_LevelComponentCommon.<>f__mg$cache1E = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_LevelComponentCommon.OnCompleteWayPointEvent);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_LevelComponentCommon.<>f__mg$cache1E);
		if (Lua_BlackJack_ProjectL_Common_LevelComponentCommon.<>f__mg$cache1F == null)
		{
			Lua_BlackJack_ProjectL_Common_LevelComponentCommon.<>f__mg$cache1F = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_LevelComponentCommon.IsRegionOpen);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_LevelComponentCommon.<>f__mg$cache1F);
		if (Lua_BlackJack_ProjectL_Common_LevelComponentCommon.<>f__mg$cache20 == null)
		{
			Lua_BlackJack_ProjectL_Common_LevelComponentCommon.<>f__mg$cache20 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_LevelComponentCommon.GetWayPointStatus);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_LevelComponentCommon.<>f__mg$cache20);
		if (Lua_BlackJack_ProjectL_Common_LevelComponentCommon.<>f__mg$cache21 == null)
		{
			Lua_BlackJack_ProjectL_Common_LevelComponentCommon.<>f__mg$cache21 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_LevelComponentCommon.OutPutRandomEventOperateLog);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_LevelComponentCommon.<>f__mg$cache21);
		if (Lua_BlackJack_ProjectL_Common_LevelComponentCommon.<>f__mg$cache22 == null)
		{
			Lua_BlackJack_ProjectL_Common_LevelComponentCommon.<>f__mg$cache22 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_LevelComponentCommon.InitLevelInfo);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_LevelComponentCommon.<>f__mg$cache22);
		if (Lua_BlackJack_ProjectL_Common_LevelComponentCommon.<>f__mg$cache23 == null)
		{
			Lua_BlackJack_ProjectL_Common_LevelComponentCommon.<>f__mg$cache23 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_LevelComponentCommon.SetArrivedWayPoint);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_LevelComponentCommon.<>f__mg$cache23);
		if (Lua_BlackJack_ProjectL_Common_LevelComponentCommon.<>f__mg$cache24 == null)
		{
			Lua_BlackJack_ProjectL_Common_LevelComponentCommon.<>f__mg$cache24 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_LevelComponentCommon.HasFirstWayPointWithScenario);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_LevelComponentCommon.<>f__mg$cache24);
		if (Lua_BlackJack_ProjectL_Common_LevelComponentCommon.<>f__mg$cache25 == null)
		{
			Lua_BlackJack_ProjectL_Common_LevelComponentCommon.<>f__mg$cache25 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_LevelComponentCommon.IsExistRandomEvent);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_LevelComponentCommon.<>f__mg$cache25);
		if (Lua_BlackJack_ProjectL_Common_LevelComponentCommon.<>f__mg$cache26 == null)
		{
			Lua_BlackJack_ProjectL_Common_LevelComponentCommon.<>f__mg$cache26 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_LevelComponentCommon.InitRandomEvents);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_LevelComponentCommon.<>f__mg$cache26);
		if (Lua_BlackJack_ProjectL_Common_LevelComponentCommon.<>f__mg$cache27 == null)
		{
			Lua_BlackJack_ProjectL_Common_LevelComponentCommon.<>f__mg$cache27 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_LevelComponentCommon.PreInitRandomEvent);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_LevelComponentCommon.<>f__mg$cache27);
		if (Lua_BlackJack_ProjectL_Common_LevelComponentCommon.<>f__mg$cache28 == null)
		{
			Lua_BlackJack_ProjectL_Common_LevelComponentCommon.<>f__mg$cache28 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_LevelComponentCommon.GetEventExpiredTime);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_LevelComponentCommon.<>f__mg$cache28);
		if (Lua_BlackJack_ProjectL_Common_LevelComponentCommon.<>f__mg$cache29 == null)
		{
			Lua_BlackJack_ProjectL_Common_LevelComponentCommon.<>f__mg$cache29 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_LevelComponentCommon.GetEventLives);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_LevelComponentCommon.<>f__mg$cache29);
		if (Lua_BlackJack_ProjectL_Common_LevelComponentCommon.<>f__mg$cache2A == null)
		{
			Lua_BlackJack_ProjectL_Common_LevelComponentCommon.<>f__mg$cache2A = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_LevelComponentCommon.CheckGameFunctionOpenByGM);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_LevelComponentCommon.<>f__mg$cache2A);
		if (Lua_BlackJack_ProjectL_Common_LevelComponentCommon.<>f__mg$cache2B == null)
		{
			Lua_BlackJack_ProjectL_Common_LevelComponentCommon.<>f__mg$cache2B = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_LevelComponentCommon.HandleEventWayPoint);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_LevelComponentCommon.<>f__mg$cache2B);
		if (Lua_BlackJack_ProjectL_Common_LevelComponentCommon.<>f__mg$cache2C == null)
		{
			Lua_BlackJack_ProjectL_Common_LevelComponentCommon.<>f__mg$cache2C = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_LevelComponentCommon.HandleDialogEvent);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_LevelComponentCommon.<>f__mg$cache2C);
		if (Lua_BlackJack_ProjectL_Common_LevelComponentCommon.<>f__mg$cache2D == null)
		{
			Lua_BlackJack_ProjectL_Common_LevelComponentCommon.<>f__mg$cache2D = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_LevelComponentCommon.HandleTresureEvent);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_LevelComponentCommon.<>f__mg$cache2D);
		if (Lua_BlackJack_ProjectL_Common_LevelComponentCommon.<>f__mg$cache2E == null)
		{
			Lua_BlackJack_ProjectL_Common_LevelComponentCommon.<>f__mg$cache2E = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_LevelComponentCommon.GetEventRewards);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_LevelComponentCommon.<>f__mg$cache2E);
		if (Lua_BlackJack_ProjectL_Common_LevelComponentCommon.<>f__mg$cache2F == null)
		{
			Lua_BlackJack_ProjectL_Common_LevelComponentCommon.<>f__mg$cache2F = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_LevelComponentCommon.AttackScenario);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_LevelComponentCommon.<>f__mg$cache2F);
		if (Lua_BlackJack_ProjectL_Common_LevelComponentCommon.<>f__mg$cache30 == null)
		{
			Lua_BlackJack_ProjectL_Common_LevelComponentCommon.<>f__mg$cache30 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_LevelComponentCommon.HandleAttackWayPointEvent);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_LevelComponentCommon.<>f__mg$cache30);
		if (Lua_BlackJack_ProjectL_Common_LevelComponentCommon.<>f__mg$cache31 == null)
		{
			Lua_BlackJack_ProjectL_Common_LevelComponentCommon.<>f__mg$cache31 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_LevelComponentCommon.AttackEventWayPoint);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_LevelComponentCommon.<>f__mg$cache31);
		if (Lua_BlackJack_ProjectL_Common_LevelComponentCommon.<>f__mg$cache32 == null)
		{
			Lua_BlackJack_ProjectL_Common_LevelComponentCommon.<>f__mg$cache32 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_LevelComponentCommon.CanMoveToWayPoint);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_LevelComponentCommon.<>f__mg$cache32);
		if (Lua_BlackJack_ProjectL_Common_LevelComponentCommon.<>f__mg$cache33 == null)
		{
			Lua_BlackJack_ProjectL_Common_LevelComponentCommon.<>f__mg$cache33 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_LevelComponentCommon.CanMoveToWayPointExistRandomEvent);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_LevelComponentCommon.<>f__mg$cache33);
		if (Lua_BlackJack_ProjectL_Common_LevelComponentCommon.<>f__mg$cache34 == null)
		{
			Lua_BlackJack_ProjectL_Common_LevelComponentCommon.<>f__mg$cache34 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_LevelComponentCommon.OnOpenRegion);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_LevelComponentCommon.<>f__mg$cache34);
		if (Lua_BlackJack_ProjectL_Common_LevelComponentCommon.<>f__mg$cache35 == null)
		{
			Lua_BlackJack_ProjectL_Common_LevelComponentCommon.<>f__mg$cache35 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_LevelComponentCommon.__callDele_CompleteEventMissionEvent);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_LevelComponentCommon.<>f__mg$cache35);
		if (Lua_BlackJack_ProjectL_Common_LevelComponentCommon.<>f__mg$cache36 == null)
		{
			Lua_BlackJack_ProjectL_Common_LevelComponentCommon.<>f__mg$cache36 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_LevelComponentCommon.__clearDele_CompleteEventMissionEvent);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_LevelComponentCommon.<>f__mg$cache36);
		if (Lua_BlackJack_ProjectL_Common_LevelComponentCommon.<>f__mg$cache37 == null)
		{
			Lua_BlackJack_ProjectL_Common_LevelComponentCommon.<>f__mg$cache37 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_LevelComponentCommon.__callDele_CompleteScenarioMissionEvent);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_LevelComponentCommon.<>f__mg$cache37);
		if (Lua_BlackJack_ProjectL_Common_LevelComponentCommon.<>f__mg$cache38 == null)
		{
			Lua_BlackJack_ProjectL_Common_LevelComponentCommon.<>f__mg$cache38 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_LevelComponentCommon.__clearDele_CompleteScenarioMissionEvent);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_LevelComponentCommon.<>f__mg$cache38);
		if (Lua_BlackJack_ProjectL_Common_LevelComponentCommon.<>f__mg$cache39 == null)
		{
			Lua_BlackJack_ProjectL_Common_LevelComponentCommon.<>f__mg$cache39 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_LevelComponentCommon.__callDele_CompleteNewScenarioMissionEvent);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_LevelComponentCommon.<>f__mg$cache39);
		if (Lua_BlackJack_ProjectL_Common_LevelComponentCommon.<>f__mg$cache3A == null)
		{
			Lua_BlackJack_ProjectL_Common_LevelComponentCommon.<>f__mg$cache3A = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_LevelComponentCommon.__clearDele_CompleteNewScenarioMissionEvent);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_LevelComponentCommon.<>f__mg$cache3A);
		string name = "m_configDataLoader";
		if (Lua_BlackJack_ProjectL_Common_LevelComponentCommon.<>f__mg$cache3B == null)
		{
			Lua_BlackJack_ProjectL_Common_LevelComponentCommon.<>f__mg$cache3B = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_LevelComponentCommon.get_m_configDataLoader);
		}
		LuaCSFunction get = Lua_BlackJack_ProjectL_Common_LevelComponentCommon.<>f__mg$cache3B;
		if (Lua_BlackJack_ProjectL_Common_LevelComponentCommon.<>f__mg$cache3C == null)
		{
			Lua_BlackJack_ProjectL_Common_LevelComponentCommon.<>f__mg$cache3C = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_LevelComponentCommon.set_m_configDataLoader);
		}
		LuaObject.addMember(l, name, get, Lua_BlackJack_ProjectL_Common_LevelComponentCommon.<>f__mg$cache3C, true);
		string name2 = "m_bag";
		if (Lua_BlackJack_ProjectL_Common_LevelComponentCommon.<>f__mg$cache3D == null)
		{
			Lua_BlackJack_ProjectL_Common_LevelComponentCommon.<>f__mg$cache3D = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_LevelComponentCommon.get_m_bag);
		}
		LuaCSFunction get2 = Lua_BlackJack_ProjectL_Common_LevelComponentCommon.<>f__mg$cache3D;
		if (Lua_BlackJack_ProjectL_Common_LevelComponentCommon.<>f__mg$cache3E == null)
		{
			Lua_BlackJack_ProjectL_Common_LevelComponentCommon.<>f__mg$cache3E = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_LevelComponentCommon.set_m_bag);
		}
		LuaObject.addMember(l, name2, get2, Lua_BlackJack_ProjectL_Common_LevelComponentCommon.<>f__mg$cache3E, true);
		string name3 = "m_basicInfo";
		if (Lua_BlackJack_ProjectL_Common_LevelComponentCommon.<>f__mg$cache3F == null)
		{
			Lua_BlackJack_ProjectL_Common_LevelComponentCommon.<>f__mg$cache3F = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_LevelComponentCommon.get_m_basicInfo);
		}
		LuaCSFunction get3 = Lua_BlackJack_ProjectL_Common_LevelComponentCommon.<>f__mg$cache3F;
		if (Lua_BlackJack_ProjectL_Common_LevelComponentCommon.<>f__mg$cache40 == null)
		{
			Lua_BlackJack_ProjectL_Common_LevelComponentCommon.<>f__mg$cache40 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_LevelComponentCommon.set_m_basicInfo);
		}
		LuaObject.addMember(l, name3, get3, Lua_BlackJack_ProjectL_Common_LevelComponentCommon.<>f__mg$cache40, true);
		string name4 = "m_rift";
		if (Lua_BlackJack_ProjectL_Common_LevelComponentCommon.<>f__mg$cache41 == null)
		{
			Lua_BlackJack_ProjectL_Common_LevelComponentCommon.<>f__mg$cache41 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_LevelComponentCommon.get_m_rift);
		}
		LuaCSFunction get4 = Lua_BlackJack_ProjectL_Common_LevelComponentCommon.<>f__mg$cache41;
		if (Lua_BlackJack_ProjectL_Common_LevelComponentCommon.<>f__mg$cache42 == null)
		{
			Lua_BlackJack_ProjectL_Common_LevelComponentCommon.<>f__mg$cache42 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_LevelComponentCommon.set_m_rift);
		}
		LuaObject.addMember(l, name4, get4, Lua_BlackJack_ProjectL_Common_LevelComponentCommon.<>f__mg$cache42, true);
		string name5 = "m_battle";
		if (Lua_BlackJack_ProjectL_Common_LevelComponentCommon.<>f__mg$cache43 == null)
		{
			Lua_BlackJack_ProjectL_Common_LevelComponentCommon.<>f__mg$cache43 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_LevelComponentCommon.get_m_battle);
		}
		LuaCSFunction get5 = Lua_BlackJack_ProjectL_Common_LevelComponentCommon.<>f__mg$cache43;
		if (Lua_BlackJack_ProjectL_Common_LevelComponentCommon.<>f__mg$cache44 == null)
		{
			Lua_BlackJack_ProjectL_Common_LevelComponentCommon.<>f__mg$cache44 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_LevelComponentCommon.set_m_battle);
		}
		LuaObject.addMember(l, name5, get5, Lua_BlackJack_ProjectL_Common_LevelComponentCommon.<>f__mg$cache44, true);
		string name6 = "m_hero";
		if (Lua_BlackJack_ProjectL_Common_LevelComponentCommon.<>f__mg$cache45 == null)
		{
			Lua_BlackJack_ProjectL_Common_LevelComponentCommon.<>f__mg$cache45 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_LevelComponentCommon.get_m_hero);
		}
		LuaCSFunction get6 = Lua_BlackJack_ProjectL_Common_LevelComponentCommon.<>f__mg$cache45;
		if (Lua_BlackJack_ProjectL_Common_LevelComponentCommon.<>f__mg$cache46 == null)
		{
			Lua_BlackJack_ProjectL_Common_LevelComponentCommon.<>f__mg$cache46 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_LevelComponentCommon.set_m_hero);
		}
		LuaObject.addMember(l, name6, get6, Lua_BlackJack_ProjectL_Common_LevelComponentCommon.<>f__mg$cache46, true);
		string name7 = "m_levelDS";
		if (Lua_BlackJack_ProjectL_Common_LevelComponentCommon.<>f__mg$cache47 == null)
		{
			Lua_BlackJack_ProjectL_Common_LevelComponentCommon.<>f__mg$cache47 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_LevelComponentCommon.get_m_levelDS);
		}
		LuaCSFunction get7 = Lua_BlackJack_ProjectL_Common_LevelComponentCommon.<>f__mg$cache47;
		if (Lua_BlackJack_ProjectL_Common_LevelComponentCommon.<>f__mg$cache48 == null)
		{
			Lua_BlackJack_ProjectL_Common_LevelComponentCommon.<>f__mg$cache48 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_LevelComponentCommon.set_m_levelDS);
		}
		LuaObject.addMember(l, name7, get7, Lua_BlackJack_ProjectL_Common_LevelComponentCommon.<>f__mg$cache48, true);
		string name8 = "CompleteEventMissionEvent";
		LuaCSFunction get8 = null;
		if (Lua_BlackJack_ProjectL_Common_LevelComponentCommon.<>f__mg$cache49 == null)
		{
			Lua_BlackJack_ProjectL_Common_LevelComponentCommon.<>f__mg$cache49 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_LevelComponentCommon.set_CompleteEventMissionEvent);
		}
		LuaObject.addMember(l, name8, get8, Lua_BlackJack_ProjectL_Common_LevelComponentCommon.<>f__mg$cache49, true);
		string name9 = "CompleteScenarioMissionEvent";
		LuaCSFunction get9 = null;
		if (Lua_BlackJack_ProjectL_Common_LevelComponentCommon.<>f__mg$cache4A == null)
		{
			Lua_BlackJack_ProjectL_Common_LevelComponentCommon.<>f__mg$cache4A = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_LevelComponentCommon.set_CompleteScenarioMissionEvent);
		}
		LuaObject.addMember(l, name9, get9, Lua_BlackJack_ProjectL_Common_LevelComponentCommon.<>f__mg$cache4A, true);
		string name10 = "CompleteNewScenarioMissionEvent";
		LuaCSFunction get10 = null;
		if (Lua_BlackJack_ProjectL_Common_LevelComponentCommon.<>f__mg$cache4B == null)
		{
			Lua_BlackJack_ProjectL_Common_LevelComponentCommon.<>f__mg$cache4B = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_LevelComponentCommon.set_CompleteNewScenarioMissionEvent);
		}
		LuaObject.addMember(l, name10, get10, Lua_BlackJack_ProjectL_Common_LevelComponentCommon.<>f__mg$cache4B, true);
		string name11 = "Owner";
		if (Lua_BlackJack_ProjectL_Common_LevelComponentCommon.<>f__mg$cache4C == null)
		{
			Lua_BlackJack_ProjectL_Common_LevelComponentCommon.<>f__mg$cache4C = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_LevelComponentCommon.get_Owner);
		}
		LuaCSFunction get11 = Lua_BlackJack_ProjectL_Common_LevelComponentCommon.<>f__mg$cache4C;
		if (Lua_BlackJack_ProjectL_Common_LevelComponentCommon.<>f__mg$cache4D == null)
		{
			Lua_BlackJack_ProjectL_Common_LevelComponentCommon.<>f__mg$cache4D = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_LevelComponentCommon.set_Owner);
		}
		LuaObject.addMember(l, name11, get11, Lua_BlackJack_ProjectL_Common_LevelComponentCommon.<>f__mg$cache4D, true);
		if (Lua_BlackJack_ProjectL_Common_LevelComponentCommon.<>f__mg$cache4E == null)
		{
			Lua_BlackJack_ProjectL_Common_LevelComponentCommon.<>f__mg$cache4E = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_LevelComponentCommon.constructor);
		}
		LuaObject.createTypeMetatable(l, Lua_BlackJack_ProjectL_Common_LevelComponentCommon.<>f__mg$cache4E, typeof(LevelComponentCommon));
	}

	// Token: 0x0400EA90 RID: 60048
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache0;

	// Token: 0x0400EA91 RID: 60049
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1;

	// Token: 0x0400EA92 RID: 60050
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2;

	// Token: 0x0400EA93 RID: 60051
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3;

	// Token: 0x0400EA94 RID: 60052
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache4;

	// Token: 0x0400EA95 RID: 60053
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache5;

	// Token: 0x0400EA96 RID: 60054
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache6;

	// Token: 0x0400EA97 RID: 60055
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache7;

	// Token: 0x0400EA98 RID: 60056
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache8;

	// Token: 0x0400EA99 RID: 60057
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache9;

	// Token: 0x0400EA9A RID: 60058
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheA;

	// Token: 0x0400EA9B RID: 60059
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheB;

	// Token: 0x0400EA9C RID: 60060
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheC;

	// Token: 0x0400EA9D RID: 60061
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheD;

	// Token: 0x0400EA9E RID: 60062
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheE;

	// Token: 0x0400EA9F RID: 60063
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheF;

	// Token: 0x0400EAA0 RID: 60064
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache10;

	// Token: 0x0400EAA1 RID: 60065
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache11;

	// Token: 0x0400EAA2 RID: 60066
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache12;

	// Token: 0x0400EAA3 RID: 60067
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache13;

	// Token: 0x0400EAA4 RID: 60068
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache14;

	// Token: 0x0400EAA5 RID: 60069
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache15;

	// Token: 0x0400EAA6 RID: 60070
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache16;

	// Token: 0x0400EAA7 RID: 60071
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache17;

	// Token: 0x0400EAA8 RID: 60072
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache18;

	// Token: 0x0400EAA9 RID: 60073
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache19;

	// Token: 0x0400EAAA RID: 60074
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1A;

	// Token: 0x0400EAAB RID: 60075
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1B;

	// Token: 0x0400EAAC RID: 60076
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1C;

	// Token: 0x0400EAAD RID: 60077
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1D;

	// Token: 0x0400EAAE RID: 60078
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1E;

	// Token: 0x0400EAAF RID: 60079
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1F;

	// Token: 0x0400EAB0 RID: 60080
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache20;

	// Token: 0x0400EAB1 RID: 60081
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache21;

	// Token: 0x0400EAB2 RID: 60082
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache22;

	// Token: 0x0400EAB3 RID: 60083
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache23;

	// Token: 0x0400EAB4 RID: 60084
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache24;

	// Token: 0x0400EAB5 RID: 60085
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache25;

	// Token: 0x0400EAB6 RID: 60086
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache26;

	// Token: 0x0400EAB7 RID: 60087
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache27;

	// Token: 0x0400EAB8 RID: 60088
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache28;

	// Token: 0x0400EAB9 RID: 60089
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache29;

	// Token: 0x0400EABA RID: 60090
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2A;

	// Token: 0x0400EABB RID: 60091
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2B;

	// Token: 0x0400EABC RID: 60092
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2C;

	// Token: 0x0400EABD RID: 60093
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2D;

	// Token: 0x0400EABE RID: 60094
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2E;

	// Token: 0x0400EABF RID: 60095
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2F;

	// Token: 0x0400EAC0 RID: 60096
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache30;

	// Token: 0x0400EAC1 RID: 60097
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache31;

	// Token: 0x0400EAC2 RID: 60098
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache32;

	// Token: 0x0400EAC3 RID: 60099
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache33;

	// Token: 0x0400EAC4 RID: 60100
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache34;

	// Token: 0x0400EAC5 RID: 60101
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache35;

	// Token: 0x0400EAC6 RID: 60102
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache36;

	// Token: 0x0400EAC7 RID: 60103
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache37;

	// Token: 0x0400EAC8 RID: 60104
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache38;

	// Token: 0x0400EAC9 RID: 60105
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache39;

	// Token: 0x0400EACA RID: 60106
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3A;

	// Token: 0x0400EACB RID: 60107
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3B;

	// Token: 0x0400EACC RID: 60108
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3C;

	// Token: 0x0400EACD RID: 60109
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3D;

	// Token: 0x0400EACE RID: 60110
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3E;

	// Token: 0x0400EACF RID: 60111
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3F;

	// Token: 0x0400EAD0 RID: 60112
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache40;

	// Token: 0x0400EAD1 RID: 60113
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache41;

	// Token: 0x0400EAD2 RID: 60114
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache42;

	// Token: 0x0400EAD3 RID: 60115
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache43;

	// Token: 0x0400EAD4 RID: 60116
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache44;

	// Token: 0x0400EAD5 RID: 60117
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache45;

	// Token: 0x0400EAD6 RID: 60118
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache46;

	// Token: 0x0400EAD7 RID: 60119
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache47;

	// Token: 0x0400EAD8 RID: 60120
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache48;

	// Token: 0x0400EAD9 RID: 60121
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache49;

	// Token: 0x0400EADA RID: 60122
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache4A;

	// Token: 0x0400EADB RID: 60123
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache4B;

	// Token: 0x0400EADC RID: 60124
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache4C;

	// Token: 0x0400EADD RID: 60125
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache4D;

	// Token: 0x0400EADE RID: 60126
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache4E;
}
