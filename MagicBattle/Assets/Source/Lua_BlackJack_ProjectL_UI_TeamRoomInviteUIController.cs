using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using BlackJack.BJFramework.Runtime.Prefab;
using BlackJack.BJFramework.Runtime.UI;
using BlackJack.ProjectL.Common;
using BlackJack.ProjectL.UI;
using SLua;
using UnityEngine;
using UnityEngine.Scripting;
using UnityEngine.UI;

// Token: 0x0200159F RID: 5535
[Preserve]
public class Lua_BlackJack_ProjectL_UI_TeamRoomInviteUIController : LuaObject
{
	// Token: 0x060217E0 RID: 137184 RVA: 0x00B556E0 File Offset: 0x00B538E0
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int Open(IntPtr l)
	{
		int result;
		try
		{
			TeamRoomInviteUIController teamRoomInviteUIController = (TeamRoomInviteUIController)LuaObject.checkSelf(l);
			teamRoomInviteUIController.Open();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060217E1 RID: 137185 RVA: 0x00B5572C File Offset: 0x00B5392C
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int SetPlayerType(IntPtr l)
	{
		int result;
		try
		{
			TeamRoomInviteUIController teamRoomInviteUIController = (TeamRoomInviteUIController)LuaObject.checkSelf(l);
			TeamRoomInvitePlayerType playerType;
			LuaObject.checkEnum<TeamRoomInvitePlayerType>(l, 2, out playerType);
			bool canChangePlayerType;
			LuaObject.checkType(l, 3, out canChangePlayerType);
			teamRoomInviteUIController.SetPlayerType(playerType, canChangePlayerType);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060217E2 RID: 137186 RVA: 0x00B55790 File Offset: 0x00B53990
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int Close(IntPtr l)
	{
		int result;
		try
		{
			TeamRoomInviteUIController teamRoomInviteUIController = (TeamRoomInviteUIController)LuaObject.checkSelf(l);
			Action onEnd;
			LuaObject.checkDelegate<Action>(l, 2, out onEnd);
			teamRoomInviteUIController.Close(onEnd);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060217E3 RID: 137187 RVA: 0x00B557E8 File Offset: 0x00B539E8
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int SetPlayers(IntPtr l)
	{
		int result;
		try
		{
			TeamRoomInviteUIController teamRoomInviteUIController = (TeamRoomInviteUIController)LuaObject.checkSelf(l);
			List<UserSummary> players;
			LuaObject.checkType<List<UserSummary>>(l, 2, out players);
			teamRoomInviteUIController.SetPlayers(players);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060217E4 RID: 137188 RVA: 0x00B55840 File Offset: 0x00B53A40
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int UpdatePlayerStatus(IntPtr l)
	{
		int result;
		try
		{
			TeamRoomInviteUIController teamRoomInviteUIController = (TeamRoomInviteUIController)LuaObject.checkSelf(l);
			string userId;
			LuaObject.checkType(l, 2, out userId);
			TeamRoomPlayerInviteState inviteState;
			LuaObject.checkEnum<TeamRoomPlayerInviteState>(l, 3, out inviteState);
			teamRoomInviteUIController.UpdatePlayerStatus(userId, inviteState);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060217E5 RID: 137189 RVA: 0x00B558A4 File Offset: 0x00B53AA4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int ShowGildToggleUnopenMask(IntPtr l)
	{
		int result;
		try
		{
			TeamRoomInviteUIController teamRoomInviteUIController = (TeamRoomInviteUIController)LuaObject.checkSelf(l);
			bool isShow;
			LuaObject.checkType(l, 2, out isShow);
			teamRoomInviteUIController.ShowGildToggleUnopenMask(isShow);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060217E6 RID: 137190 RVA: 0x00B558FC File Offset: 0x00B53AFC
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int OnBindFiledsCompleted(IntPtr l)
	{
		int result;
		try
		{
			TeamRoomInviteUIController teamRoomInviteUIController = (TeamRoomInviteUIController)LuaObject.checkSelf(l);
			teamRoomInviteUIController.m_luaExportHelper.OnBindFiledsCompleted();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060217E7 RID: 137191 RVA: 0x00B55950 File Offset: 0x00B53B50
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int IsRecentTeamBattlePlayer(IntPtr l)
	{
		int result;
		try
		{
			TeamRoomInviteUIController teamRoomInviteUIController = (TeamRoomInviteUIController)LuaObject.checkSelf(l);
			string userId;
			LuaObject.checkType(l, 2, out userId);
			bool b = teamRoomInviteUIController.m_luaExportHelper.IsRecentTeamBattlePlayer(userId);
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

	// Token: 0x060217E8 RID: 137192 RVA: 0x00B559B8 File Offset: 0x00B53BB8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int AddPlayerListItem(IntPtr l)
	{
		int result;
		try
		{
			TeamRoomInviteUIController teamRoomInviteUIController = (TeamRoomInviteUIController)LuaObject.checkSelf(l);
			string userId;
			LuaObject.checkType(l, 2, out userId);
			string name;
			LuaObject.checkType(l, 3, out name);
			int headIconId;
			LuaObject.checkType(l, 4, out headIconId);
			int level;
			LuaObject.checkType(l, 5, out level);
			bool isRecent;
			LuaObject.checkType(l, 6, out isRecent);
			teamRoomInviteUIController.m_luaExportHelper.AddPlayerListItem(userId, name, headIconId, level, isRecent);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060217E9 RID: 137193 RVA: 0x00B55A48 File Offset: 0x00B53C48
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int ClearPlayerListItems(IntPtr l)
	{
		int result;
		try
		{
			TeamRoomInviteUIController teamRoomInviteUIController = (TeamRoomInviteUIController)LuaObject.checkSelf(l);
			teamRoomInviteUIController.m_luaExportHelper.ClearPlayerListItems();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060217EA RID: 137194 RVA: 0x00B55A9C File Offset: 0x00B53C9C
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int OnFriendToggleValueChanged(IntPtr l)
	{
		int result;
		try
		{
			TeamRoomInviteUIController teamRoomInviteUIController = (TeamRoomInviteUIController)LuaObject.checkSelf(l);
			bool isOn;
			LuaObject.checkType(l, 2, out isOn);
			teamRoomInviteUIController.m_luaExportHelper.OnFriendToggleValueChanged(isOn);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060217EB RID: 137195 RVA: 0x00B55AF8 File Offset: 0x00B53CF8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int OnRecentToggleValueChanged(IntPtr l)
	{
		int result;
		try
		{
			TeamRoomInviteUIController teamRoomInviteUIController = (TeamRoomInviteUIController)LuaObject.checkSelf(l);
			bool isOn;
			LuaObject.checkType(l, 2, out isOn);
			teamRoomInviteUIController.m_luaExportHelper.OnRecentToggleValueChanged(isOn);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060217EC RID: 137196 RVA: 0x00B55B54 File Offset: 0x00B53D54
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int OnGuildToggleValueChanged(IntPtr l)
	{
		int result;
		try
		{
			TeamRoomInviteUIController teamRoomInviteUIController = (TeamRoomInviteUIController)LuaObject.checkSelf(l);
			bool isOn;
			LuaObject.checkType(l, 2, out isOn);
			teamRoomInviteUIController.m_luaExportHelper.OnGuildToggleValueChanged(isOn);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060217ED RID: 137197 RVA: 0x00B55BB0 File Offset: 0x00B53DB0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int OnGuildUnopenMaskClick(IntPtr l)
	{
		int result;
		try
		{
			TeamRoomInviteUIController teamRoomInviteUIController = (TeamRoomInviteUIController)LuaObject.checkSelf(l);
			teamRoomInviteUIController.m_luaExportHelper.OnGuildUnopenMaskClick();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060217EE RID: 137198 RVA: 0x00B55C04 File Offset: 0x00B53E04
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int OnConfirmButtonClick(IntPtr l)
	{
		int result;
		try
		{
			TeamRoomInviteUIController teamRoomInviteUIController = (TeamRoomInviteUIController)LuaObject.checkSelf(l);
			teamRoomInviteUIController.m_luaExportHelper.OnConfirmButtonClick();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060217EF RID: 137199 RVA: 0x00B55C58 File Offset: 0x00B53E58
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int OnCancelButtonClick(IntPtr l)
	{
		int result;
		try
		{
			TeamRoomInviteUIController teamRoomInviteUIController = (TeamRoomInviteUIController)LuaObject.checkSelf(l);
			teamRoomInviteUIController.m_luaExportHelper.OnCancelButtonClick();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060217F0 RID: 137200 RVA: 0x00B55CAC File Offset: 0x00B53EAC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_Initlize(IntPtr l)
	{
		int result;
		try
		{
			TeamRoomInviteUIController teamRoomInviteUIController = (TeamRoomInviteUIController)LuaObject.checkSelf(l);
			string ctrlName;
			LuaObject.checkType(l, 2, out ctrlName);
			bool bindNow;
			LuaObject.checkType(l, 3, out bindNow);
			teamRoomInviteUIController.m_luaExportHelper.__callBase_Initlize(ctrlName, bindNow);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060217F1 RID: 137201 RVA: 0x00B55D18 File Offset: 0x00B53F18
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int __callBase_BindFields(IntPtr l)
	{
		int result;
		try
		{
			TeamRoomInviteUIController teamRoomInviteUIController = (TeamRoomInviteUIController)LuaObject.checkSelf(l);
			teamRoomInviteUIController.m_luaExportHelper.__callBase_BindFields();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060217F2 RID: 137202 RVA: 0x00B55D6C File Offset: 0x00B53F6C
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int __callBase_OnBindFiledsCompleted(IntPtr l)
	{
		int result;
		try
		{
			TeamRoomInviteUIController teamRoomInviteUIController = (TeamRoomInviteUIController)LuaObject.checkSelf(l);
			teamRoomInviteUIController.m_luaExportHelper.__callBase_OnBindFiledsCompleted();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060217F3 RID: 137203 RVA: 0x00B55DC0 File Offset: 0x00B53FC0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_BindFieldImpl(IntPtr l)
	{
		int result;
		try
		{
			TeamRoomInviteUIController teamRoomInviteUIController = (TeamRoomInviteUIController)LuaObject.checkSelf(l);
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
			UnityEngine.Object o = teamRoomInviteUIController.m_luaExportHelper.__callBase_BindFieldImpl(fieldType, path, initState, fieldName, ctrlName, optional);
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

	// Token: 0x060217F4 RID: 137204 RVA: 0x00B55E68 File Offset: 0x00B54068
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_Clear(IntPtr l)
	{
		int result;
		try
		{
			TeamRoomInviteUIController teamRoomInviteUIController = (TeamRoomInviteUIController)LuaObject.checkSelf(l);
			teamRoomInviteUIController.m_luaExportHelper.__callBase_Clear();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060217F5 RID: 137205 RVA: 0x00B55EBC File Offset: 0x00B540BC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_OnButtonClick(IntPtr l)
	{
		int result;
		try
		{
			TeamRoomInviteUIController teamRoomInviteUIController = (TeamRoomInviteUIController)LuaObject.checkSelf(l);
			Button button;
			LuaObject.checkType<Button>(l, 2, out button);
			string fieldName;
			LuaObject.checkType(l, 3, out fieldName);
			teamRoomInviteUIController.m_luaExportHelper.__callBase_OnButtonClick(button, fieldName);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060217F6 RID: 137206 RVA: 0x00B55F28 File Offset: 0x00B54128
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
				TeamRoomInviteUIController teamRoomInviteUIController = (TeamRoomInviteUIController)LuaObject.checkSelf(l);
				string[] fieldNames;
				LuaObject.checkArray<string>(l, 2, out fieldNames);
				Action<UIControllerBase> action;
				LuaObject.checkDelegate<Action<UIControllerBase>>(l, 3, out action);
				teamRoomInviteUIController.m_luaExportHelper.__callBase_SetButtonClickListener(fieldNames, action);
				LuaObject.pushValue(l, true);
				result = 1;
			}
			else if (LuaObject.matchType(l, total, 2, typeof(string), typeof(Action<UIControllerBase>)))
			{
				TeamRoomInviteUIController teamRoomInviteUIController2 = (TeamRoomInviteUIController)LuaObject.checkSelf(l);
				string fieldName;
				LuaObject.checkType(l, 2, out fieldName);
				Action<UIControllerBase> action2;
				LuaObject.checkDelegate<Action<UIControllerBase>>(l, 3, out action2);
				teamRoomInviteUIController2.m_luaExportHelper.__callBase_SetButtonClickListener(fieldName, action2);
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

	// Token: 0x060217F7 RID: 137207 RVA: 0x00B56038 File Offset: 0x00B54238
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_SetButtonDoubleClickListener(IntPtr l)
	{
		int result;
		try
		{
			TeamRoomInviteUIController teamRoomInviteUIController = (TeamRoomInviteUIController)LuaObject.checkSelf(l);
			string fieldName;
			LuaObject.checkType(l, 2, out fieldName);
			Action<UIControllerBase> action;
			LuaObject.checkDelegate<Action<UIControllerBase>>(l, 3, out action);
			teamRoomInviteUIController.m_luaExportHelper.__callBase_SetButtonDoubleClickListener(fieldName, action);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060217F8 RID: 137208 RVA: 0x00B560A4 File Offset: 0x00B542A4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_SetButtonLongPressStartListener(IntPtr l)
	{
		int result;
		try
		{
			TeamRoomInviteUIController teamRoomInviteUIController = (TeamRoomInviteUIController)LuaObject.checkSelf(l);
			string fieldName;
			LuaObject.checkType(l, 2, out fieldName);
			Action<UIControllerBase> action;
			LuaObject.checkDelegate<Action<UIControllerBase>>(l, 3, out action);
			teamRoomInviteUIController.m_luaExportHelper.__callBase_SetButtonLongPressStartListener(fieldName, action);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060217F9 RID: 137209 RVA: 0x00B56110 File Offset: 0x00B54310
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_SetButtonLongPressingListener(IntPtr l)
	{
		int result;
		try
		{
			TeamRoomInviteUIController teamRoomInviteUIController = (TeamRoomInviteUIController)LuaObject.checkSelf(l);
			string fieldName;
			LuaObject.checkType(l, 2, out fieldName);
			Action<UIControllerBase> action;
			LuaObject.checkDelegate<Action<UIControllerBase>>(l, 3, out action);
			teamRoomInviteUIController.m_luaExportHelper.__callBase_SetButtonLongPressingListener(fieldName, action);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060217FA RID: 137210 RVA: 0x00B5617C File Offset: 0x00B5437C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_SetButtonLongPressEndListener(IntPtr l)
	{
		int result;
		try
		{
			TeamRoomInviteUIController teamRoomInviteUIController = (TeamRoomInviteUIController)LuaObject.checkSelf(l);
			string fieldName;
			LuaObject.checkType(l, 2, out fieldName);
			Action<UIControllerBase> action;
			LuaObject.checkDelegate<Action<UIControllerBase>>(l, 3, out action);
			teamRoomInviteUIController.m_luaExportHelper.__callBase_SetButtonLongPressEndListener(fieldName, action);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060217FB RID: 137211 RVA: 0x00B561E8 File Offset: 0x00B543E8
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
				TeamRoomInviteUIController teamRoomInviteUIController = (TeamRoomInviteUIController)LuaObject.checkSelf(l);
				string[] fieldNames;
				LuaObject.checkArray<string>(l, 2, out fieldNames);
				Action<UIControllerBase, bool> action;
				LuaObject.checkDelegate<Action<UIControllerBase, bool>>(l, 3, out action);
				teamRoomInviteUIController.m_luaExportHelper.__callBase_SetToggleValueChangedListener(fieldNames, action);
				LuaObject.pushValue(l, true);
				result = 1;
			}
			else if (LuaObject.matchType(l, total, 2, typeof(string), typeof(Action<UIControllerBase, bool>)))
			{
				TeamRoomInviteUIController teamRoomInviteUIController2 = (TeamRoomInviteUIController)LuaObject.checkSelf(l);
				string fieldName;
				LuaObject.checkType(l, 2, out fieldName);
				Action<UIControllerBase, bool> action2;
				LuaObject.checkDelegate<Action<UIControllerBase, bool>>(l, 3, out action2);
				teamRoomInviteUIController2.m_luaExportHelper.__callBase_SetToggleValueChangedListener(fieldName, action2);
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

	// Token: 0x060217FC RID: 137212 RVA: 0x00B562F8 File Offset: 0x00B544F8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_ToString(IntPtr l)
	{
		int result;
		try
		{
			TeamRoomInviteUIController teamRoomInviteUIController = (TeamRoomInviteUIController)LuaObject.checkSelf(l);
			string s = teamRoomInviteUIController.m_luaExportHelper.__callBase_ToString();
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

	// Token: 0x060217FD RID: 137213 RVA: 0x00B56354 File Offset: 0x00B54554
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callDele_EventOnConfirm(IntPtr l)
	{
		int result;
		try
		{
			TeamRoomInviteUIController teamRoomInviteUIController = (TeamRoomInviteUIController)LuaObject.checkSelf(l);
			List<string> obj;
			LuaObject.checkType<List<string>>(l, 2, out obj);
			teamRoomInviteUIController.m_luaExportHelper.__callDele_EventOnConfirm(obj);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060217FE RID: 137214 RVA: 0x00B563B0 File Offset: 0x00B545B0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __clearDele_EventOnConfirm(IntPtr l)
	{
		int result;
		try
		{
			TeamRoomInviteUIController teamRoomInviteUIController = (TeamRoomInviteUIController)LuaObject.checkSelf(l);
			List<string> obj;
			LuaObject.checkType<List<string>>(l, 2, out obj);
			teamRoomInviteUIController.m_luaExportHelper.__clearDele_EventOnConfirm(obj);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060217FF RID: 137215 RVA: 0x00B5640C File Offset: 0x00B5460C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callDele_EventOnCancel(IntPtr l)
	{
		int result;
		try
		{
			TeamRoomInviteUIController teamRoomInviteUIController = (TeamRoomInviteUIController)LuaObject.checkSelf(l);
			teamRoomInviteUIController.m_luaExportHelper.__callDele_EventOnCancel();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06021800 RID: 137216 RVA: 0x00B56460 File Offset: 0x00B54660
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __clearDele_EventOnCancel(IntPtr l)
	{
		int result;
		try
		{
			TeamRoomInviteUIController teamRoomInviteUIController = (TeamRoomInviteUIController)LuaObject.checkSelf(l);
			teamRoomInviteUIController.m_luaExportHelper.__clearDele_EventOnCancel();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06021801 RID: 137217 RVA: 0x00B564B4 File Offset: 0x00B546B4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callDele_EventOnChangePlayerType(IntPtr l)
	{
		int result;
		try
		{
			TeamRoomInviteUIController teamRoomInviteUIController = (TeamRoomInviteUIController)LuaObject.checkSelf(l);
			TeamRoomInvitePlayerType obj;
			LuaObject.checkEnum<TeamRoomInvitePlayerType>(l, 2, out obj);
			teamRoomInviteUIController.m_luaExportHelper.__callDele_EventOnChangePlayerType(obj);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06021802 RID: 137218 RVA: 0x00B56510 File Offset: 0x00B54710
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __clearDele_EventOnChangePlayerType(IntPtr l)
	{
		int result;
		try
		{
			TeamRoomInviteUIController teamRoomInviteUIController = (TeamRoomInviteUIController)LuaObject.checkSelf(l);
			TeamRoomInvitePlayerType obj;
			LuaObject.checkEnum<TeamRoomInvitePlayerType>(l, 2, out obj);
			teamRoomInviteUIController.m_luaExportHelper.__clearDele_EventOnChangePlayerType(obj);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06021803 RID: 137219 RVA: 0x00B5656C File Offset: 0x00B5476C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_EventOnConfirm(IntPtr l)
	{
		int result;
		try
		{
			TeamRoomInviteUIController teamRoomInviteUIController = (TeamRoomInviteUIController)LuaObject.checkSelf(l);
			Action<List<string>> value;
			int num = LuaObject.checkDelegate<Action<List<string>>>(l, 2, out value);
			if (num != 0)
			{
				if (num == 1)
				{
					teamRoomInviteUIController.EventOnConfirm += value;
				}
				else if (num == 2)
				{
					teamRoomInviteUIController.EventOnConfirm -= value;
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

	// Token: 0x06021804 RID: 137220 RVA: 0x00B565EC File Offset: 0x00B547EC
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_EventOnCancel(IntPtr l)
	{
		int result;
		try
		{
			TeamRoomInviteUIController teamRoomInviteUIController = (TeamRoomInviteUIController)LuaObject.checkSelf(l);
			Action value;
			int num = LuaObject.checkDelegate<Action>(l, 2, out value);
			if (num != 0)
			{
				if (num == 1)
				{
					teamRoomInviteUIController.EventOnCancel += value;
				}
				else if (num == 2)
				{
					teamRoomInviteUIController.EventOnCancel -= value;
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

	// Token: 0x06021805 RID: 137221 RVA: 0x00B5666C File Offset: 0x00B5486C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_EventOnChangePlayerType(IntPtr l)
	{
		int result;
		try
		{
			TeamRoomInviteUIController teamRoomInviteUIController = (TeamRoomInviteUIController)LuaObject.checkSelf(l);
			Action<TeamRoomInvitePlayerType> value;
			int num = LuaObject.checkDelegate<Action<TeamRoomInvitePlayerType>>(l, 2, out value);
			if (num != 0)
			{
				if (num == 1)
				{
					teamRoomInviteUIController.EventOnChangePlayerType += value;
				}
				else if (num == 2)
				{
					teamRoomInviteUIController.EventOnChangePlayerType -= value;
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

	// Token: 0x06021806 RID: 137222 RVA: 0x00B566EC File Offset: 0x00B548EC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_uiStateController(IntPtr l)
	{
		int result;
		try
		{
			TeamRoomInviteUIController teamRoomInviteUIController = (TeamRoomInviteUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, teamRoomInviteUIController.m_luaExportHelper.m_uiStateController);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06021807 RID: 137223 RVA: 0x00B56744 File Offset: 0x00B54944
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_uiStateController(IntPtr l)
	{
		int result;
		try
		{
			TeamRoomInviteUIController teamRoomInviteUIController = (TeamRoomInviteUIController)LuaObject.checkSelf(l);
			CommonUIStateController uiStateController;
			LuaObject.checkType<CommonUIStateController>(l, 2, out uiStateController);
			teamRoomInviteUIController.m_luaExportHelper.m_uiStateController = uiStateController;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06021808 RID: 137224 RVA: 0x00B567A0 File Offset: 0x00B549A0
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_m_friendToggle(IntPtr l)
	{
		int result;
		try
		{
			TeamRoomInviteUIController teamRoomInviteUIController = (TeamRoomInviteUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, teamRoomInviteUIController.m_luaExportHelper.m_friendToggle);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06021809 RID: 137225 RVA: 0x00B567F8 File Offset: 0x00B549F8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_friendToggle(IntPtr l)
	{
		int result;
		try
		{
			TeamRoomInviteUIController teamRoomInviteUIController = (TeamRoomInviteUIController)LuaObject.checkSelf(l);
			Toggle friendToggle;
			LuaObject.checkType<Toggle>(l, 2, out friendToggle);
			teamRoomInviteUIController.m_luaExportHelper.m_friendToggle = friendToggle;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0602180A RID: 137226 RVA: 0x00B56854 File Offset: 0x00B54A54
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_recentToggle(IntPtr l)
	{
		int result;
		try
		{
			TeamRoomInviteUIController teamRoomInviteUIController = (TeamRoomInviteUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, teamRoomInviteUIController.m_luaExportHelper.m_recentToggle);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0602180B RID: 137227 RVA: 0x00B568AC File Offset: 0x00B54AAC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_recentToggle(IntPtr l)
	{
		int result;
		try
		{
			TeamRoomInviteUIController teamRoomInviteUIController = (TeamRoomInviteUIController)LuaObject.checkSelf(l);
			Toggle recentToggle;
			LuaObject.checkType<Toggle>(l, 2, out recentToggle);
			teamRoomInviteUIController.m_luaExportHelper.m_recentToggle = recentToggle;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0602180C RID: 137228 RVA: 0x00B56908 File Offset: 0x00B54B08
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_guildToggle(IntPtr l)
	{
		int result;
		try
		{
			TeamRoomInviteUIController teamRoomInviteUIController = (TeamRoomInviteUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, teamRoomInviteUIController.m_luaExportHelper.m_guildToggle);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0602180D RID: 137229 RVA: 0x00B56960 File Offset: 0x00B54B60
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_m_guildToggle(IntPtr l)
	{
		int result;
		try
		{
			TeamRoomInviteUIController teamRoomInviteUIController = (TeamRoomInviteUIController)LuaObject.checkSelf(l);
			Toggle guildToggle;
			LuaObject.checkType<Toggle>(l, 2, out guildToggle);
			teamRoomInviteUIController.m_luaExportHelper.m_guildToggle = guildToggle;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0602180E RID: 137230 RVA: 0x00B569BC File Offset: 0x00B54BBC
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_m_guildToggleUnopenMask(IntPtr l)
	{
		int result;
		try
		{
			TeamRoomInviteUIController teamRoomInviteUIController = (TeamRoomInviteUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, teamRoomInviteUIController.m_luaExportHelper.m_guildToggleUnopenMask);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0602180F RID: 137231 RVA: 0x00B56A14 File Offset: 0x00B54C14
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_guildToggleUnopenMask(IntPtr l)
	{
		int result;
		try
		{
			TeamRoomInviteUIController teamRoomInviteUIController = (TeamRoomInviteUIController)LuaObject.checkSelf(l);
			Button guildToggleUnopenMask;
			LuaObject.checkType<Button>(l, 2, out guildToggleUnopenMask);
			teamRoomInviteUIController.m_luaExportHelper.m_guildToggleUnopenMask = guildToggleUnopenMask;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06021810 RID: 137232 RVA: 0x00B56A70 File Offset: 0x00B54C70
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_m_confirmButton(IntPtr l)
	{
		int result;
		try
		{
			TeamRoomInviteUIController teamRoomInviteUIController = (TeamRoomInviteUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, teamRoomInviteUIController.m_luaExportHelper.m_confirmButton);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06021811 RID: 137233 RVA: 0x00B56AC8 File Offset: 0x00B54CC8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_confirmButton(IntPtr l)
	{
		int result;
		try
		{
			TeamRoomInviteUIController teamRoomInviteUIController = (TeamRoomInviteUIController)LuaObject.checkSelf(l);
			Button confirmButton;
			LuaObject.checkType<Button>(l, 2, out confirmButton);
			teamRoomInviteUIController.m_luaExportHelper.m_confirmButton = confirmButton;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06021812 RID: 137234 RVA: 0x00B56B24 File Offset: 0x00B54D24
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_cancelButton(IntPtr l)
	{
		int result;
		try
		{
			TeamRoomInviteUIController teamRoomInviteUIController = (TeamRoomInviteUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, teamRoomInviteUIController.m_luaExportHelper.m_cancelButton);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06021813 RID: 137235 RVA: 0x00B56B7C File Offset: 0x00B54D7C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_cancelButton(IntPtr l)
	{
		int result;
		try
		{
			TeamRoomInviteUIController teamRoomInviteUIController = (TeamRoomInviteUIController)LuaObject.checkSelf(l);
			Button cancelButton;
			LuaObject.checkType<Button>(l, 2, out cancelButton);
			teamRoomInviteUIController.m_luaExportHelper.m_cancelButton = cancelButton;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06021814 RID: 137236 RVA: 0x00B56BD8 File Offset: 0x00B54DD8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_inviteScrollRect(IntPtr l)
	{
		int result;
		try
		{
			TeamRoomInviteUIController teamRoomInviteUIController = (TeamRoomInviteUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, teamRoomInviteUIController.m_luaExportHelper.m_inviteScrollRect);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06021815 RID: 137237 RVA: 0x00B56C30 File Offset: 0x00B54E30
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_inviteScrollRect(IntPtr l)
	{
		int result;
		try
		{
			TeamRoomInviteUIController teamRoomInviteUIController = (TeamRoomInviteUIController)LuaObject.checkSelf(l);
			ScrollRect inviteScrollRect;
			LuaObject.checkType<ScrollRect>(l, 2, out inviteScrollRect);
			teamRoomInviteUIController.m_luaExportHelper.m_inviteScrollRect = inviteScrollRect;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06021816 RID: 137238 RVA: 0x00B56C8C File Offset: 0x00B54E8C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_inviteCountTitleText(IntPtr l)
	{
		int result;
		try
		{
			TeamRoomInviteUIController teamRoomInviteUIController = (TeamRoomInviteUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, teamRoomInviteUIController.m_luaExportHelper.m_inviteCountTitleText);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06021817 RID: 137239 RVA: 0x00B56CE4 File Offset: 0x00B54EE4
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_m_inviteCountTitleText(IntPtr l)
	{
		int result;
		try
		{
			TeamRoomInviteUIController teamRoomInviteUIController = (TeamRoomInviteUIController)LuaObject.checkSelf(l);
			Text inviteCountTitleText;
			LuaObject.checkType<Text>(l, 2, out inviteCountTitleText);
			teamRoomInviteUIController.m_luaExportHelper.m_inviteCountTitleText = inviteCountTitleText;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06021818 RID: 137240 RVA: 0x00B56D40 File Offset: 0x00B54F40
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_inviteCountValueText(IntPtr l)
	{
		int result;
		try
		{
			TeamRoomInviteUIController teamRoomInviteUIController = (TeamRoomInviteUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, teamRoomInviteUIController.m_luaExportHelper.m_inviteCountValueText);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06021819 RID: 137241 RVA: 0x00B56D98 File Offset: 0x00B54F98
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_m_inviteCountValueText(IntPtr l)
	{
		int result;
		try
		{
			TeamRoomInviteUIController teamRoomInviteUIController = (TeamRoomInviteUIController)LuaObject.checkSelf(l);
			Text inviteCountValueText;
			LuaObject.checkType<Text>(l, 2, out inviteCountValueText);
			teamRoomInviteUIController.m_luaExportHelper.m_inviteCountValueText = inviteCountValueText;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0602181A RID: 137242 RVA: 0x00B56DF4 File Offset: 0x00B54FF4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_prefabsGameObject(IntPtr l)
	{
		int result;
		try
		{
			TeamRoomInviteUIController teamRoomInviteUIController = (TeamRoomInviteUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, teamRoomInviteUIController.m_luaExportHelper.m_prefabsGameObject);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0602181B RID: 137243 RVA: 0x00B56E4C File Offset: 0x00B5504C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_prefabsGameObject(IntPtr l)
	{
		int result;
		try
		{
			TeamRoomInviteUIController teamRoomInviteUIController = (TeamRoomInviteUIController)LuaObject.checkSelf(l);
			GameObject prefabsGameObject;
			LuaObject.checkType<GameObject>(l, 2, out prefabsGameObject);
			teamRoomInviteUIController.m_luaExportHelper.m_prefabsGameObject = prefabsGameObject;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0602181C RID: 137244 RVA: 0x00B56EA8 File Offset: 0x00B550A8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_invitePlayerListItemPrefab(IntPtr l)
	{
		int result;
		try
		{
			TeamRoomInviteUIController teamRoomInviteUIController = (TeamRoomInviteUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, teamRoomInviteUIController.m_luaExportHelper.m_invitePlayerListItemPrefab);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0602181D RID: 137245 RVA: 0x00B56F00 File Offset: 0x00B55100
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_invitePlayerListItemPrefab(IntPtr l)
	{
		int result;
		try
		{
			TeamRoomInviteUIController teamRoomInviteUIController = (TeamRoomInviteUIController)LuaObject.checkSelf(l);
			GameObject invitePlayerListItemPrefab;
			LuaObject.checkType<GameObject>(l, 2, out invitePlayerListItemPrefab);
			teamRoomInviteUIController.m_luaExportHelper.m_invitePlayerListItemPrefab = invitePlayerListItemPrefab;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0602181E RID: 137246 RVA: 0x00B56F5C File Offset: 0x00B5515C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_playerListItems(IntPtr l)
	{
		int result;
		try
		{
			TeamRoomInviteUIController teamRoomInviteUIController = (TeamRoomInviteUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, teamRoomInviteUIController.m_luaExportHelper.m_playerListItems);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0602181F RID: 137247 RVA: 0x00B56FB4 File Offset: 0x00B551B4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_playerListItems(IntPtr l)
	{
		int result;
		try
		{
			TeamRoomInviteUIController teamRoomInviteUIController = (TeamRoomInviteUIController)LuaObject.checkSelf(l);
			List<TeamRoomInvitePlayerListItemUIController> playerListItems;
			LuaObject.checkType<List<TeamRoomInvitePlayerListItemUIController>>(l, 2, out playerListItems);
			teamRoomInviteUIController.m_luaExportHelper.m_playerListItems = playerListItems;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06021820 RID: 137248 RVA: 0x00B57010 File Offset: 0x00B55210
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_isIgnoreToggleEvent(IntPtr l)
	{
		int result;
		try
		{
			TeamRoomInviteUIController teamRoomInviteUIController = (TeamRoomInviteUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, teamRoomInviteUIController.m_luaExportHelper.m_isIgnoreToggleEvent);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06021821 RID: 137249 RVA: 0x00B57068 File Offset: 0x00B55268
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_m_isIgnoreToggleEvent(IntPtr l)
	{
		int result;
		try
		{
			TeamRoomInviteUIController teamRoomInviteUIController = (TeamRoomInviteUIController)LuaObject.checkSelf(l);
			bool isIgnoreToggleEvent;
			LuaObject.checkType(l, 2, out isIgnoreToggleEvent);
			teamRoomInviteUIController.m_luaExportHelper.m_isIgnoreToggleEvent = isIgnoreToggleEvent;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06021822 RID: 137250 RVA: 0x00B570C4 File Offset: 0x00B552C4
	[Preserve]
	public static void reg(IntPtr l)
	{
		LuaObject.getTypeTable(l, "BlackJack.ProjectL.UI.TeamRoomInviteUIController");
		if (Lua_BlackJack_ProjectL_UI_TeamRoomInviteUIController.<>f__mg$cache0 == null)
		{
			Lua_BlackJack_ProjectL_UI_TeamRoomInviteUIController.<>f__mg$cache0 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_TeamRoomInviteUIController.Open);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_TeamRoomInviteUIController.<>f__mg$cache0);
		if (Lua_BlackJack_ProjectL_UI_TeamRoomInviteUIController.<>f__mg$cache1 == null)
		{
			Lua_BlackJack_ProjectL_UI_TeamRoomInviteUIController.<>f__mg$cache1 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_TeamRoomInviteUIController.SetPlayerType);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_TeamRoomInviteUIController.<>f__mg$cache1);
		if (Lua_BlackJack_ProjectL_UI_TeamRoomInviteUIController.<>f__mg$cache2 == null)
		{
			Lua_BlackJack_ProjectL_UI_TeamRoomInviteUIController.<>f__mg$cache2 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_TeamRoomInviteUIController.Close);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_TeamRoomInviteUIController.<>f__mg$cache2);
		if (Lua_BlackJack_ProjectL_UI_TeamRoomInviteUIController.<>f__mg$cache3 == null)
		{
			Lua_BlackJack_ProjectL_UI_TeamRoomInviteUIController.<>f__mg$cache3 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_TeamRoomInviteUIController.SetPlayers);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_TeamRoomInviteUIController.<>f__mg$cache3);
		if (Lua_BlackJack_ProjectL_UI_TeamRoomInviteUIController.<>f__mg$cache4 == null)
		{
			Lua_BlackJack_ProjectL_UI_TeamRoomInviteUIController.<>f__mg$cache4 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_TeamRoomInviteUIController.UpdatePlayerStatus);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_TeamRoomInviteUIController.<>f__mg$cache4);
		if (Lua_BlackJack_ProjectL_UI_TeamRoomInviteUIController.<>f__mg$cache5 == null)
		{
			Lua_BlackJack_ProjectL_UI_TeamRoomInviteUIController.<>f__mg$cache5 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_TeamRoomInviteUIController.ShowGildToggleUnopenMask);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_TeamRoomInviteUIController.<>f__mg$cache5);
		if (Lua_BlackJack_ProjectL_UI_TeamRoomInviteUIController.<>f__mg$cache6 == null)
		{
			Lua_BlackJack_ProjectL_UI_TeamRoomInviteUIController.<>f__mg$cache6 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_TeamRoomInviteUIController.OnBindFiledsCompleted);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_TeamRoomInviteUIController.<>f__mg$cache6);
		if (Lua_BlackJack_ProjectL_UI_TeamRoomInviteUIController.<>f__mg$cache7 == null)
		{
			Lua_BlackJack_ProjectL_UI_TeamRoomInviteUIController.<>f__mg$cache7 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_TeamRoomInviteUIController.IsRecentTeamBattlePlayer);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_TeamRoomInviteUIController.<>f__mg$cache7);
		if (Lua_BlackJack_ProjectL_UI_TeamRoomInviteUIController.<>f__mg$cache8 == null)
		{
			Lua_BlackJack_ProjectL_UI_TeamRoomInviteUIController.<>f__mg$cache8 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_TeamRoomInviteUIController.AddPlayerListItem);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_TeamRoomInviteUIController.<>f__mg$cache8);
		if (Lua_BlackJack_ProjectL_UI_TeamRoomInviteUIController.<>f__mg$cache9 == null)
		{
			Lua_BlackJack_ProjectL_UI_TeamRoomInviteUIController.<>f__mg$cache9 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_TeamRoomInviteUIController.ClearPlayerListItems);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_TeamRoomInviteUIController.<>f__mg$cache9);
		if (Lua_BlackJack_ProjectL_UI_TeamRoomInviteUIController.<>f__mg$cacheA == null)
		{
			Lua_BlackJack_ProjectL_UI_TeamRoomInviteUIController.<>f__mg$cacheA = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_TeamRoomInviteUIController.OnFriendToggleValueChanged);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_TeamRoomInviteUIController.<>f__mg$cacheA);
		if (Lua_BlackJack_ProjectL_UI_TeamRoomInviteUIController.<>f__mg$cacheB == null)
		{
			Lua_BlackJack_ProjectL_UI_TeamRoomInviteUIController.<>f__mg$cacheB = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_TeamRoomInviteUIController.OnRecentToggleValueChanged);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_TeamRoomInviteUIController.<>f__mg$cacheB);
		if (Lua_BlackJack_ProjectL_UI_TeamRoomInviteUIController.<>f__mg$cacheC == null)
		{
			Lua_BlackJack_ProjectL_UI_TeamRoomInviteUIController.<>f__mg$cacheC = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_TeamRoomInviteUIController.OnGuildToggleValueChanged);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_TeamRoomInviteUIController.<>f__mg$cacheC);
		if (Lua_BlackJack_ProjectL_UI_TeamRoomInviteUIController.<>f__mg$cacheD == null)
		{
			Lua_BlackJack_ProjectL_UI_TeamRoomInviteUIController.<>f__mg$cacheD = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_TeamRoomInviteUIController.OnGuildUnopenMaskClick);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_TeamRoomInviteUIController.<>f__mg$cacheD);
		if (Lua_BlackJack_ProjectL_UI_TeamRoomInviteUIController.<>f__mg$cacheE == null)
		{
			Lua_BlackJack_ProjectL_UI_TeamRoomInviteUIController.<>f__mg$cacheE = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_TeamRoomInviteUIController.OnConfirmButtonClick);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_TeamRoomInviteUIController.<>f__mg$cacheE);
		if (Lua_BlackJack_ProjectL_UI_TeamRoomInviteUIController.<>f__mg$cacheF == null)
		{
			Lua_BlackJack_ProjectL_UI_TeamRoomInviteUIController.<>f__mg$cacheF = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_TeamRoomInviteUIController.OnCancelButtonClick);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_TeamRoomInviteUIController.<>f__mg$cacheF);
		if (Lua_BlackJack_ProjectL_UI_TeamRoomInviteUIController.<>f__mg$cache10 == null)
		{
			Lua_BlackJack_ProjectL_UI_TeamRoomInviteUIController.<>f__mg$cache10 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_TeamRoomInviteUIController.__callBase_Initlize);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_TeamRoomInviteUIController.<>f__mg$cache10);
		if (Lua_BlackJack_ProjectL_UI_TeamRoomInviteUIController.<>f__mg$cache11 == null)
		{
			Lua_BlackJack_ProjectL_UI_TeamRoomInviteUIController.<>f__mg$cache11 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_TeamRoomInviteUIController.__callBase_BindFields);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_TeamRoomInviteUIController.<>f__mg$cache11);
		if (Lua_BlackJack_ProjectL_UI_TeamRoomInviteUIController.<>f__mg$cache12 == null)
		{
			Lua_BlackJack_ProjectL_UI_TeamRoomInviteUIController.<>f__mg$cache12 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_TeamRoomInviteUIController.__callBase_OnBindFiledsCompleted);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_TeamRoomInviteUIController.<>f__mg$cache12);
		if (Lua_BlackJack_ProjectL_UI_TeamRoomInviteUIController.<>f__mg$cache13 == null)
		{
			Lua_BlackJack_ProjectL_UI_TeamRoomInviteUIController.<>f__mg$cache13 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_TeamRoomInviteUIController.__callBase_BindFieldImpl);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_TeamRoomInviteUIController.<>f__mg$cache13);
		if (Lua_BlackJack_ProjectL_UI_TeamRoomInviteUIController.<>f__mg$cache14 == null)
		{
			Lua_BlackJack_ProjectL_UI_TeamRoomInviteUIController.<>f__mg$cache14 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_TeamRoomInviteUIController.__callBase_Clear);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_TeamRoomInviteUIController.<>f__mg$cache14);
		if (Lua_BlackJack_ProjectL_UI_TeamRoomInviteUIController.<>f__mg$cache15 == null)
		{
			Lua_BlackJack_ProjectL_UI_TeamRoomInviteUIController.<>f__mg$cache15 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_TeamRoomInviteUIController.__callBase_OnButtonClick);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_TeamRoomInviteUIController.<>f__mg$cache15);
		if (Lua_BlackJack_ProjectL_UI_TeamRoomInviteUIController.<>f__mg$cache16 == null)
		{
			Lua_BlackJack_ProjectL_UI_TeamRoomInviteUIController.<>f__mg$cache16 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_TeamRoomInviteUIController.__callBase_SetButtonClickListener);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_TeamRoomInviteUIController.<>f__mg$cache16);
		if (Lua_BlackJack_ProjectL_UI_TeamRoomInviteUIController.<>f__mg$cache17 == null)
		{
			Lua_BlackJack_ProjectL_UI_TeamRoomInviteUIController.<>f__mg$cache17 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_TeamRoomInviteUIController.__callBase_SetButtonDoubleClickListener);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_TeamRoomInviteUIController.<>f__mg$cache17);
		if (Lua_BlackJack_ProjectL_UI_TeamRoomInviteUIController.<>f__mg$cache18 == null)
		{
			Lua_BlackJack_ProjectL_UI_TeamRoomInviteUIController.<>f__mg$cache18 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_TeamRoomInviteUIController.__callBase_SetButtonLongPressStartListener);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_TeamRoomInviteUIController.<>f__mg$cache18);
		if (Lua_BlackJack_ProjectL_UI_TeamRoomInviteUIController.<>f__mg$cache19 == null)
		{
			Lua_BlackJack_ProjectL_UI_TeamRoomInviteUIController.<>f__mg$cache19 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_TeamRoomInviteUIController.__callBase_SetButtonLongPressingListener);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_TeamRoomInviteUIController.<>f__mg$cache19);
		if (Lua_BlackJack_ProjectL_UI_TeamRoomInviteUIController.<>f__mg$cache1A == null)
		{
			Lua_BlackJack_ProjectL_UI_TeamRoomInviteUIController.<>f__mg$cache1A = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_TeamRoomInviteUIController.__callBase_SetButtonLongPressEndListener);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_TeamRoomInviteUIController.<>f__mg$cache1A);
		if (Lua_BlackJack_ProjectL_UI_TeamRoomInviteUIController.<>f__mg$cache1B == null)
		{
			Lua_BlackJack_ProjectL_UI_TeamRoomInviteUIController.<>f__mg$cache1B = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_TeamRoomInviteUIController.__callBase_SetToggleValueChangedListener);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_TeamRoomInviteUIController.<>f__mg$cache1B);
		if (Lua_BlackJack_ProjectL_UI_TeamRoomInviteUIController.<>f__mg$cache1C == null)
		{
			Lua_BlackJack_ProjectL_UI_TeamRoomInviteUIController.<>f__mg$cache1C = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_TeamRoomInviteUIController.__callBase_ToString);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_TeamRoomInviteUIController.<>f__mg$cache1C);
		if (Lua_BlackJack_ProjectL_UI_TeamRoomInviteUIController.<>f__mg$cache1D == null)
		{
			Lua_BlackJack_ProjectL_UI_TeamRoomInviteUIController.<>f__mg$cache1D = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_TeamRoomInviteUIController.__callDele_EventOnConfirm);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_TeamRoomInviteUIController.<>f__mg$cache1D);
		if (Lua_BlackJack_ProjectL_UI_TeamRoomInviteUIController.<>f__mg$cache1E == null)
		{
			Lua_BlackJack_ProjectL_UI_TeamRoomInviteUIController.<>f__mg$cache1E = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_TeamRoomInviteUIController.__clearDele_EventOnConfirm);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_TeamRoomInviteUIController.<>f__mg$cache1E);
		if (Lua_BlackJack_ProjectL_UI_TeamRoomInviteUIController.<>f__mg$cache1F == null)
		{
			Lua_BlackJack_ProjectL_UI_TeamRoomInviteUIController.<>f__mg$cache1F = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_TeamRoomInviteUIController.__callDele_EventOnCancel);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_TeamRoomInviteUIController.<>f__mg$cache1F);
		if (Lua_BlackJack_ProjectL_UI_TeamRoomInviteUIController.<>f__mg$cache20 == null)
		{
			Lua_BlackJack_ProjectL_UI_TeamRoomInviteUIController.<>f__mg$cache20 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_TeamRoomInviteUIController.__clearDele_EventOnCancel);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_TeamRoomInviteUIController.<>f__mg$cache20);
		if (Lua_BlackJack_ProjectL_UI_TeamRoomInviteUIController.<>f__mg$cache21 == null)
		{
			Lua_BlackJack_ProjectL_UI_TeamRoomInviteUIController.<>f__mg$cache21 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_TeamRoomInviteUIController.__callDele_EventOnChangePlayerType);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_TeamRoomInviteUIController.<>f__mg$cache21);
		if (Lua_BlackJack_ProjectL_UI_TeamRoomInviteUIController.<>f__mg$cache22 == null)
		{
			Lua_BlackJack_ProjectL_UI_TeamRoomInviteUIController.<>f__mg$cache22 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_TeamRoomInviteUIController.__clearDele_EventOnChangePlayerType);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_TeamRoomInviteUIController.<>f__mg$cache22);
		string name = "EventOnConfirm";
		LuaCSFunction get = null;
		if (Lua_BlackJack_ProjectL_UI_TeamRoomInviteUIController.<>f__mg$cache23 == null)
		{
			Lua_BlackJack_ProjectL_UI_TeamRoomInviteUIController.<>f__mg$cache23 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_TeamRoomInviteUIController.set_EventOnConfirm);
		}
		LuaObject.addMember(l, name, get, Lua_BlackJack_ProjectL_UI_TeamRoomInviteUIController.<>f__mg$cache23, true);
		string name2 = "EventOnCancel";
		LuaCSFunction get2 = null;
		if (Lua_BlackJack_ProjectL_UI_TeamRoomInviteUIController.<>f__mg$cache24 == null)
		{
			Lua_BlackJack_ProjectL_UI_TeamRoomInviteUIController.<>f__mg$cache24 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_TeamRoomInviteUIController.set_EventOnCancel);
		}
		LuaObject.addMember(l, name2, get2, Lua_BlackJack_ProjectL_UI_TeamRoomInviteUIController.<>f__mg$cache24, true);
		string name3 = "EventOnChangePlayerType";
		LuaCSFunction get3 = null;
		if (Lua_BlackJack_ProjectL_UI_TeamRoomInviteUIController.<>f__mg$cache25 == null)
		{
			Lua_BlackJack_ProjectL_UI_TeamRoomInviteUIController.<>f__mg$cache25 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_TeamRoomInviteUIController.set_EventOnChangePlayerType);
		}
		LuaObject.addMember(l, name3, get3, Lua_BlackJack_ProjectL_UI_TeamRoomInviteUIController.<>f__mg$cache25, true);
		string name4 = "m_uiStateController";
		if (Lua_BlackJack_ProjectL_UI_TeamRoomInviteUIController.<>f__mg$cache26 == null)
		{
			Lua_BlackJack_ProjectL_UI_TeamRoomInviteUIController.<>f__mg$cache26 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_TeamRoomInviteUIController.get_m_uiStateController);
		}
		LuaCSFunction get4 = Lua_BlackJack_ProjectL_UI_TeamRoomInviteUIController.<>f__mg$cache26;
		if (Lua_BlackJack_ProjectL_UI_TeamRoomInviteUIController.<>f__mg$cache27 == null)
		{
			Lua_BlackJack_ProjectL_UI_TeamRoomInviteUIController.<>f__mg$cache27 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_TeamRoomInviteUIController.set_m_uiStateController);
		}
		LuaObject.addMember(l, name4, get4, Lua_BlackJack_ProjectL_UI_TeamRoomInviteUIController.<>f__mg$cache27, true);
		string name5 = "m_friendToggle";
		if (Lua_BlackJack_ProjectL_UI_TeamRoomInviteUIController.<>f__mg$cache28 == null)
		{
			Lua_BlackJack_ProjectL_UI_TeamRoomInviteUIController.<>f__mg$cache28 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_TeamRoomInviteUIController.get_m_friendToggle);
		}
		LuaCSFunction get5 = Lua_BlackJack_ProjectL_UI_TeamRoomInviteUIController.<>f__mg$cache28;
		if (Lua_BlackJack_ProjectL_UI_TeamRoomInviteUIController.<>f__mg$cache29 == null)
		{
			Lua_BlackJack_ProjectL_UI_TeamRoomInviteUIController.<>f__mg$cache29 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_TeamRoomInviteUIController.set_m_friendToggle);
		}
		LuaObject.addMember(l, name5, get5, Lua_BlackJack_ProjectL_UI_TeamRoomInviteUIController.<>f__mg$cache29, true);
		string name6 = "m_recentToggle";
		if (Lua_BlackJack_ProjectL_UI_TeamRoomInviteUIController.<>f__mg$cache2A == null)
		{
			Lua_BlackJack_ProjectL_UI_TeamRoomInviteUIController.<>f__mg$cache2A = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_TeamRoomInviteUIController.get_m_recentToggle);
		}
		LuaCSFunction get6 = Lua_BlackJack_ProjectL_UI_TeamRoomInviteUIController.<>f__mg$cache2A;
		if (Lua_BlackJack_ProjectL_UI_TeamRoomInviteUIController.<>f__mg$cache2B == null)
		{
			Lua_BlackJack_ProjectL_UI_TeamRoomInviteUIController.<>f__mg$cache2B = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_TeamRoomInviteUIController.set_m_recentToggle);
		}
		LuaObject.addMember(l, name6, get6, Lua_BlackJack_ProjectL_UI_TeamRoomInviteUIController.<>f__mg$cache2B, true);
		string name7 = "m_guildToggle";
		if (Lua_BlackJack_ProjectL_UI_TeamRoomInviteUIController.<>f__mg$cache2C == null)
		{
			Lua_BlackJack_ProjectL_UI_TeamRoomInviteUIController.<>f__mg$cache2C = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_TeamRoomInviteUIController.get_m_guildToggle);
		}
		LuaCSFunction get7 = Lua_BlackJack_ProjectL_UI_TeamRoomInviteUIController.<>f__mg$cache2C;
		if (Lua_BlackJack_ProjectL_UI_TeamRoomInviteUIController.<>f__mg$cache2D == null)
		{
			Lua_BlackJack_ProjectL_UI_TeamRoomInviteUIController.<>f__mg$cache2D = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_TeamRoomInviteUIController.set_m_guildToggle);
		}
		LuaObject.addMember(l, name7, get7, Lua_BlackJack_ProjectL_UI_TeamRoomInviteUIController.<>f__mg$cache2D, true);
		string name8 = "m_guildToggleUnopenMask";
		if (Lua_BlackJack_ProjectL_UI_TeamRoomInviteUIController.<>f__mg$cache2E == null)
		{
			Lua_BlackJack_ProjectL_UI_TeamRoomInviteUIController.<>f__mg$cache2E = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_TeamRoomInviteUIController.get_m_guildToggleUnopenMask);
		}
		LuaCSFunction get8 = Lua_BlackJack_ProjectL_UI_TeamRoomInviteUIController.<>f__mg$cache2E;
		if (Lua_BlackJack_ProjectL_UI_TeamRoomInviteUIController.<>f__mg$cache2F == null)
		{
			Lua_BlackJack_ProjectL_UI_TeamRoomInviteUIController.<>f__mg$cache2F = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_TeamRoomInviteUIController.set_m_guildToggleUnopenMask);
		}
		LuaObject.addMember(l, name8, get8, Lua_BlackJack_ProjectL_UI_TeamRoomInviteUIController.<>f__mg$cache2F, true);
		string name9 = "m_confirmButton";
		if (Lua_BlackJack_ProjectL_UI_TeamRoomInviteUIController.<>f__mg$cache30 == null)
		{
			Lua_BlackJack_ProjectL_UI_TeamRoomInviteUIController.<>f__mg$cache30 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_TeamRoomInviteUIController.get_m_confirmButton);
		}
		LuaCSFunction get9 = Lua_BlackJack_ProjectL_UI_TeamRoomInviteUIController.<>f__mg$cache30;
		if (Lua_BlackJack_ProjectL_UI_TeamRoomInviteUIController.<>f__mg$cache31 == null)
		{
			Lua_BlackJack_ProjectL_UI_TeamRoomInviteUIController.<>f__mg$cache31 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_TeamRoomInviteUIController.set_m_confirmButton);
		}
		LuaObject.addMember(l, name9, get9, Lua_BlackJack_ProjectL_UI_TeamRoomInviteUIController.<>f__mg$cache31, true);
		string name10 = "m_cancelButton";
		if (Lua_BlackJack_ProjectL_UI_TeamRoomInviteUIController.<>f__mg$cache32 == null)
		{
			Lua_BlackJack_ProjectL_UI_TeamRoomInviteUIController.<>f__mg$cache32 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_TeamRoomInviteUIController.get_m_cancelButton);
		}
		LuaCSFunction get10 = Lua_BlackJack_ProjectL_UI_TeamRoomInviteUIController.<>f__mg$cache32;
		if (Lua_BlackJack_ProjectL_UI_TeamRoomInviteUIController.<>f__mg$cache33 == null)
		{
			Lua_BlackJack_ProjectL_UI_TeamRoomInviteUIController.<>f__mg$cache33 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_TeamRoomInviteUIController.set_m_cancelButton);
		}
		LuaObject.addMember(l, name10, get10, Lua_BlackJack_ProjectL_UI_TeamRoomInviteUIController.<>f__mg$cache33, true);
		string name11 = "m_inviteScrollRect";
		if (Lua_BlackJack_ProjectL_UI_TeamRoomInviteUIController.<>f__mg$cache34 == null)
		{
			Lua_BlackJack_ProjectL_UI_TeamRoomInviteUIController.<>f__mg$cache34 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_TeamRoomInviteUIController.get_m_inviteScrollRect);
		}
		LuaCSFunction get11 = Lua_BlackJack_ProjectL_UI_TeamRoomInviteUIController.<>f__mg$cache34;
		if (Lua_BlackJack_ProjectL_UI_TeamRoomInviteUIController.<>f__mg$cache35 == null)
		{
			Lua_BlackJack_ProjectL_UI_TeamRoomInviteUIController.<>f__mg$cache35 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_TeamRoomInviteUIController.set_m_inviteScrollRect);
		}
		LuaObject.addMember(l, name11, get11, Lua_BlackJack_ProjectL_UI_TeamRoomInviteUIController.<>f__mg$cache35, true);
		string name12 = "m_inviteCountTitleText";
		if (Lua_BlackJack_ProjectL_UI_TeamRoomInviteUIController.<>f__mg$cache36 == null)
		{
			Lua_BlackJack_ProjectL_UI_TeamRoomInviteUIController.<>f__mg$cache36 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_TeamRoomInviteUIController.get_m_inviteCountTitleText);
		}
		LuaCSFunction get12 = Lua_BlackJack_ProjectL_UI_TeamRoomInviteUIController.<>f__mg$cache36;
		if (Lua_BlackJack_ProjectL_UI_TeamRoomInviteUIController.<>f__mg$cache37 == null)
		{
			Lua_BlackJack_ProjectL_UI_TeamRoomInviteUIController.<>f__mg$cache37 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_TeamRoomInviteUIController.set_m_inviteCountTitleText);
		}
		LuaObject.addMember(l, name12, get12, Lua_BlackJack_ProjectL_UI_TeamRoomInviteUIController.<>f__mg$cache37, true);
		string name13 = "m_inviteCountValueText";
		if (Lua_BlackJack_ProjectL_UI_TeamRoomInviteUIController.<>f__mg$cache38 == null)
		{
			Lua_BlackJack_ProjectL_UI_TeamRoomInviteUIController.<>f__mg$cache38 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_TeamRoomInviteUIController.get_m_inviteCountValueText);
		}
		LuaCSFunction get13 = Lua_BlackJack_ProjectL_UI_TeamRoomInviteUIController.<>f__mg$cache38;
		if (Lua_BlackJack_ProjectL_UI_TeamRoomInviteUIController.<>f__mg$cache39 == null)
		{
			Lua_BlackJack_ProjectL_UI_TeamRoomInviteUIController.<>f__mg$cache39 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_TeamRoomInviteUIController.set_m_inviteCountValueText);
		}
		LuaObject.addMember(l, name13, get13, Lua_BlackJack_ProjectL_UI_TeamRoomInviteUIController.<>f__mg$cache39, true);
		string name14 = "m_prefabsGameObject";
		if (Lua_BlackJack_ProjectL_UI_TeamRoomInviteUIController.<>f__mg$cache3A == null)
		{
			Lua_BlackJack_ProjectL_UI_TeamRoomInviteUIController.<>f__mg$cache3A = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_TeamRoomInviteUIController.get_m_prefabsGameObject);
		}
		LuaCSFunction get14 = Lua_BlackJack_ProjectL_UI_TeamRoomInviteUIController.<>f__mg$cache3A;
		if (Lua_BlackJack_ProjectL_UI_TeamRoomInviteUIController.<>f__mg$cache3B == null)
		{
			Lua_BlackJack_ProjectL_UI_TeamRoomInviteUIController.<>f__mg$cache3B = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_TeamRoomInviteUIController.set_m_prefabsGameObject);
		}
		LuaObject.addMember(l, name14, get14, Lua_BlackJack_ProjectL_UI_TeamRoomInviteUIController.<>f__mg$cache3B, true);
		string name15 = "m_invitePlayerListItemPrefab";
		if (Lua_BlackJack_ProjectL_UI_TeamRoomInviteUIController.<>f__mg$cache3C == null)
		{
			Lua_BlackJack_ProjectL_UI_TeamRoomInviteUIController.<>f__mg$cache3C = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_TeamRoomInviteUIController.get_m_invitePlayerListItemPrefab);
		}
		LuaCSFunction get15 = Lua_BlackJack_ProjectL_UI_TeamRoomInviteUIController.<>f__mg$cache3C;
		if (Lua_BlackJack_ProjectL_UI_TeamRoomInviteUIController.<>f__mg$cache3D == null)
		{
			Lua_BlackJack_ProjectL_UI_TeamRoomInviteUIController.<>f__mg$cache3D = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_TeamRoomInviteUIController.set_m_invitePlayerListItemPrefab);
		}
		LuaObject.addMember(l, name15, get15, Lua_BlackJack_ProjectL_UI_TeamRoomInviteUIController.<>f__mg$cache3D, true);
		string name16 = "m_playerListItems";
		if (Lua_BlackJack_ProjectL_UI_TeamRoomInviteUIController.<>f__mg$cache3E == null)
		{
			Lua_BlackJack_ProjectL_UI_TeamRoomInviteUIController.<>f__mg$cache3E = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_TeamRoomInviteUIController.get_m_playerListItems);
		}
		LuaCSFunction get16 = Lua_BlackJack_ProjectL_UI_TeamRoomInviteUIController.<>f__mg$cache3E;
		if (Lua_BlackJack_ProjectL_UI_TeamRoomInviteUIController.<>f__mg$cache3F == null)
		{
			Lua_BlackJack_ProjectL_UI_TeamRoomInviteUIController.<>f__mg$cache3F = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_TeamRoomInviteUIController.set_m_playerListItems);
		}
		LuaObject.addMember(l, name16, get16, Lua_BlackJack_ProjectL_UI_TeamRoomInviteUIController.<>f__mg$cache3F, true);
		string name17 = "m_isIgnoreToggleEvent";
		if (Lua_BlackJack_ProjectL_UI_TeamRoomInviteUIController.<>f__mg$cache40 == null)
		{
			Lua_BlackJack_ProjectL_UI_TeamRoomInviteUIController.<>f__mg$cache40 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_TeamRoomInviteUIController.get_m_isIgnoreToggleEvent);
		}
		LuaCSFunction get17 = Lua_BlackJack_ProjectL_UI_TeamRoomInviteUIController.<>f__mg$cache40;
		if (Lua_BlackJack_ProjectL_UI_TeamRoomInviteUIController.<>f__mg$cache41 == null)
		{
			Lua_BlackJack_ProjectL_UI_TeamRoomInviteUIController.<>f__mg$cache41 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_TeamRoomInviteUIController.set_m_isIgnoreToggleEvent);
		}
		LuaObject.addMember(l, name17, get17, Lua_BlackJack_ProjectL_UI_TeamRoomInviteUIController.<>f__mg$cache41, true);
		LuaObject.createTypeMetatable(l, null, typeof(TeamRoomInviteUIController), typeof(UIControllerBase));
	}

	// Token: 0x04017684 RID: 95876
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache0;

	// Token: 0x04017685 RID: 95877
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1;

	// Token: 0x04017686 RID: 95878
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2;

	// Token: 0x04017687 RID: 95879
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3;

	// Token: 0x04017688 RID: 95880
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache4;

	// Token: 0x04017689 RID: 95881
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache5;

	// Token: 0x0401768A RID: 95882
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache6;

	// Token: 0x0401768B RID: 95883
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache7;

	// Token: 0x0401768C RID: 95884
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache8;

	// Token: 0x0401768D RID: 95885
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache9;

	// Token: 0x0401768E RID: 95886
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheA;

	// Token: 0x0401768F RID: 95887
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheB;

	// Token: 0x04017690 RID: 95888
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheC;

	// Token: 0x04017691 RID: 95889
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheD;

	// Token: 0x04017692 RID: 95890
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheE;

	// Token: 0x04017693 RID: 95891
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheF;

	// Token: 0x04017694 RID: 95892
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache10;

	// Token: 0x04017695 RID: 95893
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache11;

	// Token: 0x04017696 RID: 95894
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache12;

	// Token: 0x04017697 RID: 95895
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache13;

	// Token: 0x04017698 RID: 95896
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache14;

	// Token: 0x04017699 RID: 95897
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache15;

	// Token: 0x0401769A RID: 95898
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache16;

	// Token: 0x0401769B RID: 95899
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache17;

	// Token: 0x0401769C RID: 95900
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache18;

	// Token: 0x0401769D RID: 95901
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache19;

	// Token: 0x0401769E RID: 95902
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1A;

	// Token: 0x0401769F RID: 95903
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1B;

	// Token: 0x040176A0 RID: 95904
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1C;

	// Token: 0x040176A1 RID: 95905
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1D;

	// Token: 0x040176A2 RID: 95906
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1E;

	// Token: 0x040176A3 RID: 95907
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1F;

	// Token: 0x040176A4 RID: 95908
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache20;

	// Token: 0x040176A5 RID: 95909
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache21;

	// Token: 0x040176A6 RID: 95910
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache22;

	// Token: 0x040176A7 RID: 95911
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache23;

	// Token: 0x040176A8 RID: 95912
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache24;

	// Token: 0x040176A9 RID: 95913
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache25;

	// Token: 0x040176AA RID: 95914
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache26;

	// Token: 0x040176AB RID: 95915
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache27;

	// Token: 0x040176AC RID: 95916
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache28;

	// Token: 0x040176AD RID: 95917
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache29;

	// Token: 0x040176AE RID: 95918
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2A;

	// Token: 0x040176AF RID: 95919
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2B;

	// Token: 0x040176B0 RID: 95920
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2C;

	// Token: 0x040176B1 RID: 95921
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2D;

	// Token: 0x040176B2 RID: 95922
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2E;

	// Token: 0x040176B3 RID: 95923
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2F;

	// Token: 0x040176B4 RID: 95924
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache30;

	// Token: 0x040176B5 RID: 95925
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache31;

	// Token: 0x040176B6 RID: 95926
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache32;

	// Token: 0x040176B7 RID: 95927
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache33;

	// Token: 0x040176B8 RID: 95928
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache34;

	// Token: 0x040176B9 RID: 95929
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache35;

	// Token: 0x040176BA RID: 95930
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache36;

	// Token: 0x040176BB RID: 95931
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache37;

	// Token: 0x040176BC RID: 95932
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache38;

	// Token: 0x040176BD RID: 95933
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache39;

	// Token: 0x040176BE RID: 95934
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3A;

	// Token: 0x040176BF RID: 95935
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3B;

	// Token: 0x040176C0 RID: 95936
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3C;

	// Token: 0x040176C1 RID: 95937
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3D;

	// Token: 0x040176C2 RID: 95938
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3E;

	// Token: 0x040176C3 RID: 95939
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3F;

	// Token: 0x040176C4 RID: 95940
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache40;

	// Token: 0x040176C5 RID: 95941
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache41;
}
