using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using BlackJack.BJFramework.Runtime.UI;
using BlackJack.ConfigData;
using BlackJack.ProjectL.Common;
using BlackJack.ProjectL.UI;
using BlackJack.ProjectLBasic;
using SLua;
using UnityEngine.Scripting;

// Token: 0x020015A9 RID: 5545
[Preserve]
public class Lua_BlackJack_ProjectL_UI_TeamUITask : LuaObject
{
	// Token: 0x0602197E RID: 137598 RVA: 0x00B625F8 File Offset: 0x00B607F8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int constructor(IntPtr l)
	{
		int result;
		try
		{
			string name;
			LuaObject.checkType(l, 2, out name);
			TeamUITask o = new TeamUITask(name);
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

	// Token: 0x0602197F RID: 137599 RVA: 0x00B6264C File Offset: 0x00B6084C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int CreateIntent_s(IntPtr l)
	{
		int result;
		try
		{
			UIIntent fromIntent;
			LuaObject.checkType<UIIntent>(l, 1, out fromIntent);
			GameFunctionType gameFunctionType;
			LuaObject.checkEnum<GameFunctionType>(l, 2, out gameFunctionType);
			int chapterId;
			LuaObject.checkType(l, 3, out chapterId);
			int locationId;
			LuaObject.checkType(l, 4, out locationId);
			UIIntentReturnable o = TeamUITask.CreateIntent(fromIntent, gameFunctionType, chapterId, locationId);
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

	// Token: 0x06021980 RID: 137600 RVA: 0x00B626C8 File Offset: 0x00B608C8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int IsNeedLoadDynamicRes(IntPtr l)
	{
		int result;
		try
		{
			TeamUITask teamUITask = (TeamUITask)LuaObject.checkSelf(l);
			bool b = teamUITask.m_luaExportHelper.IsNeedLoadDynamicRes();
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

	// Token: 0x06021981 RID: 137601 RVA: 0x00B62724 File Offset: 0x00B60924
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int InitLayerStateOnLoadAllResCompleted(IntPtr l)
	{
		int result;
		try
		{
			TeamUITask teamUITask = (TeamUITask)LuaObject.checkSelf(l);
			teamUITask.m_luaExportHelper.InitLayerStateOnLoadAllResCompleted();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06021982 RID: 137602 RVA: 0x00B62778 File Offset: 0x00B60978
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int InitAllUIControllers(IntPtr l)
	{
		int result;
		try
		{
			TeamUITask teamUITask = (TeamUITask)LuaObject.checkSelf(l);
			teamUITask.m_luaExportHelper.InitAllUIControllers();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06021983 RID: 137603 RVA: 0x00B627CC File Offset: 0x00B609CC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int ClearAllContextAndRes(IntPtr l)
	{
		int result;
		try
		{
			TeamUITask teamUITask = (TeamUITask)LuaObject.checkSelf(l);
			teamUITask.m_luaExportHelper.ClearAllContextAndRes();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06021984 RID: 137604 RVA: 0x00B62820 File Offset: 0x00B60A20
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int RegisterPlayerContextEvents(IntPtr l)
	{
		int result;
		try
		{
			TeamUITask teamUITask = (TeamUITask)LuaObject.checkSelf(l);
			teamUITask.m_luaExportHelper.RegisterPlayerContextEvents();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06021985 RID: 137605 RVA: 0x00B62874 File Offset: 0x00B60A74
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int UnregisterPlayerContextEvents(IntPtr l)
	{
		int result;
		try
		{
			TeamUITask teamUITask = (TeamUITask)LuaObject.checkSelf(l);
			teamUITask.m_luaExportHelper.UnregisterPlayerContextEvents();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06021986 RID: 137606 RVA: 0x00B628C8 File Offset: 0x00B60AC8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int InitTeamUIController(IntPtr l)
	{
		int result;
		try
		{
			TeamUITask teamUITask = (TeamUITask)LuaObject.checkSelf(l);
			teamUITask.m_luaExportHelper.InitTeamUIController();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06021987 RID: 137607 RVA: 0x00B6291C File Offset: 0x00B60B1C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int UninitTeamUIController(IntPtr l)
	{
		int result;
		try
		{
			TeamUITask teamUITask = (TeamUITask)LuaObject.checkSelf(l);
			teamUITask.m_luaExportHelper.UninitTeamUIController();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06021988 RID: 137608 RVA: 0x00B62970 File Offset: 0x00B60B70
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int InitCreateTeamRoomUIController(IntPtr l)
	{
		int result;
		try
		{
			TeamUITask teamUITask = (TeamUITask)LuaObject.checkSelf(l);
			teamUITask.m_luaExportHelper.InitCreateTeamRoomUIController();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06021989 RID: 137609 RVA: 0x00B629C4 File Offset: 0x00B60BC4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int UninitCreateTeamRoomUIController(IntPtr l)
	{
		int result;
		try
		{
			TeamUITask teamUITask = (TeamUITask)LuaObject.checkSelf(l);
			teamUITask.m_luaExportHelper.UninitCreateTeamRoomUIController();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0602198A RID: 137610 RVA: 0x00B62A18 File Offset: 0x00B60C18
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int UpdateView(IntPtr l)
	{
		int result;
		try
		{
			TeamUITask teamUITask = (TeamUITask)LuaObject.checkSelf(l);
			teamUITask.m_luaExportHelper.UpdateView();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0602198B RID: 137611 RVA: 0x00B62A6C File Offset: 0x00B60C6C
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int OnTick(IntPtr l)
	{
		int result;
		try
		{
			TeamUITask teamUITask = (TeamUITask)LuaObject.checkSelf(l);
			teamUITask.m_luaExportHelper.OnTick();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0602198C RID: 137612 RVA: 0x00B62AC0 File Offset: 0x00B60CC0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int StartTeamRoomInviteNetTask(IntPtr l)
	{
		int result;
		try
		{
			TeamUITask teamUITask = (TeamUITask)LuaObject.checkSelf(l);
			List<string> userIds;
			LuaObject.checkType<List<string>>(l, 2, out userIds);
			teamUITask.m_luaExportHelper.StartTeamRoomInviteNetTask(userIds);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0602198D RID: 137613 RVA: 0x00B62B1C File Offset: 0x00B60D1C
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int CheckTeamRoomInviteAgain(IntPtr l)
	{
		int result;
		try
		{
			TeamUITask teamUITask = (TeamUITask)LuaObject.checkSelf(l);
			bool b = teamUITask.m_luaExportHelper.CheckTeamRoomInviteAgain();
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

	// Token: 0x0602198E RID: 137614 RVA: 0x00B62B78 File Offset: 0x00B60D78
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int CheckOpenTeamRoomInfoUI(IntPtr l)
	{
		int result;
		try
		{
			TeamUITask teamUITask = (TeamUITask)LuaObject.checkSelf(l);
			bool b = teamUITask.m_luaExportHelper.CheckOpenTeamRoomInfoUI();
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

	// Token: 0x0602198F RID: 137615 RVA: 0x00B62BD4 File Offset: 0x00B60DD4
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int StartTeamRoomInfoUITask(IntPtr l)
	{
		int result;
		try
		{
			TeamUITask teamUITask = (TeamUITask)LuaObject.checkSelf(l);
			teamUITask.m_luaExportHelper.StartTeamRoomInfoUITask();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06021990 RID: 137616 RVA: 0x00B62C28 File Offset: 0x00B60E28
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int TeamRoomInfoUITask_OnClose(IntPtr l)
	{
		int result;
		try
		{
			TeamUITask teamUITask = (TeamUITask)LuaObject.checkSelf(l);
			teamUITask.m_luaExportHelper.TeamRoomInfoUITask_OnClose();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06021991 RID: 137617 RVA: 0x00B62C7C File Offset: 0x00B60E7C
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int RefreshTeamRoom(IntPtr l)
	{
		int result;
		try
		{
			TeamUITask teamUITask = (TeamUITask)LuaObject.checkSelf(l);
			bool checkRefreshTime;
			LuaObject.checkType(l, 2, out checkRefreshTime);
			teamUITask.m_luaExportHelper.RefreshTeamRoom(checkRefreshTime);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06021992 RID: 137618 RVA: 0x00B62CD8 File Offset: 0x00B60ED8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int TeamUIController_OnReturn(IntPtr l)
	{
		int result;
		try
		{
			TeamUITask teamUITask = (TeamUITask)LuaObject.checkSelf(l);
			teamUITask.m_luaExportHelper.TeamUIController_OnReturn();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06021993 RID: 137619 RVA: 0x00B62D2C File Offset: 0x00B60F2C
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int TeamUIController_OnShowHelp(IntPtr l)
	{
		int result;
		try
		{
			TeamUITask teamUITask = (TeamUITask)LuaObject.checkSelf(l);
			teamUITask.m_luaExportHelper.TeamUIController_OnShowHelp();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06021994 RID: 137620 RVA: 0x00B62D80 File Offset: 0x00B60F80
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int TeamUIController_OnRefreshTeamRoom(IntPtr l)
	{
		int result;
		try
		{
			TeamUITask teamUITask = (TeamUITask)LuaObject.checkSelf(l);
			teamUITask.m_luaExportHelper.TeamUIController_OnRefreshTeamRoom();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06021995 RID: 137621 RVA: 0x00B62DD4 File Offset: 0x00B60FD4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int TeamUIController_OnShowCreateTeamRoom(IntPtr l)
	{
		int result;
		try
		{
			TeamUITask teamUITask = (TeamUITask)LuaObject.checkSelf(l);
			teamUITask.m_luaExportHelper.TeamUIController_OnShowCreateTeamRoom();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06021996 RID: 137622 RVA: 0x00B62E28 File Offset: 0x00B61028
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int TeamUIController_OnAutoMatch(IntPtr l)
	{
		int result;
		try
		{
			TeamUITask teamUITask = (TeamUITask)LuaObject.checkSelf(l);
			teamUITask.m_luaExportHelper.TeamUIController_OnAutoMatch();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06021997 RID: 137623 RVA: 0x00B62E7C File Offset: 0x00B6107C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int TeamUIController_OnAutoMatchCancel(IntPtr l)
	{
		int result;
		try
		{
			TeamUITask teamUITask = (TeamUITask)LuaObject.checkSelf(l);
			teamUITask.m_luaExportHelper.TeamUIController_OnAutoMatchCancel();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06021998 RID: 137624 RVA: 0x00B62ED0 File Offset: 0x00B610D0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int AutoMatchCancelDialogBoxCallback(IntPtr l)
	{
		int result;
		try
		{
			TeamUITask teamUITask = (TeamUITask)LuaObject.checkSelf(l);
			DialogBoxResult r;
			LuaObject.checkEnum<DialogBoxResult>(l, 2, out r);
			teamUITask.m_luaExportHelper.AutoMatchCancelDialogBoxCallback(r);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06021999 RID: 137625 RVA: 0x00B62F2C File Offset: 0x00B6112C
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int TeamUIController_OnSelectGameFunctionTypeAndLocation(IntPtr l)
	{
		int result;
		try
		{
			TeamUITask teamUITask = (TeamUITask)LuaObject.checkSelf(l);
			GameFunctionType gameFunctionType;
			LuaObject.checkEnum<GameFunctionType>(l, 2, out gameFunctionType);
			int locationId;
			LuaObject.checkType(l, 3, out locationId);
			teamUITask.m_luaExportHelper.TeamUIController_OnSelectGameFunctionTypeAndLocation(gameFunctionType, locationId);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0602199A RID: 137626 RVA: 0x00B62F98 File Offset: 0x00B61198
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int TeamUIController_OnJoinTeamRoom(IntPtr l)
	{
		int result;
		try
		{
			TeamUITask teamUITask = (TeamUITask)LuaObject.checkSelf(l);
			int roomId;
			LuaObject.checkType(l, 2, out roomId);
			GameFunctionType gameFunctionType;
			LuaObject.checkEnum<GameFunctionType>(l, 3, out gameFunctionType);
			int locationId;
			LuaObject.checkType(l, 4, out locationId);
			teamUITask.m_luaExportHelper.TeamUIController_OnJoinTeamRoom(roomId, gameFunctionType, locationId);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0602199B RID: 137627 RVA: 0x00B63010 File Offset: 0x00B61210
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int HandleJoinTeamRoomResultError(IntPtr l)
	{
		int result2;
		try
		{
			TeamUITask teamUITask = (TeamUITask)LuaObject.checkSelf(l);
			int result;
			LuaObject.checkType(l, 2, out result);
			teamUITask.m_luaExportHelper.HandleJoinTeamRoomResultError(result);
			LuaObject.pushValue(l, true);
			result2 = 1;
		}
		catch (Exception e)
		{
			result2 = LuaObject.error(l, e);
		}
		return result2;
	}

	// Token: 0x0602199C RID: 137628 RVA: 0x00B6306C File Offset: 0x00B6126C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int CreateTeamRoomUIController_OnCreateTeamRoom(IntPtr l)
	{
		int result;
		try
		{
			TeamUITask teamUITask = (TeamUITask)LuaObject.checkSelf(l);
			TeamRoomSetting setting;
			LuaObject.checkType<TeamRoomSetting>(l, 2, out setting);
			teamUITask.m_luaExportHelper.CreateTeamRoomUIController_OnCreateTeamRoom(setting);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0602199D RID: 137629 RVA: 0x00B630C8 File Offset: 0x00B612C8
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int PlayerContext_OnTeamRoomPlayerLeaveWaitingListAndJoinRoomNtf(IntPtr l)
	{
		int result;
		try
		{
			TeamUITask teamUITask = (TeamUITask)LuaObject.checkSelf(l);
			teamUITask.m_luaExportHelper.PlayerContext_OnTeamRoomPlayerLeaveWaitingListAndJoinRoomNtf();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0602199E RID: 137630 RVA: 0x00B6311C File Offset: 0x00B6131C
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int PlayerContext_OnTeamRoomAutoMatchInfoNtf(IntPtr l)
	{
		int result;
		try
		{
			TeamUITask teamUITask = (TeamUITask)LuaObject.checkSelf(l);
			int frontOfYouWaitingNums;
			LuaObject.checkType(l, 2, out frontOfYouWaitingNums);
			teamUITask.m_luaExportHelper.PlayerContext_OnTeamRoomAutoMatchInfoNtf(frontOfYouWaitingNums);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0602199F RID: 137631 RVA: 0x00B63178 File Offset: 0x00B61378
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int PlayerContext_OnPlayerInfoInitEnd(IntPtr l)
	{
		int result;
		try
		{
			TeamUITask teamUITask = (TeamUITask)LuaObject.checkSelf(l);
			teamUITask.m_luaExportHelper.PlayerContext_OnPlayerInfoInitEnd();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060219A0 RID: 137632 RVA: 0x00B631CC File Offset: 0x00B613CC
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int __callBase_OnStart(IntPtr l)
	{
		int result;
		try
		{
			TeamUITask teamUITask = (TeamUITask)LuaObject.checkSelf(l);
			UIIntent intent;
			LuaObject.checkType<UIIntent>(l, 2, out intent);
			bool b = teamUITask.m_luaExportHelper.__callBase_OnStart(intent);
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

	// Token: 0x060219A1 RID: 137633 RVA: 0x00B63234 File Offset: 0x00B61434
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_OnStop(IntPtr l)
	{
		int result;
		try
		{
			TeamUITask teamUITask = (TeamUITask)LuaObject.checkSelf(l);
			teamUITask.m_luaExportHelper.__callBase_OnStop();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060219A2 RID: 137634 RVA: 0x00B63288 File Offset: 0x00B61488
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_OnPause(IntPtr l)
	{
		int result;
		try
		{
			TeamUITask teamUITask = (TeamUITask)LuaObject.checkSelf(l);
			teamUITask.m_luaExportHelper.__callBase_OnPause();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060219A3 RID: 137635 RVA: 0x00B632DC File Offset: 0x00B614DC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_OnResume(IntPtr l)
	{
		int result;
		try
		{
			TeamUITask teamUITask = (TeamUITask)LuaObject.checkSelf(l);
			UIIntent intent;
			LuaObject.checkType<UIIntent>(l, 2, out intent);
			bool b = teamUITask.m_luaExportHelper.__callBase_OnResume(intent);
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

	// Token: 0x060219A4 RID: 137636 RVA: 0x00B63344 File Offset: 0x00B61544
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int __callBase_OnNewIntent(IntPtr l)
	{
		int result;
		try
		{
			TeamUITask teamUITask = (TeamUITask)LuaObject.checkSelf(l);
			UIIntent intent;
			LuaObject.checkType<UIIntent>(l, 2, out intent);
			bool b = teamUITask.m_luaExportHelper.__callBase_OnNewIntent(intent);
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

	// Token: 0x060219A5 RID: 137637 RVA: 0x00B633AC File Offset: 0x00B615AC
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int __callBase_EnableUIInput(IntPtr l)
	{
		int result;
		try
		{
			TeamUITask teamUITask = (TeamUITask)LuaObject.checkSelf(l);
			bool isEnable;
			LuaObject.checkType(l, 2, out isEnable);
			bool? isGlobalEnable;
			LuaObject.checkNullable<bool>(l, 3, out isGlobalEnable);
			teamUITask.m_luaExportHelper.__callBase_EnableUIInput(isEnable, isGlobalEnable);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060219A6 RID: 137638 RVA: 0x00B63418 File Offset: 0x00B61618
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_IsNeedLoadDynamicRes(IntPtr l)
	{
		int result;
		try
		{
			TeamUITask teamUITask = (TeamUITask)LuaObject.checkSelf(l);
			bool b = teamUITask.m_luaExportHelper.__callBase_IsNeedLoadDynamicRes();
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

	// Token: 0x060219A7 RID: 137639 RVA: 0x00B63474 File Offset: 0x00B61674
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_CollectAllDynamicResForLoad(IntPtr l)
	{
		int result;
		try
		{
			TeamUITask teamUITask = (TeamUITask)LuaObject.checkSelf(l);
			List<string> o = teamUITask.m_luaExportHelper.__callBase_CollectAllDynamicResForLoad();
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

	// Token: 0x060219A8 RID: 137640 RVA: 0x00B634D0 File Offset: 0x00B616D0
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int __callBase_RegisterPlayerContextEvents(IntPtr l)
	{
		int result;
		try
		{
			TeamUITask teamUITask = (TeamUITask)LuaObject.checkSelf(l);
			teamUITask.m_luaExportHelper.__callBase_RegisterPlayerContextEvents();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060219A9 RID: 137641 RVA: 0x00B63524 File Offset: 0x00B61724
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int __callBase_UnregisterPlayerContextEvents(IntPtr l)
	{
		int result;
		try
		{
			TeamUITask teamUITask = (TeamUITask)LuaObject.checkSelf(l);
			teamUITask.m_luaExportHelper.__callBase_UnregisterPlayerContextEvents();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060219AA RID: 137642 RVA: 0x00B63578 File Offset: 0x00B61778
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_PostUpdateView(IntPtr l)
	{
		int result;
		try
		{
			TeamUITask teamUITask = (TeamUITask)LuaObject.checkSelf(l);
			teamUITask.m_luaExportHelper.__callBase_PostUpdateView();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060219AB RID: 137643 RVA: 0x00B635CC File Offset: 0x00B617CC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_CollectPreloadResourceList(IntPtr l)
	{
		int result;
		try
		{
			TeamUITask teamUITask = (TeamUITask)LuaObject.checkSelf(l);
			teamUITask.m_luaExportHelper.__callBase_CollectPreloadResourceList();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060219AC RID: 137644 RVA: 0x00B63620 File Offset: 0x00B61820
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_ClearAssetList(IntPtr l)
	{
		int result;
		try
		{
			TeamUITask teamUITask = (TeamUITask)LuaObject.checkSelf(l);
			teamUITask.m_luaExportHelper.__callBase_ClearAssetList();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060219AD RID: 137645 RVA: 0x00B63674 File Offset: 0x00B61874
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_CollectAsset(IntPtr l)
	{
		int result;
		try
		{
			TeamUITask teamUITask = (TeamUITask)LuaObject.checkSelf(l);
			string assetName;
			LuaObject.checkType(l, 2, out assetName);
			teamUITask.m_luaExportHelper.__callBase_CollectAsset(assetName);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060219AE RID: 137646 RVA: 0x00B636D0 File Offset: 0x00B618D0
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int __callBase_CollectSpriteAsset(IntPtr l)
	{
		int result;
		try
		{
			TeamUITask teamUITask = (TeamUITask)LuaObject.checkSelf(l);
			string assetName;
			LuaObject.checkType(l, 2, out assetName);
			teamUITask.m_luaExportHelper.__callBase_CollectSpriteAsset(assetName);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060219AF RID: 137647 RVA: 0x00B6372C File Offset: 0x00B6192C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_CollectFxAsset(IntPtr l)
	{
		int result;
		try
		{
			TeamUITask teamUITask = (TeamUITask)LuaObject.checkSelf(l);
			string assetName;
			LuaObject.checkType(l, 2, out assetName);
			teamUITask.m_luaExportHelper.__callBase_CollectFxAsset(assetName);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060219B0 RID: 137648 RVA: 0x00B63788 File Offset: 0x00B61988
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_StartLoadCustomAssets(IntPtr l)
	{
		int result;
		try
		{
			TeamUITask teamUITask = (TeamUITask)LuaObject.checkSelf(l);
			Action onLoadCompleted;
			LuaObject.checkDelegate<Action>(l, 2, out onLoadCompleted);
			teamUITask.m_luaExportHelper.__callBase_StartLoadCustomAssets(onLoadCompleted);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060219B1 RID: 137649 RVA: 0x00B637E4 File Offset: 0x00B619E4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_IsLoadingCustomAssets(IntPtr l)
	{
		int result;
		try
		{
			TeamUITask teamUITask = (TeamUITask)LuaObject.checkSelf(l);
			bool b = teamUITask.m_luaExportHelper.__callBase_IsLoadingCustomAssets();
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

	// Token: 0x060219B2 RID: 137650 RVA: 0x00B63840 File Offset: 0x00B61A40
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_IsPipeLineRunning(IntPtr l)
	{
		int result;
		try
		{
			TeamUITask teamUITask = (TeamUITask)LuaObject.checkSelf(l);
			bool b = teamUITask.m_luaExportHelper.__callBase_IsPipeLineRunning();
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

	// Token: 0x060219B3 RID: 137651 RVA: 0x00B6389C File Offset: 0x00B61A9C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_IsOpeningUI(IntPtr l)
	{
		int result;
		try
		{
			TeamUITask teamUITask = (TeamUITask)LuaObject.checkSelf(l);
			bool b = teamUITask.m_luaExportHelper.__callBase_IsOpeningUI();
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

	// Token: 0x060219B4 RID: 137652 RVA: 0x00B638F8 File Offset: 0x00B61AF8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_ReturnPrevUITask(IntPtr l)
	{
		int result;
		try
		{
			TeamUITask teamUITask = (TeamUITask)LuaObject.checkSelf(l);
			UITaskBase o = teamUITask.m_luaExportHelper.__callBase_ReturnPrevUITask();
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

	// Token: 0x060219B5 RID: 137653 RVA: 0x00B63954 File Offset: 0x00B61B54
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_ClearUnusedDynamicResourceCache(IntPtr l)
	{
		int result;
		try
		{
			TeamUITask teamUITask = (TeamUITask)LuaObject.checkSelf(l);
			teamUITask.m_luaExportHelper.__callBase_ClearUnusedDynamicResourceCache();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060219B6 RID: 137654 RVA: 0x00B639A8 File Offset: 0x00B61BA8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_OnMemoryWarning(IntPtr l)
	{
		int result;
		try
		{
			TeamUITask teamUITask = (TeamUITask)LuaObject.checkSelf(l);
			teamUITask.m_luaExportHelper.__callBase_OnMemoryWarning();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060219B7 RID: 137655 RVA: 0x00B639FC File Offset: 0x00B61BFC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int TeamRoomInfoUITask_OnLoadAllResCompleted_s(IntPtr l)
	{
		int result;
		try
		{
			TeamUITask.LuaExportHelper.TeamRoomInfoUITask_OnLoadAllResCompleted();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060219B8 RID: 137656 RVA: 0x00B63A3C File Offset: 0x00B61C3C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_layerDescArray(IntPtr l)
	{
		int result;
		try
		{
			TeamUITask teamUITask = (TeamUITask)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, teamUITask.m_luaExportHelper.m_layerDescArray);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060219B9 RID: 137657 RVA: 0x00B63A94 File Offset: 0x00B61C94
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_m_layerDescArray(IntPtr l)
	{
		int result;
		try
		{
			TeamUITask teamUITask = (TeamUITask)LuaObject.checkSelf(l);
			UITaskBase.LayerDesc[] layerDescArray;
			LuaObject.checkArray<UITaskBase.LayerDesc>(l, 2, out layerDescArray);
			teamUITask.m_luaExportHelper.m_layerDescArray = layerDescArray;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060219BA RID: 137658 RVA: 0x00B63AF0 File Offset: 0x00B61CF0
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_m_uiCtrlDescArray(IntPtr l)
	{
		int result;
		try
		{
			TeamUITask teamUITask = (TeamUITask)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, teamUITask.m_luaExportHelper.m_uiCtrlDescArray);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060219BB RID: 137659 RVA: 0x00B63B48 File Offset: 0x00B61D48
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_uiCtrlDescArray(IntPtr l)
	{
		int result;
		try
		{
			TeamUITask teamUITask = (TeamUITask)LuaObject.checkSelf(l);
			UITaskBase.UIControllerDesc[] uiCtrlDescArray;
			LuaObject.checkArray<UITaskBase.UIControllerDesc>(l, 2, out uiCtrlDescArray);
			teamUITask.m_luaExportHelper.m_uiCtrlDescArray = uiCtrlDescArray;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060219BC RID: 137660 RVA: 0x00B63BA4 File Offset: 0x00B61DA4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_teamUIController(IntPtr l)
	{
		int result;
		try
		{
			TeamUITask teamUITask = (TeamUITask)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, teamUITask.m_luaExportHelper.m_teamUIController);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060219BD RID: 137661 RVA: 0x00B63BFC File Offset: 0x00B61DFC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_teamUIController(IntPtr l)
	{
		int result;
		try
		{
			TeamUITask teamUITask = (TeamUITask)LuaObject.checkSelf(l);
			TeamUIController teamUIController;
			LuaObject.checkType<TeamUIController>(l, 2, out teamUIController);
			teamUITask.m_luaExportHelper.m_teamUIController = teamUIController;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060219BE RID: 137662 RVA: 0x00B63C58 File Offset: 0x00B61E58
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_playerResourceUIController(IntPtr l)
	{
		int result;
		try
		{
			TeamUITask teamUITask = (TeamUITask)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, teamUITask.m_luaExportHelper.m_playerResourceUIController);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060219BF RID: 137663 RVA: 0x00B63CB0 File Offset: 0x00B61EB0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_playerResourceUIController(IntPtr l)
	{
		int result;
		try
		{
			TeamUITask teamUITask = (TeamUITask)LuaObject.checkSelf(l);
			PlayerResourceUIController playerResourceUIController;
			LuaObject.checkType<PlayerResourceUIController>(l, 2, out playerResourceUIController);
			teamUITask.m_luaExportHelper.m_playerResourceUIController = playerResourceUIController;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060219C0 RID: 137664 RVA: 0x00B63D0C File Offset: 0x00B61F0C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_createTeamRoomUIController(IntPtr l)
	{
		int result;
		try
		{
			TeamUITask teamUITask = (TeamUITask)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, teamUITask.m_luaExportHelper.m_createTeamRoomUIController);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060219C1 RID: 137665 RVA: 0x00B63D64 File Offset: 0x00B61F64
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_createTeamRoomUIController(IntPtr l)
	{
		int result;
		try
		{
			TeamUITask teamUITask = (TeamUITask)LuaObject.checkSelf(l);
			CreateTeamRoomUIController createTeamRoomUIController;
			LuaObject.checkType<CreateTeamRoomUIController>(l, 2, out createTeamRoomUIController);
			teamUITask.m_luaExportHelper.m_createTeamRoomUIController = createTeamRoomUIController;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060219C2 RID: 137666 RVA: 0x00B63DC0 File Offset: 0x00B61FC0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_teamRoomInfoUITask(IntPtr l)
	{
		int result;
		try
		{
			TeamUITask teamUITask = (TeamUITask)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, teamUITask.m_luaExportHelper.m_teamRoomInfoUITask);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060219C3 RID: 137667 RVA: 0x00B63E18 File Offset: 0x00B62018
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_teamRoomInfoUITask(IntPtr l)
	{
		int result;
		try
		{
			TeamUITask teamUITask = (TeamUITask)LuaObject.checkSelf(l);
			TeamRoomInfoUITask teamRoomInfoUITask;
			LuaObject.checkType<TeamRoomInfoUITask>(l, 2, out teamRoomInfoUITask);
			teamUITask.m_luaExportHelper.m_teamRoomInfoUITask = teamRoomInfoUITask;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060219C4 RID: 137668 RVA: 0x00B63E74 File Offset: 0x00B62074
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_lastRefreshGameFunctionType(IntPtr l)
	{
		int result;
		try
		{
			TeamUITask teamUITask = (TeamUITask)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushEnum(l, (int)teamUITask.m_luaExportHelper.m_lastRefreshGameFunctionType);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060219C5 RID: 137669 RVA: 0x00B63ECC File Offset: 0x00B620CC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_lastRefreshGameFunctionType(IntPtr l)
	{
		int result;
		try
		{
			TeamUITask teamUITask = (TeamUITask)LuaObject.checkSelf(l);
			GameFunctionType lastRefreshGameFunctionType;
			LuaObject.checkEnum<GameFunctionType>(l, 2, out lastRefreshGameFunctionType);
			teamUITask.m_luaExportHelper.m_lastRefreshGameFunctionType = lastRefreshGameFunctionType;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060219C6 RID: 137670 RVA: 0x00B63F28 File Offset: 0x00B62128
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_lastRefreshChapterId(IntPtr l)
	{
		int result;
		try
		{
			TeamUITask teamUITask = (TeamUITask)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, teamUITask.m_luaExportHelper.m_lastRefreshChapterId);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060219C7 RID: 137671 RVA: 0x00B63F80 File Offset: 0x00B62180
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_lastRefreshChapterId(IntPtr l)
	{
		int result;
		try
		{
			TeamUITask teamUITask = (TeamUITask)LuaObject.checkSelf(l);
			int lastRefreshChapterId;
			LuaObject.checkType(l, 2, out lastRefreshChapterId);
			teamUITask.m_luaExportHelper.m_lastRefreshChapterId = lastRefreshChapterId;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060219C8 RID: 137672 RVA: 0x00B63FDC File Offset: 0x00B621DC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_lastRefreshLocationId(IntPtr l)
	{
		int result;
		try
		{
			TeamUITask teamUITask = (TeamUITask)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, teamUITask.m_luaExportHelper.m_lastRefreshLocationId);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060219C9 RID: 137673 RVA: 0x00B64034 File Offset: 0x00B62234
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_lastRefreshLocationId(IntPtr l)
	{
		int result;
		try
		{
			TeamUITask teamUITask = (TeamUITask)LuaObject.checkSelf(l);
			int lastRefreshLocationId;
			LuaObject.checkType(l, 2, out lastRefreshLocationId);
			teamUITask.m_luaExportHelper.m_lastRefreshLocationId = lastRefreshLocationId;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060219CA RID: 137674 RVA: 0x00B64090 File Offset: 0x00B62290
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_lastRefreshTeamRoomTime(IntPtr l)
	{
		int result;
		try
		{
			TeamUITask teamUITask = (TeamUITask)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, teamUITask.m_luaExportHelper.m_lastRefreshTeamRoomTime);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060219CB RID: 137675 RVA: 0x00B640EC File Offset: 0x00B622EC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_lastRefreshTeamRoomTime(IntPtr l)
	{
		int result;
		try
		{
			TeamUITask teamUITask = (TeamUITask)LuaObject.checkSelf(l);
			DateTime lastRefreshTeamRoomTime;
			LuaObject.checkValueType<DateTime>(l, 2, out lastRefreshTeamRoomTime);
			teamUITask.m_luaExportHelper.m_lastRefreshTeamRoomTime = lastRefreshTeamRoomTime;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060219CC RID: 137676 RVA: 0x00B64148 File Offset: 0x00B62348
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_LayerDescArray(IntPtr l)
	{
		int result;
		try
		{
			TeamUITask teamUITask = (TeamUITask)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, teamUITask.m_luaExportHelper.LayerDescArray);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060219CD RID: 137677 RVA: 0x00B641A0 File Offset: 0x00B623A0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_UICtrlDescArray(IntPtr l)
	{
		int result;
		try
		{
			TeamUITask teamUITask = (TeamUITask)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, teamUITask.m_luaExportHelper.UICtrlDescArray);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060219CE RID: 137678 RVA: 0x00B641F8 File Offset: 0x00B623F8
	[Preserve]
	public static void reg(IntPtr l)
	{
		LuaObject.getTypeTable(l, "BlackJack.ProjectL.UI.TeamUITask");
		if (Lua_BlackJack_ProjectL_UI_TeamUITask.<>f__mg$cache0 == null)
		{
			Lua_BlackJack_ProjectL_UI_TeamUITask.<>f__mg$cache0 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_TeamUITask.CreateIntent_s);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_TeamUITask.<>f__mg$cache0);
		if (Lua_BlackJack_ProjectL_UI_TeamUITask.<>f__mg$cache1 == null)
		{
			Lua_BlackJack_ProjectL_UI_TeamUITask.<>f__mg$cache1 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_TeamUITask.IsNeedLoadDynamicRes);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_TeamUITask.<>f__mg$cache1);
		if (Lua_BlackJack_ProjectL_UI_TeamUITask.<>f__mg$cache2 == null)
		{
			Lua_BlackJack_ProjectL_UI_TeamUITask.<>f__mg$cache2 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_TeamUITask.InitLayerStateOnLoadAllResCompleted);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_TeamUITask.<>f__mg$cache2);
		if (Lua_BlackJack_ProjectL_UI_TeamUITask.<>f__mg$cache3 == null)
		{
			Lua_BlackJack_ProjectL_UI_TeamUITask.<>f__mg$cache3 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_TeamUITask.InitAllUIControllers);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_TeamUITask.<>f__mg$cache3);
		if (Lua_BlackJack_ProjectL_UI_TeamUITask.<>f__mg$cache4 == null)
		{
			Lua_BlackJack_ProjectL_UI_TeamUITask.<>f__mg$cache4 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_TeamUITask.ClearAllContextAndRes);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_TeamUITask.<>f__mg$cache4);
		if (Lua_BlackJack_ProjectL_UI_TeamUITask.<>f__mg$cache5 == null)
		{
			Lua_BlackJack_ProjectL_UI_TeamUITask.<>f__mg$cache5 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_TeamUITask.RegisterPlayerContextEvents);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_TeamUITask.<>f__mg$cache5);
		if (Lua_BlackJack_ProjectL_UI_TeamUITask.<>f__mg$cache6 == null)
		{
			Lua_BlackJack_ProjectL_UI_TeamUITask.<>f__mg$cache6 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_TeamUITask.UnregisterPlayerContextEvents);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_TeamUITask.<>f__mg$cache6);
		if (Lua_BlackJack_ProjectL_UI_TeamUITask.<>f__mg$cache7 == null)
		{
			Lua_BlackJack_ProjectL_UI_TeamUITask.<>f__mg$cache7 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_TeamUITask.InitTeamUIController);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_TeamUITask.<>f__mg$cache7);
		if (Lua_BlackJack_ProjectL_UI_TeamUITask.<>f__mg$cache8 == null)
		{
			Lua_BlackJack_ProjectL_UI_TeamUITask.<>f__mg$cache8 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_TeamUITask.UninitTeamUIController);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_TeamUITask.<>f__mg$cache8);
		if (Lua_BlackJack_ProjectL_UI_TeamUITask.<>f__mg$cache9 == null)
		{
			Lua_BlackJack_ProjectL_UI_TeamUITask.<>f__mg$cache9 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_TeamUITask.InitCreateTeamRoomUIController);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_TeamUITask.<>f__mg$cache9);
		if (Lua_BlackJack_ProjectL_UI_TeamUITask.<>f__mg$cacheA == null)
		{
			Lua_BlackJack_ProjectL_UI_TeamUITask.<>f__mg$cacheA = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_TeamUITask.UninitCreateTeamRoomUIController);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_TeamUITask.<>f__mg$cacheA);
		if (Lua_BlackJack_ProjectL_UI_TeamUITask.<>f__mg$cacheB == null)
		{
			Lua_BlackJack_ProjectL_UI_TeamUITask.<>f__mg$cacheB = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_TeamUITask.UpdateView);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_TeamUITask.<>f__mg$cacheB);
		if (Lua_BlackJack_ProjectL_UI_TeamUITask.<>f__mg$cacheC == null)
		{
			Lua_BlackJack_ProjectL_UI_TeamUITask.<>f__mg$cacheC = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_TeamUITask.OnTick);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_TeamUITask.<>f__mg$cacheC);
		if (Lua_BlackJack_ProjectL_UI_TeamUITask.<>f__mg$cacheD == null)
		{
			Lua_BlackJack_ProjectL_UI_TeamUITask.<>f__mg$cacheD = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_TeamUITask.StartTeamRoomInviteNetTask);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_TeamUITask.<>f__mg$cacheD);
		if (Lua_BlackJack_ProjectL_UI_TeamUITask.<>f__mg$cacheE == null)
		{
			Lua_BlackJack_ProjectL_UI_TeamUITask.<>f__mg$cacheE = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_TeamUITask.CheckTeamRoomInviteAgain);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_TeamUITask.<>f__mg$cacheE);
		if (Lua_BlackJack_ProjectL_UI_TeamUITask.<>f__mg$cacheF == null)
		{
			Lua_BlackJack_ProjectL_UI_TeamUITask.<>f__mg$cacheF = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_TeamUITask.CheckOpenTeamRoomInfoUI);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_TeamUITask.<>f__mg$cacheF);
		if (Lua_BlackJack_ProjectL_UI_TeamUITask.<>f__mg$cache10 == null)
		{
			Lua_BlackJack_ProjectL_UI_TeamUITask.<>f__mg$cache10 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_TeamUITask.StartTeamRoomInfoUITask);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_TeamUITask.<>f__mg$cache10);
		if (Lua_BlackJack_ProjectL_UI_TeamUITask.<>f__mg$cache11 == null)
		{
			Lua_BlackJack_ProjectL_UI_TeamUITask.<>f__mg$cache11 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_TeamUITask.TeamRoomInfoUITask_OnClose);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_TeamUITask.<>f__mg$cache11);
		if (Lua_BlackJack_ProjectL_UI_TeamUITask.<>f__mg$cache12 == null)
		{
			Lua_BlackJack_ProjectL_UI_TeamUITask.<>f__mg$cache12 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_TeamUITask.RefreshTeamRoom);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_TeamUITask.<>f__mg$cache12);
		if (Lua_BlackJack_ProjectL_UI_TeamUITask.<>f__mg$cache13 == null)
		{
			Lua_BlackJack_ProjectL_UI_TeamUITask.<>f__mg$cache13 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_TeamUITask.TeamUIController_OnReturn);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_TeamUITask.<>f__mg$cache13);
		if (Lua_BlackJack_ProjectL_UI_TeamUITask.<>f__mg$cache14 == null)
		{
			Lua_BlackJack_ProjectL_UI_TeamUITask.<>f__mg$cache14 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_TeamUITask.TeamUIController_OnShowHelp);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_TeamUITask.<>f__mg$cache14);
		if (Lua_BlackJack_ProjectL_UI_TeamUITask.<>f__mg$cache15 == null)
		{
			Lua_BlackJack_ProjectL_UI_TeamUITask.<>f__mg$cache15 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_TeamUITask.TeamUIController_OnRefreshTeamRoom);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_TeamUITask.<>f__mg$cache15);
		if (Lua_BlackJack_ProjectL_UI_TeamUITask.<>f__mg$cache16 == null)
		{
			Lua_BlackJack_ProjectL_UI_TeamUITask.<>f__mg$cache16 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_TeamUITask.TeamUIController_OnShowCreateTeamRoom);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_TeamUITask.<>f__mg$cache16);
		if (Lua_BlackJack_ProjectL_UI_TeamUITask.<>f__mg$cache17 == null)
		{
			Lua_BlackJack_ProjectL_UI_TeamUITask.<>f__mg$cache17 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_TeamUITask.TeamUIController_OnAutoMatch);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_TeamUITask.<>f__mg$cache17);
		if (Lua_BlackJack_ProjectL_UI_TeamUITask.<>f__mg$cache18 == null)
		{
			Lua_BlackJack_ProjectL_UI_TeamUITask.<>f__mg$cache18 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_TeamUITask.TeamUIController_OnAutoMatchCancel);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_TeamUITask.<>f__mg$cache18);
		if (Lua_BlackJack_ProjectL_UI_TeamUITask.<>f__mg$cache19 == null)
		{
			Lua_BlackJack_ProjectL_UI_TeamUITask.<>f__mg$cache19 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_TeamUITask.AutoMatchCancelDialogBoxCallback);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_TeamUITask.<>f__mg$cache19);
		if (Lua_BlackJack_ProjectL_UI_TeamUITask.<>f__mg$cache1A == null)
		{
			Lua_BlackJack_ProjectL_UI_TeamUITask.<>f__mg$cache1A = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_TeamUITask.TeamUIController_OnSelectGameFunctionTypeAndLocation);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_TeamUITask.<>f__mg$cache1A);
		if (Lua_BlackJack_ProjectL_UI_TeamUITask.<>f__mg$cache1B == null)
		{
			Lua_BlackJack_ProjectL_UI_TeamUITask.<>f__mg$cache1B = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_TeamUITask.TeamUIController_OnJoinTeamRoom);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_TeamUITask.<>f__mg$cache1B);
		if (Lua_BlackJack_ProjectL_UI_TeamUITask.<>f__mg$cache1C == null)
		{
			Lua_BlackJack_ProjectL_UI_TeamUITask.<>f__mg$cache1C = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_TeamUITask.HandleJoinTeamRoomResultError);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_TeamUITask.<>f__mg$cache1C);
		if (Lua_BlackJack_ProjectL_UI_TeamUITask.<>f__mg$cache1D == null)
		{
			Lua_BlackJack_ProjectL_UI_TeamUITask.<>f__mg$cache1D = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_TeamUITask.CreateTeamRoomUIController_OnCreateTeamRoom);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_TeamUITask.<>f__mg$cache1D);
		if (Lua_BlackJack_ProjectL_UI_TeamUITask.<>f__mg$cache1E == null)
		{
			Lua_BlackJack_ProjectL_UI_TeamUITask.<>f__mg$cache1E = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_TeamUITask.PlayerContext_OnTeamRoomPlayerLeaveWaitingListAndJoinRoomNtf);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_TeamUITask.<>f__mg$cache1E);
		if (Lua_BlackJack_ProjectL_UI_TeamUITask.<>f__mg$cache1F == null)
		{
			Lua_BlackJack_ProjectL_UI_TeamUITask.<>f__mg$cache1F = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_TeamUITask.PlayerContext_OnTeamRoomAutoMatchInfoNtf);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_TeamUITask.<>f__mg$cache1F);
		if (Lua_BlackJack_ProjectL_UI_TeamUITask.<>f__mg$cache20 == null)
		{
			Lua_BlackJack_ProjectL_UI_TeamUITask.<>f__mg$cache20 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_TeamUITask.PlayerContext_OnPlayerInfoInitEnd);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_TeamUITask.<>f__mg$cache20);
		if (Lua_BlackJack_ProjectL_UI_TeamUITask.<>f__mg$cache21 == null)
		{
			Lua_BlackJack_ProjectL_UI_TeamUITask.<>f__mg$cache21 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_TeamUITask.__callBase_OnStart);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_TeamUITask.<>f__mg$cache21);
		if (Lua_BlackJack_ProjectL_UI_TeamUITask.<>f__mg$cache22 == null)
		{
			Lua_BlackJack_ProjectL_UI_TeamUITask.<>f__mg$cache22 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_TeamUITask.__callBase_OnStop);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_TeamUITask.<>f__mg$cache22);
		if (Lua_BlackJack_ProjectL_UI_TeamUITask.<>f__mg$cache23 == null)
		{
			Lua_BlackJack_ProjectL_UI_TeamUITask.<>f__mg$cache23 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_TeamUITask.__callBase_OnPause);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_TeamUITask.<>f__mg$cache23);
		if (Lua_BlackJack_ProjectL_UI_TeamUITask.<>f__mg$cache24 == null)
		{
			Lua_BlackJack_ProjectL_UI_TeamUITask.<>f__mg$cache24 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_TeamUITask.__callBase_OnResume);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_TeamUITask.<>f__mg$cache24);
		if (Lua_BlackJack_ProjectL_UI_TeamUITask.<>f__mg$cache25 == null)
		{
			Lua_BlackJack_ProjectL_UI_TeamUITask.<>f__mg$cache25 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_TeamUITask.__callBase_OnNewIntent);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_TeamUITask.<>f__mg$cache25);
		if (Lua_BlackJack_ProjectL_UI_TeamUITask.<>f__mg$cache26 == null)
		{
			Lua_BlackJack_ProjectL_UI_TeamUITask.<>f__mg$cache26 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_TeamUITask.__callBase_EnableUIInput);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_TeamUITask.<>f__mg$cache26);
		if (Lua_BlackJack_ProjectL_UI_TeamUITask.<>f__mg$cache27 == null)
		{
			Lua_BlackJack_ProjectL_UI_TeamUITask.<>f__mg$cache27 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_TeamUITask.__callBase_IsNeedLoadDynamicRes);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_TeamUITask.<>f__mg$cache27);
		if (Lua_BlackJack_ProjectL_UI_TeamUITask.<>f__mg$cache28 == null)
		{
			Lua_BlackJack_ProjectL_UI_TeamUITask.<>f__mg$cache28 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_TeamUITask.__callBase_CollectAllDynamicResForLoad);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_TeamUITask.<>f__mg$cache28);
		if (Lua_BlackJack_ProjectL_UI_TeamUITask.<>f__mg$cache29 == null)
		{
			Lua_BlackJack_ProjectL_UI_TeamUITask.<>f__mg$cache29 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_TeamUITask.__callBase_RegisterPlayerContextEvents);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_TeamUITask.<>f__mg$cache29);
		if (Lua_BlackJack_ProjectL_UI_TeamUITask.<>f__mg$cache2A == null)
		{
			Lua_BlackJack_ProjectL_UI_TeamUITask.<>f__mg$cache2A = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_TeamUITask.__callBase_UnregisterPlayerContextEvents);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_TeamUITask.<>f__mg$cache2A);
		if (Lua_BlackJack_ProjectL_UI_TeamUITask.<>f__mg$cache2B == null)
		{
			Lua_BlackJack_ProjectL_UI_TeamUITask.<>f__mg$cache2B = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_TeamUITask.__callBase_PostUpdateView);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_TeamUITask.<>f__mg$cache2B);
		if (Lua_BlackJack_ProjectL_UI_TeamUITask.<>f__mg$cache2C == null)
		{
			Lua_BlackJack_ProjectL_UI_TeamUITask.<>f__mg$cache2C = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_TeamUITask.__callBase_CollectPreloadResourceList);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_TeamUITask.<>f__mg$cache2C);
		if (Lua_BlackJack_ProjectL_UI_TeamUITask.<>f__mg$cache2D == null)
		{
			Lua_BlackJack_ProjectL_UI_TeamUITask.<>f__mg$cache2D = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_TeamUITask.__callBase_ClearAssetList);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_TeamUITask.<>f__mg$cache2D);
		if (Lua_BlackJack_ProjectL_UI_TeamUITask.<>f__mg$cache2E == null)
		{
			Lua_BlackJack_ProjectL_UI_TeamUITask.<>f__mg$cache2E = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_TeamUITask.__callBase_CollectAsset);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_TeamUITask.<>f__mg$cache2E);
		if (Lua_BlackJack_ProjectL_UI_TeamUITask.<>f__mg$cache2F == null)
		{
			Lua_BlackJack_ProjectL_UI_TeamUITask.<>f__mg$cache2F = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_TeamUITask.__callBase_CollectSpriteAsset);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_TeamUITask.<>f__mg$cache2F);
		if (Lua_BlackJack_ProjectL_UI_TeamUITask.<>f__mg$cache30 == null)
		{
			Lua_BlackJack_ProjectL_UI_TeamUITask.<>f__mg$cache30 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_TeamUITask.__callBase_CollectFxAsset);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_TeamUITask.<>f__mg$cache30);
		if (Lua_BlackJack_ProjectL_UI_TeamUITask.<>f__mg$cache31 == null)
		{
			Lua_BlackJack_ProjectL_UI_TeamUITask.<>f__mg$cache31 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_TeamUITask.__callBase_StartLoadCustomAssets);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_TeamUITask.<>f__mg$cache31);
		if (Lua_BlackJack_ProjectL_UI_TeamUITask.<>f__mg$cache32 == null)
		{
			Lua_BlackJack_ProjectL_UI_TeamUITask.<>f__mg$cache32 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_TeamUITask.__callBase_IsLoadingCustomAssets);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_TeamUITask.<>f__mg$cache32);
		if (Lua_BlackJack_ProjectL_UI_TeamUITask.<>f__mg$cache33 == null)
		{
			Lua_BlackJack_ProjectL_UI_TeamUITask.<>f__mg$cache33 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_TeamUITask.__callBase_IsPipeLineRunning);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_TeamUITask.<>f__mg$cache33);
		if (Lua_BlackJack_ProjectL_UI_TeamUITask.<>f__mg$cache34 == null)
		{
			Lua_BlackJack_ProjectL_UI_TeamUITask.<>f__mg$cache34 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_TeamUITask.__callBase_IsOpeningUI);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_TeamUITask.<>f__mg$cache34);
		if (Lua_BlackJack_ProjectL_UI_TeamUITask.<>f__mg$cache35 == null)
		{
			Lua_BlackJack_ProjectL_UI_TeamUITask.<>f__mg$cache35 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_TeamUITask.__callBase_ReturnPrevUITask);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_TeamUITask.<>f__mg$cache35);
		if (Lua_BlackJack_ProjectL_UI_TeamUITask.<>f__mg$cache36 == null)
		{
			Lua_BlackJack_ProjectL_UI_TeamUITask.<>f__mg$cache36 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_TeamUITask.__callBase_ClearUnusedDynamicResourceCache);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_TeamUITask.<>f__mg$cache36);
		if (Lua_BlackJack_ProjectL_UI_TeamUITask.<>f__mg$cache37 == null)
		{
			Lua_BlackJack_ProjectL_UI_TeamUITask.<>f__mg$cache37 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_TeamUITask.__callBase_OnMemoryWarning);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_TeamUITask.<>f__mg$cache37);
		if (Lua_BlackJack_ProjectL_UI_TeamUITask.<>f__mg$cache38 == null)
		{
			Lua_BlackJack_ProjectL_UI_TeamUITask.<>f__mg$cache38 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_TeamUITask.TeamRoomInfoUITask_OnLoadAllResCompleted_s);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_TeamUITask.<>f__mg$cache38);
		string name = "m_layerDescArray";
		if (Lua_BlackJack_ProjectL_UI_TeamUITask.<>f__mg$cache39 == null)
		{
			Lua_BlackJack_ProjectL_UI_TeamUITask.<>f__mg$cache39 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_TeamUITask.get_m_layerDescArray);
		}
		LuaCSFunction get = Lua_BlackJack_ProjectL_UI_TeamUITask.<>f__mg$cache39;
		if (Lua_BlackJack_ProjectL_UI_TeamUITask.<>f__mg$cache3A == null)
		{
			Lua_BlackJack_ProjectL_UI_TeamUITask.<>f__mg$cache3A = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_TeamUITask.set_m_layerDescArray);
		}
		LuaObject.addMember(l, name, get, Lua_BlackJack_ProjectL_UI_TeamUITask.<>f__mg$cache3A, true);
		string name2 = "m_uiCtrlDescArray";
		if (Lua_BlackJack_ProjectL_UI_TeamUITask.<>f__mg$cache3B == null)
		{
			Lua_BlackJack_ProjectL_UI_TeamUITask.<>f__mg$cache3B = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_TeamUITask.get_m_uiCtrlDescArray);
		}
		LuaCSFunction get2 = Lua_BlackJack_ProjectL_UI_TeamUITask.<>f__mg$cache3B;
		if (Lua_BlackJack_ProjectL_UI_TeamUITask.<>f__mg$cache3C == null)
		{
			Lua_BlackJack_ProjectL_UI_TeamUITask.<>f__mg$cache3C = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_TeamUITask.set_m_uiCtrlDescArray);
		}
		LuaObject.addMember(l, name2, get2, Lua_BlackJack_ProjectL_UI_TeamUITask.<>f__mg$cache3C, true);
		string name3 = "m_teamUIController";
		if (Lua_BlackJack_ProjectL_UI_TeamUITask.<>f__mg$cache3D == null)
		{
			Lua_BlackJack_ProjectL_UI_TeamUITask.<>f__mg$cache3D = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_TeamUITask.get_m_teamUIController);
		}
		LuaCSFunction get3 = Lua_BlackJack_ProjectL_UI_TeamUITask.<>f__mg$cache3D;
		if (Lua_BlackJack_ProjectL_UI_TeamUITask.<>f__mg$cache3E == null)
		{
			Lua_BlackJack_ProjectL_UI_TeamUITask.<>f__mg$cache3E = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_TeamUITask.set_m_teamUIController);
		}
		LuaObject.addMember(l, name3, get3, Lua_BlackJack_ProjectL_UI_TeamUITask.<>f__mg$cache3E, true);
		string name4 = "m_playerResourceUIController";
		if (Lua_BlackJack_ProjectL_UI_TeamUITask.<>f__mg$cache3F == null)
		{
			Lua_BlackJack_ProjectL_UI_TeamUITask.<>f__mg$cache3F = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_TeamUITask.get_m_playerResourceUIController);
		}
		LuaCSFunction get4 = Lua_BlackJack_ProjectL_UI_TeamUITask.<>f__mg$cache3F;
		if (Lua_BlackJack_ProjectL_UI_TeamUITask.<>f__mg$cache40 == null)
		{
			Lua_BlackJack_ProjectL_UI_TeamUITask.<>f__mg$cache40 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_TeamUITask.set_m_playerResourceUIController);
		}
		LuaObject.addMember(l, name4, get4, Lua_BlackJack_ProjectL_UI_TeamUITask.<>f__mg$cache40, true);
		string name5 = "m_createTeamRoomUIController";
		if (Lua_BlackJack_ProjectL_UI_TeamUITask.<>f__mg$cache41 == null)
		{
			Lua_BlackJack_ProjectL_UI_TeamUITask.<>f__mg$cache41 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_TeamUITask.get_m_createTeamRoomUIController);
		}
		LuaCSFunction get5 = Lua_BlackJack_ProjectL_UI_TeamUITask.<>f__mg$cache41;
		if (Lua_BlackJack_ProjectL_UI_TeamUITask.<>f__mg$cache42 == null)
		{
			Lua_BlackJack_ProjectL_UI_TeamUITask.<>f__mg$cache42 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_TeamUITask.set_m_createTeamRoomUIController);
		}
		LuaObject.addMember(l, name5, get5, Lua_BlackJack_ProjectL_UI_TeamUITask.<>f__mg$cache42, true);
		string name6 = "m_teamRoomInfoUITask";
		if (Lua_BlackJack_ProjectL_UI_TeamUITask.<>f__mg$cache43 == null)
		{
			Lua_BlackJack_ProjectL_UI_TeamUITask.<>f__mg$cache43 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_TeamUITask.get_m_teamRoomInfoUITask);
		}
		LuaCSFunction get6 = Lua_BlackJack_ProjectL_UI_TeamUITask.<>f__mg$cache43;
		if (Lua_BlackJack_ProjectL_UI_TeamUITask.<>f__mg$cache44 == null)
		{
			Lua_BlackJack_ProjectL_UI_TeamUITask.<>f__mg$cache44 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_TeamUITask.set_m_teamRoomInfoUITask);
		}
		LuaObject.addMember(l, name6, get6, Lua_BlackJack_ProjectL_UI_TeamUITask.<>f__mg$cache44, true);
		string name7 = "m_lastRefreshGameFunctionType";
		if (Lua_BlackJack_ProjectL_UI_TeamUITask.<>f__mg$cache45 == null)
		{
			Lua_BlackJack_ProjectL_UI_TeamUITask.<>f__mg$cache45 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_TeamUITask.get_m_lastRefreshGameFunctionType);
		}
		LuaCSFunction get7 = Lua_BlackJack_ProjectL_UI_TeamUITask.<>f__mg$cache45;
		if (Lua_BlackJack_ProjectL_UI_TeamUITask.<>f__mg$cache46 == null)
		{
			Lua_BlackJack_ProjectL_UI_TeamUITask.<>f__mg$cache46 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_TeamUITask.set_m_lastRefreshGameFunctionType);
		}
		LuaObject.addMember(l, name7, get7, Lua_BlackJack_ProjectL_UI_TeamUITask.<>f__mg$cache46, true);
		string name8 = "m_lastRefreshChapterId";
		if (Lua_BlackJack_ProjectL_UI_TeamUITask.<>f__mg$cache47 == null)
		{
			Lua_BlackJack_ProjectL_UI_TeamUITask.<>f__mg$cache47 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_TeamUITask.get_m_lastRefreshChapterId);
		}
		LuaCSFunction get8 = Lua_BlackJack_ProjectL_UI_TeamUITask.<>f__mg$cache47;
		if (Lua_BlackJack_ProjectL_UI_TeamUITask.<>f__mg$cache48 == null)
		{
			Lua_BlackJack_ProjectL_UI_TeamUITask.<>f__mg$cache48 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_TeamUITask.set_m_lastRefreshChapterId);
		}
		LuaObject.addMember(l, name8, get8, Lua_BlackJack_ProjectL_UI_TeamUITask.<>f__mg$cache48, true);
		string name9 = "m_lastRefreshLocationId";
		if (Lua_BlackJack_ProjectL_UI_TeamUITask.<>f__mg$cache49 == null)
		{
			Lua_BlackJack_ProjectL_UI_TeamUITask.<>f__mg$cache49 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_TeamUITask.get_m_lastRefreshLocationId);
		}
		LuaCSFunction get9 = Lua_BlackJack_ProjectL_UI_TeamUITask.<>f__mg$cache49;
		if (Lua_BlackJack_ProjectL_UI_TeamUITask.<>f__mg$cache4A == null)
		{
			Lua_BlackJack_ProjectL_UI_TeamUITask.<>f__mg$cache4A = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_TeamUITask.set_m_lastRefreshLocationId);
		}
		LuaObject.addMember(l, name9, get9, Lua_BlackJack_ProjectL_UI_TeamUITask.<>f__mg$cache4A, true);
		string name10 = "m_lastRefreshTeamRoomTime";
		if (Lua_BlackJack_ProjectL_UI_TeamUITask.<>f__mg$cache4B == null)
		{
			Lua_BlackJack_ProjectL_UI_TeamUITask.<>f__mg$cache4B = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_TeamUITask.get_m_lastRefreshTeamRoomTime);
		}
		LuaCSFunction get10 = Lua_BlackJack_ProjectL_UI_TeamUITask.<>f__mg$cache4B;
		if (Lua_BlackJack_ProjectL_UI_TeamUITask.<>f__mg$cache4C == null)
		{
			Lua_BlackJack_ProjectL_UI_TeamUITask.<>f__mg$cache4C = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_TeamUITask.set_m_lastRefreshTeamRoomTime);
		}
		LuaObject.addMember(l, name10, get10, Lua_BlackJack_ProjectL_UI_TeamUITask.<>f__mg$cache4C, true);
		string name11 = "LayerDescArray";
		if (Lua_BlackJack_ProjectL_UI_TeamUITask.<>f__mg$cache4D == null)
		{
			Lua_BlackJack_ProjectL_UI_TeamUITask.<>f__mg$cache4D = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_TeamUITask.get_LayerDescArray);
		}
		LuaObject.addMember(l, name11, Lua_BlackJack_ProjectL_UI_TeamUITask.<>f__mg$cache4D, null, true);
		string name12 = "UICtrlDescArray";
		if (Lua_BlackJack_ProjectL_UI_TeamUITask.<>f__mg$cache4E == null)
		{
			Lua_BlackJack_ProjectL_UI_TeamUITask.<>f__mg$cache4E = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_TeamUITask.get_UICtrlDescArray);
		}
		LuaObject.addMember(l, name12, Lua_BlackJack_ProjectL_UI_TeamUITask.<>f__mg$cache4E, null, true);
		if (Lua_BlackJack_ProjectL_UI_TeamUITask.<>f__mg$cache4F == null)
		{
			Lua_BlackJack_ProjectL_UI_TeamUITask.<>f__mg$cache4F = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_TeamUITask.constructor);
		}
		LuaObject.createTypeMetatable(l, Lua_BlackJack_ProjectL_UI_TeamUITask.<>f__mg$cache4F, typeof(TeamUITask), typeof(UITask));
	}

	// Token: 0x0401780E RID: 96270
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache0;

	// Token: 0x0401780F RID: 96271
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1;

	// Token: 0x04017810 RID: 96272
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2;

	// Token: 0x04017811 RID: 96273
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3;

	// Token: 0x04017812 RID: 96274
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache4;

	// Token: 0x04017813 RID: 96275
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache5;

	// Token: 0x04017814 RID: 96276
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache6;

	// Token: 0x04017815 RID: 96277
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache7;

	// Token: 0x04017816 RID: 96278
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache8;

	// Token: 0x04017817 RID: 96279
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache9;

	// Token: 0x04017818 RID: 96280
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheA;

	// Token: 0x04017819 RID: 96281
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheB;

	// Token: 0x0401781A RID: 96282
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheC;

	// Token: 0x0401781B RID: 96283
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheD;

	// Token: 0x0401781C RID: 96284
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheE;

	// Token: 0x0401781D RID: 96285
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheF;

	// Token: 0x0401781E RID: 96286
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache10;

	// Token: 0x0401781F RID: 96287
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache11;

	// Token: 0x04017820 RID: 96288
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache12;

	// Token: 0x04017821 RID: 96289
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache13;

	// Token: 0x04017822 RID: 96290
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache14;

	// Token: 0x04017823 RID: 96291
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache15;

	// Token: 0x04017824 RID: 96292
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache16;

	// Token: 0x04017825 RID: 96293
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache17;

	// Token: 0x04017826 RID: 96294
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache18;

	// Token: 0x04017827 RID: 96295
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache19;

	// Token: 0x04017828 RID: 96296
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1A;

	// Token: 0x04017829 RID: 96297
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1B;

	// Token: 0x0401782A RID: 96298
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1C;

	// Token: 0x0401782B RID: 96299
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1D;

	// Token: 0x0401782C RID: 96300
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1E;

	// Token: 0x0401782D RID: 96301
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1F;

	// Token: 0x0401782E RID: 96302
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache20;

	// Token: 0x0401782F RID: 96303
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache21;

	// Token: 0x04017830 RID: 96304
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache22;

	// Token: 0x04017831 RID: 96305
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache23;

	// Token: 0x04017832 RID: 96306
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache24;

	// Token: 0x04017833 RID: 96307
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache25;

	// Token: 0x04017834 RID: 96308
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache26;

	// Token: 0x04017835 RID: 96309
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache27;

	// Token: 0x04017836 RID: 96310
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache28;

	// Token: 0x04017837 RID: 96311
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache29;

	// Token: 0x04017838 RID: 96312
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2A;

	// Token: 0x04017839 RID: 96313
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2B;

	// Token: 0x0401783A RID: 96314
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2C;

	// Token: 0x0401783B RID: 96315
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2D;

	// Token: 0x0401783C RID: 96316
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2E;

	// Token: 0x0401783D RID: 96317
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2F;

	// Token: 0x0401783E RID: 96318
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache30;

	// Token: 0x0401783F RID: 96319
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache31;

	// Token: 0x04017840 RID: 96320
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache32;

	// Token: 0x04017841 RID: 96321
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache33;

	// Token: 0x04017842 RID: 96322
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache34;

	// Token: 0x04017843 RID: 96323
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache35;

	// Token: 0x04017844 RID: 96324
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache36;

	// Token: 0x04017845 RID: 96325
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache37;

	// Token: 0x04017846 RID: 96326
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache38;

	// Token: 0x04017847 RID: 96327
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache39;

	// Token: 0x04017848 RID: 96328
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3A;

	// Token: 0x04017849 RID: 96329
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3B;

	// Token: 0x0401784A RID: 96330
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3C;

	// Token: 0x0401784B RID: 96331
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3D;

	// Token: 0x0401784C RID: 96332
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3E;

	// Token: 0x0401784D RID: 96333
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3F;

	// Token: 0x0401784E RID: 96334
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache40;

	// Token: 0x0401784F RID: 96335
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache41;

	// Token: 0x04017850 RID: 96336
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache42;

	// Token: 0x04017851 RID: 96337
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache43;

	// Token: 0x04017852 RID: 96338
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache44;

	// Token: 0x04017853 RID: 96339
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache45;

	// Token: 0x04017854 RID: 96340
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache46;

	// Token: 0x04017855 RID: 96341
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache47;

	// Token: 0x04017856 RID: 96342
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache48;

	// Token: 0x04017857 RID: 96343
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache49;

	// Token: 0x04017858 RID: 96344
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache4A;

	// Token: 0x04017859 RID: 96345
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache4B;

	// Token: 0x0401785A RID: 96346
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache4C;

	// Token: 0x0401785B RID: 96347
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache4D;

	// Token: 0x0401785C RID: 96348
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache4E;

	// Token: 0x0401785D RID: 96349
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache4F;
}
