using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using BlackJack.BJFramework.Runtime.TaskNs;
using BlackJack.BJFramework.Runtime.UI;
using BlackJack.ConfigData;
using BlackJack.ProjectL.Battle;
using BlackJack.ProjectL.Common;
using BlackJack.ProjectL.PlayerContext;
using BlackJack.ProjectL.Protocol;
using BlackJack.ProjectL.Scene;
using BlackJack.ProjectL.UI;
using BlackJack.ProjectLBasic;
using SLua;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.Scripting;

// Token: 0x020013C9 RID: 5065
[Preserve]
public class Lua_BlackJack_ProjectL_UI_BattleUITask : LuaObject
{
	// Token: 0x0601C275 RID: 115317 RVA: 0x008AD3AC File Offset: 0x008AB5AC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int constructor(IntPtr l)
	{
		int result;
		try
		{
			string name;
			LuaObject.checkType(l, 2, out name);
			BattleUITask o = new BattleUITask(name);
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

	// Token: 0x0601C276 RID: 115318 RVA: 0x008AD400 File Offset: 0x008AB600
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int OnBattleMapClick(IntPtr l)
	{
		int result;
		try
		{
			BattleUITask battleUITask = (BattleUITask)LuaObject.checkSelf(l);
			GridPosition p;
			LuaObject.checkValueType<GridPosition>(l, 2, out p);
			bool isDoubleClick;
			LuaObject.checkType(l, 3, out isDoubleClick);
			battleUITask.OnBattleMapClick(p, isDoubleClick);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601C277 RID: 115319 RVA: 0x008AD464 File Offset: 0x008AB664
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int OnStartBattle(IntPtr l)
	{
		int result;
		try
		{
			BattleUITask battleUITask = (BattleUITask)LuaObject.checkSelf(l);
			battleUITask.OnStartBattle();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601C278 RID: 115320 RVA: 0x008AD4B0 File Offset: 0x008AB6B0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int OnStopBattle(IntPtr l)
	{
		int result;
		try
		{
			BattleUITask battleUITask = (BattleUITask)LuaObject.checkSelf(l);
			bool win;
			LuaObject.checkType(l, 2, out win);
			bool skipPerform;
			LuaObject.checkType(l, 3, out skipPerform);
			battleUITask.OnStopBattle(win, skipPerform);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601C279 RID: 115321 RVA: 0x008AD514 File Offset: 0x008AB714
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int OnShowBattleWinCondition(IntPtr l)
	{
		int result;
		try
		{
			BattleUITask battleUITask = (BattleUITask)LuaObject.checkSelf(l);
			ConfigDataBattleWinConditionInfo winConditionInfo;
			LuaObject.checkType<ConfigDataBattleWinConditionInfo>(l, 2, out winConditionInfo);
			GridPosition targetPos;
			LuaObject.checkValueType<GridPosition>(l, 3, out targetPos);
			battleUITask.OnShowBattleWinCondition(winConditionInfo, targetPos);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601C27A RID: 115322 RVA: 0x008AD578 File Offset: 0x008AB778
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int OnHideBattleWinCondition(IntPtr l)
	{
		int result;
		try
		{
			BattleUITask battleUITask = (BattleUITask)LuaObject.checkSelf(l);
			ConfigDataBattleWinConditionInfo winConditionInfo;
			LuaObject.checkType<ConfigDataBattleWinConditionInfo>(l, 2, out winConditionInfo);
			GridPosition targetPos;
			LuaObject.checkValueType<GridPosition>(l, 3, out targetPos);
			battleUITask.OnHideBattleWinCondition(winConditionInfo, targetPos);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601C27B RID: 115323 RVA: 0x008AD5DC File Offset: 0x008AB7DC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int OnShowBattleLoseCondition(IntPtr l)
	{
		int result;
		try
		{
			BattleUITask battleUITask = (BattleUITask)LuaObject.checkSelf(l);
			ConfigDataBattleLoseConditionInfo loseConditionInfo;
			LuaObject.checkType<ConfigDataBattleLoseConditionInfo>(l, 2, out loseConditionInfo);
			GridPosition targetPos;
			LuaObject.checkValueType<GridPosition>(l, 3, out targetPos);
			battleUITask.OnShowBattleLoseCondition(loseConditionInfo, targetPos);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601C27C RID: 115324 RVA: 0x008AD640 File Offset: 0x008AB840
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int OnHideBattleLoseCondition(IntPtr l)
	{
		int result;
		try
		{
			BattleUITask battleUITask = (BattleUITask)LuaObject.checkSelf(l);
			ConfigDataBattleLoseConditionInfo loseConditionInfo;
			LuaObject.checkType<ConfigDataBattleLoseConditionInfo>(l, 2, out loseConditionInfo);
			GridPosition targetPos;
			LuaObject.checkValueType<GridPosition>(l, 3, out targetPos);
			battleUITask.OnHideBattleLoseCondition(loseConditionInfo, targetPos);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601C27D RID: 115325 RVA: 0x008AD6A4 File Offset: 0x008AB8A4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int OnNextTurn(IntPtr l)
	{
		int result;
		try
		{
			BattleUITask battleUITask = (BattleUITask)LuaObject.checkSelf(l);
			int turn;
			LuaObject.checkType(l, 2, out turn);
			battleUITask.OnNextTurn(turn);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601C27E RID: 115326 RVA: 0x008AD6FC File Offset: 0x008AB8FC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int OnNextTurnAnimationEnd(IntPtr l)
	{
		int result;
		try
		{
			BattleUITask battleUITask = (BattleUITask)LuaObject.checkSelf(l);
			int turn;
			LuaObject.checkType(l, 2, out turn);
			battleUITask.OnNextTurnAnimationEnd(turn);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601C27F RID: 115327 RVA: 0x008AD754 File Offset: 0x008AB954
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int OnNextTeam(IntPtr l)
	{
		int result;
		try
		{
			BattleUITask battleUITask = (BattleUITask)LuaObject.checkSelf(l);
			int team;
			LuaObject.checkType(l, 2, out team);
			battleUITask.OnNextTeam(team);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601C280 RID: 115328 RVA: 0x008AD7AC File Offset: 0x008AB9AC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int OnNextPlayer(IntPtr l)
	{
		int result;
		try
		{
			BattleUITask battleUITask = (BattleUITask)LuaObject.checkSelf(l);
			int playerIndex;
			LuaObject.checkType(l, 2, out playerIndex);
			battleUITask.OnNextPlayer(playerIndex);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601C281 RID: 115329 RVA: 0x008AD804 File Offset: 0x008ABA04
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int OnNextActor(IntPtr l)
	{
		int result;
		try
		{
			BattleUITask battleUITask = (BattleUITask)LuaObject.checkSelf(l);
			BattleActor actor;
			LuaObject.checkType<BattleActor>(l, 2, out actor);
			battleUITask.OnNextActor(actor);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601C282 RID: 115330 RVA: 0x008AD85C File Offset: 0x008ABA5C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int OnClientActorActive(IntPtr l)
	{
		int result;
		try
		{
			BattleUITask battleUITask = (BattleUITask)LuaObject.checkSelf(l);
			ClientBattleActor a;
			LuaObject.checkType<ClientBattleActor>(l, 2, out a);
			bool newStep;
			LuaObject.checkType(l, 3, out newStep);
			int step;
			LuaObject.checkType(l, 4, out step);
			battleUITask.OnClientActorActive(a, newStep, step);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601C283 RID: 115331 RVA: 0x008AD8D0 File Offset: 0x008ABAD0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int OnClientActorMove(IntPtr l)
	{
		int result;
		try
		{
			BattleUITask battleUITask = (BattleUITask)LuaObject.checkSelf(l);
			ClientBattleActor a;
			LuaObject.checkType<ClientBattleActor>(l, 2, out a);
			battleUITask.OnClientActorMove(a);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601C284 RID: 115332 RVA: 0x008AD928 File Offset: 0x008ABB28
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int OnClientActorTryMove(IntPtr l)
	{
		int result;
		try
		{
			BattleUITask battleUITask = (BattleUITask)LuaObject.checkSelf(l);
			ClientBattleActor a;
			LuaObject.checkType<ClientBattleActor>(l, 2, out a);
			battleUITask.OnClientActorTryMove(a);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601C285 RID: 115333 RVA: 0x008AD980 File Offset: 0x008ABB80
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int OnClientActorNoAct(IntPtr l)
	{
		int result;
		try
		{
			BattleUITask battleUITask = (BattleUITask)LuaObject.checkSelf(l);
			ClientBattleActor a;
			LuaObject.checkType<ClientBattleActor>(l, 2, out a);
			battleUITask.OnClientActorNoAct(a);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601C286 RID: 115334 RVA: 0x008AD9D8 File Offset: 0x008ABBD8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int OnClientActorTarget(IntPtr l)
	{
		int result;
		try
		{
			BattleUITask battleUITask = (BattleUITask)LuaObject.checkSelf(l);
			ClientBattleActor a;
			LuaObject.checkType<ClientBattleActor>(l, 2, out a);
			ConfigDataSkillInfo skillInfo;
			LuaObject.checkType<ConfigDataSkillInfo>(l, 3, out skillInfo);
			GridPosition pos;
			LuaObject.checkValueType<GridPosition>(l, 4, out pos);
			int armyRelationValue;
			LuaObject.checkType(l, 5, out armyRelationValue);
			battleUITask.OnClientActorTarget(a, skillInfo, pos, armyRelationValue);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601C287 RID: 115335 RVA: 0x008ADA58 File Offset: 0x008ABC58
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int OnClientActorSkill(IntPtr l)
	{
		int result;
		try
		{
			BattleUITask battleUITask = (BattleUITask)LuaObject.checkSelf(l);
			ClientBattleActor a;
			LuaObject.checkType<ClientBattleActor>(l, 2, out a);
			ConfigDataSkillInfo skillInfo;
			LuaObject.checkType<ConfigDataSkillInfo>(l, 3, out skillInfo);
			battleUITask.OnClientActorSkill(a, skillInfo);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601C288 RID: 115336 RVA: 0x008ADABC File Offset: 0x008ABCBC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int OnClientActorSkillEnd(IntPtr l)
	{
		int result;
		try
		{
			BattleUITask battleUITask = (BattleUITask)LuaObject.checkSelf(l);
			ClientBattleActor a;
			LuaObject.checkType<ClientBattleActor>(l, 2, out a);
			ConfigDataSkillInfo skillInfo;
			LuaObject.checkType<ConfigDataSkillInfo>(l, 3, out skillInfo);
			battleUITask.OnClientActorSkillEnd(a, skillInfo);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601C289 RID: 115337 RVA: 0x008ADB20 File Offset: 0x008ABD20
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int OnClientActorSkillHit(IntPtr l)
	{
		int result;
		try
		{
			BattleUITask battleUITask = (BattleUITask)LuaObject.checkSelf(l);
			ClientBattleActor a;
			LuaObject.checkType<ClientBattleActor>(l, 2, out a);
			ConfigDataSkillInfo skillInfo;
			LuaObject.checkType<ConfigDataSkillInfo>(l, 3, out skillInfo);
			int heroHpModify;
			LuaObject.checkType(l, 4, out heroHpModify);
			int soldierHpModify;
			LuaObject.checkType(l, 5, out soldierHpModify);
			DamageNumberType damageNumberType;
			LuaObject.checkEnum<DamageNumberType>(l, 6, out damageNumberType);
			battleUITask.OnClientActorSkillHit(a, skillInfo, heroHpModify, soldierHpModify, damageNumberType);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601C28A RID: 115338 RVA: 0x008ADBAC File Offset: 0x008ABDAC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int OnClientActorBuffHit(IntPtr l)
	{
		int result;
		try
		{
			BattleUITask battleUITask = (BattleUITask)LuaObject.checkSelf(l);
			ClientBattleActor a;
			LuaObject.checkType<ClientBattleActor>(l, 2, out a);
			ConfigDataBuffInfo buffInfo;
			LuaObject.checkType<ConfigDataBuffInfo>(l, 3, out buffInfo);
			int heroHpModify;
			LuaObject.checkType(l, 4, out heroHpModify);
			int soldierHpModify;
			LuaObject.checkType(l, 5, out soldierHpModify);
			DamageNumberType damageNumberType;
			LuaObject.checkEnum<DamageNumberType>(l, 6, out damageNumberType);
			battleUITask.OnClientActorBuffHit(a, buffInfo, heroHpModify, soldierHpModify, damageNumberType);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601C28B RID: 115339 RVA: 0x008ADC38 File Offset: 0x008ABE38
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int OnClientActorTerrainHit(IntPtr l)
	{
		int result;
		try
		{
			BattleUITask battleUITask = (BattleUITask)LuaObject.checkSelf(l);
			ClientBattleActor a;
			LuaObject.checkType<ClientBattleActor>(l, 2, out a);
			ConfigDataTerrainInfo terrainInfo;
			LuaObject.checkType<ConfigDataTerrainInfo>(l, 3, out terrainInfo);
			int heroHpModify;
			LuaObject.checkType(l, 4, out heroHpModify);
			int soldierHpModify;
			LuaObject.checkType(l, 5, out soldierHpModify);
			DamageNumberType damageNumberType;
			LuaObject.checkEnum<DamageNumberType>(l, 6, out damageNumberType);
			battleUITask.OnClientActorTerrainHit(a, terrainInfo, heroHpModify, soldierHpModify, damageNumberType);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601C28C RID: 115340 RVA: 0x008ADCC4 File Offset: 0x008ABEC4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int OnClientActorImmune(IntPtr l)
	{
		int result;
		try
		{
			BattleUITask battleUITask = (BattleUITask)LuaObject.checkSelf(l);
			ClientBattleActor a;
			LuaObject.checkType<ClientBattleActor>(l, 2, out a);
			battleUITask.OnClientActorImmune(a);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601C28D RID: 115341 RVA: 0x008ADD1C File Offset: 0x008ABF1C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int OnClientActorPassiveSkill(IntPtr l)
	{
		int result;
		try
		{
			BattleUITask battleUITask = (BattleUITask)LuaObject.checkSelf(l);
			ClientBattleActor a;
			LuaObject.checkType<ClientBattleActor>(l, 2, out a);
			BuffState sourceBuffState;
			LuaObject.checkType<BuffState>(l, 3, out sourceBuffState);
			battleUITask.OnClientActorPassiveSkill(a, sourceBuffState);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601C28E RID: 115342 RVA: 0x008ADD80 File Offset: 0x008ABF80
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int OnClientActorGuard(IntPtr l)
	{
		int result;
		try
		{
			BattleUITask battleUITask = (BattleUITask)LuaObject.checkSelf(l);
			ClientBattleActor a;
			LuaObject.checkType<ClientBattleActor>(l, 2, out a);
			ClientBattleActor target;
			LuaObject.checkType<ClientBattleActor>(l, 3, out target);
			battleUITask.OnClientActorGuard(a, target);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601C28F RID: 115343 RVA: 0x008ADDE4 File Offset: 0x008ABFE4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int OnClientActorDie(IntPtr l)
	{
		int result;
		try
		{
			BattleUITask battleUITask = (BattleUITask)LuaObject.checkSelf(l);
			ClientBattleActor a;
			LuaObject.checkType<ClientBattleActor>(l, 2, out a);
			battleUITask.OnClientActorDie(a);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601C290 RID: 115344 RVA: 0x008ADE3C File Offset: 0x008AC03C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int OnClientActorAppear(IntPtr l)
	{
		int result;
		try
		{
			BattleUITask battleUITask = (BattleUITask)LuaObject.checkSelf(l);
			ClientBattleActor a;
			LuaObject.checkType<ClientBattleActor>(l, 2, out a);
			battleUITask.OnClientActorAppear(a);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601C291 RID: 115345 RVA: 0x008ADE94 File Offset: 0x008AC094
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int OnCancelCombat(IntPtr l)
	{
		int result;
		try
		{
			BattleUITask battleUITask = (BattleUITask)LuaObject.checkSelf(l);
			battleUITask.OnCancelCombat();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601C292 RID: 115346 RVA: 0x008ADEE0 File Offset: 0x008AC0E0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int OnPreStartCombat(IntPtr l)
	{
		int result;
		try
		{
			BattleUITask battleUITask = (BattleUITask)LuaObject.checkSelf(l);
			ClientBattleActor a;
			LuaObject.checkType<ClientBattleActor>(l, 2, out a);
			ClientBattleActor b;
			LuaObject.checkType<ClientBattleActor>(l, 3, out b);
			battleUITask.OnPreStartCombat(a, b);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601C293 RID: 115347 RVA: 0x008ADF44 File Offset: 0x008AC144
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int OnStartCombat(IntPtr l)
	{
		int result;
		try
		{
			BattleUITask battleUITask = (BattleUITask)LuaObject.checkSelf(l);
			ClientBattleActor a;
			LuaObject.checkType<ClientBattleActor>(l, 2, out a);
			ClientBattleActor b;
			LuaObject.checkType<ClientBattleActor>(l, 3, out b);
			bool splitScreen;
			LuaObject.checkType(l, 4, out splitScreen);
			battleUITask.OnStartCombat(a, b, splitScreen);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601C294 RID: 115348 RVA: 0x008ADFB8 File Offset: 0x008AC1B8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int OnPreStopCombat(IntPtr l)
	{
		int result;
		try
		{
			BattleUITask battleUITask = (BattleUITask)LuaObject.checkSelf(l);
			battleUITask.OnPreStopCombat();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601C295 RID: 115349 RVA: 0x008AE004 File Offset: 0x008AC204
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int OnStopCombat(IntPtr l)
	{
		int result;
		try
		{
			BattleUITask battleUITask = (BattleUITask)LuaObject.checkSelf(l);
			battleUITask.OnStopCombat();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601C296 RID: 115350 RVA: 0x008AE050 File Offset: 0x008AC250
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int OnPrepareFastCombat(IntPtr l)
	{
		int result;
		try
		{
			BattleUITask battleUITask = (BattleUITask)LuaObject.checkSelf(l);
			ClientBattleActor a;
			LuaObject.checkType<ClientBattleActor>(l, 2, out a);
			ClientBattleActor b;
			LuaObject.checkType<ClientBattleActor>(l, 3, out b);
			ConfigDataSkillInfo attackerSkillInfo;
			LuaObject.checkType<ConfigDataSkillInfo>(l, 4, out attackerSkillInfo);
			battleUITask.OnPrepareFastCombat(a, b, attackerSkillInfo);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601C297 RID: 115351 RVA: 0x008AE0C4 File Offset: 0x008AC2C4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int OnStartFastCombat(IntPtr l)
	{
		int result;
		try
		{
			BattleUITask battleUITask = (BattleUITask)LuaObject.checkSelf(l);
			FastCombatActorInfo a;
			LuaObject.checkType<FastCombatActorInfo>(l, 2, out a);
			FastCombatActorInfo b;
			LuaObject.checkType<FastCombatActorInfo>(l, 3, out b);
			battleUITask.OnStartFastCombat(a, b);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601C298 RID: 115352 RVA: 0x008AE128 File Offset: 0x008AC328
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int OnCombatActorHit(IntPtr l)
	{
		int result;
		try
		{
			BattleUITask battleUITask = (BattleUITask)LuaObject.checkSelf(l);
			CombatActor a;
			LuaObject.checkType<CombatActor>(l, 2, out a);
			CombatActor attacker;
			LuaObject.checkType<CombatActor>(l, 3, out attacker);
			ConfigDataSkillInfo skillInfo;
			LuaObject.checkType<ConfigDataSkillInfo>(l, 4, out skillInfo);
			int hpModify;
			LuaObject.checkType(l, 5, out hpModify);
			int totalDamage;
			LuaObject.checkType(l, 6, out totalDamage);
			DamageNumberType damageNumberType;
			LuaObject.checkEnum<DamageNumberType>(l, 7, out damageNumberType);
			battleUITask.OnCombatActorHit(a, attacker, skillInfo, hpModify, totalDamage, damageNumberType);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601C299 RID: 115353 RVA: 0x008AE1C0 File Offset: 0x008AC3C0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int OnStartSkillCutscene(IntPtr l)
	{
		int result;
		try
		{
			BattleUITask battleUITask = (BattleUITask)LuaObject.checkSelf(l);
			ConfigDataSkillInfo skillInfo;
			LuaObject.checkType<ConfigDataSkillInfo>(l, 2, out skillInfo);
			ConfigDataCutsceneInfo cutsceneInfo;
			LuaObject.checkType<ConfigDataCutsceneInfo>(l, 3, out cutsceneInfo);
			int team;
			LuaObject.checkType(l, 4, out team);
			battleUITask.OnStartSkillCutscene(skillInfo, cutsceneInfo, team);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601C29A RID: 115354 RVA: 0x008AE234 File Offset: 0x008AC434
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int OnStartPassiveSkillCutscene(IntPtr l)
	{
		int result;
		try
		{
			BattleUITask battleUITask = (BattleUITask)LuaObject.checkSelf(l);
			BuffState sourceBuffState;
			LuaObject.checkType<BuffState>(l, 2, out sourceBuffState);
			int team;
			LuaObject.checkType(l, 3, out team);
			battleUITask.OnStartPassiveSkillCutscene(sourceBuffState, team);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601C29B RID: 115355 RVA: 0x008AE298 File Offset: 0x008AC498
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int OnStopSkillCutscene(IntPtr l)
	{
		int result;
		try
		{
			BattleUITask battleUITask = (BattleUITask)LuaObject.checkSelf(l);
			battleUITask.OnStopSkillCutscene();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601C29C RID: 115356 RVA: 0x008AE2E4 File Offset: 0x008AC4E4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int OnStartBattleDialog(IntPtr l)
	{
		int result;
		try
		{
			BattleUITask battleUITask = (BattleUITask)LuaObject.checkSelf(l);
			ConfigDataBattleDialogInfo dialogInfo;
			LuaObject.checkType<ConfigDataBattleDialogInfo>(l, 2, out dialogInfo);
			battleUITask.OnStartBattleDialog(dialogInfo);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601C29D RID: 115357 RVA: 0x008AE33C File Offset: 0x008AC53C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int OnStartBattleTreasureDialog(IntPtr l)
	{
		int result;
		try
		{
			BattleUITask battleUITask = (BattleUITask)LuaObject.checkSelf(l);
			ConfigDataBattleTreasureInfo treasureInfo;
			LuaObject.checkType<ConfigDataBattleTreasureInfo>(l, 2, out treasureInfo);
			battleUITask.OnStartBattleTreasureDialog(treasureInfo);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601C29E RID: 115358 RVA: 0x008AE394 File Offset: 0x008AC594
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int OnShowBattleTreasureReward(IntPtr l)
	{
		int result;
		try
		{
			BattleUITask battleUITask = (BattleUITask)LuaObject.checkSelf(l);
			ConfigDataBattleTreasureInfo treasureInfo;
			LuaObject.checkType<ConfigDataBattleTreasureInfo>(l, 2, out treasureInfo);
			battleUITask.OnShowBattleTreasureReward(treasureInfo);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601C29F RID: 115359 RVA: 0x008AE3EC File Offset: 0x008AC5EC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int OnStartBattlePerform(IntPtr l)
	{
		int result;
		try
		{
			BattleUITask battleUITask = (BattleUITask)LuaObject.checkSelf(l);
			battleUITask.OnStartBattlePerform();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601C2A0 RID: 115360 RVA: 0x008AE438 File Offset: 0x008AC638
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int OnStopBattlePerform(IntPtr l)
	{
		int result;
		try
		{
			BattleUITask battleUITask = (BattleUITask)LuaObject.checkSelf(l);
			battleUITask.OnStopBattlePerform();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601C2A1 RID: 115361 RVA: 0x008AE484 File Offset: 0x008AC684
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int OnScreenEffect(IntPtr l)
	{
		int result;
		try
		{
			BattleUITask battleUITask = (BattleUITask)LuaObject.checkSelf(l);
			string name;
			LuaObject.checkType(l, 2, out name);
			battleUITask.OnScreenEffect(name);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601C2A2 RID: 115362 RVA: 0x008AE4DC File Offset: 0x008AC6DC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int PrepareBattleUI(IntPtr l)
	{
		int result;
		try
		{
			BattleUITask battleUITask = (BattleUITask)LuaObject.checkSelf(l);
			battleUITask.PrepareBattleUI();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601C2A3 RID: 115363 RVA: 0x008AE528 File Offset: 0x008AC728
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int BattlePrepareUIController_OnPointerClick(IntPtr l)
	{
		int result;
		try
		{
			BattleUITask battleUITask = (BattleUITask)LuaObject.checkSelf(l);
			PointerEventData.InputButton button;
			LuaObject.checkEnum<PointerEventData.InputButton>(l, 2, out button);
			Vector2 position;
			LuaObject.checkType(l, 3, out position);
			battleUITask.BattlePrepareUIController_OnPointerClick(button, position);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601C2A4 RID: 115364 RVA: 0x008AE58C File Offset: 0x008AC78C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int IsNeedLoadDynamicRes(IntPtr l)
	{
		int result;
		try
		{
			BattleUITask battleUITask = (BattleUITask)LuaObject.checkSelf(l);
			bool b = battleUITask.m_luaExportHelper.IsNeedLoadDynamicRes();
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

	// Token: 0x0601C2A5 RID: 115365 RVA: 0x008AE5E8 File Offset: 0x008AC7E8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int InitLayerStateOnLoadAllResCompleted(IntPtr l)
	{
		int result;
		try
		{
			BattleUITask battleUITask = (BattleUITask)LuaObject.checkSelf(l);
			battleUITask.m_luaExportHelper.InitLayerStateOnLoadAllResCompleted();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601C2A6 RID: 115366 RVA: 0x008AE63C File Offset: 0x008AC83C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int InitAllUIControllers(IntPtr l)
	{
		int result;
		try
		{
			BattleUITask battleUITask = (BattleUITask)LuaObject.checkSelf(l);
			battleUITask.m_luaExportHelper.InitAllUIControllers();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601C2A7 RID: 115367 RVA: 0x008AE690 File Offset: 0x008AC890
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int ClearAllContextAndRes(IntPtr l)
	{
		int result;
		try
		{
			BattleUITask battleUITask = (BattleUITask)LuaObject.checkSelf(l);
			battleUITask.m_luaExportHelper.ClearAllContextAndRes();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601C2A8 RID: 115368 RVA: 0x008AE6E4 File Offset: 0x008AC8E4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int OnStart(IntPtr l)
	{
		int result;
		try
		{
			BattleUITask battleUITask = (BattleUITask)LuaObject.checkSelf(l);
			UIIntent intent;
			LuaObject.checkType<UIIntent>(l, 2, out intent);
			bool b = battleUITask.m_luaExportHelper.OnStart(intent);
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

	// Token: 0x0601C2A9 RID: 115369 RVA: 0x008AE74C File Offset: 0x008AC94C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int OnStop(IntPtr l)
	{
		int result;
		try
		{
			BattleUITask battleUITask = (BattleUITask)LuaObject.checkSelf(l);
			battleUITask.m_luaExportHelper.OnStop();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601C2AA RID: 115370 RVA: 0x008AE7A0 File Offset: 0x008AC9A0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int HideAllView(IntPtr l)
	{
		int result;
		try
		{
			BattleUITask battleUITask = (BattleUITask)LuaObject.checkSelf(l);
			battleUITask.m_luaExportHelper.HideAllView();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601C2AB RID: 115371 RVA: 0x008AE7F4 File Offset: 0x008AC9F4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int UpdateView(IntPtr l)
	{
		int result;
		try
		{
			BattleUITask battleUITask = (BattleUITask)LuaObject.checkSelf(l);
			battleUITask.m_luaExportHelper.UpdateView();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601C2AC RID: 115372 RVA: 0x008AE848 File Offset: 0x008ACA48
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int PostUpdateView(IntPtr l)
	{
		int result;
		try
		{
			BattleUITask battleUITask = (BattleUITask)LuaObject.checkSelf(l);
			battleUITask.m_luaExportHelper.PostUpdateView();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601C2AD RID: 115373 RVA: 0x008AE89C File Offset: 0x008ACA9C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int OnTick(IntPtr l)
	{
		int result;
		try
		{
			BattleUITask battleUITask = (BattleUITask)LuaObject.checkSelf(l);
			battleUITask.m_luaExportHelper.OnTick();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601C2AE RID: 115374 RVA: 0x008AE8F0 File Offset: 0x008ACAF0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int IsLoading(IntPtr l)
	{
		int result;
		try
		{
			BattleUITask battleUITask = (BattleUITask)LuaObject.checkSelf(l);
			bool b = battleUITask.m_luaExportHelper.IsLoading();
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

	// Token: 0x0601C2AF RID: 115375 RVA: 0x008AE94C File Offset: 0x008ACB4C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int CreateClientBattle(IntPtr l)
	{
		int result;
		try
		{
			BattleUITask battleUITask = (BattleUITask)LuaObject.checkSelf(l);
			battleUITask.m_luaExportHelper.CreateClientBattle();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601C2B0 RID: 115376 RVA: 0x008AE9A0 File Offset: 0x008ACBA0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int DestroyClientBattle(IntPtr l)
	{
		int result;
		try
		{
			BattleUITask battleUITask = (BattleUITask)LuaObject.checkSelf(l);
			battleUITask.m_luaExportHelper.DestroyClientBattle();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601C2B1 RID: 115377 RVA: 0x008AE9F4 File Offset: 0x008ACBF4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int PrepareClientBattle(IntPtr l)
	{
		int result;
		try
		{
			BattleUITask battleUITask = (BattleUITask)LuaObject.checkSelf(l);
			bool prepareBattleUI;
			LuaObject.checkType(l, 2, out prepareBattleUI);
			battleUITask.m_luaExportHelper.PrepareClientBattle(prepareBattleUI);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601C2B2 RID: 115378 RVA: 0x008AEA50 File Offset: 0x008ACC50
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int StartClientBattle(IntPtr l)
	{
		int result;
		try
		{
			BattleUITask battleUITask = (BattleUITask)LuaObject.checkSelf(l);
			battleUITask.m_luaExportHelper.StartClientBattle();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601C2B3 RID: 115379 RVA: 0x008AEAA4 File Offset: 0x008ACCA4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int StopBattle(IntPtr l)
	{
		int result;
		try
		{
			BattleUITask battleUITask = (BattleUITask)LuaObject.checkSelf(l);
			bool win;
			LuaObject.checkType(l, 2, out win);
			bool skipPerform;
			LuaObject.checkType(l, 3, out skipPerform);
			battleUITask.m_luaExportHelper.StopBattle(win, skipPerform);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601C2B4 RID: 115380 RVA: 0x008AEB10 File Offset: 0x008ACD10
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int SendBattleRoomInitLog(IntPtr l)
	{
		int result;
		try
		{
			BattleUITask battleUITask = (BattleUITask)LuaObject.checkSelf(l);
			battleUITask.m_luaExportHelper.SendBattleRoomInitLog();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601C2B5 RID: 115381 RVA: 0x008AEB64 File Offset: 0x008ACD64
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int GetBattleTeamSetup(IntPtr l)
	{
		int result;
		try
		{
			BattleUITask battleUITask = (BattleUITask)LuaObject.checkSelf(l);
			int team;
			LuaObject.checkType(l, 2, out team);
			BattleTeamSetup battleTeamSetup = battleUITask.m_luaExportHelper.GetBattleTeamSetup(team);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, battleTeamSetup);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601C2B6 RID: 115382 RVA: 0x008AEBCC File Offset: 0x008ACDCC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int GetTeamPositions(IntPtr l)
	{
		int result;
		try
		{
			BattleUITask battleUITask = (BattleUITask)LuaObject.checkSelf(l);
			int team;
			LuaObject.checkType(l, 2, out team);
			List<GridPosition> teamPositions = battleUITask.m_luaExportHelper.GetTeamPositions(team);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, teamPositions);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601C2B7 RID: 115383 RVA: 0x008AEC34 File Offset: 0x008ACE34
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int SetCombatHp(IntPtr l)
	{
		int result;
		try
		{
			BattleUITask battleUITask = (BattleUITask)LuaObject.checkSelf(l);
			int combatHp;
			LuaObject.checkType(l, 2, out combatHp);
			battleUITask.m_luaExportHelper.SetCombatHp(combatHp);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601C2B8 RID: 115384 RVA: 0x008AEC90 File Offset: 0x008ACE90
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int ExitBattleReturnToWorld(IntPtr l)
	{
		int result;
		try
		{
			BattleUITask battleUITask = (BattleUITask)LuaObject.checkSelf(l);
			battleUITask.m_luaExportHelper.ExitBattleReturnToWorld();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601C2B9 RID: 115385 RVA: 0x008AECE4 File Offset: 0x008ACEE4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int ShowErrorMessageAndExitBattle(IntPtr l)
	{
		int result;
		try
		{
			int total = LuaDLL.lua_gettop(l);
			if (LuaObject.matchType(l, total, 2, typeof(int)))
			{
				BattleUITask battleUITask = (BattleUITask)LuaObject.checkSelf(l);
				int errorCode;
				LuaObject.checkType(l, 2, out errorCode);
				battleUITask.m_luaExportHelper.ShowErrorMessageAndExitBattle(errorCode);
				LuaObject.pushValue(l, true);
				result = 1;
			}
			else if (LuaObject.matchType(l, total, 2, typeof(StringTableId)))
			{
				BattleUITask battleUITask2 = (BattleUITask)LuaObject.checkSelf(l);
				StringTableId strId;
				LuaObject.checkEnum<StringTableId>(l, 2, out strId);
				battleUITask2.m_luaExportHelper.ShowErrorMessageAndExitBattle(strId);
				LuaObject.pushValue(l, true);
				result = 1;
			}
			else
			{
				LuaObject.pushValue(l, false);
				LuaDLL.lua_pushstring(l, "No matched override function ShowErrorMessageAndExitBattle to call");
				result = 2;
			}
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601C2BA RID: 115386 RVA: 0x008AEDC4 File Offset: 0x008ACFC4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int SaveProcessingBattle(IntPtr l)
	{
		int result;
		try
		{
			BattleUITask battleUITask = (BattleUITask)LuaObject.checkSelf(l);
			battleUITask.m_luaExportHelper.SaveProcessingBattle();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601C2BB RID: 115387 RVA: 0x008AEE18 File Offset: 0x008AD018
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int BattlePrepareBeforeShowResult(IntPtr l)
	{
		int result;
		try
		{
			BattleUITask battleUITask = (BattleUITask)LuaObject.checkSelf(l);
			battleUITask.m_luaExportHelper.BattlePrepareBeforeShowResult();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601C2BC RID: 115388 RVA: 0x008AEE6C File Offset: 0x008AD06C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int IsMeArenaBattleTeam1(IntPtr l)
	{
		int result;
		try
		{
			BattleUITask battleUITask = (BattleUITask)LuaObject.checkSelf(l);
			bool b = battleUITask.m_luaExportHelper.IsMeArenaBattleTeam1();
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

	// Token: 0x0601C2BD RID: 115389 RVA: 0x008AEEC8 File Offset: 0x008AD0C8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int CanUseChat(IntPtr l)
	{
		int result;
		try
		{
			BattleUITask battleUITask = (BattleUITask)LuaObject.checkSelf(l);
			bool b = battleUITask.m_luaExportHelper.CanUseChat();
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

	// Token: 0x0601C2BE RID: 115390 RVA: 0x008AEF24 File Offset: 0x008AD124
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int CanUseDanmaku(IntPtr l)
	{
		int result;
		try
		{
			BattleUITask battleUITask = (BattleUITask)LuaObject.checkSelf(l);
			bool b = battleUITask.m_luaExportHelper.CanUseDanmaku();
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

	// Token: 0x0601C2BF RID: 115391 RVA: 0x008AEF80 File Offset: 0x008AD180
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int BattlePauseUIController_OnClose(IntPtr l)
	{
		int result;
		try
		{
			BattleUITask battleUITask = (BattleUITask)LuaObject.checkSelf(l);
			battleUITask.m_luaExportHelper.BattlePauseUIController_OnClose();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601C2C0 RID: 115392 RVA: 0x008AEFD4 File Offset: 0x008AD1D4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int BattlePauseUIController_OnShowPlayerSetting(IntPtr l)
	{
		int result;
		try
		{
			BattleUITask battleUITask = (BattleUITask)LuaObject.checkSelf(l);
			battleUITask.m_luaExportHelper.BattlePauseUIController_OnShowPlayerSetting();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601C2C1 RID: 115393 RVA: 0x008AF028 File Offset: 0x008AD228
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int BattlePauseUIController_OnExit(IntPtr l)
	{
		int result;
		try
		{
			BattleUITask battleUITask = (BattleUITask)LuaObject.checkSelf(l);
			battleUITask.m_luaExportHelper.BattlePauseUIController_OnExit();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601C2C2 RID: 115394 RVA: 0x008AF07C File Offset: 0x008AD27C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int ExitBattleDialogBoxCallback(IntPtr l)
	{
		int result;
		try
		{
			BattleUITask battleUITask = (BattleUITask)LuaObject.checkSelf(l);
			DialogBoxResult r;
			LuaObject.checkEnum<DialogBoxResult>(l, 2, out r);
			battleUITask.m_luaExportHelper.ExitBattleDialogBoxCallback(r);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601C2C3 RID: 115395 RVA: 0x008AF0D8 File Offset: 0x008AD2D8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int TestUI_ExitBattle(IntPtr l)
	{
		int result;
		try
		{
			BattleUITask battleUITask = (BattleUITask)LuaObject.checkSelf(l);
			battleUITask.m_luaExportHelper.TestUI_ExitBattle();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601C2C4 RID: 115396 RVA: 0x008AF12C File Offset: 0x008AD32C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int TestUI_RestartBattle(IntPtr l)
	{
		int result;
		try
		{
			BattleUITask battleUITask = (BattleUITask)LuaObject.checkSelf(l);
			battleUITask.m_luaExportHelper.TestUI_RestartBattle();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601C2C5 RID: 115397 RVA: 0x008AF180 File Offset: 0x008AD380
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int TestUI_ReplayBattle(IntPtr l)
	{
		int result;
		try
		{
			BattleUITask battleUITask = (BattleUITask)LuaObject.checkSelf(l);
			battleUITask.m_luaExportHelper.TestUI_ReplayBattle();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601C2C6 RID: 115398 RVA: 0x008AF1D4 File Offset: 0x008AD3D4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int TestUI_StopBattle(IntPtr l)
	{
		int result;
		try
		{
			BattleUITask battleUITask = (BattleUITask)LuaObject.checkSelf(l);
			bool win;
			LuaObject.checkType(l, 2, out win);
			battleUITask.m_luaExportHelper.TestUI_StopBattle(win);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601C2C7 RID: 115399 RVA: 0x008AF230 File Offset: 0x008AD430
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int PlayerContext_OnChatMessageNtf(IntPtr l)
	{
		int result;
		try
		{
			BattleUITask battleUITask = (BattleUITask)LuaObject.checkSelf(l);
			ChatMessage msg;
			LuaObject.checkType<ChatMessage>(l, 2, out msg);
			battleUITask.m_luaExportHelper.PlayerContext_OnChatMessageNtf(msg);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601C2C8 RID: 115400 RVA: 0x008AF28C File Offset: 0x008AD48C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int PlayerContext_OnTeamRoomInviteNtf(IntPtr l)
	{
		int result;
		try
		{
			BattleUITask battleUITask = (BattleUITask)LuaObject.checkSelf(l);
			TeamRoomInviteInfo inviteInfo;
			LuaObject.checkType<TeamRoomInviteInfo>(l, 2, out inviteInfo);
			battleUITask.m_luaExportHelper.PlayerContext_OnTeamRoomInviteNtf(inviteInfo);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601C2C9 RID: 115401 RVA: 0x008AF2E8 File Offset: 0x008AD4E8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int PlayerContext_OnBattlePracticeInvitedNtf(IntPtr l)
	{
		int result;
		try
		{
			BattleUITask battleUITask = (BattleUITask)LuaObject.checkSelf(l);
			PVPInviteInfo inviteInfo;
			LuaObject.checkType<PVPInviteInfo>(l, 2, out inviteInfo);
			battleUITask.m_luaExportHelper.PlayerContext_OnBattlePracticeInvitedNtf(inviteInfo);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601C2CA RID: 115402 RVA: 0x008AF344 File Offset: 0x008AD544
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int CollectBattlePrepareAssets(IntPtr l)
	{
		int result;
		try
		{
			BattleUITask battleUITask = (BattleUITask)LuaObject.checkSelf(l);
			battleUITask.m_luaExportHelper.CollectBattlePrepareAssets();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601C2CB RID: 115403 RVA: 0x008AF398 File Offset: 0x008AD598
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int CollectBattleAssets(IntPtr l)
	{
		int result;
		try
		{
			BattleUITask battleUITask = (BattleUITask)LuaObject.checkSelf(l);
			battleUITask.m_luaExportHelper.CollectBattleAssets();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601C2CC RID: 115404 RVA: 0x008AF3EC File Offset: 0x008AD5EC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int CollectBattlePrepareHeros(IntPtr l)
	{
		int result;
		try
		{
			BattleUITask battleUITask = (BattleUITask)LuaObject.checkSelf(l);
			List<BattleHero> heros;
			LuaObject.checkType<List<BattleHero>>(l, 2, out heros);
			List<BattleHero> heros2;
			LuaObject.checkType<List<BattleHero>>(l, 3, out heros2);
			battleUITask.m_luaExportHelper.CollectBattlePrepareHeros(heros, heros2);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601C2CD RID: 115405 RVA: 0x008AF458 File Offset: 0x008AD658
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int CollectBattlefieldAssets(IntPtr l)
	{
		int result;
		try
		{
			BattleUITask battleUITask = (BattleUITask)LuaObject.checkSelf(l);
			ConfigDataBattlefieldInfo battlefieldInfo;
			LuaObject.checkType<ConfigDataBattlefieldInfo>(l, 2, out battlefieldInfo);
			battleUITask.m_luaExportHelper.CollectBattlefieldAssets(battlefieldInfo);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601C2CE RID: 115406 RVA: 0x008AF4B4 File Offset: 0x008AD6B4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int CollectTerrainAssets(IntPtr l)
	{
		int result;
		try
		{
			BattleUITask battleUITask = (BattleUITask)LuaObject.checkSelf(l);
			ConfigDataTerrainInfo terrainInfo;
			LuaObject.checkType<ConfigDataTerrainInfo>(l, 2, out terrainInfo);
			battleUITask.m_luaExportHelper.CollectTerrainAssets(terrainInfo);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601C2CF RID: 115407 RVA: 0x008AF510 File Offset: 0x008AD710
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int CollectCharImageAssets(IntPtr l)
	{
		int result;
		try
		{
			BattleUITask battleUITask = (BattleUITask)LuaObject.checkSelf(l);
			ConfigDataCharImageInfo charImageInfo;
			LuaObject.checkType<ConfigDataCharImageInfo>(l, 2, out charImageInfo);
			ConfigDataCharImageSkinResourceInfo skinResInfo;
			LuaObject.checkType<ConfigDataCharImageSkinResourceInfo>(l, 3, out skinResInfo);
			battleUITask.m_luaExportHelper.CollectCharImageAssets(charImageInfo, skinResInfo);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601C2D0 RID: 115408 RVA: 0x008AF57C File Offset: 0x008AD77C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int CollectHeadImageAssets(IntPtr l)
	{
		int result;
		try
		{
			BattleUITask battleUITask = (BattleUITask)LuaObject.checkSelf(l);
			ConfigDataCharImageInfo charImageInfo;
			LuaObject.checkType<ConfigDataCharImageInfo>(l, 2, out charImageInfo);
			battleUITask.m_luaExportHelper.CollectHeadImageAssets(charImageInfo);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601C2D1 RID: 115409 RVA: 0x008AF5D8 File Offset: 0x008AD7D8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int CollectHeroAssets(IntPtr l)
	{
		int result;
		try
		{
			BattleUITask battleUITask = (BattleUITask)LuaObject.checkSelf(l);
			ConfigDataJobConnectionInfo jobConnectionInfo;
			LuaObject.checkType<ConfigDataJobConnectionInfo>(l, 2, out jobConnectionInfo);
			ConfigDataModelSkinResourceInfo heroSkinResInfo;
			LuaObject.checkType<ConfigDataModelSkinResourceInfo>(l, 3, out heroSkinResInfo);
			int heroStar;
			LuaObject.checkType(l, 4, out heroStar);
			battleUITask.m_luaExportHelper.CollectHeroAssets(jobConnectionInfo, heroSkinResInfo, heroStar);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601C2D2 RID: 115410 RVA: 0x008AF650 File Offset: 0x008AD850
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int CollectSoldierAssets(IntPtr l)
	{
		int result;
		try
		{
			BattleUITask battleUITask = (BattleUITask)LuaObject.checkSelf(l);
			ConfigDataSoldierInfo soldierInfo;
			LuaObject.checkType<ConfigDataSoldierInfo>(l, 2, out soldierInfo);
			ConfigDataModelSkinResourceInfo soldierSkinResInfo;
			LuaObject.checkType<ConfigDataModelSkinResourceInfo>(l, 3, out soldierSkinResInfo);
			battleUITask.m_luaExportHelper.CollectSoldierAssets(soldierInfo, soldierSkinResInfo);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601C2D3 RID: 115411 RVA: 0x008AF6BC File Offset: 0x008AD8BC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int CollectSkinAssets(IntPtr l)
	{
		int result;
		try
		{
			BattleUITask battleUITask = (BattleUITask)LuaObject.checkSelf(l);
			ConfigDataModelSkinResourceInfo skinResInfo;
			LuaObject.checkType<ConfigDataModelSkinResourceInfo>(l, 2, out skinResInfo);
			battleUITask.m_luaExportHelper.CollectSkinAssets(skinResInfo);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601C2D4 RID: 115412 RVA: 0x008AF718 File Offset: 0x008AD918
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int CollectSkillAssets(IntPtr l)
	{
		int result;
		try
		{
			BattleUITask battleUITask = (BattleUITask)LuaObject.checkSelf(l);
			ConfigDataSkillInfo skillInfo;
			LuaObject.checkType<ConfigDataSkillInfo>(l, 2, out skillInfo);
			battleUITask.m_luaExportHelper.CollectSkillAssets(skillInfo);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601C2D5 RID: 115413 RVA: 0x008AF774 File Offset: 0x008AD974
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int CollectBuffAssets(IntPtr l)
	{
		int result;
		try
		{
			BattleUITask battleUITask = (BattleUITask)LuaObject.checkSelf(l);
			ConfigDataBuffInfo buffInfo;
			LuaObject.checkType<ConfigDataBuffInfo>(l, 2, out buffInfo);
			battleUITask.m_luaExportHelper.CollectBuffAssets(buffInfo);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601C2D6 RID: 115414 RVA: 0x008AF7D0 File Offset: 0x008AD9D0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int CollectDefaultHeroAssets(IntPtr l)
	{
		int result;
		try
		{
			BattleUITask battleUITask = (BattleUITask)LuaObject.checkSelf(l);
			ConfigDataHeroInfo heroInfo;
			LuaObject.checkType<ConfigDataHeroInfo>(l, 2, out heroInfo);
			battleUITask.m_luaExportHelper.CollectDefaultHeroAssets(heroInfo);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601C2D7 RID: 115415 RVA: 0x008AF82C File Offset: 0x008ADA2C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int CollectBattleEventAssets(IntPtr l)
	{
		int result;
		try
		{
			BattleUITask battleUITask = (BattleUITask)LuaObject.checkSelf(l);
			ConfigDataBattleEventTriggerInfo eventTriggerInfo;
			LuaObject.checkType<ConfigDataBattleEventTriggerInfo>(l, 2, out eventTriggerInfo);
			battleUITask.m_luaExportHelper.CollectBattleEventAssets(eventTriggerInfo);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601C2D8 RID: 115416 RVA: 0x008AF888 File Offset: 0x008ADA88
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int CollectBattleEventActionAssets(IntPtr l)
	{
		int result;
		try
		{
			BattleUITask battleUITask = (BattleUITask)LuaObject.checkSelf(l);
			ConfigDataBattleEventActionInfo eventActionInfo;
			LuaObject.checkType<ConfigDataBattleEventActionInfo>(l, 2, out eventActionInfo);
			battleUITask.m_luaExportHelper.CollectBattleEventActionAssets(eventActionInfo);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601C2D9 RID: 115417 RVA: 0x008AF8E4 File Offset: 0x008ADAE4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int CollectBattlePerformAssets(IntPtr l)
	{
		int result;
		try
		{
			BattleUITask battleUITask = (BattleUITask)LuaObject.checkSelf(l);
			ConfigDataBattlePerformInfo performInfo;
			LuaObject.checkType<ConfigDataBattlePerformInfo>(l, 2, out performInfo);
			battleUITask.m_luaExportHelper.CollectBattlePerformAssets(performInfo);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601C2DA RID: 115418 RVA: 0x008AF940 File Offset: 0x008ADB40
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int _CollectBattlePerformAssets(IntPtr l)
	{
		int result;
		try
		{
			BattleUITask battleUITask = (BattleUITask)LuaObject.checkSelf(l);
			ConfigDataBattlePerformInfo performInfo;
			LuaObject.checkType<ConfigDataBattlePerformInfo>(l, 2, out performInfo);
			battleUITask.m_luaExportHelper._CollectBattlePerformAssets(performInfo);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601C2DB RID: 115419 RVA: 0x008AF99C File Offset: 0x008ADB9C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int CollectTrainingTechAssets(IntPtr l)
	{
		int result;
		try
		{
			BattleUITask battleUITask = (BattleUITask)LuaObject.checkSelf(l);
			List<TrainingTech> techs;
			LuaObject.checkType<List<TrainingTech>>(l, 2, out techs);
			battleUITask.m_luaExportHelper.CollectTrainingTechAssets(techs);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601C2DC RID: 115420 RVA: 0x008AF9F8 File Offset: 0x008ADBF8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int IsAlreadyCollectAsset(IntPtr l)
	{
		int result;
		try
		{
			BattleUITask battleUITask = (BattleUITask)LuaObject.checkSelf(l);
			object obj;
			LuaObject.checkType<object>(l, 2, out obj);
			bool b = battleUITask.m_luaExportHelper.IsAlreadyCollectAsset(obj);
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

	// Token: 0x0601C2DD RID: 115421 RVA: 0x008AFA60 File Offset: 0x008ADC60
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int ClearAlreadyCollectAssets(IntPtr l)
	{
		int result;
		try
		{
			BattleUITask battleUITask = (BattleUITask)LuaObject.checkSelf(l);
			battleUITask.m_luaExportHelper.ClearAlreadyCollectAssets();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601C2DE RID: 115422 RVA: 0x008AFAB4 File Offset: 0x008ADCB4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int StartBattleUI(IntPtr l)
	{
		int result;
		try
		{
			BattleUITask battleUITask = (BattleUITask)LuaObject.checkSelf(l);
			battleUITask.m_luaExportHelper.StartBattleUI();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601C2DF RID: 115423 RVA: 0x008AFB08 File Offset: 0x008ADD08
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int ClientActorTryMoveTo(IntPtr l)
	{
		int result;
		try
		{
			BattleUITask battleUITask = (BattleUITask)LuaObject.checkSelf(l);
			ClientBattleActor ca;
			LuaObject.checkType<ClientBattleActor>(l, 2, out ca);
			GridPosition p;
			LuaObject.checkValueType<GridPosition>(l, 3, out p);
			int finalDir;
			LuaObject.checkType(l, 4, out finalDir);
			battleUITask.m_luaExportHelper.ClientActorTryMoveTo(ca, p, finalDir);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601C2E0 RID: 115424 RVA: 0x008AFB80 File Offset: 0x008ADD80
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int AddCommandIfMoved(IntPtr l)
	{
		int result;
		try
		{
			BattleUITask battleUITask = (BattleUITask)LuaObject.checkSelf(l);
			ClientBattleActor ca;
			LuaObject.checkType<ClientBattleActor>(l, 2, out ca);
			battleUITask.m_luaExportHelper.AddCommandIfMoved(ca);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601C2E1 RID: 115425 RVA: 0x008AFBDC File Offset: 0x008ADDDC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int FindAttackPosition(IntPtr l)
	{
		int result;
		try
		{
			BattleUITask battleUITask = (BattleUITask)LuaObject.checkSelf(l);
			int attackDistance;
			LuaObject.checkType(l, 2, out attackDistance);
			GridPosition targetPos;
			LuaObject.checkValueType<GridPosition>(l, 3, out targetPos);
			GridPosition gridPosition = battleUITask.m_luaExportHelper.FindAttackPosition(attackDistance, targetPos);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, gridPosition);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601C2E2 RID: 115426 RVA: 0x008AFC58 File Offset: 0x008ADE58
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int CanAction(IntPtr l)
	{
		int result;
		try
		{
			BattleUITask battleUITask = (BattleUITask)LuaObject.checkSelf(l);
			bool b = battleUITask.m_luaExportHelper.CanAction();
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

	// Token: 0x0601C2E3 RID: 115427 RVA: 0x008AFCB4 File Offset: 0x008ADEB4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int GetMapBattleActor(IntPtr l)
	{
		int result;
		try
		{
			BattleUITask battleUITask = (BattleUITask)LuaObject.checkSelf(l);
			GridPosition p;
			LuaObject.checkValueType<GridPosition>(l, 2, out p);
			BattleActor mapBattleActor = battleUITask.m_luaExportHelper.GetMapBattleActor(p);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, mapBattleActor);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601C2E4 RID: 115428 RVA: 0x008AFD1C File Offset: 0x008ADF1C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int ResetActorEffect(IntPtr l)
	{
		int result;
		try
		{
			BattleUITask battleUITask = (BattleUITask)LuaObject.checkSelf(l);
			battleUITask.m_luaExportHelper.ResetActorEffect();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601C2E5 RID: 115429 RVA: 0x008AFD70 File Offset: 0x008ADF70
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int CanUseSkillAtPosition(IntPtr l)
	{
		int result;
		try
		{
			BattleUITask battleUITask = (BattleUITask)LuaObject.checkSelf(l);
			ClientBattleActor ca;
			LuaObject.checkType<ClientBattleActor>(l, 2, out ca);
			ConfigDataSkillInfo skillInfo;
			LuaObject.checkType<ConfigDataSkillInfo>(l, 3, out skillInfo);
			GridPosition p;
			LuaObject.checkValueType<GridPosition>(l, 4, out p);
			bool b = battleUITask.m_luaExportHelper.CanUseSkillAtPosition(ca, skillInfo, p);
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

	// Token: 0x0601C2E6 RID: 115430 RVA: 0x008AFDF4 File Offset: 0x008ADFF4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int FindMoveRegion(IntPtr l)
	{
		int result;
		try
		{
			BattleUITask battleUITask = (BattleUITask)LuaObject.checkSelf(l);
			battleUITask.m_luaExportHelper.FindMoveRegion();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601C2E7 RID: 115431 RVA: 0x008AFE48 File Offset: 0x008AE048
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int ShowMoveAndAttackRegion(IntPtr l)
	{
		int result;
		try
		{
			int num = LuaDLL.lua_gettop(l);
			if (num == 1)
			{
				BattleUITask battleUITask = (BattleUITask)LuaObject.checkSelf(l);
				battleUITask.m_luaExportHelper.ShowMoveAndAttackRegion();
				LuaObject.pushValue(l, true);
				result = 1;
			}
			else if (num == 3)
			{
				BattleUITask battleUITask2 = (BattleUITask)LuaObject.checkSelf(l);
				BattleActor actor;
				LuaObject.checkType<BattleActor>(l, 2, out actor);
				GridPosition startPos;
				LuaObject.checkValueType<GridPosition>(l, 3, out startPos);
				battleUITask2.m_luaExportHelper.ShowMoveAndAttackRegion(actor, startPos);
				LuaObject.pushValue(l, true);
				result = 1;
			}
			else
			{
				LuaObject.pushValue(l, false);
				LuaDLL.lua_pushstring(l, "No matched override function ShowMoveAndAttackRegion to call");
				result = 2;
			}
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601C2E8 RID: 115432 RVA: 0x008AFF08 File Offset: 0x008AE108
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int ShowMoveRegion(IntPtr l)
	{
		int result;
		try
		{
			int num = LuaDLL.lua_gettop(l);
			if (num == 1)
			{
				BattleUITask battleUITask = (BattleUITask)LuaObject.checkSelf(l);
				battleUITask.m_luaExportHelper.ShowMoveRegion();
				LuaObject.pushValue(l, true);
				result = 1;
			}
			else if (num == 3)
			{
				BattleUITask battleUITask2 = (BattleUITask)LuaObject.checkSelf(l);
				BattleActor actor;
				LuaObject.checkType<BattleActor>(l, 2, out actor);
				GridPosition startPos;
				LuaObject.checkValueType<GridPosition>(l, 3, out startPos);
				battleUITask2.m_luaExportHelper.ShowMoveRegion(actor, startPos);
				LuaObject.pushValue(l, true);
				result = 1;
			}
			else
			{
				LuaObject.pushValue(l, false);
				LuaDLL.lua_pushstring(l, "No matched override function ShowMoveRegion to call");
				result = 2;
			}
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601C2E9 RID: 115433 RVA: 0x008AFFC8 File Offset: 0x008AE1C8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int UpdateDangerRegion(IntPtr l)
	{
		int result;
		try
		{
			BattleUITask battleUITask = (BattleUITask)LuaObject.checkSelf(l);
			battleUITask.m_luaExportHelper.UpdateDangerRegion();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601C2EA RID: 115434 RVA: 0x008B001C File Offset: 0x008AE21C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int ShowDangerTeamRegion(IntPtr l)
	{
		int result;
		try
		{
			BattleUITask battleUITask = (BattleUITask)LuaObject.checkSelf(l);
			int team;
			LuaObject.checkType(l, 2, out team);
			battleUITask.m_luaExportHelper.ShowDangerTeamRegion(team);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601C2EB RID: 115435 RVA: 0x008B0078 File Offset: 0x008AE278
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int ShowDangerRegion(IntPtr l)
	{
		int result;
		try
		{
			BattleUITask battleUITask = (BattleUITask)LuaObject.checkSelf(l);
			List<int> actorIds;
			LuaObject.checkType<List<int>>(l, 2, out actorIds);
			battleUITask.m_luaExportHelper.ShowDangerRegion(actorIds);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601C2EC RID: 115436 RVA: 0x008B00D4 File Offset: 0x008AE2D4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int ShowMovePath(IntPtr l)
	{
		int result;
		try
		{
			BattleUITask battleUITask = (BattleUITask)LuaObject.checkSelf(l);
			ClientBattleActor ca;
			LuaObject.checkType<ClientBattleActor>(l, 2, out ca);
			GridPosition startPos;
			LuaObject.checkValueType<GridPosition>(l, 3, out startPos);
			battleUITask.m_luaExportHelper.ShowMovePath(ca, startPos);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601C2ED RID: 115437 RVA: 0x008B0140 File Offset: 0x008AE340
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int GetSummonMoveType(IntPtr l)
	{
		int result;
		try
		{
			BattleUITask battleUITask = (BattleUITask)LuaObject.checkSelf(l);
			int heroId;
			LuaObject.checkType(l, 2, out heroId);
			MoveType summonMoveType = battleUITask.m_luaExportHelper.GetSummonMoveType(heroId);
			LuaObject.pushValue(l, true);
			LuaObject.pushEnum(l, (int)summonMoveType);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601C2EE RID: 115438 RVA: 0x008B01A8 File Offset: 0x008AE3A8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int ShowSkillRegion(IntPtr l)
	{
		int result;
		try
		{
			int num = LuaDLL.lua_gettop(l);
			if (num == 1)
			{
				BattleUITask battleUITask = (BattleUITask)LuaObject.checkSelf(l);
				battleUITask.m_luaExportHelper.ShowSkillRegion();
				LuaObject.pushValue(l, true);
				result = 1;
			}
			else if (num == 4)
			{
				BattleUITask battleUITask2 = (BattleUITask)LuaObject.checkSelf(l);
				BattleActor actor;
				LuaObject.checkType<BattleActor>(l, 2, out actor);
				int skillIndex;
				LuaObject.checkType(l, 3, out skillIndex);
				GridPosition startPos;
				LuaObject.checkValueType<GridPosition>(l, 4, out startPos);
				battleUITask2.m_luaExportHelper.ShowSkillRegion(actor, skillIndex, startPos);
				LuaObject.pushValue(l, true);
				result = 1;
			}
			else
			{
				LuaObject.pushValue(l, false);
				LuaDLL.lua_pushstring(l, "No matched override function ShowSkillRegion to call");
				result = 2;
			}
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601C2EF RID: 115439 RVA: 0x008B0274 File Offset: 0x008AE474
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int ShowSkillRange(IntPtr l)
	{
		int result;
		try
		{
			int num = LuaDLL.lua_gettop(l);
			if (num == 1)
			{
				BattleUITask battleUITask = (BattleUITask)LuaObject.checkSelf(l);
				battleUITask.m_luaExportHelper.ShowSkillRange();
				LuaObject.pushValue(l, true);
				result = 1;
			}
			else if (num == 4)
			{
				BattleUITask battleUITask2 = (BattleUITask)LuaObject.checkSelf(l);
				BattleActor actor;
				LuaObject.checkType<BattleActor>(l, 2, out actor);
				int skillIndex;
				LuaObject.checkType(l, 3, out skillIndex);
				GridPosition targetPos;
				LuaObject.checkValueType<GridPosition>(l, 4, out targetPos);
				battleUITask2.m_luaExportHelper.ShowSkillRange(actor, skillIndex, targetPos);
				LuaObject.pushValue(l, true);
				result = 1;
			}
			else
			{
				LuaObject.pushValue(l, false);
				LuaDLL.lua_pushstring(l, "No matched override function ShowSkillRange to call");
				result = 2;
			}
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601C2F0 RID: 115440 RVA: 0x008B0340 File Offset: 0x008AE540
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int ShowTeleportRegion(IntPtr l)
	{
		int result;
		try
		{
			int num = LuaDLL.lua_gettop(l);
			if (num == 1)
			{
				BattleUITask battleUITask = (BattleUITask)LuaObject.checkSelf(l);
				battleUITask.m_luaExportHelper.ShowTeleportRegion();
				LuaObject.pushValue(l, true);
				result = 1;
			}
			else if (num == 4)
			{
				BattleUITask battleUITask2 = (BattleUITask)LuaObject.checkSelf(l);
				BattleActor actor;
				LuaObject.checkType<BattleActor>(l, 2, out actor);
				int skillIndex;
				LuaObject.checkType(l, 3, out skillIndex);
				GridPosition targetPos;
				LuaObject.checkValueType<GridPosition>(l, 4, out targetPos);
				battleUITask2.m_luaExportHelper.ShowTeleportRegion(actor, skillIndex, targetPos);
				LuaObject.pushValue(l, true);
				result = 1;
			}
			else
			{
				LuaObject.pushValue(l, false);
				LuaDLL.lua_pushstring(l, "No matched override function ShowTeleportRegion to call");
				result = 2;
			}
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601C2F1 RID: 115441 RVA: 0x008B040C File Offset: 0x008AE60C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int ShowAttackTargets(IntPtr l)
	{
		int result;
		try
		{
			BattleUITask battleUITask = (BattleUITask)LuaObject.checkSelf(l);
			BattleActor actor;
			LuaObject.checkType<BattleActor>(l, 2, out actor);
			GridPosition goalPos;
			LuaObject.checkValueType<GridPosition>(l, 3, out goalPos);
			battleUITask.m_luaExportHelper.ShowAttackTargets(actor, goalPos);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601C2F2 RID: 115442 RVA: 0x008B0478 File Offset: 0x008AE678
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int ShowSkillTargets(IntPtr l)
	{
		int result;
		try
		{
			int num = LuaDLL.lua_gettop(l);
			if (num == 1)
			{
				BattleUITask battleUITask = (BattleUITask)LuaObject.checkSelf(l);
				battleUITask.m_luaExportHelper.ShowSkillTargets();
				LuaObject.pushValue(l, true);
				result = 1;
			}
			else if (num == 4)
			{
				BattleUITask battleUITask2 = (BattleUITask)LuaObject.checkSelf(l);
				ClientBattleActor ca;
				LuaObject.checkType<ClientBattleActor>(l, 2, out ca);
				int skillIndex;
				LuaObject.checkType(l, 3, out skillIndex);
				GridPosition startPos;
				LuaObject.checkValueType<GridPosition>(l, 4, out startPos);
				battleUITask2.m_luaExportHelper.ShowSkillTargets(ca, skillIndex, startPos);
				LuaObject.pushValue(l, true);
				result = 1;
			}
			else
			{
				LuaObject.pushValue(l, false);
				LuaDLL.lua_pushstring(l, "No matched override function ShowSkillTargets to call");
				result = 2;
			}
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601C2F3 RID: 115443 RVA: 0x008B0544 File Offset: 0x008AE744
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int ShowBattleTreasureDialog(IntPtr l)
	{
		int result;
		try
		{
			BattleUITask battleUITask = (BattleUITask)LuaObject.checkSelf(l);
			ConfigDataBattleTreasureInfo treasureInfo;
			LuaObject.checkType<ConfigDataBattleTreasureInfo>(l, 2, out treasureInfo);
			battleUITask.m_luaExportHelper.ShowBattleTreasureDialog(treasureInfo);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601C2F4 RID: 115444 RVA: 0x008B05A0 File Offset: 0x008AE7A0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int ShowBattleTreasureReward(IntPtr l)
	{
		int result;
		try
		{
			BattleUITask battleUITask = (BattleUITask)LuaObject.checkSelf(l);
			ConfigDataBattleTreasureInfo treasureInfo;
			LuaObject.checkType<ConfigDataBattleTreasureInfo>(l, 2, out treasureInfo);
			battleUITask.m_luaExportHelper.ShowBattleTreasureReward(treasureInfo);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601C2F5 RID: 115445 RVA: 0x008B05FC File Offset: 0x008AE7FC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int ShowPreCombat(IntPtr l)
	{
		int result;
		try
		{
			BattleUITask battleUITask = (BattleUITask)LuaObject.checkSelf(l);
			BattleActor a;
			LuaObject.checkType<BattleActor>(l, 2, out a);
			BattleActor a2;
			LuaObject.checkType<BattleActor>(l, 3, out a2);
			ConfigDataSkillInfo attackerSkillInfo;
			LuaObject.checkType<ConfigDataSkillInfo>(l, 4, out attackerSkillInfo);
			battleUITask.m_luaExportHelper.ShowPreCombat(a, a2, attackerSkillInfo);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601C2F6 RID: 115446 RVA: 0x008B0674 File Offset: 0x008AE874
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int ShowFastCombat(IntPtr l)
	{
		int result;
		try
		{
			BattleUITask battleUITask = (BattleUITask)LuaObject.checkSelf(l);
			FastCombatActorInfo a;
			LuaObject.checkType<FastCombatActorInfo>(l, 2, out a);
			FastCombatActorInfo a2;
			LuaObject.checkType<FastCombatActorInfo>(l, 3, out a2);
			battleUITask.m_luaExportHelper.ShowFastCombat(a, a2);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601C2F7 RID: 115447 RVA: 0x008B06E0 File Offset: 0x008AE8E0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int ShowActorInfo(IntPtr l)
	{
		int result;
		try
		{
			BattleUITask battleUITask = (BattleUITask)LuaObject.checkSelf(l);
			BattleActor a;
			LuaObject.checkType<BattleActor>(l, 2, out a);
			battleUITask.m_luaExportHelper.ShowActorInfo(a);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601C2F8 RID: 115448 RVA: 0x008B073C File Offset: 0x008AE93C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int HideActorInfo(IntPtr l)
	{
		int result;
		try
		{
			BattleUITask battleUITask = (BattleUITask)LuaObject.checkSelf(l);
			battleUITask.m_luaExportHelper.HideActorInfo();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601C2F9 RID: 115449 RVA: 0x008B0790 File Offset: 0x008AE990
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int ShowSelectionMarkAndTerrain(IntPtr l)
	{
		int result;
		try
		{
			BattleUITask battleUITask = (BattleUITask)LuaObject.checkSelf(l);
			GridPosition p;
			LuaObject.checkValueType<GridPosition>(l, 2, out p);
			battleUITask.m_luaExportHelper.ShowSelectionMarkAndTerrain(p);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601C2FA RID: 115450 RVA: 0x008B07EC File Offset: 0x008AE9EC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int SetUIStateNone(IntPtr l)
	{
		int result;
		try
		{
			BattleUITask battleUITask = (BattleUITask)LuaObject.checkSelf(l);
			battleUITask.m_luaExportHelper.SetUIStateNone();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601C2FB RID: 115451 RVA: 0x008B0840 File Offset: 0x008AEA40
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int SetUIStateSelectActionActor(IntPtr l)
	{
		int result;
		try
		{
			BattleUITask battleUITask = (BattleUITask)LuaObject.checkSelf(l);
			battleUITask.m_luaExportHelper.SetUIStateSelectActionActor();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601C2FC RID: 115452 RVA: 0x008B0894 File Offset: 0x008AEA94
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int SetUIStateMove(IntPtr l)
	{
		int result;
		try
		{
			BattleUITask battleUITask = (BattleUITask)LuaObject.checkSelf(l);
			battleUITask.m_luaExportHelper.SetUIStateMove();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601C2FD RID: 115453 RVA: 0x008B08E8 File Offset: 0x008AEAE8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int ShowSkills(IntPtr l)
	{
		int result;
		try
		{
			BattleUITask battleUITask = (BattleUITask)LuaObject.checkSelf(l);
			battleUITask.m_luaExportHelper.ShowSkills();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601C2FE RID: 115454 RVA: 0x008B093C File Offset: 0x008AEB3C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int SetUIStateExtraMove(IntPtr l)
	{
		int result;
		try
		{
			BattleUITask battleUITask = (BattleUITask)LuaObject.checkSelf(l);
			battleUITask.m_luaExportHelper.SetUIStateExtraMove();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601C2FF RID: 115455 RVA: 0x008B0990 File Offset: 0x008AEB90
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int SetUIStateSelectSkillTarget(IntPtr l)
	{
		int result;
		try
		{
			BattleUITask battleUITask = (BattleUITask)LuaObject.checkSelf(l);
			battleUITask.m_luaExportHelper.SetUIStateSelectSkillTarget();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601C300 RID: 115456 RVA: 0x008B09E4 File Offset: 0x008AEBE4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int SetUIStateConfirmSkill(IntPtr l)
	{
		int result;
		try
		{
			BattleUITask battleUITask = (BattleUITask)LuaObject.checkSelf(l);
			battleUITask.m_luaExportHelper.SetUIStateConfirmSkill();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601C301 RID: 115457 RVA: 0x008B0A38 File Offset: 0x008AEC38
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int SetUIStateSelectTeleportPosition1(IntPtr l)
	{
		int result;
		try
		{
			BattleUITask battleUITask = (BattleUITask)LuaObject.checkSelf(l);
			battleUITask.m_luaExportHelper.SetUIStateSelectTeleportPosition1();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601C302 RID: 115458 RVA: 0x008B0A8C File Offset: 0x008AEC8C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int SetUIStateSelectTeleportPosition2(IntPtr l)
	{
		int result;
		try
		{
			BattleUITask battleUITask = (BattleUITask)LuaObject.checkSelf(l);
			battleUITask.m_luaExportHelper.SetUIStateSelectTeleportPosition2();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601C303 RID: 115459 RVA: 0x008B0AE0 File Offset: 0x008AECE0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int SetUIStateWaitOtherPlayer(IntPtr l)
	{
		int result;
		try
		{
			BattleUITask battleUITask = (BattleUITask)LuaObject.checkSelf(l);
			battleUITask.m_luaExportHelper.SetUIStateWaitOtherPlayer();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601C304 RID: 115460 RVA: 0x008B0B34 File Offset: 0x008AED34
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int ShowCanActionActorsUI(IntPtr l)
	{
		int result;
		try
		{
			BattleUITask battleUITask = (BattleUITask)LuaObject.checkSelf(l);
			battleUITask.m_luaExportHelper.ShowCanActionActorsUI();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601C305 RID: 115461 RVA: 0x008B0B88 File Offset: 0x008AED88
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int HideCanActionActorsUI(IntPtr l)
	{
		int result;
		try
		{
			BattleUITask battleUITask = (BattleUITask)LuaObject.checkSelf(l);
			battleUITask.m_luaExportHelper.HideCanActionActorsUI();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601C306 RID: 115462 RVA: 0x008B0BDC File Offset: 0x008AEDDC
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int DoAutoBattle(IntPtr l)
	{
		int result;
		try
		{
			BattleUITask battleUITask = (BattleUITask)LuaObject.checkSelf(l);
			battleUITask.m_luaExportHelper.DoAutoBattle();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601C307 RID: 115463 RVA: 0x008B0C30 File Offset: 0x008AEE30
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int SetAutoBattle(IntPtr l)
	{
		int result;
		try
		{
			BattleUITask battleUITask = (BattleUITask)LuaObject.checkSelf(l);
			bool autoBattle;
			LuaObject.checkType(l, 2, out autoBattle);
			battleUITask.m_luaExportHelper.SetAutoBattle(autoBattle);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601C308 RID: 115464 RVA: 0x008B0C8C File Offset: 0x008AEE8C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int CameraFocusActor(IntPtr l)
	{
		int result;
		try
		{
			BattleUITask battleUITask = (BattleUITask)LuaObject.checkSelf(l);
			int actorId;
			LuaObject.checkType(l, 2, out actorId);
			battleUITask.m_luaExportHelper.CameraFocusActor(actorId);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601C309 RID: 115465 RVA: 0x008B0CE8 File Offset: 0x008AEEE8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int BattleUIController_OnAutoBattle(IntPtr l)
	{
		int result;
		try
		{
			BattleUITask battleUITask = (BattleUITask)LuaObject.checkSelf(l);
			bool on;
			LuaObject.checkType(l, 2, out on);
			battleUITask.m_luaExportHelper.BattleUIController_OnAutoBattle(on);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601C30A RID: 115466 RVA: 0x008B0D44 File Offset: 0x008AEF44
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int BattleUIController_OnFastBattle(IntPtr l)
	{
		int result;
		try
		{
			BattleUITask battleUITask = (BattleUITask)LuaObject.checkSelf(l);
			bool on;
			LuaObject.checkType(l, 2, out on);
			battleUITask.m_luaExportHelper.BattleUIController_OnFastBattle(on);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601C30B RID: 115467 RVA: 0x008B0DA0 File Offset: 0x008AEFA0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int BattleUIController_OnSkipCombat(IntPtr l)
	{
		int result;
		try
		{
			BattleUITask battleUITask = (BattleUITask)LuaObject.checkSelf(l);
			SkipCombatMode mode;
			LuaObject.checkEnum<SkipCombatMode>(l, 2, out mode);
			battleUITask.m_luaExportHelper.BattleUIController_OnSkipCombat(mode);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601C30C RID: 115468 RVA: 0x008B0DFC File Offset: 0x008AEFFC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int BattleUIController_OnShowDanger(IntPtr l)
	{
		int result;
		try
		{
			BattleUITask battleUITask = (BattleUITask)LuaObject.checkSelf(l);
			bool on;
			LuaObject.checkType(l, 2, out on);
			battleUITask.m_luaExportHelper.BattleUIController_OnShowDanger(on);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601C30D RID: 115469 RVA: 0x008B0E58 File Offset: 0x008AF058
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int BattleUIController_OnEndAllAction(IntPtr l)
	{
		int result;
		try
		{
			BattleUITask battleUITask = (BattleUITask)LuaObject.checkSelf(l);
			battleUITask.m_luaExportHelper.BattleUIController_OnEndAllAction();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601C30E RID: 115470 RVA: 0x008B0EAC File Offset: 0x008AF0AC
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int EndAllActionDialogBoxCallback(IntPtr l)
	{
		int result;
		try
		{
			BattleUITask battleUITask = (BattleUITask)LuaObject.checkSelf(l);
			DialogBoxResult r;
			LuaObject.checkEnum<DialogBoxResult>(l, 2, out r);
			battleUITask.m_luaExportHelper.EndAllActionDialogBoxCallback(r);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601C30F RID: 115471 RVA: 0x008B0F08 File Offset: 0x008AF108
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int BattleUIController_OnEndAction(IntPtr l)
	{
		int result;
		try
		{
			BattleUITask battleUITask = (BattleUITask)LuaObject.checkSelf(l);
			battleUITask.m_luaExportHelper.BattleUIController_OnEndAction();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601C310 RID: 115472 RVA: 0x008B0F5C File Offset: 0x008AF15C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int BattleUIController_OnShowActorInfo(IntPtr l)
	{
		int result;
		try
		{
			BattleUITask battleUITask = (BattleUITask)LuaObject.checkSelf(l);
			battleUITask.m_luaExportHelper.BattleUIController_OnShowActorInfo();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601C311 RID: 115473 RVA: 0x008B0FB0 File Offset: 0x008AF1B0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int BattleUIController_OnSelectSkill(IntPtr l)
	{
		int result;
		try
		{
			BattleUITask battleUITask = (BattleUITask)LuaObject.checkSelf(l);
			int skillIndex;
			LuaObject.checkType(l, 2, out skillIndex);
			battleUITask.m_luaExportHelper.BattleUIController_OnSelectSkill(skillIndex);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601C312 RID: 115474 RVA: 0x008B100C File Offset: 0x008AF20C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int BattleUIController_OnUseSkill(IntPtr l)
	{
		int result;
		try
		{
			BattleUITask battleUITask = (BattleUITask)LuaObject.checkSelf(l);
			battleUITask.m_luaExportHelper.BattleUIController_OnUseSkill();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601C313 RID: 115475 RVA: 0x008B1060 File Offset: 0x008AF260
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int BattleUIController_OnCancelSkill(IntPtr l)
	{
		int result;
		try
		{
			BattleUITask battleUITask = (BattleUITask)LuaObject.checkSelf(l);
			battleUITask.m_luaExportHelper.BattleUIController_OnCancelSkill();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601C314 RID: 115476 RVA: 0x008B10B4 File Offset: 0x008AF2B4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int BattleUIController_OnShowChat(IntPtr l)
	{
		int result;
		try
		{
			BattleUITask battleUITask = (BattleUITask)LuaObject.checkSelf(l);
			battleUITask.m_luaExportHelper.BattleUIController_OnShowChat();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601C315 RID: 115477 RVA: 0x008B1108 File Offset: 0x008AF308
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int BattleUIController_OnShowHelp(IntPtr l)
	{
		int result;
		try
		{
			BattleUITask battleUITask = (BattleUITask)LuaObject.checkSelf(l);
			battleUITask.m_luaExportHelper.BattleUIController_OnShowHelp();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601C316 RID: 115478 RVA: 0x008B115C File Offset: 0x008AF35C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int BattleUIController_OnPauseBattle(IntPtr l)
	{
		int result;
		try
		{
			BattleUITask battleUITask = (BattleUITask)LuaObject.checkSelf(l);
			battleUITask.m_luaExportHelper.BattleUIController_OnPauseBattle();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601C317 RID: 115479 RVA: 0x008B11B0 File Offset: 0x008AF3B0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int BattleUIController_OnShowArmyRelation(IntPtr l)
	{
		int result;
		try
		{
			BattleUITask battleUITask = (BattleUITask)LuaObject.checkSelf(l);
			battleUITask.m_luaExportHelper.BattleUIController_OnShowArmyRelation();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601C318 RID: 115480 RVA: 0x008B1204 File Offset: 0x008AF404
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int BattleUIController_OnPointerDown(IntPtr l)
	{
		int result;
		try
		{
			BattleUITask battleUITask = (BattleUITask)LuaObject.checkSelf(l);
			PointerEventData.InputButton button;
			LuaObject.checkEnum<PointerEventData.InputButton>(l, 2, out button);
			Vector2 position;
			LuaObject.checkType(l, 3, out position);
			battleUITask.m_luaExportHelper.BattleUIController_OnPointerDown(button, position);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601C319 RID: 115481 RVA: 0x008B1270 File Offset: 0x008AF470
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int BattleUIController_OnPointerUp(IntPtr l)
	{
		int result;
		try
		{
			BattleUITask battleUITask = (BattleUITask)LuaObject.checkSelf(l);
			PointerEventData.InputButton button;
			LuaObject.checkEnum<PointerEventData.InputButton>(l, 2, out button);
			Vector2 position;
			LuaObject.checkType(l, 3, out position);
			battleUITask.m_luaExportHelper.BattleUIController_OnPointerUp(button, position);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601C31A RID: 115482 RVA: 0x008B12DC File Offset: 0x008AF4DC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int BattleUIController_OnShowCurTurnDanmaku(IntPtr l)
	{
		int result;
		try
		{
			BattleUITask battleUITask = (BattleUITask)LuaObject.checkSelf(l);
			int turn;
			LuaObject.checkType(l, 2, out turn);
			battleUITask.m_luaExportHelper.BattleUIController_OnShowCurTurnDanmaku(turn);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601C31B RID: 115483 RVA: 0x008B1338 File Offset: 0x008AF538
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int BattleUIController_OnCloseCurTurnDanmaku(IntPtr l)
	{
		int result;
		try
		{
			BattleUITask battleUITask = (BattleUITask)LuaObject.checkSelf(l);
			battleUITask.m_luaExportHelper.BattleUIController_OnCloseCurTurnDanmaku();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601C31C RID: 115484 RVA: 0x008B138C File Offset: 0x008AF58C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int BattleUIController_OnShowOneDanmaku(IntPtr l)
	{
		int result;
		try
		{
			BattleUITask battleUITask = (BattleUITask)LuaObject.checkSelf(l);
			DanmakuEntry danmaku;
			LuaObject.checkType<DanmakuEntry>(l, 2, out danmaku);
			battleUITask.m_luaExportHelper.BattleUIController_OnShowOneDanmaku(danmaku);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601C31D RID: 115485 RVA: 0x008B13E8 File Offset: 0x008AF5E8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int BattleUIController_OnPointerClick(IntPtr l)
	{
		int result;
		try
		{
			BattleUITask battleUITask = (BattleUITask)LuaObject.checkSelf(l);
			PointerEventData.InputButton button;
			LuaObject.checkEnum<PointerEventData.InputButton>(l, 2, out button);
			Vector2 position;
			LuaObject.checkType(l, 3, out position);
			battleUITask.m_luaExportHelper.BattleUIController_OnPointerClick(button, position);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601C31E RID: 115486 RVA: 0x008B1454 File Offset: 0x008AF654
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int ShouldShowActorInfo(IntPtr l)
	{
		int result;
		try
		{
			BattleUITask battleUITask = (BattleUITask)LuaObject.checkSelf(l);
			BattleActor a;
			LuaObject.checkType<BattleActor>(l, 2, out a);
			bool b = battleUITask.m_luaExportHelper.ShouldShowActorInfo(a);
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

	// Token: 0x0601C31F RID: 115487 RVA: 0x008B14BC File Offset: 0x008AF6BC
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int BattleUIController_On3DTouch(IntPtr l)
	{
		int result;
		try
		{
			BattleUITask battleUITask = (BattleUITask)LuaObject.checkSelf(l);
			Vector2 pos;
			LuaObject.checkType(l, 2, out pos);
			battleUITask.m_luaExportHelper.BattleUIController_On3DTouch(pos);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601C320 RID: 115488 RVA: 0x008B1518 File Offset: 0x008AF718
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int PlaySelectHeroSound(IntPtr l)
	{
		int result;
		try
		{
			BattleUITask battleUITask = (BattleUITask)LuaObject.checkSelf(l);
			BattleActor a;
			LuaObject.checkType<BattleActor>(l, 2, out a);
			battleUITask.m_luaExportHelper.PlaySelectHeroSound(a);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601C321 RID: 115489 RVA: 0x008B1574 File Offset: 0x008AF774
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int BattleDialogUITask_OnClose(IntPtr l)
	{
		int result;
		try
		{
			BattleUITask battleUITask = (BattleUITask)LuaObject.checkSelf(l);
			bool isSkip;
			LuaObject.checkType(l, 2, out isSkip);
			battleUITask.m_luaExportHelper.BattleDialogUITask_OnClose(isSkip);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601C322 RID: 115490 RVA: 0x008B15D0 File Offset: 0x008AF7D0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int BattleTreasureDialogUIController_OnClose(IntPtr l)
	{
		int result;
		try
		{
			BattleUITask battleUITask = (BattleUITask)LuaObject.checkSelf(l);
			battleUITask.m_luaExportHelper.BattleTreasureDialogUIController_OnClose();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601C323 RID: 115491 RVA: 0x008B1624 File Offset: 0x008AF824
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int GetRewardGoodsUITask_OnStop(IntPtr l)
	{
		int result;
		try
		{
			BattleUITask battleUITask = (BattleUITask)LuaObject.checkSelf(l);
			Task task;
			LuaObject.checkType<Task>(l, 2, out task);
			battleUITask.m_luaExportHelper.GetRewardGoodsUITask_OnStop(task);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601C324 RID: 115492 RVA: 0x008B1680 File Offset: 0x008AF880
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int GetRewardGoodsUITask_OnClose(IntPtr l)
	{
		int result;
		try
		{
			BattleUITask battleUITask = (BattleUITask)LuaObject.checkSelf(l);
			battleUITask.m_luaExportHelper.GetRewardGoodsUITask_OnClose();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601C325 RID: 115493 RVA: 0x008B16D4 File Offset: 0x008AF8D4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int CombatUIController_OnAutoBattle(IntPtr l)
	{
		int result;
		try
		{
			BattleUITask battleUITask = (BattleUITask)LuaObject.checkSelf(l);
			bool on;
			LuaObject.checkType(l, 2, out on);
			battleUITask.m_luaExportHelper.CombatUIController_OnAutoBattle(on);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601C326 RID: 115494 RVA: 0x008B1730 File Offset: 0x008AF930
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int PreCombatUIController_OnOk(IntPtr l)
	{
		int result;
		try
		{
			BattleUITask battleUITask = (BattleUITask)LuaObject.checkSelf(l);
			battleUITask.m_luaExportHelper.PreCombatUIController_OnOk();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601C327 RID: 115495 RVA: 0x008B1784 File Offset: 0x008AF984
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int PreCombatUIController_OnCancel(IntPtr l)
	{
		int result;
		try
		{
			BattleUITask battleUITask = (BattleUITask)LuaObject.checkSelf(l);
			battleUITask.m_luaExportHelper.PreCombatUIController_OnCancel();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601C328 RID: 115496 RVA: 0x008B17D8 File Offset: 0x008AF9D8
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int PreCombatUIController_OnStop(IntPtr l)
	{
		int result;
		try
		{
			BattleUITask battleUITask = (BattleUITask)LuaObject.checkSelf(l);
			battleUITask.m_luaExportHelper.PreCombatUIController_OnStop();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601C329 RID: 115497 RVA: 0x008B182C File Offset: 0x008AFA2C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int BattleSceneUIController_OnPointerDown(IntPtr l)
	{
		int result;
		try
		{
			BattleUITask battleUITask = (BattleUITask)LuaObject.checkSelf(l);
			PointerEventData eventData;
			LuaObject.checkType<PointerEventData>(l, 2, out eventData);
			battleUITask.m_luaExportHelper.BattleSceneUIController_OnPointerDown(eventData);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601C32A RID: 115498 RVA: 0x008B1888 File Offset: 0x008AFA88
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int BattleSceneUIController_OnPointerUp(IntPtr l)
	{
		int result;
		try
		{
			BattleUITask battleUITask = (BattleUITask)LuaObject.checkSelf(l);
			PointerEventData eventData;
			LuaObject.checkType<PointerEventData>(l, 2, out eventData);
			battleUITask.m_luaExportHelper.BattleSceneUIController_OnPointerUp(eventData);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601C32B RID: 115499 RVA: 0x008B18E4 File Offset: 0x008AFAE4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int BattleSceneUIController_OnPointerClick(IntPtr l)
	{
		int result;
		try
		{
			BattleUITask battleUITask = (BattleUITask)LuaObject.checkSelf(l);
			PointerEventData eventData;
			LuaObject.checkType<PointerEventData>(l, 2, out eventData);
			battleUITask.m_luaExportHelper.BattleSceneUIController_OnPointerClick(eventData);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601C32C RID: 115500 RVA: 0x008B1940 File Offset: 0x008AFB40
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int BattleSceneUIController_OnBeginDrag(IntPtr l)
	{
		int result;
		try
		{
			BattleUITask battleUITask = (BattleUITask)LuaObject.checkSelf(l);
			PointerEventData eventData;
			LuaObject.checkType<PointerEventData>(l, 2, out eventData);
			battleUITask.m_luaExportHelper.BattleSceneUIController_OnBeginDrag(eventData);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601C32D RID: 115501 RVA: 0x008B199C File Offset: 0x008AFB9C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int BattleSceneUIController_OnEndDrag(IntPtr l)
	{
		int result;
		try
		{
			BattleUITask battleUITask = (BattleUITask)LuaObject.checkSelf(l);
			PointerEventData eventData;
			LuaObject.checkType<PointerEventData>(l, 2, out eventData);
			battleUITask.m_luaExportHelper.BattleSceneUIController_OnEndDrag(eventData);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601C32E RID: 115502 RVA: 0x008B19F8 File Offset: 0x008AFBF8
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int BattleSceneUIController_OnDrag(IntPtr l)
	{
		int result;
		try
		{
			BattleUITask battleUITask = (BattleUITask)LuaObject.checkSelf(l);
			PointerEventData eventData;
			LuaObject.checkType<PointerEventData>(l, 2, out eventData);
			battleUITask.m_luaExportHelper.BattleSceneUIController_OnDrag(eventData);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601C32F RID: 115503 RVA: 0x008B1A54 File Offset: 0x008AFC54
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int BattleSceneUIController_On3DTouch(IntPtr l)
	{
		int result;
		try
		{
			BattleUITask battleUITask = (BattleUITask)LuaObject.checkSelf(l);
			Vector2 p;
			LuaObject.checkType(l, 2, out p);
			battleUITask.m_luaExportHelper.BattleSceneUIController_On3DTouch(p);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601C330 RID: 115504 RVA: 0x008B1AB0 File Offset: 0x008AFCB0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int SendBattleCommands(IntPtr l)
	{
		int result;
		try
		{
			BattleUITask battleUITask = (BattleUITask)LuaObject.checkSelf(l);
			battleUITask.m_luaExportHelper.SendBattleCommands();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601C331 RID: 115505 RVA: 0x008B1B04 File Offset: 0x008AFD04
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int UpdateBattleRoomPlayerHeroStatus(IntPtr l)
	{
		int result;
		try
		{
			BattleUITask battleUITask = (BattleUITask)LuaObject.checkSelf(l);
			battleUITask.m_luaExportHelper.UpdateBattleRoomPlayerHeroStatus();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601C332 RID: 115506 RVA: 0x008B1B58 File Offset: 0x008AFD58
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int StartBattleRoomMyActionCountdown(IntPtr l)
	{
		int result;
		try
		{
			BattleUITask battleUITask = (BattleUITask)LuaObject.checkSelf(l);
			battleUITask.m_luaExportHelper.StartBattleRoomMyActionCountdown();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601C333 RID: 115507 RVA: 0x008B1BAC File Offset: 0x008AFDAC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int StopBattleRoomMyActionCountdown(IntPtr l)
	{
		int result;
		try
		{
			BattleUITask battleUITask = (BattleUITask)LuaObject.checkSelf(l);
			battleUITask.m_luaExportHelper.StopBattleRoomMyActionCountdown();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601C334 RID: 115508 RVA: 0x008B1C00 File Offset: 0x008AFE00
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int ActivateBattleRoomMyActionCountdown(IntPtr l)
	{
		int result;
		try
		{
			BattleUITask battleUITask = (BattleUITask)LuaObject.checkSelf(l);
			bool isActive;
			LuaObject.checkType(l, 2, out isActive);
			battleUITask.m_luaExportHelper.ActivateBattleRoomMyActionCountdown(isActive);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601C335 RID: 115509 RVA: 0x008B1C5C File Offset: 0x008AFE5C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int UpdateBattleRoomMyActionCountdown(IntPtr l)
	{
		int result;
		try
		{
			BattleUITask battleUITask = (BattleUITask)LuaObject.checkSelf(l);
			battleUITask.m_luaExportHelper.UpdateBattleRoomMyActionCountdown();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601C336 RID: 115510 RVA: 0x008B1CB0 File Offset: 0x008AFEB0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int StartBattleRoomOtherActionCountdown(IntPtr l)
	{
		int result;
		try
		{
			BattleUITask battleUITask = (BattleUITask)LuaObject.checkSelf(l);
			int playerIndex;
			LuaObject.checkType(l, 2, out playerIndex);
			battleUITask.m_luaExportHelper.StartBattleRoomOtherActionCountdown(playerIndex);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601C337 RID: 115511 RVA: 0x008B1D0C File Offset: 0x008AFF0C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int StopBattleRoomOtherActionCountdown(IntPtr l)
	{
		int result;
		try
		{
			BattleUITask battleUITask = (BattleUITask)LuaObject.checkSelf(l);
			battleUITask.m_luaExportHelper.StopBattleRoomOtherActionCountdown();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601C338 RID: 115512 RVA: 0x008B1D60 File Offset: 0x008AFF60
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int ActivateBattleRoomOtherActionCountdown(IntPtr l)
	{
		int result;
		try
		{
			BattleUITask battleUITask = (BattleUITask)LuaObject.checkSelf(l);
			bool isActive;
			LuaObject.checkType(l, 2, out isActive);
			battleUITask.m_luaExportHelper.ActivateBattleRoomOtherActionCountdown(isActive);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601C339 RID: 115513 RVA: 0x008B1DBC File Offset: 0x008AFFBC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int UpdateBattleRoomOtherActionCountdown(IntPtr l)
	{
		int result;
		try
		{
			BattleUITask battleUITask = (BattleUITask)LuaObject.checkSelf(l);
			battleUITask.m_luaExportHelper.UpdateBattleRoomOtherActionCountdown();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601C33A RID: 115514 RVA: 0x008B1E10 File Offset: 0x008B0010
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int BattleRoomSetAutoBattle(IntPtr l)
	{
		int result;
		try
		{
			BattleUITask battleUITask = (BattleUITask)LuaObject.checkSelf(l);
			bool on;
			LuaObject.checkType(l, 2, out on);
			battleUITask.m_luaExportHelper.BattleRoomSetAutoBattle(on);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601C33B RID: 115515 RVA: 0x008B1E6C File Offset: 0x008B006C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int ProcessBattlePendingNtfs(IntPtr l)
	{
		int result;
		try
		{
			BattleUITask battleUITask = (BattleUITask)LuaObject.checkSelf(l);
			battleUITask.m_luaExportHelper.ProcessBattlePendingNtfs();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601C33C RID: 115516 RVA: 0x008B1EC0 File Offset: 0x008B00C0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int PlayerContext_OnBattleRoomPlayerStatusChangedNtf(IntPtr l)
	{
		int result;
		try
		{
			BattleUITask battleUITask = (BattleUITask)LuaObject.checkSelf(l);
			ulong playerSessionId;
			LuaObject.checkType(l, 2, out playerSessionId);
			battleUITask.m_luaExportHelper.PlayerContext_OnBattleRoomPlayerStatusChangedNtf(playerSessionId);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601C33D RID: 115517 RVA: 0x008B1F1C File Offset: 0x008B011C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int PlayerContext_OnBattleRoomPlayerQuitNtf(IntPtr l)
	{
		int result;
		try
		{
			BattleUITask battleUITask = (BattleUITask)LuaObject.checkSelf(l);
			ulong playerSessionId;
			LuaObject.checkType(l, 2, out playerSessionId);
			BattleRoomQuitReason reason;
			LuaObject.checkEnum<BattleRoomQuitReason>(l, 3, out reason);
			battleUITask.m_luaExportHelper.PlayerContext_OnBattleRoomPlayerQuitNtf(playerSessionId, reason);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601C33E RID: 115518 RVA: 0x008B1F88 File Offset: 0x008B0188
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int PlayerContext_OnBattleRoomBattleCommandExecuteNtf(IntPtr l)
	{
		int result;
		try
		{
			BattleUITask battleUITask = (BattleUITask)LuaObject.checkSelf(l);
			ulong playerSessionId;
			LuaObject.checkType(l, 2, out playerSessionId);
			battleUITask.m_luaExportHelper.PlayerContext_OnBattleRoomBattleCommandExecuteNtf(playerSessionId);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601C33F RID: 115519 RVA: 0x008B1FE4 File Offset: 0x008B01E4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int PlayerContext_OnBattleRoomTeamBattleFinishNtf(IntPtr l)
	{
		int result;
		try
		{
			BattleUITask battleUITask = (BattleUITask)LuaObject.checkSelf(l);
			battleUITask.m_luaExportHelper.PlayerContext_OnBattleRoomTeamBattleFinishNtf();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601C340 RID: 115520 RVA: 0x008B2038 File Offset: 0x008B0238
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int PlayerContext_OnBattleRoomPVPBattleFinishNtf(IntPtr l)
	{
		int result;
		try
		{
			BattleUITask battleUITask = (BattleUITask)LuaObject.checkSelf(l);
			battleUITask.m_luaExportHelper.PlayerContext_OnBattleRoomPVPBattleFinishNtf();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601C341 RID: 115521 RVA: 0x008B208C File Offset: 0x008B028C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int PlayerContext_OnBattleRoomRealTimePVPBattleFinishNtf(IntPtr l)
	{
		int result;
		try
		{
			BattleUITask battleUITask = (BattleUITask)LuaObject.checkSelf(l);
			battleUITask.m_luaExportHelper.PlayerContext_OnBattleRoomRealTimePVPBattleFinishNtf();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601C342 RID: 115522 RVA: 0x008B20E0 File Offset: 0x008B02E0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int PlayerContext_OnBattleRoomGuildMassiveCombatBattleFinishNtf(IntPtr l)
	{
		int result;
		try
		{
			BattleUITask battleUITask = (BattleUITask)LuaObject.checkSelf(l);
			battleUITask.m_luaExportHelper.PlayerContext_OnBattleRoomGuildMassiveCombatBattleFinishNtf();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601C343 RID: 115523 RVA: 0x008B2134 File Offset: 0x008B0334
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int PlayerContext_OnBattleRoomPVPBattleJoinNtf(IntPtr l)
	{
		int result;
		try
		{
			BattleUITask battleUITask = (BattleUITask)LuaObject.checkSelf(l);
			battleUITask.m_luaExportHelper.PlayerContext_OnBattleRoomPVPBattleJoinNtf();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601C344 RID: 115524 RVA: 0x008B2188 File Offset: 0x008B0388
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int PlayerContext_OnPlayerInfoInitEnd(IntPtr l)
	{
		int result;
		try
		{
			BattleUITask battleUITask = (BattleUITask)LuaObject.checkSelf(l);
			battleUITask.m_luaExportHelper.PlayerContext_OnPlayerInfoInitEnd();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601C345 RID: 115525 RVA: 0x008B21DC File Offset: 0x008B03DC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int ReloginUITask_OnReloginSuccess(IntPtr l)
	{
		int result;
		try
		{
			BattleUITask battleUITask = (BattleUITask)LuaObject.checkSelf(l);
			battleUITask.m_luaExportHelper.ReloginUITask_OnReloginSuccess();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601C346 RID: 115526 RVA: 0x008B2230 File Offset: 0x008B0430
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int GetBattleRoom(IntPtr l)
	{
		int result;
		try
		{
			BattleUITask battleUITask = (BattleUITask)LuaObject.checkSelf(l);
			BattleRoom battleRoom = battleUITask.m_luaExportHelper.GetBattleRoom();
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, battleRoom);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601C347 RID: 115527 RVA: 0x008B228C File Offset: 0x008B048C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int UpdateBattleRoomPrepareTimeout(IntPtr l)
	{
		int result;
		try
		{
			BattleUITask battleUITask = (BattleUITask)LuaObject.checkSelf(l);
			battleUITask.m_luaExportHelper.UpdateBattleRoomPrepareTimeout();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601C348 RID: 115528 RVA: 0x008B22E0 File Offset: 0x008B04E0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int UpdateRealtimePVPBattlePrepareTimeout(IntPtr l)
	{
		int result;
		try
		{
			BattleUITask battleUITask = (BattleUITask)LuaObject.checkSelf(l);
			battleUITask.m_luaExportHelper.UpdateRealtimePVPBattlePrepareTimeout();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601C349 RID: 115529 RVA: 0x008B2334 File Offset: 0x008B0534
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int UpdateRealtimePVPBattlePrepareStatus(IntPtr l)
	{
		int result;
		try
		{
			BattleUITask battleUITask = (BattleUITask)LuaObject.checkSelf(l);
			battleUITask.m_luaExportHelper.UpdateRealtimePVPBattlePrepareStatus();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601C34A RID: 115530 RVA: 0x008B2388 File Offset: 0x008B0588
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int UpdateStageActorTag(IntPtr l)
	{
		int result;
		try
		{
			BattleUITask battleUITask = (BattleUITask)LuaObject.checkSelf(l);
			BattlePrepareStageActor sa;
			LuaObject.checkType<BattlePrepareStageActor>(l, 2, out sa);
			battleUITask.m_luaExportHelper.UpdateStageActorTag(sa);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601C34B RID: 115531 RVA: 0x008B23E4 File Offset: 0x008B05E4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int ProcessBattlePreparePendingNtfs(IntPtr l)
	{
		int result;
		try
		{
			BattleUITask battleUITask = (BattleUITask)LuaObject.checkSelf(l);
			bool playFx;
			LuaObject.checkType(l, 2, out playFx);
			battleUITask.m_luaExportHelper.ProcessBattlePreparePendingNtfs(playFx);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601C34C RID: 115532 RVA: 0x008B2440 File Offset: 0x008B0640
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int LoadAndUpdateBattleRoomStageActors(IntPtr l)
	{
		int result;
		try
		{
			BattleUITask battleUITask = (BattleUITask)LuaObject.checkSelf(l);
			List<int> posList;
			LuaObject.checkType<List<int>>(l, 2, out posList);
			bool playFx;
			LuaObject.checkType(l, 3, out playFx);
			battleUITask.m_luaExportHelper.LoadAndUpdateBattleRoomStageActors(posList, playFx);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601C34D RID: 115533 RVA: 0x008B24AC File Offset: 0x008B06AC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int UpdateBattleRoomStageActors(IntPtr l)
	{
		int result;
		try
		{
			BattleUITask battleUITask = (BattleUITask)LuaObject.checkSelf(l);
			int posIdx;
			LuaObject.checkType(l, 2, out posIdx);
			BattleHero hero;
			LuaObject.checkType<BattleHero>(l, 3, out hero);
			bool playFx;
			LuaObject.checkType(l, 4, out playFx);
			battleUITask.m_luaExportHelper.UpdateBattleRoomStageActors(posIdx, hero, playFx);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601C34E RID: 115534 RVA: 0x008B2524 File Offset: 0x008B0724
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int BattleRoomBattleStart(IntPtr l)
	{
		int result;
		try
		{
			BattleUITask battleUITask = (BattleUITask)LuaObject.checkSelf(l);
			battleUITask.m_luaExportHelper.BattleRoomBattleStart();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601C34F RID: 115535 RVA: 0x008B2578 File Offset: 0x008B0778
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int PVPBattlePrepareUIController_OnPrepareConfirm(IntPtr l)
	{
		int result;
		try
		{
			BattleUITask battleUITask = (BattleUITask)LuaObject.checkSelf(l);
			battleUITask.m_luaExportHelper.PVPBattlePrepareUIController_OnPrepareConfirm();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601C350 RID: 115536 RVA: 0x008B25CC File Offset: 0x008B07CC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int PlayerContext_OnBattleRoomHeroSetupNtf(IntPtr l)
	{
		int result;
		try
		{
			BattleUITask battleUITask = (BattleUITask)LuaObject.checkSelf(l);
			List<int> posList;
			LuaObject.checkType<List<int>>(l, 2, out posList);
			battleUITask.m_luaExportHelper.PlayerContext_OnBattleRoomHeroSetupNtf(posList);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601C351 RID: 115537 RVA: 0x008B2628 File Offset: 0x008B0828
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int PlayerContext_OnBattleRoomDataChangeNtf(IntPtr l)
	{
		int result;
		try
		{
			BattleUITask battleUITask = (BattleUITask)LuaObject.checkSelf(l);
			battleUITask.m_luaExportHelper.PlayerContext_OnBattleRoomDataChangeNtf();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601C352 RID: 115538 RVA: 0x008B267C File Offset: 0x008B087C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int PlayerContext_OnBattleRoomTeamBattleStartNtf(IntPtr l)
	{
		int result;
		try
		{
			BattleUITask battleUITask = (BattleUITask)LuaObject.checkSelf(l);
			battleUITask.m_luaExportHelper.PlayerContext_OnBattleRoomTeamBattleStartNtf();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601C353 RID: 115539 RVA: 0x008B26D0 File Offset: 0x008B08D0
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int PlayerContext_OnBattleRoomPVPBattleStartNtf(IntPtr l)
	{
		int result;
		try
		{
			BattleUITask battleUITask = (BattleUITask)LuaObject.checkSelf(l);
			battleUITask.m_luaExportHelper.PlayerContext_OnBattleRoomPVPBattleStartNtf();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601C354 RID: 115540 RVA: 0x008B2724 File Offset: 0x008B0924
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int PlayerContext_OnBattleRoomRealTimePVPBattleStartNtf(IntPtr l)
	{
		int result;
		try
		{
			BattleUITask battleUITask = (BattleUITask)LuaObject.checkSelf(l);
			battleUITask.m_luaExportHelper.PlayerContext_OnBattleRoomRealTimePVPBattleStartNtf();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601C355 RID: 115541 RVA: 0x008B2778 File Offset: 0x008B0978
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int ShowBattleResult(IntPtr l)
	{
		int result;
		try
		{
			BattleUITask battleUITask = (BattleUITask)LuaObject.checkSelf(l);
			BattleType battleType;
			LuaObject.checkEnum<BattleType>(l, 2, out battleType);
			int stars;
			LuaObject.checkType(l, 3, out stars);
			BattleReward battleReward;
			LuaObject.checkType<BattleReward>(l, 4, out battleReward);
			bool isFirstWin;
			LuaObject.checkType(l, 5, out isFirstWin);
			List<int> gotAchievements;
			LuaObject.checkType<List<int>>(l, 6, out gotAchievements);
			BattleLevelAchievement[] achievements;
			LuaObject.checkArray<BattleLevelAchievement>(l, 7, out achievements);
			battleUITask.m_luaExportHelper.ShowBattleResult(battleType, stars, battleReward, isFirstWin, gotAchievements, achievements);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601C356 RID: 115542 RVA: 0x008B2814 File Offset: 0x008B0A14
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int ShowBattleLose(IntPtr l)
	{
		int result;
		try
		{
			BattleUITask battleUITask = (BattleUITask)LuaObject.checkSelf(l);
			battleUITask.m_luaExportHelper.ShowBattleLose();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601C357 RID: 115543 RVA: 0x008B2868 File Offset: 0x008B0A68
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int ShowBattleReportEnd(IntPtr l)
	{
		int result;
		try
		{
			int total = LuaDLL.lua_gettop(l);
			if (LuaObject.matchType(l, total, 2, typeof(ArenaBattleReport)))
			{
				BattleUITask battleUITask = (BattleUITask)LuaObject.checkSelf(l);
				ArenaBattleReport battleReport;
				LuaObject.checkType<ArenaBattleReport>(l, 2, out battleReport);
				battleUITask.m_luaExportHelper.ShowBattleReportEnd(battleReport);
				LuaObject.pushValue(l, true);
				result = 1;
			}
			else if (LuaObject.matchType(l, total, 2, typeof(RealTimePVPBattleReport)))
			{
				BattleUITask battleUITask2 = (BattleUITask)LuaObject.checkSelf(l);
				RealTimePVPBattleReport battleReport2;
				LuaObject.checkType<RealTimePVPBattleReport>(l, 2, out battleReport2);
				battleUITask2.m_luaExportHelper.ShowBattleReportEnd(battleReport2);
				LuaObject.pushValue(l, true);
				result = 1;
			}
			else
			{
				LuaObject.pushValue(l, false);
				LuaDLL.lua_pushstring(l, "No matched override function ShowBattleReportEnd to call");
				result = 2;
			}
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601C358 RID: 115544 RVA: 0x008B2948 File Offset: 0x008B0B48
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int BuildBattleReport(IntPtr l)
	{
		int result;
		try
		{
			BattleUITask battleUITask = (BattleUITask)LuaObject.checkSelf(l);
			ProBattleReport o = battleUITask.m_luaExportHelper.BuildBattleReport();
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

	// Token: 0x0601C359 RID: 115545 RVA: 0x008B29A4 File Offset: 0x008B0BA4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int CheckBattleResult(IntPtr l)
	{
		int result;
		try
		{
			BattleUITask battleUITask = (BattleUITask)LuaObject.checkSelf(l);
			bool b = battleUITask.m_luaExportHelper.CheckBattleResult();
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

	// Token: 0x0601C35A RID: 115546 RVA: 0x008B2A00 File Offset: 0x008B0C00
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int SendBattleCheatGMCommand(IntPtr l)
	{
		int result;
		try
		{
			BattleUITask battleUITask = (BattleUITask)LuaObject.checkSelf(l);
			bool isCheat;
			LuaObject.checkType(l, 2, out isCheat);
			battleUITask.m_luaExportHelper.SendBattleCheatGMCommand(isCheat);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601C35B RID: 115547 RVA: 0x008B2A5C File Offset: 0x008B0C5C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int BattleResultEnd(IntPtr l)
	{
		int result;
		try
		{
			BattleUITask battleUITask = (BattleUITask)LuaObject.checkSelf(l);
			battleUITask.m_luaExportHelper.BattleResultEnd();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601C35C RID: 115548 RVA: 0x008B2AB0 File Offset: 0x008B0CB0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int BattleRoomInviteTeammateDialogBoxCallback(IntPtr l)
	{
		int result;
		try
		{
			BattleUITask battleUITask = (BattleUITask)LuaObject.checkSelf(l);
			DialogBoxResult r;
			LuaObject.checkEnum<DialogBoxResult>(l, 2, out r);
			battleUITask.m_luaExportHelper.BattleRoomInviteTeammateDialogBoxCallback(r);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601C35D RID: 115549 RVA: 0x008B2B0C File Offset: 0x008B0D0C
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int BattleUIController_OnWinOrLoseEnd(IntPtr l)
	{
		int result;
		try
		{
			BattleUITask battleUITask = (BattleUITask)LuaObject.checkSelf(l);
			battleUITask.m_luaExportHelper.BattleUIController_OnWinOrLoseEnd();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601C35E RID: 115550 RVA: 0x008B2B60 File Offset: 0x008B0D60
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int BattleResultUITask_OnStop(IntPtr l)
	{
		int result;
		try
		{
			BattleUITask battleUITask = (BattleUITask)LuaObject.checkSelf(l);
			Task task;
			LuaObject.checkType<Task>(l, 2, out task);
			battleUITask.m_luaExportHelper.BattleResultUITask_OnStop(task);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601C35F RID: 115551 RVA: 0x008B2BBC File Offset: 0x008B0DBC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int BattleResultUITask_OnClose(IntPtr l)
	{
		int result;
		try
		{
			BattleUITask battleUITask = (BattleUITask)LuaObject.checkSelf(l);
			battleUITask.m_luaExportHelper.BattleResultUITask_OnClose();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601C360 RID: 115552 RVA: 0x008B2C10 File Offset: 0x008B0E10
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int BattleResultScoreUITask_OnStop(IntPtr l)
	{
		int result;
		try
		{
			BattleUITask battleUITask = (BattleUITask)LuaObject.checkSelf(l);
			Task task;
			LuaObject.checkType<Task>(l, 2, out task);
			battleUITask.m_luaExportHelper.BattleResultScoreUITask_OnStop(task);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601C361 RID: 115553 RVA: 0x008B2C6C File Offset: 0x008B0E6C
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int BattleResultScoreUITask_OnClose(IntPtr l)
	{
		int result;
		try
		{
			BattleUITask battleUITask = (BattleUITask)LuaObject.checkSelf(l);
			battleUITask.m_luaExportHelper.BattleResultScoreUITask_OnClose();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601C362 RID: 115554 RVA: 0x008B2CC0 File Offset: 0x008B0EC0
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int BattleLoseUITask_OnStop(IntPtr l)
	{
		int result;
		try
		{
			BattleUITask battleUITask = (BattleUITask)LuaObject.checkSelf(l);
			Task task;
			LuaObject.checkType<Task>(l, 2, out task);
			battleUITask.m_luaExportHelper.BattleLoseUITask_OnStop(task);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601C363 RID: 115555 RVA: 0x008B2D1C File Offset: 0x008B0F1C
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int BattleLoseUITask_OnClose(IntPtr l)
	{
		int result;
		try
		{
			BattleUITask battleUITask = (BattleUITask)LuaObject.checkSelf(l);
			battleUITask.m_luaExportHelper.BattleLoseUITask_OnClose();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601C364 RID: 115556 RVA: 0x008B2D70 File Offset: 0x008B0F70
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int BattleReportEndUITask_OnStop(IntPtr l)
	{
		int result;
		try
		{
			BattleUITask battleUITask = (BattleUITask)LuaObject.checkSelf(l);
			Task task;
			LuaObject.checkType<Task>(l, 2, out task);
			battleUITask.m_luaExportHelper.BattleReportEndUITask_OnStop(task);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601C365 RID: 115557 RVA: 0x008B2DCC File Offset: 0x008B0FCC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int BattleReportEndUITask_OnClose(IntPtr l)
	{
		int result;
		try
		{
			BattleUITask battleUITask = (BattleUITask)LuaObject.checkSelf(l);
			battleUITask.m_luaExportHelper.BattleReportEndUITask_OnClose();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601C366 RID: 115558 RVA: 0x008B2E20 File Offset: 0x008B1020
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int BattleReportEndUITask_OnPlayAgain(IntPtr l)
	{
		int result;
		try
		{
			BattleUITask battleUITask = (BattleUITask)LuaObject.checkSelf(l);
			battleUITask.m_luaExportHelper.BattleReportEndUITask_OnPlayAgain();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601C367 RID: 115559 RVA: 0x008B2E74 File Offset: 0x008B1074
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int RegisterPlayerContextEvents(IntPtr l)
	{
		int result;
		try
		{
			BattleUITask battleUITask = (BattleUITask)LuaObject.checkSelf(l);
			battleUITask.m_luaExportHelper.RegisterPlayerContextEvents();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601C368 RID: 115560 RVA: 0x008B2EC8 File Offset: 0x008B10C8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int UnregisterPlayerContextEvents(IntPtr l)
	{
		int result;
		try
		{
			BattleUITask battleUITask = (BattleUITask)LuaObject.checkSelf(l);
			battleUITask.m_luaExportHelper.UnregisterPlayerContextEvents();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601C369 RID: 115561 RVA: 0x008B2F1C File Offset: 0x008B111C
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int InitBattleSceneUIController(IntPtr l)
	{
		int result;
		try
		{
			BattleUITask battleUITask = (BattleUITask)LuaObject.checkSelf(l);
			battleUITask.m_luaExportHelper.InitBattleSceneUIController();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601C36A RID: 115562 RVA: 0x008B2F70 File Offset: 0x008B1170
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int UninitBattleSceneUIController(IntPtr l)
	{
		int result;
		try
		{
			BattleUITask battleUITask = (BattleUITask)LuaObject.checkSelf(l);
			battleUITask.m_luaExportHelper.UninitBattleSceneUIController();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601C36B RID: 115563 RVA: 0x008B2FC4 File Offset: 0x008B11C4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int InitBattleUIController(IntPtr l)
	{
		int result;
		try
		{
			BattleUITask battleUITask = (BattleUITask)LuaObject.checkSelf(l);
			battleUITask.m_luaExportHelper.InitBattleUIController();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601C36C RID: 115564 RVA: 0x008B3018 File Offset: 0x008B1218
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int UninitBattleUIController(IntPtr l)
	{
		int result;
		try
		{
			BattleUITask battleUITask = (BattleUITask)LuaObject.checkSelf(l);
			battleUITask.m_luaExportHelper.UninitBattleUIController();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601C36D RID: 115565 RVA: 0x008B306C File Offset: 0x008B126C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int InitCombatUIController(IntPtr l)
	{
		int result;
		try
		{
			BattleUITask battleUITask = (BattleUITask)LuaObject.checkSelf(l);
			battleUITask.m_luaExportHelper.InitCombatUIController();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601C36E RID: 115566 RVA: 0x008B30C0 File Offset: 0x008B12C0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int UninitCombatUIController(IntPtr l)
	{
		int result;
		try
		{
			BattleUITask battleUITask = (BattleUITask)LuaObject.checkSelf(l);
			battleUITask.m_luaExportHelper.UninitCombatUIController();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601C36F RID: 115567 RVA: 0x008B3114 File Offset: 0x008B1314
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int InitPreCombatUIController(IntPtr l)
	{
		int result;
		try
		{
			BattleUITask battleUITask = (BattleUITask)LuaObject.checkSelf(l);
			battleUITask.m_luaExportHelper.InitPreCombatUIController();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601C370 RID: 115568 RVA: 0x008B3168 File Offset: 0x008B1368
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int UninitPreCombatUIController(IntPtr l)
	{
		int result;
		try
		{
			BattleUITask battleUITask = (BattleUITask)LuaObject.checkSelf(l);
			battleUITask.m_luaExportHelper.UninitPreCombatUIController();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601C371 RID: 115569 RVA: 0x008B31BC File Offset: 0x008B13BC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int InitBattleRoomUIController(IntPtr l)
	{
		int result;
		try
		{
			BattleUITask battleUITask = (BattleUITask)LuaObject.checkSelf(l);
			battleUITask.m_luaExportHelper.InitBattleRoomUIController();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601C372 RID: 115570 RVA: 0x008B3210 File Offset: 0x008B1410
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int UninitBattleRoomUIController(IntPtr l)
	{
		int result;
		try
		{
			BattleUITask battleUITask = (BattleUITask)LuaObject.checkSelf(l);
			battleUITask.m_luaExportHelper.UninitBattleRoomUIController();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601C373 RID: 115571 RVA: 0x008B3264 File Offset: 0x008B1464
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int InitBattleCommonUIController(IntPtr l)
	{
		int result;
		try
		{
			BattleUITask battleUITask = (BattleUITask)LuaObject.checkSelf(l);
			battleUITask.m_luaExportHelper.InitBattleCommonUIController();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601C374 RID: 115572 RVA: 0x008B32B8 File Offset: 0x008B14B8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int UninitBattleCommonUIController(IntPtr l)
	{
		int result;
		try
		{
			BattleUITask battleUITask = (BattleUITask)LuaObject.checkSelf(l);
			battleUITask.m_luaExportHelper.UninitBattleCommonUIController();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601C375 RID: 115573 RVA: 0x008B330C File Offset: 0x008B150C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int InitBattlePrepareUIController(IntPtr l)
	{
		int result;
		try
		{
			BattleUITask battleUITask = (BattleUITask)LuaObject.checkSelf(l);
			battleUITask.m_luaExportHelper.InitBattlePrepareUIController();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601C376 RID: 115574 RVA: 0x008B3360 File Offset: 0x008B1560
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int UninitBattlePrepareUIController(IntPtr l)
	{
		int result;
		try
		{
			BattleUITask battleUITask = (BattleUITask)LuaObject.checkSelf(l);
			battleUITask.m_luaExportHelper.UninitBattlePrepareUIController();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601C377 RID: 115575 RVA: 0x008B33B4 File Offset: 0x008B15B4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int BattleDialogUITask_OnLoadAllResCompleted(IntPtr l)
	{
		int result;
		try
		{
			BattleUITask battleUITask = (BattleUITask)LuaObject.checkSelf(l);
			battleUITask.m_luaExportHelper.BattleDialogUITask_OnLoadAllResCompleted();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601C378 RID: 115576 RVA: 0x008B3408 File Offset: 0x008B1608
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int StartBattleTeamSetNetTask(IntPtr l)
	{
		int result;
		try
		{
			BattleUITask battleUITask = (BattleUITask)LuaObject.checkSelf(l);
			BattleType battleType;
			LuaObject.checkEnum<BattleType>(l, 2, out battleType);
			int battleId;
			LuaObject.checkType(l, 3, out battleId);
			List<int> heros;
			LuaObject.checkType<List<int>>(l, 4, out heros);
			battleUITask.m_luaExportHelper.StartBattleTeamSetNetTask(battleType, battleId, heros);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601C379 RID: 115577 RVA: 0x008B3480 File Offset: 0x008B1680
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int StartLevelAttackNetTask(IntPtr l)
	{
		int result;
		try
		{
			BattleUITask battleUITask = (BattleUITask)LuaObject.checkSelf(l);
			battleUITask.m_luaExportHelper.StartLevelAttackNetTask();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601C37A RID: 115578 RVA: 0x008B34D4 File Offset: 0x008B16D4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int StartLevelWayPointMoveNetTask(IntPtr l)
	{
		int result;
		try
		{
			BattleUITask battleUITask = (BattleUITask)LuaObject.checkSelf(l);
			ConfigDataWaypointInfo waypointInfo;
			LuaObject.checkType<ConfigDataWaypointInfo>(l, 2, out waypointInfo);
			battleUITask.m_luaExportHelper.StartLevelWayPointMoveNetTask(waypointInfo);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601C37B RID: 115579 RVA: 0x008B3530 File Offset: 0x008B1730
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int StartLevelScenarioHandleNetTask(IntPtr l)
	{
		int result;
		try
		{
			BattleUITask battleUITask = (BattleUITask)LuaObject.checkSelf(l);
			ConfigDataScenarioInfo scenarioInfo;
			LuaObject.checkType<ConfigDataScenarioInfo>(l, 2, out scenarioInfo);
			battleUITask.m_luaExportHelper.StartLevelScenarioHandleNetTask(scenarioInfo);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601C37C RID: 115580 RVA: 0x008B358C File Offset: 0x008B178C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int StartRiftLevelAttackNetTask(IntPtr l)
	{
		int result;
		try
		{
			BattleUITask battleUITask = (BattleUITask)LuaObject.checkSelf(l);
			ConfigDataRiftLevelInfo levelInfo;
			LuaObject.checkType<ConfigDataRiftLevelInfo>(l, 2, out levelInfo);
			battleUITask.m_luaExportHelper.StartRiftLevelAttackNetTask(levelInfo);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601C37D RID: 115581 RVA: 0x008B35E8 File Offset: 0x008B17E8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int StartHeroDungeonLevelAttackNetTask(IntPtr l)
	{
		int result;
		try
		{
			BattleUITask battleUITask = (BattleUITask)LuaObject.checkSelf(l);
			ConfigDataHeroDungeonLevelInfo levelInfo;
			LuaObject.checkType<ConfigDataHeroDungeonLevelInfo>(l, 2, out levelInfo);
			battleUITask.m_luaExportHelper.StartHeroDungeonLevelAttackNetTask(levelInfo);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601C37E RID: 115582 RVA: 0x008B3644 File Offset: 0x008B1844
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int StartAnikiLevelAttackNetTask(IntPtr l)
	{
		int result;
		try
		{
			BattleUITask battleUITask = (BattleUITask)LuaObject.checkSelf(l);
			ConfigDataAnikiLevelInfo levelInfo;
			LuaObject.checkType<ConfigDataAnikiLevelInfo>(l, 2, out levelInfo);
			battleUITask.m_luaExportHelper.StartAnikiLevelAttackNetTask(levelInfo);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601C37F RID: 115583 RVA: 0x008B36A0 File Offset: 0x008B18A0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int StartThearchyLevelAttackNetTask(IntPtr l)
	{
		int result;
		try
		{
			BattleUITask battleUITask = (BattleUITask)LuaObject.checkSelf(l);
			ConfigDataThearchyTrialLevelInfo levelInfo;
			LuaObject.checkType<ConfigDataThearchyTrialLevelInfo>(l, 2, out levelInfo);
			battleUITask.m_luaExportHelper.StartThearchyLevelAttackNetTask(levelInfo);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601C380 RID: 115584 RVA: 0x008B36FC File Offset: 0x008B18FC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int StartMemoryCorridorLevelAttackNetTask(IntPtr l)
	{
		int result;
		try
		{
			BattleUITask battleUITask = (BattleUITask)LuaObject.checkSelf(l);
			ConfigDataMemoryCorridorLevelInfo levelInfo;
			LuaObject.checkType<ConfigDataMemoryCorridorLevelInfo>(l, 2, out levelInfo);
			battleUITask.m_luaExportHelper.StartMemoryCorridorLevelAttackNetTask(levelInfo);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601C381 RID: 115585 RVA: 0x008B3758 File Offset: 0x008B1958
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int StartHeroTrainningLevelAttackNetTask(IntPtr l)
	{
		int result;
		try
		{
			BattleUITask battleUITask = (BattleUITask)LuaObject.checkSelf(l);
			ConfigDataHeroTrainningLevelInfo levelInfo;
			LuaObject.checkType<ConfigDataHeroTrainningLevelInfo>(l, 2, out levelInfo);
			battleUITask.m_luaExportHelper.StartHeroTrainningLevelAttackNetTask(levelInfo);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601C382 RID: 115586 RVA: 0x008B37B4 File Offset: 0x008B19B4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int StartHeroPhantomLevelAttackNetTask(IntPtr l)
	{
		int result;
		try
		{
			BattleUITask battleUITask = (BattleUITask)LuaObject.checkSelf(l);
			ConfigDataHeroPhantomLevelInfo levelInfo;
			LuaObject.checkType<ConfigDataHeroPhantomLevelInfo>(l, 2, out levelInfo);
			battleUITask.m_luaExportHelper.StartHeroPhantomLevelAttackNetTask(levelInfo);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601C383 RID: 115587 RVA: 0x008B3810 File Offset: 0x008B1A10
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int StartTreasureLevelAttackNetTask(IntPtr l)
	{
		int result;
		try
		{
			BattleUITask battleUITask = (BattleUITask)LuaObject.checkSelf(l);
			ConfigDataTreasureLevelInfo levelInfo;
			LuaObject.checkType<ConfigDataTreasureLevelInfo>(l, 2, out levelInfo);
			battleUITask.m_luaExportHelper.StartTreasureLevelAttackNetTask(levelInfo);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601C384 RID: 115588 RVA: 0x008B386C File Offset: 0x008B1A6C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int StartUnchartedScoreLevelAttackNetTask(IntPtr l)
	{
		int result;
		try
		{
			BattleUITask battleUITask = (BattleUITask)LuaObject.checkSelf(l);
			ConfigDataScoreLevelInfo levelInfo;
			LuaObject.checkType<ConfigDataScoreLevelInfo>(l, 2, out levelInfo);
			battleUITask.m_luaExportHelper.StartUnchartedScoreLevelAttackNetTask(levelInfo);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601C385 RID: 115589 RVA: 0x008B38C8 File Offset: 0x008B1AC8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int StartUnchartedChallengeLevelAttackNetTask(IntPtr l)
	{
		int result;
		try
		{
			BattleUITask battleUITask = (BattleUITask)LuaObject.checkSelf(l);
			ConfigDataChallengeLevelInfo levelInfo;
			LuaObject.checkType<ConfigDataChallengeLevelInfo>(l, 2, out levelInfo);
			battleUITask.m_luaExportHelper.StartUnchartedChallengeLevelAttackNetTask(levelInfo);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601C386 RID: 115590 RVA: 0x008B3924 File Offset: 0x008B1B24
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int StartClimbTowerLevelAttackNetTask(IntPtr l)
	{
		int result;
		try
		{
			BattleUITask battleUITask = (BattleUITask)LuaObject.checkSelf(l);
			ConfigDataTowerFloorInfo floorInfo;
			LuaObject.checkType<ConfigDataTowerFloorInfo>(l, 2, out floorInfo);
			battleUITask.m_luaExportHelper.StartClimbTowerLevelAttackNetTask(floorInfo);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601C387 RID: 115591 RVA: 0x008B3980 File Offset: 0x008B1B80
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int StartGuildMassiveCombatAttackNetTask(IntPtr l)
	{
		int result;
		try
		{
			BattleUITask battleUITask = (BattleUITask)LuaObject.checkSelf(l);
			ConfigDataGuildMassiveCombatLevelInfo levelInfo;
			LuaObject.checkType<ConfigDataGuildMassiveCombatLevelInfo>(l, 2, out levelInfo);
			List<int> heroIds;
			LuaObject.checkType<List<int>>(l, 3, out heroIds);
			battleUITask.m_luaExportHelper.StartGuildMassiveCombatAttackNetTask(levelInfo, heroIds);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601C388 RID: 115592 RVA: 0x008B39EC File Offset: 0x008B1BEC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int StartArenaOpponentAttackFightingNetTask(IntPtr l)
	{
		int result;
		try
		{
			BattleUITask battleUITask = (BattleUITask)LuaObject.checkSelf(l);
			battleUITask.m_luaExportHelper.StartArenaOpponentAttackFightingNetTask();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601C389 RID: 115593 RVA: 0x008B3A40 File Offset: 0x008B1C40
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int HandleLevelAttackNetTaskResult(IntPtr l)
	{
		int result2;
		try
		{
			BattleUITask battleUITask = (BattleUITask)LuaObject.checkSelf(l);
			int result;
			LuaObject.checkType(l, 2, out result);
			battleUITask.m_luaExportHelper.HandleLevelAttackNetTaskResult(result);
			LuaObject.pushValue(l, true);
			result2 = 1;
		}
		catch (Exception e)
		{
			result2 = LuaObject.error(l, e);
		}
		return result2;
	}

	// Token: 0x0601C38A RID: 115594 RVA: 0x008B3A9C File Offset: 0x008B1C9C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int StartWayPointBattleFinishedNetTask(IntPtr l)
	{
		int result;
		try
		{
			BattleUITask battleUITask = (BattleUITask)LuaObject.checkSelf(l);
			ConfigDataWaypointInfo wayPointInfo;
			LuaObject.checkType<ConfigDataWaypointInfo>(l, 2, out wayPointInfo);
			battleUITask.m_luaExportHelper.StartWayPointBattleFinishedNetTask(wayPointInfo);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601C38B RID: 115595 RVA: 0x008B3AF8 File Offset: 0x008B1CF8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int StartRiftLevelBattleFinishedNetTask(IntPtr l)
	{
		int result;
		try
		{
			BattleUITask battleUITask = (BattleUITask)LuaObject.checkSelf(l);
			ConfigDataRiftLevelInfo levelInfo;
			LuaObject.checkType<ConfigDataRiftLevelInfo>(l, 2, out levelInfo);
			battleUITask.m_luaExportHelper.StartRiftLevelBattleFinishedNetTask(levelInfo);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601C38C RID: 115596 RVA: 0x008B3B54 File Offset: 0x008B1D54
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int StartHeroDungeonLevelBattleFinishedNetTask(IntPtr l)
	{
		int result;
		try
		{
			BattleUITask battleUITask = (BattleUITask)LuaObject.checkSelf(l);
			ConfigDataHeroDungeonLevelInfo levelInfo;
			LuaObject.checkType<ConfigDataHeroDungeonLevelInfo>(l, 2, out levelInfo);
			battleUITask.m_luaExportHelper.StartHeroDungeonLevelBattleFinishedNetTask(levelInfo);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601C38D RID: 115597 RVA: 0x008B3BB0 File Offset: 0x008B1DB0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int StartAnikiLevelBattleFinishedNetTask(IntPtr l)
	{
		int result;
		try
		{
			BattleUITask battleUITask = (BattleUITask)LuaObject.checkSelf(l);
			ConfigDataAnikiLevelInfo levelInfo;
			LuaObject.checkType<ConfigDataAnikiLevelInfo>(l, 2, out levelInfo);
			battleUITask.m_luaExportHelper.StartAnikiLevelBattleFinishedNetTask(levelInfo);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601C38E RID: 115598 RVA: 0x008B3C0C File Offset: 0x008B1E0C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int StartThearchyLevelBattleFinishedNetTask(IntPtr l)
	{
		int result;
		try
		{
			BattleUITask battleUITask = (BattleUITask)LuaObject.checkSelf(l);
			ConfigDataThearchyTrialLevelInfo levelInfo;
			LuaObject.checkType<ConfigDataThearchyTrialLevelInfo>(l, 2, out levelInfo);
			battleUITask.m_luaExportHelper.StartThearchyLevelBattleFinishedNetTask(levelInfo);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601C38F RID: 115599 RVA: 0x008B3C68 File Offset: 0x008B1E68
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int StartTreasureLevelBattleFinishedNetTask(IntPtr l)
	{
		int result;
		try
		{
			BattleUITask battleUITask = (BattleUITask)LuaObject.checkSelf(l);
			ConfigDataTreasureLevelInfo levelInfo;
			LuaObject.checkType<ConfigDataTreasureLevelInfo>(l, 2, out levelInfo);
			battleUITask.m_luaExportHelper.StartTreasureLevelBattleFinishedNetTask(levelInfo);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601C390 RID: 115600 RVA: 0x008B3CC4 File Offset: 0x008B1EC4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int StartMemoryCorridorLevelBattleFinishedNetTask(IntPtr l)
	{
		int result;
		try
		{
			BattleUITask battleUITask = (BattleUITask)LuaObject.checkSelf(l);
			ConfigDataMemoryCorridorLevelInfo levelInfo;
			LuaObject.checkType<ConfigDataMemoryCorridorLevelInfo>(l, 2, out levelInfo);
			battleUITask.m_luaExportHelper.StartMemoryCorridorLevelBattleFinishedNetTask(levelInfo);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601C391 RID: 115601 RVA: 0x008B3D20 File Offset: 0x008B1F20
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int StartHeroTrainningLevelBattleFinishedNetTask(IntPtr l)
	{
		int result;
		try
		{
			BattleUITask battleUITask = (BattleUITask)LuaObject.checkSelf(l);
			ConfigDataHeroTrainningLevelInfo levelInfo;
			LuaObject.checkType<ConfigDataHeroTrainningLevelInfo>(l, 2, out levelInfo);
			battleUITask.m_luaExportHelper.StartHeroTrainningLevelBattleFinishedNetTask(levelInfo);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601C392 RID: 115602 RVA: 0x008B3D7C File Offset: 0x008B1F7C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int StartHeroPhantomLevelBattleFinishedNetTask(IntPtr l)
	{
		int result;
		try
		{
			BattleUITask battleUITask = (BattleUITask)LuaObject.checkSelf(l);
			ConfigDataHeroPhantomLevelInfo levelInfo;
			LuaObject.checkType<ConfigDataHeroPhantomLevelInfo>(l, 2, out levelInfo);
			battleUITask.m_luaExportHelper.StartHeroPhantomLevelBattleFinishedNetTask(levelInfo);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601C393 RID: 115603 RVA: 0x008B3DD8 File Offset: 0x008B1FD8
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int StartUnchartedScoreLevelBattleFinishedNetTask(IntPtr l)
	{
		int result;
		try
		{
			BattleUITask battleUITask = (BattleUITask)LuaObject.checkSelf(l);
			ConfigDataScoreLevelInfo levelInfo;
			LuaObject.checkType<ConfigDataScoreLevelInfo>(l, 2, out levelInfo);
			battleUITask.m_luaExportHelper.StartUnchartedScoreLevelBattleFinishedNetTask(levelInfo);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601C394 RID: 115604 RVA: 0x008B3E34 File Offset: 0x008B2034
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int StartUnchartedChallengeLevelBattleFinishedNetTask(IntPtr l)
	{
		int result;
		try
		{
			BattleUITask battleUITask = (BattleUITask)LuaObject.checkSelf(l);
			ConfigDataChallengeLevelInfo levelInfo;
			LuaObject.checkType<ConfigDataChallengeLevelInfo>(l, 2, out levelInfo);
			battleUITask.m_luaExportHelper.StartUnchartedChallengeLevelBattleFinishedNetTask(levelInfo);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601C395 RID: 115605 RVA: 0x008B3E90 File Offset: 0x008B2090
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int StartClimbTowerLevelBattleFinishedNetTask(IntPtr l)
	{
		int result;
		try
		{
			BattleUITask battleUITask = (BattleUITask)LuaObject.checkSelf(l);
			ConfigDataTowerFloorInfo floorInfo;
			LuaObject.checkType<ConfigDataTowerFloorInfo>(l, 2, out floorInfo);
			battleUITask.m_luaExportHelper.StartClimbTowerLevelBattleFinishedNetTask(floorInfo);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601C396 RID: 115606 RVA: 0x008B3EEC File Offset: 0x008B20EC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int StartGuildMassiveCombatSinglePVEBattleEndNetTask(IntPtr l)
	{
		int result;
		try
		{
			BattleUITask battleUITask = (BattleUITask)LuaObject.checkSelf(l);
			ConfigDataGuildMassiveCombatLevelInfo levelInfo;
			LuaObject.checkType<ConfigDataGuildMassiveCombatLevelInfo>(l, 2, out levelInfo);
			battleUITask.m_luaExportHelper.StartGuildMassiveCombatSinglePVEBattleEndNetTask(levelInfo);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601C397 RID: 115607 RVA: 0x008B3F48 File Offset: 0x008B2148
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int StartArenaBattleFinishedNetTask(IntPtr l)
	{
		int result;
		try
		{
			BattleUITask battleUITask = (BattleUITask)LuaObject.checkSelf(l);
			battleUITask.m_luaExportHelper.StartArenaBattleFinishedNetTask();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601C398 RID: 115608 RVA: 0x008B3F9C File Offset: 0x008B219C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int HandleBattleFinishedNetTaskResult(IntPtr l)
	{
		int result2;
		try
		{
			BattleUITask battleUITask = (BattleUITask)LuaObject.checkSelf(l);
			int result;
			LuaObject.checkType(l, 2, out result);
			bool isWin;
			LuaObject.checkType(l, 3, out isWin);
			BattleReward reward;
			LuaObject.checkType<BattleReward>(l, 4, out reward);
			int stars;
			LuaObject.checkType(l, 5, out stars);
			bool isFirstWin;
			LuaObject.checkType(l, 6, out isFirstWin);
			List<int> gotAchievements;
			LuaObject.checkType<List<int>>(l, 7, out gotAchievements);
			BattleLevelAchievement[] achievements;
			LuaObject.checkArray<BattleLevelAchievement>(l, 8, out achievements);
			battleUITask.m_luaExportHelper.HandleBattleFinishedNetTaskResult(result, isWin, reward, stars, isFirstWin, gotAchievements, achievements);
			LuaObject.pushValue(l, true);
			result2 = 1;
		}
		catch (Exception e)
		{
			result2 = LuaObject.error(l, e);
		}
		return result2;
	}

	// Token: 0x0601C399 RID: 115609 RVA: 0x008B4044 File Offset: 0x008B2244
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int StartBattleCancelNetTask(IntPtr l)
	{
		int result;
		try
		{
			BattleUITask battleUITask = (BattleUITask)LuaObject.checkSelf(l);
			battleUITask.m_luaExportHelper.StartBattleCancelNetTask();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601C39A RID: 115610 RVA: 0x008B4098 File Offset: 0x008B2298
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int StartDanmakuPostNetTask(IntPtr l)
	{
		int result;
		try
		{
			BattleUITask battleUITask = (BattleUITask)LuaObject.checkSelf(l);
			Action<int> onEnd;
			LuaObject.checkDelegate<Action<int>>(l, 2, out onEnd);
			battleUITask.m_luaExportHelper.StartDanmakuPostNetTask(onEnd);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601C39B RID: 115611 RVA: 0x008B40F4 File Offset: 0x008B22F4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int StartBattleRoomHeroSetupNetTask(IntPtr l)
	{
		int result;
		try
		{
			BattleUITask battleUITask = (BattleUITask)LuaObject.checkSelf(l);
			int heroId;
			LuaObject.checkType(l, 2, out heroId);
			int position;
			LuaObject.checkType(l, 3, out position);
			battleUITask.m_luaExportHelper.StartBattleRoomHeroSetupNetTask(heroId, position);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601C39C RID: 115612 RVA: 0x008B4160 File Offset: 0x008B2360
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int StartBattleRoomHeroSwapNetTask(IntPtr l)
	{
		int result;
		try
		{
			BattleUITask battleUITask = (BattleUITask)LuaObject.checkSelf(l);
			int position;
			LuaObject.checkType(l, 2, out position);
			int position2;
			LuaObject.checkType(l, 3, out position2);
			battleUITask.m_luaExportHelper.StartBattleRoomHeroSwapNetTask(position, position2);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601C39D RID: 115613 RVA: 0x008B41CC File Offset: 0x008B23CC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int StartBattleRoomHeroSetoffNetTask(IntPtr l)
	{
		int result;
		try
		{
			BattleUITask battleUITask = (BattleUITask)LuaObject.checkSelf(l);
			int position;
			LuaObject.checkType(l, 2, out position);
			battleUITask.m_luaExportHelper.StartBattleRoomHeroSetoffNetTask(position);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601C39E RID: 115614 RVA: 0x008B4228 File Offset: 0x008B2428
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int StartBattleRoomPlayerStatusChangeNetTask(IntPtr l)
	{
		int result;
		try
		{
			BattleUITask battleUITask = (BattleUITask)LuaObject.checkSelf(l);
			PlayerBattleStatus status;
			LuaObject.checkEnum<PlayerBattleStatus>(l, 2, out status);
			Action onOk;
			LuaObject.checkDelegate<Action>(l, 3, out onOk);
			battleUITask.m_luaExportHelper.StartBattleRoomPlayerStatusChangeNetTask(status, onOk);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601C39F RID: 115615 RVA: 0x008B4294 File Offset: 0x008B2494
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int StartBattleRoomQuitNetTask(IntPtr l)
	{
		int result;
		try
		{
			BattleUITask battleUITask = (BattleUITask)LuaObject.checkSelf(l);
			battleUITask.m_luaExportHelper.StartBattleRoomQuitNetTask();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601C3A0 RID: 115616 RVA: 0x008B42E8 File Offset: 0x008B24E8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int StartBattleRoomEndCurrentBPTurnNetTask(IntPtr l)
	{
		int result;
		try
		{
			BattleUITask battleUITask = (BattleUITask)LuaObject.checkSelf(l);
			Action onOk;
			LuaObject.checkDelegate<Action>(l, 2, out onOk);
			battleUITask.m_luaExportHelper.StartBattleRoomEndCurrentBPTurnNetTask(onOk);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601C3A1 RID: 115617 RVA: 0x008B4344 File Offset: 0x008B2544
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int StartBattleRoomPlayerActionBeginNetTask(IntPtr l)
	{
		int result;
		try
		{
			BattleUITask battleUITask = (BattleUITask)LuaObject.checkSelf(l);
			battleUITask.m_luaExportHelper.StartBattleRoomPlayerActionBeginNetTask();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601C3A2 RID: 115618 RVA: 0x008B4398 File Offset: 0x008B2598
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int SetupReachRegion(IntPtr l)
	{
		int result;
		try
		{
			BattleUITask battleUITask = (BattleUITask)LuaObject.checkSelf(l);
			bool isSkipBattlePrepare;
			LuaObject.checkType(l, 2, out isSkipBattlePrepare);
			List<GridPosition> o = battleUITask.m_luaExportHelper.SetupReachRegion(isSkipBattlePrepare);
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

	// Token: 0x0601C3A3 RID: 115619 RVA: 0x008B4400 File Offset: 0x008B2600
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int SetupBattlePauseUIController(IntPtr l)
	{
		int result;
		try
		{
			BattleUITask battleUITask = (BattleUITask)LuaObject.checkSelf(l);
			List<GridPosition> reachRegion;
			LuaObject.checkType<List<GridPosition>>(l, 2, out reachRegion);
			battleUITask.m_luaExportHelper.SetupBattlePauseUIController(reachRegion);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601C3A4 RID: 115620 RVA: 0x008B445C File Offset: 0x008B265C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int SetupBattlePauseUIAchievements(IntPtr l)
	{
		int result;
		try
		{
			BattleUITask battleUITask = (BattleUITask)LuaObject.checkSelf(l);
			battleUITask.m_luaExportHelper.SetupBattlePauseUIAchievements();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601C3A5 RID: 115621 RVA: 0x008B44B0 File Offset: 0x008B26B0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int GetWinConditionTargetPosition(IntPtr l)
	{
		int result;
		try
		{
			BattleUITask battleUITask = (BattleUITask)LuaObject.checkSelf(l);
			ConfigDataBattleWinConditionInfo winConditionInfo;
			LuaObject.checkType<ConfigDataBattleWinConditionInfo>(l, 2, out winConditionInfo);
			GridPosition winConditionTargetPosition = battleUITask.m_luaExportHelper.GetWinConditionTargetPosition(winConditionInfo);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, winConditionTargetPosition);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601C3A6 RID: 115622 RVA: 0x008B451C File Offset: 0x008B271C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int GetMyStageActorCountMax(IntPtr l)
	{
		int result;
		try
		{
			BattleUITask battleUITask = (BattleUITask)LuaObject.checkSelf(l);
			int myStageActorCountMax = battleUITask.m_luaExportHelper.GetMyStageActorCountMax();
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, myStageActorCountMax);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601C3A7 RID: 115623 RVA: 0x008B4578 File Offset: 0x008B2778
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int SetupMyHeros(IntPtr l)
	{
		int result;
		try
		{
			BattleUITask battleUITask = (BattleUITask)LuaObject.checkSelf(l);
			ConfigDataBattleInfo battleInfo;
			LuaObject.checkType<ConfigDataBattleInfo>(l, 2, out battleInfo);
			int number;
			LuaObject.checkType(l, 3, out number);
			bool isSkipBattlePrepare;
			LuaObject.checkType(l, 4, out isSkipBattlePrepare);
			List<int> o = battleUITask.m_luaExportHelper.SetupMyHeros(battleInfo, number, isSkipBattlePrepare);
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

	// Token: 0x0601C3A8 RID: 115624 RVA: 0x008B45FC File Offset: 0x008B27FC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int FillMyHeros(IntPtr l)
	{
		int result;
		try
		{
			BattleUITask battleUITask = (BattleUITask)LuaObject.checkSelf(l);
			List<int> heroIds;
			LuaObject.checkType<List<int>>(l, 2, out heroIds);
			int count;
			LuaObject.checkType(l, 3, out count);
			List<int> disableHeroIds;
			LuaObject.checkType<List<int>>(l, 4, out disableHeroIds);
			battleUITask.m_luaExportHelper.FillMyHeros(heroIds, count, disableHeroIds);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601C3A9 RID: 115625 RVA: 0x008B4674 File Offset: 0x008B2874
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int SetupStageActors(IntPtr l)
	{
		int result;
		try
		{
			BattleUITask battleUITask = (BattleUITask)LuaObject.checkSelf(l);
			bool isSkipBattlePrepare;
			LuaObject.checkType(l, 2, out isSkipBattlePrepare);
			battleUITask.m_luaExportHelper.SetupStageActors(isSkipBattlePrepare);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601C3AA RID: 115626 RVA: 0x008B46D0 File Offset: 0x008B28D0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int GetTowerBattleRuleInfo(IntPtr l)
	{
		int result;
		try
		{
			BattleUITask battleUITask = (BattleUITask)LuaObject.checkSelf(l);
			ConfigDataTowerBattleRuleInfo towerBattleRuleInfo = battleUITask.m_luaExportHelper.GetTowerBattleRuleInfo();
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, towerBattleRuleInfo);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601C3AB RID: 115627 RVA: 0x008B472C File Offset: 0x008B292C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int GetTowerBonusHeroGroupInfo(IntPtr l)
	{
		int result;
		try
		{
			BattleUITask battleUITask = (BattleUITask)LuaObject.checkSelf(l);
			ConfigDataTowerBonusHeroGroupInfo towerBonusHeroGroupInfo = battleUITask.m_luaExportHelper.GetTowerBonusHeroGroupInfo();
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, towerBonusHeroGroupInfo);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601C3AC RID: 115628 RVA: 0x008B4788 File Offset: 0x008B2988
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int IsTowerPowerUpHero(IntPtr l)
	{
		int result;
		try
		{
			BattleUITask battleUITask = (BattleUITask)LuaObject.checkSelf(l);
			BattleHero hero;
			LuaObject.checkType<BattleHero>(l, 2, out hero);
			bool b = battleUITask.m_luaExportHelper.IsTowerPowerUpHero(hero);
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

	// Token: 0x0601C3AD RID: 115629 RVA: 0x008B47F0 File Offset: 0x008B29F0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int GetGuildPlayerMassiveCombatInfo(IntPtr l)
	{
		int result;
		try
		{
			BattleUITask battleUITask = (BattleUITask)LuaObject.checkSelf(l);
			GuildPlayerMassiveCombatInfo guildPlayerMassiveCombatInfo = battleUITask.m_luaExportHelper.GetGuildPlayerMassiveCombatInfo();
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, guildPlayerMassiveCombatInfo);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601C3AE RID: 115630 RVA: 0x008B484C File Offset: 0x008B2A4C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int IsGuildMassiveCombatCampUpHero(IntPtr l)
	{
		int result;
		try
		{
			BattleUITask battleUITask = (BattleUITask)LuaObject.checkSelf(l);
			BattleHero hero;
			LuaObject.checkType<BattleHero>(l, 2, out hero);
			bool b = battleUITask.m_luaExportHelper.IsGuildMassiveCombatCampUpHero(hero);
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

	// Token: 0x0601C3AF RID: 115631 RVA: 0x008B48B4 File Offset: 0x008B2AB4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int GetHeroTagType(IntPtr l)
	{
		int result;
		try
		{
			BattleUITask battleUITask = (BattleUITask)LuaObject.checkSelf(l);
			BattleHero hero;
			LuaObject.checkType<BattleHero>(l, 2, out hero);
			StageActorTagType heroTagType = battleUITask.m_luaExportHelper.GetHeroTagType(hero);
			LuaObject.pushValue(l, true);
			LuaObject.pushEnum(l, (int)heroTagType);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601C3B0 RID: 115632 RVA: 0x008B491C File Offset: 0x008B2B1C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int LoadArenaAttackerHeroActionValue(IntPtr l)
	{
		int result;
		try
		{
			BattleUITask battleUITask = (BattleUITask)LuaObject.checkSelf(l);
			BattleHero hero;
			LuaObject.checkType<BattleHero>(l, 2, out hero);
			battleUITask.m_luaExportHelper.LoadArenaAttackerHeroActionValue(hero);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601C3B1 RID: 115633 RVA: 0x008B4978 File Offset: 0x008B2B78
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int ShowStagePositions(IntPtr l)
	{
		int result;
		try
		{
			BattleUITask battleUITask = (BattleUITask)LuaObject.checkSelf(l);
			battleUITask.m_luaExportHelper.ShowStagePositions();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601C3B2 RID: 115634 RVA: 0x008B49CC File Offset: 0x008B2BCC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int SetupBattlePrepareTreasures(IntPtr l)
	{
		int result;
		try
		{
			BattleUITask battleUITask = (BattleUITask)LuaObject.checkSelf(l);
			battleUITask.m_luaExportHelper.SetupBattlePrepareTreasures();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601C3B3 RID: 115635 RVA: 0x008B4A20 File Offset: 0x008B2C20
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int BuildBattleTeamSetups(IntPtr l)
	{
		int result;
		try
		{
			BattleUITask battleUITask = (BattleUITask)LuaObject.checkSelf(l);
			battleUITask.m_luaExportHelper.BuildBattleTeamSetups();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601C3B4 RID: 115636 RVA: 0x008B4A74 File Offset: 0x008B2C74
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int BuildBattleTeamSetup(IntPtr l)
	{
		int result;
		try
		{
			BattleUITask battleUITask = (BattleUITask)LuaObject.checkSelf(l);
			int team;
			LuaObject.checkType(l, 2, out team);
			bool saveHeroList;
			LuaObject.checkType(l, 3, out saveHeroList);
			battleUITask.m_luaExportHelper.BuildBattleTeamSetup(team, saveHeroList);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601C3B5 RID: 115637 RVA: 0x008B4AE0 File Offset: 0x008B2CE0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int GetSoldierCount(IntPtr l)
	{
		int result;
		try
		{
			BattleUITask battleUITask = (BattleUITask)LuaObject.checkSelf(l);
			int team;
			LuaObject.checkType(l, 2, out team);
			int soldierCount = battleUITask.m_luaExportHelper.GetSoldierCount(team);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, soldierCount);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601C3B6 RID: 115638 RVA: 0x008B4B48 File Offset: 0x008B2D48
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int SetTeamAndStartBattle(IntPtr l)
	{
		int result;
		try
		{
			BattleUITask battleUITask = (BattleUITask)LuaObject.checkSelf(l);
			battleUITask.m_luaExportHelper.SetTeamAndStartBattle();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601C3B7 RID: 115639 RVA: 0x008B4B9C File Offset: 0x008B2D9C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int StartBattlePrepareLoadState(IntPtr l)
	{
		int result;
		try
		{
			BattleUITask battleUITask = (BattleUITask)LuaObject.checkSelf(l);
			battleUITask.m_luaExportHelper.StartBattlePrepareLoadState();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601C3B8 RID: 115640 RVA: 0x008B4BF0 File Offset: 0x008B2DF0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int StartBattleLoadState(IntPtr l)
	{
		int result;
		try
		{
			BattleUITask battleUITask = (BattleUITask)LuaObject.checkSelf(l);
			battleUITask.m_luaExportHelper.StartBattleLoadState();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601C3B9 RID: 115641 RVA: 0x008B4C44 File Offset: 0x008B2E44
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int ShowMoveAndAttackRegion_Prepare(IntPtr l)
	{
		int result;
		try
		{
			BattleUITask battleUITask = (BattleUITask)LuaObject.checkSelf(l);
			GridPosition pos;
			LuaObject.checkValueType<GridPosition>(l, 2, out pos);
			battleUITask.m_luaExportHelper.ShowMoveAndAttackRegion_Prepare(pos);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601C3BA RID: 115642 RVA: 0x008B4CA0 File Offset: 0x008B2EA0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int UpdateArenaAttackerHeroIds(IntPtr l)
	{
		int result;
		try
		{
			BattleUITask battleUITask = (BattleUITask)LuaObject.checkSelf(l);
			battleUITask.m_luaExportHelper.UpdateArenaAttackerHeroIds();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601C3BB RID: 115643 RVA: 0x008B4CF4 File Offset: 0x008B2EF4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int GetPlayerTrainingTechs(IntPtr l)
	{
		int result;
		try
		{
			BattleUITask battleUITask = (BattleUITask)LuaObject.checkSelf(l);
			int team;
			LuaObject.checkType(l, 2, out team);
			int playerIndex;
			LuaObject.checkType(l, 3, out playerIndex);
			bool isNpc;
			LuaObject.checkType(l, 4, out isNpc);
			List<TrainingTech> playerTrainingTechs = battleUITask.m_luaExportHelper.GetPlayerTrainingTechs(team, playerIndex, isNpc);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, playerTrainingTechs);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601C3BC RID: 115644 RVA: 0x008B4D78 File Offset: 0x008B2F78
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int GetPlayerLevel(IntPtr l)
	{
		int result;
		try
		{
			BattleUITask battleUITask = (BattleUITask)LuaObject.checkSelf(l);
			int team;
			LuaObject.checkType(l, 2, out team);
			int playerIndex;
			LuaObject.checkType(l, 3, out playerIndex);
			int playerLevel = battleUITask.m_luaExportHelper.GetPlayerLevel(team, playerIndex);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, playerLevel);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601C3BD RID: 115645 RVA: 0x008B4DEC File Offset: 0x008B2FEC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int GetPlayerSessionId(IntPtr l)
	{
		int result;
		try
		{
			BattleUITask battleUITask = (BattleUITask)LuaObject.checkSelf(l);
			int playerIndex;
			LuaObject.checkType(l, 2, out playerIndex);
			ulong playerSessionId = battleUITask.m_luaExportHelper.GetPlayerSessionId(playerIndex);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, playerSessionId);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601C3BE RID: 115646 RVA: 0x008B4E54 File Offset: 0x008B3054
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int GetMyPlayerIndex(IntPtr l)
	{
		int result;
		try
		{
			BattleUITask battleUITask = (BattleUITask)LuaObject.checkSelf(l);
			int myPlayerIndex = battleUITask.m_luaExportHelper.GetMyPlayerIndex();
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, myPlayerIndex);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601C3BF RID: 115647 RVA: 0x008B4EB0 File Offset: 0x008B30B0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int IsBattlePrepareDisableCameraMove(IntPtr l)
	{
		int result;
		try
		{
			BattleUITask battleUITask = (BattleUITask)LuaObject.checkSelf(l);
			bool b = battleUITask.m_luaExportHelper.IsBattlePrepareDisableCameraMove();
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

	// Token: 0x0601C3C0 RID: 115648 RVA: 0x008B4F0C File Offset: 0x008B310C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int UpdateBattlePower(IntPtr l)
	{
		int result;
		try
		{
			BattleUITask battleUITask = (BattleUITask)LuaObject.checkSelf(l);
			battleUITask.m_luaExportHelper.UpdateBattlePower();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601C3C1 RID: 115649 RVA: 0x008B4F60 File Offset: 0x008B3160
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int BattlePrepareUIController_OnPauseBattle(IntPtr l)
	{
		int result;
		try
		{
			BattleUITask battleUITask = (BattleUITask)LuaObject.checkSelf(l);
			battleUITask.m_luaExportHelper.BattlePrepareUIController_OnPauseBattle();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601C3C2 RID: 115650 RVA: 0x008B4FB4 File Offset: 0x008B31B4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int BattlePrepareUIController_OnShowArmyRelation(IntPtr l)
	{
		int result;
		try
		{
			BattleUITask battleUITask = (BattleUITask)LuaObject.checkSelf(l);
			battleUITask.m_luaExportHelper.BattlePrepareUIController_OnShowArmyRelation();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601C3C3 RID: 115651 RVA: 0x008B5008 File Offset: 0x008B3208
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int BattlePrepareUIController_OnStart(IntPtr l)
	{
		int result;
		try
		{
			BattleUITask battleUITask = (BattleUITask)LuaObject.checkSelf(l);
			battleUITask.m_luaExportHelper.BattlePrepareUIController_OnStart();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601C3C4 RID: 115652 RVA: 0x008B505C File Offset: 0x008B325C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int BattlePrepareUIController_OnShowActionOrder(IntPtr l)
	{
		int result;
		try
		{
			BattleUITask battleUITask = (BattleUITask)LuaObject.checkSelf(l);
			battleUITask.m_luaExportHelper.BattlePrepareUIController_OnShowActionOrder();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601C3C5 RID: 115653 RVA: 0x008B50B0 File Offset: 0x008B32B0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int HeroNotFullDialogBoxCallback(IntPtr l)
	{
		int result;
		try
		{
			BattleUITask battleUITask = (BattleUITask)LuaObject.checkSelf(l);
			DialogBoxResult r;
			LuaObject.checkEnum<DialogBoxResult>(l, 2, out r);
			battleUITask.m_luaExportHelper.HeroNotFullDialogBoxCallback(r);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601C3C6 RID: 115654 RVA: 0x008B510C File Offset: 0x008B330C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int BattlePrepareUIController_OnTestOnStage(IntPtr l)
	{
		int result;
		try
		{
			BattleUITask battleUITask = (BattleUITask)LuaObject.checkSelf(l);
			battleUITask.m_luaExportHelper.BattlePrepareUIController_OnTestOnStage();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601C3C7 RID: 115655 RVA: 0x008B5160 File Offset: 0x008B3360
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int BattlePrepareUIController_OnShowMyActorInfo(IntPtr l)
	{
		int result;
		try
		{
			BattleUITask battleUITask = (BattleUITask)LuaObject.checkSelf(l);
			BattleHero hero;
			LuaObject.checkType<BattleHero>(l, 2, out hero);
			battleUITask.m_luaExportHelper.BattlePrepareUIController_OnShowMyActorInfo(hero);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601C3C8 RID: 115656 RVA: 0x008B51BC File Offset: 0x008B33BC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int BattlePrepareUIController_OnHideActorInfo(IntPtr l)
	{
		int result;
		try
		{
			BattleUITask battleUITask = (BattleUITask)LuaObject.checkSelf(l);
			battleUITask.m_luaExportHelper.BattlePrepareUIController_OnHideActorInfo();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601C3C9 RID: 115657 RVA: 0x008B5210 File Offset: 0x008B3410
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int BattlePrepareUIController_OnStageActorChange(IntPtr l)
	{
		int result;
		try
		{
			BattleUITask battleUITask = (BattleUITask)LuaObject.checkSelf(l);
			battleUITask.m_luaExportHelper.BattlePrepareUIController_OnStageActorChange();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601C3CA RID: 115658 RVA: 0x008B5264 File Offset: 0x008B3464
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int BattlePrepareUIController_OnHeroOnStage(IntPtr l)
	{
		int result;
		try
		{
			BattleUITask battleUITask = (BattleUITask)LuaObject.checkSelf(l);
			BattleHero hero;
			LuaObject.checkType<BattleHero>(l, 2, out hero);
			GridPosition pos;
			LuaObject.checkValueType<GridPosition>(l, 3, out pos);
			int team;
			LuaObject.checkType(l, 4, out team);
			battleUITask.m_luaExportHelper.BattlePrepareUIController_OnHeroOnStage(hero, pos, team);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601C3CB RID: 115659 RVA: 0x008B52DC File Offset: 0x008B34DC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int BattlePrepareUIController_OnActorOffStage(IntPtr l)
	{
		int result;
		try
		{
			BattleUITask battleUITask = (BattleUITask)LuaObject.checkSelf(l);
			BattlePrepareStageActor sa;
			LuaObject.checkType<BattlePrepareStageActor>(l, 2, out sa);
			battleUITask.m_luaExportHelper.BattlePrepareUIController_OnActorOffStage(sa);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601C3CC RID: 115660 RVA: 0x008B5338 File Offset: 0x008B3538
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int BattlePrepareUIController_OnStageActorMove(IntPtr l)
	{
		int result;
		try
		{
			BattleUITask battleUITask = (BattleUITask)LuaObject.checkSelf(l);
			BattlePrepareStageActor sa;
			LuaObject.checkType<BattlePrepareStageActor>(l, 2, out sa);
			GridPosition p;
			LuaObject.checkValueType<GridPosition>(l, 3, out p);
			battleUITask.m_luaExportHelper.BattlePrepareUIController_OnStageActorMove(sa, p);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601C3CD RID: 115661 RVA: 0x008B53A4 File Offset: 0x008B35A4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int BattlePrepareUIController_OnStageActorSwap(IntPtr l)
	{
		int result;
		try
		{
			BattleUITask battleUITask = (BattleUITask)LuaObject.checkSelf(l);
			BattlePrepareStageActor sa;
			LuaObject.checkType<BattlePrepareStageActor>(l, 2, out sa);
			BattlePrepareStageActor sa2;
			LuaObject.checkType<BattlePrepareStageActor>(l, 3, out sa2);
			battleUITask.m_luaExportHelper.BattlePrepareUIController_OnStageActorSwap(sa, sa2);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601C3CE RID: 115662 RVA: 0x008B5410 File Offset: 0x008B3610
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int BattlePrepareUIController_OnUpdateBattlePower(IntPtr l)
	{
		int result;
		try
		{
			BattleUITask battleUITask = (BattleUITask)LuaObject.checkSelf(l);
			battleUITask.m_luaExportHelper.BattlePrepareUIController_OnUpdateBattlePower();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601C3CF RID: 115663 RVA: 0x008B5464 File Offset: 0x008B3664
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int BattlePrepareUIController_OnShowChat(IntPtr l)
	{
		int result;
		try
		{
			BattleUITask battleUITask = (BattleUITask)LuaObject.checkSelf(l);
			battleUITask.m_luaExportHelper.BattlePrepareUIController_OnShowChat();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601C3D0 RID: 115664 RVA: 0x008B54B8 File Offset: 0x008B36B8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int BattlePrepareUIController_OnShowHelp(IntPtr l)
	{
		int result;
		try
		{
			BattleUITask battleUITask = (BattleUITask)LuaObject.checkSelf(l);
			battleUITask.m_luaExportHelper.BattlePrepareUIController_OnShowHelp();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601C3D1 RID: 115665 RVA: 0x008B550C File Offset: 0x008B370C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int BattlePrepareUIController_OnPointerDown(IntPtr l)
	{
		int result;
		try
		{
			BattleUITask battleUITask = (BattleUITask)LuaObject.checkSelf(l);
			PointerEventData.InputButton button;
			LuaObject.checkEnum<PointerEventData.InputButton>(l, 2, out button);
			Vector2 position;
			LuaObject.checkType(l, 3, out position);
			battleUITask.m_luaExportHelper.BattlePrepareUIController_OnPointerDown(button, position);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601C3D2 RID: 115666 RVA: 0x008B5578 File Offset: 0x008B3778
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int BattlePrepareUIController_OnPointerUp(IntPtr l)
	{
		int result;
		try
		{
			BattleUITask battleUITask = (BattleUITask)LuaObject.checkSelf(l);
			PointerEventData.InputButton button;
			LuaObject.checkEnum<PointerEventData.InputButton>(l, 2, out button);
			Vector2 position;
			LuaObject.checkType(l, 3, out position);
			battleUITask.m_luaExportHelper.BattlePrepareUIController_OnPointerUp(button, position);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601C3D3 RID: 115667 RVA: 0x008B55E4 File Offset: 0x008B37E4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int BattlePrepareUIController_OnBeginDragHero(IntPtr l)
	{
		int result;
		try
		{
			BattleUITask battleUITask = (BattleUITask)LuaObject.checkSelf(l);
			battleUITask.m_luaExportHelper.BattlePrepareUIController_OnBeginDragHero();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601C3D4 RID: 115668 RVA: 0x008B5638 File Offset: 0x008B3838
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int BattlePrepareUIController_OnEndDragHero(IntPtr l)
	{
		int result;
		try
		{
			BattleUITask battleUITask = (BattleUITask)LuaObject.checkSelf(l);
			battleUITask.m_luaExportHelper.BattlePrepareUIController_OnEndDragHero();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601C3D5 RID: 115669 RVA: 0x008B568C File Offset: 0x008B388C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int BattlePrepareActorInfoUIController_OnShowSelectSoldierPanel(IntPtr l)
	{
		int result;
		try
		{
			BattleUITask battleUITask = (BattleUITask)LuaObject.checkSelf(l);
			BattleHero hero;
			LuaObject.checkType<BattleHero>(l, 2, out hero);
			battleUITask.m_luaExportHelper.BattlePrepareActorInfoUIController_OnShowSelectSoldierPanel(hero);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601C3D6 RID: 115670 RVA: 0x008B56E8 File Offset: 0x008B38E8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int BattlePrepareActorInfoUIController_OnChangeSkill(IntPtr l)
	{
		int result;
		try
		{
			BattleUITask battleUITask = (BattleUITask)LuaObject.checkSelf(l);
			BattleHero hero;
			LuaObject.checkType<BattleHero>(l, 2, out hero);
			List<int> skillIds;
			LuaObject.checkType<List<int>>(l, 3, out skillIds);
			battleUITask.m_luaExportHelper.BattlePrepareActorInfoUIController_OnChangeSkill(hero, skillIds);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601C3D7 RID: 115671 RVA: 0x008B5754 File Offset: 0x008B3954
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int BattlePrepareActorInfoUIController_OnChangeSoldier(IntPtr l)
	{
		int result;
		try
		{
			BattleUITask battleUITask = (BattleUITask)LuaObject.checkSelf(l);
			BattleHero hero;
			LuaObject.checkType<BattleHero>(l, 2, out hero);
			int soldierId;
			LuaObject.checkType(l, 3, out soldierId);
			battleUITask.m_luaExportHelper.BattlePrepareActorInfoUIController_OnChangeSoldier(hero, soldierId);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601C3D8 RID: 115672 RVA: 0x008B57C0 File Offset: 0x008B39C0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int ActionOrderUIController_OnConfirm(IntPtr l)
	{
		int result;
		try
		{
			BattleUITask battleUITask = (BattleUITask)LuaObject.checkSelf(l);
			battleUITask.m_luaExportHelper.ActionOrderUIController_OnConfirm();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601C3D9 RID: 115673 RVA: 0x008B5814 File Offset: 0x008B3A14
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int SetUIStateRegret(IntPtr l)
	{
		int result;
		try
		{
			BattleUITask battleUITask = (BattleUITask)LuaObject.checkSelf(l);
			battleUITask.m_luaExportHelper.SetUIStateRegret();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601C3DA RID: 115674 RVA: 0x008B5868 File Offset: 0x008B3A68
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int IsRegretActive(IntPtr l)
	{
		int result;
		try
		{
			BattleUITask battleUITask = (BattleUITask)LuaObject.checkSelf(l);
			bool b = battleUITask.m_luaExportHelper.IsRegretActive();
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

	// Token: 0x0601C3DB RID: 115675 RVA: 0x008B58C4 File Offset: 0x008B3AC4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int CanUseRegret(IntPtr l)
	{
		int result;
		try
		{
			BattleUITask battleUITask = (BattleUITask)LuaObject.checkSelf(l);
			bool b = battleUITask.m_luaExportHelper.CanUseRegret();
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

	// Token: 0x0601C3DC RID: 115676 RVA: 0x008B5920 File Offset: 0x008B3B20
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int RegretGotoStep(IntPtr l)
	{
		int result;
		try
		{
			BattleUITask battleUITask = (BattleUITask)LuaObject.checkSelf(l);
			int step;
			LuaObject.checkType(l, 2, out step);
			battleUITask.m_luaExportHelper.RegretGotoStep(step);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601C3DD RID: 115677 RVA: 0x008B597C File Offset: 0x008B3B7C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int FindRegretStepIndex(IntPtr l)
	{
		int result;
		try
		{
			BattleUITask battleUITask = (BattleUITask)LuaObject.checkSelf(l);
			int step;
			LuaObject.checkType(l, 2, out step);
			int i = battleUITask.m_luaExportHelper.FindRegretStepIndex(step);
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

	// Token: 0x0601C3DE RID: 115678 RVA: 0x008B59E4 File Offset: 0x008B3BE4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int BattleUIController_OnRegretActive(IntPtr l)
	{
		int result;
		try
		{
			BattleUITask battleUITask = (BattleUITask)LuaObject.checkSelf(l);
			battleUITask.m_luaExportHelper.BattleUIController_OnRegretActive();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601C3DF RID: 115679 RVA: 0x008B5A38 File Offset: 0x008B3C38
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int BattleUIController_OnRegretConfirm(IntPtr l)
	{
		int result;
		try
		{
			BattleUITask battleUITask = (BattleUITask)LuaObject.checkSelf(l);
			battleUITask.m_luaExportHelper.BattleUIController_OnRegretConfirm();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601C3E0 RID: 115680 RVA: 0x008B5A8C File Offset: 0x008B3C8C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int BattleUIController_OnRegretCancel(IntPtr l)
	{
		int result;
		try
		{
			BattleUITask battleUITask = (BattleUITask)LuaObject.checkSelf(l);
			battleUITask.m_luaExportHelper.BattleUIController_OnRegretCancel();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601C3E1 RID: 115681 RVA: 0x008B5AE0 File Offset: 0x008B3CE0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int BattleUIController_OnRegretBackward(IntPtr l)
	{
		int result;
		try
		{
			BattleUITask battleUITask = (BattleUITask)LuaObject.checkSelf(l);
			battleUITask.m_luaExportHelper.BattleUIController_OnRegretBackward();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601C3E2 RID: 115682 RVA: 0x008B5B34 File Offset: 0x008B3D34
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int BattleUIController_OnRegretForward(IntPtr l)
	{
		int result;
		try
		{
			BattleUITask battleUITask = (BattleUITask)LuaObject.checkSelf(l);
			battleUITask.m_luaExportHelper.BattleUIController_OnRegretForward();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601C3E3 RID: 115683 RVA: 0x008B5B88 File Offset: 0x008B3D88
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int UserGuide_GetEnforceHeros(IntPtr l)
	{
		int result;
		try
		{
			BattleUITask battleUITask = (BattleUITask)LuaObject.checkSelf(l);
			List<int> o = battleUITask.m_luaExportHelper.UserGuide_GetEnforceHeros();
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

	// Token: 0x0601C3E4 RID: 115684 RVA: 0x008B5BE4 File Offset: 0x008B3DE4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int SetUserGuideBattleSettings(IntPtr l)
	{
		int result;
		try
		{
			BattleUITask battleUITask = (BattleUITask)LuaObject.checkSelf(l);
			battleUITask.m_luaExportHelper.SetUserGuideBattleSettings();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601C3E5 RID: 115685 RVA: 0x008B5C38 File Offset: 0x008B3E38
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_OnStart(IntPtr l)
	{
		int result;
		try
		{
			BattleUITask battleUITask = (BattleUITask)LuaObject.checkSelf(l);
			UIIntent intent;
			LuaObject.checkType<UIIntent>(l, 2, out intent);
			bool b = battleUITask.m_luaExportHelper.__callBase_OnStart(intent);
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

	// Token: 0x0601C3E6 RID: 115686 RVA: 0x008B5CA0 File Offset: 0x008B3EA0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_OnStop(IntPtr l)
	{
		int result;
		try
		{
			BattleUITask battleUITask = (BattleUITask)LuaObject.checkSelf(l);
			battleUITask.m_luaExportHelper.__callBase_OnStop();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601C3E7 RID: 115687 RVA: 0x008B5CF4 File Offset: 0x008B3EF4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_OnPause(IntPtr l)
	{
		int result;
		try
		{
			BattleUITask battleUITask = (BattleUITask)LuaObject.checkSelf(l);
			battleUITask.m_luaExportHelper.__callBase_OnPause();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601C3E8 RID: 115688 RVA: 0x008B5D48 File Offset: 0x008B3F48
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_OnResume(IntPtr l)
	{
		int result;
		try
		{
			BattleUITask battleUITask = (BattleUITask)LuaObject.checkSelf(l);
			UIIntent intent;
			LuaObject.checkType<UIIntent>(l, 2, out intent);
			bool b = battleUITask.m_luaExportHelper.__callBase_OnResume(intent);
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

	// Token: 0x0601C3E9 RID: 115689 RVA: 0x008B5DB0 File Offset: 0x008B3FB0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_OnNewIntent(IntPtr l)
	{
		int result;
		try
		{
			BattleUITask battleUITask = (BattleUITask)LuaObject.checkSelf(l);
			UIIntent intent;
			LuaObject.checkType<UIIntent>(l, 2, out intent);
			bool b = battleUITask.m_luaExportHelper.__callBase_OnNewIntent(intent);
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

	// Token: 0x0601C3EA RID: 115690 RVA: 0x008B5E18 File Offset: 0x008B4018
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_EnableUIInput(IntPtr l)
	{
		int result;
		try
		{
			BattleUITask battleUITask = (BattleUITask)LuaObject.checkSelf(l);
			bool isEnable;
			LuaObject.checkType(l, 2, out isEnable);
			bool? isGlobalEnable;
			LuaObject.checkNullable<bool>(l, 3, out isGlobalEnable);
			battleUITask.m_luaExportHelper.__callBase_EnableUIInput(isEnable, isGlobalEnable);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601C3EB RID: 115691 RVA: 0x008B5E84 File Offset: 0x008B4084
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_IsNeedLoadDynamicRes(IntPtr l)
	{
		int result;
		try
		{
			BattleUITask battleUITask = (BattleUITask)LuaObject.checkSelf(l);
			bool b = battleUITask.m_luaExportHelper.__callBase_IsNeedLoadDynamicRes();
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

	// Token: 0x0601C3EC RID: 115692 RVA: 0x008B5EE0 File Offset: 0x008B40E0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_CollectAllDynamicResForLoad(IntPtr l)
	{
		int result;
		try
		{
			BattleUITask battleUITask = (BattleUITask)LuaObject.checkSelf(l);
			List<string> o = battleUITask.m_luaExportHelper.__callBase_CollectAllDynamicResForLoad();
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

	// Token: 0x0601C3ED RID: 115693 RVA: 0x008B5F3C File Offset: 0x008B413C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_RegisterPlayerContextEvents(IntPtr l)
	{
		int result;
		try
		{
			BattleUITask battleUITask = (BattleUITask)LuaObject.checkSelf(l);
			battleUITask.m_luaExportHelper.__callBase_RegisterPlayerContextEvents();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601C3EE RID: 115694 RVA: 0x008B5F90 File Offset: 0x008B4190
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_UnregisterPlayerContextEvents(IntPtr l)
	{
		int result;
		try
		{
			BattleUITask battleUITask = (BattleUITask)LuaObject.checkSelf(l);
			battleUITask.m_luaExportHelper.__callBase_UnregisterPlayerContextEvents();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601C3EF RID: 115695 RVA: 0x008B5FE4 File Offset: 0x008B41E4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_PostUpdateView(IntPtr l)
	{
		int result;
		try
		{
			BattleUITask battleUITask = (BattleUITask)LuaObject.checkSelf(l);
			battleUITask.m_luaExportHelper.__callBase_PostUpdateView();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601C3F0 RID: 115696 RVA: 0x008B6038 File Offset: 0x008B4238
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_CollectPreloadResourceList(IntPtr l)
	{
		int result;
		try
		{
			BattleUITask battleUITask = (BattleUITask)LuaObject.checkSelf(l);
			battleUITask.m_luaExportHelper.__callBase_CollectPreloadResourceList();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601C3F1 RID: 115697 RVA: 0x008B608C File Offset: 0x008B428C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_ClearAssetList(IntPtr l)
	{
		int result;
		try
		{
			BattleUITask battleUITask = (BattleUITask)LuaObject.checkSelf(l);
			battleUITask.m_luaExportHelper.__callBase_ClearAssetList();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601C3F2 RID: 115698 RVA: 0x008B60E0 File Offset: 0x008B42E0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_CollectAsset(IntPtr l)
	{
		int result;
		try
		{
			BattleUITask battleUITask = (BattleUITask)LuaObject.checkSelf(l);
			string assetName;
			LuaObject.checkType(l, 2, out assetName);
			battleUITask.m_luaExportHelper.__callBase_CollectAsset(assetName);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601C3F3 RID: 115699 RVA: 0x008B613C File Offset: 0x008B433C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_CollectSpriteAsset(IntPtr l)
	{
		int result;
		try
		{
			BattleUITask battleUITask = (BattleUITask)LuaObject.checkSelf(l);
			string assetName;
			LuaObject.checkType(l, 2, out assetName);
			battleUITask.m_luaExportHelper.__callBase_CollectSpriteAsset(assetName);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601C3F4 RID: 115700 RVA: 0x008B6198 File Offset: 0x008B4398
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_CollectFxAsset(IntPtr l)
	{
		int result;
		try
		{
			BattleUITask battleUITask = (BattleUITask)LuaObject.checkSelf(l);
			string assetName;
			LuaObject.checkType(l, 2, out assetName);
			battleUITask.m_luaExportHelper.__callBase_CollectFxAsset(assetName);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601C3F5 RID: 115701 RVA: 0x008B61F4 File Offset: 0x008B43F4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_StartLoadCustomAssets(IntPtr l)
	{
		int result;
		try
		{
			BattleUITask battleUITask = (BattleUITask)LuaObject.checkSelf(l);
			Action onLoadCompleted;
			LuaObject.checkDelegate<Action>(l, 2, out onLoadCompleted);
			battleUITask.m_luaExportHelper.__callBase_StartLoadCustomAssets(onLoadCompleted);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601C3F6 RID: 115702 RVA: 0x008B6250 File Offset: 0x008B4450
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_IsLoadingCustomAssets(IntPtr l)
	{
		int result;
		try
		{
			BattleUITask battleUITask = (BattleUITask)LuaObject.checkSelf(l);
			bool b = battleUITask.m_luaExportHelper.__callBase_IsLoadingCustomAssets();
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

	// Token: 0x0601C3F7 RID: 115703 RVA: 0x008B62AC File Offset: 0x008B44AC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_IsPipeLineRunning(IntPtr l)
	{
		int result;
		try
		{
			BattleUITask battleUITask = (BattleUITask)LuaObject.checkSelf(l);
			bool b = battleUITask.m_luaExportHelper.__callBase_IsPipeLineRunning();
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

	// Token: 0x0601C3F8 RID: 115704 RVA: 0x008B6308 File Offset: 0x008B4508
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_IsOpeningUI(IntPtr l)
	{
		int result;
		try
		{
			BattleUITask battleUITask = (BattleUITask)LuaObject.checkSelf(l);
			bool b = battleUITask.m_luaExportHelper.__callBase_IsOpeningUI();
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

	// Token: 0x0601C3F9 RID: 115705 RVA: 0x008B6364 File Offset: 0x008B4564
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_ReturnPrevUITask(IntPtr l)
	{
		int result;
		try
		{
			BattleUITask battleUITask = (BattleUITask)LuaObject.checkSelf(l);
			UITaskBase o = battleUITask.m_luaExportHelper.__callBase_ReturnPrevUITask();
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

	// Token: 0x0601C3FA RID: 115706 RVA: 0x008B63C0 File Offset: 0x008B45C0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_ClearUnusedDynamicResourceCache(IntPtr l)
	{
		int result;
		try
		{
			BattleUITask battleUITask = (BattleUITask)LuaObject.checkSelf(l);
			battleUITask.m_luaExportHelper.__callBase_ClearUnusedDynamicResourceCache();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601C3FB RID: 115707 RVA: 0x008B6414 File Offset: 0x008B4614
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_OnMemoryWarning(IntPtr l)
	{
		int result;
		try
		{
			BattleUITask battleUITask = (BattleUITask)LuaObject.checkSelf(l);
			battleUITask.m_luaExportHelper.__callBase_OnMemoryWarning();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601C3FC RID: 115708 RVA: 0x008B6468 File Offset: 0x008B4668
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int StopSubUITask_s(IntPtr l)
	{
		int result;
		try
		{
			Type taskType;
			LuaObject.checkType(l, 1, out taskType);
			BattleUITask.LuaExportHelper.StopSubUITask(taskType);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601C3FD RID: 115709 RVA: 0x008B64B4 File Offset: 0x008B46B4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int UnloadAssetsAndStartWorldUITask_s(IntPtr l)
	{
		int result;
		try
		{
			BattleUITask.LuaExportHelper.UnloadAssetsAndStartWorldUITask();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601C3FE RID: 115710 RVA: 0x008B64F4 File Offset: 0x008B46F4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int Co_UnloadAssetsAndStartWorldUITask_s(IntPtr l)
	{
		int result;
		try
		{
			IEnumerator o = BattleUITask.LuaExportHelper.Co_UnloadAssetsAndStartWorldUITask();
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

	// Token: 0x0601C3FF RID: 115711 RVA: 0x008B653C File Offset: 0x008B473C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int WorldUITask_OnLoadAllResCompleted_s(IntPtr l)
	{
		int result;
		try
		{
			BattleUITask.LuaExportHelper.WorldUITask_OnLoadAllResCompleted();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601C400 RID: 115712 RVA: 0x008B657C File Offset: 0x008B477C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int GetUnchartedScoreInfo_s(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataUnchartedScoreInfo unchartedScoreInfo = BattleUITask.LuaExportHelper.GetUnchartedScoreInfo();
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, unchartedScoreInfo);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601C401 RID: 115713 RVA: 0x008B65C4 File Offset: 0x008B47C4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int GetHeroUnchartedScoreBonus_s(IntPtr l)
	{
		int result;
		try
		{
			BattleHero hero;
			LuaObject.checkType<BattleHero>(l, 1, out hero);
			int heroUnchartedScoreBonus = BattleUITask.LuaExportHelper.GetHeroUnchartedScoreBonus(hero);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, heroUnchartedScoreBonus);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601C402 RID: 115714 RVA: 0x008B6618 File Offset: 0x008B4818
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int CompareHero_s(IntPtr l)
	{
		int result;
		try
		{
			BattleHero h;
			LuaObject.checkType<BattleHero>(l, 1, out h);
			BattleHero h2;
			LuaObject.checkType<BattleHero>(l, 2, out h2);
			int i = BattleUITask.LuaExportHelper.CompareHero(h, h2);
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

	// Token: 0x0601C403 RID: 115715 RVA: 0x008B6678 File Offset: 0x008B4878
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int CompareHeroUnchartdScoreBonus_s(IntPtr l)
	{
		int result;
		try
		{
			BattleHero h;
			LuaObject.checkType<BattleHero>(l, 1, out h);
			BattleHero h2;
			LuaObject.checkType<BattleHero>(l, 2, out h2);
			int i = BattleUITask.LuaExportHelper.CompareHeroUnchartdScoreBonus(h, h2);
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

	// Token: 0x0601C404 RID: 115716 RVA: 0x008B66D8 File Offset: 0x008B48D8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int IsListElementsEqual_s(IntPtr l)
	{
		int result;
		try
		{
			List<int> list;
			LuaObject.checkType<List<int>>(l, 1, out list);
			List<int> list2;
			LuaObject.checkType<List<int>>(l, 2, out list2);
			bool b = BattleUITask.LuaExportHelper.IsListElementsEqual(list, list2);
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

	// Token: 0x0601C405 RID: 115717 RVA: 0x008B6738 File Offset: 0x008B4938
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int CompareHeroActionValue_s(IntPtr l)
	{
		int result;
		try
		{
			BattleHero hero;
			LuaObject.checkType<BattleHero>(l, 1, out hero);
			BattleHero hero2;
			LuaObject.checkType<BattleHero>(l, 2, out hero2);
			int i = BattleUITask.LuaExportHelper.CompareHeroActionValue(hero, hero2);
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

	// Token: 0x0601C406 RID: 115718 RVA: 0x008B6798 File Offset: 0x008B4998
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callDele_m_onActiveActorEvent_s(IntPtr l)
	{
		int result;
		try
		{
			ClientBattleActor obj;
			LuaObject.checkType<ClientBattleActor>(l, 1, out obj);
			BattleUITask.LuaExportHelper.__callDele_m_onActiveActorEvent(obj);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601C407 RID: 115719 RVA: 0x008B67E4 File Offset: 0x008B49E4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __clearDele_m_onActiveActorEvent_s(IntPtr l)
	{
		int result;
		try
		{
			ClientBattleActor obj;
			LuaObject.checkType<ClientBattleActor>(l, 1, out obj);
			BattleUITask.LuaExportHelper.__clearDele_m_onActiveActorEvent(obj);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601C408 RID: 115720 RVA: 0x008B6830 File Offset: 0x008B4A30
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callDele_m_onDeactiveActorEvent_s(IntPtr l)
	{
		int result;
		try
		{
			ClientBattleActor obj;
			LuaObject.checkType<ClientBattleActor>(l, 1, out obj);
			BattleUITask.LuaExportHelper.__callDele_m_onDeactiveActorEvent(obj);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601C409 RID: 115721 RVA: 0x008B687C File Offset: 0x008B4A7C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __clearDele_m_onDeactiveActorEvent_s(IntPtr l)
	{
		int result;
		try
		{
			ClientBattleActor obj;
			LuaObject.checkType<ClientBattleActor>(l, 1, out obj);
			BattleUITask.LuaExportHelper.__clearDele_m_onDeactiveActorEvent(obj);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601C40A RID: 115722 RVA: 0x008B68C8 File Offset: 0x008B4AC8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_BattleDanmakuLayerIndex(IntPtr l)
	{
		int result;
		try
		{
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, BattleUITask.LuaExportHelper.BattleDanmakuLayerIndex);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601C40B RID: 115723 RVA: 0x008B6910 File Offset: 0x008B4B10
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_BattleRoomLayerIndex(IntPtr l)
	{
		int result;
		try
		{
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, BattleUITask.LuaExportHelper.BattleRoomLayerIndex);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601C40C RID: 115724 RVA: 0x008B6958 File Offset: 0x008B4B58
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_BattleLayerIndex(IntPtr l)
	{
		int result;
		try
		{
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, BattleUITask.LuaExportHelper.BattleLayerIndex);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601C40D RID: 115725 RVA: 0x008B69A0 File Offset: 0x008B4BA0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_BattleActorInfoLayerIndex(IntPtr l)
	{
		int result;
		try
		{
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, BattleUITask.LuaExportHelper.BattleActorInfoLayerIndex);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601C40E RID: 115726 RVA: 0x008B69E8 File Offset: 0x008B4BE8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_BattlePrepareLayerIndex(IntPtr l)
	{
		int result;
		try
		{
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, BattleUITask.LuaExportHelper.BattlePrepareLayerIndex);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601C40F RID: 115727 RVA: 0x008B6A30 File Offset: 0x008B4C30
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_PVPBattlePrepareLayerIndex(IntPtr l)
	{
		int result;
		try
		{
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, BattleUITask.LuaExportHelper.PVPBattlePrepareLayerIndex);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601C410 RID: 115728 RVA: 0x008B6A78 File Offset: 0x008B4C78
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_BattlePrepareActorInfoLayerIndex(IntPtr l)
	{
		int result;
		try
		{
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, BattleUITask.LuaExportHelper.BattlePrepareActorInfoLayerIndex);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601C411 RID: 115729 RVA: 0x008B6AC0 File Offset: 0x008B4CC0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_ActionOrderLayerIndex(IntPtr l)
	{
		int result;
		try
		{
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, BattleUITask.LuaExportHelper.ActionOrderLayerIndex);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601C412 RID: 115730 RVA: 0x008B6B08 File Offset: 0x008B4D08
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_BattlePauseLayerIndex(IntPtr l)
	{
		int result;
		try
		{
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, BattleUITask.LuaExportHelper.BattlePauseLayerIndex);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601C413 RID: 115731 RVA: 0x008B6B50 File Offset: 0x008B4D50
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_BattleTreasureDialogLayerIndex(IntPtr l)
	{
		int result;
		try
		{
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, BattleUITask.LuaExportHelper.BattleTreasureDialogLayerIndex);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601C414 RID: 115732 RVA: 0x008B6B98 File Offset: 0x008B4D98
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_CombatLayerIndex(IntPtr l)
	{
		int result;
		try
		{
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, BattleUITask.LuaExportHelper.CombatLayerIndex);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601C415 RID: 115733 RVA: 0x008B6BE0 File Offset: 0x008B4DE0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_PreCombatLayerIndex(IntPtr l)
	{
		int result;
		try
		{
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, BattleUITask.LuaExportHelper.PreCombatLayerIndex);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601C416 RID: 115734 RVA: 0x008B6C28 File Offset: 0x008B4E28
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_BattleCommonLayerIndex(IntPtr l)
	{
		int result;
		try
		{
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, BattleUITask.LuaExportHelper.BattleCommonLayerIndex);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601C417 RID: 115735 RVA: 0x008B6C70 File Offset: 0x008B4E70
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_layerDescArray(IntPtr l)
	{
		int result;
		try
		{
			BattleUITask battleUITask = (BattleUITask)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, battleUITask.m_luaExportHelper.m_layerDescArray);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601C418 RID: 115736 RVA: 0x008B6CC8 File Offset: 0x008B4EC8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_layerDescArray(IntPtr l)
	{
		int result;
		try
		{
			BattleUITask battleUITask = (BattleUITask)LuaObject.checkSelf(l);
			UITaskBase.LayerDesc[] layerDescArray;
			LuaObject.checkArray<UITaskBase.LayerDesc>(l, 2, out layerDescArray);
			battleUITask.m_luaExportHelper.m_layerDescArray = layerDescArray;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601C419 RID: 115737 RVA: 0x008B6D24 File Offset: 0x008B4F24
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_uiCtrlDescArray(IntPtr l)
	{
		int result;
		try
		{
			BattleUITask battleUITask = (BattleUITask)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, battleUITask.m_luaExportHelper.m_uiCtrlDescArray);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601C41A RID: 115738 RVA: 0x008B6D7C File Offset: 0x008B4F7C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_uiCtrlDescArray(IntPtr l)
	{
		int result;
		try
		{
			BattleUITask battleUITask = (BattleUITask)LuaObject.checkSelf(l);
			UITaskBase.UIControllerDesc[] uiCtrlDescArray;
			LuaObject.checkArray<UITaskBase.UIControllerDesc>(l, 2, out uiCtrlDescArray);
			battleUITask.m_luaExportHelper.m_uiCtrlDescArray = uiCtrlDescArray;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601C41B RID: 115739 RVA: 0x008B6DD8 File Offset: 0x008B4FD8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_battleUIController(IntPtr l)
	{
		int result;
		try
		{
			BattleUITask battleUITask = (BattleUITask)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, battleUITask.m_luaExportHelper.m_battleUIController);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601C41C RID: 115740 RVA: 0x008B6E30 File Offset: 0x008B5030
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_battleUIController(IntPtr l)
	{
		int result;
		try
		{
			BattleUITask battleUITask = (BattleUITask)LuaObject.checkSelf(l);
			BattleUIController battleUIController;
			LuaObject.checkType<BattleUIController>(l, 2, out battleUIController);
			battleUITask.m_luaExportHelper.m_battleUIController = battleUIController;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601C41D RID: 115741 RVA: 0x008B6E8C File Offset: 0x008B508C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_battleDanmakuUIController(IntPtr l)
	{
		int result;
		try
		{
			BattleUITask battleUITask = (BattleUITask)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, battleUITask.m_luaExportHelper.m_battleDanmakuUIController);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601C41E RID: 115742 RVA: 0x008B6EE4 File Offset: 0x008B50E4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_battleDanmakuUIController(IntPtr l)
	{
		int result;
		try
		{
			BattleUITask battleUITask = (BattleUITask)LuaObject.checkSelf(l);
			BattleDanmakuUIController battleDanmakuUIController;
			LuaObject.checkType<BattleDanmakuUIController>(l, 2, out battleDanmakuUIController);
			battleUITask.m_luaExportHelper.m_battleDanmakuUIController = battleDanmakuUIController;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601C41F RID: 115743 RVA: 0x008B6F40 File Offset: 0x008B5140
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_battleActorInfoUIController(IntPtr l)
	{
		int result;
		try
		{
			BattleUITask battleUITask = (BattleUITask)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, battleUITask.m_luaExportHelper.m_battleActorInfoUIController);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601C420 RID: 115744 RVA: 0x008B6F98 File Offset: 0x008B5198
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_battleActorInfoUIController(IntPtr l)
	{
		int result;
		try
		{
			BattleUITask battleUITask = (BattleUITask)LuaObject.checkSelf(l);
			BattleActorInfoUIController battleActorInfoUIController;
			LuaObject.checkType<BattleActorInfoUIController>(l, 2, out battleActorInfoUIController);
			battleUITask.m_luaExportHelper.m_battleActorInfoUIController = battleActorInfoUIController;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601C421 RID: 115745 RVA: 0x008B6FF4 File Offset: 0x008B51F4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_battlePrepareUIController(IntPtr l)
	{
		int result;
		try
		{
			BattleUITask battleUITask = (BattleUITask)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, battleUITask.m_luaExportHelper.m_battlePrepareUIController);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601C422 RID: 115746 RVA: 0x008B704C File Offset: 0x008B524C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_battlePrepareUIController(IntPtr l)
	{
		int result;
		try
		{
			BattleUITask battleUITask = (BattleUITask)LuaObject.checkSelf(l);
			BattlePrepareUIController battlePrepareUIController;
			LuaObject.checkType<BattlePrepareUIController>(l, 2, out battlePrepareUIController);
			battleUITask.m_luaExportHelper.m_battlePrepareUIController = battlePrepareUIController;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601C423 RID: 115747 RVA: 0x008B70A8 File Offset: 0x008B52A8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_pvpBattlePrepareUIController(IntPtr l)
	{
		int result;
		try
		{
			BattleUITask battleUITask = (BattleUITask)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, battleUITask.m_luaExportHelper.m_pvpBattlePrepareUIController);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601C424 RID: 115748 RVA: 0x008B7100 File Offset: 0x008B5300
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_pvpBattlePrepareUIController(IntPtr l)
	{
		int result;
		try
		{
			BattleUITask battleUITask = (BattleUITask)LuaObject.checkSelf(l);
			PVPBattlePrepareUIController pvpBattlePrepareUIController;
			LuaObject.checkType<PVPBattlePrepareUIController>(l, 2, out pvpBattlePrepareUIController);
			battleUITask.m_luaExportHelper.m_pvpBattlePrepareUIController = pvpBattlePrepareUIController;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601C425 RID: 115749 RVA: 0x008B715C File Offset: 0x008B535C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_battlePrepareActorInfoUIController(IntPtr l)
	{
		int result;
		try
		{
			BattleUITask battleUITask = (BattleUITask)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, battleUITask.m_luaExportHelper.m_battlePrepareActorInfoUIController);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601C426 RID: 115750 RVA: 0x008B71B4 File Offset: 0x008B53B4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_battlePrepareActorInfoUIController(IntPtr l)
	{
		int result;
		try
		{
			BattleUITask battleUITask = (BattleUITask)LuaObject.checkSelf(l);
			BattlePrepareActorInfoUIController battlePrepareActorInfoUIController;
			LuaObject.checkType<BattlePrepareActorInfoUIController>(l, 2, out battlePrepareActorInfoUIController);
			battleUITask.m_luaExportHelper.m_battlePrepareActorInfoUIController = battlePrepareActorInfoUIController;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601C427 RID: 115751 RVA: 0x008B7210 File Offset: 0x008B5410
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_actionOrderUIController(IntPtr l)
	{
		int result;
		try
		{
			BattleUITask battleUITask = (BattleUITask)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, battleUITask.m_luaExportHelper.m_actionOrderUIController);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601C428 RID: 115752 RVA: 0x008B7268 File Offset: 0x008B5468
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_actionOrderUIController(IntPtr l)
	{
		int result;
		try
		{
			BattleUITask battleUITask = (BattleUITask)LuaObject.checkSelf(l);
			ActionOrderUIController actionOrderUIController;
			LuaObject.checkType<ActionOrderUIController>(l, 2, out actionOrderUIController);
			battleUITask.m_luaExportHelper.m_actionOrderUIController = actionOrderUIController;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601C429 RID: 115753 RVA: 0x008B72C4 File Offset: 0x008B54C4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_battlePauseUIController(IntPtr l)
	{
		int result;
		try
		{
			BattleUITask battleUITask = (BattleUITask)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, battleUITask.m_luaExportHelper.m_battlePauseUIController);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601C42A RID: 115754 RVA: 0x008B731C File Offset: 0x008B551C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_battlePauseUIController(IntPtr l)
	{
		int result;
		try
		{
			BattleUITask battleUITask = (BattleUITask)LuaObject.checkSelf(l);
			BattlePauseUIController battlePauseUIController;
			LuaObject.checkType<BattlePauseUIController>(l, 2, out battlePauseUIController);
			battleUITask.m_luaExportHelper.m_battlePauseUIController = battlePauseUIController;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601C42B RID: 115755 RVA: 0x008B7378 File Offset: 0x008B5578
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_battleTreasureDialogUIController(IntPtr l)
	{
		int result;
		try
		{
			BattleUITask battleUITask = (BattleUITask)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, battleUITask.m_luaExportHelper.m_battleTreasureDialogUIController);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601C42C RID: 115756 RVA: 0x008B73D0 File Offset: 0x008B55D0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_battleTreasureDialogUIController(IntPtr l)
	{
		int result;
		try
		{
			BattleUITask battleUITask = (BattleUITask)LuaObject.checkSelf(l);
			BattleTreasureDialogUIController battleTreasureDialogUIController;
			LuaObject.checkType<BattleTreasureDialogUIController>(l, 2, out battleTreasureDialogUIController);
			battleUITask.m_luaExportHelper.m_battleTreasureDialogUIController = battleTreasureDialogUIController;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601C42D RID: 115757 RVA: 0x008B742C File Offset: 0x008B562C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_combatUIController(IntPtr l)
	{
		int result;
		try
		{
			BattleUITask battleUITask = (BattleUITask)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, battleUITask.m_luaExportHelper.m_combatUIController);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601C42E RID: 115758 RVA: 0x008B7484 File Offset: 0x008B5684
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_combatUIController(IntPtr l)
	{
		int result;
		try
		{
			BattleUITask battleUITask = (BattleUITask)LuaObject.checkSelf(l);
			CombatUIController combatUIController;
			LuaObject.checkType<CombatUIController>(l, 2, out combatUIController);
			battleUITask.m_luaExportHelper.m_combatUIController = combatUIController;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601C42F RID: 115759 RVA: 0x008B74E0 File Offset: 0x008B56E0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_preCombatUIController(IntPtr l)
	{
		int result;
		try
		{
			BattleUITask battleUITask = (BattleUITask)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, battleUITask.m_luaExportHelper.m_preCombatUIController);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601C430 RID: 115760 RVA: 0x008B7538 File Offset: 0x008B5738
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_preCombatUIController(IntPtr l)
	{
		int result;
		try
		{
			BattleUITask battleUITask = (BattleUITask)LuaObject.checkSelf(l);
			PreCombatUIController preCombatUIController;
			LuaObject.checkType<PreCombatUIController>(l, 2, out preCombatUIController);
			battleUITask.m_luaExportHelper.m_preCombatUIController = preCombatUIController;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601C431 RID: 115761 RVA: 0x008B7594 File Offset: 0x008B5794
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_battleRoomUIController(IntPtr l)
	{
		int result;
		try
		{
			BattleUITask battleUITask = (BattleUITask)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, battleUITask.m_luaExportHelper.m_battleRoomUIController);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601C432 RID: 115762 RVA: 0x008B75EC File Offset: 0x008B57EC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_battleRoomUIController(IntPtr l)
	{
		int result;
		try
		{
			BattleUITask battleUITask = (BattleUITask)LuaObject.checkSelf(l);
			BattleRoomUIController battleRoomUIController;
			LuaObject.checkType<BattleRoomUIController>(l, 2, out battleRoomUIController);
			battleUITask.m_luaExportHelper.m_battleRoomUIController = battleRoomUIController;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601C433 RID: 115763 RVA: 0x008B7648 File Offset: 0x008B5848
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_battleCommonUIController(IntPtr l)
	{
		int result;
		try
		{
			BattleUITask battleUITask = (BattleUITask)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, battleUITask.m_luaExportHelper.m_battleCommonUIController);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601C434 RID: 115764 RVA: 0x008B76A0 File Offset: 0x008B58A0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_battleCommonUIController(IntPtr l)
	{
		int result;
		try
		{
			BattleUITask battleUITask = (BattleUITask)LuaObject.checkSelf(l);
			BattleCommonUIController battleCommonUIController;
			LuaObject.checkType<BattleCommonUIController>(l, 2, out battleCommonUIController);
			battleUITask.m_luaExportHelper.m_battleCommonUIController = battleCommonUIController;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601C435 RID: 115765 RVA: 0x008B76FC File Offset: 0x008B58FC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_battleMapUIController(IntPtr l)
	{
		int result;
		try
		{
			BattleUITask battleUITask = (BattleUITask)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, battleUITask.m_luaExportHelper.m_battleMapUIController);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601C436 RID: 115766 RVA: 0x008B7754 File Offset: 0x008B5954
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_battleMapUIController(IntPtr l)
	{
		int result;
		try
		{
			BattleUITask battleUITask = (BattleUITask)LuaObject.checkSelf(l);
			BattleMapUIController battleMapUIController;
			LuaObject.checkType<BattleMapUIController>(l, 2, out battleMapUIController);
			battleUITask.m_luaExportHelper.m_battleMapUIController = battleMapUIController;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601C437 RID: 115767 RVA: 0x008B77B0 File Offset: 0x008B59B0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_battleSceneUIController(IntPtr l)
	{
		int result;
		try
		{
			BattleUITask battleUITask = (BattleUITask)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, battleUITask.m_luaExportHelper.m_battleSceneUIController);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601C438 RID: 115768 RVA: 0x008B7808 File Offset: 0x008B5A08
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_battleSceneUIController(IntPtr l)
	{
		int result;
		try
		{
			BattleUITask battleUITask = (BattleUITask)LuaObject.checkSelf(l);
			BattleSceneUIController battleSceneUIController;
			LuaObject.checkType<BattleSceneUIController>(l, 2, out battleSceneUIController);
			battleUITask.m_luaExportHelper.m_battleSceneUIController = battleSceneUIController;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601C439 RID: 115769 RVA: 0x008B7864 File Offset: 0x008B5A64
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_combatSceneUIController(IntPtr l)
	{
		int result;
		try
		{
			BattleUITask battleUITask = (BattleUITask)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, battleUITask.m_luaExportHelper.m_combatSceneUIController);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601C43A RID: 115770 RVA: 0x008B78BC File Offset: 0x008B5ABC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_combatSceneUIController(IntPtr l)
	{
		int result;
		try
		{
			BattleUITask battleUITask = (BattleUITask)LuaObject.checkSelf(l);
			CombatSceneUIController combatSceneUIController;
			LuaObject.checkType<CombatSceneUIController>(l, 2, out combatSceneUIController);
			battleUITask.m_luaExportHelper.m_combatSceneUIController = combatSceneUIController;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601C43B RID: 115771 RVA: 0x008B7918 File Offset: 0x008B5B18
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_getRewardGoodsUITask(IntPtr l)
	{
		int result;
		try
		{
			BattleUITask battleUITask = (BattleUITask)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, battleUITask.m_luaExportHelper.m_getRewardGoodsUITask);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601C43C RID: 115772 RVA: 0x008B7970 File Offset: 0x008B5B70
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_getRewardGoodsUITask(IntPtr l)
	{
		int result;
		try
		{
			BattleUITask battleUITask = (BattleUITask)LuaObject.checkSelf(l);
			GetRewardGoodsUITask getRewardGoodsUITask;
			LuaObject.checkType<GetRewardGoodsUITask>(l, 2, out getRewardGoodsUITask);
			battleUITask.m_luaExportHelper.m_getRewardGoodsUITask = getRewardGoodsUITask;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601C43D RID: 115773 RVA: 0x008B79CC File Offset: 0x008B5BCC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_battleDialogUITask(IntPtr l)
	{
		int result;
		try
		{
			BattleUITask battleUITask = (BattleUITask)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, battleUITask.m_luaExportHelper.m_battleDialogUITask);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601C43E RID: 115774 RVA: 0x008B7A24 File Offset: 0x008B5C24
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_battleDialogUITask(IntPtr l)
	{
		int result;
		try
		{
			BattleUITask battleUITask = (BattleUITask)LuaObject.checkSelf(l);
			BattleDialogUITask battleDialogUITask;
			LuaObject.checkType<BattleDialogUITask>(l, 2, out battleDialogUITask);
			battleUITask.m_luaExportHelper.m_battleDialogUITask = battleDialogUITask;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601C43F RID: 115775 RVA: 0x008B7A80 File Offset: 0x008B5C80
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_battleResultUITask(IntPtr l)
	{
		int result;
		try
		{
			BattleUITask battleUITask = (BattleUITask)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, battleUITask.m_luaExportHelper.m_battleResultUITask);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601C440 RID: 115776 RVA: 0x008B7AD8 File Offset: 0x008B5CD8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_battleResultUITask(IntPtr l)
	{
		int result;
		try
		{
			BattleUITask battleUITask = (BattleUITask)LuaObject.checkSelf(l);
			BattleResultUITask battleResultUITask;
			LuaObject.checkType<BattleResultUITask>(l, 2, out battleResultUITask);
			battleUITask.m_luaExportHelper.m_battleResultUITask = battleResultUITask;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601C441 RID: 115777 RVA: 0x008B7B34 File Offset: 0x008B5D34
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_battleResultScoreUITask(IntPtr l)
	{
		int result;
		try
		{
			BattleUITask battleUITask = (BattleUITask)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, battleUITask.m_luaExportHelper.m_battleResultScoreUITask);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601C442 RID: 115778 RVA: 0x008B7B8C File Offset: 0x008B5D8C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_battleResultScoreUITask(IntPtr l)
	{
		int result;
		try
		{
			BattleUITask battleUITask = (BattleUITask)LuaObject.checkSelf(l);
			BattleResultScoreUITask battleResultScoreUITask;
			LuaObject.checkType<BattleResultScoreUITask>(l, 2, out battleResultScoreUITask);
			battleUITask.m_luaExportHelper.m_battleResultScoreUITask = battleResultScoreUITask;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601C443 RID: 115779 RVA: 0x008B7BE8 File Offset: 0x008B5DE8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_battleLoseUITask(IntPtr l)
	{
		int result;
		try
		{
			BattleUITask battleUITask = (BattleUITask)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, battleUITask.m_luaExportHelper.m_battleLoseUITask);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601C444 RID: 115780 RVA: 0x008B7C40 File Offset: 0x008B5E40
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_battleLoseUITask(IntPtr l)
	{
		int result;
		try
		{
			BattleUITask battleUITask = (BattleUITask)LuaObject.checkSelf(l);
			BattleLoseUITask battleLoseUITask;
			LuaObject.checkType<BattleLoseUITask>(l, 2, out battleLoseUITask);
			battleUITask.m_luaExportHelper.m_battleLoseUITask = battleLoseUITask;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601C445 RID: 115781 RVA: 0x008B7C9C File Offset: 0x008B5E9C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_battleReportEndUITask(IntPtr l)
	{
		int result;
		try
		{
			BattleUITask battleUITask = (BattleUITask)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, battleUITask.m_luaExportHelper.m_battleReportEndUITask);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601C446 RID: 115782 RVA: 0x008B7CF4 File Offset: 0x008B5EF4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_battleReportEndUITask(IntPtr l)
	{
		int result;
		try
		{
			BattleUITask battleUITask = (BattleUITask)LuaObject.checkSelf(l);
			BattleReportEndUITask battleReportEndUITask;
			LuaObject.checkType<BattleReportEndUITask>(l, 2, out battleReportEndUITask);
			battleUITask.m_luaExportHelper.m_battleReportEndUITask = battleReportEndUITask;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601C447 RID: 115783 RVA: 0x008B7D50 File Offset: 0x008B5F50
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_clientBattle(IntPtr l)
	{
		int result;
		try
		{
			BattleUITask battleUITask = (BattleUITask)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, battleUITask.m_luaExportHelper.m_clientBattle);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601C448 RID: 115784 RVA: 0x008B7DA8 File Offset: 0x008B5FA8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_clientBattle(IntPtr l)
	{
		int result;
		try
		{
			BattleUITask battleUITask = (BattleUITask)LuaObject.checkSelf(l);
			ClientBattle clientBattle;
			LuaObject.checkType<ClientBattle>(l, 2, out clientBattle);
			battleUITask.m_luaExportHelper.m_clientBattle = clientBattle;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601C449 RID: 115785 RVA: 0x008B7E04 File Offset: 0x008B6004
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_configDataLoader(IntPtr l)
	{
		int result;
		try
		{
			BattleUITask battleUITask = (BattleUITask)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, battleUITask.m_luaExportHelper.m_configDataLoader);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601C44A RID: 115786 RVA: 0x008B7E5C File Offset: 0x008B605C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_configDataLoader(IntPtr l)
	{
		int result;
		try
		{
			BattleUITask battleUITask = (BattleUITask)LuaObject.checkSelf(l);
			IConfigDataLoader configDataLoader;
			LuaObject.checkType<IConfigDataLoader>(l, 2, out configDataLoader);
			battleUITask.m_luaExportHelper.m_configDataLoader = configDataLoader;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601C44B RID: 115787 RVA: 0x008B7EB8 File Offset: 0x008B60B8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_uiState(IntPtr l)
	{
		int result;
		try
		{
			BattleUITask battleUITask = (BattleUITask)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushEnum(l, (int)battleUITask.m_luaExportHelper.m_uiState);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601C44C RID: 115788 RVA: 0x008B7F10 File Offset: 0x008B6110
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_uiState(IntPtr l)
	{
		int result;
		try
		{
			BattleUITask battleUITask = (BattleUITask)LuaObject.checkSelf(l);
			BattleUIState uiState;
			LuaObject.checkEnum<BattleUIState>(l, 2, out uiState);
			battleUITask.m_luaExportHelper.m_uiState = uiState;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601C44D RID: 115789 RVA: 0x008B7F6C File Offset: 0x008B616C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_activeActor(IntPtr l)
	{
		int result;
		try
		{
			BattleUITask battleUITask = (BattleUITask)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, battleUITask.m_luaExportHelper.m_activeActor);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601C44E RID: 115790 RVA: 0x008B7FC4 File Offset: 0x008B61C4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_activeActor(IntPtr l)
	{
		int result;
		try
		{
			BattleUITask battleUITask = (BattleUITask)LuaObject.checkSelf(l);
			ClientBattleActor activeActor;
			LuaObject.checkType<ClientBattleActor>(l, 2, out activeActor);
			battleUITask.m_luaExportHelper.m_activeActor = activeActor;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601C44F RID: 115791 RVA: 0x008B8020 File Offset: 0x008B6220
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_activeActorInitPosition(IntPtr l)
	{
		int result;
		try
		{
			BattleUITask battleUITask = (BattleUITask)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, battleUITask.m_luaExportHelper.m_activeActorInitPosition);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601C450 RID: 115792 RVA: 0x008B807C File Offset: 0x008B627C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_activeActorInitPosition(IntPtr l)
	{
		int result;
		try
		{
			BattleUITask battleUITask = (BattleUITask)LuaObject.checkSelf(l);
			GridPosition activeActorInitPosition;
			LuaObject.checkValueType<GridPosition>(l, 2, out activeActorInitPosition);
			battleUITask.m_luaExportHelper.m_activeActorInitPosition = activeActorInitPosition;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601C451 RID: 115793 RVA: 0x008B80D8 File Offset: 0x008B62D8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_activeActorInitDirection(IntPtr l)
	{
		int result;
		try
		{
			BattleUITask battleUITask = (BattleUITask)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, battleUITask.m_luaExportHelper.m_activeActorInitDirection);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601C452 RID: 115794 RVA: 0x008B8130 File Offset: 0x008B6330
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_activeActorInitDirection(IntPtr l)
	{
		int result;
		try
		{
			BattleUITask battleUITask = (BattleUITask)LuaObject.checkSelf(l);
			int activeActorInitDirection;
			LuaObject.checkType(l, 2, out activeActorInitDirection);
			battleUITask.m_luaExportHelper.m_activeActorInitDirection = activeActorInitDirection;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601C453 RID: 115795 RVA: 0x008B818C File Offset: 0x008B638C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_skillIndex(IntPtr l)
	{
		int result;
		try
		{
			BattleUITask battleUITask = (BattleUITask)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, battleUITask.m_luaExportHelper.m_skillIndex);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601C454 RID: 115796 RVA: 0x008B81E4 File Offset: 0x008B63E4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_skillIndex(IntPtr l)
	{
		int result;
		try
		{
			BattleUITask battleUITask = (BattleUITask)LuaObject.checkSelf(l);
			int skillIndex;
			LuaObject.checkType(l, 2, out skillIndex);
			battleUITask.m_luaExportHelper.m_skillIndex = skillIndex;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601C455 RID: 115797 RVA: 0x008B8240 File Offset: 0x008B6440
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_skillTargetPosition(IntPtr l)
	{
		int result;
		try
		{
			BattleUITask battleUITask = (BattleUITask)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, battleUITask.m_luaExportHelper.m_skillTargetPosition);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601C456 RID: 115798 RVA: 0x008B829C File Offset: 0x008B649C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_skillTargetPosition(IntPtr l)
	{
		int result;
		try
		{
			BattleUITask battleUITask = (BattleUITask)LuaObject.checkSelf(l);
			GridPosition skillTargetPosition;
			LuaObject.checkValueType<GridPosition>(l, 2, out skillTargetPosition);
			battleUITask.m_luaExportHelper.m_skillTargetPosition = skillTargetPosition;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601C457 RID: 115799 RVA: 0x008B82F8 File Offset: 0x008B64F8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_skillTargetPosition2(IntPtr l)
	{
		int result;
		try
		{
			BattleUITask battleUITask = (BattleUITask)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, battleUITask.m_luaExportHelper.m_skillTargetPosition2);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601C458 RID: 115800 RVA: 0x008B8354 File Offset: 0x008B6554
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_skillTargetPosition2(IntPtr l)
	{
		int result;
		try
		{
			BattleUITask battleUITask = (BattleUITask)LuaObject.checkSelf(l);
			GridPosition skillTargetPosition;
			LuaObject.checkValueType<GridPosition>(l, 2, out skillTargetPosition);
			battleUITask.m_luaExportHelper.m_skillTargetPosition2 = skillTargetPosition;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601C459 RID: 115801 RVA: 0x008B83B0 File Offset: 0x008B65B0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_combatStartPosition(IntPtr l)
	{
		int result;
		try
		{
			BattleUITask battleUITask = (BattleUITask)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, battleUITask.m_luaExportHelper.m_combatStartPosition);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601C45A RID: 115802 RVA: 0x008B840C File Offset: 0x008B660C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_combatStartPosition(IntPtr l)
	{
		int result;
		try
		{
			BattleUITask battleUITask = (BattleUITask)LuaObject.checkSelf(l);
			GridPosition combatStartPosition;
			LuaObject.checkValueType<GridPosition>(l, 2, out combatStartPosition);
			battleUITask.m_luaExportHelper.m_combatStartPosition = combatStartPosition;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601C45B RID: 115803 RVA: 0x008B8468 File Offset: 0x008B6668
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_combatTargetPosition(IntPtr l)
	{
		int result;
		try
		{
			BattleUITask battleUITask = (BattleUITask)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, battleUITask.m_luaExportHelper.m_combatTargetPosition);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601C45C RID: 115804 RVA: 0x008B84C4 File Offset: 0x008B66C4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_combatTargetPosition(IntPtr l)
	{
		int result;
		try
		{
			BattleUITask battleUITask = (BattleUITask)LuaObject.checkSelf(l);
			GridPosition combatTargetPosition;
			LuaObject.checkValueType<GridPosition>(l, 2, out combatTargetPosition);
			battleUITask.m_luaExportHelper.m_combatTargetPosition = combatTargetPosition;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601C45D RID: 115805 RVA: 0x008B8520 File Offset: 0x008B6720
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_isBattleCutsceneFade(IntPtr l)
	{
		int result;
		try
		{
			BattleUITask battleUITask = (BattleUITask)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, battleUITask.m_luaExportHelper.m_isBattleCutsceneFade);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601C45E RID: 115806 RVA: 0x008B8578 File Offset: 0x008B6778
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_isBattleCutsceneFade(IntPtr l)
	{
		int result;
		try
		{
			BattleUITask battleUITask = (BattleUITask)LuaObject.checkSelf(l);
			bool isBattleCutsceneFade;
			LuaObject.checkType(l, 2, out isBattleCutsceneFade);
			battleUITask.m_luaExportHelper.m_isBattleCutsceneFade = isBattleCutsceneFade;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601C45F RID: 115807 RVA: 0x008B85D4 File Offset: 0x008B67D4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_isCombatCutsceneFade(IntPtr l)
	{
		int result;
		try
		{
			BattleUITask battleUITask = (BattleUITask)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, battleUITask.m_luaExportHelper.m_isCombatCutsceneFade);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601C460 RID: 115808 RVA: 0x008B862C File Offset: 0x008B682C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_isCombatCutsceneFade(IntPtr l)
	{
		int result;
		try
		{
			BattleUITask battleUITask = (BattleUITask)LuaObject.checkSelf(l);
			bool isCombatCutsceneFade;
			LuaObject.checkType(l, 2, out isCombatCutsceneFade);
			battleUITask.m_luaExportHelper.m_isCombatCutsceneFade = isCombatCutsceneFade;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601C461 RID: 115809 RVA: 0x008B8688 File Offset: 0x008B6888
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_battleMapClickTime(IntPtr l)
	{
		int result;
		try
		{
			BattleUITask battleUITask = (BattleUITask)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, battleUITask.m_luaExportHelper.m_battleMapClickTime);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601C462 RID: 115810 RVA: 0x008B86E4 File Offset: 0x008B68E4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_battleMapClickTime(IntPtr l)
	{
		int result;
		try
		{
			BattleUITask battleUITask = (BattleUITask)LuaObject.checkSelf(l);
			DateTime battleMapClickTime;
			LuaObject.checkValueType<DateTime>(l, 2, out battleMapClickTime);
			battleUITask.m_luaExportHelper.m_battleMapClickTime = battleMapClickTime;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601C463 RID: 115811 RVA: 0x008B8740 File Offset: 0x008B6940
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_showDangerRegionTeam(IntPtr l)
	{
		int result;
		try
		{
			BattleUITask battleUITask = (BattleUITask)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, battleUITask.m_luaExportHelper.m_showDangerRegionTeam);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601C464 RID: 115812 RVA: 0x008B8798 File Offset: 0x008B6998
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_showDangerRegionTeam(IntPtr l)
	{
		int result;
		try
		{
			BattleUITask battleUITask = (BattleUITask)LuaObject.checkSelf(l);
			int showDangerRegionTeam;
			LuaObject.checkType(l, 2, out showDangerRegionTeam);
			battleUITask.m_luaExportHelper.m_showDangerRegionTeam = showDangerRegionTeam;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601C465 RID: 115813 RVA: 0x008B87F4 File Offset: 0x008B69F4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_showDangerRegionActorIds(IntPtr l)
	{
		int result;
		try
		{
			BattleUITask battleUITask = (BattleUITask)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, battleUITask.m_luaExportHelper.m_showDangerRegionActorIds);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601C466 RID: 115814 RVA: 0x008B884C File Offset: 0x008B6A4C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_showDangerRegionActorIds(IntPtr l)
	{
		int result;
		try
		{
			BattleUITask battleUITask = (BattleUITask)LuaObject.checkSelf(l);
			List<int> showDangerRegionActorIds;
			LuaObject.checkType<List<int>>(l, 2, out showDangerRegionActorIds);
			battleUITask.m_luaExportHelper.m_showDangerRegionActorIds = showDangerRegionActorIds;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601C467 RID: 115815 RVA: 0x008B88A8 File Offset: 0x008B6AA8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_preCombatTargetActor(IntPtr l)
	{
		int result;
		try
		{
			BattleUITask battleUITask = (BattleUITask)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, battleUITask.m_luaExportHelper.m_preCombatTargetActor);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601C468 RID: 115816 RVA: 0x008B8900 File Offset: 0x008B6B00
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_preCombatTargetActor(IntPtr l)
	{
		int result;
		try
		{
			BattleUITask battleUITask = (BattleUITask)LuaObject.checkSelf(l);
			BattleActor preCombatTargetActor;
			LuaObject.checkType<BattleActor>(l, 2, out preCombatTargetActor);
			battleUITask.m_luaExportHelper.m_preCombatTargetActor = preCombatTargetActor;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601C469 RID: 115817 RVA: 0x008B895C File Offset: 0x008B6B5C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_saveShowTopUI(IntPtr l)
	{
		int result;
		try
		{
			BattleUITask battleUITask = (BattleUITask)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, battleUITask.m_luaExportHelper.m_saveShowTopUI);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601C46A RID: 115818 RVA: 0x008B89B4 File Offset: 0x008B6BB4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_saveShowTopUI(IntPtr l)
	{
		int result;
		try
		{
			BattleUITask battleUITask = (BattleUITask)LuaObject.checkSelf(l);
			bool saveShowTopUI;
			LuaObject.checkType(l, 2, out saveShowTopUI);
			battleUITask.m_luaExportHelper.m_saveShowTopUI = saveShowTopUI;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601C46B RID: 115819 RVA: 0x008B8A10 File Offset: 0x008B6C10
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_saveShowBottomUI(IntPtr l)
	{
		int result;
		try
		{
			BattleUITask battleUITask = (BattleUITask)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, battleUITask.m_luaExportHelper.m_saveShowBottomUI);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601C46C RID: 115820 RVA: 0x008B8A68 File Offset: 0x008B6C68
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_saveShowBottomUI(IntPtr l)
	{
		int result;
		try
		{
			BattleUITask battleUITask = (BattleUITask)LuaObject.checkSelf(l);
			bool saveShowBottomUI;
			LuaObject.checkType(l, 2, out saveShowBottomUI);
			battleUITask.m_luaExportHelper.m_saveShowBottomUI = saveShowBottomUI;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601C46D RID: 115821 RVA: 0x008B8AC4 File Offset: 0x008B6CC4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_disableSaveProcessingBattle(IntPtr l)
	{
		int result;
		try
		{
			BattleUITask battleUITask = (BattleUITask)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, battleUITask.m_luaExportHelper.m_disableSaveProcessingBattle);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601C46E RID: 115822 RVA: 0x008B8B1C File Offset: 0x008B6D1C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_disableSaveProcessingBattle(IntPtr l)
	{
		int result;
		try
		{
			BattleUITask battleUITask = (BattleUITask)LuaObject.checkSelf(l);
			bool disableSaveProcessingBattle;
			LuaObject.checkType(l, 2, out disableSaveProcessingBattle);
			battleUITask.m_luaExportHelper.m_disableSaveProcessingBattle = disableSaveProcessingBattle;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601C46F RID: 115823 RVA: 0x008B8B78 File Offset: 0x008B6D78
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_battleTeamSetup0(IntPtr l)
	{
		int result;
		try
		{
			BattleUITask battleUITask = (BattleUITask)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, battleUITask.m_luaExportHelper.m_battleTeamSetup0);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601C470 RID: 115824 RVA: 0x008B8BD0 File Offset: 0x008B6DD0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_battleTeamSetup0(IntPtr l)
	{
		int result;
		try
		{
			BattleUITask battleUITask = (BattleUITask)LuaObject.checkSelf(l);
			BattleTeamSetup battleTeamSetup;
			LuaObject.checkType<BattleTeamSetup>(l, 2, out battleTeamSetup);
			battleUITask.m_luaExportHelper.m_battleTeamSetup0 = battleTeamSetup;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601C471 RID: 115825 RVA: 0x008B8C2C File Offset: 0x008B6E2C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_battleTeamSetup1(IntPtr l)
	{
		int result;
		try
		{
			BattleUITask battleUITask = (BattleUITask)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, battleUITask.m_luaExportHelper.m_battleTeamSetup1);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601C472 RID: 115826 RVA: 0x008B8C84 File Offset: 0x008B6E84
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_battleTeamSetup1(IntPtr l)
	{
		int result;
		try
		{
			BattleUITask battleUITask = (BattleUITask)LuaObject.checkSelf(l);
			BattleTeamSetup battleTeamSetup;
			LuaObject.checkType<BattleTeamSetup>(l, 2, out battleTeamSetup);
			battleUITask.m_luaExportHelper.m_battleTeamSetup1 = battleTeamSetup;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601C473 RID: 115827 RVA: 0x008B8CE0 File Offset: 0x008B6EE0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_teamPositions0(IntPtr l)
	{
		int result;
		try
		{
			BattleUITask battleUITask = (BattleUITask)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, battleUITask.m_luaExportHelper.m_teamPositions0);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601C474 RID: 115828 RVA: 0x008B8D38 File Offset: 0x008B6F38
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_teamPositions0(IntPtr l)
	{
		int result;
		try
		{
			BattleUITask battleUITask = (BattleUITask)LuaObject.checkSelf(l);
			List<GridPosition> teamPositions;
			LuaObject.checkType<List<GridPosition>>(l, 2, out teamPositions);
			battleUITask.m_luaExportHelper.m_teamPositions0 = teamPositions;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601C475 RID: 115829 RVA: 0x008B8D94 File Offset: 0x008B6F94
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_teamPositions1(IntPtr l)
	{
		int result;
		try
		{
			BattleUITask battleUITask = (BattleUITask)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, battleUITask.m_luaExportHelper.m_teamPositions1);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601C476 RID: 115830 RVA: 0x008B8DEC File Offset: 0x008B6FEC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_teamPositions1(IntPtr l)
	{
		int result;
		try
		{
			BattleUITask battleUITask = (BattleUITask)LuaObject.checkSelf(l);
			List<GridPosition> teamPositions;
			LuaObject.checkType<List<GridPosition>>(l, 2, out teamPositions);
			battleUITask.m_luaExportHelper.m_teamPositions1 = teamPositions;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601C477 RID: 115831 RVA: 0x008B8E48 File Offset: 0x008B7048
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_teamNpcPositions0(IntPtr l)
	{
		int result;
		try
		{
			BattleUITask battleUITask = (BattleUITask)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, battleUITask.m_luaExportHelper.m_teamNpcPositions0);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601C478 RID: 115832 RVA: 0x008B8EA0 File Offset: 0x008B70A0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_teamNpcPositions0(IntPtr l)
	{
		int result;
		try
		{
			BattleUITask battleUITask = (BattleUITask)LuaObject.checkSelf(l);
			List<GridPosition> teamNpcPositions;
			LuaObject.checkType<List<GridPosition>>(l, 2, out teamNpcPositions);
			battleUITask.m_luaExportHelper.m_teamNpcPositions0 = teamNpcPositions;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601C479 RID: 115833 RVA: 0x008B8EFC File Offset: 0x008B70FC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_playerBattleHeros(IntPtr l)
	{
		int result;
		try
		{
			BattleUITask battleUITask = (BattleUITask)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, battleUITask.m_luaExportHelper.m_playerBattleHeros);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601C47A RID: 115834 RVA: 0x008B8F54 File Offset: 0x008B7154
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_playerBattleHeros(IntPtr l)
	{
		int result;
		try
		{
			BattleUITask battleUITask = (BattleUITask)LuaObject.checkSelf(l);
			List<BattleHero> playerBattleHeros;
			LuaObject.checkType<List<BattleHero>>(l, 2, out playerBattleHeros);
			battleUITask.m_luaExportHelper.m_playerBattleHeros = playerBattleHeros;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601C47B RID: 115835 RVA: 0x008B8FB0 File Offset: 0x008B71B0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_tempIntList(IntPtr l)
	{
		int result;
		try
		{
			BattleUITask battleUITask = (BattleUITask)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, battleUITask.m_luaExportHelper.m_tempIntList);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601C47C RID: 115836 RVA: 0x008B9008 File Offset: 0x008B7208
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_tempIntList(IntPtr l)
	{
		int result;
		try
		{
			BattleUITask battleUITask = (BattleUITask)LuaObject.checkSelf(l);
			List<int> tempIntList;
			LuaObject.checkType<List<int>>(l, 2, out tempIntList);
			battleUITask.m_luaExportHelper.m_tempIntList = tempIntList;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601C47D RID: 115837 RVA: 0x008B9064 File Offset: 0x008B7264
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_tempStringList(IntPtr l)
	{
		int result;
		try
		{
			BattleUITask battleUITask = (BattleUITask)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, battleUITask.m_luaExportHelper.m_tempStringList);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601C47E RID: 115838 RVA: 0x008B90BC File Offset: 0x008B72BC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_tempStringList(IntPtr l)
	{
		int result;
		try
		{
			BattleUITask battleUITask = (BattleUITask)LuaObject.checkSelf(l);
			List<string> tempStringList;
			LuaObject.checkType<List<string>>(l, 2, out tempStringList);
			battleUITask.m_luaExportHelper.m_tempStringList = tempStringList;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601C47F RID: 115839 RVA: 0x008B9118 File Offset: 0x008B7318
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_dangerRegion(IntPtr l)
	{
		int result;
		try
		{
			BattleUITask battleUITask = (BattleUITask)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, battleUITask.m_luaExportHelper.m_dangerRegion);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601C480 RID: 115840 RVA: 0x008B9170 File Offset: 0x008B7370
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_dangerRegion(IntPtr l)
	{
		int result;
		try
		{
			BattleUITask battleUITask = (BattleUITask)LuaObject.checkSelf(l);
			HashSet<GridPosition> dangerRegion;
			LuaObject.checkType<HashSet<GridPosition>>(l, 2, out dangerRegion);
			battleUITask.m_luaExportHelper.m_dangerRegion = dangerRegion;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601C481 RID: 115841 RVA: 0x008B91CC File Offset: 0x008B73CC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_trainingTechs(IntPtr l)
	{
		int result;
		try
		{
			BattleUITask battleUITask = (BattleUITask)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, battleUITask.m_luaExportHelper.m_trainingTechs);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601C482 RID: 115842 RVA: 0x008B9224 File Offset: 0x008B7424
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_trainingTechs(IntPtr l)
	{
		int result;
		try
		{
			BattleUITask battleUITask = (BattleUITask)LuaObject.checkSelf(l);
			List<TrainingTech> trainingTechs;
			LuaObject.checkType<List<TrainingTech>>(l, 2, out trainingTechs);
			battleUITask.m_luaExportHelper.m_trainingTechs = trainingTechs;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601C483 RID: 115843 RVA: 0x008B9280 File Offset: 0x008B7480
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_userGuideEnforceHeroIds(IntPtr l)
	{
		int result;
		try
		{
			BattleUITask battleUITask = (BattleUITask)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, battleUITask.m_luaExportHelper.m_userGuideEnforceHeroIds);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601C484 RID: 115844 RVA: 0x008B92D8 File Offset: 0x008B74D8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_userGuideEnforceHeroIds(IntPtr l)
	{
		int result;
		try
		{
			BattleUITask battleUITask = (BattleUITask)LuaObject.checkSelf(l);
			List<int> userGuideEnforceHeroIds;
			LuaObject.checkType<List<int>>(l, 2, out userGuideEnforceHeroIds);
			battleUITask.m_luaExportHelper.m_userGuideEnforceHeroIds = userGuideEnforceHeroIds;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601C485 RID: 115845 RVA: 0x008B9334 File Offset: 0x008B7534
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_arenaAttackerHeroIds(IntPtr l)
	{
		int result;
		try
		{
			BattleUITask battleUITask = (BattleUITask)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, battleUITask.m_luaExportHelper.m_arenaAttackerHeroIds);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601C486 RID: 115846 RVA: 0x008B938C File Offset: 0x008B758C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_arenaAttackerHeroIds(IntPtr l)
	{
		int result;
		try
		{
			BattleUITask battleUITask = (BattleUITask)LuaObject.checkSelf(l);
			List<int> arenaAttackerHeroIds;
			LuaObject.checkType<List<int>>(l, 2, out arenaAttackerHeroIds);
			battleUITask.m_luaExportHelper.m_arenaAttackerHeroIds = arenaAttackerHeroIds;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601C487 RID: 115847 RVA: 0x008B93E8 File Offset: 0x008B75E8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_myBattleHeroIds(IntPtr l)
	{
		int result;
		try
		{
			BattleUITask battleUITask = (BattleUITask)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, battleUITask.m_luaExportHelper.m_myBattleHeroIds);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601C488 RID: 115848 RVA: 0x008B9440 File Offset: 0x008B7640
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_myBattleHeroIds(IntPtr l)
	{
		int result;
		try
		{
			BattleUITask battleUITask = (BattleUITask)LuaObject.checkSelf(l);
			List<int> myBattleHeroIds;
			LuaObject.checkType<List<int>>(l, 2, out myBattleHeroIds);
			battleUITask.m_luaExportHelper.m_myBattleHeroIds = myBattleHeroIds;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601C489 RID: 115849 RVA: 0x008B949C File Offset: 0x008B769C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_loadState(IntPtr l)
	{
		int result;
		try
		{
			BattleUITask battleUITask = (BattleUITask)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushEnum(l, (int)battleUITask.m_luaExportHelper.m_loadState);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601C48A RID: 115850 RVA: 0x008B94F4 File Offset: 0x008B76F4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_loadState(IntPtr l)
	{
		int result;
		try
		{
			BattleUITask battleUITask = (BattleUITask)LuaObject.checkSelf(l);
			BattleLoadState loadState;
			LuaObject.checkEnum<BattleLoadState>(l, 2, out loadState);
			battleUITask.m_luaExportHelper.m_loadState = loadState;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601C48B RID: 115851 RVA: 0x008B9550 File Offset: 0x008B7750
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_battlePerformState(IntPtr l)
	{
		int result;
		try
		{
			BattleUITask battleUITask = (BattleUITask)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushEnum(l, (int)battleUITask.m_luaExportHelper.m_battlePerformState);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601C48C RID: 115852 RVA: 0x008B95A8 File Offset: 0x008B77A8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_battlePerformState(IntPtr l)
	{
		int result;
		try
		{
			BattleUITask battleUITask = (BattleUITask)LuaObject.checkSelf(l);
			BattlePerformState battlePerformState;
			LuaObject.checkEnum<BattlePerformState>(l, 2, out battlePerformState);
			battleUITask.m_luaExportHelper.m_battlePerformState = battlePerformState;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601C48D RID: 115853 RVA: 0x008B9604 File Offset: 0x008B7804
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_isStartBattleAutoBattle(IntPtr l)
	{
		int result;
		try
		{
			BattleUITask battleUITask = (BattleUITask)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, battleUITask.m_luaExportHelper.m_isStartBattleAutoBattle);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601C48E RID: 115854 RVA: 0x008B965C File Offset: 0x008B785C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_isStartBattleAutoBattle(IntPtr l)
	{
		int result;
		try
		{
			BattleUITask battleUITask = (BattleUITask)LuaObject.checkSelf(l);
			bool isStartBattleAutoBattle;
			LuaObject.checkType(l, 2, out isStartBattleAutoBattle);
			battleUITask.m_luaExportHelper.m_isStartBattleAutoBattle = isStartBattleAutoBattle;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601C48F RID: 115855 RVA: 0x008B96B8 File Offset: 0x008B78B8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_nowSeconds(IntPtr l)
	{
		int result;
		try
		{
			BattleUITask battleUITask = (BattleUITask)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, battleUITask.m_luaExportHelper.m_nowSeconds);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601C490 RID: 115856 RVA: 0x008B9710 File Offset: 0x008B7910
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_nowSeconds(IntPtr l)
	{
		int result;
		try
		{
			BattleUITask battleUITask = (BattleUITask)LuaObject.checkSelf(l);
			int nowSeconds;
			LuaObject.checkType(l, 2, out nowSeconds);
			battleUITask.m_luaExportHelper.m_nowSeconds = nowSeconds;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601C491 RID: 115857 RVA: 0x008B976C File Offset: 0x008B796C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_myActionTimeout(IntPtr l)
	{
		int result;
		try
		{
			BattleUITask battleUITask = (BattleUITask)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, battleUITask.m_luaExportHelper.m_myActionTimeout);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601C492 RID: 115858 RVA: 0x008B97C8 File Offset: 0x008B79C8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_myActionTimeout(IntPtr l)
	{
		int result;
		try
		{
			BattleUITask battleUITask = (BattleUITask)LuaObject.checkSelf(l);
			DateTime myActionTimeout;
			LuaObject.checkValueType<DateTime>(l, 2, out myActionTimeout);
			battleUITask.m_luaExportHelper.m_myActionTimeout = myActionTimeout;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601C493 RID: 115859 RVA: 0x008B9824 File Offset: 0x008B7A24
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_otherActionTimeout(IntPtr l)
	{
		int result;
		try
		{
			BattleUITask battleUITask = (BattleUITask)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, battleUITask.m_luaExportHelper.m_otherActionTimeout);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601C494 RID: 115860 RVA: 0x008B9880 File Offset: 0x008B7A80
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_otherActionTimeout(IntPtr l)
	{
		int result;
		try
		{
			BattleUITask battleUITask = (BattleUITask)LuaObject.checkSelf(l);
			DateTime otherActionTimeout;
			LuaObject.checkValueType<DateTime>(l, 2, out otherActionTimeout);
			battleUITask.m_luaExportHelper.m_otherActionTimeout = otherActionTimeout;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601C495 RID: 115861 RVA: 0x008B98DC File Offset: 0x008B7ADC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_isMyActionTimeoutActive(IntPtr l)
	{
		int result;
		try
		{
			BattleUITask battleUITask = (BattleUITask)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, battleUITask.m_luaExportHelper.m_isMyActionTimeoutActive);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601C496 RID: 115862 RVA: 0x008B9934 File Offset: 0x008B7B34
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_isMyActionTimeoutActive(IntPtr l)
	{
		int result;
		try
		{
			BattleUITask battleUITask = (BattleUITask)LuaObject.checkSelf(l);
			bool isMyActionTimeoutActive;
			LuaObject.checkType(l, 2, out isMyActionTimeoutActive);
			battleUITask.m_luaExportHelper.m_isMyActionTimeoutActive = isMyActionTimeoutActive;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601C497 RID: 115863 RVA: 0x008B9990 File Offset: 0x008B7B90
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_isActionTimeoutAutoBattle(IntPtr l)
	{
		int result;
		try
		{
			BattleUITask battleUITask = (BattleUITask)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, battleUITask.m_luaExportHelper.m_isActionTimeoutAutoBattle);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601C498 RID: 115864 RVA: 0x008B99E8 File Offset: 0x008B7BE8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_isActionTimeoutAutoBattle(IntPtr l)
	{
		int result;
		try
		{
			BattleUITask battleUITask = (BattleUITask)LuaObject.checkSelf(l);
			bool isActionTimeoutAutoBattle;
			LuaObject.checkType(l, 2, out isActionTimeoutAutoBattle);
			battleUITask.m_luaExportHelper.m_isActionTimeoutAutoBattle = isActionTimeoutAutoBattle;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601C499 RID: 115865 RVA: 0x008B9A44 File Offset: 0x008B7C44
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_isAutoBattleOnce(IntPtr l)
	{
		int result;
		try
		{
			BattleUITask battleUITask = (BattleUITask)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, battleUITask.m_luaExportHelper.m_isAutoBattleOnce);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601C49A RID: 115866 RVA: 0x008B9A9C File Offset: 0x008B7C9C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_isAutoBattleOnce(IntPtr l)
	{
		int result;
		try
		{
			BattleUITask battleUITask = (BattleUITask)LuaObject.checkSelf(l);
			bool isAutoBattleOnce;
			LuaObject.checkType(l, 2, out isAutoBattleOnce);
			battleUITask.m_luaExportHelper.m_isAutoBattleOnce = isAutoBattleOnce;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601C49B RID: 115867 RVA: 0x008B9AF8 File Offset: 0x008B7CF8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_pendingHeroSetupNtfs(IntPtr l)
	{
		int result;
		try
		{
			BattleUITask battleUITask = (BattleUITask)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, battleUITask.m_luaExportHelper.m_pendingHeroSetupNtfs);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601C49C RID: 115868 RVA: 0x008B9B50 File Offset: 0x008B7D50
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_pendingHeroSetupNtfs(IntPtr l)
	{
		int result;
		try
		{
			BattleUITask battleUITask = (BattleUITask)LuaObject.checkSelf(l);
			List<int> pendingHeroSetupNtfs;
			LuaObject.checkType<List<int>>(l, 2, out pendingHeroSetupNtfs);
			battleUITask.m_luaExportHelper.m_pendingHeroSetupNtfs = pendingHeroSetupNtfs;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601C49D RID: 115869 RVA: 0x008B9BAC File Offset: 0x008B7DAC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_selectProtectHeroPos(IntPtr l)
	{
		int result;
		try
		{
			BattleUITask battleUITask = (BattleUITask)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, battleUITask.m_luaExportHelper.m_selectProtectHeroPos);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601C49E RID: 115870 RVA: 0x008B9C08 File Offset: 0x008B7E08
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_selectProtectHeroPos(IntPtr l)
	{
		int result;
		try
		{
			BattleUITask battleUITask = (BattleUITask)LuaObject.checkSelf(l);
			GridPosition selectProtectHeroPos;
			LuaObject.checkValueType<GridPosition>(l, 2, out selectProtectHeroPos);
			battleUITask.m_luaExportHelper.m_selectProtectHeroPos = selectProtectHeroPos;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601C49F RID: 115871 RVA: 0x008B9C64 File Offset: 0x008B7E64
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_selectBanHeroPos(IntPtr l)
	{
		int result;
		try
		{
			BattleUITask battleUITask = (BattleUITask)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, battleUITask.m_luaExportHelper.m_selectBanHeroPos);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601C4A0 RID: 115872 RVA: 0x008B9CC0 File Offset: 0x008B7EC0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_selectBanHeroPos(IntPtr l)
	{
		int result;
		try
		{
			BattleUITask battleUITask = (BattleUITask)LuaObject.checkSelf(l);
			GridPosition selectBanHeroPos;
			LuaObject.checkValueType<GridPosition>(l, 2, out selectBanHeroPos);
			battleUITask.m_luaExportHelper.m_selectBanHeroPos = selectBanHeroPos;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601C4A1 RID: 115873 RVA: 0x008B9D1C File Offset: 0x008B7F1C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_collectAssetObjects(IntPtr l)
	{
		int result;
		try
		{
			BattleUITask battleUITask = (BattleUITask)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, battleUITask.m_luaExportHelper.m_collectAssetObjects);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601C4A2 RID: 115874 RVA: 0x008B9D74 File Offset: 0x008B7F74
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_collectAssetObjects(IntPtr l)
	{
		int result;
		try
		{
			BattleUITask battleUITask = (BattleUITask)LuaObject.checkSelf(l);
			List<object> collectAssetObjects;
			LuaObject.checkType<List<object>>(l, 2, out collectAssetObjects);
			battleUITask.m_luaExportHelper.m_collectAssetObjects = collectAssetObjects;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601C4A3 RID: 115875 RVA: 0x008B9DD0 File Offset: 0x008B7FD0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_armyRandomNumber(IntPtr l)
	{
		int result;
		try
		{
			BattleUITask battleUITask = (BattleUITask)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, battleUITask.m_luaExportHelper.m_armyRandomNumber);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601C4A4 RID: 115876 RVA: 0x008B9E28 File Offset: 0x008B8028
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_armyRandomNumber(IntPtr l)
	{
		int result;
		try
		{
			BattleUITask battleUITask = (BattleUITask)LuaObject.checkSelf(l);
			RandomNumber armyRandomNumber;
			LuaObject.checkType<RandomNumber>(l, 2, out armyRandomNumber);
			battleUITask.m_luaExportHelper.m_armyRandomNumber = armyRandomNumber;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601C4A5 RID: 115877 RVA: 0x008B9E84 File Offset: 0x008B8084
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_battleReport(IntPtr l)
	{
		int result;
		try
		{
			BattleUITask battleUITask = (BattleUITask)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, battleUITask.m_luaExportHelper.m_battleReport);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601C4A6 RID: 115878 RVA: 0x008B9EDC File Offset: 0x008B80DC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_battleReport(IntPtr l)
	{
		int result;
		try
		{
			BattleUITask battleUITask = (BattleUITask)LuaObject.checkSelf(l);
			ProBattleReport battleReport;
			LuaObject.checkType<ProBattleReport>(l, 2, out battleReport);
			battleUITask.m_luaExportHelper.m_battleReport = battleReport;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601C4A7 RID: 115879 RVA: 0x008B9F38 File Offset: 0x008B8138
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_battleStopTurn(IntPtr l)
	{
		int result;
		try
		{
			BattleUITask battleUITask = (BattleUITask)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, battleUITask.m_luaExportHelper.m_battleStopTurn);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601C4A8 RID: 115880 RVA: 0x008B9F90 File Offset: 0x008B8190
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_battleStopTurn(IntPtr l)
	{
		int result;
		try
		{
			BattleUITask battleUITask = (BattleUITask)LuaObject.checkSelf(l);
			int battleStopTurn;
			LuaObject.checkType(l, 2, out battleStopTurn);
			battleUITask.m_luaExportHelper.m_battleStopTurn = battleStopTurn;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601C4A9 RID: 115881 RVA: 0x008B9FEC File Offset: 0x008B81EC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_isSendBattleCheatGMCommand(IntPtr l)
	{
		int result;
		try
		{
			BattleUITask battleUITask = (BattleUITask)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, battleUITask.m_luaExportHelper.m_isSendBattleCheatGMCommand);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601C4AA RID: 115882 RVA: 0x008BA044 File Offset: 0x008B8244
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_isSendBattleCheatGMCommand(IntPtr l)
	{
		int result;
		try
		{
			BattleUITask battleUITask = (BattleUITask)LuaObject.checkSelf(l);
			bool isSendBattleCheatGMCommand;
			LuaObject.checkType(l, 2, out isSendBattleCheatGMCommand);
			battleUITask.m_luaExportHelper.m_isSendBattleCheatGMCommand = isSendBattleCheatGMCommand;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601C4AB RID: 115883 RVA: 0x008BA0A0 File Offset: 0x008B82A0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_isStartInBattleRoom(IntPtr l)
	{
		int result;
		try
		{
			BattleUITask battleUITask = (BattleUITask)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, battleUITask.m_luaExportHelper.m_isStartInBattleRoom);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601C4AC RID: 115884 RVA: 0x008BA0F8 File Offset: 0x008B82F8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_isStartInBattleRoom(IntPtr l)
	{
		int result;
		try
		{
			BattleUITask battleUITask = (BattleUITask)LuaObject.checkSelf(l);
			bool isStartInBattleRoom;
			LuaObject.checkType(l, 2, out isStartInBattleRoom);
			battleUITask.m_luaExportHelper.m_isStartInBattleRoom = isStartInBattleRoom;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601C4AD RID: 115885 RVA: 0x008BA154 File Offset: 0x008B8354
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_m_onActiveActorEvent(IntPtr l)
	{
		int result;
		try
		{
			Action<ClientBattleActor> value;
			int num = LuaObject.checkDelegate<Action<ClientBattleActor>>(l, 2, out value);
			if (num != 0)
			{
				if (num == 1)
				{
					BattleUITask.m_onActiveActorEvent += value;
				}
				else if (num == 2)
				{
					BattleUITask.m_onActiveActorEvent -= value;
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

	// Token: 0x0601C4AE RID: 115886 RVA: 0x008BA1C4 File Offset: 0x008B83C4
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_m_onDeactiveActorEvent(IntPtr l)
	{
		int result;
		try
		{
			Action<ClientBattleActor> value;
			int num = LuaObject.checkDelegate<Action<ClientBattleActor>>(l, 2, out value);
			if (num != 0)
			{
				if (num == 1)
				{
					BattleUITask.m_onDeactiveActorEvent += value;
				}
				else if (num == 2)
				{
					BattleUITask.m_onDeactiveActorEvent -= value;
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

	// Token: 0x0601C4AF RID: 115887 RVA: 0x008BA234 File Offset: 0x008B8434
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_regretSteps(IntPtr l)
	{
		int result;
		try
		{
			BattleUITask battleUITask = (BattleUITask)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, battleUITask.m_luaExportHelper.m_regretSteps);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601C4B0 RID: 115888 RVA: 0x008BA28C File Offset: 0x008B848C
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_m_regretSteps(IntPtr l)
	{
		int result;
		try
		{
			BattleUITask battleUITask = (BattleUITask)LuaObject.checkSelf(l);
			List<BattleUITask.RegretStep> regretSteps;
			LuaObject.checkType<List<BattleUITask.RegretStep>>(l, 2, out regretSteps);
			battleUITask.m_luaExportHelper.m_regretSteps = regretSteps;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601C4B1 RID: 115889 RVA: 0x008BA2E8 File Offset: 0x008B84E8
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_m_regretBattleCommands(IntPtr l)
	{
		int result;
		try
		{
			BattleUITask battleUITask = (BattleUITask)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, battleUITask.m_luaExportHelper.m_regretBattleCommands);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601C4B2 RID: 115890 RVA: 0x008BA340 File Offset: 0x008B8540
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_regretBattleCommands(IntPtr l)
	{
		int result;
		try
		{
			BattleUITask battleUITask = (BattleUITask)LuaObject.checkSelf(l);
			List<BattleCommand> regretBattleCommands;
			LuaObject.checkType<List<BattleCommand>>(l, 2, out regretBattleCommands);
			battleUITask.m_luaExportHelper.m_regretBattleCommands = regretBattleCommands;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601C4B3 RID: 115891 RVA: 0x008BA39C File Offset: 0x008B859C
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_m_regretFinalStep(IntPtr l)
	{
		int result;
		try
		{
			BattleUITask battleUITask = (BattleUITask)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, battleUITask.m_luaExportHelper.m_regretFinalStep);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601C4B4 RID: 115892 RVA: 0x008BA3F4 File Offset: 0x008B85F4
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_m_regretFinalStep(IntPtr l)
	{
		int result;
		try
		{
			BattleUITask battleUITask = (BattleUITask)LuaObject.checkSelf(l);
			int regretFinalStep;
			LuaObject.checkType(l, 2, out regretFinalStep);
			battleUITask.m_luaExportHelper.m_regretFinalStep = regretFinalStep;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601C4B5 RID: 115893 RVA: 0x008BA450 File Offset: 0x008B8650
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_regretCurrentStep(IntPtr l)
	{
		int result;
		try
		{
			BattleUITask battleUITask = (BattleUITask)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, battleUITask.m_luaExportHelper.m_regretCurrentStep);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601C4B6 RID: 115894 RVA: 0x008BA4A8 File Offset: 0x008B86A8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_regretCurrentStep(IntPtr l)
	{
		int result;
		try
		{
			BattleUITask battleUITask = (BattleUITask)LuaObject.checkSelf(l);
			int regretCurrentStep;
			LuaObject.checkType(l, 2, out regretCurrentStep);
			battleUITask.m_luaExportHelper.m_regretCurrentStep = regretCurrentStep;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601C4B7 RID: 115895 RVA: 0x008BA504 File Offset: 0x008B8704
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_m_regretCameraFocusActorId(IntPtr l)
	{
		int result;
		try
		{
			BattleUITask battleUITask = (BattleUITask)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, battleUITask.m_luaExportHelper.m_regretCameraFocusActorId);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601C4B8 RID: 115896 RVA: 0x008BA55C File Offset: 0x008B875C
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_m_regretCameraFocusActorId(IntPtr l)
	{
		int result;
		try
		{
			BattleUITask battleUITask = (BattleUITask)LuaObject.checkSelf(l);
			int regretCameraFocusActorId;
			LuaObject.checkType(l, 2, out regretCameraFocusActorId);
			battleUITask.m_luaExportHelper.m_regretCameraFocusActorId = regretCameraFocusActorId;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601C4B9 RID: 115897 RVA: 0x008BA5B8 File Offset: 0x008B87B8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_ClientBattle(IntPtr l)
	{
		int result;
		try
		{
			BattleUITask battleUITask = (BattleUITask)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, battleUITask.ClientBattle);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601C4BA RID: 115898 RVA: 0x008BA60C File Offset: 0x008B880C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_LayerDescArray(IntPtr l)
	{
		int result;
		try
		{
			BattleUITask battleUITask = (BattleUITask)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, battleUITask.m_luaExportHelper.LayerDescArray);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601C4BB RID: 115899 RVA: 0x008BA664 File Offset: 0x008B8864
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_UICtrlDescArray(IntPtr l)
	{
		int result;
		try
		{
			BattleUITask battleUITask = (BattleUITask)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, battleUITask.m_luaExportHelper.UICtrlDescArray);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601C4BC RID: 115900 RVA: 0x008BA6BC File Offset: 0x008B88BC
	[Preserve]
	public static void reg(IntPtr l)
	{
		LuaObject.getTypeTable(l, "BlackJack.ProjectL.UI.BattleUITask");
		if (Lua_BlackJack_ProjectL_UI_BattleUITask.<>f__mg$cache0 == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleUITask.<>f__mg$cache0 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleUITask.OnBattleMapClick);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_BattleUITask.<>f__mg$cache0);
		if (Lua_BlackJack_ProjectL_UI_BattleUITask.<>f__mg$cache1 == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleUITask.<>f__mg$cache1 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleUITask.OnStartBattle);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_BattleUITask.<>f__mg$cache1);
		if (Lua_BlackJack_ProjectL_UI_BattleUITask.<>f__mg$cache2 == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleUITask.<>f__mg$cache2 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleUITask.OnStopBattle);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_BattleUITask.<>f__mg$cache2);
		if (Lua_BlackJack_ProjectL_UI_BattleUITask.<>f__mg$cache3 == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleUITask.<>f__mg$cache3 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleUITask.OnShowBattleWinCondition);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_BattleUITask.<>f__mg$cache3);
		if (Lua_BlackJack_ProjectL_UI_BattleUITask.<>f__mg$cache4 == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleUITask.<>f__mg$cache4 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleUITask.OnHideBattleWinCondition);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_BattleUITask.<>f__mg$cache4);
		if (Lua_BlackJack_ProjectL_UI_BattleUITask.<>f__mg$cache5 == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleUITask.<>f__mg$cache5 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleUITask.OnShowBattleLoseCondition);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_BattleUITask.<>f__mg$cache5);
		if (Lua_BlackJack_ProjectL_UI_BattleUITask.<>f__mg$cache6 == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleUITask.<>f__mg$cache6 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleUITask.OnHideBattleLoseCondition);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_BattleUITask.<>f__mg$cache6);
		if (Lua_BlackJack_ProjectL_UI_BattleUITask.<>f__mg$cache7 == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleUITask.<>f__mg$cache7 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleUITask.OnNextTurn);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_BattleUITask.<>f__mg$cache7);
		if (Lua_BlackJack_ProjectL_UI_BattleUITask.<>f__mg$cache8 == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleUITask.<>f__mg$cache8 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleUITask.OnNextTurnAnimationEnd);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_BattleUITask.<>f__mg$cache8);
		if (Lua_BlackJack_ProjectL_UI_BattleUITask.<>f__mg$cache9 == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleUITask.<>f__mg$cache9 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleUITask.OnNextTeam);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_BattleUITask.<>f__mg$cache9);
		if (Lua_BlackJack_ProjectL_UI_BattleUITask.<>f__mg$cacheA == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleUITask.<>f__mg$cacheA = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleUITask.OnNextPlayer);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_BattleUITask.<>f__mg$cacheA);
		if (Lua_BlackJack_ProjectL_UI_BattleUITask.<>f__mg$cacheB == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleUITask.<>f__mg$cacheB = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleUITask.OnNextActor);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_BattleUITask.<>f__mg$cacheB);
		if (Lua_BlackJack_ProjectL_UI_BattleUITask.<>f__mg$cacheC == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleUITask.<>f__mg$cacheC = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleUITask.OnClientActorActive);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_BattleUITask.<>f__mg$cacheC);
		if (Lua_BlackJack_ProjectL_UI_BattleUITask.<>f__mg$cacheD == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleUITask.<>f__mg$cacheD = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleUITask.OnClientActorMove);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_BattleUITask.<>f__mg$cacheD);
		if (Lua_BlackJack_ProjectL_UI_BattleUITask.<>f__mg$cacheE == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleUITask.<>f__mg$cacheE = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleUITask.OnClientActorTryMove);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_BattleUITask.<>f__mg$cacheE);
		if (Lua_BlackJack_ProjectL_UI_BattleUITask.<>f__mg$cacheF == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleUITask.<>f__mg$cacheF = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleUITask.OnClientActorNoAct);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_BattleUITask.<>f__mg$cacheF);
		if (Lua_BlackJack_ProjectL_UI_BattleUITask.<>f__mg$cache10 == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleUITask.<>f__mg$cache10 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleUITask.OnClientActorTarget);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_BattleUITask.<>f__mg$cache10);
		if (Lua_BlackJack_ProjectL_UI_BattleUITask.<>f__mg$cache11 == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleUITask.<>f__mg$cache11 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleUITask.OnClientActorSkill);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_BattleUITask.<>f__mg$cache11);
		if (Lua_BlackJack_ProjectL_UI_BattleUITask.<>f__mg$cache12 == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleUITask.<>f__mg$cache12 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleUITask.OnClientActorSkillEnd);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_BattleUITask.<>f__mg$cache12);
		if (Lua_BlackJack_ProjectL_UI_BattleUITask.<>f__mg$cache13 == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleUITask.<>f__mg$cache13 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleUITask.OnClientActorSkillHit);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_BattleUITask.<>f__mg$cache13);
		if (Lua_BlackJack_ProjectL_UI_BattleUITask.<>f__mg$cache14 == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleUITask.<>f__mg$cache14 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleUITask.OnClientActorBuffHit);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_BattleUITask.<>f__mg$cache14);
		if (Lua_BlackJack_ProjectL_UI_BattleUITask.<>f__mg$cache15 == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleUITask.<>f__mg$cache15 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleUITask.OnClientActorTerrainHit);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_BattleUITask.<>f__mg$cache15);
		if (Lua_BlackJack_ProjectL_UI_BattleUITask.<>f__mg$cache16 == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleUITask.<>f__mg$cache16 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleUITask.OnClientActorImmune);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_BattleUITask.<>f__mg$cache16);
		if (Lua_BlackJack_ProjectL_UI_BattleUITask.<>f__mg$cache17 == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleUITask.<>f__mg$cache17 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleUITask.OnClientActorPassiveSkill);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_BattleUITask.<>f__mg$cache17);
		if (Lua_BlackJack_ProjectL_UI_BattleUITask.<>f__mg$cache18 == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleUITask.<>f__mg$cache18 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleUITask.OnClientActorGuard);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_BattleUITask.<>f__mg$cache18);
		if (Lua_BlackJack_ProjectL_UI_BattleUITask.<>f__mg$cache19 == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleUITask.<>f__mg$cache19 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleUITask.OnClientActorDie);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_BattleUITask.<>f__mg$cache19);
		if (Lua_BlackJack_ProjectL_UI_BattleUITask.<>f__mg$cache1A == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleUITask.<>f__mg$cache1A = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleUITask.OnClientActorAppear);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_BattleUITask.<>f__mg$cache1A);
		if (Lua_BlackJack_ProjectL_UI_BattleUITask.<>f__mg$cache1B == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleUITask.<>f__mg$cache1B = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleUITask.OnCancelCombat);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_BattleUITask.<>f__mg$cache1B);
		if (Lua_BlackJack_ProjectL_UI_BattleUITask.<>f__mg$cache1C == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleUITask.<>f__mg$cache1C = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleUITask.OnPreStartCombat);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_BattleUITask.<>f__mg$cache1C);
		if (Lua_BlackJack_ProjectL_UI_BattleUITask.<>f__mg$cache1D == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleUITask.<>f__mg$cache1D = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleUITask.OnStartCombat);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_BattleUITask.<>f__mg$cache1D);
		if (Lua_BlackJack_ProjectL_UI_BattleUITask.<>f__mg$cache1E == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleUITask.<>f__mg$cache1E = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleUITask.OnPreStopCombat);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_BattleUITask.<>f__mg$cache1E);
		if (Lua_BlackJack_ProjectL_UI_BattleUITask.<>f__mg$cache1F == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleUITask.<>f__mg$cache1F = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleUITask.OnStopCombat);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_BattleUITask.<>f__mg$cache1F);
		if (Lua_BlackJack_ProjectL_UI_BattleUITask.<>f__mg$cache20 == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleUITask.<>f__mg$cache20 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleUITask.OnPrepareFastCombat);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_BattleUITask.<>f__mg$cache20);
		if (Lua_BlackJack_ProjectL_UI_BattleUITask.<>f__mg$cache21 == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleUITask.<>f__mg$cache21 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleUITask.OnStartFastCombat);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_BattleUITask.<>f__mg$cache21);
		if (Lua_BlackJack_ProjectL_UI_BattleUITask.<>f__mg$cache22 == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleUITask.<>f__mg$cache22 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleUITask.OnCombatActorHit);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_BattleUITask.<>f__mg$cache22);
		if (Lua_BlackJack_ProjectL_UI_BattleUITask.<>f__mg$cache23 == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleUITask.<>f__mg$cache23 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleUITask.OnStartSkillCutscene);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_BattleUITask.<>f__mg$cache23);
		if (Lua_BlackJack_ProjectL_UI_BattleUITask.<>f__mg$cache24 == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleUITask.<>f__mg$cache24 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleUITask.OnStartPassiveSkillCutscene);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_BattleUITask.<>f__mg$cache24);
		if (Lua_BlackJack_ProjectL_UI_BattleUITask.<>f__mg$cache25 == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleUITask.<>f__mg$cache25 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleUITask.OnStopSkillCutscene);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_BattleUITask.<>f__mg$cache25);
		if (Lua_BlackJack_ProjectL_UI_BattleUITask.<>f__mg$cache26 == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleUITask.<>f__mg$cache26 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleUITask.OnStartBattleDialog);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_BattleUITask.<>f__mg$cache26);
		if (Lua_BlackJack_ProjectL_UI_BattleUITask.<>f__mg$cache27 == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleUITask.<>f__mg$cache27 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleUITask.OnStartBattleTreasureDialog);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_BattleUITask.<>f__mg$cache27);
		if (Lua_BlackJack_ProjectL_UI_BattleUITask.<>f__mg$cache28 == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleUITask.<>f__mg$cache28 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleUITask.OnShowBattleTreasureReward);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_BattleUITask.<>f__mg$cache28);
		if (Lua_BlackJack_ProjectL_UI_BattleUITask.<>f__mg$cache29 == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleUITask.<>f__mg$cache29 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleUITask.OnStartBattlePerform);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_BattleUITask.<>f__mg$cache29);
		if (Lua_BlackJack_ProjectL_UI_BattleUITask.<>f__mg$cache2A == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleUITask.<>f__mg$cache2A = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleUITask.OnStopBattlePerform);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_BattleUITask.<>f__mg$cache2A);
		if (Lua_BlackJack_ProjectL_UI_BattleUITask.<>f__mg$cache2B == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleUITask.<>f__mg$cache2B = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleUITask.OnScreenEffect);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_BattleUITask.<>f__mg$cache2B);
		if (Lua_BlackJack_ProjectL_UI_BattleUITask.<>f__mg$cache2C == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleUITask.<>f__mg$cache2C = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleUITask.PrepareBattleUI);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_BattleUITask.<>f__mg$cache2C);
		if (Lua_BlackJack_ProjectL_UI_BattleUITask.<>f__mg$cache2D == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleUITask.<>f__mg$cache2D = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleUITask.BattlePrepareUIController_OnPointerClick);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_BattleUITask.<>f__mg$cache2D);
		if (Lua_BlackJack_ProjectL_UI_BattleUITask.<>f__mg$cache2E == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleUITask.<>f__mg$cache2E = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleUITask.IsNeedLoadDynamicRes);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_BattleUITask.<>f__mg$cache2E);
		if (Lua_BlackJack_ProjectL_UI_BattleUITask.<>f__mg$cache2F == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleUITask.<>f__mg$cache2F = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleUITask.InitLayerStateOnLoadAllResCompleted);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_BattleUITask.<>f__mg$cache2F);
		if (Lua_BlackJack_ProjectL_UI_BattleUITask.<>f__mg$cache30 == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleUITask.<>f__mg$cache30 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleUITask.InitAllUIControllers);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_BattleUITask.<>f__mg$cache30);
		if (Lua_BlackJack_ProjectL_UI_BattleUITask.<>f__mg$cache31 == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleUITask.<>f__mg$cache31 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleUITask.ClearAllContextAndRes);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_BattleUITask.<>f__mg$cache31);
		if (Lua_BlackJack_ProjectL_UI_BattleUITask.<>f__mg$cache32 == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleUITask.<>f__mg$cache32 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleUITask.OnStart);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_BattleUITask.<>f__mg$cache32);
		if (Lua_BlackJack_ProjectL_UI_BattleUITask.<>f__mg$cache33 == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleUITask.<>f__mg$cache33 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleUITask.OnStop);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_BattleUITask.<>f__mg$cache33);
		if (Lua_BlackJack_ProjectL_UI_BattleUITask.<>f__mg$cache34 == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleUITask.<>f__mg$cache34 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleUITask.HideAllView);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_BattleUITask.<>f__mg$cache34);
		if (Lua_BlackJack_ProjectL_UI_BattleUITask.<>f__mg$cache35 == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleUITask.<>f__mg$cache35 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleUITask.UpdateView);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_BattleUITask.<>f__mg$cache35);
		if (Lua_BlackJack_ProjectL_UI_BattleUITask.<>f__mg$cache36 == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleUITask.<>f__mg$cache36 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleUITask.PostUpdateView);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_BattleUITask.<>f__mg$cache36);
		if (Lua_BlackJack_ProjectL_UI_BattleUITask.<>f__mg$cache37 == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleUITask.<>f__mg$cache37 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleUITask.OnTick);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_BattleUITask.<>f__mg$cache37);
		if (Lua_BlackJack_ProjectL_UI_BattleUITask.<>f__mg$cache38 == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleUITask.<>f__mg$cache38 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleUITask.IsLoading);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_BattleUITask.<>f__mg$cache38);
		if (Lua_BlackJack_ProjectL_UI_BattleUITask.<>f__mg$cache39 == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleUITask.<>f__mg$cache39 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleUITask.CreateClientBattle);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_BattleUITask.<>f__mg$cache39);
		if (Lua_BlackJack_ProjectL_UI_BattleUITask.<>f__mg$cache3A == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleUITask.<>f__mg$cache3A = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleUITask.DestroyClientBattle);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_BattleUITask.<>f__mg$cache3A);
		if (Lua_BlackJack_ProjectL_UI_BattleUITask.<>f__mg$cache3B == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleUITask.<>f__mg$cache3B = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleUITask.PrepareClientBattle);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_BattleUITask.<>f__mg$cache3B);
		if (Lua_BlackJack_ProjectL_UI_BattleUITask.<>f__mg$cache3C == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleUITask.<>f__mg$cache3C = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleUITask.StartClientBattle);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_BattleUITask.<>f__mg$cache3C);
		if (Lua_BlackJack_ProjectL_UI_BattleUITask.<>f__mg$cache3D == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleUITask.<>f__mg$cache3D = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleUITask.StopBattle);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_BattleUITask.<>f__mg$cache3D);
		if (Lua_BlackJack_ProjectL_UI_BattleUITask.<>f__mg$cache3E == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleUITask.<>f__mg$cache3E = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleUITask.SendBattleRoomInitLog);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_BattleUITask.<>f__mg$cache3E);
		if (Lua_BlackJack_ProjectL_UI_BattleUITask.<>f__mg$cache3F == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleUITask.<>f__mg$cache3F = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleUITask.GetBattleTeamSetup);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_BattleUITask.<>f__mg$cache3F);
		if (Lua_BlackJack_ProjectL_UI_BattleUITask.<>f__mg$cache40 == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleUITask.<>f__mg$cache40 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleUITask.GetTeamPositions);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_BattleUITask.<>f__mg$cache40);
		if (Lua_BlackJack_ProjectL_UI_BattleUITask.<>f__mg$cache41 == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleUITask.<>f__mg$cache41 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleUITask.SetCombatHp);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_BattleUITask.<>f__mg$cache41);
		if (Lua_BlackJack_ProjectL_UI_BattleUITask.<>f__mg$cache42 == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleUITask.<>f__mg$cache42 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleUITask.ExitBattleReturnToWorld);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_BattleUITask.<>f__mg$cache42);
		if (Lua_BlackJack_ProjectL_UI_BattleUITask.<>f__mg$cache43 == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleUITask.<>f__mg$cache43 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleUITask.ShowErrorMessageAndExitBattle);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_BattleUITask.<>f__mg$cache43);
		if (Lua_BlackJack_ProjectL_UI_BattleUITask.<>f__mg$cache44 == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleUITask.<>f__mg$cache44 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleUITask.SaveProcessingBattle);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_BattleUITask.<>f__mg$cache44);
		if (Lua_BlackJack_ProjectL_UI_BattleUITask.<>f__mg$cache45 == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleUITask.<>f__mg$cache45 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleUITask.BattlePrepareBeforeShowResult);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_BattleUITask.<>f__mg$cache45);
		if (Lua_BlackJack_ProjectL_UI_BattleUITask.<>f__mg$cache46 == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleUITask.<>f__mg$cache46 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleUITask.IsMeArenaBattleTeam1);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_BattleUITask.<>f__mg$cache46);
		if (Lua_BlackJack_ProjectL_UI_BattleUITask.<>f__mg$cache47 == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleUITask.<>f__mg$cache47 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleUITask.CanUseChat);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_BattleUITask.<>f__mg$cache47);
		if (Lua_BlackJack_ProjectL_UI_BattleUITask.<>f__mg$cache48 == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleUITask.<>f__mg$cache48 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleUITask.CanUseDanmaku);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_BattleUITask.<>f__mg$cache48);
		if (Lua_BlackJack_ProjectL_UI_BattleUITask.<>f__mg$cache49 == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleUITask.<>f__mg$cache49 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleUITask.BattlePauseUIController_OnClose);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_BattleUITask.<>f__mg$cache49);
		if (Lua_BlackJack_ProjectL_UI_BattleUITask.<>f__mg$cache4A == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleUITask.<>f__mg$cache4A = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleUITask.BattlePauseUIController_OnShowPlayerSetting);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_BattleUITask.<>f__mg$cache4A);
		if (Lua_BlackJack_ProjectL_UI_BattleUITask.<>f__mg$cache4B == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleUITask.<>f__mg$cache4B = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleUITask.BattlePauseUIController_OnExit);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_BattleUITask.<>f__mg$cache4B);
		if (Lua_BlackJack_ProjectL_UI_BattleUITask.<>f__mg$cache4C == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleUITask.<>f__mg$cache4C = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleUITask.ExitBattleDialogBoxCallback);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_BattleUITask.<>f__mg$cache4C);
		if (Lua_BlackJack_ProjectL_UI_BattleUITask.<>f__mg$cache4D == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleUITask.<>f__mg$cache4D = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleUITask.TestUI_ExitBattle);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_BattleUITask.<>f__mg$cache4D);
		if (Lua_BlackJack_ProjectL_UI_BattleUITask.<>f__mg$cache4E == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleUITask.<>f__mg$cache4E = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleUITask.TestUI_RestartBattle);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_BattleUITask.<>f__mg$cache4E);
		if (Lua_BlackJack_ProjectL_UI_BattleUITask.<>f__mg$cache4F == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleUITask.<>f__mg$cache4F = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleUITask.TestUI_ReplayBattle);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_BattleUITask.<>f__mg$cache4F);
		if (Lua_BlackJack_ProjectL_UI_BattleUITask.<>f__mg$cache50 == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleUITask.<>f__mg$cache50 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleUITask.TestUI_StopBattle);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_BattleUITask.<>f__mg$cache50);
		if (Lua_BlackJack_ProjectL_UI_BattleUITask.<>f__mg$cache51 == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleUITask.<>f__mg$cache51 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleUITask.PlayerContext_OnChatMessageNtf);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_BattleUITask.<>f__mg$cache51);
		if (Lua_BlackJack_ProjectL_UI_BattleUITask.<>f__mg$cache52 == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleUITask.<>f__mg$cache52 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleUITask.PlayerContext_OnTeamRoomInviteNtf);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_BattleUITask.<>f__mg$cache52);
		if (Lua_BlackJack_ProjectL_UI_BattleUITask.<>f__mg$cache53 == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleUITask.<>f__mg$cache53 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleUITask.PlayerContext_OnBattlePracticeInvitedNtf);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_BattleUITask.<>f__mg$cache53);
		if (Lua_BlackJack_ProjectL_UI_BattleUITask.<>f__mg$cache54 == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleUITask.<>f__mg$cache54 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleUITask.CollectBattlePrepareAssets);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_BattleUITask.<>f__mg$cache54);
		if (Lua_BlackJack_ProjectL_UI_BattleUITask.<>f__mg$cache55 == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleUITask.<>f__mg$cache55 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleUITask.CollectBattleAssets);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_BattleUITask.<>f__mg$cache55);
		if (Lua_BlackJack_ProjectL_UI_BattleUITask.<>f__mg$cache56 == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleUITask.<>f__mg$cache56 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleUITask.CollectBattlePrepareHeros);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_BattleUITask.<>f__mg$cache56);
		if (Lua_BlackJack_ProjectL_UI_BattleUITask.<>f__mg$cache57 == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleUITask.<>f__mg$cache57 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleUITask.CollectBattlefieldAssets);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_BattleUITask.<>f__mg$cache57);
		if (Lua_BlackJack_ProjectL_UI_BattleUITask.<>f__mg$cache58 == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleUITask.<>f__mg$cache58 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleUITask.CollectTerrainAssets);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_BattleUITask.<>f__mg$cache58);
		if (Lua_BlackJack_ProjectL_UI_BattleUITask.<>f__mg$cache59 == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleUITask.<>f__mg$cache59 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleUITask.CollectCharImageAssets);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_BattleUITask.<>f__mg$cache59);
		if (Lua_BlackJack_ProjectL_UI_BattleUITask.<>f__mg$cache5A == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleUITask.<>f__mg$cache5A = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleUITask.CollectHeadImageAssets);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_BattleUITask.<>f__mg$cache5A);
		if (Lua_BlackJack_ProjectL_UI_BattleUITask.<>f__mg$cache5B == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleUITask.<>f__mg$cache5B = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleUITask.CollectHeroAssets);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_BattleUITask.<>f__mg$cache5B);
		if (Lua_BlackJack_ProjectL_UI_BattleUITask.<>f__mg$cache5C == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleUITask.<>f__mg$cache5C = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleUITask.CollectSoldierAssets);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_BattleUITask.<>f__mg$cache5C);
		if (Lua_BlackJack_ProjectL_UI_BattleUITask.<>f__mg$cache5D == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleUITask.<>f__mg$cache5D = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleUITask.CollectSkinAssets);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_BattleUITask.<>f__mg$cache5D);
		if (Lua_BlackJack_ProjectL_UI_BattleUITask.<>f__mg$cache5E == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleUITask.<>f__mg$cache5E = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleUITask.CollectSkillAssets);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_BattleUITask.<>f__mg$cache5E);
		if (Lua_BlackJack_ProjectL_UI_BattleUITask.<>f__mg$cache5F == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleUITask.<>f__mg$cache5F = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleUITask.CollectBuffAssets);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_BattleUITask.<>f__mg$cache5F);
		if (Lua_BlackJack_ProjectL_UI_BattleUITask.<>f__mg$cache60 == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleUITask.<>f__mg$cache60 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleUITask.CollectDefaultHeroAssets);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_BattleUITask.<>f__mg$cache60);
		if (Lua_BlackJack_ProjectL_UI_BattleUITask.<>f__mg$cache61 == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleUITask.<>f__mg$cache61 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleUITask.CollectBattleEventAssets);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_BattleUITask.<>f__mg$cache61);
		if (Lua_BlackJack_ProjectL_UI_BattleUITask.<>f__mg$cache62 == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleUITask.<>f__mg$cache62 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleUITask.CollectBattleEventActionAssets);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_BattleUITask.<>f__mg$cache62);
		if (Lua_BlackJack_ProjectL_UI_BattleUITask.<>f__mg$cache63 == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleUITask.<>f__mg$cache63 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleUITask.CollectBattlePerformAssets);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_BattleUITask.<>f__mg$cache63);
		if (Lua_BlackJack_ProjectL_UI_BattleUITask.<>f__mg$cache64 == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleUITask.<>f__mg$cache64 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleUITask._CollectBattlePerformAssets);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_BattleUITask.<>f__mg$cache64);
		if (Lua_BlackJack_ProjectL_UI_BattleUITask.<>f__mg$cache65 == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleUITask.<>f__mg$cache65 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleUITask.CollectTrainingTechAssets);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_BattleUITask.<>f__mg$cache65);
		if (Lua_BlackJack_ProjectL_UI_BattleUITask.<>f__mg$cache66 == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleUITask.<>f__mg$cache66 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleUITask.IsAlreadyCollectAsset);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_BattleUITask.<>f__mg$cache66);
		if (Lua_BlackJack_ProjectL_UI_BattleUITask.<>f__mg$cache67 == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleUITask.<>f__mg$cache67 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleUITask.ClearAlreadyCollectAssets);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_BattleUITask.<>f__mg$cache67);
		if (Lua_BlackJack_ProjectL_UI_BattleUITask.<>f__mg$cache68 == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleUITask.<>f__mg$cache68 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleUITask.StartBattleUI);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_BattleUITask.<>f__mg$cache68);
		if (Lua_BlackJack_ProjectL_UI_BattleUITask.<>f__mg$cache69 == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleUITask.<>f__mg$cache69 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleUITask.ClientActorTryMoveTo);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_BattleUITask.<>f__mg$cache69);
		if (Lua_BlackJack_ProjectL_UI_BattleUITask.<>f__mg$cache6A == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleUITask.<>f__mg$cache6A = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleUITask.AddCommandIfMoved);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_BattleUITask.<>f__mg$cache6A);
		if (Lua_BlackJack_ProjectL_UI_BattleUITask.<>f__mg$cache6B == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleUITask.<>f__mg$cache6B = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleUITask.FindAttackPosition);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_BattleUITask.<>f__mg$cache6B);
		if (Lua_BlackJack_ProjectL_UI_BattleUITask.<>f__mg$cache6C == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleUITask.<>f__mg$cache6C = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleUITask.CanAction);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_BattleUITask.<>f__mg$cache6C);
		if (Lua_BlackJack_ProjectL_UI_BattleUITask.<>f__mg$cache6D == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleUITask.<>f__mg$cache6D = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleUITask.GetMapBattleActor);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_BattleUITask.<>f__mg$cache6D);
		if (Lua_BlackJack_ProjectL_UI_BattleUITask.<>f__mg$cache6E == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleUITask.<>f__mg$cache6E = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleUITask.ResetActorEffect);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_BattleUITask.<>f__mg$cache6E);
		if (Lua_BlackJack_ProjectL_UI_BattleUITask.<>f__mg$cache6F == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleUITask.<>f__mg$cache6F = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleUITask.CanUseSkillAtPosition);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_BattleUITask.<>f__mg$cache6F);
		if (Lua_BlackJack_ProjectL_UI_BattleUITask.<>f__mg$cache70 == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleUITask.<>f__mg$cache70 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleUITask.FindMoveRegion);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_BattleUITask.<>f__mg$cache70);
		if (Lua_BlackJack_ProjectL_UI_BattleUITask.<>f__mg$cache71 == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleUITask.<>f__mg$cache71 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleUITask.ShowMoveAndAttackRegion);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_BattleUITask.<>f__mg$cache71);
		if (Lua_BlackJack_ProjectL_UI_BattleUITask.<>f__mg$cache72 == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleUITask.<>f__mg$cache72 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleUITask.ShowMoveRegion);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_BattleUITask.<>f__mg$cache72);
		if (Lua_BlackJack_ProjectL_UI_BattleUITask.<>f__mg$cache73 == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleUITask.<>f__mg$cache73 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleUITask.UpdateDangerRegion);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_BattleUITask.<>f__mg$cache73);
		if (Lua_BlackJack_ProjectL_UI_BattleUITask.<>f__mg$cache74 == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleUITask.<>f__mg$cache74 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleUITask.ShowDangerTeamRegion);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_BattleUITask.<>f__mg$cache74);
		if (Lua_BlackJack_ProjectL_UI_BattleUITask.<>f__mg$cache75 == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleUITask.<>f__mg$cache75 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleUITask.ShowDangerRegion);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_BattleUITask.<>f__mg$cache75);
		if (Lua_BlackJack_ProjectL_UI_BattleUITask.<>f__mg$cache76 == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleUITask.<>f__mg$cache76 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleUITask.ShowMovePath);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_BattleUITask.<>f__mg$cache76);
		if (Lua_BlackJack_ProjectL_UI_BattleUITask.<>f__mg$cache77 == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleUITask.<>f__mg$cache77 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleUITask.GetSummonMoveType);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_BattleUITask.<>f__mg$cache77);
		if (Lua_BlackJack_ProjectL_UI_BattleUITask.<>f__mg$cache78 == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleUITask.<>f__mg$cache78 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleUITask.ShowSkillRegion);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_BattleUITask.<>f__mg$cache78);
		if (Lua_BlackJack_ProjectL_UI_BattleUITask.<>f__mg$cache79 == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleUITask.<>f__mg$cache79 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleUITask.ShowSkillRange);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_BattleUITask.<>f__mg$cache79);
		if (Lua_BlackJack_ProjectL_UI_BattleUITask.<>f__mg$cache7A == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleUITask.<>f__mg$cache7A = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleUITask.ShowTeleportRegion);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_BattleUITask.<>f__mg$cache7A);
		if (Lua_BlackJack_ProjectL_UI_BattleUITask.<>f__mg$cache7B == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleUITask.<>f__mg$cache7B = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleUITask.ShowAttackTargets);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_BattleUITask.<>f__mg$cache7B);
		if (Lua_BlackJack_ProjectL_UI_BattleUITask.<>f__mg$cache7C == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleUITask.<>f__mg$cache7C = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleUITask.ShowSkillTargets);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_BattleUITask.<>f__mg$cache7C);
		if (Lua_BlackJack_ProjectL_UI_BattleUITask.<>f__mg$cache7D == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleUITask.<>f__mg$cache7D = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleUITask.ShowBattleTreasureDialog);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_BattleUITask.<>f__mg$cache7D);
		if (Lua_BlackJack_ProjectL_UI_BattleUITask.<>f__mg$cache7E == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleUITask.<>f__mg$cache7E = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleUITask.ShowBattleTreasureReward);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_BattleUITask.<>f__mg$cache7E);
		if (Lua_BlackJack_ProjectL_UI_BattleUITask.<>f__mg$cache7F == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleUITask.<>f__mg$cache7F = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleUITask.ShowPreCombat);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_BattleUITask.<>f__mg$cache7F);
		if (Lua_BlackJack_ProjectL_UI_BattleUITask.<>f__mg$cache80 == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleUITask.<>f__mg$cache80 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleUITask.ShowFastCombat);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_BattleUITask.<>f__mg$cache80);
		if (Lua_BlackJack_ProjectL_UI_BattleUITask.<>f__mg$cache81 == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleUITask.<>f__mg$cache81 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleUITask.ShowActorInfo);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_BattleUITask.<>f__mg$cache81);
		if (Lua_BlackJack_ProjectL_UI_BattleUITask.<>f__mg$cache82 == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleUITask.<>f__mg$cache82 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleUITask.HideActorInfo);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_BattleUITask.<>f__mg$cache82);
		if (Lua_BlackJack_ProjectL_UI_BattleUITask.<>f__mg$cache83 == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleUITask.<>f__mg$cache83 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleUITask.ShowSelectionMarkAndTerrain);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_BattleUITask.<>f__mg$cache83);
		if (Lua_BlackJack_ProjectL_UI_BattleUITask.<>f__mg$cache84 == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleUITask.<>f__mg$cache84 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleUITask.SetUIStateNone);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_BattleUITask.<>f__mg$cache84);
		if (Lua_BlackJack_ProjectL_UI_BattleUITask.<>f__mg$cache85 == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleUITask.<>f__mg$cache85 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleUITask.SetUIStateSelectActionActor);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_BattleUITask.<>f__mg$cache85);
		if (Lua_BlackJack_ProjectL_UI_BattleUITask.<>f__mg$cache86 == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleUITask.<>f__mg$cache86 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleUITask.SetUIStateMove);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_BattleUITask.<>f__mg$cache86);
		if (Lua_BlackJack_ProjectL_UI_BattleUITask.<>f__mg$cache87 == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleUITask.<>f__mg$cache87 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleUITask.ShowSkills);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_BattleUITask.<>f__mg$cache87);
		if (Lua_BlackJack_ProjectL_UI_BattleUITask.<>f__mg$cache88 == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleUITask.<>f__mg$cache88 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleUITask.SetUIStateExtraMove);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_BattleUITask.<>f__mg$cache88);
		if (Lua_BlackJack_ProjectL_UI_BattleUITask.<>f__mg$cache89 == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleUITask.<>f__mg$cache89 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleUITask.SetUIStateSelectSkillTarget);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_BattleUITask.<>f__mg$cache89);
		if (Lua_BlackJack_ProjectL_UI_BattleUITask.<>f__mg$cache8A == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleUITask.<>f__mg$cache8A = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleUITask.SetUIStateConfirmSkill);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_BattleUITask.<>f__mg$cache8A);
		if (Lua_BlackJack_ProjectL_UI_BattleUITask.<>f__mg$cache8B == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleUITask.<>f__mg$cache8B = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleUITask.SetUIStateSelectTeleportPosition1);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_BattleUITask.<>f__mg$cache8B);
		if (Lua_BlackJack_ProjectL_UI_BattleUITask.<>f__mg$cache8C == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleUITask.<>f__mg$cache8C = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleUITask.SetUIStateSelectTeleportPosition2);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_BattleUITask.<>f__mg$cache8C);
		if (Lua_BlackJack_ProjectL_UI_BattleUITask.<>f__mg$cache8D == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleUITask.<>f__mg$cache8D = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleUITask.SetUIStateWaitOtherPlayer);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_BattleUITask.<>f__mg$cache8D);
		if (Lua_BlackJack_ProjectL_UI_BattleUITask.<>f__mg$cache8E == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleUITask.<>f__mg$cache8E = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleUITask.ShowCanActionActorsUI);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_BattleUITask.<>f__mg$cache8E);
		if (Lua_BlackJack_ProjectL_UI_BattleUITask.<>f__mg$cache8F == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleUITask.<>f__mg$cache8F = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleUITask.HideCanActionActorsUI);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_BattleUITask.<>f__mg$cache8F);
		if (Lua_BlackJack_ProjectL_UI_BattleUITask.<>f__mg$cache90 == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleUITask.<>f__mg$cache90 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleUITask.DoAutoBattle);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_BattleUITask.<>f__mg$cache90);
		if (Lua_BlackJack_ProjectL_UI_BattleUITask.<>f__mg$cache91 == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleUITask.<>f__mg$cache91 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleUITask.SetAutoBattle);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_BattleUITask.<>f__mg$cache91);
		if (Lua_BlackJack_ProjectL_UI_BattleUITask.<>f__mg$cache92 == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleUITask.<>f__mg$cache92 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleUITask.CameraFocusActor);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_BattleUITask.<>f__mg$cache92);
		if (Lua_BlackJack_ProjectL_UI_BattleUITask.<>f__mg$cache93 == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleUITask.<>f__mg$cache93 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleUITask.BattleUIController_OnAutoBattle);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_BattleUITask.<>f__mg$cache93);
		if (Lua_BlackJack_ProjectL_UI_BattleUITask.<>f__mg$cache94 == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleUITask.<>f__mg$cache94 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleUITask.BattleUIController_OnFastBattle);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_BattleUITask.<>f__mg$cache94);
		if (Lua_BlackJack_ProjectL_UI_BattleUITask.<>f__mg$cache95 == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleUITask.<>f__mg$cache95 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleUITask.BattleUIController_OnSkipCombat);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_BattleUITask.<>f__mg$cache95);
		if (Lua_BlackJack_ProjectL_UI_BattleUITask.<>f__mg$cache96 == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleUITask.<>f__mg$cache96 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleUITask.BattleUIController_OnShowDanger);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_BattleUITask.<>f__mg$cache96);
		if (Lua_BlackJack_ProjectL_UI_BattleUITask.<>f__mg$cache97 == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleUITask.<>f__mg$cache97 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleUITask.BattleUIController_OnEndAllAction);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_BattleUITask.<>f__mg$cache97);
		if (Lua_BlackJack_ProjectL_UI_BattleUITask.<>f__mg$cache98 == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleUITask.<>f__mg$cache98 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleUITask.EndAllActionDialogBoxCallback);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_BattleUITask.<>f__mg$cache98);
		if (Lua_BlackJack_ProjectL_UI_BattleUITask.<>f__mg$cache99 == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleUITask.<>f__mg$cache99 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleUITask.BattleUIController_OnEndAction);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_BattleUITask.<>f__mg$cache99);
		if (Lua_BlackJack_ProjectL_UI_BattleUITask.<>f__mg$cache9A == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleUITask.<>f__mg$cache9A = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleUITask.BattleUIController_OnShowActorInfo);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_BattleUITask.<>f__mg$cache9A);
		if (Lua_BlackJack_ProjectL_UI_BattleUITask.<>f__mg$cache9B == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleUITask.<>f__mg$cache9B = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleUITask.BattleUIController_OnSelectSkill);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_BattleUITask.<>f__mg$cache9B);
		if (Lua_BlackJack_ProjectL_UI_BattleUITask.<>f__mg$cache9C == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleUITask.<>f__mg$cache9C = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleUITask.BattleUIController_OnUseSkill);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_BattleUITask.<>f__mg$cache9C);
		if (Lua_BlackJack_ProjectL_UI_BattleUITask.<>f__mg$cache9D == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleUITask.<>f__mg$cache9D = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleUITask.BattleUIController_OnCancelSkill);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_BattleUITask.<>f__mg$cache9D);
		if (Lua_BlackJack_ProjectL_UI_BattleUITask.<>f__mg$cache9E == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleUITask.<>f__mg$cache9E = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleUITask.BattleUIController_OnShowChat);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_BattleUITask.<>f__mg$cache9E);
		if (Lua_BlackJack_ProjectL_UI_BattleUITask.<>f__mg$cache9F == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleUITask.<>f__mg$cache9F = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleUITask.BattleUIController_OnShowHelp);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_BattleUITask.<>f__mg$cache9F);
		if (Lua_BlackJack_ProjectL_UI_BattleUITask.<>f__mg$cacheA0 == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleUITask.<>f__mg$cacheA0 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleUITask.BattleUIController_OnPauseBattle);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_BattleUITask.<>f__mg$cacheA0);
		if (Lua_BlackJack_ProjectL_UI_BattleUITask.<>f__mg$cacheA1 == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleUITask.<>f__mg$cacheA1 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleUITask.BattleUIController_OnShowArmyRelation);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_BattleUITask.<>f__mg$cacheA1);
		if (Lua_BlackJack_ProjectL_UI_BattleUITask.<>f__mg$cacheA2 == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleUITask.<>f__mg$cacheA2 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleUITask.BattleUIController_OnPointerDown);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_BattleUITask.<>f__mg$cacheA2);
		if (Lua_BlackJack_ProjectL_UI_BattleUITask.<>f__mg$cacheA3 == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleUITask.<>f__mg$cacheA3 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleUITask.BattleUIController_OnPointerUp);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_BattleUITask.<>f__mg$cacheA3);
		if (Lua_BlackJack_ProjectL_UI_BattleUITask.<>f__mg$cacheA4 == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleUITask.<>f__mg$cacheA4 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleUITask.BattleUIController_OnShowCurTurnDanmaku);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_BattleUITask.<>f__mg$cacheA4);
		if (Lua_BlackJack_ProjectL_UI_BattleUITask.<>f__mg$cacheA5 == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleUITask.<>f__mg$cacheA5 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleUITask.BattleUIController_OnCloseCurTurnDanmaku);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_BattleUITask.<>f__mg$cacheA5);
		if (Lua_BlackJack_ProjectL_UI_BattleUITask.<>f__mg$cacheA6 == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleUITask.<>f__mg$cacheA6 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleUITask.BattleUIController_OnShowOneDanmaku);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_BattleUITask.<>f__mg$cacheA6);
		if (Lua_BlackJack_ProjectL_UI_BattleUITask.<>f__mg$cacheA7 == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleUITask.<>f__mg$cacheA7 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleUITask.BattleUIController_OnPointerClick);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_BattleUITask.<>f__mg$cacheA7);
		if (Lua_BlackJack_ProjectL_UI_BattleUITask.<>f__mg$cacheA8 == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleUITask.<>f__mg$cacheA8 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleUITask.ShouldShowActorInfo);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_BattleUITask.<>f__mg$cacheA8);
		if (Lua_BlackJack_ProjectL_UI_BattleUITask.<>f__mg$cacheA9 == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleUITask.<>f__mg$cacheA9 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleUITask.BattleUIController_On3DTouch);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_BattleUITask.<>f__mg$cacheA9);
		if (Lua_BlackJack_ProjectL_UI_BattleUITask.<>f__mg$cacheAA == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleUITask.<>f__mg$cacheAA = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleUITask.PlaySelectHeroSound);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_BattleUITask.<>f__mg$cacheAA);
		if (Lua_BlackJack_ProjectL_UI_BattleUITask.<>f__mg$cacheAB == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleUITask.<>f__mg$cacheAB = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleUITask.BattleDialogUITask_OnClose);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_BattleUITask.<>f__mg$cacheAB);
		if (Lua_BlackJack_ProjectL_UI_BattleUITask.<>f__mg$cacheAC == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleUITask.<>f__mg$cacheAC = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleUITask.BattleTreasureDialogUIController_OnClose);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_BattleUITask.<>f__mg$cacheAC);
		if (Lua_BlackJack_ProjectL_UI_BattleUITask.<>f__mg$cacheAD == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleUITask.<>f__mg$cacheAD = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleUITask.GetRewardGoodsUITask_OnStop);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_BattleUITask.<>f__mg$cacheAD);
		if (Lua_BlackJack_ProjectL_UI_BattleUITask.<>f__mg$cacheAE == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleUITask.<>f__mg$cacheAE = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleUITask.GetRewardGoodsUITask_OnClose);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_BattleUITask.<>f__mg$cacheAE);
		if (Lua_BlackJack_ProjectL_UI_BattleUITask.<>f__mg$cacheAF == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleUITask.<>f__mg$cacheAF = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleUITask.CombatUIController_OnAutoBattle);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_BattleUITask.<>f__mg$cacheAF);
		if (Lua_BlackJack_ProjectL_UI_BattleUITask.<>f__mg$cacheB0 == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleUITask.<>f__mg$cacheB0 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleUITask.PreCombatUIController_OnOk);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_BattleUITask.<>f__mg$cacheB0);
		if (Lua_BlackJack_ProjectL_UI_BattleUITask.<>f__mg$cacheB1 == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleUITask.<>f__mg$cacheB1 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleUITask.PreCombatUIController_OnCancel);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_BattleUITask.<>f__mg$cacheB1);
		if (Lua_BlackJack_ProjectL_UI_BattleUITask.<>f__mg$cacheB2 == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleUITask.<>f__mg$cacheB2 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleUITask.PreCombatUIController_OnStop);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_BattleUITask.<>f__mg$cacheB2);
		if (Lua_BlackJack_ProjectL_UI_BattleUITask.<>f__mg$cacheB3 == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleUITask.<>f__mg$cacheB3 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleUITask.BattleSceneUIController_OnPointerDown);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_BattleUITask.<>f__mg$cacheB3);
		if (Lua_BlackJack_ProjectL_UI_BattleUITask.<>f__mg$cacheB4 == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleUITask.<>f__mg$cacheB4 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleUITask.BattleSceneUIController_OnPointerUp);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_BattleUITask.<>f__mg$cacheB4);
		if (Lua_BlackJack_ProjectL_UI_BattleUITask.<>f__mg$cacheB5 == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleUITask.<>f__mg$cacheB5 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleUITask.BattleSceneUIController_OnPointerClick);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_BattleUITask.<>f__mg$cacheB5);
		if (Lua_BlackJack_ProjectL_UI_BattleUITask.<>f__mg$cacheB6 == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleUITask.<>f__mg$cacheB6 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleUITask.BattleSceneUIController_OnBeginDrag);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_BattleUITask.<>f__mg$cacheB6);
		if (Lua_BlackJack_ProjectL_UI_BattleUITask.<>f__mg$cacheB7 == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleUITask.<>f__mg$cacheB7 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleUITask.BattleSceneUIController_OnEndDrag);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_BattleUITask.<>f__mg$cacheB7);
		if (Lua_BlackJack_ProjectL_UI_BattleUITask.<>f__mg$cacheB8 == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleUITask.<>f__mg$cacheB8 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleUITask.BattleSceneUIController_OnDrag);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_BattleUITask.<>f__mg$cacheB8);
		if (Lua_BlackJack_ProjectL_UI_BattleUITask.<>f__mg$cacheB9 == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleUITask.<>f__mg$cacheB9 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleUITask.BattleSceneUIController_On3DTouch);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_BattleUITask.<>f__mg$cacheB9);
		if (Lua_BlackJack_ProjectL_UI_BattleUITask.<>f__mg$cacheBA == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleUITask.<>f__mg$cacheBA = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleUITask.SendBattleCommands);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_BattleUITask.<>f__mg$cacheBA);
		if (Lua_BlackJack_ProjectL_UI_BattleUITask.<>f__mg$cacheBB == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleUITask.<>f__mg$cacheBB = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleUITask.UpdateBattleRoomPlayerHeroStatus);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_BattleUITask.<>f__mg$cacheBB);
		if (Lua_BlackJack_ProjectL_UI_BattleUITask.<>f__mg$cacheBC == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleUITask.<>f__mg$cacheBC = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleUITask.StartBattleRoomMyActionCountdown);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_BattleUITask.<>f__mg$cacheBC);
		if (Lua_BlackJack_ProjectL_UI_BattleUITask.<>f__mg$cacheBD == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleUITask.<>f__mg$cacheBD = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleUITask.StopBattleRoomMyActionCountdown);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_BattleUITask.<>f__mg$cacheBD);
		if (Lua_BlackJack_ProjectL_UI_BattleUITask.<>f__mg$cacheBE == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleUITask.<>f__mg$cacheBE = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleUITask.ActivateBattleRoomMyActionCountdown);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_BattleUITask.<>f__mg$cacheBE);
		if (Lua_BlackJack_ProjectL_UI_BattleUITask.<>f__mg$cacheBF == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleUITask.<>f__mg$cacheBF = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleUITask.UpdateBattleRoomMyActionCountdown);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_BattleUITask.<>f__mg$cacheBF);
		if (Lua_BlackJack_ProjectL_UI_BattleUITask.<>f__mg$cacheC0 == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleUITask.<>f__mg$cacheC0 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleUITask.StartBattleRoomOtherActionCountdown);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_BattleUITask.<>f__mg$cacheC0);
		if (Lua_BlackJack_ProjectL_UI_BattleUITask.<>f__mg$cacheC1 == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleUITask.<>f__mg$cacheC1 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleUITask.StopBattleRoomOtherActionCountdown);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_BattleUITask.<>f__mg$cacheC1);
		if (Lua_BlackJack_ProjectL_UI_BattleUITask.<>f__mg$cacheC2 == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleUITask.<>f__mg$cacheC2 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleUITask.ActivateBattleRoomOtherActionCountdown);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_BattleUITask.<>f__mg$cacheC2);
		if (Lua_BlackJack_ProjectL_UI_BattleUITask.<>f__mg$cacheC3 == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleUITask.<>f__mg$cacheC3 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleUITask.UpdateBattleRoomOtherActionCountdown);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_BattleUITask.<>f__mg$cacheC3);
		if (Lua_BlackJack_ProjectL_UI_BattleUITask.<>f__mg$cacheC4 == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleUITask.<>f__mg$cacheC4 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleUITask.BattleRoomSetAutoBattle);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_BattleUITask.<>f__mg$cacheC4);
		if (Lua_BlackJack_ProjectL_UI_BattleUITask.<>f__mg$cacheC5 == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleUITask.<>f__mg$cacheC5 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleUITask.ProcessBattlePendingNtfs);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_BattleUITask.<>f__mg$cacheC5);
		if (Lua_BlackJack_ProjectL_UI_BattleUITask.<>f__mg$cacheC6 == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleUITask.<>f__mg$cacheC6 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleUITask.PlayerContext_OnBattleRoomPlayerStatusChangedNtf);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_BattleUITask.<>f__mg$cacheC6);
		if (Lua_BlackJack_ProjectL_UI_BattleUITask.<>f__mg$cacheC7 == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleUITask.<>f__mg$cacheC7 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleUITask.PlayerContext_OnBattleRoomPlayerQuitNtf);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_BattleUITask.<>f__mg$cacheC7);
		if (Lua_BlackJack_ProjectL_UI_BattleUITask.<>f__mg$cacheC8 == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleUITask.<>f__mg$cacheC8 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleUITask.PlayerContext_OnBattleRoomBattleCommandExecuteNtf);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_BattleUITask.<>f__mg$cacheC8);
		if (Lua_BlackJack_ProjectL_UI_BattleUITask.<>f__mg$cacheC9 == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleUITask.<>f__mg$cacheC9 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleUITask.PlayerContext_OnBattleRoomTeamBattleFinishNtf);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_BattleUITask.<>f__mg$cacheC9);
		if (Lua_BlackJack_ProjectL_UI_BattleUITask.<>f__mg$cacheCA == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleUITask.<>f__mg$cacheCA = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleUITask.PlayerContext_OnBattleRoomPVPBattleFinishNtf);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_BattleUITask.<>f__mg$cacheCA);
		if (Lua_BlackJack_ProjectL_UI_BattleUITask.<>f__mg$cacheCB == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleUITask.<>f__mg$cacheCB = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleUITask.PlayerContext_OnBattleRoomRealTimePVPBattleFinishNtf);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_BattleUITask.<>f__mg$cacheCB);
		if (Lua_BlackJack_ProjectL_UI_BattleUITask.<>f__mg$cacheCC == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleUITask.<>f__mg$cacheCC = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleUITask.PlayerContext_OnBattleRoomGuildMassiveCombatBattleFinishNtf);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_BattleUITask.<>f__mg$cacheCC);
		if (Lua_BlackJack_ProjectL_UI_BattleUITask.<>f__mg$cacheCD == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleUITask.<>f__mg$cacheCD = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleUITask.PlayerContext_OnBattleRoomPVPBattleJoinNtf);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_BattleUITask.<>f__mg$cacheCD);
		if (Lua_BlackJack_ProjectL_UI_BattleUITask.<>f__mg$cacheCE == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleUITask.<>f__mg$cacheCE = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleUITask.PlayerContext_OnPlayerInfoInitEnd);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_BattleUITask.<>f__mg$cacheCE);
		if (Lua_BlackJack_ProjectL_UI_BattleUITask.<>f__mg$cacheCF == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleUITask.<>f__mg$cacheCF = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleUITask.ReloginUITask_OnReloginSuccess);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_BattleUITask.<>f__mg$cacheCF);
		if (Lua_BlackJack_ProjectL_UI_BattleUITask.<>f__mg$cacheD0 == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleUITask.<>f__mg$cacheD0 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleUITask.GetBattleRoom);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_BattleUITask.<>f__mg$cacheD0);
		if (Lua_BlackJack_ProjectL_UI_BattleUITask.<>f__mg$cacheD1 == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleUITask.<>f__mg$cacheD1 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleUITask.UpdateBattleRoomPrepareTimeout);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_BattleUITask.<>f__mg$cacheD1);
		if (Lua_BlackJack_ProjectL_UI_BattleUITask.<>f__mg$cacheD2 == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleUITask.<>f__mg$cacheD2 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleUITask.UpdateRealtimePVPBattlePrepareTimeout);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_BattleUITask.<>f__mg$cacheD2);
		if (Lua_BlackJack_ProjectL_UI_BattleUITask.<>f__mg$cacheD3 == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleUITask.<>f__mg$cacheD3 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleUITask.UpdateRealtimePVPBattlePrepareStatus);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_BattleUITask.<>f__mg$cacheD3);
		if (Lua_BlackJack_ProjectL_UI_BattleUITask.<>f__mg$cacheD4 == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleUITask.<>f__mg$cacheD4 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleUITask.UpdateStageActorTag);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_BattleUITask.<>f__mg$cacheD4);
		if (Lua_BlackJack_ProjectL_UI_BattleUITask.<>f__mg$cacheD5 == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleUITask.<>f__mg$cacheD5 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleUITask.ProcessBattlePreparePendingNtfs);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_BattleUITask.<>f__mg$cacheD5);
		if (Lua_BlackJack_ProjectL_UI_BattleUITask.<>f__mg$cacheD6 == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleUITask.<>f__mg$cacheD6 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleUITask.LoadAndUpdateBattleRoomStageActors);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_BattleUITask.<>f__mg$cacheD6);
		if (Lua_BlackJack_ProjectL_UI_BattleUITask.<>f__mg$cacheD7 == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleUITask.<>f__mg$cacheD7 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleUITask.UpdateBattleRoomStageActors);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_BattleUITask.<>f__mg$cacheD7);
		if (Lua_BlackJack_ProjectL_UI_BattleUITask.<>f__mg$cacheD8 == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleUITask.<>f__mg$cacheD8 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleUITask.BattleRoomBattleStart);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_BattleUITask.<>f__mg$cacheD8);
		if (Lua_BlackJack_ProjectL_UI_BattleUITask.<>f__mg$cacheD9 == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleUITask.<>f__mg$cacheD9 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleUITask.PVPBattlePrepareUIController_OnPrepareConfirm);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_BattleUITask.<>f__mg$cacheD9);
		if (Lua_BlackJack_ProjectL_UI_BattleUITask.<>f__mg$cacheDA == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleUITask.<>f__mg$cacheDA = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleUITask.PlayerContext_OnBattleRoomHeroSetupNtf);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_BattleUITask.<>f__mg$cacheDA);
		if (Lua_BlackJack_ProjectL_UI_BattleUITask.<>f__mg$cacheDB == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleUITask.<>f__mg$cacheDB = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleUITask.PlayerContext_OnBattleRoomDataChangeNtf);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_BattleUITask.<>f__mg$cacheDB);
		if (Lua_BlackJack_ProjectL_UI_BattleUITask.<>f__mg$cacheDC == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleUITask.<>f__mg$cacheDC = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleUITask.PlayerContext_OnBattleRoomTeamBattleStartNtf);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_BattleUITask.<>f__mg$cacheDC);
		if (Lua_BlackJack_ProjectL_UI_BattleUITask.<>f__mg$cacheDD == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleUITask.<>f__mg$cacheDD = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleUITask.PlayerContext_OnBattleRoomPVPBattleStartNtf);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_BattleUITask.<>f__mg$cacheDD);
		if (Lua_BlackJack_ProjectL_UI_BattleUITask.<>f__mg$cacheDE == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleUITask.<>f__mg$cacheDE = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleUITask.PlayerContext_OnBattleRoomRealTimePVPBattleStartNtf);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_BattleUITask.<>f__mg$cacheDE);
		if (Lua_BlackJack_ProjectL_UI_BattleUITask.<>f__mg$cacheDF == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleUITask.<>f__mg$cacheDF = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleUITask.ShowBattleResult);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_BattleUITask.<>f__mg$cacheDF);
		if (Lua_BlackJack_ProjectL_UI_BattleUITask.<>f__mg$cacheE0 == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleUITask.<>f__mg$cacheE0 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleUITask.ShowBattleLose);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_BattleUITask.<>f__mg$cacheE0);
		if (Lua_BlackJack_ProjectL_UI_BattleUITask.<>f__mg$cacheE1 == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleUITask.<>f__mg$cacheE1 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleUITask.ShowBattleReportEnd);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_BattleUITask.<>f__mg$cacheE1);
		if (Lua_BlackJack_ProjectL_UI_BattleUITask.<>f__mg$cacheE2 == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleUITask.<>f__mg$cacheE2 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleUITask.BuildBattleReport);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_BattleUITask.<>f__mg$cacheE2);
		if (Lua_BlackJack_ProjectL_UI_BattleUITask.<>f__mg$cacheE3 == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleUITask.<>f__mg$cacheE3 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleUITask.CheckBattleResult);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_BattleUITask.<>f__mg$cacheE3);
		if (Lua_BlackJack_ProjectL_UI_BattleUITask.<>f__mg$cacheE4 == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleUITask.<>f__mg$cacheE4 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleUITask.SendBattleCheatGMCommand);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_BattleUITask.<>f__mg$cacheE4);
		if (Lua_BlackJack_ProjectL_UI_BattleUITask.<>f__mg$cacheE5 == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleUITask.<>f__mg$cacheE5 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleUITask.BattleResultEnd);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_BattleUITask.<>f__mg$cacheE5);
		if (Lua_BlackJack_ProjectL_UI_BattleUITask.<>f__mg$cacheE6 == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleUITask.<>f__mg$cacheE6 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleUITask.BattleRoomInviteTeammateDialogBoxCallback);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_BattleUITask.<>f__mg$cacheE6);
		if (Lua_BlackJack_ProjectL_UI_BattleUITask.<>f__mg$cacheE7 == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleUITask.<>f__mg$cacheE7 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleUITask.BattleUIController_OnWinOrLoseEnd);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_BattleUITask.<>f__mg$cacheE7);
		if (Lua_BlackJack_ProjectL_UI_BattleUITask.<>f__mg$cacheE8 == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleUITask.<>f__mg$cacheE8 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleUITask.BattleResultUITask_OnStop);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_BattleUITask.<>f__mg$cacheE8);
		if (Lua_BlackJack_ProjectL_UI_BattleUITask.<>f__mg$cacheE9 == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleUITask.<>f__mg$cacheE9 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleUITask.BattleResultUITask_OnClose);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_BattleUITask.<>f__mg$cacheE9);
		if (Lua_BlackJack_ProjectL_UI_BattleUITask.<>f__mg$cacheEA == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleUITask.<>f__mg$cacheEA = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleUITask.BattleResultScoreUITask_OnStop);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_BattleUITask.<>f__mg$cacheEA);
		if (Lua_BlackJack_ProjectL_UI_BattleUITask.<>f__mg$cacheEB == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleUITask.<>f__mg$cacheEB = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleUITask.BattleResultScoreUITask_OnClose);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_BattleUITask.<>f__mg$cacheEB);
		if (Lua_BlackJack_ProjectL_UI_BattleUITask.<>f__mg$cacheEC == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleUITask.<>f__mg$cacheEC = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleUITask.BattleLoseUITask_OnStop);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_BattleUITask.<>f__mg$cacheEC);
		if (Lua_BlackJack_ProjectL_UI_BattleUITask.<>f__mg$cacheED == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleUITask.<>f__mg$cacheED = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleUITask.BattleLoseUITask_OnClose);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_BattleUITask.<>f__mg$cacheED);
		if (Lua_BlackJack_ProjectL_UI_BattleUITask.<>f__mg$cacheEE == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleUITask.<>f__mg$cacheEE = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleUITask.BattleReportEndUITask_OnStop);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_BattleUITask.<>f__mg$cacheEE);
		if (Lua_BlackJack_ProjectL_UI_BattleUITask.<>f__mg$cacheEF == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleUITask.<>f__mg$cacheEF = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleUITask.BattleReportEndUITask_OnClose);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_BattleUITask.<>f__mg$cacheEF);
		if (Lua_BlackJack_ProjectL_UI_BattleUITask.<>f__mg$cacheF0 == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleUITask.<>f__mg$cacheF0 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleUITask.BattleReportEndUITask_OnPlayAgain);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_BattleUITask.<>f__mg$cacheF0);
		if (Lua_BlackJack_ProjectL_UI_BattleUITask.<>f__mg$cacheF1 == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleUITask.<>f__mg$cacheF1 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleUITask.RegisterPlayerContextEvents);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_BattleUITask.<>f__mg$cacheF1);
		if (Lua_BlackJack_ProjectL_UI_BattleUITask.<>f__mg$cacheF2 == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleUITask.<>f__mg$cacheF2 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleUITask.UnregisterPlayerContextEvents);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_BattleUITask.<>f__mg$cacheF2);
		if (Lua_BlackJack_ProjectL_UI_BattleUITask.<>f__mg$cacheF3 == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleUITask.<>f__mg$cacheF3 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleUITask.InitBattleSceneUIController);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_BattleUITask.<>f__mg$cacheF3);
		if (Lua_BlackJack_ProjectL_UI_BattleUITask.<>f__mg$cacheF4 == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleUITask.<>f__mg$cacheF4 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleUITask.UninitBattleSceneUIController);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_BattleUITask.<>f__mg$cacheF4);
		if (Lua_BlackJack_ProjectL_UI_BattleUITask.<>f__mg$cacheF5 == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleUITask.<>f__mg$cacheF5 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleUITask.InitBattleUIController);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_BattleUITask.<>f__mg$cacheF5);
		if (Lua_BlackJack_ProjectL_UI_BattleUITask.<>f__mg$cacheF6 == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleUITask.<>f__mg$cacheF6 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleUITask.UninitBattleUIController);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_BattleUITask.<>f__mg$cacheF6);
		if (Lua_BlackJack_ProjectL_UI_BattleUITask.<>f__mg$cacheF7 == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleUITask.<>f__mg$cacheF7 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleUITask.InitCombatUIController);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_BattleUITask.<>f__mg$cacheF7);
		if (Lua_BlackJack_ProjectL_UI_BattleUITask.<>f__mg$cacheF8 == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleUITask.<>f__mg$cacheF8 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleUITask.UninitCombatUIController);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_BattleUITask.<>f__mg$cacheF8);
		if (Lua_BlackJack_ProjectL_UI_BattleUITask.<>f__mg$cacheF9 == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleUITask.<>f__mg$cacheF9 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleUITask.InitPreCombatUIController);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_BattleUITask.<>f__mg$cacheF9);
		if (Lua_BlackJack_ProjectL_UI_BattleUITask.<>f__mg$cacheFA == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleUITask.<>f__mg$cacheFA = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleUITask.UninitPreCombatUIController);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_BattleUITask.<>f__mg$cacheFA);
		if (Lua_BlackJack_ProjectL_UI_BattleUITask.<>f__mg$cacheFB == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleUITask.<>f__mg$cacheFB = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleUITask.InitBattleRoomUIController);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_BattleUITask.<>f__mg$cacheFB);
		if (Lua_BlackJack_ProjectL_UI_BattleUITask.<>f__mg$cacheFC == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleUITask.<>f__mg$cacheFC = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleUITask.UninitBattleRoomUIController);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_BattleUITask.<>f__mg$cacheFC);
		if (Lua_BlackJack_ProjectL_UI_BattleUITask.<>f__mg$cacheFD == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleUITask.<>f__mg$cacheFD = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleUITask.InitBattleCommonUIController);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_BattleUITask.<>f__mg$cacheFD);
		if (Lua_BlackJack_ProjectL_UI_BattleUITask.<>f__mg$cacheFE == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleUITask.<>f__mg$cacheFE = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleUITask.UninitBattleCommonUIController);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_BattleUITask.<>f__mg$cacheFE);
		if (Lua_BlackJack_ProjectL_UI_BattleUITask.<>f__mg$cacheFF == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleUITask.<>f__mg$cacheFF = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleUITask.InitBattlePrepareUIController);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_BattleUITask.<>f__mg$cacheFF);
		if (Lua_BlackJack_ProjectL_UI_BattleUITask.<>f__mg$cache100 == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleUITask.<>f__mg$cache100 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleUITask.UninitBattlePrepareUIController);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_BattleUITask.<>f__mg$cache100);
		if (Lua_BlackJack_ProjectL_UI_BattleUITask.<>f__mg$cache101 == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleUITask.<>f__mg$cache101 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleUITask.BattleDialogUITask_OnLoadAllResCompleted);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_BattleUITask.<>f__mg$cache101);
		if (Lua_BlackJack_ProjectL_UI_BattleUITask.<>f__mg$cache102 == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleUITask.<>f__mg$cache102 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleUITask.StartBattleTeamSetNetTask);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_BattleUITask.<>f__mg$cache102);
		if (Lua_BlackJack_ProjectL_UI_BattleUITask.<>f__mg$cache103 == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleUITask.<>f__mg$cache103 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleUITask.StartLevelAttackNetTask);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_BattleUITask.<>f__mg$cache103);
		if (Lua_BlackJack_ProjectL_UI_BattleUITask.<>f__mg$cache104 == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleUITask.<>f__mg$cache104 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleUITask.StartLevelWayPointMoveNetTask);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_BattleUITask.<>f__mg$cache104);
		if (Lua_BlackJack_ProjectL_UI_BattleUITask.<>f__mg$cache105 == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleUITask.<>f__mg$cache105 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleUITask.StartLevelScenarioHandleNetTask);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_BattleUITask.<>f__mg$cache105);
		if (Lua_BlackJack_ProjectL_UI_BattleUITask.<>f__mg$cache106 == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleUITask.<>f__mg$cache106 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleUITask.StartRiftLevelAttackNetTask);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_BattleUITask.<>f__mg$cache106);
		if (Lua_BlackJack_ProjectL_UI_BattleUITask.<>f__mg$cache107 == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleUITask.<>f__mg$cache107 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleUITask.StartHeroDungeonLevelAttackNetTask);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_BattleUITask.<>f__mg$cache107);
		if (Lua_BlackJack_ProjectL_UI_BattleUITask.<>f__mg$cache108 == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleUITask.<>f__mg$cache108 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleUITask.StartAnikiLevelAttackNetTask);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_BattleUITask.<>f__mg$cache108);
		if (Lua_BlackJack_ProjectL_UI_BattleUITask.<>f__mg$cache109 == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleUITask.<>f__mg$cache109 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleUITask.StartThearchyLevelAttackNetTask);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_BattleUITask.<>f__mg$cache109);
		if (Lua_BlackJack_ProjectL_UI_BattleUITask.<>f__mg$cache10A == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleUITask.<>f__mg$cache10A = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleUITask.StartMemoryCorridorLevelAttackNetTask);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_BattleUITask.<>f__mg$cache10A);
		if (Lua_BlackJack_ProjectL_UI_BattleUITask.<>f__mg$cache10B == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleUITask.<>f__mg$cache10B = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleUITask.StartHeroTrainningLevelAttackNetTask);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_BattleUITask.<>f__mg$cache10B);
		if (Lua_BlackJack_ProjectL_UI_BattleUITask.<>f__mg$cache10C == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleUITask.<>f__mg$cache10C = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleUITask.StartHeroPhantomLevelAttackNetTask);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_BattleUITask.<>f__mg$cache10C);
		if (Lua_BlackJack_ProjectL_UI_BattleUITask.<>f__mg$cache10D == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleUITask.<>f__mg$cache10D = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleUITask.StartTreasureLevelAttackNetTask);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_BattleUITask.<>f__mg$cache10D);
		if (Lua_BlackJack_ProjectL_UI_BattleUITask.<>f__mg$cache10E == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleUITask.<>f__mg$cache10E = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleUITask.StartUnchartedScoreLevelAttackNetTask);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_BattleUITask.<>f__mg$cache10E);
		if (Lua_BlackJack_ProjectL_UI_BattleUITask.<>f__mg$cache10F == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleUITask.<>f__mg$cache10F = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleUITask.StartUnchartedChallengeLevelAttackNetTask);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_BattleUITask.<>f__mg$cache10F);
		if (Lua_BlackJack_ProjectL_UI_BattleUITask.<>f__mg$cache110 == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleUITask.<>f__mg$cache110 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleUITask.StartClimbTowerLevelAttackNetTask);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_BattleUITask.<>f__mg$cache110);
		if (Lua_BlackJack_ProjectL_UI_BattleUITask.<>f__mg$cache111 == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleUITask.<>f__mg$cache111 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleUITask.StartGuildMassiveCombatAttackNetTask);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_BattleUITask.<>f__mg$cache111);
		if (Lua_BlackJack_ProjectL_UI_BattleUITask.<>f__mg$cache112 == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleUITask.<>f__mg$cache112 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleUITask.StartArenaOpponentAttackFightingNetTask);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_BattleUITask.<>f__mg$cache112);
		if (Lua_BlackJack_ProjectL_UI_BattleUITask.<>f__mg$cache113 == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleUITask.<>f__mg$cache113 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleUITask.HandleLevelAttackNetTaskResult);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_BattleUITask.<>f__mg$cache113);
		if (Lua_BlackJack_ProjectL_UI_BattleUITask.<>f__mg$cache114 == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleUITask.<>f__mg$cache114 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleUITask.StartWayPointBattleFinishedNetTask);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_BattleUITask.<>f__mg$cache114);
		if (Lua_BlackJack_ProjectL_UI_BattleUITask.<>f__mg$cache115 == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleUITask.<>f__mg$cache115 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleUITask.StartRiftLevelBattleFinishedNetTask);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_BattleUITask.<>f__mg$cache115);
		if (Lua_BlackJack_ProjectL_UI_BattleUITask.<>f__mg$cache116 == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleUITask.<>f__mg$cache116 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleUITask.StartHeroDungeonLevelBattleFinishedNetTask);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_BattleUITask.<>f__mg$cache116);
		if (Lua_BlackJack_ProjectL_UI_BattleUITask.<>f__mg$cache117 == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleUITask.<>f__mg$cache117 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleUITask.StartAnikiLevelBattleFinishedNetTask);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_BattleUITask.<>f__mg$cache117);
		if (Lua_BlackJack_ProjectL_UI_BattleUITask.<>f__mg$cache118 == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleUITask.<>f__mg$cache118 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleUITask.StartThearchyLevelBattleFinishedNetTask);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_BattleUITask.<>f__mg$cache118);
		if (Lua_BlackJack_ProjectL_UI_BattleUITask.<>f__mg$cache119 == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleUITask.<>f__mg$cache119 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleUITask.StartTreasureLevelBattleFinishedNetTask);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_BattleUITask.<>f__mg$cache119);
		if (Lua_BlackJack_ProjectL_UI_BattleUITask.<>f__mg$cache11A == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleUITask.<>f__mg$cache11A = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleUITask.StartMemoryCorridorLevelBattleFinishedNetTask);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_BattleUITask.<>f__mg$cache11A);
		if (Lua_BlackJack_ProjectL_UI_BattleUITask.<>f__mg$cache11B == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleUITask.<>f__mg$cache11B = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleUITask.StartHeroTrainningLevelBattleFinishedNetTask);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_BattleUITask.<>f__mg$cache11B);
		if (Lua_BlackJack_ProjectL_UI_BattleUITask.<>f__mg$cache11C == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleUITask.<>f__mg$cache11C = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleUITask.StartHeroPhantomLevelBattleFinishedNetTask);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_BattleUITask.<>f__mg$cache11C);
		if (Lua_BlackJack_ProjectL_UI_BattleUITask.<>f__mg$cache11D == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleUITask.<>f__mg$cache11D = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleUITask.StartUnchartedScoreLevelBattleFinishedNetTask);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_BattleUITask.<>f__mg$cache11D);
		if (Lua_BlackJack_ProjectL_UI_BattleUITask.<>f__mg$cache11E == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleUITask.<>f__mg$cache11E = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleUITask.StartUnchartedChallengeLevelBattleFinishedNetTask);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_BattleUITask.<>f__mg$cache11E);
		if (Lua_BlackJack_ProjectL_UI_BattleUITask.<>f__mg$cache11F == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleUITask.<>f__mg$cache11F = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleUITask.StartClimbTowerLevelBattleFinishedNetTask);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_BattleUITask.<>f__mg$cache11F);
		if (Lua_BlackJack_ProjectL_UI_BattleUITask.<>f__mg$cache120 == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleUITask.<>f__mg$cache120 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleUITask.StartGuildMassiveCombatSinglePVEBattleEndNetTask);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_BattleUITask.<>f__mg$cache120);
		if (Lua_BlackJack_ProjectL_UI_BattleUITask.<>f__mg$cache121 == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleUITask.<>f__mg$cache121 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleUITask.StartArenaBattleFinishedNetTask);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_BattleUITask.<>f__mg$cache121);
		if (Lua_BlackJack_ProjectL_UI_BattleUITask.<>f__mg$cache122 == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleUITask.<>f__mg$cache122 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleUITask.HandleBattleFinishedNetTaskResult);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_BattleUITask.<>f__mg$cache122);
		if (Lua_BlackJack_ProjectL_UI_BattleUITask.<>f__mg$cache123 == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleUITask.<>f__mg$cache123 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleUITask.StartBattleCancelNetTask);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_BattleUITask.<>f__mg$cache123);
		if (Lua_BlackJack_ProjectL_UI_BattleUITask.<>f__mg$cache124 == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleUITask.<>f__mg$cache124 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleUITask.StartDanmakuPostNetTask);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_BattleUITask.<>f__mg$cache124);
		if (Lua_BlackJack_ProjectL_UI_BattleUITask.<>f__mg$cache125 == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleUITask.<>f__mg$cache125 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleUITask.StartBattleRoomHeroSetupNetTask);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_BattleUITask.<>f__mg$cache125);
		if (Lua_BlackJack_ProjectL_UI_BattleUITask.<>f__mg$cache126 == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleUITask.<>f__mg$cache126 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleUITask.StartBattleRoomHeroSwapNetTask);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_BattleUITask.<>f__mg$cache126);
		if (Lua_BlackJack_ProjectL_UI_BattleUITask.<>f__mg$cache127 == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleUITask.<>f__mg$cache127 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleUITask.StartBattleRoomHeroSetoffNetTask);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_BattleUITask.<>f__mg$cache127);
		if (Lua_BlackJack_ProjectL_UI_BattleUITask.<>f__mg$cache128 == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleUITask.<>f__mg$cache128 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleUITask.StartBattleRoomPlayerStatusChangeNetTask);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_BattleUITask.<>f__mg$cache128);
		if (Lua_BlackJack_ProjectL_UI_BattleUITask.<>f__mg$cache129 == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleUITask.<>f__mg$cache129 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleUITask.StartBattleRoomQuitNetTask);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_BattleUITask.<>f__mg$cache129);
		if (Lua_BlackJack_ProjectL_UI_BattleUITask.<>f__mg$cache12A == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleUITask.<>f__mg$cache12A = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleUITask.StartBattleRoomEndCurrentBPTurnNetTask);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_BattleUITask.<>f__mg$cache12A);
		if (Lua_BlackJack_ProjectL_UI_BattleUITask.<>f__mg$cache12B == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleUITask.<>f__mg$cache12B = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleUITask.StartBattleRoomPlayerActionBeginNetTask);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_BattleUITask.<>f__mg$cache12B);
		if (Lua_BlackJack_ProjectL_UI_BattleUITask.<>f__mg$cache12C == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleUITask.<>f__mg$cache12C = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleUITask.SetupReachRegion);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_BattleUITask.<>f__mg$cache12C);
		if (Lua_BlackJack_ProjectL_UI_BattleUITask.<>f__mg$cache12D == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleUITask.<>f__mg$cache12D = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleUITask.SetupBattlePauseUIController);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_BattleUITask.<>f__mg$cache12D);
		if (Lua_BlackJack_ProjectL_UI_BattleUITask.<>f__mg$cache12E == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleUITask.<>f__mg$cache12E = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleUITask.SetupBattlePauseUIAchievements);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_BattleUITask.<>f__mg$cache12E);
		if (Lua_BlackJack_ProjectL_UI_BattleUITask.<>f__mg$cache12F == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleUITask.<>f__mg$cache12F = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleUITask.GetWinConditionTargetPosition);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_BattleUITask.<>f__mg$cache12F);
		if (Lua_BlackJack_ProjectL_UI_BattleUITask.<>f__mg$cache130 == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleUITask.<>f__mg$cache130 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleUITask.GetMyStageActorCountMax);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_BattleUITask.<>f__mg$cache130);
		if (Lua_BlackJack_ProjectL_UI_BattleUITask.<>f__mg$cache131 == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleUITask.<>f__mg$cache131 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleUITask.SetupMyHeros);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_BattleUITask.<>f__mg$cache131);
		if (Lua_BlackJack_ProjectL_UI_BattleUITask.<>f__mg$cache132 == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleUITask.<>f__mg$cache132 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleUITask.FillMyHeros);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_BattleUITask.<>f__mg$cache132);
		if (Lua_BlackJack_ProjectL_UI_BattleUITask.<>f__mg$cache133 == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleUITask.<>f__mg$cache133 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleUITask.SetupStageActors);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_BattleUITask.<>f__mg$cache133);
		if (Lua_BlackJack_ProjectL_UI_BattleUITask.<>f__mg$cache134 == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleUITask.<>f__mg$cache134 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleUITask.GetTowerBattleRuleInfo);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_BattleUITask.<>f__mg$cache134);
		if (Lua_BlackJack_ProjectL_UI_BattleUITask.<>f__mg$cache135 == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleUITask.<>f__mg$cache135 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleUITask.GetTowerBonusHeroGroupInfo);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_BattleUITask.<>f__mg$cache135);
		if (Lua_BlackJack_ProjectL_UI_BattleUITask.<>f__mg$cache136 == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleUITask.<>f__mg$cache136 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleUITask.IsTowerPowerUpHero);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_BattleUITask.<>f__mg$cache136);
		if (Lua_BlackJack_ProjectL_UI_BattleUITask.<>f__mg$cache137 == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleUITask.<>f__mg$cache137 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleUITask.GetGuildPlayerMassiveCombatInfo);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_BattleUITask.<>f__mg$cache137);
		if (Lua_BlackJack_ProjectL_UI_BattleUITask.<>f__mg$cache138 == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleUITask.<>f__mg$cache138 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleUITask.IsGuildMassiveCombatCampUpHero);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_BattleUITask.<>f__mg$cache138);
		if (Lua_BlackJack_ProjectL_UI_BattleUITask.<>f__mg$cache139 == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleUITask.<>f__mg$cache139 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleUITask.GetHeroTagType);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_BattleUITask.<>f__mg$cache139);
		if (Lua_BlackJack_ProjectL_UI_BattleUITask.<>f__mg$cache13A == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleUITask.<>f__mg$cache13A = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleUITask.LoadArenaAttackerHeroActionValue);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_BattleUITask.<>f__mg$cache13A);
		if (Lua_BlackJack_ProjectL_UI_BattleUITask.<>f__mg$cache13B == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleUITask.<>f__mg$cache13B = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleUITask.ShowStagePositions);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_BattleUITask.<>f__mg$cache13B);
		if (Lua_BlackJack_ProjectL_UI_BattleUITask.<>f__mg$cache13C == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleUITask.<>f__mg$cache13C = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleUITask.SetupBattlePrepareTreasures);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_BattleUITask.<>f__mg$cache13C);
		if (Lua_BlackJack_ProjectL_UI_BattleUITask.<>f__mg$cache13D == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleUITask.<>f__mg$cache13D = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleUITask.BuildBattleTeamSetups);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_BattleUITask.<>f__mg$cache13D);
		if (Lua_BlackJack_ProjectL_UI_BattleUITask.<>f__mg$cache13E == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleUITask.<>f__mg$cache13E = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleUITask.BuildBattleTeamSetup);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_BattleUITask.<>f__mg$cache13E);
		if (Lua_BlackJack_ProjectL_UI_BattleUITask.<>f__mg$cache13F == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleUITask.<>f__mg$cache13F = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleUITask.GetSoldierCount);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_BattleUITask.<>f__mg$cache13F);
		if (Lua_BlackJack_ProjectL_UI_BattleUITask.<>f__mg$cache140 == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleUITask.<>f__mg$cache140 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleUITask.SetTeamAndStartBattle);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_BattleUITask.<>f__mg$cache140);
		if (Lua_BlackJack_ProjectL_UI_BattleUITask.<>f__mg$cache141 == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleUITask.<>f__mg$cache141 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleUITask.StartBattlePrepareLoadState);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_BattleUITask.<>f__mg$cache141);
		if (Lua_BlackJack_ProjectL_UI_BattleUITask.<>f__mg$cache142 == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleUITask.<>f__mg$cache142 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleUITask.StartBattleLoadState);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_BattleUITask.<>f__mg$cache142);
		if (Lua_BlackJack_ProjectL_UI_BattleUITask.<>f__mg$cache143 == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleUITask.<>f__mg$cache143 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleUITask.ShowMoveAndAttackRegion_Prepare);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_BattleUITask.<>f__mg$cache143);
		if (Lua_BlackJack_ProjectL_UI_BattleUITask.<>f__mg$cache144 == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleUITask.<>f__mg$cache144 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleUITask.UpdateArenaAttackerHeroIds);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_BattleUITask.<>f__mg$cache144);
		if (Lua_BlackJack_ProjectL_UI_BattleUITask.<>f__mg$cache145 == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleUITask.<>f__mg$cache145 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleUITask.GetPlayerTrainingTechs);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_BattleUITask.<>f__mg$cache145);
		if (Lua_BlackJack_ProjectL_UI_BattleUITask.<>f__mg$cache146 == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleUITask.<>f__mg$cache146 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleUITask.GetPlayerLevel);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_BattleUITask.<>f__mg$cache146);
		if (Lua_BlackJack_ProjectL_UI_BattleUITask.<>f__mg$cache147 == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleUITask.<>f__mg$cache147 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleUITask.GetPlayerSessionId);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_BattleUITask.<>f__mg$cache147);
		if (Lua_BlackJack_ProjectL_UI_BattleUITask.<>f__mg$cache148 == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleUITask.<>f__mg$cache148 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleUITask.GetMyPlayerIndex);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_BattleUITask.<>f__mg$cache148);
		if (Lua_BlackJack_ProjectL_UI_BattleUITask.<>f__mg$cache149 == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleUITask.<>f__mg$cache149 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleUITask.IsBattlePrepareDisableCameraMove);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_BattleUITask.<>f__mg$cache149);
		if (Lua_BlackJack_ProjectL_UI_BattleUITask.<>f__mg$cache14A == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleUITask.<>f__mg$cache14A = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleUITask.UpdateBattlePower);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_BattleUITask.<>f__mg$cache14A);
		if (Lua_BlackJack_ProjectL_UI_BattleUITask.<>f__mg$cache14B == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleUITask.<>f__mg$cache14B = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleUITask.BattlePrepareUIController_OnPauseBattle);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_BattleUITask.<>f__mg$cache14B);
		if (Lua_BlackJack_ProjectL_UI_BattleUITask.<>f__mg$cache14C == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleUITask.<>f__mg$cache14C = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleUITask.BattlePrepareUIController_OnShowArmyRelation);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_BattleUITask.<>f__mg$cache14C);
		if (Lua_BlackJack_ProjectL_UI_BattleUITask.<>f__mg$cache14D == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleUITask.<>f__mg$cache14D = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleUITask.BattlePrepareUIController_OnStart);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_BattleUITask.<>f__mg$cache14D);
		if (Lua_BlackJack_ProjectL_UI_BattleUITask.<>f__mg$cache14E == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleUITask.<>f__mg$cache14E = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleUITask.BattlePrepareUIController_OnShowActionOrder);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_BattleUITask.<>f__mg$cache14E);
		if (Lua_BlackJack_ProjectL_UI_BattleUITask.<>f__mg$cache14F == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleUITask.<>f__mg$cache14F = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleUITask.HeroNotFullDialogBoxCallback);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_BattleUITask.<>f__mg$cache14F);
		if (Lua_BlackJack_ProjectL_UI_BattleUITask.<>f__mg$cache150 == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleUITask.<>f__mg$cache150 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleUITask.BattlePrepareUIController_OnTestOnStage);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_BattleUITask.<>f__mg$cache150);
		if (Lua_BlackJack_ProjectL_UI_BattleUITask.<>f__mg$cache151 == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleUITask.<>f__mg$cache151 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleUITask.BattlePrepareUIController_OnShowMyActorInfo);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_BattleUITask.<>f__mg$cache151);
		if (Lua_BlackJack_ProjectL_UI_BattleUITask.<>f__mg$cache152 == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleUITask.<>f__mg$cache152 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleUITask.BattlePrepareUIController_OnHideActorInfo);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_BattleUITask.<>f__mg$cache152);
		if (Lua_BlackJack_ProjectL_UI_BattleUITask.<>f__mg$cache153 == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleUITask.<>f__mg$cache153 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleUITask.BattlePrepareUIController_OnStageActorChange);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_BattleUITask.<>f__mg$cache153);
		if (Lua_BlackJack_ProjectL_UI_BattleUITask.<>f__mg$cache154 == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleUITask.<>f__mg$cache154 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleUITask.BattlePrepareUIController_OnHeroOnStage);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_BattleUITask.<>f__mg$cache154);
		if (Lua_BlackJack_ProjectL_UI_BattleUITask.<>f__mg$cache155 == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleUITask.<>f__mg$cache155 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleUITask.BattlePrepareUIController_OnActorOffStage);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_BattleUITask.<>f__mg$cache155);
		if (Lua_BlackJack_ProjectL_UI_BattleUITask.<>f__mg$cache156 == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleUITask.<>f__mg$cache156 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleUITask.BattlePrepareUIController_OnStageActorMove);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_BattleUITask.<>f__mg$cache156);
		if (Lua_BlackJack_ProjectL_UI_BattleUITask.<>f__mg$cache157 == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleUITask.<>f__mg$cache157 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleUITask.BattlePrepareUIController_OnStageActorSwap);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_BattleUITask.<>f__mg$cache157);
		if (Lua_BlackJack_ProjectL_UI_BattleUITask.<>f__mg$cache158 == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleUITask.<>f__mg$cache158 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleUITask.BattlePrepareUIController_OnUpdateBattlePower);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_BattleUITask.<>f__mg$cache158);
		if (Lua_BlackJack_ProjectL_UI_BattleUITask.<>f__mg$cache159 == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleUITask.<>f__mg$cache159 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleUITask.BattlePrepareUIController_OnShowChat);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_BattleUITask.<>f__mg$cache159);
		if (Lua_BlackJack_ProjectL_UI_BattleUITask.<>f__mg$cache15A == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleUITask.<>f__mg$cache15A = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleUITask.BattlePrepareUIController_OnShowHelp);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_BattleUITask.<>f__mg$cache15A);
		if (Lua_BlackJack_ProjectL_UI_BattleUITask.<>f__mg$cache15B == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleUITask.<>f__mg$cache15B = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleUITask.BattlePrepareUIController_OnPointerDown);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_BattleUITask.<>f__mg$cache15B);
		if (Lua_BlackJack_ProjectL_UI_BattleUITask.<>f__mg$cache15C == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleUITask.<>f__mg$cache15C = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleUITask.BattlePrepareUIController_OnPointerUp);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_BattleUITask.<>f__mg$cache15C);
		if (Lua_BlackJack_ProjectL_UI_BattleUITask.<>f__mg$cache15D == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleUITask.<>f__mg$cache15D = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleUITask.BattlePrepareUIController_OnBeginDragHero);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_BattleUITask.<>f__mg$cache15D);
		if (Lua_BlackJack_ProjectL_UI_BattleUITask.<>f__mg$cache15E == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleUITask.<>f__mg$cache15E = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleUITask.BattlePrepareUIController_OnEndDragHero);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_BattleUITask.<>f__mg$cache15E);
		if (Lua_BlackJack_ProjectL_UI_BattleUITask.<>f__mg$cache15F == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleUITask.<>f__mg$cache15F = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleUITask.BattlePrepareActorInfoUIController_OnShowSelectSoldierPanel);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_BattleUITask.<>f__mg$cache15F);
		if (Lua_BlackJack_ProjectL_UI_BattleUITask.<>f__mg$cache160 == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleUITask.<>f__mg$cache160 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleUITask.BattlePrepareActorInfoUIController_OnChangeSkill);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_BattleUITask.<>f__mg$cache160);
		if (Lua_BlackJack_ProjectL_UI_BattleUITask.<>f__mg$cache161 == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleUITask.<>f__mg$cache161 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleUITask.BattlePrepareActorInfoUIController_OnChangeSoldier);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_BattleUITask.<>f__mg$cache161);
		if (Lua_BlackJack_ProjectL_UI_BattleUITask.<>f__mg$cache162 == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleUITask.<>f__mg$cache162 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleUITask.ActionOrderUIController_OnConfirm);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_BattleUITask.<>f__mg$cache162);
		if (Lua_BlackJack_ProjectL_UI_BattleUITask.<>f__mg$cache163 == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleUITask.<>f__mg$cache163 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleUITask.SetUIStateRegret);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_BattleUITask.<>f__mg$cache163);
		if (Lua_BlackJack_ProjectL_UI_BattleUITask.<>f__mg$cache164 == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleUITask.<>f__mg$cache164 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleUITask.IsRegretActive);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_BattleUITask.<>f__mg$cache164);
		if (Lua_BlackJack_ProjectL_UI_BattleUITask.<>f__mg$cache165 == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleUITask.<>f__mg$cache165 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleUITask.CanUseRegret);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_BattleUITask.<>f__mg$cache165);
		if (Lua_BlackJack_ProjectL_UI_BattleUITask.<>f__mg$cache166 == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleUITask.<>f__mg$cache166 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleUITask.RegretGotoStep);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_BattleUITask.<>f__mg$cache166);
		if (Lua_BlackJack_ProjectL_UI_BattleUITask.<>f__mg$cache167 == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleUITask.<>f__mg$cache167 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleUITask.FindRegretStepIndex);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_BattleUITask.<>f__mg$cache167);
		if (Lua_BlackJack_ProjectL_UI_BattleUITask.<>f__mg$cache168 == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleUITask.<>f__mg$cache168 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleUITask.BattleUIController_OnRegretActive);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_BattleUITask.<>f__mg$cache168);
		if (Lua_BlackJack_ProjectL_UI_BattleUITask.<>f__mg$cache169 == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleUITask.<>f__mg$cache169 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleUITask.BattleUIController_OnRegretConfirm);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_BattleUITask.<>f__mg$cache169);
		if (Lua_BlackJack_ProjectL_UI_BattleUITask.<>f__mg$cache16A == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleUITask.<>f__mg$cache16A = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleUITask.BattleUIController_OnRegretCancel);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_BattleUITask.<>f__mg$cache16A);
		if (Lua_BlackJack_ProjectL_UI_BattleUITask.<>f__mg$cache16B == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleUITask.<>f__mg$cache16B = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleUITask.BattleUIController_OnRegretBackward);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_BattleUITask.<>f__mg$cache16B);
		if (Lua_BlackJack_ProjectL_UI_BattleUITask.<>f__mg$cache16C == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleUITask.<>f__mg$cache16C = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleUITask.BattleUIController_OnRegretForward);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_BattleUITask.<>f__mg$cache16C);
		if (Lua_BlackJack_ProjectL_UI_BattleUITask.<>f__mg$cache16D == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleUITask.<>f__mg$cache16D = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleUITask.UserGuide_GetEnforceHeros);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_BattleUITask.<>f__mg$cache16D);
		if (Lua_BlackJack_ProjectL_UI_BattleUITask.<>f__mg$cache16E == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleUITask.<>f__mg$cache16E = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleUITask.SetUserGuideBattleSettings);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_BattleUITask.<>f__mg$cache16E);
		if (Lua_BlackJack_ProjectL_UI_BattleUITask.<>f__mg$cache16F == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleUITask.<>f__mg$cache16F = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleUITask.__callBase_OnStart);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_BattleUITask.<>f__mg$cache16F);
		if (Lua_BlackJack_ProjectL_UI_BattleUITask.<>f__mg$cache170 == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleUITask.<>f__mg$cache170 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleUITask.__callBase_OnStop);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_BattleUITask.<>f__mg$cache170);
		if (Lua_BlackJack_ProjectL_UI_BattleUITask.<>f__mg$cache171 == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleUITask.<>f__mg$cache171 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleUITask.__callBase_OnPause);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_BattleUITask.<>f__mg$cache171);
		if (Lua_BlackJack_ProjectL_UI_BattleUITask.<>f__mg$cache172 == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleUITask.<>f__mg$cache172 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleUITask.__callBase_OnResume);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_BattleUITask.<>f__mg$cache172);
		if (Lua_BlackJack_ProjectL_UI_BattleUITask.<>f__mg$cache173 == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleUITask.<>f__mg$cache173 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleUITask.__callBase_OnNewIntent);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_BattleUITask.<>f__mg$cache173);
		if (Lua_BlackJack_ProjectL_UI_BattleUITask.<>f__mg$cache174 == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleUITask.<>f__mg$cache174 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleUITask.__callBase_EnableUIInput);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_BattleUITask.<>f__mg$cache174);
		if (Lua_BlackJack_ProjectL_UI_BattleUITask.<>f__mg$cache175 == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleUITask.<>f__mg$cache175 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleUITask.__callBase_IsNeedLoadDynamicRes);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_BattleUITask.<>f__mg$cache175);
		if (Lua_BlackJack_ProjectL_UI_BattleUITask.<>f__mg$cache176 == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleUITask.<>f__mg$cache176 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleUITask.__callBase_CollectAllDynamicResForLoad);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_BattleUITask.<>f__mg$cache176);
		if (Lua_BlackJack_ProjectL_UI_BattleUITask.<>f__mg$cache177 == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleUITask.<>f__mg$cache177 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleUITask.__callBase_RegisterPlayerContextEvents);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_BattleUITask.<>f__mg$cache177);
		if (Lua_BlackJack_ProjectL_UI_BattleUITask.<>f__mg$cache178 == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleUITask.<>f__mg$cache178 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleUITask.__callBase_UnregisterPlayerContextEvents);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_BattleUITask.<>f__mg$cache178);
		if (Lua_BlackJack_ProjectL_UI_BattleUITask.<>f__mg$cache179 == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleUITask.<>f__mg$cache179 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleUITask.__callBase_PostUpdateView);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_BattleUITask.<>f__mg$cache179);
		if (Lua_BlackJack_ProjectL_UI_BattleUITask.<>f__mg$cache17A == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleUITask.<>f__mg$cache17A = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleUITask.__callBase_CollectPreloadResourceList);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_BattleUITask.<>f__mg$cache17A);
		if (Lua_BlackJack_ProjectL_UI_BattleUITask.<>f__mg$cache17B == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleUITask.<>f__mg$cache17B = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleUITask.__callBase_ClearAssetList);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_BattleUITask.<>f__mg$cache17B);
		if (Lua_BlackJack_ProjectL_UI_BattleUITask.<>f__mg$cache17C == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleUITask.<>f__mg$cache17C = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleUITask.__callBase_CollectAsset);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_BattleUITask.<>f__mg$cache17C);
		if (Lua_BlackJack_ProjectL_UI_BattleUITask.<>f__mg$cache17D == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleUITask.<>f__mg$cache17D = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleUITask.__callBase_CollectSpriteAsset);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_BattleUITask.<>f__mg$cache17D);
		if (Lua_BlackJack_ProjectL_UI_BattleUITask.<>f__mg$cache17E == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleUITask.<>f__mg$cache17E = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleUITask.__callBase_CollectFxAsset);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_BattleUITask.<>f__mg$cache17E);
		if (Lua_BlackJack_ProjectL_UI_BattleUITask.<>f__mg$cache17F == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleUITask.<>f__mg$cache17F = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleUITask.__callBase_StartLoadCustomAssets);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_BattleUITask.<>f__mg$cache17F);
		if (Lua_BlackJack_ProjectL_UI_BattleUITask.<>f__mg$cache180 == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleUITask.<>f__mg$cache180 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleUITask.__callBase_IsLoadingCustomAssets);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_BattleUITask.<>f__mg$cache180);
		if (Lua_BlackJack_ProjectL_UI_BattleUITask.<>f__mg$cache181 == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleUITask.<>f__mg$cache181 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleUITask.__callBase_IsPipeLineRunning);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_BattleUITask.<>f__mg$cache181);
		if (Lua_BlackJack_ProjectL_UI_BattleUITask.<>f__mg$cache182 == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleUITask.<>f__mg$cache182 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleUITask.__callBase_IsOpeningUI);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_BattleUITask.<>f__mg$cache182);
		if (Lua_BlackJack_ProjectL_UI_BattleUITask.<>f__mg$cache183 == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleUITask.<>f__mg$cache183 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleUITask.__callBase_ReturnPrevUITask);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_BattleUITask.<>f__mg$cache183);
		if (Lua_BlackJack_ProjectL_UI_BattleUITask.<>f__mg$cache184 == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleUITask.<>f__mg$cache184 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleUITask.__callBase_ClearUnusedDynamicResourceCache);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_BattleUITask.<>f__mg$cache184);
		if (Lua_BlackJack_ProjectL_UI_BattleUITask.<>f__mg$cache185 == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleUITask.<>f__mg$cache185 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleUITask.__callBase_OnMemoryWarning);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_BattleUITask.<>f__mg$cache185);
		if (Lua_BlackJack_ProjectL_UI_BattleUITask.<>f__mg$cache186 == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleUITask.<>f__mg$cache186 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleUITask.StopSubUITask_s);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_BattleUITask.<>f__mg$cache186);
		if (Lua_BlackJack_ProjectL_UI_BattleUITask.<>f__mg$cache187 == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleUITask.<>f__mg$cache187 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleUITask.UnloadAssetsAndStartWorldUITask_s);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_BattleUITask.<>f__mg$cache187);
		if (Lua_BlackJack_ProjectL_UI_BattleUITask.<>f__mg$cache188 == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleUITask.<>f__mg$cache188 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleUITask.Co_UnloadAssetsAndStartWorldUITask_s);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_BattleUITask.<>f__mg$cache188);
		if (Lua_BlackJack_ProjectL_UI_BattleUITask.<>f__mg$cache189 == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleUITask.<>f__mg$cache189 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleUITask.WorldUITask_OnLoadAllResCompleted_s);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_BattleUITask.<>f__mg$cache189);
		if (Lua_BlackJack_ProjectL_UI_BattleUITask.<>f__mg$cache18A == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleUITask.<>f__mg$cache18A = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleUITask.GetUnchartedScoreInfo_s);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_BattleUITask.<>f__mg$cache18A);
		if (Lua_BlackJack_ProjectL_UI_BattleUITask.<>f__mg$cache18B == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleUITask.<>f__mg$cache18B = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleUITask.GetHeroUnchartedScoreBonus_s);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_BattleUITask.<>f__mg$cache18B);
		if (Lua_BlackJack_ProjectL_UI_BattleUITask.<>f__mg$cache18C == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleUITask.<>f__mg$cache18C = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleUITask.CompareHero_s);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_BattleUITask.<>f__mg$cache18C);
		if (Lua_BlackJack_ProjectL_UI_BattleUITask.<>f__mg$cache18D == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleUITask.<>f__mg$cache18D = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleUITask.CompareHeroUnchartdScoreBonus_s);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_BattleUITask.<>f__mg$cache18D);
		if (Lua_BlackJack_ProjectL_UI_BattleUITask.<>f__mg$cache18E == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleUITask.<>f__mg$cache18E = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleUITask.IsListElementsEqual_s);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_BattleUITask.<>f__mg$cache18E);
		if (Lua_BlackJack_ProjectL_UI_BattleUITask.<>f__mg$cache18F == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleUITask.<>f__mg$cache18F = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleUITask.CompareHeroActionValue_s);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_BattleUITask.<>f__mg$cache18F);
		if (Lua_BlackJack_ProjectL_UI_BattleUITask.<>f__mg$cache190 == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleUITask.<>f__mg$cache190 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleUITask.__callDele_m_onActiveActorEvent_s);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_BattleUITask.<>f__mg$cache190);
		if (Lua_BlackJack_ProjectL_UI_BattleUITask.<>f__mg$cache191 == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleUITask.<>f__mg$cache191 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleUITask.__clearDele_m_onActiveActorEvent_s);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_BattleUITask.<>f__mg$cache191);
		if (Lua_BlackJack_ProjectL_UI_BattleUITask.<>f__mg$cache192 == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleUITask.<>f__mg$cache192 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleUITask.__callDele_m_onDeactiveActorEvent_s);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_BattleUITask.<>f__mg$cache192);
		if (Lua_BlackJack_ProjectL_UI_BattleUITask.<>f__mg$cache193 == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleUITask.<>f__mg$cache193 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleUITask.__clearDele_m_onDeactiveActorEvent_s);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_BattleUITask.<>f__mg$cache193);
		string name = "BattleDanmakuLayerIndex";
		if (Lua_BlackJack_ProjectL_UI_BattleUITask.<>f__mg$cache194 == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleUITask.<>f__mg$cache194 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleUITask.get_BattleDanmakuLayerIndex);
		}
		LuaObject.addMember(l, name, Lua_BlackJack_ProjectL_UI_BattleUITask.<>f__mg$cache194, null, false);
		string name2 = "BattleRoomLayerIndex";
		if (Lua_BlackJack_ProjectL_UI_BattleUITask.<>f__mg$cache195 == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleUITask.<>f__mg$cache195 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleUITask.get_BattleRoomLayerIndex);
		}
		LuaObject.addMember(l, name2, Lua_BlackJack_ProjectL_UI_BattleUITask.<>f__mg$cache195, null, false);
		string name3 = "BattleLayerIndex";
		if (Lua_BlackJack_ProjectL_UI_BattleUITask.<>f__mg$cache196 == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleUITask.<>f__mg$cache196 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleUITask.get_BattleLayerIndex);
		}
		LuaObject.addMember(l, name3, Lua_BlackJack_ProjectL_UI_BattleUITask.<>f__mg$cache196, null, false);
		string name4 = "BattleActorInfoLayerIndex";
		if (Lua_BlackJack_ProjectL_UI_BattleUITask.<>f__mg$cache197 == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleUITask.<>f__mg$cache197 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleUITask.get_BattleActorInfoLayerIndex);
		}
		LuaObject.addMember(l, name4, Lua_BlackJack_ProjectL_UI_BattleUITask.<>f__mg$cache197, null, false);
		string name5 = "BattlePrepareLayerIndex";
		if (Lua_BlackJack_ProjectL_UI_BattleUITask.<>f__mg$cache198 == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleUITask.<>f__mg$cache198 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleUITask.get_BattlePrepareLayerIndex);
		}
		LuaObject.addMember(l, name5, Lua_BlackJack_ProjectL_UI_BattleUITask.<>f__mg$cache198, null, false);
		string name6 = "PVPBattlePrepareLayerIndex";
		if (Lua_BlackJack_ProjectL_UI_BattleUITask.<>f__mg$cache199 == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleUITask.<>f__mg$cache199 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleUITask.get_PVPBattlePrepareLayerIndex);
		}
		LuaObject.addMember(l, name6, Lua_BlackJack_ProjectL_UI_BattleUITask.<>f__mg$cache199, null, false);
		string name7 = "BattlePrepareActorInfoLayerIndex";
		if (Lua_BlackJack_ProjectL_UI_BattleUITask.<>f__mg$cache19A == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleUITask.<>f__mg$cache19A = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleUITask.get_BattlePrepareActorInfoLayerIndex);
		}
		LuaObject.addMember(l, name7, Lua_BlackJack_ProjectL_UI_BattleUITask.<>f__mg$cache19A, null, false);
		string name8 = "ActionOrderLayerIndex";
		if (Lua_BlackJack_ProjectL_UI_BattleUITask.<>f__mg$cache19B == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleUITask.<>f__mg$cache19B = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleUITask.get_ActionOrderLayerIndex);
		}
		LuaObject.addMember(l, name8, Lua_BlackJack_ProjectL_UI_BattleUITask.<>f__mg$cache19B, null, false);
		string name9 = "BattlePauseLayerIndex";
		if (Lua_BlackJack_ProjectL_UI_BattleUITask.<>f__mg$cache19C == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleUITask.<>f__mg$cache19C = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleUITask.get_BattlePauseLayerIndex);
		}
		LuaObject.addMember(l, name9, Lua_BlackJack_ProjectL_UI_BattleUITask.<>f__mg$cache19C, null, false);
		string name10 = "BattleTreasureDialogLayerIndex";
		if (Lua_BlackJack_ProjectL_UI_BattleUITask.<>f__mg$cache19D == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleUITask.<>f__mg$cache19D = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleUITask.get_BattleTreasureDialogLayerIndex);
		}
		LuaObject.addMember(l, name10, Lua_BlackJack_ProjectL_UI_BattleUITask.<>f__mg$cache19D, null, false);
		string name11 = "CombatLayerIndex";
		if (Lua_BlackJack_ProjectL_UI_BattleUITask.<>f__mg$cache19E == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleUITask.<>f__mg$cache19E = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleUITask.get_CombatLayerIndex);
		}
		LuaObject.addMember(l, name11, Lua_BlackJack_ProjectL_UI_BattleUITask.<>f__mg$cache19E, null, false);
		string name12 = "PreCombatLayerIndex";
		if (Lua_BlackJack_ProjectL_UI_BattleUITask.<>f__mg$cache19F == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleUITask.<>f__mg$cache19F = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleUITask.get_PreCombatLayerIndex);
		}
		LuaObject.addMember(l, name12, Lua_BlackJack_ProjectL_UI_BattleUITask.<>f__mg$cache19F, null, false);
		string name13 = "BattleCommonLayerIndex";
		if (Lua_BlackJack_ProjectL_UI_BattleUITask.<>f__mg$cache1A0 == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleUITask.<>f__mg$cache1A0 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleUITask.get_BattleCommonLayerIndex);
		}
		LuaObject.addMember(l, name13, Lua_BlackJack_ProjectL_UI_BattleUITask.<>f__mg$cache1A0, null, false);
		string name14 = "m_layerDescArray";
		if (Lua_BlackJack_ProjectL_UI_BattleUITask.<>f__mg$cache1A1 == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleUITask.<>f__mg$cache1A1 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleUITask.get_m_layerDescArray);
		}
		LuaCSFunction get = Lua_BlackJack_ProjectL_UI_BattleUITask.<>f__mg$cache1A1;
		if (Lua_BlackJack_ProjectL_UI_BattleUITask.<>f__mg$cache1A2 == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleUITask.<>f__mg$cache1A2 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleUITask.set_m_layerDescArray);
		}
		LuaObject.addMember(l, name14, get, Lua_BlackJack_ProjectL_UI_BattleUITask.<>f__mg$cache1A2, true);
		string name15 = "m_uiCtrlDescArray";
		if (Lua_BlackJack_ProjectL_UI_BattleUITask.<>f__mg$cache1A3 == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleUITask.<>f__mg$cache1A3 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleUITask.get_m_uiCtrlDescArray);
		}
		LuaCSFunction get2 = Lua_BlackJack_ProjectL_UI_BattleUITask.<>f__mg$cache1A3;
		if (Lua_BlackJack_ProjectL_UI_BattleUITask.<>f__mg$cache1A4 == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleUITask.<>f__mg$cache1A4 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleUITask.set_m_uiCtrlDescArray);
		}
		LuaObject.addMember(l, name15, get2, Lua_BlackJack_ProjectL_UI_BattleUITask.<>f__mg$cache1A4, true);
		string name16 = "m_battleUIController";
		if (Lua_BlackJack_ProjectL_UI_BattleUITask.<>f__mg$cache1A5 == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleUITask.<>f__mg$cache1A5 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleUITask.get_m_battleUIController);
		}
		LuaCSFunction get3 = Lua_BlackJack_ProjectL_UI_BattleUITask.<>f__mg$cache1A5;
		if (Lua_BlackJack_ProjectL_UI_BattleUITask.<>f__mg$cache1A6 == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleUITask.<>f__mg$cache1A6 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleUITask.set_m_battleUIController);
		}
		LuaObject.addMember(l, name16, get3, Lua_BlackJack_ProjectL_UI_BattleUITask.<>f__mg$cache1A6, true);
		string name17 = "m_battleDanmakuUIController";
		if (Lua_BlackJack_ProjectL_UI_BattleUITask.<>f__mg$cache1A7 == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleUITask.<>f__mg$cache1A7 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleUITask.get_m_battleDanmakuUIController);
		}
		LuaCSFunction get4 = Lua_BlackJack_ProjectL_UI_BattleUITask.<>f__mg$cache1A7;
		if (Lua_BlackJack_ProjectL_UI_BattleUITask.<>f__mg$cache1A8 == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleUITask.<>f__mg$cache1A8 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleUITask.set_m_battleDanmakuUIController);
		}
		LuaObject.addMember(l, name17, get4, Lua_BlackJack_ProjectL_UI_BattleUITask.<>f__mg$cache1A8, true);
		string name18 = "m_battleActorInfoUIController";
		if (Lua_BlackJack_ProjectL_UI_BattleUITask.<>f__mg$cache1A9 == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleUITask.<>f__mg$cache1A9 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleUITask.get_m_battleActorInfoUIController);
		}
		LuaCSFunction get5 = Lua_BlackJack_ProjectL_UI_BattleUITask.<>f__mg$cache1A9;
		if (Lua_BlackJack_ProjectL_UI_BattleUITask.<>f__mg$cache1AA == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleUITask.<>f__mg$cache1AA = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleUITask.set_m_battleActorInfoUIController);
		}
		LuaObject.addMember(l, name18, get5, Lua_BlackJack_ProjectL_UI_BattleUITask.<>f__mg$cache1AA, true);
		string name19 = "m_battlePrepareUIController";
		if (Lua_BlackJack_ProjectL_UI_BattleUITask.<>f__mg$cache1AB == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleUITask.<>f__mg$cache1AB = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleUITask.get_m_battlePrepareUIController);
		}
		LuaCSFunction get6 = Lua_BlackJack_ProjectL_UI_BattleUITask.<>f__mg$cache1AB;
		if (Lua_BlackJack_ProjectL_UI_BattleUITask.<>f__mg$cache1AC == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleUITask.<>f__mg$cache1AC = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleUITask.set_m_battlePrepareUIController);
		}
		LuaObject.addMember(l, name19, get6, Lua_BlackJack_ProjectL_UI_BattleUITask.<>f__mg$cache1AC, true);
		string name20 = "m_pvpBattlePrepareUIController";
		if (Lua_BlackJack_ProjectL_UI_BattleUITask.<>f__mg$cache1AD == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleUITask.<>f__mg$cache1AD = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleUITask.get_m_pvpBattlePrepareUIController);
		}
		LuaCSFunction get7 = Lua_BlackJack_ProjectL_UI_BattleUITask.<>f__mg$cache1AD;
		if (Lua_BlackJack_ProjectL_UI_BattleUITask.<>f__mg$cache1AE == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleUITask.<>f__mg$cache1AE = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleUITask.set_m_pvpBattlePrepareUIController);
		}
		LuaObject.addMember(l, name20, get7, Lua_BlackJack_ProjectL_UI_BattleUITask.<>f__mg$cache1AE, true);
		string name21 = "m_battlePrepareActorInfoUIController";
		if (Lua_BlackJack_ProjectL_UI_BattleUITask.<>f__mg$cache1AF == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleUITask.<>f__mg$cache1AF = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleUITask.get_m_battlePrepareActorInfoUIController);
		}
		LuaCSFunction get8 = Lua_BlackJack_ProjectL_UI_BattleUITask.<>f__mg$cache1AF;
		if (Lua_BlackJack_ProjectL_UI_BattleUITask.<>f__mg$cache1B0 == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleUITask.<>f__mg$cache1B0 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleUITask.set_m_battlePrepareActorInfoUIController);
		}
		LuaObject.addMember(l, name21, get8, Lua_BlackJack_ProjectL_UI_BattleUITask.<>f__mg$cache1B0, true);
		string name22 = "m_actionOrderUIController";
		if (Lua_BlackJack_ProjectL_UI_BattleUITask.<>f__mg$cache1B1 == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleUITask.<>f__mg$cache1B1 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleUITask.get_m_actionOrderUIController);
		}
		LuaCSFunction get9 = Lua_BlackJack_ProjectL_UI_BattleUITask.<>f__mg$cache1B1;
		if (Lua_BlackJack_ProjectL_UI_BattleUITask.<>f__mg$cache1B2 == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleUITask.<>f__mg$cache1B2 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleUITask.set_m_actionOrderUIController);
		}
		LuaObject.addMember(l, name22, get9, Lua_BlackJack_ProjectL_UI_BattleUITask.<>f__mg$cache1B2, true);
		string name23 = "m_battlePauseUIController";
		if (Lua_BlackJack_ProjectL_UI_BattleUITask.<>f__mg$cache1B3 == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleUITask.<>f__mg$cache1B3 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleUITask.get_m_battlePauseUIController);
		}
		LuaCSFunction get10 = Lua_BlackJack_ProjectL_UI_BattleUITask.<>f__mg$cache1B3;
		if (Lua_BlackJack_ProjectL_UI_BattleUITask.<>f__mg$cache1B4 == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleUITask.<>f__mg$cache1B4 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleUITask.set_m_battlePauseUIController);
		}
		LuaObject.addMember(l, name23, get10, Lua_BlackJack_ProjectL_UI_BattleUITask.<>f__mg$cache1B4, true);
		string name24 = "m_battleTreasureDialogUIController";
		if (Lua_BlackJack_ProjectL_UI_BattleUITask.<>f__mg$cache1B5 == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleUITask.<>f__mg$cache1B5 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleUITask.get_m_battleTreasureDialogUIController);
		}
		LuaCSFunction get11 = Lua_BlackJack_ProjectL_UI_BattleUITask.<>f__mg$cache1B5;
		if (Lua_BlackJack_ProjectL_UI_BattleUITask.<>f__mg$cache1B6 == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleUITask.<>f__mg$cache1B6 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleUITask.set_m_battleTreasureDialogUIController);
		}
		LuaObject.addMember(l, name24, get11, Lua_BlackJack_ProjectL_UI_BattleUITask.<>f__mg$cache1B6, true);
		string name25 = "m_combatUIController";
		if (Lua_BlackJack_ProjectL_UI_BattleUITask.<>f__mg$cache1B7 == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleUITask.<>f__mg$cache1B7 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleUITask.get_m_combatUIController);
		}
		LuaCSFunction get12 = Lua_BlackJack_ProjectL_UI_BattleUITask.<>f__mg$cache1B7;
		if (Lua_BlackJack_ProjectL_UI_BattleUITask.<>f__mg$cache1B8 == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleUITask.<>f__mg$cache1B8 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleUITask.set_m_combatUIController);
		}
		LuaObject.addMember(l, name25, get12, Lua_BlackJack_ProjectL_UI_BattleUITask.<>f__mg$cache1B8, true);
		string name26 = "m_preCombatUIController";
		if (Lua_BlackJack_ProjectL_UI_BattleUITask.<>f__mg$cache1B9 == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleUITask.<>f__mg$cache1B9 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleUITask.get_m_preCombatUIController);
		}
		LuaCSFunction get13 = Lua_BlackJack_ProjectL_UI_BattleUITask.<>f__mg$cache1B9;
		if (Lua_BlackJack_ProjectL_UI_BattleUITask.<>f__mg$cache1BA == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleUITask.<>f__mg$cache1BA = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleUITask.set_m_preCombatUIController);
		}
		LuaObject.addMember(l, name26, get13, Lua_BlackJack_ProjectL_UI_BattleUITask.<>f__mg$cache1BA, true);
		string name27 = "m_battleRoomUIController";
		if (Lua_BlackJack_ProjectL_UI_BattleUITask.<>f__mg$cache1BB == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleUITask.<>f__mg$cache1BB = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleUITask.get_m_battleRoomUIController);
		}
		LuaCSFunction get14 = Lua_BlackJack_ProjectL_UI_BattleUITask.<>f__mg$cache1BB;
		if (Lua_BlackJack_ProjectL_UI_BattleUITask.<>f__mg$cache1BC == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleUITask.<>f__mg$cache1BC = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleUITask.set_m_battleRoomUIController);
		}
		LuaObject.addMember(l, name27, get14, Lua_BlackJack_ProjectL_UI_BattleUITask.<>f__mg$cache1BC, true);
		string name28 = "m_battleCommonUIController";
		if (Lua_BlackJack_ProjectL_UI_BattleUITask.<>f__mg$cache1BD == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleUITask.<>f__mg$cache1BD = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleUITask.get_m_battleCommonUIController);
		}
		LuaCSFunction get15 = Lua_BlackJack_ProjectL_UI_BattleUITask.<>f__mg$cache1BD;
		if (Lua_BlackJack_ProjectL_UI_BattleUITask.<>f__mg$cache1BE == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleUITask.<>f__mg$cache1BE = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleUITask.set_m_battleCommonUIController);
		}
		LuaObject.addMember(l, name28, get15, Lua_BlackJack_ProjectL_UI_BattleUITask.<>f__mg$cache1BE, true);
		string name29 = "m_battleMapUIController";
		if (Lua_BlackJack_ProjectL_UI_BattleUITask.<>f__mg$cache1BF == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleUITask.<>f__mg$cache1BF = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleUITask.get_m_battleMapUIController);
		}
		LuaCSFunction get16 = Lua_BlackJack_ProjectL_UI_BattleUITask.<>f__mg$cache1BF;
		if (Lua_BlackJack_ProjectL_UI_BattleUITask.<>f__mg$cache1C0 == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleUITask.<>f__mg$cache1C0 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleUITask.set_m_battleMapUIController);
		}
		LuaObject.addMember(l, name29, get16, Lua_BlackJack_ProjectL_UI_BattleUITask.<>f__mg$cache1C0, true);
		string name30 = "m_battleSceneUIController";
		if (Lua_BlackJack_ProjectL_UI_BattleUITask.<>f__mg$cache1C1 == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleUITask.<>f__mg$cache1C1 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleUITask.get_m_battleSceneUIController);
		}
		LuaCSFunction get17 = Lua_BlackJack_ProjectL_UI_BattleUITask.<>f__mg$cache1C1;
		if (Lua_BlackJack_ProjectL_UI_BattleUITask.<>f__mg$cache1C2 == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleUITask.<>f__mg$cache1C2 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleUITask.set_m_battleSceneUIController);
		}
		LuaObject.addMember(l, name30, get17, Lua_BlackJack_ProjectL_UI_BattleUITask.<>f__mg$cache1C2, true);
		string name31 = "m_combatSceneUIController";
		if (Lua_BlackJack_ProjectL_UI_BattleUITask.<>f__mg$cache1C3 == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleUITask.<>f__mg$cache1C3 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleUITask.get_m_combatSceneUIController);
		}
		LuaCSFunction get18 = Lua_BlackJack_ProjectL_UI_BattleUITask.<>f__mg$cache1C3;
		if (Lua_BlackJack_ProjectL_UI_BattleUITask.<>f__mg$cache1C4 == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleUITask.<>f__mg$cache1C4 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleUITask.set_m_combatSceneUIController);
		}
		LuaObject.addMember(l, name31, get18, Lua_BlackJack_ProjectL_UI_BattleUITask.<>f__mg$cache1C4, true);
		string name32 = "m_getRewardGoodsUITask";
		if (Lua_BlackJack_ProjectL_UI_BattleUITask.<>f__mg$cache1C5 == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleUITask.<>f__mg$cache1C5 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleUITask.get_m_getRewardGoodsUITask);
		}
		LuaCSFunction get19 = Lua_BlackJack_ProjectL_UI_BattleUITask.<>f__mg$cache1C5;
		if (Lua_BlackJack_ProjectL_UI_BattleUITask.<>f__mg$cache1C6 == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleUITask.<>f__mg$cache1C6 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleUITask.set_m_getRewardGoodsUITask);
		}
		LuaObject.addMember(l, name32, get19, Lua_BlackJack_ProjectL_UI_BattleUITask.<>f__mg$cache1C6, true);
		string name33 = "m_battleDialogUITask";
		if (Lua_BlackJack_ProjectL_UI_BattleUITask.<>f__mg$cache1C7 == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleUITask.<>f__mg$cache1C7 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleUITask.get_m_battleDialogUITask);
		}
		LuaCSFunction get20 = Lua_BlackJack_ProjectL_UI_BattleUITask.<>f__mg$cache1C7;
		if (Lua_BlackJack_ProjectL_UI_BattleUITask.<>f__mg$cache1C8 == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleUITask.<>f__mg$cache1C8 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleUITask.set_m_battleDialogUITask);
		}
		LuaObject.addMember(l, name33, get20, Lua_BlackJack_ProjectL_UI_BattleUITask.<>f__mg$cache1C8, true);
		string name34 = "m_battleResultUITask";
		if (Lua_BlackJack_ProjectL_UI_BattleUITask.<>f__mg$cache1C9 == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleUITask.<>f__mg$cache1C9 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleUITask.get_m_battleResultUITask);
		}
		LuaCSFunction get21 = Lua_BlackJack_ProjectL_UI_BattleUITask.<>f__mg$cache1C9;
		if (Lua_BlackJack_ProjectL_UI_BattleUITask.<>f__mg$cache1CA == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleUITask.<>f__mg$cache1CA = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleUITask.set_m_battleResultUITask);
		}
		LuaObject.addMember(l, name34, get21, Lua_BlackJack_ProjectL_UI_BattleUITask.<>f__mg$cache1CA, true);
		string name35 = "m_battleResultScoreUITask";
		if (Lua_BlackJack_ProjectL_UI_BattleUITask.<>f__mg$cache1CB == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleUITask.<>f__mg$cache1CB = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleUITask.get_m_battleResultScoreUITask);
		}
		LuaCSFunction get22 = Lua_BlackJack_ProjectL_UI_BattleUITask.<>f__mg$cache1CB;
		if (Lua_BlackJack_ProjectL_UI_BattleUITask.<>f__mg$cache1CC == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleUITask.<>f__mg$cache1CC = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleUITask.set_m_battleResultScoreUITask);
		}
		LuaObject.addMember(l, name35, get22, Lua_BlackJack_ProjectL_UI_BattleUITask.<>f__mg$cache1CC, true);
		string name36 = "m_battleLoseUITask";
		if (Lua_BlackJack_ProjectL_UI_BattleUITask.<>f__mg$cache1CD == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleUITask.<>f__mg$cache1CD = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleUITask.get_m_battleLoseUITask);
		}
		LuaCSFunction get23 = Lua_BlackJack_ProjectL_UI_BattleUITask.<>f__mg$cache1CD;
		if (Lua_BlackJack_ProjectL_UI_BattleUITask.<>f__mg$cache1CE == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleUITask.<>f__mg$cache1CE = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleUITask.set_m_battleLoseUITask);
		}
		LuaObject.addMember(l, name36, get23, Lua_BlackJack_ProjectL_UI_BattleUITask.<>f__mg$cache1CE, true);
		string name37 = "m_battleReportEndUITask";
		if (Lua_BlackJack_ProjectL_UI_BattleUITask.<>f__mg$cache1CF == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleUITask.<>f__mg$cache1CF = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleUITask.get_m_battleReportEndUITask);
		}
		LuaCSFunction get24 = Lua_BlackJack_ProjectL_UI_BattleUITask.<>f__mg$cache1CF;
		if (Lua_BlackJack_ProjectL_UI_BattleUITask.<>f__mg$cache1D0 == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleUITask.<>f__mg$cache1D0 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleUITask.set_m_battleReportEndUITask);
		}
		LuaObject.addMember(l, name37, get24, Lua_BlackJack_ProjectL_UI_BattleUITask.<>f__mg$cache1D0, true);
		string name38 = "m_clientBattle";
		if (Lua_BlackJack_ProjectL_UI_BattleUITask.<>f__mg$cache1D1 == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleUITask.<>f__mg$cache1D1 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleUITask.get_m_clientBattle);
		}
		LuaCSFunction get25 = Lua_BlackJack_ProjectL_UI_BattleUITask.<>f__mg$cache1D1;
		if (Lua_BlackJack_ProjectL_UI_BattleUITask.<>f__mg$cache1D2 == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleUITask.<>f__mg$cache1D2 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleUITask.set_m_clientBattle);
		}
		LuaObject.addMember(l, name38, get25, Lua_BlackJack_ProjectL_UI_BattleUITask.<>f__mg$cache1D2, true);
		string name39 = "m_configDataLoader";
		if (Lua_BlackJack_ProjectL_UI_BattleUITask.<>f__mg$cache1D3 == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleUITask.<>f__mg$cache1D3 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleUITask.get_m_configDataLoader);
		}
		LuaCSFunction get26 = Lua_BlackJack_ProjectL_UI_BattleUITask.<>f__mg$cache1D3;
		if (Lua_BlackJack_ProjectL_UI_BattleUITask.<>f__mg$cache1D4 == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleUITask.<>f__mg$cache1D4 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleUITask.set_m_configDataLoader);
		}
		LuaObject.addMember(l, name39, get26, Lua_BlackJack_ProjectL_UI_BattleUITask.<>f__mg$cache1D4, true);
		string name40 = "m_uiState";
		if (Lua_BlackJack_ProjectL_UI_BattleUITask.<>f__mg$cache1D5 == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleUITask.<>f__mg$cache1D5 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleUITask.get_m_uiState);
		}
		LuaCSFunction get27 = Lua_BlackJack_ProjectL_UI_BattleUITask.<>f__mg$cache1D5;
		if (Lua_BlackJack_ProjectL_UI_BattleUITask.<>f__mg$cache1D6 == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleUITask.<>f__mg$cache1D6 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleUITask.set_m_uiState);
		}
		LuaObject.addMember(l, name40, get27, Lua_BlackJack_ProjectL_UI_BattleUITask.<>f__mg$cache1D6, true);
		string name41 = "m_activeActor";
		if (Lua_BlackJack_ProjectL_UI_BattleUITask.<>f__mg$cache1D7 == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleUITask.<>f__mg$cache1D7 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleUITask.get_m_activeActor);
		}
		LuaCSFunction get28 = Lua_BlackJack_ProjectL_UI_BattleUITask.<>f__mg$cache1D7;
		if (Lua_BlackJack_ProjectL_UI_BattleUITask.<>f__mg$cache1D8 == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleUITask.<>f__mg$cache1D8 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleUITask.set_m_activeActor);
		}
		LuaObject.addMember(l, name41, get28, Lua_BlackJack_ProjectL_UI_BattleUITask.<>f__mg$cache1D8, true);
		string name42 = "m_activeActorInitPosition";
		if (Lua_BlackJack_ProjectL_UI_BattleUITask.<>f__mg$cache1D9 == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleUITask.<>f__mg$cache1D9 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleUITask.get_m_activeActorInitPosition);
		}
		LuaCSFunction get29 = Lua_BlackJack_ProjectL_UI_BattleUITask.<>f__mg$cache1D9;
		if (Lua_BlackJack_ProjectL_UI_BattleUITask.<>f__mg$cache1DA == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleUITask.<>f__mg$cache1DA = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleUITask.set_m_activeActorInitPosition);
		}
		LuaObject.addMember(l, name42, get29, Lua_BlackJack_ProjectL_UI_BattleUITask.<>f__mg$cache1DA, true);
		string name43 = "m_activeActorInitDirection";
		if (Lua_BlackJack_ProjectL_UI_BattleUITask.<>f__mg$cache1DB == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleUITask.<>f__mg$cache1DB = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleUITask.get_m_activeActorInitDirection);
		}
		LuaCSFunction get30 = Lua_BlackJack_ProjectL_UI_BattleUITask.<>f__mg$cache1DB;
		if (Lua_BlackJack_ProjectL_UI_BattleUITask.<>f__mg$cache1DC == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleUITask.<>f__mg$cache1DC = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleUITask.set_m_activeActorInitDirection);
		}
		LuaObject.addMember(l, name43, get30, Lua_BlackJack_ProjectL_UI_BattleUITask.<>f__mg$cache1DC, true);
		string name44 = "m_skillIndex";
		if (Lua_BlackJack_ProjectL_UI_BattleUITask.<>f__mg$cache1DD == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleUITask.<>f__mg$cache1DD = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleUITask.get_m_skillIndex);
		}
		LuaCSFunction get31 = Lua_BlackJack_ProjectL_UI_BattleUITask.<>f__mg$cache1DD;
		if (Lua_BlackJack_ProjectL_UI_BattleUITask.<>f__mg$cache1DE == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleUITask.<>f__mg$cache1DE = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleUITask.set_m_skillIndex);
		}
		LuaObject.addMember(l, name44, get31, Lua_BlackJack_ProjectL_UI_BattleUITask.<>f__mg$cache1DE, true);
		string name45 = "m_skillTargetPosition";
		if (Lua_BlackJack_ProjectL_UI_BattleUITask.<>f__mg$cache1DF == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleUITask.<>f__mg$cache1DF = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleUITask.get_m_skillTargetPosition);
		}
		LuaCSFunction get32 = Lua_BlackJack_ProjectL_UI_BattleUITask.<>f__mg$cache1DF;
		if (Lua_BlackJack_ProjectL_UI_BattleUITask.<>f__mg$cache1E0 == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleUITask.<>f__mg$cache1E0 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleUITask.set_m_skillTargetPosition);
		}
		LuaObject.addMember(l, name45, get32, Lua_BlackJack_ProjectL_UI_BattleUITask.<>f__mg$cache1E0, true);
		string name46 = "m_skillTargetPosition2";
		if (Lua_BlackJack_ProjectL_UI_BattleUITask.<>f__mg$cache1E1 == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleUITask.<>f__mg$cache1E1 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleUITask.get_m_skillTargetPosition2);
		}
		LuaCSFunction get33 = Lua_BlackJack_ProjectL_UI_BattleUITask.<>f__mg$cache1E1;
		if (Lua_BlackJack_ProjectL_UI_BattleUITask.<>f__mg$cache1E2 == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleUITask.<>f__mg$cache1E2 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleUITask.set_m_skillTargetPosition2);
		}
		LuaObject.addMember(l, name46, get33, Lua_BlackJack_ProjectL_UI_BattleUITask.<>f__mg$cache1E2, true);
		string name47 = "m_combatStartPosition";
		if (Lua_BlackJack_ProjectL_UI_BattleUITask.<>f__mg$cache1E3 == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleUITask.<>f__mg$cache1E3 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleUITask.get_m_combatStartPosition);
		}
		LuaCSFunction get34 = Lua_BlackJack_ProjectL_UI_BattleUITask.<>f__mg$cache1E3;
		if (Lua_BlackJack_ProjectL_UI_BattleUITask.<>f__mg$cache1E4 == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleUITask.<>f__mg$cache1E4 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleUITask.set_m_combatStartPosition);
		}
		LuaObject.addMember(l, name47, get34, Lua_BlackJack_ProjectL_UI_BattleUITask.<>f__mg$cache1E4, true);
		string name48 = "m_combatTargetPosition";
		if (Lua_BlackJack_ProjectL_UI_BattleUITask.<>f__mg$cache1E5 == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleUITask.<>f__mg$cache1E5 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleUITask.get_m_combatTargetPosition);
		}
		LuaCSFunction get35 = Lua_BlackJack_ProjectL_UI_BattleUITask.<>f__mg$cache1E5;
		if (Lua_BlackJack_ProjectL_UI_BattleUITask.<>f__mg$cache1E6 == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleUITask.<>f__mg$cache1E6 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleUITask.set_m_combatTargetPosition);
		}
		LuaObject.addMember(l, name48, get35, Lua_BlackJack_ProjectL_UI_BattleUITask.<>f__mg$cache1E6, true);
		string name49 = "m_isBattleCutsceneFade";
		if (Lua_BlackJack_ProjectL_UI_BattleUITask.<>f__mg$cache1E7 == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleUITask.<>f__mg$cache1E7 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleUITask.get_m_isBattleCutsceneFade);
		}
		LuaCSFunction get36 = Lua_BlackJack_ProjectL_UI_BattleUITask.<>f__mg$cache1E7;
		if (Lua_BlackJack_ProjectL_UI_BattleUITask.<>f__mg$cache1E8 == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleUITask.<>f__mg$cache1E8 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleUITask.set_m_isBattleCutsceneFade);
		}
		LuaObject.addMember(l, name49, get36, Lua_BlackJack_ProjectL_UI_BattleUITask.<>f__mg$cache1E8, true);
		string name50 = "m_isCombatCutsceneFade";
		if (Lua_BlackJack_ProjectL_UI_BattleUITask.<>f__mg$cache1E9 == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleUITask.<>f__mg$cache1E9 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleUITask.get_m_isCombatCutsceneFade);
		}
		LuaCSFunction get37 = Lua_BlackJack_ProjectL_UI_BattleUITask.<>f__mg$cache1E9;
		if (Lua_BlackJack_ProjectL_UI_BattleUITask.<>f__mg$cache1EA == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleUITask.<>f__mg$cache1EA = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleUITask.set_m_isCombatCutsceneFade);
		}
		LuaObject.addMember(l, name50, get37, Lua_BlackJack_ProjectL_UI_BattleUITask.<>f__mg$cache1EA, true);
		string name51 = "m_battleMapClickTime";
		if (Lua_BlackJack_ProjectL_UI_BattleUITask.<>f__mg$cache1EB == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleUITask.<>f__mg$cache1EB = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleUITask.get_m_battleMapClickTime);
		}
		LuaCSFunction get38 = Lua_BlackJack_ProjectL_UI_BattleUITask.<>f__mg$cache1EB;
		if (Lua_BlackJack_ProjectL_UI_BattleUITask.<>f__mg$cache1EC == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleUITask.<>f__mg$cache1EC = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleUITask.set_m_battleMapClickTime);
		}
		LuaObject.addMember(l, name51, get38, Lua_BlackJack_ProjectL_UI_BattleUITask.<>f__mg$cache1EC, true);
		string name52 = "m_showDangerRegionTeam";
		if (Lua_BlackJack_ProjectL_UI_BattleUITask.<>f__mg$cache1ED == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleUITask.<>f__mg$cache1ED = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleUITask.get_m_showDangerRegionTeam);
		}
		LuaCSFunction get39 = Lua_BlackJack_ProjectL_UI_BattleUITask.<>f__mg$cache1ED;
		if (Lua_BlackJack_ProjectL_UI_BattleUITask.<>f__mg$cache1EE == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleUITask.<>f__mg$cache1EE = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleUITask.set_m_showDangerRegionTeam);
		}
		LuaObject.addMember(l, name52, get39, Lua_BlackJack_ProjectL_UI_BattleUITask.<>f__mg$cache1EE, true);
		string name53 = "m_showDangerRegionActorIds";
		if (Lua_BlackJack_ProjectL_UI_BattleUITask.<>f__mg$cache1EF == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleUITask.<>f__mg$cache1EF = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleUITask.get_m_showDangerRegionActorIds);
		}
		LuaCSFunction get40 = Lua_BlackJack_ProjectL_UI_BattleUITask.<>f__mg$cache1EF;
		if (Lua_BlackJack_ProjectL_UI_BattleUITask.<>f__mg$cache1F0 == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleUITask.<>f__mg$cache1F0 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleUITask.set_m_showDangerRegionActorIds);
		}
		LuaObject.addMember(l, name53, get40, Lua_BlackJack_ProjectL_UI_BattleUITask.<>f__mg$cache1F0, true);
		string name54 = "m_preCombatTargetActor";
		if (Lua_BlackJack_ProjectL_UI_BattleUITask.<>f__mg$cache1F1 == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleUITask.<>f__mg$cache1F1 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleUITask.get_m_preCombatTargetActor);
		}
		LuaCSFunction get41 = Lua_BlackJack_ProjectL_UI_BattleUITask.<>f__mg$cache1F1;
		if (Lua_BlackJack_ProjectL_UI_BattleUITask.<>f__mg$cache1F2 == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleUITask.<>f__mg$cache1F2 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleUITask.set_m_preCombatTargetActor);
		}
		LuaObject.addMember(l, name54, get41, Lua_BlackJack_ProjectL_UI_BattleUITask.<>f__mg$cache1F2, true);
		string name55 = "m_saveShowTopUI";
		if (Lua_BlackJack_ProjectL_UI_BattleUITask.<>f__mg$cache1F3 == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleUITask.<>f__mg$cache1F3 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleUITask.get_m_saveShowTopUI);
		}
		LuaCSFunction get42 = Lua_BlackJack_ProjectL_UI_BattleUITask.<>f__mg$cache1F3;
		if (Lua_BlackJack_ProjectL_UI_BattleUITask.<>f__mg$cache1F4 == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleUITask.<>f__mg$cache1F4 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleUITask.set_m_saveShowTopUI);
		}
		LuaObject.addMember(l, name55, get42, Lua_BlackJack_ProjectL_UI_BattleUITask.<>f__mg$cache1F4, true);
		string name56 = "m_saveShowBottomUI";
		if (Lua_BlackJack_ProjectL_UI_BattleUITask.<>f__mg$cache1F5 == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleUITask.<>f__mg$cache1F5 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleUITask.get_m_saveShowBottomUI);
		}
		LuaCSFunction get43 = Lua_BlackJack_ProjectL_UI_BattleUITask.<>f__mg$cache1F5;
		if (Lua_BlackJack_ProjectL_UI_BattleUITask.<>f__mg$cache1F6 == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleUITask.<>f__mg$cache1F6 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleUITask.set_m_saveShowBottomUI);
		}
		LuaObject.addMember(l, name56, get43, Lua_BlackJack_ProjectL_UI_BattleUITask.<>f__mg$cache1F6, true);
		string name57 = "m_disableSaveProcessingBattle";
		if (Lua_BlackJack_ProjectL_UI_BattleUITask.<>f__mg$cache1F7 == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleUITask.<>f__mg$cache1F7 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleUITask.get_m_disableSaveProcessingBattle);
		}
		LuaCSFunction get44 = Lua_BlackJack_ProjectL_UI_BattleUITask.<>f__mg$cache1F7;
		if (Lua_BlackJack_ProjectL_UI_BattleUITask.<>f__mg$cache1F8 == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleUITask.<>f__mg$cache1F8 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleUITask.set_m_disableSaveProcessingBattle);
		}
		LuaObject.addMember(l, name57, get44, Lua_BlackJack_ProjectL_UI_BattleUITask.<>f__mg$cache1F8, true);
		string name58 = "m_battleTeamSetup0";
		if (Lua_BlackJack_ProjectL_UI_BattleUITask.<>f__mg$cache1F9 == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleUITask.<>f__mg$cache1F9 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleUITask.get_m_battleTeamSetup0);
		}
		LuaCSFunction get45 = Lua_BlackJack_ProjectL_UI_BattleUITask.<>f__mg$cache1F9;
		if (Lua_BlackJack_ProjectL_UI_BattleUITask.<>f__mg$cache1FA == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleUITask.<>f__mg$cache1FA = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleUITask.set_m_battleTeamSetup0);
		}
		LuaObject.addMember(l, name58, get45, Lua_BlackJack_ProjectL_UI_BattleUITask.<>f__mg$cache1FA, true);
		string name59 = "m_battleTeamSetup1";
		if (Lua_BlackJack_ProjectL_UI_BattleUITask.<>f__mg$cache1FB == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleUITask.<>f__mg$cache1FB = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleUITask.get_m_battleTeamSetup1);
		}
		LuaCSFunction get46 = Lua_BlackJack_ProjectL_UI_BattleUITask.<>f__mg$cache1FB;
		if (Lua_BlackJack_ProjectL_UI_BattleUITask.<>f__mg$cache1FC == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleUITask.<>f__mg$cache1FC = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleUITask.set_m_battleTeamSetup1);
		}
		LuaObject.addMember(l, name59, get46, Lua_BlackJack_ProjectL_UI_BattleUITask.<>f__mg$cache1FC, true);
		string name60 = "m_teamPositions0";
		if (Lua_BlackJack_ProjectL_UI_BattleUITask.<>f__mg$cache1FD == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleUITask.<>f__mg$cache1FD = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleUITask.get_m_teamPositions0);
		}
		LuaCSFunction get47 = Lua_BlackJack_ProjectL_UI_BattleUITask.<>f__mg$cache1FD;
		if (Lua_BlackJack_ProjectL_UI_BattleUITask.<>f__mg$cache1FE == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleUITask.<>f__mg$cache1FE = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleUITask.set_m_teamPositions0);
		}
		LuaObject.addMember(l, name60, get47, Lua_BlackJack_ProjectL_UI_BattleUITask.<>f__mg$cache1FE, true);
		string name61 = "m_teamPositions1";
		if (Lua_BlackJack_ProjectL_UI_BattleUITask.<>f__mg$cache1FF == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleUITask.<>f__mg$cache1FF = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleUITask.get_m_teamPositions1);
		}
		LuaCSFunction get48 = Lua_BlackJack_ProjectL_UI_BattleUITask.<>f__mg$cache1FF;
		if (Lua_BlackJack_ProjectL_UI_BattleUITask.<>f__mg$cache200 == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleUITask.<>f__mg$cache200 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleUITask.set_m_teamPositions1);
		}
		LuaObject.addMember(l, name61, get48, Lua_BlackJack_ProjectL_UI_BattleUITask.<>f__mg$cache200, true);
		string name62 = "m_teamNpcPositions0";
		if (Lua_BlackJack_ProjectL_UI_BattleUITask.<>f__mg$cache201 == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleUITask.<>f__mg$cache201 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleUITask.get_m_teamNpcPositions0);
		}
		LuaCSFunction get49 = Lua_BlackJack_ProjectL_UI_BattleUITask.<>f__mg$cache201;
		if (Lua_BlackJack_ProjectL_UI_BattleUITask.<>f__mg$cache202 == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleUITask.<>f__mg$cache202 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleUITask.set_m_teamNpcPositions0);
		}
		LuaObject.addMember(l, name62, get49, Lua_BlackJack_ProjectL_UI_BattleUITask.<>f__mg$cache202, true);
		string name63 = "m_playerBattleHeros";
		if (Lua_BlackJack_ProjectL_UI_BattleUITask.<>f__mg$cache203 == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleUITask.<>f__mg$cache203 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleUITask.get_m_playerBattleHeros);
		}
		LuaCSFunction get50 = Lua_BlackJack_ProjectL_UI_BattleUITask.<>f__mg$cache203;
		if (Lua_BlackJack_ProjectL_UI_BattleUITask.<>f__mg$cache204 == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleUITask.<>f__mg$cache204 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleUITask.set_m_playerBattleHeros);
		}
		LuaObject.addMember(l, name63, get50, Lua_BlackJack_ProjectL_UI_BattleUITask.<>f__mg$cache204, true);
		string name64 = "m_tempIntList";
		if (Lua_BlackJack_ProjectL_UI_BattleUITask.<>f__mg$cache205 == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleUITask.<>f__mg$cache205 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleUITask.get_m_tempIntList);
		}
		LuaCSFunction get51 = Lua_BlackJack_ProjectL_UI_BattleUITask.<>f__mg$cache205;
		if (Lua_BlackJack_ProjectL_UI_BattleUITask.<>f__mg$cache206 == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleUITask.<>f__mg$cache206 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleUITask.set_m_tempIntList);
		}
		LuaObject.addMember(l, name64, get51, Lua_BlackJack_ProjectL_UI_BattleUITask.<>f__mg$cache206, true);
		string name65 = "m_tempStringList";
		if (Lua_BlackJack_ProjectL_UI_BattleUITask.<>f__mg$cache207 == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleUITask.<>f__mg$cache207 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleUITask.get_m_tempStringList);
		}
		LuaCSFunction get52 = Lua_BlackJack_ProjectL_UI_BattleUITask.<>f__mg$cache207;
		if (Lua_BlackJack_ProjectL_UI_BattleUITask.<>f__mg$cache208 == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleUITask.<>f__mg$cache208 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleUITask.set_m_tempStringList);
		}
		LuaObject.addMember(l, name65, get52, Lua_BlackJack_ProjectL_UI_BattleUITask.<>f__mg$cache208, true);
		string name66 = "m_dangerRegion";
		if (Lua_BlackJack_ProjectL_UI_BattleUITask.<>f__mg$cache209 == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleUITask.<>f__mg$cache209 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleUITask.get_m_dangerRegion);
		}
		LuaCSFunction get53 = Lua_BlackJack_ProjectL_UI_BattleUITask.<>f__mg$cache209;
		if (Lua_BlackJack_ProjectL_UI_BattleUITask.<>f__mg$cache20A == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleUITask.<>f__mg$cache20A = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleUITask.set_m_dangerRegion);
		}
		LuaObject.addMember(l, name66, get53, Lua_BlackJack_ProjectL_UI_BattleUITask.<>f__mg$cache20A, true);
		string name67 = "m_trainingTechs";
		if (Lua_BlackJack_ProjectL_UI_BattleUITask.<>f__mg$cache20B == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleUITask.<>f__mg$cache20B = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleUITask.get_m_trainingTechs);
		}
		LuaCSFunction get54 = Lua_BlackJack_ProjectL_UI_BattleUITask.<>f__mg$cache20B;
		if (Lua_BlackJack_ProjectL_UI_BattleUITask.<>f__mg$cache20C == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleUITask.<>f__mg$cache20C = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleUITask.set_m_trainingTechs);
		}
		LuaObject.addMember(l, name67, get54, Lua_BlackJack_ProjectL_UI_BattleUITask.<>f__mg$cache20C, true);
		string name68 = "m_userGuideEnforceHeroIds";
		if (Lua_BlackJack_ProjectL_UI_BattleUITask.<>f__mg$cache20D == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleUITask.<>f__mg$cache20D = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleUITask.get_m_userGuideEnforceHeroIds);
		}
		LuaCSFunction get55 = Lua_BlackJack_ProjectL_UI_BattleUITask.<>f__mg$cache20D;
		if (Lua_BlackJack_ProjectL_UI_BattleUITask.<>f__mg$cache20E == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleUITask.<>f__mg$cache20E = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleUITask.set_m_userGuideEnforceHeroIds);
		}
		LuaObject.addMember(l, name68, get55, Lua_BlackJack_ProjectL_UI_BattleUITask.<>f__mg$cache20E, true);
		string name69 = "m_arenaAttackerHeroIds";
		if (Lua_BlackJack_ProjectL_UI_BattleUITask.<>f__mg$cache20F == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleUITask.<>f__mg$cache20F = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleUITask.get_m_arenaAttackerHeroIds);
		}
		LuaCSFunction get56 = Lua_BlackJack_ProjectL_UI_BattleUITask.<>f__mg$cache20F;
		if (Lua_BlackJack_ProjectL_UI_BattleUITask.<>f__mg$cache210 == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleUITask.<>f__mg$cache210 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleUITask.set_m_arenaAttackerHeroIds);
		}
		LuaObject.addMember(l, name69, get56, Lua_BlackJack_ProjectL_UI_BattleUITask.<>f__mg$cache210, true);
		string name70 = "m_myBattleHeroIds";
		if (Lua_BlackJack_ProjectL_UI_BattleUITask.<>f__mg$cache211 == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleUITask.<>f__mg$cache211 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleUITask.get_m_myBattleHeroIds);
		}
		LuaCSFunction get57 = Lua_BlackJack_ProjectL_UI_BattleUITask.<>f__mg$cache211;
		if (Lua_BlackJack_ProjectL_UI_BattleUITask.<>f__mg$cache212 == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleUITask.<>f__mg$cache212 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleUITask.set_m_myBattleHeroIds);
		}
		LuaObject.addMember(l, name70, get57, Lua_BlackJack_ProjectL_UI_BattleUITask.<>f__mg$cache212, true);
		string name71 = "m_loadState";
		if (Lua_BlackJack_ProjectL_UI_BattleUITask.<>f__mg$cache213 == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleUITask.<>f__mg$cache213 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleUITask.get_m_loadState);
		}
		LuaCSFunction get58 = Lua_BlackJack_ProjectL_UI_BattleUITask.<>f__mg$cache213;
		if (Lua_BlackJack_ProjectL_UI_BattleUITask.<>f__mg$cache214 == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleUITask.<>f__mg$cache214 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleUITask.set_m_loadState);
		}
		LuaObject.addMember(l, name71, get58, Lua_BlackJack_ProjectL_UI_BattleUITask.<>f__mg$cache214, true);
		string name72 = "m_battlePerformState";
		if (Lua_BlackJack_ProjectL_UI_BattleUITask.<>f__mg$cache215 == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleUITask.<>f__mg$cache215 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleUITask.get_m_battlePerformState);
		}
		LuaCSFunction get59 = Lua_BlackJack_ProjectL_UI_BattleUITask.<>f__mg$cache215;
		if (Lua_BlackJack_ProjectL_UI_BattleUITask.<>f__mg$cache216 == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleUITask.<>f__mg$cache216 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleUITask.set_m_battlePerformState);
		}
		LuaObject.addMember(l, name72, get59, Lua_BlackJack_ProjectL_UI_BattleUITask.<>f__mg$cache216, true);
		string name73 = "m_isStartBattleAutoBattle";
		if (Lua_BlackJack_ProjectL_UI_BattleUITask.<>f__mg$cache217 == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleUITask.<>f__mg$cache217 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleUITask.get_m_isStartBattleAutoBattle);
		}
		LuaCSFunction get60 = Lua_BlackJack_ProjectL_UI_BattleUITask.<>f__mg$cache217;
		if (Lua_BlackJack_ProjectL_UI_BattleUITask.<>f__mg$cache218 == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleUITask.<>f__mg$cache218 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleUITask.set_m_isStartBattleAutoBattle);
		}
		LuaObject.addMember(l, name73, get60, Lua_BlackJack_ProjectL_UI_BattleUITask.<>f__mg$cache218, true);
		string name74 = "m_nowSeconds";
		if (Lua_BlackJack_ProjectL_UI_BattleUITask.<>f__mg$cache219 == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleUITask.<>f__mg$cache219 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleUITask.get_m_nowSeconds);
		}
		LuaCSFunction get61 = Lua_BlackJack_ProjectL_UI_BattleUITask.<>f__mg$cache219;
		if (Lua_BlackJack_ProjectL_UI_BattleUITask.<>f__mg$cache21A == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleUITask.<>f__mg$cache21A = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleUITask.set_m_nowSeconds);
		}
		LuaObject.addMember(l, name74, get61, Lua_BlackJack_ProjectL_UI_BattleUITask.<>f__mg$cache21A, true);
		string name75 = "m_myActionTimeout";
		if (Lua_BlackJack_ProjectL_UI_BattleUITask.<>f__mg$cache21B == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleUITask.<>f__mg$cache21B = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleUITask.get_m_myActionTimeout);
		}
		LuaCSFunction get62 = Lua_BlackJack_ProjectL_UI_BattleUITask.<>f__mg$cache21B;
		if (Lua_BlackJack_ProjectL_UI_BattleUITask.<>f__mg$cache21C == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleUITask.<>f__mg$cache21C = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleUITask.set_m_myActionTimeout);
		}
		LuaObject.addMember(l, name75, get62, Lua_BlackJack_ProjectL_UI_BattleUITask.<>f__mg$cache21C, true);
		string name76 = "m_otherActionTimeout";
		if (Lua_BlackJack_ProjectL_UI_BattleUITask.<>f__mg$cache21D == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleUITask.<>f__mg$cache21D = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleUITask.get_m_otherActionTimeout);
		}
		LuaCSFunction get63 = Lua_BlackJack_ProjectL_UI_BattleUITask.<>f__mg$cache21D;
		if (Lua_BlackJack_ProjectL_UI_BattleUITask.<>f__mg$cache21E == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleUITask.<>f__mg$cache21E = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleUITask.set_m_otherActionTimeout);
		}
		LuaObject.addMember(l, name76, get63, Lua_BlackJack_ProjectL_UI_BattleUITask.<>f__mg$cache21E, true);
		string name77 = "m_isMyActionTimeoutActive";
		if (Lua_BlackJack_ProjectL_UI_BattleUITask.<>f__mg$cache21F == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleUITask.<>f__mg$cache21F = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleUITask.get_m_isMyActionTimeoutActive);
		}
		LuaCSFunction get64 = Lua_BlackJack_ProjectL_UI_BattleUITask.<>f__mg$cache21F;
		if (Lua_BlackJack_ProjectL_UI_BattleUITask.<>f__mg$cache220 == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleUITask.<>f__mg$cache220 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleUITask.set_m_isMyActionTimeoutActive);
		}
		LuaObject.addMember(l, name77, get64, Lua_BlackJack_ProjectL_UI_BattleUITask.<>f__mg$cache220, true);
		string name78 = "m_isActionTimeoutAutoBattle";
		if (Lua_BlackJack_ProjectL_UI_BattleUITask.<>f__mg$cache221 == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleUITask.<>f__mg$cache221 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleUITask.get_m_isActionTimeoutAutoBattle);
		}
		LuaCSFunction get65 = Lua_BlackJack_ProjectL_UI_BattleUITask.<>f__mg$cache221;
		if (Lua_BlackJack_ProjectL_UI_BattleUITask.<>f__mg$cache222 == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleUITask.<>f__mg$cache222 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleUITask.set_m_isActionTimeoutAutoBattle);
		}
		LuaObject.addMember(l, name78, get65, Lua_BlackJack_ProjectL_UI_BattleUITask.<>f__mg$cache222, true);
		string name79 = "m_isAutoBattleOnce";
		if (Lua_BlackJack_ProjectL_UI_BattleUITask.<>f__mg$cache223 == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleUITask.<>f__mg$cache223 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleUITask.get_m_isAutoBattleOnce);
		}
		LuaCSFunction get66 = Lua_BlackJack_ProjectL_UI_BattleUITask.<>f__mg$cache223;
		if (Lua_BlackJack_ProjectL_UI_BattleUITask.<>f__mg$cache224 == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleUITask.<>f__mg$cache224 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleUITask.set_m_isAutoBattleOnce);
		}
		LuaObject.addMember(l, name79, get66, Lua_BlackJack_ProjectL_UI_BattleUITask.<>f__mg$cache224, true);
		string name80 = "m_pendingHeroSetupNtfs";
		if (Lua_BlackJack_ProjectL_UI_BattleUITask.<>f__mg$cache225 == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleUITask.<>f__mg$cache225 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleUITask.get_m_pendingHeroSetupNtfs);
		}
		LuaCSFunction get67 = Lua_BlackJack_ProjectL_UI_BattleUITask.<>f__mg$cache225;
		if (Lua_BlackJack_ProjectL_UI_BattleUITask.<>f__mg$cache226 == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleUITask.<>f__mg$cache226 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleUITask.set_m_pendingHeroSetupNtfs);
		}
		LuaObject.addMember(l, name80, get67, Lua_BlackJack_ProjectL_UI_BattleUITask.<>f__mg$cache226, true);
		string name81 = "m_selectProtectHeroPos";
		if (Lua_BlackJack_ProjectL_UI_BattleUITask.<>f__mg$cache227 == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleUITask.<>f__mg$cache227 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleUITask.get_m_selectProtectHeroPos);
		}
		LuaCSFunction get68 = Lua_BlackJack_ProjectL_UI_BattleUITask.<>f__mg$cache227;
		if (Lua_BlackJack_ProjectL_UI_BattleUITask.<>f__mg$cache228 == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleUITask.<>f__mg$cache228 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleUITask.set_m_selectProtectHeroPos);
		}
		LuaObject.addMember(l, name81, get68, Lua_BlackJack_ProjectL_UI_BattleUITask.<>f__mg$cache228, true);
		string name82 = "m_selectBanHeroPos";
		if (Lua_BlackJack_ProjectL_UI_BattleUITask.<>f__mg$cache229 == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleUITask.<>f__mg$cache229 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleUITask.get_m_selectBanHeroPos);
		}
		LuaCSFunction get69 = Lua_BlackJack_ProjectL_UI_BattleUITask.<>f__mg$cache229;
		if (Lua_BlackJack_ProjectL_UI_BattleUITask.<>f__mg$cache22A == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleUITask.<>f__mg$cache22A = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleUITask.set_m_selectBanHeroPos);
		}
		LuaObject.addMember(l, name82, get69, Lua_BlackJack_ProjectL_UI_BattleUITask.<>f__mg$cache22A, true);
		string name83 = "m_collectAssetObjects";
		if (Lua_BlackJack_ProjectL_UI_BattleUITask.<>f__mg$cache22B == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleUITask.<>f__mg$cache22B = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleUITask.get_m_collectAssetObjects);
		}
		LuaCSFunction get70 = Lua_BlackJack_ProjectL_UI_BattleUITask.<>f__mg$cache22B;
		if (Lua_BlackJack_ProjectL_UI_BattleUITask.<>f__mg$cache22C == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleUITask.<>f__mg$cache22C = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleUITask.set_m_collectAssetObjects);
		}
		LuaObject.addMember(l, name83, get70, Lua_BlackJack_ProjectL_UI_BattleUITask.<>f__mg$cache22C, true);
		string name84 = "m_armyRandomNumber";
		if (Lua_BlackJack_ProjectL_UI_BattleUITask.<>f__mg$cache22D == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleUITask.<>f__mg$cache22D = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleUITask.get_m_armyRandomNumber);
		}
		LuaCSFunction get71 = Lua_BlackJack_ProjectL_UI_BattleUITask.<>f__mg$cache22D;
		if (Lua_BlackJack_ProjectL_UI_BattleUITask.<>f__mg$cache22E == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleUITask.<>f__mg$cache22E = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleUITask.set_m_armyRandomNumber);
		}
		LuaObject.addMember(l, name84, get71, Lua_BlackJack_ProjectL_UI_BattleUITask.<>f__mg$cache22E, true);
		string name85 = "m_battleReport";
		if (Lua_BlackJack_ProjectL_UI_BattleUITask.<>f__mg$cache22F == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleUITask.<>f__mg$cache22F = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleUITask.get_m_battleReport);
		}
		LuaCSFunction get72 = Lua_BlackJack_ProjectL_UI_BattleUITask.<>f__mg$cache22F;
		if (Lua_BlackJack_ProjectL_UI_BattleUITask.<>f__mg$cache230 == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleUITask.<>f__mg$cache230 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleUITask.set_m_battleReport);
		}
		LuaObject.addMember(l, name85, get72, Lua_BlackJack_ProjectL_UI_BattleUITask.<>f__mg$cache230, true);
		string name86 = "m_battleStopTurn";
		if (Lua_BlackJack_ProjectL_UI_BattleUITask.<>f__mg$cache231 == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleUITask.<>f__mg$cache231 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleUITask.get_m_battleStopTurn);
		}
		LuaCSFunction get73 = Lua_BlackJack_ProjectL_UI_BattleUITask.<>f__mg$cache231;
		if (Lua_BlackJack_ProjectL_UI_BattleUITask.<>f__mg$cache232 == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleUITask.<>f__mg$cache232 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleUITask.set_m_battleStopTurn);
		}
		LuaObject.addMember(l, name86, get73, Lua_BlackJack_ProjectL_UI_BattleUITask.<>f__mg$cache232, true);
		string name87 = "m_isSendBattleCheatGMCommand";
		if (Lua_BlackJack_ProjectL_UI_BattleUITask.<>f__mg$cache233 == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleUITask.<>f__mg$cache233 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleUITask.get_m_isSendBattleCheatGMCommand);
		}
		LuaCSFunction get74 = Lua_BlackJack_ProjectL_UI_BattleUITask.<>f__mg$cache233;
		if (Lua_BlackJack_ProjectL_UI_BattleUITask.<>f__mg$cache234 == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleUITask.<>f__mg$cache234 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleUITask.set_m_isSendBattleCheatGMCommand);
		}
		LuaObject.addMember(l, name87, get74, Lua_BlackJack_ProjectL_UI_BattleUITask.<>f__mg$cache234, true);
		string name88 = "m_isStartInBattleRoom";
		if (Lua_BlackJack_ProjectL_UI_BattleUITask.<>f__mg$cache235 == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleUITask.<>f__mg$cache235 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleUITask.get_m_isStartInBattleRoom);
		}
		LuaCSFunction get75 = Lua_BlackJack_ProjectL_UI_BattleUITask.<>f__mg$cache235;
		if (Lua_BlackJack_ProjectL_UI_BattleUITask.<>f__mg$cache236 == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleUITask.<>f__mg$cache236 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleUITask.set_m_isStartInBattleRoom);
		}
		LuaObject.addMember(l, name88, get75, Lua_BlackJack_ProjectL_UI_BattleUITask.<>f__mg$cache236, true);
		string name89 = "m_onActiveActorEvent";
		LuaCSFunction get76 = null;
		if (Lua_BlackJack_ProjectL_UI_BattleUITask.<>f__mg$cache237 == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleUITask.<>f__mg$cache237 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleUITask.set_m_onActiveActorEvent);
		}
		LuaObject.addMember(l, name89, get76, Lua_BlackJack_ProjectL_UI_BattleUITask.<>f__mg$cache237, false);
		string name90 = "m_onDeactiveActorEvent";
		LuaCSFunction get77 = null;
		if (Lua_BlackJack_ProjectL_UI_BattleUITask.<>f__mg$cache238 == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleUITask.<>f__mg$cache238 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleUITask.set_m_onDeactiveActorEvent);
		}
		LuaObject.addMember(l, name90, get77, Lua_BlackJack_ProjectL_UI_BattleUITask.<>f__mg$cache238, false);
		string name91 = "m_regretSteps";
		if (Lua_BlackJack_ProjectL_UI_BattleUITask.<>f__mg$cache239 == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleUITask.<>f__mg$cache239 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleUITask.get_m_regretSteps);
		}
		LuaCSFunction get78 = Lua_BlackJack_ProjectL_UI_BattleUITask.<>f__mg$cache239;
		if (Lua_BlackJack_ProjectL_UI_BattleUITask.<>f__mg$cache23A == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleUITask.<>f__mg$cache23A = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleUITask.set_m_regretSteps);
		}
		LuaObject.addMember(l, name91, get78, Lua_BlackJack_ProjectL_UI_BattleUITask.<>f__mg$cache23A, true);
		string name92 = "m_regretBattleCommands";
		if (Lua_BlackJack_ProjectL_UI_BattleUITask.<>f__mg$cache23B == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleUITask.<>f__mg$cache23B = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleUITask.get_m_regretBattleCommands);
		}
		LuaCSFunction get79 = Lua_BlackJack_ProjectL_UI_BattleUITask.<>f__mg$cache23B;
		if (Lua_BlackJack_ProjectL_UI_BattleUITask.<>f__mg$cache23C == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleUITask.<>f__mg$cache23C = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleUITask.set_m_regretBattleCommands);
		}
		LuaObject.addMember(l, name92, get79, Lua_BlackJack_ProjectL_UI_BattleUITask.<>f__mg$cache23C, true);
		string name93 = "m_regretFinalStep";
		if (Lua_BlackJack_ProjectL_UI_BattleUITask.<>f__mg$cache23D == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleUITask.<>f__mg$cache23D = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleUITask.get_m_regretFinalStep);
		}
		LuaCSFunction get80 = Lua_BlackJack_ProjectL_UI_BattleUITask.<>f__mg$cache23D;
		if (Lua_BlackJack_ProjectL_UI_BattleUITask.<>f__mg$cache23E == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleUITask.<>f__mg$cache23E = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleUITask.set_m_regretFinalStep);
		}
		LuaObject.addMember(l, name93, get80, Lua_BlackJack_ProjectL_UI_BattleUITask.<>f__mg$cache23E, true);
		string name94 = "m_regretCurrentStep";
		if (Lua_BlackJack_ProjectL_UI_BattleUITask.<>f__mg$cache23F == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleUITask.<>f__mg$cache23F = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleUITask.get_m_regretCurrentStep);
		}
		LuaCSFunction get81 = Lua_BlackJack_ProjectL_UI_BattleUITask.<>f__mg$cache23F;
		if (Lua_BlackJack_ProjectL_UI_BattleUITask.<>f__mg$cache240 == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleUITask.<>f__mg$cache240 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleUITask.set_m_regretCurrentStep);
		}
		LuaObject.addMember(l, name94, get81, Lua_BlackJack_ProjectL_UI_BattleUITask.<>f__mg$cache240, true);
		string name95 = "m_regretCameraFocusActorId";
		if (Lua_BlackJack_ProjectL_UI_BattleUITask.<>f__mg$cache241 == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleUITask.<>f__mg$cache241 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleUITask.get_m_regretCameraFocusActorId);
		}
		LuaCSFunction get82 = Lua_BlackJack_ProjectL_UI_BattleUITask.<>f__mg$cache241;
		if (Lua_BlackJack_ProjectL_UI_BattleUITask.<>f__mg$cache242 == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleUITask.<>f__mg$cache242 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleUITask.set_m_regretCameraFocusActorId);
		}
		LuaObject.addMember(l, name95, get82, Lua_BlackJack_ProjectL_UI_BattleUITask.<>f__mg$cache242, true);
		string name96 = "ClientBattle";
		if (Lua_BlackJack_ProjectL_UI_BattleUITask.<>f__mg$cache243 == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleUITask.<>f__mg$cache243 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleUITask.get_ClientBattle);
		}
		LuaObject.addMember(l, name96, Lua_BlackJack_ProjectL_UI_BattleUITask.<>f__mg$cache243, null, true);
		string name97 = "LayerDescArray";
		if (Lua_BlackJack_ProjectL_UI_BattleUITask.<>f__mg$cache244 == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleUITask.<>f__mg$cache244 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleUITask.get_LayerDescArray);
		}
		LuaObject.addMember(l, name97, Lua_BlackJack_ProjectL_UI_BattleUITask.<>f__mg$cache244, null, true);
		string name98 = "UICtrlDescArray";
		if (Lua_BlackJack_ProjectL_UI_BattleUITask.<>f__mg$cache245 == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleUITask.<>f__mg$cache245 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleUITask.get_UICtrlDescArray);
		}
		LuaObject.addMember(l, name98, Lua_BlackJack_ProjectL_UI_BattleUITask.<>f__mg$cache245, null, true);
		if (Lua_BlackJack_ProjectL_UI_BattleUITask.<>f__mg$cache246 == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleUITask.<>f__mg$cache246 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleUITask.constructor);
		}
		LuaObject.createTypeMetatable(l, Lua_BlackJack_ProjectL_UI_BattleUITask.<>f__mg$cache246, typeof(BattleUITask), typeof(UITask));
	}

	// Token: 0x040124C5 RID: 74949
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache0;

	// Token: 0x040124C6 RID: 74950
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1;

	// Token: 0x040124C7 RID: 74951
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2;

	// Token: 0x040124C8 RID: 74952
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3;

	// Token: 0x040124C9 RID: 74953
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache4;

	// Token: 0x040124CA RID: 74954
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache5;

	// Token: 0x040124CB RID: 74955
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache6;

	// Token: 0x040124CC RID: 74956
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache7;

	// Token: 0x040124CD RID: 74957
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache8;

	// Token: 0x040124CE RID: 74958
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache9;

	// Token: 0x040124CF RID: 74959
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheA;

	// Token: 0x040124D0 RID: 74960
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheB;

	// Token: 0x040124D1 RID: 74961
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheC;

	// Token: 0x040124D2 RID: 74962
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheD;

	// Token: 0x040124D3 RID: 74963
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheE;

	// Token: 0x040124D4 RID: 74964
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheF;

	// Token: 0x040124D5 RID: 74965
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache10;

	// Token: 0x040124D6 RID: 74966
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache11;

	// Token: 0x040124D7 RID: 74967
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache12;

	// Token: 0x040124D8 RID: 74968
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache13;

	// Token: 0x040124D9 RID: 74969
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache14;

	// Token: 0x040124DA RID: 74970
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache15;

	// Token: 0x040124DB RID: 74971
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache16;

	// Token: 0x040124DC RID: 74972
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache17;

	// Token: 0x040124DD RID: 74973
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache18;

	// Token: 0x040124DE RID: 74974
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache19;

	// Token: 0x040124DF RID: 74975
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1A;

	// Token: 0x040124E0 RID: 74976
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1B;

	// Token: 0x040124E1 RID: 74977
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1C;

	// Token: 0x040124E2 RID: 74978
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1D;

	// Token: 0x040124E3 RID: 74979
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1E;

	// Token: 0x040124E4 RID: 74980
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1F;

	// Token: 0x040124E5 RID: 74981
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache20;

	// Token: 0x040124E6 RID: 74982
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache21;

	// Token: 0x040124E7 RID: 74983
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache22;

	// Token: 0x040124E8 RID: 74984
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache23;

	// Token: 0x040124E9 RID: 74985
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache24;

	// Token: 0x040124EA RID: 74986
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache25;

	// Token: 0x040124EB RID: 74987
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache26;

	// Token: 0x040124EC RID: 74988
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache27;

	// Token: 0x040124ED RID: 74989
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache28;

	// Token: 0x040124EE RID: 74990
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache29;

	// Token: 0x040124EF RID: 74991
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2A;

	// Token: 0x040124F0 RID: 74992
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2B;

	// Token: 0x040124F1 RID: 74993
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2C;

	// Token: 0x040124F2 RID: 74994
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2D;

	// Token: 0x040124F3 RID: 74995
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2E;

	// Token: 0x040124F4 RID: 74996
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2F;

	// Token: 0x040124F5 RID: 74997
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache30;

	// Token: 0x040124F6 RID: 74998
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache31;

	// Token: 0x040124F7 RID: 74999
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache32;

	// Token: 0x040124F8 RID: 75000
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache33;

	// Token: 0x040124F9 RID: 75001
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache34;

	// Token: 0x040124FA RID: 75002
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache35;

	// Token: 0x040124FB RID: 75003
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache36;

	// Token: 0x040124FC RID: 75004
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache37;

	// Token: 0x040124FD RID: 75005
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache38;

	// Token: 0x040124FE RID: 75006
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache39;

	// Token: 0x040124FF RID: 75007
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3A;

	// Token: 0x04012500 RID: 75008
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3B;

	// Token: 0x04012501 RID: 75009
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3C;

	// Token: 0x04012502 RID: 75010
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3D;

	// Token: 0x04012503 RID: 75011
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3E;

	// Token: 0x04012504 RID: 75012
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3F;

	// Token: 0x04012505 RID: 75013
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache40;

	// Token: 0x04012506 RID: 75014
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache41;

	// Token: 0x04012507 RID: 75015
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache42;

	// Token: 0x04012508 RID: 75016
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache43;

	// Token: 0x04012509 RID: 75017
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache44;

	// Token: 0x0401250A RID: 75018
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache45;

	// Token: 0x0401250B RID: 75019
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache46;

	// Token: 0x0401250C RID: 75020
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache47;

	// Token: 0x0401250D RID: 75021
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache48;

	// Token: 0x0401250E RID: 75022
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache49;

	// Token: 0x0401250F RID: 75023
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache4A;

	// Token: 0x04012510 RID: 75024
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache4B;

	// Token: 0x04012511 RID: 75025
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache4C;

	// Token: 0x04012512 RID: 75026
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache4D;

	// Token: 0x04012513 RID: 75027
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache4E;

	// Token: 0x04012514 RID: 75028
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache4F;

	// Token: 0x04012515 RID: 75029
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache50;

	// Token: 0x04012516 RID: 75030
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache51;

	// Token: 0x04012517 RID: 75031
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache52;

	// Token: 0x04012518 RID: 75032
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache53;

	// Token: 0x04012519 RID: 75033
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache54;

	// Token: 0x0401251A RID: 75034
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache55;

	// Token: 0x0401251B RID: 75035
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache56;

	// Token: 0x0401251C RID: 75036
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache57;

	// Token: 0x0401251D RID: 75037
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache58;

	// Token: 0x0401251E RID: 75038
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache59;

	// Token: 0x0401251F RID: 75039
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache5A;

	// Token: 0x04012520 RID: 75040
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache5B;

	// Token: 0x04012521 RID: 75041
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache5C;

	// Token: 0x04012522 RID: 75042
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache5D;

	// Token: 0x04012523 RID: 75043
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache5E;

	// Token: 0x04012524 RID: 75044
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache5F;

	// Token: 0x04012525 RID: 75045
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache60;

	// Token: 0x04012526 RID: 75046
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache61;

	// Token: 0x04012527 RID: 75047
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache62;

	// Token: 0x04012528 RID: 75048
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache63;

	// Token: 0x04012529 RID: 75049
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache64;

	// Token: 0x0401252A RID: 75050
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache65;

	// Token: 0x0401252B RID: 75051
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache66;

	// Token: 0x0401252C RID: 75052
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache67;

	// Token: 0x0401252D RID: 75053
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache68;

	// Token: 0x0401252E RID: 75054
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache69;

	// Token: 0x0401252F RID: 75055
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache6A;

	// Token: 0x04012530 RID: 75056
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache6B;

	// Token: 0x04012531 RID: 75057
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache6C;

	// Token: 0x04012532 RID: 75058
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache6D;

	// Token: 0x04012533 RID: 75059
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache6E;

	// Token: 0x04012534 RID: 75060
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache6F;

	// Token: 0x04012535 RID: 75061
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache70;

	// Token: 0x04012536 RID: 75062
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache71;

	// Token: 0x04012537 RID: 75063
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache72;

	// Token: 0x04012538 RID: 75064
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache73;

	// Token: 0x04012539 RID: 75065
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache74;

	// Token: 0x0401253A RID: 75066
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache75;

	// Token: 0x0401253B RID: 75067
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache76;

	// Token: 0x0401253C RID: 75068
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache77;

	// Token: 0x0401253D RID: 75069
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache78;

	// Token: 0x0401253E RID: 75070
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache79;

	// Token: 0x0401253F RID: 75071
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache7A;

	// Token: 0x04012540 RID: 75072
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache7B;

	// Token: 0x04012541 RID: 75073
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache7C;

	// Token: 0x04012542 RID: 75074
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache7D;

	// Token: 0x04012543 RID: 75075
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache7E;

	// Token: 0x04012544 RID: 75076
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache7F;

	// Token: 0x04012545 RID: 75077
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache80;

	// Token: 0x04012546 RID: 75078
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache81;

	// Token: 0x04012547 RID: 75079
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache82;

	// Token: 0x04012548 RID: 75080
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache83;

	// Token: 0x04012549 RID: 75081
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache84;

	// Token: 0x0401254A RID: 75082
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache85;

	// Token: 0x0401254B RID: 75083
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache86;

	// Token: 0x0401254C RID: 75084
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache87;

	// Token: 0x0401254D RID: 75085
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache88;

	// Token: 0x0401254E RID: 75086
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache89;

	// Token: 0x0401254F RID: 75087
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache8A;

	// Token: 0x04012550 RID: 75088
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache8B;

	// Token: 0x04012551 RID: 75089
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache8C;

	// Token: 0x04012552 RID: 75090
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache8D;

	// Token: 0x04012553 RID: 75091
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache8E;

	// Token: 0x04012554 RID: 75092
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache8F;

	// Token: 0x04012555 RID: 75093
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache90;

	// Token: 0x04012556 RID: 75094
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache91;

	// Token: 0x04012557 RID: 75095
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache92;

	// Token: 0x04012558 RID: 75096
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache93;

	// Token: 0x04012559 RID: 75097
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache94;

	// Token: 0x0401255A RID: 75098
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache95;

	// Token: 0x0401255B RID: 75099
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache96;

	// Token: 0x0401255C RID: 75100
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache97;

	// Token: 0x0401255D RID: 75101
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache98;

	// Token: 0x0401255E RID: 75102
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache99;

	// Token: 0x0401255F RID: 75103
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache9A;

	// Token: 0x04012560 RID: 75104
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache9B;

	// Token: 0x04012561 RID: 75105
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache9C;

	// Token: 0x04012562 RID: 75106
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache9D;

	// Token: 0x04012563 RID: 75107
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache9E;

	// Token: 0x04012564 RID: 75108
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache9F;

	// Token: 0x04012565 RID: 75109
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheA0;

	// Token: 0x04012566 RID: 75110
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheA1;

	// Token: 0x04012567 RID: 75111
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheA2;

	// Token: 0x04012568 RID: 75112
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheA3;

	// Token: 0x04012569 RID: 75113
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheA4;

	// Token: 0x0401256A RID: 75114
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheA5;

	// Token: 0x0401256B RID: 75115
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheA6;

	// Token: 0x0401256C RID: 75116
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheA7;

	// Token: 0x0401256D RID: 75117
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheA8;

	// Token: 0x0401256E RID: 75118
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheA9;

	// Token: 0x0401256F RID: 75119
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheAA;

	// Token: 0x04012570 RID: 75120
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheAB;

	// Token: 0x04012571 RID: 75121
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheAC;

	// Token: 0x04012572 RID: 75122
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheAD;

	// Token: 0x04012573 RID: 75123
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheAE;

	// Token: 0x04012574 RID: 75124
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheAF;

	// Token: 0x04012575 RID: 75125
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheB0;

	// Token: 0x04012576 RID: 75126
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheB1;

	// Token: 0x04012577 RID: 75127
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheB2;

	// Token: 0x04012578 RID: 75128
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheB3;

	// Token: 0x04012579 RID: 75129
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheB4;

	// Token: 0x0401257A RID: 75130
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheB5;

	// Token: 0x0401257B RID: 75131
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheB6;

	// Token: 0x0401257C RID: 75132
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheB7;

	// Token: 0x0401257D RID: 75133
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheB8;

	// Token: 0x0401257E RID: 75134
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheB9;

	// Token: 0x0401257F RID: 75135
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheBA;

	// Token: 0x04012580 RID: 75136
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheBB;

	// Token: 0x04012581 RID: 75137
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheBC;

	// Token: 0x04012582 RID: 75138
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheBD;

	// Token: 0x04012583 RID: 75139
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheBE;

	// Token: 0x04012584 RID: 75140
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheBF;

	// Token: 0x04012585 RID: 75141
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheC0;

	// Token: 0x04012586 RID: 75142
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheC1;

	// Token: 0x04012587 RID: 75143
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheC2;

	// Token: 0x04012588 RID: 75144
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheC3;

	// Token: 0x04012589 RID: 75145
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheC4;

	// Token: 0x0401258A RID: 75146
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheC5;

	// Token: 0x0401258B RID: 75147
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheC6;

	// Token: 0x0401258C RID: 75148
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheC7;

	// Token: 0x0401258D RID: 75149
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheC8;

	// Token: 0x0401258E RID: 75150
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheC9;

	// Token: 0x0401258F RID: 75151
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheCA;

	// Token: 0x04012590 RID: 75152
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheCB;

	// Token: 0x04012591 RID: 75153
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheCC;

	// Token: 0x04012592 RID: 75154
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheCD;

	// Token: 0x04012593 RID: 75155
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheCE;

	// Token: 0x04012594 RID: 75156
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheCF;

	// Token: 0x04012595 RID: 75157
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheD0;

	// Token: 0x04012596 RID: 75158
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheD1;

	// Token: 0x04012597 RID: 75159
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheD2;

	// Token: 0x04012598 RID: 75160
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheD3;

	// Token: 0x04012599 RID: 75161
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheD4;

	// Token: 0x0401259A RID: 75162
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheD5;

	// Token: 0x0401259B RID: 75163
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheD6;

	// Token: 0x0401259C RID: 75164
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheD7;

	// Token: 0x0401259D RID: 75165
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheD8;

	// Token: 0x0401259E RID: 75166
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheD9;

	// Token: 0x0401259F RID: 75167
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheDA;

	// Token: 0x040125A0 RID: 75168
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheDB;

	// Token: 0x040125A1 RID: 75169
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheDC;

	// Token: 0x040125A2 RID: 75170
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheDD;

	// Token: 0x040125A3 RID: 75171
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheDE;

	// Token: 0x040125A4 RID: 75172
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheDF;

	// Token: 0x040125A5 RID: 75173
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheE0;

	// Token: 0x040125A6 RID: 75174
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheE1;

	// Token: 0x040125A7 RID: 75175
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheE2;

	// Token: 0x040125A8 RID: 75176
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheE3;

	// Token: 0x040125A9 RID: 75177
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheE4;

	// Token: 0x040125AA RID: 75178
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheE5;

	// Token: 0x040125AB RID: 75179
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheE6;

	// Token: 0x040125AC RID: 75180
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheE7;

	// Token: 0x040125AD RID: 75181
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheE8;

	// Token: 0x040125AE RID: 75182
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheE9;

	// Token: 0x040125AF RID: 75183
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheEA;

	// Token: 0x040125B0 RID: 75184
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheEB;

	// Token: 0x040125B1 RID: 75185
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheEC;

	// Token: 0x040125B2 RID: 75186
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheED;

	// Token: 0x040125B3 RID: 75187
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheEE;

	// Token: 0x040125B4 RID: 75188
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheEF;

	// Token: 0x040125B5 RID: 75189
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheF0;

	// Token: 0x040125B6 RID: 75190
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheF1;

	// Token: 0x040125B7 RID: 75191
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheF2;

	// Token: 0x040125B8 RID: 75192
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheF3;

	// Token: 0x040125B9 RID: 75193
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheF4;

	// Token: 0x040125BA RID: 75194
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheF5;

	// Token: 0x040125BB RID: 75195
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheF6;

	// Token: 0x040125BC RID: 75196
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheF7;

	// Token: 0x040125BD RID: 75197
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheF8;

	// Token: 0x040125BE RID: 75198
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheF9;

	// Token: 0x040125BF RID: 75199
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheFA;

	// Token: 0x040125C0 RID: 75200
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheFB;

	// Token: 0x040125C1 RID: 75201
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheFC;

	// Token: 0x040125C2 RID: 75202
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheFD;

	// Token: 0x040125C3 RID: 75203
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheFE;

	// Token: 0x040125C4 RID: 75204
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheFF;

	// Token: 0x040125C5 RID: 75205
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache100;

	// Token: 0x040125C6 RID: 75206
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache101;

	// Token: 0x040125C7 RID: 75207
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache102;

	// Token: 0x040125C8 RID: 75208
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache103;

	// Token: 0x040125C9 RID: 75209
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache104;

	// Token: 0x040125CA RID: 75210
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache105;

	// Token: 0x040125CB RID: 75211
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache106;

	// Token: 0x040125CC RID: 75212
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache107;

	// Token: 0x040125CD RID: 75213
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache108;

	// Token: 0x040125CE RID: 75214
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache109;

	// Token: 0x040125CF RID: 75215
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache10A;

	// Token: 0x040125D0 RID: 75216
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache10B;

	// Token: 0x040125D1 RID: 75217
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache10C;

	// Token: 0x040125D2 RID: 75218
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache10D;

	// Token: 0x040125D3 RID: 75219
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache10E;

	// Token: 0x040125D4 RID: 75220
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache10F;

	// Token: 0x040125D5 RID: 75221
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache110;

	// Token: 0x040125D6 RID: 75222
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache111;

	// Token: 0x040125D7 RID: 75223
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache112;

	// Token: 0x040125D8 RID: 75224
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache113;

	// Token: 0x040125D9 RID: 75225
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache114;

	// Token: 0x040125DA RID: 75226
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache115;

	// Token: 0x040125DB RID: 75227
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache116;

	// Token: 0x040125DC RID: 75228
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache117;

	// Token: 0x040125DD RID: 75229
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache118;

	// Token: 0x040125DE RID: 75230
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache119;

	// Token: 0x040125DF RID: 75231
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache11A;

	// Token: 0x040125E0 RID: 75232
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache11B;

	// Token: 0x040125E1 RID: 75233
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache11C;

	// Token: 0x040125E2 RID: 75234
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache11D;

	// Token: 0x040125E3 RID: 75235
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache11E;

	// Token: 0x040125E4 RID: 75236
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache11F;

	// Token: 0x040125E5 RID: 75237
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache120;

	// Token: 0x040125E6 RID: 75238
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache121;

	// Token: 0x040125E7 RID: 75239
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache122;

	// Token: 0x040125E8 RID: 75240
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache123;

	// Token: 0x040125E9 RID: 75241
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache124;

	// Token: 0x040125EA RID: 75242
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache125;

	// Token: 0x040125EB RID: 75243
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache126;

	// Token: 0x040125EC RID: 75244
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache127;

	// Token: 0x040125ED RID: 75245
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache128;

	// Token: 0x040125EE RID: 75246
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache129;

	// Token: 0x040125EF RID: 75247
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache12A;

	// Token: 0x040125F0 RID: 75248
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache12B;

	// Token: 0x040125F1 RID: 75249
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache12C;

	// Token: 0x040125F2 RID: 75250
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache12D;

	// Token: 0x040125F3 RID: 75251
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache12E;

	// Token: 0x040125F4 RID: 75252
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache12F;

	// Token: 0x040125F5 RID: 75253
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache130;

	// Token: 0x040125F6 RID: 75254
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache131;

	// Token: 0x040125F7 RID: 75255
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache132;

	// Token: 0x040125F8 RID: 75256
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache133;

	// Token: 0x040125F9 RID: 75257
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache134;

	// Token: 0x040125FA RID: 75258
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache135;

	// Token: 0x040125FB RID: 75259
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache136;

	// Token: 0x040125FC RID: 75260
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache137;

	// Token: 0x040125FD RID: 75261
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache138;

	// Token: 0x040125FE RID: 75262
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache139;

	// Token: 0x040125FF RID: 75263
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache13A;

	// Token: 0x04012600 RID: 75264
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache13B;

	// Token: 0x04012601 RID: 75265
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache13C;

	// Token: 0x04012602 RID: 75266
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache13D;

	// Token: 0x04012603 RID: 75267
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache13E;

	// Token: 0x04012604 RID: 75268
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache13F;

	// Token: 0x04012605 RID: 75269
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache140;

	// Token: 0x04012606 RID: 75270
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache141;

	// Token: 0x04012607 RID: 75271
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache142;

	// Token: 0x04012608 RID: 75272
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache143;

	// Token: 0x04012609 RID: 75273
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache144;

	// Token: 0x0401260A RID: 75274
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache145;

	// Token: 0x0401260B RID: 75275
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache146;

	// Token: 0x0401260C RID: 75276
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache147;

	// Token: 0x0401260D RID: 75277
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache148;

	// Token: 0x0401260E RID: 75278
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache149;

	// Token: 0x0401260F RID: 75279
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache14A;

	// Token: 0x04012610 RID: 75280
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache14B;

	// Token: 0x04012611 RID: 75281
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache14C;

	// Token: 0x04012612 RID: 75282
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache14D;

	// Token: 0x04012613 RID: 75283
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache14E;

	// Token: 0x04012614 RID: 75284
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache14F;

	// Token: 0x04012615 RID: 75285
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache150;

	// Token: 0x04012616 RID: 75286
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache151;

	// Token: 0x04012617 RID: 75287
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache152;

	// Token: 0x04012618 RID: 75288
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache153;

	// Token: 0x04012619 RID: 75289
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache154;

	// Token: 0x0401261A RID: 75290
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache155;

	// Token: 0x0401261B RID: 75291
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache156;

	// Token: 0x0401261C RID: 75292
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache157;

	// Token: 0x0401261D RID: 75293
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache158;

	// Token: 0x0401261E RID: 75294
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache159;

	// Token: 0x0401261F RID: 75295
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache15A;

	// Token: 0x04012620 RID: 75296
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache15B;

	// Token: 0x04012621 RID: 75297
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache15C;

	// Token: 0x04012622 RID: 75298
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache15D;

	// Token: 0x04012623 RID: 75299
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache15E;

	// Token: 0x04012624 RID: 75300
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache15F;

	// Token: 0x04012625 RID: 75301
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache160;

	// Token: 0x04012626 RID: 75302
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache161;

	// Token: 0x04012627 RID: 75303
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache162;

	// Token: 0x04012628 RID: 75304
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache163;

	// Token: 0x04012629 RID: 75305
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache164;

	// Token: 0x0401262A RID: 75306
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache165;

	// Token: 0x0401262B RID: 75307
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache166;

	// Token: 0x0401262C RID: 75308
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache167;

	// Token: 0x0401262D RID: 75309
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache168;

	// Token: 0x0401262E RID: 75310
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache169;

	// Token: 0x0401262F RID: 75311
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache16A;

	// Token: 0x04012630 RID: 75312
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache16B;

	// Token: 0x04012631 RID: 75313
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache16C;

	// Token: 0x04012632 RID: 75314
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache16D;

	// Token: 0x04012633 RID: 75315
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache16E;

	// Token: 0x04012634 RID: 75316
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache16F;

	// Token: 0x04012635 RID: 75317
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache170;

	// Token: 0x04012636 RID: 75318
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache171;

	// Token: 0x04012637 RID: 75319
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache172;

	// Token: 0x04012638 RID: 75320
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache173;

	// Token: 0x04012639 RID: 75321
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache174;

	// Token: 0x0401263A RID: 75322
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache175;

	// Token: 0x0401263B RID: 75323
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache176;

	// Token: 0x0401263C RID: 75324
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache177;

	// Token: 0x0401263D RID: 75325
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache178;

	// Token: 0x0401263E RID: 75326
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache179;

	// Token: 0x0401263F RID: 75327
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache17A;

	// Token: 0x04012640 RID: 75328
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache17B;

	// Token: 0x04012641 RID: 75329
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache17C;

	// Token: 0x04012642 RID: 75330
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache17D;

	// Token: 0x04012643 RID: 75331
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache17E;

	// Token: 0x04012644 RID: 75332
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache17F;

	// Token: 0x04012645 RID: 75333
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache180;

	// Token: 0x04012646 RID: 75334
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache181;

	// Token: 0x04012647 RID: 75335
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache182;

	// Token: 0x04012648 RID: 75336
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache183;

	// Token: 0x04012649 RID: 75337
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache184;

	// Token: 0x0401264A RID: 75338
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache185;

	// Token: 0x0401264B RID: 75339
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache186;

	// Token: 0x0401264C RID: 75340
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache187;

	// Token: 0x0401264D RID: 75341
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache188;

	// Token: 0x0401264E RID: 75342
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache189;

	// Token: 0x0401264F RID: 75343
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache18A;

	// Token: 0x04012650 RID: 75344
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache18B;

	// Token: 0x04012651 RID: 75345
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache18C;

	// Token: 0x04012652 RID: 75346
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache18D;

	// Token: 0x04012653 RID: 75347
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache18E;

	// Token: 0x04012654 RID: 75348
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache18F;

	// Token: 0x04012655 RID: 75349
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache190;

	// Token: 0x04012656 RID: 75350
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache191;

	// Token: 0x04012657 RID: 75351
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache192;

	// Token: 0x04012658 RID: 75352
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache193;

	// Token: 0x04012659 RID: 75353
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache194;

	// Token: 0x0401265A RID: 75354
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache195;

	// Token: 0x0401265B RID: 75355
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache196;

	// Token: 0x0401265C RID: 75356
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache197;

	// Token: 0x0401265D RID: 75357
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache198;

	// Token: 0x0401265E RID: 75358
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache199;

	// Token: 0x0401265F RID: 75359
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache19A;

	// Token: 0x04012660 RID: 75360
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache19B;

	// Token: 0x04012661 RID: 75361
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache19C;

	// Token: 0x04012662 RID: 75362
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache19D;

	// Token: 0x04012663 RID: 75363
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache19E;

	// Token: 0x04012664 RID: 75364
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache19F;

	// Token: 0x04012665 RID: 75365
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1A0;

	// Token: 0x04012666 RID: 75366
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1A1;

	// Token: 0x04012667 RID: 75367
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1A2;

	// Token: 0x04012668 RID: 75368
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1A3;

	// Token: 0x04012669 RID: 75369
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1A4;

	// Token: 0x0401266A RID: 75370
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1A5;

	// Token: 0x0401266B RID: 75371
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1A6;

	// Token: 0x0401266C RID: 75372
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1A7;

	// Token: 0x0401266D RID: 75373
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1A8;

	// Token: 0x0401266E RID: 75374
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1A9;

	// Token: 0x0401266F RID: 75375
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1AA;

	// Token: 0x04012670 RID: 75376
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1AB;

	// Token: 0x04012671 RID: 75377
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1AC;

	// Token: 0x04012672 RID: 75378
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1AD;

	// Token: 0x04012673 RID: 75379
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1AE;

	// Token: 0x04012674 RID: 75380
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1AF;

	// Token: 0x04012675 RID: 75381
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1B0;

	// Token: 0x04012676 RID: 75382
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1B1;

	// Token: 0x04012677 RID: 75383
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1B2;

	// Token: 0x04012678 RID: 75384
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1B3;

	// Token: 0x04012679 RID: 75385
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1B4;

	// Token: 0x0401267A RID: 75386
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1B5;

	// Token: 0x0401267B RID: 75387
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1B6;

	// Token: 0x0401267C RID: 75388
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1B7;

	// Token: 0x0401267D RID: 75389
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1B8;

	// Token: 0x0401267E RID: 75390
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1B9;

	// Token: 0x0401267F RID: 75391
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1BA;

	// Token: 0x04012680 RID: 75392
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1BB;

	// Token: 0x04012681 RID: 75393
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1BC;

	// Token: 0x04012682 RID: 75394
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1BD;

	// Token: 0x04012683 RID: 75395
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1BE;

	// Token: 0x04012684 RID: 75396
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1BF;

	// Token: 0x04012685 RID: 75397
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1C0;

	// Token: 0x04012686 RID: 75398
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1C1;

	// Token: 0x04012687 RID: 75399
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1C2;

	// Token: 0x04012688 RID: 75400
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1C3;

	// Token: 0x04012689 RID: 75401
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1C4;

	// Token: 0x0401268A RID: 75402
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1C5;

	// Token: 0x0401268B RID: 75403
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1C6;

	// Token: 0x0401268C RID: 75404
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1C7;

	// Token: 0x0401268D RID: 75405
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1C8;

	// Token: 0x0401268E RID: 75406
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1C9;

	// Token: 0x0401268F RID: 75407
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1CA;

	// Token: 0x04012690 RID: 75408
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1CB;

	// Token: 0x04012691 RID: 75409
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1CC;

	// Token: 0x04012692 RID: 75410
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1CD;

	// Token: 0x04012693 RID: 75411
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1CE;

	// Token: 0x04012694 RID: 75412
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1CF;

	// Token: 0x04012695 RID: 75413
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1D0;

	// Token: 0x04012696 RID: 75414
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1D1;

	// Token: 0x04012697 RID: 75415
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1D2;

	// Token: 0x04012698 RID: 75416
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1D3;

	// Token: 0x04012699 RID: 75417
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1D4;

	// Token: 0x0401269A RID: 75418
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1D5;

	// Token: 0x0401269B RID: 75419
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1D6;

	// Token: 0x0401269C RID: 75420
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1D7;

	// Token: 0x0401269D RID: 75421
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1D8;

	// Token: 0x0401269E RID: 75422
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1D9;

	// Token: 0x0401269F RID: 75423
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1DA;

	// Token: 0x040126A0 RID: 75424
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1DB;

	// Token: 0x040126A1 RID: 75425
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1DC;

	// Token: 0x040126A2 RID: 75426
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1DD;

	// Token: 0x040126A3 RID: 75427
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1DE;

	// Token: 0x040126A4 RID: 75428
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1DF;

	// Token: 0x040126A5 RID: 75429
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1E0;

	// Token: 0x040126A6 RID: 75430
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1E1;

	// Token: 0x040126A7 RID: 75431
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1E2;

	// Token: 0x040126A8 RID: 75432
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1E3;

	// Token: 0x040126A9 RID: 75433
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1E4;

	// Token: 0x040126AA RID: 75434
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1E5;

	// Token: 0x040126AB RID: 75435
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1E6;

	// Token: 0x040126AC RID: 75436
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1E7;

	// Token: 0x040126AD RID: 75437
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1E8;

	// Token: 0x040126AE RID: 75438
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1E9;

	// Token: 0x040126AF RID: 75439
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1EA;

	// Token: 0x040126B0 RID: 75440
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1EB;

	// Token: 0x040126B1 RID: 75441
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1EC;

	// Token: 0x040126B2 RID: 75442
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1ED;

	// Token: 0x040126B3 RID: 75443
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1EE;

	// Token: 0x040126B4 RID: 75444
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1EF;

	// Token: 0x040126B5 RID: 75445
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1F0;

	// Token: 0x040126B6 RID: 75446
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1F1;

	// Token: 0x040126B7 RID: 75447
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1F2;

	// Token: 0x040126B8 RID: 75448
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1F3;

	// Token: 0x040126B9 RID: 75449
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1F4;

	// Token: 0x040126BA RID: 75450
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1F5;

	// Token: 0x040126BB RID: 75451
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1F6;

	// Token: 0x040126BC RID: 75452
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1F7;

	// Token: 0x040126BD RID: 75453
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1F8;

	// Token: 0x040126BE RID: 75454
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1F9;

	// Token: 0x040126BF RID: 75455
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1FA;

	// Token: 0x040126C0 RID: 75456
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1FB;

	// Token: 0x040126C1 RID: 75457
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1FC;

	// Token: 0x040126C2 RID: 75458
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1FD;

	// Token: 0x040126C3 RID: 75459
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1FE;

	// Token: 0x040126C4 RID: 75460
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1FF;

	// Token: 0x040126C5 RID: 75461
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache200;

	// Token: 0x040126C6 RID: 75462
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache201;

	// Token: 0x040126C7 RID: 75463
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache202;

	// Token: 0x040126C8 RID: 75464
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache203;

	// Token: 0x040126C9 RID: 75465
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache204;

	// Token: 0x040126CA RID: 75466
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache205;

	// Token: 0x040126CB RID: 75467
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache206;

	// Token: 0x040126CC RID: 75468
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache207;

	// Token: 0x040126CD RID: 75469
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache208;

	// Token: 0x040126CE RID: 75470
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache209;

	// Token: 0x040126CF RID: 75471
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache20A;

	// Token: 0x040126D0 RID: 75472
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache20B;

	// Token: 0x040126D1 RID: 75473
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache20C;

	// Token: 0x040126D2 RID: 75474
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache20D;

	// Token: 0x040126D3 RID: 75475
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache20E;

	// Token: 0x040126D4 RID: 75476
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache20F;

	// Token: 0x040126D5 RID: 75477
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache210;

	// Token: 0x040126D6 RID: 75478
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache211;

	// Token: 0x040126D7 RID: 75479
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache212;

	// Token: 0x040126D8 RID: 75480
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache213;

	// Token: 0x040126D9 RID: 75481
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache214;

	// Token: 0x040126DA RID: 75482
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache215;

	// Token: 0x040126DB RID: 75483
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache216;

	// Token: 0x040126DC RID: 75484
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache217;

	// Token: 0x040126DD RID: 75485
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache218;

	// Token: 0x040126DE RID: 75486
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache219;

	// Token: 0x040126DF RID: 75487
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache21A;

	// Token: 0x040126E0 RID: 75488
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache21B;

	// Token: 0x040126E1 RID: 75489
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache21C;

	// Token: 0x040126E2 RID: 75490
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache21D;

	// Token: 0x040126E3 RID: 75491
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache21E;

	// Token: 0x040126E4 RID: 75492
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache21F;

	// Token: 0x040126E5 RID: 75493
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache220;

	// Token: 0x040126E6 RID: 75494
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache221;

	// Token: 0x040126E7 RID: 75495
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache222;

	// Token: 0x040126E8 RID: 75496
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache223;

	// Token: 0x040126E9 RID: 75497
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache224;

	// Token: 0x040126EA RID: 75498
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache225;

	// Token: 0x040126EB RID: 75499
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache226;

	// Token: 0x040126EC RID: 75500
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache227;

	// Token: 0x040126ED RID: 75501
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache228;

	// Token: 0x040126EE RID: 75502
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache229;

	// Token: 0x040126EF RID: 75503
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache22A;

	// Token: 0x040126F0 RID: 75504
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache22B;

	// Token: 0x040126F1 RID: 75505
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache22C;

	// Token: 0x040126F2 RID: 75506
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache22D;

	// Token: 0x040126F3 RID: 75507
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache22E;

	// Token: 0x040126F4 RID: 75508
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache22F;

	// Token: 0x040126F5 RID: 75509
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache230;

	// Token: 0x040126F6 RID: 75510
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache231;

	// Token: 0x040126F7 RID: 75511
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache232;

	// Token: 0x040126F8 RID: 75512
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache233;

	// Token: 0x040126F9 RID: 75513
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache234;

	// Token: 0x040126FA RID: 75514
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache235;

	// Token: 0x040126FB RID: 75515
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache236;

	// Token: 0x040126FC RID: 75516
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache237;

	// Token: 0x040126FD RID: 75517
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache238;

	// Token: 0x040126FE RID: 75518
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache239;

	// Token: 0x040126FF RID: 75519
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache23A;

	// Token: 0x04012700 RID: 75520
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache23B;

	// Token: 0x04012701 RID: 75521
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache23C;

	// Token: 0x04012702 RID: 75522
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache23D;

	// Token: 0x04012703 RID: 75523
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache23E;

	// Token: 0x04012704 RID: 75524
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache23F;

	// Token: 0x04012705 RID: 75525
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache240;

	// Token: 0x04012706 RID: 75526
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache241;

	// Token: 0x04012707 RID: 75527
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache242;

	// Token: 0x04012708 RID: 75528
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache243;

	// Token: 0x04012709 RID: 75529
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache244;

	// Token: 0x0401270A RID: 75530
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache245;

	// Token: 0x0401270B RID: 75531
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache246;
}
