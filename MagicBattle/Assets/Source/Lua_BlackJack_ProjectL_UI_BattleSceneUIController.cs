using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using BlackJack.BJFramework.Runtime.Prefab;
using BlackJack.BJFramework.Runtime.UI;
using BlackJack.ConfigData;
using BlackJack.ProjectL.Battle;
using BlackJack.ProjectL.Common;
using BlackJack.ProjectL.Misc;
using BlackJack.ProjectL.Scene;
using BlackJack.ProjectL.UI;
using SLua;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.Scripting;
using UnityEngine.UI;

// Token: 0x020013C2 RID: 5058
[Preserve]
public class Lua_BlackJack_ProjectL_UI_BattleSceneUIController : LuaObject
{
	// Token: 0x0601BF56 RID: 114518 RVA: 0x008941F0 File Offset: 0x008923F0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int Initialize(IntPtr l)
	{
		int result;
		try
		{
			BattleSceneUIController battleSceneUIController = (BattleSceneUIController)LuaObject.checkSelf(l);
			ClientBattle clientBattle;
			LuaObject.checkType<ClientBattle>(l, 2, out clientBattle);
			BattleMapUIController battleMapUIController;
			LuaObject.checkType<BattleMapUIController>(l, 3, out battleMapUIController);
			battleSceneUIController.Initialize(clientBattle, battleMapUIController);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601BF57 RID: 114519 RVA: 0x00894254 File Offset: 0x00892454
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int PrepareBattle(IntPtr l)
	{
		int result;
		try
		{
			BattleSceneUIController battleSceneUIController = (BattleSceneUIController)LuaObject.checkSelf(l);
			battleSceneUIController.PrepareBattle();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601BF58 RID: 114520 RVA: 0x008942A0 File Offset: 0x008924A0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int StartBattle(IntPtr l)
	{
		int result;
		try
		{
			BattleSceneUIController battleSceneUIController = (BattleSceneUIController)LuaObject.checkSelf(l);
			battleSceneUIController.StartBattle();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601BF59 RID: 114521 RVA: 0x008942EC File Offset: 0x008924EC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int StopBattle(IntPtr l)
	{
		int result;
		try
		{
			BattleSceneUIController battleSceneUIController = (BattleSceneUIController)LuaObject.checkSelf(l);
			battleSceneUIController.StopBattle();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601BF5A RID: 114522 RVA: 0x00894338 File Offset: 0x00892538
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int ShowBattleWinCondition(IntPtr l)
	{
		int result;
		try
		{
			BattleSceneUIController battleSceneUIController = (BattleSceneUIController)LuaObject.checkSelf(l);
			ConfigDataBattleWinConditionInfo winConditionInfo;
			LuaObject.checkType<ConfigDataBattleWinConditionInfo>(l, 2, out winConditionInfo);
			GridPosition targetPos;
			LuaObject.checkValueType<GridPosition>(l, 3, out targetPos);
			battleSceneUIController.ShowBattleWinCondition(winConditionInfo, targetPos);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601BF5B RID: 114523 RVA: 0x0089439C File Offset: 0x0089259C
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int HideBattleWinCondition(IntPtr l)
	{
		int result;
		try
		{
			BattleSceneUIController battleSceneUIController = (BattleSceneUIController)LuaObject.checkSelf(l);
			ConfigDataBattleWinConditionInfo winConditionInfo;
			LuaObject.checkType<ConfigDataBattleWinConditionInfo>(l, 2, out winConditionInfo);
			GridPosition targetPos;
			LuaObject.checkValueType<GridPosition>(l, 3, out targetPos);
			battleSceneUIController.HideBattleWinCondition(winConditionInfo, targetPos);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601BF5C RID: 114524 RVA: 0x00894400 File Offset: 0x00892600
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int OnActorSkillHit(IntPtr l)
	{
		int result;
		try
		{
			BattleSceneUIController battleSceneUIController = (BattleSceneUIController)LuaObject.checkSelf(l);
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
			battleSceneUIController.OnActorSkillHit(a, skillInfo, heroHpModify, soldierHpModify, damageNumberType);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601BF5D RID: 114525 RVA: 0x0089448C File Offset: 0x0089268C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int OnActorBuffHit(IntPtr l)
	{
		int result;
		try
		{
			BattleSceneUIController battleSceneUIController = (BattleSceneUIController)LuaObject.checkSelf(l);
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
			battleSceneUIController.OnActorBuffHit(a, buffInfo, heroHpModify, soldierHpModify, damageNumberType);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601BF5E RID: 114526 RVA: 0x00894518 File Offset: 0x00892718
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int OnActorTerrainHit(IntPtr l)
	{
		int result;
		try
		{
			BattleSceneUIController battleSceneUIController = (BattleSceneUIController)LuaObject.checkSelf(l);
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
			battleSceneUIController.OnActorTerrainHit(a, terrainInfo, heroHpModify, soldierHpModify, damageNumberType);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601BF5F RID: 114527 RVA: 0x008945A4 File Offset: 0x008927A4
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int OnActorAttachImmune(IntPtr l)
	{
		int result;
		try
		{
			BattleSceneUIController battleSceneUIController = (BattleSceneUIController)LuaObject.checkSelf(l);
			ClientBattleActor a;
			LuaObject.checkType<ClientBattleActor>(l, 2, out a);
			battleSceneUIController.OnActorAttachImmune(a);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601BF60 RID: 114528 RVA: 0x008945FC File Offset: 0x008927FC
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int OnActorPassiveSkill(IntPtr l)
	{
		int result;
		try
		{
			BattleSceneUIController battleSceneUIController = (BattleSceneUIController)LuaObject.checkSelf(l);
			ClientBattleActor a;
			LuaObject.checkType<ClientBattleActor>(l, 2, out a);
			BuffState sourceBuffState;
			LuaObject.checkType<BuffState>(l, 3, out sourceBuffState);
			battleSceneUIController.OnActorPassiveSkill(a, sourceBuffState);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601BF61 RID: 114529 RVA: 0x00894660 File Offset: 0x00892860
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int OnActorGuard(IntPtr l)
	{
		int result;
		try
		{
			BattleSceneUIController battleSceneUIController = (BattleSceneUIController)LuaObject.checkSelf(l);
			ClientBattleActor a;
			LuaObject.checkType<ClientBattleActor>(l, 2, out a);
			ClientBattleActor target;
			LuaObject.checkType<ClientBattleActor>(l, 3, out target);
			battleSceneUIController.OnActorGuard(a, target);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601BF62 RID: 114530 RVA: 0x008946C4 File Offset: 0x008928C4
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int OnActorCombatDamage(IntPtr l)
	{
		int result;
		try
		{
			BattleSceneUIController battleSceneUIController = (BattleSceneUIController)LuaObject.checkSelf(l);
			ClientBattleActor a;
			LuaObject.checkType<ClientBattleActor>(l, 2, out a);
			int heroDamage;
			LuaObject.checkType(l, 3, out heroDamage);
			int soldierDamage;
			LuaObject.checkType(l, 4, out soldierDamage);
			battleSceneUIController.OnActorCombatDamage(a, heroDamage, soldierDamage);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601BF63 RID: 114531 RVA: 0x00894738 File Offset: 0x00892938
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int SetActiveActor(IntPtr l)
	{
		int result;
		try
		{
			BattleSceneUIController battleSceneUIController = (BattleSceneUIController)LuaObject.checkSelf(l);
			ClientBattleActor activeActor;
			LuaObject.checkType<ClientBattleActor>(l, 2, out activeActor);
			battleSceneUIController.SetActiveActor(activeActor);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601BF64 RID: 114532 RVA: 0x00894790 File Offset: 0x00892990
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int ShowSelectionMark(IntPtr l)
	{
		int result;
		try
		{
			BattleSceneUIController battleSceneUIController = (BattleSceneUIController)LuaObject.checkSelf(l);
			GridPosition p;
			LuaObject.checkValueType<GridPosition>(l, 2, out p);
			battleSceneUIController.ShowSelectionMark(p);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601BF65 RID: 114533 RVA: 0x008947E8 File Offset: 0x008929E8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int HideSelectionMark(IntPtr l)
	{
		int result;
		try
		{
			BattleSceneUIController battleSceneUIController = (BattleSceneUIController)LuaObject.checkSelf(l);
			battleSceneUIController.HideSelectionMark();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601BF66 RID: 114534 RVA: 0x00894834 File Offset: 0x00892A34
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int ShowTargetIcons(IntPtr l)
	{
		int result;
		try
		{
			BattleSceneUIController battleSceneUIController = (BattleSceneUIController)LuaObject.checkSelf(l);
			List<GridPosition> positions;
			LuaObject.checkType<List<GridPosition>>(l, 2, out positions);
			List<int> armyRelationValues;
			LuaObject.checkType<List<int>>(l, 3, out armyRelationValues);
			ConfigDataSkillInfo skillInfo;
			LuaObject.checkType<ConfigDataSkillInfo>(l, 4, out skillInfo);
			GridPosition startPos;
			LuaObject.checkValueType<GridPosition>(l, 5, out startPos);
			battleSceneUIController.ShowTargetIcons(positions, armyRelationValues, skillInfo, startPos);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601BF67 RID: 114535 RVA: 0x008948B4 File Offset: 0x00892AB4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int ShowTargetIcon(IntPtr l)
	{
		int result;
		try
		{
			BattleSceneUIController battleSceneUIController = (BattleSceneUIController)LuaObject.checkSelf(l);
			GridPosition pos;
			LuaObject.checkValueType<GridPosition>(l, 2, out pos);
			int armyRelationValue;
			LuaObject.checkType(l, 3, out armyRelationValue);
			ConfigDataSkillInfo skillInfo;
			LuaObject.checkType<ConfigDataSkillInfo>(l, 4, out skillInfo);
			float time;
			LuaObject.checkType(l, 5, out time);
			battleSceneUIController.ShowTargetIcon(pos, armyRelationValue, skillInfo, time);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601BF68 RID: 114536 RVA: 0x00894934 File Offset: 0x00892B34
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int HideTargetIcons(IntPtr l)
	{
		int result;
		try
		{
			BattleSceneUIController battleSceneUIController = (BattleSceneUIController)LuaObject.checkSelf(l);
			battleSceneUIController.HideTargetIcons();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601BF69 RID: 114537 RVA: 0x00894980 File Offset: 0x00892B80
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int ShowCanActionIcons(IntPtr l)
	{
		int result;
		try
		{
			BattleSceneUIController battleSceneUIController = (BattleSceneUIController)LuaObject.checkSelf(l);
			List<GridPosition> positions;
			LuaObject.checkType<List<GridPosition>>(l, 2, out positions);
			battleSceneUIController.ShowCanActionIcons(positions);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601BF6A RID: 114538 RVA: 0x008949D8 File Offset: 0x00892BD8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int HideCanActionIcons(IntPtr l)
	{
		int result;
		try
		{
			BattleSceneUIController battleSceneUIController = (BattleSceneUIController)LuaObject.checkSelf(l);
			battleSceneUIController.HideCanActionIcons();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601BF6B RID: 114539 RVA: 0x00894A24 File Offset: 0x00892C24
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int OnPointerDown(IntPtr l)
	{
		int result;
		try
		{
			BattleSceneUIController battleSceneUIController = (BattleSceneUIController)LuaObject.checkSelf(l);
			PointerEventData eventData;
			LuaObject.checkType<PointerEventData>(l, 2, out eventData);
			battleSceneUIController.OnPointerDown(eventData);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601BF6C RID: 114540 RVA: 0x00894A7C File Offset: 0x00892C7C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int OnPointerUp(IntPtr l)
	{
		int result;
		try
		{
			BattleSceneUIController battleSceneUIController = (BattleSceneUIController)LuaObject.checkSelf(l);
			PointerEventData eventData;
			LuaObject.checkType<PointerEventData>(l, 2, out eventData);
			battleSceneUIController.OnPointerUp(eventData);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601BF6D RID: 114541 RVA: 0x00894AD4 File Offset: 0x00892CD4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int OnPointerClick(IntPtr l)
	{
		int result;
		try
		{
			BattleSceneUIController battleSceneUIController = (BattleSceneUIController)LuaObject.checkSelf(l);
			PointerEventData eventData;
			LuaObject.checkType<PointerEventData>(l, 2, out eventData);
			battleSceneUIController.OnPointerClick(eventData);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601BF6E RID: 114542 RVA: 0x00894B2C File Offset: 0x00892D2C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int OnBeginDrag(IntPtr l)
	{
		int result;
		try
		{
			BattleSceneUIController battleSceneUIController = (BattleSceneUIController)LuaObject.checkSelf(l);
			PointerEventData eventData;
			LuaObject.checkType<PointerEventData>(l, 2, out eventData);
			battleSceneUIController.OnBeginDrag(eventData);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601BF6F RID: 114543 RVA: 0x00894B84 File Offset: 0x00892D84
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int OnEndDrag(IntPtr l)
	{
		int result;
		try
		{
			BattleSceneUIController battleSceneUIController = (BattleSceneUIController)LuaObject.checkSelf(l);
			PointerEventData eventData;
			LuaObject.checkType<PointerEventData>(l, 2, out eventData);
			battleSceneUIController.OnEndDrag(eventData);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601BF70 RID: 114544 RVA: 0x00894BDC File Offset: 0x00892DDC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int OnDrag(IntPtr l)
	{
		int result;
		try
		{
			BattleSceneUIController battleSceneUIController = (BattleSceneUIController)LuaObject.checkSelf(l);
			PointerEventData eventData;
			LuaObject.checkType<PointerEventData>(l, 2, out eventData);
			battleSceneUIController.OnDrag(eventData);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601BF71 RID: 114545 RVA: 0x00894C34 File Offset: 0x00892E34
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int OnBindFiledsCompleted(IntPtr l)
	{
		int result;
		try
		{
			BattleSceneUIController battleSceneUIController = (BattleSceneUIController)LuaObject.checkSelf(l);
			battleSceneUIController.m_luaExportHelper.OnBindFiledsCompleted();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601BF72 RID: 114546 RVA: 0x00894C88 File Offset: 0x00892E88
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int ShowDamageNumbers(IntPtr l)
	{
		int result;
		try
		{
			BattleSceneUIController battleSceneUIController = (BattleSceneUIController)LuaObject.checkSelf(l);
			ClientBattleActor a;
			LuaObject.checkType<ClientBattleActor>(l, 2, out a);
			int heroHpModify;
			LuaObject.checkType(l, 3, out heroHpModify);
			int soldierHpModify;
			LuaObject.checkType(l, 4, out soldierHpModify);
			DamageNumberType damageNumberType;
			LuaObject.checkEnum<DamageNumberType>(l, 5, out damageNumberType);
			battleSceneUIController.m_luaExportHelper.ShowDamageNumbers(a, heroHpModify, soldierHpModify, damageNumberType);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601BF73 RID: 114547 RVA: 0x00894D0C File Offset: 0x00892F0C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int ShowDamangeNumber(IntPtr l)
	{
		int result;
		try
		{
			BattleSceneUIController battleSceneUIController = (BattleSceneUIController)LuaObject.checkSelf(l);
			ClientBattleActor a;
			LuaObject.checkType<ClientBattleActor>(l, 2, out a);
			int hpModify;
			LuaObject.checkType(l, 3, out hpModify);
			DamageNumberType damageNumberType;
			LuaObject.checkEnum<DamageNumberType>(l, 4, out damageNumberType);
			bool isHero;
			LuaObject.checkType(l, 5, out isHero);
			battleSceneUIController.m_luaExportHelper.ShowDamangeNumber(a, hpModify, damageNumberType, isHero);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601BF74 RID: 114548 RVA: 0x00894D90 File Offset: 0x00892F90
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int Update(IntPtr l)
	{
		int result;
		try
		{
			BattleSceneUIController battleSceneUIController = (BattleSceneUIController)LuaObject.checkSelf(l);
			battleSceneUIController.m_luaExportHelper.Update();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601BF75 RID: 114549 RVA: 0x00894DE4 File Offset: 0x00892FE4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int Update3DTouch(IntPtr l)
	{
		int result;
		try
		{
			BattleSceneUIController battleSceneUIController = (BattleSceneUIController)LuaObject.checkSelf(l);
			battleSceneUIController.m_luaExportHelper.Update3DTouch();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601BF76 RID: 114550 RVA: 0x00894E38 File Offset: 0x00893038
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int GetActorGraphicCenterPosition(IntPtr l)
	{
		int result;
		try
		{
			BattleSceneUIController battleSceneUIController = (BattleSceneUIController)LuaObject.checkSelf(l);
			ClientBattleActor a;
			LuaObject.checkType<ClientBattleActor>(l, 2, out a);
			Vector3 actorGraphicCenterPosition = battleSceneUIController.m_luaExportHelper.GetActorGraphicCenterPosition(a);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, actorGraphicCenterPosition);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601BF77 RID: 114551 RVA: 0x00894EA0 File Offset: 0x008930A0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int AllocateTargetIcon(IntPtr l)
	{
		int result;
		try
		{
			BattleSceneUIController battleSceneUIController = (BattleSceneUIController)LuaObject.checkSelf(l);
			ConfigDataSkillInfo skillInfo;
			LuaObject.checkType<ConfigDataSkillInfo>(l, 2, out skillInfo);
			int armyRelationValue;
			LuaObject.checkType(l, 3, out armyRelationValue);
			GameObject o = battleSceneUIController.m_luaExportHelper.AllocateTargetIcon(skillInfo, armyRelationValue);
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

	// Token: 0x0601BF78 RID: 114552 RVA: 0x00894F14 File Offset: 0x00893114
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int GridPositionToMapPosition(IntPtr l)
	{
		int result;
		try
		{
			BattleSceneUIController battleSceneUIController = (BattleSceneUIController)LuaObject.checkSelf(l);
			GridPosition p;
			LuaObject.checkValueType<GridPosition>(l, 2, out p);
			float z;
			LuaObject.checkType(l, 3, out z);
			Vector3 o = battleSceneUIController.m_luaExportHelper.GridPositionToMapPosition(p, z);
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

	// Token: 0x0601BF79 RID: 114553 RVA: 0x00894F88 File Offset: 0x00893188
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_Initlize(IntPtr l)
	{
		int result;
		try
		{
			BattleSceneUIController battleSceneUIController = (BattleSceneUIController)LuaObject.checkSelf(l);
			string ctrlName;
			LuaObject.checkType(l, 2, out ctrlName);
			bool bindNow;
			LuaObject.checkType(l, 3, out bindNow);
			battleSceneUIController.m_luaExportHelper.__callBase_Initlize(ctrlName, bindNow);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601BF7A RID: 114554 RVA: 0x00894FF4 File Offset: 0x008931F4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_BindFields(IntPtr l)
	{
		int result;
		try
		{
			BattleSceneUIController battleSceneUIController = (BattleSceneUIController)LuaObject.checkSelf(l);
			battleSceneUIController.m_luaExportHelper.__callBase_BindFields();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601BF7B RID: 114555 RVA: 0x00895048 File Offset: 0x00893248
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_OnBindFiledsCompleted(IntPtr l)
	{
		int result;
		try
		{
			BattleSceneUIController battleSceneUIController = (BattleSceneUIController)LuaObject.checkSelf(l);
			battleSceneUIController.m_luaExportHelper.__callBase_OnBindFiledsCompleted();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601BF7C RID: 114556 RVA: 0x0089509C File Offset: 0x0089329C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_BindFieldImpl(IntPtr l)
	{
		int result;
		try
		{
			BattleSceneUIController battleSceneUIController = (BattleSceneUIController)LuaObject.checkSelf(l);
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
			UnityEngine.Object o = battleSceneUIController.m_luaExportHelper.__callBase_BindFieldImpl(fieldType, path, initState, fieldName, ctrlName, optional);
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

	// Token: 0x0601BF7D RID: 114557 RVA: 0x00895144 File Offset: 0x00893344
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int __callBase_Clear(IntPtr l)
	{
		int result;
		try
		{
			BattleSceneUIController battleSceneUIController = (BattleSceneUIController)LuaObject.checkSelf(l);
			battleSceneUIController.m_luaExportHelper.__callBase_Clear();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601BF7E RID: 114558 RVA: 0x00895198 File Offset: 0x00893398
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int __callBase_OnButtonClick(IntPtr l)
	{
		int result;
		try
		{
			BattleSceneUIController battleSceneUIController = (BattleSceneUIController)LuaObject.checkSelf(l);
			Button button;
			LuaObject.checkType<Button>(l, 2, out button);
			string fieldName;
			LuaObject.checkType(l, 3, out fieldName);
			battleSceneUIController.m_luaExportHelper.__callBase_OnButtonClick(button, fieldName);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601BF7F RID: 114559 RVA: 0x00895204 File Offset: 0x00893404
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
				BattleSceneUIController battleSceneUIController = (BattleSceneUIController)LuaObject.checkSelf(l);
				string[] fieldNames;
				LuaObject.checkArray<string>(l, 2, out fieldNames);
				Action<UIControllerBase> action;
				LuaObject.checkDelegate<Action<UIControllerBase>>(l, 3, out action);
				battleSceneUIController.m_luaExportHelper.__callBase_SetButtonClickListener(fieldNames, action);
				LuaObject.pushValue(l, true);
				result = 1;
			}
			else if (LuaObject.matchType(l, total, 2, typeof(string), typeof(Action<UIControllerBase>)))
			{
				BattleSceneUIController battleSceneUIController2 = (BattleSceneUIController)LuaObject.checkSelf(l);
				string fieldName;
				LuaObject.checkType(l, 2, out fieldName);
				Action<UIControllerBase> action2;
				LuaObject.checkDelegate<Action<UIControllerBase>>(l, 3, out action2);
				battleSceneUIController2.m_luaExportHelper.__callBase_SetButtonClickListener(fieldName, action2);
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

	// Token: 0x0601BF80 RID: 114560 RVA: 0x00895314 File Offset: 0x00893514
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_SetButtonDoubleClickListener(IntPtr l)
	{
		int result;
		try
		{
			BattleSceneUIController battleSceneUIController = (BattleSceneUIController)LuaObject.checkSelf(l);
			string fieldName;
			LuaObject.checkType(l, 2, out fieldName);
			Action<UIControllerBase> action;
			LuaObject.checkDelegate<Action<UIControllerBase>>(l, 3, out action);
			battleSceneUIController.m_luaExportHelper.__callBase_SetButtonDoubleClickListener(fieldName, action);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601BF81 RID: 114561 RVA: 0x00895380 File Offset: 0x00893580
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_SetButtonLongPressStartListener(IntPtr l)
	{
		int result;
		try
		{
			BattleSceneUIController battleSceneUIController = (BattleSceneUIController)LuaObject.checkSelf(l);
			string fieldName;
			LuaObject.checkType(l, 2, out fieldName);
			Action<UIControllerBase> action;
			LuaObject.checkDelegate<Action<UIControllerBase>>(l, 3, out action);
			battleSceneUIController.m_luaExportHelper.__callBase_SetButtonLongPressStartListener(fieldName, action);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601BF82 RID: 114562 RVA: 0x008953EC File Offset: 0x008935EC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_SetButtonLongPressingListener(IntPtr l)
	{
		int result;
		try
		{
			BattleSceneUIController battleSceneUIController = (BattleSceneUIController)LuaObject.checkSelf(l);
			string fieldName;
			LuaObject.checkType(l, 2, out fieldName);
			Action<UIControllerBase> action;
			LuaObject.checkDelegate<Action<UIControllerBase>>(l, 3, out action);
			battleSceneUIController.m_luaExportHelper.__callBase_SetButtonLongPressingListener(fieldName, action);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601BF83 RID: 114563 RVA: 0x00895458 File Offset: 0x00893658
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int __callBase_SetButtonLongPressEndListener(IntPtr l)
	{
		int result;
		try
		{
			BattleSceneUIController battleSceneUIController = (BattleSceneUIController)LuaObject.checkSelf(l);
			string fieldName;
			LuaObject.checkType(l, 2, out fieldName);
			Action<UIControllerBase> action;
			LuaObject.checkDelegate<Action<UIControllerBase>>(l, 3, out action);
			battleSceneUIController.m_luaExportHelper.__callBase_SetButtonLongPressEndListener(fieldName, action);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601BF84 RID: 114564 RVA: 0x008954C4 File Offset: 0x008936C4
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
				BattleSceneUIController battleSceneUIController = (BattleSceneUIController)LuaObject.checkSelf(l);
				string[] fieldNames;
				LuaObject.checkArray<string>(l, 2, out fieldNames);
				Action<UIControllerBase, bool> action;
				LuaObject.checkDelegate<Action<UIControllerBase, bool>>(l, 3, out action);
				battleSceneUIController.m_luaExportHelper.__callBase_SetToggleValueChangedListener(fieldNames, action);
				LuaObject.pushValue(l, true);
				result = 1;
			}
			else if (LuaObject.matchType(l, total, 2, typeof(string), typeof(Action<UIControllerBase, bool>)))
			{
				BattleSceneUIController battleSceneUIController2 = (BattleSceneUIController)LuaObject.checkSelf(l);
				string fieldName;
				LuaObject.checkType(l, 2, out fieldName);
				Action<UIControllerBase, bool> action2;
				LuaObject.checkDelegate<Action<UIControllerBase, bool>>(l, 3, out action2);
				battleSceneUIController2.m_luaExportHelper.__callBase_SetToggleValueChangedListener(fieldName, action2);
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

	// Token: 0x0601BF85 RID: 114565 RVA: 0x008955D4 File Offset: 0x008937D4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_ToString(IntPtr l)
	{
		int result;
		try
		{
			BattleSceneUIController battleSceneUIController = (BattleSceneUIController)LuaObject.checkSelf(l);
			string s = battleSceneUIController.m_luaExportHelper.__callBase_ToString();
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

	// Token: 0x0601BF86 RID: 114566 RVA: 0x00895630 File Offset: 0x00893830
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callDele_EventOnPointerDown(IntPtr l)
	{
		int result;
		try
		{
			BattleSceneUIController battleSceneUIController = (BattleSceneUIController)LuaObject.checkSelf(l);
			PointerEventData obj;
			LuaObject.checkType<PointerEventData>(l, 2, out obj);
			battleSceneUIController.m_luaExportHelper.__callDele_EventOnPointerDown(obj);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601BF87 RID: 114567 RVA: 0x0089568C File Offset: 0x0089388C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __clearDele_EventOnPointerDown(IntPtr l)
	{
		int result;
		try
		{
			BattleSceneUIController battleSceneUIController = (BattleSceneUIController)LuaObject.checkSelf(l);
			PointerEventData obj;
			LuaObject.checkType<PointerEventData>(l, 2, out obj);
			battleSceneUIController.m_luaExportHelper.__clearDele_EventOnPointerDown(obj);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601BF88 RID: 114568 RVA: 0x008956E8 File Offset: 0x008938E8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callDele_EventOnPointerUp(IntPtr l)
	{
		int result;
		try
		{
			BattleSceneUIController battleSceneUIController = (BattleSceneUIController)LuaObject.checkSelf(l);
			PointerEventData obj;
			LuaObject.checkType<PointerEventData>(l, 2, out obj);
			battleSceneUIController.m_luaExportHelper.__callDele_EventOnPointerUp(obj);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601BF89 RID: 114569 RVA: 0x00895744 File Offset: 0x00893944
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __clearDele_EventOnPointerUp(IntPtr l)
	{
		int result;
		try
		{
			BattleSceneUIController battleSceneUIController = (BattleSceneUIController)LuaObject.checkSelf(l);
			PointerEventData obj;
			LuaObject.checkType<PointerEventData>(l, 2, out obj);
			battleSceneUIController.m_luaExportHelper.__clearDele_EventOnPointerUp(obj);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601BF8A RID: 114570 RVA: 0x008957A0 File Offset: 0x008939A0
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int __callDele_EventOnPointerClick(IntPtr l)
	{
		int result;
		try
		{
			BattleSceneUIController battleSceneUIController = (BattleSceneUIController)LuaObject.checkSelf(l);
			PointerEventData obj;
			LuaObject.checkType<PointerEventData>(l, 2, out obj);
			battleSceneUIController.m_luaExportHelper.__callDele_EventOnPointerClick(obj);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601BF8B RID: 114571 RVA: 0x008957FC File Offset: 0x008939FC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __clearDele_EventOnPointerClick(IntPtr l)
	{
		int result;
		try
		{
			BattleSceneUIController battleSceneUIController = (BattleSceneUIController)LuaObject.checkSelf(l);
			PointerEventData obj;
			LuaObject.checkType<PointerEventData>(l, 2, out obj);
			battleSceneUIController.m_luaExportHelper.__clearDele_EventOnPointerClick(obj);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601BF8C RID: 114572 RVA: 0x00895858 File Offset: 0x00893A58
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callDele_EventOnBeginDrag(IntPtr l)
	{
		int result;
		try
		{
			BattleSceneUIController battleSceneUIController = (BattleSceneUIController)LuaObject.checkSelf(l);
			PointerEventData obj;
			LuaObject.checkType<PointerEventData>(l, 2, out obj);
			battleSceneUIController.m_luaExportHelper.__callDele_EventOnBeginDrag(obj);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601BF8D RID: 114573 RVA: 0x008958B4 File Offset: 0x00893AB4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __clearDele_EventOnBeginDrag(IntPtr l)
	{
		int result;
		try
		{
			BattleSceneUIController battleSceneUIController = (BattleSceneUIController)LuaObject.checkSelf(l);
			PointerEventData obj;
			LuaObject.checkType<PointerEventData>(l, 2, out obj);
			battleSceneUIController.m_luaExportHelper.__clearDele_EventOnBeginDrag(obj);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601BF8E RID: 114574 RVA: 0x00895910 File Offset: 0x00893B10
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callDele_EventOnEndDrag(IntPtr l)
	{
		int result;
		try
		{
			BattleSceneUIController battleSceneUIController = (BattleSceneUIController)LuaObject.checkSelf(l);
			PointerEventData obj;
			LuaObject.checkType<PointerEventData>(l, 2, out obj);
			battleSceneUIController.m_luaExportHelper.__callDele_EventOnEndDrag(obj);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601BF8F RID: 114575 RVA: 0x0089596C File Offset: 0x00893B6C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __clearDele_EventOnEndDrag(IntPtr l)
	{
		int result;
		try
		{
			BattleSceneUIController battleSceneUIController = (BattleSceneUIController)LuaObject.checkSelf(l);
			PointerEventData obj;
			LuaObject.checkType<PointerEventData>(l, 2, out obj);
			battleSceneUIController.m_luaExportHelper.__clearDele_EventOnEndDrag(obj);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601BF90 RID: 114576 RVA: 0x008959C8 File Offset: 0x00893BC8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callDele_EventOnDrag(IntPtr l)
	{
		int result;
		try
		{
			BattleSceneUIController battleSceneUIController = (BattleSceneUIController)LuaObject.checkSelf(l);
			PointerEventData obj;
			LuaObject.checkType<PointerEventData>(l, 2, out obj);
			battleSceneUIController.m_luaExportHelper.__callDele_EventOnDrag(obj);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601BF91 RID: 114577 RVA: 0x00895A24 File Offset: 0x00893C24
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __clearDele_EventOnDrag(IntPtr l)
	{
		int result;
		try
		{
			BattleSceneUIController battleSceneUIController = (BattleSceneUIController)LuaObject.checkSelf(l);
			PointerEventData obj;
			LuaObject.checkType<PointerEventData>(l, 2, out obj);
			battleSceneUIController.m_luaExportHelper.__clearDele_EventOnDrag(obj);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601BF92 RID: 114578 RVA: 0x00895A80 File Offset: 0x00893C80
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callDele_EventOn3DTouch(IntPtr l)
	{
		int result;
		try
		{
			BattleSceneUIController battleSceneUIController = (BattleSceneUIController)LuaObject.checkSelf(l);
			Vector2 obj;
			LuaObject.checkType(l, 2, out obj);
			battleSceneUIController.m_luaExportHelper.__callDele_EventOn3DTouch(obj);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601BF93 RID: 114579 RVA: 0x00895ADC File Offset: 0x00893CDC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __clearDele_EventOn3DTouch(IntPtr l)
	{
		int result;
		try
		{
			BattleSceneUIController battleSceneUIController = (BattleSceneUIController)LuaObject.checkSelf(l);
			Vector2 obj;
			LuaObject.checkType(l, 2, out obj);
			battleSceneUIController.m_luaExportHelper.__clearDele_EventOn3DTouch(obj);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601BF94 RID: 114580 RVA: 0x00895B38 File Offset: 0x00893D38
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_EventOnPointerDown(IntPtr l)
	{
		int result;
		try
		{
			BattleSceneUIController battleSceneUIController = (BattleSceneUIController)LuaObject.checkSelf(l);
			Action<PointerEventData> value;
			int num = LuaObject.checkDelegate<Action<PointerEventData>>(l, 2, out value);
			if (num != 0)
			{
				if (num == 1)
				{
					battleSceneUIController.EventOnPointerDown += value;
				}
				else if (num == 2)
				{
					battleSceneUIController.EventOnPointerDown -= value;
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

	// Token: 0x0601BF95 RID: 114581 RVA: 0x00895BB8 File Offset: 0x00893DB8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_EventOnPointerUp(IntPtr l)
	{
		int result;
		try
		{
			BattleSceneUIController battleSceneUIController = (BattleSceneUIController)LuaObject.checkSelf(l);
			Action<PointerEventData> value;
			int num = LuaObject.checkDelegate<Action<PointerEventData>>(l, 2, out value);
			if (num != 0)
			{
				if (num == 1)
				{
					battleSceneUIController.EventOnPointerUp += value;
				}
				else if (num == 2)
				{
					battleSceneUIController.EventOnPointerUp -= value;
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

	// Token: 0x0601BF96 RID: 114582 RVA: 0x00895C38 File Offset: 0x00893E38
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_EventOnPointerClick(IntPtr l)
	{
		int result;
		try
		{
			BattleSceneUIController battleSceneUIController = (BattleSceneUIController)LuaObject.checkSelf(l);
			Action<PointerEventData> value;
			int num = LuaObject.checkDelegate<Action<PointerEventData>>(l, 2, out value);
			if (num != 0)
			{
				if (num == 1)
				{
					battleSceneUIController.EventOnPointerClick += value;
				}
				else if (num == 2)
				{
					battleSceneUIController.EventOnPointerClick -= value;
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

	// Token: 0x0601BF97 RID: 114583 RVA: 0x00895CB8 File Offset: 0x00893EB8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_EventOnBeginDrag(IntPtr l)
	{
		int result;
		try
		{
			BattleSceneUIController battleSceneUIController = (BattleSceneUIController)LuaObject.checkSelf(l);
			Action<PointerEventData> value;
			int num = LuaObject.checkDelegate<Action<PointerEventData>>(l, 2, out value);
			if (num != 0)
			{
				if (num == 1)
				{
					battleSceneUIController.EventOnBeginDrag += value;
				}
				else if (num == 2)
				{
					battleSceneUIController.EventOnBeginDrag -= value;
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

	// Token: 0x0601BF98 RID: 114584 RVA: 0x00895D38 File Offset: 0x00893F38
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_EventOnEndDrag(IntPtr l)
	{
		int result;
		try
		{
			BattleSceneUIController battleSceneUIController = (BattleSceneUIController)LuaObject.checkSelf(l);
			Action<PointerEventData> value;
			int num = LuaObject.checkDelegate<Action<PointerEventData>>(l, 2, out value);
			if (num != 0)
			{
				if (num == 1)
				{
					battleSceneUIController.EventOnEndDrag += value;
				}
				else if (num == 2)
				{
					battleSceneUIController.EventOnEndDrag -= value;
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

	// Token: 0x0601BF99 RID: 114585 RVA: 0x00895DB8 File Offset: 0x00893FB8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_EventOnDrag(IntPtr l)
	{
		int result;
		try
		{
			BattleSceneUIController battleSceneUIController = (BattleSceneUIController)LuaObject.checkSelf(l);
			Action<PointerEventData> value;
			int num = LuaObject.checkDelegate<Action<PointerEventData>>(l, 2, out value);
			if (num != 0)
			{
				if (num == 1)
				{
					battleSceneUIController.EventOnDrag += value;
				}
				else if (num == 2)
				{
					battleSceneUIController.EventOnDrag -= value;
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

	// Token: 0x0601BF9A RID: 114586 RVA: 0x00895E38 File Offset: 0x00894038
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_EventOn3DTouch(IntPtr l)
	{
		int result;
		try
		{
			BattleSceneUIController battleSceneUIController = (BattleSceneUIController)LuaObject.checkSelf(l);
			Action<Vector2> value;
			int num = LuaObject.checkDelegate<Action<Vector2>>(l, 2, out value);
			if (num != 0)
			{
				if (num == 1)
				{
					battleSceneUIController.EventOn3DTouch += value;
				}
				else if (num == 2)
				{
					battleSceneUIController.EventOn3DTouch -= value;
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

	// Token: 0x0601BF9B RID: 114587 RVA: 0x00895EB8 File Offset: 0x008940B8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_actionMarkGameObject(IntPtr l)
	{
		int result;
		try
		{
			BattleSceneUIController battleSceneUIController = (BattleSceneUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, battleSceneUIController.m_luaExportHelper.m_actionMarkGameObject);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601BF9C RID: 114588 RVA: 0x00895F10 File Offset: 0x00894110
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_actionMarkGameObject(IntPtr l)
	{
		int result;
		try
		{
			BattleSceneUIController battleSceneUIController = (BattleSceneUIController)LuaObject.checkSelf(l);
			GameObject actionMarkGameObject;
			LuaObject.checkType<GameObject>(l, 2, out actionMarkGameObject);
			battleSceneUIController.m_luaExportHelper.m_actionMarkGameObject = actionMarkGameObject;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601BF9D RID: 114589 RVA: 0x00895F6C File Offset: 0x0089416C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_actionMark2GameObject(IntPtr l)
	{
		int result;
		try
		{
			BattleSceneUIController battleSceneUIController = (BattleSceneUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, battleSceneUIController.m_luaExportHelper.m_actionMark2GameObject);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601BF9E RID: 114590 RVA: 0x00895FC4 File Offset: 0x008941C4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_actionMark2GameObject(IntPtr l)
	{
		int result;
		try
		{
			BattleSceneUIController battleSceneUIController = (BattleSceneUIController)LuaObject.checkSelf(l);
			GameObject actionMark2GameObject;
			LuaObject.checkType<GameObject>(l, 2, out actionMark2GameObject);
			battleSceneUIController.m_luaExportHelper.m_actionMark2GameObject = actionMark2GameObject;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601BF9F RID: 114591 RVA: 0x00896020 File Offset: 0x00894220
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_winConditionUIStateController(IntPtr l)
	{
		int result;
		try
		{
			BattleSceneUIController battleSceneUIController = (BattleSceneUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, battleSceneUIController.m_luaExportHelper.m_winConditionUIStateController);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601BFA0 RID: 114592 RVA: 0x00896078 File Offset: 0x00894278
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_winConditionUIStateController(IntPtr l)
	{
		int result;
		try
		{
			BattleSceneUIController battleSceneUIController = (BattleSceneUIController)LuaObject.checkSelf(l);
			CommonUIStateController winConditionUIStateController;
			LuaObject.checkType<CommonUIStateController>(l, 2, out winConditionUIStateController);
			battleSceneUIController.m_luaExportHelper.m_winConditionUIStateController = winConditionUIStateController;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601BFA1 RID: 114593 RVA: 0x008960D4 File Offset: 0x008942D4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_winConditionKillGameObject(IntPtr l)
	{
		int result;
		try
		{
			BattleSceneUIController battleSceneUIController = (BattleSceneUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, battleSceneUIController.m_luaExportHelper.m_winConditionKillGameObject);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601BFA2 RID: 114594 RVA: 0x0089612C File Offset: 0x0089432C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_winConditionKillGameObject(IntPtr l)
	{
		int result;
		try
		{
			BattleSceneUIController battleSceneUIController = (BattleSceneUIController)LuaObject.checkSelf(l);
			GameObject winConditionKillGameObject;
			LuaObject.checkType<GameObject>(l, 2, out winConditionKillGameObject);
			battleSceneUIController.m_luaExportHelper.m_winConditionKillGameObject = winConditionKillGameObject;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601BFA3 RID: 114595 RVA: 0x00896188 File Offset: 0x00894388
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_winConditionProtectGameObject(IntPtr l)
	{
		int result;
		try
		{
			BattleSceneUIController battleSceneUIController = (BattleSceneUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, battleSceneUIController.m_luaExportHelper.m_winConditionProtectGameObject);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601BFA4 RID: 114596 RVA: 0x008961E0 File Offset: 0x008943E0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_winConditionProtectGameObject(IntPtr l)
	{
		int result;
		try
		{
			BattleSceneUIController battleSceneUIController = (BattleSceneUIController)LuaObject.checkSelf(l);
			GameObject winConditionProtectGameObject;
			LuaObject.checkType<GameObject>(l, 2, out winConditionProtectGameObject);
			battleSceneUIController.m_luaExportHelper.m_winConditionProtectGameObject = winConditionProtectGameObject;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601BFA5 RID: 114597 RVA: 0x0089623C File Offset: 0x0089443C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_selectionMarkGameObject(IntPtr l)
	{
		int result;
		try
		{
			BattleSceneUIController battleSceneUIController = (BattleSceneUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, battleSceneUIController.m_luaExportHelper.m_selectionMarkGameObject);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601BFA6 RID: 114598 RVA: 0x00896294 File Offset: 0x00894494
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_selectionMarkGameObject(IntPtr l)
	{
		int result;
		try
		{
			BattleSceneUIController battleSceneUIController = (BattleSceneUIController)LuaObject.checkSelf(l);
			GameObject selectionMarkGameObject;
			LuaObject.checkType<GameObject>(l, 2, out selectionMarkGameObject);
			battleSceneUIController.m_luaExportHelper.m_selectionMarkGameObject = selectionMarkGameObject;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601BFA7 RID: 114599 RVA: 0x008962F0 File Offset: 0x008944F0
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_m_passiveSkillUIStateController(IntPtr l)
	{
		int result;
		try
		{
			BattleSceneUIController battleSceneUIController = (BattleSceneUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, battleSceneUIController.m_luaExportHelper.m_passiveSkillUIStateController);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601BFA8 RID: 114600 RVA: 0x00896348 File Offset: 0x00894548
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_passiveSkillUIStateController(IntPtr l)
	{
		int result;
		try
		{
			BattleSceneUIController battleSceneUIController = (BattleSceneUIController)LuaObject.checkSelf(l);
			CommonUIStateController passiveSkillUIStateController;
			LuaObject.checkType<CommonUIStateController>(l, 2, out passiveSkillUIStateController);
			battleSceneUIController.m_luaExportHelper.m_passiveSkillUIStateController = passiveSkillUIStateController;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601BFA9 RID: 114601 RVA: 0x008963A4 File Offset: 0x008945A4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_passiveSkillIconImage(IntPtr l)
	{
		int result;
		try
		{
			BattleSceneUIController battleSceneUIController = (BattleSceneUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, battleSceneUIController.m_luaExportHelper.m_passiveSkillIconImage);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601BFAA RID: 114602 RVA: 0x008963FC File Offset: 0x008945FC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_passiveSkillIconImage(IntPtr l)
	{
		int result;
		try
		{
			BattleSceneUIController battleSceneUIController = (BattleSceneUIController)LuaObject.checkSelf(l);
			Image passiveSkillIconImage;
			LuaObject.checkType<Image>(l, 2, out passiveSkillIconImage);
			battleSceneUIController.m_luaExportHelper.m_passiveSkillIconImage = passiveSkillIconImage;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601BFAB RID: 114603 RVA: 0x00896458 File Offset: 0x00894658
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_passiveSkillTalentIconImage(IntPtr l)
	{
		int result;
		try
		{
			BattleSceneUIController battleSceneUIController = (BattleSceneUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, battleSceneUIController.m_luaExportHelper.m_passiveSkillTalentIconImage);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601BFAC RID: 114604 RVA: 0x008964B0 File Offset: 0x008946B0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_passiveSkillTalentIconImage(IntPtr l)
	{
		int result;
		try
		{
			BattleSceneUIController battleSceneUIController = (BattleSceneUIController)LuaObject.checkSelf(l);
			Image passiveSkillTalentIconImage;
			LuaObject.checkType<Image>(l, 2, out passiveSkillTalentIconImage);
			battleSceneUIController.m_luaExportHelper.m_passiveSkillTalentIconImage = passiveSkillTalentIconImage;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601BFAD RID: 114605 RVA: 0x0089650C File Offset: 0x0089470C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_passiveSkillNameText(IntPtr l)
	{
		int result;
		try
		{
			BattleSceneUIController battleSceneUIController = (BattleSceneUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, battleSceneUIController.m_luaExportHelper.m_passiveSkillNameText);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601BFAE RID: 114606 RVA: 0x00896564 File Offset: 0x00894764
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_passiveSkillNameText(IntPtr l)
	{
		int result;
		try
		{
			BattleSceneUIController battleSceneUIController = (BattleSceneUIController)LuaObject.checkSelf(l);
			Text passiveSkillNameText;
			LuaObject.checkType<Text>(l, 2, out passiveSkillNameText);
			battleSceneUIController.m_luaExportHelper.m_passiveSkillNameText = passiveSkillNameText;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601BFAF RID: 114607 RVA: 0x008965C0 File Offset: 0x008947C0
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_m_guardUIStateController(IntPtr l)
	{
		int result;
		try
		{
			BattleSceneUIController battleSceneUIController = (BattleSceneUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, battleSceneUIController.m_luaExportHelper.m_guardUIStateController);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601BFB0 RID: 114608 RVA: 0x00896618 File Offset: 0x00894818
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_m_guardUIStateController(IntPtr l)
	{
		int result;
		try
		{
			BattleSceneUIController battleSceneUIController = (BattleSceneUIController)LuaObject.checkSelf(l);
			CommonUIStateController guardUIStateController;
			LuaObject.checkType<CommonUIStateController>(l, 2, out guardUIStateController);
			battleSceneUIController.m_luaExportHelper.m_guardUIStateController = guardUIStateController;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601BFB1 RID: 114609 RVA: 0x00896674 File Offset: 0x00894874
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_m_damageNumbersGameObject(IntPtr l)
	{
		int result;
		try
		{
			BattleSceneUIController battleSceneUIController = (BattleSceneUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, battleSceneUIController.m_luaExportHelper.m_damageNumbersGameObject);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601BFB2 RID: 114610 RVA: 0x008966CC File Offset: 0x008948CC
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_m_damageNumbersGameObject(IntPtr l)
	{
		int result;
		try
		{
			BattleSceneUIController battleSceneUIController = (BattleSceneUIController)LuaObject.checkSelf(l);
			GameObject damageNumbersGameObject;
			LuaObject.checkType<GameObject>(l, 2, out damageNumbersGameObject);
			battleSceneUIController.m_luaExportHelper.m_damageNumbersGameObject = damageNumbersGameObject;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601BFB3 RID: 114611 RVA: 0x00896728 File Offset: 0x00894928
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_prefabsGameObject(IntPtr l)
	{
		int result;
		try
		{
			BattleSceneUIController battleSceneUIController = (BattleSceneUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, battleSceneUIController.m_luaExportHelper.m_prefabsGameObject);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601BFB4 RID: 114612 RVA: 0x00896780 File Offset: 0x00894980
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_prefabsGameObject(IntPtr l)
	{
		int result;
		try
		{
			BattleSceneUIController battleSceneUIController = (BattleSceneUIController)LuaObject.checkSelf(l);
			GameObject prefabsGameObject;
			LuaObject.checkType<GameObject>(l, 2, out prefabsGameObject);
			battleSceneUIController.m_luaExportHelper.m_prefabsGameObject = prefabsGameObject;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601BFB5 RID: 114613 RVA: 0x008967DC File Offset: 0x008949DC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_damageNumberPrefab(IntPtr l)
	{
		int result;
		try
		{
			BattleSceneUIController battleSceneUIController = (BattleSceneUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, battleSceneUIController.m_luaExportHelper.m_damageNumberPrefab);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601BFB6 RID: 114614 RVA: 0x00896834 File Offset: 0x00894A34
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_damageNumberPrefab(IntPtr l)
	{
		int result;
		try
		{
			BattleSceneUIController battleSceneUIController = (BattleSceneUIController)LuaObject.checkSelf(l);
			GameObject damageNumberPrefab;
			LuaObject.checkType<GameObject>(l, 2, out damageNumberPrefab);
			battleSceneUIController.m_luaExportHelper.m_damageNumberPrefab = damageNumberPrefab;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601BFB7 RID: 114615 RVA: 0x00896890 File Offset: 0x00894A90
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_damageNumberWeakPrefab(IntPtr l)
	{
		int result;
		try
		{
			BattleSceneUIController battleSceneUIController = (BattleSceneUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, battleSceneUIController.m_luaExportHelper.m_damageNumberWeakPrefab);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601BFB8 RID: 114616 RVA: 0x008968E8 File Offset: 0x00894AE8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_damageNumberWeakPrefab(IntPtr l)
	{
		int result;
		try
		{
			BattleSceneUIController battleSceneUIController = (BattleSceneUIController)LuaObject.checkSelf(l);
			GameObject damageNumberWeakPrefab;
			LuaObject.checkType<GameObject>(l, 2, out damageNumberWeakPrefab);
			battleSceneUIController.m_luaExportHelper.m_damageNumberWeakPrefab = damageNumberWeakPrefab;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601BFB9 RID: 114617 RVA: 0x00896944 File Offset: 0x00894B44
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_damageNumberStrongPrefab(IntPtr l)
	{
		int result;
		try
		{
			BattleSceneUIController battleSceneUIController = (BattleSceneUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, battleSceneUIController.m_luaExportHelper.m_damageNumberStrongPrefab);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601BFBA RID: 114618 RVA: 0x0089699C File Offset: 0x00894B9C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_damageNumberStrongPrefab(IntPtr l)
	{
		int result;
		try
		{
			BattleSceneUIController battleSceneUIController = (BattleSceneUIController)LuaObject.checkSelf(l);
			GameObject damageNumberStrongPrefab;
			LuaObject.checkType<GameObject>(l, 2, out damageNumberStrongPrefab);
			battleSceneUIController.m_luaExportHelper.m_damageNumberStrongPrefab = damageNumberStrongPrefab;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601BFBB RID: 114619 RVA: 0x008969F8 File Offset: 0x00894BF8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_damageNumberCriticalPrefab(IntPtr l)
	{
		int result;
		try
		{
			BattleSceneUIController battleSceneUIController = (BattleSceneUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, battleSceneUIController.m_luaExportHelper.m_damageNumberCriticalPrefab);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601BFBC RID: 114620 RVA: 0x00896A50 File Offset: 0x00894C50
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_damageNumberCriticalPrefab(IntPtr l)
	{
		int result;
		try
		{
			BattleSceneUIController battleSceneUIController = (BattleSceneUIController)LuaObject.checkSelf(l);
			GameObject damageNumberCriticalPrefab;
			LuaObject.checkType<GameObject>(l, 2, out damageNumberCriticalPrefab);
			battleSceneUIController.m_luaExportHelper.m_damageNumberCriticalPrefab = damageNumberCriticalPrefab;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601BFBD RID: 114621 RVA: 0x00896AAC File Offset: 0x00894CAC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_damageNumberSoldierPrefab(IntPtr l)
	{
		int result;
		try
		{
			BattleSceneUIController battleSceneUIController = (BattleSceneUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, battleSceneUIController.m_luaExportHelper.m_damageNumberSoldierPrefab);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601BFBE RID: 114622 RVA: 0x00896B04 File Offset: 0x00894D04
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_damageNumberSoldierPrefab(IntPtr l)
	{
		int result;
		try
		{
			BattleSceneUIController battleSceneUIController = (BattleSceneUIController)LuaObject.checkSelf(l);
			GameObject damageNumberSoldierPrefab;
			LuaObject.checkType<GameObject>(l, 2, out damageNumberSoldierPrefab);
			battleSceneUIController.m_luaExportHelper.m_damageNumberSoldierPrefab = damageNumberSoldierPrefab;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601BFBF RID: 114623 RVA: 0x00896B60 File Offset: 0x00894D60
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_healNumberPrefab(IntPtr l)
	{
		int result;
		try
		{
			BattleSceneUIController battleSceneUIController = (BattleSceneUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, battleSceneUIController.m_luaExportHelper.m_healNumberPrefab);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601BFC0 RID: 114624 RVA: 0x00896BB8 File Offset: 0x00894DB8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_healNumberPrefab(IntPtr l)
	{
		int result;
		try
		{
			BattleSceneUIController battleSceneUIController = (BattleSceneUIController)LuaObject.checkSelf(l);
			GameObject healNumberPrefab;
			LuaObject.checkType<GameObject>(l, 2, out healNumberPrefab);
			battleSceneUIController.m_luaExportHelper.m_healNumberPrefab = healNumberPrefab;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601BFC1 RID: 114625 RVA: 0x00896C14 File Offset: 0x00894E14
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_immunePrefab(IntPtr l)
	{
		int result;
		try
		{
			BattleSceneUIController battleSceneUIController = (BattleSceneUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, battleSceneUIController.m_luaExportHelper.m_immunePrefab);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601BFC2 RID: 114626 RVA: 0x00896C6C File Offset: 0x00894E6C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_immunePrefab(IntPtr l)
	{
		int result;
		try
		{
			BattleSceneUIController battleSceneUIController = (BattleSceneUIController)LuaObject.checkSelf(l);
			GameObject immunePrefab;
			LuaObject.checkType<GameObject>(l, 2, out immunePrefab);
			battleSceneUIController.m_luaExportHelper.m_immunePrefab = immunePrefab;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601BFC3 RID: 114627 RVA: 0x00896CC8 File Offset: 0x00894EC8
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_m_target1Prefab(IntPtr l)
	{
		int result;
		try
		{
			BattleSceneUIController battleSceneUIController = (BattleSceneUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, battleSceneUIController.m_luaExportHelper.m_target1Prefab);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601BFC4 RID: 114628 RVA: 0x00896D20 File Offset: 0x00894F20
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_target1Prefab(IntPtr l)
	{
		int result;
		try
		{
			BattleSceneUIController battleSceneUIController = (BattleSceneUIController)LuaObject.checkSelf(l);
			GameObject target1Prefab;
			LuaObject.checkType<GameObject>(l, 2, out target1Prefab);
			battleSceneUIController.m_luaExportHelper.m_target1Prefab = target1Prefab;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601BFC5 RID: 114629 RVA: 0x00896D7C File Offset: 0x00894F7C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_target2Prefab(IntPtr l)
	{
		int result;
		try
		{
			BattleSceneUIController battleSceneUIController = (BattleSceneUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, battleSceneUIController.m_luaExportHelper.m_target2Prefab);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601BFC6 RID: 114630 RVA: 0x00896DD4 File Offset: 0x00894FD4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_target2Prefab(IntPtr l)
	{
		int result;
		try
		{
			BattleSceneUIController battleSceneUIController = (BattleSceneUIController)LuaObject.checkSelf(l);
			GameObject target2Prefab;
			LuaObject.checkType<GameObject>(l, 2, out target2Prefab);
			battleSceneUIController.m_luaExportHelper.m_target2Prefab = target2Prefab;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601BFC7 RID: 114631 RVA: 0x00896E30 File Offset: 0x00895030
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_target3Prefab(IntPtr l)
	{
		int result;
		try
		{
			BattleSceneUIController battleSceneUIController = (BattleSceneUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, battleSceneUIController.m_luaExportHelper.m_target3Prefab);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601BFC8 RID: 114632 RVA: 0x00896E88 File Offset: 0x00895088
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_target3Prefab(IntPtr l)
	{
		int result;
		try
		{
			BattleSceneUIController battleSceneUIController = (BattleSceneUIController)LuaObject.checkSelf(l);
			GameObject target3Prefab;
			LuaObject.checkType<GameObject>(l, 2, out target3Prefab);
			battleSceneUIController.m_luaExportHelper.m_target3Prefab = target3Prefab;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601BFC9 RID: 114633 RVA: 0x00896EE4 File Offset: 0x008950E4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_target4Prefab(IntPtr l)
	{
		int result;
		try
		{
			BattleSceneUIController battleSceneUIController = (BattleSceneUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, battleSceneUIController.m_luaExportHelper.m_target4Prefab);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601BFCA RID: 114634 RVA: 0x00896F3C File Offset: 0x0089513C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_target4Prefab(IntPtr l)
	{
		int result;
		try
		{
			BattleSceneUIController battleSceneUIController = (BattleSceneUIController)LuaObject.checkSelf(l);
			GameObject target4Prefab;
			LuaObject.checkType<GameObject>(l, 2, out target4Prefab);
			battleSceneUIController.m_luaExportHelper.m_target4Prefab = target4Prefab;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601BFCB RID: 114635 RVA: 0x00896F98 File Offset: 0x00895198
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_m_target5Prefab(IntPtr l)
	{
		int result;
		try
		{
			BattleSceneUIController battleSceneUIController = (BattleSceneUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, battleSceneUIController.m_luaExportHelper.m_target5Prefab);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601BFCC RID: 114636 RVA: 0x00896FF0 File Offset: 0x008951F0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_target5Prefab(IntPtr l)
	{
		int result;
		try
		{
			BattleSceneUIController battleSceneUIController = (BattleSceneUIController)LuaObject.checkSelf(l);
			GameObject target5Prefab;
			LuaObject.checkType<GameObject>(l, 2, out target5Prefab);
			battleSceneUIController.m_luaExportHelper.m_target5Prefab = target5Prefab;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601BFCD RID: 114637 RVA: 0x0089704C File Offset: 0x0089524C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_target6Prefab(IntPtr l)
	{
		int result;
		try
		{
			BattleSceneUIController battleSceneUIController = (BattleSceneUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, battleSceneUIController.m_luaExportHelper.m_target6Prefab);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601BFCE RID: 114638 RVA: 0x008970A4 File Offset: 0x008952A4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_target6Prefab(IntPtr l)
	{
		int result;
		try
		{
			BattleSceneUIController battleSceneUIController = (BattleSceneUIController)LuaObject.checkSelf(l);
			GameObject target6Prefab;
			LuaObject.checkType<GameObject>(l, 2, out target6Prefab);
			battleSceneUIController.m_luaExportHelper.m_target6Prefab = target6Prefab;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601BFCF RID: 114639 RVA: 0x00897100 File Offset: 0x00895300
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_canActionPrefab(IntPtr l)
	{
		int result;
		try
		{
			BattleSceneUIController battleSceneUIController = (BattleSceneUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, battleSceneUIController.m_luaExportHelper.m_canActionPrefab);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601BFD0 RID: 114640 RVA: 0x00897158 File Offset: 0x00895358
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_m_canActionPrefab(IntPtr l)
	{
		int result;
		try
		{
			BattleSceneUIController battleSceneUIController = (BattleSceneUIController)LuaObject.checkSelf(l);
			GameObject canActionPrefab;
			LuaObject.checkType<GameObject>(l, 2, out canActionPrefab);
			battleSceneUIController.m_luaExportHelper.m_canActionPrefab = canActionPrefab;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601BFD1 RID: 114641 RVA: 0x008971B4 File Offset: 0x008953B4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_clientBattle(IntPtr l)
	{
		int result;
		try
		{
			BattleSceneUIController battleSceneUIController = (BattleSceneUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, battleSceneUIController.m_luaExportHelper.m_clientBattle);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601BFD2 RID: 114642 RVA: 0x0089720C File Offset: 0x0089540C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_clientBattle(IntPtr l)
	{
		int result;
		try
		{
			BattleSceneUIController battleSceneUIController = (BattleSceneUIController)LuaObject.checkSelf(l);
			ClientBattle clientBattle;
			LuaObject.checkType<ClientBattle>(l, 2, out clientBattle);
			battleSceneUIController.m_luaExportHelper.m_clientBattle = clientBattle;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601BFD3 RID: 114643 RVA: 0x00897268 File Offset: 0x00895468
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_damageNumberPool(IntPtr l)
	{
		int result;
		try
		{
			BattleSceneUIController battleSceneUIController = (BattleSceneUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, battleSceneUIController.m_luaExportHelper.m_damageNumberPool);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601BFD4 RID: 114644 RVA: 0x008972C0 File Offset: 0x008954C0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_damageNumberPool(IntPtr l)
	{
		int result;
		try
		{
			BattleSceneUIController battleSceneUIController = (BattleSceneUIController)LuaObject.checkSelf(l);
			GameObjectPool<DamageNumber> damageNumberPool;
			LuaObject.checkType<GameObjectPool<DamageNumber>>(l, 2, out damageNumberPool);
			battleSceneUIController.m_luaExportHelper.m_damageNumberPool = damageNumberPool;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601BFD5 RID: 114645 RVA: 0x0089731C File Offset: 0x0089551C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_damageNumberWeakPool(IntPtr l)
	{
		int result;
		try
		{
			BattleSceneUIController battleSceneUIController = (BattleSceneUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, battleSceneUIController.m_luaExportHelper.m_damageNumberWeakPool);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601BFD6 RID: 114646 RVA: 0x00897374 File Offset: 0x00895574
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_damageNumberWeakPool(IntPtr l)
	{
		int result;
		try
		{
			BattleSceneUIController battleSceneUIController = (BattleSceneUIController)LuaObject.checkSelf(l);
			GameObjectPool<DamageNumber> damageNumberWeakPool;
			LuaObject.checkType<GameObjectPool<DamageNumber>>(l, 2, out damageNumberWeakPool);
			battleSceneUIController.m_luaExportHelper.m_damageNumberWeakPool = damageNumberWeakPool;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601BFD7 RID: 114647 RVA: 0x008973D0 File Offset: 0x008955D0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_damageNumberStrongPool(IntPtr l)
	{
		int result;
		try
		{
			BattleSceneUIController battleSceneUIController = (BattleSceneUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, battleSceneUIController.m_luaExportHelper.m_damageNumberStrongPool);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601BFD8 RID: 114648 RVA: 0x00897428 File Offset: 0x00895628
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_damageNumberStrongPool(IntPtr l)
	{
		int result;
		try
		{
			BattleSceneUIController battleSceneUIController = (BattleSceneUIController)LuaObject.checkSelf(l);
			GameObjectPool<DamageNumber> damageNumberStrongPool;
			LuaObject.checkType<GameObjectPool<DamageNumber>>(l, 2, out damageNumberStrongPool);
			battleSceneUIController.m_luaExportHelper.m_damageNumberStrongPool = damageNumberStrongPool;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601BFD9 RID: 114649 RVA: 0x00897484 File Offset: 0x00895684
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_damageNumberCriticalPool(IntPtr l)
	{
		int result;
		try
		{
			BattleSceneUIController battleSceneUIController = (BattleSceneUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, battleSceneUIController.m_luaExportHelper.m_damageNumberCriticalPool);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601BFDA RID: 114650 RVA: 0x008974DC File Offset: 0x008956DC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_damageNumberCriticalPool(IntPtr l)
	{
		int result;
		try
		{
			BattleSceneUIController battleSceneUIController = (BattleSceneUIController)LuaObject.checkSelf(l);
			GameObjectPool<DamageNumber> damageNumberCriticalPool;
			LuaObject.checkType<GameObjectPool<DamageNumber>>(l, 2, out damageNumberCriticalPool);
			battleSceneUIController.m_luaExportHelper.m_damageNumberCriticalPool = damageNumberCriticalPool;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601BFDB RID: 114651 RVA: 0x00897538 File Offset: 0x00895738
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_damageNumberSoldierPool(IntPtr l)
	{
		int result;
		try
		{
			BattleSceneUIController battleSceneUIController = (BattleSceneUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, battleSceneUIController.m_luaExportHelper.m_damageNumberSoldierPool);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601BFDC RID: 114652 RVA: 0x00897590 File Offset: 0x00895790
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_damageNumberSoldierPool(IntPtr l)
	{
		int result;
		try
		{
			BattleSceneUIController battleSceneUIController = (BattleSceneUIController)LuaObject.checkSelf(l);
			GameObjectPool<DamageNumber> damageNumberSoldierPool;
			LuaObject.checkType<GameObjectPool<DamageNumber>>(l, 2, out damageNumberSoldierPool);
			battleSceneUIController.m_luaExportHelper.m_damageNumberSoldierPool = damageNumberSoldierPool;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601BFDD RID: 114653 RVA: 0x008975EC File Offset: 0x008957EC
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_m_healNumberPool(IntPtr l)
	{
		int result;
		try
		{
			BattleSceneUIController battleSceneUIController = (BattleSceneUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, battleSceneUIController.m_luaExportHelper.m_healNumberPool);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601BFDE RID: 114654 RVA: 0x00897644 File Offset: 0x00895844
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_healNumberPool(IntPtr l)
	{
		int result;
		try
		{
			BattleSceneUIController battleSceneUIController = (BattleSceneUIController)LuaObject.checkSelf(l);
			GameObjectPool<DamageNumber> healNumberPool;
			LuaObject.checkType<GameObjectPool<DamageNumber>>(l, 2, out healNumberPool);
			battleSceneUIController.m_luaExportHelper.m_healNumberPool = healNumberPool;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601BFDF RID: 114655 RVA: 0x008976A0 File Offset: 0x008958A0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_immunePool(IntPtr l)
	{
		int result;
		try
		{
			BattleSceneUIController battleSceneUIController = (BattleSceneUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, battleSceneUIController.m_luaExportHelper.m_immunePool);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601BFE0 RID: 114656 RVA: 0x008976F8 File Offset: 0x008958F8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_immunePool(IntPtr l)
	{
		int result;
		try
		{
			BattleSceneUIController battleSceneUIController = (BattleSceneUIController)LuaObject.checkSelf(l);
			GameObjectPool<DamageNumber> immunePool;
			LuaObject.checkType<GameObjectPool<DamageNumber>>(l, 2, out immunePool);
			battleSceneUIController.m_luaExportHelper.m_immunePool = immunePool;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601BFE1 RID: 114657 RVA: 0x00897754 File Offset: 0x00895954
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_targetIconPools(IntPtr l)
	{
		int result;
		try
		{
			BattleSceneUIController battleSceneUIController = (BattleSceneUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, battleSceneUIController.m_luaExportHelper.m_targetIconPools);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601BFE2 RID: 114658 RVA: 0x008977AC File Offset: 0x008959AC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_targetIconPools(IntPtr l)
	{
		int result;
		try
		{
			BattleSceneUIController battleSceneUIController = (BattleSceneUIController)LuaObject.checkSelf(l);
			GameObjectPool[] targetIconPools;
			LuaObject.checkArray<GameObjectPool>(l, 2, out targetIconPools);
			battleSceneUIController.m_luaExportHelper.m_targetIconPools = targetIconPools;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601BFE3 RID: 114659 RVA: 0x00897808 File Offset: 0x00895A08
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_canActionIconPool(IntPtr l)
	{
		int result;
		try
		{
			BattleSceneUIController battleSceneUIController = (BattleSceneUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, battleSceneUIController.m_luaExportHelper.m_canActionIconPool);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601BFE4 RID: 114660 RVA: 0x00897860 File Offset: 0x00895A60
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_m_canActionIconPool(IntPtr l)
	{
		int result;
		try
		{
			BattleSceneUIController battleSceneUIController = (BattleSceneUIController)LuaObject.checkSelf(l);
			GameObjectPool canActionIconPool;
			LuaObject.checkType<GameObjectPool>(l, 2, out canActionIconPool);
			battleSceneUIController.m_luaExportHelper.m_canActionIconPool = canActionIconPool;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601BFE5 RID: 114661 RVA: 0x008978BC File Offset: 0x00895ABC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_hideTargetIconTime(IntPtr l)
	{
		int result;
		try
		{
			BattleSceneUIController battleSceneUIController = (BattleSceneUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, battleSceneUIController.m_luaExportHelper.m_hideTargetIconTime);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601BFE6 RID: 114662 RVA: 0x00897914 File Offset: 0x00895B14
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_m_hideTargetIconTime(IntPtr l)
	{
		int result;
		try
		{
			BattleSceneUIController battleSceneUIController = (BattleSceneUIController)LuaObject.checkSelf(l);
			float hideTargetIconTime;
			LuaObject.checkType(l, 2, out hideTargetIconTime);
			battleSceneUIController.m_luaExportHelper.m_hideTargetIconTime = hideTargetIconTime;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601BFE7 RID: 114663 RVA: 0x00897970 File Offset: 0x00895B70
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_InvalidPointerID(IntPtr l)
	{
		int result;
		try
		{
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, BattleSceneUIController.LuaExportHelper.InvalidPointerID);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601BFE8 RID: 114664 RVA: 0x008979B8 File Offset: 0x00895BB8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_downPointerId(IntPtr l)
	{
		int result;
		try
		{
			BattleSceneUIController battleSceneUIController = (BattleSceneUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, battleSceneUIController.m_luaExportHelper.m_downPointerId);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601BFE9 RID: 114665 RVA: 0x00897A10 File Offset: 0x00895C10
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_downPointerId(IntPtr l)
	{
		int result;
		try
		{
			BattleSceneUIController battleSceneUIController = (BattleSceneUIController)LuaObject.checkSelf(l);
			int downPointerId;
			LuaObject.checkType(l, 2, out downPointerId);
			battleSceneUIController.m_luaExportHelper.m_downPointerId = downPointerId;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601BFEA RID: 114666 RVA: 0x00897A6C File Offset: 0x00895C6C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_clickPointerId(IntPtr l)
	{
		int result;
		try
		{
			BattleSceneUIController battleSceneUIController = (BattleSceneUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, battleSceneUIController.m_luaExportHelper.m_clickPointerId);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601BFEB RID: 114667 RVA: 0x00897AC4 File Offset: 0x00895CC4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_clickPointerId(IntPtr l)
	{
		int result;
		try
		{
			BattleSceneUIController battleSceneUIController = (BattleSceneUIController)LuaObject.checkSelf(l);
			int clickPointerId;
			LuaObject.checkType(l, 2, out clickPointerId);
			battleSceneUIController.m_luaExportHelper.m_clickPointerId = clickPointerId;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601BFEC RID: 114668 RVA: 0x00897B20 File Offset: 0x00895D20
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_dragPointerId(IntPtr l)
	{
		int result;
		try
		{
			BattleSceneUIController battleSceneUIController = (BattleSceneUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, battleSceneUIController.m_luaExportHelper.m_dragPointerId);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601BFED RID: 114669 RVA: 0x00897B78 File Offset: 0x00895D78
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_dragPointerId(IntPtr l)
	{
		int result;
		try
		{
			BattleSceneUIController battleSceneUIController = (BattleSceneUIController)LuaObject.checkSelf(l);
			int dragPointerId;
			LuaObject.checkType(l, 2, out dragPointerId);
			battleSceneUIController.m_luaExportHelper.m_dragPointerId = dragPointerId;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601BFEE RID: 114670 RVA: 0x00897BD4 File Offset: 0x00895DD4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_is3DTouchTriggered(IntPtr l)
	{
		int result;
		try
		{
			BattleSceneUIController battleSceneUIController = (BattleSceneUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, battleSceneUIController.m_luaExportHelper.m_is3DTouchTriggered);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601BFEF RID: 114671 RVA: 0x00897C2C File Offset: 0x00895E2C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_is3DTouchTriggered(IntPtr l)
	{
		int result;
		try
		{
			BattleSceneUIController battleSceneUIController = (BattleSceneUIController)LuaObject.checkSelf(l);
			bool is3DTouchTriggered;
			LuaObject.checkType(l, 2, out is3DTouchTriggered);
			battleSceneUIController.m_luaExportHelper.m_is3DTouchTriggered = is3DTouchTriggered;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601BFF0 RID: 114672 RVA: 0x00897C88 File Offset: 0x00895E88
	[Preserve]
	public static void reg(IntPtr l)
	{
		LuaObject.getTypeTable(l, "BlackJack.ProjectL.UI.BattleSceneUIController");
		if (Lua_BlackJack_ProjectL_UI_BattleSceneUIController.<>f__mg$cache0 == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleSceneUIController.<>f__mg$cache0 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleSceneUIController.Initialize);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_BattleSceneUIController.<>f__mg$cache0);
		if (Lua_BlackJack_ProjectL_UI_BattleSceneUIController.<>f__mg$cache1 == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleSceneUIController.<>f__mg$cache1 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleSceneUIController.PrepareBattle);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_BattleSceneUIController.<>f__mg$cache1);
		if (Lua_BlackJack_ProjectL_UI_BattleSceneUIController.<>f__mg$cache2 == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleSceneUIController.<>f__mg$cache2 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleSceneUIController.StartBattle);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_BattleSceneUIController.<>f__mg$cache2);
		if (Lua_BlackJack_ProjectL_UI_BattleSceneUIController.<>f__mg$cache3 == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleSceneUIController.<>f__mg$cache3 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleSceneUIController.StopBattle);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_BattleSceneUIController.<>f__mg$cache3);
		if (Lua_BlackJack_ProjectL_UI_BattleSceneUIController.<>f__mg$cache4 == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleSceneUIController.<>f__mg$cache4 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleSceneUIController.ShowBattleWinCondition);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_BattleSceneUIController.<>f__mg$cache4);
		if (Lua_BlackJack_ProjectL_UI_BattleSceneUIController.<>f__mg$cache5 == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleSceneUIController.<>f__mg$cache5 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleSceneUIController.HideBattleWinCondition);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_BattleSceneUIController.<>f__mg$cache5);
		if (Lua_BlackJack_ProjectL_UI_BattleSceneUIController.<>f__mg$cache6 == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleSceneUIController.<>f__mg$cache6 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleSceneUIController.OnActorSkillHit);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_BattleSceneUIController.<>f__mg$cache6);
		if (Lua_BlackJack_ProjectL_UI_BattleSceneUIController.<>f__mg$cache7 == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleSceneUIController.<>f__mg$cache7 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleSceneUIController.OnActorBuffHit);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_BattleSceneUIController.<>f__mg$cache7);
		if (Lua_BlackJack_ProjectL_UI_BattleSceneUIController.<>f__mg$cache8 == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleSceneUIController.<>f__mg$cache8 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleSceneUIController.OnActorTerrainHit);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_BattleSceneUIController.<>f__mg$cache8);
		if (Lua_BlackJack_ProjectL_UI_BattleSceneUIController.<>f__mg$cache9 == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleSceneUIController.<>f__mg$cache9 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleSceneUIController.OnActorAttachImmune);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_BattleSceneUIController.<>f__mg$cache9);
		if (Lua_BlackJack_ProjectL_UI_BattleSceneUIController.<>f__mg$cacheA == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleSceneUIController.<>f__mg$cacheA = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleSceneUIController.OnActorPassiveSkill);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_BattleSceneUIController.<>f__mg$cacheA);
		if (Lua_BlackJack_ProjectL_UI_BattleSceneUIController.<>f__mg$cacheB == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleSceneUIController.<>f__mg$cacheB = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleSceneUIController.OnActorGuard);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_BattleSceneUIController.<>f__mg$cacheB);
		if (Lua_BlackJack_ProjectL_UI_BattleSceneUIController.<>f__mg$cacheC == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleSceneUIController.<>f__mg$cacheC = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleSceneUIController.OnActorCombatDamage);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_BattleSceneUIController.<>f__mg$cacheC);
		if (Lua_BlackJack_ProjectL_UI_BattleSceneUIController.<>f__mg$cacheD == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleSceneUIController.<>f__mg$cacheD = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleSceneUIController.SetActiveActor);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_BattleSceneUIController.<>f__mg$cacheD);
		if (Lua_BlackJack_ProjectL_UI_BattleSceneUIController.<>f__mg$cacheE == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleSceneUIController.<>f__mg$cacheE = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleSceneUIController.ShowSelectionMark);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_BattleSceneUIController.<>f__mg$cacheE);
		if (Lua_BlackJack_ProjectL_UI_BattleSceneUIController.<>f__mg$cacheF == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleSceneUIController.<>f__mg$cacheF = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleSceneUIController.HideSelectionMark);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_BattleSceneUIController.<>f__mg$cacheF);
		if (Lua_BlackJack_ProjectL_UI_BattleSceneUIController.<>f__mg$cache10 == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleSceneUIController.<>f__mg$cache10 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleSceneUIController.ShowTargetIcons);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_BattleSceneUIController.<>f__mg$cache10);
		if (Lua_BlackJack_ProjectL_UI_BattleSceneUIController.<>f__mg$cache11 == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleSceneUIController.<>f__mg$cache11 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleSceneUIController.ShowTargetIcon);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_BattleSceneUIController.<>f__mg$cache11);
		if (Lua_BlackJack_ProjectL_UI_BattleSceneUIController.<>f__mg$cache12 == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleSceneUIController.<>f__mg$cache12 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleSceneUIController.HideTargetIcons);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_BattleSceneUIController.<>f__mg$cache12);
		if (Lua_BlackJack_ProjectL_UI_BattleSceneUIController.<>f__mg$cache13 == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleSceneUIController.<>f__mg$cache13 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleSceneUIController.ShowCanActionIcons);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_BattleSceneUIController.<>f__mg$cache13);
		if (Lua_BlackJack_ProjectL_UI_BattleSceneUIController.<>f__mg$cache14 == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleSceneUIController.<>f__mg$cache14 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleSceneUIController.HideCanActionIcons);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_BattleSceneUIController.<>f__mg$cache14);
		if (Lua_BlackJack_ProjectL_UI_BattleSceneUIController.<>f__mg$cache15 == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleSceneUIController.<>f__mg$cache15 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleSceneUIController.OnPointerDown);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_BattleSceneUIController.<>f__mg$cache15);
		if (Lua_BlackJack_ProjectL_UI_BattleSceneUIController.<>f__mg$cache16 == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleSceneUIController.<>f__mg$cache16 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleSceneUIController.OnPointerUp);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_BattleSceneUIController.<>f__mg$cache16);
		if (Lua_BlackJack_ProjectL_UI_BattleSceneUIController.<>f__mg$cache17 == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleSceneUIController.<>f__mg$cache17 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleSceneUIController.OnPointerClick);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_BattleSceneUIController.<>f__mg$cache17);
		if (Lua_BlackJack_ProjectL_UI_BattleSceneUIController.<>f__mg$cache18 == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleSceneUIController.<>f__mg$cache18 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleSceneUIController.OnBeginDrag);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_BattleSceneUIController.<>f__mg$cache18);
		if (Lua_BlackJack_ProjectL_UI_BattleSceneUIController.<>f__mg$cache19 == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleSceneUIController.<>f__mg$cache19 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleSceneUIController.OnEndDrag);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_BattleSceneUIController.<>f__mg$cache19);
		if (Lua_BlackJack_ProjectL_UI_BattleSceneUIController.<>f__mg$cache1A == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleSceneUIController.<>f__mg$cache1A = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleSceneUIController.OnDrag);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_BattleSceneUIController.<>f__mg$cache1A);
		if (Lua_BlackJack_ProjectL_UI_BattleSceneUIController.<>f__mg$cache1B == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleSceneUIController.<>f__mg$cache1B = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleSceneUIController.OnBindFiledsCompleted);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_BattleSceneUIController.<>f__mg$cache1B);
		if (Lua_BlackJack_ProjectL_UI_BattleSceneUIController.<>f__mg$cache1C == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleSceneUIController.<>f__mg$cache1C = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleSceneUIController.ShowDamageNumbers);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_BattleSceneUIController.<>f__mg$cache1C);
		if (Lua_BlackJack_ProjectL_UI_BattleSceneUIController.<>f__mg$cache1D == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleSceneUIController.<>f__mg$cache1D = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleSceneUIController.ShowDamangeNumber);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_BattleSceneUIController.<>f__mg$cache1D);
		if (Lua_BlackJack_ProjectL_UI_BattleSceneUIController.<>f__mg$cache1E == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleSceneUIController.<>f__mg$cache1E = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleSceneUIController.Update);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_BattleSceneUIController.<>f__mg$cache1E);
		if (Lua_BlackJack_ProjectL_UI_BattleSceneUIController.<>f__mg$cache1F == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleSceneUIController.<>f__mg$cache1F = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleSceneUIController.Update3DTouch);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_BattleSceneUIController.<>f__mg$cache1F);
		if (Lua_BlackJack_ProjectL_UI_BattleSceneUIController.<>f__mg$cache20 == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleSceneUIController.<>f__mg$cache20 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleSceneUIController.GetActorGraphicCenterPosition);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_BattleSceneUIController.<>f__mg$cache20);
		if (Lua_BlackJack_ProjectL_UI_BattleSceneUIController.<>f__mg$cache21 == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleSceneUIController.<>f__mg$cache21 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleSceneUIController.AllocateTargetIcon);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_BattleSceneUIController.<>f__mg$cache21);
		if (Lua_BlackJack_ProjectL_UI_BattleSceneUIController.<>f__mg$cache22 == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleSceneUIController.<>f__mg$cache22 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleSceneUIController.GridPositionToMapPosition);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_BattleSceneUIController.<>f__mg$cache22);
		if (Lua_BlackJack_ProjectL_UI_BattleSceneUIController.<>f__mg$cache23 == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleSceneUIController.<>f__mg$cache23 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleSceneUIController.__callBase_Initlize);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_BattleSceneUIController.<>f__mg$cache23);
		if (Lua_BlackJack_ProjectL_UI_BattleSceneUIController.<>f__mg$cache24 == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleSceneUIController.<>f__mg$cache24 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleSceneUIController.__callBase_BindFields);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_BattleSceneUIController.<>f__mg$cache24);
		if (Lua_BlackJack_ProjectL_UI_BattleSceneUIController.<>f__mg$cache25 == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleSceneUIController.<>f__mg$cache25 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleSceneUIController.__callBase_OnBindFiledsCompleted);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_BattleSceneUIController.<>f__mg$cache25);
		if (Lua_BlackJack_ProjectL_UI_BattleSceneUIController.<>f__mg$cache26 == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleSceneUIController.<>f__mg$cache26 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleSceneUIController.__callBase_BindFieldImpl);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_BattleSceneUIController.<>f__mg$cache26);
		if (Lua_BlackJack_ProjectL_UI_BattleSceneUIController.<>f__mg$cache27 == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleSceneUIController.<>f__mg$cache27 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleSceneUIController.__callBase_Clear);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_BattleSceneUIController.<>f__mg$cache27);
		if (Lua_BlackJack_ProjectL_UI_BattleSceneUIController.<>f__mg$cache28 == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleSceneUIController.<>f__mg$cache28 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleSceneUIController.__callBase_OnButtonClick);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_BattleSceneUIController.<>f__mg$cache28);
		if (Lua_BlackJack_ProjectL_UI_BattleSceneUIController.<>f__mg$cache29 == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleSceneUIController.<>f__mg$cache29 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleSceneUIController.__callBase_SetButtonClickListener);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_BattleSceneUIController.<>f__mg$cache29);
		if (Lua_BlackJack_ProjectL_UI_BattleSceneUIController.<>f__mg$cache2A == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleSceneUIController.<>f__mg$cache2A = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleSceneUIController.__callBase_SetButtonDoubleClickListener);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_BattleSceneUIController.<>f__mg$cache2A);
		if (Lua_BlackJack_ProjectL_UI_BattleSceneUIController.<>f__mg$cache2B == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleSceneUIController.<>f__mg$cache2B = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleSceneUIController.__callBase_SetButtonLongPressStartListener);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_BattleSceneUIController.<>f__mg$cache2B);
		if (Lua_BlackJack_ProjectL_UI_BattleSceneUIController.<>f__mg$cache2C == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleSceneUIController.<>f__mg$cache2C = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleSceneUIController.__callBase_SetButtonLongPressingListener);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_BattleSceneUIController.<>f__mg$cache2C);
		if (Lua_BlackJack_ProjectL_UI_BattleSceneUIController.<>f__mg$cache2D == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleSceneUIController.<>f__mg$cache2D = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleSceneUIController.__callBase_SetButtonLongPressEndListener);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_BattleSceneUIController.<>f__mg$cache2D);
		if (Lua_BlackJack_ProjectL_UI_BattleSceneUIController.<>f__mg$cache2E == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleSceneUIController.<>f__mg$cache2E = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleSceneUIController.__callBase_SetToggleValueChangedListener);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_BattleSceneUIController.<>f__mg$cache2E);
		if (Lua_BlackJack_ProjectL_UI_BattleSceneUIController.<>f__mg$cache2F == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleSceneUIController.<>f__mg$cache2F = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleSceneUIController.__callBase_ToString);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_BattleSceneUIController.<>f__mg$cache2F);
		if (Lua_BlackJack_ProjectL_UI_BattleSceneUIController.<>f__mg$cache30 == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleSceneUIController.<>f__mg$cache30 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleSceneUIController.__callDele_EventOnPointerDown);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_BattleSceneUIController.<>f__mg$cache30);
		if (Lua_BlackJack_ProjectL_UI_BattleSceneUIController.<>f__mg$cache31 == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleSceneUIController.<>f__mg$cache31 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleSceneUIController.__clearDele_EventOnPointerDown);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_BattleSceneUIController.<>f__mg$cache31);
		if (Lua_BlackJack_ProjectL_UI_BattleSceneUIController.<>f__mg$cache32 == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleSceneUIController.<>f__mg$cache32 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleSceneUIController.__callDele_EventOnPointerUp);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_BattleSceneUIController.<>f__mg$cache32);
		if (Lua_BlackJack_ProjectL_UI_BattleSceneUIController.<>f__mg$cache33 == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleSceneUIController.<>f__mg$cache33 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleSceneUIController.__clearDele_EventOnPointerUp);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_BattleSceneUIController.<>f__mg$cache33);
		if (Lua_BlackJack_ProjectL_UI_BattleSceneUIController.<>f__mg$cache34 == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleSceneUIController.<>f__mg$cache34 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleSceneUIController.__callDele_EventOnPointerClick);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_BattleSceneUIController.<>f__mg$cache34);
		if (Lua_BlackJack_ProjectL_UI_BattleSceneUIController.<>f__mg$cache35 == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleSceneUIController.<>f__mg$cache35 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleSceneUIController.__clearDele_EventOnPointerClick);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_BattleSceneUIController.<>f__mg$cache35);
		if (Lua_BlackJack_ProjectL_UI_BattleSceneUIController.<>f__mg$cache36 == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleSceneUIController.<>f__mg$cache36 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleSceneUIController.__callDele_EventOnBeginDrag);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_BattleSceneUIController.<>f__mg$cache36);
		if (Lua_BlackJack_ProjectL_UI_BattleSceneUIController.<>f__mg$cache37 == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleSceneUIController.<>f__mg$cache37 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleSceneUIController.__clearDele_EventOnBeginDrag);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_BattleSceneUIController.<>f__mg$cache37);
		if (Lua_BlackJack_ProjectL_UI_BattleSceneUIController.<>f__mg$cache38 == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleSceneUIController.<>f__mg$cache38 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleSceneUIController.__callDele_EventOnEndDrag);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_BattleSceneUIController.<>f__mg$cache38);
		if (Lua_BlackJack_ProjectL_UI_BattleSceneUIController.<>f__mg$cache39 == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleSceneUIController.<>f__mg$cache39 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleSceneUIController.__clearDele_EventOnEndDrag);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_BattleSceneUIController.<>f__mg$cache39);
		if (Lua_BlackJack_ProjectL_UI_BattleSceneUIController.<>f__mg$cache3A == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleSceneUIController.<>f__mg$cache3A = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleSceneUIController.__callDele_EventOnDrag);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_BattleSceneUIController.<>f__mg$cache3A);
		if (Lua_BlackJack_ProjectL_UI_BattleSceneUIController.<>f__mg$cache3B == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleSceneUIController.<>f__mg$cache3B = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleSceneUIController.__clearDele_EventOnDrag);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_BattleSceneUIController.<>f__mg$cache3B);
		if (Lua_BlackJack_ProjectL_UI_BattleSceneUIController.<>f__mg$cache3C == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleSceneUIController.<>f__mg$cache3C = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleSceneUIController.__callDele_EventOn3DTouch);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_BattleSceneUIController.<>f__mg$cache3C);
		if (Lua_BlackJack_ProjectL_UI_BattleSceneUIController.<>f__mg$cache3D == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleSceneUIController.<>f__mg$cache3D = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleSceneUIController.__clearDele_EventOn3DTouch);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_BattleSceneUIController.<>f__mg$cache3D);
		string name = "EventOnPointerDown";
		LuaCSFunction get = null;
		if (Lua_BlackJack_ProjectL_UI_BattleSceneUIController.<>f__mg$cache3E == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleSceneUIController.<>f__mg$cache3E = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleSceneUIController.set_EventOnPointerDown);
		}
		LuaObject.addMember(l, name, get, Lua_BlackJack_ProjectL_UI_BattleSceneUIController.<>f__mg$cache3E, true);
		string name2 = "EventOnPointerUp";
		LuaCSFunction get2 = null;
		if (Lua_BlackJack_ProjectL_UI_BattleSceneUIController.<>f__mg$cache3F == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleSceneUIController.<>f__mg$cache3F = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleSceneUIController.set_EventOnPointerUp);
		}
		LuaObject.addMember(l, name2, get2, Lua_BlackJack_ProjectL_UI_BattleSceneUIController.<>f__mg$cache3F, true);
		string name3 = "EventOnPointerClick";
		LuaCSFunction get3 = null;
		if (Lua_BlackJack_ProjectL_UI_BattleSceneUIController.<>f__mg$cache40 == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleSceneUIController.<>f__mg$cache40 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleSceneUIController.set_EventOnPointerClick);
		}
		LuaObject.addMember(l, name3, get3, Lua_BlackJack_ProjectL_UI_BattleSceneUIController.<>f__mg$cache40, true);
		string name4 = "EventOnBeginDrag";
		LuaCSFunction get4 = null;
		if (Lua_BlackJack_ProjectL_UI_BattleSceneUIController.<>f__mg$cache41 == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleSceneUIController.<>f__mg$cache41 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleSceneUIController.set_EventOnBeginDrag);
		}
		LuaObject.addMember(l, name4, get4, Lua_BlackJack_ProjectL_UI_BattleSceneUIController.<>f__mg$cache41, true);
		string name5 = "EventOnEndDrag";
		LuaCSFunction get5 = null;
		if (Lua_BlackJack_ProjectL_UI_BattleSceneUIController.<>f__mg$cache42 == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleSceneUIController.<>f__mg$cache42 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleSceneUIController.set_EventOnEndDrag);
		}
		LuaObject.addMember(l, name5, get5, Lua_BlackJack_ProjectL_UI_BattleSceneUIController.<>f__mg$cache42, true);
		string name6 = "EventOnDrag";
		LuaCSFunction get6 = null;
		if (Lua_BlackJack_ProjectL_UI_BattleSceneUIController.<>f__mg$cache43 == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleSceneUIController.<>f__mg$cache43 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleSceneUIController.set_EventOnDrag);
		}
		LuaObject.addMember(l, name6, get6, Lua_BlackJack_ProjectL_UI_BattleSceneUIController.<>f__mg$cache43, true);
		string name7 = "EventOn3DTouch";
		LuaCSFunction get7 = null;
		if (Lua_BlackJack_ProjectL_UI_BattleSceneUIController.<>f__mg$cache44 == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleSceneUIController.<>f__mg$cache44 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleSceneUIController.set_EventOn3DTouch);
		}
		LuaObject.addMember(l, name7, get7, Lua_BlackJack_ProjectL_UI_BattleSceneUIController.<>f__mg$cache44, true);
		string name8 = "m_actionMarkGameObject";
		if (Lua_BlackJack_ProjectL_UI_BattleSceneUIController.<>f__mg$cache45 == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleSceneUIController.<>f__mg$cache45 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleSceneUIController.get_m_actionMarkGameObject);
		}
		LuaCSFunction get8 = Lua_BlackJack_ProjectL_UI_BattleSceneUIController.<>f__mg$cache45;
		if (Lua_BlackJack_ProjectL_UI_BattleSceneUIController.<>f__mg$cache46 == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleSceneUIController.<>f__mg$cache46 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleSceneUIController.set_m_actionMarkGameObject);
		}
		LuaObject.addMember(l, name8, get8, Lua_BlackJack_ProjectL_UI_BattleSceneUIController.<>f__mg$cache46, true);
		string name9 = "m_actionMark2GameObject";
		if (Lua_BlackJack_ProjectL_UI_BattleSceneUIController.<>f__mg$cache47 == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleSceneUIController.<>f__mg$cache47 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleSceneUIController.get_m_actionMark2GameObject);
		}
		LuaCSFunction get9 = Lua_BlackJack_ProjectL_UI_BattleSceneUIController.<>f__mg$cache47;
		if (Lua_BlackJack_ProjectL_UI_BattleSceneUIController.<>f__mg$cache48 == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleSceneUIController.<>f__mg$cache48 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleSceneUIController.set_m_actionMark2GameObject);
		}
		LuaObject.addMember(l, name9, get9, Lua_BlackJack_ProjectL_UI_BattleSceneUIController.<>f__mg$cache48, true);
		string name10 = "m_winConditionUIStateController";
		if (Lua_BlackJack_ProjectL_UI_BattleSceneUIController.<>f__mg$cache49 == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleSceneUIController.<>f__mg$cache49 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleSceneUIController.get_m_winConditionUIStateController);
		}
		LuaCSFunction get10 = Lua_BlackJack_ProjectL_UI_BattleSceneUIController.<>f__mg$cache49;
		if (Lua_BlackJack_ProjectL_UI_BattleSceneUIController.<>f__mg$cache4A == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleSceneUIController.<>f__mg$cache4A = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleSceneUIController.set_m_winConditionUIStateController);
		}
		LuaObject.addMember(l, name10, get10, Lua_BlackJack_ProjectL_UI_BattleSceneUIController.<>f__mg$cache4A, true);
		string name11 = "m_winConditionKillGameObject";
		if (Lua_BlackJack_ProjectL_UI_BattleSceneUIController.<>f__mg$cache4B == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleSceneUIController.<>f__mg$cache4B = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleSceneUIController.get_m_winConditionKillGameObject);
		}
		LuaCSFunction get11 = Lua_BlackJack_ProjectL_UI_BattleSceneUIController.<>f__mg$cache4B;
		if (Lua_BlackJack_ProjectL_UI_BattleSceneUIController.<>f__mg$cache4C == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleSceneUIController.<>f__mg$cache4C = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleSceneUIController.set_m_winConditionKillGameObject);
		}
		LuaObject.addMember(l, name11, get11, Lua_BlackJack_ProjectL_UI_BattleSceneUIController.<>f__mg$cache4C, true);
		string name12 = "m_winConditionProtectGameObject";
		if (Lua_BlackJack_ProjectL_UI_BattleSceneUIController.<>f__mg$cache4D == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleSceneUIController.<>f__mg$cache4D = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleSceneUIController.get_m_winConditionProtectGameObject);
		}
		LuaCSFunction get12 = Lua_BlackJack_ProjectL_UI_BattleSceneUIController.<>f__mg$cache4D;
		if (Lua_BlackJack_ProjectL_UI_BattleSceneUIController.<>f__mg$cache4E == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleSceneUIController.<>f__mg$cache4E = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleSceneUIController.set_m_winConditionProtectGameObject);
		}
		LuaObject.addMember(l, name12, get12, Lua_BlackJack_ProjectL_UI_BattleSceneUIController.<>f__mg$cache4E, true);
		string name13 = "m_selectionMarkGameObject";
		if (Lua_BlackJack_ProjectL_UI_BattleSceneUIController.<>f__mg$cache4F == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleSceneUIController.<>f__mg$cache4F = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleSceneUIController.get_m_selectionMarkGameObject);
		}
		LuaCSFunction get13 = Lua_BlackJack_ProjectL_UI_BattleSceneUIController.<>f__mg$cache4F;
		if (Lua_BlackJack_ProjectL_UI_BattleSceneUIController.<>f__mg$cache50 == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleSceneUIController.<>f__mg$cache50 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleSceneUIController.set_m_selectionMarkGameObject);
		}
		LuaObject.addMember(l, name13, get13, Lua_BlackJack_ProjectL_UI_BattleSceneUIController.<>f__mg$cache50, true);
		string name14 = "m_passiveSkillUIStateController";
		if (Lua_BlackJack_ProjectL_UI_BattleSceneUIController.<>f__mg$cache51 == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleSceneUIController.<>f__mg$cache51 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleSceneUIController.get_m_passiveSkillUIStateController);
		}
		LuaCSFunction get14 = Lua_BlackJack_ProjectL_UI_BattleSceneUIController.<>f__mg$cache51;
		if (Lua_BlackJack_ProjectL_UI_BattleSceneUIController.<>f__mg$cache52 == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleSceneUIController.<>f__mg$cache52 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleSceneUIController.set_m_passiveSkillUIStateController);
		}
		LuaObject.addMember(l, name14, get14, Lua_BlackJack_ProjectL_UI_BattleSceneUIController.<>f__mg$cache52, true);
		string name15 = "m_passiveSkillIconImage";
		if (Lua_BlackJack_ProjectL_UI_BattleSceneUIController.<>f__mg$cache53 == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleSceneUIController.<>f__mg$cache53 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleSceneUIController.get_m_passiveSkillIconImage);
		}
		LuaCSFunction get15 = Lua_BlackJack_ProjectL_UI_BattleSceneUIController.<>f__mg$cache53;
		if (Lua_BlackJack_ProjectL_UI_BattleSceneUIController.<>f__mg$cache54 == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleSceneUIController.<>f__mg$cache54 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleSceneUIController.set_m_passiveSkillIconImage);
		}
		LuaObject.addMember(l, name15, get15, Lua_BlackJack_ProjectL_UI_BattleSceneUIController.<>f__mg$cache54, true);
		string name16 = "m_passiveSkillTalentIconImage";
		if (Lua_BlackJack_ProjectL_UI_BattleSceneUIController.<>f__mg$cache55 == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleSceneUIController.<>f__mg$cache55 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleSceneUIController.get_m_passiveSkillTalentIconImage);
		}
		LuaCSFunction get16 = Lua_BlackJack_ProjectL_UI_BattleSceneUIController.<>f__mg$cache55;
		if (Lua_BlackJack_ProjectL_UI_BattleSceneUIController.<>f__mg$cache56 == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleSceneUIController.<>f__mg$cache56 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleSceneUIController.set_m_passiveSkillTalentIconImage);
		}
		LuaObject.addMember(l, name16, get16, Lua_BlackJack_ProjectL_UI_BattleSceneUIController.<>f__mg$cache56, true);
		string name17 = "m_passiveSkillNameText";
		if (Lua_BlackJack_ProjectL_UI_BattleSceneUIController.<>f__mg$cache57 == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleSceneUIController.<>f__mg$cache57 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleSceneUIController.get_m_passiveSkillNameText);
		}
		LuaCSFunction get17 = Lua_BlackJack_ProjectL_UI_BattleSceneUIController.<>f__mg$cache57;
		if (Lua_BlackJack_ProjectL_UI_BattleSceneUIController.<>f__mg$cache58 == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleSceneUIController.<>f__mg$cache58 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleSceneUIController.set_m_passiveSkillNameText);
		}
		LuaObject.addMember(l, name17, get17, Lua_BlackJack_ProjectL_UI_BattleSceneUIController.<>f__mg$cache58, true);
		string name18 = "m_guardUIStateController";
		if (Lua_BlackJack_ProjectL_UI_BattleSceneUIController.<>f__mg$cache59 == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleSceneUIController.<>f__mg$cache59 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleSceneUIController.get_m_guardUIStateController);
		}
		LuaCSFunction get18 = Lua_BlackJack_ProjectL_UI_BattleSceneUIController.<>f__mg$cache59;
		if (Lua_BlackJack_ProjectL_UI_BattleSceneUIController.<>f__mg$cache5A == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleSceneUIController.<>f__mg$cache5A = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleSceneUIController.set_m_guardUIStateController);
		}
		LuaObject.addMember(l, name18, get18, Lua_BlackJack_ProjectL_UI_BattleSceneUIController.<>f__mg$cache5A, true);
		string name19 = "m_damageNumbersGameObject";
		if (Lua_BlackJack_ProjectL_UI_BattleSceneUIController.<>f__mg$cache5B == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleSceneUIController.<>f__mg$cache5B = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleSceneUIController.get_m_damageNumbersGameObject);
		}
		LuaCSFunction get19 = Lua_BlackJack_ProjectL_UI_BattleSceneUIController.<>f__mg$cache5B;
		if (Lua_BlackJack_ProjectL_UI_BattleSceneUIController.<>f__mg$cache5C == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleSceneUIController.<>f__mg$cache5C = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleSceneUIController.set_m_damageNumbersGameObject);
		}
		LuaObject.addMember(l, name19, get19, Lua_BlackJack_ProjectL_UI_BattleSceneUIController.<>f__mg$cache5C, true);
		string name20 = "m_prefabsGameObject";
		if (Lua_BlackJack_ProjectL_UI_BattleSceneUIController.<>f__mg$cache5D == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleSceneUIController.<>f__mg$cache5D = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleSceneUIController.get_m_prefabsGameObject);
		}
		LuaCSFunction get20 = Lua_BlackJack_ProjectL_UI_BattleSceneUIController.<>f__mg$cache5D;
		if (Lua_BlackJack_ProjectL_UI_BattleSceneUIController.<>f__mg$cache5E == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleSceneUIController.<>f__mg$cache5E = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleSceneUIController.set_m_prefabsGameObject);
		}
		LuaObject.addMember(l, name20, get20, Lua_BlackJack_ProjectL_UI_BattleSceneUIController.<>f__mg$cache5E, true);
		string name21 = "m_damageNumberPrefab";
		if (Lua_BlackJack_ProjectL_UI_BattleSceneUIController.<>f__mg$cache5F == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleSceneUIController.<>f__mg$cache5F = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleSceneUIController.get_m_damageNumberPrefab);
		}
		LuaCSFunction get21 = Lua_BlackJack_ProjectL_UI_BattleSceneUIController.<>f__mg$cache5F;
		if (Lua_BlackJack_ProjectL_UI_BattleSceneUIController.<>f__mg$cache60 == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleSceneUIController.<>f__mg$cache60 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleSceneUIController.set_m_damageNumberPrefab);
		}
		LuaObject.addMember(l, name21, get21, Lua_BlackJack_ProjectL_UI_BattleSceneUIController.<>f__mg$cache60, true);
		string name22 = "m_damageNumberWeakPrefab";
		if (Lua_BlackJack_ProjectL_UI_BattleSceneUIController.<>f__mg$cache61 == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleSceneUIController.<>f__mg$cache61 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleSceneUIController.get_m_damageNumberWeakPrefab);
		}
		LuaCSFunction get22 = Lua_BlackJack_ProjectL_UI_BattleSceneUIController.<>f__mg$cache61;
		if (Lua_BlackJack_ProjectL_UI_BattleSceneUIController.<>f__mg$cache62 == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleSceneUIController.<>f__mg$cache62 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleSceneUIController.set_m_damageNumberWeakPrefab);
		}
		LuaObject.addMember(l, name22, get22, Lua_BlackJack_ProjectL_UI_BattleSceneUIController.<>f__mg$cache62, true);
		string name23 = "m_damageNumberStrongPrefab";
		if (Lua_BlackJack_ProjectL_UI_BattleSceneUIController.<>f__mg$cache63 == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleSceneUIController.<>f__mg$cache63 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleSceneUIController.get_m_damageNumberStrongPrefab);
		}
		LuaCSFunction get23 = Lua_BlackJack_ProjectL_UI_BattleSceneUIController.<>f__mg$cache63;
		if (Lua_BlackJack_ProjectL_UI_BattleSceneUIController.<>f__mg$cache64 == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleSceneUIController.<>f__mg$cache64 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleSceneUIController.set_m_damageNumberStrongPrefab);
		}
		LuaObject.addMember(l, name23, get23, Lua_BlackJack_ProjectL_UI_BattleSceneUIController.<>f__mg$cache64, true);
		string name24 = "m_damageNumberCriticalPrefab";
		if (Lua_BlackJack_ProjectL_UI_BattleSceneUIController.<>f__mg$cache65 == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleSceneUIController.<>f__mg$cache65 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleSceneUIController.get_m_damageNumberCriticalPrefab);
		}
		LuaCSFunction get24 = Lua_BlackJack_ProjectL_UI_BattleSceneUIController.<>f__mg$cache65;
		if (Lua_BlackJack_ProjectL_UI_BattleSceneUIController.<>f__mg$cache66 == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleSceneUIController.<>f__mg$cache66 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleSceneUIController.set_m_damageNumberCriticalPrefab);
		}
		LuaObject.addMember(l, name24, get24, Lua_BlackJack_ProjectL_UI_BattleSceneUIController.<>f__mg$cache66, true);
		string name25 = "m_damageNumberSoldierPrefab";
		if (Lua_BlackJack_ProjectL_UI_BattleSceneUIController.<>f__mg$cache67 == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleSceneUIController.<>f__mg$cache67 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleSceneUIController.get_m_damageNumberSoldierPrefab);
		}
		LuaCSFunction get25 = Lua_BlackJack_ProjectL_UI_BattleSceneUIController.<>f__mg$cache67;
		if (Lua_BlackJack_ProjectL_UI_BattleSceneUIController.<>f__mg$cache68 == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleSceneUIController.<>f__mg$cache68 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleSceneUIController.set_m_damageNumberSoldierPrefab);
		}
		LuaObject.addMember(l, name25, get25, Lua_BlackJack_ProjectL_UI_BattleSceneUIController.<>f__mg$cache68, true);
		string name26 = "m_healNumberPrefab";
		if (Lua_BlackJack_ProjectL_UI_BattleSceneUIController.<>f__mg$cache69 == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleSceneUIController.<>f__mg$cache69 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleSceneUIController.get_m_healNumberPrefab);
		}
		LuaCSFunction get26 = Lua_BlackJack_ProjectL_UI_BattleSceneUIController.<>f__mg$cache69;
		if (Lua_BlackJack_ProjectL_UI_BattleSceneUIController.<>f__mg$cache6A == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleSceneUIController.<>f__mg$cache6A = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleSceneUIController.set_m_healNumberPrefab);
		}
		LuaObject.addMember(l, name26, get26, Lua_BlackJack_ProjectL_UI_BattleSceneUIController.<>f__mg$cache6A, true);
		string name27 = "m_immunePrefab";
		if (Lua_BlackJack_ProjectL_UI_BattleSceneUIController.<>f__mg$cache6B == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleSceneUIController.<>f__mg$cache6B = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleSceneUIController.get_m_immunePrefab);
		}
		LuaCSFunction get27 = Lua_BlackJack_ProjectL_UI_BattleSceneUIController.<>f__mg$cache6B;
		if (Lua_BlackJack_ProjectL_UI_BattleSceneUIController.<>f__mg$cache6C == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleSceneUIController.<>f__mg$cache6C = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleSceneUIController.set_m_immunePrefab);
		}
		LuaObject.addMember(l, name27, get27, Lua_BlackJack_ProjectL_UI_BattleSceneUIController.<>f__mg$cache6C, true);
		string name28 = "m_target1Prefab";
		if (Lua_BlackJack_ProjectL_UI_BattleSceneUIController.<>f__mg$cache6D == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleSceneUIController.<>f__mg$cache6D = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleSceneUIController.get_m_target1Prefab);
		}
		LuaCSFunction get28 = Lua_BlackJack_ProjectL_UI_BattleSceneUIController.<>f__mg$cache6D;
		if (Lua_BlackJack_ProjectL_UI_BattleSceneUIController.<>f__mg$cache6E == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleSceneUIController.<>f__mg$cache6E = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleSceneUIController.set_m_target1Prefab);
		}
		LuaObject.addMember(l, name28, get28, Lua_BlackJack_ProjectL_UI_BattleSceneUIController.<>f__mg$cache6E, true);
		string name29 = "m_target2Prefab";
		if (Lua_BlackJack_ProjectL_UI_BattleSceneUIController.<>f__mg$cache6F == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleSceneUIController.<>f__mg$cache6F = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleSceneUIController.get_m_target2Prefab);
		}
		LuaCSFunction get29 = Lua_BlackJack_ProjectL_UI_BattleSceneUIController.<>f__mg$cache6F;
		if (Lua_BlackJack_ProjectL_UI_BattleSceneUIController.<>f__mg$cache70 == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleSceneUIController.<>f__mg$cache70 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleSceneUIController.set_m_target2Prefab);
		}
		LuaObject.addMember(l, name29, get29, Lua_BlackJack_ProjectL_UI_BattleSceneUIController.<>f__mg$cache70, true);
		string name30 = "m_target3Prefab";
		if (Lua_BlackJack_ProjectL_UI_BattleSceneUIController.<>f__mg$cache71 == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleSceneUIController.<>f__mg$cache71 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleSceneUIController.get_m_target3Prefab);
		}
		LuaCSFunction get30 = Lua_BlackJack_ProjectL_UI_BattleSceneUIController.<>f__mg$cache71;
		if (Lua_BlackJack_ProjectL_UI_BattleSceneUIController.<>f__mg$cache72 == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleSceneUIController.<>f__mg$cache72 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleSceneUIController.set_m_target3Prefab);
		}
		LuaObject.addMember(l, name30, get30, Lua_BlackJack_ProjectL_UI_BattleSceneUIController.<>f__mg$cache72, true);
		string name31 = "m_target4Prefab";
		if (Lua_BlackJack_ProjectL_UI_BattleSceneUIController.<>f__mg$cache73 == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleSceneUIController.<>f__mg$cache73 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleSceneUIController.get_m_target4Prefab);
		}
		LuaCSFunction get31 = Lua_BlackJack_ProjectL_UI_BattleSceneUIController.<>f__mg$cache73;
		if (Lua_BlackJack_ProjectL_UI_BattleSceneUIController.<>f__mg$cache74 == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleSceneUIController.<>f__mg$cache74 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleSceneUIController.set_m_target4Prefab);
		}
		LuaObject.addMember(l, name31, get31, Lua_BlackJack_ProjectL_UI_BattleSceneUIController.<>f__mg$cache74, true);
		string name32 = "m_target5Prefab";
		if (Lua_BlackJack_ProjectL_UI_BattleSceneUIController.<>f__mg$cache75 == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleSceneUIController.<>f__mg$cache75 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleSceneUIController.get_m_target5Prefab);
		}
		LuaCSFunction get32 = Lua_BlackJack_ProjectL_UI_BattleSceneUIController.<>f__mg$cache75;
		if (Lua_BlackJack_ProjectL_UI_BattleSceneUIController.<>f__mg$cache76 == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleSceneUIController.<>f__mg$cache76 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleSceneUIController.set_m_target5Prefab);
		}
		LuaObject.addMember(l, name32, get32, Lua_BlackJack_ProjectL_UI_BattleSceneUIController.<>f__mg$cache76, true);
		string name33 = "m_target6Prefab";
		if (Lua_BlackJack_ProjectL_UI_BattleSceneUIController.<>f__mg$cache77 == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleSceneUIController.<>f__mg$cache77 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleSceneUIController.get_m_target6Prefab);
		}
		LuaCSFunction get33 = Lua_BlackJack_ProjectL_UI_BattleSceneUIController.<>f__mg$cache77;
		if (Lua_BlackJack_ProjectL_UI_BattleSceneUIController.<>f__mg$cache78 == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleSceneUIController.<>f__mg$cache78 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleSceneUIController.set_m_target6Prefab);
		}
		LuaObject.addMember(l, name33, get33, Lua_BlackJack_ProjectL_UI_BattleSceneUIController.<>f__mg$cache78, true);
		string name34 = "m_canActionPrefab";
		if (Lua_BlackJack_ProjectL_UI_BattleSceneUIController.<>f__mg$cache79 == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleSceneUIController.<>f__mg$cache79 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleSceneUIController.get_m_canActionPrefab);
		}
		LuaCSFunction get34 = Lua_BlackJack_ProjectL_UI_BattleSceneUIController.<>f__mg$cache79;
		if (Lua_BlackJack_ProjectL_UI_BattleSceneUIController.<>f__mg$cache7A == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleSceneUIController.<>f__mg$cache7A = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleSceneUIController.set_m_canActionPrefab);
		}
		LuaObject.addMember(l, name34, get34, Lua_BlackJack_ProjectL_UI_BattleSceneUIController.<>f__mg$cache7A, true);
		string name35 = "m_clientBattle";
		if (Lua_BlackJack_ProjectL_UI_BattleSceneUIController.<>f__mg$cache7B == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleSceneUIController.<>f__mg$cache7B = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleSceneUIController.get_m_clientBattle);
		}
		LuaCSFunction get35 = Lua_BlackJack_ProjectL_UI_BattleSceneUIController.<>f__mg$cache7B;
		if (Lua_BlackJack_ProjectL_UI_BattleSceneUIController.<>f__mg$cache7C == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleSceneUIController.<>f__mg$cache7C = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleSceneUIController.set_m_clientBattle);
		}
		LuaObject.addMember(l, name35, get35, Lua_BlackJack_ProjectL_UI_BattleSceneUIController.<>f__mg$cache7C, true);
		string name36 = "m_damageNumberPool";
		if (Lua_BlackJack_ProjectL_UI_BattleSceneUIController.<>f__mg$cache7D == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleSceneUIController.<>f__mg$cache7D = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleSceneUIController.get_m_damageNumberPool);
		}
		LuaCSFunction get36 = Lua_BlackJack_ProjectL_UI_BattleSceneUIController.<>f__mg$cache7D;
		if (Lua_BlackJack_ProjectL_UI_BattleSceneUIController.<>f__mg$cache7E == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleSceneUIController.<>f__mg$cache7E = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleSceneUIController.set_m_damageNumberPool);
		}
		LuaObject.addMember(l, name36, get36, Lua_BlackJack_ProjectL_UI_BattleSceneUIController.<>f__mg$cache7E, true);
		string name37 = "m_damageNumberWeakPool";
		if (Lua_BlackJack_ProjectL_UI_BattleSceneUIController.<>f__mg$cache7F == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleSceneUIController.<>f__mg$cache7F = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleSceneUIController.get_m_damageNumberWeakPool);
		}
		LuaCSFunction get37 = Lua_BlackJack_ProjectL_UI_BattleSceneUIController.<>f__mg$cache7F;
		if (Lua_BlackJack_ProjectL_UI_BattleSceneUIController.<>f__mg$cache80 == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleSceneUIController.<>f__mg$cache80 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleSceneUIController.set_m_damageNumberWeakPool);
		}
		LuaObject.addMember(l, name37, get37, Lua_BlackJack_ProjectL_UI_BattleSceneUIController.<>f__mg$cache80, true);
		string name38 = "m_damageNumberStrongPool";
		if (Lua_BlackJack_ProjectL_UI_BattleSceneUIController.<>f__mg$cache81 == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleSceneUIController.<>f__mg$cache81 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleSceneUIController.get_m_damageNumberStrongPool);
		}
		LuaCSFunction get38 = Lua_BlackJack_ProjectL_UI_BattleSceneUIController.<>f__mg$cache81;
		if (Lua_BlackJack_ProjectL_UI_BattleSceneUIController.<>f__mg$cache82 == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleSceneUIController.<>f__mg$cache82 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleSceneUIController.set_m_damageNumberStrongPool);
		}
		LuaObject.addMember(l, name38, get38, Lua_BlackJack_ProjectL_UI_BattleSceneUIController.<>f__mg$cache82, true);
		string name39 = "m_damageNumberCriticalPool";
		if (Lua_BlackJack_ProjectL_UI_BattleSceneUIController.<>f__mg$cache83 == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleSceneUIController.<>f__mg$cache83 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleSceneUIController.get_m_damageNumberCriticalPool);
		}
		LuaCSFunction get39 = Lua_BlackJack_ProjectL_UI_BattleSceneUIController.<>f__mg$cache83;
		if (Lua_BlackJack_ProjectL_UI_BattleSceneUIController.<>f__mg$cache84 == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleSceneUIController.<>f__mg$cache84 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleSceneUIController.set_m_damageNumberCriticalPool);
		}
		LuaObject.addMember(l, name39, get39, Lua_BlackJack_ProjectL_UI_BattleSceneUIController.<>f__mg$cache84, true);
		string name40 = "m_damageNumberSoldierPool";
		if (Lua_BlackJack_ProjectL_UI_BattleSceneUIController.<>f__mg$cache85 == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleSceneUIController.<>f__mg$cache85 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleSceneUIController.get_m_damageNumberSoldierPool);
		}
		LuaCSFunction get40 = Lua_BlackJack_ProjectL_UI_BattleSceneUIController.<>f__mg$cache85;
		if (Lua_BlackJack_ProjectL_UI_BattleSceneUIController.<>f__mg$cache86 == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleSceneUIController.<>f__mg$cache86 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleSceneUIController.set_m_damageNumberSoldierPool);
		}
		LuaObject.addMember(l, name40, get40, Lua_BlackJack_ProjectL_UI_BattleSceneUIController.<>f__mg$cache86, true);
		string name41 = "m_healNumberPool";
		if (Lua_BlackJack_ProjectL_UI_BattleSceneUIController.<>f__mg$cache87 == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleSceneUIController.<>f__mg$cache87 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleSceneUIController.get_m_healNumberPool);
		}
		LuaCSFunction get41 = Lua_BlackJack_ProjectL_UI_BattleSceneUIController.<>f__mg$cache87;
		if (Lua_BlackJack_ProjectL_UI_BattleSceneUIController.<>f__mg$cache88 == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleSceneUIController.<>f__mg$cache88 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleSceneUIController.set_m_healNumberPool);
		}
		LuaObject.addMember(l, name41, get41, Lua_BlackJack_ProjectL_UI_BattleSceneUIController.<>f__mg$cache88, true);
		string name42 = "m_immunePool";
		if (Lua_BlackJack_ProjectL_UI_BattleSceneUIController.<>f__mg$cache89 == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleSceneUIController.<>f__mg$cache89 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleSceneUIController.get_m_immunePool);
		}
		LuaCSFunction get42 = Lua_BlackJack_ProjectL_UI_BattleSceneUIController.<>f__mg$cache89;
		if (Lua_BlackJack_ProjectL_UI_BattleSceneUIController.<>f__mg$cache8A == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleSceneUIController.<>f__mg$cache8A = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleSceneUIController.set_m_immunePool);
		}
		LuaObject.addMember(l, name42, get42, Lua_BlackJack_ProjectL_UI_BattleSceneUIController.<>f__mg$cache8A, true);
		string name43 = "m_targetIconPools";
		if (Lua_BlackJack_ProjectL_UI_BattleSceneUIController.<>f__mg$cache8B == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleSceneUIController.<>f__mg$cache8B = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleSceneUIController.get_m_targetIconPools);
		}
		LuaCSFunction get43 = Lua_BlackJack_ProjectL_UI_BattleSceneUIController.<>f__mg$cache8B;
		if (Lua_BlackJack_ProjectL_UI_BattleSceneUIController.<>f__mg$cache8C == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleSceneUIController.<>f__mg$cache8C = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleSceneUIController.set_m_targetIconPools);
		}
		LuaObject.addMember(l, name43, get43, Lua_BlackJack_ProjectL_UI_BattleSceneUIController.<>f__mg$cache8C, true);
		string name44 = "m_canActionIconPool";
		if (Lua_BlackJack_ProjectL_UI_BattleSceneUIController.<>f__mg$cache8D == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleSceneUIController.<>f__mg$cache8D = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleSceneUIController.get_m_canActionIconPool);
		}
		LuaCSFunction get44 = Lua_BlackJack_ProjectL_UI_BattleSceneUIController.<>f__mg$cache8D;
		if (Lua_BlackJack_ProjectL_UI_BattleSceneUIController.<>f__mg$cache8E == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleSceneUIController.<>f__mg$cache8E = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleSceneUIController.set_m_canActionIconPool);
		}
		LuaObject.addMember(l, name44, get44, Lua_BlackJack_ProjectL_UI_BattleSceneUIController.<>f__mg$cache8E, true);
		string name45 = "m_hideTargetIconTime";
		if (Lua_BlackJack_ProjectL_UI_BattleSceneUIController.<>f__mg$cache8F == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleSceneUIController.<>f__mg$cache8F = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleSceneUIController.get_m_hideTargetIconTime);
		}
		LuaCSFunction get45 = Lua_BlackJack_ProjectL_UI_BattleSceneUIController.<>f__mg$cache8F;
		if (Lua_BlackJack_ProjectL_UI_BattleSceneUIController.<>f__mg$cache90 == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleSceneUIController.<>f__mg$cache90 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleSceneUIController.set_m_hideTargetIconTime);
		}
		LuaObject.addMember(l, name45, get45, Lua_BlackJack_ProjectL_UI_BattleSceneUIController.<>f__mg$cache90, true);
		string name46 = "InvalidPointerID";
		if (Lua_BlackJack_ProjectL_UI_BattleSceneUIController.<>f__mg$cache91 == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleSceneUIController.<>f__mg$cache91 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleSceneUIController.get_InvalidPointerID);
		}
		LuaObject.addMember(l, name46, Lua_BlackJack_ProjectL_UI_BattleSceneUIController.<>f__mg$cache91, null, false);
		string name47 = "m_downPointerId";
		if (Lua_BlackJack_ProjectL_UI_BattleSceneUIController.<>f__mg$cache92 == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleSceneUIController.<>f__mg$cache92 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleSceneUIController.get_m_downPointerId);
		}
		LuaCSFunction get46 = Lua_BlackJack_ProjectL_UI_BattleSceneUIController.<>f__mg$cache92;
		if (Lua_BlackJack_ProjectL_UI_BattleSceneUIController.<>f__mg$cache93 == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleSceneUIController.<>f__mg$cache93 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleSceneUIController.set_m_downPointerId);
		}
		LuaObject.addMember(l, name47, get46, Lua_BlackJack_ProjectL_UI_BattleSceneUIController.<>f__mg$cache93, true);
		string name48 = "m_clickPointerId";
		if (Lua_BlackJack_ProjectL_UI_BattleSceneUIController.<>f__mg$cache94 == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleSceneUIController.<>f__mg$cache94 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleSceneUIController.get_m_clickPointerId);
		}
		LuaCSFunction get47 = Lua_BlackJack_ProjectL_UI_BattleSceneUIController.<>f__mg$cache94;
		if (Lua_BlackJack_ProjectL_UI_BattleSceneUIController.<>f__mg$cache95 == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleSceneUIController.<>f__mg$cache95 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleSceneUIController.set_m_clickPointerId);
		}
		LuaObject.addMember(l, name48, get47, Lua_BlackJack_ProjectL_UI_BattleSceneUIController.<>f__mg$cache95, true);
		string name49 = "m_dragPointerId";
		if (Lua_BlackJack_ProjectL_UI_BattleSceneUIController.<>f__mg$cache96 == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleSceneUIController.<>f__mg$cache96 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleSceneUIController.get_m_dragPointerId);
		}
		LuaCSFunction get48 = Lua_BlackJack_ProjectL_UI_BattleSceneUIController.<>f__mg$cache96;
		if (Lua_BlackJack_ProjectL_UI_BattleSceneUIController.<>f__mg$cache97 == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleSceneUIController.<>f__mg$cache97 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleSceneUIController.set_m_dragPointerId);
		}
		LuaObject.addMember(l, name49, get48, Lua_BlackJack_ProjectL_UI_BattleSceneUIController.<>f__mg$cache97, true);
		string name50 = "m_is3DTouchTriggered";
		if (Lua_BlackJack_ProjectL_UI_BattleSceneUIController.<>f__mg$cache98 == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleSceneUIController.<>f__mg$cache98 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleSceneUIController.get_m_is3DTouchTriggered);
		}
		LuaCSFunction get49 = Lua_BlackJack_ProjectL_UI_BattleSceneUIController.<>f__mg$cache98;
		if (Lua_BlackJack_ProjectL_UI_BattleSceneUIController.<>f__mg$cache99 == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleSceneUIController.<>f__mg$cache99 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleSceneUIController.set_m_is3DTouchTriggered);
		}
		LuaObject.addMember(l, name50, get49, Lua_BlackJack_ProjectL_UI_BattleSceneUIController.<>f__mg$cache99, true);
		LuaObject.createTypeMetatable(l, null, typeof(BattleSceneUIController), typeof(UIControllerBase));
	}

	// Token: 0x040121B4 RID: 74164
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache0;

	// Token: 0x040121B5 RID: 74165
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1;

	// Token: 0x040121B6 RID: 74166
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2;

	// Token: 0x040121B7 RID: 74167
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3;

	// Token: 0x040121B8 RID: 74168
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache4;

	// Token: 0x040121B9 RID: 74169
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache5;

	// Token: 0x040121BA RID: 74170
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache6;

	// Token: 0x040121BB RID: 74171
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache7;

	// Token: 0x040121BC RID: 74172
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache8;

	// Token: 0x040121BD RID: 74173
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache9;

	// Token: 0x040121BE RID: 74174
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheA;

	// Token: 0x040121BF RID: 74175
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheB;

	// Token: 0x040121C0 RID: 74176
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheC;

	// Token: 0x040121C1 RID: 74177
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheD;

	// Token: 0x040121C2 RID: 74178
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheE;

	// Token: 0x040121C3 RID: 74179
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheF;

	// Token: 0x040121C4 RID: 74180
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache10;

	// Token: 0x040121C5 RID: 74181
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache11;

	// Token: 0x040121C6 RID: 74182
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache12;

	// Token: 0x040121C7 RID: 74183
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache13;

	// Token: 0x040121C8 RID: 74184
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache14;

	// Token: 0x040121C9 RID: 74185
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache15;

	// Token: 0x040121CA RID: 74186
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache16;

	// Token: 0x040121CB RID: 74187
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache17;

	// Token: 0x040121CC RID: 74188
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache18;

	// Token: 0x040121CD RID: 74189
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache19;

	// Token: 0x040121CE RID: 74190
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1A;

	// Token: 0x040121CF RID: 74191
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1B;

	// Token: 0x040121D0 RID: 74192
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1C;

	// Token: 0x040121D1 RID: 74193
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1D;

	// Token: 0x040121D2 RID: 74194
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1E;

	// Token: 0x040121D3 RID: 74195
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1F;

	// Token: 0x040121D4 RID: 74196
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache20;

	// Token: 0x040121D5 RID: 74197
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache21;

	// Token: 0x040121D6 RID: 74198
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache22;

	// Token: 0x040121D7 RID: 74199
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache23;

	// Token: 0x040121D8 RID: 74200
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache24;

	// Token: 0x040121D9 RID: 74201
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache25;

	// Token: 0x040121DA RID: 74202
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache26;

	// Token: 0x040121DB RID: 74203
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache27;

	// Token: 0x040121DC RID: 74204
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache28;

	// Token: 0x040121DD RID: 74205
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache29;

	// Token: 0x040121DE RID: 74206
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2A;

	// Token: 0x040121DF RID: 74207
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2B;

	// Token: 0x040121E0 RID: 74208
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2C;

	// Token: 0x040121E1 RID: 74209
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2D;

	// Token: 0x040121E2 RID: 74210
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2E;

	// Token: 0x040121E3 RID: 74211
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2F;

	// Token: 0x040121E4 RID: 74212
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache30;

	// Token: 0x040121E5 RID: 74213
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache31;

	// Token: 0x040121E6 RID: 74214
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache32;

	// Token: 0x040121E7 RID: 74215
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache33;

	// Token: 0x040121E8 RID: 74216
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache34;

	// Token: 0x040121E9 RID: 74217
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache35;

	// Token: 0x040121EA RID: 74218
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache36;

	// Token: 0x040121EB RID: 74219
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache37;

	// Token: 0x040121EC RID: 74220
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache38;

	// Token: 0x040121ED RID: 74221
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache39;

	// Token: 0x040121EE RID: 74222
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3A;

	// Token: 0x040121EF RID: 74223
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3B;

	// Token: 0x040121F0 RID: 74224
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3C;

	// Token: 0x040121F1 RID: 74225
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3D;

	// Token: 0x040121F2 RID: 74226
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3E;

	// Token: 0x040121F3 RID: 74227
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3F;

	// Token: 0x040121F4 RID: 74228
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache40;

	// Token: 0x040121F5 RID: 74229
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache41;

	// Token: 0x040121F6 RID: 74230
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache42;

	// Token: 0x040121F7 RID: 74231
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache43;

	// Token: 0x040121F8 RID: 74232
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache44;

	// Token: 0x040121F9 RID: 74233
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache45;

	// Token: 0x040121FA RID: 74234
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache46;

	// Token: 0x040121FB RID: 74235
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache47;

	// Token: 0x040121FC RID: 74236
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache48;

	// Token: 0x040121FD RID: 74237
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache49;

	// Token: 0x040121FE RID: 74238
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache4A;

	// Token: 0x040121FF RID: 74239
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache4B;

	// Token: 0x04012200 RID: 74240
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache4C;

	// Token: 0x04012201 RID: 74241
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache4D;

	// Token: 0x04012202 RID: 74242
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache4E;

	// Token: 0x04012203 RID: 74243
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache4F;

	// Token: 0x04012204 RID: 74244
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache50;

	// Token: 0x04012205 RID: 74245
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache51;

	// Token: 0x04012206 RID: 74246
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache52;

	// Token: 0x04012207 RID: 74247
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache53;

	// Token: 0x04012208 RID: 74248
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache54;

	// Token: 0x04012209 RID: 74249
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache55;

	// Token: 0x0401220A RID: 74250
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache56;

	// Token: 0x0401220B RID: 74251
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache57;

	// Token: 0x0401220C RID: 74252
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache58;

	// Token: 0x0401220D RID: 74253
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache59;

	// Token: 0x0401220E RID: 74254
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache5A;

	// Token: 0x0401220F RID: 74255
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache5B;

	// Token: 0x04012210 RID: 74256
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache5C;

	// Token: 0x04012211 RID: 74257
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache5D;

	// Token: 0x04012212 RID: 74258
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache5E;

	// Token: 0x04012213 RID: 74259
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache5F;

	// Token: 0x04012214 RID: 74260
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache60;

	// Token: 0x04012215 RID: 74261
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache61;

	// Token: 0x04012216 RID: 74262
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache62;

	// Token: 0x04012217 RID: 74263
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache63;

	// Token: 0x04012218 RID: 74264
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache64;

	// Token: 0x04012219 RID: 74265
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache65;

	// Token: 0x0401221A RID: 74266
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache66;

	// Token: 0x0401221B RID: 74267
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache67;

	// Token: 0x0401221C RID: 74268
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache68;

	// Token: 0x0401221D RID: 74269
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache69;

	// Token: 0x0401221E RID: 74270
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache6A;

	// Token: 0x0401221F RID: 74271
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache6B;

	// Token: 0x04012220 RID: 74272
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache6C;

	// Token: 0x04012221 RID: 74273
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache6D;

	// Token: 0x04012222 RID: 74274
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache6E;

	// Token: 0x04012223 RID: 74275
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache6F;

	// Token: 0x04012224 RID: 74276
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache70;

	// Token: 0x04012225 RID: 74277
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache71;

	// Token: 0x04012226 RID: 74278
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache72;

	// Token: 0x04012227 RID: 74279
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache73;

	// Token: 0x04012228 RID: 74280
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache74;

	// Token: 0x04012229 RID: 74281
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache75;

	// Token: 0x0401222A RID: 74282
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache76;

	// Token: 0x0401222B RID: 74283
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache77;

	// Token: 0x0401222C RID: 74284
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache78;

	// Token: 0x0401222D RID: 74285
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache79;

	// Token: 0x0401222E RID: 74286
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache7A;

	// Token: 0x0401222F RID: 74287
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache7B;

	// Token: 0x04012230 RID: 74288
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache7C;

	// Token: 0x04012231 RID: 74289
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache7D;

	// Token: 0x04012232 RID: 74290
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache7E;

	// Token: 0x04012233 RID: 74291
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache7F;

	// Token: 0x04012234 RID: 74292
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache80;

	// Token: 0x04012235 RID: 74293
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache81;

	// Token: 0x04012236 RID: 74294
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache82;

	// Token: 0x04012237 RID: 74295
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache83;

	// Token: 0x04012238 RID: 74296
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache84;

	// Token: 0x04012239 RID: 74297
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache85;

	// Token: 0x0401223A RID: 74298
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache86;

	// Token: 0x0401223B RID: 74299
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache87;

	// Token: 0x0401223C RID: 74300
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache88;

	// Token: 0x0401223D RID: 74301
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache89;

	// Token: 0x0401223E RID: 74302
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache8A;

	// Token: 0x0401223F RID: 74303
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache8B;

	// Token: 0x04012240 RID: 74304
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache8C;

	// Token: 0x04012241 RID: 74305
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache8D;

	// Token: 0x04012242 RID: 74306
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache8E;

	// Token: 0x04012243 RID: 74307
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache8F;

	// Token: 0x04012244 RID: 74308
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache90;

	// Token: 0x04012245 RID: 74309
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache91;

	// Token: 0x04012246 RID: 74310
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache92;

	// Token: 0x04012247 RID: 74311
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache93;

	// Token: 0x04012248 RID: 74312
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache94;

	// Token: 0x04012249 RID: 74313
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache95;

	// Token: 0x0401224A RID: 74314
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache96;

	// Token: 0x0401224B RID: 74315
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache97;

	// Token: 0x0401224C RID: 74316
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache98;

	// Token: 0x0401224D RID: 74317
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache99;
}
