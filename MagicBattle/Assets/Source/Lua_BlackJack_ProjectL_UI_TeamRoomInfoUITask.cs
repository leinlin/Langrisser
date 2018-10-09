using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using BlackJack.BJFramework.Runtime.UI;
using BlackJack.ProjectL.Common;
using BlackJack.ProjectL.UI;
using SLua;
using UnityEngine;
using UnityEngine.Scripting;

// Token: 0x0200159A RID: 5530
[Preserve]
public class Lua_BlackJack_ProjectL_UI_TeamRoomInfoUITask : LuaObject
{
	// Token: 0x0602175A RID: 137050 RVA: 0x00B51748 File Offset: 0x00B4F948
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int constructor(IntPtr l)
	{
		int result;
		try
		{
			string name;
			LuaObject.checkType(l, 2, out name);
			TeamRoomInfoUITask o = new TeamRoomInfoUITask(name);
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

	// Token: 0x0602175B RID: 137051 RVA: 0x00B5179C File Offset: 0x00B4F99C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int IsNeedLoadDynamicRes(IntPtr l)
	{
		int result;
		try
		{
			TeamRoomInfoUITask teamRoomInfoUITask = (TeamRoomInfoUITask)LuaObject.checkSelf(l);
			bool b = teamRoomInfoUITask.m_luaExportHelper.IsNeedLoadDynamicRes();
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

	// Token: 0x0602175C RID: 137052 RVA: 0x00B517F8 File Offset: 0x00B4F9F8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int InitAllUIControllers(IntPtr l)
	{
		int result;
		try
		{
			TeamRoomInfoUITask teamRoomInfoUITask = (TeamRoomInfoUITask)LuaObject.checkSelf(l);
			teamRoomInfoUITask.m_luaExportHelper.InitAllUIControllers();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0602175D RID: 137053 RVA: 0x00B5184C File Offset: 0x00B4FA4C
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int ClearAllContextAndRes(IntPtr l)
	{
		int result;
		try
		{
			TeamRoomInfoUITask teamRoomInfoUITask = (TeamRoomInfoUITask)LuaObject.checkSelf(l);
			teamRoomInfoUITask.m_luaExportHelper.ClearAllContextAndRes();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0602175E RID: 137054 RVA: 0x00B518A0 File Offset: 0x00B4FAA0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int RegisterPlayerContextEvents(IntPtr l)
	{
		int result;
		try
		{
			TeamRoomInfoUITask teamRoomInfoUITask = (TeamRoomInfoUITask)LuaObject.checkSelf(l);
			teamRoomInfoUITask.m_luaExportHelper.RegisterPlayerContextEvents();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0602175F RID: 137055 RVA: 0x00B518F4 File Offset: 0x00B4FAF4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int UnregisterPlayerContextEvents(IntPtr l)
	{
		int result;
		try
		{
			TeamRoomInfoUITask teamRoomInfoUITask = (TeamRoomInfoUITask)LuaObject.checkSelf(l);
			teamRoomInfoUITask.m_luaExportHelper.UnregisterPlayerContextEvents();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06021760 RID: 137056 RVA: 0x00B51948 File Offset: 0x00B4FB48
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int InitTeamRoomInfoUIController(IntPtr l)
	{
		int result;
		try
		{
			TeamRoomInfoUITask teamRoomInfoUITask = (TeamRoomInfoUITask)LuaObject.checkSelf(l);
			teamRoomInfoUITask.m_luaExportHelper.InitTeamRoomInfoUIController();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06021761 RID: 137057 RVA: 0x00B5199C File Offset: 0x00B4FB9C
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int UninitTeamRoomInfoUIController(IntPtr l)
	{
		int result;
		try
		{
			TeamRoomInfoUITask teamRoomInfoUITask = (TeamRoomInfoUITask)LuaObject.checkSelf(l);
			teamRoomInfoUITask.m_luaExportHelper.UninitTeamRoomInfoUIController();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06021762 RID: 137058 RVA: 0x00B519F0 File Offset: 0x00B4FBF0
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int OnTick(IntPtr l)
	{
		int result;
		try
		{
			TeamRoomInfoUITask teamRoomInfoUITask = (TeamRoomInfoUITask)LuaObject.checkSelf(l);
			teamRoomInfoUITask.m_luaExportHelper.OnTick();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06021763 RID: 137059 RVA: 0x00B51A44 File Offset: 0x00B4FC44
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int UpdateView(IntPtr l)
	{
		int result;
		try
		{
			TeamRoomInfoUITask teamRoomInfoUITask = (TeamRoomInfoUITask)LuaObject.checkSelf(l);
			teamRoomInfoUITask.m_luaExportHelper.UpdateView();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06021764 RID: 137060 RVA: 0x00B51A98 File Offset: 0x00B4FC98
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int UpdateQuitCountdown(IntPtr l)
	{
		int result;
		try
		{
			TeamRoomInfoUITask teamRoomInfoUITask = (TeamRoomInfoUITask)LuaObject.checkSelf(l);
			teamRoomInfoUITask.m_luaExportHelper.UpdateQuitCountdown();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06021765 RID: 137061 RVA: 0x00B51AEC File Offset: 0x00B4FCEC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int CloseAndReturnPrevUITask(IntPtr l)
	{
		int result;
		try
		{
			TeamRoomInfoUITask teamRoomInfoUITask = (TeamRoomInfoUITask)LuaObject.checkSelf(l);
			teamRoomInfoUITask.m_luaExportHelper.CloseAndReturnPrevUITask();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06021766 RID: 137062 RVA: 0x00B51B40 File Offset: 0x00B4FD40
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int StartTeamRoomInviteUITask(IntPtr l)
	{
		int result;
		try
		{
			TeamRoomInfoUITask teamRoomInfoUITask = (TeamRoomInfoUITask)LuaObject.checkSelf(l);
			teamRoomInfoUITask.m_luaExportHelper.StartTeamRoomInviteUITask();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06021767 RID: 137063 RVA: 0x00B51B94 File Offset: 0x00B4FD94
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int TeamRoomInviteUITask_OnPrepareEnd(IntPtr l)
	{
		int result;
		try
		{
			TeamRoomInfoUITask teamRoomInfoUITask = (TeamRoomInfoUITask)LuaObject.checkSelf(l);
			bool ret;
			LuaObject.checkType(l, 2, out ret);
			teamRoomInfoUITask.m_luaExportHelper.TeamRoomInviteUITask_OnPrepareEnd(ret);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06021768 RID: 137064 RVA: 0x00B51BF0 File Offset: 0x00B4FDF0
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int TeamRoomInfoUIController_OnLeave(IntPtr l)
	{
		int result;
		try
		{
			TeamRoomInfoUITask teamRoomInfoUITask = (TeamRoomInfoUITask)LuaObject.checkSelf(l);
			teamRoomInfoUITask.m_luaExportHelper.TeamRoomInfoUIController_OnLeave();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06021769 RID: 137065 RVA: 0x00B51C44 File Offset: 0x00B4FE44
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int TeamRoomInfoUIController_OnStart(IntPtr l)
	{
		int result;
		try
		{
			TeamRoomInfoUITask teamRoomInfoUITask = (TeamRoomInfoUITask)LuaObject.checkSelf(l);
			teamRoomInfoUITask.m_luaExportHelper.TeamRoomInfoUIController_OnStart();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0602176A RID: 137066 RVA: 0x00B51C98 File Offset: 0x00B4FE98
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int TeamRoomInfoUIController_OnShowChangePlayerPosition(IntPtr l)
	{
		int result;
		try
		{
			TeamRoomInfoUITask teamRoomInfoUITask = (TeamRoomInfoUITask)LuaObject.checkSelf(l);
			teamRoomInfoUITask.m_luaExportHelper.TeamRoomInfoUIController_OnShowChangePlayerPosition();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0602176B RID: 137067 RVA: 0x00B51CEC File Offset: 0x00B4FEEC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int TeamRoomInfoUIController_OnChangePlayerPositionComplete(IntPtr l)
	{
		int result;
		try
		{
			TeamRoomInfoUITask teamRoomInfoUITask = (TeamRoomInfoUITask)LuaObject.checkSelf(l);
			teamRoomInfoUITask.m_luaExportHelper.TeamRoomInfoUIController_OnChangePlayerPositionComplete();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0602176C RID: 137068 RVA: 0x00B51D40 File Offset: 0x00B4FF40
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int TeamRoomInfoUIController_OnShowChat(IntPtr l)
	{
		int result;
		try
		{
			TeamRoomInfoUITask teamRoomInfoUITask = (TeamRoomInfoUITask)LuaObject.checkSelf(l);
			teamRoomInfoUITask.m_luaExportHelper.TeamRoomInfoUIController_OnShowChat();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0602176D RID: 137069 RVA: 0x00B51D94 File Offset: 0x00B4FF94
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int TeamRoomInfoUIController_OnChangeAuthority(IntPtr l)
	{
		int result;
		try
		{
			TeamRoomInfoUITask teamRoomInfoUITask = (TeamRoomInfoUITask)LuaObject.checkSelf(l);
			TeamRoomAuthority authority;
			LuaObject.checkEnum<TeamRoomAuthority>(l, 2, out authority);
			teamRoomInfoUITask.m_luaExportHelper.TeamRoomInfoUIController_OnChangeAuthority(authority);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0602176E RID: 137070 RVA: 0x00B51DF0 File Offset: 0x00B4FFF0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int TeamRoomInfoUIController_OnShowInvite(IntPtr l)
	{
		int result;
		try
		{
			TeamRoomInfoUITask teamRoomInfoUITask = (TeamRoomInfoUITask)LuaObject.checkSelf(l);
			teamRoomInfoUITask.m_luaExportHelper.TeamRoomInfoUIController_OnShowInvite();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0602176F RID: 137071 RVA: 0x00B51E44 File Offset: 0x00B50044
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int TeamRoomInfoUIController_OnShowPlayerInfo(IntPtr l)
	{
		int result;
		try
		{
			TeamRoomInfoUITask teamRoomInfoUITask = (TeamRoomInfoUITask)LuaObject.checkSelf(l);
			int index;
			LuaObject.checkType(l, 2, out index);
			RectTransform rt;
			LuaObject.checkType<RectTransform>(l, 3, out rt);
			teamRoomInfoUITask.m_luaExportHelper.TeamRoomInfoUIController_OnShowPlayerInfo(index, rt);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06021770 RID: 137072 RVA: 0x00B51EB0 File Offset: 0x00B500B0
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int ShowPlayerSimpleInfo(IntPtr l)
	{
		int result;
		try
		{
			TeamRoomInfoUITask teamRoomInfoUITask = (TeamRoomInfoUITask)LuaObject.checkSelf(l);
			RectTransform rt;
			LuaObject.checkType<RectTransform>(l, 2, out rt);
			teamRoomInfoUITask.m_luaExportHelper.ShowPlayerSimpleInfo(rt);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06021771 RID: 137073 RVA: 0x00B51F0C File Offset: 0x00B5010C
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int PlayerSimpleInfoUITask_OnClose(IntPtr l)
	{
		int result;
		try
		{
			TeamRoomInfoUITask teamRoomInfoUITask = (TeamRoomInfoUITask)LuaObject.checkSelf(l);
			teamRoomInfoUITask.m_luaExportHelper.PlayerSimpleInfoUITask_OnClose();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06021772 RID: 137074 RVA: 0x00B51F60 File Offset: 0x00B50160
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int PlayerSimpleInfoUITask_OnPrivateChatButtonClick(IntPtr l)
	{
		int result;
		try
		{
			TeamRoomInfoUITask teamRoomInfoUITask = (TeamRoomInfoUITask)LuaObject.checkSelf(l);
			BusinessCard playerInfo;
			LuaObject.checkType<BusinessCard>(l, 2, out playerInfo);
			teamRoomInfoUITask.m_luaExportHelper.PlayerSimpleInfoUITask_OnPrivateChatButtonClick(playerInfo);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06021773 RID: 137075 RVA: 0x00B51FBC File Offset: 0x00B501BC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int PlayerContext_OnTeamRoomPlayerJoinNtf(IntPtr l)
	{
		int result;
		try
		{
			TeamRoomInfoUITask teamRoomInfoUITask = (TeamRoomInfoUITask)LuaObject.checkSelf(l);
			TeamRoomPlayer player;
			LuaObject.checkType<TeamRoomPlayer>(l, 2, out player);
			teamRoomInfoUITask.m_luaExportHelper.PlayerContext_OnTeamRoomPlayerJoinNtf(player);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06021774 RID: 137076 RVA: 0x00B52018 File Offset: 0x00B50218
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int PlayerContext_OnTeamRoomPlayerQuitNtf(IntPtr l)
	{
		int result;
		try
		{
			TeamRoomInfoUITask teamRoomInfoUITask = (TeamRoomInfoUITask)LuaObject.checkSelf(l);
			TeamRoomPlayer player;
			LuaObject.checkType<TeamRoomPlayer>(l, 2, out player);
			teamRoomInfoUITask.m_luaExportHelper.PlayerContext_OnTeamRoomPlayerQuitNtf(player);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06021775 RID: 137077 RVA: 0x00B52074 File Offset: 0x00B50274
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int PlayerContext_OnTeamRoomPlayerPositionChangeNtf(IntPtr l)
	{
		int result;
		try
		{
			TeamRoomInfoUITask teamRoomInfoUITask = (TeamRoomInfoUITask)LuaObject.checkSelf(l);
			teamRoomInfoUITask.m_luaExportHelper.PlayerContext_OnTeamRoomPlayerPositionChangeNtf();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06021776 RID: 137078 RVA: 0x00B520C8 File Offset: 0x00B502C8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int PlayerContext_OnTeamRoomSelfKickOutNtf(IntPtr l)
	{
		int result;
		try
		{
			TeamRoomInfoUITask teamRoomInfoUITask = (TeamRoomInfoUITask)LuaObject.checkSelf(l);
			teamRoomInfoUITask.m_luaExportHelper.PlayerContext_OnTeamRoomSelfKickOutNtf();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06021777 RID: 137079 RVA: 0x00B5211C File Offset: 0x00B5031C
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int PlayerContext_OnTeamRoomAuthorityChangeNtf(IntPtr l)
	{
		int result;
		try
		{
			TeamRoomInfoUITask teamRoomInfoUITask = (TeamRoomInfoUITask)LuaObject.checkSelf(l);
			TeamRoomAuthority authority;
			LuaObject.checkEnum<TeamRoomAuthority>(l, 2, out authority);
			teamRoomInfoUITask.m_luaExportHelper.PlayerContext_OnTeamRoomAuthorityChangeNtf(authority);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06021778 RID: 137080 RVA: 0x00B52178 File Offset: 0x00B50378
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int PlayerContext_OnOnTeamRoomInvitationRefusedNtf(IntPtr l)
	{
		int result2;
		try
		{
			TeamRoomInfoUITask teamRoomInfoUITask = (TeamRoomInfoUITask)LuaObject.checkSelf(l);
			int result;
			LuaObject.checkType(l, 2, out result);
			string inviteeName;
			LuaObject.checkType(l, 3, out inviteeName);
			teamRoomInfoUITask.m_luaExportHelper.PlayerContext_OnOnTeamRoomInvitationRefusedNtf(result, inviteeName);
			LuaObject.pushValue(l, true);
			result2 = 1;
		}
		catch (Exception e)
		{
			result2 = LuaObject.error(l, e);
		}
		return result2;
	}

	// Token: 0x06021779 RID: 137081 RVA: 0x00B521E4 File Offset: 0x00B503E4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int PlayerContext_OnChatMessageNtf(IntPtr l)
	{
		int result;
		try
		{
			TeamRoomInfoUITask teamRoomInfoUITask = (TeamRoomInfoUITask)LuaObject.checkSelf(l);
			ChatMessage msg;
			LuaObject.checkType<ChatMessage>(l, 2, out msg);
			teamRoomInfoUITask.m_luaExportHelper.PlayerContext_OnChatMessageNtf(msg);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0602177A RID: 137082 RVA: 0x00B52240 File Offset: 0x00B50440
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int PlayerContext_OnPlayerInfoInitEnd(IntPtr l)
	{
		int result;
		try
		{
			TeamRoomInfoUITask teamRoomInfoUITask = (TeamRoomInfoUITask)LuaObject.checkSelf(l);
			teamRoomInfoUITask.m_luaExportHelper.PlayerContext_OnPlayerInfoInitEnd();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0602177B RID: 137083 RVA: 0x00B52294 File Offset: 0x00B50494
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int __callBase_OnStart(IntPtr l)
	{
		int result;
		try
		{
			TeamRoomInfoUITask teamRoomInfoUITask = (TeamRoomInfoUITask)LuaObject.checkSelf(l);
			UIIntent intent;
			LuaObject.checkType<UIIntent>(l, 2, out intent);
			bool b = teamRoomInfoUITask.m_luaExportHelper.__callBase_OnStart(intent);
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

	// Token: 0x0602177C RID: 137084 RVA: 0x00B522FC File Offset: 0x00B504FC
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int __callBase_OnStop(IntPtr l)
	{
		int result;
		try
		{
			TeamRoomInfoUITask teamRoomInfoUITask = (TeamRoomInfoUITask)LuaObject.checkSelf(l);
			teamRoomInfoUITask.m_luaExportHelper.__callBase_OnStop();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0602177D RID: 137085 RVA: 0x00B52350 File Offset: 0x00B50550
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_OnPause(IntPtr l)
	{
		int result;
		try
		{
			TeamRoomInfoUITask teamRoomInfoUITask = (TeamRoomInfoUITask)LuaObject.checkSelf(l);
			teamRoomInfoUITask.m_luaExportHelper.__callBase_OnPause();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0602177E RID: 137086 RVA: 0x00B523A4 File Offset: 0x00B505A4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_OnResume(IntPtr l)
	{
		int result;
		try
		{
			TeamRoomInfoUITask teamRoomInfoUITask = (TeamRoomInfoUITask)LuaObject.checkSelf(l);
			UIIntent intent;
			LuaObject.checkType<UIIntent>(l, 2, out intent);
			bool b = teamRoomInfoUITask.m_luaExportHelper.__callBase_OnResume(intent);
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

	// Token: 0x0602177F RID: 137087 RVA: 0x00B5240C File Offset: 0x00B5060C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_OnNewIntent(IntPtr l)
	{
		int result;
		try
		{
			TeamRoomInfoUITask teamRoomInfoUITask = (TeamRoomInfoUITask)LuaObject.checkSelf(l);
			UIIntent intent;
			LuaObject.checkType<UIIntent>(l, 2, out intent);
			bool b = teamRoomInfoUITask.m_luaExportHelper.__callBase_OnNewIntent(intent);
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

	// Token: 0x06021780 RID: 137088 RVA: 0x00B52474 File Offset: 0x00B50674
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int __callBase_EnableUIInput(IntPtr l)
	{
		int result;
		try
		{
			TeamRoomInfoUITask teamRoomInfoUITask = (TeamRoomInfoUITask)LuaObject.checkSelf(l);
			bool isEnable;
			LuaObject.checkType(l, 2, out isEnable);
			bool? isGlobalEnable;
			LuaObject.checkNullable<bool>(l, 3, out isGlobalEnable);
			teamRoomInfoUITask.m_luaExportHelper.__callBase_EnableUIInput(isEnable, isGlobalEnable);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06021781 RID: 137089 RVA: 0x00B524E0 File Offset: 0x00B506E0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_IsNeedLoadDynamicRes(IntPtr l)
	{
		int result;
		try
		{
			TeamRoomInfoUITask teamRoomInfoUITask = (TeamRoomInfoUITask)LuaObject.checkSelf(l);
			bool b = teamRoomInfoUITask.m_luaExportHelper.__callBase_IsNeedLoadDynamicRes();
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

	// Token: 0x06021782 RID: 137090 RVA: 0x00B5253C File Offset: 0x00B5073C
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int __callBase_CollectAllDynamicResForLoad(IntPtr l)
	{
		int result;
		try
		{
			TeamRoomInfoUITask teamRoomInfoUITask = (TeamRoomInfoUITask)LuaObject.checkSelf(l);
			List<string> o = teamRoomInfoUITask.m_luaExportHelper.__callBase_CollectAllDynamicResForLoad();
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

	// Token: 0x06021783 RID: 137091 RVA: 0x00B52598 File Offset: 0x00B50798
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_RegisterPlayerContextEvents(IntPtr l)
	{
		int result;
		try
		{
			TeamRoomInfoUITask teamRoomInfoUITask = (TeamRoomInfoUITask)LuaObject.checkSelf(l);
			teamRoomInfoUITask.m_luaExportHelper.__callBase_RegisterPlayerContextEvents();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06021784 RID: 137092 RVA: 0x00B525EC File Offset: 0x00B507EC
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int __callBase_UnregisterPlayerContextEvents(IntPtr l)
	{
		int result;
		try
		{
			TeamRoomInfoUITask teamRoomInfoUITask = (TeamRoomInfoUITask)LuaObject.checkSelf(l);
			teamRoomInfoUITask.m_luaExportHelper.__callBase_UnregisterPlayerContextEvents();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06021785 RID: 137093 RVA: 0x00B52640 File Offset: 0x00B50840
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int __callBase_PostUpdateView(IntPtr l)
	{
		int result;
		try
		{
			TeamRoomInfoUITask teamRoomInfoUITask = (TeamRoomInfoUITask)LuaObject.checkSelf(l);
			teamRoomInfoUITask.m_luaExportHelper.__callBase_PostUpdateView();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06021786 RID: 137094 RVA: 0x00B52694 File Offset: 0x00B50894
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int __callBase_CollectPreloadResourceList(IntPtr l)
	{
		int result;
		try
		{
			TeamRoomInfoUITask teamRoomInfoUITask = (TeamRoomInfoUITask)LuaObject.checkSelf(l);
			teamRoomInfoUITask.m_luaExportHelper.__callBase_CollectPreloadResourceList();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06021787 RID: 137095 RVA: 0x00B526E8 File Offset: 0x00B508E8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_ClearAssetList(IntPtr l)
	{
		int result;
		try
		{
			TeamRoomInfoUITask teamRoomInfoUITask = (TeamRoomInfoUITask)LuaObject.checkSelf(l);
			teamRoomInfoUITask.m_luaExportHelper.__callBase_ClearAssetList();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06021788 RID: 137096 RVA: 0x00B5273C File Offset: 0x00B5093C
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int __callBase_CollectAsset(IntPtr l)
	{
		int result;
		try
		{
			TeamRoomInfoUITask teamRoomInfoUITask = (TeamRoomInfoUITask)LuaObject.checkSelf(l);
			string assetName;
			LuaObject.checkType(l, 2, out assetName);
			teamRoomInfoUITask.m_luaExportHelper.__callBase_CollectAsset(assetName);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06021789 RID: 137097 RVA: 0x00B52798 File Offset: 0x00B50998
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int __callBase_CollectSpriteAsset(IntPtr l)
	{
		int result;
		try
		{
			TeamRoomInfoUITask teamRoomInfoUITask = (TeamRoomInfoUITask)LuaObject.checkSelf(l);
			string assetName;
			LuaObject.checkType(l, 2, out assetName);
			teamRoomInfoUITask.m_luaExportHelper.__callBase_CollectSpriteAsset(assetName);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0602178A RID: 137098 RVA: 0x00B527F4 File Offset: 0x00B509F4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_CollectFxAsset(IntPtr l)
	{
		int result;
		try
		{
			TeamRoomInfoUITask teamRoomInfoUITask = (TeamRoomInfoUITask)LuaObject.checkSelf(l);
			string assetName;
			LuaObject.checkType(l, 2, out assetName);
			teamRoomInfoUITask.m_luaExportHelper.__callBase_CollectFxAsset(assetName);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0602178B RID: 137099 RVA: 0x00B52850 File Offset: 0x00B50A50
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int __callBase_StartLoadCustomAssets(IntPtr l)
	{
		int result;
		try
		{
			TeamRoomInfoUITask teamRoomInfoUITask = (TeamRoomInfoUITask)LuaObject.checkSelf(l);
			Action onLoadCompleted;
			LuaObject.checkDelegate<Action>(l, 2, out onLoadCompleted);
			teamRoomInfoUITask.m_luaExportHelper.__callBase_StartLoadCustomAssets(onLoadCompleted);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0602178C RID: 137100 RVA: 0x00B528AC File Offset: 0x00B50AAC
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int __callBase_IsLoadingCustomAssets(IntPtr l)
	{
		int result;
		try
		{
			TeamRoomInfoUITask teamRoomInfoUITask = (TeamRoomInfoUITask)LuaObject.checkSelf(l);
			bool b = teamRoomInfoUITask.m_luaExportHelper.__callBase_IsLoadingCustomAssets();
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

	// Token: 0x0602178D RID: 137101 RVA: 0x00B52908 File Offset: 0x00B50B08
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_IsPipeLineRunning(IntPtr l)
	{
		int result;
		try
		{
			TeamRoomInfoUITask teamRoomInfoUITask = (TeamRoomInfoUITask)LuaObject.checkSelf(l);
			bool b = teamRoomInfoUITask.m_luaExportHelper.__callBase_IsPipeLineRunning();
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

	// Token: 0x0602178E RID: 137102 RVA: 0x00B52964 File Offset: 0x00B50B64
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_IsOpeningUI(IntPtr l)
	{
		int result;
		try
		{
			TeamRoomInfoUITask teamRoomInfoUITask = (TeamRoomInfoUITask)LuaObject.checkSelf(l);
			bool b = teamRoomInfoUITask.m_luaExportHelper.__callBase_IsOpeningUI();
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

	// Token: 0x0602178F RID: 137103 RVA: 0x00B529C0 File Offset: 0x00B50BC0
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int __callBase_ReturnPrevUITask(IntPtr l)
	{
		int result;
		try
		{
			TeamRoomInfoUITask teamRoomInfoUITask = (TeamRoomInfoUITask)LuaObject.checkSelf(l);
			UITaskBase o = teamRoomInfoUITask.m_luaExportHelper.__callBase_ReturnPrevUITask();
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

	// Token: 0x06021790 RID: 137104 RVA: 0x00B52A1C File Offset: 0x00B50C1C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_ClearUnusedDynamicResourceCache(IntPtr l)
	{
		int result;
		try
		{
			TeamRoomInfoUITask teamRoomInfoUITask = (TeamRoomInfoUITask)LuaObject.checkSelf(l);
			teamRoomInfoUITask.m_luaExportHelper.__callBase_ClearUnusedDynamicResourceCache();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06021791 RID: 137105 RVA: 0x00B52A70 File Offset: 0x00B50C70
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_OnMemoryWarning(IntPtr l)
	{
		int result;
		try
		{
			TeamRoomInfoUITask teamRoomInfoUITask = (TeamRoomInfoUITask)LuaObject.checkSelf(l);
			teamRoomInfoUITask.m_luaExportHelper.__callBase_OnMemoryWarning();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06021792 RID: 137106 RVA: 0x00B52AC4 File Offset: 0x00B50CC4
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int __callDele_EventOnClose(IntPtr l)
	{
		int result;
		try
		{
			TeamRoomInfoUITask teamRoomInfoUITask = (TeamRoomInfoUITask)LuaObject.checkSelf(l);
			teamRoomInfoUITask.m_luaExportHelper.__callDele_EventOnClose();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06021793 RID: 137107 RVA: 0x00B52B18 File Offset: 0x00B50D18
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int __clearDele_EventOnClose(IntPtr l)
	{
		int result;
		try
		{
			TeamRoomInfoUITask teamRoomInfoUITask = (TeamRoomInfoUITask)LuaObject.checkSelf(l);
			teamRoomInfoUITask.m_luaExportHelper.__clearDele_EventOnClose();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06021794 RID: 137108 RVA: 0x00B52B6C File Offset: 0x00B50D6C
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_EventOnClose(IntPtr l)
	{
		int result;
		try
		{
			TeamRoomInfoUITask teamRoomInfoUITask = (TeamRoomInfoUITask)LuaObject.checkSelf(l);
			Action value;
			int num = LuaObject.checkDelegate<Action>(l, 2, out value);
			if (num != 0)
			{
				if (num == 1)
				{
					teamRoomInfoUITask.EventOnClose += value;
				}
				else if (num == 2)
				{
					teamRoomInfoUITask.EventOnClose -= value;
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

	// Token: 0x06021795 RID: 137109 RVA: 0x00B52BEC File Offset: 0x00B50DEC
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_m_layerDescArray(IntPtr l)
	{
		int result;
		try
		{
			TeamRoomInfoUITask teamRoomInfoUITask = (TeamRoomInfoUITask)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, teamRoomInfoUITask.m_luaExportHelper.m_layerDescArray);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06021796 RID: 137110 RVA: 0x00B52C44 File Offset: 0x00B50E44
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_m_layerDescArray(IntPtr l)
	{
		int result;
		try
		{
			TeamRoomInfoUITask teamRoomInfoUITask = (TeamRoomInfoUITask)LuaObject.checkSelf(l);
			UITaskBase.LayerDesc[] layerDescArray;
			LuaObject.checkArray<UITaskBase.LayerDesc>(l, 2, out layerDescArray);
			teamRoomInfoUITask.m_luaExportHelper.m_layerDescArray = layerDescArray;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06021797 RID: 137111 RVA: 0x00B52CA0 File Offset: 0x00B50EA0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_uiCtrlDescArray(IntPtr l)
	{
		int result;
		try
		{
			TeamRoomInfoUITask teamRoomInfoUITask = (TeamRoomInfoUITask)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, teamRoomInfoUITask.m_luaExportHelper.m_uiCtrlDescArray);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06021798 RID: 137112 RVA: 0x00B52CF8 File Offset: 0x00B50EF8
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_m_uiCtrlDescArray(IntPtr l)
	{
		int result;
		try
		{
			TeamRoomInfoUITask teamRoomInfoUITask = (TeamRoomInfoUITask)LuaObject.checkSelf(l);
			UITaskBase.UIControllerDesc[] uiCtrlDescArray;
			LuaObject.checkArray<UITaskBase.UIControllerDesc>(l, 2, out uiCtrlDescArray);
			teamRoomInfoUITask.m_luaExportHelper.m_uiCtrlDescArray = uiCtrlDescArray;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06021799 RID: 137113 RVA: 0x00B52D54 File Offset: 0x00B50F54
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_teamRoomInfoUIController(IntPtr l)
	{
		int result;
		try
		{
			TeamRoomInfoUITask teamRoomInfoUITask = (TeamRoomInfoUITask)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, teamRoomInfoUITask.m_luaExportHelper.m_teamRoomInfoUIController);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0602179A RID: 137114 RVA: 0x00B52DAC File Offset: 0x00B50FAC
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_m_teamRoomInfoUIController(IntPtr l)
	{
		int result;
		try
		{
			TeamRoomInfoUITask teamRoomInfoUITask = (TeamRoomInfoUITask)LuaObject.checkSelf(l);
			TeamRoomInfoUIController teamRoomInfoUIController;
			LuaObject.checkType<TeamRoomInfoUIController>(l, 2, out teamRoomInfoUIController);
			teamRoomInfoUITask.m_luaExportHelper.m_teamRoomInfoUIController = teamRoomInfoUIController;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0602179B RID: 137115 RVA: 0x00B52E08 File Offset: 0x00B51008
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_m_playerResourceUIController(IntPtr l)
	{
		int result;
		try
		{
			TeamRoomInfoUITask teamRoomInfoUITask = (TeamRoomInfoUITask)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, teamRoomInfoUITask.m_luaExportHelper.m_playerResourceUIController);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0602179C RID: 137116 RVA: 0x00B52E60 File Offset: 0x00B51060
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_playerResourceUIController(IntPtr l)
	{
		int result;
		try
		{
			TeamRoomInfoUITask teamRoomInfoUITask = (TeamRoomInfoUITask)LuaObject.checkSelf(l);
			PlayerResourceUIController playerResourceUIController;
			LuaObject.checkType<PlayerResourceUIController>(l, 2, out playerResourceUIController);
			teamRoomInfoUITask.m_luaExportHelper.m_playerResourceUIController = playerResourceUIController;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0602179D RID: 137117 RVA: 0x00B52EBC File Offset: 0x00B510BC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_nowSeconds(IntPtr l)
	{
		int result;
		try
		{
			TeamRoomInfoUITask teamRoomInfoUITask = (TeamRoomInfoUITask)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, teamRoomInfoUITask.m_luaExportHelper.m_nowSeconds);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0602179E RID: 137118 RVA: 0x00B52F14 File Offset: 0x00B51114
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_nowSeconds(IntPtr l)
	{
		int result;
		try
		{
			TeamRoomInfoUITask teamRoomInfoUITask = (TeamRoomInfoUITask)LuaObject.checkSelf(l);
			int nowSeconds;
			LuaObject.checkType(l, 2, out nowSeconds);
			teamRoomInfoUITask.m_luaExportHelper.m_nowSeconds = nowSeconds;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0602179F RID: 137119 RVA: 0x00B52F70 File Offset: 0x00B51170
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_m_teamRoomPlayers(IntPtr l)
	{
		int result;
		try
		{
			TeamRoomInfoUITask teamRoomInfoUITask = (TeamRoomInfoUITask)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, teamRoomInfoUITask.m_luaExportHelper.m_teamRoomPlayers);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060217A0 RID: 137120 RVA: 0x00B52FC8 File Offset: 0x00B511C8
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_m_teamRoomPlayers(IntPtr l)
	{
		int result;
		try
		{
			TeamRoomInfoUITask teamRoomInfoUITask = (TeamRoomInfoUITask)LuaObject.checkSelf(l);
			List<TeamRoomPlayer> teamRoomPlayers;
			LuaObject.checkType<List<TeamRoomPlayer>>(l, 2, out teamRoomPlayers);
			teamRoomInfoUITask.m_luaExportHelper.m_teamRoomPlayers = teamRoomPlayers;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060217A1 RID: 137121 RVA: 0x00B53024 File Offset: 0x00B51224
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_m_isLeader(IntPtr l)
	{
		int result;
		try
		{
			TeamRoomInfoUITask teamRoomInfoUITask = (TeamRoomInfoUITask)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, teamRoomInfoUITask.m_luaExportHelper.m_isLeader);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060217A2 RID: 137122 RVA: 0x00B5307C File Offset: 0x00B5127C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_isLeader(IntPtr l)
	{
		int result;
		try
		{
			TeamRoomInfoUITask teamRoomInfoUITask = (TeamRoomInfoUITask)LuaObject.checkSelf(l);
			bool isLeader;
			LuaObject.checkType(l, 2, out isLeader);
			teamRoomInfoUITask.m_luaExportHelper.m_isLeader = isLeader;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060217A3 RID: 137123 RVA: 0x00B530D8 File Offset: 0x00B512D8
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_m_playerSimpleInfoUITask(IntPtr l)
	{
		int result;
		try
		{
			TeamRoomInfoUITask teamRoomInfoUITask = (TeamRoomInfoUITask)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, teamRoomInfoUITask.m_luaExportHelper.m_playerSimpleInfoUITask);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060217A4 RID: 137124 RVA: 0x00B53130 File Offset: 0x00B51330
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_m_playerSimpleInfoUITask(IntPtr l)
	{
		int result;
		try
		{
			TeamRoomInfoUITask teamRoomInfoUITask = (TeamRoomInfoUITask)LuaObject.checkSelf(l);
			PlayerSimpleInfoUITask playerSimpleInfoUITask;
			LuaObject.checkType<PlayerSimpleInfoUITask>(l, 2, out playerSimpleInfoUITask);
			teamRoomInfoUITask.m_luaExportHelper.m_playerSimpleInfoUITask = playerSimpleInfoUITask;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060217A5 RID: 137125 RVA: 0x00B5318C File Offset: 0x00B5138C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_LayerDescArray(IntPtr l)
	{
		int result;
		try
		{
			TeamRoomInfoUITask teamRoomInfoUITask = (TeamRoomInfoUITask)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, teamRoomInfoUITask.m_luaExportHelper.LayerDescArray);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060217A6 RID: 137126 RVA: 0x00B531E4 File Offset: 0x00B513E4
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_UICtrlDescArray(IntPtr l)
	{
		int result;
		try
		{
			TeamRoomInfoUITask teamRoomInfoUITask = (TeamRoomInfoUITask)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, teamRoomInfoUITask.m_luaExportHelper.UICtrlDescArray);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060217A7 RID: 137127 RVA: 0x00B5323C File Offset: 0x00B5143C
	[Preserve]
	public static void reg(IntPtr l)
	{
		LuaObject.getTypeTable(l, "BlackJack.ProjectL.UI.TeamRoomInfoUITask");
		if (Lua_BlackJack_ProjectL_UI_TeamRoomInfoUITask.<>f__mg$cache0 == null)
		{
			Lua_BlackJack_ProjectL_UI_TeamRoomInfoUITask.<>f__mg$cache0 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_TeamRoomInfoUITask.IsNeedLoadDynamicRes);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_TeamRoomInfoUITask.<>f__mg$cache0);
		if (Lua_BlackJack_ProjectL_UI_TeamRoomInfoUITask.<>f__mg$cache1 == null)
		{
			Lua_BlackJack_ProjectL_UI_TeamRoomInfoUITask.<>f__mg$cache1 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_TeamRoomInfoUITask.InitAllUIControllers);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_TeamRoomInfoUITask.<>f__mg$cache1);
		if (Lua_BlackJack_ProjectL_UI_TeamRoomInfoUITask.<>f__mg$cache2 == null)
		{
			Lua_BlackJack_ProjectL_UI_TeamRoomInfoUITask.<>f__mg$cache2 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_TeamRoomInfoUITask.ClearAllContextAndRes);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_TeamRoomInfoUITask.<>f__mg$cache2);
		if (Lua_BlackJack_ProjectL_UI_TeamRoomInfoUITask.<>f__mg$cache3 == null)
		{
			Lua_BlackJack_ProjectL_UI_TeamRoomInfoUITask.<>f__mg$cache3 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_TeamRoomInfoUITask.RegisterPlayerContextEvents);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_TeamRoomInfoUITask.<>f__mg$cache3);
		if (Lua_BlackJack_ProjectL_UI_TeamRoomInfoUITask.<>f__mg$cache4 == null)
		{
			Lua_BlackJack_ProjectL_UI_TeamRoomInfoUITask.<>f__mg$cache4 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_TeamRoomInfoUITask.UnregisterPlayerContextEvents);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_TeamRoomInfoUITask.<>f__mg$cache4);
		if (Lua_BlackJack_ProjectL_UI_TeamRoomInfoUITask.<>f__mg$cache5 == null)
		{
			Lua_BlackJack_ProjectL_UI_TeamRoomInfoUITask.<>f__mg$cache5 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_TeamRoomInfoUITask.InitTeamRoomInfoUIController);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_TeamRoomInfoUITask.<>f__mg$cache5);
		if (Lua_BlackJack_ProjectL_UI_TeamRoomInfoUITask.<>f__mg$cache6 == null)
		{
			Lua_BlackJack_ProjectL_UI_TeamRoomInfoUITask.<>f__mg$cache6 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_TeamRoomInfoUITask.UninitTeamRoomInfoUIController);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_TeamRoomInfoUITask.<>f__mg$cache6);
		if (Lua_BlackJack_ProjectL_UI_TeamRoomInfoUITask.<>f__mg$cache7 == null)
		{
			Lua_BlackJack_ProjectL_UI_TeamRoomInfoUITask.<>f__mg$cache7 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_TeamRoomInfoUITask.OnTick);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_TeamRoomInfoUITask.<>f__mg$cache7);
		if (Lua_BlackJack_ProjectL_UI_TeamRoomInfoUITask.<>f__mg$cache8 == null)
		{
			Lua_BlackJack_ProjectL_UI_TeamRoomInfoUITask.<>f__mg$cache8 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_TeamRoomInfoUITask.UpdateView);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_TeamRoomInfoUITask.<>f__mg$cache8);
		if (Lua_BlackJack_ProjectL_UI_TeamRoomInfoUITask.<>f__mg$cache9 == null)
		{
			Lua_BlackJack_ProjectL_UI_TeamRoomInfoUITask.<>f__mg$cache9 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_TeamRoomInfoUITask.UpdateQuitCountdown);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_TeamRoomInfoUITask.<>f__mg$cache9);
		if (Lua_BlackJack_ProjectL_UI_TeamRoomInfoUITask.<>f__mg$cacheA == null)
		{
			Lua_BlackJack_ProjectL_UI_TeamRoomInfoUITask.<>f__mg$cacheA = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_TeamRoomInfoUITask.CloseAndReturnPrevUITask);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_TeamRoomInfoUITask.<>f__mg$cacheA);
		if (Lua_BlackJack_ProjectL_UI_TeamRoomInfoUITask.<>f__mg$cacheB == null)
		{
			Lua_BlackJack_ProjectL_UI_TeamRoomInfoUITask.<>f__mg$cacheB = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_TeamRoomInfoUITask.StartTeamRoomInviteUITask);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_TeamRoomInfoUITask.<>f__mg$cacheB);
		if (Lua_BlackJack_ProjectL_UI_TeamRoomInfoUITask.<>f__mg$cacheC == null)
		{
			Lua_BlackJack_ProjectL_UI_TeamRoomInfoUITask.<>f__mg$cacheC = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_TeamRoomInfoUITask.TeamRoomInviteUITask_OnPrepareEnd);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_TeamRoomInfoUITask.<>f__mg$cacheC);
		if (Lua_BlackJack_ProjectL_UI_TeamRoomInfoUITask.<>f__mg$cacheD == null)
		{
			Lua_BlackJack_ProjectL_UI_TeamRoomInfoUITask.<>f__mg$cacheD = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_TeamRoomInfoUITask.TeamRoomInfoUIController_OnLeave);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_TeamRoomInfoUITask.<>f__mg$cacheD);
		if (Lua_BlackJack_ProjectL_UI_TeamRoomInfoUITask.<>f__mg$cacheE == null)
		{
			Lua_BlackJack_ProjectL_UI_TeamRoomInfoUITask.<>f__mg$cacheE = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_TeamRoomInfoUITask.TeamRoomInfoUIController_OnStart);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_TeamRoomInfoUITask.<>f__mg$cacheE);
		if (Lua_BlackJack_ProjectL_UI_TeamRoomInfoUITask.<>f__mg$cacheF == null)
		{
			Lua_BlackJack_ProjectL_UI_TeamRoomInfoUITask.<>f__mg$cacheF = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_TeamRoomInfoUITask.TeamRoomInfoUIController_OnShowChangePlayerPosition);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_TeamRoomInfoUITask.<>f__mg$cacheF);
		if (Lua_BlackJack_ProjectL_UI_TeamRoomInfoUITask.<>f__mg$cache10 == null)
		{
			Lua_BlackJack_ProjectL_UI_TeamRoomInfoUITask.<>f__mg$cache10 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_TeamRoomInfoUITask.TeamRoomInfoUIController_OnChangePlayerPositionComplete);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_TeamRoomInfoUITask.<>f__mg$cache10);
		if (Lua_BlackJack_ProjectL_UI_TeamRoomInfoUITask.<>f__mg$cache11 == null)
		{
			Lua_BlackJack_ProjectL_UI_TeamRoomInfoUITask.<>f__mg$cache11 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_TeamRoomInfoUITask.TeamRoomInfoUIController_OnShowChat);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_TeamRoomInfoUITask.<>f__mg$cache11);
		if (Lua_BlackJack_ProjectL_UI_TeamRoomInfoUITask.<>f__mg$cache12 == null)
		{
			Lua_BlackJack_ProjectL_UI_TeamRoomInfoUITask.<>f__mg$cache12 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_TeamRoomInfoUITask.TeamRoomInfoUIController_OnChangeAuthority);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_TeamRoomInfoUITask.<>f__mg$cache12);
		if (Lua_BlackJack_ProjectL_UI_TeamRoomInfoUITask.<>f__mg$cache13 == null)
		{
			Lua_BlackJack_ProjectL_UI_TeamRoomInfoUITask.<>f__mg$cache13 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_TeamRoomInfoUITask.TeamRoomInfoUIController_OnShowInvite);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_TeamRoomInfoUITask.<>f__mg$cache13);
		if (Lua_BlackJack_ProjectL_UI_TeamRoomInfoUITask.<>f__mg$cache14 == null)
		{
			Lua_BlackJack_ProjectL_UI_TeamRoomInfoUITask.<>f__mg$cache14 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_TeamRoomInfoUITask.TeamRoomInfoUIController_OnShowPlayerInfo);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_TeamRoomInfoUITask.<>f__mg$cache14);
		if (Lua_BlackJack_ProjectL_UI_TeamRoomInfoUITask.<>f__mg$cache15 == null)
		{
			Lua_BlackJack_ProjectL_UI_TeamRoomInfoUITask.<>f__mg$cache15 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_TeamRoomInfoUITask.ShowPlayerSimpleInfo);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_TeamRoomInfoUITask.<>f__mg$cache15);
		if (Lua_BlackJack_ProjectL_UI_TeamRoomInfoUITask.<>f__mg$cache16 == null)
		{
			Lua_BlackJack_ProjectL_UI_TeamRoomInfoUITask.<>f__mg$cache16 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_TeamRoomInfoUITask.PlayerSimpleInfoUITask_OnClose);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_TeamRoomInfoUITask.<>f__mg$cache16);
		if (Lua_BlackJack_ProjectL_UI_TeamRoomInfoUITask.<>f__mg$cache17 == null)
		{
			Lua_BlackJack_ProjectL_UI_TeamRoomInfoUITask.<>f__mg$cache17 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_TeamRoomInfoUITask.PlayerSimpleInfoUITask_OnPrivateChatButtonClick);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_TeamRoomInfoUITask.<>f__mg$cache17);
		if (Lua_BlackJack_ProjectL_UI_TeamRoomInfoUITask.<>f__mg$cache18 == null)
		{
			Lua_BlackJack_ProjectL_UI_TeamRoomInfoUITask.<>f__mg$cache18 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_TeamRoomInfoUITask.PlayerContext_OnTeamRoomPlayerJoinNtf);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_TeamRoomInfoUITask.<>f__mg$cache18);
		if (Lua_BlackJack_ProjectL_UI_TeamRoomInfoUITask.<>f__mg$cache19 == null)
		{
			Lua_BlackJack_ProjectL_UI_TeamRoomInfoUITask.<>f__mg$cache19 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_TeamRoomInfoUITask.PlayerContext_OnTeamRoomPlayerQuitNtf);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_TeamRoomInfoUITask.<>f__mg$cache19);
		if (Lua_BlackJack_ProjectL_UI_TeamRoomInfoUITask.<>f__mg$cache1A == null)
		{
			Lua_BlackJack_ProjectL_UI_TeamRoomInfoUITask.<>f__mg$cache1A = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_TeamRoomInfoUITask.PlayerContext_OnTeamRoomPlayerPositionChangeNtf);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_TeamRoomInfoUITask.<>f__mg$cache1A);
		if (Lua_BlackJack_ProjectL_UI_TeamRoomInfoUITask.<>f__mg$cache1B == null)
		{
			Lua_BlackJack_ProjectL_UI_TeamRoomInfoUITask.<>f__mg$cache1B = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_TeamRoomInfoUITask.PlayerContext_OnTeamRoomSelfKickOutNtf);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_TeamRoomInfoUITask.<>f__mg$cache1B);
		if (Lua_BlackJack_ProjectL_UI_TeamRoomInfoUITask.<>f__mg$cache1C == null)
		{
			Lua_BlackJack_ProjectL_UI_TeamRoomInfoUITask.<>f__mg$cache1C = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_TeamRoomInfoUITask.PlayerContext_OnTeamRoomAuthorityChangeNtf);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_TeamRoomInfoUITask.<>f__mg$cache1C);
		if (Lua_BlackJack_ProjectL_UI_TeamRoomInfoUITask.<>f__mg$cache1D == null)
		{
			Lua_BlackJack_ProjectL_UI_TeamRoomInfoUITask.<>f__mg$cache1D = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_TeamRoomInfoUITask.PlayerContext_OnOnTeamRoomInvitationRefusedNtf);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_TeamRoomInfoUITask.<>f__mg$cache1D);
		if (Lua_BlackJack_ProjectL_UI_TeamRoomInfoUITask.<>f__mg$cache1E == null)
		{
			Lua_BlackJack_ProjectL_UI_TeamRoomInfoUITask.<>f__mg$cache1E = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_TeamRoomInfoUITask.PlayerContext_OnChatMessageNtf);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_TeamRoomInfoUITask.<>f__mg$cache1E);
		if (Lua_BlackJack_ProjectL_UI_TeamRoomInfoUITask.<>f__mg$cache1F == null)
		{
			Lua_BlackJack_ProjectL_UI_TeamRoomInfoUITask.<>f__mg$cache1F = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_TeamRoomInfoUITask.PlayerContext_OnPlayerInfoInitEnd);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_TeamRoomInfoUITask.<>f__mg$cache1F);
		if (Lua_BlackJack_ProjectL_UI_TeamRoomInfoUITask.<>f__mg$cache20 == null)
		{
			Lua_BlackJack_ProjectL_UI_TeamRoomInfoUITask.<>f__mg$cache20 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_TeamRoomInfoUITask.__callBase_OnStart);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_TeamRoomInfoUITask.<>f__mg$cache20);
		if (Lua_BlackJack_ProjectL_UI_TeamRoomInfoUITask.<>f__mg$cache21 == null)
		{
			Lua_BlackJack_ProjectL_UI_TeamRoomInfoUITask.<>f__mg$cache21 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_TeamRoomInfoUITask.__callBase_OnStop);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_TeamRoomInfoUITask.<>f__mg$cache21);
		if (Lua_BlackJack_ProjectL_UI_TeamRoomInfoUITask.<>f__mg$cache22 == null)
		{
			Lua_BlackJack_ProjectL_UI_TeamRoomInfoUITask.<>f__mg$cache22 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_TeamRoomInfoUITask.__callBase_OnPause);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_TeamRoomInfoUITask.<>f__mg$cache22);
		if (Lua_BlackJack_ProjectL_UI_TeamRoomInfoUITask.<>f__mg$cache23 == null)
		{
			Lua_BlackJack_ProjectL_UI_TeamRoomInfoUITask.<>f__mg$cache23 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_TeamRoomInfoUITask.__callBase_OnResume);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_TeamRoomInfoUITask.<>f__mg$cache23);
		if (Lua_BlackJack_ProjectL_UI_TeamRoomInfoUITask.<>f__mg$cache24 == null)
		{
			Lua_BlackJack_ProjectL_UI_TeamRoomInfoUITask.<>f__mg$cache24 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_TeamRoomInfoUITask.__callBase_OnNewIntent);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_TeamRoomInfoUITask.<>f__mg$cache24);
		if (Lua_BlackJack_ProjectL_UI_TeamRoomInfoUITask.<>f__mg$cache25 == null)
		{
			Lua_BlackJack_ProjectL_UI_TeamRoomInfoUITask.<>f__mg$cache25 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_TeamRoomInfoUITask.__callBase_EnableUIInput);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_TeamRoomInfoUITask.<>f__mg$cache25);
		if (Lua_BlackJack_ProjectL_UI_TeamRoomInfoUITask.<>f__mg$cache26 == null)
		{
			Lua_BlackJack_ProjectL_UI_TeamRoomInfoUITask.<>f__mg$cache26 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_TeamRoomInfoUITask.__callBase_IsNeedLoadDynamicRes);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_TeamRoomInfoUITask.<>f__mg$cache26);
		if (Lua_BlackJack_ProjectL_UI_TeamRoomInfoUITask.<>f__mg$cache27 == null)
		{
			Lua_BlackJack_ProjectL_UI_TeamRoomInfoUITask.<>f__mg$cache27 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_TeamRoomInfoUITask.__callBase_CollectAllDynamicResForLoad);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_TeamRoomInfoUITask.<>f__mg$cache27);
		if (Lua_BlackJack_ProjectL_UI_TeamRoomInfoUITask.<>f__mg$cache28 == null)
		{
			Lua_BlackJack_ProjectL_UI_TeamRoomInfoUITask.<>f__mg$cache28 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_TeamRoomInfoUITask.__callBase_RegisterPlayerContextEvents);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_TeamRoomInfoUITask.<>f__mg$cache28);
		if (Lua_BlackJack_ProjectL_UI_TeamRoomInfoUITask.<>f__mg$cache29 == null)
		{
			Lua_BlackJack_ProjectL_UI_TeamRoomInfoUITask.<>f__mg$cache29 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_TeamRoomInfoUITask.__callBase_UnregisterPlayerContextEvents);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_TeamRoomInfoUITask.<>f__mg$cache29);
		if (Lua_BlackJack_ProjectL_UI_TeamRoomInfoUITask.<>f__mg$cache2A == null)
		{
			Lua_BlackJack_ProjectL_UI_TeamRoomInfoUITask.<>f__mg$cache2A = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_TeamRoomInfoUITask.__callBase_PostUpdateView);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_TeamRoomInfoUITask.<>f__mg$cache2A);
		if (Lua_BlackJack_ProjectL_UI_TeamRoomInfoUITask.<>f__mg$cache2B == null)
		{
			Lua_BlackJack_ProjectL_UI_TeamRoomInfoUITask.<>f__mg$cache2B = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_TeamRoomInfoUITask.__callBase_CollectPreloadResourceList);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_TeamRoomInfoUITask.<>f__mg$cache2B);
		if (Lua_BlackJack_ProjectL_UI_TeamRoomInfoUITask.<>f__mg$cache2C == null)
		{
			Lua_BlackJack_ProjectL_UI_TeamRoomInfoUITask.<>f__mg$cache2C = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_TeamRoomInfoUITask.__callBase_ClearAssetList);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_TeamRoomInfoUITask.<>f__mg$cache2C);
		if (Lua_BlackJack_ProjectL_UI_TeamRoomInfoUITask.<>f__mg$cache2D == null)
		{
			Lua_BlackJack_ProjectL_UI_TeamRoomInfoUITask.<>f__mg$cache2D = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_TeamRoomInfoUITask.__callBase_CollectAsset);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_TeamRoomInfoUITask.<>f__mg$cache2D);
		if (Lua_BlackJack_ProjectL_UI_TeamRoomInfoUITask.<>f__mg$cache2E == null)
		{
			Lua_BlackJack_ProjectL_UI_TeamRoomInfoUITask.<>f__mg$cache2E = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_TeamRoomInfoUITask.__callBase_CollectSpriteAsset);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_TeamRoomInfoUITask.<>f__mg$cache2E);
		if (Lua_BlackJack_ProjectL_UI_TeamRoomInfoUITask.<>f__mg$cache2F == null)
		{
			Lua_BlackJack_ProjectL_UI_TeamRoomInfoUITask.<>f__mg$cache2F = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_TeamRoomInfoUITask.__callBase_CollectFxAsset);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_TeamRoomInfoUITask.<>f__mg$cache2F);
		if (Lua_BlackJack_ProjectL_UI_TeamRoomInfoUITask.<>f__mg$cache30 == null)
		{
			Lua_BlackJack_ProjectL_UI_TeamRoomInfoUITask.<>f__mg$cache30 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_TeamRoomInfoUITask.__callBase_StartLoadCustomAssets);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_TeamRoomInfoUITask.<>f__mg$cache30);
		if (Lua_BlackJack_ProjectL_UI_TeamRoomInfoUITask.<>f__mg$cache31 == null)
		{
			Lua_BlackJack_ProjectL_UI_TeamRoomInfoUITask.<>f__mg$cache31 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_TeamRoomInfoUITask.__callBase_IsLoadingCustomAssets);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_TeamRoomInfoUITask.<>f__mg$cache31);
		if (Lua_BlackJack_ProjectL_UI_TeamRoomInfoUITask.<>f__mg$cache32 == null)
		{
			Lua_BlackJack_ProjectL_UI_TeamRoomInfoUITask.<>f__mg$cache32 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_TeamRoomInfoUITask.__callBase_IsPipeLineRunning);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_TeamRoomInfoUITask.<>f__mg$cache32);
		if (Lua_BlackJack_ProjectL_UI_TeamRoomInfoUITask.<>f__mg$cache33 == null)
		{
			Lua_BlackJack_ProjectL_UI_TeamRoomInfoUITask.<>f__mg$cache33 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_TeamRoomInfoUITask.__callBase_IsOpeningUI);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_TeamRoomInfoUITask.<>f__mg$cache33);
		if (Lua_BlackJack_ProjectL_UI_TeamRoomInfoUITask.<>f__mg$cache34 == null)
		{
			Lua_BlackJack_ProjectL_UI_TeamRoomInfoUITask.<>f__mg$cache34 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_TeamRoomInfoUITask.__callBase_ReturnPrevUITask);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_TeamRoomInfoUITask.<>f__mg$cache34);
		if (Lua_BlackJack_ProjectL_UI_TeamRoomInfoUITask.<>f__mg$cache35 == null)
		{
			Lua_BlackJack_ProjectL_UI_TeamRoomInfoUITask.<>f__mg$cache35 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_TeamRoomInfoUITask.__callBase_ClearUnusedDynamicResourceCache);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_TeamRoomInfoUITask.<>f__mg$cache35);
		if (Lua_BlackJack_ProjectL_UI_TeamRoomInfoUITask.<>f__mg$cache36 == null)
		{
			Lua_BlackJack_ProjectL_UI_TeamRoomInfoUITask.<>f__mg$cache36 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_TeamRoomInfoUITask.__callBase_OnMemoryWarning);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_TeamRoomInfoUITask.<>f__mg$cache36);
		if (Lua_BlackJack_ProjectL_UI_TeamRoomInfoUITask.<>f__mg$cache37 == null)
		{
			Lua_BlackJack_ProjectL_UI_TeamRoomInfoUITask.<>f__mg$cache37 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_TeamRoomInfoUITask.__callDele_EventOnClose);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_TeamRoomInfoUITask.<>f__mg$cache37);
		if (Lua_BlackJack_ProjectL_UI_TeamRoomInfoUITask.<>f__mg$cache38 == null)
		{
			Lua_BlackJack_ProjectL_UI_TeamRoomInfoUITask.<>f__mg$cache38 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_TeamRoomInfoUITask.__clearDele_EventOnClose);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_TeamRoomInfoUITask.<>f__mg$cache38);
		string name = "EventOnClose";
		LuaCSFunction get = null;
		if (Lua_BlackJack_ProjectL_UI_TeamRoomInfoUITask.<>f__mg$cache39 == null)
		{
			Lua_BlackJack_ProjectL_UI_TeamRoomInfoUITask.<>f__mg$cache39 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_TeamRoomInfoUITask.set_EventOnClose);
		}
		LuaObject.addMember(l, name, get, Lua_BlackJack_ProjectL_UI_TeamRoomInfoUITask.<>f__mg$cache39, true);
		string name2 = "m_layerDescArray";
		if (Lua_BlackJack_ProjectL_UI_TeamRoomInfoUITask.<>f__mg$cache3A == null)
		{
			Lua_BlackJack_ProjectL_UI_TeamRoomInfoUITask.<>f__mg$cache3A = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_TeamRoomInfoUITask.get_m_layerDescArray);
		}
		LuaCSFunction get2 = Lua_BlackJack_ProjectL_UI_TeamRoomInfoUITask.<>f__mg$cache3A;
		if (Lua_BlackJack_ProjectL_UI_TeamRoomInfoUITask.<>f__mg$cache3B == null)
		{
			Lua_BlackJack_ProjectL_UI_TeamRoomInfoUITask.<>f__mg$cache3B = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_TeamRoomInfoUITask.set_m_layerDescArray);
		}
		LuaObject.addMember(l, name2, get2, Lua_BlackJack_ProjectL_UI_TeamRoomInfoUITask.<>f__mg$cache3B, true);
		string name3 = "m_uiCtrlDescArray";
		if (Lua_BlackJack_ProjectL_UI_TeamRoomInfoUITask.<>f__mg$cache3C == null)
		{
			Lua_BlackJack_ProjectL_UI_TeamRoomInfoUITask.<>f__mg$cache3C = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_TeamRoomInfoUITask.get_m_uiCtrlDescArray);
		}
		LuaCSFunction get3 = Lua_BlackJack_ProjectL_UI_TeamRoomInfoUITask.<>f__mg$cache3C;
		if (Lua_BlackJack_ProjectL_UI_TeamRoomInfoUITask.<>f__mg$cache3D == null)
		{
			Lua_BlackJack_ProjectL_UI_TeamRoomInfoUITask.<>f__mg$cache3D = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_TeamRoomInfoUITask.set_m_uiCtrlDescArray);
		}
		LuaObject.addMember(l, name3, get3, Lua_BlackJack_ProjectL_UI_TeamRoomInfoUITask.<>f__mg$cache3D, true);
		string name4 = "m_teamRoomInfoUIController";
		if (Lua_BlackJack_ProjectL_UI_TeamRoomInfoUITask.<>f__mg$cache3E == null)
		{
			Lua_BlackJack_ProjectL_UI_TeamRoomInfoUITask.<>f__mg$cache3E = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_TeamRoomInfoUITask.get_m_teamRoomInfoUIController);
		}
		LuaCSFunction get4 = Lua_BlackJack_ProjectL_UI_TeamRoomInfoUITask.<>f__mg$cache3E;
		if (Lua_BlackJack_ProjectL_UI_TeamRoomInfoUITask.<>f__mg$cache3F == null)
		{
			Lua_BlackJack_ProjectL_UI_TeamRoomInfoUITask.<>f__mg$cache3F = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_TeamRoomInfoUITask.set_m_teamRoomInfoUIController);
		}
		LuaObject.addMember(l, name4, get4, Lua_BlackJack_ProjectL_UI_TeamRoomInfoUITask.<>f__mg$cache3F, true);
		string name5 = "m_playerResourceUIController";
		if (Lua_BlackJack_ProjectL_UI_TeamRoomInfoUITask.<>f__mg$cache40 == null)
		{
			Lua_BlackJack_ProjectL_UI_TeamRoomInfoUITask.<>f__mg$cache40 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_TeamRoomInfoUITask.get_m_playerResourceUIController);
		}
		LuaCSFunction get5 = Lua_BlackJack_ProjectL_UI_TeamRoomInfoUITask.<>f__mg$cache40;
		if (Lua_BlackJack_ProjectL_UI_TeamRoomInfoUITask.<>f__mg$cache41 == null)
		{
			Lua_BlackJack_ProjectL_UI_TeamRoomInfoUITask.<>f__mg$cache41 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_TeamRoomInfoUITask.set_m_playerResourceUIController);
		}
		LuaObject.addMember(l, name5, get5, Lua_BlackJack_ProjectL_UI_TeamRoomInfoUITask.<>f__mg$cache41, true);
		string name6 = "m_nowSeconds";
		if (Lua_BlackJack_ProjectL_UI_TeamRoomInfoUITask.<>f__mg$cache42 == null)
		{
			Lua_BlackJack_ProjectL_UI_TeamRoomInfoUITask.<>f__mg$cache42 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_TeamRoomInfoUITask.get_m_nowSeconds);
		}
		LuaCSFunction get6 = Lua_BlackJack_ProjectL_UI_TeamRoomInfoUITask.<>f__mg$cache42;
		if (Lua_BlackJack_ProjectL_UI_TeamRoomInfoUITask.<>f__mg$cache43 == null)
		{
			Lua_BlackJack_ProjectL_UI_TeamRoomInfoUITask.<>f__mg$cache43 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_TeamRoomInfoUITask.set_m_nowSeconds);
		}
		LuaObject.addMember(l, name6, get6, Lua_BlackJack_ProjectL_UI_TeamRoomInfoUITask.<>f__mg$cache43, true);
		string name7 = "m_teamRoomPlayers";
		if (Lua_BlackJack_ProjectL_UI_TeamRoomInfoUITask.<>f__mg$cache44 == null)
		{
			Lua_BlackJack_ProjectL_UI_TeamRoomInfoUITask.<>f__mg$cache44 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_TeamRoomInfoUITask.get_m_teamRoomPlayers);
		}
		LuaCSFunction get7 = Lua_BlackJack_ProjectL_UI_TeamRoomInfoUITask.<>f__mg$cache44;
		if (Lua_BlackJack_ProjectL_UI_TeamRoomInfoUITask.<>f__mg$cache45 == null)
		{
			Lua_BlackJack_ProjectL_UI_TeamRoomInfoUITask.<>f__mg$cache45 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_TeamRoomInfoUITask.set_m_teamRoomPlayers);
		}
		LuaObject.addMember(l, name7, get7, Lua_BlackJack_ProjectL_UI_TeamRoomInfoUITask.<>f__mg$cache45, true);
		string name8 = "m_isLeader";
		if (Lua_BlackJack_ProjectL_UI_TeamRoomInfoUITask.<>f__mg$cache46 == null)
		{
			Lua_BlackJack_ProjectL_UI_TeamRoomInfoUITask.<>f__mg$cache46 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_TeamRoomInfoUITask.get_m_isLeader);
		}
		LuaCSFunction get8 = Lua_BlackJack_ProjectL_UI_TeamRoomInfoUITask.<>f__mg$cache46;
		if (Lua_BlackJack_ProjectL_UI_TeamRoomInfoUITask.<>f__mg$cache47 == null)
		{
			Lua_BlackJack_ProjectL_UI_TeamRoomInfoUITask.<>f__mg$cache47 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_TeamRoomInfoUITask.set_m_isLeader);
		}
		LuaObject.addMember(l, name8, get8, Lua_BlackJack_ProjectL_UI_TeamRoomInfoUITask.<>f__mg$cache47, true);
		string name9 = "m_playerSimpleInfoUITask";
		if (Lua_BlackJack_ProjectL_UI_TeamRoomInfoUITask.<>f__mg$cache48 == null)
		{
			Lua_BlackJack_ProjectL_UI_TeamRoomInfoUITask.<>f__mg$cache48 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_TeamRoomInfoUITask.get_m_playerSimpleInfoUITask);
		}
		LuaCSFunction get9 = Lua_BlackJack_ProjectL_UI_TeamRoomInfoUITask.<>f__mg$cache48;
		if (Lua_BlackJack_ProjectL_UI_TeamRoomInfoUITask.<>f__mg$cache49 == null)
		{
			Lua_BlackJack_ProjectL_UI_TeamRoomInfoUITask.<>f__mg$cache49 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_TeamRoomInfoUITask.set_m_playerSimpleInfoUITask);
		}
		LuaObject.addMember(l, name9, get9, Lua_BlackJack_ProjectL_UI_TeamRoomInfoUITask.<>f__mg$cache49, true);
		string name10 = "LayerDescArray";
		if (Lua_BlackJack_ProjectL_UI_TeamRoomInfoUITask.<>f__mg$cache4A == null)
		{
			Lua_BlackJack_ProjectL_UI_TeamRoomInfoUITask.<>f__mg$cache4A = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_TeamRoomInfoUITask.get_LayerDescArray);
		}
		LuaObject.addMember(l, name10, Lua_BlackJack_ProjectL_UI_TeamRoomInfoUITask.<>f__mg$cache4A, null, true);
		string name11 = "UICtrlDescArray";
		if (Lua_BlackJack_ProjectL_UI_TeamRoomInfoUITask.<>f__mg$cache4B == null)
		{
			Lua_BlackJack_ProjectL_UI_TeamRoomInfoUITask.<>f__mg$cache4B = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_TeamRoomInfoUITask.get_UICtrlDescArray);
		}
		LuaObject.addMember(l, name11, Lua_BlackJack_ProjectL_UI_TeamRoomInfoUITask.<>f__mg$cache4B, null, true);
		if (Lua_BlackJack_ProjectL_UI_TeamRoomInfoUITask.<>f__mg$cache4C == null)
		{
			Lua_BlackJack_ProjectL_UI_TeamRoomInfoUITask.<>f__mg$cache4C = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_TeamRoomInfoUITask.constructor);
		}
		LuaObject.createTypeMetatable(l, Lua_BlackJack_ProjectL_UI_TeamRoomInfoUITask.<>f__mg$cache4C, typeof(TeamRoomInfoUITask), typeof(UITask));
	}

	// Token: 0x04017608 RID: 95752
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache0;

	// Token: 0x04017609 RID: 95753
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1;

	// Token: 0x0401760A RID: 95754
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2;

	// Token: 0x0401760B RID: 95755
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3;

	// Token: 0x0401760C RID: 95756
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache4;

	// Token: 0x0401760D RID: 95757
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache5;

	// Token: 0x0401760E RID: 95758
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache6;

	// Token: 0x0401760F RID: 95759
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache7;

	// Token: 0x04017610 RID: 95760
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache8;

	// Token: 0x04017611 RID: 95761
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache9;

	// Token: 0x04017612 RID: 95762
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheA;

	// Token: 0x04017613 RID: 95763
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheB;

	// Token: 0x04017614 RID: 95764
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheC;

	// Token: 0x04017615 RID: 95765
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheD;

	// Token: 0x04017616 RID: 95766
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheE;

	// Token: 0x04017617 RID: 95767
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheF;

	// Token: 0x04017618 RID: 95768
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache10;

	// Token: 0x04017619 RID: 95769
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache11;

	// Token: 0x0401761A RID: 95770
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache12;

	// Token: 0x0401761B RID: 95771
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache13;

	// Token: 0x0401761C RID: 95772
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache14;

	// Token: 0x0401761D RID: 95773
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache15;

	// Token: 0x0401761E RID: 95774
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache16;

	// Token: 0x0401761F RID: 95775
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache17;

	// Token: 0x04017620 RID: 95776
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache18;

	// Token: 0x04017621 RID: 95777
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache19;

	// Token: 0x04017622 RID: 95778
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1A;

	// Token: 0x04017623 RID: 95779
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1B;

	// Token: 0x04017624 RID: 95780
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1C;

	// Token: 0x04017625 RID: 95781
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1D;

	// Token: 0x04017626 RID: 95782
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1E;

	// Token: 0x04017627 RID: 95783
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1F;

	// Token: 0x04017628 RID: 95784
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache20;

	// Token: 0x04017629 RID: 95785
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache21;

	// Token: 0x0401762A RID: 95786
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache22;

	// Token: 0x0401762B RID: 95787
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache23;

	// Token: 0x0401762C RID: 95788
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache24;

	// Token: 0x0401762D RID: 95789
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache25;

	// Token: 0x0401762E RID: 95790
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache26;

	// Token: 0x0401762F RID: 95791
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache27;

	// Token: 0x04017630 RID: 95792
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache28;

	// Token: 0x04017631 RID: 95793
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache29;

	// Token: 0x04017632 RID: 95794
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2A;

	// Token: 0x04017633 RID: 95795
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2B;

	// Token: 0x04017634 RID: 95796
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2C;

	// Token: 0x04017635 RID: 95797
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2D;

	// Token: 0x04017636 RID: 95798
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2E;

	// Token: 0x04017637 RID: 95799
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2F;

	// Token: 0x04017638 RID: 95800
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache30;

	// Token: 0x04017639 RID: 95801
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache31;

	// Token: 0x0401763A RID: 95802
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache32;

	// Token: 0x0401763B RID: 95803
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache33;

	// Token: 0x0401763C RID: 95804
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache34;

	// Token: 0x0401763D RID: 95805
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache35;

	// Token: 0x0401763E RID: 95806
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache36;

	// Token: 0x0401763F RID: 95807
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache37;

	// Token: 0x04017640 RID: 95808
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache38;

	// Token: 0x04017641 RID: 95809
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache39;

	// Token: 0x04017642 RID: 95810
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3A;

	// Token: 0x04017643 RID: 95811
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3B;

	// Token: 0x04017644 RID: 95812
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3C;

	// Token: 0x04017645 RID: 95813
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3D;

	// Token: 0x04017646 RID: 95814
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3E;

	// Token: 0x04017647 RID: 95815
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3F;

	// Token: 0x04017648 RID: 95816
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache40;

	// Token: 0x04017649 RID: 95817
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache41;

	// Token: 0x0401764A RID: 95818
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache42;

	// Token: 0x0401764B RID: 95819
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache43;

	// Token: 0x0401764C RID: 95820
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache44;

	// Token: 0x0401764D RID: 95821
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache45;

	// Token: 0x0401764E RID: 95822
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache46;

	// Token: 0x0401764F RID: 95823
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache47;

	// Token: 0x04017650 RID: 95824
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache48;

	// Token: 0x04017651 RID: 95825
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache49;

	// Token: 0x04017652 RID: 95826
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache4A;

	// Token: 0x04017653 RID: 95827
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache4B;

	// Token: 0x04017654 RID: 95828
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache4C;
}
