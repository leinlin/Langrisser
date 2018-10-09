using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using BlackJack.ConfigData;
using BlackJack.ProjectL.Battle;
using BlackJack.ProjectL.Common;
using SLua;
using UnityEngine.Scripting;

// Token: 0x020011AA RID: 4522
[Preserve]
public class Lua_BlackJack_ProjectL_Battle_CombatTeam : LuaObject
{
	// Token: 0x06017646 RID: 95814 RVA: 0x0065F6DC File Offset: 0x0065D8DC
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int constructor(IntPtr l)
	{
		int result;
		try
		{
			CombatTeam o = new CombatTeam();
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

	// Token: 0x06017647 RID: 95815 RVA: 0x0065F724 File Offset: 0x0065D924
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int Initialize(IntPtr l)
	{
		int result;
		try
		{
			CombatTeam combatTeam = (CombatTeam)LuaObject.checkSelf(l);
			Combat combat;
			LuaObject.checkType<Combat>(l, 2, out combat);
			int team;
			LuaObject.checkType(l, 3, out team);
			BattleActor battleActor;
			LuaObject.checkType<BattleActor>(l, 4, out battleActor);
			ConfigDataSkillInfo heroSkillInfo;
			LuaObject.checkType<ConfigDataSkillInfo>(l, 5, out heroSkillInfo);
			combatTeam.Initialize(combat, team, battleActor, heroSkillInfo);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06017648 RID: 95816 RVA: 0x0065F7A4 File Offset: 0x0065D9A4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int IsAttackHeroOnly(IntPtr l)
	{
		int result;
		try
		{
			CombatTeam combatTeam = (CombatTeam)LuaObject.checkSelf(l);
			bool b = combatTeam.IsAttackHeroOnly();
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

	// Token: 0x06017649 RID: 95817 RVA: 0x0065F7F8 File Offset: 0x0065D9F8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int Tick(IntPtr l)
	{
		int result;
		try
		{
			CombatTeam combatTeam = (CombatTeam)LuaObject.checkSelf(l);
			combatTeam.Tick();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601764A RID: 95818 RVA: 0x0065F844 File Offset: 0x0065DA44
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int RemoveDeleted(IntPtr l)
	{
		int result;
		try
		{
			CombatTeam combatTeam = (CombatTeam)LuaObject.checkSelf(l);
			combatTeam.RemoveDeleted();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601764B RID: 95819 RVA: 0x0065F890 File Offset: 0x0065DA90
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int TickGraphic(IntPtr l)
	{
		int result;
		try
		{
			CombatTeam combatTeam = (CombatTeam)LuaObject.checkSelf(l);
			float dt;
			LuaObject.checkType(l, 2, out dt);
			combatTeam.TickGraphic(dt);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601764C RID: 95820 RVA: 0x0065F8E8 File Offset: 0x0065DAE8
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int Draw(IntPtr l)
	{
		int result;
		try
		{
			CombatTeam combatTeam = (CombatTeam)LuaObject.checkSelf(l);
			combatTeam.Draw();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601764D RID: 95821 RVA: 0x0065F934 File Offset: 0x0065DB34
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int Pause(IntPtr l)
	{
		int result;
		try
		{
			CombatTeam combatTeam = (CombatTeam)LuaObject.checkSelf(l);
			bool pause;
			LuaObject.checkType(l, 2, out pause);
			combatTeam.Pause(pause);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601764E RID: 95822 RVA: 0x0065F98C File Offset: 0x0065DB8C
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int GetColor(IntPtr l)
	{
		int result;
		try
		{
			CombatTeam combatTeam = (CombatTeam)LuaObject.checkSelf(l);
			Colori color = combatTeam.GetColor();
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, color);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601764F RID: 95823 RVA: 0x0065F9E8 File Offset: 0x0065DBE8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int CreateActor(IntPtr l)
	{
		int result;
		try
		{
			CombatTeam combatTeam = (CombatTeam)LuaObject.checkSelf(l);
			bool isHero;
			LuaObject.checkType(l, 2, out isHero);
			CombatActor o = combatTeam.CreateActor(isHero);
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

	// Token: 0x06017650 RID: 95824 RVA: 0x0065FA4C File Offset: 0x0065DC4C
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int CreateFlyObject(IntPtr l)
	{
		int result;
		try
		{
			CombatTeam combatTeam = (CombatTeam)LuaObject.checkSelf(l);
			CombatFlyObject o = combatTeam.CreateFlyObject();
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

	// Token: 0x06017651 RID: 95825 RVA: 0x0065FAA0 File Offset: 0x0065DCA0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int RemoveAll(IntPtr l)
	{
		int result;
		try
		{
			CombatTeam combatTeam = (CombatTeam)LuaObject.checkSelf(l);
			combatTeam.RemoveAll();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06017652 RID: 95826 RVA: 0x0065FAEC File Offset: 0x0065DCEC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int OnMyActorCastSkill(IntPtr l)
	{
		int result;
		try
		{
			CombatTeam combatTeam = (CombatTeam)LuaObject.checkSelf(l);
			CombatActor a;
			LuaObject.checkType<CombatActor>(l, 2, out a);
			ConfigDataSkillInfo skillInfo;
			LuaObject.checkType<ConfigDataSkillInfo>(l, 3, out skillInfo);
			combatTeam.OnMyActorCastSkill(a, skillInfo);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06017653 RID: 95827 RVA: 0x0065FB50 File Offset: 0x0065DD50
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int OnMyActorAttackBy(IntPtr l)
	{
		int result;
		try
		{
			CombatTeam combatTeam = (CombatTeam)LuaObject.checkSelf(l);
			CombatActor a;
			LuaObject.checkType<CombatActor>(l, 2, out a);
			CombatActor attacker;
			LuaObject.checkType<CombatActor>(l, 3, out attacker);
			ConfigDataSkillInfo skillInfo;
			LuaObject.checkType<ConfigDataSkillInfo>(l, 4, out skillInfo);
			int hpModify;
			LuaObject.checkType(l, 5, out hpModify);
			bool isCritical;
			LuaObject.checkType(l, 6, out isCritical);
			ArmyRelationData armyRelation;
			LuaObject.checkValueType<ArmyRelationData>(l, 7, out armyRelation);
			combatTeam.OnMyActorAttackBy(a, attacker, skillInfo, hpModify, isCritical, armyRelation);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06017654 RID: 95828 RVA: 0x0065FBE8 File Offset: 0x0065DDE8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int OnMyActorReboundDamage(IntPtr l)
	{
		int result;
		try
		{
			CombatTeam combatTeam = (CombatTeam)LuaObject.checkSelf(l);
			CombatActor a;
			LuaObject.checkType<CombatActor>(l, 2, out a);
			CombatActor attacker;
			LuaObject.checkType<CombatActor>(l, 3, out attacker);
			ConfigDataSkillInfo skillInfo;
			LuaObject.checkType<ConfigDataSkillInfo>(l, 4, out skillInfo);
			int hpModify;
			LuaObject.checkType(l, 5, out hpModify);
			combatTeam.OnMyActorReboundDamage(a, attacker, skillInfo, hpModify);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06017655 RID: 95829 RVA: 0x0065FC68 File Offset: 0x0065DE68
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int OnMyActorDie(IntPtr l)
	{
		int result;
		try
		{
			CombatTeam combatTeam = (CombatTeam)LuaObject.checkSelf(l);
			CombatActor a;
			LuaObject.checkType<CombatActor>(l, 2, out a);
			combatTeam.OnMyActorDie(a);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06017656 RID: 95830 RVA: 0x0065FCC0 File Offset: 0x0065DEC0
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int OnMyActorFightAgain(IntPtr l)
	{
		int result;
		try
		{
			CombatTeam combatTeam = (CombatTeam)LuaObject.checkSelf(l);
			CombatActor a;
			LuaObject.checkType<CombatActor>(l, 2, out a);
			combatTeam.OnMyActorFightAgain(a);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06017657 RID: 95831 RVA: 0x0065FD18 File Offset: 0x0065DF18
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int GetFormationPosition(IntPtr l)
	{
		int result;
		try
		{
			CombatTeam combatTeam = (CombatTeam)LuaObject.checkSelf(l);
			int idx;
			LuaObject.checkType(l, 2, out idx);
			Position2i formationPosition = combatTeam.GetFormationPosition(idx);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, formationPosition);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06017658 RID: 95832 RVA: 0x0065FD80 File Offset: 0x0065DF80
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int GetFormationLine(IntPtr l)
	{
		int result;
		try
		{
			CombatTeam combatTeam = (CombatTeam)LuaObject.checkSelf(l);
			int idx;
			LuaObject.checkType(l, 2, out idx);
			int formationLine = combatTeam.GetFormationLine(idx);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, formationLine);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06017659 RID: 95833 RVA: 0x0065FDE4 File Offset: 0x0065DFE4
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int GetHero(IntPtr l)
	{
		int result;
		try
		{
			CombatTeam combatTeam = (CombatTeam)LuaObject.checkSelf(l);
			CombatActor hero = combatTeam.GetHero();
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

	// Token: 0x0601765A RID: 95834 RVA: 0x0065FE38 File Offset: 0x0065E038
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int GetActors(IntPtr l)
	{
		int result;
		try
		{
			CombatTeam combatTeam = (CombatTeam)LuaObject.checkSelf(l);
			List<CombatActor> actors = combatTeam.GetActors();
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, actors);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601765B RID: 95835 RVA: 0x0065FE8C File Offset: 0x0065E08C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int EnterCombat(IntPtr l)
	{
		int result;
		try
		{
			CombatTeam combatTeam = (CombatTeam)LuaObject.checkSelf(l);
			combatTeam.EnterCombat();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601765C RID: 95836 RVA: 0x0065FED8 File Offset: 0x0065E0D8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int StartCombat(IntPtr l)
	{
		int result;
		try
		{
			CombatTeam combatTeam = (CombatTeam)LuaObject.checkSelf(l);
			combatTeam.StartCombat();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601765D RID: 95837 RVA: 0x0065FF24 File Offset: 0x0065E124
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int StopCombat(IntPtr l)
	{
		int result;
		try
		{
			CombatTeam combatTeam = (CombatTeam)LuaObject.checkSelf(l);
			combatTeam.StopCombat();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601765E RID: 95838 RVA: 0x0065FF70 File Offset: 0x0065E170
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int CanStopCombat(IntPtr l)
	{
		int result;
		try
		{
			CombatTeam combatTeam = (CombatTeam)LuaObject.checkSelf(l);
			bool b = combatTeam.CanStopCombat();
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

	// Token: 0x0601765F RID: 95839 RVA: 0x0065FFC4 File Offset: 0x0065E1C4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int LogCanNotStopCombat(IntPtr l)
	{
		int result;
		try
		{
			CombatTeam combatTeam = (CombatTeam)LuaObject.checkSelf(l);
			combatTeam.LogCanNotStopCombat();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06017660 RID: 95840 RVA: 0x00660010 File Offset: 0x0065E210
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int CanReturn(IntPtr l)
	{
		int result;
		try
		{
			CombatTeam combatTeam = (CombatTeam)LuaObject.checkSelf(l);
			bool b = combatTeam.CanReturn();
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

	// Token: 0x06017661 RID: 95841 RVA: 0x00660064 File Offset: 0x0065E264
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int SetGraphicSkillFade(IntPtr l)
	{
		int result;
		try
		{
			CombatTeam combatTeam = (CombatTeam)LuaObject.checkSelf(l);
			bool graphicSkillFade;
			LuaObject.checkType(l, 2, out graphicSkillFade);
			combatTeam.SetGraphicSkillFade(graphicSkillFade);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06017662 RID: 95842 RVA: 0x006600BC File Offset: 0x0065E2BC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int GetTargetTeam(IntPtr l)
	{
		int result;
		try
		{
			CombatTeam combatTeam = (CombatTeam)LuaObject.checkSelf(l);
			CombatTeam targetTeam = combatTeam.GetTargetTeam();
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, targetTeam);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06017663 RID: 95843 RVA: 0x00660110 File Offset: 0x0065E310
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int ComputeSoldierTotalHealthPoint(IntPtr l)
	{
		int result;
		try
		{
			CombatTeam combatTeam = (CombatTeam)LuaObject.checkSelf(l);
			int i = combatTeam.ComputeSoldierTotalHealthPoint();
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

	// Token: 0x06017664 RID: 95844 RVA: 0x00660164 File Offset: 0x0065E364
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int GetLastDamageBySkill(IntPtr l)
	{
		int result;
		try
		{
			CombatTeam combatTeam = (CombatTeam)LuaObject.checkSelf(l);
			ConfigDataSkillInfo lastDamageBySkill = combatTeam.GetLastDamageBySkill();
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, lastDamageBySkill);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06017665 RID: 95845 RVA: 0x006601B8 File Offset: 0x0065E3B8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int GetAttachBuffSourceSkillInfo(IntPtr l)
	{
		int result;
		try
		{
			CombatTeam combatTeam = (CombatTeam)LuaObject.checkSelf(l);
			ConfigDataSkillInfo attachBuffSourceSkillInfo = combatTeam.GetAttachBuffSourceSkillInfo();
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, attachBuffSourceSkillInfo);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06017666 RID: 95846 RVA: 0x0066020C File Offset: 0x0065E40C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int GetDoubleAttackBuff(IntPtr l)
	{
		int result;
		try
		{
			CombatTeam combatTeam = (CombatTeam)LuaObject.checkSelf(l);
			BuffState doubleAttackBuff = combatTeam.GetDoubleAttackBuff();
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, doubleAttackBuff);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06017667 RID: 95847 RVA: 0x00660260 File Offset: 0x0065E460
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int ComputeHeroCriticalAttack(IntPtr l)
	{
		int result;
		try
		{
			CombatTeam combatTeam = (CombatTeam)LuaObject.checkSelf(l);
			combatTeam.m_luaExportHelper.ComputeHeroCriticalAttack();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06017668 RID: 95848 RVA: 0x006602B4 File Offset: 0x0065E4B4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int ComputeSoldierCriticalAttack(IntPtr l)
	{
		int result;
		try
		{
			CombatTeam combatTeam = (CombatTeam)LuaObject.checkSelf(l);
			combatTeam.m_luaExportHelper.ComputeSoldierCriticalAttack();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06017669 RID: 95849 RVA: 0x00660308 File Offset: 0x0065E508
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int HasAliveActor(IntPtr l)
	{
		int result;
		try
		{
			CombatTeam combatTeam = (CombatTeam)LuaObject.checkSelf(l);
			bool b = combatTeam.m_luaExportHelper.HasAliveActor();
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

	// Token: 0x0601766A RID: 95850 RVA: 0x00660364 File Offset: 0x0065E564
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int GetAliveActorCount(IntPtr l)
	{
		int result;
		try
		{
			CombatTeam combatTeam = (CombatTeam)LuaObject.checkSelf(l);
			int aliveActorCount = combatTeam.m_luaExportHelper.GetAliveActorCount();
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, aliveActorCount);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601766B RID: 95851 RVA: 0x006603C0 File Offset: 0x0065E5C0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int IsAllAliveActorState(IntPtr l)
	{
		int result;
		try
		{
			CombatTeam combatTeam = (CombatTeam)LuaObject.checkSelf(l);
			CombatActorState state;
			LuaObject.checkEnum<CombatActorState>(l, 2, out state);
			CombatActorState state2;
			LuaObject.checkEnum<CombatActorState>(l, 3, out state2);
			CombatActorState state3;
			LuaObject.checkEnum<CombatActorState>(l, 4, out state3);
			bool b = combatTeam.m_luaExportHelper.IsAllAliveActorState(state, state2, state3);
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

	// Token: 0x0601766C RID: 95852 RVA: 0x00660444 File Offset: 0x0065E644
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_m_combat(IntPtr l)
	{
		int result;
		try
		{
			CombatTeam combatTeam = (CombatTeam)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, combatTeam.m_luaExportHelper.m_combat);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601766D RID: 95853 RVA: 0x0066049C File Offset: 0x0065E69C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_combat(IntPtr l)
	{
		int result;
		try
		{
			CombatTeam combatTeam = (CombatTeam)LuaObject.checkSelf(l);
			Combat combat;
			LuaObject.checkType<Combat>(l, 2, out combat);
			combatTeam.m_luaExportHelper.m_combat = combat;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601766E RID: 95854 RVA: 0x006604F8 File Offset: 0x0065E6F8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_teamNumber(IntPtr l)
	{
		int result;
		try
		{
			CombatTeam combatTeam = (CombatTeam)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, combatTeam.m_luaExportHelper.m_teamNumber);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601766F RID: 95855 RVA: 0x00660550 File Offset: 0x0065E750
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_m_teamNumber(IntPtr l)
	{
		int result;
		try
		{
			CombatTeam combatTeam = (CombatTeam)LuaObject.checkSelf(l);
			int teamNumber;
			LuaObject.checkType(l, 2, out teamNumber);
			combatTeam.m_luaExportHelper.m_teamNumber = teamNumber;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06017670 RID: 95856 RVA: 0x006605AC File Offset: 0x0065E7AC
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_m_battleActor(IntPtr l)
	{
		int result;
		try
		{
			CombatTeam combatTeam = (CombatTeam)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, combatTeam.m_luaExportHelper.m_battleActor);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06017671 RID: 95857 RVA: 0x00660604 File Offset: 0x0065E804
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_m_battleActor(IntPtr l)
	{
		int result;
		try
		{
			CombatTeam combatTeam = (CombatTeam)LuaObject.checkSelf(l);
			BattleActor battleActor;
			LuaObject.checkType<BattleActor>(l, 2, out battleActor);
			combatTeam.m_luaExportHelper.m_battleActor = battleActor;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06017672 RID: 95858 RVA: 0x00660660 File Offset: 0x0065E860
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_m_actors(IntPtr l)
	{
		int result;
		try
		{
			CombatTeam combatTeam = (CombatTeam)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, combatTeam.m_luaExportHelper.m_actors);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06017673 RID: 95859 RVA: 0x006606B8 File Offset: 0x0065E8B8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_actors(IntPtr l)
	{
		int result;
		try
		{
			CombatTeam combatTeam = (CombatTeam)LuaObject.checkSelf(l);
			List<CombatActor> actors;
			LuaObject.checkType<List<CombatActor>>(l, 2, out actors);
			combatTeam.m_luaExportHelper.m_actors = actors;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06017674 RID: 95860 RVA: 0x00660714 File Offset: 0x0065E914
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_flyObjects(IntPtr l)
	{
		int result;
		try
		{
			CombatTeam combatTeam = (CombatTeam)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, combatTeam.m_luaExportHelper.m_flyObjects);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06017675 RID: 95861 RVA: 0x0066076C File Offset: 0x0065E96C
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_m_flyObjects(IntPtr l)
	{
		int result;
		try
		{
			CombatTeam combatTeam = (CombatTeam)LuaObject.checkSelf(l);
			List<CombatFlyObject> flyObjects;
			LuaObject.checkType<List<CombatFlyObject>>(l, 2, out flyObjects);
			combatTeam.m_luaExportHelper.m_flyObjects = flyObjects;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06017676 RID: 95862 RVA: 0x006607C8 File Offset: 0x0065E9C8
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_s_formationPositions(IntPtr l)
	{
		int result;
		try
		{
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, CombatTeam.LuaExportHelper.s_formationPositions);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06017677 RID: 95863 RVA: 0x00660810 File Offset: 0x0065EA10
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_s_formationPositions(IntPtr l)
	{
		int result;
		try
		{
			Position2i[] s_formationPositions;
			LuaObject.checkArray<Position2i>(l, 2, out s_formationPositions);
			CombatTeam.LuaExportHelper.s_formationPositions = s_formationPositions;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06017678 RID: 95864 RVA: 0x0066085C File Offset: 0x0065EA5C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_heroSkillInfo(IntPtr l)
	{
		int result;
		try
		{
			CombatTeam combatTeam = (CombatTeam)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, combatTeam.m_luaExportHelper.m_heroSkillInfo);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06017679 RID: 95865 RVA: 0x006608B4 File Offset: 0x0065EAB4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_heroSkillInfo(IntPtr l)
	{
		int result;
		try
		{
			CombatTeam combatTeam = (CombatTeam)LuaObject.checkSelf(l);
			ConfigDataSkillInfo heroSkillInfo;
			LuaObject.checkType<ConfigDataSkillInfo>(l, 2, out heroSkillInfo);
			combatTeam.m_luaExportHelper.m_heroSkillInfo = heroSkillInfo;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601767A RID: 95866 RVA: 0x00660910 File Offset: 0x0065EB10
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_shouldHeroToHeroCriticalAttack(IntPtr l)
	{
		int result;
		try
		{
			CombatTeam combatTeam = (CombatTeam)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, combatTeam.m_luaExportHelper.m_shouldHeroToHeroCriticalAttack);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601767B RID: 95867 RVA: 0x00660968 File Offset: 0x0065EB68
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_shouldHeroToHeroCriticalAttack(IntPtr l)
	{
		int result;
		try
		{
			CombatTeam combatTeam = (CombatTeam)LuaObject.checkSelf(l);
			bool shouldHeroToHeroCriticalAttack;
			LuaObject.checkType(l, 2, out shouldHeroToHeroCriticalAttack);
			combatTeam.m_luaExportHelper.m_shouldHeroToHeroCriticalAttack = shouldHeroToHeroCriticalAttack;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601767C RID: 95868 RVA: 0x006609C4 File Offset: 0x0065EBC4
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_m_shouldHeroToSoldierCriticalAttack(IntPtr l)
	{
		int result;
		try
		{
			CombatTeam combatTeam = (CombatTeam)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, combatTeam.m_luaExportHelper.m_shouldHeroToSoldierCriticalAttack);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601767D RID: 95869 RVA: 0x00660A1C File Offset: 0x0065EC1C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_shouldHeroToSoldierCriticalAttack(IntPtr l)
	{
		int result;
		try
		{
			CombatTeam combatTeam = (CombatTeam)LuaObject.checkSelf(l);
			bool shouldHeroToSoldierCriticalAttack;
			LuaObject.checkType(l, 2, out shouldHeroToSoldierCriticalAttack);
			combatTeam.m_luaExportHelper.m_shouldHeroToSoldierCriticalAttack = shouldHeroToSoldierCriticalAttack;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601767E RID: 95870 RVA: 0x00660A78 File Offset: 0x0065EC78
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_m_shouldSoldierToHeroCriticalAttack(IntPtr l)
	{
		int result;
		try
		{
			CombatTeam combatTeam = (CombatTeam)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, combatTeam.m_luaExportHelper.m_shouldSoldierToHeroCriticalAttack);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601767F RID: 95871 RVA: 0x00660AD0 File Offset: 0x0065ECD0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_shouldSoldierToHeroCriticalAttack(IntPtr l)
	{
		int result;
		try
		{
			CombatTeam combatTeam = (CombatTeam)LuaObject.checkSelf(l);
			bool shouldSoldierToHeroCriticalAttack;
			LuaObject.checkType(l, 2, out shouldSoldierToHeroCriticalAttack);
			combatTeam.m_luaExportHelper.m_shouldSoldierToHeroCriticalAttack = shouldSoldierToHeroCriticalAttack;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06017680 RID: 95872 RVA: 0x00660B2C File Offset: 0x0065ED2C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_shouldSoldierToSoldierCriticalAttack(IntPtr l)
	{
		int result;
		try
		{
			CombatTeam combatTeam = (CombatTeam)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, combatTeam.m_luaExportHelper.m_shouldSoldierToSoldierCriticalAttack);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06017681 RID: 95873 RVA: 0x00660B84 File Offset: 0x0065ED84
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_shouldSoldierToSoldierCriticalAttack(IntPtr l)
	{
		int result;
		try
		{
			CombatTeam combatTeam = (CombatTeam)LuaObject.checkSelf(l);
			bool shouldSoldierToSoldierCriticalAttack;
			LuaObject.checkType(l, 2, out shouldSoldierToSoldierCriticalAttack);
			combatTeam.m_luaExportHelper.m_shouldSoldierToSoldierCriticalAttack = shouldSoldierToSoldierCriticalAttack;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06017682 RID: 95874 RVA: 0x00660BE0 File Offset: 0x0065EDE0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_isCastAnyDamageSkill(IntPtr l)
	{
		int result;
		try
		{
			CombatTeam combatTeam = (CombatTeam)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, combatTeam.m_luaExportHelper.m_isCastAnyDamageSkill);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06017683 RID: 95875 RVA: 0x00660C38 File Offset: 0x0065EE38
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_isCastAnyDamageSkill(IntPtr l)
	{
		int result;
		try
		{
			CombatTeam combatTeam = (CombatTeam)LuaObject.checkSelf(l);
			bool isCastAnyDamageSkill;
			LuaObject.checkType(l, 2, out isCastAnyDamageSkill);
			combatTeam.m_luaExportHelper.m_isCastAnyDamageSkill = isCastAnyDamageSkill;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06017684 RID: 95876 RVA: 0x00660C94 File Offset: 0x0065EE94
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_m_isBeCriticalAttack(IntPtr l)
	{
		int result;
		try
		{
			CombatTeam combatTeam = (CombatTeam)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, combatTeam.m_luaExportHelper.m_isBeCriticalAttack);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06017685 RID: 95877 RVA: 0x00660CEC File Offset: 0x0065EEEC
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_m_isBeCriticalAttack(IntPtr l)
	{
		int result;
		try
		{
			CombatTeam combatTeam = (CombatTeam)LuaObject.checkSelf(l);
			bool isBeCriticalAttack;
			LuaObject.checkType(l, 2, out isBeCriticalAttack);
			combatTeam.m_luaExportHelper.m_isBeCriticalAttack = isBeCriticalAttack;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06017686 RID: 95878 RVA: 0x00660D48 File Offset: 0x0065EF48
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_lastDamageBySkill(IntPtr l)
	{
		int result;
		try
		{
			CombatTeam combatTeam = (CombatTeam)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, combatTeam.m_luaExportHelper.m_lastDamageBySkill);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06017687 RID: 95879 RVA: 0x00660DA0 File Offset: 0x0065EFA0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_lastDamageBySkill(IntPtr l)
	{
		int result;
		try
		{
			CombatTeam combatTeam = (CombatTeam)LuaObject.checkSelf(l);
			ConfigDataSkillInfo lastDamageBySkill;
			LuaObject.checkType<ConfigDataSkillInfo>(l, 2, out lastDamageBySkill);
			combatTeam.m_luaExportHelper.m_lastDamageBySkill = lastDamageBySkill;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06017688 RID: 95880 RVA: 0x00660DFC File Offset: 0x0065EFFC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_heroReceiveTotalDamage(IntPtr l)
	{
		int result;
		try
		{
			CombatTeam combatTeam = (CombatTeam)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, combatTeam.m_luaExportHelper.m_heroReceiveTotalDamage);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06017689 RID: 95881 RVA: 0x00660E54 File Offset: 0x0065F054
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_heroReceiveTotalDamage(IntPtr l)
	{
		int result;
		try
		{
			CombatTeam combatTeam = (CombatTeam)LuaObject.checkSelf(l);
			int heroReceiveTotalDamage;
			LuaObject.checkType(l, 2, out heroReceiveTotalDamage);
			combatTeam.m_luaExportHelper.m_heroReceiveTotalDamage = heroReceiveTotalDamage;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601768A RID: 95882 RVA: 0x00660EB0 File Offset: 0x0065F0B0
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_m_soldierReceiveTotalDamage(IntPtr l)
	{
		int result;
		try
		{
			CombatTeam combatTeam = (CombatTeam)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, combatTeam.m_luaExportHelper.m_soldierReceiveTotalDamage);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601768B RID: 95883 RVA: 0x00660F08 File Offset: 0x0065F108
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_m_soldierReceiveTotalDamage(IntPtr l)
	{
		int result;
		try
		{
			CombatTeam combatTeam = (CombatTeam)LuaObject.checkSelf(l);
			int soldierReceiveTotalDamage;
			LuaObject.checkType(l, 2, out soldierReceiveTotalDamage);
			combatTeam.m_luaExportHelper.m_soldierReceiveTotalDamage = soldierReceiveTotalDamage;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601768C RID: 95884 RVA: 0x00660F64 File Offset: 0x0065F164
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_m_heroApplyTotalDamage(IntPtr l)
	{
		int result;
		try
		{
			CombatTeam combatTeam = (CombatTeam)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, combatTeam.m_luaExportHelper.m_heroApplyTotalDamage);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601768D RID: 95885 RVA: 0x00660FBC File Offset: 0x0065F1BC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_heroApplyTotalDamage(IntPtr l)
	{
		int result;
		try
		{
			CombatTeam combatTeam = (CombatTeam)LuaObject.checkSelf(l);
			int heroApplyTotalDamage;
			LuaObject.checkType(l, 2, out heroApplyTotalDamage);
			combatTeam.m_luaExportHelper.m_heroApplyTotalDamage = heroApplyTotalDamage;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601768E RID: 95886 RVA: 0x00661018 File Offset: 0x0065F218
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_soldierApplyTotalDamage(IntPtr l)
	{
		int result;
		try
		{
			CombatTeam combatTeam = (CombatTeam)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, combatTeam.m_luaExportHelper.m_soldierApplyTotalDamage);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601768F RID: 95887 RVA: 0x00661070 File Offset: 0x0065F270
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_soldierApplyTotalDamage(IntPtr l)
	{
		int result;
		try
		{
			CombatTeam combatTeam = (CombatTeam)LuaObject.checkSelf(l);
			int soldierApplyTotalDamage;
			LuaObject.checkType(l, 2, out soldierApplyTotalDamage);
			combatTeam.m_luaExportHelper.m_soldierApplyTotalDamage = soldierApplyTotalDamage;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06017690 RID: 95888 RVA: 0x006610CC File Offset: 0x0065F2CC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_isTryApplyBuff(IntPtr l)
	{
		int result;
		try
		{
			CombatTeam combatTeam = (CombatTeam)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, combatTeam.m_luaExportHelper.m_isTryApplyBuff);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06017691 RID: 95889 RVA: 0x00661124 File Offset: 0x0065F324
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_m_isTryApplyBuff(IntPtr l)
	{
		int result;
		try
		{
			CombatTeam combatTeam = (CombatTeam)LuaObject.checkSelf(l);
			bool isTryApplyBuff;
			LuaObject.checkType(l, 2, out isTryApplyBuff);
			combatTeam.m_luaExportHelper.m_isTryApplyBuff = isTryApplyBuff;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06017692 RID: 95890 RVA: 0x00661180 File Offset: 0x0065F380
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_attachBuffSourceSkillInfo(IntPtr l)
	{
		int result;
		try
		{
			CombatTeam combatTeam = (CombatTeam)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, combatTeam.m_luaExportHelper.m_attachBuffSourceSkillInfo);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06017693 RID: 95891 RVA: 0x006611D8 File Offset: 0x0065F3D8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_attachBuffSourceSkillInfo(IntPtr l)
	{
		int result;
		try
		{
			CombatTeam combatTeam = (CombatTeam)LuaObject.checkSelf(l);
			ConfigDataSkillInfo attachBuffSourceSkillInfo;
			LuaObject.checkType<ConfigDataSkillInfo>(l, 2, out attachBuffSourceSkillInfo);
			combatTeam.m_luaExportHelper.m_attachBuffSourceSkillInfo = attachBuffSourceSkillInfo;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06017694 RID: 95892 RVA: 0x00661234 File Offset: 0x0065F434
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_doubleAttackBuffState(IntPtr l)
	{
		int result;
		try
		{
			CombatTeam combatTeam = (CombatTeam)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, combatTeam.m_luaExportHelper.m_doubleAttackBuffState);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06017695 RID: 95893 RVA: 0x0066128C File Offset: 0x0065F48C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_doubleAttackBuffState(IntPtr l)
	{
		int result;
		try
		{
			CombatTeam combatTeam = (CombatTeam)LuaObject.checkSelf(l);
			BuffState doubleAttackBuffState;
			LuaObject.checkType<BuffState>(l, 2, out doubleAttackBuffState);
			combatTeam.m_luaExportHelper.m_doubleAttackBuffState = doubleAttackBuffState;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06017696 RID: 95894 RVA: 0x006612E8 File Offset: 0x0065F4E8
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_Combat(IntPtr l)
	{
		int result;
		try
		{
			CombatTeam combatTeam = (CombatTeam)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, combatTeam.Combat);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06017697 RID: 95895 RVA: 0x0066133C File Offset: 0x0065F53C
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_TeamNumber(IntPtr l)
	{
		int result;
		try
		{
			CombatTeam combatTeam = (CombatTeam)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, combatTeam.TeamNumber);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06017698 RID: 95896 RVA: 0x00661390 File Offset: 0x0065F590
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_BattleActor(IntPtr l)
	{
		int result;
		try
		{
			CombatTeam combatTeam = (CombatTeam)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, combatTeam.BattleActor);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06017699 RID: 95897 RVA: 0x006613E4 File Offset: 0x0065F5E4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_HeroInfo(IntPtr l)
	{
		int result;
		try
		{
			CombatTeam combatTeam = (CombatTeam)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, combatTeam.HeroInfo);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601769A RID: 95898 RVA: 0x00661438 File Offset: 0x0065F638
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_HeroArmyInfo(IntPtr l)
	{
		int result;
		try
		{
			CombatTeam combatTeam = (CombatTeam)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, combatTeam.HeroArmyInfo);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601769B RID: 95899 RVA: 0x0066148C File Offset: 0x0065F68C
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_JobConnectionInfo(IntPtr l)
	{
		int result;
		try
		{
			CombatTeam combatTeam = (CombatTeam)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, combatTeam.JobConnectionInfo);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601769C RID: 95900 RVA: 0x006614E0 File Offset: 0x0065F6E0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_JobInfo(IntPtr l)
	{
		int result;
		try
		{
			CombatTeam combatTeam = (CombatTeam)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, combatTeam.JobInfo);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601769D RID: 95901 RVA: 0x00661534 File Offset: 0x0065F734
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_SoldierInfo(IntPtr l)
	{
		int result;
		try
		{
			CombatTeam combatTeam = (CombatTeam)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, combatTeam.SoldierInfo);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601769E RID: 95902 RVA: 0x00661588 File Offset: 0x0065F788
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_SoldierArmyInfo(IntPtr l)
	{
		int result;
		try
		{
			CombatTeam combatTeam = (CombatTeam)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, combatTeam.SoldierArmyInfo);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601769F RID: 95903 RVA: 0x006615DC File Offset: 0x0065F7DC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_HeroSkill(IntPtr l)
	{
		int result;
		try
		{
			CombatTeam combatTeam = (CombatTeam)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, combatTeam.HeroSkill);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060176A0 RID: 95904 RVA: 0x00661630 File Offset: 0x0065F830
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_HeroLevel(IntPtr l)
	{
		int result;
		try
		{
			CombatTeam combatTeam = (CombatTeam)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, combatTeam.HeroLevel);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060176A1 RID: 95905 RVA: 0x00661684 File Offset: 0x0065F884
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_HeroStar(IntPtr l)
	{
		int result;
		try
		{
			CombatTeam combatTeam = (CombatTeam)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, combatTeam.HeroStar);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060176A2 RID: 95906 RVA: 0x006616D8 File Offset: 0x0065F8D8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_JobLevel(IntPtr l)
	{
		int result;
		try
		{
			CombatTeam combatTeam = (CombatTeam)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, combatTeam.JobLevel);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060176A3 RID: 95907 RVA: 0x0066172C File Offset: 0x0065F92C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_ShouldHeroToHeroCriticalAttack(IntPtr l)
	{
		int result;
		try
		{
			CombatTeam combatTeam = (CombatTeam)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, combatTeam.ShouldHeroToHeroCriticalAttack);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060176A4 RID: 95908 RVA: 0x00661780 File Offset: 0x0065F980
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_ShouldHeroToSoldierCriticalAttack(IntPtr l)
	{
		int result;
		try
		{
			CombatTeam combatTeam = (CombatTeam)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, combatTeam.ShouldHeroToSoldierCriticalAttack);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060176A5 RID: 95909 RVA: 0x006617D4 File Offset: 0x0065F9D4
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_ShouldSoldierToHeroCriticalAttack(IntPtr l)
	{
		int result;
		try
		{
			CombatTeam combatTeam = (CombatTeam)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, combatTeam.ShouldSoldierToHeroCriticalAttack);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060176A6 RID: 95910 RVA: 0x00661828 File Offset: 0x0065FA28
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_ShouldSoldierToSoldierCriticalAttack(IntPtr l)
	{
		int result;
		try
		{
			CombatTeam combatTeam = (CombatTeam)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, combatTeam.ShouldSoldierToSoldierCriticalAttack);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060176A7 RID: 95911 RVA: 0x0066187C File Offset: 0x0065FA7C
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_IsCastAnyDamageSkill(IntPtr l)
	{
		int result;
		try
		{
			CombatTeam combatTeam = (CombatTeam)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, combatTeam.IsCastAnyDamageSkill);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060176A8 RID: 95912 RVA: 0x006618D0 File Offset: 0x0065FAD0
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_IsBeCriticalAttack(IntPtr l)
	{
		int result;
		try
		{
			CombatTeam combatTeam = (CombatTeam)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, combatTeam.IsBeCriticalAttack);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060176A9 RID: 95913 RVA: 0x00661924 File Offset: 0x0065FB24
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_HeroReceiveTotalDamage(IntPtr l)
	{
		int result;
		try
		{
			CombatTeam combatTeam = (CombatTeam)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, combatTeam.HeroReceiveTotalDamage);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060176AA RID: 95914 RVA: 0x00661978 File Offset: 0x0065FB78
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_SoldierReceiveTotalDamage(IntPtr l)
	{
		int result;
		try
		{
			CombatTeam combatTeam = (CombatTeam)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, combatTeam.SoldierReceiveTotalDamage);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060176AB RID: 95915 RVA: 0x006619CC File Offset: 0x0065FBCC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_HeroApplyTotalDamage(IntPtr l)
	{
		int result;
		try
		{
			CombatTeam combatTeam = (CombatTeam)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, combatTeam.HeroApplyTotalDamage);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060176AC RID: 95916 RVA: 0x00661A20 File Offset: 0x0065FC20
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_SoldierApplyTotalDamage(IntPtr l)
	{
		int result;
		try
		{
			CombatTeam combatTeam = (CombatTeam)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, combatTeam.SoldierApplyTotalDamage);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060176AD RID: 95917 RVA: 0x00661A74 File Offset: 0x0065FC74
	[Preserve]
	public static void reg(IntPtr l)
	{
		LuaObject.getTypeTable(l, "BlackJack.ProjectL.Battle.CombatTeam");
		if (Lua_BlackJack_ProjectL_Battle_CombatTeam.<>f__mg$cache0 == null)
		{
			Lua_BlackJack_ProjectL_Battle_CombatTeam.<>f__mg$cache0 = new LuaCSFunction(Lua_BlackJack_ProjectL_Battle_CombatTeam.Initialize);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Battle_CombatTeam.<>f__mg$cache0);
		if (Lua_BlackJack_ProjectL_Battle_CombatTeam.<>f__mg$cache1 == null)
		{
			Lua_BlackJack_ProjectL_Battle_CombatTeam.<>f__mg$cache1 = new LuaCSFunction(Lua_BlackJack_ProjectL_Battle_CombatTeam.IsAttackHeroOnly);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Battle_CombatTeam.<>f__mg$cache1);
		if (Lua_BlackJack_ProjectL_Battle_CombatTeam.<>f__mg$cache2 == null)
		{
			Lua_BlackJack_ProjectL_Battle_CombatTeam.<>f__mg$cache2 = new LuaCSFunction(Lua_BlackJack_ProjectL_Battle_CombatTeam.Tick);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Battle_CombatTeam.<>f__mg$cache2);
		if (Lua_BlackJack_ProjectL_Battle_CombatTeam.<>f__mg$cache3 == null)
		{
			Lua_BlackJack_ProjectL_Battle_CombatTeam.<>f__mg$cache3 = new LuaCSFunction(Lua_BlackJack_ProjectL_Battle_CombatTeam.RemoveDeleted);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Battle_CombatTeam.<>f__mg$cache3);
		if (Lua_BlackJack_ProjectL_Battle_CombatTeam.<>f__mg$cache4 == null)
		{
			Lua_BlackJack_ProjectL_Battle_CombatTeam.<>f__mg$cache4 = new LuaCSFunction(Lua_BlackJack_ProjectL_Battle_CombatTeam.TickGraphic);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Battle_CombatTeam.<>f__mg$cache4);
		if (Lua_BlackJack_ProjectL_Battle_CombatTeam.<>f__mg$cache5 == null)
		{
			Lua_BlackJack_ProjectL_Battle_CombatTeam.<>f__mg$cache5 = new LuaCSFunction(Lua_BlackJack_ProjectL_Battle_CombatTeam.Draw);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Battle_CombatTeam.<>f__mg$cache5);
		if (Lua_BlackJack_ProjectL_Battle_CombatTeam.<>f__mg$cache6 == null)
		{
			Lua_BlackJack_ProjectL_Battle_CombatTeam.<>f__mg$cache6 = new LuaCSFunction(Lua_BlackJack_ProjectL_Battle_CombatTeam.Pause);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Battle_CombatTeam.<>f__mg$cache6);
		if (Lua_BlackJack_ProjectL_Battle_CombatTeam.<>f__mg$cache7 == null)
		{
			Lua_BlackJack_ProjectL_Battle_CombatTeam.<>f__mg$cache7 = new LuaCSFunction(Lua_BlackJack_ProjectL_Battle_CombatTeam.GetColor);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Battle_CombatTeam.<>f__mg$cache7);
		if (Lua_BlackJack_ProjectL_Battle_CombatTeam.<>f__mg$cache8 == null)
		{
			Lua_BlackJack_ProjectL_Battle_CombatTeam.<>f__mg$cache8 = new LuaCSFunction(Lua_BlackJack_ProjectL_Battle_CombatTeam.CreateActor);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Battle_CombatTeam.<>f__mg$cache8);
		if (Lua_BlackJack_ProjectL_Battle_CombatTeam.<>f__mg$cache9 == null)
		{
			Lua_BlackJack_ProjectL_Battle_CombatTeam.<>f__mg$cache9 = new LuaCSFunction(Lua_BlackJack_ProjectL_Battle_CombatTeam.CreateFlyObject);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Battle_CombatTeam.<>f__mg$cache9);
		if (Lua_BlackJack_ProjectL_Battle_CombatTeam.<>f__mg$cacheA == null)
		{
			Lua_BlackJack_ProjectL_Battle_CombatTeam.<>f__mg$cacheA = new LuaCSFunction(Lua_BlackJack_ProjectL_Battle_CombatTeam.RemoveAll);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Battle_CombatTeam.<>f__mg$cacheA);
		if (Lua_BlackJack_ProjectL_Battle_CombatTeam.<>f__mg$cacheB == null)
		{
			Lua_BlackJack_ProjectL_Battle_CombatTeam.<>f__mg$cacheB = new LuaCSFunction(Lua_BlackJack_ProjectL_Battle_CombatTeam.OnMyActorCastSkill);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Battle_CombatTeam.<>f__mg$cacheB);
		if (Lua_BlackJack_ProjectL_Battle_CombatTeam.<>f__mg$cacheC == null)
		{
			Lua_BlackJack_ProjectL_Battle_CombatTeam.<>f__mg$cacheC = new LuaCSFunction(Lua_BlackJack_ProjectL_Battle_CombatTeam.OnMyActorAttackBy);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Battle_CombatTeam.<>f__mg$cacheC);
		if (Lua_BlackJack_ProjectL_Battle_CombatTeam.<>f__mg$cacheD == null)
		{
			Lua_BlackJack_ProjectL_Battle_CombatTeam.<>f__mg$cacheD = new LuaCSFunction(Lua_BlackJack_ProjectL_Battle_CombatTeam.OnMyActorReboundDamage);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Battle_CombatTeam.<>f__mg$cacheD);
		if (Lua_BlackJack_ProjectL_Battle_CombatTeam.<>f__mg$cacheE == null)
		{
			Lua_BlackJack_ProjectL_Battle_CombatTeam.<>f__mg$cacheE = new LuaCSFunction(Lua_BlackJack_ProjectL_Battle_CombatTeam.OnMyActorDie);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Battle_CombatTeam.<>f__mg$cacheE);
		if (Lua_BlackJack_ProjectL_Battle_CombatTeam.<>f__mg$cacheF == null)
		{
			Lua_BlackJack_ProjectL_Battle_CombatTeam.<>f__mg$cacheF = new LuaCSFunction(Lua_BlackJack_ProjectL_Battle_CombatTeam.OnMyActorFightAgain);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Battle_CombatTeam.<>f__mg$cacheF);
		if (Lua_BlackJack_ProjectL_Battle_CombatTeam.<>f__mg$cache10 == null)
		{
			Lua_BlackJack_ProjectL_Battle_CombatTeam.<>f__mg$cache10 = new LuaCSFunction(Lua_BlackJack_ProjectL_Battle_CombatTeam.GetFormationPosition);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Battle_CombatTeam.<>f__mg$cache10);
		if (Lua_BlackJack_ProjectL_Battle_CombatTeam.<>f__mg$cache11 == null)
		{
			Lua_BlackJack_ProjectL_Battle_CombatTeam.<>f__mg$cache11 = new LuaCSFunction(Lua_BlackJack_ProjectL_Battle_CombatTeam.GetFormationLine);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Battle_CombatTeam.<>f__mg$cache11);
		if (Lua_BlackJack_ProjectL_Battle_CombatTeam.<>f__mg$cache12 == null)
		{
			Lua_BlackJack_ProjectL_Battle_CombatTeam.<>f__mg$cache12 = new LuaCSFunction(Lua_BlackJack_ProjectL_Battle_CombatTeam.GetHero);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Battle_CombatTeam.<>f__mg$cache12);
		if (Lua_BlackJack_ProjectL_Battle_CombatTeam.<>f__mg$cache13 == null)
		{
			Lua_BlackJack_ProjectL_Battle_CombatTeam.<>f__mg$cache13 = new LuaCSFunction(Lua_BlackJack_ProjectL_Battle_CombatTeam.GetActors);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Battle_CombatTeam.<>f__mg$cache13);
		if (Lua_BlackJack_ProjectL_Battle_CombatTeam.<>f__mg$cache14 == null)
		{
			Lua_BlackJack_ProjectL_Battle_CombatTeam.<>f__mg$cache14 = new LuaCSFunction(Lua_BlackJack_ProjectL_Battle_CombatTeam.EnterCombat);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Battle_CombatTeam.<>f__mg$cache14);
		if (Lua_BlackJack_ProjectL_Battle_CombatTeam.<>f__mg$cache15 == null)
		{
			Lua_BlackJack_ProjectL_Battle_CombatTeam.<>f__mg$cache15 = new LuaCSFunction(Lua_BlackJack_ProjectL_Battle_CombatTeam.StartCombat);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Battle_CombatTeam.<>f__mg$cache15);
		if (Lua_BlackJack_ProjectL_Battle_CombatTeam.<>f__mg$cache16 == null)
		{
			Lua_BlackJack_ProjectL_Battle_CombatTeam.<>f__mg$cache16 = new LuaCSFunction(Lua_BlackJack_ProjectL_Battle_CombatTeam.StopCombat);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Battle_CombatTeam.<>f__mg$cache16);
		if (Lua_BlackJack_ProjectL_Battle_CombatTeam.<>f__mg$cache17 == null)
		{
			Lua_BlackJack_ProjectL_Battle_CombatTeam.<>f__mg$cache17 = new LuaCSFunction(Lua_BlackJack_ProjectL_Battle_CombatTeam.CanStopCombat);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Battle_CombatTeam.<>f__mg$cache17);
		if (Lua_BlackJack_ProjectL_Battle_CombatTeam.<>f__mg$cache18 == null)
		{
			Lua_BlackJack_ProjectL_Battle_CombatTeam.<>f__mg$cache18 = new LuaCSFunction(Lua_BlackJack_ProjectL_Battle_CombatTeam.LogCanNotStopCombat);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Battle_CombatTeam.<>f__mg$cache18);
		if (Lua_BlackJack_ProjectL_Battle_CombatTeam.<>f__mg$cache19 == null)
		{
			Lua_BlackJack_ProjectL_Battle_CombatTeam.<>f__mg$cache19 = new LuaCSFunction(Lua_BlackJack_ProjectL_Battle_CombatTeam.CanReturn);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Battle_CombatTeam.<>f__mg$cache19);
		if (Lua_BlackJack_ProjectL_Battle_CombatTeam.<>f__mg$cache1A == null)
		{
			Lua_BlackJack_ProjectL_Battle_CombatTeam.<>f__mg$cache1A = new LuaCSFunction(Lua_BlackJack_ProjectL_Battle_CombatTeam.SetGraphicSkillFade);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Battle_CombatTeam.<>f__mg$cache1A);
		if (Lua_BlackJack_ProjectL_Battle_CombatTeam.<>f__mg$cache1B == null)
		{
			Lua_BlackJack_ProjectL_Battle_CombatTeam.<>f__mg$cache1B = new LuaCSFunction(Lua_BlackJack_ProjectL_Battle_CombatTeam.GetTargetTeam);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Battle_CombatTeam.<>f__mg$cache1B);
		if (Lua_BlackJack_ProjectL_Battle_CombatTeam.<>f__mg$cache1C == null)
		{
			Lua_BlackJack_ProjectL_Battle_CombatTeam.<>f__mg$cache1C = new LuaCSFunction(Lua_BlackJack_ProjectL_Battle_CombatTeam.ComputeSoldierTotalHealthPoint);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Battle_CombatTeam.<>f__mg$cache1C);
		if (Lua_BlackJack_ProjectL_Battle_CombatTeam.<>f__mg$cache1D == null)
		{
			Lua_BlackJack_ProjectL_Battle_CombatTeam.<>f__mg$cache1D = new LuaCSFunction(Lua_BlackJack_ProjectL_Battle_CombatTeam.GetLastDamageBySkill);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Battle_CombatTeam.<>f__mg$cache1D);
		if (Lua_BlackJack_ProjectL_Battle_CombatTeam.<>f__mg$cache1E == null)
		{
			Lua_BlackJack_ProjectL_Battle_CombatTeam.<>f__mg$cache1E = new LuaCSFunction(Lua_BlackJack_ProjectL_Battle_CombatTeam.GetAttachBuffSourceSkillInfo);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Battle_CombatTeam.<>f__mg$cache1E);
		if (Lua_BlackJack_ProjectL_Battle_CombatTeam.<>f__mg$cache1F == null)
		{
			Lua_BlackJack_ProjectL_Battle_CombatTeam.<>f__mg$cache1F = new LuaCSFunction(Lua_BlackJack_ProjectL_Battle_CombatTeam.GetDoubleAttackBuff);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Battle_CombatTeam.<>f__mg$cache1F);
		if (Lua_BlackJack_ProjectL_Battle_CombatTeam.<>f__mg$cache20 == null)
		{
			Lua_BlackJack_ProjectL_Battle_CombatTeam.<>f__mg$cache20 = new LuaCSFunction(Lua_BlackJack_ProjectL_Battle_CombatTeam.ComputeHeroCriticalAttack);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Battle_CombatTeam.<>f__mg$cache20);
		if (Lua_BlackJack_ProjectL_Battle_CombatTeam.<>f__mg$cache21 == null)
		{
			Lua_BlackJack_ProjectL_Battle_CombatTeam.<>f__mg$cache21 = new LuaCSFunction(Lua_BlackJack_ProjectL_Battle_CombatTeam.ComputeSoldierCriticalAttack);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Battle_CombatTeam.<>f__mg$cache21);
		if (Lua_BlackJack_ProjectL_Battle_CombatTeam.<>f__mg$cache22 == null)
		{
			Lua_BlackJack_ProjectL_Battle_CombatTeam.<>f__mg$cache22 = new LuaCSFunction(Lua_BlackJack_ProjectL_Battle_CombatTeam.HasAliveActor);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Battle_CombatTeam.<>f__mg$cache22);
		if (Lua_BlackJack_ProjectL_Battle_CombatTeam.<>f__mg$cache23 == null)
		{
			Lua_BlackJack_ProjectL_Battle_CombatTeam.<>f__mg$cache23 = new LuaCSFunction(Lua_BlackJack_ProjectL_Battle_CombatTeam.GetAliveActorCount);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Battle_CombatTeam.<>f__mg$cache23);
		if (Lua_BlackJack_ProjectL_Battle_CombatTeam.<>f__mg$cache24 == null)
		{
			Lua_BlackJack_ProjectL_Battle_CombatTeam.<>f__mg$cache24 = new LuaCSFunction(Lua_BlackJack_ProjectL_Battle_CombatTeam.IsAllAliveActorState);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Battle_CombatTeam.<>f__mg$cache24);
		string name = "m_combat";
		if (Lua_BlackJack_ProjectL_Battle_CombatTeam.<>f__mg$cache25 == null)
		{
			Lua_BlackJack_ProjectL_Battle_CombatTeam.<>f__mg$cache25 = new LuaCSFunction(Lua_BlackJack_ProjectL_Battle_CombatTeam.get_m_combat);
		}
		LuaCSFunction get = Lua_BlackJack_ProjectL_Battle_CombatTeam.<>f__mg$cache25;
		if (Lua_BlackJack_ProjectL_Battle_CombatTeam.<>f__mg$cache26 == null)
		{
			Lua_BlackJack_ProjectL_Battle_CombatTeam.<>f__mg$cache26 = new LuaCSFunction(Lua_BlackJack_ProjectL_Battle_CombatTeam.set_m_combat);
		}
		LuaObject.addMember(l, name, get, Lua_BlackJack_ProjectL_Battle_CombatTeam.<>f__mg$cache26, true);
		string name2 = "m_teamNumber";
		if (Lua_BlackJack_ProjectL_Battle_CombatTeam.<>f__mg$cache27 == null)
		{
			Lua_BlackJack_ProjectL_Battle_CombatTeam.<>f__mg$cache27 = new LuaCSFunction(Lua_BlackJack_ProjectL_Battle_CombatTeam.get_m_teamNumber);
		}
		LuaCSFunction get2 = Lua_BlackJack_ProjectL_Battle_CombatTeam.<>f__mg$cache27;
		if (Lua_BlackJack_ProjectL_Battle_CombatTeam.<>f__mg$cache28 == null)
		{
			Lua_BlackJack_ProjectL_Battle_CombatTeam.<>f__mg$cache28 = new LuaCSFunction(Lua_BlackJack_ProjectL_Battle_CombatTeam.set_m_teamNumber);
		}
		LuaObject.addMember(l, name2, get2, Lua_BlackJack_ProjectL_Battle_CombatTeam.<>f__mg$cache28, true);
		string name3 = "m_battleActor";
		if (Lua_BlackJack_ProjectL_Battle_CombatTeam.<>f__mg$cache29 == null)
		{
			Lua_BlackJack_ProjectL_Battle_CombatTeam.<>f__mg$cache29 = new LuaCSFunction(Lua_BlackJack_ProjectL_Battle_CombatTeam.get_m_battleActor);
		}
		LuaCSFunction get3 = Lua_BlackJack_ProjectL_Battle_CombatTeam.<>f__mg$cache29;
		if (Lua_BlackJack_ProjectL_Battle_CombatTeam.<>f__mg$cache2A == null)
		{
			Lua_BlackJack_ProjectL_Battle_CombatTeam.<>f__mg$cache2A = new LuaCSFunction(Lua_BlackJack_ProjectL_Battle_CombatTeam.set_m_battleActor);
		}
		LuaObject.addMember(l, name3, get3, Lua_BlackJack_ProjectL_Battle_CombatTeam.<>f__mg$cache2A, true);
		string name4 = "m_actors";
		if (Lua_BlackJack_ProjectL_Battle_CombatTeam.<>f__mg$cache2B == null)
		{
			Lua_BlackJack_ProjectL_Battle_CombatTeam.<>f__mg$cache2B = new LuaCSFunction(Lua_BlackJack_ProjectL_Battle_CombatTeam.get_m_actors);
		}
		LuaCSFunction get4 = Lua_BlackJack_ProjectL_Battle_CombatTeam.<>f__mg$cache2B;
		if (Lua_BlackJack_ProjectL_Battle_CombatTeam.<>f__mg$cache2C == null)
		{
			Lua_BlackJack_ProjectL_Battle_CombatTeam.<>f__mg$cache2C = new LuaCSFunction(Lua_BlackJack_ProjectL_Battle_CombatTeam.set_m_actors);
		}
		LuaObject.addMember(l, name4, get4, Lua_BlackJack_ProjectL_Battle_CombatTeam.<>f__mg$cache2C, true);
		string name5 = "m_flyObjects";
		if (Lua_BlackJack_ProjectL_Battle_CombatTeam.<>f__mg$cache2D == null)
		{
			Lua_BlackJack_ProjectL_Battle_CombatTeam.<>f__mg$cache2D = new LuaCSFunction(Lua_BlackJack_ProjectL_Battle_CombatTeam.get_m_flyObjects);
		}
		LuaCSFunction get5 = Lua_BlackJack_ProjectL_Battle_CombatTeam.<>f__mg$cache2D;
		if (Lua_BlackJack_ProjectL_Battle_CombatTeam.<>f__mg$cache2E == null)
		{
			Lua_BlackJack_ProjectL_Battle_CombatTeam.<>f__mg$cache2E = new LuaCSFunction(Lua_BlackJack_ProjectL_Battle_CombatTeam.set_m_flyObjects);
		}
		LuaObject.addMember(l, name5, get5, Lua_BlackJack_ProjectL_Battle_CombatTeam.<>f__mg$cache2E, true);
		string name6 = "s_formationPositions";
		if (Lua_BlackJack_ProjectL_Battle_CombatTeam.<>f__mg$cache2F == null)
		{
			Lua_BlackJack_ProjectL_Battle_CombatTeam.<>f__mg$cache2F = new LuaCSFunction(Lua_BlackJack_ProjectL_Battle_CombatTeam.get_s_formationPositions);
		}
		LuaCSFunction get6 = Lua_BlackJack_ProjectL_Battle_CombatTeam.<>f__mg$cache2F;
		if (Lua_BlackJack_ProjectL_Battle_CombatTeam.<>f__mg$cache30 == null)
		{
			Lua_BlackJack_ProjectL_Battle_CombatTeam.<>f__mg$cache30 = new LuaCSFunction(Lua_BlackJack_ProjectL_Battle_CombatTeam.set_s_formationPositions);
		}
		LuaObject.addMember(l, name6, get6, Lua_BlackJack_ProjectL_Battle_CombatTeam.<>f__mg$cache30, false);
		string name7 = "m_heroSkillInfo";
		if (Lua_BlackJack_ProjectL_Battle_CombatTeam.<>f__mg$cache31 == null)
		{
			Lua_BlackJack_ProjectL_Battle_CombatTeam.<>f__mg$cache31 = new LuaCSFunction(Lua_BlackJack_ProjectL_Battle_CombatTeam.get_m_heroSkillInfo);
		}
		LuaCSFunction get7 = Lua_BlackJack_ProjectL_Battle_CombatTeam.<>f__mg$cache31;
		if (Lua_BlackJack_ProjectL_Battle_CombatTeam.<>f__mg$cache32 == null)
		{
			Lua_BlackJack_ProjectL_Battle_CombatTeam.<>f__mg$cache32 = new LuaCSFunction(Lua_BlackJack_ProjectL_Battle_CombatTeam.set_m_heroSkillInfo);
		}
		LuaObject.addMember(l, name7, get7, Lua_BlackJack_ProjectL_Battle_CombatTeam.<>f__mg$cache32, true);
		string name8 = "m_shouldHeroToHeroCriticalAttack";
		if (Lua_BlackJack_ProjectL_Battle_CombatTeam.<>f__mg$cache33 == null)
		{
			Lua_BlackJack_ProjectL_Battle_CombatTeam.<>f__mg$cache33 = new LuaCSFunction(Lua_BlackJack_ProjectL_Battle_CombatTeam.get_m_shouldHeroToHeroCriticalAttack);
		}
		LuaCSFunction get8 = Lua_BlackJack_ProjectL_Battle_CombatTeam.<>f__mg$cache33;
		if (Lua_BlackJack_ProjectL_Battle_CombatTeam.<>f__mg$cache34 == null)
		{
			Lua_BlackJack_ProjectL_Battle_CombatTeam.<>f__mg$cache34 = new LuaCSFunction(Lua_BlackJack_ProjectL_Battle_CombatTeam.set_m_shouldHeroToHeroCriticalAttack);
		}
		LuaObject.addMember(l, name8, get8, Lua_BlackJack_ProjectL_Battle_CombatTeam.<>f__mg$cache34, true);
		string name9 = "m_shouldHeroToSoldierCriticalAttack";
		if (Lua_BlackJack_ProjectL_Battle_CombatTeam.<>f__mg$cache35 == null)
		{
			Lua_BlackJack_ProjectL_Battle_CombatTeam.<>f__mg$cache35 = new LuaCSFunction(Lua_BlackJack_ProjectL_Battle_CombatTeam.get_m_shouldHeroToSoldierCriticalAttack);
		}
		LuaCSFunction get9 = Lua_BlackJack_ProjectL_Battle_CombatTeam.<>f__mg$cache35;
		if (Lua_BlackJack_ProjectL_Battle_CombatTeam.<>f__mg$cache36 == null)
		{
			Lua_BlackJack_ProjectL_Battle_CombatTeam.<>f__mg$cache36 = new LuaCSFunction(Lua_BlackJack_ProjectL_Battle_CombatTeam.set_m_shouldHeroToSoldierCriticalAttack);
		}
		LuaObject.addMember(l, name9, get9, Lua_BlackJack_ProjectL_Battle_CombatTeam.<>f__mg$cache36, true);
		string name10 = "m_shouldSoldierToHeroCriticalAttack";
		if (Lua_BlackJack_ProjectL_Battle_CombatTeam.<>f__mg$cache37 == null)
		{
			Lua_BlackJack_ProjectL_Battle_CombatTeam.<>f__mg$cache37 = new LuaCSFunction(Lua_BlackJack_ProjectL_Battle_CombatTeam.get_m_shouldSoldierToHeroCriticalAttack);
		}
		LuaCSFunction get10 = Lua_BlackJack_ProjectL_Battle_CombatTeam.<>f__mg$cache37;
		if (Lua_BlackJack_ProjectL_Battle_CombatTeam.<>f__mg$cache38 == null)
		{
			Lua_BlackJack_ProjectL_Battle_CombatTeam.<>f__mg$cache38 = new LuaCSFunction(Lua_BlackJack_ProjectL_Battle_CombatTeam.set_m_shouldSoldierToHeroCriticalAttack);
		}
		LuaObject.addMember(l, name10, get10, Lua_BlackJack_ProjectL_Battle_CombatTeam.<>f__mg$cache38, true);
		string name11 = "m_shouldSoldierToSoldierCriticalAttack";
		if (Lua_BlackJack_ProjectL_Battle_CombatTeam.<>f__mg$cache39 == null)
		{
			Lua_BlackJack_ProjectL_Battle_CombatTeam.<>f__mg$cache39 = new LuaCSFunction(Lua_BlackJack_ProjectL_Battle_CombatTeam.get_m_shouldSoldierToSoldierCriticalAttack);
		}
		LuaCSFunction get11 = Lua_BlackJack_ProjectL_Battle_CombatTeam.<>f__mg$cache39;
		if (Lua_BlackJack_ProjectL_Battle_CombatTeam.<>f__mg$cache3A == null)
		{
			Lua_BlackJack_ProjectL_Battle_CombatTeam.<>f__mg$cache3A = new LuaCSFunction(Lua_BlackJack_ProjectL_Battle_CombatTeam.set_m_shouldSoldierToSoldierCriticalAttack);
		}
		LuaObject.addMember(l, name11, get11, Lua_BlackJack_ProjectL_Battle_CombatTeam.<>f__mg$cache3A, true);
		string name12 = "m_isCastAnyDamageSkill";
		if (Lua_BlackJack_ProjectL_Battle_CombatTeam.<>f__mg$cache3B == null)
		{
			Lua_BlackJack_ProjectL_Battle_CombatTeam.<>f__mg$cache3B = new LuaCSFunction(Lua_BlackJack_ProjectL_Battle_CombatTeam.get_m_isCastAnyDamageSkill);
		}
		LuaCSFunction get12 = Lua_BlackJack_ProjectL_Battle_CombatTeam.<>f__mg$cache3B;
		if (Lua_BlackJack_ProjectL_Battle_CombatTeam.<>f__mg$cache3C == null)
		{
			Lua_BlackJack_ProjectL_Battle_CombatTeam.<>f__mg$cache3C = new LuaCSFunction(Lua_BlackJack_ProjectL_Battle_CombatTeam.set_m_isCastAnyDamageSkill);
		}
		LuaObject.addMember(l, name12, get12, Lua_BlackJack_ProjectL_Battle_CombatTeam.<>f__mg$cache3C, true);
		string name13 = "m_isBeCriticalAttack";
		if (Lua_BlackJack_ProjectL_Battle_CombatTeam.<>f__mg$cache3D == null)
		{
			Lua_BlackJack_ProjectL_Battle_CombatTeam.<>f__mg$cache3D = new LuaCSFunction(Lua_BlackJack_ProjectL_Battle_CombatTeam.get_m_isBeCriticalAttack);
		}
		LuaCSFunction get13 = Lua_BlackJack_ProjectL_Battle_CombatTeam.<>f__mg$cache3D;
		if (Lua_BlackJack_ProjectL_Battle_CombatTeam.<>f__mg$cache3E == null)
		{
			Lua_BlackJack_ProjectL_Battle_CombatTeam.<>f__mg$cache3E = new LuaCSFunction(Lua_BlackJack_ProjectL_Battle_CombatTeam.set_m_isBeCriticalAttack);
		}
		LuaObject.addMember(l, name13, get13, Lua_BlackJack_ProjectL_Battle_CombatTeam.<>f__mg$cache3E, true);
		string name14 = "m_lastDamageBySkill";
		if (Lua_BlackJack_ProjectL_Battle_CombatTeam.<>f__mg$cache3F == null)
		{
			Lua_BlackJack_ProjectL_Battle_CombatTeam.<>f__mg$cache3F = new LuaCSFunction(Lua_BlackJack_ProjectL_Battle_CombatTeam.get_m_lastDamageBySkill);
		}
		LuaCSFunction get14 = Lua_BlackJack_ProjectL_Battle_CombatTeam.<>f__mg$cache3F;
		if (Lua_BlackJack_ProjectL_Battle_CombatTeam.<>f__mg$cache40 == null)
		{
			Lua_BlackJack_ProjectL_Battle_CombatTeam.<>f__mg$cache40 = new LuaCSFunction(Lua_BlackJack_ProjectL_Battle_CombatTeam.set_m_lastDamageBySkill);
		}
		LuaObject.addMember(l, name14, get14, Lua_BlackJack_ProjectL_Battle_CombatTeam.<>f__mg$cache40, true);
		string name15 = "m_heroReceiveTotalDamage";
		if (Lua_BlackJack_ProjectL_Battle_CombatTeam.<>f__mg$cache41 == null)
		{
			Lua_BlackJack_ProjectL_Battle_CombatTeam.<>f__mg$cache41 = new LuaCSFunction(Lua_BlackJack_ProjectL_Battle_CombatTeam.get_m_heroReceiveTotalDamage);
		}
		LuaCSFunction get15 = Lua_BlackJack_ProjectL_Battle_CombatTeam.<>f__mg$cache41;
		if (Lua_BlackJack_ProjectL_Battle_CombatTeam.<>f__mg$cache42 == null)
		{
			Lua_BlackJack_ProjectL_Battle_CombatTeam.<>f__mg$cache42 = new LuaCSFunction(Lua_BlackJack_ProjectL_Battle_CombatTeam.set_m_heroReceiveTotalDamage);
		}
		LuaObject.addMember(l, name15, get15, Lua_BlackJack_ProjectL_Battle_CombatTeam.<>f__mg$cache42, true);
		string name16 = "m_soldierReceiveTotalDamage";
		if (Lua_BlackJack_ProjectL_Battle_CombatTeam.<>f__mg$cache43 == null)
		{
			Lua_BlackJack_ProjectL_Battle_CombatTeam.<>f__mg$cache43 = new LuaCSFunction(Lua_BlackJack_ProjectL_Battle_CombatTeam.get_m_soldierReceiveTotalDamage);
		}
		LuaCSFunction get16 = Lua_BlackJack_ProjectL_Battle_CombatTeam.<>f__mg$cache43;
		if (Lua_BlackJack_ProjectL_Battle_CombatTeam.<>f__mg$cache44 == null)
		{
			Lua_BlackJack_ProjectL_Battle_CombatTeam.<>f__mg$cache44 = new LuaCSFunction(Lua_BlackJack_ProjectL_Battle_CombatTeam.set_m_soldierReceiveTotalDamage);
		}
		LuaObject.addMember(l, name16, get16, Lua_BlackJack_ProjectL_Battle_CombatTeam.<>f__mg$cache44, true);
		string name17 = "m_heroApplyTotalDamage";
		if (Lua_BlackJack_ProjectL_Battle_CombatTeam.<>f__mg$cache45 == null)
		{
			Lua_BlackJack_ProjectL_Battle_CombatTeam.<>f__mg$cache45 = new LuaCSFunction(Lua_BlackJack_ProjectL_Battle_CombatTeam.get_m_heroApplyTotalDamage);
		}
		LuaCSFunction get17 = Lua_BlackJack_ProjectL_Battle_CombatTeam.<>f__mg$cache45;
		if (Lua_BlackJack_ProjectL_Battle_CombatTeam.<>f__mg$cache46 == null)
		{
			Lua_BlackJack_ProjectL_Battle_CombatTeam.<>f__mg$cache46 = new LuaCSFunction(Lua_BlackJack_ProjectL_Battle_CombatTeam.set_m_heroApplyTotalDamage);
		}
		LuaObject.addMember(l, name17, get17, Lua_BlackJack_ProjectL_Battle_CombatTeam.<>f__mg$cache46, true);
		string name18 = "m_soldierApplyTotalDamage";
		if (Lua_BlackJack_ProjectL_Battle_CombatTeam.<>f__mg$cache47 == null)
		{
			Lua_BlackJack_ProjectL_Battle_CombatTeam.<>f__mg$cache47 = new LuaCSFunction(Lua_BlackJack_ProjectL_Battle_CombatTeam.get_m_soldierApplyTotalDamage);
		}
		LuaCSFunction get18 = Lua_BlackJack_ProjectL_Battle_CombatTeam.<>f__mg$cache47;
		if (Lua_BlackJack_ProjectL_Battle_CombatTeam.<>f__mg$cache48 == null)
		{
			Lua_BlackJack_ProjectL_Battle_CombatTeam.<>f__mg$cache48 = new LuaCSFunction(Lua_BlackJack_ProjectL_Battle_CombatTeam.set_m_soldierApplyTotalDamage);
		}
		LuaObject.addMember(l, name18, get18, Lua_BlackJack_ProjectL_Battle_CombatTeam.<>f__mg$cache48, true);
		string name19 = "m_isTryApplyBuff";
		if (Lua_BlackJack_ProjectL_Battle_CombatTeam.<>f__mg$cache49 == null)
		{
			Lua_BlackJack_ProjectL_Battle_CombatTeam.<>f__mg$cache49 = new LuaCSFunction(Lua_BlackJack_ProjectL_Battle_CombatTeam.get_m_isTryApplyBuff);
		}
		LuaCSFunction get19 = Lua_BlackJack_ProjectL_Battle_CombatTeam.<>f__mg$cache49;
		if (Lua_BlackJack_ProjectL_Battle_CombatTeam.<>f__mg$cache4A == null)
		{
			Lua_BlackJack_ProjectL_Battle_CombatTeam.<>f__mg$cache4A = new LuaCSFunction(Lua_BlackJack_ProjectL_Battle_CombatTeam.set_m_isTryApplyBuff);
		}
		LuaObject.addMember(l, name19, get19, Lua_BlackJack_ProjectL_Battle_CombatTeam.<>f__mg$cache4A, true);
		string name20 = "m_attachBuffSourceSkillInfo";
		if (Lua_BlackJack_ProjectL_Battle_CombatTeam.<>f__mg$cache4B == null)
		{
			Lua_BlackJack_ProjectL_Battle_CombatTeam.<>f__mg$cache4B = new LuaCSFunction(Lua_BlackJack_ProjectL_Battle_CombatTeam.get_m_attachBuffSourceSkillInfo);
		}
		LuaCSFunction get20 = Lua_BlackJack_ProjectL_Battle_CombatTeam.<>f__mg$cache4B;
		if (Lua_BlackJack_ProjectL_Battle_CombatTeam.<>f__mg$cache4C == null)
		{
			Lua_BlackJack_ProjectL_Battle_CombatTeam.<>f__mg$cache4C = new LuaCSFunction(Lua_BlackJack_ProjectL_Battle_CombatTeam.set_m_attachBuffSourceSkillInfo);
		}
		LuaObject.addMember(l, name20, get20, Lua_BlackJack_ProjectL_Battle_CombatTeam.<>f__mg$cache4C, true);
		string name21 = "m_doubleAttackBuffState";
		if (Lua_BlackJack_ProjectL_Battle_CombatTeam.<>f__mg$cache4D == null)
		{
			Lua_BlackJack_ProjectL_Battle_CombatTeam.<>f__mg$cache4D = new LuaCSFunction(Lua_BlackJack_ProjectL_Battle_CombatTeam.get_m_doubleAttackBuffState);
		}
		LuaCSFunction get21 = Lua_BlackJack_ProjectL_Battle_CombatTeam.<>f__mg$cache4D;
		if (Lua_BlackJack_ProjectL_Battle_CombatTeam.<>f__mg$cache4E == null)
		{
			Lua_BlackJack_ProjectL_Battle_CombatTeam.<>f__mg$cache4E = new LuaCSFunction(Lua_BlackJack_ProjectL_Battle_CombatTeam.set_m_doubleAttackBuffState);
		}
		LuaObject.addMember(l, name21, get21, Lua_BlackJack_ProjectL_Battle_CombatTeam.<>f__mg$cache4E, true);
		string name22 = "Combat";
		if (Lua_BlackJack_ProjectL_Battle_CombatTeam.<>f__mg$cache4F == null)
		{
			Lua_BlackJack_ProjectL_Battle_CombatTeam.<>f__mg$cache4F = new LuaCSFunction(Lua_BlackJack_ProjectL_Battle_CombatTeam.get_Combat);
		}
		LuaObject.addMember(l, name22, Lua_BlackJack_ProjectL_Battle_CombatTeam.<>f__mg$cache4F, null, true);
		string name23 = "TeamNumber";
		if (Lua_BlackJack_ProjectL_Battle_CombatTeam.<>f__mg$cache50 == null)
		{
			Lua_BlackJack_ProjectL_Battle_CombatTeam.<>f__mg$cache50 = new LuaCSFunction(Lua_BlackJack_ProjectL_Battle_CombatTeam.get_TeamNumber);
		}
		LuaObject.addMember(l, name23, Lua_BlackJack_ProjectL_Battle_CombatTeam.<>f__mg$cache50, null, true);
		string name24 = "BattleActor";
		if (Lua_BlackJack_ProjectL_Battle_CombatTeam.<>f__mg$cache51 == null)
		{
			Lua_BlackJack_ProjectL_Battle_CombatTeam.<>f__mg$cache51 = new LuaCSFunction(Lua_BlackJack_ProjectL_Battle_CombatTeam.get_BattleActor);
		}
		LuaObject.addMember(l, name24, Lua_BlackJack_ProjectL_Battle_CombatTeam.<>f__mg$cache51, null, true);
		string name25 = "HeroInfo";
		if (Lua_BlackJack_ProjectL_Battle_CombatTeam.<>f__mg$cache52 == null)
		{
			Lua_BlackJack_ProjectL_Battle_CombatTeam.<>f__mg$cache52 = new LuaCSFunction(Lua_BlackJack_ProjectL_Battle_CombatTeam.get_HeroInfo);
		}
		LuaObject.addMember(l, name25, Lua_BlackJack_ProjectL_Battle_CombatTeam.<>f__mg$cache52, null, true);
		string name26 = "HeroArmyInfo";
		if (Lua_BlackJack_ProjectL_Battle_CombatTeam.<>f__mg$cache53 == null)
		{
			Lua_BlackJack_ProjectL_Battle_CombatTeam.<>f__mg$cache53 = new LuaCSFunction(Lua_BlackJack_ProjectL_Battle_CombatTeam.get_HeroArmyInfo);
		}
		LuaObject.addMember(l, name26, Lua_BlackJack_ProjectL_Battle_CombatTeam.<>f__mg$cache53, null, true);
		string name27 = "JobConnectionInfo";
		if (Lua_BlackJack_ProjectL_Battle_CombatTeam.<>f__mg$cache54 == null)
		{
			Lua_BlackJack_ProjectL_Battle_CombatTeam.<>f__mg$cache54 = new LuaCSFunction(Lua_BlackJack_ProjectL_Battle_CombatTeam.get_JobConnectionInfo);
		}
		LuaObject.addMember(l, name27, Lua_BlackJack_ProjectL_Battle_CombatTeam.<>f__mg$cache54, null, true);
		string name28 = "JobInfo";
		if (Lua_BlackJack_ProjectL_Battle_CombatTeam.<>f__mg$cache55 == null)
		{
			Lua_BlackJack_ProjectL_Battle_CombatTeam.<>f__mg$cache55 = new LuaCSFunction(Lua_BlackJack_ProjectL_Battle_CombatTeam.get_JobInfo);
		}
		LuaObject.addMember(l, name28, Lua_BlackJack_ProjectL_Battle_CombatTeam.<>f__mg$cache55, null, true);
		string name29 = "SoldierInfo";
		if (Lua_BlackJack_ProjectL_Battle_CombatTeam.<>f__mg$cache56 == null)
		{
			Lua_BlackJack_ProjectL_Battle_CombatTeam.<>f__mg$cache56 = new LuaCSFunction(Lua_BlackJack_ProjectL_Battle_CombatTeam.get_SoldierInfo);
		}
		LuaObject.addMember(l, name29, Lua_BlackJack_ProjectL_Battle_CombatTeam.<>f__mg$cache56, null, true);
		string name30 = "SoldierArmyInfo";
		if (Lua_BlackJack_ProjectL_Battle_CombatTeam.<>f__mg$cache57 == null)
		{
			Lua_BlackJack_ProjectL_Battle_CombatTeam.<>f__mg$cache57 = new LuaCSFunction(Lua_BlackJack_ProjectL_Battle_CombatTeam.get_SoldierArmyInfo);
		}
		LuaObject.addMember(l, name30, Lua_BlackJack_ProjectL_Battle_CombatTeam.<>f__mg$cache57, null, true);
		string name31 = "HeroSkill";
		if (Lua_BlackJack_ProjectL_Battle_CombatTeam.<>f__mg$cache58 == null)
		{
			Lua_BlackJack_ProjectL_Battle_CombatTeam.<>f__mg$cache58 = new LuaCSFunction(Lua_BlackJack_ProjectL_Battle_CombatTeam.get_HeroSkill);
		}
		LuaObject.addMember(l, name31, Lua_BlackJack_ProjectL_Battle_CombatTeam.<>f__mg$cache58, null, true);
		string name32 = "HeroLevel";
		if (Lua_BlackJack_ProjectL_Battle_CombatTeam.<>f__mg$cache59 == null)
		{
			Lua_BlackJack_ProjectL_Battle_CombatTeam.<>f__mg$cache59 = new LuaCSFunction(Lua_BlackJack_ProjectL_Battle_CombatTeam.get_HeroLevel);
		}
		LuaObject.addMember(l, name32, Lua_BlackJack_ProjectL_Battle_CombatTeam.<>f__mg$cache59, null, true);
		string name33 = "HeroStar";
		if (Lua_BlackJack_ProjectL_Battle_CombatTeam.<>f__mg$cache5A == null)
		{
			Lua_BlackJack_ProjectL_Battle_CombatTeam.<>f__mg$cache5A = new LuaCSFunction(Lua_BlackJack_ProjectL_Battle_CombatTeam.get_HeroStar);
		}
		LuaObject.addMember(l, name33, Lua_BlackJack_ProjectL_Battle_CombatTeam.<>f__mg$cache5A, null, true);
		string name34 = "JobLevel";
		if (Lua_BlackJack_ProjectL_Battle_CombatTeam.<>f__mg$cache5B == null)
		{
			Lua_BlackJack_ProjectL_Battle_CombatTeam.<>f__mg$cache5B = new LuaCSFunction(Lua_BlackJack_ProjectL_Battle_CombatTeam.get_JobLevel);
		}
		LuaObject.addMember(l, name34, Lua_BlackJack_ProjectL_Battle_CombatTeam.<>f__mg$cache5B, null, true);
		string name35 = "ShouldHeroToHeroCriticalAttack";
		if (Lua_BlackJack_ProjectL_Battle_CombatTeam.<>f__mg$cache5C == null)
		{
			Lua_BlackJack_ProjectL_Battle_CombatTeam.<>f__mg$cache5C = new LuaCSFunction(Lua_BlackJack_ProjectL_Battle_CombatTeam.get_ShouldHeroToHeroCriticalAttack);
		}
		LuaObject.addMember(l, name35, Lua_BlackJack_ProjectL_Battle_CombatTeam.<>f__mg$cache5C, null, true);
		string name36 = "ShouldHeroToSoldierCriticalAttack";
		if (Lua_BlackJack_ProjectL_Battle_CombatTeam.<>f__mg$cache5D == null)
		{
			Lua_BlackJack_ProjectL_Battle_CombatTeam.<>f__mg$cache5D = new LuaCSFunction(Lua_BlackJack_ProjectL_Battle_CombatTeam.get_ShouldHeroToSoldierCriticalAttack);
		}
		LuaObject.addMember(l, name36, Lua_BlackJack_ProjectL_Battle_CombatTeam.<>f__mg$cache5D, null, true);
		string name37 = "ShouldSoldierToHeroCriticalAttack";
		if (Lua_BlackJack_ProjectL_Battle_CombatTeam.<>f__mg$cache5E == null)
		{
			Lua_BlackJack_ProjectL_Battle_CombatTeam.<>f__mg$cache5E = new LuaCSFunction(Lua_BlackJack_ProjectL_Battle_CombatTeam.get_ShouldSoldierToHeroCriticalAttack);
		}
		LuaObject.addMember(l, name37, Lua_BlackJack_ProjectL_Battle_CombatTeam.<>f__mg$cache5E, null, true);
		string name38 = "ShouldSoldierToSoldierCriticalAttack";
		if (Lua_BlackJack_ProjectL_Battle_CombatTeam.<>f__mg$cache5F == null)
		{
			Lua_BlackJack_ProjectL_Battle_CombatTeam.<>f__mg$cache5F = new LuaCSFunction(Lua_BlackJack_ProjectL_Battle_CombatTeam.get_ShouldSoldierToSoldierCriticalAttack);
		}
		LuaObject.addMember(l, name38, Lua_BlackJack_ProjectL_Battle_CombatTeam.<>f__mg$cache5F, null, true);
		string name39 = "IsCastAnyDamageSkill";
		if (Lua_BlackJack_ProjectL_Battle_CombatTeam.<>f__mg$cache60 == null)
		{
			Lua_BlackJack_ProjectL_Battle_CombatTeam.<>f__mg$cache60 = new LuaCSFunction(Lua_BlackJack_ProjectL_Battle_CombatTeam.get_IsCastAnyDamageSkill);
		}
		LuaObject.addMember(l, name39, Lua_BlackJack_ProjectL_Battle_CombatTeam.<>f__mg$cache60, null, true);
		string name40 = "IsBeCriticalAttack";
		if (Lua_BlackJack_ProjectL_Battle_CombatTeam.<>f__mg$cache61 == null)
		{
			Lua_BlackJack_ProjectL_Battle_CombatTeam.<>f__mg$cache61 = new LuaCSFunction(Lua_BlackJack_ProjectL_Battle_CombatTeam.get_IsBeCriticalAttack);
		}
		LuaObject.addMember(l, name40, Lua_BlackJack_ProjectL_Battle_CombatTeam.<>f__mg$cache61, null, true);
		string name41 = "HeroReceiveTotalDamage";
		if (Lua_BlackJack_ProjectL_Battle_CombatTeam.<>f__mg$cache62 == null)
		{
			Lua_BlackJack_ProjectL_Battle_CombatTeam.<>f__mg$cache62 = new LuaCSFunction(Lua_BlackJack_ProjectL_Battle_CombatTeam.get_HeroReceiveTotalDamage);
		}
		LuaObject.addMember(l, name41, Lua_BlackJack_ProjectL_Battle_CombatTeam.<>f__mg$cache62, null, true);
		string name42 = "SoldierReceiveTotalDamage";
		if (Lua_BlackJack_ProjectL_Battle_CombatTeam.<>f__mg$cache63 == null)
		{
			Lua_BlackJack_ProjectL_Battle_CombatTeam.<>f__mg$cache63 = new LuaCSFunction(Lua_BlackJack_ProjectL_Battle_CombatTeam.get_SoldierReceiveTotalDamage);
		}
		LuaObject.addMember(l, name42, Lua_BlackJack_ProjectL_Battle_CombatTeam.<>f__mg$cache63, null, true);
		string name43 = "HeroApplyTotalDamage";
		if (Lua_BlackJack_ProjectL_Battle_CombatTeam.<>f__mg$cache64 == null)
		{
			Lua_BlackJack_ProjectL_Battle_CombatTeam.<>f__mg$cache64 = new LuaCSFunction(Lua_BlackJack_ProjectL_Battle_CombatTeam.get_HeroApplyTotalDamage);
		}
		LuaObject.addMember(l, name43, Lua_BlackJack_ProjectL_Battle_CombatTeam.<>f__mg$cache64, null, true);
		string name44 = "SoldierApplyTotalDamage";
		if (Lua_BlackJack_ProjectL_Battle_CombatTeam.<>f__mg$cache65 == null)
		{
			Lua_BlackJack_ProjectL_Battle_CombatTeam.<>f__mg$cache65 = new LuaCSFunction(Lua_BlackJack_ProjectL_Battle_CombatTeam.get_SoldierApplyTotalDamage);
		}
		LuaObject.addMember(l, name44, Lua_BlackJack_ProjectL_Battle_CombatTeam.<>f__mg$cache65, null, true);
		if (Lua_BlackJack_ProjectL_Battle_CombatTeam.<>f__mg$cache66 == null)
		{
			Lua_BlackJack_ProjectL_Battle_CombatTeam.<>f__mg$cache66 = new LuaCSFunction(Lua_BlackJack_ProjectL_Battle_CombatTeam.constructor);
		}
		LuaObject.createTypeMetatable(l, Lua_BlackJack_ProjectL_Battle_CombatTeam.<>f__mg$cache66, typeof(CombatTeam));
	}

	// Token: 0x0400DCD4 RID: 56532
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache0;

	// Token: 0x0400DCD5 RID: 56533
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1;

	// Token: 0x0400DCD6 RID: 56534
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2;

	// Token: 0x0400DCD7 RID: 56535
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3;

	// Token: 0x0400DCD8 RID: 56536
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache4;

	// Token: 0x0400DCD9 RID: 56537
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache5;

	// Token: 0x0400DCDA RID: 56538
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache6;

	// Token: 0x0400DCDB RID: 56539
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache7;

	// Token: 0x0400DCDC RID: 56540
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache8;

	// Token: 0x0400DCDD RID: 56541
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache9;

	// Token: 0x0400DCDE RID: 56542
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheA;

	// Token: 0x0400DCDF RID: 56543
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheB;

	// Token: 0x0400DCE0 RID: 56544
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheC;

	// Token: 0x0400DCE1 RID: 56545
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheD;

	// Token: 0x0400DCE2 RID: 56546
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheE;

	// Token: 0x0400DCE3 RID: 56547
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheF;

	// Token: 0x0400DCE4 RID: 56548
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache10;

	// Token: 0x0400DCE5 RID: 56549
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache11;

	// Token: 0x0400DCE6 RID: 56550
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache12;

	// Token: 0x0400DCE7 RID: 56551
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache13;

	// Token: 0x0400DCE8 RID: 56552
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache14;

	// Token: 0x0400DCE9 RID: 56553
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache15;

	// Token: 0x0400DCEA RID: 56554
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache16;

	// Token: 0x0400DCEB RID: 56555
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache17;

	// Token: 0x0400DCEC RID: 56556
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache18;

	// Token: 0x0400DCED RID: 56557
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache19;

	// Token: 0x0400DCEE RID: 56558
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1A;

	// Token: 0x0400DCEF RID: 56559
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1B;

	// Token: 0x0400DCF0 RID: 56560
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1C;

	// Token: 0x0400DCF1 RID: 56561
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1D;

	// Token: 0x0400DCF2 RID: 56562
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1E;

	// Token: 0x0400DCF3 RID: 56563
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1F;

	// Token: 0x0400DCF4 RID: 56564
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache20;

	// Token: 0x0400DCF5 RID: 56565
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache21;

	// Token: 0x0400DCF6 RID: 56566
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache22;

	// Token: 0x0400DCF7 RID: 56567
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache23;

	// Token: 0x0400DCF8 RID: 56568
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache24;

	// Token: 0x0400DCF9 RID: 56569
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache25;

	// Token: 0x0400DCFA RID: 56570
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache26;

	// Token: 0x0400DCFB RID: 56571
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache27;

	// Token: 0x0400DCFC RID: 56572
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache28;

	// Token: 0x0400DCFD RID: 56573
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache29;

	// Token: 0x0400DCFE RID: 56574
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2A;

	// Token: 0x0400DCFF RID: 56575
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2B;

	// Token: 0x0400DD00 RID: 56576
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2C;

	// Token: 0x0400DD01 RID: 56577
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2D;

	// Token: 0x0400DD02 RID: 56578
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2E;

	// Token: 0x0400DD03 RID: 56579
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2F;

	// Token: 0x0400DD04 RID: 56580
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache30;

	// Token: 0x0400DD05 RID: 56581
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache31;

	// Token: 0x0400DD06 RID: 56582
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache32;

	// Token: 0x0400DD07 RID: 56583
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache33;

	// Token: 0x0400DD08 RID: 56584
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache34;

	// Token: 0x0400DD09 RID: 56585
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache35;

	// Token: 0x0400DD0A RID: 56586
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache36;

	// Token: 0x0400DD0B RID: 56587
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache37;

	// Token: 0x0400DD0C RID: 56588
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache38;

	// Token: 0x0400DD0D RID: 56589
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache39;

	// Token: 0x0400DD0E RID: 56590
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3A;

	// Token: 0x0400DD0F RID: 56591
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3B;

	// Token: 0x0400DD10 RID: 56592
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3C;

	// Token: 0x0400DD11 RID: 56593
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3D;

	// Token: 0x0400DD12 RID: 56594
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3E;

	// Token: 0x0400DD13 RID: 56595
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3F;

	// Token: 0x0400DD14 RID: 56596
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache40;

	// Token: 0x0400DD15 RID: 56597
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache41;

	// Token: 0x0400DD16 RID: 56598
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache42;

	// Token: 0x0400DD17 RID: 56599
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache43;

	// Token: 0x0400DD18 RID: 56600
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache44;

	// Token: 0x0400DD19 RID: 56601
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache45;

	// Token: 0x0400DD1A RID: 56602
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache46;

	// Token: 0x0400DD1B RID: 56603
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache47;

	// Token: 0x0400DD1C RID: 56604
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache48;

	// Token: 0x0400DD1D RID: 56605
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache49;

	// Token: 0x0400DD1E RID: 56606
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache4A;

	// Token: 0x0400DD1F RID: 56607
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache4B;

	// Token: 0x0400DD20 RID: 56608
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache4C;

	// Token: 0x0400DD21 RID: 56609
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache4D;

	// Token: 0x0400DD22 RID: 56610
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache4E;

	// Token: 0x0400DD23 RID: 56611
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache4F;

	// Token: 0x0400DD24 RID: 56612
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache50;

	// Token: 0x0400DD25 RID: 56613
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache51;

	// Token: 0x0400DD26 RID: 56614
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache52;

	// Token: 0x0400DD27 RID: 56615
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache53;

	// Token: 0x0400DD28 RID: 56616
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache54;

	// Token: 0x0400DD29 RID: 56617
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache55;

	// Token: 0x0400DD2A RID: 56618
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache56;

	// Token: 0x0400DD2B RID: 56619
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache57;

	// Token: 0x0400DD2C RID: 56620
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache58;

	// Token: 0x0400DD2D RID: 56621
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache59;

	// Token: 0x0400DD2E RID: 56622
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache5A;

	// Token: 0x0400DD2F RID: 56623
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache5B;

	// Token: 0x0400DD30 RID: 56624
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache5C;

	// Token: 0x0400DD31 RID: 56625
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache5D;

	// Token: 0x0400DD32 RID: 56626
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache5E;

	// Token: 0x0400DD33 RID: 56627
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache5F;

	// Token: 0x0400DD34 RID: 56628
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache60;

	// Token: 0x0400DD35 RID: 56629
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache61;

	// Token: 0x0400DD36 RID: 56630
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache62;

	// Token: 0x0400DD37 RID: 56631
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache63;

	// Token: 0x0400DD38 RID: 56632
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache64;

	// Token: 0x0400DD39 RID: 56633
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache65;

	// Token: 0x0400DD3A RID: 56634
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache66;
}
