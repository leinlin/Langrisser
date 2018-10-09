using System;
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

// Token: 0x020015A8 RID: 5544
[Preserve]
public class Lua_BlackJack_ProjectL_UI_TeamUIController : LuaObject
{
	// Token: 0x06021903 RID: 137475 RVA: 0x00B5E6CC File Offset: 0x00B5C8CC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int Open(IntPtr l)
	{
		int result;
		try
		{
			TeamUIController teamUIController = (TeamUIController)LuaObject.checkSelf(l);
			teamUIController.Open();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06021904 RID: 137476 RVA: 0x00B5E718 File Offset: 0x00B5C918
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int SelectGameFunctionTypeAndLocation(IntPtr l)
	{
		int result;
		try
		{
			TeamUIController teamUIController = (TeamUIController)LuaObject.checkSelf(l);
			GameFunctionType gameFunctionType;
			LuaObject.checkEnum<GameFunctionType>(l, 2, out gameFunctionType);
			int chapterId;
			LuaObject.checkType(l, 3, out chapterId);
			int locationId;
			LuaObject.checkType(l, 4, out locationId);
			teamUIController.SelectGameFunctionTypeAndLocation(gameFunctionType, chapterId, locationId);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06021905 RID: 137477 RVA: 0x00B5E78C File Offset: 0x00B5C98C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int SetTeamRooms(IntPtr l)
	{
		int result;
		try
		{
			TeamUIController teamUIController = (TeamUIController)LuaObject.checkSelf(l);
			List<TeamRoom> teamRooms;
			LuaObject.checkType<List<TeamRoom>>(l, 2, out teamRooms);
			teamUIController.SetTeamRooms(teamRooms);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06021906 RID: 137478 RVA: 0x00B5E7E4 File Offset: 0x00B5C9E4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int SetAutoMatchMode(IntPtr l)
	{
		int result;
		try
		{
			TeamUIController teamUIController = (TeamUIController)LuaObject.checkSelf(l);
			bool autoMatchMode;
			LuaObject.checkType(l, 2, out autoMatchMode);
			teamUIController.SetAutoMatchMode(autoMatchMode);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06021907 RID: 137479 RVA: 0x00B5E83C File Offset: 0x00B5CA3C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int SetAutoMatchWaitCount(IntPtr l)
	{
		int result;
		try
		{
			TeamUIController teamUIController = (TeamUIController)LuaObject.checkSelf(l);
			int autoMatchWaitCount;
			LuaObject.checkType(l, 2, out autoMatchWaitCount);
			teamUIController.SetAutoMatchWaitCount(autoMatchWaitCount);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06021908 RID: 137480 RVA: 0x00B5E894 File Offset: 0x00B5CA94
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int IsAutoMatching(IntPtr l)
	{
		int result;
		try
		{
			TeamUIController teamUIController = (TeamUIController)LuaObject.checkSelf(l);
			bool b = teamUIController.IsAutoMatching();
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

	// Token: 0x06021909 RID: 137481 RVA: 0x00B5E8E8 File Offset: 0x00B5CAE8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int GetGameFunctionType(IntPtr l)
	{
		int result;
		try
		{
			TeamUIController teamUIController = (TeamUIController)LuaObject.checkSelf(l);
			GameFunctionType gameFunctionType = teamUIController.GetGameFunctionType();
			LuaObject.pushValue(l, true);
			LuaObject.pushEnum(l, (int)gameFunctionType);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0602190A RID: 137482 RVA: 0x00B5E93C File Offset: 0x00B5CB3C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int GetChapterId(IntPtr l)
	{
		int result;
		try
		{
			TeamUIController teamUIController = (TeamUIController)LuaObject.checkSelf(l);
			int chapterId = teamUIController.GetChapterId();
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, chapterId);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0602190B RID: 137483 RVA: 0x00B5E990 File Offset: 0x00B5CB90
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int GetLocationId(IntPtr l)
	{
		int result;
		try
		{
			TeamUIController teamUIController = (TeamUIController)LuaObject.checkSelf(l);
			int locationId = teamUIController.GetLocationId();
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, locationId);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0602190C RID: 137484 RVA: 0x00B5E9E4 File Offset: 0x00B5CBE4
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int GetGameFunctionName_s(IntPtr l)
	{
		int result;
		try
		{
			GameFunctionType gameFunctionType;
			LuaObject.checkEnum<GameFunctionType>(l, 1, out gameFunctionType);
			int locationId;
			LuaObject.checkType(l, 2, out locationId);
			string gameFunctionName = TeamUIController.GetGameFunctionName(gameFunctionType, locationId);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, gameFunctionName);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0602190D RID: 137485 RVA: 0x00B5EA44 File Offset: 0x00B5CC44
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int GetLocationName_s(IntPtr l)
	{
		int result;
		try
		{
			GameFunctionType gameFunctionType;
			LuaObject.checkEnum<GameFunctionType>(l, 1, out gameFunctionType);
			int locationId;
			LuaObject.checkType(l, 2, out locationId);
			string locationName = TeamUIController.GetLocationName(gameFunctionType, locationId);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, locationName);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0602190E RID: 137486 RVA: 0x00B5EAA4 File Offset: 0x00B5CCA4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int GetEnergy_s(IntPtr l)
	{
		int result;
		try
		{
			GameFunctionType gameFunctionType;
			LuaObject.checkEnum<GameFunctionType>(l, 1, out gameFunctionType);
			int locationId;
			LuaObject.checkType(l, 2, out locationId);
			int energy = TeamUIController.GetEnergy(gameFunctionType, locationId);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, energy);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0602190F RID: 137487 RVA: 0x00B5EB04 File Offset: 0x00B5CD04
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int OnBindFiledsCompleted(IntPtr l)
	{
		int result;
		try
		{
			TeamUIController teamUIController = (TeamUIController)LuaObject.checkSelf(l);
			teamUIController.m_luaExportHelper.OnBindFiledsCompleted();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06021910 RID: 137488 RVA: 0x00B5EB58 File Offset: 0x00B5CD58
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int AddGameFunctionTypeListItems(IntPtr l)
	{
		int result;
		try
		{
			TeamUIController teamUIController = (TeamUIController)LuaObject.checkSelf(l);
			teamUIController.m_luaExportHelper.AddGameFunctionTypeListItems();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06021911 RID: 137489 RVA: 0x00B5EBAC File Offset: 0x00B5CDAC
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int ClearGameFunctionTypeListItems(IntPtr l)
	{
		int result;
		try
		{
			TeamUIController teamUIController = (TeamUIController)LuaObject.checkSelf(l);
			teamUIController.m_luaExportHelper.ClearGameFunctionTypeListItems();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06021912 RID: 137490 RVA: 0x00B5EC00 File Offset: 0x00B5CE00
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int AddGameFunctionTypeListItem(IntPtr l)
	{
		int result;
		try
		{
			TeamUIController teamUIController = (TeamUIController)LuaObject.checkSelf(l);
			string name;
			LuaObject.checkType(l, 2, out name);
			GameFunctionType gameFunctionType;
			LuaObject.checkEnum<GameFunctionType>(l, 3, out gameFunctionType);
			int chapterId;
			LuaObject.checkType(l, 4, out chapterId);
			bool isLocked;
			LuaObject.checkType(l, 5, out isLocked);
			teamUIController.m_luaExportHelper.AddGameFunctionTypeListItem(name, gameFunctionType, chapterId, isLocked);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06021913 RID: 137491 RVA: 0x00B5EC84 File Offset: 0x00B5CE84
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int AddLocationListItems(IntPtr l)
	{
		int result;
		try
		{
			TeamUIController teamUIController = (TeamUIController)LuaObject.checkSelf(l);
			GameFunctionType gameFunctionType;
			LuaObject.checkEnum<GameFunctionType>(l, 2, out gameFunctionType);
			int chapterId;
			LuaObject.checkType(l, 3, out chapterId);
			teamUIController.m_luaExportHelper.AddLocationListItems(gameFunctionType, chapterId);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06021914 RID: 137492 RVA: 0x00B5ECF0 File Offset: 0x00B5CEF0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int ClearLocationListItems(IntPtr l)
	{
		int result;
		try
		{
			TeamUIController teamUIController = (TeamUIController)LuaObject.checkSelf(l);
			teamUIController.m_luaExportHelper.ClearLocationListItems();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06021915 RID: 137493 RVA: 0x00B5ED44 File Offset: 0x00B5CF44
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int AddLocationListItem(IntPtr l)
	{
		int result;
		try
		{
			TeamUIController teamUIController = (TeamUIController)LuaObject.checkSelf(l);
			string name;
			LuaObject.checkType(l, 2, out name);
			int locationId;
			LuaObject.checkType(l, 3, out locationId);
			int energy;
			LuaObject.checkType(l, 4, out energy);
			bool isLocked;
			LuaObject.checkType(l, 5, out isLocked);
			teamUIController.m_luaExportHelper.AddLocationListItem(name, locationId, energy, isLocked);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06021916 RID: 137494 RVA: 0x00B5EDC8 File Offset: 0x00B5CFC8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int AddTeamRoomListItem(IntPtr l)
	{
		int result;
		try
		{
			TeamUIController teamUIController = (TeamUIController)LuaObject.checkSelf(l);
			TeamRoom room;
			LuaObject.checkType<TeamRoom>(l, 2, out room);
			teamUIController.m_luaExportHelper.AddTeamRoomListItem(room);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06021917 RID: 137495 RVA: 0x00B5EE24 File Offset: 0x00B5D024
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int ClearTeamRoomListItems(IntPtr l)
	{
		int result;
		try
		{
			TeamUIController teamUIController = (TeamUIController)LuaObject.checkSelf(l);
			teamUIController.m_luaExportHelper.ClearTeamRoomListItems();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06021918 RID: 137496 RVA: 0x00B5EE78 File Offset: 0x00B5D078
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int UpdateTitle(IntPtr l)
	{
		int result;
		try
		{
			TeamUIController teamUIController = (TeamUIController)LuaObject.checkSelf(l);
			teamUIController.m_luaExportHelper.UpdateTitle();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06021919 RID: 137497 RVA: 0x00B5EECC File Offset: 0x00B5D0CC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int OnReturnButtonClick(IntPtr l)
	{
		int result;
		try
		{
			TeamUIController teamUIController = (TeamUIController)LuaObject.checkSelf(l);
			teamUIController.m_luaExportHelper.OnReturnButtonClick();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0602191A RID: 137498 RVA: 0x00B5EF20 File Offset: 0x00B5D120
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int OnHelpButtonClick(IntPtr l)
	{
		int result;
		try
		{
			TeamUIController teamUIController = (TeamUIController)LuaObject.checkSelf(l);
			teamUIController.m_luaExportHelper.OnHelpButtonClick();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0602191B RID: 137499 RVA: 0x00B5EF74 File Offset: 0x00B5D174
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int OnRefreshTeamRoomButtonClick(IntPtr l)
	{
		int result;
		try
		{
			TeamUIController teamUIController = (TeamUIController)LuaObject.checkSelf(l);
			teamUIController.m_luaExportHelper.OnRefreshTeamRoomButtonClick();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0602191C RID: 137500 RVA: 0x00B5EFC8 File Offset: 0x00B5D1C8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int OnShowCreateTeamRoomButtonClick(IntPtr l)
	{
		int result;
		try
		{
			TeamUIController teamUIController = (TeamUIController)LuaObject.checkSelf(l);
			teamUIController.m_luaExportHelper.OnShowCreateTeamRoomButtonClick();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0602191D RID: 137501 RVA: 0x00B5F01C File Offset: 0x00B5D21C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int OnAutoMatchButtonClick(IntPtr l)
	{
		int result;
		try
		{
			TeamUIController teamUIController = (TeamUIController)LuaObject.checkSelf(l);
			teamUIController.m_luaExportHelper.OnAutoMatchButtonClick();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0602191E RID: 137502 RVA: 0x00B5F070 File Offset: 0x00B5D270
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int OnAutoMatchCancelButtonClick(IntPtr l)
	{
		int result;
		try
		{
			TeamUIController teamUIController = (TeamUIController)LuaObject.checkSelf(l);
			teamUIController.m_luaExportHelper.OnAutoMatchCancelButtonClick();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0602191F RID: 137503 RVA: 0x00B5F0C4 File Offset: 0x00B5D2C4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int OnLocationListCloseButtonClick(IntPtr l)
	{
		int result;
		try
		{
			TeamUIController teamUIController = (TeamUIController)LuaObject.checkSelf(l);
			teamUIController.m_luaExportHelper.OnLocationListCloseButtonClick();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06021920 RID: 137504 RVA: 0x00B5F118 File Offset: 0x00B5D318
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int TeamGameFunctionTypeListItem_OnToggleValueChanged(IntPtr l)
	{
		int result;
		try
		{
			TeamUIController teamUIController = (TeamUIController)LuaObject.checkSelf(l);
			bool isOn;
			LuaObject.checkType(l, 2, out isOn);
			TeamGameFunctionTypeListItemUIController ctrl;
			LuaObject.checkType<TeamGameFunctionTypeListItemUIController>(l, 3, out ctrl);
			teamUIController.m_luaExportHelper.TeamGameFunctionTypeListItem_OnToggleValueChanged(isOn, ctrl);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06021921 RID: 137505 RVA: 0x00B5F184 File Offset: 0x00B5D384
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int GetSelectedGameFunctionTypeListItem(IntPtr l)
	{
		int result;
		try
		{
			TeamUIController teamUIController = (TeamUIController)LuaObject.checkSelf(l);
			TeamGameFunctionTypeListItemUIController selectedGameFunctionTypeListItem = teamUIController.m_luaExportHelper.GetSelectedGameFunctionTypeListItem();
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, selectedGameFunctionTypeListItem);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06021922 RID: 137506 RVA: 0x00B5F1E0 File Offset: 0x00B5D3E0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int GetSelectedLocationListItem(IntPtr l)
	{
		int result;
		try
		{
			TeamUIController teamUIController = (TeamUIController)LuaObject.checkSelf(l);
			TeamLocationListItemUIController selectedLocationListItem = teamUIController.m_luaExportHelper.GetSelectedLocationListItem();
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, selectedLocationListItem);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06021923 RID: 137507 RVA: 0x00B5F23C File Offset: 0x00B5D43C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int TeamLocationListItem_OnToggleValueChanged(IntPtr l)
	{
		int result;
		try
		{
			TeamUIController teamUIController = (TeamUIController)LuaObject.checkSelf(l);
			bool isOn;
			LuaObject.checkType(l, 2, out isOn);
			TeamLocationListItemUIController ctrl;
			LuaObject.checkType<TeamLocationListItemUIController>(l, 3, out ctrl);
			teamUIController.m_luaExportHelper.TeamLocationListItem_OnToggleValueChanged(isOn, ctrl);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06021924 RID: 137508 RVA: 0x00B5F2A8 File Offset: 0x00B5D4A8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int TeamRoomListItem_OnJoinButtonClick(IntPtr l)
	{
		int result;
		try
		{
			TeamUIController teamUIController = (TeamUIController)LuaObject.checkSelf(l);
			TeamRoomListItemUIController ctrl;
			LuaObject.checkType<TeamRoomListItemUIController>(l, 2, out ctrl);
			teamUIController.m_luaExportHelper.TeamRoomListItem_OnJoinButtonClick(ctrl);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06021925 RID: 137509 RVA: 0x00B5F304 File Offset: 0x00B5D504
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_Initlize(IntPtr l)
	{
		int result;
		try
		{
			TeamUIController teamUIController = (TeamUIController)LuaObject.checkSelf(l);
			string ctrlName;
			LuaObject.checkType(l, 2, out ctrlName);
			bool bindNow;
			LuaObject.checkType(l, 3, out bindNow);
			teamUIController.m_luaExportHelper.__callBase_Initlize(ctrlName, bindNow);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06021926 RID: 137510 RVA: 0x00B5F370 File Offset: 0x00B5D570
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_BindFields(IntPtr l)
	{
		int result;
		try
		{
			TeamUIController teamUIController = (TeamUIController)LuaObject.checkSelf(l);
			teamUIController.m_luaExportHelper.__callBase_BindFields();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06021927 RID: 137511 RVA: 0x00B5F3C4 File Offset: 0x00B5D5C4
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int __callBase_OnBindFiledsCompleted(IntPtr l)
	{
		int result;
		try
		{
			TeamUIController teamUIController = (TeamUIController)LuaObject.checkSelf(l);
			teamUIController.m_luaExportHelper.__callBase_OnBindFiledsCompleted();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06021928 RID: 137512 RVA: 0x00B5F418 File Offset: 0x00B5D618
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_BindFieldImpl(IntPtr l)
	{
		int result;
		try
		{
			TeamUIController teamUIController = (TeamUIController)LuaObject.checkSelf(l);
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
			UnityEngine.Object o = teamUIController.m_luaExportHelper.__callBase_BindFieldImpl(fieldType, path, initState, fieldName, ctrlName, optional);
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

	// Token: 0x06021929 RID: 137513 RVA: 0x00B5F4C0 File Offset: 0x00B5D6C0
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int __callBase_Clear(IntPtr l)
	{
		int result;
		try
		{
			TeamUIController teamUIController = (TeamUIController)LuaObject.checkSelf(l);
			teamUIController.m_luaExportHelper.__callBase_Clear();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0602192A RID: 137514 RVA: 0x00B5F514 File Offset: 0x00B5D714
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_OnButtonClick(IntPtr l)
	{
		int result;
		try
		{
			TeamUIController teamUIController = (TeamUIController)LuaObject.checkSelf(l);
			Button button;
			LuaObject.checkType<Button>(l, 2, out button);
			string fieldName;
			LuaObject.checkType(l, 3, out fieldName);
			teamUIController.m_luaExportHelper.__callBase_OnButtonClick(button, fieldName);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0602192B RID: 137515 RVA: 0x00B5F580 File Offset: 0x00B5D780
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
				TeamUIController teamUIController = (TeamUIController)LuaObject.checkSelf(l);
				string[] fieldNames;
				LuaObject.checkArray<string>(l, 2, out fieldNames);
				Action<UIControllerBase> action;
				LuaObject.checkDelegate<Action<UIControllerBase>>(l, 3, out action);
				teamUIController.m_luaExportHelper.__callBase_SetButtonClickListener(fieldNames, action);
				LuaObject.pushValue(l, true);
				result = 1;
			}
			else if (LuaObject.matchType(l, total, 2, typeof(string), typeof(Action<UIControllerBase>)))
			{
				TeamUIController teamUIController2 = (TeamUIController)LuaObject.checkSelf(l);
				string fieldName;
				LuaObject.checkType(l, 2, out fieldName);
				Action<UIControllerBase> action2;
				LuaObject.checkDelegate<Action<UIControllerBase>>(l, 3, out action2);
				teamUIController2.m_luaExportHelper.__callBase_SetButtonClickListener(fieldName, action2);
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

	// Token: 0x0602192C RID: 137516 RVA: 0x00B5F690 File Offset: 0x00B5D890
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_SetButtonDoubleClickListener(IntPtr l)
	{
		int result;
		try
		{
			TeamUIController teamUIController = (TeamUIController)LuaObject.checkSelf(l);
			string fieldName;
			LuaObject.checkType(l, 2, out fieldName);
			Action<UIControllerBase> action;
			LuaObject.checkDelegate<Action<UIControllerBase>>(l, 3, out action);
			teamUIController.m_luaExportHelper.__callBase_SetButtonDoubleClickListener(fieldName, action);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0602192D RID: 137517 RVA: 0x00B5F6FC File Offset: 0x00B5D8FC
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int __callBase_SetButtonLongPressStartListener(IntPtr l)
	{
		int result;
		try
		{
			TeamUIController teamUIController = (TeamUIController)LuaObject.checkSelf(l);
			string fieldName;
			LuaObject.checkType(l, 2, out fieldName);
			Action<UIControllerBase> action;
			LuaObject.checkDelegate<Action<UIControllerBase>>(l, 3, out action);
			teamUIController.m_luaExportHelper.__callBase_SetButtonLongPressStartListener(fieldName, action);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0602192E RID: 137518 RVA: 0x00B5F768 File Offset: 0x00B5D968
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_SetButtonLongPressingListener(IntPtr l)
	{
		int result;
		try
		{
			TeamUIController teamUIController = (TeamUIController)LuaObject.checkSelf(l);
			string fieldName;
			LuaObject.checkType(l, 2, out fieldName);
			Action<UIControllerBase> action;
			LuaObject.checkDelegate<Action<UIControllerBase>>(l, 3, out action);
			teamUIController.m_luaExportHelper.__callBase_SetButtonLongPressingListener(fieldName, action);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0602192F RID: 137519 RVA: 0x00B5F7D4 File Offset: 0x00B5D9D4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_SetButtonLongPressEndListener(IntPtr l)
	{
		int result;
		try
		{
			TeamUIController teamUIController = (TeamUIController)LuaObject.checkSelf(l);
			string fieldName;
			LuaObject.checkType(l, 2, out fieldName);
			Action<UIControllerBase> action;
			LuaObject.checkDelegate<Action<UIControllerBase>>(l, 3, out action);
			teamUIController.m_luaExportHelper.__callBase_SetButtonLongPressEndListener(fieldName, action);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06021930 RID: 137520 RVA: 0x00B5F840 File Offset: 0x00B5DA40
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
				TeamUIController teamUIController = (TeamUIController)LuaObject.checkSelf(l);
				string[] fieldNames;
				LuaObject.checkArray<string>(l, 2, out fieldNames);
				Action<UIControllerBase, bool> action;
				LuaObject.checkDelegate<Action<UIControllerBase, bool>>(l, 3, out action);
				teamUIController.m_luaExportHelper.__callBase_SetToggleValueChangedListener(fieldNames, action);
				LuaObject.pushValue(l, true);
				result = 1;
			}
			else if (LuaObject.matchType(l, total, 2, typeof(string), typeof(Action<UIControllerBase, bool>)))
			{
				TeamUIController teamUIController2 = (TeamUIController)LuaObject.checkSelf(l);
				string fieldName;
				LuaObject.checkType(l, 2, out fieldName);
				Action<UIControllerBase, bool> action2;
				LuaObject.checkDelegate<Action<UIControllerBase, bool>>(l, 3, out action2);
				teamUIController2.m_luaExportHelper.__callBase_SetToggleValueChangedListener(fieldName, action2);
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

	// Token: 0x06021931 RID: 137521 RVA: 0x00B5F950 File Offset: 0x00B5DB50
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_ToString(IntPtr l)
	{
		int result;
		try
		{
			TeamUIController teamUIController = (TeamUIController)LuaObject.checkSelf(l);
			string s = teamUIController.m_luaExportHelper.__callBase_ToString();
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

	// Token: 0x06021932 RID: 137522 RVA: 0x00B5F9AC File Offset: 0x00B5DBAC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callDele_EventOnReturn(IntPtr l)
	{
		int result;
		try
		{
			TeamUIController teamUIController = (TeamUIController)LuaObject.checkSelf(l);
			teamUIController.m_luaExportHelper.__callDele_EventOnReturn();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06021933 RID: 137523 RVA: 0x00B5FA00 File Offset: 0x00B5DC00
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __clearDele_EventOnReturn(IntPtr l)
	{
		int result;
		try
		{
			TeamUIController teamUIController = (TeamUIController)LuaObject.checkSelf(l);
			teamUIController.m_luaExportHelper.__clearDele_EventOnReturn();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06021934 RID: 137524 RVA: 0x00B5FA54 File Offset: 0x00B5DC54
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callDele_EventOnShowHelp(IntPtr l)
	{
		int result;
		try
		{
			TeamUIController teamUIController = (TeamUIController)LuaObject.checkSelf(l);
			teamUIController.m_luaExportHelper.__callDele_EventOnShowHelp();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06021935 RID: 137525 RVA: 0x00B5FAA8 File Offset: 0x00B5DCA8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __clearDele_EventOnShowHelp(IntPtr l)
	{
		int result;
		try
		{
			TeamUIController teamUIController = (TeamUIController)LuaObject.checkSelf(l);
			teamUIController.m_luaExportHelper.__clearDele_EventOnShowHelp();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06021936 RID: 137526 RVA: 0x00B5FAFC File Offset: 0x00B5DCFC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callDele_EventOnRefreshTeamRoom(IntPtr l)
	{
		int result;
		try
		{
			TeamUIController teamUIController = (TeamUIController)LuaObject.checkSelf(l);
			teamUIController.m_luaExportHelper.__callDele_EventOnRefreshTeamRoom();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06021937 RID: 137527 RVA: 0x00B5FB50 File Offset: 0x00B5DD50
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int __clearDele_EventOnRefreshTeamRoom(IntPtr l)
	{
		int result;
		try
		{
			TeamUIController teamUIController = (TeamUIController)LuaObject.checkSelf(l);
			teamUIController.m_luaExportHelper.__clearDele_EventOnRefreshTeamRoom();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06021938 RID: 137528 RVA: 0x00B5FBA4 File Offset: 0x00B5DDA4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callDele_EventOnShowCreateTeamRoom(IntPtr l)
	{
		int result;
		try
		{
			TeamUIController teamUIController = (TeamUIController)LuaObject.checkSelf(l);
			teamUIController.m_luaExportHelper.__callDele_EventOnShowCreateTeamRoom();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06021939 RID: 137529 RVA: 0x00B5FBF8 File Offset: 0x00B5DDF8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __clearDele_EventOnShowCreateTeamRoom(IntPtr l)
	{
		int result;
		try
		{
			TeamUIController teamUIController = (TeamUIController)LuaObject.checkSelf(l);
			teamUIController.m_luaExportHelper.__clearDele_EventOnShowCreateTeamRoom();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0602193A RID: 137530 RVA: 0x00B5FC4C File Offset: 0x00B5DE4C
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int __callDele_EventOnAutoMatch(IntPtr l)
	{
		int result;
		try
		{
			TeamUIController teamUIController = (TeamUIController)LuaObject.checkSelf(l);
			teamUIController.m_luaExportHelper.__callDele_EventOnAutoMatch();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0602193B RID: 137531 RVA: 0x00B5FCA0 File Offset: 0x00B5DEA0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __clearDele_EventOnAutoMatch(IntPtr l)
	{
		int result;
		try
		{
			TeamUIController teamUIController = (TeamUIController)LuaObject.checkSelf(l);
			teamUIController.m_luaExportHelper.__clearDele_EventOnAutoMatch();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0602193C RID: 137532 RVA: 0x00B5FCF4 File Offset: 0x00B5DEF4
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int __callDele_EventOnAutoMatchCancel(IntPtr l)
	{
		int result;
		try
		{
			TeamUIController teamUIController = (TeamUIController)LuaObject.checkSelf(l);
			teamUIController.m_luaExportHelper.__callDele_EventOnAutoMatchCancel();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0602193D RID: 137533 RVA: 0x00B5FD48 File Offset: 0x00B5DF48
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int __clearDele_EventOnAutoMatchCancel(IntPtr l)
	{
		int result;
		try
		{
			TeamUIController teamUIController = (TeamUIController)LuaObject.checkSelf(l);
			teamUIController.m_luaExportHelper.__clearDele_EventOnAutoMatchCancel();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0602193E RID: 137534 RVA: 0x00B5FD9C File Offset: 0x00B5DF9C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callDele_EventOnSelectGameFunctionTypeAndLocation(IntPtr l)
	{
		int result;
		try
		{
			TeamUIController teamUIController = (TeamUIController)LuaObject.checkSelf(l);
			GameFunctionType arg;
			LuaObject.checkEnum<GameFunctionType>(l, 2, out arg);
			int arg2;
			LuaObject.checkType(l, 3, out arg2);
			teamUIController.m_luaExportHelper.__callDele_EventOnSelectGameFunctionTypeAndLocation(arg, arg2);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0602193F RID: 137535 RVA: 0x00B5FE08 File Offset: 0x00B5E008
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __clearDele_EventOnSelectGameFunctionTypeAndLocation(IntPtr l)
	{
		int result;
		try
		{
			TeamUIController teamUIController = (TeamUIController)LuaObject.checkSelf(l);
			GameFunctionType arg;
			LuaObject.checkEnum<GameFunctionType>(l, 2, out arg);
			int arg2;
			LuaObject.checkType(l, 3, out arg2);
			teamUIController.m_luaExportHelper.__clearDele_EventOnSelectGameFunctionTypeAndLocation(arg, arg2);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06021940 RID: 137536 RVA: 0x00B5FE74 File Offset: 0x00B5E074
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callDele_EventOnJoinTeamRoom(IntPtr l)
	{
		int result;
		try
		{
			TeamUIController teamUIController = (TeamUIController)LuaObject.checkSelf(l);
			int arg;
			LuaObject.checkType(l, 2, out arg);
			GameFunctionType arg2;
			LuaObject.checkEnum<GameFunctionType>(l, 3, out arg2);
			int arg3;
			LuaObject.checkType(l, 4, out arg3);
			teamUIController.m_luaExportHelper.__callDele_EventOnJoinTeamRoom(arg, arg2, arg3);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06021941 RID: 137537 RVA: 0x00B5FEEC File Offset: 0x00B5E0EC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __clearDele_EventOnJoinTeamRoom(IntPtr l)
	{
		int result;
		try
		{
			TeamUIController teamUIController = (TeamUIController)LuaObject.checkSelf(l);
			int arg;
			LuaObject.checkType(l, 2, out arg);
			GameFunctionType arg2;
			LuaObject.checkEnum<GameFunctionType>(l, 3, out arg2);
			int arg3;
			LuaObject.checkType(l, 4, out arg3);
			teamUIController.m_luaExportHelper.__clearDele_EventOnJoinTeamRoom(arg, arg2, arg3);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06021942 RID: 137538 RVA: 0x00B5FF64 File Offset: 0x00B5E164
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_EventOnReturn(IntPtr l)
	{
		int result;
		try
		{
			TeamUIController teamUIController = (TeamUIController)LuaObject.checkSelf(l);
			Action value;
			int num = LuaObject.checkDelegate<Action>(l, 2, out value);
			if (num != 0)
			{
				if (num == 1)
				{
					teamUIController.EventOnReturn += value;
				}
				else if (num == 2)
				{
					teamUIController.EventOnReturn -= value;
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

	// Token: 0x06021943 RID: 137539 RVA: 0x00B5FFE4 File Offset: 0x00B5E1E4
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_EventOnShowHelp(IntPtr l)
	{
		int result;
		try
		{
			TeamUIController teamUIController = (TeamUIController)LuaObject.checkSelf(l);
			Action value;
			int num = LuaObject.checkDelegate<Action>(l, 2, out value);
			if (num != 0)
			{
				if (num == 1)
				{
					teamUIController.EventOnShowHelp += value;
				}
				else if (num == 2)
				{
					teamUIController.EventOnShowHelp -= value;
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

	// Token: 0x06021944 RID: 137540 RVA: 0x00B60064 File Offset: 0x00B5E264
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_EventOnRefreshTeamRoom(IntPtr l)
	{
		int result;
		try
		{
			TeamUIController teamUIController = (TeamUIController)LuaObject.checkSelf(l);
			Action value;
			int num = LuaObject.checkDelegate<Action>(l, 2, out value);
			if (num != 0)
			{
				if (num == 1)
				{
					teamUIController.EventOnRefreshTeamRoom += value;
				}
				else if (num == 2)
				{
					teamUIController.EventOnRefreshTeamRoom -= value;
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

	// Token: 0x06021945 RID: 137541 RVA: 0x00B600E4 File Offset: 0x00B5E2E4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_EventOnShowCreateTeamRoom(IntPtr l)
	{
		int result;
		try
		{
			TeamUIController teamUIController = (TeamUIController)LuaObject.checkSelf(l);
			Action value;
			int num = LuaObject.checkDelegate<Action>(l, 2, out value);
			if (num != 0)
			{
				if (num == 1)
				{
					teamUIController.EventOnShowCreateTeamRoom += value;
				}
				else if (num == 2)
				{
					teamUIController.EventOnShowCreateTeamRoom -= value;
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

	// Token: 0x06021946 RID: 137542 RVA: 0x00B60164 File Offset: 0x00B5E364
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_EventOnAutoMatch(IntPtr l)
	{
		int result;
		try
		{
			TeamUIController teamUIController = (TeamUIController)LuaObject.checkSelf(l);
			Action value;
			int num = LuaObject.checkDelegate<Action>(l, 2, out value);
			if (num != 0)
			{
				if (num == 1)
				{
					teamUIController.EventOnAutoMatch += value;
				}
				else if (num == 2)
				{
					teamUIController.EventOnAutoMatch -= value;
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

	// Token: 0x06021947 RID: 137543 RVA: 0x00B601E4 File Offset: 0x00B5E3E4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_EventOnAutoMatchCancel(IntPtr l)
	{
		int result;
		try
		{
			TeamUIController teamUIController = (TeamUIController)LuaObject.checkSelf(l);
			Action value;
			int num = LuaObject.checkDelegate<Action>(l, 2, out value);
			if (num != 0)
			{
				if (num == 1)
				{
					teamUIController.EventOnAutoMatchCancel += value;
				}
				else if (num == 2)
				{
					teamUIController.EventOnAutoMatchCancel -= value;
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

	// Token: 0x06021948 RID: 137544 RVA: 0x00B60264 File Offset: 0x00B5E464
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_EventOnSelectGameFunctionTypeAndLocation(IntPtr l)
	{
		int result;
		try
		{
			TeamUIController teamUIController = (TeamUIController)LuaObject.checkSelf(l);
			Action<GameFunctionType, int> value;
			int num = LuaObject.checkDelegate<Action<GameFunctionType, int>>(l, 2, out value);
			if (num != 0)
			{
				if (num == 1)
				{
					teamUIController.EventOnSelectGameFunctionTypeAndLocation += value;
				}
				else if (num == 2)
				{
					teamUIController.EventOnSelectGameFunctionTypeAndLocation -= value;
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

	// Token: 0x06021949 RID: 137545 RVA: 0x00B602E4 File Offset: 0x00B5E4E4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_EventOnJoinTeamRoom(IntPtr l)
	{
		int result;
		try
		{
			TeamUIController teamUIController = (TeamUIController)LuaObject.checkSelf(l);
			Action<int, GameFunctionType, int> value;
			int num = LuaObject.checkDelegate<Action<int, GameFunctionType, int>>(l, 2, out value);
			if (num != 0)
			{
				if (num == 1)
				{
					teamUIController.EventOnJoinTeamRoom += value;
				}
				else if (num == 2)
				{
					teamUIController.EventOnJoinTeamRoom -= value;
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

	// Token: 0x0602194A RID: 137546 RVA: 0x00B60364 File Offset: 0x00B5E564
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_uiStateController(IntPtr l)
	{
		int result;
		try
		{
			TeamUIController teamUIController = (TeamUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, teamUIController.m_luaExportHelper.m_uiStateController);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0602194B RID: 137547 RVA: 0x00B603BC File Offset: 0x00B5E5BC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_uiStateController(IntPtr l)
	{
		int result;
		try
		{
			TeamUIController teamUIController = (TeamUIController)LuaObject.checkSelf(l);
			CommonUIStateController uiStateController;
			LuaObject.checkType<CommonUIStateController>(l, 2, out uiStateController);
			teamUIController.m_luaExportHelper.m_uiStateController = uiStateController;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0602194C RID: 137548 RVA: 0x00B60418 File Offset: 0x00B5E618
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_returnButton(IntPtr l)
	{
		int result;
		try
		{
			TeamUIController teamUIController = (TeamUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, teamUIController.m_luaExportHelper.m_returnButton);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0602194D RID: 137549 RVA: 0x00B60470 File Offset: 0x00B5E670
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_returnButton(IntPtr l)
	{
		int result;
		try
		{
			TeamUIController teamUIController = (TeamUIController)LuaObject.checkSelf(l);
			Button returnButton;
			LuaObject.checkType<Button>(l, 2, out returnButton);
			teamUIController.m_luaExportHelper.m_returnButton = returnButton;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0602194E RID: 137550 RVA: 0x00B604CC File Offset: 0x00B5E6CC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_helpButton(IntPtr l)
	{
		int result;
		try
		{
			TeamUIController teamUIController = (TeamUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, teamUIController.m_luaExportHelper.m_helpButton);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0602194F RID: 137551 RVA: 0x00B60524 File Offset: 0x00B5E724
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_helpButton(IntPtr l)
	{
		int result;
		try
		{
			TeamUIController teamUIController = (TeamUIController)LuaObject.checkSelf(l);
			Button helpButton;
			LuaObject.checkType<Button>(l, 2, out helpButton);
			teamUIController.m_luaExportHelper.m_helpButton = helpButton;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06021950 RID: 137552 RVA: 0x00B60580 File Offset: 0x00B5E780
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_gameFunctionTypeListScrollRect(IntPtr l)
	{
		int result;
		try
		{
			TeamUIController teamUIController = (TeamUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, teamUIController.m_luaExportHelper.m_gameFunctionTypeListScrollRect);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06021951 RID: 137553 RVA: 0x00B605D8 File Offset: 0x00B5E7D8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_gameFunctionTypeListScrollRect(IntPtr l)
	{
		int result;
		try
		{
			TeamUIController teamUIController = (TeamUIController)LuaObject.checkSelf(l);
			ScrollRect gameFunctionTypeListScrollRect;
			LuaObject.checkType<ScrollRect>(l, 2, out gameFunctionTypeListScrollRect);
			teamUIController.m_luaExportHelper.m_gameFunctionTypeListScrollRect = gameFunctionTypeListScrollRect;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06021952 RID: 137554 RVA: 0x00B60634 File Offset: 0x00B5E834
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_gameFunctionTypeListDisableButton(IntPtr l)
	{
		int result;
		try
		{
			TeamUIController teamUIController = (TeamUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, teamUIController.m_luaExportHelper.m_gameFunctionTypeListDisableButton);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06021953 RID: 137555 RVA: 0x00B6068C File Offset: 0x00B5E88C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_gameFunctionTypeListDisableButton(IntPtr l)
	{
		int result;
		try
		{
			TeamUIController teamUIController = (TeamUIController)LuaObject.checkSelf(l);
			Button gameFunctionTypeListDisableButton;
			LuaObject.checkType<Button>(l, 2, out gameFunctionTypeListDisableButton);
			teamUIController.m_luaExportHelper.m_gameFunctionTypeListDisableButton = gameFunctionTypeListDisableButton;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06021954 RID: 137556 RVA: 0x00B606E8 File Offset: 0x00B5E8E8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_locationListUiStateController(IntPtr l)
	{
		int result;
		try
		{
			TeamUIController teamUIController = (TeamUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, teamUIController.m_luaExportHelper.m_locationListUiStateController);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06021955 RID: 137557 RVA: 0x00B60740 File Offset: 0x00B5E940
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_locationListUiStateController(IntPtr l)
	{
		int result;
		try
		{
			TeamUIController teamUIController = (TeamUIController)LuaObject.checkSelf(l);
			CommonUIStateController locationListUiStateController;
			LuaObject.checkType<CommonUIStateController>(l, 2, out locationListUiStateController);
			teamUIController.m_luaExportHelper.m_locationListUiStateController = locationListUiStateController;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06021956 RID: 137558 RVA: 0x00B6079C File Offset: 0x00B5E99C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_locationListScrollRect(IntPtr l)
	{
		int result;
		try
		{
			TeamUIController teamUIController = (TeamUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, teamUIController.m_luaExportHelper.m_locationListScrollRect);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06021957 RID: 137559 RVA: 0x00B607F4 File Offset: 0x00B5E9F4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_locationListScrollRect(IntPtr l)
	{
		int result;
		try
		{
			TeamUIController teamUIController = (TeamUIController)LuaObject.checkSelf(l);
			ScrollRect locationListScrollRect;
			LuaObject.checkType<ScrollRect>(l, 2, out locationListScrollRect);
			teamUIController.m_luaExportHelper.m_locationListScrollRect = locationListScrollRect;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06021958 RID: 137560 RVA: 0x00B60850 File Offset: 0x00B5EA50
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_locationListCloseButton(IntPtr l)
	{
		int result;
		try
		{
			TeamUIController teamUIController = (TeamUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, teamUIController.m_luaExportHelper.m_locationListCloseButton);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06021959 RID: 137561 RVA: 0x00B608A8 File Offset: 0x00B5EAA8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_locationListCloseButton(IntPtr l)
	{
		int result;
		try
		{
			TeamUIController teamUIController = (TeamUIController)LuaObject.checkSelf(l);
			Button locationListCloseButton;
			LuaObject.checkType<Button>(l, 2, out locationListCloseButton);
			teamUIController.m_luaExportHelper.m_locationListCloseButton = locationListCloseButton;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0602195A RID: 137562 RVA: 0x00B60904 File Offset: 0x00B5EB04
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_locationListDisableButton(IntPtr l)
	{
		int result;
		try
		{
			TeamUIController teamUIController = (TeamUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, teamUIController.m_luaExportHelper.m_locationListDisableButton);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0602195B RID: 137563 RVA: 0x00B6095C File Offset: 0x00B5EB5C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_locationListDisableButton(IntPtr l)
	{
		int result;
		try
		{
			TeamUIController teamUIController = (TeamUIController)LuaObject.checkSelf(l);
			Button locationListDisableButton;
			LuaObject.checkType<Button>(l, 2, out locationListDisableButton);
			teamUIController.m_luaExportHelper.m_locationListDisableButton = locationListDisableButton;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0602195C RID: 137564 RVA: 0x00B609B8 File Offset: 0x00B5EBB8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_titleText(IntPtr l)
	{
		int result;
		try
		{
			TeamUIController teamUIController = (TeamUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, teamUIController.m_luaExportHelper.m_titleText);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0602195D RID: 137565 RVA: 0x00B60A10 File Offset: 0x00B5EC10
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_titleText(IntPtr l)
	{
		int result;
		try
		{
			TeamUIController teamUIController = (TeamUIController)LuaObject.checkSelf(l);
			Text titleText;
			LuaObject.checkType<Text>(l, 2, out titleText);
			teamUIController.m_luaExportHelper.m_titleText = titleText;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0602195E RID: 137566 RVA: 0x00B60A6C File Offset: 0x00B5EC6C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_roomListScrollRect(IntPtr l)
	{
		int result;
		try
		{
			TeamUIController teamUIController = (TeamUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, teamUIController.m_luaExportHelper.m_roomListScrollRect);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0602195F RID: 137567 RVA: 0x00B60AC4 File Offset: 0x00B5ECC4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_roomListScrollRect(IntPtr l)
	{
		int result;
		try
		{
			TeamUIController teamUIController = (TeamUIController)LuaObject.checkSelf(l);
			ScrollRect roomListScrollRect;
			LuaObject.checkType<ScrollRect>(l, 2, out roomListScrollRect);
			teamUIController.m_luaExportHelper.m_roomListScrollRect = roomListScrollRect;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06021960 RID: 137568 RVA: 0x00B60B20 File Offset: 0x00B5ED20
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_createTeamRoomButton(IntPtr l)
	{
		int result;
		try
		{
			TeamUIController teamUIController = (TeamUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, teamUIController.m_luaExportHelper.m_createTeamRoomButton);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06021961 RID: 137569 RVA: 0x00B60B78 File Offset: 0x00B5ED78
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_createTeamRoomButton(IntPtr l)
	{
		int result;
		try
		{
			TeamUIController teamUIController = (TeamUIController)LuaObject.checkSelf(l);
			Button createTeamRoomButton;
			LuaObject.checkType<Button>(l, 2, out createTeamRoomButton);
			teamUIController.m_luaExportHelper.m_createTeamRoomButton = createTeamRoomButton;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06021962 RID: 137570 RVA: 0x00B60BD4 File Offset: 0x00B5EDD4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_refreshTeamRoomButton(IntPtr l)
	{
		int result;
		try
		{
			TeamUIController teamUIController = (TeamUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, teamUIController.m_luaExportHelper.m_refreshTeamRoomButton);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06021963 RID: 137571 RVA: 0x00B60C2C File Offset: 0x00B5EE2C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_refreshTeamRoomButton(IntPtr l)
	{
		int result;
		try
		{
			TeamUIController teamUIController = (TeamUIController)LuaObject.checkSelf(l);
			Button refreshTeamRoomButton;
			LuaObject.checkType<Button>(l, 2, out refreshTeamRoomButton);
			teamUIController.m_luaExportHelper.m_refreshTeamRoomButton = refreshTeamRoomButton;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06021964 RID: 137572 RVA: 0x00B60C88 File Offset: 0x00B5EE88
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_autoMatchButton(IntPtr l)
	{
		int result;
		try
		{
			TeamUIController teamUIController = (TeamUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, teamUIController.m_luaExportHelper.m_autoMatchButton);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06021965 RID: 137573 RVA: 0x00B60CE0 File Offset: 0x00B5EEE0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_autoMatchButton(IntPtr l)
	{
		int result;
		try
		{
			TeamUIController teamUIController = (TeamUIController)LuaObject.checkSelf(l);
			Button autoMatchButton;
			LuaObject.checkType<Button>(l, 2, out autoMatchButton);
			teamUIController.m_luaExportHelper.m_autoMatchButton = autoMatchButton;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06021966 RID: 137574 RVA: 0x00B60D3C File Offset: 0x00B5EF3C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_noTeamRoomUIStateController(IntPtr l)
	{
		int result;
		try
		{
			TeamUIController teamUIController = (TeamUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, teamUIController.m_luaExportHelper.m_noTeamRoomUIStateController);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06021967 RID: 137575 RVA: 0x00B60D94 File Offset: 0x00B5EF94
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_noTeamRoomUIStateController(IntPtr l)
	{
		int result;
		try
		{
			TeamUIController teamUIController = (TeamUIController)LuaObject.checkSelf(l);
			CommonUIStateController noTeamRoomUIStateController;
			LuaObject.checkType<CommonUIStateController>(l, 2, out noTeamRoomUIStateController);
			teamUIController.m_luaExportHelper.m_noTeamRoomUIStateController = noTeamRoomUIStateController;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06021968 RID: 137576 RVA: 0x00B60DF0 File Offset: 0x00B5EFF0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_autoMatchCancelButton(IntPtr l)
	{
		int result;
		try
		{
			TeamUIController teamUIController = (TeamUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, teamUIController.m_luaExportHelper.m_autoMatchCancelButton);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06021969 RID: 137577 RVA: 0x00B60E48 File Offset: 0x00B5F048
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_autoMatchCancelButton(IntPtr l)
	{
		int result;
		try
		{
			TeamUIController teamUIController = (TeamUIController)LuaObject.checkSelf(l);
			Button autoMatchCancelButton;
			LuaObject.checkType<Button>(l, 2, out autoMatchCancelButton);
			teamUIController.m_luaExportHelper.m_autoMatchCancelButton = autoMatchCancelButton;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0602196A RID: 137578 RVA: 0x00B60EA4 File Offset: 0x00B5F0A4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_autoMatchWaitCountText(IntPtr l)
	{
		int result;
		try
		{
			TeamUIController teamUIController = (TeamUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, teamUIController.m_luaExportHelper.m_autoMatchWaitCountText);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0602196B RID: 137579 RVA: 0x00B60EFC File Offset: 0x00B5F0FC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_autoMatchWaitCountText(IntPtr l)
	{
		int result;
		try
		{
			TeamUIController teamUIController = (TeamUIController)LuaObject.checkSelf(l);
			Text autoMatchWaitCountText;
			LuaObject.checkType<Text>(l, 2, out autoMatchWaitCountText);
			teamUIController.m_luaExportHelper.m_autoMatchWaitCountText = autoMatchWaitCountText;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0602196C RID: 137580 RVA: 0x00B60F58 File Offset: 0x00B5F158
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_prefabsGameObject(IntPtr l)
	{
		int result;
		try
		{
			TeamUIController teamUIController = (TeamUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, teamUIController.m_luaExportHelper.m_prefabsGameObject);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0602196D RID: 137581 RVA: 0x00B60FB0 File Offset: 0x00B5F1B0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_prefabsGameObject(IntPtr l)
	{
		int result;
		try
		{
			TeamUIController teamUIController = (TeamUIController)LuaObject.checkSelf(l);
			GameObject prefabsGameObject;
			LuaObject.checkType<GameObject>(l, 2, out prefabsGameObject);
			teamUIController.m_luaExportHelper.m_prefabsGameObject = prefabsGameObject;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0602196E RID: 137582 RVA: 0x00B6100C File Offset: 0x00B5F20C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_gameFunctionTypeListItemPrefab(IntPtr l)
	{
		int result;
		try
		{
			TeamUIController teamUIController = (TeamUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, teamUIController.m_luaExportHelper.m_gameFunctionTypeListItemPrefab);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0602196F RID: 137583 RVA: 0x00B61064 File Offset: 0x00B5F264
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_gameFunctionTypeListItemPrefab(IntPtr l)
	{
		int result;
		try
		{
			TeamUIController teamUIController = (TeamUIController)LuaObject.checkSelf(l);
			GameObject gameFunctionTypeListItemPrefab;
			LuaObject.checkType<GameObject>(l, 2, out gameFunctionTypeListItemPrefab);
			teamUIController.m_luaExportHelper.m_gameFunctionTypeListItemPrefab = gameFunctionTypeListItemPrefab;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06021970 RID: 137584 RVA: 0x00B610C0 File Offset: 0x00B5F2C0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_locationListItemPrefab(IntPtr l)
	{
		int result;
		try
		{
			TeamUIController teamUIController = (TeamUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, teamUIController.m_luaExportHelper.m_locationListItemPrefab);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06021971 RID: 137585 RVA: 0x00B61118 File Offset: 0x00B5F318
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_locationListItemPrefab(IntPtr l)
	{
		int result;
		try
		{
			TeamUIController teamUIController = (TeamUIController)LuaObject.checkSelf(l);
			GameObject locationListItemPrefab;
			LuaObject.checkType<GameObject>(l, 2, out locationListItemPrefab);
			teamUIController.m_luaExportHelper.m_locationListItemPrefab = locationListItemPrefab;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06021972 RID: 137586 RVA: 0x00B61174 File Offset: 0x00B5F374
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_roomListItemPrefab(IntPtr l)
	{
		int result;
		try
		{
			TeamUIController teamUIController = (TeamUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, teamUIController.m_luaExportHelper.m_roomListItemPrefab);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06021973 RID: 137587 RVA: 0x00B611CC File Offset: 0x00B5F3CC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_roomListItemPrefab(IntPtr l)
	{
		int result;
		try
		{
			TeamUIController teamUIController = (TeamUIController)LuaObject.checkSelf(l);
			GameObject roomListItemPrefab;
			LuaObject.checkType<GameObject>(l, 2, out roomListItemPrefab);
			teamUIController.m_luaExportHelper.m_roomListItemPrefab = roomListItemPrefab;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06021974 RID: 137588 RVA: 0x00B61228 File Offset: 0x00B5F428
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_gameFunctionTypeListItems(IntPtr l)
	{
		int result;
		try
		{
			TeamUIController teamUIController = (TeamUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, teamUIController.m_luaExportHelper.m_gameFunctionTypeListItems);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06021975 RID: 137589 RVA: 0x00B61280 File Offset: 0x00B5F480
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_gameFunctionTypeListItems(IntPtr l)
	{
		int result;
		try
		{
			TeamUIController teamUIController = (TeamUIController)LuaObject.checkSelf(l);
			List<TeamGameFunctionTypeListItemUIController> gameFunctionTypeListItems;
			LuaObject.checkType<List<TeamGameFunctionTypeListItemUIController>>(l, 2, out gameFunctionTypeListItems);
			teamUIController.m_luaExportHelper.m_gameFunctionTypeListItems = gameFunctionTypeListItems;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06021976 RID: 137590 RVA: 0x00B612DC File Offset: 0x00B5F4DC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_locationListItems(IntPtr l)
	{
		int result;
		try
		{
			TeamUIController teamUIController = (TeamUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, teamUIController.m_luaExportHelper.m_locationListItems);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06021977 RID: 137591 RVA: 0x00B61334 File Offset: 0x00B5F534
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_locationListItems(IntPtr l)
	{
		int result;
		try
		{
			TeamUIController teamUIController = (TeamUIController)LuaObject.checkSelf(l);
			List<TeamLocationListItemUIController> locationListItems;
			LuaObject.checkType<List<TeamLocationListItemUIController>>(l, 2, out locationListItems);
			teamUIController.m_luaExportHelper.m_locationListItems = locationListItems;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06021978 RID: 137592 RVA: 0x00B61390 File Offset: 0x00B5F590
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_roomListItems(IntPtr l)
	{
		int result;
		try
		{
			TeamUIController teamUIController = (TeamUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, teamUIController.m_luaExportHelper.m_roomListItems);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06021979 RID: 137593 RVA: 0x00B613E8 File Offset: 0x00B5F5E8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_roomListItems(IntPtr l)
	{
		int result;
		try
		{
			TeamUIController teamUIController = (TeamUIController)LuaObject.checkSelf(l);
			List<TeamRoomListItemUIController> roomListItems;
			LuaObject.checkType<List<TeamRoomListItemUIController>>(l, 2, out roomListItems);
			teamUIController.m_luaExportHelper.m_roomListItems = roomListItems;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0602197A RID: 137594 RVA: 0x00B61444 File Offset: 0x00B5F644
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_isIgnoreFireSelectEvent(IntPtr l)
	{
		int result;
		try
		{
			TeamUIController teamUIController = (TeamUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, teamUIController.m_luaExportHelper.m_isIgnoreFireSelectEvent);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0602197B RID: 137595 RVA: 0x00B6149C File Offset: 0x00B5F69C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_isIgnoreFireSelectEvent(IntPtr l)
	{
		int result;
		try
		{
			TeamUIController teamUIController = (TeamUIController)LuaObject.checkSelf(l);
			bool isIgnoreFireSelectEvent;
			LuaObject.checkType(l, 2, out isIgnoreFireSelectEvent);
			teamUIController.m_luaExportHelper.m_isIgnoreFireSelectEvent = isIgnoreFireSelectEvent;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0602197C RID: 137596 RVA: 0x00B614F8 File Offset: 0x00B5F6F8
	[Preserve]
	public static void reg(IntPtr l)
	{
		LuaObject.getTypeTable(l, "BlackJack.ProjectL.UI.TeamUIController");
		if (Lua_BlackJack_ProjectL_UI_TeamUIController.<>f__mg$cache0 == null)
		{
			Lua_BlackJack_ProjectL_UI_TeamUIController.<>f__mg$cache0 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_TeamUIController.Open);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_TeamUIController.<>f__mg$cache0);
		if (Lua_BlackJack_ProjectL_UI_TeamUIController.<>f__mg$cache1 == null)
		{
			Lua_BlackJack_ProjectL_UI_TeamUIController.<>f__mg$cache1 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_TeamUIController.SelectGameFunctionTypeAndLocation);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_TeamUIController.<>f__mg$cache1);
		if (Lua_BlackJack_ProjectL_UI_TeamUIController.<>f__mg$cache2 == null)
		{
			Lua_BlackJack_ProjectL_UI_TeamUIController.<>f__mg$cache2 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_TeamUIController.SetTeamRooms);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_TeamUIController.<>f__mg$cache2);
		if (Lua_BlackJack_ProjectL_UI_TeamUIController.<>f__mg$cache3 == null)
		{
			Lua_BlackJack_ProjectL_UI_TeamUIController.<>f__mg$cache3 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_TeamUIController.SetAutoMatchMode);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_TeamUIController.<>f__mg$cache3);
		if (Lua_BlackJack_ProjectL_UI_TeamUIController.<>f__mg$cache4 == null)
		{
			Lua_BlackJack_ProjectL_UI_TeamUIController.<>f__mg$cache4 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_TeamUIController.SetAutoMatchWaitCount);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_TeamUIController.<>f__mg$cache4);
		if (Lua_BlackJack_ProjectL_UI_TeamUIController.<>f__mg$cache5 == null)
		{
			Lua_BlackJack_ProjectL_UI_TeamUIController.<>f__mg$cache5 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_TeamUIController.IsAutoMatching);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_TeamUIController.<>f__mg$cache5);
		if (Lua_BlackJack_ProjectL_UI_TeamUIController.<>f__mg$cache6 == null)
		{
			Lua_BlackJack_ProjectL_UI_TeamUIController.<>f__mg$cache6 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_TeamUIController.GetGameFunctionType);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_TeamUIController.<>f__mg$cache6);
		if (Lua_BlackJack_ProjectL_UI_TeamUIController.<>f__mg$cache7 == null)
		{
			Lua_BlackJack_ProjectL_UI_TeamUIController.<>f__mg$cache7 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_TeamUIController.GetChapterId);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_TeamUIController.<>f__mg$cache7);
		if (Lua_BlackJack_ProjectL_UI_TeamUIController.<>f__mg$cache8 == null)
		{
			Lua_BlackJack_ProjectL_UI_TeamUIController.<>f__mg$cache8 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_TeamUIController.GetLocationId);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_TeamUIController.<>f__mg$cache8);
		if (Lua_BlackJack_ProjectL_UI_TeamUIController.<>f__mg$cache9 == null)
		{
			Lua_BlackJack_ProjectL_UI_TeamUIController.<>f__mg$cache9 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_TeamUIController.GetGameFunctionName_s);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_TeamUIController.<>f__mg$cache9);
		if (Lua_BlackJack_ProjectL_UI_TeamUIController.<>f__mg$cacheA == null)
		{
			Lua_BlackJack_ProjectL_UI_TeamUIController.<>f__mg$cacheA = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_TeamUIController.GetLocationName_s);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_TeamUIController.<>f__mg$cacheA);
		if (Lua_BlackJack_ProjectL_UI_TeamUIController.<>f__mg$cacheB == null)
		{
			Lua_BlackJack_ProjectL_UI_TeamUIController.<>f__mg$cacheB = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_TeamUIController.GetEnergy_s);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_TeamUIController.<>f__mg$cacheB);
		if (Lua_BlackJack_ProjectL_UI_TeamUIController.<>f__mg$cacheC == null)
		{
			Lua_BlackJack_ProjectL_UI_TeamUIController.<>f__mg$cacheC = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_TeamUIController.OnBindFiledsCompleted);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_TeamUIController.<>f__mg$cacheC);
		if (Lua_BlackJack_ProjectL_UI_TeamUIController.<>f__mg$cacheD == null)
		{
			Lua_BlackJack_ProjectL_UI_TeamUIController.<>f__mg$cacheD = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_TeamUIController.AddGameFunctionTypeListItems);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_TeamUIController.<>f__mg$cacheD);
		if (Lua_BlackJack_ProjectL_UI_TeamUIController.<>f__mg$cacheE == null)
		{
			Lua_BlackJack_ProjectL_UI_TeamUIController.<>f__mg$cacheE = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_TeamUIController.ClearGameFunctionTypeListItems);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_TeamUIController.<>f__mg$cacheE);
		if (Lua_BlackJack_ProjectL_UI_TeamUIController.<>f__mg$cacheF == null)
		{
			Lua_BlackJack_ProjectL_UI_TeamUIController.<>f__mg$cacheF = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_TeamUIController.AddGameFunctionTypeListItem);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_TeamUIController.<>f__mg$cacheF);
		if (Lua_BlackJack_ProjectL_UI_TeamUIController.<>f__mg$cache10 == null)
		{
			Lua_BlackJack_ProjectL_UI_TeamUIController.<>f__mg$cache10 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_TeamUIController.AddLocationListItems);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_TeamUIController.<>f__mg$cache10);
		if (Lua_BlackJack_ProjectL_UI_TeamUIController.<>f__mg$cache11 == null)
		{
			Lua_BlackJack_ProjectL_UI_TeamUIController.<>f__mg$cache11 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_TeamUIController.ClearLocationListItems);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_TeamUIController.<>f__mg$cache11);
		if (Lua_BlackJack_ProjectL_UI_TeamUIController.<>f__mg$cache12 == null)
		{
			Lua_BlackJack_ProjectL_UI_TeamUIController.<>f__mg$cache12 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_TeamUIController.AddLocationListItem);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_TeamUIController.<>f__mg$cache12);
		if (Lua_BlackJack_ProjectL_UI_TeamUIController.<>f__mg$cache13 == null)
		{
			Lua_BlackJack_ProjectL_UI_TeamUIController.<>f__mg$cache13 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_TeamUIController.AddTeamRoomListItem);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_TeamUIController.<>f__mg$cache13);
		if (Lua_BlackJack_ProjectL_UI_TeamUIController.<>f__mg$cache14 == null)
		{
			Lua_BlackJack_ProjectL_UI_TeamUIController.<>f__mg$cache14 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_TeamUIController.ClearTeamRoomListItems);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_TeamUIController.<>f__mg$cache14);
		if (Lua_BlackJack_ProjectL_UI_TeamUIController.<>f__mg$cache15 == null)
		{
			Lua_BlackJack_ProjectL_UI_TeamUIController.<>f__mg$cache15 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_TeamUIController.UpdateTitle);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_TeamUIController.<>f__mg$cache15);
		if (Lua_BlackJack_ProjectL_UI_TeamUIController.<>f__mg$cache16 == null)
		{
			Lua_BlackJack_ProjectL_UI_TeamUIController.<>f__mg$cache16 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_TeamUIController.OnReturnButtonClick);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_TeamUIController.<>f__mg$cache16);
		if (Lua_BlackJack_ProjectL_UI_TeamUIController.<>f__mg$cache17 == null)
		{
			Lua_BlackJack_ProjectL_UI_TeamUIController.<>f__mg$cache17 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_TeamUIController.OnHelpButtonClick);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_TeamUIController.<>f__mg$cache17);
		if (Lua_BlackJack_ProjectL_UI_TeamUIController.<>f__mg$cache18 == null)
		{
			Lua_BlackJack_ProjectL_UI_TeamUIController.<>f__mg$cache18 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_TeamUIController.OnRefreshTeamRoomButtonClick);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_TeamUIController.<>f__mg$cache18);
		if (Lua_BlackJack_ProjectL_UI_TeamUIController.<>f__mg$cache19 == null)
		{
			Lua_BlackJack_ProjectL_UI_TeamUIController.<>f__mg$cache19 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_TeamUIController.OnShowCreateTeamRoomButtonClick);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_TeamUIController.<>f__mg$cache19);
		if (Lua_BlackJack_ProjectL_UI_TeamUIController.<>f__mg$cache1A == null)
		{
			Lua_BlackJack_ProjectL_UI_TeamUIController.<>f__mg$cache1A = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_TeamUIController.OnAutoMatchButtonClick);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_TeamUIController.<>f__mg$cache1A);
		if (Lua_BlackJack_ProjectL_UI_TeamUIController.<>f__mg$cache1B == null)
		{
			Lua_BlackJack_ProjectL_UI_TeamUIController.<>f__mg$cache1B = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_TeamUIController.OnAutoMatchCancelButtonClick);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_TeamUIController.<>f__mg$cache1B);
		if (Lua_BlackJack_ProjectL_UI_TeamUIController.<>f__mg$cache1C == null)
		{
			Lua_BlackJack_ProjectL_UI_TeamUIController.<>f__mg$cache1C = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_TeamUIController.OnLocationListCloseButtonClick);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_TeamUIController.<>f__mg$cache1C);
		if (Lua_BlackJack_ProjectL_UI_TeamUIController.<>f__mg$cache1D == null)
		{
			Lua_BlackJack_ProjectL_UI_TeamUIController.<>f__mg$cache1D = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_TeamUIController.TeamGameFunctionTypeListItem_OnToggleValueChanged);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_TeamUIController.<>f__mg$cache1D);
		if (Lua_BlackJack_ProjectL_UI_TeamUIController.<>f__mg$cache1E == null)
		{
			Lua_BlackJack_ProjectL_UI_TeamUIController.<>f__mg$cache1E = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_TeamUIController.GetSelectedGameFunctionTypeListItem);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_TeamUIController.<>f__mg$cache1E);
		if (Lua_BlackJack_ProjectL_UI_TeamUIController.<>f__mg$cache1F == null)
		{
			Lua_BlackJack_ProjectL_UI_TeamUIController.<>f__mg$cache1F = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_TeamUIController.GetSelectedLocationListItem);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_TeamUIController.<>f__mg$cache1F);
		if (Lua_BlackJack_ProjectL_UI_TeamUIController.<>f__mg$cache20 == null)
		{
			Lua_BlackJack_ProjectL_UI_TeamUIController.<>f__mg$cache20 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_TeamUIController.TeamLocationListItem_OnToggleValueChanged);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_TeamUIController.<>f__mg$cache20);
		if (Lua_BlackJack_ProjectL_UI_TeamUIController.<>f__mg$cache21 == null)
		{
			Lua_BlackJack_ProjectL_UI_TeamUIController.<>f__mg$cache21 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_TeamUIController.TeamRoomListItem_OnJoinButtonClick);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_TeamUIController.<>f__mg$cache21);
		if (Lua_BlackJack_ProjectL_UI_TeamUIController.<>f__mg$cache22 == null)
		{
			Lua_BlackJack_ProjectL_UI_TeamUIController.<>f__mg$cache22 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_TeamUIController.__callBase_Initlize);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_TeamUIController.<>f__mg$cache22);
		if (Lua_BlackJack_ProjectL_UI_TeamUIController.<>f__mg$cache23 == null)
		{
			Lua_BlackJack_ProjectL_UI_TeamUIController.<>f__mg$cache23 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_TeamUIController.__callBase_BindFields);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_TeamUIController.<>f__mg$cache23);
		if (Lua_BlackJack_ProjectL_UI_TeamUIController.<>f__mg$cache24 == null)
		{
			Lua_BlackJack_ProjectL_UI_TeamUIController.<>f__mg$cache24 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_TeamUIController.__callBase_OnBindFiledsCompleted);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_TeamUIController.<>f__mg$cache24);
		if (Lua_BlackJack_ProjectL_UI_TeamUIController.<>f__mg$cache25 == null)
		{
			Lua_BlackJack_ProjectL_UI_TeamUIController.<>f__mg$cache25 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_TeamUIController.__callBase_BindFieldImpl);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_TeamUIController.<>f__mg$cache25);
		if (Lua_BlackJack_ProjectL_UI_TeamUIController.<>f__mg$cache26 == null)
		{
			Lua_BlackJack_ProjectL_UI_TeamUIController.<>f__mg$cache26 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_TeamUIController.__callBase_Clear);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_TeamUIController.<>f__mg$cache26);
		if (Lua_BlackJack_ProjectL_UI_TeamUIController.<>f__mg$cache27 == null)
		{
			Lua_BlackJack_ProjectL_UI_TeamUIController.<>f__mg$cache27 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_TeamUIController.__callBase_OnButtonClick);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_TeamUIController.<>f__mg$cache27);
		if (Lua_BlackJack_ProjectL_UI_TeamUIController.<>f__mg$cache28 == null)
		{
			Lua_BlackJack_ProjectL_UI_TeamUIController.<>f__mg$cache28 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_TeamUIController.__callBase_SetButtonClickListener);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_TeamUIController.<>f__mg$cache28);
		if (Lua_BlackJack_ProjectL_UI_TeamUIController.<>f__mg$cache29 == null)
		{
			Lua_BlackJack_ProjectL_UI_TeamUIController.<>f__mg$cache29 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_TeamUIController.__callBase_SetButtonDoubleClickListener);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_TeamUIController.<>f__mg$cache29);
		if (Lua_BlackJack_ProjectL_UI_TeamUIController.<>f__mg$cache2A == null)
		{
			Lua_BlackJack_ProjectL_UI_TeamUIController.<>f__mg$cache2A = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_TeamUIController.__callBase_SetButtonLongPressStartListener);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_TeamUIController.<>f__mg$cache2A);
		if (Lua_BlackJack_ProjectL_UI_TeamUIController.<>f__mg$cache2B == null)
		{
			Lua_BlackJack_ProjectL_UI_TeamUIController.<>f__mg$cache2B = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_TeamUIController.__callBase_SetButtonLongPressingListener);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_TeamUIController.<>f__mg$cache2B);
		if (Lua_BlackJack_ProjectL_UI_TeamUIController.<>f__mg$cache2C == null)
		{
			Lua_BlackJack_ProjectL_UI_TeamUIController.<>f__mg$cache2C = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_TeamUIController.__callBase_SetButtonLongPressEndListener);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_TeamUIController.<>f__mg$cache2C);
		if (Lua_BlackJack_ProjectL_UI_TeamUIController.<>f__mg$cache2D == null)
		{
			Lua_BlackJack_ProjectL_UI_TeamUIController.<>f__mg$cache2D = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_TeamUIController.__callBase_SetToggleValueChangedListener);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_TeamUIController.<>f__mg$cache2D);
		if (Lua_BlackJack_ProjectL_UI_TeamUIController.<>f__mg$cache2E == null)
		{
			Lua_BlackJack_ProjectL_UI_TeamUIController.<>f__mg$cache2E = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_TeamUIController.__callBase_ToString);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_TeamUIController.<>f__mg$cache2E);
		if (Lua_BlackJack_ProjectL_UI_TeamUIController.<>f__mg$cache2F == null)
		{
			Lua_BlackJack_ProjectL_UI_TeamUIController.<>f__mg$cache2F = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_TeamUIController.__callDele_EventOnReturn);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_TeamUIController.<>f__mg$cache2F);
		if (Lua_BlackJack_ProjectL_UI_TeamUIController.<>f__mg$cache30 == null)
		{
			Lua_BlackJack_ProjectL_UI_TeamUIController.<>f__mg$cache30 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_TeamUIController.__clearDele_EventOnReturn);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_TeamUIController.<>f__mg$cache30);
		if (Lua_BlackJack_ProjectL_UI_TeamUIController.<>f__mg$cache31 == null)
		{
			Lua_BlackJack_ProjectL_UI_TeamUIController.<>f__mg$cache31 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_TeamUIController.__callDele_EventOnShowHelp);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_TeamUIController.<>f__mg$cache31);
		if (Lua_BlackJack_ProjectL_UI_TeamUIController.<>f__mg$cache32 == null)
		{
			Lua_BlackJack_ProjectL_UI_TeamUIController.<>f__mg$cache32 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_TeamUIController.__clearDele_EventOnShowHelp);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_TeamUIController.<>f__mg$cache32);
		if (Lua_BlackJack_ProjectL_UI_TeamUIController.<>f__mg$cache33 == null)
		{
			Lua_BlackJack_ProjectL_UI_TeamUIController.<>f__mg$cache33 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_TeamUIController.__callDele_EventOnRefreshTeamRoom);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_TeamUIController.<>f__mg$cache33);
		if (Lua_BlackJack_ProjectL_UI_TeamUIController.<>f__mg$cache34 == null)
		{
			Lua_BlackJack_ProjectL_UI_TeamUIController.<>f__mg$cache34 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_TeamUIController.__clearDele_EventOnRefreshTeamRoom);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_TeamUIController.<>f__mg$cache34);
		if (Lua_BlackJack_ProjectL_UI_TeamUIController.<>f__mg$cache35 == null)
		{
			Lua_BlackJack_ProjectL_UI_TeamUIController.<>f__mg$cache35 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_TeamUIController.__callDele_EventOnShowCreateTeamRoom);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_TeamUIController.<>f__mg$cache35);
		if (Lua_BlackJack_ProjectL_UI_TeamUIController.<>f__mg$cache36 == null)
		{
			Lua_BlackJack_ProjectL_UI_TeamUIController.<>f__mg$cache36 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_TeamUIController.__clearDele_EventOnShowCreateTeamRoom);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_TeamUIController.<>f__mg$cache36);
		if (Lua_BlackJack_ProjectL_UI_TeamUIController.<>f__mg$cache37 == null)
		{
			Lua_BlackJack_ProjectL_UI_TeamUIController.<>f__mg$cache37 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_TeamUIController.__callDele_EventOnAutoMatch);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_TeamUIController.<>f__mg$cache37);
		if (Lua_BlackJack_ProjectL_UI_TeamUIController.<>f__mg$cache38 == null)
		{
			Lua_BlackJack_ProjectL_UI_TeamUIController.<>f__mg$cache38 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_TeamUIController.__clearDele_EventOnAutoMatch);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_TeamUIController.<>f__mg$cache38);
		if (Lua_BlackJack_ProjectL_UI_TeamUIController.<>f__mg$cache39 == null)
		{
			Lua_BlackJack_ProjectL_UI_TeamUIController.<>f__mg$cache39 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_TeamUIController.__callDele_EventOnAutoMatchCancel);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_TeamUIController.<>f__mg$cache39);
		if (Lua_BlackJack_ProjectL_UI_TeamUIController.<>f__mg$cache3A == null)
		{
			Lua_BlackJack_ProjectL_UI_TeamUIController.<>f__mg$cache3A = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_TeamUIController.__clearDele_EventOnAutoMatchCancel);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_TeamUIController.<>f__mg$cache3A);
		if (Lua_BlackJack_ProjectL_UI_TeamUIController.<>f__mg$cache3B == null)
		{
			Lua_BlackJack_ProjectL_UI_TeamUIController.<>f__mg$cache3B = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_TeamUIController.__callDele_EventOnSelectGameFunctionTypeAndLocation);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_TeamUIController.<>f__mg$cache3B);
		if (Lua_BlackJack_ProjectL_UI_TeamUIController.<>f__mg$cache3C == null)
		{
			Lua_BlackJack_ProjectL_UI_TeamUIController.<>f__mg$cache3C = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_TeamUIController.__clearDele_EventOnSelectGameFunctionTypeAndLocation);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_TeamUIController.<>f__mg$cache3C);
		if (Lua_BlackJack_ProjectL_UI_TeamUIController.<>f__mg$cache3D == null)
		{
			Lua_BlackJack_ProjectL_UI_TeamUIController.<>f__mg$cache3D = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_TeamUIController.__callDele_EventOnJoinTeamRoom);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_TeamUIController.<>f__mg$cache3D);
		if (Lua_BlackJack_ProjectL_UI_TeamUIController.<>f__mg$cache3E == null)
		{
			Lua_BlackJack_ProjectL_UI_TeamUIController.<>f__mg$cache3E = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_TeamUIController.__clearDele_EventOnJoinTeamRoom);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_TeamUIController.<>f__mg$cache3E);
		string name = "EventOnReturn";
		LuaCSFunction get = null;
		if (Lua_BlackJack_ProjectL_UI_TeamUIController.<>f__mg$cache3F == null)
		{
			Lua_BlackJack_ProjectL_UI_TeamUIController.<>f__mg$cache3F = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_TeamUIController.set_EventOnReturn);
		}
		LuaObject.addMember(l, name, get, Lua_BlackJack_ProjectL_UI_TeamUIController.<>f__mg$cache3F, true);
		string name2 = "EventOnShowHelp";
		LuaCSFunction get2 = null;
		if (Lua_BlackJack_ProjectL_UI_TeamUIController.<>f__mg$cache40 == null)
		{
			Lua_BlackJack_ProjectL_UI_TeamUIController.<>f__mg$cache40 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_TeamUIController.set_EventOnShowHelp);
		}
		LuaObject.addMember(l, name2, get2, Lua_BlackJack_ProjectL_UI_TeamUIController.<>f__mg$cache40, true);
		string name3 = "EventOnRefreshTeamRoom";
		LuaCSFunction get3 = null;
		if (Lua_BlackJack_ProjectL_UI_TeamUIController.<>f__mg$cache41 == null)
		{
			Lua_BlackJack_ProjectL_UI_TeamUIController.<>f__mg$cache41 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_TeamUIController.set_EventOnRefreshTeamRoom);
		}
		LuaObject.addMember(l, name3, get3, Lua_BlackJack_ProjectL_UI_TeamUIController.<>f__mg$cache41, true);
		string name4 = "EventOnShowCreateTeamRoom";
		LuaCSFunction get4 = null;
		if (Lua_BlackJack_ProjectL_UI_TeamUIController.<>f__mg$cache42 == null)
		{
			Lua_BlackJack_ProjectL_UI_TeamUIController.<>f__mg$cache42 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_TeamUIController.set_EventOnShowCreateTeamRoom);
		}
		LuaObject.addMember(l, name4, get4, Lua_BlackJack_ProjectL_UI_TeamUIController.<>f__mg$cache42, true);
		string name5 = "EventOnAutoMatch";
		LuaCSFunction get5 = null;
		if (Lua_BlackJack_ProjectL_UI_TeamUIController.<>f__mg$cache43 == null)
		{
			Lua_BlackJack_ProjectL_UI_TeamUIController.<>f__mg$cache43 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_TeamUIController.set_EventOnAutoMatch);
		}
		LuaObject.addMember(l, name5, get5, Lua_BlackJack_ProjectL_UI_TeamUIController.<>f__mg$cache43, true);
		string name6 = "EventOnAutoMatchCancel";
		LuaCSFunction get6 = null;
		if (Lua_BlackJack_ProjectL_UI_TeamUIController.<>f__mg$cache44 == null)
		{
			Lua_BlackJack_ProjectL_UI_TeamUIController.<>f__mg$cache44 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_TeamUIController.set_EventOnAutoMatchCancel);
		}
		LuaObject.addMember(l, name6, get6, Lua_BlackJack_ProjectL_UI_TeamUIController.<>f__mg$cache44, true);
		string name7 = "EventOnSelectGameFunctionTypeAndLocation";
		LuaCSFunction get7 = null;
		if (Lua_BlackJack_ProjectL_UI_TeamUIController.<>f__mg$cache45 == null)
		{
			Lua_BlackJack_ProjectL_UI_TeamUIController.<>f__mg$cache45 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_TeamUIController.set_EventOnSelectGameFunctionTypeAndLocation);
		}
		LuaObject.addMember(l, name7, get7, Lua_BlackJack_ProjectL_UI_TeamUIController.<>f__mg$cache45, true);
		string name8 = "EventOnJoinTeamRoom";
		LuaCSFunction get8 = null;
		if (Lua_BlackJack_ProjectL_UI_TeamUIController.<>f__mg$cache46 == null)
		{
			Lua_BlackJack_ProjectL_UI_TeamUIController.<>f__mg$cache46 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_TeamUIController.set_EventOnJoinTeamRoom);
		}
		LuaObject.addMember(l, name8, get8, Lua_BlackJack_ProjectL_UI_TeamUIController.<>f__mg$cache46, true);
		string name9 = "m_uiStateController";
		if (Lua_BlackJack_ProjectL_UI_TeamUIController.<>f__mg$cache47 == null)
		{
			Lua_BlackJack_ProjectL_UI_TeamUIController.<>f__mg$cache47 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_TeamUIController.get_m_uiStateController);
		}
		LuaCSFunction get9 = Lua_BlackJack_ProjectL_UI_TeamUIController.<>f__mg$cache47;
		if (Lua_BlackJack_ProjectL_UI_TeamUIController.<>f__mg$cache48 == null)
		{
			Lua_BlackJack_ProjectL_UI_TeamUIController.<>f__mg$cache48 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_TeamUIController.set_m_uiStateController);
		}
		LuaObject.addMember(l, name9, get9, Lua_BlackJack_ProjectL_UI_TeamUIController.<>f__mg$cache48, true);
		string name10 = "m_returnButton";
		if (Lua_BlackJack_ProjectL_UI_TeamUIController.<>f__mg$cache49 == null)
		{
			Lua_BlackJack_ProjectL_UI_TeamUIController.<>f__mg$cache49 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_TeamUIController.get_m_returnButton);
		}
		LuaCSFunction get10 = Lua_BlackJack_ProjectL_UI_TeamUIController.<>f__mg$cache49;
		if (Lua_BlackJack_ProjectL_UI_TeamUIController.<>f__mg$cache4A == null)
		{
			Lua_BlackJack_ProjectL_UI_TeamUIController.<>f__mg$cache4A = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_TeamUIController.set_m_returnButton);
		}
		LuaObject.addMember(l, name10, get10, Lua_BlackJack_ProjectL_UI_TeamUIController.<>f__mg$cache4A, true);
		string name11 = "m_helpButton";
		if (Lua_BlackJack_ProjectL_UI_TeamUIController.<>f__mg$cache4B == null)
		{
			Lua_BlackJack_ProjectL_UI_TeamUIController.<>f__mg$cache4B = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_TeamUIController.get_m_helpButton);
		}
		LuaCSFunction get11 = Lua_BlackJack_ProjectL_UI_TeamUIController.<>f__mg$cache4B;
		if (Lua_BlackJack_ProjectL_UI_TeamUIController.<>f__mg$cache4C == null)
		{
			Lua_BlackJack_ProjectL_UI_TeamUIController.<>f__mg$cache4C = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_TeamUIController.set_m_helpButton);
		}
		LuaObject.addMember(l, name11, get11, Lua_BlackJack_ProjectL_UI_TeamUIController.<>f__mg$cache4C, true);
		string name12 = "m_gameFunctionTypeListScrollRect";
		if (Lua_BlackJack_ProjectL_UI_TeamUIController.<>f__mg$cache4D == null)
		{
			Lua_BlackJack_ProjectL_UI_TeamUIController.<>f__mg$cache4D = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_TeamUIController.get_m_gameFunctionTypeListScrollRect);
		}
		LuaCSFunction get12 = Lua_BlackJack_ProjectL_UI_TeamUIController.<>f__mg$cache4D;
		if (Lua_BlackJack_ProjectL_UI_TeamUIController.<>f__mg$cache4E == null)
		{
			Lua_BlackJack_ProjectL_UI_TeamUIController.<>f__mg$cache4E = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_TeamUIController.set_m_gameFunctionTypeListScrollRect);
		}
		LuaObject.addMember(l, name12, get12, Lua_BlackJack_ProjectL_UI_TeamUIController.<>f__mg$cache4E, true);
		string name13 = "m_gameFunctionTypeListDisableButton";
		if (Lua_BlackJack_ProjectL_UI_TeamUIController.<>f__mg$cache4F == null)
		{
			Lua_BlackJack_ProjectL_UI_TeamUIController.<>f__mg$cache4F = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_TeamUIController.get_m_gameFunctionTypeListDisableButton);
		}
		LuaCSFunction get13 = Lua_BlackJack_ProjectL_UI_TeamUIController.<>f__mg$cache4F;
		if (Lua_BlackJack_ProjectL_UI_TeamUIController.<>f__mg$cache50 == null)
		{
			Lua_BlackJack_ProjectL_UI_TeamUIController.<>f__mg$cache50 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_TeamUIController.set_m_gameFunctionTypeListDisableButton);
		}
		LuaObject.addMember(l, name13, get13, Lua_BlackJack_ProjectL_UI_TeamUIController.<>f__mg$cache50, true);
		string name14 = "m_locationListUiStateController";
		if (Lua_BlackJack_ProjectL_UI_TeamUIController.<>f__mg$cache51 == null)
		{
			Lua_BlackJack_ProjectL_UI_TeamUIController.<>f__mg$cache51 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_TeamUIController.get_m_locationListUiStateController);
		}
		LuaCSFunction get14 = Lua_BlackJack_ProjectL_UI_TeamUIController.<>f__mg$cache51;
		if (Lua_BlackJack_ProjectL_UI_TeamUIController.<>f__mg$cache52 == null)
		{
			Lua_BlackJack_ProjectL_UI_TeamUIController.<>f__mg$cache52 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_TeamUIController.set_m_locationListUiStateController);
		}
		LuaObject.addMember(l, name14, get14, Lua_BlackJack_ProjectL_UI_TeamUIController.<>f__mg$cache52, true);
		string name15 = "m_locationListScrollRect";
		if (Lua_BlackJack_ProjectL_UI_TeamUIController.<>f__mg$cache53 == null)
		{
			Lua_BlackJack_ProjectL_UI_TeamUIController.<>f__mg$cache53 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_TeamUIController.get_m_locationListScrollRect);
		}
		LuaCSFunction get15 = Lua_BlackJack_ProjectL_UI_TeamUIController.<>f__mg$cache53;
		if (Lua_BlackJack_ProjectL_UI_TeamUIController.<>f__mg$cache54 == null)
		{
			Lua_BlackJack_ProjectL_UI_TeamUIController.<>f__mg$cache54 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_TeamUIController.set_m_locationListScrollRect);
		}
		LuaObject.addMember(l, name15, get15, Lua_BlackJack_ProjectL_UI_TeamUIController.<>f__mg$cache54, true);
		string name16 = "m_locationListCloseButton";
		if (Lua_BlackJack_ProjectL_UI_TeamUIController.<>f__mg$cache55 == null)
		{
			Lua_BlackJack_ProjectL_UI_TeamUIController.<>f__mg$cache55 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_TeamUIController.get_m_locationListCloseButton);
		}
		LuaCSFunction get16 = Lua_BlackJack_ProjectL_UI_TeamUIController.<>f__mg$cache55;
		if (Lua_BlackJack_ProjectL_UI_TeamUIController.<>f__mg$cache56 == null)
		{
			Lua_BlackJack_ProjectL_UI_TeamUIController.<>f__mg$cache56 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_TeamUIController.set_m_locationListCloseButton);
		}
		LuaObject.addMember(l, name16, get16, Lua_BlackJack_ProjectL_UI_TeamUIController.<>f__mg$cache56, true);
		string name17 = "m_locationListDisableButton";
		if (Lua_BlackJack_ProjectL_UI_TeamUIController.<>f__mg$cache57 == null)
		{
			Lua_BlackJack_ProjectL_UI_TeamUIController.<>f__mg$cache57 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_TeamUIController.get_m_locationListDisableButton);
		}
		LuaCSFunction get17 = Lua_BlackJack_ProjectL_UI_TeamUIController.<>f__mg$cache57;
		if (Lua_BlackJack_ProjectL_UI_TeamUIController.<>f__mg$cache58 == null)
		{
			Lua_BlackJack_ProjectL_UI_TeamUIController.<>f__mg$cache58 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_TeamUIController.set_m_locationListDisableButton);
		}
		LuaObject.addMember(l, name17, get17, Lua_BlackJack_ProjectL_UI_TeamUIController.<>f__mg$cache58, true);
		string name18 = "m_titleText";
		if (Lua_BlackJack_ProjectL_UI_TeamUIController.<>f__mg$cache59 == null)
		{
			Lua_BlackJack_ProjectL_UI_TeamUIController.<>f__mg$cache59 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_TeamUIController.get_m_titleText);
		}
		LuaCSFunction get18 = Lua_BlackJack_ProjectL_UI_TeamUIController.<>f__mg$cache59;
		if (Lua_BlackJack_ProjectL_UI_TeamUIController.<>f__mg$cache5A == null)
		{
			Lua_BlackJack_ProjectL_UI_TeamUIController.<>f__mg$cache5A = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_TeamUIController.set_m_titleText);
		}
		LuaObject.addMember(l, name18, get18, Lua_BlackJack_ProjectL_UI_TeamUIController.<>f__mg$cache5A, true);
		string name19 = "m_roomListScrollRect";
		if (Lua_BlackJack_ProjectL_UI_TeamUIController.<>f__mg$cache5B == null)
		{
			Lua_BlackJack_ProjectL_UI_TeamUIController.<>f__mg$cache5B = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_TeamUIController.get_m_roomListScrollRect);
		}
		LuaCSFunction get19 = Lua_BlackJack_ProjectL_UI_TeamUIController.<>f__mg$cache5B;
		if (Lua_BlackJack_ProjectL_UI_TeamUIController.<>f__mg$cache5C == null)
		{
			Lua_BlackJack_ProjectL_UI_TeamUIController.<>f__mg$cache5C = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_TeamUIController.set_m_roomListScrollRect);
		}
		LuaObject.addMember(l, name19, get19, Lua_BlackJack_ProjectL_UI_TeamUIController.<>f__mg$cache5C, true);
		string name20 = "m_createTeamRoomButton";
		if (Lua_BlackJack_ProjectL_UI_TeamUIController.<>f__mg$cache5D == null)
		{
			Lua_BlackJack_ProjectL_UI_TeamUIController.<>f__mg$cache5D = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_TeamUIController.get_m_createTeamRoomButton);
		}
		LuaCSFunction get20 = Lua_BlackJack_ProjectL_UI_TeamUIController.<>f__mg$cache5D;
		if (Lua_BlackJack_ProjectL_UI_TeamUIController.<>f__mg$cache5E == null)
		{
			Lua_BlackJack_ProjectL_UI_TeamUIController.<>f__mg$cache5E = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_TeamUIController.set_m_createTeamRoomButton);
		}
		LuaObject.addMember(l, name20, get20, Lua_BlackJack_ProjectL_UI_TeamUIController.<>f__mg$cache5E, true);
		string name21 = "m_refreshTeamRoomButton";
		if (Lua_BlackJack_ProjectL_UI_TeamUIController.<>f__mg$cache5F == null)
		{
			Lua_BlackJack_ProjectL_UI_TeamUIController.<>f__mg$cache5F = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_TeamUIController.get_m_refreshTeamRoomButton);
		}
		LuaCSFunction get21 = Lua_BlackJack_ProjectL_UI_TeamUIController.<>f__mg$cache5F;
		if (Lua_BlackJack_ProjectL_UI_TeamUIController.<>f__mg$cache60 == null)
		{
			Lua_BlackJack_ProjectL_UI_TeamUIController.<>f__mg$cache60 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_TeamUIController.set_m_refreshTeamRoomButton);
		}
		LuaObject.addMember(l, name21, get21, Lua_BlackJack_ProjectL_UI_TeamUIController.<>f__mg$cache60, true);
		string name22 = "m_autoMatchButton";
		if (Lua_BlackJack_ProjectL_UI_TeamUIController.<>f__mg$cache61 == null)
		{
			Lua_BlackJack_ProjectL_UI_TeamUIController.<>f__mg$cache61 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_TeamUIController.get_m_autoMatchButton);
		}
		LuaCSFunction get22 = Lua_BlackJack_ProjectL_UI_TeamUIController.<>f__mg$cache61;
		if (Lua_BlackJack_ProjectL_UI_TeamUIController.<>f__mg$cache62 == null)
		{
			Lua_BlackJack_ProjectL_UI_TeamUIController.<>f__mg$cache62 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_TeamUIController.set_m_autoMatchButton);
		}
		LuaObject.addMember(l, name22, get22, Lua_BlackJack_ProjectL_UI_TeamUIController.<>f__mg$cache62, true);
		string name23 = "m_noTeamRoomUIStateController";
		if (Lua_BlackJack_ProjectL_UI_TeamUIController.<>f__mg$cache63 == null)
		{
			Lua_BlackJack_ProjectL_UI_TeamUIController.<>f__mg$cache63 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_TeamUIController.get_m_noTeamRoomUIStateController);
		}
		LuaCSFunction get23 = Lua_BlackJack_ProjectL_UI_TeamUIController.<>f__mg$cache63;
		if (Lua_BlackJack_ProjectL_UI_TeamUIController.<>f__mg$cache64 == null)
		{
			Lua_BlackJack_ProjectL_UI_TeamUIController.<>f__mg$cache64 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_TeamUIController.set_m_noTeamRoomUIStateController);
		}
		LuaObject.addMember(l, name23, get23, Lua_BlackJack_ProjectL_UI_TeamUIController.<>f__mg$cache64, true);
		string name24 = "m_autoMatchCancelButton";
		if (Lua_BlackJack_ProjectL_UI_TeamUIController.<>f__mg$cache65 == null)
		{
			Lua_BlackJack_ProjectL_UI_TeamUIController.<>f__mg$cache65 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_TeamUIController.get_m_autoMatchCancelButton);
		}
		LuaCSFunction get24 = Lua_BlackJack_ProjectL_UI_TeamUIController.<>f__mg$cache65;
		if (Lua_BlackJack_ProjectL_UI_TeamUIController.<>f__mg$cache66 == null)
		{
			Lua_BlackJack_ProjectL_UI_TeamUIController.<>f__mg$cache66 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_TeamUIController.set_m_autoMatchCancelButton);
		}
		LuaObject.addMember(l, name24, get24, Lua_BlackJack_ProjectL_UI_TeamUIController.<>f__mg$cache66, true);
		string name25 = "m_autoMatchWaitCountText";
		if (Lua_BlackJack_ProjectL_UI_TeamUIController.<>f__mg$cache67 == null)
		{
			Lua_BlackJack_ProjectL_UI_TeamUIController.<>f__mg$cache67 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_TeamUIController.get_m_autoMatchWaitCountText);
		}
		LuaCSFunction get25 = Lua_BlackJack_ProjectL_UI_TeamUIController.<>f__mg$cache67;
		if (Lua_BlackJack_ProjectL_UI_TeamUIController.<>f__mg$cache68 == null)
		{
			Lua_BlackJack_ProjectL_UI_TeamUIController.<>f__mg$cache68 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_TeamUIController.set_m_autoMatchWaitCountText);
		}
		LuaObject.addMember(l, name25, get25, Lua_BlackJack_ProjectL_UI_TeamUIController.<>f__mg$cache68, true);
		string name26 = "m_prefabsGameObject";
		if (Lua_BlackJack_ProjectL_UI_TeamUIController.<>f__mg$cache69 == null)
		{
			Lua_BlackJack_ProjectL_UI_TeamUIController.<>f__mg$cache69 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_TeamUIController.get_m_prefabsGameObject);
		}
		LuaCSFunction get26 = Lua_BlackJack_ProjectL_UI_TeamUIController.<>f__mg$cache69;
		if (Lua_BlackJack_ProjectL_UI_TeamUIController.<>f__mg$cache6A == null)
		{
			Lua_BlackJack_ProjectL_UI_TeamUIController.<>f__mg$cache6A = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_TeamUIController.set_m_prefabsGameObject);
		}
		LuaObject.addMember(l, name26, get26, Lua_BlackJack_ProjectL_UI_TeamUIController.<>f__mg$cache6A, true);
		string name27 = "m_gameFunctionTypeListItemPrefab";
		if (Lua_BlackJack_ProjectL_UI_TeamUIController.<>f__mg$cache6B == null)
		{
			Lua_BlackJack_ProjectL_UI_TeamUIController.<>f__mg$cache6B = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_TeamUIController.get_m_gameFunctionTypeListItemPrefab);
		}
		LuaCSFunction get27 = Lua_BlackJack_ProjectL_UI_TeamUIController.<>f__mg$cache6B;
		if (Lua_BlackJack_ProjectL_UI_TeamUIController.<>f__mg$cache6C == null)
		{
			Lua_BlackJack_ProjectL_UI_TeamUIController.<>f__mg$cache6C = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_TeamUIController.set_m_gameFunctionTypeListItemPrefab);
		}
		LuaObject.addMember(l, name27, get27, Lua_BlackJack_ProjectL_UI_TeamUIController.<>f__mg$cache6C, true);
		string name28 = "m_locationListItemPrefab";
		if (Lua_BlackJack_ProjectL_UI_TeamUIController.<>f__mg$cache6D == null)
		{
			Lua_BlackJack_ProjectL_UI_TeamUIController.<>f__mg$cache6D = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_TeamUIController.get_m_locationListItemPrefab);
		}
		LuaCSFunction get28 = Lua_BlackJack_ProjectL_UI_TeamUIController.<>f__mg$cache6D;
		if (Lua_BlackJack_ProjectL_UI_TeamUIController.<>f__mg$cache6E == null)
		{
			Lua_BlackJack_ProjectL_UI_TeamUIController.<>f__mg$cache6E = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_TeamUIController.set_m_locationListItemPrefab);
		}
		LuaObject.addMember(l, name28, get28, Lua_BlackJack_ProjectL_UI_TeamUIController.<>f__mg$cache6E, true);
		string name29 = "m_roomListItemPrefab";
		if (Lua_BlackJack_ProjectL_UI_TeamUIController.<>f__mg$cache6F == null)
		{
			Lua_BlackJack_ProjectL_UI_TeamUIController.<>f__mg$cache6F = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_TeamUIController.get_m_roomListItemPrefab);
		}
		LuaCSFunction get29 = Lua_BlackJack_ProjectL_UI_TeamUIController.<>f__mg$cache6F;
		if (Lua_BlackJack_ProjectL_UI_TeamUIController.<>f__mg$cache70 == null)
		{
			Lua_BlackJack_ProjectL_UI_TeamUIController.<>f__mg$cache70 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_TeamUIController.set_m_roomListItemPrefab);
		}
		LuaObject.addMember(l, name29, get29, Lua_BlackJack_ProjectL_UI_TeamUIController.<>f__mg$cache70, true);
		string name30 = "m_gameFunctionTypeListItems";
		if (Lua_BlackJack_ProjectL_UI_TeamUIController.<>f__mg$cache71 == null)
		{
			Lua_BlackJack_ProjectL_UI_TeamUIController.<>f__mg$cache71 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_TeamUIController.get_m_gameFunctionTypeListItems);
		}
		LuaCSFunction get30 = Lua_BlackJack_ProjectL_UI_TeamUIController.<>f__mg$cache71;
		if (Lua_BlackJack_ProjectL_UI_TeamUIController.<>f__mg$cache72 == null)
		{
			Lua_BlackJack_ProjectL_UI_TeamUIController.<>f__mg$cache72 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_TeamUIController.set_m_gameFunctionTypeListItems);
		}
		LuaObject.addMember(l, name30, get30, Lua_BlackJack_ProjectL_UI_TeamUIController.<>f__mg$cache72, true);
		string name31 = "m_locationListItems";
		if (Lua_BlackJack_ProjectL_UI_TeamUIController.<>f__mg$cache73 == null)
		{
			Lua_BlackJack_ProjectL_UI_TeamUIController.<>f__mg$cache73 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_TeamUIController.get_m_locationListItems);
		}
		LuaCSFunction get31 = Lua_BlackJack_ProjectL_UI_TeamUIController.<>f__mg$cache73;
		if (Lua_BlackJack_ProjectL_UI_TeamUIController.<>f__mg$cache74 == null)
		{
			Lua_BlackJack_ProjectL_UI_TeamUIController.<>f__mg$cache74 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_TeamUIController.set_m_locationListItems);
		}
		LuaObject.addMember(l, name31, get31, Lua_BlackJack_ProjectL_UI_TeamUIController.<>f__mg$cache74, true);
		string name32 = "m_roomListItems";
		if (Lua_BlackJack_ProjectL_UI_TeamUIController.<>f__mg$cache75 == null)
		{
			Lua_BlackJack_ProjectL_UI_TeamUIController.<>f__mg$cache75 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_TeamUIController.get_m_roomListItems);
		}
		LuaCSFunction get32 = Lua_BlackJack_ProjectL_UI_TeamUIController.<>f__mg$cache75;
		if (Lua_BlackJack_ProjectL_UI_TeamUIController.<>f__mg$cache76 == null)
		{
			Lua_BlackJack_ProjectL_UI_TeamUIController.<>f__mg$cache76 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_TeamUIController.set_m_roomListItems);
		}
		LuaObject.addMember(l, name32, get32, Lua_BlackJack_ProjectL_UI_TeamUIController.<>f__mg$cache76, true);
		string name33 = "m_isIgnoreFireSelectEvent";
		if (Lua_BlackJack_ProjectL_UI_TeamUIController.<>f__mg$cache77 == null)
		{
			Lua_BlackJack_ProjectL_UI_TeamUIController.<>f__mg$cache77 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_TeamUIController.get_m_isIgnoreFireSelectEvent);
		}
		LuaCSFunction get33 = Lua_BlackJack_ProjectL_UI_TeamUIController.<>f__mg$cache77;
		if (Lua_BlackJack_ProjectL_UI_TeamUIController.<>f__mg$cache78 == null)
		{
			Lua_BlackJack_ProjectL_UI_TeamUIController.<>f__mg$cache78 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_TeamUIController.set_m_isIgnoreFireSelectEvent);
		}
		LuaObject.addMember(l, name33, get33, Lua_BlackJack_ProjectL_UI_TeamUIController.<>f__mg$cache78, true);
		LuaObject.createTypeMetatable(l, null, typeof(TeamUIController), typeof(UIControllerBase));
	}

	// Token: 0x04017795 RID: 96149
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache0;

	// Token: 0x04017796 RID: 96150
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1;

	// Token: 0x04017797 RID: 96151
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2;

	// Token: 0x04017798 RID: 96152
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3;

	// Token: 0x04017799 RID: 96153
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache4;

	// Token: 0x0401779A RID: 96154
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache5;

	// Token: 0x0401779B RID: 96155
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache6;

	// Token: 0x0401779C RID: 96156
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache7;

	// Token: 0x0401779D RID: 96157
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache8;

	// Token: 0x0401779E RID: 96158
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache9;

	// Token: 0x0401779F RID: 96159
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheA;

	// Token: 0x040177A0 RID: 96160
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheB;

	// Token: 0x040177A1 RID: 96161
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheC;

	// Token: 0x040177A2 RID: 96162
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheD;

	// Token: 0x040177A3 RID: 96163
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheE;

	// Token: 0x040177A4 RID: 96164
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheF;

	// Token: 0x040177A5 RID: 96165
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache10;

	// Token: 0x040177A6 RID: 96166
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache11;

	// Token: 0x040177A7 RID: 96167
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache12;

	// Token: 0x040177A8 RID: 96168
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache13;

	// Token: 0x040177A9 RID: 96169
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache14;

	// Token: 0x040177AA RID: 96170
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache15;

	// Token: 0x040177AB RID: 96171
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache16;

	// Token: 0x040177AC RID: 96172
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache17;

	// Token: 0x040177AD RID: 96173
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache18;

	// Token: 0x040177AE RID: 96174
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache19;

	// Token: 0x040177AF RID: 96175
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1A;

	// Token: 0x040177B0 RID: 96176
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1B;

	// Token: 0x040177B1 RID: 96177
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1C;

	// Token: 0x040177B2 RID: 96178
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1D;

	// Token: 0x040177B3 RID: 96179
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1E;

	// Token: 0x040177B4 RID: 96180
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1F;

	// Token: 0x040177B5 RID: 96181
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache20;

	// Token: 0x040177B6 RID: 96182
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache21;

	// Token: 0x040177B7 RID: 96183
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache22;

	// Token: 0x040177B8 RID: 96184
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache23;

	// Token: 0x040177B9 RID: 96185
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache24;

	// Token: 0x040177BA RID: 96186
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache25;

	// Token: 0x040177BB RID: 96187
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache26;

	// Token: 0x040177BC RID: 96188
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache27;

	// Token: 0x040177BD RID: 96189
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache28;

	// Token: 0x040177BE RID: 96190
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache29;

	// Token: 0x040177BF RID: 96191
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2A;

	// Token: 0x040177C0 RID: 96192
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2B;

	// Token: 0x040177C1 RID: 96193
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2C;

	// Token: 0x040177C2 RID: 96194
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2D;

	// Token: 0x040177C3 RID: 96195
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2E;

	// Token: 0x040177C4 RID: 96196
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2F;

	// Token: 0x040177C5 RID: 96197
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache30;

	// Token: 0x040177C6 RID: 96198
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache31;

	// Token: 0x040177C7 RID: 96199
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache32;

	// Token: 0x040177C8 RID: 96200
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache33;

	// Token: 0x040177C9 RID: 96201
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache34;

	// Token: 0x040177CA RID: 96202
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache35;

	// Token: 0x040177CB RID: 96203
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache36;

	// Token: 0x040177CC RID: 96204
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache37;

	// Token: 0x040177CD RID: 96205
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache38;

	// Token: 0x040177CE RID: 96206
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache39;

	// Token: 0x040177CF RID: 96207
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3A;

	// Token: 0x040177D0 RID: 96208
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3B;

	// Token: 0x040177D1 RID: 96209
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3C;

	// Token: 0x040177D2 RID: 96210
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3D;

	// Token: 0x040177D3 RID: 96211
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3E;

	// Token: 0x040177D4 RID: 96212
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3F;

	// Token: 0x040177D5 RID: 96213
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache40;

	// Token: 0x040177D6 RID: 96214
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache41;

	// Token: 0x040177D7 RID: 96215
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache42;

	// Token: 0x040177D8 RID: 96216
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache43;

	// Token: 0x040177D9 RID: 96217
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache44;

	// Token: 0x040177DA RID: 96218
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache45;

	// Token: 0x040177DB RID: 96219
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache46;

	// Token: 0x040177DC RID: 96220
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache47;

	// Token: 0x040177DD RID: 96221
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache48;

	// Token: 0x040177DE RID: 96222
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache49;

	// Token: 0x040177DF RID: 96223
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache4A;

	// Token: 0x040177E0 RID: 96224
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache4B;

	// Token: 0x040177E1 RID: 96225
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache4C;

	// Token: 0x040177E2 RID: 96226
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache4D;

	// Token: 0x040177E3 RID: 96227
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache4E;

	// Token: 0x040177E4 RID: 96228
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache4F;

	// Token: 0x040177E5 RID: 96229
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache50;

	// Token: 0x040177E6 RID: 96230
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache51;

	// Token: 0x040177E7 RID: 96231
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache52;

	// Token: 0x040177E8 RID: 96232
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache53;

	// Token: 0x040177E9 RID: 96233
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache54;

	// Token: 0x040177EA RID: 96234
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache55;

	// Token: 0x040177EB RID: 96235
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache56;

	// Token: 0x040177EC RID: 96236
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache57;

	// Token: 0x040177ED RID: 96237
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache58;

	// Token: 0x040177EE RID: 96238
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache59;

	// Token: 0x040177EF RID: 96239
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache5A;

	// Token: 0x040177F0 RID: 96240
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache5B;

	// Token: 0x040177F1 RID: 96241
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache5C;

	// Token: 0x040177F2 RID: 96242
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache5D;

	// Token: 0x040177F3 RID: 96243
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache5E;

	// Token: 0x040177F4 RID: 96244
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache5F;

	// Token: 0x040177F5 RID: 96245
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache60;

	// Token: 0x040177F6 RID: 96246
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache61;

	// Token: 0x040177F7 RID: 96247
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache62;

	// Token: 0x040177F8 RID: 96248
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache63;

	// Token: 0x040177F9 RID: 96249
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache64;

	// Token: 0x040177FA RID: 96250
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache65;

	// Token: 0x040177FB RID: 96251
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache66;

	// Token: 0x040177FC RID: 96252
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache67;

	// Token: 0x040177FD RID: 96253
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache68;

	// Token: 0x040177FE RID: 96254
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache69;

	// Token: 0x040177FF RID: 96255
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache6A;

	// Token: 0x04017800 RID: 96256
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache6B;

	// Token: 0x04017801 RID: 96257
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache6C;

	// Token: 0x04017802 RID: 96258
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache6D;

	// Token: 0x04017803 RID: 96259
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache6E;

	// Token: 0x04017804 RID: 96260
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache6F;

	// Token: 0x04017805 RID: 96261
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache70;

	// Token: 0x04017806 RID: 96262
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache71;

	// Token: 0x04017807 RID: 96263
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache72;

	// Token: 0x04017808 RID: 96264
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache73;

	// Token: 0x04017809 RID: 96265
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache74;

	// Token: 0x0401780A RID: 96266
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache75;

	// Token: 0x0401780B RID: 96267
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache76;

	// Token: 0x0401780C RID: 96268
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache77;

	// Token: 0x0401780D RID: 96269
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache78;
}
