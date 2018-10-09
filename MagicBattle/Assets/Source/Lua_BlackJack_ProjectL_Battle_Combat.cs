using System;
using System.Runtime.CompilerServices;
using BlackJack.ConfigData;
using BlackJack.ProjectL.Battle;
using BlackJack.ProjectL.Common;
using SLua;
using UnityEngine.Scripting;

// Token: 0x020011A5 RID: 4517
[Preserve]
public class Lua_BlackJack_ProjectL_Battle_Combat : LuaObject
{
	// Token: 0x060174FA RID: 95482 RVA: 0x00655834 File Offset: 0x00653A34
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int constructor(IntPtr l)
	{
		int result;
		try
		{
			BattleBase battle;
			LuaObject.checkType<BattleBase>(l, 2, out battle);
			Combat o = new Combat(battle);
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

	// Token: 0x060174FB RID: 95483 RVA: 0x00655888 File Offset: 0x00653A88
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int Dispose(IntPtr l)
	{
		int result;
		try
		{
			Combat combat = (Combat)LuaObject.checkSelf(l);
			combat.Dispose();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060174FC RID: 95484 RVA: 0x006558D4 File Offset: 0x00653AD4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int Tick(IntPtr l)
	{
		int result;
		try
		{
			Combat combat = (Combat)LuaObject.checkSelf(l);
			combat.Tick();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060174FD RID: 95485 RVA: 0x00655920 File Offset: 0x00653B20
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int TickGraphic(IntPtr l)
	{
		int result;
		try
		{
			Combat combat = (Combat)LuaObject.checkSelf(l);
			float dt;
			LuaObject.checkType(l, 2, out dt);
			combat.TickGraphic(dt);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060174FE RID: 95486 RVA: 0x00655978 File Offset: 0x00653B78
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int Draw(IntPtr l)
	{
		int result;
		try
		{
			Combat combat = (Combat)LuaObject.checkSelf(l);
			combat.Draw();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060174FF RID: 95487 RVA: 0x006559C4 File Offset: 0x00653BC4
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int Start(IntPtr l)
	{
		int result;
		try
		{
			Combat combat = (Combat)LuaObject.checkSelf(l);
			BattleActor actor;
			LuaObject.checkType<BattleActor>(l, 2, out actor);
			BattleActor actor2;
			LuaObject.checkType<BattleActor>(l, 3, out actor2);
			ConfigDataSkillInfo heroSkillInfo;
			LuaObject.checkType<ConfigDataSkillInfo>(l, 4, out heroSkillInfo);
			ConfigDataSkillInfo heroSkillInfo2;
			LuaObject.checkType<ConfigDataSkillInfo>(l, 5, out heroSkillInfo2);
			int randomSeed;
			LuaObject.checkType(l, 6, out randomSeed);
			combat.Start(actor, actor2, heroSkillInfo, heroSkillInfo2, randomSeed);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06017500 RID: 95488 RVA: 0x00655A50 File Offset: 0x00653C50
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int Stop(IntPtr l)
	{
		int result;
		try
		{
			Combat combat = (Combat)LuaObject.checkSelf(l);
			combat.Stop();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06017501 RID: 95489 RVA: 0x00655A9C File Offset: 0x00653C9C
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int Clear(IntPtr l)
	{
		int result;
		try
		{
			Combat combat = (Combat)LuaObject.checkSelf(l);
			combat.Clear();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06017502 RID: 95490 RVA: 0x00655AE8 File Offset: 0x00653CE8
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int GetTeam(IntPtr l)
	{
		int result;
		try
		{
			Combat combat = (Combat)LuaObject.checkSelf(l);
			int teamNumber;
			LuaObject.checkType(l, 2, out teamNumber);
			CombatTeam team = combat.GetTeam(teamNumber);
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

	// Token: 0x06017503 RID: 95491 RVA: 0x00655B4C File Offset: 0x00653D4C
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int GetNextEntityId(IntPtr l)
	{
		int result;
		try
		{
			Combat combat = (Combat)LuaObject.checkSelf(l);
			int nextEntityId = combat.GetNextEntityId();
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, nextEntityId);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06017504 RID: 95492 RVA: 0x00655BA0 File Offset: 0x00653DA0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int GetNextHitId(IntPtr l)
	{
		int result;
		try
		{
			Combat combat = (Combat)LuaObject.checkSelf(l);
			ushort nextHitId = combat.GetNextHitId();
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, nextHitId);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06017505 RID: 95493 RVA: 0x00655BF4 File Offset: 0x00653DF4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int GetCombatGridDistance(IntPtr l)
	{
		int result;
		try
		{
			Combat combat = (Combat)LuaObject.checkSelf(l);
			int combatGridDistance = combat.GetCombatGridDistance();
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, combatGridDistance);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06017506 RID: 95494 RVA: 0x00655C48 File Offset: 0x00653E48
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int OnActorCastSkill(IntPtr l)
	{
		int result;
		try
		{
			Combat combat = (Combat)LuaObject.checkSelf(l);
			CombatActor a;
			LuaObject.checkType<CombatActor>(l, 2, out a);
			ConfigDataSkillInfo skillInfo;
			LuaObject.checkType<ConfigDataSkillInfo>(l, 3, out skillInfo);
			combat.OnActorCastSkill(a, skillInfo);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06017507 RID: 95495 RVA: 0x00655CAC File Offset: 0x00653EAC
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int OnActorCastPassiveSkill(IntPtr l)
	{
		int result;
		try
		{
			Combat combat = (Combat)LuaObject.checkSelf(l);
			CombatActor a;
			LuaObject.checkType<CombatActor>(l, 2, out a);
			BuffState sourceBuffState;
			LuaObject.checkType<BuffState>(l, 3, out sourceBuffState);
			combat.OnActorCastPassiveSkill(a, sourceBuffState);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06017508 RID: 95496 RVA: 0x00655D10 File Offset: 0x00653F10
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int OnActorDie(IntPtr l)
	{
		int result;
		try
		{
			Combat combat = (Combat)LuaObject.checkSelf(l);
			CombatActor a;
			LuaObject.checkType<CombatActor>(l, 2, out a);
			combat.OnActorDie(a);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06017509 RID: 95497 RVA: 0x00655D68 File Offset: 0x00653F68
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int IsPlay(IntPtr l)
	{
		int result;
		try
		{
			Combat combat = (Combat)LuaObject.checkSelf(l);
			bool b = combat.IsPlay();
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

	// Token: 0x0601750A RID: 95498 RVA: 0x00655DBC File Offset: 0x00653FBC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int IsPaused(IntPtr l)
	{
		int result;
		try
		{
			Combat combat = (Combat)LuaObject.checkSelf(l);
			bool b = combat.IsPaused();
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

	// Token: 0x0601750B RID: 95499 RVA: 0x00655E10 File Offset: 0x00654010
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int IsProbabilitySatisfied(IntPtr l)
	{
		int result;
		try
		{
			Combat combat = (Combat)LuaObject.checkSelf(l);
			int rate;
			LuaObject.checkType(l, 2, out rate);
			bool b = combat.IsProbabilitySatisfied(rate);
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

	// Token: 0x0601750C RID: 95500 RVA: 0x00655E74 File Offset: 0x00654074
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int GetFrameCount(IntPtr l)
	{
		int result;
		try
		{
			Combat combat = (Combat)LuaObject.checkSelf(l);
			int frameCount = combat.GetFrameCount();
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, frameCount);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601750D RID: 95501 RVA: 0x00655EC8 File Offset: 0x006540C8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int FrameToMillisecond_s(IntPtr l)
	{
		int result;
		try
		{
			int frame;
			LuaObject.checkType(l, 1, out frame);
			int i = Combat.FrameToMillisecond(frame);
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

	// Token: 0x0601750E RID: 95502 RVA: 0x00655F1C File Offset: 0x0065411C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int MillisecondToFrame_s(IntPtr l)
	{
		int result;
		try
		{
			int ms;
			LuaObject.checkType(l, 1, out ms);
			int i = Combat.MillisecondToFrame(ms);
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

	// Token: 0x0601750F RID: 95503 RVA: 0x00655F70 File Offset: 0x00654170
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int MillisecondToFrame1_s(IntPtr l)
	{
		int result;
		try
		{
			int ms;
			LuaObject.checkType(l, 1, out ms);
			int i = Combat.MillisecondToFrame1(ms);
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

	// Token: 0x06017510 RID: 95504 RVA: 0x00655FC4 File Offset: 0x006541C4
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int Pause(IntPtr l)
	{
		int result;
		try
		{
			Combat combat = (Combat)LuaObject.checkSelf(l);
			bool pause;
			LuaObject.checkType(l, 2, out pause);
			combat.m_luaExportHelper.Pause(pause);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06017511 RID: 95505 RVA: 0x00656020 File Offset: 0x00654220
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int SetupTeam(IntPtr l)
	{
		int result;
		try
		{
			Combat combat = (Combat)LuaObject.checkSelf(l);
			int teamNumber;
			LuaObject.checkType(l, 2, out teamNumber);
			BattleActor battleActor;
			LuaObject.checkType<BattleActor>(l, 3, out battleActor);
			ConfigDataSkillInfo heroSkillInfo;
			LuaObject.checkType<ConfigDataSkillInfo>(l, 4, out heroSkillInfo);
			combat.m_luaExportHelper.SetupTeam(teamNumber, battleActor, heroSkillInfo);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06017512 RID: 95506 RVA: 0x00656098 File Offset: 0x00654298
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_battle(IntPtr l)
	{
		int result;
		try
		{
			Combat combat = (Combat)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, combat.m_luaExportHelper.m_battle);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06017513 RID: 95507 RVA: 0x006560F0 File Offset: 0x006542F0
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_m_battle(IntPtr l)
	{
		int result;
		try
		{
			Combat combat = (Combat)LuaObject.checkSelf(l);
			BattleBase battle;
			LuaObject.checkType<BattleBase>(l, 2, out battle);
			combat.m_luaExportHelper.m_battle = battle;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06017514 RID: 95508 RVA: 0x0065614C File Offset: 0x0065434C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_randomNumber(IntPtr l)
	{
		int result;
		try
		{
			Combat combat = (Combat)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, combat.m_luaExportHelper.m_randomNumber);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06017515 RID: 95509 RVA: 0x006561A4 File Offset: 0x006543A4
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_m_randomNumber(IntPtr l)
	{
		int result;
		try
		{
			Combat combat = (Combat)LuaObject.checkSelf(l);
			RandomNumber randomNumber;
			LuaObject.checkType<RandomNumber>(l, 2, out randomNumber);
			combat.m_luaExportHelper.m_randomNumber = randomNumber;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06017516 RID: 95510 RVA: 0x00656200 File Offset: 0x00654400
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_state(IntPtr l)
	{
		int result;
		try
		{
			Combat combat = (Combat)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushEnum(l, (int)combat.m_luaExportHelper.m_state);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06017517 RID: 95511 RVA: 0x00656258 File Offset: 0x00654458
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_m_state(IntPtr l)
	{
		int result;
		try
		{
			Combat combat = (Combat)LuaObject.checkSelf(l);
			CombatState state;
			LuaObject.checkEnum<CombatState>(l, 2, out state);
			combat.m_luaExportHelper.m_state = state;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06017518 RID: 95512 RVA: 0x006562B4 File Offset: 0x006544B4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_isPaused(IntPtr l)
	{
		int result;
		try
		{
			Combat combat = (Combat)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, combat.m_luaExportHelper.m_isPaused);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06017519 RID: 95513 RVA: 0x0065630C File Offset: 0x0065450C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_isPaused(IntPtr l)
	{
		int result;
		try
		{
			Combat combat = (Combat)LuaObject.checkSelf(l);
			bool isPaused;
			LuaObject.checkType(l, 2, out isPaused);
			combat.m_luaExportHelper.m_isPaused = isPaused;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601751A RID: 95514 RVA: 0x00656368 File Offset: 0x00654568
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_m_entityIdCounter(IntPtr l)
	{
		int result;
		try
		{
			Combat combat = (Combat)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, combat.m_luaExportHelper.m_entityIdCounter);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601751B RID: 95515 RVA: 0x006563C0 File Offset: 0x006545C0
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_m_entityIdCounter(IntPtr l)
	{
		int result;
		try
		{
			Combat combat = (Combat)LuaObject.checkSelf(l);
			int entityIdCounter;
			LuaObject.checkType(l, 2, out entityIdCounter);
			combat.m_luaExportHelper.m_entityIdCounter = entityIdCounter;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601751C RID: 95516 RVA: 0x0065641C File Offset: 0x0065461C
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_m_hitIdCounter(IntPtr l)
	{
		int result;
		try
		{
			Combat combat = (Combat)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, combat.m_luaExportHelper.m_hitIdCounter);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601751D RID: 95517 RVA: 0x00656474 File Offset: 0x00654674
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_hitIdCounter(IntPtr l)
	{
		int result;
		try
		{
			Combat combat = (Combat)LuaObject.checkSelf(l);
			ushort hitIdCounter;
			LuaObject.checkType(l, 2, out hitIdCounter);
			combat.m_luaExportHelper.m_hitIdCounter = hitIdCounter;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601751E RID: 95518 RVA: 0x006564D0 File Offset: 0x006546D0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_combatGridDistance(IntPtr l)
	{
		int result;
		try
		{
			Combat combat = (Combat)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, combat.m_luaExportHelper.m_combatGridDistance);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601751F RID: 95519 RVA: 0x00656528 File Offset: 0x00654728
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_combatGridDistance(IntPtr l)
	{
		int result;
		try
		{
			Combat combat = (Combat)LuaObject.checkSelf(l);
			int combatGridDistance;
			LuaObject.checkType(l, 2, out combatGridDistance);
			combat.m_luaExportHelper.m_combatGridDistance = combatGridDistance;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06017520 RID: 95520 RVA: 0x00656584 File Offset: 0x00654784
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_m_frameCount(IntPtr l)
	{
		int result;
		try
		{
			Combat combat = (Combat)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, combat.m_luaExportHelper.m_frameCount);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06017521 RID: 95521 RVA: 0x006565DC File Offset: 0x006547DC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_frameCount(IntPtr l)
	{
		int result;
		try
		{
			Combat combat = (Combat)LuaObject.checkSelf(l);
			int frameCount;
			LuaObject.checkType(l, 2, out frameCount);
			combat.m_luaExportHelper.m_frameCount = frameCount;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06017522 RID: 95522 RVA: 0x00656638 File Offset: 0x00654838
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_startCountdown(IntPtr l)
	{
		int result;
		try
		{
			Combat combat = (Combat)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, combat.m_luaExportHelper.m_startCountdown);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06017523 RID: 95523 RVA: 0x00656690 File Offset: 0x00654890
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_m_startCountdown(IntPtr l)
	{
		int result;
		try
		{
			Combat combat = (Combat)LuaObject.checkSelf(l);
			int startCountdown;
			LuaObject.checkType(l, 2, out startCountdown);
			combat.m_luaExportHelper.m_startCountdown = startCountdown;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06017524 RID: 95524 RVA: 0x006566EC File Offset: 0x006548EC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_endCountdown(IntPtr l)
	{
		int result;
		try
		{
			Combat combat = (Combat)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, combat.m_luaExportHelper.m_endCountdown);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06017525 RID: 95525 RVA: 0x00656744 File Offset: 0x00654944
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_m_endCountdown(IntPtr l)
	{
		int result;
		try
		{
			Combat combat = (Combat)LuaObject.checkSelf(l);
			int endCountdown;
			LuaObject.checkType(l, 2, out endCountdown);
			combat.m_luaExportHelper.m_endCountdown = endCountdown;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06017526 RID: 95526 RVA: 0x006567A0 File Offset: 0x006549A0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_cutscenePauseCountdown(IntPtr l)
	{
		int result;
		try
		{
			Combat combat = (Combat)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, combat.m_luaExportHelper.m_cutscenePauseCountdown);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06017527 RID: 95527 RVA: 0x006567F8 File Offset: 0x006549F8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_cutscenePauseCountdown(IntPtr l)
	{
		int result;
		try
		{
			Combat combat = (Combat)LuaObject.checkSelf(l);
			int cutscenePauseCountdown;
			LuaObject.checkType(l, 2, out cutscenePauseCountdown);
			combat.m_luaExportHelper.m_cutscenePauseCountdown = cutscenePauseCountdown;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06017528 RID: 95528 RVA: 0x00656854 File Offset: 0x00654A54
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_m_teams(IntPtr l)
	{
		int result;
		try
		{
			Combat combat = (Combat)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, combat.m_luaExportHelper.m_teams);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06017529 RID: 95529 RVA: 0x006568AC File Offset: 0x00654AAC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_teams(IntPtr l)
	{
		int result;
		try
		{
			Combat combat = (Combat)LuaObject.checkSelf(l);
			CombatTeam[] teams;
			LuaObject.checkArray<CombatTeam>(l, 2, out teams);
			combat.m_luaExportHelper.m_teams = teams;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601752A RID: 95530 RVA: 0x00656908 File Offset: 0x00654B08
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_Battle(IntPtr l)
	{
		int result;
		try
		{
			Combat combat = (Combat)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, combat.Battle);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601752B RID: 95531 RVA: 0x0065695C File Offset: 0x00654B5C
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_RandomNumber(IntPtr l)
	{
		int result;
		try
		{
			Combat combat = (Combat)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, combat.RandomNumber);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601752C RID: 95532 RVA: 0x006569B0 File Offset: 0x00654BB0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_Listener(IntPtr l)
	{
		int result;
		try
		{
			Combat combat = (Combat)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, combat.Listener);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601752D RID: 95533 RVA: 0x00656A04 File Offset: 0x00654C04
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_ConfigDataLoader(IntPtr l)
	{
		int result;
		try
		{
			Combat combat = (Combat)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, combat.ConfigDataLoader);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601752E RID: 95534 RVA: 0x00656A58 File Offset: 0x00654C58
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_State(IntPtr l)
	{
		int result;
		try
		{
			Combat combat = (Combat)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushEnum(l, (int)combat.State);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601752F RID: 95535 RVA: 0x00656AAC File Offset: 0x00654CAC
	[Preserve]
	public static void reg(IntPtr l)
	{
		LuaObject.getTypeTable(l, "BlackJack.ProjectL.Battle.Combat");
		if (Lua_BlackJack_ProjectL_Battle_Combat.<>f__mg$cache0 == null)
		{
			Lua_BlackJack_ProjectL_Battle_Combat.<>f__mg$cache0 = new LuaCSFunction(Lua_BlackJack_ProjectL_Battle_Combat.Dispose);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Battle_Combat.<>f__mg$cache0);
		if (Lua_BlackJack_ProjectL_Battle_Combat.<>f__mg$cache1 == null)
		{
			Lua_BlackJack_ProjectL_Battle_Combat.<>f__mg$cache1 = new LuaCSFunction(Lua_BlackJack_ProjectL_Battle_Combat.Tick);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Battle_Combat.<>f__mg$cache1);
		if (Lua_BlackJack_ProjectL_Battle_Combat.<>f__mg$cache2 == null)
		{
			Lua_BlackJack_ProjectL_Battle_Combat.<>f__mg$cache2 = new LuaCSFunction(Lua_BlackJack_ProjectL_Battle_Combat.TickGraphic);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Battle_Combat.<>f__mg$cache2);
		if (Lua_BlackJack_ProjectL_Battle_Combat.<>f__mg$cache3 == null)
		{
			Lua_BlackJack_ProjectL_Battle_Combat.<>f__mg$cache3 = new LuaCSFunction(Lua_BlackJack_ProjectL_Battle_Combat.Draw);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Battle_Combat.<>f__mg$cache3);
		if (Lua_BlackJack_ProjectL_Battle_Combat.<>f__mg$cache4 == null)
		{
			Lua_BlackJack_ProjectL_Battle_Combat.<>f__mg$cache4 = new LuaCSFunction(Lua_BlackJack_ProjectL_Battle_Combat.Start);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Battle_Combat.<>f__mg$cache4);
		if (Lua_BlackJack_ProjectL_Battle_Combat.<>f__mg$cache5 == null)
		{
			Lua_BlackJack_ProjectL_Battle_Combat.<>f__mg$cache5 = new LuaCSFunction(Lua_BlackJack_ProjectL_Battle_Combat.Stop);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Battle_Combat.<>f__mg$cache5);
		if (Lua_BlackJack_ProjectL_Battle_Combat.<>f__mg$cache6 == null)
		{
			Lua_BlackJack_ProjectL_Battle_Combat.<>f__mg$cache6 = new LuaCSFunction(Lua_BlackJack_ProjectL_Battle_Combat.Clear);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Battle_Combat.<>f__mg$cache6);
		if (Lua_BlackJack_ProjectL_Battle_Combat.<>f__mg$cache7 == null)
		{
			Lua_BlackJack_ProjectL_Battle_Combat.<>f__mg$cache7 = new LuaCSFunction(Lua_BlackJack_ProjectL_Battle_Combat.GetTeam);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Battle_Combat.<>f__mg$cache7);
		if (Lua_BlackJack_ProjectL_Battle_Combat.<>f__mg$cache8 == null)
		{
			Lua_BlackJack_ProjectL_Battle_Combat.<>f__mg$cache8 = new LuaCSFunction(Lua_BlackJack_ProjectL_Battle_Combat.GetNextEntityId);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Battle_Combat.<>f__mg$cache8);
		if (Lua_BlackJack_ProjectL_Battle_Combat.<>f__mg$cache9 == null)
		{
			Lua_BlackJack_ProjectL_Battle_Combat.<>f__mg$cache9 = new LuaCSFunction(Lua_BlackJack_ProjectL_Battle_Combat.GetNextHitId);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Battle_Combat.<>f__mg$cache9);
		if (Lua_BlackJack_ProjectL_Battle_Combat.<>f__mg$cacheA == null)
		{
			Lua_BlackJack_ProjectL_Battle_Combat.<>f__mg$cacheA = new LuaCSFunction(Lua_BlackJack_ProjectL_Battle_Combat.GetCombatGridDistance);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Battle_Combat.<>f__mg$cacheA);
		if (Lua_BlackJack_ProjectL_Battle_Combat.<>f__mg$cacheB == null)
		{
			Lua_BlackJack_ProjectL_Battle_Combat.<>f__mg$cacheB = new LuaCSFunction(Lua_BlackJack_ProjectL_Battle_Combat.OnActorCastSkill);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Battle_Combat.<>f__mg$cacheB);
		if (Lua_BlackJack_ProjectL_Battle_Combat.<>f__mg$cacheC == null)
		{
			Lua_BlackJack_ProjectL_Battle_Combat.<>f__mg$cacheC = new LuaCSFunction(Lua_BlackJack_ProjectL_Battle_Combat.OnActorCastPassiveSkill);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Battle_Combat.<>f__mg$cacheC);
		if (Lua_BlackJack_ProjectL_Battle_Combat.<>f__mg$cacheD == null)
		{
			Lua_BlackJack_ProjectL_Battle_Combat.<>f__mg$cacheD = new LuaCSFunction(Lua_BlackJack_ProjectL_Battle_Combat.OnActorDie);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Battle_Combat.<>f__mg$cacheD);
		if (Lua_BlackJack_ProjectL_Battle_Combat.<>f__mg$cacheE == null)
		{
			Lua_BlackJack_ProjectL_Battle_Combat.<>f__mg$cacheE = new LuaCSFunction(Lua_BlackJack_ProjectL_Battle_Combat.IsPlay);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Battle_Combat.<>f__mg$cacheE);
		if (Lua_BlackJack_ProjectL_Battle_Combat.<>f__mg$cacheF == null)
		{
			Lua_BlackJack_ProjectL_Battle_Combat.<>f__mg$cacheF = new LuaCSFunction(Lua_BlackJack_ProjectL_Battle_Combat.IsPaused);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Battle_Combat.<>f__mg$cacheF);
		if (Lua_BlackJack_ProjectL_Battle_Combat.<>f__mg$cache10 == null)
		{
			Lua_BlackJack_ProjectL_Battle_Combat.<>f__mg$cache10 = new LuaCSFunction(Lua_BlackJack_ProjectL_Battle_Combat.IsProbabilitySatisfied);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Battle_Combat.<>f__mg$cache10);
		if (Lua_BlackJack_ProjectL_Battle_Combat.<>f__mg$cache11 == null)
		{
			Lua_BlackJack_ProjectL_Battle_Combat.<>f__mg$cache11 = new LuaCSFunction(Lua_BlackJack_ProjectL_Battle_Combat.GetFrameCount);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Battle_Combat.<>f__mg$cache11);
		if (Lua_BlackJack_ProjectL_Battle_Combat.<>f__mg$cache12 == null)
		{
			Lua_BlackJack_ProjectL_Battle_Combat.<>f__mg$cache12 = new LuaCSFunction(Lua_BlackJack_ProjectL_Battle_Combat.FrameToMillisecond_s);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Battle_Combat.<>f__mg$cache12);
		if (Lua_BlackJack_ProjectL_Battle_Combat.<>f__mg$cache13 == null)
		{
			Lua_BlackJack_ProjectL_Battle_Combat.<>f__mg$cache13 = new LuaCSFunction(Lua_BlackJack_ProjectL_Battle_Combat.MillisecondToFrame_s);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Battle_Combat.<>f__mg$cache13);
		if (Lua_BlackJack_ProjectL_Battle_Combat.<>f__mg$cache14 == null)
		{
			Lua_BlackJack_ProjectL_Battle_Combat.<>f__mg$cache14 = new LuaCSFunction(Lua_BlackJack_ProjectL_Battle_Combat.MillisecondToFrame1_s);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Battle_Combat.<>f__mg$cache14);
		if (Lua_BlackJack_ProjectL_Battle_Combat.<>f__mg$cache15 == null)
		{
			Lua_BlackJack_ProjectL_Battle_Combat.<>f__mg$cache15 = new LuaCSFunction(Lua_BlackJack_ProjectL_Battle_Combat.Pause);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Battle_Combat.<>f__mg$cache15);
		if (Lua_BlackJack_ProjectL_Battle_Combat.<>f__mg$cache16 == null)
		{
			Lua_BlackJack_ProjectL_Battle_Combat.<>f__mg$cache16 = new LuaCSFunction(Lua_BlackJack_ProjectL_Battle_Combat.SetupTeam);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Battle_Combat.<>f__mg$cache16);
		string name = "m_battle";
		if (Lua_BlackJack_ProjectL_Battle_Combat.<>f__mg$cache17 == null)
		{
			Lua_BlackJack_ProjectL_Battle_Combat.<>f__mg$cache17 = new LuaCSFunction(Lua_BlackJack_ProjectL_Battle_Combat.get_m_battle);
		}
		LuaCSFunction get = Lua_BlackJack_ProjectL_Battle_Combat.<>f__mg$cache17;
		if (Lua_BlackJack_ProjectL_Battle_Combat.<>f__mg$cache18 == null)
		{
			Lua_BlackJack_ProjectL_Battle_Combat.<>f__mg$cache18 = new LuaCSFunction(Lua_BlackJack_ProjectL_Battle_Combat.set_m_battle);
		}
		LuaObject.addMember(l, name, get, Lua_BlackJack_ProjectL_Battle_Combat.<>f__mg$cache18, true);
		string name2 = "m_randomNumber";
		if (Lua_BlackJack_ProjectL_Battle_Combat.<>f__mg$cache19 == null)
		{
			Lua_BlackJack_ProjectL_Battle_Combat.<>f__mg$cache19 = new LuaCSFunction(Lua_BlackJack_ProjectL_Battle_Combat.get_m_randomNumber);
		}
		LuaCSFunction get2 = Lua_BlackJack_ProjectL_Battle_Combat.<>f__mg$cache19;
		if (Lua_BlackJack_ProjectL_Battle_Combat.<>f__mg$cache1A == null)
		{
			Lua_BlackJack_ProjectL_Battle_Combat.<>f__mg$cache1A = new LuaCSFunction(Lua_BlackJack_ProjectL_Battle_Combat.set_m_randomNumber);
		}
		LuaObject.addMember(l, name2, get2, Lua_BlackJack_ProjectL_Battle_Combat.<>f__mg$cache1A, true);
		string name3 = "m_state";
		if (Lua_BlackJack_ProjectL_Battle_Combat.<>f__mg$cache1B == null)
		{
			Lua_BlackJack_ProjectL_Battle_Combat.<>f__mg$cache1B = new LuaCSFunction(Lua_BlackJack_ProjectL_Battle_Combat.get_m_state);
		}
		LuaCSFunction get3 = Lua_BlackJack_ProjectL_Battle_Combat.<>f__mg$cache1B;
		if (Lua_BlackJack_ProjectL_Battle_Combat.<>f__mg$cache1C == null)
		{
			Lua_BlackJack_ProjectL_Battle_Combat.<>f__mg$cache1C = new LuaCSFunction(Lua_BlackJack_ProjectL_Battle_Combat.set_m_state);
		}
		LuaObject.addMember(l, name3, get3, Lua_BlackJack_ProjectL_Battle_Combat.<>f__mg$cache1C, true);
		string name4 = "m_isPaused";
		if (Lua_BlackJack_ProjectL_Battle_Combat.<>f__mg$cache1D == null)
		{
			Lua_BlackJack_ProjectL_Battle_Combat.<>f__mg$cache1D = new LuaCSFunction(Lua_BlackJack_ProjectL_Battle_Combat.get_m_isPaused);
		}
		LuaCSFunction get4 = Lua_BlackJack_ProjectL_Battle_Combat.<>f__mg$cache1D;
		if (Lua_BlackJack_ProjectL_Battle_Combat.<>f__mg$cache1E == null)
		{
			Lua_BlackJack_ProjectL_Battle_Combat.<>f__mg$cache1E = new LuaCSFunction(Lua_BlackJack_ProjectL_Battle_Combat.set_m_isPaused);
		}
		LuaObject.addMember(l, name4, get4, Lua_BlackJack_ProjectL_Battle_Combat.<>f__mg$cache1E, true);
		string name5 = "m_entityIdCounter";
		if (Lua_BlackJack_ProjectL_Battle_Combat.<>f__mg$cache1F == null)
		{
			Lua_BlackJack_ProjectL_Battle_Combat.<>f__mg$cache1F = new LuaCSFunction(Lua_BlackJack_ProjectL_Battle_Combat.get_m_entityIdCounter);
		}
		LuaCSFunction get5 = Lua_BlackJack_ProjectL_Battle_Combat.<>f__mg$cache1F;
		if (Lua_BlackJack_ProjectL_Battle_Combat.<>f__mg$cache20 == null)
		{
			Lua_BlackJack_ProjectL_Battle_Combat.<>f__mg$cache20 = new LuaCSFunction(Lua_BlackJack_ProjectL_Battle_Combat.set_m_entityIdCounter);
		}
		LuaObject.addMember(l, name5, get5, Lua_BlackJack_ProjectL_Battle_Combat.<>f__mg$cache20, true);
		string name6 = "m_hitIdCounter";
		if (Lua_BlackJack_ProjectL_Battle_Combat.<>f__mg$cache21 == null)
		{
			Lua_BlackJack_ProjectL_Battle_Combat.<>f__mg$cache21 = new LuaCSFunction(Lua_BlackJack_ProjectL_Battle_Combat.get_m_hitIdCounter);
		}
		LuaCSFunction get6 = Lua_BlackJack_ProjectL_Battle_Combat.<>f__mg$cache21;
		if (Lua_BlackJack_ProjectL_Battle_Combat.<>f__mg$cache22 == null)
		{
			Lua_BlackJack_ProjectL_Battle_Combat.<>f__mg$cache22 = new LuaCSFunction(Lua_BlackJack_ProjectL_Battle_Combat.set_m_hitIdCounter);
		}
		LuaObject.addMember(l, name6, get6, Lua_BlackJack_ProjectL_Battle_Combat.<>f__mg$cache22, true);
		string name7 = "m_combatGridDistance";
		if (Lua_BlackJack_ProjectL_Battle_Combat.<>f__mg$cache23 == null)
		{
			Lua_BlackJack_ProjectL_Battle_Combat.<>f__mg$cache23 = new LuaCSFunction(Lua_BlackJack_ProjectL_Battle_Combat.get_m_combatGridDistance);
		}
		LuaCSFunction get7 = Lua_BlackJack_ProjectL_Battle_Combat.<>f__mg$cache23;
		if (Lua_BlackJack_ProjectL_Battle_Combat.<>f__mg$cache24 == null)
		{
			Lua_BlackJack_ProjectL_Battle_Combat.<>f__mg$cache24 = new LuaCSFunction(Lua_BlackJack_ProjectL_Battle_Combat.set_m_combatGridDistance);
		}
		LuaObject.addMember(l, name7, get7, Lua_BlackJack_ProjectL_Battle_Combat.<>f__mg$cache24, true);
		string name8 = "m_frameCount";
		if (Lua_BlackJack_ProjectL_Battle_Combat.<>f__mg$cache25 == null)
		{
			Lua_BlackJack_ProjectL_Battle_Combat.<>f__mg$cache25 = new LuaCSFunction(Lua_BlackJack_ProjectL_Battle_Combat.get_m_frameCount);
		}
		LuaCSFunction get8 = Lua_BlackJack_ProjectL_Battle_Combat.<>f__mg$cache25;
		if (Lua_BlackJack_ProjectL_Battle_Combat.<>f__mg$cache26 == null)
		{
			Lua_BlackJack_ProjectL_Battle_Combat.<>f__mg$cache26 = new LuaCSFunction(Lua_BlackJack_ProjectL_Battle_Combat.set_m_frameCount);
		}
		LuaObject.addMember(l, name8, get8, Lua_BlackJack_ProjectL_Battle_Combat.<>f__mg$cache26, true);
		string name9 = "m_startCountdown";
		if (Lua_BlackJack_ProjectL_Battle_Combat.<>f__mg$cache27 == null)
		{
			Lua_BlackJack_ProjectL_Battle_Combat.<>f__mg$cache27 = new LuaCSFunction(Lua_BlackJack_ProjectL_Battle_Combat.get_m_startCountdown);
		}
		LuaCSFunction get9 = Lua_BlackJack_ProjectL_Battle_Combat.<>f__mg$cache27;
		if (Lua_BlackJack_ProjectL_Battle_Combat.<>f__mg$cache28 == null)
		{
			Lua_BlackJack_ProjectL_Battle_Combat.<>f__mg$cache28 = new LuaCSFunction(Lua_BlackJack_ProjectL_Battle_Combat.set_m_startCountdown);
		}
		LuaObject.addMember(l, name9, get9, Lua_BlackJack_ProjectL_Battle_Combat.<>f__mg$cache28, true);
		string name10 = "m_endCountdown";
		if (Lua_BlackJack_ProjectL_Battle_Combat.<>f__mg$cache29 == null)
		{
			Lua_BlackJack_ProjectL_Battle_Combat.<>f__mg$cache29 = new LuaCSFunction(Lua_BlackJack_ProjectL_Battle_Combat.get_m_endCountdown);
		}
		LuaCSFunction get10 = Lua_BlackJack_ProjectL_Battle_Combat.<>f__mg$cache29;
		if (Lua_BlackJack_ProjectL_Battle_Combat.<>f__mg$cache2A == null)
		{
			Lua_BlackJack_ProjectL_Battle_Combat.<>f__mg$cache2A = new LuaCSFunction(Lua_BlackJack_ProjectL_Battle_Combat.set_m_endCountdown);
		}
		LuaObject.addMember(l, name10, get10, Lua_BlackJack_ProjectL_Battle_Combat.<>f__mg$cache2A, true);
		string name11 = "m_cutscenePauseCountdown";
		if (Lua_BlackJack_ProjectL_Battle_Combat.<>f__mg$cache2B == null)
		{
			Lua_BlackJack_ProjectL_Battle_Combat.<>f__mg$cache2B = new LuaCSFunction(Lua_BlackJack_ProjectL_Battle_Combat.get_m_cutscenePauseCountdown);
		}
		LuaCSFunction get11 = Lua_BlackJack_ProjectL_Battle_Combat.<>f__mg$cache2B;
		if (Lua_BlackJack_ProjectL_Battle_Combat.<>f__mg$cache2C == null)
		{
			Lua_BlackJack_ProjectL_Battle_Combat.<>f__mg$cache2C = new LuaCSFunction(Lua_BlackJack_ProjectL_Battle_Combat.set_m_cutscenePauseCountdown);
		}
		LuaObject.addMember(l, name11, get11, Lua_BlackJack_ProjectL_Battle_Combat.<>f__mg$cache2C, true);
		string name12 = "m_teams";
		if (Lua_BlackJack_ProjectL_Battle_Combat.<>f__mg$cache2D == null)
		{
			Lua_BlackJack_ProjectL_Battle_Combat.<>f__mg$cache2D = new LuaCSFunction(Lua_BlackJack_ProjectL_Battle_Combat.get_m_teams);
		}
		LuaCSFunction get12 = Lua_BlackJack_ProjectL_Battle_Combat.<>f__mg$cache2D;
		if (Lua_BlackJack_ProjectL_Battle_Combat.<>f__mg$cache2E == null)
		{
			Lua_BlackJack_ProjectL_Battle_Combat.<>f__mg$cache2E = new LuaCSFunction(Lua_BlackJack_ProjectL_Battle_Combat.set_m_teams);
		}
		LuaObject.addMember(l, name12, get12, Lua_BlackJack_ProjectL_Battle_Combat.<>f__mg$cache2E, true);
		string name13 = "Battle";
		if (Lua_BlackJack_ProjectL_Battle_Combat.<>f__mg$cache2F == null)
		{
			Lua_BlackJack_ProjectL_Battle_Combat.<>f__mg$cache2F = new LuaCSFunction(Lua_BlackJack_ProjectL_Battle_Combat.get_Battle);
		}
		LuaObject.addMember(l, name13, Lua_BlackJack_ProjectL_Battle_Combat.<>f__mg$cache2F, null, true);
		string name14 = "RandomNumber";
		if (Lua_BlackJack_ProjectL_Battle_Combat.<>f__mg$cache30 == null)
		{
			Lua_BlackJack_ProjectL_Battle_Combat.<>f__mg$cache30 = new LuaCSFunction(Lua_BlackJack_ProjectL_Battle_Combat.get_RandomNumber);
		}
		LuaObject.addMember(l, name14, Lua_BlackJack_ProjectL_Battle_Combat.<>f__mg$cache30, null, true);
		string name15 = "Listener";
		if (Lua_BlackJack_ProjectL_Battle_Combat.<>f__mg$cache31 == null)
		{
			Lua_BlackJack_ProjectL_Battle_Combat.<>f__mg$cache31 = new LuaCSFunction(Lua_BlackJack_ProjectL_Battle_Combat.get_Listener);
		}
		LuaObject.addMember(l, name15, Lua_BlackJack_ProjectL_Battle_Combat.<>f__mg$cache31, null, true);
		string name16 = "ConfigDataLoader";
		if (Lua_BlackJack_ProjectL_Battle_Combat.<>f__mg$cache32 == null)
		{
			Lua_BlackJack_ProjectL_Battle_Combat.<>f__mg$cache32 = new LuaCSFunction(Lua_BlackJack_ProjectL_Battle_Combat.get_ConfigDataLoader);
		}
		LuaObject.addMember(l, name16, Lua_BlackJack_ProjectL_Battle_Combat.<>f__mg$cache32, null, true);
		string name17 = "State";
		if (Lua_BlackJack_ProjectL_Battle_Combat.<>f__mg$cache33 == null)
		{
			Lua_BlackJack_ProjectL_Battle_Combat.<>f__mg$cache33 = new LuaCSFunction(Lua_BlackJack_ProjectL_Battle_Combat.get_State);
		}
		LuaObject.addMember(l, name17, Lua_BlackJack_ProjectL_Battle_Combat.<>f__mg$cache33, null, true);
		if (Lua_BlackJack_ProjectL_Battle_Combat.<>f__mg$cache34 == null)
		{
			Lua_BlackJack_ProjectL_Battle_Combat.<>f__mg$cache34 = new LuaCSFunction(Lua_BlackJack_ProjectL_Battle_Combat.constructor);
		}
		LuaObject.createTypeMetatable(l, Lua_BlackJack_ProjectL_Battle_Combat.<>f__mg$cache34, typeof(Combat));
	}

	// Token: 0x0400DB92 RID: 56210
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache0;

	// Token: 0x0400DB93 RID: 56211
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1;

	// Token: 0x0400DB94 RID: 56212
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2;

	// Token: 0x0400DB95 RID: 56213
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3;

	// Token: 0x0400DB96 RID: 56214
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache4;

	// Token: 0x0400DB97 RID: 56215
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache5;

	// Token: 0x0400DB98 RID: 56216
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache6;

	// Token: 0x0400DB99 RID: 56217
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache7;

	// Token: 0x0400DB9A RID: 56218
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache8;

	// Token: 0x0400DB9B RID: 56219
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache9;

	// Token: 0x0400DB9C RID: 56220
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheA;

	// Token: 0x0400DB9D RID: 56221
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheB;

	// Token: 0x0400DB9E RID: 56222
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheC;

	// Token: 0x0400DB9F RID: 56223
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheD;

	// Token: 0x0400DBA0 RID: 56224
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheE;

	// Token: 0x0400DBA1 RID: 56225
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheF;

	// Token: 0x0400DBA2 RID: 56226
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache10;

	// Token: 0x0400DBA3 RID: 56227
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache11;

	// Token: 0x0400DBA4 RID: 56228
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache12;

	// Token: 0x0400DBA5 RID: 56229
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache13;

	// Token: 0x0400DBA6 RID: 56230
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache14;

	// Token: 0x0400DBA7 RID: 56231
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache15;

	// Token: 0x0400DBA8 RID: 56232
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache16;

	// Token: 0x0400DBA9 RID: 56233
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache17;

	// Token: 0x0400DBAA RID: 56234
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache18;

	// Token: 0x0400DBAB RID: 56235
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache19;

	// Token: 0x0400DBAC RID: 56236
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1A;

	// Token: 0x0400DBAD RID: 56237
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1B;

	// Token: 0x0400DBAE RID: 56238
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1C;

	// Token: 0x0400DBAF RID: 56239
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1D;

	// Token: 0x0400DBB0 RID: 56240
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1E;

	// Token: 0x0400DBB1 RID: 56241
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1F;

	// Token: 0x0400DBB2 RID: 56242
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache20;

	// Token: 0x0400DBB3 RID: 56243
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache21;

	// Token: 0x0400DBB4 RID: 56244
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache22;

	// Token: 0x0400DBB5 RID: 56245
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache23;

	// Token: 0x0400DBB6 RID: 56246
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache24;

	// Token: 0x0400DBB7 RID: 56247
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache25;

	// Token: 0x0400DBB8 RID: 56248
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache26;

	// Token: 0x0400DBB9 RID: 56249
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache27;

	// Token: 0x0400DBBA RID: 56250
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache28;

	// Token: 0x0400DBBB RID: 56251
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache29;

	// Token: 0x0400DBBC RID: 56252
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2A;

	// Token: 0x0400DBBD RID: 56253
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2B;

	// Token: 0x0400DBBE RID: 56254
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2C;

	// Token: 0x0400DBBF RID: 56255
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2D;

	// Token: 0x0400DBC0 RID: 56256
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2E;

	// Token: 0x0400DBC1 RID: 56257
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2F;

	// Token: 0x0400DBC2 RID: 56258
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache30;

	// Token: 0x0400DBC3 RID: 56259
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache31;

	// Token: 0x0400DBC4 RID: 56260
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache32;

	// Token: 0x0400DBC5 RID: 56261
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache33;

	// Token: 0x0400DBC6 RID: 56262
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache34;
}
