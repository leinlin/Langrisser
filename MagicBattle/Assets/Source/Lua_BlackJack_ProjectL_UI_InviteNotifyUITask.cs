using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using BlackJack.BJFramework.Runtime.UI;
using BlackJack.ProjectL.PlayerContext;
using BlackJack.ProjectL.UI;
using SLua;
using UnityEngine.Scripting;

// Token: 0x020014F3 RID: 5363
[Preserve]
public class Lua_BlackJack_ProjectL_UI_InviteNotifyUITask : LuaObject
{
	// Token: 0x0601FACB RID: 129739 RVA: 0x00A6DD68 File Offset: 0x00A6BF68
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int constructor(IntPtr l)
	{
		int result;
		try
		{
			string name;
			LuaObject.checkType(l, 2, out name);
			InviteNotifyUITask o = new InviteNotifyUITask(name);
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

	// Token: 0x0601FACC RID: 129740 RVA: 0x00A6DDBC File Offset: 0x00A6BFBC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int OnNewIntent(IntPtr l)
	{
		int result;
		try
		{
			InviteNotifyUITask inviteNotifyUITask = (InviteNotifyUITask)LuaObject.checkSelf(l);
			UIIntent intent;
			LuaObject.checkType<UIIntent>(l, 2, out intent);
			bool b = inviteNotifyUITask.OnNewIntent(intent);
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

	// Token: 0x0601FACD RID: 129741 RVA: 0x00A6DE20 File Offset: 0x00A6C020
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int StartUITask_s(IntPtr l)
	{
		int result;
		try
		{
			InviteNotifyUITask.StartUITask();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601FACE RID: 129742 RVA: 0x00A6DE60 File Offset: 0x00A6C060
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int StopUITask_s(IntPtr l)
	{
		int result;
		try
		{
			InviteNotifyUITask.StopUITask();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601FACF RID: 129743 RVA: 0x00A6DEA0 File Offset: 0x00A6C0A0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int CheckPendingInviteInfo_s(IntPtr l)
	{
		int result;
		try
		{
			InviteNotifyUITask.CheckPendingInviteInfo();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601FAD0 RID: 129744 RVA: 0x00A6DEE0 File Offset: 0x00A6C0E0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int DisableDisplay_s(IntPtr l)
	{
		int result;
		try
		{
			InviteNotifyUITask.DisableDisplay();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601FAD1 RID: 129745 RVA: 0x00A6DF20 File Offset: 0x00A6C120
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int EnableDispaly_s(IntPtr l)
	{
		int result;
		try
		{
			InviteNotifyUITask.EnableDispaly();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601FAD2 RID: 129746 RVA: 0x00A6DF60 File Offset: 0x00A6C160
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int OnStart(IntPtr l)
	{
		int result;
		try
		{
			InviteNotifyUITask inviteNotifyUITask = (InviteNotifyUITask)LuaObject.checkSelf(l);
			UIIntent intent;
			LuaObject.checkType<UIIntent>(l, 2, out intent);
			bool b = inviteNotifyUITask.m_luaExportHelper.OnStart(intent);
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

	// Token: 0x0601FAD3 RID: 129747 RVA: 0x00A6DFC8 File Offset: 0x00A6C1C8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int OnResume(IntPtr l)
	{
		int result;
		try
		{
			InviteNotifyUITask inviteNotifyUITask = (InviteNotifyUITask)LuaObject.checkSelf(l);
			UIIntent intent;
			LuaObject.checkType<UIIntent>(l, 2, out intent);
			bool b = inviteNotifyUITask.m_luaExportHelper.OnResume(intent);
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

	// Token: 0x0601FAD4 RID: 129748 RVA: 0x00A6E030 File Offset: 0x00A6C230
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int InitDataFromUIIntent(IntPtr l)
	{
		int result;
		try
		{
			InviteNotifyUITask inviteNotifyUITask = (InviteNotifyUITask)LuaObject.checkSelf(l);
			UIIntent intent;
			LuaObject.checkType<UIIntent>(l, 2, out intent);
			bool b = inviteNotifyUITask.m_luaExportHelper.InitDataFromUIIntent(intent);
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

	// Token: 0x0601FAD5 RID: 129749 RVA: 0x00A6E098 File Offset: 0x00A6C298
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int InitAllUIControllers(IntPtr l)
	{
		int result;
		try
		{
			InviteNotifyUITask inviteNotifyUITask = (InviteNotifyUITask)LuaObject.checkSelf(l);
			inviteNotifyUITask.m_luaExportHelper.InitAllUIControllers();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601FAD6 RID: 129750 RVA: 0x00A6E0EC File Offset: 0x00A6C2EC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int ClearAllContextAndRes(IntPtr l)
	{
		int result;
		try
		{
			InviteNotifyUITask inviteNotifyUITask = (InviteNotifyUITask)LuaObject.checkSelf(l);
			inviteNotifyUITask.m_luaExportHelper.ClearAllContextAndRes();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601FAD7 RID: 129751 RVA: 0x00A6E140 File Offset: 0x00A6C340
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int InitInviteNotifyUIController(IntPtr l)
	{
		int result;
		try
		{
			InviteNotifyUITask inviteNotifyUITask = (InviteNotifyUITask)LuaObject.checkSelf(l);
			inviteNotifyUITask.m_luaExportHelper.InitInviteNotifyUIController();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601FAD8 RID: 129752 RVA: 0x00A6E194 File Offset: 0x00A6C394
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int UninitInviteNotifyUIController(IntPtr l)
	{
		int result;
		try
		{
			InviteNotifyUITask inviteNotifyUITask = (InviteNotifyUITask)LuaObject.checkSelf(l);
			inviteNotifyUITask.m_luaExportHelper.UninitInviteNotifyUIController();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601FAD9 RID: 129753 RVA: 0x00A6E1E8 File Offset: 0x00A6C3E8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int UpdateView(IntPtr l)
	{
		int result;
		try
		{
			InviteNotifyUITask inviteNotifyUITask = (InviteNotifyUITask)LuaObject.checkSelf(l);
			inviteNotifyUITask.m_luaExportHelper.UpdateView();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601FADA RID: 129754 RVA: 0x00A6E23C File Offset: 0x00A6C43C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int NextInviteInfo(IntPtr l)
	{
		int result;
		try
		{
			InviteNotifyUITask inviteNotifyUITask = (InviteNotifyUITask)LuaObject.checkSelf(l);
			bool b = inviteNotifyUITask.m_luaExportHelper.NextInviteInfo();
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

	// Token: 0x0601FADB RID: 129755 RVA: 0x00A6E298 File Offset: 0x00A6C498
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int IsInBattle(IntPtr l)
	{
		int result;
		try
		{
			InviteNotifyUITask inviteNotifyUITask = (InviteNotifyUITask)LuaObject.checkSelf(l);
			bool b = inviteNotifyUITask.m_luaExportHelper.IsInBattle();
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

	// Token: 0x0601FADC RID: 129756 RVA: 0x00A6E2F4 File Offset: 0x00A6C4F4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int StartTeamRoomInfoUITask(IntPtr l)
	{
		int result;
		try
		{
			InviteNotifyUITask inviteNotifyUITask = (InviteNotifyUITask)LuaObject.checkSelf(l);
			inviteNotifyUITask.m_luaExportHelper.StartTeamRoomInfoUITask();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601FADD RID: 129757 RVA: 0x00A6E348 File Offset: 0x00A6C548
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int CloseAndPause(IntPtr l)
	{
		int result;
		try
		{
			InviteNotifyUITask inviteNotifyUITask = (InviteNotifyUITask)LuaObject.checkSelf(l);
			inviteNotifyUITask.m_luaExportHelper.CloseAndPause();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601FADE RID: 129758 RVA: 0x00A6E39C File Offset: 0x00A6C59C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int InviteNotifyUIController_OnAccept(IntPtr l)
	{
		int result;
		try
		{
			InviteNotifyUITask inviteNotifyUITask = (InviteNotifyUITask)LuaObject.checkSelf(l);
			inviteNotifyUITask.m_luaExportHelper.InviteNotifyUIController_OnAccept();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601FADF RID: 129759 RVA: 0x00A6E3F0 File Offset: 0x00A6C5F0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int InviteNotifyUIController_OnRefuse(IntPtr l)
	{
		int result;
		try
		{
			InviteNotifyUITask inviteNotifyUITask = (InviteNotifyUITask)LuaObject.checkSelf(l);
			inviteNotifyUITask.m_luaExportHelper.InviteNotifyUIController_OnRefuse();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601FAE0 RID: 129760 RVA: 0x00A6E444 File Offset: 0x00A6C644
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int InviteNotifyUIController_OnClickIcon(IntPtr l)
	{
		int result;
		try
		{
			InviteNotifyUITask inviteNotifyUITask = (InviteNotifyUITask)LuaObject.checkSelf(l);
			inviteNotifyUITask.m_luaExportHelper.InviteNotifyUIController_OnClickIcon();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601FAE1 RID: 129761 RVA: 0x00A6E498 File Offset: 0x00A6C698
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_OnStart(IntPtr l)
	{
		int result;
		try
		{
			InviteNotifyUITask inviteNotifyUITask = (InviteNotifyUITask)LuaObject.checkSelf(l);
			UIIntent intent;
			LuaObject.checkType<UIIntent>(l, 2, out intent);
			bool b = inviteNotifyUITask.m_luaExportHelper.__callBase_OnStart(intent);
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

	// Token: 0x0601FAE2 RID: 129762 RVA: 0x00A6E500 File Offset: 0x00A6C700
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_OnStop(IntPtr l)
	{
		int result;
		try
		{
			InviteNotifyUITask inviteNotifyUITask = (InviteNotifyUITask)LuaObject.checkSelf(l);
			inviteNotifyUITask.m_luaExportHelper.__callBase_OnStop();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601FAE3 RID: 129763 RVA: 0x00A6E554 File Offset: 0x00A6C754
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_OnPause(IntPtr l)
	{
		int result;
		try
		{
			InviteNotifyUITask inviteNotifyUITask = (InviteNotifyUITask)LuaObject.checkSelf(l);
			inviteNotifyUITask.m_luaExportHelper.__callBase_OnPause();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601FAE4 RID: 129764 RVA: 0x00A6E5A8 File Offset: 0x00A6C7A8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_OnResume(IntPtr l)
	{
		int result;
		try
		{
			InviteNotifyUITask inviteNotifyUITask = (InviteNotifyUITask)LuaObject.checkSelf(l);
			UIIntent intent;
			LuaObject.checkType<UIIntent>(l, 2, out intent);
			bool b = inviteNotifyUITask.m_luaExportHelper.__callBase_OnResume(intent);
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

	// Token: 0x0601FAE5 RID: 129765 RVA: 0x00A6E610 File Offset: 0x00A6C810
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_OnNewIntent(IntPtr l)
	{
		int result;
		try
		{
			InviteNotifyUITask inviteNotifyUITask = (InviteNotifyUITask)LuaObject.checkSelf(l);
			UIIntent intent;
			LuaObject.checkType<UIIntent>(l, 2, out intent);
			bool b = inviteNotifyUITask.m_luaExportHelper.__callBase_OnNewIntent(intent);
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

	// Token: 0x0601FAE6 RID: 129766 RVA: 0x00A6E678 File Offset: 0x00A6C878
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_EnableUIInput(IntPtr l)
	{
		int result;
		try
		{
			InviteNotifyUITask inviteNotifyUITask = (InviteNotifyUITask)LuaObject.checkSelf(l);
			bool isEnable;
			LuaObject.checkType(l, 2, out isEnable);
			bool? isGlobalEnable;
			LuaObject.checkNullable<bool>(l, 3, out isGlobalEnable);
			inviteNotifyUITask.m_luaExportHelper.__callBase_EnableUIInput(isEnable, isGlobalEnable);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601FAE7 RID: 129767 RVA: 0x00A6E6E4 File Offset: 0x00A6C8E4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_IsNeedLoadDynamicRes(IntPtr l)
	{
		int result;
		try
		{
			InviteNotifyUITask inviteNotifyUITask = (InviteNotifyUITask)LuaObject.checkSelf(l);
			bool b = inviteNotifyUITask.m_luaExportHelper.__callBase_IsNeedLoadDynamicRes();
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

	// Token: 0x0601FAE8 RID: 129768 RVA: 0x00A6E740 File Offset: 0x00A6C940
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_CollectAllDynamicResForLoad(IntPtr l)
	{
		int result;
		try
		{
			InviteNotifyUITask inviteNotifyUITask = (InviteNotifyUITask)LuaObject.checkSelf(l);
			List<string> o = inviteNotifyUITask.m_luaExportHelper.__callBase_CollectAllDynamicResForLoad();
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

	// Token: 0x0601FAE9 RID: 129769 RVA: 0x00A6E79C File Offset: 0x00A6C99C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_RegisterPlayerContextEvents(IntPtr l)
	{
		int result;
		try
		{
			InviteNotifyUITask inviteNotifyUITask = (InviteNotifyUITask)LuaObject.checkSelf(l);
			inviteNotifyUITask.m_luaExportHelper.__callBase_RegisterPlayerContextEvents();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601FAEA RID: 129770 RVA: 0x00A6E7F0 File Offset: 0x00A6C9F0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_UnregisterPlayerContextEvents(IntPtr l)
	{
		int result;
		try
		{
			InviteNotifyUITask inviteNotifyUITask = (InviteNotifyUITask)LuaObject.checkSelf(l);
			inviteNotifyUITask.m_luaExportHelper.__callBase_UnregisterPlayerContextEvents();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601FAEB RID: 129771 RVA: 0x00A6E844 File Offset: 0x00A6CA44
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_PostUpdateView(IntPtr l)
	{
		int result;
		try
		{
			InviteNotifyUITask inviteNotifyUITask = (InviteNotifyUITask)LuaObject.checkSelf(l);
			inviteNotifyUITask.m_luaExportHelper.__callBase_PostUpdateView();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601FAEC RID: 129772 RVA: 0x00A6E898 File Offset: 0x00A6CA98
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_CollectPreloadResourceList(IntPtr l)
	{
		int result;
		try
		{
			InviteNotifyUITask inviteNotifyUITask = (InviteNotifyUITask)LuaObject.checkSelf(l);
			inviteNotifyUITask.m_luaExportHelper.__callBase_CollectPreloadResourceList();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601FAED RID: 129773 RVA: 0x00A6E8EC File Offset: 0x00A6CAEC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_ClearAssetList(IntPtr l)
	{
		int result;
		try
		{
			InviteNotifyUITask inviteNotifyUITask = (InviteNotifyUITask)LuaObject.checkSelf(l);
			inviteNotifyUITask.m_luaExportHelper.__callBase_ClearAssetList();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601FAEE RID: 129774 RVA: 0x00A6E940 File Offset: 0x00A6CB40
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_CollectAsset(IntPtr l)
	{
		int result;
		try
		{
			InviteNotifyUITask inviteNotifyUITask = (InviteNotifyUITask)LuaObject.checkSelf(l);
			string assetName;
			LuaObject.checkType(l, 2, out assetName);
			inviteNotifyUITask.m_luaExportHelper.__callBase_CollectAsset(assetName);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601FAEF RID: 129775 RVA: 0x00A6E99C File Offset: 0x00A6CB9C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_CollectSpriteAsset(IntPtr l)
	{
		int result;
		try
		{
			InviteNotifyUITask inviteNotifyUITask = (InviteNotifyUITask)LuaObject.checkSelf(l);
			string assetName;
			LuaObject.checkType(l, 2, out assetName);
			inviteNotifyUITask.m_luaExportHelper.__callBase_CollectSpriteAsset(assetName);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601FAF0 RID: 129776 RVA: 0x00A6E9F8 File Offset: 0x00A6CBF8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_CollectFxAsset(IntPtr l)
	{
		int result;
		try
		{
			InviteNotifyUITask inviteNotifyUITask = (InviteNotifyUITask)LuaObject.checkSelf(l);
			string assetName;
			LuaObject.checkType(l, 2, out assetName);
			inviteNotifyUITask.m_luaExportHelper.__callBase_CollectFxAsset(assetName);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601FAF1 RID: 129777 RVA: 0x00A6EA54 File Offset: 0x00A6CC54
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_StartLoadCustomAssets(IntPtr l)
	{
		int result;
		try
		{
			InviteNotifyUITask inviteNotifyUITask = (InviteNotifyUITask)LuaObject.checkSelf(l);
			Action onLoadCompleted;
			LuaObject.checkDelegate<Action>(l, 2, out onLoadCompleted);
			inviteNotifyUITask.m_luaExportHelper.__callBase_StartLoadCustomAssets(onLoadCompleted);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601FAF2 RID: 129778 RVA: 0x00A6EAB0 File Offset: 0x00A6CCB0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_IsLoadingCustomAssets(IntPtr l)
	{
		int result;
		try
		{
			InviteNotifyUITask inviteNotifyUITask = (InviteNotifyUITask)LuaObject.checkSelf(l);
			bool b = inviteNotifyUITask.m_luaExportHelper.__callBase_IsLoadingCustomAssets();
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

	// Token: 0x0601FAF3 RID: 129779 RVA: 0x00A6EB0C File Offset: 0x00A6CD0C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_IsPipeLineRunning(IntPtr l)
	{
		int result;
		try
		{
			InviteNotifyUITask inviteNotifyUITask = (InviteNotifyUITask)LuaObject.checkSelf(l);
			bool b = inviteNotifyUITask.m_luaExportHelper.__callBase_IsPipeLineRunning();
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

	// Token: 0x0601FAF4 RID: 129780 RVA: 0x00A6EB68 File Offset: 0x00A6CD68
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_IsOpeningUI(IntPtr l)
	{
		int result;
		try
		{
			InviteNotifyUITask inviteNotifyUITask = (InviteNotifyUITask)LuaObject.checkSelf(l);
			bool b = inviteNotifyUITask.m_luaExportHelper.__callBase_IsOpeningUI();
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

	// Token: 0x0601FAF5 RID: 129781 RVA: 0x00A6EBC4 File Offset: 0x00A6CDC4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_ReturnPrevUITask(IntPtr l)
	{
		int result;
		try
		{
			InviteNotifyUITask inviteNotifyUITask = (InviteNotifyUITask)LuaObject.checkSelf(l);
			UITaskBase o = inviteNotifyUITask.m_luaExportHelper.__callBase_ReturnPrevUITask();
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

	// Token: 0x0601FAF6 RID: 129782 RVA: 0x00A6EC20 File Offset: 0x00A6CE20
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_ClearUnusedDynamicResourceCache(IntPtr l)
	{
		int result;
		try
		{
			InviteNotifyUITask inviteNotifyUITask = (InviteNotifyUITask)LuaObject.checkSelf(l);
			inviteNotifyUITask.m_luaExportHelper.__callBase_ClearUnusedDynamicResourceCache();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601FAF7 RID: 129783 RVA: 0x00A6EC74 File Offset: 0x00A6CE74
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_OnMemoryWarning(IntPtr l)
	{
		int result;
		try
		{
			InviteNotifyUITask inviteNotifyUITask = (InviteNotifyUITask)LuaObject.checkSelf(l);
			inviteNotifyUITask.m_luaExportHelper.__callBase_OnMemoryWarning();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601FAF8 RID: 129784 RVA: 0x00A6ECC8 File Offset: 0x00A6CEC8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_layerDescArray(IntPtr l)
	{
		int result;
		try
		{
			InviteNotifyUITask inviteNotifyUITask = (InviteNotifyUITask)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, inviteNotifyUITask.m_luaExportHelper.m_layerDescArray);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601FAF9 RID: 129785 RVA: 0x00A6ED20 File Offset: 0x00A6CF20
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_layerDescArray(IntPtr l)
	{
		int result;
		try
		{
			InviteNotifyUITask inviteNotifyUITask = (InviteNotifyUITask)LuaObject.checkSelf(l);
			UITaskBase.LayerDesc[] layerDescArray;
			LuaObject.checkArray<UITaskBase.LayerDesc>(l, 2, out layerDescArray);
			inviteNotifyUITask.m_luaExportHelper.m_layerDescArray = layerDescArray;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601FAFA RID: 129786 RVA: 0x00A6ED7C File Offset: 0x00A6CF7C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_uiCtrlDescArray(IntPtr l)
	{
		int result;
		try
		{
			InviteNotifyUITask inviteNotifyUITask = (InviteNotifyUITask)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, inviteNotifyUITask.m_luaExportHelper.m_uiCtrlDescArray);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601FAFB RID: 129787 RVA: 0x00A6EDD4 File Offset: 0x00A6CFD4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_uiCtrlDescArray(IntPtr l)
	{
		int result;
		try
		{
			InviteNotifyUITask inviteNotifyUITask = (InviteNotifyUITask)LuaObject.checkSelf(l);
			UITaskBase.UIControllerDesc[] uiCtrlDescArray;
			LuaObject.checkArray<UITaskBase.UIControllerDesc>(l, 2, out uiCtrlDescArray);
			inviteNotifyUITask.m_luaExportHelper.m_uiCtrlDescArray = uiCtrlDescArray;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601FAFC RID: 129788 RVA: 0x00A6EE30 File Offset: 0x00A6D030
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_inviteNotifyUIController(IntPtr l)
	{
		int result;
		try
		{
			InviteNotifyUITask inviteNotifyUITask = (InviteNotifyUITask)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, inviteNotifyUITask.m_luaExportHelper.m_inviteNotifyUIController);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601FAFD RID: 129789 RVA: 0x00A6EE88 File Offset: 0x00A6D088
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_inviteNotifyUIController(IntPtr l)
	{
		int result;
		try
		{
			InviteNotifyUITask inviteNotifyUITask = (InviteNotifyUITask)LuaObject.checkSelf(l);
			InviteNotifyUIController inviteNotifyUIController;
			LuaObject.checkType<InviteNotifyUIController>(l, 2, out inviteNotifyUIController);
			inviteNotifyUITask.m_luaExportHelper.m_inviteNotifyUIController = inviteNotifyUIController;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601FAFE RID: 129790 RVA: 0x00A6EEE4 File Offset: 0x00A6D0E4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_inviteInfo(IntPtr l)
	{
		int result;
		try
		{
			InviteNotifyUITask inviteNotifyUITask = (InviteNotifyUITask)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, inviteNotifyUITask.m_luaExportHelper.m_inviteInfo);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601FAFF RID: 129791 RVA: 0x00A6EF3C File Offset: 0x00A6D13C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_inviteInfo(IntPtr l)
	{
		int result;
		try
		{
			InviteNotifyUITask inviteNotifyUITask = (InviteNotifyUITask)LuaObject.checkSelf(l);
			GeneralInviteInfo inviteInfo;
			LuaObject.checkType<GeneralInviteInfo>(l, 2, out inviteInfo);
			inviteNotifyUITask.m_luaExportHelper.m_inviteInfo = inviteInfo;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601FB00 RID: 129792 RVA: 0x00A6EF98 File Offset: 0x00A6D198
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_inviteInfoList(IntPtr l)
	{
		int result;
		try
		{
			InviteNotifyUITask inviteNotifyUITask = (InviteNotifyUITask)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, inviteNotifyUITask.m_luaExportHelper.m_inviteInfoList);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601FB01 RID: 129793 RVA: 0x00A6EFF0 File Offset: 0x00A6D1F0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_inviteInfoList(IntPtr l)
	{
		int result;
		try
		{
			InviteNotifyUITask inviteNotifyUITask = (InviteNotifyUITask)LuaObject.checkSelf(l);
			List<GeneralInviteInfo> inviteInfoList;
			LuaObject.checkType<List<GeneralInviteInfo>>(l, 2, out inviteInfoList);
			inviteNotifyUITask.m_luaExportHelper.m_inviteInfoList = inviteInfoList;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601FB02 RID: 129794 RVA: 0x00A6F04C File Offset: 0x00A6D24C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_inviteCount(IntPtr l)
	{
		int result;
		try
		{
			InviteNotifyUITask inviteNotifyUITask = (InviteNotifyUITask)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, inviteNotifyUITask.m_luaExportHelper.m_inviteCount);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601FB03 RID: 129795 RVA: 0x00A6F0A4 File Offset: 0x00A6D2A4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_inviteCount(IntPtr l)
	{
		int result;
		try
		{
			InviteNotifyUITask inviteNotifyUITask = (InviteNotifyUITask)LuaObject.checkSelf(l);
			int inviteCount;
			LuaObject.checkType(l, 2, out inviteCount);
			inviteNotifyUITask.m_luaExportHelper.m_inviteCount = inviteCount;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601FB04 RID: 129796 RVA: 0x00A6F100 File Offset: 0x00A6D300
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_isDisableDisplay(IntPtr l)
	{
		int result;
		try
		{
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, InviteNotifyUITask.LuaExportHelper.m_isDisableDisplay);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601FB05 RID: 129797 RVA: 0x00A6F148 File Offset: 0x00A6D348
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_isDisableDisplay(IntPtr l)
	{
		int result;
		try
		{
			int isDisableDisplay;
			LuaObject.checkType(l, 2, out isDisableDisplay);
			InviteNotifyUITask.LuaExportHelper.m_isDisableDisplay = isDisableDisplay;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601FB06 RID: 129798 RVA: 0x00A6F194 File Offset: 0x00A6D394
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_LayerDescArray(IntPtr l)
	{
		int result;
		try
		{
			InviteNotifyUITask inviteNotifyUITask = (InviteNotifyUITask)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, inviteNotifyUITask.m_luaExportHelper.LayerDescArray);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601FB07 RID: 129799 RVA: 0x00A6F1EC File Offset: 0x00A6D3EC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_UICtrlDescArray(IntPtr l)
	{
		int result;
		try
		{
			InviteNotifyUITask inviteNotifyUITask = (InviteNotifyUITask)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, inviteNotifyUITask.m_luaExportHelper.UICtrlDescArray);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601FB08 RID: 129800 RVA: 0x00A6F244 File Offset: 0x00A6D444
	[Preserve]
	public static void reg(IntPtr l)
	{
		LuaObject.getTypeTable(l, "BlackJack.ProjectL.UI.InviteNotifyUITask");
		if (Lua_BlackJack_ProjectL_UI_InviteNotifyUITask.<>f__mg$cache0 == null)
		{
			Lua_BlackJack_ProjectL_UI_InviteNotifyUITask.<>f__mg$cache0 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_InviteNotifyUITask.OnNewIntent);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_InviteNotifyUITask.<>f__mg$cache0);
		if (Lua_BlackJack_ProjectL_UI_InviteNotifyUITask.<>f__mg$cache1 == null)
		{
			Lua_BlackJack_ProjectL_UI_InviteNotifyUITask.<>f__mg$cache1 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_InviteNotifyUITask.StartUITask_s);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_InviteNotifyUITask.<>f__mg$cache1);
		if (Lua_BlackJack_ProjectL_UI_InviteNotifyUITask.<>f__mg$cache2 == null)
		{
			Lua_BlackJack_ProjectL_UI_InviteNotifyUITask.<>f__mg$cache2 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_InviteNotifyUITask.StopUITask_s);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_InviteNotifyUITask.<>f__mg$cache2);
		if (Lua_BlackJack_ProjectL_UI_InviteNotifyUITask.<>f__mg$cache3 == null)
		{
			Lua_BlackJack_ProjectL_UI_InviteNotifyUITask.<>f__mg$cache3 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_InviteNotifyUITask.CheckPendingInviteInfo_s);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_InviteNotifyUITask.<>f__mg$cache3);
		if (Lua_BlackJack_ProjectL_UI_InviteNotifyUITask.<>f__mg$cache4 == null)
		{
			Lua_BlackJack_ProjectL_UI_InviteNotifyUITask.<>f__mg$cache4 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_InviteNotifyUITask.DisableDisplay_s);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_InviteNotifyUITask.<>f__mg$cache4);
		if (Lua_BlackJack_ProjectL_UI_InviteNotifyUITask.<>f__mg$cache5 == null)
		{
			Lua_BlackJack_ProjectL_UI_InviteNotifyUITask.<>f__mg$cache5 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_InviteNotifyUITask.EnableDispaly_s);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_InviteNotifyUITask.<>f__mg$cache5);
		if (Lua_BlackJack_ProjectL_UI_InviteNotifyUITask.<>f__mg$cache6 == null)
		{
			Lua_BlackJack_ProjectL_UI_InviteNotifyUITask.<>f__mg$cache6 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_InviteNotifyUITask.OnStart);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_InviteNotifyUITask.<>f__mg$cache6);
		if (Lua_BlackJack_ProjectL_UI_InviteNotifyUITask.<>f__mg$cache7 == null)
		{
			Lua_BlackJack_ProjectL_UI_InviteNotifyUITask.<>f__mg$cache7 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_InviteNotifyUITask.OnResume);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_InviteNotifyUITask.<>f__mg$cache7);
		if (Lua_BlackJack_ProjectL_UI_InviteNotifyUITask.<>f__mg$cache8 == null)
		{
			Lua_BlackJack_ProjectL_UI_InviteNotifyUITask.<>f__mg$cache8 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_InviteNotifyUITask.InitDataFromUIIntent);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_InviteNotifyUITask.<>f__mg$cache8);
		if (Lua_BlackJack_ProjectL_UI_InviteNotifyUITask.<>f__mg$cache9 == null)
		{
			Lua_BlackJack_ProjectL_UI_InviteNotifyUITask.<>f__mg$cache9 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_InviteNotifyUITask.InitAllUIControllers);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_InviteNotifyUITask.<>f__mg$cache9);
		if (Lua_BlackJack_ProjectL_UI_InviteNotifyUITask.<>f__mg$cacheA == null)
		{
			Lua_BlackJack_ProjectL_UI_InviteNotifyUITask.<>f__mg$cacheA = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_InviteNotifyUITask.ClearAllContextAndRes);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_InviteNotifyUITask.<>f__mg$cacheA);
		if (Lua_BlackJack_ProjectL_UI_InviteNotifyUITask.<>f__mg$cacheB == null)
		{
			Lua_BlackJack_ProjectL_UI_InviteNotifyUITask.<>f__mg$cacheB = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_InviteNotifyUITask.InitInviteNotifyUIController);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_InviteNotifyUITask.<>f__mg$cacheB);
		if (Lua_BlackJack_ProjectL_UI_InviteNotifyUITask.<>f__mg$cacheC == null)
		{
			Lua_BlackJack_ProjectL_UI_InviteNotifyUITask.<>f__mg$cacheC = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_InviteNotifyUITask.UninitInviteNotifyUIController);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_InviteNotifyUITask.<>f__mg$cacheC);
		if (Lua_BlackJack_ProjectL_UI_InviteNotifyUITask.<>f__mg$cacheD == null)
		{
			Lua_BlackJack_ProjectL_UI_InviteNotifyUITask.<>f__mg$cacheD = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_InviteNotifyUITask.UpdateView);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_InviteNotifyUITask.<>f__mg$cacheD);
		if (Lua_BlackJack_ProjectL_UI_InviteNotifyUITask.<>f__mg$cacheE == null)
		{
			Lua_BlackJack_ProjectL_UI_InviteNotifyUITask.<>f__mg$cacheE = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_InviteNotifyUITask.NextInviteInfo);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_InviteNotifyUITask.<>f__mg$cacheE);
		if (Lua_BlackJack_ProjectL_UI_InviteNotifyUITask.<>f__mg$cacheF == null)
		{
			Lua_BlackJack_ProjectL_UI_InviteNotifyUITask.<>f__mg$cacheF = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_InviteNotifyUITask.IsInBattle);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_InviteNotifyUITask.<>f__mg$cacheF);
		if (Lua_BlackJack_ProjectL_UI_InviteNotifyUITask.<>f__mg$cache10 == null)
		{
			Lua_BlackJack_ProjectL_UI_InviteNotifyUITask.<>f__mg$cache10 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_InviteNotifyUITask.StartTeamRoomInfoUITask);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_InviteNotifyUITask.<>f__mg$cache10);
		if (Lua_BlackJack_ProjectL_UI_InviteNotifyUITask.<>f__mg$cache11 == null)
		{
			Lua_BlackJack_ProjectL_UI_InviteNotifyUITask.<>f__mg$cache11 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_InviteNotifyUITask.CloseAndPause);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_InviteNotifyUITask.<>f__mg$cache11);
		if (Lua_BlackJack_ProjectL_UI_InviteNotifyUITask.<>f__mg$cache12 == null)
		{
			Lua_BlackJack_ProjectL_UI_InviteNotifyUITask.<>f__mg$cache12 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_InviteNotifyUITask.InviteNotifyUIController_OnAccept);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_InviteNotifyUITask.<>f__mg$cache12);
		if (Lua_BlackJack_ProjectL_UI_InviteNotifyUITask.<>f__mg$cache13 == null)
		{
			Lua_BlackJack_ProjectL_UI_InviteNotifyUITask.<>f__mg$cache13 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_InviteNotifyUITask.InviteNotifyUIController_OnRefuse);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_InviteNotifyUITask.<>f__mg$cache13);
		if (Lua_BlackJack_ProjectL_UI_InviteNotifyUITask.<>f__mg$cache14 == null)
		{
			Lua_BlackJack_ProjectL_UI_InviteNotifyUITask.<>f__mg$cache14 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_InviteNotifyUITask.InviteNotifyUIController_OnClickIcon);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_InviteNotifyUITask.<>f__mg$cache14);
		if (Lua_BlackJack_ProjectL_UI_InviteNotifyUITask.<>f__mg$cache15 == null)
		{
			Lua_BlackJack_ProjectL_UI_InviteNotifyUITask.<>f__mg$cache15 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_InviteNotifyUITask.__callBase_OnStart);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_InviteNotifyUITask.<>f__mg$cache15);
		if (Lua_BlackJack_ProjectL_UI_InviteNotifyUITask.<>f__mg$cache16 == null)
		{
			Lua_BlackJack_ProjectL_UI_InviteNotifyUITask.<>f__mg$cache16 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_InviteNotifyUITask.__callBase_OnStop);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_InviteNotifyUITask.<>f__mg$cache16);
		if (Lua_BlackJack_ProjectL_UI_InviteNotifyUITask.<>f__mg$cache17 == null)
		{
			Lua_BlackJack_ProjectL_UI_InviteNotifyUITask.<>f__mg$cache17 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_InviteNotifyUITask.__callBase_OnPause);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_InviteNotifyUITask.<>f__mg$cache17);
		if (Lua_BlackJack_ProjectL_UI_InviteNotifyUITask.<>f__mg$cache18 == null)
		{
			Lua_BlackJack_ProjectL_UI_InviteNotifyUITask.<>f__mg$cache18 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_InviteNotifyUITask.__callBase_OnResume);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_InviteNotifyUITask.<>f__mg$cache18);
		if (Lua_BlackJack_ProjectL_UI_InviteNotifyUITask.<>f__mg$cache19 == null)
		{
			Lua_BlackJack_ProjectL_UI_InviteNotifyUITask.<>f__mg$cache19 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_InviteNotifyUITask.__callBase_OnNewIntent);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_InviteNotifyUITask.<>f__mg$cache19);
		if (Lua_BlackJack_ProjectL_UI_InviteNotifyUITask.<>f__mg$cache1A == null)
		{
			Lua_BlackJack_ProjectL_UI_InviteNotifyUITask.<>f__mg$cache1A = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_InviteNotifyUITask.__callBase_EnableUIInput);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_InviteNotifyUITask.<>f__mg$cache1A);
		if (Lua_BlackJack_ProjectL_UI_InviteNotifyUITask.<>f__mg$cache1B == null)
		{
			Lua_BlackJack_ProjectL_UI_InviteNotifyUITask.<>f__mg$cache1B = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_InviteNotifyUITask.__callBase_IsNeedLoadDynamicRes);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_InviteNotifyUITask.<>f__mg$cache1B);
		if (Lua_BlackJack_ProjectL_UI_InviteNotifyUITask.<>f__mg$cache1C == null)
		{
			Lua_BlackJack_ProjectL_UI_InviteNotifyUITask.<>f__mg$cache1C = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_InviteNotifyUITask.__callBase_CollectAllDynamicResForLoad);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_InviteNotifyUITask.<>f__mg$cache1C);
		if (Lua_BlackJack_ProjectL_UI_InviteNotifyUITask.<>f__mg$cache1D == null)
		{
			Lua_BlackJack_ProjectL_UI_InviteNotifyUITask.<>f__mg$cache1D = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_InviteNotifyUITask.__callBase_RegisterPlayerContextEvents);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_InviteNotifyUITask.<>f__mg$cache1D);
		if (Lua_BlackJack_ProjectL_UI_InviteNotifyUITask.<>f__mg$cache1E == null)
		{
			Lua_BlackJack_ProjectL_UI_InviteNotifyUITask.<>f__mg$cache1E = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_InviteNotifyUITask.__callBase_UnregisterPlayerContextEvents);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_InviteNotifyUITask.<>f__mg$cache1E);
		if (Lua_BlackJack_ProjectL_UI_InviteNotifyUITask.<>f__mg$cache1F == null)
		{
			Lua_BlackJack_ProjectL_UI_InviteNotifyUITask.<>f__mg$cache1F = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_InviteNotifyUITask.__callBase_PostUpdateView);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_InviteNotifyUITask.<>f__mg$cache1F);
		if (Lua_BlackJack_ProjectL_UI_InviteNotifyUITask.<>f__mg$cache20 == null)
		{
			Lua_BlackJack_ProjectL_UI_InviteNotifyUITask.<>f__mg$cache20 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_InviteNotifyUITask.__callBase_CollectPreloadResourceList);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_InviteNotifyUITask.<>f__mg$cache20);
		if (Lua_BlackJack_ProjectL_UI_InviteNotifyUITask.<>f__mg$cache21 == null)
		{
			Lua_BlackJack_ProjectL_UI_InviteNotifyUITask.<>f__mg$cache21 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_InviteNotifyUITask.__callBase_ClearAssetList);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_InviteNotifyUITask.<>f__mg$cache21);
		if (Lua_BlackJack_ProjectL_UI_InviteNotifyUITask.<>f__mg$cache22 == null)
		{
			Lua_BlackJack_ProjectL_UI_InviteNotifyUITask.<>f__mg$cache22 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_InviteNotifyUITask.__callBase_CollectAsset);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_InviteNotifyUITask.<>f__mg$cache22);
		if (Lua_BlackJack_ProjectL_UI_InviteNotifyUITask.<>f__mg$cache23 == null)
		{
			Lua_BlackJack_ProjectL_UI_InviteNotifyUITask.<>f__mg$cache23 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_InviteNotifyUITask.__callBase_CollectSpriteAsset);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_InviteNotifyUITask.<>f__mg$cache23);
		if (Lua_BlackJack_ProjectL_UI_InviteNotifyUITask.<>f__mg$cache24 == null)
		{
			Lua_BlackJack_ProjectL_UI_InviteNotifyUITask.<>f__mg$cache24 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_InviteNotifyUITask.__callBase_CollectFxAsset);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_InviteNotifyUITask.<>f__mg$cache24);
		if (Lua_BlackJack_ProjectL_UI_InviteNotifyUITask.<>f__mg$cache25 == null)
		{
			Lua_BlackJack_ProjectL_UI_InviteNotifyUITask.<>f__mg$cache25 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_InviteNotifyUITask.__callBase_StartLoadCustomAssets);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_InviteNotifyUITask.<>f__mg$cache25);
		if (Lua_BlackJack_ProjectL_UI_InviteNotifyUITask.<>f__mg$cache26 == null)
		{
			Lua_BlackJack_ProjectL_UI_InviteNotifyUITask.<>f__mg$cache26 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_InviteNotifyUITask.__callBase_IsLoadingCustomAssets);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_InviteNotifyUITask.<>f__mg$cache26);
		if (Lua_BlackJack_ProjectL_UI_InviteNotifyUITask.<>f__mg$cache27 == null)
		{
			Lua_BlackJack_ProjectL_UI_InviteNotifyUITask.<>f__mg$cache27 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_InviteNotifyUITask.__callBase_IsPipeLineRunning);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_InviteNotifyUITask.<>f__mg$cache27);
		if (Lua_BlackJack_ProjectL_UI_InviteNotifyUITask.<>f__mg$cache28 == null)
		{
			Lua_BlackJack_ProjectL_UI_InviteNotifyUITask.<>f__mg$cache28 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_InviteNotifyUITask.__callBase_IsOpeningUI);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_InviteNotifyUITask.<>f__mg$cache28);
		if (Lua_BlackJack_ProjectL_UI_InviteNotifyUITask.<>f__mg$cache29 == null)
		{
			Lua_BlackJack_ProjectL_UI_InviteNotifyUITask.<>f__mg$cache29 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_InviteNotifyUITask.__callBase_ReturnPrevUITask);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_InviteNotifyUITask.<>f__mg$cache29);
		if (Lua_BlackJack_ProjectL_UI_InviteNotifyUITask.<>f__mg$cache2A == null)
		{
			Lua_BlackJack_ProjectL_UI_InviteNotifyUITask.<>f__mg$cache2A = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_InviteNotifyUITask.__callBase_ClearUnusedDynamicResourceCache);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_InviteNotifyUITask.<>f__mg$cache2A);
		if (Lua_BlackJack_ProjectL_UI_InviteNotifyUITask.<>f__mg$cache2B == null)
		{
			Lua_BlackJack_ProjectL_UI_InviteNotifyUITask.<>f__mg$cache2B = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_InviteNotifyUITask.__callBase_OnMemoryWarning);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_InviteNotifyUITask.<>f__mg$cache2B);
		string name = "m_layerDescArray";
		if (Lua_BlackJack_ProjectL_UI_InviteNotifyUITask.<>f__mg$cache2C == null)
		{
			Lua_BlackJack_ProjectL_UI_InviteNotifyUITask.<>f__mg$cache2C = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_InviteNotifyUITask.get_m_layerDescArray);
		}
		LuaCSFunction get = Lua_BlackJack_ProjectL_UI_InviteNotifyUITask.<>f__mg$cache2C;
		if (Lua_BlackJack_ProjectL_UI_InviteNotifyUITask.<>f__mg$cache2D == null)
		{
			Lua_BlackJack_ProjectL_UI_InviteNotifyUITask.<>f__mg$cache2D = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_InviteNotifyUITask.set_m_layerDescArray);
		}
		LuaObject.addMember(l, name, get, Lua_BlackJack_ProjectL_UI_InviteNotifyUITask.<>f__mg$cache2D, true);
		string name2 = "m_uiCtrlDescArray";
		if (Lua_BlackJack_ProjectL_UI_InviteNotifyUITask.<>f__mg$cache2E == null)
		{
			Lua_BlackJack_ProjectL_UI_InviteNotifyUITask.<>f__mg$cache2E = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_InviteNotifyUITask.get_m_uiCtrlDescArray);
		}
		LuaCSFunction get2 = Lua_BlackJack_ProjectL_UI_InviteNotifyUITask.<>f__mg$cache2E;
		if (Lua_BlackJack_ProjectL_UI_InviteNotifyUITask.<>f__mg$cache2F == null)
		{
			Lua_BlackJack_ProjectL_UI_InviteNotifyUITask.<>f__mg$cache2F = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_InviteNotifyUITask.set_m_uiCtrlDescArray);
		}
		LuaObject.addMember(l, name2, get2, Lua_BlackJack_ProjectL_UI_InviteNotifyUITask.<>f__mg$cache2F, true);
		string name3 = "m_inviteNotifyUIController";
		if (Lua_BlackJack_ProjectL_UI_InviteNotifyUITask.<>f__mg$cache30 == null)
		{
			Lua_BlackJack_ProjectL_UI_InviteNotifyUITask.<>f__mg$cache30 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_InviteNotifyUITask.get_m_inviteNotifyUIController);
		}
		LuaCSFunction get3 = Lua_BlackJack_ProjectL_UI_InviteNotifyUITask.<>f__mg$cache30;
		if (Lua_BlackJack_ProjectL_UI_InviteNotifyUITask.<>f__mg$cache31 == null)
		{
			Lua_BlackJack_ProjectL_UI_InviteNotifyUITask.<>f__mg$cache31 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_InviteNotifyUITask.set_m_inviteNotifyUIController);
		}
		LuaObject.addMember(l, name3, get3, Lua_BlackJack_ProjectL_UI_InviteNotifyUITask.<>f__mg$cache31, true);
		string name4 = "m_inviteInfo";
		if (Lua_BlackJack_ProjectL_UI_InviteNotifyUITask.<>f__mg$cache32 == null)
		{
			Lua_BlackJack_ProjectL_UI_InviteNotifyUITask.<>f__mg$cache32 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_InviteNotifyUITask.get_m_inviteInfo);
		}
		LuaCSFunction get4 = Lua_BlackJack_ProjectL_UI_InviteNotifyUITask.<>f__mg$cache32;
		if (Lua_BlackJack_ProjectL_UI_InviteNotifyUITask.<>f__mg$cache33 == null)
		{
			Lua_BlackJack_ProjectL_UI_InviteNotifyUITask.<>f__mg$cache33 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_InviteNotifyUITask.set_m_inviteInfo);
		}
		LuaObject.addMember(l, name4, get4, Lua_BlackJack_ProjectL_UI_InviteNotifyUITask.<>f__mg$cache33, true);
		string name5 = "m_inviteInfoList";
		if (Lua_BlackJack_ProjectL_UI_InviteNotifyUITask.<>f__mg$cache34 == null)
		{
			Lua_BlackJack_ProjectL_UI_InviteNotifyUITask.<>f__mg$cache34 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_InviteNotifyUITask.get_m_inviteInfoList);
		}
		LuaCSFunction get5 = Lua_BlackJack_ProjectL_UI_InviteNotifyUITask.<>f__mg$cache34;
		if (Lua_BlackJack_ProjectL_UI_InviteNotifyUITask.<>f__mg$cache35 == null)
		{
			Lua_BlackJack_ProjectL_UI_InviteNotifyUITask.<>f__mg$cache35 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_InviteNotifyUITask.set_m_inviteInfoList);
		}
		LuaObject.addMember(l, name5, get5, Lua_BlackJack_ProjectL_UI_InviteNotifyUITask.<>f__mg$cache35, true);
		string name6 = "m_inviteCount";
		if (Lua_BlackJack_ProjectL_UI_InviteNotifyUITask.<>f__mg$cache36 == null)
		{
			Lua_BlackJack_ProjectL_UI_InviteNotifyUITask.<>f__mg$cache36 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_InviteNotifyUITask.get_m_inviteCount);
		}
		LuaCSFunction get6 = Lua_BlackJack_ProjectL_UI_InviteNotifyUITask.<>f__mg$cache36;
		if (Lua_BlackJack_ProjectL_UI_InviteNotifyUITask.<>f__mg$cache37 == null)
		{
			Lua_BlackJack_ProjectL_UI_InviteNotifyUITask.<>f__mg$cache37 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_InviteNotifyUITask.set_m_inviteCount);
		}
		LuaObject.addMember(l, name6, get6, Lua_BlackJack_ProjectL_UI_InviteNotifyUITask.<>f__mg$cache37, true);
		string name7 = "m_isDisableDisplay";
		if (Lua_BlackJack_ProjectL_UI_InviteNotifyUITask.<>f__mg$cache38 == null)
		{
			Lua_BlackJack_ProjectL_UI_InviteNotifyUITask.<>f__mg$cache38 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_InviteNotifyUITask.get_m_isDisableDisplay);
		}
		LuaCSFunction get7 = Lua_BlackJack_ProjectL_UI_InviteNotifyUITask.<>f__mg$cache38;
		if (Lua_BlackJack_ProjectL_UI_InviteNotifyUITask.<>f__mg$cache39 == null)
		{
			Lua_BlackJack_ProjectL_UI_InviteNotifyUITask.<>f__mg$cache39 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_InviteNotifyUITask.set_m_isDisableDisplay);
		}
		LuaObject.addMember(l, name7, get7, Lua_BlackJack_ProjectL_UI_InviteNotifyUITask.<>f__mg$cache39, false);
		string name8 = "LayerDescArray";
		if (Lua_BlackJack_ProjectL_UI_InviteNotifyUITask.<>f__mg$cache3A == null)
		{
			Lua_BlackJack_ProjectL_UI_InviteNotifyUITask.<>f__mg$cache3A = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_InviteNotifyUITask.get_LayerDescArray);
		}
		LuaObject.addMember(l, name8, Lua_BlackJack_ProjectL_UI_InviteNotifyUITask.<>f__mg$cache3A, null, true);
		string name9 = "UICtrlDescArray";
		if (Lua_BlackJack_ProjectL_UI_InviteNotifyUITask.<>f__mg$cache3B == null)
		{
			Lua_BlackJack_ProjectL_UI_InviteNotifyUITask.<>f__mg$cache3B = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_InviteNotifyUITask.get_UICtrlDescArray);
		}
		LuaObject.addMember(l, name9, Lua_BlackJack_ProjectL_UI_InviteNotifyUITask.<>f__mg$cache3B, null, true);
		if (Lua_BlackJack_ProjectL_UI_InviteNotifyUITask.<>f__mg$cache3C == null)
		{
			Lua_BlackJack_ProjectL_UI_InviteNotifyUITask.<>f__mg$cache3C = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_InviteNotifyUITask.constructor);
		}
		LuaObject.createTypeMetatable(l, Lua_BlackJack_ProjectL_UI_InviteNotifyUITask.<>f__mg$cache3C, typeof(InviteNotifyUITask), typeof(UITask));
	}

	// Token: 0x04015AC7 RID: 88775
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache0;

	// Token: 0x04015AC8 RID: 88776
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1;

	// Token: 0x04015AC9 RID: 88777
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2;

	// Token: 0x04015ACA RID: 88778
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3;

	// Token: 0x04015ACB RID: 88779
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache4;

	// Token: 0x04015ACC RID: 88780
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache5;

	// Token: 0x04015ACD RID: 88781
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache6;

	// Token: 0x04015ACE RID: 88782
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache7;

	// Token: 0x04015ACF RID: 88783
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache8;

	// Token: 0x04015AD0 RID: 88784
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache9;

	// Token: 0x04015AD1 RID: 88785
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheA;

	// Token: 0x04015AD2 RID: 88786
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheB;

	// Token: 0x04015AD3 RID: 88787
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheC;

	// Token: 0x04015AD4 RID: 88788
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheD;

	// Token: 0x04015AD5 RID: 88789
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheE;

	// Token: 0x04015AD6 RID: 88790
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheF;

	// Token: 0x04015AD7 RID: 88791
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache10;

	// Token: 0x04015AD8 RID: 88792
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache11;

	// Token: 0x04015AD9 RID: 88793
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache12;

	// Token: 0x04015ADA RID: 88794
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache13;

	// Token: 0x04015ADB RID: 88795
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache14;

	// Token: 0x04015ADC RID: 88796
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache15;

	// Token: 0x04015ADD RID: 88797
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache16;

	// Token: 0x04015ADE RID: 88798
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache17;

	// Token: 0x04015ADF RID: 88799
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache18;

	// Token: 0x04015AE0 RID: 88800
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache19;

	// Token: 0x04015AE1 RID: 88801
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1A;

	// Token: 0x04015AE2 RID: 88802
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1B;

	// Token: 0x04015AE3 RID: 88803
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1C;

	// Token: 0x04015AE4 RID: 88804
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1D;

	// Token: 0x04015AE5 RID: 88805
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1E;

	// Token: 0x04015AE6 RID: 88806
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1F;

	// Token: 0x04015AE7 RID: 88807
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache20;

	// Token: 0x04015AE8 RID: 88808
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache21;

	// Token: 0x04015AE9 RID: 88809
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache22;

	// Token: 0x04015AEA RID: 88810
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache23;

	// Token: 0x04015AEB RID: 88811
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache24;

	// Token: 0x04015AEC RID: 88812
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache25;

	// Token: 0x04015AED RID: 88813
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache26;

	// Token: 0x04015AEE RID: 88814
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache27;

	// Token: 0x04015AEF RID: 88815
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache28;

	// Token: 0x04015AF0 RID: 88816
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache29;

	// Token: 0x04015AF1 RID: 88817
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2A;

	// Token: 0x04015AF2 RID: 88818
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2B;

	// Token: 0x04015AF3 RID: 88819
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2C;

	// Token: 0x04015AF4 RID: 88820
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2D;

	// Token: 0x04015AF5 RID: 88821
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2E;

	// Token: 0x04015AF6 RID: 88822
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2F;

	// Token: 0x04015AF7 RID: 88823
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache30;

	// Token: 0x04015AF8 RID: 88824
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache31;

	// Token: 0x04015AF9 RID: 88825
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache32;

	// Token: 0x04015AFA RID: 88826
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache33;

	// Token: 0x04015AFB RID: 88827
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache34;

	// Token: 0x04015AFC RID: 88828
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache35;

	// Token: 0x04015AFD RID: 88829
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache36;

	// Token: 0x04015AFE RID: 88830
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache37;

	// Token: 0x04015AFF RID: 88831
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache38;

	// Token: 0x04015B00 RID: 88832
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache39;

	// Token: 0x04015B01 RID: 88833
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3A;

	// Token: 0x04015B02 RID: 88834
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3B;

	// Token: 0x04015B03 RID: 88835
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3C;
}
