using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using BlackJack.ProjectL.Common;
using SLua;
using UnityEngine.Scripting;

// Token: 0x02001204 RID: 4612
[Preserve]
public class Lua_BlackJack_ProjectL_Common_DataSectionLevel : LuaObject
{
	// Token: 0x06017EC1 RID: 97985 RVA: 0x0069DB68 File Offset: 0x0069BD68
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int constructor(IntPtr l)
	{
		int result;
		try
		{
			DataSectionLevel o = new DataSectionLevel();
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

	// Token: 0x06017EC2 RID: 97986 RVA: 0x0069DBB0 File Offset: 0x0069BDB0
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int ClearInitedData(IntPtr l)
	{
		int result;
		try
		{
			DataSectionLevel dataSectionLevel = (DataSectionLevel)LuaObject.checkSelf(l);
			dataSectionLevel.ClearInitedData();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06017EC3 RID: 97987 RVA: 0x0069DBFC File Offset: 0x0069BDFC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int SerializeToClient(IntPtr l)
	{
		int result;
		try
		{
			DataSectionLevel dataSectionLevel = (DataSectionLevel)LuaObject.checkSelf(l);
			object o = dataSectionLevel.SerializeToClient();
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

	// Token: 0x06017EC4 RID: 97988 RVA: 0x0069DC50 File Offset: 0x0069BE50
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int SetScenario(IntPtr l)
	{
		int result;
		try
		{
			DataSectionLevel dataSectionLevel = (DataSectionLevel)LuaObject.checkSelf(l);
			int scenario;
			LuaObject.checkType(l, 2, out scenario);
			dataSectionLevel.SetScenario(scenario);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06017EC5 RID: 97989 RVA: 0x0069DCA8 File Offset: 0x0069BEA8
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int InitScenario(IntPtr l)
	{
		int result;
		try
		{
			DataSectionLevel dataSectionLevel = (DataSectionLevel)LuaObject.checkSelf(l);
			int id;
			LuaObject.checkType(l, 2, out id);
			dataSectionLevel.InitScenario(id);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06017EC6 RID: 97990 RVA: 0x0069DD00 File Offset: 0x0069BF00
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int SetCurrentWayPoint(IntPtr l)
	{
		int result;
		try
		{
			DataSectionLevel dataSectionLevel = (DataSectionLevel)LuaObject.checkSelf(l);
			int currentWayPoint;
			LuaObject.checkType(l, 2, out currentWayPoint);
			dataSectionLevel.SetCurrentWayPoint(currentWayPoint);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06017EC7 RID: 97991 RVA: 0x0069DD58 File Offset: 0x0069BF58
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int InitCurrentWayPoint(IntPtr l)
	{
		int result;
		try
		{
			DataSectionLevel dataSectionLevel = (DataSectionLevel)LuaObject.checkSelf(l);
			int wayPointId;
			LuaObject.checkType(l, 2, out wayPointId);
			dataSectionLevel.InitCurrentWayPoint(wayPointId);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06017EC8 RID: 97992 RVA: 0x0069DDB0 File Offset: 0x0069BFB0
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int SetArrivedWayPointId(IntPtr l)
	{
		int result;
		try
		{
			DataSectionLevel dataSectionLevel = (DataSectionLevel)LuaObject.checkSelf(l);
			int arrivedWayPointId;
			LuaObject.checkType(l, 2, out arrivedWayPointId);
			dataSectionLevel.SetArrivedWayPointId(arrivedWayPointId);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06017EC9 RID: 97993 RVA: 0x0069DE08 File Offset: 0x0069C008
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int SetRandomEvent(IntPtr l)
	{
		int result;
		try
		{
			DataSectionLevel dataSectionLevel = (DataSectionLevel)LuaObject.checkSelf(l);
			int randomEvent;
			LuaObject.checkType(l, 2, out randomEvent);
			dataSectionLevel.SetRandomEvent(randomEvent);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06017ECA RID: 97994 RVA: 0x0069DE60 File Offset: 0x0069C060
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int CleanWayPointEvent(IntPtr l)
	{
		int result;
		try
		{
			DataSectionLevel dataSectionLevel = (DataSectionLevel)LuaObject.checkSelf(l);
			int wayPointId;
			LuaObject.checkType(l, 2, out wayPointId);
			dataSectionLevel.CleanWayPointEvent(wayPointId);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06017ECB RID: 97995 RVA: 0x0069DEB8 File Offset: 0x0069C0B8
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int SetWayPointStatus(IntPtr l)
	{
		int result;
		try
		{
			DataSectionLevel dataSectionLevel = (DataSectionLevel)LuaObject.checkSelf(l);
			int wayPointId;
			LuaObject.checkType(l, 2, out wayPointId);
			WayPointStatus status;
			LuaObject.checkEnum<WayPointStatus>(l, 3, out status);
			dataSectionLevel.SetWayPointStatus(wayPointId, status);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06017ECC RID: 97996 RVA: 0x0069DF1C File Offset: 0x0069C11C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int IsSetRandomEvent(IntPtr l)
	{
		int result;
		try
		{
			DataSectionLevel dataSectionLevel = (DataSectionLevel)LuaObject.checkSelf(l);
			int wayPointId;
			LuaObject.checkType(l, 2, out wayPointId);
			bool b = dataSectionLevel.IsSetRandomEvent(wayPointId);
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

	// Token: 0x06017ECD RID: 97997 RVA: 0x0069DF80 File Offset: 0x0069C180
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int IsExistRandomEvent(IntPtr l)
	{
		int result;
		try
		{
			DataSectionLevel dataSectionLevel = (DataSectionLevel)LuaObject.checkSelf(l);
			bool b = dataSectionLevel.IsExistRandomEvent();
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

	// Token: 0x06017ECE RID: 97998 RVA: 0x0069DFD4 File Offset: 0x0069C1D4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int AddCanMoveWayPointId(IntPtr l)
	{
		int result;
		try
		{
			DataSectionLevel dataSectionLevel = (DataSectionLevel)LuaObject.checkSelf(l);
			int wayPointId;
			LuaObject.checkType(l, 2, out wayPointId);
			WayPointStatus eventStatus;
			LuaObject.checkEnum<WayPointStatus>(l, 3, out eventStatus);
			dataSectionLevel.AddCanMoveWayPointId(wayPointId, eventStatus);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06017ECF RID: 97999 RVA: 0x0069E038 File Offset: 0x0069C238
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int AddArrivedWayPoint(IntPtr l)
	{
		int result;
		try
		{
			DataSectionLevel dataSectionLevel = (DataSectionLevel)LuaObject.checkSelf(l);
			int wayPointId;
			LuaObject.checkType(l, 2, out wayPointId);
			dataSectionLevel.AddArrivedWayPoint(wayPointId);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06017ED0 RID: 98000 RVA: 0x0069E090 File Offset: 0x0069C290
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int IsWayPointArrived(IntPtr l)
	{
		int result;
		try
		{
			DataSectionLevel dataSectionLevel = (DataSectionLevel)LuaObject.checkSelf(l);
			int wayPointId;
			LuaObject.checkType(l, 2, out wayPointId);
			bool b = dataSectionLevel.IsWayPointArrived(wayPointId);
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

	// Token: 0x06017ED1 RID: 98001 RVA: 0x0069E0F4 File Offset: 0x0069C2F4
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int GetNotEventWayPoints(IntPtr l)
	{
		int result;
		try
		{
			DataSectionLevel dataSectionLevel = (DataSectionLevel)LuaObject.checkSelf(l);
			List<int> notEventWayPoints = dataSectionLevel.GetNotEventWayPoints();
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, notEventWayPoints);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06017ED2 RID: 98002 RVA: 0x0069E148 File Offset: 0x0069C348
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int GetArrivedWayPoints(IntPtr l)
	{
		int result;
		try
		{
			DataSectionLevel dataSectionLevel = (DataSectionLevel)LuaObject.checkSelf(l);
			List<int> arrivedWayPoints = dataSectionLevel.GetArrivedWayPoints();
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, arrivedWayPoints);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06017ED3 RID: 98003 RVA: 0x0069E19C File Offset: 0x0069C39C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int CanExpandWayPoint(IntPtr l)
	{
		int result;
		try
		{
			DataSectionLevel dataSectionLevel = (DataSectionLevel)LuaObject.checkSelf(l);
			int wayPointId;
			LuaObject.checkType(l, 2, out wayPointId);
			bool b = dataSectionLevel.CanExpandWayPoint(wayPointId);
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

	// Token: 0x06017ED4 RID: 98004 RVA: 0x0069E200 File Offset: 0x0069C400
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int CanMoveWayPoint(IntPtr l)
	{
		int result;
		try
		{
			DataSectionLevel dataSectionLevel = (DataSectionLevel)LuaObject.checkSelf(l);
			int wayPointId;
			LuaObject.checkType(l, 2, out wayPointId);
			bool b = dataSectionLevel.CanMoveWayPoint(wayPointId);
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

	// Token: 0x06017ED5 RID: 98005 RVA: 0x0069E264 File Offset: 0x0069C464
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int InitRandomEvents(IntPtr l)
	{
		int result;
		try
		{
			DataSectionLevel dataSectionLevel = (DataSectionLevel)LuaObject.checkSelf(l);
			List<RandomEvent> randomEvents;
			LuaObject.checkType<List<RandomEvent>>(l, 2, out randomEvents);
			dataSectionLevel.InitRandomEvents(randomEvents);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06017ED6 RID: 98006 RVA: 0x0069E2BC File Offset: 0x0069C4BC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int SetRandomEvents(IntPtr l)
	{
		int result;
		try
		{
			DataSectionLevel dataSectionLevel = (DataSectionLevel)LuaObject.checkSelf(l);
			List<RandomEvent> randomEvents;
			LuaObject.checkType<List<RandomEvent>>(l, 2, out randomEvents);
			dataSectionLevel.SetRandomEvents(randomEvents);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06017ED7 RID: 98007 RVA: 0x0069E314 File Offset: 0x0069C514
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int AddRandomEvent(IntPtr l)
	{
		int result;
		try
		{
			DataSectionLevel dataSectionLevel = (DataSectionLevel)LuaObject.checkSelf(l);
			RandomEvent randomEvent;
			LuaObject.checkType<RandomEvent>(l, 2, out randomEvent);
			dataSectionLevel.AddRandomEvent(randomEvent);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06017ED8 RID: 98008 RVA: 0x0069E36C File Offset: 0x0069C56C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int AddDeadLives(IntPtr l)
	{
		int result;
		try
		{
			DataSectionLevel dataSectionLevel = (DataSectionLevel)LuaObject.checkSelf(l);
			RandomEvent randomEvent;
			LuaObject.checkType<RandomEvent>(l, 2, out randomEvent);
			int deadLives;
			LuaObject.checkType(l, 3, out deadLives);
			dataSectionLevel.AddDeadLives(randomEvent, deadLives);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06017ED9 RID: 98009 RVA: 0x0069E3D0 File Offset: 0x0069C5D0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int RemoveRandomEvent(IntPtr l)
	{
		int result;
		try
		{
			DataSectionLevel dataSectionLevel = (DataSectionLevel)LuaObject.checkSelf(l);
			RandomEvent randomEvent;
			LuaObject.checkType<RandomEvent>(l, 2, out randomEvent);
			dataSectionLevel.RemoveRandomEvent(randomEvent);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06017EDA RID: 98010 RVA: 0x0069E428 File Offset: 0x0069C628
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int ClearRandomEvents(IntPtr l)
	{
		int result;
		try
		{
			DataSectionLevel dataSectionLevel = (DataSectionLevel)LuaObject.checkSelf(l);
			dataSectionLevel.ClearRandomEvents();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06017EDB RID: 98011 RVA: 0x0069E474 File Offset: 0x0069C674
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int GetRandomEvent(IntPtr l)
	{
		int result;
		try
		{
			DataSectionLevel dataSectionLevel = (DataSectionLevel)LuaObject.checkSelf(l);
			int wayPointId;
			LuaObject.checkType(l, 2, out wayPointId);
			RandomEvent randomEvent = dataSectionLevel.GetRandomEvent(wayPointId);
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

	// Token: 0x06017EDC RID: 98012 RVA: 0x0069E4D8 File Offset: 0x0069C6D8
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_RandomEvents(IntPtr l)
	{
		int result;
		try
		{
			DataSectionLevel dataSectionLevel = (DataSectionLevel)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, dataSectionLevel.RandomEvents);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06017EDD RID: 98013 RVA: 0x0069E52C File Offset: 0x0069C72C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_RandomEvents(IntPtr l)
	{
		int result;
		try
		{
			DataSectionLevel dataSectionLevel = (DataSectionLevel)LuaObject.checkSelf(l);
			List<RandomEvent> randomEvents;
			LuaObject.checkType<List<RandomEvent>>(l, 2, out randomEvents);
			dataSectionLevel.RandomEvents = randomEvents;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06017EDE RID: 98014 RVA: 0x0069E584 File Offset: 0x0069C784
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_CurrentWayPointId(IntPtr l)
	{
		int result;
		try
		{
			DataSectionLevel dataSectionLevel = (DataSectionLevel)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, dataSectionLevel.CurrentWayPointId);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06017EDF RID: 98015 RVA: 0x0069E5D8 File Offset: 0x0069C7D8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_CurrentWayPointId(IntPtr l)
	{
		int result;
		try
		{
			DataSectionLevel dataSectionLevel = (DataSectionLevel)LuaObject.checkSelf(l);
			int currentWayPointId;
			LuaObject.checkType(l, 2, out currentWayPointId);
			dataSectionLevel.CurrentWayPointId = currentWayPointId;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06017EE0 RID: 98016 RVA: 0x0069E630 File Offset: 0x0069C830
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_LastFinishedScenarioId(IntPtr l)
	{
		int result;
		try
		{
			DataSectionLevel dataSectionLevel = (DataSectionLevel)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, dataSectionLevel.LastFinishedScenarioId);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06017EE1 RID: 98017 RVA: 0x0069E684 File Offset: 0x0069C884
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_LastFinishedScenarioId(IntPtr l)
	{
		int result;
		try
		{
			DataSectionLevel dataSectionLevel = (DataSectionLevel)LuaObject.checkSelf(l);
			int lastFinishedScenarioId;
			LuaObject.checkType(l, 2, out lastFinishedScenarioId);
			dataSectionLevel.LastFinishedScenarioId = lastFinishedScenarioId;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06017EE2 RID: 98018 RVA: 0x0069E6DC File Offset: 0x0069C8DC
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_CanMoveWayPointIds(IntPtr l)
	{
		int result;
		try
		{
			DataSectionLevel dataSectionLevel = (DataSectionLevel)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, dataSectionLevel.CanMoveWayPointIds);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06017EE3 RID: 98019 RVA: 0x0069E730 File Offset: 0x0069C930
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_CanMoveWayPointIds(IntPtr l)
	{
		int result;
		try
		{
			DataSectionLevel dataSectionLevel = (DataSectionLevel)LuaObject.checkSelf(l);
			Dictionary<int, WayPointStatus> canMoveWayPointIds;
			LuaObject.checkType<Dictionary<int, WayPointStatus>>(l, 2, out canMoveWayPointIds);
			dataSectionLevel.CanMoveWayPointIds = canMoveWayPointIds;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06017EE4 RID: 98020 RVA: 0x0069E788 File Offset: 0x0069C988
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_LastFinishedScenarioInfo(IntPtr l)
	{
		int result;
		try
		{
			DataSectionLevel dataSectionLevel = (DataSectionLevel)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, dataSectionLevel.LastFinishedScenarioInfo);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06017EE5 RID: 98021 RVA: 0x0069E7DC File Offset: 0x0069C9DC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_CurrentWaypointInfo(IntPtr l)
	{
		int result;
		try
		{
			DataSectionLevel dataSectionLevel = (DataSectionLevel)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, dataSectionLevel.CurrentWaypointInfo);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06017EE6 RID: 98022 RVA: 0x0069E830 File Offset: 0x0069CA30
	[Preserve]
	public static void reg(IntPtr l)
	{
		LuaObject.getTypeTable(l, "BlackJack.ProjectL.Common.DataSectionLevel");
		if (Lua_BlackJack_ProjectL_Common_DataSectionLevel.<>f__mg$cache0 == null)
		{
			Lua_BlackJack_ProjectL_Common_DataSectionLevel.<>f__mg$cache0 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_DataSectionLevel.ClearInitedData);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_DataSectionLevel.<>f__mg$cache0);
		if (Lua_BlackJack_ProjectL_Common_DataSectionLevel.<>f__mg$cache1 == null)
		{
			Lua_BlackJack_ProjectL_Common_DataSectionLevel.<>f__mg$cache1 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_DataSectionLevel.SerializeToClient);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_DataSectionLevel.<>f__mg$cache1);
		if (Lua_BlackJack_ProjectL_Common_DataSectionLevel.<>f__mg$cache2 == null)
		{
			Lua_BlackJack_ProjectL_Common_DataSectionLevel.<>f__mg$cache2 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_DataSectionLevel.SetScenario);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_DataSectionLevel.<>f__mg$cache2);
		if (Lua_BlackJack_ProjectL_Common_DataSectionLevel.<>f__mg$cache3 == null)
		{
			Lua_BlackJack_ProjectL_Common_DataSectionLevel.<>f__mg$cache3 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_DataSectionLevel.InitScenario);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_DataSectionLevel.<>f__mg$cache3);
		if (Lua_BlackJack_ProjectL_Common_DataSectionLevel.<>f__mg$cache4 == null)
		{
			Lua_BlackJack_ProjectL_Common_DataSectionLevel.<>f__mg$cache4 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_DataSectionLevel.SetCurrentWayPoint);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_DataSectionLevel.<>f__mg$cache4);
		if (Lua_BlackJack_ProjectL_Common_DataSectionLevel.<>f__mg$cache5 == null)
		{
			Lua_BlackJack_ProjectL_Common_DataSectionLevel.<>f__mg$cache5 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_DataSectionLevel.InitCurrentWayPoint);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_DataSectionLevel.<>f__mg$cache5);
		if (Lua_BlackJack_ProjectL_Common_DataSectionLevel.<>f__mg$cache6 == null)
		{
			Lua_BlackJack_ProjectL_Common_DataSectionLevel.<>f__mg$cache6 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_DataSectionLevel.SetArrivedWayPointId);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_DataSectionLevel.<>f__mg$cache6);
		if (Lua_BlackJack_ProjectL_Common_DataSectionLevel.<>f__mg$cache7 == null)
		{
			Lua_BlackJack_ProjectL_Common_DataSectionLevel.<>f__mg$cache7 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_DataSectionLevel.SetRandomEvent);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_DataSectionLevel.<>f__mg$cache7);
		if (Lua_BlackJack_ProjectL_Common_DataSectionLevel.<>f__mg$cache8 == null)
		{
			Lua_BlackJack_ProjectL_Common_DataSectionLevel.<>f__mg$cache8 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_DataSectionLevel.CleanWayPointEvent);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_DataSectionLevel.<>f__mg$cache8);
		if (Lua_BlackJack_ProjectL_Common_DataSectionLevel.<>f__mg$cache9 == null)
		{
			Lua_BlackJack_ProjectL_Common_DataSectionLevel.<>f__mg$cache9 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_DataSectionLevel.SetWayPointStatus);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_DataSectionLevel.<>f__mg$cache9);
		if (Lua_BlackJack_ProjectL_Common_DataSectionLevel.<>f__mg$cacheA == null)
		{
			Lua_BlackJack_ProjectL_Common_DataSectionLevel.<>f__mg$cacheA = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_DataSectionLevel.IsSetRandomEvent);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_DataSectionLevel.<>f__mg$cacheA);
		if (Lua_BlackJack_ProjectL_Common_DataSectionLevel.<>f__mg$cacheB == null)
		{
			Lua_BlackJack_ProjectL_Common_DataSectionLevel.<>f__mg$cacheB = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_DataSectionLevel.IsExistRandomEvent);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_DataSectionLevel.<>f__mg$cacheB);
		if (Lua_BlackJack_ProjectL_Common_DataSectionLevel.<>f__mg$cacheC == null)
		{
			Lua_BlackJack_ProjectL_Common_DataSectionLevel.<>f__mg$cacheC = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_DataSectionLevel.AddCanMoveWayPointId);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_DataSectionLevel.<>f__mg$cacheC);
		if (Lua_BlackJack_ProjectL_Common_DataSectionLevel.<>f__mg$cacheD == null)
		{
			Lua_BlackJack_ProjectL_Common_DataSectionLevel.<>f__mg$cacheD = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_DataSectionLevel.AddArrivedWayPoint);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_DataSectionLevel.<>f__mg$cacheD);
		if (Lua_BlackJack_ProjectL_Common_DataSectionLevel.<>f__mg$cacheE == null)
		{
			Lua_BlackJack_ProjectL_Common_DataSectionLevel.<>f__mg$cacheE = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_DataSectionLevel.IsWayPointArrived);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_DataSectionLevel.<>f__mg$cacheE);
		if (Lua_BlackJack_ProjectL_Common_DataSectionLevel.<>f__mg$cacheF == null)
		{
			Lua_BlackJack_ProjectL_Common_DataSectionLevel.<>f__mg$cacheF = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_DataSectionLevel.GetNotEventWayPoints);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_DataSectionLevel.<>f__mg$cacheF);
		if (Lua_BlackJack_ProjectL_Common_DataSectionLevel.<>f__mg$cache10 == null)
		{
			Lua_BlackJack_ProjectL_Common_DataSectionLevel.<>f__mg$cache10 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_DataSectionLevel.GetArrivedWayPoints);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_DataSectionLevel.<>f__mg$cache10);
		if (Lua_BlackJack_ProjectL_Common_DataSectionLevel.<>f__mg$cache11 == null)
		{
			Lua_BlackJack_ProjectL_Common_DataSectionLevel.<>f__mg$cache11 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_DataSectionLevel.CanExpandWayPoint);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_DataSectionLevel.<>f__mg$cache11);
		if (Lua_BlackJack_ProjectL_Common_DataSectionLevel.<>f__mg$cache12 == null)
		{
			Lua_BlackJack_ProjectL_Common_DataSectionLevel.<>f__mg$cache12 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_DataSectionLevel.CanMoveWayPoint);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_DataSectionLevel.<>f__mg$cache12);
		if (Lua_BlackJack_ProjectL_Common_DataSectionLevel.<>f__mg$cache13 == null)
		{
			Lua_BlackJack_ProjectL_Common_DataSectionLevel.<>f__mg$cache13 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_DataSectionLevel.InitRandomEvents);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_DataSectionLevel.<>f__mg$cache13);
		if (Lua_BlackJack_ProjectL_Common_DataSectionLevel.<>f__mg$cache14 == null)
		{
			Lua_BlackJack_ProjectL_Common_DataSectionLevel.<>f__mg$cache14 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_DataSectionLevel.SetRandomEvents);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_DataSectionLevel.<>f__mg$cache14);
		if (Lua_BlackJack_ProjectL_Common_DataSectionLevel.<>f__mg$cache15 == null)
		{
			Lua_BlackJack_ProjectL_Common_DataSectionLevel.<>f__mg$cache15 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_DataSectionLevel.AddRandomEvent);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_DataSectionLevel.<>f__mg$cache15);
		if (Lua_BlackJack_ProjectL_Common_DataSectionLevel.<>f__mg$cache16 == null)
		{
			Lua_BlackJack_ProjectL_Common_DataSectionLevel.<>f__mg$cache16 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_DataSectionLevel.AddDeadLives);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_DataSectionLevel.<>f__mg$cache16);
		if (Lua_BlackJack_ProjectL_Common_DataSectionLevel.<>f__mg$cache17 == null)
		{
			Lua_BlackJack_ProjectL_Common_DataSectionLevel.<>f__mg$cache17 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_DataSectionLevel.RemoveRandomEvent);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_DataSectionLevel.<>f__mg$cache17);
		if (Lua_BlackJack_ProjectL_Common_DataSectionLevel.<>f__mg$cache18 == null)
		{
			Lua_BlackJack_ProjectL_Common_DataSectionLevel.<>f__mg$cache18 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_DataSectionLevel.ClearRandomEvents);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_DataSectionLevel.<>f__mg$cache18);
		if (Lua_BlackJack_ProjectL_Common_DataSectionLevel.<>f__mg$cache19 == null)
		{
			Lua_BlackJack_ProjectL_Common_DataSectionLevel.<>f__mg$cache19 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_DataSectionLevel.GetRandomEvent);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_DataSectionLevel.<>f__mg$cache19);
		string name = "RandomEvents";
		if (Lua_BlackJack_ProjectL_Common_DataSectionLevel.<>f__mg$cache1A == null)
		{
			Lua_BlackJack_ProjectL_Common_DataSectionLevel.<>f__mg$cache1A = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_DataSectionLevel.get_RandomEvents);
		}
		LuaCSFunction get = Lua_BlackJack_ProjectL_Common_DataSectionLevel.<>f__mg$cache1A;
		if (Lua_BlackJack_ProjectL_Common_DataSectionLevel.<>f__mg$cache1B == null)
		{
			Lua_BlackJack_ProjectL_Common_DataSectionLevel.<>f__mg$cache1B = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_DataSectionLevel.set_RandomEvents);
		}
		LuaObject.addMember(l, name, get, Lua_BlackJack_ProjectL_Common_DataSectionLevel.<>f__mg$cache1B, true);
		string name2 = "CurrentWayPointId";
		if (Lua_BlackJack_ProjectL_Common_DataSectionLevel.<>f__mg$cache1C == null)
		{
			Lua_BlackJack_ProjectL_Common_DataSectionLevel.<>f__mg$cache1C = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_DataSectionLevel.get_CurrentWayPointId);
		}
		LuaCSFunction get2 = Lua_BlackJack_ProjectL_Common_DataSectionLevel.<>f__mg$cache1C;
		if (Lua_BlackJack_ProjectL_Common_DataSectionLevel.<>f__mg$cache1D == null)
		{
			Lua_BlackJack_ProjectL_Common_DataSectionLevel.<>f__mg$cache1D = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_DataSectionLevel.set_CurrentWayPointId);
		}
		LuaObject.addMember(l, name2, get2, Lua_BlackJack_ProjectL_Common_DataSectionLevel.<>f__mg$cache1D, true);
		string name3 = "LastFinishedScenarioId";
		if (Lua_BlackJack_ProjectL_Common_DataSectionLevel.<>f__mg$cache1E == null)
		{
			Lua_BlackJack_ProjectL_Common_DataSectionLevel.<>f__mg$cache1E = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_DataSectionLevel.get_LastFinishedScenarioId);
		}
		LuaCSFunction get3 = Lua_BlackJack_ProjectL_Common_DataSectionLevel.<>f__mg$cache1E;
		if (Lua_BlackJack_ProjectL_Common_DataSectionLevel.<>f__mg$cache1F == null)
		{
			Lua_BlackJack_ProjectL_Common_DataSectionLevel.<>f__mg$cache1F = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_DataSectionLevel.set_LastFinishedScenarioId);
		}
		LuaObject.addMember(l, name3, get3, Lua_BlackJack_ProjectL_Common_DataSectionLevel.<>f__mg$cache1F, true);
		string name4 = "CanMoveWayPointIds";
		if (Lua_BlackJack_ProjectL_Common_DataSectionLevel.<>f__mg$cache20 == null)
		{
			Lua_BlackJack_ProjectL_Common_DataSectionLevel.<>f__mg$cache20 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_DataSectionLevel.get_CanMoveWayPointIds);
		}
		LuaCSFunction get4 = Lua_BlackJack_ProjectL_Common_DataSectionLevel.<>f__mg$cache20;
		if (Lua_BlackJack_ProjectL_Common_DataSectionLevel.<>f__mg$cache21 == null)
		{
			Lua_BlackJack_ProjectL_Common_DataSectionLevel.<>f__mg$cache21 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_DataSectionLevel.set_CanMoveWayPointIds);
		}
		LuaObject.addMember(l, name4, get4, Lua_BlackJack_ProjectL_Common_DataSectionLevel.<>f__mg$cache21, true);
		string name5 = "LastFinishedScenarioInfo";
		if (Lua_BlackJack_ProjectL_Common_DataSectionLevel.<>f__mg$cache22 == null)
		{
			Lua_BlackJack_ProjectL_Common_DataSectionLevel.<>f__mg$cache22 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_DataSectionLevel.get_LastFinishedScenarioInfo);
		}
		LuaObject.addMember(l, name5, Lua_BlackJack_ProjectL_Common_DataSectionLevel.<>f__mg$cache22, null, true);
		string name6 = "CurrentWaypointInfo";
		if (Lua_BlackJack_ProjectL_Common_DataSectionLevel.<>f__mg$cache23 == null)
		{
			Lua_BlackJack_ProjectL_Common_DataSectionLevel.<>f__mg$cache23 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_DataSectionLevel.get_CurrentWaypointInfo);
		}
		LuaObject.addMember(l, name6, Lua_BlackJack_ProjectL_Common_DataSectionLevel.<>f__mg$cache23, null, true);
		if (Lua_BlackJack_ProjectL_Common_DataSectionLevel.<>f__mg$cache24 == null)
		{
			Lua_BlackJack_ProjectL_Common_DataSectionLevel.<>f__mg$cache24 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_DataSectionLevel.constructor);
		}
		LuaObject.createTypeMetatable(l, Lua_BlackJack_ProjectL_Common_DataSectionLevel.<>f__mg$cache24, typeof(DataSectionLevel), typeof(DataSection));
	}

	// Token: 0x0400E49B RID: 58523
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache0;

	// Token: 0x0400E49C RID: 58524
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1;

	// Token: 0x0400E49D RID: 58525
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2;

	// Token: 0x0400E49E RID: 58526
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3;

	// Token: 0x0400E49F RID: 58527
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache4;

	// Token: 0x0400E4A0 RID: 58528
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache5;

	// Token: 0x0400E4A1 RID: 58529
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache6;

	// Token: 0x0400E4A2 RID: 58530
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache7;

	// Token: 0x0400E4A3 RID: 58531
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache8;

	// Token: 0x0400E4A4 RID: 58532
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache9;

	// Token: 0x0400E4A5 RID: 58533
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheA;

	// Token: 0x0400E4A6 RID: 58534
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheB;

	// Token: 0x0400E4A7 RID: 58535
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheC;

	// Token: 0x0400E4A8 RID: 58536
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheD;

	// Token: 0x0400E4A9 RID: 58537
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheE;

	// Token: 0x0400E4AA RID: 58538
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheF;

	// Token: 0x0400E4AB RID: 58539
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache10;

	// Token: 0x0400E4AC RID: 58540
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache11;

	// Token: 0x0400E4AD RID: 58541
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache12;

	// Token: 0x0400E4AE RID: 58542
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache13;

	// Token: 0x0400E4AF RID: 58543
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache14;

	// Token: 0x0400E4B0 RID: 58544
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache15;

	// Token: 0x0400E4B1 RID: 58545
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache16;

	// Token: 0x0400E4B2 RID: 58546
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache17;

	// Token: 0x0400E4B3 RID: 58547
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache18;

	// Token: 0x0400E4B4 RID: 58548
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache19;

	// Token: 0x0400E4B5 RID: 58549
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1A;

	// Token: 0x0400E4B6 RID: 58550
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1B;

	// Token: 0x0400E4B7 RID: 58551
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1C;

	// Token: 0x0400E4B8 RID: 58552
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1D;

	// Token: 0x0400E4B9 RID: 58553
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1E;

	// Token: 0x0400E4BA RID: 58554
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1F;

	// Token: 0x0400E4BB RID: 58555
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache20;

	// Token: 0x0400E4BC RID: 58556
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache21;

	// Token: 0x0400E4BD RID: 58557
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache22;

	// Token: 0x0400E4BE RID: 58558
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache23;

	// Token: 0x0400E4BF RID: 58559
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache24;
}
