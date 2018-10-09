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

// Token: 0x0200140E RID: 5134
[Preserve]
public class Lua_BlackJack_ProjectL_UI_CreateTeamRoomUIController : LuaObject
{
	// Token: 0x0601D041 RID: 118849 RVA: 0x0091B1A4 File Offset: 0x009193A4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int Open(IntPtr l)
	{
		int result;
		try
		{
			CreateTeamRoomUIController createTeamRoomUIController = (CreateTeamRoomUIController)LuaObject.checkSelf(l);
			createTeamRoomUIController.Open();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D042 RID: 118850 RVA: 0x0091B1F0 File Offset: 0x009193F0
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int Close(IntPtr l)
	{
		int result;
		try
		{
			CreateTeamRoomUIController createTeamRoomUIController = (CreateTeamRoomUIController)LuaObject.checkSelf(l);
			Action onEnd;
			LuaObject.checkDelegate<Action>(l, 2, out onEnd);
			createTeamRoomUIController.Close(onEnd);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D043 RID: 118851 RVA: 0x0091B248 File Offset: 0x00919448
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int SetGameFunctionType(IntPtr l)
	{
		int result;
		try
		{
			CreateTeamRoomUIController createTeamRoomUIController = (CreateTeamRoomUIController)LuaObject.checkSelf(l);
			GameFunctionType gameFunctionType;
			LuaObject.checkEnum<GameFunctionType>(l, 2, out gameFunctionType);
			int chapterId;
			LuaObject.checkType(l, 3, out chapterId);
			createTeamRoomUIController.SetGameFunctionType(gameFunctionType, chapterId);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D044 RID: 118852 RVA: 0x0091B2AC File Offset: 0x009194AC
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int SetLocation(IntPtr l)
	{
		int result;
		try
		{
			CreateTeamRoomUIController createTeamRoomUIController = (CreateTeamRoomUIController)LuaObject.checkSelf(l);
			int location;
			LuaObject.checkType(l, 2, out location);
			createTeamRoomUIController.SetLocation(location);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D045 RID: 118853 RVA: 0x0091B304 File Offset: 0x00919504
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int OnBindFiledsCompleted(IntPtr l)
	{
		int result;
		try
		{
			CreateTeamRoomUIController createTeamRoomUIController = (CreateTeamRoomUIController)LuaObject.checkSelf(l);
			createTeamRoomUIController.m_luaExportHelper.OnBindFiledsCompleted();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D046 RID: 118854 RVA: 0x0091B358 File Offset: 0x00919558
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int AddGameFunctionTypeListItems(IntPtr l)
	{
		int result;
		try
		{
			CreateTeamRoomUIController createTeamRoomUIController = (CreateTeamRoomUIController)LuaObject.checkSelf(l);
			createTeamRoomUIController.m_luaExportHelper.AddGameFunctionTypeListItems();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D047 RID: 118855 RVA: 0x0091B3AC File Offset: 0x009195AC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int ClearGameFunctionTypeListItems(IntPtr l)
	{
		int result;
		try
		{
			CreateTeamRoomUIController createTeamRoomUIController = (CreateTeamRoomUIController)LuaObject.checkSelf(l);
			createTeamRoomUIController.m_luaExportHelper.ClearGameFunctionTypeListItems();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D048 RID: 118856 RVA: 0x0091B400 File Offset: 0x00919600
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int AddGameFunctionTypeListItem(IntPtr l)
	{
		int result;
		try
		{
			CreateTeamRoomUIController createTeamRoomUIController = (CreateTeamRoomUIController)LuaObject.checkSelf(l);
			string name;
			LuaObject.checkType(l, 2, out name);
			GameFunctionType gameFunctionType;
			LuaObject.checkEnum<GameFunctionType>(l, 3, out gameFunctionType);
			int chapterId;
			LuaObject.checkType(l, 4, out chapterId);
			bool isLocked;
			LuaObject.checkType(l, 5, out isLocked);
			createTeamRoomUIController.m_luaExportHelper.AddGameFunctionTypeListItem(name, gameFunctionType, chapterId, isLocked);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D049 RID: 118857 RVA: 0x0091B484 File Offset: 0x00919684
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int AddLocationListItems(IntPtr l)
	{
		int result;
		try
		{
			CreateTeamRoomUIController createTeamRoomUIController = (CreateTeamRoomUIController)LuaObject.checkSelf(l);
			GameFunctionType gameFunctionType;
			LuaObject.checkEnum<GameFunctionType>(l, 2, out gameFunctionType);
			int chapterId;
			LuaObject.checkType(l, 3, out chapterId);
			createTeamRoomUIController.m_luaExportHelper.AddLocationListItems(gameFunctionType, chapterId);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D04A RID: 118858 RVA: 0x0091B4F0 File Offset: 0x009196F0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int ClearLocationListItems(IntPtr l)
	{
		int result;
		try
		{
			CreateTeamRoomUIController createTeamRoomUIController = (CreateTeamRoomUIController)LuaObject.checkSelf(l);
			createTeamRoomUIController.m_luaExportHelper.ClearLocationListItems();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D04B RID: 118859 RVA: 0x0091B544 File Offset: 0x00919744
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int AddLocationListItem(IntPtr l)
	{
		int result;
		try
		{
			CreateTeamRoomUIController createTeamRoomUIController = (CreateTeamRoomUIController)LuaObject.checkSelf(l);
			string name;
			LuaObject.checkType(l, 2, out name);
			int id;
			LuaObject.checkType(l, 3, out id);
			bool isLocked;
			LuaObject.checkType(l, 4, out isLocked);
			createTeamRoomUIController.m_luaExportHelper.AddLocationListItem(name, id, isLocked);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D04C RID: 118860 RVA: 0x0091B5BC File Offset: 0x009197BC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int AddPlayerLevelMinListItem(IntPtr l)
	{
		int result;
		try
		{
			CreateTeamRoomUIController createTeamRoomUIController = (CreateTeamRoomUIController)LuaObject.checkSelf(l);
			int level;
			LuaObject.checkType(l, 2, out level);
			createTeamRoomUIController.m_luaExportHelper.AddPlayerLevelMinListItem(level);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D04D RID: 118861 RVA: 0x0091B618 File Offset: 0x00919818
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int ClearPlayerLevelMinListItems(IntPtr l)
	{
		int result;
		try
		{
			CreateTeamRoomUIController createTeamRoomUIController = (CreateTeamRoomUIController)LuaObject.checkSelf(l);
			createTeamRoomUIController.m_luaExportHelper.ClearPlayerLevelMinListItems();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D04E RID: 118862 RVA: 0x0091B66C File Offset: 0x0091986C
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int AddPlayerLevelMaxListItem(IntPtr l)
	{
		int result;
		try
		{
			CreateTeamRoomUIController createTeamRoomUIController = (CreateTeamRoomUIController)LuaObject.checkSelf(l);
			int level;
			LuaObject.checkType(l, 2, out level);
			createTeamRoomUIController.m_luaExportHelper.AddPlayerLevelMaxListItem(level);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D04F RID: 118863 RVA: 0x0091B6C8 File Offset: 0x009198C8
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int ClearPlayerLevelMaxListItems(IntPtr l)
	{
		int result;
		try
		{
			CreateTeamRoomUIController createTeamRoomUIController = (CreateTeamRoomUIController)LuaObject.checkSelf(l);
			createTeamRoomUIController.m_luaExportHelper.ClearPlayerLevelMaxListItems();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D050 RID: 118864 RVA: 0x0091B71C File Offset: 0x0091991C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int GetGameFunctionType(IntPtr l)
	{
		int result;
		try
		{
			CreateTeamRoomUIController createTeamRoomUIController = (CreateTeamRoomUIController)LuaObject.checkSelf(l);
			GameFunctionType gameFunctionType = createTeamRoomUIController.m_luaExportHelper.GetGameFunctionType();
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

	// Token: 0x0601D051 RID: 118865 RVA: 0x0091B778 File Offset: 0x00919978
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int GetLocationId(IntPtr l)
	{
		int result;
		try
		{
			CreateTeamRoomUIController createTeamRoomUIController = (CreateTeamRoomUIController)LuaObject.checkSelf(l);
			int locationId = createTeamRoomUIController.m_luaExportHelper.GetLocationId();
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

	// Token: 0x0601D052 RID: 118866 RVA: 0x0091B7D4 File Offset: 0x009199D4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int SetPlayerLevelMin(IntPtr l)
	{
		int result;
		try
		{
			CreateTeamRoomUIController createTeamRoomUIController = (CreateTeamRoomUIController)LuaObject.checkSelf(l);
			int playerLevelMin;
			LuaObject.checkType(l, 2, out playerLevelMin);
			createTeamRoomUIController.m_luaExportHelper.SetPlayerLevelMin(playerLevelMin);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D053 RID: 118867 RVA: 0x0091B830 File Offset: 0x00919A30
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int GetPlayerLevelMin(IntPtr l)
	{
		int result;
		try
		{
			CreateTeamRoomUIController createTeamRoomUIController = (CreateTeamRoomUIController)LuaObject.checkSelf(l);
			int playerLevelMin = createTeamRoomUIController.m_luaExportHelper.GetPlayerLevelMin();
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, playerLevelMin);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D054 RID: 118868 RVA: 0x0091B88C File Offset: 0x00919A8C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int SetPlayerLevelMax(IntPtr l)
	{
		int result;
		try
		{
			CreateTeamRoomUIController createTeamRoomUIController = (CreateTeamRoomUIController)LuaObject.checkSelf(l);
			int playerLevelMax;
			LuaObject.checkType(l, 2, out playerLevelMax);
			createTeamRoomUIController.m_luaExportHelper.SetPlayerLevelMax(playerLevelMax);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D055 RID: 118869 RVA: 0x0091B8E8 File Offset: 0x00919AE8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int GetPlayerLevelMax(IntPtr l)
	{
		int result;
		try
		{
			CreateTeamRoomUIController createTeamRoomUIController = (CreateTeamRoomUIController)LuaObject.checkSelf(l);
			int playerLevelMax = createTeamRoomUIController.m_luaExportHelper.GetPlayerLevelMax();
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, playerLevelMax);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D056 RID: 118870 RVA: 0x0091B944 File Offset: 0x00919B44
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int SetAuthority(IntPtr l)
	{
		int result;
		try
		{
			CreateTeamRoomUIController createTeamRoomUIController = (CreateTeamRoomUIController)LuaObject.checkSelf(l);
			TeamRoomAuthority authority;
			LuaObject.checkEnum<TeamRoomAuthority>(l, 2, out authority);
			createTeamRoomUIController.m_luaExportHelper.SetAuthority(authority);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D057 RID: 118871 RVA: 0x0091B9A0 File Offset: 0x00919BA0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int GetAuthority(IntPtr l)
	{
		int result;
		try
		{
			CreateTeamRoomUIController createTeamRoomUIController = (CreateTeamRoomUIController)LuaObject.checkSelf(l);
			TeamRoomAuthority authority = createTeamRoomUIController.m_luaExportHelper.GetAuthority();
			LuaObject.pushValue(l, true);
			LuaObject.pushEnum(l, (int)authority);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D058 RID: 118872 RVA: 0x0091B9FC File Offset: 0x00919BFC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int SaveTeamRoomSetting(IntPtr l)
	{
		int result;
		try
		{
			CreateTeamRoomUIController createTeamRoomUIController = (CreateTeamRoomUIController)LuaObject.checkSelf(l);
			TeamRoomSetting setting;
			LuaObject.checkType<TeamRoomSetting>(l, 2, out setting);
			createTeamRoomUIController.m_luaExportHelper.SaveTeamRoomSetting(setting);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D059 RID: 118873 RVA: 0x0091BA58 File Offset: 0x00919C58
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int OnCreateButtonClick(IntPtr l)
	{
		int result;
		try
		{
			CreateTeamRoomUIController createTeamRoomUIController = (CreateTeamRoomUIController)LuaObject.checkSelf(l);
			createTeamRoomUIController.m_luaExportHelper.OnCreateButtonClick();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D05A RID: 118874 RVA: 0x0091BAAC File Offset: 0x00919CAC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int OnCancelButtonClick(IntPtr l)
	{
		int result;
		try
		{
			CreateTeamRoomUIController createTeamRoomUIController = (CreateTeamRoomUIController)LuaObject.checkSelf(l);
			createTeamRoomUIController.m_luaExportHelper.OnCancelButtonClick();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D05B RID: 118875 RVA: 0x0091BB00 File Offset: 0x00919D00
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int OnBackgroundButtonClick(IntPtr l)
	{
		int result;
		try
		{
			CreateTeamRoomUIController createTeamRoomUIController = (CreateTeamRoomUIController)LuaObject.checkSelf(l);
			createTeamRoomUIController.m_luaExportHelper.OnBackgroundButtonClick();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D05C RID: 118876 RVA: 0x0091BB54 File Offset: 0x00919D54
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int GameFunctionTypeListItem_OnButtonClick(IntPtr l)
	{
		int result;
		try
		{
			CreateTeamRoomUIController createTeamRoomUIController = (CreateTeamRoomUIController)LuaObject.checkSelf(l);
			TeamRoomInfoListItemUIController ctrl;
			LuaObject.checkType<TeamRoomInfoListItemUIController>(l, 2, out ctrl);
			createTeamRoomUIController.m_luaExportHelper.GameFunctionTypeListItem_OnButtonClick(ctrl);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D05D RID: 118877 RVA: 0x0091BBB0 File Offset: 0x00919DB0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int LocationListItem_OnButtonClick(IntPtr l)
	{
		int result;
		try
		{
			CreateTeamRoomUIController createTeamRoomUIController = (CreateTeamRoomUIController)LuaObject.checkSelf(l);
			TeamRoomInfoListItemUIController ctrl;
			LuaObject.checkType<TeamRoomInfoListItemUIController>(l, 2, out ctrl);
			createTeamRoomUIController.m_luaExportHelper.LocationListItem_OnButtonClick(ctrl);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D05E RID: 118878 RVA: 0x0091BC0C File Offset: 0x00919E0C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int PlayerLevelMinListItem_OnButtonClick(IntPtr l)
	{
		int result;
		try
		{
			CreateTeamRoomUIController createTeamRoomUIController = (CreateTeamRoomUIController)LuaObject.checkSelf(l);
			TeamRoomInfoListItemUIController ctrl;
			LuaObject.checkType<TeamRoomInfoListItemUIController>(l, 2, out ctrl);
			createTeamRoomUIController.m_luaExportHelper.PlayerLevelMinListItem_OnButtonClick(ctrl);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D05F RID: 118879 RVA: 0x0091BC68 File Offset: 0x00919E68
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int PlayerLevelMaxListItem_OnButtonClick(IntPtr l)
	{
		int result;
		try
		{
			CreateTeamRoomUIController createTeamRoomUIController = (CreateTeamRoomUIController)LuaObject.checkSelf(l);
			TeamRoomInfoListItemUIController ctrl;
			LuaObject.checkType<TeamRoomInfoListItemUIController>(l, 2, out ctrl);
			createTeamRoomUIController.m_luaExportHelper.PlayerLevelMaxListItem_OnButtonClick(ctrl);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D060 RID: 118880 RVA: 0x0091BCC4 File Offset: 0x00919EC4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int GameFunctionTypeScrollSnapCenter_OnCenterItemChanged(IntPtr l)
	{
		int result;
		try
		{
			CreateTeamRoomUIController createTeamRoomUIController = (CreateTeamRoomUIController)LuaObject.checkSelf(l);
			int idx;
			LuaObject.checkType(l, 2, out idx);
			createTeamRoomUIController.m_luaExportHelper.GameFunctionTypeScrollSnapCenter_OnCenterItemChanged(idx);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D061 RID: 118881 RVA: 0x0091BD20 File Offset: 0x00919F20
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int GameFunctionTypeScrollRect_OnValueChaged(IntPtr l)
	{
		int result;
		try
		{
			CreateTeamRoomUIController createTeamRoomUIController = (CreateTeamRoomUIController)LuaObject.checkSelf(l);
			Vector2 value;
			LuaObject.checkType(l, 2, out value);
			createTeamRoomUIController.m_luaExportHelper.GameFunctionTypeScrollRect_OnValueChaged(value);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D062 RID: 118882 RVA: 0x0091BD7C File Offset: 0x00919F7C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int LocationScrollRect_OnValueChaged(IntPtr l)
	{
		int result;
		try
		{
			CreateTeamRoomUIController createTeamRoomUIController = (CreateTeamRoomUIController)LuaObject.checkSelf(l);
			Vector2 value;
			LuaObject.checkType(l, 2, out value);
			createTeamRoomUIController.m_luaExportHelper.LocationScrollRect_OnValueChaged(value);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D063 RID: 118883 RVA: 0x0091BDD8 File Offset: 0x00919FD8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int PlayerLevelMinScrollRect_OnValueChaged(IntPtr l)
	{
		int result;
		try
		{
			CreateTeamRoomUIController createTeamRoomUIController = (CreateTeamRoomUIController)LuaObject.checkSelf(l);
			Vector2 value;
			LuaObject.checkType(l, 2, out value);
			createTeamRoomUIController.m_luaExportHelper.PlayerLevelMinScrollRect_OnValueChaged(value);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D064 RID: 118884 RVA: 0x0091BE34 File Offset: 0x0091A034
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int PlayerLevelMaxScrollRect_OnValueChaged(IntPtr l)
	{
		int result;
		try
		{
			CreateTeamRoomUIController createTeamRoomUIController = (CreateTeamRoomUIController)LuaObject.checkSelf(l);
			Vector2 value;
			LuaObject.checkType(l, 2, out value);
			createTeamRoomUIController.m_luaExportHelper.PlayerLevelMaxScrollRect_OnValueChaged(value);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D065 RID: 118885 RVA: 0x0091BE90 File Offset: 0x0091A090
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int ScaleListItem(IntPtr l)
	{
		int result;
		try
		{
			CreateTeamRoomUIController createTeamRoomUIController = (CreateTeamRoomUIController)LuaObject.checkSelf(l);
			ScrollRect scrollRect;
			LuaObject.checkType<ScrollRect>(l, 2, out scrollRect);
			List<TeamRoomInfoListItemUIController> listItems;
			LuaObject.checkType<List<TeamRoomInfoListItemUIController>>(l, 3, out listItems);
			createTeamRoomUIController.m_luaExportHelper.ScaleListItem(scrollRect, listItems);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D066 RID: 118886 RVA: 0x0091BEFC File Offset: 0x0091A0FC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_Initlize(IntPtr l)
	{
		int result;
		try
		{
			CreateTeamRoomUIController createTeamRoomUIController = (CreateTeamRoomUIController)LuaObject.checkSelf(l);
			string ctrlName;
			LuaObject.checkType(l, 2, out ctrlName);
			bool bindNow;
			LuaObject.checkType(l, 3, out bindNow);
			createTeamRoomUIController.m_luaExportHelper.__callBase_Initlize(ctrlName, bindNow);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D067 RID: 118887 RVA: 0x0091BF68 File Offset: 0x0091A168
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_BindFields(IntPtr l)
	{
		int result;
		try
		{
			CreateTeamRoomUIController createTeamRoomUIController = (CreateTeamRoomUIController)LuaObject.checkSelf(l);
			createTeamRoomUIController.m_luaExportHelper.__callBase_BindFields();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D068 RID: 118888 RVA: 0x0091BFBC File Offset: 0x0091A1BC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_OnBindFiledsCompleted(IntPtr l)
	{
		int result;
		try
		{
			CreateTeamRoomUIController createTeamRoomUIController = (CreateTeamRoomUIController)LuaObject.checkSelf(l);
			createTeamRoomUIController.m_luaExportHelper.__callBase_OnBindFiledsCompleted();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D069 RID: 118889 RVA: 0x0091C010 File Offset: 0x0091A210
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_BindFieldImpl(IntPtr l)
	{
		int result;
		try
		{
			CreateTeamRoomUIController createTeamRoomUIController = (CreateTeamRoomUIController)LuaObject.checkSelf(l);
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
			UnityEngine.Object o = createTeamRoomUIController.m_luaExportHelper.__callBase_BindFieldImpl(fieldType, path, initState, fieldName, ctrlName, optional);
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

	// Token: 0x0601D06A RID: 118890 RVA: 0x0091C0B8 File Offset: 0x0091A2B8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_Clear(IntPtr l)
	{
		int result;
		try
		{
			CreateTeamRoomUIController createTeamRoomUIController = (CreateTeamRoomUIController)LuaObject.checkSelf(l);
			createTeamRoomUIController.m_luaExportHelper.__callBase_Clear();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D06B RID: 118891 RVA: 0x0091C10C File Offset: 0x0091A30C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_OnButtonClick(IntPtr l)
	{
		int result;
		try
		{
			CreateTeamRoomUIController createTeamRoomUIController = (CreateTeamRoomUIController)LuaObject.checkSelf(l);
			Button button;
			LuaObject.checkType<Button>(l, 2, out button);
			string fieldName;
			LuaObject.checkType(l, 3, out fieldName);
			createTeamRoomUIController.m_luaExportHelper.__callBase_OnButtonClick(button, fieldName);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D06C RID: 118892 RVA: 0x0091C178 File Offset: 0x0091A378
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
				CreateTeamRoomUIController createTeamRoomUIController = (CreateTeamRoomUIController)LuaObject.checkSelf(l);
				string[] fieldNames;
				LuaObject.checkArray<string>(l, 2, out fieldNames);
				Action<UIControllerBase> action;
				LuaObject.checkDelegate<Action<UIControllerBase>>(l, 3, out action);
				createTeamRoomUIController.m_luaExportHelper.__callBase_SetButtonClickListener(fieldNames, action);
				LuaObject.pushValue(l, true);
				result = 1;
			}
			else if (LuaObject.matchType(l, total, 2, typeof(string), typeof(Action<UIControllerBase>)))
			{
				CreateTeamRoomUIController createTeamRoomUIController2 = (CreateTeamRoomUIController)LuaObject.checkSelf(l);
				string fieldName;
				LuaObject.checkType(l, 2, out fieldName);
				Action<UIControllerBase> action2;
				LuaObject.checkDelegate<Action<UIControllerBase>>(l, 3, out action2);
				createTeamRoomUIController2.m_luaExportHelper.__callBase_SetButtonClickListener(fieldName, action2);
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

	// Token: 0x0601D06D RID: 118893 RVA: 0x0091C288 File Offset: 0x0091A488
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_SetButtonDoubleClickListener(IntPtr l)
	{
		int result;
		try
		{
			CreateTeamRoomUIController createTeamRoomUIController = (CreateTeamRoomUIController)LuaObject.checkSelf(l);
			string fieldName;
			LuaObject.checkType(l, 2, out fieldName);
			Action<UIControllerBase> action;
			LuaObject.checkDelegate<Action<UIControllerBase>>(l, 3, out action);
			createTeamRoomUIController.m_luaExportHelper.__callBase_SetButtonDoubleClickListener(fieldName, action);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D06E RID: 118894 RVA: 0x0091C2F4 File Offset: 0x0091A4F4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_SetButtonLongPressStartListener(IntPtr l)
	{
		int result;
		try
		{
			CreateTeamRoomUIController createTeamRoomUIController = (CreateTeamRoomUIController)LuaObject.checkSelf(l);
			string fieldName;
			LuaObject.checkType(l, 2, out fieldName);
			Action<UIControllerBase> action;
			LuaObject.checkDelegate<Action<UIControllerBase>>(l, 3, out action);
			createTeamRoomUIController.m_luaExportHelper.__callBase_SetButtonLongPressStartListener(fieldName, action);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D06F RID: 118895 RVA: 0x0091C360 File Offset: 0x0091A560
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_SetButtonLongPressingListener(IntPtr l)
	{
		int result;
		try
		{
			CreateTeamRoomUIController createTeamRoomUIController = (CreateTeamRoomUIController)LuaObject.checkSelf(l);
			string fieldName;
			LuaObject.checkType(l, 2, out fieldName);
			Action<UIControllerBase> action;
			LuaObject.checkDelegate<Action<UIControllerBase>>(l, 3, out action);
			createTeamRoomUIController.m_luaExportHelper.__callBase_SetButtonLongPressingListener(fieldName, action);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D070 RID: 118896 RVA: 0x0091C3CC File Offset: 0x0091A5CC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_SetButtonLongPressEndListener(IntPtr l)
	{
		int result;
		try
		{
			CreateTeamRoomUIController createTeamRoomUIController = (CreateTeamRoomUIController)LuaObject.checkSelf(l);
			string fieldName;
			LuaObject.checkType(l, 2, out fieldName);
			Action<UIControllerBase> action;
			LuaObject.checkDelegate<Action<UIControllerBase>>(l, 3, out action);
			createTeamRoomUIController.m_luaExportHelper.__callBase_SetButtonLongPressEndListener(fieldName, action);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D071 RID: 118897 RVA: 0x0091C438 File Offset: 0x0091A638
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
				CreateTeamRoomUIController createTeamRoomUIController = (CreateTeamRoomUIController)LuaObject.checkSelf(l);
				string[] fieldNames;
				LuaObject.checkArray<string>(l, 2, out fieldNames);
				Action<UIControllerBase, bool> action;
				LuaObject.checkDelegate<Action<UIControllerBase, bool>>(l, 3, out action);
				createTeamRoomUIController.m_luaExportHelper.__callBase_SetToggleValueChangedListener(fieldNames, action);
				LuaObject.pushValue(l, true);
				result = 1;
			}
			else if (LuaObject.matchType(l, total, 2, typeof(string), typeof(Action<UIControllerBase, bool>)))
			{
				CreateTeamRoomUIController createTeamRoomUIController2 = (CreateTeamRoomUIController)LuaObject.checkSelf(l);
				string fieldName;
				LuaObject.checkType(l, 2, out fieldName);
				Action<UIControllerBase, bool> action2;
				LuaObject.checkDelegate<Action<UIControllerBase, bool>>(l, 3, out action2);
				createTeamRoomUIController2.m_luaExportHelper.__callBase_SetToggleValueChangedListener(fieldName, action2);
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

	// Token: 0x0601D072 RID: 118898 RVA: 0x0091C548 File Offset: 0x0091A748
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int __callBase_ToString(IntPtr l)
	{
		int result;
		try
		{
			CreateTeamRoomUIController createTeamRoomUIController = (CreateTeamRoomUIController)LuaObject.checkSelf(l);
			string s = createTeamRoomUIController.m_luaExportHelper.__callBase_ToString();
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

	// Token: 0x0601D073 RID: 118899 RVA: 0x0091C5A4 File Offset: 0x0091A7A4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callDele_EventOnCreateTeamRoom(IntPtr l)
	{
		int result;
		try
		{
			CreateTeamRoomUIController createTeamRoomUIController = (CreateTeamRoomUIController)LuaObject.checkSelf(l);
			TeamRoomSetting obj;
			LuaObject.checkType<TeamRoomSetting>(l, 2, out obj);
			createTeamRoomUIController.m_luaExportHelper.__callDele_EventOnCreateTeamRoom(obj);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D074 RID: 118900 RVA: 0x0091C600 File Offset: 0x0091A800
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __clearDele_EventOnCreateTeamRoom(IntPtr l)
	{
		int result;
		try
		{
			CreateTeamRoomUIController createTeamRoomUIController = (CreateTeamRoomUIController)LuaObject.checkSelf(l);
			TeamRoomSetting obj;
			LuaObject.checkType<TeamRoomSetting>(l, 2, out obj);
			createTeamRoomUIController.m_luaExportHelper.__clearDele_EventOnCreateTeamRoom(obj);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D075 RID: 118901 RVA: 0x0091C65C File Offset: 0x0091A85C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int GetRoomInfoListItemIndexByValue_s(IntPtr l)
	{
		int result;
		try
		{
			List<TeamRoomInfoListItemUIController> list;
			LuaObject.checkType<List<TeamRoomInfoListItemUIController>>(l, 1, out list);
			int value;
			LuaObject.checkType(l, 2, out value);
			int value2;
			LuaObject.checkType(l, 3, out value2);
			int roomInfoListItemIndexByValue = CreateTeamRoomUIController.LuaExportHelper.GetRoomInfoListItemIndexByValue(list, value, value2);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, roomInfoListItemIndexByValue);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D076 RID: 118902 RVA: 0x0091C6CC File Offset: 0x0091A8CC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_EventOnCreateTeamRoom(IntPtr l)
	{
		int result;
		try
		{
			CreateTeamRoomUIController createTeamRoomUIController = (CreateTeamRoomUIController)LuaObject.checkSelf(l);
			Action<TeamRoomSetting> value;
			int num = LuaObject.checkDelegate<Action<TeamRoomSetting>>(l, 2, out value);
			if (num != 0)
			{
				if (num == 1)
				{
					createTeamRoomUIController.EventOnCreateTeamRoom += value;
				}
				else if (num == 2)
				{
					createTeamRoomUIController.EventOnCreateTeamRoom -= value;
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

	// Token: 0x0601D077 RID: 118903 RVA: 0x0091C74C File Offset: 0x0091A94C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_uiStateController(IntPtr l)
	{
		int result;
		try
		{
			CreateTeamRoomUIController createTeamRoomUIController = (CreateTeamRoomUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, createTeamRoomUIController.m_luaExportHelper.m_uiStateController);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D078 RID: 118904 RVA: 0x0091C7A4 File Offset: 0x0091A9A4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_uiStateController(IntPtr l)
	{
		int result;
		try
		{
			CreateTeamRoomUIController createTeamRoomUIController = (CreateTeamRoomUIController)LuaObject.checkSelf(l);
			CommonUIStateController uiStateController;
			LuaObject.checkType<CommonUIStateController>(l, 2, out uiStateController);
			createTeamRoomUIController.m_luaExportHelper.m_uiStateController = uiStateController;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D079 RID: 118905 RVA: 0x0091C800 File Offset: 0x0091AA00
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_m_createButton(IntPtr l)
	{
		int result;
		try
		{
			CreateTeamRoomUIController createTeamRoomUIController = (CreateTeamRoomUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, createTeamRoomUIController.m_luaExportHelper.m_createButton);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D07A RID: 118906 RVA: 0x0091C858 File Offset: 0x0091AA58
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_createButton(IntPtr l)
	{
		int result;
		try
		{
			CreateTeamRoomUIController createTeamRoomUIController = (CreateTeamRoomUIController)LuaObject.checkSelf(l);
			Button createButton;
			LuaObject.checkType<Button>(l, 2, out createButton);
			createTeamRoomUIController.m_luaExportHelper.m_createButton = createButton;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D07B RID: 118907 RVA: 0x0091C8B4 File Offset: 0x0091AAB4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_cancelButton(IntPtr l)
	{
		int result;
		try
		{
			CreateTeamRoomUIController createTeamRoomUIController = (CreateTeamRoomUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, createTeamRoomUIController.m_luaExportHelper.m_cancelButton);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D07C RID: 118908 RVA: 0x0091C90C File Offset: 0x0091AB0C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_cancelButton(IntPtr l)
	{
		int result;
		try
		{
			CreateTeamRoomUIController createTeamRoomUIController = (CreateTeamRoomUIController)LuaObject.checkSelf(l);
			Button cancelButton;
			LuaObject.checkType<Button>(l, 2, out cancelButton);
			createTeamRoomUIController.m_luaExportHelper.m_cancelButton = cancelButton;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D07D RID: 118909 RVA: 0x0091C968 File Offset: 0x0091AB68
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_authorityAllToggle(IntPtr l)
	{
		int result;
		try
		{
			CreateTeamRoomUIController createTeamRoomUIController = (CreateTeamRoomUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, createTeamRoomUIController.m_luaExportHelper.m_authorityAllToggle);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D07E RID: 118910 RVA: 0x0091C9C0 File Offset: 0x0091ABC0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_authorityAllToggle(IntPtr l)
	{
		int result;
		try
		{
			CreateTeamRoomUIController createTeamRoomUIController = (CreateTeamRoomUIController)LuaObject.checkSelf(l);
			Toggle authorityAllToggle;
			LuaObject.checkType<Toggle>(l, 2, out authorityAllToggle);
			createTeamRoomUIController.m_luaExportHelper.m_authorityAllToggle = authorityAllToggle;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D07F RID: 118911 RVA: 0x0091CA1C File Offset: 0x0091AC1C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_authorityFriendToggle(IntPtr l)
	{
		int result;
		try
		{
			CreateTeamRoomUIController createTeamRoomUIController = (CreateTeamRoomUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, createTeamRoomUIController.m_luaExportHelper.m_authorityFriendToggle);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D080 RID: 118912 RVA: 0x0091CA74 File Offset: 0x0091AC74
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_authorityFriendToggle(IntPtr l)
	{
		int result;
		try
		{
			CreateTeamRoomUIController createTeamRoomUIController = (CreateTeamRoomUIController)LuaObject.checkSelf(l);
			Toggle authorityFriendToggle;
			LuaObject.checkType<Toggle>(l, 2, out authorityFriendToggle);
			createTeamRoomUIController.m_luaExportHelper.m_authorityFriendToggle = authorityFriendToggle;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D081 RID: 118913 RVA: 0x0091CAD0 File Offset: 0x0091ACD0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_authorityNonPublicToggle(IntPtr l)
	{
		int result;
		try
		{
			CreateTeamRoomUIController createTeamRoomUIController = (CreateTeamRoomUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, createTeamRoomUIController.m_luaExportHelper.m_authorityNonPublicToggle);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D082 RID: 118914 RVA: 0x0091CB28 File Offset: 0x0091AD28
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_m_authorityNonPublicToggle(IntPtr l)
	{
		int result;
		try
		{
			CreateTeamRoomUIController createTeamRoomUIController = (CreateTeamRoomUIController)LuaObject.checkSelf(l);
			Toggle authorityNonPublicToggle;
			LuaObject.checkType<Toggle>(l, 2, out authorityNonPublicToggle);
			createTeamRoomUIController.m_luaExportHelper.m_authorityNonPublicToggle = authorityNonPublicToggle;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D083 RID: 118915 RVA: 0x0091CB84 File Offset: 0x0091AD84
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_gameFunctionTypeScrollRect(IntPtr l)
	{
		int result;
		try
		{
			CreateTeamRoomUIController createTeamRoomUIController = (CreateTeamRoomUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, createTeamRoomUIController.m_luaExportHelper.m_gameFunctionTypeScrollRect);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D084 RID: 118916 RVA: 0x0091CBDC File Offset: 0x0091ADDC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_gameFunctionTypeScrollRect(IntPtr l)
	{
		int result;
		try
		{
			CreateTeamRoomUIController createTeamRoomUIController = (CreateTeamRoomUIController)LuaObject.checkSelf(l);
			ScrollRect gameFunctionTypeScrollRect;
			LuaObject.checkType<ScrollRect>(l, 2, out gameFunctionTypeScrollRect);
			createTeamRoomUIController.m_luaExportHelper.m_gameFunctionTypeScrollRect = gameFunctionTypeScrollRect;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D085 RID: 118917 RVA: 0x0091CC38 File Offset: 0x0091AE38
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_locationScrollRect(IntPtr l)
	{
		int result;
		try
		{
			CreateTeamRoomUIController createTeamRoomUIController = (CreateTeamRoomUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, createTeamRoomUIController.m_luaExportHelper.m_locationScrollRect);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D086 RID: 118918 RVA: 0x0091CC90 File Offset: 0x0091AE90
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_locationScrollRect(IntPtr l)
	{
		int result;
		try
		{
			CreateTeamRoomUIController createTeamRoomUIController = (CreateTeamRoomUIController)LuaObject.checkSelf(l);
			ScrollRect locationScrollRect;
			LuaObject.checkType<ScrollRect>(l, 2, out locationScrollRect);
			createTeamRoomUIController.m_luaExportHelper.m_locationScrollRect = locationScrollRect;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D087 RID: 118919 RVA: 0x0091CCEC File Offset: 0x0091AEEC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_playerLevelMinScrollRect(IntPtr l)
	{
		int result;
		try
		{
			CreateTeamRoomUIController createTeamRoomUIController = (CreateTeamRoomUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, createTeamRoomUIController.m_luaExportHelper.m_playerLevelMinScrollRect);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D088 RID: 118920 RVA: 0x0091CD44 File Offset: 0x0091AF44
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_playerLevelMinScrollRect(IntPtr l)
	{
		int result;
		try
		{
			CreateTeamRoomUIController createTeamRoomUIController = (CreateTeamRoomUIController)LuaObject.checkSelf(l);
			ScrollRect playerLevelMinScrollRect;
			LuaObject.checkType<ScrollRect>(l, 2, out playerLevelMinScrollRect);
			createTeamRoomUIController.m_luaExportHelper.m_playerLevelMinScrollRect = playerLevelMinScrollRect;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D089 RID: 118921 RVA: 0x0091CDA0 File Offset: 0x0091AFA0
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_m_playerLevelMaxScrollRect(IntPtr l)
	{
		int result;
		try
		{
			CreateTeamRoomUIController createTeamRoomUIController = (CreateTeamRoomUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, createTeamRoomUIController.m_luaExportHelper.m_playerLevelMaxScrollRect);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D08A RID: 118922 RVA: 0x0091CDF8 File Offset: 0x0091AFF8
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_m_playerLevelMaxScrollRect(IntPtr l)
	{
		int result;
		try
		{
			CreateTeamRoomUIController createTeamRoomUIController = (CreateTeamRoomUIController)LuaObject.checkSelf(l);
			ScrollRect playerLevelMaxScrollRect;
			LuaObject.checkType<ScrollRect>(l, 2, out playerLevelMaxScrollRect);
			createTeamRoomUIController.m_luaExportHelper.m_playerLevelMaxScrollRect = playerLevelMaxScrollRect;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D08B RID: 118923 RVA: 0x0091CE54 File Offset: 0x0091B054
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_prefabsGameObject(IntPtr l)
	{
		int result;
		try
		{
			CreateTeamRoomUIController createTeamRoomUIController = (CreateTeamRoomUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, createTeamRoomUIController.m_luaExportHelper.m_prefabsGameObject);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D08C RID: 118924 RVA: 0x0091CEAC File Offset: 0x0091B0AC
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_m_prefabsGameObject(IntPtr l)
	{
		int result;
		try
		{
			CreateTeamRoomUIController createTeamRoomUIController = (CreateTeamRoomUIController)LuaObject.checkSelf(l);
			GameObject prefabsGameObject;
			LuaObject.checkType<GameObject>(l, 2, out prefabsGameObject);
			createTeamRoomUIController.m_luaExportHelper.m_prefabsGameObject = prefabsGameObject;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D08D RID: 118925 RVA: 0x0091CF08 File Offset: 0x0091B108
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_m_roomInfoListItemPrefab(IntPtr l)
	{
		int result;
		try
		{
			CreateTeamRoomUIController createTeamRoomUIController = (CreateTeamRoomUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, createTeamRoomUIController.m_luaExportHelper.m_roomInfoListItemPrefab);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D08E RID: 118926 RVA: 0x0091CF60 File Offset: 0x0091B160
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_roomInfoListItemPrefab(IntPtr l)
	{
		int result;
		try
		{
			CreateTeamRoomUIController createTeamRoomUIController = (CreateTeamRoomUIController)LuaObject.checkSelf(l);
			GameObject roomInfoListItemPrefab;
			LuaObject.checkType<GameObject>(l, 2, out roomInfoListItemPrefab);
			createTeamRoomUIController.m_luaExportHelper.m_roomInfoListItemPrefab = roomInfoListItemPrefab;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D08F RID: 118927 RVA: 0x0091CFBC File Offset: 0x0091B1BC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_gameFunctionTypeScrollSnapCenter(IntPtr l)
	{
		int result;
		try
		{
			CreateTeamRoomUIController createTeamRoomUIController = (CreateTeamRoomUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, createTeamRoomUIController.m_luaExportHelper.m_gameFunctionTypeScrollSnapCenter);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D090 RID: 118928 RVA: 0x0091D014 File Offset: 0x0091B214
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_gameFunctionTypeScrollSnapCenter(IntPtr l)
	{
		int result;
		try
		{
			CreateTeamRoomUIController createTeamRoomUIController = (CreateTeamRoomUIController)LuaObject.checkSelf(l);
			ScrollSnapCenter gameFunctionTypeScrollSnapCenter;
			LuaObject.checkType<ScrollSnapCenter>(l, 2, out gameFunctionTypeScrollSnapCenter);
			createTeamRoomUIController.m_luaExportHelper.m_gameFunctionTypeScrollSnapCenter = gameFunctionTypeScrollSnapCenter;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D091 RID: 118929 RVA: 0x0091D070 File Offset: 0x0091B270
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_m_locationScrollSnapCenter(IntPtr l)
	{
		int result;
		try
		{
			CreateTeamRoomUIController createTeamRoomUIController = (CreateTeamRoomUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, createTeamRoomUIController.m_luaExportHelper.m_locationScrollSnapCenter);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D092 RID: 118930 RVA: 0x0091D0C8 File Offset: 0x0091B2C8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_locationScrollSnapCenter(IntPtr l)
	{
		int result;
		try
		{
			CreateTeamRoomUIController createTeamRoomUIController = (CreateTeamRoomUIController)LuaObject.checkSelf(l);
			ScrollSnapCenter locationScrollSnapCenter;
			LuaObject.checkType<ScrollSnapCenter>(l, 2, out locationScrollSnapCenter);
			createTeamRoomUIController.m_luaExportHelper.m_locationScrollSnapCenter = locationScrollSnapCenter;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D093 RID: 118931 RVA: 0x0091D124 File Offset: 0x0091B324
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_playerLevelMinScrollSnapCenter(IntPtr l)
	{
		int result;
		try
		{
			CreateTeamRoomUIController createTeamRoomUIController = (CreateTeamRoomUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, createTeamRoomUIController.m_luaExportHelper.m_playerLevelMinScrollSnapCenter);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D094 RID: 118932 RVA: 0x0091D17C File Offset: 0x0091B37C
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_m_playerLevelMinScrollSnapCenter(IntPtr l)
	{
		int result;
		try
		{
			CreateTeamRoomUIController createTeamRoomUIController = (CreateTeamRoomUIController)LuaObject.checkSelf(l);
			ScrollSnapCenter playerLevelMinScrollSnapCenter;
			LuaObject.checkType<ScrollSnapCenter>(l, 2, out playerLevelMinScrollSnapCenter);
			createTeamRoomUIController.m_luaExportHelper.m_playerLevelMinScrollSnapCenter = playerLevelMinScrollSnapCenter;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D095 RID: 118933 RVA: 0x0091D1D8 File Offset: 0x0091B3D8
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_m_playerLevelMaxScrollSnapCenter(IntPtr l)
	{
		int result;
		try
		{
			CreateTeamRoomUIController createTeamRoomUIController = (CreateTeamRoomUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, createTeamRoomUIController.m_luaExportHelper.m_playerLevelMaxScrollSnapCenter);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D096 RID: 118934 RVA: 0x0091D230 File Offset: 0x0091B430
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_playerLevelMaxScrollSnapCenter(IntPtr l)
	{
		int result;
		try
		{
			CreateTeamRoomUIController createTeamRoomUIController = (CreateTeamRoomUIController)LuaObject.checkSelf(l);
			ScrollSnapCenter playerLevelMaxScrollSnapCenter;
			LuaObject.checkType<ScrollSnapCenter>(l, 2, out playerLevelMaxScrollSnapCenter);
			createTeamRoomUIController.m_luaExportHelper.m_playerLevelMaxScrollSnapCenter = playerLevelMaxScrollSnapCenter;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D097 RID: 118935 RVA: 0x0091D28C File Offset: 0x0091B48C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_gameFunctionTypeListItems(IntPtr l)
	{
		int result;
		try
		{
			CreateTeamRoomUIController createTeamRoomUIController = (CreateTeamRoomUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, createTeamRoomUIController.m_luaExportHelper.m_gameFunctionTypeListItems);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D098 RID: 118936 RVA: 0x0091D2E4 File Offset: 0x0091B4E4
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_m_gameFunctionTypeListItems(IntPtr l)
	{
		int result;
		try
		{
			CreateTeamRoomUIController createTeamRoomUIController = (CreateTeamRoomUIController)LuaObject.checkSelf(l);
			List<TeamRoomInfoListItemUIController> gameFunctionTypeListItems;
			LuaObject.checkType<List<TeamRoomInfoListItemUIController>>(l, 2, out gameFunctionTypeListItems);
			createTeamRoomUIController.m_luaExportHelper.m_gameFunctionTypeListItems = gameFunctionTypeListItems;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D099 RID: 118937 RVA: 0x0091D340 File Offset: 0x0091B540
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_locationListItems(IntPtr l)
	{
		int result;
		try
		{
			CreateTeamRoomUIController createTeamRoomUIController = (CreateTeamRoomUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, createTeamRoomUIController.m_luaExportHelper.m_locationListItems);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D09A RID: 118938 RVA: 0x0091D398 File Offset: 0x0091B598
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_m_locationListItems(IntPtr l)
	{
		int result;
		try
		{
			CreateTeamRoomUIController createTeamRoomUIController = (CreateTeamRoomUIController)LuaObject.checkSelf(l);
			List<TeamRoomInfoListItemUIController> locationListItems;
			LuaObject.checkType<List<TeamRoomInfoListItemUIController>>(l, 2, out locationListItems);
			createTeamRoomUIController.m_luaExportHelper.m_locationListItems = locationListItems;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D09B RID: 118939 RVA: 0x0091D3F4 File Offset: 0x0091B5F4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_playerLevelMinListItems(IntPtr l)
	{
		int result;
		try
		{
			CreateTeamRoomUIController createTeamRoomUIController = (CreateTeamRoomUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, createTeamRoomUIController.m_luaExportHelper.m_playerLevelMinListItems);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D09C RID: 118940 RVA: 0x0091D44C File Offset: 0x0091B64C
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_m_playerLevelMinListItems(IntPtr l)
	{
		int result;
		try
		{
			CreateTeamRoomUIController createTeamRoomUIController = (CreateTeamRoomUIController)LuaObject.checkSelf(l);
			List<TeamRoomInfoListItemUIController> playerLevelMinListItems;
			LuaObject.checkType<List<TeamRoomInfoListItemUIController>>(l, 2, out playerLevelMinListItems);
			createTeamRoomUIController.m_luaExportHelper.m_playerLevelMinListItems = playerLevelMinListItems;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D09D RID: 118941 RVA: 0x0091D4A8 File Offset: 0x0091B6A8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_playerLevelMaxListItems(IntPtr l)
	{
		int result;
		try
		{
			CreateTeamRoomUIController createTeamRoomUIController = (CreateTeamRoomUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, createTeamRoomUIController.m_luaExportHelper.m_playerLevelMaxListItems);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D09E RID: 118942 RVA: 0x0091D500 File Offset: 0x0091B700
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_playerLevelMaxListItems(IntPtr l)
	{
		int result;
		try
		{
			CreateTeamRoomUIController createTeamRoomUIController = (CreateTeamRoomUIController)LuaObject.checkSelf(l);
			List<TeamRoomInfoListItemUIController> playerLevelMaxListItems;
			LuaObject.checkType<List<TeamRoomInfoListItemUIController>>(l, 2, out playerLevelMaxListItems);
			createTeamRoomUIController.m_luaExportHelper.m_playerLevelMaxListItems = playerLevelMaxListItems;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D09F RID: 118943 RVA: 0x0091D55C File Offset: 0x0091B75C
	[Preserve]
	public static void reg(IntPtr l)
	{
		LuaObject.getTypeTable(l, "BlackJack.ProjectL.UI.CreateTeamRoomUIController");
		if (Lua_BlackJack_ProjectL_UI_CreateTeamRoomUIController.<>f__mg$cache0 == null)
		{
			Lua_BlackJack_ProjectL_UI_CreateTeamRoomUIController.<>f__mg$cache0 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_CreateTeamRoomUIController.Open);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_CreateTeamRoomUIController.<>f__mg$cache0);
		if (Lua_BlackJack_ProjectL_UI_CreateTeamRoomUIController.<>f__mg$cache1 == null)
		{
			Lua_BlackJack_ProjectL_UI_CreateTeamRoomUIController.<>f__mg$cache1 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_CreateTeamRoomUIController.Close);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_CreateTeamRoomUIController.<>f__mg$cache1);
		if (Lua_BlackJack_ProjectL_UI_CreateTeamRoomUIController.<>f__mg$cache2 == null)
		{
			Lua_BlackJack_ProjectL_UI_CreateTeamRoomUIController.<>f__mg$cache2 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_CreateTeamRoomUIController.SetGameFunctionType);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_CreateTeamRoomUIController.<>f__mg$cache2);
		if (Lua_BlackJack_ProjectL_UI_CreateTeamRoomUIController.<>f__mg$cache3 == null)
		{
			Lua_BlackJack_ProjectL_UI_CreateTeamRoomUIController.<>f__mg$cache3 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_CreateTeamRoomUIController.SetLocation);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_CreateTeamRoomUIController.<>f__mg$cache3);
		if (Lua_BlackJack_ProjectL_UI_CreateTeamRoomUIController.<>f__mg$cache4 == null)
		{
			Lua_BlackJack_ProjectL_UI_CreateTeamRoomUIController.<>f__mg$cache4 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_CreateTeamRoomUIController.OnBindFiledsCompleted);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_CreateTeamRoomUIController.<>f__mg$cache4);
		if (Lua_BlackJack_ProjectL_UI_CreateTeamRoomUIController.<>f__mg$cache5 == null)
		{
			Lua_BlackJack_ProjectL_UI_CreateTeamRoomUIController.<>f__mg$cache5 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_CreateTeamRoomUIController.AddGameFunctionTypeListItems);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_CreateTeamRoomUIController.<>f__mg$cache5);
		if (Lua_BlackJack_ProjectL_UI_CreateTeamRoomUIController.<>f__mg$cache6 == null)
		{
			Lua_BlackJack_ProjectL_UI_CreateTeamRoomUIController.<>f__mg$cache6 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_CreateTeamRoomUIController.ClearGameFunctionTypeListItems);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_CreateTeamRoomUIController.<>f__mg$cache6);
		if (Lua_BlackJack_ProjectL_UI_CreateTeamRoomUIController.<>f__mg$cache7 == null)
		{
			Lua_BlackJack_ProjectL_UI_CreateTeamRoomUIController.<>f__mg$cache7 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_CreateTeamRoomUIController.AddGameFunctionTypeListItem);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_CreateTeamRoomUIController.<>f__mg$cache7);
		if (Lua_BlackJack_ProjectL_UI_CreateTeamRoomUIController.<>f__mg$cache8 == null)
		{
			Lua_BlackJack_ProjectL_UI_CreateTeamRoomUIController.<>f__mg$cache8 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_CreateTeamRoomUIController.AddLocationListItems);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_CreateTeamRoomUIController.<>f__mg$cache8);
		if (Lua_BlackJack_ProjectL_UI_CreateTeamRoomUIController.<>f__mg$cache9 == null)
		{
			Lua_BlackJack_ProjectL_UI_CreateTeamRoomUIController.<>f__mg$cache9 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_CreateTeamRoomUIController.ClearLocationListItems);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_CreateTeamRoomUIController.<>f__mg$cache9);
		if (Lua_BlackJack_ProjectL_UI_CreateTeamRoomUIController.<>f__mg$cacheA == null)
		{
			Lua_BlackJack_ProjectL_UI_CreateTeamRoomUIController.<>f__mg$cacheA = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_CreateTeamRoomUIController.AddLocationListItem);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_CreateTeamRoomUIController.<>f__mg$cacheA);
		if (Lua_BlackJack_ProjectL_UI_CreateTeamRoomUIController.<>f__mg$cacheB == null)
		{
			Lua_BlackJack_ProjectL_UI_CreateTeamRoomUIController.<>f__mg$cacheB = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_CreateTeamRoomUIController.AddPlayerLevelMinListItem);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_CreateTeamRoomUIController.<>f__mg$cacheB);
		if (Lua_BlackJack_ProjectL_UI_CreateTeamRoomUIController.<>f__mg$cacheC == null)
		{
			Lua_BlackJack_ProjectL_UI_CreateTeamRoomUIController.<>f__mg$cacheC = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_CreateTeamRoomUIController.ClearPlayerLevelMinListItems);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_CreateTeamRoomUIController.<>f__mg$cacheC);
		if (Lua_BlackJack_ProjectL_UI_CreateTeamRoomUIController.<>f__mg$cacheD == null)
		{
			Lua_BlackJack_ProjectL_UI_CreateTeamRoomUIController.<>f__mg$cacheD = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_CreateTeamRoomUIController.AddPlayerLevelMaxListItem);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_CreateTeamRoomUIController.<>f__mg$cacheD);
		if (Lua_BlackJack_ProjectL_UI_CreateTeamRoomUIController.<>f__mg$cacheE == null)
		{
			Lua_BlackJack_ProjectL_UI_CreateTeamRoomUIController.<>f__mg$cacheE = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_CreateTeamRoomUIController.ClearPlayerLevelMaxListItems);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_CreateTeamRoomUIController.<>f__mg$cacheE);
		if (Lua_BlackJack_ProjectL_UI_CreateTeamRoomUIController.<>f__mg$cacheF == null)
		{
			Lua_BlackJack_ProjectL_UI_CreateTeamRoomUIController.<>f__mg$cacheF = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_CreateTeamRoomUIController.GetGameFunctionType);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_CreateTeamRoomUIController.<>f__mg$cacheF);
		if (Lua_BlackJack_ProjectL_UI_CreateTeamRoomUIController.<>f__mg$cache10 == null)
		{
			Lua_BlackJack_ProjectL_UI_CreateTeamRoomUIController.<>f__mg$cache10 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_CreateTeamRoomUIController.GetLocationId);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_CreateTeamRoomUIController.<>f__mg$cache10);
		if (Lua_BlackJack_ProjectL_UI_CreateTeamRoomUIController.<>f__mg$cache11 == null)
		{
			Lua_BlackJack_ProjectL_UI_CreateTeamRoomUIController.<>f__mg$cache11 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_CreateTeamRoomUIController.SetPlayerLevelMin);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_CreateTeamRoomUIController.<>f__mg$cache11);
		if (Lua_BlackJack_ProjectL_UI_CreateTeamRoomUIController.<>f__mg$cache12 == null)
		{
			Lua_BlackJack_ProjectL_UI_CreateTeamRoomUIController.<>f__mg$cache12 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_CreateTeamRoomUIController.GetPlayerLevelMin);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_CreateTeamRoomUIController.<>f__mg$cache12);
		if (Lua_BlackJack_ProjectL_UI_CreateTeamRoomUIController.<>f__mg$cache13 == null)
		{
			Lua_BlackJack_ProjectL_UI_CreateTeamRoomUIController.<>f__mg$cache13 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_CreateTeamRoomUIController.SetPlayerLevelMax);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_CreateTeamRoomUIController.<>f__mg$cache13);
		if (Lua_BlackJack_ProjectL_UI_CreateTeamRoomUIController.<>f__mg$cache14 == null)
		{
			Lua_BlackJack_ProjectL_UI_CreateTeamRoomUIController.<>f__mg$cache14 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_CreateTeamRoomUIController.GetPlayerLevelMax);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_CreateTeamRoomUIController.<>f__mg$cache14);
		if (Lua_BlackJack_ProjectL_UI_CreateTeamRoomUIController.<>f__mg$cache15 == null)
		{
			Lua_BlackJack_ProjectL_UI_CreateTeamRoomUIController.<>f__mg$cache15 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_CreateTeamRoomUIController.SetAuthority);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_CreateTeamRoomUIController.<>f__mg$cache15);
		if (Lua_BlackJack_ProjectL_UI_CreateTeamRoomUIController.<>f__mg$cache16 == null)
		{
			Lua_BlackJack_ProjectL_UI_CreateTeamRoomUIController.<>f__mg$cache16 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_CreateTeamRoomUIController.GetAuthority);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_CreateTeamRoomUIController.<>f__mg$cache16);
		if (Lua_BlackJack_ProjectL_UI_CreateTeamRoomUIController.<>f__mg$cache17 == null)
		{
			Lua_BlackJack_ProjectL_UI_CreateTeamRoomUIController.<>f__mg$cache17 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_CreateTeamRoomUIController.SaveTeamRoomSetting);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_CreateTeamRoomUIController.<>f__mg$cache17);
		if (Lua_BlackJack_ProjectL_UI_CreateTeamRoomUIController.<>f__mg$cache18 == null)
		{
			Lua_BlackJack_ProjectL_UI_CreateTeamRoomUIController.<>f__mg$cache18 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_CreateTeamRoomUIController.OnCreateButtonClick);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_CreateTeamRoomUIController.<>f__mg$cache18);
		if (Lua_BlackJack_ProjectL_UI_CreateTeamRoomUIController.<>f__mg$cache19 == null)
		{
			Lua_BlackJack_ProjectL_UI_CreateTeamRoomUIController.<>f__mg$cache19 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_CreateTeamRoomUIController.OnCancelButtonClick);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_CreateTeamRoomUIController.<>f__mg$cache19);
		if (Lua_BlackJack_ProjectL_UI_CreateTeamRoomUIController.<>f__mg$cache1A == null)
		{
			Lua_BlackJack_ProjectL_UI_CreateTeamRoomUIController.<>f__mg$cache1A = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_CreateTeamRoomUIController.OnBackgroundButtonClick);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_CreateTeamRoomUIController.<>f__mg$cache1A);
		if (Lua_BlackJack_ProjectL_UI_CreateTeamRoomUIController.<>f__mg$cache1B == null)
		{
			Lua_BlackJack_ProjectL_UI_CreateTeamRoomUIController.<>f__mg$cache1B = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_CreateTeamRoomUIController.GameFunctionTypeListItem_OnButtonClick);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_CreateTeamRoomUIController.<>f__mg$cache1B);
		if (Lua_BlackJack_ProjectL_UI_CreateTeamRoomUIController.<>f__mg$cache1C == null)
		{
			Lua_BlackJack_ProjectL_UI_CreateTeamRoomUIController.<>f__mg$cache1C = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_CreateTeamRoomUIController.LocationListItem_OnButtonClick);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_CreateTeamRoomUIController.<>f__mg$cache1C);
		if (Lua_BlackJack_ProjectL_UI_CreateTeamRoomUIController.<>f__mg$cache1D == null)
		{
			Lua_BlackJack_ProjectL_UI_CreateTeamRoomUIController.<>f__mg$cache1D = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_CreateTeamRoomUIController.PlayerLevelMinListItem_OnButtonClick);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_CreateTeamRoomUIController.<>f__mg$cache1D);
		if (Lua_BlackJack_ProjectL_UI_CreateTeamRoomUIController.<>f__mg$cache1E == null)
		{
			Lua_BlackJack_ProjectL_UI_CreateTeamRoomUIController.<>f__mg$cache1E = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_CreateTeamRoomUIController.PlayerLevelMaxListItem_OnButtonClick);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_CreateTeamRoomUIController.<>f__mg$cache1E);
		if (Lua_BlackJack_ProjectL_UI_CreateTeamRoomUIController.<>f__mg$cache1F == null)
		{
			Lua_BlackJack_ProjectL_UI_CreateTeamRoomUIController.<>f__mg$cache1F = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_CreateTeamRoomUIController.GameFunctionTypeScrollSnapCenter_OnCenterItemChanged);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_CreateTeamRoomUIController.<>f__mg$cache1F);
		if (Lua_BlackJack_ProjectL_UI_CreateTeamRoomUIController.<>f__mg$cache20 == null)
		{
			Lua_BlackJack_ProjectL_UI_CreateTeamRoomUIController.<>f__mg$cache20 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_CreateTeamRoomUIController.GameFunctionTypeScrollRect_OnValueChaged);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_CreateTeamRoomUIController.<>f__mg$cache20);
		if (Lua_BlackJack_ProjectL_UI_CreateTeamRoomUIController.<>f__mg$cache21 == null)
		{
			Lua_BlackJack_ProjectL_UI_CreateTeamRoomUIController.<>f__mg$cache21 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_CreateTeamRoomUIController.LocationScrollRect_OnValueChaged);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_CreateTeamRoomUIController.<>f__mg$cache21);
		if (Lua_BlackJack_ProjectL_UI_CreateTeamRoomUIController.<>f__mg$cache22 == null)
		{
			Lua_BlackJack_ProjectL_UI_CreateTeamRoomUIController.<>f__mg$cache22 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_CreateTeamRoomUIController.PlayerLevelMinScrollRect_OnValueChaged);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_CreateTeamRoomUIController.<>f__mg$cache22);
		if (Lua_BlackJack_ProjectL_UI_CreateTeamRoomUIController.<>f__mg$cache23 == null)
		{
			Lua_BlackJack_ProjectL_UI_CreateTeamRoomUIController.<>f__mg$cache23 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_CreateTeamRoomUIController.PlayerLevelMaxScrollRect_OnValueChaged);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_CreateTeamRoomUIController.<>f__mg$cache23);
		if (Lua_BlackJack_ProjectL_UI_CreateTeamRoomUIController.<>f__mg$cache24 == null)
		{
			Lua_BlackJack_ProjectL_UI_CreateTeamRoomUIController.<>f__mg$cache24 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_CreateTeamRoomUIController.ScaleListItem);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_CreateTeamRoomUIController.<>f__mg$cache24);
		if (Lua_BlackJack_ProjectL_UI_CreateTeamRoomUIController.<>f__mg$cache25 == null)
		{
			Lua_BlackJack_ProjectL_UI_CreateTeamRoomUIController.<>f__mg$cache25 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_CreateTeamRoomUIController.__callBase_Initlize);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_CreateTeamRoomUIController.<>f__mg$cache25);
		if (Lua_BlackJack_ProjectL_UI_CreateTeamRoomUIController.<>f__mg$cache26 == null)
		{
			Lua_BlackJack_ProjectL_UI_CreateTeamRoomUIController.<>f__mg$cache26 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_CreateTeamRoomUIController.__callBase_BindFields);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_CreateTeamRoomUIController.<>f__mg$cache26);
		if (Lua_BlackJack_ProjectL_UI_CreateTeamRoomUIController.<>f__mg$cache27 == null)
		{
			Lua_BlackJack_ProjectL_UI_CreateTeamRoomUIController.<>f__mg$cache27 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_CreateTeamRoomUIController.__callBase_OnBindFiledsCompleted);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_CreateTeamRoomUIController.<>f__mg$cache27);
		if (Lua_BlackJack_ProjectL_UI_CreateTeamRoomUIController.<>f__mg$cache28 == null)
		{
			Lua_BlackJack_ProjectL_UI_CreateTeamRoomUIController.<>f__mg$cache28 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_CreateTeamRoomUIController.__callBase_BindFieldImpl);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_CreateTeamRoomUIController.<>f__mg$cache28);
		if (Lua_BlackJack_ProjectL_UI_CreateTeamRoomUIController.<>f__mg$cache29 == null)
		{
			Lua_BlackJack_ProjectL_UI_CreateTeamRoomUIController.<>f__mg$cache29 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_CreateTeamRoomUIController.__callBase_Clear);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_CreateTeamRoomUIController.<>f__mg$cache29);
		if (Lua_BlackJack_ProjectL_UI_CreateTeamRoomUIController.<>f__mg$cache2A == null)
		{
			Lua_BlackJack_ProjectL_UI_CreateTeamRoomUIController.<>f__mg$cache2A = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_CreateTeamRoomUIController.__callBase_OnButtonClick);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_CreateTeamRoomUIController.<>f__mg$cache2A);
		if (Lua_BlackJack_ProjectL_UI_CreateTeamRoomUIController.<>f__mg$cache2B == null)
		{
			Lua_BlackJack_ProjectL_UI_CreateTeamRoomUIController.<>f__mg$cache2B = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_CreateTeamRoomUIController.__callBase_SetButtonClickListener);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_CreateTeamRoomUIController.<>f__mg$cache2B);
		if (Lua_BlackJack_ProjectL_UI_CreateTeamRoomUIController.<>f__mg$cache2C == null)
		{
			Lua_BlackJack_ProjectL_UI_CreateTeamRoomUIController.<>f__mg$cache2C = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_CreateTeamRoomUIController.__callBase_SetButtonDoubleClickListener);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_CreateTeamRoomUIController.<>f__mg$cache2C);
		if (Lua_BlackJack_ProjectL_UI_CreateTeamRoomUIController.<>f__mg$cache2D == null)
		{
			Lua_BlackJack_ProjectL_UI_CreateTeamRoomUIController.<>f__mg$cache2D = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_CreateTeamRoomUIController.__callBase_SetButtonLongPressStartListener);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_CreateTeamRoomUIController.<>f__mg$cache2D);
		if (Lua_BlackJack_ProjectL_UI_CreateTeamRoomUIController.<>f__mg$cache2E == null)
		{
			Lua_BlackJack_ProjectL_UI_CreateTeamRoomUIController.<>f__mg$cache2E = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_CreateTeamRoomUIController.__callBase_SetButtonLongPressingListener);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_CreateTeamRoomUIController.<>f__mg$cache2E);
		if (Lua_BlackJack_ProjectL_UI_CreateTeamRoomUIController.<>f__mg$cache2F == null)
		{
			Lua_BlackJack_ProjectL_UI_CreateTeamRoomUIController.<>f__mg$cache2F = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_CreateTeamRoomUIController.__callBase_SetButtonLongPressEndListener);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_CreateTeamRoomUIController.<>f__mg$cache2F);
		if (Lua_BlackJack_ProjectL_UI_CreateTeamRoomUIController.<>f__mg$cache30 == null)
		{
			Lua_BlackJack_ProjectL_UI_CreateTeamRoomUIController.<>f__mg$cache30 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_CreateTeamRoomUIController.__callBase_SetToggleValueChangedListener);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_CreateTeamRoomUIController.<>f__mg$cache30);
		if (Lua_BlackJack_ProjectL_UI_CreateTeamRoomUIController.<>f__mg$cache31 == null)
		{
			Lua_BlackJack_ProjectL_UI_CreateTeamRoomUIController.<>f__mg$cache31 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_CreateTeamRoomUIController.__callBase_ToString);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_CreateTeamRoomUIController.<>f__mg$cache31);
		if (Lua_BlackJack_ProjectL_UI_CreateTeamRoomUIController.<>f__mg$cache32 == null)
		{
			Lua_BlackJack_ProjectL_UI_CreateTeamRoomUIController.<>f__mg$cache32 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_CreateTeamRoomUIController.__callDele_EventOnCreateTeamRoom);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_CreateTeamRoomUIController.<>f__mg$cache32);
		if (Lua_BlackJack_ProjectL_UI_CreateTeamRoomUIController.<>f__mg$cache33 == null)
		{
			Lua_BlackJack_ProjectL_UI_CreateTeamRoomUIController.<>f__mg$cache33 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_CreateTeamRoomUIController.__clearDele_EventOnCreateTeamRoom);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_CreateTeamRoomUIController.<>f__mg$cache33);
		if (Lua_BlackJack_ProjectL_UI_CreateTeamRoomUIController.<>f__mg$cache34 == null)
		{
			Lua_BlackJack_ProjectL_UI_CreateTeamRoomUIController.<>f__mg$cache34 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_CreateTeamRoomUIController.GetRoomInfoListItemIndexByValue_s);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_CreateTeamRoomUIController.<>f__mg$cache34);
		string name = "EventOnCreateTeamRoom";
		LuaCSFunction get = null;
		if (Lua_BlackJack_ProjectL_UI_CreateTeamRoomUIController.<>f__mg$cache35 == null)
		{
			Lua_BlackJack_ProjectL_UI_CreateTeamRoomUIController.<>f__mg$cache35 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_CreateTeamRoomUIController.set_EventOnCreateTeamRoom);
		}
		LuaObject.addMember(l, name, get, Lua_BlackJack_ProjectL_UI_CreateTeamRoomUIController.<>f__mg$cache35, true);
		string name2 = "m_uiStateController";
		if (Lua_BlackJack_ProjectL_UI_CreateTeamRoomUIController.<>f__mg$cache36 == null)
		{
			Lua_BlackJack_ProjectL_UI_CreateTeamRoomUIController.<>f__mg$cache36 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_CreateTeamRoomUIController.get_m_uiStateController);
		}
		LuaCSFunction get2 = Lua_BlackJack_ProjectL_UI_CreateTeamRoomUIController.<>f__mg$cache36;
		if (Lua_BlackJack_ProjectL_UI_CreateTeamRoomUIController.<>f__mg$cache37 == null)
		{
			Lua_BlackJack_ProjectL_UI_CreateTeamRoomUIController.<>f__mg$cache37 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_CreateTeamRoomUIController.set_m_uiStateController);
		}
		LuaObject.addMember(l, name2, get2, Lua_BlackJack_ProjectL_UI_CreateTeamRoomUIController.<>f__mg$cache37, true);
		string name3 = "m_createButton";
		if (Lua_BlackJack_ProjectL_UI_CreateTeamRoomUIController.<>f__mg$cache38 == null)
		{
			Lua_BlackJack_ProjectL_UI_CreateTeamRoomUIController.<>f__mg$cache38 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_CreateTeamRoomUIController.get_m_createButton);
		}
		LuaCSFunction get3 = Lua_BlackJack_ProjectL_UI_CreateTeamRoomUIController.<>f__mg$cache38;
		if (Lua_BlackJack_ProjectL_UI_CreateTeamRoomUIController.<>f__mg$cache39 == null)
		{
			Lua_BlackJack_ProjectL_UI_CreateTeamRoomUIController.<>f__mg$cache39 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_CreateTeamRoomUIController.set_m_createButton);
		}
		LuaObject.addMember(l, name3, get3, Lua_BlackJack_ProjectL_UI_CreateTeamRoomUIController.<>f__mg$cache39, true);
		string name4 = "m_cancelButton";
		if (Lua_BlackJack_ProjectL_UI_CreateTeamRoomUIController.<>f__mg$cache3A == null)
		{
			Lua_BlackJack_ProjectL_UI_CreateTeamRoomUIController.<>f__mg$cache3A = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_CreateTeamRoomUIController.get_m_cancelButton);
		}
		LuaCSFunction get4 = Lua_BlackJack_ProjectL_UI_CreateTeamRoomUIController.<>f__mg$cache3A;
		if (Lua_BlackJack_ProjectL_UI_CreateTeamRoomUIController.<>f__mg$cache3B == null)
		{
			Lua_BlackJack_ProjectL_UI_CreateTeamRoomUIController.<>f__mg$cache3B = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_CreateTeamRoomUIController.set_m_cancelButton);
		}
		LuaObject.addMember(l, name4, get4, Lua_BlackJack_ProjectL_UI_CreateTeamRoomUIController.<>f__mg$cache3B, true);
		string name5 = "m_authorityAllToggle";
		if (Lua_BlackJack_ProjectL_UI_CreateTeamRoomUIController.<>f__mg$cache3C == null)
		{
			Lua_BlackJack_ProjectL_UI_CreateTeamRoomUIController.<>f__mg$cache3C = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_CreateTeamRoomUIController.get_m_authorityAllToggle);
		}
		LuaCSFunction get5 = Lua_BlackJack_ProjectL_UI_CreateTeamRoomUIController.<>f__mg$cache3C;
		if (Lua_BlackJack_ProjectL_UI_CreateTeamRoomUIController.<>f__mg$cache3D == null)
		{
			Lua_BlackJack_ProjectL_UI_CreateTeamRoomUIController.<>f__mg$cache3D = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_CreateTeamRoomUIController.set_m_authorityAllToggle);
		}
		LuaObject.addMember(l, name5, get5, Lua_BlackJack_ProjectL_UI_CreateTeamRoomUIController.<>f__mg$cache3D, true);
		string name6 = "m_authorityFriendToggle";
		if (Lua_BlackJack_ProjectL_UI_CreateTeamRoomUIController.<>f__mg$cache3E == null)
		{
			Lua_BlackJack_ProjectL_UI_CreateTeamRoomUIController.<>f__mg$cache3E = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_CreateTeamRoomUIController.get_m_authorityFriendToggle);
		}
		LuaCSFunction get6 = Lua_BlackJack_ProjectL_UI_CreateTeamRoomUIController.<>f__mg$cache3E;
		if (Lua_BlackJack_ProjectL_UI_CreateTeamRoomUIController.<>f__mg$cache3F == null)
		{
			Lua_BlackJack_ProjectL_UI_CreateTeamRoomUIController.<>f__mg$cache3F = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_CreateTeamRoomUIController.set_m_authorityFriendToggle);
		}
		LuaObject.addMember(l, name6, get6, Lua_BlackJack_ProjectL_UI_CreateTeamRoomUIController.<>f__mg$cache3F, true);
		string name7 = "m_authorityNonPublicToggle";
		if (Lua_BlackJack_ProjectL_UI_CreateTeamRoomUIController.<>f__mg$cache40 == null)
		{
			Lua_BlackJack_ProjectL_UI_CreateTeamRoomUIController.<>f__mg$cache40 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_CreateTeamRoomUIController.get_m_authorityNonPublicToggle);
		}
		LuaCSFunction get7 = Lua_BlackJack_ProjectL_UI_CreateTeamRoomUIController.<>f__mg$cache40;
		if (Lua_BlackJack_ProjectL_UI_CreateTeamRoomUIController.<>f__mg$cache41 == null)
		{
			Lua_BlackJack_ProjectL_UI_CreateTeamRoomUIController.<>f__mg$cache41 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_CreateTeamRoomUIController.set_m_authorityNonPublicToggle);
		}
		LuaObject.addMember(l, name7, get7, Lua_BlackJack_ProjectL_UI_CreateTeamRoomUIController.<>f__mg$cache41, true);
		string name8 = "m_gameFunctionTypeScrollRect";
		if (Lua_BlackJack_ProjectL_UI_CreateTeamRoomUIController.<>f__mg$cache42 == null)
		{
			Lua_BlackJack_ProjectL_UI_CreateTeamRoomUIController.<>f__mg$cache42 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_CreateTeamRoomUIController.get_m_gameFunctionTypeScrollRect);
		}
		LuaCSFunction get8 = Lua_BlackJack_ProjectL_UI_CreateTeamRoomUIController.<>f__mg$cache42;
		if (Lua_BlackJack_ProjectL_UI_CreateTeamRoomUIController.<>f__mg$cache43 == null)
		{
			Lua_BlackJack_ProjectL_UI_CreateTeamRoomUIController.<>f__mg$cache43 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_CreateTeamRoomUIController.set_m_gameFunctionTypeScrollRect);
		}
		LuaObject.addMember(l, name8, get8, Lua_BlackJack_ProjectL_UI_CreateTeamRoomUIController.<>f__mg$cache43, true);
		string name9 = "m_locationScrollRect";
		if (Lua_BlackJack_ProjectL_UI_CreateTeamRoomUIController.<>f__mg$cache44 == null)
		{
			Lua_BlackJack_ProjectL_UI_CreateTeamRoomUIController.<>f__mg$cache44 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_CreateTeamRoomUIController.get_m_locationScrollRect);
		}
		LuaCSFunction get9 = Lua_BlackJack_ProjectL_UI_CreateTeamRoomUIController.<>f__mg$cache44;
		if (Lua_BlackJack_ProjectL_UI_CreateTeamRoomUIController.<>f__mg$cache45 == null)
		{
			Lua_BlackJack_ProjectL_UI_CreateTeamRoomUIController.<>f__mg$cache45 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_CreateTeamRoomUIController.set_m_locationScrollRect);
		}
		LuaObject.addMember(l, name9, get9, Lua_BlackJack_ProjectL_UI_CreateTeamRoomUIController.<>f__mg$cache45, true);
		string name10 = "m_playerLevelMinScrollRect";
		if (Lua_BlackJack_ProjectL_UI_CreateTeamRoomUIController.<>f__mg$cache46 == null)
		{
			Lua_BlackJack_ProjectL_UI_CreateTeamRoomUIController.<>f__mg$cache46 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_CreateTeamRoomUIController.get_m_playerLevelMinScrollRect);
		}
		LuaCSFunction get10 = Lua_BlackJack_ProjectL_UI_CreateTeamRoomUIController.<>f__mg$cache46;
		if (Lua_BlackJack_ProjectL_UI_CreateTeamRoomUIController.<>f__mg$cache47 == null)
		{
			Lua_BlackJack_ProjectL_UI_CreateTeamRoomUIController.<>f__mg$cache47 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_CreateTeamRoomUIController.set_m_playerLevelMinScrollRect);
		}
		LuaObject.addMember(l, name10, get10, Lua_BlackJack_ProjectL_UI_CreateTeamRoomUIController.<>f__mg$cache47, true);
		string name11 = "m_playerLevelMaxScrollRect";
		if (Lua_BlackJack_ProjectL_UI_CreateTeamRoomUIController.<>f__mg$cache48 == null)
		{
			Lua_BlackJack_ProjectL_UI_CreateTeamRoomUIController.<>f__mg$cache48 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_CreateTeamRoomUIController.get_m_playerLevelMaxScrollRect);
		}
		LuaCSFunction get11 = Lua_BlackJack_ProjectL_UI_CreateTeamRoomUIController.<>f__mg$cache48;
		if (Lua_BlackJack_ProjectL_UI_CreateTeamRoomUIController.<>f__mg$cache49 == null)
		{
			Lua_BlackJack_ProjectL_UI_CreateTeamRoomUIController.<>f__mg$cache49 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_CreateTeamRoomUIController.set_m_playerLevelMaxScrollRect);
		}
		LuaObject.addMember(l, name11, get11, Lua_BlackJack_ProjectL_UI_CreateTeamRoomUIController.<>f__mg$cache49, true);
		string name12 = "m_prefabsGameObject";
		if (Lua_BlackJack_ProjectL_UI_CreateTeamRoomUIController.<>f__mg$cache4A == null)
		{
			Lua_BlackJack_ProjectL_UI_CreateTeamRoomUIController.<>f__mg$cache4A = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_CreateTeamRoomUIController.get_m_prefabsGameObject);
		}
		LuaCSFunction get12 = Lua_BlackJack_ProjectL_UI_CreateTeamRoomUIController.<>f__mg$cache4A;
		if (Lua_BlackJack_ProjectL_UI_CreateTeamRoomUIController.<>f__mg$cache4B == null)
		{
			Lua_BlackJack_ProjectL_UI_CreateTeamRoomUIController.<>f__mg$cache4B = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_CreateTeamRoomUIController.set_m_prefabsGameObject);
		}
		LuaObject.addMember(l, name12, get12, Lua_BlackJack_ProjectL_UI_CreateTeamRoomUIController.<>f__mg$cache4B, true);
		string name13 = "m_roomInfoListItemPrefab";
		if (Lua_BlackJack_ProjectL_UI_CreateTeamRoomUIController.<>f__mg$cache4C == null)
		{
			Lua_BlackJack_ProjectL_UI_CreateTeamRoomUIController.<>f__mg$cache4C = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_CreateTeamRoomUIController.get_m_roomInfoListItemPrefab);
		}
		LuaCSFunction get13 = Lua_BlackJack_ProjectL_UI_CreateTeamRoomUIController.<>f__mg$cache4C;
		if (Lua_BlackJack_ProjectL_UI_CreateTeamRoomUIController.<>f__mg$cache4D == null)
		{
			Lua_BlackJack_ProjectL_UI_CreateTeamRoomUIController.<>f__mg$cache4D = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_CreateTeamRoomUIController.set_m_roomInfoListItemPrefab);
		}
		LuaObject.addMember(l, name13, get13, Lua_BlackJack_ProjectL_UI_CreateTeamRoomUIController.<>f__mg$cache4D, true);
		string name14 = "m_gameFunctionTypeScrollSnapCenter";
		if (Lua_BlackJack_ProjectL_UI_CreateTeamRoomUIController.<>f__mg$cache4E == null)
		{
			Lua_BlackJack_ProjectL_UI_CreateTeamRoomUIController.<>f__mg$cache4E = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_CreateTeamRoomUIController.get_m_gameFunctionTypeScrollSnapCenter);
		}
		LuaCSFunction get14 = Lua_BlackJack_ProjectL_UI_CreateTeamRoomUIController.<>f__mg$cache4E;
		if (Lua_BlackJack_ProjectL_UI_CreateTeamRoomUIController.<>f__mg$cache4F == null)
		{
			Lua_BlackJack_ProjectL_UI_CreateTeamRoomUIController.<>f__mg$cache4F = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_CreateTeamRoomUIController.set_m_gameFunctionTypeScrollSnapCenter);
		}
		LuaObject.addMember(l, name14, get14, Lua_BlackJack_ProjectL_UI_CreateTeamRoomUIController.<>f__mg$cache4F, true);
		string name15 = "m_locationScrollSnapCenter";
		if (Lua_BlackJack_ProjectL_UI_CreateTeamRoomUIController.<>f__mg$cache50 == null)
		{
			Lua_BlackJack_ProjectL_UI_CreateTeamRoomUIController.<>f__mg$cache50 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_CreateTeamRoomUIController.get_m_locationScrollSnapCenter);
		}
		LuaCSFunction get15 = Lua_BlackJack_ProjectL_UI_CreateTeamRoomUIController.<>f__mg$cache50;
		if (Lua_BlackJack_ProjectL_UI_CreateTeamRoomUIController.<>f__mg$cache51 == null)
		{
			Lua_BlackJack_ProjectL_UI_CreateTeamRoomUIController.<>f__mg$cache51 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_CreateTeamRoomUIController.set_m_locationScrollSnapCenter);
		}
		LuaObject.addMember(l, name15, get15, Lua_BlackJack_ProjectL_UI_CreateTeamRoomUIController.<>f__mg$cache51, true);
		string name16 = "m_playerLevelMinScrollSnapCenter";
		if (Lua_BlackJack_ProjectL_UI_CreateTeamRoomUIController.<>f__mg$cache52 == null)
		{
			Lua_BlackJack_ProjectL_UI_CreateTeamRoomUIController.<>f__mg$cache52 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_CreateTeamRoomUIController.get_m_playerLevelMinScrollSnapCenter);
		}
		LuaCSFunction get16 = Lua_BlackJack_ProjectL_UI_CreateTeamRoomUIController.<>f__mg$cache52;
		if (Lua_BlackJack_ProjectL_UI_CreateTeamRoomUIController.<>f__mg$cache53 == null)
		{
			Lua_BlackJack_ProjectL_UI_CreateTeamRoomUIController.<>f__mg$cache53 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_CreateTeamRoomUIController.set_m_playerLevelMinScrollSnapCenter);
		}
		LuaObject.addMember(l, name16, get16, Lua_BlackJack_ProjectL_UI_CreateTeamRoomUIController.<>f__mg$cache53, true);
		string name17 = "m_playerLevelMaxScrollSnapCenter";
		if (Lua_BlackJack_ProjectL_UI_CreateTeamRoomUIController.<>f__mg$cache54 == null)
		{
			Lua_BlackJack_ProjectL_UI_CreateTeamRoomUIController.<>f__mg$cache54 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_CreateTeamRoomUIController.get_m_playerLevelMaxScrollSnapCenter);
		}
		LuaCSFunction get17 = Lua_BlackJack_ProjectL_UI_CreateTeamRoomUIController.<>f__mg$cache54;
		if (Lua_BlackJack_ProjectL_UI_CreateTeamRoomUIController.<>f__mg$cache55 == null)
		{
			Lua_BlackJack_ProjectL_UI_CreateTeamRoomUIController.<>f__mg$cache55 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_CreateTeamRoomUIController.set_m_playerLevelMaxScrollSnapCenter);
		}
		LuaObject.addMember(l, name17, get17, Lua_BlackJack_ProjectL_UI_CreateTeamRoomUIController.<>f__mg$cache55, true);
		string name18 = "m_gameFunctionTypeListItems";
		if (Lua_BlackJack_ProjectL_UI_CreateTeamRoomUIController.<>f__mg$cache56 == null)
		{
			Lua_BlackJack_ProjectL_UI_CreateTeamRoomUIController.<>f__mg$cache56 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_CreateTeamRoomUIController.get_m_gameFunctionTypeListItems);
		}
		LuaCSFunction get18 = Lua_BlackJack_ProjectL_UI_CreateTeamRoomUIController.<>f__mg$cache56;
		if (Lua_BlackJack_ProjectL_UI_CreateTeamRoomUIController.<>f__mg$cache57 == null)
		{
			Lua_BlackJack_ProjectL_UI_CreateTeamRoomUIController.<>f__mg$cache57 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_CreateTeamRoomUIController.set_m_gameFunctionTypeListItems);
		}
		LuaObject.addMember(l, name18, get18, Lua_BlackJack_ProjectL_UI_CreateTeamRoomUIController.<>f__mg$cache57, true);
		string name19 = "m_locationListItems";
		if (Lua_BlackJack_ProjectL_UI_CreateTeamRoomUIController.<>f__mg$cache58 == null)
		{
			Lua_BlackJack_ProjectL_UI_CreateTeamRoomUIController.<>f__mg$cache58 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_CreateTeamRoomUIController.get_m_locationListItems);
		}
		LuaCSFunction get19 = Lua_BlackJack_ProjectL_UI_CreateTeamRoomUIController.<>f__mg$cache58;
		if (Lua_BlackJack_ProjectL_UI_CreateTeamRoomUIController.<>f__mg$cache59 == null)
		{
			Lua_BlackJack_ProjectL_UI_CreateTeamRoomUIController.<>f__mg$cache59 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_CreateTeamRoomUIController.set_m_locationListItems);
		}
		LuaObject.addMember(l, name19, get19, Lua_BlackJack_ProjectL_UI_CreateTeamRoomUIController.<>f__mg$cache59, true);
		string name20 = "m_playerLevelMinListItems";
		if (Lua_BlackJack_ProjectL_UI_CreateTeamRoomUIController.<>f__mg$cache5A == null)
		{
			Lua_BlackJack_ProjectL_UI_CreateTeamRoomUIController.<>f__mg$cache5A = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_CreateTeamRoomUIController.get_m_playerLevelMinListItems);
		}
		LuaCSFunction get20 = Lua_BlackJack_ProjectL_UI_CreateTeamRoomUIController.<>f__mg$cache5A;
		if (Lua_BlackJack_ProjectL_UI_CreateTeamRoomUIController.<>f__mg$cache5B == null)
		{
			Lua_BlackJack_ProjectL_UI_CreateTeamRoomUIController.<>f__mg$cache5B = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_CreateTeamRoomUIController.set_m_playerLevelMinListItems);
		}
		LuaObject.addMember(l, name20, get20, Lua_BlackJack_ProjectL_UI_CreateTeamRoomUIController.<>f__mg$cache5B, true);
		string name21 = "m_playerLevelMaxListItems";
		if (Lua_BlackJack_ProjectL_UI_CreateTeamRoomUIController.<>f__mg$cache5C == null)
		{
			Lua_BlackJack_ProjectL_UI_CreateTeamRoomUIController.<>f__mg$cache5C = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_CreateTeamRoomUIController.get_m_playerLevelMaxListItems);
		}
		LuaCSFunction get21 = Lua_BlackJack_ProjectL_UI_CreateTeamRoomUIController.<>f__mg$cache5C;
		if (Lua_BlackJack_ProjectL_UI_CreateTeamRoomUIController.<>f__mg$cache5D == null)
		{
			Lua_BlackJack_ProjectL_UI_CreateTeamRoomUIController.<>f__mg$cache5D = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_CreateTeamRoomUIController.set_m_playerLevelMaxListItems);
		}
		LuaObject.addMember(l, name21, get21, Lua_BlackJack_ProjectL_UI_CreateTeamRoomUIController.<>f__mg$cache5D, true);
		LuaObject.createTypeMetatable(l, null, typeof(CreateTeamRoomUIController), typeof(UIControllerBase));
	}

	// Token: 0x04013207 RID: 78343
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache0;

	// Token: 0x04013208 RID: 78344
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1;

	// Token: 0x04013209 RID: 78345
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2;

	// Token: 0x0401320A RID: 78346
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3;

	// Token: 0x0401320B RID: 78347
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache4;

	// Token: 0x0401320C RID: 78348
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache5;

	// Token: 0x0401320D RID: 78349
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache6;

	// Token: 0x0401320E RID: 78350
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache7;

	// Token: 0x0401320F RID: 78351
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache8;

	// Token: 0x04013210 RID: 78352
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache9;

	// Token: 0x04013211 RID: 78353
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheA;

	// Token: 0x04013212 RID: 78354
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheB;

	// Token: 0x04013213 RID: 78355
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheC;

	// Token: 0x04013214 RID: 78356
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheD;

	// Token: 0x04013215 RID: 78357
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheE;

	// Token: 0x04013216 RID: 78358
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheF;

	// Token: 0x04013217 RID: 78359
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache10;

	// Token: 0x04013218 RID: 78360
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache11;

	// Token: 0x04013219 RID: 78361
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache12;

	// Token: 0x0401321A RID: 78362
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache13;

	// Token: 0x0401321B RID: 78363
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache14;

	// Token: 0x0401321C RID: 78364
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache15;

	// Token: 0x0401321D RID: 78365
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache16;

	// Token: 0x0401321E RID: 78366
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache17;

	// Token: 0x0401321F RID: 78367
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache18;

	// Token: 0x04013220 RID: 78368
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache19;

	// Token: 0x04013221 RID: 78369
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1A;

	// Token: 0x04013222 RID: 78370
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1B;

	// Token: 0x04013223 RID: 78371
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1C;

	// Token: 0x04013224 RID: 78372
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1D;

	// Token: 0x04013225 RID: 78373
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1E;

	// Token: 0x04013226 RID: 78374
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1F;

	// Token: 0x04013227 RID: 78375
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache20;

	// Token: 0x04013228 RID: 78376
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache21;

	// Token: 0x04013229 RID: 78377
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache22;

	// Token: 0x0401322A RID: 78378
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache23;

	// Token: 0x0401322B RID: 78379
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache24;

	// Token: 0x0401322C RID: 78380
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache25;

	// Token: 0x0401322D RID: 78381
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache26;

	// Token: 0x0401322E RID: 78382
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache27;

	// Token: 0x0401322F RID: 78383
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache28;

	// Token: 0x04013230 RID: 78384
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache29;

	// Token: 0x04013231 RID: 78385
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2A;

	// Token: 0x04013232 RID: 78386
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2B;

	// Token: 0x04013233 RID: 78387
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2C;

	// Token: 0x04013234 RID: 78388
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2D;

	// Token: 0x04013235 RID: 78389
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2E;

	// Token: 0x04013236 RID: 78390
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2F;

	// Token: 0x04013237 RID: 78391
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache30;

	// Token: 0x04013238 RID: 78392
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache31;

	// Token: 0x04013239 RID: 78393
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache32;

	// Token: 0x0401323A RID: 78394
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache33;

	// Token: 0x0401323B RID: 78395
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache34;

	// Token: 0x0401323C RID: 78396
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache35;

	// Token: 0x0401323D RID: 78397
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache36;

	// Token: 0x0401323E RID: 78398
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache37;

	// Token: 0x0401323F RID: 78399
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache38;

	// Token: 0x04013240 RID: 78400
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache39;

	// Token: 0x04013241 RID: 78401
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3A;

	// Token: 0x04013242 RID: 78402
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3B;

	// Token: 0x04013243 RID: 78403
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3C;

	// Token: 0x04013244 RID: 78404
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3D;

	// Token: 0x04013245 RID: 78405
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3E;

	// Token: 0x04013246 RID: 78406
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3F;

	// Token: 0x04013247 RID: 78407
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache40;

	// Token: 0x04013248 RID: 78408
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache41;

	// Token: 0x04013249 RID: 78409
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache42;

	// Token: 0x0401324A RID: 78410
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache43;

	// Token: 0x0401324B RID: 78411
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache44;

	// Token: 0x0401324C RID: 78412
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache45;

	// Token: 0x0401324D RID: 78413
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache46;

	// Token: 0x0401324E RID: 78414
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache47;

	// Token: 0x0401324F RID: 78415
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache48;

	// Token: 0x04013250 RID: 78416
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache49;

	// Token: 0x04013251 RID: 78417
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache4A;

	// Token: 0x04013252 RID: 78418
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache4B;

	// Token: 0x04013253 RID: 78419
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache4C;

	// Token: 0x04013254 RID: 78420
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache4D;

	// Token: 0x04013255 RID: 78421
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache4E;

	// Token: 0x04013256 RID: 78422
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache4F;

	// Token: 0x04013257 RID: 78423
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache50;

	// Token: 0x04013258 RID: 78424
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache51;

	// Token: 0x04013259 RID: 78425
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache52;

	// Token: 0x0401325A RID: 78426
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache53;

	// Token: 0x0401325B RID: 78427
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache54;

	// Token: 0x0401325C RID: 78428
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache55;

	// Token: 0x0401325D RID: 78429
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache56;

	// Token: 0x0401325E RID: 78430
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache57;

	// Token: 0x0401325F RID: 78431
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache58;

	// Token: 0x04013260 RID: 78432
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache59;

	// Token: 0x04013261 RID: 78433
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache5A;

	// Token: 0x04013262 RID: 78434
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache5B;

	// Token: 0x04013263 RID: 78435
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache5C;

	// Token: 0x04013264 RID: 78436
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache5D;
}
