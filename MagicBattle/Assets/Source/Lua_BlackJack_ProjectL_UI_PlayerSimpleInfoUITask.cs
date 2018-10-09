using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using BlackJack.BJFramework.Runtime.UI;
using BlackJack.ConfigData;
using BlackJack.ProjectL.Common;
using BlackJack.ProjectL.PlayerContext;
using BlackJack.ProjectL.UI;
using BlackJack.ProjectLBasic;
using SLua;
using UnityEngine;
using UnityEngine.Scripting;

// Token: 0x02001533 RID: 5427
[Preserve]
public class Lua_BlackJack_ProjectL_UI_PlayerSimpleInfoUITask : LuaObject
{
	// Token: 0x06020582 RID: 132482 RVA: 0x00AC2C58 File Offset: 0x00AC0E58
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int constructor(IntPtr l)
	{
		int result;
		try
		{
			string name;
			LuaObject.checkType(l, 2, out name);
			PlayerSimpleInfoUITask o = new PlayerSimpleInfoUITask(name);
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

	// Token: 0x06020583 RID: 132483 RVA: 0x00AC2CAC File Offset: 0x00AC0EAC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int InitlizeBeforeManagerStartIt(IntPtr l)
	{
		int result;
		try
		{
			PlayerSimpleInfoUITask playerSimpleInfoUITask = (PlayerSimpleInfoUITask)LuaObject.checkSelf(l);
			playerSimpleInfoUITask.InitlizeBeforeManagerStartIt();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06020584 RID: 132484 RVA: 0x00AC2CF8 File Offset: 0x00AC0EF8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int ShowPlayerSimpleInfoPanel_s(IntPtr l)
	{
		int result;
		try
		{
			Vector3 pos;
			LuaObject.checkType(l, 1, out pos);
			PlayerSimpleInfoUITask.PostionType postionType;
			LuaObject.checkEnum<PlayerSimpleInfoUITask.PostionType>(l, 2, out postionType);
			UIIntent returnIntent;
			LuaObject.checkType<UIIntent>(l, 3, out returnIntent);
			bool isFromGuild;
			LuaObject.checkType(l, 4, out isFromGuild);
			PlayerSimpleInfoUITask o = PlayerSimpleInfoUITask.ShowPlayerSimpleInfoPanel(pos, postionType, returnIntent, isFromGuild);
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

	// Token: 0x06020585 RID: 132485 RVA: 0x00AC2D74 File Offset: 0x00AC0F74
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int OnStart(IntPtr l)
	{
		int result;
		try
		{
			PlayerSimpleInfoUITask playerSimpleInfoUITask = (PlayerSimpleInfoUITask)LuaObject.checkSelf(l);
			UIIntent intent;
			LuaObject.checkType<UIIntent>(l, 2, out intent);
			bool b = playerSimpleInfoUITask.m_luaExportHelper.OnStart(intent);
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

	// Token: 0x06020586 RID: 132486 RVA: 0x00AC2DDC File Offset: 0x00AC0FDC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int OnStop(IntPtr l)
	{
		int result;
		try
		{
			PlayerSimpleInfoUITask playerSimpleInfoUITask = (PlayerSimpleInfoUITask)LuaObject.checkSelf(l);
			playerSimpleInfoUITask.m_luaExportHelper.OnStop();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06020587 RID: 132487 RVA: 0x00AC2E30 File Offset: 0x00AC1030
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int OnResume(IntPtr l)
	{
		int result;
		try
		{
			PlayerSimpleInfoUITask playerSimpleInfoUITask = (PlayerSimpleInfoUITask)LuaObject.checkSelf(l);
			UIIntent intent;
			LuaObject.checkType<UIIntent>(l, 2, out intent);
			bool b = playerSimpleInfoUITask.m_luaExportHelper.OnResume(intent);
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

	// Token: 0x06020588 RID: 132488 RVA: 0x00AC2E98 File Offset: 0x00AC1098
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int InitAllUIControllers(IntPtr l)
	{
		int result;
		try
		{
			PlayerSimpleInfoUITask playerSimpleInfoUITask = (PlayerSimpleInfoUITask)LuaObject.checkSelf(l);
			playerSimpleInfoUITask.m_luaExportHelper.InitAllUIControllers();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06020589 RID: 132489 RVA: 0x00AC2EEC File Offset: 0x00AC10EC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int IsNeedUpdateDataCache(IntPtr l)
	{
		int result;
		try
		{
			PlayerSimpleInfoUITask playerSimpleInfoUITask = (PlayerSimpleInfoUITask)LuaObject.checkSelf(l);
			bool b = playerSimpleInfoUITask.m_luaExportHelper.IsNeedUpdateDataCache();
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

	// Token: 0x0602058A RID: 132490 RVA: 0x00AC2F48 File Offset: 0x00AC1148
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int UpdateDataCache(IntPtr l)
	{
		int result;
		try
		{
			PlayerSimpleInfoUITask playerSimpleInfoUITask = (PlayerSimpleInfoUITask)LuaObject.checkSelf(l);
			playerSimpleInfoUITask.m_luaExportHelper.UpdateDataCache();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0602058B RID: 132491 RVA: 0x00AC2F9C File Offset: 0x00AC119C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int UpdateView(IntPtr l)
	{
		int result;
		try
		{
			PlayerSimpleInfoUITask playerSimpleInfoUITask = (PlayerSimpleInfoUITask)LuaObject.checkSelf(l);
			playerSimpleInfoUITask.m_luaExportHelper.UpdateView();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0602058C RID: 132492 RVA: 0x00AC2FF0 File Offset: 0x00AC11F0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int IsInBattle(IntPtr l)
	{
		int result;
		try
		{
			PlayerSimpleInfoUITask playerSimpleInfoUITask = (PlayerSimpleInfoUITask)LuaObject.checkSelf(l);
			bool b = playerSimpleInfoUITask.m_luaExportHelper.IsInBattle();
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

	// Token: 0x0602058D RID: 132493 RVA: 0x00AC304C File Offset: 0x00AC124C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int PlayerSimpleInfoUIController_OnWatchCard(IntPtr l)
	{
		int result;
		try
		{
			PlayerSimpleInfoUITask playerSimpleInfoUITask = (PlayerSimpleInfoUITask)LuaObject.checkSelf(l);
			string userID;
			LuaObject.checkType(l, 2, out userID);
			playerSimpleInfoUITask.m_luaExportHelper.PlayerSimpleInfoUIController_OnWatchCard(userID);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0602058E RID: 132494 RVA: 0x00AC30A8 File Offset: 0x00AC12A8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int PlayerSimpleInfoUIController_OnPrivateChat(IntPtr l)
	{
		int result;
		try
		{
			PlayerSimpleInfoUITask playerSimpleInfoUITask = (PlayerSimpleInfoUITask)LuaObject.checkSelf(l);
			playerSimpleInfoUITask.m_luaExportHelper.PlayerSimpleInfoUIController_OnPrivateChat();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0602058F RID: 132495 RVA: 0x00AC30FC File Offset: 0x00AC12FC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int PlayerSimpleInfoUIController_OnPK(IntPtr l)
	{
		int result;
		try
		{
			PlayerSimpleInfoUITask playerSimpleInfoUITask = (PlayerSimpleInfoUITask)LuaObject.checkSelf(l);
			string userID;
			LuaObject.checkType(l, 2, out userID);
			playerSimpleInfoUITask.m_luaExportHelper.PlayerSimpleInfoUIController_OnPK(userID);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06020590 RID: 132496 RVA: 0x00AC3158 File Offset: 0x00AC1358
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int PlayerSimpleInfoUIController_OnDeleteFriend(IntPtr l)
	{
		int result;
		try
		{
			PlayerSimpleInfoUITask playerSimpleInfoUITask = (PlayerSimpleInfoUITask)LuaObject.checkSelf(l);
			BusinessCard userInfo;
			LuaObject.checkType<BusinessCard>(l, 2, out userInfo);
			playerSimpleInfoUITask.m_luaExportHelper.PlayerSimpleInfoUIController_OnDeleteFriend(userInfo);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06020591 RID: 132497 RVA: 0x00AC31B4 File Offset: 0x00AC13B4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int OnDeleteFreindDialogBoxCallback(IntPtr l)
	{
		int result;
		try
		{
			PlayerSimpleInfoUITask playerSimpleInfoUITask = (PlayerSimpleInfoUITask)LuaObject.checkSelf(l);
			DialogBoxResult r;
			LuaObject.checkEnum<DialogBoxResult>(l, 2, out r);
			playerSimpleInfoUITask.m_luaExportHelper.OnDeleteFreindDialogBoxCallback(r);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06020592 RID: 132498 RVA: 0x00AC3210 File Offset: 0x00AC1410
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int PlayerSimpleInfoUIController_OnAddFriend(IntPtr l)
	{
		int result;
		try
		{
			PlayerSimpleInfoUITask playerSimpleInfoUITask = (PlayerSimpleInfoUITask)LuaObject.checkSelf(l);
			string userID;
			LuaObject.checkType(l, 2, out userID);
			playerSimpleInfoUITask.m_luaExportHelper.PlayerSimpleInfoUIController_OnAddFriend(userID);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06020593 RID: 132499 RVA: 0x00AC326C File Offset: 0x00AC146C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int PlayerSimpleInfoUIController_OnBlock(IntPtr l)
	{
		int result;
		try
		{
			PlayerSimpleInfoUITask playerSimpleInfoUITask = (PlayerSimpleInfoUITask)LuaObject.checkSelf(l);
			string userID;
			LuaObject.checkType(l, 2, out userID);
			playerSimpleInfoUITask.m_luaExportHelper.PlayerSimpleInfoUIController_OnBlock(userID);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06020594 RID: 132500 RVA: 0x00AC32C8 File Offset: 0x00AC14C8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int PlayerSimpleInfoUIController_OnLike(IntPtr l)
	{
		int result;
		try
		{
			PlayerSimpleInfoUITask playerSimpleInfoUITask = (PlayerSimpleInfoUITask)LuaObject.checkSelf(l);
			string userID;
			LuaObject.checkType(l, 2, out userID);
			playerSimpleInfoUITask.m_luaExportHelper.PlayerSimpleInfoUIController_OnLike(userID);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06020595 RID: 132501 RVA: 0x00AC3324 File Offset: 0x00AC1524
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int PlayerSimpleInfoUIController_OnReturn(IntPtr l)
	{
		int result;
		try
		{
			PlayerSimpleInfoUITask playerSimpleInfoUITask = (PlayerSimpleInfoUITask)LuaObject.checkSelf(l);
			playerSimpleInfoUITask.m_luaExportHelper.PlayerSimpleInfoUIController_OnReturn();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06020596 RID: 132502 RVA: 0x00AC3378 File Offset: 0x00AC1578
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int PlayerSimpleInfoUIController_OnExpel(IntPtr l)
	{
		int result;
		try
		{
			PlayerSimpleInfoUITask playerSimpleInfoUITask = (PlayerSimpleInfoUITask)LuaObject.checkSelf(l);
			string userId;
			LuaObject.checkType(l, 2, out userId);
			playerSimpleInfoUITask.m_luaExportHelper.PlayerSimpleInfoUIController_OnExpel(userId);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06020597 RID: 132503 RVA: 0x00AC33D4 File Offset: 0x00AC15D4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int PlayerSimpleInfoUIController_OnVChairmanChange(IntPtr l)
	{
		int result;
		try
		{
			PlayerSimpleInfoUITask playerSimpleInfoUITask = (PlayerSimpleInfoUITask)LuaObject.checkSelf(l);
			string userId;
			LuaObject.checkType(l, 2, out userId);
			bool isAppiont;
			LuaObject.checkType(l, 3, out isAppiont);
			playerSimpleInfoUITask.m_luaExportHelper.PlayerSimpleInfoUIController_OnVChairmanChange(userId, isAppiont);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06020598 RID: 132504 RVA: 0x00AC3440 File Offset: 0x00AC1640
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int PlayerSimpleInfoUIController_ChairmanMove(IntPtr l)
	{
		int result;
		try
		{
			PlayerSimpleInfoUITask playerSimpleInfoUITask = (PlayerSimpleInfoUITask)LuaObject.checkSelf(l);
			string userId;
			LuaObject.checkType(l, 2, out userId);
			playerSimpleInfoUITask.m_luaExportHelper.PlayerSimpleInfoUIController_ChairmanMove(userId);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06020599 RID: 132505 RVA: 0x00AC349C File Offset: 0x00AC169C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int PlayerSimpleInfoUIController_OnChairmanRelieve(IntPtr l)
	{
		int result;
		try
		{
			PlayerSimpleInfoUITask playerSimpleInfoUITask = (PlayerSimpleInfoUITask)LuaObject.checkSelf(l);
			string userId;
			LuaObject.checkType(l, 2, out userId);
			playerSimpleInfoUITask.m_luaExportHelper.PlayerSimpleInfoUIController_OnChairmanRelieve(userId);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0602059A RID: 132506 RVA: 0x00AC34F8 File Offset: 0x00AC16F8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int ClosePanel(IntPtr l)
	{
		int result;
		try
		{
			PlayerSimpleInfoUITask playerSimpleInfoUITask = (PlayerSimpleInfoUITask)LuaObject.checkSelf(l);
			playerSimpleInfoUITask.m_luaExportHelper.ClosePanel();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0602059B RID: 132507 RVA: 0x00AC354C File Offset: 0x00AC174C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int RegisterUIEvent(IntPtr l)
	{
		int result;
		try
		{
			PlayerSimpleInfoUITask playerSimpleInfoUITask = (PlayerSimpleInfoUITask)LuaObject.checkSelf(l);
			playerSimpleInfoUITask.m_luaExportHelper.RegisterUIEvent();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0602059C RID: 132508 RVA: 0x00AC35A0 File Offset: 0x00AC17A0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int UnRegiterUIEvent(IntPtr l)
	{
		int result;
		try
		{
			PlayerSimpleInfoUITask playerSimpleInfoUITask = (PlayerSimpleInfoUITask)LuaObject.checkSelf(l);
			playerSimpleInfoUITask.m_luaExportHelper.UnRegiterUIEvent();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0602059D RID: 132509 RVA: 0x00AC35F4 File Offset: 0x00AC17F4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int SetPanelPostion(IntPtr l)
	{
		int result;
		try
		{
			PlayerSimpleInfoUITask playerSimpleInfoUITask = (PlayerSimpleInfoUITask)LuaObject.checkSelf(l);
			playerSimpleInfoUITask.m_luaExportHelper.SetPanelPostion();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0602059E RID: 132510 RVA: 0x00AC3648 File Offset: 0x00AC1848
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_OnStart(IntPtr l)
	{
		int result;
		try
		{
			PlayerSimpleInfoUITask playerSimpleInfoUITask = (PlayerSimpleInfoUITask)LuaObject.checkSelf(l);
			UIIntent intent;
			LuaObject.checkType<UIIntent>(l, 2, out intent);
			bool b = playerSimpleInfoUITask.m_luaExportHelper.__callBase_OnStart(intent);
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

	// Token: 0x0602059F RID: 132511 RVA: 0x00AC36B0 File Offset: 0x00AC18B0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_OnStop(IntPtr l)
	{
		int result;
		try
		{
			PlayerSimpleInfoUITask playerSimpleInfoUITask = (PlayerSimpleInfoUITask)LuaObject.checkSelf(l);
			playerSimpleInfoUITask.m_luaExportHelper.__callBase_OnStop();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060205A0 RID: 132512 RVA: 0x00AC3704 File Offset: 0x00AC1904
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_OnPause(IntPtr l)
	{
		int result;
		try
		{
			PlayerSimpleInfoUITask playerSimpleInfoUITask = (PlayerSimpleInfoUITask)LuaObject.checkSelf(l);
			playerSimpleInfoUITask.m_luaExportHelper.__callBase_OnPause();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060205A1 RID: 132513 RVA: 0x00AC3758 File Offset: 0x00AC1958
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_OnResume(IntPtr l)
	{
		int result;
		try
		{
			PlayerSimpleInfoUITask playerSimpleInfoUITask = (PlayerSimpleInfoUITask)LuaObject.checkSelf(l);
			UIIntent intent;
			LuaObject.checkType<UIIntent>(l, 2, out intent);
			bool b = playerSimpleInfoUITask.m_luaExportHelper.__callBase_OnResume(intent);
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

	// Token: 0x060205A2 RID: 132514 RVA: 0x00AC37C0 File Offset: 0x00AC19C0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_OnNewIntent(IntPtr l)
	{
		int result;
		try
		{
			PlayerSimpleInfoUITask playerSimpleInfoUITask = (PlayerSimpleInfoUITask)LuaObject.checkSelf(l);
			UIIntent intent;
			LuaObject.checkType<UIIntent>(l, 2, out intent);
			bool b = playerSimpleInfoUITask.m_luaExportHelper.__callBase_OnNewIntent(intent);
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

	// Token: 0x060205A3 RID: 132515 RVA: 0x00AC3828 File Offset: 0x00AC1A28
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_EnableUIInput(IntPtr l)
	{
		int result;
		try
		{
			PlayerSimpleInfoUITask playerSimpleInfoUITask = (PlayerSimpleInfoUITask)LuaObject.checkSelf(l);
			bool isEnable;
			LuaObject.checkType(l, 2, out isEnable);
			bool? isGlobalEnable;
			LuaObject.checkNullable<bool>(l, 3, out isGlobalEnable);
			playerSimpleInfoUITask.m_luaExportHelper.__callBase_EnableUIInput(isEnable, isGlobalEnable);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060205A4 RID: 132516 RVA: 0x00AC3894 File Offset: 0x00AC1A94
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_IsNeedLoadDynamicRes(IntPtr l)
	{
		int result;
		try
		{
			PlayerSimpleInfoUITask playerSimpleInfoUITask = (PlayerSimpleInfoUITask)LuaObject.checkSelf(l);
			bool b = playerSimpleInfoUITask.m_luaExportHelper.__callBase_IsNeedLoadDynamicRes();
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

	// Token: 0x060205A5 RID: 132517 RVA: 0x00AC38F0 File Offset: 0x00AC1AF0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_CollectAllDynamicResForLoad(IntPtr l)
	{
		int result;
		try
		{
			PlayerSimpleInfoUITask playerSimpleInfoUITask = (PlayerSimpleInfoUITask)LuaObject.checkSelf(l);
			List<string> o = playerSimpleInfoUITask.m_luaExportHelper.__callBase_CollectAllDynamicResForLoad();
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

	// Token: 0x060205A6 RID: 132518 RVA: 0x00AC394C File Offset: 0x00AC1B4C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_RegisterPlayerContextEvents(IntPtr l)
	{
		int result;
		try
		{
			PlayerSimpleInfoUITask playerSimpleInfoUITask = (PlayerSimpleInfoUITask)LuaObject.checkSelf(l);
			playerSimpleInfoUITask.m_luaExportHelper.__callBase_RegisterPlayerContextEvents();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060205A7 RID: 132519 RVA: 0x00AC39A0 File Offset: 0x00AC1BA0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_UnregisterPlayerContextEvents(IntPtr l)
	{
		int result;
		try
		{
			PlayerSimpleInfoUITask playerSimpleInfoUITask = (PlayerSimpleInfoUITask)LuaObject.checkSelf(l);
			playerSimpleInfoUITask.m_luaExportHelper.__callBase_UnregisterPlayerContextEvents();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060205A8 RID: 132520 RVA: 0x00AC39F4 File Offset: 0x00AC1BF4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_PostUpdateView(IntPtr l)
	{
		int result;
		try
		{
			PlayerSimpleInfoUITask playerSimpleInfoUITask = (PlayerSimpleInfoUITask)LuaObject.checkSelf(l);
			playerSimpleInfoUITask.m_luaExportHelper.__callBase_PostUpdateView();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060205A9 RID: 132521 RVA: 0x00AC3A48 File Offset: 0x00AC1C48
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_CollectPreloadResourceList(IntPtr l)
	{
		int result;
		try
		{
			PlayerSimpleInfoUITask playerSimpleInfoUITask = (PlayerSimpleInfoUITask)LuaObject.checkSelf(l);
			playerSimpleInfoUITask.m_luaExportHelper.__callBase_CollectPreloadResourceList();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060205AA RID: 132522 RVA: 0x00AC3A9C File Offset: 0x00AC1C9C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_ClearAssetList(IntPtr l)
	{
		int result;
		try
		{
			PlayerSimpleInfoUITask playerSimpleInfoUITask = (PlayerSimpleInfoUITask)LuaObject.checkSelf(l);
			playerSimpleInfoUITask.m_luaExportHelper.__callBase_ClearAssetList();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060205AB RID: 132523 RVA: 0x00AC3AF0 File Offset: 0x00AC1CF0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_CollectAsset(IntPtr l)
	{
		int result;
		try
		{
			PlayerSimpleInfoUITask playerSimpleInfoUITask = (PlayerSimpleInfoUITask)LuaObject.checkSelf(l);
			string assetName;
			LuaObject.checkType(l, 2, out assetName);
			playerSimpleInfoUITask.m_luaExportHelper.__callBase_CollectAsset(assetName);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060205AC RID: 132524 RVA: 0x00AC3B4C File Offset: 0x00AC1D4C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_CollectSpriteAsset(IntPtr l)
	{
		int result;
		try
		{
			PlayerSimpleInfoUITask playerSimpleInfoUITask = (PlayerSimpleInfoUITask)LuaObject.checkSelf(l);
			string assetName;
			LuaObject.checkType(l, 2, out assetName);
			playerSimpleInfoUITask.m_luaExportHelper.__callBase_CollectSpriteAsset(assetName);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060205AD RID: 132525 RVA: 0x00AC3BA8 File Offset: 0x00AC1DA8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_CollectFxAsset(IntPtr l)
	{
		int result;
		try
		{
			PlayerSimpleInfoUITask playerSimpleInfoUITask = (PlayerSimpleInfoUITask)LuaObject.checkSelf(l);
			string assetName;
			LuaObject.checkType(l, 2, out assetName);
			playerSimpleInfoUITask.m_luaExportHelper.__callBase_CollectFxAsset(assetName);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060205AE RID: 132526 RVA: 0x00AC3C04 File Offset: 0x00AC1E04
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_StartLoadCustomAssets(IntPtr l)
	{
		int result;
		try
		{
			PlayerSimpleInfoUITask playerSimpleInfoUITask = (PlayerSimpleInfoUITask)LuaObject.checkSelf(l);
			Action onLoadCompleted;
			LuaObject.checkDelegate<Action>(l, 2, out onLoadCompleted);
			playerSimpleInfoUITask.m_luaExportHelper.__callBase_StartLoadCustomAssets(onLoadCompleted);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060205AF RID: 132527 RVA: 0x00AC3C60 File Offset: 0x00AC1E60
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_IsLoadingCustomAssets(IntPtr l)
	{
		int result;
		try
		{
			PlayerSimpleInfoUITask playerSimpleInfoUITask = (PlayerSimpleInfoUITask)LuaObject.checkSelf(l);
			bool b = playerSimpleInfoUITask.m_luaExportHelper.__callBase_IsLoadingCustomAssets();
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

	// Token: 0x060205B0 RID: 132528 RVA: 0x00AC3CBC File Offset: 0x00AC1EBC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_IsPipeLineRunning(IntPtr l)
	{
		int result;
		try
		{
			PlayerSimpleInfoUITask playerSimpleInfoUITask = (PlayerSimpleInfoUITask)LuaObject.checkSelf(l);
			bool b = playerSimpleInfoUITask.m_luaExportHelper.__callBase_IsPipeLineRunning();
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

	// Token: 0x060205B1 RID: 132529 RVA: 0x00AC3D18 File Offset: 0x00AC1F18
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_IsOpeningUI(IntPtr l)
	{
		int result;
		try
		{
			PlayerSimpleInfoUITask playerSimpleInfoUITask = (PlayerSimpleInfoUITask)LuaObject.checkSelf(l);
			bool b = playerSimpleInfoUITask.m_luaExportHelper.__callBase_IsOpeningUI();
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

	// Token: 0x060205B2 RID: 132530 RVA: 0x00AC3D74 File Offset: 0x00AC1F74
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_ReturnPrevUITask(IntPtr l)
	{
		int result;
		try
		{
			PlayerSimpleInfoUITask playerSimpleInfoUITask = (PlayerSimpleInfoUITask)LuaObject.checkSelf(l);
			UITaskBase o = playerSimpleInfoUITask.m_luaExportHelper.__callBase_ReturnPrevUITask();
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

	// Token: 0x060205B3 RID: 132531 RVA: 0x00AC3DD0 File Offset: 0x00AC1FD0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_ClearUnusedDynamicResourceCache(IntPtr l)
	{
		int result;
		try
		{
			PlayerSimpleInfoUITask playerSimpleInfoUITask = (PlayerSimpleInfoUITask)LuaObject.checkSelf(l);
			playerSimpleInfoUITask.m_luaExportHelper.__callBase_ClearUnusedDynamicResourceCache();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060205B4 RID: 132532 RVA: 0x00AC3E24 File Offset: 0x00AC2024
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_OnMemoryWarning(IntPtr l)
	{
		int result;
		try
		{
			PlayerSimpleInfoUITask playerSimpleInfoUITask = (PlayerSimpleInfoUITask)LuaObject.checkSelf(l);
			playerSimpleInfoUITask.m_luaExportHelper.__callBase_OnMemoryWarning();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060205B5 RID: 132533 RVA: 0x00AC3E78 File Offset: 0x00AC2078
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callDele_EventOnClose(IntPtr l)
	{
		int result;
		try
		{
			PlayerSimpleInfoUITask playerSimpleInfoUITask = (PlayerSimpleInfoUITask)LuaObject.checkSelf(l);
			playerSimpleInfoUITask.m_luaExportHelper.__callDele_EventOnClose();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060205B6 RID: 132534 RVA: 0x00AC3ECC File Offset: 0x00AC20CC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __clearDele_EventOnClose(IntPtr l)
	{
		int result;
		try
		{
			PlayerSimpleInfoUITask playerSimpleInfoUITask = (PlayerSimpleInfoUITask)LuaObject.checkSelf(l);
			playerSimpleInfoUITask.m_luaExportHelper.__clearDele_EventOnClose();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060205B7 RID: 132535 RVA: 0x00AC3F20 File Offset: 0x00AC2120
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callDele_EventOnGetSocialRelation(IntPtr l)
	{
		int result;
		try
		{
			PlayerSimpleInfoUITask playerSimpleInfoUITask = (PlayerSimpleInfoUITask)LuaObject.checkSelf(l);
			playerSimpleInfoUITask.m_luaExportHelper.__callDele_EventOnGetSocialRelation();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060205B8 RID: 132536 RVA: 0x00AC3F74 File Offset: 0x00AC2174
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __clearDele_EventOnGetSocialRelation(IntPtr l)
	{
		int result;
		try
		{
			PlayerSimpleInfoUITask playerSimpleInfoUITask = (PlayerSimpleInfoUITask)LuaObject.checkSelf(l);
			playerSimpleInfoUITask.m_luaExportHelper.__clearDele_EventOnGetSocialRelation();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060205B9 RID: 132537 RVA: 0x00AC3FC8 File Offset: 0x00AC21C8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callDele_EventOnPrivateChatButtonClick(IntPtr l)
	{
		int result;
		try
		{
			PlayerSimpleInfoUITask playerSimpleInfoUITask = (PlayerSimpleInfoUITask)LuaObject.checkSelf(l);
			BusinessCard obj;
			LuaObject.checkType<BusinessCard>(l, 2, out obj);
			playerSimpleInfoUITask.m_luaExportHelper.__callDele_EventOnPrivateChatButtonClick(obj);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060205BA RID: 132538 RVA: 0x00AC4024 File Offset: 0x00AC2224
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __clearDele_EventOnPrivateChatButtonClick(IntPtr l)
	{
		int result;
		try
		{
			PlayerSimpleInfoUITask playerSimpleInfoUITask = (PlayerSimpleInfoUITask)LuaObject.checkSelf(l);
			BusinessCard obj;
			LuaObject.checkType<BusinessCard>(l, 2, out obj);
			playerSimpleInfoUITask.m_luaExportHelper.__clearDele_EventOnPrivateChatButtonClick(obj);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060205BB RID: 132539 RVA: 0x00AC4080 File Offset: 0x00AC2280
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callDele_EventOnBlockUser(IntPtr l)
	{
		int result;
		try
		{
			PlayerSimpleInfoUITask playerSimpleInfoUITask = (PlayerSimpleInfoUITask)LuaObject.checkSelf(l);
			playerSimpleInfoUITask.m_luaExportHelper.__callDele_EventOnBlockUser();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060205BC RID: 132540 RVA: 0x00AC40D4 File Offset: 0x00AC22D4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __clearDele_EventOnBlockUser(IntPtr l)
	{
		int result;
		try
		{
			PlayerSimpleInfoUITask playerSimpleInfoUITask = (PlayerSimpleInfoUITask)LuaObject.checkSelf(l);
			playerSimpleInfoUITask.m_luaExportHelper.__clearDele_EventOnBlockUser();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060205BD RID: 132541 RVA: 0x00AC4128 File Offset: 0x00AC2328
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_mainCtrl(IntPtr l)
	{
		int result;
		try
		{
			PlayerSimpleInfoUITask playerSimpleInfoUITask = (PlayerSimpleInfoUITask)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, playerSimpleInfoUITask.m_luaExportHelper.m_mainCtrl);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060205BE RID: 132542 RVA: 0x00AC4180 File Offset: 0x00AC2380
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_mainCtrl(IntPtr l)
	{
		int result;
		try
		{
			PlayerSimpleInfoUITask playerSimpleInfoUITask = (PlayerSimpleInfoUITask)LuaObject.checkSelf(l);
			PlayerSimpleInfoUIController mainCtrl;
			LuaObject.checkType<PlayerSimpleInfoUIController>(l, 2, out mainCtrl);
			playerSimpleInfoUITask.m_luaExportHelper.m_mainCtrl = mainCtrl;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060205BF RID: 132543 RVA: 0x00AC41DC File Offset: 0x00AC23DC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_currInfo(IntPtr l)
	{
		int result;
		try
		{
			PlayerSimpleInfoUITask playerSimpleInfoUITask = (PlayerSimpleInfoUITask)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, playerSimpleInfoUITask.m_luaExportHelper.m_currInfo);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060205C0 RID: 132544 RVA: 0x00AC4234 File Offset: 0x00AC2434
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_currInfo(IntPtr l)
	{
		int result;
		try
		{
			PlayerSimpleInfoUITask playerSimpleInfoUITask = (PlayerSimpleInfoUITask)LuaObject.checkSelf(l);
			BusinessCard currInfo;
			LuaObject.checkType<BusinessCard>(l, 2, out currInfo);
			playerSimpleInfoUITask.m_luaExportHelper.m_currInfo = currInfo;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060205C1 RID: 132545 RVA: 0x00AC4290 File Offset: 0x00AC2490
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_returnUITaskIntent(IntPtr l)
	{
		int result;
		try
		{
			PlayerSimpleInfoUITask playerSimpleInfoUITask = (PlayerSimpleInfoUITask)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, playerSimpleInfoUITask.m_luaExportHelper.m_returnUITaskIntent);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060205C2 RID: 132546 RVA: 0x00AC42E8 File Offset: 0x00AC24E8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_returnUITaskIntent(IntPtr l)
	{
		int result;
		try
		{
			PlayerSimpleInfoUITask playerSimpleInfoUITask = (PlayerSimpleInfoUITask)LuaObject.checkSelf(l);
			UIIntent returnUITaskIntent;
			LuaObject.checkType<UIIntent>(l, 2, out returnUITaskIntent);
			playerSimpleInfoUITask.m_luaExportHelper.m_returnUITaskIntent = returnUITaskIntent;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060205C3 RID: 132547 RVA: 0x00AC4344 File Offset: 0x00AC2544
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_panelPos(IntPtr l)
	{
		int result;
		try
		{
			PlayerSimpleInfoUITask playerSimpleInfoUITask = (PlayerSimpleInfoUITask)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, playerSimpleInfoUITask.m_luaExportHelper.m_panelPos);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060205C4 RID: 132548 RVA: 0x00AC439C File Offset: 0x00AC259C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_panelPos(IntPtr l)
	{
		int result;
		try
		{
			PlayerSimpleInfoUITask playerSimpleInfoUITask = (PlayerSimpleInfoUITask)LuaObject.checkSelf(l);
			Vector3 panelPos;
			LuaObject.checkType(l, 2, out panelPos);
			playerSimpleInfoUITask.m_luaExportHelper.m_panelPos = panelPos;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060205C5 RID: 132549 RVA: 0x00AC43F8 File Offset: 0x00AC25F8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_showPanelType(IntPtr l)
	{
		int result;
		try
		{
			PlayerSimpleInfoUITask playerSimpleInfoUITask = (PlayerSimpleInfoUITask)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushEnum(l, (int)playerSimpleInfoUITask.m_luaExportHelper.m_showPanelType);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060205C6 RID: 132550 RVA: 0x00AC4450 File Offset: 0x00AC2650
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_showPanelType(IntPtr l)
	{
		int result;
		try
		{
			PlayerSimpleInfoUITask playerSimpleInfoUITask = (PlayerSimpleInfoUITask)LuaObject.checkSelf(l);
			PlayerSimpleInfoUITask.PostionType showPanelType;
			LuaObject.checkEnum<PlayerSimpleInfoUITask.PostionType>(l, 2, out showPanelType);
			playerSimpleInfoUITask.m_luaExportHelper.m_showPanelType = showPanelType;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060205C7 RID: 132551 RVA: 0x00AC44AC File Offset: 0x00AC26AC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_deleteFriendUserID(IntPtr l)
	{
		int result;
		try
		{
			PlayerSimpleInfoUITask playerSimpleInfoUITask = (PlayerSimpleInfoUITask)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, playerSimpleInfoUITask.m_luaExportHelper.m_deleteFriendUserID);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060205C8 RID: 132552 RVA: 0x00AC4504 File Offset: 0x00AC2704
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_deleteFriendUserID(IntPtr l)
	{
		int result;
		try
		{
			PlayerSimpleInfoUITask playerSimpleInfoUITask = (PlayerSimpleInfoUITask)LuaObject.checkSelf(l);
			string deleteFriendUserID;
			LuaObject.checkType(l, 2, out deleteFriendUserID);
			playerSimpleInfoUITask.m_luaExportHelper.m_deleteFriendUserID = deleteFriendUserID;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060205C9 RID: 132553 RVA: 0x00AC4560 File Offset: 0x00AC2760
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_layerDescArray(IntPtr l)
	{
		int result;
		try
		{
			PlayerSimpleInfoUITask playerSimpleInfoUITask = (PlayerSimpleInfoUITask)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, playerSimpleInfoUITask.m_luaExportHelper.m_layerDescArray);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060205CA RID: 132554 RVA: 0x00AC45B8 File Offset: 0x00AC27B8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_layerDescArray(IntPtr l)
	{
		int result;
		try
		{
			PlayerSimpleInfoUITask playerSimpleInfoUITask = (PlayerSimpleInfoUITask)LuaObject.checkSelf(l);
			UITaskBase.LayerDesc[] layerDescArray;
			LuaObject.checkArray<UITaskBase.LayerDesc>(l, 2, out layerDescArray);
			playerSimpleInfoUITask.m_luaExportHelper.m_layerDescArray = layerDescArray;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060205CB RID: 132555 RVA: 0x00AC4614 File Offset: 0x00AC2814
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_uiCtrlDescArray(IntPtr l)
	{
		int result;
		try
		{
			PlayerSimpleInfoUITask playerSimpleInfoUITask = (PlayerSimpleInfoUITask)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, playerSimpleInfoUITask.m_luaExportHelper.m_uiCtrlDescArray);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060205CC RID: 132556 RVA: 0x00AC466C File Offset: 0x00AC286C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_uiCtrlDescArray(IntPtr l)
	{
		int result;
		try
		{
			PlayerSimpleInfoUITask playerSimpleInfoUITask = (PlayerSimpleInfoUITask)LuaObject.checkSelf(l);
			UITaskBase.UIControllerDesc[] uiCtrlDescArray;
			LuaObject.checkArray<UITaskBase.UIControllerDesc>(l, 2, out uiCtrlDescArray);
			playerSimpleInfoUITask.m_luaExportHelper.m_uiCtrlDescArray = uiCtrlDescArray;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060205CD RID: 132557 RVA: 0x00AC46C8 File Offset: 0x00AC28C8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_ModeParams_Stranger(IntPtr l)
	{
		int result;
		try
		{
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, "StrangerInfoMode");
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060205CE RID: 132558 RVA: 0x00AC4710 File Offset: 0x00AC2910
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_ModeParams_Friend(IntPtr l)
	{
		int result;
		try
		{
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, "FriendInfoMode");
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060205CF RID: 132559 RVA: 0x00AC4758 File Offset: 0x00AC2958
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_ModeParams_Guild(IntPtr l)
	{
		int result;
		try
		{
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, "GuildInfoMode");
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060205D0 RID: 132560 RVA: 0x00AC47A0 File Offset: 0x00AC29A0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_EventOnClose(IntPtr l)
	{
		int result;
		try
		{
			PlayerSimpleInfoUITask playerSimpleInfoUITask = (PlayerSimpleInfoUITask)LuaObject.checkSelf(l);
			Action value;
			int num = LuaObject.checkDelegate<Action>(l, 2, out value);
			if (num != 0)
			{
				if (num == 1)
				{
					playerSimpleInfoUITask.EventOnClose += value;
				}
				else if (num == 2)
				{
					playerSimpleInfoUITask.EventOnClose -= value;
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

	// Token: 0x060205D1 RID: 132561 RVA: 0x00AC4820 File Offset: 0x00AC2A20
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_EventOnGetSocialRelation(IntPtr l)
	{
		int result;
		try
		{
			PlayerSimpleInfoUITask playerSimpleInfoUITask = (PlayerSimpleInfoUITask)LuaObject.checkSelf(l);
			Action value;
			int num = LuaObject.checkDelegate<Action>(l, 2, out value);
			if (num != 0)
			{
				if (num == 1)
				{
					playerSimpleInfoUITask.EventOnGetSocialRelation += value;
				}
				else if (num == 2)
				{
					playerSimpleInfoUITask.EventOnGetSocialRelation -= value;
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

	// Token: 0x060205D2 RID: 132562 RVA: 0x00AC48A0 File Offset: 0x00AC2AA0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_EventOnPrivateChatButtonClick(IntPtr l)
	{
		int result;
		try
		{
			PlayerSimpleInfoUITask playerSimpleInfoUITask = (PlayerSimpleInfoUITask)LuaObject.checkSelf(l);
			Action<BusinessCard> value;
			int num = LuaObject.checkDelegate<Action<BusinessCard>>(l, 2, out value);
			if (num != 0)
			{
				if (num == 1)
				{
					playerSimpleInfoUITask.EventOnPrivateChatButtonClick += value;
				}
				else if (num == 2)
				{
					playerSimpleInfoUITask.EventOnPrivateChatButtonClick -= value;
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

	// Token: 0x060205D3 RID: 132563 RVA: 0x00AC4920 File Offset: 0x00AC2B20
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_EventOnBlockUser(IntPtr l)
	{
		int result;
		try
		{
			PlayerSimpleInfoUITask playerSimpleInfoUITask = (PlayerSimpleInfoUITask)LuaObject.checkSelf(l);
			Action value;
			int num = LuaObject.checkDelegate<Action>(l, 2, out value);
			if (num != 0)
			{
				if (num == 1)
				{
					playerSimpleInfoUITask.EventOnBlockUser += value;
				}
				else if (num == 2)
				{
					playerSimpleInfoUITask.EventOnBlockUser -= value;
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

	// Token: 0x060205D4 RID: 132564 RVA: 0x00AC49A0 File Offset: 0x00AC2BA0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_Params_PanelPos(IntPtr l)
	{
		int result;
		try
		{
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, "PlayerSimpleInfoPanelPostion");
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060205D5 RID: 132565 RVA: 0x00AC49E8 File Offset: 0x00AC2BE8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_Params_PanelType(IntPtr l)
	{
		int result;
		try
		{
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, "PlayerSimpleInfoPanelType");
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060205D6 RID: 132566 RVA: 0x00AC4A30 File Offset: 0x00AC2C30
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_Params_ReturnToIntent(IntPtr l)
	{
		int result;
		try
		{
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, "PlayerSimpleInfoReturnToIntent");
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060205D7 RID: 132567 RVA: 0x00AC4A78 File Offset: 0x00AC2C78
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_friendAddList(IntPtr l)
	{
		int result;
		try
		{
			PlayerSimpleInfoUITask playerSimpleInfoUITask = (PlayerSimpleInfoUITask)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, playerSimpleInfoUITask.m_luaExportHelper.m_friendAddList);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060205D8 RID: 132568 RVA: 0x00AC4AD0 File Offset: 0x00AC2CD0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_friendAddList(IntPtr l)
	{
		int result;
		try
		{
			PlayerSimpleInfoUITask playerSimpleInfoUITask = (PlayerSimpleInfoUITask)LuaObject.checkSelf(l);
			List<string> friendAddList;
			LuaObject.checkType<List<string>>(l, 2, out friendAddList);
			playerSimpleInfoUITask.m_luaExportHelper.m_friendAddList = friendAddList;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060205D9 RID: 132569 RVA: 0x00AC4B2C File Offset: 0x00AC2D2C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_playerContext(IntPtr l)
	{
		int result;
		try
		{
			PlayerSimpleInfoUITask playerSimpleInfoUITask = (PlayerSimpleInfoUITask)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, playerSimpleInfoUITask.m_luaExportHelper.m_playerContext);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060205DA RID: 132570 RVA: 0x00AC4B84 File Offset: 0x00AC2D84
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_playerContext(IntPtr l)
	{
		int result;
		try
		{
			PlayerSimpleInfoUITask playerSimpleInfoUITask = (PlayerSimpleInfoUITask)LuaObject.checkSelf(l);
			ProjectLPlayerContext playerContext;
			LuaObject.checkType<ProjectLPlayerContext>(l, 2, out playerContext);
			playerSimpleInfoUITask.m_luaExportHelper.m_playerContext = playerContext;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060205DB RID: 132571 RVA: 0x00AC4BE0 File Offset: 0x00AC2DE0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_configDataLoader(IntPtr l)
	{
		int result;
		try
		{
			PlayerSimpleInfoUITask playerSimpleInfoUITask = (PlayerSimpleInfoUITask)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, playerSimpleInfoUITask.m_luaExportHelper.m_configDataLoader);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060205DC RID: 132572 RVA: 0x00AC4C38 File Offset: 0x00AC2E38
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_configDataLoader(IntPtr l)
	{
		int result;
		try
		{
			PlayerSimpleInfoUITask playerSimpleInfoUITask = (PlayerSimpleInfoUITask)LuaObject.checkSelf(l);
			IConfigDataLoader configDataLoader;
			LuaObject.checkType<IConfigDataLoader>(l, 2, out configDataLoader);
			playerSimpleInfoUITask.m_luaExportHelper.m_configDataLoader = configDataLoader;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060205DD RID: 132573 RVA: 0x00AC4C94 File Offset: 0x00AC2E94
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_LayerDescArray(IntPtr l)
	{
		int result;
		try
		{
			PlayerSimpleInfoUITask playerSimpleInfoUITask = (PlayerSimpleInfoUITask)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, playerSimpleInfoUITask.m_luaExportHelper.LayerDescArray);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060205DE RID: 132574 RVA: 0x00AC4CEC File Offset: 0x00AC2EEC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_UICtrlDescArray(IntPtr l)
	{
		int result;
		try
		{
			PlayerSimpleInfoUITask playerSimpleInfoUITask = (PlayerSimpleInfoUITask)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, playerSimpleInfoUITask.m_luaExportHelper.UICtrlDescArray);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060205DF RID: 132575 RVA: 0x00AC4D44 File Offset: 0x00AC2F44
	[Preserve]
	public static void reg(IntPtr l)
	{
		LuaObject.getTypeTable(l, "BlackJack.ProjectL.UI.PlayerSimpleInfoUITask");
		if (Lua_BlackJack_ProjectL_UI_PlayerSimpleInfoUITask.<>f__mg$cache0 == null)
		{
			Lua_BlackJack_ProjectL_UI_PlayerSimpleInfoUITask.<>f__mg$cache0 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_PlayerSimpleInfoUITask.InitlizeBeforeManagerStartIt);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_PlayerSimpleInfoUITask.<>f__mg$cache0);
		if (Lua_BlackJack_ProjectL_UI_PlayerSimpleInfoUITask.<>f__mg$cache1 == null)
		{
			Lua_BlackJack_ProjectL_UI_PlayerSimpleInfoUITask.<>f__mg$cache1 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_PlayerSimpleInfoUITask.ShowPlayerSimpleInfoPanel_s);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_PlayerSimpleInfoUITask.<>f__mg$cache1);
		if (Lua_BlackJack_ProjectL_UI_PlayerSimpleInfoUITask.<>f__mg$cache2 == null)
		{
			Lua_BlackJack_ProjectL_UI_PlayerSimpleInfoUITask.<>f__mg$cache2 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_PlayerSimpleInfoUITask.OnStart);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_PlayerSimpleInfoUITask.<>f__mg$cache2);
		if (Lua_BlackJack_ProjectL_UI_PlayerSimpleInfoUITask.<>f__mg$cache3 == null)
		{
			Lua_BlackJack_ProjectL_UI_PlayerSimpleInfoUITask.<>f__mg$cache3 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_PlayerSimpleInfoUITask.OnStop);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_PlayerSimpleInfoUITask.<>f__mg$cache3);
		if (Lua_BlackJack_ProjectL_UI_PlayerSimpleInfoUITask.<>f__mg$cache4 == null)
		{
			Lua_BlackJack_ProjectL_UI_PlayerSimpleInfoUITask.<>f__mg$cache4 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_PlayerSimpleInfoUITask.OnResume);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_PlayerSimpleInfoUITask.<>f__mg$cache4);
		if (Lua_BlackJack_ProjectL_UI_PlayerSimpleInfoUITask.<>f__mg$cache5 == null)
		{
			Lua_BlackJack_ProjectL_UI_PlayerSimpleInfoUITask.<>f__mg$cache5 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_PlayerSimpleInfoUITask.InitAllUIControllers);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_PlayerSimpleInfoUITask.<>f__mg$cache5);
		if (Lua_BlackJack_ProjectL_UI_PlayerSimpleInfoUITask.<>f__mg$cache6 == null)
		{
			Lua_BlackJack_ProjectL_UI_PlayerSimpleInfoUITask.<>f__mg$cache6 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_PlayerSimpleInfoUITask.IsNeedUpdateDataCache);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_PlayerSimpleInfoUITask.<>f__mg$cache6);
		if (Lua_BlackJack_ProjectL_UI_PlayerSimpleInfoUITask.<>f__mg$cache7 == null)
		{
			Lua_BlackJack_ProjectL_UI_PlayerSimpleInfoUITask.<>f__mg$cache7 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_PlayerSimpleInfoUITask.UpdateDataCache);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_PlayerSimpleInfoUITask.<>f__mg$cache7);
		if (Lua_BlackJack_ProjectL_UI_PlayerSimpleInfoUITask.<>f__mg$cache8 == null)
		{
			Lua_BlackJack_ProjectL_UI_PlayerSimpleInfoUITask.<>f__mg$cache8 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_PlayerSimpleInfoUITask.UpdateView);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_PlayerSimpleInfoUITask.<>f__mg$cache8);
		if (Lua_BlackJack_ProjectL_UI_PlayerSimpleInfoUITask.<>f__mg$cache9 == null)
		{
			Lua_BlackJack_ProjectL_UI_PlayerSimpleInfoUITask.<>f__mg$cache9 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_PlayerSimpleInfoUITask.IsInBattle);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_PlayerSimpleInfoUITask.<>f__mg$cache9);
		if (Lua_BlackJack_ProjectL_UI_PlayerSimpleInfoUITask.<>f__mg$cacheA == null)
		{
			Lua_BlackJack_ProjectL_UI_PlayerSimpleInfoUITask.<>f__mg$cacheA = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_PlayerSimpleInfoUITask.PlayerSimpleInfoUIController_OnWatchCard);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_PlayerSimpleInfoUITask.<>f__mg$cacheA);
		if (Lua_BlackJack_ProjectL_UI_PlayerSimpleInfoUITask.<>f__mg$cacheB == null)
		{
			Lua_BlackJack_ProjectL_UI_PlayerSimpleInfoUITask.<>f__mg$cacheB = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_PlayerSimpleInfoUITask.PlayerSimpleInfoUIController_OnPrivateChat);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_PlayerSimpleInfoUITask.<>f__mg$cacheB);
		if (Lua_BlackJack_ProjectL_UI_PlayerSimpleInfoUITask.<>f__mg$cacheC == null)
		{
			Lua_BlackJack_ProjectL_UI_PlayerSimpleInfoUITask.<>f__mg$cacheC = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_PlayerSimpleInfoUITask.PlayerSimpleInfoUIController_OnPK);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_PlayerSimpleInfoUITask.<>f__mg$cacheC);
		if (Lua_BlackJack_ProjectL_UI_PlayerSimpleInfoUITask.<>f__mg$cacheD == null)
		{
			Lua_BlackJack_ProjectL_UI_PlayerSimpleInfoUITask.<>f__mg$cacheD = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_PlayerSimpleInfoUITask.PlayerSimpleInfoUIController_OnDeleteFriend);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_PlayerSimpleInfoUITask.<>f__mg$cacheD);
		if (Lua_BlackJack_ProjectL_UI_PlayerSimpleInfoUITask.<>f__mg$cacheE == null)
		{
			Lua_BlackJack_ProjectL_UI_PlayerSimpleInfoUITask.<>f__mg$cacheE = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_PlayerSimpleInfoUITask.OnDeleteFreindDialogBoxCallback);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_PlayerSimpleInfoUITask.<>f__mg$cacheE);
		if (Lua_BlackJack_ProjectL_UI_PlayerSimpleInfoUITask.<>f__mg$cacheF == null)
		{
			Lua_BlackJack_ProjectL_UI_PlayerSimpleInfoUITask.<>f__mg$cacheF = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_PlayerSimpleInfoUITask.PlayerSimpleInfoUIController_OnAddFriend);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_PlayerSimpleInfoUITask.<>f__mg$cacheF);
		if (Lua_BlackJack_ProjectL_UI_PlayerSimpleInfoUITask.<>f__mg$cache10 == null)
		{
			Lua_BlackJack_ProjectL_UI_PlayerSimpleInfoUITask.<>f__mg$cache10 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_PlayerSimpleInfoUITask.PlayerSimpleInfoUIController_OnBlock);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_PlayerSimpleInfoUITask.<>f__mg$cache10);
		if (Lua_BlackJack_ProjectL_UI_PlayerSimpleInfoUITask.<>f__mg$cache11 == null)
		{
			Lua_BlackJack_ProjectL_UI_PlayerSimpleInfoUITask.<>f__mg$cache11 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_PlayerSimpleInfoUITask.PlayerSimpleInfoUIController_OnLike);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_PlayerSimpleInfoUITask.<>f__mg$cache11);
		if (Lua_BlackJack_ProjectL_UI_PlayerSimpleInfoUITask.<>f__mg$cache12 == null)
		{
			Lua_BlackJack_ProjectL_UI_PlayerSimpleInfoUITask.<>f__mg$cache12 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_PlayerSimpleInfoUITask.PlayerSimpleInfoUIController_OnReturn);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_PlayerSimpleInfoUITask.<>f__mg$cache12);
		if (Lua_BlackJack_ProjectL_UI_PlayerSimpleInfoUITask.<>f__mg$cache13 == null)
		{
			Lua_BlackJack_ProjectL_UI_PlayerSimpleInfoUITask.<>f__mg$cache13 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_PlayerSimpleInfoUITask.PlayerSimpleInfoUIController_OnExpel);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_PlayerSimpleInfoUITask.<>f__mg$cache13);
		if (Lua_BlackJack_ProjectL_UI_PlayerSimpleInfoUITask.<>f__mg$cache14 == null)
		{
			Lua_BlackJack_ProjectL_UI_PlayerSimpleInfoUITask.<>f__mg$cache14 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_PlayerSimpleInfoUITask.PlayerSimpleInfoUIController_OnVChairmanChange);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_PlayerSimpleInfoUITask.<>f__mg$cache14);
		if (Lua_BlackJack_ProjectL_UI_PlayerSimpleInfoUITask.<>f__mg$cache15 == null)
		{
			Lua_BlackJack_ProjectL_UI_PlayerSimpleInfoUITask.<>f__mg$cache15 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_PlayerSimpleInfoUITask.PlayerSimpleInfoUIController_ChairmanMove);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_PlayerSimpleInfoUITask.<>f__mg$cache15);
		if (Lua_BlackJack_ProjectL_UI_PlayerSimpleInfoUITask.<>f__mg$cache16 == null)
		{
			Lua_BlackJack_ProjectL_UI_PlayerSimpleInfoUITask.<>f__mg$cache16 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_PlayerSimpleInfoUITask.PlayerSimpleInfoUIController_OnChairmanRelieve);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_PlayerSimpleInfoUITask.<>f__mg$cache16);
		if (Lua_BlackJack_ProjectL_UI_PlayerSimpleInfoUITask.<>f__mg$cache17 == null)
		{
			Lua_BlackJack_ProjectL_UI_PlayerSimpleInfoUITask.<>f__mg$cache17 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_PlayerSimpleInfoUITask.ClosePanel);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_PlayerSimpleInfoUITask.<>f__mg$cache17);
		if (Lua_BlackJack_ProjectL_UI_PlayerSimpleInfoUITask.<>f__mg$cache18 == null)
		{
			Lua_BlackJack_ProjectL_UI_PlayerSimpleInfoUITask.<>f__mg$cache18 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_PlayerSimpleInfoUITask.RegisterUIEvent);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_PlayerSimpleInfoUITask.<>f__mg$cache18);
		if (Lua_BlackJack_ProjectL_UI_PlayerSimpleInfoUITask.<>f__mg$cache19 == null)
		{
			Lua_BlackJack_ProjectL_UI_PlayerSimpleInfoUITask.<>f__mg$cache19 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_PlayerSimpleInfoUITask.UnRegiterUIEvent);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_PlayerSimpleInfoUITask.<>f__mg$cache19);
		if (Lua_BlackJack_ProjectL_UI_PlayerSimpleInfoUITask.<>f__mg$cache1A == null)
		{
			Lua_BlackJack_ProjectL_UI_PlayerSimpleInfoUITask.<>f__mg$cache1A = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_PlayerSimpleInfoUITask.SetPanelPostion);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_PlayerSimpleInfoUITask.<>f__mg$cache1A);
		if (Lua_BlackJack_ProjectL_UI_PlayerSimpleInfoUITask.<>f__mg$cache1B == null)
		{
			Lua_BlackJack_ProjectL_UI_PlayerSimpleInfoUITask.<>f__mg$cache1B = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_PlayerSimpleInfoUITask.__callBase_OnStart);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_PlayerSimpleInfoUITask.<>f__mg$cache1B);
		if (Lua_BlackJack_ProjectL_UI_PlayerSimpleInfoUITask.<>f__mg$cache1C == null)
		{
			Lua_BlackJack_ProjectL_UI_PlayerSimpleInfoUITask.<>f__mg$cache1C = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_PlayerSimpleInfoUITask.__callBase_OnStop);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_PlayerSimpleInfoUITask.<>f__mg$cache1C);
		if (Lua_BlackJack_ProjectL_UI_PlayerSimpleInfoUITask.<>f__mg$cache1D == null)
		{
			Lua_BlackJack_ProjectL_UI_PlayerSimpleInfoUITask.<>f__mg$cache1D = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_PlayerSimpleInfoUITask.__callBase_OnPause);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_PlayerSimpleInfoUITask.<>f__mg$cache1D);
		if (Lua_BlackJack_ProjectL_UI_PlayerSimpleInfoUITask.<>f__mg$cache1E == null)
		{
			Lua_BlackJack_ProjectL_UI_PlayerSimpleInfoUITask.<>f__mg$cache1E = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_PlayerSimpleInfoUITask.__callBase_OnResume);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_PlayerSimpleInfoUITask.<>f__mg$cache1E);
		if (Lua_BlackJack_ProjectL_UI_PlayerSimpleInfoUITask.<>f__mg$cache1F == null)
		{
			Lua_BlackJack_ProjectL_UI_PlayerSimpleInfoUITask.<>f__mg$cache1F = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_PlayerSimpleInfoUITask.__callBase_OnNewIntent);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_PlayerSimpleInfoUITask.<>f__mg$cache1F);
		if (Lua_BlackJack_ProjectL_UI_PlayerSimpleInfoUITask.<>f__mg$cache20 == null)
		{
			Lua_BlackJack_ProjectL_UI_PlayerSimpleInfoUITask.<>f__mg$cache20 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_PlayerSimpleInfoUITask.__callBase_EnableUIInput);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_PlayerSimpleInfoUITask.<>f__mg$cache20);
		if (Lua_BlackJack_ProjectL_UI_PlayerSimpleInfoUITask.<>f__mg$cache21 == null)
		{
			Lua_BlackJack_ProjectL_UI_PlayerSimpleInfoUITask.<>f__mg$cache21 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_PlayerSimpleInfoUITask.__callBase_IsNeedLoadDynamicRes);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_PlayerSimpleInfoUITask.<>f__mg$cache21);
		if (Lua_BlackJack_ProjectL_UI_PlayerSimpleInfoUITask.<>f__mg$cache22 == null)
		{
			Lua_BlackJack_ProjectL_UI_PlayerSimpleInfoUITask.<>f__mg$cache22 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_PlayerSimpleInfoUITask.__callBase_CollectAllDynamicResForLoad);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_PlayerSimpleInfoUITask.<>f__mg$cache22);
		if (Lua_BlackJack_ProjectL_UI_PlayerSimpleInfoUITask.<>f__mg$cache23 == null)
		{
			Lua_BlackJack_ProjectL_UI_PlayerSimpleInfoUITask.<>f__mg$cache23 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_PlayerSimpleInfoUITask.__callBase_RegisterPlayerContextEvents);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_PlayerSimpleInfoUITask.<>f__mg$cache23);
		if (Lua_BlackJack_ProjectL_UI_PlayerSimpleInfoUITask.<>f__mg$cache24 == null)
		{
			Lua_BlackJack_ProjectL_UI_PlayerSimpleInfoUITask.<>f__mg$cache24 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_PlayerSimpleInfoUITask.__callBase_UnregisterPlayerContextEvents);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_PlayerSimpleInfoUITask.<>f__mg$cache24);
		if (Lua_BlackJack_ProjectL_UI_PlayerSimpleInfoUITask.<>f__mg$cache25 == null)
		{
			Lua_BlackJack_ProjectL_UI_PlayerSimpleInfoUITask.<>f__mg$cache25 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_PlayerSimpleInfoUITask.__callBase_PostUpdateView);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_PlayerSimpleInfoUITask.<>f__mg$cache25);
		if (Lua_BlackJack_ProjectL_UI_PlayerSimpleInfoUITask.<>f__mg$cache26 == null)
		{
			Lua_BlackJack_ProjectL_UI_PlayerSimpleInfoUITask.<>f__mg$cache26 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_PlayerSimpleInfoUITask.__callBase_CollectPreloadResourceList);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_PlayerSimpleInfoUITask.<>f__mg$cache26);
		if (Lua_BlackJack_ProjectL_UI_PlayerSimpleInfoUITask.<>f__mg$cache27 == null)
		{
			Lua_BlackJack_ProjectL_UI_PlayerSimpleInfoUITask.<>f__mg$cache27 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_PlayerSimpleInfoUITask.__callBase_ClearAssetList);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_PlayerSimpleInfoUITask.<>f__mg$cache27);
		if (Lua_BlackJack_ProjectL_UI_PlayerSimpleInfoUITask.<>f__mg$cache28 == null)
		{
			Lua_BlackJack_ProjectL_UI_PlayerSimpleInfoUITask.<>f__mg$cache28 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_PlayerSimpleInfoUITask.__callBase_CollectAsset);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_PlayerSimpleInfoUITask.<>f__mg$cache28);
		if (Lua_BlackJack_ProjectL_UI_PlayerSimpleInfoUITask.<>f__mg$cache29 == null)
		{
			Lua_BlackJack_ProjectL_UI_PlayerSimpleInfoUITask.<>f__mg$cache29 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_PlayerSimpleInfoUITask.__callBase_CollectSpriteAsset);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_PlayerSimpleInfoUITask.<>f__mg$cache29);
		if (Lua_BlackJack_ProjectL_UI_PlayerSimpleInfoUITask.<>f__mg$cache2A == null)
		{
			Lua_BlackJack_ProjectL_UI_PlayerSimpleInfoUITask.<>f__mg$cache2A = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_PlayerSimpleInfoUITask.__callBase_CollectFxAsset);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_PlayerSimpleInfoUITask.<>f__mg$cache2A);
		if (Lua_BlackJack_ProjectL_UI_PlayerSimpleInfoUITask.<>f__mg$cache2B == null)
		{
			Lua_BlackJack_ProjectL_UI_PlayerSimpleInfoUITask.<>f__mg$cache2B = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_PlayerSimpleInfoUITask.__callBase_StartLoadCustomAssets);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_PlayerSimpleInfoUITask.<>f__mg$cache2B);
		if (Lua_BlackJack_ProjectL_UI_PlayerSimpleInfoUITask.<>f__mg$cache2C == null)
		{
			Lua_BlackJack_ProjectL_UI_PlayerSimpleInfoUITask.<>f__mg$cache2C = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_PlayerSimpleInfoUITask.__callBase_IsLoadingCustomAssets);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_PlayerSimpleInfoUITask.<>f__mg$cache2C);
		if (Lua_BlackJack_ProjectL_UI_PlayerSimpleInfoUITask.<>f__mg$cache2D == null)
		{
			Lua_BlackJack_ProjectL_UI_PlayerSimpleInfoUITask.<>f__mg$cache2D = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_PlayerSimpleInfoUITask.__callBase_IsPipeLineRunning);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_PlayerSimpleInfoUITask.<>f__mg$cache2D);
		if (Lua_BlackJack_ProjectL_UI_PlayerSimpleInfoUITask.<>f__mg$cache2E == null)
		{
			Lua_BlackJack_ProjectL_UI_PlayerSimpleInfoUITask.<>f__mg$cache2E = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_PlayerSimpleInfoUITask.__callBase_IsOpeningUI);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_PlayerSimpleInfoUITask.<>f__mg$cache2E);
		if (Lua_BlackJack_ProjectL_UI_PlayerSimpleInfoUITask.<>f__mg$cache2F == null)
		{
			Lua_BlackJack_ProjectL_UI_PlayerSimpleInfoUITask.<>f__mg$cache2F = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_PlayerSimpleInfoUITask.__callBase_ReturnPrevUITask);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_PlayerSimpleInfoUITask.<>f__mg$cache2F);
		if (Lua_BlackJack_ProjectL_UI_PlayerSimpleInfoUITask.<>f__mg$cache30 == null)
		{
			Lua_BlackJack_ProjectL_UI_PlayerSimpleInfoUITask.<>f__mg$cache30 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_PlayerSimpleInfoUITask.__callBase_ClearUnusedDynamicResourceCache);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_PlayerSimpleInfoUITask.<>f__mg$cache30);
		if (Lua_BlackJack_ProjectL_UI_PlayerSimpleInfoUITask.<>f__mg$cache31 == null)
		{
			Lua_BlackJack_ProjectL_UI_PlayerSimpleInfoUITask.<>f__mg$cache31 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_PlayerSimpleInfoUITask.__callBase_OnMemoryWarning);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_PlayerSimpleInfoUITask.<>f__mg$cache31);
		if (Lua_BlackJack_ProjectL_UI_PlayerSimpleInfoUITask.<>f__mg$cache32 == null)
		{
			Lua_BlackJack_ProjectL_UI_PlayerSimpleInfoUITask.<>f__mg$cache32 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_PlayerSimpleInfoUITask.__callDele_EventOnClose);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_PlayerSimpleInfoUITask.<>f__mg$cache32);
		if (Lua_BlackJack_ProjectL_UI_PlayerSimpleInfoUITask.<>f__mg$cache33 == null)
		{
			Lua_BlackJack_ProjectL_UI_PlayerSimpleInfoUITask.<>f__mg$cache33 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_PlayerSimpleInfoUITask.__clearDele_EventOnClose);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_PlayerSimpleInfoUITask.<>f__mg$cache33);
		if (Lua_BlackJack_ProjectL_UI_PlayerSimpleInfoUITask.<>f__mg$cache34 == null)
		{
			Lua_BlackJack_ProjectL_UI_PlayerSimpleInfoUITask.<>f__mg$cache34 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_PlayerSimpleInfoUITask.__callDele_EventOnGetSocialRelation);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_PlayerSimpleInfoUITask.<>f__mg$cache34);
		if (Lua_BlackJack_ProjectL_UI_PlayerSimpleInfoUITask.<>f__mg$cache35 == null)
		{
			Lua_BlackJack_ProjectL_UI_PlayerSimpleInfoUITask.<>f__mg$cache35 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_PlayerSimpleInfoUITask.__clearDele_EventOnGetSocialRelation);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_PlayerSimpleInfoUITask.<>f__mg$cache35);
		if (Lua_BlackJack_ProjectL_UI_PlayerSimpleInfoUITask.<>f__mg$cache36 == null)
		{
			Lua_BlackJack_ProjectL_UI_PlayerSimpleInfoUITask.<>f__mg$cache36 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_PlayerSimpleInfoUITask.__callDele_EventOnPrivateChatButtonClick);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_PlayerSimpleInfoUITask.<>f__mg$cache36);
		if (Lua_BlackJack_ProjectL_UI_PlayerSimpleInfoUITask.<>f__mg$cache37 == null)
		{
			Lua_BlackJack_ProjectL_UI_PlayerSimpleInfoUITask.<>f__mg$cache37 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_PlayerSimpleInfoUITask.__clearDele_EventOnPrivateChatButtonClick);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_PlayerSimpleInfoUITask.<>f__mg$cache37);
		if (Lua_BlackJack_ProjectL_UI_PlayerSimpleInfoUITask.<>f__mg$cache38 == null)
		{
			Lua_BlackJack_ProjectL_UI_PlayerSimpleInfoUITask.<>f__mg$cache38 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_PlayerSimpleInfoUITask.__callDele_EventOnBlockUser);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_PlayerSimpleInfoUITask.<>f__mg$cache38);
		if (Lua_BlackJack_ProjectL_UI_PlayerSimpleInfoUITask.<>f__mg$cache39 == null)
		{
			Lua_BlackJack_ProjectL_UI_PlayerSimpleInfoUITask.<>f__mg$cache39 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_PlayerSimpleInfoUITask.__clearDele_EventOnBlockUser);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_PlayerSimpleInfoUITask.<>f__mg$cache39);
		string name = "m_mainCtrl";
		if (Lua_BlackJack_ProjectL_UI_PlayerSimpleInfoUITask.<>f__mg$cache3A == null)
		{
			Lua_BlackJack_ProjectL_UI_PlayerSimpleInfoUITask.<>f__mg$cache3A = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_PlayerSimpleInfoUITask.get_m_mainCtrl);
		}
		LuaCSFunction get = Lua_BlackJack_ProjectL_UI_PlayerSimpleInfoUITask.<>f__mg$cache3A;
		if (Lua_BlackJack_ProjectL_UI_PlayerSimpleInfoUITask.<>f__mg$cache3B == null)
		{
			Lua_BlackJack_ProjectL_UI_PlayerSimpleInfoUITask.<>f__mg$cache3B = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_PlayerSimpleInfoUITask.set_m_mainCtrl);
		}
		LuaObject.addMember(l, name, get, Lua_BlackJack_ProjectL_UI_PlayerSimpleInfoUITask.<>f__mg$cache3B, true);
		string name2 = "m_currInfo";
		if (Lua_BlackJack_ProjectL_UI_PlayerSimpleInfoUITask.<>f__mg$cache3C == null)
		{
			Lua_BlackJack_ProjectL_UI_PlayerSimpleInfoUITask.<>f__mg$cache3C = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_PlayerSimpleInfoUITask.get_m_currInfo);
		}
		LuaCSFunction get2 = Lua_BlackJack_ProjectL_UI_PlayerSimpleInfoUITask.<>f__mg$cache3C;
		if (Lua_BlackJack_ProjectL_UI_PlayerSimpleInfoUITask.<>f__mg$cache3D == null)
		{
			Lua_BlackJack_ProjectL_UI_PlayerSimpleInfoUITask.<>f__mg$cache3D = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_PlayerSimpleInfoUITask.set_m_currInfo);
		}
		LuaObject.addMember(l, name2, get2, Lua_BlackJack_ProjectL_UI_PlayerSimpleInfoUITask.<>f__mg$cache3D, true);
		string name3 = "m_returnUITaskIntent";
		if (Lua_BlackJack_ProjectL_UI_PlayerSimpleInfoUITask.<>f__mg$cache3E == null)
		{
			Lua_BlackJack_ProjectL_UI_PlayerSimpleInfoUITask.<>f__mg$cache3E = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_PlayerSimpleInfoUITask.get_m_returnUITaskIntent);
		}
		LuaCSFunction get3 = Lua_BlackJack_ProjectL_UI_PlayerSimpleInfoUITask.<>f__mg$cache3E;
		if (Lua_BlackJack_ProjectL_UI_PlayerSimpleInfoUITask.<>f__mg$cache3F == null)
		{
			Lua_BlackJack_ProjectL_UI_PlayerSimpleInfoUITask.<>f__mg$cache3F = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_PlayerSimpleInfoUITask.set_m_returnUITaskIntent);
		}
		LuaObject.addMember(l, name3, get3, Lua_BlackJack_ProjectL_UI_PlayerSimpleInfoUITask.<>f__mg$cache3F, true);
		string name4 = "m_panelPos";
		if (Lua_BlackJack_ProjectL_UI_PlayerSimpleInfoUITask.<>f__mg$cache40 == null)
		{
			Lua_BlackJack_ProjectL_UI_PlayerSimpleInfoUITask.<>f__mg$cache40 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_PlayerSimpleInfoUITask.get_m_panelPos);
		}
		LuaCSFunction get4 = Lua_BlackJack_ProjectL_UI_PlayerSimpleInfoUITask.<>f__mg$cache40;
		if (Lua_BlackJack_ProjectL_UI_PlayerSimpleInfoUITask.<>f__mg$cache41 == null)
		{
			Lua_BlackJack_ProjectL_UI_PlayerSimpleInfoUITask.<>f__mg$cache41 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_PlayerSimpleInfoUITask.set_m_panelPos);
		}
		LuaObject.addMember(l, name4, get4, Lua_BlackJack_ProjectL_UI_PlayerSimpleInfoUITask.<>f__mg$cache41, true);
		string name5 = "m_showPanelType";
		if (Lua_BlackJack_ProjectL_UI_PlayerSimpleInfoUITask.<>f__mg$cache42 == null)
		{
			Lua_BlackJack_ProjectL_UI_PlayerSimpleInfoUITask.<>f__mg$cache42 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_PlayerSimpleInfoUITask.get_m_showPanelType);
		}
		LuaCSFunction get5 = Lua_BlackJack_ProjectL_UI_PlayerSimpleInfoUITask.<>f__mg$cache42;
		if (Lua_BlackJack_ProjectL_UI_PlayerSimpleInfoUITask.<>f__mg$cache43 == null)
		{
			Lua_BlackJack_ProjectL_UI_PlayerSimpleInfoUITask.<>f__mg$cache43 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_PlayerSimpleInfoUITask.set_m_showPanelType);
		}
		LuaObject.addMember(l, name5, get5, Lua_BlackJack_ProjectL_UI_PlayerSimpleInfoUITask.<>f__mg$cache43, true);
		string name6 = "m_deleteFriendUserID";
		if (Lua_BlackJack_ProjectL_UI_PlayerSimpleInfoUITask.<>f__mg$cache44 == null)
		{
			Lua_BlackJack_ProjectL_UI_PlayerSimpleInfoUITask.<>f__mg$cache44 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_PlayerSimpleInfoUITask.get_m_deleteFriendUserID);
		}
		LuaCSFunction get6 = Lua_BlackJack_ProjectL_UI_PlayerSimpleInfoUITask.<>f__mg$cache44;
		if (Lua_BlackJack_ProjectL_UI_PlayerSimpleInfoUITask.<>f__mg$cache45 == null)
		{
			Lua_BlackJack_ProjectL_UI_PlayerSimpleInfoUITask.<>f__mg$cache45 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_PlayerSimpleInfoUITask.set_m_deleteFriendUserID);
		}
		LuaObject.addMember(l, name6, get6, Lua_BlackJack_ProjectL_UI_PlayerSimpleInfoUITask.<>f__mg$cache45, true);
		string name7 = "m_layerDescArray";
		if (Lua_BlackJack_ProjectL_UI_PlayerSimpleInfoUITask.<>f__mg$cache46 == null)
		{
			Lua_BlackJack_ProjectL_UI_PlayerSimpleInfoUITask.<>f__mg$cache46 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_PlayerSimpleInfoUITask.get_m_layerDescArray);
		}
		LuaCSFunction get7 = Lua_BlackJack_ProjectL_UI_PlayerSimpleInfoUITask.<>f__mg$cache46;
		if (Lua_BlackJack_ProjectL_UI_PlayerSimpleInfoUITask.<>f__mg$cache47 == null)
		{
			Lua_BlackJack_ProjectL_UI_PlayerSimpleInfoUITask.<>f__mg$cache47 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_PlayerSimpleInfoUITask.set_m_layerDescArray);
		}
		LuaObject.addMember(l, name7, get7, Lua_BlackJack_ProjectL_UI_PlayerSimpleInfoUITask.<>f__mg$cache47, true);
		string name8 = "m_uiCtrlDescArray";
		if (Lua_BlackJack_ProjectL_UI_PlayerSimpleInfoUITask.<>f__mg$cache48 == null)
		{
			Lua_BlackJack_ProjectL_UI_PlayerSimpleInfoUITask.<>f__mg$cache48 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_PlayerSimpleInfoUITask.get_m_uiCtrlDescArray);
		}
		LuaCSFunction get8 = Lua_BlackJack_ProjectL_UI_PlayerSimpleInfoUITask.<>f__mg$cache48;
		if (Lua_BlackJack_ProjectL_UI_PlayerSimpleInfoUITask.<>f__mg$cache49 == null)
		{
			Lua_BlackJack_ProjectL_UI_PlayerSimpleInfoUITask.<>f__mg$cache49 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_PlayerSimpleInfoUITask.set_m_uiCtrlDescArray);
		}
		LuaObject.addMember(l, name8, get8, Lua_BlackJack_ProjectL_UI_PlayerSimpleInfoUITask.<>f__mg$cache49, true);
		string name9 = "ModeParams_Stranger";
		if (Lua_BlackJack_ProjectL_UI_PlayerSimpleInfoUITask.<>f__mg$cache4A == null)
		{
			Lua_BlackJack_ProjectL_UI_PlayerSimpleInfoUITask.<>f__mg$cache4A = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_PlayerSimpleInfoUITask.get_ModeParams_Stranger);
		}
		LuaObject.addMember(l, name9, Lua_BlackJack_ProjectL_UI_PlayerSimpleInfoUITask.<>f__mg$cache4A, null, false);
		string name10 = "ModeParams_Friend";
		if (Lua_BlackJack_ProjectL_UI_PlayerSimpleInfoUITask.<>f__mg$cache4B == null)
		{
			Lua_BlackJack_ProjectL_UI_PlayerSimpleInfoUITask.<>f__mg$cache4B = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_PlayerSimpleInfoUITask.get_ModeParams_Friend);
		}
		LuaObject.addMember(l, name10, Lua_BlackJack_ProjectL_UI_PlayerSimpleInfoUITask.<>f__mg$cache4B, null, false);
		string name11 = "ModeParams_Guild";
		if (Lua_BlackJack_ProjectL_UI_PlayerSimpleInfoUITask.<>f__mg$cache4C == null)
		{
			Lua_BlackJack_ProjectL_UI_PlayerSimpleInfoUITask.<>f__mg$cache4C = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_PlayerSimpleInfoUITask.get_ModeParams_Guild);
		}
		LuaObject.addMember(l, name11, Lua_BlackJack_ProjectL_UI_PlayerSimpleInfoUITask.<>f__mg$cache4C, null, false);
		string name12 = "EventOnClose";
		LuaCSFunction get9 = null;
		if (Lua_BlackJack_ProjectL_UI_PlayerSimpleInfoUITask.<>f__mg$cache4D == null)
		{
			Lua_BlackJack_ProjectL_UI_PlayerSimpleInfoUITask.<>f__mg$cache4D = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_PlayerSimpleInfoUITask.set_EventOnClose);
		}
		LuaObject.addMember(l, name12, get9, Lua_BlackJack_ProjectL_UI_PlayerSimpleInfoUITask.<>f__mg$cache4D, true);
		string name13 = "EventOnGetSocialRelation";
		LuaCSFunction get10 = null;
		if (Lua_BlackJack_ProjectL_UI_PlayerSimpleInfoUITask.<>f__mg$cache4E == null)
		{
			Lua_BlackJack_ProjectL_UI_PlayerSimpleInfoUITask.<>f__mg$cache4E = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_PlayerSimpleInfoUITask.set_EventOnGetSocialRelation);
		}
		LuaObject.addMember(l, name13, get10, Lua_BlackJack_ProjectL_UI_PlayerSimpleInfoUITask.<>f__mg$cache4E, true);
		string name14 = "EventOnPrivateChatButtonClick";
		LuaCSFunction get11 = null;
		if (Lua_BlackJack_ProjectL_UI_PlayerSimpleInfoUITask.<>f__mg$cache4F == null)
		{
			Lua_BlackJack_ProjectL_UI_PlayerSimpleInfoUITask.<>f__mg$cache4F = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_PlayerSimpleInfoUITask.set_EventOnPrivateChatButtonClick);
		}
		LuaObject.addMember(l, name14, get11, Lua_BlackJack_ProjectL_UI_PlayerSimpleInfoUITask.<>f__mg$cache4F, true);
		string name15 = "EventOnBlockUser";
		LuaCSFunction get12 = null;
		if (Lua_BlackJack_ProjectL_UI_PlayerSimpleInfoUITask.<>f__mg$cache50 == null)
		{
			Lua_BlackJack_ProjectL_UI_PlayerSimpleInfoUITask.<>f__mg$cache50 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_PlayerSimpleInfoUITask.set_EventOnBlockUser);
		}
		LuaObject.addMember(l, name15, get12, Lua_BlackJack_ProjectL_UI_PlayerSimpleInfoUITask.<>f__mg$cache50, true);
		string name16 = "Params_PanelPos";
		if (Lua_BlackJack_ProjectL_UI_PlayerSimpleInfoUITask.<>f__mg$cache51 == null)
		{
			Lua_BlackJack_ProjectL_UI_PlayerSimpleInfoUITask.<>f__mg$cache51 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_PlayerSimpleInfoUITask.get_Params_PanelPos);
		}
		LuaObject.addMember(l, name16, Lua_BlackJack_ProjectL_UI_PlayerSimpleInfoUITask.<>f__mg$cache51, null, false);
		string name17 = "Params_PanelType";
		if (Lua_BlackJack_ProjectL_UI_PlayerSimpleInfoUITask.<>f__mg$cache52 == null)
		{
			Lua_BlackJack_ProjectL_UI_PlayerSimpleInfoUITask.<>f__mg$cache52 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_PlayerSimpleInfoUITask.get_Params_PanelType);
		}
		LuaObject.addMember(l, name17, Lua_BlackJack_ProjectL_UI_PlayerSimpleInfoUITask.<>f__mg$cache52, null, false);
		string name18 = "Params_ReturnToIntent";
		if (Lua_BlackJack_ProjectL_UI_PlayerSimpleInfoUITask.<>f__mg$cache53 == null)
		{
			Lua_BlackJack_ProjectL_UI_PlayerSimpleInfoUITask.<>f__mg$cache53 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_PlayerSimpleInfoUITask.get_Params_ReturnToIntent);
		}
		LuaObject.addMember(l, name18, Lua_BlackJack_ProjectL_UI_PlayerSimpleInfoUITask.<>f__mg$cache53, null, false);
		string name19 = "m_friendAddList";
		if (Lua_BlackJack_ProjectL_UI_PlayerSimpleInfoUITask.<>f__mg$cache54 == null)
		{
			Lua_BlackJack_ProjectL_UI_PlayerSimpleInfoUITask.<>f__mg$cache54 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_PlayerSimpleInfoUITask.get_m_friendAddList);
		}
		LuaCSFunction get13 = Lua_BlackJack_ProjectL_UI_PlayerSimpleInfoUITask.<>f__mg$cache54;
		if (Lua_BlackJack_ProjectL_UI_PlayerSimpleInfoUITask.<>f__mg$cache55 == null)
		{
			Lua_BlackJack_ProjectL_UI_PlayerSimpleInfoUITask.<>f__mg$cache55 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_PlayerSimpleInfoUITask.set_m_friendAddList);
		}
		LuaObject.addMember(l, name19, get13, Lua_BlackJack_ProjectL_UI_PlayerSimpleInfoUITask.<>f__mg$cache55, true);
		string name20 = "m_playerContext";
		if (Lua_BlackJack_ProjectL_UI_PlayerSimpleInfoUITask.<>f__mg$cache56 == null)
		{
			Lua_BlackJack_ProjectL_UI_PlayerSimpleInfoUITask.<>f__mg$cache56 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_PlayerSimpleInfoUITask.get_m_playerContext);
		}
		LuaCSFunction get14 = Lua_BlackJack_ProjectL_UI_PlayerSimpleInfoUITask.<>f__mg$cache56;
		if (Lua_BlackJack_ProjectL_UI_PlayerSimpleInfoUITask.<>f__mg$cache57 == null)
		{
			Lua_BlackJack_ProjectL_UI_PlayerSimpleInfoUITask.<>f__mg$cache57 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_PlayerSimpleInfoUITask.set_m_playerContext);
		}
		LuaObject.addMember(l, name20, get14, Lua_BlackJack_ProjectL_UI_PlayerSimpleInfoUITask.<>f__mg$cache57, true);
		string name21 = "m_configDataLoader";
		if (Lua_BlackJack_ProjectL_UI_PlayerSimpleInfoUITask.<>f__mg$cache58 == null)
		{
			Lua_BlackJack_ProjectL_UI_PlayerSimpleInfoUITask.<>f__mg$cache58 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_PlayerSimpleInfoUITask.get_m_configDataLoader);
		}
		LuaCSFunction get15 = Lua_BlackJack_ProjectL_UI_PlayerSimpleInfoUITask.<>f__mg$cache58;
		if (Lua_BlackJack_ProjectL_UI_PlayerSimpleInfoUITask.<>f__mg$cache59 == null)
		{
			Lua_BlackJack_ProjectL_UI_PlayerSimpleInfoUITask.<>f__mg$cache59 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_PlayerSimpleInfoUITask.set_m_configDataLoader);
		}
		LuaObject.addMember(l, name21, get15, Lua_BlackJack_ProjectL_UI_PlayerSimpleInfoUITask.<>f__mg$cache59, true);
		string name22 = "LayerDescArray";
		if (Lua_BlackJack_ProjectL_UI_PlayerSimpleInfoUITask.<>f__mg$cache5A == null)
		{
			Lua_BlackJack_ProjectL_UI_PlayerSimpleInfoUITask.<>f__mg$cache5A = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_PlayerSimpleInfoUITask.get_LayerDescArray);
		}
		LuaObject.addMember(l, name22, Lua_BlackJack_ProjectL_UI_PlayerSimpleInfoUITask.<>f__mg$cache5A, null, true);
		string name23 = "UICtrlDescArray";
		if (Lua_BlackJack_ProjectL_UI_PlayerSimpleInfoUITask.<>f__mg$cache5B == null)
		{
			Lua_BlackJack_ProjectL_UI_PlayerSimpleInfoUITask.<>f__mg$cache5B = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_PlayerSimpleInfoUITask.get_UICtrlDescArray);
		}
		LuaObject.addMember(l, name23, Lua_BlackJack_ProjectL_UI_PlayerSimpleInfoUITask.<>f__mg$cache5B, null, true);
		if (Lua_BlackJack_ProjectL_UI_PlayerSimpleInfoUITask.<>f__mg$cache5C == null)
		{
			Lua_BlackJack_ProjectL_UI_PlayerSimpleInfoUITask.<>f__mg$cache5C = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_PlayerSimpleInfoUITask.constructor);
		}
		LuaObject.createTypeMetatable(l, Lua_BlackJack_ProjectL_UI_PlayerSimpleInfoUITask.<>f__mg$cache5C, typeof(PlayerSimpleInfoUITask), typeof(UITask));
	}

	// Token: 0x040164FE RID: 91390
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache0;

	// Token: 0x040164FF RID: 91391
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1;

	// Token: 0x04016500 RID: 91392
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2;

	// Token: 0x04016501 RID: 91393
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3;

	// Token: 0x04016502 RID: 91394
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache4;

	// Token: 0x04016503 RID: 91395
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache5;

	// Token: 0x04016504 RID: 91396
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache6;

	// Token: 0x04016505 RID: 91397
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache7;

	// Token: 0x04016506 RID: 91398
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache8;

	// Token: 0x04016507 RID: 91399
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache9;

	// Token: 0x04016508 RID: 91400
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheA;

	// Token: 0x04016509 RID: 91401
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheB;

	// Token: 0x0401650A RID: 91402
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheC;

	// Token: 0x0401650B RID: 91403
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheD;

	// Token: 0x0401650C RID: 91404
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheE;

	// Token: 0x0401650D RID: 91405
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheF;

	// Token: 0x0401650E RID: 91406
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache10;

	// Token: 0x0401650F RID: 91407
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache11;

	// Token: 0x04016510 RID: 91408
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache12;

	// Token: 0x04016511 RID: 91409
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache13;

	// Token: 0x04016512 RID: 91410
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache14;

	// Token: 0x04016513 RID: 91411
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache15;

	// Token: 0x04016514 RID: 91412
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache16;

	// Token: 0x04016515 RID: 91413
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache17;

	// Token: 0x04016516 RID: 91414
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache18;

	// Token: 0x04016517 RID: 91415
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache19;

	// Token: 0x04016518 RID: 91416
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1A;

	// Token: 0x04016519 RID: 91417
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1B;

	// Token: 0x0401651A RID: 91418
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1C;

	// Token: 0x0401651B RID: 91419
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1D;

	// Token: 0x0401651C RID: 91420
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1E;

	// Token: 0x0401651D RID: 91421
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1F;

	// Token: 0x0401651E RID: 91422
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache20;

	// Token: 0x0401651F RID: 91423
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache21;

	// Token: 0x04016520 RID: 91424
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache22;

	// Token: 0x04016521 RID: 91425
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache23;

	// Token: 0x04016522 RID: 91426
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache24;

	// Token: 0x04016523 RID: 91427
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache25;

	// Token: 0x04016524 RID: 91428
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache26;

	// Token: 0x04016525 RID: 91429
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache27;

	// Token: 0x04016526 RID: 91430
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache28;

	// Token: 0x04016527 RID: 91431
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache29;

	// Token: 0x04016528 RID: 91432
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2A;

	// Token: 0x04016529 RID: 91433
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2B;

	// Token: 0x0401652A RID: 91434
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2C;

	// Token: 0x0401652B RID: 91435
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2D;

	// Token: 0x0401652C RID: 91436
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2E;

	// Token: 0x0401652D RID: 91437
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2F;

	// Token: 0x0401652E RID: 91438
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache30;

	// Token: 0x0401652F RID: 91439
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache31;

	// Token: 0x04016530 RID: 91440
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache32;

	// Token: 0x04016531 RID: 91441
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache33;

	// Token: 0x04016532 RID: 91442
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache34;

	// Token: 0x04016533 RID: 91443
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache35;

	// Token: 0x04016534 RID: 91444
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache36;

	// Token: 0x04016535 RID: 91445
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache37;

	// Token: 0x04016536 RID: 91446
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache38;

	// Token: 0x04016537 RID: 91447
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache39;

	// Token: 0x04016538 RID: 91448
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3A;

	// Token: 0x04016539 RID: 91449
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3B;

	// Token: 0x0401653A RID: 91450
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3C;

	// Token: 0x0401653B RID: 91451
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3D;

	// Token: 0x0401653C RID: 91452
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3E;

	// Token: 0x0401653D RID: 91453
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3F;

	// Token: 0x0401653E RID: 91454
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache40;

	// Token: 0x0401653F RID: 91455
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache41;

	// Token: 0x04016540 RID: 91456
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache42;

	// Token: 0x04016541 RID: 91457
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache43;

	// Token: 0x04016542 RID: 91458
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache44;

	// Token: 0x04016543 RID: 91459
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache45;

	// Token: 0x04016544 RID: 91460
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache46;

	// Token: 0x04016545 RID: 91461
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache47;

	// Token: 0x04016546 RID: 91462
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache48;

	// Token: 0x04016547 RID: 91463
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache49;

	// Token: 0x04016548 RID: 91464
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache4A;

	// Token: 0x04016549 RID: 91465
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache4B;

	// Token: 0x0401654A RID: 91466
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache4C;

	// Token: 0x0401654B RID: 91467
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache4D;

	// Token: 0x0401654C RID: 91468
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache4E;

	// Token: 0x0401654D RID: 91469
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache4F;

	// Token: 0x0401654E RID: 91470
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache50;

	// Token: 0x0401654F RID: 91471
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache51;

	// Token: 0x04016550 RID: 91472
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache52;

	// Token: 0x04016551 RID: 91473
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache53;

	// Token: 0x04016552 RID: 91474
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache54;

	// Token: 0x04016553 RID: 91475
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache55;

	// Token: 0x04016554 RID: 91476
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache56;

	// Token: 0x04016555 RID: 91477
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache57;

	// Token: 0x04016556 RID: 91478
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache58;

	// Token: 0x04016557 RID: 91479
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache59;

	// Token: 0x04016558 RID: 91480
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache5A;

	// Token: 0x04016559 RID: 91481
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache5B;

	// Token: 0x0401655A RID: 91482
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache5C;
}
