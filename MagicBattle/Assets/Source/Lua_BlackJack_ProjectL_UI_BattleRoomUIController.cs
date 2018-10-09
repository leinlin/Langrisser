using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using BlackJack.BJFramework.Runtime.Prefab;
using BlackJack.BJFramework.Runtime.UI;
using BlackJack.ProjectL.Common;
using BlackJack.ProjectL.PlayerContext;
using BlackJack.ProjectL.UI;
using BlackJack.ProjectLBasic;
using SLua;
using UnityEngine;
using UnityEngine.Scripting;
using UnityEngine.UI;

// Token: 0x020013C1 RID: 5057
[Preserve]
public class Lua_BlackJack_ProjectL_UI_BattleRoomUIController : LuaObject
{
	// Token: 0x0601BF05 RID: 114437 RVA: 0x00891900 File Offset: 0x0088FB00
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int StartBattle(IntPtr l)
	{
		int result;
		try
		{
			BattleRoomUIController battleRoomUIController = (BattleRoomUIController)LuaObject.checkSelf(l);
			battleRoomUIController.StartBattle();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601BF06 RID: 114438 RVA: 0x0089194C File Offset: 0x0088FB4C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int AddPlayers(IntPtr l)
	{
		int result;
		try
		{
			BattleRoomUIController battleRoomUIController = (BattleRoomUIController)LuaObject.checkSelf(l);
			BattleRoom battleRoom;
			LuaObject.checkType<BattleRoom>(l, 2, out battleRoom);
			battleRoomUIController.AddPlayers(battleRoom);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601BF07 RID: 114439 RVA: 0x008919A4 File Offset: 0x0088FBA4
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int SetPlayerStatus(IntPtr l)
	{
		int result;
		try
		{
			BattleRoomUIController battleRoomUIController = (BattleRoomUIController)LuaObject.checkSelf(l);
			int playerIndex;
			LuaObject.checkType(l, 2, out playerIndex);
			PlayerBattleStatus status;
			LuaObject.checkEnum<PlayerBattleStatus>(l, 3, out status);
			bool isOffline;
			LuaObject.checkType(l, 4, out isOffline);
			battleRoomUIController.SetPlayerStatus(playerIndex, status, isOffline);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601BF08 RID: 114440 RVA: 0x00891A18 File Offset: 0x0088FC18
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int SetPlayerAction(IntPtr l)
	{
		int result;
		try
		{
			BattleRoomUIController battleRoomUIController = (BattleRoomUIController)LuaObject.checkSelf(l);
			int playerIndex;
			LuaObject.checkType(l, 2, out playerIndex);
			bool isAction;
			LuaObject.checkType(l, 3, out isAction);
			battleRoomUIController.SetPlayerAction(playerIndex, isAction);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601BF09 RID: 114441 RVA: 0x00891A7C File Offset: 0x0088FC7C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int SetPlayerHeroAlive(IntPtr l)
	{
		int result;
		try
		{
			BattleRoomUIController battleRoomUIController = (BattleRoomUIController)LuaObject.checkSelf(l);
			int playerIndex;
			LuaObject.checkType(l, 2, out playerIndex);
			int heroIndex;
			LuaObject.checkType(l, 3, out heroIndex);
			bool isAlive;
			LuaObject.checkType(l, 4, out isAlive);
			battleRoomUIController.SetPlayerHeroAlive(playerIndex, heroIndex, isAlive);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601BF0A RID: 114442 RVA: 0x00891AF0 File Offset: 0x0088FCF0
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int ShowPlayerChat(IntPtr l)
	{
		int result;
		try
		{
			BattleRoomUIController battleRoomUIController = (BattleRoomUIController)LuaObject.checkSelf(l);
			int playerIndex;
			LuaObject.checkType(l, 2, out playerIndex);
			string text;
			LuaObject.checkType(l, 3, out text);
			battleRoomUIController.ShowPlayerChat(playerIndex, text);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601BF0B RID: 114443 RVA: 0x00891B54 File Offset: 0x0088FD54
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int ShowPlayerExpression(IntPtr l)
	{
		int result;
		try
		{
			BattleRoomUIController battleRoomUIController = (BattleRoomUIController)LuaObject.checkSelf(l);
			int playerIndex;
			LuaObject.checkType(l, 2, out playerIndex);
			int id;
			LuaObject.checkType(l, 3, out id);
			battleRoomUIController.ShowPlayerExpression(playerIndex, id);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601BF0C RID: 114444 RVA: 0x00891BB8 File Offset: 0x0088FDB8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int ShowPlayerVoice(IntPtr l)
	{
		int result;
		try
		{
			BattleRoomUIController battleRoomUIController = (BattleRoomUIController)LuaObject.checkSelf(l);
			int playerIndex;
			LuaObject.checkType(l, 2, out playerIndex);
			ChatVoiceMessage voiceMessage;
			LuaObject.checkType<ChatVoiceMessage>(l, 3, out voiceMessage);
			battleRoomUIController.ShowPlayerVoice(playerIndex, voiceMessage);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601BF0D RID: 114445 RVA: 0x00891C1C File Offset: 0x0088FE1C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int SetOtherActionAsTeammate(IntPtr l)
	{
		int result;
		try
		{
			BattleRoomUIController battleRoomUIController = (BattleRoomUIController)LuaObject.checkSelf(l);
			int otherActionAsTeammate;
			LuaObject.checkType(l, 2, out otherActionAsTeammate);
			battleRoomUIController.SetOtherActionAsTeammate(otherActionAsTeammate);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601BF0E RID: 114446 RVA: 0x00891C74 File Offset: 0x0088FE74
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int SetOtherActionAsEnemy(IntPtr l)
	{
		int result;
		try
		{
			BattleRoomUIController battleRoomUIController = (BattleRoomUIController)LuaObject.checkSelf(l);
			battleRoomUIController.SetOtherActionAsEnemy();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601BF0F RID: 114447 RVA: 0x00891CC0 File Offset: 0x0088FEC0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int ShowOtherActionCountdown(IntPtr l)
	{
		int result;
		try
		{
			BattleRoomUIController battleRoomUIController = (BattleRoomUIController)LuaObject.checkSelf(l);
			battleRoomUIController.ShowOtherActionCountdown();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601BF10 RID: 114448 RVA: 0x00891D0C File Offset: 0x0088FF0C
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int HideOtherActionCountdown(IntPtr l)
	{
		int result;
		try
		{
			BattleRoomUIController battleRoomUIController = (BattleRoomUIController)LuaObject.checkSelf(l);
			battleRoomUIController.HideOtherActionCountdown();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601BF11 RID: 114449 RVA: 0x00891D58 File Offset: 0x0088FF58
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int SetOtherActionCountdown(IntPtr l)
	{
		int result;
		try
		{
			BattleRoomUIController battleRoomUIController = (BattleRoomUIController)LuaObject.checkSelf(l);
			TimeSpan otherActionCountdown;
			LuaObject.checkValueType<TimeSpan>(l, 2, out otherActionCountdown);
			battleRoomUIController.SetOtherActionCountdown(otherActionCountdown);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601BF12 RID: 114450 RVA: 0x00891DB0 File Offset: 0x0088FFB0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int ShowMyActionCountdown(IntPtr l)
	{
		int result;
		try
		{
			BattleRoomUIController battleRoomUIController = (BattleRoomUIController)LuaObject.checkSelf(l);
			battleRoomUIController.ShowMyActionCountdown();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601BF13 RID: 114451 RVA: 0x00891DFC File Offset: 0x0088FFFC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int HideMyActionCountdown(IntPtr l)
	{
		int result;
		try
		{
			BattleRoomUIController battleRoomUIController = (BattleRoomUIController)LuaObject.checkSelf(l);
			battleRoomUIController.HideMyActionCountdown();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601BF14 RID: 114452 RVA: 0x00891E48 File Offset: 0x00890048
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int SetMyActionCountdown(IntPtr l)
	{
		int result;
		try
		{
			BattleRoomUIController battleRoomUIController = (BattleRoomUIController)LuaObject.checkSelf(l);
			TimeSpan myActionCountdown;
			LuaObject.checkValueType<TimeSpan>(l, 2, out myActionCountdown);
			battleRoomUIController.SetMyActionCountdown(myActionCountdown);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601BF15 RID: 114453 RVA: 0x00891EA0 File Offset: 0x008900A0
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int SetCanUseChat(IntPtr l)
	{
		int result;
		try
		{
			BattleRoomUIController battleRoomUIController = (BattleRoomUIController)LuaObject.checkSelf(l);
			bool canUseChat;
			LuaObject.checkType(l, 2, out canUseChat);
			battleRoomUIController.SetCanUseChat(canUseChat);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601BF16 RID: 114454 RVA: 0x00891EF8 File Offset: 0x008900F8
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int OnBindFiledsCompleted(IntPtr l)
	{
		int result;
		try
		{
			BattleRoomUIController battleRoomUIController = (BattleRoomUIController)LuaObject.checkSelf(l);
			battleRoomUIController.m_luaExportHelper.OnBindFiledsCompleted();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601BF17 RID: 114455 RVA: 0x00891F4C File Offset: 0x0089014C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int AddPlayer(IntPtr l)
	{
		int result;
		try
		{
			BattleRoomUIController battleRoomUIController = (BattleRoomUIController)LuaObject.checkSelf(l);
			BattleRoomPlayer player;
			LuaObject.checkType<BattleRoomPlayer>(l, 2, out player);
			int heroCount;
			LuaObject.checkType(l, 3, out heroCount);
			bool showPlayerIndex;
			LuaObject.checkType(l, 4, out showPlayerIndex);
			battleRoomUIController.m_luaExportHelper.AddPlayer(player, heroCount, showPlayerIndex);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601BF18 RID: 114456 RVA: 0x00891FC4 File Offset: 0x008901C4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int ClearPlayers(IntPtr l)
	{
		int result;
		try
		{
			BattleRoomUIController battleRoomUIController = (BattleRoomUIController)LuaObject.checkSelf(l);
			battleRoomUIController.m_luaExportHelper.ClearPlayers();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601BF19 RID: 114457 RVA: 0x00892018 File Offset: 0x00890218
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int GetPlayerUIController(IntPtr l)
	{
		int result;
		try
		{
			BattleRoomUIController battleRoomUIController = (BattleRoomUIController)LuaObject.checkSelf(l);
			int playerIndex;
			LuaObject.checkType(l, 2, out playerIndex);
			BattleTeamPlayerUIController playerUIController = battleRoomUIController.m_luaExportHelper.GetPlayerUIController(playerIndex);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, playerUIController);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601BF1A RID: 114458 RVA: 0x00892080 File Offset: 0x00890280
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int OnExpressionButtonClick(IntPtr l)
	{
		int result;
		try
		{
			BattleRoomUIController battleRoomUIController = (BattleRoomUIController)LuaObject.checkSelf(l);
			battleRoomUIController.m_luaExportHelper.OnExpressionButtonClick();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601BF1B RID: 114459 RVA: 0x008920D4 File Offset: 0x008902D4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int OnBigExpressionClick(IntPtr l)
	{
		int result;
		try
		{
			BattleRoomUIController battleRoomUIController = (BattleRoomUIController)LuaObject.checkSelf(l);
			int id;
			LuaObject.checkType(l, 2, out id);
			battleRoomUIController.m_luaExportHelper.OnBigExpressionClick(id);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601BF1C RID: 114460 RVA: 0x00892130 File Offset: 0x00890330
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int OnBigExpressionBGClick(IntPtr l)
	{
		int result;
		try
		{
			BattleRoomUIController battleRoomUIController = (BattleRoomUIController)LuaObject.checkSelf(l);
			battleRoomUIController.m_luaExportHelper.OnBigExpressionBGClick();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601BF1D RID: 114461 RVA: 0x00892184 File Offset: 0x00890384
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int __callBase_Initlize(IntPtr l)
	{
		int result;
		try
		{
			BattleRoomUIController battleRoomUIController = (BattleRoomUIController)LuaObject.checkSelf(l);
			string ctrlName;
			LuaObject.checkType(l, 2, out ctrlName);
			bool bindNow;
			LuaObject.checkType(l, 3, out bindNow);
			battleRoomUIController.m_luaExportHelper.__callBase_Initlize(ctrlName, bindNow);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601BF1E RID: 114462 RVA: 0x008921F0 File Offset: 0x008903F0
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int __callBase_BindFields(IntPtr l)
	{
		int result;
		try
		{
			BattleRoomUIController battleRoomUIController = (BattleRoomUIController)LuaObject.checkSelf(l);
			battleRoomUIController.m_luaExportHelper.__callBase_BindFields();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601BF1F RID: 114463 RVA: 0x00892244 File Offset: 0x00890444
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_OnBindFiledsCompleted(IntPtr l)
	{
		int result;
		try
		{
			BattleRoomUIController battleRoomUIController = (BattleRoomUIController)LuaObject.checkSelf(l);
			battleRoomUIController.m_luaExportHelper.__callBase_OnBindFiledsCompleted();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601BF20 RID: 114464 RVA: 0x00892298 File Offset: 0x00890498
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_BindFieldImpl(IntPtr l)
	{
		int result;
		try
		{
			BattleRoomUIController battleRoomUIController = (BattleRoomUIController)LuaObject.checkSelf(l);
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
			UnityEngine.Object o = battleRoomUIController.m_luaExportHelper.__callBase_BindFieldImpl(fieldType, path, initState, fieldName, ctrlName, optional);
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

	// Token: 0x0601BF21 RID: 114465 RVA: 0x00892340 File Offset: 0x00890540
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_Clear(IntPtr l)
	{
		int result;
		try
		{
			BattleRoomUIController battleRoomUIController = (BattleRoomUIController)LuaObject.checkSelf(l);
			battleRoomUIController.m_luaExportHelper.__callBase_Clear();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601BF22 RID: 114466 RVA: 0x00892394 File Offset: 0x00890594
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_OnButtonClick(IntPtr l)
	{
		int result;
		try
		{
			BattleRoomUIController battleRoomUIController = (BattleRoomUIController)LuaObject.checkSelf(l);
			Button button;
			LuaObject.checkType<Button>(l, 2, out button);
			string fieldName;
			LuaObject.checkType(l, 3, out fieldName);
			battleRoomUIController.m_luaExportHelper.__callBase_OnButtonClick(button, fieldName);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601BF23 RID: 114467 RVA: 0x00892400 File Offset: 0x00890600
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
				BattleRoomUIController battleRoomUIController = (BattleRoomUIController)LuaObject.checkSelf(l);
				string[] fieldNames;
				LuaObject.checkArray<string>(l, 2, out fieldNames);
				Action<UIControllerBase> action;
				LuaObject.checkDelegate<Action<UIControllerBase>>(l, 3, out action);
				battleRoomUIController.m_luaExportHelper.__callBase_SetButtonClickListener(fieldNames, action);
				LuaObject.pushValue(l, true);
				result = 1;
			}
			else if (LuaObject.matchType(l, total, 2, typeof(string), typeof(Action<UIControllerBase>)))
			{
				BattleRoomUIController battleRoomUIController2 = (BattleRoomUIController)LuaObject.checkSelf(l);
				string fieldName;
				LuaObject.checkType(l, 2, out fieldName);
				Action<UIControllerBase> action2;
				LuaObject.checkDelegate<Action<UIControllerBase>>(l, 3, out action2);
				battleRoomUIController2.m_luaExportHelper.__callBase_SetButtonClickListener(fieldName, action2);
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

	// Token: 0x0601BF24 RID: 114468 RVA: 0x00892510 File Offset: 0x00890710
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_SetButtonDoubleClickListener(IntPtr l)
	{
		int result;
		try
		{
			BattleRoomUIController battleRoomUIController = (BattleRoomUIController)LuaObject.checkSelf(l);
			string fieldName;
			LuaObject.checkType(l, 2, out fieldName);
			Action<UIControllerBase> action;
			LuaObject.checkDelegate<Action<UIControllerBase>>(l, 3, out action);
			battleRoomUIController.m_luaExportHelper.__callBase_SetButtonDoubleClickListener(fieldName, action);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601BF25 RID: 114469 RVA: 0x0089257C File Offset: 0x0089077C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_SetButtonLongPressStartListener(IntPtr l)
	{
		int result;
		try
		{
			BattleRoomUIController battleRoomUIController = (BattleRoomUIController)LuaObject.checkSelf(l);
			string fieldName;
			LuaObject.checkType(l, 2, out fieldName);
			Action<UIControllerBase> action;
			LuaObject.checkDelegate<Action<UIControllerBase>>(l, 3, out action);
			battleRoomUIController.m_luaExportHelper.__callBase_SetButtonLongPressStartListener(fieldName, action);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601BF26 RID: 114470 RVA: 0x008925E8 File Offset: 0x008907E8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_SetButtonLongPressingListener(IntPtr l)
	{
		int result;
		try
		{
			BattleRoomUIController battleRoomUIController = (BattleRoomUIController)LuaObject.checkSelf(l);
			string fieldName;
			LuaObject.checkType(l, 2, out fieldName);
			Action<UIControllerBase> action;
			LuaObject.checkDelegate<Action<UIControllerBase>>(l, 3, out action);
			battleRoomUIController.m_luaExportHelper.__callBase_SetButtonLongPressingListener(fieldName, action);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601BF27 RID: 114471 RVA: 0x00892654 File Offset: 0x00890854
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_SetButtonLongPressEndListener(IntPtr l)
	{
		int result;
		try
		{
			BattleRoomUIController battleRoomUIController = (BattleRoomUIController)LuaObject.checkSelf(l);
			string fieldName;
			LuaObject.checkType(l, 2, out fieldName);
			Action<UIControllerBase> action;
			LuaObject.checkDelegate<Action<UIControllerBase>>(l, 3, out action);
			battleRoomUIController.m_luaExportHelper.__callBase_SetButtonLongPressEndListener(fieldName, action);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601BF28 RID: 114472 RVA: 0x008926C0 File Offset: 0x008908C0
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
				BattleRoomUIController battleRoomUIController = (BattleRoomUIController)LuaObject.checkSelf(l);
				string[] fieldNames;
				LuaObject.checkArray<string>(l, 2, out fieldNames);
				Action<UIControllerBase, bool> action;
				LuaObject.checkDelegate<Action<UIControllerBase, bool>>(l, 3, out action);
				battleRoomUIController.m_luaExportHelper.__callBase_SetToggleValueChangedListener(fieldNames, action);
				LuaObject.pushValue(l, true);
				result = 1;
			}
			else if (LuaObject.matchType(l, total, 2, typeof(string), typeof(Action<UIControllerBase, bool>)))
			{
				BattleRoomUIController battleRoomUIController2 = (BattleRoomUIController)LuaObject.checkSelf(l);
				string fieldName;
				LuaObject.checkType(l, 2, out fieldName);
				Action<UIControllerBase, bool> action2;
				LuaObject.checkDelegate<Action<UIControllerBase, bool>>(l, 3, out action2);
				battleRoomUIController2.m_luaExportHelper.__callBase_SetToggleValueChangedListener(fieldName, action2);
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

	// Token: 0x0601BF29 RID: 114473 RVA: 0x008927D0 File Offset: 0x008909D0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_ToString(IntPtr l)
	{
		int result;
		try
		{
			BattleRoomUIController battleRoomUIController = (BattleRoomUIController)LuaObject.checkSelf(l);
			string s = battleRoomUIController.m_luaExportHelper.__callBase_ToString();
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

	// Token: 0x0601BF2A RID: 114474 RVA: 0x0089282C File Offset: 0x00890A2C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_marginTransform(IntPtr l)
	{
		int result;
		try
		{
			BattleRoomUIController battleRoomUIController = (BattleRoomUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, battleRoomUIController.m_luaExportHelper.m_marginTransform);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601BF2B RID: 114475 RVA: 0x00892884 File Offset: 0x00890A84
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_m_marginTransform(IntPtr l)
	{
		int result;
		try
		{
			BattleRoomUIController battleRoomUIController = (BattleRoomUIController)LuaObject.checkSelf(l);
			RectTransform marginTransform;
			LuaObject.checkType<RectTransform>(l, 2, out marginTransform);
			battleRoomUIController.m_luaExportHelper.m_marginTransform = marginTransform;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601BF2C RID: 114476 RVA: 0x008928E0 File Offset: 0x00890AE0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_playerGroupGameObject(IntPtr l)
	{
		int result;
		try
		{
			BattleRoomUIController battleRoomUIController = (BattleRoomUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, battleRoomUIController.m_luaExportHelper.m_playerGroupGameObject);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601BF2D RID: 114477 RVA: 0x00892938 File Offset: 0x00890B38
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_playerGroupGameObject(IntPtr l)
	{
		int result;
		try
		{
			BattleRoomUIController battleRoomUIController = (BattleRoomUIController)LuaObject.checkSelf(l);
			GameObject playerGroupGameObject;
			LuaObject.checkType<GameObject>(l, 2, out playerGroupGameObject);
			battleRoomUIController.m_luaExportHelper.m_playerGroupGameObject = playerGroupGameObject;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601BF2E RID: 114478 RVA: 0x00892994 File Offset: 0x00890B94
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_chatEmptyGameObject(IntPtr l)
	{
		int result;
		try
		{
			BattleRoomUIController battleRoomUIController = (BattleRoomUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, battleRoomUIController.m_luaExportHelper.m_chatEmptyGameObject);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601BF2F RID: 114479 RVA: 0x008929EC File Offset: 0x00890BEC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_chatEmptyGameObject(IntPtr l)
	{
		int result;
		try
		{
			BattleRoomUIController battleRoomUIController = (BattleRoomUIController)LuaObject.checkSelf(l);
			GameObject chatEmptyGameObject;
			LuaObject.checkType<GameObject>(l, 2, out chatEmptyGameObject);
			battleRoomUIController.m_luaExportHelper.m_chatEmptyGameObject = chatEmptyGameObject;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601BF30 RID: 114480 RVA: 0x00892A48 File Offset: 0x00890C48
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_m_expressionButton(IntPtr l)
	{
		int result;
		try
		{
			BattleRoomUIController battleRoomUIController = (BattleRoomUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, battleRoomUIController.m_luaExportHelper.m_expressionButton);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601BF31 RID: 114481 RVA: 0x00892AA0 File Offset: 0x00890CA0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_expressionButton(IntPtr l)
	{
		int result;
		try
		{
			BattleRoomUIController battleRoomUIController = (BattleRoomUIController)LuaObject.checkSelf(l);
			ButtonEx expressionButton;
			LuaObject.checkType<ButtonEx>(l, 2, out expressionButton);
			battleRoomUIController.m_luaExportHelper.m_expressionButton = expressionButton;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601BF32 RID: 114482 RVA: 0x00892AFC File Offset: 0x00890CFC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_TalkButton(IntPtr l)
	{
		int result;
		try
		{
			BattleRoomUIController battleRoomUIController = (BattleRoomUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, battleRoomUIController.TalkButton);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601BF33 RID: 114483 RVA: 0x00892B50 File Offset: 0x00890D50
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_TalkButton(IntPtr l)
	{
		int result;
		try
		{
			BattleRoomUIController battleRoomUIController = (BattleRoomUIController)LuaObject.checkSelf(l);
			Button talkButton;
			LuaObject.checkType<Button>(l, 2, out talkButton);
			battleRoomUIController.TalkButton = talkButton;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601BF34 RID: 114484 RVA: 0x00892BA8 File Offset: 0x00890DA8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_expressionGroup(IntPtr l)
	{
		int result;
		try
		{
			BattleRoomUIController battleRoomUIController = (BattleRoomUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, battleRoomUIController.m_luaExportHelper.m_expressionGroup);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601BF35 RID: 114485 RVA: 0x00892C00 File Offset: 0x00890E00
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_expressionGroup(IntPtr l)
	{
		int result;
		try
		{
			BattleRoomUIController battleRoomUIController = (BattleRoomUIController)LuaObject.checkSelf(l);
			GameObject expressionGroup;
			LuaObject.checkType<GameObject>(l, 2, out expressionGroup);
			battleRoomUIController.m_luaExportHelper.m_expressionGroup = expressionGroup;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601BF36 RID: 114486 RVA: 0x00892C5C File Offset: 0x00890E5C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_ButtonBGMask(IntPtr l)
	{
		int result;
		try
		{
			BattleRoomUIController battleRoomUIController = (BattleRoomUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, battleRoomUIController.m_luaExportHelper.ButtonBGMask);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601BF37 RID: 114487 RVA: 0x00892CB4 File Offset: 0x00890EB4
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_ButtonBGMask(IntPtr l)
	{
		int result;
		try
		{
			BattleRoomUIController battleRoomUIController = (BattleRoomUIController)LuaObject.checkSelf(l);
			ButtonEx buttonBGMask;
			LuaObject.checkType<ButtonEx>(l, 2, out buttonBGMask);
			battleRoomUIController.m_luaExportHelper.ButtonBGMask = buttonBGMask;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601BF38 RID: 114488 RVA: 0x00892D10 File Offset: 0x00890F10
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_m_timeGameObject(IntPtr l)
	{
		int result;
		try
		{
			BattleRoomUIController battleRoomUIController = (BattleRoomUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, battleRoomUIController.m_luaExportHelper.m_timeGameObject);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601BF39 RID: 114489 RVA: 0x00892D68 File Offset: 0x00890F68
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_timeGameObject(IntPtr l)
	{
		int result;
		try
		{
			BattleRoomUIController battleRoomUIController = (BattleRoomUIController)LuaObject.checkSelf(l);
			GameObject timeGameObject;
			LuaObject.checkType<GameObject>(l, 2, out timeGameObject);
			battleRoomUIController.m_luaExportHelper.m_timeGameObject = timeGameObject;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601BF3A RID: 114490 RVA: 0x00892DC4 File Offset: 0x00890FC4
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_m_timeText(IntPtr l)
	{
		int result;
		try
		{
			BattleRoomUIController battleRoomUIController = (BattleRoomUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, battleRoomUIController.m_luaExportHelper.m_timeText);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601BF3B RID: 114491 RVA: 0x00892E1C File Offset: 0x0089101C
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_m_timeText(IntPtr l)
	{
		int result;
		try
		{
			BattleRoomUIController battleRoomUIController = (BattleRoomUIController)LuaObject.checkSelf(l);
			Text timeText;
			LuaObject.checkType<Text>(l, 2, out timeText);
			battleRoomUIController.m_luaExportHelper.m_timeText = timeText;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601BF3C RID: 114492 RVA: 0x00892E78 File Offset: 0x00891078
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_m_bigTimeUIStateController(IntPtr l)
	{
		int result;
		try
		{
			BattleRoomUIController battleRoomUIController = (BattleRoomUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, battleRoomUIController.m_luaExportHelper.m_bigTimeUIStateController);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601BF3D RID: 114493 RVA: 0x00892ED0 File Offset: 0x008910D0
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_m_bigTimeUIStateController(IntPtr l)
	{
		int result;
		try
		{
			BattleRoomUIController battleRoomUIController = (BattleRoomUIController)LuaObject.checkSelf(l);
			CommonUIStateController bigTimeUIStateController;
			LuaObject.checkType<CommonUIStateController>(l, 2, out bigTimeUIStateController);
			battleRoomUIController.m_luaExportHelper.m_bigTimeUIStateController = bigTimeUIStateController;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601BF3E RID: 114494 RVA: 0x00892F2C File Offset: 0x0089112C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_bigTimeText(IntPtr l)
	{
		int result;
		try
		{
			BattleRoomUIController battleRoomUIController = (BattleRoomUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, battleRoomUIController.m_luaExportHelper.m_bigTimeText);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601BF3F RID: 114495 RVA: 0x00892F84 File Offset: 0x00891184
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_bigTimeText(IntPtr l)
	{
		int result;
		try
		{
			BattleRoomUIController battleRoomUIController = (BattleRoomUIController)LuaObject.checkSelf(l);
			Text bigTimeText;
			LuaObject.checkType<Text>(l, 2, out bigTimeText);
			battleRoomUIController.m_luaExportHelper.m_bigTimeText = bigTimeText;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601BF40 RID: 114496 RVA: 0x00892FE0 File Offset: 0x008911E0
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_m_actionPlayerUIStateController(IntPtr l)
	{
		int result;
		try
		{
			BattleRoomUIController battleRoomUIController = (BattleRoomUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, battleRoomUIController.m_luaExportHelper.m_actionPlayerUIStateController);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601BF41 RID: 114497 RVA: 0x00893038 File Offset: 0x00891238
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_actionPlayerUIStateController(IntPtr l)
	{
		int result;
		try
		{
			BattleRoomUIController battleRoomUIController = (BattleRoomUIController)LuaObject.checkSelf(l);
			CommonUIStateController actionPlayerUIStateController;
			LuaObject.checkType<CommonUIStateController>(l, 2, out actionPlayerUIStateController);
			battleRoomUIController.m_luaExportHelper.m_actionPlayerUIStateController = actionPlayerUIStateController;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601BF42 RID: 114498 RVA: 0x00893094 File Offset: 0x00891294
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_actionPlayerEnemyUIStateController(IntPtr l)
	{
		int result;
		try
		{
			BattleRoomUIController battleRoomUIController = (BattleRoomUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, battleRoomUIController.m_luaExportHelper.m_actionPlayerEnemyUIStateController);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601BF43 RID: 114499 RVA: 0x008930EC File Offset: 0x008912EC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_actionPlayerEnemyUIStateController(IntPtr l)
	{
		int result;
		try
		{
			BattleRoomUIController battleRoomUIController = (BattleRoomUIController)LuaObject.checkSelf(l);
			CommonUIStateController actionPlayerEnemyUIStateController;
			LuaObject.checkType<CommonUIStateController>(l, 2, out actionPlayerEnemyUIStateController);
			battleRoomUIController.m_luaExportHelper.m_actionPlayerEnemyUIStateController = actionPlayerEnemyUIStateController;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601BF44 RID: 114500 RVA: 0x00893148 File Offset: 0x00891348
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_actionPlayerTagImage(IntPtr l)
	{
		int result;
		try
		{
			BattleRoomUIController battleRoomUIController = (BattleRoomUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, battleRoomUIController.m_luaExportHelper.m_actionPlayerTagImage);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601BF45 RID: 114501 RVA: 0x008931A0 File Offset: 0x008913A0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_actionPlayerTagImage(IntPtr l)
	{
		int result;
		try
		{
			BattleRoomUIController battleRoomUIController = (BattleRoomUIController)LuaObject.checkSelf(l);
			Image actionPlayerTagImage;
			LuaObject.checkType<Image>(l, 2, out actionPlayerTagImage);
			battleRoomUIController.m_luaExportHelper.m_actionPlayerTagImage = actionPlayerTagImage;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601BF46 RID: 114502 RVA: 0x008931FC File Offset: 0x008913FC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_actionPlayerTimeText(IntPtr l)
	{
		int result;
		try
		{
			BattleRoomUIController battleRoomUIController = (BattleRoomUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, battleRoomUIController.m_luaExportHelper.m_actionPlayerTimeText);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601BF47 RID: 114503 RVA: 0x00893254 File Offset: 0x00891454
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_actionPlayerTimeText(IntPtr l)
	{
		int result;
		try
		{
			BattleRoomUIController battleRoomUIController = (BattleRoomUIController)LuaObject.checkSelf(l);
			Text actionPlayerTimeText;
			LuaObject.checkType<Text>(l, 2, out actionPlayerTimeText);
			battleRoomUIController.m_luaExportHelper.m_actionPlayerTimeText = actionPlayerTimeText;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601BF48 RID: 114504 RVA: 0x008932B0 File Offset: 0x008914B0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_prefabsGameObject(IntPtr l)
	{
		int result;
		try
		{
			BattleRoomUIController battleRoomUIController = (BattleRoomUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, battleRoomUIController.m_luaExportHelper.m_prefabsGameObject);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601BF49 RID: 114505 RVA: 0x00893308 File Offset: 0x00891508
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_prefabsGameObject(IntPtr l)
	{
		int result;
		try
		{
			BattleRoomUIController battleRoomUIController = (BattleRoomUIController)LuaObject.checkSelf(l);
			GameObject prefabsGameObject;
			LuaObject.checkType<GameObject>(l, 2, out prefabsGameObject);
			battleRoomUIController.m_luaExportHelper.m_prefabsGameObject = prefabsGameObject;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601BF4A RID: 114506 RVA: 0x00893364 File Offset: 0x00891564
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_battleTeamPlayerPrefab(IntPtr l)
	{
		int result;
		try
		{
			BattleRoomUIController battleRoomUIController = (BattleRoomUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, battleRoomUIController.m_luaExportHelper.m_battleTeamPlayerPrefab);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601BF4B RID: 114507 RVA: 0x008933BC File Offset: 0x008915BC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_battleTeamPlayerPrefab(IntPtr l)
	{
		int result;
		try
		{
			BattleRoomUIController battleRoomUIController = (BattleRoomUIController)LuaObject.checkSelf(l);
			GameObject battleTeamPlayerPrefab;
			LuaObject.checkType<GameObject>(l, 2, out battleTeamPlayerPrefab);
			battleRoomUIController.m_luaExportHelper.m_battleTeamPlayerPrefab = battleTeamPlayerPrefab;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601BF4C RID: 114508 RVA: 0x00893418 File Offset: 0x00891618
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_expressionParseDesc(IntPtr l)
	{
		int result;
		try
		{
			BattleRoomUIController battleRoomUIController = (BattleRoomUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, battleRoomUIController.m_luaExportHelper.m_expressionParseDesc);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601BF4D RID: 114509 RVA: 0x00893470 File Offset: 0x00891670
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_expressionParseDesc(IntPtr l)
	{
		int result;
		try
		{
			BattleRoomUIController battleRoomUIController = (BattleRoomUIController)LuaObject.checkSelf(l);
			SmallExpressionParseDesc expressionParseDesc;
			LuaObject.checkType<SmallExpressionParseDesc>(l, 2, out expressionParseDesc);
			battleRoomUIController.m_luaExportHelper.m_expressionParseDesc = expressionParseDesc;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601BF4E RID: 114510 RVA: 0x008934CC File Offset: 0x008916CC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_expressionResContainer(IntPtr l)
	{
		int result;
		try
		{
			BattleRoomUIController battleRoomUIController = (BattleRoomUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, battleRoomUIController.m_luaExportHelper.m_expressionResContainer);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601BF4F RID: 114511 RVA: 0x00893524 File Offset: 0x00891724
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_expressionResContainer(IntPtr l)
	{
		int result;
		try
		{
			BattleRoomUIController battleRoomUIController = (BattleRoomUIController)LuaObject.checkSelf(l);
			PrefabResourceContainer expressionResContainer;
			LuaObject.checkType<PrefabResourceContainer>(l, 2, out expressionResContainer);
			battleRoomUIController.m_luaExportHelper.m_expressionResContainer = expressionResContainer;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601BF50 RID: 114512 RVA: 0x00893580 File Offset: 0x00891780
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_players(IntPtr l)
	{
		int result;
		try
		{
			BattleRoomUIController battleRoomUIController = (BattleRoomUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, battleRoomUIController.m_luaExportHelper.m_players);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601BF51 RID: 114513 RVA: 0x008935D8 File Offset: 0x008917D8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_players(IntPtr l)
	{
		int result;
		try
		{
			BattleRoomUIController battleRoomUIController = (BattleRoomUIController)LuaObject.checkSelf(l);
			List<BattleTeamPlayerUIController> players;
			LuaObject.checkType<List<BattleTeamPlayerUIController>>(l, 2, out players);
			battleRoomUIController.m_luaExportHelper.m_players = players;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601BF52 RID: 114514 RVA: 0x00893634 File Offset: 0x00891834
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_bigExpressionCtrl(IntPtr l)
	{
		int result;
		try
		{
			BattleRoomUIController battleRoomUIController = (BattleRoomUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, battleRoomUIController.m_luaExportHelper.m_bigExpressionCtrl);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601BF53 RID: 114515 RVA: 0x0089368C File Offset: 0x0089188C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_bigExpressionCtrl(IntPtr l)
	{
		int result;
		try
		{
			BattleRoomUIController battleRoomUIController = (BattleRoomUIController)LuaObject.checkSelf(l);
			BigExpressionController bigExpressionCtrl;
			LuaObject.checkType<BigExpressionController>(l, 2, out bigExpressionCtrl);
			battleRoomUIController.m_luaExportHelper.m_bigExpressionCtrl = bigExpressionCtrl;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601BF54 RID: 114516 RVA: 0x008936E8 File Offset: 0x008918E8
	[Preserve]
	public static void reg(IntPtr l)
	{
		LuaObject.getTypeTable(l, "BlackJack.ProjectL.UI.BattleRoomUIController");
		if (Lua_BlackJack_ProjectL_UI_BattleRoomUIController.<>f__mg$cache0 == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleRoomUIController.<>f__mg$cache0 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleRoomUIController.StartBattle);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_BattleRoomUIController.<>f__mg$cache0);
		if (Lua_BlackJack_ProjectL_UI_BattleRoomUIController.<>f__mg$cache1 == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleRoomUIController.<>f__mg$cache1 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleRoomUIController.AddPlayers);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_BattleRoomUIController.<>f__mg$cache1);
		if (Lua_BlackJack_ProjectL_UI_BattleRoomUIController.<>f__mg$cache2 == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleRoomUIController.<>f__mg$cache2 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleRoomUIController.SetPlayerStatus);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_BattleRoomUIController.<>f__mg$cache2);
		if (Lua_BlackJack_ProjectL_UI_BattleRoomUIController.<>f__mg$cache3 == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleRoomUIController.<>f__mg$cache3 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleRoomUIController.SetPlayerAction);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_BattleRoomUIController.<>f__mg$cache3);
		if (Lua_BlackJack_ProjectL_UI_BattleRoomUIController.<>f__mg$cache4 == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleRoomUIController.<>f__mg$cache4 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleRoomUIController.SetPlayerHeroAlive);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_BattleRoomUIController.<>f__mg$cache4);
		if (Lua_BlackJack_ProjectL_UI_BattleRoomUIController.<>f__mg$cache5 == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleRoomUIController.<>f__mg$cache5 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleRoomUIController.ShowPlayerChat);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_BattleRoomUIController.<>f__mg$cache5);
		if (Lua_BlackJack_ProjectL_UI_BattleRoomUIController.<>f__mg$cache6 == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleRoomUIController.<>f__mg$cache6 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleRoomUIController.ShowPlayerExpression);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_BattleRoomUIController.<>f__mg$cache6);
		if (Lua_BlackJack_ProjectL_UI_BattleRoomUIController.<>f__mg$cache7 == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleRoomUIController.<>f__mg$cache7 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleRoomUIController.ShowPlayerVoice);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_BattleRoomUIController.<>f__mg$cache7);
		if (Lua_BlackJack_ProjectL_UI_BattleRoomUIController.<>f__mg$cache8 == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleRoomUIController.<>f__mg$cache8 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleRoomUIController.SetOtherActionAsTeammate);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_BattleRoomUIController.<>f__mg$cache8);
		if (Lua_BlackJack_ProjectL_UI_BattleRoomUIController.<>f__mg$cache9 == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleRoomUIController.<>f__mg$cache9 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleRoomUIController.SetOtherActionAsEnemy);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_BattleRoomUIController.<>f__mg$cache9);
		if (Lua_BlackJack_ProjectL_UI_BattleRoomUIController.<>f__mg$cacheA == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleRoomUIController.<>f__mg$cacheA = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleRoomUIController.ShowOtherActionCountdown);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_BattleRoomUIController.<>f__mg$cacheA);
		if (Lua_BlackJack_ProjectL_UI_BattleRoomUIController.<>f__mg$cacheB == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleRoomUIController.<>f__mg$cacheB = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleRoomUIController.HideOtherActionCountdown);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_BattleRoomUIController.<>f__mg$cacheB);
		if (Lua_BlackJack_ProjectL_UI_BattleRoomUIController.<>f__mg$cacheC == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleRoomUIController.<>f__mg$cacheC = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleRoomUIController.SetOtherActionCountdown);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_BattleRoomUIController.<>f__mg$cacheC);
		if (Lua_BlackJack_ProjectL_UI_BattleRoomUIController.<>f__mg$cacheD == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleRoomUIController.<>f__mg$cacheD = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleRoomUIController.ShowMyActionCountdown);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_BattleRoomUIController.<>f__mg$cacheD);
		if (Lua_BlackJack_ProjectL_UI_BattleRoomUIController.<>f__mg$cacheE == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleRoomUIController.<>f__mg$cacheE = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleRoomUIController.HideMyActionCountdown);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_BattleRoomUIController.<>f__mg$cacheE);
		if (Lua_BlackJack_ProjectL_UI_BattleRoomUIController.<>f__mg$cacheF == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleRoomUIController.<>f__mg$cacheF = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleRoomUIController.SetMyActionCountdown);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_BattleRoomUIController.<>f__mg$cacheF);
		if (Lua_BlackJack_ProjectL_UI_BattleRoomUIController.<>f__mg$cache10 == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleRoomUIController.<>f__mg$cache10 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleRoomUIController.SetCanUseChat);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_BattleRoomUIController.<>f__mg$cache10);
		if (Lua_BlackJack_ProjectL_UI_BattleRoomUIController.<>f__mg$cache11 == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleRoomUIController.<>f__mg$cache11 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleRoomUIController.OnBindFiledsCompleted);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_BattleRoomUIController.<>f__mg$cache11);
		if (Lua_BlackJack_ProjectL_UI_BattleRoomUIController.<>f__mg$cache12 == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleRoomUIController.<>f__mg$cache12 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleRoomUIController.AddPlayer);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_BattleRoomUIController.<>f__mg$cache12);
		if (Lua_BlackJack_ProjectL_UI_BattleRoomUIController.<>f__mg$cache13 == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleRoomUIController.<>f__mg$cache13 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleRoomUIController.ClearPlayers);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_BattleRoomUIController.<>f__mg$cache13);
		if (Lua_BlackJack_ProjectL_UI_BattleRoomUIController.<>f__mg$cache14 == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleRoomUIController.<>f__mg$cache14 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleRoomUIController.GetPlayerUIController);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_BattleRoomUIController.<>f__mg$cache14);
		if (Lua_BlackJack_ProjectL_UI_BattleRoomUIController.<>f__mg$cache15 == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleRoomUIController.<>f__mg$cache15 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleRoomUIController.OnExpressionButtonClick);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_BattleRoomUIController.<>f__mg$cache15);
		if (Lua_BlackJack_ProjectL_UI_BattleRoomUIController.<>f__mg$cache16 == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleRoomUIController.<>f__mg$cache16 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleRoomUIController.OnBigExpressionClick);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_BattleRoomUIController.<>f__mg$cache16);
		if (Lua_BlackJack_ProjectL_UI_BattleRoomUIController.<>f__mg$cache17 == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleRoomUIController.<>f__mg$cache17 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleRoomUIController.OnBigExpressionBGClick);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_BattleRoomUIController.<>f__mg$cache17);
		if (Lua_BlackJack_ProjectL_UI_BattleRoomUIController.<>f__mg$cache18 == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleRoomUIController.<>f__mg$cache18 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleRoomUIController.__callBase_Initlize);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_BattleRoomUIController.<>f__mg$cache18);
		if (Lua_BlackJack_ProjectL_UI_BattleRoomUIController.<>f__mg$cache19 == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleRoomUIController.<>f__mg$cache19 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleRoomUIController.__callBase_BindFields);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_BattleRoomUIController.<>f__mg$cache19);
		if (Lua_BlackJack_ProjectL_UI_BattleRoomUIController.<>f__mg$cache1A == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleRoomUIController.<>f__mg$cache1A = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleRoomUIController.__callBase_OnBindFiledsCompleted);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_BattleRoomUIController.<>f__mg$cache1A);
		if (Lua_BlackJack_ProjectL_UI_BattleRoomUIController.<>f__mg$cache1B == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleRoomUIController.<>f__mg$cache1B = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleRoomUIController.__callBase_BindFieldImpl);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_BattleRoomUIController.<>f__mg$cache1B);
		if (Lua_BlackJack_ProjectL_UI_BattleRoomUIController.<>f__mg$cache1C == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleRoomUIController.<>f__mg$cache1C = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleRoomUIController.__callBase_Clear);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_BattleRoomUIController.<>f__mg$cache1C);
		if (Lua_BlackJack_ProjectL_UI_BattleRoomUIController.<>f__mg$cache1D == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleRoomUIController.<>f__mg$cache1D = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleRoomUIController.__callBase_OnButtonClick);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_BattleRoomUIController.<>f__mg$cache1D);
		if (Lua_BlackJack_ProjectL_UI_BattleRoomUIController.<>f__mg$cache1E == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleRoomUIController.<>f__mg$cache1E = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleRoomUIController.__callBase_SetButtonClickListener);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_BattleRoomUIController.<>f__mg$cache1E);
		if (Lua_BlackJack_ProjectL_UI_BattleRoomUIController.<>f__mg$cache1F == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleRoomUIController.<>f__mg$cache1F = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleRoomUIController.__callBase_SetButtonDoubleClickListener);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_BattleRoomUIController.<>f__mg$cache1F);
		if (Lua_BlackJack_ProjectL_UI_BattleRoomUIController.<>f__mg$cache20 == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleRoomUIController.<>f__mg$cache20 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleRoomUIController.__callBase_SetButtonLongPressStartListener);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_BattleRoomUIController.<>f__mg$cache20);
		if (Lua_BlackJack_ProjectL_UI_BattleRoomUIController.<>f__mg$cache21 == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleRoomUIController.<>f__mg$cache21 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleRoomUIController.__callBase_SetButtonLongPressingListener);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_BattleRoomUIController.<>f__mg$cache21);
		if (Lua_BlackJack_ProjectL_UI_BattleRoomUIController.<>f__mg$cache22 == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleRoomUIController.<>f__mg$cache22 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleRoomUIController.__callBase_SetButtonLongPressEndListener);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_BattleRoomUIController.<>f__mg$cache22);
		if (Lua_BlackJack_ProjectL_UI_BattleRoomUIController.<>f__mg$cache23 == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleRoomUIController.<>f__mg$cache23 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleRoomUIController.__callBase_SetToggleValueChangedListener);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_BattleRoomUIController.<>f__mg$cache23);
		if (Lua_BlackJack_ProjectL_UI_BattleRoomUIController.<>f__mg$cache24 == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleRoomUIController.<>f__mg$cache24 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleRoomUIController.__callBase_ToString);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_BattleRoomUIController.<>f__mg$cache24);
		string name = "m_marginTransform";
		if (Lua_BlackJack_ProjectL_UI_BattleRoomUIController.<>f__mg$cache25 == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleRoomUIController.<>f__mg$cache25 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleRoomUIController.get_m_marginTransform);
		}
		LuaCSFunction get = Lua_BlackJack_ProjectL_UI_BattleRoomUIController.<>f__mg$cache25;
		if (Lua_BlackJack_ProjectL_UI_BattleRoomUIController.<>f__mg$cache26 == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleRoomUIController.<>f__mg$cache26 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleRoomUIController.set_m_marginTransform);
		}
		LuaObject.addMember(l, name, get, Lua_BlackJack_ProjectL_UI_BattleRoomUIController.<>f__mg$cache26, true);
		string name2 = "m_playerGroupGameObject";
		if (Lua_BlackJack_ProjectL_UI_BattleRoomUIController.<>f__mg$cache27 == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleRoomUIController.<>f__mg$cache27 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleRoomUIController.get_m_playerGroupGameObject);
		}
		LuaCSFunction get2 = Lua_BlackJack_ProjectL_UI_BattleRoomUIController.<>f__mg$cache27;
		if (Lua_BlackJack_ProjectL_UI_BattleRoomUIController.<>f__mg$cache28 == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleRoomUIController.<>f__mg$cache28 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleRoomUIController.set_m_playerGroupGameObject);
		}
		LuaObject.addMember(l, name2, get2, Lua_BlackJack_ProjectL_UI_BattleRoomUIController.<>f__mg$cache28, true);
		string name3 = "m_chatEmptyGameObject";
		if (Lua_BlackJack_ProjectL_UI_BattleRoomUIController.<>f__mg$cache29 == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleRoomUIController.<>f__mg$cache29 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleRoomUIController.get_m_chatEmptyGameObject);
		}
		LuaCSFunction get3 = Lua_BlackJack_ProjectL_UI_BattleRoomUIController.<>f__mg$cache29;
		if (Lua_BlackJack_ProjectL_UI_BattleRoomUIController.<>f__mg$cache2A == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleRoomUIController.<>f__mg$cache2A = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleRoomUIController.set_m_chatEmptyGameObject);
		}
		LuaObject.addMember(l, name3, get3, Lua_BlackJack_ProjectL_UI_BattleRoomUIController.<>f__mg$cache2A, true);
		string name4 = "m_expressionButton";
		if (Lua_BlackJack_ProjectL_UI_BattleRoomUIController.<>f__mg$cache2B == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleRoomUIController.<>f__mg$cache2B = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleRoomUIController.get_m_expressionButton);
		}
		LuaCSFunction get4 = Lua_BlackJack_ProjectL_UI_BattleRoomUIController.<>f__mg$cache2B;
		if (Lua_BlackJack_ProjectL_UI_BattleRoomUIController.<>f__mg$cache2C == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleRoomUIController.<>f__mg$cache2C = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleRoomUIController.set_m_expressionButton);
		}
		LuaObject.addMember(l, name4, get4, Lua_BlackJack_ProjectL_UI_BattleRoomUIController.<>f__mg$cache2C, true);
		string name5 = "TalkButton";
		if (Lua_BlackJack_ProjectL_UI_BattleRoomUIController.<>f__mg$cache2D == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleRoomUIController.<>f__mg$cache2D = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleRoomUIController.get_TalkButton);
		}
		LuaCSFunction get5 = Lua_BlackJack_ProjectL_UI_BattleRoomUIController.<>f__mg$cache2D;
		if (Lua_BlackJack_ProjectL_UI_BattleRoomUIController.<>f__mg$cache2E == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleRoomUIController.<>f__mg$cache2E = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleRoomUIController.set_TalkButton);
		}
		LuaObject.addMember(l, name5, get5, Lua_BlackJack_ProjectL_UI_BattleRoomUIController.<>f__mg$cache2E, true);
		string name6 = "m_expressionGroup";
		if (Lua_BlackJack_ProjectL_UI_BattleRoomUIController.<>f__mg$cache2F == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleRoomUIController.<>f__mg$cache2F = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleRoomUIController.get_m_expressionGroup);
		}
		LuaCSFunction get6 = Lua_BlackJack_ProjectL_UI_BattleRoomUIController.<>f__mg$cache2F;
		if (Lua_BlackJack_ProjectL_UI_BattleRoomUIController.<>f__mg$cache30 == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleRoomUIController.<>f__mg$cache30 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleRoomUIController.set_m_expressionGroup);
		}
		LuaObject.addMember(l, name6, get6, Lua_BlackJack_ProjectL_UI_BattleRoomUIController.<>f__mg$cache30, true);
		string name7 = "ButtonBGMask";
		if (Lua_BlackJack_ProjectL_UI_BattleRoomUIController.<>f__mg$cache31 == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleRoomUIController.<>f__mg$cache31 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleRoomUIController.get_ButtonBGMask);
		}
		LuaCSFunction get7 = Lua_BlackJack_ProjectL_UI_BattleRoomUIController.<>f__mg$cache31;
		if (Lua_BlackJack_ProjectL_UI_BattleRoomUIController.<>f__mg$cache32 == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleRoomUIController.<>f__mg$cache32 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleRoomUIController.set_ButtonBGMask);
		}
		LuaObject.addMember(l, name7, get7, Lua_BlackJack_ProjectL_UI_BattleRoomUIController.<>f__mg$cache32, true);
		string name8 = "m_timeGameObject";
		if (Lua_BlackJack_ProjectL_UI_BattleRoomUIController.<>f__mg$cache33 == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleRoomUIController.<>f__mg$cache33 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleRoomUIController.get_m_timeGameObject);
		}
		LuaCSFunction get8 = Lua_BlackJack_ProjectL_UI_BattleRoomUIController.<>f__mg$cache33;
		if (Lua_BlackJack_ProjectL_UI_BattleRoomUIController.<>f__mg$cache34 == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleRoomUIController.<>f__mg$cache34 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleRoomUIController.set_m_timeGameObject);
		}
		LuaObject.addMember(l, name8, get8, Lua_BlackJack_ProjectL_UI_BattleRoomUIController.<>f__mg$cache34, true);
		string name9 = "m_timeText";
		if (Lua_BlackJack_ProjectL_UI_BattleRoomUIController.<>f__mg$cache35 == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleRoomUIController.<>f__mg$cache35 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleRoomUIController.get_m_timeText);
		}
		LuaCSFunction get9 = Lua_BlackJack_ProjectL_UI_BattleRoomUIController.<>f__mg$cache35;
		if (Lua_BlackJack_ProjectL_UI_BattleRoomUIController.<>f__mg$cache36 == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleRoomUIController.<>f__mg$cache36 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleRoomUIController.set_m_timeText);
		}
		LuaObject.addMember(l, name9, get9, Lua_BlackJack_ProjectL_UI_BattleRoomUIController.<>f__mg$cache36, true);
		string name10 = "m_bigTimeUIStateController";
		if (Lua_BlackJack_ProjectL_UI_BattleRoomUIController.<>f__mg$cache37 == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleRoomUIController.<>f__mg$cache37 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleRoomUIController.get_m_bigTimeUIStateController);
		}
		LuaCSFunction get10 = Lua_BlackJack_ProjectL_UI_BattleRoomUIController.<>f__mg$cache37;
		if (Lua_BlackJack_ProjectL_UI_BattleRoomUIController.<>f__mg$cache38 == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleRoomUIController.<>f__mg$cache38 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleRoomUIController.set_m_bigTimeUIStateController);
		}
		LuaObject.addMember(l, name10, get10, Lua_BlackJack_ProjectL_UI_BattleRoomUIController.<>f__mg$cache38, true);
		string name11 = "m_bigTimeText";
		if (Lua_BlackJack_ProjectL_UI_BattleRoomUIController.<>f__mg$cache39 == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleRoomUIController.<>f__mg$cache39 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleRoomUIController.get_m_bigTimeText);
		}
		LuaCSFunction get11 = Lua_BlackJack_ProjectL_UI_BattleRoomUIController.<>f__mg$cache39;
		if (Lua_BlackJack_ProjectL_UI_BattleRoomUIController.<>f__mg$cache3A == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleRoomUIController.<>f__mg$cache3A = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleRoomUIController.set_m_bigTimeText);
		}
		LuaObject.addMember(l, name11, get11, Lua_BlackJack_ProjectL_UI_BattleRoomUIController.<>f__mg$cache3A, true);
		string name12 = "m_actionPlayerUIStateController";
		if (Lua_BlackJack_ProjectL_UI_BattleRoomUIController.<>f__mg$cache3B == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleRoomUIController.<>f__mg$cache3B = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleRoomUIController.get_m_actionPlayerUIStateController);
		}
		LuaCSFunction get12 = Lua_BlackJack_ProjectL_UI_BattleRoomUIController.<>f__mg$cache3B;
		if (Lua_BlackJack_ProjectL_UI_BattleRoomUIController.<>f__mg$cache3C == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleRoomUIController.<>f__mg$cache3C = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleRoomUIController.set_m_actionPlayerUIStateController);
		}
		LuaObject.addMember(l, name12, get12, Lua_BlackJack_ProjectL_UI_BattleRoomUIController.<>f__mg$cache3C, true);
		string name13 = "m_actionPlayerEnemyUIStateController";
		if (Lua_BlackJack_ProjectL_UI_BattleRoomUIController.<>f__mg$cache3D == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleRoomUIController.<>f__mg$cache3D = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleRoomUIController.get_m_actionPlayerEnemyUIStateController);
		}
		LuaCSFunction get13 = Lua_BlackJack_ProjectL_UI_BattleRoomUIController.<>f__mg$cache3D;
		if (Lua_BlackJack_ProjectL_UI_BattleRoomUIController.<>f__mg$cache3E == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleRoomUIController.<>f__mg$cache3E = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleRoomUIController.set_m_actionPlayerEnemyUIStateController);
		}
		LuaObject.addMember(l, name13, get13, Lua_BlackJack_ProjectL_UI_BattleRoomUIController.<>f__mg$cache3E, true);
		string name14 = "m_actionPlayerTagImage";
		if (Lua_BlackJack_ProjectL_UI_BattleRoomUIController.<>f__mg$cache3F == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleRoomUIController.<>f__mg$cache3F = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleRoomUIController.get_m_actionPlayerTagImage);
		}
		LuaCSFunction get14 = Lua_BlackJack_ProjectL_UI_BattleRoomUIController.<>f__mg$cache3F;
		if (Lua_BlackJack_ProjectL_UI_BattleRoomUIController.<>f__mg$cache40 == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleRoomUIController.<>f__mg$cache40 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleRoomUIController.set_m_actionPlayerTagImage);
		}
		LuaObject.addMember(l, name14, get14, Lua_BlackJack_ProjectL_UI_BattleRoomUIController.<>f__mg$cache40, true);
		string name15 = "m_actionPlayerTimeText";
		if (Lua_BlackJack_ProjectL_UI_BattleRoomUIController.<>f__mg$cache41 == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleRoomUIController.<>f__mg$cache41 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleRoomUIController.get_m_actionPlayerTimeText);
		}
		LuaCSFunction get15 = Lua_BlackJack_ProjectL_UI_BattleRoomUIController.<>f__mg$cache41;
		if (Lua_BlackJack_ProjectL_UI_BattleRoomUIController.<>f__mg$cache42 == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleRoomUIController.<>f__mg$cache42 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleRoomUIController.set_m_actionPlayerTimeText);
		}
		LuaObject.addMember(l, name15, get15, Lua_BlackJack_ProjectL_UI_BattleRoomUIController.<>f__mg$cache42, true);
		string name16 = "m_prefabsGameObject";
		if (Lua_BlackJack_ProjectL_UI_BattleRoomUIController.<>f__mg$cache43 == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleRoomUIController.<>f__mg$cache43 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleRoomUIController.get_m_prefabsGameObject);
		}
		LuaCSFunction get16 = Lua_BlackJack_ProjectL_UI_BattleRoomUIController.<>f__mg$cache43;
		if (Lua_BlackJack_ProjectL_UI_BattleRoomUIController.<>f__mg$cache44 == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleRoomUIController.<>f__mg$cache44 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleRoomUIController.set_m_prefabsGameObject);
		}
		LuaObject.addMember(l, name16, get16, Lua_BlackJack_ProjectL_UI_BattleRoomUIController.<>f__mg$cache44, true);
		string name17 = "m_battleTeamPlayerPrefab";
		if (Lua_BlackJack_ProjectL_UI_BattleRoomUIController.<>f__mg$cache45 == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleRoomUIController.<>f__mg$cache45 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleRoomUIController.get_m_battleTeamPlayerPrefab);
		}
		LuaCSFunction get17 = Lua_BlackJack_ProjectL_UI_BattleRoomUIController.<>f__mg$cache45;
		if (Lua_BlackJack_ProjectL_UI_BattleRoomUIController.<>f__mg$cache46 == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleRoomUIController.<>f__mg$cache46 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleRoomUIController.set_m_battleTeamPlayerPrefab);
		}
		LuaObject.addMember(l, name17, get17, Lua_BlackJack_ProjectL_UI_BattleRoomUIController.<>f__mg$cache46, true);
		string name18 = "m_expressionParseDesc";
		if (Lua_BlackJack_ProjectL_UI_BattleRoomUIController.<>f__mg$cache47 == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleRoomUIController.<>f__mg$cache47 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleRoomUIController.get_m_expressionParseDesc);
		}
		LuaCSFunction get18 = Lua_BlackJack_ProjectL_UI_BattleRoomUIController.<>f__mg$cache47;
		if (Lua_BlackJack_ProjectL_UI_BattleRoomUIController.<>f__mg$cache48 == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleRoomUIController.<>f__mg$cache48 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleRoomUIController.set_m_expressionParseDesc);
		}
		LuaObject.addMember(l, name18, get18, Lua_BlackJack_ProjectL_UI_BattleRoomUIController.<>f__mg$cache48, true);
		string name19 = "m_expressionResContainer";
		if (Lua_BlackJack_ProjectL_UI_BattleRoomUIController.<>f__mg$cache49 == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleRoomUIController.<>f__mg$cache49 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleRoomUIController.get_m_expressionResContainer);
		}
		LuaCSFunction get19 = Lua_BlackJack_ProjectL_UI_BattleRoomUIController.<>f__mg$cache49;
		if (Lua_BlackJack_ProjectL_UI_BattleRoomUIController.<>f__mg$cache4A == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleRoomUIController.<>f__mg$cache4A = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleRoomUIController.set_m_expressionResContainer);
		}
		LuaObject.addMember(l, name19, get19, Lua_BlackJack_ProjectL_UI_BattleRoomUIController.<>f__mg$cache4A, true);
		string name20 = "m_players";
		if (Lua_BlackJack_ProjectL_UI_BattleRoomUIController.<>f__mg$cache4B == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleRoomUIController.<>f__mg$cache4B = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleRoomUIController.get_m_players);
		}
		LuaCSFunction get20 = Lua_BlackJack_ProjectL_UI_BattleRoomUIController.<>f__mg$cache4B;
		if (Lua_BlackJack_ProjectL_UI_BattleRoomUIController.<>f__mg$cache4C == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleRoomUIController.<>f__mg$cache4C = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleRoomUIController.set_m_players);
		}
		LuaObject.addMember(l, name20, get20, Lua_BlackJack_ProjectL_UI_BattleRoomUIController.<>f__mg$cache4C, true);
		string name21 = "m_bigExpressionCtrl";
		if (Lua_BlackJack_ProjectL_UI_BattleRoomUIController.<>f__mg$cache4D == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleRoomUIController.<>f__mg$cache4D = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleRoomUIController.get_m_bigExpressionCtrl);
		}
		LuaCSFunction get21 = Lua_BlackJack_ProjectL_UI_BattleRoomUIController.<>f__mg$cache4D;
		if (Lua_BlackJack_ProjectL_UI_BattleRoomUIController.<>f__mg$cache4E == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleRoomUIController.<>f__mg$cache4E = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleRoomUIController.set_m_bigExpressionCtrl);
		}
		LuaObject.addMember(l, name21, get21, Lua_BlackJack_ProjectL_UI_BattleRoomUIController.<>f__mg$cache4E, true);
		LuaObject.createTypeMetatable(l, null, typeof(BattleRoomUIController), typeof(UIControllerBase));
	}

	// Token: 0x04012165 RID: 74085
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache0;

	// Token: 0x04012166 RID: 74086
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1;

	// Token: 0x04012167 RID: 74087
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2;

	// Token: 0x04012168 RID: 74088
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3;

	// Token: 0x04012169 RID: 74089
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache4;

	// Token: 0x0401216A RID: 74090
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache5;

	// Token: 0x0401216B RID: 74091
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache6;

	// Token: 0x0401216C RID: 74092
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache7;

	// Token: 0x0401216D RID: 74093
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache8;

	// Token: 0x0401216E RID: 74094
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache9;

	// Token: 0x0401216F RID: 74095
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheA;

	// Token: 0x04012170 RID: 74096
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheB;

	// Token: 0x04012171 RID: 74097
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheC;

	// Token: 0x04012172 RID: 74098
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheD;

	// Token: 0x04012173 RID: 74099
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheE;

	// Token: 0x04012174 RID: 74100
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheF;

	// Token: 0x04012175 RID: 74101
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache10;

	// Token: 0x04012176 RID: 74102
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache11;

	// Token: 0x04012177 RID: 74103
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache12;

	// Token: 0x04012178 RID: 74104
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache13;

	// Token: 0x04012179 RID: 74105
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache14;

	// Token: 0x0401217A RID: 74106
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache15;

	// Token: 0x0401217B RID: 74107
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache16;

	// Token: 0x0401217C RID: 74108
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache17;

	// Token: 0x0401217D RID: 74109
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache18;

	// Token: 0x0401217E RID: 74110
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache19;

	// Token: 0x0401217F RID: 74111
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1A;

	// Token: 0x04012180 RID: 74112
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1B;

	// Token: 0x04012181 RID: 74113
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1C;

	// Token: 0x04012182 RID: 74114
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1D;

	// Token: 0x04012183 RID: 74115
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1E;

	// Token: 0x04012184 RID: 74116
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1F;

	// Token: 0x04012185 RID: 74117
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache20;

	// Token: 0x04012186 RID: 74118
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache21;

	// Token: 0x04012187 RID: 74119
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache22;

	// Token: 0x04012188 RID: 74120
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache23;

	// Token: 0x04012189 RID: 74121
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache24;

	// Token: 0x0401218A RID: 74122
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache25;

	// Token: 0x0401218B RID: 74123
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache26;

	// Token: 0x0401218C RID: 74124
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache27;

	// Token: 0x0401218D RID: 74125
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache28;

	// Token: 0x0401218E RID: 74126
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache29;

	// Token: 0x0401218F RID: 74127
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2A;

	// Token: 0x04012190 RID: 74128
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2B;

	// Token: 0x04012191 RID: 74129
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2C;

	// Token: 0x04012192 RID: 74130
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2D;

	// Token: 0x04012193 RID: 74131
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2E;

	// Token: 0x04012194 RID: 74132
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2F;

	// Token: 0x04012195 RID: 74133
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache30;

	// Token: 0x04012196 RID: 74134
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache31;

	// Token: 0x04012197 RID: 74135
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache32;

	// Token: 0x04012198 RID: 74136
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache33;

	// Token: 0x04012199 RID: 74137
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache34;

	// Token: 0x0401219A RID: 74138
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache35;

	// Token: 0x0401219B RID: 74139
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache36;

	// Token: 0x0401219C RID: 74140
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache37;

	// Token: 0x0401219D RID: 74141
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache38;

	// Token: 0x0401219E RID: 74142
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache39;

	// Token: 0x0401219F RID: 74143
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3A;

	// Token: 0x040121A0 RID: 74144
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3B;

	// Token: 0x040121A1 RID: 74145
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3C;

	// Token: 0x040121A2 RID: 74146
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3D;

	// Token: 0x040121A3 RID: 74147
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3E;

	// Token: 0x040121A4 RID: 74148
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3F;

	// Token: 0x040121A5 RID: 74149
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache40;

	// Token: 0x040121A6 RID: 74150
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache41;

	// Token: 0x040121A7 RID: 74151
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache42;

	// Token: 0x040121A8 RID: 74152
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache43;

	// Token: 0x040121A9 RID: 74153
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache44;

	// Token: 0x040121AA RID: 74154
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache45;

	// Token: 0x040121AB RID: 74155
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache46;

	// Token: 0x040121AC RID: 74156
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache47;

	// Token: 0x040121AD RID: 74157
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache48;

	// Token: 0x040121AE RID: 74158
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache49;

	// Token: 0x040121AF RID: 74159
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache4A;

	// Token: 0x040121B0 RID: 74160
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache4B;

	// Token: 0x040121B1 RID: 74161
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache4C;

	// Token: 0x040121B2 RID: 74162
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache4D;

	// Token: 0x040121B3 RID: 74163
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache4E;
}
