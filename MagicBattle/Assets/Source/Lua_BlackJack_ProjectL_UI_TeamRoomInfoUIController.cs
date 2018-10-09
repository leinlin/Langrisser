using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using BlackJack.BJFramework.Runtime.Prefab;
using BlackJack.BJFramework.Runtime.UI;
using BlackJack.ConfigData;
using BlackJack.ProjectL.Common;
using BlackJack.ProjectL.UI;
using BlackJack.ProjectLBasic;
using SLua;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.Scripting;
using UnityEngine.UI;

// Token: 0x02001599 RID: 5529
[Preserve]
public class Lua_BlackJack_ProjectL_UI_TeamRoomInfoUIController : LuaObject
{
	// Token: 0x060216CE RID: 136910 RVA: 0x00B4D010 File Offset: 0x00B4B210
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int Open(IntPtr l)
	{
		int result;
		try
		{
			TeamRoomInfoUIController teamRoomInfoUIController = (TeamRoomInfoUIController)LuaObject.checkSelf(l);
			teamRoomInfoUIController.Open();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060216CF RID: 136911 RVA: 0x00B4D05C File Offset: 0x00B4B25C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int Close(IntPtr l)
	{
		int result;
		try
		{
			TeamRoomInfoUIController teamRoomInfoUIController = (TeamRoomInfoUIController)LuaObject.checkSelf(l);
			Action onEnd;
			LuaObject.checkDelegate<Action>(l, 2, out onEnd);
			teamRoomInfoUIController.Close(onEnd);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060216D0 RID: 136912 RVA: 0x00B4D0B4 File Offset: 0x00B4B2B4
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int SetTeamRoomSetting(IntPtr l)
	{
		int result;
		try
		{
			TeamRoomInfoUIController teamRoomInfoUIController = (TeamRoomInfoUIController)LuaObject.checkSelf(l);
			TeamRoomSetting teamRoomSetting;
			LuaObject.checkType<TeamRoomSetting>(l, 2, out teamRoomSetting);
			teamRoomInfoUIController.SetTeamRoomSetting(teamRoomSetting);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060216D1 RID: 136913 RVA: 0x00B4D10C File Offset: 0x00B4B30C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int SetTeamRoomPlayers(IntPtr l)
	{
		int result;
		try
		{
			TeamRoomInfoUIController teamRoomInfoUIController = (TeamRoomInfoUIController)LuaObject.checkSelf(l);
			List<TeamRoomPlayer> players;
			LuaObject.checkType<List<TeamRoomPlayer>>(l, 2, out players);
			bool isLeader;
			LuaObject.checkType(l, 3, out isLeader);
			teamRoomInfoUIController.SetTeamRoomPlayers(players, isLeader);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060216D2 RID: 136914 RVA: 0x00B4D170 File Offset: 0x00B4B370
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int SetAuthority(IntPtr l)
	{
		int result;
		try
		{
			TeamRoomInfoUIController teamRoomInfoUIController = (TeamRoomInfoUIController)LuaObject.checkSelf(l);
			TeamRoomAuthority authority;
			LuaObject.checkEnum<TeamRoomAuthority>(l, 2, out authority);
			teamRoomInfoUIController.SetAuthority(authority);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060216D3 RID: 136915 RVA: 0x00B4D1C8 File Offset: 0x00B4B3C8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int SetQuitCountdown(IntPtr l)
	{
		int result;
		try
		{
			TeamRoomInfoUIController teamRoomInfoUIController = (TeamRoomInfoUIController)LuaObject.checkSelf(l);
			TimeSpan quitCountdown;
			LuaObject.checkValueType<TimeSpan>(l, 2, out quitCountdown);
			teamRoomInfoUIController.SetQuitCountdown(quitCountdown);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060216D4 RID: 136916 RVA: 0x00B4D220 File Offset: 0x00B4B420
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int ShowWaitStartBattle(IntPtr l)
	{
		int result;
		try
		{
			TeamRoomInfoUIController teamRoomInfoUIController = (TeamRoomInfoUIController)LuaObject.checkSelf(l);
			bool show;
			LuaObject.checkType(l, 2, out show);
			teamRoomInfoUIController.ShowWaitStartBattle(show);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060216D5 RID: 136917 RVA: 0x00B4D278 File Offset: 0x00B4B478
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int ShowChangePlayerPosition(IntPtr l)
	{
		int result;
		try
		{
			TeamRoomInfoUIController teamRoomInfoUIController = (TeamRoomInfoUIController)LuaObject.checkSelf(l);
			TeamRoom teamRoom;
			LuaObject.checkType<TeamRoom>(l, 2, out teamRoom);
			teamRoomInfoUIController.ShowChangePlayerPosition(teamRoom);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060216D6 RID: 136918 RVA: 0x00B4D2D0 File Offset: 0x00B4B4D0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int HideChangePlayerPosition(IntPtr l)
	{
		int result;
		try
		{
			TeamRoomInfoUIController teamRoomInfoUIController = (TeamRoomInfoUIController)LuaObject.checkSelf(l);
			teamRoomInfoUIController.HideChangePlayerPosition();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060216D7 RID: 136919 RVA: 0x00B4D31C File Offset: 0x00B4B51C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int GetPlayerChangedPosition(IntPtr l)
	{
		int result;
		try
		{
			TeamRoomInfoUIController teamRoomInfoUIController = (TeamRoomInfoUIController)LuaObject.checkSelf(l);
			TeamRoomPlayer player;
			LuaObject.checkType<TeamRoomPlayer>(l, 2, out player);
			int playerChangedPosition = teamRoomInfoUIController.GetPlayerChangedPosition(player);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, playerChangedPosition);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060216D8 RID: 136920 RVA: 0x00B4D380 File Offset: 0x00B4B580
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int ShowPlayerChat(IntPtr l)
	{
		int result;
		try
		{
			TeamRoomInfoUIController teamRoomInfoUIController = (TeamRoomInfoUIController)LuaObject.checkSelf(l);
			int playerIndex;
			LuaObject.checkType(l, 2, out playerIndex);
			string text;
			LuaObject.checkType(l, 3, out text);
			teamRoomInfoUIController.ShowPlayerChat(playerIndex, text);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060216D9 RID: 136921 RVA: 0x00B4D3E4 File Offset: 0x00B4B5E4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int ShowPlayerBigExpression(IntPtr l)
	{
		int result;
		try
		{
			TeamRoomInfoUIController teamRoomInfoUIController = (TeamRoomInfoUIController)LuaObject.checkSelf(l);
			int playerIndex;
			LuaObject.checkType(l, 2, out playerIndex);
			int expressionID;
			LuaObject.checkType(l, 3, out expressionID);
			teamRoomInfoUIController.ShowPlayerBigExpression(playerIndex, expressionID);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060216DA RID: 136922 RVA: 0x00B4D448 File Offset: 0x00B4B648
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int TeamRoomPlayerInfoUIController_OnDrop(IntPtr l)
	{
		int result;
		try
		{
			TeamRoomInfoUIController teamRoomInfoUIController = (TeamRoomInfoUIController)LuaObject.checkSelf(l);
			PointerEventData eventData;
			LuaObject.checkType<PointerEventData>(l, 2, out eventData);
			teamRoomInfoUIController.TeamRoomPlayerInfoUIController_OnDrop(eventData);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060216DB RID: 136923 RVA: 0x00B4D4A0 File Offset: 0x00B4B6A0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int OnBindFiledsCompleted(IntPtr l)
	{
		int result;
		try
		{
			TeamRoomInfoUIController teamRoomInfoUIController = (TeamRoomInfoUIController)LuaObject.checkSelf(l);
			teamRoomInfoUIController.m_luaExportHelper.OnBindFiledsCompleted();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060216DC RID: 136924 RVA: 0x00B4D4F4 File Offset: 0x00B4B6F4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int GetPlayerInfoParent(IntPtr l)
	{
		int result;
		try
		{
			TeamRoomInfoUIController teamRoomInfoUIController = (TeamRoomInfoUIController)LuaObject.checkSelf(l);
			int idx;
			LuaObject.checkType(l, 2, out idx);
			bool isEdit;
			LuaObject.checkType(l, 3, out isEdit);
			Transform playerInfoParent = teamRoomInfoUIController.m_luaExportHelper.GetPlayerInfoParent(idx, isEdit);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, playerInfoParent);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060216DD RID: 136925 RVA: 0x00B4D568 File Offset: 0x00B4B768
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int OnDisable(IntPtr l)
	{
		int result;
		try
		{
			TeamRoomInfoUIController teamRoomInfoUIController = (TeamRoomInfoUIController)LuaObject.checkSelf(l);
			teamRoomInfoUIController.m_luaExportHelper.OnDisable();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060216DE RID: 136926 RVA: 0x00B4D5BC File Offset: 0x00B4B7BC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int OnApplicationPause(IntPtr l)
	{
		int result;
		try
		{
			TeamRoomInfoUIController teamRoomInfoUIController = (TeamRoomInfoUIController)LuaObject.checkSelf(l);
			bool isPause;
			LuaObject.checkType(l, 2, out isPause);
			teamRoomInfoUIController.m_luaExportHelper.OnApplicationPause(isPause);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060216DF RID: 136927 RVA: 0x00B4D618 File Offset: 0x00B4B818
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int SetBattleName(IntPtr l)
	{
		int result;
		try
		{
			TeamRoomInfoUIController teamRoomInfoUIController = (TeamRoomInfoUIController)LuaObject.checkSelf(l);
			GameFunctionType gameFunctionType;
			LuaObject.checkEnum<GameFunctionType>(l, 2, out gameFunctionType);
			int locationId;
			LuaObject.checkType(l, 3, out locationId);
			teamRoomInfoUIController.m_luaExportHelper.SetBattleName(gameFunctionType, locationId);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060216E0 RID: 136928 RVA: 0x00B4D684 File Offset: 0x00B4B884
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int SetPlayerLevelRange(IntPtr l)
	{
		int result;
		try
		{
			TeamRoomInfoUIController teamRoomInfoUIController = (TeamRoomInfoUIController)LuaObject.checkSelf(l);
			int levelMin;
			LuaObject.checkType(l, 2, out levelMin);
			int levelMax;
			LuaObject.checkType(l, 3, out levelMax);
			teamRoomInfoUIController.m_luaExportHelper.SetPlayerLevelRange(levelMin, levelMax);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060216E1 RID: 136929 RVA: 0x00B4D6F0 File Offset: 0x00B4B8F0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int CreateDraggingPlayerInfoUIController(IntPtr l)
	{
		int result;
		try
		{
			TeamRoomInfoUIController teamRoomInfoUIController = (TeamRoomInfoUIController)LuaObject.checkSelf(l);
			TeamRoomPlayerInfoUIController ctrl;
			LuaObject.checkType<TeamRoomPlayerInfoUIController>(l, 2, out ctrl);
			teamRoomInfoUIController.m_luaExportHelper.CreateDraggingPlayerInfoUIController(ctrl);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060216E2 RID: 136930 RVA: 0x00B4D74C File Offset: 0x00B4B94C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int DestroyDragginPlayerInfoUIController(IntPtr l)
	{
		int result;
		try
		{
			TeamRoomInfoUIController teamRoomInfoUIController = (TeamRoomInfoUIController)LuaObject.checkSelf(l);
			teamRoomInfoUIController.m_luaExportHelper.DestroyDragginPlayerInfoUIController();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060216E3 RID: 136931 RVA: 0x00B4D7A0 File Offset: 0x00B4B9A0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int MoveDraggingPlayerInfoUIController(IntPtr l)
	{
		int result;
		try
		{
			TeamRoomInfoUIController teamRoomInfoUIController = (TeamRoomInfoUIController)LuaObject.checkSelf(l);
			Vector2 pos;
			LuaObject.checkType(l, 2, out pos);
			teamRoomInfoUIController.m_luaExportHelper.MoveDraggingPlayerInfoUIController(pos);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060216E4 RID: 136932 RVA: 0x00B4D7FC File Offset: 0x00B4B9FC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int DropDraggingPlayerInfoUIController(IntPtr l)
	{
		int result;
		try
		{
			TeamRoomInfoUIController teamRoomInfoUIController = (TeamRoomInfoUIController)LuaObject.checkSelf(l);
			Vector3 pos;
			LuaObject.checkType(l, 2, out pos);
			teamRoomInfoUIController.m_luaExportHelper.DropDraggingPlayerInfoUIController(pos);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060216E5 RID: 136933 RVA: 0x00B4D858 File Offset: 0x00B4BA58
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int OnLeaveButtonClick(IntPtr l)
	{
		int result;
		try
		{
			TeamRoomInfoUIController teamRoomInfoUIController = (TeamRoomInfoUIController)LuaObject.checkSelf(l);
			teamRoomInfoUIController.m_luaExportHelper.OnLeaveButtonClick();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060216E6 RID: 136934 RVA: 0x00B4D8AC File Offset: 0x00B4BAAC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int OnStartButtonClick(IntPtr l)
	{
		int result;
		try
		{
			TeamRoomInfoUIController teamRoomInfoUIController = (TeamRoomInfoUIController)LuaObject.checkSelf(l);
			teamRoomInfoUIController.m_luaExportHelper.OnStartButtonClick();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060216E7 RID: 136935 RVA: 0x00B4D900 File Offset: 0x00B4BB00
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int OnShowChangePlayerPositionButtonClick(IntPtr l)
	{
		int result;
		try
		{
			TeamRoomInfoUIController teamRoomInfoUIController = (TeamRoomInfoUIController)LuaObject.checkSelf(l);
			teamRoomInfoUIController.m_luaExportHelper.OnShowChangePlayerPositionButtonClick();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060216E8 RID: 136936 RVA: 0x00B4D954 File Offset: 0x00B4BB54
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int OnChangePlayerPositionCompleteButtonClick(IntPtr l)
	{
		int result;
		try
		{
			TeamRoomInfoUIController teamRoomInfoUIController = (TeamRoomInfoUIController)LuaObject.checkSelf(l);
			teamRoomInfoUIController.m_luaExportHelper.OnChangePlayerPositionCompleteButtonClick();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060216E9 RID: 136937 RVA: 0x00B4D9A8 File Offset: 0x00B4BBA8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int OnChatButtonClick(IntPtr l)
	{
		int result;
		try
		{
			TeamRoomInfoUIController teamRoomInfoUIController = (TeamRoomInfoUIController)LuaObject.checkSelf(l);
			teamRoomInfoUIController.m_luaExportHelper.OnChatButtonClick();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060216EA RID: 136938 RVA: 0x00B4D9FC File Offset: 0x00B4BBFC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int OnAuthorityDropdownValueChanged(IntPtr l)
	{
		int result;
		try
		{
			TeamRoomInfoUIController teamRoomInfoUIController = (TeamRoomInfoUIController)LuaObject.checkSelf(l);
			int value;
			LuaObject.checkType(l, 2, out value);
			teamRoomInfoUIController.m_luaExportHelper.OnAuthorityDropdownValueChanged(value);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060216EB RID: 136939 RVA: 0x00B4DA58 File Offset: 0x00B4BC58
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int OnAuthorityLockButtonClick(IntPtr l)
	{
		int result;
		try
		{
			TeamRoomInfoUIController teamRoomInfoUIController = (TeamRoomInfoUIController)LuaObject.checkSelf(l);
			teamRoomInfoUIController.m_luaExportHelper.OnAuthorityLockButtonClick();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060216EC RID: 136940 RVA: 0x00B4DAAC File Offset: 0x00B4BCAC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int TeamRoomPlayerInfoUIController_OnInviteButtonClick(IntPtr l)
	{
		int result;
		try
		{
			TeamRoomInfoUIController teamRoomInfoUIController = (TeamRoomInfoUIController)LuaObject.checkSelf(l);
			TeamRoomPlayerInfoUIController ctrl;
			LuaObject.checkType<TeamRoomPlayerInfoUIController>(l, 2, out ctrl);
			teamRoomInfoUIController.m_luaExportHelper.TeamRoomPlayerInfoUIController_OnInviteButtonClick(ctrl);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060216ED RID: 136941 RVA: 0x00B4DB08 File Offset: 0x00B4BD08
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int TeamRoomPlayerInfoUIController_OnPlayerButtonClick(IntPtr l)
	{
		int result;
		try
		{
			TeamRoomInfoUIController teamRoomInfoUIController = (TeamRoomInfoUIController)LuaObject.checkSelf(l);
			TeamRoomPlayerInfoUIController ctrl;
			LuaObject.checkType<TeamRoomPlayerInfoUIController>(l, 2, out ctrl);
			teamRoomInfoUIController.m_luaExportHelper.TeamRoomPlayerInfoUIController_OnPlayerButtonClick(ctrl);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060216EE RID: 136942 RVA: 0x00B4DB64 File Offset: 0x00B4BD64
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int TeamRoomPlayerInfoUIController_OnBeginDrag(IntPtr l)
	{
		int result;
		try
		{
			TeamRoomInfoUIController teamRoomInfoUIController = (TeamRoomInfoUIController)LuaObject.checkSelf(l);
			TeamRoomPlayerInfoUIController ctrl;
			LuaObject.checkType<TeamRoomPlayerInfoUIController>(l, 2, out ctrl);
			PointerEventData eventData;
			LuaObject.checkType<PointerEventData>(l, 3, out eventData);
			teamRoomInfoUIController.m_luaExportHelper.TeamRoomPlayerInfoUIController_OnBeginDrag(ctrl, eventData);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060216EF RID: 136943 RVA: 0x00B4DBD0 File Offset: 0x00B4BDD0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int TeamRoomPlayerInfoUIController_OnEndDrag(IntPtr l)
	{
		int result;
		try
		{
			TeamRoomInfoUIController teamRoomInfoUIController = (TeamRoomInfoUIController)LuaObject.checkSelf(l);
			TeamRoomPlayerInfoUIController ctrl;
			LuaObject.checkType<TeamRoomPlayerInfoUIController>(l, 2, out ctrl);
			PointerEventData eventData;
			LuaObject.checkType<PointerEventData>(l, 3, out eventData);
			teamRoomInfoUIController.m_luaExportHelper.TeamRoomPlayerInfoUIController_OnEndDrag(ctrl, eventData);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060216F0 RID: 136944 RVA: 0x00B4DC3C File Offset: 0x00B4BE3C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int TeamRoomPlayerInfoUIController_OnDrag(IntPtr l)
	{
		int result;
		try
		{
			TeamRoomInfoUIController teamRoomInfoUIController = (TeamRoomInfoUIController)LuaObject.checkSelf(l);
			PointerEventData eventData;
			LuaObject.checkType<PointerEventData>(l, 2, out eventData);
			teamRoomInfoUIController.m_luaExportHelper.TeamRoomPlayerInfoUIController_OnDrag(eventData);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060216F1 RID: 136945 RVA: 0x00B4DC98 File Offset: 0x00B4BE98
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_Initlize(IntPtr l)
	{
		int result;
		try
		{
			TeamRoomInfoUIController teamRoomInfoUIController = (TeamRoomInfoUIController)LuaObject.checkSelf(l);
			string ctrlName;
			LuaObject.checkType(l, 2, out ctrlName);
			bool bindNow;
			LuaObject.checkType(l, 3, out bindNow);
			teamRoomInfoUIController.m_luaExportHelper.__callBase_Initlize(ctrlName, bindNow);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060216F2 RID: 136946 RVA: 0x00B4DD04 File Offset: 0x00B4BF04
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_BindFields(IntPtr l)
	{
		int result;
		try
		{
			TeamRoomInfoUIController teamRoomInfoUIController = (TeamRoomInfoUIController)LuaObject.checkSelf(l);
			teamRoomInfoUIController.m_luaExportHelper.__callBase_BindFields();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060216F3 RID: 136947 RVA: 0x00B4DD58 File Offset: 0x00B4BF58
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_OnBindFiledsCompleted(IntPtr l)
	{
		int result;
		try
		{
			TeamRoomInfoUIController teamRoomInfoUIController = (TeamRoomInfoUIController)LuaObject.checkSelf(l);
			teamRoomInfoUIController.m_luaExportHelper.__callBase_OnBindFiledsCompleted();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060216F4 RID: 136948 RVA: 0x00B4DDAC File Offset: 0x00B4BFAC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_BindFieldImpl(IntPtr l)
	{
		int result;
		try
		{
			TeamRoomInfoUIController teamRoomInfoUIController = (TeamRoomInfoUIController)LuaObject.checkSelf(l);
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
			UnityEngine.Object o = teamRoomInfoUIController.m_luaExportHelper.__callBase_BindFieldImpl(fieldType, path, initState, fieldName, ctrlName, optional);
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

	// Token: 0x060216F5 RID: 136949 RVA: 0x00B4DE54 File Offset: 0x00B4C054
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_Clear(IntPtr l)
	{
		int result;
		try
		{
			TeamRoomInfoUIController teamRoomInfoUIController = (TeamRoomInfoUIController)LuaObject.checkSelf(l);
			teamRoomInfoUIController.m_luaExportHelper.__callBase_Clear();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060216F6 RID: 136950 RVA: 0x00B4DEA8 File Offset: 0x00B4C0A8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_OnButtonClick(IntPtr l)
	{
		int result;
		try
		{
			TeamRoomInfoUIController teamRoomInfoUIController = (TeamRoomInfoUIController)LuaObject.checkSelf(l);
			Button button;
			LuaObject.checkType<Button>(l, 2, out button);
			string fieldName;
			LuaObject.checkType(l, 3, out fieldName);
			teamRoomInfoUIController.m_luaExportHelper.__callBase_OnButtonClick(button, fieldName);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060216F7 RID: 136951 RVA: 0x00B4DF14 File Offset: 0x00B4C114
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
				TeamRoomInfoUIController teamRoomInfoUIController = (TeamRoomInfoUIController)LuaObject.checkSelf(l);
				string[] fieldNames;
				LuaObject.checkArray<string>(l, 2, out fieldNames);
				Action<UIControllerBase> action;
				LuaObject.checkDelegate<Action<UIControllerBase>>(l, 3, out action);
				teamRoomInfoUIController.m_luaExportHelper.__callBase_SetButtonClickListener(fieldNames, action);
				LuaObject.pushValue(l, true);
				result = 1;
			}
			else if (LuaObject.matchType(l, total, 2, typeof(string), typeof(Action<UIControllerBase>)))
			{
				TeamRoomInfoUIController teamRoomInfoUIController2 = (TeamRoomInfoUIController)LuaObject.checkSelf(l);
				string fieldName;
				LuaObject.checkType(l, 2, out fieldName);
				Action<UIControllerBase> action2;
				LuaObject.checkDelegate<Action<UIControllerBase>>(l, 3, out action2);
				teamRoomInfoUIController2.m_luaExportHelper.__callBase_SetButtonClickListener(fieldName, action2);
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

	// Token: 0x060216F8 RID: 136952 RVA: 0x00B4E024 File Offset: 0x00B4C224
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_SetButtonDoubleClickListener(IntPtr l)
	{
		int result;
		try
		{
			TeamRoomInfoUIController teamRoomInfoUIController = (TeamRoomInfoUIController)LuaObject.checkSelf(l);
			string fieldName;
			LuaObject.checkType(l, 2, out fieldName);
			Action<UIControllerBase> action;
			LuaObject.checkDelegate<Action<UIControllerBase>>(l, 3, out action);
			teamRoomInfoUIController.m_luaExportHelper.__callBase_SetButtonDoubleClickListener(fieldName, action);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060216F9 RID: 136953 RVA: 0x00B4E090 File Offset: 0x00B4C290
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_SetButtonLongPressStartListener(IntPtr l)
	{
		int result;
		try
		{
			TeamRoomInfoUIController teamRoomInfoUIController = (TeamRoomInfoUIController)LuaObject.checkSelf(l);
			string fieldName;
			LuaObject.checkType(l, 2, out fieldName);
			Action<UIControllerBase> action;
			LuaObject.checkDelegate<Action<UIControllerBase>>(l, 3, out action);
			teamRoomInfoUIController.m_luaExportHelper.__callBase_SetButtonLongPressStartListener(fieldName, action);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060216FA RID: 136954 RVA: 0x00B4E0FC File Offset: 0x00B4C2FC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_SetButtonLongPressingListener(IntPtr l)
	{
		int result;
		try
		{
			TeamRoomInfoUIController teamRoomInfoUIController = (TeamRoomInfoUIController)LuaObject.checkSelf(l);
			string fieldName;
			LuaObject.checkType(l, 2, out fieldName);
			Action<UIControllerBase> action;
			LuaObject.checkDelegate<Action<UIControllerBase>>(l, 3, out action);
			teamRoomInfoUIController.m_luaExportHelper.__callBase_SetButtonLongPressingListener(fieldName, action);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060216FB RID: 136955 RVA: 0x00B4E168 File Offset: 0x00B4C368
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_SetButtonLongPressEndListener(IntPtr l)
	{
		int result;
		try
		{
			TeamRoomInfoUIController teamRoomInfoUIController = (TeamRoomInfoUIController)LuaObject.checkSelf(l);
			string fieldName;
			LuaObject.checkType(l, 2, out fieldName);
			Action<UIControllerBase> action;
			LuaObject.checkDelegate<Action<UIControllerBase>>(l, 3, out action);
			teamRoomInfoUIController.m_luaExportHelper.__callBase_SetButtonLongPressEndListener(fieldName, action);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060216FC RID: 136956 RVA: 0x00B4E1D4 File Offset: 0x00B4C3D4
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
				TeamRoomInfoUIController teamRoomInfoUIController = (TeamRoomInfoUIController)LuaObject.checkSelf(l);
				string[] fieldNames;
				LuaObject.checkArray<string>(l, 2, out fieldNames);
				Action<UIControllerBase, bool> action;
				LuaObject.checkDelegate<Action<UIControllerBase, bool>>(l, 3, out action);
				teamRoomInfoUIController.m_luaExportHelper.__callBase_SetToggleValueChangedListener(fieldNames, action);
				LuaObject.pushValue(l, true);
				result = 1;
			}
			else if (LuaObject.matchType(l, total, 2, typeof(string), typeof(Action<UIControllerBase, bool>)))
			{
				TeamRoomInfoUIController teamRoomInfoUIController2 = (TeamRoomInfoUIController)LuaObject.checkSelf(l);
				string fieldName;
				LuaObject.checkType(l, 2, out fieldName);
				Action<UIControllerBase, bool> action2;
				LuaObject.checkDelegate<Action<UIControllerBase, bool>>(l, 3, out action2);
				teamRoomInfoUIController2.m_luaExportHelper.__callBase_SetToggleValueChangedListener(fieldName, action2);
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

	// Token: 0x060216FD RID: 136957 RVA: 0x00B4E2E4 File Offset: 0x00B4C4E4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_ToString(IntPtr l)
	{
		int result;
		try
		{
			TeamRoomInfoUIController teamRoomInfoUIController = (TeamRoomInfoUIController)LuaObject.checkSelf(l);
			string s = teamRoomInfoUIController.m_luaExportHelper.__callBase_ToString();
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

	// Token: 0x060216FE RID: 136958 RVA: 0x00B4E340 File Offset: 0x00B4C540
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callDele_EventOnLeave(IntPtr l)
	{
		int result;
		try
		{
			TeamRoomInfoUIController teamRoomInfoUIController = (TeamRoomInfoUIController)LuaObject.checkSelf(l);
			teamRoomInfoUIController.m_luaExportHelper.__callDele_EventOnLeave();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060216FF RID: 136959 RVA: 0x00B4E394 File Offset: 0x00B4C594
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __clearDele_EventOnLeave(IntPtr l)
	{
		int result;
		try
		{
			TeamRoomInfoUIController teamRoomInfoUIController = (TeamRoomInfoUIController)LuaObject.checkSelf(l);
			teamRoomInfoUIController.m_luaExportHelper.__clearDele_EventOnLeave();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06021700 RID: 136960 RVA: 0x00B4E3E8 File Offset: 0x00B4C5E8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callDele_EventOnStart(IntPtr l)
	{
		int result;
		try
		{
			TeamRoomInfoUIController teamRoomInfoUIController = (TeamRoomInfoUIController)LuaObject.checkSelf(l);
			teamRoomInfoUIController.m_luaExportHelper.__callDele_EventOnStart();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06021701 RID: 136961 RVA: 0x00B4E43C File Offset: 0x00B4C63C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __clearDele_EventOnStart(IntPtr l)
	{
		int result;
		try
		{
			TeamRoomInfoUIController teamRoomInfoUIController = (TeamRoomInfoUIController)LuaObject.checkSelf(l);
			teamRoomInfoUIController.m_luaExportHelper.__clearDele_EventOnStart();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06021702 RID: 136962 RVA: 0x00B4E490 File Offset: 0x00B4C690
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callDele_EventOnShowChangePlayerPosition(IntPtr l)
	{
		int result;
		try
		{
			TeamRoomInfoUIController teamRoomInfoUIController = (TeamRoomInfoUIController)LuaObject.checkSelf(l);
			teamRoomInfoUIController.m_luaExportHelper.__callDele_EventOnShowChangePlayerPosition();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06021703 RID: 136963 RVA: 0x00B4E4E4 File Offset: 0x00B4C6E4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __clearDele_EventOnShowChangePlayerPosition(IntPtr l)
	{
		int result;
		try
		{
			TeamRoomInfoUIController teamRoomInfoUIController = (TeamRoomInfoUIController)LuaObject.checkSelf(l);
			teamRoomInfoUIController.m_luaExportHelper.__clearDele_EventOnShowChangePlayerPosition();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06021704 RID: 136964 RVA: 0x00B4E538 File Offset: 0x00B4C738
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callDele_EventOnChangePlayerPositionComplete(IntPtr l)
	{
		int result;
		try
		{
			TeamRoomInfoUIController teamRoomInfoUIController = (TeamRoomInfoUIController)LuaObject.checkSelf(l);
			teamRoomInfoUIController.m_luaExportHelper.__callDele_EventOnChangePlayerPositionComplete();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06021705 RID: 136965 RVA: 0x00B4E58C File Offset: 0x00B4C78C
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int __clearDele_EventOnChangePlayerPositionComplete(IntPtr l)
	{
		int result;
		try
		{
			TeamRoomInfoUIController teamRoomInfoUIController = (TeamRoomInfoUIController)LuaObject.checkSelf(l);
			teamRoomInfoUIController.m_luaExportHelper.__clearDele_EventOnChangePlayerPositionComplete();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06021706 RID: 136966 RVA: 0x00B4E5E0 File Offset: 0x00B4C7E0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callDele_EventOnShowChat(IntPtr l)
	{
		int result;
		try
		{
			TeamRoomInfoUIController teamRoomInfoUIController = (TeamRoomInfoUIController)LuaObject.checkSelf(l);
			teamRoomInfoUIController.m_luaExportHelper.__callDele_EventOnShowChat();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06021707 RID: 136967 RVA: 0x00B4E634 File Offset: 0x00B4C834
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int __clearDele_EventOnShowChat(IntPtr l)
	{
		int result;
		try
		{
			TeamRoomInfoUIController teamRoomInfoUIController = (TeamRoomInfoUIController)LuaObject.checkSelf(l);
			teamRoomInfoUIController.m_luaExportHelper.__clearDele_EventOnShowChat();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06021708 RID: 136968 RVA: 0x00B4E688 File Offset: 0x00B4C888
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callDele_EventOnChangeAuthority(IntPtr l)
	{
		int result;
		try
		{
			TeamRoomInfoUIController teamRoomInfoUIController = (TeamRoomInfoUIController)LuaObject.checkSelf(l);
			TeamRoomAuthority obj;
			LuaObject.checkEnum<TeamRoomAuthority>(l, 2, out obj);
			teamRoomInfoUIController.m_luaExportHelper.__callDele_EventOnChangeAuthority(obj);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06021709 RID: 136969 RVA: 0x00B4E6E4 File Offset: 0x00B4C8E4
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int __clearDele_EventOnChangeAuthority(IntPtr l)
	{
		int result;
		try
		{
			TeamRoomInfoUIController teamRoomInfoUIController = (TeamRoomInfoUIController)LuaObject.checkSelf(l);
			TeamRoomAuthority obj;
			LuaObject.checkEnum<TeamRoomAuthority>(l, 2, out obj);
			teamRoomInfoUIController.m_luaExportHelper.__clearDele_EventOnChangeAuthority(obj);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0602170A RID: 136970 RVA: 0x00B4E740 File Offset: 0x00B4C940
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int __callDele_EventOnShowInvite(IntPtr l)
	{
		int result;
		try
		{
			TeamRoomInfoUIController teamRoomInfoUIController = (TeamRoomInfoUIController)LuaObject.checkSelf(l);
			teamRoomInfoUIController.m_luaExportHelper.__callDele_EventOnShowInvite();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0602170B RID: 136971 RVA: 0x00B4E794 File Offset: 0x00B4C994
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __clearDele_EventOnShowInvite(IntPtr l)
	{
		int result;
		try
		{
			TeamRoomInfoUIController teamRoomInfoUIController = (TeamRoomInfoUIController)LuaObject.checkSelf(l);
			teamRoomInfoUIController.m_luaExportHelper.__clearDele_EventOnShowInvite();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0602170C RID: 136972 RVA: 0x00B4E7E8 File Offset: 0x00B4C9E8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callDele_EventOnShowPlayerInfo(IntPtr l)
	{
		int result;
		try
		{
			TeamRoomInfoUIController teamRoomInfoUIController = (TeamRoomInfoUIController)LuaObject.checkSelf(l);
			int arg;
			LuaObject.checkType(l, 2, out arg);
			RectTransform arg2;
			LuaObject.checkType<RectTransform>(l, 3, out arg2);
			teamRoomInfoUIController.m_luaExportHelper.__callDele_EventOnShowPlayerInfo(arg, arg2);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0602170D RID: 136973 RVA: 0x00B4E854 File Offset: 0x00B4CA54
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int __clearDele_EventOnShowPlayerInfo(IntPtr l)
	{
		int result;
		try
		{
			TeamRoomInfoUIController teamRoomInfoUIController = (TeamRoomInfoUIController)LuaObject.checkSelf(l);
			int arg;
			LuaObject.checkType(l, 2, out arg);
			RectTransform arg2;
			LuaObject.checkType<RectTransform>(l, 3, out arg2);
			teamRoomInfoUIController.m_luaExportHelper.__clearDele_EventOnShowPlayerInfo(arg, arg2);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0602170E RID: 136974 RVA: 0x00B4E8C0 File Offset: 0x00B4CAC0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_EventOnLeave(IntPtr l)
	{
		int result;
		try
		{
			TeamRoomInfoUIController teamRoomInfoUIController = (TeamRoomInfoUIController)LuaObject.checkSelf(l);
			Action value;
			int num = LuaObject.checkDelegate<Action>(l, 2, out value);
			if (num != 0)
			{
				if (num == 1)
				{
					teamRoomInfoUIController.EventOnLeave += value;
				}
				else if (num == 2)
				{
					teamRoomInfoUIController.EventOnLeave -= value;
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

	// Token: 0x0602170F RID: 136975 RVA: 0x00B4E940 File Offset: 0x00B4CB40
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_EventOnStart(IntPtr l)
	{
		int result;
		try
		{
			TeamRoomInfoUIController teamRoomInfoUIController = (TeamRoomInfoUIController)LuaObject.checkSelf(l);
			Action value;
			int num = LuaObject.checkDelegate<Action>(l, 2, out value);
			if (num != 0)
			{
				if (num == 1)
				{
					teamRoomInfoUIController.EventOnStart += value;
				}
				else if (num == 2)
				{
					teamRoomInfoUIController.EventOnStart -= value;
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

	// Token: 0x06021710 RID: 136976 RVA: 0x00B4E9C0 File Offset: 0x00B4CBC0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_EventOnShowChangePlayerPosition(IntPtr l)
	{
		int result;
		try
		{
			TeamRoomInfoUIController teamRoomInfoUIController = (TeamRoomInfoUIController)LuaObject.checkSelf(l);
			Action value;
			int num = LuaObject.checkDelegate<Action>(l, 2, out value);
			if (num != 0)
			{
				if (num == 1)
				{
					teamRoomInfoUIController.EventOnShowChangePlayerPosition += value;
				}
				else if (num == 2)
				{
					teamRoomInfoUIController.EventOnShowChangePlayerPosition -= value;
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

	// Token: 0x06021711 RID: 136977 RVA: 0x00B4EA40 File Offset: 0x00B4CC40
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_EventOnChangePlayerPositionComplete(IntPtr l)
	{
		int result;
		try
		{
			TeamRoomInfoUIController teamRoomInfoUIController = (TeamRoomInfoUIController)LuaObject.checkSelf(l);
			Action value;
			int num = LuaObject.checkDelegate<Action>(l, 2, out value);
			if (num != 0)
			{
				if (num == 1)
				{
					teamRoomInfoUIController.EventOnChangePlayerPositionComplete += value;
				}
				else if (num == 2)
				{
					teamRoomInfoUIController.EventOnChangePlayerPositionComplete -= value;
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

	// Token: 0x06021712 RID: 136978 RVA: 0x00B4EAC0 File Offset: 0x00B4CCC0
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_EventOnShowChat(IntPtr l)
	{
		int result;
		try
		{
			TeamRoomInfoUIController teamRoomInfoUIController = (TeamRoomInfoUIController)LuaObject.checkSelf(l);
			Action value;
			int num = LuaObject.checkDelegate<Action>(l, 2, out value);
			if (num != 0)
			{
				if (num == 1)
				{
					teamRoomInfoUIController.EventOnShowChat += value;
				}
				else if (num == 2)
				{
					teamRoomInfoUIController.EventOnShowChat -= value;
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

	// Token: 0x06021713 RID: 136979 RVA: 0x00B4EB40 File Offset: 0x00B4CD40
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_EventOnChangeAuthority(IntPtr l)
	{
		int result;
		try
		{
			TeamRoomInfoUIController teamRoomInfoUIController = (TeamRoomInfoUIController)LuaObject.checkSelf(l);
			Action<TeamRoomAuthority> value;
			int num = LuaObject.checkDelegate<Action<TeamRoomAuthority>>(l, 2, out value);
			if (num != 0)
			{
				if (num == 1)
				{
					teamRoomInfoUIController.EventOnChangeAuthority += value;
				}
				else if (num == 2)
				{
					teamRoomInfoUIController.EventOnChangeAuthority -= value;
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

	// Token: 0x06021714 RID: 136980 RVA: 0x00B4EBC0 File Offset: 0x00B4CDC0
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_EventOnShowInvite(IntPtr l)
	{
		int result;
		try
		{
			TeamRoomInfoUIController teamRoomInfoUIController = (TeamRoomInfoUIController)LuaObject.checkSelf(l);
			Action value;
			int num = LuaObject.checkDelegate<Action>(l, 2, out value);
			if (num != 0)
			{
				if (num == 1)
				{
					teamRoomInfoUIController.EventOnShowInvite += value;
				}
				else if (num == 2)
				{
					teamRoomInfoUIController.EventOnShowInvite -= value;
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

	// Token: 0x06021715 RID: 136981 RVA: 0x00B4EC40 File Offset: 0x00B4CE40
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_EventOnShowPlayerInfo(IntPtr l)
	{
		int result;
		try
		{
			TeamRoomInfoUIController teamRoomInfoUIController = (TeamRoomInfoUIController)LuaObject.checkSelf(l);
			Action<int, RectTransform> value;
			int num = LuaObject.checkDelegate<Action<int, RectTransform>>(l, 2, out value);
			if (num != 0)
			{
				if (num == 1)
				{
					teamRoomInfoUIController.EventOnShowPlayerInfo += value;
				}
				else if (num == 2)
				{
					teamRoomInfoUIController.EventOnShowPlayerInfo -= value;
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

	// Token: 0x06021716 RID: 136982 RVA: 0x00B4ECC0 File Offset: 0x00B4CEC0
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_m_uiStateController(IntPtr l)
	{
		int result;
		try
		{
			TeamRoomInfoUIController teamRoomInfoUIController = (TeamRoomInfoUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, teamRoomInfoUIController.m_luaExportHelper.m_uiStateController);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06021717 RID: 136983 RVA: 0x00B4ED18 File Offset: 0x00B4CF18
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_uiStateController(IntPtr l)
	{
		int result;
		try
		{
			TeamRoomInfoUIController teamRoomInfoUIController = (TeamRoomInfoUIController)LuaObject.checkSelf(l);
			CommonUIStateController uiStateController;
			LuaObject.checkType<CommonUIStateController>(l, 2, out uiStateController);
			teamRoomInfoUIController.m_luaExportHelper.m_uiStateController = uiStateController;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06021718 RID: 136984 RVA: 0x00B4ED74 File Offset: 0x00B4CF74
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_guildOrTeamUIStateController(IntPtr l)
	{
		int result;
		try
		{
			TeamRoomInfoUIController teamRoomInfoUIController = (TeamRoomInfoUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, teamRoomInfoUIController.m_luaExportHelper.m_guildOrTeamUIStateController);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06021719 RID: 136985 RVA: 0x00B4EDCC File Offset: 0x00B4CFCC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_guildOrTeamUIStateController(IntPtr l)
	{
		int result;
		try
		{
			TeamRoomInfoUIController teamRoomInfoUIController = (TeamRoomInfoUIController)LuaObject.checkSelf(l);
			CommonUIStateController guildOrTeamUIStateController;
			LuaObject.checkType<CommonUIStateController>(l, 2, out guildOrTeamUIStateController);
			teamRoomInfoUIController.m_luaExportHelper.m_guildOrTeamUIStateController = guildOrTeamUIStateController;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0602171A RID: 136986 RVA: 0x00B4EE28 File Offset: 0x00B4D028
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_waitStartBattleGameObject(IntPtr l)
	{
		int result;
		try
		{
			TeamRoomInfoUIController teamRoomInfoUIController = (TeamRoomInfoUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, teamRoomInfoUIController.m_luaExportHelper.m_waitStartBattleGameObject);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0602171B RID: 136987 RVA: 0x00B4EE80 File Offset: 0x00B4D080
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_m_waitStartBattleGameObject(IntPtr l)
	{
		int result;
		try
		{
			TeamRoomInfoUIController teamRoomInfoUIController = (TeamRoomInfoUIController)LuaObject.checkSelf(l);
			GameObject waitStartBattleGameObject;
			LuaObject.checkType<GameObject>(l, 2, out waitStartBattleGameObject);
			teamRoomInfoUIController.m_luaExportHelper.m_waitStartBattleGameObject = waitStartBattleGameObject;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0602171C RID: 136988 RVA: 0x00B4EEDC File Offset: 0x00B4D0DC
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_m_startButton(IntPtr l)
	{
		int result;
		try
		{
			TeamRoomInfoUIController teamRoomInfoUIController = (TeamRoomInfoUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, teamRoomInfoUIController.m_luaExportHelper.m_startButton);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0602171D RID: 136989 RVA: 0x00B4EF34 File Offset: 0x00B4D134
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_startButton(IntPtr l)
	{
		int result;
		try
		{
			TeamRoomInfoUIController teamRoomInfoUIController = (TeamRoomInfoUIController)LuaObject.checkSelf(l);
			Button startButton;
			LuaObject.checkType<Button>(l, 2, out startButton);
			teamRoomInfoUIController.m_luaExportHelper.m_startButton = startButton;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0602171E RID: 136990 RVA: 0x00B4EF90 File Offset: 0x00B4D190
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_startButtonUIStateController(IntPtr l)
	{
		int result;
		try
		{
			TeamRoomInfoUIController teamRoomInfoUIController = (TeamRoomInfoUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, teamRoomInfoUIController.m_luaExportHelper.m_startButtonUIStateController);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0602171F RID: 136991 RVA: 0x00B4EFE8 File Offset: 0x00B4D1E8
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_m_startButtonUIStateController(IntPtr l)
	{
		int result;
		try
		{
			TeamRoomInfoUIController teamRoomInfoUIController = (TeamRoomInfoUIController)LuaObject.checkSelf(l);
			CommonUIStateController startButtonUIStateController;
			LuaObject.checkType<CommonUIStateController>(l, 2, out startButtonUIStateController);
			teamRoomInfoUIController.m_luaExportHelper.m_startButtonUIStateController = startButtonUIStateController;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06021720 RID: 136992 RVA: 0x00B4F044 File Offset: 0x00B4D244
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_leaveButton(IntPtr l)
	{
		int result;
		try
		{
			TeamRoomInfoUIController teamRoomInfoUIController = (TeamRoomInfoUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, teamRoomInfoUIController.m_luaExportHelper.m_leaveButton);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06021721 RID: 136993 RVA: 0x00B4F09C File Offset: 0x00B4D29C
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_m_leaveButton(IntPtr l)
	{
		int result;
		try
		{
			TeamRoomInfoUIController teamRoomInfoUIController = (TeamRoomInfoUIController)LuaObject.checkSelf(l);
			Button leaveButton;
			LuaObject.checkType<Button>(l, 2, out leaveButton);
			teamRoomInfoUIController.m_luaExportHelper.m_leaveButton = leaveButton;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06021722 RID: 136994 RVA: 0x00B4F0F8 File Offset: 0x00B4D2F8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_showChangePlayerPositionButton(IntPtr l)
	{
		int result;
		try
		{
			TeamRoomInfoUIController teamRoomInfoUIController = (TeamRoomInfoUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, teamRoomInfoUIController.m_luaExportHelper.m_showChangePlayerPositionButton);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06021723 RID: 136995 RVA: 0x00B4F150 File Offset: 0x00B4D350
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_m_showChangePlayerPositionButton(IntPtr l)
	{
		int result;
		try
		{
			TeamRoomInfoUIController teamRoomInfoUIController = (TeamRoomInfoUIController)LuaObject.checkSelf(l);
			Button showChangePlayerPositionButton;
			LuaObject.checkType<Button>(l, 2, out showChangePlayerPositionButton);
			teamRoomInfoUIController.m_luaExportHelper.m_showChangePlayerPositionButton = showChangePlayerPositionButton;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06021724 RID: 136996 RVA: 0x00B4F1AC File Offset: 0x00B4D3AC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_chatButton(IntPtr l)
	{
		int result;
		try
		{
			TeamRoomInfoUIController teamRoomInfoUIController = (TeamRoomInfoUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, teamRoomInfoUIController.m_luaExportHelper.m_chatButton);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06021725 RID: 136997 RVA: 0x00B4F204 File Offset: 0x00B4D404
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_chatButton(IntPtr l)
	{
		int result;
		try
		{
			TeamRoomInfoUIController teamRoomInfoUIController = (TeamRoomInfoUIController)LuaObject.checkSelf(l);
			Button chatButton;
			LuaObject.checkType<Button>(l, 2, out chatButton);
			teamRoomInfoUIController.m_luaExportHelper.m_chatButton = chatButton;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06021726 RID: 136998 RVA: 0x00B4F260 File Offset: 0x00B4D460
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_m_gameFunctionTypeNameText(IntPtr l)
	{
		int result;
		try
		{
			TeamRoomInfoUIController teamRoomInfoUIController = (TeamRoomInfoUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, teamRoomInfoUIController.m_luaExportHelper.m_gameFunctionTypeNameText);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06021727 RID: 136999 RVA: 0x00B4F2B8 File Offset: 0x00B4D4B8
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_m_gameFunctionTypeNameText(IntPtr l)
	{
		int result;
		try
		{
			TeamRoomInfoUIController teamRoomInfoUIController = (TeamRoomInfoUIController)LuaObject.checkSelf(l);
			Text gameFunctionTypeNameText;
			LuaObject.checkType<Text>(l, 2, out gameFunctionTypeNameText);
			teamRoomInfoUIController.m_luaExportHelper.m_gameFunctionTypeNameText = gameFunctionTypeNameText;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06021728 RID: 137000 RVA: 0x00B4F314 File Offset: 0x00B4D514
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_m_locationNameText(IntPtr l)
	{
		int result;
		try
		{
			TeamRoomInfoUIController teamRoomInfoUIController = (TeamRoomInfoUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, teamRoomInfoUIController.m_luaExportHelper.m_locationNameText);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06021729 RID: 137001 RVA: 0x00B4F36C File Offset: 0x00B4D56C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_locationNameText(IntPtr l)
	{
		int result;
		try
		{
			TeamRoomInfoUIController teamRoomInfoUIController = (TeamRoomInfoUIController)LuaObject.checkSelf(l);
			Text locationNameText;
			LuaObject.checkType<Text>(l, 2, out locationNameText);
			teamRoomInfoUIController.m_luaExportHelper.m_locationNameText = locationNameText;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0602172A RID: 137002 RVA: 0x00B4F3C8 File Offset: 0x00B4D5C8
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_m_playerLevelText(IntPtr l)
	{
		int result;
		try
		{
			TeamRoomInfoUIController teamRoomInfoUIController = (TeamRoomInfoUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, teamRoomInfoUIController.m_luaExportHelper.m_playerLevelText);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0602172B RID: 137003 RVA: 0x00B4F420 File Offset: 0x00B4D620
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_m_playerLevelText(IntPtr l)
	{
		int result;
		try
		{
			TeamRoomInfoUIController teamRoomInfoUIController = (TeamRoomInfoUIController)LuaObject.checkSelf(l);
			Text playerLevelText;
			LuaObject.checkType<Text>(l, 2, out playerLevelText);
			teamRoomInfoUIController.m_luaExportHelper.m_playerLevelText = playerLevelText;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0602172C RID: 137004 RVA: 0x00B4F47C File Offset: 0x00B4D67C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_quitCountdownText(IntPtr l)
	{
		int result;
		try
		{
			TeamRoomInfoUIController teamRoomInfoUIController = (TeamRoomInfoUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, teamRoomInfoUIController.m_luaExportHelper.m_quitCountdownText);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0602172D RID: 137005 RVA: 0x00B4F4D4 File Offset: 0x00B4D6D4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_quitCountdownText(IntPtr l)
	{
		int result;
		try
		{
			TeamRoomInfoUIController teamRoomInfoUIController = (TeamRoomInfoUIController)LuaObject.checkSelf(l);
			Text quitCountdownText;
			LuaObject.checkType<Text>(l, 2, out quitCountdownText);
			teamRoomInfoUIController.m_luaExportHelper.m_quitCountdownText = quitCountdownText;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0602172E RID: 137006 RVA: 0x00B4F530 File Offset: 0x00B4D730
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_energyText(IntPtr l)
	{
		int result;
		try
		{
			TeamRoomInfoUIController teamRoomInfoUIController = (TeamRoomInfoUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, teamRoomInfoUIController.m_luaExportHelper.m_energyText);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0602172F RID: 137007 RVA: 0x00B4F588 File Offset: 0x00B4D788
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_energyText(IntPtr l)
	{
		int result;
		try
		{
			TeamRoomInfoUIController teamRoomInfoUIController = (TeamRoomInfoUIController)LuaObject.checkSelf(l);
			Text energyText;
			LuaObject.checkType<Text>(l, 2, out energyText);
			teamRoomInfoUIController.m_luaExportHelper.m_energyText = energyText;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06021730 RID: 137008 RVA: 0x00B4F5E4 File Offset: 0x00B4D7E4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_guildMassiveCombatNameText(IntPtr l)
	{
		int result;
		try
		{
			TeamRoomInfoUIController teamRoomInfoUIController = (TeamRoomInfoUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, teamRoomInfoUIController.m_luaExportHelper.m_guildMassiveCombatNameText);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06021731 RID: 137009 RVA: 0x00B4F63C File Offset: 0x00B4D83C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_guildMassiveCombatNameText(IntPtr l)
	{
		int result;
		try
		{
			TeamRoomInfoUIController teamRoomInfoUIController = (TeamRoomInfoUIController)LuaObject.checkSelf(l);
			Text guildMassiveCombatNameText;
			LuaObject.checkType<Text>(l, 2, out guildMassiveCombatNameText);
			teamRoomInfoUIController.m_luaExportHelper.m_guildMassiveCombatNameText = guildMassiveCombatNameText;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06021732 RID: 137010 RVA: 0x00B4F698 File Offset: 0x00B4D898
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_authorityDropdown(IntPtr l)
	{
		int result;
		try
		{
			TeamRoomInfoUIController teamRoomInfoUIController = (TeamRoomInfoUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, teamRoomInfoUIController.m_luaExportHelper.m_authorityDropdown);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06021733 RID: 137011 RVA: 0x00B4F6F0 File Offset: 0x00B4D8F0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_authorityDropdown(IntPtr l)
	{
		int result;
		try
		{
			TeamRoomInfoUIController teamRoomInfoUIController = (TeamRoomInfoUIController)LuaObject.checkSelf(l);
			Dropdown authorityDropdown;
			LuaObject.checkType<Dropdown>(l, 2, out authorityDropdown);
			teamRoomInfoUIController.m_luaExportHelper.m_authorityDropdown = authorityDropdown;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06021734 RID: 137012 RVA: 0x00B4F74C File Offset: 0x00B4D94C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_authorityLockButton(IntPtr l)
	{
		int result;
		try
		{
			TeamRoomInfoUIController teamRoomInfoUIController = (TeamRoomInfoUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, teamRoomInfoUIController.m_luaExportHelper.m_authorityLockButton);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06021735 RID: 137013 RVA: 0x00B4F7A4 File Offset: 0x00B4D9A4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_authorityLockButton(IntPtr l)
	{
		int result;
		try
		{
			TeamRoomInfoUIController teamRoomInfoUIController = (TeamRoomInfoUIController)LuaObject.checkSelf(l);
			Button authorityLockButton;
			LuaObject.checkType<Button>(l, 2, out authorityLockButton);
			teamRoomInfoUIController.m_luaExportHelper.m_authorityLockButton = authorityLockButton;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06021736 RID: 137014 RVA: 0x00B4F800 File Offset: 0x00B4DA00
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_m_playerInfo0GameObject(IntPtr l)
	{
		int result;
		try
		{
			TeamRoomInfoUIController teamRoomInfoUIController = (TeamRoomInfoUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, teamRoomInfoUIController.m_luaExportHelper.m_playerInfo0GameObject);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06021737 RID: 137015 RVA: 0x00B4F858 File Offset: 0x00B4DA58
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_m_playerInfo0GameObject(IntPtr l)
	{
		int result;
		try
		{
			TeamRoomInfoUIController teamRoomInfoUIController = (TeamRoomInfoUIController)LuaObject.checkSelf(l);
			GameObject playerInfo0GameObject;
			LuaObject.checkType<GameObject>(l, 2, out playerInfo0GameObject);
			teamRoomInfoUIController.m_luaExportHelper.m_playerInfo0GameObject = playerInfo0GameObject;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06021738 RID: 137016 RVA: 0x00B4F8B4 File Offset: 0x00B4DAB4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_playerInfo1GameObject(IntPtr l)
	{
		int result;
		try
		{
			TeamRoomInfoUIController teamRoomInfoUIController = (TeamRoomInfoUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, teamRoomInfoUIController.m_luaExportHelper.m_playerInfo1GameObject);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06021739 RID: 137017 RVA: 0x00B4F90C File Offset: 0x00B4DB0C
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_m_playerInfo1GameObject(IntPtr l)
	{
		int result;
		try
		{
			TeamRoomInfoUIController teamRoomInfoUIController = (TeamRoomInfoUIController)LuaObject.checkSelf(l);
			GameObject playerInfo1GameObject;
			LuaObject.checkType<GameObject>(l, 2, out playerInfo1GameObject);
			teamRoomInfoUIController.m_luaExportHelper.m_playerInfo1GameObject = playerInfo1GameObject;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0602173A RID: 137018 RVA: 0x00B4F968 File Offset: 0x00B4DB68
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_playerInfo2GameObject(IntPtr l)
	{
		int result;
		try
		{
			TeamRoomInfoUIController teamRoomInfoUIController = (TeamRoomInfoUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, teamRoomInfoUIController.m_luaExportHelper.m_playerInfo2GameObject);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0602173B RID: 137019 RVA: 0x00B4F9C0 File Offset: 0x00B4DBC0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_playerInfo2GameObject(IntPtr l)
	{
		int result;
		try
		{
			TeamRoomInfoUIController teamRoomInfoUIController = (TeamRoomInfoUIController)LuaObject.checkSelf(l);
			GameObject playerInfo2GameObject;
			LuaObject.checkType<GameObject>(l, 2, out playerInfo2GameObject);
			teamRoomInfoUIController.m_luaExportHelper.m_playerInfo2GameObject = playerInfo2GameObject;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0602173C RID: 137020 RVA: 0x00B4FA1C File Offset: 0x00B4DC1C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_changePlayerPositionPanelGameObject(IntPtr l)
	{
		int result;
		try
		{
			TeamRoomInfoUIController teamRoomInfoUIController = (TeamRoomInfoUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, teamRoomInfoUIController.m_luaExportHelper.m_changePlayerPositionPanelGameObject);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0602173D RID: 137021 RVA: 0x00B4FA74 File Offset: 0x00B4DC74
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_changePlayerPositionPanelGameObject(IntPtr l)
	{
		int result;
		try
		{
			TeamRoomInfoUIController teamRoomInfoUIController = (TeamRoomInfoUIController)LuaObject.checkSelf(l);
			GameObject changePlayerPositionPanelGameObject;
			LuaObject.checkType<GameObject>(l, 2, out changePlayerPositionPanelGameObject);
			teamRoomInfoUIController.m_luaExportHelper.m_changePlayerPositionPanelGameObject = changePlayerPositionPanelGameObject;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0602173E RID: 137022 RVA: 0x00B4FAD0 File Offset: 0x00B4DCD0
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_m_changePlayerPositionCompleteButton(IntPtr l)
	{
		int result;
		try
		{
			TeamRoomInfoUIController teamRoomInfoUIController = (TeamRoomInfoUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, teamRoomInfoUIController.m_luaExportHelper.m_changePlayerPositionCompleteButton);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0602173F RID: 137023 RVA: 0x00B4FB28 File Offset: 0x00B4DD28
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_changePlayerPositionCompleteButton(IntPtr l)
	{
		int result;
		try
		{
			TeamRoomInfoUIController teamRoomInfoUIController = (TeamRoomInfoUIController)LuaObject.checkSelf(l);
			Button changePlayerPositionCompleteButton;
			LuaObject.checkType<Button>(l, 2, out changePlayerPositionCompleteButton);
			teamRoomInfoUIController.m_luaExportHelper.m_changePlayerPositionCompleteButton = changePlayerPositionCompleteButton;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06021740 RID: 137024 RVA: 0x00B4FB84 File Offset: 0x00B4DD84
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_changePlayerPositionInfo0GameObject(IntPtr l)
	{
		int result;
		try
		{
			TeamRoomInfoUIController teamRoomInfoUIController = (TeamRoomInfoUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, teamRoomInfoUIController.m_luaExportHelper.m_changePlayerPositionInfo0GameObject);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06021741 RID: 137025 RVA: 0x00B4FBDC File Offset: 0x00B4DDDC
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_m_changePlayerPositionInfo0GameObject(IntPtr l)
	{
		int result;
		try
		{
			TeamRoomInfoUIController teamRoomInfoUIController = (TeamRoomInfoUIController)LuaObject.checkSelf(l);
			GameObject changePlayerPositionInfo0GameObject;
			LuaObject.checkType<GameObject>(l, 2, out changePlayerPositionInfo0GameObject);
			teamRoomInfoUIController.m_luaExportHelper.m_changePlayerPositionInfo0GameObject = changePlayerPositionInfo0GameObject;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06021742 RID: 137026 RVA: 0x00B4FC38 File Offset: 0x00B4DE38
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_changePlayerPositionInfo1GameObject(IntPtr l)
	{
		int result;
		try
		{
			TeamRoomInfoUIController teamRoomInfoUIController = (TeamRoomInfoUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, teamRoomInfoUIController.m_luaExportHelper.m_changePlayerPositionInfo1GameObject);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06021743 RID: 137027 RVA: 0x00B4FC90 File Offset: 0x00B4DE90
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_changePlayerPositionInfo1GameObject(IntPtr l)
	{
		int result;
		try
		{
			TeamRoomInfoUIController teamRoomInfoUIController = (TeamRoomInfoUIController)LuaObject.checkSelf(l);
			GameObject changePlayerPositionInfo1GameObject;
			LuaObject.checkType<GameObject>(l, 2, out changePlayerPositionInfo1GameObject);
			teamRoomInfoUIController.m_luaExportHelper.m_changePlayerPositionInfo1GameObject = changePlayerPositionInfo1GameObject;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06021744 RID: 137028 RVA: 0x00B4FCEC File Offset: 0x00B4DEEC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_changePlayerPositionInfo2GameObject(IntPtr l)
	{
		int result;
		try
		{
			TeamRoomInfoUIController teamRoomInfoUIController = (TeamRoomInfoUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, teamRoomInfoUIController.m_luaExportHelper.m_changePlayerPositionInfo2GameObject);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06021745 RID: 137029 RVA: 0x00B4FD44 File Offset: 0x00B4DF44
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_changePlayerPositionInfo2GameObject(IntPtr l)
	{
		int result;
		try
		{
			TeamRoomInfoUIController teamRoomInfoUIController = (TeamRoomInfoUIController)LuaObject.checkSelf(l);
			GameObject changePlayerPositionInfo2GameObject;
			LuaObject.checkType<GameObject>(l, 2, out changePlayerPositionInfo2GameObject);
			teamRoomInfoUIController.m_luaExportHelper.m_changePlayerPositionInfo2GameObject = changePlayerPositionInfo2GameObject;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06021746 RID: 137030 RVA: 0x00B4FDA0 File Offset: 0x00B4DFA0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_prefabsGameObject(IntPtr l)
	{
		int result;
		try
		{
			TeamRoomInfoUIController teamRoomInfoUIController = (TeamRoomInfoUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, teamRoomInfoUIController.m_luaExportHelper.m_prefabsGameObject);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06021747 RID: 137031 RVA: 0x00B4FDF8 File Offset: 0x00B4DFF8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_prefabsGameObject(IntPtr l)
	{
		int result;
		try
		{
			TeamRoomInfoUIController teamRoomInfoUIController = (TeamRoomInfoUIController)LuaObject.checkSelf(l);
			GameObject prefabsGameObject;
			LuaObject.checkType<GameObject>(l, 2, out prefabsGameObject);
			teamRoomInfoUIController.m_luaExportHelper.m_prefabsGameObject = prefabsGameObject;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06021748 RID: 137032 RVA: 0x00B4FE54 File Offset: 0x00B4E054
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_m_playerInfoPrefab(IntPtr l)
	{
		int result;
		try
		{
			TeamRoomInfoUIController teamRoomInfoUIController = (TeamRoomInfoUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, teamRoomInfoUIController.m_luaExportHelper.m_playerInfoPrefab);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06021749 RID: 137033 RVA: 0x00B4FEAC File Offset: 0x00B4E0AC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_playerInfoPrefab(IntPtr l)
	{
		int result;
		try
		{
			TeamRoomInfoUIController teamRoomInfoUIController = (TeamRoomInfoUIController)LuaObject.checkSelf(l);
			GameObject playerInfoPrefab;
			LuaObject.checkType<GameObject>(l, 2, out playerInfoPrefab);
			teamRoomInfoUIController.m_luaExportHelper.m_playerInfoPrefab = playerInfoPrefab;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0602174A RID: 137034 RVA: 0x00B4FF08 File Offset: 0x00B4E108
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_expressionParseDesc(IntPtr l)
	{
		int result;
		try
		{
			TeamRoomInfoUIController teamRoomInfoUIController = (TeamRoomInfoUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, teamRoomInfoUIController.m_luaExportHelper.m_expressionParseDesc);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0602174B RID: 137035 RVA: 0x00B4FF60 File Offset: 0x00B4E160
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_expressionParseDesc(IntPtr l)
	{
		int result;
		try
		{
			TeamRoomInfoUIController teamRoomInfoUIController = (TeamRoomInfoUIController)LuaObject.checkSelf(l);
			SmallExpressionParseDesc expressionParseDesc;
			LuaObject.checkType<SmallExpressionParseDesc>(l, 2, out expressionParseDesc);
			teamRoomInfoUIController.m_luaExportHelper.m_expressionParseDesc = expressionParseDesc;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0602174C RID: 137036 RVA: 0x00B4FFBC File Offset: 0x00B4E1BC
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_m_expressionResContainer(IntPtr l)
	{
		int result;
		try
		{
			TeamRoomInfoUIController teamRoomInfoUIController = (TeamRoomInfoUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, teamRoomInfoUIController.m_luaExportHelper.m_expressionResContainer);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0602174D RID: 137037 RVA: 0x00B50014 File Offset: 0x00B4E214
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_m_expressionResContainer(IntPtr l)
	{
		int result;
		try
		{
			TeamRoomInfoUIController teamRoomInfoUIController = (TeamRoomInfoUIController)LuaObject.checkSelf(l);
			PrefabResourceContainer expressionResContainer;
			LuaObject.checkType<PrefabResourceContainer>(l, 2, out expressionResContainer);
			teamRoomInfoUIController.m_luaExportHelper.m_expressionResContainer = expressionResContainer;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0602174E RID: 137038 RVA: 0x00B50070 File Offset: 0x00B4E270
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_m_playerInfoUIControllers(IntPtr l)
	{
		int result;
		try
		{
			TeamRoomInfoUIController teamRoomInfoUIController = (TeamRoomInfoUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, teamRoomInfoUIController.m_luaExportHelper.m_playerInfoUIControllers);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0602174F RID: 137039 RVA: 0x00B500C8 File Offset: 0x00B4E2C8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_playerInfoUIControllers(IntPtr l)
	{
		int result;
		try
		{
			TeamRoomInfoUIController teamRoomInfoUIController = (TeamRoomInfoUIController)LuaObject.checkSelf(l);
			TeamRoomPlayerInfoUIController[] playerInfoUIControllers;
			LuaObject.checkArray<TeamRoomPlayerInfoUIController>(l, 2, out playerInfoUIControllers);
			teamRoomInfoUIController.m_luaExportHelper.m_playerInfoUIControllers = playerInfoUIControllers;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06021750 RID: 137040 RVA: 0x00B50124 File Offset: 0x00B4E324
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_m_editPlayerInfoUIControllers(IntPtr l)
	{
		int result;
		try
		{
			TeamRoomInfoUIController teamRoomInfoUIController = (TeamRoomInfoUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, teamRoomInfoUIController.m_luaExportHelper.m_editPlayerInfoUIControllers);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06021751 RID: 137041 RVA: 0x00B5017C File Offset: 0x00B4E37C
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_m_editPlayerInfoUIControllers(IntPtr l)
	{
		int result;
		try
		{
			TeamRoomInfoUIController teamRoomInfoUIController = (TeamRoomInfoUIController)LuaObject.checkSelf(l);
			TeamRoomPlayerInfoUIController[] editPlayerInfoUIControllers;
			LuaObject.checkArray<TeamRoomPlayerInfoUIController>(l, 2, out editPlayerInfoUIControllers);
			teamRoomInfoUIController.m_luaExportHelper.m_editPlayerInfoUIControllers = editPlayerInfoUIControllers;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06021752 RID: 137042 RVA: 0x00B501D8 File Offset: 0x00B4E3D8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_draggingPlayerInfoUIController(IntPtr l)
	{
		int result;
		try
		{
			TeamRoomInfoUIController teamRoomInfoUIController = (TeamRoomInfoUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, teamRoomInfoUIController.m_luaExportHelper.m_draggingPlayerInfoUIController);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06021753 RID: 137043 RVA: 0x00B50230 File Offset: 0x00B4E430
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_draggingPlayerInfoUIController(IntPtr l)
	{
		int result;
		try
		{
			TeamRoomInfoUIController teamRoomInfoUIController = (TeamRoomInfoUIController)LuaObject.checkSelf(l);
			TeamRoomPlayerInfoUIController draggingPlayerInfoUIController;
			LuaObject.checkType<TeamRoomPlayerInfoUIController>(l, 2, out draggingPlayerInfoUIController);
			teamRoomInfoUIController.m_luaExportHelper.m_draggingPlayerInfoUIController = draggingPlayerInfoUIController;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06021754 RID: 137044 RVA: 0x00B5028C File Offset: 0x00B4E48C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_isIgnoreToggleEvent(IntPtr l)
	{
		int result;
		try
		{
			TeamRoomInfoUIController teamRoomInfoUIController = (TeamRoomInfoUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, teamRoomInfoUIController.m_luaExportHelper.m_isIgnoreToggleEvent);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06021755 RID: 137045 RVA: 0x00B502E4 File Offset: 0x00B4E4E4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_isIgnoreToggleEvent(IntPtr l)
	{
		int result;
		try
		{
			TeamRoomInfoUIController teamRoomInfoUIController = (TeamRoomInfoUIController)LuaObject.checkSelf(l);
			bool isIgnoreToggleEvent;
			LuaObject.checkType(l, 2, out isIgnoreToggleEvent);
			teamRoomInfoUIController.m_luaExportHelper.m_isIgnoreToggleEvent = isIgnoreToggleEvent;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06021756 RID: 137046 RVA: 0x00B50340 File Offset: 0x00B4E540
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_m_camera(IntPtr l)
	{
		int result;
		try
		{
			TeamRoomInfoUIController teamRoomInfoUIController = (TeamRoomInfoUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, teamRoomInfoUIController.m_luaExportHelper.m_camera);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06021757 RID: 137047 RVA: 0x00B50398 File Offset: 0x00B4E598
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_m_camera(IntPtr l)
	{
		int result;
		try
		{
			TeamRoomInfoUIController teamRoomInfoUIController = (TeamRoomInfoUIController)LuaObject.checkSelf(l);
			Camera camera;
			LuaObject.checkType<Camera>(l, 2, out camera);
			teamRoomInfoUIController.m_luaExportHelper.m_camera = camera;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06021758 RID: 137048 RVA: 0x00B503F4 File Offset: 0x00B4E5F4
	[Preserve]
	public static void reg(IntPtr l)
	{
		LuaObject.getTypeTable(l, "BlackJack.ProjectL.UI.TeamRoomInfoUIController");
		if (Lua_BlackJack_ProjectL_UI_TeamRoomInfoUIController.<>f__mg$cache0 == null)
		{
			Lua_BlackJack_ProjectL_UI_TeamRoomInfoUIController.<>f__mg$cache0 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_TeamRoomInfoUIController.Open);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_TeamRoomInfoUIController.<>f__mg$cache0);
		if (Lua_BlackJack_ProjectL_UI_TeamRoomInfoUIController.<>f__mg$cache1 == null)
		{
			Lua_BlackJack_ProjectL_UI_TeamRoomInfoUIController.<>f__mg$cache1 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_TeamRoomInfoUIController.Close);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_TeamRoomInfoUIController.<>f__mg$cache1);
		if (Lua_BlackJack_ProjectL_UI_TeamRoomInfoUIController.<>f__mg$cache2 == null)
		{
			Lua_BlackJack_ProjectL_UI_TeamRoomInfoUIController.<>f__mg$cache2 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_TeamRoomInfoUIController.SetTeamRoomSetting);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_TeamRoomInfoUIController.<>f__mg$cache2);
		if (Lua_BlackJack_ProjectL_UI_TeamRoomInfoUIController.<>f__mg$cache3 == null)
		{
			Lua_BlackJack_ProjectL_UI_TeamRoomInfoUIController.<>f__mg$cache3 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_TeamRoomInfoUIController.SetTeamRoomPlayers);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_TeamRoomInfoUIController.<>f__mg$cache3);
		if (Lua_BlackJack_ProjectL_UI_TeamRoomInfoUIController.<>f__mg$cache4 == null)
		{
			Lua_BlackJack_ProjectL_UI_TeamRoomInfoUIController.<>f__mg$cache4 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_TeamRoomInfoUIController.SetAuthority);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_TeamRoomInfoUIController.<>f__mg$cache4);
		if (Lua_BlackJack_ProjectL_UI_TeamRoomInfoUIController.<>f__mg$cache5 == null)
		{
			Lua_BlackJack_ProjectL_UI_TeamRoomInfoUIController.<>f__mg$cache5 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_TeamRoomInfoUIController.SetQuitCountdown);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_TeamRoomInfoUIController.<>f__mg$cache5);
		if (Lua_BlackJack_ProjectL_UI_TeamRoomInfoUIController.<>f__mg$cache6 == null)
		{
			Lua_BlackJack_ProjectL_UI_TeamRoomInfoUIController.<>f__mg$cache6 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_TeamRoomInfoUIController.ShowWaitStartBattle);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_TeamRoomInfoUIController.<>f__mg$cache6);
		if (Lua_BlackJack_ProjectL_UI_TeamRoomInfoUIController.<>f__mg$cache7 == null)
		{
			Lua_BlackJack_ProjectL_UI_TeamRoomInfoUIController.<>f__mg$cache7 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_TeamRoomInfoUIController.ShowChangePlayerPosition);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_TeamRoomInfoUIController.<>f__mg$cache7);
		if (Lua_BlackJack_ProjectL_UI_TeamRoomInfoUIController.<>f__mg$cache8 == null)
		{
			Lua_BlackJack_ProjectL_UI_TeamRoomInfoUIController.<>f__mg$cache8 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_TeamRoomInfoUIController.HideChangePlayerPosition);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_TeamRoomInfoUIController.<>f__mg$cache8);
		if (Lua_BlackJack_ProjectL_UI_TeamRoomInfoUIController.<>f__mg$cache9 == null)
		{
			Lua_BlackJack_ProjectL_UI_TeamRoomInfoUIController.<>f__mg$cache9 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_TeamRoomInfoUIController.GetPlayerChangedPosition);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_TeamRoomInfoUIController.<>f__mg$cache9);
		if (Lua_BlackJack_ProjectL_UI_TeamRoomInfoUIController.<>f__mg$cacheA == null)
		{
			Lua_BlackJack_ProjectL_UI_TeamRoomInfoUIController.<>f__mg$cacheA = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_TeamRoomInfoUIController.ShowPlayerChat);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_TeamRoomInfoUIController.<>f__mg$cacheA);
		if (Lua_BlackJack_ProjectL_UI_TeamRoomInfoUIController.<>f__mg$cacheB == null)
		{
			Lua_BlackJack_ProjectL_UI_TeamRoomInfoUIController.<>f__mg$cacheB = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_TeamRoomInfoUIController.ShowPlayerBigExpression);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_TeamRoomInfoUIController.<>f__mg$cacheB);
		if (Lua_BlackJack_ProjectL_UI_TeamRoomInfoUIController.<>f__mg$cacheC == null)
		{
			Lua_BlackJack_ProjectL_UI_TeamRoomInfoUIController.<>f__mg$cacheC = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_TeamRoomInfoUIController.TeamRoomPlayerInfoUIController_OnDrop);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_TeamRoomInfoUIController.<>f__mg$cacheC);
		if (Lua_BlackJack_ProjectL_UI_TeamRoomInfoUIController.<>f__mg$cacheD == null)
		{
			Lua_BlackJack_ProjectL_UI_TeamRoomInfoUIController.<>f__mg$cacheD = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_TeamRoomInfoUIController.OnBindFiledsCompleted);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_TeamRoomInfoUIController.<>f__mg$cacheD);
		if (Lua_BlackJack_ProjectL_UI_TeamRoomInfoUIController.<>f__mg$cacheE == null)
		{
			Lua_BlackJack_ProjectL_UI_TeamRoomInfoUIController.<>f__mg$cacheE = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_TeamRoomInfoUIController.GetPlayerInfoParent);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_TeamRoomInfoUIController.<>f__mg$cacheE);
		if (Lua_BlackJack_ProjectL_UI_TeamRoomInfoUIController.<>f__mg$cacheF == null)
		{
			Lua_BlackJack_ProjectL_UI_TeamRoomInfoUIController.<>f__mg$cacheF = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_TeamRoomInfoUIController.OnDisable);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_TeamRoomInfoUIController.<>f__mg$cacheF);
		if (Lua_BlackJack_ProjectL_UI_TeamRoomInfoUIController.<>f__mg$cache10 == null)
		{
			Lua_BlackJack_ProjectL_UI_TeamRoomInfoUIController.<>f__mg$cache10 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_TeamRoomInfoUIController.OnApplicationPause);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_TeamRoomInfoUIController.<>f__mg$cache10);
		if (Lua_BlackJack_ProjectL_UI_TeamRoomInfoUIController.<>f__mg$cache11 == null)
		{
			Lua_BlackJack_ProjectL_UI_TeamRoomInfoUIController.<>f__mg$cache11 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_TeamRoomInfoUIController.SetBattleName);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_TeamRoomInfoUIController.<>f__mg$cache11);
		if (Lua_BlackJack_ProjectL_UI_TeamRoomInfoUIController.<>f__mg$cache12 == null)
		{
			Lua_BlackJack_ProjectL_UI_TeamRoomInfoUIController.<>f__mg$cache12 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_TeamRoomInfoUIController.SetPlayerLevelRange);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_TeamRoomInfoUIController.<>f__mg$cache12);
		if (Lua_BlackJack_ProjectL_UI_TeamRoomInfoUIController.<>f__mg$cache13 == null)
		{
			Lua_BlackJack_ProjectL_UI_TeamRoomInfoUIController.<>f__mg$cache13 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_TeamRoomInfoUIController.CreateDraggingPlayerInfoUIController);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_TeamRoomInfoUIController.<>f__mg$cache13);
		if (Lua_BlackJack_ProjectL_UI_TeamRoomInfoUIController.<>f__mg$cache14 == null)
		{
			Lua_BlackJack_ProjectL_UI_TeamRoomInfoUIController.<>f__mg$cache14 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_TeamRoomInfoUIController.DestroyDragginPlayerInfoUIController);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_TeamRoomInfoUIController.<>f__mg$cache14);
		if (Lua_BlackJack_ProjectL_UI_TeamRoomInfoUIController.<>f__mg$cache15 == null)
		{
			Lua_BlackJack_ProjectL_UI_TeamRoomInfoUIController.<>f__mg$cache15 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_TeamRoomInfoUIController.MoveDraggingPlayerInfoUIController);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_TeamRoomInfoUIController.<>f__mg$cache15);
		if (Lua_BlackJack_ProjectL_UI_TeamRoomInfoUIController.<>f__mg$cache16 == null)
		{
			Lua_BlackJack_ProjectL_UI_TeamRoomInfoUIController.<>f__mg$cache16 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_TeamRoomInfoUIController.DropDraggingPlayerInfoUIController);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_TeamRoomInfoUIController.<>f__mg$cache16);
		if (Lua_BlackJack_ProjectL_UI_TeamRoomInfoUIController.<>f__mg$cache17 == null)
		{
			Lua_BlackJack_ProjectL_UI_TeamRoomInfoUIController.<>f__mg$cache17 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_TeamRoomInfoUIController.OnLeaveButtonClick);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_TeamRoomInfoUIController.<>f__mg$cache17);
		if (Lua_BlackJack_ProjectL_UI_TeamRoomInfoUIController.<>f__mg$cache18 == null)
		{
			Lua_BlackJack_ProjectL_UI_TeamRoomInfoUIController.<>f__mg$cache18 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_TeamRoomInfoUIController.OnStartButtonClick);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_TeamRoomInfoUIController.<>f__mg$cache18);
		if (Lua_BlackJack_ProjectL_UI_TeamRoomInfoUIController.<>f__mg$cache19 == null)
		{
			Lua_BlackJack_ProjectL_UI_TeamRoomInfoUIController.<>f__mg$cache19 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_TeamRoomInfoUIController.OnShowChangePlayerPositionButtonClick);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_TeamRoomInfoUIController.<>f__mg$cache19);
		if (Lua_BlackJack_ProjectL_UI_TeamRoomInfoUIController.<>f__mg$cache1A == null)
		{
			Lua_BlackJack_ProjectL_UI_TeamRoomInfoUIController.<>f__mg$cache1A = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_TeamRoomInfoUIController.OnChangePlayerPositionCompleteButtonClick);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_TeamRoomInfoUIController.<>f__mg$cache1A);
		if (Lua_BlackJack_ProjectL_UI_TeamRoomInfoUIController.<>f__mg$cache1B == null)
		{
			Lua_BlackJack_ProjectL_UI_TeamRoomInfoUIController.<>f__mg$cache1B = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_TeamRoomInfoUIController.OnChatButtonClick);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_TeamRoomInfoUIController.<>f__mg$cache1B);
		if (Lua_BlackJack_ProjectL_UI_TeamRoomInfoUIController.<>f__mg$cache1C == null)
		{
			Lua_BlackJack_ProjectL_UI_TeamRoomInfoUIController.<>f__mg$cache1C = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_TeamRoomInfoUIController.OnAuthorityDropdownValueChanged);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_TeamRoomInfoUIController.<>f__mg$cache1C);
		if (Lua_BlackJack_ProjectL_UI_TeamRoomInfoUIController.<>f__mg$cache1D == null)
		{
			Lua_BlackJack_ProjectL_UI_TeamRoomInfoUIController.<>f__mg$cache1D = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_TeamRoomInfoUIController.OnAuthorityLockButtonClick);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_TeamRoomInfoUIController.<>f__mg$cache1D);
		if (Lua_BlackJack_ProjectL_UI_TeamRoomInfoUIController.<>f__mg$cache1E == null)
		{
			Lua_BlackJack_ProjectL_UI_TeamRoomInfoUIController.<>f__mg$cache1E = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_TeamRoomInfoUIController.TeamRoomPlayerInfoUIController_OnInviteButtonClick);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_TeamRoomInfoUIController.<>f__mg$cache1E);
		if (Lua_BlackJack_ProjectL_UI_TeamRoomInfoUIController.<>f__mg$cache1F == null)
		{
			Lua_BlackJack_ProjectL_UI_TeamRoomInfoUIController.<>f__mg$cache1F = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_TeamRoomInfoUIController.TeamRoomPlayerInfoUIController_OnPlayerButtonClick);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_TeamRoomInfoUIController.<>f__mg$cache1F);
		if (Lua_BlackJack_ProjectL_UI_TeamRoomInfoUIController.<>f__mg$cache20 == null)
		{
			Lua_BlackJack_ProjectL_UI_TeamRoomInfoUIController.<>f__mg$cache20 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_TeamRoomInfoUIController.TeamRoomPlayerInfoUIController_OnBeginDrag);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_TeamRoomInfoUIController.<>f__mg$cache20);
		if (Lua_BlackJack_ProjectL_UI_TeamRoomInfoUIController.<>f__mg$cache21 == null)
		{
			Lua_BlackJack_ProjectL_UI_TeamRoomInfoUIController.<>f__mg$cache21 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_TeamRoomInfoUIController.TeamRoomPlayerInfoUIController_OnEndDrag);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_TeamRoomInfoUIController.<>f__mg$cache21);
		if (Lua_BlackJack_ProjectL_UI_TeamRoomInfoUIController.<>f__mg$cache22 == null)
		{
			Lua_BlackJack_ProjectL_UI_TeamRoomInfoUIController.<>f__mg$cache22 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_TeamRoomInfoUIController.TeamRoomPlayerInfoUIController_OnDrag);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_TeamRoomInfoUIController.<>f__mg$cache22);
		if (Lua_BlackJack_ProjectL_UI_TeamRoomInfoUIController.<>f__mg$cache23 == null)
		{
			Lua_BlackJack_ProjectL_UI_TeamRoomInfoUIController.<>f__mg$cache23 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_TeamRoomInfoUIController.__callBase_Initlize);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_TeamRoomInfoUIController.<>f__mg$cache23);
		if (Lua_BlackJack_ProjectL_UI_TeamRoomInfoUIController.<>f__mg$cache24 == null)
		{
			Lua_BlackJack_ProjectL_UI_TeamRoomInfoUIController.<>f__mg$cache24 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_TeamRoomInfoUIController.__callBase_BindFields);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_TeamRoomInfoUIController.<>f__mg$cache24);
		if (Lua_BlackJack_ProjectL_UI_TeamRoomInfoUIController.<>f__mg$cache25 == null)
		{
			Lua_BlackJack_ProjectL_UI_TeamRoomInfoUIController.<>f__mg$cache25 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_TeamRoomInfoUIController.__callBase_OnBindFiledsCompleted);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_TeamRoomInfoUIController.<>f__mg$cache25);
		if (Lua_BlackJack_ProjectL_UI_TeamRoomInfoUIController.<>f__mg$cache26 == null)
		{
			Lua_BlackJack_ProjectL_UI_TeamRoomInfoUIController.<>f__mg$cache26 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_TeamRoomInfoUIController.__callBase_BindFieldImpl);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_TeamRoomInfoUIController.<>f__mg$cache26);
		if (Lua_BlackJack_ProjectL_UI_TeamRoomInfoUIController.<>f__mg$cache27 == null)
		{
			Lua_BlackJack_ProjectL_UI_TeamRoomInfoUIController.<>f__mg$cache27 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_TeamRoomInfoUIController.__callBase_Clear);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_TeamRoomInfoUIController.<>f__mg$cache27);
		if (Lua_BlackJack_ProjectL_UI_TeamRoomInfoUIController.<>f__mg$cache28 == null)
		{
			Lua_BlackJack_ProjectL_UI_TeamRoomInfoUIController.<>f__mg$cache28 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_TeamRoomInfoUIController.__callBase_OnButtonClick);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_TeamRoomInfoUIController.<>f__mg$cache28);
		if (Lua_BlackJack_ProjectL_UI_TeamRoomInfoUIController.<>f__mg$cache29 == null)
		{
			Lua_BlackJack_ProjectL_UI_TeamRoomInfoUIController.<>f__mg$cache29 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_TeamRoomInfoUIController.__callBase_SetButtonClickListener);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_TeamRoomInfoUIController.<>f__mg$cache29);
		if (Lua_BlackJack_ProjectL_UI_TeamRoomInfoUIController.<>f__mg$cache2A == null)
		{
			Lua_BlackJack_ProjectL_UI_TeamRoomInfoUIController.<>f__mg$cache2A = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_TeamRoomInfoUIController.__callBase_SetButtonDoubleClickListener);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_TeamRoomInfoUIController.<>f__mg$cache2A);
		if (Lua_BlackJack_ProjectL_UI_TeamRoomInfoUIController.<>f__mg$cache2B == null)
		{
			Lua_BlackJack_ProjectL_UI_TeamRoomInfoUIController.<>f__mg$cache2B = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_TeamRoomInfoUIController.__callBase_SetButtonLongPressStartListener);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_TeamRoomInfoUIController.<>f__mg$cache2B);
		if (Lua_BlackJack_ProjectL_UI_TeamRoomInfoUIController.<>f__mg$cache2C == null)
		{
			Lua_BlackJack_ProjectL_UI_TeamRoomInfoUIController.<>f__mg$cache2C = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_TeamRoomInfoUIController.__callBase_SetButtonLongPressingListener);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_TeamRoomInfoUIController.<>f__mg$cache2C);
		if (Lua_BlackJack_ProjectL_UI_TeamRoomInfoUIController.<>f__mg$cache2D == null)
		{
			Lua_BlackJack_ProjectL_UI_TeamRoomInfoUIController.<>f__mg$cache2D = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_TeamRoomInfoUIController.__callBase_SetButtonLongPressEndListener);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_TeamRoomInfoUIController.<>f__mg$cache2D);
		if (Lua_BlackJack_ProjectL_UI_TeamRoomInfoUIController.<>f__mg$cache2E == null)
		{
			Lua_BlackJack_ProjectL_UI_TeamRoomInfoUIController.<>f__mg$cache2E = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_TeamRoomInfoUIController.__callBase_SetToggleValueChangedListener);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_TeamRoomInfoUIController.<>f__mg$cache2E);
		if (Lua_BlackJack_ProjectL_UI_TeamRoomInfoUIController.<>f__mg$cache2F == null)
		{
			Lua_BlackJack_ProjectL_UI_TeamRoomInfoUIController.<>f__mg$cache2F = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_TeamRoomInfoUIController.__callBase_ToString);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_TeamRoomInfoUIController.<>f__mg$cache2F);
		if (Lua_BlackJack_ProjectL_UI_TeamRoomInfoUIController.<>f__mg$cache30 == null)
		{
			Lua_BlackJack_ProjectL_UI_TeamRoomInfoUIController.<>f__mg$cache30 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_TeamRoomInfoUIController.__callDele_EventOnLeave);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_TeamRoomInfoUIController.<>f__mg$cache30);
		if (Lua_BlackJack_ProjectL_UI_TeamRoomInfoUIController.<>f__mg$cache31 == null)
		{
			Lua_BlackJack_ProjectL_UI_TeamRoomInfoUIController.<>f__mg$cache31 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_TeamRoomInfoUIController.__clearDele_EventOnLeave);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_TeamRoomInfoUIController.<>f__mg$cache31);
		if (Lua_BlackJack_ProjectL_UI_TeamRoomInfoUIController.<>f__mg$cache32 == null)
		{
			Lua_BlackJack_ProjectL_UI_TeamRoomInfoUIController.<>f__mg$cache32 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_TeamRoomInfoUIController.__callDele_EventOnStart);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_TeamRoomInfoUIController.<>f__mg$cache32);
		if (Lua_BlackJack_ProjectL_UI_TeamRoomInfoUIController.<>f__mg$cache33 == null)
		{
			Lua_BlackJack_ProjectL_UI_TeamRoomInfoUIController.<>f__mg$cache33 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_TeamRoomInfoUIController.__clearDele_EventOnStart);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_TeamRoomInfoUIController.<>f__mg$cache33);
		if (Lua_BlackJack_ProjectL_UI_TeamRoomInfoUIController.<>f__mg$cache34 == null)
		{
			Lua_BlackJack_ProjectL_UI_TeamRoomInfoUIController.<>f__mg$cache34 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_TeamRoomInfoUIController.__callDele_EventOnShowChangePlayerPosition);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_TeamRoomInfoUIController.<>f__mg$cache34);
		if (Lua_BlackJack_ProjectL_UI_TeamRoomInfoUIController.<>f__mg$cache35 == null)
		{
			Lua_BlackJack_ProjectL_UI_TeamRoomInfoUIController.<>f__mg$cache35 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_TeamRoomInfoUIController.__clearDele_EventOnShowChangePlayerPosition);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_TeamRoomInfoUIController.<>f__mg$cache35);
		if (Lua_BlackJack_ProjectL_UI_TeamRoomInfoUIController.<>f__mg$cache36 == null)
		{
			Lua_BlackJack_ProjectL_UI_TeamRoomInfoUIController.<>f__mg$cache36 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_TeamRoomInfoUIController.__callDele_EventOnChangePlayerPositionComplete);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_TeamRoomInfoUIController.<>f__mg$cache36);
		if (Lua_BlackJack_ProjectL_UI_TeamRoomInfoUIController.<>f__mg$cache37 == null)
		{
			Lua_BlackJack_ProjectL_UI_TeamRoomInfoUIController.<>f__mg$cache37 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_TeamRoomInfoUIController.__clearDele_EventOnChangePlayerPositionComplete);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_TeamRoomInfoUIController.<>f__mg$cache37);
		if (Lua_BlackJack_ProjectL_UI_TeamRoomInfoUIController.<>f__mg$cache38 == null)
		{
			Lua_BlackJack_ProjectL_UI_TeamRoomInfoUIController.<>f__mg$cache38 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_TeamRoomInfoUIController.__callDele_EventOnShowChat);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_TeamRoomInfoUIController.<>f__mg$cache38);
		if (Lua_BlackJack_ProjectL_UI_TeamRoomInfoUIController.<>f__mg$cache39 == null)
		{
			Lua_BlackJack_ProjectL_UI_TeamRoomInfoUIController.<>f__mg$cache39 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_TeamRoomInfoUIController.__clearDele_EventOnShowChat);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_TeamRoomInfoUIController.<>f__mg$cache39);
		if (Lua_BlackJack_ProjectL_UI_TeamRoomInfoUIController.<>f__mg$cache3A == null)
		{
			Lua_BlackJack_ProjectL_UI_TeamRoomInfoUIController.<>f__mg$cache3A = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_TeamRoomInfoUIController.__callDele_EventOnChangeAuthority);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_TeamRoomInfoUIController.<>f__mg$cache3A);
		if (Lua_BlackJack_ProjectL_UI_TeamRoomInfoUIController.<>f__mg$cache3B == null)
		{
			Lua_BlackJack_ProjectL_UI_TeamRoomInfoUIController.<>f__mg$cache3B = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_TeamRoomInfoUIController.__clearDele_EventOnChangeAuthority);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_TeamRoomInfoUIController.<>f__mg$cache3B);
		if (Lua_BlackJack_ProjectL_UI_TeamRoomInfoUIController.<>f__mg$cache3C == null)
		{
			Lua_BlackJack_ProjectL_UI_TeamRoomInfoUIController.<>f__mg$cache3C = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_TeamRoomInfoUIController.__callDele_EventOnShowInvite);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_TeamRoomInfoUIController.<>f__mg$cache3C);
		if (Lua_BlackJack_ProjectL_UI_TeamRoomInfoUIController.<>f__mg$cache3D == null)
		{
			Lua_BlackJack_ProjectL_UI_TeamRoomInfoUIController.<>f__mg$cache3D = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_TeamRoomInfoUIController.__clearDele_EventOnShowInvite);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_TeamRoomInfoUIController.<>f__mg$cache3D);
		if (Lua_BlackJack_ProjectL_UI_TeamRoomInfoUIController.<>f__mg$cache3E == null)
		{
			Lua_BlackJack_ProjectL_UI_TeamRoomInfoUIController.<>f__mg$cache3E = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_TeamRoomInfoUIController.__callDele_EventOnShowPlayerInfo);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_TeamRoomInfoUIController.<>f__mg$cache3E);
		if (Lua_BlackJack_ProjectL_UI_TeamRoomInfoUIController.<>f__mg$cache3F == null)
		{
			Lua_BlackJack_ProjectL_UI_TeamRoomInfoUIController.<>f__mg$cache3F = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_TeamRoomInfoUIController.__clearDele_EventOnShowPlayerInfo);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_TeamRoomInfoUIController.<>f__mg$cache3F);
		string name = "EventOnLeave";
		LuaCSFunction get = null;
		if (Lua_BlackJack_ProjectL_UI_TeamRoomInfoUIController.<>f__mg$cache40 == null)
		{
			Lua_BlackJack_ProjectL_UI_TeamRoomInfoUIController.<>f__mg$cache40 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_TeamRoomInfoUIController.set_EventOnLeave);
		}
		LuaObject.addMember(l, name, get, Lua_BlackJack_ProjectL_UI_TeamRoomInfoUIController.<>f__mg$cache40, true);
		string name2 = "EventOnStart";
		LuaCSFunction get2 = null;
		if (Lua_BlackJack_ProjectL_UI_TeamRoomInfoUIController.<>f__mg$cache41 == null)
		{
			Lua_BlackJack_ProjectL_UI_TeamRoomInfoUIController.<>f__mg$cache41 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_TeamRoomInfoUIController.set_EventOnStart);
		}
		LuaObject.addMember(l, name2, get2, Lua_BlackJack_ProjectL_UI_TeamRoomInfoUIController.<>f__mg$cache41, true);
		string name3 = "EventOnShowChangePlayerPosition";
		LuaCSFunction get3 = null;
		if (Lua_BlackJack_ProjectL_UI_TeamRoomInfoUIController.<>f__mg$cache42 == null)
		{
			Lua_BlackJack_ProjectL_UI_TeamRoomInfoUIController.<>f__mg$cache42 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_TeamRoomInfoUIController.set_EventOnShowChangePlayerPosition);
		}
		LuaObject.addMember(l, name3, get3, Lua_BlackJack_ProjectL_UI_TeamRoomInfoUIController.<>f__mg$cache42, true);
		string name4 = "EventOnChangePlayerPositionComplete";
		LuaCSFunction get4 = null;
		if (Lua_BlackJack_ProjectL_UI_TeamRoomInfoUIController.<>f__mg$cache43 == null)
		{
			Lua_BlackJack_ProjectL_UI_TeamRoomInfoUIController.<>f__mg$cache43 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_TeamRoomInfoUIController.set_EventOnChangePlayerPositionComplete);
		}
		LuaObject.addMember(l, name4, get4, Lua_BlackJack_ProjectL_UI_TeamRoomInfoUIController.<>f__mg$cache43, true);
		string name5 = "EventOnShowChat";
		LuaCSFunction get5 = null;
		if (Lua_BlackJack_ProjectL_UI_TeamRoomInfoUIController.<>f__mg$cache44 == null)
		{
			Lua_BlackJack_ProjectL_UI_TeamRoomInfoUIController.<>f__mg$cache44 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_TeamRoomInfoUIController.set_EventOnShowChat);
		}
		LuaObject.addMember(l, name5, get5, Lua_BlackJack_ProjectL_UI_TeamRoomInfoUIController.<>f__mg$cache44, true);
		string name6 = "EventOnChangeAuthority";
		LuaCSFunction get6 = null;
		if (Lua_BlackJack_ProjectL_UI_TeamRoomInfoUIController.<>f__mg$cache45 == null)
		{
			Lua_BlackJack_ProjectL_UI_TeamRoomInfoUIController.<>f__mg$cache45 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_TeamRoomInfoUIController.set_EventOnChangeAuthority);
		}
		LuaObject.addMember(l, name6, get6, Lua_BlackJack_ProjectL_UI_TeamRoomInfoUIController.<>f__mg$cache45, true);
		string name7 = "EventOnShowInvite";
		LuaCSFunction get7 = null;
		if (Lua_BlackJack_ProjectL_UI_TeamRoomInfoUIController.<>f__mg$cache46 == null)
		{
			Lua_BlackJack_ProjectL_UI_TeamRoomInfoUIController.<>f__mg$cache46 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_TeamRoomInfoUIController.set_EventOnShowInvite);
		}
		LuaObject.addMember(l, name7, get7, Lua_BlackJack_ProjectL_UI_TeamRoomInfoUIController.<>f__mg$cache46, true);
		string name8 = "EventOnShowPlayerInfo";
		LuaCSFunction get8 = null;
		if (Lua_BlackJack_ProjectL_UI_TeamRoomInfoUIController.<>f__mg$cache47 == null)
		{
			Lua_BlackJack_ProjectL_UI_TeamRoomInfoUIController.<>f__mg$cache47 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_TeamRoomInfoUIController.set_EventOnShowPlayerInfo);
		}
		LuaObject.addMember(l, name8, get8, Lua_BlackJack_ProjectL_UI_TeamRoomInfoUIController.<>f__mg$cache47, true);
		string name9 = "m_uiStateController";
		if (Lua_BlackJack_ProjectL_UI_TeamRoomInfoUIController.<>f__mg$cache48 == null)
		{
			Lua_BlackJack_ProjectL_UI_TeamRoomInfoUIController.<>f__mg$cache48 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_TeamRoomInfoUIController.get_m_uiStateController);
		}
		LuaCSFunction get9 = Lua_BlackJack_ProjectL_UI_TeamRoomInfoUIController.<>f__mg$cache48;
		if (Lua_BlackJack_ProjectL_UI_TeamRoomInfoUIController.<>f__mg$cache49 == null)
		{
			Lua_BlackJack_ProjectL_UI_TeamRoomInfoUIController.<>f__mg$cache49 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_TeamRoomInfoUIController.set_m_uiStateController);
		}
		LuaObject.addMember(l, name9, get9, Lua_BlackJack_ProjectL_UI_TeamRoomInfoUIController.<>f__mg$cache49, true);
		string name10 = "m_guildOrTeamUIStateController";
		if (Lua_BlackJack_ProjectL_UI_TeamRoomInfoUIController.<>f__mg$cache4A == null)
		{
			Lua_BlackJack_ProjectL_UI_TeamRoomInfoUIController.<>f__mg$cache4A = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_TeamRoomInfoUIController.get_m_guildOrTeamUIStateController);
		}
		LuaCSFunction get10 = Lua_BlackJack_ProjectL_UI_TeamRoomInfoUIController.<>f__mg$cache4A;
		if (Lua_BlackJack_ProjectL_UI_TeamRoomInfoUIController.<>f__mg$cache4B == null)
		{
			Lua_BlackJack_ProjectL_UI_TeamRoomInfoUIController.<>f__mg$cache4B = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_TeamRoomInfoUIController.set_m_guildOrTeamUIStateController);
		}
		LuaObject.addMember(l, name10, get10, Lua_BlackJack_ProjectL_UI_TeamRoomInfoUIController.<>f__mg$cache4B, true);
		string name11 = "m_waitStartBattleGameObject";
		if (Lua_BlackJack_ProjectL_UI_TeamRoomInfoUIController.<>f__mg$cache4C == null)
		{
			Lua_BlackJack_ProjectL_UI_TeamRoomInfoUIController.<>f__mg$cache4C = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_TeamRoomInfoUIController.get_m_waitStartBattleGameObject);
		}
		LuaCSFunction get11 = Lua_BlackJack_ProjectL_UI_TeamRoomInfoUIController.<>f__mg$cache4C;
		if (Lua_BlackJack_ProjectL_UI_TeamRoomInfoUIController.<>f__mg$cache4D == null)
		{
			Lua_BlackJack_ProjectL_UI_TeamRoomInfoUIController.<>f__mg$cache4D = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_TeamRoomInfoUIController.set_m_waitStartBattleGameObject);
		}
		LuaObject.addMember(l, name11, get11, Lua_BlackJack_ProjectL_UI_TeamRoomInfoUIController.<>f__mg$cache4D, true);
		string name12 = "m_startButton";
		if (Lua_BlackJack_ProjectL_UI_TeamRoomInfoUIController.<>f__mg$cache4E == null)
		{
			Lua_BlackJack_ProjectL_UI_TeamRoomInfoUIController.<>f__mg$cache4E = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_TeamRoomInfoUIController.get_m_startButton);
		}
		LuaCSFunction get12 = Lua_BlackJack_ProjectL_UI_TeamRoomInfoUIController.<>f__mg$cache4E;
		if (Lua_BlackJack_ProjectL_UI_TeamRoomInfoUIController.<>f__mg$cache4F == null)
		{
			Lua_BlackJack_ProjectL_UI_TeamRoomInfoUIController.<>f__mg$cache4F = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_TeamRoomInfoUIController.set_m_startButton);
		}
		LuaObject.addMember(l, name12, get12, Lua_BlackJack_ProjectL_UI_TeamRoomInfoUIController.<>f__mg$cache4F, true);
		string name13 = "m_startButtonUIStateController";
		if (Lua_BlackJack_ProjectL_UI_TeamRoomInfoUIController.<>f__mg$cache50 == null)
		{
			Lua_BlackJack_ProjectL_UI_TeamRoomInfoUIController.<>f__mg$cache50 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_TeamRoomInfoUIController.get_m_startButtonUIStateController);
		}
		LuaCSFunction get13 = Lua_BlackJack_ProjectL_UI_TeamRoomInfoUIController.<>f__mg$cache50;
		if (Lua_BlackJack_ProjectL_UI_TeamRoomInfoUIController.<>f__mg$cache51 == null)
		{
			Lua_BlackJack_ProjectL_UI_TeamRoomInfoUIController.<>f__mg$cache51 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_TeamRoomInfoUIController.set_m_startButtonUIStateController);
		}
		LuaObject.addMember(l, name13, get13, Lua_BlackJack_ProjectL_UI_TeamRoomInfoUIController.<>f__mg$cache51, true);
		string name14 = "m_leaveButton";
		if (Lua_BlackJack_ProjectL_UI_TeamRoomInfoUIController.<>f__mg$cache52 == null)
		{
			Lua_BlackJack_ProjectL_UI_TeamRoomInfoUIController.<>f__mg$cache52 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_TeamRoomInfoUIController.get_m_leaveButton);
		}
		LuaCSFunction get14 = Lua_BlackJack_ProjectL_UI_TeamRoomInfoUIController.<>f__mg$cache52;
		if (Lua_BlackJack_ProjectL_UI_TeamRoomInfoUIController.<>f__mg$cache53 == null)
		{
			Lua_BlackJack_ProjectL_UI_TeamRoomInfoUIController.<>f__mg$cache53 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_TeamRoomInfoUIController.set_m_leaveButton);
		}
		LuaObject.addMember(l, name14, get14, Lua_BlackJack_ProjectL_UI_TeamRoomInfoUIController.<>f__mg$cache53, true);
		string name15 = "m_showChangePlayerPositionButton";
		if (Lua_BlackJack_ProjectL_UI_TeamRoomInfoUIController.<>f__mg$cache54 == null)
		{
			Lua_BlackJack_ProjectL_UI_TeamRoomInfoUIController.<>f__mg$cache54 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_TeamRoomInfoUIController.get_m_showChangePlayerPositionButton);
		}
		LuaCSFunction get15 = Lua_BlackJack_ProjectL_UI_TeamRoomInfoUIController.<>f__mg$cache54;
		if (Lua_BlackJack_ProjectL_UI_TeamRoomInfoUIController.<>f__mg$cache55 == null)
		{
			Lua_BlackJack_ProjectL_UI_TeamRoomInfoUIController.<>f__mg$cache55 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_TeamRoomInfoUIController.set_m_showChangePlayerPositionButton);
		}
		LuaObject.addMember(l, name15, get15, Lua_BlackJack_ProjectL_UI_TeamRoomInfoUIController.<>f__mg$cache55, true);
		string name16 = "m_chatButton";
		if (Lua_BlackJack_ProjectL_UI_TeamRoomInfoUIController.<>f__mg$cache56 == null)
		{
			Lua_BlackJack_ProjectL_UI_TeamRoomInfoUIController.<>f__mg$cache56 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_TeamRoomInfoUIController.get_m_chatButton);
		}
		LuaCSFunction get16 = Lua_BlackJack_ProjectL_UI_TeamRoomInfoUIController.<>f__mg$cache56;
		if (Lua_BlackJack_ProjectL_UI_TeamRoomInfoUIController.<>f__mg$cache57 == null)
		{
			Lua_BlackJack_ProjectL_UI_TeamRoomInfoUIController.<>f__mg$cache57 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_TeamRoomInfoUIController.set_m_chatButton);
		}
		LuaObject.addMember(l, name16, get16, Lua_BlackJack_ProjectL_UI_TeamRoomInfoUIController.<>f__mg$cache57, true);
		string name17 = "m_gameFunctionTypeNameText";
		if (Lua_BlackJack_ProjectL_UI_TeamRoomInfoUIController.<>f__mg$cache58 == null)
		{
			Lua_BlackJack_ProjectL_UI_TeamRoomInfoUIController.<>f__mg$cache58 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_TeamRoomInfoUIController.get_m_gameFunctionTypeNameText);
		}
		LuaCSFunction get17 = Lua_BlackJack_ProjectL_UI_TeamRoomInfoUIController.<>f__mg$cache58;
		if (Lua_BlackJack_ProjectL_UI_TeamRoomInfoUIController.<>f__mg$cache59 == null)
		{
			Lua_BlackJack_ProjectL_UI_TeamRoomInfoUIController.<>f__mg$cache59 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_TeamRoomInfoUIController.set_m_gameFunctionTypeNameText);
		}
		LuaObject.addMember(l, name17, get17, Lua_BlackJack_ProjectL_UI_TeamRoomInfoUIController.<>f__mg$cache59, true);
		string name18 = "m_locationNameText";
		if (Lua_BlackJack_ProjectL_UI_TeamRoomInfoUIController.<>f__mg$cache5A == null)
		{
			Lua_BlackJack_ProjectL_UI_TeamRoomInfoUIController.<>f__mg$cache5A = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_TeamRoomInfoUIController.get_m_locationNameText);
		}
		LuaCSFunction get18 = Lua_BlackJack_ProjectL_UI_TeamRoomInfoUIController.<>f__mg$cache5A;
		if (Lua_BlackJack_ProjectL_UI_TeamRoomInfoUIController.<>f__mg$cache5B == null)
		{
			Lua_BlackJack_ProjectL_UI_TeamRoomInfoUIController.<>f__mg$cache5B = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_TeamRoomInfoUIController.set_m_locationNameText);
		}
		LuaObject.addMember(l, name18, get18, Lua_BlackJack_ProjectL_UI_TeamRoomInfoUIController.<>f__mg$cache5B, true);
		string name19 = "m_playerLevelText";
		if (Lua_BlackJack_ProjectL_UI_TeamRoomInfoUIController.<>f__mg$cache5C == null)
		{
			Lua_BlackJack_ProjectL_UI_TeamRoomInfoUIController.<>f__mg$cache5C = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_TeamRoomInfoUIController.get_m_playerLevelText);
		}
		LuaCSFunction get19 = Lua_BlackJack_ProjectL_UI_TeamRoomInfoUIController.<>f__mg$cache5C;
		if (Lua_BlackJack_ProjectL_UI_TeamRoomInfoUIController.<>f__mg$cache5D == null)
		{
			Lua_BlackJack_ProjectL_UI_TeamRoomInfoUIController.<>f__mg$cache5D = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_TeamRoomInfoUIController.set_m_playerLevelText);
		}
		LuaObject.addMember(l, name19, get19, Lua_BlackJack_ProjectL_UI_TeamRoomInfoUIController.<>f__mg$cache5D, true);
		string name20 = "m_quitCountdownText";
		if (Lua_BlackJack_ProjectL_UI_TeamRoomInfoUIController.<>f__mg$cache5E == null)
		{
			Lua_BlackJack_ProjectL_UI_TeamRoomInfoUIController.<>f__mg$cache5E = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_TeamRoomInfoUIController.get_m_quitCountdownText);
		}
		LuaCSFunction get20 = Lua_BlackJack_ProjectL_UI_TeamRoomInfoUIController.<>f__mg$cache5E;
		if (Lua_BlackJack_ProjectL_UI_TeamRoomInfoUIController.<>f__mg$cache5F == null)
		{
			Lua_BlackJack_ProjectL_UI_TeamRoomInfoUIController.<>f__mg$cache5F = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_TeamRoomInfoUIController.set_m_quitCountdownText);
		}
		LuaObject.addMember(l, name20, get20, Lua_BlackJack_ProjectL_UI_TeamRoomInfoUIController.<>f__mg$cache5F, true);
		string name21 = "m_energyText";
		if (Lua_BlackJack_ProjectL_UI_TeamRoomInfoUIController.<>f__mg$cache60 == null)
		{
			Lua_BlackJack_ProjectL_UI_TeamRoomInfoUIController.<>f__mg$cache60 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_TeamRoomInfoUIController.get_m_energyText);
		}
		LuaCSFunction get21 = Lua_BlackJack_ProjectL_UI_TeamRoomInfoUIController.<>f__mg$cache60;
		if (Lua_BlackJack_ProjectL_UI_TeamRoomInfoUIController.<>f__mg$cache61 == null)
		{
			Lua_BlackJack_ProjectL_UI_TeamRoomInfoUIController.<>f__mg$cache61 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_TeamRoomInfoUIController.set_m_energyText);
		}
		LuaObject.addMember(l, name21, get21, Lua_BlackJack_ProjectL_UI_TeamRoomInfoUIController.<>f__mg$cache61, true);
		string name22 = "m_guildMassiveCombatNameText";
		if (Lua_BlackJack_ProjectL_UI_TeamRoomInfoUIController.<>f__mg$cache62 == null)
		{
			Lua_BlackJack_ProjectL_UI_TeamRoomInfoUIController.<>f__mg$cache62 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_TeamRoomInfoUIController.get_m_guildMassiveCombatNameText);
		}
		LuaCSFunction get22 = Lua_BlackJack_ProjectL_UI_TeamRoomInfoUIController.<>f__mg$cache62;
		if (Lua_BlackJack_ProjectL_UI_TeamRoomInfoUIController.<>f__mg$cache63 == null)
		{
			Lua_BlackJack_ProjectL_UI_TeamRoomInfoUIController.<>f__mg$cache63 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_TeamRoomInfoUIController.set_m_guildMassiveCombatNameText);
		}
		LuaObject.addMember(l, name22, get22, Lua_BlackJack_ProjectL_UI_TeamRoomInfoUIController.<>f__mg$cache63, true);
		string name23 = "m_authorityDropdown";
		if (Lua_BlackJack_ProjectL_UI_TeamRoomInfoUIController.<>f__mg$cache64 == null)
		{
			Lua_BlackJack_ProjectL_UI_TeamRoomInfoUIController.<>f__mg$cache64 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_TeamRoomInfoUIController.get_m_authorityDropdown);
		}
		LuaCSFunction get23 = Lua_BlackJack_ProjectL_UI_TeamRoomInfoUIController.<>f__mg$cache64;
		if (Lua_BlackJack_ProjectL_UI_TeamRoomInfoUIController.<>f__mg$cache65 == null)
		{
			Lua_BlackJack_ProjectL_UI_TeamRoomInfoUIController.<>f__mg$cache65 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_TeamRoomInfoUIController.set_m_authorityDropdown);
		}
		LuaObject.addMember(l, name23, get23, Lua_BlackJack_ProjectL_UI_TeamRoomInfoUIController.<>f__mg$cache65, true);
		string name24 = "m_authorityLockButton";
		if (Lua_BlackJack_ProjectL_UI_TeamRoomInfoUIController.<>f__mg$cache66 == null)
		{
			Lua_BlackJack_ProjectL_UI_TeamRoomInfoUIController.<>f__mg$cache66 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_TeamRoomInfoUIController.get_m_authorityLockButton);
		}
		LuaCSFunction get24 = Lua_BlackJack_ProjectL_UI_TeamRoomInfoUIController.<>f__mg$cache66;
		if (Lua_BlackJack_ProjectL_UI_TeamRoomInfoUIController.<>f__mg$cache67 == null)
		{
			Lua_BlackJack_ProjectL_UI_TeamRoomInfoUIController.<>f__mg$cache67 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_TeamRoomInfoUIController.set_m_authorityLockButton);
		}
		LuaObject.addMember(l, name24, get24, Lua_BlackJack_ProjectL_UI_TeamRoomInfoUIController.<>f__mg$cache67, true);
		string name25 = "m_playerInfo0GameObject";
		if (Lua_BlackJack_ProjectL_UI_TeamRoomInfoUIController.<>f__mg$cache68 == null)
		{
			Lua_BlackJack_ProjectL_UI_TeamRoomInfoUIController.<>f__mg$cache68 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_TeamRoomInfoUIController.get_m_playerInfo0GameObject);
		}
		LuaCSFunction get25 = Lua_BlackJack_ProjectL_UI_TeamRoomInfoUIController.<>f__mg$cache68;
		if (Lua_BlackJack_ProjectL_UI_TeamRoomInfoUIController.<>f__mg$cache69 == null)
		{
			Lua_BlackJack_ProjectL_UI_TeamRoomInfoUIController.<>f__mg$cache69 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_TeamRoomInfoUIController.set_m_playerInfo0GameObject);
		}
		LuaObject.addMember(l, name25, get25, Lua_BlackJack_ProjectL_UI_TeamRoomInfoUIController.<>f__mg$cache69, true);
		string name26 = "m_playerInfo1GameObject";
		if (Lua_BlackJack_ProjectL_UI_TeamRoomInfoUIController.<>f__mg$cache6A == null)
		{
			Lua_BlackJack_ProjectL_UI_TeamRoomInfoUIController.<>f__mg$cache6A = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_TeamRoomInfoUIController.get_m_playerInfo1GameObject);
		}
		LuaCSFunction get26 = Lua_BlackJack_ProjectL_UI_TeamRoomInfoUIController.<>f__mg$cache6A;
		if (Lua_BlackJack_ProjectL_UI_TeamRoomInfoUIController.<>f__mg$cache6B == null)
		{
			Lua_BlackJack_ProjectL_UI_TeamRoomInfoUIController.<>f__mg$cache6B = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_TeamRoomInfoUIController.set_m_playerInfo1GameObject);
		}
		LuaObject.addMember(l, name26, get26, Lua_BlackJack_ProjectL_UI_TeamRoomInfoUIController.<>f__mg$cache6B, true);
		string name27 = "m_playerInfo2GameObject";
		if (Lua_BlackJack_ProjectL_UI_TeamRoomInfoUIController.<>f__mg$cache6C == null)
		{
			Lua_BlackJack_ProjectL_UI_TeamRoomInfoUIController.<>f__mg$cache6C = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_TeamRoomInfoUIController.get_m_playerInfo2GameObject);
		}
		LuaCSFunction get27 = Lua_BlackJack_ProjectL_UI_TeamRoomInfoUIController.<>f__mg$cache6C;
		if (Lua_BlackJack_ProjectL_UI_TeamRoomInfoUIController.<>f__mg$cache6D == null)
		{
			Lua_BlackJack_ProjectL_UI_TeamRoomInfoUIController.<>f__mg$cache6D = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_TeamRoomInfoUIController.set_m_playerInfo2GameObject);
		}
		LuaObject.addMember(l, name27, get27, Lua_BlackJack_ProjectL_UI_TeamRoomInfoUIController.<>f__mg$cache6D, true);
		string name28 = "m_changePlayerPositionPanelGameObject";
		if (Lua_BlackJack_ProjectL_UI_TeamRoomInfoUIController.<>f__mg$cache6E == null)
		{
			Lua_BlackJack_ProjectL_UI_TeamRoomInfoUIController.<>f__mg$cache6E = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_TeamRoomInfoUIController.get_m_changePlayerPositionPanelGameObject);
		}
		LuaCSFunction get28 = Lua_BlackJack_ProjectL_UI_TeamRoomInfoUIController.<>f__mg$cache6E;
		if (Lua_BlackJack_ProjectL_UI_TeamRoomInfoUIController.<>f__mg$cache6F == null)
		{
			Lua_BlackJack_ProjectL_UI_TeamRoomInfoUIController.<>f__mg$cache6F = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_TeamRoomInfoUIController.set_m_changePlayerPositionPanelGameObject);
		}
		LuaObject.addMember(l, name28, get28, Lua_BlackJack_ProjectL_UI_TeamRoomInfoUIController.<>f__mg$cache6F, true);
		string name29 = "m_changePlayerPositionCompleteButton";
		if (Lua_BlackJack_ProjectL_UI_TeamRoomInfoUIController.<>f__mg$cache70 == null)
		{
			Lua_BlackJack_ProjectL_UI_TeamRoomInfoUIController.<>f__mg$cache70 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_TeamRoomInfoUIController.get_m_changePlayerPositionCompleteButton);
		}
		LuaCSFunction get29 = Lua_BlackJack_ProjectL_UI_TeamRoomInfoUIController.<>f__mg$cache70;
		if (Lua_BlackJack_ProjectL_UI_TeamRoomInfoUIController.<>f__mg$cache71 == null)
		{
			Lua_BlackJack_ProjectL_UI_TeamRoomInfoUIController.<>f__mg$cache71 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_TeamRoomInfoUIController.set_m_changePlayerPositionCompleteButton);
		}
		LuaObject.addMember(l, name29, get29, Lua_BlackJack_ProjectL_UI_TeamRoomInfoUIController.<>f__mg$cache71, true);
		string name30 = "m_changePlayerPositionInfo0GameObject";
		if (Lua_BlackJack_ProjectL_UI_TeamRoomInfoUIController.<>f__mg$cache72 == null)
		{
			Lua_BlackJack_ProjectL_UI_TeamRoomInfoUIController.<>f__mg$cache72 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_TeamRoomInfoUIController.get_m_changePlayerPositionInfo0GameObject);
		}
		LuaCSFunction get30 = Lua_BlackJack_ProjectL_UI_TeamRoomInfoUIController.<>f__mg$cache72;
		if (Lua_BlackJack_ProjectL_UI_TeamRoomInfoUIController.<>f__mg$cache73 == null)
		{
			Lua_BlackJack_ProjectL_UI_TeamRoomInfoUIController.<>f__mg$cache73 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_TeamRoomInfoUIController.set_m_changePlayerPositionInfo0GameObject);
		}
		LuaObject.addMember(l, name30, get30, Lua_BlackJack_ProjectL_UI_TeamRoomInfoUIController.<>f__mg$cache73, true);
		string name31 = "m_changePlayerPositionInfo1GameObject";
		if (Lua_BlackJack_ProjectL_UI_TeamRoomInfoUIController.<>f__mg$cache74 == null)
		{
			Lua_BlackJack_ProjectL_UI_TeamRoomInfoUIController.<>f__mg$cache74 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_TeamRoomInfoUIController.get_m_changePlayerPositionInfo1GameObject);
		}
		LuaCSFunction get31 = Lua_BlackJack_ProjectL_UI_TeamRoomInfoUIController.<>f__mg$cache74;
		if (Lua_BlackJack_ProjectL_UI_TeamRoomInfoUIController.<>f__mg$cache75 == null)
		{
			Lua_BlackJack_ProjectL_UI_TeamRoomInfoUIController.<>f__mg$cache75 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_TeamRoomInfoUIController.set_m_changePlayerPositionInfo1GameObject);
		}
		LuaObject.addMember(l, name31, get31, Lua_BlackJack_ProjectL_UI_TeamRoomInfoUIController.<>f__mg$cache75, true);
		string name32 = "m_changePlayerPositionInfo2GameObject";
		if (Lua_BlackJack_ProjectL_UI_TeamRoomInfoUIController.<>f__mg$cache76 == null)
		{
			Lua_BlackJack_ProjectL_UI_TeamRoomInfoUIController.<>f__mg$cache76 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_TeamRoomInfoUIController.get_m_changePlayerPositionInfo2GameObject);
		}
		LuaCSFunction get32 = Lua_BlackJack_ProjectL_UI_TeamRoomInfoUIController.<>f__mg$cache76;
		if (Lua_BlackJack_ProjectL_UI_TeamRoomInfoUIController.<>f__mg$cache77 == null)
		{
			Lua_BlackJack_ProjectL_UI_TeamRoomInfoUIController.<>f__mg$cache77 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_TeamRoomInfoUIController.set_m_changePlayerPositionInfo2GameObject);
		}
		LuaObject.addMember(l, name32, get32, Lua_BlackJack_ProjectL_UI_TeamRoomInfoUIController.<>f__mg$cache77, true);
		string name33 = "m_prefabsGameObject";
		if (Lua_BlackJack_ProjectL_UI_TeamRoomInfoUIController.<>f__mg$cache78 == null)
		{
			Lua_BlackJack_ProjectL_UI_TeamRoomInfoUIController.<>f__mg$cache78 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_TeamRoomInfoUIController.get_m_prefabsGameObject);
		}
		LuaCSFunction get33 = Lua_BlackJack_ProjectL_UI_TeamRoomInfoUIController.<>f__mg$cache78;
		if (Lua_BlackJack_ProjectL_UI_TeamRoomInfoUIController.<>f__mg$cache79 == null)
		{
			Lua_BlackJack_ProjectL_UI_TeamRoomInfoUIController.<>f__mg$cache79 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_TeamRoomInfoUIController.set_m_prefabsGameObject);
		}
		LuaObject.addMember(l, name33, get33, Lua_BlackJack_ProjectL_UI_TeamRoomInfoUIController.<>f__mg$cache79, true);
		string name34 = "m_playerInfoPrefab";
		if (Lua_BlackJack_ProjectL_UI_TeamRoomInfoUIController.<>f__mg$cache7A == null)
		{
			Lua_BlackJack_ProjectL_UI_TeamRoomInfoUIController.<>f__mg$cache7A = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_TeamRoomInfoUIController.get_m_playerInfoPrefab);
		}
		LuaCSFunction get34 = Lua_BlackJack_ProjectL_UI_TeamRoomInfoUIController.<>f__mg$cache7A;
		if (Lua_BlackJack_ProjectL_UI_TeamRoomInfoUIController.<>f__mg$cache7B == null)
		{
			Lua_BlackJack_ProjectL_UI_TeamRoomInfoUIController.<>f__mg$cache7B = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_TeamRoomInfoUIController.set_m_playerInfoPrefab);
		}
		LuaObject.addMember(l, name34, get34, Lua_BlackJack_ProjectL_UI_TeamRoomInfoUIController.<>f__mg$cache7B, true);
		string name35 = "m_expressionParseDesc";
		if (Lua_BlackJack_ProjectL_UI_TeamRoomInfoUIController.<>f__mg$cache7C == null)
		{
			Lua_BlackJack_ProjectL_UI_TeamRoomInfoUIController.<>f__mg$cache7C = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_TeamRoomInfoUIController.get_m_expressionParseDesc);
		}
		LuaCSFunction get35 = Lua_BlackJack_ProjectL_UI_TeamRoomInfoUIController.<>f__mg$cache7C;
		if (Lua_BlackJack_ProjectL_UI_TeamRoomInfoUIController.<>f__mg$cache7D == null)
		{
			Lua_BlackJack_ProjectL_UI_TeamRoomInfoUIController.<>f__mg$cache7D = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_TeamRoomInfoUIController.set_m_expressionParseDesc);
		}
		LuaObject.addMember(l, name35, get35, Lua_BlackJack_ProjectL_UI_TeamRoomInfoUIController.<>f__mg$cache7D, true);
		string name36 = "m_expressionResContainer";
		if (Lua_BlackJack_ProjectL_UI_TeamRoomInfoUIController.<>f__mg$cache7E == null)
		{
			Lua_BlackJack_ProjectL_UI_TeamRoomInfoUIController.<>f__mg$cache7E = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_TeamRoomInfoUIController.get_m_expressionResContainer);
		}
		LuaCSFunction get36 = Lua_BlackJack_ProjectL_UI_TeamRoomInfoUIController.<>f__mg$cache7E;
		if (Lua_BlackJack_ProjectL_UI_TeamRoomInfoUIController.<>f__mg$cache7F == null)
		{
			Lua_BlackJack_ProjectL_UI_TeamRoomInfoUIController.<>f__mg$cache7F = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_TeamRoomInfoUIController.set_m_expressionResContainer);
		}
		LuaObject.addMember(l, name36, get36, Lua_BlackJack_ProjectL_UI_TeamRoomInfoUIController.<>f__mg$cache7F, true);
		string name37 = "m_playerInfoUIControllers";
		if (Lua_BlackJack_ProjectL_UI_TeamRoomInfoUIController.<>f__mg$cache80 == null)
		{
			Lua_BlackJack_ProjectL_UI_TeamRoomInfoUIController.<>f__mg$cache80 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_TeamRoomInfoUIController.get_m_playerInfoUIControllers);
		}
		LuaCSFunction get37 = Lua_BlackJack_ProjectL_UI_TeamRoomInfoUIController.<>f__mg$cache80;
		if (Lua_BlackJack_ProjectL_UI_TeamRoomInfoUIController.<>f__mg$cache81 == null)
		{
			Lua_BlackJack_ProjectL_UI_TeamRoomInfoUIController.<>f__mg$cache81 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_TeamRoomInfoUIController.set_m_playerInfoUIControllers);
		}
		LuaObject.addMember(l, name37, get37, Lua_BlackJack_ProjectL_UI_TeamRoomInfoUIController.<>f__mg$cache81, true);
		string name38 = "m_editPlayerInfoUIControllers";
		if (Lua_BlackJack_ProjectL_UI_TeamRoomInfoUIController.<>f__mg$cache82 == null)
		{
			Lua_BlackJack_ProjectL_UI_TeamRoomInfoUIController.<>f__mg$cache82 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_TeamRoomInfoUIController.get_m_editPlayerInfoUIControllers);
		}
		LuaCSFunction get38 = Lua_BlackJack_ProjectL_UI_TeamRoomInfoUIController.<>f__mg$cache82;
		if (Lua_BlackJack_ProjectL_UI_TeamRoomInfoUIController.<>f__mg$cache83 == null)
		{
			Lua_BlackJack_ProjectL_UI_TeamRoomInfoUIController.<>f__mg$cache83 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_TeamRoomInfoUIController.set_m_editPlayerInfoUIControllers);
		}
		LuaObject.addMember(l, name38, get38, Lua_BlackJack_ProjectL_UI_TeamRoomInfoUIController.<>f__mg$cache83, true);
		string name39 = "m_draggingPlayerInfoUIController";
		if (Lua_BlackJack_ProjectL_UI_TeamRoomInfoUIController.<>f__mg$cache84 == null)
		{
			Lua_BlackJack_ProjectL_UI_TeamRoomInfoUIController.<>f__mg$cache84 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_TeamRoomInfoUIController.get_m_draggingPlayerInfoUIController);
		}
		LuaCSFunction get39 = Lua_BlackJack_ProjectL_UI_TeamRoomInfoUIController.<>f__mg$cache84;
		if (Lua_BlackJack_ProjectL_UI_TeamRoomInfoUIController.<>f__mg$cache85 == null)
		{
			Lua_BlackJack_ProjectL_UI_TeamRoomInfoUIController.<>f__mg$cache85 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_TeamRoomInfoUIController.set_m_draggingPlayerInfoUIController);
		}
		LuaObject.addMember(l, name39, get39, Lua_BlackJack_ProjectL_UI_TeamRoomInfoUIController.<>f__mg$cache85, true);
		string name40 = "m_isIgnoreToggleEvent";
		if (Lua_BlackJack_ProjectL_UI_TeamRoomInfoUIController.<>f__mg$cache86 == null)
		{
			Lua_BlackJack_ProjectL_UI_TeamRoomInfoUIController.<>f__mg$cache86 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_TeamRoomInfoUIController.get_m_isIgnoreToggleEvent);
		}
		LuaCSFunction get40 = Lua_BlackJack_ProjectL_UI_TeamRoomInfoUIController.<>f__mg$cache86;
		if (Lua_BlackJack_ProjectL_UI_TeamRoomInfoUIController.<>f__mg$cache87 == null)
		{
			Lua_BlackJack_ProjectL_UI_TeamRoomInfoUIController.<>f__mg$cache87 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_TeamRoomInfoUIController.set_m_isIgnoreToggleEvent);
		}
		LuaObject.addMember(l, name40, get40, Lua_BlackJack_ProjectL_UI_TeamRoomInfoUIController.<>f__mg$cache87, true);
		string name41 = "m_camera";
		if (Lua_BlackJack_ProjectL_UI_TeamRoomInfoUIController.<>f__mg$cache88 == null)
		{
			Lua_BlackJack_ProjectL_UI_TeamRoomInfoUIController.<>f__mg$cache88 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_TeamRoomInfoUIController.get_m_camera);
		}
		LuaCSFunction get41 = Lua_BlackJack_ProjectL_UI_TeamRoomInfoUIController.<>f__mg$cache88;
		if (Lua_BlackJack_ProjectL_UI_TeamRoomInfoUIController.<>f__mg$cache89 == null)
		{
			Lua_BlackJack_ProjectL_UI_TeamRoomInfoUIController.<>f__mg$cache89 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_TeamRoomInfoUIController.set_m_camera);
		}
		LuaObject.addMember(l, name41, get41, Lua_BlackJack_ProjectL_UI_TeamRoomInfoUIController.<>f__mg$cache89, true);
		LuaObject.createTypeMetatable(l, null, typeof(TeamRoomInfoUIController), typeof(UIControllerBase));
	}

	// Token: 0x0401757E RID: 95614
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache0;

	// Token: 0x0401757F RID: 95615
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1;

	// Token: 0x04017580 RID: 95616
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2;

	// Token: 0x04017581 RID: 95617
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3;

	// Token: 0x04017582 RID: 95618
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache4;

	// Token: 0x04017583 RID: 95619
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache5;

	// Token: 0x04017584 RID: 95620
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache6;

	// Token: 0x04017585 RID: 95621
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache7;

	// Token: 0x04017586 RID: 95622
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache8;

	// Token: 0x04017587 RID: 95623
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache9;

	// Token: 0x04017588 RID: 95624
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheA;

	// Token: 0x04017589 RID: 95625
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheB;

	// Token: 0x0401758A RID: 95626
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheC;

	// Token: 0x0401758B RID: 95627
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheD;

	// Token: 0x0401758C RID: 95628
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheE;

	// Token: 0x0401758D RID: 95629
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheF;

	// Token: 0x0401758E RID: 95630
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache10;

	// Token: 0x0401758F RID: 95631
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache11;

	// Token: 0x04017590 RID: 95632
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache12;

	// Token: 0x04017591 RID: 95633
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache13;

	// Token: 0x04017592 RID: 95634
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache14;

	// Token: 0x04017593 RID: 95635
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache15;

	// Token: 0x04017594 RID: 95636
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache16;

	// Token: 0x04017595 RID: 95637
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache17;

	// Token: 0x04017596 RID: 95638
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache18;

	// Token: 0x04017597 RID: 95639
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache19;

	// Token: 0x04017598 RID: 95640
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1A;

	// Token: 0x04017599 RID: 95641
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1B;

	// Token: 0x0401759A RID: 95642
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1C;

	// Token: 0x0401759B RID: 95643
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1D;

	// Token: 0x0401759C RID: 95644
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1E;

	// Token: 0x0401759D RID: 95645
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1F;

	// Token: 0x0401759E RID: 95646
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache20;

	// Token: 0x0401759F RID: 95647
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache21;

	// Token: 0x040175A0 RID: 95648
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache22;

	// Token: 0x040175A1 RID: 95649
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache23;

	// Token: 0x040175A2 RID: 95650
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache24;

	// Token: 0x040175A3 RID: 95651
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache25;

	// Token: 0x040175A4 RID: 95652
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache26;

	// Token: 0x040175A5 RID: 95653
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache27;

	// Token: 0x040175A6 RID: 95654
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache28;

	// Token: 0x040175A7 RID: 95655
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache29;

	// Token: 0x040175A8 RID: 95656
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2A;

	// Token: 0x040175A9 RID: 95657
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2B;

	// Token: 0x040175AA RID: 95658
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2C;

	// Token: 0x040175AB RID: 95659
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2D;

	// Token: 0x040175AC RID: 95660
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2E;

	// Token: 0x040175AD RID: 95661
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2F;

	// Token: 0x040175AE RID: 95662
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache30;

	// Token: 0x040175AF RID: 95663
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache31;

	// Token: 0x040175B0 RID: 95664
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache32;

	// Token: 0x040175B1 RID: 95665
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache33;

	// Token: 0x040175B2 RID: 95666
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache34;

	// Token: 0x040175B3 RID: 95667
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache35;

	// Token: 0x040175B4 RID: 95668
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache36;

	// Token: 0x040175B5 RID: 95669
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache37;

	// Token: 0x040175B6 RID: 95670
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache38;

	// Token: 0x040175B7 RID: 95671
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache39;

	// Token: 0x040175B8 RID: 95672
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3A;

	// Token: 0x040175B9 RID: 95673
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3B;

	// Token: 0x040175BA RID: 95674
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3C;

	// Token: 0x040175BB RID: 95675
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3D;

	// Token: 0x040175BC RID: 95676
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3E;

	// Token: 0x040175BD RID: 95677
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3F;

	// Token: 0x040175BE RID: 95678
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache40;

	// Token: 0x040175BF RID: 95679
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache41;

	// Token: 0x040175C0 RID: 95680
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache42;

	// Token: 0x040175C1 RID: 95681
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache43;

	// Token: 0x040175C2 RID: 95682
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache44;

	// Token: 0x040175C3 RID: 95683
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache45;

	// Token: 0x040175C4 RID: 95684
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache46;

	// Token: 0x040175C5 RID: 95685
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache47;

	// Token: 0x040175C6 RID: 95686
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache48;

	// Token: 0x040175C7 RID: 95687
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache49;

	// Token: 0x040175C8 RID: 95688
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache4A;

	// Token: 0x040175C9 RID: 95689
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache4B;

	// Token: 0x040175CA RID: 95690
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache4C;

	// Token: 0x040175CB RID: 95691
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache4D;

	// Token: 0x040175CC RID: 95692
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache4E;

	// Token: 0x040175CD RID: 95693
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache4F;

	// Token: 0x040175CE RID: 95694
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache50;

	// Token: 0x040175CF RID: 95695
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache51;

	// Token: 0x040175D0 RID: 95696
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache52;

	// Token: 0x040175D1 RID: 95697
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache53;

	// Token: 0x040175D2 RID: 95698
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache54;

	// Token: 0x040175D3 RID: 95699
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache55;

	// Token: 0x040175D4 RID: 95700
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache56;

	// Token: 0x040175D5 RID: 95701
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache57;

	// Token: 0x040175D6 RID: 95702
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache58;

	// Token: 0x040175D7 RID: 95703
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache59;

	// Token: 0x040175D8 RID: 95704
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache5A;

	// Token: 0x040175D9 RID: 95705
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache5B;

	// Token: 0x040175DA RID: 95706
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache5C;

	// Token: 0x040175DB RID: 95707
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache5D;

	// Token: 0x040175DC RID: 95708
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache5E;

	// Token: 0x040175DD RID: 95709
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache5F;

	// Token: 0x040175DE RID: 95710
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache60;

	// Token: 0x040175DF RID: 95711
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache61;

	// Token: 0x040175E0 RID: 95712
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache62;

	// Token: 0x040175E1 RID: 95713
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache63;

	// Token: 0x040175E2 RID: 95714
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache64;

	// Token: 0x040175E3 RID: 95715
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache65;

	// Token: 0x040175E4 RID: 95716
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache66;

	// Token: 0x040175E5 RID: 95717
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache67;

	// Token: 0x040175E6 RID: 95718
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache68;

	// Token: 0x040175E7 RID: 95719
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache69;

	// Token: 0x040175E8 RID: 95720
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache6A;

	// Token: 0x040175E9 RID: 95721
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache6B;

	// Token: 0x040175EA RID: 95722
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache6C;

	// Token: 0x040175EB RID: 95723
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache6D;

	// Token: 0x040175EC RID: 95724
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache6E;

	// Token: 0x040175ED RID: 95725
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache6F;

	// Token: 0x040175EE RID: 95726
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache70;

	// Token: 0x040175EF RID: 95727
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache71;

	// Token: 0x040175F0 RID: 95728
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache72;

	// Token: 0x040175F1 RID: 95729
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache73;

	// Token: 0x040175F2 RID: 95730
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache74;

	// Token: 0x040175F3 RID: 95731
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache75;

	// Token: 0x040175F4 RID: 95732
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache76;

	// Token: 0x040175F5 RID: 95733
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache77;

	// Token: 0x040175F6 RID: 95734
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache78;

	// Token: 0x040175F7 RID: 95735
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache79;

	// Token: 0x040175F8 RID: 95736
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache7A;

	// Token: 0x040175F9 RID: 95737
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache7B;

	// Token: 0x040175FA RID: 95738
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache7C;

	// Token: 0x040175FB RID: 95739
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache7D;

	// Token: 0x040175FC RID: 95740
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache7E;

	// Token: 0x040175FD RID: 95741
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache7F;

	// Token: 0x040175FE RID: 95742
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache80;

	// Token: 0x040175FF RID: 95743
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache81;

	// Token: 0x04017600 RID: 95744
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache82;

	// Token: 0x04017601 RID: 95745
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache83;

	// Token: 0x04017602 RID: 95746
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache84;

	// Token: 0x04017603 RID: 95747
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache85;

	// Token: 0x04017604 RID: 95748
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache86;

	// Token: 0x04017605 RID: 95749
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache87;

	// Token: 0x04017606 RID: 95750
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache88;

	// Token: 0x04017607 RID: 95751
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache89;
}
