using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using BlackJack.BJFramework.Runtime.Prefab;
using BlackJack.BJFramework.Runtime.UI;
using BlackJack.ConfigData;
using BlackJack.ProjectL.Common;
using BlackJack.ProjectL.UI;
using SLua;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.Scripting;
using UnityEngine.UI;

// Token: 0x02001373 RID: 4979
[Preserve]
public class Lua_BlackJack_ProjectL_UI_ArenaDefendUIController : LuaObject
{
	// Token: 0x0601AE1B RID: 110107 RVA: 0x0080B6C4 File Offset: 0x008098C4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int Initialize(IntPtr l)
	{
		int result;
		try
		{
			ArenaDefendUIController arenaDefendUIController = (ArenaDefendUIController)LuaObject.checkSelf(l);
			ArenaDefendBattle battle;
			LuaObject.checkType<ArenaDefendBattle>(l, 2, out battle);
			arenaDefendUIController.Initialize(battle);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601AE1C RID: 110108 RVA: 0x0080B71C File Offset: 0x0080991C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int SetHeroActionOrders(IntPtr l)
	{
		int result;
		try
		{
			ArenaDefendUIController arenaDefendUIController = (ArenaDefendUIController)LuaObject.checkSelf(l);
			List<BattleHero> heroActionOrders;
			LuaObject.checkType<List<BattleHero>>(l, 2, out heroActionOrders);
			arenaDefendUIController.SetHeroActionOrders(heroActionOrders);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601AE1D RID: 110109 RVA: 0x0080B774 File Offset: 0x00809974
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int GetHeroActionOrderIndex(IntPtr l)
	{
		int result;
		try
		{
			ArenaDefendUIController arenaDefendUIController = (ArenaDefendUIController)LuaObject.checkSelf(l);
			BattleHero hero;
			LuaObject.checkType<BattleHero>(l, 2, out hero);
			int heroActionOrderIndex = arenaDefendUIController.GetHeroActionOrderIndex(hero);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, heroActionOrderIndex);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601AE1E RID: 110110 RVA: 0x0080B7D8 File Offset: 0x008099D8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int SetMaps(IntPtr l)
	{
		int result;
		try
		{
			ArenaDefendUIController arenaDefendUIController = (ArenaDefendUIController)LuaObject.checkSelf(l);
			List<ConfigDataArenaBattleInfo> battleInfos;
			LuaObject.checkType<List<ConfigDataArenaBattleInfo>>(l, 2, out battleInfos);
			int currentIndex;
			LuaObject.checkType(l, 3, out currentIndex);
			arenaDefendUIController.SetMaps(battleInfos, currentIndex);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601AE1F RID: 110111 RVA: 0x0080B83C File Offset: 0x00809A3C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int SetDefendRules(IntPtr l)
	{
		int result;
		try
		{
			ArenaDefendUIController arenaDefendUIController = (ArenaDefendUIController)LuaObject.checkSelf(l);
			List<ConfigDataArenaDefendRuleInfo> defendRuleInfos;
			LuaObject.checkType<List<ConfigDataArenaDefendRuleInfo>>(l, 2, out defendRuleInfos);
			int currentIndex;
			LuaObject.checkType(l, 3, out currentIndex);
			arenaDefendUIController.SetDefendRules(defendRuleInfos, currentIndex);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601AE20 RID: 110112 RVA: 0x0080B8A0 File Offset: 0x00809AA0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int SetBattlePower(IntPtr l)
	{
		int result;
		try
		{
			ArenaDefendUIController arenaDefendUIController = (ArenaDefendUIController)LuaObject.checkSelf(l);
			int battlePower;
			LuaObject.checkType(l, 2, out battlePower);
			arenaDefendUIController.SetBattlePower(battlePower);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601AE21 RID: 110113 RVA: 0x0080B8F8 File Offset: 0x00809AF8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int CheckStageAtorChange(IntPtr l)
	{
		int result;
		try
		{
			ArenaDefendUIController arenaDefendUIController = (ArenaDefendUIController)LuaObject.checkSelf(l);
			arenaDefendUIController.CheckStageAtorChange();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601AE22 RID: 110114 RVA: 0x0080B944 File Offset: 0x00809B44
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int SetStageActorCountMax(IntPtr l)
	{
		int result;
		try
		{
			ArenaDefendUIController arenaDefendUIController = (ArenaDefendUIController)LuaObject.checkSelf(l);
			int stageActorCountMax;
			LuaObject.checkType(l, 2, out stageActorCountMax);
			arenaDefendUIController.SetStageActorCountMax(stageActorCountMax);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601AE23 RID: 110115 RVA: 0x0080B99C File Offset: 0x00809B9C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int ClearHeros(IntPtr l)
	{
		int result;
		try
		{
			ArenaDefendUIController arenaDefendUIController = (ArenaDefendUIController)LuaObject.checkSelf(l);
			arenaDefendUIController.ClearHeros();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601AE24 RID: 110116 RVA: 0x0080B9E8 File Offset: 0x00809BE8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int AddHero(IntPtr l)
	{
		int result;
		try
		{
			ArenaDefendUIController arenaDefendUIController = (ArenaDefendUIController)LuaObject.checkSelf(l);
			BattleHero hero;
			LuaObject.checkType<BattleHero>(l, 2, out hero);
			arenaDefendUIController.AddHero(hero);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601AE25 RID: 110117 RVA: 0x0080BA40 File Offset: 0x00809C40
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int ClearStagePositions(IntPtr l)
	{
		int result;
		try
		{
			ArenaDefendUIController arenaDefendUIController = (ArenaDefendUIController)LuaObject.checkSelf(l);
			arenaDefendUIController.ClearStagePositions();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601AE26 RID: 110118 RVA: 0x0080BA8C File Offset: 0x00809C8C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int AddStagePosition(IntPtr l)
	{
		int result;
		try
		{
			ArenaDefendUIController arenaDefendUIController = (ArenaDefendUIController)LuaObject.checkSelf(l);
			GridPosition p;
			LuaObject.checkValueType<GridPosition>(l, 2, out p);
			int dir;
			LuaObject.checkType(l, 3, out dir);
			arenaDefendUIController.AddStagePosition(p, dir);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601AE27 RID: 110119 RVA: 0x0080BAF0 File Offset: 0x00809CF0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int GetStagePositions(IntPtr l)
	{
		int result;
		try
		{
			ArenaDefendUIController arenaDefendUIController = (ArenaDefendUIController)LuaObject.checkSelf(l);
			List<GridPosition> stagePositions = arenaDefendUIController.GetStagePositions();
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

	// Token: 0x0601AE28 RID: 110120 RVA: 0x0080BB44 File Offset: 0x00809D44
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int HeroOnStage(IntPtr l)
	{
		int result;
		try
		{
			ArenaDefendUIController arenaDefendUIController = (ArenaDefendUIController)LuaObject.checkSelf(l);
			BattleHero hero;
			LuaObject.checkType<BattleHero>(l, 2, out hero);
			GridPosition p;
			LuaObject.checkValueType<GridPosition>(l, 3, out p);
			ArenaDefendActor o = arenaDefendUIController.HeroOnStage(hero, p);
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

	// Token: 0x0601AE29 RID: 110121 RVA: 0x0080BBB4 File Offset: 0x00809DB4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int ActorOffStage(IntPtr l)
	{
		int result;
		try
		{
			ArenaDefendUIController arenaDefendUIController = (ArenaDefendUIController)LuaObject.checkSelf(l);
			ArenaDefendActor sa;
			LuaObject.checkType<ArenaDefendActor>(l, 2, out sa);
			arenaDefendUIController.ActorOffStage(sa);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601AE2A RID: 110122 RVA: 0x0080BC0C File Offset: 0x00809E0C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int ActorOnStageMove(IntPtr l)
	{
		int result;
		try
		{
			ArenaDefendUIController arenaDefendUIController = (ArenaDefendUIController)LuaObject.checkSelf(l);
			ArenaDefendActor sa;
			LuaObject.checkType<ArenaDefendActor>(l, 2, out sa);
			GridPosition p;
			LuaObject.checkValueType<GridPosition>(l, 3, out p);
			arenaDefendUIController.ActorOnStageMove(sa, p);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601AE2B RID: 110123 RVA: 0x0080BC70 File Offset: 0x00809E70
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int ActorOnStageExchange(IntPtr l)
	{
		int result;
		try
		{
			ArenaDefendUIController arenaDefendUIController = (ArenaDefendUIController)LuaObject.checkSelf(l);
			ArenaDefendActor sa;
			LuaObject.checkType<ArenaDefendActor>(l, 2, out sa);
			ArenaDefendActor sa2;
			LuaObject.checkType<ArenaDefendActor>(l, 3, out sa2);
			arenaDefendUIController.ActorOnStageExchange(sa, sa2);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601AE2C RID: 110124 RVA: 0x0080BCD4 File Offset: 0x00809ED4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int ClearStageActors(IntPtr l)
	{
		int result;
		try
		{
			ArenaDefendUIController arenaDefendUIController = (ArenaDefendUIController)LuaObject.checkSelf(l);
			arenaDefendUIController.ClearStageActors();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601AE2D RID: 110125 RVA: 0x0080BD20 File Offset: 0x00809F20
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int GetStageActor(IntPtr l)
	{
		int result;
		try
		{
			ArenaDefendUIController arenaDefendUIController = (ArenaDefendUIController)LuaObject.checkSelf(l);
			GridPosition p;
			LuaObject.checkValueType<GridPosition>(l, 2, out p);
			ArenaDefendActor stageActor = arenaDefendUIController.GetStageActor(p);
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

	// Token: 0x0601AE2E RID: 110126 RVA: 0x0080BD84 File Offset: 0x00809F84
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int GetStageActors(IntPtr l)
	{
		int result;
		try
		{
			ArenaDefendUIController arenaDefendUIController = (ArenaDefendUIController)LuaObject.checkSelf(l);
			List<ArenaDefendActor> stageActors = arenaDefendUIController.GetStageActors();
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

	// Token: 0x0601AE2F RID: 110127 RVA: 0x0080BDD8 File Offset: 0x00809FD8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int UpdateStageActor(IntPtr l)
	{
		int result;
		try
		{
			ArenaDefendUIController arenaDefendUIController = (ArenaDefendUIController)LuaObject.checkSelf(l);
			BattleHero hero;
			LuaObject.checkType<BattleHero>(l, 2, out hero);
			arenaDefendUIController.UpdateStageActor(hero);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601AE30 RID: 110128 RVA: 0x0080BE30 File Offset: 0x0080A030
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int HeroDragButton_OnBeginDrag(IntPtr l)
	{
		int result;
		try
		{
			ArenaDefendUIController arenaDefendUIController = (ArenaDefendUIController)LuaObject.checkSelf(l);
			HeroDragButton b;
			LuaObject.checkType<HeroDragButton>(l, 2, out b);
			PointerEventData eventData;
			LuaObject.checkType<PointerEventData>(l, 3, out eventData);
			arenaDefendUIController.HeroDragButton_OnBeginDrag(b, eventData);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601AE31 RID: 110129 RVA: 0x0080BE94 File Offset: 0x0080A094
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int HeroDragButton_OnEndDrag(IntPtr l)
	{
		int result;
		try
		{
			ArenaDefendUIController arenaDefendUIController = (ArenaDefendUIController)LuaObject.checkSelf(l);
			HeroDragButton b;
			LuaObject.checkType<HeroDragButton>(l, 2, out b);
			PointerEventData eventData;
			LuaObject.checkType<PointerEventData>(l, 3, out eventData);
			arenaDefendUIController.HeroDragButton_OnEndDrag(b, eventData);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601AE32 RID: 110130 RVA: 0x0080BEF8 File Offset: 0x0080A0F8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int HeroDragButton_OnDrag(IntPtr l)
	{
		int result;
		try
		{
			ArenaDefendUIController arenaDefendUIController = (ArenaDefendUIController)LuaObject.checkSelf(l);
			PointerEventData eventData;
			LuaObject.checkType<PointerEventData>(l, 2, out eventData);
			arenaDefendUIController.HeroDragButton_OnDrag(eventData);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601AE33 RID: 110131 RVA: 0x0080BF50 File Offset: 0x0080A150
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int HeroDragButton_OnDrop(IntPtr l)
	{
		int result;
		try
		{
			ArenaDefendUIController arenaDefendUIController = (ArenaDefendUIController)LuaObject.checkSelf(l);
			PointerEventData eventData;
			LuaObject.checkType<PointerEventData>(l, 2, out eventData);
			arenaDefendUIController.HeroDragButton_OnDrop(eventData);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601AE34 RID: 110132 RVA: 0x0080BFA8 File Offset: 0x0080A1A8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int HeroDragButton_OnClick(IntPtr l)
	{
		int result;
		try
		{
			ArenaDefendUIController arenaDefendUIController = (ArenaDefendUIController)LuaObject.checkSelf(l);
			HeroDragButton b;
			LuaObject.checkType<HeroDragButton>(l, 2, out b);
			arenaDefendUIController.HeroDragButton_OnClick(b);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601AE35 RID: 110133 RVA: 0x0080C000 File Offset: 0x0080A200
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int OnScenePointerDown(IntPtr l)
	{
		int result;
		try
		{
			ArenaDefendUIController arenaDefendUIController = (ArenaDefendUIController)LuaObject.checkSelf(l);
			PointerEventData eventData;
			LuaObject.checkType<PointerEventData>(l, 2, out eventData);
			arenaDefendUIController.OnScenePointerDown(eventData);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601AE36 RID: 110134 RVA: 0x0080C058 File Offset: 0x0080A258
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int OnScenePointerUp(IntPtr l)
	{
		int result;
		try
		{
			ArenaDefendUIController arenaDefendUIController = (ArenaDefendUIController)LuaObject.checkSelf(l);
			PointerEventData eventData;
			LuaObject.checkType<PointerEventData>(l, 2, out eventData);
			arenaDefendUIController.OnScenePointerUp(eventData);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601AE37 RID: 110135 RVA: 0x0080C0B0 File Offset: 0x0080A2B0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int OnScenePointerClick(IntPtr l)
	{
		int result;
		try
		{
			ArenaDefendUIController arenaDefendUIController = (ArenaDefendUIController)LuaObject.checkSelf(l);
			PointerEventData eventData;
			LuaObject.checkType<PointerEventData>(l, 2, out eventData);
			arenaDefendUIController.OnScenePointerClick(eventData);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601AE38 RID: 110136 RVA: 0x0080C108 File Offset: 0x0080A308
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int OnSceneBeginDrag(IntPtr l)
	{
		int result;
		try
		{
			ArenaDefendUIController arenaDefendUIController = (ArenaDefendUIController)LuaObject.checkSelf(l);
			PointerEventData eventData;
			LuaObject.checkType<PointerEventData>(l, 2, out eventData);
			arenaDefendUIController.OnSceneBeginDrag(eventData);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601AE39 RID: 110137 RVA: 0x0080C160 File Offset: 0x0080A360
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int OnSceneEndDrag(IntPtr l)
	{
		int result;
		try
		{
			ArenaDefendUIController arenaDefendUIController = (ArenaDefendUIController)LuaObject.checkSelf(l);
			PointerEventData eventData;
			LuaObject.checkType<PointerEventData>(l, 2, out eventData);
			arenaDefendUIController.OnSceneEndDrag(eventData);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601AE3A RID: 110138 RVA: 0x0080C1B8 File Offset: 0x0080A3B8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int OnSceneDrag(IntPtr l)
	{
		int result;
		try
		{
			ArenaDefendUIController arenaDefendUIController = (ArenaDefendUIController)LuaObject.checkSelf(l);
			PointerEventData eventData;
			LuaObject.checkType<PointerEventData>(l, 2, out eventData);
			arenaDefendUIController.OnSceneDrag(eventData);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601AE3B RID: 110139 RVA: 0x0080C210 File Offset: 0x0080A410
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int DropHeroButton(IntPtr l)
	{
		int result;
		try
		{
			ArenaDefendUIController arenaDefendUIController = (ArenaDefendUIController)LuaObject.checkSelf(l);
			Vector2 pos;
			LuaObject.checkType(l, 2, out pos);
			arenaDefendUIController.DropHeroButton(pos);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601AE3C RID: 110140 RVA: 0x0080C268 File Offset: 0x0080A468
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int ShowActionOrderPanel(IntPtr l)
	{
		int result;
		try
		{
			ArenaDefendUIController arenaDefendUIController = (ArenaDefendUIController)LuaObject.checkSelf(l);
			arenaDefendUIController.ShowActionOrderPanel();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601AE3D RID: 110141 RVA: 0x0080C2B4 File Offset: 0x0080A4B4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int ShowMapPanel(IntPtr l)
	{
		int result;
		try
		{
			ArenaDefendUIController arenaDefendUIController = (ArenaDefendUIController)LuaObject.checkSelf(l);
			arenaDefendUIController.ShowMapPanel();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601AE3E RID: 110142 RVA: 0x0080C300 File Offset: 0x0080A500
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int ShowDefendRulePanel(IntPtr l)
	{
		int result;
		try
		{
			ArenaDefendUIController arenaDefendUIController = (ArenaDefendUIController)LuaObject.checkSelf(l);
			arenaDefendUIController.ShowDefendRulePanel();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601AE3F RID: 110143 RVA: 0x0080C34C File Offset: 0x0080A54C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int OnBindFiledsCompleted(IntPtr l)
	{
		int result;
		try
		{
			ArenaDefendUIController arenaDefendUIController = (ArenaDefendUIController)LuaObject.checkSelf(l);
			arenaDefendUIController.m_luaExportHelper.OnBindFiledsCompleted();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601AE40 RID: 110144 RVA: 0x0080C3A0 File Offset: 0x0080A5A0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int OnDisable(IntPtr l)
	{
		int result;
		try
		{
			ArenaDefendUIController arenaDefendUIController = (ArenaDefendUIController)LuaObject.checkSelf(l);
			arenaDefendUIController.m_luaExportHelper.OnDisable();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601AE41 RID: 110145 RVA: 0x0080C3F4 File Offset: 0x0080A5F4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int OnApplicationPause(IntPtr l)
	{
		int result;
		try
		{
			ArenaDefendUIController arenaDefendUIController = (ArenaDefendUIController)LuaObject.checkSelf(l);
			bool isPause;
			LuaObject.checkType(l, 2, out isPause);
			arenaDefendUIController.m_luaExportHelper.OnApplicationPause(isPause);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601AE42 RID: 110146 RVA: 0x0080C450 File Offset: 0x0080A650
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int OnApplicationFocus(IntPtr l)
	{
		int result;
		try
		{
			ArenaDefendUIController arenaDefendUIController = (ArenaDefendUIController)LuaObject.checkSelf(l);
			bool focus;
			LuaObject.checkType(l, 2, out focus);
			arenaDefendUIController.m_luaExportHelper.OnApplicationFocus(focus);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601AE43 RID: 110147 RVA: 0x0080C4AC File Offset: 0x0080A6AC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int CancelDragging(IntPtr l)
	{
		int result;
		try
		{
			ArenaDefendUIController arenaDefendUIController = (ArenaDefendUIController)LuaObject.checkSelf(l);
			arenaDefendUIController.m_luaExportHelper.CancelDragging();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601AE44 RID: 110148 RVA: 0x0080C500 File Offset: 0x0080A700
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int Co_SetBattlePowerValue(IntPtr l)
	{
		int result;
		try
		{
			ArenaDefendUIController arenaDefendUIController = (ArenaDefendUIController)LuaObject.checkSelf(l);
			int newValue;
			LuaObject.checkType(l, 2, out newValue);
			int oldValue;
			LuaObject.checkType(l, 3, out oldValue);
			IEnumerator o = arenaDefendUIController.m_luaExportHelper.Co_SetBattlePowerValue(newValue, oldValue);
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

	// Token: 0x0601AE45 RID: 110149 RVA: 0x0080C574 File Offset: 0x0080A774
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int ClearBattlePowerValue(IntPtr l)
	{
		int result;
		try
		{
			ArenaDefendUIController arenaDefendUIController = (ArenaDefendUIController)LuaObject.checkSelf(l);
			arenaDefendUIController.m_luaExportHelper.ClearBattlePowerValue();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601AE46 RID: 110150 RVA: 0x0080C5C8 File Offset: 0x0080A7C8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int Update(IntPtr l)
	{
		int result;
		try
		{
			ArenaDefendUIController arenaDefendUIController = (ArenaDefendUIController)LuaObject.checkSelf(l);
			arenaDefendUIController.m_luaExportHelper.Update();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601AE47 RID: 110151 RVA: 0x0080C61C File Offset: 0x0080A81C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int UpdateStageActorCount(IntPtr l)
	{
		int result;
		try
		{
			ArenaDefendUIController arenaDefendUIController = (ArenaDefendUIController)LuaObject.checkSelf(l);
			arenaDefendUIController.m_luaExportHelper.UpdateStageActorCount();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601AE48 RID: 110152 RVA: 0x0080C670 File Offset: 0x0080A870
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int GetStageDirection(IntPtr l)
	{
		int result;
		try
		{
			ArenaDefendUIController arenaDefendUIController = (ArenaDefendUIController)LuaObject.checkSelf(l);
			GridPosition p;
			LuaObject.checkValueType<GridPosition>(l, 2, out p);
			int stageDirection = arenaDefendUIController.m_luaExportHelper.GetStageDirection(p);
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

	// Token: 0x0601AE49 RID: 110153 RVA: 0x0080C6D8 File Offset: 0x0080A8D8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int CreateHeroButton(IntPtr l)
	{
		int result;
		try
		{
			ArenaDefendUIController arenaDefendUIController = (ArenaDefendUIController)LuaObject.checkSelf(l);
			BattleHero hero;
			LuaObject.checkType<BattleHero>(l, 2, out hero);
			Transform parent;
			LuaObject.checkType<Transform>(l, 3, out parent);
			HeroDragButton o = arenaDefendUIController.m_luaExportHelper.CreateHeroButton(hero, parent);
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

	// Token: 0x0601AE4A RID: 110154 RVA: 0x0080C74C File Offset: 0x0080A94C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int HideActorInfo(IntPtr l)
	{
		int result;
		try
		{
			ArenaDefendUIController arenaDefendUIController = (ArenaDefendUIController)LuaObject.checkSelf(l);
			arenaDefendUIController.m_luaExportHelper.HideActorInfo();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601AE4B RID: 110155 RVA: 0x0080C7A0 File Offset: 0x0080A9A0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int ClearPointerDownStageActor(IntPtr l)
	{
		int result;
		try
		{
			ArenaDefendUIController arenaDefendUIController = (ArenaDefendUIController)LuaObject.checkSelf(l);
			arenaDefendUIController.m_luaExportHelper.ClearPointerDownStageActor();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601AE4C RID: 110156 RVA: 0x0080C7F4 File Offset: 0x0080A9F4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int CreateDraggingHeroButton(IntPtr l)
	{
		int result;
		try
		{
			ArenaDefendUIController arenaDefendUIController = (ArenaDefendUIController)LuaObject.checkSelf(l);
			BattleHero hero;
			LuaObject.checkType<BattleHero>(l, 2, out hero);
			arenaDefendUIController.m_luaExportHelper.CreateDraggingHeroButton(hero);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601AE4D RID: 110157 RVA: 0x0080C850 File Offset: 0x0080AA50
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int DestroyDragginHeroButton(IntPtr l)
	{
		int result;
		try
		{
			ArenaDefendUIController arenaDefendUIController = (ArenaDefendUIController)LuaObject.checkSelf(l);
			arenaDefendUIController.m_luaExportHelper.DestroyDragginHeroButton();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601AE4E RID: 110158 RVA: 0x0080C8A4 File Offset: 0x0080AAA4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int MoveDraggingHeroButton(IntPtr l)
	{
		int result;
		try
		{
			ArenaDefendUIController arenaDefendUIController = (ArenaDefendUIController)LuaObject.checkSelf(l);
			Vector2 pos;
			LuaObject.checkType(l, 2, out pos);
			arenaDefendUIController.m_luaExportHelper.MoveDraggingHeroButton(pos);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601AE4F RID: 110159 RVA: 0x0080C900 File Offset: 0x0080AB00
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int CreateActionOrderButton(IntPtr l)
	{
		int result;
		try
		{
			ArenaDefendUIController arenaDefendUIController = (ArenaDefendUIController)LuaObject.checkSelf(l);
			BattleHero hero;
			LuaObject.checkType<BattleHero>(l, 2, out hero);
			Transform parent;
			LuaObject.checkType<Transform>(l, 3, out parent);
			ArenaActionOrderButton o = arenaDefendUIController.m_luaExportHelper.CreateActionOrderButton(hero, parent);
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

	// Token: 0x0601AE50 RID: 110160 RVA: 0x0080C974 File Offset: 0x0080AB74
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int CreateDraggingActionOrderButton(IntPtr l)
	{
		int result;
		try
		{
			ArenaDefendUIController arenaDefendUIController = (ArenaDefendUIController)LuaObject.checkSelf(l);
			BattleHero hero;
			LuaObject.checkType<BattleHero>(l, 2, out hero);
			arenaDefendUIController.m_luaExportHelper.CreateDraggingActionOrderButton(hero);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601AE51 RID: 110161 RVA: 0x0080C9D0 File Offset: 0x0080ABD0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int DestroyDragginActionOrderButton(IntPtr l)
	{
		int result;
		try
		{
			ArenaDefendUIController arenaDefendUIController = (ArenaDefendUIController)LuaObject.checkSelf(l);
			arenaDefendUIController.m_luaExportHelper.DestroyDragginActionOrderButton();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601AE52 RID: 110162 RVA: 0x0080CA24 File Offset: 0x0080AC24
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int MoveDraggingActionOrderButton(IntPtr l)
	{
		int result;
		try
		{
			ArenaDefendUIController arenaDefendUIController = (ArenaDefendUIController)LuaObject.checkSelf(l);
			Vector2 pos;
			LuaObject.checkType(l, 2, out pos);
			arenaDefendUIController.m_luaExportHelper.MoveDraggingActionOrderButton(pos);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601AE53 RID: 110163 RVA: 0x0080CA80 File Offset: 0x0080AC80
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int DropDraggingActionOrderButton(IntPtr l)
	{
		int result;
		try
		{
			ArenaDefendUIController arenaDefendUIController = (ArenaDefendUIController)LuaObject.checkSelf(l);
			Vector2 pos;
			LuaObject.checkType(l, 2, out pos);
			arenaDefendUIController.m_luaExportHelper.DropDraggingActionOrderButton(pos);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601AE54 RID: 110164 RVA: 0x0080CADC File Offset: 0x0080ACDC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int OnReturnButtonClick(IntPtr l)
	{
		int result;
		try
		{
			ArenaDefendUIController arenaDefendUIController = (ArenaDefendUIController)LuaObject.checkSelf(l);
			arenaDefendUIController.m_luaExportHelper.OnReturnButtonClick();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601AE55 RID: 110165 RVA: 0x0080CB30 File Offset: 0x0080AD30
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int OnSaveTeamButtonClick(IntPtr l)
	{
		int result;
		try
		{
			ArenaDefendUIController arenaDefendUIController = (ArenaDefendUIController)LuaObject.checkSelf(l);
			arenaDefendUIController.m_luaExportHelper.OnSaveTeamButtonClick();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601AE56 RID: 110166 RVA: 0x0080CB84 File Offset: 0x0080AD84
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int OnShowActionOrderButtonClick(IntPtr l)
	{
		int result;
		try
		{
			ArenaDefendUIController arenaDefendUIController = (ArenaDefendUIController)LuaObject.checkSelf(l);
			arenaDefendUIController.m_luaExportHelper.OnShowActionOrderButtonClick();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601AE57 RID: 110167 RVA: 0x0080CBD8 File Offset: 0x0080ADD8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int OnShowMapButtonClick(IntPtr l)
	{
		int result;
		try
		{
			ArenaDefendUIController arenaDefendUIController = (ArenaDefendUIController)LuaObject.checkSelf(l);
			arenaDefendUIController.m_luaExportHelper.OnShowMapButtonClick();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601AE58 RID: 110168 RVA: 0x0080CC2C File Offset: 0x0080AE2C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int OnShowDefendRuleButtonClick(IntPtr l)
	{
		int result;
		try
		{
			ArenaDefendUIController arenaDefendUIController = (ArenaDefendUIController)LuaObject.checkSelf(l);
			arenaDefendUIController.m_luaExportHelper.OnShowDefendRuleButtonClick();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601AE59 RID: 110169 RVA: 0x0080CC80 File Offset: 0x0080AE80
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int OnPanelBackgroundButtonClick(IntPtr l)
	{
		int result;
		try
		{
			ArenaDefendUIController arenaDefendUIController = (ArenaDefendUIController)LuaObject.checkSelf(l);
			arenaDefendUIController.m_luaExportHelper.OnPanelBackgroundButtonClick();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601AE5A RID: 110170 RVA: 0x0080CCD4 File Offset: 0x0080AED4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int OnActionOrderOkButtonClick(IntPtr l)
	{
		int result;
		try
		{
			ArenaDefendUIController arenaDefendUIController = (ArenaDefendUIController)LuaObject.checkSelf(l);
			arenaDefendUIController.m_luaExportHelper.OnActionOrderOkButtonClick();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601AE5B RID: 110171 RVA: 0x0080CD28 File Offset: 0x0080AF28
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int ActionOrderButton_OnClick(IntPtr l)
	{
		int result;
		try
		{
			ArenaDefendUIController arenaDefendUIController = (ArenaDefendUIController)LuaObject.checkSelf(l);
			ArenaActionOrderButton b;
			LuaObject.checkType<ArenaActionOrderButton>(l, 2, out b);
			arenaDefendUIController.m_luaExportHelper.ActionOrderButton_OnClick(b);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601AE5C RID: 110172 RVA: 0x0080CD84 File Offset: 0x0080AF84
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int ActionOrderButton_OnBeginDrag(IntPtr l)
	{
		int result;
		try
		{
			ArenaDefendUIController arenaDefendUIController = (ArenaDefendUIController)LuaObject.checkSelf(l);
			ArenaActionOrderButton b;
			LuaObject.checkType<ArenaActionOrderButton>(l, 2, out b);
			PointerEventData eventData;
			LuaObject.checkType<PointerEventData>(l, 3, out eventData);
			arenaDefendUIController.m_luaExportHelper.ActionOrderButton_OnBeginDrag(b, eventData);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601AE5D RID: 110173 RVA: 0x0080CDF0 File Offset: 0x0080AFF0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int ActionOrderButton_OnEndDrag(IntPtr l)
	{
		int result;
		try
		{
			ArenaDefendUIController arenaDefendUIController = (ArenaDefendUIController)LuaObject.checkSelf(l);
			ArenaActionOrderButton b;
			LuaObject.checkType<ArenaActionOrderButton>(l, 2, out b);
			PointerEventData eventData;
			LuaObject.checkType<PointerEventData>(l, 3, out eventData);
			arenaDefendUIController.m_luaExportHelper.ActionOrderButton_OnEndDrag(b, eventData);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601AE5E RID: 110174 RVA: 0x0080CE5C File Offset: 0x0080B05C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int ActionOrderButton_OnDrag(IntPtr l)
	{
		int result;
		try
		{
			ArenaDefendUIController arenaDefendUIController = (ArenaDefendUIController)LuaObject.checkSelf(l);
			PointerEventData eventData;
			LuaObject.checkType<PointerEventData>(l, 2, out eventData);
			arenaDefendUIController.m_luaExportHelper.ActionOrderButton_OnDrag(eventData);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601AE5F RID: 110175 RVA: 0x0080CEB8 File Offset: 0x0080B0B8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int ActionOrderButton_OnDrop(IntPtr l)
	{
		int result;
		try
		{
			ArenaDefendUIController arenaDefendUIController = (ArenaDefendUIController)LuaObject.checkSelf(l);
			PointerEventData eventData;
			LuaObject.checkType<PointerEventData>(l, 2, out eventData);
			arenaDefendUIController.m_luaExportHelper.ActionOrderButton_OnDrop(eventData);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601AE60 RID: 110176 RVA: 0x0080CF14 File Offset: 0x0080B114
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int OnMapOkButtonClick(IntPtr l)
	{
		int result;
		try
		{
			ArenaDefendUIController arenaDefendUIController = (ArenaDefendUIController)LuaObject.checkSelf(l);
			arenaDefendUIController.m_luaExportHelper.OnMapOkButtonClick();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601AE61 RID: 110177 RVA: 0x0080CF68 File Offset: 0x0080B168
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int OnDefendRuleOkButtonClick(IntPtr l)
	{
		int result;
		try
		{
			ArenaDefendUIController arenaDefendUIController = (ArenaDefendUIController)LuaObject.checkSelf(l);
			arenaDefendUIController.m_luaExportHelper.OnDefendRuleOkButtonClick();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601AE62 RID: 110178 RVA: 0x0080CFBC File Offset: 0x0080B1BC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_Initlize(IntPtr l)
	{
		int result;
		try
		{
			ArenaDefendUIController arenaDefendUIController = (ArenaDefendUIController)LuaObject.checkSelf(l);
			string ctrlName;
			LuaObject.checkType(l, 2, out ctrlName);
			bool bindNow;
			LuaObject.checkType(l, 3, out bindNow);
			arenaDefendUIController.m_luaExportHelper.__callBase_Initlize(ctrlName, bindNow);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601AE63 RID: 110179 RVA: 0x0080D028 File Offset: 0x0080B228
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_BindFields(IntPtr l)
	{
		int result;
		try
		{
			ArenaDefendUIController arenaDefendUIController = (ArenaDefendUIController)LuaObject.checkSelf(l);
			arenaDefendUIController.m_luaExportHelper.__callBase_BindFields();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601AE64 RID: 110180 RVA: 0x0080D07C File Offset: 0x0080B27C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_OnBindFiledsCompleted(IntPtr l)
	{
		int result;
		try
		{
			ArenaDefendUIController arenaDefendUIController = (ArenaDefendUIController)LuaObject.checkSelf(l);
			arenaDefendUIController.m_luaExportHelper.__callBase_OnBindFiledsCompleted();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601AE65 RID: 110181 RVA: 0x0080D0D0 File Offset: 0x0080B2D0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_BindFieldImpl(IntPtr l)
	{
		int result;
		try
		{
			ArenaDefendUIController arenaDefendUIController = (ArenaDefendUIController)LuaObject.checkSelf(l);
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
			UnityEngine.Object o = arenaDefendUIController.m_luaExportHelper.__callBase_BindFieldImpl(fieldType, path, initState, fieldName, ctrlName, optional);
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

	// Token: 0x0601AE66 RID: 110182 RVA: 0x0080D178 File Offset: 0x0080B378
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_Clear(IntPtr l)
	{
		int result;
		try
		{
			ArenaDefendUIController arenaDefendUIController = (ArenaDefendUIController)LuaObject.checkSelf(l);
			arenaDefendUIController.m_luaExportHelper.__callBase_Clear();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601AE67 RID: 110183 RVA: 0x0080D1CC File Offset: 0x0080B3CC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_OnButtonClick(IntPtr l)
	{
		int result;
		try
		{
			ArenaDefendUIController arenaDefendUIController = (ArenaDefendUIController)LuaObject.checkSelf(l);
			Button button;
			LuaObject.checkType<Button>(l, 2, out button);
			string fieldName;
			LuaObject.checkType(l, 3, out fieldName);
			arenaDefendUIController.m_luaExportHelper.__callBase_OnButtonClick(button, fieldName);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601AE68 RID: 110184 RVA: 0x0080D238 File Offset: 0x0080B438
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
				ArenaDefendUIController arenaDefendUIController = (ArenaDefendUIController)LuaObject.checkSelf(l);
				string[] fieldNames;
				LuaObject.checkArray<string>(l, 2, out fieldNames);
				Action<UIControllerBase> action;
				LuaObject.checkDelegate<Action<UIControllerBase>>(l, 3, out action);
				arenaDefendUIController.m_luaExportHelper.__callBase_SetButtonClickListener(fieldNames, action);
				LuaObject.pushValue(l, true);
				result = 1;
			}
			else if (LuaObject.matchType(l, total, 2, typeof(string), typeof(Action<UIControllerBase>)))
			{
				ArenaDefendUIController arenaDefendUIController2 = (ArenaDefendUIController)LuaObject.checkSelf(l);
				string fieldName;
				LuaObject.checkType(l, 2, out fieldName);
				Action<UIControllerBase> action2;
				LuaObject.checkDelegate<Action<UIControllerBase>>(l, 3, out action2);
				arenaDefendUIController2.m_luaExportHelper.__callBase_SetButtonClickListener(fieldName, action2);
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

	// Token: 0x0601AE69 RID: 110185 RVA: 0x0080D348 File Offset: 0x0080B548
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_SetButtonDoubleClickListener(IntPtr l)
	{
		int result;
		try
		{
			ArenaDefendUIController arenaDefendUIController = (ArenaDefendUIController)LuaObject.checkSelf(l);
			string fieldName;
			LuaObject.checkType(l, 2, out fieldName);
			Action<UIControllerBase> action;
			LuaObject.checkDelegate<Action<UIControllerBase>>(l, 3, out action);
			arenaDefendUIController.m_luaExportHelper.__callBase_SetButtonDoubleClickListener(fieldName, action);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601AE6A RID: 110186 RVA: 0x0080D3B4 File Offset: 0x0080B5B4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_SetButtonLongPressStartListener(IntPtr l)
	{
		int result;
		try
		{
			ArenaDefendUIController arenaDefendUIController = (ArenaDefendUIController)LuaObject.checkSelf(l);
			string fieldName;
			LuaObject.checkType(l, 2, out fieldName);
			Action<UIControllerBase> action;
			LuaObject.checkDelegate<Action<UIControllerBase>>(l, 3, out action);
			arenaDefendUIController.m_luaExportHelper.__callBase_SetButtonLongPressStartListener(fieldName, action);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601AE6B RID: 110187 RVA: 0x0080D420 File Offset: 0x0080B620
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_SetButtonLongPressingListener(IntPtr l)
	{
		int result;
		try
		{
			ArenaDefendUIController arenaDefendUIController = (ArenaDefendUIController)LuaObject.checkSelf(l);
			string fieldName;
			LuaObject.checkType(l, 2, out fieldName);
			Action<UIControllerBase> action;
			LuaObject.checkDelegate<Action<UIControllerBase>>(l, 3, out action);
			arenaDefendUIController.m_luaExportHelper.__callBase_SetButtonLongPressingListener(fieldName, action);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601AE6C RID: 110188 RVA: 0x0080D48C File Offset: 0x0080B68C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_SetButtonLongPressEndListener(IntPtr l)
	{
		int result;
		try
		{
			ArenaDefendUIController arenaDefendUIController = (ArenaDefendUIController)LuaObject.checkSelf(l);
			string fieldName;
			LuaObject.checkType(l, 2, out fieldName);
			Action<UIControllerBase> action;
			LuaObject.checkDelegate<Action<UIControllerBase>>(l, 3, out action);
			arenaDefendUIController.m_luaExportHelper.__callBase_SetButtonLongPressEndListener(fieldName, action);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601AE6D RID: 110189 RVA: 0x0080D4F8 File Offset: 0x0080B6F8
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
				ArenaDefendUIController arenaDefendUIController = (ArenaDefendUIController)LuaObject.checkSelf(l);
				string[] fieldNames;
				LuaObject.checkArray<string>(l, 2, out fieldNames);
				Action<UIControllerBase, bool> action;
				LuaObject.checkDelegate<Action<UIControllerBase, bool>>(l, 3, out action);
				arenaDefendUIController.m_luaExportHelper.__callBase_SetToggleValueChangedListener(fieldNames, action);
				LuaObject.pushValue(l, true);
				result = 1;
			}
			else if (LuaObject.matchType(l, total, 2, typeof(string), typeof(Action<UIControllerBase, bool>)))
			{
				ArenaDefendUIController arenaDefendUIController2 = (ArenaDefendUIController)LuaObject.checkSelf(l);
				string fieldName;
				LuaObject.checkType(l, 2, out fieldName);
				Action<UIControllerBase, bool> action2;
				LuaObject.checkDelegate<Action<UIControllerBase, bool>>(l, 3, out action2);
				arenaDefendUIController2.m_luaExportHelper.__callBase_SetToggleValueChangedListener(fieldName, action2);
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

	// Token: 0x0601AE6E RID: 110190 RVA: 0x0080D608 File Offset: 0x0080B808
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_ToString(IntPtr l)
	{
		int result;
		try
		{
			ArenaDefendUIController arenaDefendUIController = (ArenaDefendUIController)LuaObject.checkSelf(l);
			string s = arenaDefendUIController.m_luaExportHelper.__callBase_ToString();
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

	// Token: 0x0601AE6F RID: 110191 RVA: 0x0080D664 File Offset: 0x0080B864
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callDele_EventOnReturn(IntPtr l)
	{
		int result;
		try
		{
			ArenaDefendUIController arenaDefendUIController = (ArenaDefendUIController)LuaObject.checkSelf(l);
			arenaDefendUIController.m_luaExportHelper.__callDele_EventOnReturn();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601AE70 RID: 110192 RVA: 0x0080D6B8 File Offset: 0x0080B8B8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __clearDele_EventOnReturn(IntPtr l)
	{
		int result;
		try
		{
			ArenaDefendUIController arenaDefendUIController = (ArenaDefendUIController)LuaObject.checkSelf(l);
			arenaDefendUIController.m_luaExportHelper.__clearDele_EventOnReturn();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601AE71 RID: 110193 RVA: 0x0080D70C File Offset: 0x0080B90C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callDele_EventOnSave(IntPtr l)
	{
		int result;
		try
		{
			ArenaDefendUIController arenaDefendUIController = (ArenaDefendUIController)LuaObject.checkSelf(l);
			arenaDefendUIController.m_luaExportHelper.__callDele_EventOnSave();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601AE72 RID: 110194 RVA: 0x0080D760 File Offset: 0x0080B960
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __clearDele_EventOnSave(IntPtr l)
	{
		int result;
		try
		{
			ArenaDefendUIController arenaDefendUIController = (ArenaDefendUIController)LuaObject.checkSelf(l);
			arenaDefendUIController.m_luaExportHelper.__clearDele_EventOnSave();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601AE73 RID: 110195 RVA: 0x0080D7B4 File Offset: 0x0080B9B4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callDele_EventOnShowActionOrderPanel(IntPtr l)
	{
		int result;
		try
		{
			ArenaDefendUIController arenaDefendUIController = (ArenaDefendUIController)LuaObject.checkSelf(l);
			arenaDefendUIController.m_luaExportHelper.__callDele_EventOnShowActionOrderPanel();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601AE74 RID: 110196 RVA: 0x0080D808 File Offset: 0x0080BA08
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __clearDele_EventOnShowActionOrderPanel(IntPtr l)
	{
		int result;
		try
		{
			ArenaDefendUIController arenaDefendUIController = (ArenaDefendUIController)LuaObject.checkSelf(l);
			arenaDefendUIController.m_luaExportHelper.__clearDele_EventOnShowActionOrderPanel();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601AE75 RID: 110197 RVA: 0x0080D85C File Offset: 0x0080BA5C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callDele_EventOnShowMapPanel(IntPtr l)
	{
		int result;
		try
		{
			ArenaDefendUIController arenaDefendUIController = (ArenaDefendUIController)LuaObject.checkSelf(l);
			arenaDefendUIController.m_luaExportHelper.__callDele_EventOnShowMapPanel();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601AE76 RID: 110198 RVA: 0x0080D8B0 File Offset: 0x0080BAB0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __clearDele_EventOnShowMapPanel(IntPtr l)
	{
		int result;
		try
		{
			ArenaDefendUIController arenaDefendUIController = (ArenaDefendUIController)LuaObject.checkSelf(l);
			arenaDefendUIController.m_luaExportHelper.__clearDele_EventOnShowMapPanel();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601AE77 RID: 110199 RVA: 0x0080D904 File Offset: 0x0080BB04
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callDele_EventOnShowDefendRulePanel(IntPtr l)
	{
		int result;
		try
		{
			ArenaDefendUIController arenaDefendUIController = (ArenaDefendUIController)LuaObject.checkSelf(l);
			arenaDefendUIController.m_luaExportHelper.__callDele_EventOnShowDefendRulePanel();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601AE78 RID: 110200 RVA: 0x0080D958 File Offset: 0x0080BB58
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __clearDele_EventOnShowDefendRulePanel(IntPtr l)
	{
		int result;
		try
		{
			ArenaDefendUIController arenaDefendUIController = (ArenaDefendUIController)LuaObject.checkSelf(l);
			arenaDefendUIController.m_luaExportHelper.__clearDele_EventOnShowDefendRulePanel();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601AE79 RID: 110201 RVA: 0x0080D9AC File Offset: 0x0080BBAC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callDele_EventOnConfirmActionOrder(IntPtr l)
	{
		int result;
		try
		{
			ArenaDefendUIController arenaDefendUIController = (ArenaDefendUIController)LuaObject.checkSelf(l);
			arenaDefendUIController.m_luaExportHelper.__callDele_EventOnConfirmActionOrder();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601AE7A RID: 110202 RVA: 0x0080DA00 File Offset: 0x0080BC00
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __clearDele_EventOnConfirmActionOrder(IntPtr l)
	{
		int result;
		try
		{
			ArenaDefendUIController arenaDefendUIController = (ArenaDefendUIController)LuaObject.checkSelf(l);
			arenaDefendUIController.m_luaExportHelper.__clearDele_EventOnConfirmActionOrder();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601AE7B RID: 110203 RVA: 0x0080DA54 File Offset: 0x0080BC54
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callDele_EventOnConfirmMap(IntPtr l)
	{
		int result;
		try
		{
			ArenaDefendUIController arenaDefendUIController = (ArenaDefendUIController)LuaObject.checkSelf(l);
			int obj;
			LuaObject.checkType(l, 2, out obj);
			arenaDefendUIController.m_luaExportHelper.__callDele_EventOnConfirmMap(obj);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601AE7C RID: 110204 RVA: 0x0080DAB0 File Offset: 0x0080BCB0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __clearDele_EventOnConfirmMap(IntPtr l)
	{
		int result;
		try
		{
			ArenaDefendUIController arenaDefendUIController = (ArenaDefendUIController)LuaObject.checkSelf(l);
			int obj;
			LuaObject.checkType(l, 2, out obj);
			arenaDefendUIController.m_luaExportHelper.__clearDele_EventOnConfirmMap(obj);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601AE7D RID: 110205 RVA: 0x0080DB0C File Offset: 0x0080BD0C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callDele_EventOnConfirmDefendRule(IntPtr l)
	{
		int result;
		try
		{
			ArenaDefendUIController arenaDefendUIController = (ArenaDefendUIController)LuaObject.checkSelf(l);
			int obj;
			LuaObject.checkType(l, 2, out obj);
			arenaDefendUIController.m_luaExportHelper.__callDele_EventOnConfirmDefendRule(obj);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601AE7E RID: 110206 RVA: 0x0080DB68 File Offset: 0x0080BD68
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __clearDele_EventOnConfirmDefendRule(IntPtr l)
	{
		int result;
		try
		{
			ArenaDefendUIController arenaDefendUIController = (ArenaDefendUIController)LuaObject.checkSelf(l);
			int obj;
			LuaObject.checkType(l, 2, out obj);
			arenaDefendUIController.m_luaExportHelper.__clearDele_EventOnConfirmDefendRule(obj);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601AE7F RID: 110207 RVA: 0x0080DBC4 File Offset: 0x0080BDC4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callDele_EventOnShowMyActorInfo(IntPtr l)
	{
		int result;
		try
		{
			ArenaDefendUIController arenaDefendUIController = (ArenaDefendUIController)LuaObject.checkSelf(l);
			BattleHero obj;
			LuaObject.checkType<BattleHero>(l, 2, out obj);
			arenaDefendUIController.m_luaExportHelper.__callDele_EventOnShowMyActorInfo(obj);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601AE80 RID: 110208 RVA: 0x0080DC20 File Offset: 0x0080BE20
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __clearDele_EventOnShowMyActorInfo(IntPtr l)
	{
		int result;
		try
		{
			ArenaDefendUIController arenaDefendUIController = (ArenaDefendUIController)LuaObject.checkSelf(l);
			BattleHero obj;
			LuaObject.checkType<BattleHero>(l, 2, out obj);
			arenaDefendUIController.m_luaExportHelper.__clearDele_EventOnShowMyActorInfo(obj);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601AE81 RID: 110209 RVA: 0x0080DC7C File Offset: 0x0080BE7C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callDele_EventOnHideActorInfo(IntPtr l)
	{
		int result;
		try
		{
			ArenaDefendUIController arenaDefendUIController = (ArenaDefendUIController)LuaObject.checkSelf(l);
			arenaDefendUIController.m_luaExportHelper.__callDele_EventOnHideActorInfo();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601AE82 RID: 110210 RVA: 0x0080DCD0 File Offset: 0x0080BED0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __clearDele_EventOnHideActorInfo(IntPtr l)
	{
		int result;
		try
		{
			ArenaDefendUIController arenaDefendUIController = (ArenaDefendUIController)LuaObject.checkSelf(l);
			arenaDefendUIController.m_luaExportHelper.__clearDele_EventOnHideActorInfo();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601AE83 RID: 110211 RVA: 0x0080DD24 File Offset: 0x0080BF24
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callDele_EventOnStageActorChange(IntPtr l)
	{
		int result;
		try
		{
			ArenaDefendUIController arenaDefendUIController = (ArenaDefendUIController)LuaObject.checkSelf(l);
			arenaDefendUIController.m_luaExportHelper.__callDele_EventOnStageActorChange();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601AE84 RID: 110212 RVA: 0x0080DD78 File Offset: 0x0080BF78
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __clearDele_EventOnStageActorChange(IntPtr l)
	{
		int result;
		try
		{
			ArenaDefendUIController arenaDefendUIController = (ArenaDefendUIController)LuaObject.checkSelf(l);
			arenaDefendUIController.m_luaExportHelper.__clearDele_EventOnStageActorChange();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601AE85 RID: 110213 RVA: 0x0080DDCC File Offset: 0x0080BFCC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callDele_EventOnHeroOnStage(IntPtr l)
	{
		int result;
		try
		{
			ArenaDefendUIController arenaDefendUIController = (ArenaDefendUIController)LuaObject.checkSelf(l);
			BattleHero arg;
			LuaObject.checkType<BattleHero>(l, 2, out arg);
			GridPosition arg2;
			LuaObject.checkValueType<GridPosition>(l, 3, out arg2);
			arenaDefendUIController.m_luaExportHelper.__callDele_EventOnHeroOnStage(arg, arg2);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601AE86 RID: 110214 RVA: 0x0080DE38 File Offset: 0x0080C038
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __clearDele_EventOnHeroOnStage(IntPtr l)
	{
		int result;
		try
		{
			ArenaDefendUIController arenaDefendUIController = (ArenaDefendUIController)LuaObject.checkSelf(l);
			BattleHero arg;
			LuaObject.checkType<BattleHero>(l, 2, out arg);
			GridPosition arg2;
			LuaObject.checkValueType<GridPosition>(l, 3, out arg2);
			arenaDefendUIController.m_luaExportHelper.__clearDele_EventOnHeroOnStage(arg, arg2);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601AE87 RID: 110215 RVA: 0x0080DEA4 File Offset: 0x0080C0A4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callDele_EventOnActorOffStage(IntPtr l)
	{
		int result;
		try
		{
			ArenaDefendUIController arenaDefendUIController = (ArenaDefendUIController)LuaObject.checkSelf(l);
			ArenaDefendActor obj;
			LuaObject.checkType<ArenaDefendActor>(l, 2, out obj);
			arenaDefendUIController.m_luaExportHelper.__callDele_EventOnActorOffStage(obj);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601AE88 RID: 110216 RVA: 0x0080DF00 File Offset: 0x0080C100
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __clearDele_EventOnActorOffStage(IntPtr l)
	{
		int result;
		try
		{
			ArenaDefendUIController arenaDefendUIController = (ArenaDefendUIController)LuaObject.checkSelf(l);
			ArenaDefendActor obj;
			LuaObject.checkType<ArenaDefendActor>(l, 2, out obj);
			arenaDefendUIController.m_luaExportHelper.__clearDele_EventOnActorOffStage(obj);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601AE89 RID: 110217 RVA: 0x0080DF5C File Offset: 0x0080C15C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callDele_EventOnStageActorMove(IntPtr l)
	{
		int result;
		try
		{
			ArenaDefendUIController arenaDefendUIController = (ArenaDefendUIController)LuaObject.checkSelf(l);
			ArenaDefendActor arg;
			LuaObject.checkType<ArenaDefendActor>(l, 2, out arg);
			GridPosition arg2;
			LuaObject.checkValueType<GridPosition>(l, 3, out arg2);
			arenaDefendUIController.m_luaExportHelper.__callDele_EventOnStageActorMove(arg, arg2);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601AE8A RID: 110218 RVA: 0x0080DFC8 File Offset: 0x0080C1C8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __clearDele_EventOnStageActorMove(IntPtr l)
	{
		int result;
		try
		{
			ArenaDefendUIController arenaDefendUIController = (ArenaDefendUIController)LuaObject.checkSelf(l);
			ArenaDefendActor arg;
			LuaObject.checkType<ArenaDefendActor>(l, 2, out arg);
			GridPosition arg2;
			LuaObject.checkValueType<GridPosition>(l, 3, out arg2);
			arenaDefendUIController.m_luaExportHelper.__clearDele_EventOnStageActorMove(arg, arg2);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601AE8B RID: 110219 RVA: 0x0080E034 File Offset: 0x0080C234
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callDele_EventOnStageActorSwap(IntPtr l)
	{
		int result;
		try
		{
			ArenaDefendUIController arenaDefendUIController = (ArenaDefendUIController)LuaObject.checkSelf(l);
			ArenaDefendActor arg;
			LuaObject.checkType<ArenaDefendActor>(l, 2, out arg);
			ArenaDefendActor arg2;
			LuaObject.checkType<ArenaDefendActor>(l, 3, out arg2);
			arenaDefendUIController.m_luaExportHelper.__callDele_EventOnStageActorSwap(arg, arg2);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601AE8C RID: 110220 RVA: 0x0080E0A0 File Offset: 0x0080C2A0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __clearDele_EventOnStageActorSwap(IntPtr l)
	{
		int result;
		try
		{
			ArenaDefendUIController arenaDefendUIController = (ArenaDefendUIController)LuaObject.checkSelf(l);
			ArenaDefendActor arg;
			LuaObject.checkType<ArenaDefendActor>(l, 2, out arg);
			ArenaDefendActor arg2;
			LuaObject.checkType<ArenaDefendActor>(l, 3, out arg2);
			arenaDefendUIController.m_luaExportHelper.__clearDele_EventOnStageActorSwap(arg, arg2);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601AE8D RID: 110221 RVA: 0x0080E10C File Offset: 0x0080C30C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callDele_EventOnPointerDown(IntPtr l)
	{
		int result;
		try
		{
			ArenaDefendUIController arenaDefendUIController = (ArenaDefendUIController)LuaObject.checkSelf(l);
			PointerEventData.InputButton arg;
			LuaObject.checkEnum<PointerEventData.InputButton>(l, 2, out arg);
			Vector2 arg2;
			LuaObject.checkType(l, 3, out arg2);
			arenaDefendUIController.m_luaExportHelper.__callDele_EventOnPointerDown(arg, arg2);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601AE8E RID: 110222 RVA: 0x0080E178 File Offset: 0x0080C378
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __clearDele_EventOnPointerDown(IntPtr l)
	{
		int result;
		try
		{
			ArenaDefendUIController arenaDefendUIController = (ArenaDefendUIController)LuaObject.checkSelf(l);
			PointerEventData.InputButton arg;
			LuaObject.checkEnum<PointerEventData.InputButton>(l, 2, out arg);
			Vector2 arg2;
			LuaObject.checkType(l, 3, out arg2);
			arenaDefendUIController.m_luaExportHelper.__clearDele_EventOnPointerDown(arg, arg2);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601AE8F RID: 110223 RVA: 0x0080E1E4 File Offset: 0x0080C3E4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callDele_EventOnPointerUp(IntPtr l)
	{
		int result;
		try
		{
			ArenaDefendUIController arenaDefendUIController = (ArenaDefendUIController)LuaObject.checkSelf(l);
			PointerEventData.InputButton arg;
			LuaObject.checkEnum<PointerEventData.InputButton>(l, 2, out arg);
			Vector2 arg2;
			LuaObject.checkType(l, 3, out arg2);
			arenaDefendUIController.m_luaExportHelper.__callDele_EventOnPointerUp(arg, arg2);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601AE90 RID: 110224 RVA: 0x0080E250 File Offset: 0x0080C450
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __clearDele_EventOnPointerUp(IntPtr l)
	{
		int result;
		try
		{
			ArenaDefendUIController arenaDefendUIController = (ArenaDefendUIController)LuaObject.checkSelf(l);
			PointerEventData.InputButton arg;
			LuaObject.checkEnum<PointerEventData.InputButton>(l, 2, out arg);
			Vector2 arg2;
			LuaObject.checkType(l, 3, out arg2);
			arenaDefendUIController.m_luaExportHelper.__clearDele_EventOnPointerUp(arg, arg2);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601AE91 RID: 110225 RVA: 0x0080E2BC File Offset: 0x0080C4BC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callDele_EventOnPointerClick(IntPtr l)
	{
		int result;
		try
		{
			ArenaDefendUIController arenaDefendUIController = (ArenaDefendUIController)LuaObject.checkSelf(l);
			PointerEventData.InputButton arg;
			LuaObject.checkEnum<PointerEventData.InputButton>(l, 2, out arg);
			Vector2 arg2;
			LuaObject.checkType(l, 3, out arg2);
			arenaDefendUIController.m_luaExportHelper.__callDele_EventOnPointerClick(arg, arg2);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601AE92 RID: 110226 RVA: 0x0080E328 File Offset: 0x0080C528
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __clearDele_EventOnPointerClick(IntPtr l)
	{
		int result;
		try
		{
			ArenaDefendUIController arenaDefendUIController = (ArenaDefendUIController)LuaObject.checkSelf(l);
			PointerEventData.InputButton arg;
			LuaObject.checkEnum<PointerEventData.InputButton>(l, 2, out arg);
			Vector2 arg2;
			LuaObject.checkType(l, 3, out arg2);
			arenaDefendUIController.m_luaExportHelper.__clearDele_EventOnPointerClick(arg, arg2);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601AE93 RID: 110227 RVA: 0x0080E394 File Offset: 0x0080C594
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_EventOnReturn(IntPtr l)
	{
		int result;
		try
		{
			ArenaDefendUIController arenaDefendUIController = (ArenaDefendUIController)LuaObject.checkSelf(l);
			Action value;
			int num = LuaObject.checkDelegate<Action>(l, 2, out value);
			if (num != 0)
			{
				if (num == 1)
				{
					arenaDefendUIController.EventOnReturn += value;
				}
				else if (num == 2)
				{
					arenaDefendUIController.EventOnReturn -= value;
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

	// Token: 0x0601AE94 RID: 110228 RVA: 0x0080E414 File Offset: 0x0080C614
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_EventOnSave(IntPtr l)
	{
		int result;
		try
		{
			ArenaDefendUIController arenaDefendUIController = (ArenaDefendUIController)LuaObject.checkSelf(l);
			Action value;
			int num = LuaObject.checkDelegate<Action>(l, 2, out value);
			if (num != 0)
			{
				if (num == 1)
				{
					arenaDefendUIController.EventOnSave += value;
				}
				else if (num == 2)
				{
					arenaDefendUIController.EventOnSave -= value;
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

	// Token: 0x0601AE95 RID: 110229 RVA: 0x0080E494 File Offset: 0x0080C694
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_EventOnShowActionOrderPanel(IntPtr l)
	{
		int result;
		try
		{
			ArenaDefendUIController arenaDefendUIController = (ArenaDefendUIController)LuaObject.checkSelf(l);
			Action value;
			int num = LuaObject.checkDelegate<Action>(l, 2, out value);
			if (num != 0)
			{
				if (num == 1)
				{
					arenaDefendUIController.EventOnShowActionOrderPanel += value;
				}
				else if (num == 2)
				{
					arenaDefendUIController.EventOnShowActionOrderPanel -= value;
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

	// Token: 0x0601AE96 RID: 110230 RVA: 0x0080E514 File Offset: 0x0080C714
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_EventOnShowMapPanel(IntPtr l)
	{
		int result;
		try
		{
			ArenaDefendUIController arenaDefendUIController = (ArenaDefendUIController)LuaObject.checkSelf(l);
			Action value;
			int num = LuaObject.checkDelegate<Action>(l, 2, out value);
			if (num != 0)
			{
				if (num == 1)
				{
					arenaDefendUIController.EventOnShowMapPanel += value;
				}
				else if (num == 2)
				{
					arenaDefendUIController.EventOnShowMapPanel -= value;
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

	// Token: 0x0601AE97 RID: 110231 RVA: 0x0080E594 File Offset: 0x0080C794
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_EventOnShowDefendRulePanel(IntPtr l)
	{
		int result;
		try
		{
			ArenaDefendUIController arenaDefendUIController = (ArenaDefendUIController)LuaObject.checkSelf(l);
			Action value;
			int num = LuaObject.checkDelegate<Action>(l, 2, out value);
			if (num != 0)
			{
				if (num == 1)
				{
					arenaDefendUIController.EventOnShowDefendRulePanel += value;
				}
				else if (num == 2)
				{
					arenaDefendUIController.EventOnShowDefendRulePanel -= value;
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

	// Token: 0x0601AE98 RID: 110232 RVA: 0x0080E614 File Offset: 0x0080C814
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_EventOnConfirmActionOrder(IntPtr l)
	{
		int result;
		try
		{
			ArenaDefendUIController arenaDefendUIController = (ArenaDefendUIController)LuaObject.checkSelf(l);
			Action value;
			int num = LuaObject.checkDelegate<Action>(l, 2, out value);
			if (num != 0)
			{
				if (num == 1)
				{
					arenaDefendUIController.EventOnConfirmActionOrder += value;
				}
				else if (num == 2)
				{
					arenaDefendUIController.EventOnConfirmActionOrder -= value;
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

	// Token: 0x0601AE99 RID: 110233 RVA: 0x0080E694 File Offset: 0x0080C894
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_EventOnConfirmMap(IntPtr l)
	{
		int result;
		try
		{
			ArenaDefendUIController arenaDefendUIController = (ArenaDefendUIController)LuaObject.checkSelf(l);
			Action<int> value;
			int num = LuaObject.checkDelegate<Action<int>>(l, 2, out value);
			if (num != 0)
			{
				if (num == 1)
				{
					arenaDefendUIController.EventOnConfirmMap += value;
				}
				else if (num == 2)
				{
					arenaDefendUIController.EventOnConfirmMap -= value;
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

	// Token: 0x0601AE9A RID: 110234 RVA: 0x0080E714 File Offset: 0x0080C914
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_EventOnConfirmDefendRule(IntPtr l)
	{
		int result;
		try
		{
			ArenaDefendUIController arenaDefendUIController = (ArenaDefendUIController)LuaObject.checkSelf(l);
			Action<int> value;
			int num = LuaObject.checkDelegate<Action<int>>(l, 2, out value);
			if (num != 0)
			{
				if (num == 1)
				{
					arenaDefendUIController.EventOnConfirmDefendRule += value;
				}
				else if (num == 2)
				{
					arenaDefendUIController.EventOnConfirmDefendRule -= value;
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

	// Token: 0x0601AE9B RID: 110235 RVA: 0x0080E794 File Offset: 0x0080C994
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_EventOnShowMyActorInfo(IntPtr l)
	{
		int result;
		try
		{
			ArenaDefendUIController arenaDefendUIController = (ArenaDefendUIController)LuaObject.checkSelf(l);
			Action<BattleHero> value;
			int num = LuaObject.checkDelegate<Action<BattleHero>>(l, 2, out value);
			if (num != 0)
			{
				if (num == 1)
				{
					arenaDefendUIController.EventOnShowMyActorInfo += value;
				}
				else if (num == 2)
				{
					arenaDefendUIController.EventOnShowMyActorInfo -= value;
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

	// Token: 0x0601AE9C RID: 110236 RVA: 0x0080E814 File Offset: 0x0080CA14
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_EventOnHideActorInfo(IntPtr l)
	{
		int result;
		try
		{
			ArenaDefendUIController arenaDefendUIController = (ArenaDefendUIController)LuaObject.checkSelf(l);
			Action value;
			int num = LuaObject.checkDelegate<Action>(l, 2, out value);
			if (num != 0)
			{
				if (num == 1)
				{
					arenaDefendUIController.EventOnHideActorInfo += value;
				}
				else if (num == 2)
				{
					arenaDefendUIController.EventOnHideActorInfo -= value;
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

	// Token: 0x0601AE9D RID: 110237 RVA: 0x0080E894 File Offset: 0x0080CA94
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_EventOnStageActorChange(IntPtr l)
	{
		int result;
		try
		{
			ArenaDefendUIController arenaDefendUIController = (ArenaDefendUIController)LuaObject.checkSelf(l);
			Action value;
			int num = LuaObject.checkDelegate<Action>(l, 2, out value);
			if (num != 0)
			{
				if (num == 1)
				{
					arenaDefendUIController.EventOnStageActorChange += value;
				}
				else if (num == 2)
				{
					arenaDefendUIController.EventOnStageActorChange -= value;
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

	// Token: 0x0601AE9E RID: 110238 RVA: 0x0080E914 File Offset: 0x0080CB14
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_EventOnHeroOnStage(IntPtr l)
	{
		int result;
		try
		{
			ArenaDefendUIController arenaDefendUIController = (ArenaDefendUIController)LuaObject.checkSelf(l);
			Action<BattleHero, GridPosition> value;
			int num = LuaObject.checkDelegate<Action<BattleHero, GridPosition>>(l, 2, out value);
			if (num != 0)
			{
				if (num == 1)
				{
					arenaDefendUIController.EventOnHeroOnStage += value;
				}
				else if (num == 2)
				{
					arenaDefendUIController.EventOnHeroOnStage -= value;
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

	// Token: 0x0601AE9F RID: 110239 RVA: 0x0080E994 File Offset: 0x0080CB94
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_EventOnActorOffStage(IntPtr l)
	{
		int result;
		try
		{
			ArenaDefendUIController arenaDefendUIController = (ArenaDefendUIController)LuaObject.checkSelf(l);
			Action<ArenaDefendActor> value;
			int num = LuaObject.checkDelegate<Action<ArenaDefendActor>>(l, 2, out value);
			if (num != 0)
			{
				if (num == 1)
				{
					arenaDefendUIController.EventOnActorOffStage += value;
				}
				else if (num == 2)
				{
					arenaDefendUIController.EventOnActorOffStage -= value;
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

	// Token: 0x0601AEA0 RID: 110240 RVA: 0x0080EA14 File Offset: 0x0080CC14
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_EventOnStageActorMove(IntPtr l)
	{
		int result;
		try
		{
			ArenaDefendUIController arenaDefendUIController = (ArenaDefendUIController)LuaObject.checkSelf(l);
			Action<ArenaDefendActor, GridPosition> value;
			int num = LuaObject.checkDelegate<Action<ArenaDefendActor, GridPosition>>(l, 2, out value);
			if (num != 0)
			{
				if (num == 1)
				{
					arenaDefendUIController.EventOnStageActorMove += value;
				}
				else if (num == 2)
				{
					arenaDefendUIController.EventOnStageActorMove -= value;
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

	// Token: 0x0601AEA1 RID: 110241 RVA: 0x0080EA94 File Offset: 0x0080CC94
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_EventOnStageActorSwap(IntPtr l)
	{
		int result;
		try
		{
			ArenaDefendUIController arenaDefendUIController = (ArenaDefendUIController)LuaObject.checkSelf(l);
			Action<ArenaDefendActor, ArenaDefendActor> value;
			int num = LuaObject.checkDelegate<Action<ArenaDefendActor, ArenaDefendActor>>(l, 2, out value);
			if (num != 0)
			{
				if (num == 1)
				{
					arenaDefendUIController.EventOnStageActorSwap += value;
				}
				else if (num == 2)
				{
					arenaDefendUIController.EventOnStageActorSwap -= value;
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

	// Token: 0x0601AEA2 RID: 110242 RVA: 0x0080EB14 File Offset: 0x0080CD14
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_EventOnPointerDown(IntPtr l)
	{
		int result;
		try
		{
			ArenaDefendUIController arenaDefendUIController = (ArenaDefendUIController)LuaObject.checkSelf(l);
			Action<PointerEventData.InputButton, Vector2> value;
			int num = LuaObject.checkDelegate<Action<PointerEventData.InputButton, Vector2>>(l, 2, out value);
			if (num != 0)
			{
				if (num == 1)
				{
					arenaDefendUIController.EventOnPointerDown += value;
				}
				else if (num == 2)
				{
					arenaDefendUIController.EventOnPointerDown -= value;
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

	// Token: 0x0601AEA3 RID: 110243 RVA: 0x0080EB94 File Offset: 0x0080CD94
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_EventOnPointerUp(IntPtr l)
	{
		int result;
		try
		{
			ArenaDefendUIController arenaDefendUIController = (ArenaDefendUIController)LuaObject.checkSelf(l);
			Action<PointerEventData.InputButton, Vector2> value;
			int num = LuaObject.checkDelegate<Action<PointerEventData.InputButton, Vector2>>(l, 2, out value);
			if (num != 0)
			{
				if (num == 1)
				{
					arenaDefendUIController.EventOnPointerUp += value;
				}
				else if (num == 2)
				{
					arenaDefendUIController.EventOnPointerUp -= value;
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

	// Token: 0x0601AEA4 RID: 110244 RVA: 0x0080EC14 File Offset: 0x0080CE14
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_EventOnPointerClick(IntPtr l)
	{
		int result;
		try
		{
			ArenaDefendUIController arenaDefendUIController = (ArenaDefendUIController)LuaObject.checkSelf(l);
			Action<PointerEventData.InputButton, Vector2> value;
			int num = LuaObject.checkDelegate<Action<PointerEventData.InputButton, Vector2>>(l, 2, out value);
			if (num != 0)
			{
				if (num == 1)
				{
					arenaDefendUIController.EventOnPointerClick += value;
				}
				else if (num == 2)
				{
					arenaDefendUIController.EventOnPointerClick -= value;
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

	// Token: 0x0601AEA5 RID: 110245 RVA: 0x0080EC94 File Offset: 0x0080CE94
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_marginTransform(IntPtr l)
	{
		int result;
		try
		{
			ArenaDefendUIController arenaDefendUIController = (ArenaDefendUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, arenaDefendUIController.m_luaExportHelper.m_marginTransform);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601AEA6 RID: 110246 RVA: 0x0080ECEC File Offset: 0x0080CEEC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_marginTransform(IntPtr l)
	{
		int result;
		try
		{
			ArenaDefendUIController arenaDefendUIController = (ArenaDefendUIController)LuaObject.checkSelf(l);
			RectTransform marginTransform;
			LuaObject.checkType<RectTransform>(l, 2, out marginTransform);
			arenaDefendUIController.m_luaExportHelper.m_marginTransform = marginTransform;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601AEA7 RID: 110247 RVA: 0x0080ED48 File Offset: 0x0080CF48
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_returnButton(IntPtr l)
	{
		int result;
		try
		{
			ArenaDefendUIController arenaDefendUIController = (ArenaDefendUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, arenaDefendUIController.m_luaExportHelper.m_returnButton);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601AEA8 RID: 110248 RVA: 0x0080EDA0 File Offset: 0x0080CFA0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_returnButton(IntPtr l)
	{
		int result;
		try
		{
			ArenaDefendUIController arenaDefendUIController = (ArenaDefendUIController)LuaObject.checkSelf(l);
			Button returnButton;
			LuaObject.checkType<Button>(l, 2, out returnButton);
			arenaDefendUIController.m_luaExportHelper.m_returnButton = returnButton;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601AEA9 RID: 110249 RVA: 0x0080EDFC File Offset: 0x0080CFFC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_saveTeamButton(IntPtr l)
	{
		int result;
		try
		{
			ArenaDefendUIController arenaDefendUIController = (ArenaDefendUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, arenaDefendUIController.m_luaExportHelper.m_saveTeamButton);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601AEAA RID: 110250 RVA: 0x0080EE54 File Offset: 0x0080D054
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_saveTeamButton(IntPtr l)
	{
		int result;
		try
		{
			ArenaDefendUIController arenaDefendUIController = (ArenaDefendUIController)LuaObject.checkSelf(l);
			Button saveTeamButton;
			LuaObject.checkType<Button>(l, 2, out saveTeamButton);
			arenaDefendUIController.m_luaExportHelper.m_saveTeamButton = saveTeamButton;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601AEAB RID: 110251 RVA: 0x0080EEB0 File Offset: 0x0080D0B0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_actionOrderButton(IntPtr l)
	{
		int result;
		try
		{
			ArenaDefendUIController arenaDefendUIController = (ArenaDefendUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, arenaDefendUIController.m_luaExportHelper.m_actionOrderButton);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601AEAC RID: 110252 RVA: 0x0080EF08 File Offset: 0x0080D108
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_actionOrderButton(IntPtr l)
	{
		int result;
		try
		{
			ArenaDefendUIController arenaDefendUIController = (ArenaDefendUIController)LuaObject.checkSelf(l);
			Button actionOrderButton;
			LuaObject.checkType<Button>(l, 2, out actionOrderButton);
			arenaDefendUIController.m_luaExportHelper.m_actionOrderButton = actionOrderButton;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601AEAD RID: 110253 RVA: 0x0080EF64 File Offset: 0x0080D164
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_mapButton(IntPtr l)
	{
		int result;
		try
		{
			ArenaDefendUIController arenaDefendUIController = (ArenaDefendUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, arenaDefendUIController.m_luaExportHelper.m_mapButton);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601AEAE RID: 110254 RVA: 0x0080EFBC File Offset: 0x0080D1BC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_mapButton(IntPtr l)
	{
		int result;
		try
		{
			ArenaDefendUIController arenaDefendUIController = (ArenaDefendUIController)LuaObject.checkSelf(l);
			Button mapButton;
			LuaObject.checkType<Button>(l, 2, out mapButton);
			arenaDefendUIController.m_luaExportHelper.m_mapButton = mapButton;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601AEAF RID: 110255 RVA: 0x0080F018 File Offset: 0x0080D218
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_defendRuleButton(IntPtr l)
	{
		int result;
		try
		{
			ArenaDefendUIController arenaDefendUIController = (ArenaDefendUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, arenaDefendUIController.m_luaExportHelper.m_defendRuleButton);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601AEB0 RID: 110256 RVA: 0x0080F070 File Offset: 0x0080D270
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_defendRuleButton(IntPtr l)
	{
		int result;
		try
		{
			ArenaDefendUIController arenaDefendUIController = (ArenaDefendUIController)LuaObject.checkSelf(l);
			Button defendRuleButton;
			LuaObject.checkType<Button>(l, 2, out defendRuleButton);
			arenaDefendUIController.m_luaExportHelper.m_defendRuleButton = defendRuleButton;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601AEB1 RID: 110257 RVA: 0x0080F0CC File Offset: 0x0080D2CC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_stageActorCountText(IntPtr l)
	{
		int result;
		try
		{
			ArenaDefendUIController arenaDefendUIController = (ArenaDefendUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, arenaDefendUIController.m_luaExportHelper.m_stageActorCountText);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601AEB2 RID: 110258 RVA: 0x0080F124 File Offset: 0x0080D324
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_stageActorCountText(IntPtr l)
	{
		int result;
		try
		{
			ArenaDefendUIController arenaDefendUIController = (ArenaDefendUIController)LuaObject.checkSelf(l);
			Text stageActorCountText;
			LuaObject.checkType<Text>(l, 2, out stageActorCountText);
			arenaDefendUIController.m_luaExportHelper.m_stageActorCountText = stageActorCountText;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601AEB3 RID: 110259 RVA: 0x0080F180 File Offset: 0x0080D380
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_actorListScrollRect(IntPtr l)
	{
		int result;
		try
		{
			ArenaDefendUIController arenaDefendUIController = (ArenaDefendUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, arenaDefendUIController.m_luaExportHelper.m_actorListScrollRect);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601AEB4 RID: 110260 RVA: 0x0080F1D8 File Offset: 0x0080D3D8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_actorListScrollRect(IntPtr l)
	{
		int result;
		try
		{
			ArenaDefendUIController arenaDefendUIController = (ArenaDefendUIController)LuaObject.checkSelf(l);
			ScrollRect actorListScrollRect;
			LuaObject.checkType<ScrollRect>(l, 2, out actorListScrollRect);
			arenaDefendUIController.m_luaExportHelper.m_actorListScrollRect = actorListScrollRect;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601AEB5 RID: 110261 RVA: 0x0080F234 File Offset: 0x0080D434
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_battlePowerUIStateController(IntPtr l)
	{
		int result;
		try
		{
			ArenaDefendUIController arenaDefendUIController = (ArenaDefendUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, arenaDefendUIController.m_luaExportHelper.m_battlePowerUIStateController);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601AEB6 RID: 110262 RVA: 0x0080F28C File Offset: 0x0080D48C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_battlePowerUIStateController(IntPtr l)
	{
		int result;
		try
		{
			ArenaDefendUIController arenaDefendUIController = (ArenaDefendUIController)LuaObject.checkSelf(l);
			CommonUIStateController battlePowerUIStateController;
			LuaObject.checkType<CommonUIStateController>(l, 2, out battlePowerUIStateController);
			arenaDefendUIController.m_luaExportHelper.m_battlePowerUIStateController = battlePowerUIStateController;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601AEB7 RID: 110263 RVA: 0x0080F2E8 File Offset: 0x0080D4E8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_battlePowerText(IntPtr l)
	{
		int result;
		try
		{
			ArenaDefendUIController arenaDefendUIController = (ArenaDefendUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, arenaDefendUIController.m_luaExportHelper.m_battlePowerText);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601AEB8 RID: 110264 RVA: 0x0080F340 File Offset: 0x0080D540
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_battlePowerText(IntPtr l)
	{
		int result;
		try
		{
			ArenaDefendUIController arenaDefendUIController = (ArenaDefendUIController)LuaObject.checkSelf(l);
			Text battlePowerText;
			LuaObject.checkType<Text>(l, 2, out battlePowerText);
			arenaDefendUIController.m_luaExportHelper.m_battlePowerText = battlePowerText;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601AEB9 RID: 110265 RVA: 0x0080F39C File Offset: 0x0080D59C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_panelGameObject(IntPtr l)
	{
		int result;
		try
		{
			ArenaDefendUIController arenaDefendUIController = (ArenaDefendUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, arenaDefendUIController.m_luaExportHelper.m_panelGameObject);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601AEBA RID: 110266 RVA: 0x0080F3F4 File Offset: 0x0080D5F4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_panelGameObject(IntPtr l)
	{
		int result;
		try
		{
			ArenaDefendUIController arenaDefendUIController = (ArenaDefendUIController)LuaObject.checkSelf(l);
			GameObject panelGameObject;
			LuaObject.checkType<GameObject>(l, 2, out panelGameObject);
			arenaDefendUIController.m_luaExportHelper.m_panelGameObject = panelGameObject;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601AEBB RID: 110267 RVA: 0x0080F450 File Offset: 0x0080D650
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_panelBackgroundButton(IntPtr l)
	{
		int result;
		try
		{
			ArenaDefendUIController arenaDefendUIController = (ArenaDefendUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, arenaDefendUIController.m_luaExportHelper.m_panelBackgroundButton);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601AEBC RID: 110268 RVA: 0x0080F4A8 File Offset: 0x0080D6A8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_panelBackgroundButton(IntPtr l)
	{
		int result;
		try
		{
			ArenaDefendUIController arenaDefendUIController = (ArenaDefendUIController)LuaObject.checkSelf(l);
			Button panelBackgroundButton;
			LuaObject.checkType<Button>(l, 2, out panelBackgroundButton);
			arenaDefendUIController.m_luaExportHelper.m_panelBackgroundButton = panelBackgroundButton;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601AEBD RID: 110269 RVA: 0x0080F504 File Offset: 0x0080D704
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_actionOrderPanelUIStateController(IntPtr l)
	{
		int result;
		try
		{
			ArenaDefendUIController arenaDefendUIController = (ArenaDefendUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, arenaDefendUIController.m_luaExportHelper.m_actionOrderPanelUIStateController);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601AEBE RID: 110270 RVA: 0x0080F55C File Offset: 0x0080D75C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_actionOrderPanelUIStateController(IntPtr l)
	{
		int result;
		try
		{
			ArenaDefendUIController arenaDefendUIController = (ArenaDefendUIController)LuaObject.checkSelf(l);
			CommonUIStateController actionOrderPanelUIStateController;
			LuaObject.checkType<CommonUIStateController>(l, 2, out actionOrderPanelUIStateController);
			arenaDefendUIController.m_luaExportHelper.m_actionOrderPanelUIStateController = actionOrderPanelUIStateController;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601AEBF RID: 110271 RVA: 0x0080F5B8 File Offset: 0x0080D7B8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_actionOrderPanelGameObject(IntPtr l)
	{
		int result;
		try
		{
			ArenaDefendUIController arenaDefendUIController = (ArenaDefendUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, arenaDefendUIController.m_luaExportHelper.m_actionOrderPanelGameObject);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601AEC0 RID: 110272 RVA: 0x0080F610 File Offset: 0x0080D810
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_actionOrderPanelGameObject(IntPtr l)
	{
		int result;
		try
		{
			ArenaDefendUIController arenaDefendUIController = (ArenaDefendUIController)LuaObject.checkSelf(l);
			GameObject actionOrderPanelGameObject;
			LuaObject.checkType<GameObject>(l, 2, out actionOrderPanelGameObject);
			arenaDefendUIController.m_luaExportHelper.m_actionOrderPanelGameObject = actionOrderPanelGameObject;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601AEC1 RID: 110273 RVA: 0x0080F66C File Offset: 0x0080D86C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_actionOrdersGameObject(IntPtr l)
	{
		int result;
		try
		{
			ArenaDefendUIController arenaDefendUIController = (ArenaDefendUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, arenaDefendUIController.m_luaExportHelper.m_actionOrdersGameObject);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601AEC2 RID: 110274 RVA: 0x0080F6C4 File Offset: 0x0080D8C4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_actionOrdersGameObject(IntPtr l)
	{
		int result;
		try
		{
			ArenaDefendUIController arenaDefendUIController = (ArenaDefendUIController)LuaObject.checkSelf(l);
			GameObject actionOrdersGameObject;
			LuaObject.checkType<GameObject>(l, 2, out actionOrdersGameObject);
			arenaDefendUIController.m_luaExportHelper.m_actionOrdersGameObject = actionOrdersGameObject;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601AEC3 RID: 110275 RVA: 0x0080F720 File Offset: 0x0080D920
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_actionOrderOkButton(IntPtr l)
	{
		int result;
		try
		{
			ArenaDefendUIController arenaDefendUIController = (ArenaDefendUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, arenaDefendUIController.m_luaExportHelper.m_actionOrderOkButton);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601AEC4 RID: 110276 RVA: 0x0080F778 File Offset: 0x0080D978
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_actionOrderOkButton(IntPtr l)
	{
		int result;
		try
		{
			ArenaDefendUIController arenaDefendUIController = (ArenaDefendUIController)LuaObject.checkSelf(l);
			Button actionOrderOkButton;
			LuaObject.checkType<Button>(l, 2, out actionOrderOkButton);
			arenaDefendUIController.m_luaExportHelper.m_actionOrderOkButton = actionOrderOkButton;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601AEC5 RID: 110277 RVA: 0x0080F7D4 File Offset: 0x0080D9D4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_mapPanelUIStateController(IntPtr l)
	{
		int result;
		try
		{
			ArenaDefendUIController arenaDefendUIController = (ArenaDefendUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, arenaDefendUIController.m_luaExportHelper.m_mapPanelUIStateController);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601AEC6 RID: 110278 RVA: 0x0080F82C File Offset: 0x0080DA2C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_mapPanelUIStateController(IntPtr l)
	{
		int result;
		try
		{
			ArenaDefendUIController arenaDefendUIController = (ArenaDefendUIController)LuaObject.checkSelf(l);
			CommonUIStateController mapPanelUIStateController;
			LuaObject.checkType<CommonUIStateController>(l, 2, out mapPanelUIStateController);
			arenaDefendUIController.m_luaExportHelper.m_mapPanelUIStateController = mapPanelUIStateController;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601AEC7 RID: 110279 RVA: 0x0080F888 File Offset: 0x0080DA88
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_mapPanelGameObject(IntPtr l)
	{
		int result;
		try
		{
			ArenaDefendUIController arenaDefendUIController = (ArenaDefendUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, arenaDefendUIController.m_luaExportHelper.m_mapPanelGameObject);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601AEC8 RID: 110280 RVA: 0x0080F8E0 File Offset: 0x0080DAE0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_mapPanelGameObject(IntPtr l)
	{
		int result;
		try
		{
			ArenaDefendUIController arenaDefendUIController = (ArenaDefendUIController)LuaObject.checkSelf(l);
			GameObject mapPanelGameObject;
			LuaObject.checkType<GameObject>(l, 2, out mapPanelGameObject);
			arenaDefendUIController.m_luaExportHelper.m_mapPanelGameObject = mapPanelGameObject;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601AEC9 RID: 110281 RVA: 0x0080F93C File Offset: 0x0080DB3C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_mapsGameObject(IntPtr l)
	{
		int result;
		try
		{
			ArenaDefendUIController arenaDefendUIController = (ArenaDefendUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, arenaDefendUIController.m_luaExportHelper.m_mapsGameObject);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601AECA RID: 110282 RVA: 0x0080F994 File Offset: 0x0080DB94
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_mapsGameObject(IntPtr l)
	{
		int result;
		try
		{
			ArenaDefendUIController arenaDefendUIController = (ArenaDefendUIController)LuaObject.checkSelf(l);
			GameObject mapsGameObject;
			LuaObject.checkType<GameObject>(l, 2, out mapsGameObject);
			arenaDefendUIController.m_luaExportHelper.m_mapsGameObject = mapsGameObject;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601AECB RID: 110283 RVA: 0x0080F9F0 File Offset: 0x0080DBF0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_mapOkButton(IntPtr l)
	{
		int result;
		try
		{
			ArenaDefendUIController arenaDefendUIController = (ArenaDefendUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, arenaDefendUIController.m_luaExportHelper.m_mapOkButton);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601AECC RID: 110284 RVA: 0x0080FA48 File Offset: 0x0080DC48
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_mapOkButton(IntPtr l)
	{
		int result;
		try
		{
			ArenaDefendUIController arenaDefendUIController = (ArenaDefendUIController)LuaObject.checkSelf(l);
			Button mapOkButton;
			LuaObject.checkType<Button>(l, 2, out mapOkButton);
			arenaDefendUIController.m_luaExportHelper.m_mapOkButton = mapOkButton;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601AECD RID: 110285 RVA: 0x0080FAA4 File Offset: 0x0080DCA4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_defendRulePanelUIStateController(IntPtr l)
	{
		int result;
		try
		{
			ArenaDefendUIController arenaDefendUIController = (ArenaDefendUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, arenaDefendUIController.m_luaExportHelper.m_defendRulePanelUIStateController);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601AECE RID: 110286 RVA: 0x0080FAFC File Offset: 0x0080DCFC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_defendRulePanelUIStateController(IntPtr l)
	{
		int result;
		try
		{
			ArenaDefendUIController arenaDefendUIController = (ArenaDefendUIController)LuaObject.checkSelf(l);
			CommonUIStateController defendRulePanelUIStateController;
			LuaObject.checkType<CommonUIStateController>(l, 2, out defendRulePanelUIStateController);
			arenaDefendUIController.m_luaExportHelper.m_defendRulePanelUIStateController = defendRulePanelUIStateController;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601AECF RID: 110287 RVA: 0x0080FB58 File Offset: 0x0080DD58
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_defendRulePanelGameObject(IntPtr l)
	{
		int result;
		try
		{
			ArenaDefendUIController arenaDefendUIController = (ArenaDefendUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, arenaDefendUIController.m_luaExportHelper.m_defendRulePanelGameObject);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601AED0 RID: 110288 RVA: 0x0080FBB0 File Offset: 0x0080DDB0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_defendRulePanelGameObject(IntPtr l)
	{
		int result;
		try
		{
			ArenaDefendUIController arenaDefendUIController = (ArenaDefendUIController)LuaObject.checkSelf(l);
			GameObject defendRulePanelGameObject;
			LuaObject.checkType<GameObject>(l, 2, out defendRulePanelGameObject);
			arenaDefendUIController.m_luaExportHelper.m_defendRulePanelGameObject = defendRulePanelGameObject;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601AED1 RID: 110289 RVA: 0x0080FC0C File Offset: 0x0080DE0C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_defendRulesGameObject(IntPtr l)
	{
		int result;
		try
		{
			ArenaDefendUIController arenaDefendUIController = (ArenaDefendUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, arenaDefendUIController.m_luaExportHelper.m_defendRulesGameObject);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601AED2 RID: 110290 RVA: 0x0080FC64 File Offset: 0x0080DE64
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_defendRulesGameObject(IntPtr l)
	{
		int result;
		try
		{
			ArenaDefendUIController arenaDefendUIController = (ArenaDefendUIController)LuaObject.checkSelf(l);
			GameObject defendRulesGameObject;
			LuaObject.checkType<GameObject>(l, 2, out defendRulesGameObject);
			arenaDefendUIController.m_luaExportHelper.m_defendRulesGameObject = defendRulesGameObject;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601AED3 RID: 110291 RVA: 0x0080FCC0 File Offset: 0x0080DEC0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_defendRuleOkButton(IntPtr l)
	{
		int result;
		try
		{
			ArenaDefendUIController arenaDefendUIController = (ArenaDefendUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, arenaDefendUIController.m_luaExportHelper.m_defendRuleOkButton);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601AED4 RID: 110292 RVA: 0x0080FD18 File Offset: 0x0080DF18
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_defendRuleOkButton(IntPtr l)
	{
		int result;
		try
		{
			ArenaDefendUIController arenaDefendUIController = (ArenaDefendUIController)LuaObject.checkSelf(l);
			Button defendRuleOkButton;
			LuaObject.checkType<Button>(l, 2, out defendRuleOkButton);
			arenaDefendUIController.m_luaExportHelper.m_defendRuleOkButton = defendRuleOkButton;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601AED5 RID: 110293 RVA: 0x0080FD74 File Offset: 0x0080DF74
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_prefabsGameObject(IntPtr l)
	{
		int result;
		try
		{
			ArenaDefendUIController arenaDefendUIController = (ArenaDefendUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, arenaDefendUIController.m_luaExportHelper.m_prefabsGameObject);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601AED6 RID: 110294 RVA: 0x0080FDCC File Offset: 0x0080DFCC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_prefabsGameObject(IntPtr l)
	{
		int result;
		try
		{
			ArenaDefendUIController arenaDefendUIController = (ArenaDefendUIController)LuaObject.checkSelf(l);
			GameObject prefabsGameObject;
			LuaObject.checkType<GameObject>(l, 2, out prefabsGameObject);
			arenaDefendUIController.m_luaExportHelper.m_prefabsGameObject = prefabsGameObject;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601AED7 RID: 110295 RVA: 0x0080FE28 File Offset: 0x0080E028
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_heroButtonPrefab(IntPtr l)
	{
		int result;
		try
		{
			ArenaDefendUIController arenaDefendUIController = (ArenaDefendUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, arenaDefendUIController.m_luaExportHelper.m_heroButtonPrefab);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601AED8 RID: 110296 RVA: 0x0080FE80 File Offset: 0x0080E080
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_heroButtonPrefab(IntPtr l)
	{
		int result;
		try
		{
			ArenaDefendUIController arenaDefendUIController = (ArenaDefendUIController)LuaObject.checkSelf(l);
			GameObject heroButtonPrefab;
			LuaObject.checkType<GameObject>(l, 2, out heroButtonPrefab);
			arenaDefendUIController.m_luaExportHelper.m_heroButtonPrefab = heroButtonPrefab;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601AED9 RID: 110297 RVA: 0x0080FEDC File Offset: 0x0080E0DC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_actionOrderButtonPrefab(IntPtr l)
	{
		int result;
		try
		{
			ArenaDefendUIController arenaDefendUIController = (ArenaDefendUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, arenaDefendUIController.m_luaExportHelper.m_actionOrderButtonPrefab);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601AEDA RID: 110298 RVA: 0x0080FF34 File Offset: 0x0080E134
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_actionOrderButtonPrefab(IntPtr l)
	{
		int result;
		try
		{
			ArenaDefendUIController arenaDefendUIController = (ArenaDefendUIController)LuaObject.checkSelf(l);
			GameObject actionOrderButtonPrefab;
			LuaObject.checkType<GameObject>(l, 2, out actionOrderButtonPrefab);
			arenaDefendUIController.m_luaExportHelper.m_actionOrderButtonPrefab = actionOrderButtonPrefab;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601AEDB RID: 110299 RVA: 0x0080FF90 File Offset: 0x0080E190
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_camera(IntPtr l)
	{
		int result;
		try
		{
			ArenaDefendUIController arenaDefendUIController = (ArenaDefendUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, arenaDefendUIController.m_luaExportHelper.m_camera);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601AEDC RID: 110300 RVA: 0x0080FFE8 File Offset: 0x0080E1E8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_camera(IntPtr l)
	{
		int result;
		try
		{
			ArenaDefendUIController arenaDefendUIController = (ArenaDefendUIController)LuaObject.checkSelf(l);
			Camera camera;
			LuaObject.checkType<Camera>(l, 2, out camera);
			arenaDefendUIController.m_luaExportHelper.m_camera = camera;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601AEDD RID: 110301 RVA: 0x00810044 File Offset: 0x0080E244
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_isIgnorePointerClick(IntPtr l)
	{
		int result;
		try
		{
			ArenaDefendUIController arenaDefendUIController = (ArenaDefendUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, arenaDefendUIController.m_luaExportHelper.m_isIgnorePointerClick);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601AEDE RID: 110302 RVA: 0x0081009C File Offset: 0x0080E29C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_isIgnorePointerClick(IntPtr l)
	{
		int result;
		try
		{
			ArenaDefendUIController arenaDefendUIController = (ArenaDefendUIController)LuaObject.checkSelf(l);
			bool isIgnorePointerClick;
			LuaObject.checkType(l, 2, out isIgnorePointerClick);
			arenaDefendUIController.m_luaExportHelper.m_isIgnorePointerClick = isIgnorePointerClick;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601AEDF RID: 110303 RVA: 0x008100F8 File Offset: 0x0080E2F8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_pointerDownStageActor(IntPtr l)
	{
		int result;
		try
		{
			ArenaDefendUIController arenaDefendUIController = (ArenaDefendUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, arenaDefendUIController.m_luaExportHelper.m_pointerDownStageActor);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601AEE0 RID: 110304 RVA: 0x00810150 File Offset: 0x0080E350
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_pointerDownStageActor(IntPtr l)
	{
		int result;
		try
		{
			ArenaDefendUIController arenaDefendUIController = (ArenaDefendUIController)LuaObject.checkSelf(l);
			ArenaDefendActor pointerDownStageActor;
			LuaObject.checkType<ArenaDefendActor>(l, 2, out pointerDownStageActor);
			arenaDefendUIController.m_luaExportHelper.m_pointerDownStageActor = pointerDownStageActor;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601AEE1 RID: 110305 RVA: 0x008101AC File Offset: 0x0080E3AC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_stageActorCountMax(IntPtr l)
	{
		int result;
		try
		{
			ArenaDefendUIController arenaDefendUIController = (ArenaDefendUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, arenaDefendUIController.m_luaExportHelper.m_stageActorCountMax);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601AEE2 RID: 110306 RVA: 0x00810204 File Offset: 0x0080E404
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_stageActorCountMax(IntPtr l)
	{
		int result;
		try
		{
			ArenaDefendUIController arenaDefendUIController = (ArenaDefendUIController)LuaObject.checkSelf(l);
			int stageActorCountMax;
			LuaObject.checkType(l, 2, out stageActorCountMax);
			arenaDefendUIController.m_luaExportHelper.m_stageActorCountMax = stageActorCountMax;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601AEE3 RID: 110307 RVA: 0x00810260 File Offset: 0x0080E460
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_isStageActorChanged(IntPtr l)
	{
		int result;
		try
		{
			ArenaDefendUIController arenaDefendUIController = (ArenaDefendUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, arenaDefendUIController.m_luaExportHelper.m_isStageActorChanged);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601AEE4 RID: 110308 RVA: 0x008102B8 File Offset: 0x0080E4B8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_isStageActorChanged(IntPtr l)
	{
		int result;
		try
		{
			ArenaDefendUIController arenaDefendUIController = (ArenaDefendUIController)LuaObject.checkSelf(l);
			bool isStageActorChanged;
			LuaObject.checkType(l, 2, out isStageActorChanged);
			arenaDefendUIController.m_luaExportHelper.m_isStageActorChanged = isStageActorChanged;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601AEE5 RID: 110309 RVA: 0x00810314 File Offset: 0x0080E514
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_heroButtons(IntPtr l)
	{
		int result;
		try
		{
			ArenaDefendUIController arenaDefendUIController = (ArenaDefendUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, arenaDefendUIController.m_luaExportHelper.m_heroButtons);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601AEE6 RID: 110310 RVA: 0x0081036C File Offset: 0x0080E56C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_heroButtons(IntPtr l)
	{
		int result;
		try
		{
			ArenaDefendUIController arenaDefendUIController = (ArenaDefendUIController)LuaObject.checkSelf(l);
			List<HeroDragButton> heroButtons;
			LuaObject.checkType<List<HeroDragButton>>(l, 2, out heroButtons);
			arenaDefendUIController.m_luaExportHelper.m_heroButtons = heroButtons;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601AEE7 RID: 110311 RVA: 0x008103C8 File Offset: 0x0080E5C8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_stageActors(IntPtr l)
	{
		int result;
		try
		{
			ArenaDefendUIController arenaDefendUIController = (ArenaDefendUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, arenaDefendUIController.m_luaExportHelper.m_stageActors);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601AEE8 RID: 110312 RVA: 0x00810420 File Offset: 0x0080E620
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_stageActors(IntPtr l)
	{
		int result;
		try
		{
			ArenaDefendUIController arenaDefendUIController = (ArenaDefendUIController)LuaObject.checkSelf(l);
			List<ArenaDefendActor> stageActors;
			LuaObject.checkType<List<ArenaDefendActor>>(l, 2, out stageActors);
			arenaDefendUIController.m_luaExportHelper.m_stageActors = stageActors;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601AEE9 RID: 110313 RVA: 0x0081047C File Offset: 0x0080E67C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_stagePositions(IntPtr l)
	{
		int result;
		try
		{
			ArenaDefendUIController arenaDefendUIController = (ArenaDefendUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, arenaDefendUIController.m_luaExportHelper.m_stagePositions);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601AEEA RID: 110314 RVA: 0x008104D4 File Offset: 0x0080E6D4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_stagePositions(IntPtr l)
	{
		int result;
		try
		{
			ArenaDefendUIController arenaDefendUIController = (ArenaDefendUIController)LuaObject.checkSelf(l);
			List<GridPosition> stagePositions;
			LuaObject.checkType<List<GridPosition>>(l, 2, out stagePositions);
			arenaDefendUIController.m_luaExportHelper.m_stagePositions = stagePositions;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601AEEB RID: 110315 RVA: 0x00810530 File Offset: 0x0080E730
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_stageDirs(IntPtr l)
	{
		int result;
		try
		{
			ArenaDefendUIController arenaDefendUIController = (ArenaDefendUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, arenaDefendUIController.m_luaExportHelper.m_stageDirs);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601AEEC RID: 110316 RVA: 0x00810588 File Offset: 0x0080E788
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_stageDirs(IntPtr l)
	{
		int result;
		try
		{
			ArenaDefendUIController arenaDefendUIController = (ArenaDefendUIController)LuaObject.checkSelf(l);
			List<int> stageDirs;
			LuaObject.checkType<List<int>>(l, 2, out stageDirs);
			arenaDefendUIController.m_luaExportHelper.m_stageDirs = stageDirs;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601AEED RID: 110317 RVA: 0x008105E4 File Offset: 0x0080E7E4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_actionOrderButtons(IntPtr l)
	{
		int result;
		try
		{
			ArenaDefendUIController arenaDefendUIController = (ArenaDefendUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, arenaDefendUIController.m_luaExportHelper.m_actionOrderButtons);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601AEEE RID: 110318 RVA: 0x0081063C File Offset: 0x0080E83C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_actionOrderButtons(IntPtr l)
	{
		int result;
		try
		{
			ArenaDefendUIController arenaDefendUIController = (ArenaDefendUIController)LuaObject.checkSelf(l);
			ArenaActionOrderButton[] actionOrderButtons;
			LuaObject.checkArray<ArenaActionOrderButton>(l, 2, out actionOrderButtons);
			arenaDefendUIController.m_luaExportHelper.m_actionOrderButtons = actionOrderButtons;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601AEEF RID: 110319 RVA: 0x00810698 File Offset: 0x0080E898
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_defendMapToggles(IntPtr l)
	{
		int result;
		try
		{
			ArenaDefendUIController arenaDefendUIController = (ArenaDefendUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, arenaDefendUIController.m_luaExportHelper.m_defendMapToggles);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601AEF0 RID: 110320 RVA: 0x008106F0 File Offset: 0x0080E8F0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_defendMapToggles(IntPtr l)
	{
		int result;
		try
		{
			ArenaDefendUIController arenaDefendUIController = (ArenaDefendUIController)LuaObject.checkSelf(l);
			ArenaDefendMapToggle[] defendMapToggles;
			LuaObject.checkArray<ArenaDefendMapToggle>(l, 2, out defendMapToggles);
			arenaDefendUIController.m_luaExportHelper.m_defendMapToggles = defendMapToggles;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601AEF1 RID: 110321 RVA: 0x0081074C File Offset: 0x0080E94C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_defendRuleToggles(IntPtr l)
	{
		int result;
		try
		{
			ArenaDefendUIController arenaDefendUIController = (ArenaDefendUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, arenaDefendUIController.m_luaExportHelper.m_defendRuleToggles);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601AEF2 RID: 110322 RVA: 0x008107A4 File Offset: 0x0080E9A4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_defendRuleToggles(IntPtr l)
	{
		int result;
		try
		{
			ArenaDefendUIController arenaDefendUIController = (ArenaDefendUIController)LuaObject.checkSelf(l);
			ArenaDefendRuleToggle[] defendRuleToggles;
			LuaObject.checkArray<ArenaDefendRuleToggle>(l, 2, out defendRuleToggles);
			arenaDefendUIController.m_luaExportHelper.m_defendRuleToggles = defendRuleToggles;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601AEF3 RID: 110323 RVA: 0x00810800 File Offset: 0x0080EA00
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_draggingHeroButton(IntPtr l)
	{
		int result;
		try
		{
			ArenaDefendUIController arenaDefendUIController = (ArenaDefendUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, arenaDefendUIController.m_luaExportHelper.m_draggingHeroButton);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601AEF4 RID: 110324 RVA: 0x00810858 File Offset: 0x0080EA58
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_draggingHeroButton(IntPtr l)
	{
		int result;
		try
		{
			ArenaDefendUIController arenaDefendUIController = (ArenaDefendUIController)LuaObject.checkSelf(l);
			HeroDragButton draggingHeroButton;
			LuaObject.checkType<HeroDragButton>(l, 2, out draggingHeroButton);
			arenaDefendUIController.m_luaExportHelper.m_draggingHeroButton = draggingHeroButton;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601AEF5 RID: 110325 RVA: 0x008108B4 File Offset: 0x0080EAB4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_draggingActionOrderButton(IntPtr l)
	{
		int result;
		try
		{
			ArenaDefendUIController arenaDefendUIController = (ArenaDefendUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, arenaDefendUIController.m_luaExportHelper.m_draggingActionOrderButton);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601AEF6 RID: 110326 RVA: 0x0081090C File Offset: 0x0080EB0C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_draggingActionOrderButton(IntPtr l)
	{
		int result;
		try
		{
			ArenaDefendUIController arenaDefendUIController = (ArenaDefendUIController)LuaObject.checkSelf(l);
			ArenaActionOrderButton draggingActionOrderButton;
			LuaObject.checkType<ArenaActionOrderButton>(l, 2, out draggingActionOrderButton);
			arenaDefendUIController.m_luaExportHelper.m_draggingActionOrderButton = draggingActionOrderButton;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601AEF7 RID: 110327 RVA: 0x00810968 File Offset: 0x0080EB68
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_draggingActionOrderButtonIndex(IntPtr l)
	{
		int result;
		try
		{
			ArenaDefendUIController arenaDefendUIController = (ArenaDefendUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, arenaDefendUIController.m_luaExportHelper.m_draggingActionOrderButtonIndex);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601AEF8 RID: 110328 RVA: 0x008109C0 File Offset: 0x0080EBC0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_draggingActionOrderButtonIndex(IntPtr l)
	{
		int result;
		try
		{
			ArenaDefendUIController arenaDefendUIController = (ArenaDefendUIController)LuaObject.checkSelf(l);
			int draggingActionOrderButtonIndex;
			LuaObject.checkType(l, 2, out draggingActionOrderButtonIndex);
			arenaDefendUIController.m_luaExportHelper.m_draggingActionOrderButtonIndex = draggingActionOrderButtonIndex;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601AEF9 RID: 110329 RVA: 0x00810A1C File Offset: 0x0080EC1C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_arenaDefendBattle(IntPtr l)
	{
		int result;
		try
		{
			ArenaDefendUIController arenaDefendUIController = (ArenaDefendUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, arenaDefendUIController.m_luaExportHelper.m_arenaDefendBattle);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601AEFA RID: 110330 RVA: 0x00810A74 File Offset: 0x0080EC74
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_arenaDefendBattle(IntPtr l)
	{
		int result;
		try
		{
			ArenaDefendUIController arenaDefendUIController = (ArenaDefendUIController)LuaObject.checkSelf(l);
			ArenaDefendBattle arenaDefendBattle;
			LuaObject.checkType<ArenaDefendBattle>(l, 2, out arenaDefendBattle);
			arenaDefendUIController.m_luaExportHelper.m_arenaDefendBattle = arenaDefendBattle;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601AEFB RID: 110331 RVA: 0x00810AD0 File Offset: 0x0080ECD0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_battlePowerValue(IntPtr l)
	{
		int result;
		try
		{
			ArenaDefendUIController arenaDefendUIController = (ArenaDefendUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, arenaDefendUIController.m_luaExportHelper.m_battlePowerValue);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601AEFC RID: 110332 RVA: 0x00810B28 File Offset: 0x0080ED28
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_battlePowerValue(IntPtr l)
	{
		int result;
		try
		{
			ArenaDefendUIController arenaDefendUIController = (ArenaDefendUIController)LuaObject.checkSelf(l);
			int battlePowerValue;
			LuaObject.checkType(l, 2, out battlePowerValue);
			arenaDefendUIController.m_luaExportHelper.m_battlePowerValue = battlePowerValue;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601AEFD RID: 110333 RVA: 0x00810B84 File Offset: 0x0080ED84
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_setBattlePowerValueCoroutine(IntPtr l)
	{
		int result;
		try
		{
			ArenaDefendUIController arenaDefendUIController = (ArenaDefendUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, arenaDefendUIController.m_luaExportHelper.m_setBattlePowerValueCoroutine);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601AEFE RID: 110334 RVA: 0x00810BDC File Offset: 0x0080EDDC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_setBattlePowerValueCoroutine(IntPtr l)
	{
		int result;
		try
		{
			ArenaDefendUIController arenaDefendUIController = (ArenaDefendUIController)LuaObject.checkSelf(l);
			Coroutine setBattlePowerValueCoroutine;
			LuaObject.checkType<Coroutine>(l, 2, out setBattlePowerValueCoroutine);
			arenaDefendUIController.m_luaExportHelper.m_setBattlePowerValueCoroutine = setBattlePowerValueCoroutine;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601AEFF RID: 110335 RVA: 0x00810C38 File Offset: 0x0080EE38
	[Preserve]
	public static void reg(IntPtr l)
	{
		LuaObject.getTypeTable(l, "BlackJack.ProjectL.UI.ArenaDefendUIController");
		if (Lua_BlackJack_ProjectL_UI_ArenaDefendUIController.<>f__mg$cache0 == null)
		{
			Lua_BlackJack_ProjectL_UI_ArenaDefendUIController.<>f__mg$cache0 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ArenaDefendUIController.Initialize);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_ArenaDefendUIController.<>f__mg$cache0);
		if (Lua_BlackJack_ProjectL_UI_ArenaDefendUIController.<>f__mg$cache1 == null)
		{
			Lua_BlackJack_ProjectL_UI_ArenaDefendUIController.<>f__mg$cache1 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ArenaDefendUIController.SetHeroActionOrders);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_ArenaDefendUIController.<>f__mg$cache1);
		if (Lua_BlackJack_ProjectL_UI_ArenaDefendUIController.<>f__mg$cache2 == null)
		{
			Lua_BlackJack_ProjectL_UI_ArenaDefendUIController.<>f__mg$cache2 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ArenaDefendUIController.GetHeroActionOrderIndex);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_ArenaDefendUIController.<>f__mg$cache2);
		if (Lua_BlackJack_ProjectL_UI_ArenaDefendUIController.<>f__mg$cache3 == null)
		{
			Lua_BlackJack_ProjectL_UI_ArenaDefendUIController.<>f__mg$cache3 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ArenaDefendUIController.SetMaps);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_ArenaDefendUIController.<>f__mg$cache3);
		if (Lua_BlackJack_ProjectL_UI_ArenaDefendUIController.<>f__mg$cache4 == null)
		{
			Lua_BlackJack_ProjectL_UI_ArenaDefendUIController.<>f__mg$cache4 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ArenaDefendUIController.SetDefendRules);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_ArenaDefendUIController.<>f__mg$cache4);
		if (Lua_BlackJack_ProjectL_UI_ArenaDefendUIController.<>f__mg$cache5 == null)
		{
			Lua_BlackJack_ProjectL_UI_ArenaDefendUIController.<>f__mg$cache5 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ArenaDefendUIController.SetBattlePower);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_ArenaDefendUIController.<>f__mg$cache5);
		if (Lua_BlackJack_ProjectL_UI_ArenaDefendUIController.<>f__mg$cache6 == null)
		{
			Lua_BlackJack_ProjectL_UI_ArenaDefendUIController.<>f__mg$cache6 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ArenaDefendUIController.CheckStageAtorChange);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_ArenaDefendUIController.<>f__mg$cache6);
		if (Lua_BlackJack_ProjectL_UI_ArenaDefendUIController.<>f__mg$cache7 == null)
		{
			Lua_BlackJack_ProjectL_UI_ArenaDefendUIController.<>f__mg$cache7 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ArenaDefendUIController.SetStageActorCountMax);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_ArenaDefendUIController.<>f__mg$cache7);
		if (Lua_BlackJack_ProjectL_UI_ArenaDefendUIController.<>f__mg$cache8 == null)
		{
			Lua_BlackJack_ProjectL_UI_ArenaDefendUIController.<>f__mg$cache8 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ArenaDefendUIController.ClearHeros);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_ArenaDefendUIController.<>f__mg$cache8);
		if (Lua_BlackJack_ProjectL_UI_ArenaDefendUIController.<>f__mg$cache9 == null)
		{
			Lua_BlackJack_ProjectL_UI_ArenaDefendUIController.<>f__mg$cache9 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ArenaDefendUIController.AddHero);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_ArenaDefendUIController.<>f__mg$cache9);
		if (Lua_BlackJack_ProjectL_UI_ArenaDefendUIController.<>f__mg$cacheA == null)
		{
			Lua_BlackJack_ProjectL_UI_ArenaDefendUIController.<>f__mg$cacheA = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ArenaDefendUIController.ClearStagePositions);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_ArenaDefendUIController.<>f__mg$cacheA);
		if (Lua_BlackJack_ProjectL_UI_ArenaDefendUIController.<>f__mg$cacheB == null)
		{
			Lua_BlackJack_ProjectL_UI_ArenaDefendUIController.<>f__mg$cacheB = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ArenaDefendUIController.AddStagePosition);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_ArenaDefendUIController.<>f__mg$cacheB);
		if (Lua_BlackJack_ProjectL_UI_ArenaDefendUIController.<>f__mg$cacheC == null)
		{
			Lua_BlackJack_ProjectL_UI_ArenaDefendUIController.<>f__mg$cacheC = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ArenaDefendUIController.GetStagePositions);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_ArenaDefendUIController.<>f__mg$cacheC);
		if (Lua_BlackJack_ProjectL_UI_ArenaDefendUIController.<>f__mg$cacheD == null)
		{
			Lua_BlackJack_ProjectL_UI_ArenaDefendUIController.<>f__mg$cacheD = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ArenaDefendUIController.HeroOnStage);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_ArenaDefendUIController.<>f__mg$cacheD);
		if (Lua_BlackJack_ProjectL_UI_ArenaDefendUIController.<>f__mg$cacheE == null)
		{
			Lua_BlackJack_ProjectL_UI_ArenaDefendUIController.<>f__mg$cacheE = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ArenaDefendUIController.ActorOffStage);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_ArenaDefendUIController.<>f__mg$cacheE);
		if (Lua_BlackJack_ProjectL_UI_ArenaDefendUIController.<>f__mg$cacheF == null)
		{
			Lua_BlackJack_ProjectL_UI_ArenaDefendUIController.<>f__mg$cacheF = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ArenaDefendUIController.ActorOnStageMove);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_ArenaDefendUIController.<>f__mg$cacheF);
		if (Lua_BlackJack_ProjectL_UI_ArenaDefendUIController.<>f__mg$cache10 == null)
		{
			Lua_BlackJack_ProjectL_UI_ArenaDefendUIController.<>f__mg$cache10 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ArenaDefendUIController.ActorOnStageExchange);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_ArenaDefendUIController.<>f__mg$cache10);
		if (Lua_BlackJack_ProjectL_UI_ArenaDefendUIController.<>f__mg$cache11 == null)
		{
			Lua_BlackJack_ProjectL_UI_ArenaDefendUIController.<>f__mg$cache11 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ArenaDefendUIController.ClearStageActors);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_ArenaDefendUIController.<>f__mg$cache11);
		if (Lua_BlackJack_ProjectL_UI_ArenaDefendUIController.<>f__mg$cache12 == null)
		{
			Lua_BlackJack_ProjectL_UI_ArenaDefendUIController.<>f__mg$cache12 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ArenaDefendUIController.GetStageActor);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_ArenaDefendUIController.<>f__mg$cache12);
		if (Lua_BlackJack_ProjectL_UI_ArenaDefendUIController.<>f__mg$cache13 == null)
		{
			Lua_BlackJack_ProjectL_UI_ArenaDefendUIController.<>f__mg$cache13 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ArenaDefendUIController.GetStageActors);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_ArenaDefendUIController.<>f__mg$cache13);
		if (Lua_BlackJack_ProjectL_UI_ArenaDefendUIController.<>f__mg$cache14 == null)
		{
			Lua_BlackJack_ProjectL_UI_ArenaDefendUIController.<>f__mg$cache14 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ArenaDefendUIController.UpdateStageActor);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_ArenaDefendUIController.<>f__mg$cache14);
		if (Lua_BlackJack_ProjectL_UI_ArenaDefendUIController.<>f__mg$cache15 == null)
		{
			Lua_BlackJack_ProjectL_UI_ArenaDefendUIController.<>f__mg$cache15 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ArenaDefendUIController.HeroDragButton_OnBeginDrag);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_ArenaDefendUIController.<>f__mg$cache15);
		if (Lua_BlackJack_ProjectL_UI_ArenaDefendUIController.<>f__mg$cache16 == null)
		{
			Lua_BlackJack_ProjectL_UI_ArenaDefendUIController.<>f__mg$cache16 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ArenaDefendUIController.HeroDragButton_OnEndDrag);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_ArenaDefendUIController.<>f__mg$cache16);
		if (Lua_BlackJack_ProjectL_UI_ArenaDefendUIController.<>f__mg$cache17 == null)
		{
			Lua_BlackJack_ProjectL_UI_ArenaDefendUIController.<>f__mg$cache17 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ArenaDefendUIController.HeroDragButton_OnDrag);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_ArenaDefendUIController.<>f__mg$cache17);
		if (Lua_BlackJack_ProjectL_UI_ArenaDefendUIController.<>f__mg$cache18 == null)
		{
			Lua_BlackJack_ProjectL_UI_ArenaDefendUIController.<>f__mg$cache18 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ArenaDefendUIController.HeroDragButton_OnDrop);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_ArenaDefendUIController.<>f__mg$cache18);
		if (Lua_BlackJack_ProjectL_UI_ArenaDefendUIController.<>f__mg$cache19 == null)
		{
			Lua_BlackJack_ProjectL_UI_ArenaDefendUIController.<>f__mg$cache19 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ArenaDefendUIController.HeroDragButton_OnClick);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_ArenaDefendUIController.<>f__mg$cache19);
		if (Lua_BlackJack_ProjectL_UI_ArenaDefendUIController.<>f__mg$cache1A == null)
		{
			Lua_BlackJack_ProjectL_UI_ArenaDefendUIController.<>f__mg$cache1A = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ArenaDefendUIController.OnScenePointerDown);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_ArenaDefendUIController.<>f__mg$cache1A);
		if (Lua_BlackJack_ProjectL_UI_ArenaDefendUIController.<>f__mg$cache1B == null)
		{
			Lua_BlackJack_ProjectL_UI_ArenaDefendUIController.<>f__mg$cache1B = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ArenaDefendUIController.OnScenePointerUp);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_ArenaDefendUIController.<>f__mg$cache1B);
		if (Lua_BlackJack_ProjectL_UI_ArenaDefendUIController.<>f__mg$cache1C == null)
		{
			Lua_BlackJack_ProjectL_UI_ArenaDefendUIController.<>f__mg$cache1C = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ArenaDefendUIController.OnScenePointerClick);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_ArenaDefendUIController.<>f__mg$cache1C);
		if (Lua_BlackJack_ProjectL_UI_ArenaDefendUIController.<>f__mg$cache1D == null)
		{
			Lua_BlackJack_ProjectL_UI_ArenaDefendUIController.<>f__mg$cache1D = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ArenaDefendUIController.OnSceneBeginDrag);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_ArenaDefendUIController.<>f__mg$cache1D);
		if (Lua_BlackJack_ProjectL_UI_ArenaDefendUIController.<>f__mg$cache1E == null)
		{
			Lua_BlackJack_ProjectL_UI_ArenaDefendUIController.<>f__mg$cache1E = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ArenaDefendUIController.OnSceneEndDrag);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_ArenaDefendUIController.<>f__mg$cache1E);
		if (Lua_BlackJack_ProjectL_UI_ArenaDefendUIController.<>f__mg$cache1F == null)
		{
			Lua_BlackJack_ProjectL_UI_ArenaDefendUIController.<>f__mg$cache1F = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ArenaDefendUIController.OnSceneDrag);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_ArenaDefendUIController.<>f__mg$cache1F);
		if (Lua_BlackJack_ProjectL_UI_ArenaDefendUIController.<>f__mg$cache20 == null)
		{
			Lua_BlackJack_ProjectL_UI_ArenaDefendUIController.<>f__mg$cache20 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ArenaDefendUIController.DropHeroButton);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_ArenaDefendUIController.<>f__mg$cache20);
		if (Lua_BlackJack_ProjectL_UI_ArenaDefendUIController.<>f__mg$cache21 == null)
		{
			Lua_BlackJack_ProjectL_UI_ArenaDefendUIController.<>f__mg$cache21 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ArenaDefendUIController.ShowActionOrderPanel);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_ArenaDefendUIController.<>f__mg$cache21);
		if (Lua_BlackJack_ProjectL_UI_ArenaDefendUIController.<>f__mg$cache22 == null)
		{
			Lua_BlackJack_ProjectL_UI_ArenaDefendUIController.<>f__mg$cache22 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ArenaDefendUIController.ShowMapPanel);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_ArenaDefendUIController.<>f__mg$cache22);
		if (Lua_BlackJack_ProjectL_UI_ArenaDefendUIController.<>f__mg$cache23 == null)
		{
			Lua_BlackJack_ProjectL_UI_ArenaDefendUIController.<>f__mg$cache23 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ArenaDefendUIController.ShowDefendRulePanel);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_ArenaDefendUIController.<>f__mg$cache23);
		if (Lua_BlackJack_ProjectL_UI_ArenaDefendUIController.<>f__mg$cache24 == null)
		{
			Lua_BlackJack_ProjectL_UI_ArenaDefendUIController.<>f__mg$cache24 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ArenaDefendUIController.OnBindFiledsCompleted);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_ArenaDefendUIController.<>f__mg$cache24);
		if (Lua_BlackJack_ProjectL_UI_ArenaDefendUIController.<>f__mg$cache25 == null)
		{
			Lua_BlackJack_ProjectL_UI_ArenaDefendUIController.<>f__mg$cache25 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ArenaDefendUIController.OnDisable);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_ArenaDefendUIController.<>f__mg$cache25);
		if (Lua_BlackJack_ProjectL_UI_ArenaDefendUIController.<>f__mg$cache26 == null)
		{
			Lua_BlackJack_ProjectL_UI_ArenaDefendUIController.<>f__mg$cache26 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ArenaDefendUIController.OnApplicationPause);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_ArenaDefendUIController.<>f__mg$cache26);
		if (Lua_BlackJack_ProjectL_UI_ArenaDefendUIController.<>f__mg$cache27 == null)
		{
			Lua_BlackJack_ProjectL_UI_ArenaDefendUIController.<>f__mg$cache27 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ArenaDefendUIController.OnApplicationFocus);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_ArenaDefendUIController.<>f__mg$cache27);
		if (Lua_BlackJack_ProjectL_UI_ArenaDefendUIController.<>f__mg$cache28 == null)
		{
			Lua_BlackJack_ProjectL_UI_ArenaDefendUIController.<>f__mg$cache28 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ArenaDefendUIController.CancelDragging);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_ArenaDefendUIController.<>f__mg$cache28);
		if (Lua_BlackJack_ProjectL_UI_ArenaDefendUIController.<>f__mg$cache29 == null)
		{
			Lua_BlackJack_ProjectL_UI_ArenaDefendUIController.<>f__mg$cache29 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ArenaDefendUIController.Co_SetBattlePowerValue);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_ArenaDefendUIController.<>f__mg$cache29);
		if (Lua_BlackJack_ProjectL_UI_ArenaDefendUIController.<>f__mg$cache2A == null)
		{
			Lua_BlackJack_ProjectL_UI_ArenaDefendUIController.<>f__mg$cache2A = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ArenaDefendUIController.ClearBattlePowerValue);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_ArenaDefendUIController.<>f__mg$cache2A);
		if (Lua_BlackJack_ProjectL_UI_ArenaDefendUIController.<>f__mg$cache2B == null)
		{
			Lua_BlackJack_ProjectL_UI_ArenaDefendUIController.<>f__mg$cache2B = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ArenaDefendUIController.Update);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_ArenaDefendUIController.<>f__mg$cache2B);
		if (Lua_BlackJack_ProjectL_UI_ArenaDefendUIController.<>f__mg$cache2C == null)
		{
			Lua_BlackJack_ProjectL_UI_ArenaDefendUIController.<>f__mg$cache2C = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ArenaDefendUIController.UpdateStageActorCount);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_ArenaDefendUIController.<>f__mg$cache2C);
		if (Lua_BlackJack_ProjectL_UI_ArenaDefendUIController.<>f__mg$cache2D == null)
		{
			Lua_BlackJack_ProjectL_UI_ArenaDefendUIController.<>f__mg$cache2D = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ArenaDefendUIController.GetStageDirection);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_ArenaDefendUIController.<>f__mg$cache2D);
		if (Lua_BlackJack_ProjectL_UI_ArenaDefendUIController.<>f__mg$cache2E == null)
		{
			Lua_BlackJack_ProjectL_UI_ArenaDefendUIController.<>f__mg$cache2E = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ArenaDefendUIController.CreateHeroButton);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_ArenaDefendUIController.<>f__mg$cache2E);
		if (Lua_BlackJack_ProjectL_UI_ArenaDefendUIController.<>f__mg$cache2F == null)
		{
			Lua_BlackJack_ProjectL_UI_ArenaDefendUIController.<>f__mg$cache2F = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ArenaDefendUIController.HideActorInfo);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_ArenaDefendUIController.<>f__mg$cache2F);
		if (Lua_BlackJack_ProjectL_UI_ArenaDefendUIController.<>f__mg$cache30 == null)
		{
			Lua_BlackJack_ProjectL_UI_ArenaDefendUIController.<>f__mg$cache30 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ArenaDefendUIController.ClearPointerDownStageActor);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_ArenaDefendUIController.<>f__mg$cache30);
		if (Lua_BlackJack_ProjectL_UI_ArenaDefendUIController.<>f__mg$cache31 == null)
		{
			Lua_BlackJack_ProjectL_UI_ArenaDefendUIController.<>f__mg$cache31 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ArenaDefendUIController.CreateDraggingHeroButton);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_ArenaDefendUIController.<>f__mg$cache31);
		if (Lua_BlackJack_ProjectL_UI_ArenaDefendUIController.<>f__mg$cache32 == null)
		{
			Lua_BlackJack_ProjectL_UI_ArenaDefendUIController.<>f__mg$cache32 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ArenaDefendUIController.DestroyDragginHeroButton);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_ArenaDefendUIController.<>f__mg$cache32);
		if (Lua_BlackJack_ProjectL_UI_ArenaDefendUIController.<>f__mg$cache33 == null)
		{
			Lua_BlackJack_ProjectL_UI_ArenaDefendUIController.<>f__mg$cache33 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ArenaDefendUIController.MoveDraggingHeroButton);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_ArenaDefendUIController.<>f__mg$cache33);
		if (Lua_BlackJack_ProjectL_UI_ArenaDefendUIController.<>f__mg$cache34 == null)
		{
			Lua_BlackJack_ProjectL_UI_ArenaDefendUIController.<>f__mg$cache34 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ArenaDefendUIController.CreateActionOrderButton);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_ArenaDefendUIController.<>f__mg$cache34);
		if (Lua_BlackJack_ProjectL_UI_ArenaDefendUIController.<>f__mg$cache35 == null)
		{
			Lua_BlackJack_ProjectL_UI_ArenaDefendUIController.<>f__mg$cache35 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ArenaDefendUIController.CreateDraggingActionOrderButton);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_ArenaDefendUIController.<>f__mg$cache35);
		if (Lua_BlackJack_ProjectL_UI_ArenaDefendUIController.<>f__mg$cache36 == null)
		{
			Lua_BlackJack_ProjectL_UI_ArenaDefendUIController.<>f__mg$cache36 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ArenaDefendUIController.DestroyDragginActionOrderButton);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_ArenaDefendUIController.<>f__mg$cache36);
		if (Lua_BlackJack_ProjectL_UI_ArenaDefendUIController.<>f__mg$cache37 == null)
		{
			Lua_BlackJack_ProjectL_UI_ArenaDefendUIController.<>f__mg$cache37 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ArenaDefendUIController.MoveDraggingActionOrderButton);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_ArenaDefendUIController.<>f__mg$cache37);
		if (Lua_BlackJack_ProjectL_UI_ArenaDefendUIController.<>f__mg$cache38 == null)
		{
			Lua_BlackJack_ProjectL_UI_ArenaDefendUIController.<>f__mg$cache38 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ArenaDefendUIController.DropDraggingActionOrderButton);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_ArenaDefendUIController.<>f__mg$cache38);
		if (Lua_BlackJack_ProjectL_UI_ArenaDefendUIController.<>f__mg$cache39 == null)
		{
			Lua_BlackJack_ProjectL_UI_ArenaDefendUIController.<>f__mg$cache39 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ArenaDefendUIController.OnReturnButtonClick);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_ArenaDefendUIController.<>f__mg$cache39);
		if (Lua_BlackJack_ProjectL_UI_ArenaDefendUIController.<>f__mg$cache3A == null)
		{
			Lua_BlackJack_ProjectL_UI_ArenaDefendUIController.<>f__mg$cache3A = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ArenaDefendUIController.OnSaveTeamButtonClick);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_ArenaDefendUIController.<>f__mg$cache3A);
		if (Lua_BlackJack_ProjectL_UI_ArenaDefendUIController.<>f__mg$cache3B == null)
		{
			Lua_BlackJack_ProjectL_UI_ArenaDefendUIController.<>f__mg$cache3B = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ArenaDefendUIController.OnShowActionOrderButtonClick);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_ArenaDefendUIController.<>f__mg$cache3B);
		if (Lua_BlackJack_ProjectL_UI_ArenaDefendUIController.<>f__mg$cache3C == null)
		{
			Lua_BlackJack_ProjectL_UI_ArenaDefendUIController.<>f__mg$cache3C = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ArenaDefendUIController.OnShowMapButtonClick);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_ArenaDefendUIController.<>f__mg$cache3C);
		if (Lua_BlackJack_ProjectL_UI_ArenaDefendUIController.<>f__mg$cache3D == null)
		{
			Lua_BlackJack_ProjectL_UI_ArenaDefendUIController.<>f__mg$cache3D = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ArenaDefendUIController.OnShowDefendRuleButtonClick);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_ArenaDefendUIController.<>f__mg$cache3D);
		if (Lua_BlackJack_ProjectL_UI_ArenaDefendUIController.<>f__mg$cache3E == null)
		{
			Lua_BlackJack_ProjectL_UI_ArenaDefendUIController.<>f__mg$cache3E = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ArenaDefendUIController.OnPanelBackgroundButtonClick);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_ArenaDefendUIController.<>f__mg$cache3E);
		if (Lua_BlackJack_ProjectL_UI_ArenaDefendUIController.<>f__mg$cache3F == null)
		{
			Lua_BlackJack_ProjectL_UI_ArenaDefendUIController.<>f__mg$cache3F = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ArenaDefendUIController.OnActionOrderOkButtonClick);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_ArenaDefendUIController.<>f__mg$cache3F);
		if (Lua_BlackJack_ProjectL_UI_ArenaDefendUIController.<>f__mg$cache40 == null)
		{
			Lua_BlackJack_ProjectL_UI_ArenaDefendUIController.<>f__mg$cache40 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ArenaDefendUIController.ActionOrderButton_OnClick);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_ArenaDefendUIController.<>f__mg$cache40);
		if (Lua_BlackJack_ProjectL_UI_ArenaDefendUIController.<>f__mg$cache41 == null)
		{
			Lua_BlackJack_ProjectL_UI_ArenaDefendUIController.<>f__mg$cache41 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ArenaDefendUIController.ActionOrderButton_OnBeginDrag);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_ArenaDefendUIController.<>f__mg$cache41);
		if (Lua_BlackJack_ProjectL_UI_ArenaDefendUIController.<>f__mg$cache42 == null)
		{
			Lua_BlackJack_ProjectL_UI_ArenaDefendUIController.<>f__mg$cache42 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ArenaDefendUIController.ActionOrderButton_OnEndDrag);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_ArenaDefendUIController.<>f__mg$cache42);
		if (Lua_BlackJack_ProjectL_UI_ArenaDefendUIController.<>f__mg$cache43 == null)
		{
			Lua_BlackJack_ProjectL_UI_ArenaDefendUIController.<>f__mg$cache43 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ArenaDefendUIController.ActionOrderButton_OnDrag);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_ArenaDefendUIController.<>f__mg$cache43);
		if (Lua_BlackJack_ProjectL_UI_ArenaDefendUIController.<>f__mg$cache44 == null)
		{
			Lua_BlackJack_ProjectL_UI_ArenaDefendUIController.<>f__mg$cache44 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ArenaDefendUIController.ActionOrderButton_OnDrop);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_ArenaDefendUIController.<>f__mg$cache44);
		if (Lua_BlackJack_ProjectL_UI_ArenaDefendUIController.<>f__mg$cache45 == null)
		{
			Lua_BlackJack_ProjectL_UI_ArenaDefendUIController.<>f__mg$cache45 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ArenaDefendUIController.OnMapOkButtonClick);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_ArenaDefendUIController.<>f__mg$cache45);
		if (Lua_BlackJack_ProjectL_UI_ArenaDefendUIController.<>f__mg$cache46 == null)
		{
			Lua_BlackJack_ProjectL_UI_ArenaDefendUIController.<>f__mg$cache46 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ArenaDefendUIController.OnDefendRuleOkButtonClick);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_ArenaDefendUIController.<>f__mg$cache46);
		if (Lua_BlackJack_ProjectL_UI_ArenaDefendUIController.<>f__mg$cache47 == null)
		{
			Lua_BlackJack_ProjectL_UI_ArenaDefendUIController.<>f__mg$cache47 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ArenaDefendUIController.__callBase_Initlize);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_ArenaDefendUIController.<>f__mg$cache47);
		if (Lua_BlackJack_ProjectL_UI_ArenaDefendUIController.<>f__mg$cache48 == null)
		{
			Lua_BlackJack_ProjectL_UI_ArenaDefendUIController.<>f__mg$cache48 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ArenaDefendUIController.__callBase_BindFields);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_ArenaDefendUIController.<>f__mg$cache48);
		if (Lua_BlackJack_ProjectL_UI_ArenaDefendUIController.<>f__mg$cache49 == null)
		{
			Lua_BlackJack_ProjectL_UI_ArenaDefendUIController.<>f__mg$cache49 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ArenaDefendUIController.__callBase_OnBindFiledsCompleted);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_ArenaDefendUIController.<>f__mg$cache49);
		if (Lua_BlackJack_ProjectL_UI_ArenaDefendUIController.<>f__mg$cache4A == null)
		{
			Lua_BlackJack_ProjectL_UI_ArenaDefendUIController.<>f__mg$cache4A = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ArenaDefendUIController.__callBase_BindFieldImpl);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_ArenaDefendUIController.<>f__mg$cache4A);
		if (Lua_BlackJack_ProjectL_UI_ArenaDefendUIController.<>f__mg$cache4B == null)
		{
			Lua_BlackJack_ProjectL_UI_ArenaDefendUIController.<>f__mg$cache4B = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ArenaDefendUIController.__callBase_Clear);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_ArenaDefendUIController.<>f__mg$cache4B);
		if (Lua_BlackJack_ProjectL_UI_ArenaDefendUIController.<>f__mg$cache4C == null)
		{
			Lua_BlackJack_ProjectL_UI_ArenaDefendUIController.<>f__mg$cache4C = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ArenaDefendUIController.__callBase_OnButtonClick);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_ArenaDefendUIController.<>f__mg$cache4C);
		if (Lua_BlackJack_ProjectL_UI_ArenaDefendUIController.<>f__mg$cache4D == null)
		{
			Lua_BlackJack_ProjectL_UI_ArenaDefendUIController.<>f__mg$cache4D = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ArenaDefendUIController.__callBase_SetButtonClickListener);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_ArenaDefendUIController.<>f__mg$cache4D);
		if (Lua_BlackJack_ProjectL_UI_ArenaDefendUIController.<>f__mg$cache4E == null)
		{
			Lua_BlackJack_ProjectL_UI_ArenaDefendUIController.<>f__mg$cache4E = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ArenaDefendUIController.__callBase_SetButtonDoubleClickListener);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_ArenaDefendUIController.<>f__mg$cache4E);
		if (Lua_BlackJack_ProjectL_UI_ArenaDefendUIController.<>f__mg$cache4F == null)
		{
			Lua_BlackJack_ProjectL_UI_ArenaDefendUIController.<>f__mg$cache4F = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ArenaDefendUIController.__callBase_SetButtonLongPressStartListener);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_ArenaDefendUIController.<>f__mg$cache4F);
		if (Lua_BlackJack_ProjectL_UI_ArenaDefendUIController.<>f__mg$cache50 == null)
		{
			Lua_BlackJack_ProjectL_UI_ArenaDefendUIController.<>f__mg$cache50 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ArenaDefendUIController.__callBase_SetButtonLongPressingListener);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_ArenaDefendUIController.<>f__mg$cache50);
		if (Lua_BlackJack_ProjectL_UI_ArenaDefendUIController.<>f__mg$cache51 == null)
		{
			Lua_BlackJack_ProjectL_UI_ArenaDefendUIController.<>f__mg$cache51 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ArenaDefendUIController.__callBase_SetButtonLongPressEndListener);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_ArenaDefendUIController.<>f__mg$cache51);
		if (Lua_BlackJack_ProjectL_UI_ArenaDefendUIController.<>f__mg$cache52 == null)
		{
			Lua_BlackJack_ProjectL_UI_ArenaDefendUIController.<>f__mg$cache52 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ArenaDefendUIController.__callBase_SetToggleValueChangedListener);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_ArenaDefendUIController.<>f__mg$cache52);
		if (Lua_BlackJack_ProjectL_UI_ArenaDefendUIController.<>f__mg$cache53 == null)
		{
			Lua_BlackJack_ProjectL_UI_ArenaDefendUIController.<>f__mg$cache53 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ArenaDefendUIController.__callBase_ToString);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_ArenaDefendUIController.<>f__mg$cache53);
		if (Lua_BlackJack_ProjectL_UI_ArenaDefendUIController.<>f__mg$cache54 == null)
		{
			Lua_BlackJack_ProjectL_UI_ArenaDefendUIController.<>f__mg$cache54 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ArenaDefendUIController.__callDele_EventOnReturn);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_ArenaDefendUIController.<>f__mg$cache54);
		if (Lua_BlackJack_ProjectL_UI_ArenaDefendUIController.<>f__mg$cache55 == null)
		{
			Lua_BlackJack_ProjectL_UI_ArenaDefendUIController.<>f__mg$cache55 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ArenaDefendUIController.__clearDele_EventOnReturn);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_ArenaDefendUIController.<>f__mg$cache55);
		if (Lua_BlackJack_ProjectL_UI_ArenaDefendUIController.<>f__mg$cache56 == null)
		{
			Lua_BlackJack_ProjectL_UI_ArenaDefendUIController.<>f__mg$cache56 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ArenaDefendUIController.__callDele_EventOnSave);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_ArenaDefendUIController.<>f__mg$cache56);
		if (Lua_BlackJack_ProjectL_UI_ArenaDefendUIController.<>f__mg$cache57 == null)
		{
			Lua_BlackJack_ProjectL_UI_ArenaDefendUIController.<>f__mg$cache57 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ArenaDefendUIController.__clearDele_EventOnSave);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_ArenaDefendUIController.<>f__mg$cache57);
		if (Lua_BlackJack_ProjectL_UI_ArenaDefendUIController.<>f__mg$cache58 == null)
		{
			Lua_BlackJack_ProjectL_UI_ArenaDefendUIController.<>f__mg$cache58 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ArenaDefendUIController.__callDele_EventOnShowActionOrderPanel);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_ArenaDefendUIController.<>f__mg$cache58);
		if (Lua_BlackJack_ProjectL_UI_ArenaDefendUIController.<>f__mg$cache59 == null)
		{
			Lua_BlackJack_ProjectL_UI_ArenaDefendUIController.<>f__mg$cache59 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ArenaDefendUIController.__clearDele_EventOnShowActionOrderPanel);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_ArenaDefendUIController.<>f__mg$cache59);
		if (Lua_BlackJack_ProjectL_UI_ArenaDefendUIController.<>f__mg$cache5A == null)
		{
			Lua_BlackJack_ProjectL_UI_ArenaDefendUIController.<>f__mg$cache5A = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ArenaDefendUIController.__callDele_EventOnShowMapPanel);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_ArenaDefendUIController.<>f__mg$cache5A);
		if (Lua_BlackJack_ProjectL_UI_ArenaDefendUIController.<>f__mg$cache5B == null)
		{
			Lua_BlackJack_ProjectL_UI_ArenaDefendUIController.<>f__mg$cache5B = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ArenaDefendUIController.__clearDele_EventOnShowMapPanel);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_ArenaDefendUIController.<>f__mg$cache5B);
		if (Lua_BlackJack_ProjectL_UI_ArenaDefendUIController.<>f__mg$cache5C == null)
		{
			Lua_BlackJack_ProjectL_UI_ArenaDefendUIController.<>f__mg$cache5C = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ArenaDefendUIController.__callDele_EventOnShowDefendRulePanel);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_ArenaDefendUIController.<>f__mg$cache5C);
		if (Lua_BlackJack_ProjectL_UI_ArenaDefendUIController.<>f__mg$cache5D == null)
		{
			Lua_BlackJack_ProjectL_UI_ArenaDefendUIController.<>f__mg$cache5D = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ArenaDefendUIController.__clearDele_EventOnShowDefendRulePanel);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_ArenaDefendUIController.<>f__mg$cache5D);
		if (Lua_BlackJack_ProjectL_UI_ArenaDefendUIController.<>f__mg$cache5E == null)
		{
			Lua_BlackJack_ProjectL_UI_ArenaDefendUIController.<>f__mg$cache5E = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ArenaDefendUIController.__callDele_EventOnConfirmActionOrder);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_ArenaDefendUIController.<>f__mg$cache5E);
		if (Lua_BlackJack_ProjectL_UI_ArenaDefendUIController.<>f__mg$cache5F == null)
		{
			Lua_BlackJack_ProjectL_UI_ArenaDefendUIController.<>f__mg$cache5F = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ArenaDefendUIController.__clearDele_EventOnConfirmActionOrder);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_ArenaDefendUIController.<>f__mg$cache5F);
		if (Lua_BlackJack_ProjectL_UI_ArenaDefendUIController.<>f__mg$cache60 == null)
		{
			Lua_BlackJack_ProjectL_UI_ArenaDefendUIController.<>f__mg$cache60 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ArenaDefendUIController.__callDele_EventOnConfirmMap);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_ArenaDefendUIController.<>f__mg$cache60);
		if (Lua_BlackJack_ProjectL_UI_ArenaDefendUIController.<>f__mg$cache61 == null)
		{
			Lua_BlackJack_ProjectL_UI_ArenaDefendUIController.<>f__mg$cache61 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ArenaDefendUIController.__clearDele_EventOnConfirmMap);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_ArenaDefendUIController.<>f__mg$cache61);
		if (Lua_BlackJack_ProjectL_UI_ArenaDefendUIController.<>f__mg$cache62 == null)
		{
			Lua_BlackJack_ProjectL_UI_ArenaDefendUIController.<>f__mg$cache62 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ArenaDefendUIController.__callDele_EventOnConfirmDefendRule);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_ArenaDefendUIController.<>f__mg$cache62);
		if (Lua_BlackJack_ProjectL_UI_ArenaDefendUIController.<>f__mg$cache63 == null)
		{
			Lua_BlackJack_ProjectL_UI_ArenaDefendUIController.<>f__mg$cache63 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ArenaDefendUIController.__clearDele_EventOnConfirmDefendRule);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_ArenaDefendUIController.<>f__mg$cache63);
		if (Lua_BlackJack_ProjectL_UI_ArenaDefendUIController.<>f__mg$cache64 == null)
		{
			Lua_BlackJack_ProjectL_UI_ArenaDefendUIController.<>f__mg$cache64 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ArenaDefendUIController.__callDele_EventOnShowMyActorInfo);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_ArenaDefendUIController.<>f__mg$cache64);
		if (Lua_BlackJack_ProjectL_UI_ArenaDefendUIController.<>f__mg$cache65 == null)
		{
			Lua_BlackJack_ProjectL_UI_ArenaDefendUIController.<>f__mg$cache65 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ArenaDefendUIController.__clearDele_EventOnShowMyActorInfo);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_ArenaDefendUIController.<>f__mg$cache65);
		if (Lua_BlackJack_ProjectL_UI_ArenaDefendUIController.<>f__mg$cache66 == null)
		{
			Lua_BlackJack_ProjectL_UI_ArenaDefendUIController.<>f__mg$cache66 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ArenaDefendUIController.__callDele_EventOnHideActorInfo);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_ArenaDefendUIController.<>f__mg$cache66);
		if (Lua_BlackJack_ProjectL_UI_ArenaDefendUIController.<>f__mg$cache67 == null)
		{
			Lua_BlackJack_ProjectL_UI_ArenaDefendUIController.<>f__mg$cache67 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ArenaDefendUIController.__clearDele_EventOnHideActorInfo);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_ArenaDefendUIController.<>f__mg$cache67);
		if (Lua_BlackJack_ProjectL_UI_ArenaDefendUIController.<>f__mg$cache68 == null)
		{
			Lua_BlackJack_ProjectL_UI_ArenaDefendUIController.<>f__mg$cache68 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ArenaDefendUIController.__callDele_EventOnStageActorChange);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_ArenaDefendUIController.<>f__mg$cache68);
		if (Lua_BlackJack_ProjectL_UI_ArenaDefendUIController.<>f__mg$cache69 == null)
		{
			Lua_BlackJack_ProjectL_UI_ArenaDefendUIController.<>f__mg$cache69 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ArenaDefendUIController.__clearDele_EventOnStageActorChange);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_ArenaDefendUIController.<>f__mg$cache69);
		if (Lua_BlackJack_ProjectL_UI_ArenaDefendUIController.<>f__mg$cache6A == null)
		{
			Lua_BlackJack_ProjectL_UI_ArenaDefendUIController.<>f__mg$cache6A = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ArenaDefendUIController.__callDele_EventOnHeroOnStage);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_ArenaDefendUIController.<>f__mg$cache6A);
		if (Lua_BlackJack_ProjectL_UI_ArenaDefendUIController.<>f__mg$cache6B == null)
		{
			Lua_BlackJack_ProjectL_UI_ArenaDefendUIController.<>f__mg$cache6B = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ArenaDefendUIController.__clearDele_EventOnHeroOnStage);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_ArenaDefendUIController.<>f__mg$cache6B);
		if (Lua_BlackJack_ProjectL_UI_ArenaDefendUIController.<>f__mg$cache6C == null)
		{
			Lua_BlackJack_ProjectL_UI_ArenaDefendUIController.<>f__mg$cache6C = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ArenaDefendUIController.__callDele_EventOnActorOffStage);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_ArenaDefendUIController.<>f__mg$cache6C);
		if (Lua_BlackJack_ProjectL_UI_ArenaDefendUIController.<>f__mg$cache6D == null)
		{
			Lua_BlackJack_ProjectL_UI_ArenaDefendUIController.<>f__mg$cache6D = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ArenaDefendUIController.__clearDele_EventOnActorOffStage);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_ArenaDefendUIController.<>f__mg$cache6D);
		if (Lua_BlackJack_ProjectL_UI_ArenaDefendUIController.<>f__mg$cache6E == null)
		{
			Lua_BlackJack_ProjectL_UI_ArenaDefendUIController.<>f__mg$cache6E = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ArenaDefendUIController.__callDele_EventOnStageActorMove);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_ArenaDefendUIController.<>f__mg$cache6E);
		if (Lua_BlackJack_ProjectL_UI_ArenaDefendUIController.<>f__mg$cache6F == null)
		{
			Lua_BlackJack_ProjectL_UI_ArenaDefendUIController.<>f__mg$cache6F = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ArenaDefendUIController.__clearDele_EventOnStageActorMove);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_ArenaDefendUIController.<>f__mg$cache6F);
		if (Lua_BlackJack_ProjectL_UI_ArenaDefendUIController.<>f__mg$cache70 == null)
		{
			Lua_BlackJack_ProjectL_UI_ArenaDefendUIController.<>f__mg$cache70 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ArenaDefendUIController.__callDele_EventOnStageActorSwap);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_ArenaDefendUIController.<>f__mg$cache70);
		if (Lua_BlackJack_ProjectL_UI_ArenaDefendUIController.<>f__mg$cache71 == null)
		{
			Lua_BlackJack_ProjectL_UI_ArenaDefendUIController.<>f__mg$cache71 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ArenaDefendUIController.__clearDele_EventOnStageActorSwap);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_ArenaDefendUIController.<>f__mg$cache71);
		if (Lua_BlackJack_ProjectL_UI_ArenaDefendUIController.<>f__mg$cache72 == null)
		{
			Lua_BlackJack_ProjectL_UI_ArenaDefendUIController.<>f__mg$cache72 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ArenaDefendUIController.__callDele_EventOnPointerDown);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_ArenaDefendUIController.<>f__mg$cache72);
		if (Lua_BlackJack_ProjectL_UI_ArenaDefendUIController.<>f__mg$cache73 == null)
		{
			Lua_BlackJack_ProjectL_UI_ArenaDefendUIController.<>f__mg$cache73 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ArenaDefendUIController.__clearDele_EventOnPointerDown);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_ArenaDefendUIController.<>f__mg$cache73);
		if (Lua_BlackJack_ProjectL_UI_ArenaDefendUIController.<>f__mg$cache74 == null)
		{
			Lua_BlackJack_ProjectL_UI_ArenaDefendUIController.<>f__mg$cache74 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ArenaDefendUIController.__callDele_EventOnPointerUp);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_ArenaDefendUIController.<>f__mg$cache74);
		if (Lua_BlackJack_ProjectL_UI_ArenaDefendUIController.<>f__mg$cache75 == null)
		{
			Lua_BlackJack_ProjectL_UI_ArenaDefendUIController.<>f__mg$cache75 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ArenaDefendUIController.__clearDele_EventOnPointerUp);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_ArenaDefendUIController.<>f__mg$cache75);
		if (Lua_BlackJack_ProjectL_UI_ArenaDefendUIController.<>f__mg$cache76 == null)
		{
			Lua_BlackJack_ProjectL_UI_ArenaDefendUIController.<>f__mg$cache76 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ArenaDefendUIController.__callDele_EventOnPointerClick);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_ArenaDefendUIController.<>f__mg$cache76);
		if (Lua_BlackJack_ProjectL_UI_ArenaDefendUIController.<>f__mg$cache77 == null)
		{
			Lua_BlackJack_ProjectL_UI_ArenaDefendUIController.<>f__mg$cache77 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ArenaDefendUIController.__clearDele_EventOnPointerClick);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_ArenaDefendUIController.<>f__mg$cache77);
		string name = "EventOnReturn";
		LuaCSFunction get = null;
		if (Lua_BlackJack_ProjectL_UI_ArenaDefendUIController.<>f__mg$cache78 == null)
		{
			Lua_BlackJack_ProjectL_UI_ArenaDefendUIController.<>f__mg$cache78 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ArenaDefendUIController.set_EventOnReturn);
		}
		LuaObject.addMember(l, name, get, Lua_BlackJack_ProjectL_UI_ArenaDefendUIController.<>f__mg$cache78, true);
		string name2 = "EventOnSave";
		LuaCSFunction get2 = null;
		if (Lua_BlackJack_ProjectL_UI_ArenaDefendUIController.<>f__mg$cache79 == null)
		{
			Lua_BlackJack_ProjectL_UI_ArenaDefendUIController.<>f__mg$cache79 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ArenaDefendUIController.set_EventOnSave);
		}
		LuaObject.addMember(l, name2, get2, Lua_BlackJack_ProjectL_UI_ArenaDefendUIController.<>f__mg$cache79, true);
		string name3 = "EventOnShowActionOrderPanel";
		LuaCSFunction get3 = null;
		if (Lua_BlackJack_ProjectL_UI_ArenaDefendUIController.<>f__mg$cache7A == null)
		{
			Lua_BlackJack_ProjectL_UI_ArenaDefendUIController.<>f__mg$cache7A = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ArenaDefendUIController.set_EventOnShowActionOrderPanel);
		}
		LuaObject.addMember(l, name3, get3, Lua_BlackJack_ProjectL_UI_ArenaDefendUIController.<>f__mg$cache7A, true);
		string name4 = "EventOnShowMapPanel";
		LuaCSFunction get4 = null;
		if (Lua_BlackJack_ProjectL_UI_ArenaDefendUIController.<>f__mg$cache7B == null)
		{
			Lua_BlackJack_ProjectL_UI_ArenaDefendUIController.<>f__mg$cache7B = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ArenaDefendUIController.set_EventOnShowMapPanel);
		}
		LuaObject.addMember(l, name4, get4, Lua_BlackJack_ProjectL_UI_ArenaDefendUIController.<>f__mg$cache7B, true);
		string name5 = "EventOnShowDefendRulePanel";
		LuaCSFunction get5 = null;
		if (Lua_BlackJack_ProjectL_UI_ArenaDefendUIController.<>f__mg$cache7C == null)
		{
			Lua_BlackJack_ProjectL_UI_ArenaDefendUIController.<>f__mg$cache7C = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ArenaDefendUIController.set_EventOnShowDefendRulePanel);
		}
		LuaObject.addMember(l, name5, get5, Lua_BlackJack_ProjectL_UI_ArenaDefendUIController.<>f__mg$cache7C, true);
		string name6 = "EventOnConfirmActionOrder";
		LuaCSFunction get6 = null;
		if (Lua_BlackJack_ProjectL_UI_ArenaDefendUIController.<>f__mg$cache7D == null)
		{
			Lua_BlackJack_ProjectL_UI_ArenaDefendUIController.<>f__mg$cache7D = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ArenaDefendUIController.set_EventOnConfirmActionOrder);
		}
		LuaObject.addMember(l, name6, get6, Lua_BlackJack_ProjectL_UI_ArenaDefendUIController.<>f__mg$cache7D, true);
		string name7 = "EventOnConfirmMap";
		LuaCSFunction get7 = null;
		if (Lua_BlackJack_ProjectL_UI_ArenaDefendUIController.<>f__mg$cache7E == null)
		{
			Lua_BlackJack_ProjectL_UI_ArenaDefendUIController.<>f__mg$cache7E = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ArenaDefendUIController.set_EventOnConfirmMap);
		}
		LuaObject.addMember(l, name7, get7, Lua_BlackJack_ProjectL_UI_ArenaDefendUIController.<>f__mg$cache7E, true);
		string name8 = "EventOnConfirmDefendRule";
		LuaCSFunction get8 = null;
		if (Lua_BlackJack_ProjectL_UI_ArenaDefendUIController.<>f__mg$cache7F == null)
		{
			Lua_BlackJack_ProjectL_UI_ArenaDefendUIController.<>f__mg$cache7F = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ArenaDefendUIController.set_EventOnConfirmDefendRule);
		}
		LuaObject.addMember(l, name8, get8, Lua_BlackJack_ProjectL_UI_ArenaDefendUIController.<>f__mg$cache7F, true);
		string name9 = "EventOnShowMyActorInfo";
		LuaCSFunction get9 = null;
		if (Lua_BlackJack_ProjectL_UI_ArenaDefendUIController.<>f__mg$cache80 == null)
		{
			Lua_BlackJack_ProjectL_UI_ArenaDefendUIController.<>f__mg$cache80 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ArenaDefendUIController.set_EventOnShowMyActorInfo);
		}
		LuaObject.addMember(l, name9, get9, Lua_BlackJack_ProjectL_UI_ArenaDefendUIController.<>f__mg$cache80, true);
		string name10 = "EventOnHideActorInfo";
		LuaCSFunction get10 = null;
		if (Lua_BlackJack_ProjectL_UI_ArenaDefendUIController.<>f__mg$cache81 == null)
		{
			Lua_BlackJack_ProjectL_UI_ArenaDefendUIController.<>f__mg$cache81 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ArenaDefendUIController.set_EventOnHideActorInfo);
		}
		LuaObject.addMember(l, name10, get10, Lua_BlackJack_ProjectL_UI_ArenaDefendUIController.<>f__mg$cache81, true);
		string name11 = "EventOnStageActorChange";
		LuaCSFunction get11 = null;
		if (Lua_BlackJack_ProjectL_UI_ArenaDefendUIController.<>f__mg$cache82 == null)
		{
			Lua_BlackJack_ProjectL_UI_ArenaDefendUIController.<>f__mg$cache82 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ArenaDefendUIController.set_EventOnStageActorChange);
		}
		LuaObject.addMember(l, name11, get11, Lua_BlackJack_ProjectL_UI_ArenaDefendUIController.<>f__mg$cache82, true);
		string name12 = "EventOnHeroOnStage";
		LuaCSFunction get12 = null;
		if (Lua_BlackJack_ProjectL_UI_ArenaDefendUIController.<>f__mg$cache83 == null)
		{
			Lua_BlackJack_ProjectL_UI_ArenaDefendUIController.<>f__mg$cache83 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ArenaDefendUIController.set_EventOnHeroOnStage);
		}
		LuaObject.addMember(l, name12, get12, Lua_BlackJack_ProjectL_UI_ArenaDefendUIController.<>f__mg$cache83, true);
		string name13 = "EventOnActorOffStage";
		LuaCSFunction get13 = null;
		if (Lua_BlackJack_ProjectL_UI_ArenaDefendUIController.<>f__mg$cache84 == null)
		{
			Lua_BlackJack_ProjectL_UI_ArenaDefendUIController.<>f__mg$cache84 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ArenaDefendUIController.set_EventOnActorOffStage);
		}
		LuaObject.addMember(l, name13, get13, Lua_BlackJack_ProjectL_UI_ArenaDefendUIController.<>f__mg$cache84, true);
		string name14 = "EventOnStageActorMove";
		LuaCSFunction get14 = null;
		if (Lua_BlackJack_ProjectL_UI_ArenaDefendUIController.<>f__mg$cache85 == null)
		{
			Lua_BlackJack_ProjectL_UI_ArenaDefendUIController.<>f__mg$cache85 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ArenaDefendUIController.set_EventOnStageActorMove);
		}
		LuaObject.addMember(l, name14, get14, Lua_BlackJack_ProjectL_UI_ArenaDefendUIController.<>f__mg$cache85, true);
		string name15 = "EventOnStageActorSwap";
		LuaCSFunction get15 = null;
		if (Lua_BlackJack_ProjectL_UI_ArenaDefendUIController.<>f__mg$cache86 == null)
		{
			Lua_BlackJack_ProjectL_UI_ArenaDefendUIController.<>f__mg$cache86 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ArenaDefendUIController.set_EventOnStageActorSwap);
		}
		LuaObject.addMember(l, name15, get15, Lua_BlackJack_ProjectL_UI_ArenaDefendUIController.<>f__mg$cache86, true);
		string name16 = "EventOnPointerDown";
		LuaCSFunction get16 = null;
		if (Lua_BlackJack_ProjectL_UI_ArenaDefendUIController.<>f__mg$cache87 == null)
		{
			Lua_BlackJack_ProjectL_UI_ArenaDefendUIController.<>f__mg$cache87 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ArenaDefendUIController.set_EventOnPointerDown);
		}
		LuaObject.addMember(l, name16, get16, Lua_BlackJack_ProjectL_UI_ArenaDefendUIController.<>f__mg$cache87, true);
		string name17 = "EventOnPointerUp";
		LuaCSFunction get17 = null;
		if (Lua_BlackJack_ProjectL_UI_ArenaDefendUIController.<>f__mg$cache88 == null)
		{
			Lua_BlackJack_ProjectL_UI_ArenaDefendUIController.<>f__mg$cache88 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ArenaDefendUIController.set_EventOnPointerUp);
		}
		LuaObject.addMember(l, name17, get17, Lua_BlackJack_ProjectL_UI_ArenaDefendUIController.<>f__mg$cache88, true);
		string name18 = "EventOnPointerClick";
		LuaCSFunction get18 = null;
		if (Lua_BlackJack_ProjectL_UI_ArenaDefendUIController.<>f__mg$cache89 == null)
		{
			Lua_BlackJack_ProjectL_UI_ArenaDefendUIController.<>f__mg$cache89 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ArenaDefendUIController.set_EventOnPointerClick);
		}
		LuaObject.addMember(l, name18, get18, Lua_BlackJack_ProjectL_UI_ArenaDefendUIController.<>f__mg$cache89, true);
		string name19 = "m_marginTransform";
		if (Lua_BlackJack_ProjectL_UI_ArenaDefendUIController.<>f__mg$cache8A == null)
		{
			Lua_BlackJack_ProjectL_UI_ArenaDefendUIController.<>f__mg$cache8A = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ArenaDefendUIController.get_m_marginTransform);
		}
		LuaCSFunction get19 = Lua_BlackJack_ProjectL_UI_ArenaDefendUIController.<>f__mg$cache8A;
		if (Lua_BlackJack_ProjectL_UI_ArenaDefendUIController.<>f__mg$cache8B == null)
		{
			Lua_BlackJack_ProjectL_UI_ArenaDefendUIController.<>f__mg$cache8B = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ArenaDefendUIController.set_m_marginTransform);
		}
		LuaObject.addMember(l, name19, get19, Lua_BlackJack_ProjectL_UI_ArenaDefendUIController.<>f__mg$cache8B, true);
		string name20 = "m_returnButton";
		if (Lua_BlackJack_ProjectL_UI_ArenaDefendUIController.<>f__mg$cache8C == null)
		{
			Lua_BlackJack_ProjectL_UI_ArenaDefendUIController.<>f__mg$cache8C = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ArenaDefendUIController.get_m_returnButton);
		}
		LuaCSFunction get20 = Lua_BlackJack_ProjectL_UI_ArenaDefendUIController.<>f__mg$cache8C;
		if (Lua_BlackJack_ProjectL_UI_ArenaDefendUIController.<>f__mg$cache8D == null)
		{
			Lua_BlackJack_ProjectL_UI_ArenaDefendUIController.<>f__mg$cache8D = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ArenaDefendUIController.set_m_returnButton);
		}
		LuaObject.addMember(l, name20, get20, Lua_BlackJack_ProjectL_UI_ArenaDefendUIController.<>f__mg$cache8D, true);
		string name21 = "m_saveTeamButton";
		if (Lua_BlackJack_ProjectL_UI_ArenaDefendUIController.<>f__mg$cache8E == null)
		{
			Lua_BlackJack_ProjectL_UI_ArenaDefendUIController.<>f__mg$cache8E = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ArenaDefendUIController.get_m_saveTeamButton);
		}
		LuaCSFunction get21 = Lua_BlackJack_ProjectL_UI_ArenaDefendUIController.<>f__mg$cache8E;
		if (Lua_BlackJack_ProjectL_UI_ArenaDefendUIController.<>f__mg$cache8F == null)
		{
			Lua_BlackJack_ProjectL_UI_ArenaDefendUIController.<>f__mg$cache8F = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ArenaDefendUIController.set_m_saveTeamButton);
		}
		LuaObject.addMember(l, name21, get21, Lua_BlackJack_ProjectL_UI_ArenaDefendUIController.<>f__mg$cache8F, true);
		string name22 = "m_actionOrderButton";
		if (Lua_BlackJack_ProjectL_UI_ArenaDefendUIController.<>f__mg$cache90 == null)
		{
			Lua_BlackJack_ProjectL_UI_ArenaDefendUIController.<>f__mg$cache90 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ArenaDefendUIController.get_m_actionOrderButton);
		}
		LuaCSFunction get22 = Lua_BlackJack_ProjectL_UI_ArenaDefendUIController.<>f__mg$cache90;
		if (Lua_BlackJack_ProjectL_UI_ArenaDefendUIController.<>f__mg$cache91 == null)
		{
			Lua_BlackJack_ProjectL_UI_ArenaDefendUIController.<>f__mg$cache91 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ArenaDefendUIController.set_m_actionOrderButton);
		}
		LuaObject.addMember(l, name22, get22, Lua_BlackJack_ProjectL_UI_ArenaDefendUIController.<>f__mg$cache91, true);
		string name23 = "m_mapButton";
		if (Lua_BlackJack_ProjectL_UI_ArenaDefendUIController.<>f__mg$cache92 == null)
		{
			Lua_BlackJack_ProjectL_UI_ArenaDefendUIController.<>f__mg$cache92 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ArenaDefendUIController.get_m_mapButton);
		}
		LuaCSFunction get23 = Lua_BlackJack_ProjectL_UI_ArenaDefendUIController.<>f__mg$cache92;
		if (Lua_BlackJack_ProjectL_UI_ArenaDefendUIController.<>f__mg$cache93 == null)
		{
			Lua_BlackJack_ProjectL_UI_ArenaDefendUIController.<>f__mg$cache93 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ArenaDefendUIController.set_m_mapButton);
		}
		LuaObject.addMember(l, name23, get23, Lua_BlackJack_ProjectL_UI_ArenaDefendUIController.<>f__mg$cache93, true);
		string name24 = "m_defendRuleButton";
		if (Lua_BlackJack_ProjectL_UI_ArenaDefendUIController.<>f__mg$cache94 == null)
		{
			Lua_BlackJack_ProjectL_UI_ArenaDefendUIController.<>f__mg$cache94 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ArenaDefendUIController.get_m_defendRuleButton);
		}
		LuaCSFunction get24 = Lua_BlackJack_ProjectL_UI_ArenaDefendUIController.<>f__mg$cache94;
		if (Lua_BlackJack_ProjectL_UI_ArenaDefendUIController.<>f__mg$cache95 == null)
		{
			Lua_BlackJack_ProjectL_UI_ArenaDefendUIController.<>f__mg$cache95 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ArenaDefendUIController.set_m_defendRuleButton);
		}
		LuaObject.addMember(l, name24, get24, Lua_BlackJack_ProjectL_UI_ArenaDefendUIController.<>f__mg$cache95, true);
		string name25 = "m_stageActorCountText";
		if (Lua_BlackJack_ProjectL_UI_ArenaDefendUIController.<>f__mg$cache96 == null)
		{
			Lua_BlackJack_ProjectL_UI_ArenaDefendUIController.<>f__mg$cache96 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ArenaDefendUIController.get_m_stageActorCountText);
		}
		LuaCSFunction get25 = Lua_BlackJack_ProjectL_UI_ArenaDefendUIController.<>f__mg$cache96;
		if (Lua_BlackJack_ProjectL_UI_ArenaDefendUIController.<>f__mg$cache97 == null)
		{
			Lua_BlackJack_ProjectL_UI_ArenaDefendUIController.<>f__mg$cache97 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ArenaDefendUIController.set_m_stageActorCountText);
		}
		LuaObject.addMember(l, name25, get25, Lua_BlackJack_ProjectL_UI_ArenaDefendUIController.<>f__mg$cache97, true);
		string name26 = "m_actorListScrollRect";
		if (Lua_BlackJack_ProjectL_UI_ArenaDefendUIController.<>f__mg$cache98 == null)
		{
			Lua_BlackJack_ProjectL_UI_ArenaDefendUIController.<>f__mg$cache98 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ArenaDefendUIController.get_m_actorListScrollRect);
		}
		LuaCSFunction get26 = Lua_BlackJack_ProjectL_UI_ArenaDefendUIController.<>f__mg$cache98;
		if (Lua_BlackJack_ProjectL_UI_ArenaDefendUIController.<>f__mg$cache99 == null)
		{
			Lua_BlackJack_ProjectL_UI_ArenaDefendUIController.<>f__mg$cache99 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ArenaDefendUIController.set_m_actorListScrollRect);
		}
		LuaObject.addMember(l, name26, get26, Lua_BlackJack_ProjectL_UI_ArenaDefendUIController.<>f__mg$cache99, true);
		string name27 = "m_battlePowerUIStateController";
		if (Lua_BlackJack_ProjectL_UI_ArenaDefendUIController.<>f__mg$cache9A == null)
		{
			Lua_BlackJack_ProjectL_UI_ArenaDefendUIController.<>f__mg$cache9A = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ArenaDefendUIController.get_m_battlePowerUIStateController);
		}
		LuaCSFunction get27 = Lua_BlackJack_ProjectL_UI_ArenaDefendUIController.<>f__mg$cache9A;
		if (Lua_BlackJack_ProjectL_UI_ArenaDefendUIController.<>f__mg$cache9B == null)
		{
			Lua_BlackJack_ProjectL_UI_ArenaDefendUIController.<>f__mg$cache9B = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ArenaDefendUIController.set_m_battlePowerUIStateController);
		}
		LuaObject.addMember(l, name27, get27, Lua_BlackJack_ProjectL_UI_ArenaDefendUIController.<>f__mg$cache9B, true);
		string name28 = "m_battlePowerText";
		if (Lua_BlackJack_ProjectL_UI_ArenaDefendUIController.<>f__mg$cache9C == null)
		{
			Lua_BlackJack_ProjectL_UI_ArenaDefendUIController.<>f__mg$cache9C = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ArenaDefendUIController.get_m_battlePowerText);
		}
		LuaCSFunction get28 = Lua_BlackJack_ProjectL_UI_ArenaDefendUIController.<>f__mg$cache9C;
		if (Lua_BlackJack_ProjectL_UI_ArenaDefendUIController.<>f__mg$cache9D == null)
		{
			Lua_BlackJack_ProjectL_UI_ArenaDefendUIController.<>f__mg$cache9D = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ArenaDefendUIController.set_m_battlePowerText);
		}
		LuaObject.addMember(l, name28, get28, Lua_BlackJack_ProjectL_UI_ArenaDefendUIController.<>f__mg$cache9D, true);
		string name29 = "m_panelGameObject";
		if (Lua_BlackJack_ProjectL_UI_ArenaDefendUIController.<>f__mg$cache9E == null)
		{
			Lua_BlackJack_ProjectL_UI_ArenaDefendUIController.<>f__mg$cache9E = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ArenaDefendUIController.get_m_panelGameObject);
		}
		LuaCSFunction get29 = Lua_BlackJack_ProjectL_UI_ArenaDefendUIController.<>f__mg$cache9E;
		if (Lua_BlackJack_ProjectL_UI_ArenaDefendUIController.<>f__mg$cache9F == null)
		{
			Lua_BlackJack_ProjectL_UI_ArenaDefendUIController.<>f__mg$cache9F = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ArenaDefendUIController.set_m_panelGameObject);
		}
		LuaObject.addMember(l, name29, get29, Lua_BlackJack_ProjectL_UI_ArenaDefendUIController.<>f__mg$cache9F, true);
		string name30 = "m_panelBackgroundButton";
		if (Lua_BlackJack_ProjectL_UI_ArenaDefendUIController.<>f__mg$cacheA0 == null)
		{
			Lua_BlackJack_ProjectL_UI_ArenaDefendUIController.<>f__mg$cacheA0 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ArenaDefendUIController.get_m_panelBackgroundButton);
		}
		LuaCSFunction get30 = Lua_BlackJack_ProjectL_UI_ArenaDefendUIController.<>f__mg$cacheA0;
		if (Lua_BlackJack_ProjectL_UI_ArenaDefendUIController.<>f__mg$cacheA1 == null)
		{
			Lua_BlackJack_ProjectL_UI_ArenaDefendUIController.<>f__mg$cacheA1 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ArenaDefendUIController.set_m_panelBackgroundButton);
		}
		LuaObject.addMember(l, name30, get30, Lua_BlackJack_ProjectL_UI_ArenaDefendUIController.<>f__mg$cacheA1, true);
		string name31 = "m_actionOrderPanelUIStateController";
		if (Lua_BlackJack_ProjectL_UI_ArenaDefendUIController.<>f__mg$cacheA2 == null)
		{
			Lua_BlackJack_ProjectL_UI_ArenaDefendUIController.<>f__mg$cacheA2 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ArenaDefendUIController.get_m_actionOrderPanelUIStateController);
		}
		LuaCSFunction get31 = Lua_BlackJack_ProjectL_UI_ArenaDefendUIController.<>f__mg$cacheA2;
		if (Lua_BlackJack_ProjectL_UI_ArenaDefendUIController.<>f__mg$cacheA3 == null)
		{
			Lua_BlackJack_ProjectL_UI_ArenaDefendUIController.<>f__mg$cacheA3 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ArenaDefendUIController.set_m_actionOrderPanelUIStateController);
		}
		LuaObject.addMember(l, name31, get31, Lua_BlackJack_ProjectL_UI_ArenaDefendUIController.<>f__mg$cacheA3, true);
		string name32 = "m_actionOrderPanelGameObject";
		if (Lua_BlackJack_ProjectL_UI_ArenaDefendUIController.<>f__mg$cacheA4 == null)
		{
			Lua_BlackJack_ProjectL_UI_ArenaDefendUIController.<>f__mg$cacheA4 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ArenaDefendUIController.get_m_actionOrderPanelGameObject);
		}
		LuaCSFunction get32 = Lua_BlackJack_ProjectL_UI_ArenaDefendUIController.<>f__mg$cacheA4;
		if (Lua_BlackJack_ProjectL_UI_ArenaDefendUIController.<>f__mg$cacheA5 == null)
		{
			Lua_BlackJack_ProjectL_UI_ArenaDefendUIController.<>f__mg$cacheA5 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ArenaDefendUIController.set_m_actionOrderPanelGameObject);
		}
		LuaObject.addMember(l, name32, get32, Lua_BlackJack_ProjectL_UI_ArenaDefendUIController.<>f__mg$cacheA5, true);
		string name33 = "m_actionOrdersGameObject";
		if (Lua_BlackJack_ProjectL_UI_ArenaDefendUIController.<>f__mg$cacheA6 == null)
		{
			Lua_BlackJack_ProjectL_UI_ArenaDefendUIController.<>f__mg$cacheA6 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ArenaDefendUIController.get_m_actionOrdersGameObject);
		}
		LuaCSFunction get33 = Lua_BlackJack_ProjectL_UI_ArenaDefendUIController.<>f__mg$cacheA6;
		if (Lua_BlackJack_ProjectL_UI_ArenaDefendUIController.<>f__mg$cacheA7 == null)
		{
			Lua_BlackJack_ProjectL_UI_ArenaDefendUIController.<>f__mg$cacheA7 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ArenaDefendUIController.set_m_actionOrdersGameObject);
		}
		LuaObject.addMember(l, name33, get33, Lua_BlackJack_ProjectL_UI_ArenaDefendUIController.<>f__mg$cacheA7, true);
		string name34 = "m_actionOrderOkButton";
		if (Lua_BlackJack_ProjectL_UI_ArenaDefendUIController.<>f__mg$cacheA8 == null)
		{
			Lua_BlackJack_ProjectL_UI_ArenaDefendUIController.<>f__mg$cacheA8 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ArenaDefendUIController.get_m_actionOrderOkButton);
		}
		LuaCSFunction get34 = Lua_BlackJack_ProjectL_UI_ArenaDefendUIController.<>f__mg$cacheA8;
		if (Lua_BlackJack_ProjectL_UI_ArenaDefendUIController.<>f__mg$cacheA9 == null)
		{
			Lua_BlackJack_ProjectL_UI_ArenaDefendUIController.<>f__mg$cacheA9 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ArenaDefendUIController.set_m_actionOrderOkButton);
		}
		LuaObject.addMember(l, name34, get34, Lua_BlackJack_ProjectL_UI_ArenaDefendUIController.<>f__mg$cacheA9, true);
		string name35 = "m_mapPanelUIStateController";
		if (Lua_BlackJack_ProjectL_UI_ArenaDefendUIController.<>f__mg$cacheAA == null)
		{
			Lua_BlackJack_ProjectL_UI_ArenaDefendUIController.<>f__mg$cacheAA = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ArenaDefendUIController.get_m_mapPanelUIStateController);
		}
		LuaCSFunction get35 = Lua_BlackJack_ProjectL_UI_ArenaDefendUIController.<>f__mg$cacheAA;
		if (Lua_BlackJack_ProjectL_UI_ArenaDefendUIController.<>f__mg$cacheAB == null)
		{
			Lua_BlackJack_ProjectL_UI_ArenaDefendUIController.<>f__mg$cacheAB = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ArenaDefendUIController.set_m_mapPanelUIStateController);
		}
		LuaObject.addMember(l, name35, get35, Lua_BlackJack_ProjectL_UI_ArenaDefendUIController.<>f__mg$cacheAB, true);
		string name36 = "m_mapPanelGameObject";
		if (Lua_BlackJack_ProjectL_UI_ArenaDefendUIController.<>f__mg$cacheAC == null)
		{
			Lua_BlackJack_ProjectL_UI_ArenaDefendUIController.<>f__mg$cacheAC = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ArenaDefendUIController.get_m_mapPanelGameObject);
		}
		LuaCSFunction get36 = Lua_BlackJack_ProjectL_UI_ArenaDefendUIController.<>f__mg$cacheAC;
		if (Lua_BlackJack_ProjectL_UI_ArenaDefendUIController.<>f__mg$cacheAD == null)
		{
			Lua_BlackJack_ProjectL_UI_ArenaDefendUIController.<>f__mg$cacheAD = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ArenaDefendUIController.set_m_mapPanelGameObject);
		}
		LuaObject.addMember(l, name36, get36, Lua_BlackJack_ProjectL_UI_ArenaDefendUIController.<>f__mg$cacheAD, true);
		string name37 = "m_mapsGameObject";
		if (Lua_BlackJack_ProjectL_UI_ArenaDefendUIController.<>f__mg$cacheAE == null)
		{
			Lua_BlackJack_ProjectL_UI_ArenaDefendUIController.<>f__mg$cacheAE = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ArenaDefendUIController.get_m_mapsGameObject);
		}
		LuaCSFunction get37 = Lua_BlackJack_ProjectL_UI_ArenaDefendUIController.<>f__mg$cacheAE;
		if (Lua_BlackJack_ProjectL_UI_ArenaDefendUIController.<>f__mg$cacheAF == null)
		{
			Lua_BlackJack_ProjectL_UI_ArenaDefendUIController.<>f__mg$cacheAF = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ArenaDefendUIController.set_m_mapsGameObject);
		}
		LuaObject.addMember(l, name37, get37, Lua_BlackJack_ProjectL_UI_ArenaDefendUIController.<>f__mg$cacheAF, true);
		string name38 = "m_mapOkButton";
		if (Lua_BlackJack_ProjectL_UI_ArenaDefendUIController.<>f__mg$cacheB0 == null)
		{
			Lua_BlackJack_ProjectL_UI_ArenaDefendUIController.<>f__mg$cacheB0 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ArenaDefendUIController.get_m_mapOkButton);
		}
		LuaCSFunction get38 = Lua_BlackJack_ProjectL_UI_ArenaDefendUIController.<>f__mg$cacheB0;
		if (Lua_BlackJack_ProjectL_UI_ArenaDefendUIController.<>f__mg$cacheB1 == null)
		{
			Lua_BlackJack_ProjectL_UI_ArenaDefendUIController.<>f__mg$cacheB1 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ArenaDefendUIController.set_m_mapOkButton);
		}
		LuaObject.addMember(l, name38, get38, Lua_BlackJack_ProjectL_UI_ArenaDefendUIController.<>f__mg$cacheB1, true);
		string name39 = "m_defendRulePanelUIStateController";
		if (Lua_BlackJack_ProjectL_UI_ArenaDefendUIController.<>f__mg$cacheB2 == null)
		{
			Lua_BlackJack_ProjectL_UI_ArenaDefendUIController.<>f__mg$cacheB2 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ArenaDefendUIController.get_m_defendRulePanelUIStateController);
		}
		LuaCSFunction get39 = Lua_BlackJack_ProjectL_UI_ArenaDefendUIController.<>f__mg$cacheB2;
		if (Lua_BlackJack_ProjectL_UI_ArenaDefendUIController.<>f__mg$cacheB3 == null)
		{
			Lua_BlackJack_ProjectL_UI_ArenaDefendUIController.<>f__mg$cacheB3 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ArenaDefendUIController.set_m_defendRulePanelUIStateController);
		}
		LuaObject.addMember(l, name39, get39, Lua_BlackJack_ProjectL_UI_ArenaDefendUIController.<>f__mg$cacheB3, true);
		string name40 = "m_defendRulePanelGameObject";
		if (Lua_BlackJack_ProjectL_UI_ArenaDefendUIController.<>f__mg$cacheB4 == null)
		{
			Lua_BlackJack_ProjectL_UI_ArenaDefendUIController.<>f__mg$cacheB4 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ArenaDefendUIController.get_m_defendRulePanelGameObject);
		}
		LuaCSFunction get40 = Lua_BlackJack_ProjectL_UI_ArenaDefendUIController.<>f__mg$cacheB4;
		if (Lua_BlackJack_ProjectL_UI_ArenaDefendUIController.<>f__mg$cacheB5 == null)
		{
			Lua_BlackJack_ProjectL_UI_ArenaDefendUIController.<>f__mg$cacheB5 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ArenaDefendUIController.set_m_defendRulePanelGameObject);
		}
		LuaObject.addMember(l, name40, get40, Lua_BlackJack_ProjectL_UI_ArenaDefendUIController.<>f__mg$cacheB5, true);
		string name41 = "m_defendRulesGameObject";
		if (Lua_BlackJack_ProjectL_UI_ArenaDefendUIController.<>f__mg$cacheB6 == null)
		{
			Lua_BlackJack_ProjectL_UI_ArenaDefendUIController.<>f__mg$cacheB6 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ArenaDefendUIController.get_m_defendRulesGameObject);
		}
		LuaCSFunction get41 = Lua_BlackJack_ProjectL_UI_ArenaDefendUIController.<>f__mg$cacheB6;
		if (Lua_BlackJack_ProjectL_UI_ArenaDefendUIController.<>f__mg$cacheB7 == null)
		{
			Lua_BlackJack_ProjectL_UI_ArenaDefendUIController.<>f__mg$cacheB7 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ArenaDefendUIController.set_m_defendRulesGameObject);
		}
		LuaObject.addMember(l, name41, get41, Lua_BlackJack_ProjectL_UI_ArenaDefendUIController.<>f__mg$cacheB7, true);
		string name42 = "m_defendRuleOkButton";
		if (Lua_BlackJack_ProjectL_UI_ArenaDefendUIController.<>f__mg$cacheB8 == null)
		{
			Lua_BlackJack_ProjectL_UI_ArenaDefendUIController.<>f__mg$cacheB8 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ArenaDefendUIController.get_m_defendRuleOkButton);
		}
		LuaCSFunction get42 = Lua_BlackJack_ProjectL_UI_ArenaDefendUIController.<>f__mg$cacheB8;
		if (Lua_BlackJack_ProjectL_UI_ArenaDefendUIController.<>f__mg$cacheB9 == null)
		{
			Lua_BlackJack_ProjectL_UI_ArenaDefendUIController.<>f__mg$cacheB9 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ArenaDefendUIController.set_m_defendRuleOkButton);
		}
		LuaObject.addMember(l, name42, get42, Lua_BlackJack_ProjectL_UI_ArenaDefendUIController.<>f__mg$cacheB9, true);
		string name43 = "m_prefabsGameObject";
		if (Lua_BlackJack_ProjectL_UI_ArenaDefendUIController.<>f__mg$cacheBA == null)
		{
			Lua_BlackJack_ProjectL_UI_ArenaDefendUIController.<>f__mg$cacheBA = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ArenaDefendUIController.get_m_prefabsGameObject);
		}
		LuaCSFunction get43 = Lua_BlackJack_ProjectL_UI_ArenaDefendUIController.<>f__mg$cacheBA;
		if (Lua_BlackJack_ProjectL_UI_ArenaDefendUIController.<>f__mg$cacheBB == null)
		{
			Lua_BlackJack_ProjectL_UI_ArenaDefendUIController.<>f__mg$cacheBB = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ArenaDefendUIController.set_m_prefabsGameObject);
		}
		LuaObject.addMember(l, name43, get43, Lua_BlackJack_ProjectL_UI_ArenaDefendUIController.<>f__mg$cacheBB, true);
		string name44 = "m_heroButtonPrefab";
		if (Lua_BlackJack_ProjectL_UI_ArenaDefendUIController.<>f__mg$cacheBC == null)
		{
			Lua_BlackJack_ProjectL_UI_ArenaDefendUIController.<>f__mg$cacheBC = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ArenaDefendUIController.get_m_heroButtonPrefab);
		}
		LuaCSFunction get44 = Lua_BlackJack_ProjectL_UI_ArenaDefendUIController.<>f__mg$cacheBC;
		if (Lua_BlackJack_ProjectL_UI_ArenaDefendUIController.<>f__mg$cacheBD == null)
		{
			Lua_BlackJack_ProjectL_UI_ArenaDefendUIController.<>f__mg$cacheBD = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ArenaDefendUIController.set_m_heroButtonPrefab);
		}
		LuaObject.addMember(l, name44, get44, Lua_BlackJack_ProjectL_UI_ArenaDefendUIController.<>f__mg$cacheBD, true);
		string name45 = "m_actionOrderButtonPrefab";
		if (Lua_BlackJack_ProjectL_UI_ArenaDefendUIController.<>f__mg$cacheBE == null)
		{
			Lua_BlackJack_ProjectL_UI_ArenaDefendUIController.<>f__mg$cacheBE = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ArenaDefendUIController.get_m_actionOrderButtonPrefab);
		}
		LuaCSFunction get45 = Lua_BlackJack_ProjectL_UI_ArenaDefendUIController.<>f__mg$cacheBE;
		if (Lua_BlackJack_ProjectL_UI_ArenaDefendUIController.<>f__mg$cacheBF == null)
		{
			Lua_BlackJack_ProjectL_UI_ArenaDefendUIController.<>f__mg$cacheBF = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ArenaDefendUIController.set_m_actionOrderButtonPrefab);
		}
		LuaObject.addMember(l, name45, get45, Lua_BlackJack_ProjectL_UI_ArenaDefendUIController.<>f__mg$cacheBF, true);
		string name46 = "m_camera";
		if (Lua_BlackJack_ProjectL_UI_ArenaDefendUIController.<>f__mg$cacheC0 == null)
		{
			Lua_BlackJack_ProjectL_UI_ArenaDefendUIController.<>f__mg$cacheC0 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ArenaDefendUIController.get_m_camera);
		}
		LuaCSFunction get46 = Lua_BlackJack_ProjectL_UI_ArenaDefendUIController.<>f__mg$cacheC0;
		if (Lua_BlackJack_ProjectL_UI_ArenaDefendUIController.<>f__mg$cacheC1 == null)
		{
			Lua_BlackJack_ProjectL_UI_ArenaDefendUIController.<>f__mg$cacheC1 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ArenaDefendUIController.set_m_camera);
		}
		LuaObject.addMember(l, name46, get46, Lua_BlackJack_ProjectL_UI_ArenaDefendUIController.<>f__mg$cacheC1, true);
		string name47 = "m_isIgnorePointerClick";
		if (Lua_BlackJack_ProjectL_UI_ArenaDefendUIController.<>f__mg$cacheC2 == null)
		{
			Lua_BlackJack_ProjectL_UI_ArenaDefendUIController.<>f__mg$cacheC2 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ArenaDefendUIController.get_m_isIgnorePointerClick);
		}
		LuaCSFunction get47 = Lua_BlackJack_ProjectL_UI_ArenaDefendUIController.<>f__mg$cacheC2;
		if (Lua_BlackJack_ProjectL_UI_ArenaDefendUIController.<>f__mg$cacheC3 == null)
		{
			Lua_BlackJack_ProjectL_UI_ArenaDefendUIController.<>f__mg$cacheC3 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ArenaDefendUIController.set_m_isIgnorePointerClick);
		}
		LuaObject.addMember(l, name47, get47, Lua_BlackJack_ProjectL_UI_ArenaDefendUIController.<>f__mg$cacheC3, true);
		string name48 = "m_pointerDownStageActor";
		if (Lua_BlackJack_ProjectL_UI_ArenaDefendUIController.<>f__mg$cacheC4 == null)
		{
			Lua_BlackJack_ProjectL_UI_ArenaDefendUIController.<>f__mg$cacheC4 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ArenaDefendUIController.get_m_pointerDownStageActor);
		}
		LuaCSFunction get48 = Lua_BlackJack_ProjectL_UI_ArenaDefendUIController.<>f__mg$cacheC4;
		if (Lua_BlackJack_ProjectL_UI_ArenaDefendUIController.<>f__mg$cacheC5 == null)
		{
			Lua_BlackJack_ProjectL_UI_ArenaDefendUIController.<>f__mg$cacheC5 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ArenaDefendUIController.set_m_pointerDownStageActor);
		}
		LuaObject.addMember(l, name48, get48, Lua_BlackJack_ProjectL_UI_ArenaDefendUIController.<>f__mg$cacheC5, true);
		string name49 = "m_stageActorCountMax";
		if (Lua_BlackJack_ProjectL_UI_ArenaDefendUIController.<>f__mg$cacheC6 == null)
		{
			Lua_BlackJack_ProjectL_UI_ArenaDefendUIController.<>f__mg$cacheC6 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ArenaDefendUIController.get_m_stageActorCountMax);
		}
		LuaCSFunction get49 = Lua_BlackJack_ProjectL_UI_ArenaDefendUIController.<>f__mg$cacheC6;
		if (Lua_BlackJack_ProjectL_UI_ArenaDefendUIController.<>f__mg$cacheC7 == null)
		{
			Lua_BlackJack_ProjectL_UI_ArenaDefendUIController.<>f__mg$cacheC7 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ArenaDefendUIController.set_m_stageActorCountMax);
		}
		LuaObject.addMember(l, name49, get49, Lua_BlackJack_ProjectL_UI_ArenaDefendUIController.<>f__mg$cacheC7, true);
		string name50 = "m_isStageActorChanged";
		if (Lua_BlackJack_ProjectL_UI_ArenaDefendUIController.<>f__mg$cacheC8 == null)
		{
			Lua_BlackJack_ProjectL_UI_ArenaDefendUIController.<>f__mg$cacheC8 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ArenaDefendUIController.get_m_isStageActorChanged);
		}
		LuaCSFunction get50 = Lua_BlackJack_ProjectL_UI_ArenaDefendUIController.<>f__mg$cacheC8;
		if (Lua_BlackJack_ProjectL_UI_ArenaDefendUIController.<>f__mg$cacheC9 == null)
		{
			Lua_BlackJack_ProjectL_UI_ArenaDefendUIController.<>f__mg$cacheC9 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ArenaDefendUIController.set_m_isStageActorChanged);
		}
		LuaObject.addMember(l, name50, get50, Lua_BlackJack_ProjectL_UI_ArenaDefendUIController.<>f__mg$cacheC9, true);
		string name51 = "m_heroButtons";
		if (Lua_BlackJack_ProjectL_UI_ArenaDefendUIController.<>f__mg$cacheCA == null)
		{
			Lua_BlackJack_ProjectL_UI_ArenaDefendUIController.<>f__mg$cacheCA = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ArenaDefendUIController.get_m_heroButtons);
		}
		LuaCSFunction get51 = Lua_BlackJack_ProjectL_UI_ArenaDefendUIController.<>f__mg$cacheCA;
		if (Lua_BlackJack_ProjectL_UI_ArenaDefendUIController.<>f__mg$cacheCB == null)
		{
			Lua_BlackJack_ProjectL_UI_ArenaDefendUIController.<>f__mg$cacheCB = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ArenaDefendUIController.set_m_heroButtons);
		}
		LuaObject.addMember(l, name51, get51, Lua_BlackJack_ProjectL_UI_ArenaDefendUIController.<>f__mg$cacheCB, true);
		string name52 = "m_stageActors";
		if (Lua_BlackJack_ProjectL_UI_ArenaDefendUIController.<>f__mg$cacheCC == null)
		{
			Lua_BlackJack_ProjectL_UI_ArenaDefendUIController.<>f__mg$cacheCC = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ArenaDefendUIController.get_m_stageActors);
		}
		LuaCSFunction get52 = Lua_BlackJack_ProjectL_UI_ArenaDefendUIController.<>f__mg$cacheCC;
		if (Lua_BlackJack_ProjectL_UI_ArenaDefendUIController.<>f__mg$cacheCD == null)
		{
			Lua_BlackJack_ProjectL_UI_ArenaDefendUIController.<>f__mg$cacheCD = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ArenaDefendUIController.set_m_stageActors);
		}
		LuaObject.addMember(l, name52, get52, Lua_BlackJack_ProjectL_UI_ArenaDefendUIController.<>f__mg$cacheCD, true);
		string name53 = "m_stagePositions";
		if (Lua_BlackJack_ProjectL_UI_ArenaDefendUIController.<>f__mg$cacheCE == null)
		{
			Lua_BlackJack_ProjectL_UI_ArenaDefendUIController.<>f__mg$cacheCE = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ArenaDefendUIController.get_m_stagePositions);
		}
		LuaCSFunction get53 = Lua_BlackJack_ProjectL_UI_ArenaDefendUIController.<>f__mg$cacheCE;
		if (Lua_BlackJack_ProjectL_UI_ArenaDefendUIController.<>f__mg$cacheCF == null)
		{
			Lua_BlackJack_ProjectL_UI_ArenaDefendUIController.<>f__mg$cacheCF = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ArenaDefendUIController.set_m_stagePositions);
		}
		LuaObject.addMember(l, name53, get53, Lua_BlackJack_ProjectL_UI_ArenaDefendUIController.<>f__mg$cacheCF, true);
		string name54 = "m_stageDirs";
		if (Lua_BlackJack_ProjectL_UI_ArenaDefendUIController.<>f__mg$cacheD0 == null)
		{
			Lua_BlackJack_ProjectL_UI_ArenaDefendUIController.<>f__mg$cacheD0 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ArenaDefendUIController.get_m_stageDirs);
		}
		LuaCSFunction get54 = Lua_BlackJack_ProjectL_UI_ArenaDefendUIController.<>f__mg$cacheD0;
		if (Lua_BlackJack_ProjectL_UI_ArenaDefendUIController.<>f__mg$cacheD1 == null)
		{
			Lua_BlackJack_ProjectL_UI_ArenaDefendUIController.<>f__mg$cacheD1 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ArenaDefendUIController.set_m_stageDirs);
		}
		LuaObject.addMember(l, name54, get54, Lua_BlackJack_ProjectL_UI_ArenaDefendUIController.<>f__mg$cacheD1, true);
		string name55 = "m_actionOrderButtons";
		if (Lua_BlackJack_ProjectL_UI_ArenaDefendUIController.<>f__mg$cacheD2 == null)
		{
			Lua_BlackJack_ProjectL_UI_ArenaDefendUIController.<>f__mg$cacheD2 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ArenaDefendUIController.get_m_actionOrderButtons);
		}
		LuaCSFunction get55 = Lua_BlackJack_ProjectL_UI_ArenaDefendUIController.<>f__mg$cacheD2;
		if (Lua_BlackJack_ProjectL_UI_ArenaDefendUIController.<>f__mg$cacheD3 == null)
		{
			Lua_BlackJack_ProjectL_UI_ArenaDefendUIController.<>f__mg$cacheD3 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ArenaDefendUIController.set_m_actionOrderButtons);
		}
		LuaObject.addMember(l, name55, get55, Lua_BlackJack_ProjectL_UI_ArenaDefendUIController.<>f__mg$cacheD3, true);
		string name56 = "m_defendMapToggles";
		if (Lua_BlackJack_ProjectL_UI_ArenaDefendUIController.<>f__mg$cacheD4 == null)
		{
			Lua_BlackJack_ProjectL_UI_ArenaDefendUIController.<>f__mg$cacheD4 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ArenaDefendUIController.get_m_defendMapToggles);
		}
		LuaCSFunction get56 = Lua_BlackJack_ProjectL_UI_ArenaDefendUIController.<>f__mg$cacheD4;
		if (Lua_BlackJack_ProjectL_UI_ArenaDefendUIController.<>f__mg$cacheD5 == null)
		{
			Lua_BlackJack_ProjectL_UI_ArenaDefendUIController.<>f__mg$cacheD5 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ArenaDefendUIController.set_m_defendMapToggles);
		}
		LuaObject.addMember(l, name56, get56, Lua_BlackJack_ProjectL_UI_ArenaDefendUIController.<>f__mg$cacheD5, true);
		string name57 = "m_defendRuleToggles";
		if (Lua_BlackJack_ProjectL_UI_ArenaDefendUIController.<>f__mg$cacheD6 == null)
		{
			Lua_BlackJack_ProjectL_UI_ArenaDefendUIController.<>f__mg$cacheD6 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ArenaDefendUIController.get_m_defendRuleToggles);
		}
		LuaCSFunction get57 = Lua_BlackJack_ProjectL_UI_ArenaDefendUIController.<>f__mg$cacheD6;
		if (Lua_BlackJack_ProjectL_UI_ArenaDefendUIController.<>f__mg$cacheD7 == null)
		{
			Lua_BlackJack_ProjectL_UI_ArenaDefendUIController.<>f__mg$cacheD7 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ArenaDefendUIController.set_m_defendRuleToggles);
		}
		LuaObject.addMember(l, name57, get57, Lua_BlackJack_ProjectL_UI_ArenaDefendUIController.<>f__mg$cacheD7, true);
		string name58 = "m_draggingHeroButton";
		if (Lua_BlackJack_ProjectL_UI_ArenaDefendUIController.<>f__mg$cacheD8 == null)
		{
			Lua_BlackJack_ProjectL_UI_ArenaDefendUIController.<>f__mg$cacheD8 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ArenaDefendUIController.get_m_draggingHeroButton);
		}
		LuaCSFunction get58 = Lua_BlackJack_ProjectL_UI_ArenaDefendUIController.<>f__mg$cacheD8;
		if (Lua_BlackJack_ProjectL_UI_ArenaDefendUIController.<>f__mg$cacheD9 == null)
		{
			Lua_BlackJack_ProjectL_UI_ArenaDefendUIController.<>f__mg$cacheD9 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ArenaDefendUIController.set_m_draggingHeroButton);
		}
		LuaObject.addMember(l, name58, get58, Lua_BlackJack_ProjectL_UI_ArenaDefendUIController.<>f__mg$cacheD9, true);
		string name59 = "m_draggingActionOrderButton";
		if (Lua_BlackJack_ProjectL_UI_ArenaDefendUIController.<>f__mg$cacheDA == null)
		{
			Lua_BlackJack_ProjectL_UI_ArenaDefendUIController.<>f__mg$cacheDA = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ArenaDefendUIController.get_m_draggingActionOrderButton);
		}
		LuaCSFunction get59 = Lua_BlackJack_ProjectL_UI_ArenaDefendUIController.<>f__mg$cacheDA;
		if (Lua_BlackJack_ProjectL_UI_ArenaDefendUIController.<>f__mg$cacheDB == null)
		{
			Lua_BlackJack_ProjectL_UI_ArenaDefendUIController.<>f__mg$cacheDB = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ArenaDefendUIController.set_m_draggingActionOrderButton);
		}
		LuaObject.addMember(l, name59, get59, Lua_BlackJack_ProjectL_UI_ArenaDefendUIController.<>f__mg$cacheDB, true);
		string name60 = "m_draggingActionOrderButtonIndex";
		if (Lua_BlackJack_ProjectL_UI_ArenaDefendUIController.<>f__mg$cacheDC == null)
		{
			Lua_BlackJack_ProjectL_UI_ArenaDefendUIController.<>f__mg$cacheDC = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ArenaDefendUIController.get_m_draggingActionOrderButtonIndex);
		}
		LuaCSFunction get60 = Lua_BlackJack_ProjectL_UI_ArenaDefendUIController.<>f__mg$cacheDC;
		if (Lua_BlackJack_ProjectL_UI_ArenaDefendUIController.<>f__mg$cacheDD == null)
		{
			Lua_BlackJack_ProjectL_UI_ArenaDefendUIController.<>f__mg$cacheDD = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ArenaDefendUIController.set_m_draggingActionOrderButtonIndex);
		}
		LuaObject.addMember(l, name60, get60, Lua_BlackJack_ProjectL_UI_ArenaDefendUIController.<>f__mg$cacheDD, true);
		string name61 = "m_arenaDefendBattle";
		if (Lua_BlackJack_ProjectL_UI_ArenaDefendUIController.<>f__mg$cacheDE == null)
		{
			Lua_BlackJack_ProjectL_UI_ArenaDefendUIController.<>f__mg$cacheDE = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ArenaDefendUIController.get_m_arenaDefendBattle);
		}
		LuaCSFunction get61 = Lua_BlackJack_ProjectL_UI_ArenaDefendUIController.<>f__mg$cacheDE;
		if (Lua_BlackJack_ProjectL_UI_ArenaDefendUIController.<>f__mg$cacheDF == null)
		{
			Lua_BlackJack_ProjectL_UI_ArenaDefendUIController.<>f__mg$cacheDF = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ArenaDefendUIController.set_m_arenaDefendBattle);
		}
		LuaObject.addMember(l, name61, get61, Lua_BlackJack_ProjectL_UI_ArenaDefendUIController.<>f__mg$cacheDF, true);
		string name62 = "m_battlePowerValue";
		if (Lua_BlackJack_ProjectL_UI_ArenaDefendUIController.<>f__mg$cacheE0 == null)
		{
			Lua_BlackJack_ProjectL_UI_ArenaDefendUIController.<>f__mg$cacheE0 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ArenaDefendUIController.get_m_battlePowerValue);
		}
		LuaCSFunction get62 = Lua_BlackJack_ProjectL_UI_ArenaDefendUIController.<>f__mg$cacheE0;
		if (Lua_BlackJack_ProjectL_UI_ArenaDefendUIController.<>f__mg$cacheE1 == null)
		{
			Lua_BlackJack_ProjectL_UI_ArenaDefendUIController.<>f__mg$cacheE1 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ArenaDefendUIController.set_m_battlePowerValue);
		}
		LuaObject.addMember(l, name62, get62, Lua_BlackJack_ProjectL_UI_ArenaDefendUIController.<>f__mg$cacheE1, true);
		string name63 = "m_setBattlePowerValueCoroutine";
		if (Lua_BlackJack_ProjectL_UI_ArenaDefendUIController.<>f__mg$cacheE2 == null)
		{
			Lua_BlackJack_ProjectL_UI_ArenaDefendUIController.<>f__mg$cacheE2 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ArenaDefendUIController.get_m_setBattlePowerValueCoroutine);
		}
		LuaCSFunction get63 = Lua_BlackJack_ProjectL_UI_ArenaDefendUIController.<>f__mg$cacheE2;
		if (Lua_BlackJack_ProjectL_UI_ArenaDefendUIController.<>f__mg$cacheE3 == null)
		{
			Lua_BlackJack_ProjectL_UI_ArenaDefendUIController.<>f__mg$cacheE3 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ArenaDefendUIController.set_m_setBattlePowerValueCoroutine);
		}
		LuaObject.addMember(l, name63, get63, Lua_BlackJack_ProjectL_UI_ArenaDefendUIController.<>f__mg$cacheE3, true);
		LuaObject.createTypeMetatable(l, null, typeof(ArenaDefendUIController), typeof(UIControllerBase));
	}

	// Token: 0x04011117 RID: 69911
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache0;

	// Token: 0x04011118 RID: 69912
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1;

	// Token: 0x04011119 RID: 69913
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2;

	// Token: 0x0401111A RID: 69914
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3;

	// Token: 0x0401111B RID: 69915
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache4;

	// Token: 0x0401111C RID: 69916
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache5;

	// Token: 0x0401111D RID: 69917
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache6;

	// Token: 0x0401111E RID: 69918
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache7;

	// Token: 0x0401111F RID: 69919
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache8;

	// Token: 0x04011120 RID: 69920
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache9;

	// Token: 0x04011121 RID: 69921
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheA;

	// Token: 0x04011122 RID: 69922
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheB;

	// Token: 0x04011123 RID: 69923
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheC;

	// Token: 0x04011124 RID: 69924
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheD;

	// Token: 0x04011125 RID: 69925
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheE;

	// Token: 0x04011126 RID: 69926
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheF;

	// Token: 0x04011127 RID: 69927
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache10;

	// Token: 0x04011128 RID: 69928
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache11;

	// Token: 0x04011129 RID: 69929
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache12;

	// Token: 0x0401112A RID: 69930
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache13;

	// Token: 0x0401112B RID: 69931
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache14;

	// Token: 0x0401112C RID: 69932
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache15;

	// Token: 0x0401112D RID: 69933
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache16;

	// Token: 0x0401112E RID: 69934
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache17;

	// Token: 0x0401112F RID: 69935
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache18;

	// Token: 0x04011130 RID: 69936
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache19;

	// Token: 0x04011131 RID: 69937
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1A;

	// Token: 0x04011132 RID: 69938
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1B;

	// Token: 0x04011133 RID: 69939
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1C;

	// Token: 0x04011134 RID: 69940
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1D;

	// Token: 0x04011135 RID: 69941
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1E;

	// Token: 0x04011136 RID: 69942
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1F;

	// Token: 0x04011137 RID: 69943
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache20;

	// Token: 0x04011138 RID: 69944
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache21;

	// Token: 0x04011139 RID: 69945
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache22;

	// Token: 0x0401113A RID: 69946
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache23;

	// Token: 0x0401113B RID: 69947
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache24;

	// Token: 0x0401113C RID: 69948
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache25;

	// Token: 0x0401113D RID: 69949
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache26;

	// Token: 0x0401113E RID: 69950
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache27;

	// Token: 0x0401113F RID: 69951
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache28;

	// Token: 0x04011140 RID: 69952
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache29;

	// Token: 0x04011141 RID: 69953
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2A;

	// Token: 0x04011142 RID: 69954
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2B;

	// Token: 0x04011143 RID: 69955
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2C;

	// Token: 0x04011144 RID: 69956
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2D;

	// Token: 0x04011145 RID: 69957
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2E;

	// Token: 0x04011146 RID: 69958
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2F;

	// Token: 0x04011147 RID: 69959
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache30;

	// Token: 0x04011148 RID: 69960
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache31;

	// Token: 0x04011149 RID: 69961
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache32;

	// Token: 0x0401114A RID: 69962
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache33;

	// Token: 0x0401114B RID: 69963
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache34;

	// Token: 0x0401114C RID: 69964
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache35;

	// Token: 0x0401114D RID: 69965
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache36;

	// Token: 0x0401114E RID: 69966
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache37;

	// Token: 0x0401114F RID: 69967
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache38;

	// Token: 0x04011150 RID: 69968
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache39;

	// Token: 0x04011151 RID: 69969
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3A;

	// Token: 0x04011152 RID: 69970
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3B;

	// Token: 0x04011153 RID: 69971
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3C;

	// Token: 0x04011154 RID: 69972
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3D;

	// Token: 0x04011155 RID: 69973
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3E;

	// Token: 0x04011156 RID: 69974
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3F;

	// Token: 0x04011157 RID: 69975
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache40;

	// Token: 0x04011158 RID: 69976
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache41;

	// Token: 0x04011159 RID: 69977
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache42;

	// Token: 0x0401115A RID: 69978
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache43;

	// Token: 0x0401115B RID: 69979
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache44;

	// Token: 0x0401115C RID: 69980
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache45;

	// Token: 0x0401115D RID: 69981
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache46;

	// Token: 0x0401115E RID: 69982
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache47;

	// Token: 0x0401115F RID: 69983
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache48;

	// Token: 0x04011160 RID: 69984
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache49;

	// Token: 0x04011161 RID: 69985
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache4A;

	// Token: 0x04011162 RID: 69986
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache4B;

	// Token: 0x04011163 RID: 69987
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache4C;

	// Token: 0x04011164 RID: 69988
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache4D;

	// Token: 0x04011165 RID: 69989
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache4E;

	// Token: 0x04011166 RID: 69990
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache4F;

	// Token: 0x04011167 RID: 69991
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache50;

	// Token: 0x04011168 RID: 69992
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache51;

	// Token: 0x04011169 RID: 69993
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache52;

	// Token: 0x0401116A RID: 69994
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache53;

	// Token: 0x0401116B RID: 69995
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache54;

	// Token: 0x0401116C RID: 69996
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache55;

	// Token: 0x0401116D RID: 69997
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache56;

	// Token: 0x0401116E RID: 69998
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache57;

	// Token: 0x0401116F RID: 69999
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache58;

	// Token: 0x04011170 RID: 70000
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache59;

	// Token: 0x04011171 RID: 70001
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache5A;

	// Token: 0x04011172 RID: 70002
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache5B;

	// Token: 0x04011173 RID: 70003
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache5C;

	// Token: 0x04011174 RID: 70004
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache5D;

	// Token: 0x04011175 RID: 70005
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache5E;

	// Token: 0x04011176 RID: 70006
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache5F;

	// Token: 0x04011177 RID: 70007
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache60;

	// Token: 0x04011178 RID: 70008
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache61;

	// Token: 0x04011179 RID: 70009
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache62;

	// Token: 0x0401117A RID: 70010
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache63;

	// Token: 0x0401117B RID: 70011
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache64;

	// Token: 0x0401117C RID: 70012
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache65;

	// Token: 0x0401117D RID: 70013
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache66;

	// Token: 0x0401117E RID: 70014
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache67;

	// Token: 0x0401117F RID: 70015
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache68;

	// Token: 0x04011180 RID: 70016
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache69;

	// Token: 0x04011181 RID: 70017
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache6A;

	// Token: 0x04011182 RID: 70018
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache6B;

	// Token: 0x04011183 RID: 70019
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache6C;

	// Token: 0x04011184 RID: 70020
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache6D;

	// Token: 0x04011185 RID: 70021
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache6E;

	// Token: 0x04011186 RID: 70022
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache6F;

	// Token: 0x04011187 RID: 70023
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache70;

	// Token: 0x04011188 RID: 70024
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache71;

	// Token: 0x04011189 RID: 70025
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache72;

	// Token: 0x0401118A RID: 70026
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache73;

	// Token: 0x0401118B RID: 70027
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache74;

	// Token: 0x0401118C RID: 70028
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache75;

	// Token: 0x0401118D RID: 70029
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache76;

	// Token: 0x0401118E RID: 70030
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache77;

	// Token: 0x0401118F RID: 70031
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache78;

	// Token: 0x04011190 RID: 70032
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache79;

	// Token: 0x04011191 RID: 70033
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache7A;

	// Token: 0x04011192 RID: 70034
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache7B;

	// Token: 0x04011193 RID: 70035
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache7C;

	// Token: 0x04011194 RID: 70036
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache7D;

	// Token: 0x04011195 RID: 70037
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache7E;

	// Token: 0x04011196 RID: 70038
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache7F;

	// Token: 0x04011197 RID: 70039
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache80;

	// Token: 0x04011198 RID: 70040
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache81;

	// Token: 0x04011199 RID: 70041
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache82;

	// Token: 0x0401119A RID: 70042
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache83;

	// Token: 0x0401119B RID: 70043
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache84;

	// Token: 0x0401119C RID: 70044
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache85;

	// Token: 0x0401119D RID: 70045
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache86;

	// Token: 0x0401119E RID: 70046
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache87;

	// Token: 0x0401119F RID: 70047
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache88;

	// Token: 0x040111A0 RID: 70048
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache89;

	// Token: 0x040111A1 RID: 70049
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache8A;

	// Token: 0x040111A2 RID: 70050
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache8B;

	// Token: 0x040111A3 RID: 70051
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache8C;

	// Token: 0x040111A4 RID: 70052
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache8D;

	// Token: 0x040111A5 RID: 70053
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache8E;

	// Token: 0x040111A6 RID: 70054
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache8F;

	// Token: 0x040111A7 RID: 70055
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache90;

	// Token: 0x040111A8 RID: 70056
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache91;

	// Token: 0x040111A9 RID: 70057
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache92;

	// Token: 0x040111AA RID: 70058
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache93;

	// Token: 0x040111AB RID: 70059
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache94;

	// Token: 0x040111AC RID: 70060
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache95;

	// Token: 0x040111AD RID: 70061
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache96;

	// Token: 0x040111AE RID: 70062
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache97;

	// Token: 0x040111AF RID: 70063
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache98;

	// Token: 0x040111B0 RID: 70064
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache99;

	// Token: 0x040111B1 RID: 70065
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache9A;

	// Token: 0x040111B2 RID: 70066
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache9B;

	// Token: 0x040111B3 RID: 70067
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache9C;

	// Token: 0x040111B4 RID: 70068
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache9D;

	// Token: 0x040111B5 RID: 70069
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache9E;

	// Token: 0x040111B6 RID: 70070
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache9F;

	// Token: 0x040111B7 RID: 70071
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheA0;

	// Token: 0x040111B8 RID: 70072
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheA1;

	// Token: 0x040111B9 RID: 70073
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheA2;

	// Token: 0x040111BA RID: 70074
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheA3;

	// Token: 0x040111BB RID: 70075
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheA4;

	// Token: 0x040111BC RID: 70076
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheA5;

	// Token: 0x040111BD RID: 70077
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheA6;

	// Token: 0x040111BE RID: 70078
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheA7;

	// Token: 0x040111BF RID: 70079
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheA8;

	// Token: 0x040111C0 RID: 70080
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheA9;

	// Token: 0x040111C1 RID: 70081
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheAA;

	// Token: 0x040111C2 RID: 70082
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheAB;

	// Token: 0x040111C3 RID: 70083
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheAC;

	// Token: 0x040111C4 RID: 70084
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheAD;

	// Token: 0x040111C5 RID: 70085
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheAE;

	// Token: 0x040111C6 RID: 70086
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheAF;

	// Token: 0x040111C7 RID: 70087
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheB0;

	// Token: 0x040111C8 RID: 70088
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheB1;

	// Token: 0x040111C9 RID: 70089
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheB2;

	// Token: 0x040111CA RID: 70090
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheB3;

	// Token: 0x040111CB RID: 70091
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheB4;

	// Token: 0x040111CC RID: 70092
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheB5;

	// Token: 0x040111CD RID: 70093
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheB6;

	// Token: 0x040111CE RID: 70094
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheB7;

	// Token: 0x040111CF RID: 70095
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheB8;

	// Token: 0x040111D0 RID: 70096
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheB9;

	// Token: 0x040111D1 RID: 70097
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheBA;

	// Token: 0x040111D2 RID: 70098
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheBB;

	// Token: 0x040111D3 RID: 70099
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheBC;

	// Token: 0x040111D4 RID: 70100
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheBD;

	// Token: 0x040111D5 RID: 70101
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheBE;

	// Token: 0x040111D6 RID: 70102
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheBF;

	// Token: 0x040111D7 RID: 70103
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheC0;

	// Token: 0x040111D8 RID: 70104
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheC1;

	// Token: 0x040111D9 RID: 70105
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheC2;

	// Token: 0x040111DA RID: 70106
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheC3;

	// Token: 0x040111DB RID: 70107
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheC4;

	// Token: 0x040111DC RID: 70108
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheC5;

	// Token: 0x040111DD RID: 70109
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheC6;

	// Token: 0x040111DE RID: 70110
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheC7;

	// Token: 0x040111DF RID: 70111
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheC8;

	// Token: 0x040111E0 RID: 70112
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheC9;

	// Token: 0x040111E1 RID: 70113
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheCA;

	// Token: 0x040111E2 RID: 70114
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheCB;

	// Token: 0x040111E3 RID: 70115
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheCC;

	// Token: 0x040111E4 RID: 70116
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheCD;

	// Token: 0x040111E5 RID: 70117
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheCE;

	// Token: 0x040111E6 RID: 70118
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheCF;

	// Token: 0x040111E7 RID: 70119
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheD0;

	// Token: 0x040111E8 RID: 70120
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheD1;

	// Token: 0x040111E9 RID: 70121
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheD2;

	// Token: 0x040111EA RID: 70122
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheD3;

	// Token: 0x040111EB RID: 70123
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheD4;

	// Token: 0x040111EC RID: 70124
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheD5;

	// Token: 0x040111ED RID: 70125
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheD6;

	// Token: 0x040111EE RID: 70126
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheD7;

	// Token: 0x040111EF RID: 70127
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheD8;

	// Token: 0x040111F0 RID: 70128
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheD9;

	// Token: 0x040111F1 RID: 70129
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheDA;

	// Token: 0x040111F2 RID: 70130
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheDB;

	// Token: 0x040111F3 RID: 70131
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheDC;

	// Token: 0x040111F4 RID: 70132
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheDD;

	// Token: 0x040111F5 RID: 70133
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheDE;

	// Token: 0x040111F6 RID: 70134
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheDF;

	// Token: 0x040111F7 RID: 70135
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheE0;

	// Token: 0x040111F8 RID: 70136
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheE1;

	// Token: 0x040111F9 RID: 70137
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheE2;

	// Token: 0x040111FA RID: 70138
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheE3;
}
