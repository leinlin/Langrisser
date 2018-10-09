using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using BlackJack.BJFramework.Runtime.UI;
using BlackJack.ConfigData;
using BlackJack.ProjectL.Common;
using BlackJack.ProjectL.UI;
using SLua;
using UnityEngine.Scripting;

// Token: 0x020015A0 RID: 5536
[Preserve]
public class Lua_BlackJack_ProjectL_UI_TeamRoomInviteUITask : LuaObject
{
	// Token: 0x06021824 RID: 137252 RVA: 0x00B57A1C File Offset: 0x00B55C1C
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int constructor(IntPtr l)
	{
		int result;
		try
		{
			string name;
			LuaObject.checkType(l, 2, out name);
			TeamRoomInviteUITask o = new TeamRoomInviteUITask(name);
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

	// Token: 0x06021825 RID: 137253 RVA: 0x00B57A70 File Offset: 0x00B55C70
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int PrepareForStartOrResume(IntPtr l)
	{
		int result;
		try
		{
			TeamRoomInviteUITask teamRoomInviteUITask = (TeamRoomInviteUITask)LuaObject.checkSelf(l);
			UIIntent intent;
			LuaObject.checkType<UIIntent>(l, 2, out intent);
			Action<bool> onPrepareEnd;
			LuaObject.checkDelegate<Action<bool>>(l, 3, out onPrepareEnd);
			teamRoomInviteUITask.PrepareForStartOrResume(intent, onPrepareEnd);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06021826 RID: 137254 RVA: 0x00B57AD4 File Offset: 0x00B55CD4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int GetGuildInfo(IntPtr l)
	{
		int result;
		try
		{
			TeamRoomInviteUITask teamRoomInviteUITask = (TeamRoomInviteUITask)LuaObject.checkSelf(l);
			Action<bool> onPrepareEnd;
			LuaObject.checkDelegate<Action<bool>>(l, 2, out onPrepareEnd);
			teamRoomInviteUITask.m_luaExportHelper.GetGuildInfo(onPrepareEnd);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06021827 RID: 137255 RVA: 0x00B57B30 File Offset: 0x00B55D30
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int InitAllUIControllers(IntPtr l)
	{
		int result;
		try
		{
			TeamRoomInviteUITask teamRoomInviteUITask = (TeamRoomInviteUITask)LuaObject.checkSelf(l);
			teamRoomInviteUITask.m_luaExportHelper.InitAllUIControllers();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06021828 RID: 137256 RVA: 0x00B57B84 File Offset: 0x00B55D84
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int ClearAllContextAndRes(IntPtr l)
	{
		int result;
		try
		{
			TeamRoomInviteUITask teamRoomInviteUITask = (TeamRoomInviteUITask)LuaObject.checkSelf(l);
			teamRoomInviteUITask.m_luaExportHelper.ClearAllContextAndRes();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06021829 RID: 137257 RVA: 0x00B57BD8 File Offset: 0x00B55DD8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int InitTeamRoomInviteUIController(IntPtr l)
	{
		int result;
		try
		{
			TeamRoomInviteUITask teamRoomInviteUITask = (TeamRoomInviteUITask)LuaObject.checkSelf(l);
			teamRoomInviteUITask.m_luaExportHelper.InitTeamRoomInviteUIController();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0602182A RID: 137258 RVA: 0x00B57C2C File Offset: 0x00B55E2C
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int UninitTeamRoomInviteUIController(IntPtr l)
	{
		int result;
		try
		{
			TeamRoomInviteUITask teamRoomInviteUITask = (TeamRoomInviteUITask)LuaObject.checkSelf(l);
			teamRoomInviteUITask.m_luaExportHelper.UninitTeamRoomInviteUIController();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0602182B RID: 137259 RVA: 0x00B57C80 File Offset: 0x00B55E80
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int UpdateView(IntPtr l)
	{
		int result;
		try
		{
			TeamRoomInviteUITask teamRoomInviteUITask = (TeamRoomInviteUITask)LuaObject.checkSelf(l);
			teamRoomInviteUITask.m_luaExportHelper.UpdateView();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0602182C RID: 137260 RVA: 0x00B57CD4 File Offset: 0x00B55ED4
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int StartTeamRoomInviteeInfoGetNetTask(IntPtr l)
	{
		int result;
		try
		{
			TeamRoomInviteUITask teamRoomInviteUITask = (TeamRoomInviteUITask)LuaObject.checkSelf(l);
			List<string> userIds;
			LuaObject.checkType<List<string>>(l, 2, out userIds);
			TeamRoomInviteeInfoType infoType;
			LuaObject.checkEnum<TeamRoomInviteeInfoType>(l, 3, out infoType);
			teamRoomInviteUITask.m_luaExportHelper.StartTeamRoomInviteeInfoGetNetTask(userIds, infoType);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0602182D RID: 137261 RVA: 0x00B57D40 File Offset: 0x00B55F40
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int IsUserInTeamRoom(IntPtr l)
	{
		int result;
		try
		{
			TeamRoomInviteUITask teamRoomInviteUITask = (TeamRoomInviteUITask)LuaObject.checkSelf(l);
			string userId;
			LuaObject.checkType(l, 2, out userId);
			bool b = teamRoomInviteUITask.m_luaExportHelper.IsUserInTeamRoom(userId);
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

	// Token: 0x0602182E RID: 137262 RVA: 0x00B57DA8 File Offset: 0x00B55FA8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int CloseAndReturnPrevUITask(IntPtr l)
	{
		int result;
		try
		{
			TeamRoomInviteUITask teamRoomInviteUITask = (TeamRoomInviteUITask)LuaObject.checkSelf(l);
			teamRoomInviteUITask.m_luaExportHelper.CloseAndReturnPrevUITask();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0602182F RID: 137263 RVA: 0x00B57DFC File Offset: 0x00B55FFC
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int UpdateOnlinePlayerStatus(IntPtr l)
	{
		int result;
		try
		{
			TeamRoomInviteUITask teamRoomInviteUITask = (TeamRoomInviteUITask)LuaObject.checkSelf(l);
			string userId;
			LuaObject.checkType(l, 2, out userId);
			TeamRoomPlayerInviteState inviteState;
			LuaObject.checkEnum<TeamRoomPlayerInviteState>(l, 3, out inviteState);
			teamRoomInviteUITask.m_luaExportHelper.UpdateOnlinePlayerStatus(userId, inviteState);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06021830 RID: 137264 RVA: 0x00B57E68 File Offset: 0x00B56068
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int GetOnlinePlayerStatus(IntPtr l)
	{
		int result;
		try
		{
			TeamRoomInviteUITask teamRoomInviteUITask = (TeamRoomInviteUITask)LuaObject.checkSelf(l);
			string userId;
			LuaObject.checkType(l, 2, out userId);
			TeamRoomInviteUITask.OnlinePlayerStatus onlinePlayerStatus = teamRoomInviteUITask.m_luaExportHelper.GetOnlinePlayerStatus(userId);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, onlinePlayerStatus);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06021831 RID: 137265 RVA: 0x00B57ED0 File Offset: 0x00B560D0
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int TeamRoomInviteUIController_OnConfirm(IntPtr l)
	{
		int result;
		try
		{
			TeamRoomInviteUITask teamRoomInviteUITask = (TeamRoomInviteUITask)LuaObject.checkSelf(l);
			List<string> playerUserIds;
			LuaObject.checkType<List<string>>(l, 2, out playerUserIds);
			teamRoomInviteUITask.m_luaExportHelper.TeamRoomInviteUIController_OnConfirm(playerUserIds);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06021832 RID: 137266 RVA: 0x00B57F2C File Offset: 0x00B5612C
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int TeamRoomInviteUIController_OnCancel(IntPtr l)
	{
		int result;
		try
		{
			TeamRoomInviteUITask teamRoomInviteUITask = (TeamRoomInviteUITask)LuaObject.checkSelf(l);
			teamRoomInviteUITask.m_luaExportHelper.TeamRoomInviteUIController_OnCancel();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06021833 RID: 137267 RVA: 0x00B57F80 File Offset: 0x00B56180
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int TeamRoomInviteUIController_OnChangePlayerType(IntPtr l)
	{
		int result;
		try
		{
			TeamRoomInviteUITask teamRoomInviteUITask = (TeamRoomInviteUITask)LuaObject.checkSelf(l);
			TeamRoomInvitePlayerType playerType;
			LuaObject.checkEnum<TeamRoomInvitePlayerType>(l, 2, out playerType);
			teamRoomInviteUITask.m_luaExportHelper.TeamRoomInviteUIController_OnChangePlayerType(playerType);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06021834 RID: 137268 RVA: 0x00B57FDC File Offset: 0x00B561DC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int PlayerContext_OnTeamRoomInviteeInfoNtf(IntPtr l)
	{
		int result;
		try
		{
			TeamRoomInviteUITask teamRoomInviteUITask = (TeamRoomInviteUITask)LuaObject.checkSelf(l);
			string inviteeUserId;
			LuaObject.checkType(l, 2, out inviteeUserId);
			int levelUnlocked;
			LuaObject.checkType(l, 3, out levelUnlocked);
			int guildMassiveCombatAvailable;
			LuaObject.checkType(l, 4, out guildMassiveCombatAvailable);
			teamRoomInviteUITask.m_luaExportHelper.PlayerContext_OnTeamRoomInviteeInfoNtf(inviteeUserId, levelUnlocked, guildMassiveCombatAvailable);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06021835 RID: 137269 RVA: 0x00B58054 File Offset: 0x00B56254
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_OnStart(IntPtr l)
	{
		int result;
		try
		{
			TeamRoomInviteUITask teamRoomInviteUITask = (TeamRoomInviteUITask)LuaObject.checkSelf(l);
			UIIntent intent;
			LuaObject.checkType<UIIntent>(l, 2, out intent);
			bool b = teamRoomInviteUITask.m_luaExportHelper.__callBase_OnStart(intent);
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

	// Token: 0x06021836 RID: 137270 RVA: 0x00B580BC File Offset: 0x00B562BC
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int __callBase_OnStop(IntPtr l)
	{
		int result;
		try
		{
			TeamRoomInviteUITask teamRoomInviteUITask = (TeamRoomInviteUITask)LuaObject.checkSelf(l);
			teamRoomInviteUITask.m_luaExportHelper.__callBase_OnStop();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06021837 RID: 137271 RVA: 0x00B58110 File Offset: 0x00B56310
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int __callBase_OnPause(IntPtr l)
	{
		int result;
		try
		{
			TeamRoomInviteUITask teamRoomInviteUITask = (TeamRoomInviteUITask)LuaObject.checkSelf(l);
			teamRoomInviteUITask.m_luaExportHelper.__callBase_OnPause();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06021838 RID: 137272 RVA: 0x00B58164 File Offset: 0x00B56364
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int __callBase_OnResume(IntPtr l)
	{
		int result;
		try
		{
			TeamRoomInviteUITask teamRoomInviteUITask = (TeamRoomInviteUITask)LuaObject.checkSelf(l);
			UIIntent intent;
			LuaObject.checkType<UIIntent>(l, 2, out intent);
			bool b = teamRoomInviteUITask.m_luaExportHelper.__callBase_OnResume(intent);
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

	// Token: 0x06021839 RID: 137273 RVA: 0x00B581CC File Offset: 0x00B563CC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_OnNewIntent(IntPtr l)
	{
		int result;
		try
		{
			TeamRoomInviteUITask teamRoomInviteUITask = (TeamRoomInviteUITask)LuaObject.checkSelf(l);
			UIIntent intent;
			LuaObject.checkType<UIIntent>(l, 2, out intent);
			bool b = teamRoomInviteUITask.m_luaExportHelper.__callBase_OnNewIntent(intent);
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

	// Token: 0x0602183A RID: 137274 RVA: 0x00B58234 File Offset: 0x00B56434
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int __callBase_EnableUIInput(IntPtr l)
	{
		int result;
		try
		{
			TeamRoomInviteUITask teamRoomInviteUITask = (TeamRoomInviteUITask)LuaObject.checkSelf(l);
			bool isEnable;
			LuaObject.checkType(l, 2, out isEnable);
			bool? isGlobalEnable;
			LuaObject.checkNullable<bool>(l, 3, out isGlobalEnable);
			teamRoomInviteUITask.m_luaExportHelper.__callBase_EnableUIInput(isEnable, isGlobalEnable);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0602183B RID: 137275 RVA: 0x00B582A0 File Offset: 0x00B564A0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_IsNeedLoadDynamicRes(IntPtr l)
	{
		int result;
		try
		{
			TeamRoomInviteUITask teamRoomInviteUITask = (TeamRoomInviteUITask)LuaObject.checkSelf(l);
			bool b = teamRoomInviteUITask.m_luaExportHelper.__callBase_IsNeedLoadDynamicRes();
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

	// Token: 0x0602183C RID: 137276 RVA: 0x00B582FC File Offset: 0x00B564FC
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int __callBase_CollectAllDynamicResForLoad(IntPtr l)
	{
		int result;
		try
		{
			TeamRoomInviteUITask teamRoomInviteUITask = (TeamRoomInviteUITask)LuaObject.checkSelf(l);
			List<string> o = teamRoomInviteUITask.m_luaExportHelper.__callBase_CollectAllDynamicResForLoad();
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

	// Token: 0x0602183D RID: 137277 RVA: 0x00B58358 File Offset: 0x00B56558
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int __callBase_RegisterPlayerContextEvents(IntPtr l)
	{
		int result;
		try
		{
			TeamRoomInviteUITask teamRoomInviteUITask = (TeamRoomInviteUITask)LuaObject.checkSelf(l);
			teamRoomInviteUITask.m_luaExportHelper.__callBase_RegisterPlayerContextEvents();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0602183E RID: 137278 RVA: 0x00B583AC File Offset: 0x00B565AC
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int __callBase_UnregisterPlayerContextEvents(IntPtr l)
	{
		int result;
		try
		{
			TeamRoomInviteUITask teamRoomInviteUITask = (TeamRoomInviteUITask)LuaObject.checkSelf(l);
			teamRoomInviteUITask.m_luaExportHelper.__callBase_UnregisterPlayerContextEvents();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0602183F RID: 137279 RVA: 0x00B58400 File Offset: 0x00B56600
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_PostUpdateView(IntPtr l)
	{
		int result;
		try
		{
			TeamRoomInviteUITask teamRoomInviteUITask = (TeamRoomInviteUITask)LuaObject.checkSelf(l);
			teamRoomInviteUITask.m_luaExportHelper.__callBase_PostUpdateView();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06021840 RID: 137280 RVA: 0x00B58454 File Offset: 0x00B56654
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int __callBase_CollectPreloadResourceList(IntPtr l)
	{
		int result;
		try
		{
			TeamRoomInviteUITask teamRoomInviteUITask = (TeamRoomInviteUITask)LuaObject.checkSelf(l);
			teamRoomInviteUITask.m_luaExportHelper.__callBase_CollectPreloadResourceList();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06021841 RID: 137281 RVA: 0x00B584A8 File Offset: 0x00B566A8
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int __callBase_ClearAssetList(IntPtr l)
	{
		int result;
		try
		{
			TeamRoomInviteUITask teamRoomInviteUITask = (TeamRoomInviteUITask)LuaObject.checkSelf(l);
			teamRoomInviteUITask.m_luaExportHelper.__callBase_ClearAssetList();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06021842 RID: 137282 RVA: 0x00B584FC File Offset: 0x00B566FC
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int __callBase_CollectAsset(IntPtr l)
	{
		int result;
		try
		{
			TeamRoomInviteUITask teamRoomInviteUITask = (TeamRoomInviteUITask)LuaObject.checkSelf(l);
			string assetName;
			LuaObject.checkType(l, 2, out assetName);
			teamRoomInviteUITask.m_luaExportHelper.__callBase_CollectAsset(assetName);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06021843 RID: 137283 RVA: 0x00B58558 File Offset: 0x00B56758
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_CollectSpriteAsset(IntPtr l)
	{
		int result;
		try
		{
			TeamRoomInviteUITask teamRoomInviteUITask = (TeamRoomInviteUITask)LuaObject.checkSelf(l);
			string assetName;
			LuaObject.checkType(l, 2, out assetName);
			teamRoomInviteUITask.m_luaExportHelper.__callBase_CollectSpriteAsset(assetName);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06021844 RID: 137284 RVA: 0x00B585B4 File Offset: 0x00B567B4
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int __callBase_CollectFxAsset(IntPtr l)
	{
		int result;
		try
		{
			TeamRoomInviteUITask teamRoomInviteUITask = (TeamRoomInviteUITask)LuaObject.checkSelf(l);
			string assetName;
			LuaObject.checkType(l, 2, out assetName);
			teamRoomInviteUITask.m_luaExportHelper.__callBase_CollectFxAsset(assetName);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06021845 RID: 137285 RVA: 0x00B58610 File Offset: 0x00B56810
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_StartLoadCustomAssets(IntPtr l)
	{
		int result;
		try
		{
			TeamRoomInviteUITask teamRoomInviteUITask = (TeamRoomInviteUITask)LuaObject.checkSelf(l);
			Action onLoadCompleted;
			LuaObject.checkDelegate<Action>(l, 2, out onLoadCompleted);
			teamRoomInviteUITask.m_luaExportHelper.__callBase_StartLoadCustomAssets(onLoadCompleted);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06021846 RID: 137286 RVA: 0x00B5866C File Offset: 0x00B5686C
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int __callBase_IsLoadingCustomAssets(IntPtr l)
	{
		int result;
		try
		{
			TeamRoomInviteUITask teamRoomInviteUITask = (TeamRoomInviteUITask)LuaObject.checkSelf(l);
			bool b = teamRoomInviteUITask.m_luaExportHelper.__callBase_IsLoadingCustomAssets();
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

	// Token: 0x06021847 RID: 137287 RVA: 0x00B586C8 File Offset: 0x00B568C8
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int __callBase_IsPipeLineRunning(IntPtr l)
	{
		int result;
		try
		{
			TeamRoomInviteUITask teamRoomInviteUITask = (TeamRoomInviteUITask)LuaObject.checkSelf(l);
			bool b = teamRoomInviteUITask.m_luaExportHelper.__callBase_IsPipeLineRunning();
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

	// Token: 0x06021848 RID: 137288 RVA: 0x00B58724 File Offset: 0x00B56924
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_IsOpeningUI(IntPtr l)
	{
		int result;
		try
		{
			TeamRoomInviteUITask teamRoomInviteUITask = (TeamRoomInviteUITask)LuaObject.checkSelf(l);
			bool b = teamRoomInviteUITask.m_luaExportHelper.__callBase_IsOpeningUI();
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

	// Token: 0x06021849 RID: 137289 RVA: 0x00B58780 File Offset: 0x00B56980
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int __callBase_ReturnPrevUITask(IntPtr l)
	{
		int result;
		try
		{
			TeamRoomInviteUITask teamRoomInviteUITask = (TeamRoomInviteUITask)LuaObject.checkSelf(l);
			UITaskBase o = teamRoomInviteUITask.m_luaExportHelper.__callBase_ReturnPrevUITask();
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

	// Token: 0x0602184A RID: 137290 RVA: 0x00B587DC File Offset: 0x00B569DC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_ClearUnusedDynamicResourceCache(IntPtr l)
	{
		int result;
		try
		{
			TeamRoomInviteUITask teamRoomInviteUITask = (TeamRoomInviteUITask)LuaObject.checkSelf(l);
			teamRoomInviteUITask.m_luaExportHelper.__callBase_ClearUnusedDynamicResourceCache();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0602184B RID: 137291 RVA: 0x00B58830 File Offset: 0x00B56A30
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_OnMemoryWarning(IntPtr l)
	{
		int result;
		try
		{
			TeamRoomInviteUITask teamRoomInviteUITask = (TeamRoomInviteUITask)LuaObject.checkSelf(l);
			teamRoomInviteUITask.m_luaExportHelper.__callBase_OnMemoryWarning();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0602184C RID: 137292 RVA: 0x00B58884 File Offset: 0x00B56A84
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int ComparePlayerLevel_s(IntPtr l)
	{
		int result;
		try
		{
			UserSummary u;
			LuaObject.checkType<UserSummary>(l, 1, out u);
			UserSummary u2;
			LuaObject.checkType<UserSummary>(l, 2, out u2);
			int i = TeamRoomInviteUITask.LuaExportHelper.ComparePlayerLevel(u, u2);
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

	// Token: 0x0602184D RID: 137293 RVA: 0x00B588E4 File Offset: 0x00B56AE4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_layerDescArray(IntPtr l)
	{
		int result;
		try
		{
			TeamRoomInviteUITask teamRoomInviteUITask = (TeamRoomInviteUITask)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, teamRoomInviteUITask.m_luaExportHelper.m_layerDescArray);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0602184E RID: 137294 RVA: 0x00B5893C File Offset: 0x00B56B3C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_layerDescArray(IntPtr l)
	{
		int result;
		try
		{
			TeamRoomInviteUITask teamRoomInviteUITask = (TeamRoomInviteUITask)LuaObject.checkSelf(l);
			UITaskBase.LayerDesc[] layerDescArray;
			LuaObject.checkArray<UITaskBase.LayerDesc>(l, 2, out layerDescArray);
			teamRoomInviteUITask.m_luaExportHelper.m_layerDescArray = layerDescArray;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0602184F RID: 137295 RVA: 0x00B58998 File Offset: 0x00B56B98
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_uiCtrlDescArray(IntPtr l)
	{
		int result;
		try
		{
			TeamRoomInviteUITask teamRoomInviteUITask = (TeamRoomInviteUITask)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, teamRoomInviteUITask.m_luaExportHelper.m_uiCtrlDescArray);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06021850 RID: 137296 RVA: 0x00B589F0 File Offset: 0x00B56BF0
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_m_uiCtrlDescArray(IntPtr l)
	{
		int result;
		try
		{
			TeamRoomInviteUITask teamRoomInviteUITask = (TeamRoomInviteUITask)LuaObject.checkSelf(l);
			UITaskBase.UIControllerDesc[] uiCtrlDescArray;
			LuaObject.checkArray<UITaskBase.UIControllerDesc>(l, 2, out uiCtrlDescArray);
			teamRoomInviteUITask.m_luaExportHelper.m_uiCtrlDescArray = uiCtrlDescArray;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06021851 RID: 137297 RVA: 0x00B58A4C File Offset: 0x00B56C4C
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_m_teamRoomInviteUIController(IntPtr l)
	{
		int result;
		try
		{
			TeamRoomInviteUITask teamRoomInviteUITask = (TeamRoomInviteUITask)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, teamRoomInviteUITask.m_luaExportHelper.m_teamRoomInviteUIController);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06021852 RID: 137298 RVA: 0x00B58AA4 File Offset: 0x00B56CA4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_teamRoomInviteUIController(IntPtr l)
	{
		int result;
		try
		{
			TeamRoomInviteUITask teamRoomInviteUITask = (TeamRoomInviteUITask)LuaObject.checkSelf(l);
			TeamRoomInviteUIController teamRoomInviteUIController;
			LuaObject.checkType<TeamRoomInviteUIController>(l, 2, out teamRoomInviteUIController);
			teamRoomInviteUITask.m_luaExportHelper.m_teamRoomInviteUIController = teamRoomInviteUIController;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06021853 RID: 137299 RVA: 0x00B58B00 File Offset: 0x00B56D00
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_m_playerType(IntPtr l)
	{
		int result;
		try
		{
			TeamRoomInviteUITask teamRoomInviteUITask = (TeamRoomInviteUITask)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushEnum(l, (int)teamRoomInviteUITask.m_luaExportHelper.m_playerType);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06021854 RID: 137300 RVA: 0x00B58B58 File Offset: 0x00B56D58
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_playerType(IntPtr l)
	{
		int result;
		try
		{
			TeamRoomInviteUITask teamRoomInviteUITask = (TeamRoomInviteUITask)LuaObject.checkSelf(l);
			TeamRoomInvitePlayerType playerType;
			LuaObject.checkEnum<TeamRoomInvitePlayerType>(l, 2, out playerType);
			teamRoomInviteUITask.m_luaExportHelper.m_playerType = playerType;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06021855 RID: 137301 RVA: 0x00B58BB4 File Offset: 0x00B56DB4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_playerList(IntPtr l)
	{
		int result;
		try
		{
			TeamRoomInviteUITask teamRoomInviteUITask = (TeamRoomInviteUITask)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, teamRoomInviteUITask.m_luaExportHelper.m_playerList);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06021856 RID: 137302 RVA: 0x00B58C0C File Offset: 0x00B56E0C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_playerList(IntPtr l)
	{
		int result;
		try
		{
			TeamRoomInviteUITask teamRoomInviteUITask = (TeamRoomInviteUITask)LuaObject.checkSelf(l);
			List<UserSummary> playerList;
			LuaObject.checkType<List<UserSummary>>(l, 2, out playerList);
			teamRoomInviteUITask.m_luaExportHelper.m_playerList = playerList;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06021857 RID: 137303 RVA: 0x00B58C68 File Offset: 0x00B56E68
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_updateStatusUserIds(IntPtr l)
	{
		int result;
		try
		{
			TeamRoomInviteUITask teamRoomInviteUITask = (TeamRoomInviteUITask)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, teamRoomInviteUITask.m_luaExportHelper.m_updateStatusUserIds);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06021858 RID: 137304 RVA: 0x00B58CC0 File Offset: 0x00B56EC0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_updateStatusUserIds(IntPtr l)
	{
		int result;
		try
		{
			TeamRoomInviteUITask teamRoomInviteUITask = (TeamRoomInviteUITask)LuaObject.checkSelf(l);
			List<string> updateStatusUserIds;
			LuaObject.checkType<List<string>>(l, 2, out updateStatusUserIds);
			teamRoomInviteUITask.m_luaExportHelper.m_updateStatusUserIds = updateStatusUserIds;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06021859 RID: 137305 RVA: 0x00B58D1C File Offset: 0x00B56F1C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_onlinePlayersStatus(IntPtr l)
	{
		int result;
		try
		{
			TeamRoomInviteUITask teamRoomInviteUITask = (TeamRoomInviteUITask)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, teamRoomInviteUITask.m_luaExportHelper.m_onlinePlayersStatus);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0602185A RID: 137306 RVA: 0x00B58D74 File Offset: 0x00B56F74
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_onlinePlayersStatus(IntPtr l)
	{
		int result;
		try
		{
			TeamRoomInviteUITask teamRoomInviteUITask = (TeamRoomInviteUITask)LuaObject.checkSelf(l);
			List<TeamRoomInviteUITask.OnlinePlayerStatus> onlinePlayersStatus;
			LuaObject.checkType<List<TeamRoomInviteUITask.OnlinePlayerStatus>>(l, 2, out onlinePlayersStatus);
			teamRoomInviteUITask.m_luaExportHelper.m_onlinePlayersStatus = onlinePlayersStatus;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0602185B RID: 137307 RVA: 0x00B58DD0 File Offset: 0x00B56FD0
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_m_onlinePlayersStatusGameFunctionType(IntPtr l)
	{
		int result;
		try
		{
			TeamRoomInviteUITask teamRoomInviteUITask = (TeamRoomInviteUITask)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushEnum(l, (int)teamRoomInviteUITask.m_luaExportHelper.m_onlinePlayersStatusGameFunctionType);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0602185C RID: 137308 RVA: 0x00B58E28 File Offset: 0x00B57028
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_onlinePlayersStatusGameFunctionType(IntPtr l)
	{
		int result;
		try
		{
			TeamRoomInviteUITask teamRoomInviteUITask = (TeamRoomInviteUITask)LuaObject.checkSelf(l);
			GameFunctionType onlinePlayersStatusGameFunctionType;
			LuaObject.checkEnum<GameFunctionType>(l, 2, out onlinePlayersStatusGameFunctionType);
			teamRoomInviteUITask.m_luaExportHelper.m_onlinePlayersStatusGameFunctionType = onlinePlayersStatusGameFunctionType;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0602185D RID: 137309 RVA: 0x00B58E84 File Offset: 0x00B57084
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_onlinePlayersStatusLocationId(IntPtr l)
	{
		int result;
		try
		{
			TeamRoomInviteUITask teamRoomInviteUITask = (TeamRoomInviteUITask)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, teamRoomInviteUITask.m_luaExportHelper.m_onlinePlayersStatusLocationId);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0602185E RID: 137310 RVA: 0x00B58EDC File Offset: 0x00B570DC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_onlinePlayersStatusLocationId(IntPtr l)
	{
		int result;
		try
		{
			TeamRoomInviteUITask teamRoomInviteUITask = (TeamRoomInviteUITask)LuaObject.checkSelf(l);
			int onlinePlayersStatusLocationId;
			LuaObject.checkType(l, 2, out onlinePlayersStatusLocationId);
			teamRoomInviteUITask.m_luaExportHelper.m_onlinePlayersStatusLocationId = onlinePlayersStatusLocationId;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0602185F RID: 137311 RVA: 0x00B58F38 File Offset: 0x00B57138
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_LayerDescArray(IntPtr l)
	{
		int result;
		try
		{
			TeamRoomInviteUITask teamRoomInviteUITask = (TeamRoomInviteUITask)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, teamRoomInviteUITask.m_luaExportHelper.LayerDescArray);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06021860 RID: 137312 RVA: 0x00B58F90 File Offset: 0x00B57190
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_UICtrlDescArray(IntPtr l)
	{
		int result;
		try
		{
			TeamRoomInviteUITask teamRoomInviteUITask = (TeamRoomInviteUITask)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, teamRoomInviteUITask.m_luaExportHelper.UICtrlDescArray);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06021861 RID: 137313 RVA: 0x00B58FE8 File Offset: 0x00B571E8
	[Preserve]
	public static void reg(IntPtr l)
	{
		LuaObject.getTypeTable(l, "BlackJack.ProjectL.UI.TeamRoomInviteUITask");
		if (Lua_BlackJack_ProjectL_UI_TeamRoomInviteUITask.<>f__mg$cache0 == null)
		{
			Lua_BlackJack_ProjectL_UI_TeamRoomInviteUITask.<>f__mg$cache0 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_TeamRoomInviteUITask.PrepareForStartOrResume);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_TeamRoomInviteUITask.<>f__mg$cache0);
		if (Lua_BlackJack_ProjectL_UI_TeamRoomInviteUITask.<>f__mg$cache1 == null)
		{
			Lua_BlackJack_ProjectL_UI_TeamRoomInviteUITask.<>f__mg$cache1 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_TeamRoomInviteUITask.GetGuildInfo);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_TeamRoomInviteUITask.<>f__mg$cache1);
		if (Lua_BlackJack_ProjectL_UI_TeamRoomInviteUITask.<>f__mg$cache2 == null)
		{
			Lua_BlackJack_ProjectL_UI_TeamRoomInviteUITask.<>f__mg$cache2 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_TeamRoomInviteUITask.InitAllUIControllers);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_TeamRoomInviteUITask.<>f__mg$cache2);
		if (Lua_BlackJack_ProjectL_UI_TeamRoomInviteUITask.<>f__mg$cache3 == null)
		{
			Lua_BlackJack_ProjectL_UI_TeamRoomInviteUITask.<>f__mg$cache3 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_TeamRoomInviteUITask.ClearAllContextAndRes);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_TeamRoomInviteUITask.<>f__mg$cache3);
		if (Lua_BlackJack_ProjectL_UI_TeamRoomInviteUITask.<>f__mg$cache4 == null)
		{
			Lua_BlackJack_ProjectL_UI_TeamRoomInviteUITask.<>f__mg$cache4 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_TeamRoomInviteUITask.InitTeamRoomInviteUIController);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_TeamRoomInviteUITask.<>f__mg$cache4);
		if (Lua_BlackJack_ProjectL_UI_TeamRoomInviteUITask.<>f__mg$cache5 == null)
		{
			Lua_BlackJack_ProjectL_UI_TeamRoomInviteUITask.<>f__mg$cache5 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_TeamRoomInviteUITask.UninitTeamRoomInviteUIController);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_TeamRoomInviteUITask.<>f__mg$cache5);
		if (Lua_BlackJack_ProjectL_UI_TeamRoomInviteUITask.<>f__mg$cache6 == null)
		{
			Lua_BlackJack_ProjectL_UI_TeamRoomInviteUITask.<>f__mg$cache6 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_TeamRoomInviteUITask.UpdateView);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_TeamRoomInviteUITask.<>f__mg$cache6);
		if (Lua_BlackJack_ProjectL_UI_TeamRoomInviteUITask.<>f__mg$cache7 == null)
		{
			Lua_BlackJack_ProjectL_UI_TeamRoomInviteUITask.<>f__mg$cache7 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_TeamRoomInviteUITask.StartTeamRoomInviteeInfoGetNetTask);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_TeamRoomInviteUITask.<>f__mg$cache7);
		if (Lua_BlackJack_ProjectL_UI_TeamRoomInviteUITask.<>f__mg$cache8 == null)
		{
			Lua_BlackJack_ProjectL_UI_TeamRoomInviteUITask.<>f__mg$cache8 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_TeamRoomInviteUITask.IsUserInTeamRoom);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_TeamRoomInviteUITask.<>f__mg$cache8);
		if (Lua_BlackJack_ProjectL_UI_TeamRoomInviteUITask.<>f__mg$cache9 == null)
		{
			Lua_BlackJack_ProjectL_UI_TeamRoomInviteUITask.<>f__mg$cache9 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_TeamRoomInviteUITask.CloseAndReturnPrevUITask);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_TeamRoomInviteUITask.<>f__mg$cache9);
		if (Lua_BlackJack_ProjectL_UI_TeamRoomInviteUITask.<>f__mg$cacheA == null)
		{
			Lua_BlackJack_ProjectL_UI_TeamRoomInviteUITask.<>f__mg$cacheA = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_TeamRoomInviteUITask.UpdateOnlinePlayerStatus);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_TeamRoomInviteUITask.<>f__mg$cacheA);
		if (Lua_BlackJack_ProjectL_UI_TeamRoomInviteUITask.<>f__mg$cacheB == null)
		{
			Lua_BlackJack_ProjectL_UI_TeamRoomInviteUITask.<>f__mg$cacheB = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_TeamRoomInviteUITask.GetOnlinePlayerStatus);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_TeamRoomInviteUITask.<>f__mg$cacheB);
		if (Lua_BlackJack_ProjectL_UI_TeamRoomInviteUITask.<>f__mg$cacheC == null)
		{
			Lua_BlackJack_ProjectL_UI_TeamRoomInviteUITask.<>f__mg$cacheC = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_TeamRoomInviteUITask.TeamRoomInviteUIController_OnConfirm);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_TeamRoomInviteUITask.<>f__mg$cacheC);
		if (Lua_BlackJack_ProjectL_UI_TeamRoomInviteUITask.<>f__mg$cacheD == null)
		{
			Lua_BlackJack_ProjectL_UI_TeamRoomInviteUITask.<>f__mg$cacheD = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_TeamRoomInviteUITask.TeamRoomInviteUIController_OnCancel);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_TeamRoomInviteUITask.<>f__mg$cacheD);
		if (Lua_BlackJack_ProjectL_UI_TeamRoomInviteUITask.<>f__mg$cacheE == null)
		{
			Lua_BlackJack_ProjectL_UI_TeamRoomInviteUITask.<>f__mg$cacheE = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_TeamRoomInviteUITask.TeamRoomInviteUIController_OnChangePlayerType);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_TeamRoomInviteUITask.<>f__mg$cacheE);
		if (Lua_BlackJack_ProjectL_UI_TeamRoomInviteUITask.<>f__mg$cacheF == null)
		{
			Lua_BlackJack_ProjectL_UI_TeamRoomInviteUITask.<>f__mg$cacheF = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_TeamRoomInviteUITask.PlayerContext_OnTeamRoomInviteeInfoNtf);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_TeamRoomInviteUITask.<>f__mg$cacheF);
		if (Lua_BlackJack_ProjectL_UI_TeamRoomInviteUITask.<>f__mg$cache10 == null)
		{
			Lua_BlackJack_ProjectL_UI_TeamRoomInviteUITask.<>f__mg$cache10 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_TeamRoomInviteUITask.__callBase_OnStart);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_TeamRoomInviteUITask.<>f__mg$cache10);
		if (Lua_BlackJack_ProjectL_UI_TeamRoomInviteUITask.<>f__mg$cache11 == null)
		{
			Lua_BlackJack_ProjectL_UI_TeamRoomInviteUITask.<>f__mg$cache11 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_TeamRoomInviteUITask.__callBase_OnStop);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_TeamRoomInviteUITask.<>f__mg$cache11);
		if (Lua_BlackJack_ProjectL_UI_TeamRoomInviteUITask.<>f__mg$cache12 == null)
		{
			Lua_BlackJack_ProjectL_UI_TeamRoomInviteUITask.<>f__mg$cache12 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_TeamRoomInviteUITask.__callBase_OnPause);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_TeamRoomInviteUITask.<>f__mg$cache12);
		if (Lua_BlackJack_ProjectL_UI_TeamRoomInviteUITask.<>f__mg$cache13 == null)
		{
			Lua_BlackJack_ProjectL_UI_TeamRoomInviteUITask.<>f__mg$cache13 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_TeamRoomInviteUITask.__callBase_OnResume);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_TeamRoomInviteUITask.<>f__mg$cache13);
		if (Lua_BlackJack_ProjectL_UI_TeamRoomInviteUITask.<>f__mg$cache14 == null)
		{
			Lua_BlackJack_ProjectL_UI_TeamRoomInviteUITask.<>f__mg$cache14 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_TeamRoomInviteUITask.__callBase_OnNewIntent);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_TeamRoomInviteUITask.<>f__mg$cache14);
		if (Lua_BlackJack_ProjectL_UI_TeamRoomInviteUITask.<>f__mg$cache15 == null)
		{
			Lua_BlackJack_ProjectL_UI_TeamRoomInviteUITask.<>f__mg$cache15 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_TeamRoomInviteUITask.__callBase_EnableUIInput);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_TeamRoomInviteUITask.<>f__mg$cache15);
		if (Lua_BlackJack_ProjectL_UI_TeamRoomInviteUITask.<>f__mg$cache16 == null)
		{
			Lua_BlackJack_ProjectL_UI_TeamRoomInviteUITask.<>f__mg$cache16 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_TeamRoomInviteUITask.__callBase_IsNeedLoadDynamicRes);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_TeamRoomInviteUITask.<>f__mg$cache16);
		if (Lua_BlackJack_ProjectL_UI_TeamRoomInviteUITask.<>f__mg$cache17 == null)
		{
			Lua_BlackJack_ProjectL_UI_TeamRoomInviteUITask.<>f__mg$cache17 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_TeamRoomInviteUITask.__callBase_CollectAllDynamicResForLoad);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_TeamRoomInviteUITask.<>f__mg$cache17);
		if (Lua_BlackJack_ProjectL_UI_TeamRoomInviteUITask.<>f__mg$cache18 == null)
		{
			Lua_BlackJack_ProjectL_UI_TeamRoomInviteUITask.<>f__mg$cache18 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_TeamRoomInviteUITask.__callBase_RegisterPlayerContextEvents);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_TeamRoomInviteUITask.<>f__mg$cache18);
		if (Lua_BlackJack_ProjectL_UI_TeamRoomInviteUITask.<>f__mg$cache19 == null)
		{
			Lua_BlackJack_ProjectL_UI_TeamRoomInviteUITask.<>f__mg$cache19 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_TeamRoomInviteUITask.__callBase_UnregisterPlayerContextEvents);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_TeamRoomInviteUITask.<>f__mg$cache19);
		if (Lua_BlackJack_ProjectL_UI_TeamRoomInviteUITask.<>f__mg$cache1A == null)
		{
			Lua_BlackJack_ProjectL_UI_TeamRoomInviteUITask.<>f__mg$cache1A = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_TeamRoomInviteUITask.__callBase_PostUpdateView);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_TeamRoomInviteUITask.<>f__mg$cache1A);
		if (Lua_BlackJack_ProjectL_UI_TeamRoomInviteUITask.<>f__mg$cache1B == null)
		{
			Lua_BlackJack_ProjectL_UI_TeamRoomInviteUITask.<>f__mg$cache1B = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_TeamRoomInviteUITask.__callBase_CollectPreloadResourceList);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_TeamRoomInviteUITask.<>f__mg$cache1B);
		if (Lua_BlackJack_ProjectL_UI_TeamRoomInviteUITask.<>f__mg$cache1C == null)
		{
			Lua_BlackJack_ProjectL_UI_TeamRoomInviteUITask.<>f__mg$cache1C = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_TeamRoomInviteUITask.__callBase_ClearAssetList);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_TeamRoomInviteUITask.<>f__mg$cache1C);
		if (Lua_BlackJack_ProjectL_UI_TeamRoomInviteUITask.<>f__mg$cache1D == null)
		{
			Lua_BlackJack_ProjectL_UI_TeamRoomInviteUITask.<>f__mg$cache1D = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_TeamRoomInviteUITask.__callBase_CollectAsset);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_TeamRoomInviteUITask.<>f__mg$cache1D);
		if (Lua_BlackJack_ProjectL_UI_TeamRoomInviteUITask.<>f__mg$cache1E == null)
		{
			Lua_BlackJack_ProjectL_UI_TeamRoomInviteUITask.<>f__mg$cache1E = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_TeamRoomInviteUITask.__callBase_CollectSpriteAsset);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_TeamRoomInviteUITask.<>f__mg$cache1E);
		if (Lua_BlackJack_ProjectL_UI_TeamRoomInviteUITask.<>f__mg$cache1F == null)
		{
			Lua_BlackJack_ProjectL_UI_TeamRoomInviteUITask.<>f__mg$cache1F = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_TeamRoomInviteUITask.__callBase_CollectFxAsset);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_TeamRoomInviteUITask.<>f__mg$cache1F);
		if (Lua_BlackJack_ProjectL_UI_TeamRoomInviteUITask.<>f__mg$cache20 == null)
		{
			Lua_BlackJack_ProjectL_UI_TeamRoomInviteUITask.<>f__mg$cache20 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_TeamRoomInviteUITask.__callBase_StartLoadCustomAssets);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_TeamRoomInviteUITask.<>f__mg$cache20);
		if (Lua_BlackJack_ProjectL_UI_TeamRoomInviteUITask.<>f__mg$cache21 == null)
		{
			Lua_BlackJack_ProjectL_UI_TeamRoomInviteUITask.<>f__mg$cache21 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_TeamRoomInviteUITask.__callBase_IsLoadingCustomAssets);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_TeamRoomInviteUITask.<>f__mg$cache21);
		if (Lua_BlackJack_ProjectL_UI_TeamRoomInviteUITask.<>f__mg$cache22 == null)
		{
			Lua_BlackJack_ProjectL_UI_TeamRoomInviteUITask.<>f__mg$cache22 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_TeamRoomInviteUITask.__callBase_IsPipeLineRunning);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_TeamRoomInviteUITask.<>f__mg$cache22);
		if (Lua_BlackJack_ProjectL_UI_TeamRoomInviteUITask.<>f__mg$cache23 == null)
		{
			Lua_BlackJack_ProjectL_UI_TeamRoomInviteUITask.<>f__mg$cache23 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_TeamRoomInviteUITask.__callBase_IsOpeningUI);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_TeamRoomInviteUITask.<>f__mg$cache23);
		if (Lua_BlackJack_ProjectL_UI_TeamRoomInviteUITask.<>f__mg$cache24 == null)
		{
			Lua_BlackJack_ProjectL_UI_TeamRoomInviteUITask.<>f__mg$cache24 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_TeamRoomInviteUITask.__callBase_ReturnPrevUITask);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_TeamRoomInviteUITask.<>f__mg$cache24);
		if (Lua_BlackJack_ProjectL_UI_TeamRoomInviteUITask.<>f__mg$cache25 == null)
		{
			Lua_BlackJack_ProjectL_UI_TeamRoomInviteUITask.<>f__mg$cache25 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_TeamRoomInviteUITask.__callBase_ClearUnusedDynamicResourceCache);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_TeamRoomInviteUITask.<>f__mg$cache25);
		if (Lua_BlackJack_ProjectL_UI_TeamRoomInviteUITask.<>f__mg$cache26 == null)
		{
			Lua_BlackJack_ProjectL_UI_TeamRoomInviteUITask.<>f__mg$cache26 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_TeamRoomInviteUITask.__callBase_OnMemoryWarning);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_TeamRoomInviteUITask.<>f__mg$cache26);
		if (Lua_BlackJack_ProjectL_UI_TeamRoomInviteUITask.<>f__mg$cache27 == null)
		{
			Lua_BlackJack_ProjectL_UI_TeamRoomInviteUITask.<>f__mg$cache27 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_TeamRoomInviteUITask.ComparePlayerLevel_s);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_TeamRoomInviteUITask.<>f__mg$cache27);
		string name = "m_layerDescArray";
		if (Lua_BlackJack_ProjectL_UI_TeamRoomInviteUITask.<>f__mg$cache28 == null)
		{
			Lua_BlackJack_ProjectL_UI_TeamRoomInviteUITask.<>f__mg$cache28 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_TeamRoomInviteUITask.get_m_layerDescArray);
		}
		LuaCSFunction get = Lua_BlackJack_ProjectL_UI_TeamRoomInviteUITask.<>f__mg$cache28;
		if (Lua_BlackJack_ProjectL_UI_TeamRoomInviteUITask.<>f__mg$cache29 == null)
		{
			Lua_BlackJack_ProjectL_UI_TeamRoomInviteUITask.<>f__mg$cache29 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_TeamRoomInviteUITask.set_m_layerDescArray);
		}
		LuaObject.addMember(l, name, get, Lua_BlackJack_ProjectL_UI_TeamRoomInviteUITask.<>f__mg$cache29, true);
		string name2 = "m_uiCtrlDescArray";
		if (Lua_BlackJack_ProjectL_UI_TeamRoomInviteUITask.<>f__mg$cache2A == null)
		{
			Lua_BlackJack_ProjectL_UI_TeamRoomInviteUITask.<>f__mg$cache2A = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_TeamRoomInviteUITask.get_m_uiCtrlDescArray);
		}
		LuaCSFunction get2 = Lua_BlackJack_ProjectL_UI_TeamRoomInviteUITask.<>f__mg$cache2A;
		if (Lua_BlackJack_ProjectL_UI_TeamRoomInviteUITask.<>f__mg$cache2B == null)
		{
			Lua_BlackJack_ProjectL_UI_TeamRoomInviteUITask.<>f__mg$cache2B = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_TeamRoomInviteUITask.set_m_uiCtrlDescArray);
		}
		LuaObject.addMember(l, name2, get2, Lua_BlackJack_ProjectL_UI_TeamRoomInviteUITask.<>f__mg$cache2B, true);
		string name3 = "m_teamRoomInviteUIController";
		if (Lua_BlackJack_ProjectL_UI_TeamRoomInviteUITask.<>f__mg$cache2C == null)
		{
			Lua_BlackJack_ProjectL_UI_TeamRoomInviteUITask.<>f__mg$cache2C = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_TeamRoomInviteUITask.get_m_teamRoomInviteUIController);
		}
		LuaCSFunction get3 = Lua_BlackJack_ProjectL_UI_TeamRoomInviteUITask.<>f__mg$cache2C;
		if (Lua_BlackJack_ProjectL_UI_TeamRoomInviteUITask.<>f__mg$cache2D == null)
		{
			Lua_BlackJack_ProjectL_UI_TeamRoomInviteUITask.<>f__mg$cache2D = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_TeamRoomInviteUITask.set_m_teamRoomInviteUIController);
		}
		LuaObject.addMember(l, name3, get3, Lua_BlackJack_ProjectL_UI_TeamRoomInviteUITask.<>f__mg$cache2D, true);
		string name4 = "m_playerType";
		if (Lua_BlackJack_ProjectL_UI_TeamRoomInviteUITask.<>f__mg$cache2E == null)
		{
			Lua_BlackJack_ProjectL_UI_TeamRoomInviteUITask.<>f__mg$cache2E = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_TeamRoomInviteUITask.get_m_playerType);
		}
		LuaCSFunction get4 = Lua_BlackJack_ProjectL_UI_TeamRoomInviteUITask.<>f__mg$cache2E;
		if (Lua_BlackJack_ProjectL_UI_TeamRoomInviteUITask.<>f__mg$cache2F == null)
		{
			Lua_BlackJack_ProjectL_UI_TeamRoomInviteUITask.<>f__mg$cache2F = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_TeamRoomInviteUITask.set_m_playerType);
		}
		LuaObject.addMember(l, name4, get4, Lua_BlackJack_ProjectL_UI_TeamRoomInviteUITask.<>f__mg$cache2F, true);
		string name5 = "m_playerList";
		if (Lua_BlackJack_ProjectL_UI_TeamRoomInviteUITask.<>f__mg$cache30 == null)
		{
			Lua_BlackJack_ProjectL_UI_TeamRoomInviteUITask.<>f__mg$cache30 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_TeamRoomInviteUITask.get_m_playerList);
		}
		LuaCSFunction get5 = Lua_BlackJack_ProjectL_UI_TeamRoomInviteUITask.<>f__mg$cache30;
		if (Lua_BlackJack_ProjectL_UI_TeamRoomInviteUITask.<>f__mg$cache31 == null)
		{
			Lua_BlackJack_ProjectL_UI_TeamRoomInviteUITask.<>f__mg$cache31 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_TeamRoomInviteUITask.set_m_playerList);
		}
		LuaObject.addMember(l, name5, get5, Lua_BlackJack_ProjectL_UI_TeamRoomInviteUITask.<>f__mg$cache31, true);
		string name6 = "m_updateStatusUserIds";
		if (Lua_BlackJack_ProjectL_UI_TeamRoomInviteUITask.<>f__mg$cache32 == null)
		{
			Lua_BlackJack_ProjectL_UI_TeamRoomInviteUITask.<>f__mg$cache32 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_TeamRoomInviteUITask.get_m_updateStatusUserIds);
		}
		LuaCSFunction get6 = Lua_BlackJack_ProjectL_UI_TeamRoomInviteUITask.<>f__mg$cache32;
		if (Lua_BlackJack_ProjectL_UI_TeamRoomInviteUITask.<>f__mg$cache33 == null)
		{
			Lua_BlackJack_ProjectL_UI_TeamRoomInviteUITask.<>f__mg$cache33 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_TeamRoomInviteUITask.set_m_updateStatusUserIds);
		}
		LuaObject.addMember(l, name6, get6, Lua_BlackJack_ProjectL_UI_TeamRoomInviteUITask.<>f__mg$cache33, true);
		string name7 = "m_onlinePlayersStatus";
		if (Lua_BlackJack_ProjectL_UI_TeamRoomInviteUITask.<>f__mg$cache34 == null)
		{
			Lua_BlackJack_ProjectL_UI_TeamRoomInviteUITask.<>f__mg$cache34 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_TeamRoomInviteUITask.get_m_onlinePlayersStatus);
		}
		LuaCSFunction get7 = Lua_BlackJack_ProjectL_UI_TeamRoomInviteUITask.<>f__mg$cache34;
		if (Lua_BlackJack_ProjectL_UI_TeamRoomInviteUITask.<>f__mg$cache35 == null)
		{
			Lua_BlackJack_ProjectL_UI_TeamRoomInviteUITask.<>f__mg$cache35 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_TeamRoomInviteUITask.set_m_onlinePlayersStatus);
		}
		LuaObject.addMember(l, name7, get7, Lua_BlackJack_ProjectL_UI_TeamRoomInviteUITask.<>f__mg$cache35, true);
		string name8 = "m_onlinePlayersStatusGameFunctionType";
		if (Lua_BlackJack_ProjectL_UI_TeamRoomInviteUITask.<>f__mg$cache36 == null)
		{
			Lua_BlackJack_ProjectL_UI_TeamRoomInviteUITask.<>f__mg$cache36 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_TeamRoomInviteUITask.get_m_onlinePlayersStatusGameFunctionType);
		}
		LuaCSFunction get8 = Lua_BlackJack_ProjectL_UI_TeamRoomInviteUITask.<>f__mg$cache36;
		if (Lua_BlackJack_ProjectL_UI_TeamRoomInviteUITask.<>f__mg$cache37 == null)
		{
			Lua_BlackJack_ProjectL_UI_TeamRoomInviteUITask.<>f__mg$cache37 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_TeamRoomInviteUITask.set_m_onlinePlayersStatusGameFunctionType);
		}
		LuaObject.addMember(l, name8, get8, Lua_BlackJack_ProjectL_UI_TeamRoomInviteUITask.<>f__mg$cache37, true);
		string name9 = "m_onlinePlayersStatusLocationId";
		if (Lua_BlackJack_ProjectL_UI_TeamRoomInviteUITask.<>f__mg$cache38 == null)
		{
			Lua_BlackJack_ProjectL_UI_TeamRoomInviteUITask.<>f__mg$cache38 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_TeamRoomInviteUITask.get_m_onlinePlayersStatusLocationId);
		}
		LuaCSFunction get9 = Lua_BlackJack_ProjectL_UI_TeamRoomInviteUITask.<>f__mg$cache38;
		if (Lua_BlackJack_ProjectL_UI_TeamRoomInviteUITask.<>f__mg$cache39 == null)
		{
			Lua_BlackJack_ProjectL_UI_TeamRoomInviteUITask.<>f__mg$cache39 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_TeamRoomInviteUITask.set_m_onlinePlayersStatusLocationId);
		}
		LuaObject.addMember(l, name9, get9, Lua_BlackJack_ProjectL_UI_TeamRoomInviteUITask.<>f__mg$cache39, true);
		string name10 = "LayerDescArray";
		if (Lua_BlackJack_ProjectL_UI_TeamRoomInviteUITask.<>f__mg$cache3A == null)
		{
			Lua_BlackJack_ProjectL_UI_TeamRoomInviteUITask.<>f__mg$cache3A = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_TeamRoomInviteUITask.get_LayerDescArray);
		}
		LuaObject.addMember(l, name10, Lua_BlackJack_ProjectL_UI_TeamRoomInviteUITask.<>f__mg$cache3A, null, true);
		string name11 = "UICtrlDescArray";
		if (Lua_BlackJack_ProjectL_UI_TeamRoomInviteUITask.<>f__mg$cache3B == null)
		{
			Lua_BlackJack_ProjectL_UI_TeamRoomInviteUITask.<>f__mg$cache3B = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_TeamRoomInviteUITask.get_UICtrlDescArray);
		}
		LuaObject.addMember(l, name11, Lua_BlackJack_ProjectL_UI_TeamRoomInviteUITask.<>f__mg$cache3B, null, true);
		if (Lua_BlackJack_ProjectL_UI_TeamRoomInviteUITask.<>f__mg$cache3C == null)
		{
			Lua_BlackJack_ProjectL_UI_TeamRoomInviteUITask.<>f__mg$cache3C = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_TeamRoomInviteUITask.constructor);
		}
		LuaObject.createTypeMetatable(l, Lua_BlackJack_ProjectL_UI_TeamRoomInviteUITask.<>f__mg$cache3C, typeof(TeamRoomInviteUITask), typeof(UITask));
	}

	// Token: 0x040176C6 RID: 95942
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache0;

	// Token: 0x040176C7 RID: 95943
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1;

	// Token: 0x040176C8 RID: 95944
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2;

	// Token: 0x040176C9 RID: 95945
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3;

	// Token: 0x040176CA RID: 95946
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache4;

	// Token: 0x040176CB RID: 95947
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache5;

	// Token: 0x040176CC RID: 95948
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache6;

	// Token: 0x040176CD RID: 95949
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache7;

	// Token: 0x040176CE RID: 95950
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache8;

	// Token: 0x040176CF RID: 95951
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache9;

	// Token: 0x040176D0 RID: 95952
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheA;

	// Token: 0x040176D1 RID: 95953
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheB;

	// Token: 0x040176D2 RID: 95954
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheC;

	// Token: 0x040176D3 RID: 95955
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheD;

	// Token: 0x040176D4 RID: 95956
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheE;

	// Token: 0x040176D5 RID: 95957
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheF;

	// Token: 0x040176D6 RID: 95958
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache10;

	// Token: 0x040176D7 RID: 95959
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache11;

	// Token: 0x040176D8 RID: 95960
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache12;

	// Token: 0x040176D9 RID: 95961
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache13;

	// Token: 0x040176DA RID: 95962
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache14;

	// Token: 0x040176DB RID: 95963
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache15;

	// Token: 0x040176DC RID: 95964
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache16;

	// Token: 0x040176DD RID: 95965
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache17;

	// Token: 0x040176DE RID: 95966
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache18;

	// Token: 0x040176DF RID: 95967
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache19;

	// Token: 0x040176E0 RID: 95968
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1A;

	// Token: 0x040176E1 RID: 95969
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1B;

	// Token: 0x040176E2 RID: 95970
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1C;

	// Token: 0x040176E3 RID: 95971
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1D;

	// Token: 0x040176E4 RID: 95972
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1E;

	// Token: 0x040176E5 RID: 95973
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1F;

	// Token: 0x040176E6 RID: 95974
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache20;

	// Token: 0x040176E7 RID: 95975
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache21;

	// Token: 0x040176E8 RID: 95976
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache22;

	// Token: 0x040176E9 RID: 95977
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache23;

	// Token: 0x040176EA RID: 95978
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache24;

	// Token: 0x040176EB RID: 95979
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache25;

	// Token: 0x040176EC RID: 95980
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache26;

	// Token: 0x040176ED RID: 95981
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache27;

	// Token: 0x040176EE RID: 95982
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache28;

	// Token: 0x040176EF RID: 95983
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache29;

	// Token: 0x040176F0 RID: 95984
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2A;

	// Token: 0x040176F1 RID: 95985
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2B;

	// Token: 0x040176F2 RID: 95986
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2C;

	// Token: 0x040176F3 RID: 95987
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2D;

	// Token: 0x040176F4 RID: 95988
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2E;

	// Token: 0x040176F5 RID: 95989
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2F;

	// Token: 0x040176F6 RID: 95990
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache30;

	// Token: 0x040176F7 RID: 95991
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache31;

	// Token: 0x040176F8 RID: 95992
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache32;

	// Token: 0x040176F9 RID: 95993
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache33;

	// Token: 0x040176FA RID: 95994
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache34;

	// Token: 0x040176FB RID: 95995
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache35;

	// Token: 0x040176FC RID: 95996
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache36;

	// Token: 0x040176FD RID: 95997
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache37;

	// Token: 0x040176FE RID: 95998
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache38;

	// Token: 0x040176FF RID: 95999
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache39;

	// Token: 0x04017700 RID: 96000
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3A;

	// Token: 0x04017701 RID: 96001
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3B;

	// Token: 0x04017702 RID: 96002
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3C;
}
