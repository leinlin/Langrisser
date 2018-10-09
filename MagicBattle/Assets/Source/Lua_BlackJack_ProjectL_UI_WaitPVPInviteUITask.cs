using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using BlackJack.BJFramework.Runtime.UI;
using BlackJack.ProjectL.UI;
using SLua;
using UnityEngine.Scripting;

// Token: 0x020015E0 RID: 5600
[Preserve]
public class Lua_BlackJack_ProjectL_UI_WaitPVPInviteUITask : LuaObject
{
	// Token: 0x0602233E RID: 140094 RVA: 0x00BAF080 File Offset: 0x00BAD280
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int constructor(IntPtr l)
	{
		int result;
		try
		{
			string name;
			LuaObject.checkType(l, 2, out name);
			WaitPVPInviteUITask o = new WaitPVPInviteUITask(name);
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

	// Token: 0x0602233F RID: 140095 RVA: 0x00BAF0D4 File Offset: 0x00BAD2D4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int StartUITask_s(IntPtr l)
	{
		int result;
		try
		{
			string targetUserId;
			LuaObject.checkType(l, 1, out targetUserId);
			WaitPVPInviteUITask.StartUITask(targetUserId);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06022340 RID: 140096 RVA: 0x00BAF120 File Offset: 0x00BAD320
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int OnStart(IntPtr l)
	{
		int result;
		try
		{
			WaitPVPInviteUITask waitPVPInviteUITask = (WaitPVPInviteUITask)LuaObject.checkSelf(l);
			UIIntent intent;
			LuaObject.checkType<UIIntent>(l, 2, out intent);
			bool b = waitPVPInviteUITask.m_luaExportHelper.OnStart(intent);
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

	// Token: 0x06022341 RID: 140097 RVA: 0x00BAF188 File Offset: 0x00BAD388
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int OnResume(IntPtr l)
	{
		int result;
		try
		{
			WaitPVPInviteUITask waitPVPInviteUITask = (WaitPVPInviteUITask)LuaObject.checkSelf(l);
			UIIntent intent;
			LuaObject.checkType<UIIntent>(l, 2, out intent);
			bool b = waitPVPInviteUITask.m_luaExportHelper.OnResume(intent);
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

	// Token: 0x06022342 RID: 140098 RVA: 0x00BAF1F0 File Offset: 0x00BAD3F0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int InitDataFromUIIntent(IntPtr l)
	{
		int result;
		try
		{
			WaitPVPInviteUITask waitPVPInviteUITask = (WaitPVPInviteUITask)LuaObject.checkSelf(l);
			UIIntent intent;
			LuaObject.checkType<UIIntent>(l, 2, out intent);
			waitPVPInviteUITask.m_luaExportHelper.InitDataFromUIIntent(intent);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06022343 RID: 140099 RVA: 0x00BAF24C File Offset: 0x00BAD44C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int InitAllUIControllers(IntPtr l)
	{
		int result;
		try
		{
			WaitPVPInviteUITask waitPVPInviteUITask = (WaitPVPInviteUITask)LuaObject.checkSelf(l);
			waitPVPInviteUITask.m_luaExportHelper.InitAllUIControllers();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06022344 RID: 140100 RVA: 0x00BAF2A0 File Offset: 0x00BAD4A0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int ClearAllContextAndRes(IntPtr l)
	{
		int result;
		try
		{
			WaitPVPInviteUITask waitPVPInviteUITask = (WaitPVPInviteUITask)LuaObject.checkSelf(l);
			waitPVPInviteUITask.m_luaExportHelper.ClearAllContextAndRes();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06022345 RID: 140101 RVA: 0x00BAF2F4 File Offset: 0x00BAD4F4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int RegisterPlayerContextEvents(IntPtr l)
	{
		int result;
		try
		{
			WaitPVPInviteUITask waitPVPInviteUITask = (WaitPVPInviteUITask)LuaObject.checkSelf(l);
			waitPVPInviteUITask.m_luaExportHelper.RegisterPlayerContextEvents();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06022346 RID: 140102 RVA: 0x00BAF348 File Offset: 0x00BAD548
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int UnregisterPlayerContextEvents(IntPtr l)
	{
		int result;
		try
		{
			WaitPVPInviteUITask waitPVPInviteUITask = (WaitPVPInviteUITask)LuaObject.checkSelf(l);
			waitPVPInviteUITask.m_luaExportHelper.UnregisterPlayerContextEvents();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06022347 RID: 140103 RVA: 0x00BAF39C File Offset: 0x00BAD59C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int InitWaitPVPInviteUIController(IntPtr l)
	{
		int result;
		try
		{
			WaitPVPInviteUITask waitPVPInviteUITask = (WaitPVPInviteUITask)LuaObject.checkSelf(l);
			waitPVPInviteUITask.m_luaExportHelper.InitWaitPVPInviteUIController();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06022348 RID: 140104 RVA: 0x00BAF3F0 File Offset: 0x00BAD5F0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int UninitWaitPVPInviteUIController(IntPtr l)
	{
		int result;
		try
		{
			WaitPVPInviteUITask waitPVPInviteUITask = (WaitPVPInviteUITask)LuaObject.checkSelf(l);
			waitPVPInviteUITask.m_luaExportHelper.UninitWaitPVPInviteUIController();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06022349 RID: 140105 RVA: 0x00BAF444 File Offset: 0x00BAD644
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int UpdateView(IntPtr l)
	{
		int result;
		try
		{
			WaitPVPInviteUITask waitPVPInviteUITask = (WaitPVPInviteUITask)LuaObject.checkSelf(l);
			waitPVPInviteUITask.m_luaExportHelper.UpdateView();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0602234A RID: 140106 RVA: 0x00BAF498 File Offset: 0x00BAD698
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int OnTick(IntPtr l)
	{
		int result;
		try
		{
			WaitPVPInviteUITask waitPVPInviteUITask = (WaitPVPInviteUITask)LuaObject.checkSelf(l);
			waitPVPInviteUITask.m_luaExportHelper.OnTick();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0602234B RID: 140107 RVA: 0x00BAF4EC File Offset: 0x00BAD6EC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int StartBattlePracticeInviteNetTask(IntPtr l)
	{
		int result;
		try
		{
			WaitPVPInviteUITask waitPVPInviteUITask = (WaitPVPInviteUITask)LuaObject.checkSelf(l);
			string userId;
			LuaObject.checkType(l, 2, out userId);
			waitPVPInviteUITask.m_luaExportHelper.StartBattlePracticeInviteNetTask(userId);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0602234C RID: 140108 RVA: 0x00BAF548 File Offset: 0x00BAD748
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int CloseAndPause(IntPtr l)
	{
		int result;
		try
		{
			WaitPVPInviteUITask waitPVPInviteUITask = (WaitPVPInviteUITask)LuaObject.checkSelf(l);
			waitPVPInviteUITask.m_luaExportHelper.CloseAndPause();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0602234D RID: 140109 RVA: 0x00BAF59C File Offset: 0x00BAD79C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int WaitPVPInviteUIController_OnCancel(IntPtr l)
	{
		int result;
		try
		{
			WaitPVPInviteUITask waitPVPInviteUITask = (WaitPVPInviteUITask)LuaObject.checkSelf(l);
			waitPVPInviteUITask.m_luaExportHelper.WaitPVPInviteUIController_OnCancel();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0602234E RID: 140110 RVA: 0x00BAF5F0 File Offset: 0x00BAD7F0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int PlayerContext_OnOnBattlePracticeFailNtf(IntPtr l)
	{
		int result;
		try
		{
			WaitPVPInviteUITask waitPVPInviteUITask = (WaitPVPInviteUITask)LuaObject.checkSelf(l);
			waitPVPInviteUITask.m_luaExportHelper.PlayerContext_OnOnBattlePracticeFailNtf();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0602234F RID: 140111 RVA: 0x00BAF644 File Offset: 0x00BAD844
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int PlayerContext_OnBattlePracticeDeclinedNtf(IntPtr l)
	{
		int result;
		try
		{
			WaitPVPInviteUITask waitPVPInviteUITask = (WaitPVPInviteUITask)LuaObject.checkSelf(l);
			waitPVPInviteUITask.m_luaExportHelper.PlayerContext_OnBattlePracticeDeclinedNtf();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06022350 RID: 140112 RVA: 0x00BAF698 File Offset: 0x00BAD898
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_OnStart(IntPtr l)
	{
		int result;
		try
		{
			WaitPVPInviteUITask waitPVPInviteUITask = (WaitPVPInviteUITask)LuaObject.checkSelf(l);
			UIIntent intent;
			LuaObject.checkType<UIIntent>(l, 2, out intent);
			bool b = waitPVPInviteUITask.m_luaExportHelper.__callBase_OnStart(intent);
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

	// Token: 0x06022351 RID: 140113 RVA: 0x00BAF700 File Offset: 0x00BAD900
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_OnStop(IntPtr l)
	{
		int result;
		try
		{
			WaitPVPInviteUITask waitPVPInviteUITask = (WaitPVPInviteUITask)LuaObject.checkSelf(l);
			waitPVPInviteUITask.m_luaExportHelper.__callBase_OnStop();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06022352 RID: 140114 RVA: 0x00BAF754 File Offset: 0x00BAD954
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_OnPause(IntPtr l)
	{
		int result;
		try
		{
			WaitPVPInviteUITask waitPVPInviteUITask = (WaitPVPInviteUITask)LuaObject.checkSelf(l);
			waitPVPInviteUITask.m_luaExportHelper.__callBase_OnPause();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06022353 RID: 140115 RVA: 0x00BAF7A8 File Offset: 0x00BAD9A8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_OnResume(IntPtr l)
	{
		int result;
		try
		{
			WaitPVPInviteUITask waitPVPInviteUITask = (WaitPVPInviteUITask)LuaObject.checkSelf(l);
			UIIntent intent;
			LuaObject.checkType<UIIntent>(l, 2, out intent);
			bool b = waitPVPInviteUITask.m_luaExportHelper.__callBase_OnResume(intent);
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

	// Token: 0x06022354 RID: 140116 RVA: 0x00BAF810 File Offset: 0x00BADA10
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_OnNewIntent(IntPtr l)
	{
		int result;
		try
		{
			WaitPVPInviteUITask waitPVPInviteUITask = (WaitPVPInviteUITask)LuaObject.checkSelf(l);
			UIIntent intent;
			LuaObject.checkType<UIIntent>(l, 2, out intent);
			bool b = waitPVPInviteUITask.m_luaExportHelper.__callBase_OnNewIntent(intent);
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

	// Token: 0x06022355 RID: 140117 RVA: 0x00BAF878 File Offset: 0x00BADA78
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_EnableUIInput(IntPtr l)
	{
		int result;
		try
		{
			WaitPVPInviteUITask waitPVPInviteUITask = (WaitPVPInviteUITask)LuaObject.checkSelf(l);
			bool isEnable;
			LuaObject.checkType(l, 2, out isEnable);
			bool? isGlobalEnable;
			LuaObject.checkNullable<bool>(l, 3, out isGlobalEnable);
			waitPVPInviteUITask.m_luaExportHelper.__callBase_EnableUIInput(isEnable, isGlobalEnable);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06022356 RID: 140118 RVA: 0x00BAF8E4 File Offset: 0x00BADAE4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_IsNeedLoadDynamicRes(IntPtr l)
	{
		int result;
		try
		{
			WaitPVPInviteUITask waitPVPInviteUITask = (WaitPVPInviteUITask)LuaObject.checkSelf(l);
			bool b = waitPVPInviteUITask.m_luaExportHelper.__callBase_IsNeedLoadDynamicRes();
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

	// Token: 0x06022357 RID: 140119 RVA: 0x00BAF940 File Offset: 0x00BADB40
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_CollectAllDynamicResForLoad(IntPtr l)
	{
		int result;
		try
		{
			WaitPVPInviteUITask waitPVPInviteUITask = (WaitPVPInviteUITask)LuaObject.checkSelf(l);
			List<string> o = waitPVPInviteUITask.m_luaExportHelper.__callBase_CollectAllDynamicResForLoad();
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

	// Token: 0x06022358 RID: 140120 RVA: 0x00BAF99C File Offset: 0x00BADB9C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_RegisterPlayerContextEvents(IntPtr l)
	{
		int result;
		try
		{
			WaitPVPInviteUITask waitPVPInviteUITask = (WaitPVPInviteUITask)LuaObject.checkSelf(l);
			waitPVPInviteUITask.m_luaExportHelper.__callBase_RegisterPlayerContextEvents();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06022359 RID: 140121 RVA: 0x00BAF9F0 File Offset: 0x00BADBF0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_UnregisterPlayerContextEvents(IntPtr l)
	{
		int result;
		try
		{
			WaitPVPInviteUITask waitPVPInviteUITask = (WaitPVPInviteUITask)LuaObject.checkSelf(l);
			waitPVPInviteUITask.m_luaExportHelper.__callBase_UnregisterPlayerContextEvents();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0602235A RID: 140122 RVA: 0x00BAFA44 File Offset: 0x00BADC44
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_PostUpdateView(IntPtr l)
	{
		int result;
		try
		{
			WaitPVPInviteUITask waitPVPInviteUITask = (WaitPVPInviteUITask)LuaObject.checkSelf(l);
			waitPVPInviteUITask.m_luaExportHelper.__callBase_PostUpdateView();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0602235B RID: 140123 RVA: 0x00BAFA98 File Offset: 0x00BADC98
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_CollectPreloadResourceList(IntPtr l)
	{
		int result;
		try
		{
			WaitPVPInviteUITask waitPVPInviteUITask = (WaitPVPInviteUITask)LuaObject.checkSelf(l);
			waitPVPInviteUITask.m_luaExportHelper.__callBase_CollectPreloadResourceList();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0602235C RID: 140124 RVA: 0x00BAFAEC File Offset: 0x00BADCEC
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int __callBase_ClearAssetList(IntPtr l)
	{
		int result;
		try
		{
			WaitPVPInviteUITask waitPVPInviteUITask = (WaitPVPInviteUITask)LuaObject.checkSelf(l);
			waitPVPInviteUITask.m_luaExportHelper.__callBase_ClearAssetList();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0602235D RID: 140125 RVA: 0x00BAFB40 File Offset: 0x00BADD40
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_CollectAsset(IntPtr l)
	{
		int result;
		try
		{
			WaitPVPInviteUITask waitPVPInviteUITask = (WaitPVPInviteUITask)LuaObject.checkSelf(l);
			string assetName;
			LuaObject.checkType(l, 2, out assetName);
			waitPVPInviteUITask.m_luaExportHelper.__callBase_CollectAsset(assetName);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0602235E RID: 140126 RVA: 0x00BAFB9C File Offset: 0x00BADD9C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_CollectSpriteAsset(IntPtr l)
	{
		int result;
		try
		{
			WaitPVPInviteUITask waitPVPInviteUITask = (WaitPVPInviteUITask)LuaObject.checkSelf(l);
			string assetName;
			LuaObject.checkType(l, 2, out assetName);
			waitPVPInviteUITask.m_luaExportHelper.__callBase_CollectSpriteAsset(assetName);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0602235F RID: 140127 RVA: 0x00BAFBF8 File Offset: 0x00BADDF8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_CollectFxAsset(IntPtr l)
	{
		int result;
		try
		{
			WaitPVPInviteUITask waitPVPInviteUITask = (WaitPVPInviteUITask)LuaObject.checkSelf(l);
			string assetName;
			LuaObject.checkType(l, 2, out assetName);
			waitPVPInviteUITask.m_luaExportHelper.__callBase_CollectFxAsset(assetName);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06022360 RID: 140128 RVA: 0x00BAFC54 File Offset: 0x00BADE54
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_StartLoadCustomAssets(IntPtr l)
	{
		int result;
		try
		{
			WaitPVPInviteUITask waitPVPInviteUITask = (WaitPVPInviteUITask)LuaObject.checkSelf(l);
			Action onLoadCompleted;
			LuaObject.checkDelegate<Action>(l, 2, out onLoadCompleted);
			waitPVPInviteUITask.m_luaExportHelper.__callBase_StartLoadCustomAssets(onLoadCompleted);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06022361 RID: 140129 RVA: 0x00BAFCB0 File Offset: 0x00BADEB0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_IsLoadingCustomAssets(IntPtr l)
	{
		int result;
		try
		{
			WaitPVPInviteUITask waitPVPInviteUITask = (WaitPVPInviteUITask)LuaObject.checkSelf(l);
			bool b = waitPVPInviteUITask.m_luaExportHelper.__callBase_IsLoadingCustomAssets();
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

	// Token: 0x06022362 RID: 140130 RVA: 0x00BAFD0C File Offset: 0x00BADF0C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_IsPipeLineRunning(IntPtr l)
	{
		int result;
		try
		{
			WaitPVPInviteUITask waitPVPInviteUITask = (WaitPVPInviteUITask)LuaObject.checkSelf(l);
			bool b = waitPVPInviteUITask.m_luaExportHelper.__callBase_IsPipeLineRunning();
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

	// Token: 0x06022363 RID: 140131 RVA: 0x00BAFD68 File Offset: 0x00BADF68
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_IsOpeningUI(IntPtr l)
	{
		int result;
		try
		{
			WaitPVPInviteUITask waitPVPInviteUITask = (WaitPVPInviteUITask)LuaObject.checkSelf(l);
			bool b = waitPVPInviteUITask.m_luaExportHelper.__callBase_IsOpeningUI();
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

	// Token: 0x06022364 RID: 140132 RVA: 0x00BAFDC4 File Offset: 0x00BADFC4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_ReturnPrevUITask(IntPtr l)
	{
		int result;
		try
		{
			WaitPVPInviteUITask waitPVPInviteUITask = (WaitPVPInviteUITask)LuaObject.checkSelf(l);
			UITaskBase o = waitPVPInviteUITask.m_luaExportHelper.__callBase_ReturnPrevUITask();
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

	// Token: 0x06022365 RID: 140133 RVA: 0x00BAFE20 File Offset: 0x00BAE020
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_ClearUnusedDynamicResourceCache(IntPtr l)
	{
		int result;
		try
		{
			WaitPVPInviteUITask waitPVPInviteUITask = (WaitPVPInviteUITask)LuaObject.checkSelf(l);
			waitPVPInviteUITask.m_luaExportHelper.__callBase_ClearUnusedDynamicResourceCache();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06022366 RID: 140134 RVA: 0x00BAFE74 File Offset: 0x00BAE074
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int __callBase_OnMemoryWarning(IntPtr l)
	{
		int result;
		try
		{
			WaitPVPInviteUITask waitPVPInviteUITask = (WaitPVPInviteUITask)LuaObject.checkSelf(l);
			waitPVPInviteUITask.m_luaExportHelper.__callBase_OnMemoryWarning();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06022367 RID: 140135 RVA: 0x00BAFEC8 File Offset: 0x00BAE0C8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_layerDescArray(IntPtr l)
	{
		int result;
		try
		{
			WaitPVPInviteUITask waitPVPInviteUITask = (WaitPVPInviteUITask)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, waitPVPInviteUITask.m_luaExportHelper.m_layerDescArray);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06022368 RID: 140136 RVA: 0x00BAFF20 File Offset: 0x00BAE120
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_layerDescArray(IntPtr l)
	{
		int result;
		try
		{
			WaitPVPInviteUITask waitPVPInviteUITask = (WaitPVPInviteUITask)LuaObject.checkSelf(l);
			UITaskBase.LayerDesc[] layerDescArray;
			LuaObject.checkArray<UITaskBase.LayerDesc>(l, 2, out layerDescArray);
			waitPVPInviteUITask.m_luaExportHelper.m_layerDescArray = layerDescArray;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06022369 RID: 140137 RVA: 0x00BAFF7C File Offset: 0x00BAE17C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_uiCtrlDescArray(IntPtr l)
	{
		int result;
		try
		{
			WaitPVPInviteUITask waitPVPInviteUITask = (WaitPVPInviteUITask)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, waitPVPInviteUITask.m_luaExportHelper.m_uiCtrlDescArray);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0602236A RID: 140138 RVA: 0x00BAFFD4 File Offset: 0x00BAE1D4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_uiCtrlDescArray(IntPtr l)
	{
		int result;
		try
		{
			WaitPVPInviteUITask waitPVPInviteUITask = (WaitPVPInviteUITask)LuaObject.checkSelf(l);
			UITaskBase.UIControllerDesc[] uiCtrlDescArray;
			LuaObject.checkArray<UITaskBase.UIControllerDesc>(l, 2, out uiCtrlDescArray);
			waitPVPInviteUITask.m_luaExportHelper.m_uiCtrlDescArray = uiCtrlDescArray;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0602236B RID: 140139 RVA: 0x00BB0030 File Offset: 0x00BAE230
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_waitPVPInviteUIController(IntPtr l)
	{
		int result;
		try
		{
			WaitPVPInviteUITask waitPVPInviteUITask = (WaitPVPInviteUITask)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, waitPVPInviteUITask.m_luaExportHelper.m_waitPVPInviteUIController);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0602236C RID: 140140 RVA: 0x00BB0088 File Offset: 0x00BAE288
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_waitPVPInviteUIController(IntPtr l)
	{
		int result;
		try
		{
			WaitPVPInviteUITask waitPVPInviteUITask = (WaitPVPInviteUITask)LuaObject.checkSelf(l);
			WaitPVPInviteUIController waitPVPInviteUIController;
			LuaObject.checkType<WaitPVPInviteUIController>(l, 2, out waitPVPInviteUIController);
			waitPVPInviteUITask.m_luaExportHelper.m_waitPVPInviteUIController = waitPVPInviteUIController;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0602236D RID: 140141 RVA: 0x00BB00E4 File Offset: 0x00BAE2E4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_targetUserId(IntPtr l)
	{
		int result;
		try
		{
			WaitPVPInviteUITask waitPVPInviteUITask = (WaitPVPInviteUITask)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, waitPVPInviteUITask.m_luaExportHelper.m_targetUserId);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0602236E RID: 140142 RVA: 0x00BB013C File Offset: 0x00BAE33C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_targetUserId(IntPtr l)
	{
		int result;
		try
		{
			WaitPVPInviteUITask waitPVPInviteUITask = (WaitPVPInviteUITask)LuaObject.checkSelf(l);
			string targetUserId;
			LuaObject.checkType(l, 2, out targetUserId);
			waitPVPInviteUITask.m_luaExportHelper.m_targetUserId = targetUserId;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0602236F RID: 140143 RVA: 0x00BB0198 File Offset: 0x00BAE398
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_waitTimeout(IntPtr l)
	{
		int result;
		try
		{
			WaitPVPInviteUITask waitPVPInviteUITask = (WaitPVPInviteUITask)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, waitPVPInviteUITask.m_luaExportHelper.m_waitTimeout);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06022370 RID: 140144 RVA: 0x00BB01F4 File Offset: 0x00BAE3F4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_waitTimeout(IntPtr l)
	{
		int result;
		try
		{
			WaitPVPInviteUITask waitPVPInviteUITask = (WaitPVPInviteUITask)LuaObject.checkSelf(l);
			DateTime waitTimeout;
			LuaObject.checkValueType<DateTime>(l, 2, out waitTimeout);
			waitPVPInviteUITask.m_luaExportHelper.m_waitTimeout = waitTimeout;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06022371 RID: 140145 RVA: 0x00BB0250 File Offset: 0x00BAE450
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_LayerDescArray(IntPtr l)
	{
		int result;
		try
		{
			WaitPVPInviteUITask waitPVPInviteUITask = (WaitPVPInviteUITask)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, waitPVPInviteUITask.m_luaExportHelper.LayerDescArray);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06022372 RID: 140146 RVA: 0x00BB02A8 File Offset: 0x00BAE4A8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_UICtrlDescArray(IntPtr l)
	{
		int result;
		try
		{
			WaitPVPInviteUITask waitPVPInviteUITask = (WaitPVPInviteUITask)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, waitPVPInviteUITask.m_luaExportHelper.UICtrlDescArray);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06022373 RID: 140147 RVA: 0x00BB0300 File Offset: 0x00BAE500
	[Preserve]
	public static void reg(IntPtr l)
	{
		LuaObject.getTypeTable(l, "BlackJack.ProjectL.UI.WaitPVPInviteUITask");
		if (Lua_BlackJack_ProjectL_UI_WaitPVPInviteUITask.<>f__mg$cache0 == null)
		{
			Lua_BlackJack_ProjectL_UI_WaitPVPInviteUITask.<>f__mg$cache0 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_WaitPVPInviteUITask.StartUITask_s);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_WaitPVPInviteUITask.<>f__mg$cache0);
		if (Lua_BlackJack_ProjectL_UI_WaitPVPInviteUITask.<>f__mg$cache1 == null)
		{
			Lua_BlackJack_ProjectL_UI_WaitPVPInviteUITask.<>f__mg$cache1 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_WaitPVPInviteUITask.OnStart);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_WaitPVPInviteUITask.<>f__mg$cache1);
		if (Lua_BlackJack_ProjectL_UI_WaitPVPInviteUITask.<>f__mg$cache2 == null)
		{
			Lua_BlackJack_ProjectL_UI_WaitPVPInviteUITask.<>f__mg$cache2 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_WaitPVPInviteUITask.OnResume);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_WaitPVPInviteUITask.<>f__mg$cache2);
		if (Lua_BlackJack_ProjectL_UI_WaitPVPInviteUITask.<>f__mg$cache3 == null)
		{
			Lua_BlackJack_ProjectL_UI_WaitPVPInviteUITask.<>f__mg$cache3 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_WaitPVPInviteUITask.InitDataFromUIIntent);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_WaitPVPInviteUITask.<>f__mg$cache3);
		if (Lua_BlackJack_ProjectL_UI_WaitPVPInviteUITask.<>f__mg$cache4 == null)
		{
			Lua_BlackJack_ProjectL_UI_WaitPVPInviteUITask.<>f__mg$cache4 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_WaitPVPInviteUITask.InitAllUIControllers);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_WaitPVPInviteUITask.<>f__mg$cache4);
		if (Lua_BlackJack_ProjectL_UI_WaitPVPInviteUITask.<>f__mg$cache5 == null)
		{
			Lua_BlackJack_ProjectL_UI_WaitPVPInviteUITask.<>f__mg$cache5 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_WaitPVPInviteUITask.ClearAllContextAndRes);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_WaitPVPInviteUITask.<>f__mg$cache5);
		if (Lua_BlackJack_ProjectL_UI_WaitPVPInviteUITask.<>f__mg$cache6 == null)
		{
			Lua_BlackJack_ProjectL_UI_WaitPVPInviteUITask.<>f__mg$cache6 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_WaitPVPInviteUITask.RegisterPlayerContextEvents);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_WaitPVPInviteUITask.<>f__mg$cache6);
		if (Lua_BlackJack_ProjectL_UI_WaitPVPInviteUITask.<>f__mg$cache7 == null)
		{
			Lua_BlackJack_ProjectL_UI_WaitPVPInviteUITask.<>f__mg$cache7 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_WaitPVPInviteUITask.UnregisterPlayerContextEvents);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_WaitPVPInviteUITask.<>f__mg$cache7);
		if (Lua_BlackJack_ProjectL_UI_WaitPVPInviteUITask.<>f__mg$cache8 == null)
		{
			Lua_BlackJack_ProjectL_UI_WaitPVPInviteUITask.<>f__mg$cache8 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_WaitPVPInviteUITask.InitWaitPVPInviteUIController);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_WaitPVPInviteUITask.<>f__mg$cache8);
		if (Lua_BlackJack_ProjectL_UI_WaitPVPInviteUITask.<>f__mg$cache9 == null)
		{
			Lua_BlackJack_ProjectL_UI_WaitPVPInviteUITask.<>f__mg$cache9 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_WaitPVPInviteUITask.UninitWaitPVPInviteUIController);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_WaitPVPInviteUITask.<>f__mg$cache9);
		if (Lua_BlackJack_ProjectL_UI_WaitPVPInviteUITask.<>f__mg$cacheA == null)
		{
			Lua_BlackJack_ProjectL_UI_WaitPVPInviteUITask.<>f__mg$cacheA = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_WaitPVPInviteUITask.UpdateView);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_WaitPVPInviteUITask.<>f__mg$cacheA);
		if (Lua_BlackJack_ProjectL_UI_WaitPVPInviteUITask.<>f__mg$cacheB == null)
		{
			Lua_BlackJack_ProjectL_UI_WaitPVPInviteUITask.<>f__mg$cacheB = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_WaitPVPInviteUITask.OnTick);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_WaitPVPInviteUITask.<>f__mg$cacheB);
		if (Lua_BlackJack_ProjectL_UI_WaitPVPInviteUITask.<>f__mg$cacheC == null)
		{
			Lua_BlackJack_ProjectL_UI_WaitPVPInviteUITask.<>f__mg$cacheC = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_WaitPVPInviteUITask.StartBattlePracticeInviteNetTask);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_WaitPVPInviteUITask.<>f__mg$cacheC);
		if (Lua_BlackJack_ProjectL_UI_WaitPVPInviteUITask.<>f__mg$cacheD == null)
		{
			Lua_BlackJack_ProjectL_UI_WaitPVPInviteUITask.<>f__mg$cacheD = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_WaitPVPInviteUITask.CloseAndPause);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_WaitPVPInviteUITask.<>f__mg$cacheD);
		if (Lua_BlackJack_ProjectL_UI_WaitPVPInviteUITask.<>f__mg$cacheE == null)
		{
			Lua_BlackJack_ProjectL_UI_WaitPVPInviteUITask.<>f__mg$cacheE = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_WaitPVPInviteUITask.WaitPVPInviteUIController_OnCancel);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_WaitPVPInviteUITask.<>f__mg$cacheE);
		if (Lua_BlackJack_ProjectL_UI_WaitPVPInviteUITask.<>f__mg$cacheF == null)
		{
			Lua_BlackJack_ProjectL_UI_WaitPVPInviteUITask.<>f__mg$cacheF = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_WaitPVPInviteUITask.PlayerContext_OnOnBattlePracticeFailNtf);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_WaitPVPInviteUITask.<>f__mg$cacheF);
		if (Lua_BlackJack_ProjectL_UI_WaitPVPInviteUITask.<>f__mg$cache10 == null)
		{
			Lua_BlackJack_ProjectL_UI_WaitPVPInviteUITask.<>f__mg$cache10 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_WaitPVPInviteUITask.PlayerContext_OnBattlePracticeDeclinedNtf);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_WaitPVPInviteUITask.<>f__mg$cache10);
		if (Lua_BlackJack_ProjectL_UI_WaitPVPInviteUITask.<>f__mg$cache11 == null)
		{
			Lua_BlackJack_ProjectL_UI_WaitPVPInviteUITask.<>f__mg$cache11 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_WaitPVPInviteUITask.__callBase_OnStart);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_WaitPVPInviteUITask.<>f__mg$cache11);
		if (Lua_BlackJack_ProjectL_UI_WaitPVPInviteUITask.<>f__mg$cache12 == null)
		{
			Lua_BlackJack_ProjectL_UI_WaitPVPInviteUITask.<>f__mg$cache12 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_WaitPVPInviteUITask.__callBase_OnStop);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_WaitPVPInviteUITask.<>f__mg$cache12);
		if (Lua_BlackJack_ProjectL_UI_WaitPVPInviteUITask.<>f__mg$cache13 == null)
		{
			Lua_BlackJack_ProjectL_UI_WaitPVPInviteUITask.<>f__mg$cache13 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_WaitPVPInviteUITask.__callBase_OnPause);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_WaitPVPInviteUITask.<>f__mg$cache13);
		if (Lua_BlackJack_ProjectL_UI_WaitPVPInviteUITask.<>f__mg$cache14 == null)
		{
			Lua_BlackJack_ProjectL_UI_WaitPVPInviteUITask.<>f__mg$cache14 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_WaitPVPInviteUITask.__callBase_OnResume);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_WaitPVPInviteUITask.<>f__mg$cache14);
		if (Lua_BlackJack_ProjectL_UI_WaitPVPInviteUITask.<>f__mg$cache15 == null)
		{
			Lua_BlackJack_ProjectL_UI_WaitPVPInviteUITask.<>f__mg$cache15 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_WaitPVPInviteUITask.__callBase_OnNewIntent);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_WaitPVPInviteUITask.<>f__mg$cache15);
		if (Lua_BlackJack_ProjectL_UI_WaitPVPInviteUITask.<>f__mg$cache16 == null)
		{
			Lua_BlackJack_ProjectL_UI_WaitPVPInviteUITask.<>f__mg$cache16 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_WaitPVPInviteUITask.__callBase_EnableUIInput);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_WaitPVPInviteUITask.<>f__mg$cache16);
		if (Lua_BlackJack_ProjectL_UI_WaitPVPInviteUITask.<>f__mg$cache17 == null)
		{
			Lua_BlackJack_ProjectL_UI_WaitPVPInviteUITask.<>f__mg$cache17 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_WaitPVPInviteUITask.__callBase_IsNeedLoadDynamicRes);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_WaitPVPInviteUITask.<>f__mg$cache17);
		if (Lua_BlackJack_ProjectL_UI_WaitPVPInviteUITask.<>f__mg$cache18 == null)
		{
			Lua_BlackJack_ProjectL_UI_WaitPVPInviteUITask.<>f__mg$cache18 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_WaitPVPInviteUITask.__callBase_CollectAllDynamicResForLoad);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_WaitPVPInviteUITask.<>f__mg$cache18);
		if (Lua_BlackJack_ProjectL_UI_WaitPVPInviteUITask.<>f__mg$cache19 == null)
		{
			Lua_BlackJack_ProjectL_UI_WaitPVPInviteUITask.<>f__mg$cache19 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_WaitPVPInviteUITask.__callBase_RegisterPlayerContextEvents);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_WaitPVPInviteUITask.<>f__mg$cache19);
		if (Lua_BlackJack_ProjectL_UI_WaitPVPInviteUITask.<>f__mg$cache1A == null)
		{
			Lua_BlackJack_ProjectL_UI_WaitPVPInviteUITask.<>f__mg$cache1A = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_WaitPVPInviteUITask.__callBase_UnregisterPlayerContextEvents);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_WaitPVPInviteUITask.<>f__mg$cache1A);
		if (Lua_BlackJack_ProjectL_UI_WaitPVPInviteUITask.<>f__mg$cache1B == null)
		{
			Lua_BlackJack_ProjectL_UI_WaitPVPInviteUITask.<>f__mg$cache1B = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_WaitPVPInviteUITask.__callBase_PostUpdateView);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_WaitPVPInviteUITask.<>f__mg$cache1B);
		if (Lua_BlackJack_ProjectL_UI_WaitPVPInviteUITask.<>f__mg$cache1C == null)
		{
			Lua_BlackJack_ProjectL_UI_WaitPVPInviteUITask.<>f__mg$cache1C = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_WaitPVPInviteUITask.__callBase_CollectPreloadResourceList);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_WaitPVPInviteUITask.<>f__mg$cache1C);
		if (Lua_BlackJack_ProjectL_UI_WaitPVPInviteUITask.<>f__mg$cache1D == null)
		{
			Lua_BlackJack_ProjectL_UI_WaitPVPInviteUITask.<>f__mg$cache1D = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_WaitPVPInviteUITask.__callBase_ClearAssetList);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_WaitPVPInviteUITask.<>f__mg$cache1D);
		if (Lua_BlackJack_ProjectL_UI_WaitPVPInviteUITask.<>f__mg$cache1E == null)
		{
			Lua_BlackJack_ProjectL_UI_WaitPVPInviteUITask.<>f__mg$cache1E = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_WaitPVPInviteUITask.__callBase_CollectAsset);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_WaitPVPInviteUITask.<>f__mg$cache1E);
		if (Lua_BlackJack_ProjectL_UI_WaitPVPInviteUITask.<>f__mg$cache1F == null)
		{
			Lua_BlackJack_ProjectL_UI_WaitPVPInviteUITask.<>f__mg$cache1F = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_WaitPVPInviteUITask.__callBase_CollectSpriteAsset);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_WaitPVPInviteUITask.<>f__mg$cache1F);
		if (Lua_BlackJack_ProjectL_UI_WaitPVPInviteUITask.<>f__mg$cache20 == null)
		{
			Lua_BlackJack_ProjectL_UI_WaitPVPInviteUITask.<>f__mg$cache20 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_WaitPVPInviteUITask.__callBase_CollectFxAsset);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_WaitPVPInviteUITask.<>f__mg$cache20);
		if (Lua_BlackJack_ProjectL_UI_WaitPVPInviteUITask.<>f__mg$cache21 == null)
		{
			Lua_BlackJack_ProjectL_UI_WaitPVPInviteUITask.<>f__mg$cache21 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_WaitPVPInviteUITask.__callBase_StartLoadCustomAssets);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_WaitPVPInviteUITask.<>f__mg$cache21);
		if (Lua_BlackJack_ProjectL_UI_WaitPVPInviteUITask.<>f__mg$cache22 == null)
		{
			Lua_BlackJack_ProjectL_UI_WaitPVPInviteUITask.<>f__mg$cache22 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_WaitPVPInviteUITask.__callBase_IsLoadingCustomAssets);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_WaitPVPInviteUITask.<>f__mg$cache22);
		if (Lua_BlackJack_ProjectL_UI_WaitPVPInviteUITask.<>f__mg$cache23 == null)
		{
			Lua_BlackJack_ProjectL_UI_WaitPVPInviteUITask.<>f__mg$cache23 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_WaitPVPInviteUITask.__callBase_IsPipeLineRunning);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_WaitPVPInviteUITask.<>f__mg$cache23);
		if (Lua_BlackJack_ProjectL_UI_WaitPVPInviteUITask.<>f__mg$cache24 == null)
		{
			Lua_BlackJack_ProjectL_UI_WaitPVPInviteUITask.<>f__mg$cache24 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_WaitPVPInviteUITask.__callBase_IsOpeningUI);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_WaitPVPInviteUITask.<>f__mg$cache24);
		if (Lua_BlackJack_ProjectL_UI_WaitPVPInviteUITask.<>f__mg$cache25 == null)
		{
			Lua_BlackJack_ProjectL_UI_WaitPVPInviteUITask.<>f__mg$cache25 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_WaitPVPInviteUITask.__callBase_ReturnPrevUITask);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_WaitPVPInviteUITask.<>f__mg$cache25);
		if (Lua_BlackJack_ProjectL_UI_WaitPVPInviteUITask.<>f__mg$cache26 == null)
		{
			Lua_BlackJack_ProjectL_UI_WaitPVPInviteUITask.<>f__mg$cache26 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_WaitPVPInviteUITask.__callBase_ClearUnusedDynamicResourceCache);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_WaitPVPInviteUITask.<>f__mg$cache26);
		if (Lua_BlackJack_ProjectL_UI_WaitPVPInviteUITask.<>f__mg$cache27 == null)
		{
			Lua_BlackJack_ProjectL_UI_WaitPVPInviteUITask.<>f__mg$cache27 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_WaitPVPInviteUITask.__callBase_OnMemoryWarning);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_WaitPVPInviteUITask.<>f__mg$cache27);
		string name = "m_layerDescArray";
		if (Lua_BlackJack_ProjectL_UI_WaitPVPInviteUITask.<>f__mg$cache28 == null)
		{
			Lua_BlackJack_ProjectL_UI_WaitPVPInviteUITask.<>f__mg$cache28 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_WaitPVPInviteUITask.get_m_layerDescArray);
		}
		LuaCSFunction get = Lua_BlackJack_ProjectL_UI_WaitPVPInviteUITask.<>f__mg$cache28;
		if (Lua_BlackJack_ProjectL_UI_WaitPVPInviteUITask.<>f__mg$cache29 == null)
		{
			Lua_BlackJack_ProjectL_UI_WaitPVPInviteUITask.<>f__mg$cache29 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_WaitPVPInviteUITask.set_m_layerDescArray);
		}
		LuaObject.addMember(l, name, get, Lua_BlackJack_ProjectL_UI_WaitPVPInviteUITask.<>f__mg$cache29, true);
		string name2 = "m_uiCtrlDescArray";
		if (Lua_BlackJack_ProjectL_UI_WaitPVPInviteUITask.<>f__mg$cache2A == null)
		{
			Lua_BlackJack_ProjectL_UI_WaitPVPInviteUITask.<>f__mg$cache2A = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_WaitPVPInviteUITask.get_m_uiCtrlDescArray);
		}
		LuaCSFunction get2 = Lua_BlackJack_ProjectL_UI_WaitPVPInviteUITask.<>f__mg$cache2A;
		if (Lua_BlackJack_ProjectL_UI_WaitPVPInviteUITask.<>f__mg$cache2B == null)
		{
			Lua_BlackJack_ProjectL_UI_WaitPVPInviteUITask.<>f__mg$cache2B = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_WaitPVPInviteUITask.set_m_uiCtrlDescArray);
		}
		LuaObject.addMember(l, name2, get2, Lua_BlackJack_ProjectL_UI_WaitPVPInviteUITask.<>f__mg$cache2B, true);
		string name3 = "m_waitPVPInviteUIController";
		if (Lua_BlackJack_ProjectL_UI_WaitPVPInviteUITask.<>f__mg$cache2C == null)
		{
			Lua_BlackJack_ProjectL_UI_WaitPVPInviteUITask.<>f__mg$cache2C = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_WaitPVPInviteUITask.get_m_waitPVPInviteUIController);
		}
		LuaCSFunction get3 = Lua_BlackJack_ProjectL_UI_WaitPVPInviteUITask.<>f__mg$cache2C;
		if (Lua_BlackJack_ProjectL_UI_WaitPVPInviteUITask.<>f__mg$cache2D == null)
		{
			Lua_BlackJack_ProjectL_UI_WaitPVPInviteUITask.<>f__mg$cache2D = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_WaitPVPInviteUITask.set_m_waitPVPInviteUIController);
		}
		LuaObject.addMember(l, name3, get3, Lua_BlackJack_ProjectL_UI_WaitPVPInviteUITask.<>f__mg$cache2D, true);
		string name4 = "m_targetUserId";
		if (Lua_BlackJack_ProjectL_UI_WaitPVPInviteUITask.<>f__mg$cache2E == null)
		{
			Lua_BlackJack_ProjectL_UI_WaitPVPInviteUITask.<>f__mg$cache2E = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_WaitPVPInviteUITask.get_m_targetUserId);
		}
		LuaCSFunction get4 = Lua_BlackJack_ProjectL_UI_WaitPVPInviteUITask.<>f__mg$cache2E;
		if (Lua_BlackJack_ProjectL_UI_WaitPVPInviteUITask.<>f__mg$cache2F == null)
		{
			Lua_BlackJack_ProjectL_UI_WaitPVPInviteUITask.<>f__mg$cache2F = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_WaitPVPInviteUITask.set_m_targetUserId);
		}
		LuaObject.addMember(l, name4, get4, Lua_BlackJack_ProjectL_UI_WaitPVPInviteUITask.<>f__mg$cache2F, true);
		string name5 = "m_waitTimeout";
		if (Lua_BlackJack_ProjectL_UI_WaitPVPInviteUITask.<>f__mg$cache30 == null)
		{
			Lua_BlackJack_ProjectL_UI_WaitPVPInviteUITask.<>f__mg$cache30 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_WaitPVPInviteUITask.get_m_waitTimeout);
		}
		LuaCSFunction get5 = Lua_BlackJack_ProjectL_UI_WaitPVPInviteUITask.<>f__mg$cache30;
		if (Lua_BlackJack_ProjectL_UI_WaitPVPInviteUITask.<>f__mg$cache31 == null)
		{
			Lua_BlackJack_ProjectL_UI_WaitPVPInviteUITask.<>f__mg$cache31 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_WaitPVPInviteUITask.set_m_waitTimeout);
		}
		LuaObject.addMember(l, name5, get5, Lua_BlackJack_ProjectL_UI_WaitPVPInviteUITask.<>f__mg$cache31, true);
		string name6 = "LayerDescArray";
		if (Lua_BlackJack_ProjectL_UI_WaitPVPInviteUITask.<>f__mg$cache32 == null)
		{
			Lua_BlackJack_ProjectL_UI_WaitPVPInviteUITask.<>f__mg$cache32 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_WaitPVPInviteUITask.get_LayerDescArray);
		}
		LuaObject.addMember(l, name6, Lua_BlackJack_ProjectL_UI_WaitPVPInviteUITask.<>f__mg$cache32, null, true);
		string name7 = "UICtrlDescArray";
		if (Lua_BlackJack_ProjectL_UI_WaitPVPInviteUITask.<>f__mg$cache33 == null)
		{
			Lua_BlackJack_ProjectL_UI_WaitPVPInviteUITask.<>f__mg$cache33 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_WaitPVPInviteUITask.get_UICtrlDescArray);
		}
		LuaObject.addMember(l, name7, Lua_BlackJack_ProjectL_UI_WaitPVPInviteUITask.<>f__mg$cache33, null, true);
		if (Lua_BlackJack_ProjectL_UI_WaitPVPInviteUITask.<>f__mg$cache34 == null)
		{
			Lua_BlackJack_ProjectL_UI_WaitPVPInviteUITask.<>f__mg$cache34 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_WaitPVPInviteUITask.constructor);
		}
		LuaObject.createTypeMetatable(l, Lua_BlackJack_ProjectL_UI_WaitPVPInviteUITask.<>f__mg$cache34, typeof(WaitPVPInviteUITask), typeof(UITask));
	}

	// Token: 0x04018160 RID: 98656
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache0;

	// Token: 0x04018161 RID: 98657
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1;

	// Token: 0x04018162 RID: 98658
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2;

	// Token: 0x04018163 RID: 98659
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3;

	// Token: 0x04018164 RID: 98660
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache4;

	// Token: 0x04018165 RID: 98661
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache5;

	// Token: 0x04018166 RID: 98662
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache6;

	// Token: 0x04018167 RID: 98663
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache7;

	// Token: 0x04018168 RID: 98664
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache8;

	// Token: 0x04018169 RID: 98665
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache9;

	// Token: 0x0401816A RID: 98666
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheA;

	// Token: 0x0401816B RID: 98667
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheB;

	// Token: 0x0401816C RID: 98668
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheC;

	// Token: 0x0401816D RID: 98669
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheD;

	// Token: 0x0401816E RID: 98670
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheE;

	// Token: 0x0401816F RID: 98671
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheF;

	// Token: 0x04018170 RID: 98672
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache10;

	// Token: 0x04018171 RID: 98673
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache11;

	// Token: 0x04018172 RID: 98674
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache12;

	// Token: 0x04018173 RID: 98675
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache13;

	// Token: 0x04018174 RID: 98676
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache14;

	// Token: 0x04018175 RID: 98677
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache15;

	// Token: 0x04018176 RID: 98678
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache16;

	// Token: 0x04018177 RID: 98679
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache17;

	// Token: 0x04018178 RID: 98680
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache18;

	// Token: 0x04018179 RID: 98681
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache19;

	// Token: 0x0401817A RID: 98682
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1A;

	// Token: 0x0401817B RID: 98683
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1B;

	// Token: 0x0401817C RID: 98684
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1C;

	// Token: 0x0401817D RID: 98685
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1D;

	// Token: 0x0401817E RID: 98686
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1E;

	// Token: 0x0401817F RID: 98687
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1F;

	// Token: 0x04018180 RID: 98688
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache20;

	// Token: 0x04018181 RID: 98689
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache21;

	// Token: 0x04018182 RID: 98690
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache22;

	// Token: 0x04018183 RID: 98691
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache23;

	// Token: 0x04018184 RID: 98692
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache24;

	// Token: 0x04018185 RID: 98693
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache25;

	// Token: 0x04018186 RID: 98694
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache26;

	// Token: 0x04018187 RID: 98695
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache27;

	// Token: 0x04018188 RID: 98696
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache28;

	// Token: 0x04018189 RID: 98697
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache29;

	// Token: 0x0401818A RID: 98698
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2A;

	// Token: 0x0401818B RID: 98699
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2B;

	// Token: 0x0401818C RID: 98700
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2C;

	// Token: 0x0401818D RID: 98701
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2D;

	// Token: 0x0401818E RID: 98702
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2E;

	// Token: 0x0401818F RID: 98703
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2F;

	// Token: 0x04018190 RID: 98704
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache30;

	// Token: 0x04018191 RID: 98705
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache31;

	// Token: 0x04018192 RID: 98706
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache32;

	// Token: 0x04018193 RID: 98707
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache33;

	// Token: 0x04018194 RID: 98708
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache34;
}
