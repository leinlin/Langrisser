using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using BlackJack.BJFramework.Runtime.UI;
using BlackJack.ConfigData;
using BlackJack.ProjectL.Common;
using BlackJack.ProjectL.UI;
using SLua;
using UnityEngine.Scripting;

// Token: 0x02001404 RID: 5124
[Preserve]
public class Lua_BlackJack_ProjectL_UI_CommonUITask : LuaObject
{
	// Token: 0x0601CE8A RID: 118410 RVA: 0x0090D588 File Offset: 0x0090B788
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int constructor(IntPtr l)
	{
		int result;
		try
		{
			string name;
			LuaObject.checkType(l, 2, out name);
			CommonUITask o = new CommonUITask(name);
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

	// Token: 0x0601CE8B RID: 118411 RVA: 0x0090D5DC File Offset: 0x0090B7DC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int TickCheckOnline_s(IntPtr l)
	{
		int result;
		try
		{
			CommonUITask.TickCheckOnline();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601CE8C RID: 118412 RVA: 0x0090D61C File Offset: 0x0090B81C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int InitAllUIControllers(IntPtr l)
	{
		int result;
		try
		{
			CommonUITask commonUITask = (CommonUITask)LuaObject.checkSelf(l);
			commonUITask.m_luaExportHelper.InitAllUIControllers();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601CE8D RID: 118413 RVA: 0x0090D670 File Offset: 0x0090B870
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int ClearAllContextAndRes(IntPtr l)
	{
		int result;
		try
		{
			CommonUITask commonUITask = (CommonUITask)LuaObject.checkSelf(l);
			commonUITask.m_luaExportHelper.ClearAllContextAndRes();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601CE8E RID: 118414 RVA: 0x0090D6C4 File Offset: 0x0090B8C4
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int OnStart(IntPtr l)
	{
		int result;
		try
		{
			CommonUITask commonUITask = (CommonUITask)LuaObject.checkSelf(l);
			UIIntent intent;
			LuaObject.checkType<UIIntent>(l, 2, out intent);
			bool b = commonUITask.m_luaExportHelper.OnStart(intent);
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

	// Token: 0x0601CE8F RID: 118415 RVA: 0x0090D72C File Offset: 0x0090B92C
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int OnStop(IntPtr l)
	{
		int result;
		try
		{
			CommonUITask commonUITask = (CommonUITask)LuaObject.checkSelf(l);
			commonUITask.m_luaExportHelper.OnStop();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601CE90 RID: 118416 RVA: 0x0090D780 File Offset: 0x0090B980
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int OnTick(IntPtr l)
	{
		int result;
		try
		{
			CommonUITask commonUITask = (CommonUITask)LuaObject.checkSelf(l);
			commonUITask.m_luaExportHelper.OnTick();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601CE91 RID: 118417 RVA: 0x0090D7D4 File Offset: 0x0090B9D4
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int InitNetReq(IntPtr l)
	{
		int result;
		try
		{
			CommonUITask commonUITask = (CommonUITask)LuaObject.checkSelf(l);
			commonUITask.m_luaExportHelper.InitNetReq();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601CE92 RID: 118418 RVA: 0x0090D828 File Offset: 0x0090BA28
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int TickCheckClientVersion(IntPtr l)
	{
		int result;
		try
		{
			CommonUITask commonUITask = (CommonUITask)LuaObject.checkSelf(l);
			commonUITask.m_luaExportHelper.TickCheckClientVersion();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601CE93 RID: 118419 RVA: 0x0090D87C File Offset: 0x0090BA7C
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int TickChatVoice(IntPtr l)
	{
		int result;
		try
		{
			CommonUITask commonUITask = (CommonUITask)LuaObject.checkSelf(l);
			commonUITask.m_luaExportHelper.TickChatVoice();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601CE94 RID: 118420 RVA: 0x0090D8D0 File Offset: 0x0090BAD0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int TickClientHeartBeat(IntPtr l)
	{
		int result;
		try
		{
			CommonUITask commonUITask = (CommonUITask)LuaObject.checkSelf(l);
			commonUITask.m_luaExportHelper.TickClientHeartBeat();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601CE95 RID: 118421 RVA: 0x0090D924 File Offset: 0x0090BB24
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int _TickCheckOnline(IntPtr l)
	{
		int result;
		try
		{
			CommonUITask commonUITask = (CommonUITask)LuaObject.checkSelf(l);
			commonUITask.m_luaExportHelper._TickCheckOnline();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601CE96 RID: 118422 RVA: 0x0090D978 File Offset: 0x0090BB78
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int UpdateView(IntPtr l)
	{
		int result;
		try
		{
			CommonUITask commonUITask = (CommonUITask)LuaObject.checkSelf(l);
			commonUITask.m_luaExportHelper.UpdateView();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601CE97 RID: 118423 RVA: 0x0090D9CC File Offset: 0x0090BBCC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int IsNeedLoadDynamicRes(IntPtr l)
	{
		int result;
		try
		{
			CommonUITask commonUITask = (CommonUITask)LuaObject.checkSelf(l);
			bool b = commonUITask.m_luaExportHelper.IsNeedLoadDynamicRes();
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

	// Token: 0x0601CE98 RID: 118424 RVA: 0x0090DA28 File Offset: 0x0090BC28
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int PostUpdateView(IntPtr l)
	{
		int result;
		try
		{
			CommonUITask commonUITask = (CommonUITask)LuaObject.checkSelf(l);
			commonUITask.m_luaExportHelper.PostUpdateView();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601CE99 RID: 118425 RVA: 0x0090DA7C File Offset: 0x0090BC7C
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int PlayerContext_OnNewMarqueeNtf(IntPtr l)
	{
		int result;
		try
		{
			CommonUITask commonUITask = (CommonUITask)LuaObject.checkSelf(l);
			Marquee marquee;
			LuaObject.checkType<Marquee>(l, 2, out marquee);
			commonUITask.m_luaExportHelper.PlayerContext_OnNewMarqueeNtf(marquee);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601CE9A RID: 118426 RVA: 0x0090DAD8 File Offset: 0x0090BCD8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int PlayerContext_OnServerDisconnectNtf(IntPtr l)
	{
		int result;
		try
		{
			CommonUITask commonUITask = (CommonUITask)LuaObject.checkSelf(l);
			int errorCode;
			LuaObject.checkType(l, 2, out errorCode);
			commonUITask.m_luaExportHelper.PlayerContext_OnServerDisconnectNtf(errorCode);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601CE9B RID: 118427 RVA: 0x0090DB34 File Offset: 0x0090BD34
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int PlayerContext_OnClientCheatNtf(IntPtr l)
	{
		int result;
		try
		{
			CommonUITask commonUITask = (CommonUITask)LuaObject.checkSelf(l);
			commonUITask.m_luaExportHelper.PlayerContext_OnClientCheatNtf();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601CE9C RID: 118428 RVA: 0x0090DB88 File Offset: 0x0090BD88
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int PlayerContext_EventOnGuildUpdateInfo(IntPtr l)
	{
		int result;
		try
		{
			CommonUITask commonUITask = (CommonUITask)LuaObject.checkSelf(l);
			GuildLog log;
			LuaObject.checkType<GuildLog>(l, 2, out log);
			commonUITask.m_luaExportHelper.PlayerContext_EventOnGuildUpdateInfo(log);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601CE9D RID: 118429 RVA: 0x0090DBE4 File Offset: 0x0090BDE4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int EventOnSDKPromotingPlaySuccess(IntPtr l)
	{
		int result;
		try
		{
			CommonUITask commonUITask = (CommonUITask)LuaObject.checkSelf(l);
			string goodsRegisterID;
			LuaObject.checkType(l, 2, out goodsRegisterID);
			commonUITask.m_luaExportHelper.EventOnSDKPromotingPlaySuccess(goodsRegisterID);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601CE9E RID: 118430 RVA: 0x0090DC40 File Offset: 0x0090BE40
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int StartWorldUITask(IntPtr l)
	{
		int result;
		try
		{
			CommonUITask commonUITask = (CommonUITask)LuaObject.checkSelf(l);
			commonUITask.m_luaExportHelper.StartWorldUITask();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601CE9F RID: 118431 RVA: 0x0090DC94 File Offset: 0x0090BE94
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int WorldUITask_OnLoadAllResCompleted(IntPtr l)
	{
		int result;
		try
		{
			CommonUITask commonUITask = (CommonUITask)LuaObject.checkSelf(l);
			commonUITask.m_luaExportHelper.WorldUITask_OnLoadAllResCompleted();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601CEA0 RID: 118432 RVA: 0x0090DCE8 File Offset: 0x0090BEE8
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int StartBattleUITask(IntPtr l)
	{
		int result;
		try
		{
			CommonUITask commonUITask = (CommonUITask)LuaObject.checkSelf(l);
			commonUITask.m_luaExportHelper.StartBattleUITask();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601CEA1 RID: 118433 RVA: 0x0090DD3C File Offset: 0x0090BF3C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int BattleUITask_OnLoadAllResCompleted(IntPtr l)
	{
		int result;
		try
		{
			CommonUITask commonUITask = (CommonUITask)LuaObject.checkSelf(l);
			commonUITask.m_luaExportHelper.BattleUITask_OnLoadAllResCompleted();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601CEA2 RID: 118434 RVA: 0x0090DD90 File Offset: 0x0090BF90
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int StartArenaBattleUITask(IntPtr l)
	{
		int result;
		try
		{
			CommonUITask commonUITask = (CommonUITask)LuaObject.checkSelf(l);
			bool b = commonUITask.m_luaExportHelper.StartArenaBattleUITask();
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

	// Token: 0x0601CEA3 RID: 118435 RVA: 0x0090DDEC File Offset: 0x0090BFEC
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int CheckEnterBattle(IntPtr l)
	{
		int result;
		try
		{
			CommonUITask commonUITask = (CommonUITask)LuaObject.checkSelf(l);
			bool b = commonUITask.m_luaExportHelper.CheckEnterBattle();
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

	// Token: 0x0601CEA4 RID: 118436 RVA: 0x0090DE48 File Offset: 0x0090C048
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int RebuildBattle(IntPtr l)
	{
		int result;
		try
		{
			CommonUITask commonUITask = (CommonUITask)LuaObject.checkSelf(l);
			bool b = commonUITask.m_luaExportHelper.RebuildBattle();
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

	// Token: 0x0601CEA5 RID: 118437 RVA: 0x0090DEA4 File Offset: 0x0090C0A4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int RebuildBattleHappening(IntPtr l)
	{
		int result;
		try
		{
			CommonUITask commonUITask = (CommonUITask)LuaObject.checkSelf(l);
			BattleType battleType;
			LuaObject.checkEnum<BattleType>(l, 2, out battleType);
			int levelId;
			LuaObject.checkType(l, 3, out levelId);
			bool b = commonUITask.m_luaExportHelper.RebuildBattleHappening(battleType, levelId);
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

	// Token: 0x0601CEA6 RID: 118438 RVA: 0x0090DF18 File Offset: 0x0090C118
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int RebuildArenaBattle(IntPtr l)
	{
		int result;
		try
		{
			CommonUITask commonUITask = (CommonUITask)LuaObject.checkSelf(l);
			bool b = commonUITask.m_luaExportHelper.RebuildArenaBattle();
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

	// Token: 0x0601CEA7 RID: 118439 RVA: 0x0090DF74 File Offset: 0x0090C174
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int RebuildBattleRoom(IntPtr l)
	{
		int result;
		try
		{
			CommonUITask commonUITask = (CommonUITask)LuaObject.checkSelf(l);
			bool b = commonUITask.m_luaExportHelper.RebuildBattleRoom();
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

	// Token: 0x0601CEA8 RID: 118440 RVA: 0x0090DFD0 File Offset: 0x0090C1D0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int StartArenaBattleCancelNetTaskAndStartWorldUITask(IntPtr l)
	{
		int result;
		try
		{
			CommonUITask commonUITask = (CommonUITask)LuaObject.checkSelf(l);
			commonUITask.m_luaExportHelper.StartArenaBattleCancelNetTaskAndStartWorldUITask();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601CEA9 RID: 118441 RVA: 0x0090E024 File Offset: 0x0090C224
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_OnStart(IntPtr l)
	{
		int result;
		try
		{
			CommonUITask commonUITask = (CommonUITask)LuaObject.checkSelf(l);
			UIIntent intent;
			LuaObject.checkType<UIIntent>(l, 2, out intent);
			bool b = commonUITask.m_luaExportHelper.__callBase_OnStart(intent);
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

	// Token: 0x0601CEAA RID: 118442 RVA: 0x0090E08C File Offset: 0x0090C28C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_OnStop(IntPtr l)
	{
		int result;
		try
		{
			CommonUITask commonUITask = (CommonUITask)LuaObject.checkSelf(l);
			commonUITask.m_luaExportHelper.__callBase_OnStop();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601CEAB RID: 118443 RVA: 0x0090E0E0 File Offset: 0x0090C2E0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_OnPause(IntPtr l)
	{
		int result;
		try
		{
			CommonUITask commonUITask = (CommonUITask)LuaObject.checkSelf(l);
			commonUITask.m_luaExportHelper.__callBase_OnPause();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601CEAC RID: 118444 RVA: 0x0090E134 File Offset: 0x0090C334
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int __callBase_OnResume(IntPtr l)
	{
		int result;
		try
		{
			CommonUITask commonUITask = (CommonUITask)LuaObject.checkSelf(l);
			UIIntent intent;
			LuaObject.checkType<UIIntent>(l, 2, out intent);
			bool b = commonUITask.m_luaExportHelper.__callBase_OnResume(intent);
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

	// Token: 0x0601CEAD RID: 118445 RVA: 0x0090E19C File Offset: 0x0090C39C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_OnNewIntent(IntPtr l)
	{
		int result;
		try
		{
			CommonUITask commonUITask = (CommonUITask)LuaObject.checkSelf(l);
			UIIntent intent;
			LuaObject.checkType<UIIntent>(l, 2, out intent);
			bool b = commonUITask.m_luaExportHelper.__callBase_OnNewIntent(intent);
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

	// Token: 0x0601CEAE RID: 118446 RVA: 0x0090E204 File Offset: 0x0090C404
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_EnableUIInput(IntPtr l)
	{
		int result;
		try
		{
			CommonUITask commonUITask = (CommonUITask)LuaObject.checkSelf(l);
			bool isEnable;
			LuaObject.checkType(l, 2, out isEnable);
			bool? isGlobalEnable;
			LuaObject.checkNullable<bool>(l, 3, out isGlobalEnable);
			commonUITask.m_luaExportHelper.__callBase_EnableUIInput(isEnable, isGlobalEnable);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601CEAF RID: 118447 RVA: 0x0090E270 File Offset: 0x0090C470
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_IsNeedLoadDynamicRes(IntPtr l)
	{
		int result;
		try
		{
			CommonUITask commonUITask = (CommonUITask)LuaObject.checkSelf(l);
			bool b = commonUITask.m_luaExportHelper.__callBase_IsNeedLoadDynamicRes();
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

	// Token: 0x0601CEB0 RID: 118448 RVA: 0x0090E2CC File Offset: 0x0090C4CC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_CollectAllDynamicResForLoad(IntPtr l)
	{
		int result;
		try
		{
			CommonUITask commonUITask = (CommonUITask)LuaObject.checkSelf(l);
			List<string> o = commonUITask.m_luaExportHelper.__callBase_CollectAllDynamicResForLoad();
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

	// Token: 0x0601CEB1 RID: 118449 RVA: 0x0090E328 File Offset: 0x0090C528
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_RegisterPlayerContextEvents(IntPtr l)
	{
		int result;
		try
		{
			CommonUITask commonUITask = (CommonUITask)LuaObject.checkSelf(l);
			commonUITask.m_luaExportHelper.__callBase_RegisterPlayerContextEvents();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601CEB2 RID: 118450 RVA: 0x0090E37C File Offset: 0x0090C57C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_UnregisterPlayerContextEvents(IntPtr l)
	{
		int result;
		try
		{
			CommonUITask commonUITask = (CommonUITask)LuaObject.checkSelf(l);
			commonUITask.m_luaExportHelper.__callBase_UnregisterPlayerContextEvents();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601CEB3 RID: 118451 RVA: 0x0090E3D0 File Offset: 0x0090C5D0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_PostUpdateView(IntPtr l)
	{
		int result;
		try
		{
			CommonUITask commonUITask = (CommonUITask)LuaObject.checkSelf(l);
			commonUITask.m_luaExportHelper.__callBase_PostUpdateView();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601CEB4 RID: 118452 RVA: 0x0090E424 File Offset: 0x0090C624
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_CollectPreloadResourceList(IntPtr l)
	{
		int result;
		try
		{
			CommonUITask commonUITask = (CommonUITask)LuaObject.checkSelf(l);
			commonUITask.m_luaExportHelper.__callBase_CollectPreloadResourceList();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601CEB5 RID: 118453 RVA: 0x0090E478 File Offset: 0x0090C678
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_ClearAssetList(IntPtr l)
	{
		int result;
		try
		{
			CommonUITask commonUITask = (CommonUITask)LuaObject.checkSelf(l);
			commonUITask.m_luaExportHelper.__callBase_ClearAssetList();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601CEB6 RID: 118454 RVA: 0x0090E4CC File Offset: 0x0090C6CC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_CollectAsset(IntPtr l)
	{
		int result;
		try
		{
			CommonUITask commonUITask = (CommonUITask)LuaObject.checkSelf(l);
			string assetName;
			LuaObject.checkType(l, 2, out assetName);
			commonUITask.m_luaExportHelper.__callBase_CollectAsset(assetName);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601CEB7 RID: 118455 RVA: 0x0090E528 File Offset: 0x0090C728
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int __callBase_CollectSpriteAsset(IntPtr l)
	{
		int result;
		try
		{
			CommonUITask commonUITask = (CommonUITask)LuaObject.checkSelf(l);
			string assetName;
			LuaObject.checkType(l, 2, out assetName);
			commonUITask.m_luaExportHelper.__callBase_CollectSpriteAsset(assetName);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601CEB8 RID: 118456 RVA: 0x0090E584 File Offset: 0x0090C784
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_CollectFxAsset(IntPtr l)
	{
		int result;
		try
		{
			CommonUITask commonUITask = (CommonUITask)LuaObject.checkSelf(l);
			string assetName;
			LuaObject.checkType(l, 2, out assetName);
			commonUITask.m_luaExportHelper.__callBase_CollectFxAsset(assetName);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601CEB9 RID: 118457 RVA: 0x0090E5E0 File Offset: 0x0090C7E0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_StartLoadCustomAssets(IntPtr l)
	{
		int result;
		try
		{
			CommonUITask commonUITask = (CommonUITask)LuaObject.checkSelf(l);
			Action onLoadCompleted;
			LuaObject.checkDelegate<Action>(l, 2, out onLoadCompleted);
			commonUITask.m_luaExportHelper.__callBase_StartLoadCustomAssets(onLoadCompleted);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601CEBA RID: 118458 RVA: 0x0090E63C File Offset: 0x0090C83C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_IsLoadingCustomAssets(IntPtr l)
	{
		int result;
		try
		{
			CommonUITask commonUITask = (CommonUITask)LuaObject.checkSelf(l);
			bool b = commonUITask.m_luaExportHelper.__callBase_IsLoadingCustomAssets();
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

	// Token: 0x0601CEBB RID: 118459 RVA: 0x0090E698 File Offset: 0x0090C898
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int __callBase_IsPipeLineRunning(IntPtr l)
	{
		int result;
		try
		{
			CommonUITask commonUITask = (CommonUITask)LuaObject.checkSelf(l);
			bool b = commonUITask.m_luaExportHelper.__callBase_IsPipeLineRunning();
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

	// Token: 0x0601CEBC RID: 118460 RVA: 0x0090E6F4 File Offset: 0x0090C8F4
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int __callBase_IsOpeningUI(IntPtr l)
	{
		int result;
		try
		{
			CommonUITask commonUITask = (CommonUITask)LuaObject.checkSelf(l);
			bool b = commonUITask.m_luaExportHelper.__callBase_IsOpeningUI();
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

	// Token: 0x0601CEBD RID: 118461 RVA: 0x0090E750 File Offset: 0x0090C950
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int __callBase_ReturnPrevUITask(IntPtr l)
	{
		int result;
		try
		{
			CommonUITask commonUITask = (CommonUITask)LuaObject.checkSelf(l);
			UITaskBase o = commonUITask.m_luaExportHelper.__callBase_ReturnPrevUITask();
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

	// Token: 0x0601CEBE RID: 118462 RVA: 0x0090E7AC File Offset: 0x0090C9AC
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int __callBase_ClearUnusedDynamicResourceCache(IntPtr l)
	{
		int result;
		try
		{
			CommonUITask commonUITask = (CommonUITask)LuaObject.checkSelf(l);
			commonUITask.m_luaExportHelper.__callBase_ClearUnusedDynamicResourceCache();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601CEBF RID: 118463 RVA: 0x0090E800 File Offset: 0x0090CA00
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_OnMemoryWarning(IntPtr l)
	{
		int result;
		try
		{
			CommonUITask commonUITask = (CommonUITask)LuaObject.checkSelf(l);
			commonUITask.m_luaExportHelper.__callBase_OnMemoryWarning();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601CEC0 RID: 118464 RVA: 0x0090E854 File Offset: 0x0090CA54
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int StartBattleCancelNetTask_s(IntPtr l)
	{
		int result;
		try
		{
			Action<int> onEnd;
			LuaObject.checkDelegate<Action<int>>(l, 1, out onEnd);
			CommonUITask.LuaExportHelper.StartBattleCancelNetTask(onEnd);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601CEC1 RID: 118465 RVA: 0x0090E8A0 File Offset: 0x0090CAA0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int StartArenaPlayerInfoGetNetTask_s(IntPtr l)
	{
		int result;
		try
		{
			Action<int> onEnd;
			LuaObject.checkDelegate<Action<int>>(l, 1, out onEnd);
			CommonUITask.LuaExportHelper.StartArenaPlayerInfoGetNetTask(onEnd);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601CEC2 RID: 118466 RVA: 0x0090E8EC File Offset: 0x0090CAEC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int StartArenaBattleReconnectNetTask_s(IntPtr l)
	{
		int result;
		try
		{
			Action<int> onEnd;
			LuaObject.checkDelegate<Action<int>>(l, 1, out onEnd);
			CommonUITask.LuaExportHelper.StartArenaBattleReconnectNetTask(onEnd);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601CEC3 RID: 118467 RVA: 0x0090E938 File Offset: 0x0090CB38
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int StartBattleRoomGetNetTask_s(IntPtr l)
	{
		int result;
		try
		{
			Action<int> onEnd;
			LuaObject.checkDelegate<Action<int>>(l, 1, out onEnd);
			CommonUITask.LuaExportHelper.StartBattleRoomGetNetTask(onEnd);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601CEC4 RID: 118468 RVA: 0x0090E984 File Offset: 0x0090CB84
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int StartRealTimePVPGetInfoNetTask_s(IntPtr l)
	{
		int result;
		try
		{
			Action<int> onEnd;
			LuaObject.checkDelegate<Action<int>>(l, 1, out onEnd);
			CommonUITask.LuaExportHelper.StartRealTimePVPGetInfoNetTask(onEnd);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601CEC5 RID: 118469 RVA: 0x0090E9D0 File Offset: 0x0090CBD0
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_m_state(IntPtr l)
	{
		int result;
		try
		{
			CommonUITask commonUITask = (CommonUITask)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, commonUITask.m_luaExportHelper.m_state);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601CEC6 RID: 118470 RVA: 0x0090EA28 File Offset: 0x0090CC28
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_state(IntPtr l)
	{
		int result;
		try
		{
			CommonUITask commonUITask = (CommonUITask)LuaObject.checkSelf(l);
			int state;
			LuaObject.checkType(l, 2, out state);
			commonUITask.m_luaExportHelper.m_state = state;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601CEC7 RID: 118471 RVA: 0x0090EA84 File Offset: 0x0090CC84
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_s_instance(IntPtr l)
	{
		int result;
		try
		{
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, CommonUITask.LuaExportHelper.s_instance);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601CEC8 RID: 118472 RVA: 0x0090EACC File Offset: 0x0090CCCC
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_s_instance(IntPtr l)
	{
		int result;
		try
		{
			CommonUITask s_instance;
			LuaObject.checkType<CommonUITask>(l, 2, out s_instance);
			CommonUITask.LuaExportHelper.s_instance = s_instance;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601CEC9 RID: 118473 RVA: 0x0090EB18 File Offset: 0x0090CD18
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_layerDescArray(IntPtr l)
	{
		int result;
		try
		{
			CommonUITask commonUITask = (CommonUITask)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, commonUITask.m_luaExportHelper.m_layerDescArray);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601CECA RID: 118474 RVA: 0x0090EB70 File Offset: 0x0090CD70
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_layerDescArray(IntPtr l)
	{
		int result;
		try
		{
			CommonUITask commonUITask = (CommonUITask)LuaObject.checkSelf(l);
			UITaskBase.LayerDesc[] layerDescArray;
			LuaObject.checkArray<UITaskBase.LayerDesc>(l, 2, out layerDescArray);
			commonUITask.m_luaExportHelper.m_layerDescArray = layerDescArray;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601CECB RID: 118475 RVA: 0x0090EBCC File Offset: 0x0090CDCC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_uiCtrlDescArray(IntPtr l)
	{
		int result;
		try
		{
			CommonUITask commonUITask = (CommonUITask)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, commonUITask.m_luaExportHelper.m_uiCtrlDescArray);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601CECC RID: 118476 RVA: 0x0090EC24 File Offset: 0x0090CE24
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_uiCtrlDescArray(IntPtr l)
	{
		int result;
		try
		{
			CommonUITask commonUITask = (CommonUITask)LuaObject.checkSelf(l);
			UITaskBase.UIControllerDesc[] uiCtrlDescArray;
			LuaObject.checkArray<UITaskBase.UIControllerDesc>(l, 2, out uiCtrlDescArray);
			commonUITask.m_luaExportHelper.m_uiCtrlDescArray = uiCtrlDescArray;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601CECD RID: 118477 RVA: 0x0090EC80 File Offset: 0x0090CE80
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_commonUIController(IntPtr l)
	{
		int result;
		try
		{
			CommonUITask commonUITask = (CommonUITask)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, commonUITask.m_luaExportHelper.m_commonUIController);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601CECE RID: 118478 RVA: 0x0090ECD8 File Offset: 0x0090CED8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_commonUIController(IntPtr l)
	{
		int result;
		try
		{
			CommonUITask commonUITask = (CommonUITask)LuaObject.checkSelf(l);
			CommonUIController commonUIController;
			LuaObject.checkType<CommonUIController>(l, 2, out commonUIController);
			commonUITask.m_luaExportHelper.m_commonUIController = commonUIController;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601CECF RID: 118479 RVA: 0x0090ED34 File Offset: 0x0090CF34
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_sendHeartBeatTime(IntPtr l)
	{
		int result;
		try
		{
			CommonUITask commonUITask = (CommonUITask)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, commonUITask.m_luaExportHelper.m_sendHeartBeatTime);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601CED0 RID: 118480 RVA: 0x0090ED8C File Offset: 0x0090CF8C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_sendHeartBeatTime(IntPtr l)
	{
		int result;
		try
		{
			CommonUITask commonUITask = (CommonUITask)LuaObject.checkSelf(l);
			float sendHeartBeatTime;
			LuaObject.checkType(l, 2, out sendHeartBeatTime);
			commonUITask.m_luaExportHelper.m_sendHeartBeatTime = sendHeartBeatTime;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601CED1 RID: 118481 RVA: 0x0090EDE8 File Offset: 0x0090CFE8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_nextCheckOnlineTime(IntPtr l)
	{
		int result;
		try
		{
			CommonUITask commonUITask = (CommonUITask)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, commonUITask.m_luaExportHelper.m_nextCheckOnlineTime);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601CED2 RID: 118482 RVA: 0x0090EE44 File Offset: 0x0090D044
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_nextCheckOnlineTime(IntPtr l)
	{
		int result;
		try
		{
			CommonUITask commonUITask = (CommonUITask)LuaObject.checkSelf(l);
			DateTime nextCheckOnlineTime;
			LuaObject.checkValueType<DateTime>(l, 2, out nextCheckOnlineTime);
			commonUITask.m_luaExportHelper.m_nextCheckOnlineTime = nextCheckOnlineTime;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601CED3 RID: 118483 RVA: 0x0090EEA0 File Offset: 0x0090D0A0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_disconnectedByServerMessageId(IntPtr l)
	{
		int result;
		try
		{
			CommonUITask commonUITask = (CommonUITask)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushEnum(l, (int)commonUITask.m_luaExportHelper.m_disconnectedByServerMessageId);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601CED4 RID: 118484 RVA: 0x0090EEF8 File Offset: 0x0090D0F8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_disconnectedByServerMessageId(IntPtr l)
	{
		int result;
		try
		{
			CommonUITask commonUITask = (CommonUITask)LuaObject.checkSelf(l);
			StringTableId disconnectedByServerMessageId;
			LuaObject.checkEnum<StringTableId>(l, 2, out disconnectedByServerMessageId);
			commonUITask.m_luaExportHelper.m_disconnectedByServerMessageId = disconnectedByServerMessageId;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601CED5 RID: 118485 RVA: 0x0090EF54 File Offset: 0x0090D154
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_lastCheckClientVersionTime(IntPtr l)
	{
		int result;
		try
		{
			CommonUITask commonUITask = (CommonUITask)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, commonUITask.m_luaExportHelper.m_lastCheckClientVersionTime);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601CED6 RID: 118486 RVA: 0x0090EFAC File Offset: 0x0090D1AC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_lastCheckClientVersionTime(IntPtr l)
	{
		int result;
		try
		{
			CommonUITask commonUITask = (CommonUITask)LuaObject.checkSelf(l);
			float lastCheckClientVersionTime;
			LuaObject.checkType(l, 2, out lastCheckClientVersionTime);
			commonUITask.m_luaExportHelper.m_lastCheckClientVersionTime = lastCheckClientVersionTime;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601CED7 RID: 118487 RVA: 0x0090F008 File Offset: 0x0090D208
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_LayerDescArray(IntPtr l)
	{
		int result;
		try
		{
			CommonUITask commonUITask = (CommonUITask)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, commonUITask.m_luaExportHelper.LayerDescArray);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601CED8 RID: 118488 RVA: 0x0090F060 File Offset: 0x0090D260
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_UICtrlDescArray(IntPtr l)
	{
		int result;
		try
		{
			CommonUITask commonUITask = (CommonUITask)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, commonUITask.m_luaExportHelper.UICtrlDescArray);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601CED9 RID: 118489 RVA: 0x0090F0B8 File Offset: 0x0090D2B8
	[Preserve]
	public static void reg(IntPtr l)
	{
		LuaObject.getTypeTable(l, "BlackJack.ProjectL.UI.CommonUITask");
		if (Lua_BlackJack_ProjectL_UI_CommonUITask.<>f__mg$cache0 == null)
		{
			Lua_BlackJack_ProjectL_UI_CommonUITask.<>f__mg$cache0 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_CommonUITask.TickCheckOnline_s);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_CommonUITask.<>f__mg$cache0);
		if (Lua_BlackJack_ProjectL_UI_CommonUITask.<>f__mg$cache1 == null)
		{
			Lua_BlackJack_ProjectL_UI_CommonUITask.<>f__mg$cache1 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_CommonUITask.InitAllUIControllers);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_CommonUITask.<>f__mg$cache1);
		if (Lua_BlackJack_ProjectL_UI_CommonUITask.<>f__mg$cache2 == null)
		{
			Lua_BlackJack_ProjectL_UI_CommonUITask.<>f__mg$cache2 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_CommonUITask.ClearAllContextAndRes);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_CommonUITask.<>f__mg$cache2);
		if (Lua_BlackJack_ProjectL_UI_CommonUITask.<>f__mg$cache3 == null)
		{
			Lua_BlackJack_ProjectL_UI_CommonUITask.<>f__mg$cache3 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_CommonUITask.OnStart);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_CommonUITask.<>f__mg$cache3);
		if (Lua_BlackJack_ProjectL_UI_CommonUITask.<>f__mg$cache4 == null)
		{
			Lua_BlackJack_ProjectL_UI_CommonUITask.<>f__mg$cache4 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_CommonUITask.OnStop);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_CommonUITask.<>f__mg$cache4);
		if (Lua_BlackJack_ProjectL_UI_CommonUITask.<>f__mg$cache5 == null)
		{
			Lua_BlackJack_ProjectL_UI_CommonUITask.<>f__mg$cache5 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_CommonUITask.OnTick);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_CommonUITask.<>f__mg$cache5);
		if (Lua_BlackJack_ProjectL_UI_CommonUITask.<>f__mg$cache6 == null)
		{
			Lua_BlackJack_ProjectL_UI_CommonUITask.<>f__mg$cache6 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_CommonUITask.InitNetReq);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_CommonUITask.<>f__mg$cache6);
		if (Lua_BlackJack_ProjectL_UI_CommonUITask.<>f__mg$cache7 == null)
		{
			Lua_BlackJack_ProjectL_UI_CommonUITask.<>f__mg$cache7 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_CommonUITask.TickCheckClientVersion);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_CommonUITask.<>f__mg$cache7);
		if (Lua_BlackJack_ProjectL_UI_CommonUITask.<>f__mg$cache8 == null)
		{
			Lua_BlackJack_ProjectL_UI_CommonUITask.<>f__mg$cache8 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_CommonUITask.TickChatVoice);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_CommonUITask.<>f__mg$cache8);
		if (Lua_BlackJack_ProjectL_UI_CommonUITask.<>f__mg$cache9 == null)
		{
			Lua_BlackJack_ProjectL_UI_CommonUITask.<>f__mg$cache9 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_CommonUITask.TickClientHeartBeat);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_CommonUITask.<>f__mg$cache9);
		if (Lua_BlackJack_ProjectL_UI_CommonUITask.<>f__mg$cacheA == null)
		{
			Lua_BlackJack_ProjectL_UI_CommonUITask.<>f__mg$cacheA = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_CommonUITask._TickCheckOnline);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_CommonUITask.<>f__mg$cacheA);
		if (Lua_BlackJack_ProjectL_UI_CommonUITask.<>f__mg$cacheB == null)
		{
			Lua_BlackJack_ProjectL_UI_CommonUITask.<>f__mg$cacheB = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_CommonUITask.UpdateView);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_CommonUITask.<>f__mg$cacheB);
		if (Lua_BlackJack_ProjectL_UI_CommonUITask.<>f__mg$cacheC == null)
		{
			Lua_BlackJack_ProjectL_UI_CommonUITask.<>f__mg$cacheC = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_CommonUITask.IsNeedLoadDynamicRes);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_CommonUITask.<>f__mg$cacheC);
		if (Lua_BlackJack_ProjectL_UI_CommonUITask.<>f__mg$cacheD == null)
		{
			Lua_BlackJack_ProjectL_UI_CommonUITask.<>f__mg$cacheD = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_CommonUITask.PostUpdateView);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_CommonUITask.<>f__mg$cacheD);
		if (Lua_BlackJack_ProjectL_UI_CommonUITask.<>f__mg$cacheE == null)
		{
			Lua_BlackJack_ProjectL_UI_CommonUITask.<>f__mg$cacheE = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_CommonUITask.PlayerContext_OnNewMarqueeNtf);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_CommonUITask.<>f__mg$cacheE);
		if (Lua_BlackJack_ProjectL_UI_CommonUITask.<>f__mg$cacheF == null)
		{
			Lua_BlackJack_ProjectL_UI_CommonUITask.<>f__mg$cacheF = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_CommonUITask.PlayerContext_OnServerDisconnectNtf);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_CommonUITask.<>f__mg$cacheF);
		if (Lua_BlackJack_ProjectL_UI_CommonUITask.<>f__mg$cache10 == null)
		{
			Lua_BlackJack_ProjectL_UI_CommonUITask.<>f__mg$cache10 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_CommonUITask.PlayerContext_OnClientCheatNtf);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_CommonUITask.<>f__mg$cache10);
		if (Lua_BlackJack_ProjectL_UI_CommonUITask.<>f__mg$cache11 == null)
		{
			Lua_BlackJack_ProjectL_UI_CommonUITask.<>f__mg$cache11 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_CommonUITask.PlayerContext_EventOnGuildUpdateInfo);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_CommonUITask.<>f__mg$cache11);
		if (Lua_BlackJack_ProjectL_UI_CommonUITask.<>f__mg$cache12 == null)
		{
			Lua_BlackJack_ProjectL_UI_CommonUITask.<>f__mg$cache12 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_CommonUITask.EventOnSDKPromotingPlaySuccess);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_CommonUITask.<>f__mg$cache12);
		if (Lua_BlackJack_ProjectL_UI_CommonUITask.<>f__mg$cache13 == null)
		{
			Lua_BlackJack_ProjectL_UI_CommonUITask.<>f__mg$cache13 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_CommonUITask.StartWorldUITask);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_CommonUITask.<>f__mg$cache13);
		if (Lua_BlackJack_ProjectL_UI_CommonUITask.<>f__mg$cache14 == null)
		{
			Lua_BlackJack_ProjectL_UI_CommonUITask.<>f__mg$cache14 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_CommonUITask.WorldUITask_OnLoadAllResCompleted);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_CommonUITask.<>f__mg$cache14);
		if (Lua_BlackJack_ProjectL_UI_CommonUITask.<>f__mg$cache15 == null)
		{
			Lua_BlackJack_ProjectL_UI_CommonUITask.<>f__mg$cache15 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_CommonUITask.StartBattleUITask);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_CommonUITask.<>f__mg$cache15);
		if (Lua_BlackJack_ProjectL_UI_CommonUITask.<>f__mg$cache16 == null)
		{
			Lua_BlackJack_ProjectL_UI_CommonUITask.<>f__mg$cache16 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_CommonUITask.BattleUITask_OnLoadAllResCompleted);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_CommonUITask.<>f__mg$cache16);
		if (Lua_BlackJack_ProjectL_UI_CommonUITask.<>f__mg$cache17 == null)
		{
			Lua_BlackJack_ProjectL_UI_CommonUITask.<>f__mg$cache17 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_CommonUITask.StartArenaBattleUITask);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_CommonUITask.<>f__mg$cache17);
		if (Lua_BlackJack_ProjectL_UI_CommonUITask.<>f__mg$cache18 == null)
		{
			Lua_BlackJack_ProjectL_UI_CommonUITask.<>f__mg$cache18 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_CommonUITask.CheckEnterBattle);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_CommonUITask.<>f__mg$cache18);
		if (Lua_BlackJack_ProjectL_UI_CommonUITask.<>f__mg$cache19 == null)
		{
			Lua_BlackJack_ProjectL_UI_CommonUITask.<>f__mg$cache19 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_CommonUITask.RebuildBattle);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_CommonUITask.<>f__mg$cache19);
		if (Lua_BlackJack_ProjectL_UI_CommonUITask.<>f__mg$cache1A == null)
		{
			Lua_BlackJack_ProjectL_UI_CommonUITask.<>f__mg$cache1A = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_CommonUITask.RebuildBattleHappening);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_CommonUITask.<>f__mg$cache1A);
		if (Lua_BlackJack_ProjectL_UI_CommonUITask.<>f__mg$cache1B == null)
		{
			Lua_BlackJack_ProjectL_UI_CommonUITask.<>f__mg$cache1B = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_CommonUITask.RebuildArenaBattle);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_CommonUITask.<>f__mg$cache1B);
		if (Lua_BlackJack_ProjectL_UI_CommonUITask.<>f__mg$cache1C == null)
		{
			Lua_BlackJack_ProjectL_UI_CommonUITask.<>f__mg$cache1C = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_CommonUITask.RebuildBattleRoom);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_CommonUITask.<>f__mg$cache1C);
		if (Lua_BlackJack_ProjectL_UI_CommonUITask.<>f__mg$cache1D == null)
		{
			Lua_BlackJack_ProjectL_UI_CommonUITask.<>f__mg$cache1D = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_CommonUITask.StartArenaBattleCancelNetTaskAndStartWorldUITask);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_CommonUITask.<>f__mg$cache1D);
		if (Lua_BlackJack_ProjectL_UI_CommonUITask.<>f__mg$cache1E == null)
		{
			Lua_BlackJack_ProjectL_UI_CommonUITask.<>f__mg$cache1E = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_CommonUITask.__callBase_OnStart);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_CommonUITask.<>f__mg$cache1E);
		if (Lua_BlackJack_ProjectL_UI_CommonUITask.<>f__mg$cache1F == null)
		{
			Lua_BlackJack_ProjectL_UI_CommonUITask.<>f__mg$cache1F = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_CommonUITask.__callBase_OnStop);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_CommonUITask.<>f__mg$cache1F);
		if (Lua_BlackJack_ProjectL_UI_CommonUITask.<>f__mg$cache20 == null)
		{
			Lua_BlackJack_ProjectL_UI_CommonUITask.<>f__mg$cache20 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_CommonUITask.__callBase_OnPause);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_CommonUITask.<>f__mg$cache20);
		if (Lua_BlackJack_ProjectL_UI_CommonUITask.<>f__mg$cache21 == null)
		{
			Lua_BlackJack_ProjectL_UI_CommonUITask.<>f__mg$cache21 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_CommonUITask.__callBase_OnResume);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_CommonUITask.<>f__mg$cache21);
		if (Lua_BlackJack_ProjectL_UI_CommonUITask.<>f__mg$cache22 == null)
		{
			Lua_BlackJack_ProjectL_UI_CommonUITask.<>f__mg$cache22 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_CommonUITask.__callBase_OnNewIntent);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_CommonUITask.<>f__mg$cache22);
		if (Lua_BlackJack_ProjectL_UI_CommonUITask.<>f__mg$cache23 == null)
		{
			Lua_BlackJack_ProjectL_UI_CommonUITask.<>f__mg$cache23 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_CommonUITask.__callBase_EnableUIInput);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_CommonUITask.<>f__mg$cache23);
		if (Lua_BlackJack_ProjectL_UI_CommonUITask.<>f__mg$cache24 == null)
		{
			Lua_BlackJack_ProjectL_UI_CommonUITask.<>f__mg$cache24 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_CommonUITask.__callBase_IsNeedLoadDynamicRes);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_CommonUITask.<>f__mg$cache24);
		if (Lua_BlackJack_ProjectL_UI_CommonUITask.<>f__mg$cache25 == null)
		{
			Lua_BlackJack_ProjectL_UI_CommonUITask.<>f__mg$cache25 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_CommonUITask.__callBase_CollectAllDynamicResForLoad);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_CommonUITask.<>f__mg$cache25);
		if (Lua_BlackJack_ProjectL_UI_CommonUITask.<>f__mg$cache26 == null)
		{
			Lua_BlackJack_ProjectL_UI_CommonUITask.<>f__mg$cache26 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_CommonUITask.__callBase_RegisterPlayerContextEvents);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_CommonUITask.<>f__mg$cache26);
		if (Lua_BlackJack_ProjectL_UI_CommonUITask.<>f__mg$cache27 == null)
		{
			Lua_BlackJack_ProjectL_UI_CommonUITask.<>f__mg$cache27 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_CommonUITask.__callBase_UnregisterPlayerContextEvents);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_CommonUITask.<>f__mg$cache27);
		if (Lua_BlackJack_ProjectL_UI_CommonUITask.<>f__mg$cache28 == null)
		{
			Lua_BlackJack_ProjectL_UI_CommonUITask.<>f__mg$cache28 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_CommonUITask.__callBase_PostUpdateView);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_CommonUITask.<>f__mg$cache28);
		if (Lua_BlackJack_ProjectL_UI_CommonUITask.<>f__mg$cache29 == null)
		{
			Lua_BlackJack_ProjectL_UI_CommonUITask.<>f__mg$cache29 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_CommonUITask.__callBase_CollectPreloadResourceList);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_CommonUITask.<>f__mg$cache29);
		if (Lua_BlackJack_ProjectL_UI_CommonUITask.<>f__mg$cache2A == null)
		{
			Lua_BlackJack_ProjectL_UI_CommonUITask.<>f__mg$cache2A = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_CommonUITask.__callBase_ClearAssetList);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_CommonUITask.<>f__mg$cache2A);
		if (Lua_BlackJack_ProjectL_UI_CommonUITask.<>f__mg$cache2B == null)
		{
			Lua_BlackJack_ProjectL_UI_CommonUITask.<>f__mg$cache2B = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_CommonUITask.__callBase_CollectAsset);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_CommonUITask.<>f__mg$cache2B);
		if (Lua_BlackJack_ProjectL_UI_CommonUITask.<>f__mg$cache2C == null)
		{
			Lua_BlackJack_ProjectL_UI_CommonUITask.<>f__mg$cache2C = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_CommonUITask.__callBase_CollectSpriteAsset);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_CommonUITask.<>f__mg$cache2C);
		if (Lua_BlackJack_ProjectL_UI_CommonUITask.<>f__mg$cache2D == null)
		{
			Lua_BlackJack_ProjectL_UI_CommonUITask.<>f__mg$cache2D = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_CommonUITask.__callBase_CollectFxAsset);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_CommonUITask.<>f__mg$cache2D);
		if (Lua_BlackJack_ProjectL_UI_CommonUITask.<>f__mg$cache2E == null)
		{
			Lua_BlackJack_ProjectL_UI_CommonUITask.<>f__mg$cache2E = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_CommonUITask.__callBase_StartLoadCustomAssets);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_CommonUITask.<>f__mg$cache2E);
		if (Lua_BlackJack_ProjectL_UI_CommonUITask.<>f__mg$cache2F == null)
		{
			Lua_BlackJack_ProjectL_UI_CommonUITask.<>f__mg$cache2F = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_CommonUITask.__callBase_IsLoadingCustomAssets);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_CommonUITask.<>f__mg$cache2F);
		if (Lua_BlackJack_ProjectL_UI_CommonUITask.<>f__mg$cache30 == null)
		{
			Lua_BlackJack_ProjectL_UI_CommonUITask.<>f__mg$cache30 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_CommonUITask.__callBase_IsPipeLineRunning);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_CommonUITask.<>f__mg$cache30);
		if (Lua_BlackJack_ProjectL_UI_CommonUITask.<>f__mg$cache31 == null)
		{
			Lua_BlackJack_ProjectL_UI_CommonUITask.<>f__mg$cache31 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_CommonUITask.__callBase_IsOpeningUI);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_CommonUITask.<>f__mg$cache31);
		if (Lua_BlackJack_ProjectL_UI_CommonUITask.<>f__mg$cache32 == null)
		{
			Lua_BlackJack_ProjectL_UI_CommonUITask.<>f__mg$cache32 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_CommonUITask.__callBase_ReturnPrevUITask);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_CommonUITask.<>f__mg$cache32);
		if (Lua_BlackJack_ProjectL_UI_CommonUITask.<>f__mg$cache33 == null)
		{
			Lua_BlackJack_ProjectL_UI_CommonUITask.<>f__mg$cache33 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_CommonUITask.__callBase_ClearUnusedDynamicResourceCache);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_CommonUITask.<>f__mg$cache33);
		if (Lua_BlackJack_ProjectL_UI_CommonUITask.<>f__mg$cache34 == null)
		{
			Lua_BlackJack_ProjectL_UI_CommonUITask.<>f__mg$cache34 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_CommonUITask.__callBase_OnMemoryWarning);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_CommonUITask.<>f__mg$cache34);
		if (Lua_BlackJack_ProjectL_UI_CommonUITask.<>f__mg$cache35 == null)
		{
			Lua_BlackJack_ProjectL_UI_CommonUITask.<>f__mg$cache35 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_CommonUITask.StartBattleCancelNetTask_s);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_CommonUITask.<>f__mg$cache35);
		if (Lua_BlackJack_ProjectL_UI_CommonUITask.<>f__mg$cache36 == null)
		{
			Lua_BlackJack_ProjectL_UI_CommonUITask.<>f__mg$cache36 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_CommonUITask.StartArenaPlayerInfoGetNetTask_s);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_CommonUITask.<>f__mg$cache36);
		if (Lua_BlackJack_ProjectL_UI_CommonUITask.<>f__mg$cache37 == null)
		{
			Lua_BlackJack_ProjectL_UI_CommonUITask.<>f__mg$cache37 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_CommonUITask.StartArenaBattleReconnectNetTask_s);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_CommonUITask.<>f__mg$cache37);
		if (Lua_BlackJack_ProjectL_UI_CommonUITask.<>f__mg$cache38 == null)
		{
			Lua_BlackJack_ProjectL_UI_CommonUITask.<>f__mg$cache38 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_CommonUITask.StartBattleRoomGetNetTask_s);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_CommonUITask.<>f__mg$cache38);
		if (Lua_BlackJack_ProjectL_UI_CommonUITask.<>f__mg$cache39 == null)
		{
			Lua_BlackJack_ProjectL_UI_CommonUITask.<>f__mg$cache39 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_CommonUITask.StartRealTimePVPGetInfoNetTask_s);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_CommonUITask.<>f__mg$cache39);
		string name = "m_state";
		if (Lua_BlackJack_ProjectL_UI_CommonUITask.<>f__mg$cache3A == null)
		{
			Lua_BlackJack_ProjectL_UI_CommonUITask.<>f__mg$cache3A = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_CommonUITask.get_m_state);
		}
		LuaCSFunction get = Lua_BlackJack_ProjectL_UI_CommonUITask.<>f__mg$cache3A;
		if (Lua_BlackJack_ProjectL_UI_CommonUITask.<>f__mg$cache3B == null)
		{
			Lua_BlackJack_ProjectL_UI_CommonUITask.<>f__mg$cache3B = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_CommonUITask.set_m_state);
		}
		LuaObject.addMember(l, name, get, Lua_BlackJack_ProjectL_UI_CommonUITask.<>f__mg$cache3B, true);
		string name2 = "s_instance";
		if (Lua_BlackJack_ProjectL_UI_CommonUITask.<>f__mg$cache3C == null)
		{
			Lua_BlackJack_ProjectL_UI_CommonUITask.<>f__mg$cache3C = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_CommonUITask.get_s_instance);
		}
		LuaCSFunction get2 = Lua_BlackJack_ProjectL_UI_CommonUITask.<>f__mg$cache3C;
		if (Lua_BlackJack_ProjectL_UI_CommonUITask.<>f__mg$cache3D == null)
		{
			Lua_BlackJack_ProjectL_UI_CommonUITask.<>f__mg$cache3D = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_CommonUITask.set_s_instance);
		}
		LuaObject.addMember(l, name2, get2, Lua_BlackJack_ProjectL_UI_CommonUITask.<>f__mg$cache3D, false);
		string name3 = "m_layerDescArray";
		if (Lua_BlackJack_ProjectL_UI_CommonUITask.<>f__mg$cache3E == null)
		{
			Lua_BlackJack_ProjectL_UI_CommonUITask.<>f__mg$cache3E = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_CommonUITask.get_m_layerDescArray);
		}
		LuaCSFunction get3 = Lua_BlackJack_ProjectL_UI_CommonUITask.<>f__mg$cache3E;
		if (Lua_BlackJack_ProjectL_UI_CommonUITask.<>f__mg$cache3F == null)
		{
			Lua_BlackJack_ProjectL_UI_CommonUITask.<>f__mg$cache3F = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_CommonUITask.set_m_layerDescArray);
		}
		LuaObject.addMember(l, name3, get3, Lua_BlackJack_ProjectL_UI_CommonUITask.<>f__mg$cache3F, true);
		string name4 = "m_uiCtrlDescArray";
		if (Lua_BlackJack_ProjectL_UI_CommonUITask.<>f__mg$cache40 == null)
		{
			Lua_BlackJack_ProjectL_UI_CommonUITask.<>f__mg$cache40 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_CommonUITask.get_m_uiCtrlDescArray);
		}
		LuaCSFunction get4 = Lua_BlackJack_ProjectL_UI_CommonUITask.<>f__mg$cache40;
		if (Lua_BlackJack_ProjectL_UI_CommonUITask.<>f__mg$cache41 == null)
		{
			Lua_BlackJack_ProjectL_UI_CommonUITask.<>f__mg$cache41 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_CommonUITask.set_m_uiCtrlDescArray);
		}
		LuaObject.addMember(l, name4, get4, Lua_BlackJack_ProjectL_UI_CommonUITask.<>f__mg$cache41, true);
		string name5 = "m_commonUIController";
		if (Lua_BlackJack_ProjectL_UI_CommonUITask.<>f__mg$cache42 == null)
		{
			Lua_BlackJack_ProjectL_UI_CommonUITask.<>f__mg$cache42 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_CommonUITask.get_m_commonUIController);
		}
		LuaCSFunction get5 = Lua_BlackJack_ProjectL_UI_CommonUITask.<>f__mg$cache42;
		if (Lua_BlackJack_ProjectL_UI_CommonUITask.<>f__mg$cache43 == null)
		{
			Lua_BlackJack_ProjectL_UI_CommonUITask.<>f__mg$cache43 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_CommonUITask.set_m_commonUIController);
		}
		LuaObject.addMember(l, name5, get5, Lua_BlackJack_ProjectL_UI_CommonUITask.<>f__mg$cache43, true);
		string name6 = "m_sendHeartBeatTime";
		if (Lua_BlackJack_ProjectL_UI_CommonUITask.<>f__mg$cache44 == null)
		{
			Lua_BlackJack_ProjectL_UI_CommonUITask.<>f__mg$cache44 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_CommonUITask.get_m_sendHeartBeatTime);
		}
		LuaCSFunction get6 = Lua_BlackJack_ProjectL_UI_CommonUITask.<>f__mg$cache44;
		if (Lua_BlackJack_ProjectL_UI_CommonUITask.<>f__mg$cache45 == null)
		{
			Lua_BlackJack_ProjectL_UI_CommonUITask.<>f__mg$cache45 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_CommonUITask.set_m_sendHeartBeatTime);
		}
		LuaObject.addMember(l, name6, get6, Lua_BlackJack_ProjectL_UI_CommonUITask.<>f__mg$cache45, true);
		string name7 = "m_nextCheckOnlineTime";
		if (Lua_BlackJack_ProjectL_UI_CommonUITask.<>f__mg$cache46 == null)
		{
			Lua_BlackJack_ProjectL_UI_CommonUITask.<>f__mg$cache46 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_CommonUITask.get_m_nextCheckOnlineTime);
		}
		LuaCSFunction get7 = Lua_BlackJack_ProjectL_UI_CommonUITask.<>f__mg$cache46;
		if (Lua_BlackJack_ProjectL_UI_CommonUITask.<>f__mg$cache47 == null)
		{
			Lua_BlackJack_ProjectL_UI_CommonUITask.<>f__mg$cache47 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_CommonUITask.set_m_nextCheckOnlineTime);
		}
		LuaObject.addMember(l, name7, get7, Lua_BlackJack_ProjectL_UI_CommonUITask.<>f__mg$cache47, true);
		string name8 = "m_disconnectedByServerMessageId";
		if (Lua_BlackJack_ProjectL_UI_CommonUITask.<>f__mg$cache48 == null)
		{
			Lua_BlackJack_ProjectL_UI_CommonUITask.<>f__mg$cache48 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_CommonUITask.get_m_disconnectedByServerMessageId);
		}
		LuaCSFunction get8 = Lua_BlackJack_ProjectL_UI_CommonUITask.<>f__mg$cache48;
		if (Lua_BlackJack_ProjectL_UI_CommonUITask.<>f__mg$cache49 == null)
		{
			Lua_BlackJack_ProjectL_UI_CommonUITask.<>f__mg$cache49 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_CommonUITask.set_m_disconnectedByServerMessageId);
		}
		LuaObject.addMember(l, name8, get8, Lua_BlackJack_ProjectL_UI_CommonUITask.<>f__mg$cache49, true);
		string name9 = "m_lastCheckClientVersionTime";
		if (Lua_BlackJack_ProjectL_UI_CommonUITask.<>f__mg$cache4A == null)
		{
			Lua_BlackJack_ProjectL_UI_CommonUITask.<>f__mg$cache4A = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_CommonUITask.get_m_lastCheckClientVersionTime);
		}
		LuaCSFunction get9 = Lua_BlackJack_ProjectL_UI_CommonUITask.<>f__mg$cache4A;
		if (Lua_BlackJack_ProjectL_UI_CommonUITask.<>f__mg$cache4B == null)
		{
			Lua_BlackJack_ProjectL_UI_CommonUITask.<>f__mg$cache4B = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_CommonUITask.set_m_lastCheckClientVersionTime);
		}
		LuaObject.addMember(l, name9, get9, Lua_BlackJack_ProjectL_UI_CommonUITask.<>f__mg$cache4B, true);
		string name10 = "LayerDescArray";
		if (Lua_BlackJack_ProjectL_UI_CommonUITask.<>f__mg$cache4C == null)
		{
			Lua_BlackJack_ProjectL_UI_CommonUITask.<>f__mg$cache4C = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_CommonUITask.get_LayerDescArray);
		}
		LuaObject.addMember(l, name10, Lua_BlackJack_ProjectL_UI_CommonUITask.<>f__mg$cache4C, null, true);
		string name11 = "UICtrlDescArray";
		if (Lua_BlackJack_ProjectL_UI_CommonUITask.<>f__mg$cache4D == null)
		{
			Lua_BlackJack_ProjectL_UI_CommonUITask.<>f__mg$cache4D = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_CommonUITask.get_UICtrlDescArray);
		}
		LuaObject.addMember(l, name11, Lua_BlackJack_ProjectL_UI_CommonUITask.<>f__mg$cache4D, null, true);
		if (Lua_BlackJack_ProjectL_UI_CommonUITask.<>f__mg$cache4E == null)
		{
			Lua_BlackJack_ProjectL_UI_CommonUITask.<>f__mg$cache4E = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_CommonUITask.constructor);
		}
		LuaObject.createTypeMetatable(l, Lua_BlackJack_ProjectL_UI_CommonUITask.<>f__mg$cache4E, typeof(CommonUITask), typeof(UITask));
	}

	// Token: 0x04013064 RID: 77924
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache0;

	// Token: 0x04013065 RID: 77925
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1;

	// Token: 0x04013066 RID: 77926
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2;

	// Token: 0x04013067 RID: 77927
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3;

	// Token: 0x04013068 RID: 77928
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache4;

	// Token: 0x04013069 RID: 77929
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache5;

	// Token: 0x0401306A RID: 77930
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache6;

	// Token: 0x0401306B RID: 77931
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache7;

	// Token: 0x0401306C RID: 77932
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache8;

	// Token: 0x0401306D RID: 77933
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache9;

	// Token: 0x0401306E RID: 77934
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheA;

	// Token: 0x0401306F RID: 77935
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheB;

	// Token: 0x04013070 RID: 77936
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheC;

	// Token: 0x04013071 RID: 77937
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheD;

	// Token: 0x04013072 RID: 77938
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheE;

	// Token: 0x04013073 RID: 77939
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheF;

	// Token: 0x04013074 RID: 77940
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache10;

	// Token: 0x04013075 RID: 77941
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache11;

	// Token: 0x04013076 RID: 77942
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache12;

	// Token: 0x04013077 RID: 77943
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache13;

	// Token: 0x04013078 RID: 77944
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache14;

	// Token: 0x04013079 RID: 77945
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache15;

	// Token: 0x0401307A RID: 77946
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache16;

	// Token: 0x0401307B RID: 77947
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache17;

	// Token: 0x0401307C RID: 77948
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache18;

	// Token: 0x0401307D RID: 77949
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache19;

	// Token: 0x0401307E RID: 77950
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1A;

	// Token: 0x0401307F RID: 77951
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1B;

	// Token: 0x04013080 RID: 77952
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1C;

	// Token: 0x04013081 RID: 77953
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1D;

	// Token: 0x04013082 RID: 77954
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1E;

	// Token: 0x04013083 RID: 77955
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1F;

	// Token: 0x04013084 RID: 77956
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache20;

	// Token: 0x04013085 RID: 77957
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache21;

	// Token: 0x04013086 RID: 77958
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache22;

	// Token: 0x04013087 RID: 77959
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache23;

	// Token: 0x04013088 RID: 77960
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache24;

	// Token: 0x04013089 RID: 77961
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache25;

	// Token: 0x0401308A RID: 77962
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache26;

	// Token: 0x0401308B RID: 77963
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache27;

	// Token: 0x0401308C RID: 77964
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache28;

	// Token: 0x0401308D RID: 77965
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache29;

	// Token: 0x0401308E RID: 77966
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2A;

	// Token: 0x0401308F RID: 77967
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2B;

	// Token: 0x04013090 RID: 77968
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2C;

	// Token: 0x04013091 RID: 77969
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2D;

	// Token: 0x04013092 RID: 77970
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2E;

	// Token: 0x04013093 RID: 77971
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2F;

	// Token: 0x04013094 RID: 77972
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache30;

	// Token: 0x04013095 RID: 77973
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache31;

	// Token: 0x04013096 RID: 77974
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache32;

	// Token: 0x04013097 RID: 77975
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache33;

	// Token: 0x04013098 RID: 77976
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache34;

	// Token: 0x04013099 RID: 77977
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache35;

	// Token: 0x0401309A RID: 77978
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache36;

	// Token: 0x0401309B RID: 77979
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache37;

	// Token: 0x0401309C RID: 77980
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache38;

	// Token: 0x0401309D RID: 77981
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache39;

	// Token: 0x0401309E RID: 77982
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3A;

	// Token: 0x0401309F RID: 77983
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3B;

	// Token: 0x040130A0 RID: 77984
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3C;

	// Token: 0x040130A1 RID: 77985
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3D;

	// Token: 0x040130A2 RID: 77986
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3E;

	// Token: 0x040130A3 RID: 77987
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3F;

	// Token: 0x040130A4 RID: 77988
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache40;

	// Token: 0x040130A5 RID: 77989
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache41;

	// Token: 0x040130A6 RID: 77990
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache42;

	// Token: 0x040130A7 RID: 77991
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache43;

	// Token: 0x040130A8 RID: 77992
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache44;

	// Token: 0x040130A9 RID: 77993
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache45;

	// Token: 0x040130AA RID: 77994
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache46;

	// Token: 0x040130AB RID: 77995
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache47;

	// Token: 0x040130AC RID: 77996
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache48;

	// Token: 0x040130AD RID: 77997
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache49;

	// Token: 0x040130AE RID: 77998
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache4A;

	// Token: 0x040130AF RID: 77999
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache4B;

	// Token: 0x040130B0 RID: 78000
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache4C;

	// Token: 0x040130B1 RID: 78001
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache4D;

	// Token: 0x040130B2 RID: 78002
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache4E;
}
