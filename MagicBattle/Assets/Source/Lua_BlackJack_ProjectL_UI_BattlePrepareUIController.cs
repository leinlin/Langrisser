using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using BlackJack.BJFramework.Runtime.Prefab;
using BlackJack.BJFramework.Runtime.UI;
using BlackJack.ConfigData;
using BlackJack.ProjectL.Common;
using BlackJack.ProjectL.Scene;
using BlackJack.ProjectL.UI;
using SLua;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.Scripting;
using UnityEngine.UI;

// Token: 0x020013AF RID: 5039
[Preserve]
public class Lua_BlackJack_ProjectL_UI_BattlePrepareUIController : LuaObject
{
	// Token: 0x0601BC2C RID: 113708 RVA: 0x0087B2A8 File Offset: 0x008794A8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int Initialize(IntPtr l)
	{
		int result;
		try
		{
			BattlePrepareUIController battlePrepareUIController = (BattlePrepareUIController)LuaObject.checkSelf(l);
			ClientBattle clientBattle;
			LuaObject.checkType<ClientBattle>(l, 2, out clientBattle);
			battlePrepareUIController.Initialize(clientBattle);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601BC2D RID: 113709 RVA: 0x0087B300 File Offset: 0x00879500
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int CheckStageActorChange(IntPtr l)
	{
		int result;
		try
		{
			BattlePrepareUIController battlePrepareUIController = (BattlePrepareUIController)LuaObject.checkSelf(l);
			battlePrepareUIController.CheckStageActorChange();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601BC2E RID: 113710 RVA: 0x0087B34C File Offset: 0x0087954C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int PrepareBattle(IntPtr l)
	{
		int result;
		try
		{
			BattlePrepareUIController battlePrepareUIController = (BattlePrepareUIController)LuaObject.checkSelf(l);
			battlePrepareUIController.PrepareBattle();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601BC2F RID: 113711 RVA: 0x0087B398 File Offset: 0x00879598
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int Pause(IntPtr l)
	{
		int result;
		try
		{
			BattlePrepareUIController battlePrepareUIController = (BattlePrepareUIController)LuaObject.checkSelf(l);
			bool pause;
			LuaObject.checkType(l, 2, out pause);
			battlePrepareUIController.Pause(pause);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601BC30 RID: 113712 RVA: 0x0087B3F0 File Offset: 0x008795F0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int SetStageActorCountMax(IntPtr l)
	{
		int result;
		try
		{
			BattlePrepareUIController battlePrepareUIController = (BattlePrepareUIController)LuaObject.checkSelf(l);
			int stageActorCountMax;
			LuaObject.checkType(l, 2, out stageActorCountMax);
			battlePrepareUIController.SetStageActorCountMax(stageActorCountMax);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601BC31 RID: 113713 RVA: 0x0087B448 File Offset: 0x00879648
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int SetTurnStageActorCountMax(IntPtr l)
	{
		int result;
		try
		{
			BattlePrepareUIController battlePrepareUIController = (BattlePrepareUIController)LuaObject.checkSelf(l);
			int turnStageActorCountMax;
			LuaObject.checkType(l, 2, out turnStageActorCountMax);
			battlePrepareUIController.SetTurnStageActorCountMax(turnStageActorCountMax);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601BC32 RID: 113714 RVA: 0x0087B4A0 File Offset: 0x008796A0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int ClearHeros(IntPtr l)
	{
		int result;
		try
		{
			BattlePrepareUIController battlePrepareUIController = (BattlePrepareUIController)LuaObject.checkSelf(l);
			battlePrepareUIController.ClearHeros();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601BC33 RID: 113715 RVA: 0x0087B4EC File Offset: 0x008796EC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int AddHero(IntPtr l)
	{
		int result;
		try
		{
			BattlePrepareUIController battlePrepareUIController = (BattlePrepareUIController)LuaObject.checkSelf(l);
			BattleHero hero;
			LuaObject.checkType<BattleHero>(l, 2, out hero);
			StageActorTagType tagType;
			LuaObject.checkEnum<StageActorTagType>(l, 3, out tagType);
			battlePrepareUIController.AddHero(hero, tagType);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601BC34 RID: 113716 RVA: 0x0087B550 File Offset: 0x00879750
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int ClearStagePositions(IntPtr l)
	{
		int result;
		try
		{
			BattlePrepareUIController battlePrepareUIController = (BattlePrepareUIController)LuaObject.checkSelf(l);
			battlePrepareUIController.ClearStagePositions();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601BC35 RID: 113717 RVA: 0x0087B59C File Offset: 0x0087979C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int AddStagePosition(IntPtr l)
	{
		int result;
		try
		{
			BattlePrepareUIController battlePrepareUIController = (BattlePrepareUIController)LuaObject.checkSelf(l);
			GridPosition p;
			LuaObject.checkValueType<GridPosition>(l, 2, out p);
			int dir;
			LuaObject.checkType(l, 3, out dir);
			StagePositionType posType;
			LuaObject.checkEnum<StagePositionType>(l, 4, out posType);
			battlePrepareUIController.AddStagePosition(p, dir, posType);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601BC36 RID: 113718 RVA: 0x0087B610 File Offset: 0x00879810
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int GetStagePositions(IntPtr l)
	{
		int result;
		try
		{
			BattlePrepareUIController battlePrepareUIController = (BattlePrepareUIController)LuaObject.checkSelf(l);
			StagePositionType posType;
			LuaObject.checkEnum<StagePositionType>(l, 2, out posType);
			List<GridPosition> stagePositions = battlePrepareUIController.GetStagePositions(posType);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, stagePositions);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601BC37 RID: 113719 RVA: 0x0087B674 File Offset: 0x00879874
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int SkipStageActorGraphic(IntPtr l)
	{
		int result;
		try
		{
			BattlePrepareUIController battlePrepareUIController = (BattlePrepareUIController)LuaObject.checkSelf(l);
			bool skip;
			LuaObject.checkType(l, 2, out skip);
			battlePrepareUIController.SkipStageActorGraphic(skip);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601BC38 RID: 113720 RVA: 0x0087B6CC File Offset: 0x008798CC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int EnableHeroOnStage(IntPtr l)
	{
		int result;
		try
		{
			BattlePrepareUIController battlePrepareUIController = (BattlePrepareUIController)LuaObject.checkSelf(l);
			bool enable;
			LuaObject.checkType(l, 2, out enable);
			battlePrepareUIController.EnableHeroOnStage(enable);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601BC39 RID: 113721 RVA: 0x0087B724 File Offset: 0x00879924
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int HeroOnStage(IntPtr l)
	{
		int result;
		try
		{
			int num = LuaDLL.lua_gettop(l);
			if (num == 7)
			{
				BattlePrepareUIController battlePrepareUIController = (BattlePrepareUIController)LuaObject.checkSelf(l);
				BattleHero hero;
				LuaObject.checkType<BattleHero>(l, 2, out hero);
				GridPosition pos;
				LuaObject.checkValueType<GridPosition>(l, 3, out pos);
				int team;
				LuaObject.checkType(l, 4, out team);
				StagePositionType posType;
				LuaObject.checkEnum<StagePositionType>(l, 5, out posType);
				int playerIndex;
				LuaObject.checkType(l, 6, out playerIndex);
				StageActorTagType tagType;
				LuaObject.checkEnum<StageActorTagType>(l, 7, out tagType);
				BattlePrepareStageActor o = battlePrepareUIController.HeroOnStage(hero, pos, team, posType, playerIndex, tagType);
				LuaObject.pushValue(l, true);
				LuaObject.pushValue(l, o);
				result = 2;
			}
			else if (num == 10)
			{
				BattlePrepareUIController battlePrepareUIController2 = (BattlePrepareUIController)LuaObject.checkSelf(l);
				BattleHero hero2;
				LuaObject.checkType<BattleHero>(l, 2, out hero2);
				GridPosition pos2;
				LuaObject.checkValueType<GridPosition>(l, 3, out pos2);
				int dir;
				LuaObject.checkType(l, 4, out dir);
				int team2;
				LuaObject.checkType(l, 5, out team2);
				StagePositionType posType2;
				LuaObject.checkEnum<StagePositionType>(l, 6, out posType2);
				StageActorTagType tagType2;
				LuaObject.checkEnum<StageActorTagType>(l, 7, out tagType2);
				int behaviorId;
				LuaObject.checkType(l, 8, out behaviorId);
				int groupId;
				LuaObject.checkType(l, 9, out groupId);
				int playerIndex2;
				LuaObject.checkType(l, 10, out playerIndex2);
				BattlePrepareStageActor o2 = battlePrepareUIController2.HeroOnStage(hero2, pos2, dir, team2, posType2, tagType2, behaviorId, groupId, playerIndex2);
				LuaObject.pushValue(l, true);
				LuaObject.pushValue(l, o2);
				result = 2;
			}
			else
			{
				LuaObject.pushValue(l, false);
				LuaDLL.lua_pushstring(l, "No matched override function HeroOnStage to call");
				result = 2;
			}
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601BC3A RID: 113722 RVA: 0x0087B89C File Offset: 0x00879A9C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int ActorOffStage(IntPtr l)
	{
		int result;
		try
		{
			BattlePrepareUIController battlePrepareUIController = (BattlePrepareUIController)LuaObject.checkSelf(l);
			BattlePrepareStageActor sa;
			LuaObject.checkType<BattlePrepareStageActor>(l, 2, out sa);
			battlePrepareUIController.ActorOffStage(sa);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601BC3B RID: 113723 RVA: 0x0087B8F4 File Offset: 0x00879AF4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int ActorOnStageMove(IntPtr l)
	{
		int result;
		try
		{
			BattlePrepareUIController battlePrepareUIController = (BattlePrepareUIController)LuaObject.checkSelf(l);
			BattlePrepareStageActor sa;
			LuaObject.checkType<BattlePrepareStageActor>(l, 2, out sa);
			GridPosition p;
			LuaObject.checkValueType<GridPosition>(l, 3, out p);
			battlePrepareUIController.ActorOnStageMove(sa, p);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601BC3C RID: 113724 RVA: 0x0087B958 File Offset: 0x00879B58
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int ActorOnStageExchange(IntPtr l)
	{
		int result;
		try
		{
			BattlePrepareUIController battlePrepareUIController = (BattlePrepareUIController)LuaObject.checkSelf(l);
			BattlePrepareStageActor sa;
			LuaObject.checkType<BattlePrepareStageActor>(l, 2, out sa);
			BattlePrepareStageActor sa2;
			LuaObject.checkType<BattlePrepareStageActor>(l, 3, out sa2);
			battlePrepareUIController.ActorOnStageExchange(sa, sa2);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601BC3D RID: 113725 RVA: 0x0087B9BC File Offset: 0x00879BBC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int ClearStageActors(IntPtr l)
	{
		int result;
		try
		{
			BattlePrepareUIController battlePrepareUIController = (BattlePrepareUIController)LuaObject.checkSelf(l);
			battlePrepareUIController.ClearStageActors();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601BC3E RID: 113726 RVA: 0x0087BA08 File Offset: 0x00879C08
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int GetStageActor(IntPtr l)
	{
		int result;
		try
		{
			BattlePrepareUIController battlePrepareUIController = (BattlePrepareUIController)LuaObject.checkSelf(l);
			GridPosition p;
			LuaObject.checkValueType<GridPosition>(l, 2, out p);
			BattlePrepareStageActor stageActor = battlePrepareUIController.GetStageActor(p);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, stageActor);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601BC3F RID: 113727 RVA: 0x0087BA6C File Offset: 0x00879C6C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int GetStageActorByHeroId(IntPtr l)
	{
		int result;
		try
		{
			BattlePrepareUIController battlePrepareUIController = (BattlePrepareUIController)LuaObject.checkSelf(l);
			int heroId;
			LuaObject.checkType(l, 2, out heroId);
			BattlePrepareStageActor stageActorByHeroId = battlePrepareUIController.GetStageActorByHeroId(heroId);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, stageActorByHeroId);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601BC40 RID: 113728 RVA: 0x0087BAD0 File Offset: 0x00879CD0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int GetStageActors(IntPtr l)
	{
		int result;
		try
		{
			BattlePrepareUIController battlePrepareUIController = (BattlePrepareUIController)LuaObject.checkSelf(l);
			List<BattlePrepareStageActor> stageActors = battlePrepareUIController.GetStageActors();
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, stageActors);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601BC41 RID: 113729 RVA: 0x0087BB24 File Offset: 0x00879D24
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int UpdateStageActor(IntPtr l)
	{
		int result;
		try
		{
			BattlePrepareUIController battlePrepareUIController = (BattlePrepareUIController)LuaObject.checkSelf(l);
			BattleHero hero;
			LuaObject.checkType<BattleHero>(l, 2, out hero);
			battlePrepareUIController.UpdateStageActor(hero);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601BC42 RID: 113730 RVA: 0x0087BB7C File Offset: 0x00879D7C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int AddBattleTreasure(IntPtr l)
	{
		int result;
		try
		{
			BattlePrepareUIController battlePrepareUIController = (BattlePrepareUIController)LuaObject.checkSelf(l);
			ConfigDataBattleTreasureInfo treasureInfo;
			LuaObject.checkType<ConfigDataBattleTreasureInfo>(l, 2, out treasureInfo);
			bool isOpened;
			LuaObject.checkType(l, 3, out isOpened);
			battlePrepareUIController.AddBattleTreasure(treasureInfo, isOpened);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601BC43 RID: 113731 RVA: 0x0087BBE0 File Offset: 0x00879DE0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int ClearBattleTreasures(IntPtr l)
	{
		int result;
		try
		{
			BattlePrepareUIController battlePrepareUIController = (BattlePrepareUIController)LuaObject.checkSelf(l);
			battlePrepareUIController.ClearBattleTreasures();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601BC44 RID: 113732 RVA: 0x0087BC2C File Offset: 0x00879E2C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int ShowTerrainInfo(IntPtr l)
	{
		int result;
		try
		{
			BattlePrepareUIController battlePrepareUIController = (BattlePrepareUIController)LuaObject.checkSelf(l);
			ConfigDataTerrainInfo terrain;
			LuaObject.checkType<ConfigDataTerrainInfo>(l, 2, out terrain);
			battlePrepareUIController.ShowTerrainInfo(terrain);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601BC45 RID: 113733 RVA: 0x0087BC84 File Offset: 0x00879E84
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int HideTerrainInfo(IntPtr l)
	{
		int result;
		try
		{
			BattlePrepareUIController battlePrepareUIController = (BattlePrepareUIController)LuaObject.checkSelf(l);
			battlePrepareUIController.HideTerrainInfo();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601BC46 RID: 113734 RVA: 0x0087BCD0 File Offset: 0x00879ED0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int ShowArmyRelationDesc(IntPtr l)
	{
		int result;
		try
		{
			BattlePrepareUIController battlePrepareUIController = (BattlePrepareUIController)LuaObject.checkSelf(l);
			battlePrepareUIController.ShowArmyRelationDesc();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601BC47 RID: 113735 RVA: 0x0087BD1C File Offset: 0x00879F1C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int HideArmyRelationDesc(IntPtr l)
	{
		int result;
		try
		{
			BattlePrepareUIController battlePrepareUIController = (BattlePrepareUIController)LuaObject.checkSelf(l);
			battlePrepareUIController.HideArmyRelationDesc();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601BC48 RID: 113736 RVA: 0x0087BD68 File Offset: 0x00879F68
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int IsArmyRelationDescVisible(IntPtr l)
	{
		int result;
		try
		{
			BattlePrepareUIController battlePrepareUIController = (BattlePrepareUIController)LuaObject.checkSelf(l);
			bool b = battlePrepareUIController.IsArmyRelationDescVisible();
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

	// Token: 0x0601BC49 RID: 113737 RVA: 0x0087BDBC File Offset: 0x00879FBC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int ShowClimbTowerBattleRule(IntPtr l)
	{
		int result;
		try
		{
			BattlePrepareUIController battlePrepareUIController = (BattlePrepareUIController)LuaObject.checkSelf(l);
			ConfigDataTowerBattleRuleInfo ruleInfo;
			LuaObject.checkType<ConfigDataTowerBattleRuleInfo>(l, 2, out ruleInfo);
			battlePrepareUIController.ShowClimbTowerBattleRule(ruleInfo);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601BC4A RID: 113738 RVA: 0x0087BE14 File Offset: 0x0087A014
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int HideClimbTowerBattleRule(IntPtr l)
	{
		int result;
		try
		{
			BattlePrepareUIController battlePrepareUIController = (BattlePrepareUIController)LuaObject.checkSelf(l);
			battlePrepareUIController.HideClimbTowerBattleRule();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601BC4B RID: 113739 RVA: 0x0087BE60 File Offset: 0x0087A060
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int ShowActionOrderButton(IntPtr l)
	{
		int result;
		try
		{
			BattlePrepareUIController battlePrepareUIController = (BattlePrepareUIController)LuaObject.checkSelf(l);
			bool show;
			LuaObject.checkType(l, 2, out show);
			battlePrepareUIController.ShowActionOrderButton(show);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601BC4C RID: 113740 RVA: 0x0087BEB8 File Offset: 0x0087A0B8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int ShowChatButton(IntPtr l)
	{
		int result;
		try
		{
			BattlePrepareUIController battlePrepareUIController = (BattlePrepareUIController)LuaObject.checkSelf(l);
			bool show;
			LuaObject.checkType(l, 2, out show);
			battlePrepareUIController.ShowChatButton(show);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601BC4D RID: 113741 RVA: 0x0087BF10 File Offset: 0x0087A110
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int SetBattlePower(IntPtr l)
	{
		int result;
		try
		{
			BattlePrepareUIController battlePrepareUIController = (BattlePrepareUIController)LuaObject.checkSelf(l);
			int battlePower;
			LuaObject.checkType(l, 2, out battlePower);
			battlePrepareUIController.SetBattlePower(battlePower);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601BC4E RID: 113742 RVA: 0x0087BF68 File Offset: 0x0087A168
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int ShowStartButton(IntPtr l)
	{
		int result;
		try
		{
			BattlePrepareUIController battlePrepareUIController = (BattlePrepareUIController)LuaObject.checkSelf(l);
			bool show;
			LuaObject.checkType(l, 2, out show);
			battlePrepareUIController.ShowStartButton(show);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601BC4F RID: 113743 RVA: 0x0087BFC0 File Offset: 0x0087A1C0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int ShowTeamReadyCountdown(IntPtr l)
	{
		int result;
		try
		{
			BattlePrepareUIController battlePrepareUIController = (BattlePrepareUIController)LuaObject.checkSelf(l);
			TimeSpan ts;
			LuaObject.checkValueType<TimeSpan>(l, 2, out ts);
			battlePrepareUIController.ShowTeamReadyCountdown(ts);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601BC50 RID: 113744 RVA: 0x0087C018 File Offset: 0x0087A218
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int ShowTeamReadyWait(IntPtr l)
	{
		int result;
		try
		{
			BattlePrepareUIController battlePrepareUIController = (BattlePrepareUIController)LuaObject.checkSelf(l);
			BattleRoomType battleRoomType;
			LuaObject.checkEnum<BattleRoomType>(l, 2, out battleRoomType);
			battlePrepareUIController.ShowTeamReadyWait(battleRoomType);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601BC51 RID: 113745 RVA: 0x0087C070 File Offset: 0x0087A270
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int IsTestBattle(IntPtr l)
	{
		int result;
		try
		{
			BattlePrepareUIController battlePrepareUIController = (BattlePrepareUIController)LuaObject.checkSelf(l);
			bool b = battlePrepareUIController.IsTestBattle();
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

	// Token: 0x0601BC52 RID: 113746 RVA: 0x0087C0C4 File Offset: 0x0087A2C4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int IsTestOnStage(IntPtr l)
	{
		int result;
		try
		{
			BattlePrepareUIController battlePrepareUIController = (BattlePrepareUIController)LuaObject.checkSelf(l);
			bool b = battlePrepareUIController.IsTestOnStage();
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

	// Token: 0x0601BC53 RID: 113747 RVA: 0x0087C118 File Offset: 0x0087A318
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int GetTestSoldierCount(IntPtr l)
	{
		int result;
		try
		{
			BattlePrepareUIController battlePrepareUIController = (BattlePrepareUIController)LuaObject.checkSelf(l);
			int team;
			LuaObject.checkType(l, 2, out team);
			int testSoldierCount = battlePrepareUIController.GetTestSoldierCount(team);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, testSoldierCount);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601BC54 RID: 113748 RVA: 0x0087C17C File Offset: 0x0087A37C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int GetTestSkillId(IntPtr l)
	{
		int result;
		try
		{
			BattlePrepareUIController battlePrepareUIController = (BattlePrepareUIController)LuaObject.checkSelf(l);
			int team;
			LuaObject.checkType(l, 2, out team);
			int testSkillId = battlePrepareUIController.GetTestSkillId(team);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, testSkillId);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601BC55 RID: 113749 RVA: 0x0087C1E0 File Offset: 0x0087A3E0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int GetTestTalentId(IntPtr l)
	{
		int result;
		try
		{
			BattlePrepareUIController battlePrepareUIController = (BattlePrepareUIController)LuaObject.checkSelf(l);
			int team;
			LuaObject.checkType(l, 2, out team);
			int testTalentId = battlePrepareUIController.GetTestTalentId(team);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, testTalentId);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601BC56 RID: 113750 RVA: 0x0087C244 File Offset: 0x0087A444
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int OnScenePointerDown(IntPtr l)
	{
		int result;
		try
		{
			BattlePrepareUIController battlePrepareUIController = (BattlePrepareUIController)LuaObject.checkSelf(l);
			PointerEventData eventData;
			LuaObject.checkType<PointerEventData>(l, 2, out eventData);
			battlePrepareUIController.OnScenePointerDown(eventData);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601BC57 RID: 113751 RVA: 0x0087C29C File Offset: 0x0087A49C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int OnScenePointerUp(IntPtr l)
	{
		int result;
		try
		{
			BattlePrepareUIController battlePrepareUIController = (BattlePrepareUIController)LuaObject.checkSelf(l);
			PointerEventData eventData;
			LuaObject.checkType<PointerEventData>(l, 2, out eventData);
			battlePrepareUIController.OnScenePointerUp(eventData);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601BC58 RID: 113752 RVA: 0x0087C2F4 File Offset: 0x0087A4F4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int OnScenePointerClick(IntPtr l)
	{
		int result;
		try
		{
			BattlePrepareUIController battlePrepareUIController = (BattlePrepareUIController)LuaObject.checkSelf(l);
			PointerEventData eventData;
			LuaObject.checkType<PointerEventData>(l, 2, out eventData);
			battlePrepareUIController.OnScenePointerClick(eventData);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601BC59 RID: 113753 RVA: 0x0087C34C File Offset: 0x0087A54C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int OnSceneBeginDrag(IntPtr l)
	{
		int result;
		try
		{
			BattlePrepareUIController battlePrepareUIController = (BattlePrepareUIController)LuaObject.checkSelf(l);
			PointerEventData eventData;
			LuaObject.checkType<PointerEventData>(l, 2, out eventData);
			battlePrepareUIController.OnSceneBeginDrag(eventData);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601BC5A RID: 113754 RVA: 0x0087C3A4 File Offset: 0x0087A5A4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int OnSceneEndDrag(IntPtr l)
	{
		int result;
		try
		{
			BattlePrepareUIController battlePrepareUIController = (BattlePrepareUIController)LuaObject.checkSelf(l);
			PointerEventData eventData;
			LuaObject.checkType<PointerEventData>(l, 2, out eventData);
			battlePrepareUIController.OnSceneEndDrag(eventData);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601BC5B RID: 113755 RVA: 0x0087C3FC File Offset: 0x0087A5FC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int OnSceneDrag(IntPtr l)
	{
		int result;
		try
		{
			BattlePrepareUIController battlePrepareUIController = (BattlePrepareUIController)LuaObject.checkSelf(l);
			PointerEventData eventData;
			LuaObject.checkType<PointerEventData>(l, 2, out eventData);
			battlePrepareUIController.OnSceneDrag(eventData);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601BC5C RID: 113756 RVA: 0x0087C454 File Offset: 0x0087A654
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int OnScene3DTouch(IntPtr l)
	{
		int result;
		try
		{
			BattlePrepareUIController battlePrepareUIController = (BattlePrepareUIController)LuaObject.checkSelf(l);
			Vector2 p;
			LuaObject.checkType(l, 2, out p);
			battlePrepareUIController.OnScene3DTouch(p);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601BC5D RID: 113757 RVA: 0x0087C4AC File Offset: 0x0087A6AC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int DropHeroButton(IntPtr l)
	{
		int result;
		try
		{
			BattlePrepareUIController battlePrepareUIController = (BattlePrepareUIController)LuaObject.checkSelf(l);
			Vector2 pos;
			LuaObject.checkType(l, 2, out pos);
			battlePrepareUIController.DropHeroButton(pos);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601BC5E RID: 113758 RVA: 0x0087C504 File Offset: 0x0087A704
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int ComputeStageActorCount(IntPtr l)
	{
		int result;
		try
		{
			BattlePrepareUIController battlePrepareUIController = (BattlePrepareUIController)LuaObject.checkSelf(l);
			int i = battlePrepareUIController.ComputeStageActorCount();
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

	// Token: 0x0601BC5F RID: 113759 RVA: 0x0087C558 File Offset: 0x0087A758
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int HeroDragButton_OnBeginDrag(IntPtr l)
	{
		int result;
		try
		{
			BattlePrepareUIController battlePrepareUIController = (BattlePrepareUIController)LuaObject.checkSelf(l);
			HeroDragButton b;
			LuaObject.checkType<HeroDragButton>(l, 2, out b);
			PointerEventData eventData;
			LuaObject.checkType<PointerEventData>(l, 3, out eventData);
			battlePrepareUIController.HeroDragButton_OnBeginDrag(b, eventData);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601BC60 RID: 113760 RVA: 0x0087C5BC File Offset: 0x0087A7BC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int HeroDragButton_OnEndDrag(IntPtr l)
	{
		int result;
		try
		{
			BattlePrepareUIController battlePrepareUIController = (BattlePrepareUIController)LuaObject.checkSelf(l);
			HeroDragButton b;
			LuaObject.checkType<HeroDragButton>(l, 2, out b);
			PointerEventData eventData;
			LuaObject.checkType<PointerEventData>(l, 3, out eventData);
			battlePrepareUIController.HeroDragButton_OnEndDrag(b, eventData);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601BC61 RID: 113761 RVA: 0x0087C620 File Offset: 0x0087A820
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int HeroDragButton_OnDrag(IntPtr l)
	{
		int result;
		try
		{
			BattlePrepareUIController battlePrepareUIController = (BattlePrepareUIController)LuaObject.checkSelf(l);
			PointerEventData eventData;
			LuaObject.checkType<PointerEventData>(l, 2, out eventData);
			battlePrepareUIController.HeroDragButton_OnDrag(eventData);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601BC62 RID: 113762 RVA: 0x0087C678 File Offset: 0x0087A878
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int HeroDragButton_OnDrop(IntPtr l)
	{
		int result;
		try
		{
			BattlePrepareUIController battlePrepareUIController = (BattlePrepareUIController)LuaObject.checkSelf(l);
			PointerEventData eventData;
			LuaObject.checkType<PointerEventData>(l, 2, out eventData);
			battlePrepareUIController.HeroDragButton_OnDrop(eventData);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601BC63 RID: 113763 RVA: 0x0087C6D0 File Offset: 0x0087A8D0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int HeroDragButton_OnClick(IntPtr l)
	{
		int result;
		try
		{
			BattlePrepareUIController battlePrepareUIController = (BattlePrepareUIController)LuaObject.checkSelf(l);
			HeroDragButton b;
			LuaObject.checkType<HeroDragButton>(l, 2, out b);
			battlePrepareUIController.HeroDragButton_OnClick(b);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601BC64 RID: 113764 RVA: 0x0087C728 File Offset: 0x0087A928
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int RefreshChatRedState(IntPtr l)
	{
		int result;
		try
		{
			BattlePrepareUIController battlePrepareUIController = (BattlePrepareUIController)LuaObject.checkSelf(l);
			battlePrepareUIController.RefreshChatRedState();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601BC65 RID: 113765 RVA: 0x0087C774 File Offset: 0x0087A974
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int OnBindFiledsCompleted(IntPtr l)
	{
		int result;
		try
		{
			BattlePrepareUIController battlePrepareUIController = (BattlePrepareUIController)LuaObject.checkSelf(l);
			battlePrepareUIController.m_luaExportHelper.OnBindFiledsCompleted();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601BC66 RID: 113766 RVA: 0x0087C7C8 File Offset: 0x0087A9C8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int OnDisable(IntPtr l)
	{
		int result;
		try
		{
			BattlePrepareUIController battlePrepareUIController = (BattlePrepareUIController)LuaObject.checkSelf(l);
			battlePrepareUIController.m_luaExportHelper.OnDisable();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601BC67 RID: 113767 RVA: 0x0087C81C File Offset: 0x0087AA1C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int OnApplicationPause(IntPtr l)
	{
		int result;
		try
		{
			BattlePrepareUIController battlePrepareUIController = (BattlePrepareUIController)LuaObject.checkSelf(l);
			bool isPause;
			LuaObject.checkType(l, 2, out isPause);
			battlePrepareUIController.m_luaExportHelper.OnApplicationPause(isPause);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601BC68 RID: 113768 RVA: 0x0087C878 File Offset: 0x0087AA78
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int OnApplicationFocus(IntPtr l)
	{
		int result;
		try
		{
			BattlePrepareUIController battlePrepareUIController = (BattlePrepareUIController)LuaObject.checkSelf(l);
			bool focus;
			LuaObject.checkType(l, 2, out focus);
			battlePrepareUIController.m_luaExportHelper.OnApplicationFocus(focus);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601BC69 RID: 113769 RVA: 0x0087C8D4 File Offset: 0x0087AAD4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int CancelDragging(IntPtr l)
	{
		int result;
		try
		{
			BattlePrepareUIController battlePrepareUIController = (BattlePrepareUIController)LuaObject.checkSelf(l);
			battlePrepareUIController.m_luaExportHelper.CancelDragging();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601BC6A RID: 113770 RVA: 0x0087C928 File Offset: 0x0087AB28
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int Update(IntPtr l)
	{
		int result;
		try
		{
			BattlePrepareUIController battlePrepareUIController = (BattlePrepareUIController)LuaObject.checkSelf(l);
			battlePrepareUIController.m_luaExportHelper.Update();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601BC6B RID: 113771 RVA: 0x0087C97C File Offset: 0x0087AB7C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int GetStageDirection(IntPtr l)
	{
		int result;
		try
		{
			BattlePrepareUIController battlePrepareUIController = (BattlePrepareUIController)LuaObject.checkSelf(l);
			GridPosition p;
			LuaObject.checkValueType<GridPosition>(l, 2, out p);
			StagePositionType posType;
			LuaObject.checkEnum<StagePositionType>(l, 3, out posType);
			int stageDirection = battlePrepareUIController.m_luaExportHelper.GetStageDirection(p, posType);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, stageDirection);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601BC6C RID: 113772 RVA: 0x0087C9F0 File Offset: 0x0087ABF0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int CreateHeroButton(IntPtr l)
	{
		int result;
		try
		{
			BattlePrepareUIController battlePrepareUIController = (BattlePrepareUIController)LuaObject.checkSelf(l);
			BattleHero hero;
			LuaObject.checkType<BattleHero>(l, 2, out hero);
			Transform parent;
			LuaObject.checkType<Transform>(l, 3, out parent);
			HeroDragButton o = battlePrepareUIController.m_luaExportHelper.CreateHeroButton(hero, parent);
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

	// Token: 0x0601BC6D RID: 113773 RVA: 0x0087CA64 File Offset: 0x0087AC64
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int SortChildByY(IntPtr l)
	{
		int result;
		try
		{
			BattlePrepareUIController battlePrepareUIController = (BattlePrepareUIController)LuaObject.checkSelf(l);
			Transform parent;
			LuaObject.checkType<Transform>(l, 2, out parent);
			battlePrepareUIController.m_luaExportHelper.SortChildByY(parent);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601BC6E RID: 113774 RVA: 0x0087CAC0 File Offset: 0x0087ACC0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int ClearBattlePowerValue(IntPtr l)
	{
		int result;
		try
		{
			BattlePrepareUIController battlePrepareUIController = (BattlePrepareUIController)LuaObject.checkSelf(l);
			battlePrepareUIController.m_luaExportHelper.ClearBattlePowerValue();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601BC6F RID: 113775 RVA: 0x0087CB14 File Offset: 0x0087AD14
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int Co_SetBattlePowerValue(IntPtr l)
	{
		int result;
		try
		{
			BattlePrepareUIController battlePrepareUIController = (BattlePrepareUIController)LuaObject.checkSelf(l);
			int newValue;
			LuaObject.checkType(l, 2, out newValue);
			int oldValue;
			LuaObject.checkType(l, 3, out oldValue);
			IEnumerator o = battlePrepareUIController.m_luaExportHelper.Co_SetBattlePowerValue(newValue, oldValue);
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

	// Token: 0x0601BC70 RID: 113776 RVA: 0x0087CB88 File Offset: 0x0087AD88
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int UpdateTestValuesToInputField(IntPtr l)
	{
		int result;
		try
		{
			BattlePrepareUIController battlePrepareUIController = (BattlePrepareUIController)LuaObject.checkSelf(l);
			battlePrepareUIController.m_luaExportHelper.UpdateTestValuesToInputField();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601BC71 RID: 113777 RVA: 0x0087CBDC File Offset: 0x0087ADDC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int UpdateTestValuesFromInputField(IntPtr l)
	{
		int result;
		try
		{
			BattlePrepareUIController battlePrepareUIController = (BattlePrepareUIController)LuaObject.checkSelf(l);
			battlePrepareUIController.m_luaExportHelper.UpdateTestValuesFromInputField();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601BC72 RID: 113778 RVA: 0x0087CC30 File Offset: 0x0087AE30
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int HideTeamReadyCountdown(IntPtr l)
	{
		int result;
		try
		{
			BattlePrepareUIController battlePrepareUIController = (BattlePrepareUIController)LuaObject.checkSelf(l);
			battlePrepareUIController.m_luaExportHelper.HideTeamReadyCountdown();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601BC73 RID: 113779 RVA: 0x0087CC84 File Offset: 0x0087AE84
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int HideTeamReadyWait(IntPtr l)
	{
		int result;
		try
		{
			BattlePrepareUIController battlePrepareUIController = (BattlePrepareUIController)LuaObject.checkSelf(l);
			battlePrepareUIController.m_luaExportHelper.HideTeamReadyWait();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601BC74 RID: 113780 RVA: 0x0087CCD8 File Offset: 0x0087AED8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int OnPauseButtonClick(IntPtr l)
	{
		int result;
		try
		{
			BattlePrepareUIController battlePrepareUIController = (BattlePrepareUIController)LuaObject.checkSelf(l);
			battlePrepareUIController.m_luaExportHelper.OnPauseButtonClick();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601BC75 RID: 113781 RVA: 0x0087CD2C File Offset: 0x0087AF2C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int OnArmyRelationButtonClick(IntPtr l)
	{
		int result;
		try
		{
			BattlePrepareUIController battlePrepareUIController = (BattlePrepareUIController)LuaObject.checkSelf(l);
			battlePrepareUIController.m_luaExportHelper.OnArmyRelationButtonClick();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601BC76 RID: 113782 RVA: 0x0087CD80 File Offset: 0x0087AF80
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int OnStartButtonClick(IntPtr l)
	{
		int result;
		try
		{
			BattlePrepareUIController battlePrepareUIController = (BattlePrepareUIController)LuaObject.checkSelf(l);
			battlePrepareUIController.m_luaExportHelper.OnStartButtonClick();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601BC77 RID: 113783 RVA: 0x0087CDD4 File Offset: 0x0087AFD4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int OnActionOrderButtonClick(IntPtr l)
	{
		int result;
		try
		{
			BattlePrepareUIController battlePrepareUIController = (BattlePrepareUIController)LuaObject.checkSelf(l);
			battlePrepareUIController.m_luaExportHelper.OnActionOrderButtonClick();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601BC78 RID: 113784 RVA: 0x0087CE28 File Offset: 0x0087B028
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int OnChatButtonClick(IntPtr l)
	{
		int result;
		try
		{
			BattlePrepareUIController battlePrepareUIController = (BattlePrepareUIController)LuaObject.checkSelf(l);
			battlePrepareUIController.m_luaExportHelper.OnChatButtonClick();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601BC79 RID: 113785 RVA: 0x0087CE7C File Offset: 0x0087B07C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int OnHelpButtonClick(IntPtr l)
	{
		int result;
		try
		{
			BattlePrepareUIController battlePrepareUIController = (BattlePrepareUIController)LuaObject.checkSelf(l);
			battlePrepareUIController.m_luaExportHelper.OnHelpButtonClick();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601BC7A RID: 113786 RVA: 0x0087CED0 File Offset: 0x0087B0D0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int OnTestOnStageToggle(IntPtr l)
	{
		int result;
		try
		{
			BattlePrepareUIController battlePrepareUIController = (BattlePrepareUIController)LuaObject.checkSelf(l);
			bool on;
			LuaObject.checkType(l, 2, out on);
			battlePrepareUIController.m_luaExportHelper.OnTestOnStageToggle(on);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601BC7B RID: 113787 RVA: 0x0087CF2C File Offset: 0x0087B12C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int ClearPointerDownStageActor(IntPtr l)
	{
		int result;
		try
		{
			BattlePrepareUIController battlePrepareUIController = (BattlePrepareUIController)LuaObject.checkSelf(l);
			battlePrepareUIController.m_luaExportHelper.ClearPointerDownStageActor();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601BC7C RID: 113788 RVA: 0x0087CF80 File Offset: 0x0087B180
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int CreateDraggingHeroButton(IntPtr l)
	{
		int result;
		try
		{
			BattlePrepareUIController battlePrepareUIController = (BattlePrepareUIController)LuaObject.checkSelf(l);
			BattleHero hero;
			LuaObject.checkType<BattleHero>(l, 2, out hero);
			battlePrepareUIController.m_luaExportHelper.CreateDraggingHeroButton(hero);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601BC7D RID: 113789 RVA: 0x0087CFDC File Offset: 0x0087B1DC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int DestroyDragginHeroButton(IntPtr l)
	{
		int result;
		try
		{
			BattlePrepareUIController battlePrepareUIController = (BattlePrepareUIController)LuaObject.checkSelf(l);
			battlePrepareUIController.m_luaExportHelper.DestroyDragginHeroButton();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601BC7E RID: 113790 RVA: 0x0087D030 File Offset: 0x0087B230
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int MoveDraggingHeroButton(IntPtr l)
	{
		int result;
		try
		{
			BattlePrepareUIController battlePrepareUIController = (BattlePrepareUIController)LuaObject.checkSelf(l);
			Vector2 pos;
			LuaObject.checkType(l, 2, out pos);
			battlePrepareUIController.m_luaExportHelper.MoveDraggingHeroButton(pos);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601BC7F RID: 113791 RVA: 0x0087D08C File Offset: 0x0087B28C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int UpdateStageActorCount(IntPtr l)
	{
		int result;
		try
		{
			BattlePrepareUIController battlePrepareUIController = (BattlePrepareUIController)LuaObject.checkSelf(l);
			battlePrepareUIController.m_luaExportHelper.UpdateStageActorCount();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601BC80 RID: 113792 RVA: 0x0087D0E0 File Offset: 0x0087B2E0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int HideActorInfo(IntPtr l)
	{
		int result;
		try
		{
			BattlePrepareUIController battlePrepareUIController = (BattlePrepareUIController)LuaObject.checkSelf(l);
			battlePrepareUIController.m_luaExportHelper.HideActorInfo();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601BC81 RID: 113793 RVA: 0x0087D134 File Offset: 0x0087B334
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_Initlize(IntPtr l)
	{
		int result;
		try
		{
			BattlePrepareUIController battlePrepareUIController = (BattlePrepareUIController)LuaObject.checkSelf(l);
			string ctrlName;
			LuaObject.checkType(l, 2, out ctrlName);
			bool bindNow;
			LuaObject.checkType(l, 3, out bindNow);
			battlePrepareUIController.m_luaExportHelper.__callBase_Initlize(ctrlName, bindNow);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601BC82 RID: 113794 RVA: 0x0087D1A0 File Offset: 0x0087B3A0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_BindFields(IntPtr l)
	{
		int result;
		try
		{
			BattlePrepareUIController battlePrepareUIController = (BattlePrepareUIController)LuaObject.checkSelf(l);
			battlePrepareUIController.m_luaExportHelper.__callBase_BindFields();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601BC83 RID: 113795 RVA: 0x0087D1F4 File Offset: 0x0087B3F4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_OnBindFiledsCompleted(IntPtr l)
	{
		int result;
		try
		{
			BattlePrepareUIController battlePrepareUIController = (BattlePrepareUIController)LuaObject.checkSelf(l);
			battlePrepareUIController.m_luaExportHelper.__callBase_OnBindFiledsCompleted();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601BC84 RID: 113796 RVA: 0x0087D248 File Offset: 0x0087B448
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_BindFieldImpl(IntPtr l)
	{
		int result;
		try
		{
			BattlePrepareUIController battlePrepareUIController = (BattlePrepareUIController)LuaObject.checkSelf(l);
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
			UnityEngine.Object o = battlePrepareUIController.m_luaExportHelper.__callBase_BindFieldImpl(fieldType, path, initState, fieldName, ctrlName, optional);
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

	// Token: 0x0601BC85 RID: 113797 RVA: 0x0087D2F0 File Offset: 0x0087B4F0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_Clear(IntPtr l)
	{
		int result;
		try
		{
			BattlePrepareUIController battlePrepareUIController = (BattlePrepareUIController)LuaObject.checkSelf(l);
			battlePrepareUIController.m_luaExportHelper.__callBase_Clear();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601BC86 RID: 113798 RVA: 0x0087D344 File Offset: 0x0087B544
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_OnButtonClick(IntPtr l)
	{
		int result;
		try
		{
			BattlePrepareUIController battlePrepareUIController = (BattlePrepareUIController)LuaObject.checkSelf(l);
			Button button;
			LuaObject.checkType<Button>(l, 2, out button);
			string fieldName;
			LuaObject.checkType(l, 3, out fieldName);
			battlePrepareUIController.m_luaExportHelper.__callBase_OnButtonClick(button, fieldName);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601BC87 RID: 113799 RVA: 0x0087D3B0 File Offset: 0x0087B5B0
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
				BattlePrepareUIController battlePrepareUIController = (BattlePrepareUIController)LuaObject.checkSelf(l);
				string[] fieldNames;
				LuaObject.checkArray<string>(l, 2, out fieldNames);
				Action<UIControllerBase> action;
				LuaObject.checkDelegate<Action<UIControllerBase>>(l, 3, out action);
				battlePrepareUIController.m_luaExportHelper.__callBase_SetButtonClickListener(fieldNames, action);
				LuaObject.pushValue(l, true);
				result = 1;
			}
			else if (LuaObject.matchType(l, total, 2, typeof(string), typeof(Action<UIControllerBase>)))
			{
				BattlePrepareUIController battlePrepareUIController2 = (BattlePrepareUIController)LuaObject.checkSelf(l);
				string fieldName;
				LuaObject.checkType(l, 2, out fieldName);
				Action<UIControllerBase> action2;
				LuaObject.checkDelegate<Action<UIControllerBase>>(l, 3, out action2);
				battlePrepareUIController2.m_luaExportHelper.__callBase_SetButtonClickListener(fieldName, action2);
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

	// Token: 0x0601BC88 RID: 113800 RVA: 0x0087D4C0 File Offset: 0x0087B6C0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_SetButtonDoubleClickListener(IntPtr l)
	{
		int result;
		try
		{
			BattlePrepareUIController battlePrepareUIController = (BattlePrepareUIController)LuaObject.checkSelf(l);
			string fieldName;
			LuaObject.checkType(l, 2, out fieldName);
			Action<UIControllerBase> action;
			LuaObject.checkDelegate<Action<UIControllerBase>>(l, 3, out action);
			battlePrepareUIController.m_luaExportHelper.__callBase_SetButtonDoubleClickListener(fieldName, action);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601BC89 RID: 113801 RVA: 0x0087D52C File Offset: 0x0087B72C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_SetButtonLongPressStartListener(IntPtr l)
	{
		int result;
		try
		{
			BattlePrepareUIController battlePrepareUIController = (BattlePrepareUIController)LuaObject.checkSelf(l);
			string fieldName;
			LuaObject.checkType(l, 2, out fieldName);
			Action<UIControllerBase> action;
			LuaObject.checkDelegate<Action<UIControllerBase>>(l, 3, out action);
			battlePrepareUIController.m_luaExportHelper.__callBase_SetButtonLongPressStartListener(fieldName, action);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601BC8A RID: 113802 RVA: 0x0087D598 File Offset: 0x0087B798
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_SetButtonLongPressingListener(IntPtr l)
	{
		int result;
		try
		{
			BattlePrepareUIController battlePrepareUIController = (BattlePrepareUIController)LuaObject.checkSelf(l);
			string fieldName;
			LuaObject.checkType(l, 2, out fieldName);
			Action<UIControllerBase> action;
			LuaObject.checkDelegate<Action<UIControllerBase>>(l, 3, out action);
			battlePrepareUIController.m_luaExportHelper.__callBase_SetButtonLongPressingListener(fieldName, action);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601BC8B RID: 113803 RVA: 0x0087D604 File Offset: 0x0087B804
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_SetButtonLongPressEndListener(IntPtr l)
	{
		int result;
		try
		{
			BattlePrepareUIController battlePrepareUIController = (BattlePrepareUIController)LuaObject.checkSelf(l);
			string fieldName;
			LuaObject.checkType(l, 2, out fieldName);
			Action<UIControllerBase> action;
			LuaObject.checkDelegate<Action<UIControllerBase>>(l, 3, out action);
			battlePrepareUIController.m_luaExportHelper.__callBase_SetButtonLongPressEndListener(fieldName, action);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601BC8C RID: 113804 RVA: 0x0087D670 File Offset: 0x0087B870
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
				BattlePrepareUIController battlePrepareUIController = (BattlePrepareUIController)LuaObject.checkSelf(l);
				string[] fieldNames;
				LuaObject.checkArray<string>(l, 2, out fieldNames);
				Action<UIControllerBase, bool> action;
				LuaObject.checkDelegate<Action<UIControllerBase, bool>>(l, 3, out action);
				battlePrepareUIController.m_luaExportHelper.__callBase_SetToggleValueChangedListener(fieldNames, action);
				LuaObject.pushValue(l, true);
				result = 1;
			}
			else if (LuaObject.matchType(l, total, 2, typeof(string), typeof(Action<UIControllerBase, bool>)))
			{
				BattlePrepareUIController battlePrepareUIController2 = (BattlePrepareUIController)LuaObject.checkSelf(l);
				string fieldName;
				LuaObject.checkType(l, 2, out fieldName);
				Action<UIControllerBase, bool> action2;
				LuaObject.checkDelegate<Action<UIControllerBase, bool>>(l, 3, out action2);
				battlePrepareUIController2.m_luaExportHelper.__callBase_SetToggleValueChangedListener(fieldName, action2);
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

	// Token: 0x0601BC8D RID: 113805 RVA: 0x0087D780 File Offset: 0x0087B980
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_ToString(IntPtr l)
	{
		int result;
		try
		{
			BattlePrepareUIController battlePrepareUIController = (BattlePrepareUIController)LuaObject.checkSelf(l);
			string s = battlePrepareUIController.m_luaExportHelper.__callBase_ToString();
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

	// Token: 0x0601BC8E RID: 113806 RVA: 0x0087D7DC File Offset: 0x0087B9DC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callDele_EventOnPauseBattle(IntPtr l)
	{
		int result;
		try
		{
			BattlePrepareUIController battlePrepareUIController = (BattlePrepareUIController)LuaObject.checkSelf(l);
			battlePrepareUIController.m_luaExportHelper.__callDele_EventOnPauseBattle();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601BC8F RID: 113807 RVA: 0x0087D830 File Offset: 0x0087BA30
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __clearDele_EventOnPauseBattle(IntPtr l)
	{
		int result;
		try
		{
			BattlePrepareUIController battlePrepareUIController = (BattlePrepareUIController)LuaObject.checkSelf(l);
			battlePrepareUIController.m_luaExportHelper.__clearDele_EventOnPauseBattle();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601BC90 RID: 113808 RVA: 0x0087D884 File Offset: 0x0087BA84
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callDele_EventOnShowArmyRelation(IntPtr l)
	{
		int result;
		try
		{
			BattlePrepareUIController battlePrepareUIController = (BattlePrepareUIController)LuaObject.checkSelf(l);
			battlePrepareUIController.m_luaExportHelper.__callDele_EventOnShowArmyRelation();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601BC91 RID: 113809 RVA: 0x0087D8D8 File Offset: 0x0087BAD8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __clearDele_EventOnShowArmyRelation(IntPtr l)
	{
		int result;
		try
		{
			BattlePrepareUIController battlePrepareUIController = (BattlePrepareUIController)LuaObject.checkSelf(l);
			battlePrepareUIController.m_luaExportHelper.__clearDele_EventOnShowArmyRelation();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601BC92 RID: 113810 RVA: 0x0087D92C File Offset: 0x0087BB2C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callDele_EventOnStart(IntPtr l)
	{
		int result;
		try
		{
			BattlePrepareUIController battlePrepareUIController = (BattlePrepareUIController)LuaObject.checkSelf(l);
			battlePrepareUIController.m_luaExportHelper.__callDele_EventOnStart();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601BC93 RID: 113811 RVA: 0x0087D980 File Offset: 0x0087BB80
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __clearDele_EventOnStart(IntPtr l)
	{
		int result;
		try
		{
			BattlePrepareUIController battlePrepareUIController = (BattlePrepareUIController)LuaObject.checkSelf(l);
			battlePrepareUIController.m_luaExportHelper.__clearDele_EventOnStart();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601BC94 RID: 113812 RVA: 0x0087D9D4 File Offset: 0x0087BBD4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callDele_EventOnShowActionOrder(IntPtr l)
	{
		int result;
		try
		{
			BattlePrepareUIController battlePrepareUIController = (BattlePrepareUIController)LuaObject.checkSelf(l);
			battlePrepareUIController.m_luaExportHelper.__callDele_EventOnShowActionOrder();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601BC95 RID: 113813 RVA: 0x0087DA28 File Offset: 0x0087BC28
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __clearDele_EventOnShowActionOrder(IntPtr l)
	{
		int result;
		try
		{
			BattlePrepareUIController battlePrepareUIController = (BattlePrepareUIController)LuaObject.checkSelf(l);
			battlePrepareUIController.m_luaExportHelper.__clearDele_EventOnShowActionOrder();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601BC96 RID: 113814 RVA: 0x0087DA7C File Offset: 0x0087BC7C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callDele_EventOnTestOnStage(IntPtr l)
	{
		int result;
		try
		{
			BattlePrepareUIController battlePrepareUIController = (BattlePrepareUIController)LuaObject.checkSelf(l);
			battlePrepareUIController.m_luaExportHelper.__callDele_EventOnTestOnStage();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601BC97 RID: 113815 RVA: 0x0087DAD0 File Offset: 0x0087BCD0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __clearDele_EventOnTestOnStage(IntPtr l)
	{
		int result;
		try
		{
			BattlePrepareUIController battlePrepareUIController = (BattlePrepareUIController)LuaObject.checkSelf(l);
			battlePrepareUIController.m_luaExportHelper.__clearDele_EventOnTestOnStage();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601BC98 RID: 113816 RVA: 0x0087DB24 File Offset: 0x0087BD24
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callDele_EventOnShowMyActorInfo(IntPtr l)
	{
		int result;
		try
		{
			BattlePrepareUIController battlePrepareUIController = (BattlePrepareUIController)LuaObject.checkSelf(l);
			BattleHero obj;
			LuaObject.checkType<BattleHero>(l, 2, out obj);
			battlePrepareUIController.m_luaExportHelper.__callDele_EventOnShowMyActorInfo(obj);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601BC99 RID: 113817 RVA: 0x0087DB80 File Offset: 0x0087BD80
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __clearDele_EventOnShowMyActorInfo(IntPtr l)
	{
		int result;
		try
		{
			BattlePrepareUIController battlePrepareUIController = (BattlePrepareUIController)LuaObject.checkSelf(l);
			BattleHero obj;
			LuaObject.checkType<BattleHero>(l, 2, out obj);
			battlePrepareUIController.m_luaExportHelper.__clearDele_EventOnShowMyActorInfo(obj);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601BC9A RID: 113818 RVA: 0x0087DBDC File Offset: 0x0087BDDC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callDele_EventOnHideActorInfo(IntPtr l)
	{
		int result;
		try
		{
			BattlePrepareUIController battlePrepareUIController = (BattlePrepareUIController)LuaObject.checkSelf(l);
			battlePrepareUIController.m_luaExportHelper.__callDele_EventOnHideActorInfo();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601BC9B RID: 113819 RVA: 0x0087DC30 File Offset: 0x0087BE30
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __clearDele_EventOnHideActorInfo(IntPtr l)
	{
		int result;
		try
		{
			BattlePrepareUIController battlePrepareUIController = (BattlePrepareUIController)LuaObject.checkSelf(l);
			battlePrepareUIController.m_luaExportHelper.__clearDele_EventOnHideActorInfo();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601BC9C RID: 113820 RVA: 0x0087DC84 File Offset: 0x0087BE84
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callDele_EventOnStageActorChange(IntPtr l)
	{
		int result;
		try
		{
			BattlePrepareUIController battlePrepareUIController = (BattlePrepareUIController)LuaObject.checkSelf(l);
			battlePrepareUIController.m_luaExportHelper.__callDele_EventOnStageActorChange();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601BC9D RID: 113821 RVA: 0x0087DCD8 File Offset: 0x0087BED8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __clearDele_EventOnStageActorChange(IntPtr l)
	{
		int result;
		try
		{
			BattlePrepareUIController battlePrepareUIController = (BattlePrepareUIController)LuaObject.checkSelf(l);
			battlePrepareUIController.m_luaExportHelper.__clearDele_EventOnStageActorChange();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601BC9E RID: 113822 RVA: 0x0087DD2C File Offset: 0x0087BF2C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callDele_EventOnShowChat(IntPtr l)
	{
		int result;
		try
		{
			BattlePrepareUIController battlePrepareUIController = (BattlePrepareUIController)LuaObject.checkSelf(l);
			battlePrepareUIController.m_luaExportHelper.__callDele_EventOnShowChat();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601BC9F RID: 113823 RVA: 0x0087DD80 File Offset: 0x0087BF80
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __clearDele_EventOnShowChat(IntPtr l)
	{
		int result;
		try
		{
			BattlePrepareUIController battlePrepareUIController = (BattlePrepareUIController)LuaObject.checkSelf(l);
			battlePrepareUIController.m_luaExportHelper.__clearDele_EventOnShowChat();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601BCA0 RID: 113824 RVA: 0x0087DDD4 File Offset: 0x0087BFD4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callDele_EventOnShowHelp(IntPtr l)
	{
		int result;
		try
		{
			BattlePrepareUIController battlePrepareUIController = (BattlePrepareUIController)LuaObject.checkSelf(l);
			battlePrepareUIController.m_luaExportHelper.__callDele_EventOnShowHelp();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601BCA1 RID: 113825 RVA: 0x0087DE28 File Offset: 0x0087C028
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __clearDele_EventOnShowHelp(IntPtr l)
	{
		int result;
		try
		{
			BattlePrepareUIController battlePrepareUIController = (BattlePrepareUIController)LuaObject.checkSelf(l);
			battlePrepareUIController.m_luaExportHelper.__clearDele_EventOnShowHelp();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601BCA2 RID: 113826 RVA: 0x0087DE7C File Offset: 0x0087C07C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callDele_EventOnHeroOnStage(IntPtr l)
	{
		int result;
		try
		{
			BattlePrepareUIController battlePrepareUIController = (BattlePrepareUIController)LuaObject.checkSelf(l);
			BattleHero arg;
			LuaObject.checkType<BattleHero>(l, 2, out arg);
			GridPosition arg2;
			LuaObject.checkValueType<GridPosition>(l, 3, out arg2);
			int arg3;
			LuaObject.checkType(l, 4, out arg3);
			battlePrepareUIController.m_luaExportHelper.__callDele_EventOnHeroOnStage(arg, arg2, arg3);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601BCA3 RID: 113827 RVA: 0x0087DEF4 File Offset: 0x0087C0F4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __clearDele_EventOnHeroOnStage(IntPtr l)
	{
		int result;
		try
		{
			BattlePrepareUIController battlePrepareUIController = (BattlePrepareUIController)LuaObject.checkSelf(l);
			BattleHero arg;
			LuaObject.checkType<BattleHero>(l, 2, out arg);
			GridPosition arg2;
			LuaObject.checkValueType<GridPosition>(l, 3, out arg2);
			int arg3;
			LuaObject.checkType(l, 4, out arg3);
			battlePrepareUIController.m_luaExportHelper.__clearDele_EventOnHeroOnStage(arg, arg2, arg3);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601BCA4 RID: 113828 RVA: 0x0087DF6C File Offset: 0x0087C16C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callDele_EventOnActorOffStage(IntPtr l)
	{
		int result;
		try
		{
			BattlePrepareUIController battlePrepareUIController = (BattlePrepareUIController)LuaObject.checkSelf(l);
			BattlePrepareStageActor obj;
			LuaObject.checkType<BattlePrepareStageActor>(l, 2, out obj);
			battlePrepareUIController.m_luaExportHelper.__callDele_EventOnActorOffStage(obj);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601BCA5 RID: 113829 RVA: 0x0087DFC8 File Offset: 0x0087C1C8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __clearDele_EventOnActorOffStage(IntPtr l)
	{
		int result;
		try
		{
			BattlePrepareUIController battlePrepareUIController = (BattlePrepareUIController)LuaObject.checkSelf(l);
			BattlePrepareStageActor obj;
			LuaObject.checkType<BattlePrepareStageActor>(l, 2, out obj);
			battlePrepareUIController.m_luaExportHelper.__clearDele_EventOnActorOffStage(obj);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601BCA6 RID: 113830 RVA: 0x0087E024 File Offset: 0x0087C224
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callDele_EventOnStageActorMove(IntPtr l)
	{
		int result;
		try
		{
			BattlePrepareUIController battlePrepareUIController = (BattlePrepareUIController)LuaObject.checkSelf(l);
			BattlePrepareStageActor arg;
			LuaObject.checkType<BattlePrepareStageActor>(l, 2, out arg);
			GridPosition arg2;
			LuaObject.checkValueType<GridPosition>(l, 3, out arg2);
			battlePrepareUIController.m_luaExportHelper.__callDele_EventOnStageActorMove(arg, arg2);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601BCA7 RID: 113831 RVA: 0x0087E090 File Offset: 0x0087C290
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __clearDele_EventOnStageActorMove(IntPtr l)
	{
		int result;
		try
		{
			BattlePrepareUIController battlePrepareUIController = (BattlePrepareUIController)LuaObject.checkSelf(l);
			BattlePrepareStageActor arg;
			LuaObject.checkType<BattlePrepareStageActor>(l, 2, out arg);
			GridPosition arg2;
			LuaObject.checkValueType<GridPosition>(l, 3, out arg2);
			battlePrepareUIController.m_luaExportHelper.__clearDele_EventOnStageActorMove(arg, arg2);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601BCA8 RID: 113832 RVA: 0x0087E0FC File Offset: 0x0087C2FC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callDele_EventOnStageActorSwap(IntPtr l)
	{
		int result;
		try
		{
			BattlePrepareUIController battlePrepareUIController = (BattlePrepareUIController)LuaObject.checkSelf(l);
			BattlePrepareStageActor arg;
			LuaObject.checkType<BattlePrepareStageActor>(l, 2, out arg);
			BattlePrepareStageActor arg2;
			LuaObject.checkType<BattlePrepareStageActor>(l, 3, out arg2);
			battlePrepareUIController.m_luaExportHelper.__callDele_EventOnStageActorSwap(arg, arg2);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601BCA9 RID: 113833 RVA: 0x0087E168 File Offset: 0x0087C368
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __clearDele_EventOnStageActorSwap(IntPtr l)
	{
		int result;
		try
		{
			BattlePrepareUIController battlePrepareUIController = (BattlePrepareUIController)LuaObject.checkSelf(l);
			BattlePrepareStageActor arg;
			LuaObject.checkType<BattlePrepareStageActor>(l, 2, out arg);
			BattlePrepareStageActor arg2;
			LuaObject.checkType<BattlePrepareStageActor>(l, 3, out arg2);
			battlePrepareUIController.m_luaExportHelper.__clearDele_EventOnStageActorSwap(arg, arg2);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601BCAA RID: 113834 RVA: 0x0087E1D4 File Offset: 0x0087C3D4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callDele_EventOnPointerDown(IntPtr l)
	{
		int result;
		try
		{
			BattlePrepareUIController battlePrepareUIController = (BattlePrepareUIController)LuaObject.checkSelf(l);
			PointerEventData.InputButton arg;
			LuaObject.checkEnum<PointerEventData.InputButton>(l, 2, out arg);
			Vector2 arg2;
			LuaObject.checkType(l, 3, out arg2);
			battlePrepareUIController.m_luaExportHelper.__callDele_EventOnPointerDown(arg, arg2);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601BCAB RID: 113835 RVA: 0x0087E240 File Offset: 0x0087C440
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __clearDele_EventOnPointerDown(IntPtr l)
	{
		int result;
		try
		{
			BattlePrepareUIController battlePrepareUIController = (BattlePrepareUIController)LuaObject.checkSelf(l);
			PointerEventData.InputButton arg;
			LuaObject.checkEnum<PointerEventData.InputButton>(l, 2, out arg);
			Vector2 arg2;
			LuaObject.checkType(l, 3, out arg2);
			battlePrepareUIController.m_luaExportHelper.__clearDele_EventOnPointerDown(arg, arg2);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601BCAC RID: 113836 RVA: 0x0087E2AC File Offset: 0x0087C4AC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callDele_EventOnPointerUp(IntPtr l)
	{
		int result;
		try
		{
			BattlePrepareUIController battlePrepareUIController = (BattlePrepareUIController)LuaObject.checkSelf(l);
			PointerEventData.InputButton arg;
			LuaObject.checkEnum<PointerEventData.InputButton>(l, 2, out arg);
			Vector2 arg2;
			LuaObject.checkType(l, 3, out arg2);
			battlePrepareUIController.m_luaExportHelper.__callDele_EventOnPointerUp(arg, arg2);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601BCAD RID: 113837 RVA: 0x0087E318 File Offset: 0x0087C518
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __clearDele_EventOnPointerUp(IntPtr l)
	{
		int result;
		try
		{
			BattlePrepareUIController battlePrepareUIController = (BattlePrepareUIController)LuaObject.checkSelf(l);
			PointerEventData.InputButton arg;
			LuaObject.checkEnum<PointerEventData.InputButton>(l, 2, out arg);
			Vector2 arg2;
			LuaObject.checkType(l, 3, out arg2);
			battlePrepareUIController.m_luaExportHelper.__clearDele_EventOnPointerUp(arg, arg2);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601BCAE RID: 113838 RVA: 0x0087E384 File Offset: 0x0087C584
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callDele_EventOnPointerClick(IntPtr l)
	{
		int result;
		try
		{
			BattlePrepareUIController battlePrepareUIController = (BattlePrepareUIController)LuaObject.checkSelf(l);
			PointerEventData.InputButton arg;
			LuaObject.checkEnum<PointerEventData.InputButton>(l, 2, out arg);
			Vector2 arg2;
			LuaObject.checkType(l, 3, out arg2);
			battlePrepareUIController.m_luaExportHelper.__callDele_EventOnPointerClick(arg, arg2);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601BCAF RID: 113839 RVA: 0x0087E3F0 File Offset: 0x0087C5F0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __clearDele_EventOnPointerClick(IntPtr l)
	{
		int result;
		try
		{
			BattlePrepareUIController battlePrepareUIController = (BattlePrepareUIController)LuaObject.checkSelf(l);
			PointerEventData.InputButton arg;
			LuaObject.checkEnum<PointerEventData.InputButton>(l, 2, out arg);
			Vector2 arg2;
			LuaObject.checkType(l, 3, out arg2);
			battlePrepareUIController.m_luaExportHelper.__clearDele_EventOnPointerClick(arg, arg2);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601BCB0 RID: 113840 RVA: 0x0087E45C File Offset: 0x0087C65C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callDele_EventOnBeginDragHero(IntPtr l)
	{
		int result;
		try
		{
			BattlePrepareUIController battlePrepareUIController = (BattlePrepareUIController)LuaObject.checkSelf(l);
			battlePrepareUIController.m_luaExportHelper.__callDele_EventOnBeginDragHero();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601BCB1 RID: 113841 RVA: 0x0087E4B0 File Offset: 0x0087C6B0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __clearDele_EventOnBeginDragHero(IntPtr l)
	{
		int result;
		try
		{
			BattlePrepareUIController battlePrepareUIController = (BattlePrepareUIController)LuaObject.checkSelf(l);
			battlePrepareUIController.m_luaExportHelper.__clearDele_EventOnBeginDragHero();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601BCB2 RID: 113842 RVA: 0x0087E504 File Offset: 0x0087C704
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callDele_EventOnEndDragHero(IntPtr l)
	{
		int result;
		try
		{
			BattlePrepareUIController battlePrepareUIController = (BattlePrepareUIController)LuaObject.checkSelf(l);
			battlePrepareUIController.m_luaExportHelper.__callDele_EventOnEndDragHero();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601BCB3 RID: 113843 RVA: 0x0087E558 File Offset: 0x0087C758
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __clearDele_EventOnEndDragHero(IntPtr l)
	{
		int result;
		try
		{
			BattlePrepareUIController battlePrepareUIController = (BattlePrepareUIController)LuaObject.checkSelf(l);
			battlePrepareUIController.m_luaExportHelper.__clearDele_EventOnEndDragHero();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601BCB4 RID: 113844 RVA: 0x0087E5AC File Offset: 0x0087C7AC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int CompareTransformY_s(IntPtr l)
	{
		int result;
		try
		{
			Transform t;
			LuaObject.checkType<Transform>(l, 1, out t);
			Transform t2;
			LuaObject.checkType<Transform>(l, 2, out t2);
			int i = BattlePrepareUIController.LuaExportHelper.CompareTransformY(t, t2);
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

	// Token: 0x0601BCB5 RID: 113845 RVA: 0x0087E60C File Offset: 0x0087C80C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int SetInputFieldValue_s(IntPtr l)
	{
		int result;
		try
		{
			InputField inputField;
			LuaObject.checkType<InputField>(l, 1, out inputField);
			int value;
			LuaObject.checkType(l, 2, out value);
			int defaultValue;
			LuaObject.checkType(l, 3, out defaultValue);
			BattlePrepareUIController.LuaExportHelper.SetInputFieldValue(inputField, value, defaultValue);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601BCB6 RID: 113846 RVA: 0x0087E670 File Offset: 0x0087C870
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int GetInputFieldValue_s(IntPtr l)
	{
		int result;
		try
		{
			InputField inputField;
			LuaObject.checkType<InputField>(l, 1, out inputField);
			int defaultValue;
			LuaObject.checkType(l, 2, out defaultValue);
			int inputFieldValue = BattlePrepareUIController.LuaExportHelper.GetInputFieldValue(inputField, defaultValue);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, inputFieldValue);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601BCB7 RID: 113847 RVA: 0x0087E6D0 File Offset: 0x0087C8D0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_EventOnPauseBattle(IntPtr l)
	{
		int result;
		try
		{
			BattlePrepareUIController battlePrepareUIController = (BattlePrepareUIController)LuaObject.checkSelf(l);
			Action value;
			int num = LuaObject.checkDelegate<Action>(l, 2, out value);
			if (num != 0)
			{
				if (num == 1)
				{
					battlePrepareUIController.EventOnPauseBattle += value;
				}
				else if (num == 2)
				{
					battlePrepareUIController.EventOnPauseBattle -= value;
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

	// Token: 0x0601BCB8 RID: 113848 RVA: 0x0087E750 File Offset: 0x0087C950
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_EventOnShowArmyRelation(IntPtr l)
	{
		int result;
		try
		{
			BattlePrepareUIController battlePrepareUIController = (BattlePrepareUIController)LuaObject.checkSelf(l);
			Action value;
			int num = LuaObject.checkDelegate<Action>(l, 2, out value);
			if (num != 0)
			{
				if (num == 1)
				{
					battlePrepareUIController.EventOnShowArmyRelation += value;
				}
				else if (num == 2)
				{
					battlePrepareUIController.EventOnShowArmyRelation -= value;
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

	// Token: 0x0601BCB9 RID: 113849 RVA: 0x0087E7D0 File Offset: 0x0087C9D0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_EventOnStart(IntPtr l)
	{
		int result;
		try
		{
			BattlePrepareUIController battlePrepareUIController = (BattlePrepareUIController)LuaObject.checkSelf(l);
			Action value;
			int num = LuaObject.checkDelegate<Action>(l, 2, out value);
			if (num != 0)
			{
				if (num == 1)
				{
					battlePrepareUIController.EventOnStart += value;
				}
				else if (num == 2)
				{
					battlePrepareUIController.EventOnStart -= value;
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

	// Token: 0x0601BCBA RID: 113850 RVA: 0x0087E850 File Offset: 0x0087CA50
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_EventOnShowActionOrder(IntPtr l)
	{
		int result;
		try
		{
			BattlePrepareUIController battlePrepareUIController = (BattlePrepareUIController)LuaObject.checkSelf(l);
			Action value;
			int num = LuaObject.checkDelegate<Action>(l, 2, out value);
			if (num != 0)
			{
				if (num == 1)
				{
					battlePrepareUIController.EventOnShowActionOrder += value;
				}
				else if (num == 2)
				{
					battlePrepareUIController.EventOnShowActionOrder -= value;
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

	// Token: 0x0601BCBB RID: 113851 RVA: 0x0087E8D0 File Offset: 0x0087CAD0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_EventOnTestOnStage(IntPtr l)
	{
		int result;
		try
		{
			BattlePrepareUIController battlePrepareUIController = (BattlePrepareUIController)LuaObject.checkSelf(l);
			Action value;
			int num = LuaObject.checkDelegate<Action>(l, 2, out value);
			if (num != 0)
			{
				if (num == 1)
				{
					battlePrepareUIController.EventOnTestOnStage += value;
				}
				else if (num == 2)
				{
					battlePrepareUIController.EventOnTestOnStage -= value;
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

	// Token: 0x0601BCBC RID: 113852 RVA: 0x0087E950 File Offset: 0x0087CB50
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_EventOnShowMyActorInfo(IntPtr l)
	{
		int result;
		try
		{
			BattlePrepareUIController battlePrepareUIController = (BattlePrepareUIController)LuaObject.checkSelf(l);
			Action<BattleHero> value;
			int num = LuaObject.checkDelegate<Action<BattleHero>>(l, 2, out value);
			if (num != 0)
			{
				if (num == 1)
				{
					battlePrepareUIController.EventOnShowMyActorInfo += value;
				}
				else if (num == 2)
				{
					battlePrepareUIController.EventOnShowMyActorInfo -= value;
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

	// Token: 0x0601BCBD RID: 113853 RVA: 0x0087E9D0 File Offset: 0x0087CBD0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_EventOnHideActorInfo(IntPtr l)
	{
		int result;
		try
		{
			BattlePrepareUIController battlePrepareUIController = (BattlePrepareUIController)LuaObject.checkSelf(l);
			Action value;
			int num = LuaObject.checkDelegate<Action>(l, 2, out value);
			if (num != 0)
			{
				if (num == 1)
				{
					battlePrepareUIController.EventOnHideActorInfo += value;
				}
				else if (num == 2)
				{
					battlePrepareUIController.EventOnHideActorInfo -= value;
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

	// Token: 0x0601BCBE RID: 113854 RVA: 0x0087EA50 File Offset: 0x0087CC50
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_EventOnStageActorChange(IntPtr l)
	{
		int result;
		try
		{
			BattlePrepareUIController battlePrepareUIController = (BattlePrepareUIController)LuaObject.checkSelf(l);
			Action value;
			int num = LuaObject.checkDelegate<Action>(l, 2, out value);
			if (num != 0)
			{
				if (num == 1)
				{
					battlePrepareUIController.EventOnStageActorChange += value;
				}
				else if (num == 2)
				{
					battlePrepareUIController.EventOnStageActorChange -= value;
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

	// Token: 0x0601BCBF RID: 113855 RVA: 0x0087EAD0 File Offset: 0x0087CCD0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_EventOnShowChat(IntPtr l)
	{
		int result;
		try
		{
			BattlePrepareUIController battlePrepareUIController = (BattlePrepareUIController)LuaObject.checkSelf(l);
			Action value;
			int num = LuaObject.checkDelegate<Action>(l, 2, out value);
			if (num != 0)
			{
				if (num == 1)
				{
					battlePrepareUIController.EventOnShowChat += value;
				}
				else if (num == 2)
				{
					battlePrepareUIController.EventOnShowChat -= value;
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

	// Token: 0x0601BCC0 RID: 113856 RVA: 0x0087EB50 File Offset: 0x0087CD50
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_EventOnShowHelp(IntPtr l)
	{
		int result;
		try
		{
			BattlePrepareUIController battlePrepareUIController = (BattlePrepareUIController)LuaObject.checkSelf(l);
			Action value;
			int num = LuaObject.checkDelegate<Action>(l, 2, out value);
			if (num != 0)
			{
				if (num == 1)
				{
					battlePrepareUIController.EventOnShowHelp += value;
				}
				else if (num == 2)
				{
					battlePrepareUIController.EventOnShowHelp -= value;
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

	// Token: 0x0601BCC1 RID: 113857 RVA: 0x0087EBD0 File Offset: 0x0087CDD0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_EventOnHeroOnStage(IntPtr l)
	{
		int result;
		try
		{
			BattlePrepareUIController battlePrepareUIController = (BattlePrepareUIController)LuaObject.checkSelf(l);
			Action<BattleHero, GridPosition, int> value;
			int num = LuaObject.checkDelegate<Action<BattleHero, GridPosition, int>>(l, 2, out value);
			if (num != 0)
			{
				if (num == 1)
				{
					battlePrepareUIController.EventOnHeroOnStage += value;
				}
				else if (num == 2)
				{
					battlePrepareUIController.EventOnHeroOnStage -= value;
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

	// Token: 0x0601BCC2 RID: 113858 RVA: 0x0087EC50 File Offset: 0x0087CE50
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_EventOnActorOffStage(IntPtr l)
	{
		int result;
		try
		{
			BattlePrepareUIController battlePrepareUIController = (BattlePrepareUIController)LuaObject.checkSelf(l);
			Action<BattlePrepareStageActor> value;
			int num = LuaObject.checkDelegate<Action<BattlePrepareStageActor>>(l, 2, out value);
			if (num != 0)
			{
				if (num == 1)
				{
					battlePrepareUIController.EventOnActorOffStage += value;
				}
				else if (num == 2)
				{
					battlePrepareUIController.EventOnActorOffStage -= value;
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

	// Token: 0x0601BCC3 RID: 113859 RVA: 0x0087ECD0 File Offset: 0x0087CED0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_EventOnStageActorMove(IntPtr l)
	{
		int result;
		try
		{
			BattlePrepareUIController battlePrepareUIController = (BattlePrepareUIController)LuaObject.checkSelf(l);
			Action<BattlePrepareStageActor, GridPosition> value;
			int num = LuaObject.checkDelegate<Action<BattlePrepareStageActor, GridPosition>>(l, 2, out value);
			if (num != 0)
			{
				if (num == 1)
				{
					battlePrepareUIController.EventOnStageActorMove += value;
				}
				else if (num == 2)
				{
					battlePrepareUIController.EventOnStageActorMove -= value;
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

	// Token: 0x0601BCC4 RID: 113860 RVA: 0x0087ED50 File Offset: 0x0087CF50
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_EventOnStageActorSwap(IntPtr l)
	{
		int result;
		try
		{
			BattlePrepareUIController battlePrepareUIController = (BattlePrepareUIController)LuaObject.checkSelf(l);
			Action<BattlePrepareStageActor, BattlePrepareStageActor> value;
			int num = LuaObject.checkDelegate<Action<BattlePrepareStageActor, BattlePrepareStageActor>>(l, 2, out value);
			if (num != 0)
			{
				if (num == 1)
				{
					battlePrepareUIController.EventOnStageActorSwap += value;
				}
				else if (num == 2)
				{
					battlePrepareUIController.EventOnStageActorSwap -= value;
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

	// Token: 0x0601BCC5 RID: 113861 RVA: 0x0087EDD0 File Offset: 0x0087CFD0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_EventOnPointerDown(IntPtr l)
	{
		int result;
		try
		{
			BattlePrepareUIController battlePrepareUIController = (BattlePrepareUIController)LuaObject.checkSelf(l);
			Action<PointerEventData.InputButton, Vector2> value;
			int num = LuaObject.checkDelegate<Action<PointerEventData.InputButton, Vector2>>(l, 2, out value);
			if (num != 0)
			{
				if (num == 1)
				{
					battlePrepareUIController.EventOnPointerDown += value;
				}
				else if (num == 2)
				{
					battlePrepareUIController.EventOnPointerDown -= value;
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

	// Token: 0x0601BCC6 RID: 113862 RVA: 0x0087EE50 File Offset: 0x0087D050
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_EventOnPointerUp(IntPtr l)
	{
		int result;
		try
		{
			BattlePrepareUIController battlePrepareUIController = (BattlePrepareUIController)LuaObject.checkSelf(l);
			Action<PointerEventData.InputButton, Vector2> value;
			int num = LuaObject.checkDelegate<Action<PointerEventData.InputButton, Vector2>>(l, 2, out value);
			if (num != 0)
			{
				if (num == 1)
				{
					battlePrepareUIController.EventOnPointerUp += value;
				}
				else if (num == 2)
				{
					battlePrepareUIController.EventOnPointerUp -= value;
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

	// Token: 0x0601BCC7 RID: 113863 RVA: 0x0087EED0 File Offset: 0x0087D0D0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_EventOnPointerClick(IntPtr l)
	{
		int result;
		try
		{
			BattlePrepareUIController battlePrepareUIController = (BattlePrepareUIController)LuaObject.checkSelf(l);
			Action<PointerEventData.InputButton, Vector2> value;
			int num = LuaObject.checkDelegate<Action<PointerEventData.InputButton, Vector2>>(l, 2, out value);
			if (num != 0)
			{
				if (num == 1)
				{
					battlePrepareUIController.EventOnPointerClick += value;
				}
				else if (num == 2)
				{
					battlePrepareUIController.EventOnPointerClick -= value;
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

	// Token: 0x0601BCC8 RID: 113864 RVA: 0x0087EF50 File Offset: 0x0087D150
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_EventOnBeginDragHero(IntPtr l)
	{
		int result;
		try
		{
			BattlePrepareUIController battlePrepareUIController = (BattlePrepareUIController)LuaObject.checkSelf(l);
			Action value;
			int num = LuaObject.checkDelegate<Action>(l, 2, out value);
			if (num != 0)
			{
				if (num == 1)
				{
					battlePrepareUIController.EventOnBeginDragHero += value;
				}
				else if (num == 2)
				{
					battlePrepareUIController.EventOnBeginDragHero -= value;
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

	// Token: 0x0601BCC9 RID: 113865 RVA: 0x0087EFD0 File Offset: 0x0087D1D0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_EventOnEndDragHero(IntPtr l)
	{
		int result;
		try
		{
			BattlePrepareUIController battlePrepareUIController = (BattlePrepareUIController)LuaObject.checkSelf(l);
			Action value;
			int num = LuaObject.checkDelegate<Action>(l, 2, out value);
			if (num != 0)
			{
				if (num == 1)
				{
					battlePrepareUIController.EventOnEndDragHero += value;
				}
				else if (num == 2)
				{
					battlePrepareUIController.EventOnEndDragHero -= value;
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

	// Token: 0x0601BCCA RID: 113866 RVA: 0x0087F050 File Offset: 0x0087D250
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_marginTransform(IntPtr l)
	{
		int result;
		try
		{
			BattlePrepareUIController battlePrepareUIController = (BattlePrepareUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, battlePrepareUIController.m_luaExportHelper.m_marginTransform);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601BCCB RID: 113867 RVA: 0x0087F0A8 File Offset: 0x0087D2A8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_marginTransform(IntPtr l)
	{
		int result;
		try
		{
			BattlePrepareUIController battlePrepareUIController = (BattlePrepareUIController)LuaObject.checkSelf(l);
			RectTransform marginTransform;
			LuaObject.checkType<RectTransform>(l, 2, out marginTransform);
			battlePrepareUIController.m_luaExportHelper.m_marginTransform = marginTransform;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601BCCC RID: 113868 RVA: 0x0087F104 File Offset: 0x0087D304
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_pauseButton(IntPtr l)
	{
		int result;
		try
		{
			BattlePrepareUIController battlePrepareUIController = (BattlePrepareUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, battlePrepareUIController.m_luaExportHelper.m_pauseButton);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601BCCD RID: 113869 RVA: 0x0087F15C File Offset: 0x0087D35C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_pauseButton(IntPtr l)
	{
		int result;
		try
		{
			BattlePrepareUIController battlePrepareUIController = (BattlePrepareUIController)LuaObject.checkSelf(l);
			Button pauseButton;
			LuaObject.checkType<Button>(l, 2, out pauseButton);
			battlePrepareUIController.m_luaExportHelper.m_pauseButton = pauseButton;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601BCCE RID: 113870 RVA: 0x0087F1B8 File Offset: 0x0087D3B8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_stageActorCountText(IntPtr l)
	{
		int result;
		try
		{
			BattlePrepareUIController battlePrepareUIController = (BattlePrepareUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, battlePrepareUIController.m_luaExportHelper.m_stageActorCountText);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601BCCF RID: 113871 RVA: 0x0087F210 File Offset: 0x0087D410
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_stageActorCountText(IntPtr l)
	{
		int result;
		try
		{
			BattlePrepareUIController battlePrepareUIController = (BattlePrepareUIController)LuaObject.checkSelf(l);
			Text stageActorCountText;
			LuaObject.checkType<Text>(l, 2, out stageActorCountText);
			battlePrepareUIController.m_luaExportHelper.m_stageActorCountText = stageActorCountText;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601BCD0 RID: 113872 RVA: 0x0087F26C File Offset: 0x0087D46C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_battlePowerUIStateController(IntPtr l)
	{
		int result;
		try
		{
			BattlePrepareUIController battlePrepareUIController = (BattlePrepareUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, battlePrepareUIController.m_luaExportHelper.m_battlePowerUIStateController);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601BCD1 RID: 113873 RVA: 0x0087F2C4 File Offset: 0x0087D4C4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_battlePowerUIStateController(IntPtr l)
	{
		int result;
		try
		{
			BattlePrepareUIController battlePrepareUIController = (BattlePrepareUIController)LuaObject.checkSelf(l);
			CommonUIStateController battlePowerUIStateController;
			LuaObject.checkType<CommonUIStateController>(l, 2, out battlePowerUIStateController);
			battlePrepareUIController.m_luaExportHelper.m_battlePowerUIStateController = battlePowerUIStateController;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601BCD2 RID: 113874 RVA: 0x0087F320 File Offset: 0x0087D520
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_battlePowerText(IntPtr l)
	{
		int result;
		try
		{
			BattlePrepareUIController battlePrepareUIController = (BattlePrepareUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, battlePrepareUIController.m_luaExportHelper.m_battlePowerText);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601BCD3 RID: 113875 RVA: 0x0087F378 File Offset: 0x0087D578
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_battlePowerText(IntPtr l)
	{
		int result;
		try
		{
			BattlePrepareUIController battlePrepareUIController = (BattlePrepareUIController)LuaObject.checkSelf(l);
			Text battlePowerText;
			LuaObject.checkType<Text>(l, 2, out battlePowerText);
			battlePrepareUIController.m_luaExportHelper.m_battlePowerText = battlePowerText;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601BCD4 RID: 113876 RVA: 0x0087F3D4 File Offset: 0x0087D5D4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_battlePowerArrowGo(IntPtr l)
	{
		int result;
		try
		{
			BattlePrepareUIController battlePrepareUIController = (BattlePrepareUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, battlePrepareUIController.m_luaExportHelper.m_battlePowerArrowGo);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601BCD5 RID: 113877 RVA: 0x0087F42C File Offset: 0x0087D62C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_battlePowerArrowGo(IntPtr l)
	{
		int result;
		try
		{
			BattlePrepareUIController battlePrepareUIController = (BattlePrepareUIController)LuaObject.checkSelf(l);
			GameObject battlePowerArrowGo;
			LuaObject.checkType<GameObject>(l, 2, out battlePowerArrowGo);
			battlePrepareUIController.m_luaExportHelper.m_battlePowerArrowGo = battlePowerArrowGo;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601BCD6 RID: 113878 RVA: 0x0087F488 File Offset: 0x0087D688
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_climbTowerRuleUIStateController(IntPtr l)
	{
		int result;
		try
		{
			BattlePrepareUIController battlePrepareUIController = (BattlePrepareUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, battlePrepareUIController.m_luaExportHelper.m_climbTowerRuleUIStateController);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601BCD7 RID: 113879 RVA: 0x0087F4E0 File Offset: 0x0087D6E0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_climbTowerRuleUIStateController(IntPtr l)
	{
		int result;
		try
		{
			BattlePrepareUIController battlePrepareUIController = (BattlePrepareUIController)LuaObject.checkSelf(l);
			CommonUIStateController climbTowerRuleUIStateController;
			LuaObject.checkType<CommonUIStateController>(l, 2, out climbTowerRuleUIStateController);
			battlePrepareUIController.m_luaExportHelper.m_climbTowerRuleUIStateController = climbTowerRuleUIStateController;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601BCD8 RID: 113880 RVA: 0x0087F53C File Offset: 0x0087D73C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_climbTowerRuleText(IntPtr l)
	{
		int result;
		try
		{
			BattlePrepareUIController battlePrepareUIController = (BattlePrepareUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, battlePrepareUIController.m_luaExportHelper.m_climbTowerRuleText);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601BCD9 RID: 113881 RVA: 0x0087F594 File Offset: 0x0087D794
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_climbTowerRuleText(IntPtr l)
	{
		int result;
		try
		{
			BattlePrepareUIController battlePrepareUIController = (BattlePrepareUIController)LuaObject.checkSelf(l);
			Text climbTowerRuleText;
			LuaObject.checkType<Text>(l, 2, out climbTowerRuleText);
			battlePrepareUIController.m_luaExportHelper.m_climbTowerRuleText = climbTowerRuleText;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601BCDA RID: 113882 RVA: 0x0087F5F0 File Offset: 0x0087D7F0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_chatButton(IntPtr l)
	{
		int result;
		try
		{
			BattlePrepareUIController battlePrepareUIController = (BattlePrepareUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, battlePrepareUIController.m_luaExportHelper.m_chatButton);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601BCDB RID: 113883 RVA: 0x0087F648 File Offset: 0x0087D848
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_chatButton(IntPtr l)
	{
		int result;
		try
		{
			BattlePrepareUIController battlePrepareUIController = (BattlePrepareUIController)LuaObject.checkSelf(l);
			Button chatButton;
			LuaObject.checkType<Button>(l, 2, out chatButton);
			battlePrepareUIController.m_luaExportHelper.m_chatButton = chatButton;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601BCDC RID: 113884 RVA: 0x0087F6A4 File Offset: 0x0087D8A4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_chatRedPoint(IntPtr l)
	{
		int result;
		try
		{
			BattlePrepareUIController battlePrepareUIController = (BattlePrepareUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, battlePrepareUIController.m_luaExportHelper.m_chatRedPoint);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601BCDD RID: 113885 RVA: 0x0087F6FC File Offset: 0x0087D8FC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_chatRedPoint(IntPtr l)
	{
		int result;
		try
		{
			BattlePrepareUIController battlePrepareUIController = (BattlePrepareUIController)LuaObject.checkSelf(l);
			GameObject chatRedPoint;
			LuaObject.checkType<GameObject>(l, 2, out chatRedPoint);
			battlePrepareUIController.m_luaExportHelper.m_chatRedPoint = chatRedPoint;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601BCDE RID: 113886 RVA: 0x0087F758 File Offset: 0x0087D958
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_actionOrderButton(IntPtr l)
	{
		int result;
		try
		{
			BattlePrepareUIController battlePrepareUIController = (BattlePrepareUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, battlePrepareUIController.m_luaExportHelper.m_actionOrderButton);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601BCDF RID: 113887 RVA: 0x0087F7B0 File Offset: 0x0087D9B0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_actionOrderButton(IntPtr l)
	{
		int result;
		try
		{
			BattlePrepareUIController battlePrepareUIController = (BattlePrepareUIController)LuaObject.checkSelf(l);
			Button actionOrderButton;
			LuaObject.checkType<Button>(l, 2, out actionOrderButton);
			battlePrepareUIController.m_luaExportHelper.m_actionOrderButton = actionOrderButton;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601BCE0 RID: 113888 RVA: 0x0087F80C File Offset: 0x0087DA0C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_startButton(IntPtr l)
	{
		int result;
		try
		{
			BattlePrepareUIController battlePrepareUIController = (BattlePrepareUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, battlePrepareUIController.m_luaExportHelper.m_startButton);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601BCE1 RID: 113889 RVA: 0x0087F864 File Offset: 0x0087DA64
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_startButton(IntPtr l)
	{
		int result;
		try
		{
			BattlePrepareUIController battlePrepareUIController = (BattlePrepareUIController)LuaObject.checkSelf(l);
			Button startButton;
			LuaObject.checkType<Button>(l, 2, out startButton);
			battlePrepareUIController.m_luaExportHelper.m_startButton = startButton;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601BCE2 RID: 113890 RVA: 0x0087F8C0 File Offset: 0x0087DAC0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_teamReadyGameObject(IntPtr l)
	{
		int result;
		try
		{
			BattlePrepareUIController battlePrepareUIController = (BattlePrepareUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, battlePrepareUIController.m_luaExportHelper.m_teamReadyGameObject);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601BCE3 RID: 113891 RVA: 0x0087F918 File Offset: 0x0087DB18
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_teamReadyGameObject(IntPtr l)
	{
		int result;
		try
		{
			BattlePrepareUIController battlePrepareUIController = (BattlePrepareUIController)LuaObject.checkSelf(l);
			GameObject teamReadyGameObject;
			LuaObject.checkType<GameObject>(l, 2, out teamReadyGameObject);
			battlePrepareUIController.m_luaExportHelper.m_teamReadyGameObject = teamReadyGameObject;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601BCE4 RID: 113892 RVA: 0x0087F974 File Offset: 0x0087DB74
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_teamReadyTimeUIStateController(IntPtr l)
	{
		int result;
		try
		{
			BattlePrepareUIController battlePrepareUIController = (BattlePrepareUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, battlePrepareUIController.m_luaExportHelper.m_teamReadyTimeUIStateController);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601BCE5 RID: 113893 RVA: 0x0087F9CC File Offset: 0x0087DBCC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_teamReadyTimeUIStateController(IntPtr l)
	{
		int result;
		try
		{
			BattlePrepareUIController battlePrepareUIController = (BattlePrepareUIController)LuaObject.checkSelf(l);
			CommonUIStateController teamReadyTimeUIStateController;
			LuaObject.checkType<CommonUIStateController>(l, 2, out teamReadyTimeUIStateController);
			battlePrepareUIController.m_luaExportHelper.m_teamReadyTimeUIStateController = teamReadyTimeUIStateController;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601BCE6 RID: 113894 RVA: 0x0087FA28 File Offset: 0x0087DC28
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_teamReadyTimeText(IntPtr l)
	{
		int result;
		try
		{
			BattlePrepareUIController battlePrepareUIController = (BattlePrepareUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, battlePrepareUIController.m_luaExportHelper.m_teamReadyTimeText);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601BCE7 RID: 113895 RVA: 0x0087FA80 File Offset: 0x0087DC80
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_teamReadyTimeText(IntPtr l)
	{
		int result;
		try
		{
			BattlePrepareUIController battlePrepareUIController = (BattlePrepareUIController)LuaObject.checkSelf(l);
			Text teamReadyTimeText;
			LuaObject.checkType<Text>(l, 2, out teamReadyTimeText);
			battlePrepareUIController.m_luaExportHelper.m_teamReadyTimeText = teamReadyTimeText;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601BCE8 RID: 113896 RVA: 0x0087FADC File Offset: 0x0087DCDC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_teamReadyWaitGameObject(IntPtr l)
	{
		int result;
		try
		{
			BattlePrepareUIController battlePrepareUIController = (BattlePrepareUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, battlePrepareUIController.m_luaExportHelper.m_teamReadyWaitGameObject);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601BCE9 RID: 113897 RVA: 0x0087FB34 File Offset: 0x0087DD34
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_teamReadyWaitGameObject(IntPtr l)
	{
		int result;
		try
		{
			BattlePrepareUIController battlePrepareUIController = (BattlePrepareUIController)LuaObject.checkSelf(l);
			GameObject teamReadyWaitGameObject;
			LuaObject.checkType<GameObject>(l, 2, out teamReadyWaitGameObject);
			battlePrepareUIController.m_luaExportHelper.m_teamReadyWaitGameObject = teamReadyWaitGameObject;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601BCEA RID: 113898 RVA: 0x0087FB90 File Offset: 0x0087DD90
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_teamReadyWaitTeammateText(IntPtr l)
	{
		int result;
		try
		{
			BattlePrepareUIController battlePrepareUIController = (BattlePrepareUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, battlePrepareUIController.m_luaExportHelper.m_teamReadyWaitTeammateText);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601BCEB RID: 113899 RVA: 0x0087FBE8 File Offset: 0x0087DDE8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_teamReadyWaitTeammateText(IntPtr l)
	{
		int result;
		try
		{
			BattlePrepareUIController battlePrepareUIController = (BattlePrepareUIController)LuaObject.checkSelf(l);
			Text teamReadyWaitTeammateText;
			LuaObject.checkType<Text>(l, 2, out teamReadyWaitTeammateText);
			battlePrepareUIController.m_luaExportHelper.m_teamReadyWaitTeammateText = teamReadyWaitTeammateText;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601BCEC RID: 113900 RVA: 0x0087FC44 File Offset: 0x0087DE44
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_teamReadyWaitOpponentText(IntPtr l)
	{
		int result;
		try
		{
			BattlePrepareUIController battlePrepareUIController = (BattlePrepareUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, battlePrepareUIController.m_luaExportHelper.m_teamReadyWaitOpponentText);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601BCED RID: 113901 RVA: 0x0087FC9C File Offset: 0x0087DE9C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_teamReadyWaitOpponentText(IntPtr l)
	{
		int result;
		try
		{
			BattlePrepareUIController battlePrepareUIController = (BattlePrepareUIController)LuaObject.checkSelf(l);
			Text teamReadyWaitOpponentText;
			LuaObject.checkType<Text>(l, 2, out teamReadyWaitOpponentText);
			battlePrepareUIController.m_luaExportHelper.m_teamReadyWaitOpponentText = teamReadyWaitOpponentText;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601BCEE RID: 113902 RVA: 0x0087FCF8 File Offset: 0x0087DEF8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_testGameObject(IntPtr l)
	{
		int result;
		try
		{
			BattlePrepareUIController battlePrepareUIController = (BattlePrepareUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, battlePrepareUIController.m_luaExportHelper.m_testGameObject);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601BCEF RID: 113903 RVA: 0x0087FD50 File Offset: 0x0087DF50
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_testGameObject(IntPtr l)
	{
		int result;
		try
		{
			BattlePrepareUIController battlePrepareUIController = (BattlePrepareUIController)LuaObject.checkSelf(l);
			GameObject testGameObject;
			LuaObject.checkType<GameObject>(l, 2, out testGameObject);
			battlePrepareUIController.m_luaExportHelper.m_testGameObject = testGameObject;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601BCF0 RID: 113904 RVA: 0x0087FDAC File Offset: 0x0087DFAC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_testOnStageToggle(IntPtr l)
	{
		int result;
		try
		{
			BattlePrepareUIController battlePrepareUIController = (BattlePrepareUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, battlePrepareUIController.m_luaExportHelper.m_testOnStageToggle);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601BCF1 RID: 113905 RVA: 0x0087FE04 File Offset: 0x0087E004
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_testOnStageToggle(IntPtr l)
	{
		int result;
		try
		{
			BattlePrepareUIController battlePrepareUIController = (BattlePrepareUIController)LuaObject.checkSelf(l);
			Toggle testOnStageToggle;
			LuaObject.checkType<Toggle>(l, 2, out testOnStageToggle);
			battlePrepareUIController.m_luaExportHelper.m_testOnStageToggle = testOnStageToggle;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601BCF2 RID: 113906 RVA: 0x0087FE60 File Offset: 0x0087E060
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_testSoldierInputField0(IntPtr l)
	{
		int result;
		try
		{
			BattlePrepareUIController battlePrepareUIController = (BattlePrepareUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, battlePrepareUIController.m_luaExportHelper.m_testSoldierInputField0);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601BCF3 RID: 113907 RVA: 0x0087FEB8 File Offset: 0x0087E0B8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_testSoldierInputField0(IntPtr l)
	{
		int result;
		try
		{
			BattlePrepareUIController battlePrepareUIController = (BattlePrepareUIController)LuaObject.checkSelf(l);
			InputField testSoldierInputField;
			LuaObject.checkType<InputField>(l, 2, out testSoldierInputField);
			battlePrepareUIController.m_luaExportHelper.m_testSoldierInputField0 = testSoldierInputField;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601BCF4 RID: 113908 RVA: 0x0087FF14 File Offset: 0x0087E114
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_testSoldierInputField1(IntPtr l)
	{
		int result;
		try
		{
			BattlePrepareUIController battlePrepareUIController = (BattlePrepareUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, battlePrepareUIController.m_luaExportHelper.m_testSoldierInputField1);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601BCF5 RID: 113909 RVA: 0x0087FF6C File Offset: 0x0087E16C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_testSoldierInputField1(IntPtr l)
	{
		int result;
		try
		{
			BattlePrepareUIController battlePrepareUIController = (BattlePrepareUIController)LuaObject.checkSelf(l);
			InputField testSoldierInputField;
			LuaObject.checkType<InputField>(l, 2, out testSoldierInputField);
			battlePrepareUIController.m_luaExportHelper.m_testSoldierInputField1 = testSoldierInputField;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601BCF6 RID: 113910 RVA: 0x0087FFC8 File Offset: 0x0087E1C8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_testSkillInputField0(IntPtr l)
	{
		int result;
		try
		{
			BattlePrepareUIController battlePrepareUIController = (BattlePrepareUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, battlePrepareUIController.m_luaExportHelper.m_testSkillInputField0);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601BCF7 RID: 113911 RVA: 0x00880020 File Offset: 0x0087E220
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_testSkillInputField0(IntPtr l)
	{
		int result;
		try
		{
			BattlePrepareUIController battlePrepareUIController = (BattlePrepareUIController)LuaObject.checkSelf(l);
			InputField testSkillInputField;
			LuaObject.checkType<InputField>(l, 2, out testSkillInputField);
			battlePrepareUIController.m_luaExportHelper.m_testSkillInputField0 = testSkillInputField;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601BCF8 RID: 113912 RVA: 0x0088007C File Offset: 0x0087E27C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_testSkillInputField1(IntPtr l)
	{
		int result;
		try
		{
			BattlePrepareUIController battlePrepareUIController = (BattlePrepareUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, battlePrepareUIController.m_luaExportHelper.m_testSkillInputField1);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601BCF9 RID: 113913 RVA: 0x008800D4 File Offset: 0x0087E2D4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_testSkillInputField1(IntPtr l)
	{
		int result;
		try
		{
			BattlePrepareUIController battlePrepareUIController = (BattlePrepareUIController)LuaObject.checkSelf(l);
			InputField testSkillInputField;
			LuaObject.checkType<InputField>(l, 2, out testSkillInputField);
			battlePrepareUIController.m_luaExportHelper.m_testSkillInputField1 = testSkillInputField;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601BCFA RID: 113914 RVA: 0x00880130 File Offset: 0x0087E330
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_testTalentInputField0(IntPtr l)
	{
		int result;
		try
		{
			BattlePrepareUIController battlePrepareUIController = (BattlePrepareUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, battlePrepareUIController.m_luaExportHelper.m_testTalentInputField0);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601BCFB RID: 113915 RVA: 0x00880188 File Offset: 0x0087E388
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_testTalentInputField0(IntPtr l)
	{
		int result;
		try
		{
			BattlePrepareUIController battlePrepareUIController = (BattlePrepareUIController)LuaObject.checkSelf(l);
			InputField testTalentInputField;
			LuaObject.checkType<InputField>(l, 2, out testTalentInputField);
			battlePrepareUIController.m_luaExportHelper.m_testTalentInputField0 = testTalentInputField;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601BCFC RID: 113916 RVA: 0x008801E4 File Offset: 0x0087E3E4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_testTalentInputField1(IntPtr l)
	{
		int result;
		try
		{
			BattlePrepareUIController battlePrepareUIController = (BattlePrepareUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, battlePrepareUIController.m_luaExportHelper.m_testTalentInputField1);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601BCFD RID: 113917 RVA: 0x0088023C File Offset: 0x0087E43C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_testTalentInputField1(IntPtr l)
	{
		int result;
		try
		{
			BattlePrepareUIController battlePrepareUIController = (BattlePrepareUIController)LuaObject.checkSelf(l);
			InputField testTalentInputField;
			LuaObject.checkType<InputField>(l, 2, out testTalentInputField);
			battlePrepareUIController.m_luaExportHelper.m_testTalentInputField1 = testTalentInputField;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601BCFE RID: 113918 RVA: 0x00880298 File Offset: 0x0087E498
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_actorListScrollRect(IntPtr l)
	{
		int result;
		try
		{
			BattlePrepareUIController battlePrepareUIController = (BattlePrepareUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, battlePrepareUIController.m_luaExportHelper.m_actorListScrollRect);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601BCFF RID: 113919 RVA: 0x008802F0 File Offset: 0x0087E4F0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_actorListScrollRect(IntPtr l)
	{
		int result;
		try
		{
			BattlePrepareUIController battlePrepareUIController = (BattlePrepareUIController)LuaObject.checkSelf(l);
			ScrollRect actorListScrollRect;
			LuaObject.checkType<ScrollRect>(l, 2, out actorListScrollRect);
			battlePrepareUIController.m_luaExportHelper.m_actorListScrollRect = actorListScrollRect;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601BD00 RID: 113920 RVA: 0x0088034C File Offset: 0x0087E54C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_actorListDisableGameObject(IntPtr l)
	{
		int result;
		try
		{
			BattlePrepareUIController battlePrepareUIController = (BattlePrepareUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, battlePrepareUIController.m_luaExportHelper.m_actorListDisableGameObject);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601BD01 RID: 113921 RVA: 0x008803A4 File Offset: 0x0087E5A4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_actorListDisableGameObject(IntPtr l)
	{
		int result;
		try
		{
			BattlePrepareUIController battlePrepareUIController = (BattlePrepareUIController)LuaObject.checkSelf(l);
			GameObject actorListDisableGameObject;
			LuaObject.checkType<GameObject>(l, 2, out actorListDisableGameObject);
			battlePrepareUIController.m_luaExportHelper.m_actorListDisableGameObject = actorListDisableGameObject;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601BD02 RID: 113922 RVA: 0x00880400 File Offset: 0x0087E600
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_terrainInfoGameObject(IntPtr l)
	{
		int result;
		try
		{
			BattlePrepareUIController battlePrepareUIController = (BattlePrepareUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, battlePrepareUIController.m_luaExportHelper.m_terrainInfoGameObject);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601BD03 RID: 113923 RVA: 0x00880458 File Offset: 0x0087E658
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_terrainInfoGameObject(IntPtr l)
	{
		int result;
		try
		{
			BattlePrepareUIController battlePrepareUIController = (BattlePrepareUIController)LuaObject.checkSelf(l);
			GameObject terrainInfoGameObject;
			LuaObject.checkType<GameObject>(l, 2, out terrainInfoGameObject);
			battlePrepareUIController.m_luaExportHelper.m_terrainInfoGameObject = terrainInfoGameObject;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601BD04 RID: 113924 RVA: 0x008804B4 File Offset: 0x0087E6B4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_terrainInfoText(IntPtr l)
	{
		int result;
		try
		{
			BattlePrepareUIController battlePrepareUIController = (BattlePrepareUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, battlePrepareUIController.m_luaExportHelper.m_terrainInfoText);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601BD05 RID: 113925 RVA: 0x0088050C File Offset: 0x0087E70C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_terrainInfoText(IntPtr l)
	{
		int result;
		try
		{
			BattlePrepareUIController battlePrepareUIController = (BattlePrepareUIController)LuaObject.checkSelf(l);
			Text terrainInfoText;
			LuaObject.checkType<Text>(l, 2, out terrainInfoText);
			battlePrepareUIController.m_luaExportHelper.m_terrainInfoText = terrainInfoText;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601BD06 RID: 113926 RVA: 0x00880568 File Offset: 0x0087E768
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_terrainInfoImage(IntPtr l)
	{
		int result;
		try
		{
			BattlePrepareUIController battlePrepareUIController = (BattlePrepareUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, battlePrepareUIController.m_luaExportHelper.m_terrainInfoImage);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601BD07 RID: 113927 RVA: 0x008805C0 File Offset: 0x0087E7C0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_terrainInfoImage(IntPtr l)
	{
		int result;
		try
		{
			BattlePrepareUIController battlePrepareUIController = (BattlePrepareUIController)LuaObject.checkSelf(l);
			Image terrainInfoImage;
			LuaObject.checkType<Image>(l, 2, out terrainInfoImage);
			battlePrepareUIController.m_luaExportHelper.m_terrainInfoImage = terrainInfoImage;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601BD08 RID: 113928 RVA: 0x0088061C File Offset: 0x0087E81C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_terrainInfoDefText(IntPtr l)
	{
		int result;
		try
		{
			BattlePrepareUIController battlePrepareUIController = (BattlePrepareUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, battlePrepareUIController.m_luaExportHelper.m_terrainInfoDefText);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601BD09 RID: 113929 RVA: 0x00880674 File Offset: 0x0087E874
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_terrainInfoDefText(IntPtr l)
	{
		int result;
		try
		{
			BattlePrepareUIController battlePrepareUIController = (BattlePrepareUIController)LuaObject.checkSelf(l);
			Text terrainInfoDefText;
			LuaObject.checkType<Text>(l, 2, out terrainInfoDefText);
			battlePrepareUIController.m_luaExportHelper.m_terrainInfoDefText = terrainInfoDefText;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601BD0A RID: 113930 RVA: 0x008806D0 File Offset: 0x0087E8D0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_prefabsGameObject(IntPtr l)
	{
		int result;
		try
		{
			BattlePrepareUIController battlePrepareUIController = (BattlePrepareUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, battlePrepareUIController.m_luaExportHelper.m_prefabsGameObject);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601BD0B RID: 113931 RVA: 0x00880728 File Offset: 0x0087E928
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_m_prefabsGameObject(IntPtr l)
	{
		int result;
		try
		{
			BattlePrepareUIController battlePrepareUIController = (BattlePrepareUIController)LuaObject.checkSelf(l);
			GameObject prefabsGameObject;
			LuaObject.checkType<GameObject>(l, 2, out prefabsGameObject);
			battlePrepareUIController.m_luaExportHelper.m_prefabsGameObject = prefabsGameObject;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601BD0C RID: 113932 RVA: 0x00880784 File Offset: 0x0087E984
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_heroButtonPrefab(IntPtr l)
	{
		int result;
		try
		{
			BattlePrepareUIController battlePrepareUIController = (BattlePrepareUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, battlePrepareUIController.m_luaExportHelper.m_heroButtonPrefab);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601BD0D RID: 113933 RVA: 0x008807DC File Offset: 0x0087E9DC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_heroButtonPrefab(IntPtr l)
	{
		int result;
		try
		{
			BattlePrepareUIController battlePrepareUIController = (BattlePrepareUIController)LuaObject.checkSelf(l);
			GameObject heroButtonPrefab;
			LuaObject.checkType<GameObject>(l, 2, out heroButtonPrefab);
			battlePrepareUIController.m_luaExportHelper.m_heroButtonPrefab = heroButtonPrefab;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601BD0E RID: 113934 RVA: 0x00880838 File Offset: 0x0087EA38
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_armyRelationButtonUIStateController(IntPtr l)
	{
		int result;
		try
		{
			BattlePrepareUIController battlePrepareUIController = (BattlePrepareUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, battlePrepareUIController.m_luaExportHelper.m_armyRelationButtonUIStateController);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601BD0F RID: 113935 RVA: 0x00880890 File Offset: 0x0087EA90
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_armyRelationButtonUIStateController(IntPtr l)
	{
		int result;
		try
		{
			BattlePrepareUIController battlePrepareUIController = (BattlePrepareUIController)LuaObject.checkSelf(l);
			CommonUIStateController armyRelationButtonUIStateController;
			LuaObject.checkType<CommonUIStateController>(l, 2, out armyRelationButtonUIStateController);
			battlePrepareUIController.m_luaExportHelper.m_armyRelationButtonUIStateController = armyRelationButtonUIStateController;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601BD10 RID: 113936 RVA: 0x008808EC File Offset: 0x0087EAEC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_armyRelationDescUIStateController(IntPtr l)
	{
		int result;
		try
		{
			BattlePrepareUIController battlePrepareUIController = (BattlePrepareUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, battlePrepareUIController.m_luaExportHelper.m_armyRelationDescUIStateController);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601BD11 RID: 113937 RVA: 0x00880944 File Offset: 0x0087EB44
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_armyRelationDescUIStateController(IntPtr l)
	{
		int result;
		try
		{
			BattlePrepareUIController battlePrepareUIController = (BattlePrepareUIController)LuaObject.checkSelf(l);
			CommonUIStateController armyRelationDescUIStateController;
			LuaObject.checkType<CommonUIStateController>(l, 2, out armyRelationDescUIStateController);
			battlePrepareUIController.m_luaExportHelper.m_armyRelationDescUIStateController = armyRelationDescUIStateController;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601BD12 RID: 113938 RVA: 0x008809A0 File Offset: 0x0087EBA0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_clientBattle(IntPtr l)
	{
		int result;
		try
		{
			BattlePrepareUIController battlePrepareUIController = (BattlePrepareUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, battlePrepareUIController.m_luaExportHelper.m_clientBattle);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601BD13 RID: 113939 RVA: 0x008809F8 File Offset: 0x0087EBF8
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_m_clientBattle(IntPtr l)
	{
		int result;
		try
		{
			BattlePrepareUIController battlePrepareUIController = (BattlePrepareUIController)LuaObject.checkSelf(l);
			ClientBattle clientBattle;
			LuaObject.checkType<ClientBattle>(l, 2, out clientBattle);
			battlePrepareUIController.m_luaExportHelper.m_clientBattle = clientBattle;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601BD14 RID: 113940 RVA: 0x00880A54 File Offset: 0x0087EC54
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_camera(IntPtr l)
	{
		int result;
		try
		{
			BattlePrepareUIController battlePrepareUIController = (BattlePrepareUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, battlePrepareUIController.m_luaExportHelper.m_camera);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601BD15 RID: 113941 RVA: 0x00880AAC File Offset: 0x0087ECAC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_camera(IntPtr l)
	{
		int result;
		try
		{
			BattlePrepareUIController battlePrepareUIController = (BattlePrepareUIController)LuaObject.checkSelf(l);
			Camera camera;
			LuaObject.checkType<Camera>(l, 2, out camera);
			battlePrepareUIController.m_luaExportHelper.m_camera = camera;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601BD16 RID: 113942 RVA: 0x00880B08 File Offset: 0x0087ED08
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_chatRedPointLastTime(IntPtr l)
	{
		int result;
		try
		{
			BattlePrepareUIController battlePrepareUIController = (BattlePrepareUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, battlePrepareUIController.m_luaExportHelper.m_chatRedPointLastTime);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601BD17 RID: 113943 RVA: 0x00880B60 File Offset: 0x0087ED60
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_chatRedPointLastTime(IntPtr l)
	{
		int result;
		try
		{
			BattlePrepareUIController battlePrepareUIController = (BattlePrepareUIController)LuaObject.checkSelf(l);
			float chatRedPointLastTime;
			LuaObject.checkType(l, 2, out chatRedPointLastTime);
			battlePrepareUIController.m_luaExportHelper.m_chatRedPointLastTime = chatRedPointLastTime;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601BD18 RID: 113944 RVA: 0x00880BBC File Offset: 0x0087EDBC
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_m_isIgnorePointerClick(IntPtr l)
	{
		int result;
		try
		{
			BattlePrepareUIController battlePrepareUIController = (BattlePrepareUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, battlePrepareUIController.m_luaExportHelper.m_isIgnorePointerClick);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601BD19 RID: 113945 RVA: 0x00880C14 File Offset: 0x0087EE14
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_isIgnorePointerClick(IntPtr l)
	{
		int result;
		try
		{
			BattlePrepareUIController battlePrepareUIController = (BattlePrepareUIController)LuaObject.checkSelf(l);
			bool isIgnorePointerClick;
			LuaObject.checkType(l, 2, out isIgnorePointerClick);
			battlePrepareUIController.m_luaExportHelper.m_isIgnorePointerClick = isIgnorePointerClick;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601BD1A RID: 113946 RVA: 0x00880C70 File Offset: 0x0087EE70
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_pointerDownStageActor(IntPtr l)
	{
		int result;
		try
		{
			BattlePrepareUIController battlePrepareUIController = (BattlePrepareUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, battlePrepareUIController.m_luaExportHelper.m_pointerDownStageActor);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601BD1B RID: 113947 RVA: 0x00880CC8 File Offset: 0x0087EEC8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_pointerDownStageActor(IntPtr l)
	{
		int result;
		try
		{
			BattlePrepareUIController battlePrepareUIController = (BattlePrepareUIController)LuaObject.checkSelf(l);
			BattlePrepareStageActor pointerDownStageActor;
			LuaObject.checkType<BattlePrepareStageActor>(l, 2, out pointerDownStageActor);
			battlePrepareUIController.m_luaExportHelper.m_pointerDownStageActor = pointerDownStageActor;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601BD1C RID: 113948 RVA: 0x00880D24 File Offset: 0x0087EF24
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_isIgnoreToggleEvent(IntPtr l)
	{
		int result;
		try
		{
			BattlePrepareUIController battlePrepareUIController = (BattlePrepareUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, battlePrepareUIController.m_luaExportHelper.m_isIgnoreToggleEvent);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601BD1D RID: 113949 RVA: 0x00880D7C File Offset: 0x0087EF7C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_isIgnoreToggleEvent(IntPtr l)
	{
		int result;
		try
		{
			BattlePrepareUIController battlePrepareUIController = (BattlePrepareUIController)LuaObject.checkSelf(l);
			bool isIgnoreToggleEvent;
			LuaObject.checkType(l, 2, out isIgnoreToggleEvent);
			battlePrepareUIController.m_luaExportHelper.m_isIgnoreToggleEvent = isIgnoreToggleEvent;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601BD1E RID: 113950 RVA: 0x00880DD8 File Offset: 0x0087EFD8
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_m_isSkipStageActorGraphic(IntPtr l)
	{
		int result;
		try
		{
			BattlePrepareUIController battlePrepareUIController = (BattlePrepareUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, battlePrepareUIController.m_luaExportHelper.m_isSkipStageActorGraphic);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601BD1F RID: 113951 RVA: 0x00880E30 File Offset: 0x0087F030
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_isSkipStageActorGraphic(IntPtr l)
	{
		int result;
		try
		{
			BattlePrepareUIController battlePrepareUIController = (BattlePrepareUIController)LuaObject.checkSelf(l);
			bool isSkipStageActorGraphic;
			LuaObject.checkType(l, 2, out isSkipStageActorGraphic);
			battlePrepareUIController.m_luaExportHelper.m_isSkipStageActorGraphic = isSkipStageActorGraphic;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601BD20 RID: 113952 RVA: 0x00880E8C File Offset: 0x0087F08C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_stageActorCountMax(IntPtr l)
	{
		int result;
		try
		{
			BattlePrepareUIController battlePrepareUIController = (BattlePrepareUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, battlePrepareUIController.m_luaExportHelper.m_stageActorCountMax);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601BD21 RID: 113953 RVA: 0x00880EE4 File Offset: 0x0087F0E4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_stageActorCountMax(IntPtr l)
	{
		int result;
		try
		{
			BattlePrepareUIController battlePrepareUIController = (BattlePrepareUIController)LuaObject.checkSelf(l);
			int stageActorCountMax;
			LuaObject.checkType(l, 2, out stageActorCountMax);
			battlePrepareUIController.m_luaExportHelper.m_stageActorCountMax = stageActorCountMax;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601BD22 RID: 113954 RVA: 0x00880F40 File Offset: 0x0087F140
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_turnStageActorCountMax(IntPtr l)
	{
		int result;
		try
		{
			BattlePrepareUIController battlePrepareUIController = (BattlePrepareUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, battlePrepareUIController.m_luaExportHelper.m_turnStageActorCountMax);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601BD23 RID: 113955 RVA: 0x00880F98 File Offset: 0x0087F198
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_turnStageActorCountMax(IntPtr l)
	{
		int result;
		try
		{
			BattlePrepareUIController battlePrepareUIController = (BattlePrepareUIController)LuaObject.checkSelf(l);
			int turnStageActorCountMax;
			LuaObject.checkType(l, 2, out turnStageActorCountMax);
			battlePrepareUIController.m_luaExportHelper.m_turnStageActorCountMax = turnStageActorCountMax;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601BD24 RID: 113956 RVA: 0x00880FF4 File Offset: 0x0087F1F4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_isStageActorChanged(IntPtr l)
	{
		int result;
		try
		{
			BattlePrepareUIController battlePrepareUIController = (BattlePrepareUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, battlePrepareUIController.m_luaExportHelper.m_isStageActorChanged);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601BD25 RID: 113957 RVA: 0x0088104C File Offset: 0x0087F24C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_isStageActorChanged(IntPtr l)
	{
		int result;
		try
		{
			BattlePrepareUIController battlePrepareUIController = (BattlePrepareUIController)LuaObject.checkSelf(l);
			bool isStageActorChanged;
			LuaObject.checkType(l, 2, out isStageActorChanged);
			battlePrepareUIController.m_luaExportHelper.m_isStageActorChanged = isStageActorChanged;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601BD26 RID: 113958 RVA: 0x008810A8 File Offset: 0x0087F2A8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_heroButtons(IntPtr l)
	{
		int result;
		try
		{
			BattlePrepareUIController battlePrepareUIController = (BattlePrepareUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, battlePrepareUIController.m_luaExportHelper.m_heroButtons);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601BD27 RID: 113959 RVA: 0x00881100 File Offset: 0x0087F300
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_heroButtons(IntPtr l)
	{
		int result;
		try
		{
			BattlePrepareUIController battlePrepareUIController = (BattlePrepareUIController)LuaObject.checkSelf(l);
			List<HeroDragButton> heroButtons;
			LuaObject.checkType<List<HeroDragButton>>(l, 2, out heroButtons);
			battlePrepareUIController.m_luaExportHelper.m_heroButtons = heroButtons;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601BD28 RID: 113960 RVA: 0x0088115C File Offset: 0x0087F35C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_stageActors(IntPtr l)
	{
		int result;
		try
		{
			BattlePrepareUIController battlePrepareUIController = (BattlePrepareUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, battlePrepareUIController.m_luaExportHelper.m_stageActors);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601BD29 RID: 113961 RVA: 0x008811B4 File Offset: 0x0087F3B4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_stageActors(IntPtr l)
	{
		int result;
		try
		{
			BattlePrepareUIController battlePrepareUIController = (BattlePrepareUIController)LuaObject.checkSelf(l);
			List<BattlePrepareStageActor> stageActors;
			LuaObject.checkType<List<BattlePrepareStageActor>>(l, 2, out stageActors);
			battlePrepareUIController.m_luaExportHelper.m_stageActors = stageActors;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601BD2A RID: 113962 RVA: 0x00881210 File Offset: 0x0087F410
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_treasures(IntPtr l)
	{
		int result;
		try
		{
			BattlePrepareUIController battlePrepareUIController = (BattlePrepareUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, battlePrepareUIController.m_luaExportHelper.m_treasures);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601BD2B RID: 113963 RVA: 0x00881268 File Offset: 0x0087F468
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_treasures(IntPtr l)
	{
		int result;
		try
		{
			BattlePrepareUIController battlePrepareUIController = (BattlePrepareUIController)LuaObject.checkSelf(l);
			List<BattlePrepareTreasure> treasures;
			LuaObject.checkType<List<BattlePrepareTreasure>>(l, 2, out treasures);
			battlePrepareUIController.m_luaExportHelper.m_treasures = treasures;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601BD2C RID: 113964 RVA: 0x008812C4 File Offset: 0x0087F4C4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_stagePositions(IntPtr l)
	{
		int result;
		try
		{
			BattlePrepareUIController battlePrepareUIController = (BattlePrepareUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, battlePrepareUIController.m_luaExportHelper.m_stagePositions);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601BD2D RID: 113965 RVA: 0x0088131C File Offset: 0x0087F51C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_stagePositions(IntPtr l)
	{
		int result;
		try
		{
			BattlePrepareUIController battlePrepareUIController = (BattlePrepareUIController)LuaObject.checkSelf(l);
			List<GridPosition>[] stagePositions;
			LuaObject.checkArray<List<GridPosition>>(l, 2, out stagePositions);
			battlePrepareUIController.m_luaExportHelper.m_stagePositions = stagePositions;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601BD2E RID: 113966 RVA: 0x00881378 File Offset: 0x0087F578
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_stageDirs(IntPtr l)
	{
		int result;
		try
		{
			BattlePrepareUIController battlePrepareUIController = (BattlePrepareUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, battlePrepareUIController.m_luaExportHelper.m_stageDirs);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601BD2F RID: 113967 RVA: 0x008813D0 File Offset: 0x0087F5D0
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_m_stageDirs(IntPtr l)
	{
		int result;
		try
		{
			BattlePrepareUIController battlePrepareUIController = (BattlePrepareUIController)LuaObject.checkSelf(l);
			List<int>[] stageDirs;
			LuaObject.checkArray<List<int>>(l, 2, out stageDirs);
			battlePrepareUIController.m_luaExportHelper.m_stageDirs = stageDirs;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601BD30 RID: 113968 RVA: 0x0088142C File Offset: 0x0087F62C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_draggingHeroButton(IntPtr l)
	{
		int result;
		try
		{
			BattlePrepareUIController battlePrepareUIController = (BattlePrepareUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, battlePrepareUIController.m_luaExportHelper.m_draggingHeroButton);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601BD31 RID: 113969 RVA: 0x00881484 File Offset: 0x0087F684
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_draggingHeroButton(IntPtr l)
	{
		int result;
		try
		{
			BattlePrepareUIController battlePrepareUIController = (BattlePrepareUIController)LuaObject.checkSelf(l);
			HeroDragButton draggingHeroButton;
			LuaObject.checkType<HeroDragButton>(l, 2, out draggingHeroButton);
			battlePrepareUIController.m_luaExportHelper.m_draggingHeroButton = draggingHeroButton;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601BD32 RID: 113970 RVA: 0x008814E0 File Offset: 0x0087F6E0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_s_testSoldierCount0(IntPtr l)
	{
		int result;
		try
		{
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, BattlePrepareUIController.LuaExportHelper.s_testSoldierCount0);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601BD33 RID: 113971 RVA: 0x00881528 File Offset: 0x0087F728
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_s_testSoldierCount0(IntPtr l)
	{
		int result;
		try
		{
			int s_testSoldierCount;
			LuaObject.checkType(l, 2, out s_testSoldierCount);
			BattlePrepareUIController.LuaExportHelper.s_testSoldierCount0 = s_testSoldierCount;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601BD34 RID: 113972 RVA: 0x00881574 File Offset: 0x0087F774
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_s_testSoldierCount1(IntPtr l)
	{
		int result;
		try
		{
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, BattlePrepareUIController.LuaExportHelper.s_testSoldierCount1);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601BD35 RID: 113973 RVA: 0x008815BC File Offset: 0x0087F7BC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_s_testSoldierCount1(IntPtr l)
	{
		int result;
		try
		{
			int s_testSoldierCount;
			LuaObject.checkType(l, 2, out s_testSoldierCount);
			BattlePrepareUIController.LuaExportHelper.s_testSoldierCount1 = s_testSoldierCount;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601BD36 RID: 113974 RVA: 0x00881608 File Offset: 0x0087F808
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_s_testSkillId0(IntPtr l)
	{
		int result;
		try
		{
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, BattlePrepareUIController.LuaExportHelper.s_testSkillId0);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601BD37 RID: 113975 RVA: 0x00881650 File Offset: 0x0087F850
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_s_testSkillId0(IntPtr l)
	{
		int result;
		try
		{
			int s_testSkillId;
			LuaObject.checkType(l, 2, out s_testSkillId);
			BattlePrepareUIController.LuaExportHelper.s_testSkillId0 = s_testSkillId;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601BD38 RID: 113976 RVA: 0x0088169C File Offset: 0x0087F89C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_s_testSkillId1(IntPtr l)
	{
		int result;
		try
		{
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, BattlePrepareUIController.LuaExportHelper.s_testSkillId1);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601BD39 RID: 113977 RVA: 0x008816E4 File Offset: 0x0087F8E4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_s_testSkillId1(IntPtr l)
	{
		int result;
		try
		{
			int s_testSkillId;
			LuaObject.checkType(l, 2, out s_testSkillId);
			BattlePrepareUIController.LuaExportHelper.s_testSkillId1 = s_testSkillId;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601BD3A RID: 113978 RVA: 0x00881730 File Offset: 0x0087F930
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_s_testTalentId0(IntPtr l)
	{
		int result;
		try
		{
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, BattlePrepareUIController.LuaExportHelper.s_testTalentId0);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601BD3B RID: 113979 RVA: 0x00881778 File Offset: 0x0087F978
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_s_testTalentId0(IntPtr l)
	{
		int result;
		try
		{
			int s_testTalentId;
			LuaObject.checkType(l, 2, out s_testTalentId);
			BattlePrepareUIController.LuaExportHelper.s_testTalentId0 = s_testTalentId;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601BD3C RID: 113980 RVA: 0x008817C4 File Offset: 0x0087F9C4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_s_testTalentId1(IntPtr l)
	{
		int result;
		try
		{
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, BattlePrepareUIController.LuaExportHelper.s_testTalentId1);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601BD3D RID: 113981 RVA: 0x0088180C File Offset: 0x0087FA0C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_s_testTalentId1(IntPtr l)
	{
		int result;
		try
		{
			int s_testTalentId;
			LuaObject.checkType(l, 2, out s_testTalentId);
			BattlePrepareUIController.LuaExportHelper.s_testTalentId1 = s_testTalentId;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601BD3E RID: 113982 RVA: 0x00881858 File Offset: 0x0087FA58
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_s_isTestOnStage(IntPtr l)
	{
		int result;
		try
		{
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, BattlePrepareUIController.LuaExportHelper.s_isTestOnStage);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601BD3F RID: 113983 RVA: 0x008818A0 File Offset: 0x0087FAA0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_s_isTestOnStage(IntPtr l)
	{
		int result;
		try
		{
			bool s_isTestOnStage;
			LuaObject.checkType(l, 2, out s_isTestOnStage);
			BattlePrepareUIController.LuaExportHelper.s_isTestOnStage = s_isTestOnStage;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601BD40 RID: 113984 RVA: 0x008818EC File Offset: 0x0087FAEC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_battlePowerValue(IntPtr l)
	{
		int result;
		try
		{
			BattlePrepareUIController battlePrepareUIController = (BattlePrepareUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, battlePrepareUIController.m_luaExportHelper.m_battlePowerValue);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601BD41 RID: 113985 RVA: 0x00881944 File Offset: 0x0087FB44
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_battlePowerValue(IntPtr l)
	{
		int result;
		try
		{
			BattlePrepareUIController battlePrepareUIController = (BattlePrepareUIController)LuaObject.checkSelf(l);
			int battlePowerValue;
			LuaObject.checkType(l, 2, out battlePowerValue);
			battlePrepareUIController.m_luaExportHelper.m_battlePowerValue = battlePowerValue;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601BD42 RID: 113986 RVA: 0x008819A0 File Offset: 0x0087FBA0
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_m_setBattlePowerValueCoroutine(IntPtr l)
	{
		int result;
		try
		{
			BattlePrepareUIController battlePrepareUIController = (BattlePrepareUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, battlePrepareUIController.m_luaExportHelper.m_setBattlePowerValueCoroutine);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601BD43 RID: 113987 RVA: 0x008819F8 File Offset: 0x0087FBF8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_setBattlePowerValueCoroutine(IntPtr l)
	{
		int result;
		try
		{
			BattlePrepareUIController battlePrepareUIController = (BattlePrepareUIController)LuaObject.checkSelf(l);
			Coroutine setBattlePowerValueCoroutine;
			LuaObject.checkType<Coroutine>(l, 2, out setBattlePowerValueCoroutine);
			battlePrepareUIController.m_luaExportHelper.m_setBattlePowerValueCoroutine = setBattlePowerValueCoroutine;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601BD44 RID: 113988 RVA: 0x00881A54 File Offset: 0x0087FC54
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_towerBattleRuleInfo(IntPtr l)
	{
		int result;
		try
		{
			BattlePrepareUIController battlePrepareUIController = (BattlePrepareUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, battlePrepareUIController.m_luaExportHelper.m_towerBattleRuleInfo);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601BD45 RID: 113989 RVA: 0x00881AAC File Offset: 0x0087FCAC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_towerBattleRuleInfo(IntPtr l)
	{
		int result;
		try
		{
			BattlePrepareUIController battlePrepareUIController = (BattlePrepareUIController)LuaObject.checkSelf(l);
			ConfigDataTowerBattleRuleInfo towerBattleRuleInfo;
			LuaObject.checkType<ConfigDataTowerBattleRuleInfo>(l, 2, out towerBattleRuleInfo);
			battlePrepareUIController.m_luaExportHelper.m_towerBattleRuleInfo = towerBattleRuleInfo;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601BD46 RID: 113990 RVA: 0x00881B08 File Offset: 0x0087FD08
	[Preserve]
	public static void reg(IntPtr l)
	{
		LuaObject.getTypeTable(l, "BlackJack.ProjectL.UI.BattlePrepareUIController");
		if (Lua_BlackJack_ProjectL_UI_BattlePrepareUIController.<>f__mg$cache0 == null)
		{
			Lua_BlackJack_ProjectL_UI_BattlePrepareUIController.<>f__mg$cache0 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattlePrepareUIController.Initialize);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_BattlePrepareUIController.<>f__mg$cache0);
		if (Lua_BlackJack_ProjectL_UI_BattlePrepareUIController.<>f__mg$cache1 == null)
		{
			Lua_BlackJack_ProjectL_UI_BattlePrepareUIController.<>f__mg$cache1 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattlePrepareUIController.CheckStageActorChange);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_BattlePrepareUIController.<>f__mg$cache1);
		if (Lua_BlackJack_ProjectL_UI_BattlePrepareUIController.<>f__mg$cache2 == null)
		{
			Lua_BlackJack_ProjectL_UI_BattlePrepareUIController.<>f__mg$cache2 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattlePrepareUIController.PrepareBattle);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_BattlePrepareUIController.<>f__mg$cache2);
		if (Lua_BlackJack_ProjectL_UI_BattlePrepareUIController.<>f__mg$cache3 == null)
		{
			Lua_BlackJack_ProjectL_UI_BattlePrepareUIController.<>f__mg$cache3 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattlePrepareUIController.Pause);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_BattlePrepareUIController.<>f__mg$cache3);
		if (Lua_BlackJack_ProjectL_UI_BattlePrepareUIController.<>f__mg$cache4 == null)
		{
			Lua_BlackJack_ProjectL_UI_BattlePrepareUIController.<>f__mg$cache4 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattlePrepareUIController.SetStageActorCountMax);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_BattlePrepareUIController.<>f__mg$cache4);
		if (Lua_BlackJack_ProjectL_UI_BattlePrepareUIController.<>f__mg$cache5 == null)
		{
			Lua_BlackJack_ProjectL_UI_BattlePrepareUIController.<>f__mg$cache5 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattlePrepareUIController.SetTurnStageActorCountMax);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_BattlePrepareUIController.<>f__mg$cache5);
		if (Lua_BlackJack_ProjectL_UI_BattlePrepareUIController.<>f__mg$cache6 == null)
		{
			Lua_BlackJack_ProjectL_UI_BattlePrepareUIController.<>f__mg$cache6 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattlePrepareUIController.ClearHeros);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_BattlePrepareUIController.<>f__mg$cache6);
		if (Lua_BlackJack_ProjectL_UI_BattlePrepareUIController.<>f__mg$cache7 == null)
		{
			Lua_BlackJack_ProjectL_UI_BattlePrepareUIController.<>f__mg$cache7 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattlePrepareUIController.AddHero);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_BattlePrepareUIController.<>f__mg$cache7);
		if (Lua_BlackJack_ProjectL_UI_BattlePrepareUIController.<>f__mg$cache8 == null)
		{
			Lua_BlackJack_ProjectL_UI_BattlePrepareUIController.<>f__mg$cache8 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattlePrepareUIController.ClearStagePositions);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_BattlePrepareUIController.<>f__mg$cache8);
		if (Lua_BlackJack_ProjectL_UI_BattlePrepareUIController.<>f__mg$cache9 == null)
		{
			Lua_BlackJack_ProjectL_UI_BattlePrepareUIController.<>f__mg$cache9 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattlePrepareUIController.AddStagePosition);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_BattlePrepareUIController.<>f__mg$cache9);
		if (Lua_BlackJack_ProjectL_UI_BattlePrepareUIController.<>f__mg$cacheA == null)
		{
			Lua_BlackJack_ProjectL_UI_BattlePrepareUIController.<>f__mg$cacheA = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattlePrepareUIController.GetStagePositions);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_BattlePrepareUIController.<>f__mg$cacheA);
		if (Lua_BlackJack_ProjectL_UI_BattlePrepareUIController.<>f__mg$cacheB == null)
		{
			Lua_BlackJack_ProjectL_UI_BattlePrepareUIController.<>f__mg$cacheB = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattlePrepareUIController.SkipStageActorGraphic);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_BattlePrepareUIController.<>f__mg$cacheB);
		if (Lua_BlackJack_ProjectL_UI_BattlePrepareUIController.<>f__mg$cacheC == null)
		{
			Lua_BlackJack_ProjectL_UI_BattlePrepareUIController.<>f__mg$cacheC = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattlePrepareUIController.EnableHeroOnStage);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_BattlePrepareUIController.<>f__mg$cacheC);
		if (Lua_BlackJack_ProjectL_UI_BattlePrepareUIController.<>f__mg$cacheD == null)
		{
			Lua_BlackJack_ProjectL_UI_BattlePrepareUIController.<>f__mg$cacheD = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattlePrepareUIController.HeroOnStage);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_BattlePrepareUIController.<>f__mg$cacheD);
		if (Lua_BlackJack_ProjectL_UI_BattlePrepareUIController.<>f__mg$cacheE == null)
		{
			Lua_BlackJack_ProjectL_UI_BattlePrepareUIController.<>f__mg$cacheE = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattlePrepareUIController.ActorOffStage);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_BattlePrepareUIController.<>f__mg$cacheE);
		if (Lua_BlackJack_ProjectL_UI_BattlePrepareUIController.<>f__mg$cacheF == null)
		{
			Lua_BlackJack_ProjectL_UI_BattlePrepareUIController.<>f__mg$cacheF = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattlePrepareUIController.ActorOnStageMove);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_BattlePrepareUIController.<>f__mg$cacheF);
		if (Lua_BlackJack_ProjectL_UI_BattlePrepareUIController.<>f__mg$cache10 == null)
		{
			Lua_BlackJack_ProjectL_UI_BattlePrepareUIController.<>f__mg$cache10 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattlePrepareUIController.ActorOnStageExchange);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_BattlePrepareUIController.<>f__mg$cache10);
		if (Lua_BlackJack_ProjectL_UI_BattlePrepareUIController.<>f__mg$cache11 == null)
		{
			Lua_BlackJack_ProjectL_UI_BattlePrepareUIController.<>f__mg$cache11 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattlePrepareUIController.ClearStageActors);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_BattlePrepareUIController.<>f__mg$cache11);
		if (Lua_BlackJack_ProjectL_UI_BattlePrepareUIController.<>f__mg$cache12 == null)
		{
			Lua_BlackJack_ProjectL_UI_BattlePrepareUIController.<>f__mg$cache12 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattlePrepareUIController.GetStageActor);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_BattlePrepareUIController.<>f__mg$cache12);
		if (Lua_BlackJack_ProjectL_UI_BattlePrepareUIController.<>f__mg$cache13 == null)
		{
			Lua_BlackJack_ProjectL_UI_BattlePrepareUIController.<>f__mg$cache13 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattlePrepareUIController.GetStageActorByHeroId);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_BattlePrepareUIController.<>f__mg$cache13);
		if (Lua_BlackJack_ProjectL_UI_BattlePrepareUIController.<>f__mg$cache14 == null)
		{
			Lua_BlackJack_ProjectL_UI_BattlePrepareUIController.<>f__mg$cache14 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattlePrepareUIController.GetStageActors);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_BattlePrepareUIController.<>f__mg$cache14);
		if (Lua_BlackJack_ProjectL_UI_BattlePrepareUIController.<>f__mg$cache15 == null)
		{
			Lua_BlackJack_ProjectL_UI_BattlePrepareUIController.<>f__mg$cache15 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattlePrepareUIController.UpdateStageActor);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_BattlePrepareUIController.<>f__mg$cache15);
		if (Lua_BlackJack_ProjectL_UI_BattlePrepareUIController.<>f__mg$cache16 == null)
		{
			Lua_BlackJack_ProjectL_UI_BattlePrepareUIController.<>f__mg$cache16 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattlePrepareUIController.AddBattleTreasure);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_BattlePrepareUIController.<>f__mg$cache16);
		if (Lua_BlackJack_ProjectL_UI_BattlePrepareUIController.<>f__mg$cache17 == null)
		{
			Lua_BlackJack_ProjectL_UI_BattlePrepareUIController.<>f__mg$cache17 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattlePrepareUIController.ClearBattleTreasures);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_BattlePrepareUIController.<>f__mg$cache17);
		if (Lua_BlackJack_ProjectL_UI_BattlePrepareUIController.<>f__mg$cache18 == null)
		{
			Lua_BlackJack_ProjectL_UI_BattlePrepareUIController.<>f__mg$cache18 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattlePrepareUIController.ShowTerrainInfo);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_BattlePrepareUIController.<>f__mg$cache18);
		if (Lua_BlackJack_ProjectL_UI_BattlePrepareUIController.<>f__mg$cache19 == null)
		{
			Lua_BlackJack_ProjectL_UI_BattlePrepareUIController.<>f__mg$cache19 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattlePrepareUIController.HideTerrainInfo);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_BattlePrepareUIController.<>f__mg$cache19);
		if (Lua_BlackJack_ProjectL_UI_BattlePrepareUIController.<>f__mg$cache1A == null)
		{
			Lua_BlackJack_ProjectL_UI_BattlePrepareUIController.<>f__mg$cache1A = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattlePrepareUIController.ShowArmyRelationDesc);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_BattlePrepareUIController.<>f__mg$cache1A);
		if (Lua_BlackJack_ProjectL_UI_BattlePrepareUIController.<>f__mg$cache1B == null)
		{
			Lua_BlackJack_ProjectL_UI_BattlePrepareUIController.<>f__mg$cache1B = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattlePrepareUIController.HideArmyRelationDesc);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_BattlePrepareUIController.<>f__mg$cache1B);
		if (Lua_BlackJack_ProjectL_UI_BattlePrepareUIController.<>f__mg$cache1C == null)
		{
			Lua_BlackJack_ProjectL_UI_BattlePrepareUIController.<>f__mg$cache1C = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattlePrepareUIController.IsArmyRelationDescVisible);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_BattlePrepareUIController.<>f__mg$cache1C);
		if (Lua_BlackJack_ProjectL_UI_BattlePrepareUIController.<>f__mg$cache1D == null)
		{
			Lua_BlackJack_ProjectL_UI_BattlePrepareUIController.<>f__mg$cache1D = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattlePrepareUIController.ShowClimbTowerBattleRule);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_BattlePrepareUIController.<>f__mg$cache1D);
		if (Lua_BlackJack_ProjectL_UI_BattlePrepareUIController.<>f__mg$cache1E == null)
		{
			Lua_BlackJack_ProjectL_UI_BattlePrepareUIController.<>f__mg$cache1E = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattlePrepareUIController.HideClimbTowerBattleRule);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_BattlePrepareUIController.<>f__mg$cache1E);
		if (Lua_BlackJack_ProjectL_UI_BattlePrepareUIController.<>f__mg$cache1F == null)
		{
			Lua_BlackJack_ProjectL_UI_BattlePrepareUIController.<>f__mg$cache1F = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattlePrepareUIController.ShowActionOrderButton);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_BattlePrepareUIController.<>f__mg$cache1F);
		if (Lua_BlackJack_ProjectL_UI_BattlePrepareUIController.<>f__mg$cache20 == null)
		{
			Lua_BlackJack_ProjectL_UI_BattlePrepareUIController.<>f__mg$cache20 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattlePrepareUIController.ShowChatButton);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_BattlePrepareUIController.<>f__mg$cache20);
		if (Lua_BlackJack_ProjectL_UI_BattlePrepareUIController.<>f__mg$cache21 == null)
		{
			Lua_BlackJack_ProjectL_UI_BattlePrepareUIController.<>f__mg$cache21 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattlePrepareUIController.SetBattlePower);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_BattlePrepareUIController.<>f__mg$cache21);
		if (Lua_BlackJack_ProjectL_UI_BattlePrepareUIController.<>f__mg$cache22 == null)
		{
			Lua_BlackJack_ProjectL_UI_BattlePrepareUIController.<>f__mg$cache22 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattlePrepareUIController.ShowStartButton);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_BattlePrepareUIController.<>f__mg$cache22);
		if (Lua_BlackJack_ProjectL_UI_BattlePrepareUIController.<>f__mg$cache23 == null)
		{
			Lua_BlackJack_ProjectL_UI_BattlePrepareUIController.<>f__mg$cache23 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattlePrepareUIController.ShowTeamReadyCountdown);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_BattlePrepareUIController.<>f__mg$cache23);
		if (Lua_BlackJack_ProjectL_UI_BattlePrepareUIController.<>f__mg$cache24 == null)
		{
			Lua_BlackJack_ProjectL_UI_BattlePrepareUIController.<>f__mg$cache24 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattlePrepareUIController.ShowTeamReadyWait);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_BattlePrepareUIController.<>f__mg$cache24);
		if (Lua_BlackJack_ProjectL_UI_BattlePrepareUIController.<>f__mg$cache25 == null)
		{
			Lua_BlackJack_ProjectL_UI_BattlePrepareUIController.<>f__mg$cache25 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattlePrepareUIController.IsTestBattle);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_BattlePrepareUIController.<>f__mg$cache25);
		if (Lua_BlackJack_ProjectL_UI_BattlePrepareUIController.<>f__mg$cache26 == null)
		{
			Lua_BlackJack_ProjectL_UI_BattlePrepareUIController.<>f__mg$cache26 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattlePrepareUIController.IsTestOnStage);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_BattlePrepareUIController.<>f__mg$cache26);
		if (Lua_BlackJack_ProjectL_UI_BattlePrepareUIController.<>f__mg$cache27 == null)
		{
			Lua_BlackJack_ProjectL_UI_BattlePrepareUIController.<>f__mg$cache27 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattlePrepareUIController.GetTestSoldierCount);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_BattlePrepareUIController.<>f__mg$cache27);
		if (Lua_BlackJack_ProjectL_UI_BattlePrepareUIController.<>f__mg$cache28 == null)
		{
			Lua_BlackJack_ProjectL_UI_BattlePrepareUIController.<>f__mg$cache28 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattlePrepareUIController.GetTestSkillId);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_BattlePrepareUIController.<>f__mg$cache28);
		if (Lua_BlackJack_ProjectL_UI_BattlePrepareUIController.<>f__mg$cache29 == null)
		{
			Lua_BlackJack_ProjectL_UI_BattlePrepareUIController.<>f__mg$cache29 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattlePrepareUIController.GetTestTalentId);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_BattlePrepareUIController.<>f__mg$cache29);
		if (Lua_BlackJack_ProjectL_UI_BattlePrepareUIController.<>f__mg$cache2A == null)
		{
			Lua_BlackJack_ProjectL_UI_BattlePrepareUIController.<>f__mg$cache2A = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattlePrepareUIController.OnScenePointerDown);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_BattlePrepareUIController.<>f__mg$cache2A);
		if (Lua_BlackJack_ProjectL_UI_BattlePrepareUIController.<>f__mg$cache2B == null)
		{
			Lua_BlackJack_ProjectL_UI_BattlePrepareUIController.<>f__mg$cache2B = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattlePrepareUIController.OnScenePointerUp);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_BattlePrepareUIController.<>f__mg$cache2B);
		if (Lua_BlackJack_ProjectL_UI_BattlePrepareUIController.<>f__mg$cache2C == null)
		{
			Lua_BlackJack_ProjectL_UI_BattlePrepareUIController.<>f__mg$cache2C = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattlePrepareUIController.OnScenePointerClick);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_BattlePrepareUIController.<>f__mg$cache2C);
		if (Lua_BlackJack_ProjectL_UI_BattlePrepareUIController.<>f__mg$cache2D == null)
		{
			Lua_BlackJack_ProjectL_UI_BattlePrepareUIController.<>f__mg$cache2D = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattlePrepareUIController.OnSceneBeginDrag);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_BattlePrepareUIController.<>f__mg$cache2D);
		if (Lua_BlackJack_ProjectL_UI_BattlePrepareUIController.<>f__mg$cache2E == null)
		{
			Lua_BlackJack_ProjectL_UI_BattlePrepareUIController.<>f__mg$cache2E = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattlePrepareUIController.OnSceneEndDrag);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_BattlePrepareUIController.<>f__mg$cache2E);
		if (Lua_BlackJack_ProjectL_UI_BattlePrepareUIController.<>f__mg$cache2F == null)
		{
			Lua_BlackJack_ProjectL_UI_BattlePrepareUIController.<>f__mg$cache2F = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattlePrepareUIController.OnSceneDrag);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_BattlePrepareUIController.<>f__mg$cache2F);
		if (Lua_BlackJack_ProjectL_UI_BattlePrepareUIController.<>f__mg$cache30 == null)
		{
			Lua_BlackJack_ProjectL_UI_BattlePrepareUIController.<>f__mg$cache30 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattlePrepareUIController.OnScene3DTouch);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_BattlePrepareUIController.<>f__mg$cache30);
		if (Lua_BlackJack_ProjectL_UI_BattlePrepareUIController.<>f__mg$cache31 == null)
		{
			Lua_BlackJack_ProjectL_UI_BattlePrepareUIController.<>f__mg$cache31 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattlePrepareUIController.DropHeroButton);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_BattlePrepareUIController.<>f__mg$cache31);
		if (Lua_BlackJack_ProjectL_UI_BattlePrepareUIController.<>f__mg$cache32 == null)
		{
			Lua_BlackJack_ProjectL_UI_BattlePrepareUIController.<>f__mg$cache32 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattlePrepareUIController.ComputeStageActorCount);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_BattlePrepareUIController.<>f__mg$cache32);
		if (Lua_BlackJack_ProjectL_UI_BattlePrepareUIController.<>f__mg$cache33 == null)
		{
			Lua_BlackJack_ProjectL_UI_BattlePrepareUIController.<>f__mg$cache33 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattlePrepareUIController.HeroDragButton_OnBeginDrag);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_BattlePrepareUIController.<>f__mg$cache33);
		if (Lua_BlackJack_ProjectL_UI_BattlePrepareUIController.<>f__mg$cache34 == null)
		{
			Lua_BlackJack_ProjectL_UI_BattlePrepareUIController.<>f__mg$cache34 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattlePrepareUIController.HeroDragButton_OnEndDrag);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_BattlePrepareUIController.<>f__mg$cache34);
		if (Lua_BlackJack_ProjectL_UI_BattlePrepareUIController.<>f__mg$cache35 == null)
		{
			Lua_BlackJack_ProjectL_UI_BattlePrepareUIController.<>f__mg$cache35 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattlePrepareUIController.HeroDragButton_OnDrag);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_BattlePrepareUIController.<>f__mg$cache35);
		if (Lua_BlackJack_ProjectL_UI_BattlePrepareUIController.<>f__mg$cache36 == null)
		{
			Lua_BlackJack_ProjectL_UI_BattlePrepareUIController.<>f__mg$cache36 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattlePrepareUIController.HeroDragButton_OnDrop);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_BattlePrepareUIController.<>f__mg$cache36);
		if (Lua_BlackJack_ProjectL_UI_BattlePrepareUIController.<>f__mg$cache37 == null)
		{
			Lua_BlackJack_ProjectL_UI_BattlePrepareUIController.<>f__mg$cache37 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattlePrepareUIController.HeroDragButton_OnClick);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_BattlePrepareUIController.<>f__mg$cache37);
		if (Lua_BlackJack_ProjectL_UI_BattlePrepareUIController.<>f__mg$cache38 == null)
		{
			Lua_BlackJack_ProjectL_UI_BattlePrepareUIController.<>f__mg$cache38 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattlePrepareUIController.RefreshChatRedState);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_BattlePrepareUIController.<>f__mg$cache38);
		if (Lua_BlackJack_ProjectL_UI_BattlePrepareUIController.<>f__mg$cache39 == null)
		{
			Lua_BlackJack_ProjectL_UI_BattlePrepareUIController.<>f__mg$cache39 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattlePrepareUIController.OnBindFiledsCompleted);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_BattlePrepareUIController.<>f__mg$cache39);
		if (Lua_BlackJack_ProjectL_UI_BattlePrepareUIController.<>f__mg$cache3A == null)
		{
			Lua_BlackJack_ProjectL_UI_BattlePrepareUIController.<>f__mg$cache3A = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattlePrepareUIController.OnDisable);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_BattlePrepareUIController.<>f__mg$cache3A);
		if (Lua_BlackJack_ProjectL_UI_BattlePrepareUIController.<>f__mg$cache3B == null)
		{
			Lua_BlackJack_ProjectL_UI_BattlePrepareUIController.<>f__mg$cache3B = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattlePrepareUIController.OnApplicationPause);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_BattlePrepareUIController.<>f__mg$cache3B);
		if (Lua_BlackJack_ProjectL_UI_BattlePrepareUIController.<>f__mg$cache3C == null)
		{
			Lua_BlackJack_ProjectL_UI_BattlePrepareUIController.<>f__mg$cache3C = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattlePrepareUIController.OnApplicationFocus);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_BattlePrepareUIController.<>f__mg$cache3C);
		if (Lua_BlackJack_ProjectL_UI_BattlePrepareUIController.<>f__mg$cache3D == null)
		{
			Lua_BlackJack_ProjectL_UI_BattlePrepareUIController.<>f__mg$cache3D = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattlePrepareUIController.CancelDragging);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_BattlePrepareUIController.<>f__mg$cache3D);
		if (Lua_BlackJack_ProjectL_UI_BattlePrepareUIController.<>f__mg$cache3E == null)
		{
			Lua_BlackJack_ProjectL_UI_BattlePrepareUIController.<>f__mg$cache3E = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattlePrepareUIController.Update);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_BattlePrepareUIController.<>f__mg$cache3E);
		if (Lua_BlackJack_ProjectL_UI_BattlePrepareUIController.<>f__mg$cache3F == null)
		{
			Lua_BlackJack_ProjectL_UI_BattlePrepareUIController.<>f__mg$cache3F = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattlePrepareUIController.GetStageDirection);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_BattlePrepareUIController.<>f__mg$cache3F);
		if (Lua_BlackJack_ProjectL_UI_BattlePrepareUIController.<>f__mg$cache40 == null)
		{
			Lua_BlackJack_ProjectL_UI_BattlePrepareUIController.<>f__mg$cache40 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattlePrepareUIController.CreateHeroButton);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_BattlePrepareUIController.<>f__mg$cache40);
		if (Lua_BlackJack_ProjectL_UI_BattlePrepareUIController.<>f__mg$cache41 == null)
		{
			Lua_BlackJack_ProjectL_UI_BattlePrepareUIController.<>f__mg$cache41 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattlePrepareUIController.SortChildByY);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_BattlePrepareUIController.<>f__mg$cache41);
		if (Lua_BlackJack_ProjectL_UI_BattlePrepareUIController.<>f__mg$cache42 == null)
		{
			Lua_BlackJack_ProjectL_UI_BattlePrepareUIController.<>f__mg$cache42 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattlePrepareUIController.ClearBattlePowerValue);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_BattlePrepareUIController.<>f__mg$cache42);
		if (Lua_BlackJack_ProjectL_UI_BattlePrepareUIController.<>f__mg$cache43 == null)
		{
			Lua_BlackJack_ProjectL_UI_BattlePrepareUIController.<>f__mg$cache43 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattlePrepareUIController.Co_SetBattlePowerValue);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_BattlePrepareUIController.<>f__mg$cache43);
		if (Lua_BlackJack_ProjectL_UI_BattlePrepareUIController.<>f__mg$cache44 == null)
		{
			Lua_BlackJack_ProjectL_UI_BattlePrepareUIController.<>f__mg$cache44 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattlePrepareUIController.UpdateTestValuesToInputField);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_BattlePrepareUIController.<>f__mg$cache44);
		if (Lua_BlackJack_ProjectL_UI_BattlePrepareUIController.<>f__mg$cache45 == null)
		{
			Lua_BlackJack_ProjectL_UI_BattlePrepareUIController.<>f__mg$cache45 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattlePrepareUIController.UpdateTestValuesFromInputField);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_BattlePrepareUIController.<>f__mg$cache45);
		if (Lua_BlackJack_ProjectL_UI_BattlePrepareUIController.<>f__mg$cache46 == null)
		{
			Lua_BlackJack_ProjectL_UI_BattlePrepareUIController.<>f__mg$cache46 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattlePrepareUIController.HideTeamReadyCountdown);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_BattlePrepareUIController.<>f__mg$cache46);
		if (Lua_BlackJack_ProjectL_UI_BattlePrepareUIController.<>f__mg$cache47 == null)
		{
			Lua_BlackJack_ProjectL_UI_BattlePrepareUIController.<>f__mg$cache47 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattlePrepareUIController.HideTeamReadyWait);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_BattlePrepareUIController.<>f__mg$cache47);
		if (Lua_BlackJack_ProjectL_UI_BattlePrepareUIController.<>f__mg$cache48 == null)
		{
			Lua_BlackJack_ProjectL_UI_BattlePrepareUIController.<>f__mg$cache48 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattlePrepareUIController.OnPauseButtonClick);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_BattlePrepareUIController.<>f__mg$cache48);
		if (Lua_BlackJack_ProjectL_UI_BattlePrepareUIController.<>f__mg$cache49 == null)
		{
			Lua_BlackJack_ProjectL_UI_BattlePrepareUIController.<>f__mg$cache49 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattlePrepareUIController.OnArmyRelationButtonClick);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_BattlePrepareUIController.<>f__mg$cache49);
		if (Lua_BlackJack_ProjectL_UI_BattlePrepareUIController.<>f__mg$cache4A == null)
		{
			Lua_BlackJack_ProjectL_UI_BattlePrepareUIController.<>f__mg$cache4A = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattlePrepareUIController.OnStartButtonClick);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_BattlePrepareUIController.<>f__mg$cache4A);
		if (Lua_BlackJack_ProjectL_UI_BattlePrepareUIController.<>f__mg$cache4B == null)
		{
			Lua_BlackJack_ProjectL_UI_BattlePrepareUIController.<>f__mg$cache4B = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattlePrepareUIController.OnActionOrderButtonClick);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_BattlePrepareUIController.<>f__mg$cache4B);
		if (Lua_BlackJack_ProjectL_UI_BattlePrepareUIController.<>f__mg$cache4C == null)
		{
			Lua_BlackJack_ProjectL_UI_BattlePrepareUIController.<>f__mg$cache4C = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattlePrepareUIController.OnChatButtonClick);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_BattlePrepareUIController.<>f__mg$cache4C);
		if (Lua_BlackJack_ProjectL_UI_BattlePrepareUIController.<>f__mg$cache4D == null)
		{
			Lua_BlackJack_ProjectL_UI_BattlePrepareUIController.<>f__mg$cache4D = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattlePrepareUIController.OnHelpButtonClick);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_BattlePrepareUIController.<>f__mg$cache4D);
		if (Lua_BlackJack_ProjectL_UI_BattlePrepareUIController.<>f__mg$cache4E == null)
		{
			Lua_BlackJack_ProjectL_UI_BattlePrepareUIController.<>f__mg$cache4E = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattlePrepareUIController.OnTestOnStageToggle);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_BattlePrepareUIController.<>f__mg$cache4E);
		if (Lua_BlackJack_ProjectL_UI_BattlePrepareUIController.<>f__mg$cache4F == null)
		{
			Lua_BlackJack_ProjectL_UI_BattlePrepareUIController.<>f__mg$cache4F = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattlePrepareUIController.ClearPointerDownStageActor);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_BattlePrepareUIController.<>f__mg$cache4F);
		if (Lua_BlackJack_ProjectL_UI_BattlePrepareUIController.<>f__mg$cache50 == null)
		{
			Lua_BlackJack_ProjectL_UI_BattlePrepareUIController.<>f__mg$cache50 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattlePrepareUIController.CreateDraggingHeroButton);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_BattlePrepareUIController.<>f__mg$cache50);
		if (Lua_BlackJack_ProjectL_UI_BattlePrepareUIController.<>f__mg$cache51 == null)
		{
			Lua_BlackJack_ProjectL_UI_BattlePrepareUIController.<>f__mg$cache51 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattlePrepareUIController.DestroyDragginHeroButton);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_BattlePrepareUIController.<>f__mg$cache51);
		if (Lua_BlackJack_ProjectL_UI_BattlePrepareUIController.<>f__mg$cache52 == null)
		{
			Lua_BlackJack_ProjectL_UI_BattlePrepareUIController.<>f__mg$cache52 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattlePrepareUIController.MoveDraggingHeroButton);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_BattlePrepareUIController.<>f__mg$cache52);
		if (Lua_BlackJack_ProjectL_UI_BattlePrepareUIController.<>f__mg$cache53 == null)
		{
			Lua_BlackJack_ProjectL_UI_BattlePrepareUIController.<>f__mg$cache53 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattlePrepareUIController.UpdateStageActorCount);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_BattlePrepareUIController.<>f__mg$cache53);
		if (Lua_BlackJack_ProjectL_UI_BattlePrepareUIController.<>f__mg$cache54 == null)
		{
			Lua_BlackJack_ProjectL_UI_BattlePrepareUIController.<>f__mg$cache54 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattlePrepareUIController.HideActorInfo);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_BattlePrepareUIController.<>f__mg$cache54);
		if (Lua_BlackJack_ProjectL_UI_BattlePrepareUIController.<>f__mg$cache55 == null)
		{
			Lua_BlackJack_ProjectL_UI_BattlePrepareUIController.<>f__mg$cache55 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattlePrepareUIController.__callBase_Initlize);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_BattlePrepareUIController.<>f__mg$cache55);
		if (Lua_BlackJack_ProjectL_UI_BattlePrepareUIController.<>f__mg$cache56 == null)
		{
			Lua_BlackJack_ProjectL_UI_BattlePrepareUIController.<>f__mg$cache56 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattlePrepareUIController.__callBase_BindFields);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_BattlePrepareUIController.<>f__mg$cache56);
		if (Lua_BlackJack_ProjectL_UI_BattlePrepareUIController.<>f__mg$cache57 == null)
		{
			Lua_BlackJack_ProjectL_UI_BattlePrepareUIController.<>f__mg$cache57 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattlePrepareUIController.__callBase_OnBindFiledsCompleted);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_BattlePrepareUIController.<>f__mg$cache57);
		if (Lua_BlackJack_ProjectL_UI_BattlePrepareUIController.<>f__mg$cache58 == null)
		{
			Lua_BlackJack_ProjectL_UI_BattlePrepareUIController.<>f__mg$cache58 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattlePrepareUIController.__callBase_BindFieldImpl);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_BattlePrepareUIController.<>f__mg$cache58);
		if (Lua_BlackJack_ProjectL_UI_BattlePrepareUIController.<>f__mg$cache59 == null)
		{
			Lua_BlackJack_ProjectL_UI_BattlePrepareUIController.<>f__mg$cache59 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattlePrepareUIController.__callBase_Clear);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_BattlePrepareUIController.<>f__mg$cache59);
		if (Lua_BlackJack_ProjectL_UI_BattlePrepareUIController.<>f__mg$cache5A == null)
		{
			Lua_BlackJack_ProjectL_UI_BattlePrepareUIController.<>f__mg$cache5A = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattlePrepareUIController.__callBase_OnButtonClick);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_BattlePrepareUIController.<>f__mg$cache5A);
		if (Lua_BlackJack_ProjectL_UI_BattlePrepareUIController.<>f__mg$cache5B == null)
		{
			Lua_BlackJack_ProjectL_UI_BattlePrepareUIController.<>f__mg$cache5B = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattlePrepareUIController.__callBase_SetButtonClickListener);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_BattlePrepareUIController.<>f__mg$cache5B);
		if (Lua_BlackJack_ProjectL_UI_BattlePrepareUIController.<>f__mg$cache5C == null)
		{
			Lua_BlackJack_ProjectL_UI_BattlePrepareUIController.<>f__mg$cache5C = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattlePrepareUIController.__callBase_SetButtonDoubleClickListener);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_BattlePrepareUIController.<>f__mg$cache5C);
		if (Lua_BlackJack_ProjectL_UI_BattlePrepareUIController.<>f__mg$cache5D == null)
		{
			Lua_BlackJack_ProjectL_UI_BattlePrepareUIController.<>f__mg$cache5D = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattlePrepareUIController.__callBase_SetButtonLongPressStartListener);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_BattlePrepareUIController.<>f__mg$cache5D);
		if (Lua_BlackJack_ProjectL_UI_BattlePrepareUIController.<>f__mg$cache5E == null)
		{
			Lua_BlackJack_ProjectL_UI_BattlePrepareUIController.<>f__mg$cache5E = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattlePrepareUIController.__callBase_SetButtonLongPressingListener);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_BattlePrepareUIController.<>f__mg$cache5E);
		if (Lua_BlackJack_ProjectL_UI_BattlePrepareUIController.<>f__mg$cache5F == null)
		{
			Lua_BlackJack_ProjectL_UI_BattlePrepareUIController.<>f__mg$cache5F = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattlePrepareUIController.__callBase_SetButtonLongPressEndListener);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_BattlePrepareUIController.<>f__mg$cache5F);
		if (Lua_BlackJack_ProjectL_UI_BattlePrepareUIController.<>f__mg$cache60 == null)
		{
			Lua_BlackJack_ProjectL_UI_BattlePrepareUIController.<>f__mg$cache60 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattlePrepareUIController.__callBase_SetToggleValueChangedListener);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_BattlePrepareUIController.<>f__mg$cache60);
		if (Lua_BlackJack_ProjectL_UI_BattlePrepareUIController.<>f__mg$cache61 == null)
		{
			Lua_BlackJack_ProjectL_UI_BattlePrepareUIController.<>f__mg$cache61 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattlePrepareUIController.__callBase_ToString);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_BattlePrepareUIController.<>f__mg$cache61);
		if (Lua_BlackJack_ProjectL_UI_BattlePrepareUIController.<>f__mg$cache62 == null)
		{
			Lua_BlackJack_ProjectL_UI_BattlePrepareUIController.<>f__mg$cache62 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattlePrepareUIController.__callDele_EventOnPauseBattle);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_BattlePrepareUIController.<>f__mg$cache62);
		if (Lua_BlackJack_ProjectL_UI_BattlePrepareUIController.<>f__mg$cache63 == null)
		{
			Lua_BlackJack_ProjectL_UI_BattlePrepareUIController.<>f__mg$cache63 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattlePrepareUIController.__clearDele_EventOnPauseBattle);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_BattlePrepareUIController.<>f__mg$cache63);
		if (Lua_BlackJack_ProjectL_UI_BattlePrepareUIController.<>f__mg$cache64 == null)
		{
			Lua_BlackJack_ProjectL_UI_BattlePrepareUIController.<>f__mg$cache64 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattlePrepareUIController.__callDele_EventOnShowArmyRelation);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_BattlePrepareUIController.<>f__mg$cache64);
		if (Lua_BlackJack_ProjectL_UI_BattlePrepareUIController.<>f__mg$cache65 == null)
		{
			Lua_BlackJack_ProjectL_UI_BattlePrepareUIController.<>f__mg$cache65 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattlePrepareUIController.__clearDele_EventOnShowArmyRelation);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_BattlePrepareUIController.<>f__mg$cache65);
		if (Lua_BlackJack_ProjectL_UI_BattlePrepareUIController.<>f__mg$cache66 == null)
		{
			Lua_BlackJack_ProjectL_UI_BattlePrepareUIController.<>f__mg$cache66 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattlePrepareUIController.__callDele_EventOnStart);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_BattlePrepareUIController.<>f__mg$cache66);
		if (Lua_BlackJack_ProjectL_UI_BattlePrepareUIController.<>f__mg$cache67 == null)
		{
			Lua_BlackJack_ProjectL_UI_BattlePrepareUIController.<>f__mg$cache67 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattlePrepareUIController.__clearDele_EventOnStart);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_BattlePrepareUIController.<>f__mg$cache67);
		if (Lua_BlackJack_ProjectL_UI_BattlePrepareUIController.<>f__mg$cache68 == null)
		{
			Lua_BlackJack_ProjectL_UI_BattlePrepareUIController.<>f__mg$cache68 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattlePrepareUIController.__callDele_EventOnShowActionOrder);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_BattlePrepareUIController.<>f__mg$cache68);
		if (Lua_BlackJack_ProjectL_UI_BattlePrepareUIController.<>f__mg$cache69 == null)
		{
			Lua_BlackJack_ProjectL_UI_BattlePrepareUIController.<>f__mg$cache69 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattlePrepareUIController.__clearDele_EventOnShowActionOrder);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_BattlePrepareUIController.<>f__mg$cache69);
		if (Lua_BlackJack_ProjectL_UI_BattlePrepareUIController.<>f__mg$cache6A == null)
		{
			Lua_BlackJack_ProjectL_UI_BattlePrepareUIController.<>f__mg$cache6A = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattlePrepareUIController.__callDele_EventOnTestOnStage);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_BattlePrepareUIController.<>f__mg$cache6A);
		if (Lua_BlackJack_ProjectL_UI_BattlePrepareUIController.<>f__mg$cache6B == null)
		{
			Lua_BlackJack_ProjectL_UI_BattlePrepareUIController.<>f__mg$cache6B = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattlePrepareUIController.__clearDele_EventOnTestOnStage);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_BattlePrepareUIController.<>f__mg$cache6B);
		if (Lua_BlackJack_ProjectL_UI_BattlePrepareUIController.<>f__mg$cache6C == null)
		{
			Lua_BlackJack_ProjectL_UI_BattlePrepareUIController.<>f__mg$cache6C = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattlePrepareUIController.__callDele_EventOnShowMyActorInfo);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_BattlePrepareUIController.<>f__mg$cache6C);
		if (Lua_BlackJack_ProjectL_UI_BattlePrepareUIController.<>f__mg$cache6D == null)
		{
			Lua_BlackJack_ProjectL_UI_BattlePrepareUIController.<>f__mg$cache6D = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattlePrepareUIController.__clearDele_EventOnShowMyActorInfo);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_BattlePrepareUIController.<>f__mg$cache6D);
		if (Lua_BlackJack_ProjectL_UI_BattlePrepareUIController.<>f__mg$cache6E == null)
		{
			Lua_BlackJack_ProjectL_UI_BattlePrepareUIController.<>f__mg$cache6E = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattlePrepareUIController.__callDele_EventOnHideActorInfo);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_BattlePrepareUIController.<>f__mg$cache6E);
		if (Lua_BlackJack_ProjectL_UI_BattlePrepareUIController.<>f__mg$cache6F == null)
		{
			Lua_BlackJack_ProjectL_UI_BattlePrepareUIController.<>f__mg$cache6F = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattlePrepareUIController.__clearDele_EventOnHideActorInfo);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_BattlePrepareUIController.<>f__mg$cache6F);
		if (Lua_BlackJack_ProjectL_UI_BattlePrepareUIController.<>f__mg$cache70 == null)
		{
			Lua_BlackJack_ProjectL_UI_BattlePrepareUIController.<>f__mg$cache70 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattlePrepareUIController.__callDele_EventOnStageActorChange);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_BattlePrepareUIController.<>f__mg$cache70);
		if (Lua_BlackJack_ProjectL_UI_BattlePrepareUIController.<>f__mg$cache71 == null)
		{
			Lua_BlackJack_ProjectL_UI_BattlePrepareUIController.<>f__mg$cache71 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattlePrepareUIController.__clearDele_EventOnStageActorChange);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_BattlePrepareUIController.<>f__mg$cache71);
		if (Lua_BlackJack_ProjectL_UI_BattlePrepareUIController.<>f__mg$cache72 == null)
		{
			Lua_BlackJack_ProjectL_UI_BattlePrepareUIController.<>f__mg$cache72 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattlePrepareUIController.__callDele_EventOnShowChat);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_BattlePrepareUIController.<>f__mg$cache72);
		if (Lua_BlackJack_ProjectL_UI_BattlePrepareUIController.<>f__mg$cache73 == null)
		{
			Lua_BlackJack_ProjectL_UI_BattlePrepareUIController.<>f__mg$cache73 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattlePrepareUIController.__clearDele_EventOnShowChat);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_BattlePrepareUIController.<>f__mg$cache73);
		if (Lua_BlackJack_ProjectL_UI_BattlePrepareUIController.<>f__mg$cache74 == null)
		{
			Lua_BlackJack_ProjectL_UI_BattlePrepareUIController.<>f__mg$cache74 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattlePrepareUIController.__callDele_EventOnShowHelp);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_BattlePrepareUIController.<>f__mg$cache74);
		if (Lua_BlackJack_ProjectL_UI_BattlePrepareUIController.<>f__mg$cache75 == null)
		{
			Lua_BlackJack_ProjectL_UI_BattlePrepareUIController.<>f__mg$cache75 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattlePrepareUIController.__clearDele_EventOnShowHelp);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_BattlePrepareUIController.<>f__mg$cache75);
		if (Lua_BlackJack_ProjectL_UI_BattlePrepareUIController.<>f__mg$cache76 == null)
		{
			Lua_BlackJack_ProjectL_UI_BattlePrepareUIController.<>f__mg$cache76 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattlePrepareUIController.__callDele_EventOnHeroOnStage);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_BattlePrepareUIController.<>f__mg$cache76);
		if (Lua_BlackJack_ProjectL_UI_BattlePrepareUIController.<>f__mg$cache77 == null)
		{
			Lua_BlackJack_ProjectL_UI_BattlePrepareUIController.<>f__mg$cache77 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattlePrepareUIController.__clearDele_EventOnHeroOnStage);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_BattlePrepareUIController.<>f__mg$cache77);
		if (Lua_BlackJack_ProjectL_UI_BattlePrepareUIController.<>f__mg$cache78 == null)
		{
			Lua_BlackJack_ProjectL_UI_BattlePrepareUIController.<>f__mg$cache78 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattlePrepareUIController.__callDele_EventOnActorOffStage);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_BattlePrepareUIController.<>f__mg$cache78);
		if (Lua_BlackJack_ProjectL_UI_BattlePrepareUIController.<>f__mg$cache79 == null)
		{
			Lua_BlackJack_ProjectL_UI_BattlePrepareUIController.<>f__mg$cache79 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattlePrepareUIController.__clearDele_EventOnActorOffStage);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_BattlePrepareUIController.<>f__mg$cache79);
		if (Lua_BlackJack_ProjectL_UI_BattlePrepareUIController.<>f__mg$cache7A == null)
		{
			Lua_BlackJack_ProjectL_UI_BattlePrepareUIController.<>f__mg$cache7A = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattlePrepareUIController.__callDele_EventOnStageActorMove);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_BattlePrepareUIController.<>f__mg$cache7A);
		if (Lua_BlackJack_ProjectL_UI_BattlePrepareUIController.<>f__mg$cache7B == null)
		{
			Lua_BlackJack_ProjectL_UI_BattlePrepareUIController.<>f__mg$cache7B = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattlePrepareUIController.__clearDele_EventOnStageActorMove);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_BattlePrepareUIController.<>f__mg$cache7B);
		if (Lua_BlackJack_ProjectL_UI_BattlePrepareUIController.<>f__mg$cache7C == null)
		{
			Lua_BlackJack_ProjectL_UI_BattlePrepareUIController.<>f__mg$cache7C = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattlePrepareUIController.__callDele_EventOnStageActorSwap);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_BattlePrepareUIController.<>f__mg$cache7C);
		if (Lua_BlackJack_ProjectL_UI_BattlePrepareUIController.<>f__mg$cache7D == null)
		{
			Lua_BlackJack_ProjectL_UI_BattlePrepareUIController.<>f__mg$cache7D = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattlePrepareUIController.__clearDele_EventOnStageActorSwap);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_BattlePrepareUIController.<>f__mg$cache7D);
		if (Lua_BlackJack_ProjectL_UI_BattlePrepareUIController.<>f__mg$cache7E == null)
		{
			Lua_BlackJack_ProjectL_UI_BattlePrepareUIController.<>f__mg$cache7E = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattlePrepareUIController.__callDele_EventOnPointerDown);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_BattlePrepareUIController.<>f__mg$cache7E);
		if (Lua_BlackJack_ProjectL_UI_BattlePrepareUIController.<>f__mg$cache7F == null)
		{
			Lua_BlackJack_ProjectL_UI_BattlePrepareUIController.<>f__mg$cache7F = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattlePrepareUIController.__clearDele_EventOnPointerDown);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_BattlePrepareUIController.<>f__mg$cache7F);
		if (Lua_BlackJack_ProjectL_UI_BattlePrepareUIController.<>f__mg$cache80 == null)
		{
			Lua_BlackJack_ProjectL_UI_BattlePrepareUIController.<>f__mg$cache80 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattlePrepareUIController.__callDele_EventOnPointerUp);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_BattlePrepareUIController.<>f__mg$cache80);
		if (Lua_BlackJack_ProjectL_UI_BattlePrepareUIController.<>f__mg$cache81 == null)
		{
			Lua_BlackJack_ProjectL_UI_BattlePrepareUIController.<>f__mg$cache81 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattlePrepareUIController.__clearDele_EventOnPointerUp);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_BattlePrepareUIController.<>f__mg$cache81);
		if (Lua_BlackJack_ProjectL_UI_BattlePrepareUIController.<>f__mg$cache82 == null)
		{
			Lua_BlackJack_ProjectL_UI_BattlePrepareUIController.<>f__mg$cache82 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattlePrepareUIController.__callDele_EventOnPointerClick);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_BattlePrepareUIController.<>f__mg$cache82);
		if (Lua_BlackJack_ProjectL_UI_BattlePrepareUIController.<>f__mg$cache83 == null)
		{
			Lua_BlackJack_ProjectL_UI_BattlePrepareUIController.<>f__mg$cache83 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattlePrepareUIController.__clearDele_EventOnPointerClick);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_BattlePrepareUIController.<>f__mg$cache83);
		if (Lua_BlackJack_ProjectL_UI_BattlePrepareUIController.<>f__mg$cache84 == null)
		{
			Lua_BlackJack_ProjectL_UI_BattlePrepareUIController.<>f__mg$cache84 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattlePrepareUIController.__callDele_EventOnBeginDragHero);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_BattlePrepareUIController.<>f__mg$cache84);
		if (Lua_BlackJack_ProjectL_UI_BattlePrepareUIController.<>f__mg$cache85 == null)
		{
			Lua_BlackJack_ProjectL_UI_BattlePrepareUIController.<>f__mg$cache85 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattlePrepareUIController.__clearDele_EventOnBeginDragHero);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_BattlePrepareUIController.<>f__mg$cache85);
		if (Lua_BlackJack_ProjectL_UI_BattlePrepareUIController.<>f__mg$cache86 == null)
		{
			Lua_BlackJack_ProjectL_UI_BattlePrepareUIController.<>f__mg$cache86 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattlePrepareUIController.__callDele_EventOnEndDragHero);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_BattlePrepareUIController.<>f__mg$cache86);
		if (Lua_BlackJack_ProjectL_UI_BattlePrepareUIController.<>f__mg$cache87 == null)
		{
			Lua_BlackJack_ProjectL_UI_BattlePrepareUIController.<>f__mg$cache87 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattlePrepareUIController.__clearDele_EventOnEndDragHero);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_BattlePrepareUIController.<>f__mg$cache87);
		if (Lua_BlackJack_ProjectL_UI_BattlePrepareUIController.<>f__mg$cache88 == null)
		{
			Lua_BlackJack_ProjectL_UI_BattlePrepareUIController.<>f__mg$cache88 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattlePrepareUIController.CompareTransformY_s);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_BattlePrepareUIController.<>f__mg$cache88);
		if (Lua_BlackJack_ProjectL_UI_BattlePrepareUIController.<>f__mg$cache89 == null)
		{
			Lua_BlackJack_ProjectL_UI_BattlePrepareUIController.<>f__mg$cache89 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattlePrepareUIController.SetInputFieldValue_s);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_BattlePrepareUIController.<>f__mg$cache89);
		if (Lua_BlackJack_ProjectL_UI_BattlePrepareUIController.<>f__mg$cache8A == null)
		{
			Lua_BlackJack_ProjectL_UI_BattlePrepareUIController.<>f__mg$cache8A = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattlePrepareUIController.GetInputFieldValue_s);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_BattlePrepareUIController.<>f__mg$cache8A);
		string name = "EventOnPauseBattle";
		LuaCSFunction get = null;
		if (Lua_BlackJack_ProjectL_UI_BattlePrepareUIController.<>f__mg$cache8B == null)
		{
			Lua_BlackJack_ProjectL_UI_BattlePrepareUIController.<>f__mg$cache8B = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattlePrepareUIController.set_EventOnPauseBattle);
		}
		LuaObject.addMember(l, name, get, Lua_BlackJack_ProjectL_UI_BattlePrepareUIController.<>f__mg$cache8B, true);
		string name2 = "EventOnShowArmyRelation";
		LuaCSFunction get2 = null;
		if (Lua_BlackJack_ProjectL_UI_BattlePrepareUIController.<>f__mg$cache8C == null)
		{
			Lua_BlackJack_ProjectL_UI_BattlePrepareUIController.<>f__mg$cache8C = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattlePrepareUIController.set_EventOnShowArmyRelation);
		}
		LuaObject.addMember(l, name2, get2, Lua_BlackJack_ProjectL_UI_BattlePrepareUIController.<>f__mg$cache8C, true);
		string name3 = "EventOnStart";
		LuaCSFunction get3 = null;
		if (Lua_BlackJack_ProjectL_UI_BattlePrepareUIController.<>f__mg$cache8D == null)
		{
			Lua_BlackJack_ProjectL_UI_BattlePrepareUIController.<>f__mg$cache8D = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattlePrepareUIController.set_EventOnStart);
		}
		LuaObject.addMember(l, name3, get3, Lua_BlackJack_ProjectL_UI_BattlePrepareUIController.<>f__mg$cache8D, true);
		string name4 = "EventOnShowActionOrder";
		LuaCSFunction get4 = null;
		if (Lua_BlackJack_ProjectL_UI_BattlePrepareUIController.<>f__mg$cache8E == null)
		{
			Lua_BlackJack_ProjectL_UI_BattlePrepareUIController.<>f__mg$cache8E = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattlePrepareUIController.set_EventOnShowActionOrder);
		}
		LuaObject.addMember(l, name4, get4, Lua_BlackJack_ProjectL_UI_BattlePrepareUIController.<>f__mg$cache8E, true);
		string name5 = "EventOnTestOnStage";
		LuaCSFunction get5 = null;
		if (Lua_BlackJack_ProjectL_UI_BattlePrepareUIController.<>f__mg$cache8F == null)
		{
			Lua_BlackJack_ProjectL_UI_BattlePrepareUIController.<>f__mg$cache8F = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattlePrepareUIController.set_EventOnTestOnStage);
		}
		LuaObject.addMember(l, name5, get5, Lua_BlackJack_ProjectL_UI_BattlePrepareUIController.<>f__mg$cache8F, true);
		string name6 = "EventOnShowMyActorInfo";
		LuaCSFunction get6 = null;
		if (Lua_BlackJack_ProjectL_UI_BattlePrepareUIController.<>f__mg$cache90 == null)
		{
			Lua_BlackJack_ProjectL_UI_BattlePrepareUIController.<>f__mg$cache90 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattlePrepareUIController.set_EventOnShowMyActorInfo);
		}
		LuaObject.addMember(l, name6, get6, Lua_BlackJack_ProjectL_UI_BattlePrepareUIController.<>f__mg$cache90, true);
		string name7 = "EventOnHideActorInfo";
		LuaCSFunction get7 = null;
		if (Lua_BlackJack_ProjectL_UI_BattlePrepareUIController.<>f__mg$cache91 == null)
		{
			Lua_BlackJack_ProjectL_UI_BattlePrepareUIController.<>f__mg$cache91 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattlePrepareUIController.set_EventOnHideActorInfo);
		}
		LuaObject.addMember(l, name7, get7, Lua_BlackJack_ProjectL_UI_BattlePrepareUIController.<>f__mg$cache91, true);
		string name8 = "EventOnStageActorChange";
		LuaCSFunction get8 = null;
		if (Lua_BlackJack_ProjectL_UI_BattlePrepareUIController.<>f__mg$cache92 == null)
		{
			Lua_BlackJack_ProjectL_UI_BattlePrepareUIController.<>f__mg$cache92 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattlePrepareUIController.set_EventOnStageActorChange);
		}
		LuaObject.addMember(l, name8, get8, Lua_BlackJack_ProjectL_UI_BattlePrepareUIController.<>f__mg$cache92, true);
		string name9 = "EventOnShowChat";
		LuaCSFunction get9 = null;
		if (Lua_BlackJack_ProjectL_UI_BattlePrepareUIController.<>f__mg$cache93 == null)
		{
			Lua_BlackJack_ProjectL_UI_BattlePrepareUIController.<>f__mg$cache93 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattlePrepareUIController.set_EventOnShowChat);
		}
		LuaObject.addMember(l, name9, get9, Lua_BlackJack_ProjectL_UI_BattlePrepareUIController.<>f__mg$cache93, true);
		string name10 = "EventOnShowHelp";
		LuaCSFunction get10 = null;
		if (Lua_BlackJack_ProjectL_UI_BattlePrepareUIController.<>f__mg$cache94 == null)
		{
			Lua_BlackJack_ProjectL_UI_BattlePrepareUIController.<>f__mg$cache94 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattlePrepareUIController.set_EventOnShowHelp);
		}
		LuaObject.addMember(l, name10, get10, Lua_BlackJack_ProjectL_UI_BattlePrepareUIController.<>f__mg$cache94, true);
		string name11 = "EventOnHeroOnStage";
		LuaCSFunction get11 = null;
		if (Lua_BlackJack_ProjectL_UI_BattlePrepareUIController.<>f__mg$cache95 == null)
		{
			Lua_BlackJack_ProjectL_UI_BattlePrepareUIController.<>f__mg$cache95 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattlePrepareUIController.set_EventOnHeroOnStage);
		}
		LuaObject.addMember(l, name11, get11, Lua_BlackJack_ProjectL_UI_BattlePrepareUIController.<>f__mg$cache95, true);
		string name12 = "EventOnActorOffStage";
		LuaCSFunction get12 = null;
		if (Lua_BlackJack_ProjectL_UI_BattlePrepareUIController.<>f__mg$cache96 == null)
		{
			Lua_BlackJack_ProjectL_UI_BattlePrepareUIController.<>f__mg$cache96 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattlePrepareUIController.set_EventOnActorOffStage);
		}
		LuaObject.addMember(l, name12, get12, Lua_BlackJack_ProjectL_UI_BattlePrepareUIController.<>f__mg$cache96, true);
		string name13 = "EventOnStageActorMove";
		LuaCSFunction get13 = null;
		if (Lua_BlackJack_ProjectL_UI_BattlePrepareUIController.<>f__mg$cache97 == null)
		{
			Lua_BlackJack_ProjectL_UI_BattlePrepareUIController.<>f__mg$cache97 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattlePrepareUIController.set_EventOnStageActorMove);
		}
		LuaObject.addMember(l, name13, get13, Lua_BlackJack_ProjectL_UI_BattlePrepareUIController.<>f__mg$cache97, true);
		string name14 = "EventOnStageActorSwap";
		LuaCSFunction get14 = null;
		if (Lua_BlackJack_ProjectL_UI_BattlePrepareUIController.<>f__mg$cache98 == null)
		{
			Lua_BlackJack_ProjectL_UI_BattlePrepareUIController.<>f__mg$cache98 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattlePrepareUIController.set_EventOnStageActorSwap);
		}
		LuaObject.addMember(l, name14, get14, Lua_BlackJack_ProjectL_UI_BattlePrepareUIController.<>f__mg$cache98, true);
		string name15 = "EventOnPointerDown";
		LuaCSFunction get15 = null;
		if (Lua_BlackJack_ProjectL_UI_BattlePrepareUIController.<>f__mg$cache99 == null)
		{
			Lua_BlackJack_ProjectL_UI_BattlePrepareUIController.<>f__mg$cache99 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattlePrepareUIController.set_EventOnPointerDown);
		}
		LuaObject.addMember(l, name15, get15, Lua_BlackJack_ProjectL_UI_BattlePrepareUIController.<>f__mg$cache99, true);
		string name16 = "EventOnPointerUp";
		LuaCSFunction get16 = null;
		if (Lua_BlackJack_ProjectL_UI_BattlePrepareUIController.<>f__mg$cache9A == null)
		{
			Lua_BlackJack_ProjectL_UI_BattlePrepareUIController.<>f__mg$cache9A = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattlePrepareUIController.set_EventOnPointerUp);
		}
		LuaObject.addMember(l, name16, get16, Lua_BlackJack_ProjectL_UI_BattlePrepareUIController.<>f__mg$cache9A, true);
		string name17 = "EventOnPointerClick";
		LuaCSFunction get17 = null;
		if (Lua_BlackJack_ProjectL_UI_BattlePrepareUIController.<>f__mg$cache9B == null)
		{
			Lua_BlackJack_ProjectL_UI_BattlePrepareUIController.<>f__mg$cache9B = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattlePrepareUIController.set_EventOnPointerClick);
		}
		LuaObject.addMember(l, name17, get17, Lua_BlackJack_ProjectL_UI_BattlePrepareUIController.<>f__mg$cache9B, true);
		string name18 = "EventOnBeginDragHero";
		LuaCSFunction get18 = null;
		if (Lua_BlackJack_ProjectL_UI_BattlePrepareUIController.<>f__mg$cache9C == null)
		{
			Lua_BlackJack_ProjectL_UI_BattlePrepareUIController.<>f__mg$cache9C = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattlePrepareUIController.set_EventOnBeginDragHero);
		}
		LuaObject.addMember(l, name18, get18, Lua_BlackJack_ProjectL_UI_BattlePrepareUIController.<>f__mg$cache9C, true);
		string name19 = "EventOnEndDragHero";
		LuaCSFunction get19 = null;
		if (Lua_BlackJack_ProjectL_UI_BattlePrepareUIController.<>f__mg$cache9D == null)
		{
			Lua_BlackJack_ProjectL_UI_BattlePrepareUIController.<>f__mg$cache9D = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattlePrepareUIController.set_EventOnEndDragHero);
		}
		LuaObject.addMember(l, name19, get19, Lua_BlackJack_ProjectL_UI_BattlePrepareUIController.<>f__mg$cache9D, true);
		string name20 = "m_marginTransform";
		if (Lua_BlackJack_ProjectL_UI_BattlePrepareUIController.<>f__mg$cache9E == null)
		{
			Lua_BlackJack_ProjectL_UI_BattlePrepareUIController.<>f__mg$cache9E = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattlePrepareUIController.get_m_marginTransform);
		}
		LuaCSFunction get20 = Lua_BlackJack_ProjectL_UI_BattlePrepareUIController.<>f__mg$cache9E;
		if (Lua_BlackJack_ProjectL_UI_BattlePrepareUIController.<>f__mg$cache9F == null)
		{
			Lua_BlackJack_ProjectL_UI_BattlePrepareUIController.<>f__mg$cache9F = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattlePrepareUIController.set_m_marginTransform);
		}
		LuaObject.addMember(l, name20, get20, Lua_BlackJack_ProjectL_UI_BattlePrepareUIController.<>f__mg$cache9F, true);
		string name21 = "m_pauseButton";
		if (Lua_BlackJack_ProjectL_UI_BattlePrepareUIController.<>f__mg$cacheA0 == null)
		{
			Lua_BlackJack_ProjectL_UI_BattlePrepareUIController.<>f__mg$cacheA0 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattlePrepareUIController.get_m_pauseButton);
		}
		LuaCSFunction get21 = Lua_BlackJack_ProjectL_UI_BattlePrepareUIController.<>f__mg$cacheA0;
		if (Lua_BlackJack_ProjectL_UI_BattlePrepareUIController.<>f__mg$cacheA1 == null)
		{
			Lua_BlackJack_ProjectL_UI_BattlePrepareUIController.<>f__mg$cacheA1 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattlePrepareUIController.set_m_pauseButton);
		}
		LuaObject.addMember(l, name21, get21, Lua_BlackJack_ProjectL_UI_BattlePrepareUIController.<>f__mg$cacheA1, true);
		string name22 = "m_stageActorCountText";
		if (Lua_BlackJack_ProjectL_UI_BattlePrepareUIController.<>f__mg$cacheA2 == null)
		{
			Lua_BlackJack_ProjectL_UI_BattlePrepareUIController.<>f__mg$cacheA2 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattlePrepareUIController.get_m_stageActorCountText);
		}
		LuaCSFunction get22 = Lua_BlackJack_ProjectL_UI_BattlePrepareUIController.<>f__mg$cacheA2;
		if (Lua_BlackJack_ProjectL_UI_BattlePrepareUIController.<>f__mg$cacheA3 == null)
		{
			Lua_BlackJack_ProjectL_UI_BattlePrepareUIController.<>f__mg$cacheA3 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattlePrepareUIController.set_m_stageActorCountText);
		}
		LuaObject.addMember(l, name22, get22, Lua_BlackJack_ProjectL_UI_BattlePrepareUIController.<>f__mg$cacheA3, true);
		string name23 = "m_battlePowerUIStateController";
		if (Lua_BlackJack_ProjectL_UI_BattlePrepareUIController.<>f__mg$cacheA4 == null)
		{
			Lua_BlackJack_ProjectL_UI_BattlePrepareUIController.<>f__mg$cacheA4 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattlePrepareUIController.get_m_battlePowerUIStateController);
		}
		LuaCSFunction get23 = Lua_BlackJack_ProjectL_UI_BattlePrepareUIController.<>f__mg$cacheA4;
		if (Lua_BlackJack_ProjectL_UI_BattlePrepareUIController.<>f__mg$cacheA5 == null)
		{
			Lua_BlackJack_ProjectL_UI_BattlePrepareUIController.<>f__mg$cacheA5 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattlePrepareUIController.set_m_battlePowerUIStateController);
		}
		LuaObject.addMember(l, name23, get23, Lua_BlackJack_ProjectL_UI_BattlePrepareUIController.<>f__mg$cacheA5, true);
		string name24 = "m_battlePowerText";
		if (Lua_BlackJack_ProjectL_UI_BattlePrepareUIController.<>f__mg$cacheA6 == null)
		{
			Lua_BlackJack_ProjectL_UI_BattlePrepareUIController.<>f__mg$cacheA6 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattlePrepareUIController.get_m_battlePowerText);
		}
		LuaCSFunction get24 = Lua_BlackJack_ProjectL_UI_BattlePrepareUIController.<>f__mg$cacheA6;
		if (Lua_BlackJack_ProjectL_UI_BattlePrepareUIController.<>f__mg$cacheA7 == null)
		{
			Lua_BlackJack_ProjectL_UI_BattlePrepareUIController.<>f__mg$cacheA7 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattlePrepareUIController.set_m_battlePowerText);
		}
		LuaObject.addMember(l, name24, get24, Lua_BlackJack_ProjectL_UI_BattlePrepareUIController.<>f__mg$cacheA7, true);
		string name25 = "m_battlePowerArrowGo";
		if (Lua_BlackJack_ProjectL_UI_BattlePrepareUIController.<>f__mg$cacheA8 == null)
		{
			Lua_BlackJack_ProjectL_UI_BattlePrepareUIController.<>f__mg$cacheA8 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattlePrepareUIController.get_m_battlePowerArrowGo);
		}
		LuaCSFunction get25 = Lua_BlackJack_ProjectL_UI_BattlePrepareUIController.<>f__mg$cacheA8;
		if (Lua_BlackJack_ProjectL_UI_BattlePrepareUIController.<>f__mg$cacheA9 == null)
		{
			Lua_BlackJack_ProjectL_UI_BattlePrepareUIController.<>f__mg$cacheA9 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattlePrepareUIController.set_m_battlePowerArrowGo);
		}
		LuaObject.addMember(l, name25, get25, Lua_BlackJack_ProjectL_UI_BattlePrepareUIController.<>f__mg$cacheA9, true);
		string name26 = "m_climbTowerRuleUIStateController";
		if (Lua_BlackJack_ProjectL_UI_BattlePrepareUIController.<>f__mg$cacheAA == null)
		{
			Lua_BlackJack_ProjectL_UI_BattlePrepareUIController.<>f__mg$cacheAA = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattlePrepareUIController.get_m_climbTowerRuleUIStateController);
		}
		LuaCSFunction get26 = Lua_BlackJack_ProjectL_UI_BattlePrepareUIController.<>f__mg$cacheAA;
		if (Lua_BlackJack_ProjectL_UI_BattlePrepareUIController.<>f__mg$cacheAB == null)
		{
			Lua_BlackJack_ProjectL_UI_BattlePrepareUIController.<>f__mg$cacheAB = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattlePrepareUIController.set_m_climbTowerRuleUIStateController);
		}
		LuaObject.addMember(l, name26, get26, Lua_BlackJack_ProjectL_UI_BattlePrepareUIController.<>f__mg$cacheAB, true);
		string name27 = "m_climbTowerRuleText";
		if (Lua_BlackJack_ProjectL_UI_BattlePrepareUIController.<>f__mg$cacheAC == null)
		{
			Lua_BlackJack_ProjectL_UI_BattlePrepareUIController.<>f__mg$cacheAC = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattlePrepareUIController.get_m_climbTowerRuleText);
		}
		LuaCSFunction get27 = Lua_BlackJack_ProjectL_UI_BattlePrepareUIController.<>f__mg$cacheAC;
		if (Lua_BlackJack_ProjectL_UI_BattlePrepareUIController.<>f__mg$cacheAD == null)
		{
			Lua_BlackJack_ProjectL_UI_BattlePrepareUIController.<>f__mg$cacheAD = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattlePrepareUIController.set_m_climbTowerRuleText);
		}
		LuaObject.addMember(l, name27, get27, Lua_BlackJack_ProjectL_UI_BattlePrepareUIController.<>f__mg$cacheAD, true);
		string name28 = "m_chatButton";
		if (Lua_BlackJack_ProjectL_UI_BattlePrepareUIController.<>f__mg$cacheAE == null)
		{
			Lua_BlackJack_ProjectL_UI_BattlePrepareUIController.<>f__mg$cacheAE = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattlePrepareUIController.get_m_chatButton);
		}
		LuaCSFunction get28 = Lua_BlackJack_ProjectL_UI_BattlePrepareUIController.<>f__mg$cacheAE;
		if (Lua_BlackJack_ProjectL_UI_BattlePrepareUIController.<>f__mg$cacheAF == null)
		{
			Lua_BlackJack_ProjectL_UI_BattlePrepareUIController.<>f__mg$cacheAF = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattlePrepareUIController.set_m_chatButton);
		}
		LuaObject.addMember(l, name28, get28, Lua_BlackJack_ProjectL_UI_BattlePrepareUIController.<>f__mg$cacheAF, true);
		string name29 = "m_chatRedPoint";
		if (Lua_BlackJack_ProjectL_UI_BattlePrepareUIController.<>f__mg$cacheB0 == null)
		{
			Lua_BlackJack_ProjectL_UI_BattlePrepareUIController.<>f__mg$cacheB0 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattlePrepareUIController.get_m_chatRedPoint);
		}
		LuaCSFunction get29 = Lua_BlackJack_ProjectL_UI_BattlePrepareUIController.<>f__mg$cacheB0;
		if (Lua_BlackJack_ProjectL_UI_BattlePrepareUIController.<>f__mg$cacheB1 == null)
		{
			Lua_BlackJack_ProjectL_UI_BattlePrepareUIController.<>f__mg$cacheB1 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattlePrepareUIController.set_m_chatRedPoint);
		}
		LuaObject.addMember(l, name29, get29, Lua_BlackJack_ProjectL_UI_BattlePrepareUIController.<>f__mg$cacheB1, true);
		string name30 = "m_actionOrderButton";
		if (Lua_BlackJack_ProjectL_UI_BattlePrepareUIController.<>f__mg$cacheB2 == null)
		{
			Lua_BlackJack_ProjectL_UI_BattlePrepareUIController.<>f__mg$cacheB2 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattlePrepareUIController.get_m_actionOrderButton);
		}
		LuaCSFunction get30 = Lua_BlackJack_ProjectL_UI_BattlePrepareUIController.<>f__mg$cacheB2;
		if (Lua_BlackJack_ProjectL_UI_BattlePrepareUIController.<>f__mg$cacheB3 == null)
		{
			Lua_BlackJack_ProjectL_UI_BattlePrepareUIController.<>f__mg$cacheB3 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattlePrepareUIController.set_m_actionOrderButton);
		}
		LuaObject.addMember(l, name30, get30, Lua_BlackJack_ProjectL_UI_BattlePrepareUIController.<>f__mg$cacheB3, true);
		string name31 = "m_startButton";
		if (Lua_BlackJack_ProjectL_UI_BattlePrepareUIController.<>f__mg$cacheB4 == null)
		{
			Lua_BlackJack_ProjectL_UI_BattlePrepareUIController.<>f__mg$cacheB4 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattlePrepareUIController.get_m_startButton);
		}
		LuaCSFunction get31 = Lua_BlackJack_ProjectL_UI_BattlePrepareUIController.<>f__mg$cacheB4;
		if (Lua_BlackJack_ProjectL_UI_BattlePrepareUIController.<>f__mg$cacheB5 == null)
		{
			Lua_BlackJack_ProjectL_UI_BattlePrepareUIController.<>f__mg$cacheB5 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattlePrepareUIController.set_m_startButton);
		}
		LuaObject.addMember(l, name31, get31, Lua_BlackJack_ProjectL_UI_BattlePrepareUIController.<>f__mg$cacheB5, true);
		string name32 = "m_teamReadyGameObject";
		if (Lua_BlackJack_ProjectL_UI_BattlePrepareUIController.<>f__mg$cacheB6 == null)
		{
			Lua_BlackJack_ProjectL_UI_BattlePrepareUIController.<>f__mg$cacheB6 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattlePrepareUIController.get_m_teamReadyGameObject);
		}
		LuaCSFunction get32 = Lua_BlackJack_ProjectL_UI_BattlePrepareUIController.<>f__mg$cacheB6;
		if (Lua_BlackJack_ProjectL_UI_BattlePrepareUIController.<>f__mg$cacheB7 == null)
		{
			Lua_BlackJack_ProjectL_UI_BattlePrepareUIController.<>f__mg$cacheB7 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattlePrepareUIController.set_m_teamReadyGameObject);
		}
		LuaObject.addMember(l, name32, get32, Lua_BlackJack_ProjectL_UI_BattlePrepareUIController.<>f__mg$cacheB7, true);
		string name33 = "m_teamReadyTimeUIStateController";
		if (Lua_BlackJack_ProjectL_UI_BattlePrepareUIController.<>f__mg$cacheB8 == null)
		{
			Lua_BlackJack_ProjectL_UI_BattlePrepareUIController.<>f__mg$cacheB8 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattlePrepareUIController.get_m_teamReadyTimeUIStateController);
		}
		LuaCSFunction get33 = Lua_BlackJack_ProjectL_UI_BattlePrepareUIController.<>f__mg$cacheB8;
		if (Lua_BlackJack_ProjectL_UI_BattlePrepareUIController.<>f__mg$cacheB9 == null)
		{
			Lua_BlackJack_ProjectL_UI_BattlePrepareUIController.<>f__mg$cacheB9 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattlePrepareUIController.set_m_teamReadyTimeUIStateController);
		}
		LuaObject.addMember(l, name33, get33, Lua_BlackJack_ProjectL_UI_BattlePrepareUIController.<>f__mg$cacheB9, true);
		string name34 = "m_teamReadyTimeText";
		if (Lua_BlackJack_ProjectL_UI_BattlePrepareUIController.<>f__mg$cacheBA == null)
		{
			Lua_BlackJack_ProjectL_UI_BattlePrepareUIController.<>f__mg$cacheBA = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattlePrepareUIController.get_m_teamReadyTimeText);
		}
		LuaCSFunction get34 = Lua_BlackJack_ProjectL_UI_BattlePrepareUIController.<>f__mg$cacheBA;
		if (Lua_BlackJack_ProjectL_UI_BattlePrepareUIController.<>f__mg$cacheBB == null)
		{
			Lua_BlackJack_ProjectL_UI_BattlePrepareUIController.<>f__mg$cacheBB = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattlePrepareUIController.set_m_teamReadyTimeText);
		}
		LuaObject.addMember(l, name34, get34, Lua_BlackJack_ProjectL_UI_BattlePrepareUIController.<>f__mg$cacheBB, true);
		string name35 = "m_teamReadyWaitGameObject";
		if (Lua_BlackJack_ProjectL_UI_BattlePrepareUIController.<>f__mg$cacheBC == null)
		{
			Lua_BlackJack_ProjectL_UI_BattlePrepareUIController.<>f__mg$cacheBC = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattlePrepareUIController.get_m_teamReadyWaitGameObject);
		}
		LuaCSFunction get35 = Lua_BlackJack_ProjectL_UI_BattlePrepareUIController.<>f__mg$cacheBC;
		if (Lua_BlackJack_ProjectL_UI_BattlePrepareUIController.<>f__mg$cacheBD == null)
		{
			Lua_BlackJack_ProjectL_UI_BattlePrepareUIController.<>f__mg$cacheBD = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattlePrepareUIController.set_m_teamReadyWaitGameObject);
		}
		LuaObject.addMember(l, name35, get35, Lua_BlackJack_ProjectL_UI_BattlePrepareUIController.<>f__mg$cacheBD, true);
		string name36 = "m_teamReadyWaitTeammateText";
		if (Lua_BlackJack_ProjectL_UI_BattlePrepareUIController.<>f__mg$cacheBE == null)
		{
			Lua_BlackJack_ProjectL_UI_BattlePrepareUIController.<>f__mg$cacheBE = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattlePrepareUIController.get_m_teamReadyWaitTeammateText);
		}
		LuaCSFunction get36 = Lua_BlackJack_ProjectL_UI_BattlePrepareUIController.<>f__mg$cacheBE;
		if (Lua_BlackJack_ProjectL_UI_BattlePrepareUIController.<>f__mg$cacheBF == null)
		{
			Lua_BlackJack_ProjectL_UI_BattlePrepareUIController.<>f__mg$cacheBF = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattlePrepareUIController.set_m_teamReadyWaitTeammateText);
		}
		LuaObject.addMember(l, name36, get36, Lua_BlackJack_ProjectL_UI_BattlePrepareUIController.<>f__mg$cacheBF, true);
		string name37 = "m_teamReadyWaitOpponentText";
		if (Lua_BlackJack_ProjectL_UI_BattlePrepareUIController.<>f__mg$cacheC0 == null)
		{
			Lua_BlackJack_ProjectL_UI_BattlePrepareUIController.<>f__mg$cacheC0 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattlePrepareUIController.get_m_teamReadyWaitOpponentText);
		}
		LuaCSFunction get37 = Lua_BlackJack_ProjectL_UI_BattlePrepareUIController.<>f__mg$cacheC0;
		if (Lua_BlackJack_ProjectL_UI_BattlePrepareUIController.<>f__mg$cacheC1 == null)
		{
			Lua_BlackJack_ProjectL_UI_BattlePrepareUIController.<>f__mg$cacheC1 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattlePrepareUIController.set_m_teamReadyWaitOpponentText);
		}
		LuaObject.addMember(l, name37, get37, Lua_BlackJack_ProjectL_UI_BattlePrepareUIController.<>f__mg$cacheC1, true);
		string name38 = "m_testGameObject";
		if (Lua_BlackJack_ProjectL_UI_BattlePrepareUIController.<>f__mg$cacheC2 == null)
		{
			Lua_BlackJack_ProjectL_UI_BattlePrepareUIController.<>f__mg$cacheC2 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattlePrepareUIController.get_m_testGameObject);
		}
		LuaCSFunction get38 = Lua_BlackJack_ProjectL_UI_BattlePrepareUIController.<>f__mg$cacheC2;
		if (Lua_BlackJack_ProjectL_UI_BattlePrepareUIController.<>f__mg$cacheC3 == null)
		{
			Lua_BlackJack_ProjectL_UI_BattlePrepareUIController.<>f__mg$cacheC3 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattlePrepareUIController.set_m_testGameObject);
		}
		LuaObject.addMember(l, name38, get38, Lua_BlackJack_ProjectL_UI_BattlePrepareUIController.<>f__mg$cacheC3, true);
		string name39 = "m_testOnStageToggle";
		if (Lua_BlackJack_ProjectL_UI_BattlePrepareUIController.<>f__mg$cacheC4 == null)
		{
			Lua_BlackJack_ProjectL_UI_BattlePrepareUIController.<>f__mg$cacheC4 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattlePrepareUIController.get_m_testOnStageToggle);
		}
		LuaCSFunction get39 = Lua_BlackJack_ProjectL_UI_BattlePrepareUIController.<>f__mg$cacheC4;
		if (Lua_BlackJack_ProjectL_UI_BattlePrepareUIController.<>f__mg$cacheC5 == null)
		{
			Lua_BlackJack_ProjectL_UI_BattlePrepareUIController.<>f__mg$cacheC5 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattlePrepareUIController.set_m_testOnStageToggle);
		}
		LuaObject.addMember(l, name39, get39, Lua_BlackJack_ProjectL_UI_BattlePrepareUIController.<>f__mg$cacheC5, true);
		string name40 = "m_testSoldierInputField0";
		if (Lua_BlackJack_ProjectL_UI_BattlePrepareUIController.<>f__mg$cacheC6 == null)
		{
			Lua_BlackJack_ProjectL_UI_BattlePrepareUIController.<>f__mg$cacheC6 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattlePrepareUIController.get_m_testSoldierInputField0);
		}
		LuaCSFunction get40 = Lua_BlackJack_ProjectL_UI_BattlePrepareUIController.<>f__mg$cacheC6;
		if (Lua_BlackJack_ProjectL_UI_BattlePrepareUIController.<>f__mg$cacheC7 == null)
		{
			Lua_BlackJack_ProjectL_UI_BattlePrepareUIController.<>f__mg$cacheC7 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattlePrepareUIController.set_m_testSoldierInputField0);
		}
		LuaObject.addMember(l, name40, get40, Lua_BlackJack_ProjectL_UI_BattlePrepareUIController.<>f__mg$cacheC7, true);
		string name41 = "m_testSoldierInputField1";
		if (Lua_BlackJack_ProjectL_UI_BattlePrepareUIController.<>f__mg$cacheC8 == null)
		{
			Lua_BlackJack_ProjectL_UI_BattlePrepareUIController.<>f__mg$cacheC8 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattlePrepareUIController.get_m_testSoldierInputField1);
		}
		LuaCSFunction get41 = Lua_BlackJack_ProjectL_UI_BattlePrepareUIController.<>f__mg$cacheC8;
		if (Lua_BlackJack_ProjectL_UI_BattlePrepareUIController.<>f__mg$cacheC9 == null)
		{
			Lua_BlackJack_ProjectL_UI_BattlePrepareUIController.<>f__mg$cacheC9 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattlePrepareUIController.set_m_testSoldierInputField1);
		}
		LuaObject.addMember(l, name41, get41, Lua_BlackJack_ProjectL_UI_BattlePrepareUIController.<>f__mg$cacheC9, true);
		string name42 = "m_testSkillInputField0";
		if (Lua_BlackJack_ProjectL_UI_BattlePrepareUIController.<>f__mg$cacheCA == null)
		{
			Lua_BlackJack_ProjectL_UI_BattlePrepareUIController.<>f__mg$cacheCA = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattlePrepareUIController.get_m_testSkillInputField0);
		}
		LuaCSFunction get42 = Lua_BlackJack_ProjectL_UI_BattlePrepareUIController.<>f__mg$cacheCA;
		if (Lua_BlackJack_ProjectL_UI_BattlePrepareUIController.<>f__mg$cacheCB == null)
		{
			Lua_BlackJack_ProjectL_UI_BattlePrepareUIController.<>f__mg$cacheCB = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattlePrepareUIController.set_m_testSkillInputField0);
		}
		LuaObject.addMember(l, name42, get42, Lua_BlackJack_ProjectL_UI_BattlePrepareUIController.<>f__mg$cacheCB, true);
		string name43 = "m_testSkillInputField1";
		if (Lua_BlackJack_ProjectL_UI_BattlePrepareUIController.<>f__mg$cacheCC == null)
		{
			Lua_BlackJack_ProjectL_UI_BattlePrepareUIController.<>f__mg$cacheCC = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattlePrepareUIController.get_m_testSkillInputField1);
		}
		LuaCSFunction get43 = Lua_BlackJack_ProjectL_UI_BattlePrepareUIController.<>f__mg$cacheCC;
		if (Lua_BlackJack_ProjectL_UI_BattlePrepareUIController.<>f__mg$cacheCD == null)
		{
			Lua_BlackJack_ProjectL_UI_BattlePrepareUIController.<>f__mg$cacheCD = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattlePrepareUIController.set_m_testSkillInputField1);
		}
		LuaObject.addMember(l, name43, get43, Lua_BlackJack_ProjectL_UI_BattlePrepareUIController.<>f__mg$cacheCD, true);
		string name44 = "m_testTalentInputField0";
		if (Lua_BlackJack_ProjectL_UI_BattlePrepareUIController.<>f__mg$cacheCE == null)
		{
			Lua_BlackJack_ProjectL_UI_BattlePrepareUIController.<>f__mg$cacheCE = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattlePrepareUIController.get_m_testTalentInputField0);
		}
		LuaCSFunction get44 = Lua_BlackJack_ProjectL_UI_BattlePrepareUIController.<>f__mg$cacheCE;
		if (Lua_BlackJack_ProjectL_UI_BattlePrepareUIController.<>f__mg$cacheCF == null)
		{
			Lua_BlackJack_ProjectL_UI_BattlePrepareUIController.<>f__mg$cacheCF = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattlePrepareUIController.set_m_testTalentInputField0);
		}
		LuaObject.addMember(l, name44, get44, Lua_BlackJack_ProjectL_UI_BattlePrepareUIController.<>f__mg$cacheCF, true);
		string name45 = "m_testTalentInputField1";
		if (Lua_BlackJack_ProjectL_UI_BattlePrepareUIController.<>f__mg$cacheD0 == null)
		{
			Lua_BlackJack_ProjectL_UI_BattlePrepareUIController.<>f__mg$cacheD0 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattlePrepareUIController.get_m_testTalentInputField1);
		}
		LuaCSFunction get45 = Lua_BlackJack_ProjectL_UI_BattlePrepareUIController.<>f__mg$cacheD0;
		if (Lua_BlackJack_ProjectL_UI_BattlePrepareUIController.<>f__mg$cacheD1 == null)
		{
			Lua_BlackJack_ProjectL_UI_BattlePrepareUIController.<>f__mg$cacheD1 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattlePrepareUIController.set_m_testTalentInputField1);
		}
		LuaObject.addMember(l, name45, get45, Lua_BlackJack_ProjectL_UI_BattlePrepareUIController.<>f__mg$cacheD1, true);
		string name46 = "m_actorListScrollRect";
		if (Lua_BlackJack_ProjectL_UI_BattlePrepareUIController.<>f__mg$cacheD2 == null)
		{
			Lua_BlackJack_ProjectL_UI_BattlePrepareUIController.<>f__mg$cacheD2 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattlePrepareUIController.get_m_actorListScrollRect);
		}
		LuaCSFunction get46 = Lua_BlackJack_ProjectL_UI_BattlePrepareUIController.<>f__mg$cacheD2;
		if (Lua_BlackJack_ProjectL_UI_BattlePrepareUIController.<>f__mg$cacheD3 == null)
		{
			Lua_BlackJack_ProjectL_UI_BattlePrepareUIController.<>f__mg$cacheD3 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattlePrepareUIController.set_m_actorListScrollRect);
		}
		LuaObject.addMember(l, name46, get46, Lua_BlackJack_ProjectL_UI_BattlePrepareUIController.<>f__mg$cacheD3, true);
		string name47 = "m_actorListDisableGameObject";
		if (Lua_BlackJack_ProjectL_UI_BattlePrepareUIController.<>f__mg$cacheD4 == null)
		{
			Lua_BlackJack_ProjectL_UI_BattlePrepareUIController.<>f__mg$cacheD4 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattlePrepareUIController.get_m_actorListDisableGameObject);
		}
		LuaCSFunction get47 = Lua_BlackJack_ProjectL_UI_BattlePrepareUIController.<>f__mg$cacheD4;
		if (Lua_BlackJack_ProjectL_UI_BattlePrepareUIController.<>f__mg$cacheD5 == null)
		{
			Lua_BlackJack_ProjectL_UI_BattlePrepareUIController.<>f__mg$cacheD5 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattlePrepareUIController.set_m_actorListDisableGameObject);
		}
		LuaObject.addMember(l, name47, get47, Lua_BlackJack_ProjectL_UI_BattlePrepareUIController.<>f__mg$cacheD5, true);
		string name48 = "m_terrainInfoGameObject";
		if (Lua_BlackJack_ProjectL_UI_BattlePrepareUIController.<>f__mg$cacheD6 == null)
		{
			Lua_BlackJack_ProjectL_UI_BattlePrepareUIController.<>f__mg$cacheD6 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattlePrepareUIController.get_m_terrainInfoGameObject);
		}
		LuaCSFunction get48 = Lua_BlackJack_ProjectL_UI_BattlePrepareUIController.<>f__mg$cacheD6;
		if (Lua_BlackJack_ProjectL_UI_BattlePrepareUIController.<>f__mg$cacheD7 == null)
		{
			Lua_BlackJack_ProjectL_UI_BattlePrepareUIController.<>f__mg$cacheD7 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattlePrepareUIController.set_m_terrainInfoGameObject);
		}
		LuaObject.addMember(l, name48, get48, Lua_BlackJack_ProjectL_UI_BattlePrepareUIController.<>f__mg$cacheD7, true);
		string name49 = "m_terrainInfoText";
		if (Lua_BlackJack_ProjectL_UI_BattlePrepareUIController.<>f__mg$cacheD8 == null)
		{
			Lua_BlackJack_ProjectL_UI_BattlePrepareUIController.<>f__mg$cacheD8 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattlePrepareUIController.get_m_terrainInfoText);
		}
		LuaCSFunction get49 = Lua_BlackJack_ProjectL_UI_BattlePrepareUIController.<>f__mg$cacheD8;
		if (Lua_BlackJack_ProjectL_UI_BattlePrepareUIController.<>f__mg$cacheD9 == null)
		{
			Lua_BlackJack_ProjectL_UI_BattlePrepareUIController.<>f__mg$cacheD9 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattlePrepareUIController.set_m_terrainInfoText);
		}
		LuaObject.addMember(l, name49, get49, Lua_BlackJack_ProjectL_UI_BattlePrepareUIController.<>f__mg$cacheD9, true);
		string name50 = "m_terrainInfoImage";
		if (Lua_BlackJack_ProjectL_UI_BattlePrepareUIController.<>f__mg$cacheDA == null)
		{
			Lua_BlackJack_ProjectL_UI_BattlePrepareUIController.<>f__mg$cacheDA = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattlePrepareUIController.get_m_terrainInfoImage);
		}
		LuaCSFunction get50 = Lua_BlackJack_ProjectL_UI_BattlePrepareUIController.<>f__mg$cacheDA;
		if (Lua_BlackJack_ProjectL_UI_BattlePrepareUIController.<>f__mg$cacheDB == null)
		{
			Lua_BlackJack_ProjectL_UI_BattlePrepareUIController.<>f__mg$cacheDB = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattlePrepareUIController.set_m_terrainInfoImage);
		}
		LuaObject.addMember(l, name50, get50, Lua_BlackJack_ProjectL_UI_BattlePrepareUIController.<>f__mg$cacheDB, true);
		string name51 = "m_terrainInfoDefText";
		if (Lua_BlackJack_ProjectL_UI_BattlePrepareUIController.<>f__mg$cacheDC == null)
		{
			Lua_BlackJack_ProjectL_UI_BattlePrepareUIController.<>f__mg$cacheDC = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattlePrepareUIController.get_m_terrainInfoDefText);
		}
		LuaCSFunction get51 = Lua_BlackJack_ProjectL_UI_BattlePrepareUIController.<>f__mg$cacheDC;
		if (Lua_BlackJack_ProjectL_UI_BattlePrepareUIController.<>f__mg$cacheDD == null)
		{
			Lua_BlackJack_ProjectL_UI_BattlePrepareUIController.<>f__mg$cacheDD = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattlePrepareUIController.set_m_terrainInfoDefText);
		}
		LuaObject.addMember(l, name51, get51, Lua_BlackJack_ProjectL_UI_BattlePrepareUIController.<>f__mg$cacheDD, true);
		string name52 = "m_prefabsGameObject";
		if (Lua_BlackJack_ProjectL_UI_BattlePrepareUIController.<>f__mg$cacheDE == null)
		{
			Lua_BlackJack_ProjectL_UI_BattlePrepareUIController.<>f__mg$cacheDE = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattlePrepareUIController.get_m_prefabsGameObject);
		}
		LuaCSFunction get52 = Lua_BlackJack_ProjectL_UI_BattlePrepareUIController.<>f__mg$cacheDE;
		if (Lua_BlackJack_ProjectL_UI_BattlePrepareUIController.<>f__mg$cacheDF == null)
		{
			Lua_BlackJack_ProjectL_UI_BattlePrepareUIController.<>f__mg$cacheDF = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattlePrepareUIController.set_m_prefabsGameObject);
		}
		LuaObject.addMember(l, name52, get52, Lua_BlackJack_ProjectL_UI_BattlePrepareUIController.<>f__mg$cacheDF, true);
		string name53 = "m_heroButtonPrefab";
		if (Lua_BlackJack_ProjectL_UI_BattlePrepareUIController.<>f__mg$cacheE0 == null)
		{
			Lua_BlackJack_ProjectL_UI_BattlePrepareUIController.<>f__mg$cacheE0 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattlePrepareUIController.get_m_heroButtonPrefab);
		}
		LuaCSFunction get53 = Lua_BlackJack_ProjectL_UI_BattlePrepareUIController.<>f__mg$cacheE0;
		if (Lua_BlackJack_ProjectL_UI_BattlePrepareUIController.<>f__mg$cacheE1 == null)
		{
			Lua_BlackJack_ProjectL_UI_BattlePrepareUIController.<>f__mg$cacheE1 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattlePrepareUIController.set_m_heroButtonPrefab);
		}
		LuaObject.addMember(l, name53, get53, Lua_BlackJack_ProjectL_UI_BattlePrepareUIController.<>f__mg$cacheE1, true);
		string name54 = "m_armyRelationButtonUIStateController";
		if (Lua_BlackJack_ProjectL_UI_BattlePrepareUIController.<>f__mg$cacheE2 == null)
		{
			Lua_BlackJack_ProjectL_UI_BattlePrepareUIController.<>f__mg$cacheE2 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattlePrepareUIController.get_m_armyRelationButtonUIStateController);
		}
		LuaCSFunction get54 = Lua_BlackJack_ProjectL_UI_BattlePrepareUIController.<>f__mg$cacheE2;
		if (Lua_BlackJack_ProjectL_UI_BattlePrepareUIController.<>f__mg$cacheE3 == null)
		{
			Lua_BlackJack_ProjectL_UI_BattlePrepareUIController.<>f__mg$cacheE3 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattlePrepareUIController.set_m_armyRelationButtonUIStateController);
		}
		LuaObject.addMember(l, name54, get54, Lua_BlackJack_ProjectL_UI_BattlePrepareUIController.<>f__mg$cacheE3, true);
		string name55 = "m_armyRelationDescUIStateController";
		if (Lua_BlackJack_ProjectL_UI_BattlePrepareUIController.<>f__mg$cacheE4 == null)
		{
			Lua_BlackJack_ProjectL_UI_BattlePrepareUIController.<>f__mg$cacheE4 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattlePrepareUIController.get_m_armyRelationDescUIStateController);
		}
		LuaCSFunction get55 = Lua_BlackJack_ProjectL_UI_BattlePrepareUIController.<>f__mg$cacheE4;
		if (Lua_BlackJack_ProjectL_UI_BattlePrepareUIController.<>f__mg$cacheE5 == null)
		{
			Lua_BlackJack_ProjectL_UI_BattlePrepareUIController.<>f__mg$cacheE5 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattlePrepareUIController.set_m_armyRelationDescUIStateController);
		}
		LuaObject.addMember(l, name55, get55, Lua_BlackJack_ProjectL_UI_BattlePrepareUIController.<>f__mg$cacheE5, true);
		string name56 = "m_clientBattle";
		if (Lua_BlackJack_ProjectL_UI_BattlePrepareUIController.<>f__mg$cacheE6 == null)
		{
			Lua_BlackJack_ProjectL_UI_BattlePrepareUIController.<>f__mg$cacheE6 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattlePrepareUIController.get_m_clientBattle);
		}
		LuaCSFunction get56 = Lua_BlackJack_ProjectL_UI_BattlePrepareUIController.<>f__mg$cacheE6;
		if (Lua_BlackJack_ProjectL_UI_BattlePrepareUIController.<>f__mg$cacheE7 == null)
		{
			Lua_BlackJack_ProjectL_UI_BattlePrepareUIController.<>f__mg$cacheE7 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattlePrepareUIController.set_m_clientBattle);
		}
		LuaObject.addMember(l, name56, get56, Lua_BlackJack_ProjectL_UI_BattlePrepareUIController.<>f__mg$cacheE7, true);
		string name57 = "m_camera";
		if (Lua_BlackJack_ProjectL_UI_BattlePrepareUIController.<>f__mg$cacheE8 == null)
		{
			Lua_BlackJack_ProjectL_UI_BattlePrepareUIController.<>f__mg$cacheE8 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattlePrepareUIController.get_m_camera);
		}
		LuaCSFunction get57 = Lua_BlackJack_ProjectL_UI_BattlePrepareUIController.<>f__mg$cacheE8;
		if (Lua_BlackJack_ProjectL_UI_BattlePrepareUIController.<>f__mg$cacheE9 == null)
		{
			Lua_BlackJack_ProjectL_UI_BattlePrepareUIController.<>f__mg$cacheE9 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattlePrepareUIController.set_m_camera);
		}
		LuaObject.addMember(l, name57, get57, Lua_BlackJack_ProjectL_UI_BattlePrepareUIController.<>f__mg$cacheE9, true);
		string name58 = "m_chatRedPointLastTime";
		if (Lua_BlackJack_ProjectL_UI_BattlePrepareUIController.<>f__mg$cacheEA == null)
		{
			Lua_BlackJack_ProjectL_UI_BattlePrepareUIController.<>f__mg$cacheEA = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattlePrepareUIController.get_m_chatRedPointLastTime);
		}
		LuaCSFunction get58 = Lua_BlackJack_ProjectL_UI_BattlePrepareUIController.<>f__mg$cacheEA;
		if (Lua_BlackJack_ProjectL_UI_BattlePrepareUIController.<>f__mg$cacheEB == null)
		{
			Lua_BlackJack_ProjectL_UI_BattlePrepareUIController.<>f__mg$cacheEB = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattlePrepareUIController.set_m_chatRedPointLastTime);
		}
		LuaObject.addMember(l, name58, get58, Lua_BlackJack_ProjectL_UI_BattlePrepareUIController.<>f__mg$cacheEB, true);
		string name59 = "m_isIgnorePointerClick";
		if (Lua_BlackJack_ProjectL_UI_BattlePrepareUIController.<>f__mg$cacheEC == null)
		{
			Lua_BlackJack_ProjectL_UI_BattlePrepareUIController.<>f__mg$cacheEC = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattlePrepareUIController.get_m_isIgnorePointerClick);
		}
		LuaCSFunction get59 = Lua_BlackJack_ProjectL_UI_BattlePrepareUIController.<>f__mg$cacheEC;
		if (Lua_BlackJack_ProjectL_UI_BattlePrepareUIController.<>f__mg$cacheED == null)
		{
			Lua_BlackJack_ProjectL_UI_BattlePrepareUIController.<>f__mg$cacheED = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattlePrepareUIController.set_m_isIgnorePointerClick);
		}
		LuaObject.addMember(l, name59, get59, Lua_BlackJack_ProjectL_UI_BattlePrepareUIController.<>f__mg$cacheED, true);
		string name60 = "m_pointerDownStageActor";
		if (Lua_BlackJack_ProjectL_UI_BattlePrepareUIController.<>f__mg$cacheEE == null)
		{
			Lua_BlackJack_ProjectL_UI_BattlePrepareUIController.<>f__mg$cacheEE = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattlePrepareUIController.get_m_pointerDownStageActor);
		}
		LuaCSFunction get60 = Lua_BlackJack_ProjectL_UI_BattlePrepareUIController.<>f__mg$cacheEE;
		if (Lua_BlackJack_ProjectL_UI_BattlePrepareUIController.<>f__mg$cacheEF == null)
		{
			Lua_BlackJack_ProjectL_UI_BattlePrepareUIController.<>f__mg$cacheEF = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattlePrepareUIController.set_m_pointerDownStageActor);
		}
		LuaObject.addMember(l, name60, get60, Lua_BlackJack_ProjectL_UI_BattlePrepareUIController.<>f__mg$cacheEF, true);
		string name61 = "m_isIgnoreToggleEvent";
		if (Lua_BlackJack_ProjectL_UI_BattlePrepareUIController.<>f__mg$cacheF0 == null)
		{
			Lua_BlackJack_ProjectL_UI_BattlePrepareUIController.<>f__mg$cacheF0 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattlePrepareUIController.get_m_isIgnoreToggleEvent);
		}
		LuaCSFunction get61 = Lua_BlackJack_ProjectL_UI_BattlePrepareUIController.<>f__mg$cacheF0;
		if (Lua_BlackJack_ProjectL_UI_BattlePrepareUIController.<>f__mg$cacheF1 == null)
		{
			Lua_BlackJack_ProjectL_UI_BattlePrepareUIController.<>f__mg$cacheF1 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattlePrepareUIController.set_m_isIgnoreToggleEvent);
		}
		LuaObject.addMember(l, name61, get61, Lua_BlackJack_ProjectL_UI_BattlePrepareUIController.<>f__mg$cacheF1, true);
		string name62 = "m_isSkipStageActorGraphic";
		if (Lua_BlackJack_ProjectL_UI_BattlePrepareUIController.<>f__mg$cacheF2 == null)
		{
			Lua_BlackJack_ProjectL_UI_BattlePrepareUIController.<>f__mg$cacheF2 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattlePrepareUIController.get_m_isSkipStageActorGraphic);
		}
		LuaCSFunction get62 = Lua_BlackJack_ProjectL_UI_BattlePrepareUIController.<>f__mg$cacheF2;
		if (Lua_BlackJack_ProjectL_UI_BattlePrepareUIController.<>f__mg$cacheF3 == null)
		{
			Lua_BlackJack_ProjectL_UI_BattlePrepareUIController.<>f__mg$cacheF3 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattlePrepareUIController.set_m_isSkipStageActorGraphic);
		}
		LuaObject.addMember(l, name62, get62, Lua_BlackJack_ProjectL_UI_BattlePrepareUIController.<>f__mg$cacheF3, true);
		string name63 = "m_stageActorCountMax";
		if (Lua_BlackJack_ProjectL_UI_BattlePrepareUIController.<>f__mg$cacheF4 == null)
		{
			Lua_BlackJack_ProjectL_UI_BattlePrepareUIController.<>f__mg$cacheF4 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattlePrepareUIController.get_m_stageActorCountMax);
		}
		LuaCSFunction get63 = Lua_BlackJack_ProjectL_UI_BattlePrepareUIController.<>f__mg$cacheF4;
		if (Lua_BlackJack_ProjectL_UI_BattlePrepareUIController.<>f__mg$cacheF5 == null)
		{
			Lua_BlackJack_ProjectL_UI_BattlePrepareUIController.<>f__mg$cacheF5 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattlePrepareUIController.set_m_stageActorCountMax);
		}
		LuaObject.addMember(l, name63, get63, Lua_BlackJack_ProjectL_UI_BattlePrepareUIController.<>f__mg$cacheF5, true);
		string name64 = "m_turnStageActorCountMax";
		if (Lua_BlackJack_ProjectL_UI_BattlePrepareUIController.<>f__mg$cacheF6 == null)
		{
			Lua_BlackJack_ProjectL_UI_BattlePrepareUIController.<>f__mg$cacheF6 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattlePrepareUIController.get_m_turnStageActorCountMax);
		}
		LuaCSFunction get64 = Lua_BlackJack_ProjectL_UI_BattlePrepareUIController.<>f__mg$cacheF6;
		if (Lua_BlackJack_ProjectL_UI_BattlePrepareUIController.<>f__mg$cacheF7 == null)
		{
			Lua_BlackJack_ProjectL_UI_BattlePrepareUIController.<>f__mg$cacheF7 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattlePrepareUIController.set_m_turnStageActorCountMax);
		}
		LuaObject.addMember(l, name64, get64, Lua_BlackJack_ProjectL_UI_BattlePrepareUIController.<>f__mg$cacheF7, true);
		string name65 = "m_isStageActorChanged";
		if (Lua_BlackJack_ProjectL_UI_BattlePrepareUIController.<>f__mg$cacheF8 == null)
		{
			Lua_BlackJack_ProjectL_UI_BattlePrepareUIController.<>f__mg$cacheF8 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattlePrepareUIController.get_m_isStageActorChanged);
		}
		LuaCSFunction get65 = Lua_BlackJack_ProjectL_UI_BattlePrepareUIController.<>f__mg$cacheF8;
		if (Lua_BlackJack_ProjectL_UI_BattlePrepareUIController.<>f__mg$cacheF9 == null)
		{
			Lua_BlackJack_ProjectL_UI_BattlePrepareUIController.<>f__mg$cacheF9 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattlePrepareUIController.set_m_isStageActorChanged);
		}
		LuaObject.addMember(l, name65, get65, Lua_BlackJack_ProjectL_UI_BattlePrepareUIController.<>f__mg$cacheF9, true);
		string name66 = "m_heroButtons";
		if (Lua_BlackJack_ProjectL_UI_BattlePrepareUIController.<>f__mg$cacheFA == null)
		{
			Lua_BlackJack_ProjectL_UI_BattlePrepareUIController.<>f__mg$cacheFA = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattlePrepareUIController.get_m_heroButtons);
		}
		LuaCSFunction get66 = Lua_BlackJack_ProjectL_UI_BattlePrepareUIController.<>f__mg$cacheFA;
		if (Lua_BlackJack_ProjectL_UI_BattlePrepareUIController.<>f__mg$cacheFB == null)
		{
			Lua_BlackJack_ProjectL_UI_BattlePrepareUIController.<>f__mg$cacheFB = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattlePrepareUIController.set_m_heroButtons);
		}
		LuaObject.addMember(l, name66, get66, Lua_BlackJack_ProjectL_UI_BattlePrepareUIController.<>f__mg$cacheFB, true);
		string name67 = "m_stageActors";
		if (Lua_BlackJack_ProjectL_UI_BattlePrepareUIController.<>f__mg$cacheFC == null)
		{
			Lua_BlackJack_ProjectL_UI_BattlePrepareUIController.<>f__mg$cacheFC = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattlePrepareUIController.get_m_stageActors);
		}
		LuaCSFunction get67 = Lua_BlackJack_ProjectL_UI_BattlePrepareUIController.<>f__mg$cacheFC;
		if (Lua_BlackJack_ProjectL_UI_BattlePrepareUIController.<>f__mg$cacheFD == null)
		{
			Lua_BlackJack_ProjectL_UI_BattlePrepareUIController.<>f__mg$cacheFD = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattlePrepareUIController.set_m_stageActors);
		}
		LuaObject.addMember(l, name67, get67, Lua_BlackJack_ProjectL_UI_BattlePrepareUIController.<>f__mg$cacheFD, true);
		string name68 = "m_treasures";
		if (Lua_BlackJack_ProjectL_UI_BattlePrepareUIController.<>f__mg$cacheFE == null)
		{
			Lua_BlackJack_ProjectL_UI_BattlePrepareUIController.<>f__mg$cacheFE = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattlePrepareUIController.get_m_treasures);
		}
		LuaCSFunction get68 = Lua_BlackJack_ProjectL_UI_BattlePrepareUIController.<>f__mg$cacheFE;
		if (Lua_BlackJack_ProjectL_UI_BattlePrepareUIController.<>f__mg$cacheFF == null)
		{
			Lua_BlackJack_ProjectL_UI_BattlePrepareUIController.<>f__mg$cacheFF = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattlePrepareUIController.set_m_treasures);
		}
		LuaObject.addMember(l, name68, get68, Lua_BlackJack_ProjectL_UI_BattlePrepareUIController.<>f__mg$cacheFF, true);
		string name69 = "m_stagePositions";
		if (Lua_BlackJack_ProjectL_UI_BattlePrepareUIController.<>f__mg$cache100 == null)
		{
			Lua_BlackJack_ProjectL_UI_BattlePrepareUIController.<>f__mg$cache100 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattlePrepareUIController.get_m_stagePositions);
		}
		LuaCSFunction get69 = Lua_BlackJack_ProjectL_UI_BattlePrepareUIController.<>f__mg$cache100;
		if (Lua_BlackJack_ProjectL_UI_BattlePrepareUIController.<>f__mg$cache101 == null)
		{
			Lua_BlackJack_ProjectL_UI_BattlePrepareUIController.<>f__mg$cache101 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattlePrepareUIController.set_m_stagePositions);
		}
		LuaObject.addMember(l, name69, get69, Lua_BlackJack_ProjectL_UI_BattlePrepareUIController.<>f__mg$cache101, true);
		string name70 = "m_stageDirs";
		if (Lua_BlackJack_ProjectL_UI_BattlePrepareUIController.<>f__mg$cache102 == null)
		{
			Lua_BlackJack_ProjectL_UI_BattlePrepareUIController.<>f__mg$cache102 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattlePrepareUIController.get_m_stageDirs);
		}
		LuaCSFunction get70 = Lua_BlackJack_ProjectL_UI_BattlePrepareUIController.<>f__mg$cache102;
		if (Lua_BlackJack_ProjectL_UI_BattlePrepareUIController.<>f__mg$cache103 == null)
		{
			Lua_BlackJack_ProjectL_UI_BattlePrepareUIController.<>f__mg$cache103 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattlePrepareUIController.set_m_stageDirs);
		}
		LuaObject.addMember(l, name70, get70, Lua_BlackJack_ProjectL_UI_BattlePrepareUIController.<>f__mg$cache103, true);
		string name71 = "m_draggingHeroButton";
		if (Lua_BlackJack_ProjectL_UI_BattlePrepareUIController.<>f__mg$cache104 == null)
		{
			Lua_BlackJack_ProjectL_UI_BattlePrepareUIController.<>f__mg$cache104 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattlePrepareUIController.get_m_draggingHeroButton);
		}
		LuaCSFunction get71 = Lua_BlackJack_ProjectL_UI_BattlePrepareUIController.<>f__mg$cache104;
		if (Lua_BlackJack_ProjectL_UI_BattlePrepareUIController.<>f__mg$cache105 == null)
		{
			Lua_BlackJack_ProjectL_UI_BattlePrepareUIController.<>f__mg$cache105 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattlePrepareUIController.set_m_draggingHeroButton);
		}
		LuaObject.addMember(l, name71, get71, Lua_BlackJack_ProjectL_UI_BattlePrepareUIController.<>f__mg$cache105, true);
		string name72 = "s_testSoldierCount0";
		if (Lua_BlackJack_ProjectL_UI_BattlePrepareUIController.<>f__mg$cache106 == null)
		{
			Lua_BlackJack_ProjectL_UI_BattlePrepareUIController.<>f__mg$cache106 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattlePrepareUIController.get_s_testSoldierCount0);
		}
		LuaCSFunction get72 = Lua_BlackJack_ProjectL_UI_BattlePrepareUIController.<>f__mg$cache106;
		if (Lua_BlackJack_ProjectL_UI_BattlePrepareUIController.<>f__mg$cache107 == null)
		{
			Lua_BlackJack_ProjectL_UI_BattlePrepareUIController.<>f__mg$cache107 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattlePrepareUIController.set_s_testSoldierCount0);
		}
		LuaObject.addMember(l, name72, get72, Lua_BlackJack_ProjectL_UI_BattlePrepareUIController.<>f__mg$cache107, false);
		string name73 = "s_testSoldierCount1";
		if (Lua_BlackJack_ProjectL_UI_BattlePrepareUIController.<>f__mg$cache108 == null)
		{
			Lua_BlackJack_ProjectL_UI_BattlePrepareUIController.<>f__mg$cache108 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattlePrepareUIController.get_s_testSoldierCount1);
		}
		LuaCSFunction get73 = Lua_BlackJack_ProjectL_UI_BattlePrepareUIController.<>f__mg$cache108;
		if (Lua_BlackJack_ProjectL_UI_BattlePrepareUIController.<>f__mg$cache109 == null)
		{
			Lua_BlackJack_ProjectL_UI_BattlePrepareUIController.<>f__mg$cache109 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattlePrepareUIController.set_s_testSoldierCount1);
		}
		LuaObject.addMember(l, name73, get73, Lua_BlackJack_ProjectL_UI_BattlePrepareUIController.<>f__mg$cache109, false);
		string name74 = "s_testSkillId0";
		if (Lua_BlackJack_ProjectL_UI_BattlePrepareUIController.<>f__mg$cache10A == null)
		{
			Lua_BlackJack_ProjectL_UI_BattlePrepareUIController.<>f__mg$cache10A = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattlePrepareUIController.get_s_testSkillId0);
		}
		LuaCSFunction get74 = Lua_BlackJack_ProjectL_UI_BattlePrepareUIController.<>f__mg$cache10A;
		if (Lua_BlackJack_ProjectL_UI_BattlePrepareUIController.<>f__mg$cache10B == null)
		{
			Lua_BlackJack_ProjectL_UI_BattlePrepareUIController.<>f__mg$cache10B = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattlePrepareUIController.set_s_testSkillId0);
		}
		LuaObject.addMember(l, name74, get74, Lua_BlackJack_ProjectL_UI_BattlePrepareUIController.<>f__mg$cache10B, false);
		string name75 = "s_testSkillId1";
		if (Lua_BlackJack_ProjectL_UI_BattlePrepareUIController.<>f__mg$cache10C == null)
		{
			Lua_BlackJack_ProjectL_UI_BattlePrepareUIController.<>f__mg$cache10C = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattlePrepareUIController.get_s_testSkillId1);
		}
		LuaCSFunction get75 = Lua_BlackJack_ProjectL_UI_BattlePrepareUIController.<>f__mg$cache10C;
		if (Lua_BlackJack_ProjectL_UI_BattlePrepareUIController.<>f__mg$cache10D == null)
		{
			Lua_BlackJack_ProjectL_UI_BattlePrepareUIController.<>f__mg$cache10D = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattlePrepareUIController.set_s_testSkillId1);
		}
		LuaObject.addMember(l, name75, get75, Lua_BlackJack_ProjectL_UI_BattlePrepareUIController.<>f__mg$cache10D, false);
		string name76 = "s_testTalentId0";
		if (Lua_BlackJack_ProjectL_UI_BattlePrepareUIController.<>f__mg$cache10E == null)
		{
			Lua_BlackJack_ProjectL_UI_BattlePrepareUIController.<>f__mg$cache10E = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattlePrepareUIController.get_s_testTalentId0);
		}
		LuaCSFunction get76 = Lua_BlackJack_ProjectL_UI_BattlePrepareUIController.<>f__mg$cache10E;
		if (Lua_BlackJack_ProjectL_UI_BattlePrepareUIController.<>f__mg$cache10F == null)
		{
			Lua_BlackJack_ProjectL_UI_BattlePrepareUIController.<>f__mg$cache10F = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattlePrepareUIController.set_s_testTalentId0);
		}
		LuaObject.addMember(l, name76, get76, Lua_BlackJack_ProjectL_UI_BattlePrepareUIController.<>f__mg$cache10F, false);
		string name77 = "s_testTalentId1";
		if (Lua_BlackJack_ProjectL_UI_BattlePrepareUIController.<>f__mg$cache110 == null)
		{
			Lua_BlackJack_ProjectL_UI_BattlePrepareUIController.<>f__mg$cache110 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattlePrepareUIController.get_s_testTalentId1);
		}
		LuaCSFunction get77 = Lua_BlackJack_ProjectL_UI_BattlePrepareUIController.<>f__mg$cache110;
		if (Lua_BlackJack_ProjectL_UI_BattlePrepareUIController.<>f__mg$cache111 == null)
		{
			Lua_BlackJack_ProjectL_UI_BattlePrepareUIController.<>f__mg$cache111 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattlePrepareUIController.set_s_testTalentId1);
		}
		LuaObject.addMember(l, name77, get77, Lua_BlackJack_ProjectL_UI_BattlePrepareUIController.<>f__mg$cache111, false);
		string name78 = "s_isTestOnStage";
		if (Lua_BlackJack_ProjectL_UI_BattlePrepareUIController.<>f__mg$cache112 == null)
		{
			Lua_BlackJack_ProjectL_UI_BattlePrepareUIController.<>f__mg$cache112 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattlePrepareUIController.get_s_isTestOnStage);
		}
		LuaCSFunction get78 = Lua_BlackJack_ProjectL_UI_BattlePrepareUIController.<>f__mg$cache112;
		if (Lua_BlackJack_ProjectL_UI_BattlePrepareUIController.<>f__mg$cache113 == null)
		{
			Lua_BlackJack_ProjectL_UI_BattlePrepareUIController.<>f__mg$cache113 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattlePrepareUIController.set_s_isTestOnStage);
		}
		LuaObject.addMember(l, name78, get78, Lua_BlackJack_ProjectL_UI_BattlePrepareUIController.<>f__mg$cache113, false);
		string name79 = "m_battlePowerValue";
		if (Lua_BlackJack_ProjectL_UI_BattlePrepareUIController.<>f__mg$cache114 == null)
		{
			Lua_BlackJack_ProjectL_UI_BattlePrepareUIController.<>f__mg$cache114 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattlePrepareUIController.get_m_battlePowerValue);
		}
		LuaCSFunction get79 = Lua_BlackJack_ProjectL_UI_BattlePrepareUIController.<>f__mg$cache114;
		if (Lua_BlackJack_ProjectL_UI_BattlePrepareUIController.<>f__mg$cache115 == null)
		{
			Lua_BlackJack_ProjectL_UI_BattlePrepareUIController.<>f__mg$cache115 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattlePrepareUIController.set_m_battlePowerValue);
		}
		LuaObject.addMember(l, name79, get79, Lua_BlackJack_ProjectL_UI_BattlePrepareUIController.<>f__mg$cache115, true);
		string name80 = "m_setBattlePowerValueCoroutine";
		if (Lua_BlackJack_ProjectL_UI_BattlePrepareUIController.<>f__mg$cache116 == null)
		{
			Lua_BlackJack_ProjectL_UI_BattlePrepareUIController.<>f__mg$cache116 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattlePrepareUIController.get_m_setBattlePowerValueCoroutine);
		}
		LuaCSFunction get80 = Lua_BlackJack_ProjectL_UI_BattlePrepareUIController.<>f__mg$cache116;
		if (Lua_BlackJack_ProjectL_UI_BattlePrepareUIController.<>f__mg$cache117 == null)
		{
			Lua_BlackJack_ProjectL_UI_BattlePrepareUIController.<>f__mg$cache117 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattlePrepareUIController.set_m_setBattlePowerValueCoroutine);
		}
		LuaObject.addMember(l, name80, get80, Lua_BlackJack_ProjectL_UI_BattlePrepareUIController.<>f__mg$cache117, true);
		string name81 = "m_towerBattleRuleInfo";
		if (Lua_BlackJack_ProjectL_UI_BattlePrepareUIController.<>f__mg$cache118 == null)
		{
			Lua_BlackJack_ProjectL_UI_BattlePrepareUIController.<>f__mg$cache118 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattlePrepareUIController.get_m_towerBattleRuleInfo);
		}
		LuaCSFunction get81 = Lua_BlackJack_ProjectL_UI_BattlePrepareUIController.<>f__mg$cache118;
		if (Lua_BlackJack_ProjectL_UI_BattlePrepareUIController.<>f__mg$cache119 == null)
		{
			Lua_BlackJack_ProjectL_UI_BattlePrepareUIController.<>f__mg$cache119 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattlePrepareUIController.set_m_towerBattleRuleInfo);
		}
		LuaObject.addMember(l, name81, get81, Lua_BlackJack_ProjectL_UI_BattlePrepareUIController.<>f__mg$cache119, true);
		LuaObject.createTypeMetatable(l, null, typeof(BattlePrepareUIController), typeof(UIControllerBase));
	}

	// Token: 0x04011EB0 RID: 73392
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache0;

	// Token: 0x04011EB1 RID: 73393
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1;

	// Token: 0x04011EB2 RID: 73394
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2;

	// Token: 0x04011EB3 RID: 73395
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3;

	// Token: 0x04011EB4 RID: 73396
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache4;

	// Token: 0x04011EB5 RID: 73397
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache5;

	// Token: 0x04011EB6 RID: 73398
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache6;

	// Token: 0x04011EB7 RID: 73399
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache7;

	// Token: 0x04011EB8 RID: 73400
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache8;

	// Token: 0x04011EB9 RID: 73401
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache9;

	// Token: 0x04011EBA RID: 73402
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheA;

	// Token: 0x04011EBB RID: 73403
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheB;

	// Token: 0x04011EBC RID: 73404
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheC;

	// Token: 0x04011EBD RID: 73405
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheD;

	// Token: 0x04011EBE RID: 73406
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheE;

	// Token: 0x04011EBF RID: 73407
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheF;

	// Token: 0x04011EC0 RID: 73408
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache10;

	// Token: 0x04011EC1 RID: 73409
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache11;

	// Token: 0x04011EC2 RID: 73410
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache12;

	// Token: 0x04011EC3 RID: 73411
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache13;

	// Token: 0x04011EC4 RID: 73412
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache14;

	// Token: 0x04011EC5 RID: 73413
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache15;

	// Token: 0x04011EC6 RID: 73414
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache16;

	// Token: 0x04011EC7 RID: 73415
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache17;

	// Token: 0x04011EC8 RID: 73416
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache18;

	// Token: 0x04011EC9 RID: 73417
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache19;

	// Token: 0x04011ECA RID: 73418
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1A;

	// Token: 0x04011ECB RID: 73419
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1B;

	// Token: 0x04011ECC RID: 73420
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1C;

	// Token: 0x04011ECD RID: 73421
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1D;

	// Token: 0x04011ECE RID: 73422
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1E;

	// Token: 0x04011ECF RID: 73423
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1F;

	// Token: 0x04011ED0 RID: 73424
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache20;

	// Token: 0x04011ED1 RID: 73425
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache21;

	// Token: 0x04011ED2 RID: 73426
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache22;

	// Token: 0x04011ED3 RID: 73427
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache23;

	// Token: 0x04011ED4 RID: 73428
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache24;

	// Token: 0x04011ED5 RID: 73429
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache25;

	// Token: 0x04011ED6 RID: 73430
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache26;

	// Token: 0x04011ED7 RID: 73431
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache27;

	// Token: 0x04011ED8 RID: 73432
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache28;

	// Token: 0x04011ED9 RID: 73433
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache29;

	// Token: 0x04011EDA RID: 73434
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2A;

	// Token: 0x04011EDB RID: 73435
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2B;

	// Token: 0x04011EDC RID: 73436
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2C;

	// Token: 0x04011EDD RID: 73437
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2D;

	// Token: 0x04011EDE RID: 73438
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2E;

	// Token: 0x04011EDF RID: 73439
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2F;

	// Token: 0x04011EE0 RID: 73440
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache30;

	// Token: 0x04011EE1 RID: 73441
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache31;

	// Token: 0x04011EE2 RID: 73442
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache32;

	// Token: 0x04011EE3 RID: 73443
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache33;

	// Token: 0x04011EE4 RID: 73444
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache34;

	// Token: 0x04011EE5 RID: 73445
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache35;

	// Token: 0x04011EE6 RID: 73446
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache36;

	// Token: 0x04011EE7 RID: 73447
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache37;

	// Token: 0x04011EE8 RID: 73448
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache38;

	// Token: 0x04011EE9 RID: 73449
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache39;

	// Token: 0x04011EEA RID: 73450
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3A;

	// Token: 0x04011EEB RID: 73451
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3B;

	// Token: 0x04011EEC RID: 73452
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3C;

	// Token: 0x04011EED RID: 73453
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3D;

	// Token: 0x04011EEE RID: 73454
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3E;

	// Token: 0x04011EEF RID: 73455
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3F;

	// Token: 0x04011EF0 RID: 73456
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache40;

	// Token: 0x04011EF1 RID: 73457
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache41;

	// Token: 0x04011EF2 RID: 73458
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache42;

	// Token: 0x04011EF3 RID: 73459
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache43;

	// Token: 0x04011EF4 RID: 73460
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache44;

	// Token: 0x04011EF5 RID: 73461
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache45;

	// Token: 0x04011EF6 RID: 73462
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache46;

	// Token: 0x04011EF7 RID: 73463
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache47;

	// Token: 0x04011EF8 RID: 73464
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache48;

	// Token: 0x04011EF9 RID: 73465
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache49;

	// Token: 0x04011EFA RID: 73466
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache4A;

	// Token: 0x04011EFB RID: 73467
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache4B;

	// Token: 0x04011EFC RID: 73468
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache4C;

	// Token: 0x04011EFD RID: 73469
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache4D;

	// Token: 0x04011EFE RID: 73470
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache4E;

	// Token: 0x04011EFF RID: 73471
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache4F;

	// Token: 0x04011F00 RID: 73472
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache50;

	// Token: 0x04011F01 RID: 73473
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache51;

	// Token: 0x04011F02 RID: 73474
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache52;

	// Token: 0x04011F03 RID: 73475
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache53;

	// Token: 0x04011F04 RID: 73476
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache54;

	// Token: 0x04011F05 RID: 73477
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache55;

	// Token: 0x04011F06 RID: 73478
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache56;

	// Token: 0x04011F07 RID: 73479
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache57;

	// Token: 0x04011F08 RID: 73480
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache58;

	// Token: 0x04011F09 RID: 73481
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache59;

	// Token: 0x04011F0A RID: 73482
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache5A;

	// Token: 0x04011F0B RID: 73483
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache5B;

	// Token: 0x04011F0C RID: 73484
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache5C;

	// Token: 0x04011F0D RID: 73485
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache5D;

	// Token: 0x04011F0E RID: 73486
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache5E;

	// Token: 0x04011F0F RID: 73487
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache5F;

	// Token: 0x04011F10 RID: 73488
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache60;

	// Token: 0x04011F11 RID: 73489
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache61;

	// Token: 0x04011F12 RID: 73490
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache62;

	// Token: 0x04011F13 RID: 73491
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache63;

	// Token: 0x04011F14 RID: 73492
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache64;

	// Token: 0x04011F15 RID: 73493
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache65;

	// Token: 0x04011F16 RID: 73494
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache66;

	// Token: 0x04011F17 RID: 73495
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache67;

	// Token: 0x04011F18 RID: 73496
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache68;

	// Token: 0x04011F19 RID: 73497
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache69;

	// Token: 0x04011F1A RID: 73498
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache6A;

	// Token: 0x04011F1B RID: 73499
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache6B;

	// Token: 0x04011F1C RID: 73500
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache6C;

	// Token: 0x04011F1D RID: 73501
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache6D;

	// Token: 0x04011F1E RID: 73502
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache6E;

	// Token: 0x04011F1F RID: 73503
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache6F;

	// Token: 0x04011F20 RID: 73504
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache70;

	// Token: 0x04011F21 RID: 73505
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache71;

	// Token: 0x04011F22 RID: 73506
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache72;

	// Token: 0x04011F23 RID: 73507
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache73;

	// Token: 0x04011F24 RID: 73508
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache74;

	// Token: 0x04011F25 RID: 73509
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache75;

	// Token: 0x04011F26 RID: 73510
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache76;

	// Token: 0x04011F27 RID: 73511
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache77;

	// Token: 0x04011F28 RID: 73512
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache78;

	// Token: 0x04011F29 RID: 73513
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache79;

	// Token: 0x04011F2A RID: 73514
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache7A;

	// Token: 0x04011F2B RID: 73515
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache7B;

	// Token: 0x04011F2C RID: 73516
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache7C;

	// Token: 0x04011F2D RID: 73517
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache7D;

	// Token: 0x04011F2E RID: 73518
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache7E;

	// Token: 0x04011F2F RID: 73519
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache7F;

	// Token: 0x04011F30 RID: 73520
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache80;

	// Token: 0x04011F31 RID: 73521
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache81;

	// Token: 0x04011F32 RID: 73522
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache82;

	// Token: 0x04011F33 RID: 73523
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache83;

	// Token: 0x04011F34 RID: 73524
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache84;

	// Token: 0x04011F35 RID: 73525
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache85;

	// Token: 0x04011F36 RID: 73526
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache86;

	// Token: 0x04011F37 RID: 73527
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache87;

	// Token: 0x04011F38 RID: 73528
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache88;

	// Token: 0x04011F39 RID: 73529
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache89;

	// Token: 0x04011F3A RID: 73530
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache8A;

	// Token: 0x04011F3B RID: 73531
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache8B;

	// Token: 0x04011F3C RID: 73532
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache8C;

	// Token: 0x04011F3D RID: 73533
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache8D;

	// Token: 0x04011F3E RID: 73534
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache8E;

	// Token: 0x04011F3F RID: 73535
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache8F;

	// Token: 0x04011F40 RID: 73536
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache90;

	// Token: 0x04011F41 RID: 73537
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache91;

	// Token: 0x04011F42 RID: 73538
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache92;

	// Token: 0x04011F43 RID: 73539
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache93;

	// Token: 0x04011F44 RID: 73540
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache94;

	// Token: 0x04011F45 RID: 73541
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache95;

	// Token: 0x04011F46 RID: 73542
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache96;

	// Token: 0x04011F47 RID: 73543
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache97;

	// Token: 0x04011F48 RID: 73544
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache98;

	// Token: 0x04011F49 RID: 73545
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache99;

	// Token: 0x04011F4A RID: 73546
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache9A;

	// Token: 0x04011F4B RID: 73547
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache9B;

	// Token: 0x04011F4C RID: 73548
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache9C;

	// Token: 0x04011F4D RID: 73549
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache9D;

	// Token: 0x04011F4E RID: 73550
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache9E;

	// Token: 0x04011F4F RID: 73551
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache9F;

	// Token: 0x04011F50 RID: 73552
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheA0;

	// Token: 0x04011F51 RID: 73553
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheA1;

	// Token: 0x04011F52 RID: 73554
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheA2;

	// Token: 0x04011F53 RID: 73555
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheA3;

	// Token: 0x04011F54 RID: 73556
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheA4;

	// Token: 0x04011F55 RID: 73557
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheA5;

	// Token: 0x04011F56 RID: 73558
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheA6;

	// Token: 0x04011F57 RID: 73559
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheA7;

	// Token: 0x04011F58 RID: 73560
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheA8;

	// Token: 0x04011F59 RID: 73561
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheA9;

	// Token: 0x04011F5A RID: 73562
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheAA;

	// Token: 0x04011F5B RID: 73563
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheAB;

	// Token: 0x04011F5C RID: 73564
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheAC;

	// Token: 0x04011F5D RID: 73565
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheAD;

	// Token: 0x04011F5E RID: 73566
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheAE;

	// Token: 0x04011F5F RID: 73567
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheAF;

	// Token: 0x04011F60 RID: 73568
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheB0;

	// Token: 0x04011F61 RID: 73569
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheB1;

	// Token: 0x04011F62 RID: 73570
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheB2;

	// Token: 0x04011F63 RID: 73571
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheB3;

	// Token: 0x04011F64 RID: 73572
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheB4;

	// Token: 0x04011F65 RID: 73573
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheB5;

	// Token: 0x04011F66 RID: 73574
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheB6;

	// Token: 0x04011F67 RID: 73575
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheB7;

	// Token: 0x04011F68 RID: 73576
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheB8;

	// Token: 0x04011F69 RID: 73577
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheB9;

	// Token: 0x04011F6A RID: 73578
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheBA;

	// Token: 0x04011F6B RID: 73579
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheBB;

	// Token: 0x04011F6C RID: 73580
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheBC;

	// Token: 0x04011F6D RID: 73581
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheBD;

	// Token: 0x04011F6E RID: 73582
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheBE;

	// Token: 0x04011F6F RID: 73583
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheBF;

	// Token: 0x04011F70 RID: 73584
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheC0;

	// Token: 0x04011F71 RID: 73585
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheC1;

	// Token: 0x04011F72 RID: 73586
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheC2;

	// Token: 0x04011F73 RID: 73587
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheC3;

	// Token: 0x04011F74 RID: 73588
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheC4;

	// Token: 0x04011F75 RID: 73589
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheC5;

	// Token: 0x04011F76 RID: 73590
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheC6;

	// Token: 0x04011F77 RID: 73591
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheC7;

	// Token: 0x04011F78 RID: 73592
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheC8;

	// Token: 0x04011F79 RID: 73593
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheC9;

	// Token: 0x04011F7A RID: 73594
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheCA;

	// Token: 0x04011F7B RID: 73595
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheCB;

	// Token: 0x04011F7C RID: 73596
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheCC;

	// Token: 0x04011F7D RID: 73597
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheCD;

	// Token: 0x04011F7E RID: 73598
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheCE;

	// Token: 0x04011F7F RID: 73599
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheCF;

	// Token: 0x04011F80 RID: 73600
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheD0;

	// Token: 0x04011F81 RID: 73601
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheD1;

	// Token: 0x04011F82 RID: 73602
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheD2;

	// Token: 0x04011F83 RID: 73603
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheD3;

	// Token: 0x04011F84 RID: 73604
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheD4;

	// Token: 0x04011F85 RID: 73605
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheD5;

	// Token: 0x04011F86 RID: 73606
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheD6;

	// Token: 0x04011F87 RID: 73607
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheD7;

	// Token: 0x04011F88 RID: 73608
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheD8;

	// Token: 0x04011F89 RID: 73609
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheD9;

	// Token: 0x04011F8A RID: 73610
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheDA;

	// Token: 0x04011F8B RID: 73611
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheDB;

	// Token: 0x04011F8C RID: 73612
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheDC;

	// Token: 0x04011F8D RID: 73613
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheDD;

	// Token: 0x04011F8E RID: 73614
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheDE;

	// Token: 0x04011F8F RID: 73615
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheDF;

	// Token: 0x04011F90 RID: 73616
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheE0;

	// Token: 0x04011F91 RID: 73617
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheE1;

	// Token: 0x04011F92 RID: 73618
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheE2;

	// Token: 0x04011F93 RID: 73619
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheE3;

	// Token: 0x04011F94 RID: 73620
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheE4;

	// Token: 0x04011F95 RID: 73621
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheE5;

	// Token: 0x04011F96 RID: 73622
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheE6;

	// Token: 0x04011F97 RID: 73623
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheE7;

	// Token: 0x04011F98 RID: 73624
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheE8;

	// Token: 0x04011F99 RID: 73625
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheE9;

	// Token: 0x04011F9A RID: 73626
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheEA;

	// Token: 0x04011F9B RID: 73627
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheEB;

	// Token: 0x04011F9C RID: 73628
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheEC;

	// Token: 0x04011F9D RID: 73629
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheED;

	// Token: 0x04011F9E RID: 73630
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheEE;

	// Token: 0x04011F9F RID: 73631
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheEF;

	// Token: 0x04011FA0 RID: 73632
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheF0;

	// Token: 0x04011FA1 RID: 73633
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheF1;

	// Token: 0x04011FA2 RID: 73634
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheF2;

	// Token: 0x04011FA3 RID: 73635
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheF3;

	// Token: 0x04011FA4 RID: 73636
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheF4;

	// Token: 0x04011FA5 RID: 73637
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheF5;

	// Token: 0x04011FA6 RID: 73638
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheF6;

	// Token: 0x04011FA7 RID: 73639
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheF7;

	// Token: 0x04011FA8 RID: 73640
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheF8;

	// Token: 0x04011FA9 RID: 73641
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheF9;

	// Token: 0x04011FAA RID: 73642
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheFA;

	// Token: 0x04011FAB RID: 73643
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheFB;

	// Token: 0x04011FAC RID: 73644
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheFC;

	// Token: 0x04011FAD RID: 73645
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheFD;

	// Token: 0x04011FAE RID: 73646
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheFE;

	// Token: 0x04011FAF RID: 73647
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheFF;

	// Token: 0x04011FB0 RID: 73648
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache100;

	// Token: 0x04011FB1 RID: 73649
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache101;

	// Token: 0x04011FB2 RID: 73650
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache102;

	// Token: 0x04011FB3 RID: 73651
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache103;

	// Token: 0x04011FB4 RID: 73652
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache104;

	// Token: 0x04011FB5 RID: 73653
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache105;

	// Token: 0x04011FB6 RID: 73654
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache106;

	// Token: 0x04011FB7 RID: 73655
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache107;

	// Token: 0x04011FB8 RID: 73656
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache108;

	// Token: 0x04011FB9 RID: 73657
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache109;

	// Token: 0x04011FBA RID: 73658
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache10A;

	// Token: 0x04011FBB RID: 73659
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache10B;

	// Token: 0x04011FBC RID: 73660
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache10C;

	// Token: 0x04011FBD RID: 73661
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache10D;

	// Token: 0x04011FBE RID: 73662
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache10E;

	// Token: 0x04011FBF RID: 73663
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache10F;

	// Token: 0x04011FC0 RID: 73664
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache110;

	// Token: 0x04011FC1 RID: 73665
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache111;

	// Token: 0x04011FC2 RID: 73666
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache112;

	// Token: 0x04011FC3 RID: 73667
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache113;

	// Token: 0x04011FC4 RID: 73668
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache114;

	// Token: 0x04011FC5 RID: 73669
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache115;

	// Token: 0x04011FC6 RID: 73670
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache116;

	// Token: 0x04011FC7 RID: 73671
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache117;

	// Token: 0x04011FC8 RID: 73672
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache118;

	// Token: 0x04011FC9 RID: 73673
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache119;
}
