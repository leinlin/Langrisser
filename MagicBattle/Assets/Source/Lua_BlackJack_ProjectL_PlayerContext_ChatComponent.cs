using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using BlackJack.ProjectL.Common;
using BlackJack.ProjectL.PlayerContext;
using BlackJack.ProjectL.Protocol;
using SLua;
using UnityEngine.Scripting;

// Token: 0x020012B6 RID: 4790
[Preserve]
public class Lua_BlackJack_ProjectL_PlayerContext_ChatComponent : LuaObject
{
	// Token: 0x060192B9 RID: 103097 RVA: 0x00731E40 File Offset: 0x00730040
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int constructor(IntPtr l)
	{
		int result;
		try
		{
			ChatComponent o = new ChatComponent();
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

	// Token: 0x060192BA RID: 103098 RVA: 0x00731E88 File Offset: 0x00730088
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int Init(IntPtr l)
	{
		int result;
		try
		{
			ChatComponent chatComponent = (ChatComponent)LuaObject.checkSelf(l);
			chatComponent.Init();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060192BB RID: 103099 RVA: 0x00731ED4 File Offset: 0x007300D4
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int PostInit(IntPtr l)
	{
		int result;
		try
		{
			ChatComponent chatComponent = (ChatComponent)LuaObject.checkSelf(l);
			chatComponent.PostInit();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060192BC RID: 103100 RVA: 0x00731F20 File Offset: 0x00730120
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int DeInit(IntPtr l)
	{
		int result;
		try
		{
			ChatComponent chatComponent = (ChatComponent)LuaObject.checkSelf(l);
			chatComponent.DeInit();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060192BD RID: 103101 RVA: 0x00731F6C File Offset: 0x0073016C
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int DeSerialize(IntPtr l)
	{
		int result;
		try
		{
			ChatComponent chatComponent = (ChatComponent)LuaObject.checkSelf(l);
			DSChatNtf msg;
			LuaObject.checkType<DSChatNtf>(l, 2, out msg);
			chatComponent.DeSerialize(msg);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060192BE RID: 103102 RVA: 0x00731FC4 File Offset: 0x007301C4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int ReadChatBeforeDate(IntPtr l)
	{
		int result;
		try
		{
			ChatComponent chatComponent = (ChatComponent)LuaObject.checkSelf(l);
			ChatChannel type;
			LuaObject.checkEnum<ChatChannel>(l, 2, out type);
			DateTime date;
			LuaObject.checkValueType<DateTime>(l, 3, out date);
			chatComponent.ReadChatBeforeDate(type, date);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060192BF RID: 103103 RVA: 0x00732028 File Offset: 0x00730228
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int CanSendChatMessage(IntPtr l)
	{
		int result;
		try
		{
			ChatComponent chatComponent = (ChatComponent)LuaObject.checkSelf(l);
			int channelId;
			LuaObject.checkType(l, 2, out channelId);
			int i = chatComponent.CanSendChatMessage(channelId);
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

	// Token: 0x060192C0 RID: 103104 RVA: 0x0073208C File Offset: 0x0073028C
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int NotifyGetPlayerInfo(IntPtr l)
	{
		int result;
		try
		{
			ChatComponent chatComponent = (ChatComponent)LuaObject.checkSelf(l);
			List<ProUserSummary> userInfoList;
			LuaObject.checkType<List<ProUserSummary>>(l, 2, out userInfoList);
			chatComponent.NotifyGetPlayerInfo(userInfoList);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060192C1 RID: 103105 RVA: 0x007320E4 File Offset: 0x007302E4
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int NotifyChatMessage(IntPtr l)
	{
		int result;
		try
		{
			ChatComponent chatComponent = (ChatComponent)LuaObject.checkSelf(l);
			ChatMessageNtf msg;
			LuaObject.checkType<ChatMessageNtf>(l, 2, out msg);
			ChatMessage o = chatComponent.NotifyChatMessage(msg);
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

	// Token: 0x060192C2 RID: 103106 RVA: 0x00732148 File Offset: 0x00730348
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int CreateASystemTip(IntPtr l)
	{
		int result;
		try
		{
			ChatComponent chatComponent = (ChatComponent)LuaObject.checkSelf(l);
			ChatChannel channel;
			LuaObject.checkEnum<ChatChannel>(l, 2, out channel);
			string tips;
			LuaObject.checkType(l, 3, out tips);
			ChatComponent.ChatMessageClient o = chatComponent.CreateASystemTip(channel, tips);
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

	// Token: 0x060192C3 RID: 103107 RVA: 0x007321B8 File Offset: 0x007303B8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int IsHasHistoryRecord4Chat(IntPtr l)
	{
		int result;
		try
		{
			ChatComponent chatComponent = (ChatComponent)LuaObject.checkSelf(l);
			ChatChannel channel;
			LuaObject.checkEnum<ChatChannel>(l, 2, out channel);
			string id;
			LuaObject.checkType(l, 3, out id);
			bool b = chatComponent.IsHasHistoryRecord4Chat(channel, id);
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

	// Token: 0x060192C4 RID: 103108 RVA: 0x00732228 File Offset: 0x00730428
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int LoadChatHistoryData(IntPtr l)
	{
		int result;
		try
		{
			ChatComponent chatComponent = (ChatComponent)LuaObject.checkSelf(l);
			DateTime currTime;
			LuaObject.checkValueType<DateTime>(l, 2, out currTime);
			chatComponent.LoadChatHistoryData(currTime);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060192C5 RID: 103109 RVA: 0x00732280 File Offset: 0x00730480
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int SaveChatHistoryData(IntPtr l)
	{
		int result;
		try
		{
			ChatComponent chatComponent = (ChatComponent)LuaObject.checkSelf(l);
			chatComponent.SaveChatHistoryData();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060192C6 RID: 103110 RVA: 0x007322CC File Offset: 0x007304CC
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int GetSaveFileName(IntPtr l)
	{
		int result;
		try
		{
			ChatComponent chatComponent = (ChatComponent)LuaObject.checkSelf(l);
			string userId;
			LuaObject.checkType(l, 2, out userId);
			string saveFileName = chatComponent.GetSaveFileName(userId);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, saveFileName);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060192C7 RID: 103111 RVA: 0x00732330 File Offset: 0x00730530
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int GetGroupChatTarget(IntPtr l)
	{
		int result;
		try
		{
			ChatComponent chatComponent = (ChatComponent)LuaObject.checkSelf(l);
			string groupChatTarget = chatComponent.GetGroupChatTarget();
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, groupChatTarget);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060192C8 RID: 103112 RVA: 0x00732384 File Offset: 0x00730584
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int SetGroupChatTarget(IntPtr l)
	{
		int result;
		try
		{
			ChatComponent chatComponent = (ChatComponent)LuaObject.checkSelf(l);
			string groupChatTarget;
			LuaObject.checkType(l, 2, out groupChatTarget);
			chatComponent.SetGroupChatTarget(groupChatTarget);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060192C9 RID: 103113 RVA: 0x007323DC File Offset: 0x007305DC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int SetPrivateChatTarget(IntPtr l)
	{
		int result;
		try
		{
			ChatComponent chatComponent = (ChatComponent)LuaObject.checkSelf(l);
			string privateChatTarget;
			LuaObject.checkType(l, 2, out privateChatTarget);
			chatComponent.SetPrivateChatTarget(privateChatTarget);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060192CA RID: 103114 RVA: 0x00732434 File Offset: 0x00730634
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int GetUserInfo(IntPtr l)
	{
		int result;
		try
		{
			ChatComponent chatComponent = (ChatComponent)LuaObject.checkSelf(l);
			string gameUserId;
			LuaObject.checkType(l, 2, out gameUserId);
			UserSummary userInfo = chatComponent.GetUserInfo(gameUserId);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, userInfo);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060192CB RID: 103115 RVA: 0x00732498 File Offset: 0x00730698
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int AddUserInfo(IntPtr l)
	{
		int result;
		try
		{
			ChatComponent chatComponent = (ChatComponent)LuaObject.checkSelf(l);
			UserSummary userSummary;
			LuaObject.checkType<UserSummary>(l, 2, out userSummary);
			chatComponent.AddUserInfo(userSummary);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060192CC RID: 103116 RVA: 0x007324F0 File Offset: 0x007306F0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int NotifyEnterNewRoom(IntPtr l)
	{
		int result;
		try
		{
			ChatComponent chatComponent = (ChatComponent)LuaObject.checkSelf(l);
			int roomindex;
			LuaObject.checkType(l, 2, out roomindex);
			chatComponent.NotifyEnterNewRoom(roomindex);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060192CD RID: 103117 RVA: 0x00732548 File Offset: 0x00730748
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int GetDSVersion(IntPtr l)
	{
		int result;
		try
		{
			ChatComponent chatComponent = (ChatComponent)LuaObject.checkSelf(l);
			ushort dsversion = chatComponent.GetDSVersion();
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

	// Token: 0x060192CE RID: 103118 RVA: 0x0073259C File Offset: 0x0073079C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int GetChatMessageList(IntPtr l)
	{
		int result;
		try
		{
			ChatComponent chatComponent = (ChatComponent)LuaObject.checkSelf(l);
			ChatChannel channel;
			LuaObject.checkEnum<ChatChannel>(l, 2, out channel);
			List<ChatComponent.ChatMessageClient> chatMessageList = chatComponent.GetChatMessageList(channel);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, chatMessageList);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060192CF RID: 103119 RVA: 0x00732600 File Offset: 0x00730800
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int GetUnReadChatMsgCount4PointPlayerOrGroup(IntPtr l)
	{
		int result;
		try
		{
			ChatComponent chatComponent = (ChatComponent)LuaObject.checkSelf(l);
			ChatChannel channel;
			LuaObject.checkEnum<ChatChannel>(l, 2, out channel);
			string id;
			LuaObject.checkType(l, 3, out id);
			int unReadChatMsgCount4PointPlayerOrGroup = chatComponent.GetUnReadChatMsgCount4PointPlayerOrGroup(channel, id);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, unReadChatMsgCount4PointPlayerOrGroup);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060192D0 RID: 103120 RVA: 0x00732670 File Offset: 0x00730870
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int GetRecentChatTargetList(IntPtr l)
	{
		int result;
		try
		{
			ChatComponent chatComponent = (ChatComponent)LuaObject.checkSelf(l);
			ChatChannel channel;
			LuaObject.checkEnum<ChatChannel>(l, 2, out channel);
			KeyValuePair<List<string>, List<string>> recentChatTargetList = chatComponent.GetRecentChatTargetList(channel);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, recentChatTargetList);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060192D1 RID: 103121 RVA: 0x007326D8 File Offset: 0x007308D8
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int GetAllUnReadChatMsgCount(IntPtr l)
	{
		int result;
		try
		{
			ChatComponent chatComponent = (ChatComponent)LuaObject.checkSelf(l);
			int allUnReadChatMsgCount = chatComponent.GetAllUnReadChatMsgCount();
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, allUnReadChatMsgCount);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060192D2 RID: 103122 RVA: 0x0073272C File Offset: 0x0073092C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int GetGroupUnreadChatMsgCount(IntPtr l)
	{
		int result;
		try
		{
			ChatComponent chatComponent = (ChatComponent)LuaObject.checkSelf(l);
			int groupUnreadChatMsgCount = chatComponent.GetGroupUnreadChatMsgCount();
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, groupUnreadChatMsgCount);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060192D3 RID: 103123 RVA: 0x00732780 File Offset: 0x00730980
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int GetAssignGroupUnreadChatMsgCount(IntPtr l)
	{
		int result;
		try
		{
			ChatComponent chatComponent = (ChatComponent)LuaObject.checkSelf(l);
			string groupID;
			LuaObject.checkType(l, 2, out groupID);
			int assignGroupUnreadChatMsgCount = chatComponent.GetAssignGroupUnreadChatMsgCount(groupID);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, assignGroupUnreadChatMsgCount);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060192D4 RID: 103124 RVA: 0x007327E4 File Offset: 0x007309E4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int GetAssignPrivateUnreadChatMsgCount(IntPtr l)
	{
		int result;
		try
		{
			ChatComponent chatComponent = (ChatComponent)LuaObject.checkSelf(l);
			string userID;
			LuaObject.checkType(l, 2, out userID);
			int assignPrivateUnreadChatMsgCount = chatComponent.GetAssignPrivateUnreadChatMsgCount(userID);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, assignPrivateUnreadChatMsgCount);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060192D5 RID: 103125 RVA: 0x00732848 File Offset: 0x00730A48
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int GetPrivateUnreadChatMsgCount(IntPtr l)
	{
		int result;
		try
		{
			ChatComponent chatComponent = (ChatComponent)LuaObject.checkSelf(l);
			int privateUnreadChatMsgCount = chatComponent.GetPrivateUnreadChatMsgCount();
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, privateUnreadChatMsgCount);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060192D6 RID: 103126 RVA: 0x0073289C File Offset: 0x00730A9C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int GetGuildUnreadChatMsgCount(IntPtr l)
	{
		int result;
		try
		{
			ChatComponent chatComponent = (ChatComponent)LuaObject.checkSelf(l);
			int guildUnreadChatMsgCount = chatComponent.GetGuildUnreadChatMsgCount();
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, guildUnreadChatMsgCount);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060192D7 RID: 103127 RVA: 0x007328F0 File Offset: 0x00730AF0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int ReadChat(IntPtr l)
	{
		int result;
		try
		{
			ChatComponent chatComponent = (ChatComponent)LuaObject.checkSelf(l);
			ChatComponent.ChatMessageClient msg;
			LuaObject.checkType<ChatComponent.ChatMessageClient>(l, 2, out msg);
			chatComponent.ReadChat(msg);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060192D8 RID: 103128 RVA: 0x00732948 File Offset: 0x00730B48
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int SetRecentTeamMsgRead(IntPtr l)
	{
		int result;
		try
		{
			ChatComponent chatComponent = (ChatComponent)LuaObject.checkSelf(l);
			chatComponent.SetRecentTeamMsgRead();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060192D9 RID: 103129 RVA: 0x00732994 File Offset: 0x00730B94
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int SetGroupChatMsgReadByID(IntPtr l)
	{
		int result;
		try
		{
			ChatComponent chatComponent = (ChatComponent)LuaObject.checkSelf(l);
			string groupChatMsgReadByID;
			LuaObject.checkType(l, 2, out groupChatMsgReadByID);
			chatComponent.SetGroupChatMsgReadByID(groupChatMsgReadByID);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060192DA RID: 103130 RVA: 0x007329EC File Offset: 0x00730BEC
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int SetPrivateChatMsgReadByID(IntPtr l)
	{
		int result;
		try
		{
			ChatComponent chatComponent = (ChatComponent)LuaObject.checkSelf(l);
			string privateChatMsgReadByID;
			LuaObject.checkType(l, 2, out privateChatMsgReadByID);
			chatComponent.SetPrivateChatMsgReadByID(privateChatMsgReadByID);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060192DB RID: 103131 RVA: 0x00732A44 File Offset: 0x00730C44
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int ClearChatMessage4LimitCondition(IntPtr l)
	{
		int result;
		try
		{
			ChatComponent chatComponent = (ChatComponent)LuaObject.checkSelf(l);
			DateTime currTime;
			LuaObject.checkValueType<DateTime>(l, 2, out currTime);
			chatComponent.m_luaExportHelper.ClearChatMessage4LimitCondition(currTime);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060192DC RID: 103132 RVA: 0x00732AA0 File Offset: 0x00730CA0
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int AddMsgToGroupChatDict(IntPtr l)
	{
		int result;
		try
		{
			ChatComponent chatComponent = (ChatComponent)LuaObject.checkSelf(l);
			ChatComponent.ChatMessageClient chatMessage;
			LuaObject.checkType<ChatComponent.ChatMessageClient>(l, 2, out chatMessage);
			chatComponent.m_luaExportHelper.AddMsgToGroupChatDict(chatMessage);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060192DD RID: 103133 RVA: 0x00732AFC File Offset: 0x00730CFC
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int AddMsgToPrivateChatDict(IntPtr l)
	{
		int result;
		try
		{
			ChatComponent chatComponent = (ChatComponent)LuaObject.checkSelf(l);
			ChatComponent.ChatMessageClient chatMessage;
			LuaObject.checkType<ChatComponent.ChatMessageClient>(l, 2, out chatMessage);
			chatComponent.m_luaExportHelper.AddMsgToPrivateChatDict(chatMessage);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060192DE RID: 103134 RVA: 0x00732B58 File Offset: 0x00730D58
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int NotifySystemChatMessage(IntPtr l)
	{
		int result;
		try
		{
			ChatComponent chatComponent = (ChatComponent)LuaObject.checkSelf(l);
			ChatTextMessage chatMessage;
			LuaObject.checkType<ChatTextMessage>(l, 2, out chatMessage);
			ChatMessage o = chatComponent.m_luaExportHelper.NotifySystemChatMessage(chatMessage);
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

	// Token: 0x060192DF RID: 103135 RVA: 0x00732BC0 File Offset: 0x00730DC0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int CombineSystemSelectHeroMessage(IntPtr l)
	{
		int result;
		try
		{
			ChatComponent chatComponent = (ChatComponent)LuaObject.checkSelf(l);
			int contentId;
			LuaObject.checkType(l, 2, out contentId);
			string sourceContent;
			LuaObject.checkType(l, 3, out sourceContent);
			string s = chatComponent.m_luaExportHelper.CombineSystemSelectHeroMessage(contentId, sourceContent);
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

	// Token: 0x060192E0 RID: 103136 RVA: 0x00732C34 File Offset: 0x00730E34
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int CombineSystemSelectEquipmentMessage(IntPtr l)
	{
		int result;
		try
		{
			ChatComponent chatComponent = (ChatComponent)LuaObject.checkSelf(l);
			int contentId;
			LuaObject.checkType(l, 2, out contentId);
			string sourceContent;
			LuaObject.checkType(l, 3, out sourceContent);
			string s = chatComponent.m_luaExportHelper.CombineSystemSelectEquipmentMessage(contentId, sourceContent);
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

	// Token: 0x060192E1 RID: 103137 RVA: 0x00732CA8 File Offset: 0x00730EA8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int NotifyWorldChatMessage(IntPtr l)
	{
		int result;
		try
		{
			ChatComponent chatComponent = (ChatComponent)LuaObject.checkSelf(l);
			ChatMessage chatMessage;
			LuaObject.checkType<ChatMessage>(l, 2, out chatMessage);
			ChatMessage o = chatComponent.m_luaExportHelper.NotifyWorldChatMessage(chatMessage);
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

	// Token: 0x060192E2 RID: 103138 RVA: 0x00732D10 File Offset: 0x00730F10
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int NotifyTeamChatMessage(IntPtr l)
	{
		int result;
		try
		{
			ChatComponent chatComponent = (ChatComponent)LuaObject.checkSelf(l);
			ChatMessage chatMessage;
			LuaObject.checkType<ChatMessage>(l, 2, out chatMessage);
			ChatMessage o = chatComponent.m_luaExportHelper.NotifyTeamChatMessage(chatMessage);
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

	// Token: 0x060192E3 RID: 103139 RVA: 0x00732D78 File Offset: 0x00730F78
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int NotifyGroupChatMessage(IntPtr l)
	{
		int result;
		try
		{
			ChatComponent chatComponent = (ChatComponent)LuaObject.checkSelf(l);
			ChatMessage chatMessage;
			LuaObject.checkType<ChatMessage>(l, 2, out chatMessage);
			ChatMessage o = chatComponent.m_luaExportHelper.NotifyGroupChatMessage(chatMessage);
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

	// Token: 0x060192E4 RID: 103140 RVA: 0x00732DE0 File Offset: 0x00730FE0
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int NotifyPrivateChatMessage(IntPtr l)
	{
		int result;
		try
		{
			ChatComponent chatComponent = (ChatComponent)LuaObject.checkSelf(l);
			ChatMessage chatMessage;
			LuaObject.checkType<ChatMessage>(l, 2, out chatMessage);
			ChatMessage o = chatComponent.m_luaExportHelper.NotifyPrivateChatMessage(chatMessage);
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

	// Token: 0x060192E5 RID: 103141 RVA: 0x00732E48 File Offset: 0x00731048
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int NotifyGuildChatMessage(IntPtr l)
	{
		int result;
		try
		{
			ChatComponent chatComponent = (ChatComponent)LuaObject.checkSelf(l);
			ChatMessage chatMessage;
			LuaObject.checkType<ChatMessage>(l, 2, out chatMessage);
			ChatMessage o = chatComponent.m_luaExportHelper.NotifyGuildChatMessage(chatMessage);
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

	// Token: 0x060192E6 RID: 103142 RVA: 0x00732EB0 File Offset: 0x007310B0
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int __callBase_GetName(IntPtr l)
	{
		int result;
		try
		{
			ChatComponent chatComponent = (ChatComponent)LuaObject.checkSelf(l);
			string s = chatComponent.m_luaExportHelper.__callBase_GetName();
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

	// Token: 0x060192E7 RID: 103143 RVA: 0x00732F0C File Offset: 0x0073110C
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int __callBase_Init(IntPtr l)
	{
		int result;
		try
		{
			ChatComponent chatComponent = (ChatComponent)LuaObject.checkSelf(l);
			chatComponent.m_luaExportHelper.__callBase_Init();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060192E8 RID: 103144 RVA: 0x00732F60 File Offset: 0x00731160
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_PostInit(IntPtr l)
	{
		int result;
		try
		{
			ChatComponent chatComponent = (ChatComponent)LuaObject.checkSelf(l);
			chatComponent.m_luaExportHelper.__callBase_PostInit();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060192E9 RID: 103145 RVA: 0x00732FB4 File Offset: 0x007311B4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_DeInit(IntPtr l)
	{
		int result;
		try
		{
			ChatComponent chatComponent = (ChatComponent)LuaObject.checkSelf(l);
			chatComponent.m_luaExportHelper.__callBase_DeInit();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060192EA RID: 103146 RVA: 0x00733008 File Offset: 0x00731208
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int __callBase_Tick(IntPtr l)
	{
		int result;
		try
		{
			ChatComponent chatComponent = (ChatComponent)LuaObject.checkSelf(l);
			uint deltaMillisecond;
			LuaObject.checkType(l, 2, out deltaMillisecond);
			chatComponent.m_luaExportHelper.__callBase_Tick(deltaMillisecond);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060192EB RID: 103147 RVA: 0x00733064 File Offset: 0x00731264
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int __callBase_PostDeSerialize(IntPtr l)
	{
		int result;
		try
		{
			ChatComponent chatComponent = (ChatComponent)LuaObject.checkSelf(l);
			chatComponent.m_luaExportHelper.__callBase_PostDeSerialize();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060192EC RID: 103148 RVA: 0x007330B8 File Offset: 0x007312B8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_CanSendChatMessage(IntPtr l)
	{
		int result;
		try
		{
			ChatComponent chatComponent = (ChatComponent)LuaObject.checkSelf(l);
			int channelId;
			LuaObject.checkType(l, 2, out channelId);
			int i = chatComponent.m_luaExportHelper.__callBase_CanSendChatMessage(channelId);
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

	// Token: 0x060192ED RID: 103149 RVA: 0x00733120 File Offset: 0x00731320
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_TruncateChatMessage(IntPtr l)
	{
		int result;
		try
		{
			ChatComponent chatComponent = (ChatComponent)LuaObject.checkSelf(l);
			string content;
			LuaObject.checkType(l, 2, out content);
			string s = chatComponent.m_luaExportHelper.__callBase_TruncateChatMessage(content);
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

	// Token: 0x060192EE RID: 103150 RVA: 0x00733188 File Offset: 0x00731388
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_IsBanned(IntPtr l)
	{
		int result;
		try
		{
			ChatComponent chatComponent = (ChatComponent)LuaObject.checkSelf(l);
			bool b = chatComponent.m_luaExportHelper.__callBase_IsBanned();
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

	// Token: 0x060192EF RID: 103151 RVA: 0x007331E4 File Offset: 0x007313E4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_Ban(IntPtr l)
	{
		int result;
		try
		{
			ChatComponent chatComponent = (ChatComponent)LuaObject.checkSelf(l);
			DateTime bannedTime;
			LuaObject.checkValueType<DateTime>(l, 2, out bannedTime);
			chatComponent.m_luaExportHelper.__callBase_Ban(bannedTime);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060192F0 RID: 103152 RVA: 0x00733240 File Offset: 0x00731440
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_OnBan(IntPtr l)
	{
		int result;
		try
		{
			ChatComponent chatComponent = (ChatComponent)LuaObject.checkSelf(l);
			chatComponent.m_luaExportHelper.__callBase_OnBan();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060192F1 RID: 103153 RVA: 0x00733294 File Offset: 0x00731494
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_OnUnBan(IntPtr l)
	{
		int result;
		try
		{
			ChatComponent chatComponent = (ChatComponent)LuaObject.checkSelf(l);
			chatComponent.m_luaExportHelper.__callBase_OnUnBan();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060192F2 RID: 103154 RVA: 0x007332E8 File Offset: 0x007314E8
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_m_loadChatHistoryMessageCount(IntPtr l)
	{
		int result;
		try
		{
			ChatComponent chatComponent = (ChatComponent)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, chatComponent.m_loadChatHistoryMessageCount);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060192F3 RID: 103155 RVA: 0x0073333C File Offset: 0x0073153C
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_m_loadChatHistoryMessageCount(IntPtr l)
	{
		int result;
		try
		{
			ChatComponent chatComponent = (ChatComponent)LuaObject.checkSelf(l);
			int loadChatHistoryMessageCount;
			LuaObject.checkType(l, 2, out loadChatHistoryMessageCount);
			chatComponent.m_loadChatHistoryMessageCount = loadChatHistoryMessageCount;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060192F4 RID: 103156 RVA: 0x00733394 File Offset: 0x00731594
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_m_worldChatMsgList(IntPtr l)
	{
		int result;
		try
		{
			ChatComponent chatComponent = (ChatComponent)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, chatComponent.m_worldChatMsgList);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060192F5 RID: 103157 RVA: 0x007333E8 File Offset: 0x007315E8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_worldChatMsgList(IntPtr l)
	{
		int result;
		try
		{
			ChatComponent chatComponent = (ChatComponent)LuaObject.checkSelf(l);
			List<ChatComponent.ChatMessageClient> worldChatMsgList;
			LuaObject.checkType<List<ChatComponent.ChatMessageClient>>(l, 2, out worldChatMsgList);
			chatComponent.m_worldChatMsgList = worldChatMsgList;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060192F6 RID: 103158 RVA: 0x00733440 File Offset: 0x00731640
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_m_sysChatMsgList(IntPtr l)
	{
		int result;
		try
		{
			ChatComponent chatComponent = (ChatComponent)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, chatComponent.m_sysChatMsgList);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060192F7 RID: 103159 RVA: 0x00733494 File Offset: 0x00731694
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_sysChatMsgList(IntPtr l)
	{
		int result;
		try
		{
			ChatComponent chatComponent = (ChatComponent)LuaObject.checkSelf(l);
			List<ChatComponent.ChatMessageClient> sysChatMsgList;
			LuaObject.checkType<List<ChatComponent.ChatMessageClient>>(l, 2, out sysChatMsgList);
			chatComponent.m_sysChatMsgList = sysChatMsgList;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060192F8 RID: 103160 RVA: 0x007334EC File Offset: 0x007316EC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_teamChatMsgList(IntPtr l)
	{
		int result;
		try
		{
			ChatComponent chatComponent = (ChatComponent)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, chatComponent.m_teamChatMsgList);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060192F9 RID: 103161 RVA: 0x00733540 File Offset: 0x00731740
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_teamChatMsgList(IntPtr l)
	{
		int result;
		try
		{
			ChatComponent chatComponent = (ChatComponent)LuaObject.checkSelf(l);
			List<ChatComponent.ChatMessageClient> teamChatMsgList;
			LuaObject.checkType<List<ChatComponent.ChatMessageClient>>(l, 2, out teamChatMsgList);
			chatComponent.m_teamChatMsgList = teamChatMsgList;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060192FA RID: 103162 RVA: 0x00733598 File Offset: 0x00731798
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_m_guildChatMsgList(IntPtr l)
	{
		int result;
		try
		{
			ChatComponent chatComponent = (ChatComponent)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, chatComponent.m_guildChatMsgList);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060192FB RID: 103163 RVA: 0x007335EC File Offset: 0x007317EC
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_m_guildChatMsgList(IntPtr l)
	{
		int result;
		try
		{
			ChatComponent chatComponent = (ChatComponent)LuaObject.checkSelf(l);
			List<ChatComponent.ChatMessageClient> guildChatMsgList;
			LuaObject.checkType<List<ChatComponent.ChatMessageClient>>(l, 2, out guildChatMsgList);
			chatComponent.m_guildChatMsgList = guildChatMsgList;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060192FC RID: 103164 RVA: 0x00733644 File Offset: 0x00731844
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_groupChatMsgDict(IntPtr l)
	{
		int result;
		try
		{
			ChatComponent chatComponent = (ChatComponent)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, chatComponent.m_groupChatMsgDict);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060192FD RID: 103165 RVA: 0x00733698 File Offset: 0x00731898
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_groupChatMsgDict(IntPtr l)
	{
		int result;
		try
		{
			ChatComponent chatComponent = (ChatComponent)LuaObject.checkSelf(l);
			Dictionary<string, List<ChatComponent.ChatMessageClient>> groupChatMsgDict;
			LuaObject.checkType<Dictionary<string, List<ChatComponent.ChatMessageClient>>>(l, 2, out groupChatMsgDict);
			chatComponent.m_groupChatMsgDict = groupChatMsgDict;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060192FE RID: 103166 RVA: 0x007336F0 File Offset: 0x007318F0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_recentLinkChatGroupIdList(IntPtr l)
	{
		int result;
		try
		{
			ChatComponent chatComponent = (ChatComponent)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, chatComponent.m_recentLinkChatGroupIdList);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060192FF RID: 103167 RVA: 0x00733744 File Offset: 0x00731944
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_m_recentLinkChatGroupIdList(IntPtr l)
	{
		int result;
		try
		{
			ChatComponent chatComponent = (ChatComponent)LuaObject.checkSelf(l);
			List<string> recentLinkChatGroupIdList;
			LuaObject.checkType<List<string>>(l, 2, out recentLinkChatGroupIdList);
			chatComponent.m_recentLinkChatGroupIdList = recentLinkChatGroupIdList;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06019300 RID: 103168 RVA: 0x0073379C File Offset: 0x0073199C
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_m_privateChatMsgDict(IntPtr l)
	{
		int result;
		try
		{
			ChatComponent chatComponent = (ChatComponent)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, chatComponent.m_privateChatMsgDict);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06019301 RID: 103169 RVA: 0x007337F0 File Offset: 0x007319F0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_privateChatMsgDict(IntPtr l)
	{
		int result;
		try
		{
			ChatComponent chatComponent = (ChatComponent)LuaObject.checkSelf(l);
			Dictionary<string, List<ChatComponent.ChatMessageClient>> privateChatMsgDict;
			LuaObject.checkType<Dictionary<string, List<ChatComponent.ChatMessageClient>>>(l, 2, out privateChatMsgDict);
			chatComponent.m_privateChatMsgDict = privateChatMsgDict;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06019302 RID: 103170 RVA: 0x00733848 File Offset: 0x00731A48
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_recentPrivateChatPlayerIdList(IntPtr l)
	{
		int result;
		try
		{
			ChatComponent chatComponent = (ChatComponent)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, chatComponent.m_recentPrivateChatPlayerIdList);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06019303 RID: 103171 RVA: 0x0073389C File Offset: 0x00731A9C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_recentPrivateChatPlayerIdList(IntPtr l)
	{
		int result;
		try
		{
			ChatComponent chatComponent = (ChatComponent)LuaObject.checkSelf(l);
			List<string> recentPrivateChatPlayerIdList;
			LuaObject.checkType<List<string>>(l, 2, out recentPrivateChatPlayerIdList);
			chatComponent.m_recentPrivateChatPlayerIdList = recentPrivateChatPlayerIdList;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06019304 RID: 103172 RVA: 0x007338F4 File Offset: 0x00731AF4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_recentLinkPlayerInfoDict(IntPtr l)
	{
		int result;
		try
		{
			ChatComponent chatComponent = (ChatComponent)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, chatComponent.m_recentLinkPlayerInfoDict);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06019305 RID: 103173 RVA: 0x00733948 File Offset: 0x00731B48
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_m_recentLinkPlayerInfoDict(IntPtr l)
	{
		int result;
		try
		{
			ChatComponent chatComponent = (ChatComponent)LuaObject.checkSelf(l);
			Dictionary<string, UserSummary> recentLinkPlayerInfoDict;
			LuaObject.checkType<Dictionary<string, UserSummary>>(l, 2, out recentLinkPlayerInfoDict);
			chatComponent.m_recentLinkPlayerInfoDict = recentLinkPlayerInfoDict;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06019306 RID: 103174 RVA: 0x007339A0 File Offset: 0x00731BA0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_privateChatHistoryStateList(IntPtr l)
	{
		int result;
		try
		{
			ChatComponent chatComponent = (ChatComponent)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, chatComponent.m_privateChatHistoryStateList);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06019307 RID: 103175 RVA: 0x007339F4 File Offset: 0x00731BF4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_privateChatHistoryStateList(IntPtr l)
	{
		int result;
		try
		{
			ChatComponent chatComponent = (ChatComponent)LuaObject.checkSelf(l);
			Dictionary<string, bool> privateChatHistoryStateList;
			LuaObject.checkType<Dictionary<string, bool>>(l, 2, out privateChatHistoryStateList);
			chatComponent.m_privateChatHistoryStateList = privateChatHistoryStateList;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06019308 RID: 103176 RVA: 0x00733A4C File Offset: 0x00731C4C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_groupChatHistoryStateList(IntPtr l)
	{
		int result;
		try
		{
			ChatComponent chatComponent = (ChatComponent)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, chatComponent.m_groupChatHistoryStateList);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06019309 RID: 103177 RVA: 0x00733AA0 File Offset: 0x00731CA0
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_m_groupChatHistoryStateList(IntPtr l)
	{
		int result;
		try
		{
			ChatComponent chatComponent = (ChatComponent)LuaObject.checkSelf(l);
			Dictionary<string, bool> groupChatHistoryStateList;
			LuaObject.checkType<Dictionary<string, bool>>(l, 2, out groupChatHistoryStateList);
			chatComponent.m_groupChatHistoryStateList = groupChatHistoryStateList;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601930A RID: 103178 RVA: 0x00733AF8 File Offset: 0x00731CF8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_currGroupChatGroupId(IntPtr l)
	{
		int result;
		try
		{
			ChatComponent chatComponent = (ChatComponent)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, chatComponent.m_currGroupChatGroupId);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601930B RID: 103179 RVA: 0x00733B4C File Offset: 0x00731D4C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_currGroupChatGroupId(IntPtr l)
	{
		int result;
		try
		{
			ChatComponent chatComponent = (ChatComponent)LuaObject.checkSelf(l);
			string currGroupChatGroupId;
			LuaObject.checkType(l, 2, out currGroupChatGroupId);
			chatComponent.m_currGroupChatGroupId = currGroupChatGroupId;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601930C RID: 103180 RVA: 0x00733BA4 File Offset: 0x00731DA4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_currPrivateChatPlayerGameUserId(IntPtr l)
	{
		int result;
		try
		{
			ChatComponent chatComponent = (ChatComponent)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, chatComponent.m_currPrivateChatPlayerGameUserId);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601930D RID: 103181 RVA: 0x00733BF8 File Offset: 0x00731DF8
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_m_currPrivateChatPlayerGameUserId(IntPtr l)
	{
		int result;
		try
		{
			ChatComponent chatComponent = (ChatComponent)LuaObject.checkSelf(l);
			string currPrivateChatPlayerGameUserId;
			LuaObject.checkType(l, 2, out currPrivateChatPlayerGameUserId);
			chatComponent.m_currPrivateChatPlayerGameUserId = currPrivateChatPlayerGameUserId;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601930E RID: 103182 RVA: 0x00733C50 File Offset: 0x00731E50
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_m_chatGroupComponent(IntPtr l)
	{
		int result;
		try
		{
			ChatComponent chatComponent = (ChatComponent)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, chatComponent.m_chatGroupComponent);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601930F RID: 103183 RVA: 0x00733CA4 File Offset: 0x00731EA4
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_m_chatGroupComponent(IntPtr l)
	{
		int result;
		try
		{
			ChatComponent chatComponent = (ChatComponent)LuaObject.checkSelf(l);
			ChatGroupComponent chatGroupComponent;
			LuaObject.checkType<ChatGroupComponent>(l, 2, out chatGroupComponent);
			chatComponent.m_chatGroupComponent = chatGroupComponent;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06019310 RID: 103184 RVA: 0x00733CFC File Offset: 0x00731EFC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_friendComponent(IntPtr l)
	{
		int result;
		try
		{
			ChatComponent chatComponent = (ChatComponent)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, chatComponent.m_friendComponent);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06019311 RID: 103185 RVA: 0x00733D50 File Offset: 0x00731F50
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_friendComponent(IntPtr l)
	{
		int result;
		try
		{
			ChatComponent chatComponent = (ChatComponent)LuaObject.checkSelf(l);
			FriendComponent friendComponent;
			LuaObject.checkType<FriendComponent>(l, 2, out friendComponent);
			chatComponent.m_friendComponent = friendComponent;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06019312 RID: 103186 RVA: 0x00733DA8 File Offset: 0x00731FA8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_guildChatLastReadTime(IntPtr l)
	{
		int result;
		try
		{
			ChatComponent chatComponent = (ChatComponent)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, chatComponent.m_guildChatLastReadTime);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06019313 RID: 103187 RVA: 0x00733E00 File Offset: 0x00732000
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_guildChatLastReadTime(IntPtr l)
	{
		int result;
		try
		{
			ChatComponent chatComponent = (ChatComponent)LuaObject.checkSelf(l);
			DateTime guildChatLastReadTime;
			LuaObject.checkValueType<DateTime>(l, 2, out guildChatLastReadTime);
			chatComponent.m_guildChatLastReadTime = guildChatLastReadTime;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06019314 RID: 103188 RVA: 0x00733E58 File Offset: 0x00732058
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_m_currRoomIndex(IntPtr l)
	{
		int result;
		try
		{
			ChatComponent chatComponent = (ChatComponent)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, chatComponent.m_currRoomIndex);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06019315 RID: 103189 RVA: 0x00733EAC File Offset: 0x007320AC
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_m_currRoomIndex(IntPtr l)
	{
		int result;
		try
		{
			ChatComponent chatComponent = (ChatComponent)LuaObject.checkSelf(l);
			int currRoomIndex;
			LuaObject.checkType(l, 2, out currRoomIndex);
			chatComponent.m_currRoomIndex = currRoomIndex;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06019316 RID: 103190 RVA: 0x00733F04 File Offset: 0x00732104
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_dataDirtyState(IntPtr l)
	{
		int result;
		try
		{
			ChatComponent chatComponent = (ChatComponent)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, chatComponent.m_luaExportHelper.m_dataDirtyState);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06019317 RID: 103191 RVA: 0x00733F5C File Offset: 0x0073215C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_dataDirtyState(IntPtr l)
	{
		int result;
		try
		{
			ChatComponent chatComponent = (ChatComponent)LuaObject.checkSelf(l);
			bool dataDirtyState;
			LuaObject.checkType(l, 2, out dataDirtyState);
			chatComponent.m_luaExportHelper.m_dataDirtyState = dataDirtyState;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06019318 RID: 103192 RVA: 0x00733FB8 File Offset: 0x007321B8
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_m_isLoadHistoryRecordSuccess(IntPtr l)
	{
		int result;
		try
		{
			ChatComponent chatComponent = (ChatComponent)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, chatComponent.m_luaExportHelper.m_isLoadHistoryRecordSuccess);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06019319 RID: 103193 RVA: 0x00734010 File Offset: 0x00732210
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_m_isLoadHistoryRecordSuccess(IntPtr l)
	{
		int result;
		try
		{
			ChatComponent chatComponent = (ChatComponent)LuaObject.checkSelf(l);
			bool isLoadHistoryRecordSuccess;
			LuaObject.checkType(l, 2, out isLoadHistoryRecordSuccess);
			chatComponent.m_luaExportHelper.m_isLoadHistoryRecordSuccess = isLoadHistoryRecordSuccess;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601931A RID: 103194 RVA: 0x0073406C File Offset: 0x0073226C
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_m_chatDirectoryPath(IntPtr l)
	{
		int result;
		try
		{
			ChatComponent chatComponent = (ChatComponent)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, chatComponent.m_luaExportHelper.m_chatDirectoryPath);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601931B RID: 103195 RVA: 0x007340C4 File Offset: 0x007322C4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_chatDirectoryPath(IntPtr l)
	{
		int result;
		try
		{
			ChatComponent chatComponent = (ChatComponent)LuaObject.checkSelf(l);
			string chatDirectoryPath;
			LuaObject.checkType(l, 2, out chatDirectoryPath);
			chatComponent.m_luaExportHelper.m_chatDirectoryPath = chatDirectoryPath;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601931C RID: 103196 RVA: 0x00734120 File Offset: 0x00732320
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_s_chatDataSavePath(IntPtr l)
	{
		int result;
		try
		{
			ChatComponent chatComponent = (ChatComponent)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, chatComponent.m_luaExportHelper.s_chatDataSavePath);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601931D RID: 103197 RVA: 0x00734178 File Offset: 0x00732378
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_s_chatDataSavePath(IntPtr l)
	{
		int result;
		try
		{
			ChatComponent chatComponent = (ChatComponent)LuaObject.checkSelf(l);
			string s_chatDataSavePath;
			LuaObject.checkType(l, 2, out s_chatDataSavePath);
			chatComponent.m_luaExportHelper.s_chatDataSavePath = s_chatDataSavePath;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601931E RID: 103198 RVA: 0x007341D4 File Offset: 0x007323D4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_s_chatRecentLinkManMaxCount(IntPtr l)
	{
		int result;
		try
		{
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, ChatComponent.LuaExportHelper.s_chatRecentLinkManMaxCount);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601931F RID: 103199 RVA: 0x0073421C File Offset: 0x0073241C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_s_chatRecentLinkManMaxCount(IntPtr l)
	{
		int result;
		try
		{
			int s_chatRecentLinkManMaxCount;
			LuaObject.checkType(l, 2, out s_chatRecentLinkManMaxCount);
			ChatComponent.LuaExportHelper.s_chatRecentLinkManMaxCount = s_chatRecentLinkManMaxCount;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06019320 RID: 103200 RVA: 0x00734268 File Offset: 0x00732468
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_s_chatRecentLinkChatGroupCount(IntPtr l)
	{
		int result;
		try
		{
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, ChatComponent.LuaExportHelper.s_chatRecentLinkChatGroupCount);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06019321 RID: 103201 RVA: 0x007342B0 File Offset: 0x007324B0
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_s_chatRecentLinkChatGroupCount(IntPtr l)
	{
		int result;
		try
		{
			int s_chatRecentLinkChatGroupCount;
			LuaObject.checkType(l, 2, out s_chatRecentLinkChatGroupCount);
			ChatComponent.LuaExportHelper.s_chatRecentLinkChatGroupCount = s_chatRecentLinkChatGroupCount;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06019322 RID: 103202 RVA: 0x007342FC File Offset: 0x007324FC
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_s_chatHistoryRecordTimeLimit(IntPtr l)
	{
		int result;
		try
		{
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, ChatComponent.LuaExportHelper.s_chatHistoryRecordTimeLimit);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06019323 RID: 103203 RVA: 0x00734344 File Offset: 0x00732544
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_s_chatHistoryRecordTimeLimit(IntPtr l)
	{
		int result;
		try
		{
			int s_chatHistoryRecordTimeLimit;
			LuaObject.checkType(l, 2, out s_chatHistoryRecordTimeLimit);
			ChatComponent.LuaExportHelper.s_chatHistoryRecordTimeLimit = s_chatHistoryRecordTimeLimit;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06019324 RID: 103204 RVA: 0x00734390 File Offset: 0x00732590
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_s_chatHistoryRecordCountLimit(IntPtr l)
	{
		int result;
		try
		{
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, ChatComponent.LuaExportHelper.s_chatHistoryRecordCountLimit);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06019325 RID: 103205 RVA: 0x007343D8 File Offset: 0x007325D8
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_s_chatHistoryRecordCountLimit(IntPtr l)
	{
		int result;
		try
		{
			int s_chatHistoryRecordCountLimit;
			LuaObject.checkType(l, 2, out s_chatHistoryRecordCountLimit);
			ChatComponent.LuaExportHelper.s_chatHistoryRecordCountLimit = s_chatHistoryRecordCountLimit;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06019326 RID: 103206 RVA: 0x00734424 File Offset: 0x00732624
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_s_chatSaveHistoryRecordCountOnClear(IntPtr l)
	{
		int result;
		try
		{
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, ChatComponent.LuaExportHelper.s_chatSaveHistoryRecordCountOnClear);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06019327 RID: 103207 RVA: 0x0073446C File Offset: 0x0073266C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_s_chatSaveHistoryRecordCountOnClear(IntPtr l)
	{
		int result;
		try
		{
			int s_chatSaveHistoryRecordCountOnClear;
			LuaObject.checkType(l, 2, out s_chatSaveHistoryRecordCountOnClear);
			ChatComponent.LuaExportHelper.s_chatSaveHistoryRecordCountOnClear = s_chatSaveHistoryRecordCountOnClear;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06019328 RID: 103208 RVA: 0x007344B8 File Offset: 0x007326B8
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_RoomIndex(IntPtr l)
	{
		int result;
		try
		{
			ChatComponent chatComponent = (ChatComponent)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, chatComponent.RoomIndex);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06019329 RID: 103209 RVA: 0x0073450C File Offset: 0x0073270C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_DataDirty(IntPtr l)
	{
		int result;
		try
		{
			ChatComponent chatComponent = (ChatComponent)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, chatComponent.DataDirty);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601932A RID: 103210 RVA: 0x00734560 File Offset: 0x00732760
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_DataDirty(IntPtr l)
	{
		int result;
		try
		{
			ChatComponent chatComponent = (ChatComponent)LuaObject.checkSelf(l);
			bool dataDirty;
			LuaObject.checkType(l, 2, out dataDirty);
			chatComponent.DataDirty = dataDirty;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601932B RID: 103211 RVA: 0x007345B8 File Offset: 0x007327B8
	[Preserve]
	public static void reg(IntPtr l)
	{
		LuaObject.getTypeTable(l, "BlackJack.ProjectL.PlayerContext.ChatComponent");
		if (Lua_BlackJack_ProjectL_PlayerContext_ChatComponent.<>f__mg$cache0 == null)
		{
			Lua_BlackJack_ProjectL_PlayerContext_ChatComponent.<>f__mg$cache0 = new LuaCSFunction(Lua_BlackJack_ProjectL_PlayerContext_ChatComponent.Init);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_PlayerContext_ChatComponent.<>f__mg$cache0);
		if (Lua_BlackJack_ProjectL_PlayerContext_ChatComponent.<>f__mg$cache1 == null)
		{
			Lua_BlackJack_ProjectL_PlayerContext_ChatComponent.<>f__mg$cache1 = new LuaCSFunction(Lua_BlackJack_ProjectL_PlayerContext_ChatComponent.PostInit);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_PlayerContext_ChatComponent.<>f__mg$cache1);
		if (Lua_BlackJack_ProjectL_PlayerContext_ChatComponent.<>f__mg$cache2 == null)
		{
			Lua_BlackJack_ProjectL_PlayerContext_ChatComponent.<>f__mg$cache2 = new LuaCSFunction(Lua_BlackJack_ProjectL_PlayerContext_ChatComponent.DeInit);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_PlayerContext_ChatComponent.<>f__mg$cache2);
		if (Lua_BlackJack_ProjectL_PlayerContext_ChatComponent.<>f__mg$cache3 == null)
		{
			Lua_BlackJack_ProjectL_PlayerContext_ChatComponent.<>f__mg$cache3 = new LuaCSFunction(Lua_BlackJack_ProjectL_PlayerContext_ChatComponent.DeSerialize);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_PlayerContext_ChatComponent.<>f__mg$cache3);
		if (Lua_BlackJack_ProjectL_PlayerContext_ChatComponent.<>f__mg$cache4 == null)
		{
			Lua_BlackJack_ProjectL_PlayerContext_ChatComponent.<>f__mg$cache4 = new LuaCSFunction(Lua_BlackJack_ProjectL_PlayerContext_ChatComponent.ReadChatBeforeDate);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_PlayerContext_ChatComponent.<>f__mg$cache4);
		if (Lua_BlackJack_ProjectL_PlayerContext_ChatComponent.<>f__mg$cache5 == null)
		{
			Lua_BlackJack_ProjectL_PlayerContext_ChatComponent.<>f__mg$cache5 = new LuaCSFunction(Lua_BlackJack_ProjectL_PlayerContext_ChatComponent.CanSendChatMessage);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_PlayerContext_ChatComponent.<>f__mg$cache5);
		if (Lua_BlackJack_ProjectL_PlayerContext_ChatComponent.<>f__mg$cache6 == null)
		{
			Lua_BlackJack_ProjectL_PlayerContext_ChatComponent.<>f__mg$cache6 = new LuaCSFunction(Lua_BlackJack_ProjectL_PlayerContext_ChatComponent.NotifyGetPlayerInfo);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_PlayerContext_ChatComponent.<>f__mg$cache6);
		if (Lua_BlackJack_ProjectL_PlayerContext_ChatComponent.<>f__mg$cache7 == null)
		{
			Lua_BlackJack_ProjectL_PlayerContext_ChatComponent.<>f__mg$cache7 = new LuaCSFunction(Lua_BlackJack_ProjectL_PlayerContext_ChatComponent.NotifyChatMessage);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_PlayerContext_ChatComponent.<>f__mg$cache7);
		if (Lua_BlackJack_ProjectL_PlayerContext_ChatComponent.<>f__mg$cache8 == null)
		{
			Lua_BlackJack_ProjectL_PlayerContext_ChatComponent.<>f__mg$cache8 = new LuaCSFunction(Lua_BlackJack_ProjectL_PlayerContext_ChatComponent.CreateASystemTip);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_PlayerContext_ChatComponent.<>f__mg$cache8);
		if (Lua_BlackJack_ProjectL_PlayerContext_ChatComponent.<>f__mg$cache9 == null)
		{
			Lua_BlackJack_ProjectL_PlayerContext_ChatComponent.<>f__mg$cache9 = new LuaCSFunction(Lua_BlackJack_ProjectL_PlayerContext_ChatComponent.IsHasHistoryRecord4Chat);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_PlayerContext_ChatComponent.<>f__mg$cache9);
		if (Lua_BlackJack_ProjectL_PlayerContext_ChatComponent.<>f__mg$cacheA == null)
		{
			Lua_BlackJack_ProjectL_PlayerContext_ChatComponent.<>f__mg$cacheA = new LuaCSFunction(Lua_BlackJack_ProjectL_PlayerContext_ChatComponent.LoadChatHistoryData);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_PlayerContext_ChatComponent.<>f__mg$cacheA);
		if (Lua_BlackJack_ProjectL_PlayerContext_ChatComponent.<>f__mg$cacheB == null)
		{
			Lua_BlackJack_ProjectL_PlayerContext_ChatComponent.<>f__mg$cacheB = new LuaCSFunction(Lua_BlackJack_ProjectL_PlayerContext_ChatComponent.SaveChatHistoryData);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_PlayerContext_ChatComponent.<>f__mg$cacheB);
		if (Lua_BlackJack_ProjectL_PlayerContext_ChatComponent.<>f__mg$cacheC == null)
		{
			Lua_BlackJack_ProjectL_PlayerContext_ChatComponent.<>f__mg$cacheC = new LuaCSFunction(Lua_BlackJack_ProjectL_PlayerContext_ChatComponent.GetSaveFileName);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_PlayerContext_ChatComponent.<>f__mg$cacheC);
		if (Lua_BlackJack_ProjectL_PlayerContext_ChatComponent.<>f__mg$cacheD == null)
		{
			Lua_BlackJack_ProjectL_PlayerContext_ChatComponent.<>f__mg$cacheD = new LuaCSFunction(Lua_BlackJack_ProjectL_PlayerContext_ChatComponent.GetGroupChatTarget);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_PlayerContext_ChatComponent.<>f__mg$cacheD);
		if (Lua_BlackJack_ProjectL_PlayerContext_ChatComponent.<>f__mg$cacheE == null)
		{
			Lua_BlackJack_ProjectL_PlayerContext_ChatComponent.<>f__mg$cacheE = new LuaCSFunction(Lua_BlackJack_ProjectL_PlayerContext_ChatComponent.SetGroupChatTarget);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_PlayerContext_ChatComponent.<>f__mg$cacheE);
		if (Lua_BlackJack_ProjectL_PlayerContext_ChatComponent.<>f__mg$cacheF == null)
		{
			Lua_BlackJack_ProjectL_PlayerContext_ChatComponent.<>f__mg$cacheF = new LuaCSFunction(Lua_BlackJack_ProjectL_PlayerContext_ChatComponent.SetPrivateChatTarget);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_PlayerContext_ChatComponent.<>f__mg$cacheF);
		if (Lua_BlackJack_ProjectL_PlayerContext_ChatComponent.<>f__mg$cache10 == null)
		{
			Lua_BlackJack_ProjectL_PlayerContext_ChatComponent.<>f__mg$cache10 = new LuaCSFunction(Lua_BlackJack_ProjectL_PlayerContext_ChatComponent.GetUserInfo);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_PlayerContext_ChatComponent.<>f__mg$cache10);
		if (Lua_BlackJack_ProjectL_PlayerContext_ChatComponent.<>f__mg$cache11 == null)
		{
			Lua_BlackJack_ProjectL_PlayerContext_ChatComponent.<>f__mg$cache11 = new LuaCSFunction(Lua_BlackJack_ProjectL_PlayerContext_ChatComponent.AddUserInfo);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_PlayerContext_ChatComponent.<>f__mg$cache11);
		if (Lua_BlackJack_ProjectL_PlayerContext_ChatComponent.<>f__mg$cache12 == null)
		{
			Lua_BlackJack_ProjectL_PlayerContext_ChatComponent.<>f__mg$cache12 = new LuaCSFunction(Lua_BlackJack_ProjectL_PlayerContext_ChatComponent.NotifyEnterNewRoom);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_PlayerContext_ChatComponent.<>f__mg$cache12);
		if (Lua_BlackJack_ProjectL_PlayerContext_ChatComponent.<>f__mg$cache13 == null)
		{
			Lua_BlackJack_ProjectL_PlayerContext_ChatComponent.<>f__mg$cache13 = new LuaCSFunction(Lua_BlackJack_ProjectL_PlayerContext_ChatComponent.GetDSVersion);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_PlayerContext_ChatComponent.<>f__mg$cache13);
		if (Lua_BlackJack_ProjectL_PlayerContext_ChatComponent.<>f__mg$cache14 == null)
		{
			Lua_BlackJack_ProjectL_PlayerContext_ChatComponent.<>f__mg$cache14 = new LuaCSFunction(Lua_BlackJack_ProjectL_PlayerContext_ChatComponent.GetChatMessageList);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_PlayerContext_ChatComponent.<>f__mg$cache14);
		if (Lua_BlackJack_ProjectL_PlayerContext_ChatComponent.<>f__mg$cache15 == null)
		{
			Lua_BlackJack_ProjectL_PlayerContext_ChatComponent.<>f__mg$cache15 = new LuaCSFunction(Lua_BlackJack_ProjectL_PlayerContext_ChatComponent.GetUnReadChatMsgCount4PointPlayerOrGroup);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_PlayerContext_ChatComponent.<>f__mg$cache15);
		if (Lua_BlackJack_ProjectL_PlayerContext_ChatComponent.<>f__mg$cache16 == null)
		{
			Lua_BlackJack_ProjectL_PlayerContext_ChatComponent.<>f__mg$cache16 = new LuaCSFunction(Lua_BlackJack_ProjectL_PlayerContext_ChatComponent.GetRecentChatTargetList);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_PlayerContext_ChatComponent.<>f__mg$cache16);
		if (Lua_BlackJack_ProjectL_PlayerContext_ChatComponent.<>f__mg$cache17 == null)
		{
			Lua_BlackJack_ProjectL_PlayerContext_ChatComponent.<>f__mg$cache17 = new LuaCSFunction(Lua_BlackJack_ProjectL_PlayerContext_ChatComponent.GetAllUnReadChatMsgCount);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_PlayerContext_ChatComponent.<>f__mg$cache17);
		if (Lua_BlackJack_ProjectL_PlayerContext_ChatComponent.<>f__mg$cache18 == null)
		{
			Lua_BlackJack_ProjectL_PlayerContext_ChatComponent.<>f__mg$cache18 = new LuaCSFunction(Lua_BlackJack_ProjectL_PlayerContext_ChatComponent.GetGroupUnreadChatMsgCount);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_PlayerContext_ChatComponent.<>f__mg$cache18);
		if (Lua_BlackJack_ProjectL_PlayerContext_ChatComponent.<>f__mg$cache19 == null)
		{
			Lua_BlackJack_ProjectL_PlayerContext_ChatComponent.<>f__mg$cache19 = new LuaCSFunction(Lua_BlackJack_ProjectL_PlayerContext_ChatComponent.GetAssignGroupUnreadChatMsgCount);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_PlayerContext_ChatComponent.<>f__mg$cache19);
		if (Lua_BlackJack_ProjectL_PlayerContext_ChatComponent.<>f__mg$cache1A == null)
		{
			Lua_BlackJack_ProjectL_PlayerContext_ChatComponent.<>f__mg$cache1A = new LuaCSFunction(Lua_BlackJack_ProjectL_PlayerContext_ChatComponent.GetAssignPrivateUnreadChatMsgCount);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_PlayerContext_ChatComponent.<>f__mg$cache1A);
		if (Lua_BlackJack_ProjectL_PlayerContext_ChatComponent.<>f__mg$cache1B == null)
		{
			Lua_BlackJack_ProjectL_PlayerContext_ChatComponent.<>f__mg$cache1B = new LuaCSFunction(Lua_BlackJack_ProjectL_PlayerContext_ChatComponent.GetPrivateUnreadChatMsgCount);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_PlayerContext_ChatComponent.<>f__mg$cache1B);
		if (Lua_BlackJack_ProjectL_PlayerContext_ChatComponent.<>f__mg$cache1C == null)
		{
			Lua_BlackJack_ProjectL_PlayerContext_ChatComponent.<>f__mg$cache1C = new LuaCSFunction(Lua_BlackJack_ProjectL_PlayerContext_ChatComponent.GetGuildUnreadChatMsgCount);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_PlayerContext_ChatComponent.<>f__mg$cache1C);
		if (Lua_BlackJack_ProjectL_PlayerContext_ChatComponent.<>f__mg$cache1D == null)
		{
			Lua_BlackJack_ProjectL_PlayerContext_ChatComponent.<>f__mg$cache1D = new LuaCSFunction(Lua_BlackJack_ProjectL_PlayerContext_ChatComponent.ReadChat);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_PlayerContext_ChatComponent.<>f__mg$cache1D);
		if (Lua_BlackJack_ProjectL_PlayerContext_ChatComponent.<>f__mg$cache1E == null)
		{
			Lua_BlackJack_ProjectL_PlayerContext_ChatComponent.<>f__mg$cache1E = new LuaCSFunction(Lua_BlackJack_ProjectL_PlayerContext_ChatComponent.SetRecentTeamMsgRead);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_PlayerContext_ChatComponent.<>f__mg$cache1E);
		if (Lua_BlackJack_ProjectL_PlayerContext_ChatComponent.<>f__mg$cache1F == null)
		{
			Lua_BlackJack_ProjectL_PlayerContext_ChatComponent.<>f__mg$cache1F = new LuaCSFunction(Lua_BlackJack_ProjectL_PlayerContext_ChatComponent.SetGroupChatMsgReadByID);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_PlayerContext_ChatComponent.<>f__mg$cache1F);
		if (Lua_BlackJack_ProjectL_PlayerContext_ChatComponent.<>f__mg$cache20 == null)
		{
			Lua_BlackJack_ProjectL_PlayerContext_ChatComponent.<>f__mg$cache20 = new LuaCSFunction(Lua_BlackJack_ProjectL_PlayerContext_ChatComponent.SetPrivateChatMsgReadByID);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_PlayerContext_ChatComponent.<>f__mg$cache20);
		if (Lua_BlackJack_ProjectL_PlayerContext_ChatComponent.<>f__mg$cache21 == null)
		{
			Lua_BlackJack_ProjectL_PlayerContext_ChatComponent.<>f__mg$cache21 = new LuaCSFunction(Lua_BlackJack_ProjectL_PlayerContext_ChatComponent.ClearChatMessage4LimitCondition);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_PlayerContext_ChatComponent.<>f__mg$cache21);
		if (Lua_BlackJack_ProjectL_PlayerContext_ChatComponent.<>f__mg$cache22 == null)
		{
			Lua_BlackJack_ProjectL_PlayerContext_ChatComponent.<>f__mg$cache22 = new LuaCSFunction(Lua_BlackJack_ProjectL_PlayerContext_ChatComponent.AddMsgToGroupChatDict);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_PlayerContext_ChatComponent.<>f__mg$cache22);
		if (Lua_BlackJack_ProjectL_PlayerContext_ChatComponent.<>f__mg$cache23 == null)
		{
			Lua_BlackJack_ProjectL_PlayerContext_ChatComponent.<>f__mg$cache23 = new LuaCSFunction(Lua_BlackJack_ProjectL_PlayerContext_ChatComponent.AddMsgToPrivateChatDict);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_PlayerContext_ChatComponent.<>f__mg$cache23);
		if (Lua_BlackJack_ProjectL_PlayerContext_ChatComponent.<>f__mg$cache24 == null)
		{
			Lua_BlackJack_ProjectL_PlayerContext_ChatComponent.<>f__mg$cache24 = new LuaCSFunction(Lua_BlackJack_ProjectL_PlayerContext_ChatComponent.NotifySystemChatMessage);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_PlayerContext_ChatComponent.<>f__mg$cache24);
		if (Lua_BlackJack_ProjectL_PlayerContext_ChatComponent.<>f__mg$cache25 == null)
		{
			Lua_BlackJack_ProjectL_PlayerContext_ChatComponent.<>f__mg$cache25 = new LuaCSFunction(Lua_BlackJack_ProjectL_PlayerContext_ChatComponent.CombineSystemSelectHeroMessage);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_PlayerContext_ChatComponent.<>f__mg$cache25);
		if (Lua_BlackJack_ProjectL_PlayerContext_ChatComponent.<>f__mg$cache26 == null)
		{
			Lua_BlackJack_ProjectL_PlayerContext_ChatComponent.<>f__mg$cache26 = new LuaCSFunction(Lua_BlackJack_ProjectL_PlayerContext_ChatComponent.CombineSystemSelectEquipmentMessage);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_PlayerContext_ChatComponent.<>f__mg$cache26);
		if (Lua_BlackJack_ProjectL_PlayerContext_ChatComponent.<>f__mg$cache27 == null)
		{
			Lua_BlackJack_ProjectL_PlayerContext_ChatComponent.<>f__mg$cache27 = new LuaCSFunction(Lua_BlackJack_ProjectL_PlayerContext_ChatComponent.NotifyWorldChatMessage);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_PlayerContext_ChatComponent.<>f__mg$cache27);
		if (Lua_BlackJack_ProjectL_PlayerContext_ChatComponent.<>f__mg$cache28 == null)
		{
			Lua_BlackJack_ProjectL_PlayerContext_ChatComponent.<>f__mg$cache28 = new LuaCSFunction(Lua_BlackJack_ProjectL_PlayerContext_ChatComponent.NotifyTeamChatMessage);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_PlayerContext_ChatComponent.<>f__mg$cache28);
		if (Lua_BlackJack_ProjectL_PlayerContext_ChatComponent.<>f__mg$cache29 == null)
		{
			Lua_BlackJack_ProjectL_PlayerContext_ChatComponent.<>f__mg$cache29 = new LuaCSFunction(Lua_BlackJack_ProjectL_PlayerContext_ChatComponent.NotifyGroupChatMessage);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_PlayerContext_ChatComponent.<>f__mg$cache29);
		if (Lua_BlackJack_ProjectL_PlayerContext_ChatComponent.<>f__mg$cache2A == null)
		{
			Lua_BlackJack_ProjectL_PlayerContext_ChatComponent.<>f__mg$cache2A = new LuaCSFunction(Lua_BlackJack_ProjectL_PlayerContext_ChatComponent.NotifyPrivateChatMessage);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_PlayerContext_ChatComponent.<>f__mg$cache2A);
		if (Lua_BlackJack_ProjectL_PlayerContext_ChatComponent.<>f__mg$cache2B == null)
		{
			Lua_BlackJack_ProjectL_PlayerContext_ChatComponent.<>f__mg$cache2B = new LuaCSFunction(Lua_BlackJack_ProjectL_PlayerContext_ChatComponent.NotifyGuildChatMessage);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_PlayerContext_ChatComponent.<>f__mg$cache2B);
		if (Lua_BlackJack_ProjectL_PlayerContext_ChatComponent.<>f__mg$cache2C == null)
		{
			Lua_BlackJack_ProjectL_PlayerContext_ChatComponent.<>f__mg$cache2C = new LuaCSFunction(Lua_BlackJack_ProjectL_PlayerContext_ChatComponent.__callBase_GetName);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_PlayerContext_ChatComponent.<>f__mg$cache2C);
		if (Lua_BlackJack_ProjectL_PlayerContext_ChatComponent.<>f__mg$cache2D == null)
		{
			Lua_BlackJack_ProjectL_PlayerContext_ChatComponent.<>f__mg$cache2D = new LuaCSFunction(Lua_BlackJack_ProjectL_PlayerContext_ChatComponent.__callBase_Init);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_PlayerContext_ChatComponent.<>f__mg$cache2D);
		if (Lua_BlackJack_ProjectL_PlayerContext_ChatComponent.<>f__mg$cache2E == null)
		{
			Lua_BlackJack_ProjectL_PlayerContext_ChatComponent.<>f__mg$cache2E = new LuaCSFunction(Lua_BlackJack_ProjectL_PlayerContext_ChatComponent.__callBase_PostInit);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_PlayerContext_ChatComponent.<>f__mg$cache2E);
		if (Lua_BlackJack_ProjectL_PlayerContext_ChatComponent.<>f__mg$cache2F == null)
		{
			Lua_BlackJack_ProjectL_PlayerContext_ChatComponent.<>f__mg$cache2F = new LuaCSFunction(Lua_BlackJack_ProjectL_PlayerContext_ChatComponent.__callBase_DeInit);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_PlayerContext_ChatComponent.<>f__mg$cache2F);
		if (Lua_BlackJack_ProjectL_PlayerContext_ChatComponent.<>f__mg$cache30 == null)
		{
			Lua_BlackJack_ProjectL_PlayerContext_ChatComponent.<>f__mg$cache30 = new LuaCSFunction(Lua_BlackJack_ProjectL_PlayerContext_ChatComponent.__callBase_Tick);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_PlayerContext_ChatComponent.<>f__mg$cache30);
		if (Lua_BlackJack_ProjectL_PlayerContext_ChatComponent.<>f__mg$cache31 == null)
		{
			Lua_BlackJack_ProjectL_PlayerContext_ChatComponent.<>f__mg$cache31 = new LuaCSFunction(Lua_BlackJack_ProjectL_PlayerContext_ChatComponent.__callBase_PostDeSerialize);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_PlayerContext_ChatComponent.<>f__mg$cache31);
		if (Lua_BlackJack_ProjectL_PlayerContext_ChatComponent.<>f__mg$cache32 == null)
		{
			Lua_BlackJack_ProjectL_PlayerContext_ChatComponent.<>f__mg$cache32 = new LuaCSFunction(Lua_BlackJack_ProjectL_PlayerContext_ChatComponent.__callBase_CanSendChatMessage);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_PlayerContext_ChatComponent.<>f__mg$cache32);
		if (Lua_BlackJack_ProjectL_PlayerContext_ChatComponent.<>f__mg$cache33 == null)
		{
			Lua_BlackJack_ProjectL_PlayerContext_ChatComponent.<>f__mg$cache33 = new LuaCSFunction(Lua_BlackJack_ProjectL_PlayerContext_ChatComponent.__callBase_TruncateChatMessage);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_PlayerContext_ChatComponent.<>f__mg$cache33);
		if (Lua_BlackJack_ProjectL_PlayerContext_ChatComponent.<>f__mg$cache34 == null)
		{
			Lua_BlackJack_ProjectL_PlayerContext_ChatComponent.<>f__mg$cache34 = new LuaCSFunction(Lua_BlackJack_ProjectL_PlayerContext_ChatComponent.__callBase_IsBanned);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_PlayerContext_ChatComponent.<>f__mg$cache34);
		if (Lua_BlackJack_ProjectL_PlayerContext_ChatComponent.<>f__mg$cache35 == null)
		{
			Lua_BlackJack_ProjectL_PlayerContext_ChatComponent.<>f__mg$cache35 = new LuaCSFunction(Lua_BlackJack_ProjectL_PlayerContext_ChatComponent.__callBase_Ban);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_PlayerContext_ChatComponent.<>f__mg$cache35);
		if (Lua_BlackJack_ProjectL_PlayerContext_ChatComponent.<>f__mg$cache36 == null)
		{
			Lua_BlackJack_ProjectL_PlayerContext_ChatComponent.<>f__mg$cache36 = new LuaCSFunction(Lua_BlackJack_ProjectL_PlayerContext_ChatComponent.__callBase_OnBan);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_PlayerContext_ChatComponent.<>f__mg$cache36);
		if (Lua_BlackJack_ProjectL_PlayerContext_ChatComponent.<>f__mg$cache37 == null)
		{
			Lua_BlackJack_ProjectL_PlayerContext_ChatComponent.<>f__mg$cache37 = new LuaCSFunction(Lua_BlackJack_ProjectL_PlayerContext_ChatComponent.__callBase_OnUnBan);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_PlayerContext_ChatComponent.<>f__mg$cache37);
		string name = "m_loadChatHistoryMessageCount";
		if (Lua_BlackJack_ProjectL_PlayerContext_ChatComponent.<>f__mg$cache38 == null)
		{
			Lua_BlackJack_ProjectL_PlayerContext_ChatComponent.<>f__mg$cache38 = new LuaCSFunction(Lua_BlackJack_ProjectL_PlayerContext_ChatComponent.get_m_loadChatHistoryMessageCount);
		}
		LuaCSFunction get = Lua_BlackJack_ProjectL_PlayerContext_ChatComponent.<>f__mg$cache38;
		if (Lua_BlackJack_ProjectL_PlayerContext_ChatComponent.<>f__mg$cache39 == null)
		{
			Lua_BlackJack_ProjectL_PlayerContext_ChatComponent.<>f__mg$cache39 = new LuaCSFunction(Lua_BlackJack_ProjectL_PlayerContext_ChatComponent.set_m_loadChatHistoryMessageCount);
		}
		LuaObject.addMember(l, name, get, Lua_BlackJack_ProjectL_PlayerContext_ChatComponent.<>f__mg$cache39, true);
		string name2 = "m_worldChatMsgList";
		if (Lua_BlackJack_ProjectL_PlayerContext_ChatComponent.<>f__mg$cache3A == null)
		{
			Lua_BlackJack_ProjectL_PlayerContext_ChatComponent.<>f__mg$cache3A = new LuaCSFunction(Lua_BlackJack_ProjectL_PlayerContext_ChatComponent.get_m_worldChatMsgList);
		}
		LuaCSFunction get2 = Lua_BlackJack_ProjectL_PlayerContext_ChatComponent.<>f__mg$cache3A;
		if (Lua_BlackJack_ProjectL_PlayerContext_ChatComponent.<>f__mg$cache3B == null)
		{
			Lua_BlackJack_ProjectL_PlayerContext_ChatComponent.<>f__mg$cache3B = new LuaCSFunction(Lua_BlackJack_ProjectL_PlayerContext_ChatComponent.set_m_worldChatMsgList);
		}
		LuaObject.addMember(l, name2, get2, Lua_BlackJack_ProjectL_PlayerContext_ChatComponent.<>f__mg$cache3B, true);
		string name3 = "m_sysChatMsgList";
		if (Lua_BlackJack_ProjectL_PlayerContext_ChatComponent.<>f__mg$cache3C == null)
		{
			Lua_BlackJack_ProjectL_PlayerContext_ChatComponent.<>f__mg$cache3C = new LuaCSFunction(Lua_BlackJack_ProjectL_PlayerContext_ChatComponent.get_m_sysChatMsgList);
		}
		LuaCSFunction get3 = Lua_BlackJack_ProjectL_PlayerContext_ChatComponent.<>f__mg$cache3C;
		if (Lua_BlackJack_ProjectL_PlayerContext_ChatComponent.<>f__mg$cache3D == null)
		{
			Lua_BlackJack_ProjectL_PlayerContext_ChatComponent.<>f__mg$cache3D = new LuaCSFunction(Lua_BlackJack_ProjectL_PlayerContext_ChatComponent.set_m_sysChatMsgList);
		}
		LuaObject.addMember(l, name3, get3, Lua_BlackJack_ProjectL_PlayerContext_ChatComponent.<>f__mg$cache3D, true);
		string name4 = "m_teamChatMsgList";
		if (Lua_BlackJack_ProjectL_PlayerContext_ChatComponent.<>f__mg$cache3E == null)
		{
			Lua_BlackJack_ProjectL_PlayerContext_ChatComponent.<>f__mg$cache3E = new LuaCSFunction(Lua_BlackJack_ProjectL_PlayerContext_ChatComponent.get_m_teamChatMsgList);
		}
		LuaCSFunction get4 = Lua_BlackJack_ProjectL_PlayerContext_ChatComponent.<>f__mg$cache3E;
		if (Lua_BlackJack_ProjectL_PlayerContext_ChatComponent.<>f__mg$cache3F == null)
		{
			Lua_BlackJack_ProjectL_PlayerContext_ChatComponent.<>f__mg$cache3F = new LuaCSFunction(Lua_BlackJack_ProjectL_PlayerContext_ChatComponent.set_m_teamChatMsgList);
		}
		LuaObject.addMember(l, name4, get4, Lua_BlackJack_ProjectL_PlayerContext_ChatComponent.<>f__mg$cache3F, true);
		string name5 = "m_guildChatMsgList";
		if (Lua_BlackJack_ProjectL_PlayerContext_ChatComponent.<>f__mg$cache40 == null)
		{
			Lua_BlackJack_ProjectL_PlayerContext_ChatComponent.<>f__mg$cache40 = new LuaCSFunction(Lua_BlackJack_ProjectL_PlayerContext_ChatComponent.get_m_guildChatMsgList);
		}
		LuaCSFunction get5 = Lua_BlackJack_ProjectL_PlayerContext_ChatComponent.<>f__mg$cache40;
		if (Lua_BlackJack_ProjectL_PlayerContext_ChatComponent.<>f__mg$cache41 == null)
		{
			Lua_BlackJack_ProjectL_PlayerContext_ChatComponent.<>f__mg$cache41 = new LuaCSFunction(Lua_BlackJack_ProjectL_PlayerContext_ChatComponent.set_m_guildChatMsgList);
		}
		LuaObject.addMember(l, name5, get5, Lua_BlackJack_ProjectL_PlayerContext_ChatComponent.<>f__mg$cache41, true);
		string name6 = "m_groupChatMsgDict";
		if (Lua_BlackJack_ProjectL_PlayerContext_ChatComponent.<>f__mg$cache42 == null)
		{
			Lua_BlackJack_ProjectL_PlayerContext_ChatComponent.<>f__mg$cache42 = new LuaCSFunction(Lua_BlackJack_ProjectL_PlayerContext_ChatComponent.get_m_groupChatMsgDict);
		}
		LuaCSFunction get6 = Lua_BlackJack_ProjectL_PlayerContext_ChatComponent.<>f__mg$cache42;
		if (Lua_BlackJack_ProjectL_PlayerContext_ChatComponent.<>f__mg$cache43 == null)
		{
			Lua_BlackJack_ProjectL_PlayerContext_ChatComponent.<>f__mg$cache43 = new LuaCSFunction(Lua_BlackJack_ProjectL_PlayerContext_ChatComponent.set_m_groupChatMsgDict);
		}
		LuaObject.addMember(l, name6, get6, Lua_BlackJack_ProjectL_PlayerContext_ChatComponent.<>f__mg$cache43, true);
		string name7 = "m_recentLinkChatGroupIdList";
		if (Lua_BlackJack_ProjectL_PlayerContext_ChatComponent.<>f__mg$cache44 == null)
		{
			Lua_BlackJack_ProjectL_PlayerContext_ChatComponent.<>f__mg$cache44 = new LuaCSFunction(Lua_BlackJack_ProjectL_PlayerContext_ChatComponent.get_m_recentLinkChatGroupIdList);
		}
		LuaCSFunction get7 = Lua_BlackJack_ProjectL_PlayerContext_ChatComponent.<>f__mg$cache44;
		if (Lua_BlackJack_ProjectL_PlayerContext_ChatComponent.<>f__mg$cache45 == null)
		{
			Lua_BlackJack_ProjectL_PlayerContext_ChatComponent.<>f__mg$cache45 = new LuaCSFunction(Lua_BlackJack_ProjectL_PlayerContext_ChatComponent.set_m_recentLinkChatGroupIdList);
		}
		LuaObject.addMember(l, name7, get7, Lua_BlackJack_ProjectL_PlayerContext_ChatComponent.<>f__mg$cache45, true);
		string name8 = "m_privateChatMsgDict";
		if (Lua_BlackJack_ProjectL_PlayerContext_ChatComponent.<>f__mg$cache46 == null)
		{
			Lua_BlackJack_ProjectL_PlayerContext_ChatComponent.<>f__mg$cache46 = new LuaCSFunction(Lua_BlackJack_ProjectL_PlayerContext_ChatComponent.get_m_privateChatMsgDict);
		}
		LuaCSFunction get8 = Lua_BlackJack_ProjectL_PlayerContext_ChatComponent.<>f__mg$cache46;
		if (Lua_BlackJack_ProjectL_PlayerContext_ChatComponent.<>f__mg$cache47 == null)
		{
			Lua_BlackJack_ProjectL_PlayerContext_ChatComponent.<>f__mg$cache47 = new LuaCSFunction(Lua_BlackJack_ProjectL_PlayerContext_ChatComponent.set_m_privateChatMsgDict);
		}
		LuaObject.addMember(l, name8, get8, Lua_BlackJack_ProjectL_PlayerContext_ChatComponent.<>f__mg$cache47, true);
		string name9 = "m_recentPrivateChatPlayerIdList";
		if (Lua_BlackJack_ProjectL_PlayerContext_ChatComponent.<>f__mg$cache48 == null)
		{
			Lua_BlackJack_ProjectL_PlayerContext_ChatComponent.<>f__mg$cache48 = new LuaCSFunction(Lua_BlackJack_ProjectL_PlayerContext_ChatComponent.get_m_recentPrivateChatPlayerIdList);
		}
		LuaCSFunction get9 = Lua_BlackJack_ProjectL_PlayerContext_ChatComponent.<>f__mg$cache48;
		if (Lua_BlackJack_ProjectL_PlayerContext_ChatComponent.<>f__mg$cache49 == null)
		{
			Lua_BlackJack_ProjectL_PlayerContext_ChatComponent.<>f__mg$cache49 = new LuaCSFunction(Lua_BlackJack_ProjectL_PlayerContext_ChatComponent.set_m_recentPrivateChatPlayerIdList);
		}
		LuaObject.addMember(l, name9, get9, Lua_BlackJack_ProjectL_PlayerContext_ChatComponent.<>f__mg$cache49, true);
		string name10 = "m_recentLinkPlayerInfoDict";
		if (Lua_BlackJack_ProjectL_PlayerContext_ChatComponent.<>f__mg$cache4A == null)
		{
			Lua_BlackJack_ProjectL_PlayerContext_ChatComponent.<>f__mg$cache4A = new LuaCSFunction(Lua_BlackJack_ProjectL_PlayerContext_ChatComponent.get_m_recentLinkPlayerInfoDict);
		}
		LuaCSFunction get10 = Lua_BlackJack_ProjectL_PlayerContext_ChatComponent.<>f__mg$cache4A;
		if (Lua_BlackJack_ProjectL_PlayerContext_ChatComponent.<>f__mg$cache4B == null)
		{
			Lua_BlackJack_ProjectL_PlayerContext_ChatComponent.<>f__mg$cache4B = new LuaCSFunction(Lua_BlackJack_ProjectL_PlayerContext_ChatComponent.set_m_recentLinkPlayerInfoDict);
		}
		LuaObject.addMember(l, name10, get10, Lua_BlackJack_ProjectL_PlayerContext_ChatComponent.<>f__mg$cache4B, true);
		string name11 = "m_privateChatHistoryStateList";
		if (Lua_BlackJack_ProjectL_PlayerContext_ChatComponent.<>f__mg$cache4C == null)
		{
			Lua_BlackJack_ProjectL_PlayerContext_ChatComponent.<>f__mg$cache4C = new LuaCSFunction(Lua_BlackJack_ProjectL_PlayerContext_ChatComponent.get_m_privateChatHistoryStateList);
		}
		LuaCSFunction get11 = Lua_BlackJack_ProjectL_PlayerContext_ChatComponent.<>f__mg$cache4C;
		if (Lua_BlackJack_ProjectL_PlayerContext_ChatComponent.<>f__mg$cache4D == null)
		{
			Lua_BlackJack_ProjectL_PlayerContext_ChatComponent.<>f__mg$cache4D = new LuaCSFunction(Lua_BlackJack_ProjectL_PlayerContext_ChatComponent.set_m_privateChatHistoryStateList);
		}
		LuaObject.addMember(l, name11, get11, Lua_BlackJack_ProjectL_PlayerContext_ChatComponent.<>f__mg$cache4D, true);
		string name12 = "m_groupChatHistoryStateList";
		if (Lua_BlackJack_ProjectL_PlayerContext_ChatComponent.<>f__mg$cache4E == null)
		{
			Lua_BlackJack_ProjectL_PlayerContext_ChatComponent.<>f__mg$cache4E = new LuaCSFunction(Lua_BlackJack_ProjectL_PlayerContext_ChatComponent.get_m_groupChatHistoryStateList);
		}
		LuaCSFunction get12 = Lua_BlackJack_ProjectL_PlayerContext_ChatComponent.<>f__mg$cache4E;
		if (Lua_BlackJack_ProjectL_PlayerContext_ChatComponent.<>f__mg$cache4F == null)
		{
			Lua_BlackJack_ProjectL_PlayerContext_ChatComponent.<>f__mg$cache4F = new LuaCSFunction(Lua_BlackJack_ProjectL_PlayerContext_ChatComponent.set_m_groupChatHistoryStateList);
		}
		LuaObject.addMember(l, name12, get12, Lua_BlackJack_ProjectL_PlayerContext_ChatComponent.<>f__mg$cache4F, true);
		string name13 = "m_currGroupChatGroupId";
		if (Lua_BlackJack_ProjectL_PlayerContext_ChatComponent.<>f__mg$cache50 == null)
		{
			Lua_BlackJack_ProjectL_PlayerContext_ChatComponent.<>f__mg$cache50 = new LuaCSFunction(Lua_BlackJack_ProjectL_PlayerContext_ChatComponent.get_m_currGroupChatGroupId);
		}
		LuaCSFunction get13 = Lua_BlackJack_ProjectL_PlayerContext_ChatComponent.<>f__mg$cache50;
		if (Lua_BlackJack_ProjectL_PlayerContext_ChatComponent.<>f__mg$cache51 == null)
		{
			Lua_BlackJack_ProjectL_PlayerContext_ChatComponent.<>f__mg$cache51 = new LuaCSFunction(Lua_BlackJack_ProjectL_PlayerContext_ChatComponent.set_m_currGroupChatGroupId);
		}
		LuaObject.addMember(l, name13, get13, Lua_BlackJack_ProjectL_PlayerContext_ChatComponent.<>f__mg$cache51, true);
		string name14 = "m_currPrivateChatPlayerGameUserId";
		if (Lua_BlackJack_ProjectL_PlayerContext_ChatComponent.<>f__mg$cache52 == null)
		{
			Lua_BlackJack_ProjectL_PlayerContext_ChatComponent.<>f__mg$cache52 = new LuaCSFunction(Lua_BlackJack_ProjectL_PlayerContext_ChatComponent.get_m_currPrivateChatPlayerGameUserId);
		}
		LuaCSFunction get14 = Lua_BlackJack_ProjectL_PlayerContext_ChatComponent.<>f__mg$cache52;
		if (Lua_BlackJack_ProjectL_PlayerContext_ChatComponent.<>f__mg$cache53 == null)
		{
			Lua_BlackJack_ProjectL_PlayerContext_ChatComponent.<>f__mg$cache53 = new LuaCSFunction(Lua_BlackJack_ProjectL_PlayerContext_ChatComponent.set_m_currPrivateChatPlayerGameUserId);
		}
		LuaObject.addMember(l, name14, get14, Lua_BlackJack_ProjectL_PlayerContext_ChatComponent.<>f__mg$cache53, true);
		string name15 = "m_chatGroupComponent";
		if (Lua_BlackJack_ProjectL_PlayerContext_ChatComponent.<>f__mg$cache54 == null)
		{
			Lua_BlackJack_ProjectL_PlayerContext_ChatComponent.<>f__mg$cache54 = new LuaCSFunction(Lua_BlackJack_ProjectL_PlayerContext_ChatComponent.get_m_chatGroupComponent);
		}
		LuaCSFunction get15 = Lua_BlackJack_ProjectL_PlayerContext_ChatComponent.<>f__mg$cache54;
		if (Lua_BlackJack_ProjectL_PlayerContext_ChatComponent.<>f__mg$cache55 == null)
		{
			Lua_BlackJack_ProjectL_PlayerContext_ChatComponent.<>f__mg$cache55 = new LuaCSFunction(Lua_BlackJack_ProjectL_PlayerContext_ChatComponent.set_m_chatGroupComponent);
		}
		LuaObject.addMember(l, name15, get15, Lua_BlackJack_ProjectL_PlayerContext_ChatComponent.<>f__mg$cache55, true);
		string name16 = "m_friendComponent";
		if (Lua_BlackJack_ProjectL_PlayerContext_ChatComponent.<>f__mg$cache56 == null)
		{
			Lua_BlackJack_ProjectL_PlayerContext_ChatComponent.<>f__mg$cache56 = new LuaCSFunction(Lua_BlackJack_ProjectL_PlayerContext_ChatComponent.get_m_friendComponent);
		}
		LuaCSFunction get16 = Lua_BlackJack_ProjectL_PlayerContext_ChatComponent.<>f__mg$cache56;
		if (Lua_BlackJack_ProjectL_PlayerContext_ChatComponent.<>f__mg$cache57 == null)
		{
			Lua_BlackJack_ProjectL_PlayerContext_ChatComponent.<>f__mg$cache57 = new LuaCSFunction(Lua_BlackJack_ProjectL_PlayerContext_ChatComponent.set_m_friendComponent);
		}
		LuaObject.addMember(l, name16, get16, Lua_BlackJack_ProjectL_PlayerContext_ChatComponent.<>f__mg$cache57, true);
		string name17 = "m_guildChatLastReadTime";
		if (Lua_BlackJack_ProjectL_PlayerContext_ChatComponent.<>f__mg$cache58 == null)
		{
			Lua_BlackJack_ProjectL_PlayerContext_ChatComponent.<>f__mg$cache58 = new LuaCSFunction(Lua_BlackJack_ProjectL_PlayerContext_ChatComponent.get_m_guildChatLastReadTime);
		}
		LuaCSFunction get17 = Lua_BlackJack_ProjectL_PlayerContext_ChatComponent.<>f__mg$cache58;
		if (Lua_BlackJack_ProjectL_PlayerContext_ChatComponent.<>f__mg$cache59 == null)
		{
			Lua_BlackJack_ProjectL_PlayerContext_ChatComponent.<>f__mg$cache59 = new LuaCSFunction(Lua_BlackJack_ProjectL_PlayerContext_ChatComponent.set_m_guildChatLastReadTime);
		}
		LuaObject.addMember(l, name17, get17, Lua_BlackJack_ProjectL_PlayerContext_ChatComponent.<>f__mg$cache59, true);
		string name18 = "m_currRoomIndex";
		if (Lua_BlackJack_ProjectL_PlayerContext_ChatComponent.<>f__mg$cache5A == null)
		{
			Lua_BlackJack_ProjectL_PlayerContext_ChatComponent.<>f__mg$cache5A = new LuaCSFunction(Lua_BlackJack_ProjectL_PlayerContext_ChatComponent.get_m_currRoomIndex);
		}
		LuaCSFunction get18 = Lua_BlackJack_ProjectL_PlayerContext_ChatComponent.<>f__mg$cache5A;
		if (Lua_BlackJack_ProjectL_PlayerContext_ChatComponent.<>f__mg$cache5B == null)
		{
			Lua_BlackJack_ProjectL_PlayerContext_ChatComponent.<>f__mg$cache5B = new LuaCSFunction(Lua_BlackJack_ProjectL_PlayerContext_ChatComponent.set_m_currRoomIndex);
		}
		LuaObject.addMember(l, name18, get18, Lua_BlackJack_ProjectL_PlayerContext_ChatComponent.<>f__mg$cache5B, true);
		string name19 = "m_dataDirtyState";
		if (Lua_BlackJack_ProjectL_PlayerContext_ChatComponent.<>f__mg$cache5C == null)
		{
			Lua_BlackJack_ProjectL_PlayerContext_ChatComponent.<>f__mg$cache5C = new LuaCSFunction(Lua_BlackJack_ProjectL_PlayerContext_ChatComponent.get_m_dataDirtyState);
		}
		LuaCSFunction get19 = Lua_BlackJack_ProjectL_PlayerContext_ChatComponent.<>f__mg$cache5C;
		if (Lua_BlackJack_ProjectL_PlayerContext_ChatComponent.<>f__mg$cache5D == null)
		{
			Lua_BlackJack_ProjectL_PlayerContext_ChatComponent.<>f__mg$cache5D = new LuaCSFunction(Lua_BlackJack_ProjectL_PlayerContext_ChatComponent.set_m_dataDirtyState);
		}
		LuaObject.addMember(l, name19, get19, Lua_BlackJack_ProjectL_PlayerContext_ChatComponent.<>f__mg$cache5D, true);
		string name20 = "m_isLoadHistoryRecordSuccess";
		if (Lua_BlackJack_ProjectL_PlayerContext_ChatComponent.<>f__mg$cache5E == null)
		{
			Lua_BlackJack_ProjectL_PlayerContext_ChatComponent.<>f__mg$cache5E = new LuaCSFunction(Lua_BlackJack_ProjectL_PlayerContext_ChatComponent.get_m_isLoadHistoryRecordSuccess);
		}
		LuaCSFunction get20 = Lua_BlackJack_ProjectL_PlayerContext_ChatComponent.<>f__mg$cache5E;
		if (Lua_BlackJack_ProjectL_PlayerContext_ChatComponent.<>f__mg$cache5F == null)
		{
			Lua_BlackJack_ProjectL_PlayerContext_ChatComponent.<>f__mg$cache5F = new LuaCSFunction(Lua_BlackJack_ProjectL_PlayerContext_ChatComponent.set_m_isLoadHistoryRecordSuccess);
		}
		LuaObject.addMember(l, name20, get20, Lua_BlackJack_ProjectL_PlayerContext_ChatComponent.<>f__mg$cache5F, true);
		string name21 = "m_chatDirectoryPath";
		if (Lua_BlackJack_ProjectL_PlayerContext_ChatComponent.<>f__mg$cache60 == null)
		{
			Lua_BlackJack_ProjectL_PlayerContext_ChatComponent.<>f__mg$cache60 = new LuaCSFunction(Lua_BlackJack_ProjectL_PlayerContext_ChatComponent.get_m_chatDirectoryPath);
		}
		LuaCSFunction get21 = Lua_BlackJack_ProjectL_PlayerContext_ChatComponent.<>f__mg$cache60;
		if (Lua_BlackJack_ProjectL_PlayerContext_ChatComponent.<>f__mg$cache61 == null)
		{
			Lua_BlackJack_ProjectL_PlayerContext_ChatComponent.<>f__mg$cache61 = new LuaCSFunction(Lua_BlackJack_ProjectL_PlayerContext_ChatComponent.set_m_chatDirectoryPath);
		}
		LuaObject.addMember(l, name21, get21, Lua_BlackJack_ProjectL_PlayerContext_ChatComponent.<>f__mg$cache61, true);
		string name22 = "s_chatDataSavePath";
		if (Lua_BlackJack_ProjectL_PlayerContext_ChatComponent.<>f__mg$cache62 == null)
		{
			Lua_BlackJack_ProjectL_PlayerContext_ChatComponent.<>f__mg$cache62 = new LuaCSFunction(Lua_BlackJack_ProjectL_PlayerContext_ChatComponent.get_s_chatDataSavePath);
		}
		LuaCSFunction get22 = Lua_BlackJack_ProjectL_PlayerContext_ChatComponent.<>f__mg$cache62;
		if (Lua_BlackJack_ProjectL_PlayerContext_ChatComponent.<>f__mg$cache63 == null)
		{
			Lua_BlackJack_ProjectL_PlayerContext_ChatComponent.<>f__mg$cache63 = new LuaCSFunction(Lua_BlackJack_ProjectL_PlayerContext_ChatComponent.set_s_chatDataSavePath);
		}
		LuaObject.addMember(l, name22, get22, Lua_BlackJack_ProjectL_PlayerContext_ChatComponent.<>f__mg$cache63, true);
		string name23 = "s_chatRecentLinkManMaxCount";
		if (Lua_BlackJack_ProjectL_PlayerContext_ChatComponent.<>f__mg$cache64 == null)
		{
			Lua_BlackJack_ProjectL_PlayerContext_ChatComponent.<>f__mg$cache64 = new LuaCSFunction(Lua_BlackJack_ProjectL_PlayerContext_ChatComponent.get_s_chatRecentLinkManMaxCount);
		}
		LuaCSFunction get23 = Lua_BlackJack_ProjectL_PlayerContext_ChatComponent.<>f__mg$cache64;
		if (Lua_BlackJack_ProjectL_PlayerContext_ChatComponent.<>f__mg$cache65 == null)
		{
			Lua_BlackJack_ProjectL_PlayerContext_ChatComponent.<>f__mg$cache65 = new LuaCSFunction(Lua_BlackJack_ProjectL_PlayerContext_ChatComponent.set_s_chatRecentLinkManMaxCount);
		}
		LuaObject.addMember(l, name23, get23, Lua_BlackJack_ProjectL_PlayerContext_ChatComponent.<>f__mg$cache65, false);
		string name24 = "s_chatRecentLinkChatGroupCount";
		if (Lua_BlackJack_ProjectL_PlayerContext_ChatComponent.<>f__mg$cache66 == null)
		{
			Lua_BlackJack_ProjectL_PlayerContext_ChatComponent.<>f__mg$cache66 = new LuaCSFunction(Lua_BlackJack_ProjectL_PlayerContext_ChatComponent.get_s_chatRecentLinkChatGroupCount);
		}
		LuaCSFunction get24 = Lua_BlackJack_ProjectL_PlayerContext_ChatComponent.<>f__mg$cache66;
		if (Lua_BlackJack_ProjectL_PlayerContext_ChatComponent.<>f__mg$cache67 == null)
		{
			Lua_BlackJack_ProjectL_PlayerContext_ChatComponent.<>f__mg$cache67 = new LuaCSFunction(Lua_BlackJack_ProjectL_PlayerContext_ChatComponent.set_s_chatRecentLinkChatGroupCount);
		}
		LuaObject.addMember(l, name24, get24, Lua_BlackJack_ProjectL_PlayerContext_ChatComponent.<>f__mg$cache67, false);
		string name25 = "s_chatHistoryRecordTimeLimit";
		if (Lua_BlackJack_ProjectL_PlayerContext_ChatComponent.<>f__mg$cache68 == null)
		{
			Lua_BlackJack_ProjectL_PlayerContext_ChatComponent.<>f__mg$cache68 = new LuaCSFunction(Lua_BlackJack_ProjectL_PlayerContext_ChatComponent.get_s_chatHistoryRecordTimeLimit);
		}
		LuaCSFunction get25 = Lua_BlackJack_ProjectL_PlayerContext_ChatComponent.<>f__mg$cache68;
		if (Lua_BlackJack_ProjectL_PlayerContext_ChatComponent.<>f__mg$cache69 == null)
		{
			Lua_BlackJack_ProjectL_PlayerContext_ChatComponent.<>f__mg$cache69 = new LuaCSFunction(Lua_BlackJack_ProjectL_PlayerContext_ChatComponent.set_s_chatHistoryRecordTimeLimit);
		}
		LuaObject.addMember(l, name25, get25, Lua_BlackJack_ProjectL_PlayerContext_ChatComponent.<>f__mg$cache69, false);
		string name26 = "s_chatHistoryRecordCountLimit";
		if (Lua_BlackJack_ProjectL_PlayerContext_ChatComponent.<>f__mg$cache6A == null)
		{
			Lua_BlackJack_ProjectL_PlayerContext_ChatComponent.<>f__mg$cache6A = new LuaCSFunction(Lua_BlackJack_ProjectL_PlayerContext_ChatComponent.get_s_chatHistoryRecordCountLimit);
		}
		LuaCSFunction get26 = Lua_BlackJack_ProjectL_PlayerContext_ChatComponent.<>f__mg$cache6A;
		if (Lua_BlackJack_ProjectL_PlayerContext_ChatComponent.<>f__mg$cache6B == null)
		{
			Lua_BlackJack_ProjectL_PlayerContext_ChatComponent.<>f__mg$cache6B = new LuaCSFunction(Lua_BlackJack_ProjectL_PlayerContext_ChatComponent.set_s_chatHistoryRecordCountLimit);
		}
		LuaObject.addMember(l, name26, get26, Lua_BlackJack_ProjectL_PlayerContext_ChatComponent.<>f__mg$cache6B, false);
		string name27 = "s_chatSaveHistoryRecordCountOnClear";
		if (Lua_BlackJack_ProjectL_PlayerContext_ChatComponent.<>f__mg$cache6C == null)
		{
			Lua_BlackJack_ProjectL_PlayerContext_ChatComponent.<>f__mg$cache6C = new LuaCSFunction(Lua_BlackJack_ProjectL_PlayerContext_ChatComponent.get_s_chatSaveHistoryRecordCountOnClear);
		}
		LuaCSFunction get27 = Lua_BlackJack_ProjectL_PlayerContext_ChatComponent.<>f__mg$cache6C;
		if (Lua_BlackJack_ProjectL_PlayerContext_ChatComponent.<>f__mg$cache6D == null)
		{
			Lua_BlackJack_ProjectL_PlayerContext_ChatComponent.<>f__mg$cache6D = new LuaCSFunction(Lua_BlackJack_ProjectL_PlayerContext_ChatComponent.set_s_chatSaveHistoryRecordCountOnClear);
		}
		LuaObject.addMember(l, name27, get27, Lua_BlackJack_ProjectL_PlayerContext_ChatComponent.<>f__mg$cache6D, false);
		string name28 = "RoomIndex";
		if (Lua_BlackJack_ProjectL_PlayerContext_ChatComponent.<>f__mg$cache6E == null)
		{
			Lua_BlackJack_ProjectL_PlayerContext_ChatComponent.<>f__mg$cache6E = new LuaCSFunction(Lua_BlackJack_ProjectL_PlayerContext_ChatComponent.get_RoomIndex);
		}
		LuaObject.addMember(l, name28, Lua_BlackJack_ProjectL_PlayerContext_ChatComponent.<>f__mg$cache6E, null, true);
		string name29 = "DataDirty";
		if (Lua_BlackJack_ProjectL_PlayerContext_ChatComponent.<>f__mg$cache6F == null)
		{
			Lua_BlackJack_ProjectL_PlayerContext_ChatComponent.<>f__mg$cache6F = new LuaCSFunction(Lua_BlackJack_ProjectL_PlayerContext_ChatComponent.get_DataDirty);
		}
		LuaCSFunction get28 = Lua_BlackJack_ProjectL_PlayerContext_ChatComponent.<>f__mg$cache6F;
		if (Lua_BlackJack_ProjectL_PlayerContext_ChatComponent.<>f__mg$cache70 == null)
		{
			Lua_BlackJack_ProjectL_PlayerContext_ChatComponent.<>f__mg$cache70 = new LuaCSFunction(Lua_BlackJack_ProjectL_PlayerContext_ChatComponent.set_DataDirty);
		}
		LuaObject.addMember(l, name29, get28, Lua_BlackJack_ProjectL_PlayerContext_ChatComponent.<>f__mg$cache70, true);
		if (Lua_BlackJack_ProjectL_PlayerContext_ChatComponent.<>f__mg$cache71 == null)
		{
			Lua_BlackJack_ProjectL_PlayerContext_ChatComponent.<>f__mg$cache71 = new LuaCSFunction(Lua_BlackJack_ProjectL_PlayerContext_ChatComponent.constructor);
		}
		LuaObject.createTypeMetatable(l, Lua_BlackJack_ProjectL_PlayerContext_ChatComponent.<>f__mg$cache71, typeof(ChatComponent), typeof(ChatComponentCommon));
	}

	// Token: 0x0400F72F RID: 63279
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache0;

	// Token: 0x0400F730 RID: 63280
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1;

	// Token: 0x0400F731 RID: 63281
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2;

	// Token: 0x0400F732 RID: 63282
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3;

	// Token: 0x0400F733 RID: 63283
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache4;

	// Token: 0x0400F734 RID: 63284
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache5;

	// Token: 0x0400F735 RID: 63285
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache6;

	// Token: 0x0400F736 RID: 63286
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache7;

	// Token: 0x0400F737 RID: 63287
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache8;

	// Token: 0x0400F738 RID: 63288
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache9;

	// Token: 0x0400F739 RID: 63289
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheA;

	// Token: 0x0400F73A RID: 63290
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheB;

	// Token: 0x0400F73B RID: 63291
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheC;

	// Token: 0x0400F73C RID: 63292
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheD;

	// Token: 0x0400F73D RID: 63293
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheE;

	// Token: 0x0400F73E RID: 63294
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheF;

	// Token: 0x0400F73F RID: 63295
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache10;

	// Token: 0x0400F740 RID: 63296
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache11;

	// Token: 0x0400F741 RID: 63297
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache12;

	// Token: 0x0400F742 RID: 63298
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache13;

	// Token: 0x0400F743 RID: 63299
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache14;

	// Token: 0x0400F744 RID: 63300
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache15;

	// Token: 0x0400F745 RID: 63301
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache16;

	// Token: 0x0400F746 RID: 63302
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache17;

	// Token: 0x0400F747 RID: 63303
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache18;

	// Token: 0x0400F748 RID: 63304
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache19;

	// Token: 0x0400F749 RID: 63305
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1A;

	// Token: 0x0400F74A RID: 63306
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1B;

	// Token: 0x0400F74B RID: 63307
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1C;

	// Token: 0x0400F74C RID: 63308
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1D;

	// Token: 0x0400F74D RID: 63309
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1E;

	// Token: 0x0400F74E RID: 63310
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1F;

	// Token: 0x0400F74F RID: 63311
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache20;

	// Token: 0x0400F750 RID: 63312
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache21;

	// Token: 0x0400F751 RID: 63313
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache22;

	// Token: 0x0400F752 RID: 63314
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache23;

	// Token: 0x0400F753 RID: 63315
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache24;

	// Token: 0x0400F754 RID: 63316
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache25;

	// Token: 0x0400F755 RID: 63317
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache26;

	// Token: 0x0400F756 RID: 63318
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache27;

	// Token: 0x0400F757 RID: 63319
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache28;

	// Token: 0x0400F758 RID: 63320
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache29;

	// Token: 0x0400F759 RID: 63321
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2A;

	// Token: 0x0400F75A RID: 63322
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2B;

	// Token: 0x0400F75B RID: 63323
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2C;

	// Token: 0x0400F75C RID: 63324
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2D;

	// Token: 0x0400F75D RID: 63325
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2E;

	// Token: 0x0400F75E RID: 63326
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2F;

	// Token: 0x0400F75F RID: 63327
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache30;

	// Token: 0x0400F760 RID: 63328
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache31;

	// Token: 0x0400F761 RID: 63329
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache32;

	// Token: 0x0400F762 RID: 63330
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache33;

	// Token: 0x0400F763 RID: 63331
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache34;

	// Token: 0x0400F764 RID: 63332
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache35;

	// Token: 0x0400F765 RID: 63333
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache36;

	// Token: 0x0400F766 RID: 63334
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache37;

	// Token: 0x0400F767 RID: 63335
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache38;

	// Token: 0x0400F768 RID: 63336
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache39;

	// Token: 0x0400F769 RID: 63337
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3A;

	// Token: 0x0400F76A RID: 63338
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3B;

	// Token: 0x0400F76B RID: 63339
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3C;

	// Token: 0x0400F76C RID: 63340
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3D;

	// Token: 0x0400F76D RID: 63341
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3E;

	// Token: 0x0400F76E RID: 63342
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3F;

	// Token: 0x0400F76F RID: 63343
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache40;

	// Token: 0x0400F770 RID: 63344
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache41;

	// Token: 0x0400F771 RID: 63345
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache42;

	// Token: 0x0400F772 RID: 63346
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache43;

	// Token: 0x0400F773 RID: 63347
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache44;

	// Token: 0x0400F774 RID: 63348
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache45;

	// Token: 0x0400F775 RID: 63349
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache46;

	// Token: 0x0400F776 RID: 63350
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache47;

	// Token: 0x0400F777 RID: 63351
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache48;

	// Token: 0x0400F778 RID: 63352
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache49;

	// Token: 0x0400F779 RID: 63353
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache4A;

	// Token: 0x0400F77A RID: 63354
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache4B;

	// Token: 0x0400F77B RID: 63355
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache4C;

	// Token: 0x0400F77C RID: 63356
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache4D;

	// Token: 0x0400F77D RID: 63357
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache4E;

	// Token: 0x0400F77E RID: 63358
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache4F;

	// Token: 0x0400F77F RID: 63359
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache50;

	// Token: 0x0400F780 RID: 63360
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache51;

	// Token: 0x0400F781 RID: 63361
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache52;

	// Token: 0x0400F782 RID: 63362
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache53;

	// Token: 0x0400F783 RID: 63363
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache54;

	// Token: 0x0400F784 RID: 63364
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache55;

	// Token: 0x0400F785 RID: 63365
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache56;

	// Token: 0x0400F786 RID: 63366
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache57;

	// Token: 0x0400F787 RID: 63367
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache58;

	// Token: 0x0400F788 RID: 63368
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache59;

	// Token: 0x0400F789 RID: 63369
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache5A;

	// Token: 0x0400F78A RID: 63370
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache5B;

	// Token: 0x0400F78B RID: 63371
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache5C;

	// Token: 0x0400F78C RID: 63372
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache5D;

	// Token: 0x0400F78D RID: 63373
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache5E;

	// Token: 0x0400F78E RID: 63374
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache5F;

	// Token: 0x0400F78F RID: 63375
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache60;

	// Token: 0x0400F790 RID: 63376
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache61;

	// Token: 0x0400F791 RID: 63377
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache62;

	// Token: 0x0400F792 RID: 63378
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache63;

	// Token: 0x0400F793 RID: 63379
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache64;

	// Token: 0x0400F794 RID: 63380
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache65;

	// Token: 0x0400F795 RID: 63381
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache66;

	// Token: 0x0400F796 RID: 63382
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache67;

	// Token: 0x0400F797 RID: 63383
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache68;

	// Token: 0x0400F798 RID: 63384
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache69;

	// Token: 0x0400F799 RID: 63385
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache6A;

	// Token: 0x0400F79A RID: 63386
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache6B;

	// Token: 0x0400F79B RID: 63387
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache6C;

	// Token: 0x0400F79C RID: 63388
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache6D;

	// Token: 0x0400F79D RID: 63389
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache6E;

	// Token: 0x0400F79E RID: 63390
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache6F;

	// Token: 0x0400F79F RID: 63391
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache70;

	// Token: 0x0400F7A0 RID: 63392
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache71;
}
