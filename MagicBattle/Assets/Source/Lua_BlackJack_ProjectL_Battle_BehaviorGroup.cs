using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using BlackJack.ConfigData;
using BlackJack.ProjectL.Battle;
using SLua;
using UnityEngine.Scripting;

// Token: 0x020011A2 RID: 4514
[Preserve]
public class Lua_BlackJack_ProjectL_Battle_BehaviorGroup : LuaObject
{
	// Token: 0x060174BE RID: 95422 RVA: 0x00653D1C File Offset: 0x00651F1C
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int constructor(IntPtr l)
	{
		int result;
		try
		{
			int id;
			LuaObject.checkType(l, 2, out id);
			BattleTeam team;
			LuaObject.checkType<BattleTeam>(l, 3, out team);
			BehaviorGroup o = new BehaviorGroup(id, team);
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

	// Token: 0x060174BF RID: 95423 RVA: 0x00653D7C File Offset: 0x00651F7C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int AddActor(IntPtr l)
	{
		int result;
		try
		{
			BehaviorGroup behaviorGroup = (BehaviorGroup)LuaObject.checkSelf(l);
			BattleActor actor;
			LuaObject.checkType<BattleActor>(l, 2, out actor);
			behaviorGroup.AddActor(actor);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060174C0 RID: 95424 RVA: 0x00653DD4 File Offset: 0x00651FD4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int SetBahvior(IntPtr l)
	{
		int result;
		try
		{
			BehaviorGroup behaviorGroup = (BehaviorGroup)LuaObject.checkSelf(l);
			int bahvior;
			LuaObject.checkType(l, 2, out bahvior);
			behaviorGroup.SetBahvior(bahvior);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060174C1 RID: 95425 RVA: 0x00653E2C File Offset: 0x0065202C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int DoBehavor(IntPtr l)
	{
		int result;
		try
		{
			BehaviorGroup behaviorGroup = (BehaviorGroup)LuaObject.checkSelf(l);
			behaviorGroup.DoBehavor();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060174C2 RID: 95426 RVA: 0x00653E78 File Offset: 0x00652078
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_ID(IntPtr l)
	{
		int result;
		try
		{
			BehaviorGroup behaviorGroup = (BehaviorGroup)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, behaviorGroup.m_luaExportHelper.m_ID);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060174C3 RID: 95427 RVA: 0x00653ED0 File Offset: 0x006520D0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_ID(IntPtr l)
	{
		int result;
		try
		{
			BehaviorGroup behaviorGroup = (BehaviorGroup)LuaObject.checkSelf(l);
			int id;
			LuaObject.checkType(l, 2, out id);
			behaviorGroup.m_luaExportHelper.m_ID = id;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060174C4 RID: 95428 RVA: 0x00653F2C File Offset: 0x0065212C
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_m_team(IntPtr l)
	{
		int result;
		try
		{
			BehaviorGroup behaviorGroup = (BehaviorGroup)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, behaviorGroup.m_luaExportHelper.m_team);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060174C5 RID: 95429 RVA: 0x00653F84 File Offset: 0x00652184
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_m_team(IntPtr l)
	{
		int result;
		try
		{
			BehaviorGroup behaviorGroup = (BehaviorGroup)LuaObject.checkSelf(l);
			BattleTeam team;
			LuaObject.checkType<BattleTeam>(l, 2, out team);
			behaviorGroup.m_luaExportHelper.m_team = team;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060174C6 RID: 95430 RVA: 0x00653FE0 File Offset: 0x006521E0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_actors(IntPtr l)
	{
		int result;
		try
		{
			BehaviorGroup behaviorGroup = (BehaviorGroup)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, behaviorGroup.m_luaExportHelper.m_actors);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060174C7 RID: 95431 RVA: 0x00654038 File Offset: 0x00652238
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_actors(IntPtr l)
	{
		int result;
		try
		{
			BehaviorGroup behaviorGroup = (BehaviorGroup)LuaObject.checkSelf(l);
			List<BattleActor> actors;
			LuaObject.checkType<List<BattleActor>>(l, 2, out actors);
			behaviorGroup.m_luaExportHelper.m_actors = actors;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060174C8 RID: 95432 RVA: 0x00654094 File Offset: 0x00652294
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_curBehaviorCfg(IntPtr l)
	{
		int result;
		try
		{
			BehaviorGroup behaviorGroup = (BehaviorGroup)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, behaviorGroup.m_luaExportHelper.m_curBehaviorCfg);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060174C9 RID: 95433 RVA: 0x006540EC File Offset: 0x006522EC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_curBehaviorCfg(IntPtr l)
	{
		int result;
		try
		{
			BehaviorGroup behaviorGroup = (BehaviorGroup)LuaObject.checkSelf(l);
			ConfigDataGroupBehavior curBehaviorCfg;
			LuaObject.checkType<ConfigDataGroupBehavior>(l, 2, out curBehaviorCfg);
			behaviorGroup.m_luaExportHelper.m_curBehaviorCfg = curBehaviorCfg;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060174CA RID: 95434 RVA: 0x00654148 File Offset: 0x00652348
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_m_leader(IntPtr l)
	{
		int result;
		try
		{
			BehaviorGroup behaviorGroup = (BehaviorGroup)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, behaviorGroup.m_luaExportHelper.m_leader);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060174CB RID: 95435 RVA: 0x006541A0 File Offset: 0x006523A0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_leader(IntPtr l)
	{
		int result;
		try
		{
			BehaviorGroup behaviorGroup = (BehaviorGroup)LuaObject.checkSelf(l);
			BattleActor leader;
			LuaObject.checkType<BattleActor>(l, 2, out leader);
			behaviorGroup.m_luaExportHelper.m_leader = leader;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060174CC RID: 95436 RVA: 0x006541FC File Offset: 0x006523FC
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_m_leaderNormalActionPriority(IntPtr l)
	{
		int result;
		try
		{
			BehaviorGroup behaviorGroup = (BehaviorGroup)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, behaviorGroup.m_luaExportHelper.m_leaderNormalActionPriority);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060174CD RID: 95437 RVA: 0x00654254 File Offset: 0x00652454
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_leaderNormalActionPriority(IntPtr l)
	{
		int result;
		try
		{
			BehaviorGroup behaviorGroup = (BehaviorGroup)LuaObject.checkSelf(l);
			int leaderNormalActionPriority;
			LuaObject.checkType(l, 2, out leaderNormalActionPriority);
			behaviorGroup.m_luaExportHelper.m_leaderNormalActionPriority = leaderNormalActionPriority;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060174CE RID: 95438 RVA: 0x006542B0 File Offset: 0x006524B0
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_m_singleBehaviors(IntPtr l)
	{
		int result;
		try
		{
			BehaviorGroup behaviorGroup = (BehaviorGroup)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, behaviorGroup.m_luaExportHelper.m_singleBehaviors);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060174CF RID: 95439 RVA: 0x00654308 File Offset: 0x00652508
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_m_singleBehaviors(IntPtr l)
	{
		int result;
		try
		{
			BehaviorGroup behaviorGroup = (BehaviorGroup)LuaObject.checkSelf(l);
			List<int> singleBehaviors;
			LuaObject.checkType<List<int>>(l, 2, out singleBehaviors);
			behaviorGroup.m_luaExportHelper.m_singleBehaviors = singleBehaviors;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060174D0 RID: 95440 RVA: 0x00654364 File Offset: 0x00652564
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_ID(IntPtr l)
	{
		int result;
		try
		{
			BehaviorGroup behaviorGroup = (BehaviorGroup)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, behaviorGroup.ID);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060174D1 RID: 95441 RVA: 0x006543B8 File Offset: 0x006525B8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_Leader(IntPtr l)
	{
		int result;
		try
		{
			BehaviorGroup behaviorGroup = (BehaviorGroup)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, behaviorGroup.Leader);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060174D2 RID: 95442 RVA: 0x0065440C File Offset: 0x0065260C
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_Behavior(IntPtr l)
	{
		int result;
		try
		{
			BehaviorGroup behaviorGroup = (BehaviorGroup)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, behaviorGroup.Behavior);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060174D3 RID: 95443 RVA: 0x00654460 File Offset: 0x00652660
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_Actors(IntPtr l)
	{
		int result;
		try
		{
			BehaviorGroup behaviorGroup = (BehaviorGroup)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, behaviorGroup.Actors);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060174D4 RID: 95444 RVA: 0x006544B4 File Offset: 0x006526B4
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_InstanceID(IntPtr l)
	{
		int result;
		try
		{
			BehaviorGroup behaviorGroup = (BehaviorGroup)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, behaviorGroup.InstanceID);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060174D5 RID: 95445 RVA: 0x00654508 File Offset: 0x00652708
	[Preserve]
	public static void reg(IntPtr l)
	{
		LuaObject.getTypeTable(l, "BlackJack.ProjectL.Battle.BehaviorGroup");
		if (Lua_BlackJack_ProjectL_Battle_BehaviorGroup.<>f__mg$cache0 == null)
		{
			Lua_BlackJack_ProjectL_Battle_BehaviorGroup.<>f__mg$cache0 = new LuaCSFunction(Lua_BlackJack_ProjectL_Battle_BehaviorGroup.AddActor);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Battle_BehaviorGroup.<>f__mg$cache0);
		if (Lua_BlackJack_ProjectL_Battle_BehaviorGroup.<>f__mg$cache1 == null)
		{
			Lua_BlackJack_ProjectL_Battle_BehaviorGroup.<>f__mg$cache1 = new LuaCSFunction(Lua_BlackJack_ProjectL_Battle_BehaviorGroup.SetBahvior);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Battle_BehaviorGroup.<>f__mg$cache1);
		if (Lua_BlackJack_ProjectL_Battle_BehaviorGroup.<>f__mg$cache2 == null)
		{
			Lua_BlackJack_ProjectL_Battle_BehaviorGroup.<>f__mg$cache2 = new LuaCSFunction(Lua_BlackJack_ProjectL_Battle_BehaviorGroup.DoBehavor);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Battle_BehaviorGroup.<>f__mg$cache2);
		string name = "m_ID";
		if (Lua_BlackJack_ProjectL_Battle_BehaviorGroup.<>f__mg$cache3 == null)
		{
			Lua_BlackJack_ProjectL_Battle_BehaviorGroup.<>f__mg$cache3 = new LuaCSFunction(Lua_BlackJack_ProjectL_Battle_BehaviorGroup.get_m_ID);
		}
		LuaCSFunction get = Lua_BlackJack_ProjectL_Battle_BehaviorGroup.<>f__mg$cache3;
		if (Lua_BlackJack_ProjectL_Battle_BehaviorGroup.<>f__mg$cache4 == null)
		{
			Lua_BlackJack_ProjectL_Battle_BehaviorGroup.<>f__mg$cache4 = new LuaCSFunction(Lua_BlackJack_ProjectL_Battle_BehaviorGroup.set_m_ID);
		}
		LuaObject.addMember(l, name, get, Lua_BlackJack_ProjectL_Battle_BehaviorGroup.<>f__mg$cache4, true);
		string name2 = "m_team";
		if (Lua_BlackJack_ProjectL_Battle_BehaviorGroup.<>f__mg$cache5 == null)
		{
			Lua_BlackJack_ProjectL_Battle_BehaviorGroup.<>f__mg$cache5 = new LuaCSFunction(Lua_BlackJack_ProjectL_Battle_BehaviorGroup.get_m_team);
		}
		LuaCSFunction get2 = Lua_BlackJack_ProjectL_Battle_BehaviorGroup.<>f__mg$cache5;
		if (Lua_BlackJack_ProjectL_Battle_BehaviorGroup.<>f__mg$cache6 == null)
		{
			Lua_BlackJack_ProjectL_Battle_BehaviorGroup.<>f__mg$cache6 = new LuaCSFunction(Lua_BlackJack_ProjectL_Battle_BehaviorGroup.set_m_team);
		}
		LuaObject.addMember(l, name2, get2, Lua_BlackJack_ProjectL_Battle_BehaviorGroup.<>f__mg$cache6, true);
		string name3 = "m_actors";
		if (Lua_BlackJack_ProjectL_Battle_BehaviorGroup.<>f__mg$cache7 == null)
		{
			Lua_BlackJack_ProjectL_Battle_BehaviorGroup.<>f__mg$cache7 = new LuaCSFunction(Lua_BlackJack_ProjectL_Battle_BehaviorGroup.get_m_actors);
		}
		LuaCSFunction get3 = Lua_BlackJack_ProjectL_Battle_BehaviorGroup.<>f__mg$cache7;
		if (Lua_BlackJack_ProjectL_Battle_BehaviorGroup.<>f__mg$cache8 == null)
		{
			Lua_BlackJack_ProjectL_Battle_BehaviorGroup.<>f__mg$cache8 = new LuaCSFunction(Lua_BlackJack_ProjectL_Battle_BehaviorGroup.set_m_actors);
		}
		LuaObject.addMember(l, name3, get3, Lua_BlackJack_ProjectL_Battle_BehaviorGroup.<>f__mg$cache8, true);
		string name4 = "m_curBehaviorCfg";
		if (Lua_BlackJack_ProjectL_Battle_BehaviorGroup.<>f__mg$cache9 == null)
		{
			Lua_BlackJack_ProjectL_Battle_BehaviorGroup.<>f__mg$cache9 = new LuaCSFunction(Lua_BlackJack_ProjectL_Battle_BehaviorGroup.get_m_curBehaviorCfg);
		}
		LuaCSFunction get4 = Lua_BlackJack_ProjectL_Battle_BehaviorGroup.<>f__mg$cache9;
		if (Lua_BlackJack_ProjectL_Battle_BehaviorGroup.<>f__mg$cacheA == null)
		{
			Lua_BlackJack_ProjectL_Battle_BehaviorGroup.<>f__mg$cacheA = new LuaCSFunction(Lua_BlackJack_ProjectL_Battle_BehaviorGroup.set_m_curBehaviorCfg);
		}
		LuaObject.addMember(l, name4, get4, Lua_BlackJack_ProjectL_Battle_BehaviorGroup.<>f__mg$cacheA, true);
		string name5 = "m_leader";
		if (Lua_BlackJack_ProjectL_Battle_BehaviorGroup.<>f__mg$cacheB == null)
		{
			Lua_BlackJack_ProjectL_Battle_BehaviorGroup.<>f__mg$cacheB = new LuaCSFunction(Lua_BlackJack_ProjectL_Battle_BehaviorGroup.get_m_leader);
		}
		LuaCSFunction get5 = Lua_BlackJack_ProjectL_Battle_BehaviorGroup.<>f__mg$cacheB;
		if (Lua_BlackJack_ProjectL_Battle_BehaviorGroup.<>f__mg$cacheC == null)
		{
			Lua_BlackJack_ProjectL_Battle_BehaviorGroup.<>f__mg$cacheC = new LuaCSFunction(Lua_BlackJack_ProjectL_Battle_BehaviorGroup.set_m_leader);
		}
		LuaObject.addMember(l, name5, get5, Lua_BlackJack_ProjectL_Battle_BehaviorGroup.<>f__mg$cacheC, true);
		string name6 = "m_leaderNormalActionPriority";
		if (Lua_BlackJack_ProjectL_Battle_BehaviorGroup.<>f__mg$cacheD == null)
		{
			Lua_BlackJack_ProjectL_Battle_BehaviorGroup.<>f__mg$cacheD = new LuaCSFunction(Lua_BlackJack_ProjectL_Battle_BehaviorGroup.get_m_leaderNormalActionPriority);
		}
		LuaCSFunction get6 = Lua_BlackJack_ProjectL_Battle_BehaviorGroup.<>f__mg$cacheD;
		if (Lua_BlackJack_ProjectL_Battle_BehaviorGroup.<>f__mg$cacheE == null)
		{
			Lua_BlackJack_ProjectL_Battle_BehaviorGroup.<>f__mg$cacheE = new LuaCSFunction(Lua_BlackJack_ProjectL_Battle_BehaviorGroup.set_m_leaderNormalActionPriority);
		}
		LuaObject.addMember(l, name6, get6, Lua_BlackJack_ProjectL_Battle_BehaviorGroup.<>f__mg$cacheE, true);
		string name7 = "m_singleBehaviors";
		if (Lua_BlackJack_ProjectL_Battle_BehaviorGroup.<>f__mg$cacheF == null)
		{
			Lua_BlackJack_ProjectL_Battle_BehaviorGroup.<>f__mg$cacheF = new LuaCSFunction(Lua_BlackJack_ProjectL_Battle_BehaviorGroup.get_m_singleBehaviors);
		}
		LuaCSFunction get7 = Lua_BlackJack_ProjectL_Battle_BehaviorGroup.<>f__mg$cacheF;
		if (Lua_BlackJack_ProjectL_Battle_BehaviorGroup.<>f__mg$cache10 == null)
		{
			Lua_BlackJack_ProjectL_Battle_BehaviorGroup.<>f__mg$cache10 = new LuaCSFunction(Lua_BlackJack_ProjectL_Battle_BehaviorGroup.set_m_singleBehaviors);
		}
		LuaObject.addMember(l, name7, get7, Lua_BlackJack_ProjectL_Battle_BehaviorGroup.<>f__mg$cache10, true);
		string name8 = "ID";
		if (Lua_BlackJack_ProjectL_Battle_BehaviorGroup.<>f__mg$cache11 == null)
		{
			Lua_BlackJack_ProjectL_Battle_BehaviorGroup.<>f__mg$cache11 = new LuaCSFunction(Lua_BlackJack_ProjectL_Battle_BehaviorGroup.get_ID);
		}
		LuaObject.addMember(l, name8, Lua_BlackJack_ProjectL_Battle_BehaviorGroup.<>f__mg$cache11, null, true);
		string name9 = "Leader";
		if (Lua_BlackJack_ProjectL_Battle_BehaviorGroup.<>f__mg$cache12 == null)
		{
			Lua_BlackJack_ProjectL_Battle_BehaviorGroup.<>f__mg$cache12 = new LuaCSFunction(Lua_BlackJack_ProjectL_Battle_BehaviorGroup.get_Leader);
		}
		LuaObject.addMember(l, name9, Lua_BlackJack_ProjectL_Battle_BehaviorGroup.<>f__mg$cache12, null, true);
		string name10 = "Behavior";
		if (Lua_BlackJack_ProjectL_Battle_BehaviorGroup.<>f__mg$cache13 == null)
		{
			Lua_BlackJack_ProjectL_Battle_BehaviorGroup.<>f__mg$cache13 = new LuaCSFunction(Lua_BlackJack_ProjectL_Battle_BehaviorGroup.get_Behavior);
		}
		LuaObject.addMember(l, name10, Lua_BlackJack_ProjectL_Battle_BehaviorGroup.<>f__mg$cache13, null, true);
		string name11 = "Actors";
		if (Lua_BlackJack_ProjectL_Battle_BehaviorGroup.<>f__mg$cache14 == null)
		{
			Lua_BlackJack_ProjectL_Battle_BehaviorGroup.<>f__mg$cache14 = new LuaCSFunction(Lua_BlackJack_ProjectL_Battle_BehaviorGroup.get_Actors);
		}
		LuaObject.addMember(l, name11, Lua_BlackJack_ProjectL_Battle_BehaviorGroup.<>f__mg$cache14, null, true);
		string name12 = "InstanceID";
		if (Lua_BlackJack_ProjectL_Battle_BehaviorGroup.<>f__mg$cache15 == null)
		{
			Lua_BlackJack_ProjectL_Battle_BehaviorGroup.<>f__mg$cache15 = new LuaCSFunction(Lua_BlackJack_ProjectL_Battle_BehaviorGroup.get_InstanceID);
		}
		LuaObject.addMember(l, name12, Lua_BlackJack_ProjectL_Battle_BehaviorGroup.<>f__mg$cache15, null, true);
		if (Lua_BlackJack_ProjectL_Battle_BehaviorGroup.<>f__mg$cache16 == null)
		{
			Lua_BlackJack_ProjectL_Battle_BehaviorGroup.<>f__mg$cache16 = new LuaCSFunction(Lua_BlackJack_ProjectL_Battle_BehaviorGroup.constructor);
		}
		LuaObject.createTypeMetatable(l, Lua_BlackJack_ProjectL_Battle_BehaviorGroup.<>f__mg$cache16, typeof(BehaviorGroup));
	}

	// Token: 0x0400DB5C RID: 56156
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache0;

	// Token: 0x0400DB5D RID: 56157
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1;

	// Token: 0x0400DB5E RID: 56158
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2;

	// Token: 0x0400DB5F RID: 56159
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3;

	// Token: 0x0400DB60 RID: 56160
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache4;

	// Token: 0x0400DB61 RID: 56161
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache5;

	// Token: 0x0400DB62 RID: 56162
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache6;

	// Token: 0x0400DB63 RID: 56163
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache7;

	// Token: 0x0400DB64 RID: 56164
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache8;

	// Token: 0x0400DB65 RID: 56165
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache9;

	// Token: 0x0400DB66 RID: 56166
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheA;

	// Token: 0x0400DB67 RID: 56167
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheB;

	// Token: 0x0400DB68 RID: 56168
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheC;

	// Token: 0x0400DB69 RID: 56169
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheD;

	// Token: 0x0400DB6A RID: 56170
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheE;

	// Token: 0x0400DB6B RID: 56171
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheF;

	// Token: 0x0400DB6C RID: 56172
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache10;

	// Token: 0x0400DB6D RID: 56173
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache11;

	// Token: 0x0400DB6E RID: 56174
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache12;

	// Token: 0x0400DB6F RID: 56175
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache13;

	// Token: 0x0400DB70 RID: 56176
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache14;

	// Token: 0x0400DB71 RID: 56177
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache15;

	// Token: 0x0400DB72 RID: 56178
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache16;
}
