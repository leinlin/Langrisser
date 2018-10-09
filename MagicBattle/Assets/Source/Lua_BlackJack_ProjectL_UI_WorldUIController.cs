using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using BlackJack.BJFramework.Runtime.Prefab;
using BlackJack.BJFramework.Runtime.UI;
using BlackJack.ConfigData;
using BlackJack.ProjectL.Common;
using BlackJack.ProjectL.UI;
using SLua;
using UnityEngine;
using UnityEngine.Scripting;
using UnityEngine.UI;

// Token: 0x020015E9 RID: 5609
[Preserve]
public class Lua_BlackJack_ProjectL_UI_WorldUIController : LuaObject
{
	// Token: 0x060224AF RID: 140463 RVA: 0x00BBAE50 File Offset: 0x00BB9050
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int ShowOrHide(IntPtr l)
	{
		int result;
		try
		{
			WorldUIController worldUIController = (WorldUIController)LuaObject.checkSelf(l);
			bool isShow;
			LuaObject.checkType(l, 2, out isShow);
			worldUIController.ShowOrHide(isShow);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060224B0 RID: 140464 RVA: 0x00BBAEA8 File Offset: 0x00BB90A8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int UpdateGameFunctionOpen(IntPtr l)
	{
		int result;
		try
		{
			WorldUIController worldUIController = (WorldUIController)LuaObject.checkSelf(l);
			worldUIController.UpdateGameFunctionOpen();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060224B1 RID: 140465 RVA: 0x00BBAEF4 File Offset: 0x00BB90F4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int SetPlayerName(IntPtr l)
	{
		int result;
		try
		{
			WorldUIController worldUIController = (WorldUIController)LuaObject.checkSelf(l);
			string playerName;
			LuaObject.checkType(l, 2, out playerName);
			worldUIController.SetPlayerName(playerName);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060224B2 RID: 140466 RVA: 0x00BBAF4C File Offset: 0x00BB914C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int SetPlayerLevel(IntPtr l)
	{
		int result;
		try
		{
			WorldUIController worldUIController = (WorldUIController)LuaObject.checkSelf(l);
			int playerLevel;
			LuaObject.checkType(l, 2, out playerLevel);
			worldUIController.SetPlayerLevel(playerLevel);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060224B3 RID: 140467 RVA: 0x00BBAFA4 File Offset: 0x00BB91A4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int SetPlayerVip(IntPtr l)
	{
		int result;
		try
		{
			WorldUIController worldUIController = (WorldUIController)LuaObject.checkSelf(l);
			int playerVip;
			LuaObject.checkType(l, 2, out playerVip);
			worldUIController.SetPlayerVip(playerVip);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060224B4 RID: 140468 RVA: 0x00BBAFFC File Offset: 0x00BB91FC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int SetPlayerExp(IntPtr l)
	{
		int result;
		try
		{
			WorldUIController worldUIController = (WorldUIController)LuaObject.checkSelf(l);
			int exp;
			LuaObject.checkType(l, 2, out exp);
			int expMax;
			LuaObject.checkType(l, 3, out expMax);
			worldUIController.SetPlayerExp(exp, expMax);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060224B5 RID: 140469 RVA: 0x00BBB060 File Offset: 0x00BB9260
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int SetPlayerHeadIcon(IntPtr l)
	{
		int result;
		try
		{
			WorldUIController worldUIController = (WorldUIController)LuaObject.checkSelf(l);
			int playerHeadIcon;
			LuaObject.checkType(l, 2, out playerHeadIcon);
			worldUIController.SetPlayerHeadIcon(playerHeadIcon);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060224B6 RID: 140470 RVA: 0x00BBB0B8 File Offset: 0x00BB92B8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int ShowMainButtonBar(IntPtr l)
	{
		int result;
		try
		{
			WorldUIController worldUIController = (WorldUIController)LuaObject.checkSelf(l);
			bool show;
			LuaObject.checkType(l, 2, out show);
			worldUIController.ShowMainButtonBar(show);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060224B7 RID: 140471 RVA: 0x00BBB110 File Offset: 0x00BB9310
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int SetCurrentScenario(IntPtr l)
	{
		int result;
		try
		{
			WorldUIController worldUIController = (WorldUIController)LuaObject.checkSelf(l);
			ConfigDataScenarioInfo currentScenario;
			LuaObject.checkType<ConfigDataScenarioInfo>(l, 2, out currentScenario);
			worldUIController.SetCurrentScenario(currentScenario);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060224B8 RID: 140472 RVA: 0x00BBB168 File Offset: 0x00BB9368
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int ShowNewScenario(IntPtr l)
	{
		int result;
		try
		{
			WorldUIController worldUIController = (WorldUIController)LuaObject.checkSelf(l);
			ConfigDataScenarioInfo scenarioInfo;
			LuaObject.checkType<ConfigDataScenarioInfo>(l, 2, out scenarioInfo);
			Action onEnd;
			LuaObject.checkDelegate<Action>(l, 3, out onEnd);
			worldUIController.ShowNewScenario(scenarioInfo, onEnd);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060224B9 RID: 140473 RVA: 0x00BBB1CC File Offset: 0x00BB93CC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int ShowUnlockScenario(IntPtr l)
	{
		int result;
		try
		{
			WorldUIController worldUIController = (WorldUIController)LuaObject.checkSelf(l);
			ConfigDataScenarioInfo scenarioInfo;
			LuaObject.checkType<ConfigDataScenarioInfo>(l, 2, out scenarioInfo);
			worldUIController.ShowUnlockScenario(scenarioInfo);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060224BA RID: 140474 RVA: 0x00BBB224 File Offset: 0x00BB9424
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int ShowEnterScenario(IntPtr l)
	{
		int result;
		try
		{
			WorldUIController worldUIController = (WorldUIController)LuaObject.checkSelf(l);
			ConfigDataScenarioInfo scenarioInfo;
			LuaObject.checkType<ConfigDataScenarioInfo>(l, 2, out scenarioInfo);
			Action onEnd;
			LuaObject.checkDelegate<Action>(l, 3, out onEnd);
			worldUIController.ShowEnterScenario(scenarioInfo, onEnd);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060224BB RID: 140475 RVA: 0x00BBB288 File Offset: 0x00BB9488
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int ShowEnterMonster(IntPtr l)
	{
		int result;
		try
		{
			WorldUIController worldUIController = (WorldUIController)LuaObject.checkSelf(l);
			ConfigDataBattleInfo battleInfo;
			LuaObject.checkType<ConfigDataBattleInfo>(l, 2, out battleInfo);
			Action onEnd;
			LuaObject.checkDelegate<Action>(l, 3, out onEnd);
			worldUIController.ShowEnterMonster(battleInfo, onEnd);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060224BC RID: 140476 RVA: 0x00BBB2EC File Offset: 0x00BB94EC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int SetFog(IntPtr l)
	{
		int result;
		try
		{
			WorldUIController worldUIController = (WorldUIController)LuaObject.checkSelf(l);
			float fog;
			LuaObject.checkType(l, 2, out fog);
			worldUIController.SetFog(fog);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060224BD RID: 140477 RVA: 0x00BBB344 File Offset: 0x00BB9544
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int AddRandomEvent(IntPtr l)
	{
		int result;
		try
		{
			WorldUIController worldUIController = (WorldUIController)LuaObject.checkSelf(l);
			ConfigDataWaypointInfo waypointInfo;
			LuaObject.checkType<ConfigDataWaypointInfo>(l, 2, out waypointInfo);
			RandomEvent randomEvent;
			LuaObject.checkType<RandomEvent>(l, 3, out randomEvent);
			worldUIController.AddRandomEvent(waypointInfo, randomEvent);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060224BE RID: 140478 RVA: 0x00BBB3A8 File Offset: 0x00BB95A8
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int ClearRandomEventList(IntPtr l)
	{
		int result;
		try
		{
			WorldUIController worldUIController = (WorldUIController)LuaObject.checkSelf(l);
			worldUIController.ClearRandomEventList();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060224BF RID: 140479 RVA: 0x00BBB3F4 File Offset: 0x00BB95F4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int ShowEventList(IntPtr l)
	{
		int result;
		try
		{
			WorldUIController worldUIController = (WorldUIController)LuaObject.checkSelf(l);
			worldUIController.ShowEventList();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060224C0 RID: 140480 RVA: 0x00BBB440 File Offset: 0x00BB9640
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int HideEventList(IntPtr l)
	{
		int result;
		try
		{
			WorldUIController worldUIController = (WorldUIController)LuaObject.checkSelf(l);
			Action onEnd;
			LuaObject.checkDelegate<Action>(l, 2, out onEnd);
			worldUIController.HideEventList(onEnd);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060224C1 RID: 140481 RVA: 0x00BBB498 File Offset: 0x00BB9698
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int IsEventListVisible(IntPtr l)
	{
		int result;
		try
		{
			WorldUIController worldUIController = (WorldUIController)LuaObject.checkSelf(l);
			bool b = worldUIController.IsEventListVisible();
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

	// Token: 0x060224C2 RID: 140482 RVA: 0x00BBB4EC File Offset: 0x00BB96EC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int AddPastScenario(IntPtr l)
	{
		int result;
		try
		{
			WorldUIController worldUIController = (WorldUIController)LuaObject.checkSelf(l);
			ConfigDataScenarioInfo scenarioInfo;
			LuaObject.checkType<ConfigDataScenarioInfo>(l, 2, out scenarioInfo);
			worldUIController.AddPastScenario(scenarioInfo);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060224C3 RID: 140483 RVA: 0x00BBB544 File Offset: 0x00BB9744
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int ClearPastScenarioList(IntPtr l)
	{
		int result;
		try
		{
			WorldUIController worldUIController = (WorldUIController)LuaObject.checkSelf(l);
			worldUIController.ClearPastScenarioList();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060224C4 RID: 140484 RVA: 0x00BBB590 File Offset: 0x00BB9790
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int ShowPastScenarioList(IntPtr l)
	{
		int result;
		try
		{
			WorldUIController worldUIController = (WorldUIController)LuaObject.checkSelf(l);
			worldUIController.ShowPastScenarioList();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060224C5 RID: 140485 RVA: 0x00BBB5DC File Offset: 0x00BB97DC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int HidePastScenarioList(IntPtr l)
	{
		int result;
		try
		{
			WorldUIController worldUIController = (WorldUIController)LuaObject.checkSelf(l);
			worldUIController.HidePastScenarioList();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060224C6 RID: 140486 RVA: 0x00BBB628 File Offset: 0x00BB9828
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int ShowCooperateBattleButton(IntPtr l)
	{
		int result;
		try
		{
			WorldUIController worldUIController = (WorldUIController)LuaObject.checkSelf(l);
			bool show;
			LuaObject.checkType(l, 2, out show);
			worldUIController.ShowCooperateBattleButton(show);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060224C7 RID: 140487 RVA: 0x00BBB680 File Offset: 0x00BB9880
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int ShowHeroRedMark(IntPtr l)
	{
		int result;
		try
		{
			WorldUIController worldUIController = (WorldUIController)LuaObject.checkSelf(l);
			bool show;
			LuaObject.checkType(l, 2, out show);
			worldUIController.ShowHeroRedMark(show);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060224C8 RID: 140488 RVA: 0x00BBB6D8 File Offset: 0x00BB98D8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int ShowDrillRedMark(IntPtr l)
	{
		int result;
		try
		{
			WorldUIController worldUIController = (WorldUIController)LuaObject.checkSelf(l);
			bool show;
			LuaObject.checkType(l, 2, out show);
			worldUIController.ShowDrillRedMark(show);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060224C9 RID: 140489 RVA: 0x00BBB730 File Offset: 0x00BB9930
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int ShowFetterRedMark(IntPtr l)
	{
		int result;
		try
		{
			WorldUIController worldUIController = (WorldUIController)LuaObject.checkSelf(l);
			bool show;
			LuaObject.checkType(l, 2, out show);
			worldUIController.ShowFetterRedMark(show);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060224CA RID: 140490 RVA: 0x00BBB788 File Offset: 0x00BB9988
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int ShowGuildRedMark(IntPtr l)
	{
		int result;
		try
		{
			WorldUIController worldUIController = (WorldUIController)LuaObject.checkSelf(l);
			bool show;
			LuaObject.checkType(l, 2, out show);
			worldUIController.ShowGuildRedMark(show);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060224CB RID: 140491 RVA: 0x00BBB7E0 File Offset: 0x00BB99E0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int ShowEventRedMark(IntPtr l)
	{
		int result;
		try
		{
			WorldUIController worldUIController = (WorldUIController)LuaObject.checkSelf(l);
			bool show;
			LuaObject.checkType(l, 2, out show);
			worldUIController.ShowEventRedMark(show);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060224CC RID: 140492 RVA: 0x00BBB838 File Offset: 0x00BB9A38
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int ShowMissionRedMark(IntPtr l)
	{
		int result;
		try
		{
			WorldUIController worldUIController = (WorldUIController)LuaObject.checkSelf(l);
			bool show;
			LuaObject.checkType(l, 2, out show);
			worldUIController.ShowMissionRedMark(show);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060224CD RID: 140493 RVA: 0x00BBB890 File Offset: 0x00BB9A90
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int ShowActivityRedMark(IntPtr l)
	{
		int result;
		try
		{
			WorldUIController worldUIController = (WorldUIController)LuaObject.checkSelf(l);
			bool show;
			LuaObject.checkType(l, 2, out show);
			worldUIController.ShowActivityRedMark(show);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060224CE RID: 140494 RVA: 0x00BBB8E8 File Offset: 0x00BB9AE8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int ShowFriendRedMark(IntPtr l)
	{
		int result;
		try
		{
			WorldUIController worldUIController = (WorldUIController)LuaObject.checkSelf(l);
			bool show;
			LuaObject.checkType(l, 2, out show);
			worldUIController.ShowFriendRedMark(show);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060224CF RID: 140495 RVA: 0x00BBB940 File Offset: 0x00BB9B40
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int UpdateNewChatCount(IntPtr l)
	{
		int result;
		try
		{
			WorldUIController worldUIController = (WorldUIController)LuaObject.checkSelf(l);
			int newCount;
			LuaObject.checkType(l, 2, out newCount);
			worldUIController.UpdateNewChatCount(newCount);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060224D0 RID: 140496 RVA: 0x00BBB998 File Offset: 0x00BB9B98
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int UpdateUnreadMailCount(IntPtr l)
	{
		int result;
		try
		{
			WorldUIController worldUIController = (WorldUIController)LuaObject.checkSelf(l);
			int newCount;
			LuaObject.checkType(l, 2, out newCount);
			worldUIController.UpdateUnreadMailCount(newCount);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060224D1 RID: 140497 RVA: 0x00BBB9F0 File Offset: 0x00BB9BF0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int GetUserGuideDialogHideGameObjects(IntPtr l)
	{
		int result;
		try
		{
			WorldUIController worldUIController = (WorldUIController)LuaObject.checkSelf(l);
			List<GameObject> userGuideDialogHideGameObjects = worldUIController.GetUserGuideDialogHideGameObjects();
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, userGuideDialogHideGameObjects);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060224D2 RID: 140498 RVA: 0x00BBBA44 File Offset: 0x00BB9C44
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int UpdateMonthCardOpen(IntPtr l)
	{
		int result;
		try
		{
			WorldUIController worldUIController = (WorldUIController)LuaObject.checkSelf(l);
			bool isOpen;
			LuaObject.checkType(l, 2, out isOpen);
			worldUIController.UpdateMonthCardOpen(isOpen);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060224D3 RID: 140499 RVA: 0x00BBBA9C File Offset: 0x00BB9C9C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int OpenMonthCardPanel(IntPtr l)
	{
		int result;
		try
		{
			WorldUIController worldUIController = (WorldUIController)LuaObject.checkSelf(l);
			List<MonthCard> cardList;
			LuaObject.checkType<List<MonthCard>>(l, 2, out cardList);
			worldUIController.OpenMonthCardPanel(cardList);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060224D4 RID: 140500 RVA: 0x00BBBAF4 File Offset: 0x00BB9CF4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int CloseMonthCardPanel(IntPtr l)
	{
		int result;
		try
		{
			WorldUIController worldUIController = (WorldUIController)LuaObject.checkSelf(l);
			worldUIController.CloseMonthCardPanel();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060224D5 RID: 140501 RVA: 0x00BBBB40 File Offset: 0x00BB9D40
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int UpdateInvestigationButton(IntPtr l)
	{
		int result;
		try
		{
			WorldUIController worldUIController = (WorldUIController)LuaObject.checkSelf(l);
			worldUIController.UpdateInvestigationButton();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060224D6 RID: 140502 RVA: 0x00BBBB8C File Offset: 0x00BB9D8C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int UpdateOpenServiceActivityButton(IntPtr l)
	{
		int result;
		try
		{
			WorldUIController worldUIController = (WorldUIController)LuaObject.checkSelf(l);
			worldUIController.UpdateOpenServiceActivityButton();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060224D7 RID: 140503 RVA: 0x00BBBBD8 File Offset: 0x00BB9DD8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int OnBindFiledsCompleted(IntPtr l)
	{
		int result;
		try
		{
			WorldUIController worldUIController = (WorldUIController)LuaObject.checkSelf(l);
			worldUIController.m_luaExportHelper.OnBindFiledsCompleted();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060224D8 RID: 140504 RVA: 0x00BBBC2C File Offset: 0x00BB9E2C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int OnEnable(IntPtr l)
	{
		int result;
		try
		{
			WorldUIController worldUIController = (WorldUIController)LuaObject.checkSelf(l);
			worldUIController.m_luaExportHelper.OnEnable();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060224D9 RID: 140505 RVA: 0x00BBBC80 File Offset: 0x00BB9E80
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int UpdateDeveloperMode(IntPtr l)
	{
		int result;
		try
		{
			WorldUIController worldUIController = (WorldUIController)LuaObject.checkSelf(l);
			worldUIController.m_luaExportHelper.UpdateDeveloperMode();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060224DA RID: 140506 RVA: 0x00BBBCD4 File Offset: 0x00BB9ED4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int Co_EnterMonster(IntPtr l)
	{
		int result;
		try
		{
			WorldUIController worldUIController = (WorldUIController)LuaObject.checkSelf(l);
			Action onEnd;
			LuaObject.checkDelegate<Action>(l, 2, out onEnd);
			IEnumerator o = worldUIController.m_luaExportHelper.Co_EnterMonster(onEnd);
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

	// Token: 0x060224DB RID: 140507 RVA: 0x00BBBD3C File Offset: 0x00BB9F3C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int DeveloperModeClick(IntPtr l)
	{
		int result;
		try
		{
			WorldUIController worldUIController = (WorldUIController)LuaObject.checkSelf(l);
			worldUIController.m_luaExportHelper.DeveloperModeClick();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060224DC RID: 140508 RVA: 0x00BBBD90 File Offset: 0x00BB9F90
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int OnCompassButtonClick(IntPtr l)
	{
		int result;
		try
		{
			WorldUIController worldUIController = (WorldUIController)LuaObject.checkSelf(l);
			worldUIController.m_luaExportHelper.OnCompassButtonClick();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060224DD RID: 140509 RVA: 0x00BBBDE4 File Offset: 0x00BB9FE4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int OnCurrentScenarioButtonClick(IntPtr l)
	{
		int result;
		try
		{
			WorldUIController worldUIController = (WorldUIController)LuaObject.checkSelf(l);
			worldUIController.m_luaExportHelper.OnCurrentScenarioButtonClick();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060224DE RID: 140510 RVA: 0x00BBBE38 File Offset: 0x00BBA038
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int OnUnlockScenarioBackgroundButtonClick(IntPtr l)
	{
		int result;
		try
		{
			WorldUIController worldUIController = (WorldUIController)LuaObject.checkSelf(l);
			worldUIController.m_luaExportHelper.OnUnlockScenarioBackgroundButtonClick();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060224DF RID: 140511 RVA: 0x00BBBE8C File Offset: 0x00BBA08C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int OnUnlockScenarioGotoButtonClick(IntPtr l)
	{
		int result;
		try
		{
			WorldUIController worldUIController = (WorldUIController)LuaObject.checkSelf(l);
			worldUIController.m_luaExportHelper.OnUnlockScenarioGotoButtonClick();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060224E0 RID: 140512 RVA: 0x00BBBEE0 File Offset: 0x00BBA0E0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int OnMainButtonClick(IntPtr l)
	{
		int result;
		try
		{
			WorldUIController worldUIController = (WorldUIController)LuaObject.checkSelf(l);
			worldUIController.m_luaExportHelper.OnMainButtonClick();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060224E1 RID: 140513 RVA: 0x00BBBF34 File Offset: 0x00BBA134
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int OnPlayerButtonClick(IntPtr l)
	{
		int result;
		try
		{
			WorldUIController worldUIController = (WorldUIController)LuaObject.checkSelf(l);
			UIControllerBase ctrl;
			LuaObject.checkType<UIControllerBase>(l, 2, out ctrl);
			worldUIController.m_luaExportHelper.OnPlayerButtonClick(ctrl);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060224E2 RID: 140514 RVA: 0x00BBBF90 File Offset: 0x00BBA190
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int OnHeroButtonClick(IntPtr l)
	{
		int result;
		try
		{
			WorldUIController worldUIController = (WorldUIController)LuaObject.checkSelf(l);
			UIControllerBase ctrl;
			LuaObject.checkType<UIControllerBase>(l, 2, out ctrl);
			worldUIController.m_luaExportHelper.OnHeroButtonClick(ctrl);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060224E3 RID: 140515 RVA: 0x00BBBFEC File Offset: 0x00BBA1EC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int OnBagButtonClick(IntPtr l)
	{
		int result;
		try
		{
			WorldUIController worldUIController = (WorldUIController)LuaObject.checkSelf(l);
			UIControllerBase ctrl;
			LuaObject.checkType<UIControllerBase>(l, 2, out ctrl);
			worldUIController.m_luaExportHelper.OnBagButtonClick(ctrl);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060224E4 RID: 140516 RVA: 0x00BBC048 File Offset: 0x00BBA248
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int OnSelectCardButtonClick(IntPtr l)
	{
		int result;
		try
		{
			WorldUIController worldUIController = (WorldUIController)LuaObject.checkSelf(l);
			UIControllerBase ctrl;
			LuaObject.checkType<UIControllerBase>(l, 2, out ctrl);
			worldUIController.m_luaExportHelper.OnSelectCardButtonClick(ctrl);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060224E5 RID: 140517 RVA: 0x00BBC0A4 File Offset: 0x00BBA2A4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int OnMissionButtonClick(IntPtr l)
	{
		int result;
		try
		{
			WorldUIController worldUIController = (WorldUIController)LuaObject.checkSelf(l);
			UIControllerBase ctrl;
			LuaObject.checkType<UIControllerBase>(l, 2, out ctrl);
			worldUIController.m_luaExportHelper.OnMissionButtonClick(ctrl);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060224E6 RID: 140518 RVA: 0x00BBC100 File Offset: 0x00BBA300
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int OnFetterButtonClick(IntPtr l)
	{
		int result;
		try
		{
			WorldUIController worldUIController = (WorldUIController)LuaObject.checkSelf(l);
			UIControllerBase ctrl;
			LuaObject.checkType<UIControllerBase>(l, 2, out ctrl);
			worldUIController.m_luaExportHelper.OnFetterButtonClick(ctrl);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060224E7 RID: 140519 RVA: 0x00BBC15C File Offset: 0x00BBA35C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int OnStoreButtonClick(IntPtr l)
	{
		int result;
		try
		{
			WorldUIController worldUIController = (WorldUIController)LuaObject.checkSelf(l);
			UIControllerBase ctrl;
			LuaObject.checkType<UIControllerBase>(l, 2, out ctrl);
			worldUIController.m_luaExportHelper.OnStoreButtonClick(ctrl);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060224E8 RID: 140520 RVA: 0x00BBC1B8 File Offset: 0x00BBA3B8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int OnDrillButtonClick(IntPtr l)
	{
		int result;
		try
		{
			WorldUIController worldUIController = (WorldUIController)LuaObject.checkSelf(l);
			UIControllerBase ctrl;
			LuaObject.checkType<UIControllerBase>(l, 2, out ctrl);
			worldUIController.m_luaExportHelper.OnDrillButtonClick(ctrl);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060224E9 RID: 140521 RVA: 0x00BBC214 File Offset: 0x00BBA414
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int OnFriendButtonClick(IntPtr l)
	{
		int result;
		try
		{
			WorldUIController worldUIController = (WorldUIController)LuaObject.checkSelf(l);
			UIControllerBase ctrl;
			LuaObject.checkType<UIControllerBase>(l, 2, out ctrl);
			worldUIController.m_luaExportHelper.OnFriendButtonClick(ctrl);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060224EA RID: 140522 RVA: 0x00BBC270 File Offset: 0x00BBA470
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int OnGuildButtonClick(IntPtr l)
	{
		int result;
		try
		{
			WorldUIController worldUIController = (WorldUIController)LuaObject.checkSelf(l);
			UIControllerBase ctrl;
			LuaObject.checkType<UIControllerBase>(l, 2, out ctrl);
			worldUIController.m_luaExportHelper.OnGuildButtonClick(ctrl);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060224EB RID: 140523 RVA: 0x00BBC2CC File Offset: 0x00BBA4CC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int OnEventButtonClick(IntPtr l)
	{
		int result;
		try
		{
			WorldUIController worldUIController = (WorldUIController)LuaObject.checkSelf(l);
			UIControllerBase ctrl;
			LuaObject.checkType<UIControllerBase>(l, 2, out ctrl);
			worldUIController.m_luaExportHelper.OnEventButtonClick(ctrl);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060224EC RID: 140524 RVA: 0x00BBC328 File Offset: 0x00BBA528
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int OnUnchartedButtonClick(IntPtr l)
	{
		int result;
		try
		{
			WorldUIController worldUIController = (WorldUIController)LuaObject.checkSelf(l);
			UIControllerBase ctrl;
			LuaObject.checkType<UIControllerBase>(l, 2, out ctrl);
			worldUIController.m_luaExportHelper.OnUnchartedButtonClick(ctrl);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060224ED RID: 140525 RVA: 0x00BBC384 File Offset: 0x00BBA584
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int OnArenaButtonClick(IntPtr l)
	{
		int result;
		try
		{
			WorldUIController worldUIController = (WorldUIController)LuaObject.checkSelf(l);
			UIControllerBase ctrl;
			LuaObject.checkType<UIControllerBase>(l, 2, out ctrl);
			worldUIController.m_luaExportHelper.OnArenaButtonClick(ctrl);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060224EE RID: 140526 RVA: 0x00BBC3E0 File Offset: 0x00BBA5E0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int OnRiftButtonClick(IntPtr l)
	{
		int result;
		try
		{
			WorldUIController worldUIController = (WorldUIController)LuaObject.checkSelf(l);
			UIControllerBase ctrl;
			LuaObject.checkType<UIControllerBase>(l, 2, out ctrl);
			worldUIController.m_luaExportHelper.OnRiftButtonClick(ctrl);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060224EF RID: 140527 RVA: 0x00BBC43C File Offset: 0x00BBA63C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int OnTestButtonClick(IntPtr l)
	{
		int result;
		try
		{
			WorldUIController worldUIController = (WorldUIController)LuaObject.checkSelf(l);
			UIControllerBase ctrl;
			LuaObject.checkType<UIControllerBase>(l, 2, out ctrl);
			worldUIController.m_luaExportHelper.OnTestButtonClick(ctrl);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060224F0 RID: 140528 RVA: 0x00BBC498 File Offset: 0x00BBA698
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int OnCooperateBattleButtonClick(IntPtr l)
	{
		int result;
		try
		{
			WorldUIController worldUIController = (WorldUIController)LuaObject.checkSelf(l);
			worldUIController.m_luaExportHelper.OnCooperateBattleButtonClick();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060224F1 RID: 140529 RVA: 0x00BBC4EC File Offset: 0x00BBA6EC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int OnMailButtonClick(IntPtr l)
	{
		int result;
		try
		{
			WorldUIController worldUIController = (WorldUIController)LuaObject.checkSelf(l);
			UIControllerBase ctrl;
			LuaObject.checkType<UIControllerBase>(l, 2, out ctrl);
			worldUIController.m_luaExportHelper.OnMailButtonClick(ctrl);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060224F2 RID: 140530 RVA: 0x00BBC548 File Offset: 0x00BBA748
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int OnChatButtonClick(IntPtr l)
	{
		int result;
		try
		{
			WorldUIController worldUIController = (WorldUIController)LuaObject.checkSelf(l);
			UIControllerBase ctrl;
			LuaObject.checkType<UIControllerBase>(l, 2, out ctrl);
			worldUIController.m_luaExportHelper.OnChatButtonClick(ctrl);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060224F3 RID: 140531 RVA: 0x00BBC5A4 File Offset: 0x00BBA7A4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int OnRankButtonClick(IntPtr l)
	{
		int result;
		try
		{
			WorldUIController worldUIController = (WorldUIController)LuaObject.checkSelf(l);
			UIControllerBase ctrl;
			LuaObject.checkType<UIControllerBase>(l, 2, out ctrl);
			worldUIController.m_luaExportHelper.OnRankButtonClick(ctrl);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060224F4 RID: 140532 RVA: 0x00BBC600 File Offset: 0x00BBA800
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int OnActivityButtonClick(IntPtr l)
	{
		int result;
		try
		{
			WorldUIController worldUIController = (WorldUIController)LuaObject.checkSelf(l);
			UIControllerBase ctrl;
			LuaObject.checkType<UIControllerBase>(l, 2, out ctrl);
			worldUIController.m_luaExportHelper.OnActivityButtonClick(ctrl);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060224F5 RID: 140533 RVA: 0x00BBC65C File Offset: 0x00BBA85C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int OnOpenServiceActivityButtonClick(IntPtr l)
	{
		int result;
		try
		{
			WorldUIController worldUIController = (WorldUIController)LuaObject.checkSelf(l);
			UIControllerBase ctrl;
			LuaObject.checkType<UIControllerBase>(l, 2, out ctrl);
			worldUIController.m_luaExportHelper.OnOpenServiceActivityButtonClick(ctrl);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060224F6 RID: 140534 RVA: 0x00BBC6B8 File Offset: 0x00BBA8B8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int OnOppoButtonClick(IntPtr l)
	{
		int result;
		try
		{
			WorldUIController worldUIController = (WorldUIController)LuaObject.checkSelf(l);
			UIControllerBase ctrl;
			LuaObject.checkType<UIControllerBase>(l, 2, out ctrl);
			worldUIController.m_luaExportHelper.OnOppoButtonClick(ctrl);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060224F7 RID: 140535 RVA: 0x00BBC714 File Offset: 0x00BBA914
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int OnYingYongBaoButtonClick(IntPtr l)
	{
		int result;
		try
		{
			WorldUIController worldUIController = (WorldUIController)LuaObject.checkSelf(l);
			UIControllerBase ctrl;
			LuaObject.checkType<UIControllerBase>(l, 2, out ctrl);
			worldUIController.m_luaExportHelper.OnYingYongBaoButtonClick(ctrl);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060224F8 RID: 140536 RVA: 0x00BBC770 File Offset: 0x00BBA970
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int OnInvestigationButtonClick(IntPtr l)
	{
		int result;
		try
		{
			WorldUIController worldUIController = (WorldUIController)LuaObject.checkSelf(l);
			UIControllerBase ctrl;
			LuaObject.checkType<UIControllerBase>(l, 2, out ctrl);
			worldUIController.m_luaExportHelper.OnInvestigationButtonClick(ctrl);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060224F9 RID: 140537 RVA: 0x00BBC7CC File Offset: 0x00BBA9CC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int WorldEventListItem_OnButtonClick(IntPtr l)
	{
		int result;
		try
		{
			WorldUIController worldUIController = (WorldUIController)LuaObject.checkSelf(l);
			WorldEventListItemUIController ctrl;
			LuaObject.checkType<WorldEventListItemUIController>(l, 2, out ctrl);
			worldUIController.m_luaExportHelper.WorldEventListItem_OnButtonClick(ctrl);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060224FA RID: 140538 RVA: 0x00BBC828 File Offset: 0x00BBAA28
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int OnEventListBackgroundButtonClick(IntPtr l)
	{
		int result;
		try
		{
			WorldUIController worldUIController = (WorldUIController)LuaObject.checkSelf(l);
			worldUIController.m_luaExportHelper.OnEventListBackgroundButtonClick();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060224FB RID: 140539 RVA: 0x00BBC87C File Offset: 0x00BBAA7C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int OnPastScenarioListBackgroundButtonClick(IntPtr l)
	{
		int result;
		try
		{
			WorldUIController worldUIController = (WorldUIController)LuaObject.checkSelf(l);
			worldUIController.m_luaExportHelper.OnPastScenarioListBackgroundButtonClick();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060224FC RID: 140540 RVA: 0x00BBC8D0 File Offset: 0x00BBAAD0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int PastScenarioListItem_OnStartButtonClick(IntPtr l)
	{
		int result;
		try
		{
			WorldUIController worldUIController = (WorldUIController)LuaObject.checkSelf(l);
			PastScenarioListItemUIController ctrl;
			LuaObject.checkType<PastScenarioListItemUIController>(l, 2, out ctrl);
			worldUIController.m_luaExportHelper.PastScenarioListItem_OnStartButtonClick(ctrl);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060224FD RID: 140541 RVA: 0x00BBC92C File Offset: 0x00BBAB2C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int OnMonthCardButtonClick(IntPtr l)
	{
		int result;
		try
		{
			WorldUIController worldUIController = (WorldUIController)LuaObject.checkSelf(l);
			worldUIController.m_luaExportHelper.OnMonthCardButtonClick();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060224FE RID: 140542 RVA: 0x00BBC980 File Offset: 0x00BBAB80
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int OnMonthCardCloseButtonClick(IntPtr l)
	{
		int result;
		try
		{
			WorldUIController worldUIController = (WorldUIController)LuaObject.checkSelf(l);
			worldUIController.m_luaExportHelper.OnMonthCardCloseButtonClick();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060224FF RID: 140543 RVA: 0x00BBC9D4 File Offset: 0x00BBABD4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int OnMonthCardItemItemClick(IntPtr l)
	{
		int result;
		try
		{
			WorldUIController worldUIController = (WorldUIController)LuaObject.checkSelf(l);
			int cardId;
			LuaObject.checkType(l, 2, out cardId);
			worldUIController.m_luaExportHelper.OnMonthCardItemItemClick(cardId);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06022500 RID: 140544 RVA: 0x00BBCA30 File Offset: 0x00BBAC30
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int OnMonthCardBuyClick(IntPtr l)
	{
		int result;
		try
		{
			WorldUIController worldUIController = (WorldUIController)LuaObject.checkSelf(l);
			int cardId;
			LuaObject.checkType(l, 2, out cardId);
			worldUIController.m_luaExportHelper.OnMonthCardBuyClick(cardId);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06022501 RID: 140545 RVA: 0x00BBCA8C File Offset: 0x00BBAC8C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_Initlize(IntPtr l)
	{
		int result;
		try
		{
			WorldUIController worldUIController = (WorldUIController)LuaObject.checkSelf(l);
			string ctrlName;
			LuaObject.checkType(l, 2, out ctrlName);
			bool bindNow;
			LuaObject.checkType(l, 3, out bindNow);
			worldUIController.m_luaExportHelper.__callBase_Initlize(ctrlName, bindNow);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06022502 RID: 140546 RVA: 0x00BBCAF8 File Offset: 0x00BBACF8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_BindFields(IntPtr l)
	{
		int result;
		try
		{
			WorldUIController worldUIController = (WorldUIController)LuaObject.checkSelf(l);
			worldUIController.m_luaExportHelper.__callBase_BindFields();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06022503 RID: 140547 RVA: 0x00BBCB4C File Offset: 0x00BBAD4C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_OnBindFiledsCompleted(IntPtr l)
	{
		int result;
		try
		{
			WorldUIController worldUIController = (WorldUIController)LuaObject.checkSelf(l);
			worldUIController.m_luaExportHelper.__callBase_OnBindFiledsCompleted();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06022504 RID: 140548 RVA: 0x00BBCBA0 File Offset: 0x00BBADA0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_BindFieldImpl(IntPtr l)
	{
		int result;
		try
		{
			WorldUIController worldUIController = (WorldUIController)LuaObject.checkSelf(l);
			Type fieldType;
			LuaObject.checkType(l, 2, out fieldType);
			string path;
			LuaObject.checkType(l, 3, out path);
			AutoBindAttribute.InitState initState;
			LuaObject.checkEnum<AutoBindAttribute.InitState>(l, 4, out initState);
			string fieldName;
			LuaObject.checkType(l, 5, out fieldName);
			string ctrlName;
			LuaObject.checkType(l, 6, out ctrlName);
			bool optional;
			LuaObject.checkType(l, 7, out optional);
			UnityEngine.Object o = worldUIController.m_luaExportHelper.__callBase_BindFieldImpl(fieldType, path, initState, fieldName, ctrlName, optional);
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

	// Token: 0x06022505 RID: 140549 RVA: 0x00BBCC48 File Offset: 0x00BBAE48
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_Clear(IntPtr l)
	{
		int result;
		try
		{
			WorldUIController worldUIController = (WorldUIController)LuaObject.checkSelf(l);
			worldUIController.m_luaExportHelper.__callBase_Clear();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06022506 RID: 140550 RVA: 0x00BBCC9C File Offset: 0x00BBAE9C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_OnButtonClick(IntPtr l)
	{
		int result;
		try
		{
			WorldUIController worldUIController = (WorldUIController)LuaObject.checkSelf(l);
			Button button;
			LuaObject.checkType<Button>(l, 2, out button);
			string fieldName;
			LuaObject.checkType(l, 3, out fieldName);
			worldUIController.m_luaExportHelper.__callBase_OnButtonClick(button, fieldName);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06022507 RID: 140551 RVA: 0x00BBCD08 File Offset: 0x00BBAF08
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_SetButtonClickListener(IntPtr l)
	{
		int result;
		try
		{
			int total = LuaDLL.lua_gettop(l);
			if (LuaObject.matchType(l, total, 2, typeof(string[]), typeof(Action<UIControllerBase>)))
			{
				WorldUIController worldUIController = (WorldUIController)LuaObject.checkSelf(l);
				string[] fieldNames;
				LuaObject.checkArray<string>(l, 2, out fieldNames);
				Action<UIControllerBase> action;
				LuaObject.checkDelegate<Action<UIControllerBase>>(l, 3, out action);
				worldUIController.m_luaExportHelper.__callBase_SetButtonClickListener(fieldNames, action);
				LuaObject.pushValue(l, true);
				result = 1;
			}
			else if (LuaObject.matchType(l, total, 2, typeof(string), typeof(Action<UIControllerBase>)))
			{
				WorldUIController worldUIController2 = (WorldUIController)LuaObject.checkSelf(l);
				string fieldName;
				LuaObject.checkType(l, 2, out fieldName);
				Action<UIControllerBase> action2;
				LuaObject.checkDelegate<Action<UIControllerBase>>(l, 3, out action2);
				worldUIController2.m_luaExportHelper.__callBase_SetButtonClickListener(fieldName, action2);
				LuaObject.pushValue(l, true);
				result = 1;
			}
			else
			{
				LuaObject.pushValue(l, false);
				LuaDLL.lua_pushstring(l, "No matched override function __callBase_SetButtonClickListener to call");
				result = 2;
			}
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06022508 RID: 140552 RVA: 0x00BBCE18 File Offset: 0x00BBB018
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_SetButtonDoubleClickListener(IntPtr l)
	{
		int result;
		try
		{
			WorldUIController worldUIController = (WorldUIController)LuaObject.checkSelf(l);
			string fieldName;
			LuaObject.checkType(l, 2, out fieldName);
			Action<UIControllerBase> action;
			LuaObject.checkDelegate<Action<UIControllerBase>>(l, 3, out action);
			worldUIController.m_luaExportHelper.__callBase_SetButtonDoubleClickListener(fieldName, action);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06022509 RID: 140553 RVA: 0x00BBCE84 File Offset: 0x00BBB084
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_SetButtonLongPressStartListener(IntPtr l)
	{
		int result;
		try
		{
			WorldUIController worldUIController = (WorldUIController)LuaObject.checkSelf(l);
			string fieldName;
			LuaObject.checkType(l, 2, out fieldName);
			Action<UIControllerBase> action;
			LuaObject.checkDelegate<Action<UIControllerBase>>(l, 3, out action);
			worldUIController.m_luaExportHelper.__callBase_SetButtonLongPressStartListener(fieldName, action);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0602250A RID: 140554 RVA: 0x00BBCEF0 File Offset: 0x00BBB0F0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_SetButtonLongPressingListener(IntPtr l)
	{
		int result;
		try
		{
			WorldUIController worldUIController = (WorldUIController)LuaObject.checkSelf(l);
			string fieldName;
			LuaObject.checkType(l, 2, out fieldName);
			Action<UIControllerBase> action;
			LuaObject.checkDelegate<Action<UIControllerBase>>(l, 3, out action);
			worldUIController.m_luaExportHelper.__callBase_SetButtonLongPressingListener(fieldName, action);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0602250B RID: 140555 RVA: 0x00BBCF5C File Offset: 0x00BBB15C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_SetButtonLongPressEndListener(IntPtr l)
	{
		int result;
		try
		{
			WorldUIController worldUIController = (WorldUIController)LuaObject.checkSelf(l);
			string fieldName;
			LuaObject.checkType(l, 2, out fieldName);
			Action<UIControllerBase> action;
			LuaObject.checkDelegate<Action<UIControllerBase>>(l, 3, out action);
			worldUIController.m_luaExportHelper.__callBase_SetButtonLongPressEndListener(fieldName, action);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0602250C RID: 140556 RVA: 0x00BBCFC8 File Offset: 0x00BBB1C8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_SetToggleValueChangedListener(IntPtr l)
	{
		int result;
		try
		{
			int total = LuaDLL.lua_gettop(l);
			if (LuaObject.matchType(l, total, 2, typeof(string[]), typeof(Action<UIControllerBase, bool>)))
			{
				WorldUIController worldUIController = (WorldUIController)LuaObject.checkSelf(l);
				string[] fieldNames;
				LuaObject.checkArray<string>(l, 2, out fieldNames);
				Action<UIControllerBase, bool> action;
				LuaObject.checkDelegate<Action<UIControllerBase, bool>>(l, 3, out action);
				worldUIController.m_luaExportHelper.__callBase_SetToggleValueChangedListener(fieldNames, action);
				LuaObject.pushValue(l, true);
				result = 1;
			}
			else if (LuaObject.matchType(l, total, 2, typeof(string), typeof(Action<UIControllerBase, bool>)))
			{
				WorldUIController worldUIController2 = (WorldUIController)LuaObject.checkSelf(l);
				string fieldName;
				LuaObject.checkType(l, 2, out fieldName);
				Action<UIControllerBase, bool> action2;
				LuaObject.checkDelegate<Action<UIControllerBase, bool>>(l, 3, out action2);
				worldUIController2.m_luaExportHelper.__callBase_SetToggleValueChangedListener(fieldName, action2);
				LuaObject.pushValue(l, true);
				result = 1;
			}
			else
			{
				LuaObject.pushValue(l, false);
				LuaDLL.lua_pushstring(l, "No matched override function __callBase_SetToggleValueChangedListener to call");
				result = 2;
			}
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0602250D RID: 140557 RVA: 0x00BBD0D8 File Offset: 0x00BBB2D8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_ToString(IntPtr l)
	{
		int result;
		try
		{
			WorldUIController worldUIController = (WorldUIController)LuaObject.checkSelf(l);
			string s = worldUIController.m_luaExportHelper.__callBase_ToString();
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

	// Token: 0x0602250E RID: 140558 RVA: 0x00BBD134 File Offset: 0x00BBB334
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callDele_EventOnShowPlayerInfo(IntPtr l)
	{
		int result;
		try
		{
			WorldUIController worldUIController = (WorldUIController)LuaObject.checkSelf(l);
			worldUIController.m_luaExportHelper.__callDele_EventOnShowPlayerInfo();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0602250F RID: 140559 RVA: 0x00BBD188 File Offset: 0x00BBB388
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __clearDele_EventOnShowPlayerInfo(IntPtr l)
	{
		int result;
		try
		{
			WorldUIController worldUIController = (WorldUIController)LuaObject.checkSelf(l);
			worldUIController.m_luaExportHelper.__clearDele_EventOnShowPlayerInfo();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06022510 RID: 140560 RVA: 0x00BBD1DC File Offset: 0x00BBB3DC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callDele_EventOnCompass(IntPtr l)
	{
		int result;
		try
		{
			WorldUIController worldUIController = (WorldUIController)LuaObject.checkSelf(l);
			worldUIController.m_luaExportHelper.__callDele_EventOnCompass();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06022511 RID: 140561 RVA: 0x00BBD230 File Offset: 0x00BBB430
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __clearDele_EventOnCompass(IntPtr l)
	{
		int result;
		try
		{
			WorldUIController worldUIController = (WorldUIController)LuaObject.checkSelf(l);
			worldUIController.m_luaExportHelper.__clearDele_EventOnCompass();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06022512 RID: 140562 RVA: 0x00BBD284 File Offset: 0x00BBB484
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callDele_EventOnCurrentScenario(IntPtr l)
	{
		int result;
		try
		{
			WorldUIController worldUIController = (WorldUIController)LuaObject.checkSelf(l);
			worldUIController.m_luaExportHelper.__callDele_EventOnCurrentScenario();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06022513 RID: 140563 RVA: 0x00BBD2D8 File Offset: 0x00BBB4D8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __clearDele_EventOnCurrentScenario(IntPtr l)
	{
		int result;
		try
		{
			WorldUIController worldUIController = (WorldUIController)LuaObject.checkSelf(l);
			worldUIController.m_luaExportHelper.__clearDele_EventOnCurrentScenario();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06022514 RID: 140564 RVA: 0x00BBD32C File Offset: 0x00BBB52C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callDele_EventOnShowMainButtonBar(IntPtr l)
	{
		int result;
		try
		{
			WorldUIController worldUIController = (WorldUIController)LuaObject.checkSelf(l);
			bool obj;
			LuaObject.checkType(l, 2, out obj);
			worldUIController.m_luaExportHelper.__callDele_EventOnShowMainButtonBar(obj);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06022515 RID: 140565 RVA: 0x00BBD388 File Offset: 0x00BBB588
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __clearDele_EventOnShowMainButtonBar(IntPtr l)
	{
		int result;
		try
		{
			WorldUIController worldUIController = (WorldUIController)LuaObject.checkSelf(l);
			bool obj;
			LuaObject.checkType(l, 2, out obj);
			worldUIController.m_luaExportHelper.__clearDele_EventOnShowMainButtonBar(obj);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06022516 RID: 140566 RVA: 0x00BBD3E4 File Offset: 0x00BBB5E4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callDele_EventOnUnlockScenarioGotoRiftLevel(IntPtr l)
	{
		int result;
		try
		{
			WorldUIController worldUIController = (WorldUIController)LuaObject.checkSelf(l);
			ConfigDataRiftLevelInfo obj;
			LuaObject.checkType<ConfigDataRiftLevelInfo>(l, 2, out obj);
			worldUIController.m_luaExportHelper.__callDele_EventOnUnlockScenarioGotoRiftLevel(obj);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06022517 RID: 140567 RVA: 0x00BBD440 File Offset: 0x00BBB640
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __clearDele_EventOnUnlockScenarioGotoRiftLevel(IntPtr l)
	{
		int result;
		try
		{
			WorldUIController worldUIController = (WorldUIController)LuaObject.checkSelf(l);
			ConfigDataRiftLevelInfo obj;
			LuaObject.checkType<ConfigDataRiftLevelInfo>(l, 2, out obj);
			worldUIController.m_luaExportHelper.__clearDele_EventOnUnlockScenarioGotoRiftLevel(obj);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06022518 RID: 140568 RVA: 0x00BBD49C File Offset: 0x00BBB69C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callDele_EventOnGotoEvent(IntPtr l)
	{
		int result;
		try
		{
			WorldUIController worldUIController = (WorldUIController)LuaObject.checkSelf(l);
			ConfigDataWaypointInfo arg;
			LuaObject.checkType<ConfigDataWaypointInfo>(l, 2, out arg);
			ConfigDataEventInfo arg2;
			LuaObject.checkType<ConfigDataEventInfo>(l, 3, out arg2);
			worldUIController.m_luaExportHelper.__callDele_EventOnGotoEvent(arg, arg2);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06022519 RID: 140569 RVA: 0x00BBD508 File Offset: 0x00BBB708
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __clearDele_EventOnGotoEvent(IntPtr l)
	{
		int result;
		try
		{
			WorldUIController worldUIController = (WorldUIController)LuaObject.checkSelf(l);
			ConfigDataWaypointInfo arg;
			LuaObject.checkType<ConfigDataWaypointInfo>(l, 2, out arg);
			ConfigDataEventInfo arg2;
			LuaObject.checkType<ConfigDataEventInfo>(l, 3, out arg2);
			worldUIController.m_luaExportHelper.__clearDele_EventOnGotoEvent(arg, arg2);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0602251A RID: 140570 RVA: 0x00BBD574 File Offset: 0x00BBB774
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callDele_EventOnStartPastScenario(IntPtr l)
	{
		int result;
		try
		{
			WorldUIController worldUIController = (WorldUIController)LuaObject.checkSelf(l);
			ConfigDataScenarioInfo obj;
			LuaObject.checkType<ConfigDataScenarioInfo>(l, 2, out obj);
			worldUIController.m_luaExportHelper.__callDele_EventOnStartPastScenario(obj);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0602251B RID: 140571 RVA: 0x00BBD5D0 File Offset: 0x00BBB7D0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __clearDele_EventOnStartPastScenario(IntPtr l)
	{
		int result;
		try
		{
			WorldUIController worldUIController = (WorldUIController)LuaObject.checkSelf(l);
			ConfigDataScenarioInfo obj;
			LuaObject.checkType<ConfigDataScenarioInfo>(l, 2, out obj);
			worldUIController.m_luaExportHelper.__clearDele_EventOnStartPastScenario(obj);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0602251C RID: 140572 RVA: 0x00BBD62C File Offset: 0x00BBB82C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callDele_EventOnClosePastScenarioList(IntPtr l)
	{
		int result;
		try
		{
			WorldUIController worldUIController = (WorldUIController)LuaObject.checkSelf(l);
			worldUIController.m_luaExportHelper.__callDele_EventOnClosePastScenarioList();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0602251D RID: 140573 RVA: 0x00BBD680 File Offset: 0x00BBB880
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __clearDele_EventOnClosePastScenarioList(IntPtr l)
	{
		int result;
		try
		{
			WorldUIController worldUIController = (WorldUIController)LuaObject.checkSelf(l);
			worldUIController.m_luaExportHelper.__clearDele_EventOnClosePastScenarioList();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0602251E RID: 140574 RVA: 0x00BBD6D4 File Offset: 0x00BBB8D4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callDele_EventOnShowHero(IntPtr l)
	{
		int result;
		try
		{
			WorldUIController worldUIController = (WorldUIController)LuaObject.checkSelf(l);
			worldUIController.m_luaExportHelper.__callDele_EventOnShowHero();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0602251F RID: 140575 RVA: 0x00BBD728 File Offset: 0x00BBB928
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __clearDele_EventOnShowHero(IntPtr l)
	{
		int result;
		try
		{
			WorldUIController worldUIController = (WorldUIController)LuaObject.checkSelf(l);
			worldUIController.m_luaExportHelper.__clearDele_EventOnShowHero();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06022520 RID: 140576 RVA: 0x00BBD77C File Offset: 0x00BBB97C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callDele_EventOnShowBag(IntPtr l)
	{
		int result;
		try
		{
			WorldUIController worldUIController = (WorldUIController)LuaObject.checkSelf(l);
			worldUIController.m_luaExportHelper.__callDele_EventOnShowBag();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06022521 RID: 140577 RVA: 0x00BBD7D0 File Offset: 0x00BBB9D0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __clearDele_EventOnShowBag(IntPtr l)
	{
		int result;
		try
		{
			WorldUIController worldUIController = (WorldUIController)LuaObject.checkSelf(l);
			worldUIController.m_luaExportHelper.__clearDele_EventOnShowBag();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06022522 RID: 140578 RVA: 0x00BBD824 File Offset: 0x00BBBA24
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callDele_EventOnShowSelectCard(IntPtr l)
	{
		int result;
		try
		{
			WorldUIController worldUIController = (WorldUIController)LuaObject.checkSelf(l);
			worldUIController.m_luaExportHelper.__callDele_EventOnShowSelectCard();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06022523 RID: 140579 RVA: 0x00BBD878 File Offset: 0x00BBBA78
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __clearDele_EventOnShowSelectCard(IntPtr l)
	{
		int result;
		try
		{
			WorldUIController worldUIController = (WorldUIController)LuaObject.checkSelf(l);
			worldUIController.m_luaExportHelper.__clearDele_EventOnShowSelectCard();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06022524 RID: 140580 RVA: 0x00BBD8CC File Offset: 0x00BBBACC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callDele_EventOnShowMisision(IntPtr l)
	{
		int result;
		try
		{
			WorldUIController worldUIController = (WorldUIController)LuaObject.checkSelf(l);
			worldUIController.m_luaExportHelper.__callDele_EventOnShowMisision();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06022525 RID: 140581 RVA: 0x00BBD920 File Offset: 0x00BBBB20
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __clearDele_EventOnShowMisision(IntPtr l)
	{
		int result;
		try
		{
			WorldUIController worldUIController = (WorldUIController)LuaObject.checkSelf(l);
			worldUIController.m_luaExportHelper.__clearDele_EventOnShowMisision();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06022526 RID: 140582 RVA: 0x00BBD974 File Offset: 0x00BBBB74
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callDele_EventOnShowFetter(IntPtr l)
	{
		int result;
		try
		{
			WorldUIController worldUIController = (WorldUIController)LuaObject.checkSelf(l);
			worldUIController.m_luaExportHelper.__callDele_EventOnShowFetter();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06022527 RID: 140583 RVA: 0x00BBD9C8 File Offset: 0x00BBBBC8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __clearDele_EventOnShowFetter(IntPtr l)
	{
		int result;
		try
		{
			WorldUIController worldUIController = (WorldUIController)LuaObject.checkSelf(l);
			worldUIController.m_luaExportHelper.__clearDele_EventOnShowFetter();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06022528 RID: 140584 RVA: 0x00BBDA1C File Offset: 0x00BBBC1C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callDele_EventOnShowStore(IntPtr l)
	{
		int result;
		try
		{
			WorldUIController worldUIController = (WorldUIController)LuaObject.checkSelf(l);
			worldUIController.m_luaExportHelper.__callDele_EventOnShowStore();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06022529 RID: 140585 RVA: 0x00BBDA70 File Offset: 0x00BBBC70
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __clearDele_EventOnShowStore(IntPtr l)
	{
		int result;
		try
		{
			WorldUIController worldUIController = (WorldUIController)LuaObject.checkSelf(l);
			worldUIController.m_luaExportHelper.__clearDele_EventOnShowStore();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0602252A RID: 140586 RVA: 0x00BBDAC4 File Offset: 0x00BBBCC4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callDele_EventOnShowDrill(IntPtr l)
	{
		int result;
		try
		{
			WorldUIController worldUIController = (WorldUIController)LuaObject.checkSelf(l);
			worldUIController.m_luaExportHelper.__callDele_EventOnShowDrill();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0602252B RID: 140587 RVA: 0x00BBDB18 File Offset: 0x00BBBD18
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __clearDele_EventOnShowDrill(IntPtr l)
	{
		int result;
		try
		{
			WorldUIController worldUIController = (WorldUIController)LuaObject.checkSelf(l);
			worldUIController.m_luaExportHelper.__clearDele_EventOnShowDrill();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0602252C RID: 140588 RVA: 0x00BBDB6C File Offset: 0x00BBBD6C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callDele_EventOnShowFriend(IntPtr l)
	{
		int result;
		try
		{
			WorldUIController worldUIController = (WorldUIController)LuaObject.checkSelf(l);
			worldUIController.m_luaExportHelper.__callDele_EventOnShowFriend();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0602252D RID: 140589 RVA: 0x00BBDBC0 File Offset: 0x00BBBDC0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __clearDele_EventOnShowFriend(IntPtr l)
	{
		int result;
		try
		{
			WorldUIController worldUIController = (WorldUIController)LuaObject.checkSelf(l);
			worldUIController.m_luaExportHelper.__clearDele_EventOnShowFriend();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0602252E RID: 140590 RVA: 0x00BBDC14 File Offset: 0x00BBBE14
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callDele_EventOnShowGuild(IntPtr l)
	{
		int result;
		try
		{
			WorldUIController worldUIController = (WorldUIController)LuaObject.checkSelf(l);
			worldUIController.m_luaExportHelper.__callDele_EventOnShowGuild();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0602252F RID: 140591 RVA: 0x00BBDC68 File Offset: 0x00BBBE68
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __clearDele_EventOnShowGuild(IntPtr l)
	{
		int result;
		try
		{
			WorldUIController worldUIController = (WorldUIController)LuaObject.checkSelf(l);
			worldUIController.m_luaExportHelper.__clearDele_EventOnShowGuild();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06022530 RID: 140592 RVA: 0x00BBDCBC File Offset: 0x00BBBEBC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callDele_EventOnShowEvent(IntPtr l)
	{
		int result;
		try
		{
			WorldUIController worldUIController = (WorldUIController)LuaObject.checkSelf(l);
			worldUIController.m_luaExportHelper.__callDele_EventOnShowEvent();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06022531 RID: 140593 RVA: 0x00BBDD10 File Offset: 0x00BBBF10
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __clearDele_EventOnShowEvent(IntPtr l)
	{
		int result;
		try
		{
			WorldUIController worldUIController = (WorldUIController)LuaObject.checkSelf(l);
			worldUIController.m_luaExportHelper.__clearDele_EventOnShowEvent();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06022532 RID: 140594 RVA: 0x00BBDD64 File Offset: 0x00BBBF64
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callDele_EventOnShowUncharted(IntPtr l)
	{
		int result;
		try
		{
			WorldUIController worldUIController = (WorldUIController)LuaObject.checkSelf(l);
			worldUIController.m_luaExportHelper.__callDele_EventOnShowUncharted();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06022533 RID: 140595 RVA: 0x00BBDDB8 File Offset: 0x00BBBFB8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __clearDele_EventOnShowUncharted(IntPtr l)
	{
		int result;
		try
		{
			WorldUIController worldUIController = (WorldUIController)LuaObject.checkSelf(l);
			worldUIController.m_luaExportHelper.__clearDele_EventOnShowUncharted();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06022534 RID: 140596 RVA: 0x00BBDE0C File Offset: 0x00BBC00C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callDele_EventOnShowArena(IntPtr l)
	{
		int result;
		try
		{
			WorldUIController worldUIController = (WorldUIController)LuaObject.checkSelf(l);
			worldUIController.m_luaExportHelper.__callDele_EventOnShowArena();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06022535 RID: 140597 RVA: 0x00BBDE60 File Offset: 0x00BBC060
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __clearDele_EventOnShowArena(IntPtr l)
	{
		int result;
		try
		{
			WorldUIController worldUIController = (WorldUIController)LuaObject.checkSelf(l);
			worldUIController.m_luaExportHelper.__clearDele_EventOnShowArena();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06022536 RID: 140598 RVA: 0x00BBDEB4 File Offset: 0x00BBC0B4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callDele_EventOnShowRift(IntPtr l)
	{
		int result;
		try
		{
			WorldUIController worldUIController = (WorldUIController)LuaObject.checkSelf(l);
			worldUIController.m_luaExportHelper.__callDele_EventOnShowRift();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06022537 RID: 140599 RVA: 0x00BBDF08 File Offset: 0x00BBC108
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __clearDele_EventOnShowRift(IntPtr l)
	{
		int result;
		try
		{
			WorldUIController worldUIController = (WorldUIController)LuaObject.checkSelf(l);
			worldUIController.m_luaExportHelper.__clearDele_EventOnShowRift();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06022538 RID: 140600 RVA: 0x00BBDF5C File Offset: 0x00BBC15C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callDele_EventOnShowTest(IntPtr l)
	{
		int result;
		try
		{
			WorldUIController worldUIController = (WorldUIController)LuaObject.checkSelf(l);
			worldUIController.m_luaExportHelper.__callDele_EventOnShowTest();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06022539 RID: 140601 RVA: 0x00BBDFB0 File Offset: 0x00BBC1B0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __clearDele_EventOnShowTest(IntPtr l)
	{
		int result;
		try
		{
			WorldUIController worldUIController = (WorldUIController)LuaObject.checkSelf(l);
			worldUIController.m_luaExportHelper.__clearDele_EventOnShowTest();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0602253A RID: 140602 RVA: 0x00BBE004 File Offset: 0x00BBC204
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callDele_EventOnShowCooperateBattle(IntPtr l)
	{
		int result;
		try
		{
			WorldUIController worldUIController = (WorldUIController)LuaObject.checkSelf(l);
			worldUIController.m_luaExportHelper.__callDele_EventOnShowCooperateBattle();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0602253B RID: 140603 RVA: 0x00BBE058 File Offset: 0x00BBC258
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __clearDele_EventOnShowCooperateBattle(IntPtr l)
	{
		int result;
		try
		{
			WorldUIController worldUIController = (WorldUIController)LuaObject.checkSelf(l);
			worldUIController.m_luaExportHelper.__clearDele_EventOnShowCooperateBattle();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0602253C RID: 140604 RVA: 0x00BBE0AC File Offset: 0x00BBC2AC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callDele_EventOnShowMail(IntPtr l)
	{
		int result;
		try
		{
			WorldUIController worldUIController = (WorldUIController)LuaObject.checkSelf(l);
			worldUIController.m_luaExportHelper.__callDele_EventOnShowMail();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0602253D RID: 140605 RVA: 0x00BBE100 File Offset: 0x00BBC300
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __clearDele_EventOnShowMail(IntPtr l)
	{
		int result;
		try
		{
			WorldUIController worldUIController = (WorldUIController)LuaObject.checkSelf(l);
			worldUIController.m_luaExportHelper.__clearDele_EventOnShowMail();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0602253E RID: 140606 RVA: 0x00BBE154 File Offset: 0x00BBC354
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callDele_EventOnShowChat(IntPtr l)
	{
		int result;
		try
		{
			WorldUIController worldUIController = (WorldUIController)LuaObject.checkSelf(l);
			worldUIController.m_luaExportHelper.__callDele_EventOnShowChat();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0602253F RID: 140607 RVA: 0x00BBE1A8 File Offset: 0x00BBC3A8
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int __clearDele_EventOnShowChat(IntPtr l)
	{
		int result;
		try
		{
			WorldUIController worldUIController = (WorldUIController)LuaObject.checkSelf(l);
			worldUIController.m_luaExportHelper.__clearDele_EventOnShowChat();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06022540 RID: 140608 RVA: 0x00BBE1FC File Offset: 0x00BBC3FC
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int __callDele_EventOnShowRanking(IntPtr l)
	{
		int result;
		try
		{
			WorldUIController worldUIController = (WorldUIController)LuaObject.checkSelf(l);
			worldUIController.m_luaExportHelper.__callDele_EventOnShowRanking();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06022541 RID: 140609 RVA: 0x00BBE250 File Offset: 0x00BBC450
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __clearDele_EventOnShowRanking(IntPtr l)
	{
		int result;
		try
		{
			WorldUIController worldUIController = (WorldUIController)LuaObject.checkSelf(l);
			worldUIController.m_luaExportHelper.__clearDele_EventOnShowRanking();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06022542 RID: 140610 RVA: 0x00BBE2A4 File Offset: 0x00BBC4A4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callDele_EventOnShowAnnouncement(IntPtr l)
	{
		int result;
		try
		{
			WorldUIController worldUIController = (WorldUIController)LuaObject.checkSelf(l);
			worldUIController.m_luaExportHelper.__callDele_EventOnShowAnnouncement();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06022543 RID: 140611 RVA: 0x00BBE2F8 File Offset: 0x00BBC4F8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __clearDele_EventOnShowAnnouncement(IntPtr l)
	{
		int result;
		try
		{
			WorldUIController worldUIController = (WorldUIController)LuaObject.checkSelf(l);
			worldUIController.m_luaExportHelper.__clearDele_EventOnShowAnnouncement();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06022544 RID: 140612 RVA: 0x00BBE34C File Offset: 0x00BBC54C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callDele_EventOnOpenWebInvestigation(IntPtr l)
	{
		int result;
		try
		{
			WorldUIController worldUIController = (WorldUIController)LuaObject.checkSelf(l);
			worldUIController.m_luaExportHelper.__callDele_EventOnOpenWebInvestigation();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06022545 RID: 140613 RVA: 0x00BBE3A0 File Offset: 0x00BBC5A0
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int __clearDele_EventOnOpenWebInvestigation(IntPtr l)
	{
		int result;
		try
		{
			WorldUIController worldUIController = (WorldUIController)LuaObject.checkSelf(l);
			worldUIController.m_luaExportHelper.__clearDele_EventOnOpenWebInvestigation();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06022546 RID: 140614 RVA: 0x00BBE3F4 File Offset: 0x00BBC5F4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callDele_EventOnShowOpenServiceActivity(IntPtr l)
	{
		int result;
		try
		{
			WorldUIController worldUIController = (WorldUIController)LuaObject.checkSelf(l);
			worldUIController.m_luaExportHelper.__callDele_EventOnShowOpenServiceActivity();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06022547 RID: 140615 RVA: 0x00BBE448 File Offset: 0x00BBC648
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int __clearDele_EventOnShowOpenServiceActivity(IntPtr l)
	{
		int result;
		try
		{
			WorldUIController worldUIController = (WorldUIController)LuaObject.checkSelf(l);
			worldUIController.m_luaExportHelper.__clearDele_EventOnShowOpenServiceActivity();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06022548 RID: 140616 RVA: 0x00BBE49C File Offset: 0x00BBC69C
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int __callDele_EventOnMonthCardButtonClick(IntPtr l)
	{
		int result;
		try
		{
			WorldUIController worldUIController = (WorldUIController)LuaObject.checkSelf(l);
			worldUIController.m_luaExportHelper.__callDele_EventOnMonthCardButtonClick();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06022549 RID: 140617 RVA: 0x00BBE4F0 File Offset: 0x00BBC6F0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __clearDele_EventOnMonthCardButtonClick(IntPtr l)
	{
		int result;
		try
		{
			WorldUIController worldUIController = (WorldUIController)LuaObject.checkSelf(l);
			worldUIController.m_luaExportHelper.__clearDele_EventOnMonthCardButtonClick();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0602254A RID: 140618 RVA: 0x00BBE544 File Offset: 0x00BBC744
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callDele_EventOnRefreshMonthCardPanel(IntPtr l)
	{
		int result;
		try
		{
			WorldUIController worldUIController = (WorldUIController)LuaObject.checkSelf(l);
			bool obj;
			LuaObject.checkType(l, 2, out obj);
			worldUIController.m_luaExportHelper.__callDele_EventOnRefreshMonthCardPanel(obj);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0602254B RID: 140619 RVA: 0x00BBE5A0 File Offset: 0x00BBC7A0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __clearDele_EventOnRefreshMonthCardPanel(IntPtr l)
	{
		int result;
		try
		{
			WorldUIController worldUIController = (WorldUIController)LuaObject.checkSelf(l);
			bool obj;
			LuaObject.checkType(l, 2, out obj);
			worldUIController.m_luaExportHelper.__clearDele_EventOnRefreshMonthCardPanel(obj);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0602254C RID: 140620 RVA: 0x00BBE5FC File Offset: 0x00BBC7FC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callDele_EventOnMonthCardItemClick(IntPtr l)
	{
		int result;
		try
		{
			WorldUIController worldUIController = (WorldUIController)LuaObject.checkSelf(l);
			int obj;
			LuaObject.checkType(l, 2, out obj);
			worldUIController.m_luaExportHelper.__callDele_EventOnMonthCardItemClick(obj);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0602254D RID: 140621 RVA: 0x00BBE658 File Offset: 0x00BBC858
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __clearDele_EventOnMonthCardItemClick(IntPtr l)
	{
		int result;
		try
		{
			WorldUIController worldUIController = (WorldUIController)LuaObject.checkSelf(l);
			int obj;
			LuaObject.checkType(l, 2, out obj);
			worldUIController.m_luaExportHelper.__clearDele_EventOnMonthCardItemClick(obj);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0602254E RID: 140622 RVA: 0x00BBE6B4 File Offset: 0x00BBC8B4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callDele_EventOnMonthCardItemBuyClick(IntPtr l)
	{
		int result;
		try
		{
			WorldUIController worldUIController = (WorldUIController)LuaObject.checkSelf(l);
			int obj;
			LuaObject.checkType(l, 2, out obj);
			worldUIController.m_luaExportHelper.__callDele_EventOnMonthCardItemBuyClick(obj);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0602254F RID: 140623 RVA: 0x00BBE710 File Offset: 0x00BBC910
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __clearDele_EventOnMonthCardItemBuyClick(IntPtr l)
	{
		int result;
		try
		{
			WorldUIController worldUIController = (WorldUIController)LuaObject.checkSelf(l);
			int obj;
			LuaObject.checkType(l, 2, out obj);
			worldUIController.m_luaExportHelper.__clearDele_EventOnMonthCardItemBuyClick(obj);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06022550 RID: 140624 RVA: 0x00BBE76C File Offset: 0x00BBC96C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callDele_EventOnYYBButtonClick(IntPtr l)
	{
		int result;
		try
		{
			WorldUIController worldUIController = (WorldUIController)LuaObject.checkSelf(l);
			worldUIController.m_luaExportHelper.__callDele_EventOnYYBButtonClick();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06022551 RID: 140625 RVA: 0x00BBE7C0 File Offset: 0x00BBC9C0
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int __clearDele_EventOnYYBButtonClick(IntPtr l)
	{
		int result;
		try
		{
			WorldUIController worldUIController = (WorldUIController)LuaObject.checkSelf(l);
			worldUIController.m_luaExportHelper.__clearDele_EventOnYYBButtonClick();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06022552 RID: 140626 RVA: 0x00BBE814 File Offset: 0x00BBCA14
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callDele_EventOnOppoButtonClick(IntPtr l)
	{
		int result;
		try
		{
			WorldUIController worldUIController = (WorldUIController)LuaObject.checkSelf(l);
			worldUIController.m_luaExportHelper.__callDele_EventOnOppoButtonClick();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06022553 RID: 140627 RVA: 0x00BBE868 File Offset: 0x00BBCA68
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __clearDele_EventOnOppoButtonClick(IntPtr l)
	{
		int result;
		try
		{
			WorldUIController worldUIController = (WorldUIController)LuaObject.checkSelf(l);
			worldUIController.m_luaExportHelper.__clearDele_EventOnOppoButtonClick();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06022554 RID: 140628 RVA: 0x00BBE8BC File Offset: 0x00BBCABC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_EventOnShowPlayerInfo(IntPtr l)
	{
		int result;
		try
		{
			WorldUIController worldUIController = (WorldUIController)LuaObject.checkSelf(l);
			Action value;
			int num = LuaObject.checkDelegate<Action>(l, 2, out value);
			if (num != 0)
			{
				if (num == 1)
				{
					worldUIController.EventOnShowPlayerInfo += value;
				}
				else if (num == 2)
				{
					worldUIController.EventOnShowPlayerInfo -= value;
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

	// Token: 0x06022555 RID: 140629 RVA: 0x00BBE93C File Offset: 0x00BBCB3C
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_EventOnCompass(IntPtr l)
	{
		int result;
		try
		{
			WorldUIController worldUIController = (WorldUIController)LuaObject.checkSelf(l);
			Action value;
			int num = LuaObject.checkDelegate<Action>(l, 2, out value);
			if (num != 0)
			{
				if (num == 1)
				{
					worldUIController.EventOnCompass += value;
				}
				else if (num == 2)
				{
					worldUIController.EventOnCompass -= value;
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

	// Token: 0x06022556 RID: 140630 RVA: 0x00BBE9BC File Offset: 0x00BBCBBC
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_EventOnCurrentScenario(IntPtr l)
	{
		int result;
		try
		{
			WorldUIController worldUIController = (WorldUIController)LuaObject.checkSelf(l);
			Action value;
			int num = LuaObject.checkDelegate<Action>(l, 2, out value);
			if (num != 0)
			{
				if (num == 1)
				{
					worldUIController.EventOnCurrentScenario += value;
				}
				else if (num == 2)
				{
					worldUIController.EventOnCurrentScenario -= value;
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

	// Token: 0x06022557 RID: 140631 RVA: 0x00BBEA3C File Offset: 0x00BBCC3C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_EventOnShowMainButtonBar(IntPtr l)
	{
		int result;
		try
		{
			WorldUIController worldUIController = (WorldUIController)LuaObject.checkSelf(l);
			Action<bool> value;
			int num = LuaObject.checkDelegate<Action<bool>>(l, 2, out value);
			if (num != 0)
			{
				if (num == 1)
				{
					worldUIController.EventOnShowMainButtonBar += value;
				}
				else if (num == 2)
				{
					worldUIController.EventOnShowMainButtonBar -= value;
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

	// Token: 0x06022558 RID: 140632 RVA: 0x00BBEABC File Offset: 0x00BBCCBC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_EventOnUnlockScenarioGotoRiftLevel(IntPtr l)
	{
		int result;
		try
		{
			WorldUIController worldUIController = (WorldUIController)LuaObject.checkSelf(l);
			Action<ConfigDataRiftLevelInfo> value;
			int num = LuaObject.checkDelegate<Action<ConfigDataRiftLevelInfo>>(l, 2, out value);
			if (num != 0)
			{
				if (num == 1)
				{
					worldUIController.EventOnUnlockScenarioGotoRiftLevel += value;
				}
				else if (num == 2)
				{
					worldUIController.EventOnUnlockScenarioGotoRiftLevel -= value;
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

	// Token: 0x06022559 RID: 140633 RVA: 0x00BBEB3C File Offset: 0x00BBCD3C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_EventOnGotoEvent(IntPtr l)
	{
		int result;
		try
		{
			WorldUIController worldUIController = (WorldUIController)LuaObject.checkSelf(l);
			Action<ConfigDataWaypointInfo, ConfigDataEventInfo> value;
			int num = LuaObject.checkDelegate<Action<ConfigDataWaypointInfo, ConfigDataEventInfo>>(l, 2, out value);
			if (num != 0)
			{
				if (num == 1)
				{
					worldUIController.EventOnGotoEvent += value;
				}
				else if (num == 2)
				{
					worldUIController.EventOnGotoEvent -= value;
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

	// Token: 0x0602255A RID: 140634 RVA: 0x00BBEBBC File Offset: 0x00BBCDBC
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_EventOnStartPastScenario(IntPtr l)
	{
		int result;
		try
		{
			WorldUIController worldUIController = (WorldUIController)LuaObject.checkSelf(l);
			Action<ConfigDataScenarioInfo> value;
			int num = LuaObject.checkDelegate<Action<ConfigDataScenarioInfo>>(l, 2, out value);
			if (num != 0)
			{
				if (num == 1)
				{
					worldUIController.EventOnStartPastScenario += value;
				}
				else if (num == 2)
				{
					worldUIController.EventOnStartPastScenario -= value;
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

	// Token: 0x0602255B RID: 140635 RVA: 0x00BBEC3C File Offset: 0x00BBCE3C
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_EventOnClosePastScenarioList(IntPtr l)
	{
		int result;
		try
		{
			WorldUIController worldUIController = (WorldUIController)LuaObject.checkSelf(l);
			Action value;
			int num = LuaObject.checkDelegate<Action>(l, 2, out value);
			if (num != 0)
			{
				if (num == 1)
				{
					worldUIController.EventOnClosePastScenarioList += value;
				}
				else if (num == 2)
				{
					worldUIController.EventOnClosePastScenarioList -= value;
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

	// Token: 0x0602255C RID: 140636 RVA: 0x00BBECBC File Offset: 0x00BBCEBC
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_EventOnShowHero(IntPtr l)
	{
		int result;
		try
		{
			WorldUIController worldUIController = (WorldUIController)LuaObject.checkSelf(l);
			Action value;
			int num = LuaObject.checkDelegate<Action>(l, 2, out value);
			if (num != 0)
			{
				if (num == 1)
				{
					worldUIController.EventOnShowHero += value;
				}
				else if (num == 2)
				{
					worldUIController.EventOnShowHero -= value;
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

	// Token: 0x0602255D RID: 140637 RVA: 0x00BBED3C File Offset: 0x00BBCF3C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_EventOnShowBag(IntPtr l)
	{
		int result;
		try
		{
			WorldUIController worldUIController = (WorldUIController)LuaObject.checkSelf(l);
			Action value;
			int num = LuaObject.checkDelegate<Action>(l, 2, out value);
			if (num != 0)
			{
				if (num == 1)
				{
					worldUIController.EventOnShowBag += value;
				}
				else if (num == 2)
				{
					worldUIController.EventOnShowBag -= value;
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

	// Token: 0x0602255E RID: 140638 RVA: 0x00BBEDBC File Offset: 0x00BBCFBC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_EventOnShowSelectCard(IntPtr l)
	{
		int result;
		try
		{
			WorldUIController worldUIController = (WorldUIController)LuaObject.checkSelf(l);
			Action value;
			int num = LuaObject.checkDelegate<Action>(l, 2, out value);
			if (num != 0)
			{
				if (num == 1)
				{
					worldUIController.EventOnShowSelectCard += value;
				}
				else if (num == 2)
				{
					worldUIController.EventOnShowSelectCard -= value;
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

	// Token: 0x0602255F RID: 140639 RVA: 0x00BBEE3C File Offset: 0x00BBD03C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_EventOnShowMisision(IntPtr l)
	{
		int result;
		try
		{
			WorldUIController worldUIController = (WorldUIController)LuaObject.checkSelf(l);
			Action value;
			int num = LuaObject.checkDelegate<Action>(l, 2, out value);
			if (num != 0)
			{
				if (num == 1)
				{
					worldUIController.EventOnShowMisision += value;
				}
				else if (num == 2)
				{
					worldUIController.EventOnShowMisision -= value;
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

	// Token: 0x06022560 RID: 140640 RVA: 0x00BBEEBC File Offset: 0x00BBD0BC
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_EventOnShowFetter(IntPtr l)
	{
		int result;
		try
		{
			WorldUIController worldUIController = (WorldUIController)LuaObject.checkSelf(l);
			Action value;
			int num = LuaObject.checkDelegate<Action>(l, 2, out value);
			if (num != 0)
			{
				if (num == 1)
				{
					worldUIController.EventOnShowFetter += value;
				}
				else if (num == 2)
				{
					worldUIController.EventOnShowFetter -= value;
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

	// Token: 0x06022561 RID: 140641 RVA: 0x00BBEF3C File Offset: 0x00BBD13C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_EventOnShowStore(IntPtr l)
	{
		int result;
		try
		{
			WorldUIController worldUIController = (WorldUIController)LuaObject.checkSelf(l);
			Action value;
			int num = LuaObject.checkDelegate<Action>(l, 2, out value);
			if (num != 0)
			{
				if (num == 1)
				{
					worldUIController.EventOnShowStore += value;
				}
				else if (num == 2)
				{
					worldUIController.EventOnShowStore -= value;
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

	// Token: 0x06022562 RID: 140642 RVA: 0x00BBEFBC File Offset: 0x00BBD1BC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_EventOnShowDrill(IntPtr l)
	{
		int result;
		try
		{
			WorldUIController worldUIController = (WorldUIController)LuaObject.checkSelf(l);
			Action value;
			int num = LuaObject.checkDelegate<Action>(l, 2, out value);
			if (num != 0)
			{
				if (num == 1)
				{
					worldUIController.EventOnShowDrill += value;
				}
				else if (num == 2)
				{
					worldUIController.EventOnShowDrill -= value;
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

	// Token: 0x06022563 RID: 140643 RVA: 0x00BBF03C File Offset: 0x00BBD23C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_EventOnShowFriend(IntPtr l)
	{
		int result;
		try
		{
			WorldUIController worldUIController = (WorldUIController)LuaObject.checkSelf(l);
			Action value;
			int num = LuaObject.checkDelegate<Action>(l, 2, out value);
			if (num != 0)
			{
				if (num == 1)
				{
					worldUIController.EventOnShowFriend += value;
				}
				else if (num == 2)
				{
					worldUIController.EventOnShowFriend -= value;
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

	// Token: 0x06022564 RID: 140644 RVA: 0x00BBF0BC File Offset: 0x00BBD2BC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_EventOnShowGuild(IntPtr l)
	{
		int result;
		try
		{
			WorldUIController worldUIController = (WorldUIController)LuaObject.checkSelf(l);
			Action value;
			int num = LuaObject.checkDelegate<Action>(l, 2, out value);
			if (num != 0)
			{
				if (num == 1)
				{
					worldUIController.EventOnShowGuild += value;
				}
				else if (num == 2)
				{
					worldUIController.EventOnShowGuild -= value;
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

	// Token: 0x06022565 RID: 140645 RVA: 0x00BBF13C File Offset: 0x00BBD33C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_EventOnShowEvent(IntPtr l)
	{
		int result;
		try
		{
			WorldUIController worldUIController = (WorldUIController)LuaObject.checkSelf(l);
			Action value;
			int num = LuaObject.checkDelegate<Action>(l, 2, out value);
			if (num != 0)
			{
				if (num == 1)
				{
					worldUIController.EventOnShowEvent += value;
				}
				else if (num == 2)
				{
					worldUIController.EventOnShowEvent -= value;
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

	// Token: 0x06022566 RID: 140646 RVA: 0x00BBF1BC File Offset: 0x00BBD3BC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_EventOnShowUncharted(IntPtr l)
	{
		int result;
		try
		{
			WorldUIController worldUIController = (WorldUIController)LuaObject.checkSelf(l);
			Action value;
			int num = LuaObject.checkDelegate<Action>(l, 2, out value);
			if (num != 0)
			{
				if (num == 1)
				{
					worldUIController.EventOnShowUncharted += value;
				}
				else if (num == 2)
				{
					worldUIController.EventOnShowUncharted -= value;
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

	// Token: 0x06022567 RID: 140647 RVA: 0x00BBF23C File Offset: 0x00BBD43C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_EventOnShowArena(IntPtr l)
	{
		int result;
		try
		{
			WorldUIController worldUIController = (WorldUIController)LuaObject.checkSelf(l);
			Action value;
			int num = LuaObject.checkDelegate<Action>(l, 2, out value);
			if (num != 0)
			{
				if (num == 1)
				{
					worldUIController.EventOnShowArena += value;
				}
				else if (num == 2)
				{
					worldUIController.EventOnShowArena -= value;
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

	// Token: 0x06022568 RID: 140648 RVA: 0x00BBF2BC File Offset: 0x00BBD4BC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_EventOnShowRift(IntPtr l)
	{
		int result;
		try
		{
			WorldUIController worldUIController = (WorldUIController)LuaObject.checkSelf(l);
			Action value;
			int num = LuaObject.checkDelegate<Action>(l, 2, out value);
			if (num != 0)
			{
				if (num == 1)
				{
					worldUIController.EventOnShowRift += value;
				}
				else if (num == 2)
				{
					worldUIController.EventOnShowRift -= value;
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

	// Token: 0x06022569 RID: 140649 RVA: 0x00BBF33C File Offset: 0x00BBD53C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_EventOnShowTest(IntPtr l)
	{
		int result;
		try
		{
			WorldUIController worldUIController = (WorldUIController)LuaObject.checkSelf(l);
			Action value;
			int num = LuaObject.checkDelegate<Action>(l, 2, out value);
			if (num != 0)
			{
				if (num == 1)
				{
					worldUIController.EventOnShowTest += value;
				}
				else if (num == 2)
				{
					worldUIController.EventOnShowTest -= value;
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

	// Token: 0x0602256A RID: 140650 RVA: 0x00BBF3BC File Offset: 0x00BBD5BC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_EventOnShowCooperateBattle(IntPtr l)
	{
		int result;
		try
		{
			WorldUIController worldUIController = (WorldUIController)LuaObject.checkSelf(l);
			Action value;
			int num = LuaObject.checkDelegate<Action>(l, 2, out value);
			if (num != 0)
			{
				if (num == 1)
				{
					worldUIController.EventOnShowCooperateBattle += value;
				}
				else if (num == 2)
				{
					worldUIController.EventOnShowCooperateBattle -= value;
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

	// Token: 0x0602256B RID: 140651 RVA: 0x00BBF43C File Offset: 0x00BBD63C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_EventOnShowMail(IntPtr l)
	{
		int result;
		try
		{
			WorldUIController worldUIController = (WorldUIController)LuaObject.checkSelf(l);
			Action value;
			int num = LuaObject.checkDelegate<Action>(l, 2, out value);
			if (num != 0)
			{
				if (num == 1)
				{
					worldUIController.EventOnShowMail += value;
				}
				else if (num == 2)
				{
					worldUIController.EventOnShowMail -= value;
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

	// Token: 0x0602256C RID: 140652 RVA: 0x00BBF4BC File Offset: 0x00BBD6BC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_EventOnShowChat(IntPtr l)
	{
		int result;
		try
		{
			WorldUIController worldUIController = (WorldUIController)LuaObject.checkSelf(l);
			Action value;
			int num = LuaObject.checkDelegate<Action>(l, 2, out value);
			if (num != 0)
			{
				if (num == 1)
				{
					worldUIController.EventOnShowChat += value;
				}
				else if (num == 2)
				{
					worldUIController.EventOnShowChat -= value;
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

	// Token: 0x0602256D RID: 140653 RVA: 0x00BBF53C File Offset: 0x00BBD73C
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_EventOnShowRanking(IntPtr l)
	{
		int result;
		try
		{
			WorldUIController worldUIController = (WorldUIController)LuaObject.checkSelf(l);
			Action value;
			int num = LuaObject.checkDelegate<Action>(l, 2, out value);
			if (num != 0)
			{
				if (num == 1)
				{
					worldUIController.EventOnShowRanking += value;
				}
				else if (num == 2)
				{
					worldUIController.EventOnShowRanking -= value;
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

	// Token: 0x0602256E RID: 140654 RVA: 0x00BBF5BC File Offset: 0x00BBD7BC
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_EventOnShowAnnouncement(IntPtr l)
	{
		int result;
		try
		{
			WorldUIController worldUIController = (WorldUIController)LuaObject.checkSelf(l);
			Action value;
			int num = LuaObject.checkDelegate<Action>(l, 2, out value);
			if (num != 0)
			{
				if (num == 1)
				{
					worldUIController.EventOnShowAnnouncement += value;
				}
				else if (num == 2)
				{
					worldUIController.EventOnShowAnnouncement -= value;
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

	// Token: 0x0602256F RID: 140655 RVA: 0x00BBF63C File Offset: 0x00BBD83C
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_EventOnOpenWebInvestigation(IntPtr l)
	{
		int result;
		try
		{
			WorldUIController worldUIController = (WorldUIController)LuaObject.checkSelf(l);
			Action value;
			int num = LuaObject.checkDelegate<Action>(l, 2, out value);
			if (num != 0)
			{
				if (num == 1)
				{
					worldUIController.EventOnOpenWebInvestigation += value;
				}
				else if (num == 2)
				{
					worldUIController.EventOnOpenWebInvestigation -= value;
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

	// Token: 0x06022570 RID: 140656 RVA: 0x00BBF6BC File Offset: 0x00BBD8BC
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_EventOnShowOpenServiceActivity(IntPtr l)
	{
		int result;
		try
		{
			WorldUIController worldUIController = (WorldUIController)LuaObject.checkSelf(l);
			Action value;
			int num = LuaObject.checkDelegate<Action>(l, 2, out value);
			if (num != 0)
			{
				if (num == 1)
				{
					worldUIController.EventOnShowOpenServiceActivity += value;
				}
				else if (num == 2)
				{
					worldUIController.EventOnShowOpenServiceActivity -= value;
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

	// Token: 0x06022571 RID: 140657 RVA: 0x00BBF73C File Offset: 0x00BBD93C
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_EventOnMonthCardButtonClick(IntPtr l)
	{
		int result;
		try
		{
			WorldUIController worldUIController = (WorldUIController)LuaObject.checkSelf(l);
			Action value;
			int num = LuaObject.checkDelegate<Action>(l, 2, out value);
			if (num != 0)
			{
				if (num == 1)
				{
					worldUIController.EventOnMonthCardButtonClick += value;
				}
				else if (num == 2)
				{
					worldUIController.EventOnMonthCardButtonClick -= value;
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

	// Token: 0x06022572 RID: 140658 RVA: 0x00BBF7BC File Offset: 0x00BBD9BC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_EventOnRefreshMonthCardPanel(IntPtr l)
	{
		int result;
		try
		{
			WorldUIController worldUIController = (WorldUIController)LuaObject.checkSelf(l);
			Action<bool> value;
			int num = LuaObject.checkDelegate<Action<bool>>(l, 2, out value);
			if (num != 0)
			{
				if (num == 1)
				{
					worldUIController.EventOnRefreshMonthCardPanel += value;
				}
				else if (num == 2)
				{
					worldUIController.EventOnRefreshMonthCardPanel -= value;
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

	// Token: 0x06022573 RID: 140659 RVA: 0x00BBF83C File Offset: 0x00BBDA3C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_EventOnMonthCardItemClick(IntPtr l)
	{
		int result;
		try
		{
			WorldUIController worldUIController = (WorldUIController)LuaObject.checkSelf(l);
			Action<int> value;
			int num = LuaObject.checkDelegate<Action<int>>(l, 2, out value);
			if (num != 0)
			{
				if (num == 1)
				{
					worldUIController.EventOnMonthCardItemClick += value;
				}
				else if (num == 2)
				{
					worldUIController.EventOnMonthCardItemClick -= value;
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

	// Token: 0x06022574 RID: 140660 RVA: 0x00BBF8BC File Offset: 0x00BBDABC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_EventOnMonthCardItemBuyClick(IntPtr l)
	{
		int result;
		try
		{
			WorldUIController worldUIController = (WorldUIController)LuaObject.checkSelf(l);
			Action<int> value;
			int num = LuaObject.checkDelegate<Action<int>>(l, 2, out value);
			if (num != 0)
			{
				if (num == 1)
				{
					worldUIController.EventOnMonthCardItemBuyClick += value;
				}
				else if (num == 2)
				{
					worldUIController.EventOnMonthCardItemBuyClick -= value;
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

	// Token: 0x06022575 RID: 140661 RVA: 0x00BBF93C File Offset: 0x00BBDB3C
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_EventOnYYBButtonClick(IntPtr l)
	{
		int result;
		try
		{
			WorldUIController worldUIController = (WorldUIController)LuaObject.checkSelf(l);
			Action value;
			int num = LuaObject.checkDelegate<Action>(l, 2, out value);
			if (num != 0)
			{
				if (num == 1)
				{
					worldUIController.EventOnYYBButtonClick += value;
				}
				else if (num == 2)
				{
					worldUIController.EventOnYYBButtonClick -= value;
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

	// Token: 0x06022576 RID: 140662 RVA: 0x00BBF9BC File Offset: 0x00BBDBBC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_EventOnOppoButtonClick(IntPtr l)
	{
		int result;
		try
		{
			WorldUIController worldUIController = (WorldUIController)LuaObject.checkSelf(l);
			Action value;
			int num = LuaObject.checkDelegate<Action>(l, 2, out value);
			if (num != 0)
			{
				if (num == 1)
				{
					worldUIController.EventOnOppoButtonClick += value;
				}
				else if (num == 2)
				{
					worldUIController.EventOnOppoButtonClick -= value;
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

	// Token: 0x06022577 RID: 140663 RVA: 0x00BBFA3C File Offset: 0x00BBDC3C
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_m_uiStateController(IntPtr l)
	{
		int result;
		try
		{
			WorldUIController worldUIController = (WorldUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, worldUIController.m_luaExportHelper.m_uiStateController);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06022578 RID: 140664 RVA: 0x00BBFA94 File Offset: 0x00BBDC94
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_uiStateController(IntPtr l)
	{
		int result;
		try
		{
			WorldUIController worldUIController = (WorldUIController)LuaObject.checkSelf(l);
			CommonUIStateController uiStateController;
			LuaObject.checkType<CommonUIStateController>(l, 2, out uiStateController);
			worldUIController.m_luaExportHelper.m_uiStateController = uiStateController;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06022579 RID: 140665 RVA: 0x00BBFAF0 File Offset: 0x00BBDCF0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_fogImage(IntPtr l)
	{
		int result;
		try
		{
			WorldUIController worldUIController = (WorldUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, worldUIController.m_luaExportHelper.m_fogImage);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0602257A RID: 140666 RVA: 0x00BBFB48 File Offset: 0x00BBDD48
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_fogImage(IntPtr l)
	{
		int result;
		try
		{
			WorldUIController worldUIController = (WorldUIController)LuaObject.checkSelf(l);
			Image fogImage;
			LuaObject.checkType<Image>(l, 2, out fogImage);
			worldUIController.m_luaExportHelper.m_fogImage = fogImage;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0602257B RID: 140667 RVA: 0x00BBFBA4 File Offset: 0x00BBDDA4
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_m_playerButton(IntPtr l)
	{
		int result;
		try
		{
			WorldUIController worldUIController = (WorldUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, worldUIController.m_luaExportHelper.m_playerButton);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0602257C RID: 140668 RVA: 0x00BBFBFC File Offset: 0x00BBDDFC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_playerButton(IntPtr l)
	{
		int result;
		try
		{
			WorldUIController worldUIController = (WorldUIController)LuaObject.checkSelf(l);
			Button playerButton;
			LuaObject.checkType<Button>(l, 2, out playerButton);
			worldUIController.m_luaExportHelper.m_playerButton = playerButton;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0602257D RID: 140669 RVA: 0x00BBFC58 File Offset: 0x00BBDE58
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_m_playerNameText(IntPtr l)
	{
		int result;
		try
		{
			WorldUIController worldUIController = (WorldUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, worldUIController.m_luaExportHelper.m_playerNameText);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0602257E RID: 140670 RVA: 0x00BBFCB0 File Offset: 0x00BBDEB0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_playerNameText(IntPtr l)
	{
		int result;
		try
		{
			WorldUIController worldUIController = (WorldUIController)LuaObject.checkSelf(l);
			Text playerNameText;
			LuaObject.checkType<Text>(l, 2, out playerNameText);
			worldUIController.m_luaExportHelper.m_playerNameText = playerNameText;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0602257F RID: 140671 RVA: 0x00BBFD0C File Offset: 0x00BBDF0C
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_m_playerLevelText(IntPtr l)
	{
		int result;
		try
		{
			WorldUIController worldUIController = (WorldUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, worldUIController.m_luaExportHelper.m_playerLevelText);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06022580 RID: 140672 RVA: 0x00BBFD64 File Offset: 0x00BBDF64
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_playerLevelText(IntPtr l)
	{
		int result;
		try
		{
			WorldUIController worldUIController = (WorldUIController)LuaObject.checkSelf(l);
			Text playerLevelText;
			LuaObject.checkType<Text>(l, 2, out playerLevelText);
			worldUIController.m_luaExportHelper.m_playerLevelText = playerLevelText;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06022581 RID: 140673 RVA: 0x00BBFDC0 File Offset: 0x00BBDFC0
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_m_playerVipText(IntPtr l)
	{
		int result;
		try
		{
			WorldUIController worldUIController = (WorldUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, worldUIController.m_luaExportHelper.m_playerVipText);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06022582 RID: 140674 RVA: 0x00BBFE18 File Offset: 0x00BBE018
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_playerVipText(IntPtr l)
	{
		int result;
		try
		{
			WorldUIController worldUIController = (WorldUIController)LuaObject.checkSelf(l);
			Text playerVipText;
			LuaObject.checkType<Text>(l, 2, out playerVipText);
			worldUIController.m_luaExportHelper.m_playerVipText = playerVipText;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06022583 RID: 140675 RVA: 0x00BBFE74 File Offset: 0x00BBE074
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_playerExpText(IntPtr l)
	{
		int result;
		try
		{
			WorldUIController worldUIController = (WorldUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, worldUIController.m_luaExportHelper.m_playerExpText);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06022584 RID: 140676 RVA: 0x00BBFECC File Offset: 0x00BBE0CC
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_m_playerExpText(IntPtr l)
	{
		int result;
		try
		{
			WorldUIController worldUIController = (WorldUIController)LuaObject.checkSelf(l);
			Text playerExpText;
			LuaObject.checkType<Text>(l, 2, out playerExpText);
			worldUIController.m_luaExportHelper.m_playerExpText = playerExpText;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06022585 RID: 140677 RVA: 0x00BBFF28 File Offset: 0x00BBE128
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_m_playerExpImage(IntPtr l)
	{
		int result;
		try
		{
			WorldUIController worldUIController = (WorldUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, worldUIController.m_luaExportHelper.m_playerExpImage);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06022586 RID: 140678 RVA: 0x00BBFF80 File Offset: 0x00BBE180
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_playerExpImage(IntPtr l)
	{
		int result;
		try
		{
			WorldUIController worldUIController = (WorldUIController)LuaObject.checkSelf(l);
			Image playerExpImage;
			LuaObject.checkType<Image>(l, 2, out playerExpImage);
			worldUIController.m_luaExportHelper.m_playerExpImage = playerExpImage;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06022587 RID: 140679 RVA: 0x00BBFFDC File Offset: 0x00BBE1DC
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_m_playerIconImage(IntPtr l)
	{
		int result;
		try
		{
			WorldUIController worldUIController = (WorldUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, worldUIController.m_luaExportHelper.m_playerIconImage);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06022588 RID: 140680 RVA: 0x00BC0034 File Offset: 0x00BBE234
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_m_playerIconImage(IntPtr l)
	{
		int result;
		try
		{
			WorldUIController worldUIController = (WorldUIController)LuaObject.checkSelf(l);
			Image playerIconImage;
			LuaObject.checkType<Image>(l, 2, out playerIconImage);
			worldUIController.m_luaExportHelper.m_playerIconImage = playerIconImage;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06022589 RID: 140681 RVA: 0x00BC0090 File Offset: 0x00BBE290
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_compassButton(IntPtr l)
	{
		int result;
		try
		{
			WorldUIController worldUIController = (WorldUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, worldUIController.m_luaExportHelper.m_compassButton);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0602258A RID: 140682 RVA: 0x00BC00E8 File Offset: 0x00BBE2E8
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_m_compassButton(IntPtr l)
	{
		int result;
		try
		{
			WorldUIController worldUIController = (WorldUIController)LuaObject.checkSelf(l);
			Button compassButton;
			LuaObject.checkType<Button>(l, 2, out compassButton);
			worldUIController.m_luaExportHelper.m_compassButton = compassButton;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0602258B RID: 140683 RVA: 0x00BC0144 File Offset: 0x00BBE344
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_currentScenarioButton(IntPtr l)
	{
		int result;
		try
		{
			WorldUIController worldUIController = (WorldUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, worldUIController.m_luaExportHelper.m_currentScenarioButton);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0602258C RID: 140684 RVA: 0x00BC019C File Offset: 0x00BBE39C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_currentScenarioButton(IntPtr l)
	{
		int result;
		try
		{
			WorldUIController worldUIController = (WorldUIController)LuaObject.checkSelf(l);
			Button currentScenarioButton;
			LuaObject.checkType<Button>(l, 2, out currentScenarioButton);
			worldUIController.m_luaExportHelper.m_currentScenarioButton = currentScenarioButton;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0602258D RID: 140685 RVA: 0x00BC01F8 File Offset: 0x00BBE3F8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_currentScenarioNameText(IntPtr l)
	{
		int result;
		try
		{
			WorldUIController worldUIController = (WorldUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, worldUIController.m_luaExportHelper.m_currentScenarioNameText);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0602258E RID: 140686 RVA: 0x00BC0250 File Offset: 0x00BBE450
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_currentScenarioNameText(IntPtr l)
	{
		int result;
		try
		{
			WorldUIController worldUIController = (WorldUIController)LuaObject.checkSelf(l);
			Text currentScenarioNameText;
			LuaObject.checkType<Text>(l, 2, out currentScenarioNameText);
			worldUIController.m_luaExportHelper.m_currentScenarioNameText = currentScenarioNameText;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0602258F RID: 140687 RVA: 0x00BC02AC File Offset: 0x00BBE4AC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_newScenarioUIStateController(IntPtr l)
	{
		int result;
		try
		{
			WorldUIController worldUIController = (WorldUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, worldUIController.m_luaExportHelper.m_newScenarioUIStateController);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06022590 RID: 140688 RVA: 0x00BC0304 File Offset: 0x00BBE504
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_newScenarioUIStateController(IntPtr l)
	{
		int result;
		try
		{
			WorldUIController worldUIController = (WorldUIController)LuaObject.checkSelf(l);
			CommonUIStateController newScenarioUIStateController;
			LuaObject.checkType<CommonUIStateController>(l, 2, out newScenarioUIStateController);
			worldUIController.m_luaExportHelper.m_newScenarioUIStateController = newScenarioUIStateController;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06022591 RID: 140689 RVA: 0x00BC0360 File Offset: 0x00BBE560
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_m_newScenarioNameText(IntPtr l)
	{
		int result;
		try
		{
			WorldUIController worldUIController = (WorldUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, worldUIController.m_luaExportHelper.m_newScenarioNameText);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06022592 RID: 140690 RVA: 0x00BC03B8 File Offset: 0x00BBE5B8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_newScenarioNameText(IntPtr l)
	{
		int result;
		try
		{
			WorldUIController worldUIController = (WorldUIController)LuaObject.checkSelf(l);
			Text newScenarioNameText;
			LuaObject.checkType<Text>(l, 2, out newScenarioNameText);
			worldUIController.m_luaExportHelper.m_newScenarioNameText = newScenarioNameText;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06022593 RID: 140691 RVA: 0x00BC0414 File Offset: 0x00BBE614
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_enterScenarioUIStateController(IntPtr l)
	{
		int result;
		try
		{
			WorldUIController worldUIController = (WorldUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, worldUIController.m_luaExportHelper.m_enterScenarioUIStateController);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06022594 RID: 140692 RVA: 0x00BC046C File Offset: 0x00BBE66C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_enterScenarioUIStateController(IntPtr l)
	{
		int result;
		try
		{
			WorldUIController worldUIController = (WorldUIController)LuaObject.checkSelf(l);
			CommonUIStateController enterScenarioUIStateController;
			LuaObject.checkType<CommonUIStateController>(l, 2, out enterScenarioUIStateController);
			worldUIController.m_luaExportHelper.m_enterScenarioUIStateController = enterScenarioUIStateController;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06022595 RID: 140693 RVA: 0x00BC04C8 File Offset: 0x00BBE6C8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_enterScenarioChapterText(IntPtr l)
	{
		int result;
		try
		{
			WorldUIController worldUIController = (WorldUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, worldUIController.m_luaExportHelper.m_enterScenarioChapterText);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06022596 RID: 140694 RVA: 0x00BC0520 File Offset: 0x00BBE720
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_enterScenarioChapterText(IntPtr l)
	{
		int result;
		try
		{
			WorldUIController worldUIController = (WorldUIController)LuaObject.checkSelf(l);
			Text enterScenarioChapterText;
			LuaObject.checkType<Text>(l, 2, out enterScenarioChapterText);
			worldUIController.m_luaExportHelper.m_enterScenarioChapterText = enterScenarioChapterText;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06022597 RID: 140695 RVA: 0x00BC057C File Offset: 0x00BBE77C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_enterScenarioNameText(IntPtr l)
	{
		int result;
		try
		{
			WorldUIController worldUIController = (WorldUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, worldUIController.m_luaExportHelper.m_enterScenarioNameText);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06022598 RID: 140696 RVA: 0x00BC05D4 File Offset: 0x00BBE7D4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_enterScenarioNameText(IntPtr l)
	{
		int result;
		try
		{
			WorldUIController worldUIController = (WorldUIController)LuaObject.checkSelf(l);
			Text enterScenarioNameText;
			LuaObject.checkType<Text>(l, 2, out enterScenarioNameText);
			worldUIController.m_luaExportHelper.m_enterScenarioNameText = enterScenarioNameText;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06022599 RID: 140697 RVA: 0x00BC0630 File Offset: 0x00BBE830
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_enterMonsterUIStateController(IntPtr l)
	{
		int result;
		try
		{
			WorldUIController worldUIController = (WorldUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, worldUIController.m_luaExportHelper.m_enterMonsterUIStateController);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0602259A RID: 140698 RVA: 0x00BC0688 File Offset: 0x00BBE888
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_enterMonsterUIStateController(IntPtr l)
	{
		int result;
		try
		{
			WorldUIController worldUIController = (WorldUIController)LuaObject.checkSelf(l);
			CommonUIStateController enterMonsterUIStateController;
			LuaObject.checkType<CommonUIStateController>(l, 2, out enterMonsterUIStateController);
			worldUIController.m_luaExportHelper.m_enterMonsterUIStateController = enterMonsterUIStateController;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0602259B RID: 140699 RVA: 0x00BC06E4 File Offset: 0x00BBE8E4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_eventListTransform(IntPtr l)
	{
		int result;
		try
		{
			WorldUIController worldUIController = (WorldUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, worldUIController.m_luaExportHelper.m_eventListTransform);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0602259C RID: 140700 RVA: 0x00BC073C File Offset: 0x00BBE93C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_eventListTransform(IntPtr l)
	{
		int result;
		try
		{
			WorldUIController worldUIController = (WorldUIController)LuaObject.checkSelf(l);
			RectTransform eventListTransform;
			LuaObject.checkType<RectTransform>(l, 2, out eventListTransform);
			worldUIController.m_luaExportHelper.m_eventListTransform = eventListTransform;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0602259D RID: 140701 RVA: 0x00BC0798 File Offset: 0x00BBE998
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_eventListUIStateController(IntPtr l)
	{
		int result;
		try
		{
			WorldUIController worldUIController = (WorldUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, worldUIController.m_luaExportHelper.m_eventListUIStateController);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0602259E RID: 140702 RVA: 0x00BC07F0 File Offset: 0x00BBE9F0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_eventListUIStateController(IntPtr l)
	{
		int result;
		try
		{
			WorldUIController worldUIController = (WorldUIController)LuaObject.checkSelf(l);
			CommonUIStateController eventListUIStateController;
			LuaObject.checkType<CommonUIStateController>(l, 2, out eventListUIStateController);
			worldUIController.m_luaExportHelper.m_eventListUIStateController = eventListUIStateController;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0602259F RID: 140703 RVA: 0x00BC084C File Offset: 0x00BBEA4C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_randomEventScrollRect(IntPtr l)
	{
		int result;
		try
		{
			WorldUIController worldUIController = (WorldUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, worldUIController.m_luaExportHelper.m_randomEventScrollRect);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060225A0 RID: 140704 RVA: 0x00BC08A4 File Offset: 0x00BBEAA4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_randomEventScrollRect(IntPtr l)
	{
		int result;
		try
		{
			WorldUIController worldUIController = (WorldUIController)LuaObject.checkSelf(l);
			ScrollRect randomEventScrollRect;
			LuaObject.checkType<ScrollRect>(l, 2, out randomEventScrollRect);
			worldUIController.m_luaExportHelper.m_randomEventScrollRect = randomEventScrollRect;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060225A1 RID: 140705 RVA: 0x00BC0900 File Offset: 0x00BBEB00
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_eventListBackgroundButton(IntPtr l)
	{
		int result;
		try
		{
			WorldUIController worldUIController = (WorldUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, worldUIController.m_luaExportHelper.m_eventListBackgroundButton);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060225A2 RID: 140706 RVA: 0x00BC0958 File Offset: 0x00BBEB58
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_eventListBackgroundButton(IntPtr l)
	{
		int result;
		try
		{
			WorldUIController worldUIController = (WorldUIController)LuaObject.checkSelf(l);
			Button eventListBackgroundButton;
			LuaObject.checkType<Button>(l, 2, out eventListBackgroundButton);
			worldUIController.m_luaExportHelper.m_eventListBackgroundButton = eventListBackgroundButton;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060225A3 RID: 140707 RVA: 0x00BC09B4 File Offset: 0x00BBEBB4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_pastScenarioListUIStateController(IntPtr l)
	{
		int result;
		try
		{
			WorldUIController worldUIController = (WorldUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, worldUIController.m_luaExportHelper.m_pastScenarioListUIStateController);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060225A4 RID: 140708 RVA: 0x00BC0A0C File Offset: 0x00BBEC0C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_pastScenarioListUIStateController(IntPtr l)
	{
		int result;
		try
		{
			WorldUIController worldUIController = (WorldUIController)LuaObject.checkSelf(l);
			CommonUIStateController pastScenarioListUIStateController;
			LuaObject.checkType<CommonUIStateController>(l, 2, out pastScenarioListUIStateController);
			worldUIController.m_luaExportHelper.m_pastScenarioListUIStateController = pastScenarioListUIStateController;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060225A5 RID: 140709 RVA: 0x00BC0A68 File Offset: 0x00BBEC68
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_pastScenarioListBackgroundButton(IntPtr l)
	{
		int result;
		try
		{
			WorldUIController worldUIController = (WorldUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, worldUIController.m_luaExportHelper.m_pastScenarioListBackgroundButton);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060225A6 RID: 140710 RVA: 0x00BC0AC0 File Offset: 0x00BBECC0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_pastScenarioListBackgroundButton(IntPtr l)
	{
		int result;
		try
		{
			WorldUIController worldUIController = (WorldUIController)LuaObject.checkSelf(l);
			Button pastScenarioListBackgroundButton;
			LuaObject.checkType<Button>(l, 2, out pastScenarioListBackgroundButton);
			worldUIController.m_luaExportHelper.m_pastScenarioListBackgroundButton = pastScenarioListBackgroundButton;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060225A7 RID: 140711 RVA: 0x00BC0B1C File Offset: 0x00BBED1C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_pastScenarioListScrollRect(IntPtr l)
	{
		int result;
		try
		{
			WorldUIController worldUIController = (WorldUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, worldUIController.m_luaExportHelper.m_pastScenarioListScrollRect);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060225A8 RID: 140712 RVA: 0x00BC0B74 File Offset: 0x00BBED74
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_pastScenarioListScrollRect(IntPtr l)
	{
		int result;
		try
		{
			WorldUIController worldUIController = (WorldUIController)LuaObject.checkSelf(l);
			ScrollRect pastScenarioListScrollRect;
			LuaObject.checkType<ScrollRect>(l, 2, out pastScenarioListScrollRect);
			worldUIController.m_luaExportHelper.m_pastScenarioListScrollRect = pastScenarioListScrollRect;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060225A9 RID: 140713 RVA: 0x00BC0BD0 File Offset: 0x00BBEDD0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_unlockScenarioUIStateController(IntPtr l)
	{
		int result;
		try
		{
			WorldUIController worldUIController = (WorldUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, worldUIController.m_luaExportHelper.m_unlockScenarioUIStateController);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060225AA RID: 140714 RVA: 0x00BC0C28 File Offset: 0x00BBEE28
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_unlockScenarioUIStateController(IntPtr l)
	{
		int result;
		try
		{
			WorldUIController worldUIController = (WorldUIController)LuaObject.checkSelf(l);
			CommonUIStateController unlockScenarioUIStateController;
			LuaObject.checkType<CommonUIStateController>(l, 2, out unlockScenarioUIStateController);
			worldUIController.m_luaExportHelper.m_unlockScenarioUIStateController = unlockScenarioUIStateController;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060225AB RID: 140715 RVA: 0x00BC0C84 File Offset: 0x00BBEE84
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_unlockScenarioBackgroundButton(IntPtr l)
	{
		int result;
		try
		{
			WorldUIController worldUIController = (WorldUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, worldUIController.m_luaExportHelper.m_unlockScenarioBackgroundButton);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060225AC RID: 140716 RVA: 0x00BC0CDC File Offset: 0x00BBEEDC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_unlockScenarioBackgroundButton(IntPtr l)
	{
		int result;
		try
		{
			WorldUIController worldUIController = (WorldUIController)LuaObject.checkSelf(l);
			Button unlockScenarioBackgroundButton;
			LuaObject.checkType<Button>(l, 2, out unlockScenarioBackgroundButton);
			worldUIController.m_luaExportHelper.m_unlockScenarioBackgroundButton = unlockScenarioBackgroundButton;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060225AD RID: 140717 RVA: 0x00BC0D38 File Offset: 0x00BBEF38
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_unlockScenarioTitleText(IntPtr l)
	{
		int result;
		try
		{
			WorldUIController worldUIController = (WorldUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, worldUIController.m_luaExportHelper.m_unlockScenarioTitleText);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060225AE RID: 140718 RVA: 0x00BC0D90 File Offset: 0x00BBEF90
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_unlockScenarioTitleText(IntPtr l)
	{
		int result;
		try
		{
			WorldUIController worldUIController = (WorldUIController)LuaObject.checkSelf(l);
			Text unlockScenarioTitleText;
			LuaObject.checkType<Text>(l, 2, out unlockScenarioTitleText);
			worldUIController.m_luaExportHelper.m_unlockScenarioTitleText = unlockScenarioTitleText;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060225AF RID: 140719 RVA: 0x00BC0DEC File Offset: 0x00BBEFEC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_unlockScenarioText(IntPtr l)
	{
		int result;
		try
		{
			WorldUIController worldUIController = (WorldUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, worldUIController.m_luaExportHelper.m_unlockScenarioText);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060225B0 RID: 140720 RVA: 0x00BC0E44 File Offset: 0x00BBF044
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_unlockScenarioText(IntPtr l)
	{
		int result;
		try
		{
			WorldUIController worldUIController = (WorldUIController)LuaObject.checkSelf(l);
			Text unlockScenarioText;
			LuaObject.checkType<Text>(l, 2, out unlockScenarioText);
			worldUIController.m_luaExportHelper.m_unlockScenarioText = unlockScenarioText;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060225B1 RID: 140721 RVA: 0x00BC0EA0 File Offset: 0x00BBF0A0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_unlockScenarioGotoButton(IntPtr l)
	{
		int result;
		try
		{
			WorldUIController worldUIController = (WorldUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, worldUIController.m_luaExportHelper.m_unlockScenarioGotoButton);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060225B2 RID: 140722 RVA: 0x00BC0EF8 File Offset: 0x00BBF0F8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_unlockScenarioGotoButton(IntPtr l)
	{
		int result;
		try
		{
			WorldUIController worldUIController = (WorldUIController)LuaObject.checkSelf(l);
			Button unlockScenarioGotoButton;
			LuaObject.checkType<Button>(l, 2, out unlockScenarioGotoButton);
			worldUIController.m_luaExportHelper.m_unlockScenarioGotoButton = unlockScenarioGotoButton;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060225B3 RID: 140723 RVA: 0x00BC0F54 File Offset: 0x00BBF154
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_mainButton(IntPtr l)
	{
		int result;
		try
		{
			WorldUIController worldUIController = (WorldUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, worldUIController.m_luaExportHelper.m_mainButton);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060225B4 RID: 140724 RVA: 0x00BC0FAC File Offset: 0x00BBF1AC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_mainButton(IntPtr l)
	{
		int result;
		try
		{
			WorldUIController worldUIController = (WorldUIController)LuaObject.checkSelf(l);
			Button mainButton;
			LuaObject.checkType<Button>(l, 2, out mainButton);
			worldUIController.m_luaExportHelper.m_mainButton = mainButton;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060225B5 RID: 140725 RVA: 0x00BC1008 File Offset: 0x00BBF208
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_mainButtonOnGameObject(IntPtr l)
	{
		int result;
		try
		{
			WorldUIController worldUIController = (WorldUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, worldUIController.m_luaExportHelper.m_mainButtonOnGameObject);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060225B6 RID: 140726 RVA: 0x00BC1060 File Offset: 0x00BBF260
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_m_mainButtonOnGameObject(IntPtr l)
	{
		int result;
		try
		{
			WorldUIController worldUIController = (WorldUIController)LuaObject.checkSelf(l);
			GameObject mainButtonOnGameObject;
			LuaObject.checkType<GameObject>(l, 2, out mainButtonOnGameObject);
			worldUIController.m_luaExportHelper.m_mainButtonOnGameObject = mainButtonOnGameObject;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060225B7 RID: 140727 RVA: 0x00BC10BC File Offset: 0x00BBF2BC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_mainButtonOffGameObject(IntPtr l)
	{
		int result;
		try
		{
			WorldUIController worldUIController = (WorldUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, worldUIController.m_luaExportHelper.m_mainButtonOffGameObject);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060225B8 RID: 140728 RVA: 0x00BC1114 File Offset: 0x00BBF314
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_mainButtonOffGameObject(IntPtr l)
	{
		int result;
		try
		{
			WorldUIController worldUIController = (WorldUIController)LuaObject.checkSelf(l);
			GameObject mainButtonOffGameObject;
			LuaObject.checkType<GameObject>(l, 2, out mainButtonOffGameObject);
			worldUIController.m_luaExportHelper.m_mainButtonOffGameObject = mainButtonOffGameObject;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060225B9 RID: 140729 RVA: 0x00BC1170 File Offset: 0x00BBF370
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_margin1Transform(IntPtr l)
	{
		int result;
		try
		{
			WorldUIController worldUIController = (WorldUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, worldUIController.m_luaExportHelper.m_margin1Transform);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060225BA RID: 140730 RVA: 0x00BC11C8 File Offset: 0x00BBF3C8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_margin1Transform(IntPtr l)
	{
		int result;
		try
		{
			WorldUIController worldUIController = (WorldUIController)LuaObject.checkSelf(l);
			RectTransform margin1Transform;
			LuaObject.checkType<RectTransform>(l, 2, out margin1Transform);
			worldUIController.m_luaExportHelper.m_margin1Transform = margin1Transform;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060225BB RID: 140731 RVA: 0x00BC1224 File Offset: 0x00BBF424
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_mainButtonBarUIStateController(IntPtr l)
	{
		int result;
		try
		{
			WorldUIController worldUIController = (WorldUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, worldUIController.m_luaExportHelper.m_mainButtonBarUIStateController);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060225BC RID: 140732 RVA: 0x00BC127C File Offset: 0x00BBF47C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_mainButtonBarUIStateController(IntPtr l)
	{
		int result;
		try
		{
			WorldUIController worldUIController = (WorldUIController)LuaObject.checkSelf(l);
			CommonUIStateController mainButtonBarUIStateController;
			LuaObject.checkType<CommonUIStateController>(l, 2, out mainButtonBarUIStateController);
			worldUIController.m_luaExportHelper.m_mainButtonBarUIStateController = mainButtonBarUIStateController;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060225BD RID: 140733 RVA: 0x00BC12D8 File Offset: 0x00BBF4D8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_heroButton(IntPtr l)
	{
		int result;
		try
		{
			WorldUIController worldUIController = (WorldUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, worldUIController.m_luaExportHelper.m_heroButton);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060225BE RID: 140734 RVA: 0x00BC1330 File Offset: 0x00BBF530
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_heroButton(IntPtr l)
	{
		int result;
		try
		{
			WorldUIController worldUIController = (WorldUIController)LuaObject.checkSelf(l);
			Button heroButton;
			LuaObject.checkType<Button>(l, 2, out heroButton);
			worldUIController.m_luaExportHelper.m_heroButton = heroButton;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060225BF RID: 140735 RVA: 0x00BC138C File Offset: 0x00BBF58C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_heroButtonRedMarkGameObject(IntPtr l)
	{
		int result;
		try
		{
			WorldUIController worldUIController = (WorldUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, worldUIController.m_luaExportHelper.m_heroButtonRedMarkGameObject);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060225C0 RID: 140736 RVA: 0x00BC13E4 File Offset: 0x00BBF5E4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_heroButtonRedMarkGameObject(IntPtr l)
	{
		int result;
		try
		{
			WorldUIController worldUIController = (WorldUIController)LuaObject.checkSelf(l);
			GameObject heroButtonRedMarkGameObject;
			LuaObject.checkType<GameObject>(l, 2, out heroButtonRedMarkGameObject);
			worldUIController.m_luaExportHelper.m_heroButtonRedMarkGameObject = heroButtonRedMarkGameObject;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060225C1 RID: 140737 RVA: 0x00BC1440 File Offset: 0x00BBF640
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_bagButton(IntPtr l)
	{
		int result;
		try
		{
			WorldUIController worldUIController = (WorldUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, worldUIController.m_luaExportHelper.m_bagButton);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060225C2 RID: 140738 RVA: 0x00BC1498 File Offset: 0x00BBF698
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_bagButton(IntPtr l)
	{
		int result;
		try
		{
			WorldUIController worldUIController = (WorldUIController)LuaObject.checkSelf(l);
			Button bagButton;
			LuaObject.checkType<Button>(l, 2, out bagButton);
			worldUIController.m_luaExportHelper.m_bagButton = bagButton;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060225C3 RID: 140739 RVA: 0x00BC14F4 File Offset: 0x00BBF6F4
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_m_missionButton(IntPtr l)
	{
		int result;
		try
		{
			WorldUIController worldUIController = (WorldUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, worldUIController.m_luaExportHelper.m_missionButton);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060225C4 RID: 140740 RVA: 0x00BC154C File Offset: 0x00BBF74C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_missionButton(IntPtr l)
	{
		int result;
		try
		{
			WorldUIController worldUIController = (WorldUIController)LuaObject.checkSelf(l);
			Button missionButton;
			LuaObject.checkType<Button>(l, 2, out missionButton);
			worldUIController.m_luaExportHelper.m_missionButton = missionButton;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060225C5 RID: 140741 RVA: 0x00BC15A8 File Offset: 0x00BBF7A8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_missionButtonRedMarkGameObject(IntPtr l)
	{
		int result;
		try
		{
			WorldUIController worldUIController = (WorldUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, worldUIController.m_luaExportHelper.m_missionButtonRedMarkGameObject);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060225C6 RID: 140742 RVA: 0x00BC1600 File Offset: 0x00BBF800
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_missionButtonRedMarkGameObject(IntPtr l)
	{
		int result;
		try
		{
			WorldUIController worldUIController = (WorldUIController)LuaObject.checkSelf(l);
			GameObject missionButtonRedMarkGameObject;
			LuaObject.checkType<GameObject>(l, 2, out missionButtonRedMarkGameObject);
			worldUIController.m_luaExportHelper.m_missionButtonRedMarkGameObject = missionButtonRedMarkGameObject;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060225C7 RID: 140743 RVA: 0x00BC165C File Offset: 0x00BBF85C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_fetterButton(IntPtr l)
	{
		int result;
		try
		{
			WorldUIController worldUIController = (WorldUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, worldUIController.m_luaExportHelper.m_fetterButton);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060225C8 RID: 140744 RVA: 0x00BC16B4 File Offset: 0x00BBF8B4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_fetterButton(IntPtr l)
	{
		int result;
		try
		{
			WorldUIController worldUIController = (WorldUIController)LuaObject.checkSelf(l);
			Button fetterButton;
			LuaObject.checkType<Button>(l, 2, out fetterButton);
			worldUIController.m_luaExportHelper.m_fetterButton = fetterButton;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060225C9 RID: 140745 RVA: 0x00BC1710 File Offset: 0x00BBF910
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_fetterButtonRedMarkGameObject(IntPtr l)
	{
		int result;
		try
		{
			WorldUIController worldUIController = (WorldUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, worldUIController.m_luaExportHelper.m_fetterButtonRedMarkGameObject);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060225CA RID: 140746 RVA: 0x00BC1768 File Offset: 0x00BBF968
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_m_fetterButtonRedMarkGameObject(IntPtr l)
	{
		int result;
		try
		{
			WorldUIController worldUIController = (WorldUIController)LuaObject.checkSelf(l);
			GameObject fetterButtonRedMarkGameObject;
			LuaObject.checkType<GameObject>(l, 2, out fetterButtonRedMarkGameObject);
			worldUIController.m_luaExportHelper.m_fetterButtonRedMarkGameObject = fetterButtonRedMarkGameObject;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060225CB RID: 140747 RVA: 0x00BC17C4 File Offset: 0x00BBF9C4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_storeButton(IntPtr l)
	{
		int result;
		try
		{
			WorldUIController worldUIController = (WorldUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, worldUIController.m_luaExportHelper.m_storeButton);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060225CC RID: 140748 RVA: 0x00BC181C File Offset: 0x00BBFA1C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_storeButton(IntPtr l)
	{
		int result;
		try
		{
			WorldUIController worldUIController = (WorldUIController)LuaObject.checkSelf(l);
			Button storeButton;
			LuaObject.checkType<Button>(l, 2, out storeButton);
			worldUIController.m_luaExportHelper.m_storeButton = storeButton;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060225CD RID: 140749 RVA: 0x00BC1878 File Offset: 0x00BBFA78
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_selectCardButton(IntPtr l)
	{
		int result;
		try
		{
			WorldUIController worldUIController = (WorldUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, worldUIController.m_luaExportHelper.m_selectCardButton);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060225CE RID: 140750 RVA: 0x00BC18D0 File Offset: 0x00BBFAD0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_selectCardButton(IntPtr l)
	{
		int result;
		try
		{
			WorldUIController worldUIController = (WorldUIController)LuaObject.checkSelf(l);
			Button selectCardButton;
			LuaObject.checkType<Button>(l, 2, out selectCardButton);
			worldUIController.m_luaExportHelper.m_selectCardButton = selectCardButton;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060225CF RID: 140751 RVA: 0x00BC192C File Offset: 0x00BBFB2C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_drillButton(IntPtr l)
	{
		int result;
		try
		{
			WorldUIController worldUIController = (WorldUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, worldUIController.m_luaExportHelper.m_drillButton);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060225D0 RID: 140752 RVA: 0x00BC1984 File Offset: 0x00BBFB84
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_drillButton(IntPtr l)
	{
		int result;
		try
		{
			WorldUIController worldUIController = (WorldUIController)LuaObject.checkSelf(l);
			Button drillButton;
			LuaObject.checkType<Button>(l, 2, out drillButton);
			worldUIController.m_luaExportHelper.m_drillButton = drillButton;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060225D1 RID: 140753 RVA: 0x00BC19E0 File Offset: 0x00BBFBE0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_drillButtonRedMark(IntPtr l)
	{
		int result;
		try
		{
			WorldUIController worldUIController = (WorldUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, worldUIController.m_luaExportHelper.m_drillButtonRedMark);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060225D2 RID: 140754 RVA: 0x00BC1A38 File Offset: 0x00BBFC38
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_m_drillButtonRedMark(IntPtr l)
	{
		int result;
		try
		{
			WorldUIController worldUIController = (WorldUIController)LuaObject.checkSelf(l);
			GameObject drillButtonRedMark;
			LuaObject.checkType<GameObject>(l, 2, out drillButtonRedMark);
			worldUIController.m_luaExportHelper.m_drillButtonRedMark = drillButtonRedMark;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060225D3 RID: 140755 RVA: 0x00BC1A94 File Offset: 0x00BBFC94
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_m_guildButton(IntPtr l)
	{
		int result;
		try
		{
			WorldUIController worldUIController = (WorldUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, worldUIController.m_luaExportHelper.m_guildButton);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060225D4 RID: 140756 RVA: 0x00BC1AEC File Offset: 0x00BBFCEC
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_m_guildButton(IntPtr l)
	{
		int result;
		try
		{
			WorldUIController worldUIController = (WorldUIController)LuaObject.checkSelf(l);
			Button guildButton;
			LuaObject.checkType<Button>(l, 2, out guildButton);
			worldUIController.m_luaExportHelper.m_guildButton = guildButton;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060225D5 RID: 140757 RVA: 0x00BC1B48 File Offset: 0x00BBFD48
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_sociatyButtonRedMark(IntPtr l)
	{
		int result;
		try
		{
			WorldUIController worldUIController = (WorldUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, worldUIController.m_luaExportHelper.m_sociatyButtonRedMark);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060225D6 RID: 140758 RVA: 0x00BC1BA0 File Offset: 0x00BBFDA0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_sociatyButtonRedMark(IntPtr l)
	{
		int result;
		try
		{
			WorldUIController worldUIController = (WorldUIController)LuaObject.checkSelf(l);
			GameObject sociatyButtonRedMark;
			LuaObject.checkType<GameObject>(l, 2, out sociatyButtonRedMark);
			worldUIController.m_luaExportHelper.m_sociatyButtonRedMark = sociatyButtonRedMark;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060225D7 RID: 140759 RVA: 0x00BC1BFC File Offset: 0x00BBFDFC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_marginTransform(IntPtr l)
	{
		int result;
		try
		{
			WorldUIController worldUIController = (WorldUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, worldUIController.m_luaExportHelper.m_marginTransform);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060225D8 RID: 140760 RVA: 0x00BC1C54 File Offset: 0x00BBFE54
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_marginTransform(IntPtr l)
	{
		int result;
		try
		{
			WorldUIController worldUIController = (WorldUIController)LuaObject.checkSelf(l);
			RectTransform marginTransform;
			LuaObject.checkType<RectTransform>(l, 2, out marginTransform);
			worldUIController.m_luaExportHelper.m_marginTransform = marginTransform;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060225D9 RID: 140761 RVA: 0x00BC1CB0 File Offset: 0x00BBFEB0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_rightGameObject(IntPtr l)
	{
		int result;
		try
		{
			WorldUIController worldUIController = (WorldUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, worldUIController.m_luaExportHelper.m_rightGameObject);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060225DA RID: 140762 RVA: 0x00BC1D08 File Offset: 0x00BBFF08
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_rightGameObject(IntPtr l)
	{
		int result;
		try
		{
			WorldUIController worldUIController = (WorldUIController)LuaObject.checkSelf(l);
			GameObject rightGameObject;
			LuaObject.checkType<GameObject>(l, 2, out rightGameObject);
			worldUIController.m_luaExportHelper.m_rightGameObject = rightGameObject;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060225DB RID: 140763 RVA: 0x00BC1D64 File Offset: 0x00BBFF64
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_eventButton(IntPtr l)
	{
		int result;
		try
		{
			WorldUIController worldUIController = (WorldUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, worldUIController.m_luaExportHelper.m_eventButton);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060225DC RID: 140764 RVA: 0x00BC1DBC File Offset: 0x00BBFFBC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_eventButton(IntPtr l)
	{
		int result;
		try
		{
			WorldUIController worldUIController = (WorldUIController)LuaObject.checkSelf(l);
			Button eventButton;
			LuaObject.checkType<Button>(l, 2, out eventButton);
			worldUIController.m_luaExportHelper.m_eventButton = eventButton;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060225DD RID: 140765 RVA: 0x00BC1E18 File Offset: 0x00BC0018
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_eventButtonRedMarkGameObject(IntPtr l)
	{
		int result;
		try
		{
			WorldUIController worldUIController = (WorldUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, worldUIController.m_luaExportHelper.m_eventButtonRedMarkGameObject);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060225DE RID: 140766 RVA: 0x00BC1E70 File Offset: 0x00BC0070
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_eventButtonRedMarkGameObject(IntPtr l)
	{
		int result;
		try
		{
			WorldUIController worldUIController = (WorldUIController)LuaObject.checkSelf(l);
			GameObject eventButtonRedMarkGameObject;
			LuaObject.checkType<GameObject>(l, 2, out eventButtonRedMarkGameObject);
			worldUIController.m_luaExportHelper.m_eventButtonRedMarkGameObject = eventButtonRedMarkGameObject;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060225DF RID: 140767 RVA: 0x00BC1ECC File Offset: 0x00BC00CC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_unchartedButton(IntPtr l)
	{
		int result;
		try
		{
			WorldUIController worldUIController = (WorldUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, worldUIController.m_luaExportHelper.m_unchartedButton);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060225E0 RID: 140768 RVA: 0x00BC1F24 File Offset: 0x00BC0124
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_unchartedButton(IntPtr l)
	{
		int result;
		try
		{
			WorldUIController worldUIController = (WorldUIController)LuaObject.checkSelf(l);
			Button unchartedButton;
			LuaObject.checkType<Button>(l, 2, out unchartedButton);
			worldUIController.m_luaExportHelper.m_unchartedButton = unchartedButton;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060225E1 RID: 140769 RVA: 0x00BC1F80 File Offset: 0x00BC0180
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_arenaButton(IntPtr l)
	{
		int result;
		try
		{
			WorldUIController worldUIController = (WorldUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, worldUIController.m_luaExportHelper.m_arenaButton);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060225E2 RID: 140770 RVA: 0x00BC1FD8 File Offset: 0x00BC01D8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_arenaButton(IntPtr l)
	{
		int result;
		try
		{
			WorldUIController worldUIController = (WorldUIController)LuaObject.checkSelf(l);
			Button arenaButton;
			LuaObject.checkType<Button>(l, 2, out arenaButton);
			worldUIController.m_luaExportHelper.m_arenaButton = arenaButton;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060225E3 RID: 140771 RVA: 0x00BC2034 File Offset: 0x00BC0234
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_riftButton(IntPtr l)
	{
		int result;
		try
		{
			WorldUIController worldUIController = (WorldUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, worldUIController.m_luaExportHelper.m_riftButton);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060225E4 RID: 140772 RVA: 0x00BC208C File Offset: 0x00BC028C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_riftButton(IntPtr l)
	{
		int result;
		try
		{
			WorldUIController worldUIController = (WorldUIController)LuaObject.checkSelf(l);
			Button riftButton;
			LuaObject.checkType<Button>(l, 2, out riftButton);
			worldUIController.m_luaExportHelper.m_riftButton = riftButton;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060225E5 RID: 140773 RVA: 0x00BC20E8 File Offset: 0x00BC02E8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_testButton(IntPtr l)
	{
		int result;
		try
		{
			WorldUIController worldUIController = (WorldUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, worldUIController.m_luaExportHelper.m_testButton);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060225E6 RID: 140774 RVA: 0x00BC2140 File Offset: 0x00BC0340
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_testButton(IntPtr l)
	{
		int result;
		try
		{
			WorldUIController worldUIController = (WorldUIController)LuaObject.checkSelf(l);
			Button testButton;
			LuaObject.checkType<Button>(l, 2, out testButton);
			worldUIController.m_luaExportHelper.m_testButton = testButton;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060225E7 RID: 140775 RVA: 0x00BC219C File Offset: 0x00BC039C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_cooperateBattleButton(IntPtr l)
	{
		int result;
		try
		{
			WorldUIController worldUIController = (WorldUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, worldUIController.m_luaExportHelper.m_cooperateBattleButton);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060225E8 RID: 140776 RVA: 0x00BC21F4 File Offset: 0x00BC03F4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_cooperateBattleButton(IntPtr l)
	{
		int result;
		try
		{
			WorldUIController worldUIController = (WorldUIController)LuaObject.checkSelf(l);
			Button cooperateBattleButton;
			LuaObject.checkType<Button>(l, 2, out cooperateBattleButton);
			worldUIController.m_luaExportHelper.m_cooperateBattleButton = cooperateBattleButton;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060225E9 RID: 140777 RVA: 0x00BC2250 File Offset: 0x00BC0450
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_leftGameObject(IntPtr l)
	{
		int result;
		try
		{
			WorldUIController worldUIController = (WorldUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, worldUIController.m_luaExportHelper.m_leftGameObject);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060225EA RID: 140778 RVA: 0x00BC22A8 File Offset: 0x00BC04A8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_leftGameObject(IntPtr l)
	{
		int result;
		try
		{
			WorldUIController worldUIController = (WorldUIController)LuaObject.checkSelf(l);
			GameObject leftGameObject;
			LuaObject.checkType<GameObject>(l, 2, out leftGameObject);
			worldUIController.m_luaExportHelper.m_leftGameObject = leftGameObject;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060225EB RID: 140779 RVA: 0x00BC2304 File Offset: 0x00BC0504
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_friendButton(IntPtr l)
	{
		int result;
		try
		{
			WorldUIController worldUIController = (WorldUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, worldUIController.m_luaExportHelper.m_friendButton);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060225EC RID: 140780 RVA: 0x00BC235C File Offset: 0x00BC055C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_friendButton(IntPtr l)
	{
		int result;
		try
		{
			WorldUIController worldUIController = (WorldUIController)LuaObject.checkSelf(l);
			Button friendButton;
			LuaObject.checkType<Button>(l, 2, out friendButton);
			worldUIController.m_luaExportHelper.m_friendButton = friendButton;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060225ED RID: 140781 RVA: 0x00BC23B8 File Offset: 0x00BC05B8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_friendButtonRedMark(IntPtr l)
	{
		int result;
		try
		{
			WorldUIController worldUIController = (WorldUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, worldUIController.m_luaExportHelper.m_friendButtonRedMark);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060225EE RID: 140782 RVA: 0x00BC2410 File Offset: 0x00BC0610
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_friendButtonRedMark(IntPtr l)
	{
		int result;
		try
		{
			WorldUIController worldUIController = (WorldUIController)LuaObject.checkSelf(l);
			GameObject friendButtonRedMark;
			LuaObject.checkType<GameObject>(l, 2, out friendButtonRedMark);
			worldUIController.m_luaExportHelper.m_friendButtonRedMark = friendButtonRedMark;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060225EF RID: 140783 RVA: 0x00BC246C File Offset: 0x00BC066C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_mailButton(IntPtr l)
	{
		int result;
		try
		{
			WorldUIController worldUIController = (WorldUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, worldUIController.m_luaExportHelper.m_mailButton);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060225F0 RID: 140784 RVA: 0x00BC24C4 File Offset: 0x00BC06C4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_mailButton(IntPtr l)
	{
		int result;
		try
		{
			WorldUIController worldUIController = (WorldUIController)LuaObject.checkSelf(l);
			Button mailButton;
			LuaObject.checkType<Button>(l, 2, out mailButton);
			worldUIController.m_luaExportHelper.m_mailButton = mailButton;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060225F1 RID: 140785 RVA: 0x00BC2520 File Offset: 0x00BC0720
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_unreadMailCountText(IntPtr l)
	{
		int result;
		try
		{
			WorldUIController worldUIController = (WorldUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, worldUIController.m_luaExportHelper.m_unreadMailCountText);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060225F2 RID: 140786 RVA: 0x00BC2578 File Offset: 0x00BC0778
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_unreadMailCountText(IntPtr l)
	{
		int result;
		try
		{
			WorldUIController worldUIController = (WorldUIController)LuaObject.checkSelf(l);
			Text unreadMailCountText;
			LuaObject.checkType<Text>(l, 2, out unreadMailCountText);
			worldUIController.m_luaExportHelper.m_unreadMailCountText = unreadMailCountText;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060225F3 RID: 140787 RVA: 0x00BC25D4 File Offset: 0x00BC07D4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_chatButton(IntPtr l)
	{
		int result;
		try
		{
			WorldUIController worldUIController = (WorldUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, worldUIController.m_luaExportHelper.m_chatButton);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060225F4 RID: 140788 RVA: 0x00BC262C File Offset: 0x00BC082C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_chatButton(IntPtr l)
	{
		int result;
		try
		{
			WorldUIController worldUIController = (WorldUIController)LuaObject.checkSelf(l);
			Button chatButton;
			LuaObject.checkType<Button>(l, 2, out chatButton);
			worldUIController.m_luaExportHelper.m_chatButton = chatButton;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060225F5 RID: 140789 RVA: 0x00BC2688 File Offset: 0x00BC0888
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_newChatCountText(IntPtr l)
	{
		int result;
		try
		{
			WorldUIController worldUIController = (WorldUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, worldUIController.m_luaExportHelper.m_newChatCountText);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060225F6 RID: 140790 RVA: 0x00BC26E0 File Offset: 0x00BC08E0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_newChatCountText(IntPtr l)
	{
		int result;
		try
		{
			WorldUIController worldUIController = (WorldUIController)LuaObject.checkSelf(l);
			Text newChatCountText;
			LuaObject.checkType<Text>(l, 2, out newChatCountText);
			worldUIController.m_luaExportHelper.m_newChatCountText = newChatCountText;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060225F7 RID: 140791 RVA: 0x00BC273C File Offset: 0x00BC093C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_rankButton(IntPtr l)
	{
		int result;
		try
		{
			WorldUIController worldUIController = (WorldUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, worldUIController.m_luaExportHelper.m_rankButton);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060225F8 RID: 140792 RVA: 0x00BC2794 File Offset: 0x00BC0994
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_rankButton(IntPtr l)
	{
		int result;
		try
		{
			WorldUIController worldUIController = (WorldUIController)LuaObject.checkSelf(l);
			Button rankButton;
			LuaObject.checkType<Button>(l, 2, out rankButton);
			worldUIController.m_luaExportHelper.m_rankButton = rankButton;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060225F9 RID: 140793 RVA: 0x00BC27F0 File Offset: 0x00BC09F0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_activityButton(IntPtr l)
	{
		int result;
		try
		{
			WorldUIController worldUIController = (WorldUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, worldUIController.m_luaExportHelper.m_activityButton);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060225FA RID: 140794 RVA: 0x00BC2848 File Offset: 0x00BC0A48
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_activityButton(IntPtr l)
	{
		int result;
		try
		{
			WorldUIController worldUIController = (WorldUIController)LuaObject.checkSelf(l);
			Button activityButton;
			LuaObject.checkType<Button>(l, 2, out activityButton);
			worldUIController.m_luaExportHelper.m_activityButton = activityButton;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060225FB RID: 140795 RVA: 0x00BC28A4 File Offset: 0x00BC0AA4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_activityRedMarkGameObject(IntPtr l)
	{
		int result;
		try
		{
			WorldUIController worldUIController = (WorldUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, worldUIController.m_luaExportHelper.m_activityRedMarkGameObject);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060225FC RID: 140796 RVA: 0x00BC28FC File Offset: 0x00BC0AFC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_activityRedMarkGameObject(IntPtr l)
	{
		int result;
		try
		{
			WorldUIController worldUIController = (WorldUIController)LuaObject.checkSelf(l);
			GameObject activityRedMarkGameObject;
			LuaObject.checkType<GameObject>(l, 2, out activityRedMarkGameObject);
			worldUIController.m_luaExportHelper.m_activityRedMarkGameObject = activityRedMarkGameObject;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060225FD RID: 140797 RVA: 0x00BC2958 File Offset: 0x00BC0B58
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_investigationButton(IntPtr l)
	{
		int result;
		try
		{
			WorldUIController worldUIController = (WorldUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, worldUIController.m_luaExportHelper.m_investigationButton);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060225FE RID: 140798 RVA: 0x00BC29B0 File Offset: 0x00BC0BB0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_investigationButton(IntPtr l)
	{
		int result;
		try
		{
			WorldUIController worldUIController = (WorldUIController)LuaObject.checkSelf(l);
			Button investigationButton;
			LuaObject.checkType<Button>(l, 2, out investigationButton);
			worldUIController.m_luaExportHelper.m_investigationButton = investigationButton;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060225FF RID: 140799 RVA: 0x00BC2A0C File Offset: 0x00BC0C0C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_investigationButtonRedMark(IntPtr l)
	{
		int result;
		try
		{
			WorldUIController worldUIController = (WorldUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, worldUIController.m_luaExportHelper.m_investigationButtonRedMark);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06022600 RID: 140800 RVA: 0x00BC2A64 File Offset: 0x00BC0C64
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_investigationButtonRedMark(IntPtr l)
	{
		int result;
		try
		{
			WorldUIController worldUIController = (WorldUIController)LuaObject.checkSelf(l);
			GameObject investigationButtonRedMark;
			LuaObject.checkType<GameObject>(l, 2, out investigationButtonRedMark);
			worldUIController.m_luaExportHelper.m_investigationButtonRedMark = investigationButtonRedMark;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06022601 RID: 140801 RVA: 0x00BC2AC0 File Offset: 0x00BC0CC0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_YYBButton(IntPtr l)
	{
		int result;
		try
		{
			WorldUIController worldUIController = (WorldUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, worldUIController.m_luaExportHelper.m_YYBButton);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06022602 RID: 140802 RVA: 0x00BC2B18 File Offset: 0x00BC0D18
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_YYBButton(IntPtr l)
	{
		int result;
		try
		{
			WorldUIController worldUIController = (WorldUIController)LuaObject.checkSelf(l);
			Button yybbutton;
			LuaObject.checkType<Button>(l, 2, out yybbutton);
			worldUIController.m_luaExportHelper.m_YYBButton = yybbutton;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06022603 RID: 140803 RVA: 0x00BC2B74 File Offset: 0x00BC0D74
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_OppoButton(IntPtr l)
	{
		int result;
		try
		{
			WorldUIController worldUIController = (WorldUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, worldUIController.m_luaExportHelper.m_OppoButton);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06022604 RID: 140804 RVA: 0x00BC2BCC File Offset: 0x00BC0DCC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_OppoButton(IntPtr l)
	{
		int result;
		try
		{
			WorldUIController worldUIController = (WorldUIController)LuaObject.checkSelf(l);
			Button oppoButton;
			LuaObject.checkType<Button>(l, 2, out oppoButton);
			worldUIController.m_luaExportHelper.m_OppoButton = oppoButton;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06022605 RID: 140805 RVA: 0x00BC2C28 File Offset: 0x00BC0E28
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_openServiceActivityButton(IntPtr l)
	{
		int result;
		try
		{
			WorldUIController worldUIController = (WorldUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, worldUIController.m_luaExportHelper.m_openServiceActivityButton);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06022606 RID: 140806 RVA: 0x00BC2C80 File Offset: 0x00BC0E80
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_openServiceActivityButton(IntPtr l)
	{
		int result;
		try
		{
			WorldUIController worldUIController = (WorldUIController)LuaObject.checkSelf(l);
			Button openServiceActivityButton;
			LuaObject.checkType<Button>(l, 2, out openServiceActivityButton);
			worldUIController.m_luaExportHelper.m_openServiceActivityButton = openServiceActivityButton;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06022607 RID: 140807 RVA: 0x00BC2CDC File Offset: 0x00BC0EDC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_openServiceActivityButtonRedMark(IntPtr l)
	{
		int result;
		try
		{
			WorldUIController worldUIController = (WorldUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, worldUIController.m_luaExportHelper.m_openServiceActivityButtonRedMark);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06022608 RID: 140808 RVA: 0x00BC2D34 File Offset: 0x00BC0F34
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_openServiceActivityButtonRedMark(IntPtr l)
	{
		int result;
		try
		{
			WorldUIController worldUIController = (WorldUIController)LuaObject.checkSelf(l);
			GameObject openServiceActivityButtonRedMark;
			LuaObject.checkType<GameObject>(l, 2, out openServiceActivityButtonRedMark);
			worldUIController.m_luaExportHelper.m_openServiceActivityButtonRedMark = openServiceActivityButtonRedMark;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06022609 RID: 140809 RVA: 0x00BC2D90 File Offset: 0x00BC0F90
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_monthCardButton(IntPtr l)
	{
		int result;
		try
		{
			WorldUIController worldUIController = (WorldUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, worldUIController.m_luaExportHelper.m_monthCardButton);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0602260A RID: 140810 RVA: 0x00BC2DE8 File Offset: 0x00BC0FE8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_monthCardButton(IntPtr l)
	{
		int result;
		try
		{
			WorldUIController worldUIController = (WorldUIController)LuaObject.checkSelf(l);
			Button monthCardButton;
			LuaObject.checkType<Button>(l, 2, out monthCardButton);
			worldUIController.m_luaExportHelper.m_monthCardButton = monthCardButton;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0602260B RID: 140811 RVA: 0x00BC2E44 File Offset: 0x00BC1044
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_monthCardPanelUIStateController(IntPtr l)
	{
		int result;
		try
		{
			WorldUIController worldUIController = (WorldUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, worldUIController.m_luaExportHelper.m_monthCardPanelUIStateController);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0602260C RID: 140812 RVA: 0x00BC2E9C File Offset: 0x00BC109C
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_m_monthCardPanelUIStateController(IntPtr l)
	{
		int result;
		try
		{
			WorldUIController worldUIController = (WorldUIController)LuaObject.checkSelf(l);
			CommonUIStateController monthCardPanelUIStateController;
			LuaObject.checkType<CommonUIStateController>(l, 2, out monthCardPanelUIStateController);
			worldUIController.m_luaExportHelper.m_monthCardPanelUIStateController = monthCardPanelUIStateController;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0602260D RID: 140813 RVA: 0x00BC2EF8 File Offset: 0x00BC10F8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_monthCardItemGroupObj(IntPtr l)
	{
		int result;
		try
		{
			WorldUIController worldUIController = (WorldUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, worldUIController.m_luaExportHelper.m_monthCardItemGroupObj);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0602260E RID: 140814 RVA: 0x00BC2F50 File Offset: 0x00BC1150
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_monthCardItemGroupObj(IntPtr l)
	{
		int result;
		try
		{
			WorldUIController worldUIController = (WorldUIController)LuaObject.checkSelf(l);
			GameObject monthCardItemGroupObj;
			LuaObject.checkType<GameObject>(l, 2, out monthCardItemGroupObj);
			worldUIController.m_luaExportHelper.m_monthCardItemGroupObj = monthCardItemGroupObj;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0602260F RID: 140815 RVA: 0x00BC2FAC File Offset: 0x00BC11AC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_monthCardCloseButton(IntPtr l)
	{
		int result;
		try
		{
			WorldUIController worldUIController = (WorldUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, worldUIController.m_luaExportHelper.m_monthCardCloseButton);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06022610 RID: 140816 RVA: 0x00BC3004 File Offset: 0x00BC1204
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_monthCardCloseButton(IntPtr l)
	{
		int result;
		try
		{
			WorldUIController worldUIController = (WorldUIController)LuaObject.checkSelf(l);
			Button monthCardCloseButton;
			LuaObject.checkType<Button>(l, 2, out monthCardCloseButton);
			worldUIController.m_luaExportHelper.m_monthCardCloseButton = monthCardCloseButton;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06022611 RID: 140817 RVA: 0x00BC3060 File Offset: 0x00BC1260
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_prefabsGameObject(IntPtr l)
	{
		int result;
		try
		{
			WorldUIController worldUIController = (WorldUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, worldUIController.m_luaExportHelper.m_prefabsGameObject);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06022612 RID: 140818 RVA: 0x00BC30B8 File Offset: 0x00BC12B8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_prefabsGameObject(IntPtr l)
	{
		int result;
		try
		{
			WorldUIController worldUIController = (WorldUIController)LuaObject.checkSelf(l);
			GameObject prefabsGameObject;
			LuaObject.checkType<GameObject>(l, 2, out prefabsGameObject);
			worldUIController.m_luaExportHelper.m_prefabsGameObject = prefabsGameObject;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06022613 RID: 140819 RVA: 0x00BC3114 File Offset: 0x00BC1314
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_randomEventListItemPrefab(IntPtr l)
	{
		int result;
		try
		{
			WorldUIController worldUIController = (WorldUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, worldUIController.m_luaExportHelper.m_randomEventListItemPrefab);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06022614 RID: 140820 RVA: 0x00BC316C File Offset: 0x00BC136C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_randomEventListItemPrefab(IntPtr l)
	{
		int result;
		try
		{
			WorldUIController worldUIController = (WorldUIController)LuaObject.checkSelf(l);
			GameObject randomEventListItemPrefab;
			LuaObject.checkType<GameObject>(l, 2, out randomEventListItemPrefab);
			worldUIController.m_luaExportHelper.m_randomEventListItemPrefab = randomEventListItemPrefab;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06022615 RID: 140821 RVA: 0x00BC31C8 File Offset: 0x00BC13C8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_pastScenarioListItemPrefab(IntPtr l)
	{
		int result;
		try
		{
			WorldUIController worldUIController = (WorldUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, worldUIController.m_luaExportHelper.m_pastScenarioListItemPrefab);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06022616 RID: 140822 RVA: 0x00BC3220 File Offset: 0x00BC1420
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_pastScenarioListItemPrefab(IntPtr l)
	{
		int result;
		try
		{
			WorldUIController worldUIController = (WorldUIController)LuaObject.checkSelf(l);
			GameObject pastScenarioListItemPrefab;
			LuaObject.checkType<GameObject>(l, 2, out pastScenarioListItemPrefab);
			worldUIController.m_luaExportHelper.m_pastScenarioListItemPrefab = pastScenarioListItemPrefab;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06022617 RID: 140823 RVA: 0x00BC327C File Offset: 0x00BC147C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_monthCardItemPrefab(IntPtr l)
	{
		int result;
		try
		{
			WorldUIController worldUIController = (WorldUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, worldUIController.m_luaExportHelper.m_monthCardItemPrefab);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06022618 RID: 140824 RVA: 0x00BC32D4 File Offset: 0x00BC14D4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_monthCardItemPrefab(IntPtr l)
	{
		int result;
		try
		{
			WorldUIController worldUIController = (WorldUIController)LuaObject.checkSelf(l);
			GameObject monthCardItemPrefab;
			LuaObject.checkType<GameObject>(l, 2, out monthCardItemPrefab);
			worldUIController.m_luaExportHelper.m_monthCardItemPrefab = monthCardItemPrefab;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06022619 RID: 140825 RVA: 0x00BC3330 File Offset: 0x00BC1530
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_gotoRiftLevelInfo(IntPtr l)
	{
		int result;
		try
		{
			WorldUIController worldUIController = (WorldUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, worldUIController.m_luaExportHelper.m_gotoRiftLevelInfo);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0602261A RID: 140826 RVA: 0x00BC3388 File Offset: 0x00BC1588
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_gotoRiftLevelInfo(IntPtr l)
	{
		int result;
		try
		{
			WorldUIController worldUIController = (WorldUIController)LuaObject.checkSelf(l);
			ConfigDataRiftLevelInfo gotoRiftLevelInfo;
			LuaObject.checkType<ConfigDataRiftLevelInfo>(l, 2, out gotoRiftLevelInfo);
			worldUIController.m_luaExportHelper.m_gotoRiftLevelInfo = gotoRiftLevelInfo;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0602261B RID: 140827 RVA: 0x00BC33E4 File Offset: 0x00BC15E4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_developerClickCount(IntPtr l)
	{
		int result;
		try
		{
			WorldUIController worldUIController = (WorldUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, worldUIController.m_luaExportHelper.m_developerClickCount);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0602261C RID: 140828 RVA: 0x00BC343C File Offset: 0x00BC163C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_developerClickCount(IntPtr l)
	{
		int result;
		try
		{
			WorldUIController worldUIController = (WorldUIController)LuaObject.checkSelf(l);
			int developerClickCount;
			LuaObject.checkType(l, 2, out developerClickCount);
			worldUIController.m_luaExportHelper.m_developerClickCount = developerClickCount;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0602261D RID: 140829 RVA: 0x00BC3498 File Offset: 0x00BC1698
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_fogColor(IntPtr l)
	{
		int result;
		try
		{
			WorldUIController worldUIController = (WorldUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, worldUIController.m_luaExportHelper.m_fogColor);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0602261E RID: 140830 RVA: 0x00BC34F0 File Offset: 0x00BC16F0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_fogColor(IntPtr l)
	{
		int result;
		try
		{
			WorldUIController worldUIController = (WorldUIController)LuaObject.checkSelf(l);
			Color fogColor;
			LuaObject.checkType(l, 2, out fogColor);
			worldUIController.m_luaExportHelper.m_fogColor = fogColor;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0602261F RID: 140831 RVA: 0x00BC354C File Offset: 0x00BC174C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_randomEventListItems(IntPtr l)
	{
		int result;
		try
		{
			WorldUIController worldUIController = (WorldUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, worldUIController.m_luaExportHelper.m_randomEventListItems);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06022620 RID: 140832 RVA: 0x00BC35A4 File Offset: 0x00BC17A4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_randomEventListItems(IntPtr l)
	{
		int result;
		try
		{
			WorldUIController worldUIController = (WorldUIController)LuaObject.checkSelf(l);
			List<WorldEventListItemUIController> randomEventListItems;
			LuaObject.checkType<List<WorldEventListItemUIController>>(l, 2, out randomEventListItems);
			worldUIController.m_luaExportHelper.m_randomEventListItems = randomEventListItems;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06022621 RID: 140833 RVA: 0x00BC3600 File Offset: 0x00BC1800
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_pastScenarioListItems(IntPtr l)
	{
		int result;
		try
		{
			WorldUIController worldUIController = (WorldUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, worldUIController.m_luaExportHelper.m_pastScenarioListItems);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06022622 RID: 140834 RVA: 0x00BC3658 File Offset: 0x00BC1858
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_pastScenarioListItems(IntPtr l)
	{
		int result;
		try
		{
			WorldUIController worldUIController = (WorldUIController)LuaObject.checkSelf(l);
			List<PastScenarioListItemUIController> pastScenarioListItems;
			LuaObject.checkType<List<PastScenarioListItemUIController>>(l, 2, out pastScenarioListItems);
			worldUIController.m_luaExportHelper.m_pastScenarioListItems = pastScenarioListItems;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06022623 RID: 140835 RVA: 0x00BC36B4 File Offset: 0x00BC18B4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_userGuideDialogHideGameObjects(IntPtr l)
	{
		int result;
		try
		{
			WorldUIController worldUIController = (WorldUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, worldUIController.m_luaExportHelper.m_userGuideDialogHideGameObjects);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06022624 RID: 140836 RVA: 0x00BC370C File Offset: 0x00BC190C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_userGuideDialogHideGameObjects(IntPtr l)
	{
		int result;
		try
		{
			WorldUIController worldUIController = (WorldUIController)LuaObject.checkSelf(l);
			List<GameObject> userGuideDialogHideGameObjects;
			LuaObject.checkType<List<GameObject>>(l, 2, out userGuideDialogHideGameObjects);
			worldUIController.m_luaExportHelper.m_userGuideDialogHideGameObjects = userGuideDialogHideGameObjects;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06022625 RID: 140837 RVA: 0x00BC3768 File Offset: 0x00BC1968
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_configDataLoader(IntPtr l)
	{
		int result;
		try
		{
			WorldUIController worldUIController = (WorldUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, worldUIController.m_luaExportHelper.m_configDataLoader);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06022626 RID: 140838 RVA: 0x00BC37C0 File Offset: 0x00BC19C0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_configDataLoader(IntPtr l)
	{
		int result;
		try
		{
			WorldUIController worldUIController = (WorldUIController)LuaObject.checkSelf(l);
			IConfigDataLoader configDataLoader;
			LuaObject.checkType<IConfigDataLoader>(l, 2, out configDataLoader);
			worldUIController.m_luaExportHelper.m_configDataLoader = configDataLoader;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06022627 RID: 140839 RVA: 0x00BC381C File Offset: 0x00BC1A1C
	[Preserve]
	public static void reg(IntPtr l)
	{
		LuaObject.getTypeTable(l, "BlackJack.ProjectL.UI.WorldUIController");
		if (Lua_BlackJack_ProjectL_UI_WorldUIController.<>f__mg$cache0 == null)
		{
			Lua_BlackJack_ProjectL_UI_WorldUIController.<>f__mg$cache0 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_WorldUIController.ShowOrHide);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_WorldUIController.<>f__mg$cache0);
		if (Lua_BlackJack_ProjectL_UI_WorldUIController.<>f__mg$cache1 == null)
		{
			Lua_BlackJack_ProjectL_UI_WorldUIController.<>f__mg$cache1 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_WorldUIController.UpdateGameFunctionOpen);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_WorldUIController.<>f__mg$cache1);
		if (Lua_BlackJack_ProjectL_UI_WorldUIController.<>f__mg$cache2 == null)
		{
			Lua_BlackJack_ProjectL_UI_WorldUIController.<>f__mg$cache2 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_WorldUIController.SetPlayerName);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_WorldUIController.<>f__mg$cache2);
		if (Lua_BlackJack_ProjectL_UI_WorldUIController.<>f__mg$cache3 == null)
		{
			Lua_BlackJack_ProjectL_UI_WorldUIController.<>f__mg$cache3 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_WorldUIController.SetPlayerLevel);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_WorldUIController.<>f__mg$cache3);
		if (Lua_BlackJack_ProjectL_UI_WorldUIController.<>f__mg$cache4 == null)
		{
			Lua_BlackJack_ProjectL_UI_WorldUIController.<>f__mg$cache4 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_WorldUIController.SetPlayerVip);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_WorldUIController.<>f__mg$cache4);
		if (Lua_BlackJack_ProjectL_UI_WorldUIController.<>f__mg$cache5 == null)
		{
			Lua_BlackJack_ProjectL_UI_WorldUIController.<>f__mg$cache5 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_WorldUIController.SetPlayerExp);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_WorldUIController.<>f__mg$cache5);
		if (Lua_BlackJack_ProjectL_UI_WorldUIController.<>f__mg$cache6 == null)
		{
			Lua_BlackJack_ProjectL_UI_WorldUIController.<>f__mg$cache6 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_WorldUIController.SetPlayerHeadIcon);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_WorldUIController.<>f__mg$cache6);
		if (Lua_BlackJack_ProjectL_UI_WorldUIController.<>f__mg$cache7 == null)
		{
			Lua_BlackJack_ProjectL_UI_WorldUIController.<>f__mg$cache7 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_WorldUIController.ShowMainButtonBar);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_WorldUIController.<>f__mg$cache7);
		if (Lua_BlackJack_ProjectL_UI_WorldUIController.<>f__mg$cache8 == null)
		{
			Lua_BlackJack_ProjectL_UI_WorldUIController.<>f__mg$cache8 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_WorldUIController.SetCurrentScenario);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_WorldUIController.<>f__mg$cache8);
		if (Lua_BlackJack_ProjectL_UI_WorldUIController.<>f__mg$cache9 == null)
		{
			Lua_BlackJack_ProjectL_UI_WorldUIController.<>f__mg$cache9 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_WorldUIController.ShowNewScenario);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_WorldUIController.<>f__mg$cache9);
		if (Lua_BlackJack_ProjectL_UI_WorldUIController.<>f__mg$cacheA == null)
		{
			Lua_BlackJack_ProjectL_UI_WorldUIController.<>f__mg$cacheA = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_WorldUIController.ShowUnlockScenario);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_WorldUIController.<>f__mg$cacheA);
		if (Lua_BlackJack_ProjectL_UI_WorldUIController.<>f__mg$cacheB == null)
		{
			Lua_BlackJack_ProjectL_UI_WorldUIController.<>f__mg$cacheB = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_WorldUIController.ShowEnterScenario);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_WorldUIController.<>f__mg$cacheB);
		if (Lua_BlackJack_ProjectL_UI_WorldUIController.<>f__mg$cacheC == null)
		{
			Lua_BlackJack_ProjectL_UI_WorldUIController.<>f__mg$cacheC = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_WorldUIController.ShowEnterMonster);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_WorldUIController.<>f__mg$cacheC);
		if (Lua_BlackJack_ProjectL_UI_WorldUIController.<>f__mg$cacheD == null)
		{
			Lua_BlackJack_ProjectL_UI_WorldUIController.<>f__mg$cacheD = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_WorldUIController.SetFog);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_WorldUIController.<>f__mg$cacheD);
		if (Lua_BlackJack_ProjectL_UI_WorldUIController.<>f__mg$cacheE == null)
		{
			Lua_BlackJack_ProjectL_UI_WorldUIController.<>f__mg$cacheE = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_WorldUIController.AddRandomEvent);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_WorldUIController.<>f__mg$cacheE);
		if (Lua_BlackJack_ProjectL_UI_WorldUIController.<>f__mg$cacheF == null)
		{
			Lua_BlackJack_ProjectL_UI_WorldUIController.<>f__mg$cacheF = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_WorldUIController.ClearRandomEventList);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_WorldUIController.<>f__mg$cacheF);
		if (Lua_BlackJack_ProjectL_UI_WorldUIController.<>f__mg$cache10 == null)
		{
			Lua_BlackJack_ProjectL_UI_WorldUIController.<>f__mg$cache10 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_WorldUIController.ShowEventList);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_WorldUIController.<>f__mg$cache10);
		if (Lua_BlackJack_ProjectL_UI_WorldUIController.<>f__mg$cache11 == null)
		{
			Lua_BlackJack_ProjectL_UI_WorldUIController.<>f__mg$cache11 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_WorldUIController.HideEventList);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_WorldUIController.<>f__mg$cache11);
		if (Lua_BlackJack_ProjectL_UI_WorldUIController.<>f__mg$cache12 == null)
		{
			Lua_BlackJack_ProjectL_UI_WorldUIController.<>f__mg$cache12 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_WorldUIController.IsEventListVisible);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_WorldUIController.<>f__mg$cache12);
		if (Lua_BlackJack_ProjectL_UI_WorldUIController.<>f__mg$cache13 == null)
		{
			Lua_BlackJack_ProjectL_UI_WorldUIController.<>f__mg$cache13 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_WorldUIController.AddPastScenario);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_WorldUIController.<>f__mg$cache13);
		if (Lua_BlackJack_ProjectL_UI_WorldUIController.<>f__mg$cache14 == null)
		{
			Lua_BlackJack_ProjectL_UI_WorldUIController.<>f__mg$cache14 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_WorldUIController.ClearPastScenarioList);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_WorldUIController.<>f__mg$cache14);
		if (Lua_BlackJack_ProjectL_UI_WorldUIController.<>f__mg$cache15 == null)
		{
			Lua_BlackJack_ProjectL_UI_WorldUIController.<>f__mg$cache15 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_WorldUIController.ShowPastScenarioList);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_WorldUIController.<>f__mg$cache15);
		if (Lua_BlackJack_ProjectL_UI_WorldUIController.<>f__mg$cache16 == null)
		{
			Lua_BlackJack_ProjectL_UI_WorldUIController.<>f__mg$cache16 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_WorldUIController.HidePastScenarioList);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_WorldUIController.<>f__mg$cache16);
		if (Lua_BlackJack_ProjectL_UI_WorldUIController.<>f__mg$cache17 == null)
		{
			Lua_BlackJack_ProjectL_UI_WorldUIController.<>f__mg$cache17 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_WorldUIController.ShowCooperateBattleButton);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_WorldUIController.<>f__mg$cache17);
		if (Lua_BlackJack_ProjectL_UI_WorldUIController.<>f__mg$cache18 == null)
		{
			Lua_BlackJack_ProjectL_UI_WorldUIController.<>f__mg$cache18 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_WorldUIController.ShowHeroRedMark);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_WorldUIController.<>f__mg$cache18);
		if (Lua_BlackJack_ProjectL_UI_WorldUIController.<>f__mg$cache19 == null)
		{
			Lua_BlackJack_ProjectL_UI_WorldUIController.<>f__mg$cache19 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_WorldUIController.ShowDrillRedMark);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_WorldUIController.<>f__mg$cache19);
		if (Lua_BlackJack_ProjectL_UI_WorldUIController.<>f__mg$cache1A == null)
		{
			Lua_BlackJack_ProjectL_UI_WorldUIController.<>f__mg$cache1A = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_WorldUIController.ShowFetterRedMark);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_WorldUIController.<>f__mg$cache1A);
		if (Lua_BlackJack_ProjectL_UI_WorldUIController.<>f__mg$cache1B == null)
		{
			Lua_BlackJack_ProjectL_UI_WorldUIController.<>f__mg$cache1B = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_WorldUIController.ShowGuildRedMark);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_WorldUIController.<>f__mg$cache1B);
		if (Lua_BlackJack_ProjectL_UI_WorldUIController.<>f__mg$cache1C == null)
		{
			Lua_BlackJack_ProjectL_UI_WorldUIController.<>f__mg$cache1C = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_WorldUIController.ShowEventRedMark);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_WorldUIController.<>f__mg$cache1C);
		if (Lua_BlackJack_ProjectL_UI_WorldUIController.<>f__mg$cache1D == null)
		{
			Lua_BlackJack_ProjectL_UI_WorldUIController.<>f__mg$cache1D = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_WorldUIController.ShowMissionRedMark);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_WorldUIController.<>f__mg$cache1D);
		if (Lua_BlackJack_ProjectL_UI_WorldUIController.<>f__mg$cache1E == null)
		{
			Lua_BlackJack_ProjectL_UI_WorldUIController.<>f__mg$cache1E = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_WorldUIController.ShowActivityRedMark);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_WorldUIController.<>f__mg$cache1E);
		if (Lua_BlackJack_ProjectL_UI_WorldUIController.<>f__mg$cache1F == null)
		{
			Lua_BlackJack_ProjectL_UI_WorldUIController.<>f__mg$cache1F = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_WorldUIController.ShowFriendRedMark);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_WorldUIController.<>f__mg$cache1F);
		if (Lua_BlackJack_ProjectL_UI_WorldUIController.<>f__mg$cache20 == null)
		{
			Lua_BlackJack_ProjectL_UI_WorldUIController.<>f__mg$cache20 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_WorldUIController.UpdateNewChatCount);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_WorldUIController.<>f__mg$cache20);
		if (Lua_BlackJack_ProjectL_UI_WorldUIController.<>f__mg$cache21 == null)
		{
			Lua_BlackJack_ProjectL_UI_WorldUIController.<>f__mg$cache21 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_WorldUIController.UpdateUnreadMailCount);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_WorldUIController.<>f__mg$cache21);
		if (Lua_BlackJack_ProjectL_UI_WorldUIController.<>f__mg$cache22 == null)
		{
			Lua_BlackJack_ProjectL_UI_WorldUIController.<>f__mg$cache22 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_WorldUIController.GetUserGuideDialogHideGameObjects);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_WorldUIController.<>f__mg$cache22);
		if (Lua_BlackJack_ProjectL_UI_WorldUIController.<>f__mg$cache23 == null)
		{
			Lua_BlackJack_ProjectL_UI_WorldUIController.<>f__mg$cache23 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_WorldUIController.UpdateMonthCardOpen);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_WorldUIController.<>f__mg$cache23);
		if (Lua_BlackJack_ProjectL_UI_WorldUIController.<>f__mg$cache24 == null)
		{
			Lua_BlackJack_ProjectL_UI_WorldUIController.<>f__mg$cache24 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_WorldUIController.OpenMonthCardPanel);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_WorldUIController.<>f__mg$cache24);
		if (Lua_BlackJack_ProjectL_UI_WorldUIController.<>f__mg$cache25 == null)
		{
			Lua_BlackJack_ProjectL_UI_WorldUIController.<>f__mg$cache25 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_WorldUIController.CloseMonthCardPanel);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_WorldUIController.<>f__mg$cache25);
		if (Lua_BlackJack_ProjectL_UI_WorldUIController.<>f__mg$cache26 == null)
		{
			Lua_BlackJack_ProjectL_UI_WorldUIController.<>f__mg$cache26 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_WorldUIController.UpdateInvestigationButton);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_WorldUIController.<>f__mg$cache26);
		if (Lua_BlackJack_ProjectL_UI_WorldUIController.<>f__mg$cache27 == null)
		{
			Lua_BlackJack_ProjectL_UI_WorldUIController.<>f__mg$cache27 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_WorldUIController.UpdateOpenServiceActivityButton);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_WorldUIController.<>f__mg$cache27);
		if (Lua_BlackJack_ProjectL_UI_WorldUIController.<>f__mg$cache28 == null)
		{
			Lua_BlackJack_ProjectL_UI_WorldUIController.<>f__mg$cache28 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_WorldUIController.OnBindFiledsCompleted);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_WorldUIController.<>f__mg$cache28);
		if (Lua_BlackJack_ProjectL_UI_WorldUIController.<>f__mg$cache29 == null)
		{
			Lua_BlackJack_ProjectL_UI_WorldUIController.<>f__mg$cache29 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_WorldUIController.OnEnable);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_WorldUIController.<>f__mg$cache29);
		if (Lua_BlackJack_ProjectL_UI_WorldUIController.<>f__mg$cache2A == null)
		{
			Lua_BlackJack_ProjectL_UI_WorldUIController.<>f__mg$cache2A = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_WorldUIController.UpdateDeveloperMode);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_WorldUIController.<>f__mg$cache2A);
		if (Lua_BlackJack_ProjectL_UI_WorldUIController.<>f__mg$cache2B == null)
		{
			Lua_BlackJack_ProjectL_UI_WorldUIController.<>f__mg$cache2B = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_WorldUIController.Co_EnterMonster);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_WorldUIController.<>f__mg$cache2B);
		if (Lua_BlackJack_ProjectL_UI_WorldUIController.<>f__mg$cache2C == null)
		{
			Lua_BlackJack_ProjectL_UI_WorldUIController.<>f__mg$cache2C = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_WorldUIController.DeveloperModeClick);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_WorldUIController.<>f__mg$cache2C);
		if (Lua_BlackJack_ProjectL_UI_WorldUIController.<>f__mg$cache2D == null)
		{
			Lua_BlackJack_ProjectL_UI_WorldUIController.<>f__mg$cache2D = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_WorldUIController.OnCompassButtonClick);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_WorldUIController.<>f__mg$cache2D);
		if (Lua_BlackJack_ProjectL_UI_WorldUIController.<>f__mg$cache2E == null)
		{
			Lua_BlackJack_ProjectL_UI_WorldUIController.<>f__mg$cache2E = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_WorldUIController.OnCurrentScenarioButtonClick);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_WorldUIController.<>f__mg$cache2E);
		if (Lua_BlackJack_ProjectL_UI_WorldUIController.<>f__mg$cache2F == null)
		{
			Lua_BlackJack_ProjectL_UI_WorldUIController.<>f__mg$cache2F = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_WorldUIController.OnUnlockScenarioBackgroundButtonClick);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_WorldUIController.<>f__mg$cache2F);
		if (Lua_BlackJack_ProjectL_UI_WorldUIController.<>f__mg$cache30 == null)
		{
			Lua_BlackJack_ProjectL_UI_WorldUIController.<>f__mg$cache30 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_WorldUIController.OnUnlockScenarioGotoButtonClick);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_WorldUIController.<>f__mg$cache30);
		if (Lua_BlackJack_ProjectL_UI_WorldUIController.<>f__mg$cache31 == null)
		{
			Lua_BlackJack_ProjectL_UI_WorldUIController.<>f__mg$cache31 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_WorldUIController.OnMainButtonClick);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_WorldUIController.<>f__mg$cache31);
		if (Lua_BlackJack_ProjectL_UI_WorldUIController.<>f__mg$cache32 == null)
		{
			Lua_BlackJack_ProjectL_UI_WorldUIController.<>f__mg$cache32 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_WorldUIController.OnPlayerButtonClick);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_WorldUIController.<>f__mg$cache32);
		if (Lua_BlackJack_ProjectL_UI_WorldUIController.<>f__mg$cache33 == null)
		{
			Lua_BlackJack_ProjectL_UI_WorldUIController.<>f__mg$cache33 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_WorldUIController.OnHeroButtonClick);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_WorldUIController.<>f__mg$cache33);
		if (Lua_BlackJack_ProjectL_UI_WorldUIController.<>f__mg$cache34 == null)
		{
			Lua_BlackJack_ProjectL_UI_WorldUIController.<>f__mg$cache34 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_WorldUIController.OnBagButtonClick);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_WorldUIController.<>f__mg$cache34);
		if (Lua_BlackJack_ProjectL_UI_WorldUIController.<>f__mg$cache35 == null)
		{
			Lua_BlackJack_ProjectL_UI_WorldUIController.<>f__mg$cache35 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_WorldUIController.OnSelectCardButtonClick);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_WorldUIController.<>f__mg$cache35);
		if (Lua_BlackJack_ProjectL_UI_WorldUIController.<>f__mg$cache36 == null)
		{
			Lua_BlackJack_ProjectL_UI_WorldUIController.<>f__mg$cache36 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_WorldUIController.OnMissionButtonClick);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_WorldUIController.<>f__mg$cache36);
		if (Lua_BlackJack_ProjectL_UI_WorldUIController.<>f__mg$cache37 == null)
		{
			Lua_BlackJack_ProjectL_UI_WorldUIController.<>f__mg$cache37 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_WorldUIController.OnFetterButtonClick);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_WorldUIController.<>f__mg$cache37);
		if (Lua_BlackJack_ProjectL_UI_WorldUIController.<>f__mg$cache38 == null)
		{
			Lua_BlackJack_ProjectL_UI_WorldUIController.<>f__mg$cache38 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_WorldUIController.OnStoreButtonClick);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_WorldUIController.<>f__mg$cache38);
		if (Lua_BlackJack_ProjectL_UI_WorldUIController.<>f__mg$cache39 == null)
		{
			Lua_BlackJack_ProjectL_UI_WorldUIController.<>f__mg$cache39 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_WorldUIController.OnDrillButtonClick);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_WorldUIController.<>f__mg$cache39);
		if (Lua_BlackJack_ProjectL_UI_WorldUIController.<>f__mg$cache3A == null)
		{
			Lua_BlackJack_ProjectL_UI_WorldUIController.<>f__mg$cache3A = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_WorldUIController.OnFriendButtonClick);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_WorldUIController.<>f__mg$cache3A);
		if (Lua_BlackJack_ProjectL_UI_WorldUIController.<>f__mg$cache3B == null)
		{
			Lua_BlackJack_ProjectL_UI_WorldUIController.<>f__mg$cache3B = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_WorldUIController.OnGuildButtonClick);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_WorldUIController.<>f__mg$cache3B);
		if (Lua_BlackJack_ProjectL_UI_WorldUIController.<>f__mg$cache3C == null)
		{
			Lua_BlackJack_ProjectL_UI_WorldUIController.<>f__mg$cache3C = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_WorldUIController.OnEventButtonClick);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_WorldUIController.<>f__mg$cache3C);
		if (Lua_BlackJack_ProjectL_UI_WorldUIController.<>f__mg$cache3D == null)
		{
			Lua_BlackJack_ProjectL_UI_WorldUIController.<>f__mg$cache3D = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_WorldUIController.OnUnchartedButtonClick);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_WorldUIController.<>f__mg$cache3D);
		if (Lua_BlackJack_ProjectL_UI_WorldUIController.<>f__mg$cache3E == null)
		{
			Lua_BlackJack_ProjectL_UI_WorldUIController.<>f__mg$cache3E = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_WorldUIController.OnArenaButtonClick);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_WorldUIController.<>f__mg$cache3E);
		if (Lua_BlackJack_ProjectL_UI_WorldUIController.<>f__mg$cache3F == null)
		{
			Lua_BlackJack_ProjectL_UI_WorldUIController.<>f__mg$cache3F = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_WorldUIController.OnRiftButtonClick);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_WorldUIController.<>f__mg$cache3F);
		if (Lua_BlackJack_ProjectL_UI_WorldUIController.<>f__mg$cache40 == null)
		{
			Lua_BlackJack_ProjectL_UI_WorldUIController.<>f__mg$cache40 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_WorldUIController.OnTestButtonClick);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_WorldUIController.<>f__mg$cache40);
		if (Lua_BlackJack_ProjectL_UI_WorldUIController.<>f__mg$cache41 == null)
		{
			Lua_BlackJack_ProjectL_UI_WorldUIController.<>f__mg$cache41 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_WorldUIController.OnCooperateBattleButtonClick);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_WorldUIController.<>f__mg$cache41);
		if (Lua_BlackJack_ProjectL_UI_WorldUIController.<>f__mg$cache42 == null)
		{
			Lua_BlackJack_ProjectL_UI_WorldUIController.<>f__mg$cache42 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_WorldUIController.OnMailButtonClick);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_WorldUIController.<>f__mg$cache42);
		if (Lua_BlackJack_ProjectL_UI_WorldUIController.<>f__mg$cache43 == null)
		{
			Lua_BlackJack_ProjectL_UI_WorldUIController.<>f__mg$cache43 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_WorldUIController.OnChatButtonClick);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_WorldUIController.<>f__mg$cache43);
		if (Lua_BlackJack_ProjectL_UI_WorldUIController.<>f__mg$cache44 == null)
		{
			Lua_BlackJack_ProjectL_UI_WorldUIController.<>f__mg$cache44 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_WorldUIController.OnRankButtonClick);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_WorldUIController.<>f__mg$cache44);
		if (Lua_BlackJack_ProjectL_UI_WorldUIController.<>f__mg$cache45 == null)
		{
			Lua_BlackJack_ProjectL_UI_WorldUIController.<>f__mg$cache45 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_WorldUIController.OnActivityButtonClick);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_WorldUIController.<>f__mg$cache45);
		if (Lua_BlackJack_ProjectL_UI_WorldUIController.<>f__mg$cache46 == null)
		{
			Lua_BlackJack_ProjectL_UI_WorldUIController.<>f__mg$cache46 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_WorldUIController.OnOpenServiceActivityButtonClick);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_WorldUIController.<>f__mg$cache46);
		if (Lua_BlackJack_ProjectL_UI_WorldUIController.<>f__mg$cache47 == null)
		{
			Lua_BlackJack_ProjectL_UI_WorldUIController.<>f__mg$cache47 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_WorldUIController.OnOppoButtonClick);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_WorldUIController.<>f__mg$cache47);
		if (Lua_BlackJack_ProjectL_UI_WorldUIController.<>f__mg$cache48 == null)
		{
			Lua_BlackJack_ProjectL_UI_WorldUIController.<>f__mg$cache48 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_WorldUIController.OnYingYongBaoButtonClick);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_WorldUIController.<>f__mg$cache48);
		if (Lua_BlackJack_ProjectL_UI_WorldUIController.<>f__mg$cache49 == null)
		{
			Lua_BlackJack_ProjectL_UI_WorldUIController.<>f__mg$cache49 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_WorldUIController.OnInvestigationButtonClick);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_WorldUIController.<>f__mg$cache49);
		if (Lua_BlackJack_ProjectL_UI_WorldUIController.<>f__mg$cache4A == null)
		{
			Lua_BlackJack_ProjectL_UI_WorldUIController.<>f__mg$cache4A = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_WorldUIController.WorldEventListItem_OnButtonClick);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_WorldUIController.<>f__mg$cache4A);
		if (Lua_BlackJack_ProjectL_UI_WorldUIController.<>f__mg$cache4B == null)
		{
			Lua_BlackJack_ProjectL_UI_WorldUIController.<>f__mg$cache4B = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_WorldUIController.OnEventListBackgroundButtonClick);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_WorldUIController.<>f__mg$cache4B);
		if (Lua_BlackJack_ProjectL_UI_WorldUIController.<>f__mg$cache4C == null)
		{
			Lua_BlackJack_ProjectL_UI_WorldUIController.<>f__mg$cache4C = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_WorldUIController.OnPastScenarioListBackgroundButtonClick);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_WorldUIController.<>f__mg$cache4C);
		if (Lua_BlackJack_ProjectL_UI_WorldUIController.<>f__mg$cache4D == null)
		{
			Lua_BlackJack_ProjectL_UI_WorldUIController.<>f__mg$cache4D = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_WorldUIController.PastScenarioListItem_OnStartButtonClick);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_WorldUIController.<>f__mg$cache4D);
		if (Lua_BlackJack_ProjectL_UI_WorldUIController.<>f__mg$cache4E == null)
		{
			Lua_BlackJack_ProjectL_UI_WorldUIController.<>f__mg$cache4E = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_WorldUIController.OnMonthCardButtonClick);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_WorldUIController.<>f__mg$cache4E);
		if (Lua_BlackJack_ProjectL_UI_WorldUIController.<>f__mg$cache4F == null)
		{
			Lua_BlackJack_ProjectL_UI_WorldUIController.<>f__mg$cache4F = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_WorldUIController.OnMonthCardCloseButtonClick);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_WorldUIController.<>f__mg$cache4F);
		if (Lua_BlackJack_ProjectL_UI_WorldUIController.<>f__mg$cache50 == null)
		{
			Lua_BlackJack_ProjectL_UI_WorldUIController.<>f__mg$cache50 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_WorldUIController.OnMonthCardItemItemClick);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_WorldUIController.<>f__mg$cache50);
		if (Lua_BlackJack_ProjectL_UI_WorldUIController.<>f__mg$cache51 == null)
		{
			Lua_BlackJack_ProjectL_UI_WorldUIController.<>f__mg$cache51 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_WorldUIController.OnMonthCardBuyClick);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_WorldUIController.<>f__mg$cache51);
		if (Lua_BlackJack_ProjectL_UI_WorldUIController.<>f__mg$cache52 == null)
		{
			Lua_BlackJack_ProjectL_UI_WorldUIController.<>f__mg$cache52 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_WorldUIController.__callBase_Initlize);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_WorldUIController.<>f__mg$cache52);
		if (Lua_BlackJack_ProjectL_UI_WorldUIController.<>f__mg$cache53 == null)
		{
			Lua_BlackJack_ProjectL_UI_WorldUIController.<>f__mg$cache53 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_WorldUIController.__callBase_BindFields);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_WorldUIController.<>f__mg$cache53);
		if (Lua_BlackJack_ProjectL_UI_WorldUIController.<>f__mg$cache54 == null)
		{
			Lua_BlackJack_ProjectL_UI_WorldUIController.<>f__mg$cache54 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_WorldUIController.__callBase_OnBindFiledsCompleted);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_WorldUIController.<>f__mg$cache54);
		if (Lua_BlackJack_ProjectL_UI_WorldUIController.<>f__mg$cache55 == null)
		{
			Lua_BlackJack_ProjectL_UI_WorldUIController.<>f__mg$cache55 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_WorldUIController.__callBase_BindFieldImpl);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_WorldUIController.<>f__mg$cache55);
		if (Lua_BlackJack_ProjectL_UI_WorldUIController.<>f__mg$cache56 == null)
		{
			Lua_BlackJack_ProjectL_UI_WorldUIController.<>f__mg$cache56 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_WorldUIController.__callBase_Clear);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_WorldUIController.<>f__mg$cache56);
		if (Lua_BlackJack_ProjectL_UI_WorldUIController.<>f__mg$cache57 == null)
		{
			Lua_BlackJack_ProjectL_UI_WorldUIController.<>f__mg$cache57 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_WorldUIController.__callBase_OnButtonClick);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_WorldUIController.<>f__mg$cache57);
		if (Lua_BlackJack_ProjectL_UI_WorldUIController.<>f__mg$cache58 == null)
		{
			Lua_BlackJack_ProjectL_UI_WorldUIController.<>f__mg$cache58 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_WorldUIController.__callBase_SetButtonClickListener);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_WorldUIController.<>f__mg$cache58);
		if (Lua_BlackJack_ProjectL_UI_WorldUIController.<>f__mg$cache59 == null)
		{
			Lua_BlackJack_ProjectL_UI_WorldUIController.<>f__mg$cache59 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_WorldUIController.__callBase_SetButtonDoubleClickListener);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_WorldUIController.<>f__mg$cache59);
		if (Lua_BlackJack_ProjectL_UI_WorldUIController.<>f__mg$cache5A == null)
		{
			Lua_BlackJack_ProjectL_UI_WorldUIController.<>f__mg$cache5A = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_WorldUIController.__callBase_SetButtonLongPressStartListener);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_WorldUIController.<>f__mg$cache5A);
		if (Lua_BlackJack_ProjectL_UI_WorldUIController.<>f__mg$cache5B == null)
		{
			Lua_BlackJack_ProjectL_UI_WorldUIController.<>f__mg$cache5B = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_WorldUIController.__callBase_SetButtonLongPressingListener);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_WorldUIController.<>f__mg$cache5B);
		if (Lua_BlackJack_ProjectL_UI_WorldUIController.<>f__mg$cache5C == null)
		{
			Lua_BlackJack_ProjectL_UI_WorldUIController.<>f__mg$cache5C = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_WorldUIController.__callBase_SetButtonLongPressEndListener);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_WorldUIController.<>f__mg$cache5C);
		if (Lua_BlackJack_ProjectL_UI_WorldUIController.<>f__mg$cache5D == null)
		{
			Lua_BlackJack_ProjectL_UI_WorldUIController.<>f__mg$cache5D = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_WorldUIController.__callBase_SetToggleValueChangedListener);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_WorldUIController.<>f__mg$cache5D);
		if (Lua_BlackJack_ProjectL_UI_WorldUIController.<>f__mg$cache5E == null)
		{
			Lua_BlackJack_ProjectL_UI_WorldUIController.<>f__mg$cache5E = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_WorldUIController.__callBase_ToString);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_WorldUIController.<>f__mg$cache5E);
		if (Lua_BlackJack_ProjectL_UI_WorldUIController.<>f__mg$cache5F == null)
		{
			Lua_BlackJack_ProjectL_UI_WorldUIController.<>f__mg$cache5F = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_WorldUIController.__callDele_EventOnShowPlayerInfo);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_WorldUIController.<>f__mg$cache5F);
		if (Lua_BlackJack_ProjectL_UI_WorldUIController.<>f__mg$cache60 == null)
		{
			Lua_BlackJack_ProjectL_UI_WorldUIController.<>f__mg$cache60 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_WorldUIController.__clearDele_EventOnShowPlayerInfo);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_WorldUIController.<>f__mg$cache60);
		if (Lua_BlackJack_ProjectL_UI_WorldUIController.<>f__mg$cache61 == null)
		{
			Lua_BlackJack_ProjectL_UI_WorldUIController.<>f__mg$cache61 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_WorldUIController.__callDele_EventOnCompass);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_WorldUIController.<>f__mg$cache61);
		if (Lua_BlackJack_ProjectL_UI_WorldUIController.<>f__mg$cache62 == null)
		{
			Lua_BlackJack_ProjectL_UI_WorldUIController.<>f__mg$cache62 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_WorldUIController.__clearDele_EventOnCompass);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_WorldUIController.<>f__mg$cache62);
		if (Lua_BlackJack_ProjectL_UI_WorldUIController.<>f__mg$cache63 == null)
		{
			Lua_BlackJack_ProjectL_UI_WorldUIController.<>f__mg$cache63 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_WorldUIController.__callDele_EventOnCurrentScenario);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_WorldUIController.<>f__mg$cache63);
		if (Lua_BlackJack_ProjectL_UI_WorldUIController.<>f__mg$cache64 == null)
		{
			Lua_BlackJack_ProjectL_UI_WorldUIController.<>f__mg$cache64 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_WorldUIController.__clearDele_EventOnCurrentScenario);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_WorldUIController.<>f__mg$cache64);
		if (Lua_BlackJack_ProjectL_UI_WorldUIController.<>f__mg$cache65 == null)
		{
			Lua_BlackJack_ProjectL_UI_WorldUIController.<>f__mg$cache65 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_WorldUIController.__callDele_EventOnShowMainButtonBar);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_WorldUIController.<>f__mg$cache65);
		if (Lua_BlackJack_ProjectL_UI_WorldUIController.<>f__mg$cache66 == null)
		{
			Lua_BlackJack_ProjectL_UI_WorldUIController.<>f__mg$cache66 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_WorldUIController.__clearDele_EventOnShowMainButtonBar);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_WorldUIController.<>f__mg$cache66);
		if (Lua_BlackJack_ProjectL_UI_WorldUIController.<>f__mg$cache67 == null)
		{
			Lua_BlackJack_ProjectL_UI_WorldUIController.<>f__mg$cache67 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_WorldUIController.__callDele_EventOnUnlockScenarioGotoRiftLevel);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_WorldUIController.<>f__mg$cache67);
		if (Lua_BlackJack_ProjectL_UI_WorldUIController.<>f__mg$cache68 == null)
		{
			Lua_BlackJack_ProjectL_UI_WorldUIController.<>f__mg$cache68 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_WorldUIController.__clearDele_EventOnUnlockScenarioGotoRiftLevel);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_WorldUIController.<>f__mg$cache68);
		if (Lua_BlackJack_ProjectL_UI_WorldUIController.<>f__mg$cache69 == null)
		{
			Lua_BlackJack_ProjectL_UI_WorldUIController.<>f__mg$cache69 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_WorldUIController.__callDele_EventOnGotoEvent);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_WorldUIController.<>f__mg$cache69);
		if (Lua_BlackJack_ProjectL_UI_WorldUIController.<>f__mg$cache6A == null)
		{
			Lua_BlackJack_ProjectL_UI_WorldUIController.<>f__mg$cache6A = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_WorldUIController.__clearDele_EventOnGotoEvent);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_WorldUIController.<>f__mg$cache6A);
		if (Lua_BlackJack_ProjectL_UI_WorldUIController.<>f__mg$cache6B == null)
		{
			Lua_BlackJack_ProjectL_UI_WorldUIController.<>f__mg$cache6B = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_WorldUIController.__callDele_EventOnStartPastScenario);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_WorldUIController.<>f__mg$cache6B);
		if (Lua_BlackJack_ProjectL_UI_WorldUIController.<>f__mg$cache6C == null)
		{
			Lua_BlackJack_ProjectL_UI_WorldUIController.<>f__mg$cache6C = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_WorldUIController.__clearDele_EventOnStartPastScenario);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_WorldUIController.<>f__mg$cache6C);
		if (Lua_BlackJack_ProjectL_UI_WorldUIController.<>f__mg$cache6D == null)
		{
			Lua_BlackJack_ProjectL_UI_WorldUIController.<>f__mg$cache6D = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_WorldUIController.__callDele_EventOnClosePastScenarioList);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_WorldUIController.<>f__mg$cache6D);
		if (Lua_BlackJack_ProjectL_UI_WorldUIController.<>f__mg$cache6E == null)
		{
			Lua_BlackJack_ProjectL_UI_WorldUIController.<>f__mg$cache6E = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_WorldUIController.__clearDele_EventOnClosePastScenarioList);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_WorldUIController.<>f__mg$cache6E);
		if (Lua_BlackJack_ProjectL_UI_WorldUIController.<>f__mg$cache6F == null)
		{
			Lua_BlackJack_ProjectL_UI_WorldUIController.<>f__mg$cache6F = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_WorldUIController.__callDele_EventOnShowHero);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_WorldUIController.<>f__mg$cache6F);
		if (Lua_BlackJack_ProjectL_UI_WorldUIController.<>f__mg$cache70 == null)
		{
			Lua_BlackJack_ProjectL_UI_WorldUIController.<>f__mg$cache70 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_WorldUIController.__clearDele_EventOnShowHero);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_WorldUIController.<>f__mg$cache70);
		if (Lua_BlackJack_ProjectL_UI_WorldUIController.<>f__mg$cache71 == null)
		{
			Lua_BlackJack_ProjectL_UI_WorldUIController.<>f__mg$cache71 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_WorldUIController.__callDele_EventOnShowBag);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_WorldUIController.<>f__mg$cache71);
		if (Lua_BlackJack_ProjectL_UI_WorldUIController.<>f__mg$cache72 == null)
		{
			Lua_BlackJack_ProjectL_UI_WorldUIController.<>f__mg$cache72 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_WorldUIController.__clearDele_EventOnShowBag);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_WorldUIController.<>f__mg$cache72);
		if (Lua_BlackJack_ProjectL_UI_WorldUIController.<>f__mg$cache73 == null)
		{
			Lua_BlackJack_ProjectL_UI_WorldUIController.<>f__mg$cache73 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_WorldUIController.__callDele_EventOnShowSelectCard);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_WorldUIController.<>f__mg$cache73);
		if (Lua_BlackJack_ProjectL_UI_WorldUIController.<>f__mg$cache74 == null)
		{
			Lua_BlackJack_ProjectL_UI_WorldUIController.<>f__mg$cache74 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_WorldUIController.__clearDele_EventOnShowSelectCard);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_WorldUIController.<>f__mg$cache74);
		if (Lua_BlackJack_ProjectL_UI_WorldUIController.<>f__mg$cache75 == null)
		{
			Lua_BlackJack_ProjectL_UI_WorldUIController.<>f__mg$cache75 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_WorldUIController.__callDele_EventOnShowMisision);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_WorldUIController.<>f__mg$cache75);
		if (Lua_BlackJack_ProjectL_UI_WorldUIController.<>f__mg$cache76 == null)
		{
			Lua_BlackJack_ProjectL_UI_WorldUIController.<>f__mg$cache76 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_WorldUIController.__clearDele_EventOnShowMisision);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_WorldUIController.<>f__mg$cache76);
		if (Lua_BlackJack_ProjectL_UI_WorldUIController.<>f__mg$cache77 == null)
		{
			Lua_BlackJack_ProjectL_UI_WorldUIController.<>f__mg$cache77 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_WorldUIController.__callDele_EventOnShowFetter);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_WorldUIController.<>f__mg$cache77);
		if (Lua_BlackJack_ProjectL_UI_WorldUIController.<>f__mg$cache78 == null)
		{
			Lua_BlackJack_ProjectL_UI_WorldUIController.<>f__mg$cache78 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_WorldUIController.__clearDele_EventOnShowFetter);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_WorldUIController.<>f__mg$cache78);
		if (Lua_BlackJack_ProjectL_UI_WorldUIController.<>f__mg$cache79 == null)
		{
			Lua_BlackJack_ProjectL_UI_WorldUIController.<>f__mg$cache79 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_WorldUIController.__callDele_EventOnShowStore);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_WorldUIController.<>f__mg$cache79);
		if (Lua_BlackJack_ProjectL_UI_WorldUIController.<>f__mg$cache7A == null)
		{
			Lua_BlackJack_ProjectL_UI_WorldUIController.<>f__mg$cache7A = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_WorldUIController.__clearDele_EventOnShowStore);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_WorldUIController.<>f__mg$cache7A);
		if (Lua_BlackJack_ProjectL_UI_WorldUIController.<>f__mg$cache7B == null)
		{
			Lua_BlackJack_ProjectL_UI_WorldUIController.<>f__mg$cache7B = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_WorldUIController.__callDele_EventOnShowDrill);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_WorldUIController.<>f__mg$cache7B);
		if (Lua_BlackJack_ProjectL_UI_WorldUIController.<>f__mg$cache7C == null)
		{
			Lua_BlackJack_ProjectL_UI_WorldUIController.<>f__mg$cache7C = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_WorldUIController.__clearDele_EventOnShowDrill);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_WorldUIController.<>f__mg$cache7C);
		if (Lua_BlackJack_ProjectL_UI_WorldUIController.<>f__mg$cache7D == null)
		{
			Lua_BlackJack_ProjectL_UI_WorldUIController.<>f__mg$cache7D = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_WorldUIController.__callDele_EventOnShowFriend);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_WorldUIController.<>f__mg$cache7D);
		if (Lua_BlackJack_ProjectL_UI_WorldUIController.<>f__mg$cache7E == null)
		{
			Lua_BlackJack_ProjectL_UI_WorldUIController.<>f__mg$cache7E = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_WorldUIController.__clearDele_EventOnShowFriend);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_WorldUIController.<>f__mg$cache7E);
		if (Lua_BlackJack_ProjectL_UI_WorldUIController.<>f__mg$cache7F == null)
		{
			Lua_BlackJack_ProjectL_UI_WorldUIController.<>f__mg$cache7F = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_WorldUIController.__callDele_EventOnShowGuild);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_WorldUIController.<>f__mg$cache7F);
		if (Lua_BlackJack_ProjectL_UI_WorldUIController.<>f__mg$cache80 == null)
		{
			Lua_BlackJack_ProjectL_UI_WorldUIController.<>f__mg$cache80 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_WorldUIController.__clearDele_EventOnShowGuild);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_WorldUIController.<>f__mg$cache80);
		if (Lua_BlackJack_ProjectL_UI_WorldUIController.<>f__mg$cache81 == null)
		{
			Lua_BlackJack_ProjectL_UI_WorldUIController.<>f__mg$cache81 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_WorldUIController.__callDele_EventOnShowEvent);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_WorldUIController.<>f__mg$cache81);
		if (Lua_BlackJack_ProjectL_UI_WorldUIController.<>f__mg$cache82 == null)
		{
			Lua_BlackJack_ProjectL_UI_WorldUIController.<>f__mg$cache82 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_WorldUIController.__clearDele_EventOnShowEvent);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_WorldUIController.<>f__mg$cache82);
		if (Lua_BlackJack_ProjectL_UI_WorldUIController.<>f__mg$cache83 == null)
		{
			Lua_BlackJack_ProjectL_UI_WorldUIController.<>f__mg$cache83 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_WorldUIController.__callDele_EventOnShowUncharted);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_WorldUIController.<>f__mg$cache83);
		if (Lua_BlackJack_ProjectL_UI_WorldUIController.<>f__mg$cache84 == null)
		{
			Lua_BlackJack_ProjectL_UI_WorldUIController.<>f__mg$cache84 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_WorldUIController.__clearDele_EventOnShowUncharted);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_WorldUIController.<>f__mg$cache84);
		if (Lua_BlackJack_ProjectL_UI_WorldUIController.<>f__mg$cache85 == null)
		{
			Lua_BlackJack_ProjectL_UI_WorldUIController.<>f__mg$cache85 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_WorldUIController.__callDele_EventOnShowArena);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_WorldUIController.<>f__mg$cache85);
		if (Lua_BlackJack_ProjectL_UI_WorldUIController.<>f__mg$cache86 == null)
		{
			Lua_BlackJack_ProjectL_UI_WorldUIController.<>f__mg$cache86 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_WorldUIController.__clearDele_EventOnShowArena);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_WorldUIController.<>f__mg$cache86);
		if (Lua_BlackJack_ProjectL_UI_WorldUIController.<>f__mg$cache87 == null)
		{
			Lua_BlackJack_ProjectL_UI_WorldUIController.<>f__mg$cache87 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_WorldUIController.__callDele_EventOnShowRift);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_WorldUIController.<>f__mg$cache87);
		if (Lua_BlackJack_ProjectL_UI_WorldUIController.<>f__mg$cache88 == null)
		{
			Lua_BlackJack_ProjectL_UI_WorldUIController.<>f__mg$cache88 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_WorldUIController.__clearDele_EventOnShowRift);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_WorldUIController.<>f__mg$cache88);
		if (Lua_BlackJack_ProjectL_UI_WorldUIController.<>f__mg$cache89 == null)
		{
			Lua_BlackJack_ProjectL_UI_WorldUIController.<>f__mg$cache89 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_WorldUIController.__callDele_EventOnShowTest);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_WorldUIController.<>f__mg$cache89);
		if (Lua_BlackJack_ProjectL_UI_WorldUIController.<>f__mg$cache8A == null)
		{
			Lua_BlackJack_ProjectL_UI_WorldUIController.<>f__mg$cache8A = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_WorldUIController.__clearDele_EventOnShowTest);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_WorldUIController.<>f__mg$cache8A);
		if (Lua_BlackJack_ProjectL_UI_WorldUIController.<>f__mg$cache8B == null)
		{
			Lua_BlackJack_ProjectL_UI_WorldUIController.<>f__mg$cache8B = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_WorldUIController.__callDele_EventOnShowCooperateBattle);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_WorldUIController.<>f__mg$cache8B);
		if (Lua_BlackJack_ProjectL_UI_WorldUIController.<>f__mg$cache8C == null)
		{
			Lua_BlackJack_ProjectL_UI_WorldUIController.<>f__mg$cache8C = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_WorldUIController.__clearDele_EventOnShowCooperateBattle);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_WorldUIController.<>f__mg$cache8C);
		if (Lua_BlackJack_ProjectL_UI_WorldUIController.<>f__mg$cache8D == null)
		{
			Lua_BlackJack_ProjectL_UI_WorldUIController.<>f__mg$cache8D = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_WorldUIController.__callDele_EventOnShowMail);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_WorldUIController.<>f__mg$cache8D);
		if (Lua_BlackJack_ProjectL_UI_WorldUIController.<>f__mg$cache8E == null)
		{
			Lua_BlackJack_ProjectL_UI_WorldUIController.<>f__mg$cache8E = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_WorldUIController.__clearDele_EventOnShowMail);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_WorldUIController.<>f__mg$cache8E);
		if (Lua_BlackJack_ProjectL_UI_WorldUIController.<>f__mg$cache8F == null)
		{
			Lua_BlackJack_ProjectL_UI_WorldUIController.<>f__mg$cache8F = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_WorldUIController.__callDele_EventOnShowChat);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_WorldUIController.<>f__mg$cache8F);
		if (Lua_BlackJack_ProjectL_UI_WorldUIController.<>f__mg$cache90 == null)
		{
			Lua_BlackJack_ProjectL_UI_WorldUIController.<>f__mg$cache90 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_WorldUIController.__clearDele_EventOnShowChat);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_WorldUIController.<>f__mg$cache90);
		if (Lua_BlackJack_ProjectL_UI_WorldUIController.<>f__mg$cache91 == null)
		{
			Lua_BlackJack_ProjectL_UI_WorldUIController.<>f__mg$cache91 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_WorldUIController.__callDele_EventOnShowRanking);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_WorldUIController.<>f__mg$cache91);
		if (Lua_BlackJack_ProjectL_UI_WorldUIController.<>f__mg$cache92 == null)
		{
			Lua_BlackJack_ProjectL_UI_WorldUIController.<>f__mg$cache92 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_WorldUIController.__clearDele_EventOnShowRanking);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_WorldUIController.<>f__mg$cache92);
		if (Lua_BlackJack_ProjectL_UI_WorldUIController.<>f__mg$cache93 == null)
		{
			Lua_BlackJack_ProjectL_UI_WorldUIController.<>f__mg$cache93 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_WorldUIController.__callDele_EventOnShowAnnouncement);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_WorldUIController.<>f__mg$cache93);
		if (Lua_BlackJack_ProjectL_UI_WorldUIController.<>f__mg$cache94 == null)
		{
			Lua_BlackJack_ProjectL_UI_WorldUIController.<>f__mg$cache94 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_WorldUIController.__clearDele_EventOnShowAnnouncement);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_WorldUIController.<>f__mg$cache94);
		if (Lua_BlackJack_ProjectL_UI_WorldUIController.<>f__mg$cache95 == null)
		{
			Lua_BlackJack_ProjectL_UI_WorldUIController.<>f__mg$cache95 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_WorldUIController.__callDele_EventOnOpenWebInvestigation);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_WorldUIController.<>f__mg$cache95);
		if (Lua_BlackJack_ProjectL_UI_WorldUIController.<>f__mg$cache96 == null)
		{
			Lua_BlackJack_ProjectL_UI_WorldUIController.<>f__mg$cache96 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_WorldUIController.__clearDele_EventOnOpenWebInvestigation);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_WorldUIController.<>f__mg$cache96);
		if (Lua_BlackJack_ProjectL_UI_WorldUIController.<>f__mg$cache97 == null)
		{
			Lua_BlackJack_ProjectL_UI_WorldUIController.<>f__mg$cache97 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_WorldUIController.__callDele_EventOnShowOpenServiceActivity);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_WorldUIController.<>f__mg$cache97);
		if (Lua_BlackJack_ProjectL_UI_WorldUIController.<>f__mg$cache98 == null)
		{
			Lua_BlackJack_ProjectL_UI_WorldUIController.<>f__mg$cache98 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_WorldUIController.__clearDele_EventOnShowOpenServiceActivity);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_WorldUIController.<>f__mg$cache98);
		if (Lua_BlackJack_ProjectL_UI_WorldUIController.<>f__mg$cache99 == null)
		{
			Lua_BlackJack_ProjectL_UI_WorldUIController.<>f__mg$cache99 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_WorldUIController.__callDele_EventOnMonthCardButtonClick);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_WorldUIController.<>f__mg$cache99);
		if (Lua_BlackJack_ProjectL_UI_WorldUIController.<>f__mg$cache9A == null)
		{
			Lua_BlackJack_ProjectL_UI_WorldUIController.<>f__mg$cache9A = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_WorldUIController.__clearDele_EventOnMonthCardButtonClick);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_WorldUIController.<>f__mg$cache9A);
		if (Lua_BlackJack_ProjectL_UI_WorldUIController.<>f__mg$cache9B == null)
		{
			Lua_BlackJack_ProjectL_UI_WorldUIController.<>f__mg$cache9B = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_WorldUIController.__callDele_EventOnRefreshMonthCardPanel);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_WorldUIController.<>f__mg$cache9B);
		if (Lua_BlackJack_ProjectL_UI_WorldUIController.<>f__mg$cache9C == null)
		{
			Lua_BlackJack_ProjectL_UI_WorldUIController.<>f__mg$cache9C = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_WorldUIController.__clearDele_EventOnRefreshMonthCardPanel);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_WorldUIController.<>f__mg$cache9C);
		if (Lua_BlackJack_ProjectL_UI_WorldUIController.<>f__mg$cache9D == null)
		{
			Lua_BlackJack_ProjectL_UI_WorldUIController.<>f__mg$cache9D = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_WorldUIController.__callDele_EventOnMonthCardItemClick);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_WorldUIController.<>f__mg$cache9D);
		if (Lua_BlackJack_ProjectL_UI_WorldUIController.<>f__mg$cache9E == null)
		{
			Lua_BlackJack_ProjectL_UI_WorldUIController.<>f__mg$cache9E = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_WorldUIController.__clearDele_EventOnMonthCardItemClick);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_WorldUIController.<>f__mg$cache9E);
		if (Lua_BlackJack_ProjectL_UI_WorldUIController.<>f__mg$cache9F == null)
		{
			Lua_BlackJack_ProjectL_UI_WorldUIController.<>f__mg$cache9F = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_WorldUIController.__callDele_EventOnMonthCardItemBuyClick);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_WorldUIController.<>f__mg$cache9F);
		if (Lua_BlackJack_ProjectL_UI_WorldUIController.<>f__mg$cacheA0 == null)
		{
			Lua_BlackJack_ProjectL_UI_WorldUIController.<>f__mg$cacheA0 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_WorldUIController.__clearDele_EventOnMonthCardItemBuyClick);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_WorldUIController.<>f__mg$cacheA0);
		if (Lua_BlackJack_ProjectL_UI_WorldUIController.<>f__mg$cacheA1 == null)
		{
			Lua_BlackJack_ProjectL_UI_WorldUIController.<>f__mg$cacheA1 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_WorldUIController.__callDele_EventOnYYBButtonClick);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_WorldUIController.<>f__mg$cacheA1);
		if (Lua_BlackJack_ProjectL_UI_WorldUIController.<>f__mg$cacheA2 == null)
		{
			Lua_BlackJack_ProjectL_UI_WorldUIController.<>f__mg$cacheA2 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_WorldUIController.__clearDele_EventOnYYBButtonClick);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_WorldUIController.<>f__mg$cacheA2);
		if (Lua_BlackJack_ProjectL_UI_WorldUIController.<>f__mg$cacheA3 == null)
		{
			Lua_BlackJack_ProjectL_UI_WorldUIController.<>f__mg$cacheA3 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_WorldUIController.__callDele_EventOnOppoButtonClick);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_WorldUIController.<>f__mg$cacheA3);
		if (Lua_BlackJack_ProjectL_UI_WorldUIController.<>f__mg$cacheA4 == null)
		{
			Lua_BlackJack_ProjectL_UI_WorldUIController.<>f__mg$cacheA4 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_WorldUIController.__clearDele_EventOnOppoButtonClick);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_WorldUIController.<>f__mg$cacheA4);
		string name = "EventOnShowPlayerInfo";
		LuaCSFunction get = null;
		if (Lua_BlackJack_ProjectL_UI_WorldUIController.<>f__mg$cacheA5 == null)
		{
			Lua_BlackJack_ProjectL_UI_WorldUIController.<>f__mg$cacheA5 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_WorldUIController.set_EventOnShowPlayerInfo);
		}
		LuaObject.addMember(l, name, get, Lua_BlackJack_ProjectL_UI_WorldUIController.<>f__mg$cacheA5, true);
		string name2 = "EventOnCompass";
		LuaCSFunction get2 = null;
		if (Lua_BlackJack_ProjectL_UI_WorldUIController.<>f__mg$cacheA6 == null)
		{
			Lua_BlackJack_ProjectL_UI_WorldUIController.<>f__mg$cacheA6 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_WorldUIController.set_EventOnCompass);
		}
		LuaObject.addMember(l, name2, get2, Lua_BlackJack_ProjectL_UI_WorldUIController.<>f__mg$cacheA6, true);
		string name3 = "EventOnCurrentScenario";
		LuaCSFunction get3 = null;
		if (Lua_BlackJack_ProjectL_UI_WorldUIController.<>f__mg$cacheA7 == null)
		{
			Lua_BlackJack_ProjectL_UI_WorldUIController.<>f__mg$cacheA7 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_WorldUIController.set_EventOnCurrentScenario);
		}
		LuaObject.addMember(l, name3, get3, Lua_BlackJack_ProjectL_UI_WorldUIController.<>f__mg$cacheA7, true);
		string name4 = "EventOnShowMainButtonBar";
		LuaCSFunction get4 = null;
		if (Lua_BlackJack_ProjectL_UI_WorldUIController.<>f__mg$cacheA8 == null)
		{
			Lua_BlackJack_ProjectL_UI_WorldUIController.<>f__mg$cacheA8 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_WorldUIController.set_EventOnShowMainButtonBar);
		}
		LuaObject.addMember(l, name4, get4, Lua_BlackJack_ProjectL_UI_WorldUIController.<>f__mg$cacheA8, true);
		string name5 = "EventOnUnlockScenarioGotoRiftLevel";
		LuaCSFunction get5 = null;
		if (Lua_BlackJack_ProjectL_UI_WorldUIController.<>f__mg$cacheA9 == null)
		{
			Lua_BlackJack_ProjectL_UI_WorldUIController.<>f__mg$cacheA9 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_WorldUIController.set_EventOnUnlockScenarioGotoRiftLevel);
		}
		LuaObject.addMember(l, name5, get5, Lua_BlackJack_ProjectL_UI_WorldUIController.<>f__mg$cacheA9, true);
		string name6 = "EventOnGotoEvent";
		LuaCSFunction get6 = null;
		if (Lua_BlackJack_ProjectL_UI_WorldUIController.<>f__mg$cacheAA == null)
		{
			Lua_BlackJack_ProjectL_UI_WorldUIController.<>f__mg$cacheAA = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_WorldUIController.set_EventOnGotoEvent);
		}
		LuaObject.addMember(l, name6, get6, Lua_BlackJack_ProjectL_UI_WorldUIController.<>f__mg$cacheAA, true);
		string name7 = "EventOnStartPastScenario";
		LuaCSFunction get7 = null;
		if (Lua_BlackJack_ProjectL_UI_WorldUIController.<>f__mg$cacheAB == null)
		{
			Lua_BlackJack_ProjectL_UI_WorldUIController.<>f__mg$cacheAB = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_WorldUIController.set_EventOnStartPastScenario);
		}
		LuaObject.addMember(l, name7, get7, Lua_BlackJack_ProjectL_UI_WorldUIController.<>f__mg$cacheAB, true);
		string name8 = "EventOnClosePastScenarioList";
		LuaCSFunction get8 = null;
		if (Lua_BlackJack_ProjectL_UI_WorldUIController.<>f__mg$cacheAC == null)
		{
			Lua_BlackJack_ProjectL_UI_WorldUIController.<>f__mg$cacheAC = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_WorldUIController.set_EventOnClosePastScenarioList);
		}
		LuaObject.addMember(l, name8, get8, Lua_BlackJack_ProjectL_UI_WorldUIController.<>f__mg$cacheAC, true);
		string name9 = "EventOnShowHero";
		LuaCSFunction get9 = null;
		if (Lua_BlackJack_ProjectL_UI_WorldUIController.<>f__mg$cacheAD == null)
		{
			Lua_BlackJack_ProjectL_UI_WorldUIController.<>f__mg$cacheAD = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_WorldUIController.set_EventOnShowHero);
		}
		LuaObject.addMember(l, name9, get9, Lua_BlackJack_ProjectL_UI_WorldUIController.<>f__mg$cacheAD, true);
		string name10 = "EventOnShowBag";
		LuaCSFunction get10 = null;
		if (Lua_BlackJack_ProjectL_UI_WorldUIController.<>f__mg$cacheAE == null)
		{
			Lua_BlackJack_ProjectL_UI_WorldUIController.<>f__mg$cacheAE = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_WorldUIController.set_EventOnShowBag);
		}
		LuaObject.addMember(l, name10, get10, Lua_BlackJack_ProjectL_UI_WorldUIController.<>f__mg$cacheAE, true);
		string name11 = "EventOnShowSelectCard";
		LuaCSFunction get11 = null;
		if (Lua_BlackJack_ProjectL_UI_WorldUIController.<>f__mg$cacheAF == null)
		{
			Lua_BlackJack_ProjectL_UI_WorldUIController.<>f__mg$cacheAF = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_WorldUIController.set_EventOnShowSelectCard);
		}
		LuaObject.addMember(l, name11, get11, Lua_BlackJack_ProjectL_UI_WorldUIController.<>f__mg$cacheAF, true);
		string name12 = "EventOnShowMisision";
		LuaCSFunction get12 = null;
		if (Lua_BlackJack_ProjectL_UI_WorldUIController.<>f__mg$cacheB0 == null)
		{
			Lua_BlackJack_ProjectL_UI_WorldUIController.<>f__mg$cacheB0 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_WorldUIController.set_EventOnShowMisision);
		}
		LuaObject.addMember(l, name12, get12, Lua_BlackJack_ProjectL_UI_WorldUIController.<>f__mg$cacheB0, true);
		string name13 = "EventOnShowFetter";
		LuaCSFunction get13 = null;
		if (Lua_BlackJack_ProjectL_UI_WorldUIController.<>f__mg$cacheB1 == null)
		{
			Lua_BlackJack_ProjectL_UI_WorldUIController.<>f__mg$cacheB1 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_WorldUIController.set_EventOnShowFetter);
		}
		LuaObject.addMember(l, name13, get13, Lua_BlackJack_ProjectL_UI_WorldUIController.<>f__mg$cacheB1, true);
		string name14 = "EventOnShowStore";
		LuaCSFunction get14 = null;
		if (Lua_BlackJack_ProjectL_UI_WorldUIController.<>f__mg$cacheB2 == null)
		{
			Lua_BlackJack_ProjectL_UI_WorldUIController.<>f__mg$cacheB2 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_WorldUIController.set_EventOnShowStore);
		}
		LuaObject.addMember(l, name14, get14, Lua_BlackJack_ProjectL_UI_WorldUIController.<>f__mg$cacheB2, true);
		string name15 = "EventOnShowDrill";
		LuaCSFunction get15 = null;
		if (Lua_BlackJack_ProjectL_UI_WorldUIController.<>f__mg$cacheB3 == null)
		{
			Lua_BlackJack_ProjectL_UI_WorldUIController.<>f__mg$cacheB3 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_WorldUIController.set_EventOnShowDrill);
		}
		LuaObject.addMember(l, name15, get15, Lua_BlackJack_ProjectL_UI_WorldUIController.<>f__mg$cacheB3, true);
		string name16 = "EventOnShowFriend";
		LuaCSFunction get16 = null;
		if (Lua_BlackJack_ProjectL_UI_WorldUIController.<>f__mg$cacheB4 == null)
		{
			Lua_BlackJack_ProjectL_UI_WorldUIController.<>f__mg$cacheB4 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_WorldUIController.set_EventOnShowFriend);
		}
		LuaObject.addMember(l, name16, get16, Lua_BlackJack_ProjectL_UI_WorldUIController.<>f__mg$cacheB4, true);
		string name17 = "EventOnShowGuild";
		LuaCSFunction get17 = null;
		if (Lua_BlackJack_ProjectL_UI_WorldUIController.<>f__mg$cacheB5 == null)
		{
			Lua_BlackJack_ProjectL_UI_WorldUIController.<>f__mg$cacheB5 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_WorldUIController.set_EventOnShowGuild);
		}
		LuaObject.addMember(l, name17, get17, Lua_BlackJack_ProjectL_UI_WorldUIController.<>f__mg$cacheB5, true);
		string name18 = "EventOnShowEvent";
		LuaCSFunction get18 = null;
		if (Lua_BlackJack_ProjectL_UI_WorldUIController.<>f__mg$cacheB6 == null)
		{
			Lua_BlackJack_ProjectL_UI_WorldUIController.<>f__mg$cacheB6 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_WorldUIController.set_EventOnShowEvent);
		}
		LuaObject.addMember(l, name18, get18, Lua_BlackJack_ProjectL_UI_WorldUIController.<>f__mg$cacheB6, true);
		string name19 = "EventOnShowUncharted";
		LuaCSFunction get19 = null;
		if (Lua_BlackJack_ProjectL_UI_WorldUIController.<>f__mg$cacheB7 == null)
		{
			Lua_BlackJack_ProjectL_UI_WorldUIController.<>f__mg$cacheB7 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_WorldUIController.set_EventOnShowUncharted);
		}
		LuaObject.addMember(l, name19, get19, Lua_BlackJack_ProjectL_UI_WorldUIController.<>f__mg$cacheB7, true);
		string name20 = "EventOnShowArena";
		LuaCSFunction get20 = null;
		if (Lua_BlackJack_ProjectL_UI_WorldUIController.<>f__mg$cacheB8 == null)
		{
			Lua_BlackJack_ProjectL_UI_WorldUIController.<>f__mg$cacheB8 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_WorldUIController.set_EventOnShowArena);
		}
		LuaObject.addMember(l, name20, get20, Lua_BlackJack_ProjectL_UI_WorldUIController.<>f__mg$cacheB8, true);
		string name21 = "EventOnShowRift";
		LuaCSFunction get21 = null;
		if (Lua_BlackJack_ProjectL_UI_WorldUIController.<>f__mg$cacheB9 == null)
		{
			Lua_BlackJack_ProjectL_UI_WorldUIController.<>f__mg$cacheB9 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_WorldUIController.set_EventOnShowRift);
		}
		LuaObject.addMember(l, name21, get21, Lua_BlackJack_ProjectL_UI_WorldUIController.<>f__mg$cacheB9, true);
		string name22 = "EventOnShowTest";
		LuaCSFunction get22 = null;
		if (Lua_BlackJack_ProjectL_UI_WorldUIController.<>f__mg$cacheBA == null)
		{
			Lua_BlackJack_ProjectL_UI_WorldUIController.<>f__mg$cacheBA = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_WorldUIController.set_EventOnShowTest);
		}
		LuaObject.addMember(l, name22, get22, Lua_BlackJack_ProjectL_UI_WorldUIController.<>f__mg$cacheBA, true);
		string name23 = "EventOnShowCooperateBattle";
		LuaCSFunction get23 = null;
		if (Lua_BlackJack_ProjectL_UI_WorldUIController.<>f__mg$cacheBB == null)
		{
			Lua_BlackJack_ProjectL_UI_WorldUIController.<>f__mg$cacheBB = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_WorldUIController.set_EventOnShowCooperateBattle);
		}
		LuaObject.addMember(l, name23, get23, Lua_BlackJack_ProjectL_UI_WorldUIController.<>f__mg$cacheBB, true);
		string name24 = "EventOnShowMail";
		LuaCSFunction get24 = null;
		if (Lua_BlackJack_ProjectL_UI_WorldUIController.<>f__mg$cacheBC == null)
		{
			Lua_BlackJack_ProjectL_UI_WorldUIController.<>f__mg$cacheBC = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_WorldUIController.set_EventOnShowMail);
		}
		LuaObject.addMember(l, name24, get24, Lua_BlackJack_ProjectL_UI_WorldUIController.<>f__mg$cacheBC, true);
		string name25 = "EventOnShowChat";
		LuaCSFunction get25 = null;
		if (Lua_BlackJack_ProjectL_UI_WorldUIController.<>f__mg$cacheBD == null)
		{
			Lua_BlackJack_ProjectL_UI_WorldUIController.<>f__mg$cacheBD = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_WorldUIController.set_EventOnShowChat);
		}
		LuaObject.addMember(l, name25, get25, Lua_BlackJack_ProjectL_UI_WorldUIController.<>f__mg$cacheBD, true);
		string name26 = "EventOnShowRanking";
		LuaCSFunction get26 = null;
		if (Lua_BlackJack_ProjectL_UI_WorldUIController.<>f__mg$cacheBE == null)
		{
			Lua_BlackJack_ProjectL_UI_WorldUIController.<>f__mg$cacheBE = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_WorldUIController.set_EventOnShowRanking);
		}
		LuaObject.addMember(l, name26, get26, Lua_BlackJack_ProjectL_UI_WorldUIController.<>f__mg$cacheBE, true);
		string name27 = "EventOnShowAnnouncement";
		LuaCSFunction get27 = null;
		if (Lua_BlackJack_ProjectL_UI_WorldUIController.<>f__mg$cacheBF == null)
		{
			Lua_BlackJack_ProjectL_UI_WorldUIController.<>f__mg$cacheBF = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_WorldUIController.set_EventOnShowAnnouncement);
		}
		LuaObject.addMember(l, name27, get27, Lua_BlackJack_ProjectL_UI_WorldUIController.<>f__mg$cacheBF, true);
		string name28 = "EventOnOpenWebInvestigation";
		LuaCSFunction get28 = null;
		if (Lua_BlackJack_ProjectL_UI_WorldUIController.<>f__mg$cacheC0 == null)
		{
			Lua_BlackJack_ProjectL_UI_WorldUIController.<>f__mg$cacheC0 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_WorldUIController.set_EventOnOpenWebInvestigation);
		}
		LuaObject.addMember(l, name28, get28, Lua_BlackJack_ProjectL_UI_WorldUIController.<>f__mg$cacheC0, true);
		string name29 = "EventOnShowOpenServiceActivity";
		LuaCSFunction get29 = null;
		if (Lua_BlackJack_ProjectL_UI_WorldUIController.<>f__mg$cacheC1 == null)
		{
			Lua_BlackJack_ProjectL_UI_WorldUIController.<>f__mg$cacheC1 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_WorldUIController.set_EventOnShowOpenServiceActivity);
		}
		LuaObject.addMember(l, name29, get29, Lua_BlackJack_ProjectL_UI_WorldUIController.<>f__mg$cacheC1, true);
		string name30 = "EventOnMonthCardButtonClick";
		LuaCSFunction get30 = null;
		if (Lua_BlackJack_ProjectL_UI_WorldUIController.<>f__mg$cacheC2 == null)
		{
			Lua_BlackJack_ProjectL_UI_WorldUIController.<>f__mg$cacheC2 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_WorldUIController.set_EventOnMonthCardButtonClick);
		}
		LuaObject.addMember(l, name30, get30, Lua_BlackJack_ProjectL_UI_WorldUIController.<>f__mg$cacheC2, true);
		string name31 = "EventOnRefreshMonthCardPanel";
		LuaCSFunction get31 = null;
		if (Lua_BlackJack_ProjectL_UI_WorldUIController.<>f__mg$cacheC3 == null)
		{
			Lua_BlackJack_ProjectL_UI_WorldUIController.<>f__mg$cacheC3 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_WorldUIController.set_EventOnRefreshMonthCardPanel);
		}
		LuaObject.addMember(l, name31, get31, Lua_BlackJack_ProjectL_UI_WorldUIController.<>f__mg$cacheC3, true);
		string name32 = "EventOnMonthCardItemClick";
		LuaCSFunction get32 = null;
		if (Lua_BlackJack_ProjectL_UI_WorldUIController.<>f__mg$cacheC4 == null)
		{
			Lua_BlackJack_ProjectL_UI_WorldUIController.<>f__mg$cacheC4 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_WorldUIController.set_EventOnMonthCardItemClick);
		}
		LuaObject.addMember(l, name32, get32, Lua_BlackJack_ProjectL_UI_WorldUIController.<>f__mg$cacheC4, true);
		string name33 = "EventOnMonthCardItemBuyClick";
		LuaCSFunction get33 = null;
		if (Lua_BlackJack_ProjectL_UI_WorldUIController.<>f__mg$cacheC5 == null)
		{
			Lua_BlackJack_ProjectL_UI_WorldUIController.<>f__mg$cacheC5 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_WorldUIController.set_EventOnMonthCardItemBuyClick);
		}
		LuaObject.addMember(l, name33, get33, Lua_BlackJack_ProjectL_UI_WorldUIController.<>f__mg$cacheC5, true);
		string name34 = "EventOnYYBButtonClick";
		LuaCSFunction get34 = null;
		if (Lua_BlackJack_ProjectL_UI_WorldUIController.<>f__mg$cacheC6 == null)
		{
			Lua_BlackJack_ProjectL_UI_WorldUIController.<>f__mg$cacheC6 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_WorldUIController.set_EventOnYYBButtonClick);
		}
		LuaObject.addMember(l, name34, get34, Lua_BlackJack_ProjectL_UI_WorldUIController.<>f__mg$cacheC6, true);
		string name35 = "EventOnOppoButtonClick";
		LuaCSFunction get35 = null;
		if (Lua_BlackJack_ProjectL_UI_WorldUIController.<>f__mg$cacheC7 == null)
		{
			Lua_BlackJack_ProjectL_UI_WorldUIController.<>f__mg$cacheC7 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_WorldUIController.set_EventOnOppoButtonClick);
		}
		LuaObject.addMember(l, name35, get35, Lua_BlackJack_ProjectL_UI_WorldUIController.<>f__mg$cacheC7, true);
		string name36 = "m_uiStateController";
		if (Lua_BlackJack_ProjectL_UI_WorldUIController.<>f__mg$cacheC8 == null)
		{
			Lua_BlackJack_ProjectL_UI_WorldUIController.<>f__mg$cacheC8 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_WorldUIController.get_m_uiStateController);
		}
		LuaCSFunction get36 = Lua_BlackJack_ProjectL_UI_WorldUIController.<>f__mg$cacheC8;
		if (Lua_BlackJack_ProjectL_UI_WorldUIController.<>f__mg$cacheC9 == null)
		{
			Lua_BlackJack_ProjectL_UI_WorldUIController.<>f__mg$cacheC9 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_WorldUIController.set_m_uiStateController);
		}
		LuaObject.addMember(l, name36, get36, Lua_BlackJack_ProjectL_UI_WorldUIController.<>f__mg$cacheC9, true);
		string name37 = "m_fogImage";
		if (Lua_BlackJack_ProjectL_UI_WorldUIController.<>f__mg$cacheCA == null)
		{
			Lua_BlackJack_ProjectL_UI_WorldUIController.<>f__mg$cacheCA = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_WorldUIController.get_m_fogImage);
		}
		LuaCSFunction get37 = Lua_BlackJack_ProjectL_UI_WorldUIController.<>f__mg$cacheCA;
		if (Lua_BlackJack_ProjectL_UI_WorldUIController.<>f__mg$cacheCB == null)
		{
			Lua_BlackJack_ProjectL_UI_WorldUIController.<>f__mg$cacheCB = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_WorldUIController.set_m_fogImage);
		}
		LuaObject.addMember(l, name37, get37, Lua_BlackJack_ProjectL_UI_WorldUIController.<>f__mg$cacheCB, true);
		string name38 = "m_playerButton";
		if (Lua_BlackJack_ProjectL_UI_WorldUIController.<>f__mg$cacheCC == null)
		{
			Lua_BlackJack_ProjectL_UI_WorldUIController.<>f__mg$cacheCC = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_WorldUIController.get_m_playerButton);
		}
		LuaCSFunction get38 = Lua_BlackJack_ProjectL_UI_WorldUIController.<>f__mg$cacheCC;
		if (Lua_BlackJack_ProjectL_UI_WorldUIController.<>f__mg$cacheCD == null)
		{
			Lua_BlackJack_ProjectL_UI_WorldUIController.<>f__mg$cacheCD = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_WorldUIController.set_m_playerButton);
		}
		LuaObject.addMember(l, name38, get38, Lua_BlackJack_ProjectL_UI_WorldUIController.<>f__mg$cacheCD, true);
		string name39 = "m_playerNameText";
		if (Lua_BlackJack_ProjectL_UI_WorldUIController.<>f__mg$cacheCE == null)
		{
			Lua_BlackJack_ProjectL_UI_WorldUIController.<>f__mg$cacheCE = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_WorldUIController.get_m_playerNameText);
		}
		LuaCSFunction get39 = Lua_BlackJack_ProjectL_UI_WorldUIController.<>f__mg$cacheCE;
		if (Lua_BlackJack_ProjectL_UI_WorldUIController.<>f__mg$cacheCF == null)
		{
			Lua_BlackJack_ProjectL_UI_WorldUIController.<>f__mg$cacheCF = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_WorldUIController.set_m_playerNameText);
		}
		LuaObject.addMember(l, name39, get39, Lua_BlackJack_ProjectL_UI_WorldUIController.<>f__mg$cacheCF, true);
		string name40 = "m_playerLevelText";
		if (Lua_BlackJack_ProjectL_UI_WorldUIController.<>f__mg$cacheD0 == null)
		{
			Lua_BlackJack_ProjectL_UI_WorldUIController.<>f__mg$cacheD0 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_WorldUIController.get_m_playerLevelText);
		}
		LuaCSFunction get40 = Lua_BlackJack_ProjectL_UI_WorldUIController.<>f__mg$cacheD0;
		if (Lua_BlackJack_ProjectL_UI_WorldUIController.<>f__mg$cacheD1 == null)
		{
			Lua_BlackJack_ProjectL_UI_WorldUIController.<>f__mg$cacheD1 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_WorldUIController.set_m_playerLevelText);
		}
		LuaObject.addMember(l, name40, get40, Lua_BlackJack_ProjectL_UI_WorldUIController.<>f__mg$cacheD1, true);
		string name41 = "m_playerVipText";
		if (Lua_BlackJack_ProjectL_UI_WorldUIController.<>f__mg$cacheD2 == null)
		{
			Lua_BlackJack_ProjectL_UI_WorldUIController.<>f__mg$cacheD2 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_WorldUIController.get_m_playerVipText);
		}
		LuaCSFunction get41 = Lua_BlackJack_ProjectL_UI_WorldUIController.<>f__mg$cacheD2;
		if (Lua_BlackJack_ProjectL_UI_WorldUIController.<>f__mg$cacheD3 == null)
		{
			Lua_BlackJack_ProjectL_UI_WorldUIController.<>f__mg$cacheD3 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_WorldUIController.set_m_playerVipText);
		}
		LuaObject.addMember(l, name41, get41, Lua_BlackJack_ProjectL_UI_WorldUIController.<>f__mg$cacheD3, true);
		string name42 = "m_playerExpText";
		if (Lua_BlackJack_ProjectL_UI_WorldUIController.<>f__mg$cacheD4 == null)
		{
			Lua_BlackJack_ProjectL_UI_WorldUIController.<>f__mg$cacheD4 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_WorldUIController.get_m_playerExpText);
		}
		LuaCSFunction get42 = Lua_BlackJack_ProjectL_UI_WorldUIController.<>f__mg$cacheD4;
		if (Lua_BlackJack_ProjectL_UI_WorldUIController.<>f__mg$cacheD5 == null)
		{
			Lua_BlackJack_ProjectL_UI_WorldUIController.<>f__mg$cacheD5 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_WorldUIController.set_m_playerExpText);
		}
		LuaObject.addMember(l, name42, get42, Lua_BlackJack_ProjectL_UI_WorldUIController.<>f__mg$cacheD5, true);
		string name43 = "m_playerExpImage";
		if (Lua_BlackJack_ProjectL_UI_WorldUIController.<>f__mg$cacheD6 == null)
		{
			Lua_BlackJack_ProjectL_UI_WorldUIController.<>f__mg$cacheD6 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_WorldUIController.get_m_playerExpImage);
		}
		LuaCSFunction get43 = Lua_BlackJack_ProjectL_UI_WorldUIController.<>f__mg$cacheD6;
		if (Lua_BlackJack_ProjectL_UI_WorldUIController.<>f__mg$cacheD7 == null)
		{
			Lua_BlackJack_ProjectL_UI_WorldUIController.<>f__mg$cacheD7 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_WorldUIController.set_m_playerExpImage);
		}
		LuaObject.addMember(l, name43, get43, Lua_BlackJack_ProjectL_UI_WorldUIController.<>f__mg$cacheD7, true);
		string name44 = "m_playerIconImage";
		if (Lua_BlackJack_ProjectL_UI_WorldUIController.<>f__mg$cacheD8 == null)
		{
			Lua_BlackJack_ProjectL_UI_WorldUIController.<>f__mg$cacheD8 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_WorldUIController.get_m_playerIconImage);
		}
		LuaCSFunction get44 = Lua_BlackJack_ProjectL_UI_WorldUIController.<>f__mg$cacheD8;
		if (Lua_BlackJack_ProjectL_UI_WorldUIController.<>f__mg$cacheD9 == null)
		{
			Lua_BlackJack_ProjectL_UI_WorldUIController.<>f__mg$cacheD9 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_WorldUIController.set_m_playerIconImage);
		}
		LuaObject.addMember(l, name44, get44, Lua_BlackJack_ProjectL_UI_WorldUIController.<>f__mg$cacheD9, true);
		string name45 = "m_compassButton";
		if (Lua_BlackJack_ProjectL_UI_WorldUIController.<>f__mg$cacheDA == null)
		{
			Lua_BlackJack_ProjectL_UI_WorldUIController.<>f__mg$cacheDA = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_WorldUIController.get_m_compassButton);
		}
		LuaCSFunction get45 = Lua_BlackJack_ProjectL_UI_WorldUIController.<>f__mg$cacheDA;
		if (Lua_BlackJack_ProjectL_UI_WorldUIController.<>f__mg$cacheDB == null)
		{
			Lua_BlackJack_ProjectL_UI_WorldUIController.<>f__mg$cacheDB = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_WorldUIController.set_m_compassButton);
		}
		LuaObject.addMember(l, name45, get45, Lua_BlackJack_ProjectL_UI_WorldUIController.<>f__mg$cacheDB, true);
		string name46 = "m_currentScenarioButton";
		if (Lua_BlackJack_ProjectL_UI_WorldUIController.<>f__mg$cacheDC == null)
		{
			Lua_BlackJack_ProjectL_UI_WorldUIController.<>f__mg$cacheDC = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_WorldUIController.get_m_currentScenarioButton);
		}
		LuaCSFunction get46 = Lua_BlackJack_ProjectL_UI_WorldUIController.<>f__mg$cacheDC;
		if (Lua_BlackJack_ProjectL_UI_WorldUIController.<>f__mg$cacheDD == null)
		{
			Lua_BlackJack_ProjectL_UI_WorldUIController.<>f__mg$cacheDD = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_WorldUIController.set_m_currentScenarioButton);
		}
		LuaObject.addMember(l, name46, get46, Lua_BlackJack_ProjectL_UI_WorldUIController.<>f__mg$cacheDD, true);
		string name47 = "m_currentScenarioNameText";
		if (Lua_BlackJack_ProjectL_UI_WorldUIController.<>f__mg$cacheDE == null)
		{
			Lua_BlackJack_ProjectL_UI_WorldUIController.<>f__mg$cacheDE = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_WorldUIController.get_m_currentScenarioNameText);
		}
		LuaCSFunction get47 = Lua_BlackJack_ProjectL_UI_WorldUIController.<>f__mg$cacheDE;
		if (Lua_BlackJack_ProjectL_UI_WorldUIController.<>f__mg$cacheDF == null)
		{
			Lua_BlackJack_ProjectL_UI_WorldUIController.<>f__mg$cacheDF = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_WorldUIController.set_m_currentScenarioNameText);
		}
		LuaObject.addMember(l, name47, get47, Lua_BlackJack_ProjectL_UI_WorldUIController.<>f__mg$cacheDF, true);
		string name48 = "m_newScenarioUIStateController";
		if (Lua_BlackJack_ProjectL_UI_WorldUIController.<>f__mg$cacheE0 == null)
		{
			Lua_BlackJack_ProjectL_UI_WorldUIController.<>f__mg$cacheE0 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_WorldUIController.get_m_newScenarioUIStateController);
		}
		LuaCSFunction get48 = Lua_BlackJack_ProjectL_UI_WorldUIController.<>f__mg$cacheE0;
		if (Lua_BlackJack_ProjectL_UI_WorldUIController.<>f__mg$cacheE1 == null)
		{
			Lua_BlackJack_ProjectL_UI_WorldUIController.<>f__mg$cacheE1 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_WorldUIController.set_m_newScenarioUIStateController);
		}
		LuaObject.addMember(l, name48, get48, Lua_BlackJack_ProjectL_UI_WorldUIController.<>f__mg$cacheE1, true);
		string name49 = "m_newScenarioNameText";
		if (Lua_BlackJack_ProjectL_UI_WorldUIController.<>f__mg$cacheE2 == null)
		{
			Lua_BlackJack_ProjectL_UI_WorldUIController.<>f__mg$cacheE2 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_WorldUIController.get_m_newScenarioNameText);
		}
		LuaCSFunction get49 = Lua_BlackJack_ProjectL_UI_WorldUIController.<>f__mg$cacheE2;
		if (Lua_BlackJack_ProjectL_UI_WorldUIController.<>f__mg$cacheE3 == null)
		{
			Lua_BlackJack_ProjectL_UI_WorldUIController.<>f__mg$cacheE3 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_WorldUIController.set_m_newScenarioNameText);
		}
		LuaObject.addMember(l, name49, get49, Lua_BlackJack_ProjectL_UI_WorldUIController.<>f__mg$cacheE3, true);
		string name50 = "m_enterScenarioUIStateController";
		if (Lua_BlackJack_ProjectL_UI_WorldUIController.<>f__mg$cacheE4 == null)
		{
			Lua_BlackJack_ProjectL_UI_WorldUIController.<>f__mg$cacheE4 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_WorldUIController.get_m_enterScenarioUIStateController);
		}
		LuaCSFunction get50 = Lua_BlackJack_ProjectL_UI_WorldUIController.<>f__mg$cacheE4;
		if (Lua_BlackJack_ProjectL_UI_WorldUIController.<>f__mg$cacheE5 == null)
		{
			Lua_BlackJack_ProjectL_UI_WorldUIController.<>f__mg$cacheE5 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_WorldUIController.set_m_enterScenarioUIStateController);
		}
		LuaObject.addMember(l, name50, get50, Lua_BlackJack_ProjectL_UI_WorldUIController.<>f__mg$cacheE5, true);
		string name51 = "m_enterScenarioChapterText";
		if (Lua_BlackJack_ProjectL_UI_WorldUIController.<>f__mg$cacheE6 == null)
		{
			Lua_BlackJack_ProjectL_UI_WorldUIController.<>f__mg$cacheE6 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_WorldUIController.get_m_enterScenarioChapterText);
		}
		LuaCSFunction get51 = Lua_BlackJack_ProjectL_UI_WorldUIController.<>f__mg$cacheE6;
		if (Lua_BlackJack_ProjectL_UI_WorldUIController.<>f__mg$cacheE7 == null)
		{
			Lua_BlackJack_ProjectL_UI_WorldUIController.<>f__mg$cacheE7 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_WorldUIController.set_m_enterScenarioChapterText);
		}
		LuaObject.addMember(l, name51, get51, Lua_BlackJack_ProjectL_UI_WorldUIController.<>f__mg$cacheE7, true);
		string name52 = "m_enterScenarioNameText";
		if (Lua_BlackJack_ProjectL_UI_WorldUIController.<>f__mg$cacheE8 == null)
		{
			Lua_BlackJack_ProjectL_UI_WorldUIController.<>f__mg$cacheE8 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_WorldUIController.get_m_enterScenarioNameText);
		}
		LuaCSFunction get52 = Lua_BlackJack_ProjectL_UI_WorldUIController.<>f__mg$cacheE8;
		if (Lua_BlackJack_ProjectL_UI_WorldUIController.<>f__mg$cacheE9 == null)
		{
			Lua_BlackJack_ProjectL_UI_WorldUIController.<>f__mg$cacheE9 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_WorldUIController.set_m_enterScenarioNameText);
		}
		LuaObject.addMember(l, name52, get52, Lua_BlackJack_ProjectL_UI_WorldUIController.<>f__mg$cacheE9, true);
		string name53 = "m_enterMonsterUIStateController";
		if (Lua_BlackJack_ProjectL_UI_WorldUIController.<>f__mg$cacheEA == null)
		{
			Lua_BlackJack_ProjectL_UI_WorldUIController.<>f__mg$cacheEA = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_WorldUIController.get_m_enterMonsterUIStateController);
		}
		LuaCSFunction get53 = Lua_BlackJack_ProjectL_UI_WorldUIController.<>f__mg$cacheEA;
		if (Lua_BlackJack_ProjectL_UI_WorldUIController.<>f__mg$cacheEB == null)
		{
			Lua_BlackJack_ProjectL_UI_WorldUIController.<>f__mg$cacheEB = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_WorldUIController.set_m_enterMonsterUIStateController);
		}
		LuaObject.addMember(l, name53, get53, Lua_BlackJack_ProjectL_UI_WorldUIController.<>f__mg$cacheEB, true);
		string name54 = "m_eventListTransform";
		if (Lua_BlackJack_ProjectL_UI_WorldUIController.<>f__mg$cacheEC == null)
		{
			Lua_BlackJack_ProjectL_UI_WorldUIController.<>f__mg$cacheEC = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_WorldUIController.get_m_eventListTransform);
		}
		LuaCSFunction get54 = Lua_BlackJack_ProjectL_UI_WorldUIController.<>f__mg$cacheEC;
		if (Lua_BlackJack_ProjectL_UI_WorldUIController.<>f__mg$cacheED == null)
		{
			Lua_BlackJack_ProjectL_UI_WorldUIController.<>f__mg$cacheED = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_WorldUIController.set_m_eventListTransform);
		}
		LuaObject.addMember(l, name54, get54, Lua_BlackJack_ProjectL_UI_WorldUIController.<>f__mg$cacheED, true);
		string name55 = "m_eventListUIStateController";
		if (Lua_BlackJack_ProjectL_UI_WorldUIController.<>f__mg$cacheEE == null)
		{
			Lua_BlackJack_ProjectL_UI_WorldUIController.<>f__mg$cacheEE = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_WorldUIController.get_m_eventListUIStateController);
		}
		LuaCSFunction get55 = Lua_BlackJack_ProjectL_UI_WorldUIController.<>f__mg$cacheEE;
		if (Lua_BlackJack_ProjectL_UI_WorldUIController.<>f__mg$cacheEF == null)
		{
			Lua_BlackJack_ProjectL_UI_WorldUIController.<>f__mg$cacheEF = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_WorldUIController.set_m_eventListUIStateController);
		}
		LuaObject.addMember(l, name55, get55, Lua_BlackJack_ProjectL_UI_WorldUIController.<>f__mg$cacheEF, true);
		string name56 = "m_randomEventScrollRect";
		if (Lua_BlackJack_ProjectL_UI_WorldUIController.<>f__mg$cacheF0 == null)
		{
			Lua_BlackJack_ProjectL_UI_WorldUIController.<>f__mg$cacheF0 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_WorldUIController.get_m_randomEventScrollRect);
		}
		LuaCSFunction get56 = Lua_BlackJack_ProjectL_UI_WorldUIController.<>f__mg$cacheF0;
		if (Lua_BlackJack_ProjectL_UI_WorldUIController.<>f__mg$cacheF1 == null)
		{
			Lua_BlackJack_ProjectL_UI_WorldUIController.<>f__mg$cacheF1 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_WorldUIController.set_m_randomEventScrollRect);
		}
		LuaObject.addMember(l, name56, get56, Lua_BlackJack_ProjectL_UI_WorldUIController.<>f__mg$cacheF1, true);
		string name57 = "m_eventListBackgroundButton";
		if (Lua_BlackJack_ProjectL_UI_WorldUIController.<>f__mg$cacheF2 == null)
		{
			Lua_BlackJack_ProjectL_UI_WorldUIController.<>f__mg$cacheF2 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_WorldUIController.get_m_eventListBackgroundButton);
		}
		LuaCSFunction get57 = Lua_BlackJack_ProjectL_UI_WorldUIController.<>f__mg$cacheF2;
		if (Lua_BlackJack_ProjectL_UI_WorldUIController.<>f__mg$cacheF3 == null)
		{
			Lua_BlackJack_ProjectL_UI_WorldUIController.<>f__mg$cacheF3 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_WorldUIController.set_m_eventListBackgroundButton);
		}
		LuaObject.addMember(l, name57, get57, Lua_BlackJack_ProjectL_UI_WorldUIController.<>f__mg$cacheF3, true);
		string name58 = "m_pastScenarioListUIStateController";
		if (Lua_BlackJack_ProjectL_UI_WorldUIController.<>f__mg$cacheF4 == null)
		{
			Lua_BlackJack_ProjectL_UI_WorldUIController.<>f__mg$cacheF4 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_WorldUIController.get_m_pastScenarioListUIStateController);
		}
		LuaCSFunction get58 = Lua_BlackJack_ProjectL_UI_WorldUIController.<>f__mg$cacheF4;
		if (Lua_BlackJack_ProjectL_UI_WorldUIController.<>f__mg$cacheF5 == null)
		{
			Lua_BlackJack_ProjectL_UI_WorldUIController.<>f__mg$cacheF5 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_WorldUIController.set_m_pastScenarioListUIStateController);
		}
		LuaObject.addMember(l, name58, get58, Lua_BlackJack_ProjectL_UI_WorldUIController.<>f__mg$cacheF5, true);
		string name59 = "m_pastScenarioListBackgroundButton";
		if (Lua_BlackJack_ProjectL_UI_WorldUIController.<>f__mg$cacheF6 == null)
		{
			Lua_BlackJack_ProjectL_UI_WorldUIController.<>f__mg$cacheF6 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_WorldUIController.get_m_pastScenarioListBackgroundButton);
		}
		LuaCSFunction get59 = Lua_BlackJack_ProjectL_UI_WorldUIController.<>f__mg$cacheF6;
		if (Lua_BlackJack_ProjectL_UI_WorldUIController.<>f__mg$cacheF7 == null)
		{
			Lua_BlackJack_ProjectL_UI_WorldUIController.<>f__mg$cacheF7 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_WorldUIController.set_m_pastScenarioListBackgroundButton);
		}
		LuaObject.addMember(l, name59, get59, Lua_BlackJack_ProjectL_UI_WorldUIController.<>f__mg$cacheF7, true);
		string name60 = "m_pastScenarioListScrollRect";
		if (Lua_BlackJack_ProjectL_UI_WorldUIController.<>f__mg$cacheF8 == null)
		{
			Lua_BlackJack_ProjectL_UI_WorldUIController.<>f__mg$cacheF8 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_WorldUIController.get_m_pastScenarioListScrollRect);
		}
		LuaCSFunction get60 = Lua_BlackJack_ProjectL_UI_WorldUIController.<>f__mg$cacheF8;
		if (Lua_BlackJack_ProjectL_UI_WorldUIController.<>f__mg$cacheF9 == null)
		{
			Lua_BlackJack_ProjectL_UI_WorldUIController.<>f__mg$cacheF9 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_WorldUIController.set_m_pastScenarioListScrollRect);
		}
		LuaObject.addMember(l, name60, get60, Lua_BlackJack_ProjectL_UI_WorldUIController.<>f__mg$cacheF9, true);
		string name61 = "m_unlockScenarioUIStateController";
		if (Lua_BlackJack_ProjectL_UI_WorldUIController.<>f__mg$cacheFA == null)
		{
			Lua_BlackJack_ProjectL_UI_WorldUIController.<>f__mg$cacheFA = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_WorldUIController.get_m_unlockScenarioUIStateController);
		}
		LuaCSFunction get61 = Lua_BlackJack_ProjectL_UI_WorldUIController.<>f__mg$cacheFA;
		if (Lua_BlackJack_ProjectL_UI_WorldUIController.<>f__mg$cacheFB == null)
		{
			Lua_BlackJack_ProjectL_UI_WorldUIController.<>f__mg$cacheFB = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_WorldUIController.set_m_unlockScenarioUIStateController);
		}
		LuaObject.addMember(l, name61, get61, Lua_BlackJack_ProjectL_UI_WorldUIController.<>f__mg$cacheFB, true);
		string name62 = "m_unlockScenarioBackgroundButton";
		if (Lua_BlackJack_ProjectL_UI_WorldUIController.<>f__mg$cacheFC == null)
		{
			Lua_BlackJack_ProjectL_UI_WorldUIController.<>f__mg$cacheFC = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_WorldUIController.get_m_unlockScenarioBackgroundButton);
		}
		LuaCSFunction get62 = Lua_BlackJack_ProjectL_UI_WorldUIController.<>f__mg$cacheFC;
		if (Lua_BlackJack_ProjectL_UI_WorldUIController.<>f__mg$cacheFD == null)
		{
			Lua_BlackJack_ProjectL_UI_WorldUIController.<>f__mg$cacheFD = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_WorldUIController.set_m_unlockScenarioBackgroundButton);
		}
		LuaObject.addMember(l, name62, get62, Lua_BlackJack_ProjectL_UI_WorldUIController.<>f__mg$cacheFD, true);
		string name63 = "m_unlockScenarioTitleText";
		if (Lua_BlackJack_ProjectL_UI_WorldUIController.<>f__mg$cacheFE == null)
		{
			Lua_BlackJack_ProjectL_UI_WorldUIController.<>f__mg$cacheFE = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_WorldUIController.get_m_unlockScenarioTitleText);
		}
		LuaCSFunction get63 = Lua_BlackJack_ProjectL_UI_WorldUIController.<>f__mg$cacheFE;
		if (Lua_BlackJack_ProjectL_UI_WorldUIController.<>f__mg$cacheFF == null)
		{
			Lua_BlackJack_ProjectL_UI_WorldUIController.<>f__mg$cacheFF = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_WorldUIController.set_m_unlockScenarioTitleText);
		}
		LuaObject.addMember(l, name63, get63, Lua_BlackJack_ProjectL_UI_WorldUIController.<>f__mg$cacheFF, true);
		string name64 = "m_unlockScenarioText";
		if (Lua_BlackJack_ProjectL_UI_WorldUIController.<>f__mg$cache100 == null)
		{
			Lua_BlackJack_ProjectL_UI_WorldUIController.<>f__mg$cache100 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_WorldUIController.get_m_unlockScenarioText);
		}
		LuaCSFunction get64 = Lua_BlackJack_ProjectL_UI_WorldUIController.<>f__mg$cache100;
		if (Lua_BlackJack_ProjectL_UI_WorldUIController.<>f__mg$cache101 == null)
		{
			Lua_BlackJack_ProjectL_UI_WorldUIController.<>f__mg$cache101 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_WorldUIController.set_m_unlockScenarioText);
		}
		LuaObject.addMember(l, name64, get64, Lua_BlackJack_ProjectL_UI_WorldUIController.<>f__mg$cache101, true);
		string name65 = "m_unlockScenarioGotoButton";
		if (Lua_BlackJack_ProjectL_UI_WorldUIController.<>f__mg$cache102 == null)
		{
			Lua_BlackJack_ProjectL_UI_WorldUIController.<>f__mg$cache102 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_WorldUIController.get_m_unlockScenarioGotoButton);
		}
		LuaCSFunction get65 = Lua_BlackJack_ProjectL_UI_WorldUIController.<>f__mg$cache102;
		if (Lua_BlackJack_ProjectL_UI_WorldUIController.<>f__mg$cache103 == null)
		{
			Lua_BlackJack_ProjectL_UI_WorldUIController.<>f__mg$cache103 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_WorldUIController.set_m_unlockScenarioGotoButton);
		}
		LuaObject.addMember(l, name65, get65, Lua_BlackJack_ProjectL_UI_WorldUIController.<>f__mg$cache103, true);
		string name66 = "m_mainButton";
		if (Lua_BlackJack_ProjectL_UI_WorldUIController.<>f__mg$cache104 == null)
		{
			Lua_BlackJack_ProjectL_UI_WorldUIController.<>f__mg$cache104 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_WorldUIController.get_m_mainButton);
		}
		LuaCSFunction get66 = Lua_BlackJack_ProjectL_UI_WorldUIController.<>f__mg$cache104;
		if (Lua_BlackJack_ProjectL_UI_WorldUIController.<>f__mg$cache105 == null)
		{
			Lua_BlackJack_ProjectL_UI_WorldUIController.<>f__mg$cache105 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_WorldUIController.set_m_mainButton);
		}
		LuaObject.addMember(l, name66, get66, Lua_BlackJack_ProjectL_UI_WorldUIController.<>f__mg$cache105, true);
		string name67 = "m_mainButtonOnGameObject";
		if (Lua_BlackJack_ProjectL_UI_WorldUIController.<>f__mg$cache106 == null)
		{
			Lua_BlackJack_ProjectL_UI_WorldUIController.<>f__mg$cache106 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_WorldUIController.get_m_mainButtonOnGameObject);
		}
		LuaCSFunction get67 = Lua_BlackJack_ProjectL_UI_WorldUIController.<>f__mg$cache106;
		if (Lua_BlackJack_ProjectL_UI_WorldUIController.<>f__mg$cache107 == null)
		{
			Lua_BlackJack_ProjectL_UI_WorldUIController.<>f__mg$cache107 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_WorldUIController.set_m_mainButtonOnGameObject);
		}
		LuaObject.addMember(l, name67, get67, Lua_BlackJack_ProjectL_UI_WorldUIController.<>f__mg$cache107, true);
		string name68 = "m_mainButtonOffGameObject";
		if (Lua_BlackJack_ProjectL_UI_WorldUIController.<>f__mg$cache108 == null)
		{
			Lua_BlackJack_ProjectL_UI_WorldUIController.<>f__mg$cache108 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_WorldUIController.get_m_mainButtonOffGameObject);
		}
		LuaCSFunction get68 = Lua_BlackJack_ProjectL_UI_WorldUIController.<>f__mg$cache108;
		if (Lua_BlackJack_ProjectL_UI_WorldUIController.<>f__mg$cache109 == null)
		{
			Lua_BlackJack_ProjectL_UI_WorldUIController.<>f__mg$cache109 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_WorldUIController.set_m_mainButtonOffGameObject);
		}
		LuaObject.addMember(l, name68, get68, Lua_BlackJack_ProjectL_UI_WorldUIController.<>f__mg$cache109, true);
		string name69 = "m_margin1Transform";
		if (Lua_BlackJack_ProjectL_UI_WorldUIController.<>f__mg$cache10A == null)
		{
			Lua_BlackJack_ProjectL_UI_WorldUIController.<>f__mg$cache10A = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_WorldUIController.get_m_margin1Transform);
		}
		LuaCSFunction get69 = Lua_BlackJack_ProjectL_UI_WorldUIController.<>f__mg$cache10A;
		if (Lua_BlackJack_ProjectL_UI_WorldUIController.<>f__mg$cache10B == null)
		{
			Lua_BlackJack_ProjectL_UI_WorldUIController.<>f__mg$cache10B = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_WorldUIController.set_m_margin1Transform);
		}
		LuaObject.addMember(l, name69, get69, Lua_BlackJack_ProjectL_UI_WorldUIController.<>f__mg$cache10B, true);
		string name70 = "m_mainButtonBarUIStateController";
		if (Lua_BlackJack_ProjectL_UI_WorldUIController.<>f__mg$cache10C == null)
		{
			Lua_BlackJack_ProjectL_UI_WorldUIController.<>f__mg$cache10C = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_WorldUIController.get_m_mainButtonBarUIStateController);
		}
		LuaCSFunction get70 = Lua_BlackJack_ProjectL_UI_WorldUIController.<>f__mg$cache10C;
		if (Lua_BlackJack_ProjectL_UI_WorldUIController.<>f__mg$cache10D == null)
		{
			Lua_BlackJack_ProjectL_UI_WorldUIController.<>f__mg$cache10D = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_WorldUIController.set_m_mainButtonBarUIStateController);
		}
		LuaObject.addMember(l, name70, get70, Lua_BlackJack_ProjectL_UI_WorldUIController.<>f__mg$cache10D, true);
		string name71 = "m_heroButton";
		if (Lua_BlackJack_ProjectL_UI_WorldUIController.<>f__mg$cache10E == null)
		{
			Lua_BlackJack_ProjectL_UI_WorldUIController.<>f__mg$cache10E = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_WorldUIController.get_m_heroButton);
		}
		LuaCSFunction get71 = Lua_BlackJack_ProjectL_UI_WorldUIController.<>f__mg$cache10E;
		if (Lua_BlackJack_ProjectL_UI_WorldUIController.<>f__mg$cache10F == null)
		{
			Lua_BlackJack_ProjectL_UI_WorldUIController.<>f__mg$cache10F = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_WorldUIController.set_m_heroButton);
		}
		LuaObject.addMember(l, name71, get71, Lua_BlackJack_ProjectL_UI_WorldUIController.<>f__mg$cache10F, true);
		string name72 = "m_heroButtonRedMarkGameObject";
		if (Lua_BlackJack_ProjectL_UI_WorldUIController.<>f__mg$cache110 == null)
		{
			Lua_BlackJack_ProjectL_UI_WorldUIController.<>f__mg$cache110 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_WorldUIController.get_m_heroButtonRedMarkGameObject);
		}
		LuaCSFunction get72 = Lua_BlackJack_ProjectL_UI_WorldUIController.<>f__mg$cache110;
		if (Lua_BlackJack_ProjectL_UI_WorldUIController.<>f__mg$cache111 == null)
		{
			Lua_BlackJack_ProjectL_UI_WorldUIController.<>f__mg$cache111 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_WorldUIController.set_m_heroButtonRedMarkGameObject);
		}
		LuaObject.addMember(l, name72, get72, Lua_BlackJack_ProjectL_UI_WorldUIController.<>f__mg$cache111, true);
		string name73 = "m_bagButton";
		if (Lua_BlackJack_ProjectL_UI_WorldUIController.<>f__mg$cache112 == null)
		{
			Lua_BlackJack_ProjectL_UI_WorldUIController.<>f__mg$cache112 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_WorldUIController.get_m_bagButton);
		}
		LuaCSFunction get73 = Lua_BlackJack_ProjectL_UI_WorldUIController.<>f__mg$cache112;
		if (Lua_BlackJack_ProjectL_UI_WorldUIController.<>f__mg$cache113 == null)
		{
			Lua_BlackJack_ProjectL_UI_WorldUIController.<>f__mg$cache113 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_WorldUIController.set_m_bagButton);
		}
		LuaObject.addMember(l, name73, get73, Lua_BlackJack_ProjectL_UI_WorldUIController.<>f__mg$cache113, true);
		string name74 = "m_missionButton";
		if (Lua_BlackJack_ProjectL_UI_WorldUIController.<>f__mg$cache114 == null)
		{
			Lua_BlackJack_ProjectL_UI_WorldUIController.<>f__mg$cache114 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_WorldUIController.get_m_missionButton);
		}
		LuaCSFunction get74 = Lua_BlackJack_ProjectL_UI_WorldUIController.<>f__mg$cache114;
		if (Lua_BlackJack_ProjectL_UI_WorldUIController.<>f__mg$cache115 == null)
		{
			Lua_BlackJack_ProjectL_UI_WorldUIController.<>f__mg$cache115 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_WorldUIController.set_m_missionButton);
		}
		LuaObject.addMember(l, name74, get74, Lua_BlackJack_ProjectL_UI_WorldUIController.<>f__mg$cache115, true);
		string name75 = "m_missionButtonRedMarkGameObject";
		if (Lua_BlackJack_ProjectL_UI_WorldUIController.<>f__mg$cache116 == null)
		{
			Lua_BlackJack_ProjectL_UI_WorldUIController.<>f__mg$cache116 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_WorldUIController.get_m_missionButtonRedMarkGameObject);
		}
		LuaCSFunction get75 = Lua_BlackJack_ProjectL_UI_WorldUIController.<>f__mg$cache116;
		if (Lua_BlackJack_ProjectL_UI_WorldUIController.<>f__mg$cache117 == null)
		{
			Lua_BlackJack_ProjectL_UI_WorldUIController.<>f__mg$cache117 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_WorldUIController.set_m_missionButtonRedMarkGameObject);
		}
		LuaObject.addMember(l, name75, get75, Lua_BlackJack_ProjectL_UI_WorldUIController.<>f__mg$cache117, true);
		string name76 = "m_fetterButton";
		if (Lua_BlackJack_ProjectL_UI_WorldUIController.<>f__mg$cache118 == null)
		{
			Lua_BlackJack_ProjectL_UI_WorldUIController.<>f__mg$cache118 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_WorldUIController.get_m_fetterButton);
		}
		LuaCSFunction get76 = Lua_BlackJack_ProjectL_UI_WorldUIController.<>f__mg$cache118;
		if (Lua_BlackJack_ProjectL_UI_WorldUIController.<>f__mg$cache119 == null)
		{
			Lua_BlackJack_ProjectL_UI_WorldUIController.<>f__mg$cache119 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_WorldUIController.set_m_fetterButton);
		}
		LuaObject.addMember(l, name76, get76, Lua_BlackJack_ProjectL_UI_WorldUIController.<>f__mg$cache119, true);
		string name77 = "m_fetterButtonRedMarkGameObject";
		if (Lua_BlackJack_ProjectL_UI_WorldUIController.<>f__mg$cache11A == null)
		{
			Lua_BlackJack_ProjectL_UI_WorldUIController.<>f__mg$cache11A = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_WorldUIController.get_m_fetterButtonRedMarkGameObject);
		}
		LuaCSFunction get77 = Lua_BlackJack_ProjectL_UI_WorldUIController.<>f__mg$cache11A;
		if (Lua_BlackJack_ProjectL_UI_WorldUIController.<>f__mg$cache11B == null)
		{
			Lua_BlackJack_ProjectL_UI_WorldUIController.<>f__mg$cache11B = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_WorldUIController.set_m_fetterButtonRedMarkGameObject);
		}
		LuaObject.addMember(l, name77, get77, Lua_BlackJack_ProjectL_UI_WorldUIController.<>f__mg$cache11B, true);
		string name78 = "m_storeButton";
		if (Lua_BlackJack_ProjectL_UI_WorldUIController.<>f__mg$cache11C == null)
		{
			Lua_BlackJack_ProjectL_UI_WorldUIController.<>f__mg$cache11C = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_WorldUIController.get_m_storeButton);
		}
		LuaCSFunction get78 = Lua_BlackJack_ProjectL_UI_WorldUIController.<>f__mg$cache11C;
		if (Lua_BlackJack_ProjectL_UI_WorldUIController.<>f__mg$cache11D == null)
		{
			Lua_BlackJack_ProjectL_UI_WorldUIController.<>f__mg$cache11D = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_WorldUIController.set_m_storeButton);
		}
		LuaObject.addMember(l, name78, get78, Lua_BlackJack_ProjectL_UI_WorldUIController.<>f__mg$cache11D, true);
		string name79 = "m_selectCardButton";
		if (Lua_BlackJack_ProjectL_UI_WorldUIController.<>f__mg$cache11E == null)
		{
			Lua_BlackJack_ProjectL_UI_WorldUIController.<>f__mg$cache11E = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_WorldUIController.get_m_selectCardButton);
		}
		LuaCSFunction get79 = Lua_BlackJack_ProjectL_UI_WorldUIController.<>f__mg$cache11E;
		if (Lua_BlackJack_ProjectL_UI_WorldUIController.<>f__mg$cache11F == null)
		{
			Lua_BlackJack_ProjectL_UI_WorldUIController.<>f__mg$cache11F = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_WorldUIController.set_m_selectCardButton);
		}
		LuaObject.addMember(l, name79, get79, Lua_BlackJack_ProjectL_UI_WorldUIController.<>f__mg$cache11F, true);
		string name80 = "m_drillButton";
		if (Lua_BlackJack_ProjectL_UI_WorldUIController.<>f__mg$cache120 == null)
		{
			Lua_BlackJack_ProjectL_UI_WorldUIController.<>f__mg$cache120 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_WorldUIController.get_m_drillButton);
		}
		LuaCSFunction get80 = Lua_BlackJack_ProjectL_UI_WorldUIController.<>f__mg$cache120;
		if (Lua_BlackJack_ProjectL_UI_WorldUIController.<>f__mg$cache121 == null)
		{
			Lua_BlackJack_ProjectL_UI_WorldUIController.<>f__mg$cache121 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_WorldUIController.set_m_drillButton);
		}
		LuaObject.addMember(l, name80, get80, Lua_BlackJack_ProjectL_UI_WorldUIController.<>f__mg$cache121, true);
		string name81 = "m_drillButtonRedMark";
		if (Lua_BlackJack_ProjectL_UI_WorldUIController.<>f__mg$cache122 == null)
		{
			Lua_BlackJack_ProjectL_UI_WorldUIController.<>f__mg$cache122 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_WorldUIController.get_m_drillButtonRedMark);
		}
		LuaCSFunction get81 = Lua_BlackJack_ProjectL_UI_WorldUIController.<>f__mg$cache122;
		if (Lua_BlackJack_ProjectL_UI_WorldUIController.<>f__mg$cache123 == null)
		{
			Lua_BlackJack_ProjectL_UI_WorldUIController.<>f__mg$cache123 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_WorldUIController.set_m_drillButtonRedMark);
		}
		LuaObject.addMember(l, name81, get81, Lua_BlackJack_ProjectL_UI_WorldUIController.<>f__mg$cache123, true);
		string name82 = "m_guildButton";
		if (Lua_BlackJack_ProjectL_UI_WorldUIController.<>f__mg$cache124 == null)
		{
			Lua_BlackJack_ProjectL_UI_WorldUIController.<>f__mg$cache124 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_WorldUIController.get_m_guildButton);
		}
		LuaCSFunction get82 = Lua_BlackJack_ProjectL_UI_WorldUIController.<>f__mg$cache124;
		if (Lua_BlackJack_ProjectL_UI_WorldUIController.<>f__mg$cache125 == null)
		{
			Lua_BlackJack_ProjectL_UI_WorldUIController.<>f__mg$cache125 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_WorldUIController.set_m_guildButton);
		}
		LuaObject.addMember(l, name82, get82, Lua_BlackJack_ProjectL_UI_WorldUIController.<>f__mg$cache125, true);
		string name83 = "m_sociatyButtonRedMark";
		if (Lua_BlackJack_ProjectL_UI_WorldUIController.<>f__mg$cache126 == null)
		{
			Lua_BlackJack_ProjectL_UI_WorldUIController.<>f__mg$cache126 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_WorldUIController.get_m_sociatyButtonRedMark);
		}
		LuaCSFunction get83 = Lua_BlackJack_ProjectL_UI_WorldUIController.<>f__mg$cache126;
		if (Lua_BlackJack_ProjectL_UI_WorldUIController.<>f__mg$cache127 == null)
		{
			Lua_BlackJack_ProjectL_UI_WorldUIController.<>f__mg$cache127 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_WorldUIController.set_m_sociatyButtonRedMark);
		}
		LuaObject.addMember(l, name83, get83, Lua_BlackJack_ProjectL_UI_WorldUIController.<>f__mg$cache127, true);
		string name84 = "m_marginTransform";
		if (Lua_BlackJack_ProjectL_UI_WorldUIController.<>f__mg$cache128 == null)
		{
			Lua_BlackJack_ProjectL_UI_WorldUIController.<>f__mg$cache128 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_WorldUIController.get_m_marginTransform);
		}
		LuaCSFunction get84 = Lua_BlackJack_ProjectL_UI_WorldUIController.<>f__mg$cache128;
		if (Lua_BlackJack_ProjectL_UI_WorldUIController.<>f__mg$cache129 == null)
		{
			Lua_BlackJack_ProjectL_UI_WorldUIController.<>f__mg$cache129 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_WorldUIController.set_m_marginTransform);
		}
		LuaObject.addMember(l, name84, get84, Lua_BlackJack_ProjectL_UI_WorldUIController.<>f__mg$cache129, true);
		string name85 = "m_rightGameObject";
		if (Lua_BlackJack_ProjectL_UI_WorldUIController.<>f__mg$cache12A == null)
		{
			Lua_BlackJack_ProjectL_UI_WorldUIController.<>f__mg$cache12A = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_WorldUIController.get_m_rightGameObject);
		}
		LuaCSFunction get85 = Lua_BlackJack_ProjectL_UI_WorldUIController.<>f__mg$cache12A;
		if (Lua_BlackJack_ProjectL_UI_WorldUIController.<>f__mg$cache12B == null)
		{
			Lua_BlackJack_ProjectL_UI_WorldUIController.<>f__mg$cache12B = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_WorldUIController.set_m_rightGameObject);
		}
		LuaObject.addMember(l, name85, get85, Lua_BlackJack_ProjectL_UI_WorldUIController.<>f__mg$cache12B, true);
		string name86 = "m_eventButton";
		if (Lua_BlackJack_ProjectL_UI_WorldUIController.<>f__mg$cache12C == null)
		{
			Lua_BlackJack_ProjectL_UI_WorldUIController.<>f__mg$cache12C = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_WorldUIController.get_m_eventButton);
		}
		LuaCSFunction get86 = Lua_BlackJack_ProjectL_UI_WorldUIController.<>f__mg$cache12C;
		if (Lua_BlackJack_ProjectL_UI_WorldUIController.<>f__mg$cache12D == null)
		{
			Lua_BlackJack_ProjectL_UI_WorldUIController.<>f__mg$cache12D = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_WorldUIController.set_m_eventButton);
		}
		LuaObject.addMember(l, name86, get86, Lua_BlackJack_ProjectL_UI_WorldUIController.<>f__mg$cache12D, true);
		string name87 = "m_eventButtonRedMarkGameObject";
		if (Lua_BlackJack_ProjectL_UI_WorldUIController.<>f__mg$cache12E == null)
		{
			Lua_BlackJack_ProjectL_UI_WorldUIController.<>f__mg$cache12E = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_WorldUIController.get_m_eventButtonRedMarkGameObject);
		}
		LuaCSFunction get87 = Lua_BlackJack_ProjectL_UI_WorldUIController.<>f__mg$cache12E;
		if (Lua_BlackJack_ProjectL_UI_WorldUIController.<>f__mg$cache12F == null)
		{
			Lua_BlackJack_ProjectL_UI_WorldUIController.<>f__mg$cache12F = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_WorldUIController.set_m_eventButtonRedMarkGameObject);
		}
		LuaObject.addMember(l, name87, get87, Lua_BlackJack_ProjectL_UI_WorldUIController.<>f__mg$cache12F, true);
		string name88 = "m_unchartedButton";
		if (Lua_BlackJack_ProjectL_UI_WorldUIController.<>f__mg$cache130 == null)
		{
			Lua_BlackJack_ProjectL_UI_WorldUIController.<>f__mg$cache130 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_WorldUIController.get_m_unchartedButton);
		}
		LuaCSFunction get88 = Lua_BlackJack_ProjectL_UI_WorldUIController.<>f__mg$cache130;
		if (Lua_BlackJack_ProjectL_UI_WorldUIController.<>f__mg$cache131 == null)
		{
			Lua_BlackJack_ProjectL_UI_WorldUIController.<>f__mg$cache131 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_WorldUIController.set_m_unchartedButton);
		}
		LuaObject.addMember(l, name88, get88, Lua_BlackJack_ProjectL_UI_WorldUIController.<>f__mg$cache131, true);
		string name89 = "m_arenaButton";
		if (Lua_BlackJack_ProjectL_UI_WorldUIController.<>f__mg$cache132 == null)
		{
			Lua_BlackJack_ProjectL_UI_WorldUIController.<>f__mg$cache132 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_WorldUIController.get_m_arenaButton);
		}
		LuaCSFunction get89 = Lua_BlackJack_ProjectL_UI_WorldUIController.<>f__mg$cache132;
		if (Lua_BlackJack_ProjectL_UI_WorldUIController.<>f__mg$cache133 == null)
		{
			Lua_BlackJack_ProjectL_UI_WorldUIController.<>f__mg$cache133 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_WorldUIController.set_m_arenaButton);
		}
		LuaObject.addMember(l, name89, get89, Lua_BlackJack_ProjectL_UI_WorldUIController.<>f__mg$cache133, true);
		string name90 = "m_riftButton";
		if (Lua_BlackJack_ProjectL_UI_WorldUIController.<>f__mg$cache134 == null)
		{
			Lua_BlackJack_ProjectL_UI_WorldUIController.<>f__mg$cache134 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_WorldUIController.get_m_riftButton);
		}
		LuaCSFunction get90 = Lua_BlackJack_ProjectL_UI_WorldUIController.<>f__mg$cache134;
		if (Lua_BlackJack_ProjectL_UI_WorldUIController.<>f__mg$cache135 == null)
		{
			Lua_BlackJack_ProjectL_UI_WorldUIController.<>f__mg$cache135 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_WorldUIController.set_m_riftButton);
		}
		LuaObject.addMember(l, name90, get90, Lua_BlackJack_ProjectL_UI_WorldUIController.<>f__mg$cache135, true);
		string name91 = "m_testButton";
		if (Lua_BlackJack_ProjectL_UI_WorldUIController.<>f__mg$cache136 == null)
		{
			Lua_BlackJack_ProjectL_UI_WorldUIController.<>f__mg$cache136 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_WorldUIController.get_m_testButton);
		}
		LuaCSFunction get91 = Lua_BlackJack_ProjectL_UI_WorldUIController.<>f__mg$cache136;
		if (Lua_BlackJack_ProjectL_UI_WorldUIController.<>f__mg$cache137 == null)
		{
			Lua_BlackJack_ProjectL_UI_WorldUIController.<>f__mg$cache137 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_WorldUIController.set_m_testButton);
		}
		LuaObject.addMember(l, name91, get91, Lua_BlackJack_ProjectL_UI_WorldUIController.<>f__mg$cache137, true);
		string name92 = "m_cooperateBattleButton";
		if (Lua_BlackJack_ProjectL_UI_WorldUIController.<>f__mg$cache138 == null)
		{
			Lua_BlackJack_ProjectL_UI_WorldUIController.<>f__mg$cache138 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_WorldUIController.get_m_cooperateBattleButton);
		}
		LuaCSFunction get92 = Lua_BlackJack_ProjectL_UI_WorldUIController.<>f__mg$cache138;
		if (Lua_BlackJack_ProjectL_UI_WorldUIController.<>f__mg$cache139 == null)
		{
			Lua_BlackJack_ProjectL_UI_WorldUIController.<>f__mg$cache139 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_WorldUIController.set_m_cooperateBattleButton);
		}
		LuaObject.addMember(l, name92, get92, Lua_BlackJack_ProjectL_UI_WorldUIController.<>f__mg$cache139, true);
		string name93 = "m_leftGameObject";
		if (Lua_BlackJack_ProjectL_UI_WorldUIController.<>f__mg$cache13A == null)
		{
			Lua_BlackJack_ProjectL_UI_WorldUIController.<>f__mg$cache13A = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_WorldUIController.get_m_leftGameObject);
		}
		LuaCSFunction get93 = Lua_BlackJack_ProjectL_UI_WorldUIController.<>f__mg$cache13A;
		if (Lua_BlackJack_ProjectL_UI_WorldUIController.<>f__mg$cache13B == null)
		{
			Lua_BlackJack_ProjectL_UI_WorldUIController.<>f__mg$cache13B = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_WorldUIController.set_m_leftGameObject);
		}
		LuaObject.addMember(l, name93, get93, Lua_BlackJack_ProjectL_UI_WorldUIController.<>f__mg$cache13B, true);
		string name94 = "m_friendButton";
		if (Lua_BlackJack_ProjectL_UI_WorldUIController.<>f__mg$cache13C == null)
		{
			Lua_BlackJack_ProjectL_UI_WorldUIController.<>f__mg$cache13C = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_WorldUIController.get_m_friendButton);
		}
		LuaCSFunction get94 = Lua_BlackJack_ProjectL_UI_WorldUIController.<>f__mg$cache13C;
		if (Lua_BlackJack_ProjectL_UI_WorldUIController.<>f__mg$cache13D == null)
		{
			Lua_BlackJack_ProjectL_UI_WorldUIController.<>f__mg$cache13D = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_WorldUIController.set_m_friendButton);
		}
		LuaObject.addMember(l, name94, get94, Lua_BlackJack_ProjectL_UI_WorldUIController.<>f__mg$cache13D, true);
		string name95 = "m_friendButtonRedMark";
		if (Lua_BlackJack_ProjectL_UI_WorldUIController.<>f__mg$cache13E == null)
		{
			Lua_BlackJack_ProjectL_UI_WorldUIController.<>f__mg$cache13E = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_WorldUIController.get_m_friendButtonRedMark);
		}
		LuaCSFunction get95 = Lua_BlackJack_ProjectL_UI_WorldUIController.<>f__mg$cache13E;
		if (Lua_BlackJack_ProjectL_UI_WorldUIController.<>f__mg$cache13F == null)
		{
			Lua_BlackJack_ProjectL_UI_WorldUIController.<>f__mg$cache13F = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_WorldUIController.set_m_friendButtonRedMark);
		}
		LuaObject.addMember(l, name95, get95, Lua_BlackJack_ProjectL_UI_WorldUIController.<>f__mg$cache13F, true);
		string name96 = "m_mailButton";
		if (Lua_BlackJack_ProjectL_UI_WorldUIController.<>f__mg$cache140 == null)
		{
			Lua_BlackJack_ProjectL_UI_WorldUIController.<>f__mg$cache140 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_WorldUIController.get_m_mailButton);
		}
		LuaCSFunction get96 = Lua_BlackJack_ProjectL_UI_WorldUIController.<>f__mg$cache140;
		if (Lua_BlackJack_ProjectL_UI_WorldUIController.<>f__mg$cache141 == null)
		{
			Lua_BlackJack_ProjectL_UI_WorldUIController.<>f__mg$cache141 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_WorldUIController.set_m_mailButton);
		}
		LuaObject.addMember(l, name96, get96, Lua_BlackJack_ProjectL_UI_WorldUIController.<>f__mg$cache141, true);
		string name97 = "m_unreadMailCountText";
		if (Lua_BlackJack_ProjectL_UI_WorldUIController.<>f__mg$cache142 == null)
		{
			Lua_BlackJack_ProjectL_UI_WorldUIController.<>f__mg$cache142 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_WorldUIController.get_m_unreadMailCountText);
		}
		LuaCSFunction get97 = Lua_BlackJack_ProjectL_UI_WorldUIController.<>f__mg$cache142;
		if (Lua_BlackJack_ProjectL_UI_WorldUIController.<>f__mg$cache143 == null)
		{
			Lua_BlackJack_ProjectL_UI_WorldUIController.<>f__mg$cache143 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_WorldUIController.set_m_unreadMailCountText);
		}
		LuaObject.addMember(l, name97, get97, Lua_BlackJack_ProjectL_UI_WorldUIController.<>f__mg$cache143, true);
		string name98 = "m_chatButton";
		if (Lua_BlackJack_ProjectL_UI_WorldUIController.<>f__mg$cache144 == null)
		{
			Lua_BlackJack_ProjectL_UI_WorldUIController.<>f__mg$cache144 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_WorldUIController.get_m_chatButton);
		}
		LuaCSFunction get98 = Lua_BlackJack_ProjectL_UI_WorldUIController.<>f__mg$cache144;
		if (Lua_BlackJack_ProjectL_UI_WorldUIController.<>f__mg$cache145 == null)
		{
			Lua_BlackJack_ProjectL_UI_WorldUIController.<>f__mg$cache145 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_WorldUIController.set_m_chatButton);
		}
		LuaObject.addMember(l, name98, get98, Lua_BlackJack_ProjectL_UI_WorldUIController.<>f__mg$cache145, true);
		string name99 = "m_newChatCountText";
		if (Lua_BlackJack_ProjectL_UI_WorldUIController.<>f__mg$cache146 == null)
		{
			Lua_BlackJack_ProjectL_UI_WorldUIController.<>f__mg$cache146 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_WorldUIController.get_m_newChatCountText);
		}
		LuaCSFunction get99 = Lua_BlackJack_ProjectL_UI_WorldUIController.<>f__mg$cache146;
		if (Lua_BlackJack_ProjectL_UI_WorldUIController.<>f__mg$cache147 == null)
		{
			Lua_BlackJack_ProjectL_UI_WorldUIController.<>f__mg$cache147 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_WorldUIController.set_m_newChatCountText);
		}
		LuaObject.addMember(l, name99, get99, Lua_BlackJack_ProjectL_UI_WorldUIController.<>f__mg$cache147, true);
		string name100 = "m_rankButton";
		if (Lua_BlackJack_ProjectL_UI_WorldUIController.<>f__mg$cache148 == null)
		{
			Lua_BlackJack_ProjectL_UI_WorldUIController.<>f__mg$cache148 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_WorldUIController.get_m_rankButton);
		}
		LuaCSFunction get100 = Lua_BlackJack_ProjectL_UI_WorldUIController.<>f__mg$cache148;
		if (Lua_BlackJack_ProjectL_UI_WorldUIController.<>f__mg$cache149 == null)
		{
			Lua_BlackJack_ProjectL_UI_WorldUIController.<>f__mg$cache149 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_WorldUIController.set_m_rankButton);
		}
		LuaObject.addMember(l, name100, get100, Lua_BlackJack_ProjectL_UI_WorldUIController.<>f__mg$cache149, true);
		string name101 = "m_activityButton";
		if (Lua_BlackJack_ProjectL_UI_WorldUIController.<>f__mg$cache14A == null)
		{
			Lua_BlackJack_ProjectL_UI_WorldUIController.<>f__mg$cache14A = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_WorldUIController.get_m_activityButton);
		}
		LuaCSFunction get101 = Lua_BlackJack_ProjectL_UI_WorldUIController.<>f__mg$cache14A;
		if (Lua_BlackJack_ProjectL_UI_WorldUIController.<>f__mg$cache14B == null)
		{
			Lua_BlackJack_ProjectL_UI_WorldUIController.<>f__mg$cache14B = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_WorldUIController.set_m_activityButton);
		}
		LuaObject.addMember(l, name101, get101, Lua_BlackJack_ProjectL_UI_WorldUIController.<>f__mg$cache14B, true);
		string name102 = "m_activityRedMarkGameObject";
		if (Lua_BlackJack_ProjectL_UI_WorldUIController.<>f__mg$cache14C == null)
		{
			Lua_BlackJack_ProjectL_UI_WorldUIController.<>f__mg$cache14C = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_WorldUIController.get_m_activityRedMarkGameObject);
		}
		LuaCSFunction get102 = Lua_BlackJack_ProjectL_UI_WorldUIController.<>f__mg$cache14C;
		if (Lua_BlackJack_ProjectL_UI_WorldUIController.<>f__mg$cache14D == null)
		{
			Lua_BlackJack_ProjectL_UI_WorldUIController.<>f__mg$cache14D = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_WorldUIController.set_m_activityRedMarkGameObject);
		}
		LuaObject.addMember(l, name102, get102, Lua_BlackJack_ProjectL_UI_WorldUIController.<>f__mg$cache14D, true);
		string name103 = "m_investigationButton";
		if (Lua_BlackJack_ProjectL_UI_WorldUIController.<>f__mg$cache14E == null)
		{
			Lua_BlackJack_ProjectL_UI_WorldUIController.<>f__mg$cache14E = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_WorldUIController.get_m_investigationButton);
		}
		LuaCSFunction get103 = Lua_BlackJack_ProjectL_UI_WorldUIController.<>f__mg$cache14E;
		if (Lua_BlackJack_ProjectL_UI_WorldUIController.<>f__mg$cache14F == null)
		{
			Lua_BlackJack_ProjectL_UI_WorldUIController.<>f__mg$cache14F = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_WorldUIController.set_m_investigationButton);
		}
		LuaObject.addMember(l, name103, get103, Lua_BlackJack_ProjectL_UI_WorldUIController.<>f__mg$cache14F, true);
		string name104 = "m_investigationButtonRedMark";
		if (Lua_BlackJack_ProjectL_UI_WorldUIController.<>f__mg$cache150 == null)
		{
			Lua_BlackJack_ProjectL_UI_WorldUIController.<>f__mg$cache150 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_WorldUIController.get_m_investigationButtonRedMark);
		}
		LuaCSFunction get104 = Lua_BlackJack_ProjectL_UI_WorldUIController.<>f__mg$cache150;
		if (Lua_BlackJack_ProjectL_UI_WorldUIController.<>f__mg$cache151 == null)
		{
			Lua_BlackJack_ProjectL_UI_WorldUIController.<>f__mg$cache151 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_WorldUIController.set_m_investigationButtonRedMark);
		}
		LuaObject.addMember(l, name104, get104, Lua_BlackJack_ProjectL_UI_WorldUIController.<>f__mg$cache151, true);
		string name105 = "m_YYBButton";
		if (Lua_BlackJack_ProjectL_UI_WorldUIController.<>f__mg$cache152 == null)
		{
			Lua_BlackJack_ProjectL_UI_WorldUIController.<>f__mg$cache152 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_WorldUIController.get_m_YYBButton);
		}
		LuaCSFunction get105 = Lua_BlackJack_ProjectL_UI_WorldUIController.<>f__mg$cache152;
		if (Lua_BlackJack_ProjectL_UI_WorldUIController.<>f__mg$cache153 == null)
		{
			Lua_BlackJack_ProjectL_UI_WorldUIController.<>f__mg$cache153 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_WorldUIController.set_m_YYBButton);
		}
		LuaObject.addMember(l, name105, get105, Lua_BlackJack_ProjectL_UI_WorldUIController.<>f__mg$cache153, true);
		string name106 = "m_OppoButton";
		if (Lua_BlackJack_ProjectL_UI_WorldUIController.<>f__mg$cache154 == null)
		{
			Lua_BlackJack_ProjectL_UI_WorldUIController.<>f__mg$cache154 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_WorldUIController.get_m_OppoButton);
		}
		LuaCSFunction get106 = Lua_BlackJack_ProjectL_UI_WorldUIController.<>f__mg$cache154;
		if (Lua_BlackJack_ProjectL_UI_WorldUIController.<>f__mg$cache155 == null)
		{
			Lua_BlackJack_ProjectL_UI_WorldUIController.<>f__mg$cache155 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_WorldUIController.set_m_OppoButton);
		}
		LuaObject.addMember(l, name106, get106, Lua_BlackJack_ProjectL_UI_WorldUIController.<>f__mg$cache155, true);
		string name107 = "m_openServiceActivityButton";
		if (Lua_BlackJack_ProjectL_UI_WorldUIController.<>f__mg$cache156 == null)
		{
			Lua_BlackJack_ProjectL_UI_WorldUIController.<>f__mg$cache156 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_WorldUIController.get_m_openServiceActivityButton);
		}
		LuaCSFunction get107 = Lua_BlackJack_ProjectL_UI_WorldUIController.<>f__mg$cache156;
		if (Lua_BlackJack_ProjectL_UI_WorldUIController.<>f__mg$cache157 == null)
		{
			Lua_BlackJack_ProjectL_UI_WorldUIController.<>f__mg$cache157 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_WorldUIController.set_m_openServiceActivityButton);
		}
		LuaObject.addMember(l, name107, get107, Lua_BlackJack_ProjectL_UI_WorldUIController.<>f__mg$cache157, true);
		string name108 = "m_openServiceActivityButtonRedMark";
		if (Lua_BlackJack_ProjectL_UI_WorldUIController.<>f__mg$cache158 == null)
		{
			Lua_BlackJack_ProjectL_UI_WorldUIController.<>f__mg$cache158 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_WorldUIController.get_m_openServiceActivityButtonRedMark);
		}
		LuaCSFunction get108 = Lua_BlackJack_ProjectL_UI_WorldUIController.<>f__mg$cache158;
		if (Lua_BlackJack_ProjectL_UI_WorldUIController.<>f__mg$cache159 == null)
		{
			Lua_BlackJack_ProjectL_UI_WorldUIController.<>f__mg$cache159 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_WorldUIController.set_m_openServiceActivityButtonRedMark);
		}
		LuaObject.addMember(l, name108, get108, Lua_BlackJack_ProjectL_UI_WorldUIController.<>f__mg$cache159, true);
		string name109 = "m_monthCardButton";
		if (Lua_BlackJack_ProjectL_UI_WorldUIController.<>f__mg$cache15A == null)
		{
			Lua_BlackJack_ProjectL_UI_WorldUIController.<>f__mg$cache15A = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_WorldUIController.get_m_monthCardButton);
		}
		LuaCSFunction get109 = Lua_BlackJack_ProjectL_UI_WorldUIController.<>f__mg$cache15A;
		if (Lua_BlackJack_ProjectL_UI_WorldUIController.<>f__mg$cache15B == null)
		{
			Lua_BlackJack_ProjectL_UI_WorldUIController.<>f__mg$cache15B = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_WorldUIController.set_m_monthCardButton);
		}
		LuaObject.addMember(l, name109, get109, Lua_BlackJack_ProjectL_UI_WorldUIController.<>f__mg$cache15B, true);
		string name110 = "m_monthCardPanelUIStateController";
		if (Lua_BlackJack_ProjectL_UI_WorldUIController.<>f__mg$cache15C == null)
		{
			Lua_BlackJack_ProjectL_UI_WorldUIController.<>f__mg$cache15C = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_WorldUIController.get_m_monthCardPanelUIStateController);
		}
		LuaCSFunction get110 = Lua_BlackJack_ProjectL_UI_WorldUIController.<>f__mg$cache15C;
		if (Lua_BlackJack_ProjectL_UI_WorldUIController.<>f__mg$cache15D == null)
		{
			Lua_BlackJack_ProjectL_UI_WorldUIController.<>f__mg$cache15D = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_WorldUIController.set_m_monthCardPanelUIStateController);
		}
		LuaObject.addMember(l, name110, get110, Lua_BlackJack_ProjectL_UI_WorldUIController.<>f__mg$cache15D, true);
		string name111 = "m_monthCardItemGroupObj";
		if (Lua_BlackJack_ProjectL_UI_WorldUIController.<>f__mg$cache15E == null)
		{
			Lua_BlackJack_ProjectL_UI_WorldUIController.<>f__mg$cache15E = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_WorldUIController.get_m_monthCardItemGroupObj);
		}
		LuaCSFunction get111 = Lua_BlackJack_ProjectL_UI_WorldUIController.<>f__mg$cache15E;
		if (Lua_BlackJack_ProjectL_UI_WorldUIController.<>f__mg$cache15F == null)
		{
			Lua_BlackJack_ProjectL_UI_WorldUIController.<>f__mg$cache15F = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_WorldUIController.set_m_monthCardItemGroupObj);
		}
		LuaObject.addMember(l, name111, get111, Lua_BlackJack_ProjectL_UI_WorldUIController.<>f__mg$cache15F, true);
		string name112 = "m_monthCardCloseButton";
		if (Lua_BlackJack_ProjectL_UI_WorldUIController.<>f__mg$cache160 == null)
		{
			Lua_BlackJack_ProjectL_UI_WorldUIController.<>f__mg$cache160 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_WorldUIController.get_m_monthCardCloseButton);
		}
		LuaCSFunction get112 = Lua_BlackJack_ProjectL_UI_WorldUIController.<>f__mg$cache160;
		if (Lua_BlackJack_ProjectL_UI_WorldUIController.<>f__mg$cache161 == null)
		{
			Lua_BlackJack_ProjectL_UI_WorldUIController.<>f__mg$cache161 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_WorldUIController.set_m_monthCardCloseButton);
		}
		LuaObject.addMember(l, name112, get112, Lua_BlackJack_ProjectL_UI_WorldUIController.<>f__mg$cache161, true);
		string name113 = "m_prefabsGameObject";
		if (Lua_BlackJack_ProjectL_UI_WorldUIController.<>f__mg$cache162 == null)
		{
			Lua_BlackJack_ProjectL_UI_WorldUIController.<>f__mg$cache162 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_WorldUIController.get_m_prefabsGameObject);
		}
		LuaCSFunction get113 = Lua_BlackJack_ProjectL_UI_WorldUIController.<>f__mg$cache162;
		if (Lua_BlackJack_ProjectL_UI_WorldUIController.<>f__mg$cache163 == null)
		{
			Lua_BlackJack_ProjectL_UI_WorldUIController.<>f__mg$cache163 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_WorldUIController.set_m_prefabsGameObject);
		}
		LuaObject.addMember(l, name113, get113, Lua_BlackJack_ProjectL_UI_WorldUIController.<>f__mg$cache163, true);
		string name114 = "m_randomEventListItemPrefab";
		if (Lua_BlackJack_ProjectL_UI_WorldUIController.<>f__mg$cache164 == null)
		{
			Lua_BlackJack_ProjectL_UI_WorldUIController.<>f__mg$cache164 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_WorldUIController.get_m_randomEventListItemPrefab);
		}
		LuaCSFunction get114 = Lua_BlackJack_ProjectL_UI_WorldUIController.<>f__mg$cache164;
		if (Lua_BlackJack_ProjectL_UI_WorldUIController.<>f__mg$cache165 == null)
		{
			Lua_BlackJack_ProjectL_UI_WorldUIController.<>f__mg$cache165 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_WorldUIController.set_m_randomEventListItemPrefab);
		}
		LuaObject.addMember(l, name114, get114, Lua_BlackJack_ProjectL_UI_WorldUIController.<>f__mg$cache165, true);
		string name115 = "m_pastScenarioListItemPrefab";
		if (Lua_BlackJack_ProjectL_UI_WorldUIController.<>f__mg$cache166 == null)
		{
			Lua_BlackJack_ProjectL_UI_WorldUIController.<>f__mg$cache166 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_WorldUIController.get_m_pastScenarioListItemPrefab);
		}
		LuaCSFunction get115 = Lua_BlackJack_ProjectL_UI_WorldUIController.<>f__mg$cache166;
		if (Lua_BlackJack_ProjectL_UI_WorldUIController.<>f__mg$cache167 == null)
		{
			Lua_BlackJack_ProjectL_UI_WorldUIController.<>f__mg$cache167 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_WorldUIController.set_m_pastScenarioListItemPrefab);
		}
		LuaObject.addMember(l, name115, get115, Lua_BlackJack_ProjectL_UI_WorldUIController.<>f__mg$cache167, true);
		string name116 = "m_monthCardItemPrefab";
		if (Lua_BlackJack_ProjectL_UI_WorldUIController.<>f__mg$cache168 == null)
		{
			Lua_BlackJack_ProjectL_UI_WorldUIController.<>f__mg$cache168 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_WorldUIController.get_m_monthCardItemPrefab);
		}
		LuaCSFunction get116 = Lua_BlackJack_ProjectL_UI_WorldUIController.<>f__mg$cache168;
		if (Lua_BlackJack_ProjectL_UI_WorldUIController.<>f__mg$cache169 == null)
		{
			Lua_BlackJack_ProjectL_UI_WorldUIController.<>f__mg$cache169 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_WorldUIController.set_m_monthCardItemPrefab);
		}
		LuaObject.addMember(l, name116, get116, Lua_BlackJack_ProjectL_UI_WorldUIController.<>f__mg$cache169, true);
		string name117 = "m_gotoRiftLevelInfo";
		if (Lua_BlackJack_ProjectL_UI_WorldUIController.<>f__mg$cache16A == null)
		{
			Lua_BlackJack_ProjectL_UI_WorldUIController.<>f__mg$cache16A = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_WorldUIController.get_m_gotoRiftLevelInfo);
		}
		LuaCSFunction get117 = Lua_BlackJack_ProjectL_UI_WorldUIController.<>f__mg$cache16A;
		if (Lua_BlackJack_ProjectL_UI_WorldUIController.<>f__mg$cache16B == null)
		{
			Lua_BlackJack_ProjectL_UI_WorldUIController.<>f__mg$cache16B = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_WorldUIController.set_m_gotoRiftLevelInfo);
		}
		LuaObject.addMember(l, name117, get117, Lua_BlackJack_ProjectL_UI_WorldUIController.<>f__mg$cache16B, true);
		string name118 = "m_developerClickCount";
		if (Lua_BlackJack_ProjectL_UI_WorldUIController.<>f__mg$cache16C == null)
		{
			Lua_BlackJack_ProjectL_UI_WorldUIController.<>f__mg$cache16C = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_WorldUIController.get_m_developerClickCount);
		}
		LuaCSFunction get118 = Lua_BlackJack_ProjectL_UI_WorldUIController.<>f__mg$cache16C;
		if (Lua_BlackJack_ProjectL_UI_WorldUIController.<>f__mg$cache16D == null)
		{
			Lua_BlackJack_ProjectL_UI_WorldUIController.<>f__mg$cache16D = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_WorldUIController.set_m_developerClickCount);
		}
		LuaObject.addMember(l, name118, get118, Lua_BlackJack_ProjectL_UI_WorldUIController.<>f__mg$cache16D, true);
		string name119 = "m_fogColor";
		if (Lua_BlackJack_ProjectL_UI_WorldUIController.<>f__mg$cache16E == null)
		{
			Lua_BlackJack_ProjectL_UI_WorldUIController.<>f__mg$cache16E = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_WorldUIController.get_m_fogColor);
		}
		LuaCSFunction get119 = Lua_BlackJack_ProjectL_UI_WorldUIController.<>f__mg$cache16E;
		if (Lua_BlackJack_ProjectL_UI_WorldUIController.<>f__mg$cache16F == null)
		{
			Lua_BlackJack_ProjectL_UI_WorldUIController.<>f__mg$cache16F = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_WorldUIController.set_m_fogColor);
		}
		LuaObject.addMember(l, name119, get119, Lua_BlackJack_ProjectL_UI_WorldUIController.<>f__mg$cache16F, true);
		string name120 = "m_randomEventListItems";
		if (Lua_BlackJack_ProjectL_UI_WorldUIController.<>f__mg$cache170 == null)
		{
			Lua_BlackJack_ProjectL_UI_WorldUIController.<>f__mg$cache170 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_WorldUIController.get_m_randomEventListItems);
		}
		LuaCSFunction get120 = Lua_BlackJack_ProjectL_UI_WorldUIController.<>f__mg$cache170;
		if (Lua_BlackJack_ProjectL_UI_WorldUIController.<>f__mg$cache171 == null)
		{
			Lua_BlackJack_ProjectL_UI_WorldUIController.<>f__mg$cache171 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_WorldUIController.set_m_randomEventListItems);
		}
		LuaObject.addMember(l, name120, get120, Lua_BlackJack_ProjectL_UI_WorldUIController.<>f__mg$cache171, true);
		string name121 = "m_pastScenarioListItems";
		if (Lua_BlackJack_ProjectL_UI_WorldUIController.<>f__mg$cache172 == null)
		{
			Lua_BlackJack_ProjectL_UI_WorldUIController.<>f__mg$cache172 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_WorldUIController.get_m_pastScenarioListItems);
		}
		LuaCSFunction get121 = Lua_BlackJack_ProjectL_UI_WorldUIController.<>f__mg$cache172;
		if (Lua_BlackJack_ProjectL_UI_WorldUIController.<>f__mg$cache173 == null)
		{
			Lua_BlackJack_ProjectL_UI_WorldUIController.<>f__mg$cache173 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_WorldUIController.set_m_pastScenarioListItems);
		}
		LuaObject.addMember(l, name121, get121, Lua_BlackJack_ProjectL_UI_WorldUIController.<>f__mg$cache173, true);
		string name122 = "m_userGuideDialogHideGameObjects";
		if (Lua_BlackJack_ProjectL_UI_WorldUIController.<>f__mg$cache174 == null)
		{
			Lua_BlackJack_ProjectL_UI_WorldUIController.<>f__mg$cache174 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_WorldUIController.get_m_userGuideDialogHideGameObjects);
		}
		LuaCSFunction get122 = Lua_BlackJack_ProjectL_UI_WorldUIController.<>f__mg$cache174;
		if (Lua_BlackJack_ProjectL_UI_WorldUIController.<>f__mg$cache175 == null)
		{
			Lua_BlackJack_ProjectL_UI_WorldUIController.<>f__mg$cache175 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_WorldUIController.set_m_userGuideDialogHideGameObjects);
		}
		LuaObject.addMember(l, name122, get122, Lua_BlackJack_ProjectL_UI_WorldUIController.<>f__mg$cache175, true);
		string name123 = "m_configDataLoader";
		if (Lua_BlackJack_ProjectL_UI_WorldUIController.<>f__mg$cache176 == null)
		{
			Lua_BlackJack_ProjectL_UI_WorldUIController.<>f__mg$cache176 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_WorldUIController.get_m_configDataLoader);
		}
		LuaCSFunction get123 = Lua_BlackJack_ProjectL_UI_WorldUIController.<>f__mg$cache176;
		if (Lua_BlackJack_ProjectL_UI_WorldUIController.<>f__mg$cache177 == null)
		{
			Lua_BlackJack_ProjectL_UI_WorldUIController.<>f__mg$cache177 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_WorldUIController.set_m_configDataLoader);
		}
		LuaObject.addMember(l, name123, get123, Lua_BlackJack_ProjectL_UI_WorldUIController.<>f__mg$cache177, true);
		LuaObject.createTypeMetatable(l, null, typeof(WorldUIController), typeof(UIControllerBase));
	}

	// Token: 0x040182BF RID: 99007
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache0;

	// Token: 0x040182C0 RID: 99008
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1;

	// Token: 0x040182C1 RID: 99009
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2;

	// Token: 0x040182C2 RID: 99010
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3;

	// Token: 0x040182C3 RID: 99011
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache4;

	// Token: 0x040182C4 RID: 99012
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache5;

	// Token: 0x040182C5 RID: 99013
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache6;

	// Token: 0x040182C6 RID: 99014
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache7;

	// Token: 0x040182C7 RID: 99015
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache8;

	// Token: 0x040182C8 RID: 99016
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache9;

	// Token: 0x040182C9 RID: 99017
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheA;

	// Token: 0x040182CA RID: 99018
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheB;

	// Token: 0x040182CB RID: 99019
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheC;

	// Token: 0x040182CC RID: 99020
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheD;

	// Token: 0x040182CD RID: 99021
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheE;

	// Token: 0x040182CE RID: 99022
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheF;

	// Token: 0x040182CF RID: 99023
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache10;

	// Token: 0x040182D0 RID: 99024
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache11;

	// Token: 0x040182D1 RID: 99025
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache12;

	// Token: 0x040182D2 RID: 99026
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache13;

	// Token: 0x040182D3 RID: 99027
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache14;

	// Token: 0x040182D4 RID: 99028
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache15;

	// Token: 0x040182D5 RID: 99029
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache16;

	// Token: 0x040182D6 RID: 99030
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache17;

	// Token: 0x040182D7 RID: 99031
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache18;

	// Token: 0x040182D8 RID: 99032
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache19;

	// Token: 0x040182D9 RID: 99033
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1A;

	// Token: 0x040182DA RID: 99034
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1B;

	// Token: 0x040182DB RID: 99035
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1C;

	// Token: 0x040182DC RID: 99036
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1D;

	// Token: 0x040182DD RID: 99037
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1E;

	// Token: 0x040182DE RID: 99038
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1F;

	// Token: 0x040182DF RID: 99039
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache20;

	// Token: 0x040182E0 RID: 99040
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache21;

	// Token: 0x040182E1 RID: 99041
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache22;

	// Token: 0x040182E2 RID: 99042
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache23;

	// Token: 0x040182E3 RID: 99043
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache24;

	// Token: 0x040182E4 RID: 99044
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache25;

	// Token: 0x040182E5 RID: 99045
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache26;

	// Token: 0x040182E6 RID: 99046
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache27;

	// Token: 0x040182E7 RID: 99047
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache28;

	// Token: 0x040182E8 RID: 99048
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache29;

	// Token: 0x040182E9 RID: 99049
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2A;

	// Token: 0x040182EA RID: 99050
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2B;

	// Token: 0x040182EB RID: 99051
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2C;

	// Token: 0x040182EC RID: 99052
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2D;

	// Token: 0x040182ED RID: 99053
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2E;

	// Token: 0x040182EE RID: 99054
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2F;

	// Token: 0x040182EF RID: 99055
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache30;

	// Token: 0x040182F0 RID: 99056
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache31;

	// Token: 0x040182F1 RID: 99057
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache32;

	// Token: 0x040182F2 RID: 99058
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache33;

	// Token: 0x040182F3 RID: 99059
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache34;

	// Token: 0x040182F4 RID: 99060
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache35;

	// Token: 0x040182F5 RID: 99061
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache36;

	// Token: 0x040182F6 RID: 99062
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache37;

	// Token: 0x040182F7 RID: 99063
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache38;

	// Token: 0x040182F8 RID: 99064
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache39;

	// Token: 0x040182F9 RID: 99065
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3A;

	// Token: 0x040182FA RID: 99066
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3B;

	// Token: 0x040182FB RID: 99067
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3C;

	// Token: 0x040182FC RID: 99068
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3D;

	// Token: 0x040182FD RID: 99069
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3E;

	// Token: 0x040182FE RID: 99070
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3F;

	// Token: 0x040182FF RID: 99071
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache40;

	// Token: 0x04018300 RID: 99072
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache41;

	// Token: 0x04018301 RID: 99073
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache42;

	// Token: 0x04018302 RID: 99074
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache43;

	// Token: 0x04018303 RID: 99075
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache44;

	// Token: 0x04018304 RID: 99076
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache45;

	// Token: 0x04018305 RID: 99077
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache46;

	// Token: 0x04018306 RID: 99078
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache47;

	// Token: 0x04018307 RID: 99079
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache48;

	// Token: 0x04018308 RID: 99080
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache49;

	// Token: 0x04018309 RID: 99081
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache4A;

	// Token: 0x0401830A RID: 99082
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache4B;

	// Token: 0x0401830B RID: 99083
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache4C;

	// Token: 0x0401830C RID: 99084
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache4D;

	// Token: 0x0401830D RID: 99085
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache4E;

	// Token: 0x0401830E RID: 99086
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache4F;

	// Token: 0x0401830F RID: 99087
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache50;

	// Token: 0x04018310 RID: 99088
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache51;

	// Token: 0x04018311 RID: 99089
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache52;

	// Token: 0x04018312 RID: 99090
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache53;

	// Token: 0x04018313 RID: 99091
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache54;

	// Token: 0x04018314 RID: 99092
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache55;

	// Token: 0x04018315 RID: 99093
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache56;

	// Token: 0x04018316 RID: 99094
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache57;

	// Token: 0x04018317 RID: 99095
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache58;

	// Token: 0x04018318 RID: 99096
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache59;

	// Token: 0x04018319 RID: 99097
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache5A;

	// Token: 0x0401831A RID: 99098
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache5B;

	// Token: 0x0401831B RID: 99099
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache5C;

	// Token: 0x0401831C RID: 99100
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache5D;

	// Token: 0x0401831D RID: 99101
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache5E;

	// Token: 0x0401831E RID: 99102
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache5F;

	// Token: 0x0401831F RID: 99103
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache60;

	// Token: 0x04018320 RID: 99104
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache61;

	// Token: 0x04018321 RID: 99105
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache62;

	// Token: 0x04018322 RID: 99106
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache63;

	// Token: 0x04018323 RID: 99107
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache64;

	// Token: 0x04018324 RID: 99108
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache65;

	// Token: 0x04018325 RID: 99109
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache66;

	// Token: 0x04018326 RID: 99110
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache67;

	// Token: 0x04018327 RID: 99111
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache68;

	// Token: 0x04018328 RID: 99112
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache69;

	// Token: 0x04018329 RID: 99113
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache6A;

	// Token: 0x0401832A RID: 99114
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache6B;

	// Token: 0x0401832B RID: 99115
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache6C;

	// Token: 0x0401832C RID: 99116
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache6D;

	// Token: 0x0401832D RID: 99117
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache6E;

	// Token: 0x0401832E RID: 99118
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache6F;

	// Token: 0x0401832F RID: 99119
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache70;

	// Token: 0x04018330 RID: 99120
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache71;

	// Token: 0x04018331 RID: 99121
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache72;

	// Token: 0x04018332 RID: 99122
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache73;

	// Token: 0x04018333 RID: 99123
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache74;

	// Token: 0x04018334 RID: 99124
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache75;

	// Token: 0x04018335 RID: 99125
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache76;

	// Token: 0x04018336 RID: 99126
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache77;

	// Token: 0x04018337 RID: 99127
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache78;

	// Token: 0x04018338 RID: 99128
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache79;

	// Token: 0x04018339 RID: 99129
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache7A;

	// Token: 0x0401833A RID: 99130
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache7B;

	// Token: 0x0401833B RID: 99131
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache7C;

	// Token: 0x0401833C RID: 99132
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache7D;

	// Token: 0x0401833D RID: 99133
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache7E;

	// Token: 0x0401833E RID: 99134
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache7F;

	// Token: 0x0401833F RID: 99135
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache80;

	// Token: 0x04018340 RID: 99136
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache81;

	// Token: 0x04018341 RID: 99137
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache82;

	// Token: 0x04018342 RID: 99138
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache83;

	// Token: 0x04018343 RID: 99139
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache84;

	// Token: 0x04018344 RID: 99140
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache85;

	// Token: 0x04018345 RID: 99141
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache86;

	// Token: 0x04018346 RID: 99142
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache87;

	// Token: 0x04018347 RID: 99143
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache88;

	// Token: 0x04018348 RID: 99144
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache89;

	// Token: 0x04018349 RID: 99145
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache8A;

	// Token: 0x0401834A RID: 99146
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache8B;

	// Token: 0x0401834B RID: 99147
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache8C;

	// Token: 0x0401834C RID: 99148
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache8D;

	// Token: 0x0401834D RID: 99149
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache8E;

	// Token: 0x0401834E RID: 99150
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache8F;

	// Token: 0x0401834F RID: 99151
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache90;

	// Token: 0x04018350 RID: 99152
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache91;

	// Token: 0x04018351 RID: 99153
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache92;

	// Token: 0x04018352 RID: 99154
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache93;

	// Token: 0x04018353 RID: 99155
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache94;

	// Token: 0x04018354 RID: 99156
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache95;

	// Token: 0x04018355 RID: 99157
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache96;

	// Token: 0x04018356 RID: 99158
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache97;

	// Token: 0x04018357 RID: 99159
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache98;

	// Token: 0x04018358 RID: 99160
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache99;

	// Token: 0x04018359 RID: 99161
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache9A;

	// Token: 0x0401835A RID: 99162
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache9B;

	// Token: 0x0401835B RID: 99163
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache9C;

	// Token: 0x0401835C RID: 99164
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache9D;

	// Token: 0x0401835D RID: 99165
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache9E;

	// Token: 0x0401835E RID: 99166
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache9F;

	// Token: 0x0401835F RID: 99167
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheA0;

	// Token: 0x04018360 RID: 99168
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheA1;

	// Token: 0x04018361 RID: 99169
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheA2;

	// Token: 0x04018362 RID: 99170
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheA3;

	// Token: 0x04018363 RID: 99171
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheA4;

	// Token: 0x04018364 RID: 99172
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheA5;

	// Token: 0x04018365 RID: 99173
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheA6;

	// Token: 0x04018366 RID: 99174
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheA7;

	// Token: 0x04018367 RID: 99175
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheA8;

	// Token: 0x04018368 RID: 99176
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheA9;

	// Token: 0x04018369 RID: 99177
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheAA;

	// Token: 0x0401836A RID: 99178
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheAB;

	// Token: 0x0401836B RID: 99179
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheAC;

	// Token: 0x0401836C RID: 99180
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheAD;

	// Token: 0x0401836D RID: 99181
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheAE;

	// Token: 0x0401836E RID: 99182
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheAF;

	// Token: 0x0401836F RID: 99183
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheB0;

	// Token: 0x04018370 RID: 99184
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheB1;

	// Token: 0x04018371 RID: 99185
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheB2;

	// Token: 0x04018372 RID: 99186
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheB3;

	// Token: 0x04018373 RID: 99187
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheB4;

	// Token: 0x04018374 RID: 99188
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheB5;

	// Token: 0x04018375 RID: 99189
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheB6;

	// Token: 0x04018376 RID: 99190
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheB7;

	// Token: 0x04018377 RID: 99191
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheB8;

	// Token: 0x04018378 RID: 99192
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheB9;

	// Token: 0x04018379 RID: 99193
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheBA;

	// Token: 0x0401837A RID: 99194
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheBB;

	// Token: 0x0401837B RID: 99195
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheBC;

	// Token: 0x0401837C RID: 99196
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheBD;

	// Token: 0x0401837D RID: 99197
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheBE;

	// Token: 0x0401837E RID: 99198
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheBF;

	// Token: 0x0401837F RID: 99199
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheC0;

	// Token: 0x04018380 RID: 99200
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheC1;

	// Token: 0x04018381 RID: 99201
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheC2;

	// Token: 0x04018382 RID: 99202
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheC3;

	// Token: 0x04018383 RID: 99203
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheC4;

	// Token: 0x04018384 RID: 99204
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheC5;

	// Token: 0x04018385 RID: 99205
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheC6;

	// Token: 0x04018386 RID: 99206
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheC7;

	// Token: 0x04018387 RID: 99207
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheC8;

	// Token: 0x04018388 RID: 99208
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheC9;

	// Token: 0x04018389 RID: 99209
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheCA;

	// Token: 0x0401838A RID: 99210
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheCB;

	// Token: 0x0401838B RID: 99211
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheCC;

	// Token: 0x0401838C RID: 99212
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheCD;

	// Token: 0x0401838D RID: 99213
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheCE;

	// Token: 0x0401838E RID: 99214
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheCF;

	// Token: 0x0401838F RID: 99215
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheD0;

	// Token: 0x04018390 RID: 99216
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheD1;

	// Token: 0x04018391 RID: 99217
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheD2;

	// Token: 0x04018392 RID: 99218
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheD3;

	// Token: 0x04018393 RID: 99219
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheD4;

	// Token: 0x04018394 RID: 99220
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheD5;

	// Token: 0x04018395 RID: 99221
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheD6;

	// Token: 0x04018396 RID: 99222
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheD7;

	// Token: 0x04018397 RID: 99223
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheD8;

	// Token: 0x04018398 RID: 99224
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheD9;

	// Token: 0x04018399 RID: 99225
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheDA;

	// Token: 0x0401839A RID: 99226
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheDB;

	// Token: 0x0401839B RID: 99227
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheDC;

	// Token: 0x0401839C RID: 99228
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheDD;

	// Token: 0x0401839D RID: 99229
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheDE;

	// Token: 0x0401839E RID: 99230
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheDF;

	// Token: 0x0401839F RID: 99231
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheE0;

	// Token: 0x040183A0 RID: 99232
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheE1;

	// Token: 0x040183A1 RID: 99233
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheE2;

	// Token: 0x040183A2 RID: 99234
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheE3;

	// Token: 0x040183A3 RID: 99235
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheE4;

	// Token: 0x040183A4 RID: 99236
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheE5;

	// Token: 0x040183A5 RID: 99237
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheE6;

	// Token: 0x040183A6 RID: 99238
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheE7;

	// Token: 0x040183A7 RID: 99239
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheE8;

	// Token: 0x040183A8 RID: 99240
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheE9;

	// Token: 0x040183A9 RID: 99241
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheEA;

	// Token: 0x040183AA RID: 99242
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheEB;

	// Token: 0x040183AB RID: 99243
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheEC;

	// Token: 0x040183AC RID: 99244
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheED;

	// Token: 0x040183AD RID: 99245
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheEE;

	// Token: 0x040183AE RID: 99246
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheEF;

	// Token: 0x040183AF RID: 99247
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheF0;

	// Token: 0x040183B0 RID: 99248
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheF1;

	// Token: 0x040183B1 RID: 99249
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheF2;

	// Token: 0x040183B2 RID: 99250
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheF3;

	// Token: 0x040183B3 RID: 99251
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheF4;

	// Token: 0x040183B4 RID: 99252
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheF5;

	// Token: 0x040183B5 RID: 99253
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheF6;

	// Token: 0x040183B6 RID: 99254
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheF7;

	// Token: 0x040183B7 RID: 99255
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheF8;

	// Token: 0x040183B8 RID: 99256
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheF9;

	// Token: 0x040183B9 RID: 99257
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheFA;

	// Token: 0x040183BA RID: 99258
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheFB;

	// Token: 0x040183BB RID: 99259
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheFC;

	// Token: 0x040183BC RID: 99260
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheFD;

	// Token: 0x040183BD RID: 99261
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheFE;

	// Token: 0x040183BE RID: 99262
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheFF;

	// Token: 0x040183BF RID: 99263
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache100;

	// Token: 0x040183C0 RID: 99264
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache101;

	// Token: 0x040183C1 RID: 99265
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache102;

	// Token: 0x040183C2 RID: 99266
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache103;

	// Token: 0x040183C3 RID: 99267
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache104;

	// Token: 0x040183C4 RID: 99268
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache105;

	// Token: 0x040183C5 RID: 99269
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache106;

	// Token: 0x040183C6 RID: 99270
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache107;

	// Token: 0x040183C7 RID: 99271
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache108;

	// Token: 0x040183C8 RID: 99272
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache109;

	// Token: 0x040183C9 RID: 99273
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache10A;

	// Token: 0x040183CA RID: 99274
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache10B;

	// Token: 0x040183CB RID: 99275
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache10C;

	// Token: 0x040183CC RID: 99276
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache10D;

	// Token: 0x040183CD RID: 99277
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache10E;

	// Token: 0x040183CE RID: 99278
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache10F;

	// Token: 0x040183CF RID: 99279
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache110;

	// Token: 0x040183D0 RID: 99280
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache111;

	// Token: 0x040183D1 RID: 99281
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache112;

	// Token: 0x040183D2 RID: 99282
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache113;

	// Token: 0x040183D3 RID: 99283
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache114;

	// Token: 0x040183D4 RID: 99284
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache115;

	// Token: 0x040183D5 RID: 99285
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache116;

	// Token: 0x040183D6 RID: 99286
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache117;

	// Token: 0x040183D7 RID: 99287
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache118;

	// Token: 0x040183D8 RID: 99288
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache119;

	// Token: 0x040183D9 RID: 99289
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache11A;

	// Token: 0x040183DA RID: 99290
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache11B;

	// Token: 0x040183DB RID: 99291
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache11C;

	// Token: 0x040183DC RID: 99292
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache11D;

	// Token: 0x040183DD RID: 99293
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache11E;

	// Token: 0x040183DE RID: 99294
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache11F;

	// Token: 0x040183DF RID: 99295
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache120;

	// Token: 0x040183E0 RID: 99296
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache121;

	// Token: 0x040183E1 RID: 99297
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache122;

	// Token: 0x040183E2 RID: 99298
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache123;

	// Token: 0x040183E3 RID: 99299
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache124;

	// Token: 0x040183E4 RID: 99300
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache125;

	// Token: 0x040183E5 RID: 99301
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache126;

	// Token: 0x040183E6 RID: 99302
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache127;

	// Token: 0x040183E7 RID: 99303
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache128;

	// Token: 0x040183E8 RID: 99304
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache129;

	// Token: 0x040183E9 RID: 99305
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache12A;

	// Token: 0x040183EA RID: 99306
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache12B;

	// Token: 0x040183EB RID: 99307
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache12C;

	// Token: 0x040183EC RID: 99308
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache12D;

	// Token: 0x040183ED RID: 99309
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache12E;

	// Token: 0x040183EE RID: 99310
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache12F;

	// Token: 0x040183EF RID: 99311
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache130;

	// Token: 0x040183F0 RID: 99312
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache131;

	// Token: 0x040183F1 RID: 99313
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache132;

	// Token: 0x040183F2 RID: 99314
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache133;

	// Token: 0x040183F3 RID: 99315
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache134;

	// Token: 0x040183F4 RID: 99316
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache135;

	// Token: 0x040183F5 RID: 99317
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache136;

	// Token: 0x040183F6 RID: 99318
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache137;

	// Token: 0x040183F7 RID: 99319
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache138;

	// Token: 0x040183F8 RID: 99320
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache139;

	// Token: 0x040183F9 RID: 99321
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache13A;

	// Token: 0x040183FA RID: 99322
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache13B;

	// Token: 0x040183FB RID: 99323
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache13C;

	// Token: 0x040183FC RID: 99324
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache13D;

	// Token: 0x040183FD RID: 99325
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache13E;

	// Token: 0x040183FE RID: 99326
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache13F;

	// Token: 0x040183FF RID: 99327
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache140;

	// Token: 0x04018400 RID: 99328
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache141;

	// Token: 0x04018401 RID: 99329
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache142;

	// Token: 0x04018402 RID: 99330
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache143;

	// Token: 0x04018403 RID: 99331
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache144;

	// Token: 0x04018404 RID: 99332
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache145;

	// Token: 0x04018405 RID: 99333
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache146;

	// Token: 0x04018406 RID: 99334
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache147;

	// Token: 0x04018407 RID: 99335
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache148;

	// Token: 0x04018408 RID: 99336
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache149;

	// Token: 0x04018409 RID: 99337
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache14A;

	// Token: 0x0401840A RID: 99338
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache14B;

	// Token: 0x0401840B RID: 99339
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache14C;

	// Token: 0x0401840C RID: 99340
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache14D;

	// Token: 0x0401840D RID: 99341
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache14E;

	// Token: 0x0401840E RID: 99342
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache14F;

	// Token: 0x0401840F RID: 99343
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache150;

	// Token: 0x04018410 RID: 99344
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache151;

	// Token: 0x04018411 RID: 99345
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache152;

	// Token: 0x04018412 RID: 99346
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache153;

	// Token: 0x04018413 RID: 99347
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache154;

	// Token: 0x04018414 RID: 99348
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache155;

	// Token: 0x04018415 RID: 99349
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache156;

	// Token: 0x04018416 RID: 99350
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache157;

	// Token: 0x04018417 RID: 99351
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache158;

	// Token: 0x04018418 RID: 99352
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache159;

	// Token: 0x04018419 RID: 99353
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache15A;

	// Token: 0x0401841A RID: 99354
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache15B;

	// Token: 0x0401841B RID: 99355
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache15C;

	// Token: 0x0401841C RID: 99356
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache15D;

	// Token: 0x0401841D RID: 99357
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache15E;

	// Token: 0x0401841E RID: 99358
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache15F;

	// Token: 0x0401841F RID: 99359
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache160;

	// Token: 0x04018420 RID: 99360
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache161;

	// Token: 0x04018421 RID: 99361
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache162;

	// Token: 0x04018422 RID: 99362
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache163;

	// Token: 0x04018423 RID: 99363
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache164;

	// Token: 0x04018424 RID: 99364
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache165;

	// Token: 0x04018425 RID: 99365
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache166;

	// Token: 0x04018426 RID: 99366
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache167;

	// Token: 0x04018427 RID: 99367
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache168;

	// Token: 0x04018428 RID: 99368
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache169;

	// Token: 0x04018429 RID: 99369
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache16A;

	// Token: 0x0401842A RID: 99370
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache16B;

	// Token: 0x0401842B RID: 99371
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache16C;

	// Token: 0x0401842C RID: 99372
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache16D;

	// Token: 0x0401842D RID: 99373
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache16E;

	// Token: 0x0401842E RID: 99374
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache16F;

	// Token: 0x0401842F RID: 99375
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache170;

	// Token: 0x04018430 RID: 99376
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache171;

	// Token: 0x04018431 RID: 99377
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache172;

	// Token: 0x04018432 RID: 99378
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache173;

	// Token: 0x04018433 RID: 99379
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache174;

	// Token: 0x04018434 RID: 99380
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache175;

	// Token: 0x04018435 RID: 99381
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache176;

	// Token: 0x04018436 RID: 99382
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache177;
}
