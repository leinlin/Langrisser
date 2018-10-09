using System;
using System.Runtime.CompilerServices;
using BlackJack.ConfigData;
using BlackJack.ProjectL.Common;
using BlackJack.ProjectL.Scene;
using BlackJack.ProjectL.UI;
using SLua;
using UnityEngine;
using UnityEngine.Scripting;

// Token: 0x020013AD RID: 5037
[Preserve]
public class Lua_BlackJack_ProjectL_UI_BattlePrepareStageActor : LuaObject
{
	// Token: 0x0601BBC7 RID: 113607 RVA: 0x008782C8 File Offset: 0x008764C8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int constructor(IntPtr l)
	{
		int result;
		try
		{
			ClientBattle clientBattle;
			LuaObject.checkType<ClientBattle>(l, 2, out clientBattle);
			BattlePrepareStageActor o = new BattlePrepareStageActor(clientBattle);
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

	// Token: 0x0601BBC8 RID: 113608 RVA: 0x0087831C File Offset: 0x0087651C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int Destroy(IntPtr l)
	{
		int result;
		try
		{
			BattlePrepareStageActor battlePrepareStageActor = (BattlePrepareStageActor)LuaObject.checkSelf(l);
			battlePrepareStageActor.Destroy();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601BBC9 RID: 113609 RVA: 0x00878368 File Offset: 0x00876568
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int Setup(IntPtr l)
	{
		int result;
		try
		{
			BattlePrepareStageActor battlePrepareStageActor = (BattlePrepareStageActor)LuaObject.checkSelf(l);
			BattleHero hero;
			LuaObject.checkType<BattleHero>(l, 2, out hero);
			int team;
			LuaObject.checkType(l, 3, out team);
			StagePositionType posType;
			LuaObject.checkEnum<StagePositionType>(l, 4, out posType);
			StageActorTagType tagType;
			LuaObject.checkEnum<StageActorTagType>(l, 5, out tagType);
			int behaviorId;
			LuaObject.checkType(l, 6, out behaviorId);
			int groupId;
			LuaObject.checkType(l, 7, out groupId);
			int playerIndex;
			LuaObject.checkType(l, 8, out playerIndex);
			bool isSkipGraphic;
			LuaObject.checkType(l, 9, out isSkipGraphic);
			battlePrepareStageActor.Setup(hero, team, posType, tagType, behaviorId, groupId, playerIndex, isSkipGraphic);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601BBCA RID: 113610 RVA: 0x00878418 File Offset: 0x00876618
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int GetHero(IntPtr l)
	{
		int result;
		try
		{
			BattlePrepareStageActor battlePrepareStageActor = (BattlePrepareStageActor)LuaObject.checkSelf(l);
			BattleHero hero = battlePrepareStageActor.GetHero();
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, hero);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601BBCB RID: 113611 RVA: 0x0087846C File Offset: 0x0087666C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int GetHeroId(IntPtr l)
	{
		int result;
		try
		{
			BattlePrepareStageActor battlePrepareStageActor = (BattlePrepareStageActor)LuaObject.checkSelf(l);
			int heroId = battlePrepareStageActor.GetHeroId();
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, heroId);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601BBCC RID: 113612 RVA: 0x008784C0 File Offset: 0x008766C0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int GetSoldierId(IntPtr l)
	{
		int result;
		try
		{
			BattlePrepareStageActor battlePrepareStageActor = (BattlePrepareStageActor)LuaObject.checkSelf(l);
			int soldierId = battlePrepareStageActor.GetSoldierId();
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, soldierId);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601BBCD RID: 113613 RVA: 0x00878514 File Offset: 0x00876714
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int SetHp(IntPtr l)
	{
		int result;
		try
		{
			BattlePrepareStageActor battlePrepareStageActor = (BattlePrepareStageActor)LuaObject.checkSelf(l);
			int heroHp;
			LuaObject.checkType(l, 2, out heroHp);
			int heroHpMax;
			LuaObject.checkType(l, 3, out heroHpMax);
			int soldierHp;
			LuaObject.checkType(l, 4, out soldierHp);
			int soldierHpMax;
			LuaObject.checkType(l, 5, out soldierHpMax);
			battlePrepareStageActor.SetHp(heroHp, heroHpMax, soldierHp, soldierHpMax);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601BBCE RID: 113614 RVA: 0x00878594 File Offset: 0x00876794
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int GetHeroHp(IntPtr l)
	{
		int result;
		try
		{
			BattlePrepareStageActor battlePrepareStageActor = (BattlePrepareStageActor)LuaObject.checkSelf(l);
			int heroHp = battlePrepareStageActor.GetHeroHp();
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, heroHp);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601BBCF RID: 113615 RVA: 0x008785E8 File Offset: 0x008767E8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int GetSoldierHp(IntPtr l)
	{
		int result;
		try
		{
			BattlePrepareStageActor battlePrepareStageActor = (BattlePrepareStageActor)LuaObject.checkSelf(l);
			int soldierHp = battlePrepareStageActor.GetSoldierHp();
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, soldierHp);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601BBD0 RID: 113616 RVA: 0x0087863C File Offset: 0x0087683C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int SetExtraTalentSkillInfo(IntPtr l)
	{
		int result;
		try
		{
			BattlePrepareStageActor battlePrepareStageActor = (BattlePrepareStageActor)LuaObject.checkSelf(l);
			ConfigDataSkillInfo extraTalentSkillInfo;
			LuaObject.checkType<ConfigDataSkillInfo>(l, 2, out extraTalentSkillInfo);
			battlePrepareStageActor.SetExtraTalentSkillInfo(extraTalentSkillInfo);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601BBD1 RID: 113617 RVA: 0x00878694 File Offset: 0x00876894
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int GetExtraTalentSkillInfo(IntPtr l)
	{
		int result;
		try
		{
			BattlePrepareStageActor battlePrepareStageActor = (BattlePrepareStageActor)LuaObject.checkSelf(l);
			ConfigDataSkillInfo extraTalentSkillInfo = battlePrepareStageActor.GetExtraTalentSkillInfo();
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, extraTalentSkillInfo);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601BBD2 RID: 113618 RVA: 0x008786E8 File Offset: 0x008768E8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int SetPosition(IntPtr l)
	{
		int result;
		try
		{
			BattlePrepareStageActor battlePrepareStageActor = (BattlePrepareStageActor)LuaObject.checkSelf(l);
			GridPosition p;
			LuaObject.checkValueType<GridPosition>(l, 2, out p);
			int dir;
			LuaObject.checkType(l, 3, out dir);
			battlePrepareStageActor.SetPosition(p, dir);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601BBD3 RID: 113619 RVA: 0x0087874C File Offset: 0x0087694C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int SetGray(IntPtr l)
	{
		int result;
		try
		{
			BattlePrepareStageActor battlePrepareStageActor = (BattlePrepareStageActor)LuaObject.checkSelf(l);
			bool gray;
			LuaObject.checkType(l, 2, out gray);
			battlePrepareStageActor.SetGray(gray);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601BBD4 RID: 113620 RVA: 0x008787A4 File Offset: 0x008769A4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int SetChooseEffect(IntPtr l)
	{
		int result;
		try
		{
			BattlePrepareStageActor battlePrepareStageActor = (BattlePrepareStageActor)LuaObject.checkSelf(l);
			bool chooseEffect;
			LuaObject.checkType(l, 2, out chooseEffect);
			battlePrepareStageActor.SetChooseEffect(chooseEffect);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601BBD5 RID: 113621 RVA: 0x008787FC File Offset: 0x008769FC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int IsGray(IntPtr l)
	{
		int result;
		try
		{
			BattlePrepareStageActor battlePrepareStageActor = (BattlePrepareStageActor)LuaObject.checkSelf(l);
			bool b = battlePrepareStageActor.IsGray();
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

	// Token: 0x0601BBD6 RID: 113622 RVA: 0x00878850 File Offset: 0x00876A50
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int ForceUpdateSpine(IntPtr l)
	{
		int result;
		try
		{
			BattlePrepareStageActor battlePrepareStageActor = (BattlePrepareStageActor)LuaObject.checkSelf(l);
			battlePrepareStageActor.ForceUpdateSpine();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601BBD7 RID: 113623 RVA: 0x0087889C File Offset: 0x00876A9C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int GetPosition(IntPtr l)
	{
		int result;
		try
		{
			BattlePrepareStageActor battlePrepareStageActor = (BattlePrepareStageActor)LuaObject.checkSelf(l);
			GridPosition position = battlePrepareStageActor.GetPosition();
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, position);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601BBD8 RID: 113624 RVA: 0x008788F8 File Offset: 0x00876AF8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int GetDirection(IntPtr l)
	{
		int result;
		try
		{
			BattlePrepareStageActor battlePrepareStageActor = (BattlePrepareStageActor)LuaObject.checkSelf(l);
			int direction = battlePrepareStageActor.GetDirection();
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, direction);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601BBD9 RID: 113625 RVA: 0x0087894C File Offset: 0x00876B4C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int GetTeam(IntPtr l)
	{
		int result;
		try
		{
			BattlePrepareStageActor battlePrepareStageActor = (BattlePrepareStageActor)LuaObject.checkSelf(l);
			int team = battlePrepareStageActor.GetTeam();
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, team);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601BBDA RID: 113626 RVA: 0x008789A0 File Offset: 0x00876BA0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int GetPlayerIndex(IntPtr l)
	{
		int result;
		try
		{
			BattlePrepareStageActor battlePrepareStageActor = (BattlePrepareStageActor)LuaObject.checkSelf(l);
			int playerIndex = battlePrepareStageActor.GetPlayerIndex();
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, playerIndex);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601BBDB RID: 113627 RVA: 0x008789F4 File Offset: 0x00876BF4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int GetTagType(IntPtr l)
	{
		int result;
		try
		{
			BattlePrepareStageActor battlePrepareStageActor = (BattlePrepareStageActor)LuaObject.checkSelf(l);
			StageActorTagType tagType = battlePrepareStageActor.GetTagType();
			LuaObject.pushValue(l, true);
			LuaObject.pushEnum(l, (int)tagType);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601BBDC RID: 113628 RVA: 0x00878A48 File Offset: 0x00876C48
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int GetPositionType(IntPtr l)
	{
		int result;
		try
		{
			BattlePrepareStageActor battlePrepareStageActor = (BattlePrepareStageActor)LuaObject.checkSelf(l);
			StagePositionType positionType = battlePrepareStageActor.GetPositionType();
			LuaObject.pushValue(l, true);
			LuaObject.pushEnum(l, (int)positionType);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601BBDD RID: 113629 RVA: 0x00878A9C File Offset: 0x00876C9C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int GetBehaviorId(IntPtr l)
	{
		int result;
		try
		{
			BattlePrepareStageActor battlePrepareStageActor = (BattlePrepareStageActor)LuaObject.checkSelf(l);
			int behaviorId = battlePrepareStageActor.GetBehaviorId();
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, behaviorId);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601BBDE RID: 113630 RVA: 0x00878AF0 File Offset: 0x00876CF0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int GetGroupId(IntPtr l)
	{
		int result;
		try
		{
			BattlePrepareStageActor battlePrepareStageActor = (BattlePrepareStageActor)LuaObject.checkSelf(l);
			int groupId = battlePrepareStageActor.GetGroupId();
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, groupId);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601BBDF RID: 113631 RVA: 0x00878B44 File Offset: 0x00876D44
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int IsNpc(IntPtr l)
	{
		int result;
		try
		{
			BattlePrepareStageActor battlePrepareStageActor = (BattlePrepareStageActor)LuaObject.checkSelf(l);
			bool b = battlePrepareStageActor.IsNpc();
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

	// Token: 0x0601BBE0 RID: 113632 RVA: 0x00878B98 File Offset: 0x00876D98
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int IsAINpc(IntPtr l)
	{
		int result;
		try
		{
			BattlePrepareStageActor battlePrepareStageActor = (BattlePrepareStageActor)LuaObject.checkSelf(l);
			bool b = battlePrepareStageActor.IsAINpc();
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

	// Token: 0x0601BBE1 RID: 113633 RVA: 0x00878BEC File Offset: 0x00876DEC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int IsTeammate(IntPtr l)
	{
		int result;
		try
		{
			BattlePrepareStageActor battlePrepareStageActor = (BattlePrepareStageActor)LuaObject.checkSelf(l);
			bool b = battlePrepareStageActor.IsTeammate();
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

	// Token: 0x0601BBE2 RID: 113634 RVA: 0x00878C40 File Offset: 0x00876E40
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int IsEnforce(IntPtr l)
	{
		int result;
		try
		{
			BattlePrepareStageActor battlePrepareStageActor = (BattlePrepareStageActor)LuaObject.checkSelf(l);
			bool b = battlePrepareStageActor.IsEnforce();
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

	// Token: 0x0601BBE3 RID: 113635 RVA: 0x00878C94 File Offset: 0x00876E94
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int TweenColor(IntPtr l)
	{
		int result;
		try
		{
			BattlePrepareStageActor battlePrepareStageActor = (BattlePrepareStageActor)LuaObject.checkSelf(l);
			Colori c;
			LuaObject.checkValueType<Colori>(l, 2, out c);
			battlePrepareStageActor.TweenColor(c);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601BBE4 RID: 113636 RVA: 0x00878CEC File Offset: 0x00876EEC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int GetUIController(IntPtr l)
	{
		int result;
		try
		{
			BattlePrepareStageActor battlePrepareStageActor = (BattlePrepareStageActor)LuaObject.checkSelf(l);
			BattleActorUIController uicontroller = battlePrepareStageActor.GetUIController();
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, uicontroller);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601BBE5 RID: 113637 RVA: 0x00878D40 File Offset: 0x00876F40
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int TickGraphic(IntPtr l)
	{
		int result;
		try
		{
			BattlePrepareStageActor battlePrepareStageActor = (BattlePrepareStageActor)LuaObject.checkSelf(l);
			float dt;
			LuaObject.checkType(l, 2, out dt);
			battlePrepareStageActor.TickGraphic(dt);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601BBE6 RID: 113638 RVA: 0x00878D98 File Offset: 0x00876F98
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int Pause(IntPtr l)
	{
		int result;
		try
		{
			BattlePrepareStageActor battlePrepareStageActor = (BattlePrepareStageActor)LuaObject.checkSelf(l);
			bool pause;
			LuaObject.checkType(l, 2, out pause);
			battlePrepareStageActor.Pause(pause);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601BBE7 RID: 113639 RVA: 0x00878DF0 File Offset: 0x00876FF0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int DestroyGraphic(IntPtr l)
	{
		int result;
		try
		{
			BattlePrepareStageActor battlePrepareStageActor = (BattlePrepareStageActor)LuaObject.checkSelf(l);
			battlePrepareStageActor.m_luaExportHelper.DestroyGraphic();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601BBE8 RID: 113640 RVA: 0x00878E44 File Offset: 0x00877044
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int DestroyUI(IntPtr l)
	{
		int result;
		try
		{
			BattlePrepareStageActor battlePrepareStageActor = (BattlePrepareStageActor)LuaObject.checkSelf(l);
			battlePrepareStageActor.m_luaExportHelper.DestroyUI();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601BBE9 RID: 113641 RVA: 0x00878E98 File Offset: 0x00877098
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int PlayAnimation(IntPtr l)
	{
		int result;
		try
		{
			BattlePrepareStageActor battlePrepareStageActor = (BattlePrepareStageActor)LuaObject.checkSelf(l);
			string name;
			LuaObject.checkType(l, 2, out name);
			bool loop;
			LuaObject.checkType(l, 3, out loop);
			battlePrepareStageActor.m_luaExportHelper.PlayAnimation(name, loop);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601BBEA RID: 113642 RVA: 0x00878F04 File Offset: 0x00877104
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int ComputeGraphicPosition(IntPtr l)
	{
		int result;
		try
		{
			BattlePrepareStageActor battlePrepareStageActor = (BattlePrepareStageActor)LuaObject.checkSelf(l);
			Vector2 p;
			LuaObject.checkType(l, 2, out p);
			Vector3 o = battlePrepareStageActor.m_luaExportHelper.ComputeGraphicPosition(p);
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

	// Token: 0x0601BBEB RID: 113643 RVA: 0x00878F6C File Offset: 0x0087716C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int ComputeGraphicOffset(IntPtr l)
	{
		int result;
		try
		{
			BattlePrepareStageActor battlePrepareStageActor = (BattlePrepareStageActor)LuaObject.checkSelf(l);
			int idx;
			LuaObject.checkType(l, 2, out idx);
			int dir;
			LuaObject.checkType(l, 3, out dir);
			Vector2 o = battlePrepareStageActor.m_luaExportHelper.ComputeGraphicOffset(idx, dir);
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

	// Token: 0x0601BBEC RID: 113644 RVA: 0x00878FE0 File Offset: 0x008771E0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int ComputeSoldierGraphicCount(IntPtr l)
	{
		int result;
		try
		{
			BattlePrepareStageActor battlePrepareStageActor = (BattlePrepareStageActor)LuaObject.checkSelf(l);
			int soldierHp;
			LuaObject.checkType(l, 2, out soldierHp);
			int soldierHpMax;
			LuaObject.checkType(l, 3, out soldierHpMax);
			int i = battlePrepareStageActor.m_luaExportHelper.ComputeSoldierGraphicCount(soldierHp, soldierHpMax);
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

	// Token: 0x0601BBED RID: 113645 RVA: 0x00879054 File Offset: 0x00877254
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int UpdateGraphicVisible(IntPtr l)
	{
		int result;
		try
		{
			BattlePrepareStageActor battlePrepareStageActor = (BattlePrepareStageActor)LuaObject.checkSelf(l);
			battlePrepareStageActor.m_luaExportHelper.UpdateGraphicVisible();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601BBEE RID: 113646 RVA: 0x008790A8 File Offset: 0x008772A8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_position(IntPtr l)
	{
		int result;
		try
		{
			BattlePrepareStageActor battlePrepareStageActor = (BattlePrepareStageActor)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, battlePrepareStageActor.m_luaExportHelper.m_position);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601BBEF RID: 113647 RVA: 0x00879104 File Offset: 0x00877304
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_position(IntPtr l)
	{
		int result;
		try
		{
			BattlePrepareStageActor battlePrepareStageActor = (BattlePrepareStageActor)LuaObject.checkSelf(l);
			GridPosition position;
			LuaObject.checkValueType<GridPosition>(l, 2, out position);
			battlePrepareStageActor.m_luaExportHelper.m_position = position;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601BBF0 RID: 113648 RVA: 0x00879160 File Offset: 0x00877360
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_direction(IntPtr l)
	{
		int result;
		try
		{
			BattlePrepareStageActor battlePrepareStageActor = (BattlePrepareStageActor)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, battlePrepareStageActor.m_luaExportHelper.m_direction);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601BBF1 RID: 113649 RVA: 0x008791B8 File Offset: 0x008773B8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_direction(IntPtr l)
	{
		int result;
		try
		{
			BattlePrepareStageActor battlePrepareStageActor = (BattlePrepareStageActor)LuaObject.checkSelf(l);
			int direction;
			LuaObject.checkType(l, 2, out direction);
			battlePrepareStageActor.m_luaExportHelper.m_direction = direction;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601BBF2 RID: 113650 RVA: 0x00879214 File Offset: 0x00877414
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_team(IntPtr l)
	{
		int result;
		try
		{
			BattlePrepareStageActor battlePrepareStageActor = (BattlePrepareStageActor)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, battlePrepareStageActor.m_luaExportHelper.m_team);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601BBF3 RID: 113651 RVA: 0x0087926C File Offset: 0x0087746C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_team(IntPtr l)
	{
		int result;
		try
		{
			BattlePrepareStageActor battlePrepareStageActor = (BattlePrepareStageActor)LuaObject.checkSelf(l);
			int team;
			LuaObject.checkType(l, 2, out team);
			battlePrepareStageActor.m_luaExportHelper.m_team = team;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601BBF4 RID: 113652 RVA: 0x008792C8 File Offset: 0x008774C8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_playerIndex(IntPtr l)
	{
		int result;
		try
		{
			BattlePrepareStageActor battlePrepareStageActor = (BattlePrepareStageActor)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, battlePrepareStageActor.m_luaExportHelper.m_playerIndex);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601BBF5 RID: 113653 RVA: 0x00879320 File Offset: 0x00877520
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_playerIndex(IntPtr l)
	{
		int result;
		try
		{
			BattlePrepareStageActor battlePrepareStageActor = (BattlePrepareStageActor)LuaObject.checkSelf(l);
			int playerIndex;
			LuaObject.checkType(l, 2, out playerIndex);
			battlePrepareStageActor.m_luaExportHelper.m_playerIndex = playerIndex;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601BBF6 RID: 113654 RVA: 0x0087937C File Offset: 0x0087757C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_hero(IntPtr l)
	{
		int result;
		try
		{
			BattlePrepareStageActor battlePrepareStageActor = (BattlePrepareStageActor)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, battlePrepareStageActor.m_luaExportHelper.m_hero);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601BBF7 RID: 113655 RVA: 0x008793D4 File Offset: 0x008775D4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_hero(IntPtr l)
	{
		int result;
		try
		{
			BattlePrepareStageActor battlePrepareStageActor = (BattlePrepareStageActor)LuaObject.checkSelf(l);
			BattleHero hero;
			LuaObject.checkType<BattleHero>(l, 2, out hero);
			battlePrepareStageActor.m_luaExportHelper.m_hero = hero;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601BBF8 RID: 113656 RVA: 0x00879430 File Offset: 0x00877630
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_behaviorId(IntPtr l)
	{
		int result;
		try
		{
			BattlePrepareStageActor battlePrepareStageActor = (BattlePrepareStageActor)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, battlePrepareStageActor.m_luaExportHelper.m_behaviorId);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601BBF9 RID: 113657 RVA: 0x00879488 File Offset: 0x00877688
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_behaviorId(IntPtr l)
	{
		int result;
		try
		{
			BattlePrepareStageActor battlePrepareStageActor = (BattlePrepareStageActor)LuaObject.checkSelf(l);
			int behaviorId;
			LuaObject.checkType(l, 2, out behaviorId);
			battlePrepareStageActor.m_luaExportHelper.m_behaviorId = behaviorId;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601BBFA RID: 113658 RVA: 0x008794E4 File Offset: 0x008776E4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_groupId(IntPtr l)
	{
		int result;
		try
		{
			BattlePrepareStageActor battlePrepareStageActor = (BattlePrepareStageActor)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, battlePrepareStageActor.m_luaExportHelper.m_groupId);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601BBFB RID: 113659 RVA: 0x0087953C File Offset: 0x0087773C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_groupId(IntPtr l)
	{
		int result;
		try
		{
			BattlePrepareStageActor battlePrepareStageActor = (BattlePrepareStageActor)LuaObject.checkSelf(l);
			int groupId;
			LuaObject.checkType(l, 2, out groupId);
			battlePrepareStageActor.m_luaExportHelper.m_groupId = groupId;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601BBFC RID: 113660 RVA: 0x00879598 File Offset: 0x00877798
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_tagType(IntPtr l)
	{
		int result;
		try
		{
			BattlePrepareStageActor battlePrepareStageActor = (BattlePrepareStageActor)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushEnum(l, (int)battlePrepareStageActor.m_luaExportHelper.m_tagType);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601BBFD RID: 113661 RVA: 0x008795F0 File Offset: 0x008777F0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_tagType(IntPtr l)
	{
		int result;
		try
		{
			BattlePrepareStageActor battlePrepareStageActor = (BattlePrepareStageActor)LuaObject.checkSelf(l);
			StageActorTagType tagType;
			LuaObject.checkEnum<StageActorTagType>(l, 2, out tagType);
			battlePrepareStageActor.m_luaExportHelper.m_tagType = tagType;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601BBFE RID: 113662 RVA: 0x0087964C File Offset: 0x0087784C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_stagePositionType(IntPtr l)
	{
		int result;
		try
		{
			BattlePrepareStageActor battlePrepareStageActor = (BattlePrepareStageActor)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushEnum(l, (int)battlePrepareStageActor.m_luaExportHelper.m_stagePositionType);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601BBFF RID: 113663 RVA: 0x008796A4 File Offset: 0x008778A4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_stagePositionType(IntPtr l)
	{
		int result;
		try
		{
			BattlePrepareStageActor battlePrepareStageActor = (BattlePrepareStageActor)LuaObject.checkSelf(l);
			StagePositionType stagePositionType;
			LuaObject.checkEnum<StagePositionType>(l, 2, out stagePositionType);
			battlePrepareStageActor.m_luaExportHelper.m_stagePositionType = stagePositionType;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601BC00 RID: 113664 RVA: 0x00879700 File Offset: 0x00877900
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_isGray(IntPtr l)
	{
		int result;
		try
		{
			BattlePrepareStageActor battlePrepareStageActor = (BattlePrepareStageActor)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, battlePrepareStageActor.m_luaExportHelper.m_isGray);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601BC01 RID: 113665 RVA: 0x00879758 File Offset: 0x00877958
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_isGray(IntPtr l)
	{
		int result;
		try
		{
			BattlePrepareStageActor battlePrepareStageActor = (BattlePrepareStageActor)LuaObject.checkSelf(l);
			bool isGray;
			LuaObject.checkType(l, 2, out isGray);
			battlePrepareStageActor.m_luaExportHelper.m_isGray = isGray;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601BC02 RID: 113666 RVA: 0x008797B4 File Offset: 0x008779B4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_heroHealthPoint(IntPtr l)
	{
		int result;
		try
		{
			BattlePrepareStageActor battlePrepareStageActor = (BattlePrepareStageActor)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, battlePrepareStageActor.m_luaExportHelper.m_heroHealthPoint);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601BC03 RID: 113667 RVA: 0x0087980C File Offset: 0x00877A0C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_heroHealthPoint(IntPtr l)
	{
		int result;
		try
		{
			BattlePrepareStageActor battlePrepareStageActor = (BattlePrepareStageActor)LuaObject.checkSelf(l);
			int heroHealthPoint;
			LuaObject.checkType(l, 2, out heroHealthPoint);
			battlePrepareStageActor.m_luaExportHelper.m_heroHealthPoint = heroHealthPoint;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601BC04 RID: 113668 RVA: 0x00879868 File Offset: 0x00877A68
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_soldierHealthPoint(IntPtr l)
	{
		int result;
		try
		{
			BattlePrepareStageActor battlePrepareStageActor = (BattlePrepareStageActor)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, battlePrepareStageActor.m_luaExportHelper.m_soldierHealthPoint);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601BC05 RID: 113669 RVA: 0x008798C0 File Offset: 0x00877AC0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_soldierHealthPoint(IntPtr l)
	{
		int result;
		try
		{
			BattlePrepareStageActor battlePrepareStageActor = (BattlePrepareStageActor)LuaObject.checkSelf(l);
			int soldierHealthPoint;
			LuaObject.checkType(l, 2, out soldierHealthPoint);
			battlePrepareStageActor.m_luaExportHelper.m_soldierHealthPoint = soldierHealthPoint;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601BC06 RID: 113670 RVA: 0x0087991C File Offset: 0x00877B1C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_extraTalentSkillInfo(IntPtr l)
	{
		int result;
		try
		{
			BattlePrepareStageActor battlePrepareStageActor = (BattlePrepareStageActor)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, battlePrepareStageActor.m_luaExportHelper.m_extraTalentSkillInfo);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601BC07 RID: 113671 RVA: 0x00879974 File Offset: 0x00877B74
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_extraTalentSkillInfo(IntPtr l)
	{
		int result;
		try
		{
			BattlePrepareStageActor battlePrepareStageActor = (BattlePrepareStageActor)LuaObject.checkSelf(l);
			ConfigDataSkillInfo extraTalentSkillInfo;
			LuaObject.checkType<ConfigDataSkillInfo>(l, 2, out extraTalentSkillInfo);
			battlePrepareStageActor.m_luaExportHelper.m_extraTalentSkillInfo = extraTalentSkillInfo;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601BC08 RID: 113672 RVA: 0x008799D0 File Offset: 0x00877BD0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_clientBattle(IntPtr l)
	{
		int result;
		try
		{
			BattlePrepareStageActor battlePrepareStageActor = (BattlePrepareStageActor)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, battlePrepareStageActor.m_luaExportHelper.m_clientBattle);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601BC09 RID: 113673 RVA: 0x00879A28 File Offset: 0x00877C28
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_clientBattle(IntPtr l)
	{
		int result;
		try
		{
			BattlePrepareStageActor battlePrepareStageActor = (BattlePrepareStageActor)LuaObject.checkSelf(l);
			ClientBattle clientBattle;
			LuaObject.checkType<ClientBattle>(l, 2, out clientBattle);
			battlePrepareStageActor.m_luaExportHelper.m_clientBattle = clientBattle;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601BC0A RID: 113674 RVA: 0x00879A84 File Offset: 0x00877C84
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_graphics(IntPtr l)
	{
		int result;
		try
		{
			BattlePrepareStageActor battlePrepareStageActor = (BattlePrepareStageActor)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, battlePrepareStageActor.m_luaExportHelper.m_graphics);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601BC0B RID: 113675 RVA: 0x00879ADC File Offset: 0x00877CDC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_graphics(IntPtr l)
	{
		int result;
		try
		{
			BattlePrepareStageActor battlePrepareStageActor = (BattlePrepareStageActor)LuaObject.checkSelf(l);
			GenericGraphic[] graphics;
			LuaObject.checkArray<GenericGraphic>(l, 2, out graphics);
			battlePrepareStageActor.m_luaExportHelper.m_graphics = graphics;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601BC0C RID: 113676 RVA: 0x00879B38 File Offset: 0x00877D38
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_soldierCount(IntPtr l)
	{
		int result;
		try
		{
			BattlePrepareStageActor battlePrepareStageActor = (BattlePrepareStageActor)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, battlePrepareStageActor.m_luaExportHelper.m_soldierCount);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601BC0D RID: 113677 RVA: 0x00879B90 File Offset: 0x00877D90
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_soldierCount(IntPtr l)
	{
		int result;
		try
		{
			BattlePrepareStageActor battlePrepareStageActor = (BattlePrepareStageActor)LuaObject.checkSelf(l);
			int soldierCount;
			LuaObject.checkType(l, 2, out soldierCount);
			battlePrepareStageActor.m_luaExportHelper.m_soldierCount = soldierCount;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601BC0E RID: 113678 RVA: 0x00879BEC File Offset: 0x00877DEC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_tweenFromColor(IntPtr l)
	{
		int result;
		try
		{
			BattlePrepareStageActor battlePrepareStageActor = (BattlePrepareStageActor)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, battlePrepareStageActor.m_luaExportHelper.m_tweenFromColor);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601BC0F RID: 113679 RVA: 0x00879C48 File Offset: 0x00877E48
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_tweenFromColor(IntPtr l)
	{
		int result;
		try
		{
			BattlePrepareStageActor battlePrepareStageActor = (BattlePrepareStageActor)LuaObject.checkSelf(l);
			Colori tweenFromColor;
			LuaObject.checkValueType<Colori>(l, 2, out tweenFromColor);
			battlePrepareStageActor.m_luaExportHelper.m_tweenFromColor = tweenFromColor;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601BC10 RID: 113680 RVA: 0x00879CA4 File Offset: 0x00877EA4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_tweenToColor(IntPtr l)
	{
		int result;
		try
		{
			BattlePrepareStageActor battlePrepareStageActor = (BattlePrepareStageActor)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, battlePrepareStageActor.m_luaExportHelper.m_tweenToColor);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601BC11 RID: 113681 RVA: 0x00879D00 File Offset: 0x00877F00
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_tweenToColor(IntPtr l)
	{
		int result;
		try
		{
			BattlePrepareStageActor battlePrepareStageActor = (BattlePrepareStageActor)LuaObject.checkSelf(l);
			Colori tweenToColor;
			LuaObject.checkValueType<Colori>(l, 2, out tweenToColor);
			battlePrepareStageActor.m_luaExportHelper.m_tweenToColor = tweenToColor;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601BC12 RID: 113682 RVA: 0x00879D5C File Offset: 0x00877F5C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_tweenColorTime(IntPtr l)
	{
		int result;
		try
		{
			BattlePrepareStageActor battlePrepareStageActor = (BattlePrepareStageActor)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, battlePrepareStageActor.m_luaExportHelper.m_tweenColorTime);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601BC13 RID: 113683 RVA: 0x00879DB4 File Offset: 0x00877FB4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_tweenColorTime(IntPtr l)
	{
		int result;
		try
		{
			BattlePrepareStageActor battlePrepareStageActor = (BattlePrepareStageActor)LuaObject.checkSelf(l);
			float tweenColorTime;
			LuaObject.checkType(l, 2, out tweenColorTime);
			battlePrepareStageActor.m_luaExportHelper.m_tweenColorTime = tweenColorTime;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601BC14 RID: 113684 RVA: 0x00879E10 File Offset: 0x00878010
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_uiController(IntPtr l)
	{
		int result;
		try
		{
			BattlePrepareStageActor battlePrepareStageActor = (BattlePrepareStageActor)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, battlePrepareStageActor.m_luaExportHelper.m_uiController);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601BC15 RID: 113685 RVA: 0x00879E68 File Offset: 0x00878068
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_uiController(IntPtr l)
	{
		int result;
		try
		{
			BattlePrepareStageActor battlePrepareStageActor = (BattlePrepareStageActor)LuaObject.checkSelf(l);
			BattleActorUIController uiController;
			LuaObject.checkType<BattleActorUIController>(l, 2, out uiController);
			battlePrepareStageActor.m_luaExportHelper.m_uiController = uiController;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601BC16 RID: 113686 RVA: 0x00879EC4 File Offset: 0x008780C4
	[Preserve]
	public static void reg(IntPtr l)
	{
		LuaObject.getTypeTable(l, "BlackJack.ProjectL.UI.BattlePrepareStageActor");
		if (Lua_BlackJack_ProjectL_UI_BattlePrepareStageActor.<>f__mg$cache0 == null)
		{
			Lua_BlackJack_ProjectL_UI_BattlePrepareStageActor.<>f__mg$cache0 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattlePrepareStageActor.Destroy);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_BattlePrepareStageActor.<>f__mg$cache0);
		if (Lua_BlackJack_ProjectL_UI_BattlePrepareStageActor.<>f__mg$cache1 == null)
		{
			Lua_BlackJack_ProjectL_UI_BattlePrepareStageActor.<>f__mg$cache1 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattlePrepareStageActor.Setup);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_BattlePrepareStageActor.<>f__mg$cache1);
		if (Lua_BlackJack_ProjectL_UI_BattlePrepareStageActor.<>f__mg$cache2 == null)
		{
			Lua_BlackJack_ProjectL_UI_BattlePrepareStageActor.<>f__mg$cache2 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattlePrepareStageActor.GetHero);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_BattlePrepareStageActor.<>f__mg$cache2);
		if (Lua_BlackJack_ProjectL_UI_BattlePrepareStageActor.<>f__mg$cache3 == null)
		{
			Lua_BlackJack_ProjectL_UI_BattlePrepareStageActor.<>f__mg$cache3 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattlePrepareStageActor.GetHeroId);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_BattlePrepareStageActor.<>f__mg$cache3);
		if (Lua_BlackJack_ProjectL_UI_BattlePrepareStageActor.<>f__mg$cache4 == null)
		{
			Lua_BlackJack_ProjectL_UI_BattlePrepareStageActor.<>f__mg$cache4 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattlePrepareStageActor.GetSoldierId);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_BattlePrepareStageActor.<>f__mg$cache4);
		if (Lua_BlackJack_ProjectL_UI_BattlePrepareStageActor.<>f__mg$cache5 == null)
		{
			Lua_BlackJack_ProjectL_UI_BattlePrepareStageActor.<>f__mg$cache5 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattlePrepareStageActor.SetHp);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_BattlePrepareStageActor.<>f__mg$cache5);
		if (Lua_BlackJack_ProjectL_UI_BattlePrepareStageActor.<>f__mg$cache6 == null)
		{
			Lua_BlackJack_ProjectL_UI_BattlePrepareStageActor.<>f__mg$cache6 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattlePrepareStageActor.GetHeroHp);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_BattlePrepareStageActor.<>f__mg$cache6);
		if (Lua_BlackJack_ProjectL_UI_BattlePrepareStageActor.<>f__mg$cache7 == null)
		{
			Lua_BlackJack_ProjectL_UI_BattlePrepareStageActor.<>f__mg$cache7 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattlePrepareStageActor.GetSoldierHp);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_BattlePrepareStageActor.<>f__mg$cache7);
		if (Lua_BlackJack_ProjectL_UI_BattlePrepareStageActor.<>f__mg$cache8 == null)
		{
			Lua_BlackJack_ProjectL_UI_BattlePrepareStageActor.<>f__mg$cache8 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattlePrepareStageActor.SetExtraTalentSkillInfo);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_BattlePrepareStageActor.<>f__mg$cache8);
		if (Lua_BlackJack_ProjectL_UI_BattlePrepareStageActor.<>f__mg$cache9 == null)
		{
			Lua_BlackJack_ProjectL_UI_BattlePrepareStageActor.<>f__mg$cache9 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattlePrepareStageActor.GetExtraTalentSkillInfo);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_BattlePrepareStageActor.<>f__mg$cache9);
		if (Lua_BlackJack_ProjectL_UI_BattlePrepareStageActor.<>f__mg$cacheA == null)
		{
			Lua_BlackJack_ProjectL_UI_BattlePrepareStageActor.<>f__mg$cacheA = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattlePrepareStageActor.SetPosition);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_BattlePrepareStageActor.<>f__mg$cacheA);
		if (Lua_BlackJack_ProjectL_UI_BattlePrepareStageActor.<>f__mg$cacheB == null)
		{
			Lua_BlackJack_ProjectL_UI_BattlePrepareStageActor.<>f__mg$cacheB = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattlePrepareStageActor.SetGray);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_BattlePrepareStageActor.<>f__mg$cacheB);
		if (Lua_BlackJack_ProjectL_UI_BattlePrepareStageActor.<>f__mg$cacheC == null)
		{
			Lua_BlackJack_ProjectL_UI_BattlePrepareStageActor.<>f__mg$cacheC = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattlePrepareStageActor.SetChooseEffect);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_BattlePrepareStageActor.<>f__mg$cacheC);
		if (Lua_BlackJack_ProjectL_UI_BattlePrepareStageActor.<>f__mg$cacheD == null)
		{
			Lua_BlackJack_ProjectL_UI_BattlePrepareStageActor.<>f__mg$cacheD = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattlePrepareStageActor.IsGray);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_BattlePrepareStageActor.<>f__mg$cacheD);
		if (Lua_BlackJack_ProjectL_UI_BattlePrepareStageActor.<>f__mg$cacheE == null)
		{
			Lua_BlackJack_ProjectL_UI_BattlePrepareStageActor.<>f__mg$cacheE = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattlePrepareStageActor.ForceUpdateSpine);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_BattlePrepareStageActor.<>f__mg$cacheE);
		if (Lua_BlackJack_ProjectL_UI_BattlePrepareStageActor.<>f__mg$cacheF == null)
		{
			Lua_BlackJack_ProjectL_UI_BattlePrepareStageActor.<>f__mg$cacheF = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattlePrepareStageActor.GetPosition);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_BattlePrepareStageActor.<>f__mg$cacheF);
		if (Lua_BlackJack_ProjectL_UI_BattlePrepareStageActor.<>f__mg$cache10 == null)
		{
			Lua_BlackJack_ProjectL_UI_BattlePrepareStageActor.<>f__mg$cache10 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattlePrepareStageActor.GetDirection);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_BattlePrepareStageActor.<>f__mg$cache10);
		if (Lua_BlackJack_ProjectL_UI_BattlePrepareStageActor.<>f__mg$cache11 == null)
		{
			Lua_BlackJack_ProjectL_UI_BattlePrepareStageActor.<>f__mg$cache11 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattlePrepareStageActor.GetTeam);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_BattlePrepareStageActor.<>f__mg$cache11);
		if (Lua_BlackJack_ProjectL_UI_BattlePrepareStageActor.<>f__mg$cache12 == null)
		{
			Lua_BlackJack_ProjectL_UI_BattlePrepareStageActor.<>f__mg$cache12 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattlePrepareStageActor.GetPlayerIndex);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_BattlePrepareStageActor.<>f__mg$cache12);
		if (Lua_BlackJack_ProjectL_UI_BattlePrepareStageActor.<>f__mg$cache13 == null)
		{
			Lua_BlackJack_ProjectL_UI_BattlePrepareStageActor.<>f__mg$cache13 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattlePrepareStageActor.GetTagType);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_BattlePrepareStageActor.<>f__mg$cache13);
		if (Lua_BlackJack_ProjectL_UI_BattlePrepareStageActor.<>f__mg$cache14 == null)
		{
			Lua_BlackJack_ProjectL_UI_BattlePrepareStageActor.<>f__mg$cache14 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattlePrepareStageActor.GetPositionType);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_BattlePrepareStageActor.<>f__mg$cache14);
		if (Lua_BlackJack_ProjectL_UI_BattlePrepareStageActor.<>f__mg$cache15 == null)
		{
			Lua_BlackJack_ProjectL_UI_BattlePrepareStageActor.<>f__mg$cache15 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattlePrepareStageActor.GetBehaviorId);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_BattlePrepareStageActor.<>f__mg$cache15);
		if (Lua_BlackJack_ProjectL_UI_BattlePrepareStageActor.<>f__mg$cache16 == null)
		{
			Lua_BlackJack_ProjectL_UI_BattlePrepareStageActor.<>f__mg$cache16 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattlePrepareStageActor.GetGroupId);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_BattlePrepareStageActor.<>f__mg$cache16);
		if (Lua_BlackJack_ProjectL_UI_BattlePrepareStageActor.<>f__mg$cache17 == null)
		{
			Lua_BlackJack_ProjectL_UI_BattlePrepareStageActor.<>f__mg$cache17 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattlePrepareStageActor.IsNpc);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_BattlePrepareStageActor.<>f__mg$cache17);
		if (Lua_BlackJack_ProjectL_UI_BattlePrepareStageActor.<>f__mg$cache18 == null)
		{
			Lua_BlackJack_ProjectL_UI_BattlePrepareStageActor.<>f__mg$cache18 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattlePrepareStageActor.IsAINpc);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_BattlePrepareStageActor.<>f__mg$cache18);
		if (Lua_BlackJack_ProjectL_UI_BattlePrepareStageActor.<>f__mg$cache19 == null)
		{
			Lua_BlackJack_ProjectL_UI_BattlePrepareStageActor.<>f__mg$cache19 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattlePrepareStageActor.IsTeammate);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_BattlePrepareStageActor.<>f__mg$cache19);
		if (Lua_BlackJack_ProjectL_UI_BattlePrepareStageActor.<>f__mg$cache1A == null)
		{
			Lua_BlackJack_ProjectL_UI_BattlePrepareStageActor.<>f__mg$cache1A = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattlePrepareStageActor.IsEnforce);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_BattlePrepareStageActor.<>f__mg$cache1A);
		if (Lua_BlackJack_ProjectL_UI_BattlePrepareStageActor.<>f__mg$cache1B == null)
		{
			Lua_BlackJack_ProjectL_UI_BattlePrepareStageActor.<>f__mg$cache1B = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattlePrepareStageActor.TweenColor);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_BattlePrepareStageActor.<>f__mg$cache1B);
		if (Lua_BlackJack_ProjectL_UI_BattlePrepareStageActor.<>f__mg$cache1C == null)
		{
			Lua_BlackJack_ProjectL_UI_BattlePrepareStageActor.<>f__mg$cache1C = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattlePrepareStageActor.GetUIController);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_BattlePrepareStageActor.<>f__mg$cache1C);
		if (Lua_BlackJack_ProjectL_UI_BattlePrepareStageActor.<>f__mg$cache1D == null)
		{
			Lua_BlackJack_ProjectL_UI_BattlePrepareStageActor.<>f__mg$cache1D = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattlePrepareStageActor.TickGraphic);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_BattlePrepareStageActor.<>f__mg$cache1D);
		if (Lua_BlackJack_ProjectL_UI_BattlePrepareStageActor.<>f__mg$cache1E == null)
		{
			Lua_BlackJack_ProjectL_UI_BattlePrepareStageActor.<>f__mg$cache1E = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattlePrepareStageActor.Pause);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_BattlePrepareStageActor.<>f__mg$cache1E);
		if (Lua_BlackJack_ProjectL_UI_BattlePrepareStageActor.<>f__mg$cache1F == null)
		{
			Lua_BlackJack_ProjectL_UI_BattlePrepareStageActor.<>f__mg$cache1F = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattlePrepareStageActor.DestroyGraphic);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_BattlePrepareStageActor.<>f__mg$cache1F);
		if (Lua_BlackJack_ProjectL_UI_BattlePrepareStageActor.<>f__mg$cache20 == null)
		{
			Lua_BlackJack_ProjectL_UI_BattlePrepareStageActor.<>f__mg$cache20 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattlePrepareStageActor.DestroyUI);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_BattlePrepareStageActor.<>f__mg$cache20);
		if (Lua_BlackJack_ProjectL_UI_BattlePrepareStageActor.<>f__mg$cache21 == null)
		{
			Lua_BlackJack_ProjectL_UI_BattlePrepareStageActor.<>f__mg$cache21 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattlePrepareStageActor.PlayAnimation);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_BattlePrepareStageActor.<>f__mg$cache21);
		if (Lua_BlackJack_ProjectL_UI_BattlePrepareStageActor.<>f__mg$cache22 == null)
		{
			Lua_BlackJack_ProjectL_UI_BattlePrepareStageActor.<>f__mg$cache22 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattlePrepareStageActor.ComputeGraphicPosition);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_BattlePrepareStageActor.<>f__mg$cache22);
		if (Lua_BlackJack_ProjectL_UI_BattlePrepareStageActor.<>f__mg$cache23 == null)
		{
			Lua_BlackJack_ProjectL_UI_BattlePrepareStageActor.<>f__mg$cache23 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattlePrepareStageActor.ComputeGraphicOffset);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_BattlePrepareStageActor.<>f__mg$cache23);
		if (Lua_BlackJack_ProjectL_UI_BattlePrepareStageActor.<>f__mg$cache24 == null)
		{
			Lua_BlackJack_ProjectL_UI_BattlePrepareStageActor.<>f__mg$cache24 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattlePrepareStageActor.ComputeSoldierGraphicCount);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_BattlePrepareStageActor.<>f__mg$cache24);
		if (Lua_BlackJack_ProjectL_UI_BattlePrepareStageActor.<>f__mg$cache25 == null)
		{
			Lua_BlackJack_ProjectL_UI_BattlePrepareStageActor.<>f__mg$cache25 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattlePrepareStageActor.UpdateGraphicVisible);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_BattlePrepareStageActor.<>f__mg$cache25);
		string name = "m_position";
		if (Lua_BlackJack_ProjectL_UI_BattlePrepareStageActor.<>f__mg$cache26 == null)
		{
			Lua_BlackJack_ProjectL_UI_BattlePrepareStageActor.<>f__mg$cache26 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattlePrepareStageActor.get_m_position);
		}
		LuaCSFunction get = Lua_BlackJack_ProjectL_UI_BattlePrepareStageActor.<>f__mg$cache26;
		if (Lua_BlackJack_ProjectL_UI_BattlePrepareStageActor.<>f__mg$cache27 == null)
		{
			Lua_BlackJack_ProjectL_UI_BattlePrepareStageActor.<>f__mg$cache27 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattlePrepareStageActor.set_m_position);
		}
		LuaObject.addMember(l, name, get, Lua_BlackJack_ProjectL_UI_BattlePrepareStageActor.<>f__mg$cache27, true);
		string name2 = "m_direction";
		if (Lua_BlackJack_ProjectL_UI_BattlePrepareStageActor.<>f__mg$cache28 == null)
		{
			Lua_BlackJack_ProjectL_UI_BattlePrepareStageActor.<>f__mg$cache28 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattlePrepareStageActor.get_m_direction);
		}
		LuaCSFunction get2 = Lua_BlackJack_ProjectL_UI_BattlePrepareStageActor.<>f__mg$cache28;
		if (Lua_BlackJack_ProjectL_UI_BattlePrepareStageActor.<>f__mg$cache29 == null)
		{
			Lua_BlackJack_ProjectL_UI_BattlePrepareStageActor.<>f__mg$cache29 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattlePrepareStageActor.set_m_direction);
		}
		LuaObject.addMember(l, name2, get2, Lua_BlackJack_ProjectL_UI_BattlePrepareStageActor.<>f__mg$cache29, true);
		string name3 = "m_team";
		if (Lua_BlackJack_ProjectL_UI_BattlePrepareStageActor.<>f__mg$cache2A == null)
		{
			Lua_BlackJack_ProjectL_UI_BattlePrepareStageActor.<>f__mg$cache2A = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattlePrepareStageActor.get_m_team);
		}
		LuaCSFunction get3 = Lua_BlackJack_ProjectL_UI_BattlePrepareStageActor.<>f__mg$cache2A;
		if (Lua_BlackJack_ProjectL_UI_BattlePrepareStageActor.<>f__mg$cache2B == null)
		{
			Lua_BlackJack_ProjectL_UI_BattlePrepareStageActor.<>f__mg$cache2B = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattlePrepareStageActor.set_m_team);
		}
		LuaObject.addMember(l, name3, get3, Lua_BlackJack_ProjectL_UI_BattlePrepareStageActor.<>f__mg$cache2B, true);
		string name4 = "m_playerIndex";
		if (Lua_BlackJack_ProjectL_UI_BattlePrepareStageActor.<>f__mg$cache2C == null)
		{
			Lua_BlackJack_ProjectL_UI_BattlePrepareStageActor.<>f__mg$cache2C = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattlePrepareStageActor.get_m_playerIndex);
		}
		LuaCSFunction get4 = Lua_BlackJack_ProjectL_UI_BattlePrepareStageActor.<>f__mg$cache2C;
		if (Lua_BlackJack_ProjectL_UI_BattlePrepareStageActor.<>f__mg$cache2D == null)
		{
			Lua_BlackJack_ProjectL_UI_BattlePrepareStageActor.<>f__mg$cache2D = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattlePrepareStageActor.set_m_playerIndex);
		}
		LuaObject.addMember(l, name4, get4, Lua_BlackJack_ProjectL_UI_BattlePrepareStageActor.<>f__mg$cache2D, true);
		string name5 = "m_hero";
		if (Lua_BlackJack_ProjectL_UI_BattlePrepareStageActor.<>f__mg$cache2E == null)
		{
			Lua_BlackJack_ProjectL_UI_BattlePrepareStageActor.<>f__mg$cache2E = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattlePrepareStageActor.get_m_hero);
		}
		LuaCSFunction get5 = Lua_BlackJack_ProjectL_UI_BattlePrepareStageActor.<>f__mg$cache2E;
		if (Lua_BlackJack_ProjectL_UI_BattlePrepareStageActor.<>f__mg$cache2F == null)
		{
			Lua_BlackJack_ProjectL_UI_BattlePrepareStageActor.<>f__mg$cache2F = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattlePrepareStageActor.set_m_hero);
		}
		LuaObject.addMember(l, name5, get5, Lua_BlackJack_ProjectL_UI_BattlePrepareStageActor.<>f__mg$cache2F, true);
		string name6 = "m_behaviorId";
		if (Lua_BlackJack_ProjectL_UI_BattlePrepareStageActor.<>f__mg$cache30 == null)
		{
			Lua_BlackJack_ProjectL_UI_BattlePrepareStageActor.<>f__mg$cache30 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattlePrepareStageActor.get_m_behaviorId);
		}
		LuaCSFunction get6 = Lua_BlackJack_ProjectL_UI_BattlePrepareStageActor.<>f__mg$cache30;
		if (Lua_BlackJack_ProjectL_UI_BattlePrepareStageActor.<>f__mg$cache31 == null)
		{
			Lua_BlackJack_ProjectL_UI_BattlePrepareStageActor.<>f__mg$cache31 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattlePrepareStageActor.set_m_behaviorId);
		}
		LuaObject.addMember(l, name6, get6, Lua_BlackJack_ProjectL_UI_BattlePrepareStageActor.<>f__mg$cache31, true);
		string name7 = "m_groupId";
		if (Lua_BlackJack_ProjectL_UI_BattlePrepareStageActor.<>f__mg$cache32 == null)
		{
			Lua_BlackJack_ProjectL_UI_BattlePrepareStageActor.<>f__mg$cache32 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattlePrepareStageActor.get_m_groupId);
		}
		LuaCSFunction get7 = Lua_BlackJack_ProjectL_UI_BattlePrepareStageActor.<>f__mg$cache32;
		if (Lua_BlackJack_ProjectL_UI_BattlePrepareStageActor.<>f__mg$cache33 == null)
		{
			Lua_BlackJack_ProjectL_UI_BattlePrepareStageActor.<>f__mg$cache33 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattlePrepareStageActor.set_m_groupId);
		}
		LuaObject.addMember(l, name7, get7, Lua_BlackJack_ProjectL_UI_BattlePrepareStageActor.<>f__mg$cache33, true);
		string name8 = "m_tagType";
		if (Lua_BlackJack_ProjectL_UI_BattlePrepareStageActor.<>f__mg$cache34 == null)
		{
			Lua_BlackJack_ProjectL_UI_BattlePrepareStageActor.<>f__mg$cache34 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattlePrepareStageActor.get_m_tagType);
		}
		LuaCSFunction get8 = Lua_BlackJack_ProjectL_UI_BattlePrepareStageActor.<>f__mg$cache34;
		if (Lua_BlackJack_ProjectL_UI_BattlePrepareStageActor.<>f__mg$cache35 == null)
		{
			Lua_BlackJack_ProjectL_UI_BattlePrepareStageActor.<>f__mg$cache35 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattlePrepareStageActor.set_m_tagType);
		}
		LuaObject.addMember(l, name8, get8, Lua_BlackJack_ProjectL_UI_BattlePrepareStageActor.<>f__mg$cache35, true);
		string name9 = "m_stagePositionType";
		if (Lua_BlackJack_ProjectL_UI_BattlePrepareStageActor.<>f__mg$cache36 == null)
		{
			Lua_BlackJack_ProjectL_UI_BattlePrepareStageActor.<>f__mg$cache36 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattlePrepareStageActor.get_m_stagePositionType);
		}
		LuaCSFunction get9 = Lua_BlackJack_ProjectL_UI_BattlePrepareStageActor.<>f__mg$cache36;
		if (Lua_BlackJack_ProjectL_UI_BattlePrepareStageActor.<>f__mg$cache37 == null)
		{
			Lua_BlackJack_ProjectL_UI_BattlePrepareStageActor.<>f__mg$cache37 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattlePrepareStageActor.set_m_stagePositionType);
		}
		LuaObject.addMember(l, name9, get9, Lua_BlackJack_ProjectL_UI_BattlePrepareStageActor.<>f__mg$cache37, true);
		string name10 = "m_isGray";
		if (Lua_BlackJack_ProjectL_UI_BattlePrepareStageActor.<>f__mg$cache38 == null)
		{
			Lua_BlackJack_ProjectL_UI_BattlePrepareStageActor.<>f__mg$cache38 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattlePrepareStageActor.get_m_isGray);
		}
		LuaCSFunction get10 = Lua_BlackJack_ProjectL_UI_BattlePrepareStageActor.<>f__mg$cache38;
		if (Lua_BlackJack_ProjectL_UI_BattlePrepareStageActor.<>f__mg$cache39 == null)
		{
			Lua_BlackJack_ProjectL_UI_BattlePrepareStageActor.<>f__mg$cache39 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattlePrepareStageActor.set_m_isGray);
		}
		LuaObject.addMember(l, name10, get10, Lua_BlackJack_ProjectL_UI_BattlePrepareStageActor.<>f__mg$cache39, true);
		string name11 = "m_heroHealthPoint";
		if (Lua_BlackJack_ProjectL_UI_BattlePrepareStageActor.<>f__mg$cache3A == null)
		{
			Lua_BlackJack_ProjectL_UI_BattlePrepareStageActor.<>f__mg$cache3A = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattlePrepareStageActor.get_m_heroHealthPoint);
		}
		LuaCSFunction get11 = Lua_BlackJack_ProjectL_UI_BattlePrepareStageActor.<>f__mg$cache3A;
		if (Lua_BlackJack_ProjectL_UI_BattlePrepareStageActor.<>f__mg$cache3B == null)
		{
			Lua_BlackJack_ProjectL_UI_BattlePrepareStageActor.<>f__mg$cache3B = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattlePrepareStageActor.set_m_heroHealthPoint);
		}
		LuaObject.addMember(l, name11, get11, Lua_BlackJack_ProjectL_UI_BattlePrepareStageActor.<>f__mg$cache3B, true);
		string name12 = "m_soldierHealthPoint";
		if (Lua_BlackJack_ProjectL_UI_BattlePrepareStageActor.<>f__mg$cache3C == null)
		{
			Lua_BlackJack_ProjectL_UI_BattlePrepareStageActor.<>f__mg$cache3C = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattlePrepareStageActor.get_m_soldierHealthPoint);
		}
		LuaCSFunction get12 = Lua_BlackJack_ProjectL_UI_BattlePrepareStageActor.<>f__mg$cache3C;
		if (Lua_BlackJack_ProjectL_UI_BattlePrepareStageActor.<>f__mg$cache3D == null)
		{
			Lua_BlackJack_ProjectL_UI_BattlePrepareStageActor.<>f__mg$cache3D = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattlePrepareStageActor.set_m_soldierHealthPoint);
		}
		LuaObject.addMember(l, name12, get12, Lua_BlackJack_ProjectL_UI_BattlePrepareStageActor.<>f__mg$cache3D, true);
		string name13 = "m_extraTalentSkillInfo";
		if (Lua_BlackJack_ProjectL_UI_BattlePrepareStageActor.<>f__mg$cache3E == null)
		{
			Lua_BlackJack_ProjectL_UI_BattlePrepareStageActor.<>f__mg$cache3E = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattlePrepareStageActor.get_m_extraTalentSkillInfo);
		}
		LuaCSFunction get13 = Lua_BlackJack_ProjectL_UI_BattlePrepareStageActor.<>f__mg$cache3E;
		if (Lua_BlackJack_ProjectL_UI_BattlePrepareStageActor.<>f__mg$cache3F == null)
		{
			Lua_BlackJack_ProjectL_UI_BattlePrepareStageActor.<>f__mg$cache3F = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattlePrepareStageActor.set_m_extraTalentSkillInfo);
		}
		LuaObject.addMember(l, name13, get13, Lua_BlackJack_ProjectL_UI_BattlePrepareStageActor.<>f__mg$cache3F, true);
		string name14 = "m_clientBattle";
		if (Lua_BlackJack_ProjectL_UI_BattlePrepareStageActor.<>f__mg$cache40 == null)
		{
			Lua_BlackJack_ProjectL_UI_BattlePrepareStageActor.<>f__mg$cache40 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattlePrepareStageActor.get_m_clientBattle);
		}
		LuaCSFunction get14 = Lua_BlackJack_ProjectL_UI_BattlePrepareStageActor.<>f__mg$cache40;
		if (Lua_BlackJack_ProjectL_UI_BattlePrepareStageActor.<>f__mg$cache41 == null)
		{
			Lua_BlackJack_ProjectL_UI_BattlePrepareStageActor.<>f__mg$cache41 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattlePrepareStageActor.set_m_clientBattle);
		}
		LuaObject.addMember(l, name14, get14, Lua_BlackJack_ProjectL_UI_BattlePrepareStageActor.<>f__mg$cache41, true);
		string name15 = "m_graphics";
		if (Lua_BlackJack_ProjectL_UI_BattlePrepareStageActor.<>f__mg$cache42 == null)
		{
			Lua_BlackJack_ProjectL_UI_BattlePrepareStageActor.<>f__mg$cache42 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattlePrepareStageActor.get_m_graphics);
		}
		LuaCSFunction get15 = Lua_BlackJack_ProjectL_UI_BattlePrepareStageActor.<>f__mg$cache42;
		if (Lua_BlackJack_ProjectL_UI_BattlePrepareStageActor.<>f__mg$cache43 == null)
		{
			Lua_BlackJack_ProjectL_UI_BattlePrepareStageActor.<>f__mg$cache43 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattlePrepareStageActor.set_m_graphics);
		}
		LuaObject.addMember(l, name15, get15, Lua_BlackJack_ProjectL_UI_BattlePrepareStageActor.<>f__mg$cache43, true);
		string name16 = "m_soldierCount";
		if (Lua_BlackJack_ProjectL_UI_BattlePrepareStageActor.<>f__mg$cache44 == null)
		{
			Lua_BlackJack_ProjectL_UI_BattlePrepareStageActor.<>f__mg$cache44 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattlePrepareStageActor.get_m_soldierCount);
		}
		LuaCSFunction get16 = Lua_BlackJack_ProjectL_UI_BattlePrepareStageActor.<>f__mg$cache44;
		if (Lua_BlackJack_ProjectL_UI_BattlePrepareStageActor.<>f__mg$cache45 == null)
		{
			Lua_BlackJack_ProjectL_UI_BattlePrepareStageActor.<>f__mg$cache45 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattlePrepareStageActor.set_m_soldierCount);
		}
		LuaObject.addMember(l, name16, get16, Lua_BlackJack_ProjectL_UI_BattlePrepareStageActor.<>f__mg$cache45, true);
		string name17 = "m_tweenFromColor";
		if (Lua_BlackJack_ProjectL_UI_BattlePrepareStageActor.<>f__mg$cache46 == null)
		{
			Lua_BlackJack_ProjectL_UI_BattlePrepareStageActor.<>f__mg$cache46 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattlePrepareStageActor.get_m_tweenFromColor);
		}
		LuaCSFunction get17 = Lua_BlackJack_ProjectL_UI_BattlePrepareStageActor.<>f__mg$cache46;
		if (Lua_BlackJack_ProjectL_UI_BattlePrepareStageActor.<>f__mg$cache47 == null)
		{
			Lua_BlackJack_ProjectL_UI_BattlePrepareStageActor.<>f__mg$cache47 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattlePrepareStageActor.set_m_tweenFromColor);
		}
		LuaObject.addMember(l, name17, get17, Lua_BlackJack_ProjectL_UI_BattlePrepareStageActor.<>f__mg$cache47, true);
		string name18 = "m_tweenToColor";
		if (Lua_BlackJack_ProjectL_UI_BattlePrepareStageActor.<>f__mg$cache48 == null)
		{
			Lua_BlackJack_ProjectL_UI_BattlePrepareStageActor.<>f__mg$cache48 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattlePrepareStageActor.get_m_tweenToColor);
		}
		LuaCSFunction get18 = Lua_BlackJack_ProjectL_UI_BattlePrepareStageActor.<>f__mg$cache48;
		if (Lua_BlackJack_ProjectL_UI_BattlePrepareStageActor.<>f__mg$cache49 == null)
		{
			Lua_BlackJack_ProjectL_UI_BattlePrepareStageActor.<>f__mg$cache49 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattlePrepareStageActor.set_m_tweenToColor);
		}
		LuaObject.addMember(l, name18, get18, Lua_BlackJack_ProjectL_UI_BattlePrepareStageActor.<>f__mg$cache49, true);
		string name19 = "m_tweenColorTime";
		if (Lua_BlackJack_ProjectL_UI_BattlePrepareStageActor.<>f__mg$cache4A == null)
		{
			Lua_BlackJack_ProjectL_UI_BattlePrepareStageActor.<>f__mg$cache4A = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattlePrepareStageActor.get_m_tweenColorTime);
		}
		LuaCSFunction get19 = Lua_BlackJack_ProjectL_UI_BattlePrepareStageActor.<>f__mg$cache4A;
		if (Lua_BlackJack_ProjectL_UI_BattlePrepareStageActor.<>f__mg$cache4B == null)
		{
			Lua_BlackJack_ProjectL_UI_BattlePrepareStageActor.<>f__mg$cache4B = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattlePrepareStageActor.set_m_tweenColorTime);
		}
		LuaObject.addMember(l, name19, get19, Lua_BlackJack_ProjectL_UI_BattlePrepareStageActor.<>f__mg$cache4B, true);
		string name20 = "m_uiController";
		if (Lua_BlackJack_ProjectL_UI_BattlePrepareStageActor.<>f__mg$cache4C == null)
		{
			Lua_BlackJack_ProjectL_UI_BattlePrepareStageActor.<>f__mg$cache4C = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattlePrepareStageActor.get_m_uiController);
		}
		LuaCSFunction get20 = Lua_BlackJack_ProjectL_UI_BattlePrepareStageActor.<>f__mg$cache4C;
		if (Lua_BlackJack_ProjectL_UI_BattlePrepareStageActor.<>f__mg$cache4D == null)
		{
			Lua_BlackJack_ProjectL_UI_BattlePrepareStageActor.<>f__mg$cache4D = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattlePrepareStageActor.set_m_uiController);
		}
		LuaObject.addMember(l, name20, get20, Lua_BlackJack_ProjectL_UI_BattlePrepareStageActor.<>f__mg$cache4D, true);
		if (Lua_BlackJack_ProjectL_UI_BattlePrepareStageActor.<>f__mg$cache4E == null)
		{
			Lua_BlackJack_ProjectL_UI_BattlePrepareStageActor.<>f__mg$cache4E = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattlePrepareStageActor.constructor);
		}
		LuaObject.createTypeMetatable(l, Lua_BlackJack_ProjectL_UI_BattlePrepareStageActor.<>f__mg$cache4E, typeof(BattlePrepareStageActor));
	}

	// Token: 0x04011E4F RID: 73295
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache0;

	// Token: 0x04011E50 RID: 73296
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1;

	// Token: 0x04011E51 RID: 73297
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2;

	// Token: 0x04011E52 RID: 73298
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3;

	// Token: 0x04011E53 RID: 73299
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache4;

	// Token: 0x04011E54 RID: 73300
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache5;

	// Token: 0x04011E55 RID: 73301
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache6;

	// Token: 0x04011E56 RID: 73302
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache7;

	// Token: 0x04011E57 RID: 73303
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache8;

	// Token: 0x04011E58 RID: 73304
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache9;

	// Token: 0x04011E59 RID: 73305
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheA;

	// Token: 0x04011E5A RID: 73306
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheB;

	// Token: 0x04011E5B RID: 73307
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheC;

	// Token: 0x04011E5C RID: 73308
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheD;

	// Token: 0x04011E5D RID: 73309
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheE;

	// Token: 0x04011E5E RID: 73310
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheF;

	// Token: 0x04011E5F RID: 73311
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache10;

	// Token: 0x04011E60 RID: 73312
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache11;

	// Token: 0x04011E61 RID: 73313
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache12;

	// Token: 0x04011E62 RID: 73314
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache13;

	// Token: 0x04011E63 RID: 73315
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache14;

	// Token: 0x04011E64 RID: 73316
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache15;

	// Token: 0x04011E65 RID: 73317
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache16;

	// Token: 0x04011E66 RID: 73318
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache17;

	// Token: 0x04011E67 RID: 73319
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache18;

	// Token: 0x04011E68 RID: 73320
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache19;

	// Token: 0x04011E69 RID: 73321
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1A;

	// Token: 0x04011E6A RID: 73322
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1B;

	// Token: 0x04011E6B RID: 73323
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1C;

	// Token: 0x04011E6C RID: 73324
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1D;

	// Token: 0x04011E6D RID: 73325
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1E;

	// Token: 0x04011E6E RID: 73326
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1F;

	// Token: 0x04011E6F RID: 73327
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache20;

	// Token: 0x04011E70 RID: 73328
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache21;

	// Token: 0x04011E71 RID: 73329
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache22;

	// Token: 0x04011E72 RID: 73330
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache23;

	// Token: 0x04011E73 RID: 73331
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache24;

	// Token: 0x04011E74 RID: 73332
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache25;

	// Token: 0x04011E75 RID: 73333
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache26;

	// Token: 0x04011E76 RID: 73334
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache27;

	// Token: 0x04011E77 RID: 73335
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache28;

	// Token: 0x04011E78 RID: 73336
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache29;

	// Token: 0x04011E79 RID: 73337
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2A;

	// Token: 0x04011E7A RID: 73338
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2B;

	// Token: 0x04011E7B RID: 73339
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2C;

	// Token: 0x04011E7C RID: 73340
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2D;

	// Token: 0x04011E7D RID: 73341
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2E;

	// Token: 0x04011E7E RID: 73342
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2F;

	// Token: 0x04011E7F RID: 73343
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache30;

	// Token: 0x04011E80 RID: 73344
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache31;

	// Token: 0x04011E81 RID: 73345
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache32;

	// Token: 0x04011E82 RID: 73346
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache33;

	// Token: 0x04011E83 RID: 73347
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache34;

	// Token: 0x04011E84 RID: 73348
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache35;

	// Token: 0x04011E85 RID: 73349
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache36;

	// Token: 0x04011E86 RID: 73350
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache37;

	// Token: 0x04011E87 RID: 73351
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache38;

	// Token: 0x04011E88 RID: 73352
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache39;

	// Token: 0x04011E89 RID: 73353
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3A;

	// Token: 0x04011E8A RID: 73354
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3B;

	// Token: 0x04011E8B RID: 73355
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3C;

	// Token: 0x04011E8C RID: 73356
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3D;

	// Token: 0x04011E8D RID: 73357
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3E;

	// Token: 0x04011E8E RID: 73358
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3F;

	// Token: 0x04011E8F RID: 73359
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache40;

	// Token: 0x04011E90 RID: 73360
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache41;

	// Token: 0x04011E91 RID: 73361
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache42;

	// Token: 0x04011E92 RID: 73362
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache43;

	// Token: 0x04011E93 RID: 73363
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache44;

	// Token: 0x04011E94 RID: 73364
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache45;

	// Token: 0x04011E95 RID: 73365
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache46;

	// Token: 0x04011E96 RID: 73366
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache47;

	// Token: 0x04011E97 RID: 73367
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache48;

	// Token: 0x04011E98 RID: 73368
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache49;

	// Token: 0x04011E99 RID: 73369
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache4A;

	// Token: 0x04011E9A RID: 73370
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache4B;

	// Token: 0x04011E9B RID: 73371
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache4C;

	// Token: 0x04011E9C RID: 73372
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache4D;

	// Token: 0x04011E9D RID: 73373
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache4E;
}
