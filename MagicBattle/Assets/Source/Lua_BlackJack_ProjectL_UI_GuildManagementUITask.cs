using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using BlackJack.BJFramework.Runtime.UI;
using BlackJack.ProjectL.Common;
using BlackJack.ProjectL.UI;
using SLua;
using UnityEngine;
using UnityEngine.Scripting;

// Token: 0x02001488 RID: 5256
[Preserve]
public class Lua_BlackJack_ProjectL_UI_GuildManagementUITask : LuaObject
{
	// Token: 0x0601E68F RID: 124559 RVA: 0x009CC55C File Offset: 0x009CA75C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int constructor(IntPtr l)
	{
		int result;
		try
		{
			string name;
			LuaObject.checkType(l, 2, out name);
			GuildManagementUITask o = new GuildManagementUITask(name);
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

	// Token: 0x0601E690 RID: 124560 RVA: 0x009CC5B0 File Offset: 0x009CA7B0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int StartUITask_s(IntPtr l)
	{
		int result;
		try
		{
			string guildId;
			LuaObject.checkType(l, 1, out guildId);
			UIIntent intent;
			LuaObject.checkType<UIIntent>(l, 2, out intent);
			GuildManagementUITask o = GuildManagementUITask.StartUITask(guildId, intent);
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

	// Token: 0x0601E691 RID: 124561 RVA: 0x009CC610 File Offset: 0x009CA810
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int GuildManagementUITask_OnLoadAllResCompleted_s(IntPtr l)
	{
		int result;
		try
		{
			GuildManagementUITask.GuildManagementUITask_OnLoadAllResCompleted();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601E692 RID: 124562 RVA: 0x009CC650 File Offset: 0x009CA850
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int IsNeedLoadDynamicRes(IntPtr l)
	{
		int result;
		try
		{
			GuildManagementUITask guildManagementUITask = (GuildManagementUITask)LuaObject.checkSelf(l);
			bool b = guildManagementUITask.m_luaExportHelper.IsNeedLoadDynamicRes();
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

	// Token: 0x0601E693 RID: 124563 RVA: 0x009CC6AC File Offset: 0x009CA8AC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int InitAllUIControllers(IntPtr l)
	{
		int result;
		try
		{
			GuildManagementUITask guildManagementUITask = (GuildManagementUITask)LuaObject.checkSelf(l);
			guildManagementUITask.m_luaExportHelper.InitAllUIControllers();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601E694 RID: 124564 RVA: 0x009CC700 File Offset: 0x009CA900
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int ClearAllContextAndRes(IntPtr l)
	{
		int result;
		try
		{
			GuildManagementUITask guildManagementUITask = (GuildManagementUITask)LuaObject.checkSelf(l);
			guildManagementUITask.m_luaExportHelper.ClearAllContextAndRes();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601E695 RID: 124565 RVA: 0x009CC754 File Offset: 0x009CA954
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int OnStart(IntPtr l)
	{
		int result;
		try
		{
			GuildManagementUITask guildManagementUITask = (GuildManagementUITask)LuaObject.checkSelf(l);
			UIIntent intent;
			LuaObject.checkType<UIIntent>(l, 2, out intent);
			bool b = guildManagementUITask.m_luaExportHelper.OnStart(intent);
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

	// Token: 0x0601E696 RID: 124566 RVA: 0x009CC7BC File Offset: 0x009CA9BC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int OnResume(IntPtr l)
	{
		int result;
		try
		{
			GuildManagementUITask guildManagementUITask = (GuildManagementUITask)LuaObject.checkSelf(l);
			UIIntent intent;
			LuaObject.checkType<UIIntent>(l, 2, out intent);
			bool b = guildManagementUITask.m_luaExportHelper.OnResume(intent);
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

	// Token: 0x0601E697 RID: 124567 RVA: 0x009CC824 File Offset: 0x009CAA24
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int InitDataFromUIIntent(IntPtr l)
	{
		int result;
		try
		{
			GuildManagementUITask guildManagementUITask = (GuildManagementUITask)LuaObject.checkSelf(l);
			UIIntent intent;
			LuaObject.checkType<UIIntent>(l, 2, out intent);
			guildManagementUITask.m_luaExportHelper.InitDataFromUIIntent(intent);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601E698 RID: 124568 RVA: 0x009CC880 File Offset: 0x009CAA80
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int UpdateView(IntPtr l)
	{
		int result;
		try
		{
			GuildManagementUITask guildManagementUITask = (GuildManagementUITask)LuaObject.checkSelf(l);
			guildManagementUITask.m_luaExportHelper.UpdateView();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601E699 RID: 124569 RVA: 0x009CC8D4 File Offset: 0x009CAAD4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int PostUpdateView(IntPtr l)
	{
		int result;
		try
		{
			GuildManagementUITask guildManagementUITask = (GuildManagementUITask)LuaObject.checkSelf(l);
			guildManagementUITask.m_luaExportHelper.PostUpdateView();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601E69A RID: 124570 RVA: 0x009CC928 File Offset: 0x009CAB28
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int GuildManagementUIController_OnClose(IntPtr l)
	{
		int result;
		try
		{
			GuildManagementUITask guildManagementUITask = (GuildManagementUITask)LuaObject.checkSelf(l);
			guildManagementUITask.m_luaExportHelper.GuildManagementUIController_OnClose();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601E69B RID: 124571 RVA: 0x009CC97C File Offset: 0x009CAB7C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int PlayerContext_EventOnGuildUpdateInfo(IntPtr l)
	{
		int result;
		try
		{
			GuildManagementUITask guildManagementUITask = (GuildManagementUITask)LuaObject.checkSelf(l);
			GuildLog log;
			LuaObject.checkType<GuildLog>(l, 2, out log);
			guildManagementUITask.m_luaExportHelper.PlayerContext_EventOnGuildUpdateInfo(log);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601E69C RID: 124572 RVA: 0x009CC9D8 File Offset: 0x009CABD8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int GuildManagementUIController_OnQuitGuild(IntPtr l)
	{
		int result;
		try
		{
			GuildManagementUITask guildManagementUITask = (GuildManagementUITask)LuaObject.checkSelf(l);
			Action onSucceed;
			LuaObject.checkDelegate<Action>(l, 2, out onSucceed);
			guildManagementUITask.m_luaExportHelper.GuildManagementUIController_OnQuitGuild(onSucceed);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601E69D RID: 124573 RVA: 0x009CCA34 File Offset: 0x009CAC34
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int GuildManagementUIController_OnGetCanInvitePlayerList(IntPtr l)
	{
		int result;
		try
		{
			GuildManagementUITask guildManagementUITask = (GuildManagementUITask)LuaObject.checkSelf(l);
			Action<List<UserSummary>> onSucceed;
			LuaObject.checkDelegate<Action<List<UserSummary>>>(l, 2, out onSucceed);
			bool isShowSucceedTip;
			LuaObject.checkType(l, 3, out isShowSucceedTip);
			guildManagementUITask.m_luaExportHelper.GuildManagementUIController_OnGetCanInvitePlayerList(onSucceed, isShowSucceedTip);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601E69E RID: 124574 RVA: 0x009CCAA0 File Offset: 0x009CACA0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int GuildManagementUIController_OnGuildHiringDeclarationSet(IntPtr l)
	{
		int result;
		try
		{
			GuildManagementUITask guildManagementUITask = (GuildManagementUITask)LuaObject.checkSelf(l);
			string hiringDeclaration;
			LuaObject.checkType(l, 2, out hiringDeclaration);
			Action onSucceed;
			LuaObject.checkDelegate<Action>(l, 3, out onSucceed);
			guildManagementUITask.m_luaExportHelper.GuildManagementUIController_OnGuildHiringDeclarationSet(hiringDeclaration, onSucceed);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601E69F RID: 124575 RVA: 0x009CCB0C File Offset: 0x009CAD0C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int GuildManagementUIController_OnGuildInfoSet(IntPtr l)
	{
		int result;
		try
		{
			GuildManagementUITask guildManagementUITask = (GuildManagementUITask)LuaObject.checkSelf(l);
			bool autoJoin;
			LuaObject.checkType(l, 2, out autoJoin);
			int joinLevel;
			LuaObject.checkType(l, 3, out joinLevel);
			string announcement;
			LuaObject.checkType(l, 4, out announcement);
			Action onSucceed;
			LuaObject.checkDelegate<Action>(l, 5, out onSucceed);
			guildManagementUITask.m_luaExportHelper.GuildManagementUIController_OnGuildInfoSet(autoJoin, joinLevel, announcement, onSucceed);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601E6A0 RID: 124576 RVA: 0x009CCB90 File Offset: 0x009CAD90
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int GuildManagementUIController_OnGuildAnnouncementSet(IntPtr l)
	{
		int result;
		try
		{
			GuildManagementUITask guildManagementUITask = (GuildManagementUITask)LuaObject.checkSelf(l);
			string announcement;
			LuaObject.checkType(l, 2, out announcement);
			Action onSucceed;
			LuaObject.checkDelegate<Action>(l, 3, out onSucceed);
			guildManagementUITask.m_luaExportHelper.GuildManagementUIController_OnGuildAnnouncementSet(announcement, onSucceed);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601E6A1 RID: 124577 RVA: 0x009CCBFC File Offset: 0x009CADFC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int GuildManagementUIController_OnGetGuildJoinApply(IntPtr l)
	{
		int result;
		try
		{
			GuildManagementUITask guildManagementUITask = (GuildManagementUITask)LuaObject.checkSelf(l);
			Action<List<UserSummary>> onSucceed;
			LuaObject.checkDelegate<Action<List<UserSummary>>>(l, 2, out onSucceed);
			guildManagementUITask.m_luaExportHelper.GuildManagementUIController_OnGetGuildJoinApply(onSucceed);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601E6A2 RID: 124578 RVA: 0x009CCC58 File Offset: 0x009CAE58
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int GuildManagementUIController_OnGuildJoinConfirmOrRefuse(IntPtr l)
	{
		int result;
		try
		{
			GuildManagementUITask guildManagementUITask = (GuildManagementUITask)LuaObject.checkSelf(l);
			string userId;
			LuaObject.checkType(l, 2, out userId);
			bool isAccept;
			LuaObject.checkType(l, 3, out isAccept);
			Action onEnd;
			LuaObject.checkDelegate<Action>(l, 4, out onEnd);
			guildManagementUITask.m_luaExportHelper.GuildManagementUIController_OnGuildJoinConfirmOrRefuse(userId, isAccept, onEnd);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601E6A3 RID: 124579 RVA: 0x009CCCD0 File Offset: 0x009CAED0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int GuildManagementUIController_OnChangeGuildName(IntPtr l)
	{
		int result;
		try
		{
			GuildManagementUITask guildManagementUITask = (GuildManagementUITask)LuaObject.checkSelf(l);
			string name;
			LuaObject.checkType(l, 2, out name);
			Action onSucceed;
			LuaObject.checkDelegate<Action>(l, 3, out onSucceed);
			guildManagementUITask.m_luaExportHelper.GuildManagementUIController_OnChangeGuildName(name, onSucceed);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601E6A4 RID: 124580 RVA: 0x009CCD3C File Offset: 0x009CAF3C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int GuildManagementUIController_OnGetGuildJournal(IntPtr l)
	{
		int result;
		try
		{
			GuildManagementUITask guildManagementUITask = (GuildManagementUITask)LuaObject.checkSelf(l);
			Action<List<GuildLog>> onSucceed;
			LuaObject.checkDelegate<Action<List<GuildLog>>>(l, 2, out onSucceed);
			guildManagementUITask.m_luaExportHelper.GuildManagementUIController_OnGetGuildJournal(onSucceed);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601E6A5 RID: 124581 RVA: 0x009CCD98 File Offset: 0x009CAF98
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int GuildManagementUIController_OnGuildInviteMember(IntPtr l)
	{
		int result;
		try
		{
			GuildManagementUITask guildManagementUITask = (GuildManagementUITask)LuaObject.checkSelf(l);
			string userId;
			LuaObject.checkType(l, 2, out userId);
			Action onSucceed;
			LuaObject.checkDelegate<Action>(l, 3, out onSucceed);
			guildManagementUITask.m_luaExportHelper.GuildManagementUIController_OnGuildInviteMember(userId, onSucceed);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601E6A6 RID: 124582 RVA: 0x009CCE04 File Offset: 0x009CB004
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int GuildManagementUIController_OnAllRefuseButtonClick(IntPtr l)
	{
		int result;
		try
		{
			GuildManagementUITask guildManagementUITask = (GuildManagementUITask)LuaObject.checkSelf(l);
			Action onSucceed;
			LuaObject.checkDelegate<Action>(l, 2, out onSucceed);
			guildManagementUITask.m_luaExportHelper.GuildManagementUIController_OnAllRefuseButtonClick(onSucceed);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601E6A7 RID: 124583 RVA: 0x009CCE60 File Offset: 0x009CB060
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int GuildManagementUIController_OnGuildMemberClick(IntPtr l)
	{
		int result;
		try
		{
			GuildManagementUITask guildManagementUITask = (GuildManagementUITask)LuaObject.checkSelf(l);
			string userId;
			LuaObject.checkType(l, 2, out userId);
			Vector3 pos;
			LuaObject.checkType(l, 3, out pos);
			PlayerSimpleInfoUITask.PostionType posType;
			LuaObject.checkEnum<PlayerSimpleInfoUITask.PostionType>(l, 4, out posType);
			guildManagementUITask.m_luaExportHelper.GuildManagementUIController_OnGuildMemberClick(userId, pos, posType);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601E6A8 RID: 124584 RVA: 0x009CCED8 File Offset: 0x009CB0D8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int GuildManagementUIController_OnGotoGuildStore(IntPtr l)
	{
		int result;
		try
		{
			GuildManagementUITask guildManagementUITask = (GuildManagementUITask)LuaObject.checkSelf(l);
			guildManagementUITask.m_luaExportHelper.GuildManagementUIController_OnGotoGuildStore();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601E6A9 RID: 124585 RVA: 0x009CCF2C File Offset: 0x009CB12C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int GuildManagementUIController_OnGotoGuildGameListPanel(IntPtr l)
	{
		int result;
		try
		{
			GuildManagementUITask guildManagementUITask = (GuildManagementUITask)LuaObject.checkSelf(l);
			guildManagementUITask.m_luaExportHelper.GuildManagementUIController_OnGotoGuildGameListPanel();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601E6AA RID: 124586 RVA: 0x009CCF80 File Offset: 0x009CB180
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int GuildGameListUITask_OnLoadAllResCompleted(IntPtr l)
	{
		int result;
		try
		{
			GuildManagementUITask guildManagementUITask = (GuildManagementUITask)LuaObject.checkSelf(l);
			guildManagementUITask.m_luaExportHelper.GuildGameListUITask_OnLoadAllResCompleted();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601E6AB RID: 124587 RVA: 0x009CCFD4 File Offset: 0x009CB1D4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int PlayerSimpleInfoUITask_OnClose(IntPtr l)
	{
		int result;
		try
		{
			GuildManagementUITask guildManagementUITask = (GuildManagementUITask)LuaObject.checkSelf(l);
			guildManagementUITask.m_luaExportHelper.PlayerSimpleInfoUITask_OnClose();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601E6AC RID: 124588 RVA: 0x009CD028 File Offset: 0x009CB228
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int PlayerSimpleInfoUITask_OnPrivateChatButtonClick(IntPtr l)
	{
		int result;
		try
		{
			GuildManagementUITask guildManagementUITask = (GuildManagementUITask)LuaObject.checkSelf(l);
			BusinessCard playerInfo;
			LuaObject.checkType<BusinessCard>(l, 2, out playerInfo);
			guildManagementUITask.m_luaExportHelper.PlayerSimpleInfoUITask_OnPrivateChatButtonClick(playerInfo);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601E6AD RID: 124589 RVA: 0x009CD084 File Offset: 0x009CB284
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int OnTick(IntPtr l)
	{
		int result;
		try
		{
			GuildManagementUITask guildManagementUITask = (GuildManagementUITask)LuaObject.checkSelf(l);
			guildManagementUITask.m_luaExportHelper.OnTick();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601E6AE RID: 124590 RVA: 0x009CD0D8 File Offset: 0x009CB2D8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int SendRefreshGuildReq(IntPtr l)
	{
		int result;
		try
		{
			GuildManagementUITask guildManagementUITask = (GuildManagementUITask)LuaObject.checkSelf(l);
			guildManagementUITask.m_luaExportHelper.SendRefreshGuildReq();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601E6AF RID: 124591 RVA: 0x009CD12C File Offset: 0x009CB32C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_OnStart(IntPtr l)
	{
		int result;
		try
		{
			GuildManagementUITask guildManagementUITask = (GuildManagementUITask)LuaObject.checkSelf(l);
			UIIntent intent;
			LuaObject.checkType<UIIntent>(l, 2, out intent);
			bool b = guildManagementUITask.m_luaExportHelper.__callBase_OnStart(intent);
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

	// Token: 0x0601E6B0 RID: 124592 RVA: 0x009CD194 File Offset: 0x009CB394
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_OnStop(IntPtr l)
	{
		int result;
		try
		{
			GuildManagementUITask guildManagementUITask = (GuildManagementUITask)LuaObject.checkSelf(l);
			guildManagementUITask.m_luaExportHelper.__callBase_OnStop();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601E6B1 RID: 124593 RVA: 0x009CD1E8 File Offset: 0x009CB3E8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_OnPause(IntPtr l)
	{
		int result;
		try
		{
			GuildManagementUITask guildManagementUITask = (GuildManagementUITask)LuaObject.checkSelf(l);
			guildManagementUITask.m_luaExportHelper.__callBase_OnPause();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601E6B2 RID: 124594 RVA: 0x009CD23C File Offset: 0x009CB43C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_OnResume(IntPtr l)
	{
		int result;
		try
		{
			GuildManagementUITask guildManagementUITask = (GuildManagementUITask)LuaObject.checkSelf(l);
			UIIntent intent;
			LuaObject.checkType<UIIntent>(l, 2, out intent);
			bool b = guildManagementUITask.m_luaExportHelper.__callBase_OnResume(intent);
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

	// Token: 0x0601E6B3 RID: 124595 RVA: 0x009CD2A4 File Offset: 0x009CB4A4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_OnNewIntent(IntPtr l)
	{
		int result;
		try
		{
			GuildManagementUITask guildManagementUITask = (GuildManagementUITask)LuaObject.checkSelf(l);
			UIIntent intent;
			LuaObject.checkType<UIIntent>(l, 2, out intent);
			bool b = guildManagementUITask.m_luaExportHelper.__callBase_OnNewIntent(intent);
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

	// Token: 0x0601E6B4 RID: 124596 RVA: 0x009CD30C File Offset: 0x009CB50C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_EnableUIInput(IntPtr l)
	{
		int result;
		try
		{
			GuildManagementUITask guildManagementUITask = (GuildManagementUITask)LuaObject.checkSelf(l);
			bool isEnable;
			LuaObject.checkType(l, 2, out isEnable);
			bool? isGlobalEnable;
			LuaObject.checkNullable<bool>(l, 3, out isGlobalEnable);
			guildManagementUITask.m_luaExportHelper.__callBase_EnableUIInput(isEnable, isGlobalEnable);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601E6B5 RID: 124597 RVA: 0x009CD378 File Offset: 0x009CB578
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_IsNeedLoadDynamicRes(IntPtr l)
	{
		int result;
		try
		{
			GuildManagementUITask guildManagementUITask = (GuildManagementUITask)LuaObject.checkSelf(l);
			bool b = guildManagementUITask.m_luaExportHelper.__callBase_IsNeedLoadDynamicRes();
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

	// Token: 0x0601E6B6 RID: 124598 RVA: 0x009CD3D4 File Offset: 0x009CB5D4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_CollectAllDynamicResForLoad(IntPtr l)
	{
		int result;
		try
		{
			GuildManagementUITask guildManagementUITask = (GuildManagementUITask)LuaObject.checkSelf(l);
			List<string> o = guildManagementUITask.m_luaExportHelper.__callBase_CollectAllDynamicResForLoad();
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

	// Token: 0x0601E6B7 RID: 124599 RVA: 0x009CD430 File Offset: 0x009CB630
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_RegisterPlayerContextEvents(IntPtr l)
	{
		int result;
		try
		{
			GuildManagementUITask guildManagementUITask = (GuildManagementUITask)LuaObject.checkSelf(l);
			guildManagementUITask.m_luaExportHelper.__callBase_RegisterPlayerContextEvents();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601E6B8 RID: 124600 RVA: 0x009CD484 File Offset: 0x009CB684
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_UnregisterPlayerContextEvents(IntPtr l)
	{
		int result;
		try
		{
			GuildManagementUITask guildManagementUITask = (GuildManagementUITask)LuaObject.checkSelf(l);
			guildManagementUITask.m_luaExportHelper.__callBase_UnregisterPlayerContextEvents();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601E6B9 RID: 124601 RVA: 0x009CD4D8 File Offset: 0x009CB6D8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_PostUpdateView(IntPtr l)
	{
		int result;
		try
		{
			GuildManagementUITask guildManagementUITask = (GuildManagementUITask)LuaObject.checkSelf(l);
			guildManagementUITask.m_luaExportHelper.__callBase_PostUpdateView();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601E6BA RID: 124602 RVA: 0x009CD52C File Offset: 0x009CB72C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_CollectPreloadResourceList(IntPtr l)
	{
		int result;
		try
		{
			GuildManagementUITask guildManagementUITask = (GuildManagementUITask)LuaObject.checkSelf(l);
			guildManagementUITask.m_luaExportHelper.__callBase_CollectPreloadResourceList();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601E6BB RID: 124603 RVA: 0x009CD580 File Offset: 0x009CB780
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_ClearAssetList(IntPtr l)
	{
		int result;
		try
		{
			GuildManagementUITask guildManagementUITask = (GuildManagementUITask)LuaObject.checkSelf(l);
			guildManagementUITask.m_luaExportHelper.__callBase_ClearAssetList();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601E6BC RID: 124604 RVA: 0x009CD5D4 File Offset: 0x009CB7D4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_CollectAsset(IntPtr l)
	{
		int result;
		try
		{
			GuildManagementUITask guildManagementUITask = (GuildManagementUITask)LuaObject.checkSelf(l);
			string assetName;
			LuaObject.checkType(l, 2, out assetName);
			guildManagementUITask.m_luaExportHelper.__callBase_CollectAsset(assetName);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601E6BD RID: 124605 RVA: 0x009CD630 File Offset: 0x009CB830
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_CollectSpriteAsset(IntPtr l)
	{
		int result;
		try
		{
			GuildManagementUITask guildManagementUITask = (GuildManagementUITask)LuaObject.checkSelf(l);
			string assetName;
			LuaObject.checkType(l, 2, out assetName);
			guildManagementUITask.m_luaExportHelper.__callBase_CollectSpriteAsset(assetName);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601E6BE RID: 124606 RVA: 0x009CD68C File Offset: 0x009CB88C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_CollectFxAsset(IntPtr l)
	{
		int result;
		try
		{
			GuildManagementUITask guildManagementUITask = (GuildManagementUITask)LuaObject.checkSelf(l);
			string assetName;
			LuaObject.checkType(l, 2, out assetName);
			guildManagementUITask.m_luaExportHelper.__callBase_CollectFxAsset(assetName);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601E6BF RID: 124607 RVA: 0x009CD6E8 File Offset: 0x009CB8E8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_StartLoadCustomAssets(IntPtr l)
	{
		int result;
		try
		{
			GuildManagementUITask guildManagementUITask = (GuildManagementUITask)LuaObject.checkSelf(l);
			Action onLoadCompleted;
			LuaObject.checkDelegate<Action>(l, 2, out onLoadCompleted);
			guildManagementUITask.m_luaExportHelper.__callBase_StartLoadCustomAssets(onLoadCompleted);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601E6C0 RID: 124608 RVA: 0x009CD744 File Offset: 0x009CB944
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_IsLoadingCustomAssets(IntPtr l)
	{
		int result;
		try
		{
			GuildManagementUITask guildManagementUITask = (GuildManagementUITask)LuaObject.checkSelf(l);
			bool b = guildManagementUITask.m_luaExportHelper.__callBase_IsLoadingCustomAssets();
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

	// Token: 0x0601E6C1 RID: 124609 RVA: 0x009CD7A0 File Offset: 0x009CB9A0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_IsPipeLineRunning(IntPtr l)
	{
		int result;
		try
		{
			GuildManagementUITask guildManagementUITask = (GuildManagementUITask)LuaObject.checkSelf(l);
			bool b = guildManagementUITask.m_luaExportHelper.__callBase_IsPipeLineRunning();
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

	// Token: 0x0601E6C2 RID: 124610 RVA: 0x009CD7FC File Offset: 0x009CB9FC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_IsOpeningUI(IntPtr l)
	{
		int result;
		try
		{
			GuildManagementUITask guildManagementUITask = (GuildManagementUITask)LuaObject.checkSelf(l);
			bool b = guildManagementUITask.m_luaExportHelper.__callBase_IsOpeningUI();
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

	// Token: 0x0601E6C3 RID: 124611 RVA: 0x009CD858 File Offset: 0x009CBA58
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_ReturnPrevUITask(IntPtr l)
	{
		int result;
		try
		{
			GuildManagementUITask guildManagementUITask = (GuildManagementUITask)LuaObject.checkSelf(l);
			UITaskBase o = guildManagementUITask.m_luaExportHelper.__callBase_ReturnPrevUITask();
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

	// Token: 0x0601E6C4 RID: 124612 RVA: 0x009CD8B4 File Offset: 0x009CBAB4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_ClearUnusedDynamicResourceCache(IntPtr l)
	{
		int result;
		try
		{
			GuildManagementUITask guildManagementUITask = (GuildManagementUITask)LuaObject.checkSelf(l);
			guildManagementUITask.m_luaExportHelper.__callBase_ClearUnusedDynamicResourceCache();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601E6C5 RID: 124613 RVA: 0x009CD908 File Offset: 0x009CBB08
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_OnMemoryWarning(IntPtr l)
	{
		int result;
		try
		{
			GuildManagementUITask guildManagementUITask = (GuildManagementUITask)LuaObject.checkSelf(l);
			guildManagementUITask.m_luaExportHelper.__callBase_OnMemoryWarning();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601E6C6 RID: 124614 RVA: 0x009CD95C File Offset: 0x009CBB5C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_layerDescArray(IntPtr l)
	{
		int result;
		try
		{
			GuildManagementUITask guildManagementUITask = (GuildManagementUITask)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, guildManagementUITask.m_luaExportHelper.m_layerDescArray);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601E6C7 RID: 124615 RVA: 0x009CD9B4 File Offset: 0x009CBBB4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_layerDescArray(IntPtr l)
	{
		int result;
		try
		{
			GuildManagementUITask guildManagementUITask = (GuildManagementUITask)LuaObject.checkSelf(l);
			UITaskBase.LayerDesc[] layerDescArray;
			LuaObject.checkArray<UITaskBase.LayerDesc>(l, 2, out layerDescArray);
			guildManagementUITask.m_luaExportHelper.m_layerDescArray = layerDescArray;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601E6C8 RID: 124616 RVA: 0x009CDA10 File Offset: 0x009CBC10
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_uiCtrlDescArray(IntPtr l)
	{
		int result;
		try
		{
			GuildManagementUITask guildManagementUITask = (GuildManagementUITask)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, guildManagementUITask.m_luaExportHelper.m_uiCtrlDescArray);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601E6C9 RID: 124617 RVA: 0x009CDA68 File Offset: 0x009CBC68
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_uiCtrlDescArray(IntPtr l)
	{
		int result;
		try
		{
			GuildManagementUITask guildManagementUITask = (GuildManagementUITask)LuaObject.checkSelf(l);
			UITaskBase.UIControllerDesc[] uiCtrlDescArray;
			LuaObject.checkArray<UITaskBase.UIControllerDesc>(l, 2, out uiCtrlDescArray);
			guildManagementUITask.m_luaExportHelper.m_uiCtrlDescArray = uiCtrlDescArray;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601E6CA RID: 124618 RVA: 0x009CDAC4 File Offset: 0x009CBCC4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_guildManagementUIController(IntPtr l)
	{
		int result;
		try
		{
			GuildManagementUITask guildManagementUITask = (GuildManagementUITask)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, guildManagementUITask.m_luaExportHelper.m_guildManagementUIController);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601E6CB RID: 124619 RVA: 0x009CDB1C File Offset: 0x009CBD1C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_guildManagementUIController(IntPtr l)
	{
		int result;
		try
		{
			GuildManagementUITask guildManagementUITask = (GuildManagementUITask)LuaObject.checkSelf(l);
			GuildManagementUIController guildManagementUIController;
			LuaObject.checkType<GuildManagementUIController>(l, 2, out guildManagementUIController);
			guildManagementUITask.m_luaExportHelper.m_guildManagementUIController = guildManagementUIController;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601E6CC RID: 124620 RVA: 0x009CDB78 File Offset: 0x009CBD78
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_guildId(IntPtr l)
	{
		int result;
		try
		{
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, GuildManagementUITask.LuaExportHelper.m_guildId);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601E6CD RID: 124621 RVA: 0x009CDBC0 File Offset: 0x009CBDC0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_guildId(IntPtr l)
	{
		int result;
		try
		{
			string guildId;
			LuaObject.checkType(l, 2, out guildId);
			GuildManagementUITask.LuaExportHelper.m_guildId = guildId;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601E6CE RID: 124622 RVA: 0x009CDC0C File Offset: 0x009CBE0C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_playerSimpleInfoUITask(IntPtr l)
	{
		int result;
		try
		{
			GuildManagementUITask guildManagementUITask = (GuildManagementUITask)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, guildManagementUITask.m_luaExportHelper.m_playerSimpleInfoUITask);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601E6CF RID: 124623 RVA: 0x009CDC64 File Offset: 0x009CBE64
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_playerSimpleInfoUITask(IntPtr l)
	{
		int result;
		try
		{
			GuildManagementUITask guildManagementUITask = (GuildManagementUITask)LuaObject.checkSelf(l);
			PlayerSimpleInfoUITask playerSimpleInfoUITask;
			LuaObject.checkType<PlayerSimpleInfoUITask>(l, 2, out playerSimpleInfoUITask);
			guildManagementUITask.m_luaExportHelper.m_playerSimpleInfoUITask = playerSimpleInfoUITask;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601E6D0 RID: 124624 RVA: 0x009CDCC0 File Offset: 0x009CBEC0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_lastUpdateTime(IntPtr l)
	{
		int result;
		try
		{
			GuildManagementUITask guildManagementUITask = (GuildManagementUITask)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, guildManagementUITask.m_luaExportHelper.m_lastUpdateTime);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601E6D1 RID: 124625 RVA: 0x009CDD18 File Offset: 0x009CBF18
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_lastUpdateTime(IntPtr l)
	{
		int result;
		try
		{
			GuildManagementUITask guildManagementUITask = (GuildManagementUITask)LuaObject.checkSelf(l);
			float lastUpdateTime;
			LuaObject.checkType(l, 2, out lastUpdateTime);
			guildManagementUITask.m_luaExportHelper.m_lastUpdateTime = lastUpdateTime;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601E6D2 RID: 124626 RVA: 0x009CDD74 File Offset: 0x009CBF74
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_guild(IntPtr l)
	{
		int result;
		try
		{
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, GuildManagementUITask.LuaExportHelper.m_guild);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601E6D3 RID: 124627 RVA: 0x009CDDBC File Offset: 0x009CBFBC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_guild(IntPtr l)
	{
		int result;
		try
		{
			Guild guild;
			LuaObject.checkType<Guild>(l, 2, out guild);
			GuildManagementUITask.LuaExportHelper.m_guild = guild;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601E6D4 RID: 124628 RVA: 0x009CDE08 File Offset: 0x009CC008
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_LayerDescArray(IntPtr l)
	{
		int result;
		try
		{
			GuildManagementUITask guildManagementUITask = (GuildManagementUITask)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, guildManagementUITask.m_luaExportHelper.LayerDescArray);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601E6D5 RID: 124629 RVA: 0x009CDE60 File Offset: 0x009CC060
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_UICtrlDescArray(IntPtr l)
	{
		int result;
		try
		{
			GuildManagementUITask guildManagementUITask = (GuildManagementUITask)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, guildManagementUITask.m_luaExportHelper.UICtrlDescArray);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601E6D6 RID: 124630 RVA: 0x009CDEB8 File Offset: 0x009CC0B8
	[Preserve]
	public static void reg(IntPtr l)
	{
		LuaObject.getTypeTable(l, "BlackJack.ProjectL.UI.GuildManagementUITask");
		if (Lua_BlackJack_ProjectL_UI_GuildManagementUITask.<>f__mg$cache0 == null)
		{
			Lua_BlackJack_ProjectL_UI_GuildManagementUITask.<>f__mg$cache0 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_GuildManagementUITask.StartUITask_s);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_GuildManagementUITask.<>f__mg$cache0);
		if (Lua_BlackJack_ProjectL_UI_GuildManagementUITask.<>f__mg$cache1 == null)
		{
			Lua_BlackJack_ProjectL_UI_GuildManagementUITask.<>f__mg$cache1 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_GuildManagementUITask.GuildManagementUITask_OnLoadAllResCompleted_s);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_GuildManagementUITask.<>f__mg$cache1);
		if (Lua_BlackJack_ProjectL_UI_GuildManagementUITask.<>f__mg$cache2 == null)
		{
			Lua_BlackJack_ProjectL_UI_GuildManagementUITask.<>f__mg$cache2 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_GuildManagementUITask.IsNeedLoadDynamicRes);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_GuildManagementUITask.<>f__mg$cache2);
		if (Lua_BlackJack_ProjectL_UI_GuildManagementUITask.<>f__mg$cache3 == null)
		{
			Lua_BlackJack_ProjectL_UI_GuildManagementUITask.<>f__mg$cache3 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_GuildManagementUITask.InitAllUIControllers);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_GuildManagementUITask.<>f__mg$cache3);
		if (Lua_BlackJack_ProjectL_UI_GuildManagementUITask.<>f__mg$cache4 == null)
		{
			Lua_BlackJack_ProjectL_UI_GuildManagementUITask.<>f__mg$cache4 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_GuildManagementUITask.ClearAllContextAndRes);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_GuildManagementUITask.<>f__mg$cache4);
		if (Lua_BlackJack_ProjectL_UI_GuildManagementUITask.<>f__mg$cache5 == null)
		{
			Lua_BlackJack_ProjectL_UI_GuildManagementUITask.<>f__mg$cache5 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_GuildManagementUITask.OnStart);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_GuildManagementUITask.<>f__mg$cache5);
		if (Lua_BlackJack_ProjectL_UI_GuildManagementUITask.<>f__mg$cache6 == null)
		{
			Lua_BlackJack_ProjectL_UI_GuildManagementUITask.<>f__mg$cache6 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_GuildManagementUITask.OnResume);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_GuildManagementUITask.<>f__mg$cache6);
		if (Lua_BlackJack_ProjectL_UI_GuildManagementUITask.<>f__mg$cache7 == null)
		{
			Lua_BlackJack_ProjectL_UI_GuildManagementUITask.<>f__mg$cache7 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_GuildManagementUITask.InitDataFromUIIntent);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_GuildManagementUITask.<>f__mg$cache7);
		if (Lua_BlackJack_ProjectL_UI_GuildManagementUITask.<>f__mg$cache8 == null)
		{
			Lua_BlackJack_ProjectL_UI_GuildManagementUITask.<>f__mg$cache8 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_GuildManagementUITask.UpdateView);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_GuildManagementUITask.<>f__mg$cache8);
		if (Lua_BlackJack_ProjectL_UI_GuildManagementUITask.<>f__mg$cache9 == null)
		{
			Lua_BlackJack_ProjectL_UI_GuildManagementUITask.<>f__mg$cache9 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_GuildManagementUITask.PostUpdateView);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_GuildManagementUITask.<>f__mg$cache9);
		if (Lua_BlackJack_ProjectL_UI_GuildManagementUITask.<>f__mg$cacheA == null)
		{
			Lua_BlackJack_ProjectL_UI_GuildManagementUITask.<>f__mg$cacheA = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_GuildManagementUITask.GuildManagementUIController_OnClose);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_GuildManagementUITask.<>f__mg$cacheA);
		if (Lua_BlackJack_ProjectL_UI_GuildManagementUITask.<>f__mg$cacheB == null)
		{
			Lua_BlackJack_ProjectL_UI_GuildManagementUITask.<>f__mg$cacheB = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_GuildManagementUITask.PlayerContext_EventOnGuildUpdateInfo);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_GuildManagementUITask.<>f__mg$cacheB);
		if (Lua_BlackJack_ProjectL_UI_GuildManagementUITask.<>f__mg$cacheC == null)
		{
			Lua_BlackJack_ProjectL_UI_GuildManagementUITask.<>f__mg$cacheC = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_GuildManagementUITask.GuildManagementUIController_OnQuitGuild);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_GuildManagementUITask.<>f__mg$cacheC);
		if (Lua_BlackJack_ProjectL_UI_GuildManagementUITask.<>f__mg$cacheD == null)
		{
			Lua_BlackJack_ProjectL_UI_GuildManagementUITask.<>f__mg$cacheD = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_GuildManagementUITask.GuildManagementUIController_OnGetCanInvitePlayerList);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_GuildManagementUITask.<>f__mg$cacheD);
		if (Lua_BlackJack_ProjectL_UI_GuildManagementUITask.<>f__mg$cacheE == null)
		{
			Lua_BlackJack_ProjectL_UI_GuildManagementUITask.<>f__mg$cacheE = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_GuildManagementUITask.GuildManagementUIController_OnGuildHiringDeclarationSet);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_GuildManagementUITask.<>f__mg$cacheE);
		if (Lua_BlackJack_ProjectL_UI_GuildManagementUITask.<>f__mg$cacheF == null)
		{
			Lua_BlackJack_ProjectL_UI_GuildManagementUITask.<>f__mg$cacheF = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_GuildManagementUITask.GuildManagementUIController_OnGuildInfoSet);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_GuildManagementUITask.<>f__mg$cacheF);
		if (Lua_BlackJack_ProjectL_UI_GuildManagementUITask.<>f__mg$cache10 == null)
		{
			Lua_BlackJack_ProjectL_UI_GuildManagementUITask.<>f__mg$cache10 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_GuildManagementUITask.GuildManagementUIController_OnGuildAnnouncementSet);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_GuildManagementUITask.<>f__mg$cache10);
		if (Lua_BlackJack_ProjectL_UI_GuildManagementUITask.<>f__mg$cache11 == null)
		{
			Lua_BlackJack_ProjectL_UI_GuildManagementUITask.<>f__mg$cache11 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_GuildManagementUITask.GuildManagementUIController_OnGetGuildJoinApply);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_GuildManagementUITask.<>f__mg$cache11);
		if (Lua_BlackJack_ProjectL_UI_GuildManagementUITask.<>f__mg$cache12 == null)
		{
			Lua_BlackJack_ProjectL_UI_GuildManagementUITask.<>f__mg$cache12 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_GuildManagementUITask.GuildManagementUIController_OnGuildJoinConfirmOrRefuse);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_GuildManagementUITask.<>f__mg$cache12);
		if (Lua_BlackJack_ProjectL_UI_GuildManagementUITask.<>f__mg$cache13 == null)
		{
			Lua_BlackJack_ProjectL_UI_GuildManagementUITask.<>f__mg$cache13 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_GuildManagementUITask.GuildManagementUIController_OnChangeGuildName);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_GuildManagementUITask.<>f__mg$cache13);
		if (Lua_BlackJack_ProjectL_UI_GuildManagementUITask.<>f__mg$cache14 == null)
		{
			Lua_BlackJack_ProjectL_UI_GuildManagementUITask.<>f__mg$cache14 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_GuildManagementUITask.GuildManagementUIController_OnGetGuildJournal);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_GuildManagementUITask.<>f__mg$cache14);
		if (Lua_BlackJack_ProjectL_UI_GuildManagementUITask.<>f__mg$cache15 == null)
		{
			Lua_BlackJack_ProjectL_UI_GuildManagementUITask.<>f__mg$cache15 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_GuildManagementUITask.GuildManagementUIController_OnGuildInviteMember);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_GuildManagementUITask.<>f__mg$cache15);
		if (Lua_BlackJack_ProjectL_UI_GuildManagementUITask.<>f__mg$cache16 == null)
		{
			Lua_BlackJack_ProjectL_UI_GuildManagementUITask.<>f__mg$cache16 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_GuildManagementUITask.GuildManagementUIController_OnAllRefuseButtonClick);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_GuildManagementUITask.<>f__mg$cache16);
		if (Lua_BlackJack_ProjectL_UI_GuildManagementUITask.<>f__mg$cache17 == null)
		{
			Lua_BlackJack_ProjectL_UI_GuildManagementUITask.<>f__mg$cache17 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_GuildManagementUITask.GuildManagementUIController_OnGuildMemberClick);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_GuildManagementUITask.<>f__mg$cache17);
		if (Lua_BlackJack_ProjectL_UI_GuildManagementUITask.<>f__mg$cache18 == null)
		{
			Lua_BlackJack_ProjectL_UI_GuildManagementUITask.<>f__mg$cache18 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_GuildManagementUITask.GuildManagementUIController_OnGotoGuildStore);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_GuildManagementUITask.<>f__mg$cache18);
		if (Lua_BlackJack_ProjectL_UI_GuildManagementUITask.<>f__mg$cache19 == null)
		{
			Lua_BlackJack_ProjectL_UI_GuildManagementUITask.<>f__mg$cache19 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_GuildManagementUITask.GuildManagementUIController_OnGotoGuildGameListPanel);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_GuildManagementUITask.<>f__mg$cache19);
		if (Lua_BlackJack_ProjectL_UI_GuildManagementUITask.<>f__mg$cache1A == null)
		{
			Lua_BlackJack_ProjectL_UI_GuildManagementUITask.<>f__mg$cache1A = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_GuildManagementUITask.GuildGameListUITask_OnLoadAllResCompleted);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_GuildManagementUITask.<>f__mg$cache1A);
		if (Lua_BlackJack_ProjectL_UI_GuildManagementUITask.<>f__mg$cache1B == null)
		{
			Lua_BlackJack_ProjectL_UI_GuildManagementUITask.<>f__mg$cache1B = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_GuildManagementUITask.PlayerSimpleInfoUITask_OnClose);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_GuildManagementUITask.<>f__mg$cache1B);
		if (Lua_BlackJack_ProjectL_UI_GuildManagementUITask.<>f__mg$cache1C == null)
		{
			Lua_BlackJack_ProjectL_UI_GuildManagementUITask.<>f__mg$cache1C = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_GuildManagementUITask.PlayerSimpleInfoUITask_OnPrivateChatButtonClick);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_GuildManagementUITask.<>f__mg$cache1C);
		if (Lua_BlackJack_ProjectL_UI_GuildManagementUITask.<>f__mg$cache1D == null)
		{
			Lua_BlackJack_ProjectL_UI_GuildManagementUITask.<>f__mg$cache1D = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_GuildManagementUITask.OnTick);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_GuildManagementUITask.<>f__mg$cache1D);
		if (Lua_BlackJack_ProjectL_UI_GuildManagementUITask.<>f__mg$cache1E == null)
		{
			Lua_BlackJack_ProjectL_UI_GuildManagementUITask.<>f__mg$cache1E = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_GuildManagementUITask.SendRefreshGuildReq);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_GuildManagementUITask.<>f__mg$cache1E);
		if (Lua_BlackJack_ProjectL_UI_GuildManagementUITask.<>f__mg$cache1F == null)
		{
			Lua_BlackJack_ProjectL_UI_GuildManagementUITask.<>f__mg$cache1F = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_GuildManagementUITask.__callBase_OnStart);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_GuildManagementUITask.<>f__mg$cache1F);
		if (Lua_BlackJack_ProjectL_UI_GuildManagementUITask.<>f__mg$cache20 == null)
		{
			Lua_BlackJack_ProjectL_UI_GuildManagementUITask.<>f__mg$cache20 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_GuildManagementUITask.__callBase_OnStop);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_GuildManagementUITask.<>f__mg$cache20);
		if (Lua_BlackJack_ProjectL_UI_GuildManagementUITask.<>f__mg$cache21 == null)
		{
			Lua_BlackJack_ProjectL_UI_GuildManagementUITask.<>f__mg$cache21 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_GuildManagementUITask.__callBase_OnPause);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_GuildManagementUITask.<>f__mg$cache21);
		if (Lua_BlackJack_ProjectL_UI_GuildManagementUITask.<>f__mg$cache22 == null)
		{
			Lua_BlackJack_ProjectL_UI_GuildManagementUITask.<>f__mg$cache22 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_GuildManagementUITask.__callBase_OnResume);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_GuildManagementUITask.<>f__mg$cache22);
		if (Lua_BlackJack_ProjectL_UI_GuildManagementUITask.<>f__mg$cache23 == null)
		{
			Lua_BlackJack_ProjectL_UI_GuildManagementUITask.<>f__mg$cache23 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_GuildManagementUITask.__callBase_OnNewIntent);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_GuildManagementUITask.<>f__mg$cache23);
		if (Lua_BlackJack_ProjectL_UI_GuildManagementUITask.<>f__mg$cache24 == null)
		{
			Lua_BlackJack_ProjectL_UI_GuildManagementUITask.<>f__mg$cache24 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_GuildManagementUITask.__callBase_EnableUIInput);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_GuildManagementUITask.<>f__mg$cache24);
		if (Lua_BlackJack_ProjectL_UI_GuildManagementUITask.<>f__mg$cache25 == null)
		{
			Lua_BlackJack_ProjectL_UI_GuildManagementUITask.<>f__mg$cache25 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_GuildManagementUITask.__callBase_IsNeedLoadDynamicRes);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_GuildManagementUITask.<>f__mg$cache25);
		if (Lua_BlackJack_ProjectL_UI_GuildManagementUITask.<>f__mg$cache26 == null)
		{
			Lua_BlackJack_ProjectL_UI_GuildManagementUITask.<>f__mg$cache26 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_GuildManagementUITask.__callBase_CollectAllDynamicResForLoad);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_GuildManagementUITask.<>f__mg$cache26);
		if (Lua_BlackJack_ProjectL_UI_GuildManagementUITask.<>f__mg$cache27 == null)
		{
			Lua_BlackJack_ProjectL_UI_GuildManagementUITask.<>f__mg$cache27 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_GuildManagementUITask.__callBase_RegisterPlayerContextEvents);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_GuildManagementUITask.<>f__mg$cache27);
		if (Lua_BlackJack_ProjectL_UI_GuildManagementUITask.<>f__mg$cache28 == null)
		{
			Lua_BlackJack_ProjectL_UI_GuildManagementUITask.<>f__mg$cache28 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_GuildManagementUITask.__callBase_UnregisterPlayerContextEvents);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_GuildManagementUITask.<>f__mg$cache28);
		if (Lua_BlackJack_ProjectL_UI_GuildManagementUITask.<>f__mg$cache29 == null)
		{
			Lua_BlackJack_ProjectL_UI_GuildManagementUITask.<>f__mg$cache29 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_GuildManagementUITask.__callBase_PostUpdateView);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_GuildManagementUITask.<>f__mg$cache29);
		if (Lua_BlackJack_ProjectL_UI_GuildManagementUITask.<>f__mg$cache2A == null)
		{
			Lua_BlackJack_ProjectL_UI_GuildManagementUITask.<>f__mg$cache2A = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_GuildManagementUITask.__callBase_CollectPreloadResourceList);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_GuildManagementUITask.<>f__mg$cache2A);
		if (Lua_BlackJack_ProjectL_UI_GuildManagementUITask.<>f__mg$cache2B == null)
		{
			Lua_BlackJack_ProjectL_UI_GuildManagementUITask.<>f__mg$cache2B = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_GuildManagementUITask.__callBase_ClearAssetList);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_GuildManagementUITask.<>f__mg$cache2B);
		if (Lua_BlackJack_ProjectL_UI_GuildManagementUITask.<>f__mg$cache2C == null)
		{
			Lua_BlackJack_ProjectL_UI_GuildManagementUITask.<>f__mg$cache2C = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_GuildManagementUITask.__callBase_CollectAsset);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_GuildManagementUITask.<>f__mg$cache2C);
		if (Lua_BlackJack_ProjectL_UI_GuildManagementUITask.<>f__mg$cache2D == null)
		{
			Lua_BlackJack_ProjectL_UI_GuildManagementUITask.<>f__mg$cache2D = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_GuildManagementUITask.__callBase_CollectSpriteAsset);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_GuildManagementUITask.<>f__mg$cache2D);
		if (Lua_BlackJack_ProjectL_UI_GuildManagementUITask.<>f__mg$cache2E == null)
		{
			Lua_BlackJack_ProjectL_UI_GuildManagementUITask.<>f__mg$cache2E = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_GuildManagementUITask.__callBase_CollectFxAsset);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_GuildManagementUITask.<>f__mg$cache2E);
		if (Lua_BlackJack_ProjectL_UI_GuildManagementUITask.<>f__mg$cache2F == null)
		{
			Lua_BlackJack_ProjectL_UI_GuildManagementUITask.<>f__mg$cache2F = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_GuildManagementUITask.__callBase_StartLoadCustomAssets);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_GuildManagementUITask.<>f__mg$cache2F);
		if (Lua_BlackJack_ProjectL_UI_GuildManagementUITask.<>f__mg$cache30 == null)
		{
			Lua_BlackJack_ProjectL_UI_GuildManagementUITask.<>f__mg$cache30 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_GuildManagementUITask.__callBase_IsLoadingCustomAssets);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_GuildManagementUITask.<>f__mg$cache30);
		if (Lua_BlackJack_ProjectL_UI_GuildManagementUITask.<>f__mg$cache31 == null)
		{
			Lua_BlackJack_ProjectL_UI_GuildManagementUITask.<>f__mg$cache31 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_GuildManagementUITask.__callBase_IsPipeLineRunning);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_GuildManagementUITask.<>f__mg$cache31);
		if (Lua_BlackJack_ProjectL_UI_GuildManagementUITask.<>f__mg$cache32 == null)
		{
			Lua_BlackJack_ProjectL_UI_GuildManagementUITask.<>f__mg$cache32 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_GuildManagementUITask.__callBase_IsOpeningUI);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_GuildManagementUITask.<>f__mg$cache32);
		if (Lua_BlackJack_ProjectL_UI_GuildManagementUITask.<>f__mg$cache33 == null)
		{
			Lua_BlackJack_ProjectL_UI_GuildManagementUITask.<>f__mg$cache33 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_GuildManagementUITask.__callBase_ReturnPrevUITask);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_GuildManagementUITask.<>f__mg$cache33);
		if (Lua_BlackJack_ProjectL_UI_GuildManagementUITask.<>f__mg$cache34 == null)
		{
			Lua_BlackJack_ProjectL_UI_GuildManagementUITask.<>f__mg$cache34 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_GuildManagementUITask.__callBase_ClearUnusedDynamicResourceCache);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_GuildManagementUITask.<>f__mg$cache34);
		if (Lua_BlackJack_ProjectL_UI_GuildManagementUITask.<>f__mg$cache35 == null)
		{
			Lua_BlackJack_ProjectL_UI_GuildManagementUITask.<>f__mg$cache35 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_GuildManagementUITask.__callBase_OnMemoryWarning);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_GuildManagementUITask.<>f__mg$cache35);
		string name = "m_layerDescArray";
		if (Lua_BlackJack_ProjectL_UI_GuildManagementUITask.<>f__mg$cache36 == null)
		{
			Lua_BlackJack_ProjectL_UI_GuildManagementUITask.<>f__mg$cache36 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_GuildManagementUITask.get_m_layerDescArray);
		}
		LuaCSFunction get = Lua_BlackJack_ProjectL_UI_GuildManagementUITask.<>f__mg$cache36;
		if (Lua_BlackJack_ProjectL_UI_GuildManagementUITask.<>f__mg$cache37 == null)
		{
			Lua_BlackJack_ProjectL_UI_GuildManagementUITask.<>f__mg$cache37 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_GuildManagementUITask.set_m_layerDescArray);
		}
		LuaObject.addMember(l, name, get, Lua_BlackJack_ProjectL_UI_GuildManagementUITask.<>f__mg$cache37, true);
		string name2 = "m_uiCtrlDescArray";
		if (Lua_BlackJack_ProjectL_UI_GuildManagementUITask.<>f__mg$cache38 == null)
		{
			Lua_BlackJack_ProjectL_UI_GuildManagementUITask.<>f__mg$cache38 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_GuildManagementUITask.get_m_uiCtrlDescArray);
		}
		LuaCSFunction get2 = Lua_BlackJack_ProjectL_UI_GuildManagementUITask.<>f__mg$cache38;
		if (Lua_BlackJack_ProjectL_UI_GuildManagementUITask.<>f__mg$cache39 == null)
		{
			Lua_BlackJack_ProjectL_UI_GuildManagementUITask.<>f__mg$cache39 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_GuildManagementUITask.set_m_uiCtrlDescArray);
		}
		LuaObject.addMember(l, name2, get2, Lua_BlackJack_ProjectL_UI_GuildManagementUITask.<>f__mg$cache39, true);
		string name3 = "m_guildManagementUIController";
		if (Lua_BlackJack_ProjectL_UI_GuildManagementUITask.<>f__mg$cache3A == null)
		{
			Lua_BlackJack_ProjectL_UI_GuildManagementUITask.<>f__mg$cache3A = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_GuildManagementUITask.get_m_guildManagementUIController);
		}
		LuaCSFunction get3 = Lua_BlackJack_ProjectL_UI_GuildManagementUITask.<>f__mg$cache3A;
		if (Lua_BlackJack_ProjectL_UI_GuildManagementUITask.<>f__mg$cache3B == null)
		{
			Lua_BlackJack_ProjectL_UI_GuildManagementUITask.<>f__mg$cache3B = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_GuildManagementUITask.set_m_guildManagementUIController);
		}
		LuaObject.addMember(l, name3, get3, Lua_BlackJack_ProjectL_UI_GuildManagementUITask.<>f__mg$cache3B, true);
		string name4 = "m_guildId";
		if (Lua_BlackJack_ProjectL_UI_GuildManagementUITask.<>f__mg$cache3C == null)
		{
			Lua_BlackJack_ProjectL_UI_GuildManagementUITask.<>f__mg$cache3C = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_GuildManagementUITask.get_m_guildId);
		}
		LuaCSFunction get4 = Lua_BlackJack_ProjectL_UI_GuildManagementUITask.<>f__mg$cache3C;
		if (Lua_BlackJack_ProjectL_UI_GuildManagementUITask.<>f__mg$cache3D == null)
		{
			Lua_BlackJack_ProjectL_UI_GuildManagementUITask.<>f__mg$cache3D = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_GuildManagementUITask.set_m_guildId);
		}
		LuaObject.addMember(l, name4, get4, Lua_BlackJack_ProjectL_UI_GuildManagementUITask.<>f__mg$cache3D, false);
		string name5 = "m_playerSimpleInfoUITask";
		if (Lua_BlackJack_ProjectL_UI_GuildManagementUITask.<>f__mg$cache3E == null)
		{
			Lua_BlackJack_ProjectL_UI_GuildManagementUITask.<>f__mg$cache3E = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_GuildManagementUITask.get_m_playerSimpleInfoUITask);
		}
		LuaCSFunction get5 = Lua_BlackJack_ProjectL_UI_GuildManagementUITask.<>f__mg$cache3E;
		if (Lua_BlackJack_ProjectL_UI_GuildManagementUITask.<>f__mg$cache3F == null)
		{
			Lua_BlackJack_ProjectL_UI_GuildManagementUITask.<>f__mg$cache3F = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_GuildManagementUITask.set_m_playerSimpleInfoUITask);
		}
		LuaObject.addMember(l, name5, get5, Lua_BlackJack_ProjectL_UI_GuildManagementUITask.<>f__mg$cache3F, true);
		string name6 = "m_lastUpdateTime";
		if (Lua_BlackJack_ProjectL_UI_GuildManagementUITask.<>f__mg$cache40 == null)
		{
			Lua_BlackJack_ProjectL_UI_GuildManagementUITask.<>f__mg$cache40 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_GuildManagementUITask.get_m_lastUpdateTime);
		}
		LuaCSFunction get6 = Lua_BlackJack_ProjectL_UI_GuildManagementUITask.<>f__mg$cache40;
		if (Lua_BlackJack_ProjectL_UI_GuildManagementUITask.<>f__mg$cache41 == null)
		{
			Lua_BlackJack_ProjectL_UI_GuildManagementUITask.<>f__mg$cache41 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_GuildManagementUITask.set_m_lastUpdateTime);
		}
		LuaObject.addMember(l, name6, get6, Lua_BlackJack_ProjectL_UI_GuildManagementUITask.<>f__mg$cache41, true);
		string name7 = "m_guild";
		if (Lua_BlackJack_ProjectL_UI_GuildManagementUITask.<>f__mg$cache42 == null)
		{
			Lua_BlackJack_ProjectL_UI_GuildManagementUITask.<>f__mg$cache42 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_GuildManagementUITask.get_m_guild);
		}
		LuaCSFunction get7 = Lua_BlackJack_ProjectL_UI_GuildManagementUITask.<>f__mg$cache42;
		if (Lua_BlackJack_ProjectL_UI_GuildManagementUITask.<>f__mg$cache43 == null)
		{
			Lua_BlackJack_ProjectL_UI_GuildManagementUITask.<>f__mg$cache43 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_GuildManagementUITask.set_m_guild);
		}
		LuaObject.addMember(l, name7, get7, Lua_BlackJack_ProjectL_UI_GuildManagementUITask.<>f__mg$cache43, false);
		string name8 = "LayerDescArray";
		if (Lua_BlackJack_ProjectL_UI_GuildManagementUITask.<>f__mg$cache44 == null)
		{
			Lua_BlackJack_ProjectL_UI_GuildManagementUITask.<>f__mg$cache44 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_GuildManagementUITask.get_LayerDescArray);
		}
		LuaObject.addMember(l, name8, Lua_BlackJack_ProjectL_UI_GuildManagementUITask.<>f__mg$cache44, null, true);
		string name9 = "UICtrlDescArray";
		if (Lua_BlackJack_ProjectL_UI_GuildManagementUITask.<>f__mg$cache45 == null)
		{
			Lua_BlackJack_ProjectL_UI_GuildManagementUITask.<>f__mg$cache45 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_GuildManagementUITask.get_UICtrlDescArray);
		}
		LuaObject.addMember(l, name9, Lua_BlackJack_ProjectL_UI_GuildManagementUITask.<>f__mg$cache45, null, true);
		if (Lua_BlackJack_ProjectL_UI_GuildManagementUITask.<>f__mg$cache46 == null)
		{
			Lua_BlackJack_ProjectL_UI_GuildManagementUITask.<>f__mg$cache46 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_GuildManagementUITask.constructor);
		}
		LuaObject.createTypeMetatable(l, Lua_BlackJack_ProjectL_UI_GuildManagementUITask.<>f__mg$cache46, typeof(GuildManagementUITask), typeof(UITask));
	}

	// Token: 0x04014761 RID: 83809
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache0;

	// Token: 0x04014762 RID: 83810
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1;

	// Token: 0x04014763 RID: 83811
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2;

	// Token: 0x04014764 RID: 83812
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3;

	// Token: 0x04014765 RID: 83813
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache4;

	// Token: 0x04014766 RID: 83814
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache5;

	// Token: 0x04014767 RID: 83815
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache6;

	// Token: 0x04014768 RID: 83816
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache7;

	// Token: 0x04014769 RID: 83817
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache8;

	// Token: 0x0401476A RID: 83818
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache9;

	// Token: 0x0401476B RID: 83819
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheA;

	// Token: 0x0401476C RID: 83820
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheB;

	// Token: 0x0401476D RID: 83821
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheC;

	// Token: 0x0401476E RID: 83822
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheD;

	// Token: 0x0401476F RID: 83823
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheE;

	// Token: 0x04014770 RID: 83824
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheF;

	// Token: 0x04014771 RID: 83825
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache10;

	// Token: 0x04014772 RID: 83826
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache11;

	// Token: 0x04014773 RID: 83827
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache12;

	// Token: 0x04014774 RID: 83828
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache13;

	// Token: 0x04014775 RID: 83829
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache14;

	// Token: 0x04014776 RID: 83830
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache15;

	// Token: 0x04014777 RID: 83831
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache16;

	// Token: 0x04014778 RID: 83832
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache17;

	// Token: 0x04014779 RID: 83833
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache18;

	// Token: 0x0401477A RID: 83834
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache19;

	// Token: 0x0401477B RID: 83835
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1A;

	// Token: 0x0401477C RID: 83836
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1B;

	// Token: 0x0401477D RID: 83837
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1C;

	// Token: 0x0401477E RID: 83838
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1D;

	// Token: 0x0401477F RID: 83839
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1E;

	// Token: 0x04014780 RID: 83840
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1F;

	// Token: 0x04014781 RID: 83841
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache20;

	// Token: 0x04014782 RID: 83842
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache21;

	// Token: 0x04014783 RID: 83843
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache22;

	// Token: 0x04014784 RID: 83844
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache23;

	// Token: 0x04014785 RID: 83845
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache24;

	// Token: 0x04014786 RID: 83846
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache25;

	// Token: 0x04014787 RID: 83847
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache26;

	// Token: 0x04014788 RID: 83848
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache27;

	// Token: 0x04014789 RID: 83849
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache28;

	// Token: 0x0401478A RID: 83850
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache29;

	// Token: 0x0401478B RID: 83851
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2A;

	// Token: 0x0401478C RID: 83852
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2B;

	// Token: 0x0401478D RID: 83853
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2C;

	// Token: 0x0401478E RID: 83854
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2D;

	// Token: 0x0401478F RID: 83855
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2E;

	// Token: 0x04014790 RID: 83856
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2F;

	// Token: 0x04014791 RID: 83857
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache30;

	// Token: 0x04014792 RID: 83858
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache31;

	// Token: 0x04014793 RID: 83859
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache32;

	// Token: 0x04014794 RID: 83860
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache33;

	// Token: 0x04014795 RID: 83861
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache34;

	// Token: 0x04014796 RID: 83862
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache35;

	// Token: 0x04014797 RID: 83863
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache36;

	// Token: 0x04014798 RID: 83864
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache37;

	// Token: 0x04014799 RID: 83865
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache38;

	// Token: 0x0401479A RID: 83866
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache39;

	// Token: 0x0401479B RID: 83867
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3A;

	// Token: 0x0401479C RID: 83868
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3B;

	// Token: 0x0401479D RID: 83869
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3C;

	// Token: 0x0401479E RID: 83870
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3D;

	// Token: 0x0401479F RID: 83871
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3E;

	// Token: 0x040147A0 RID: 83872
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3F;

	// Token: 0x040147A1 RID: 83873
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache40;

	// Token: 0x040147A2 RID: 83874
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache41;

	// Token: 0x040147A3 RID: 83875
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache42;

	// Token: 0x040147A4 RID: 83876
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache43;

	// Token: 0x040147A5 RID: 83877
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache44;

	// Token: 0x040147A6 RID: 83878
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache45;

	// Token: 0x040147A7 RID: 83879
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache46;
}
