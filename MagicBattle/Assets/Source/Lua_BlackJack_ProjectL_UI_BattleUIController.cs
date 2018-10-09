using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using BlackJack.BJFramework.Runtime.Prefab;
using BlackJack.BJFramework.Runtime.UI;
using BlackJack.ConfigData;
using BlackJack.ProjectL.Battle;
using BlackJack.ProjectL.Common;
using BlackJack.ProjectL.Misc;
using BlackJack.ProjectL.PlayerContext;
using BlackJack.ProjectL.Scene;
using BlackJack.ProjectL.UI;
using SLua;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.Scripting;
using UnityEngine.UI;

// Token: 0x020013C8 RID: 5064
[Preserve]
public class Lua_BlackJack_ProjectL_UI_BattleUIController : LuaObject
{
	// Token: 0x0601C0D9 RID: 114905 RVA: 0x008A059C File Offset: 0x0089E79C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int StartBattle(IntPtr l)
	{
		int result;
		try
		{
			BattleUIController battleUIController = (BattleUIController)LuaObject.checkSelf(l);
			battleUIController.StartBattle();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601C0DA RID: 114906 RVA: 0x008A05E8 File Offset: 0x0089E7E8
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int StopBattle(IntPtr l)
	{
		int result;
		try
		{
			BattleUIController battleUIController = (BattleUIController)LuaObject.checkSelf(l);
			bool win;
			LuaObject.checkType(l, 2, out win);
			battleUIController.StopBattle(win);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601C0DB RID: 114907 RVA: 0x008A0640 File Offset: 0x0089E840
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int ShowTurnStatus(IntPtr l)
	{
		int result;
		try
		{
			BattleUIController battleUIController = (BattleUIController)LuaObject.checkSelf(l);
			bool show;
			LuaObject.checkType(l, 2, out show);
			battleUIController.ShowTurnStatus(show);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601C0DC RID: 114908 RVA: 0x008A0698 File Offset: 0x0089E898
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int ShowObjecive(IntPtr l)
	{
		int result;
		try
		{
			BattleUIController battleUIController = (BattleUIController)LuaObject.checkSelf(l);
			string winDesc;
			LuaObject.checkType(l, 2, out winDesc);
			string loseDesc;
			LuaObject.checkType(l, 3, out loseDesc);
			battleUIController.ShowObjecive(winDesc, loseDesc);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601C0DD RID: 114909 RVA: 0x008A06FC File Offset: 0x0089E8FC
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int ShowTurnStart(IntPtr l)
	{
		int result;
		try
		{
			BattleUIController battleUIController = (BattleUIController)LuaObject.checkSelf(l);
			int turn;
			LuaObject.checkType(l, 2, out turn);
			int turnMax;
			LuaObject.checkType(l, 3, out turnMax);
			battleUIController.ShowTurnStart(turn, turnMax);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601C0DE RID: 114910 RVA: 0x008A0760 File Offset: 0x0089E960
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int ShowPlayerTurn(IntPtr l)
	{
		int result;
		try
		{
			BattleUIController battleUIController = (BattleUIController)LuaObject.checkSelf(l);
			battleUIController.ShowPlayerTurn();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601C0DF RID: 114911 RVA: 0x008A07AC File Offset: 0x0089E9AC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int ShowEnemyTurn(IntPtr l)
	{
		int result;
		try
		{
			BattleUIController battleUIController = (BattleUIController)LuaObject.checkSelf(l);
			battleUIController.ShowEnemyTurn();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601C0E0 RID: 114912 RVA: 0x008A07F8 File Offset: 0x0089E9F8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int ShowMyAction(IntPtr l)
	{
		int result;
		try
		{
			BattleUIController battleUIController = (BattleUIController)LuaObject.checkSelf(l);
			BattleRoomPlayer player;
			LuaObject.checkType<BattleRoomPlayer>(l, 2, out player);
			int playerTagIndex;
			LuaObject.checkType(l, 3, out playerTagIndex);
			Action onEnd;
			LuaObject.checkDelegate<Action>(l, 4, out onEnd);
			battleUIController.ShowMyAction(player, playerTagIndex, onEnd);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601C0E1 RID: 114913 RVA: 0x008A086C File Offset: 0x0089EA6C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int ShowTeammateAction(IntPtr l)
	{
		int result;
		try
		{
			BattleUIController battleUIController = (BattleUIController)LuaObject.checkSelf(l);
			BattleRoomPlayer player;
			LuaObject.checkType<BattleRoomPlayer>(l, 2, out player);
			int playerIndex;
			LuaObject.checkType(l, 3, out playerIndex);
			Action onEnd;
			LuaObject.checkDelegate<Action>(l, 4, out onEnd);
			battleUIController.ShowTeammateAction(player, playerIndex, onEnd);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601C0E2 RID: 114914 RVA: 0x008A08E0 File Offset: 0x0089EAE0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int ShowEnemyAction(IntPtr l)
	{
		int result;
		try
		{
			BattleUIController battleUIController = (BattleUIController)LuaObject.checkSelf(l);
			BattleRoomPlayer player;
			LuaObject.checkType<BattleRoomPlayer>(l, 2, out player);
			battleUIController.ShowEnemyAction(player);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601C0E3 RID: 114915 RVA: 0x008A0938 File Offset: 0x0089EB38
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int HidePauseButton(IntPtr l)
	{
		int result;
		try
		{
			BattleUIController battleUIController = (BattleUIController)LuaObject.checkSelf(l);
			battleUIController.HidePauseButton();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601C0E4 RID: 114916 RVA: 0x008A0984 File Offset: 0x0089EB84
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int ShowChatButton(IntPtr l)
	{
		int result;
		try
		{
			BattleUIController battleUIController = (BattleUIController)LuaObject.checkSelf(l);
			bool show;
			LuaObject.checkType(l, 2, out show);
			battleUIController.ShowChatButton(show);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601C0E5 RID: 114917 RVA: 0x008A09DC File Offset: 0x0089EBDC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int SetAutoBattle(IntPtr l)
	{
		int result;
		try
		{
			BattleUIController battleUIController = (BattleUIController)LuaObject.checkSelf(l);
			bool autoBattle;
			LuaObject.checkType(l, 2, out autoBattle);
			battleUIController.SetAutoBattle(autoBattle);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601C0E6 RID: 114918 RVA: 0x008A0A34 File Offset: 0x0089EC34
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int HideAutoBattleButton(IntPtr l)
	{
		int result;
		try
		{
			BattleUIController battleUIController = (BattleUIController)LuaObject.checkSelf(l);
			battleUIController.HideAutoBattleButton();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601C0E7 RID: 114919 RVA: 0x008A0A80 File Offset: 0x0089EC80
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int SetArenaAutoBattle(IntPtr l)
	{
		int result;
		try
		{
			BattleUIController battleUIController = (BattleUIController)LuaObject.checkSelf(l);
			bool arenaAutoBattle;
			LuaObject.checkType(l, 2, out arenaAutoBattle);
			battleUIController.SetArenaAutoBattle(arenaAutoBattle);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601C0E8 RID: 114920 RVA: 0x008A0AD8 File Offset: 0x0089ECD8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int SetFastBattle(IntPtr l)
	{
		int result;
		try
		{
			BattleUIController battleUIController = (BattleUIController)LuaObject.checkSelf(l);
			bool fastBattle;
			LuaObject.checkType(l, 2, out fastBattle);
			battleUIController.SetFastBattle(fastBattle);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601C0E9 RID: 114921 RVA: 0x008A0B30 File Offset: 0x0089ED30
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int SetSkipCombatMode(IntPtr l)
	{
		int result;
		try
		{
			BattleUIController battleUIController = (BattleUIController)LuaObject.checkSelf(l);
			SkipCombatMode skipCombatMode;
			LuaObject.checkEnum<SkipCombatMode>(l, 2, out skipCombatMode);
			battleUIController.SetSkipCombatMode(skipCombatMode);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601C0EA RID: 114922 RVA: 0x008A0B88 File Offset: 0x0089ED88
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int SetActorSimpleInfo(IntPtr l)
	{
		int result;
		try
		{
			BattleUIController battleUIController = (BattleUIController)LuaObject.checkSelf(l);
			BattleActor actorSimpleInfo;
			LuaObject.checkType<BattleActor>(l, 2, out actorSimpleInfo);
			battleUIController.SetActorSimpleInfo(actorSimpleInfo);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601C0EB RID: 114923 RVA: 0x008A0BE0 File Offset: 0x0089EDE0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int ShowActorSimpleInfo(IntPtr l)
	{
		int result;
		try
		{
			BattleUIController battleUIController = (BattleUIController)LuaObject.checkSelf(l);
			bool show;
			LuaObject.checkType(l, 2, out show);
			battleUIController.ShowActorSimpleInfo(show);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601C0EC RID: 114924 RVA: 0x008A0C38 File Offset: 0x0089EE38
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int IsShowActorSimpleInfo(IntPtr l)
	{
		int result;
		try
		{
			BattleUIController battleUIController = (BattleUIController)LuaObject.checkSelf(l);
			bool b = battleUIController.IsShowActorSimpleInfo();
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

	// Token: 0x0601C0ED RID: 114925 RVA: 0x008A0C8C File Offset: 0x0089EE8C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int SetShowDanger(IntPtr l)
	{
		int result;
		try
		{
			BattleUIController battleUIController = (BattleUIController)LuaObject.checkSelf(l);
			bool showDanger;
			LuaObject.checkType(l, 2, out showDanger);
			battleUIController.SetShowDanger(showDanger);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601C0EE RID: 114926 RVA: 0x008A0CE4 File Offset: 0x0089EEE4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int ShowEndAction(IntPtr l)
	{
		int result;
		try
		{
			BattleUIController battleUIController = (BattleUIController)LuaObject.checkSelf(l);
			bool show;
			LuaObject.checkType(l, 2, out show);
			battleUIController.ShowEndAction(show);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601C0EF RID: 114927 RVA: 0x008A0D3C File Offset: 0x0089EF3C
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int ShowEndAllAction(IntPtr l)
	{
		int result;
		try
		{
			BattleUIController battleUIController = (BattleUIController)LuaObject.checkSelf(l);
			bool show;
			LuaObject.checkType(l, 2, out show);
			battleUIController.ShowEndAllAction(show);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601C0F0 RID: 114928 RVA: 0x008A0D94 File Offset: 0x0089EF94
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int SetActionOrderType(IntPtr l)
	{
		int result;
		try
		{
			BattleUIController battleUIController = (BattleUIController)LuaObject.checkSelf(l);
			ActionOrderType actionOrderType;
			LuaObject.checkEnum<ActionOrderType>(l, 2, out actionOrderType);
			battleUIController.SetActionOrderType(actionOrderType);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601C0F1 RID: 114929 RVA: 0x008A0DEC File Offset: 0x0089EFEC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int RefreshChatRedState(IntPtr l)
	{
		int result;
		try
		{
			BattleUIController battleUIController = (BattleUIController)LuaObject.checkSelf(l);
			battleUIController.RefreshChatRedState();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601C0F2 RID: 114930 RVA: 0x008A0E38 File Offset: 0x0089F038
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int ShowTopUI(IntPtr l)
	{
		int result;
		try
		{
			BattleUIController battleUIController = (BattleUIController)LuaObject.checkSelf(l);
			bool show;
			LuaObject.checkType(l, 2, out show);
			battleUIController.ShowTopUI(show);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601C0F3 RID: 114931 RVA: 0x008A0E90 File Offset: 0x0089F090
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int IsShowTopUI(IntPtr l)
	{
		int result;
		try
		{
			BattleUIController battleUIController = (BattleUIController)LuaObject.checkSelf(l);
			bool b = battleUIController.IsShowTopUI();
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

	// Token: 0x0601C0F4 RID: 114932 RVA: 0x008A0EE4 File Offset: 0x0089F0E4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int ShowBottomUI(IntPtr l)
	{
		int result;
		try
		{
			BattleUIController battleUIController = (BattleUIController)LuaObject.checkSelf(l);
			bool show;
			LuaObject.checkType(l, 2, out show);
			battleUIController.ShowBottomUI(show);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601C0F5 RID: 114933 RVA: 0x008A0F3C File Offset: 0x0089F13C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int IsShowBottomUI(IntPtr l)
	{
		int result;
		try
		{
			BattleUIController battleUIController = (BattleUIController)LuaObject.checkSelf(l);
			bool b = battleUIController.IsShowBottomUI();
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

	// Token: 0x0601C0F6 RID: 114934 RVA: 0x008A0F90 File Offset: 0x0089F190
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int ShowSkills(IntPtr l)
	{
		int result;
		try
		{
			BattleUIController battleUIController = (BattleUIController)LuaObject.checkSelf(l);
			List<BattleSkillState> skills;
			LuaObject.checkType<List<BattleSkillState>>(l, 2, out skills);
			bool isActiveSkillBanned;
			LuaObject.checkType(l, 3, out isActiveSkillBanned);
			bool isPassiveSkillBanned;
			LuaObject.checkType(l, 4, out isPassiveSkillBanned);
			battleUIController.ShowSkills(skills, isActiveSkillBanned, isPassiveSkillBanned);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601C0F7 RID: 114935 RVA: 0x008A1004 File Offset: 0x0089F204
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int GetSkillButtonRectTransform(IntPtr l)
	{
		int result;
		try
		{
			BattleUIController battleUIController = (BattleUIController)LuaObject.checkSelf(l);
			int idx;
			LuaObject.checkType(l, 2, out idx);
			RectTransform skillButtonRectTransform = battleUIController.GetSkillButtonRectTransform(idx);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, skillButtonRectTransform);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601C0F8 RID: 114936 RVA: 0x008A1068 File Offset: 0x0089F268
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int HideSkills(IntPtr l)
	{
		int result;
		try
		{
			BattleUIController battleUIController = (BattleUIController)LuaObject.checkSelf(l);
			battleUIController.HideSkills();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601C0F9 RID: 114937 RVA: 0x008A10B4 File Offset: 0x0089F2B4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int ShowUseOrCancelSkill(IntPtr l)
	{
		int result;
		try
		{
			BattleUIController battleUIController = (BattleUIController)LuaObject.checkSelf(l);
			bool show;
			LuaObject.checkType(l, 2, out show);
			battleUIController.ShowUseOrCancelSkill(show);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601C0FA RID: 114938 RVA: 0x008A110C File Offset: 0x0089F30C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int ShowUseSkill(IntPtr l)
	{
		int result;
		try
		{
			BattleUIController battleUIController = (BattleUIController)LuaObject.checkSelf(l);
			bool enable;
			LuaObject.checkType(l, 2, out enable);
			battleUIController.ShowUseSkill(enable);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601C0FB RID: 114939 RVA: 0x008A1164 File Offset: 0x0089F364
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int SetCurrentSkill(IntPtr l)
	{
		int result;
		try
		{
			BattleUIController battleUIController = (BattleUIController)LuaObject.checkSelf(l);
			BattleSkillState currentSkill;
			LuaObject.checkType<BattleSkillState>(l, 2, out currentSkill);
			battleUIController.SetCurrentSkill(currentSkill);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601C0FC RID: 114940 RVA: 0x008A11BC File Offset: 0x0089F3BC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int ShowSkillHint(IntPtr l)
	{
		int result;
		try
		{
			BattleUIController battleUIController = (BattleUIController)LuaObject.checkSelf(l);
			StringTableId id;
			LuaObject.checkEnum<StringTableId>(l, 2, out id);
			float hideTime;
			LuaObject.checkType(l, 3, out hideTime);
			battleUIController.ShowSkillHint(id, hideTime);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601C0FD RID: 114941 RVA: 0x008A1220 File Offset: 0x0089F420
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int HideSkillHint(IntPtr l)
	{
		int result;
		try
		{
			BattleUIController battleUIController = (BattleUIController)LuaObject.checkSelf(l);
			battleUIController.HideSkillHint();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601C0FE RID: 114942 RVA: 0x008A126C File Offset: 0x0089F46C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int HighlightSkillHint(IntPtr l)
	{
		int result;
		try
		{
			BattleUIController battleUIController = (BattleUIController)LuaObject.checkSelf(l);
			battleUIController.HighlightSkillHint();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601C0FF RID: 114943 RVA: 0x008A12B8 File Offset: 0x0089F4B8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int ShowTerrainInfo(IntPtr l)
	{
		int result;
		try
		{
			BattleUIController battleUIController = (BattleUIController)LuaObject.checkSelf(l);
			ConfigDataTerrainInfo terrain;
			LuaObject.checkType<ConfigDataTerrainInfo>(l, 2, out terrain);
			battleUIController.ShowTerrainInfo(terrain);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601C100 RID: 114944 RVA: 0x008A1310 File Offset: 0x0089F510
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int HideTerrainInfo(IntPtr l)
	{
		int result;
		try
		{
			BattleUIController battleUIController = (BattleUIController)LuaObject.checkSelf(l);
			battleUIController.HideTerrainInfo();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601C101 RID: 114945 RVA: 0x008A135C File Offset: 0x0089F55C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int ShowArmyRelationButton(IntPtr l)
	{
		int result;
		try
		{
			BattleUIController battleUIController = (BattleUIController)LuaObject.checkSelf(l);
			battleUIController.ShowArmyRelationButton();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601C102 RID: 114946 RVA: 0x008A13A8 File Offset: 0x0089F5A8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int ShowArmyRelationDesc(IntPtr l)
	{
		int result;
		try
		{
			BattleUIController battleUIController = (BattleUIController)LuaObject.checkSelf(l);
			battleUIController.ShowArmyRelationDesc();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601C103 RID: 114947 RVA: 0x008A13F4 File Offset: 0x0089F5F4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int HideArmyRelationDesc(IntPtr l)
	{
		int result;
		try
		{
			BattleUIController battleUIController = (BattleUIController)LuaObject.checkSelf(l);
			battleUIController.HideArmyRelationDesc();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601C104 RID: 114948 RVA: 0x008A1440 File Offset: 0x0089F640
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int IsArmyRelationDescVisible(IntPtr l)
	{
		int result;
		try
		{
			BattleUIController battleUIController = (BattleUIController)LuaObject.checkSelf(l);
			bool b = battleUIController.IsArmyRelationDescVisible();
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

	// Token: 0x0601C105 RID: 114949 RVA: 0x008A1494 File Offset: 0x0089F694
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int ShowCutsceneSkill(IntPtr l)
	{
		int result;
		try
		{
			BattleUIController battleUIController = (BattleUIController)LuaObject.checkSelf(l);
			ConfigDataSkillInfo skillInfo;
			LuaObject.checkType<ConfigDataSkillInfo>(l, 2, out skillInfo);
			battleUIController.ShowCutsceneSkill(skillInfo);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601C106 RID: 114950 RVA: 0x008A14EC File Offset: 0x0089F6EC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int ShowDanmakuToggle(IntPtr l)
	{
		int result;
		try
		{
			BattleUIController battleUIController = (BattleUIController)LuaObject.checkSelf(l);
			bool show;
			LuaObject.checkType(l, 2, out show);
			battleUIController.ShowDanmakuToggle(show);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601C107 RID: 114951 RVA: 0x008A1544 File Offset: 0x0089F744
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int ShowCurTurnDanmaku(IntPtr l)
	{
		int result;
		try
		{
			BattleUIController battleUIController = (BattleUIController)LuaObject.checkSelf(l);
			int turn;
			LuaObject.checkType(l, 2, out turn);
			battleUIController.ShowCurTurnDanmaku(turn);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601C108 RID: 114952 RVA: 0x008A159C File Offset: 0x0089F79C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int SetRegretCount(IntPtr l)
	{
		int result;
		try
		{
			BattleUIController battleUIController = (BattleUIController)LuaObject.checkSelf(l);
			int remainCount;
			LuaObject.checkType(l, 2, out remainCount);
			int maxCount;
			LuaObject.checkType(l, 3, out maxCount);
			battleUIController.SetRegretCount(remainCount, maxCount);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601C109 RID: 114953 RVA: 0x008A1600 File Offset: 0x0089F800
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int SetRegretTurnStatus(IntPtr l)
	{
		int result;
		try
		{
			BattleUIController battleUIController = (BattleUIController)LuaObject.checkSelf(l);
			int turn;
			LuaObject.checkType(l, 2, out turn);
			int actionTeam;
			LuaObject.checkType(l, 3, out actionTeam);
			int count;
			LuaObject.checkType(l, 4, out count);
			int countMax;
			LuaObject.checkType(l, 5, out countMax);
			battleUIController.SetRegretTurnStatus(turn, actionTeam, count, countMax);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601C10A RID: 114954 RVA: 0x008A1680 File Offset: 0x0089F880
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int SetRegretButtonStatus(IntPtr l)
	{
		int result;
		try
		{
			BattleUIController battleUIController = (BattleUIController)LuaObject.checkSelf(l);
			bool canBackward;
			LuaObject.checkType(l, 2, out canBackward);
			bool canForward;
			LuaObject.checkType(l, 3, out canForward);
			bool canConfirm;
			LuaObject.checkType(l, 4, out canConfirm);
			battleUIController.SetRegretButtonStatus(canBackward, canForward, canConfirm);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601C10B RID: 114955 RVA: 0x008A16F4 File Offset: 0x0089F8F4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int ShowRegretButton(IntPtr l)
	{
		int result;
		try
		{
			BattleUIController battleUIController = (BattleUIController)LuaObject.checkSelf(l);
			bool show;
			LuaObject.checkType(l, 2, out show);
			battleUIController.ShowRegretButton(show);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601C10C RID: 114956 RVA: 0x008A174C File Offset: 0x0089F94C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int ShowRegretPanel(IntPtr l)
	{
		int result;
		try
		{
			BattleUIController battleUIController = (BattleUIController)LuaObject.checkSelf(l);
			bool show;
			LuaObject.checkType(l, 2, out show);
			battleUIController.ShowRegretPanel(show);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601C10D RID: 114957 RVA: 0x008A17A4 File Offset: 0x0089F9A4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int ShowRegretConfirmFx(IntPtr l)
	{
		int result;
		try
		{
			BattleUIController battleUIController = (BattleUIController)LuaObject.checkSelf(l);
			Action onEnd;
			LuaObject.checkDelegate<Action>(l, 2, out onEnd);
			battleUIController.ShowRegretConfirmFx(onEnd);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601C10E RID: 114958 RVA: 0x008A17FC File Offset: 0x0089F9FC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int OnScenePointerDown(IntPtr l)
	{
		int result;
		try
		{
			BattleUIController battleUIController = (BattleUIController)LuaObject.checkSelf(l);
			PointerEventData eventData;
			LuaObject.checkType<PointerEventData>(l, 2, out eventData);
			battleUIController.OnScenePointerDown(eventData);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601C10F RID: 114959 RVA: 0x008A1854 File Offset: 0x0089FA54
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int OnScenePointerUp(IntPtr l)
	{
		int result;
		try
		{
			BattleUIController battleUIController = (BattleUIController)LuaObject.checkSelf(l);
			PointerEventData eventData;
			LuaObject.checkType<PointerEventData>(l, 2, out eventData);
			battleUIController.OnScenePointerUp(eventData);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601C110 RID: 114960 RVA: 0x008A18AC File Offset: 0x0089FAAC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int OnScenePointerClick(IntPtr l)
	{
		int result;
		try
		{
			BattleUIController battleUIController = (BattleUIController)LuaObject.checkSelf(l);
			PointerEventData eventData;
			LuaObject.checkType<PointerEventData>(l, 2, out eventData);
			battleUIController.OnScenePointerClick(eventData);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601C111 RID: 114961 RVA: 0x008A1904 File Offset: 0x0089FB04
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int OnSceneBeginDrag(IntPtr l)
	{
		int result;
		try
		{
			BattleUIController battleUIController = (BattleUIController)LuaObject.checkSelf(l);
			PointerEventData eventData;
			LuaObject.checkType<PointerEventData>(l, 2, out eventData);
			battleUIController.OnSceneBeginDrag(eventData);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601C112 RID: 114962 RVA: 0x008A195C File Offset: 0x0089FB5C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int OnSceneEndDrag(IntPtr l)
	{
		int result;
		try
		{
			BattleUIController battleUIController = (BattleUIController)LuaObject.checkSelf(l);
			PointerEventData eventData;
			LuaObject.checkType<PointerEventData>(l, 2, out eventData);
			battleUIController.OnSceneEndDrag(eventData);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601C113 RID: 114963 RVA: 0x008A19B4 File Offset: 0x0089FBB4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int OnSceneDrag(IntPtr l)
	{
		int result;
		try
		{
			BattleUIController battleUIController = (BattleUIController)LuaObject.checkSelf(l);
			PointerEventData eventData;
			LuaObject.checkType<PointerEventData>(l, 2, out eventData);
			battleUIController.OnSceneDrag(eventData);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601C114 RID: 114964 RVA: 0x008A1A0C File Offset: 0x0089FC0C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int OnScene3DTouch(IntPtr l)
	{
		int result;
		try
		{
			BattleUIController battleUIController = (BattleUIController)LuaObject.checkSelf(l);
			Vector2 p;
			LuaObject.checkType(l, 2, out p);
			battleUIController.OnScene3DTouch(p);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601C115 RID: 114965 RVA: 0x008A1A64 File Offset: 0x0089FC64
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int OnBindFiledsCompleted(IntPtr l)
	{
		int result;
		try
		{
			BattleUIController battleUIController = (BattleUIController)LuaObject.checkSelf(l);
			battleUIController.m_luaExportHelper.OnBindFiledsCompleted();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601C116 RID: 114966 RVA: 0x008A1AB8 File Offset: 0x0089FCB8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int Update(IntPtr l)
	{
		int result;
		try
		{
			BattleUIController battleUIController = (BattleUIController)LuaObject.checkSelf(l);
			battleUIController.m_luaExportHelper.Update();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601C117 RID: 114967 RVA: 0x008A1B0C File Offset: 0x0089FD0C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int WinOrLoseTweenFinished(IntPtr l)
	{
		int result;
		try
		{
			BattleUIController battleUIController = (BattleUIController)LuaObject.checkSelf(l);
			battleUIController.m_luaExportHelper.WinOrLoseTweenFinished();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601C118 RID: 114968 RVA: 0x008A1B60 File Offset: 0x0089FD60
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int HideArmyRelation(IntPtr l)
	{
		int result;
		try
		{
			BattleUIController battleUIController = (BattleUIController)LuaObject.checkSelf(l);
			battleUIController.m_luaExportHelper.HideArmyRelation();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601C119 RID: 114969 RVA: 0x008A1BB4 File Offset: 0x0089FDB4
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int HideCutsceneSkill(IntPtr l)
	{
		int result;
		try
		{
			BattleUIController battleUIController = (BattleUIController)LuaObject.checkSelf(l);
			battleUIController.m_luaExportHelper.HideCutsceneSkill();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601C11A RID: 114970 RVA: 0x008A1C08 File Offset: 0x0089FE08
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int OnPauseButtonClick(IntPtr l)
	{
		int result;
		try
		{
			BattleUIController battleUIController = (BattleUIController)LuaObject.checkSelf(l);
			battleUIController.m_luaExportHelper.OnPauseButtonClick();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601C11B RID: 114971 RVA: 0x008A1C5C File Offset: 0x0089FE5C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int OnArmyRelationButtonClick(IntPtr l)
	{
		int result;
		try
		{
			BattleUIController battleUIController = (BattleUIController)LuaObject.checkSelf(l);
			battleUIController.m_luaExportHelper.OnArmyRelationButtonClick();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601C11C RID: 114972 RVA: 0x008A1CB0 File Offset: 0x0089FEB0
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int OnAutoButtonClick(IntPtr l)
	{
		int result;
		try
		{
			BattleUIController battleUIController = (BattleUIController)LuaObject.checkSelf(l);
			battleUIController.m_luaExportHelper.OnAutoButtonClick();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601C11D RID: 114973 RVA: 0x008A1D04 File Offset: 0x0089FF04
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int OnAutoOffButtonClick(IntPtr l)
	{
		int result;
		try
		{
			BattleUIController battleUIController = (BattleUIController)LuaObject.checkSelf(l);
			battleUIController.m_luaExportHelper.OnAutoOffButtonClick();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601C11E RID: 114974 RVA: 0x008A1D58 File Offset: 0x0089FF58
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int OnArenaAutoButtonClick(IntPtr l)
	{
		int result;
		try
		{
			BattleUIController battleUIController = (BattleUIController)LuaObject.checkSelf(l);
			battleUIController.m_luaExportHelper.OnArenaAutoButtonClick();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601C11F RID: 114975 RVA: 0x008A1DAC File Offset: 0x0089FFAC
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int OnFastButtonClick(IntPtr l)
	{
		int result;
		try
		{
			BattleUIController battleUIController = (BattleUIController)LuaObject.checkSelf(l);
			battleUIController.m_luaExportHelper.OnFastButtonClick();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601C120 RID: 114976 RVA: 0x008A1E00 File Offset: 0x008A0000
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int OnSkipCombatButtonClick(IntPtr l)
	{
		int result;
		try
		{
			BattleUIController battleUIController = (BattleUIController)LuaObject.checkSelf(l);
			battleUIController.m_luaExportHelper.OnSkipCombatButtonClick();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601C121 RID: 114977 RVA: 0x008A1E54 File Offset: 0x008A0054
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int OnDangerOnButtonClick(IntPtr l)
	{
		int result;
		try
		{
			BattleUIController battleUIController = (BattleUIController)LuaObject.checkSelf(l);
			battleUIController.m_luaExportHelper.OnDangerOnButtonClick();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601C122 RID: 114978 RVA: 0x008A1EA8 File Offset: 0x008A00A8
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int OnDangerOffButtonClick(IntPtr l)
	{
		int result;
		try
		{
			BattleUIController battleUIController = (BattleUIController)LuaObject.checkSelf(l);
			battleUIController.m_luaExportHelper.OnDangerOffButtonClick();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601C123 RID: 114979 RVA: 0x008A1EFC File Offset: 0x008A00FC
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int OnEndActionButtonClick(IntPtr l)
	{
		int result;
		try
		{
			BattleUIController battleUIController = (BattleUIController)LuaObject.checkSelf(l);
			battleUIController.m_luaExportHelper.OnEndActionButtonClick();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601C124 RID: 114980 RVA: 0x008A1F50 File Offset: 0x008A0150
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int OnEndAllActionButtonClick(IntPtr l)
	{
		int result;
		try
		{
			BattleUIController battleUIController = (BattleUIController)LuaObject.checkSelf(l);
			battleUIController.m_luaExportHelper.OnEndAllActionButtonClick();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601C125 RID: 114981 RVA: 0x008A1FA4 File Offset: 0x008A01A4
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int OnActorSimpleInfoButtonClick(IntPtr l)
	{
		int result;
		try
		{
			BattleUIController battleUIController = (BattleUIController)LuaObject.checkSelf(l);
			battleUIController.m_luaExportHelper.OnActorSimpleInfoButtonClick();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601C126 RID: 114982 RVA: 0x008A1FF8 File Offset: 0x008A01F8
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int OnUseSkillButtonClick(IntPtr l)
	{
		int result;
		try
		{
			BattleUIController battleUIController = (BattleUIController)LuaObject.checkSelf(l);
			battleUIController.m_luaExportHelper.OnUseSkillButtonClick();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601C127 RID: 114983 RVA: 0x008A204C File Offset: 0x008A024C
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int OnCancelSkillButtonClick(IntPtr l)
	{
		int result;
		try
		{
			BattleUIController battleUIController = (BattleUIController)LuaObject.checkSelf(l);
			battleUIController.m_luaExportHelper.OnCancelSkillButtonClick();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601C128 RID: 114984 RVA: 0x008A20A0 File Offset: 0x008A02A0
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int BattleSkillButton_OnClick(IntPtr l)
	{
		int result;
		try
		{
			BattleUIController battleUIController = (BattleUIController)LuaObject.checkSelf(l);
			BattleSkillButton sb;
			LuaObject.checkType<BattleSkillButton>(l, 2, out sb);
			battleUIController.m_luaExportHelper.BattleSkillButton_OnClick(sb);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601C129 RID: 114985 RVA: 0x008A20FC File Offset: 0x008A02FC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int OnChatButtonClick(IntPtr l)
	{
		int result;
		try
		{
			BattleUIController battleUIController = (BattleUIController)LuaObject.checkSelf(l);
			battleUIController.m_luaExportHelper.OnChatButtonClick();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601C12A RID: 114986 RVA: 0x008A2150 File Offset: 0x008A0350
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int OnHelpButtonClick(IntPtr l)
	{
		int result;
		try
		{
			BattleUIController battleUIController = (BattleUIController)LuaObject.checkSelf(l);
			battleUIController.m_luaExportHelper.OnHelpButtonClick();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601C12B RID: 114987 RVA: 0x008A21A4 File Offset: 0x008A03A4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int OnTerrainInfoButtonClick(IntPtr l)
	{
		int result;
		try
		{
			BattleUIController battleUIController = (BattleUIController)LuaObject.checkSelf(l);
			battleUIController.m_luaExportHelper.OnTerrainInfoButtonClick();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601C12C RID: 114988 RVA: 0x008A21F8 File Offset: 0x008A03F8
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int DeveloperModeClick(IntPtr l)
	{
		int result;
		try
		{
			BattleUIController battleUIController = (BattleUIController)LuaObject.checkSelf(l);
			battleUIController.m_luaExportHelper.DeveloperModeClick();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601C12D RID: 114989 RVA: 0x008A224C File Offset: 0x008A044C
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int OnDanmakuToggleValueChanged(IntPtr l)
	{
		int result;
		try
		{
			BattleUIController battleUIController = (BattleUIController)LuaObject.checkSelf(l);
			bool isOn;
			LuaObject.checkType(l, 2, out isOn);
			battleUIController.m_luaExportHelper.OnDanmakuToggleValueChanged(isOn);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601C12E RID: 114990 RVA: 0x008A22A8 File Offset: 0x008A04A8
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int OnDanmakuInputWordButtonClick(IntPtr l)
	{
		int result;
		try
		{
			BattleUIController battleUIController = (BattleUIController)LuaObject.checkSelf(l);
			battleUIController.m_luaExportHelper.OnDanmakuInputWordButtonClick();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601C12F RID: 114991 RVA: 0x008A22FC File Offset: 0x008A04FC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int OnDanmakuInputBackButtonClick(IntPtr l)
	{
		int result;
		try
		{
			BattleUIController battleUIController = (BattleUIController)LuaObject.checkSelf(l);
			battleUIController.m_luaExportHelper.OnDanmakuInputBackButtonClick();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601C130 RID: 114992 RVA: 0x008A2350 File Offset: 0x008A0550
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int OnDanmakuSendButtonClick(IntPtr l)
	{
		int result;
		try
		{
			BattleUIController battleUIController = (BattleUIController)LuaObject.checkSelf(l);
			battleUIController.m_luaExportHelper.OnDanmakuSendButtonClick();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601C131 RID: 114993 RVA: 0x008A23A4 File Offset: 0x008A05A4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int OnRegretButtonClick(IntPtr l)
	{
		int result;
		try
		{
			BattleUIController battleUIController = (BattleUIController)LuaObject.checkSelf(l);
			battleUIController.m_luaExportHelper.OnRegretButtonClick();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601C132 RID: 114994 RVA: 0x008A23F8 File Offset: 0x008A05F8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int OnRegretConfirmButtonClick(IntPtr l)
	{
		int result;
		try
		{
			BattleUIController battleUIController = (BattleUIController)LuaObject.checkSelf(l);
			battleUIController.m_luaExportHelper.OnRegretConfirmButtonClick();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601C133 RID: 114995 RVA: 0x008A244C File Offset: 0x008A064C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int OnRegretCancelButtonClick(IntPtr l)
	{
		int result;
		try
		{
			BattleUIController battleUIController = (BattleUIController)LuaObject.checkSelf(l);
			battleUIController.m_luaExportHelper.OnRegretCancelButtonClick();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601C134 RID: 114996 RVA: 0x008A24A0 File Offset: 0x008A06A0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int OnRegretBackwardButtonClick(IntPtr l)
	{
		int result;
		try
		{
			BattleUIController battleUIController = (BattleUIController)LuaObject.checkSelf(l);
			battleUIController.m_luaExportHelper.OnRegretBackwardButtonClick();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601C135 RID: 114997 RVA: 0x008A24F4 File Offset: 0x008A06F4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int OnRegretForwardButtonClick(IntPtr l)
	{
		int result;
		try
		{
			BattleUIController battleUIController = (BattleUIController)LuaObject.checkSelf(l);
			battleUIController.m_luaExportHelper.OnRegretForwardButtonClick();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601C136 RID: 114998 RVA: 0x008A2548 File Offset: 0x008A0748
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_Initlize(IntPtr l)
	{
		int result;
		try
		{
			BattleUIController battleUIController = (BattleUIController)LuaObject.checkSelf(l);
			string ctrlName;
			LuaObject.checkType(l, 2, out ctrlName);
			bool bindNow;
			LuaObject.checkType(l, 3, out bindNow);
			battleUIController.m_luaExportHelper.__callBase_Initlize(ctrlName, bindNow);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601C137 RID: 114999 RVA: 0x008A25B4 File Offset: 0x008A07B4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_BindFields(IntPtr l)
	{
		int result;
		try
		{
			BattleUIController battleUIController = (BattleUIController)LuaObject.checkSelf(l);
			battleUIController.m_luaExportHelper.__callBase_BindFields();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601C138 RID: 115000 RVA: 0x008A2608 File Offset: 0x008A0808
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_OnBindFiledsCompleted(IntPtr l)
	{
		int result;
		try
		{
			BattleUIController battleUIController = (BattleUIController)LuaObject.checkSelf(l);
			battleUIController.m_luaExportHelper.__callBase_OnBindFiledsCompleted();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601C139 RID: 115001 RVA: 0x008A265C File Offset: 0x008A085C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_BindFieldImpl(IntPtr l)
	{
		int result;
		try
		{
			BattleUIController battleUIController = (BattleUIController)LuaObject.checkSelf(l);
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
			UnityEngine.Object o = battleUIController.m_luaExportHelper.__callBase_BindFieldImpl(fieldType, path, initState, fieldName, ctrlName, optional);
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

	// Token: 0x0601C13A RID: 115002 RVA: 0x008A2704 File Offset: 0x008A0904
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_Clear(IntPtr l)
	{
		int result;
		try
		{
			BattleUIController battleUIController = (BattleUIController)LuaObject.checkSelf(l);
			battleUIController.m_luaExportHelper.__callBase_Clear();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601C13B RID: 115003 RVA: 0x008A2758 File Offset: 0x008A0958
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_OnButtonClick(IntPtr l)
	{
		int result;
		try
		{
			BattleUIController battleUIController = (BattleUIController)LuaObject.checkSelf(l);
			Button button;
			LuaObject.checkType<Button>(l, 2, out button);
			string fieldName;
			LuaObject.checkType(l, 3, out fieldName);
			battleUIController.m_luaExportHelper.__callBase_OnButtonClick(button, fieldName);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601C13C RID: 115004 RVA: 0x008A27C4 File Offset: 0x008A09C4
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
				BattleUIController battleUIController = (BattleUIController)LuaObject.checkSelf(l);
				string[] fieldNames;
				LuaObject.checkArray<string>(l, 2, out fieldNames);
				Action<UIControllerBase> action;
				LuaObject.checkDelegate<Action<UIControllerBase>>(l, 3, out action);
				battleUIController.m_luaExportHelper.__callBase_SetButtonClickListener(fieldNames, action);
				LuaObject.pushValue(l, true);
				result = 1;
			}
			else if (LuaObject.matchType(l, total, 2, typeof(string), typeof(Action<UIControllerBase>)))
			{
				BattleUIController battleUIController2 = (BattleUIController)LuaObject.checkSelf(l);
				string fieldName;
				LuaObject.checkType(l, 2, out fieldName);
				Action<UIControllerBase> action2;
				LuaObject.checkDelegate<Action<UIControllerBase>>(l, 3, out action2);
				battleUIController2.m_luaExportHelper.__callBase_SetButtonClickListener(fieldName, action2);
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

	// Token: 0x0601C13D RID: 115005 RVA: 0x008A28D4 File Offset: 0x008A0AD4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_SetButtonDoubleClickListener(IntPtr l)
	{
		int result;
		try
		{
			BattleUIController battleUIController = (BattleUIController)LuaObject.checkSelf(l);
			string fieldName;
			LuaObject.checkType(l, 2, out fieldName);
			Action<UIControllerBase> action;
			LuaObject.checkDelegate<Action<UIControllerBase>>(l, 3, out action);
			battleUIController.m_luaExportHelper.__callBase_SetButtonDoubleClickListener(fieldName, action);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601C13E RID: 115006 RVA: 0x008A2940 File Offset: 0x008A0B40
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_SetButtonLongPressStartListener(IntPtr l)
	{
		int result;
		try
		{
			BattleUIController battleUIController = (BattleUIController)LuaObject.checkSelf(l);
			string fieldName;
			LuaObject.checkType(l, 2, out fieldName);
			Action<UIControllerBase> action;
			LuaObject.checkDelegate<Action<UIControllerBase>>(l, 3, out action);
			battleUIController.m_luaExportHelper.__callBase_SetButtonLongPressStartListener(fieldName, action);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601C13F RID: 115007 RVA: 0x008A29AC File Offset: 0x008A0BAC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_SetButtonLongPressingListener(IntPtr l)
	{
		int result;
		try
		{
			BattleUIController battleUIController = (BattleUIController)LuaObject.checkSelf(l);
			string fieldName;
			LuaObject.checkType(l, 2, out fieldName);
			Action<UIControllerBase> action;
			LuaObject.checkDelegate<Action<UIControllerBase>>(l, 3, out action);
			battleUIController.m_luaExportHelper.__callBase_SetButtonLongPressingListener(fieldName, action);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601C140 RID: 115008 RVA: 0x008A2A18 File Offset: 0x008A0C18
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_SetButtonLongPressEndListener(IntPtr l)
	{
		int result;
		try
		{
			BattleUIController battleUIController = (BattleUIController)LuaObject.checkSelf(l);
			string fieldName;
			LuaObject.checkType(l, 2, out fieldName);
			Action<UIControllerBase> action;
			LuaObject.checkDelegate<Action<UIControllerBase>>(l, 3, out action);
			battleUIController.m_luaExportHelper.__callBase_SetButtonLongPressEndListener(fieldName, action);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601C141 RID: 115009 RVA: 0x008A2A84 File Offset: 0x008A0C84
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
				BattleUIController battleUIController = (BattleUIController)LuaObject.checkSelf(l);
				string[] fieldNames;
				LuaObject.checkArray<string>(l, 2, out fieldNames);
				Action<UIControllerBase, bool> action;
				LuaObject.checkDelegate<Action<UIControllerBase, bool>>(l, 3, out action);
				battleUIController.m_luaExportHelper.__callBase_SetToggleValueChangedListener(fieldNames, action);
				LuaObject.pushValue(l, true);
				result = 1;
			}
			else if (LuaObject.matchType(l, total, 2, typeof(string), typeof(Action<UIControllerBase, bool>)))
			{
				BattleUIController battleUIController2 = (BattleUIController)LuaObject.checkSelf(l);
				string fieldName;
				LuaObject.checkType(l, 2, out fieldName);
				Action<UIControllerBase, bool> action2;
				LuaObject.checkDelegate<Action<UIControllerBase, bool>>(l, 3, out action2);
				battleUIController2.m_luaExportHelper.__callBase_SetToggleValueChangedListener(fieldName, action2);
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

	// Token: 0x0601C142 RID: 115010 RVA: 0x008A2B94 File Offset: 0x008A0D94
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_ToString(IntPtr l)
	{
		int result;
		try
		{
			BattleUIController battleUIController = (BattleUIController)LuaObject.checkSelf(l);
			string s = battleUIController.m_luaExportHelper.__callBase_ToString();
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

	// Token: 0x0601C143 RID: 115011 RVA: 0x008A2BF0 File Offset: 0x008A0DF0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callDele_EventOnPauseBattle(IntPtr l)
	{
		int result;
		try
		{
			BattleUIController battleUIController = (BattleUIController)LuaObject.checkSelf(l);
			battleUIController.m_luaExportHelper.__callDele_EventOnPauseBattle();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601C144 RID: 115012 RVA: 0x008A2C44 File Offset: 0x008A0E44
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __clearDele_EventOnPauseBattle(IntPtr l)
	{
		int result;
		try
		{
			BattleUIController battleUIController = (BattleUIController)LuaObject.checkSelf(l);
			battleUIController.m_luaExportHelper.__clearDele_EventOnPauseBattle();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601C145 RID: 115013 RVA: 0x008A2C98 File Offset: 0x008A0E98
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callDele_EventOnShowArmyRelation(IntPtr l)
	{
		int result;
		try
		{
			BattleUIController battleUIController = (BattleUIController)LuaObject.checkSelf(l);
			battleUIController.m_luaExportHelper.__callDele_EventOnShowArmyRelation();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601C146 RID: 115014 RVA: 0x008A2CEC File Offset: 0x008A0EEC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __clearDele_EventOnShowArmyRelation(IntPtr l)
	{
		int result;
		try
		{
			BattleUIController battleUIController = (BattleUIController)LuaObject.checkSelf(l);
			battleUIController.m_luaExportHelper.__clearDele_EventOnShowArmyRelation();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601C147 RID: 115015 RVA: 0x008A2D40 File Offset: 0x008A0F40
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callDele_EventOnAutoBattle(IntPtr l)
	{
		int result;
		try
		{
			BattleUIController battleUIController = (BattleUIController)LuaObject.checkSelf(l);
			bool obj;
			LuaObject.checkType(l, 2, out obj);
			battleUIController.m_luaExportHelper.__callDele_EventOnAutoBattle(obj);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601C148 RID: 115016 RVA: 0x008A2D9C File Offset: 0x008A0F9C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __clearDele_EventOnAutoBattle(IntPtr l)
	{
		int result;
		try
		{
			BattleUIController battleUIController = (BattleUIController)LuaObject.checkSelf(l);
			bool obj;
			LuaObject.checkType(l, 2, out obj);
			battleUIController.m_luaExportHelper.__clearDele_EventOnAutoBattle(obj);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601C149 RID: 115017 RVA: 0x008A2DF8 File Offset: 0x008A0FF8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callDele_EventOnFastBattle(IntPtr l)
	{
		int result;
		try
		{
			BattleUIController battleUIController = (BattleUIController)LuaObject.checkSelf(l);
			bool obj;
			LuaObject.checkType(l, 2, out obj);
			battleUIController.m_luaExportHelper.__callDele_EventOnFastBattle(obj);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601C14A RID: 115018 RVA: 0x008A2E54 File Offset: 0x008A1054
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __clearDele_EventOnFastBattle(IntPtr l)
	{
		int result;
		try
		{
			BattleUIController battleUIController = (BattleUIController)LuaObject.checkSelf(l);
			bool obj;
			LuaObject.checkType(l, 2, out obj);
			battleUIController.m_luaExportHelper.__clearDele_EventOnFastBattle(obj);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601C14B RID: 115019 RVA: 0x008A2EB0 File Offset: 0x008A10B0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callDele_EventOnSkipCombat(IntPtr l)
	{
		int result;
		try
		{
			BattleUIController battleUIController = (BattleUIController)LuaObject.checkSelf(l);
			SkipCombatMode obj;
			LuaObject.checkEnum<SkipCombatMode>(l, 2, out obj);
			battleUIController.m_luaExportHelper.__callDele_EventOnSkipCombat(obj);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601C14C RID: 115020 RVA: 0x008A2F0C File Offset: 0x008A110C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __clearDele_EventOnSkipCombat(IntPtr l)
	{
		int result;
		try
		{
			BattleUIController battleUIController = (BattleUIController)LuaObject.checkSelf(l);
			SkipCombatMode obj;
			LuaObject.checkEnum<SkipCombatMode>(l, 2, out obj);
			battleUIController.m_luaExportHelper.__clearDele_EventOnSkipCombat(obj);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601C14D RID: 115021 RVA: 0x008A2F68 File Offset: 0x008A1168
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callDele_EventOnShowDanger(IntPtr l)
	{
		int result;
		try
		{
			BattleUIController battleUIController = (BattleUIController)LuaObject.checkSelf(l);
			bool obj;
			LuaObject.checkType(l, 2, out obj);
			battleUIController.m_luaExportHelper.__callDele_EventOnShowDanger(obj);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601C14E RID: 115022 RVA: 0x008A2FC4 File Offset: 0x008A11C4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __clearDele_EventOnShowDanger(IntPtr l)
	{
		int result;
		try
		{
			BattleUIController battleUIController = (BattleUIController)LuaObject.checkSelf(l);
			bool obj;
			LuaObject.checkType(l, 2, out obj);
			battleUIController.m_luaExportHelper.__clearDele_EventOnShowDanger(obj);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601C14F RID: 115023 RVA: 0x008A3020 File Offset: 0x008A1220
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callDele_EventOnEndAction(IntPtr l)
	{
		int result;
		try
		{
			BattleUIController battleUIController = (BattleUIController)LuaObject.checkSelf(l);
			battleUIController.m_luaExportHelper.__callDele_EventOnEndAction();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601C150 RID: 115024 RVA: 0x008A3074 File Offset: 0x008A1274
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __clearDele_EventOnEndAction(IntPtr l)
	{
		int result;
		try
		{
			BattleUIController battleUIController = (BattleUIController)LuaObject.checkSelf(l);
			battleUIController.m_luaExportHelper.__clearDele_EventOnEndAction();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601C151 RID: 115025 RVA: 0x008A30C8 File Offset: 0x008A12C8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callDele_EventOnShowActorInfo(IntPtr l)
	{
		int result;
		try
		{
			BattleUIController battleUIController = (BattleUIController)LuaObject.checkSelf(l);
			battleUIController.m_luaExportHelper.__callDele_EventOnShowActorInfo();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601C152 RID: 115026 RVA: 0x008A311C File Offset: 0x008A131C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __clearDele_EventOnShowActorInfo(IntPtr l)
	{
		int result;
		try
		{
			BattleUIController battleUIController = (BattleUIController)LuaObject.checkSelf(l);
			battleUIController.m_luaExportHelper.__clearDele_EventOnShowActorInfo();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601C153 RID: 115027 RVA: 0x008A3170 File Offset: 0x008A1370
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callDele_EventOnEndAllAction(IntPtr l)
	{
		int result;
		try
		{
			BattleUIController battleUIController = (BattleUIController)LuaObject.checkSelf(l);
			battleUIController.m_luaExportHelper.__callDele_EventOnEndAllAction();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601C154 RID: 115028 RVA: 0x008A31C4 File Offset: 0x008A13C4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __clearDele_EventOnEndAllAction(IntPtr l)
	{
		int result;
		try
		{
			BattleUIController battleUIController = (BattleUIController)LuaObject.checkSelf(l);
			battleUIController.m_luaExportHelper.__clearDele_EventOnEndAllAction();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601C155 RID: 115029 RVA: 0x008A3218 File Offset: 0x008A1418
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callDele_EventOnUseSkill(IntPtr l)
	{
		int result;
		try
		{
			BattleUIController battleUIController = (BattleUIController)LuaObject.checkSelf(l);
			battleUIController.m_luaExportHelper.__callDele_EventOnUseSkill();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601C156 RID: 115030 RVA: 0x008A326C File Offset: 0x008A146C
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int __clearDele_EventOnUseSkill(IntPtr l)
	{
		int result;
		try
		{
			BattleUIController battleUIController = (BattleUIController)LuaObject.checkSelf(l);
			battleUIController.m_luaExportHelper.__clearDele_EventOnUseSkill();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601C157 RID: 115031 RVA: 0x008A32C0 File Offset: 0x008A14C0
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int __callDele_EventOnCancelSkill(IntPtr l)
	{
		int result;
		try
		{
			BattleUIController battleUIController = (BattleUIController)LuaObject.checkSelf(l);
			battleUIController.m_luaExportHelper.__callDele_EventOnCancelSkill();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601C158 RID: 115032 RVA: 0x008A3314 File Offset: 0x008A1514
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __clearDele_EventOnCancelSkill(IntPtr l)
	{
		int result;
		try
		{
			BattleUIController battleUIController = (BattleUIController)LuaObject.checkSelf(l);
			battleUIController.m_luaExportHelper.__clearDele_EventOnCancelSkill();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601C159 RID: 115033 RVA: 0x008A3368 File Offset: 0x008A1568
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int __callDele_EventOnWinOrLoseEnd(IntPtr l)
	{
		int result;
		try
		{
			BattleUIController battleUIController = (BattleUIController)LuaObject.checkSelf(l);
			battleUIController.m_luaExportHelper.__callDele_EventOnWinOrLoseEnd();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601C15A RID: 115034 RVA: 0x008A33BC File Offset: 0x008A15BC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __clearDele_EventOnWinOrLoseEnd(IntPtr l)
	{
		int result;
		try
		{
			BattleUIController battleUIController = (BattleUIController)LuaObject.checkSelf(l);
			battleUIController.m_luaExportHelper.__clearDele_EventOnWinOrLoseEnd();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601C15B RID: 115035 RVA: 0x008A3410 File Offset: 0x008A1610
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callDele_EventOnShowChat(IntPtr l)
	{
		int result;
		try
		{
			BattleUIController battleUIController = (BattleUIController)LuaObject.checkSelf(l);
			battleUIController.m_luaExportHelper.__callDele_EventOnShowChat();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601C15C RID: 115036 RVA: 0x008A3464 File Offset: 0x008A1664
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __clearDele_EventOnShowChat(IntPtr l)
	{
		int result;
		try
		{
			BattleUIController battleUIController = (BattleUIController)LuaObject.checkSelf(l);
			battleUIController.m_luaExportHelper.__clearDele_EventOnShowChat();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601C15D RID: 115037 RVA: 0x008A34B8 File Offset: 0x008A16B8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callDele_EventOnShowHelp(IntPtr l)
	{
		int result;
		try
		{
			BattleUIController battleUIController = (BattleUIController)LuaObject.checkSelf(l);
			battleUIController.m_luaExportHelper.__callDele_EventOnShowHelp();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601C15E RID: 115038 RVA: 0x008A350C File Offset: 0x008A170C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __clearDele_EventOnShowHelp(IntPtr l)
	{
		int result;
		try
		{
			BattleUIController battleUIController = (BattleUIController)LuaObject.checkSelf(l);
			battleUIController.m_luaExportHelper.__clearDele_EventOnShowHelp();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601C15F RID: 115039 RVA: 0x008A3560 File Offset: 0x008A1760
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callDele_EventOnSelectSkill(IntPtr l)
	{
		int result;
		try
		{
			BattleUIController battleUIController = (BattleUIController)LuaObject.checkSelf(l);
			int obj;
			LuaObject.checkType(l, 2, out obj);
			battleUIController.m_luaExportHelper.__callDele_EventOnSelectSkill(obj);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601C160 RID: 115040 RVA: 0x008A35BC File Offset: 0x008A17BC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __clearDele_EventOnSelectSkill(IntPtr l)
	{
		int result;
		try
		{
			BattleUIController battleUIController = (BattleUIController)LuaObject.checkSelf(l);
			int obj;
			LuaObject.checkType(l, 2, out obj);
			battleUIController.m_luaExportHelper.__clearDele_EventOnSelectSkill(obj);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601C161 RID: 115041 RVA: 0x008A3618 File Offset: 0x008A1818
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callDele_EventOnPointerDown(IntPtr l)
	{
		int result;
		try
		{
			BattleUIController battleUIController = (BattleUIController)LuaObject.checkSelf(l);
			PointerEventData.InputButton arg;
			LuaObject.checkEnum<PointerEventData.InputButton>(l, 2, out arg);
			Vector2 arg2;
			LuaObject.checkType(l, 3, out arg2);
			battleUIController.m_luaExportHelper.__callDele_EventOnPointerDown(arg, arg2);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601C162 RID: 115042 RVA: 0x008A3684 File Offset: 0x008A1884
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __clearDele_EventOnPointerDown(IntPtr l)
	{
		int result;
		try
		{
			BattleUIController battleUIController = (BattleUIController)LuaObject.checkSelf(l);
			PointerEventData.InputButton arg;
			LuaObject.checkEnum<PointerEventData.InputButton>(l, 2, out arg);
			Vector2 arg2;
			LuaObject.checkType(l, 3, out arg2);
			battleUIController.m_luaExportHelper.__clearDele_EventOnPointerDown(arg, arg2);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601C163 RID: 115043 RVA: 0x008A36F0 File Offset: 0x008A18F0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callDele_EventOnPointerUp(IntPtr l)
	{
		int result;
		try
		{
			BattleUIController battleUIController = (BattleUIController)LuaObject.checkSelf(l);
			PointerEventData.InputButton arg;
			LuaObject.checkEnum<PointerEventData.InputButton>(l, 2, out arg);
			Vector2 arg2;
			LuaObject.checkType(l, 3, out arg2);
			battleUIController.m_luaExportHelper.__callDele_EventOnPointerUp(arg, arg2);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601C164 RID: 115044 RVA: 0x008A375C File Offset: 0x008A195C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __clearDele_EventOnPointerUp(IntPtr l)
	{
		int result;
		try
		{
			BattleUIController battleUIController = (BattleUIController)LuaObject.checkSelf(l);
			PointerEventData.InputButton arg;
			LuaObject.checkEnum<PointerEventData.InputButton>(l, 2, out arg);
			Vector2 arg2;
			LuaObject.checkType(l, 3, out arg2);
			battleUIController.m_luaExportHelper.__clearDele_EventOnPointerUp(arg, arg2);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601C165 RID: 115045 RVA: 0x008A37C8 File Offset: 0x008A19C8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callDele_EventOnPointerClick(IntPtr l)
	{
		int result;
		try
		{
			BattleUIController battleUIController = (BattleUIController)LuaObject.checkSelf(l);
			PointerEventData.InputButton arg;
			LuaObject.checkEnum<PointerEventData.InputButton>(l, 2, out arg);
			Vector2 arg2;
			LuaObject.checkType(l, 3, out arg2);
			battleUIController.m_luaExportHelper.__callDele_EventOnPointerClick(arg, arg2);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601C166 RID: 115046 RVA: 0x008A3834 File Offset: 0x008A1A34
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int __clearDele_EventOnPointerClick(IntPtr l)
	{
		int result;
		try
		{
			BattleUIController battleUIController = (BattleUIController)LuaObject.checkSelf(l);
			PointerEventData.InputButton arg;
			LuaObject.checkEnum<PointerEventData.InputButton>(l, 2, out arg);
			Vector2 arg2;
			LuaObject.checkType(l, 3, out arg2);
			battleUIController.m_luaExportHelper.__clearDele_EventOnPointerClick(arg, arg2);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601C167 RID: 115047 RVA: 0x008A38A0 File Offset: 0x008A1AA0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callDele_EventOn3DTouch(IntPtr l)
	{
		int result;
		try
		{
			BattleUIController battleUIController = (BattleUIController)LuaObject.checkSelf(l);
			Vector2 obj;
			LuaObject.checkType(l, 2, out obj);
			battleUIController.m_luaExportHelper.__callDele_EventOn3DTouch(obj);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601C168 RID: 115048 RVA: 0x008A38FC File Offset: 0x008A1AFC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __clearDele_EventOn3DTouch(IntPtr l)
	{
		int result;
		try
		{
			BattleUIController battleUIController = (BattleUIController)LuaObject.checkSelf(l);
			Vector2 obj;
			LuaObject.checkType(l, 2, out obj);
			battleUIController.m_luaExportHelper.__clearDele_EventOn3DTouch(obj);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601C169 RID: 115049 RVA: 0x008A3958 File Offset: 0x008A1B58
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callDele_EventOnShowCurTurnDanmaku(IntPtr l)
	{
		int result;
		try
		{
			BattleUIController battleUIController = (BattleUIController)LuaObject.checkSelf(l);
			int obj;
			LuaObject.checkType(l, 2, out obj);
			battleUIController.m_luaExportHelper.__callDele_EventOnShowCurTurnDanmaku(obj);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601C16A RID: 115050 RVA: 0x008A39B4 File Offset: 0x008A1BB4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __clearDele_EventOnShowCurTurnDanmaku(IntPtr l)
	{
		int result;
		try
		{
			BattleUIController battleUIController = (BattleUIController)LuaObject.checkSelf(l);
			int obj;
			LuaObject.checkType(l, 2, out obj);
			battleUIController.m_luaExportHelper.__clearDele_EventOnShowCurTurnDanmaku(obj);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601C16B RID: 115051 RVA: 0x008A3A10 File Offset: 0x008A1C10
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callDele_EventOnCloseCurTurnDanmaku(IntPtr l)
	{
		int result;
		try
		{
			BattleUIController battleUIController = (BattleUIController)LuaObject.checkSelf(l);
			battleUIController.m_luaExportHelper.__callDele_EventOnCloseCurTurnDanmaku();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601C16C RID: 115052 RVA: 0x008A3A64 File Offset: 0x008A1C64
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __clearDele_EventOnCloseCurTurnDanmaku(IntPtr l)
	{
		int result;
		try
		{
			BattleUIController battleUIController = (BattleUIController)LuaObject.checkSelf(l);
			battleUIController.m_luaExportHelper.__clearDele_EventOnCloseCurTurnDanmaku();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601C16D RID: 115053 RVA: 0x008A3AB8 File Offset: 0x008A1CB8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callDele_EventOnShowOneDanmaku(IntPtr l)
	{
		int result;
		try
		{
			BattleUIController battleUIController = (BattleUIController)LuaObject.checkSelf(l);
			DanmakuEntry obj;
			LuaObject.checkType<DanmakuEntry>(l, 2, out obj);
			battleUIController.m_luaExportHelper.__callDele_EventOnShowOneDanmaku(obj);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601C16E RID: 115054 RVA: 0x008A3B14 File Offset: 0x008A1D14
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __clearDele_EventOnShowOneDanmaku(IntPtr l)
	{
		int result;
		try
		{
			BattleUIController battleUIController = (BattleUIController)LuaObject.checkSelf(l);
			DanmakuEntry obj;
			LuaObject.checkType<DanmakuEntry>(l, 2, out obj);
			battleUIController.m_luaExportHelper.__clearDele_EventOnShowOneDanmaku(obj);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601C16F RID: 115055 RVA: 0x008A3B70 File Offset: 0x008A1D70
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callDele_EventOnRegretActive(IntPtr l)
	{
		int result;
		try
		{
			BattleUIController battleUIController = (BattleUIController)LuaObject.checkSelf(l);
			battleUIController.m_luaExportHelper.__callDele_EventOnRegretActive();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601C170 RID: 115056 RVA: 0x008A3BC4 File Offset: 0x008A1DC4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __clearDele_EventOnRegretActive(IntPtr l)
	{
		int result;
		try
		{
			BattleUIController battleUIController = (BattleUIController)LuaObject.checkSelf(l);
			battleUIController.m_luaExportHelper.__clearDele_EventOnRegretActive();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601C171 RID: 115057 RVA: 0x008A3C18 File Offset: 0x008A1E18
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callDele_EventOnRegretConfirm(IntPtr l)
	{
		int result;
		try
		{
			BattleUIController battleUIController = (BattleUIController)LuaObject.checkSelf(l);
			battleUIController.m_luaExportHelper.__callDele_EventOnRegretConfirm();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601C172 RID: 115058 RVA: 0x008A3C6C File Offset: 0x008A1E6C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __clearDele_EventOnRegretConfirm(IntPtr l)
	{
		int result;
		try
		{
			BattleUIController battleUIController = (BattleUIController)LuaObject.checkSelf(l);
			battleUIController.m_luaExportHelper.__clearDele_EventOnRegretConfirm();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601C173 RID: 115059 RVA: 0x008A3CC0 File Offset: 0x008A1EC0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callDele_EventOnRegretCancel(IntPtr l)
	{
		int result;
		try
		{
			BattleUIController battleUIController = (BattleUIController)LuaObject.checkSelf(l);
			battleUIController.m_luaExportHelper.__callDele_EventOnRegretCancel();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601C174 RID: 115060 RVA: 0x008A3D14 File Offset: 0x008A1F14
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __clearDele_EventOnRegretCancel(IntPtr l)
	{
		int result;
		try
		{
			BattleUIController battleUIController = (BattleUIController)LuaObject.checkSelf(l);
			battleUIController.m_luaExportHelper.__clearDele_EventOnRegretCancel();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601C175 RID: 115061 RVA: 0x008A3D68 File Offset: 0x008A1F68
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callDele_EventOnRegretBackward(IntPtr l)
	{
		int result;
		try
		{
			BattleUIController battleUIController = (BattleUIController)LuaObject.checkSelf(l);
			battleUIController.m_luaExportHelper.__callDele_EventOnRegretBackward();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601C176 RID: 115062 RVA: 0x008A3DBC File Offset: 0x008A1FBC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __clearDele_EventOnRegretBackward(IntPtr l)
	{
		int result;
		try
		{
			BattleUIController battleUIController = (BattleUIController)LuaObject.checkSelf(l);
			battleUIController.m_luaExportHelper.__clearDele_EventOnRegretBackward();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601C177 RID: 115063 RVA: 0x008A3E10 File Offset: 0x008A2010
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callDele_EventOnRegretForward(IntPtr l)
	{
		int result;
		try
		{
			BattleUIController battleUIController = (BattleUIController)LuaObject.checkSelf(l);
			battleUIController.m_luaExportHelper.__callDele_EventOnRegretForward();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601C178 RID: 115064 RVA: 0x008A3E64 File Offset: 0x008A2064
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __clearDele_EventOnRegretForward(IntPtr l)
	{
		int result;
		try
		{
			BattleUIController battleUIController = (BattleUIController)LuaObject.checkSelf(l);
			battleUIController.m_luaExportHelper.__clearDele_EventOnRegretForward();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601C179 RID: 115065 RVA: 0x008A3EB8 File Offset: 0x008A20B8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int ComputeActionIconPositionScale_s(IntPtr l)
	{
		int result;
		try
		{
			int index;
			LuaObject.checkType(l, 1, out index);
			Vector2 o;
			float o2;
			BattleUIController.LuaExportHelper.ComputeActionIconPositionScale(index, out o, out o2);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, o);
			LuaObject.pushValue(l, o2);
			result = 3;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601C17A RID: 115066 RVA: 0x008A3F18 File Offset: 0x008A2118
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_EventOnPauseBattle(IntPtr l)
	{
		int result;
		try
		{
			BattleUIController battleUIController = (BattleUIController)LuaObject.checkSelf(l);
			Action value;
			int num = LuaObject.checkDelegate<Action>(l, 2, out value);
			if (num != 0)
			{
				if (num == 1)
				{
					battleUIController.EventOnPauseBattle += value;
				}
				else if (num == 2)
				{
					battleUIController.EventOnPauseBattle -= value;
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

	// Token: 0x0601C17B RID: 115067 RVA: 0x008A3F98 File Offset: 0x008A2198
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_EventOnShowArmyRelation(IntPtr l)
	{
		int result;
		try
		{
			BattleUIController battleUIController = (BattleUIController)LuaObject.checkSelf(l);
			Action value;
			int num = LuaObject.checkDelegate<Action>(l, 2, out value);
			if (num != 0)
			{
				if (num == 1)
				{
					battleUIController.EventOnShowArmyRelation += value;
				}
				else if (num == 2)
				{
					battleUIController.EventOnShowArmyRelation -= value;
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

	// Token: 0x0601C17C RID: 115068 RVA: 0x008A4018 File Offset: 0x008A2218
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_EventOnAutoBattle(IntPtr l)
	{
		int result;
		try
		{
			BattleUIController battleUIController = (BattleUIController)LuaObject.checkSelf(l);
			Action<bool> value;
			int num = LuaObject.checkDelegate<Action<bool>>(l, 2, out value);
			if (num != 0)
			{
				if (num == 1)
				{
					battleUIController.EventOnAutoBattle += value;
				}
				else if (num == 2)
				{
					battleUIController.EventOnAutoBattle -= value;
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

	// Token: 0x0601C17D RID: 115069 RVA: 0x008A4098 File Offset: 0x008A2298
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_EventOnFastBattle(IntPtr l)
	{
		int result;
		try
		{
			BattleUIController battleUIController = (BattleUIController)LuaObject.checkSelf(l);
			Action<bool> value;
			int num = LuaObject.checkDelegate<Action<bool>>(l, 2, out value);
			if (num != 0)
			{
				if (num == 1)
				{
					battleUIController.EventOnFastBattle += value;
				}
				else if (num == 2)
				{
					battleUIController.EventOnFastBattle -= value;
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

	// Token: 0x0601C17E RID: 115070 RVA: 0x008A4118 File Offset: 0x008A2318
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_EventOnSkipCombat(IntPtr l)
	{
		int result;
		try
		{
			BattleUIController battleUIController = (BattleUIController)LuaObject.checkSelf(l);
			Action<SkipCombatMode> value;
			int num = LuaObject.checkDelegate<Action<SkipCombatMode>>(l, 2, out value);
			if (num != 0)
			{
				if (num == 1)
				{
					battleUIController.EventOnSkipCombat += value;
				}
				else if (num == 2)
				{
					battleUIController.EventOnSkipCombat -= value;
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

	// Token: 0x0601C17F RID: 115071 RVA: 0x008A4198 File Offset: 0x008A2398
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_EventOnShowDanger(IntPtr l)
	{
		int result;
		try
		{
			BattleUIController battleUIController = (BattleUIController)LuaObject.checkSelf(l);
			Action<bool> value;
			int num = LuaObject.checkDelegate<Action<bool>>(l, 2, out value);
			if (num != 0)
			{
				if (num == 1)
				{
					battleUIController.EventOnShowDanger += value;
				}
				else if (num == 2)
				{
					battleUIController.EventOnShowDanger -= value;
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

	// Token: 0x0601C180 RID: 115072 RVA: 0x008A4218 File Offset: 0x008A2418
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_EventOnEndAction(IntPtr l)
	{
		int result;
		try
		{
			BattleUIController battleUIController = (BattleUIController)LuaObject.checkSelf(l);
			Action value;
			int num = LuaObject.checkDelegate<Action>(l, 2, out value);
			if (num != 0)
			{
				if (num == 1)
				{
					battleUIController.EventOnEndAction += value;
				}
				else if (num == 2)
				{
					battleUIController.EventOnEndAction -= value;
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

	// Token: 0x0601C181 RID: 115073 RVA: 0x008A4298 File Offset: 0x008A2498
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_EventOnShowActorInfo(IntPtr l)
	{
		int result;
		try
		{
			BattleUIController battleUIController = (BattleUIController)LuaObject.checkSelf(l);
			Action value;
			int num = LuaObject.checkDelegate<Action>(l, 2, out value);
			if (num != 0)
			{
				if (num == 1)
				{
					battleUIController.EventOnShowActorInfo += value;
				}
				else if (num == 2)
				{
					battleUIController.EventOnShowActorInfo -= value;
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

	// Token: 0x0601C182 RID: 115074 RVA: 0x008A4318 File Offset: 0x008A2518
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_EventOnEndAllAction(IntPtr l)
	{
		int result;
		try
		{
			BattleUIController battleUIController = (BattleUIController)LuaObject.checkSelf(l);
			Action value;
			int num = LuaObject.checkDelegate<Action>(l, 2, out value);
			if (num != 0)
			{
				if (num == 1)
				{
					battleUIController.EventOnEndAllAction += value;
				}
				else if (num == 2)
				{
					battleUIController.EventOnEndAllAction -= value;
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

	// Token: 0x0601C183 RID: 115075 RVA: 0x008A4398 File Offset: 0x008A2598
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_EventOnUseSkill(IntPtr l)
	{
		int result;
		try
		{
			BattleUIController battleUIController = (BattleUIController)LuaObject.checkSelf(l);
			Action value;
			int num = LuaObject.checkDelegate<Action>(l, 2, out value);
			if (num != 0)
			{
				if (num == 1)
				{
					battleUIController.EventOnUseSkill += value;
				}
				else if (num == 2)
				{
					battleUIController.EventOnUseSkill -= value;
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

	// Token: 0x0601C184 RID: 115076 RVA: 0x008A4418 File Offset: 0x008A2618
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_EventOnCancelSkill(IntPtr l)
	{
		int result;
		try
		{
			BattleUIController battleUIController = (BattleUIController)LuaObject.checkSelf(l);
			Action value;
			int num = LuaObject.checkDelegate<Action>(l, 2, out value);
			if (num != 0)
			{
				if (num == 1)
				{
					battleUIController.EventOnCancelSkill += value;
				}
				else if (num == 2)
				{
					battleUIController.EventOnCancelSkill -= value;
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

	// Token: 0x0601C185 RID: 115077 RVA: 0x008A4498 File Offset: 0x008A2698
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_EventOnWinOrLoseEnd(IntPtr l)
	{
		int result;
		try
		{
			BattleUIController battleUIController = (BattleUIController)LuaObject.checkSelf(l);
			Action value;
			int num = LuaObject.checkDelegate<Action>(l, 2, out value);
			if (num != 0)
			{
				if (num == 1)
				{
					battleUIController.EventOnWinOrLoseEnd += value;
				}
				else if (num == 2)
				{
					battleUIController.EventOnWinOrLoseEnd -= value;
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

	// Token: 0x0601C186 RID: 115078 RVA: 0x008A4518 File Offset: 0x008A2718
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_EventOnShowChat(IntPtr l)
	{
		int result;
		try
		{
			BattleUIController battleUIController = (BattleUIController)LuaObject.checkSelf(l);
			Action value;
			int num = LuaObject.checkDelegate<Action>(l, 2, out value);
			if (num != 0)
			{
				if (num == 1)
				{
					battleUIController.EventOnShowChat += value;
				}
				else if (num == 2)
				{
					battleUIController.EventOnShowChat -= value;
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

	// Token: 0x0601C187 RID: 115079 RVA: 0x008A4598 File Offset: 0x008A2798
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_EventOnShowHelp(IntPtr l)
	{
		int result;
		try
		{
			BattleUIController battleUIController = (BattleUIController)LuaObject.checkSelf(l);
			Action value;
			int num = LuaObject.checkDelegate<Action>(l, 2, out value);
			if (num != 0)
			{
				if (num == 1)
				{
					battleUIController.EventOnShowHelp += value;
				}
				else if (num == 2)
				{
					battleUIController.EventOnShowHelp -= value;
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

	// Token: 0x0601C188 RID: 115080 RVA: 0x008A4618 File Offset: 0x008A2818
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_EventOnSelectSkill(IntPtr l)
	{
		int result;
		try
		{
			BattleUIController battleUIController = (BattleUIController)LuaObject.checkSelf(l);
			Action<int> value;
			int num = LuaObject.checkDelegate<Action<int>>(l, 2, out value);
			if (num != 0)
			{
				if (num == 1)
				{
					battleUIController.EventOnSelectSkill += value;
				}
				else if (num == 2)
				{
					battleUIController.EventOnSelectSkill -= value;
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

	// Token: 0x0601C189 RID: 115081 RVA: 0x008A4698 File Offset: 0x008A2898
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_EventOnPointerDown(IntPtr l)
	{
		int result;
		try
		{
			BattleUIController battleUIController = (BattleUIController)LuaObject.checkSelf(l);
			Action<PointerEventData.InputButton, Vector2> value;
			int num = LuaObject.checkDelegate<Action<PointerEventData.InputButton, Vector2>>(l, 2, out value);
			if (num != 0)
			{
				if (num == 1)
				{
					battleUIController.EventOnPointerDown += value;
				}
				else if (num == 2)
				{
					battleUIController.EventOnPointerDown -= value;
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

	// Token: 0x0601C18A RID: 115082 RVA: 0x008A4718 File Offset: 0x008A2918
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_EventOnPointerUp(IntPtr l)
	{
		int result;
		try
		{
			BattleUIController battleUIController = (BattleUIController)LuaObject.checkSelf(l);
			Action<PointerEventData.InputButton, Vector2> value;
			int num = LuaObject.checkDelegate<Action<PointerEventData.InputButton, Vector2>>(l, 2, out value);
			if (num != 0)
			{
				if (num == 1)
				{
					battleUIController.EventOnPointerUp += value;
				}
				else if (num == 2)
				{
					battleUIController.EventOnPointerUp -= value;
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

	// Token: 0x0601C18B RID: 115083 RVA: 0x008A4798 File Offset: 0x008A2998
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_EventOnPointerClick(IntPtr l)
	{
		int result;
		try
		{
			BattleUIController battleUIController = (BattleUIController)LuaObject.checkSelf(l);
			Action<PointerEventData.InputButton, Vector2> value;
			int num = LuaObject.checkDelegate<Action<PointerEventData.InputButton, Vector2>>(l, 2, out value);
			if (num != 0)
			{
				if (num == 1)
				{
					battleUIController.EventOnPointerClick += value;
				}
				else if (num == 2)
				{
					battleUIController.EventOnPointerClick -= value;
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

	// Token: 0x0601C18C RID: 115084 RVA: 0x008A4818 File Offset: 0x008A2A18
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_EventOn3DTouch(IntPtr l)
	{
		int result;
		try
		{
			BattleUIController battleUIController = (BattleUIController)LuaObject.checkSelf(l);
			Action<Vector2> value;
			int num = LuaObject.checkDelegate<Action<Vector2>>(l, 2, out value);
			if (num != 0)
			{
				if (num == 1)
				{
					battleUIController.EventOn3DTouch += value;
				}
				else if (num == 2)
				{
					battleUIController.EventOn3DTouch -= value;
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

	// Token: 0x0601C18D RID: 115085 RVA: 0x008A4898 File Offset: 0x008A2A98
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_EventOnShowCurTurnDanmaku(IntPtr l)
	{
		int result;
		try
		{
			BattleUIController battleUIController = (BattleUIController)LuaObject.checkSelf(l);
			Action<int> value;
			int num = LuaObject.checkDelegate<Action<int>>(l, 2, out value);
			if (num != 0)
			{
				if (num == 1)
				{
					battleUIController.EventOnShowCurTurnDanmaku += value;
				}
				else if (num == 2)
				{
					battleUIController.EventOnShowCurTurnDanmaku -= value;
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

	// Token: 0x0601C18E RID: 115086 RVA: 0x008A4918 File Offset: 0x008A2B18
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_EventOnCloseCurTurnDanmaku(IntPtr l)
	{
		int result;
		try
		{
			BattleUIController battleUIController = (BattleUIController)LuaObject.checkSelf(l);
			Action value;
			int num = LuaObject.checkDelegate<Action>(l, 2, out value);
			if (num != 0)
			{
				if (num == 1)
				{
					battleUIController.EventOnCloseCurTurnDanmaku += value;
				}
				else if (num == 2)
				{
					battleUIController.EventOnCloseCurTurnDanmaku -= value;
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

	// Token: 0x0601C18F RID: 115087 RVA: 0x008A4998 File Offset: 0x008A2B98
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_EventOnShowOneDanmaku(IntPtr l)
	{
		int result;
		try
		{
			BattleUIController battleUIController = (BattleUIController)LuaObject.checkSelf(l);
			Action<DanmakuEntry> value;
			int num = LuaObject.checkDelegate<Action<DanmakuEntry>>(l, 2, out value);
			if (num != 0)
			{
				if (num == 1)
				{
					battleUIController.EventOnShowOneDanmaku += value;
				}
				else if (num == 2)
				{
					battleUIController.EventOnShowOneDanmaku -= value;
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

	// Token: 0x0601C190 RID: 115088 RVA: 0x008A4A18 File Offset: 0x008A2C18
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_EventOnRegretActive(IntPtr l)
	{
		int result;
		try
		{
			BattleUIController battleUIController = (BattleUIController)LuaObject.checkSelf(l);
			Action value;
			int num = LuaObject.checkDelegate<Action>(l, 2, out value);
			if (num != 0)
			{
				if (num == 1)
				{
					battleUIController.EventOnRegretActive += value;
				}
				else if (num == 2)
				{
					battleUIController.EventOnRegretActive -= value;
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

	// Token: 0x0601C191 RID: 115089 RVA: 0x008A4A98 File Offset: 0x008A2C98
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_EventOnRegretConfirm(IntPtr l)
	{
		int result;
		try
		{
			BattleUIController battleUIController = (BattleUIController)LuaObject.checkSelf(l);
			Action value;
			int num = LuaObject.checkDelegate<Action>(l, 2, out value);
			if (num != 0)
			{
				if (num == 1)
				{
					battleUIController.EventOnRegretConfirm += value;
				}
				else if (num == 2)
				{
					battleUIController.EventOnRegretConfirm -= value;
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

	// Token: 0x0601C192 RID: 115090 RVA: 0x008A4B18 File Offset: 0x008A2D18
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_EventOnRegretCancel(IntPtr l)
	{
		int result;
		try
		{
			BattleUIController battleUIController = (BattleUIController)LuaObject.checkSelf(l);
			Action value;
			int num = LuaObject.checkDelegate<Action>(l, 2, out value);
			if (num != 0)
			{
				if (num == 1)
				{
					battleUIController.EventOnRegretCancel += value;
				}
				else if (num == 2)
				{
					battleUIController.EventOnRegretCancel -= value;
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

	// Token: 0x0601C193 RID: 115091 RVA: 0x008A4B98 File Offset: 0x008A2D98
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_EventOnRegretBackward(IntPtr l)
	{
		int result;
		try
		{
			BattleUIController battleUIController = (BattleUIController)LuaObject.checkSelf(l);
			Action value;
			int num = LuaObject.checkDelegate<Action>(l, 2, out value);
			if (num != 0)
			{
				if (num == 1)
				{
					battleUIController.EventOnRegretBackward += value;
				}
				else if (num == 2)
				{
					battleUIController.EventOnRegretBackward -= value;
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

	// Token: 0x0601C194 RID: 115092 RVA: 0x008A4C18 File Offset: 0x008A2E18
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_EventOnRegretForward(IntPtr l)
	{
		int result;
		try
		{
			BattleUIController battleUIController = (BattleUIController)LuaObject.checkSelf(l);
			Action value;
			int num = LuaObject.checkDelegate<Action>(l, 2, out value);
			if (num != 0)
			{
				if (num == 1)
				{
					battleUIController.EventOnRegretForward += value;
				}
				else if (num == 2)
				{
					battleUIController.EventOnRegretForward -= value;
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

	// Token: 0x0601C195 RID: 115093 RVA: 0x008A4C98 File Offset: 0x008A2E98
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_m_marginTransform(IntPtr l)
	{
		int result;
		try
		{
			BattleUIController battleUIController = (BattleUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, battleUIController.m_luaExportHelper.m_marginTransform);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601C196 RID: 115094 RVA: 0x008A4CF0 File Offset: 0x008A2EF0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_marginTransform(IntPtr l)
	{
		int result;
		try
		{
			BattleUIController battleUIController = (BattleUIController)LuaObject.checkSelf(l);
			RectTransform marginTransform;
			LuaObject.checkType<RectTransform>(l, 2, out marginTransform);
			battleUIController.m_luaExportHelper.m_marginTransform = marginTransform;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601C197 RID: 115095 RVA: 0x008A4D4C File Offset: 0x008A2F4C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_autoOffButton(IntPtr l)
	{
		int result;
		try
		{
			BattleUIController battleUIController = (BattleUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, battleUIController.m_luaExportHelper.m_autoOffButton);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601C198 RID: 115096 RVA: 0x008A4DA4 File Offset: 0x008A2FA4
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_m_autoOffButton(IntPtr l)
	{
		int result;
		try
		{
			BattleUIController battleUIController = (BattleUIController)LuaObject.checkSelf(l);
			Button autoOffButton;
			LuaObject.checkType<Button>(l, 2, out autoOffButton);
			battleUIController.m_luaExportHelper.m_autoOffButton = autoOffButton;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601C199 RID: 115097 RVA: 0x008A4E00 File Offset: 0x008A3000
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_arenaAutoButton(IntPtr l)
	{
		int result;
		try
		{
			BattleUIController battleUIController = (BattleUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, battleUIController.m_luaExportHelper.m_arenaAutoButton);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601C19A RID: 115098 RVA: 0x008A4E58 File Offset: 0x008A3058
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_arenaAutoButton(IntPtr l)
	{
		int result;
		try
		{
			BattleUIController battleUIController = (BattleUIController)LuaObject.checkSelf(l);
			Button arenaAutoButton;
			LuaObject.checkType<Button>(l, 2, out arenaAutoButton);
			battleUIController.m_luaExportHelper.m_arenaAutoButton = arenaAutoButton;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601C19B RID: 115099 RVA: 0x008A4EB4 File Offset: 0x008A30B4
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_m_topLeftGameObject(IntPtr l)
	{
		int result;
		try
		{
			BattleUIController battleUIController = (BattleUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, battleUIController.m_luaExportHelper.m_topLeftGameObject);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601C19C RID: 115100 RVA: 0x008A4F0C File Offset: 0x008A310C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_topLeftGameObject(IntPtr l)
	{
		int result;
		try
		{
			BattleUIController battleUIController = (BattleUIController)LuaObject.checkSelf(l);
			GameObject topLeftGameObject;
			LuaObject.checkType<GameObject>(l, 2, out topLeftGameObject);
			battleUIController.m_luaExportHelper.m_topLeftGameObject = topLeftGameObject;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601C19D RID: 115101 RVA: 0x008A4F68 File Offset: 0x008A3168
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_actorSimpleInfoButton(IntPtr l)
	{
		int result;
		try
		{
			BattleUIController battleUIController = (BattleUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, battleUIController.m_luaExportHelper.m_actorSimpleInfoButton);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601C19E RID: 115102 RVA: 0x008A4FC0 File Offset: 0x008A31C0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_actorSimpleInfoButton(IntPtr l)
	{
		int result;
		try
		{
			BattleUIController battleUIController = (BattleUIController)LuaObject.checkSelf(l);
			Button actorSimpleInfoButton;
			LuaObject.checkType<Button>(l, 2, out actorSimpleInfoButton);
			battleUIController.m_luaExportHelper.m_actorSimpleInfoButton = actorSimpleInfoButton;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601C19F RID: 115103 RVA: 0x008A501C File Offset: 0x008A321C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_actorSimpleInfoUIStateController(IntPtr l)
	{
		int result;
		try
		{
			BattleUIController battleUIController = (BattleUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, battleUIController.m_luaExportHelper.m_actorSimpleInfoUIStateController);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601C1A0 RID: 115104 RVA: 0x008A5074 File Offset: 0x008A3274
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_m_actorSimpleInfoUIStateController(IntPtr l)
	{
		int result;
		try
		{
			BattleUIController battleUIController = (BattleUIController)LuaObject.checkSelf(l);
			CommonUIStateController actorSimpleInfoUIStateController;
			LuaObject.checkType<CommonUIStateController>(l, 2, out actorSimpleInfoUIStateController);
			battleUIController.m_luaExportHelper.m_actorSimpleInfoUIStateController = actorSimpleInfoUIStateController;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601C1A1 RID: 115105 RVA: 0x008A50D0 File Offset: 0x008A32D0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_actorSimpleInfoHeadImage(IntPtr l)
	{
		int result;
		try
		{
			BattleUIController battleUIController = (BattleUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, battleUIController.m_luaExportHelper.m_actorSimpleInfoHeadImage);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601C1A2 RID: 115106 RVA: 0x008A5128 File Offset: 0x008A3328
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_actorSimpleInfoHeadImage(IntPtr l)
	{
		int result;
		try
		{
			BattleUIController battleUIController = (BattleUIController)LuaObject.checkSelf(l);
			Image actorSimpleInfoHeadImage;
			LuaObject.checkType<Image>(l, 2, out actorSimpleInfoHeadImage);
			battleUIController.m_luaExportHelper.m_actorSimpleInfoHeadImage = actorSimpleInfoHeadImage;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601C1A3 RID: 115107 RVA: 0x008A5184 File Offset: 0x008A3384
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_actorSimpleInfoNameText(IntPtr l)
	{
		int result;
		try
		{
			BattleUIController battleUIController = (BattleUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, battleUIController.m_luaExportHelper.m_actorSimpleInfoNameText);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601C1A4 RID: 115108 RVA: 0x008A51DC File Offset: 0x008A33DC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_actorSimpleInfoNameText(IntPtr l)
	{
		int result;
		try
		{
			BattleUIController battleUIController = (BattleUIController)LuaObject.checkSelf(l);
			Text actorSimpleInfoNameText;
			LuaObject.checkType<Text>(l, 2, out actorSimpleInfoNameText);
			battleUIController.m_luaExportHelper.m_actorSimpleInfoNameText = actorSimpleInfoNameText;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601C1A5 RID: 115109 RVA: 0x008A5238 File Offset: 0x008A3438
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_actorSimpleInfoLevelText(IntPtr l)
	{
		int result;
		try
		{
			BattleUIController battleUIController = (BattleUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, battleUIController.m_luaExportHelper.m_actorSimpleInfoLevelText);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601C1A6 RID: 115110 RVA: 0x008A5290 File Offset: 0x008A3490
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_actorSimpleInfoLevelText(IntPtr l)
	{
		int result;
		try
		{
			BattleUIController battleUIController = (BattleUIController)LuaObject.checkSelf(l);
			Text actorSimpleInfoLevelText;
			LuaObject.checkType<Text>(l, 2, out actorSimpleInfoLevelText);
			battleUIController.m_luaExportHelper.m_actorSimpleInfoLevelText = actorSimpleInfoLevelText;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601C1A7 RID: 115111 RVA: 0x008A52EC File Offset: 0x008A34EC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_actorSimpleInfoArmyImage(IntPtr l)
	{
		int result;
		try
		{
			BattleUIController battleUIController = (BattleUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, battleUIController.m_luaExportHelper.m_actorSimpleInfoArmyImage);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601C1A8 RID: 115112 RVA: 0x008A5344 File Offset: 0x008A3544
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_actorSimpleInfoArmyImage(IntPtr l)
	{
		int result;
		try
		{
			BattleUIController battleUIController = (BattleUIController)LuaObject.checkSelf(l);
			Image actorSimpleInfoArmyImage;
			LuaObject.checkType<Image>(l, 2, out actorSimpleInfoArmyImage);
			battleUIController.m_luaExportHelper.m_actorSimpleInfoArmyImage = actorSimpleInfoArmyImage;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601C1A9 RID: 115113 RVA: 0x008A53A0 File Offset: 0x008A35A0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_actorSimpleInfoHeroHPImage(IntPtr l)
	{
		int result;
		try
		{
			BattleUIController battleUIController = (BattleUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, battleUIController.m_luaExportHelper.m_actorSimpleInfoHeroHPImage);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601C1AA RID: 115114 RVA: 0x008A53F8 File Offset: 0x008A35F8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_actorSimpleInfoHeroHPImage(IntPtr l)
	{
		int result;
		try
		{
			BattleUIController battleUIController = (BattleUIController)LuaObject.checkSelf(l);
			Image actorSimpleInfoHeroHPImage;
			LuaObject.checkType<Image>(l, 2, out actorSimpleInfoHeroHPImage);
			battleUIController.m_luaExportHelper.m_actorSimpleInfoHeroHPImage = actorSimpleInfoHeroHPImage;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601C1AB RID: 115115 RVA: 0x008A5454 File Offset: 0x008A3654
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_m_actorSimpleInfoHeroHPText(IntPtr l)
	{
		int result;
		try
		{
			BattleUIController battleUIController = (BattleUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, battleUIController.m_luaExportHelper.m_actorSimpleInfoHeroHPText);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601C1AC RID: 115116 RVA: 0x008A54AC File Offset: 0x008A36AC
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_m_actorSimpleInfoHeroHPText(IntPtr l)
	{
		int result;
		try
		{
			BattleUIController battleUIController = (BattleUIController)LuaObject.checkSelf(l);
			Text actorSimpleInfoHeroHPText;
			LuaObject.checkType<Text>(l, 2, out actorSimpleInfoHeroHPText);
			battleUIController.m_luaExportHelper.m_actorSimpleInfoHeroHPText = actorSimpleInfoHeroHPText;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601C1AD RID: 115117 RVA: 0x008A5508 File Offset: 0x008A3708
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_m_actorSimpleInfoSoldierHPImage(IntPtr l)
	{
		int result;
		try
		{
			BattleUIController battleUIController = (BattleUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, battleUIController.m_luaExportHelper.m_actorSimpleInfoSoldierHPImage);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601C1AE RID: 115118 RVA: 0x008A5560 File Offset: 0x008A3760
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_actorSimpleInfoSoldierHPImage(IntPtr l)
	{
		int result;
		try
		{
			BattleUIController battleUIController = (BattleUIController)LuaObject.checkSelf(l);
			Image actorSimpleInfoSoldierHPImage;
			LuaObject.checkType<Image>(l, 2, out actorSimpleInfoSoldierHPImage);
			battleUIController.m_luaExportHelper.m_actorSimpleInfoSoldierHPImage = actorSimpleInfoSoldierHPImage;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601C1AF RID: 115119 RVA: 0x008A55BC File Offset: 0x008A37BC
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_m_actorSimpleInfoSoldierHPText(IntPtr l)
	{
		int result;
		try
		{
			BattleUIController battleUIController = (BattleUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, battleUIController.m_luaExportHelper.m_actorSimpleInfoSoldierHPText);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601C1B0 RID: 115120 RVA: 0x008A5614 File Offset: 0x008A3814
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_m_actorSimpleInfoSoldierHPText(IntPtr l)
	{
		int result;
		try
		{
			BattleUIController battleUIController = (BattleUIController)LuaObject.checkSelf(l);
			Text actorSimpleInfoSoldierHPText;
			LuaObject.checkType<Text>(l, 2, out actorSimpleInfoSoldierHPText);
			battleUIController.m_luaExportHelper.m_actorSimpleInfoSoldierHPText = actorSimpleInfoSoldierHPText;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601C1B1 RID: 115121 RVA: 0x008A5670 File Offset: 0x008A3870
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_m_topLeftGameObject2(IntPtr l)
	{
		int result;
		try
		{
			BattleUIController battleUIController = (BattleUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, battleUIController.m_luaExportHelper.m_topLeftGameObject2);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601C1B2 RID: 115122 RVA: 0x008A56C8 File Offset: 0x008A38C8
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_m_topLeftGameObject2(IntPtr l)
	{
		int result;
		try
		{
			BattleUIController battleUIController = (BattleUIController)LuaObject.checkSelf(l);
			GameObject topLeftGameObject;
			LuaObject.checkType<GameObject>(l, 2, out topLeftGameObject);
			battleUIController.m_luaExportHelper.m_topLeftGameObject2 = topLeftGameObject;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601C1B3 RID: 115123 RVA: 0x008A5724 File Offset: 0x008A3924
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_regratButton(IntPtr l)
	{
		int result;
		try
		{
			BattleUIController battleUIController = (BattleUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, battleUIController.m_luaExportHelper.m_regratButton);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601C1B4 RID: 115124 RVA: 0x008A577C File Offset: 0x008A397C
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_m_regratButton(IntPtr l)
	{
		int result;
		try
		{
			BattleUIController battleUIController = (BattleUIController)LuaObject.checkSelf(l);
			Button regratButton;
			LuaObject.checkType<Button>(l, 2, out regratButton);
			battleUIController.m_luaExportHelper.m_regratButton = regratButton;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601C1B5 RID: 115125 RVA: 0x008A57D8 File Offset: 0x008A39D8
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_m_regretButtonUIStateController(IntPtr l)
	{
		int result;
		try
		{
			BattleUIController battleUIController = (BattleUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, battleUIController.m_luaExportHelper.m_regretButtonUIStateController);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601C1B6 RID: 115126 RVA: 0x008A5830 File Offset: 0x008A3A30
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_m_regretButtonUIStateController(IntPtr l)
	{
		int result;
		try
		{
			BattleUIController battleUIController = (BattleUIController)LuaObject.checkSelf(l);
			CommonUIStateController regretButtonUIStateController;
			LuaObject.checkType<CommonUIStateController>(l, 2, out regretButtonUIStateController);
			battleUIController.m_luaExportHelper.m_regretButtonUIStateController = regretButtonUIStateController;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601C1B7 RID: 115127 RVA: 0x008A588C File Offset: 0x008A3A8C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_regretCountText(IntPtr l)
	{
		int result;
		try
		{
			BattleUIController battleUIController = (BattleUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, battleUIController.m_luaExportHelper.m_regretCountText);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601C1B8 RID: 115128 RVA: 0x008A58E4 File Offset: 0x008A3AE4
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_m_regretCountText(IntPtr l)
	{
		int result;
		try
		{
			BattleUIController battleUIController = (BattleUIController)LuaObject.checkSelf(l);
			Text regretCountText;
			LuaObject.checkType<Text>(l, 2, out regretCountText);
			battleUIController.m_luaExportHelper.m_regretCountText = regretCountText;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601C1B9 RID: 115129 RVA: 0x008A5940 File Offset: 0x008A3B40
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_topRightGameObject2(IntPtr l)
	{
		int result;
		try
		{
			BattleUIController battleUIController = (BattleUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, battleUIController.m_luaExportHelper.m_topRightGameObject2);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601C1BA RID: 115130 RVA: 0x008A5998 File Offset: 0x008A3B98
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_m_topRightGameObject2(IntPtr l)
	{
		int result;
		try
		{
			BattleUIController battleUIController = (BattleUIController)LuaObject.checkSelf(l);
			GameObject topRightGameObject;
			LuaObject.checkType<GameObject>(l, 2, out topRightGameObject);
			battleUIController.m_luaExportHelper.m_topRightGameObject2 = topRightGameObject;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601C1BB RID: 115131 RVA: 0x008A59F4 File Offset: 0x008A3BF4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_pauseButton(IntPtr l)
	{
		int result;
		try
		{
			BattleUIController battleUIController = (BattleUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, battleUIController.m_luaExportHelper.m_pauseButton);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601C1BC RID: 115132 RVA: 0x008A5A4C File Offset: 0x008A3C4C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_pauseButton(IntPtr l)
	{
		int result;
		try
		{
			BattleUIController battleUIController = (BattleUIController)LuaObject.checkSelf(l);
			Button pauseButton;
			LuaObject.checkType<Button>(l, 2, out pauseButton);
			battleUIController.m_luaExportHelper.m_pauseButton = pauseButton;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601C1BD RID: 115133 RVA: 0x008A5AA8 File Offset: 0x008A3CA8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_autoButton(IntPtr l)
	{
		int result;
		try
		{
			BattleUIController battleUIController = (BattleUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, battleUIController.m_luaExportHelper.m_autoButton);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601C1BE RID: 115134 RVA: 0x008A5B00 File Offset: 0x008A3D00
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_autoButton(IntPtr l)
	{
		int result;
		try
		{
			BattleUIController battleUIController = (BattleUIController)LuaObject.checkSelf(l);
			Button autoButton;
			LuaObject.checkType<Button>(l, 2, out autoButton);
			battleUIController.m_luaExportHelper.m_autoButton = autoButton;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601C1BF RID: 115135 RVA: 0x008A5B5C File Offset: 0x008A3D5C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_autoButtonUIStateController(IntPtr l)
	{
		int result;
		try
		{
			BattleUIController battleUIController = (BattleUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, battleUIController.m_luaExportHelper.m_autoButtonUIStateController);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601C1C0 RID: 115136 RVA: 0x008A5BB4 File Offset: 0x008A3DB4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_autoButtonUIStateController(IntPtr l)
	{
		int result;
		try
		{
			BattleUIController battleUIController = (BattleUIController)LuaObject.checkSelf(l);
			CommonUIStateController autoButtonUIStateController;
			LuaObject.checkType<CommonUIStateController>(l, 2, out autoButtonUIStateController);
			battleUIController.m_luaExportHelper.m_autoButtonUIStateController = autoButtonUIStateController;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601C1C1 RID: 115137 RVA: 0x008A5C10 File Offset: 0x008A3E10
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_fastButton(IntPtr l)
	{
		int result;
		try
		{
			BattleUIController battleUIController = (BattleUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, battleUIController.m_luaExportHelper.m_fastButton);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601C1C2 RID: 115138 RVA: 0x008A5C68 File Offset: 0x008A3E68
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_fastButton(IntPtr l)
	{
		int result;
		try
		{
			BattleUIController battleUIController = (BattleUIController)LuaObject.checkSelf(l);
			Button fastButton;
			LuaObject.checkType<Button>(l, 2, out fastButton);
			battleUIController.m_luaExportHelper.m_fastButton = fastButton;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601C1C3 RID: 115139 RVA: 0x008A5CC4 File Offset: 0x008A3EC4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_fastButtonUIStateController(IntPtr l)
	{
		int result;
		try
		{
			BattleUIController battleUIController = (BattleUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, battleUIController.m_luaExportHelper.m_fastButtonUIStateController);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601C1C4 RID: 115140 RVA: 0x008A5D1C File Offset: 0x008A3F1C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_fastButtonUIStateController(IntPtr l)
	{
		int result;
		try
		{
			BattleUIController battleUIController = (BattleUIController)LuaObject.checkSelf(l);
			CommonUIStateController fastButtonUIStateController;
			LuaObject.checkType<CommonUIStateController>(l, 2, out fastButtonUIStateController);
			battleUIController.m_luaExportHelper.m_fastButtonUIStateController = fastButtonUIStateController;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601C1C5 RID: 115141 RVA: 0x008A5D78 File Offset: 0x008A3F78
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_skipCombatButton(IntPtr l)
	{
		int result;
		try
		{
			BattleUIController battleUIController = (BattleUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, battleUIController.m_luaExportHelper.m_skipCombatButton);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601C1C6 RID: 115142 RVA: 0x008A5DD0 File Offset: 0x008A3FD0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_skipCombatButton(IntPtr l)
	{
		int result;
		try
		{
			BattleUIController battleUIController = (BattleUIController)LuaObject.checkSelf(l);
			Button skipCombatButton;
			LuaObject.checkType<Button>(l, 2, out skipCombatButton);
			battleUIController.m_luaExportHelper.m_skipCombatButton = skipCombatButton;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601C1C7 RID: 115143 RVA: 0x008A5E2C File Offset: 0x008A402C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_skipCombatButtonUIStateController(IntPtr l)
	{
		int result;
		try
		{
			BattleUIController battleUIController = (BattleUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, battleUIController.m_luaExportHelper.m_skipCombatButtonUIStateController);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601C1C8 RID: 115144 RVA: 0x008A5E84 File Offset: 0x008A4084
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_m_skipCombatButtonUIStateController(IntPtr l)
	{
		int result;
		try
		{
			BattleUIController battleUIController = (BattleUIController)LuaObject.checkSelf(l);
			CommonUIStateController skipCombatButtonUIStateController;
			LuaObject.checkType<CommonUIStateController>(l, 2, out skipCombatButtonUIStateController);
			battleUIController.m_luaExportHelper.m_skipCombatButtonUIStateController = skipCombatButtonUIStateController;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601C1C9 RID: 115145 RVA: 0x008A5EE0 File Offset: 0x008A40E0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_terrainInfoGameObject(IntPtr l)
	{
		int result;
		try
		{
			BattleUIController battleUIController = (BattleUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, battleUIController.m_luaExportHelper.m_terrainInfoGameObject);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601C1CA RID: 115146 RVA: 0x008A5F38 File Offset: 0x008A4138
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_terrainInfoGameObject(IntPtr l)
	{
		int result;
		try
		{
			BattleUIController battleUIController = (BattleUIController)LuaObject.checkSelf(l);
			GameObject terrainInfoGameObject;
			LuaObject.checkType<GameObject>(l, 2, out terrainInfoGameObject);
			battleUIController.m_luaExportHelper.m_terrainInfoGameObject = terrainInfoGameObject;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601C1CB RID: 115147 RVA: 0x008A5F94 File Offset: 0x008A4194
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_terrainInfoButton(IntPtr l)
	{
		int result;
		try
		{
			BattleUIController battleUIController = (BattleUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, battleUIController.m_luaExportHelper.m_terrainInfoButton);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601C1CC RID: 115148 RVA: 0x008A5FEC File Offset: 0x008A41EC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_terrainInfoButton(IntPtr l)
	{
		int result;
		try
		{
			BattleUIController battleUIController = (BattleUIController)LuaObject.checkSelf(l);
			Button terrainInfoButton;
			LuaObject.checkType<Button>(l, 2, out terrainInfoButton);
			battleUIController.m_luaExportHelper.m_terrainInfoButton = terrainInfoButton;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601C1CD RID: 115149 RVA: 0x008A6048 File Offset: 0x008A4248
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_terrainInfoText(IntPtr l)
	{
		int result;
		try
		{
			BattleUIController battleUIController = (BattleUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, battleUIController.m_luaExportHelper.m_terrainInfoText);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601C1CE RID: 115150 RVA: 0x008A60A0 File Offset: 0x008A42A0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_terrainInfoText(IntPtr l)
	{
		int result;
		try
		{
			BattleUIController battleUIController = (BattleUIController)LuaObject.checkSelf(l);
			Text terrainInfoText;
			LuaObject.checkType<Text>(l, 2, out terrainInfoText);
			battleUIController.m_luaExportHelper.m_terrainInfoText = terrainInfoText;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601C1CF RID: 115151 RVA: 0x008A60FC File Offset: 0x008A42FC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_terrainInfoImage(IntPtr l)
	{
		int result;
		try
		{
			BattleUIController battleUIController = (BattleUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, battleUIController.m_luaExportHelper.m_terrainInfoImage);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601C1D0 RID: 115152 RVA: 0x008A6154 File Offset: 0x008A4354
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_terrainInfoImage(IntPtr l)
	{
		int result;
		try
		{
			BattleUIController battleUIController = (BattleUIController)LuaObject.checkSelf(l);
			Image terrainInfoImage;
			LuaObject.checkType<Image>(l, 2, out terrainInfoImage);
			battleUIController.m_luaExportHelper.m_terrainInfoImage = terrainInfoImage;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601C1D1 RID: 115153 RVA: 0x008A61B0 File Offset: 0x008A43B0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_terrainInfoDefText(IntPtr l)
	{
		int result;
		try
		{
			BattleUIController battleUIController = (BattleUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, battleUIController.m_luaExportHelper.m_terrainInfoDefText);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601C1D2 RID: 115154 RVA: 0x008A6208 File Offset: 0x008A4408
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_terrainInfoDefText(IntPtr l)
	{
		int result;
		try
		{
			BattleUIController battleUIController = (BattleUIController)LuaObject.checkSelf(l);
			Text terrainInfoDefText;
			LuaObject.checkType<Text>(l, 2, out terrainInfoDefText);
			battleUIController.m_luaExportHelper.m_terrainInfoDefText = terrainInfoDefText;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601C1D3 RID: 115155 RVA: 0x008A6264 File Offset: 0x008A4464
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_bottomGameObject(IntPtr l)
	{
		int result;
		try
		{
			BattleUIController battleUIController = (BattleUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, battleUIController.m_luaExportHelper.m_bottomGameObject);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601C1D4 RID: 115156 RVA: 0x008A62BC File Offset: 0x008A44BC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_bottomGameObject(IntPtr l)
	{
		int result;
		try
		{
			BattleUIController battleUIController = (BattleUIController)LuaObject.checkSelf(l);
			GameObject bottomGameObject;
			LuaObject.checkType<GameObject>(l, 2, out bottomGameObject);
			battleUIController.m_luaExportHelper.m_bottomGameObject = bottomGameObject;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601C1D5 RID: 115157 RVA: 0x008A6318 File Offset: 0x008A4518
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_dangerOnButton(IntPtr l)
	{
		int result;
		try
		{
			BattleUIController battleUIController = (BattleUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, battleUIController.m_luaExportHelper.m_dangerOnButton);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601C1D6 RID: 115158 RVA: 0x008A6370 File Offset: 0x008A4570
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_dangerOnButton(IntPtr l)
	{
		int result;
		try
		{
			BattleUIController battleUIController = (BattleUIController)LuaObject.checkSelf(l);
			Button dangerOnButton;
			LuaObject.checkType<Button>(l, 2, out dangerOnButton);
			battleUIController.m_luaExportHelper.m_dangerOnButton = dangerOnButton;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601C1D7 RID: 115159 RVA: 0x008A63CC File Offset: 0x008A45CC
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_m_dangerOffButton(IntPtr l)
	{
		int result;
		try
		{
			BattleUIController battleUIController = (BattleUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, battleUIController.m_luaExportHelper.m_dangerOffButton);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601C1D8 RID: 115160 RVA: 0x008A6424 File Offset: 0x008A4624
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_dangerOffButton(IntPtr l)
	{
		int result;
		try
		{
			BattleUIController battleUIController = (BattleUIController)LuaObject.checkSelf(l);
			Button dangerOffButton;
			LuaObject.checkType<Button>(l, 2, out dangerOffButton);
			battleUIController.m_luaExportHelper.m_dangerOffButton = dangerOffButton;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601C1D9 RID: 115161 RVA: 0x008A6480 File Offset: 0x008A4680
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_endAllActionButton(IntPtr l)
	{
		int result;
		try
		{
			BattleUIController battleUIController = (BattleUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, battleUIController.m_luaExportHelper.m_endAllActionButton);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601C1DA RID: 115162 RVA: 0x008A64D8 File Offset: 0x008A46D8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_endAllActionButton(IntPtr l)
	{
		int result;
		try
		{
			BattleUIController battleUIController = (BattleUIController)LuaObject.checkSelf(l);
			Button endAllActionButton;
			LuaObject.checkType<Button>(l, 2, out endAllActionButton);
			battleUIController.m_luaExportHelper.m_endAllActionButton = endAllActionButton;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601C1DB RID: 115163 RVA: 0x008A6534 File Offset: 0x008A4734
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_useSkillButton(IntPtr l)
	{
		int result;
		try
		{
			BattleUIController battleUIController = (BattleUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, battleUIController.m_luaExportHelper.m_useSkillButton);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601C1DC RID: 115164 RVA: 0x008A658C File Offset: 0x008A478C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_useSkillButton(IntPtr l)
	{
		int result;
		try
		{
			BattleUIController battleUIController = (BattleUIController)LuaObject.checkSelf(l);
			Button useSkillButton;
			LuaObject.checkType<Button>(l, 2, out useSkillButton);
			battleUIController.m_luaExportHelper.m_useSkillButton = useSkillButton;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601C1DD RID: 115165 RVA: 0x008A65E8 File Offset: 0x008A47E8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_cancelSkillButton(IntPtr l)
	{
		int result;
		try
		{
			BattleUIController battleUIController = (BattleUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, battleUIController.m_luaExportHelper.m_cancelSkillButton);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601C1DE RID: 115166 RVA: 0x008A6640 File Offset: 0x008A4840
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_cancelSkillButton(IntPtr l)
	{
		int result;
		try
		{
			BattleUIController battleUIController = (BattleUIController)LuaObject.checkSelf(l);
			Button cancelSkillButton;
			LuaObject.checkType<Button>(l, 2, out cancelSkillButton);
			battleUIController.m_luaExportHelper.m_cancelSkillButton = cancelSkillButton;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601C1DF RID: 115167 RVA: 0x008A669C File Offset: 0x008A489C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_chatButton(IntPtr l)
	{
		int result;
		try
		{
			BattleUIController battleUIController = (BattleUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, battleUIController.m_luaExportHelper.m_chatButton);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601C1E0 RID: 115168 RVA: 0x008A66F4 File Offset: 0x008A48F4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_chatButton(IntPtr l)
	{
		int result;
		try
		{
			BattleUIController battleUIController = (BattleUIController)LuaObject.checkSelf(l);
			Button chatButton;
			LuaObject.checkType<Button>(l, 2, out chatButton);
			battleUIController.m_luaExportHelper.m_chatButton = chatButton;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601C1E1 RID: 115169 RVA: 0x008A6750 File Offset: 0x008A4950
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_chatRedPoint(IntPtr l)
	{
		int result;
		try
		{
			BattleUIController battleUIController = (BattleUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, battleUIController.m_luaExportHelper.m_chatRedPoint);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601C1E2 RID: 115170 RVA: 0x008A67A8 File Offset: 0x008A49A8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_chatRedPoint(IntPtr l)
	{
		int result;
		try
		{
			BattleUIController battleUIController = (BattleUIController)LuaObject.checkSelf(l);
			GameObject chatRedPoint;
			LuaObject.checkType<GameObject>(l, 2, out chatRedPoint);
			battleUIController.m_luaExportHelper.m_chatRedPoint = chatRedPoint;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601C1E3 RID: 115171 RVA: 0x008A6804 File Offset: 0x008A4A04
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_skillsUIStateController(IntPtr l)
	{
		int result;
		try
		{
			BattleUIController battleUIController = (BattleUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, battleUIController.m_luaExportHelper.m_skillsUIStateController);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601C1E4 RID: 115172 RVA: 0x008A685C File Offset: 0x008A4A5C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_skillsUIStateController(IntPtr l)
	{
		int result;
		try
		{
			BattleUIController battleUIController = (BattleUIController)LuaObject.checkSelf(l);
			CommonUIStateController skillsUIStateController;
			LuaObject.checkType<CommonUIStateController>(l, 2, out skillsUIStateController);
			battleUIController.m_luaExportHelper.m_skillsUIStateController = skillsUIStateController;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601C1E5 RID: 115173 RVA: 0x008A68B8 File Offset: 0x008A4AB8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_endActionButton(IntPtr l)
	{
		int result;
		try
		{
			BattleUIController battleUIController = (BattleUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, battleUIController.m_luaExportHelper.m_endActionButton);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601C1E6 RID: 115174 RVA: 0x008A6910 File Offset: 0x008A4B10
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_endActionButton(IntPtr l)
	{
		int result;
		try
		{
			BattleUIController battleUIController = (BattleUIController)LuaObject.checkSelf(l);
			Button endActionButton;
			LuaObject.checkType<Button>(l, 2, out endActionButton);
			battleUIController.m_luaExportHelper.m_endActionButton = endActionButton;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601C1E7 RID: 115175 RVA: 0x008A696C File Offset: 0x008A4B6C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_skillListGameObject(IntPtr l)
	{
		int result;
		try
		{
			BattleUIController battleUIController = (BattleUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, battleUIController.m_luaExportHelper.m_skillListGameObject);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601C1E8 RID: 115176 RVA: 0x008A69C4 File Offset: 0x008A4BC4
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_m_skillListGameObject(IntPtr l)
	{
		int result;
		try
		{
			BattleUIController battleUIController = (BattleUIController)LuaObject.checkSelf(l);
			GameObject skillListGameObject;
			LuaObject.checkType<GameObject>(l, 2, out skillListGameObject);
			battleUIController.m_luaExportHelper.m_skillListGameObject = skillListGameObject;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601C1E9 RID: 115177 RVA: 0x008A6A20 File Offset: 0x008A4C20
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_m_skillListUIStateController(IntPtr l)
	{
		int result;
		try
		{
			BattleUIController battleUIController = (BattleUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, battleUIController.m_luaExportHelper.m_skillListUIStateController);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601C1EA RID: 115178 RVA: 0x008A6A78 File Offset: 0x008A4C78
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_m_skillListUIStateController(IntPtr l)
	{
		int result;
		try
		{
			BattleUIController battleUIController = (BattleUIController)LuaObject.checkSelf(l);
			CommonUIStateController skillListUIStateController;
			LuaObject.checkType<CommonUIStateController>(l, 2, out skillListUIStateController);
			battleUIController.m_luaExportHelper.m_skillListUIStateController = skillListUIStateController;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601C1EB RID: 115179 RVA: 0x008A6AD4 File Offset: 0x008A4CD4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_skillDescGameObject(IntPtr l)
	{
		int result;
		try
		{
			BattleUIController battleUIController = (BattleUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, battleUIController.m_luaExportHelper.m_skillDescGameObject);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601C1EC RID: 115180 RVA: 0x008A6B2C File Offset: 0x008A4D2C
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_m_skillDescGameObject(IntPtr l)
	{
		int result;
		try
		{
			BattleUIController battleUIController = (BattleUIController)LuaObject.checkSelf(l);
			GameObject skillDescGameObject;
			LuaObject.checkType<GameObject>(l, 2, out skillDescGameObject);
			battleUIController.m_luaExportHelper.m_skillDescGameObject = skillDescGameObject;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601C1ED RID: 115181 RVA: 0x008A6B88 File Offset: 0x008A4D88
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_skillHintUIStateController(IntPtr l)
	{
		int result;
		try
		{
			BattleUIController battleUIController = (BattleUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, battleUIController.m_luaExportHelper.m_skillHintUIStateController);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601C1EE RID: 115182 RVA: 0x008A6BE0 File Offset: 0x008A4DE0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_skillHintUIStateController(IntPtr l)
	{
		int result;
		try
		{
			BattleUIController battleUIController = (BattleUIController)LuaObject.checkSelf(l);
			CommonUIStateController skillHintUIStateController;
			LuaObject.checkType<CommonUIStateController>(l, 2, out skillHintUIStateController);
			battleUIController.m_luaExportHelper.m_skillHintUIStateController = skillHintUIStateController;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601C1EF RID: 115183 RVA: 0x008A6C3C File Offset: 0x008A4E3C
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_m_skillHintText(IntPtr l)
	{
		int result;
		try
		{
			BattleUIController battleUIController = (BattleUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, battleUIController.m_luaExportHelper.m_skillHintText);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601C1F0 RID: 115184 RVA: 0x008A6C94 File Offset: 0x008A4E94
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_m_skillHintText(IntPtr l)
	{
		int result;
		try
		{
			BattleUIController battleUIController = (BattleUIController)LuaObject.checkSelf(l);
			Text skillHintText;
			LuaObject.checkType<Text>(l, 2, out skillHintText);
			battleUIController.m_luaExportHelper.m_skillHintText = skillHintText;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601C1F1 RID: 115185 RVA: 0x008A6CF0 File Offset: 0x008A4EF0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_statusUIStateController(IntPtr l)
	{
		int result;
		try
		{
			BattleUIController battleUIController = (BattleUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, battleUIController.m_luaExportHelper.m_statusUIStateController);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601C1F2 RID: 115186 RVA: 0x008A6D48 File Offset: 0x008A4F48
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_statusUIStateController(IntPtr l)
	{
		int result;
		try
		{
			BattleUIController battleUIController = (BattleUIController)LuaObject.checkSelf(l);
			CommonUIStateController statusUIStateController;
			LuaObject.checkType<CommonUIStateController>(l, 2, out statusUIStateController);
			battleUIController.m_luaExportHelper.m_statusUIStateController = statusUIStateController;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601C1F3 RID: 115187 RVA: 0x008A6DA4 File Offset: 0x008A4FA4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_statusTurnText(IntPtr l)
	{
		int result;
		try
		{
			BattleUIController battleUIController = (BattleUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, battleUIController.m_luaExportHelper.m_statusTurnText);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601C1F4 RID: 115188 RVA: 0x008A6DFC File Offset: 0x008A4FFC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_statusTurnText(IntPtr l)
	{
		int result;
		try
		{
			BattleUIController battleUIController = (BattleUIController)LuaObject.checkSelf(l);
			Text statusTurnText;
			LuaObject.checkType<Text>(l, 2, out statusTurnText);
			battleUIController.m_luaExportHelper.m_statusTurnText = statusTurnText;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601C1F5 RID: 115189 RVA: 0x008A6E58 File Offset: 0x008A5058
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_statusWinDescGameObject1(IntPtr l)
	{
		int result;
		try
		{
			BattleUIController battleUIController = (BattleUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, battleUIController.m_luaExportHelper.m_statusWinDescGameObject1);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601C1F6 RID: 115190 RVA: 0x008A6EB0 File Offset: 0x008A50B0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_statusWinDescGameObject1(IntPtr l)
	{
		int result;
		try
		{
			BattleUIController battleUIController = (BattleUIController)LuaObject.checkSelf(l);
			GameObject statusWinDescGameObject;
			LuaObject.checkType<GameObject>(l, 2, out statusWinDescGameObject);
			battleUIController.m_luaExportHelper.m_statusWinDescGameObject1 = statusWinDescGameObject;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601C1F7 RID: 115191 RVA: 0x008A6F0C File Offset: 0x008A510C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_statusWinDescText1(IntPtr l)
	{
		int result;
		try
		{
			BattleUIController battleUIController = (BattleUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, battleUIController.m_luaExportHelper.m_statusWinDescText1);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601C1F8 RID: 115192 RVA: 0x008A6F64 File Offset: 0x008A5164
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_statusWinDescText1(IntPtr l)
	{
		int result;
		try
		{
			BattleUIController battleUIController = (BattleUIController)LuaObject.checkSelf(l);
			Text statusWinDescText;
			LuaObject.checkType<Text>(l, 2, out statusWinDescText);
			battleUIController.m_luaExportHelper.m_statusWinDescText1 = statusWinDescText;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601C1F9 RID: 115193 RVA: 0x008A6FC0 File Offset: 0x008A51C0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_statusWinDescGameObject2(IntPtr l)
	{
		int result;
		try
		{
			BattleUIController battleUIController = (BattleUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, battleUIController.m_luaExportHelper.m_statusWinDescGameObject2);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601C1FA RID: 115194 RVA: 0x008A7018 File Offset: 0x008A5218
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_statusWinDescGameObject2(IntPtr l)
	{
		int result;
		try
		{
			BattleUIController battleUIController = (BattleUIController)LuaObject.checkSelf(l);
			GameObject statusWinDescGameObject;
			LuaObject.checkType<GameObject>(l, 2, out statusWinDescGameObject);
			battleUIController.m_luaExportHelper.m_statusWinDescGameObject2 = statusWinDescGameObject;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601C1FB RID: 115195 RVA: 0x008A7074 File Offset: 0x008A5274
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_statusWinDescText2(IntPtr l)
	{
		int result;
		try
		{
			BattleUIController battleUIController = (BattleUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, battleUIController.m_luaExportHelper.m_statusWinDescText2);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601C1FC RID: 115196 RVA: 0x008A70CC File Offset: 0x008A52CC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_statusWinDescText2(IntPtr l)
	{
		int result;
		try
		{
			BattleUIController battleUIController = (BattleUIController)LuaObject.checkSelf(l);
			Text statusWinDescText;
			LuaObject.checkType<Text>(l, 2, out statusWinDescText);
			battleUIController.m_luaExportHelper.m_statusWinDescText2 = statusWinDescText;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601C1FD RID: 115197 RVA: 0x008A7128 File Offset: 0x008A5328
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_danmakuStateCtrl(IntPtr l)
	{
		int result;
		try
		{
			BattleUIController battleUIController = (BattleUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, battleUIController.m_luaExportHelper.m_danmakuStateCtrl);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601C1FE RID: 115198 RVA: 0x008A7180 File Offset: 0x008A5380
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_danmakuStateCtrl(IntPtr l)
	{
		int result;
		try
		{
			BattleUIController battleUIController = (BattleUIController)LuaObject.checkSelf(l);
			CommonUIStateController danmakuStateCtrl;
			LuaObject.checkType<CommonUIStateController>(l, 2, out danmakuStateCtrl);
			battleUIController.m_luaExportHelper.m_danmakuStateCtrl = danmakuStateCtrl;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601C1FF RID: 115199 RVA: 0x008A71DC File Offset: 0x008A53DC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_danmakuInputBackButton(IntPtr l)
	{
		int result;
		try
		{
			BattleUIController battleUIController = (BattleUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, battleUIController.m_luaExportHelper.m_danmakuInputBackButton);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601C200 RID: 115200 RVA: 0x008A7234 File Offset: 0x008A5434
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_danmakuInputBackButton(IntPtr l)
	{
		int result;
		try
		{
			BattleUIController battleUIController = (BattleUIController)LuaObject.checkSelf(l);
			Button danmakuInputBackButton;
			LuaObject.checkType<Button>(l, 2, out danmakuInputBackButton);
			battleUIController.m_luaExportHelper.m_danmakuInputBackButton = danmakuInputBackButton;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601C201 RID: 115201 RVA: 0x008A7290 File Offset: 0x008A5490
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_danmakuToggle(IntPtr l)
	{
		int result;
		try
		{
			BattleUIController battleUIController = (BattleUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, battleUIController.m_luaExportHelper.m_danmakuToggle);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601C202 RID: 115202 RVA: 0x008A72E8 File Offset: 0x008A54E8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_danmakuToggle(IntPtr l)
	{
		int result;
		try
		{
			BattleUIController battleUIController = (BattleUIController)LuaObject.checkSelf(l);
			Toggle danmakuToggle;
			LuaObject.checkType<Toggle>(l, 2, out danmakuToggle);
			battleUIController.m_luaExportHelper.m_danmakuToggle = danmakuToggle;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601C203 RID: 115203 RVA: 0x008A7344 File Offset: 0x008A5544
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_danmakuInputWordButton(IntPtr l)
	{
		int result;
		try
		{
			BattleUIController battleUIController = (BattleUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, battleUIController.m_luaExportHelper.m_danmakuInputWordButton);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601C204 RID: 115204 RVA: 0x008A739C File Offset: 0x008A559C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_danmakuInputWordButton(IntPtr l)
	{
		int result;
		try
		{
			BattleUIController battleUIController = (BattleUIController)LuaObject.checkSelf(l);
			Button danmakuInputWordButton;
			LuaObject.checkType<Button>(l, 2, out danmakuInputWordButton);
			battleUIController.m_luaExportHelper.m_danmakuInputWordButton = danmakuInputWordButton;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601C205 RID: 115205 RVA: 0x008A73F8 File Offset: 0x008A55F8
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_m_danmakuInputField(IntPtr l)
	{
		int result;
		try
		{
			BattleUIController battleUIController = (BattleUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, battleUIController.m_luaExportHelper.m_danmakuInputField);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601C206 RID: 115206 RVA: 0x008A7450 File Offset: 0x008A5650
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_danmakuInputField(IntPtr l)
	{
		int result;
		try
		{
			BattleUIController battleUIController = (BattleUIController)LuaObject.checkSelf(l);
			InputField danmakuInputField;
			LuaObject.checkType<InputField>(l, 2, out danmakuInputField);
			battleUIController.m_luaExportHelper.m_danmakuInputField = danmakuInputField;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601C207 RID: 115207 RVA: 0x008A74AC File Offset: 0x008A56AC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_danmakuSendButton(IntPtr l)
	{
		int result;
		try
		{
			BattleUIController battleUIController = (BattleUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, battleUIController.m_luaExportHelper.m_danmakuSendButton);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601C208 RID: 115208 RVA: 0x008A7504 File Offset: 0x008A5704
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_danmakuSendButton(IntPtr l)
	{
		int result;
		try
		{
			BattleUIController battleUIController = (BattleUIController)LuaObject.checkSelf(l);
			Button danmakuSendButton;
			LuaObject.checkType<Button>(l, 2, out danmakuSendButton);
			battleUIController.m_luaExportHelper.m_danmakuSendButton = danmakuSendButton;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601C209 RID: 115209 RVA: 0x008A7560 File Offset: 0x008A5760
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_regretUIStateController(IntPtr l)
	{
		int result;
		try
		{
			BattleUIController battleUIController = (BattleUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, battleUIController.m_luaExportHelper.m_regretUIStateController);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601C20A RID: 115210 RVA: 0x008A75B8 File Offset: 0x008A57B8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_regretUIStateController(IntPtr l)
	{
		int result;
		try
		{
			BattleUIController battleUIController = (BattleUIController)LuaObject.checkSelf(l);
			CommonUIStateController regretUIStateController;
			LuaObject.checkType<CommonUIStateController>(l, 2, out regretUIStateController);
			battleUIController.m_luaExportHelper.m_regretUIStateController = regretUIStateController;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601C20B RID: 115211 RVA: 0x008A7614 File Offset: 0x008A5814
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_regretPanelGameObject(IntPtr l)
	{
		int result;
		try
		{
			BattleUIController battleUIController = (BattleUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, battleUIController.m_luaExportHelper.m_regretPanelGameObject);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601C20C RID: 115212 RVA: 0x008A766C File Offset: 0x008A586C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_regretPanelGameObject(IntPtr l)
	{
		int result;
		try
		{
			BattleUIController battleUIController = (BattleUIController)LuaObject.checkSelf(l);
			GameObject regretPanelGameObject;
			LuaObject.checkType<GameObject>(l, 2, out regretPanelGameObject);
			battleUIController.m_luaExportHelper.m_regretPanelGameObject = regretPanelGameObject;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601C20D RID: 115213 RVA: 0x008A76C8 File Offset: 0x008A58C8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_regratConfirmButton(IntPtr l)
	{
		int result;
		try
		{
			BattleUIController battleUIController = (BattleUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, battleUIController.m_luaExportHelper.m_regratConfirmButton);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601C20E RID: 115214 RVA: 0x008A7720 File Offset: 0x008A5920
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_regratConfirmButton(IntPtr l)
	{
		int result;
		try
		{
			BattleUIController battleUIController = (BattleUIController)LuaObject.checkSelf(l);
			Button regratConfirmButton;
			LuaObject.checkType<Button>(l, 2, out regratConfirmButton);
			battleUIController.m_luaExportHelper.m_regratConfirmButton = regratConfirmButton;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601C20F RID: 115215 RVA: 0x008A777C File Offset: 0x008A597C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_regretConfirmUIStateController(IntPtr l)
	{
		int result;
		try
		{
			BattleUIController battleUIController = (BattleUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, battleUIController.m_luaExportHelper.m_regretConfirmUIStateController);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601C210 RID: 115216 RVA: 0x008A77D4 File Offset: 0x008A59D4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_regretConfirmUIStateController(IntPtr l)
	{
		int result;
		try
		{
			BattleUIController battleUIController = (BattleUIController)LuaObject.checkSelf(l);
			CommonUIStateController regretConfirmUIStateController;
			LuaObject.checkType<CommonUIStateController>(l, 2, out regretConfirmUIStateController);
			battleUIController.m_luaExportHelper.m_regretConfirmUIStateController = regretConfirmUIStateController;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601C211 RID: 115217 RVA: 0x008A7830 File Offset: 0x008A5A30
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_regretCancelButton(IntPtr l)
	{
		int result;
		try
		{
			BattleUIController battleUIController = (BattleUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, battleUIController.m_luaExportHelper.m_regretCancelButton);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601C212 RID: 115218 RVA: 0x008A7888 File Offset: 0x008A5A88
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_regretCancelButton(IntPtr l)
	{
		int result;
		try
		{
			BattleUIController battleUIController = (BattleUIController)LuaObject.checkSelf(l);
			Button regretCancelButton;
			LuaObject.checkType<Button>(l, 2, out regretCancelButton);
			battleUIController.m_luaExportHelper.m_regretCancelButton = regretCancelButton;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601C213 RID: 115219 RVA: 0x008A78E4 File Offset: 0x008A5AE4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_regretBackwardButton(IntPtr l)
	{
		int result;
		try
		{
			BattleUIController battleUIController = (BattleUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, battleUIController.m_luaExportHelper.m_regretBackwardButton);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601C214 RID: 115220 RVA: 0x008A793C File Offset: 0x008A5B3C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_regretBackwardButton(IntPtr l)
	{
		int result;
		try
		{
			BattleUIController battleUIController = (BattleUIController)LuaObject.checkSelf(l);
			Button regretBackwardButton;
			LuaObject.checkType<Button>(l, 2, out regretBackwardButton);
			battleUIController.m_luaExportHelper.m_regretBackwardButton = regretBackwardButton;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601C215 RID: 115221 RVA: 0x008A7998 File Offset: 0x008A5B98
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_regretBackwardUIStateController(IntPtr l)
	{
		int result;
		try
		{
			BattleUIController battleUIController = (BattleUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, battleUIController.m_luaExportHelper.m_regretBackwardUIStateController);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601C216 RID: 115222 RVA: 0x008A79F0 File Offset: 0x008A5BF0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_regretBackwardUIStateController(IntPtr l)
	{
		int result;
		try
		{
			BattleUIController battleUIController = (BattleUIController)LuaObject.checkSelf(l);
			CommonUIStateController regretBackwardUIStateController;
			LuaObject.checkType<CommonUIStateController>(l, 2, out regretBackwardUIStateController);
			battleUIController.m_luaExportHelper.m_regretBackwardUIStateController = regretBackwardUIStateController;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601C217 RID: 115223 RVA: 0x008A7A4C File Offset: 0x008A5C4C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_regretForwardButton(IntPtr l)
	{
		int result;
		try
		{
			BattleUIController battleUIController = (BattleUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, battleUIController.m_luaExportHelper.m_regretForwardButton);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601C218 RID: 115224 RVA: 0x008A7AA4 File Offset: 0x008A5CA4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_regretForwardButton(IntPtr l)
	{
		int result;
		try
		{
			BattleUIController battleUIController = (BattleUIController)LuaObject.checkSelf(l);
			Button regretForwardButton;
			LuaObject.checkType<Button>(l, 2, out regretForwardButton);
			battleUIController.m_luaExportHelper.m_regretForwardButton = regretForwardButton;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601C219 RID: 115225 RVA: 0x008A7B00 File Offset: 0x008A5D00
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_regretForwardUIStateController(IntPtr l)
	{
		int result;
		try
		{
			BattleUIController battleUIController = (BattleUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, battleUIController.m_luaExportHelper.m_regretForwardUIStateController);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601C21A RID: 115226 RVA: 0x008A7B58 File Offset: 0x008A5D58
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_regretForwardUIStateController(IntPtr l)
	{
		int result;
		try
		{
			BattleUIController battleUIController = (BattleUIController)LuaObject.checkSelf(l);
			CommonUIStateController regretForwardUIStateController;
			LuaObject.checkType<CommonUIStateController>(l, 2, out regretForwardUIStateController);
			battleUIController.m_luaExportHelper.m_regretForwardUIStateController = regretForwardUIStateController;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601C21B RID: 115227 RVA: 0x008A7BB4 File Offset: 0x008A5DB4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_regretTurnText(IntPtr l)
	{
		int result;
		try
		{
			BattleUIController battleUIController = (BattleUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, battleUIController.m_luaExportHelper.m_regretTurnText);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601C21C RID: 115228 RVA: 0x008A7C0C File Offset: 0x008A5E0C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_regretTurnText(IntPtr l)
	{
		int result;
		try
		{
			BattleUIController battleUIController = (BattleUIController)LuaObject.checkSelf(l);
			Text regretTurnText;
			LuaObject.checkType<Text>(l, 2, out regretTurnText);
			battleUIController.m_luaExportHelper.m_regretTurnText = regretTurnText;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601C21D RID: 115229 RVA: 0x008A7C68 File Offset: 0x008A5E68
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_regretActionText(IntPtr l)
	{
		int result;
		try
		{
			BattleUIController battleUIController = (BattleUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, battleUIController.m_luaExportHelper.m_regretActionText);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601C21E RID: 115230 RVA: 0x008A7CC0 File Offset: 0x008A5EC0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_regretActionText(IntPtr l)
	{
		int result;
		try
		{
			BattleUIController battleUIController = (BattleUIController)LuaObject.checkSelf(l);
			Text regretActionText;
			LuaObject.checkType<Text>(l, 2, out regretActionText);
			battleUIController.m_luaExportHelper.m_regretActionText = regretActionText;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601C21F RID: 115231 RVA: 0x008A7D1C File Offset: 0x008A5F1C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_regretTurnUIStateController(IntPtr l)
	{
		int result;
		try
		{
			BattleUIController battleUIController = (BattleUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, battleUIController.m_luaExportHelper.m_regretTurnUIStateController);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601C220 RID: 115232 RVA: 0x008A7D74 File Offset: 0x008A5F74
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_regretTurnUIStateController(IntPtr l)
	{
		int result;
		try
		{
			BattleUIController battleUIController = (BattleUIController)LuaObject.checkSelf(l);
			CommonUIStateController regretTurnUIStateController;
			LuaObject.checkType<CommonUIStateController>(l, 2, out regretTurnUIStateController);
			battleUIController.m_luaExportHelper.m_regretTurnUIStateController = regretTurnUIStateController;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601C221 RID: 115233 RVA: 0x008A7DD0 File Offset: 0x008A5FD0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_regretMyCountText(IntPtr l)
	{
		int result;
		try
		{
			BattleUIController battleUIController = (BattleUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, battleUIController.m_luaExportHelper.m_regretMyCountText);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601C222 RID: 115234 RVA: 0x008A7E28 File Offset: 0x008A6028
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_regretMyCountText(IntPtr l)
	{
		int result;
		try
		{
			BattleUIController battleUIController = (BattleUIController)LuaObject.checkSelf(l);
			Text regretMyCountText;
			LuaObject.checkType<Text>(l, 2, out regretMyCountText);
			battleUIController.m_luaExportHelper.m_regretMyCountText = regretMyCountText;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601C223 RID: 115235 RVA: 0x008A7E84 File Offset: 0x008A6084
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_regretEnemyCountText(IntPtr l)
	{
		int result;
		try
		{
			BattleUIController battleUIController = (BattleUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, battleUIController.m_luaExportHelper.m_regretEnemyCountText);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601C224 RID: 115236 RVA: 0x008A7EDC File Offset: 0x008A60DC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_regretEnemyCountText(IntPtr l)
	{
		int result;
		try
		{
			BattleUIController battleUIController = (BattleUIController)LuaObject.checkSelf(l);
			Text regretEnemyCountText;
			LuaObject.checkType<Text>(l, 2, out regretEnemyCountText);
			battleUIController.m_luaExportHelper.m_regretEnemyCountText = regretEnemyCountText;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601C225 RID: 115237 RVA: 0x008A7F38 File Offset: 0x008A6138
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_regretEffectUIStateController(IntPtr l)
	{
		int result;
		try
		{
			BattleUIController battleUIController = (BattleUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, battleUIController.m_luaExportHelper.m_regretEffectUIStateController);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601C226 RID: 115238 RVA: 0x008A7F90 File Offset: 0x008A6190
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_regretEffectUIStateController(IntPtr l)
	{
		int result;
		try
		{
			BattleUIController battleUIController = (BattleUIController)LuaObject.checkSelf(l);
			CommonUIStateController regretEffectUIStateController;
			LuaObject.checkType<CommonUIStateController>(l, 2, out regretEffectUIStateController);
			battleUIController.m_luaExportHelper.m_regretEffectUIStateController = regretEffectUIStateController;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601C227 RID: 115239 RVA: 0x008A7FEC File Offset: 0x008A61EC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_regretFxUIStateController(IntPtr l)
	{
		int result;
		try
		{
			BattleUIController battleUIController = (BattleUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, battleUIController.m_luaExportHelper.m_regretFxUIStateController);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601C228 RID: 115240 RVA: 0x008A8044 File Offset: 0x008A6244
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_m_regretFxUIStateController(IntPtr l)
	{
		int result;
		try
		{
			BattleUIController battleUIController = (BattleUIController)LuaObject.checkSelf(l);
			CommonUIStateController regretFxUIStateController;
			LuaObject.checkType<CommonUIStateController>(l, 2, out regretFxUIStateController);
			battleUIController.m_luaExportHelper.m_regretFxUIStateController = regretFxUIStateController;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601C229 RID: 115241 RVA: 0x008A80A0 File Offset: 0x008A62A0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_cutsceneSkillUIStateController(IntPtr l)
	{
		int result;
		try
		{
			BattleUIController battleUIController = (BattleUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, battleUIController.m_luaExportHelper.m_cutsceneSkillUIStateController);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601C22A RID: 115242 RVA: 0x008A80F8 File Offset: 0x008A62F8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_cutsceneSkillUIStateController(IntPtr l)
	{
		int result;
		try
		{
			BattleUIController battleUIController = (BattleUIController)LuaObject.checkSelf(l);
			CommonUIStateController cutsceneSkillUIStateController;
			LuaObject.checkType<CommonUIStateController>(l, 2, out cutsceneSkillUIStateController);
			battleUIController.m_luaExportHelper.m_cutsceneSkillUIStateController = cutsceneSkillUIStateController;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601C22B RID: 115243 RVA: 0x008A8154 File Offset: 0x008A6354
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_cutsceneSkillIconImage(IntPtr l)
	{
		int result;
		try
		{
			BattleUIController battleUIController = (BattleUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, battleUIController.m_luaExportHelper.m_cutsceneSkillIconImage);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601C22C RID: 115244 RVA: 0x008A81AC File Offset: 0x008A63AC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_cutsceneSkillIconImage(IntPtr l)
	{
		int result;
		try
		{
			BattleUIController battleUIController = (BattleUIController)LuaObject.checkSelf(l);
			Image cutsceneSkillIconImage;
			LuaObject.checkType<Image>(l, 2, out cutsceneSkillIconImage);
			battleUIController.m_luaExportHelper.m_cutsceneSkillIconImage = cutsceneSkillIconImage;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601C22D RID: 115245 RVA: 0x008A8208 File Offset: 0x008A6408
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_cutsceneSkillNameText(IntPtr l)
	{
		int result;
		try
		{
			BattleUIController battleUIController = (BattleUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, battleUIController.m_luaExportHelper.m_cutsceneSkillNameText);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601C22E RID: 115246 RVA: 0x008A8260 File Offset: 0x008A6460
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_cutsceneSkillNameText(IntPtr l)
	{
		int result;
		try
		{
			BattleUIController battleUIController = (BattleUIController)LuaObject.checkSelf(l);
			Text cutsceneSkillNameText;
			LuaObject.checkType<Text>(l, 2, out cutsceneSkillNameText);
			battleUIController.m_luaExportHelper.m_cutsceneSkillNameText = cutsceneSkillNameText;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601C22F RID: 115247 RVA: 0x008A82BC File Offset: 0x008A64BC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_objectiveGameObject(IntPtr l)
	{
		int result;
		try
		{
			BattleUIController battleUIController = (BattleUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, battleUIController.m_luaExportHelper.m_objectiveGameObject);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601C230 RID: 115248 RVA: 0x008A8314 File Offset: 0x008A6514
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_objectiveGameObject(IntPtr l)
	{
		int result;
		try
		{
			BattleUIController battleUIController = (BattleUIController)LuaObject.checkSelf(l);
			GameObject objectiveGameObject;
			LuaObject.checkType<GameObject>(l, 2, out objectiveGameObject);
			battleUIController.m_luaExportHelper.m_objectiveGameObject = objectiveGameObject;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601C231 RID: 115249 RVA: 0x008A8370 File Offset: 0x008A6570
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_objectiveWinDescText(IntPtr l)
	{
		int result;
		try
		{
			BattleUIController battleUIController = (BattleUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, battleUIController.m_luaExportHelper.m_objectiveWinDescText);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601C232 RID: 115250 RVA: 0x008A83C8 File Offset: 0x008A65C8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_objectiveWinDescText(IntPtr l)
	{
		int result;
		try
		{
			BattleUIController battleUIController = (BattleUIController)LuaObject.checkSelf(l);
			Text objectiveWinDescText;
			LuaObject.checkType<Text>(l, 2, out objectiveWinDescText);
			battleUIController.m_luaExportHelper.m_objectiveWinDescText = objectiveWinDescText;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601C233 RID: 115251 RVA: 0x008A8424 File Offset: 0x008A6624
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_objectiveLoseDescText(IntPtr l)
	{
		int result;
		try
		{
			BattleUIController battleUIController = (BattleUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, battleUIController.m_luaExportHelper.m_objectiveLoseDescText);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601C234 RID: 115252 RVA: 0x008A847C File Offset: 0x008A667C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_objectiveLoseDescText(IntPtr l)
	{
		int result;
		try
		{
			BattleUIController battleUIController = (BattleUIController)LuaObject.checkSelf(l);
			Text objectiveLoseDescText;
			LuaObject.checkType<Text>(l, 2, out objectiveLoseDescText);
			battleUIController.m_luaExportHelper.m_objectiveLoseDescText = objectiveLoseDescText;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601C235 RID: 115253 RVA: 0x008A84D8 File Offset: 0x008A66D8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_winGameObject(IntPtr l)
	{
		int result;
		try
		{
			BattleUIController battleUIController = (BattleUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, battleUIController.m_luaExportHelper.m_winGameObject);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601C236 RID: 115254 RVA: 0x008A8530 File Offset: 0x008A6730
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_winGameObject(IntPtr l)
	{
		int result;
		try
		{
			BattleUIController battleUIController = (BattleUIController)LuaObject.checkSelf(l);
			GameObject winGameObject;
			LuaObject.checkType<GameObject>(l, 2, out winGameObject);
			battleUIController.m_luaExportHelper.m_winGameObject = winGameObject;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601C237 RID: 115255 RVA: 0x008A858C File Offset: 0x008A678C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_loseGameObject(IntPtr l)
	{
		int result;
		try
		{
			BattleUIController battleUIController = (BattleUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, battleUIController.m_luaExportHelper.m_loseGameObject);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601C238 RID: 115256 RVA: 0x008A85E4 File Offset: 0x008A67E4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_loseGameObject(IntPtr l)
	{
		int result;
		try
		{
			BattleUIController battleUIController = (BattleUIController)LuaObject.checkSelf(l);
			GameObject loseGameObject;
			LuaObject.checkType<GameObject>(l, 2, out loseGameObject);
			battleUIController.m_luaExportHelper.m_loseGameObject = loseGameObject;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601C239 RID: 115257 RVA: 0x008A8640 File Offset: 0x008A6840
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_turnStartGameObject(IntPtr l)
	{
		int result;
		try
		{
			BattleUIController battleUIController = (BattleUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, battleUIController.m_luaExportHelper.m_turnStartGameObject);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601C23A RID: 115258 RVA: 0x008A8698 File Offset: 0x008A6898
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_turnStartGameObject(IntPtr l)
	{
		int result;
		try
		{
			BattleUIController battleUIController = (BattleUIController)LuaObject.checkSelf(l);
			GameObject turnStartGameObject;
			LuaObject.checkType<GameObject>(l, 2, out turnStartGameObject);
			battleUIController.m_luaExportHelper.m_turnStartGameObject = turnStartGameObject;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601C23B RID: 115259 RVA: 0x008A86F4 File Offset: 0x008A68F4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_turnStartText(IntPtr l)
	{
		int result;
		try
		{
			BattleUIController battleUIController = (BattleUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, battleUIController.m_luaExportHelper.m_turnStartText);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601C23C RID: 115260 RVA: 0x008A874C File Offset: 0x008A694C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_turnStartText(IntPtr l)
	{
		int result;
		try
		{
			BattleUIController battleUIController = (BattleUIController)LuaObject.checkSelf(l);
			Text turnStartText;
			LuaObject.checkType<Text>(l, 2, out turnStartText);
			battleUIController.m_luaExportHelper.m_turnStartText = turnStartText;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601C23D RID: 115261 RVA: 0x008A87A8 File Offset: 0x008A69A8
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_m_playerTurnGameObject(IntPtr l)
	{
		int result;
		try
		{
			BattleUIController battleUIController = (BattleUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, battleUIController.m_luaExportHelper.m_playerTurnGameObject);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601C23E RID: 115262 RVA: 0x008A8800 File Offset: 0x008A6A00
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_playerTurnGameObject(IntPtr l)
	{
		int result;
		try
		{
			BattleUIController battleUIController = (BattleUIController)LuaObject.checkSelf(l);
			GameObject playerTurnGameObject;
			LuaObject.checkType<GameObject>(l, 2, out playerTurnGameObject);
			battleUIController.m_luaExportHelper.m_playerTurnGameObject = playerTurnGameObject;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601C23F RID: 115263 RVA: 0x008A885C File Offset: 0x008A6A5C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_enemyTurnGameObject(IntPtr l)
	{
		int result;
		try
		{
			BattleUIController battleUIController = (BattleUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, battleUIController.m_luaExportHelper.m_enemyTurnGameObject);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601C240 RID: 115264 RVA: 0x008A88B4 File Offset: 0x008A6AB4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_enemyTurnGameObject(IntPtr l)
	{
		int result;
		try
		{
			BattleUIController battleUIController = (BattleUIController)LuaObject.checkSelf(l);
			GameObject enemyTurnGameObject;
			LuaObject.checkType<GameObject>(l, 2, out enemyTurnGameObject);
			battleUIController.m_luaExportHelper.m_enemyTurnGameObject = enemyTurnGameObject;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601C241 RID: 115265 RVA: 0x008A8910 File Offset: 0x008A6B10
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_myActionUIStateController(IntPtr l)
	{
		int result;
		try
		{
			BattleUIController battleUIController = (BattleUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, battleUIController.m_luaExportHelper.m_myActionUIStateController);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601C242 RID: 115266 RVA: 0x008A8968 File Offset: 0x008A6B68
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_myActionUIStateController(IntPtr l)
	{
		int result;
		try
		{
			BattleUIController battleUIController = (BattleUIController)LuaObject.checkSelf(l);
			CommonUIStateController myActionUIStateController;
			LuaObject.checkType<CommonUIStateController>(l, 2, out myActionUIStateController);
			battleUIController.m_luaExportHelper.m_myActionUIStateController = myActionUIStateController;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601C243 RID: 115267 RVA: 0x008A89C4 File Offset: 0x008A6BC4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_myActionHeadImage(IntPtr l)
	{
		int result;
		try
		{
			BattleUIController battleUIController = (BattleUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, battleUIController.m_luaExportHelper.m_myActionHeadImage);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601C244 RID: 115268 RVA: 0x008A8A1C File Offset: 0x008A6C1C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_myActionHeadImage(IntPtr l)
	{
		int result;
		try
		{
			BattleUIController battleUIController = (BattleUIController)LuaObject.checkSelf(l);
			Image myActionHeadImage;
			LuaObject.checkType<Image>(l, 2, out myActionHeadImage);
			battleUIController.m_luaExportHelper.m_myActionHeadImage = myActionHeadImage;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601C245 RID: 115269 RVA: 0x008A8A78 File Offset: 0x008A6C78
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_myActionNameText(IntPtr l)
	{
		int result;
		try
		{
			BattleUIController battleUIController = (BattleUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, battleUIController.m_luaExportHelper.m_myActionNameText);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601C246 RID: 115270 RVA: 0x008A8AD0 File Offset: 0x008A6CD0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_myActionNameText(IntPtr l)
	{
		int result;
		try
		{
			BattleUIController battleUIController = (BattleUIController)LuaObject.checkSelf(l);
			Text myActionNameText;
			LuaObject.checkType<Text>(l, 2, out myActionNameText);
			battleUIController.m_luaExportHelper.m_myActionNameText = myActionNameText;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601C247 RID: 115271 RVA: 0x008A8B2C File Offset: 0x008A6D2C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_myActionPlayerTagImage(IntPtr l)
	{
		int result;
		try
		{
			BattleUIController battleUIController = (BattleUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, battleUIController.m_luaExportHelper.m_myActionPlayerTagImage);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601C248 RID: 115272 RVA: 0x008A8B84 File Offset: 0x008A6D84
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_myActionPlayerTagImage(IntPtr l)
	{
		int result;
		try
		{
			BattleUIController battleUIController = (BattleUIController)LuaObject.checkSelf(l);
			Image myActionPlayerTagImage;
			LuaObject.checkType<Image>(l, 2, out myActionPlayerTagImage);
			battleUIController.m_luaExportHelper.m_myActionPlayerTagImage = myActionPlayerTagImage;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601C249 RID: 115273 RVA: 0x008A8BE0 File Offset: 0x008A6DE0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_teammateActionUIStateController(IntPtr l)
	{
		int result;
		try
		{
			BattleUIController battleUIController = (BattleUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, battleUIController.m_luaExportHelper.m_teammateActionUIStateController);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601C24A RID: 115274 RVA: 0x008A8C38 File Offset: 0x008A6E38
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_teammateActionUIStateController(IntPtr l)
	{
		int result;
		try
		{
			BattleUIController battleUIController = (BattleUIController)LuaObject.checkSelf(l);
			CommonUIStateController teammateActionUIStateController;
			LuaObject.checkType<CommonUIStateController>(l, 2, out teammateActionUIStateController);
			battleUIController.m_luaExportHelper.m_teammateActionUIStateController = teammateActionUIStateController;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601C24B RID: 115275 RVA: 0x008A8C94 File Offset: 0x008A6E94
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_teammateActionHeadImage(IntPtr l)
	{
		int result;
		try
		{
			BattleUIController battleUIController = (BattleUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, battleUIController.m_luaExportHelper.m_teammateActionHeadImage);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601C24C RID: 115276 RVA: 0x008A8CEC File Offset: 0x008A6EEC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_teammateActionHeadImage(IntPtr l)
	{
		int result;
		try
		{
			BattleUIController battleUIController = (BattleUIController)LuaObject.checkSelf(l);
			Image teammateActionHeadImage;
			LuaObject.checkType<Image>(l, 2, out teammateActionHeadImage);
			battleUIController.m_luaExportHelper.m_teammateActionHeadImage = teammateActionHeadImage;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601C24D RID: 115277 RVA: 0x008A8D48 File Offset: 0x008A6F48
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_teammateActionNameText(IntPtr l)
	{
		int result;
		try
		{
			BattleUIController battleUIController = (BattleUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, battleUIController.m_luaExportHelper.m_teammateActionNameText);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601C24E RID: 115278 RVA: 0x008A8DA0 File Offset: 0x008A6FA0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_teammateActionNameText(IntPtr l)
	{
		int result;
		try
		{
			BattleUIController battleUIController = (BattleUIController)LuaObject.checkSelf(l);
			Text teammateActionNameText;
			LuaObject.checkType<Text>(l, 2, out teammateActionNameText);
			battleUIController.m_luaExportHelper.m_teammateActionNameText = teammateActionNameText;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601C24F RID: 115279 RVA: 0x008A8DFC File Offset: 0x008A6FFC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_teammateActionPlayerTagImage(IntPtr l)
	{
		int result;
		try
		{
			BattleUIController battleUIController = (BattleUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, battleUIController.m_luaExportHelper.m_teammateActionPlayerTagImage);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601C250 RID: 115280 RVA: 0x008A8E54 File Offset: 0x008A7054
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_teammateActionPlayerTagImage(IntPtr l)
	{
		int result;
		try
		{
			BattleUIController battleUIController = (BattleUIController)LuaObject.checkSelf(l);
			Image teammateActionPlayerTagImage;
			LuaObject.checkType<Image>(l, 2, out teammateActionPlayerTagImage);
			battleUIController.m_luaExportHelper.m_teammateActionPlayerTagImage = teammateActionPlayerTagImage;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601C251 RID: 115281 RVA: 0x008A8EB0 File Offset: 0x008A70B0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_enemyActionUIStateController(IntPtr l)
	{
		int result;
		try
		{
			BattleUIController battleUIController = (BattleUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, battleUIController.m_luaExportHelper.m_enemyActionUIStateController);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601C252 RID: 115282 RVA: 0x008A8F08 File Offset: 0x008A7108
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_enemyActionUIStateController(IntPtr l)
	{
		int result;
		try
		{
			BattleUIController battleUIController = (BattleUIController)LuaObject.checkSelf(l);
			CommonUIStateController enemyActionUIStateController;
			LuaObject.checkType<CommonUIStateController>(l, 2, out enemyActionUIStateController);
			battleUIController.m_luaExportHelper.m_enemyActionUIStateController = enemyActionUIStateController;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601C253 RID: 115283 RVA: 0x008A8F64 File Offset: 0x008A7164
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_enemyActionHeadImage(IntPtr l)
	{
		int result;
		try
		{
			BattleUIController battleUIController = (BattleUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, battleUIController.m_luaExportHelper.m_enemyActionHeadImage);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601C254 RID: 115284 RVA: 0x008A8FBC File Offset: 0x008A71BC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_enemyActionHeadImage(IntPtr l)
	{
		int result;
		try
		{
			BattleUIController battleUIController = (BattleUIController)LuaObject.checkSelf(l);
			Image enemyActionHeadImage;
			LuaObject.checkType<Image>(l, 2, out enemyActionHeadImage);
			battleUIController.m_luaExportHelper.m_enemyActionHeadImage = enemyActionHeadImage;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601C255 RID: 115285 RVA: 0x008A9018 File Offset: 0x008A7218
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_enemyActionNameText(IntPtr l)
	{
		int result;
		try
		{
			BattleUIController battleUIController = (BattleUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, battleUIController.m_luaExportHelper.m_enemyActionNameText);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601C256 RID: 115286 RVA: 0x008A9070 File Offset: 0x008A7270
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_enemyActionNameText(IntPtr l)
	{
		int result;
		try
		{
			BattleUIController battleUIController = (BattleUIController)LuaObject.checkSelf(l);
			Text enemyActionNameText;
			LuaObject.checkType<Text>(l, 2, out enemyActionNameText);
			battleUIController.m_luaExportHelper.m_enemyActionNameText = enemyActionNameText;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601C257 RID: 115287 RVA: 0x008A90CC File Offset: 0x008A72CC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_prefabsGameObject(IntPtr l)
	{
		int result;
		try
		{
			BattleUIController battleUIController = (BattleUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, battleUIController.m_luaExportHelper.m_prefabsGameObject);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601C258 RID: 115288 RVA: 0x008A9124 File Offset: 0x008A7324
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_prefabsGameObject(IntPtr l)
	{
		int result;
		try
		{
			BattleUIController battleUIController = (BattleUIController)LuaObject.checkSelf(l);
			GameObject prefabsGameObject;
			LuaObject.checkType<GameObject>(l, 2, out prefabsGameObject);
			battleUIController.m_luaExportHelper.m_prefabsGameObject = prefabsGameObject;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601C259 RID: 115289 RVA: 0x008A9180 File Offset: 0x008A7380
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_battleSkillButtonPrefab(IntPtr l)
	{
		int result;
		try
		{
			BattleUIController battleUIController = (BattleUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, battleUIController.m_luaExportHelper.m_battleSkillButtonPrefab);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601C25A RID: 115290 RVA: 0x008A91D8 File Offset: 0x008A73D8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_battleSkillButtonPrefab(IntPtr l)
	{
		int result;
		try
		{
			BattleUIController battleUIController = (BattleUIController)LuaObject.checkSelf(l);
			GameObject battleSkillButtonPrefab;
			LuaObject.checkType<GameObject>(l, 2, out battleSkillButtonPrefab);
			battleUIController.m_luaExportHelper.m_battleSkillButtonPrefab = battleSkillButtonPrefab;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601C25B RID: 115291 RVA: 0x008A9234 File Offset: 0x008A7434
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_armyRelationButtonUIStateController(IntPtr l)
	{
		int result;
		try
		{
			BattleUIController battleUIController = (BattleUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, battleUIController.m_luaExportHelper.m_armyRelationButtonUIStateController);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601C25C RID: 115292 RVA: 0x008A928C File Offset: 0x008A748C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_armyRelationButtonUIStateController(IntPtr l)
	{
		int result;
		try
		{
			BattleUIController battleUIController = (BattleUIController)LuaObject.checkSelf(l);
			CommonUIStateController armyRelationButtonUIStateController;
			LuaObject.checkType<CommonUIStateController>(l, 2, out armyRelationButtonUIStateController);
			battleUIController.m_luaExportHelper.m_armyRelationButtonUIStateController = armyRelationButtonUIStateController;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601C25D RID: 115293 RVA: 0x008A92E8 File Offset: 0x008A74E8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_armyRelationDescUIStateController(IntPtr l)
	{
		int result;
		try
		{
			BattleUIController battleUIController = (BattleUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, battleUIController.m_luaExportHelper.m_armyRelationDescUIStateController);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601C25E RID: 115294 RVA: 0x008A9340 File Offset: 0x008A7540
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_armyRelationDescUIStateController(IntPtr l)
	{
		int result;
		try
		{
			BattleUIController battleUIController = (BattleUIController)LuaObject.checkSelf(l);
			CommonUIStateController armyRelationDescUIStateController;
			LuaObject.checkType<CommonUIStateController>(l, 2, out armyRelationDescUIStateController);
			battleUIController.m_luaExportHelper.m_armyRelationDescUIStateController = armyRelationDescUIStateController;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601C25F RID: 115295 RVA: 0x008A939C File Offset: 0x008A759C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_pointerDownPosition(IntPtr l)
	{
		int result;
		try
		{
			BattleUIController battleUIController = (BattleUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, battleUIController.m_luaExportHelper.m_pointerDownPosition);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601C260 RID: 115296 RVA: 0x008A93F4 File Offset: 0x008A75F4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_pointerDownPosition(IntPtr l)
	{
		int result;
		try
		{
			BattleUIController battleUIController = (BattleUIController)LuaObject.checkSelf(l);
			Vector2 pointerDownPosition;
			LuaObject.checkType(l, 2, out pointerDownPosition);
			battleUIController.m_luaExportHelper.m_pointerDownPosition = pointerDownPosition;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601C261 RID: 115297 RVA: 0x008A9450 File Offset: 0x008A7650
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_battleSkillButtonPool(IntPtr l)
	{
		int result;
		try
		{
			BattleUIController battleUIController = (BattleUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, battleUIController.m_luaExportHelper.m_battleSkillButtonPool);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601C262 RID: 115298 RVA: 0x008A94A8 File Offset: 0x008A76A8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_battleSkillButtonPool(IntPtr l)
	{
		int result;
		try
		{
			BattleUIController battleUIController = (BattleUIController)LuaObject.checkSelf(l);
			GameObjectPool<BattleSkillButton> battleSkillButtonPool;
			LuaObject.checkType<GameObjectPool<BattleSkillButton>>(l, 2, out battleSkillButtonPool);
			battleUIController.m_luaExportHelper.m_battleSkillButtonPool = battleSkillButtonPool;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601C263 RID: 115299 RVA: 0x008A9504 File Offset: 0x008A7704
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_chatRedPointLastTime(IntPtr l)
	{
		int result;
		try
		{
			BattleUIController battleUIController = (BattleUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, battleUIController.m_luaExportHelper.m_chatRedPointLastTime);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601C264 RID: 115300 RVA: 0x008A955C File Offset: 0x008A775C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_chatRedPointLastTime(IntPtr l)
	{
		int result;
		try
		{
			BattleUIController battleUIController = (BattleUIController)LuaObject.checkSelf(l);
			float chatRedPointLastTime;
			LuaObject.checkType(l, 2, out chatRedPointLastTime);
			battleUIController.m_luaExportHelper.m_chatRedPointLastTime = chatRedPointLastTime;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601C265 RID: 115301 RVA: 0x008A95B8 File Offset: 0x008A77B8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_hideSkillHintTime(IntPtr l)
	{
		int result;
		try
		{
			BattleUIController battleUIController = (BattleUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, battleUIController.m_luaExportHelper.m_hideSkillHintTime);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601C266 RID: 115302 RVA: 0x008A9610 File Offset: 0x008A7810
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_hideSkillHintTime(IntPtr l)
	{
		int result;
		try
		{
			BattleUIController battleUIController = (BattleUIController)LuaObject.checkSelf(l);
			float hideSkillHintTime;
			LuaObject.checkType(l, 2, out hideSkillHintTime);
			battleUIController.m_luaExportHelper.m_hideSkillHintTime = hideSkillHintTime;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601C267 RID: 115303 RVA: 0x008A966C File Offset: 0x008A786C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_isShowSkillHint(IntPtr l)
	{
		int result;
		try
		{
			BattleUIController battleUIController = (BattleUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, battleUIController.m_luaExportHelper.m_isShowSkillHint);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601C268 RID: 115304 RVA: 0x008A96C4 File Offset: 0x008A78C4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_isShowSkillHint(IntPtr l)
	{
		int result;
		try
		{
			BattleUIController battleUIController = (BattleUIController)LuaObject.checkSelf(l);
			bool isShowSkillHint;
			LuaObject.checkType(l, 2, out isShowSkillHint);
			battleUIController.m_luaExportHelper.m_isShowSkillHint = isShowSkillHint;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601C269 RID: 115305 RVA: 0x008A9720 File Offset: 0x008A7920
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_isShowRegretPanel(IntPtr l)
	{
		int result;
		try
		{
			BattleUIController battleUIController = (BattleUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, battleUIController.m_luaExportHelper.m_isShowRegretPanel);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601C26A RID: 115306 RVA: 0x008A9778 File Offset: 0x008A7978
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_isShowRegretPanel(IntPtr l)
	{
		int result;
		try
		{
			BattleUIController battleUIController = (BattleUIController)LuaObject.checkSelf(l);
			bool isShowRegretPanel;
			LuaObject.checkType(l, 2, out isShowRegretPanel);
			battleUIController.m_luaExportHelper.m_isShowRegretPanel = isShowRegretPanel;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601C26B RID: 115307 RVA: 0x008A97D4 File Offset: 0x008A79D4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_developerClickCount(IntPtr l)
	{
		int result;
		try
		{
			BattleUIController battleUIController = (BattleUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, battleUIController.m_luaExportHelper.m_developerClickCount);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601C26C RID: 115308 RVA: 0x008A982C File Offset: 0x008A7A2C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_developerClickCount(IntPtr l)
	{
		int result;
		try
		{
			BattleUIController battleUIController = (BattleUIController)LuaObject.checkSelf(l);
			int developerClickCount;
			LuaObject.checkType(l, 2, out developerClickCount);
			battleUIController.m_luaExportHelper.m_developerClickCount = developerClickCount;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601C26D RID: 115309 RVA: 0x008A9888 File Offset: 0x008A7A88
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_turn(IntPtr l)
	{
		int result;
		try
		{
			BattleUIController battleUIController = (BattleUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, battleUIController.m_luaExportHelper.m_turn);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601C26E RID: 115310 RVA: 0x008A98E0 File Offset: 0x008A7AE0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_turn(IntPtr l)
	{
		int result;
		try
		{
			BattleUIController battleUIController = (BattleUIController)LuaObject.checkSelf(l);
			int turn;
			LuaObject.checkType(l, 2, out turn);
			battleUIController.m_luaExportHelper.m_turn = turn;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601C26F RID: 115311 RVA: 0x008A993C File Offset: 0x008A7B3C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_configDataLoader(IntPtr l)
	{
		int result;
		try
		{
			BattleUIController battleUIController = (BattleUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, battleUIController.m_luaExportHelper.m_configDataLoader);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601C270 RID: 115312 RVA: 0x008A9994 File Offset: 0x008A7B94
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_configDataLoader(IntPtr l)
	{
		int result;
		try
		{
			BattleUIController battleUIController = (BattleUIController)LuaObject.checkSelf(l);
			IConfigDataLoader configDataLoader;
			LuaObject.checkType<IConfigDataLoader>(l, 2, out configDataLoader);
			battleUIController.m_luaExportHelper.m_configDataLoader = configDataLoader;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601C271 RID: 115313 RVA: 0x008A99F0 File Offset: 0x008A7BF0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_playerContext(IntPtr l)
	{
		int result;
		try
		{
			BattleUIController battleUIController = (BattleUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, battleUIController.m_luaExportHelper.m_playerContext);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601C272 RID: 115314 RVA: 0x008A9A48 File Offset: 0x008A7C48
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_playerContext(IntPtr l)
	{
		int result;
		try
		{
			BattleUIController battleUIController = (BattleUIController)LuaObject.checkSelf(l);
			ProjectLPlayerContext playerContext;
			LuaObject.checkType<ProjectLPlayerContext>(l, 2, out playerContext);
			battleUIController.m_luaExportHelper.m_playerContext = playerContext;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601C273 RID: 115315 RVA: 0x008A9AA4 File Offset: 0x008A7CA4
	[Preserve]
	public static void reg(IntPtr l)
	{
		LuaObject.getTypeTable(l, "BlackJack.ProjectL.UI.BattleUIController");
		if (Lua_BlackJack_ProjectL_UI_BattleUIController.<>f__mg$cache0 == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleUIController.<>f__mg$cache0 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleUIController.StartBattle);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_BattleUIController.<>f__mg$cache0);
		if (Lua_BlackJack_ProjectL_UI_BattleUIController.<>f__mg$cache1 == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleUIController.<>f__mg$cache1 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleUIController.StopBattle);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_BattleUIController.<>f__mg$cache1);
		if (Lua_BlackJack_ProjectL_UI_BattleUIController.<>f__mg$cache2 == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleUIController.<>f__mg$cache2 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleUIController.ShowTurnStatus);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_BattleUIController.<>f__mg$cache2);
		if (Lua_BlackJack_ProjectL_UI_BattleUIController.<>f__mg$cache3 == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleUIController.<>f__mg$cache3 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleUIController.ShowObjecive);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_BattleUIController.<>f__mg$cache3);
		if (Lua_BlackJack_ProjectL_UI_BattleUIController.<>f__mg$cache4 == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleUIController.<>f__mg$cache4 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleUIController.ShowTurnStart);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_BattleUIController.<>f__mg$cache4);
		if (Lua_BlackJack_ProjectL_UI_BattleUIController.<>f__mg$cache5 == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleUIController.<>f__mg$cache5 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleUIController.ShowPlayerTurn);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_BattleUIController.<>f__mg$cache5);
		if (Lua_BlackJack_ProjectL_UI_BattleUIController.<>f__mg$cache6 == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleUIController.<>f__mg$cache6 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleUIController.ShowEnemyTurn);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_BattleUIController.<>f__mg$cache6);
		if (Lua_BlackJack_ProjectL_UI_BattleUIController.<>f__mg$cache7 == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleUIController.<>f__mg$cache7 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleUIController.ShowMyAction);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_BattleUIController.<>f__mg$cache7);
		if (Lua_BlackJack_ProjectL_UI_BattleUIController.<>f__mg$cache8 == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleUIController.<>f__mg$cache8 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleUIController.ShowTeammateAction);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_BattleUIController.<>f__mg$cache8);
		if (Lua_BlackJack_ProjectL_UI_BattleUIController.<>f__mg$cache9 == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleUIController.<>f__mg$cache9 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleUIController.ShowEnemyAction);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_BattleUIController.<>f__mg$cache9);
		if (Lua_BlackJack_ProjectL_UI_BattleUIController.<>f__mg$cacheA == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleUIController.<>f__mg$cacheA = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleUIController.HidePauseButton);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_BattleUIController.<>f__mg$cacheA);
		if (Lua_BlackJack_ProjectL_UI_BattleUIController.<>f__mg$cacheB == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleUIController.<>f__mg$cacheB = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleUIController.ShowChatButton);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_BattleUIController.<>f__mg$cacheB);
		if (Lua_BlackJack_ProjectL_UI_BattleUIController.<>f__mg$cacheC == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleUIController.<>f__mg$cacheC = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleUIController.SetAutoBattle);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_BattleUIController.<>f__mg$cacheC);
		if (Lua_BlackJack_ProjectL_UI_BattleUIController.<>f__mg$cacheD == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleUIController.<>f__mg$cacheD = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleUIController.HideAutoBattleButton);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_BattleUIController.<>f__mg$cacheD);
		if (Lua_BlackJack_ProjectL_UI_BattleUIController.<>f__mg$cacheE == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleUIController.<>f__mg$cacheE = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleUIController.SetArenaAutoBattle);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_BattleUIController.<>f__mg$cacheE);
		if (Lua_BlackJack_ProjectL_UI_BattleUIController.<>f__mg$cacheF == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleUIController.<>f__mg$cacheF = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleUIController.SetFastBattle);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_BattleUIController.<>f__mg$cacheF);
		if (Lua_BlackJack_ProjectL_UI_BattleUIController.<>f__mg$cache10 == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleUIController.<>f__mg$cache10 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleUIController.SetSkipCombatMode);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_BattleUIController.<>f__mg$cache10);
		if (Lua_BlackJack_ProjectL_UI_BattleUIController.<>f__mg$cache11 == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleUIController.<>f__mg$cache11 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleUIController.SetActorSimpleInfo);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_BattleUIController.<>f__mg$cache11);
		if (Lua_BlackJack_ProjectL_UI_BattleUIController.<>f__mg$cache12 == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleUIController.<>f__mg$cache12 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleUIController.ShowActorSimpleInfo);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_BattleUIController.<>f__mg$cache12);
		if (Lua_BlackJack_ProjectL_UI_BattleUIController.<>f__mg$cache13 == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleUIController.<>f__mg$cache13 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleUIController.IsShowActorSimpleInfo);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_BattleUIController.<>f__mg$cache13);
		if (Lua_BlackJack_ProjectL_UI_BattleUIController.<>f__mg$cache14 == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleUIController.<>f__mg$cache14 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleUIController.SetShowDanger);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_BattleUIController.<>f__mg$cache14);
		if (Lua_BlackJack_ProjectL_UI_BattleUIController.<>f__mg$cache15 == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleUIController.<>f__mg$cache15 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleUIController.ShowEndAction);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_BattleUIController.<>f__mg$cache15);
		if (Lua_BlackJack_ProjectL_UI_BattleUIController.<>f__mg$cache16 == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleUIController.<>f__mg$cache16 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleUIController.ShowEndAllAction);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_BattleUIController.<>f__mg$cache16);
		if (Lua_BlackJack_ProjectL_UI_BattleUIController.<>f__mg$cache17 == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleUIController.<>f__mg$cache17 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleUIController.SetActionOrderType);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_BattleUIController.<>f__mg$cache17);
		if (Lua_BlackJack_ProjectL_UI_BattleUIController.<>f__mg$cache18 == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleUIController.<>f__mg$cache18 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleUIController.RefreshChatRedState);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_BattleUIController.<>f__mg$cache18);
		if (Lua_BlackJack_ProjectL_UI_BattleUIController.<>f__mg$cache19 == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleUIController.<>f__mg$cache19 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleUIController.ShowTopUI);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_BattleUIController.<>f__mg$cache19);
		if (Lua_BlackJack_ProjectL_UI_BattleUIController.<>f__mg$cache1A == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleUIController.<>f__mg$cache1A = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleUIController.IsShowTopUI);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_BattleUIController.<>f__mg$cache1A);
		if (Lua_BlackJack_ProjectL_UI_BattleUIController.<>f__mg$cache1B == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleUIController.<>f__mg$cache1B = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleUIController.ShowBottomUI);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_BattleUIController.<>f__mg$cache1B);
		if (Lua_BlackJack_ProjectL_UI_BattleUIController.<>f__mg$cache1C == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleUIController.<>f__mg$cache1C = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleUIController.IsShowBottomUI);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_BattleUIController.<>f__mg$cache1C);
		if (Lua_BlackJack_ProjectL_UI_BattleUIController.<>f__mg$cache1D == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleUIController.<>f__mg$cache1D = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleUIController.ShowSkills);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_BattleUIController.<>f__mg$cache1D);
		if (Lua_BlackJack_ProjectL_UI_BattleUIController.<>f__mg$cache1E == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleUIController.<>f__mg$cache1E = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleUIController.GetSkillButtonRectTransform);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_BattleUIController.<>f__mg$cache1E);
		if (Lua_BlackJack_ProjectL_UI_BattleUIController.<>f__mg$cache1F == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleUIController.<>f__mg$cache1F = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleUIController.HideSkills);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_BattleUIController.<>f__mg$cache1F);
		if (Lua_BlackJack_ProjectL_UI_BattleUIController.<>f__mg$cache20 == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleUIController.<>f__mg$cache20 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleUIController.ShowUseOrCancelSkill);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_BattleUIController.<>f__mg$cache20);
		if (Lua_BlackJack_ProjectL_UI_BattleUIController.<>f__mg$cache21 == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleUIController.<>f__mg$cache21 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleUIController.ShowUseSkill);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_BattleUIController.<>f__mg$cache21);
		if (Lua_BlackJack_ProjectL_UI_BattleUIController.<>f__mg$cache22 == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleUIController.<>f__mg$cache22 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleUIController.SetCurrentSkill);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_BattleUIController.<>f__mg$cache22);
		if (Lua_BlackJack_ProjectL_UI_BattleUIController.<>f__mg$cache23 == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleUIController.<>f__mg$cache23 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleUIController.ShowSkillHint);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_BattleUIController.<>f__mg$cache23);
		if (Lua_BlackJack_ProjectL_UI_BattleUIController.<>f__mg$cache24 == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleUIController.<>f__mg$cache24 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleUIController.HideSkillHint);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_BattleUIController.<>f__mg$cache24);
		if (Lua_BlackJack_ProjectL_UI_BattleUIController.<>f__mg$cache25 == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleUIController.<>f__mg$cache25 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleUIController.HighlightSkillHint);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_BattleUIController.<>f__mg$cache25);
		if (Lua_BlackJack_ProjectL_UI_BattleUIController.<>f__mg$cache26 == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleUIController.<>f__mg$cache26 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleUIController.ShowTerrainInfo);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_BattleUIController.<>f__mg$cache26);
		if (Lua_BlackJack_ProjectL_UI_BattleUIController.<>f__mg$cache27 == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleUIController.<>f__mg$cache27 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleUIController.HideTerrainInfo);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_BattleUIController.<>f__mg$cache27);
		if (Lua_BlackJack_ProjectL_UI_BattleUIController.<>f__mg$cache28 == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleUIController.<>f__mg$cache28 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleUIController.ShowArmyRelationButton);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_BattleUIController.<>f__mg$cache28);
		if (Lua_BlackJack_ProjectL_UI_BattleUIController.<>f__mg$cache29 == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleUIController.<>f__mg$cache29 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleUIController.ShowArmyRelationDesc);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_BattleUIController.<>f__mg$cache29);
		if (Lua_BlackJack_ProjectL_UI_BattleUIController.<>f__mg$cache2A == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleUIController.<>f__mg$cache2A = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleUIController.HideArmyRelationDesc);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_BattleUIController.<>f__mg$cache2A);
		if (Lua_BlackJack_ProjectL_UI_BattleUIController.<>f__mg$cache2B == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleUIController.<>f__mg$cache2B = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleUIController.IsArmyRelationDescVisible);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_BattleUIController.<>f__mg$cache2B);
		if (Lua_BlackJack_ProjectL_UI_BattleUIController.<>f__mg$cache2C == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleUIController.<>f__mg$cache2C = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleUIController.ShowCutsceneSkill);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_BattleUIController.<>f__mg$cache2C);
		if (Lua_BlackJack_ProjectL_UI_BattleUIController.<>f__mg$cache2D == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleUIController.<>f__mg$cache2D = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleUIController.ShowDanmakuToggle);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_BattleUIController.<>f__mg$cache2D);
		if (Lua_BlackJack_ProjectL_UI_BattleUIController.<>f__mg$cache2E == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleUIController.<>f__mg$cache2E = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleUIController.ShowCurTurnDanmaku);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_BattleUIController.<>f__mg$cache2E);
		if (Lua_BlackJack_ProjectL_UI_BattleUIController.<>f__mg$cache2F == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleUIController.<>f__mg$cache2F = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleUIController.SetRegretCount);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_BattleUIController.<>f__mg$cache2F);
		if (Lua_BlackJack_ProjectL_UI_BattleUIController.<>f__mg$cache30 == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleUIController.<>f__mg$cache30 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleUIController.SetRegretTurnStatus);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_BattleUIController.<>f__mg$cache30);
		if (Lua_BlackJack_ProjectL_UI_BattleUIController.<>f__mg$cache31 == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleUIController.<>f__mg$cache31 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleUIController.SetRegretButtonStatus);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_BattleUIController.<>f__mg$cache31);
		if (Lua_BlackJack_ProjectL_UI_BattleUIController.<>f__mg$cache32 == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleUIController.<>f__mg$cache32 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleUIController.ShowRegretButton);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_BattleUIController.<>f__mg$cache32);
		if (Lua_BlackJack_ProjectL_UI_BattleUIController.<>f__mg$cache33 == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleUIController.<>f__mg$cache33 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleUIController.ShowRegretPanel);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_BattleUIController.<>f__mg$cache33);
		if (Lua_BlackJack_ProjectL_UI_BattleUIController.<>f__mg$cache34 == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleUIController.<>f__mg$cache34 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleUIController.ShowRegretConfirmFx);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_BattleUIController.<>f__mg$cache34);
		if (Lua_BlackJack_ProjectL_UI_BattleUIController.<>f__mg$cache35 == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleUIController.<>f__mg$cache35 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleUIController.OnScenePointerDown);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_BattleUIController.<>f__mg$cache35);
		if (Lua_BlackJack_ProjectL_UI_BattleUIController.<>f__mg$cache36 == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleUIController.<>f__mg$cache36 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleUIController.OnScenePointerUp);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_BattleUIController.<>f__mg$cache36);
		if (Lua_BlackJack_ProjectL_UI_BattleUIController.<>f__mg$cache37 == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleUIController.<>f__mg$cache37 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleUIController.OnScenePointerClick);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_BattleUIController.<>f__mg$cache37);
		if (Lua_BlackJack_ProjectL_UI_BattleUIController.<>f__mg$cache38 == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleUIController.<>f__mg$cache38 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleUIController.OnSceneBeginDrag);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_BattleUIController.<>f__mg$cache38);
		if (Lua_BlackJack_ProjectL_UI_BattleUIController.<>f__mg$cache39 == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleUIController.<>f__mg$cache39 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleUIController.OnSceneEndDrag);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_BattleUIController.<>f__mg$cache39);
		if (Lua_BlackJack_ProjectL_UI_BattleUIController.<>f__mg$cache3A == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleUIController.<>f__mg$cache3A = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleUIController.OnSceneDrag);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_BattleUIController.<>f__mg$cache3A);
		if (Lua_BlackJack_ProjectL_UI_BattleUIController.<>f__mg$cache3B == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleUIController.<>f__mg$cache3B = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleUIController.OnScene3DTouch);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_BattleUIController.<>f__mg$cache3B);
		if (Lua_BlackJack_ProjectL_UI_BattleUIController.<>f__mg$cache3C == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleUIController.<>f__mg$cache3C = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleUIController.OnBindFiledsCompleted);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_BattleUIController.<>f__mg$cache3C);
		if (Lua_BlackJack_ProjectL_UI_BattleUIController.<>f__mg$cache3D == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleUIController.<>f__mg$cache3D = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleUIController.Update);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_BattleUIController.<>f__mg$cache3D);
		if (Lua_BlackJack_ProjectL_UI_BattleUIController.<>f__mg$cache3E == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleUIController.<>f__mg$cache3E = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleUIController.WinOrLoseTweenFinished);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_BattleUIController.<>f__mg$cache3E);
		if (Lua_BlackJack_ProjectL_UI_BattleUIController.<>f__mg$cache3F == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleUIController.<>f__mg$cache3F = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleUIController.HideArmyRelation);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_BattleUIController.<>f__mg$cache3F);
		if (Lua_BlackJack_ProjectL_UI_BattleUIController.<>f__mg$cache40 == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleUIController.<>f__mg$cache40 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleUIController.HideCutsceneSkill);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_BattleUIController.<>f__mg$cache40);
		if (Lua_BlackJack_ProjectL_UI_BattleUIController.<>f__mg$cache41 == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleUIController.<>f__mg$cache41 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleUIController.OnPauseButtonClick);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_BattleUIController.<>f__mg$cache41);
		if (Lua_BlackJack_ProjectL_UI_BattleUIController.<>f__mg$cache42 == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleUIController.<>f__mg$cache42 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleUIController.OnArmyRelationButtonClick);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_BattleUIController.<>f__mg$cache42);
		if (Lua_BlackJack_ProjectL_UI_BattleUIController.<>f__mg$cache43 == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleUIController.<>f__mg$cache43 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleUIController.OnAutoButtonClick);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_BattleUIController.<>f__mg$cache43);
		if (Lua_BlackJack_ProjectL_UI_BattleUIController.<>f__mg$cache44 == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleUIController.<>f__mg$cache44 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleUIController.OnAutoOffButtonClick);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_BattleUIController.<>f__mg$cache44);
		if (Lua_BlackJack_ProjectL_UI_BattleUIController.<>f__mg$cache45 == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleUIController.<>f__mg$cache45 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleUIController.OnArenaAutoButtonClick);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_BattleUIController.<>f__mg$cache45);
		if (Lua_BlackJack_ProjectL_UI_BattleUIController.<>f__mg$cache46 == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleUIController.<>f__mg$cache46 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleUIController.OnFastButtonClick);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_BattleUIController.<>f__mg$cache46);
		if (Lua_BlackJack_ProjectL_UI_BattleUIController.<>f__mg$cache47 == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleUIController.<>f__mg$cache47 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleUIController.OnSkipCombatButtonClick);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_BattleUIController.<>f__mg$cache47);
		if (Lua_BlackJack_ProjectL_UI_BattleUIController.<>f__mg$cache48 == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleUIController.<>f__mg$cache48 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleUIController.OnDangerOnButtonClick);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_BattleUIController.<>f__mg$cache48);
		if (Lua_BlackJack_ProjectL_UI_BattleUIController.<>f__mg$cache49 == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleUIController.<>f__mg$cache49 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleUIController.OnDangerOffButtonClick);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_BattleUIController.<>f__mg$cache49);
		if (Lua_BlackJack_ProjectL_UI_BattleUIController.<>f__mg$cache4A == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleUIController.<>f__mg$cache4A = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleUIController.OnEndActionButtonClick);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_BattleUIController.<>f__mg$cache4A);
		if (Lua_BlackJack_ProjectL_UI_BattleUIController.<>f__mg$cache4B == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleUIController.<>f__mg$cache4B = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleUIController.OnEndAllActionButtonClick);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_BattleUIController.<>f__mg$cache4B);
		if (Lua_BlackJack_ProjectL_UI_BattleUIController.<>f__mg$cache4C == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleUIController.<>f__mg$cache4C = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleUIController.OnActorSimpleInfoButtonClick);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_BattleUIController.<>f__mg$cache4C);
		if (Lua_BlackJack_ProjectL_UI_BattleUIController.<>f__mg$cache4D == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleUIController.<>f__mg$cache4D = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleUIController.OnUseSkillButtonClick);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_BattleUIController.<>f__mg$cache4D);
		if (Lua_BlackJack_ProjectL_UI_BattleUIController.<>f__mg$cache4E == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleUIController.<>f__mg$cache4E = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleUIController.OnCancelSkillButtonClick);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_BattleUIController.<>f__mg$cache4E);
		if (Lua_BlackJack_ProjectL_UI_BattleUIController.<>f__mg$cache4F == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleUIController.<>f__mg$cache4F = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleUIController.BattleSkillButton_OnClick);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_BattleUIController.<>f__mg$cache4F);
		if (Lua_BlackJack_ProjectL_UI_BattleUIController.<>f__mg$cache50 == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleUIController.<>f__mg$cache50 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleUIController.OnChatButtonClick);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_BattleUIController.<>f__mg$cache50);
		if (Lua_BlackJack_ProjectL_UI_BattleUIController.<>f__mg$cache51 == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleUIController.<>f__mg$cache51 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleUIController.OnHelpButtonClick);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_BattleUIController.<>f__mg$cache51);
		if (Lua_BlackJack_ProjectL_UI_BattleUIController.<>f__mg$cache52 == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleUIController.<>f__mg$cache52 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleUIController.OnTerrainInfoButtonClick);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_BattleUIController.<>f__mg$cache52);
		if (Lua_BlackJack_ProjectL_UI_BattleUIController.<>f__mg$cache53 == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleUIController.<>f__mg$cache53 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleUIController.DeveloperModeClick);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_BattleUIController.<>f__mg$cache53);
		if (Lua_BlackJack_ProjectL_UI_BattleUIController.<>f__mg$cache54 == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleUIController.<>f__mg$cache54 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleUIController.OnDanmakuToggleValueChanged);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_BattleUIController.<>f__mg$cache54);
		if (Lua_BlackJack_ProjectL_UI_BattleUIController.<>f__mg$cache55 == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleUIController.<>f__mg$cache55 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleUIController.OnDanmakuInputWordButtonClick);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_BattleUIController.<>f__mg$cache55);
		if (Lua_BlackJack_ProjectL_UI_BattleUIController.<>f__mg$cache56 == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleUIController.<>f__mg$cache56 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleUIController.OnDanmakuInputBackButtonClick);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_BattleUIController.<>f__mg$cache56);
		if (Lua_BlackJack_ProjectL_UI_BattleUIController.<>f__mg$cache57 == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleUIController.<>f__mg$cache57 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleUIController.OnDanmakuSendButtonClick);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_BattleUIController.<>f__mg$cache57);
		if (Lua_BlackJack_ProjectL_UI_BattleUIController.<>f__mg$cache58 == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleUIController.<>f__mg$cache58 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleUIController.OnRegretButtonClick);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_BattleUIController.<>f__mg$cache58);
		if (Lua_BlackJack_ProjectL_UI_BattleUIController.<>f__mg$cache59 == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleUIController.<>f__mg$cache59 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleUIController.OnRegretConfirmButtonClick);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_BattleUIController.<>f__mg$cache59);
		if (Lua_BlackJack_ProjectL_UI_BattleUIController.<>f__mg$cache5A == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleUIController.<>f__mg$cache5A = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleUIController.OnRegretCancelButtonClick);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_BattleUIController.<>f__mg$cache5A);
		if (Lua_BlackJack_ProjectL_UI_BattleUIController.<>f__mg$cache5B == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleUIController.<>f__mg$cache5B = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleUIController.OnRegretBackwardButtonClick);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_BattleUIController.<>f__mg$cache5B);
		if (Lua_BlackJack_ProjectL_UI_BattleUIController.<>f__mg$cache5C == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleUIController.<>f__mg$cache5C = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleUIController.OnRegretForwardButtonClick);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_BattleUIController.<>f__mg$cache5C);
		if (Lua_BlackJack_ProjectL_UI_BattleUIController.<>f__mg$cache5D == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleUIController.<>f__mg$cache5D = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleUIController.__callBase_Initlize);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_BattleUIController.<>f__mg$cache5D);
		if (Lua_BlackJack_ProjectL_UI_BattleUIController.<>f__mg$cache5E == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleUIController.<>f__mg$cache5E = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleUIController.__callBase_BindFields);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_BattleUIController.<>f__mg$cache5E);
		if (Lua_BlackJack_ProjectL_UI_BattleUIController.<>f__mg$cache5F == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleUIController.<>f__mg$cache5F = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleUIController.__callBase_OnBindFiledsCompleted);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_BattleUIController.<>f__mg$cache5F);
		if (Lua_BlackJack_ProjectL_UI_BattleUIController.<>f__mg$cache60 == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleUIController.<>f__mg$cache60 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleUIController.__callBase_BindFieldImpl);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_BattleUIController.<>f__mg$cache60);
		if (Lua_BlackJack_ProjectL_UI_BattleUIController.<>f__mg$cache61 == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleUIController.<>f__mg$cache61 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleUIController.__callBase_Clear);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_BattleUIController.<>f__mg$cache61);
		if (Lua_BlackJack_ProjectL_UI_BattleUIController.<>f__mg$cache62 == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleUIController.<>f__mg$cache62 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleUIController.__callBase_OnButtonClick);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_BattleUIController.<>f__mg$cache62);
		if (Lua_BlackJack_ProjectL_UI_BattleUIController.<>f__mg$cache63 == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleUIController.<>f__mg$cache63 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleUIController.__callBase_SetButtonClickListener);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_BattleUIController.<>f__mg$cache63);
		if (Lua_BlackJack_ProjectL_UI_BattleUIController.<>f__mg$cache64 == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleUIController.<>f__mg$cache64 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleUIController.__callBase_SetButtonDoubleClickListener);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_BattleUIController.<>f__mg$cache64);
		if (Lua_BlackJack_ProjectL_UI_BattleUIController.<>f__mg$cache65 == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleUIController.<>f__mg$cache65 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleUIController.__callBase_SetButtonLongPressStartListener);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_BattleUIController.<>f__mg$cache65);
		if (Lua_BlackJack_ProjectL_UI_BattleUIController.<>f__mg$cache66 == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleUIController.<>f__mg$cache66 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleUIController.__callBase_SetButtonLongPressingListener);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_BattleUIController.<>f__mg$cache66);
		if (Lua_BlackJack_ProjectL_UI_BattleUIController.<>f__mg$cache67 == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleUIController.<>f__mg$cache67 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleUIController.__callBase_SetButtonLongPressEndListener);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_BattleUIController.<>f__mg$cache67);
		if (Lua_BlackJack_ProjectL_UI_BattleUIController.<>f__mg$cache68 == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleUIController.<>f__mg$cache68 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleUIController.__callBase_SetToggleValueChangedListener);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_BattleUIController.<>f__mg$cache68);
		if (Lua_BlackJack_ProjectL_UI_BattleUIController.<>f__mg$cache69 == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleUIController.<>f__mg$cache69 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleUIController.__callBase_ToString);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_BattleUIController.<>f__mg$cache69);
		if (Lua_BlackJack_ProjectL_UI_BattleUIController.<>f__mg$cache6A == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleUIController.<>f__mg$cache6A = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleUIController.__callDele_EventOnPauseBattle);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_BattleUIController.<>f__mg$cache6A);
		if (Lua_BlackJack_ProjectL_UI_BattleUIController.<>f__mg$cache6B == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleUIController.<>f__mg$cache6B = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleUIController.__clearDele_EventOnPauseBattle);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_BattleUIController.<>f__mg$cache6B);
		if (Lua_BlackJack_ProjectL_UI_BattleUIController.<>f__mg$cache6C == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleUIController.<>f__mg$cache6C = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleUIController.__callDele_EventOnShowArmyRelation);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_BattleUIController.<>f__mg$cache6C);
		if (Lua_BlackJack_ProjectL_UI_BattleUIController.<>f__mg$cache6D == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleUIController.<>f__mg$cache6D = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleUIController.__clearDele_EventOnShowArmyRelation);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_BattleUIController.<>f__mg$cache6D);
		if (Lua_BlackJack_ProjectL_UI_BattleUIController.<>f__mg$cache6E == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleUIController.<>f__mg$cache6E = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleUIController.__callDele_EventOnAutoBattle);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_BattleUIController.<>f__mg$cache6E);
		if (Lua_BlackJack_ProjectL_UI_BattleUIController.<>f__mg$cache6F == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleUIController.<>f__mg$cache6F = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleUIController.__clearDele_EventOnAutoBattle);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_BattleUIController.<>f__mg$cache6F);
		if (Lua_BlackJack_ProjectL_UI_BattleUIController.<>f__mg$cache70 == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleUIController.<>f__mg$cache70 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleUIController.__callDele_EventOnFastBattle);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_BattleUIController.<>f__mg$cache70);
		if (Lua_BlackJack_ProjectL_UI_BattleUIController.<>f__mg$cache71 == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleUIController.<>f__mg$cache71 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleUIController.__clearDele_EventOnFastBattle);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_BattleUIController.<>f__mg$cache71);
		if (Lua_BlackJack_ProjectL_UI_BattleUIController.<>f__mg$cache72 == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleUIController.<>f__mg$cache72 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleUIController.__callDele_EventOnSkipCombat);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_BattleUIController.<>f__mg$cache72);
		if (Lua_BlackJack_ProjectL_UI_BattleUIController.<>f__mg$cache73 == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleUIController.<>f__mg$cache73 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleUIController.__clearDele_EventOnSkipCombat);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_BattleUIController.<>f__mg$cache73);
		if (Lua_BlackJack_ProjectL_UI_BattleUIController.<>f__mg$cache74 == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleUIController.<>f__mg$cache74 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleUIController.__callDele_EventOnShowDanger);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_BattleUIController.<>f__mg$cache74);
		if (Lua_BlackJack_ProjectL_UI_BattleUIController.<>f__mg$cache75 == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleUIController.<>f__mg$cache75 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleUIController.__clearDele_EventOnShowDanger);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_BattleUIController.<>f__mg$cache75);
		if (Lua_BlackJack_ProjectL_UI_BattleUIController.<>f__mg$cache76 == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleUIController.<>f__mg$cache76 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleUIController.__callDele_EventOnEndAction);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_BattleUIController.<>f__mg$cache76);
		if (Lua_BlackJack_ProjectL_UI_BattleUIController.<>f__mg$cache77 == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleUIController.<>f__mg$cache77 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleUIController.__clearDele_EventOnEndAction);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_BattleUIController.<>f__mg$cache77);
		if (Lua_BlackJack_ProjectL_UI_BattleUIController.<>f__mg$cache78 == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleUIController.<>f__mg$cache78 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleUIController.__callDele_EventOnShowActorInfo);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_BattleUIController.<>f__mg$cache78);
		if (Lua_BlackJack_ProjectL_UI_BattleUIController.<>f__mg$cache79 == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleUIController.<>f__mg$cache79 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleUIController.__clearDele_EventOnShowActorInfo);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_BattleUIController.<>f__mg$cache79);
		if (Lua_BlackJack_ProjectL_UI_BattleUIController.<>f__mg$cache7A == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleUIController.<>f__mg$cache7A = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleUIController.__callDele_EventOnEndAllAction);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_BattleUIController.<>f__mg$cache7A);
		if (Lua_BlackJack_ProjectL_UI_BattleUIController.<>f__mg$cache7B == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleUIController.<>f__mg$cache7B = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleUIController.__clearDele_EventOnEndAllAction);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_BattleUIController.<>f__mg$cache7B);
		if (Lua_BlackJack_ProjectL_UI_BattleUIController.<>f__mg$cache7C == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleUIController.<>f__mg$cache7C = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleUIController.__callDele_EventOnUseSkill);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_BattleUIController.<>f__mg$cache7C);
		if (Lua_BlackJack_ProjectL_UI_BattleUIController.<>f__mg$cache7D == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleUIController.<>f__mg$cache7D = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleUIController.__clearDele_EventOnUseSkill);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_BattleUIController.<>f__mg$cache7D);
		if (Lua_BlackJack_ProjectL_UI_BattleUIController.<>f__mg$cache7E == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleUIController.<>f__mg$cache7E = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleUIController.__callDele_EventOnCancelSkill);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_BattleUIController.<>f__mg$cache7E);
		if (Lua_BlackJack_ProjectL_UI_BattleUIController.<>f__mg$cache7F == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleUIController.<>f__mg$cache7F = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleUIController.__clearDele_EventOnCancelSkill);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_BattleUIController.<>f__mg$cache7F);
		if (Lua_BlackJack_ProjectL_UI_BattleUIController.<>f__mg$cache80 == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleUIController.<>f__mg$cache80 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleUIController.__callDele_EventOnWinOrLoseEnd);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_BattleUIController.<>f__mg$cache80);
		if (Lua_BlackJack_ProjectL_UI_BattleUIController.<>f__mg$cache81 == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleUIController.<>f__mg$cache81 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleUIController.__clearDele_EventOnWinOrLoseEnd);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_BattleUIController.<>f__mg$cache81);
		if (Lua_BlackJack_ProjectL_UI_BattleUIController.<>f__mg$cache82 == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleUIController.<>f__mg$cache82 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleUIController.__callDele_EventOnShowChat);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_BattleUIController.<>f__mg$cache82);
		if (Lua_BlackJack_ProjectL_UI_BattleUIController.<>f__mg$cache83 == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleUIController.<>f__mg$cache83 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleUIController.__clearDele_EventOnShowChat);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_BattleUIController.<>f__mg$cache83);
		if (Lua_BlackJack_ProjectL_UI_BattleUIController.<>f__mg$cache84 == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleUIController.<>f__mg$cache84 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleUIController.__callDele_EventOnShowHelp);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_BattleUIController.<>f__mg$cache84);
		if (Lua_BlackJack_ProjectL_UI_BattleUIController.<>f__mg$cache85 == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleUIController.<>f__mg$cache85 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleUIController.__clearDele_EventOnShowHelp);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_BattleUIController.<>f__mg$cache85);
		if (Lua_BlackJack_ProjectL_UI_BattleUIController.<>f__mg$cache86 == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleUIController.<>f__mg$cache86 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleUIController.__callDele_EventOnSelectSkill);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_BattleUIController.<>f__mg$cache86);
		if (Lua_BlackJack_ProjectL_UI_BattleUIController.<>f__mg$cache87 == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleUIController.<>f__mg$cache87 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleUIController.__clearDele_EventOnSelectSkill);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_BattleUIController.<>f__mg$cache87);
		if (Lua_BlackJack_ProjectL_UI_BattleUIController.<>f__mg$cache88 == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleUIController.<>f__mg$cache88 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleUIController.__callDele_EventOnPointerDown);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_BattleUIController.<>f__mg$cache88);
		if (Lua_BlackJack_ProjectL_UI_BattleUIController.<>f__mg$cache89 == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleUIController.<>f__mg$cache89 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleUIController.__clearDele_EventOnPointerDown);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_BattleUIController.<>f__mg$cache89);
		if (Lua_BlackJack_ProjectL_UI_BattleUIController.<>f__mg$cache8A == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleUIController.<>f__mg$cache8A = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleUIController.__callDele_EventOnPointerUp);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_BattleUIController.<>f__mg$cache8A);
		if (Lua_BlackJack_ProjectL_UI_BattleUIController.<>f__mg$cache8B == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleUIController.<>f__mg$cache8B = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleUIController.__clearDele_EventOnPointerUp);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_BattleUIController.<>f__mg$cache8B);
		if (Lua_BlackJack_ProjectL_UI_BattleUIController.<>f__mg$cache8C == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleUIController.<>f__mg$cache8C = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleUIController.__callDele_EventOnPointerClick);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_BattleUIController.<>f__mg$cache8C);
		if (Lua_BlackJack_ProjectL_UI_BattleUIController.<>f__mg$cache8D == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleUIController.<>f__mg$cache8D = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleUIController.__clearDele_EventOnPointerClick);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_BattleUIController.<>f__mg$cache8D);
		if (Lua_BlackJack_ProjectL_UI_BattleUIController.<>f__mg$cache8E == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleUIController.<>f__mg$cache8E = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleUIController.__callDele_EventOn3DTouch);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_BattleUIController.<>f__mg$cache8E);
		if (Lua_BlackJack_ProjectL_UI_BattleUIController.<>f__mg$cache8F == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleUIController.<>f__mg$cache8F = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleUIController.__clearDele_EventOn3DTouch);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_BattleUIController.<>f__mg$cache8F);
		if (Lua_BlackJack_ProjectL_UI_BattleUIController.<>f__mg$cache90 == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleUIController.<>f__mg$cache90 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleUIController.__callDele_EventOnShowCurTurnDanmaku);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_BattleUIController.<>f__mg$cache90);
		if (Lua_BlackJack_ProjectL_UI_BattleUIController.<>f__mg$cache91 == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleUIController.<>f__mg$cache91 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleUIController.__clearDele_EventOnShowCurTurnDanmaku);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_BattleUIController.<>f__mg$cache91);
		if (Lua_BlackJack_ProjectL_UI_BattleUIController.<>f__mg$cache92 == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleUIController.<>f__mg$cache92 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleUIController.__callDele_EventOnCloseCurTurnDanmaku);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_BattleUIController.<>f__mg$cache92);
		if (Lua_BlackJack_ProjectL_UI_BattleUIController.<>f__mg$cache93 == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleUIController.<>f__mg$cache93 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleUIController.__clearDele_EventOnCloseCurTurnDanmaku);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_BattleUIController.<>f__mg$cache93);
		if (Lua_BlackJack_ProjectL_UI_BattleUIController.<>f__mg$cache94 == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleUIController.<>f__mg$cache94 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleUIController.__callDele_EventOnShowOneDanmaku);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_BattleUIController.<>f__mg$cache94);
		if (Lua_BlackJack_ProjectL_UI_BattleUIController.<>f__mg$cache95 == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleUIController.<>f__mg$cache95 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleUIController.__clearDele_EventOnShowOneDanmaku);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_BattleUIController.<>f__mg$cache95);
		if (Lua_BlackJack_ProjectL_UI_BattleUIController.<>f__mg$cache96 == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleUIController.<>f__mg$cache96 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleUIController.__callDele_EventOnRegretActive);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_BattleUIController.<>f__mg$cache96);
		if (Lua_BlackJack_ProjectL_UI_BattleUIController.<>f__mg$cache97 == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleUIController.<>f__mg$cache97 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleUIController.__clearDele_EventOnRegretActive);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_BattleUIController.<>f__mg$cache97);
		if (Lua_BlackJack_ProjectL_UI_BattleUIController.<>f__mg$cache98 == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleUIController.<>f__mg$cache98 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleUIController.__callDele_EventOnRegretConfirm);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_BattleUIController.<>f__mg$cache98);
		if (Lua_BlackJack_ProjectL_UI_BattleUIController.<>f__mg$cache99 == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleUIController.<>f__mg$cache99 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleUIController.__clearDele_EventOnRegretConfirm);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_BattleUIController.<>f__mg$cache99);
		if (Lua_BlackJack_ProjectL_UI_BattleUIController.<>f__mg$cache9A == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleUIController.<>f__mg$cache9A = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleUIController.__callDele_EventOnRegretCancel);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_BattleUIController.<>f__mg$cache9A);
		if (Lua_BlackJack_ProjectL_UI_BattleUIController.<>f__mg$cache9B == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleUIController.<>f__mg$cache9B = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleUIController.__clearDele_EventOnRegretCancel);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_BattleUIController.<>f__mg$cache9B);
		if (Lua_BlackJack_ProjectL_UI_BattleUIController.<>f__mg$cache9C == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleUIController.<>f__mg$cache9C = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleUIController.__callDele_EventOnRegretBackward);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_BattleUIController.<>f__mg$cache9C);
		if (Lua_BlackJack_ProjectL_UI_BattleUIController.<>f__mg$cache9D == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleUIController.<>f__mg$cache9D = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleUIController.__clearDele_EventOnRegretBackward);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_BattleUIController.<>f__mg$cache9D);
		if (Lua_BlackJack_ProjectL_UI_BattleUIController.<>f__mg$cache9E == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleUIController.<>f__mg$cache9E = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleUIController.__callDele_EventOnRegretForward);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_BattleUIController.<>f__mg$cache9E);
		if (Lua_BlackJack_ProjectL_UI_BattleUIController.<>f__mg$cache9F == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleUIController.<>f__mg$cache9F = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleUIController.__clearDele_EventOnRegretForward);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_BattleUIController.<>f__mg$cache9F);
		if (Lua_BlackJack_ProjectL_UI_BattleUIController.<>f__mg$cacheA0 == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleUIController.<>f__mg$cacheA0 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleUIController.ComputeActionIconPositionScale_s);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_BattleUIController.<>f__mg$cacheA0);
		string name = "EventOnPauseBattle";
		LuaCSFunction get = null;
		if (Lua_BlackJack_ProjectL_UI_BattleUIController.<>f__mg$cacheA1 == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleUIController.<>f__mg$cacheA1 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleUIController.set_EventOnPauseBattle);
		}
		LuaObject.addMember(l, name, get, Lua_BlackJack_ProjectL_UI_BattleUIController.<>f__mg$cacheA1, true);
		string name2 = "EventOnShowArmyRelation";
		LuaCSFunction get2 = null;
		if (Lua_BlackJack_ProjectL_UI_BattleUIController.<>f__mg$cacheA2 == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleUIController.<>f__mg$cacheA2 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleUIController.set_EventOnShowArmyRelation);
		}
		LuaObject.addMember(l, name2, get2, Lua_BlackJack_ProjectL_UI_BattleUIController.<>f__mg$cacheA2, true);
		string name3 = "EventOnAutoBattle";
		LuaCSFunction get3 = null;
		if (Lua_BlackJack_ProjectL_UI_BattleUIController.<>f__mg$cacheA3 == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleUIController.<>f__mg$cacheA3 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleUIController.set_EventOnAutoBattle);
		}
		LuaObject.addMember(l, name3, get3, Lua_BlackJack_ProjectL_UI_BattleUIController.<>f__mg$cacheA3, true);
		string name4 = "EventOnFastBattle";
		LuaCSFunction get4 = null;
		if (Lua_BlackJack_ProjectL_UI_BattleUIController.<>f__mg$cacheA4 == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleUIController.<>f__mg$cacheA4 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleUIController.set_EventOnFastBattle);
		}
		LuaObject.addMember(l, name4, get4, Lua_BlackJack_ProjectL_UI_BattleUIController.<>f__mg$cacheA4, true);
		string name5 = "EventOnSkipCombat";
		LuaCSFunction get5 = null;
		if (Lua_BlackJack_ProjectL_UI_BattleUIController.<>f__mg$cacheA5 == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleUIController.<>f__mg$cacheA5 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleUIController.set_EventOnSkipCombat);
		}
		LuaObject.addMember(l, name5, get5, Lua_BlackJack_ProjectL_UI_BattleUIController.<>f__mg$cacheA5, true);
		string name6 = "EventOnShowDanger";
		LuaCSFunction get6 = null;
		if (Lua_BlackJack_ProjectL_UI_BattleUIController.<>f__mg$cacheA6 == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleUIController.<>f__mg$cacheA6 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleUIController.set_EventOnShowDanger);
		}
		LuaObject.addMember(l, name6, get6, Lua_BlackJack_ProjectL_UI_BattleUIController.<>f__mg$cacheA6, true);
		string name7 = "EventOnEndAction";
		LuaCSFunction get7 = null;
		if (Lua_BlackJack_ProjectL_UI_BattleUIController.<>f__mg$cacheA7 == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleUIController.<>f__mg$cacheA7 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleUIController.set_EventOnEndAction);
		}
		LuaObject.addMember(l, name7, get7, Lua_BlackJack_ProjectL_UI_BattleUIController.<>f__mg$cacheA7, true);
		string name8 = "EventOnShowActorInfo";
		LuaCSFunction get8 = null;
		if (Lua_BlackJack_ProjectL_UI_BattleUIController.<>f__mg$cacheA8 == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleUIController.<>f__mg$cacheA8 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleUIController.set_EventOnShowActorInfo);
		}
		LuaObject.addMember(l, name8, get8, Lua_BlackJack_ProjectL_UI_BattleUIController.<>f__mg$cacheA8, true);
		string name9 = "EventOnEndAllAction";
		LuaCSFunction get9 = null;
		if (Lua_BlackJack_ProjectL_UI_BattleUIController.<>f__mg$cacheA9 == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleUIController.<>f__mg$cacheA9 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleUIController.set_EventOnEndAllAction);
		}
		LuaObject.addMember(l, name9, get9, Lua_BlackJack_ProjectL_UI_BattleUIController.<>f__mg$cacheA9, true);
		string name10 = "EventOnUseSkill";
		LuaCSFunction get10 = null;
		if (Lua_BlackJack_ProjectL_UI_BattleUIController.<>f__mg$cacheAA == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleUIController.<>f__mg$cacheAA = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleUIController.set_EventOnUseSkill);
		}
		LuaObject.addMember(l, name10, get10, Lua_BlackJack_ProjectL_UI_BattleUIController.<>f__mg$cacheAA, true);
		string name11 = "EventOnCancelSkill";
		LuaCSFunction get11 = null;
		if (Lua_BlackJack_ProjectL_UI_BattleUIController.<>f__mg$cacheAB == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleUIController.<>f__mg$cacheAB = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleUIController.set_EventOnCancelSkill);
		}
		LuaObject.addMember(l, name11, get11, Lua_BlackJack_ProjectL_UI_BattleUIController.<>f__mg$cacheAB, true);
		string name12 = "EventOnWinOrLoseEnd";
		LuaCSFunction get12 = null;
		if (Lua_BlackJack_ProjectL_UI_BattleUIController.<>f__mg$cacheAC == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleUIController.<>f__mg$cacheAC = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleUIController.set_EventOnWinOrLoseEnd);
		}
		LuaObject.addMember(l, name12, get12, Lua_BlackJack_ProjectL_UI_BattleUIController.<>f__mg$cacheAC, true);
		string name13 = "EventOnShowChat";
		LuaCSFunction get13 = null;
		if (Lua_BlackJack_ProjectL_UI_BattleUIController.<>f__mg$cacheAD == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleUIController.<>f__mg$cacheAD = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleUIController.set_EventOnShowChat);
		}
		LuaObject.addMember(l, name13, get13, Lua_BlackJack_ProjectL_UI_BattleUIController.<>f__mg$cacheAD, true);
		string name14 = "EventOnShowHelp";
		LuaCSFunction get14 = null;
		if (Lua_BlackJack_ProjectL_UI_BattleUIController.<>f__mg$cacheAE == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleUIController.<>f__mg$cacheAE = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleUIController.set_EventOnShowHelp);
		}
		LuaObject.addMember(l, name14, get14, Lua_BlackJack_ProjectL_UI_BattleUIController.<>f__mg$cacheAE, true);
		string name15 = "EventOnSelectSkill";
		LuaCSFunction get15 = null;
		if (Lua_BlackJack_ProjectL_UI_BattleUIController.<>f__mg$cacheAF == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleUIController.<>f__mg$cacheAF = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleUIController.set_EventOnSelectSkill);
		}
		LuaObject.addMember(l, name15, get15, Lua_BlackJack_ProjectL_UI_BattleUIController.<>f__mg$cacheAF, true);
		string name16 = "EventOnPointerDown";
		LuaCSFunction get16 = null;
		if (Lua_BlackJack_ProjectL_UI_BattleUIController.<>f__mg$cacheB0 == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleUIController.<>f__mg$cacheB0 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleUIController.set_EventOnPointerDown);
		}
		LuaObject.addMember(l, name16, get16, Lua_BlackJack_ProjectL_UI_BattleUIController.<>f__mg$cacheB0, true);
		string name17 = "EventOnPointerUp";
		LuaCSFunction get17 = null;
		if (Lua_BlackJack_ProjectL_UI_BattleUIController.<>f__mg$cacheB1 == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleUIController.<>f__mg$cacheB1 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleUIController.set_EventOnPointerUp);
		}
		LuaObject.addMember(l, name17, get17, Lua_BlackJack_ProjectL_UI_BattleUIController.<>f__mg$cacheB1, true);
		string name18 = "EventOnPointerClick";
		LuaCSFunction get18 = null;
		if (Lua_BlackJack_ProjectL_UI_BattleUIController.<>f__mg$cacheB2 == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleUIController.<>f__mg$cacheB2 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleUIController.set_EventOnPointerClick);
		}
		LuaObject.addMember(l, name18, get18, Lua_BlackJack_ProjectL_UI_BattleUIController.<>f__mg$cacheB2, true);
		string name19 = "EventOn3DTouch";
		LuaCSFunction get19 = null;
		if (Lua_BlackJack_ProjectL_UI_BattleUIController.<>f__mg$cacheB3 == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleUIController.<>f__mg$cacheB3 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleUIController.set_EventOn3DTouch);
		}
		LuaObject.addMember(l, name19, get19, Lua_BlackJack_ProjectL_UI_BattleUIController.<>f__mg$cacheB3, true);
		string name20 = "EventOnShowCurTurnDanmaku";
		LuaCSFunction get20 = null;
		if (Lua_BlackJack_ProjectL_UI_BattleUIController.<>f__mg$cacheB4 == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleUIController.<>f__mg$cacheB4 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleUIController.set_EventOnShowCurTurnDanmaku);
		}
		LuaObject.addMember(l, name20, get20, Lua_BlackJack_ProjectL_UI_BattleUIController.<>f__mg$cacheB4, true);
		string name21 = "EventOnCloseCurTurnDanmaku";
		LuaCSFunction get21 = null;
		if (Lua_BlackJack_ProjectL_UI_BattleUIController.<>f__mg$cacheB5 == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleUIController.<>f__mg$cacheB5 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleUIController.set_EventOnCloseCurTurnDanmaku);
		}
		LuaObject.addMember(l, name21, get21, Lua_BlackJack_ProjectL_UI_BattleUIController.<>f__mg$cacheB5, true);
		string name22 = "EventOnShowOneDanmaku";
		LuaCSFunction get22 = null;
		if (Lua_BlackJack_ProjectL_UI_BattleUIController.<>f__mg$cacheB6 == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleUIController.<>f__mg$cacheB6 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleUIController.set_EventOnShowOneDanmaku);
		}
		LuaObject.addMember(l, name22, get22, Lua_BlackJack_ProjectL_UI_BattleUIController.<>f__mg$cacheB6, true);
		string name23 = "EventOnRegretActive";
		LuaCSFunction get23 = null;
		if (Lua_BlackJack_ProjectL_UI_BattleUIController.<>f__mg$cacheB7 == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleUIController.<>f__mg$cacheB7 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleUIController.set_EventOnRegretActive);
		}
		LuaObject.addMember(l, name23, get23, Lua_BlackJack_ProjectL_UI_BattleUIController.<>f__mg$cacheB7, true);
		string name24 = "EventOnRegretConfirm";
		LuaCSFunction get24 = null;
		if (Lua_BlackJack_ProjectL_UI_BattleUIController.<>f__mg$cacheB8 == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleUIController.<>f__mg$cacheB8 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleUIController.set_EventOnRegretConfirm);
		}
		LuaObject.addMember(l, name24, get24, Lua_BlackJack_ProjectL_UI_BattleUIController.<>f__mg$cacheB8, true);
		string name25 = "EventOnRegretCancel";
		LuaCSFunction get25 = null;
		if (Lua_BlackJack_ProjectL_UI_BattleUIController.<>f__mg$cacheB9 == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleUIController.<>f__mg$cacheB9 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleUIController.set_EventOnRegretCancel);
		}
		LuaObject.addMember(l, name25, get25, Lua_BlackJack_ProjectL_UI_BattleUIController.<>f__mg$cacheB9, true);
		string name26 = "EventOnRegretBackward";
		LuaCSFunction get26 = null;
		if (Lua_BlackJack_ProjectL_UI_BattleUIController.<>f__mg$cacheBA == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleUIController.<>f__mg$cacheBA = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleUIController.set_EventOnRegretBackward);
		}
		LuaObject.addMember(l, name26, get26, Lua_BlackJack_ProjectL_UI_BattleUIController.<>f__mg$cacheBA, true);
		string name27 = "EventOnRegretForward";
		LuaCSFunction get27 = null;
		if (Lua_BlackJack_ProjectL_UI_BattleUIController.<>f__mg$cacheBB == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleUIController.<>f__mg$cacheBB = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleUIController.set_EventOnRegretForward);
		}
		LuaObject.addMember(l, name27, get27, Lua_BlackJack_ProjectL_UI_BattleUIController.<>f__mg$cacheBB, true);
		string name28 = "m_marginTransform";
		if (Lua_BlackJack_ProjectL_UI_BattleUIController.<>f__mg$cacheBC == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleUIController.<>f__mg$cacheBC = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleUIController.get_m_marginTransform);
		}
		LuaCSFunction get28 = Lua_BlackJack_ProjectL_UI_BattleUIController.<>f__mg$cacheBC;
		if (Lua_BlackJack_ProjectL_UI_BattleUIController.<>f__mg$cacheBD == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleUIController.<>f__mg$cacheBD = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleUIController.set_m_marginTransform);
		}
		LuaObject.addMember(l, name28, get28, Lua_BlackJack_ProjectL_UI_BattleUIController.<>f__mg$cacheBD, true);
		string name29 = "m_autoOffButton";
		if (Lua_BlackJack_ProjectL_UI_BattleUIController.<>f__mg$cacheBE == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleUIController.<>f__mg$cacheBE = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleUIController.get_m_autoOffButton);
		}
		LuaCSFunction get29 = Lua_BlackJack_ProjectL_UI_BattleUIController.<>f__mg$cacheBE;
		if (Lua_BlackJack_ProjectL_UI_BattleUIController.<>f__mg$cacheBF == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleUIController.<>f__mg$cacheBF = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleUIController.set_m_autoOffButton);
		}
		LuaObject.addMember(l, name29, get29, Lua_BlackJack_ProjectL_UI_BattleUIController.<>f__mg$cacheBF, true);
		string name30 = "m_arenaAutoButton";
		if (Lua_BlackJack_ProjectL_UI_BattleUIController.<>f__mg$cacheC0 == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleUIController.<>f__mg$cacheC0 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleUIController.get_m_arenaAutoButton);
		}
		LuaCSFunction get30 = Lua_BlackJack_ProjectL_UI_BattleUIController.<>f__mg$cacheC0;
		if (Lua_BlackJack_ProjectL_UI_BattleUIController.<>f__mg$cacheC1 == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleUIController.<>f__mg$cacheC1 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleUIController.set_m_arenaAutoButton);
		}
		LuaObject.addMember(l, name30, get30, Lua_BlackJack_ProjectL_UI_BattleUIController.<>f__mg$cacheC1, true);
		string name31 = "m_topLeftGameObject";
		if (Lua_BlackJack_ProjectL_UI_BattleUIController.<>f__mg$cacheC2 == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleUIController.<>f__mg$cacheC2 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleUIController.get_m_topLeftGameObject);
		}
		LuaCSFunction get31 = Lua_BlackJack_ProjectL_UI_BattleUIController.<>f__mg$cacheC2;
		if (Lua_BlackJack_ProjectL_UI_BattleUIController.<>f__mg$cacheC3 == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleUIController.<>f__mg$cacheC3 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleUIController.set_m_topLeftGameObject);
		}
		LuaObject.addMember(l, name31, get31, Lua_BlackJack_ProjectL_UI_BattleUIController.<>f__mg$cacheC3, true);
		string name32 = "m_actorSimpleInfoButton";
		if (Lua_BlackJack_ProjectL_UI_BattleUIController.<>f__mg$cacheC4 == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleUIController.<>f__mg$cacheC4 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleUIController.get_m_actorSimpleInfoButton);
		}
		LuaCSFunction get32 = Lua_BlackJack_ProjectL_UI_BattleUIController.<>f__mg$cacheC4;
		if (Lua_BlackJack_ProjectL_UI_BattleUIController.<>f__mg$cacheC5 == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleUIController.<>f__mg$cacheC5 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleUIController.set_m_actorSimpleInfoButton);
		}
		LuaObject.addMember(l, name32, get32, Lua_BlackJack_ProjectL_UI_BattleUIController.<>f__mg$cacheC5, true);
		string name33 = "m_actorSimpleInfoUIStateController";
		if (Lua_BlackJack_ProjectL_UI_BattleUIController.<>f__mg$cacheC6 == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleUIController.<>f__mg$cacheC6 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleUIController.get_m_actorSimpleInfoUIStateController);
		}
		LuaCSFunction get33 = Lua_BlackJack_ProjectL_UI_BattleUIController.<>f__mg$cacheC6;
		if (Lua_BlackJack_ProjectL_UI_BattleUIController.<>f__mg$cacheC7 == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleUIController.<>f__mg$cacheC7 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleUIController.set_m_actorSimpleInfoUIStateController);
		}
		LuaObject.addMember(l, name33, get33, Lua_BlackJack_ProjectL_UI_BattleUIController.<>f__mg$cacheC7, true);
		string name34 = "m_actorSimpleInfoHeadImage";
		if (Lua_BlackJack_ProjectL_UI_BattleUIController.<>f__mg$cacheC8 == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleUIController.<>f__mg$cacheC8 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleUIController.get_m_actorSimpleInfoHeadImage);
		}
		LuaCSFunction get34 = Lua_BlackJack_ProjectL_UI_BattleUIController.<>f__mg$cacheC8;
		if (Lua_BlackJack_ProjectL_UI_BattleUIController.<>f__mg$cacheC9 == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleUIController.<>f__mg$cacheC9 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleUIController.set_m_actorSimpleInfoHeadImage);
		}
		LuaObject.addMember(l, name34, get34, Lua_BlackJack_ProjectL_UI_BattleUIController.<>f__mg$cacheC9, true);
		string name35 = "m_actorSimpleInfoNameText";
		if (Lua_BlackJack_ProjectL_UI_BattleUIController.<>f__mg$cacheCA == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleUIController.<>f__mg$cacheCA = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleUIController.get_m_actorSimpleInfoNameText);
		}
		LuaCSFunction get35 = Lua_BlackJack_ProjectL_UI_BattleUIController.<>f__mg$cacheCA;
		if (Lua_BlackJack_ProjectL_UI_BattleUIController.<>f__mg$cacheCB == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleUIController.<>f__mg$cacheCB = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleUIController.set_m_actorSimpleInfoNameText);
		}
		LuaObject.addMember(l, name35, get35, Lua_BlackJack_ProjectL_UI_BattleUIController.<>f__mg$cacheCB, true);
		string name36 = "m_actorSimpleInfoLevelText";
		if (Lua_BlackJack_ProjectL_UI_BattleUIController.<>f__mg$cacheCC == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleUIController.<>f__mg$cacheCC = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleUIController.get_m_actorSimpleInfoLevelText);
		}
		LuaCSFunction get36 = Lua_BlackJack_ProjectL_UI_BattleUIController.<>f__mg$cacheCC;
		if (Lua_BlackJack_ProjectL_UI_BattleUIController.<>f__mg$cacheCD == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleUIController.<>f__mg$cacheCD = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleUIController.set_m_actorSimpleInfoLevelText);
		}
		LuaObject.addMember(l, name36, get36, Lua_BlackJack_ProjectL_UI_BattleUIController.<>f__mg$cacheCD, true);
		string name37 = "m_actorSimpleInfoArmyImage";
		if (Lua_BlackJack_ProjectL_UI_BattleUIController.<>f__mg$cacheCE == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleUIController.<>f__mg$cacheCE = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleUIController.get_m_actorSimpleInfoArmyImage);
		}
		LuaCSFunction get37 = Lua_BlackJack_ProjectL_UI_BattleUIController.<>f__mg$cacheCE;
		if (Lua_BlackJack_ProjectL_UI_BattleUIController.<>f__mg$cacheCF == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleUIController.<>f__mg$cacheCF = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleUIController.set_m_actorSimpleInfoArmyImage);
		}
		LuaObject.addMember(l, name37, get37, Lua_BlackJack_ProjectL_UI_BattleUIController.<>f__mg$cacheCF, true);
		string name38 = "m_actorSimpleInfoHeroHPImage";
		if (Lua_BlackJack_ProjectL_UI_BattleUIController.<>f__mg$cacheD0 == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleUIController.<>f__mg$cacheD0 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleUIController.get_m_actorSimpleInfoHeroHPImage);
		}
		LuaCSFunction get38 = Lua_BlackJack_ProjectL_UI_BattleUIController.<>f__mg$cacheD0;
		if (Lua_BlackJack_ProjectL_UI_BattleUIController.<>f__mg$cacheD1 == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleUIController.<>f__mg$cacheD1 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleUIController.set_m_actorSimpleInfoHeroHPImage);
		}
		LuaObject.addMember(l, name38, get38, Lua_BlackJack_ProjectL_UI_BattleUIController.<>f__mg$cacheD1, true);
		string name39 = "m_actorSimpleInfoHeroHPText";
		if (Lua_BlackJack_ProjectL_UI_BattleUIController.<>f__mg$cacheD2 == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleUIController.<>f__mg$cacheD2 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleUIController.get_m_actorSimpleInfoHeroHPText);
		}
		LuaCSFunction get39 = Lua_BlackJack_ProjectL_UI_BattleUIController.<>f__mg$cacheD2;
		if (Lua_BlackJack_ProjectL_UI_BattleUIController.<>f__mg$cacheD3 == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleUIController.<>f__mg$cacheD3 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleUIController.set_m_actorSimpleInfoHeroHPText);
		}
		LuaObject.addMember(l, name39, get39, Lua_BlackJack_ProjectL_UI_BattleUIController.<>f__mg$cacheD3, true);
		string name40 = "m_actorSimpleInfoSoldierHPImage";
		if (Lua_BlackJack_ProjectL_UI_BattleUIController.<>f__mg$cacheD4 == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleUIController.<>f__mg$cacheD4 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleUIController.get_m_actorSimpleInfoSoldierHPImage);
		}
		LuaCSFunction get40 = Lua_BlackJack_ProjectL_UI_BattleUIController.<>f__mg$cacheD4;
		if (Lua_BlackJack_ProjectL_UI_BattleUIController.<>f__mg$cacheD5 == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleUIController.<>f__mg$cacheD5 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleUIController.set_m_actorSimpleInfoSoldierHPImage);
		}
		LuaObject.addMember(l, name40, get40, Lua_BlackJack_ProjectL_UI_BattleUIController.<>f__mg$cacheD5, true);
		string name41 = "m_actorSimpleInfoSoldierHPText";
		if (Lua_BlackJack_ProjectL_UI_BattleUIController.<>f__mg$cacheD6 == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleUIController.<>f__mg$cacheD6 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleUIController.get_m_actorSimpleInfoSoldierHPText);
		}
		LuaCSFunction get41 = Lua_BlackJack_ProjectL_UI_BattleUIController.<>f__mg$cacheD6;
		if (Lua_BlackJack_ProjectL_UI_BattleUIController.<>f__mg$cacheD7 == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleUIController.<>f__mg$cacheD7 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleUIController.set_m_actorSimpleInfoSoldierHPText);
		}
		LuaObject.addMember(l, name41, get41, Lua_BlackJack_ProjectL_UI_BattleUIController.<>f__mg$cacheD7, true);
		string name42 = "m_topLeftGameObject2";
		if (Lua_BlackJack_ProjectL_UI_BattleUIController.<>f__mg$cacheD8 == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleUIController.<>f__mg$cacheD8 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleUIController.get_m_topLeftGameObject2);
		}
		LuaCSFunction get42 = Lua_BlackJack_ProjectL_UI_BattleUIController.<>f__mg$cacheD8;
		if (Lua_BlackJack_ProjectL_UI_BattleUIController.<>f__mg$cacheD9 == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleUIController.<>f__mg$cacheD9 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleUIController.set_m_topLeftGameObject2);
		}
		LuaObject.addMember(l, name42, get42, Lua_BlackJack_ProjectL_UI_BattleUIController.<>f__mg$cacheD9, true);
		string name43 = "m_regratButton";
		if (Lua_BlackJack_ProjectL_UI_BattleUIController.<>f__mg$cacheDA == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleUIController.<>f__mg$cacheDA = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleUIController.get_m_regratButton);
		}
		LuaCSFunction get43 = Lua_BlackJack_ProjectL_UI_BattleUIController.<>f__mg$cacheDA;
		if (Lua_BlackJack_ProjectL_UI_BattleUIController.<>f__mg$cacheDB == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleUIController.<>f__mg$cacheDB = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleUIController.set_m_regratButton);
		}
		LuaObject.addMember(l, name43, get43, Lua_BlackJack_ProjectL_UI_BattleUIController.<>f__mg$cacheDB, true);
		string name44 = "m_regretButtonUIStateController";
		if (Lua_BlackJack_ProjectL_UI_BattleUIController.<>f__mg$cacheDC == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleUIController.<>f__mg$cacheDC = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleUIController.get_m_regretButtonUIStateController);
		}
		LuaCSFunction get44 = Lua_BlackJack_ProjectL_UI_BattleUIController.<>f__mg$cacheDC;
		if (Lua_BlackJack_ProjectL_UI_BattleUIController.<>f__mg$cacheDD == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleUIController.<>f__mg$cacheDD = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleUIController.set_m_regretButtonUIStateController);
		}
		LuaObject.addMember(l, name44, get44, Lua_BlackJack_ProjectL_UI_BattleUIController.<>f__mg$cacheDD, true);
		string name45 = "m_regretCountText";
		if (Lua_BlackJack_ProjectL_UI_BattleUIController.<>f__mg$cacheDE == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleUIController.<>f__mg$cacheDE = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleUIController.get_m_regretCountText);
		}
		LuaCSFunction get45 = Lua_BlackJack_ProjectL_UI_BattleUIController.<>f__mg$cacheDE;
		if (Lua_BlackJack_ProjectL_UI_BattleUIController.<>f__mg$cacheDF == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleUIController.<>f__mg$cacheDF = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleUIController.set_m_regretCountText);
		}
		LuaObject.addMember(l, name45, get45, Lua_BlackJack_ProjectL_UI_BattleUIController.<>f__mg$cacheDF, true);
		string name46 = "m_topRightGameObject2";
		if (Lua_BlackJack_ProjectL_UI_BattleUIController.<>f__mg$cacheE0 == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleUIController.<>f__mg$cacheE0 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleUIController.get_m_topRightGameObject2);
		}
		LuaCSFunction get46 = Lua_BlackJack_ProjectL_UI_BattleUIController.<>f__mg$cacheE0;
		if (Lua_BlackJack_ProjectL_UI_BattleUIController.<>f__mg$cacheE1 == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleUIController.<>f__mg$cacheE1 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleUIController.set_m_topRightGameObject2);
		}
		LuaObject.addMember(l, name46, get46, Lua_BlackJack_ProjectL_UI_BattleUIController.<>f__mg$cacheE1, true);
		string name47 = "m_pauseButton";
		if (Lua_BlackJack_ProjectL_UI_BattleUIController.<>f__mg$cacheE2 == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleUIController.<>f__mg$cacheE2 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleUIController.get_m_pauseButton);
		}
		LuaCSFunction get47 = Lua_BlackJack_ProjectL_UI_BattleUIController.<>f__mg$cacheE2;
		if (Lua_BlackJack_ProjectL_UI_BattleUIController.<>f__mg$cacheE3 == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleUIController.<>f__mg$cacheE3 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleUIController.set_m_pauseButton);
		}
		LuaObject.addMember(l, name47, get47, Lua_BlackJack_ProjectL_UI_BattleUIController.<>f__mg$cacheE3, true);
		string name48 = "m_autoButton";
		if (Lua_BlackJack_ProjectL_UI_BattleUIController.<>f__mg$cacheE4 == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleUIController.<>f__mg$cacheE4 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleUIController.get_m_autoButton);
		}
		LuaCSFunction get48 = Lua_BlackJack_ProjectL_UI_BattleUIController.<>f__mg$cacheE4;
		if (Lua_BlackJack_ProjectL_UI_BattleUIController.<>f__mg$cacheE5 == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleUIController.<>f__mg$cacheE5 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleUIController.set_m_autoButton);
		}
		LuaObject.addMember(l, name48, get48, Lua_BlackJack_ProjectL_UI_BattleUIController.<>f__mg$cacheE5, true);
		string name49 = "m_autoButtonUIStateController";
		if (Lua_BlackJack_ProjectL_UI_BattleUIController.<>f__mg$cacheE6 == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleUIController.<>f__mg$cacheE6 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleUIController.get_m_autoButtonUIStateController);
		}
		LuaCSFunction get49 = Lua_BlackJack_ProjectL_UI_BattleUIController.<>f__mg$cacheE6;
		if (Lua_BlackJack_ProjectL_UI_BattleUIController.<>f__mg$cacheE7 == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleUIController.<>f__mg$cacheE7 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleUIController.set_m_autoButtonUIStateController);
		}
		LuaObject.addMember(l, name49, get49, Lua_BlackJack_ProjectL_UI_BattleUIController.<>f__mg$cacheE7, true);
		string name50 = "m_fastButton";
		if (Lua_BlackJack_ProjectL_UI_BattleUIController.<>f__mg$cacheE8 == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleUIController.<>f__mg$cacheE8 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleUIController.get_m_fastButton);
		}
		LuaCSFunction get50 = Lua_BlackJack_ProjectL_UI_BattleUIController.<>f__mg$cacheE8;
		if (Lua_BlackJack_ProjectL_UI_BattleUIController.<>f__mg$cacheE9 == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleUIController.<>f__mg$cacheE9 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleUIController.set_m_fastButton);
		}
		LuaObject.addMember(l, name50, get50, Lua_BlackJack_ProjectL_UI_BattleUIController.<>f__mg$cacheE9, true);
		string name51 = "m_fastButtonUIStateController";
		if (Lua_BlackJack_ProjectL_UI_BattleUIController.<>f__mg$cacheEA == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleUIController.<>f__mg$cacheEA = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleUIController.get_m_fastButtonUIStateController);
		}
		LuaCSFunction get51 = Lua_BlackJack_ProjectL_UI_BattleUIController.<>f__mg$cacheEA;
		if (Lua_BlackJack_ProjectL_UI_BattleUIController.<>f__mg$cacheEB == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleUIController.<>f__mg$cacheEB = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleUIController.set_m_fastButtonUIStateController);
		}
		LuaObject.addMember(l, name51, get51, Lua_BlackJack_ProjectL_UI_BattleUIController.<>f__mg$cacheEB, true);
		string name52 = "m_skipCombatButton";
		if (Lua_BlackJack_ProjectL_UI_BattleUIController.<>f__mg$cacheEC == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleUIController.<>f__mg$cacheEC = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleUIController.get_m_skipCombatButton);
		}
		LuaCSFunction get52 = Lua_BlackJack_ProjectL_UI_BattleUIController.<>f__mg$cacheEC;
		if (Lua_BlackJack_ProjectL_UI_BattleUIController.<>f__mg$cacheED == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleUIController.<>f__mg$cacheED = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleUIController.set_m_skipCombatButton);
		}
		LuaObject.addMember(l, name52, get52, Lua_BlackJack_ProjectL_UI_BattleUIController.<>f__mg$cacheED, true);
		string name53 = "m_skipCombatButtonUIStateController";
		if (Lua_BlackJack_ProjectL_UI_BattleUIController.<>f__mg$cacheEE == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleUIController.<>f__mg$cacheEE = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleUIController.get_m_skipCombatButtonUIStateController);
		}
		LuaCSFunction get53 = Lua_BlackJack_ProjectL_UI_BattleUIController.<>f__mg$cacheEE;
		if (Lua_BlackJack_ProjectL_UI_BattleUIController.<>f__mg$cacheEF == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleUIController.<>f__mg$cacheEF = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleUIController.set_m_skipCombatButtonUIStateController);
		}
		LuaObject.addMember(l, name53, get53, Lua_BlackJack_ProjectL_UI_BattleUIController.<>f__mg$cacheEF, true);
		string name54 = "m_terrainInfoGameObject";
		if (Lua_BlackJack_ProjectL_UI_BattleUIController.<>f__mg$cacheF0 == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleUIController.<>f__mg$cacheF0 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleUIController.get_m_terrainInfoGameObject);
		}
		LuaCSFunction get54 = Lua_BlackJack_ProjectL_UI_BattleUIController.<>f__mg$cacheF0;
		if (Lua_BlackJack_ProjectL_UI_BattleUIController.<>f__mg$cacheF1 == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleUIController.<>f__mg$cacheF1 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleUIController.set_m_terrainInfoGameObject);
		}
		LuaObject.addMember(l, name54, get54, Lua_BlackJack_ProjectL_UI_BattleUIController.<>f__mg$cacheF1, true);
		string name55 = "m_terrainInfoButton";
		if (Lua_BlackJack_ProjectL_UI_BattleUIController.<>f__mg$cacheF2 == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleUIController.<>f__mg$cacheF2 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleUIController.get_m_terrainInfoButton);
		}
		LuaCSFunction get55 = Lua_BlackJack_ProjectL_UI_BattleUIController.<>f__mg$cacheF2;
		if (Lua_BlackJack_ProjectL_UI_BattleUIController.<>f__mg$cacheF3 == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleUIController.<>f__mg$cacheF3 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleUIController.set_m_terrainInfoButton);
		}
		LuaObject.addMember(l, name55, get55, Lua_BlackJack_ProjectL_UI_BattleUIController.<>f__mg$cacheF3, true);
		string name56 = "m_terrainInfoText";
		if (Lua_BlackJack_ProjectL_UI_BattleUIController.<>f__mg$cacheF4 == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleUIController.<>f__mg$cacheF4 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleUIController.get_m_terrainInfoText);
		}
		LuaCSFunction get56 = Lua_BlackJack_ProjectL_UI_BattleUIController.<>f__mg$cacheF4;
		if (Lua_BlackJack_ProjectL_UI_BattleUIController.<>f__mg$cacheF5 == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleUIController.<>f__mg$cacheF5 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleUIController.set_m_terrainInfoText);
		}
		LuaObject.addMember(l, name56, get56, Lua_BlackJack_ProjectL_UI_BattleUIController.<>f__mg$cacheF5, true);
		string name57 = "m_terrainInfoImage";
		if (Lua_BlackJack_ProjectL_UI_BattleUIController.<>f__mg$cacheF6 == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleUIController.<>f__mg$cacheF6 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleUIController.get_m_terrainInfoImage);
		}
		LuaCSFunction get57 = Lua_BlackJack_ProjectL_UI_BattleUIController.<>f__mg$cacheF6;
		if (Lua_BlackJack_ProjectL_UI_BattleUIController.<>f__mg$cacheF7 == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleUIController.<>f__mg$cacheF7 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleUIController.set_m_terrainInfoImage);
		}
		LuaObject.addMember(l, name57, get57, Lua_BlackJack_ProjectL_UI_BattleUIController.<>f__mg$cacheF7, true);
		string name58 = "m_terrainInfoDefText";
		if (Lua_BlackJack_ProjectL_UI_BattleUIController.<>f__mg$cacheF8 == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleUIController.<>f__mg$cacheF8 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleUIController.get_m_terrainInfoDefText);
		}
		LuaCSFunction get58 = Lua_BlackJack_ProjectL_UI_BattleUIController.<>f__mg$cacheF8;
		if (Lua_BlackJack_ProjectL_UI_BattleUIController.<>f__mg$cacheF9 == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleUIController.<>f__mg$cacheF9 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleUIController.set_m_terrainInfoDefText);
		}
		LuaObject.addMember(l, name58, get58, Lua_BlackJack_ProjectL_UI_BattleUIController.<>f__mg$cacheF9, true);
		string name59 = "m_bottomGameObject";
		if (Lua_BlackJack_ProjectL_UI_BattleUIController.<>f__mg$cacheFA == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleUIController.<>f__mg$cacheFA = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleUIController.get_m_bottomGameObject);
		}
		LuaCSFunction get59 = Lua_BlackJack_ProjectL_UI_BattleUIController.<>f__mg$cacheFA;
		if (Lua_BlackJack_ProjectL_UI_BattleUIController.<>f__mg$cacheFB == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleUIController.<>f__mg$cacheFB = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleUIController.set_m_bottomGameObject);
		}
		LuaObject.addMember(l, name59, get59, Lua_BlackJack_ProjectL_UI_BattleUIController.<>f__mg$cacheFB, true);
		string name60 = "m_dangerOnButton";
		if (Lua_BlackJack_ProjectL_UI_BattleUIController.<>f__mg$cacheFC == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleUIController.<>f__mg$cacheFC = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleUIController.get_m_dangerOnButton);
		}
		LuaCSFunction get60 = Lua_BlackJack_ProjectL_UI_BattleUIController.<>f__mg$cacheFC;
		if (Lua_BlackJack_ProjectL_UI_BattleUIController.<>f__mg$cacheFD == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleUIController.<>f__mg$cacheFD = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleUIController.set_m_dangerOnButton);
		}
		LuaObject.addMember(l, name60, get60, Lua_BlackJack_ProjectL_UI_BattleUIController.<>f__mg$cacheFD, true);
		string name61 = "m_dangerOffButton";
		if (Lua_BlackJack_ProjectL_UI_BattleUIController.<>f__mg$cacheFE == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleUIController.<>f__mg$cacheFE = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleUIController.get_m_dangerOffButton);
		}
		LuaCSFunction get61 = Lua_BlackJack_ProjectL_UI_BattleUIController.<>f__mg$cacheFE;
		if (Lua_BlackJack_ProjectL_UI_BattleUIController.<>f__mg$cacheFF == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleUIController.<>f__mg$cacheFF = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleUIController.set_m_dangerOffButton);
		}
		LuaObject.addMember(l, name61, get61, Lua_BlackJack_ProjectL_UI_BattleUIController.<>f__mg$cacheFF, true);
		string name62 = "m_endAllActionButton";
		if (Lua_BlackJack_ProjectL_UI_BattleUIController.<>f__mg$cache100 == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleUIController.<>f__mg$cache100 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleUIController.get_m_endAllActionButton);
		}
		LuaCSFunction get62 = Lua_BlackJack_ProjectL_UI_BattleUIController.<>f__mg$cache100;
		if (Lua_BlackJack_ProjectL_UI_BattleUIController.<>f__mg$cache101 == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleUIController.<>f__mg$cache101 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleUIController.set_m_endAllActionButton);
		}
		LuaObject.addMember(l, name62, get62, Lua_BlackJack_ProjectL_UI_BattleUIController.<>f__mg$cache101, true);
		string name63 = "m_useSkillButton";
		if (Lua_BlackJack_ProjectL_UI_BattleUIController.<>f__mg$cache102 == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleUIController.<>f__mg$cache102 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleUIController.get_m_useSkillButton);
		}
		LuaCSFunction get63 = Lua_BlackJack_ProjectL_UI_BattleUIController.<>f__mg$cache102;
		if (Lua_BlackJack_ProjectL_UI_BattleUIController.<>f__mg$cache103 == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleUIController.<>f__mg$cache103 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleUIController.set_m_useSkillButton);
		}
		LuaObject.addMember(l, name63, get63, Lua_BlackJack_ProjectL_UI_BattleUIController.<>f__mg$cache103, true);
		string name64 = "m_cancelSkillButton";
		if (Lua_BlackJack_ProjectL_UI_BattleUIController.<>f__mg$cache104 == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleUIController.<>f__mg$cache104 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleUIController.get_m_cancelSkillButton);
		}
		LuaCSFunction get64 = Lua_BlackJack_ProjectL_UI_BattleUIController.<>f__mg$cache104;
		if (Lua_BlackJack_ProjectL_UI_BattleUIController.<>f__mg$cache105 == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleUIController.<>f__mg$cache105 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleUIController.set_m_cancelSkillButton);
		}
		LuaObject.addMember(l, name64, get64, Lua_BlackJack_ProjectL_UI_BattleUIController.<>f__mg$cache105, true);
		string name65 = "m_chatButton";
		if (Lua_BlackJack_ProjectL_UI_BattleUIController.<>f__mg$cache106 == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleUIController.<>f__mg$cache106 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleUIController.get_m_chatButton);
		}
		LuaCSFunction get65 = Lua_BlackJack_ProjectL_UI_BattleUIController.<>f__mg$cache106;
		if (Lua_BlackJack_ProjectL_UI_BattleUIController.<>f__mg$cache107 == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleUIController.<>f__mg$cache107 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleUIController.set_m_chatButton);
		}
		LuaObject.addMember(l, name65, get65, Lua_BlackJack_ProjectL_UI_BattleUIController.<>f__mg$cache107, true);
		string name66 = "m_chatRedPoint";
		if (Lua_BlackJack_ProjectL_UI_BattleUIController.<>f__mg$cache108 == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleUIController.<>f__mg$cache108 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleUIController.get_m_chatRedPoint);
		}
		LuaCSFunction get66 = Lua_BlackJack_ProjectL_UI_BattleUIController.<>f__mg$cache108;
		if (Lua_BlackJack_ProjectL_UI_BattleUIController.<>f__mg$cache109 == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleUIController.<>f__mg$cache109 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleUIController.set_m_chatRedPoint);
		}
		LuaObject.addMember(l, name66, get66, Lua_BlackJack_ProjectL_UI_BattleUIController.<>f__mg$cache109, true);
		string name67 = "m_skillsUIStateController";
		if (Lua_BlackJack_ProjectL_UI_BattleUIController.<>f__mg$cache10A == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleUIController.<>f__mg$cache10A = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleUIController.get_m_skillsUIStateController);
		}
		LuaCSFunction get67 = Lua_BlackJack_ProjectL_UI_BattleUIController.<>f__mg$cache10A;
		if (Lua_BlackJack_ProjectL_UI_BattleUIController.<>f__mg$cache10B == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleUIController.<>f__mg$cache10B = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleUIController.set_m_skillsUIStateController);
		}
		LuaObject.addMember(l, name67, get67, Lua_BlackJack_ProjectL_UI_BattleUIController.<>f__mg$cache10B, true);
		string name68 = "m_endActionButton";
		if (Lua_BlackJack_ProjectL_UI_BattleUIController.<>f__mg$cache10C == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleUIController.<>f__mg$cache10C = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleUIController.get_m_endActionButton);
		}
		LuaCSFunction get68 = Lua_BlackJack_ProjectL_UI_BattleUIController.<>f__mg$cache10C;
		if (Lua_BlackJack_ProjectL_UI_BattleUIController.<>f__mg$cache10D == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleUIController.<>f__mg$cache10D = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleUIController.set_m_endActionButton);
		}
		LuaObject.addMember(l, name68, get68, Lua_BlackJack_ProjectL_UI_BattleUIController.<>f__mg$cache10D, true);
		string name69 = "m_skillListGameObject";
		if (Lua_BlackJack_ProjectL_UI_BattleUIController.<>f__mg$cache10E == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleUIController.<>f__mg$cache10E = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleUIController.get_m_skillListGameObject);
		}
		LuaCSFunction get69 = Lua_BlackJack_ProjectL_UI_BattleUIController.<>f__mg$cache10E;
		if (Lua_BlackJack_ProjectL_UI_BattleUIController.<>f__mg$cache10F == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleUIController.<>f__mg$cache10F = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleUIController.set_m_skillListGameObject);
		}
		LuaObject.addMember(l, name69, get69, Lua_BlackJack_ProjectL_UI_BattleUIController.<>f__mg$cache10F, true);
		string name70 = "m_skillListUIStateController";
		if (Lua_BlackJack_ProjectL_UI_BattleUIController.<>f__mg$cache110 == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleUIController.<>f__mg$cache110 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleUIController.get_m_skillListUIStateController);
		}
		LuaCSFunction get70 = Lua_BlackJack_ProjectL_UI_BattleUIController.<>f__mg$cache110;
		if (Lua_BlackJack_ProjectL_UI_BattleUIController.<>f__mg$cache111 == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleUIController.<>f__mg$cache111 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleUIController.set_m_skillListUIStateController);
		}
		LuaObject.addMember(l, name70, get70, Lua_BlackJack_ProjectL_UI_BattleUIController.<>f__mg$cache111, true);
		string name71 = "m_skillDescGameObject";
		if (Lua_BlackJack_ProjectL_UI_BattleUIController.<>f__mg$cache112 == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleUIController.<>f__mg$cache112 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleUIController.get_m_skillDescGameObject);
		}
		LuaCSFunction get71 = Lua_BlackJack_ProjectL_UI_BattleUIController.<>f__mg$cache112;
		if (Lua_BlackJack_ProjectL_UI_BattleUIController.<>f__mg$cache113 == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleUIController.<>f__mg$cache113 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleUIController.set_m_skillDescGameObject);
		}
		LuaObject.addMember(l, name71, get71, Lua_BlackJack_ProjectL_UI_BattleUIController.<>f__mg$cache113, true);
		string name72 = "m_skillHintUIStateController";
		if (Lua_BlackJack_ProjectL_UI_BattleUIController.<>f__mg$cache114 == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleUIController.<>f__mg$cache114 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleUIController.get_m_skillHintUIStateController);
		}
		LuaCSFunction get72 = Lua_BlackJack_ProjectL_UI_BattleUIController.<>f__mg$cache114;
		if (Lua_BlackJack_ProjectL_UI_BattleUIController.<>f__mg$cache115 == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleUIController.<>f__mg$cache115 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleUIController.set_m_skillHintUIStateController);
		}
		LuaObject.addMember(l, name72, get72, Lua_BlackJack_ProjectL_UI_BattleUIController.<>f__mg$cache115, true);
		string name73 = "m_skillHintText";
		if (Lua_BlackJack_ProjectL_UI_BattleUIController.<>f__mg$cache116 == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleUIController.<>f__mg$cache116 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleUIController.get_m_skillHintText);
		}
		LuaCSFunction get73 = Lua_BlackJack_ProjectL_UI_BattleUIController.<>f__mg$cache116;
		if (Lua_BlackJack_ProjectL_UI_BattleUIController.<>f__mg$cache117 == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleUIController.<>f__mg$cache117 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleUIController.set_m_skillHintText);
		}
		LuaObject.addMember(l, name73, get73, Lua_BlackJack_ProjectL_UI_BattleUIController.<>f__mg$cache117, true);
		string name74 = "m_statusUIStateController";
		if (Lua_BlackJack_ProjectL_UI_BattleUIController.<>f__mg$cache118 == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleUIController.<>f__mg$cache118 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleUIController.get_m_statusUIStateController);
		}
		LuaCSFunction get74 = Lua_BlackJack_ProjectL_UI_BattleUIController.<>f__mg$cache118;
		if (Lua_BlackJack_ProjectL_UI_BattleUIController.<>f__mg$cache119 == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleUIController.<>f__mg$cache119 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleUIController.set_m_statusUIStateController);
		}
		LuaObject.addMember(l, name74, get74, Lua_BlackJack_ProjectL_UI_BattleUIController.<>f__mg$cache119, true);
		string name75 = "m_statusTurnText";
		if (Lua_BlackJack_ProjectL_UI_BattleUIController.<>f__mg$cache11A == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleUIController.<>f__mg$cache11A = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleUIController.get_m_statusTurnText);
		}
		LuaCSFunction get75 = Lua_BlackJack_ProjectL_UI_BattleUIController.<>f__mg$cache11A;
		if (Lua_BlackJack_ProjectL_UI_BattleUIController.<>f__mg$cache11B == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleUIController.<>f__mg$cache11B = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleUIController.set_m_statusTurnText);
		}
		LuaObject.addMember(l, name75, get75, Lua_BlackJack_ProjectL_UI_BattleUIController.<>f__mg$cache11B, true);
		string name76 = "m_statusWinDescGameObject1";
		if (Lua_BlackJack_ProjectL_UI_BattleUIController.<>f__mg$cache11C == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleUIController.<>f__mg$cache11C = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleUIController.get_m_statusWinDescGameObject1);
		}
		LuaCSFunction get76 = Lua_BlackJack_ProjectL_UI_BattleUIController.<>f__mg$cache11C;
		if (Lua_BlackJack_ProjectL_UI_BattleUIController.<>f__mg$cache11D == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleUIController.<>f__mg$cache11D = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleUIController.set_m_statusWinDescGameObject1);
		}
		LuaObject.addMember(l, name76, get76, Lua_BlackJack_ProjectL_UI_BattleUIController.<>f__mg$cache11D, true);
		string name77 = "m_statusWinDescText1";
		if (Lua_BlackJack_ProjectL_UI_BattleUIController.<>f__mg$cache11E == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleUIController.<>f__mg$cache11E = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleUIController.get_m_statusWinDescText1);
		}
		LuaCSFunction get77 = Lua_BlackJack_ProjectL_UI_BattleUIController.<>f__mg$cache11E;
		if (Lua_BlackJack_ProjectL_UI_BattleUIController.<>f__mg$cache11F == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleUIController.<>f__mg$cache11F = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleUIController.set_m_statusWinDescText1);
		}
		LuaObject.addMember(l, name77, get77, Lua_BlackJack_ProjectL_UI_BattleUIController.<>f__mg$cache11F, true);
		string name78 = "m_statusWinDescGameObject2";
		if (Lua_BlackJack_ProjectL_UI_BattleUIController.<>f__mg$cache120 == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleUIController.<>f__mg$cache120 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleUIController.get_m_statusWinDescGameObject2);
		}
		LuaCSFunction get78 = Lua_BlackJack_ProjectL_UI_BattleUIController.<>f__mg$cache120;
		if (Lua_BlackJack_ProjectL_UI_BattleUIController.<>f__mg$cache121 == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleUIController.<>f__mg$cache121 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleUIController.set_m_statusWinDescGameObject2);
		}
		LuaObject.addMember(l, name78, get78, Lua_BlackJack_ProjectL_UI_BattleUIController.<>f__mg$cache121, true);
		string name79 = "m_statusWinDescText2";
		if (Lua_BlackJack_ProjectL_UI_BattleUIController.<>f__mg$cache122 == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleUIController.<>f__mg$cache122 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleUIController.get_m_statusWinDescText2);
		}
		LuaCSFunction get79 = Lua_BlackJack_ProjectL_UI_BattleUIController.<>f__mg$cache122;
		if (Lua_BlackJack_ProjectL_UI_BattleUIController.<>f__mg$cache123 == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleUIController.<>f__mg$cache123 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleUIController.set_m_statusWinDescText2);
		}
		LuaObject.addMember(l, name79, get79, Lua_BlackJack_ProjectL_UI_BattleUIController.<>f__mg$cache123, true);
		string name80 = "m_danmakuStateCtrl";
		if (Lua_BlackJack_ProjectL_UI_BattleUIController.<>f__mg$cache124 == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleUIController.<>f__mg$cache124 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleUIController.get_m_danmakuStateCtrl);
		}
		LuaCSFunction get80 = Lua_BlackJack_ProjectL_UI_BattleUIController.<>f__mg$cache124;
		if (Lua_BlackJack_ProjectL_UI_BattleUIController.<>f__mg$cache125 == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleUIController.<>f__mg$cache125 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleUIController.set_m_danmakuStateCtrl);
		}
		LuaObject.addMember(l, name80, get80, Lua_BlackJack_ProjectL_UI_BattleUIController.<>f__mg$cache125, true);
		string name81 = "m_danmakuInputBackButton";
		if (Lua_BlackJack_ProjectL_UI_BattleUIController.<>f__mg$cache126 == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleUIController.<>f__mg$cache126 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleUIController.get_m_danmakuInputBackButton);
		}
		LuaCSFunction get81 = Lua_BlackJack_ProjectL_UI_BattleUIController.<>f__mg$cache126;
		if (Lua_BlackJack_ProjectL_UI_BattleUIController.<>f__mg$cache127 == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleUIController.<>f__mg$cache127 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleUIController.set_m_danmakuInputBackButton);
		}
		LuaObject.addMember(l, name81, get81, Lua_BlackJack_ProjectL_UI_BattleUIController.<>f__mg$cache127, true);
		string name82 = "m_danmakuToggle";
		if (Lua_BlackJack_ProjectL_UI_BattleUIController.<>f__mg$cache128 == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleUIController.<>f__mg$cache128 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleUIController.get_m_danmakuToggle);
		}
		LuaCSFunction get82 = Lua_BlackJack_ProjectL_UI_BattleUIController.<>f__mg$cache128;
		if (Lua_BlackJack_ProjectL_UI_BattleUIController.<>f__mg$cache129 == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleUIController.<>f__mg$cache129 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleUIController.set_m_danmakuToggle);
		}
		LuaObject.addMember(l, name82, get82, Lua_BlackJack_ProjectL_UI_BattleUIController.<>f__mg$cache129, true);
		string name83 = "m_danmakuInputWordButton";
		if (Lua_BlackJack_ProjectL_UI_BattleUIController.<>f__mg$cache12A == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleUIController.<>f__mg$cache12A = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleUIController.get_m_danmakuInputWordButton);
		}
		LuaCSFunction get83 = Lua_BlackJack_ProjectL_UI_BattleUIController.<>f__mg$cache12A;
		if (Lua_BlackJack_ProjectL_UI_BattleUIController.<>f__mg$cache12B == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleUIController.<>f__mg$cache12B = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleUIController.set_m_danmakuInputWordButton);
		}
		LuaObject.addMember(l, name83, get83, Lua_BlackJack_ProjectL_UI_BattleUIController.<>f__mg$cache12B, true);
		string name84 = "m_danmakuInputField";
		if (Lua_BlackJack_ProjectL_UI_BattleUIController.<>f__mg$cache12C == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleUIController.<>f__mg$cache12C = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleUIController.get_m_danmakuInputField);
		}
		LuaCSFunction get84 = Lua_BlackJack_ProjectL_UI_BattleUIController.<>f__mg$cache12C;
		if (Lua_BlackJack_ProjectL_UI_BattleUIController.<>f__mg$cache12D == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleUIController.<>f__mg$cache12D = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleUIController.set_m_danmakuInputField);
		}
		LuaObject.addMember(l, name84, get84, Lua_BlackJack_ProjectL_UI_BattleUIController.<>f__mg$cache12D, true);
		string name85 = "m_danmakuSendButton";
		if (Lua_BlackJack_ProjectL_UI_BattleUIController.<>f__mg$cache12E == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleUIController.<>f__mg$cache12E = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleUIController.get_m_danmakuSendButton);
		}
		LuaCSFunction get85 = Lua_BlackJack_ProjectL_UI_BattleUIController.<>f__mg$cache12E;
		if (Lua_BlackJack_ProjectL_UI_BattleUIController.<>f__mg$cache12F == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleUIController.<>f__mg$cache12F = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleUIController.set_m_danmakuSendButton);
		}
		LuaObject.addMember(l, name85, get85, Lua_BlackJack_ProjectL_UI_BattleUIController.<>f__mg$cache12F, true);
		string name86 = "m_regretUIStateController";
		if (Lua_BlackJack_ProjectL_UI_BattleUIController.<>f__mg$cache130 == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleUIController.<>f__mg$cache130 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleUIController.get_m_regretUIStateController);
		}
		LuaCSFunction get86 = Lua_BlackJack_ProjectL_UI_BattleUIController.<>f__mg$cache130;
		if (Lua_BlackJack_ProjectL_UI_BattleUIController.<>f__mg$cache131 == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleUIController.<>f__mg$cache131 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleUIController.set_m_regretUIStateController);
		}
		LuaObject.addMember(l, name86, get86, Lua_BlackJack_ProjectL_UI_BattleUIController.<>f__mg$cache131, true);
		string name87 = "m_regretPanelGameObject";
		if (Lua_BlackJack_ProjectL_UI_BattleUIController.<>f__mg$cache132 == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleUIController.<>f__mg$cache132 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleUIController.get_m_regretPanelGameObject);
		}
		LuaCSFunction get87 = Lua_BlackJack_ProjectL_UI_BattleUIController.<>f__mg$cache132;
		if (Lua_BlackJack_ProjectL_UI_BattleUIController.<>f__mg$cache133 == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleUIController.<>f__mg$cache133 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleUIController.set_m_regretPanelGameObject);
		}
		LuaObject.addMember(l, name87, get87, Lua_BlackJack_ProjectL_UI_BattleUIController.<>f__mg$cache133, true);
		string name88 = "m_regratConfirmButton";
		if (Lua_BlackJack_ProjectL_UI_BattleUIController.<>f__mg$cache134 == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleUIController.<>f__mg$cache134 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleUIController.get_m_regratConfirmButton);
		}
		LuaCSFunction get88 = Lua_BlackJack_ProjectL_UI_BattleUIController.<>f__mg$cache134;
		if (Lua_BlackJack_ProjectL_UI_BattleUIController.<>f__mg$cache135 == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleUIController.<>f__mg$cache135 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleUIController.set_m_regratConfirmButton);
		}
		LuaObject.addMember(l, name88, get88, Lua_BlackJack_ProjectL_UI_BattleUIController.<>f__mg$cache135, true);
		string name89 = "m_regretConfirmUIStateController";
		if (Lua_BlackJack_ProjectL_UI_BattleUIController.<>f__mg$cache136 == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleUIController.<>f__mg$cache136 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleUIController.get_m_regretConfirmUIStateController);
		}
		LuaCSFunction get89 = Lua_BlackJack_ProjectL_UI_BattleUIController.<>f__mg$cache136;
		if (Lua_BlackJack_ProjectL_UI_BattleUIController.<>f__mg$cache137 == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleUIController.<>f__mg$cache137 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleUIController.set_m_regretConfirmUIStateController);
		}
		LuaObject.addMember(l, name89, get89, Lua_BlackJack_ProjectL_UI_BattleUIController.<>f__mg$cache137, true);
		string name90 = "m_regretCancelButton";
		if (Lua_BlackJack_ProjectL_UI_BattleUIController.<>f__mg$cache138 == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleUIController.<>f__mg$cache138 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleUIController.get_m_regretCancelButton);
		}
		LuaCSFunction get90 = Lua_BlackJack_ProjectL_UI_BattleUIController.<>f__mg$cache138;
		if (Lua_BlackJack_ProjectL_UI_BattleUIController.<>f__mg$cache139 == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleUIController.<>f__mg$cache139 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleUIController.set_m_regretCancelButton);
		}
		LuaObject.addMember(l, name90, get90, Lua_BlackJack_ProjectL_UI_BattleUIController.<>f__mg$cache139, true);
		string name91 = "m_regretBackwardButton";
		if (Lua_BlackJack_ProjectL_UI_BattleUIController.<>f__mg$cache13A == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleUIController.<>f__mg$cache13A = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleUIController.get_m_regretBackwardButton);
		}
		LuaCSFunction get91 = Lua_BlackJack_ProjectL_UI_BattleUIController.<>f__mg$cache13A;
		if (Lua_BlackJack_ProjectL_UI_BattleUIController.<>f__mg$cache13B == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleUIController.<>f__mg$cache13B = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleUIController.set_m_regretBackwardButton);
		}
		LuaObject.addMember(l, name91, get91, Lua_BlackJack_ProjectL_UI_BattleUIController.<>f__mg$cache13B, true);
		string name92 = "m_regretBackwardUIStateController";
		if (Lua_BlackJack_ProjectL_UI_BattleUIController.<>f__mg$cache13C == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleUIController.<>f__mg$cache13C = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleUIController.get_m_regretBackwardUIStateController);
		}
		LuaCSFunction get92 = Lua_BlackJack_ProjectL_UI_BattleUIController.<>f__mg$cache13C;
		if (Lua_BlackJack_ProjectL_UI_BattleUIController.<>f__mg$cache13D == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleUIController.<>f__mg$cache13D = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleUIController.set_m_regretBackwardUIStateController);
		}
		LuaObject.addMember(l, name92, get92, Lua_BlackJack_ProjectL_UI_BattleUIController.<>f__mg$cache13D, true);
		string name93 = "m_regretForwardButton";
		if (Lua_BlackJack_ProjectL_UI_BattleUIController.<>f__mg$cache13E == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleUIController.<>f__mg$cache13E = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleUIController.get_m_regretForwardButton);
		}
		LuaCSFunction get93 = Lua_BlackJack_ProjectL_UI_BattleUIController.<>f__mg$cache13E;
		if (Lua_BlackJack_ProjectL_UI_BattleUIController.<>f__mg$cache13F == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleUIController.<>f__mg$cache13F = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleUIController.set_m_regretForwardButton);
		}
		LuaObject.addMember(l, name93, get93, Lua_BlackJack_ProjectL_UI_BattleUIController.<>f__mg$cache13F, true);
		string name94 = "m_regretForwardUIStateController";
		if (Lua_BlackJack_ProjectL_UI_BattleUIController.<>f__mg$cache140 == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleUIController.<>f__mg$cache140 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleUIController.get_m_regretForwardUIStateController);
		}
		LuaCSFunction get94 = Lua_BlackJack_ProjectL_UI_BattleUIController.<>f__mg$cache140;
		if (Lua_BlackJack_ProjectL_UI_BattleUIController.<>f__mg$cache141 == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleUIController.<>f__mg$cache141 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleUIController.set_m_regretForwardUIStateController);
		}
		LuaObject.addMember(l, name94, get94, Lua_BlackJack_ProjectL_UI_BattleUIController.<>f__mg$cache141, true);
		string name95 = "m_regretTurnText";
		if (Lua_BlackJack_ProjectL_UI_BattleUIController.<>f__mg$cache142 == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleUIController.<>f__mg$cache142 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleUIController.get_m_regretTurnText);
		}
		LuaCSFunction get95 = Lua_BlackJack_ProjectL_UI_BattleUIController.<>f__mg$cache142;
		if (Lua_BlackJack_ProjectL_UI_BattleUIController.<>f__mg$cache143 == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleUIController.<>f__mg$cache143 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleUIController.set_m_regretTurnText);
		}
		LuaObject.addMember(l, name95, get95, Lua_BlackJack_ProjectL_UI_BattleUIController.<>f__mg$cache143, true);
		string name96 = "m_regretActionText";
		if (Lua_BlackJack_ProjectL_UI_BattleUIController.<>f__mg$cache144 == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleUIController.<>f__mg$cache144 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleUIController.get_m_regretActionText);
		}
		LuaCSFunction get96 = Lua_BlackJack_ProjectL_UI_BattleUIController.<>f__mg$cache144;
		if (Lua_BlackJack_ProjectL_UI_BattleUIController.<>f__mg$cache145 == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleUIController.<>f__mg$cache145 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleUIController.set_m_regretActionText);
		}
		LuaObject.addMember(l, name96, get96, Lua_BlackJack_ProjectL_UI_BattleUIController.<>f__mg$cache145, true);
		string name97 = "m_regretTurnUIStateController";
		if (Lua_BlackJack_ProjectL_UI_BattleUIController.<>f__mg$cache146 == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleUIController.<>f__mg$cache146 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleUIController.get_m_regretTurnUIStateController);
		}
		LuaCSFunction get97 = Lua_BlackJack_ProjectL_UI_BattleUIController.<>f__mg$cache146;
		if (Lua_BlackJack_ProjectL_UI_BattleUIController.<>f__mg$cache147 == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleUIController.<>f__mg$cache147 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleUIController.set_m_regretTurnUIStateController);
		}
		LuaObject.addMember(l, name97, get97, Lua_BlackJack_ProjectL_UI_BattleUIController.<>f__mg$cache147, true);
		string name98 = "m_regretMyCountText";
		if (Lua_BlackJack_ProjectL_UI_BattleUIController.<>f__mg$cache148 == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleUIController.<>f__mg$cache148 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleUIController.get_m_regretMyCountText);
		}
		LuaCSFunction get98 = Lua_BlackJack_ProjectL_UI_BattleUIController.<>f__mg$cache148;
		if (Lua_BlackJack_ProjectL_UI_BattleUIController.<>f__mg$cache149 == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleUIController.<>f__mg$cache149 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleUIController.set_m_regretMyCountText);
		}
		LuaObject.addMember(l, name98, get98, Lua_BlackJack_ProjectL_UI_BattleUIController.<>f__mg$cache149, true);
		string name99 = "m_regretEnemyCountText";
		if (Lua_BlackJack_ProjectL_UI_BattleUIController.<>f__mg$cache14A == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleUIController.<>f__mg$cache14A = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleUIController.get_m_regretEnemyCountText);
		}
		LuaCSFunction get99 = Lua_BlackJack_ProjectL_UI_BattleUIController.<>f__mg$cache14A;
		if (Lua_BlackJack_ProjectL_UI_BattleUIController.<>f__mg$cache14B == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleUIController.<>f__mg$cache14B = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleUIController.set_m_regretEnemyCountText);
		}
		LuaObject.addMember(l, name99, get99, Lua_BlackJack_ProjectL_UI_BattleUIController.<>f__mg$cache14B, true);
		string name100 = "m_regretEffectUIStateController";
		if (Lua_BlackJack_ProjectL_UI_BattleUIController.<>f__mg$cache14C == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleUIController.<>f__mg$cache14C = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleUIController.get_m_regretEffectUIStateController);
		}
		LuaCSFunction get100 = Lua_BlackJack_ProjectL_UI_BattleUIController.<>f__mg$cache14C;
		if (Lua_BlackJack_ProjectL_UI_BattleUIController.<>f__mg$cache14D == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleUIController.<>f__mg$cache14D = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleUIController.set_m_regretEffectUIStateController);
		}
		LuaObject.addMember(l, name100, get100, Lua_BlackJack_ProjectL_UI_BattleUIController.<>f__mg$cache14D, true);
		string name101 = "m_regretFxUIStateController";
		if (Lua_BlackJack_ProjectL_UI_BattleUIController.<>f__mg$cache14E == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleUIController.<>f__mg$cache14E = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleUIController.get_m_regretFxUIStateController);
		}
		LuaCSFunction get101 = Lua_BlackJack_ProjectL_UI_BattleUIController.<>f__mg$cache14E;
		if (Lua_BlackJack_ProjectL_UI_BattleUIController.<>f__mg$cache14F == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleUIController.<>f__mg$cache14F = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleUIController.set_m_regretFxUIStateController);
		}
		LuaObject.addMember(l, name101, get101, Lua_BlackJack_ProjectL_UI_BattleUIController.<>f__mg$cache14F, true);
		string name102 = "m_cutsceneSkillUIStateController";
		if (Lua_BlackJack_ProjectL_UI_BattleUIController.<>f__mg$cache150 == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleUIController.<>f__mg$cache150 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleUIController.get_m_cutsceneSkillUIStateController);
		}
		LuaCSFunction get102 = Lua_BlackJack_ProjectL_UI_BattleUIController.<>f__mg$cache150;
		if (Lua_BlackJack_ProjectL_UI_BattleUIController.<>f__mg$cache151 == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleUIController.<>f__mg$cache151 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleUIController.set_m_cutsceneSkillUIStateController);
		}
		LuaObject.addMember(l, name102, get102, Lua_BlackJack_ProjectL_UI_BattleUIController.<>f__mg$cache151, true);
		string name103 = "m_cutsceneSkillIconImage";
		if (Lua_BlackJack_ProjectL_UI_BattleUIController.<>f__mg$cache152 == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleUIController.<>f__mg$cache152 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleUIController.get_m_cutsceneSkillIconImage);
		}
		LuaCSFunction get103 = Lua_BlackJack_ProjectL_UI_BattleUIController.<>f__mg$cache152;
		if (Lua_BlackJack_ProjectL_UI_BattleUIController.<>f__mg$cache153 == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleUIController.<>f__mg$cache153 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleUIController.set_m_cutsceneSkillIconImage);
		}
		LuaObject.addMember(l, name103, get103, Lua_BlackJack_ProjectL_UI_BattleUIController.<>f__mg$cache153, true);
		string name104 = "m_cutsceneSkillNameText";
		if (Lua_BlackJack_ProjectL_UI_BattleUIController.<>f__mg$cache154 == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleUIController.<>f__mg$cache154 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleUIController.get_m_cutsceneSkillNameText);
		}
		LuaCSFunction get104 = Lua_BlackJack_ProjectL_UI_BattleUIController.<>f__mg$cache154;
		if (Lua_BlackJack_ProjectL_UI_BattleUIController.<>f__mg$cache155 == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleUIController.<>f__mg$cache155 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleUIController.set_m_cutsceneSkillNameText);
		}
		LuaObject.addMember(l, name104, get104, Lua_BlackJack_ProjectL_UI_BattleUIController.<>f__mg$cache155, true);
		string name105 = "m_objectiveGameObject";
		if (Lua_BlackJack_ProjectL_UI_BattleUIController.<>f__mg$cache156 == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleUIController.<>f__mg$cache156 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleUIController.get_m_objectiveGameObject);
		}
		LuaCSFunction get105 = Lua_BlackJack_ProjectL_UI_BattleUIController.<>f__mg$cache156;
		if (Lua_BlackJack_ProjectL_UI_BattleUIController.<>f__mg$cache157 == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleUIController.<>f__mg$cache157 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleUIController.set_m_objectiveGameObject);
		}
		LuaObject.addMember(l, name105, get105, Lua_BlackJack_ProjectL_UI_BattleUIController.<>f__mg$cache157, true);
		string name106 = "m_objectiveWinDescText";
		if (Lua_BlackJack_ProjectL_UI_BattleUIController.<>f__mg$cache158 == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleUIController.<>f__mg$cache158 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleUIController.get_m_objectiveWinDescText);
		}
		LuaCSFunction get106 = Lua_BlackJack_ProjectL_UI_BattleUIController.<>f__mg$cache158;
		if (Lua_BlackJack_ProjectL_UI_BattleUIController.<>f__mg$cache159 == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleUIController.<>f__mg$cache159 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleUIController.set_m_objectiveWinDescText);
		}
		LuaObject.addMember(l, name106, get106, Lua_BlackJack_ProjectL_UI_BattleUIController.<>f__mg$cache159, true);
		string name107 = "m_objectiveLoseDescText";
		if (Lua_BlackJack_ProjectL_UI_BattleUIController.<>f__mg$cache15A == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleUIController.<>f__mg$cache15A = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleUIController.get_m_objectiveLoseDescText);
		}
		LuaCSFunction get107 = Lua_BlackJack_ProjectL_UI_BattleUIController.<>f__mg$cache15A;
		if (Lua_BlackJack_ProjectL_UI_BattleUIController.<>f__mg$cache15B == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleUIController.<>f__mg$cache15B = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleUIController.set_m_objectiveLoseDescText);
		}
		LuaObject.addMember(l, name107, get107, Lua_BlackJack_ProjectL_UI_BattleUIController.<>f__mg$cache15B, true);
		string name108 = "m_winGameObject";
		if (Lua_BlackJack_ProjectL_UI_BattleUIController.<>f__mg$cache15C == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleUIController.<>f__mg$cache15C = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleUIController.get_m_winGameObject);
		}
		LuaCSFunction get108 = Lua_BlackJack_ProjectL_UI_BattleUIController.<>f__mg$cache15C;
		if (Lua_BlackJack_ProjectL_UI_BattleUIController.<>f__mg$cache15D == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleUIController.<>f__mg$cache15D = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleUIController.set_m_winGameObject);
		}
		LuaObject.addMember(l, name108, get108, Lua_BlackJack_ProjectL_UI_BattleUIController.<>f__mg$cache15D, true);
		string name109 = "m_loseGameObject";
		if (Lua_BlackJack_ProjectL_UI_BattleUIController.<>f__mg$cache15E == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleUIController.<>f__mg$cache15E = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleUIController.get_m_loseGameObject);
		}
		LuaCSFunction get109 = Lua_BlackJack_ProjectL_UI_BattleUIController.<>f__mg$cache15E;
		if (Lua_BlackJack_ProjectL_UI_BattleUIController.<>f__mg$cache15F == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleUIController.<>f__mg$cache15F = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleUIController.set_m_loseGameObject);
		}
		LuaObject.addMember(l, name109, get109, Lua_BlackJack_ProjectL_UI_BattleUIController.<>f__mg$cache15F, true);
		string name110 = "m_turnStartGameObject";
		if (Lua_BlackJack_ProjectL_UI_BattleUIController.<>f__mg$cache160 == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleUIController.<>f__mg$cache160 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleUIController.get_m_turnStartGameObject);
		}
		LuaCSFunction get110 = Lua_BlackJack_ProjectL_UI_BattleUIController.<>f__mg$cache160;
		if (Lua_BlackJack_ProjectL_UI_BattleUIController.<>f__mg$cache161 == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleUIController.<>f__mg$cache161 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleUIController.set_m_turnStartGameObject);
		}
		LuaObject.addMember(l, name110, get110, Lua_BlackJack_ProjectL_UI_BattleUIController.<>f__mg$cache161, true);
		string name111 = "m_turnStartText";
		if (Lua_BlackJack_ProjectL_UI_BattleUIController.<>f__mg$cache162 == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleUIController.<>f__mg$cache162 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleUIController.get_m_turnStartText);
		}
		LuaCSFunction get111 = Lua_BlackJack_ProjectL_UI_BattleUIController.<>f__mg$cache162;
		if (Lua_BlackJack_ProjectL_UI_BattleUIController.<>f__mg$cache163 == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleUIController.<>f__mg$cache163 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleUIController.set_m_turnStartText);
		}
		LuaObject.addMember(l, name111, get111, Lua_BlackJack_ProjectL_UI_BattleUIController.<>f__mg$cache163, true);
		string name112 = "m_playerTurnGameObject";
		if (Lua_BlackJack_ProjectL_UI_BattleUIController.<>f__mg$cache164 == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleUIController.<>f__mg$cache164 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleUIController.get_m_playerTurnGameObject);
		}
		LuaCSFunction get112 = Lua_BlackJack_ProjectL_UI_BattleUIController.<>f__mg$cache164;
		if (Lua_BlackJack_ProjectL_UI_BattleUIController.<>f__mg$cache165 == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleUIController.<>f__mg$cache165 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleUIController.set_m_playerTurnGameObject);
		}
		LuaObject.addMember(l, name112, get112, Lua_BlackJack_ProjectL_UI_BattleUIController.<>f__mg$cache165, true);
		string name113 = "m_enemyTurnGameObject";
		if (Lua_BlackJack_ProjectL_UI_BattleUIController.<>f__mg$cache166 == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleUIController.<>f__mg$cache166 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleUIController.get_m_enemyTurnGameObject);
		}
		LuaCSFunction get113 = Lua_BlackJack_ProjectL_UI_BattleUIController.<>f__mg$cache166;
		if (Lua_BlackJack_ProjectL_UI_BattleUIController.<>f__mg$cache167 == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleUIController.<>f__mg$cache167 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleUIController.set_m_enemyTurnGameObject);
		}
		LuaObject.addMember(l, name113, get113, Lua_BlackJack_ProjectL_UI_BattleUIController.<>f__mg$cache167, true);
		string name114 = "m_myActionUIStateController";
		if (Lua_BlackJack_ProjectL_UI_BattleUIController.<>f__mg$cache168 == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleUIController.<>f__mg$cache168 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleUIController.get_m_myActionUIStateController);
		}
		LuaCSFunction get114 = Lua_BlackJack_ProjectL_UI_BattleUIController.<>f__mg$cache168;
		if (Lua_BlackJack_ProjectL_UI_BattleUIController.<>f__mg$cache169 == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleUIController.<>f__mg$cache169 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleUIController.set_m_myActionUIStateController);
		}
		LuaObject.addMember(l, name114, get114, Lua_BlackJack_ProjectL_UI_BattleUIController.<>f__mg$cache169, true);
		string name115 = "m_myActionHeadImage";
		if (Lua_BlackJack_ProjectL_UI_BattleUIController.<>f__mg$cache16A == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleUIController.<>f__mg$cache16A = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleUIController.get_m_myActionHeadImage);
		}
		LuaCSFunction get115 = Lua_BlackJack_ProjectL_UI_BattleUIController.<>f__mg$cache16A;
		if (Lua_BlackJack_ProjectL_UI_BattleUIController.<>f__mg$cache16B == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleUIController.<>f__mg$cache16B = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleUIController.set_m_myActionHeadImage);
		}
		LuaObject.addMember(l, name115, get115, Lua_BlackJack_ProjectL_UI_BattleUIController.<>f__mg$cache16B, true);
		string name116 = "m_myActionNameText";
		if (Lua_BlackJack_ProjectL_UI_BattleUIController.<>f__mg$cache16C == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleUIController.<>f__mg$cache16C = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleUIController.get_m_myActionNameText);
		}
		LuaCSFunction get116 = Lua_BlackJack_ProjectL_UI_BattleUIController.<>f__mg$cache16C;
		if (Lua_BlackJack_ProjectL_UI_BattleUIController.<>f__mg$cache16D == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleUIController.<>f__mg$cache16D = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleUIController.set_m_myActionNameText);
		}
		LuaObject.addMember(l, name116, get116, Lua_BlackJack_ProjectL_UI_BattleUIController.<>f__mg$cache16D, true);
		string name117 = "m_myActionPlayerTagImage";
		if (Lua_BlackJack_ProjectL_UI_BattleUIController.<>f__mg$cache16E == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleUIController.<>f__mg$cache16E = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleUIController.get_m_myActionPlayerTagImage);
		}
		LuaCSFunction get117 = Lua_BlackJack_ProjectL_UI_BattleUIController.<>f__mg$cache16E;
		if (Lua_BlackJack_ProjectL_UI_BattleUIController.<>f__mg$cache16F == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleUIController.<>f__mg$cache16F = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleUIController.set_m_myActionPlayerTagImage);
		}
		LuaObject.addMember(l, name117, get117, Lua_BlackJack_ProjectL_UI_BattleUIController.<>f__mg$cache16F, true);
		string name118 = "m_teammateActionUIStateController";
		if (Lua_BlackJack_ProjectL_UI_BattleUIController.<>f__mg$cache170 == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleUIController.<>f__mg$cache170 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleUIController.get_m_teammateActionUIStateController);
		}
		LuaCSFunction get118 = Lua_BlackJack_ProjectL_UI_BattleUIController.<>f__mg$cache170;
		if (Lua_BlackJack_ProjectL_UI_BattleUIController.<>f__mg$cache171 == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleUIController.<>f__mg$cache171 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleUIController.set_m_teammateActionUIStateController);
		}
		LuaObject.addMember(l, name118, get118, Lua_BlackJack_ProjectL_UI_BattleUIController.<>f__mg$cache171, true);
		string name119 = "m_teammateActionHeadImage";
		if (Lua_BlackJack_ProjectL_UI_BattleUIController.<>f__mg$cache172 == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleUIController.<>f__mg$cache172 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleUIController.get_m_teammateActionHeadImage);
		}
		LuaCSFunction get119 = Lua_BlackJack_ProjectL_UI_BattleUIController.<>f__mg$cache172;
		if (Lua_BlackJack_ProjectL_UI_BattleUIController.<>f__mg$cache173 == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleUIController.<>f__mg$cache173 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleUIController.set_m_teammateActionHeadImage);
		}
		LuaObject.addMember(l, name119, get119, Lua_BlackJack_ProjectL_UI_BattleUIController.<>f__mg$cache173, true);
		string name120 = "m_teammateActionNameText";
		if (Lua_BlackJack_ProjectL_UI_BattleUIController.<>f__mg$cache174 == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleUIController.<>f__mg$cache174 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleUIController.get_m_teammateActionNameText);
		}
		LuaCSFunction get120 = Lua_BlackJack_ProjectL_UI_BattleUIController.<>f__mg$cache174;
		if (Lua_BlackJack_ProjectL_UI_BattleUIController.<>f__mg$cache175 == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleUIController.<>f__mg$cache175 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleUIController.set_m_teammateActionNameText);
		}
		LuaObject.addMember(l, name120, get120, Lua_BlackJack_ProjectL_UI_BattleUIController.<>f__mg$cache175, true);
		string name121 = "m_teammateActionPlayerTagImage";
		if (Lua_BlackJack_ProjectL_UI_BattleUIController.<>f__mg$cache176 == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleUIController.<>f__mg$cache176 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleUIController.get_m_teammateActionPlayerTagImage);
		}
		LuaCSFunction get121 = Lua_BlackJack_ProjectL_UI_BattleUIController.<>f__mg$cache176;
		if (Lua_BlackJack_ProjectL_UI_BattleUIController.<>f__mg$cache177 == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleUIController.<>f__mg$cache177 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleUIController.set_m_teammateActionPlayerTagImage);
		}
		LuaObject.addMember(l, name121, get121, Lua_BlackJack_ProjectL_UI_BattleUIController.<>f__mg$cache177, true);
		string name122 = "m_enemyActionUIStateController";
		if (Lua_BlackJack_ProjectL_UI_BattleUIController.<>f__mg$cache178 == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleUIController.<>f__mg$cache178 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleUIController.get_m_enemyActionUIStateController);
		}
		LuaCSFunction get122 = Lua_BlackJack_ProjectL_UI_BattleUIController.<>f__mg$cache178;
		if (Lua_BlackJack_ProjectL_UI_BattleUIController.<>f__mg$cache179 == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleUIController.<>f__mg$cache179 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleUIController.set_m_enemyActionUIStateController);
		}
		LuaObject.addMember(l, name122, get122, Lua_BlackJack_ProjectL_UI_BattleUIController.<>f__mg$cache179, true);
		string name123 = "m_enemyActionHeadImage";
		if (Lua_BlackJack_ProjectL_UI_BattleUIController.<>f__mg$cache17A == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleUIController.<>f__mg$cache17A = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleUIController.get_m_enemyActionHeadImage);
		}
		LuaCSFunction get123 = Lua_BlackJack_ProjectL_UI_BattleUIController.<>f__mg$cache17A;
		if (Lua_BlackJack_ProjectL_UI_BattleUIController.<>f__mg$cache17B == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleUIController.<>f__mg$cache17B = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleUIController.set_m_enemyActionHeadImage);
		}
		LuaObject.addMember(l, name123, get123, Lua_BlackJack_ProjectL_UI_BattleUIController.<>f__mg$cache17B, true);
		string name124 = "m_enemyActionNameText";
		if (Lua_BlackJack_ProjectL_UI_BattleUIController.<>f__mg$cache17C == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleUIController.<>f__mg$cache17C = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleUIController.get_m_enemyActionNameText);
		}
		LuaCSFunction get124 = Lua_BlackJack_ProjectL_UI_BattleUIController.<>f__mg$cache17C;
		if (Lua_BlackJack_ProjectL_UI_BattleUIController.<>f__mg$cache17D == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleUIController.<>f__mg$cache17D = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleUIController.set_m_enemyActionNameText);
		}
		LuaObject.addMember(l, name124, get124, Lua_BlackJack_ProjectL_UI_BattleUIController.<>f__mg$cache17D, true);
		string name125 = "m_prefabsGameObject";
		if (Lua_BlackJack_ProjectL_UI_BattleUIController.<>f__mg$cache17E == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleUIController.<>f__mg$cache17E = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleUIController.get_m_prefabsGameObject);
		}
		LuaCSFunction get125 = Lua_BlackJack_ProjectL_UI_BattleUIController.<>f__mg$cache17E;
		if (Lua_BlackJack_ProjectL_UI_BattleUIController.<>f__mg$cache17F == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleUIController.<>f__mg$cache17F = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleUIController.set_m_prefabsGameObject);
		}
		LuaObject.addMember(l, name125, get125, Lua_BlackJack_ProjectL_UI_BattleUIController.<>f__mg$cache17F, true);
		string name126 = "m_battleSkillButtonPrefab";
		if (Lua_BlackJack_ProjectL_UI_BattleUIController.<>f__mg$cache180 == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleUIController.<>f__mg$cache180 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleUIController.get_m_battleSkillButtonPrefab);
		}
		LuaCSFunction get126 = Lua_BlackJack_ProjectL_UI_BattleUIController.<>f__mg$cache180;
		if (Lua_BlackJack_ProjectL_UI_BattleUIController.<>f__mg$cache181 == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleUIController.<>f__mg$cache181 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleUIController.set_m_battleSkillButtonPrefab);
		}
		LuaObject.addMember(l, name126, get126, Lua_BlackJack_ProjectL_UI_BattleUIController.<>f__mg$cache181, true);
		string name127 = "m_armyRelationButtonUIStateController";
		if (Lua_BlackJack_ProjectL_UI_BattleUIController.<>f__mg$cache182 == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleUIController.<>f__mg$cache182 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleUIController.get_m_armyRelationButtonUIStateController);
		}
		LuaCSFunction get127 = Lua_BlackJack_ProjectL_UI_BattleUIController.<>f__mg$cache182;
		if (Lua_BlackJack_ProjectL_UI_BattleUIController.<>f__mg$cache183 == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleUIController.<>f__mg$cache183 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleUIController.set_m_armyRelationButtonUIStateController);
		}
		LuaObject.addMember(l, name127, get127, Lua_BlackJack_ProjectL_UI_BattleUIController.<>f__mg$cache183, true);
		string name128 = "m_armyRelationDescUIStateController";
		if (Lua_BlackJack_ProjectL_UI_BattleUIController.<>f__mg$cache184 == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleUIController.<>f__mg$cache184 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleUIController.get_m_armyRelationDescUIStateController);
		}
		LuaCSFunction get128 = Lua_BlackJack_ProjectL_UI_BattleUIController.<>f__mg$cache184;
		if (Lua_BlackJack_ProjectL_UI_BattleUIController.<>f__mg$cache185 == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleUIController.<>f__mg$cache185 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleUIController.set_m_armyRelationDescUIStateController);
		}
		LuaObject.addMember(l, name128, get128, Lua_BlackJack_ProjectL_UI_BattleUIController.<>f__mg$cache185, true);
		string name129 = "m_pointerDownPosition";
		if (Lua_BlackJack_ProjectL_UI_BattleUIController.<>f__mg$cache186 == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleUIController.<>f__mg$cache186 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleUIController.get_m_pointerDownPosition);
		}
		LuaCSFunction get129 = Lua_BlackJack_ProjectL_UI_BattleUIController.<>f__mg$cache186;
		if (Lua_BlackJack_ProjectL_UI_BattleUIController.<>f__mg$cache187 == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleUIController.<>f__mg$cache187 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleUIController.set_m_pointerDownPosition);
		}
		LuaObject.addMember(l, name129, get129, Lua_BlackJack_ProjectL_UI_BattleUIController.<>f__mg$cache187, true);
		string name130 = "m_battleSkillButtonPool";
		if (Lua_BlackJack_ProjectL_UI_BattleUIController.<>f__mg$cache188 == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleUIController.<>f__mg$cache188 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleUIController.get_m_battleSkillButtonPool);
		}
		LuaCSFunction get130 = Lua_BlackJack_ProjectL_UI_BattleUIController.<>f__mg$cache188;
		if (Lua_BlackJack_ProjectL_UI_BattleUIController.<>f__mg$cache189 == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleUIController.<>f__mg$cache189 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleUIController.set_m_battleSkillButtonPool);
		}
		LuaObject.addMember(l, name130, get130, Lua_BlackJack_ProjectL_UI_BattleUIController.<>f__mg$cache189, true);
		string name131 = "m_chatRedPointLastTime";
		if (Lua_BlackJack_ProjectL_UI_BattleUIController.<>f__mg$cache18A == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleUIController.<>f__mg$cache18A = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleUIController.get_m_chatRedPointLastTime);
		}
		LuaCSFunction get131 = Lua_BlackJack_ProjectL_UI_BattleUIController.<>f__mg$cache18A;
		if (Lua_BlackJack_ProjectL_UI_BattleUIController.<>f__mg$cache18B == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleUIController.<>f__mg$cache18B = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleUIController.set_m_chatRedPointLastTime);
		}
		LuaObject.addMember(l, name131, get131, Lua_BlackJack_ProjectL_UI_BattleUIController.<>f__mg$cache18B, true);
		string name132 = "m_hideSkillHintTime";
		if (Lua_BlackJack_ProjectL_UI_BattleUIController.<>f__mg$cache18C == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleUIController.<>f__mg$cache18C = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleUIController.get_m_hideSkillHintTime);
		}
		LuaCSFunction get132 = Lua_BlackJack_ProjectL_UI_BattleUIController.<>f__mg$cache18C;
		if (Lua_BlackJack_ProjectL_UI_BattleUIController.<>f__mg$cache18D == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleUIController.<>f__mg$cache18D = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleUIController.set_m_hideSkillHintTime);
		}
		LuaObject.addMember(l, name132, get132, Lua_BlackJack_ProjectL_UI_BattleUIController.<>f__mg$cache18D, true);
		string name133 = "m_isShowSkillHint";
		if (Lua_BlackJack_ProjectL_UI_BattleUIController.<>f__mg$cache18E == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleUIController.<>f__mg$cache18E = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleUIController.get_m_isShowSkillHint);
		}
		LuaCSFunction get133 = Lua_BlackJack_ProjectL_UI_BattleUIController.<>f__mg$cache18E;
		if (Lua_BlackJack_ProjectL_UI_BattleUIController.<>f__mg$cache18F == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleUIController.<>f__mg$cache18F = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleUIController.set_m_isShowSkillHint);
		}
		LuaObject.addMember(l, name133, get133, Lua_BlackJack_ProjectL_UI_BattleUIController.<>f__mg$cache18F, true);
		string name134 = "m_isShowRegretPanel";
		if (Lua_BlackJack_ProjectL_UI_BattleUIController.<>f__mg$cache190 == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleUIController.<>f__mg$cache190 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleUIController.get_m_isShowRegretPanel);
		}
		LuaCSFunction get134 = Lua_BlackJack_ProjectL_UI_BattleUIController.<>f__mg$cache190;
		if (Lua_BlackJack_ProjectL_UI_BattleUIController.<>f__mg$cache191 == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleUIController.<>f__mg$cache191 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleUIController.set_m_isShowRegretPanel);
		}
		LuaObject.addMember(l, name134, get134, Lua_BlackJack_ProjectL_UI_BattleUIController.<>f__mg$cache191, true);
		string name135 = "m_developerClickCount";
		if (Lua_BlackJack_ProjectL_UI_BattleUIController.<>f__mg$cache192 == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleUIController.<>f__mg$cache192 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleUIController.get_m_developerClickCount);
		}
		LuaCSFunction get135 = Lua_BlackJack_ProjectL_UI_BattleUIController.<>f__mg$cache192;
		if (Lua_BlackJack_ProjectL_UI_BattleUIController.<>f__mg$cache193 == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleUIController.<>f__mg$cache193 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleUIController.set_m_developerClickCount);
		}
		LuaObject.addMember(l, name135, get135, Lua_BlackJack_ProjectL_UI_BattleUIController.<>f__mg$cache193, true);
		string name136 = "m_turn";
		if (Lua_BlackJack_ProjectL_UI_BattleUIController.<>f__mg$cache194 == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleUIController.<>f__mg$cache194 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleUIController.get_m_turn);
		}
		LuaCSFunction get136 = Lua_BlackJack_ProjectL_UI_BattleUIController.<>f__mg$cache194;
		if (Lua_BlackJack_ProjectL_UI_BattleUIController.<>f__mg$cache195 == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleUIController.<>f__mg$cache195 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleUIController.set_m_turn);
		}
		LuaObject.addMember(l, name136, get136, Lua_BlackJack_ProjectL_UI_BattleUIController.<>f__mg$cache195, true);
		string name137 = "m_configDataLoader";
		if (Lua_BlackJack_ProjectL_UI_BattleUIController.<>f__mg$cache196 == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleUIController.<>f__mg$cache196 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleUIController.get_m_configDataLoader);
		}
		LuaCSFunction get137 = Lua_BlackJack_ProjectL_UI_BattleUIController.<>f__mg$cache196;
		if (Lua_BlackJack_ProjectL_UI_BattleUIController.<>f__mg$cache197 == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleUIController.<>f__mg$cache197 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleUIController.set_m_configDataLoader);
		}
		LuaObject.addMember(l, name137, get137, Lua_BlackJack_ProjectL_UI_BattleUIController.<>f__mg$cache197, true);
		string name138 = "m_playerContext";
		if (Lua_BlackJack_ProjectL_UI_BattleUIController.<>f__mg$cache198 == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleUIController.<>f__mg$cache198 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleUIController.get_m_playerContext);
		}
		LuaCSFunction get138 = Lua_BlackJack_ProjectL_UI_BattleUIController.<>f__mg$cache198;
		if (Lua_BlackJack_ProjectL_UI_BattleUIController.<>f__mg$cache199 == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleUIController.<>f__mg$cache199 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleUIController.set_m_playerContext);
		}
		LuaObject.addMember(l, name138, get138, Lua_BlackJack_ProjectL_UI_BattleUIController.<>f__mg$cache199, true);
		LuaObject.createTypeMetatable(l, null, typeof(BattleUIController), typeof(UIControllerBase));
	}

	// Token: 0x0401232B RID: 74539
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache0;

	// Token: 0x0401232C RID: 74540
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1;

	// Token: 0x0401232D RID: 74541
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2;

	// Token: 0x0401232E RID: 74542
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3;

	// Token: 0x0401232F RID: 74543
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache4;

	// Token: 0x04012330 RID: 74544
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache5;

	// Token: 0x04012331 RID: 74545
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache6;

	// Token: 0x04012332 RID: 74546
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache7;

	// Token: 0x04012333 RID: 74547
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache8;

	// Token: 0x04012334 RID: 74548
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache9;

	// Token: 0x04012335 RID: 74549
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheA;

	// Token: 0x04012336 RID: 74550
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheB;

	// Token: 0x04012337 RID: 74551
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheC;

	// Token: 0x04012338 RID: 74552
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheD;

	// Token: 0x04012339 RID: 74553
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheE;

	// Token: 0x0401233A RID: 74554
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheF;

	// Token: 0x0401233B RID: 74555
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache10;

	// Token: 0x0401233C RID: 74556
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache11;

	// Token: 0x0401233D RID: 74557
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache12;

	// Token: 0x0401233E RID: 74558
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache13;

	// Token: 0x0401233F RID: 74559
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache14;

	// Token: 0x04012340 RID: 74560
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache15;

	// Token: 0x04012341 RID: 74561
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache16;

	// Token: 0x04012342 RID: 74562
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache17;

	// Token: 0x04012343 RID: 74563
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache18;

	// Token: 0x04012344 RID: 74564
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache19;

	// Token: 0x04012345 RID: 74565
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1A;

	// Token: 0x04012346 RID: 74566
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1B;

	// Token: 0x04012347 RID: 74567
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1C;

	// Token: 0x04012348 RID: 74568
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1D;

	// Token: 0x04012349 RID: 74569
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1E;

	// Token: 0x0401234A RID: 74570
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1F;

	// Token: 0x0401234B RID: 74571
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache20;

	// Token: 0x0401234C RID: 74572
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache21;

	// Token: 0x0401234D RID: 74573
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache22;

	// Token: 0x0401234E RID: 74574
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache23;

	// Token: 0x0401234F RID: 74575
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache24;

	// Token: 0x04012350 RID: 74576
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache25;

	// Token: 0x04012351 RID: 74577
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache26;

	// Token: 0x04012352 RID: 74578
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache27;

	// Token: 0x04012353 RID: 74579
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache28;

	// Token: 0x04012354 RID: 74580
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache29;

	// Token: 0x04012355 RID: 74581
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2A;

	// Token: 0x04012356 RID: 74582
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2B;

	// Token: 0x04012357 RID: 74583
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2C;

	// Token: 0x04012358 RID: 74584
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2D;

	// Token: 0x04012359 RID: 74585
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2E;

	// Token: 0x0401235A RID: 74586
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2F;

	// Token: 0x0401235B RID: 74587
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache30;

	// Token: 0x0401235C RID: 74588
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache31;

	// Token: 0x0401235D RID: 74589
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache32;

	// Token: 0x0401235E RID: 74590
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache33;

	// Token: 0x0401235F RID: 74591
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache34;

	// Token: 0x04012360 RID: 74592
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache35;

	// Token: 0x04012361 RID: 74593
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache36;

	// Token: 0x04012362 RID: 74594
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache37;

	// Token: 0x04012363 RID: 74595
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache38;

	// Token: 0x04012364 RID: 74596
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache39;

	// Token: 0x04012365 RID: 74597
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3A;

	// Token: 0x04012366 RID: 74598
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3B;

	// Token: 0x04012367 RID: 74599
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3C;

	// Token: 0x04012368 RID: 74600
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3D;

	// Token: 0x04012369 RID: 74601
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3E;

	// Token: 0x0401236A RID: 74602
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3F;

	// Token: 0x0401236B RID: 74603
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache40;

	// Token: 0x0401236C RID: 74604
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache41;

	// Token: 0x0401236D RID: 74605
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache42;

	// Token: 0x0401236E RID: 74606
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache43;

	// Token: 0x0401236F RID: 74607
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache44;

	// Token: 0x04012370 RID: 74608
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache45;

	// Token: 0x04012371 RID: 74609
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache46;

	// Token: 0x04012372 RID: 74610
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache47;

	// Token: 0x04012373 RID: 74611
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache48;

	// Token: 0x04012374 RID: 74612
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache49;

	// Token: 0x04012375 RID: 74613
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache4A;

	// Token: 0x04012376 RID: 74614
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache4B;

	// Token: 0x04012377 RID: 74615
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache4C;

	// Token: 0x04012378 RID: 74616
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache4D;

	// Token: 0x04012379 RID: 74617
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache4E;

	// Token: 0x0401237A RID: 74618
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache4F;

	// Token: 0x0401237B RID: 74619
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache50;

	// Token: 0x0401237C RID: 74620
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache51;

	// Token: 0x0401237D RID: 74621
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache52;

	// Token: 0x0401237E RID: 74622
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache53;

	// Token: 0x0401237F RID: 74623
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache54;

	// Token: 0x04012380 RID: 74624
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache55;

	// Token: 0x04012381 RID: 74625
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache56;

	// Token: 0x04012382 RID: 74626
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache57;

	// Token: 0x04012383 RID: 74627
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache58;

	// Token: 0x04012384 RID: 74628
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache59;

	// Token: 0x04012385 RID: 74629
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache5A;

	// Token: 0x04012386 RID: 74630
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache5B;

	// Token: 0x04012387 RID: 74631
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache5C;

	// Token: 0x04012388 RID: 74632
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache5D;

	// Token: 0x04012389 RID: 74633
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache5E;

	// Token: 0x0401238A RID: 74634
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache5F;

	// Token: 0x0401238B RID: 74635
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache60;

	// Token: 0x0401238C RID: 74636
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache61;

	// Token: 0x0401238D RID: 74637
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache62;

	// Token: 0x0401238E RID: 74638
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache63;

	// Token: 0x0401238F RID: 74639
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache64;

	// Token: 0x04012390 RID: 74640
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache65;

	// Token: 0x04012391 RID: 74641
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache66;

	// Token: 0x04012392 RID: 74642
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache67;

	// Token: 0x04012393 RID: 74643
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache68;

	// Token: 0x04012394 RID: 74644
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache69;

	// Token: 0x04012395 RID: 74645
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache6A;

	// Token: 0x04012396 RID: 74646
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache6B;

	// Token: 0x04012397 RID: 74647
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache6C;

	// Token: 0x04012398 RID: 74648
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache6D;

	// Token: 0x04012399 RID: 74649
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache6E;

	// Token: 0x0401239A RID: 74650
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache6F;

	// Token: 0x0401239B RID: 74651
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache70;

	// Token: 0x0401239C RID: 74652
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache71;

	// Token: 0x0401239D RID: 74653
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache72;

	// Token: 0x0401239E RID: 74654
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache73;

	// Token: 0x0401239F RID: 74655
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache74;

	// Token: 0x040123A0 RID: 74656
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache75;

	// Token: 0x040123A1 RID: 74657
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache76;

	// Token: 0x040123A2 RID: 74658
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache77;

	// Token: 0x040123A3 RID: 74659
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache78;

	// Token: 0x040123A4 RID: 74660
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache79;

	// Token: 0x040123A5 RID: 74661
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache7A;

	// Token: 0x040123A6 RID: 74662
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache7B;

	// Token: 0x040123A7 RID: 74663
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache7C;

	// Token: 0x040123A8 RID: 74664
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache7D;

	// Token: 0x040123A9 RID: 74665
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache7E;

	// Token: 0x040123AA RID: 74666
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache7F;

	// Token: 0x040123AB RID: 74667
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache80;

	// Token: 0x040123AC RID: 74668
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache81;

	// Token: 0x040123AD RID: 74669
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache82;

	// Token: 0x040123AE RID: 74670
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache83;

	// Token: 0x040123AF RID: 74671
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache84;

	// Token: 0x040123B0 RID: 74672
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache85;

	// Token: 0x040123B1 RID: 74673
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache86;

	// Token: 0x040123B2 RID: 74674
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache87;

	// Token: 0x040123B3 RID: 74675
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache88;

	// Token: 0x040123B4 RID: 74676
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache89;

	// Token: 0x040123B5 RID: 74677
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache8A;

	// Token: 0x040123B6 RID: 74678
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache8B;

	// Token: 0x040123B7 RID: 74679
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache8C;

	// Token: 0x040123B8 RID: 74680
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache8D;

	// Token: 0x040123B9 RID: 74681
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache8E;

	// Token: 0x040123BA RID: 74682
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache8F;

	// Token: 0x040123BB RID: 74683
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache90;

	// Token: 0x040123BC RID: 74684
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache91;

	// Token: 0x040123BD RID: 74685
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache92;

	// Token: 0x040123BE RID: 74686
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache93;

	// Token: 0x040123BF RID: 74687
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache94;

	// Token: 0x040123C0 RID: 74688
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache95;

	// Token: 0x040123C1 RID: 74689
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache96;

	// Token: 0x040123C2 RID: 74690
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache97;

	// Token: 0x040123C3 RID: 74691
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache98;

	// Token: 0x040123C4 RID: 74692
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache99;

	// Token: 0x040123C5 RID: 74693
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache9A;

	// Token: 0x040123C6 RID: 74694
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache9B;

	// Token: 0x040123C7 RID: 74695
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache9C;

	// Token: 0x040123C8 RID: 74696
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache9D;

	// Token: 0x040123C9 RID: 74697
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache9E;

	// Token: 0x040123CA RID: 74698
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache9F;

	// Token: 0x040123CB RID: 74699
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheA0;

	// Token: 0x040123CC RID: 74700
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheA1;

	// Token: 0x040123CD RID: 74701
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheA2;

	// Token: 0x040123CE RID: 74702
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheA3;

	// Token: 0x040123CF RID: 74703
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheA4;

	// Token: 0x040123D0 RID: 74704
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheA5;

	// Token: 0x040123D1 RID: 74705
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheA6;

	// Token: 0x040123D2 RID: 74706
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheA7;

	// Token: 0x040123D3 RID: 74707
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheA8;

	// Token: 0x040123D4 RID: 74708
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheA9;

	// Token: 0x040123D5 RID: 74709
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheAA;

	// Token: 0x040123D6 RID: 74710
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheAB;

	// Token: 0x040123D7 RID: 74711
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheAC;

	// Token: 0x040123D8 RID: 74712
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheAD;

	// Token: 0x040123D9 RID: 74713
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheAE;

	// Token: 0x040123DA RID: 74714
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheAF;

	// Token: 0x040123DB RID: 74715
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheB0;

	// Token: 0x040123DC RID: 74716
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheB1;

	// Token: 0x040123DD RID: 74717
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheB2;

	// Token: 0x040123DE RID: 74718
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheB3;

	// Token: 0x040123DF RID: 74719
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheB4;

	// Token: 0x040123E0 RID: 74720
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheB5;

	// Token: 0x040123E1 RID: 74721
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheB6;

	// Token: 0x040123E2 RID: 74722
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheB7;

	// Token: 0x040123E3 RID: 74723
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheB8;

	// Token: 0x040123E4 RID: 74724
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheB9;

	// Token: 0x040123E5 RID: 74725
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheBA;

	// Token: 0x040123E6 RID: 74726
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheBB;

	// Token: 0x040123E7 RID: 74727
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheBC;

	// Token: 0x040123E8 RID: 74728
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheBD;

	// Token: 0x040123E9 RID: 74729
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheBE;

	// Token: 0x040123EA RID: 74730
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheBF;

	// Token: 0x040123EB RID: 74731
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheC0;

	// Token: 0x040123EC RID: 74732
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheC1;

	// Token: 0x040123ED RID: 74733
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheC2;

	// Token: 0x040123EE RID: 74734
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheC3;

	// Token: 0x040123EF RID: 74735
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheC4;

	// Token: 0x040123F0 RID: 74736
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheC5;

	// Token: 0x040123F1 RID: 74737
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheC6;

	// Token: 0x040123F2 RID: 74738
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheC7;

	// Token: 0x040123F3 RID: 74739
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheC8;

	// Token: 0x040123F4 RID: 74740
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheC9;

	// Token: 0x040123F5 RID: 74741
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheCA;

	// Token: 0x040123F6 RID: 74742
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheCB;

	// Token: 0x040123F7 RID: 74743
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheCC;

	// Token: 0x040123F8 RID: 74744
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheCD;

	// Token: 0x040123F9 RID: 74745
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheCE;

	// Token: 0x040123FA RID: 74746
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheCF;

	// Token: 0x040123FB RID: 74747
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheD0;

	// Token: 0x040123FC RID: 74748
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheD1;

	// Token: 0x040123FD RID: 74749
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheD2;

	// Token: 0x040123FE RID: 74750
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheD3;

	// Token: 0x040123FF RID: 74751
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheD4;

	// Token: 0x04012400 RID: 74752
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheD5;

	// Token: 0x04012401 RID: 74753
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheD6;

	// Token: 0x04012402 RID: 74754
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheD7;

	// Token: 0x04012403 RID: 74755
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheD8;

	// Token: 0x04012404 RID: 74756
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheD9;

	// Token: 0x04012405 RID: 74757
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheDA;

	// Token: 0x04012406 RID: 74758
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheDB;

	// Token: 0x04012407 RID: 74759
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheDC;

	// Token: 0x04012408 RID: 74760
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheDD;

	// Token: 0x04012409 RID: 74761
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheDE;

	// Token: 0x0401240A RID: 74762
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheDF;

	// Token: 0x0401240B RID: 74763
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheE0;

	// Token: 0x0401240C RID: 74764
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheE1;

	// Token: 0x0401240D RID: 74765
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheE2;

	// Token: 0x0401240E RID: 74766
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheE3;

	// Token: 0x0401240F RID: 74767
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheE4;

	// Token: 0x04012410 RID: 74768
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheE5;

	// Token: 0x04012411 RID: 74769
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheE6;

	// Token: 0x04012412 RID: 74770
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheE7;

	// Token: 0x04012413 RID: 74771
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheE8;

	// Token: 0x04012414 RID: 74772
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheE9;

	// Token: 0x04012415 RID: 74773
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheEA;

	// Token: 0x04012416 RID: 74774
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheEB;

	// Token: 0x04012417 RID: 74775
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheEC;

	// Token: 0x04012418 RID: 74776
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheED;

	// Token: 0x04012419 RID: 74777
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheEE;

	// Token: 0x0401241A RID: 74778
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheEF;

	// Token: 0x0401241B RID: 74779
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheF0;

	// Token: 0x0401241C RID: 74780
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheF1;

	// Token: 0x0401241D RID: 74781
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheF2;

	// Token: 0x0401241E RID: 74782
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheF3;

	// Token: 0x0401241F RID: 74783
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheF4;

	// Token: 0x04012420 RID: 74784
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheF5;

	// Token: 0x04012421 RID: 74785
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheF6;

	// Token: 0x04012422 RID: 74786
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheF7;

	// Token: 0x04012423 RID: 74787
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheF8;

	// Token: 0x04012424 RID: 74788
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheF9;

	// Token: 0x04012425 RID: 74789
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheFA;

	// Token: 0x04012426 RID: 74790
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheFB;

	// Token: 0x04012427 RID: 74791
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheFC;

	// Token: 0x04012428 RID: 74792
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheFD;

	// Token: 0x04012429 RID: 74793
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheFE;

	// Token: 0x0401242A RID: 74794
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheFF;

	// Token: 0x0401242B RID: 74795
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache100;

	// Token: 0x0401242C RID: 74796
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache101;

	// Token: 0x0401242D RID: 74797
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache102;

	// Token: 0x0401242E RID: 74798
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache103;

	// Token: 0x0401242F RID: 74799
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache104;

	// Token: 0x04012430 RID: 74800
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache105;

	// Token: 0x04012431 RID: 74801
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache106;

	// Token: 0x04012432 RID: 74802
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache107;

	// Token: 0x04012433 RID: 74803
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache108;

	// Token: 0x04012434 RID: 74804
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache109;

	// Token: 0x04012435 RID: 74805
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache10A;

	// Token: 0x04012436 RID: 74806
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache10B;

	// Token: 0x04012437 RID: 74807
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache10C;

	// Token: 0x04012438 RID: 74808
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache10D;

	// Token: 0x04012439 RID: 74809
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache10E;

	// Token: 0x0401243A RID: 74810
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache10F;

	// Token: 0x0401243B RID: 74811
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache110;

	// Token: 0x0401243C RID: 74812
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache111;

	// Token: 0x0401243D RID: 74813
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache112;

	// Token: 0x0401243E RID: 74814
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache113;

	// Token: 0x0401243F RID: 74815
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache114;

	// Token: 0x04012440 RID: 74816
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache115;

	// Token: 0x04012441 RID: 74817
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache116;

	// Token: 0x04012442 RID: 74818
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache117;

	// Token: 0x04012443 RID: 74819
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache118;

	// Token: 0x04012444 RID: 74820
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache119;

	// Token: 0x04012445 RID: 74821
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache11A;

	// Token: 0x04012446 RID: 74822
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache11B;

	// Token: 0x04012447 RID: 74823
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache11C;

	// Token: 0x04012448 RID: 74824
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache11D;

	// Token: 0x04012449 RID: 74825
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache11E;

	// Token: 0x0401244A RID: 74826
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache11F;

	// Token: 0x0401244B RID: 74827
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache120;

	// Token: 0x0401244C RID: 74828
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache121;

	// Token: 0x0401244D RID: 74829
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache122;

	// Token: 0x0401244E RID: 74830
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache123;

	// Token: 0x0401244F RID: 74831
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache124;

	// Token: 0x04012450 RID: 74832
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache125;

	// Token: 0x04012451 RID: 74833
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache126;

	// Token: 0x04012452 RID: 74834
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache127;

	// Token: 0x04012453 RID: 74835
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache128;

	// Token: 0x04012454 RID: 74836
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache129;

	// Token: 0x04012455 RID: 74837
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache12A;

	// Token: 0x04012456 RID: 74838
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache12B;

	// Token: 0x04012457 RID: 74839
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache12C;

	// Token: 0x04012458 RID: 74840
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache12D;

	// Token: 0x04012459 RID: 74841
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache12E;

	// Token: 0x0401245A RID: 74842
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache12F;

	// Token: 0x0401245B RID: 74843
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache130;

	// Token: 0x0401245C RID: 74844
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache131;

	// Token: 0x0401245D RID: 74845
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache132;

	// Token: 0x0401245E RID: 74846
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache133;

	// Token: 0x0401245F RID: 74847
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache134;

	// Token: 0x04012460 RID: 74848
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache135;

	// Token: 0x04012461 RID: 74849
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache136;

	// Token: 0x04012462 RID: 74850
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache137;

	// Token: 0x04012463 RID: 74851
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache138;

	// Token: 0x04012464 RID: 74852
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache139;

	// Token: 0x04012465 RID: 74853
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache13A;

	// Token: 0x04012466 RID: 74854
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache13B;

	// Token: 0x04012467 RID: 74855
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache13C;

	// Token: 0x04012468 RID: 74856
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache13D;

	// Token: 0x04012469 RID: 74857
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache13E;

	// Token: 0x0401246A RID: 74858
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache13F;

	// Token: 0x0401246B RID: 74859
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache140;

	// Token: 0x0401246C RID: 74860
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache141;

	// Token: 0x0401246D RID: 74861
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache142;

	// Token: 0x0401246E RID: 74862
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache143;

	// Token: 0x0401246F RID: 74863
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache144;

	// Token: 0x04012470 RID: 74864
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache145;

	// Token: 0x04012471 RID: 74865
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache146;

	// Token: 0x04012472 RID: 74866
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache147;

	// Token: 0x04012473 RID: 74867
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache148;

	// Token: 0x04012474 RID: 74868
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache149;

	// Token: 0x04012475 RID: 74869
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache14A;

	// Token: 0x04012476 RID: 74870
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache14B;

	// Token: 0x04012477 RID: 74871
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache14C;

	// Token: 0x04012478 RID: 74872
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache14D;

	// Token: 0x04012479 RID: 74873
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache14E;

	// Token: 0x0401247A RID: 74874
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache14F;

	// Token: 0x0401247B RID: 74875
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache150;

	// Token: 0x0401247C RID: 74876
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache151;

	// Token: 0x0401247D RID: 74877
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache152;

	// Token: 0x0401247E RID: 74878
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache153;

	// Token: 0x0401247F RID: 74879
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache154;

	// Token: 0x04012480 RID: 74880
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache155;

	// Token: 0x04012481 RID: 74881
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache156;

	// Token: 0x04012482 RID: 74882
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache157;

	// Token: 0x04012483 RID: 74883
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache158;

	// Token: 0x04012484 RID: 74884
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache159;

	// Token: 0x04012485 RID: 74885
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache15A;

	// Token: 0x04012486 RID: 74886
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache15B;

	// Token: 0x04012487 RID: 74887
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache15C;

	// Token: 0x04012488 RID: 74888
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache15D;

	// Token: 0x04012489 RID: 74889
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache15E;

	// Token: 0x0401248A RID: 74890
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache15F;

	// Token: 0x0401248B RID: 74891
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache160;

	// Token: 0x0401248C RID: 74892
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache161;

	// Token: 0x0401248D RID: 74893
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache162;

	// Token: 0x0401248E RID: 74894
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache163;

	// Token: 0x0401248F RID: 74895
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache164;

	// Token: 0x04012490 RID: 74896
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache165;

	// Token: 0x04012491 RID: 74897
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache166;

	// Token: 0x04012492 RID: 74898
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache167;

	// Token: 0x04012493 RID: 74899
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache168;

	// Token: 0x04012494 RID: 74900
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache169;

	// Token: 0x04012495 RID: 74901
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache16A;

	// Token: 0x04012496 RID: 74902
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache16B;

	// Token: 0x04012497 RID: 74903
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache16C;

	// Token: 0x04012498 RID: 74904
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache16D;

	// Token: 0x04012499 RID: 74905
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache16E;

	// Token: 0x0401249A RID: 74906
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache16F;

	// Token: 0x0401249B RID: 74907
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache170;

	// Token: 0x0401249C RID: 74908
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache171;

	// Token: 0x0401249D RID: 74909
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache172;

	// Token: 0x0401249E RID: 74910
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache173;

	// Token: 0x0401249F RID: 74911
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache174;

	// Token: 0x040124A0 RID: 74912
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache175;

	// Token: 0x040124A1 RID: 74913
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache176;

	// Token: 0x040124A2 RID: 74914
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache177;

	// Token: 0x040124A3 RID: 74915
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache178;

	// Token: 0x040124A4 RID: 74916
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache179;

	// Token: 0x040124A5 RID: 74917
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache17A;

	// Token: 0x040124A6 RID: 74918
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache17B;

	// Token: 0x040124A7 RID: 74919
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache17C;

	// Token: 0x040124A8 RID: 74920
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache17D;

	// Token: 0x040124A9 RID: 74921
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache17E;

	// Token: 0x040124AA RID: 74922
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache17F;

	// Token: 0x040124AB RID: 74923
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache180;

	// Token: 0x040124AC RID: 74924
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache181;

	// Token: 0x040124AD RID: 74925
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache182;

	// Token: 0x040124AE RID: 74926
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache183;

	// Token: 0x040124AF RID: 74927
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache184;

	// Token: 0x040124B0 RID: 74928
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache185;

	// Token: 0x040124B1 RID: 74929
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache186;

	// Token: 0x040124B2 RID: 74930
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache187;

	// Token: 0x040124B3 RID: 74931
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache188;

	// Token: 0x040124B4 RID: 74932
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache189;

	// Token: 0x040124B5 RID: 74933
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache18A;

	// Token: 0x040124B6 RID: 74934
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache18B;

	// Token: 0x040124B7 RID: 74935
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache18C;

	// Token: 0x040124B8 RID: 74936
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache18D;

	// Token: 0x040124B9 RID: 74937
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache18E;

	// Token: 0x040124BA RID: 74938
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache18F;

	// Token: 0x040124BB RID: 74939
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache190;

	// Token: 0x040124BC RID: 74940
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache191;

	// Token: 0x040124BD RID: 74941
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache192;

	// Token: 0x040124BE RID: 74942
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache193;

	// Token: 0x040124BF RID: 74943
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache194;

	// Token: 0x040124C0 RID: 74944
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache195;

	// Token: 0x040124C1 RID: 74945
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache196;

	// Token: 0x040124C2 RID: 74946
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache197;

	// Token: 0x040124C3 RID: 74947
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache198;

	// Token: 0x040124C4 RID: 74948
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache199;
}
