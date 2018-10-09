using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using BlackJack.BJFramework.Runtime.UI;
using BlackJack.ConfigData;
using BlackJack.ProjectL.Common;
using BlackJack.ProjectL.PlayerContext;
using BlackJack.ProjectL.Protocol;
using BlackJack.ProjectL.UI;
using BlackJack.ProjectLBasic;
using SLua;
using UnityEngine;
using UnityEngine.Scripting;

// Token: 0x02001459 RID: 5209
[Preserve]
public class Lua_BlackJack_ProjectL_UI_FriendUITask : LuaObject
{
	// Token: 0x0601E0E0 RID: 123104 RVA: 0x0099FA80 File Offset: 0x0099DC80
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int constructor(IntPtr l)
	{
		int result;
		try
		{
			string name;
			LuaObject.checkType(l, 2, out name);
			FriendUITask o = new FriendUITask(name);
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

	// Token: 0x0601E0E1 RID: 123105 RVA: 0x0099FAD4 File Offset: 0x0099DCD4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int InitAllUIControllers(IntPtr l)
	{
		int result;
		try
		{
			FriendUITask friendUITask = (FriendUITask)LuaObject.checkSelf(l);
			friendUITask.m_luaExportHelper.InitAllUIControllers();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601E0E2 RID: 123106 RVA: 0x0099FB28 File Offset: 0x0099DD28
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int ClearAllContextAndRes(IntPtr l)
	{
		int result;
		try
		{
			FriendUITask friendUITask = (FriendUITask)LuaObject.checkSelf(l);
			friendUITask.m_luaExportHelper.ClearAllContextAndRes();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601E0E3 RID: 123107 RVA: 0x0099FB7C File Offset: 0x0099DD7C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int RegisterPlayerContextEvents(IntPtr l)
	{
		int result;
		try
		{
			FriendUITask friendUITask = (FriendUITask)LuaObject.checkSelf(l);
			friendUITask.m_luaExportHelper.RegisterPlayerContextEvents();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601E0E4 RID: 123108 RVA: 0x0099FBD0 File Offset: 0x0099DDD0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int UnregisterPlayerContextEvents(IntPtr l)
	{
		int result;
		try
		{
			FriendUITask friendUITask = (FriendUITask)LuaObject.checkSelf(l);
			friendUITask.m_luaExportHelper.UnregisterPlayerContextEvents();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601E0E5 RID: 123109 RVA: 0x0099FC24 File Offset: 0x0099DE24
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int UpdateView(IntPtr l)
	{
		int result;
		try
		{
			FriendUITask friendUITask = (FriendUITask)LuaObject.checkSelf(l);
			friendUITask.m_luaExportHelper.UpdateView();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601E0E6 RID: 123110 RVA: 0x0099FC78 File Offset: 0x0099DE78
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int UpdatePanel(IntPtr l)
	{
		int result;
		try
		{
			FriendUITask friendUITask = (FriendUITask)LuaObject.checkSelf(l);
			friendUITask.m_luaExportHelper.UpdatePanel();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601E0E7 RID: 123111 RVA: 0x0099FCCC File Offset: 0x0099DECC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int FriendUIController_OnShowPanel(IntPtr l)
	{
		int result;
		try
		{
			FriendUITask friendUITask = (FriendUITask)LuaObject.checkSelf(l);
			FriendPanelType panelType;
			LuaObject.checkEnum<FriendPanelType>(l, 2, out panelType);
			friendUITask.m_luaExportHelper.FriendUIController_OnShowPanel(panelType);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601E0E8 RID: 123112 RVA: 0x0099FD28 File Offset: 0x0099DF28
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int FriendUIController_OnReturn(IntPtr l)
	{
		int result;
		try
		{
			FriendUITask friendUITask = (FriendUITask)LuaObject.checkSelf(l);
			friendUITask.m_luaExportHelper.FriendUIController_OnReturn();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601E0E9 RID: 123113 RVA: 0x0099FD7C File Offset: 0x0099DF7C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int FriendUIController_OnShowHelp(IntPtr l)
	{
		int result;
		try
		{
			FriendUITask friendUITask = (FriendUITask)LuaObject.checkSelf(l);
			friendUITask.m_luaExportHelper.FriendUIController_OnShowHelp();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601E0EA RID: 123114 RVA: 0x0099FDD0 File Offset: 0x0099DFD0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int FriendUIController_OnGetSocialRelation(IntPtr l)
	{
		int result;
		try
		{
			FriendUITask friendUITask = (FriendUITask)LuaObject.checkSelf(l);
			FriendSocialRelationFlag friendSocialRelationFlag;
			LuaObject.checkEnum<FriendSocialRelationFlag>(l, 2, out friendSocialRelationFlag);
			friendUITask.m_luaExportHelper.FriendUIController_OnGetSocialRelation(friendSocialRelationFlag);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601E0EB RID: 123115 RVA: 0x0099FE2C File Offset: 0x0099E02C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int FriendUIController_OnShowPlayerInfo(IntPtr l)
	{
		int result;
		try
		{
			FriendUITask friendUITask = (FriendUITask)LuaObject.checkSelf(l);
			UserSummary userSummy;
			LuaObject.checkType<UserSummary>(l, 2, out userSummy);
			Vector3 pos;
			LuaObject.checkType(l, 3, out pos);
			PlayerSimpleInfoUITask.PostionType posType;
			LuaObject.checkEnum<PlayerSimpleInfoUITask.PostionType>(l, 4, out posType);
			friendUITask.m_luaExportHelper.FriendUIController_OnShowPlayerInfo(userSummy, pos, posType);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601E0EC RID: 123116 RVA: 0x0099FEA4 File Offset: 0x0099E0A4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int OnShowPlayerSimpleInfo(IntPtr l)
	{
		int result;
		try
		{
			FriendUITask friendUITask = (FriendUITask)LuaObject.checkSelf(l);
			Vector3 pos;
			LuaObject.checkType(l, 2, out pos);
			PlayerSimpleInfoUITask.PostionType posType;
			LuaObject.checkEnum<PlayerSimpleInfoUITask.PostionType>(l, 3, out posType);
			friendUITask.m_luaExportHelper.OnShowPlayerSimpleInfo(pos, posType);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601E0ED RID: 123117 RVA: 0x0099FF10 File Offset: 0x0099E110
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int PlayerSimpleInfoUITask_GetSocialRelation(IntPtr l)
	{
		int result;
		try
		{
			FriendUITask friendUITask = (FriendUITask)LuaObject.checkSelf(l);
			friendUITask.m_luaExportHelper.PlayerSimpleInfoUITask_GetSocialRelation();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601E0EE RID: 123118 RVA: 0x0099FF64 File Offset: 0x0099E164
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int PlayerSimpleInfoUITask_OnClose(IntPtr l)
	{
		int result;
		try
		{
			FriendUITask friendUITask = (FriendUITask)LuaObject.checkSelf(l);
			friendUITask.m_luaExportHelper.PlayerSimpleInfoUITask_OnClose();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601E0EF RID: 123119 RVA: 0x0099FFB8 File Offset: 0x0099E1B8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int PlayerSimpleInfoUITask_OnPrivateChatButtonClick(IntPtr l)
	{
		int result;
		try
		{
			FriendUITask friendUITask = (FriendUITask)LuaObject.checkSelf(l);
			BusinessCard playerInfo;
			LuaObject.checkType<BusinessCard>(l, 2, out playerInfo);
			friendUITask.m_luaExportHelper.PlayerSimpleInfoUITask_OnPrivateChatButtonClick(playerInfo);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601E0F0 RID: 123120 RVA: 0x009A0014 File Offset: 0x0099E214
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int FriendUIController_OnAddFriend(IntPtr l)
	{
		int result;
		try
		{
			FriendUITask friendUITask = (FriendUITask)LuaObject.checkSelf(l);
			List<string> userIDList;
			LuaObject.checkType<List<string>>(l, 2, out userIDList);
			friendUITask.m_luaExportHelper.FriendUIController_OnAddFriend(userIDList);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601E0F1 RID: 123121 RVA: 0x009A0070 File Offset: 0x0099E270
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int FriendUIController_OnFriendInviteAceept(IntPtr l)
	{
		int result;
		try
		{
			FriendUITask friendUITask = (FriendUITask)LuaObject.checkSelf(l);
			List<string> userIDList;
			LuaObject.checkType<List<string>>(l, 2, out userIDList);
			friendUITask.m_luaExportHelper.FriendUIController_OnFriendInviteAceept(userIDList);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601E0F2 RID: 123122 RVA: 0x009A00CC File Offset: 0x0099E2CC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int FriendUIController_OnFriendInviteDecline(IntPtr l)
	{
		int result;
		try
		{
			FriendUITask friendUITask = (FriendUITask)LuaObject.checkSelf(l);
			List<string> userIDList;
			LuaObject.checkType<List<string>>(l, 2, out userIDList);
			friendUITask.m_luaExportHelper.FriendUIController_OnFriendInviteDecline(userIDList);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601E0F3 RID: 123123 RVA: 0x009A0128 File Offset: 0x0099E328
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int FriendUIController_OnUnblockPlayer(IntPtr l)
	{
		int result;
		try
		{
			FriendUITask friendUITask = (FriendUITask)LuaObject.checkSelf(l);
			string userID;
			LuaObject.checkType(l, 2, out userID);
			friendUITask.m_luaExportHelper.FriendUIController_OnUnblockPlayer(userID);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601E0F4 RID: 123124 RVA: 0x009A0184 File Offset: 0x0099E384
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int UnblockPlayerCallback(IntPtr l)
	{
		int result;
		try
		{
			FriendUITask friendUITask = (FriendUITask)LuaObject.checkSelf(l);
			DialogBoxResult r;
			LuaObject.checkEnum<DialogBoxResult>(l, 2, out r);
			friendUITask.m_luaExportHelper.UnblockPlayerCallback(r);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601E0F5 RID: 123125 RVA: 0x009A01E0 File Offset: 0x0099E3E0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int FriendUIController_OnFindFriend(IntPtr l)
	{
		int result;
		try
		{
			FriendUITask friendUITask = (FriendUITask)LuaObject.checkSelf(l);
			int bornChannelID;
			LuaObject.checkType(l, 2, out bornChannelID);
			string partialName;
			LuaObject.checkType(l, 3, out partialName);
			friendUITask.m_luaExportHelper.FriendUIController_OnFindFriend(bornChannelID, partialName);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601E0F6 RID: 123126 RVA: 0x009A024C File Offset: 0x0099E44C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int SetCurrentFindFriendList(IntPtr l)
	{
		int result;
		try
		{
			FriendUITask friendUITask = (FriendUITask)LuaObject.checkSelf(l);
			friendUITask.m_luaExportHelper.SetCurrentFindFriendList();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601E0F7 RID: 123127 RVA: 0x009A02A0 File Offset: 0x0099E4A0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int FriendUIController_OnGetRecommendFriendList(IntPtr l)
	{
		int result;
		try
		{
			FriendUITask friendUITask = (FriendUITask)LuaObject.checkSelf(l);
			friendUITask.m_luaExportHelper.FriendUIController_OnGetRecommendFriendList();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601E0F8 RID: 123128 RVA: 0x009A02F4 File Offset: 0x0099E4F4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int SetCurrentRecommedFriendList(IntPtr l)
	{
		int result;
		try
		{
			FriendUITask friendUITask = (FriendUITask)LuaObject.checkSelf(l);
			friendUITask.m_luaExportHelper.SetCurrentRecommedFriendList();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601E0F9 RID: 123129 RVA: 0x009A0348 File Offset: 0x0099E548
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int FriendUIController_OnGetAllGroup(IntPtr l)
	{
		int result;
		try
		{
			FriendUITask friendUITask = (FriendUITask)LuaObject.checkSelf(l);
			friendUITask.m_luaExportHelper.FriendUIController_OnGetAllGroup();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601E0FA RID: 123130 RVA: 0x009A039C File Offset: 0x0099E59C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int FriendUIController_OnGroupChat(IntPtr l)
	{
		int result;
		try
		{
			FriendUITask friendUITask = (FriendUITask)LuaObject.checkSelf(l);
			string groupID;
			LuaObject.checkType(l, 2, out groupID);
			friendUITask.m_luaExportHelper.FriendUIController_OnGroupChat(groupID);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601E0FB RID: 123131 RVA: 0x009A03F8 File Offset: 0x0099E5F8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int FriendUIController_OnWatchGroupStaff(IntPtr l)
	{
		int result;
		try
		{
			FriendUITask friendUITask = (FriendUITask)LuaObject.checkSelf(l);
			string groupID;
			LuaObject.checkType(l, 2, out groupID);
			bool needOpenTween;
			LuaObject.checkType(l, 3, out needOpenTween);
			friendUITask.m_luaExportHelper.FriendUIController_OnWatchGroupStaff(groupID, needOpenTween);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601E0FC RID: 123132 RVA: 0x009A0464 File Offset: 0x0099E664
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int FriendUIController_OnCreateNewGroup(IntPtr l)
	{
		int result;
		try
		{
			FriendUITask friendUITask = (FriendUITask)LuaObject.checkSelf(l);
			List<string> userIDList;
			LuaObject.checkType<List<string>>(l, 2, out userIDList);
			friendUITask.m_luaExportHelper.FriendUIController_OnCreateNewGroup(userIDList);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601E0FD RID: 123133 RVA: 0x009A04C0 File Offset: 0x0099E6C0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int FriendUIController_OnInviteFriendToGroup(IntPtr l)
	{
		int result;
		try
		{
			FriendUITask friendUITask = (FriendUITask)LuaObject.checkSelf(l);
			string groupID;
			LuaObject.checkType(l, 2, out groupID);
			List<string> userIDList;
			LuaObject.checkType<List<string>>(l, 3, out userIDList);
			friendUITask.m_luaExportHelper.FriendUIController_OnInviteFriendToGroup(groupID, userIDList);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601E0FE RID: 123134 RVA: 0x009A052C File Offset: 0x0099E72C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int FriendUIController_OnChangeGroupName(IntPtr l)
	{
		int result;
		try
		{
			FriendUITask friendUITask = (FriendUITask)LuaObject.checkSelf(l);
			string groupID;
			LuaObject.checkType(l, 2, out groupID);
			string newName;
			LuaObject.checkType(l, 3, out newName);
			friendUITask.m_luaExportHelper.FriendUIController_OnChangeGroupName(groupID, newName);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601E0FF RID: 123135 RVA: 0x009A0598 File Offset: 0x0099E798
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int FriendUIController_OnLeaveGroup(IntPtr l)
	{
		int result;
		try
		{
			FriendUITask friendUITask = (FriendUITask)LuaObject.checkSelf(l);
			ProChatGroupInfo chatGroupInfo;
			LuaObject.checkType<ProChatGroupInfo>(l, 2, out chatGroupInfo);
			friendUITask.m_luaExportHelper.FriendUIController_OnLeaveGroup(chatGroupInfo);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601E100 RID: 123136 RVA: 0x009A05F4 File Offset: 0x0099E7F4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int OnLeaveGroupDialogBoxCallback(IntPtr l)
	{
		int result;
		try
		{
			FriendUITask friendUITask = (FriendUITask)LuaObject.checkSelf(l);
			DialogBoxResult r;
			LuaObject.checkEnum<DialogBoxResult>(l, 2, out r);
			friendUITask.m_luaExportHelper.OnLeaveGroupDialogBoxCallback(r);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601E101 RID: 123137 RVA: 0x009A0650 File Offset: 0x0099E850
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int FriendUIController_OnKickGroup(IntPtr l)
	{
		int result;
		try
		{
			FriendUITask friendUITask = (FriendUITask)LuaObject.checkSelf(l);
			ProChatGroupInfo chatGroupInfo;
			LuaObject.checkType<ProChatGroupInfo>(l, 2, out chatGroupInfo);
			UserSummary userSummy;
			LuaObject.checkType<UserSummary>(l, 3, out userSummy);
			friendUITask.m_luaExportHelper.FriendUIController_OnKickGroup(chatGroupInfo, userSummy);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601E102 RID: 123138 RVA: 0x009A06BC File Offset: 0x0099E8BC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int OnKickFromGroupDialogBoxCallback(IntPtr l)
	{
		int result;
		try
		{
			FriendUITask friendUITask = (FriendUITask)LuaObject.checkSelf(l);
			DialogBoxResult r;
			LuaObject.checkEnum<DialogBoxResult>(l, 2, out r);
			friendUITask.m_luaExportHelper.OnKickFromGroupDialogBoxCallback(r);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601E103 RID: 123139 RVA: 0x009A0718 File Offset: 0x0099E918
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int FriendUIController_OnChat(IntPtr l)
	{
		int result;
		try
		{
			FriendUITask friendUITask = (FriendUITask)LuaObject.checkSelf(l);
			UserSummary userSummy;
			LuaObject.checkType<UserSummary>(l, 2, out userSummy);
			friendUITask.m_luaExportHelper.FriendUIController_OnChat(userSummy);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601E104 RID: 123140 RVA: 0x009A0774 File Offset: 0x0099E974
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int FriendUIController_OnSendFriendshipPoint(IntPtr l)
	{
		int result;
		try
		{
			FriendUITask friendUITask = (FriendUITask)LuaObject.checkSelf(l);
			string userID;
			LuaObject.checkType(l, 2, out userID);
			friendUITask.m_luaExportHelper.FriendUIController_OnSendFriendshipPoint(userID);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601E105 RID: 123141 RVA: 0x009A07D0 File Offset: 0x0099E9D0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int FriendUIController_OnGetFriendshipPoint(IntPtr l)
	{
		int result;
		try
		{
			FriendUITask friendUITask = (FriendUITask)LuaObject.checkSelf(l);
			string userID;
			LuaObject.checkType(l, 2, out userID);
			friendUITask.m_luaExportHelper.FriendUIController_OnGetFriendshipPoint(userID);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601E106 RID: 123142 RVA: 0x009A082C File Offset: 0x0099EA2C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int FriendUIController_OnSendAllFriendshipPoint(IntPtr l)
	{
		int result;
		try
		{
			FriendUITask friendUITask = (FriendUITask)LuaObject.checkSelf(l);
			friendUITask.m_luaExportHelper.FriendUIController_OnSendAllFriendshipPoint();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601E107 RID: 123143 RVA: 0x009A0880 File Offset: 0x0099EA80
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int FriendUIController_OnGetAllFriendshipPoint(IntPtr l)
	{
		int result;
		try
		{
			FriendUITask friendUITask = (FriendUITask)LuaObject.checkSelf(l);
			friendUITask.m_luaExportHelper.FriendUIController_OnGetAllFriendshipPoint();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601E108 RID: 123144 RVA: 0x009A08D4 File Offset: 0x0099EAD4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int PlayerContext_OnChatGroupUpdateNtf(IntPtr l)
	{
		int result;
		try
		{
			FriendUITask friendUITask = (FriendUITask)LuaObject.checkSelf(l);
			ProChatGroupInfo chatGroupInfo;
			LuaObject.checkType<ProChatGroupInfo>(l, 2, out chatGroupInfo);
			friendUITask.m_luaExportHelper.PlayerContext_OnChatGroupUpdateNtf(chatGroupInfo);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601E109 RID: 123145 RVA: 0x009A0930 File Offset: 0x0099EB30
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int isMeInTheGroup(IntPtr l)
	{
		int result;
		try
		{
			FriendUITask friendUITask = (FriendUITask)LuaObject.checkSelf(l);
			ProChatGroupInfo chatGroupInfo;
			LuaObject.checkType<ProChatGroupInfo>(l, 2, out chatGroupInfo);
			bool b = friendUITask.m_luaExportHelper.isMeInTheGroup(chatGroupInfo);
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

	// Token: 0x0601E10A RID: 123146 RVA: 0x009A0998 File Offset: 0x0099EB98
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int ShowErrorMessage(IntPtr l)
	{
		int result;
		try
		{
			FriendUITask friendUITask = (FriendUITask)LuaObject.checkSelf(l);
			int errorCode;
			LuaObject.checkType(l, 2, out errorCode);
			friendUITask.m_luaExportHelper.ShowErrorMessage(errorCode);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601E10B RID: 123147 RVA: 0x009A09F4 File Offset: 0x0099EBF4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int ShowMessage(IntPtr l)
	{
		int result;
		try
		{
			FriendUITask friendUITask = (FriendUITask)LuaObject.checkSelf(l);
			string text;
			LuaObject.checkType(l, 2, out text);
			friendUITask.m_luaExportHelper.ShowMessage(text);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601E10C RID: 123148 RVA: 0x009A0A50 File Offset: 0x0099EC50
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_OnStart(IntPtr l)
	{
		int result;
		try
		{
			FriendUITask friendUITask = (FriendUITask)LuaObject.checkSelf(l);
			UIIntent intent;
			LuaObject.checkType<UIIntent>(l, 2, out intent);
			bool b = friendUITask.m_luaExportHelper.__callBase_OnStart(intent);
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

	// Token: 0x0601E10D RID: 123149 RVA: 0x009A0AB8 File Offset: 0x0099ECB8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_OnStop(IntPtr l)
	{
		int result;
		try
		{
			FriendUITask friendUITask = (FriendUITask)LuaObject.checkSelf(l);
			friendUITask.m_luaExportHelper.__callBase_OnStop();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601E10E RID: 123150 RVA: 0x009A0B0C File Offset: 0x0099ED0C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_OnPause(IntPtr l)
	{
		int result;
		try
		{
			FriendUITask friendUITask = (FriendUITask)LuaObject.checkSelf(l);
			friendUITask.m_luaExportHelper.__callBase_OnPause();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601E10F RID: 123151 RVA: 0x009A0B60 File Offset: 0x0099ED60
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_OnResume(IntPtr l)
	{
		int result;
		try
		{
			FriendUITask friendUITask = (FriendUITask)LuaObject.checkSelf(l);
			UIIntent intent;
			LuaObject.checkType<UIIntent>(l, 2, out intent);
			bool b = friendUITask.m_luaExportHelper.__callBase_OnResume(intent);
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

	// Token: 0x0601E110 RID: 123152 RVA: 0x009A0BC8 File Offset: 0x0099EDC8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_OnNewIntent(IntPtr l)
	{
		int result;
		try
		{
			FriendUITask friendUITask = (FriendUITask)LuaObject.checkSelf(l);
			UIIntent intent;
			LuaObject.checkType<UIIntent>(l, 2, out intent);
			bool b = friendUITask.m_luaExportHelper.__callBase_OnNewIntent(intent);
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

	// Token: 0x0601E111 RID: 123153 RVA: 0x009A0C30 File Offset: 0x0099EE30
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_EnableUIInput(IntPtr l)
	{
		int result;
		try
		{
			FriendUITask friendUITask = (FriendUITask)LuaObject.checkSelf(l);
			bool isEnable;
			LuaObject.checkType(l, 2, out isEnable);
			bool? isGlobalEnable;
			LuaObject.checkNullable<bool>(l, 3, out isGlobalEnable);
			friendUITask.m_luaExportHelper.__callBase_EnableUIInput(isEnable, isGlobalEnable);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601E112 RID: 123154 RVA: 0x009A0C9C File Offset: 0x0099EE9C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_IsNeedLoadDynamicRes(IntPtr l)
	{
		int result;
		try
		{
			FriendUITask friendUITask = (FriendUITask)LuaObject.checkSelf(l);
			bool b = friendUITask.m_luaExportHelper.__callBase_IsNeedLoadDynamicRes();
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

	// Token: 0x0601E113 RID: 123155 RVA: 0x009A0CF8 File Offset: 0x0099EEF8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_CollectAllDynamicResForLoad(IntPtr l)
	{
		int result;
		try
		{
			FriendUITask friendUITask = (FriendUITask)LuaObject.checkSelf(l);
			List<string> o = friendUITask.m_luaExportHelper.__callBase_CollectAllDynamicResForLoad();
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

	// Token: 0x0601E114 RID: 123156 RVA: 0x009A0D54 File Offset: 0x0099EF54
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_RegisterPlayerContextEvents(IntPtr l)
	{
		int result;
		try
		{
			FriendUITask friendUITask = (FriendUITask)LuaObject.checkSelf(l);
			friendUITask.m_luaExportHelper.__callBase_RegisterPlayerContextEvents();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601E115 RID: 123157 RVA: 0x009A0DA8 File Offset: 0x0099EFA8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_UnregisterPlayerContextEvents(IntPtr l)
	{
		int result;
		try
		{
			FriendUITask friendUITask = (FriendUITask)LuaObject.checkSelf(l);
			friendUITask.m_luaExportHelper.__callBase_UnregisterPlayerContextEvents();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601E116 RID: 123158 RVA: 0x009A0DFC File Offset: 0x0099EFFC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_PostUpdateView(IntPtr l)
	{
		int result;
		try
		{
			FriendUITask friendUITask = (FriendUITask)LuaObject.checkSelf(l);
			friendUITask.m_luaExportHelper.__callBase_PostUpdateView();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601E117 RID: 123159 RVA: 0x009A0E50 File Offset: 0x0099F050
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_CollectPreloadResourceList(IntPtr l)
	{
		int result;
		try
		{
			FriendUITask friendUITask = (FriendUITask)LuaObject.checkSelf(l);
			friendUITask.m_luaExportHelper.__callBase_CollectPreloadResourceList();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601E118 RID: 123160 RVA: 0x009A0EA4 File Offset: 0x0099F0A4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_ClearAssetList(IntPtr l)
	{
		int result;
		try
		{
			FriendUITask friendUITask = (FriendUITask)LuaObject.checkSelf(l);
			friendUITask.m_luaExportHelper.__callBase_ClearAssetList();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601E119 RID: 123161 RVA: 0x009A0EF8 File Offset: 0x0099F0F8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_CollectAsset(IntPtr l)
	{
		int result;
		try
		{
			FriendUITask friendUITask = (FriendUITask)LuaObject.checkSelf(l);
			string assetName;
			LuaObject.checkType(l, 2, out assetName);
			friendUITask.m_luaExportHelper.__callBase_CollectAsset(assetName);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601E11A RID: 123162 RVA: 0x009A0F54 File Offset: 0x0099F154
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_CollectSpriteAsset(IntPtr l)
	{
		int result;
		try
		{
			FriendUITask friendUITask = (FriendUITask)LuaObject.checkSelf(l);
			string assetName;
			LuaObject.checkType(l, 2, out assetName);
			friendUITask.m_luaExportHelper.__callBase_CollectSpriteAsset(assetName);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601E11B RID: 123163 RVA: 0x009A0FB0 File Offset: 0x0099F1B0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_CollectFxAsset(IntPtr l)
	{
		int result;
		try
		{
			FriendUITask friendUITask = (FriendUITask)LuaObject.checkSelf(l);
			string assetName;
			LuaObject.checkType(l, 2, out assetName);
			friendUITask.m_luaExportHelper.__callBase_CollectFxAsset(assetName);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601E11C RID: 123164 RVA: 0x009A100C File Offset: 0x0099F20C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_StartLoadCustomAssets(IntPtr l)
	{
		int result;
		try
		{
			FriendUITask friendUITask = (FriendUITask)LuaObject.checkSelf(l);
			Action onLoadCompleted;
			LuaObject.checkDelegate<Action>(l, 2, out onLoadCompleted);
			friendUITask.m_luaExportHelper.__callBase_StartLoadCustomAssets(onLoadCompleted);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601E11D RID: 123165 RVA: 0x009A1068 File Offset: 0x0099F268
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_IsLoadingCustomAssets(IntPtr l)
	{
		int result;
		try
		{
			FriendUITask friendUITask = (FriendUITask)LuaObject.checkSelf(l);
			bool b = friendUITask.m_luaExportHelper.__callBase_IsLoadingCustomAssets();
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

	// Token: 0x0601E11E RID: 123166 RVA: 0x009A10C4 File Offset: 0x0099F2C4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_IsPipeLineRunning(IntPtr l)
	{
		int result;
		try
		{
			FriendUITask friendUITask = (FriendUITask)LuaObject.checkSelf(l);
			bool b = friendUITask.m_luaExportHelper.__callBase_IsPipeLineRunning();
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

	// Token: 0x0601E11F RID: 123167 RVA: 0x009A1120 File Offset: 0x0099F320
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_IsOpeningUI(IntPtr l)
	{
		int result;
		try
		{
			FriendUITask friendUITask = (FriendUITask)LuaObject.checkSelf(l);
			bool b = friendUITask.m_luaExportHelper.__callBase_IsOpeningUI();
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

	// Token: 0x0601E120 RID: 123168 RVA: 0x009A117C File Offset: 0x0099F37C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_ReturnPrevUITask(IntPtr l)
	{
		int result;
		try
		{
			FriendUITask friendUITask = (FriendUITask)LuaObject.checkSelf(l);
			UITaskBase o = friendUITask.m_luaExportHelper.__callBase_ReturnPrevUITask();
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

	// Token: 0x0601E121 RID: 123169 RVA: 0x009A11D8 File Offset: 0x0099F3D8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_ClearUnusedDynamicResourceCache(IntPtr l)
	{
		int result;
		try
		{
			FriendUITask friendUITask = (FriendUITask)LuaObject.checkSelf(l);
			friendUITask.m_luaExportHelper.__callBase_ClearUnusedDynamicResourceCache();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601E122 RID: 123170 RVA: 0x009A122C File Offset: 0x0099F42C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_OnMemoryWarning(IntPtr l)
	{
		int result;
		try
		{
			FriendUITask friendUITask = (FriendUITask)LuaObject.checkSelf(l);
			friendUITask.m_luaExportHelper.__callBase_OnMemoryWarning();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601E123 RID: 123171 RVA: 0x009A1280 File Offset: 0x0099F480
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_layerDescArray(IntPtr l)
	{
		int result;
		try
		{
			FriendUITask friendUITask = (FriendUITask)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, friendUITask.m_luaExportHelper.m_layerDescArray);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601E124 RID: 123172 RVA: 0x009A12D8 File Offset: 0x0099F4D8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_layerDescArray(IntPtr l)
	{
		int result;
		try
		{
			FriendUITask friendUITask = (FriendUITask)LuaObject.checkSelf(l);
			UITaskBase.LayerDesc[] layerDescArray;
			LuaObject.checkArray<UITaskBase.LayerDesc>(l, 2, out layerDescArray);
			friendUITask.m_luaExportHelper.m_layerDescArray = layerDescArray;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601E125 RID: 123173 RVA: 0x009A1334 File Offset: 0x0099F534
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_uiCtrlDescArray(IntPtr l)
	{
		int result;
		try
		{
			FriendUITask friendUITask = (FriendUITask)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, friendUITask.m_luaExportHelper.m_uiCtrlDescArray);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601E126 RID: 123174 RVA: 0x009A138C File Offset: 0x0099F58C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_uiCtrlDescArray(IntPtr l)
	{
		int result;
		try
		{
			FriendUITask friendUITask = (FriendUITask)LuaObject.checkSelf(l);
			UITaskBase.UIControllerDesc[] uiCtrlDescArray;
			LuaObject.checkArray<UITaskBase.UIControllerDesc>(l, 2, out uiCtrlDescArray);
			friendUITask.m_luaExportHelper.m_uiCtrlDescArray = uiCtrlDescArray;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601E127 RID: 123175 RVA: 0x009A13E8 File Offset: 0x0099F5E8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_playerSimpleInfoUITask(IntPtr l)
	{
		int result;
		try
		{
			FriendUITask friendUITask = (FriendUITask)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, friendUITask.m_luaExportHelper.m_playerSimpleInfoUITask);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601E128 RID: 123176 RVA: 0x009A1440 File Offset: 0x0099F640
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_playerSimpleInfoUITask(IntPtr l)
	{
		int result;
		try
		{
			FriendUITask friendUITask = (FriendUITask)LuaObject.checkSelf(l);
			PlayerSimpleInfoUITask playerSimpleInfoUITask;
			LuaObject.checkType<PlayerSimpleInfoUITask>(l, 2, out playerSimpleInfoUITask);
			friendUITask.m_luaExportHelper.m_playerSimpleInfoUITask = playerSimpleInfoUITask;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601E129 RID: 123177 RVA: 0x009A149C File Offset: 0x0099F69C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_friendUIController(IntPtr l)
	{
		int result;
		try
		{
			FriendUITask friendUITask = (FriendUITask)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, friendUITask.m_luaExportHelper.m_friendUIController);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601E12A RID: 123178 RVA: 0x009A14F4 File Offset: 0x0099F6F4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_friendUIController(IntPtr l)
	{
		int result;
		try
		{
			FriendUITask friendUITask = (FriendUITask)LuaObject.checkSelf(l);
			FriendUIController friendUIController;
			LuaObject.checkType<FriendUIController>(l, 2, out friendUIController);
			friendUITask.m_luaExportHelper.m_friendUIController = friendUIController;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601E12B RID: 123179 RVA: 0x009A1550 File Offset: 0x0099F750
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_panelType(IntPtr l)
	{
		int result;
		try
		{
			FriendUITask friendUITask = (FriendUITask)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushEnum(l, (int)friendUITask.m_luaExportHelper.m_panelType);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601E12C RID: 123180 RVA: 0x009A15A8 File Offset: 0x0099F7A8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_panelType(IntPtr l)
	{
		int result;
		try
		{
			FriendUITask friendUITask = (FriendUITask)LuaObject.checkSelf(l);
			FriendPanelType panelType;
			LuaObject.checkEnum<FriendPanelType>(l, 2, out panelType);
			friendUITask.m_luaExportHelper.m_panelType = panelType;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601E12D RID: 123181 RVA: 0x009A1604 File Offset: 0x0099F804
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_invitedRecommendFriendIDList(IntPtr l)
	{
		int result;
		try
		{
			FriendUITask friendUITask = (FriendUITask)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, friendUITask.m_luaExportHelper.m_invitedRecommendFriendIDList);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601E12E RID: 123182 RVA: 0x009A165C File Offset: 0x0099F85C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_invitedRecommendFriendIDList(IntPtr l)
	{
		int result;
		try
		{
			FriendUITask friendUITask = (FriendUITask)LuaObject.checkSelf(l);
			List<string> invitedRecommendFriendIDList;
			LuaObject.checkType<List<string>>(l, 2, out invitedRecommendFriendIDList);
			friendUITask.m_luaExportHelper.m_invitedRecommendFriendIDList = invitedRecommendFriendIDList;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601E12F RID: 123183 RVA: 0x009A16B8 File Offset: 0x0099F8B8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_recommendFriendList(IntPtr l)
	{
		int result;
		try
		{
			FriendUITask friendUITask = (FriendUITask)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, friendUITask.m_luaExportHelper.m_recommendFriendList);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601E130 RID: 123184 RVA: 0x009A1710 File Offset: 0x0099F910
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_recommendFriendList(IntPtr l)
	{
		int result;
		try
		{
			FriendUITask friendUITask = (FriendUITask)LuaObject.checkSelf(l);
			List<UserSummary> recommendFriendList;
			LuaObject.checkType<List<UserSummary>>(l, 2, out recommendFriendList);
			friendUITask.m_luaExportHelper.m_recommendFriendList = recommendFriendList;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601E131 RID: 123185 RVA: 0x009A176C File Offset: 0x0099F96C
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_m_findFriendList(IntPtr l)
	{
		int result;
		try
		{
			FriendUITask friendUITask = (FriendUITask)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, friendUITask.m_luaExportHelper.m_findFriendList);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601E132 RID: 123186 RVA: 0x009A17C4 File Offset: 0x0099F9C4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_findFriendList(IntPtr l)
	{
		int result;
		try
		{
			FriendUITask friendUITask = (FriendUITask)LuaObject.checkSelf(l);
			List<UserSummary> findFriendList;
			LuaObject.checkType<List<UserSummary>>(l, 2, out findFriendList);
			friendUITask.m_luaExportHelper.m_findFriendList = findFriendList;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601E133 RID: 123187 RVA: 0x009A1820 File Offset: 0x0099FA20
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_sendFriendshipPointUserIDList(IntPtr l)
	{
		int result;
		try
		{
			FriendUITask friendUITask = (FriendUITask)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, friendUITask.m_luaExportHelper.m_sendFriendshipPointUserIDList);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601E134 RID: 123188 RVA: 0x009A1878 File Offset: 0x0099FA78
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_sendFriendshipPointUserIDList(IntPtr l)
	{
		int result;
		try
		{
			FriendUITask friendUITask = (FriendUITask)LuaObject.checkSelf(l);
			List<string> sendFriendshipPointUserIDList;
			LuaObject.checkType<List<string>>(l, 2, out sendFriendshipPointUserIDList);
			friendUITask.m_luaExportHelper.m_sendFriendshipPointUserIDList = sendFriendshipPointUserIDList;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601E135 RID: 123189 RVA: 0x009A18D4 File Offset: 0x0099FAD4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_getFriendshipPointUserIDList(IntPtr l)
	{
		int result;
		try
		{
			FriendUITask friendUITask = (FriendUITask)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, friendUITask.m_luaExportHelper.m_getFriendshipPointUserIDList);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601E136 RID: 123190 RVA: 0x009A192C File Offset: 0x0099FB2C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_getFriendshipPointUserIDList(IntPtr l)
	{
		int result;
		try
		{
			FriendUITask friendUITask = (FriendUITask)LuaObject.checkSelf(l);
			List<string> getFriendshipPointUserIDList;
			LuaObject.checkType<List<string>>(l, 2, out getFriendshipPointUserIDList);
			friendUITask.m_luaExportHelper.m_getFriendshipPointUserIDList = getFriendshipPointUserIDList;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601E137 RID: 123191 RVA: 0x009A1988 File Offset: 0x0099FB88
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_unblockPlayerUserID(IntPtr l)
	{
		int result;
		try
		{
			FriendUITask friendUITask = (FriendUITask)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, friendUITask.m_luaExportHelper.m_unblockPlayerUserID);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601E138 RID: 123192 RVA: 0x009A19E0 File Offset: 0x0099FBE0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_unblockPlayerUserID(IntPtr l)
	{
		int result;
		try
		{
			FriendUITask friendUITask = (FriendUITask)LuaObject.checkSelf(l);
			string unblockPlayerUserID;
			LuaObject.checkType(l, 2, out unblockPlayerUserID);
			friendUITask.m_luaExportHelper.m_unblockPlayerUserID = unblockPlayerUserID;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601E139 RID: 123193 RVA: 0x009A1A3C File Offset: 0x0099FC3C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_kickPlayerUserID(IntPtr l)
	{
		int result;
		try
		{
			FriendUITask friendUITask = (FriendUITask)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, friendUITask.m_luaExportHelper.m_kickPlayerUserID);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601E13A RID: 123194 RVA: 0x009A1A94 File Offset: 0x0099FC94
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_kickPlayerUserID(IntPtr l)
	{
		int result;
		try
		{
			FriendUITask friendUITask = (FriendUITask)LuaObject.checkSelf(l);
			string kickPlayerUserID;
			LuaObject.checkType(l, 2, out kickPlayerUserID);
			friendUITask.m_luaExportHelper.m_kickPlayerUserID = kickPlayerUserID;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601E13B RID: 123195 RVA: 0x009A1AF0 File Offset: 0x0099FCF0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_kickPlayerUserName(IntPtr l)
	{
		int result;
		try
		{
			FriendUITask friendUITask = (FriendUITask)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, friendUITask.m_luaExportHelper.m_kickPlayerUserName);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601E13C RID: 123196 RVA: 0x009A1B48 File Offset: 0x0099FD48
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_kickPlayerUserName(IntPtr l)
	{
		int result;
		try
		{
			FriendUITask friendUITask = (FriendUITask)LuaObject.checkSelf(l);
			string kickPlayerUserName;
			LuaObject.checkType(l, 2, out kickPlayerUserName);
			friendUITask.m_luaExportHelper.m_kickPlayerUserName = kickPlayerUserName;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601E13D RID: 123197 RVA: 0x009A1BA4 File Offset: 0x0099FDA4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_currentGroupInfo(IntPtr l)
	{
		int result;
		try
		{
			FriendUITask friendUITask = (FriendUITask)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, friendUITask.m_luaExportHelper.m_currentGroupInfo);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601E13E RID: 123198 RVA: 0x009A1BFC File Offset: 0x0099FDFC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_currentGroupInfo(IntPtr l)
	{
		int result;
		try
		{
			FriendUITask friendUITask = (FriendUITask)LuaObject.checkSelf(l);
			ProChatGroupInfo currentGroupInfo;
			LuaObject.checkType<ProChatGroupInfo>(l, 2, out currentGroupInfo);
			friendUITask.m_luaExportHelper.m_currentGroupInfo = currentGroupInfo;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601E13F RID: 123199 RVA: 0x009A1C58 File Offset: 0x0099FE58
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_playerContext(IntPtr l)
	{
		int result;
		try
		{
			FriendUITask friendUITask = (FriendUITask)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, friendUITask.m_luaExportHelper.m_playerContext);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601E140 RID: 123200 RVA: 0x009A1CB0 File Offset: 0x0099FEB0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_playerContext(IntPtr l)
	{
		int result;
		try
		{
			FriendUITask friendUITask = (FriendUITask)LuaObject.checkSelf(l);
			ProjectLPlayerContext playerContext;
			LuaObject.checkType<ProjectLPlayerContext>(l, 2, out playerContext);
			friendUITask.m_luaExportHelper.m_playerContext = playerContext;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601E141 RID: 123201 RVA: 0x009A1D0C File Offset: 0x0099FF0C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_configDataLoader(IntPtr l)
	{
		int result;
		try
		{
			FriendUITask friendUITask = (FriendUITask)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, friendUITask.m_luaExportHelper.m_configDataLoader);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601E142 RID: 123202 RVA: 0x009A1D64 File Offset: 0x0099FF64
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_configDataLoader(IntPtr l)
	{
		int result;
		try
		{
			FriendUITask friendUITask = (FriendUITask)LuaObject.checkSelf(l);
			IConfigDataLoader configDataLoader;
			LuaObject.checkType<IConfigDataLoader>(l, 2, out configDataLoader);
			friendUITask.m_luaExportHelper.m_configDataLoader = configDataLoader;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601E143 RID: 123203 RVA: 0x009A1DC0 File Offset: 0x0099FFC0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_LayerDescArray(IntPtr l)
	{
		int result;
		try
		{
			FriendUITask friendUITask = (FriendUITask)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, friendUITask.m_luaExportHelper.LayerDescArray);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601E144 RID: 123204 RVA: 0x009A1E18 File Offset: 0x009A0018
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_UICtrlDescArray(IntPtr l)
	{
		int result;
		try
		{
			FriendUITask friendUITask = (FriendUITask)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, friendUITask.m_luaExportHelper.UICtrlDescArray);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601E145 RID: 123205 RVA: 0x009A1E70 File Offset: 0x009A0070
	[Preserve]
	public static void reg(IntPtr l)
	{
		LuaObject.getTypeTable(l, "BlackJack.ProjectL.UI.FriendUITask");
		if (Lua_BlackJack_ProjectL_UI_FriendUITask.<>f__mg$cache0 == null)
		{
			Lua_BlackJack_ProjectL_UI_FriendUITask.<>f__mg$cache0 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_FriendUITask.InitAllUIControllers);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_FriendUITask.<>f__mg$cache0);
		if (Lua_BlackJack_ProjectL_UI_FriendUITask.<>f__mg$cache1 == null)
		{
			Lua_BlackJack_ProjectL_UI_FriendUITask.<>f__mg$cache1 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_FriendUITask.ClearAllContextAndRes);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_FriendUITask.<>f__mg$cache1);
		if (Lua_BlackJack_ProjectL_UI_FriendUITask.<>f__mg$cache2 == null)
		{
			Lua_BlackJack_ProjectL_UI_FriendUITask.<>f__mg$cache2 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_FriendUITask.RegisterPlayerContextEvents);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_FriendUITask.<>f__mg$cache2);
		if (Lua_BlackJack_ProjectL_UI_FriendUITask.<>f__mg$cache3 == null)
		{
			Lua_BlackJack_ProjectL_UI_FriendUITask.<>f__mg$cache3 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_FriendUITask.UnregisterPlayerContextEvents);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_FriendUITask.<>f__mg$cache3);
		if (Lua_BlackJack_ProjectL_UI_FriendUITask.<>f__mg$cache4 == null)
		{
			Lua_BlackJack_ProjectL_UI_FriendUITask.<>f__mg$cache4 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_FriendUITask.UpdateView);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_FriendUITask.<>f__mg$cache4);
		if (Lua_BlackJack_ProjectL_UI_FriendUITask.<>f__mg$cache5 == null)
		{
			Lua_BlackJack_ProjectL_UI_FriendUITask.<>f__mg$cache5 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_FriendUITask.UpdatePanel);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_FriendUITask.<>f__mg$cache5);
		if (Lua_BlackJack_ProjectL_UI_FriendUITask.<>f__mg$cache6 == null)
		{
			Lua_BlackJack_ProjectL_UI_FriendUITask.<>f__mg$cache6 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_FriendUITask.FriendUIController_OnShowPanel);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_FriendUITask.<>f__mg$cache6);
		if (Lua_BlackJack_ProjectL_UI_FriendUITask.<>f__mg$cache7 == null)
		{
			Lua_BlackJack_ProjectL_UI_FriendUITask.<>f__mg$cache7 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_FriendUITask.FriendUIController_OnReturn);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_FriendUITask.<>f__mg$cache7);
		if (Lua_BlackJack_ProjectL_UI_FriendUITask.<>f__mg$cache8 == null)
		{
			Lua_BlackJack_ProjectL_UI_FriendUITask.<>f__mg$cache8 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_FriendUITask.FriendUIController_OnShowHelp);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_FriendUITask.<>f__mg$cache8);
		if (Lua_BlackJack_ProjectL_UI_FriendUITask.<>f__mg$cache9 == null)
		{
			Lua_BlackJack_ProjectL_UI_FriendUITask.<>f__mg$cache9 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_FriendUITask.FriendUIController_OnGetSocialRelation);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_FriendUITask.<>f__mg$cache9);
		if (Lua_BlackJack_ProjectL_UI_FriendUITask.<>f__mg$cacheA == null)
		{
			Lua_BlackJack_ProjectL_UI_FriendUITask.<>f__mg$cacheA = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_FriendUITask.FriendUIController_OnShowPlayerInfo);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_FriendUITask.<>f__mg$cacheA);
		if (Lua_BlackJack_ProjectL_UI_FriendUITask.<>f__mg$cacheB == null)
		{
			Lua_BlackJack_ProjectL_UI_FriendUITask.<>f__mg$cacheB = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_FriendUITask.OnShowPlayerSimpleInfo);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_FriendUITask.<>f__mg$cacheB);
		if (Lua_BlackJack_ProjectL_UI_FriendUITask.<>f__mg$cacheC == null)
		{
			Lua_BlackJack_ProjectL_UI_FriendUITask.<>f__mg$cacheC = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_FriendUITask.PlayerSimpleInfoUITask_GetSocialRelation);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_FriendUITask.<>f__mg$cacheC);
		if (Lua_BlackJack_ProjectL_UI_FriendUITask.<>f__mg$cacheD == null)
		{
			Lua_BlackJack_ProjectL_UI_FriendUITask.<>f__mg$cacheD = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_FriendUITask.PlayerSimpleInfoUITask_OnClose);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_FriendUITask.<>f__mg$cacheD);
		if (Lua_BlackJack_ProjectL_UI_FriendUITask.<>f__mg$cacheE == null)
		{
			Lua_BlackJack_ProjectL_UI_FriendUITask.<>f__mg$cacheE = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_FriendUITask.PlayerSimpleInfoUITask_OnPrivateChatButtonClick);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_FriendUITask.<>f__mg$cacheE);
		if (Lua_BlackJack_ProjectL_UI_FriendUITask.<>f__mg$cacheF == null)
		{
			Lua_BlackJack_ProjectL_UI_FriendUITask.<>f__mg$cacheF = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_FriendUITask.FriendUIController_OnAddFriend);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_FriendUITask.<>f__mg$cacheF);
		if (Lua_BlackJack_ProjectL_UI_FriendUITask.<>f__mg$cache10 == null)
		{
			Lua_BlackJack_ProjectL_UI_FriendUITask.<>f__mg$cache10 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_FriendUITask.FriendUIController_OnFriendInviteAceept);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_FriendUITask.<>f__mg$cache10);
		if (Lua_BlackJack_ProjectL_UI_FriendUITask.<>f__mg$cache11 == null)
		{
			Lua_BlackJack_ProjectL_UI_FriendUITask.<>f__mg$cache11 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_FriendUITask.FriendUIController_OnFriendInviteDecline);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_FriendUITask.<>f__mg$cache11);
		if (Lua_BlackJack_ProjectL_UI_FriendUITask.<>f__mg$cache12 == null)
		{
			Lua_BlackJack_ProjectL_UI_FriendUITask.<>f__mg$cache12 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_FriendUITask.FriendUIController_OnUnblockPlayer);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_FriendUITask.<>f__mg$cache12);
		if (Lua_BlackJack_ProjectL_UI_FriendUITask.<>f__mg$cache13 == null)
		{
			Lua_BlackJack_ProjectL_UI_FriendUITask.<>f__mg$cache13 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_FriendUITask.UnblockPlayerCallback);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_FriendUITask.<>f__mg$cache13);
		if (Lua_BlackJack_ProjectL_UI_FriendUITask.<>f__mg$cache14 == null)
		{
			Lua_BlackJack_ProjectL_UI_FriendUITask.<>f__mg$cache14 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_FriendUITask.FriendUIController_OnFindFriend);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_FriendUITask.<>f__mg$cache14);
		if (Lua_BlackJack_ProjectL_UI_FriendUITask.<>f__mg$cache15 == null)
		{
			Lua_BlackJack_ProjectL_UI_FriendUITask.<>f__mg$cache15 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_FriendUITask.SetCurrentFindFriendList);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_FriendUITask.<>f__mg$cache15);
		if (Lua_BlackJack_ProjectL_UI_FriendUITask.<>f__mg$cache16 == null)
		{
			Lua_BlackJack_ProjectL_UI_FriendUITask.<>f__mg$cache16 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_FriendUITask.FriendUIController_OnGetRecommendFriendList);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_FriendUITask.<>f__mg$cache16);
		if (Lua_BlackJack_ProjectL_UI_FriendUITask.<>f__mg$cache17 == null)
		{
			Lua_BlackJack_ProjectL_UI_FriendUITask.<>f__mg$cache17 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_FriendUITask.SetCurrentRecommedFriendList);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_FriendUITask.<>f__mg$cache17);
		if (Lua_BlackJack_ProjectL_UI_FriendUITask.<>f__mg$cache18 == null)
		{
			Lua_BlackJack_ProjectL_UI_FriendUITask.<>f__mg$cache18 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_FriendUITask.FriendUIController_OnGetAllGroup);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_FriendUITask.<>f__mg$cache18);
		if (Lua_BlackJack_ProjectL_UI_FriendUITask.<>f__mg$cache19 == null)
		{
			Lua_BlackJack_ProjectL_UI_FriendUITask.<>f__mg$cache19 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_FriendUITask.FriendUIController_OnGroupChat);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_FriendUITask.<>f__mg$cache19);
		if (Lua_BlackJack_ProjectL_UI_FriendUITask.<>f__mg$cache1A == null)
		{
			Lua_BlackJack_ProjectL_UI_FriendUITask.<>f__mg$cache1A = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_FriendUITask.FriendUIController_OnWatchGroupStaff);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_FriendUITask.<>f__mg$cache1A);
		if (Lua_BlackJack_ProjectL_UI_FriendUITask.<>f__mg$cache1B == null)
		{
			Lua_BlackJack_ProjectL_UI_FriendUITask.<>f__mg$cache1B = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_FriendUITask.FriendUIController_OnCreateNewGroup);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_FriendUITask.<>f__mg$cache1B);
		if (Lua_BlackJack_ProjectL_UI_FriendUITask.<>f__mg$cache1C == null)
		{
			Lua_BlackJack_ProjectL_UI_FriendUITask.<>f__mg$cache1C = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_FriendUITask.FriendUIController_OnInviteFriendToGroup);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_FriendUITask.<>f__mg$cache1C);
		if (Lua_BlackJack_ProjectL_UI_FriendUITask.<>f__mg$cache1D == null)
		{
			Lua_BlackJack_ProjectL_UI_FriendUITask.<>f__mg$cache1D = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_FriendUITask.FriendUIController_OnChangeGroupName);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_FriendUITask.<>f__mg$cache1D);
		if (Lua_BlackJack_ProjectL_UI_FriendUITask.<>f__mg$cache1E == null)
		{
			Lua_BlackJack_ProjectL_UI_FriendUITask.<>f__mg$cache1E = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_FriendUITask.FriendUIController_OnLeaveGroup);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_FriendUITask.<>f__mg$cache1E);
		if (Lua_BlackJack_ProjectL_UI_FriendUITask.<>f__mg$cache1F == null)
		{
			Lua_BlackJack_ProjectL_UI_FriendUITask.<>f__mg$cache1F = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_FriendUITask.OnLeaveGroupDialogBoxCallback);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_FriendUITask.<>f__mg$cache1F);
		if (Lua_BlackJack_ProjectL_UI_FriendUITask.<>f__mg$cache20 == null)
		{
			Lua_BlackJack_ProjectL_UI_FriendUITask.<>f__mg$cache20 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_FriendUITask.FriendUIController_OnKickGroup);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_FriendUITask.<>f__mg$cache20);
		if (Lua_BlackJack_ProjectL_UI_FriendUITask.<>f__mg$cache21 == null)
		{
			Lua_BlackJack_ProjectL_UI_FriendUITask.<>f__mg$cache21 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_FriendUITask.OnKickFromGroupDialogBoxCallback);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_FriendUITask.<>f__mg$cache21);
		if (Lua_BlackJack_ProjectL_UI_FriendUITask.<>f__mg$cache22 == null)
		{
			Lua_BlackJack_ProjectL_UI_FriendUITask.<>f__mg$cache22 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_FriendUITask.FriendUIController_OnChat);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_FriendUITask.<>f__mg$cache22);
		if (Lua_BlackJack_ProjectL_UI_FriendUITask.<>f__mg$cache23 == null)
		{
			Lua_BlackJack_ProjectL_UI_FriendUITask.<>f__mg$cache23 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_FriendUITask.FriendUIController_OnSendFriendshipPoint);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_FriendUITask.<>f__mg$cache23);
		if (Lua_BlackJack_ProjectL_UI_FriendUITask.<>f__mg$cache24 == null)
		{
			Lua_BlackJack_ProjectL_UI_FriendUITask.<>f__mg$cache24 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_FriendUITask.FriendUIController_OnGetFriendshipPoint);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_FriendUITask.<>f__mg$cache24);
		if (Lua_BlackJack_ProjectL_UI_FriendUITask.<>f__mg$cache25 == null)
		{
			Lua_BlackJack_ProjectL_UI_FriendUITask.<>f__mg$cache25 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_FriendUITask.FriendUIController_OnSendAllFriendshipPoint);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_FriendUITask.<>f__mg$cache25);
		if (Lua_BlackJack_ProjectL_UI_FriendUITask.<>f__mg$cache26 == null)
		{
			Lua_BlackJack_ProjectL_UI_FriendUITask.<>f__mg$cache26 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_FriendUITask.FriendUIController_OnGetAllFriendshipPoint);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_FriendUITask.<>f__mg$cache26);
		if (Lua_BlackJack_ProjectL_UI_FriendUITask.<>f__mg$cache27 == null)
		{
			Lua_BlackJack_ProjectL_UI_FriendUITask.<>f__mg$cache27 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_FriendUITask.PlayerContext_OnChatGroupUpdateNtf);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_FriendUITask.<>f__mg$cache27);
		if (Lua_BlackJack_ProjectL_UI_FriendUITask.<>f__mg$cache28 == null)
		{
			Lua_BlackJack_ProjectL_UI_FriendUITask.<>f__mg$cache28 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_FriendUITask.isMeInTheGroup);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_FriendUITask.<>f__mg$cache28);
		if (Lua_BlackJack_ProjectL_UI_FriendUITask.<>f__mg$cache29 == null)
		{
			Lua_BlackJack_ProjectL_UI_FriendUITask.<>f__mg$cache29 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_FriendUITask.ShowErrorMessage);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_FriendUITask.<>f__mg$cache29);
		if (Lua_BlackJack_ProjectL_UI_FriendUITask.<>f__mg$cache2A == null)
		{
			Lua_BlackJack_ProjectL_UI_FriendUITask.<>f__mg$cache2A = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_FriendUITask.ShowMessage);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_FriendUITask.<>f__mg$cache2A);
		if (Lua_BlackJack_ProjectL_UI_FriendUITask.<>f__mg$cache2B == null)
		{
			Lua_BlackJack_ProjectL_UI_FriendUITask.<>f__mg$cache2B = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_FriendUITask.__callBase_OnStart);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_FriendUITask.<>f__mg$cache2B);
		if (Lua_BlackJack_ProjectL_UI_FriendUITask.<>f__mg$cache2C == null)
		{
			Lua_BlackJack_ProjectL_UI_FriendUITask.<>f__mg$cache2C = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_FriendUITask.__callBase_OnStop);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_FriendUITask.<>f__mg$cache2C);
		if (Lua_BlackJack_ProjectL_UI_FriendUITask.<>f__mg$cache2D == null)
		{
			Lua_BlackJack_ProjectL_UI_FriendUITask.<>f__mg$cache2D = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_FriendUITask.__callBase_OnPause);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_FriendUITask.<>f__mg$cache2D);
		if (Lua_BlackJack_ProjectL_UI_FriendUITask.<>f__mg$cache2E == null)
		{
			Lua_BlackJack_ProjectL_UI_FriendUITask.<>f__mg$cache2E = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_FriendUITask.__callBase_OnResume);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_FriendUITask.<>f__mg$cache2E);
		if (Lua_BlackJack_ProjectL_UI_FriendUITask.<>f__mg$cache2F == null)
		{
			Lua_BlackJack_ProjectL_UI_FriendUITask.<>f__mg$cache2F = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_FriendUITask.__callBase_OnNewIntent);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_FriendUITask.<>f__mg$cache2F);
		if (Lua_BlackJack_ProjectL_UI_FriendUITask.<>f__mg$cache30 == null)
		{
			Lua_BlackJack_ProjectL_UI_FriendUITask.<>f__mg$cache30 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_FriendUITask.__callBase_EnableUIInput);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_FriendUITask.<>f__mg$cache30);
		if (Lua_BlackJack_ProjectL_UI_FriendUITask.<>f__mg$cache31 == null)
		{
			Lua_BlackJack_ProjectL_UI_FriendUITask.<>f__mg$cache31 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_FriendUITask.__callBase_IsNeedLoadDynamicRes);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_FriendUITask.<>f__mg$cache31);
		if (Lua_BlackJack_ProjectL_UI_FriendUITask.<>f__mg$cache32 == null)
		{
			Lua_BlackJack_ProjectL_UI_FriendUITask.<>f__mg$cache32 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_FriendUITask.__callBase_CollectAllDynamicResForLoad);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_FriendUITask.<>f__mg$cache32);
		if (Lua_BlackJack_ProjectL_UI_FriendUITask.<>f__mg$cache33 == null)
		{
			Lua_BlackJack_ProjectL_UI_FriendUITask.<>f__mg$cache33 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_FriendUITask.__callBase_RegisterPlayerContextEvents);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_FriendUITask.<>f__mg$cache33);
		if (Lua_BlackJack_ProjectL_UI_FriendUITask.<>f__mg$cache34 == null)
		{
			Lua_BlackJack_ProjectL_UI_FriendUITask.<>f__mg$cache34 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_FriendUITask.__callBase_UnregisterPlayerContextEvents);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_FriendUITask.<>f__mg$cache34);
		if (Lua_BlackJack_ProjectL_UI_FriendUITask.<>f__mg$cache35 == null)
		{
			Lua_BlackJack_ProjectL_UI_FriendUITask.<>f__mg$cache35 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_FriendUITask.__callBase_PostUpdateView);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_FriendUITask.<>f__mg$cache35);
		if (Lua_BlackJack_ProjectL_UI_FriendUITask.<>f__mg$cache36 == null)
		{
			Lua_BlackJack_ProjectL_UI_FriendUITask.<>f__mg$cache36 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_FriendUITask.__callBase_CollectPreloadResourceList);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_FriendUITask.<>f__mg$cache36);
		if (Lua_BlackJack_ProjectL_UI_FriendUITask.<>f__mg$cache37 == null)
		{
			Lua_BlackJack_ProjectL_UI_FriendUITask.<>f__mg$cache37 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_FriendUITask.__callBase_ClearAssetList);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_FriendUITask.<>f__mg$cache37);
		if (Lua_BlackJack_ProjectL_UI_FriendUITask.<>f__mg$cache38 == null)
		{
			Lua_BlackJack_ProjectL_UI_FriendUITask.<>f__mg$cache38 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_FriendUITask.__callBase_CollectAsset);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_FriendUITask.<>f__mg$cache38);
		if (Lua_BlackJack_ProjectL_UI_FriendUITask.<>f__mg$cache39 == null)
		{
			Lua_BlackJack_ProjectL_UI_FriendUITask.<>f__mg$cache39 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_FriendUITask.__callBase_CollectSpriteAsset);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_FriendUITask.<>f__mg$cache39);
		if (Lua_BlackJack_ProjectL_UI_FriendUITask.<>f__mg$cache3A == null)
		{
			Lua_BlackJack_ProjectL_UI_FriendUITask.<>f__mg$cache3A = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_FriendUITask.__callBase_CollectFxAsset);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_FriendUITask.<>f__mg$cache3A);
		if (Lua_BlackJack_ProjectL_UI_FriendUITask.<>f__mg$cache3B == null)
		{
			Lua_BlackJack_ProjectL_UI_FriendUITask.<>f__mg$cache3B = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_FriendUITask.__callBase_StartLoadCustomAssets);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_FriendUITask.<>f__mg$cache3B);
		if (Lua_BlackJack_ProjectL_UI_FriendUITask.<>f__mg$cache3C == null)
		{
			Lua_BlackJack_ProjectL_UI_FriendUITask.<>f__mg$cache3C = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_FriendUITask.__callBase_IsLoadingCustomAssets);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_FriendUITask.<>f__mg$cache3C);
		if (Lua_BlackJack_ProjectL_UI_FriendUITask.<>f__mg$cache3D == null)
		{
			Lua_BlackJack_ProjectL_UI_FriendUITask.<>f__mg$cache3D = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_FriendUITask.__callBase_IsPipeLineRunning);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_FriendUITask.<>f__mg$cache3D);
		if (Lua_BlackJack_ProjectL_UI_FriendUITask.<>f__mg$cache3E == null)
		{
			Lua_BlackJack_ProjectL_UI_FriendUITask.<>f__mg$cache3E = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_FriendUITask.__callBase_IsOpeningUI);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_FriendUITask.<>f__mg$cache3E);
		if (Lua_BlackJack_ProjectL_UI_FriendUITask.<>f__mg$cache3F == null)
		{
			Lua_BlackJack_ProjectL_UI_FriendUITask.<>f__mg$cache3F = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_FriendUITask.__callBase_ReturnPrevUITask);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_FriendUITask.<>f__mg$cache3F);
		if (Lua_BlackJack_ProjectL_UI_FriendUITask.<>f__mg$cache40 == null)
		{
			Lua_BlackJack_ProjectL_UI_FriendUITask.<>f__mg$cache40 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_FriendUITask.__callBase_ClearUnusedDynamicResourceCache);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_FriendUITask.<>f__mg$cache40);
		if (Lua_BlackJack_ProjectL_UI_FriendUITask.<>f__mg$cache41 == null)
		{
			Lua_BlackJack_ProjectL_UI_FriendUITask.<>f__mg$cache41 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_FriendUITask.__callBase_OnMemoryWarning);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_FriendUITask.<>f__mg$cache41);
		string name = "m_layerDescArray";
		if (Lua_BlackJack_ProjectL_UI_FriendUITask.<>f__mg$cache42 == null)
		{
			Lua_BlackJack_ProjectL_UI_FriendUITask.<>f__mg$cache42 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_FriendUITask.get_m_layerDescArray);
		}
		LuaCSFunction get = Lua_BlackJack_ProjectL_UI_FriendUITask.<>f__mg$cache42;
		if (Lua_BlackJack_ProjectL_UI_FriendUITask.<>f__mg$cache43 == null)
		{
			Lua_BlackJack_ProjectL_UI_FriendUITask.<>f__mg$cache43 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_FriendUITask.set_m_layerDescArray);
		}
		LuaObject.addMember(l, name, get, Lua_BlackJack_ProjectL_UI_FriendUITask.<>f__mg$cache43, true);
		string name2 = "m_uiCtrlDescArray";
		if (Lua_BlackJack_ProjectL_UI_FriendUITask.<>f__mg$cache44 == null)
		{
			Lua_BlackJack_ProjectL_UI_FriendUITask.<>f__mg$cache44 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_FriendUITask.get_m_uiCtrlDescArray);
		}
		LuaCSFunction get2 = Lua_BlackJack_ProjectL_UI_FriendUITask.<>f__mg$cache44;
		if (Lua_BlackJack_ProjectL_UI_FriendUITask.<>f__mg$cache45 == null)
		{
			Lua_BlackJack_ProjectL_UI_FriendUITask.<>f__mg$cache45 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_FriendUITask.set_m_uiCtrlDescArray);
		}
		LuaObject.addMember(l, name2, get2, Lua_BlackJack_ProjectL_UI_FriendUITask.<>f__mg$cache45, true);
		string name3 = "m_playerSimpleInfoUITask";
		if (Lua_BlackJack_ProjectL_UI_FriendUITask.<>f__mg$cache46 == null)
		{
			Lua_BlackJack_ProjectL_UI_FriendUITask.<>f__mg$cache46 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_FriendUITask.get_m_playerSimpleInfoUITask);
		}
		LuaCSFunction get3 = Lua_BlackJack_ProjectL_UI_FriendUITask.<>f__mg$cache46;
		if (Lua_BlackJack_ProjectL_UI_FriendUITask.<>f__mg$cache47 == null)
		{
			Lua_BlackJack_ProjectL_UI_FriendUITask.<>f__mg$cache47 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_FriendUITask.set_m_playerSimpleInfoUITask);
		}
		LuaObject.addMember(l, name3, get3, Lua_BlackJack_ProjectL_UI_FriendUITask.<>f__mg$cache47, true);
		string name4 = "m_friendUIController";
		if (Lua_BlackJack_ProjectL_UI_FriendUITask.<>f__mg$cache48 == null)
		{
			Lua_BlackJack_ProjectL_UI_FriendUITask.<>f__mg$cache48 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_FriendUITask.get_m_friendUIController);
		}
		LuaCSFunction get4 = Lua_BlackJack_ProjectL_UI_FriendUITask.<>f__mg$cache48;
		if (Lua_BlackJack_ProjectL_UI_FriendUITask.<>f__mg$cache49 == null)
		{
			Lua_BlackJack_ProjectL_UI_FriendUITask.<>f__mg$cache49 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_FriendUITask.set_m_friendUIController);
		}
		LuaObject.addMember(l, name4, get4, Lua_BlackJack_ProjectL_UI_FriendUITask.<>f__mg$cache49, true);
		string name5 = "m_panelType";
		if (Lua_BlackJack_ProjectL_UI_FriendUITask.<>f__mg$cache4A == null)
		{
			Lua_BlackJack_ProjectL_UI_FriendUITask.<>f__mg$cache4A = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_FriendUITask.get_m_panelType);
		}
		LuaCSFunction get5 = Lua_BlackJack_ProjectL_UI_FriendUITask.<>f__mg$cache4A;
		if (Lua_BlackJack_ProjectL_UI_FriendUITask.<>f__mg$cache4B == null)
		{
			Lua_BlackJack_ProjectL_UI_FriendUITask.<>f__mg$cache4B = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_FriendUITask.set_m_panelType);
		}
		LuaObject.addMember(l, name5, get5, Lua_BlackJack_ProjectL_UI_FriendUITask.<>f__mg$cache4B, true);
		string name6 = "m_invitedRecommendFriendIDList";
		if (Lua_BlackJack_ProjectL_UI_FriendUITask.<>f__mg$cache4C == null)
		{
			Lua_BlackJack_ProjectL_UI_FriendUITask.<>f__mg$cache4C = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_FriendUITask.get_m_invitedRecommendFriendIDList);
		}
		LuaCSFunction get6 = Lua_BlackJack_ProjectL_UI_FriendUITask.<>f__mg$cache4C;
		if (Lua_BlackJack_ProjectL_UI_FriendUITask.<>f__mg$cache4D == null)
		{
			Lua_BlackJack_ProjectL_UI_FriendUITask.<>f__mg$cache4D = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_FriendUITask.set_m_invitedRecommendFriendIDList);
		}
		LuaObject.addMember(l, name6, get6, Lua_BlackJack_ProjectL_UI_FriendUITask.<>f__mg$cache4D, true);
		string name7 = "m_recommendFriendList";
		if (Lua_BlackJack_ProjectL_UI_FriendUITask.<>f__mg$cache4E == null)
		{
			Lua_BlackJack_ProjectL_UI_FriendUITask.<>f__mg$cache4E = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_FriendUITask.get_m_recommendFriendList);
		}
		LuaCSFunction get7 = Lua_BlackJack_ProjectL_UI_FriendUITask.<>f__mg$cache4E;
		if (Lua_BlackJack_ProjectL_UI_FriendUITask.<>f__mg$cache4F == null)
		{
			Lua_BlackJack_ProjectL_UI_FriendUITask.<>f__mg$cache4F = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_FriendUITask.set_m_recommendFriendList);
		}
		LuaObject.addMember(l, name7, get7, Lua_BlackJack_ProjectL_UI_FriendUITask.<>f__mg$cache4F, true);
		string name8 = "m_findFriendList";
		if (Lua_BlackJack_ProjectL_UI_FriendUITask.<>f__mg$cache50 == null)
		{
			Lua_BlackJack_ProjectL_UI_FriendUITask.<>f__mg$cache50 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_FriendUITask.get_m_findFriendList);
		}
		LuaCSFunction get8 = Lua_BlackJack_ProjectL_UI_FriendUITask.<>f__mg$cache50;
		if (Lua_BlackJack_ProjectL_UI_FriendUITask.<>f__mg$cache51 == null)
		{
			Lua_BlackJack_ProjectL_UI_FriendUITask.<>f__mg$cache51 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_FriendUITask.set_m_findFriendList);
		}
		LuaObject.addMember(l, name8, get8, Lua_BlackJack_ProjectL_UI_FriendUITask.<>f__mg$cache51, true);
		string name9 = "m_sendFriendshipPointUserIDList";
		if (Lua_BlackJack_ProjectL_UI_FriendUITask.<>f__mg$cache52 == null)
		{
			Lua_BlackJack_ProjectL_UI_FriendUITask.<>f__mg$cache52 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_FriendUITask.get_m_sendFriendshipPointUserIDList);
		}
		LuaCSFunction get9 = Lua_BlackJack_ProjectL_UI_FriendUITask.<>f__mg$cache52;
		if (Lua_BlackJack_ProjectL_UI_FriendUITask.<>f__mg$cache53 == null)
		{
			Lua_BlackJack_ProjectL_UI_FriendUITask.<>f__mg$cache53 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_FriendUITask.set_m_sendFriendshipPointUserIDList);
		}
		LuaObject.addMember(l, name9, get9, Lua_BlackJack_ProjectL_UI_FriendUITask.<>f__mg$cache53, true);
		string name10 = "m_getFriendshipPointUserIDList";
		if (Lua_BlackJack_ProjectL_UI_FriendUITask.<>f__mg$cache54 == null)
		{
			Lua_BlackJack_ProjectL_UI_FriendUITask.<>f__mg$cache54 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_FriendUITask.get_m_getFriendshipPointUserIDList);
		}
		LuaCSFunction get10 = Lua_BlackJack_ProjectL_UI_FriendUITask.<>f__mg$cache54;
		if (Lua_BlackJack_ProjectL_UI_FriendUITask.<>f__mg$cache55 == null)
		{
			Lua_BlackJack_ProjectL_UI_FriendUITask.<>f__mg$cache55 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_FriendUITask.set_m_getFriendshipPointUserIDList);
		}
		LuaObject.addMember(l, name10, get10, Lua_BlackJack_ProjectL_UI_FriendUITask.<>f__mg$cache55, true);
		string name11 = "m_unblockPlayerUserID";
		if (Lua_BlackJack_ProjectL_UI_FriendUITask.<>f__mg$cache56 == null)
		{
			Lua_BlackJack_ProjectL_UI_FriendUITask.<>f__mg$cache56 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_FriendUITask.get_m_unblockPlayerUserID);
		}
		LuaCSFunction get11 = Lua_BlackJack_ProjectL_UI_FriendUITask.<>f__mg$cache56;
		if (Lua_BlackJack_ProjectL_UI_FriendUITask.<>f__mg$cache57 == null)
		{
			Lua_BlackJack_ProjectL_UI_FriendUITask.<>f__mg$cache57 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_FriendUITask.set_m_unblockPlayerUserID);
		}
		LuaObject.addMember(l, name11, get11, Lua_BlackJack_ProjectL_UI_FriendUITask.<>f__mg$cache57, true);
		string name12 = "m_kickPlayerUserID";
		if (Lua_BlackJack_ProjectL_UI_FriendUITask.<>f__mg$cache58 == null)
		{
			Lua_BlackJack_ProjectL_UI_FriendUITask.<>f__mg$cache58 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_FriendUITask.get_m_kickPlayerUserID);
		}
		LuaCSFunction get12 = Lua_BlackJack_ProjectL_UI_FriendUITask.<>f__mg$cache58;
		if (Lua_BlackJack_ProjectL_UI_FriendUITask.<>f__mg$cache59 == null)
		{
			Lua_BlackJack_ProjectL_UI_FriendUITask.<>f__mg$cache59 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_FriendUITask.set_m_kickPlayerUserID);
		}
		LuaObject.addMember(l, name12, get12, Lua_BlackJack_ProjectL_UI_FriendUITask.<>f__mg$cache59, true);
		string name13 = "m_kickPlayerUserName";
		if (Lua_BlackJack_ProjectL_UI_FriendUITask.<>f__mg$cache5A == null)
		{
			Lua_BlackJack_ProjectL_UI_FriendUITask.<>f__mg$cache5A = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_FriendUITask.get_m_kickPlayerUserName);
		}
		LuaCSFunction get13 = Lua_BlackJack_ProjectL_UI_FriendUITask.<>f__mg$cache5A;
		if (Lua_BlackJack_ProjectL_UI_FriendUITask.<>f__mg$cache5B == null)
		{
			Lua_BlackJack_ProjectL_UI_FriendUITask.<>f__mg$cache5B = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_FriendUITask.set_m_kickPlayerUserName);
		}
		LuaObject.addMember(l, name13, get13, Lua_BlackJack_ProjectL_UI_FriendUITask.<>f__mg$cache5B, true);
		string name14 = "m_currentGroupInfo";
		if (Lua_BlackJack_ProjectL_UI_FriendUITask.<>f__mg$cache5C == null)
		{
			Lua_BlackJack_ProjectL_UI_FriendUITask.<>f__mg$cache5C = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_FriendUITask.get_m_currentGroupInfo);
		}
		LuaCSFunction get14 = Lua_BlackJack_ProjectL_UI_FriendUITask.<>f__mg$cache5C;
		if (Lua_BlackJack_ProjectL_UI_FriendUITask.<>f__mg$cache5D == null)
		{
			Lua_BlackJack_ProjectL_UI_FriendUITask.<>f__mg$cache5D = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_FriendUITask.set_m_currentGroupInfo);
		}
		LuaObject.addMember(l, name14, get14, Lua_BlackJack_ProjectL_UI_FriendUITask.<>f__mg$cache5D, true);
		string name15 = "m_playerContext";
		if (Lua_BlackJack_ProjectL_UI_FriendUITask.<>f__mg$cache5E == null)
		{
			Lua_BlackJack_ProjectL_UI_FriendUITask.<>f__mg$cache5E = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_FriendUITask.get_m_playerContext);
		}
		LuaCSFunction get15 = Lua_BlackJack_ProjectL_UI_FriendUITask.<>f__mg$cache5E;
		if (Lua_BlackJack_ProjectL_UI_FriendUITask.<>f__mg$cache5F == null)
		{
			Lua_BlackJack_ProjectL_UI_FriendUITask.<>f__mg$cache5F = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_FriendUITask.set_m_playerContext);
		}
		LuaObject.addMember(l, name15, get15, Lua_BlackJack_ProjectL_UI_FriendUITask.<>f__mg$cache5F, true);
		string name16 = "m_configDataLoader";
		if (Lua_BlackJack_ProjectL_UI_FriendUITask.<>f__mg$cache60 == null)
		{
			Lua_BlackJack_ProjectL_UI_FriendUITask.<>f__mg$cache60 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_FriendUITask.get_m_configDataLoader);
		}
		LuaCSFunction get16 = Lua_BlackJack_ProjectL_UI_FriendUITask.<>f__mg$cache60;
		if (Lua_BlackJack_ProjectL_UI_FriendUITask.<>f__mg$cache61 == null)
		{
			Lua_BlackJack_ProjectL_UI_FriendUITask.<>f__mg$cache61 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_FriendUITask.set_m_configDataLoader);
		}
		LuaObject.addMember(l, name16, get16, Lua_BlackJack_ProjectL_UI_FriendUITask.<>f__mg$cache61, true);
		string name17 = "LayerDescArray";
		if (Lua_BlackJack_ProjectL_UI_FriendUITask.<>f__mg$cache62 == null)
		{
			Lua_BlackJack_ProjectL_UI_FriendUITask.<>f__mg$cache62 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_FriendUITask.get_LayerDescArray);
		}
		LuaObject.addMember(l, name17, Lua_BlackJack_ProjectL_UI_FriendUITask.<>f__mg$cache62, null, true);
		string name18 = "UICtrlDescArray";
		if (Lua_BlackJack_ProjectL_UI_FriendUITask.<>f__mg$cache63 == null)
		{
			Lua_BlackJack_ProjectL_UI_FriendUITask.<>f__mg$cache63 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_FriendUITask.get_UICtrlDescArray);
		}
		LuaObject.addMember(l, name18, Lua_BlackJack_ProjectL_UI_FriendUITask.<>f__mg$cache63, null, true);
		if (Lua_BlackJack_ProjectL_UI_FriendUITask.<>f__mg$cache64 == null)
		{
			Lua_BlackJack_ProjectL_UI_FriendUITask.<>f__mg$cache64 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_FriendUITask.constructor);
		}
		LuaObject.createTypeMetatable(l, Lua_BlackJack_ProjectL_UI_FriendUITask.<>f__mg$cache64, typeof(FriendUITask), typeof(UITask));
	}

	// Token: 0x04014210 RID: 82448
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache0;

	// Token: 0x04014211 RID: 82449
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1;

	// Token: 0x04014212 RID: 82450
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2;

	// Token: 0x04014213 RID: 82451
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3;

	// Token: 0x04014214 RID: 82452
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache4;

	// Token: 0x04014215 RID: 82453
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache5;

	// Token: 0x04014216 RID: 82454
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache6;

	// Token: 0x04014217 RID: 82455
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache7;

	// Token: 0x04014218 RID: 82456
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache8;

	// Token: 0x04014219 RID: 82457
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache9;

	// Token: 0x0401421A RID: 82458
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheA;

	// Token: 0x0401421B RID: 82459
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheB;

	// Token: 0x0401421C RID: 82460
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheC;

	// Token: 0x0401421D RID: 82461
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheD;

	// Token: 0x0401421E RID: 82462
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheE;

	// Token: 0x0401421F RID: 82463
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheF;

	// Token: 0x04014220 RID: 82464
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache10;

	// Token: 0x04014221 RID: 82465
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache11;

	// Token: 0x04014222 RID: 82466
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache12;

	// Token: 0x04014223 RID: 82467
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache13;

	// Token: 0x04014224 RID: 82468
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache14;

	// Token: 0x04014225 RID: 82469
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache15;

	// Token: 0x04014226 RID: 82470
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache16;

	// Token: 0x04014227 RID: 82471
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache17;

	// Token: 0x04014228 RID: 82472
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache18;

	// Token: 0x04014229 RID: 82473
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache19;

	// Token: 0x0401422A RID: 82474
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1A;

	// Token: 0x0401422B RID: 82475
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1B;

	// Token: 0x0401422C RID: 82476
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1C;

	// Token: 0x0401422D RID: 82477
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1D;

	// Token: 0x0401422E RID: 82478
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1E;

	// Token: 0x0401422F RID: 82479
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1F;

	// Token: 0x04014230 RID: 82480
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache20;

	// Token: 0x04014231 RID: 82481
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache21;

	// Token: 0x04014232 RID: 82482
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache22;

	// Token: 0x04014233 RID: 82483
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache23;

	// Token: 0x04014234 RID: 82484
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache24;

	// Token: 0x04014235 RID: 82485
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache25;

	// Token: 0x04014236 RID: 82486
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache26;

	// Token: 0x04014237 RID: 82487
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache27;

	// Token: 0x04014238 RID: 82488
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache28;

	// Token: 0x04014239 RID: 82489
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache29;

	// Token: 0x0401423A RID: 82490
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2A;

	// Token: 0x0401423B RID: 82491
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2B;

	// Token: 0x0401423C RID: 82492
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2C;

	// Token: 0x0401423D RID: 82493
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2D;

	// Token: 0x0401423E RID: 82494
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2E;

	// Token: 0x0401423F RID: 82495
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2F;

	// Token: 0x04014240 RID: 82496
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache30;

	// Token: 0x04014241 RID: 82497
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache31;

	// Token: 0x04014242 RID: 82498
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache32;

	// Token: 0x04014243 RID: 82499
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache33;

	// Token: 0x04014244 RID: 82500
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache34;

	// Token: 0x04014245 RID: 82501
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache35;

	// Token: 0x04014246 RID: 82502
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache36;

	// Token: 0x04014247 RID: 82503
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache37;

	// Token: 0x04014248 RID: 82504
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache38;

	// Token: 0x04014249 RID: 82505
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache39;

	// Token: 0x0401424A RID: 82506
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3A;

	// Token: 0x0401424B RID: 82507
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3B;

	// Token: 0x0401424C RID: 82508
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3C;

	// Token: 0x0401424D RID: 82509
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3D;

	// Token: 0x0401424E RID: 82510
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3E;

	// Token: 0x0401424F RID: 82511
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3F;

	// Token: 0x04014250 RID: 82512
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache40;

	// Token: 0x04014251 RID: 82513
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache41;

	// Token: 0x04014252 RID: 82514
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache42;

	// Token: 0x04014253 RID: 82515
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache43;

	// Token: 0x04014254 RID: 82516
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache44;

	// Token: 0x04014255 RID: 82517
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache45;

	// Token: 0x04014256 RID: 82518
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache46;

	// Token: 0x04014257 RID: 82519
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache47;

	// Token: 0x04014258 RID: 82520
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache48;

	// Token: 0x04014259 RID: 82521
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache49;

	// Token: 0x0401425A RID: 82522
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache4A;

	// Token: 0x0401425B RID: 82523
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache4B;

	// Token: 0x0401425C RID: 82524
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache4C;

	// Token: 0x0401425D RID: 82525
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache4D;

	// Token: 0x0401425E RID: 82526
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache4E;

	// Token: 0x0401425F RID: 82527
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache4F;

	// Token: 0x04014260 RID: 82528
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache50;

	// Token: 0x04014261 RID: 82529
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache51;

	// Token: 0x04014262 RID: 82530
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache52;

	// Token: 0x04014263 RID: 82531
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache53;

	// Token: 0x04014264 RID: 82532
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache54;

	// Token: 0x04014265 RID: 82533
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache55;

	// Token: 0x04014266 RID: 82534
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache56;

	// Token: 0x04014267 RID: 82535
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache57;

	// Token: 0x04014268 RID: 82536
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache58;

	// Token: 0x04014269 RID: 82537
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache59;

	// Token: 0x0401426A RID: 82538
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache5A;

	// Token: 0x0401426B RID: 82539
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache5B;

	// Token: 0x0401426C RID: 82540
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache5C;

	// Token: 0x0401426D RID: 82541
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache5D;

	// Token: 0x0401426E RID: 82542
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache5E;

	// Token: 0x0401426F RID: 82543
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache5F;

	// Token: 0x04014270 RID: 82544
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache60;

	// Token: 0x04014271 RID: 82545
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache61;

	// Token: 0x04014272 RID: 82546
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache62;

	// Token: 0x04014273 RID: 82547
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache63;

	// Token: 0x04014274 RID: 82548
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache64;
}
