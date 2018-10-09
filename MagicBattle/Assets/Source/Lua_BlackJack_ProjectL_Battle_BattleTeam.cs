using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using BlackJack.ProjectL.Battle;
using SLua;
using UnityEngine.Scripting;

// Token: 0x0200119E RID: 4510
[Preserve]
public class Lua_BlackJack_ProjectL_Battle_BattleTeam : LuaObject
{
	// Token: 0x06017478 RID: 95352 RVA: 0x00651E90 File Offset: 0x00650090
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int constructor(IntPtr l)
	{
		int result;
		try
		{
			BattleBase battle;
			LuaObject.checkType<BattleBase>(l, 2, out battle);
			int teamNumer;
			LuaObject.checkType(l, 3, out teamNumer);
			BattleTeam o = new BattleTeam(battle, teamNumer);
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

	// Token: 0x06017479 RID: 95353 RVA: 0x00651EF0 File Offset: 0x006500F0
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int RemoveDeleted(IntPtr l)
	{
		int result;
		try
		{
			BattleTeam battleTeam = (BattleTeam)LuaObject.checkSelf(l);
			battleTeam.RemoveDeleted();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601747A RID: 95354 RVA: 0x00651F3C File Offset: 0x0065013C
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int CreateActor(IntPtr l)
	{
		int result;
		try
		{
			BattleTeam battleTeam = (BattleTeam)LuaObject.checkSelf(l);
			BattleActor o = battleTeam.CreateActor();
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

	// Token: 0x0601747B RID: 95355 RVA: 0x00651F90 File Offset: 0x00650190
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int RemoveAll(IntPtr l)
	{
		int result;
		try
		{
			BattleTeam battleTeam = (BattleTeam)LuaObject.checkSelf(l);
			battleTeam.RemoveAll();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601747C RID: 95356 RVA: 0x00651FDC File Offset: 0x006501DC
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int GetActors(IntPtr l)
	{
		int result;
		try
		{
			BattleTeam battleTeam = (BattleTeam)LuaObject.checkSelf(l);
			List<BattleActor> actors = battleTeam.GetActors();
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

	// Token: 0x0601747D RID: 95357 RVA: 0x00652030 File Offset: 0x00650230
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int GetActorById(IntPtr l)
	{
		int result;
		try
		{
			BattleTeam battleTeam = (BattleTeam)LuaObject.checkSelf(l);
			int id;
			LuaObject.checkType(l, 2, out id);
			BattleActor actorById = battleTeam.GetActorById(id);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, actorById);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601747E RID: 95358 RVA: 0x00652094 File Offset: 0x00650294
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int GetActorByHeroId(IntPtr l)
	{
		int result;
		try
		{
			BattleTeam battleTeam = (BattleTeam)LuaObject.checkSelf(l);
			int heroId;
			LuaObject.checkType(l, 2, out heroId);
			bool ignoreDead;
			LuaObject.checkType(l, 3, out ignoreDead);
			BattleActor actorByHeroId = battleTeam.GetActorByHeroId(heroId, ignoreDead);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, actorByHeroId);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601747F RID: 95359 RVA: 0x00652104 File Offset: 0x00650304
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int StartBattle(IntPtr l)
	{
		int result;
		try
		{
			BattleTeam battleTeam = (BattleTeam)LuaObject.checkSelf(l);
			battleTeam.StartBattle();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06017480 RID: 95360 RVA: 0x00652150 File Offset: 0x00650350
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int StopBattle(IntPtr l)
	{
		int result;
		try
		{
			BattleTeam battleTeam = (BattleTeam)LuaObject.checkSelf(l);
			bool win;
			LuaObject.checkType(l, 2, out win);
			battleTeam.StopBattle(win);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06017481 RID: 95361 RVA: 0x006521A8 File Offset: 0x006503A8
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int HasAliveActor(IntPtr l)
	{
		int result;
		try
		{
			BattleTeam battleTeam = (BattleTeam)LuaObject.checkSelf(l);
			bool b = battleTeam.HasAliveActor();
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

	// Token: 0x06017482 RID: 95362 RVA: 0x006521FC File Offset: 0x006503FC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int HasNotActionFinishedActor(IntPtr l)
	{
		int result;
		try
		{
			BattleTeam battleTeam = (BattleTeam)LuaObject.checkSelf(l);
			bool b = battleTeam.HasNotActionFinishedActor();
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

	// Token: 0x06017483 RID: 95363 RVA: 0x00652250 File Offset: 0x00650450
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int HasFinishActionNpcActor(IntPtr l)
	{
		int result;
		try
		{
			BattleTeam battleTeam = (BattleTeam)LuaObject.checkSelf(l);
			bool b = battleTeam.HasFinishActionNpcActor();
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

	// Token: 0x06017484 RID: 95364 RVA: 0x006522A4 File Offset: 0x006504A4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int GetOtherTeam(IntPtr l)
	{
		int result;
		try
		{
			BattleTeam battleTeam = (BattleTeam)LuaObject.checkSelf(l);
			BattleTeam otherTeam = battleTeam.GetOtherTeam();
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, otherTeam);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06017485 RID: 95365 RVA: 0x006522F8 File Offset: 0x006504F8
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int OnMyActorDie(IntPtr l)
	{
		int result;
		try
		{
			BattleTeam battleTeam = (BattleTeam)LuaObject.checkSelf(l);
			BattleActor actor;
			LuaObject.checkType<BattleActor>(l, 2, out actor);
			battleTeam.OnMyActorDie(actor);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06017486 RID: 95366 RVA: 0x00652350 File Offset: 0x00650550
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int OnMyActorRetreat(IntPtr l)
	{
		int result;
		try
		{
			BattleTeam battleTeam = (BattleTeam)LuaObject.checkSelf(l);
			BattleActor actor;
			LuaObject.checkType<BattleActor>(l, 2, out actor);
			int effectType;
			LuaObject.checkType(l, 3, out effectType);
			string fxName;
			LuaObject.checkType(l, 4, out fxName);
			bool notifyListener;
			LuaObject.checkType(l, 5, out notifyListener);
			battleTeam.OnMyActorRetreat(actor, effectType, fxName, notifyListener);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06017487 RID: 95367 RVA: 0x006523D0 File Offset: 0x006505D0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int ComputeDeadActorCount(IntPtr l)
	{
		int result;
		try
		{
			BattleTeam battleTeam = (BattleTeam)LuaObject.checkSelf(l);
			List<int> heroIds;
			LuaObject.checkType<List<int>>(l, 2, out heroIds);
			NpcCondition npcCondition;
			LuaObject.checkEnum<NpcCondition>(l, 3, out npcCondition);
			int i = battleTeam.ComputeDeadActorCount(heroIds, npcCondition);
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

	// Token: 0x06017488 RID: 95368 RVA: 0x00652440 File Offset: 0x00650640
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int ComputeAliveActorCount(IntPtr l)
	{
		int result;
		try
		{
			BattleTeam battleTeam = (BattleTeam)LuaObject.checkSelf(l);
			List<int> heroIds;
			LuaObject.checkType<List<int>>(l, 2, out heroIds);
			NpcCondition npcCondition;
			LuaObject.checkEnum<NpcCondition>(l, 3, out npcCondition);
			int i = battleTeam.ComputeAliveActorCount(heroIds, npcCondition);
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

	// Token: 0x06017489 RID: 95369 RVA: 0x006524B0 File Offset: 0x006506B0
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int IsGroupDie(IntPtr l)
	{
		int result;
		try
		{
			BattleTeam battleTeam = (BattleTeam)LuaObject.checkSelf(l);
			int groupId;
			LuaObject.checkType(l, 2, out groupId);
			bool b = battleTeam.IsGroupDie(groupId);
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

	// Token: 0x0601748A RID: 95370 RVA: 0x00652514 File Offset: 0x00650714
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int NextTurn(IntPtr l)
	{
		int result;
		try
		{
			BattleTeam battleTeam = (BattleTeam)LuaObject.checkSelf(l);
			battleTeam.NextTurn();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601748B RID: 95371 RVA: 0x00652560 File Offset: 0x00650760
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int SetGroupBehaviorDict(IntPtr l)
	{
		int result;
		try
		{
			BattleTeam battleTeam = (BattleTeam)LuaObject.checkSelf(l);
			Dictionary<int, int> groupBehaviorDict;
			LuaObject.checkType<Dictionary<int, int>>(l, 2, out groupBehaviorDict);
			battleTeam.SetGroupBehaviorDict(groupBehaviorDict);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601748C RID: 95372 RVA: 0x006525B8 File Offset: 0x006507B8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int AddGroupBehaviors(IntPtr l)
	{
		int result;
		try
		{
			BattleTeam battleTeam = (BattleTeam)LuaObject.checkSelf(l);
			Dictionary<int, int> behaviors;
			LuaObject.checkType<Dictionary<int, int>>(l, 2, out behaviors);
			battleTeam.AddGroupBehaviors(behaviors);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601748D RID: 95373 RVA: 0x00652610 File Offset: 0x00650810
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int CreateGroups(IntPtr l)
	{
		int result;
		try
		{
			BattleTeam battleTeam = (BattleTeam)LuaObject.checkSelf(l);
			battleTeam.CreateGroups();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601748E RID: 95374 RVA: 0x0065265C File Offset: 0x0065085C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int DoGroupBehavior(IntPtr l)
	{
		int result;
		try
		{
			BattleTeam battleTeam = (BattleTeam)LuaObject.checkSelf(l);
			battleTeam.DoGroupBehavior();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601748F RID: 95375 RVA: 0x006526A8 File Offset: 0x006508A8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int UpdateGroups(IntPtr l)
	{
		int result;
		try
		{
			BattleTeam battleTeam = (BattleTeam)LuaObject.checkSelf(l);
			battleTeam.UpdateGroups();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06017490 RID: 95376 RVA: 0x006526F4 File Offset: 0x006508F4
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int GetGroup(IntPtr l)
	{
		int result;
		try
		{
			BattleTeam battleTeam = (BattleTeam)LuaObject.checkSelf(l);
			int groupID;
			LuaObject.checkType(l, 2, out groupID);
			BehaviorGroup group = battleTeam.m_luaExportHelper.GetGroup(groupID);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, group);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06017491 RID: 95377 RVA: 0x0065275C File Offset: 0x0065095C
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int CreateGroup(IntPtr l)
	{
		int result;
		try
		{
			BattleTeam battleTeam = (BattleTeam)LuaObject.checkSelf(l);
			int id;
			LuaObject.checkType(l, 2, out id);
			BehaviorGroup o = battleTeam.m_luaExportHelper.CreateGroup(id);
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

	// Token: 0x06017492 RID: 95378 RVA: 0x006527C4 File Offset: 0x006509C4
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_m_initNotNpcActorCount(IntPtr l)
	{
		int result;
		try
		{
			BattleTeam battleTeam = (BattleTeam)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, battleTeam.m_luaExportHelper.m_initNotNpcActorCount);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06017493 RID: 95379 RVA: 0x0065281C File Offset: 0x00650A1C
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_m_initNotNpcActorCount(IntPtr l)
	{
		int result;
		try
		{
			BattleTeam battleTeam = (BattleTeam)LuaObject.checkSelf(l);
			int initNotNpcActorCount;
			LuaObject.checkType(l, 2, out initNotNpcActorCount);
			battleTeam.m_luaExportHelper.m_initNotNpcActorCount = initNotNpcActorCount;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06017494 RID: 95380 RVA: 0x00652878 File Offset: 0x00650A78
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_deadActorCount(IntPtr l)
	{
		int result;
		try
		{
			BattleTeam battleTeam = (BattleTeam)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, battleTeam.m_luaExportHelper.m_deadActorCount);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06017495 RID: 95381 RVA: 0x006528D0 File Offset: 0x00650AD0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_deadActorCount(IntPtr l)
	{
		int result;
		try
		{
			BattleTeam battleTeam = (BattleTeam)LuaObject.checkSelf(l);
			int deadActorCount;
			LuaObject.checkType(l, 2, out deadActorCount);
			battleTeam.m_luaExportHelper.m_deadActorCount = deadActorCount;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06017496 RID: 95382 RVA: 0x0065292C File Offset: 0x00650B2C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_actors(IntPtr l)
	{
		int result;
		try
		{
			BattleTeam battleTeam = (BattleTeam)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, battleTeam.m_luaExportHelper.m_actors);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06017497 RID: 95383 RVA: 0x00652984 File Offset: 0x00650B84
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_actors(IntPtr l)
	{
		int result;
		try
		{
			BattleTeam battleTeam = (BattleTeam)LuaObject.checkSelf(l);
			List<BattleActor> actors;
			LuaObject.checkType<List<BattleActor>>(l, 2, out actors);
			battleTeam.m_luaExportHelper.m_actors = actors;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06017498 RID: 95384 RVA: 0x006529E0 File Offset: 0x00650BE0
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_m_battle(IntPtr l)
	{
		int result;
		try
		{
			BattleTeam battleTeam = (BattleTeam)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, battleTeam.m_luaExportHelper.m_battle);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06017499 RID: 95385 RVA: 0x00652A38 File Offset: 0x00650C38
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_battle(IntPtr l)
	{
		int result;
		try
		{
			BattleTeam battleTeam = (BattleTeam)LuaObject.checkSelf(l);
			BattleBase battle;
			LuaObject.checkType<BattleBase>(l, 2, out battle);
			battleTeam.m_luaExportHelper.m_battle = battle;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601749A RID: 95386 RVA: 0x00652A94 File Offset: 0x00650C94
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_teamNumber(IntPtr l)
	{
		int result;
		try
		{
			BattleTeam battleTeam = (BattleTeam)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, battleTeam.m_luaExportHelper.m_teamNumber);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601749B RID: 95387 RVA: 0x00652AEC File Offset: 0x00650CEC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_teamNumber(IntPtr l)
	{
		int result;
		try
		{
			BattleTeam battleTeam = (BattleTeam)LuaObject.checkSelf(l);
			int teamNumber;
			LuaObject.checkType(l, 2, out teamNumber);
			battleTeam.m_luaExportHelper.m_teamNumber = teamNumber;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601749C RID: 95388 RVA: 0x00652B48 File Offset: 0x00650D48
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_groupBehaviorDict(IntPtr l)
	{
		int result;
		try
		{
			BattleTeam battleTeam = (BattleTeam)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, battleTeam.m_luaExportHelper.m_groupBehaviorDict);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601749D RID: 95389 RVA: 0x00652BA0 File Offset: 0x00650DA0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_groupBehaviorDict(IntPtr l)
	{
		int result;
		try
		{
			BattleTeam battleTeam = (BattleTeam)LuaObject.checkSelf(l);
			Dictionary<int, int> groupBehaviorDict;
			LuaObject.checkType<Dictionary<int, int>>(l, 2, out groupBehaviorDict);
			battleTeam.m_luaExportHelper.m_groupBehaviorDict = groupBehaviorDict;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601749E RID: 95390 RVA: 0x00652BFC File Offset: 0x00650DFC
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_m_groups(IntPtr l)
	{
		int result;
		try
		{
			BattleTeam battleTeam = (BattleTeam)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, battleTeam.m_luaExportHelper.m_groups);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601749F RID: 95391 RVA: 0x00652C54 File Offset: 0x00650E54
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_m_groups(IntPtr l)
	{
		int result;
		try
		{
			BattleTeam battleTeam = (BattleTeam)LuaObject.checkSelf(l);
			List<BehaviorGroup> groups;
			LuaObject.checkType<List<BehaviorGroup>>(l, 2, out groups);
			battleTeam.m_luaExportHelper.m_groups = groups;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060174A0 RID: 95392 RVA: 0x00652CB0 File Offset: 0x00650EB0
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_Battle(IntPtr l)
	{
		int result;
		try
		{
			BattleTeam battleTeam = (BattleTeam)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, battleTeam.Battle);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060174A1 RID: 95393 RVA: 0x00652D04 File Offset: 0x00650F04
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_TeamNumber(IntPtr l)
	{
		int result;
		try
		{
			BattleTeam battleTeam = (BattleTeam)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, battleTeam.TeamNumber);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060174A2 RID: 95394 RVA: 0x00652D58 File Offset: 0x00650F58
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_InitNotNpcActorCount(IntPtr l)
	{
		int result;
		try
		{
			BattleTeam battleTeam = (BattleTeam)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, battleTeam.InitNotNpcActorCount);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060174A3 RID: 95395 RVA: 0x00652DAC File Offset: 0x00650FAC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_DeadActorCount(IntPtr l)
	{
		int result;
		try
		{
			BattleTeam battleTeam = (BattleTeam)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, battleTeam.DeadActorCount);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060174A4 RID: 95396 RVA: 0x00652E00 File Offset: 0x00651000
	[Preserve]
	public static void reg(IntPtr l)
	{
		LuaObject.getTypeTable(l, "BlackJack.ProjectL.Battle.BattleTeam");
		if (Lua_BlackJack_ProjectL_Battle_BattleTeam.<>f__mg$cache0 == null)
		{
			Lua_BlackJack_ProjectL_Battle_BattleTeam.<>f__mg$cache0 = new LuaCSFunction(Lua_BlackJack_ProjectL_Battle_BattleTeam.RemoveDeleted);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Battle_BattleTeam.<>f__mg$cache0);
		if (Lua_BlackJack_ProjectL_Battle_BattleTeam.<>f__mg$cache1 == null)
		{
			Lua_BlackJack_ProjectL_Battle_BattleTeam.<>f__mg$cache1 = new LuaCSFunction(Lua_BlackJack_ProjectL_Battle_BattleTeam.CreateActor);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Battle_BattleTeam.<>f__mg$cache1);
		if (Lua_BlackJack_ProjectL_Battle_BattleTeam.<>f__mg$cache2 == null)
		{
			Lua_BlackJack_ProjectL_Battle_BattleTeam.<>f__mg$cache2 = new LuaCSFunction(Lua_BlackJack_ProjectL_Battle_BattleTeam.RemoveAll);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Battle_BattleTeam.<>f__mg$cache2);
		if (Lua_BlackJack_ProjectL_Battle_BattleTeam.<>f__mg$cache3 == null)
		{
			Lua_BlackJack_ProjectL_Battle_BattleTeam.<>f__mg$cache3 = new LuaCSFunction(Lua_BlackJack_ProjectL_Battle_BattleTeam.GetActors);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Battle_BattleTeam.<>f__mg$cache3);
		if (Lua_BlackJack_ProjectL_Battle_BattleTeam.<>f__mg$cache4 == null)
		{
			Lua_BlackJack_ProjectL_Battle_BattleTeam.<>f__mg$cache4 = new LuaCSFunction(Lua_BlackJack_ProjectL_Battle_BattleTeam.GetActorById);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Battle_BattleTeam.<>f__mg$cache4);
		if (Lua_BlackJack_ProjectL_Battle_BattleTeam.<>f__mg$cache5 == null)
		{
			Lua_BlackJack_ProjectL_Battle_BattleTeam.<>f__mg$cache5 = new LuaCSFunction(Lua_BlackJack_ProjectL_Battle_BattleTeam.GetActorByHeroId);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Battle_BattleTeam.<>f__mg$cache5);
		if (Lua_BlackJack_ProjectL_Battle_BattleTeam.<>f__mg$cache6 == null)
		{
			Lua_BlackJack_ProjectL_Battle_BattleTeam.<>f__mg$cache6 = new LuaCSFunction(Lua_BlackJack_ProjectL_Battle_BattleTeam.StartBattle);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Battle_BattleTeam.<>f__mg$cache6);
		if (Lua_BlackJack_ProjectL_Battle_BattleTeam.<>f__mg$cache7 == null)
		{
			Lua_BlackJack_ProjectL_Battle_BattleTeam.<>f__mg$cache7 = new LuaCSFunction(Lua_BlackJack_ProjectL_Battle_BattleTeam.StopBattle);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Battle_BattleTeam.<>f__mg$cache7);
		if (Lua_BlackJack_ProjectL_Battle_BattleTeam.<>f__mg$cache8 == null)
		{
			Lua_BlackJack_ProjectL_Battle_BattleTeam.<>f__mg$cache8 = new LuaCSFunction(Lua_BlackJack_ProjectL_Battle_BattleTeam.HasAliveActor);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Battle_BattleTeam.<>f__mg$cache8);
		if (Lua_BlackJack_ProjectL_Battle_BattleTeam.<>f__mg$cache9 == null)
		{
			Lua_BlackJack_ProjectL_Battle_BattleTeam.<>f__mg$cache9 = new LuaCSFunction(Lua_BlackJack_ProjectL_Battle_BattleTeam.HasNotActionFinishedActor);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Battle_BattleTeam.<>f__mg$cache9);
		if (Lua_BlackJack_ProjectL_Battle_BattleTeam.<>f__mg$cacheA == null)
		{
			Lua_BlackJack_ProjectL_Battle_BattleTeam.<>f__mg$cacheA = new LuaCSFunction(Lua_BlackJack_ProjectL_Battle_BattleTeam.HasFinishActionNpcActor);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Battle_BattleTeam.<>f__mg$cacheA);
		if (Lua_BlackJack_ProjectL_Battle_BattleTeam.<>f__mg$cacheB == null)
		{
			Lua_BlackJack_ProjectL_Battle_BattleTeam.<>f__mg$cacheB = new LuaCSFunction(Lua_BlackJack_ProjectL_Battle_BattleTeam.GetOtherTeam);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Battle_BattleTeam.<>f__mg$cacheB);
		if (Lua_BlackJack_ProjectL_Battle_BattleTeam.<>f__mg$cacheC == null)
		{
			Lua_BlackJack_ProjectL_Battle_BattleTeam.<>f__mg$cacheC = new LuaCSFunction(Lua_BlackJack_ProjectL_Battle_BattleTeam.OnMyActorDie);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Battle_BattleTeam.<>f__mg$cacheC);
		if (Lua_BlackJack_ProjectL_Battle_BattleTeam.<>f__mg$cacheD == null)
		{
			Lua_BlackJack_ProjectL_Battle_BattleTeam.<>f__mg$cacheD = new LuaCSFunction(Lua_BlackJack_ProjectL_Battle_BattleTeam.OnMyActorRetreat);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Battle_BattleTeam.<>f__mg$cacheD);
		if (Lua_BlackJack_ProjectL_Battle_BattleTeam.<>f__mg$cacheE == null)
		{
			Lua_BlackJack_ProjectL_Battle_BattleTeam.<>f__mg$cacheE = new LuaCSFunction(Lua_BlackJack_ProjectL_Battle_BattleTeam.ComputeDeadActorCount);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Battle_BattleTeam.<>f__mg$cacheE);
		if (Lua_BlackJack_ProjectL_Battle_BattleTeam.<>f__mg$cacheF == null)
		{
			Lua_BlackJack_ProjectL_Battle_BattleTeam.<>f__mg$cacheF = new LuaCSFunction(Lua_BlackJack_ProjectL_Battle_BattleTeam.ComputeAliveActorCount);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Battle_BattleTeam.<>f__mg$cacheF);
		if (Lua_BlackJack_ProjectL_Battle_BattleTeam.<>f__mg$cache10 == null)
		{
			Lua_BlackJack_ProjectL_Battle_BattleTeam.<>f__mg$cache10 = new LuaCSFunction(Lua_BlackJack_ProjectL_Battle_BattleTeam.IsGroupDie);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Battle_BattleTeam.<>f__mg$cache10);
		if (Lua_BlackJack_ProjectL_Battle_BattleTeam.<>f__mg$cache11 == null)
		{
			Lua_BlackJack_ProjectL_Battle_BattleTeam.<>f__mg$cache11 = new LuaCSFunction(Lua_BlackJack_ProjectL_Battle_BattleTeam.NextTurn);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Battle_BattleTeam.<>f__mg$cache11);
		if (Lua_BlackJack_ProjectL_Battle_BattleTeam.<>f__mg$cache12 == null)
		{
			Lua_BlackJack_ProjectL_Battle_BattleTeam.<>f__mg$cache12 = new LuaCSFunction(Lua_BlackJack_ProjectL_Battle_BattleTeam.SetGroupBehaviorDict);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Battle_BattleTeam.<>f__mg$cache12);
		if (Lua_BlackJack_ProjectL_Battle_BattleTeam.<>f__mg$cache13 == null)
		{
			Lua_BlackJack_ProjectL_Battle_BattleTeam.<>f__mg$cache13 = new LuaCSFunction(Lua_BlackJack_ProjectL_Battle_BattleTeam.AddGroupBehaviors);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Battle_BattleTeam.<>f__mg$cache13);
		if (Lua_BlackJack_ProjectL_Battle_BattleTeam.<>f__mg$cache14 == null)
		{
			Lua_BlackJack_ProjectL_Battle_BattleTeam.<>f__mg$cache14 = new LuaCSFunction(Lua_BlackJack_ProjectL_Battle_BattleTeam.CreateGroups);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Battle_BattleTeam.<>f__mg$cache14);
		if (Lua_BlackJack_ProjectL_Battle_BattleTeam.<>f__mg$cache15 == null)
		{
			Lua_BlackJack_ProjectL_Battle_BattleTeam.<>f__mg$cache15 = new LuaCSFunction(Lua_BlackJack_ProjectL_Battle_BattleTeam.DoGroupBehavior);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Battle_BattleTeam.<>f__mg$cache15);
		if (Lua_BlackJack_ProjectL_Battle_BattleTeam.<>f__mg$cache16 == null)
		{
			Lua_BlackJack_ProjectL_Battle_BattleTeam.<>f__mg$cache16 = new LuaCSFunction(Lua_BlackJack_ProjectL_Battle_BattleTeam.UpdateGroups);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Battle_BattleTeam.<>f__mg$cache16);
		if (Lua_BlackJack_ProjectL_Battle_BattleTeam.<>f__mg$cache17 == null)
		{
			Lua_BlackJack_ProjectL_Battle_BattleTeam.<>f__mg$cache17 = new LuaCSFunction(Lua_BlackJack_ProjectL_Battle_BattleTeam.GetGroup);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Battle_BattleTeam.<>f__mg$cache17);
		if (Lua_BlackJack_ProjectL_Battle_BattleTeam.<>f__mg$cache18 == null)
		{
			Lua_BlackJack_ProjectL_Battle_BattleTeam.<>f__mg$cache18 = new LuaCSFunction(Lua_BlackJack_ProjectL_Battle_BattleTeam.CreateGroup);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Battle_BattleTeam.<>f__mg$cache18);
		string name = "m_initNotNpcActorCount";
		if (Lua_BlackJack_ProjectL_Battle_BattleTeam.<>f__mg$cache19 == null)
		{
			Lua_BlackJack_ProjectL_Battle_BattleTeam.<>f__mg$cache19 = new LuaCSFunction(Lua_BlackJack_ProjectL_Battle_BattleTeam.get_m_initNotNpcActorCount);
		}
		LuaCSFunction get = Lua_BlackJack_ProjectL_Battle_BattleTeam.<>f__mg$cache19;
		if (Lua_BlackJack_ProjectL_Battle_BattleTeam.<>f__mg$cache1A == null)
		{
			Lua_BlackJack_ProjectL_Battle_BattleTeam.<>f__mg$cache1A = new LuaCSFunction(Lua_BlackJack_ProjectL_Battle_BattleTeam.set_m_initNotNpcActorCount);
		}
		LuaObject.addMember(l, name, get, Lua_BlackJack_ProjectL_Battle_BattleTeam.<>f__mg$cache1A, true);
		string name2 = "m_deadActorCount";
		if (Lua_BlackJack_ProjectL_Battle_BattleTeam.<>f__mg$cache1B == null)
		{
			Lua_BlackJack_ProjectL_Battle_BattleTeam.<>f__mg$cache1B = new LuaCSFunction(Lua_BlackJack_ProjectL_Battle_BattleTeam.get_m_deadActorCount);
		}
		LuaCSFunction get2 = Lua_BlackJack_ProjectL_Battle_BattleTeam.<>f__mg$cache1B;
		if (Lua_BlackJack_ProjectL_Battle_BattleTeam.<>f__mg$cache1C == null)
		{
			Lua_BlackJack_ProjectL_Battle_BattleTeam.<>f__mg$cache1C = new LuaCSFunction(Lua_BlackJack_ProjectL_Battle_BattleTeam.set_m_deadActorCount);
		}
		LuaObject.addMember(l, name2, get2, Lua_BlackJack_ProjectL_Battle_BattleTeam.<>f__mg$cache1C, true);
		string name3 = "m_actors";
		if (Lua_BlackJack_ProjectL_Battle_BattleTeam.<>f__mg$cache1D == null)
		{
			Lua_BlackJack_ProjectL_Battle_BattleTeam.<>f__mg$cache1D = new LuaCSFunction(Lua_BlackJack_ProjectL_Battle_BattleTeam.get_m_actors);
		}
		LuaCSFunction get3 = Lua_BlackJack_ProjectL_Battle_BattleTeam.<>f__mg$cache1D;
		if (Lua_BlackJack_ProjectL_Battle_BattleTeam.<>f__mg$cache1E == null)
		{
			Lua_BlackJack_ProjectL_Battle_BattleTeam.<>f__mg$cache1E = new LuaCSFunction(Lua_BlackJack_ProjectL_Battle_BattleTeam.set_m_actors);
		}
		LuaObject.addMember(l, name3, get3, Lua_BlackJack_ProjectL_Battle_BattleTeam.<>f__mg$cache1E, true);
		string name4 = "m_battle";
		if (Lua_BlackJack_ProjectL_Battle_BattleTeam.<>f__mg$cache1F == null)
		{
			Lua_BlackJack_ProjectL_Battle_BattleTeam.<>f__mg$cache1F = new LuaCSFunction(Lua_BlackJack_ProjectL_Battle_BattleTeam.get_m_battle);
		}
		LuaCSFunction get4 = Lua_BlackJack_ProjectL_Battle_BattleTeam.<>f__mg$cache1F;
		if (Lua_BlackJack_ProjectL_Battle_BattleTeam.<>f__mg$cache20 == null)
		{
			Lua_BlackJack_ProjectL_Battle_BattleTeam.<>f__mg$cache20 = new LuaCSFunction(Lua_BlackJack_ProjectL_Battle_BattleTeam.set_m_battle);
		}
		LuaObject.addMember(l, name4, get4, Lua_BlackJack_ProjectL_Battle_BattleTeam.<>f__mg$cache20, true);
		string name5 = "m_teamNumber";
		if (Lua_BlackJack_ProjectL_Battle_BattleTeam.<>f__mg$cache21 == null)
		{
			Lua_BlackJack_ProjectL_Battle_BattleTeam.<>f__mg$cache21 = new LuaCSFunction(Lua_BlackJack_ProjectL_Battle_BattleTeam.get_m_teamNumber);
		}
		LuaCSFunction get5 = Lua_BlackJack_ProjectL_Battle_BattleTeam.<>f__mg$cache21;
		if (Lua_BlackJack_ProjectL_Battle_BattleTeam.<>f__mg$cache22 == null)
		{
			Lua_BlackJack_ProjectL_Battle_BattleTeam.<>f__mg$cache22 = new LuaCSFunction(Lua_BlackJack_ProjectL_Battle_BattleTeam.set_m_teamNumber);
		}
		LuaObject.addMember(l, name5, get5, Lua_BlackJack_ProjectL_Battle_BattleTeam.<>f__mg$cache22, true);
		string name6 = "m_groupBehaviorDict";
		if (Lua_BlackJack_ProjectL_Battle_BattleTeam.<>f__mg$cache23 == null)
		{
			Lua_BlackJack_ProjectL_Battle_BattleTeam.<>f__mg$cache23 = new LuaCSFunction(Lua_BlackJack_ProjectL_Battle_BattleTeam.get_m_groupBehaviorDict);
		}
		LuaCSFunction get6 = Lua_BlackJack_ProjectL_Battle_BattleTeam.<>f__mg$cache23;
		if (Lua_BlackJack_ProjectL_Battle_BattleTeam.<>f__mg$cache24 == null)
		{
			Lua_BlackJack_ProjectL_Battle_BattleTeam.<>f__mg$cache24 = new LuaCSFunction(Lua_BlackJack_ProjectL_Battle_BattleTeam.set_m_groupBehaviorDict);
		}
		LuaObject.addMember(l, name6, get6, Lua_BlackJack_ProjectL_Battle_BattleTeam.<>f__mg$cache24, true);
		string name7 = "m_groups";
		if (Lua_BlackJack_ProjectL_Battle_BattleTeam.<>f__mg$cache25 == null)
		{
			Lua_BlackJack_ProjectL_Battle_BattleTeam.<>f__mg$cache25 = new LuaCSFunction(Lua_BlackJack_ProjectL_Battle_BattleTeam.get_m_groups);
		}
		LuaCSFunction get7 = Lua_BlackJack_ProjectL_Battle_BattleTeam.<>f__mg$cache25;
		if (Lua_BlackJack_ProjectL_Battle_BattleTeam.<>f__mg$cache26 == null)
		{
			Lua_BlackJack_ProjectL_Battle_BattleTeam.<>f__mg$cache26 = new LuaCSFunction(Lua_BlackJack_ProjectL_Battle_BattleTeam.set_m_groups);
		}
		LuaObject.addMember(l, name7, get7, Lua_BlackJack_ProjectL_Battle_BattleTeam.<>f__mg$cache26, true);
		string name8 = "Battle";
		if (Lua_BlackJack_ProjectL_Battle_BattleTeam.<>f__mg$cache27 == null)
		{
			Lua_BlackJack_ProjectL_Battle_BattleTeam.<>f__mg$cache27 = new LuaCSFunction(Lua_BlackJack_ProjectL_Battle_BattleTeam.get_Battle);
		}
		LuaObject.addMember(l, name8, Lua_BlackJack_ProjectL_Battle_BattleTeam.<>f__mg$cache27, null, true);
		string name9 = "TeamNumber";
		if (Lua_BlackJack_ProjectL_Battle_BattleTeam.<>f__mg$cache28 == null)
		{
			Lua_BlackJack_ProjectL_Battle_BattleTeam.<>f__mg$cache28 = new LuaCSFunction(Lua_BlackJack_ProjectL_Battle_BattleTeam.get_TeamNumber);
		}
		LuaObject.addMember(l, name9, Lua_BlackJack_ProjectL_Battle_BattleTeam.<>f__mg$cache28, null, true);
		string name10 = "InitNotNpcActorCount";
		if (Lua_BlackJack_ProjectL_Battle_BattleTeam.<>f__mg$cache29 == null)
		{
			Lua_BlackJack_ProjectL_Battle_BattleTeam.<>f__mg$cache29 = new LuaCSFunction(Lua_BlackJack_ProjectL_Battle_BattleTeam.get_InitNotNpcActorCount);
		}
		LuaObject.addMember(l, name10, Lua_BlackJack_ProjectL_Battle_BattleTeam.<>f__mg$cache29, null, true);
		string name11 = "DeadActorCount";
		if (Lua_BlackJack_ProjectL_Battle_BattleTeam.<>f__mg$cache2A == null)
		{
			Lua_BlackJack_ProjectL_Battle_BattleTeam.<>f__mg$cache2A = new LuaCSFunction(Lua_BlackJack_ProjectL_Battle_BattleTeam.get_DeadActorCount);
		}
		LuaObject.addMember(l, name11, Lua_BlackJack_ProjectL_Battle_BattleTeam.<>f__mg$cache2A, null, true);
		if (Lua_BlackJack_ProjectL_Battle_BattleTeam.<>f__mg$cache2B == null)
		{
			Lua_BlackJack_ProjectL_Battle_BattleTeam.<>f__mg$cache2B = new LuaCSFunction(Lua_BlackJack_ProjectL_Battle_BattleTeam.constructor);
		}
		LuaObject.createTypeMetatable(l, Lua_BlackJack_ProjectL_Battle_BattleTeam.<>f__mg$cache2B, typeof(BattleTeam));
	}

	// Token: 0x0400DB1E RID: 56094
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache0;

	// Token: 0x0400DB1F RID: 56095
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1;

	// Token: 0x0400DB20 RID: 56096
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2;

	// Token: 0x0400DB21 RID: 56097
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3;

	// Token: 0x0400DB22 RID: 56098
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache4;

	// Token: 0x0400DB23 RID: 56099
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache5;

	// Token: 0x0400DB24 RID: 56100
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache6;

	// Token: 0x0400DB25 RID: 56101
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache7;

	// Token: 0x0400DB26 RID: 56102
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache8;

	// Token: 0x0400DB27 RID: 56103
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache9;

	// Token: 0x0400DB28 RID: 56104
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheA;

	// Token: 0x0400DB29 RID: 56105
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheB;

	// Token: 0x0400DB2A RID: 56106
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheC;

	// Token: 0x0400DB2B RID: 56107
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheD;

	// Token: 0x0400DB2C RID: 56108
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheE;

	// Token: 0x0400DB2D RID: 56109
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheF;

	// Token: 0x0400DB2E RID: 56110
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache10;

	// Token: 0x0400DB2F RID: 56111
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache11;

	// Token: 0x0400DB30 RID: 56112
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache12;

	// Token: 0x0400DB31 RID: 56113
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache13;

	// Token: 0x0400DB32 RID: 56114
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache14;

	// Token: 0x0400DB33 RID: 56115
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache15;

	// Token: 0x0400DB34 RID: 56116
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache16;

	// Token: 0x0400DB35 RID: 56117
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache17;

	// Token: 0x0400DB36 RID: 56118
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache18;

	// Token: 0x0400DB37 RID: 56119
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache19;

	// Token: 0x0400DB38 RID: 56120
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1A;

	// Token: 0x0400DB39 RID: 56121
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1B;

	// Token: 0x0400DB3A RID: 56122
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1C;

	// Token: 0x0400DB3B RID: 56123
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1D;

	// Token: 0x0400DB3C RID: 56124
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1E;

	// Token: 0x0400DB3D RID: 56125
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1F;

	// Token: 0x0400DB3E RID: 56126
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache20;

	// Token: 0x0400DB3F RID: 56127
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache21;

	// Token: 0x0400DB40 RID: 56128
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache22;

	// Token: 0x0400DB41 RID: 56129
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache23;

	// Token: 0x0400DB42 RID: 56130
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache24;

	// Token: 0x0400DB43 RID: 56131
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache25;

	// Token: 0x0400DB44 RID: 56132
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache26;

	// Token: 0x0400DB45 RID: 56133
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache27;

	// Token: 0x0400DB46 RID: 56134
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache28;

	// Token: 0x0400DB47 RID: 56135
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache29;

	// Token: 0x0400DB48 RID: 56136
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2A;

	// Token: 0x0400DB49 RID: 56137
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2B;
}
