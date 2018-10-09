using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using BlackJack.ConfigData;
using BlackJack.ProjectL.Battle;
using BlackJack.ProjectL.Common;
using SLua;
using UnityEngine.Scripting;

// Token: 0x02001192 RID: 4498
[Preserve]
public class Lua_BlackJack_ProjectL_Battle_BattleBase : LuaObject
{
	// Token: 0x0601722F RID: 94767 RVA: 0x006400AC File Offset: 0x0063E2AC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int constructor(IntPtr l)
	{
		int result;
		try
		{
			IConfigDataLoader configDataLoader;
			LuaObject.checkType<IConfigDataLoader>(l, 2, out configDataLoader);
			IBattleListener battleListener;
			LuaObject.checkType<IBattleListener>(l, 3, out battleListener);
			BattleBase o = new BattleBase(configDataLoader, battleListener);
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

	// Token: 0x06017230 RID: 94768 RVA: 0x0064010C File Offset: 0x0063E30C
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int Dispose(IntPtr l)
	{
		int result;
		try
		{
			BattleBase battleBase = (BattleBase)LuaObject.checkSelf(l);
			battleBase.Dispose();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06017231 RID: 94769 RVA: 0x00640158 File Offset: 0x0063E358
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int SetWinForCheat(IntPtr l)
	{
		int result;
		try
		{
			BattleBase battleBase = (BattleBase)LuaObject.checkSelf(l);
			battleBase.SetWinForCheat();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06017232 RID: 94770 RVA: 0x006401A4 File Offset: 0x0063E3A4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int Clear(IntPtr l)
	{
		int result;
		try
		{
			BattleBase battleBase = (BattleBase)LuaObject.checkSelf(l);
			battleBase.Clear();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06017233 RID: 94771 RVA: 0x006401F0 File Offset: 0x0063E3F0
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int GetStarTurnMax(IntPtr l)
	{
		int result;
		try
		{
			BattleBase battleBase = (BattleBase)LuaObject.checkSelf(l);
			int starTurnMax = battleBase.GetStarTurnMax();
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, starTurnMax);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06017234 RID: 94772 RVA: 0x00640244 File Offset: 0x0063E444
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int GetStarDeadMax(IntPtr l)
	{
		int result;
		try
		{
			BattleBase battleBase = (BattleBase)LuaObject.checkSelf(l);
			int starDeadMax = battleBase.GetStarDeadMax();
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, starDeadMax);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06017235 RID: 94773 RVA: 0x00640298 File Offset: 0x0063E498
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int IsPerformOnlyBattle(IntPtr l)
	{
		int result;
		try
		{
			BattleBase battleBase = (BattleBase)LuaObject.checkSelf(l);
			bool b = battleBase.IsPerformOnlyBattle();
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

	// Token: 0x06017236 RID: 94774 RVA: 0x006402EC File Offset: 0x0063E4EC
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int Start(IntPtr l)
	{
		int result;
		try
		{
			BattleBase battleBase = (BattleBase)LuaObject.checkSelf(l);
			battleBase.Start();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06017237 RID: 94775 RVA: 0x00640338 File Offset: 0x0063E538
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int FirstStep(IntPtr l)
	{
		int result;
		try
		{
			BattleBase battleBase = (BattleBase)LuaObject.checkSelf(l);
			bool skipPerformCombat;
			LuaObject.checkType(l, 2, out skipPerformCombat);
			battleBase.FirstStep(skipPerformCombat);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06017238 RID: 94776 RVA: 0x00640390 File Offset: 0x0063E590
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int GetActionTeam(IntPtr l)
	{
		int result;
		try
		{
			BattleBase battleBase = (BattleBase)LuaObject.checkSelf(l);
			int actionTeam = battleBase.GetActionTeam();
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, actionTeam);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06017239 RID: 94777 RVA: 0x006403E4 File Offset: 0x0063E5E4
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int GetActionActor(IntPtr l)
	{
		int result;
		try
		{
			BattleBase battleBase = (BattleBase)LuaObject.checkSelf(l);
			BattleActor actionActor = battleBase.GetActionActor();
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, actionActor);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601723A RID: 94778 RVA: 0x00640438 File Offset: 0x0063E638
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int ChangeActionActor(IntPtr l)
	{
		int result;
		try
		{
			BattleBase battleBase = (BattleBase)LuaObject.checkSelf(l);
			BattleActor a;
			LuaObject.checkType<BattleActor>(l, 2, out a);
			bool b = battleBase.ChangeActionActor(a);
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

	// Token: 0x0601723B RID: 94779 RVA: 0x0064049C File Offset: 0x0063E69C
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int Tick(IntPtr l)
	{
		int result;
		try
		{
			BattleBase battleBase = (BattleBase)LuaObject.checkSelf(l);
			battleBase.Tick();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601723C RID: 94780 RVA: 0x006404E8 File Offset: 0x0063E6E8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int TickGraphic(IntPtr l)
	{
		int result;
		try
		{
			BattleBase battleBase = (BattleBase)LuaObject.checkSelf(l);
			float dt;
			LuaObject.checkType(l, 2, out dt);
			battleBase.TickGraphic(dt);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601723D RID: 94781 RVA: 0x00640540 File Offset: 0x0063E740
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int Draw(IntPtr l)
	{
		int result;
		try
		{
			BattleBase battleBase = (BattleBase)LuaObject.checkSelf(l);
			battleBase.Draw();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601723E RID: 94782 RVA: 0x0064058C File Offset: 0x0063E78C
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int ChangeMapTerrain(IntPtr l)
	{
		int result;
		try
		{
			BattleBase battleBase = (BattleBase)LuaObject.checkSelf(l);
			GridPosition p;
			LuaObject.checkValueType<GridPosition>(l, 2, out p);
			ConfigDataTerrainInfo terrainInfo;
			LuaObject.checkType<ConfigDataTerrainInfo>(l, 3, out terrainInfo);
			battleBase.ChangeMapTerrain(p, terrainInfo);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601723F RID: 94783 RVA: 0x006405F0 File Offset: 0x0063E7F0
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int GetTeam(IntPtr l)
	{
		int result;
		try
		{
			BattleBase battleBase = (BattleBase)LuaObject.checkSelf(l);
			int teamNumber;
			LuaObject.checkType(l, 2, out teamNumber);
			BattleTeam team = battleBase.GetTeam(teamNumber);
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

	// Token: 0x06017240 RID: 94784 RVA: 0x00640654 File Offset: 0x0063E854
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int GetBattlePlayer(IntPtr l)
	{
		int result;
		try
		{
			BattleBase battleBase = (BattleBase)LuaObject.checkSelf(l);
			int playerIndex;
			LuaObject.checkType(l, 2, out playerIndex);
			BattlePlayer battlePlayer = battleBase.GetBattlePlayer(playerIndex);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, battlePlayer);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06017241 RID: 94785 RVA: 0x006406B8 File Offset: 0x0063E8B8
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int GetActorById(IntPtr l)
	{
		int result;
		try
		{
			BattleBase battleBase = (BattleBase)LuaObject.checkSelf(l);
			int id;
			LuaObject.checkType(l, 2, out id);
			BattleActor actorById = battleBase.GetActorById(id);
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

	// Token: 0x06017242 RID: 94786 RVA: 0x0064071C File Offset: 0x0063E91C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int GetActorByHeroId(IntPtr l)
	{
		int result;
		try
		{
			BattleBase battleBase = (BattleBase)LuaObject.checkSelf(l);
			int heroId;
			LuaObject.checkType(l, 2, out heroId);
			BattleActor actorByHeroId = battleBase.GetActorByHeroId(heroId);
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

	// Token: 0x06017243 RID: 94787 RVA: 0x00640780 File Offset: 0x0063E980
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int GetNextEntityId(IntPtr l)
	{
		int result;
		try
		{
			BattleBase battleBase = (BattleBase)LuaObject.checkSelf(l);
			int nextEntityId = battleBase.GetNextEntityId();
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

	// Token: 0x06017244 RID: 94788 RVA: 0x006407D4 File Offset: 0x0063E9D4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int CheckOnActorMove(IntPtr l)
	{
		int result;
		try
		{
			BattleBase battleBase = (BattleBase)LuaObject.checkSelf(l);
			BattleActor actor;
			LuaObject.checkType<BattleActor>(l, 2, out actor);
			battleBase.CheckOnActorMove(actor);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06017245 RID: 94789 RVA: 0x0064082C File Offset: 0x0063EA2C
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int CheckOnActorDie(IntPtr l)
	{
		int result;
		try
		{
			BattleBase battleBase = (BattleBase)LuaObject.checkSelf(l);
			BattleActor actor;
			LuaObject.checkType<BattleActor>(l, 2, out actor);
			battleBase.CheckOnActorDie(actor);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06017246 RID: 94790 RVA: 0x00640884 File Offset: 0x0063EA84
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int OnActorDie(IntPtr l)
	{
		int result;
		try
		{
			BattleBase battleBase = (BattleBase)LuaObject.checkSelf(l);
			BattleActor actor;
			LuaObject.checkType<BattleActor>(l, 2, out actor);
			battleBase.OnActorDie(actor);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06017247 RID: 94791 RVA: 0x006408DC File Offset: 0x0063EADC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int OnActorRetreat(IntPtr l)
	{
		int result;
		try
		{
			BattleBase battleBase = (BattleBase)LuaObject.checkSelf(l);
			BattleActor actor;
			LuaObject.checkType<BattleActor>(l, 2, out actor);
			int effectType;
			LuaObject.checkType(l, 3, out effectType);
			string fxName;
			LuaObject.checkType(l, 4, out fxName);
			bool notifyListener;
			LuaObject.checkType(l, 5, out notifyListener);
			battleBase.OnActorRetreat(actor, effectType, fxName, notifyListener);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06017248 RID: 94792 RVA: 0x0064095C File Offset: 0x0063EB5C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int OnActorChangeTeam(IntPtr l)
	{
		int result;
		try
		{
			BattleBase battleBase = (BattleBase)LuaObject.checkSelf(l);
			BattleActor actor;
			LuaObject.checkType<BattleActor>(l, 2, out actor);
			battleBase.OnActorChangeTeam(actor);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06017249 RID: 94793 RVA: 0x006409B4 File Offset: 0x0063EBB4
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int IsPlay(IntPtr l)
	{
		int result;
		try
		{
			BattleBase battleBase = (BattleBase)LuaObject.checkSelf(l);
			bool b = battleBase.IsPlay();
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

	// Token: 0x0601724A RID: 94794 RVA: 0x00640A08 File Offset: 0x0063EC08
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int IsGiveupBattle(IntPtr l)
	{
		int result;
		try
		{
			BattleBase battleBase = (BattleBase)LuaObject.checkSelf(l);
			bool b = battleBase.IsGiveupBattle();
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

	// Token: 0x0601724B RID: 94795 RVA: 0x00640A5C File Offset: 0x0063EC5C
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int GetGiveupBattlePlayerIndex(IntPtr l)
	{
		int result;
		try
		{
			BattleBase battleBase = (BattleBase)LuaObject.checkSelf(l);
			int giveupBattlePlayerIndex = battleBase.GetGiveupBattlePlayerIndex();
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, giveupBattlePlayerIndex);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601724C RID: 94796 RVA: 0x00640AB0 File Offset: 0x0063ECB0
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int AllocateTempIntList(IntPtr l)
	{
		int result;
		try
		{
			BattleBase battleBase = (BattleBase)LuaObject.checkSelf(l);
			List<int> o = battleBase.AllocateTempIntList();
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

	// Token: 0x0601724D RID: 94797 RVA: 0x00640B04 File Offset: 0x0063ED04
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int FreeTempIntList(IntPtr l)
	{
		int result;
		try
		{
			BattleBase battleBase = (BattleBase)LuaObject.checkSelf(l);
			List<int> list;
			LuaObject.checkType<List<int>>(l, 2, out list);
			battleBase.FreeTempIntList(list);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601724E RID: 94798 RVA: 0x00640B5C File Offset: 0x0063ED5C
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int AllocateTempGridPositionList(IntPtr l)
	{
		int result;
		try
		{
			BattleBase battleBase = (BattleBase)LuaObject.checkSelf(l);
			List<GridPosition> o = battleBase.AllocateTempGridPositionList();
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

	// Token: 0x0601724F RID: 94799 RVA: 0x00640BB0 File Offset: 0x0063EDB0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int FreeTempGridPositionList(IntPtr l)
	{
		int result;
		try
		{
			BattleBase battleBase = (BattleBase)LuaObject.checkSelf(l);
			List<GridPosition> list;
			LuaObject.checkType<List<GridPosition>>(l, 2, out list);
			battleBase.FreeTempGridPositionList(list);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06017250 RID: 94800 RVA: 0x00640C08 File Offset: 0x0063EE08
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int AllocateTempActorList(IntPtr l)
	{
		int result;
		try
		{
			BattleBase battleBase = (BattleBase)LuaObject.checkSelf(l);
			List<BattleActor> o = battleBase.AllocateTempActorList();
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

	// Token: 0x06017251 RID: 94801 RVA: 0x00640C5C File Offset: 0x0063EE5C
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int FreeTempActorList(IntPtr l)
	{
		int result;
		try
		{
			BattleBase battleBase = (BattleBase)LuaObject.checkSelf(l);
			List<BattleActor> list;
			LuaObject.checkType<List<BattleActor>>(l, 2, out list);
			battleBase.FreeTempActorList(list);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06017252 RID: 94802 RVA: 0x00640CB4 File Offset: 0x0063EEB4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int AllocateTempBuffList(IntPtr l)
	{
		int result;
		try
		{
			BattleBase battleBase = (BattleBase)LuaObject.checkSelf(l);
			List<ConfigDataBuffInfo> o = battleBase.AllocateTempBuffList();
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

	// Token: 0x06017253 RID: 94803 RVA: 0x00640D08 File Offset: 0x0063EF08
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int FreeTempBuffList(IntPtr l)
	{
		int result;
		try
		{
			BattleBase battleBase = (BattleBase)LuaObject.checkSelf(l);
			List<ConfigDataBuffInfo> list;
			LuaObject.checkType<List<ConfigDataBuffInfo>>(l, 2, out list);
			battleBase.FreeTempBuffList(list);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06017254 RID: 94804 RVA: 0x00640D60 File Offset: 0x0063EF60
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int AllocateTempBuffStateList(IntPtr l)
	{
		int result;
		try
		{
			BattleBase battleBase = (BattleBase)LuaObject.checkSelf(l);
			List<BuffState> initValue;
			LuaObject.checkType<List<BuffState>>(l, 2, out initValue);
			List<BuffState> o = battleBase.AllocateTempBuffStateList(initValue);
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

	// Token: 0x06017255 RID: 94805 RVA: 0x00640DC4 File Offset: 0x0063EFC4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int FreeTempBuffStateList(IntPtr l)
	{
		int result;
		try
		{
			BattleBase battleBase = (BattleBase)LuaObject.checkSelf(l);
			List<BuffState> list;
			LuaObject.checkType<List<BuffState>>(l, 2, out list);
			battleBase.FreeTempBuffStateList(list);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06017256 RID: 94806 RVA: 0x00640E1C File Offset: 0x0063F01C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int RandomizeBuffStateList(IntPtr l)
	{
		int result;
		try
		{
			BattleBase battleBase = (BattleBase)LuaObject.checkSelf(l);
			List<BuffState> buffStateList;
			LuaObject.checkType<List<BuffState>>(l, 2, out buffStateList);
			battleBase.RandomizeBuffStateList(buffStateList);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06017257 RID: 94807 RVA: 0x00640E74 File Offset: 0x0063F074
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int GetTempBattlePropertyModifier(IntPtr l)
	{
		int result;
		try
		{
			BattleBase battleBase = (BattleBase)LuaObject.checkSelf(l);
			BattlePropertyModifier tempBattlePropertyModifier = battleBase.GetTempBattlePropertyModifier();
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, tempBattlePropertyModifier);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06017258 RID: 94808 RVA: 0x00640EC8 File Offset: 0x0063F0C8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int IsProbabilitySatisfied(IntPtr l)
	{
		int result;
		try
		{
			BattleBase battleBase = (BattleBase)LuaObject.checkSelf(l);
			int rate;
			LuaObject.checkType(l, 2, out rate);
			bool b = battleBase.IsProbabilitySatisfied(rate);
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

	// Token: 0x06017259 RID: 94809 RVA: 0x00640F2C File Offset: 0x0063F12C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int GetRandomBuffList(IntPtr l)
	{
		int result;
		try
		{
			BattleBase battleBase = (BattleBase)LuaObject.checkSelf(l);
			List<int> buffIds;
			LuaObject.checkType<List<int>>(l, 2, out buffIds);
			int num;
			LuaObject.checkType(l, 3, out num);
			List<ConfigDataBuffInfo> buffList;
			LuaObject.checkType<List<ConfigDataBuffInfo>>(l, 4, out buffList);
			battleBase.GetRandomBuffList(buffIds, num, buffList);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601725A RID: 94810 RVA: 0x00640FA0 File Offset: 0x0063F1A0
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int ComputeArmyRelationData(IntPtr l)
	{
		int result;
		try
		{
			BattleBase battleBase = (BattleBase)LuaObject.checkSelf(l);
			ConfigDataArmyInfo attackerArmyInfo;
			LuaObject.checkType<ConfigDataArmyInfo>(l, 2, out attackerArmyInfo);
			ConfigDataArmyInfo targetArmyInfo;
			LuaObject.checkType<ConfigDataArmyInfo>(l, 3, out targetArmyInfo);
			BattleActor attacker;
			LuaObject.checkType<BattleActor>(l, 4, out attacker);
			BattleActor target;
			LuaObject.checkType<BattleActor>(l, 5, out target);
			bool targetIsHero;
			LuaObject.checkType(l, 6, out targetIsHero);
			bool isMagic;
			LuaObject.checkType(l, 7, out isMagic);
			ArmyRelationData armyRelationData = battleBase.ComputeArmyRelationData(attackerArmyInfo, targetArmyInfo, attacker, target, targetIsHero, isMagic);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, armyRelationData);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601725B RID: 94811 RVA: 0x00641048 File Offset: 0x0063F248
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int FindPath(IntPtr l)
	{
		int result;
		try
		{
			BattleBase battleBase = (BattleBase)LuaObject.checkSelf(l);
			GridPosition start;
			LuaObject.checkValueType<GridPosition>(l, 2, out start);
			GridPosition goal;
			LuaObject.checkValueType<GridPosition>(l, 3, out goal);
			int movePoint;
			LuaObject.checkType(l, 4, out movePoint);
			MoveType moveType;
			LuaObject.checkEnum<MoveType>(l, 5, out moveType);
			int ignoreTeam;
			LuaObject.checkType(l, 6, out ignoreTeam);
			int overrideMovePointCost;
			LuaObject.checkType(l, 7, out overrideMovePointCost);
			int inRegion;
			LuaObject.checkType(l, 8, out inRegion);
			List<GridPosition> path;
			LuaObject.checkType<List<GridPosition>>(l, 9, out path);
			bool findNearestIfFail;
			LuaObject.checkType(l, 10, out findNearestIfFail);
			bool b = battleBase.FindPath(start, goal, movePoint, moveType, ignoreTeam, overrideMovePointCost, inRegion, path, findNearestIfFail);
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

	// Token: 0x0601725C RID: 94812 RVA: 0x00641110 File Offset: 0x0063F310
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int FindMoveRegion(IntPtr l)
	{
		int result;
		try
		{
			BattleBase battleBase = (BattleBase)LuaObject.checkSelf(l);
			GridPosition start;
			LuaObject.checkValueType<GridPosition>(l, 2, out start);
			int movePoint;
			LuaObject.checkType(l, 3, out movePoint);
			MoveType moveType;
			LuaObject.checkEnum<MoveType>(l, 4, out moveType);
			int ignoreTeam;
			LuaObject.checkType(l, 5, out ignoreTeam);
			int overrideMovePointCost;
			LuaObject.checkType(l, 6, out overrideMovePointCost);
			int inRegion;
			LuaObject.checkType(l, 7, out inRegion);
			List<GridPosition> region;
			LuaObject.checkType<List<GridPosition>>(l, 8, out region);
			battleBase.FindMoveRegion(start, movePoint, moveType, ignoreTeam, overrideMovePointCost, inRegion, region);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601725D RID: 94813 RVA: 0x006411B4 File Offset: 0x0063F3B4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int FindAttackRegion(IntPtr l)
	{
		int result;
		try
		{
			BattleBase battleBase = (BattleBase)LuaObject.checkSelf(l);
			GridPosition start;
			LuaObject.checkValueType<GridPosition>(l, 2, out start);
			int range;
			LuaObject.checkType(l, 3, out range);
			int shape;
			LuaObject.checkType(l, 4, out shape);
			List<GridPosition> region;
			LuaObject.checkType<List<GridPosition>>(l, 5, out region);
			battleBase.FindAttackRegion(start, range, shape, region);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601725E RID: 94814 RVA: 0x00641234 File Offset: 0x0063F434
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int FindFixedDistanceRegion(IntPtr l)
	{
		int result;
		try
		{
			BattleBase battleBase = (BattleBase)LuaObject.checkSelf(l);
			GridPosition start;
			LuaObject.checkValueType<GridPosition>(l, 2, out start);
			int distance;
			LuaObject.checkType(l, 3, out distance);
			List<GridPosition> region;
			LuaObject.checkType<List<GridPosition>>(l, 4, out region);
			battleBase.FindFixedDistanceRegion(start, distance, region);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601725F RID: 94815 RVA: 0x006412A8 File Offset: 0x0063F4A8
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int IsInDangerRegion(IntPtr l)
	{
		int result;
		try
		{
			BattleBase battleBase = (BattleBase)LuaObject.checkSelf(l);
			int team;
			LuaObject.checkType(l, 2, out team);
			GridPosition pos;
			LuaObject.checkValueType<GridPosition>(l, 3, out pos);
			bool b = battleBase.IsInDangerRegion(team, pos);
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

	// Token: 0x06017260 RID: 94816 RVA: 0x00641318 File Offset: 0x0063F518
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int GetStars(IntPtr l)
	{
		int result;
		try
		{
			BattleBase battleBase = (BattleBase)LuaObject.checkSelf(l);
			int stars = battleBase.GetStars();
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, stars);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06017261 RID: 94817 RVA: 0x0064136C File Offset: 0x0063F56C
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int IsWin(IntPtr l)
	{
		int result;
		try
		{
			BattleBase battleBase = (BattleBase)LuaObject.checkSelf(l);
			bool b = battleBase.IsWin();
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

	// Token: 0x06017262 RID: 94818 RVA: 0x006413C0 File Offset: 0x0063F5C0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int GetPlayerActors(IntPtr l)
	{
		int result;
		try
		{
			BattleBase battleBase = (BattleBase)LuaObject.checkSelf(l);
			int teamId;
			LuaObject.checkType(l, 2, out teamId);
			List<BattleActor> playerActors = battleBase.GetPlayerActors(teamId);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, playerActors);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06017263 RID: 94819 RVA: 0x00641424 File Offset: 0x0063F624
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int GetPlayerActorsLogInfos(IntPtr l)
	{
		int result;
		try
		{
			BattleBase battleBase = (BattleBase)LuaObject.checkSelf(l);
			int teamId;
			LuaObject.checkType(l, 2, out teamId);
			Dictionary<int, List<BattleActorLogInfo>> playerActorsLogInfos = battleBase.GetPlayerActorsLogInfos(teamId);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, playerActorsLogInfos);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06017264 RID: 94820 RVA: 0x00641488 File Offset: 0x0063F688
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int GetPlayerKillActorCount(IntPtr l)
	{
		int result;
		try
		{
			BattleBase battleBase = (BattleBase)LuaObject.checkSelf(l);
			int playerIndex;
			LuaObject.checkType(l, 2, out playerIndex);
			int playerKillActorCount = battleBase.GetPlayerKillActorCount(playerIndex);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, playerKillActorCount);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06017265 RID: 94821 RVA: 0x006414EC File Offset: 0x0063F6EC
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int GetDeadEnemyActors(IntPtr l)
	{
		int result;
		try
		{
			BattleBase battleBase = (BattleBase)LuaObject.checkSelf(l);
			List<BattleActor> deadEnemyActors = battleBase.GetDeadEnemyActors();
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, deadEnemyActors);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06017266 RID: 94822 RVA: 0x00641540 File Offset: 0x0063F740
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int EnableChecksum(IntPtr l)
	{
		int result;
		try
		{
			BattleBase battleBase = (BattleBase)LuaObject.checkSelf(l);
			bool enable;
			LuaObject.checkType(l, 2, out enable);
			battleBase.EnableChecksum(enable);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06017267 RID: 94823 RVA: 0x00641598 File Offset: 0x0063F798
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int GetChecksums(IntPtr l)
	{
		int result;
		try
		{
			BattleBase battleBase = (BattleBase)LuaObject.checkSelf(l);
			List<int> checksums = battleBase.GetChecksums();
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, checksums);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06017268 RID: 94824 RVA: 0x006415EC File Offset: 0x0063F7EC
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int EnableDebugLog(IntPtr l)
	{
		int result;
		try
		{
			BattleBase battleBase = (BattleBase)LuaObject.checkSelf(l);
			bool enable;
			LuaObject.checkType(l, 2, out enable);
			battleBase.EnableDebugLog(enable);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06017269 RID: 94825 RVA: 0x00641644 File Offset: 0x0063F844
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int IsEnableDebugLog(IntPtr l)
	{
		int result;
		try
		{
			BattleBase battleBase = (BattleBase)LuaObject.checkSelf(l);
			bool b = battleBase.IsEnableDebugLog();
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

	// Token: 0x0601726A RID: 94826 RVA: 0x00641698 File Offset: 0x0063F898
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int IsAchievementComplete(IntPtr l)
	{
		int result;
		try
		{
			BattleBase battleBase = (BattleBase)LuaObject.checkSelf(l);
			int achievementReleatedId;
			LuaObject.checkType(l, 2, out achievementReleatedId);
			bool b = battleBase.IsAchievementComplete(achievementReleatedId);
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

	// Token: 0x0601726B RID: 94827 RVA: 0x006416FC File Offset: 0x0063F8FC
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int GetCompleteAchievements(IntPtr l)
	{
		int result;
		try
		{
			BattleBase battleBase = (BattleBase)LuaObject.checkSelf(l);
			List<int> completeAchievements = battleBase.GetCompleteAchievements();
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, completeAchievements);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601726C RID: 94828 RVA: 0x00641750 File Offset: 0x0063F950
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int GetAchievementStatus(IntPtr l)
	{
		int result;
		try
		{
			BattleBase battleBase = (BattleBase)LuaObject.checkSelf(l);
			int achievementReleatedId;
			LuaObject.checkType(l, 2, out achievementReleatedId);
			BattleConditionStatus achievementStatus = battleBase.GetAchievementStatus(achievementReleatedId);
			LuaObject.pushValue(l, true);
			LuaObject.pushEnum(l, (int)achievementStatus);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601726D RID: 94829 RVA: 0x006417B4 File Offset: 0x0063F9B4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int AddBattleCommand(IntPtr l)
	{
		int result;
		try
		{
			BattleBase battleBase = (BattleBase)LuaObject.checkSelf(l);
			BattleCommand cmd;
			LuaObject.checkType<BattleCommand>(l, 2, out cmd);
			battleBase.AddBattleCommand(cmd);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601726E RID: 94830 RVA: 0x0064180C File Offset: 0x0063FA0C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int AddGiveupLogBattleCommand(IntPtr l)
	{
		int result;
		try
		{
			BattleBase battleBase = (BattleBase)LuaObject.checkSelf(l);
			int playerIndex;
			LuaObject.checkType(l, 2, out playerIndex);
			battleBase.AddGiveupLogBattleCommand(playerIndex);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601726F RID: 94831 RVA: 0x00641864 File Offset: 0x0063FA64
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int AddCancelLogBattleCommand(IntPtr l)
	{
		int result;
		try
		{
			BattleBase battleBase = (BattleBase)LuaObject.checkSelf(l);
			int playerIndex;
			LuaObject.checkType(l, 2, out playerIndex);
			battleBase.AddCancelLogBattleCommand(playerIndex);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06017270 RID: 94832 RVA: 0x006418BC File Offset: 0x0063FABC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int ClearBattleCommandsAndNextStep(IntPtr l)
	{
		int result;
		try
		{
			BattleBase battleBase = (BattleBase)LuaObject.checkSelf(l);
			battleBase.ClearBattleCommandsAndNextStep();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06017271 RID: 94833 RVA: 0x00641908 File Offset: 0x0063FB08
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int HasBattleCommand(IntPtr l)
	{
		int result;
		try
		{
			BattleBase battleBase = (BattleBase)LuaObject.checkSelf(l);
			bool b = battleBase.HasBattleCommand();
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

	// Token: 0x06017272 RID: 94834 RVA: 0x0064195C File Offset: 0x0063FB5C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int HasCurrentStepBattleCommand(IntPtr l)
	{
		int result;
		try
		{
			BattleBase battleBase = (BattleBase)LuaObject.checkSelf(l);
			bool b = battleBase.HasCurrentStepBattleCommand();
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

	// Token: 0x06017273 RID: 94835 RVA: 0x006419B0 File Offset: 0x0063FBB0
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int ExecuteBattleCommand(IntPtr l)
	{
		int result;
		try
		{
			BattleBase battleBase = (BattleBase)LuaObject.checkSelf(l);
			bool b = battleBase.ExecuteBattleCommand();
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

	// Token: 0x06017274 RID: 94836 RVA: 0x00641A04 File Offset: 0x0063FC04
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int Run(IntPtr l)
	{
		int result;
		try
		{
			BattleBase battleBase = (BattleBase)LuaObject.checkSelf(l);
			bool strictCheckCommand;
			LuaObject.checkType(l, 2, out strictCheckCommand);
			bool b = battleBase.Run(strictCheckCommand);
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

	// Token: 0x06017275 RID: 94837 RVA: 0x00641A68 File Offset: 0x0063FC68
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int RunAIActors(IntPtr l)
	{
		int result;
		try
		{
			BattleBase battleBase = (BattleBase)LuaObject.checkSelf(l);
			bool b = battleBase.RunAIActors();
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

	// Token: 0x06017276 RID: 94838 RVA: 0x00641ABC File Offset: 0x0063FCBC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int RunPlayerBattleCommands(IntPtr l)
	{
		int result;
		try
		{
			BattleBase battleBase = (BattleBase)LuaObject.checkSelf(l);
			int playerIndex;
			LuaObject.checkType(l, 2, out playerIndex);
			List<BattleCommand> commands;
			LuaObject.checkType<List<BattleCommand>>(l, 3, out commands);
			bool b = battleBase.RunPlayerBattleCommands(playerIndex, commands);
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

	// Token: 0x06017277 RID: 94839 RVA: 0x00641B2C File Offset: 0x0063FD2C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int FixExecutedCommands(IntPtr l)
	{
		int result;
		try
		{
			BattleBase battleBase = (BattleBase)LuaObject.checkSelf(l);
			BattleActor actor;
			LuaObject.checkType<BattleActor>(l, 2, out actor);
			int step;
			LuaObject.checkType(l, 3, out step);
			battleBase.FixExecutedCommands(actor, step);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06017278 RID: 94840 RVA: 0x00641B90 File Offset: 0x0063FD90
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int GetStepExecutedCommands(IntPtr l)
	{
		int result;
		try
		{
			BattleBase battleBase = (BattleBase)LuaObject.checkSelf(l);
			List<BattleCommand> stepExecutedCommands = battleBase.GetStepExecutedCommands();
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, stepExecutedCommands);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06017279 RID: 94841 RVA: 0x00641BE4 File Offset: 0x0063FDE4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int EnableLogBattleCommands(IntPtr l)
	{
		int result;
		try
		{
			BattleBase battleBase = (BattleBase)LuaObject.checkSelf(l);
			bool enable;
			LuaObject.checkType(l, 2, out enable);
			battleBase.EnableLogBattleCommands(enable);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601727A RID: 94842 RVA: 0x00641C3C File Offset: 0x0063FE3C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int IsEnableLogBattleCommands(IntPtr l)
	{
		int result;
		try
		{
			BattleBase battleBase = (BattleBase)LuaObject.checkSelf(l);
			bool b = battleBase.IsEnableLogBattleCommands();
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

	// Token: 0x0601727B RID: 94843 RVA: 0x00641C90 File Offset: 0x0063FE90
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int GetLogBattleCommands(IntPtr l)
	{
		int result;
		try
		{
			BattleBase battleBase = (BattleBase)LuaObject.checkSelf(l);
			LinkedList<BattleCommand> logBattleCommands = battleBase.GetLogBattleCommands();
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, logBattleCommands);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601727C RID: 94844 RVA: 0x00641CE4 File Offset: 0x0063FEE4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int EnableTempBattleCommands(IntPtr l)
	{
		int result;
		try
		{
			BattleBase battleBase = (BattleBase)LuaObject.checkSelf(l);
			bool enable;
			LuaObject.checkType(l, 2, out enable);
			battleBase.EnableTempBattleCommands(enable);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601727D RID: 94845 RVA: 0x00641D3C File Offset: 0x0063FF3C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int IsEnableTempBattleCommands(IntPtr l)
	{
		int result;
		try
		{
			BattleBase battleBase = (BattleBase)LuaObject.checkSelf(l);
			bool b = battleBase.IsEnableTempBattleCommands();
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

	// Token: 0x0601727E RID: 94846 RVA: 0x00641D90 File Offset: 0x0063FF90
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int GetTempBattleCommands(IntPtr l)
	{
		int result;
		try
		{
			BattleBase battleBase = (BattleBase)LuaObject.checkSelf(l);
			LinkedList<BattleCommand> tempBattleCommands = battleBase.GetTempBattleCommands();
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, tempBattleCommands);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601727F RID: 94847 RVA: 0x00641DE4 File Offset: 0x0063FFE4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int ClearTempBattleCommands(IntPtr l)
	{
		int result;
		try
		{
			BattleBase battleBase = (BattleBase)LuaObject.checkSelf(l);
			battleBase.ClearTempBattleCommands();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06017280 RID: 94848 RVA: 0x00641E30 File Offset: 0x00640030
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int StartCombat(IntPtr l)
	{
		int result;
		try
		{
			BattleBase battleBase = (BattleBase)LuaObject.checkSelf(l);
			BattleActor actorA;
			LuaObject.checkType<BattleActor>(l, 2, out actorA);
			BattleActor actorB;
			LuaObject.checkType<BattleActor>(l, 3, out actorB);
			ConfigDataSkillInfo skillInfoA;
			LuaObject.checkType<ConfigDataSkillInfo>(l, 4, out skillInfoA);
			battleBase.StartCombat(actorA, actorB, skillInfoA);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06017281 RID: 94849 RVA: 0x00641EA4 File Offset: 0x006400A4
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int RestartCombat(IntPtr l)
	{
		int result;
		try
		{
			BattleBase battleBase = (BattleBase)LuaObject.checkSelf(l);
			battleBase.RestartCombat();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06017282 RID: 94850 RVA: 0x00641EF0 File Offset: 0x006400F0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int CheckEventTriggerOnActorUseSkill(IntPtr l)
	{
		int result;
		try
		{
			BattleBase battleBase = (BattleBase)LuaObject.checkSelf(l);
			BattleActor a;
			LuaObject.checkType<BattleActor>(l, 2, out a);
			battleBase.CheckEventTriggerOnActorUseSkill(a);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06017283 RID: 94851 RVA: 0x00641F48 File Offset: 0x00640148
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int CreateMap(IntPtr l)
	{
		int result;
		try
		{
			BattleBase battleBase = (BattleBase)LuaObject.checkSelf(l);
			ConfigDataBattlefieldInfo battlefieldInfo;
			LuaObject.checkType<ConfigDataBattlefieldInfo>(l, 2, out battlefieldInfo);
			bool b = battleBase.CreateMap(battlefieldInfo);
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

	// Token: 0x06017284 RID: 94852 RVA: 0x00641FAC File Offset: 0x006401AC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int ResetMap(IntPtr l)
	{
		int result;
		try
		{
			BattleBase battleBase = (BattleBase)LuaObject.checkSelf(l);
			battleBase.ResetMap();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06017285 RID: 94853 RVA: 0x00641FF8 File Offset: 0x006401F8
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int SetMyPlayerTeamNumber(IntPtr l)
	{
		int result;
		try
		{
			BattleBase battleBase = (BattleBase)LuaObject.checkSelf(l);
			int myPlayerTeamNumber;
			LuaObject.checkType(l, 2, out myPlayerTeamNumber);
			battleBase.SetMyPlayerTeamNumber(myPlayerTeamNumber);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06017286 RID: 94854 RVA: 0x00642050 File Offset: 0x00640250
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int GetMyPlayerTeamNumber(IntPtr l)
	{
		int result;
		try
		{
			BattleBase battleBase = (BattleBase)LuaObject.checkSelf(l);
			int myPlayerTeamNumber = battleBase.GetMyPlayerTeamNumber();
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, myPlayerTeamNumber);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06017287 RID: 94855 RVA: 0x006420A4 File Offset: 0x006402A4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int InitBattle(IntPtr l)
	{
		int result;
		try
		{
			BattleBase battleBase = (BattleBase)LuaObject.checkSelf(l);
			ConfigDataBattleInfo battleInfo;
			LuaObject.checkType<ConfigDataBattleInfo>(l, 2, out battleInfo);
			BattleType battleType;
			LuaObject.checkEnum<BattleType>(l, 3, out battleType);
			BattleTeamSetup teamSetup;
			LuaObject.checkType<BattleTeamSetup>(l, 4, out teamSetup);
			BattleTeamSetup teamSetup2;
			LuaObject.checkType<BattleTeamSetup>(l, 5, out teamSetup2);
			BattlePlayer[] players;
			LuaObject.checkArray<BattlePlayer>(l, 6, out players);
			int randomSeed;
			LuaObject.checkType(l, 7, out randomSeed);
			int armyRandomSeed;
			LuaObject.checkType(l, 8, out armyRandomSeed);
			int monsterLevel;
			LuaObject.checkType(l, 9, out monsterLevel);
			bool b = battleBase.InitBattle(battleInfo, battleType, teamSetup, teamSetup2, players, randomSeed, armyRandomSeed, monsterLevel);
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

	// Token: 0x06017288 RID: 94856 RVA: 0x00642160 File Offset: 0x00640360
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int InitArenaBattle(IntPtr l)
	{
		int result;
		try
		{
			BattleBase battleBase = (BattleBase)LuaObject.checkSelf(l);
			ConfigDataArenaBattleInfo battleInfo;
			LuaObject.checkType<ConfigDataArenaBattleInfo>(l, 2, out battleInfo);
			BattleTeamSetup teamSetup;
			LuaObject.checkType<BattleTeamSetup>(l, 3, out teamSetup);
			BattleTeamSetup teamSetup2;
			LuaObject.checkType<BattleTeamSetup>(l, 4, out teamSetup2);
			BattlePlayer[] players;
			LuaObject.checkArray<BattlePlayer>(l, 5, out players);
			int randomSeed;
			LuaObject.checkType(l, 6, out randomSeed);
			ConfigDataArenaDefendRuleInfo arenaDefendRuleInfo;
			LuaObject.checkType<ConfigDataArenaDefendRuleInfo>(l, 7, out arenaDefendRuleInfo);
			bool b = battleBase.InitArenaBattle(battleInfo, teamSetup, teamSetup2, players, randomSeed, arenaDefendRuleInfo);
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

	// Token: 0x06017289 RID: 94857 RVA: 0x00642200 File Offset: 0x00640400
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int InitPVPBattle(IntPtr l)
	{
		int result;
		try
		{
			BattleBase battleBase = (BattleBase)LuaObject.checkSelf(l);
			ConfigDataPVPBattleInfo battleInfo;
			LuaObject.checkType<ConfigDataPVPBattleInfo>(l, 2, out battleInfo);
			BattleTeamSetup teamSetup;
			LuaObject.checkType<BattleTeamSetup>(l, 3, out teamSetup);
			BattleTeamSetup teamSetup2;
			LuaObject.checkType<BattleTeamSetup>(l, 4, out teamSetup2);
			BattlePlayer[] players;
			LuaObject.checkArray<BattlePlayer>(l, 5, out players);
			int randomSeed;
			LuaObject.checkType(l, 6, out randomSeed);
			bool b = battleBase.InitPVPBattle(battleInfo, teamSetup, teamSetup2, players, randomSeed);
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

	// Token: 0x0601728A RID: 94858 RVA: 0x00642294 File Offset: 0x00640494
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int InitRealTimePVPBattle(IntPtr l)
	{
		int result;
		try
		{
			BattleBase battleBase = (BattleBase)LuaObject.checkSelf(l);
			ConfigDataRealTimePVPBattleInfo battleInfo;
			LuaObject.checkType<ConfigDataRealTimePVPBattleInfo>(l, 2, out battleInfo);
			BattleTeamSetup teamSetup;
			LuaObject.checkType<BattleTeamSetup>(l, 3, out teamSetup);
			BattleTeamSetup teamSetup2;
			LuaObject.checkType<BattleTeamSetup>(l, 4, out teamSetup2);
			BattlePlayer[] players;
			LuaObject.checkArray<BattlePlayer>(l, 5, out players);
			int randomSeed;
			LuaObject.checkType(l, 6, out randomSeed);
			bool b = battleBase.InitRealTimePVPBattle(battleInfo, teamSetup, teamSetup2, players, randomSeed);
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

	// Token: 0x0601728B RID: 94859 RVA: 0x00642328 File Offset: 0x00640528
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int InitBattleReport(IntPtr l)
	{
		int result;
		try
		{
			BattleBase battleBase = (BattleBase)LuaObject.checkSelf(l);
			ConfigDataBattleInfo battleInfo;
			LuaObject.checkType<ConfigDataBattleInfo>(l, 2, out battleInfo);
			BattleType battleType;
			LuaObject.checkEnum<BattleType>(l, 3, out battleType);
			BattleTeamSetup teamSetup;
			LuaObject.checkType<BattleTeamSetup>(l, 4, out teamSetup);
			BattleTeamSetup teamSetup2;
			LuaObject.checkType<BattleTeamSetup>(l, 5, out teamSetup2);
			BattlePlayer[] players;
			LuaObject.checkArray<BattlePlayer>(l, 6, out players);
			int randomSeed;
			LuaObject.checkType(l, 7, out randomSeed);
			int armyRandomSeed;
			LuaObject.checkType(l, 8, out armyRandomSeed);
			int monsterLevel;
			LuaObject.checkType(l, 9, out monsterLevel);
			List<BattleCommand> commands;
			LuaObject.checkType<List<BattleCommand>>(l, 10, out commands);
			bool b = battleBase.InitBattleReport(battleInfo, battleType, teamSetup, teamSetup2, players, randomSeed, armyRandomSeed, monsterLevel, commands);
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

	// Token: 0x0601728C RID: 94860 RVA: 0x006423F0 File Offset: 0x006405F0
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int InitArenaBattleReport(IntPtr l)
	{
		int result;
		try
		{
			BattleBase battleBase = (BattleBase)LuaObject.checkSelf(l);
			ConfigDataArenaBattleInfo battleInfo;
			LuaObject.checkType<ConfigDataArenaBattleInfo>(l, 2, out battleInfo);
			BattleTeamSetup teamSetup;
			LuaObject.checkType<BattleTeamSetup>(l, 3, out teamSetup);
			BattleTeamSetup teamSetup2;
			LuaObject.checkType<BattleTeamSetup>(l, 4, out teamSetup2);
			BattlePlayer[] players;
			LuaObject.checkArray<BattlePlayer>(l, 5, out players);
			int randomSeed;
			LuaObject.checkType(l, 6, out randomSeed);
			ConfigDataArenaDefendRuleInfo arenaDefendRuleInfo;
			LuaObject.checkType<ConfigDataArenaDefendRuleInfo>(l, 7, out arenaDefendRuleInfo);
			List<BattleCommand> commands;
			LuaObject.checkType<List<BattleCommand>>(l, 8, out commands);
			bool b = battleBase.InitArenaBattleReport(battleInfo, teamSetup, teamSetup2, players, randomSeed, arenaDefendRuleInfo, commands);
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

	// Token: 0x0601728D RID: 94861 RVA: 0x0064249C File Offset: 0x0064069C
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int InitPVPBattleReport(IntPtr l)
	{
		int result;
		try
		{
			BattleBase battleBase = (BattleBase)LuaObject.checkSelf(l);
			ConfigDataPVPBattleInfo battleInfo;
			LuaObject.checkType<ConfigDataPVPBattleInfo>(l, 2, out battleInfo);
			BattleTeamSetup teamSetup;
			LuaObject.checkType<BattleTeamSetup>(l, 3, out teamSetup);
			BattleTeamSetup teamSetup2;
			LuaObject.checkType<BattleTeamSetup>(l, 4, out teamSetup2);
			BattlePlayer[] players;
			LuaObject.checkArray<BattlePlayer>(l, 5, out players);
			int randomSeed;
			LuaObject.checkType(l, 6, out randomSeed);
			List<BattleCommand> commands;
			LuaObject.checkType<List<BattleCommand>>(l, 7, out commands);
			bool b = battleBase.InitPVPBattleReport(battleInfo, teamSetup, teamSetup2, players, randomSeed, commands);
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

	// Token: 0x0601728E RID: 94862 RVA: 0x0064253C File Offset: 0x0064073C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int InitRealTimePVPBattleReport(IntPtr l)
	{
		int result;
		try
		{
			BattleBase battleBase = (BattleBase)LuaObject.checkSelf(l);
			ConfigDataRealTimePVPBattleInfo battleInfo;
			LuaObject.checkType<ConfigDataRealTimePVPBattleInfo>(l, 2, out battleInfo);
			BattleTeamSetup teamSetup;
			LuaObject.checkType<BattleTeamSetup>(l, 3, out teamSetup);
			BattleTeamSetup teamSetup2;
			LuaObject.checkType<BattleTeamSetup>(l, 4, out teamSetup2);
			BattlePlayer[] players;
			LuaObject.checkArray<BattlePlayer>(l, 5, out players);
			int randomSeed;
			LuaObject.checkType(l, 6, out randomSeed);
			List<BattleCommand> commands;
			LuaObject.checkType<List<BattleCommand>>(l, 7, out commands);
			bool b = battleBase.InitRealTimePVPBattleReport(battleInfo, teamSetup, teamSetup2, players, randomSeed, commands);
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

	// Token: 0x0601728F RID: 94863 RVA: 0x006425DC File Offset: 0x006407DC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int InitStarAndAchievement(IntPtr l)
	{
		int result;
		try
		{
			BattleBase battleBase = (BattleBase)LuaObject.checkSelf(l);
			int starTurnMax;
			LuaObject.checkType(l, 2, out starTurnMax);
			int starDeadMax;
			LuaObject.checkType(l, 3, out starDeadMax);
			List<ConfigDataBattleAchievementRelatedInfo> achievementRelatedInfos;
			LuaObject.checkType<List<ConfigDataBattleAchievementRelatedInfo>>(l, 4, out achievementRelatedInfos);
			battleBase.InitStarAndAchievement(starTurnMax, starDeadMax, achievementRelatedInfos);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06017290 RID: 94864 RVA: 0x00642650 File Offset: 0x00640850
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int InitGainBattleTreasures(IntPtr l)
	{
		int result;
		try
		{
			BattleBase battleBase = (BattleBase)LuaObject.checkSelf(l);
			List<int> gainBattleTreasureIds;
			LuaObject.checkType<List<int>>(l, 2, out gainBattleTreasureIds);
			battleBase.InitGainBattleTreasures(gainBattleTreasureIds);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06017291 RID: 94865 RVA: 0x006426A8 File Offset: 0x006408A8
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int IsGainBattleTreasure(IntPtr l)
	{
		int result;
		try
		{
			BattleBase battleBase = (BattleBase)LuaObject.checkSelf(l);
			int treasureId;
			LuaObject.checkType(l, 2, out treasureId);
			bool b = battleBase.IsGainBattleTreasure(treasureId);
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

	// Token: 0x06017292 RID: 94866 RVA: 0x0064270C File Offset: 0x0064090C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int GetGainBattleTreasures(IntPtr l)
	{
		int result;
		try
		{
			BattleBase battleBase = (BattleBase)LuaObject.checkSelf(l);
			List<int> gainBattleTreasures = battleBase.GetGainBattleTreasures();
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, gainBattleTreasures);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06017293 RID: 94867 RVA: 0x00642760 File Offset: 0x00640960
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int IsInRegion_s(IntPtr l)
	{
		int result;
		try
		{
			GridPosition start;
			LuaObject.checkValueType<GridPosition>(l, 1, out start);
			GridPosition target;
			LuaObject.checkValueType<GridPosition>(l, 2, out target);
			int range;
			LuaObject.checkType(l, 3, out range);
			int shape;
			LuaObject.checkType(l, 4, out shape);
			bool b = BattleBase.IsInRegion(start, target, range, shape);
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

	// Token: 0x06017294 RID: 94868 RVA: 0x006427DC File Offset: 0x006409DC
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int Stop(IntPtr l)
	{
		int result;
		try
		{
			BattleBase battleBase = (BattleBase)LuaObject.checkSelf(l);
			bool win;
			LuaObject.checkType(l, 2, out win);
			battleBase.m_luaExportHelper.Stop(win);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06017295 RID: 94869 RVA: 0x00642838 File Offset: 0x00640A38
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int NextStep(IntPtr l)
	{
		int result;
		try
		{
			BattleBase battleBase = (BattleBase)LuaObject.checkSelf(l);
			battleBase.m_luaExportHelper.NextStep();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06017296 RID: 94870 RVA: 0x0064288C File Offset: 0x00640A8C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int NextStep_Normal(IntPtr l)
	{
		int result;
		try
		{
			BattleBase battleBase = (BattleBase)LuaObject.checkSelf(l);
			BattleActor actionActor;
			LuaObject.checkType<BattleActor>(l, 2, out actionActor);
			battleBase.m_luaExportHelper.NextStep_Normal(actionActor);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06017297 RID: 94871 RVA: 0x006428E8 File Offset: 0x00640AE8
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int NextStep_Pvp(IntPtr l)
	{
		int result;
		try
		{
			BattleBase battleBase = (BattleBase)LuaObject.checkSelf(l);
			BattleActor actionActor;
			LuaObject.checkType<BattleActor>(l, 2, out actionActor);
			battleBase.m_luaExportHelper.NextStep_Pvp(actionActor);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06017298 RID: 94872 RVA: 0x00642944 File Offset: 0x00640B44
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int NextStepActorActive(IntPtr l)
	{
		int result;
		try
		{
			BattleBase battleBase = (BattleBase)LuaObject.checkSelf(l);
			battleBase.m_luaExportHelper.NextStepActorActive();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06017299 RID: 94873 RVA: 0x00642998 File Offset: 0x00640B98
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int NextTurn(IntPtr l)
	{
		int result;
		try
		{
			BattleBase battleBase = (BattleBase)LuaObject.checkSelf(l);
			battleBase.m_luaExportHelper.NextTurn();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601729A RID: 94874 RVA: 0x006429EC File Offset: 0x00640BEC
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int GetDefaultActionActor(IntPtr l)
	{
		int result;
		try
		{
			BattleBase battleBase = (BattleBase)LuaObject.checkSelf(l);
			int team;
			LuaObject.checkType(l, 2, out team);
			BattleActor defaultActionActor = battleBase.m_luaExportHelper.GetDefaultActionActor(team);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, defaultActionActor);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601729B RID: 94875 RVA: 0x00642A54 File Offset: 0x00640C54
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int HasNotActionFinishedActor(IntPtr l)
	{
		int result;
		try
		{
			BattleBase battleBase = (BattleBase)LuaObject.checkSelf(l);
			bool b = battleBase.m_luaExportHelper.HasNotActionFinishedActor();
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

	// Token: 0x0601729C RID: 94876 RVA: 0x00642AB0 File Offset: 0x00640CB0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int GetAliveActorByHeroId(IntPtr l)
	{
		int result;
		try
		{
			BattleBase battleBase = (BattleBase)LuaObject.checkSelf(l);
			int heroId;
			LuaObject.checkType(l, 2, out heroId);
			BattleActor aliveActorByHeroId = battleBase.m_luaExportHelper.GetAliveActorByHeroId(heroId);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, aliveActorByHeroId);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601729D RID: 94877 RVA: 0x00642B18 File Offset: 0x00640D18
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int GetAliveActorsByHeroIdsAndGroupIds(IntPtr l)
	{
		int result;
		try
		{
			BattleBase battleBase = (BattleBase)LuaObject.checkSelf(l);
			List<int> heroIds;
			LuaObject.checkType<List<int>>(l, 2, out heroIds);
			List<int> groupIds;
			LuaObject.checkType<List<int>>(l, 3, out groupIds);
			List<BattleActor> actors;
			LuaObject.checkType<List<BattleActor>>(l, 4, out actors);
			battleBase.m_luaExportHelper.GetAliveActorsByHeroIdsAndGroupIds(heroIds, groupIds, actors);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601729E RID: 94878 RVA: 0x00642B90 File Offset: 0x00640D90
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int ComputeStepChecksum(IntPtr l)
	{
		int result;
		try
		{
			BattleBase battleBase = (BattleBase)LuaObject.checkSelf(l);
			battleBase.m_luaExportHelper.ComputeStepChecksum();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601729F RID: 94879 RVA: 0x00642BE4 File Offset: 0x00640DE4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int CheckAchievementOnActorMove(IntPtr l)
	{
		int result;
		try
		{
			BattleBase battleBase = (BattleBase)LuaObject.checkSelf(l);
			BattleActor actor;
			LuaObject.checkType<BattleActor>(l, 2, out actor);
			battleBase.m_luaExportHelper.CheckAchievementOnActorMove(actor);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060172A0 RID: 94880 RVA: 0x00642C40 File Offset: 0x00640E40
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int CheckAchievementOnActorDie(IntPtr l)
	{
		int result;
		try
		{
			BattleBase battleBase = (BattleBase)LuaObject.checkSelf(l);
			BattleActor actor;
			LuaObject.checkType<BattleActor>(l, 2, out actor);
			battleBase.m_luaExportHelper.CheckAchievementOnActorDie(actor);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060172A1 RID: 94881 RVA: 0x00642C9C File Offset: 0x00640E9C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int CheckAchievementOnNextStep(IntPtr l)
	{
		int result;
		try
		{
			BattleBase battleBase = (BattleBase)LuaObject.checkSelf(l);
			battleBase.m_luaExportHelper.CheckAchievementOnNextStep();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060172A2 RID: 94882 RVA: 0x00642CF0 File Offset: 0x00640EF0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int CheckAchievementOnTurnEndOrWin(IntPtr l)
	{
		int result;
		try
		{
			BattleBase battleBase = (BattleBase)LuaObject.checkSelf(l);
			bool isWin;
			LuaObject.checkType(l, 2, out isWin);
			battleBase.m_luaExportHelper.CheckAchievementOnTurnEndOrWin(isWin);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060172A3 RID: 94883 RVA: 0x00642D4C File Offset: 0x00640F4C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int CheckAchievementOnWin(IntPtr l)
	{
		int result;
		try
		{
			BattleBase battleBase = (BattleBase)LuaObject.checkSelf(l);
			battleBase.m_luaExportHelper.CheckAchievementOnWin();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060172A4 RID: 94884 RVA: 0x00642DA0 File Offset: 0x00640FA0
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int CheckAchievementOnLose(IntPtr l)
	{
		int result;
		try
		{
			BattleBase battleBase = (BattleBase)LuaObject.checkSelf(l);
			battleBase.m_luaExportHelper.CheckAchievementOnLose();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060172A5 RID: 94885 RVA: 0x00642DF4 File Offset: 0x00640FF4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int ChangeAchievementStatus(IntPtr l)
	{
		int result;
		try
		{
			BattleBase battleBase = (BattleBase)LuaObject.checkSelf(l);
			BattleAchievementState bs;
			LuaObject.checkType<BattleAchievementState>(l, 2, out bs);
			bool success;
			LuaObject.checkType(l, 3, out success);
			battleBase.m_luaExportHelper.ChangeAchievementStatus(bs, success);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060172A6 RID: 94886 RVA: 0x00642E60 File Offset: 0x00641060
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int IsActorsAllAlive(IntPtr l)
	{
		int result;
		try
		{
			BattleBase battleBase = (BattleBase)LuaObject.checkSelf(l);
			List<int> heroIds;
			LuaObject.checkType<List<int>>(l, 2, out heroIds);
			bool b = battleBase.m_luaExportHelper.IsActorsAllAlive(heroIds);
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

	// Token: 0x060172A7 RID: 94887 RVA: 0x00642EC8 File Offset: 0x006410C8
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int IsActorsAllKillBySkillClass(IntPtr l)
	{
		int result;
		try
		{
			BattleBase battleBase = (BattleBase)LuaObject.checkSelf(l);
			List<int> heroIds;
			LuaObject.checkType<List<int>>(l, 2, out heroIds);
			int skillClass;
			LuaObject.checkType(l, 3, out skillClass);
			bool b = battleBase.m_luaExportHelper.IsActorsAllKillBySkillClass(heroIds, skillClass);
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

	// Token: 0x060172A8 RID: 94888 RVA: 0x00642F3C File Offset: 0x0064113C
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int IsActorReachPositions(IntPtr l)
	{
		int result;
		try
		{
			int num = LuaDLL.lua_gettop(l);
			if (num == 4)
			{
				BattleBase battleBase = (BattleBase)LuaObject.checkSelf(l);
				BattleActor a;
				LuaObject.checkType<BattleActor>(l, 2, out a);
				List<ParamPosition> positions;
				LuaObject.checkType<List<ParamPosition>>(l, 3, out positions);
				int conditionId;
				LuaObject.checkType(l, 4, out conditionId);
				bool b = battleBase.m_luaExportHelper.IsActorReachPositions(a, positions, conditionId);
				LuaObject.pushValue(l, true);
				LuaObject.pushValue(l, b);
				result = 2;
			}
			else if (num == 5)
			{
				BattleBase battleBase2 = (BattleBase)LuaObject.checkSelf(l);
				BattleActor a2;
				LuaObject.checkType<BattleActor>(l, 2, out a2);
				NpcCondition npcCondition;
				LuaObject.checkEnum<NpcCondition>(l, 3, out npcCondition);
				List<ParamPosition> positions2;
				LuaObject.checkType<List<ParamPosition>>(l, 4, out positions2);
				int conditionId2;
				LuaObject.checkType(l, 5, out conditionId2);
				bool b2 = battleBase2.m_luaExportHelper.IsActorReachPositions(a2, npcCondition, positions2, conditionId2);
				LuaObject.pushValue(l, true);
				LuaObject.pushValue(l, b2);
				result = 2;
			}
			else
			{
				LuaObject.pushValue(l, false);
				LuaDLL.lua_pushstring(l, "No matched override function IsActorReachPositions to call");
				result = 2;
			}
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060172A9 RID: 94889 RVA: 0x00643050 File Offset: 0x00641250
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int IsActorsAnyReachPositions(IntPtr l)
	{
		int result;
		try
		{
			int num = LuaDLL.lua_gettop(l);
			if (num == 4)
			{
				BattleBase battleBase = (BattleBase)LuaObject.checkSelf(l);
				List<int> heroIds;
				LuaObject.checkType<List<int>>(l, 2, out heroIds);
				List<ParamPosition> positions;
				LuaObject.checkType<List<ParamPosition>>(l, 3, out positions);
				int conditionId;
				LuaObject.checkType(l, 4, out conditionId);
				bool b = battleBase.m_luaExportHelper.IsActorsAnyReachPositions(heroIds, positions, conditionId);
				LuaObject.pushValue(l, true);
				LuaObject.pushValue(l, b);
				result = 2;
			}
			else if (num == 5)
			{
				BattleBase battleBase2 = (BattleBase)LuaObject.checkSelf(l);
				int team;
				LuaObject.checkType(l, 2, out team);
				NpcCondition npcCondition;
				LuaObject.checkEnum<NpcCondition>(l, 3, out npcCondition);
				List<ParamPosition> positions2;
				LuaObject.checkType<List<ParamPosition>>(l, 4, out positions2);
				int conditionId2;
				LuaObject.checkType(l, 5, out conditionId2);
				bool b2 = battleBase2.m_luaExportHelper.IsActorsAnyReachPositions(team, npcCondition, positions2, conditionId2);
				LuaObject.pushValue(l, true);
				LuaObject.pushValue(l, b2);
				result = 2;
			}
			else
			{
				LuaObject.pushValue(l, false);
				LuaDLL.lua_pushstring(l, "No matched override function IsActorsAnyReachPositions to call");
				result = 2;
			}
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060172AA RID: 94890 RVA: 0x00643164 File Offset: 0x00641364
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int GetActorsCountSatisfyCondition(IntPtr l)
	{
		int result;
		try
		{
			BattleBase battleBase = (BattleBase)LuaObject.checkSelf(l);
			int team;
			LuaObject.checkType(l, 2, out team);
			NpcCondition npcCondition;
			LuaObject.checkEnum<NpcCondition>(l, 3, out npcCondition);
			int conditionId;
			LuaObject.checkType(l, 4, out conditionId);
			int actorsCountSatisfyCondition = battleBase.m_luaExportHelper.GetActorsCountSatisfyCondition(team, npcCondition, conditionId);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, actorsCountSatisfyCondition);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060172AB RID: 94891 RVA: 0x006431E8 File Offset: 0x006413E8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int AddLogBattleCommand(IntPtr l)
	{
		int result;
		try
		{
			BattleBase battleBase = (BattleBase)LuaObject.checkSelf(l);
			BattleCommand cmd;
			LuaObject.checkType<BattleCommand>(l, 2, out cmd);
			battleBase.m_luaExportHelper.AddLogBattleCommand(cmd);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060172AC RID: 94892 RVA: 0x00643244 File Offset: 0x00641444
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int AddBattleCommandToList(IntPtr l)
	{
		int result;
		try
		{
			BattleBase battleBase = (BattleBase)LuaObject.checkSelf(l);
			LinkedList<BattleCommand> commands;
			LuaObject.checkType<LinkedList<BattleCommand>>(l, 2, out commands);
			BattleCommand command;
			LuaObject.checkType<BattleCommand>(l, 3, out command);
			battleBase.m_luaExportHelper.AddBattleCommandToList(commands, command);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060172AD RID: 94893 RVA: 0x006432B0 File Offset: 0x006414B0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int HasWrongStepBattleCommand(IntPtr l)
	{
		int result;
		try
		{
			BattleBase battleBase = (BattleBase)LuaObject.checkSelf(l);
			bool b = battleBase.m_luaExportHelper.HasWrongStepBattleCommand();
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

	// Token: 0x060172AE RID: 94894 RVA: 0x0064330C File Offset: 0x0064150C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int ExecuteGiveupCommand(IntPtr l)
	{
		int result;
		try
		{
			BattleBase battleBase = (BattleBase)LuaObject.checkSelf(l);
			int playerIndex;
			LuaObject.checkType(l, 2, out playerIndex);
			battleBase.m_luaExportHelper.ExecuteGiveupCommand(playerIndex);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060172AF RID: 94895 RVA: 0x00643368 File Offset: 0x00641568
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int RemoveStepCommands(IntPtr l)
	{
		int result;
		try
		{
			BattleBase battleBase = (BattleBase)LuaObject.checkSelf(l);
			int step;
			LuaObject.checkType(l, 2, out step);
			battleBase.m_luaExportHelper.RemoveStepCommands(step);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060172B0 RID: 94896 RVA: 0x006433C4 File Offset: 0x006415C4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int RunCurrentStepBattleCommand(IntPtr l)
	{
		int result;
		try
		{
			BattleBase battleBase = (BattleBase)LuaObject.checkSelf(l);
			bool b = battleBase.m_luaExportHelper.RunCurrentStepBattleCommand();
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

	// Token: 0x060172B1 RID: 94897 RVA: 0x00643420 File Offset: 0x00641620
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int RunCombat(IntPtr l)
	{
		int result;
		try
		{
			BattleBase battleBase = (BattleBase)LuaObject.checkSelf(l);
			bool b = battleBase.m_luaExportHelper.RunCombat();
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

	// Token: 0x060172B2 RID: 94898 RVA: 0x0064347C File Offset: 0x0064167C
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int AddExecutedCommand(IntPtr l)
	{
		int result;
		try
		{
			BattleBase battleBase = (BattleBase)LuaObject.checkSelf(l);
			BattleCommand cmd;
			LuaObject.checkType<BattleCommand>(l, 2, out cmd);
			battleBase.m_luaExportHelper.AddExecutedCommand(cmd);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060172B3 RID: 94899 RVA: 0x006434D8 File Offset: 0x006416D8
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int StopCombat(IntPtr l)
	{
		int result;
		try
		{
			BattleBase battleBase = (BattleBase)LuaObject.checkSelf(l);
			battleBase.m_luaExportHelper.StopCombat();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060172B4 RID: 94900 RVA: 0x0064352C File Offset: 0x0064172C
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int CheckCombatActorsDie(IntPtr l)
	{
		int result;
		try
		{
			BattleBase battleBase = (BattleBase)LuaObject.checkSelf(l);
			BattleActor actorA;
			LuaObject.checkType<BattleActor>(l, 2, out actorA);
			BattleActor actorB;
			LuaObject.checkType<BattleActor>(l, 3, out actorB);
			battleBase.m_luaExportHelper.CheckCombatActorsDie(actorA, actorB);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060172B5 RID: 94901 RVA: 0x00643598 File Offset: 0x00641798
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int CopyCombatProperty(IntPtr l)
	{
		int result;
		try
		{
			BattleBase battleBase = (BattleBase)LuaObject.checkSelf(l);
			CombatTeam combatTeam;
			LuaObject.checkType<CombatTeam>(l, 2, out combatTeam);
			BattleActor actor;
			LuaObject.checkType<BattleActor>(l, 3, out actor);
			battleBase.m_luaExportHelper.CopyCombatProperty(combatTeam, actor);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060172B6 RID: 94902 RVA: 0x00643604 File Offset: 0x00641804
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int CheckWinConditionOnActorMove(IntPtr l)
	{
		int result;
		try
		{
			BattleBase battleBase = (BattleBase)LuaObject.checkSelf(l);
			BattleActor actor;
			LuaObject.checkType<BattleActor>(l, 2, out actor);
			battleBase.m_luaExportHelper.CheckWinConditionOnActorMove(actor);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060172B7 RID: 94903 RVA: 0x00643660 File Offset: 0x00641860
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int CheckLoseConditionOnActorMove(IntPtr l)
	{
		int result;
		try
		{
			BattleBase battleBase = (BattleBase)LuaObject.checkSelf(l);
			BattleActor actor;
			LuaObject.checkType<BattleActor>(l, 2, out actor);
			battleBase.m_luaExportHelper.CheckLoseConditionOnActorMove(actor);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060172B8 RID: 94904 RVA: 0x006436BC File Offset: 0x006418BC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int CheckWinConditionOnActorDie(IntPtr l)
	{
		int result;
		try
		{
			BattleBase battleBase = (BattleBase)LuaObject.checkSelf(l);
			BattleActor actor;
			LuaObject.checkType<BattleActor>(l, 2, out actor);
			battleBase.m_luaExportHelper.CheckWinConditionOnActorDie(actor);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060172B9 RID: 94905 RVA: 0x00643718 File Offset: 0x00641918
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int CheckLoseConditionOnActorDie(IntPtr l)
	{
		int result;
		try
		{
			BattleBase battleBase = (BattleBase)LuaObject.checkSelf(l);
			BattleActor actor;
			LuaObject.checkType<BattleActor>(l, 2, out actor);
			battleBase.m_luaExportHelper.CheckLoseConditionOnActorDie(actor);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060172BA RID: 94906 RVA: 0x00643774 File Offset: 0x00641974
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int CheckWinConditionOnActorRetreat(IntPtr l)
	{
		int result;
		try
		{
			BattleBase battleBase = (BattleBase)LuaObject.checkSelf(l);
			BattleActor actor;
			LuaObject.checkType<BattleActor>(l, 2, out actor);
			battleBase.m_luaExportHelper.CheckWinConditionOnActorRetreat(actor);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060172BB RID: 94907 RVA: 0x006437D0 File Offset: 0x006419D0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int CheckLoseConditionOnActorRetreat(IntPtr l)
	{
		int result;
		try
		{
			BattleBase battleBase = (BattleBase)LuaObject.checkSelf(l);
			BattleActor actor;
			LuaObject.checkType<BattleActor>(l, 2, out actor);
			battleBase.m_luaExportHelper.CheckLoseConditionOnActorRetreat(actor);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060172BC RID: 94908 RVA: 0x0064382C File Offset: 0x00641A2C
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int CheckWinConditionOnEventTrigger(IntPtr l)
	{
		int result;
		try
		{
			BattleBase battleBase = (BattleBase)LuaObject.checkSelf(l);
			BattleEventTriggerState eventState;
			LuaObject.checkType<BattleEventTriggerState>(l, 2, out eventState);
			battleBase.m_luaExportHelper.CheckWinConditionOnEventTrigger(eventState);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060172BD RID: 94909 RVA: 0x00643888 File Offset: 0x00641A88
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int CheckLoseConditionOnEventTrigger(IntPtr l)
	{
		int result;
		try
		{
			BattleBase battleBase = (BattleBase)LuaObject.checkSelf(l);
			BattleEventTriggerState eventState;
			LuaObject.checkType<BattleEventTriggerState>(l, 2, out eventState);
			battleBase.m_luaExportHelper.CheckLoseConditionOnEventTrigger(eventState);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060172BE RID: 94910 RVA: 0x006438E4 File Offset: 0x00641AE4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int CheckWinConditionOnNextStep(IntPtr l)
	{
		int result;
		try
		{
			BattleBase battleBase = (BattleBase)LuaObject.checkSelf(l);
			battleBase.m_luaExportHelper.CheckWinConditionOnNextStep();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060172BF RID: 94911 RVA: 0x00643938 File Offset: 0x00641B38
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int CheckWinConditionOnTurnBegin(IntPtr l)
	{
		int result;
		try
		{
			BattleBase battleBase = (BattleBase)LuaObject.checkSelf(l);
			battleBase.m_luaExportHelper.CheckWinConditionOnTurnBegin();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060172C0 RID: 94912 RVA: 0x0064398C File Offset: 0x00641B8C
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int CheckWinLoseConditionOnTurnMax(IntPtr l)
	{
		int result;
		try
		{
			BattleBase battleBase = (BattleBase)LuaObject.checkSelf(l);
			battleBase.m_luaExportHelper.CheckWinLoseConditionOnTurnMax();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060172C1 RID: 94913 RVA: 0x006439E0 File Offset: 0x00641BE0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int ChangeWinConditionStatus(IntPtr l)
	{
		int result;
		try
		{
			BattleBase battleBase = (BattleBase)LuaObject.checkSelf(l);
			BattleWinConditionState state;
			LuaObject.checkType<BattleWinConditionState>(l, 2, out state);
			battleBase.m_luaExportHelper.ChangeWinConditionStatus(state);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060172C2 RID: 94914 RVA: 0x00643A3C File Offset: 0x00641C3C
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int ChangeLoseConditionStatus(IntPtr l)
	{
		int result;
		try
		{
			BattleBase battleBase = (BattleBase)LuaObject.checkSelf(l);
			BattleLoseConditionState state;
			LuaObject.checkType<BattleLoseConditionState>(l, 2, out state);
			battleBase.m_luaExportHelper.ChangeLoseConditionStatus(state);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060172C3 RID: 94915 RVA: 0x00643A98 File Offset: 0x00641C98
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int CheckEventTriggerOnActorMove(IntPtr l)
	{
		int result;
		try
		{
			BattleBase battleBase = (BattleBase)LuaObject.checkSelf(l);
			BattleActor actor;
			LuaObject.checkType<BattleActor>(l, 2, out actor);
			battleBase.m_luaExportHelper.CheckEventTriggerOnActorMove(actor);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060172C4 RID: 94916 RVA: 0x00643AF4 File Offset: 0x00641CF4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int CheckEventTriggerOnActorDie(IntPtr l)
	{
		int result;
		try
		{
			BattleBase battleBase = (BattleBase)LuaObject.checkSelf(l);
			BattleActor actor;
			LuaObject.checkType<BattleActor>(l, 2, out actor);
			battleBase.m_luaExportHelper.CheckEventTriggerOnActorDie(actor);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060172C5 RID: 94917 RVA: 0x00643B50 File Offset: 0x00641D50
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int CheckEventTriggerOnActorActionBegin(IntPtr l)
	{
		int result;
		try
		{
			BattleBase battleBase = (BattleBase)LuaObject.checkSelf(l);
			BattleActor a;
			LuaObject.checkType<BattleActor>(l, 2, out a);
			battleBase.m_luaExportHelper.CheckEventTriggerOnActorActionBegin(a);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060172C6 RID: 94918 RVA: 0x00643BAC File Offset: 0x00641DAC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int CheckEventTriggerOnActorCombatAttackBefore(IntPtr l)
	{
		int result;
		try
		{
			BattleBase battleBase = (BattleBase)LuaObject.checkSelf(l);
			BattleActor a;
			LuaObject.checkType<BattleActor>(l, 2, out a);
			BattleActor target;
			LuaObject.checkType<BattleActor>(l, 3, out target);
			battleBase.m_luaExportHelper.CheckEventTriggerOnActorCombatAttackBefore(a, target);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060172C7 RID: 94919 RVA: 0x00643C18 File Offset: 0x00641E18
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int CheckEventTriggerOnActorCombatAttackAfter(IntPtr l)
	{
		int result;
		try
		{
			BattleBase battleBase = (BattleBase)LuaObject.checkSelf(l);
			BattleActor a;
			LuaObject.checkType<BattleActor>(l, 2, out a);
			BattleActor target;
			LuaObject.checkType<BattleActor>(l, 3, out target);
			battleBase.m_luaExportHelper.CheckEventTriggerOnActorCombatAttackAfter(a, target);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060172C8 RID: 94920 RVA: 0x00643C84 File Offset: 0x00641E84
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int CheckEventTriggerOnActorBeCombatAttack(IntPtr l)
	{
		int result;
		try
		{
			BattleBase battleBase = (BattleBase)LuaObject.checkSelf(l);
			BattleActor a;
			LuaObject.checkType<BattleActor>(l, 2, out a);
			battleBase.m_luaExportHelper.CheckEventTriggerOnActorBeCombatAttack(a);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060172C9 RID: 94921 RVA: 0x00643CE0 File Offset: 0x00641EE0
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int CheckEventTriggerOnNextStep(IntPtr l)
	{
		int result;
		try
		{
			BattleBase battleBase = (BattleBase)LuaObject.checkSelf(l);
			battleBase.m_luaExportHelper.CheckEventTriggerOnNextStep();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060172CA RID: 94922 RVA: 0x00643D34 File Offset: 0x00641F34
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int CheckEventTriggerOnNextTeam(IntPtr l)
	{
		int result;
		try
		{
			BattleBase battleBase = (BattleBase)LuaObject.checkSelf(l);
			int team;
			LuaObject.checkType(l, 2, out team);
			bool isNpc;
			LuaObject.checkType(l, 3, out isNpc);
			battleBase.m_luaExportHelper.CheckEventTriggerOnNextTeam(team, isNpc);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060172CB RID: 94923 RVA: 0x00643DA0 File Offset: 0x00641FA0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int CheckEventTriggerOnCompleteAchievement(IntPtr l)
	{
		int result;
		try
		{
			BattleBase battleBase = (BattleBase)LuaObject.checkSelf(l);
			int achievementId;
			LuaObject.checkType(l, 2, out achievementId);
			battleBase.m_luaExportHelper.CheckEventTriggerOnCompleteAchievement(achievementId);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060172CC RID: 94924 RVA: 0x00643DFC File Offset: 0x00641FFC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int CheckEventTriggerOnWin(IntPtr l)
	{
		int result;
		try
		{
			BattleBase battleBase = (BattleBase)LuaObject.checkSelf(l);
			battleBase.m_luaExportHelper.CheckEventTriggerOnWin();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060172CD RID: 94925 RVA: 0x00643E50 File Offset: 0x00642050
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int CheckEventTriggerOnLose(IntPtr l)
	{
		int result;
		try
		{
			BattleBase battleBase = (BattleBase)LuaObject.checkSelf(l);
			battleBase.m_luaExportHelper.CheckEventTriggerOnLose();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060172CE RID: 94926 RVA: 0x00643EA4 File Offset: 0x006420A4
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int CheckBattleStopEventTrigger(IntPtr l)
	{
		int result;
		try
		{
			BattleBase battleBase = (BattleBase)LuaObject.checkSelf(l);
			battleBase.m_luaExportHelper.CheckBattleStopEventTrigger();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060172CF RID: 94927 RVA: 0x00643EF8 File Offset: 0x006420F8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int CheckMultiEventTrigger(IntPtr l)
	{
		int result;
		try
		{
			BattleBase battleBase = (BattleBase)LuaObject.checkSelf(l);
			battleBase.m_luaExportHelper.CheckMultiEventTrigger();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060172D0 RID: 94928 RVA: 0x00643F4C File Offset: 0x0064214C
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int IsEventTriggerd(IntPtr l)
	{
		int result;
		try
		{
			BattleBase battleBase = (BattleBase)LuaObject.checkSelf(l);
			int triggerId;
			LuaObject.checkType(l, 2, out triggerId);
			bool b = battleBase.m_luaExportHelper.IsEventTriggerd(triggerId);
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

	// Token: 0x060172D1 RID: 94929 RVA: 0x00643FB4 File Offset: 0x006421B4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int GetEventTriggerState(IntPtr l)
	{
		int result;
		try
		{
			BattleBase battleBase = (BattleBase)LuaObject.checkSelf(l);
			int triggerId;
			LuaObject.checkType(l, 2, out triggerId);
			BattleEventTriggerState eventTriggerState = battleBase.m_luaExportHelper.GetEventTriggerState(triggerId);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, eventTriggerState);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060172D2 RID: 94930 RVA: 0x0064401C File Offset: 0x0064221C
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int TriggerEvent(IntPtr l)
	{
		int result;
		try
		{
			BattleBase battleBase = (BattleBase)LuaObject.checkSelf(l);
			BattleEventTriggerState state;
			LuaObject.checkType<BattleEventTriggerState>(l, 2, out state);
			battleBase.m_luaExportHelper.TriggerEvent(state);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060172D3 RID: 94931 RVA: 0x00644078 File Offset: 0x00642278
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int ExecuteTriggerEventActions(IntPtr l)
	{
		int result;
		try
		{
			BattleBase battleBase = (BattleBase)LuaObject.checkSelf(l);
			BattleEventTriggerState state;
			LuaObject.checkType<BattleEventTriggerState>(l, 2, out state);
			int fromIdx;
			LuaObject.checkType(l, 3, out fromIdx);
			battleBase.m_luaExportHelper.ExecuteTriggerEventActions(state, fromIdx);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060172D4 RID: 94932 RVA: 0x006440E4 File Offset: 0x006422E4
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int ExecuteEventAction(IntPtr l)
	{
		int result;
		try
		{
			BattleBase battleBase = (BattleBase)LuaObject.checkSelf(l);
			ConfigDataBattleEventActionInfo e;
			LuaObject.checkType<ConfigDataBattleEventActionInfo>(l, 2, out e);
			battleBase.m_luaExportHelper.ExecuteEventAction(e);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e2)
		{
			result = LuaObject.error(l, e2);
		}
		return result;
	}

	// Token: 0x060172D5 RID: 94933 RVA: 0x00644140 File Offset: 0x00642340
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int ExecuteEventAction_Relief(IntPtr l)
	{
		int result;
		try
		{
			BattleBase battleBase = (BattleBase)LuaObject.checkSelf(l);
			ConfigDataBattleEventActionInfo e;
			LuaObject.checkType<ConfigDataBattleEventActionInfo>(l, 2, out e);
			battleBase.m_luaExportHelper.ExecuteEventAction_Relief(e);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e2)
		{
			result = LuaObject.error(l, e2);
		}
		return result;
	}

	// Token: 0x060172D6 RID: 94934 RVA: 0x0064419C File Offset: 0x0064239C
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int ExecuteEventAction_Retreat(IntPtr l)
	{
		int result;
		try
		{
			BattleBase battleBase = (BattleBase)LuaObject.checkSelf(l);
			ConfigDataBattleEventActionInfo e;
			LuaObject.checkType<ConfigDataBattleEventActionInfo>(l, 2, out e);
			battleBase.m_luaExportHelper.ExecuteEventAction_Retreat(e);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e2)
		{
			result = LuaObject.error(l, e2);
		}
		return result;
	}

	// Token: 0x060172D7 RID: 94935 RVA: 0x006441F8 File Offset: 0x006423F8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int ExecuteEventAction_Dialog(IntPtr l)
	{
		int result;
		try
		{
			BattleBase battleBase = (BattleBase)LuaObject.checkSelf(l);
			ConfigDataBattleEventActionInfo e;
			LuaObject.checkType<ConfigDataBattleEventActionInfo>(l, 2, out e);
			battleBase.m_luaExportHelper.ExecuteEventAction_Dialog(e);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e2)
		{
			result = LuaObject.error(l, e2);
		}
		return result;
	}

	// Token: 0x060172D8 RID: 94936 RVA: 0x00644254 File Offset: 0x00642454
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int ExecuteEventAction_ChangeTeam(IntPtr l)
	{
		int result;
		try
		{
			BattleBase battleBase = (BattleBase)LuaObject.checkSelf(l);
			ConfigDataBattleEventActionInfo e;
			LuaObject.checkType<ConfigDataBattleEventActionInfo>(l, 2, out e);
			battleBase.m_luaExportHelper.ExecuteEventAction_ChangeTeam(e);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e2)
		{
			result = LuaObject.error(l, e2);
		}
		return result;
	}

	// Token: 0x060172D9 RID: 94937 RVA: 0x006442B0 File Offset: 0x006424B0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int ExecuteEventAction_AttachBuff(IntPtr l)
	{
		int result;
		try
		{
			BattleBase battleBase = (BattleBase)LuaObject.checkSelf(l);
			ConfigDataBattleEventActionInfo e;
			LuaObject.checkType<ConfigDataBattleEventActionInfo>(l, 2, out e);
			battleBase.m_luaExportHelper.ExecuteEventAction_AttachBuff(e);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e2)
		{
			result = LuaObject.error(l, e2);
		}
		return result;
	}

	// Token: 0x060172DA RID: 94938 RVA: 0x0064430C File Offset: 0x0064250C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int ExecuteEventAction_ChangeBehavior(IntPtr l)
	{
		int result;
		try
		{
			BattleBase battleBase = (BattleBase)LuaObject.checkSelf(l);
			ConfigDataBattleEventActionInfo e;
			LuaObject.checkType<ConfigDataBattleEventActionInfo>(l, 2, out e);
			battleBase.m_luaExportHelper.ExecuteEventAction_ChangeBehavior(e);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e2)
		{
			result = LuaObject.error(l, e2);
		}
		return result;
	}

	// Token: 0x060172DB RID: 94939 RVA: 0x00644368 File Offset: 0x00642568
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int ExecuteEventAction_Music(IntPtr l)
	{
		int result;
		try
		{
			BattleBase battleBase = (BattleBase)LuaObject.checkSelf(l);
			ConfigDataBattleEventActionInfo e;
			LuaObject.checkType<ConfigDataBattleEventActionInfo>(l, 2, out e);
			battleBase.m_luaExportHelper.ExecuteEventAction_Music(e);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e2)
		{
			result = LuaObject.error(l, e2);
		}
		return result;
	}

	// Token: 0x060172DC RID: 94940 RVA: 0x006443C4 File Offset: 0x006425C4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int ExecuteEventAction_ChangeTerrain(IntPtr l)
	{
		int result;
		try
		{
			BattleBase battleBase = (BattleBase)LuaObject.checkSelf(l);
			ConfigDataBattleEventActionInfo e;
			LuaObject.checkType<ConfigDataBattleEventActionInfo>(l, 2, out e);
			battleBase.m_luaExportHelper.ExecuteEventAction_ChangeTerrain(e);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e2)
		{
			result = LuaObject.error(l, e2);
		}
		return result;
	}

	// Token: 0x060172DD RID: 94941 RVA: 0x00644420 File Offset: 0x00642620
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int ExecuteEventAction_Perform(IntPtr l)
	{
		int result;
		try
		{
			BattleBase battleBase = (BattleBase)LuaObject.checkSelf(l);
			ConfigDataBattleEventActionInfo e;
			LuaObject.checkType<ConfigDataBattleEventActionInfo>(l, 2, out e);
			battleBase.m_luaExportHelper.ExecuteEventAction_Perform(e);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e2)
		{
			result = LuaObject.error(l, e2);
		}
		return result;
	}

	// Token: 0x060172DE RID: 94942 RVA: 0x0064447C File Offset: 0x0064267C
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int ExecuteEventAction_RetreatPosition(IntPtr l)
	{
		int result;
		try
		{
			BattleBase battleBase = (BattleBase)LuaObject.checkSelf(l);
			ConfigDataBattleEventActionInfo e;
			LuaObject.checkType<ConfigDataBattleEventActionInfo>(l, 2, out e);
			battleBase.m_luaExportHelper.ExecuteEventAction_RetreatPosition(e);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e2)
		{
			result = LuaObject.error(l, e2);
		}
		return result;
	}

	// Token: 0x060172DF RID: 94943 RVA: 0x006444D8 File Offset: 0x006426D8
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int ExecuteEventAction_Replace(IntPtr l)
	{
		int result;
		try
		{
			BattleBase battleBase = (BattleBase)LuaObject.checkSelf(l);
			ConfigDataBattleEventActionInfo e;
			LuaObject.checkType<ConfigDataBattleEventActionInfo>(l, 2, out e);
			battleBase.m_luaExportHelper.ExecuteEventAction_Replace(e);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e2)
		{
			result = LuaObject.error(l, e2);
		}
		return result;
	}

	// Token: 0x060172E0 RID: 94944 RVA: 0x00644534 File Offset: 0x00642734
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int ExecuteEventAction_RemoveBuff(IntPtr l)
	{
		int result;
		try
		{
			BattleBase battleBase = (BattleBase)LuaObject.checkSelf(l);
			ConfigDataBattleEventActionInfo e;
			LuaObject.checkType<ConfigDataBattleEventActionInfo>(l, 2, out e);
			battleBase.m_luaExportHelper.ExecuteEventAction_RemoveBuff(e);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e2)
		{
			result = LuaObject.error(l, e2);
		}
		return result;
	}

	// Token: 0x060172E1 RID: 94945 RVA: 0x00644590 File Offset: 0x00642790
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int ExecuteEventAction_AttachBuffPosition(IntPtr l)
	{
		int result;
		try
		{
			BattleBase battleBase = (BattleBase)LuaObject.checkSelf(l);
			ConfigDataBattleEventActionInfo e;
			LuaObject.checkType<ConfigDataBattleEventActionInfo>(l, 2, out e);
			battleBase.m_luaExportHelper.ExecuteEventAction_AttachBuffPosition(e);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e2)
		{
			result = LuaObject.error(l, e2);
		}
		return result;
	}

	// Token: 0x060172E2 RID: 94946 RVA: 0x006445EC File Offset: 0x006427EC
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int IsEmptyPosition(IntPtr l)
	{
		int result;
		try
		{
			BattleBase battleBase = (BattleBase)LuaObject.checkSelf(l);
			GridPosition p;
			LuaObject.checkValueType<GridPosition>(l, 2, out p);
			bool b = battleBase.m_luaExportHelper.IsEmptyPosition(p);
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

	// Token: 0x060172E3 RID: 94947 RVA: 0x00644654 File Offset: 0x00642854
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int GetRandomBattleArmyActors(IntPtr l)
	{
		int result;
		try
		{
			BattleBase battleBase = (BattleBase)LuaObject.checkSelf(l);
			List<int> randomArmies;
			LuaObject.checkType<List<int>>(l, 2, out randomArmies);
			List<RandomArmyActor> randomBattleArmyActors = battleBase.m_luaExportHelper.GetRandomBattleArmyActors(randomArmies);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, randomBattleArmyActors);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060172E4 RID: 94948 RVA: 0x006446BC File Offset: 0x006428BC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int CreateEventActor(IntPtr l)
	{
		int result;
		try
		{
			BattleBase battleBase = (BattleBase)LuaObject.checkSelf(l);
			GridPosition p;
			LuaObject.checkValueType<GridPosition>(l, 2, out p);
			int dir;
			LuaObject.checkType(l, 3, out dir);
			int team;
			LuaObject.checkType(l, 4, out team);
			bool isNpc;
			LuaObject.checkType(l, 5, out isNpc);
			int heroId;
			LuaObject.checkType(l, 6, out heroId);
			int heroLevel;
			LuaObject.checkType(l, 7, out heroLevel);
			int behaviorId;
			LuaObject.checkType(l, 8, out behaviorId);
			int groupId;
			LuaObject.checkType(l, 9, out groupId);
			int effectType;
			LuaObject.checkType(l, 10, out effectType);
			string fxName;
			LuaObject.checkType(l, 11, out fxName);
			BattleActorSourceType sourceType;
			LuaObject.checkEnum<BattleActorSourceType>(l, 12, out sourceType);
			bool b = battleBase.m_luaExportHelper.CreateEventActor(p, dir, team, isNpc, heroId, heroLevel, behaviorId, groupId, effectType, fxName, sourceType);
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

	// Token: 0x060172E5 RID: 94949 RVA: 0x006447A4 File Offset: 0x006429A4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int ReplaceEventActor(IntPtr l)
	{
		int result;
		try
		{
			BattleBase battleBase = (BattleBase)LuaObject.checkSelf(l);
			BattleActor a;
			LuaObject.checkType<BattleActor>(l, 2, out a);
			int heroId;
			LuaObject.checkType(l, 3, out heroId);
			int heroLevel;
			LuaObject.checkType(l, 4, out heroLevel);
			string fxName;
			LuaObject.checkType(l, 5, out fxName);
			bool b = battleBase.m_luaExportHelper.ReplaceEventActor(a, heroId, heroLevel, fxName);
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

	// Token: 0x060172E6 RID: 94950 RVA: 0x00644834 File Offset: 0x00642A34
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int FindEmptyFixedDistancePosition(IntPtr l)
	{
		int result;
		try
		{
			int num = LuaDLL.lua_gettop(l);
			if (num == 3)
			{
				BattleBase battleBase = (BattleBase)LuaObject.checkSelf(l);
				GridPosition target;
				LuaObject.checkValueType<GridPosition>(l, 2, out target);
				int distance;
				LuaObject.checkType(l, 3, out distance);
				GridPosition gridPosition = battleBase.m_luaExportHelper.FindEmptyFixedDistancePosition(target, distance);
				LuaObject.pushValue(l, true);
				LuaObject.pushValue(l, gridPosition);
				result = 2;
			}
			else if (num == 4)
			{
				BattleBase battleBase2 = (BattleBase)LuaObject.checkSelf(l);
				GridPosition start;
				LuaObject.checkValueType<GridPosition>(l, 2, out start);
				GridPosition target2;
				LuaObject.checkValueType<GridPosition>(l, 3, out target2);
				int distance2;
				LuaObject.checkType(l, 4, out distance2);
				GridPosition gridPosition2 = battleBase2.m_luaExportHelper.FindEmptyFixedDistancePosition(start, target2, distance2);
				LuaObject.pushValue(l, true);
				LuaObject.pushValue(l, gridPosition2);
				result = 2;
			}
			else
			{
				LuaObject.pushValue(l, false);
				LuaDLL.lua_pushstring(l, "No matched override function FindEmptyFixedDistancePosition to call");
				result = 2;
			}
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060172E7 RID: 94951 RVA: 0x0064493C File Offset: 0x00642B3C
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int FindEmptyNearPosition(IntPtr l)
	{
		int result;
		try
		{
			BattleBase battleBase = (BattleBase)LuaObject.checkSelf(l);
			GridPosition target;
			LuaObject.checkValueType<GridPosition>(l, 2, out target);
			MoveType moveType;
			LuaObject.checkEnum<MoveType>(l, 3, out moveType);
			GridPosition gridPosition = battleBase.m_luaExportHelper.FindEmptyNearPosition(target, moveType);
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

	// Token: 0x060172E8 RID: 94952 RVA: 0x006449B8 File Offset: 0x00642BB8
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int InitRandomNumbers(IntPtr l)
	{
		int result;
		try
		{
			BattleBase battleBase = (BattleBase)LuaObject.checkSelf(l);
			int randomSeed;
			LuaObject.checkType(l, 2, out randomSeed);
			int armyRandomSeed;
			LuaObject.checkType(l, 3, out armyRandomSeed);
			battleBase.m_luaExportHelper.InitRandomNumbers(randomSeed, armyRandomSeed);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060172E9 RID: 94953 RVA: 0x00644A24 File Offset: 0x00642C24
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int InitPlayers(IntPtr l)
	{
		int result;
		try
		{
			BattleBase battleBase = (BattleBase)LuaObject.checkSelf(l);
			BattlePlayer[] players;
			LuaObject.checkArray<BattlePlayer>(l, 2, out players);
			battleBase.m_luaExportHelper.InitPlayers(players);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060172EA RID: 94954 RVA: 0x00644A80 File Offset: 0x00642C80
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int InitWinConditionStates(IntPtr l)
	{
		int result;
		try
		{
			BattleBase battleBase = (BattleBase)LuaObject.checkSelf(l);
			ConfigDataBattleWinConditionInfo[] winConditionInfos;
			LuaObject.checkArray<ConfigDataBattleWinConditionInfo>(l, 2, out winConditionInfos);
			battleBase.m_luaExportHelper.InitWinConditionStates(winConditionInfos);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060172EB RID: 94955 RVA: 0x00644ADC File Offset: 0x00642CDC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int InitLoseConditionStates(IntPtr l)
	{
		int result;
		try
		{
			BattleBase battleBase = (BattleBase)LuaObject.checkSelf(l);
			ConfigDataBattleLoseConditionInfo[] loseConditionInfos;
			LuaObject.checkArray<ConfigDataBattleLoseConditionInfo>(l, 2, out loseConditionInfos);
			battleBase.m_luaExportHelper.InitLoseConditionStates(loseConditionInfos);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060172EC RID: 94956 RVA: 0x00644B38 File Offset: 0x00642D38
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int InitEventTriggerStates(IntPtr l)
	{
		int result;
		try
		{
			BattleBase battleBase = (BattleBase)LuaObject.checkSelf(l);
			ConfigDataBattleEventTriggerInfo[] eventTriggerInfos;
			LuaObject.checkArray<ConfigDataBattleEventTriggerInfo>(l, 2, out eventTriggerInfos);
			battleBase.m_luaExportHelper.InitEventTriggerStates(eventTriggerInfos);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060172ED RID: 94957 RVA: 0x00644B94 File Offset: 0x00642D94
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int InitBattleTreasureStates(IntPtr l)
	{
		int result;
		try
		{
			BattleBase battleBase = (BattleBase)LuaObject.checkSelf(l);
			ConfigDataBattleTreasureInfo[] battleTreasureInfos;
			LuaObject.checkArray<ConfigDataBattleTreasureInfo>(l, 2, out battleTreasureInfos);
			battleBase.m_luaExportHelper.InitBattleTreasureStates(battleTreasureInfos);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060172EE RID: 94958 RVA: 0x00644BF0 File Offset: 0x00642DF0
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int CreateActors(IntPtr l)
	{
		int result;
		try
		{
			BattleBase battleBase = (BattleBase)LuaObject.checkSelf(l);
			int team;
			LuaObject.checkType(l, 2, out team);
			List<BattleActorSetup> setups;
			LuaObject.checkType<List<BattleActorSetup>>(l, 3, out setups);
			battleBase.m_luaExportHelper.CreateActors(team, setups);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060172EF RID: 94959 RVA: 0x00644C5C File Offset: 0x00642E5C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int ExecuteBattlePerforms(IntPtr l)
	{
		int result;
		try
		{
			BattleBase battleBase = (BattleBase)LuaObject.checkSelf(l);
			ConfigDataBattlePerformInfo performInfo;
			LuaObject.checkType<ConfigDataBattlePerformInfo>(l, 2, out performInfo);
			battleBase.m_luaExportHelper.ExecuteBattlePerforms(performInfo);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060172F0 RID: 94960 RVA: 0x00644CB8 File Offset: 0x00642EB8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int ExecuteAfterCombatSteps(IntPtr l)
	{
		int result;
		try
		{
			BattleBase battleBase = (BattleBase)LuaObject.checkSelf(l);
			battleBase.m_luaExportHelper.ExecuteAfterCombatSteps();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060172F1 RID: 94961 RVA: 0x00644D0C File Offset: 0x00642F0C
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int ExecuteBattlePerform(IntPtr l)
	{
		int result;
		try
		{
			BattleBase battleBase = (BattleBase)LuaObject.checkSelf(l);
			ConfigDataBattlePerformInfo performInfo;
			LuaObject.checkType<ConfigDataBattlePerformInfo>(l, 2, out performInfo);
			battleBase.m_luaExportHelper.ExecuteBattlePerform(performInfo);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060172F2 RID: 94962 RVA: 0x00644D68 File Offset: 0x00642F68
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int ExecuteBattlePerform_Dialog(IntPtr l)
	{
		int result;
		try
		{
			BattleBase battleBase = (BattleBase)LuaObject.checkSelf(l);
			ConfigDataBattlePerformInfo performInfo;
			LuaObject.checkType<ConfigDataBattlePerformInfo>(l, 2, out performInfo);
			battleBase.m_luaExportHelper.ExecuteBattlePerform_Dialog(performInfo);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060172F3 RID: 94963 RVA: 0x00644DC4 File Offset: 0x00642FC4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int ExecuteBattlePerform_PlayMusic(IntPtr l)
	{
		int result;
		try
		{
			BattleBase battleBase = (BattleBase)LuaObject.checkSelf(l);
			ConfigDataBattlePerformInfo performInfo;
			LuaObject.checkType<ConfigDataBattlePerformInfo>(l, 2, out performInfo);
			battleBase.m_luaExportHelper.ExecuteBattlePerform_PlayMusic(performInfo);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060172F4 RID: 94964 RVA: 0x00644E20 File Offset: 0x00643020
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int ExecuteBattlePerform_PlaySound(IntPtr l)
	{
		int result;
		try
		{
			BattleBase battleBase = (BattleBase)LuaObject.checkSelf(l);
			ConfigDataBattlePerformInfo performInfo;
			LuaObject.checkType<ConfigDataBattlePerformInfo>(l, 2, out performInfo);
			battleBase.m_luaExportHelper.ExecuteBattlePerform_PlaySound(performInfo);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060172F5 RID: 94965 RVA: 0x00644E7C File Offset: 0x0064307C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int ExecuteBattlePerform_PlayFx(IntPtr l)
	{
		int result;
		try
		{
			BattleBase battleBase = (BattleBase)LuaObject.checkSelf(l);
			ConfigDataBattlePerformInfo performInfo;
			LuaObject.checkType<ConfigDataBattlePerformInfo>(l, 2, out performInfo);
			battleBase.m_luaExportHelper.ExecuteBattlePerform_PlayFx(performInfo);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060172F6 RID: 94966 RVA: 0x00644ED8 File Offset: 0x006430D8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int ExecuteBattlePerform_PlayActorFx(IntPtr l)
	{
		int result;
		try
		{
			BattleBase battleBase = (BattleBase)LuaObject.checkSelf(l);
			ConfigDataBattlePerformInfo performInfo;
			LuaObject.checkType<ConfigDataBattlePerformInfo>(l, 2, out performInfo);
			battleBase.m_luaExportHelper.ExecuteBattlePerform_PlayActorFx(performInfo);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060172F7 RID: 94967 RVA: 0x00644F34 File Offset: 0x00643134
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int ExecuteBattlePerform_ChangeTerrain(IntPtr l)
	{
		int result;
		try
		{
			BattleBase battleBase = (BattleBase)LuaObject.checkSelf(l);
			ConfigDataBattlePerformInfo performInfo;
			LuaObject.checkType<ConfigDataBattlePerformInfo>(l, 2, out performInfo);
			battleBase.m_luaExportHelper.ExecuteBattlePerform_ChangeTerrain(performInfo);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060172F8 RID: 94968 RVA: 0x00644F90 File Offset: 0x00643190
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int ExecuteBattlePerform_CameraFocusPosition(IntPtr l)
	{
		int result;
		try
		{
			BattleBase battleBase = (BattleBase)LuaObject.checkSelf(l);
			ConfigDataBattlePerformInfo performInfo;
			LuaObject.checkType<ConfigDataBattlePerformInfo>(l, 2, out performInfo);
			battleBase.m_luaExportHelper.ExecuteBattlePerform_CameraFocusPosition(performInfo);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060172F9 RID: 94969 RVA: 0x00644FEC File Offset: 0x006431EC
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int ExecuteBattlePerform_CameraFocusActor(IntPtr l)
	{
		int result;
		try
		{
			BattleBase battleBase = (BattleBase)LuaObject.checkSelf(l);
			ConfigDataBattlePerformInfo performInfo;
			LuaObject.checkType<ConfigDataBattlePerformInfo>(l, 2, out performInfo);
			battleBase.m_luaExportHelper.ExecuteBattlePerform_CameraFocusActor(performInfo);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060172FA RID: 94970 RVA: 0x00645048 File Offset: 0x00643248
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int ExecuteBattlePerform_CreateActor(IntPtr l)
	{
		int result;
		try
		{
			BattleBase battleBase = (BattleBase)LuaObject.checkSelf(l);
			ConfigDataBattlePerformInfo performInfo;
			LuaObject.checkType<ConfigDataBattlePerformInfo>(l, 2, out performInfo);
			battleBase.m_luaExportHelper.ExecuteBattlePerform_CreateActor(performInfo);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060172FB RID: 94971 RVA: 0x006450A4 File Offset: 0x006432A4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int ExecuteBattlePerform_CreateActorNear(IntPtr l)
	{
		int result;
		try
		{
			BattleBase battleBase = (BattleBase)LuaObject.checkSelf(l);
			ConfigDataBattlePerformInfo performInfo;
			LuaObject.checkType<ConfigDataBattlePerformInfo>(l, 2, out performInfo);
			battleBase.m_luaExportHelper.ExecuteBattlePerform_CreateActorNear(performInfo);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060172FC RID: 94972 RVA: 0x00645100 File Offset: 0x00643300
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int ExecuteBattlePerform_RemoveActor(IntPtr l)
	{
		int result;
		try
		{
			BattleBase battleBase = (BattleBase)LuaObject.checkSelf(l);
			ConfigDataBattlePerformInfo performInfo;
			LuaObject.checkType<ConfigDataBattlePerformInfo>(l, 2, out performInfo);
			battleBase.m_luaExportHelper.ExecuteBattlePerform_RemoveActor(performInfo);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060172FD RID: 94973 RVA: 0x0064515C File Offset: 0x0064335C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int ExecuteBattlePerform_ActorMove(IntPtr l)
	{
		int result;
		try
		{
			BattleBase battleBase = (BattleBase)LuaObject.checkSelf(l);
			ConfigDataBattlePerformInfo performInfo;
			LuaObject.checkType<ConfigDataBattlePerformInfo>(l, 2, out performInfo);
			battleBase.m_luaExportHelper.ExecuteBattlePerform_ActorMove(performInfo);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060172FE RID: 94974 RVA: 0x006451B8 File Offset: 0x006433B8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int ExecuteBattlePerform_ActorMoveNear(IntPtr l)
	{
		int result;
		try
		{
			BattleBase battleBase = (BattleBase)LuaObject.checkSelf(l);
			ConfigDataBattlePerformInfo performInfo;
			LuaObject.checkType<ConfigDataBattlePerformInfo>(l, 2, out performInfo);
			battleBase.m_luaExportHelper.ExecuteBattlePerform_ActorMoveNear(performInfo);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060172FF RID: 94975 RVA: 0x00645214 File Offset: 0x00643414
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int ExecuteBattlePerform_ActorAttack(IntPtr l)
	{
		int result;
		try
		{
			BattleBase battleBase = (BattleBase)LuaObject.checkSelf(l);
			ConfigDataBattlePerformInfo performInfo;
			LuaObject.checkType<ConfigDataBattlePerformInfo>(l, 2, out performInfo);
			battleBase.m_luaExportHelper.ExecuteBattlePerform_ActorAttack(performInfo);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06017300 RID: 94976 RVA: 0x00645270 File Offset: 0x00643470
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int ExecuteBattlePerform_ActorSkill(IntPtr l)
	{
		int result;
		try
		{
			BattleBase battleBase = (BattleBase)LuaObject.checkSelf(l);
			ConfigDataBattlePerformInfo performInfo;
			LuaObject.checkType<ConfigDataBattlePerformInfo>(l, 2, out performInfo);
			battleBase.m_luaExportHelper.ExecuteBattlePerform_ActorSkill(performInfo);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06017301 RID: 94977 RVA: 0x006452CC File Offset: 0x006434CC
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int ExecuteBattlePerform_ActorDir(IntPtr l)
	{
		int result;
		try
		{
			BattleBase battleBase = (BattleBase)LuaObject.checkSelf(l);
			ConfigDataBattlePerformInfo performInfo;
			LuaObject.checkType<ConfigDataBattlePerformInfo>(l, 2, out performInfo);
			battleBase.m_luaExportHelper.ExecuteBattlePerform_ActorDir(performInfo);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06017302 RID: 94978 RVA: 0x00645328 File Offset: 0x00643528
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int ExecuteBattlePerform_ActorAnimation(IntPtr l)
	{
		int result;
		try
		{
			BattleBase battleBase = (BattleBase)LuaObject.checkSelf(l);
			ConfigDataBattlePerformInfo performInfo;
			LuaObject.checkType<ConfigDataBattlePerformInfo>(l, 2, out performInfo);
			battleBase.m_luaExportHelper.ExecuteBattlePerform_ActorAnimation(performInfo);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06017303 RID: 94979 RVA: 0x00645384 File Offset: 0x00643584
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int ExecuteBattlePerform_ActorIdle(IntPtr l)
	{
		int result;
		try
		{
			BattleBase battleBase = (BattleBase)LuaObject.checkSelf(l);
			ConfigDataBattlePerformInfo performInfo;
			LuaObject.checkType<ConfigDataBattlePerformInfo>(l, 2, out performInfo);
			battleBase.m_luaExportHelper.ExecuteBattlePerform_ActorIdle(performInfo);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06017304 RID: 94980 RVA: 0x006453E0 File Offset: 0x006435E0
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int ExecuteBattlePerform_WaitTime(IntPtr l)
	{
		int result;
		try
		{
			BattleBase battleBase = (BattleBase)LuaObject.checkSelf(l);
			ConfigDataBattlePerformInfo performInfo;
			LuaObject.checkType<ConfigDataBattlePerformInfo>(l, 2, out performInfo);
			battleBase.m_luaExportHelper.ExecuteBattlePerform_WaitTime(performInfo);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06017305 RID: 94981 RVA: 0x0064543C File Offset: 0x0064363C
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int ExecuteBattlePerform_StopBattle(IntPtr l)
	{
		int result;
		try
		{
			BattleBase battleBase = (BattleBase)LuaObject.checkSelf(l);
			ConfigDataBattlePerformInfo performInfo;
			LuaObject.checkType<ConfigDataBattlePerformInfo>(l, 2, out performInfo);
			battleBase.m_luaExportHelper.ExecuteBattlePerform_StopBattle(performInfo);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06017306 RID: 94982 RVA: 0x00645498 File Offset: 0x00643698
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int CheckBattleTreasureOnActorMove(IntPtr l)
	{
		int result;
		try
		{
			BattleBase battleBase = (BattleBase)LuaObject.checkSelf(l);
			BattleActor actor;
			LuaObject.checkType<BattleActor>(l, 2, out actor);
			battleBase.m_luaExportHelper.CheckBattleTreasureOnActorMove(actor);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06017307 RID: 94983 RVA: 0x006454F4 File Offset: 0x006436F4
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int ChangeBattleTeasureStatus(IntPtr l)
	{
		int result;
		try
		{
			BattleBase battleBase = (BattleBase)LuaObject.checkSelf(l);
			BattleTreasureState state;
			LuaObject.checkType<BattleTreasureState>(l, 2, out state);
			BattleActor actor;
			LuaObject.checkType<BattleActor>(l, 3, out actor);
			battleBase.m_luaExportHelper.ChangeBattleTeasureStatus(state, actor);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06017308 RID: 94984 RVA: 0x00645560 File Offset: 0x00643760
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int IsActorInPositions_s(IntPtr l)
	{
		int result;
		try
		{
			BattleActor a;
			LuaObject.checkType<BattleActor>(l, 1, out a);
			List<ParamPosition> positions;
			LuaObject.checkType<List<ParamPosition>>(l, 2, out positions);
			bool b = BattleBase.LuaExportHelper.IsActorInPositions(a, positions);
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

	// Token: 0x06017309 RID: 94985 RVA: 0x006455C0 File Offset: 0x006437C0
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int IsSkillClassMatch_s(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataSkillInfo skillInfo;
			LuaObject.checkType<ConfigDataSkillInfo>(l, 1, out skillInfo);
			int skillClass;
			LuaObject.checkType(l, 2, out skillClass);
			bool b = BattleBase.LuaExportHelper.IsSkillClassMatch(skillInfo, skillClass);
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

	// Token: 0x0601730A RID: 94986 RVA: 0x00645620 File Offset: 0x00643820
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int IsActorClassMatch_s(IntPtr l)
	{
		int result;
		try
		{
			BattleActor actor;
			LuaObject.checkType<BattleActor>(l, 1, out actor);
			int actorClass;
			LuaObject.checkType(l, 2, out actorClass);
			bool b = BattleBase.LuaExportHelper.IsActorClassMatch(actor, actorClass);
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

	// Token: 0x0601730B RID: 94987 RVA: 0x00645680 File Offset: 0x00643880
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_configDataLoader(IntPtr l)
	{
		int result;
		try
		{
			BattleBase battleBase = (BattleBase)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, battleBase.m_luaExportHelper.m_configDataLoader);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601730C RID: 94988 RVA: 0x006456D8 File Offset: 0x006438D8
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_m_configDataLoader(IntPtr l)
	{
		int result;
		try
		{
			BattleBase battleBase = (BattleBase)LuaObject.checkSelf(l);
			IConfigDataLoader configDataLoader;
			LuaObject.checkType<IConfigDataLoader>(l, 2, out configDataLoader);
			battleBase.m_luaExportHelper.m_configDataLoader = configDataLoader;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601730D RID: 94989 RVA: 0x00645734 File Offset: 0x00643934
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_battleListener(IntPtr l)
	{
		int result;
		try
		{
			BattleBase battleBase = (BattleBase)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, battleBase.m_luaExportHelper.m_battleListener);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601730E RID: 94990 RVA: 0x0064578C File Offset: 0x0064398C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_battleListener(IntPtr l)
	{
		int result;
		try
		{
			BattleBase battleBase = (BattleBase)LuaObject.checkSelf(l);
			IBattleListener battleListener;
			LuaObject.checkType<IBattleListener>(l, 2, out battleListener);
			battleBase.m_luaExportHelper.m_battleListener = battleListener;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601730F RID: 94991 RVA: 0x006457E8 File Offset: 0x006439E8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_randomNumber(IntPtr l)
	{
		int result;
		try
		{
			BattleBase battleBase = (BattleBase)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, battleBase.m_luaExportHelper.m_randomNumber);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06017310 RID: 94992 RVA: 0x00645840 File Offset: 0x00643A40
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_randomNumber(IntPtr l)
	{
		int result;
		try
		{
			BattleBase battleBase = (BattleBase)LuaObject.checkSelf(l);
			RandomNumber randomNumber;
			LuaObject.checkType<RandomNumber>(l, 2, out randomNumber);
			battleBase.m_luaExportHelper.m_randomNumber = randomNumber;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06017311 RID: 94993 RVA: 0x0064589C File Offset: 0x00643A9C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_aiRandomNumber1(IntPtr l)
	{
		int result;
		try
		{
			BattleBase battleBase = (BattleBase)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, battleBase.m_luaExportHelper.m_aiRandomNumber1);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06017312 RID: 94994 RVA: 0x006458F4 File Offset: 0x00643AF4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_aiRandomNumber1(IntPtr l)
	{
		int result;
		try
		{
			BattleBase battleBase = (BattleBase)LuaObject.checkSelf(l);
			RandomNumber aiRandomNumber;
			LuaObject.checkType<RandomNumber>(l, 2, out aiRandomNumber);
			battleBase.m_luaExportHelper.m_aiRandomNumber1 = aiRandomNumber;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06017313 RID: 94995 RVA: 0x00645950 File Offset: 0x00643B50
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_m_aiRandomNumber2(IntPtr l)
	{
		int result;
		try
		{
			BattleBase battleBase = (BattleBase)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, battleBase.m_luaExportHelper.m_aiRandomNumber2);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06017314 RID: 94996 RVA: 0x006459A8 File Offset: 0x00643BA8
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_m_aiRandomNumber2(IntPtr l)
	{
		int result;
		try
		{
			BattleBase battleBase = (BattleBase)LuaObject.checkSelf(l);
			RandomNumber aiRandomNumber;
			LuaObject.checkType<RandomNumber>(l, 2, out aiRandomNumber);
			battleBase.m_luaExportHelper.m_aiRandomNumber2 = aiRandomNumber;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06017315 RID: 94997 RVA: 0x00645A04 File Offset: 0x00643C04
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_m_armyRandomNumber(IntPtr l)
	{
		int result;
		try
		{
			BattleBase battleBase = (BattleBase)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, battleBase.m_luaExportHelper.m_armyRandomNumber);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06017316 RID: 94998 RVA: 0x00645A5C File Offset: 0x00643C5C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_armyRandomNumber(IntPtr l)
	{
		int result;
		try
		{
			BattleBase battleBase = (BattleBase)LuaObject.checkSelf(l);
			RandomNumber armyRandomNumber;
			LuaObject.checkType<RandomNumber>(l, 2, out armyRandomNumber);
			battleBase.m_luaExportHelper.m_armyRandomNumber = armyRandomNumber;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06017317 RID: 94999 RVA: 0x00645AB8 File Offset: 0x00643CB8
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_m_map(IntPtr l)
	{
		int result;
		try
		{
			BattleBase battleBase = (BattleBase)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, battleBase.m_luaExportHelper.m_map);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06017318 RID: 95000 RVA: 0x00645B10 File Offset: 0x00643D10
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_map(IntPtr l)
	{
		int result;
		try
		{
			BattleBase battleBase = (BattleBase)LuaObject.checkSelf(l);
			BattleMap map;
			LuaObject.checkType<BattleMap>(l, 2, out map);
			battleBase.m_luaExportHelper.m_map = map;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06017319 RID: 95001 RVA: 0x00645B6C File Offset: 0x00643D6C
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_m_pathfinder(IntPtr l)
	{
		int result;
		try
		{
			BattleBase battleBase = (BattleBase)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, battleBase.m_luaExportHelper.m_pathfinder);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601731A RID: 95002 RVA: 0x00645BC4 File Offset: 0x00643DC4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_pathfinder(IntPtr l)
	{
		int result;
		try
		{
			BattleBase battleBase = (BattleBase)LuaObject.checkSelf(l);
			Pathfinder pathfinder;
			LuaObject.checkType<Pathfinder>(l, 2, out pathfinder);
			battleBase.m_luaExportHelper.m_pathfinder = pathfinder;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601731B RID: 95003 RVA: 0x00645C20 File Offset: 0x00643E20
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_m_combat(IntPtr l)
	{
		int result;
		try
		{
			BattleBase battleBase = (BattleBase)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, battleBase.m_luaExportHelper.m_combat);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601731C RID: 95004 RVA: 0x00645C78 File Offset: 0x00643E78
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_combat(IntPtr l)
	{
		int result;
		try
		{
			BattleBase battleBase = (BattleBase)LuaObject.checkSelf(l);
			Combat combat;
			LuaObject.checkType<Combat>(l, 2, out combat);
			battleBase.m_luaExportHelper.m_combat = combat;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601731D RID: 95005 RVA: 0x00645CD4 File Offset: 0x00643ED4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_battlefieldInfo(IntPtr l)
	{
		int result;
		try
		{
			BattleBase battleBase = (BattleBase)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, battleBase.m_luaExportHelper.m_battlefieldInfo);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601731E RID: 95006 RVA: 0x00645D2C File Offset: 0x00643F2C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_battlefieldInfo(IntPtr l)
	{
		int result;
		try
		{
			BattleBase battleBase = (BattleBase)LuaObject.checkSelf(l);
			ConfigDataBattlefieldInfo battlefieldInfo;
			LuaObject.checkType<ConfigDataBattlefieldInfo>(l, 2, out battlefieldInfo);
			battleBase.m_luaExportHelper.m_battlefieldInfo = battlefieldInfo;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601731F RID: 95007 RVA: 0x00645D88 File Offset: 0x00643F88
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_battleInfo(IntPtr l)
	{
		int result;
		try
		{
			BattleBase battleBase = (BattleBase)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, battleBase.m_luaExportHelper.m_battleInfo);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06017320 RID: 95008 RVA: 0x00645DE0 File Offset: 0x00643FE0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_battleInfo(IntPtr l)
	{
		int result;
		try
		{
			BattleBase battleBase = (BattleBase)LuaObject.checkSelf(l);
			ConfigDataBattleInfo battleInfo;
			LuaObject.checkType<ConfigDataBattleInfo>(l, 2, out battleInfo);
			battleBase.m_luaExportHelper.m_battleInfo = battleInfo;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06017321 RID: 95009 RVA: 0x00645E3C File Offset: 0x0064403C
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_m_arenaBattleInfo(IntPtr l)
	{
		int result;
		try
		{
			BattleBase battleBase = (BattleBase)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, battleBase.m_luaExportHelper.m_arenaBattleInfo);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06017322 RID: 95010 RVA: 0x00645E94 File Offset: 0x00644094
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_arenaBattleInfo(IntPtr l)
	{
		int result;
		try
		{
			BattleBase battleBase = (BattleBase)LuaObject.checkSelf(l);
			ConfigDataArenaBattleInfo arenaBattleInfo;
			LuaObject.checkType<ConfigDataArenaBattleInfo>(l, 2, out arenaBattleInfo);
			battleBase.m_luaExportHelper.m_arenaBattleInfo = arenaBattleInfo;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06017323 RID: 95011 RVA: 0x00645EF0 File Offset: 0x006440F0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_pvpBattleInfo(IntPtr l)
	{
		int result;
		try
		{
			BattleBase battleBase = (BattleBase)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, battleBase.m_luaExportHelper.m_pvpBattleInfo);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06017324 RID: 95012 RVA: 0x00645F48 File Offset: 0x00644148
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_pvpBattleInfo(IntPtr l)
	{
		int result;
		try
		{
			BattleBase battleBase = (BattleBase)LuaObject.checkSelf(l);
			ConfigDataPVPBattleInfo pvpBattleInfo;
			LuaObject.checkType<ConfigDataPVPBattleInfo>(l, 2, out pvpBattleInfo);
			battleBase.m_luaExportHelper.m_pvpBattleInfo = pvpBattleInfo;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06017325 RID: 95013 RVA: 0x00645FA4 File Offset: 0x006441A4
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_m_realtimePvpBattleInfo(IntPtr l)
	{
		int result;
		try
		{
			BattleBase battleBase = (BattleBase)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, battleBase.m_luaExportHelper.m_realtimePvpBattleInfo);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06017326 RID: 95014 RVA: 0x00645FFC File Offset: 0x006441FC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_realtimePvpBattleInfo(IntPtr l)
	{
		int result;
		try
		{
			BattleBase battleBase = (BattleBase)LuaObject.checkSelf(l);
			ConfigDataRealTimePVPBattleInfo realtimePvpBattleInfo;
			LuaObject.checkType<ConfigDataRealTimePVPBattleInfo>(l, 2, out realtimePvpBattleInfo);
			battleBase.m_luaExportHelper.m_realtimePvpBattleInfo = realtimePvpBattleInfo;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06017327 RID: 95015 RVA: 0x00646058 File Offset: 0x00644258
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_battleType(IntPtr l)
	{
		int result;
		try
		{
			BattleBase battleBase = (BattleBase)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushEnum(l, (int)battleBase.m_luaExportHelper.m_battleType);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06017328 RID: 95016 RVA: 0x006460B0 File Offset: 0x006442B0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_battleType(IntPtr l)
	{
		int result;
		try
		{
			BattleBase battleBase = (BattleBase)LuaObject.checkSelf(l);
			BattleType battleType;
			LuaObject.checkEnum<BattleType>(l, 2, out battleType);
			battleBase.m_luaExportHelper.m_battleType = battleType;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06017329 RID: 95017 RVA: 0x0064610C File Offset: 0x0064430C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_monsterLevel(IntPtr l)
	{
		int result;
		try
		{
			BattleBase battleBase = (BattleBase)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, battleBase.m_luaExportHelper.m_monsterLevel);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601732A RID: 95018 RVA: 0x00646164 File Offset: 0x00644364
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_monsterLevel(IntPtr l)
	{
		int result;
		try
		{
			BattleBase battleBase = (BattleBase)LuaObject.checkSelf(l);
			int monsterLevel;
			LuaObject.checkType(l, 2, out monsterLevel);
			battleBase.m_luaExportHelper.m_monsterLevel = monsterLevel;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601732B RID: 95019 RVA: 0x006461C0 File Offset: 0x006443C0
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_m_teams(IntPtr l)
	{
		int result;
		try
		{
			BattleBase battleBase = (BattleBase)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, battleBase.m_luaExportHelper.m_teams);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601732C RID: 95020 RVA: 0x00646218 File Offset: 0x00644418
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_teams(IntPtr l)
	{
		int result;
		try
		{
			BattleBase battleBase = (BattleBase)LuaObject.checkSelf(l);
			BattleTeam[] teams;
			LuaObject.checkArray<BattleTeam>(l, 2, out teams);
			battleBase.m_luaExportHelper.m_teams = teams;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601732D RID: 95021 RVA: 0x00646274 File Offset: 0x00644474
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_players(IntPtr l)
	{
		int result;
		try
		{
			BattleBase battleBase = (BattleBase)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, battleBase.m_luaExportHelper.m_players);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601732E RID: 95022 RVA: 0x006462CC File Offset: 0x006444CC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_players(IntPtr l)
	{
		int result;
		try
		{
			BattleBase battleBase = (BattleBase)LuaObject.checkSelf(l);
			BattlePlayer[] players;
			LuaObject.checkArray<BattlePlayer>(l, 2, out players);
			battleBase.m_luaExportHelper.m_players = players;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601732F RID: 95023 RVA: 0x00646328 File Offset: 0x00644528
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_m_maxPlayerLevelInfo(IntPtr l)
	{
		int result;
		try
		{
			BattleBase battleBase = (BattleBase)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, battleBase.m_luaExportHelper.m_maxPlayerLevelInfo);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06017330 RID: 95024 RVA: 0x00646380 File Offset: 0x00644580
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_m_maxPlayerLevelInfo(IntPtr l)
	{
		int result;
		try
		{
			BattleBase battleBase = (BattleBase)LuaObject.checkSelf(l);
			ConfigDataPlayerLevelInfo maxPlayerLevelInfo;
			LuaObject.checkType<ConfigDataPlayerLevelInfo>(l, 2, out maxPlayerLevelInfo);
			battleBase.m_luaExportHelper.m_maxPlayerLevelInfo = maxPlayerLevelInfo;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06017331 RID: 95025 RVA: 0x006463DC File Offset: 0x006445DC
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_m_state(IntPtr l)
	{
		int result;
		try
		{
			BattleBase battleBase = (BattleBase)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushEnum(l, (int)battleBase.m_luaExportHelper.m_state);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06017332 RID: 95026 RVA: 0x00646434 File Offset: 0x00644634
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_state(IntPtr l)
	{
		int result;
		try
		{
			BattleBase battleBase = (BattleBase)LuaObject.checkSelf(l);
			BattleState state;
			LuaObject.checkEnum<BattleState>(l, 2, out state);
			battleBase.m_luaExportHelper.m_state = state;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06017333 RID: 95027 RVA: 0x00646490 File Offset: 0x00644690
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_step(IntPtr l)
	{
		int result;
		try
		{
			BattleBase battleBase = (BattleBase)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, battleBase.m_luaExportHelper.m_step);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06017334 RID: 95028 RVA: 0x006464E8 File Offset: 0x006446E8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_step(IntPtr l)
	{
		int result;
		try
		{
			BattleBase battleBase = (BattleBase)LuaObject.checkSelf(l);
			int step;
			LuaObject.checkType(l, 2, out step);
			battleBase.m_luaExportHelper.m_step = step;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06017335 RID: 95029 RVA: 0x00646544 File Offset: 0x00644744
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_turn(IntPtr l)
	{
		int result;
		try
		{
			BattleBase battleBase = (BattleBase)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, battleBase.m_luaExportHelper.m_turn);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06017336 RID: 95030 RVA: 0x0064659C File Offset: 0x0064479C
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_m_turn(IntPtr l)
	{
		int result;
		try
		{
			BattleBase battleBase = (BattleBase)LuaObject.checkSelf(l);
			int turn;
			LuaObject.checkType(l, 2, out turn);
			battleBase.m_luaExportHelper.m_turn = turn;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06017337 RID: 95031 RVA: 0x006465F8 File Offset: 0x006447F8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_turnMax(IntPtr l)
	{
		int result;
		try
		{
			BattleBase battleBase = (BattleBase)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, battleBase.m_luaExportHelper.m_turnMax);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06017338 RID: 95032 RVA: 0x00646650 File Offset: 0x00644850
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_turnMax(IntPtr l)
	{
		int result;
		try
		{
			BattleBase battleBase = (BattleBase)LuaObject.checkSelf(l);
			int turnMax;
			LuaObject.checkType(l, 2, out turnMax);
			battleBase.m_luaExportHelper.m_turnMax = turnMax;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06017339 RID: 95033 RVA: 0x006466AC File Offset: 0x006448AC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_actionTeam(IntPtr l)
	{
		int result;
		try
		{
			BattleBase battleBase = (BattleBase)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, battleBase.m_luaExportHelper.m_actionTeam);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601733A RID: 95034 RVA: 0x00646704 File Offset: 0x00644904
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_actionTeam(IntPtr l)
	{
		int result;
		try
		{
			BattleBase battleBase = (BattleBase)LuaObject.checkSelf(l);
			int actionTeam;
			LuaObject.checkType(l, 2, out actionTeam);
			battleBase.m_luaExportHelper.m_actionTeam = actionTeam;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601733B RID: 95035 RVA: 0x00646760 File Offset: 0x00644960
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_prevActionPlayerIndex(IntPtr l)
	{
		int result;
		try
		{
			BattleBase battleBase = (BattleBase)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, battleBase.m_luaExportHelper.m_prevActionPlayerIndex);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601733C RID: 95036 RVA: 0x006467B8 File Offset: 0x006449B8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_prevActionPlayerIndex(IntPtr l)
	{
		int result;
		try
		{
			BattleBase battleBase = (BattleBase)LuaObject.checkSelf(l);
			int prevActionPlayerIndex;
			LuaObject.checkType(l, 2, out prevActionPlayerIndex);
			battleBase.m_luaExportHelper.m_prevActionPlayerIndex = prevActionPlayerIndex;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601733D RID: 95037 RVA: 0x00646814 File Offset: 0x00644A14
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_m_actionActor(IntPtr l)
	{
		int result;
		try
		{
			BattleBase battleBase = (BattleBase)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, battleBase.m_luaExportHelper.m_actionActor);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601733E RID: 95038 RVA: 0x0064686C File Offset: 0x00644A6C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_actionActor(IntPtr l)
	{
		int result;
		try
		{
			BattleBase battleBase = (BattleBase)LuaObject.checkSelf(l);
			BattleActor actionActor;
			LuaObject.checkType<BattleActor>(l, 2, out actionActor);
			battleBase.m_luaExportHelper.m_actionActor = actionActor;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601733F RID: 95039 RVA: 0x006468C8 File Offset: 0x00644AC8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_actionOrderType(IntPtr l)
	{
		int result;
		try
		{
			BattleBase battleBase = (BattleBase)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushEnum(l, (int)battleBase.m_luaExportHelper.m_actionOrderType);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06017340 RID: 95040 RVA: 0x00646920 File Offset: 0x00644B20
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_actionOrderType(IntPtr l)
	{
		int result;
		try
		{
			BattleBase battleBase = (BattleBase)LuaObject.checkSelf(l);
			ActionOrderType actionOrderType;
			LuaObject.checkEnum<ActionOrderType>(l, 2, out actionOrderType);
			battleBase.m_luaExportHelper.m_actionOrderType = actionOrderType;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06017341 RID: 95041 RVA: 0x0064697C File Offset: 0x00644B7C
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_m_entityIdCounter(IntPtr l)
	{
		int result;
		try
		{
			BattleBase battleBase = (BattleBase)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, battleBase.m_luaExportHelper.m_entityIdCounter);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06017342 RID: 95042 RVA: 0x006469D4 File Offset: 0x00644BD4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_entityIdCounter(IntPtr l)
	{
		int result;
		try
		{
			BattleBase battleBase = (BattleBase)LuaObject.checkSelf(l);
			int entityIdCounter;
			LuaObject.checkType(l, 2, out entityIdCounter);
			battleBase.m_luaExportHelper.m_entityIdCounter = entityIdCounter;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06017343 RID: 95043 RVA: 0x00646A30 File Offset: 0x00644C30
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_needCheckBattleStopEventTrigger(IntPtr l)
	{
		int result;
		try
		{
			BattleBase battleBase = (BattleBase)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, battleBase.m_luaExportHelper.m_needCheckBattleStopEventTrigger);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06017344 RID: 95044 RVA: 0x00646A88 File Offset: 0x00644C88
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_m_needCheckBattleStopEventTrigger(IntPtr l)
	{
		int result;
		try
		{
			BattleBase battleBase = (BattleBase)LuaObject.checkSelf(l);
			bool needCheckBattleStopEventTrigger;
			LuaObject.checkType(l, 2, out needCheckBattleStopEventTrigger);
			battleBase.m_luaExportHelper.m_needCheckBattleStopEventTrigger = needCheckBattleStopEventTrigger;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06017345 RID: 95045 RVA: 0x00646AE4 File Offset: 0x00644CE4
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_m_isGiveupBattle(IntPtr l)
	{
		int result;
		try
		{
			BattleBase battleBase = (BattleBase)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, battleBase.m_luaExportHelper.m_isGiveupBattle);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06017346 RID: 95046 RVA: 0x00646B3C File Offset: 0x00644D3C
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_m_isGiveupBattle(IntPtr l)
	{
		int result;
		try
		{
			BattleBase battleBase = (BattleBase)LuaObject.checkSelf(l);
			bool isGiveupBattle;
			LuaObject.checkType(l, 2, out isGiveupBattle);
			battleBase.m_luaExportHelper.m_isGiveupBattle = isGiveupBattle;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06017347 RID: 95047 RVA: 0x00646B98 File Offset: 0x00644D98
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_m_giveupBattlePlayerIndex(IntPtr l)
	{
		int result;
		try
		{
			BattleBase battleBase = (BattleBase)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, battleBase.m_luaExportHelper.m_giveupBattlePlayerIndex);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06017348 RID: 95048 RVA: 0x00646BF0 File Offset: 0x00644DF0
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_m_giveupBattlePlayerIndex(IntPtr l)
	{
		int result;
		try
		{
			BattleBase battleBase = (BattleBase)LuaObject.checkSelf(l);
			int giveupBattlePlayerIndex;
			LuaObject.checkType(l, 2, out giveupBattlePlayerIndex);
			battleBase.m_luaExportHelper.m_giveupBattlePlayerIndex = giveupBattlePlayerIndex;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06017349 RID: 95049 RVA: 0x00646C4C File Offset: 0x00644E4C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_combatRandomSeed(IntPtr l)
	{
		int result;
		try
		{
			BattleBase battleBase = (BattleBase)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, battleBase.m_luaExportHelper.m_combatRandomSeed);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601734A RID: 95050 RVA: 0x00646CA4 File Offset: 0x00644EA4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_combatRandomSeed(IntPtr l)
	{
		int result;
		try
		{
			BattleBase battleBase = (BattleBase)LuaObject.checkSelf(l);
			int combatRandomSeed;
			LuaObject.checkType(l, 2, out combatRandomSeed);
			battleBase.m_luaExportHelper.m_combatRandomSeed = combatRandomSeed;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601734B RID: 95051 RVA: 0x00646D00 File Offset: 0x00644F00
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_combatActorA(IntPtr l)
	{
		int result;
		try
		{
			BattleBase battleBase = (BattleBase)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, battleBase.m_luaExportHelper.m_combatActorA);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601734C RID: 95052 RVA: 0x00646D58 File Offset: 0x00644F58
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_m_combatActorA(IntPtr l)
	{
		int result;
		try
		{
			BattleBase battleBase = (BattleBase)LuaObject.checkSelf(l);
			BattleActor combatActorA;
			LuaObject.checkType<BattleActor>(l, 2, out combatActorA);
			battleBase.m_luaExportHelper.m_combatActorA = combatActorA;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601734D RID: 95053 RVA: 0x00646DB4 File Offset: 0x00644FB4
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_m_combatActorB(IntPtr l)
	{
		int result;
		try
		{
			BattleBase battleBase = (BattleBase)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, battleBase.m_luaExportHelper.m_combatActorB);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601734E RID: 95054 RVA: 0x00646E0C File Offset: 0x0064500C
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_m_combatActorB(IntPtr l)
	{
		int result;
		try
		{
			BattleBase battleBase = (BattleBase)LuaObject.checkSelf(l);
			BattleActor combatActorB;
			LuaObject.checkType<BattleActor>(l, 2, out combatActorB);
			battleBase.m_luaExportHelper.m_combatActorB = combatActorB;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601734F RID: 95055 RVA: 0x00646E68 File Offset: 0x00645068
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_m_combatSkillInfoA(IntPtr l)
	{
		int result;
		try
		{
			BattleBase battleBase = (BattleBase)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, battleBase.m_luaExportHelper.m_combatSkillInfoA);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06017350 RID: 95056 RVA: 0x00646EC0 File Offset: 0x006450C0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_combatSkillInfoA(IntPtr l)
	{
		int result;
		try
		{
			BattleBase battleBase = (BattleBase)LuaObject.checkSelf(l);
			ConfigDataSkillInfo combatSkillInfoA;
			LuaObject.checkType<ConfigDataSkillInfo>(l, 2, out combatSkillInfoA);
			battleBase.m_luaExportHelper.m_combatSkillInfoA = combatSkillInfoA;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06017351 RID: 95057 RVA: 0x00646F1C File Offset: 0x0064511C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_beGuardedCombatActor(IntPtr l)
	{
		int result;
		try
		{
			BattleBase battleBase = (BattleBase)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, battleBase.m_luaExportHelper.m_beGuardedCombatActor);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06017352 RID: 95058 RVA: 0x00646F74 File Offset: 0x00645174
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_m_beGuardedCombatActor(IntPtr l)
	{
		int result;
		try
		{
			BattleBase battleBase = (BattleBase)LuaObject.checkSelf(l);
			BattleActor beGuardedCombatActor;
			LuaObject.checkType<BattleActor>(l, 2, out beGuardedCombatActor);
			battleBase.m_luaExportHelper.m_beGuardedCombatActor = beGuardedCombatActor;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06017353 RID: 95059 RVA: 0x00646FD0 File Offset: 0x006451D0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_isPerformCombat(IntPtr l)
	{
		int result;
		try
		{
			BattleBase battleBase = (BattleBase)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, battleBase.m_luaExportHelper.m_isPerformCombat);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06017354 RID: 95060 RVA: 0x00647028 File Offset: 0x00645228
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_isPerformCombat(IntPtr l)
	{
		int result;
		try
		{
			BattleBase battleBase = (BattleBase)LuaObject.checkSelf(l);
			bool isPerformCombat;
			LuaObject.checkType(l, 2, out isPerformCombat);
			battleBase.m_luaExportHelper.m_isPerformCombat = isPerformCombat;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06017355 RID: 95061 RVA: 0x00647084 File Offset: 0x00645284
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_afterComatPerform(IntPtr l)
	{
		int result;
		try
		{
			BattleBase battleBase = (BattleBase)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, battleBase.m_luaExportHelper.m_afterComatPerform);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06017356 RID: 95062 RVA: 0x006470DC File Offset: 0x006452DC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_afterComatPerform(IntPtr l)
	{
		int result;
		try
		{
			BattleBase battleBase = (BattleBase)LuaObject.checkSelf(l);
			ConfigDataBattlePerformInfo afterComatPerform;
			LuaObject.checkType<ConfigDataBattlePerformInfo>(l, 2, out afterComatPerform);
			battleBase.m_luaExportHelper.m_afterComatPerform = afterComatPerform;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06017357 RID: 95063 RVA: 0x00647138 File Offset: 0x00645338
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_m_afterCombatExecuteTriggerState(IntPtr l)
	{
		int result;
		try
		{
			BattleBase battleBase = (BattleBase)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, battleBase.m_luaExportHelper.m_afterCombatExecuteTriggerState);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06017358 RID: 95064 RVA: 0x00647190 File Offset: 0x00645390
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_afterCombatExecuteTriggerState(IntPtr l)
	{
		int result;
		try
		{
			BattleBase battleBase = (BattleBase)LuaObject.checkSelf(l);
			BattleEventTriggerState afterCombatExecuteTriggerState;
			LuaObject.checkType<BattleEventTriggerState>(l, 2, out afterCombatExecuteTriggerState);
			battleBase.m_luaExportHelper.m_afterCombatExecuteTriggerState = afterCombatExecuteTriggerState;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06017359 RID: 95065 RVA: 0x006471EC File Offset: 0x006453EC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_afterCombatExecuteTriggerEventActionIndex(IntPtr l)
	{
		int result;
		try
		{
			BattleBase battleBase = (BattleBase)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, battleBase.m_luaExportHelper.m_afterCombatExecuteTriggerEventActionIndex);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601735A RID: 95066 RVA: 0x00647244 File Offset: 0x00645444
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_afterCombatExecuteTriggerEventActionIndex(IntPtr l)
	{
		int result;
		try
		{
			BattleBase battleBase = (BattleBase)LuaObject.checkSelf(l);
			int afterCombatExecuteTriggerEventActionIndex;
			LuaObject.checkType(l, 2, out afterCombatExecuteTriggerEventActionIndex);
			battleBase.m_luaExportHelper.m_afterCombatExecuteTriggerEventActionIndex = afterCombatExecuteTriggerEventActionIndex;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601735B RID: 95067 RVA: 0x006472A0 File Offset: 0x006454A0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_isAfterCombatNextStep(IntPtr l)
	{
		int result;
		try
		{
			BattleBase battleBase = (BattleBase)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, battleBase.m_luaExportHelper.m_isAfterCombatNextStep);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601735C RID: 95068 RVA: 0x006472F8 File Offset: 0x006454F8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_isAfterCombatNextStep(IntPtr l)
	{
		int result;
		try
		{
			BattleBase battleBase = (BattleBase)LuaObject.checkSelf(l);
			bool isAfterCombatNextStep;
			LuaObject.checkType(l, 2, out isAfterCombatNextStep);
			battleBase.m_luaExportHelper.m_isAfterCombatNextStep = isAfterCombatNextStep;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601735D RID: 95069 RVA: 0x00647354 File Offset: 0x00645554
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_isAfterCombatNextStepActorActive(IntPtr l)
	{
		int result;
		try
		{
			BattleBase battleBase = (BattleBase)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, battleBase.m_luaExportHelper.m_isAfterCombatNextStepActorActive);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601735E RID: 95070 RVA: 0x006473AC File Offset: 0x006455AC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_isAfterCombatNextStepActorActive(IntPtr l)
	{
		int result;
		try
		{
			BattleBase battleBase = (BattleBase)LuaObject.checkSelf(l);
			bool isAfterCombatNextStepActorActive;
			LuaObject.checkType(l, 2, out isAfterCombatNextStepActorActive);
			battleBase.m_luaExportHelper.m_isAfterCombatNextStepActorActive = isAfterCombatNextStepActorActive;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601735F RID: 95071 RVA: 0x00647408 File Offset: 0x00645608
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_tempIntLists(IntPtr l)
	{
		int result;
		try
		{
			BattleBase battleBase = (BattleBase)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, battleBase.m_luaExportHelper.m_tempIntLists);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06017360 RID: 95072 RVA: 0x00647460 File Offset: 0x00645660
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_tempIntLists(IntPtr l)
	{
		int result;
		try
		{
			BattleBase battleBase = (BattleBase)LuaObject.checkSelf(l);
			List<int>[] tempIntLists;
			LuaObject.checkArray<List<int>>(l, 2, out tempIntLists);
			battleBase.m_luaExportHelper.m_tempIntLists = tempIntLists;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06017361 RID: 95073 RVA: 0x006474BC File Offset: 0x006456BC
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_m_freeIntListIndex(IntPtr l)
	{
		int result;
		try
		{
			BattleBase battleBase = (BattleBase)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, battleBase.m_luaExportHelper.m_freeIntListIndex);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06017362 RID: 95074 RVA: 0x00647514 File Offset: 0x00645714
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_m_freeIntListIndex(IntPtr l)
	{
		int result;
		try
		{
			BattleBase battleBase = (BattleBase)LuaObject.checkSelf(l);
			int freeIntListIndex;
			LuaObject.checkType(l, 2, out freeIntListIndex);
			battleBase.m_luaExportHelper.m_freeIntListIndex = freeIntListIndex;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06017363 RID: 95075 RVA: 0x00647570 File Offset: 0x00645770
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_tempGridPositionLists(IntPtr l)
	{
		int result;
		try
		{
			BattleBase battleBase = (BattleBase)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, battleBase.m_luaExportHelper.m_tempGridPositionLists);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06017364 RID: 95076 RVA: 0x006475C8 File Offset: 0x006457C8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_tempGridPositionLists(IntPtr l)
	{
		int result;
		try
		{
			BattleBase battleBase = (BattleBase)LuaObject.checkSelf(l);
			List<GridPosition>[] tempGridPositionLists;
			LuaObject.checkArray<List<GridPosition>>(l, 2, out tempGridPositionLists);
			battleBase.m_luaExportHelper.m_tempGridPositionLists = tempGridPositionLists;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06017365 RID: 95077 RVA: 0x00647624 File Offset: 0x00645824
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_m_freeGridPositionListIndex(IntPtr l)
	{
		int result;
		try
		{
			BattleBase battleBase = (BattleBase)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, battleBase.m_luaExportHelper.m_freeGridPositionListIndex);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06017366 RID: 95078 RVA: 0x0064767C File Offset: 0x0064587C
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_m_freeGridPositionListIndex(IntPtr l)
	{
		int result;
		try
		{
			BattleBase battleBase = (BattleBase)LuaObject.checkSelf(l);
			int freeGridPositionListIndex;
			LuaObject.checkType(l, 2, out freeGridPositionListIndex);
			battleBase.m_luaExportHelper.m_freeGridPositionListIndex = freeGridPositionListIndex;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06017367 RID: 95079 RVA: 0x006476D8 File Offset: 0x006458D8
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_m_tempActorLists(IntPtr l)
	{
		int result;
		try
		{
			BattleBase battleBase = (BattleBase)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, battleBase.m_luaExportHelper.m_tempActorLists);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06017368 RID: 95080 RVA: 0x00647730 File Offset: 0x00645930
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_tempActorLists(IntPtr l)
	{
		int result;
		try
		{
			BattleBase battleBase = (BattleBase)LuaObject.checkSelf(l);
			List<BattleActor>[] tempActorLists;
			LuaObject.checkArray<List<BattleActor>>(l, 2, out tempActorLists);
			battleBase.m_luaExportHelper.m_tempActorLists = tempActorLists;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06017369 RID: 95081 RVA: 0x0064778C File Offset: 0x0064598C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_freeActorListIndex(IntPtr l)
	{
		int result;
		try
		{
			BattleBase battleBase = (BattleBase)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, battleBase.m_luaExportHelper.m_freeActorListIndex);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601736A RID: 95082 RVA: 0x006477E4 File Offset: 0x006459E4
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_m_freeActorListIndex(IntPtr l)
	{
		int result;
		try
		{
			BattleBase battleBase = (BattleBase)LuaObject.checkSelf(l);
			int freeActorListIndex;
			LuaObject.checkType(l, 2, out freeActorListIndex);
			battleBase.m_luaExportHelper.m_freeActorListIndex = freeActorListIndex;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601736B RID: 95083 RVA: 0x00647840 File Offset: 0x00645A40
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_tempBuffLists(IntPtr l)
	{
		int result;
		try
		{
			BattleBase battleBase = (BattleBase)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, battleBase.m_luaExportHelper.m_tempBuffLists);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601736C RID: 95084 RVA: 0x00647898 File Offset: 0x00645A98
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_tempBuffLists(IntPtr l)
	{
		int result;
		try
		{
			BattleBase battleBase = (BattleBase)LuaObject.checkSelf(l);
			List<ConfigDataBuffInfo>[] tempBuffLists;
			LuaObject.checkArray<List<ConfigDataBuffInfo>>(l, 2, out tempBuffLists);
			battleBase.m_luaExportHelper.m_tempBuffLists = tempBuffLists;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601736D RID: 95085 RVA: 0x006478F4 File Offset: 0x00645AF4
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_m_freeBuffListIndex(IntPtr l)
	{
		int result;
		try
		{
			BattleBase battleBase = (BattleBase)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, battleBase.m_luaExportHelper.m_freeBuffListIndex);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601736E RID: 95086 RVA: 0x0064794C File Offset: 0x00645B4C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_freeBuffListIndex(IntPtr l)
	{
		int result;
		try
		{
			BattleBase battleBase = (BattleBase)LuaObject.checkSelf(l);
			int freeBuffListIndex;
			LuaObject.checkType(l, 2, out freeBuffListIndex);
			battleBase.m_luaExportHelper.m_freeBuffListIndex = freeBuffListIndex;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601736F RID: 95087 RVA: 0x006479A8 File Offset: 0x00645BA8
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_m_tempBuffStateLists(IntPtr l)
	{
		int result;
		try
		{
			BattleBase battleBase = (BattleBase)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, battleBase.m_luaExportHelper.m_tempBuffStateLists);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06017370 RID: 95088 RVA: 0x00647A00 File Offset: 0x00645C00
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_m_tempBuffStateLists(IntPtr l)
	{
		int result;
		try
		{
			BattleBase battleBase = (BattleBase)LuaObject.checkSelf(l);
			List<BuffState>[] tempBuffStateLists;
			LuaObject.checkArray<List<BuffState>>(l, 2, out tempBuffStateLists);
			battleBase.m_luaExportHelper.m_tempBuffStateLists = tempBuffStateLists;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06017371 RID: 95089 RVA: 0x00647A5C File Offset: 0x00645C5C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_freeBuffStateListIndex(IntPtr l)
	{
		int result;
		try
		{
			BattleBase battleBase = (BattleBase)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, battleBase.m_luaExportHelper.m_freeBuffStateListIndex);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06017372 RID: 95090 RVA: 0x00647AB4 File Offset: 0x00645CB4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_freeBuffStateListIndex(IntPtr l)
	{
		int result;
		try
		{
			BattleBase battleBase = (BattleBase)LuaObject.checkSelf(l);
			int freeBuffStateListIndex;
			LuaObject.checkType(l, 2, out freeBuffStateListIndex);
			battleBase.m_luaExportHelper.m_freeBuffStateListIndex = freeBuffStateListIndex;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06017373 RID: 95091 RVA: 0x00647B10 File Offset: 0x00645D10
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_m_tempBattlePropertyModifier(IntPtr l)
	{
		int result;
		try
		{
			BattleBase battleBase = (BattleBase)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, battleBase.m_luaExportHelper.m_tempBattlePropertyModifier);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06017374 RID: 95092 RVA: 0x00647B68 File Offset: 0x00645D68
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_m_tempBattlePropertyModifier(IntPtr l)
	{
		int result;
		try
		{
			BattleBase battleBase = (BattleBase)LuaObject.checkSelf(l);
			BattlePropertyModifier tempBattlePropertyModifier;
			LuaObject.checkType<BattlePropertyModifier>(l, 2, out tempBattlePropertyModifier);
			battleBase.m_luaExportHelper.m_tempBattlePropertyModifier = tempBattlePropertyModifier;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06017375 RID: 95093 RVA: 0x00647BC4 File Offset: 0x00645DC4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_battleCommands(IntPtr l)
	{
		int result;
		try
		{
			BattleBase battleBase = (BattleBase)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, battleBase.m_luaExportHelper.m_battleCommands);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06017376 RID: 95094 RVA: 0x00647C1C File Offset: 0x00645E1C
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_m_battleCommands(IntPtr l)
	{
		int result;
		try
		{
			BattleBase battleBase = (BattleBase)LuaObject.checkSelf(l);
			LinkedList<BattleCommand> battleCommands;
			LuaObject.checkType<LinkedList<BattleCommand>>(l, 2, out battleCommands);
			battleBase.m_luaExportHelper.m_battleCommands = battleCommands;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06017377 RID: 95095 RVA: 0x00647C78 File Offset: 0x00645E78
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_logBattleCommands(IntPtr l)
	{
		int result;
		try
		{
			BattleBase battleBase = (BattleBase)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, battleBase.m_luaExportHelper.m_logBattleCommands);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06017378 RID: 95096 RVA: 0x00647CD0 File Offset: 0x00645ED0
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_m_logBattleCommands(IntPtr l)
	{
		int result;
		try
		{
			BattleBase battleBase = (BattleBase)LuaObject.checkSelf(l);
			LinkedList<BattleCommand> logBattleCommands;
			LuaObject.checkType<LinkedList<BattleCommand>>(l, 2, out logBattleCommands);
			battleBase.m_luaExportHelper.m_logBattleCommands = logBattleCommands;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06017379 RID: 95097 RVA: 0x00647D2C File Offset: 0x00645F2C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_tempBattleCommands(IntPtr l)
	{
		int result;
		try
		{
			BattleBase battleBase = (BattleBase)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, battleBase.m_luaExportHelper.m_tempBattleCommands);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601737A RID: 95098 RVA: 0x00647D84 File Offset: 0x00645F84
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_m_tempBattleCommands(IntPtr l)
	{
		int result;
		try
		{
			BattleBase battleBase = (BattleBase)LuaObject.checkSelf(l);
			LinkedList<BattleCommand> tempBattleCommands;
			LuaObject.checkType<LinkedList<BattleCommand>>(l, 2, out tempBattleCommands);
			battleBase.m_luaExportHelper.m_tempBattleCommands = tempBattleCommands;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601737B RID: 95099 RVA: 0x00647DE0 File Offset: 0x00645FE0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_stepExecutedCommands(IntPtr l)
	{
		int result;
		try
		{
			BattleBase battleBase = (BattleBase)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, battleBase.m_luaExportHelper.m_stepExecutedCommands);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601737C RID: 95100 RVA: 0x00647E38 File Offset: 0x00646038
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_stepExecutedCommands(IntPtr l)
	{
		int result;
		try
		{
			BattleBase battleBase = (BattleBase)LuaObject.checkSelf(l);
			List<BattleCommand> stepExecutedCommands;
			LuaObject.checkType<List<BattleCommand>>(l, 2, out stepExecutedCommands);
			battleBase.m_luaExportHelper.m_stepExecutedCommands = stepExecutedCommands;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601737D RID: 95101 RVA: 0x00647E94 File Offset: 0x00646094
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_enableLogBattleCommands(IntPtr l)
	{
		int result;
		try
		{
			BattleBase battleBase = (BattleBase)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, battleBase.m_luaExportHelper.m_enableLogBattleCommands);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601737E RID: 95102 RVA: 0x00647EEC File Offset: 0x006460EC
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_m_enableLogBattleCommands(IntPtr l)
	{
		int result;
		try
		{
			BattleBase battleBase = (BattleBase)LuaObject.checkSelf(l);
			bool enableLogBattleCommands;
			LuaObject.checkType(l, 2, out enableLogBattleCommands);
			battleBase.m_luaExportHelper.m_enableLogBattleCommands = enableLogBattleCommands;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601737F RID: 95103 RVA: 0x00647F48 File Offset: 0x00646148
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_enableTempBattleCommands(IntPtr l)
	{
		int result;
		try
		{
			BattleBase battleBase = (BattleBase)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, battleBase.m_luaExportHelper.m_enableTempBattleCommands);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06017380 RID: 95104 RVA: 0x00647FA0 File Offset: 0x006461A0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_enableTempBattleCommands(IntPtr l)
	{
		int result;
		try
		{
			BattleBase battleBase = (BattleBase)LuaObject.checkSelf(l);
			bool enableTempBattleCommands;
			LuaObject.checkType(l, 2, out enableTempBattleCommands);
			battleBase.m_luaExportHelper.m_enableTempBattleCommands = enableTempBattleCommands;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06017381 RID: 95105 RVA: 0x00647FFC File Offset: 0x006461FC
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_m_enableDebugLog(IntPtr l)
	{
		int result;
		try
		{
			BattleBase battleBase = (BattleBase)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, battleBase.m_luaExportHelper.m_enableDebugLog);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06017382 RID: 95106 RVA: 0x00648054 File Offset: 0x00646254
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_enableDebugLog(IntPtr l)
	{
		int result;
		try
		{
			BattleBase battleBase = (BattleBase)LuaObject.checkSelf(l);
			bool enableDebugLog;
			LuaObject.checkType(l, 2, out enableDebugLog);
			battleBase.m_luaExportHelper.m_enableDebugLog = enableDebugLog;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06017383 RID: 95107 RVA: 0x006480B0 File Offset: 0x006462B0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_enableChecksum(IntPtr l)
	{
		int result;
		try
		{
			BattleBase battleBase = (BattleBase)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, battleBase.m_luaExportHelper.m_enableChecksum);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06017384 RID: 95108 RVA: 0x00648108 File Offset: 0x00646308
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_enableChecksum(IntPtr l)
	{
		int result;
		try
		{
			BattleBase battleBase = (BattleBase)LuaObject.checkSelf(l);
			bool enableChecksum;
			LuaObject.checkType(l, 2, out enableChecksum);
			battleBase.m_luaExportHelper.m_enableChecksum = enableChecksum;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06017385 RID: 95109 RVA: 0x00648164 File Offset: 0x00646364
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_checksums(IntPtr l)
	{
		int result;
		try
		{
			BattleBase battleBase = (BattleBase)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, battleBase.m_luaExportHelper.m_checksums);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06017386 RID: 95110 RVA: 0x006481BC File Offset: 0x006463BC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_checksums(IntPtr l)
	{
		int result;
		try
		{
			BattleBase battleBase = (BattleBase)LuaObject.checkSelf(l);
			List<int> checksums;
			LuaObject.checkType<List<int>>(l, 2, out checksums);
			battleBase.m_luaExportHelper.m_checksums = checksums;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06017387 RID: 95111 RVA: 0x00648218 File Offset: 0x00646418
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_winConditionStates(IntPtr l)
	{
		int result;
		try
		{
			BattleBase battleBase = (BattleBase)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, battleBase.m_luaExportHelper.m_winConditionStates);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06017388 RID: 95112 RVA: 0x00648270 File Offset: 0x00646470
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_winConditionStates(IntPtr l)
	{
		int result;
		try
		{
			BattleBase battleBase = (BattleBase)LuaObject.checkSelf(l);
			List<BattleWinConditionState> winConditionStates;
			LuaObject.checkType<List<BattleWinConditionState>>(l, 2, out winConditionStates);
			battleBase.m_luaExportHelper.m_winConditionStates = winConditionStates;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06017389 RID: 95113 RVA: 0x006482CC File Offset: 0x006464CC
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_m_loseConditionStates(IntPtr l)
	{
		int result;
		try
		{
			BattleBase battleBase = (BattleBase)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, battleBase.m_luaExportHelper.m_loseConditionStates);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601738A RID: 95114 RVA: 0x00648324 File Offset: 0x00646524
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_m_loseConditionStates(IntPtr l)
	{
		int result;
		try
		{
			BattleBase battleBase = (BattleBase)LuaObject.checkSelf(l);
			List<BattleLoseConditionState> loseConditionStates;
			LuaObject.checkType<List<BattleLoseConditionState>>(l, 2, out loseConditionStates);
			battleBase.m_luaExportHelper.m_loseConditionStates = loseConditionStates;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601738B RID: 95115 RVA: 0x00648380 File Offset: 0x00646580
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_m_achievementStates(IntPtr l)
	{
		int result;
		try
		{
			BattleBase battleBase = (BattleBase)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, battleBase.m_luaExportHelper.m_achievementStates);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601738C RID: 95116 RVA: 0x006483D8 File Offset: 0x006465D8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_achievementStates(IntPtr l)
	{
		int result;
		try
		{
			BattleBase battleBase = (BattleBase)LuaObject.checkSelf(l);
			List<BattleAchievementState> achievementStates;
			LuaObject.checkType<List<BattleAchievementState>>(l, 2, out achievementStates);
			battleBase.m_luaExportHelper.m_achievementStates = achievementStates;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601738D RID: 95117 RVA: 0x00648434 File Offset: 0x00646634
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_eventTriggerStates(IntPtr l)
	{
		int result;
		try
		{
			BattleBase battleBase = (BattleBase)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, battleBase.m_luaExportHelper.m_eventTriggerStates);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601738E RID: 95118 RVA: 0x0064848C File Offset: 0x0064668C
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_m_eventTriggerStates(IntPtr l)
	{
		int result;
		try
		{
			BattleBase battleBase = (BattleBase)LuaObject.checkSelf(l);
			List<BattleEventTriggerState> eventTriggerStates;
			LuaObject.checkType<List<BattleEventTriggerState>>(l, 2, out eventTriggerStates);
			battleBase.m_luaExportHelper.m_eventTriggerStates = eventTriggerStates;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601738F RID: 95119 RVA: 0x006484E8 File Offset: 0x006466E8
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_m_battleTreasureStates(IntPtr l)
	{
		int result;
		try
		{
			BattleBase battleBase = (BattleBase)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, battleBase.m_luaExportHelper.m_battleTreasureStates);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06017390 RID: 95120 RVA: 0x00648540 File Offset: 0x00646740
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_m_battleTreasureStates(IntPtr l)
	{
		int result;
		try
		{
			BattleBase battleBase = (BattleBase)LuaObject.checkSelf(l);
			List<BattleTreasureState> battleTreasureStates;
			LuaObject.checkType<List<BattleTreasureState>>(l, 2, out battleTreasureStates);
			battleBase.m_luaExportHelper.m_battleTreasureStates = battleTreasureStates;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06017391 RID: 95121 RVA: 0x0064859C File Offset: 0x0064679C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_stars(IntPtr l)
	{
		int result;
		try
		{
			BattleBase battleBase = (BattleBase)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, battleBase.m_luaExportHelper.m_stars);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06017392 RID: 95122 RVA: 0x006485F4 File Offset: 0x006467F4
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_m_stars(IntPtr l)
	{
		int result;
		try
		{
			BattleBase battleBase = (BattleBase)LuaObject.checkSelf(l);
			int stars;
			LuaObject.checkType(l, 2, out stars);
			battleBase.m_luaExportHelper.m_stars = stars;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06017393 RID: 95123 RVA: 0x00648650 File Offset: 0x00646850
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_starTurnMax(IntPtr l)
	{
		int result;
		try
		{
			BattleBase battleBase = (BattleBase)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, battleBase.m_luaExportHelper.m_starTurnMax);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06017394 RID: 95124 RVA: 0x006486A8 File Offset: 0x006468A8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_starTurnMax(IntPtr l)
	{
		int result;
		try
		{
			BattleBase battleBase = (BattleBase)LuaObject.checkSelf(l);
			int starTurnMax;
			LuaObject.checkType(l, 2, out starTurnMax);
			battleBase.m_luaExportHelper.m_starTurnMax = starTurnMax;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06017395 RID: 95125 RVA: 0x00648704 File Offset: 0x00646904
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_starDeadMax(IntPtr l)
	{
		int result;
		try
		{
			BattleBase battleBase = (BattleBase)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, battleBase.m_luaExportHelper.m_starDeadMax);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06017396 RID: 95126 RVA: 0x0064875C File Offset: 0x0064695C
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_m_starDeadMax(IntPtr l)
	{
		int result;
		try
		{
			BattleBase battleBase = (BattleBase)LuaObject.checkSelf(l);
			int starDeadMax;
			LuaObject.checkType(l, 2, out starDeadMax);
			battleBase.m_luaExportHelper.m_starDeadMax = starDeadMax;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06017397 RID: 95127 RVA: 0x006487B8 File Offset: 0x006469B8
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_m_myPlayerTeam(IntPtr l)
	{
		int result;
		try
		{
			BattleBase battleBase = (BattleBase)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, battleBase.m_luaExportHelper.m_myPlayerTeam);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06017398 RID: 95128 RVA: 0x00648810 File Offset: 0x00646A10
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_m_myPlayerTeam(IntPtr l)
	{
		int result;
		try
		{
			BattleBase battleBase = (BattleBase)LuaObject.checkSelf(l);
			int myPlayerTeam;
			LuaObject.checkType(l, 2, out myPlayerTeam);
			battleBase.m_luaExportHelper.m_myPlayerTeam = myPlayerTeam;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06017399 RID: 95129 RVA: 0x0064886C File Offset: 0x00646A6C
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_AliveActorsInfo(IntPtr l)
	{
		int result;
		try
		{
			BattleBase battleBase = (BattleBase)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, battleBase.AliveActorsInfo);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601739A RID: 95130 RVA: 0x006488C0 File Offset: 0x00646AC0
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_ConfigDataLoader(IntPtr l)
	{
		int result;
		try
		{
			BattleBase battleBase = (BattleBase)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, battleBase.ConfigDataLoader);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601739B RID: 95131 RVA: 0x00648914 File Offset: 0x00646B14
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_Listener(IntPtr l)
	{
		int result;
		try
		{
			BattleBase battleBase = (BattleBase)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, battleBase.Listener);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601739C RID: 95132 RVA: 0x00648968 File Offset: 0x00646B68
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_RandomNumber(IntPtr l)
	{
		int result;
		try
		{
			BattleBase battleBase = (BattleBase)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, battleBase.RandomNumber);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601739D RID: 95133 RVA: 0x006489BC File Offset: 0x00646BBC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_AIRandomNumber1(IntPtr l)
	{
		int result;
		try
		{
			BattleBase battleBase = (BattleBase)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, battleBase.AIRandomNumber1);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601739E RID: 95134 RVA: 0x00648A10 File Offset: 0x00646C10
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_AIRandomNumber2(IntPtr l)
	{
		int result;
		try
		{
			BattleBase battleBase = (BattleBase)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, battleBase.AIRandomNumber2);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601739F RID: 95135 RVA: 0x00648A64 File Offset: 0x00646C64
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_BattleInfo(IntPtr l)
	{
		int result;
		try
		{
			BattleBase battleBase = (BattleBase)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, battleBase.BattleInfo);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060173A0 RID: 95136 RVA: 0x00648AB8 File Offset: 0x00646CB8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_ArenaBattleInfo(IntPtr l)
	{
		int result;
		try
		{
			BattleBase battleBase = (BattleBase)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, battleBase.ArenaBattleInfo);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060173A1 RID: 95137 RVA: 0x00648B0C File Offset: 0x00646D0C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_PVPBattleInfo(IntPtr l)
	{
		int result;
		try
		{
			BattleBase battleBase = (BattleBase)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, battleBase.PVPBattleInfo);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060173A2 RID: 95138 RVA: 0x00648B60 File Offset: 0x00646D60
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_RealTimePVPBattleInfo(IntPtr l)
	{
		int result;
		try
		{
			BattleBase battleBase = (BattleBase)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, battleBase.RealTimePVPBattleInfo);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060173A3 RID: 95139 RVA: 0x00648BB4 File Offset: 0x00646DB4
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_BattleType(IntPtr l)
	{
		int result;
		try
		{
			BattleBase battleBase = (BattleBase)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushEnum(l, (int)battleBase.BattleType);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060173A4 RID: 95140 RVA: 0x00648C08 File Offset: 0x00646E08
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_ActionOrderType(IntPtr l)
	{
		int result;
		try
		{
			BattleBase battleBase = (BattleBase)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushEnum(l, (int)battleBase.ActionOrderType);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060173A5 RID: 95141 RVA: 0x00648C5C File Offset: 0x00646E5C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_BattlePlayers(IntPtr l)
	{
		int result;
		try
		{
			BattleBase battleBase = (BattleBase)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, battleBase.BattlePlayers);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060173A6 RID: 95142 RVA: 0x00648CB0 File Offset: 0x00646EB0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_MaxPlayerLevelInfo(IntPtr l)
	{
		int result;
		try
		{
			BattleBase battleBase = (BattleBase)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, battleBase.MaxPlayerLevelInfo);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060173A7 RID: 95143 RVA: 0x00648D04 File Offset: 0x00646F04
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_State(IntPtr l)
	{
		int result;
		try
		{
			BattleBase battleBase = (BattleBase)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushEnum(l, (int)battleBase.State);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060173A8 RID: 95144 RVA: 0x00648D58 File Offset: 0x00646F58
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_Step(IntPtr l)
	{
		int result;
		try
		{
			BattleBase battleBase = (BattleBase)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, battleBase.Step);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060173A9 RID: 95145 RVA: 0x00648DAC File Offset: 0x00646FAC
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_Turn(IntPtr l)
	{
		int result;
		try
		{
			BattleBase battleBase = (BattleBase)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, battleBase.Turn);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060173AA RID: 95146 RVA: 0x00648E00 File Offset: 0x00647000
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_TurnMax(IntPtr l)
	{
		int result;
		try
		{
			BattleBase battleBase = (BattleBase)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, battleBase.TurnMax);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060173AB RID: 95147 RVA: 0x00648E54 File Offset: 0x00647054
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_Map(IntPtr l)
	{
		int result;
		try
		{
			BattleBase battleBase = (BattleBase)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, battleBase.Map);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060173AC RID: 95148 RVA: 0x00648EA8 File Offset: 0x006470A8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_Combat(IntPtr l)
	{
		int result;
		try
		{
			BattleBase battleBase = (BattleBase)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, battleBase.Combat);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060173AD RID: 95149 RVA: 0x00648EFC File Offset: 0x006470FC
	[Preserve]
	public static void reg(IntPtr l)
	{
		LuaObject.getTypeTable(l, "BlackJack.ProjectL.Battle.BattleBase");
		if (Lua_BlackJack_ProjectL_Battle_BattleBase.<>f__mg$cache0 == null)
		{
			Lua_BlackJack_ProjectL_Battle_BattleBase.<>f__mg$cache0 = new LuaCSFunction(Lua_BlackJack_ProjectL_Battle_BattleBase.Dispose);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Battle_BattleBase.<>f__mg$cache0);
		if (Lua_BlackJack_ProjectL_Battle_BattleBase.<>f__mg$cache1 == null)
		{
			Lua_BlackJack_ProjectL_Battle_BattleBase.<>f__mg$cache1 = new LuaCSFunction(Lua_BlackJack_ProjectL_Battle_BattleBase.SetWinForCheat);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Battle_BattleBase.<>f__mg$cache1);
		if (Lua_BlackJack_ProjectL_Battle_BattleBase.<>f__mg$cache2 == null)
		{
			Lua_BlackJack_ProjectL_Battle_BattleBase.<>f__mg$cache2 = new LuaCSFunction(Lua_BlackJack_ProjectL_Battle_BattleBase.Clear);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Battle_BattleBase.<>f__mg$cache2);
		if (Lua_BlackJack_ProjectL_Battle_BattleBase.<>f__mg$cache3 == null)
		{
			Lua_BlackJack_ProjectL_Battle_BattleBase.<>f__mg$cache3 = new LuaCSFunction(Lua_BlackJack_ProjectL_Battle_BattleBase.GetStarTurnMax);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Battle_BattleBase.<>f__mg$cache3);
		if (Lua_BlackJack_ProjectL_Battle_BattleBase.<>f__mg$cache4 == null)
		{
			Lua_BlackJack_ProjectL_Battle_BattleBase.<>f__mg$cache4 = new LuaCSFunction(Lua_BlackJack_ProjectL_Battle_BattleBase.GetStarDeadMax);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Battle_BattleBase.<>f__mg$cache4);
		if (Lua_BlackJack_ProjectL_Battle_BattleBase.<>f__mg$cache5 == null)
		{
			Lua_BlackJack_ProjectL_Battle_BattleBase.<>f__mg$cache5 = new LuaCSFunction(Lua_BlackJack_ProjectL_Battle_BattleBase.IsPerformOnlyBattle);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Battle_BattleBase.<>f__mg$cache5);
		if (Lua_BlackJack_ProjectL_Battle_BattleBase.<>f__mg$cache6 == null)
		{
			Lua_BlackJack_ProjectL_Battle_BattleBase.<>f__mg$cache6 = new LuaCSFunction(Lua_BlackJack_ProjectL_Battle_BattleBase.Start);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Battle_BattleBase.<>f__mg$cache6);
		if (Lua_BlackJack_ProjectL_Battle_BattleBase.<>f__mg$cache7 == null)
		{
			Lua_BlackJack_ProjectL_Battle_BattleBase.<>f__mg$cache7 = new LuaCSFunction(Lua_BlackJack_ProjectL_Battle_BattleBase.FirstStep);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Battle_BattleBase.<>f__mg$cache7);
		if (Lua_BlackJack_ProjectL_Battle_BattleBase.<>f__mg$cache8 == null)
		{
			Lua_BlackJack_ProjectL_Battle_BattleBase.<>f__mg$cache8 = new LuaCSFunction(Lua_BlackJack_ProjectL_Battle_BattleBase.GetActionTeam);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Battle_BattleBase.<>f__mg$cache8);
		if (Lua_BlackJack_ProjectL_Battle_BattleBase.<>f__mg$cache9 == null)
		{
			Lua_BlackJack_ProjectL_Battle_BattleBase.<>f__mg$cache9 = new LuaCSFunction(Lua_BlackJack_ProjectL_Battle_BattleBase.GetActionActor);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Battle_BattleBase.<>f__mg$cache9);
		if (Lua_BlackJack_ProjectL_Battle_BattleBase.<>f__mg$cacheA == null)
		{
			Lua_BlackJack_ProjectL_Battle_BattleBase.<>f__mg$cacheA = new LuaCSFunction(Lua_BlackJack_ProjectL_Battle_BattleBase.ChangeActionActor);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Battle_BattleBase.<>f__mg$cacheA);
		if (Lua_BlackJack_ProjectL_Battle_BattleBase.<>f__mg$cacheB == null)
		{
			Lua_BlackJack_ProjectL_Battle_BattleBase.<>f__mg$cacheB = new LuaCSFunction(Lua_BlackJack_ProjectL_Battle_BattleBase.Tick);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Battle_BattleBase.<>f__mg$cacheB);
		if (Lua_BlackJack_ProjectL_Battle_BattleBase.<>f__mg$cacheC == null)
		{
			Lua_BlackJack_ProjectL_Battle_BattleBase.<>f__mg$cacheC = new LuaCSFunction(Lua_BlackJack_ProjectL_Battle_BattleBase.TickGraphic);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Battle_BattleBase.<>f__mg$cacheC);
		if (Lua_BlackJack_ProjectL_Battle_BattleBase.<>f__mg$cacheD == null)
		{
			Lua_BlackJack_ProjectL_Battle_BattleBase.<>f__mg$cacheD = new LuaCSFunction(Lua_BlackJack_ProjectL_Battle_BattleBase.Draw);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Battle_BattleBase.<>f__mg$cacheD);
		if (Lua_BlackJack_ProjectL_Battle_BattleBase.<>f__mg$cacheE == null)
		{
			Lua_BlackJack_ProjectL_Battle_BattleBase.<>f__mg$cacheE = new LuaCSFunction(Lua_BlackJack_ProjectL_Battle_BattleBase.ChangeMapTerrain);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Battle_BattleBase.<>f__mg$cacheE);
		if (Lua_BlackJack_ProjectL_Battle_BattleBase.<>f__mg$cacheF == null)
		{
			Lua_BlackJack_ProjectL_Battle_BattleBase.<>f__mg$cacheF = new LuaCSFunction(Lua_BlackJack_ProjectL_Battle_BattleBase.GetTeam);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Battle_BattleBase.<>f__mg$cacheF);
		if (Lua_BlackJack_ProjectL_Battle_BattleBase.<>f__mg$cache10 == null)
		{
			Lua_BlackJack_ProjectL_Battle_BattleBase.<>f__mg$cache10 = new LuaCSFunction(Lua_BlackJack_ProjectL_Battle_BattleBase.GetBattlePlayer);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Battle_BattleBase.<>f__mg$cache10);
		if (Lua_BlackJack_ProjectL_Battle_BattleBase.<>f__mg$cache11 == null)
		{
			Lua_BlackJack_ProjectL_Battle_BattleBase.<>f__mg$cache11 = new LuaCSFunction(Lua_BlackJack_ProjectL_Battle_BattleBase.GetActorById);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Battle_BattleBase.<>f__mg$cache11);
		if (Lua_BlackJack_ProjectL_Battle_BattleBase.<>f__mg$cache12 == null)
		{
			Lua_BlackJack_ProjectL_Battle_BattleBase.<>f__mg$cache12 = new LuaCSFunction(Lua_BlackJack_ProjectL_Battle_BattleBase.GetActorByHeroId);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Battle_BattleBase.<>f__mg$cache12);
		if (Lua_BlackJack_ProjectL_Battle_BattleBase.<>f__mg$cache13 == null)
		{
			Lua_BlackJack_ProjectL_Battle_BattleBase.<>f__mg$cache13 = new LuaCSFunction(Lua_BlackJack_ProjectL_Battle_BattleBase.GetNextEntityId);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Battle_BattleBase.<>f__mg$cache13);
		if (Lua_BlackJack_ProjectL_Battle_BattleBase.<>f__mg$cache14 == null)
		{
			Lua_BlackJack_ProjectL_Battle_BattleBase.<>f__mg$cache14 = new LuaCSFunction(Lua_BlackJack_ProjectL_Battle_BattleBase.CheckOnActorMove);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Battle_BattleBase.<>f__mg$cache14);
		if (Lua_BlackJack_ProjectL_Battle_BattleBase.<>f__mg$cache15 == null)
		{
			Lua_BlackJack_ProjectL_Battle_BattleBase.<>f__mg$cache15 = new LuaCSFunction(Lua_BlackJack_ProjectL_Battle_BattleBase.CheckOnActorDie);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Battle_BattleBase.<>f__mg$cache15);
		if (Lua_BlackJack_ProjectL_Battle_BattleBase.<>f__mg$cache16 == null)
		{
			Lua_BlackJack_ProjectL_Battle_BattleBase.<>f__mg$cache16 = new LuaCSFunction(Lua_BlackJack_ProjectL_Battle_BattleBase.OnActorDie);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Battle_BattleBase.<>f__mg$cache16);
		if (Lua_BlackJack_ProjectL_Battle_BattleBase.<>f__mg$cache17 == null)
		{
			Lua_BlackJack_ProjectL_Battle_BattleBase.<>f__mg$cache17 = new LuaCSFunction(Lua_BlackJack_ProjectL_Battle_BattleBase.OnActorRetreat);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Battle_BattleBase.<>f__mg$cache17);
		if (Lua_BlackJack_ProjectL_Battle_BattleBase.<>f__mg$cache18 == null)
		{
			Lua_BlackJack_ProjectL_Battle_BattleBase.<>f__mg$cache18 = new LuaCSFunction(Lua_BlackJack_ProjectL_Battle_BattleBase.OnActorChangeTeam);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Battle_BattleBase.<>f__mg$cache18);
		if (Lua_BlackJack_ProjectL_Battle_BattleBase.<>f__mg$cache19 == null)
		{
			Lua_BlackJack_ProjectL_Battle_BattleBase.<>f__mg$cache19 = new LuaCSFunction(Lua_BlackJack_ProjectL_Battle_BattleBase.IsPlay);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Battle_BattleBase.<>f__mg$cache19);
		if (Lua_BlackJack_ProjectL_Battle_BattleBase.<>f__mg$cache1A == null)
		{
			Lua_BlackJack_ProjectL_Battle_BattleBase.<>f__mg$cache1A = new LuaCSFunction(Lua_BlackJack_ProjectL_Battle_BattleBase.IsGiveupBattle);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Battle_BattleBase.<>f__mg$cache1A);
		if (Lua_BlackJack_ProjectL_Battle_BattleBase.<>f__mg$cache1B == null)
		{
			Lua_BlackJack_ProjectL_Battle_BattleBase.<>f__mg$cache1B = new LuaCSFunction(Lua_BlackJack_ProjectL_Battle_BattleBase.GetGiveupBattlePlayerIndex);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Battle_BattleBase.<>f__mg$cache1B);
		if (Lua_BlackJack_ProjectL_Battle_BattleBase.<>f__mg$cache1C == null)
		{
			Lua_BlackJack_ProjectL_Battle_BattleBase.<>f__mg$cache1C = new LuaCSFunction(Lua_BlackJack_ProjectL_Battle_BattleBase.AllocateTempIntList);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Battle_BattleBase.<>f__mg$cache1C);
		if (Lua_BlackJack_ProjectL_Battle_BattleBase.<>f__mg$cache1D == null)
		{
			Lua_BlackJack_ProjectL_Battle_BattleBase.<>f__mg$cache1D = new LuaCSFunction(Lua_BlackJack_ProjectL_Battle_BattleBase.FreeTempIntList);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Battle_BattleBase.<>f__mg$cache1D);
		if (Lua_BlackJack_ProjectL_Battle_BattleBase.<>f__mg$cache1E == null)
		{
			Lua_BlackJack_ProjectL_Battle_BattleBase.<>f__mg$cache1E = new LuaCSFunction(Lua_BlackJack_ProjectL_Battle_BattleBase.AllocateTempGridPositionList);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Battle_BattleBase.<>f__mg$cache1E);
		if (Lua_BlackJack_ProjectL_Battle_BattleBase.<>f__mg$cache1F == null)
		{
			Lua_BlackJack_ProjectL_Battle_BattleBase.<>f__mg$cache1F = new LuaCSFunction(Lua_BlackJack_ProjectL_Battle_BattleBase.FreeTempGridPositionList);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Battle_BattleBase.<>f__mg$cache1F);
		if (Lua_BlackJack_ProjectL_Battle_BattleBase.<>f__mg$cache20 == null)
		{
			Lua_BlackJack_ProjectL_Battle_BattleBase.<>f__mg$cache20 = new LuaCSFunction(Lua_BlackJack_ProjectL_Battle_BattleBase.AllocateTempActorList);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Battle_BattleBase.<>f__mg$cache20);
		if (Lua_BlackJack_ProjectL_Battle_BattleBase.<>f__mg$cache21 == null)
		{
			Lua_BlackJack_ProjectL_Battle_BattleBase.<>f__mg$cache21 = new LuaCSFunction(Lua_BlackJack_ProjectL_Battle_BattleBase.FreeTempActorList);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Battle_BattleBase.<>f__mg$cache21);
		if (Lua_BlackJack_ProjectL_Battle_BattleBase.<>f__mg$cache22 == null)
		{
			Lua_BlackJack_ProjectL_Battle_BattleBase.<>f__mg$cache22 = new LuaCSFunction(Lua_BlackJack_ProjectL_Battle_BattleBase.AllocateTempBuffList);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Battle_BattleBase.<>f__mg$cache22);
		if (Lua_BlackJack_ProjectL_Battle_BattleBase.<>f__mg$cache23 == null)
		{
			Lua_BlackJack_ProjectL_Battle_BattleBase.<>f__mg$cache23 = new LuaCSFunction(Lua_BlackJack_ProjectL_Battle_BattleBase.FreeTempBuffList);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Battle_BattleBase.<>f__mg$cache23);
		if (Lua_BlackJack_ProjectL_Battle_BattleBase.<>f__mg$cache24 == null)
		{
			Lua_BlackJack_ProjectL_Battle_BattleBase.<>f__mg$cache24 = new LuaCSFunction(Lua_BlackJack_ProjectL_Battle_BattleBase.AllocateTempBuffStateList);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Battle_BattleBase.<>f__mg$cache24);
		if (Lua_BlackJack_ProjectL_Battle_BattleBase.<>f__mg$cache25 == null)
		{
			Lua_BlackJack_ProjectL_Battle_BattleBase.<>f__mg$cache25 = new LuaCSFunction(Lua_BlackJack_ProjectL_Battle_BattleBase.FreeTempBuffStateList);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Battle_BattleBase.<>f__mg$cache25);
		if (Lua_BlackJack_ProjectL_Battle_BattleBase.<>f__mg$cache26 == null)
		{
			Lua_BlackJack_ProjectL_Battle_BattleBase.<>f__mg$cache26 = new LuaCSFunction(Lua_BlackJack_ProjectL_Battle_BattleBase.RandomizeBuffStateList);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Battle_BattleBase.<>f__mg$cache26);
		if (Lua_BlackJack_ProjectL_Battle_BattleBase.<>f__mg$cache27 == null)
		{
			Lua_BlackJack_ProjectL_Battle_BattleBase.<>f__mg$cache27 = new LuaCSFunction(Lua_BlackJack_ProjectL_Battle_BattleBase.GetTempBattlePropertyModifier);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Battle_BattleBase.<>f__mg$cache27);
		if (Lua_BlackJack_ProjectL_Battle_BattleBase.<>f__mg$cache28 == null)
		{
			Lua_BlackJack_ProjectL_Battle_BattleBase.<>f__mg$cache28 = new LuaCSFunction(Lua_BlackJack_ProjectL_Battle_BattleBase.IsProbabilitySatisfied);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Battle_BattleBase.<>f__mg$cache28);
		if (Lua_BlackJack_ProjectL_Battle_BattleBase.<>f__mg$cache29 == null)
		{
			Lua_BlackJack_ProjectL_Battle_BattleBase.<>f__mg$cache29 = new LuaCSFunction(Lua_BlackJack_ProjectL_Battle_BattleBase.GetRandomBuffList);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Battle_BattleBase.<>f__mg$cache29);
		if (Lua_BlackJack_ProjectL_Battle_BattleBase.<>f__mg$cache2A == null)
		{
			Lua_BlackJack_ProjectL_Battle_BattleBase.<>f__mg$cache2A = new LuaCSFunction(Lua_BlackJack_ProjectL_Battle_BattleBase.ComputeArmyRelationData);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Battle_BattleBase.<>f__mg$cache2A);
		if (Lua_BlackJack_ProjectL_Battle_BattleBase.<>f__mg$cache2B == null)
		{
			Lua_BlackJack_ProjectL_Battle_BattleBase.<>f__mg$cache2B = new LuaCSFunction(Lua_BlackJack_ProjectL_Battle_BattleBase.FindPath);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Battle_BattleBase.<>f__mg$cache2B);
		if (Lua_BlackJack_ProjectL_Battle_BattleBase.<>f__mg$cache2C == null)
		{
			Lua_BlackJack_ProjectL_Battle_BattleBase.<>f__mg$cache2C = new LuaCSFunction(Lua_BlackJack_ProjectL_Battle_BattleBase.FindMoveRegion);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Battle_BattleBase.<>f__mg$cache2C);
		if (Lua_BlackJack_ProjectL_Battle_BattleBase.<>f__mg$cache2D == null)
		{
			Lua_BlackJack_ProjectL_Battle_BattleBase.<>f__mg$cache2D = new LuaCSFunction(Lua_BlackJack_ProjectL_Battle_BattleBase.FindAttackRegion);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Battle_BattleBase.<>f__mg$cache2D);
		if (Lua_BlackJack_ProjectL_Battle_BattleBase.<>f__mg$cache2E == null)
		{
			Lua_BlackJack_ProjectL_Battle_BattleBase.<>f__mg$cache2E = new LuaCSFunction(Lua_BlackJack_ProjectL_Battle_BattleBase.FindFixedDistanceRegion);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Battle_BattleBase.<>f__mg$cache2E);
		if (Lua_BlackJack_ProjectL_Battle_BattleBase.<>f__mg$cache2F == null)
		{
			Lua_BlackJack_ProjectL_Battle_BattleBase.<>f__mg$cache2F = new LuaCSFunction(Lua_BlackJack_ProjectL_Battle_BattleBase.IsInDangerRegion);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Battle_BattleBase.<>f__mg$cache2F);
		if (Lua_BlackJack_ProjectL_Battle_BattleBase.<>f__mg$cache30 == null)
		{
			Lua_BlackJack_ProjectL_Battle_BattleBase.<>f__mg$cache30 = new LuaCSFunction(Lua_BlackJack_ProjectL_Battle_BattleBase.GetStars);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Battle_BattleBase.<>f__mg$cache30);
		if (Lua_BlackJack_ProjectL_Battle_BattleBase.<>f__mg$cache31 == null)
		{
			Lua_BlackJack_ProjectL_Battle_BattleBase.<>f__mg$cache31 = new LuaCSFunction(Lua_BlackJack_ProjectL_Battle_BattleBase.IsWin);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Battle_BattleBase.<>f__mg$cache31);
		if (Lua_BlackJack_ProjectL_Battle_BattleBase.<>f__mg$cache32 == null)
		{
			Lua_BlackJack_ProjectL_Battle_BattleBase.<>f__mg$cache32 = new LuaCSFunction(Lua_BlackJack_ProjectL_Battle_BattleBase.GetPlayerActors);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Battle_BattleBase.<>f__mg$cache32);
		if (Lua_BlackJack_ProjectL_Battle_BattleBase.<>f__mg$cache33 == null)
		{
			Lua_BlackJack_ProjectL_Battle_BattleBase.<>f__mg$cache33 = new LuaCSFunction(Lua_BlackJack_ProjectL_Battle_BattleBase.GetPlayerActorsLogInfos);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Battle_BattleBase.<>f__mg$cache33);
		if (Lua_BlackJack_ProjectL_Battle_BattleBase.<>f__mg$cache34 == null)
		{
			Lua_BlackJack_ProjectL_Battle_BattleBase.<>f__mg$cache34 = new LuaCSFunction(Lua_BlackJack_ProjectL_Battle_BattleBase.GetPlayerKillActorCount);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Battle_BattleBase.<>f__mg$cache34);
		if (Lua_BlackJack_ProjectL_Battle_BattleBase.<>f__mg$cache35 == null)
		{
			Lua_BlackJack_ProjectL_Battle_BattleBase.<>f__mg$cache35 = new LuaCSFunction(Lua_BlackJack_ProjectL_Battle_BattleBase.GetDeadEnemyActors);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Battle_BattleBase.<>f__mg$cache35);
		if (Lua_BlackJack_ProjectL_Battle_BattleBase.<>f__mg$cache36 == null)
		{
			Lua_BlackJack_ProjectL_Battle_BattleBase.<>f__mg$cache36 = new LuaCSFunction(Lua_BlackJack_ProjectL_Battle_BattleBase.EnableChecksum);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Battle_BattleBase.<>f__mg$cache36);
		if (Lua_BlackJack_ProjectL_Battle_BattleBase.<>f__mg$cache37 == null)
		{
			Lua_BlackJack_ProjectL_Battle_BattleBase.<>f__mg$cache37 = new LuaCSFunction(Lua_BlackJack_ProjectL_Battle_BattleBase.GetChecksums);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Battle_BattleBase.<>f__mg$cache37);
		if (Lua_BlackJack_ProjectL_Battle_BattleBase.<>f__mg$cache38 == null)
		{
			Lua_BlackJack_ProjectL_Battle_BattleBase.<>f__mg$cache38 = new LuaCSFunction(Lua_BlackJack_ProjectL_Battle_BattleBase.EnableDebugLog);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Battle_BattleBase.<>f__mg$cache38);
		if (Lua_BlackJack_ProjectL_Battle_BattleBase.<>f__mg$cache39 == null)
		{
			Lua_BlackJack_ProjectL_Battle_BattleBase.<>f__mg$cache39 = new LuaCSFunction(Lua_BlackJack_ProjectL_Battle_BattleBase.IsEnableDebugLog);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Battle_BattleBase.<>f__mg$cache39);
		if (Lua_BlackJack_ProjectL_Battle_BattleBase.<>f__mg$cache3A == null)
		{
			Lua_BlackJack_ProjectL_Battle_BattleBase.<>f__mg$cache3A = new LuaCSFunction(Lua_BlackJack_ProjectL_Battle_BattleBase.IsAchievementComplete);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Battle_BattleBase.<>f__mg$cache3A);
		if (Lua_BlackJack_ProjectL_Battle_BattleBase.<>f__mg$cache3B == null)
		{
			Lua_BlackJack_ProjectL_Battle_BattleBase.<>f__mg$cache3B = new LuaCSFunction(Lua_BlackJack_ProjectL_Battle_BattleBase.GetCompleteAchievements);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Battle_BattleBase.<>f__mg$cache3B);
		if (Lua_BlackJack_ProjectL_Battle_BattleBase.<>f__mg$cache3C == null)
		{
			Lua_BlackJack_ProjectL_Battle_BattleBase.<>f__mg$cache3C = new LuaCSFunction(Lua_BlackJack_ProjectL_Battle_BattleBase.GetAchievementStatus);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Battle_BattleBase.<>f__mg$cache3C);
		if (Lua_BlackJack_ProjectL_Battle_BattleBase.<>f__mg$cache3D == null)
		{
			Lua_BlackJack_ProjectL_Battle_BattleBase.<>f__mg$cache3D = new LuaCSFunction(Lua_BlackJack_ProjectL_Battle_BattleBase.AddBattleCommand);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Battle_BattleBase.<>f__mg$cache3D);
		if (Lua_BlackJack_ProjectL_Battle_BattleBase.<>f__mg$cache3E == null)
		{
			Lua_BlackJack_ProjectL_Battle_BattleBase.<>f__mg$cache3E = new LuaCSFunction(Lua_BlackJack_ProjectL_Battle_BattleBase.AddGiveupLogBattleCommand);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Battle_BattleBase.<>f__mg$cache3E);
		if (Lua_BlackJack_ProjectL_Battle_BattleBase.<>f__mg$cache3F == null)
		{
			Lua_BlackJack_ProjectL_Battle_BattleBase.<>f__mg$cache3F = new LuaCSFunction(Lua_BlackJack_ProjectL_Battle_BattleBase.AddCancelLogBattleCommand);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Battle_BattleBase.<>f__mg$cache3F);
		if (Lua_BlackJack_ProjectL_Battle_BattleBase.<>f__mg$cache40 == null)
		{
			Lua_BlackJack_ProjectL_Battle_BattleBase.<>f__mg$cache40 = new LuaCSFunction(Lua_BlackJack_ProjectL_Battle_BattleBase.ClearBattleCommandsAndNextStep);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Battle_BattleBase.<>f__mg$cache40);
		if (Lua_BlackJack_ProjectL_Battle_BattleBase.<>f__mg$cache41 == null)
		{
			Lua_BlackJack_ProjectL_Battle_BattleBase.<>f__mg$cache41 = new LuaCSFunction(Lua_BlackJack_ProjectL_Battle_BattleBase.HasBattleCommand);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Battle_BattleBase.<>f__mg$cache41);
		if (Lua_BlackJack_ProjectL_Battle_BattleBase.<>f__mg$cache42 == null)
		{
			Lua_BlackJack_ProjectL_Battle_BattleBase.<>f__mg$cache42 = new LuaCSFunction(Lua_BlackJack_ProjectL_Battle_BattleBase.HasCurrentStepBattleCommand);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Battle_BattleBase.<>f__mg$cache42);
		if (Lua_BlackJack_ProjectL_Battle_BattleBase.<>f__mg$cache43 == null)
		{
			Lua_BlackJack_ProjectL_Battle_BattleBase.<>f__mg$cache43 = new LuaCSFunction(Lua_BlackJack_ProjectL_Battle_BattleBase.ExecuteBattleCommand);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Battle_BattleBase.<>f__mg$cache43);
		if (Lua_BlackJack_ProjectL_Battle_BattleBase.<>f__mg$cache44 == null)
		{
			Lua_BlackJack_ProjectL_Battle_BattleBase.<>f__mg$cache44 = new LuaCSFunction(Lua_BlackJack_ProjectL_Battle_BattleBase.Run);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Battle_BattleBase.<>f__mg$cache44);
		if (Lua_BlackJack_ProjectL_Battle_BattleBase.<>f__mg$cache45 == null)
		{
			Lua_BlackJack_ProjectL_Battle_BattleBase.<>f__mg$cache45 = new LuaCSFunction(Lua_BlackJack_ProjectL_Battle_BattleBase.RunAIActors);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Battle_BattleBase.<>f__mg$cache45);
		if (Lua_BlackJack_ProjectL_Battle_BattleBase.<>f__mg$cache46 == null)
		{
			Lua_BlackJack_ProjectL_Battle_BattleBase.<>f__mg$cache46 = new LuaCSFunction(Lua_BlackJack_ProjectL_Battle_BattleBase.RunPlayerBattleCommands);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Battle_BattleBase.<>f__mg$cache46);
		if (Lua_BlackJack_ProjectL_Battle_BattleBase.<>f__mg$cache47 == null)
		{
			Lua_BlackJack_ProjectL_Battle_BattleBase.<>f__mg$cache47 = new LuaCSFunction(Lua_BlackJack_ProjectL_Battle_BattleBase.FixExecutedCommands);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Battle_BattleBase.<>f__mg$cache47);
		if (Lua_BlackJack_ProjectL_Battle_BattleBase.<>f__mg$cache48 == null)
		{
			Lua_BlackJack_ProjectL_Battle_BattleBase.<>f__mg$cache48 = new LuaCSFunction(Lua_BlackJack_ProjectL_Battle_BattleBase.GetStepExecutedCommands);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Battle_BattleBase.<>f__mg$cache48);
		if (Lua_BlackJack_ProjectL_Battle_BattleBase.<>f__mg$cache49 == null)
		{
			Lua_BlackJack_ProjectL_Battle_BattleBase.<>f__mg$cache49 = new LuaCSFunction(Lua_BlackJack_ProjectL_Battle_BattleBase.EnableLogBattleCommands);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Battle_BattleBase.<>f__mg$cache49);
		if (Lua_BlackJack_ProjectL_Battle_BattleBase.<>f__mg$cache4A == null)
		{
			Lua_BlackJack_ProjectL_Battle_BattleBase.<>f__mg$cache4A = new LuaCSFunction(Lua_BlackJack_ProjectL_Battle_BattleBase.IsEnableLogBattleCommands);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Battle_BattleBase.<>f__mg$cache4A);
		if (Lua_BlackJack_ProjectL_Battle_BattleBase.<>f__mg$cache4B == null)
		{
			Lua_BlackJack_ProjectL_Battle_BattleBase.<>f__mg$cache4B = new LuaCSFunction(Lua_BlackJack_ProjectL_Battle_BattleBase.GetLogBattleCommands);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Battle_BattleBase.<>f__mg$cache4B);
		if (Lua_BlackJack_ProjectL_Battle_BattleBase.<>f__mg$cache4C == null)
		{
			Lua_BlackJack_ProjectL_Battle_BattleBase.<>f__mg$cache4C = new LuaCSFunction(Lua_BlackJack_ProjectL_Battle_BattleBase.EnableTempBattleCommands);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Battle_BattleBase.<>f__mg$cache4C);
		if (Lua_BlackJack_ProjectL_Battle_BattleBase.<>f__mg$cache4D == null)
		{
			Lua_BlackJack_ProjectL_Battle_BattleBase.<>f__mg$cache4D = new LuaCSFunction(Lua_BlackJack_ProjectL_Battle_BattleBase.IsEnableTempBattleCommands);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Battle_BattleBase.<>f__mg$cache4D);
		if (Lua_BlackJack_ProjectL_Battle_BattleBase.<>f__mg$cache4E == null)
		{
			Lua_BlackJack_ProjectL_Battle_BattleBase.<>f__mg$cache4E = new LuaCSFunction(Lua_BlackJack_ProjectL_Battle_BattleBase.GetTempBattleCommands);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Battle_BattleBase.<>f__mg$cache4E);
		if (Lua_BlackJack_ProjectL_Battle_BattleBase.<>f__mg$cache4F == null)
		{
			Lua_BlackJack_ProjectL_Battle_BattleBase.<>f__mg$cache4F = new LuaCSFunction(Lua_BlackJack_ProjectL_Battle_BattleBase.ClearTempBattleCommands);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Battle_BattleBase.<>f__mg$cache4F);
		if (Lua_BlackJack_ProjectL_Battle_BattleBase.<>f__mg$cache50 == null)
		{
			Lua_BlackJack_ProjectL_Battle_BattleBase.<>f__mg$cache50 = new LuaCSFunction(Lua_BlackJack_ProjectL_Battle_BattleBase.StartCombat);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Battle_BattleBase.<>f__mg$cache50);
		if (Lua_BlackJack_ProjectL_Battle_BattleBase.<>f__mg$cache51 == null)
		{
			Lua_BlackJack_ProjectL_Battle_BattleBase.<>f__mg$cache51 = new LuaCSFunction(Lua_BlackJack_ProjectL_Battle_BattleBase.RestartCombat);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Battle_BattleBase.<>f__mg$cache51);
		if (Lua_BlackJack_ProjectL_Battle_BattleBase.<>f__mg$cache52 == null)
		{
			Lua_BlackJack_ProjectL_Battle_BattleBase.<>f__mg$cache52 = new LuaCSFunction(Lua_BlackJack_ProjectL_Battle_BattleBase.CheckEventTriggerOnActorUseSkill);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Battle_BattleBase.<>f__mg$cache52);
		if (Lua_BlackJack_ProjectL_Battle_BattleBase.<>f__mg$cache53 == null)
		{
			Lua_BlackJack_ProjectL_Battle_BattleBase.<>f__mg$cache53 = new LuaCSFunction(Lua_BlackJack_ProjectL_Battle_BattleBase.CreateMap);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Battle_BattleBase.<>f__mg$cache53);
		if (Lua_BlackJack_ProjectL_Battle_BattleBase.<>f__mg$cache54 == null)
		{
			Lua_BlackJack_ProjectL_Battle_BattleBase.<>f__mg$cache54 = new LuaCSFunction(Lua_BlackJack_ProjectL_Battle_BattleBase.ResetMap);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Battle_BattleBase.<>f__mg$cache54);
		if (Lua_BlackJack_ProjectL_Battle_BattleBase.<>f__mg$cache55 == null)
		{
			Lua_BlackJack_ProjectL_Battle_BattleBase.<>f__mg$cache55 = new LuaCSFunction(Lua_BlackJack_ProjectL_Battle_BattleBase.SetMyPlayerTeamNumber);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Battle_BattleBase.<>f__mg$cache55);
		if (Lua_BlackJack_ProjectL_Battle_BattleBase.<>f__mg$cache56 == null)
		{
			Lua_BlackJack_ProjectL_Battle_BattleBase.<>f__mg$cache56 = new LuaCSFunction(Lua_BlackJack_ProjectL_Battle_BattleBase.GetMyPlayerTeamNumber);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Battle_BattleBase.<>f__mg$cache56);
		if (Lua_BlackJack_ProjectL_Battle_BattleBase.<>f__mg$cache57 == null)
		{
			Lua_BlackJack_ProjectL_Battle_BattleBase.<>f__mg$cache57 = new LuaCSFunction(Lua_BlackJack_ProjectL_Battle_BattleBase.InitBattle);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Battle_BattleBase.<>f__mg$cache57);
		if (Lua_BlackJack_ProjectL_Battle_BattleBase.<>f__mg$cache58 == null)
		{
			Lua_BlackJack_ProjectL_Battle_BattleBase.<>f__mg$cache58 = new LuaCSFunction(Lua_BlackJack_ProjectL_Battle_BattleBase.InitArenaBattle);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Battle_BattleBase.<>f__mg$cache58);
		if (Lua_BlackJack_ProjectL_Battle_BattleBase.<>f__mg$cache59 == null)
		{
			Lua_BlackJack_ProjectL_Battle_BattleBase.<>f__mg$cache59 = new LuaCSFunction(Lua_BlackJack_ProjectL_Battle_BattleBase.InitPVPBattle);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Battle_BattleBase.<>f__mg$cache59);
		if (Lua_BlackJack_ProjectL_Battle_BattleBase.<>f__mg$cache5A == null)
		{
			Lua_BlackJack_ProjectL_Battle_BattleBase.<>f__mg$cache5A = new LuaCSFunction(Lua_BlackJack_ProjectL_Battle_BattleBase.InitRealTimePVPBattle);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Battle_BattleBase.<>f__mg$cache5A);
		if (Lua_BlackJack_ProjectL_Battle_BattleBase.<>f__mg$cache5B == null)
		{
			Lua_BlackJack_ProjectL_Battle_BattleBase.<>f__mg$cache5B = new LuaCSFunction(Lua_BlackJack_ProjectL_Battle_BattleBase.InitBattleReport);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Battle_BattleBase.<>f__mg$cache5B);
		if (Lua_BlackJack_ProjectL_Battle_BattleBase.<>f__mg$cache5C == null)
		{
			Lua_BlackJack_ProjectL_Battle_BattleBase.<>f__mg$cache5C = new LuaCSFunction(Lua_BlackJack_ProjectL_Battle_BattleBase.InitArenaBattleReport);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Battle_BattleBase.<>f__mg$cache5C);
		if (Lua_BlackJack_ProjectL_Battle_BattleBase.<>f__mg$cache5D == null)
		{
			Lua_BlackJack_ProjectL_Battle_BattleBase.<>f__mg$cache5D = new LuaCSFunction(Lua_BlackJack_ProjectL_Battle_BattleBase.InitPVPBattleReport);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Battle_BattleBase.<>f__mg$cache5D);
		if (Lua_BlackJack_ProjectL_Battle_BattleBase.<>f__mg$cache5E == null)
		{
			Lua_BlackJack_ProjectL_Battle_BattleBase.<>f__mg$cache5E = new LuaCSFunction(Lua_BlackJack_ProjectL_Battle_BattleBase.InitRealTimePVPBattleReport);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Battle_BattleBase.<>f__mg$cache5E);
		if (Lua_BlackJack_ProjectL_Battle_BattleBase.<>f__mg$cache5F == null)
		{
			Lua_BlackJack_ProjectL_Battle_BattleBase.<>f__mg$cache5F = new LuaCSFunction(Lua_BlackJack_ProjectL_Battle_BattleBase.InitStarAndAchievement);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Battle_BattleBase.<>f__mg$cache5F);
		if (Lua_BlackJack_ProjectL_Battle_BattleBase.<>f__mg$cache60 == null)
		{
			Lua_BlackJack_ProjectL_Battle_BattleBase.<>f__mg$cache60 = new LuaCSFunction(Lua_BlackJack_ProjectL_Battle_BattleBase.InitGainBattleTreasures);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Battle_BattleBase.<>f__mg$cache60);
		if (Lua_BlackJack_ProjectL_Battle_BattleBase.<>f__mg$cache61 == null)
		{
			Lua_BlackJack_ProjectL_Battle_BattleBase.<>f__mg$cache61 = new LuaCSFunction(Lua_BlackJack_ProjectL_Battle_BattleBase.IsGainBattleTreasure);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Battle_BattleBase.<>f__mg$cache61);
		if (Lua_BlackJack_ProjectL_Battle_BattleBase.<>f__mg$cache62 == null)
		{
			Lua_BlackJack_ProjectL_Battle_BattleBase.<>f__mg$cache62 = new LuaCSFunction(Lua_BlackJack_ProjectL_Battle_BattleBase.GetGainBattleTreasures);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Battle_BattleBase.<>f__mg$cache62);
		if (Lua_BlackJack_ProjectL_Battle_BattleBase.<>f__mg$cache63 == null)
		{
			Lua_BlackJack_ProjectL_Battle_BattleBase.<>f__mg$cache63 = new LuaCSFunction(Lua_BlackJack_ProjectL_Battle_BattleBase.IsInRegion_s);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Battle_BattleBase.<>f__mg$cache63);
		if (Lua_BlackJack_ProjectL_Battle_BattleBase.<>f__mg$cache64 == null)
		{
			Lua_BlackJack_ProjectL_Battle_BattleBase.<>f__mg$cache64 = new LuaCSFunction(Lua_BlackJack_ProjectL_Battle_BattleBase.Stop);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Battle_BattleBase.<>f__mg$cache64);
		if (Lua_BlackJack_ProjectL_Battle_BattleBase.<>f__mg$cache65 == null)
		{
			Lua_BlackJack_ProjectL_Battle_BattleBase.<>f__mg$cache65 = new LuaCSFunction(Lua_BlackJack_ProjectL_Battle_BattleBase.NextStep);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Battle_BattleBase.<>f__mg$cache65);
		if (Lua_BlackJack_ProjectL_Battle_BattleBase.<>f__mg$cache66 == null)
		{
			Lua_BlackJack_ProjectL_Battle_BattleBase.<>f__mg$cache66 = new LuaCSFunction(Lua_BlackJack_ProjectL_Battle_BattleBase.NextStep_Normal);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Battle_BattleBase.<>f__mg$cache66);
		if (Lua_BlackJack_ProjectL_Battle_BattleBase.<>f__mg$cache67 == null)
		{
			Lua_BlackJack_ProjectL_Battle_BattleBase.<>f__mg$cache67 = new LuaCSFunction(Lua_BlackJack_ProjectL_Battle_BattleBase.NextStep_Pvp);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Battle_BattleBase.<>f__mg$cache67);
		if (Lua_BlackJack_ProjectL_Battle_BattleBase.<>f__mg$cache68 == null)
		{
			Lua_BlackJack_ProjectL_Battle_BattleBase.<>f__mg$cache68 = new LuaCSFunction(Lua_BlackJack_ProjectL_Battle_BattleBase.NextStepActorActive);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Battle_BattleBase.<>f__mg$cache68);
		if (Lua_BlackJack_ProjectL_Battle_BattleBase.<>f__mg$cache69 == null)
		{
			Lua_BlackJack_ProjectL_Battle_BattleBase.<>f__mg$cache69 = new LuaCSFunction(Lua_BlackJack_ProjectL_Battle_BattleBase.NextTurn);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Battle_BattleBase.<>f__mg$cache69);
		if (Lua_BlackJack_ProjectL_Battle_BattleBase.<>f__mg$cache6A == null)
		{
			Lua_BlackJack_ProjectL_Battle_BattleBase.<>f__mg$cache6A = new LuaCSFunction(Lua_BlackJack_ProjectL_Battle_BattleBase.GetDefaultActionActor);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Battle_BattleBase.<>f__mg$cache6A);
		if (Lua_BlackJack_ProjectL_Battle_BattleBase.<>f__mg$cache6B == null)
		{
			Lua_BlackJack_ProjectL_Battle_BattleBase.<>f__mg$cache6B = new LuaCSFunction(Lua_BlackJack_ProjectL_Battle_BattleBase.HasNotActionFinishedActor);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Battle_BattleBase.<>f__mg$cache6B);
		if (Lua_BlackJack_ProjectL_Battle_BattleBase.<>f__mg$cache6C == null)
		{
			Lua_BlackJack_ProjectL_Battle_BattleBase.<>f__mg$cache6C = new LuaCSFunction(Lua_BlackJack_ProjectL_Battle_BattleBase.GetAliveActorByHeroId);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Battle_BattleBase.<>f__mg$cache6C);
		if (Lua_BlackJack_ProjectL_Battle_BattleBase.<>f__mg$cache6D == null)
		{
			Lua_BlackJack_ProjectL_Battle_BattleBase.<>f__mg$cache6D = new LuaCSFunction(Lua_BlackJack_ProjectL_Battle_BattleBase.GetAliveActorsByHeroIdsAndGroupIds);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Battle_BattleBase.<>f__mg$cache6D);
		if (Lua_BlackJack_ProjectL_Battle_BattleBase.<>f__mg$cache6E == null)
		{
			Lua_BlackJack_ProjectL_Battle_BattleBase.<>f__mg$cache6E = new LuaCSFunction(Lua_BlackJack_ProjectL_Battle_BattleBase.ComputeStepChecksum);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Battle_BattleBase.<>f__mg$cache6E);
		if (Lua_BlackJack_ProjectL_Battle_BattleBase.<>f__mg$cache6F == null)
		{
			Lua_BlackJack_ProjectL_Battle_BattleBase.<>f__mg$cache6F = new LuaCSFunction(Lua_BlackJack_ProjectL_Battle_BattleBase.CheckAchievementOnActorMove);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Battle_BattleBase.<>f__mg$cache6F);
		if (Lua_BlackJack_ProjectL_Battle_BattleBase.<>f__mg$cache70 == null)
		{
			Lua_BlackJack_ProjectL_Battle_BattleBase.<>f__mg$cache70 = new LuaCSFunction(Lua_BlackJack_ProjectL_Battle_BattleBase.CheckAchievementOnActorDie);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Battle_BattleBase.<>f__mg$cache70);
		if (Lua_BlackJack_ProjectL_Battle_BattleBase.<>f__mg$cache71 == null)
		{
			Lua_BlackJack_ProjectL_Battle_BattleBase.<>f__mg$cache71 = new LuaCSFunction(Lua_BlackJack_ProjectL_Battle_BattleBase.CheckAchievementOnNextStep);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Battle_BattleBase.<>f__mg$cache71);
		if (Lua_BlackJack_ProjectL_Battle_BattleBase.<>f__mg$cache72 == null)
		{
			Lua_BlackJack_ProjectL_Battle_BattleBase.<>f__mg$cache72 = new LuaCSFunction(Lua_BlackJack_ProjectL_Battle_BattleBase.CheckAchievementOnTurnEndOrWin);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Battle_BattleBase.<>f__mg$cache72);
		if (Lua_BlackJack_ProjectL_Battle_BattleBase.<>f__mg$cache73 == null)
		{
			Lua_BlackJack_ProjectL_Battle_BattleBase.<>f__mg$cache73 = new LuaCSFunction(Lua_BlackJack_ProjectL_Battle_BattleBase.CheckAchievementOnWin);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Battle_BattleBase.<>f__mg$cache73);
		if (Lua_BlackJack_ProjectL_Battle_BattleBase.<>f__mg$cache74 == null)
		{
			Lua_BlackJack_ProjectL_Battle_BattleBase.<>f__mg$cache74 = new LuaCSFunction(Lua_BlackJack_ProjectL_Battle_BattleBase.CheckAchievementOnLose);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Battle_BattleBase.<>f__mg$cache74);
		if (Lua_BlackJack_ProjectL_Battle_BattleBase.<>f__mg$cache75 == null)
		{
			Lua_BlackJack_ProjectL_Battle_BattleBase.<>f__mg$cache75 = new LuaCSFunction(Lua_BlackJack_ProjectL_Battle_BattleBase.ChangeAchievementStatus);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Battle_BattleBase.<>f__mg$cache75);
		if (Lua_BlackJack_ProjectL_Battle_BattleBase.<>f__mg$cache76 == null)
		{
			Lua_BlackJack_ProjectL_Battle_BattleBase.<>f__mg$cache76 = new LuaCSFunction(Lua_BlackJack_ProjectL_Battle_BattleBase.IsActorsAllAlive);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Battle_BattleBase.<>f__mg$cache76);
		if (Lua_BlackJack_ProjectL_Battle_BattleBase.<>f__mg$cache77 == null)
		{
			Lua_BlackJack_ProjectL_Battle_BattleBase.<>f__mg$cache77 = new LuaCSFunction(Lua_BlackJack_ProjectL_Battle_BattleBase.IsActorsAllKillBySkillClass);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Battle_BattleBase.<>f__mg$cache77);
		if (Lua_BlackJack_ProjectL_Battle_BattleBase.<>f__mg$cache78 == null)
		{
			Lua_BlackJack_ProjectL_Battle_BattleBase.<>f__mg$cache78 = new LuaCSFunction(Lua_BlackJack_ProjectL_Battle_BattleBase.IsActorReachPositions);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Battle_BattleBase.<>f__mg$cache78);
		if (Lua_BlackJack_ProjectL_Battle_BattleBase.<>f__mg$cache79 == null)
		{
			Lua_BlackJack_ProjectL_Battle_BattleBase.<>f__mg$cache79 = new LuaCSFunction(Lua_BlackJack_ProjectL_Battle_BattleBase.IsActorsAnyReachPositions);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Battle_BattleBase.<>f__mg$cache79);
		if (Lua_BlackJack_ProjectL_Battle_BattleBase.<>f__mg$cache7A == null)
		{
			Lua_BlackJack_ProjectL_Battle_BattleBase.<>f__mg$cache7A = new LuaCSFunction(Lua_BlackJack_ProjectL_Battle_BattleBase.GetActorsCountSatisfyCondition);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Battle_BattleBase.<>f__mg$cache7A);
		if (Lua_BlackJack_ProjectL_Battle_BattleBase.<>f__mg$cache7B == null)
		{
			Lua_BlackJack_ProjectL_Battle_BattleBase.<>f__mg$cache7B = new LuaCSFunction(Lua_BlackJack_ProjectL_Battle_BattleBase.AddLogBattleCommand);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Battle_BattleBase.<>f__mg$cache7B);
		if (Lua_BlackJack_ProjectL_Battle_BattleBase.<>f__mg$cache7C == null)
		{
			Lua_BlackJack_ProjectL_Battle_BattleBase.<>f__mg$cache7C = new LuaCSFunction(Lua_BlackJack_ProjectL_Battle_BattleBase.AddBattleCommandToList);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Battle_BattleBase.<>f__mg$cache7C);
		if (Lua_BlackJack_ProjectL_Battle_BattleBase.<>f__mg$cache7D == null)
		{
			Lua_BlackJack_ProjectL_Battle_BattleBase.<>f__mg$cache7D = new LuaCSFunction(Lua_BlackJack_ProjectL_Battle_BattleBase.HasWrongStepBattleCommand);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Battle_BattleBase.<>f__mg$cache7D);
		if (Lua_BlackJack_ProjectL_Battle_BattleBase.<>f__mg$cache7E == null)
		{
			Lua_BlackJack_ProjectL_Battle_BattleBase.<>f__mg$cache7E = new LuaCSFunction(Lua_BlackJack_ProjectL_Battle_BattleBase.ExecuteGiveupCommand);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Battle_BattleBase.<>f__mg$cache7E);
		if (Lua_BlackJack_ProjectL_Battle_BattleBase.<>f__mg$cache7F == null)
		{
			Lua_BlackJack_ProjectL_Battle_BattleBase.<>f__mg$cache7F = new LuaCSFunction(Lua_BlackJack_ProjectL_Battle_BattleBase.RemoveStepCommands);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Battle_BattleBase.<>f__mg$cache7F);
		if (Lua_BlackJack_ProjectL_Battle_BattleBase.<>f__mg$cache80 == null)
		{
			Lua_BlackJack_ProjectL_Battle_BattleBase.<>f__mg$cache80 = new LuaCSFunction(Lua_BlackJack_ProjectL_Battle_BattleBase.RunCurrentStepBattleCommand);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Battle_BattleBase.<>f__mg$cache80);
		if (Lua_BlackJack_ProjectL_Battle_BattleBase.<>f__mg$cache81 == null)
		{
			Lua_BlackJack_ProjectL_Battle_BattleBase.<>f__mg$cache81 = new LuaCSFunction(Lua_BlackJack_ProjectL_Battle_BattleBase.RunCombat);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Battle_BattleBase.<>f__mg$cache81);
		if (Lua_BlackJack_ProjectL_Battle_BattleBase.<>f__mg$cache82 == null)
		{
			Lua_BlackJack_ProjectL_Battle_BattleBase.<>f__mg$cache82 = new LuaCSFunction(Lua_BlackJack_ProjectL_Battle_BattleBase.AddExecutedCommand);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Battle_BattleBase.<>f__mg$cache82);
		if (Lua_BlackJack_ProjectL_Battle_BattleBase.<>f__mg$cache83 == null)
		{
			Lua_BlackJack_ProjectL_Battle_BattleBase.<>f__mg$cache83 = new LuaCSFunction(Lua_BlackJack_ProjectL_Battle_BattleBase.StopCombat);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Battle_BattleBase.<>f__mg$cache83);
		if (Lua_BlackJack_ProjectL_Battle_BattleBase.<>f__mg$cache84 == null)
		{
			Lua_BlackJack_ProjectL_Battle_BattleBase.<>f__mg$cache84 = new LuaCSFunction(Lua_BlackJack_ProjectL_Battle_BattleBase.CheckCombatActorsDie);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Battle_BattleBase.<>f__mg$cache84);
		if (Lua_BlackJack_ProjectL_Battle_BattleBase.<>f__mg$cache85 == null)
		{
			Lua_BlackJack_ProjectL_Battle_BattleBase.<>f__mg$cache85 = new LuaCSFunction(Lua_BlackJack_ProjectL_Battle_BattleBase.CopyCombatProperty);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Battle_BattleBase.<>f__mg$cache85);
		if (Lua_BlackJack_ProjectL_Battle_BattleBase.<>f__mg$cache86 == null)
		{
			Lua_BlackJack_ProjectL_Battle_BattleBase.<>f__mg$cache86 = new LuaCSFunction(Lua_BlackJack_ProjectL_Battle_BattleBase.CheckWinConditionOnActorMove);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Battle_BattleBase.<>f__mg$cache86);
		if (Lua_BlackJack_ProjectL_Battle_BattleBase.<>f__mg$cache87 == null)
		{
			Lua_BlackJack_ProjectL_Battle_BattleBase.<>f__mg$cache87 = new LuaCSFunction(Lua_BlackJack_ProjectL_Battle_BattleBase.CheckLoseConditionOnActorMove);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Battle_BattleBase.<>f__mg$cache87);
		if (Lua_BlackJack_ProjectL_Battle_BattleBase.<>f__mg$cache88 == null)
		{
			Lua_BlackJack_ProjectL_Battle_BattleBase.<>f__mg$cache88 = new LuaCSFunction(Lua_BlackJack_ProjectL_Battle_BattleBase.CheckWinConditionOnActorDie);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Battle_BattleBase.<>f__mg$cache88);
		if (Lua_BlackJack_ProjectL_Battle_BattleBase.<>f__mg$cache89 == null)
		{
			Lua_BlackJack_ProjectL_Battle_BattleBase.<>f__mg$cache89 = new LuaCSFunction(Lua_BlackJack_ProjectL_Battle_BattleBase.CheckLoseConditionOnActorDie);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Battle_BattleBase.<>f__mg$cache89);
		if (Lua_BlackJack_ProjectL_Battle_BattleBase.<>f__mg$cache8A == null)
		{
			Lua_BlackJack_ProjectL_Battle_BattleBase.<>f__mg$cache8A = new LuaCSFunction(Lua_BlackJack_ProjectL_Battle_BattleBase.CheckWinConditionOnActorRetreat);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Battle_BattleBase.<>f__mg$cache8A);
		if (Lua_BlackJack_ProjectL_Battle_BattleBase.<>f__mg$cache8B == null)
		{
			Lua_BlackJack_ProjectL_Battle_BattleBase.<>f__mg$cache8B = new LuaCSFunction(Lua_BlackJack_ProjectL_Battle_BattleBase.CheckLoseConditionOnActorRetreat);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Battle_BattleBase.<>f__mg$cache8B);
		if (Lua_BlackJack_ProjectL_Battle_BattleBase.<>f__mg$cache8C == null)
		{
			Lua_BlackJack_ProjectL_Battle_BattleBase.<>f__mg$cache8C = new LuaCSFunction(Lua_BlackJack_ProjectL_Battle_BattleBase.CheckWinConditionOnEventTrigger);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Battle_BattleBase.<>f__mg$cache8C);
		if (Lua_BlackJack_ProjectL_Battle_BattleBase.<>f__mg$cache8D == null)
		{
			Lua_BlackJack_ProjectL_Battle_BattleBase.<>f__mg$cache8D = new LuaCSFunction(Lua_BlackJack_ProjectL_Battle_BattleBase.CheckLoseConditionOnEventTrigger);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Battle_BattleBase.<>f__mg$cache8D);
		if (Lua_BlackJack_ProjectL_Battle_BattleBase.<>f__mg$cache8E == null)
		{
			Lua_BlackJack_ProjectL_Battle_BattleBase.<>f__mg$cache8E = new LuaCSFunction(Lua_BlackJack_ProjectL_Battle_BattleBase.CheckWinConditionOnNextStep);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Battle_BattleBase.<>f__mg$cache8E);
		if (Lua_BlackJack_ProjectL_Battle_BattleBase.<>f__mg$cache8F == null)
		{
			Lua_BlackJack_ProjectL_Battle_BattleBase.<>f__mg$cache8F = new LuaCSFunction(Lua_BlackJack_ProjectL_Battle_BattleBase.CheckWinConditionOnTurnBegin);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Battle_BattleBase.<>f__mg$cache8F);
		if (Lua_BlackJack_ProjectL_Battle_BattleBase.<>f__mg$cache90 == null)
		{
			Lua_BlackJack_ProjectL_Battle_BattleBase.<>f__mg$cache90 = new LuaCSFunction(Lua_BlackJack_ProjectL_Battle_BattleBase.CheckWinLoseConditionOnTurnMax);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Battle_BattleBase.<>f__mg$cache90);
		if (Lua_BlackJack_ProjectL_Battle_BattleBase.<>f__mg$cache91 == null)
		{
			Lua_BlackJack_ProjectL_Battle_BattleBase.<>f__mg$cache91 = new LuaCSFunction(Lua_BlackJack_ProjectL_Battle_BattleBase.ChangeWinConditionStatus);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Battle_BattleBase.<>f__mg$cache91);
		if (Lua_BlackJack_ProjectL_Battle_BattleBase.<>f__mg$cache92 == null)
		{
			Lua_BlackJack_ProjectL_Battle_BattleBase.<>f__mg$cache92 = new LuaCSFunction(Lua_BlackJack_ProjectL_Battle_BattleBase.ChangeLoseConditionStatus);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Battle_BattleBase.<>f__mg$cache92);
		if (Lua_BlackJack_ProjectL_Battle_BattleBase.<>f__mg$cache93 == null)
		{
			Lua_BlackJack_ProjectL_Battle_BattleBase.<>f__mg$cache93 = new LuaCSFunction(Lua_BlackJack_ProjectL_Battle_BattleBase.CheckEventTriggerOnActorMove);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Battle_BattleBase.<>f__mg$cache93);
		if (Lua_BlackJack_ProjectL_Battle_BattleBase.<>f__mg$cache94 == null)
		{
			Lua_BlackJack_ProjectL_Battle_BattleBase.<>f__mg$cache94 = new LuaCSFunction(Lua_BlackJack_ProjectL_Battle_BattleBase.CheckEventTriggerOnActorDie);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Battle_BattleBase.<>f__mg$cache94);
		if (Lua_BlackJack_ProjectL_Battle_BattleBase.<>f__mg$cache95 == null)
		{
			Lua_BlackJack_ProjectL_Battle_BattleBase.<>f__mg$cache95 = new LuaCSFunction(Lua_BlackJack_ProjectL_Battle_BattleBase.CheckEventTriggerOnActorActionBegin);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Battle_BattleBase.<>f__mg$cache95);
		if (Lua_BlackJack_ProjectL_Battle_BattleBase.<>f__mg$cache96 == null)
		{
			Lua_BlackJack_ProjectL_Battle_BattleBase.<>f__mg$cache96 = new LuaCSFunction(Lua_BlackJack_ProjectL_Battle_BattleBase.CheckEventTriggerOnActorCombatAttackBefore);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Battle_BattleBase.<>f__mg$cache96);
		if (Lua_BlackJack_ProjectL_Battle_BattleBase.<>f__mg$cache97 == null)
		{
			Lua_BlackJack_ProjectL_Battle_BattleBase.<>f__mg$cache97 = new LuaCSFunction(Lua_BlackJack_ProjectL_Battle_BattleBase.CheckEventTriggerOnActorCombatAttackAfter);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Battle_BattleBase.<>f__mg$cache97);
		if (Lua_BlackJack_ProjectL_Battle_BattleBase.<>f__mg$cache98 == null)
		{
			Lua_BlackJack_ProjectL_Battle_BattleBase.<>f__mg$cache98 = new LuaCSFunction(Lua_BlackJack_ProjectL_Battle_BattleBase.CheckEventTriggerOnActorBeCombatAttack);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Battle_BattleBase.<>f__mg$cache98);
		if (Lua_BlackJack_ProjectL_Battle_BattleBase.<>f__mg$cache99 == null)
		{
			Lua_BlackJack_ProjectL_Battle_BattleBase.<>f__mg$cache99 = new LuaCSFunction(Lua_BlackJack_ProjectL_Battle_BattleBase.CheckEventTriggerOnNextStep);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Battle_BattleBase.<>f__mg$cache99);
		if (Lua_BlackJack_ProjectL_Battle_BattleBase.<>f__mg$cache9A == null)
		{
			Lua_BlackJack_ProjectL_Battle_BattleBase.<>f__mg$cache9A = new LuaCSFunction(Lua_BlackJack_ProjectL_Battle_BattleBase.CheckEventTriggerOnNextTeam);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Battle_BattleBase.<>f__mg$cache9A);
		if (Lua_BlackJack_ProjectL_Battle_BattleBase.<>f__mg$cache9B == null)
		{
			Lua_BlackJack_ProjectL_Battle_BattleBase.<>f__mg$cache9B = new LuaCSFunction(Lua_BlackJack_ProjectL_Battle_BattleBase.CheckEventTriggerOnCompleteAchievement);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Battle_BattleBase.<>f__mg$cache9B);
		if (Lua_BlackJack_ProjectL_Battle_BattleBase.<>f__mg$cache9C == null)
		{
			Lua_BlackJack_ProjectL_Battle_BattleBase.<>f__mg$cache9C = new LuaCSFunction(Lua_BlackJack_ProjectL_Battle_BattleBase.CheckEventTriggerOnWin);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Battle_BattleBase.<>f__mg$cache9C);
		if (Lua_BlackJack_ProjectL_Battle_BattleBase.<>f__mg$cache9D == null)
		{
			Lua_BlackJack_ProjectL_Battle_BattleBase.<>f__mg$cache9D = new LuaCSFunction(Lua_BlackJack_ProjectL_Battle_BattleBase.CheckEventTriggerOnLose);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Battle_BattleBase.<>f__mg$cache9D);
		if (Lua_BlackJack_ProjectL_Battle_BattleBase.<>f__mg$cache9E == null)
		{
			Lua_BlackJack_ProjectL_Battle_BattleBase.<>f__mg$cache9E = new LuaCSFunction(Lua_BlackJack_ProjectL_Battle_BattleBase.CheckBattleStopEventTrigger);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Battle_BattleBase.<>f__mg$cache9E);
		if (Lua_BlackJack_ProjectL_Battle_BattleBase.<>f__mg$cache9F == null)
		{
			Lua_BlackJack_ProjectL_Battle_BattleBase.<>f__mg$cache9F = new LuaCSFunction(Lua_BlackJack_ProjectL_Battle_BattleBase.CheckMultiEventTrigger);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Battle_BattleBase.<>f__mg$cache9F);
		if (Lua_BlackJack_ProjectL_Battle_BattleBase.<>f__mg$cacheA0 == null)
		{
			Lua_BlackJack_ProjectL_Battle_BattleBase.<>f__mg$cacheA0 = new LuaCSFunction(Lua_BlackJack_ProjectL_Battle_BattleBase.IsEventTriggerd);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Battle_BattleBase.<>f__mg$cacheA0);
		if (Lua_BlackJack_ProjectL_Battle_BattleBase.<>f__mg$cacheA1 == null)
		{
			Lua_BlackJack_ProjectL_Battle_BattleBase.<>f__mg$cacheA1 = new LuaCSFunction(Lua_BlackJack_ProjectL_Battle_BattleBase.GetEventTriggerState);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Battle_BattleBase.<>f__mg$cacheA1);
		if (Lua_BlackJack_ProjectL_Battle_BattleBase.<>f__mg$cacheA2 == null)
		{
			Lua_BlackJack_ProjectL_Battle_BattleBase.<>f__mg$cacheA2 = new LuaCSFunction(Lua_BlackJack_ProjectL_Battle_BattleBase.TriggerEvent);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Battle_BattleBase.<>f__mg$cacheA2);
		if (Lua_BlackJack_ProjectL_Battle_BattleBase.<>f__mg$cacheA3 == null)
		{
			Lua_BlackJack_ProjectL_Battle_BattleBase.<>f__mg$cacheA3 = new LuaCSFunction(Lua_BlackJack_ProjectL_Battle_BattleBase.ExecuteTriggerEventActions);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Battle_BattleBase.<>f__mg$cacheA3);
		if (Lua_BlackJack_ProjectL_Battle_BattleBase.<>f__mg$cacheA4 == null)
		{
			Lua_BlackJack_ProjectL_Battle_BattleBase.<>f__mg$cacheA4 = new LuaCSFunction(Lua_BlackJack_ProjectL_Battle_BattleBase.ExecuteEventAction);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Battle_BattleBase.<>f__mg$cacheA4);
		if (Lua_BlackJack_ProjectL_Battle_BattleBase.<>f__mg$cacheA5 == null)
		{
			Lua_BlackJack_ProjectL_Battle_BattleBase.<>f__mg$cacheA5 = new LuaCSFunction(Lua_BlackJack_ProjectL_Battle_BattleBase.ExecuteEventAction_Relief);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Battle_BattleBase.<>f__mg$cacheA5);
		if (Lua_BlackJack_ProjectL_Battle_BattleBase.<>f__mg$cacheA6 == null)
		{
			Lua_BlackJack_ProjectL_Battle_BattleBase.<>f__mg$cacheA6 = new LuaCSFunction(Lua_BlackJack_ProjectL_Battle_BattleBase.ExecuteEventAction_Retreat);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Battle_BattleBase.<>f__mg$cacheA6);
		if (Lua_BlackJack_ProjectL_Battle_BattleBase.<>f__mg$cacheA7 == null)
		{
			Lua_BlackJack_ProjectL_Battle_BattleBase.<>f__mg$cacheA7 = new LuaCSFunction(Lua_BlackJack_ProjectL_Battle_BattleBase.ExecuteEventAction_Dialog);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Battle_BattleBase.<>f__mg$cacheA7);
		if (Lua_BlackJack_ProjectL_Battle_BattleBase.<>f__mg$cacheA8 == null)
		{
			Lua_BlackJack_ProjectL_Battle_BattleBase.<>f__mg$cacheA8 = new LuaCSFunction(Lua_BlackJack_ProjectL_Battle_BattleBase.ExecuteEventAction_ChangeTeam);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Battle_BattleBase.<>f__mg$cacheA8);
		if (Lua_BlackJack_ProjectL_Battle_BattleBase.<>f__mg$cacheA9 == null)
		{
			Lua_BlackJack_ProjectL_Battle_BattleBase.<>f__mg$cacheA9 = new LuaCSFunction(Lua_BlackJack_ProjectL_Battle_BattleBase.ExecuteEventAction_AttachBuff);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Battle_BattleBase.<>f__mg$cacheA9);
		if (Lua_BlackJack_ProjectL_Battle_BattleBase.<>f__mg$cacheAA == null)
		{
			Lua_BlackJack_ProjectL_Battle_BattleBase.<>f__mg$cacheAA = new LuaCSFunction(Lua_BlackJack_ProjectL_Battle_BattleBase.ExecuteEventAction_ChangeBehavior);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Battle_BattleBase.<>f__mg$cacheAA);
		if (Lua_BlackJack_ProjectL_Battle_BattleBase.<>f__mg$cacheAB == null)
		{
			Lua_BlackJack_ProjectL_Battle_BattleBase.<>f__mg$cacheAB = new LuaCSFunction(Lua_BlackJack_ProjectL_Battle_BattleBase.ExecuteEventAction_Music);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Battle_BattleBase.<>f__mg$cacheAB);
		if (Lua_BlackJack_ProjectL_Battle_BattleBase.<>f__mg$cacheAC == null)
		{
			Lua_BlackJack_ProjectL_Battle_BattleBase.<>f__mg$cacheAC = new LuaCSFunction(Lua_BlackJack_ProjectL_Battle_BattleBase.ExecuteEventAction_ChangeTerrain);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Battle_BattleBase.<>f__mg$cacheAC);
		if (Lua_BlackJack_ProjectL_Battle_BattleBase.<>f__mg$cacheAD == null)
		{
			Lua_BlackJack_ProjectL_Battle_BattleBase.<>f__mg$cacheAD = new LuaCSFunction(Lua_BlackJack_ProjectL_Battle_BattleBase.ExecuteEventAction_Perform);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Battle_BattleBase.<>f__mg$cacheAD);
		if (Lua_BlackJack_ProjectL_Battle_BattleBase.<>f__mg$cacheAE == null)
		{
			Lua_BlackJack_ProjectL_Battle_BattleBase.<>f__mg$cacheAE = new LuaCSFunction(Lua_BlackJack_ProjectL_Battle_BattleBase.ExecuteEventAction_RetreatPosition);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Battle_BattleBase.<>f__mg$cacheAE);
		if (Lua_BlackJack_ProjectL_Battle_BattleBase.<>f__mg$cacheAF == null)
		{
			Lua_BlackJack_ProjectL_Battle_BattleBase.<>f__mg$cacheAF = new LuaCSFunction(Lua_BlackJack_ProjectL_Battle_BattleBase.ExecuteEventAction_Replace);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Battle_BattleBase.<>f__mg$cacheAF);
		if (Lua_BlackJack_ProjectL_Battle_BattleBase.<>f__mg$cacheB0 == null)
		{
			Lua_BlackJack_ProjectL_Battle_BattleBase.<>f__mg$cacheB0 = new LuaCSFunction(Lua_BlackJack_ProjectL_Battle_BattleBase.ExecuteEventAction_RemoveBuff);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Battle_BattleBase.<>f__mg$cacheB0);
		if (Lua_BlackJack_ProjectL_Battle_BattleBase.<>f__mg$cacheB1 == null)
		{
			Lua_BlackJack_ProjectL_Battle_BattleBase.<>f__mg$cacheB1 = new LuaCSFunction(Lua_BlackJack_ProjectL_Battle_BattleBase.ExecuteEventAction_AttachBuffPosition);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Battle_BattleBase.<>f__mg$cacheB1);
		if (Lua_BlackJack_ProjectL_Battle_BattleBase.<>f__mg$cacheB2 == null)
		{
			Lua_BlackJack_ProjectL_Battle_BattleBase.<>f__mg$cacheB2 = new LuaCSFunction(Lua_BlackJack_ProjectL_Battle_BattleBase.IsEmptyPosition);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Battle_BattleBase.<>f__mg$cacheB2);
		if (Lua_BlackJack_ProjectL_Battle_BattleBase.<>f__mg$cacheB3 == null)
		{
			Lua_BlackJack_ProjectL_Battle_BattleBase.<>f__mg$cacheB3 = new LuaCSFunction(Lua_BlackJack_ProjectL_Battle_BattleBase.GetRandomBattleArmyActors);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Battle_BattleBase.<>f__mg$cacheB3);
		if (Lua_BlackJack_ProjectL_Battle_BattleBase.<>f__mg$cacheB4 == null)
		{
			Lua_BlackJack_ProjectL_Battle_BattleBase.<>f__mg$cacheB4 = new LuaCSFunction(Lua_BlackJack_ProjectL_Battle_BattleBase.CreateEventActor);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Battle_BattleBase.<>f__mg$cacheB4);
		if (Lua_BlackJack_ProjectL_Battle_BattleBase.<>f__mg$cacheB5 == null)
		{
			Lua_BlackJack_ProjectL_Battle_BattleBase.<>f__mg$cacheB5 = new LuaCSFunction(Lua_BlackJack_ProjectL_Battle_BattleBase.ReplaceEventActor);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Battle_BattleBase.<>f__mg$cacheB5);
		if (Lua_BlackJack_ProjectL_Battle_BattleBase.<>f__mg$cacheB6 == null)
		{
			Lua_BlackJack_ProjectL_Battle_BattleBase.<>f__mg$cacheB6 = new LuaCSFunction(Lua_BlackJack_ProjectL_Battle_BattleBase.FindEmptyFixedDistancePosition);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Battle_BattleBase.<>f__mg$cacheB6);
		if (Lua_BlackJack_ProjectL_Battle_BattleBase.<>f__mg$cacheB7 == null)
		{
			Lua_BlackJack_ProjectL_Battle_BattleBase.<>f__mg$cacheB7 = new LuaCSFunction(Lua_BlackJack_ProjectL_Battle_BattleBase.FindEmptyNearPosition);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Battle_BattleBase.<>f__mg$cacheB7);
		if (Lua_BlackJack_ProjectL_Battle_BattleBase.<>f__mg$cacheB8 == null)
		{
			Lua_BlackJack_ProjectL_Battle_BattleBase.<>f__mg$cacheB8 = new LuaCSFunction(Lua_BlackJack_ProjectL_Battle_BattleBase.InitRandomNumbers);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Battle_BattleBase.<>f__mg$cacheB8);
		if (Lua_BlackJack_ProjectL_Battle_BattleBase.<>f__mg$cacheB9 == null)
		{
			Lua_BlackJack_ProjectL_Battle_BattleBase.<>f__mg$cacheB9 = new LuaCSFunction(Lua_BlackJack_ProjectL_Battle_BattleBase.InitPlayers);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Battle_BattleBase.<>f__mg$cacheB9);
		if (Lua_BlackJack_ProjectL_Battle_BattleBase.<>f__mg$cacheBA == null)
		{
			Lua_BlackJack_ProjectL_Battle_BattleBase.<>f__mg$cacheBA = new LuaCSFunction(Lua_BlackJack_ProjectL_Battle_BattleBase.InitWinConditionStates);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Battle_BattleBase.<>f__mg$cacheBA);
		if (Lua_BlackJack_ProjectL_Battle_BattleBase.<>f__mg$cacheBB == null)
		{
			Lua_BlackJack_ProjectL_Battle_BattleBase.<>f__mg$cacheBB = new LuaCSFunction(Lua_BlackJack_ProjectL_Battle_BattleBase.InitLoseConditionStates);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Battle_BattleBase.<>f__mg$cacheBB);
		if (Lua_BlackJack_ProjectL_Battle_BattleBase.<>f__mg$cacheBC == null)
		{
			Lua_BlackJack_ProjectL_Battle_BattleBase.<>f__mg$cacheBC = new LuaCSFunction(Lua_BlackJack_ProjectL_Battle_BattleBase.InitEventTriggerStates);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Battle_BattleBase.<>f__mg$cacheBC);
		if (Lua_BlackJack_ProjectL_Battle_BattleBase.<>f__mg$cacheBD == null)
		{
			Lua_BlackJack_ProjectL_Battle_BattleBase.<>f__mg$cacheBD = new LuaCSFunction(Lua_BlackJack_ProjectL_Battle_BattleBase.InitBattleTreasureStates);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Battle_BattleBase.<>f__mg$cacheBD);
		if (Lua_BlackJack_ProjectL_Battle_BattleBase.<>f__mg$cacheBE == null)
		{
			Lua_BlackJack_ProjectL_Battle_BattleBase.<>f__mg$cacheBE = new LuaCSFunction(Lua_BlackJack_ProjectL_Battle_BattleBase.CreateActors);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Battle_BattleBase.<>f__mg$cacheBE);
		if (Lua_BlackJack_ProjectL_Battle_BattleBase.<>f__mg$cacheBF == null)
		{
			Lua_BlackJack_ProjectL_Battle_BattleBase.<>f__mg$cacheBF = new LuaCSFunction(Lua_BlackJack_ProjectL_Battle_BattleBase.ExecuteBattlePerforms);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Battle_BattleBase.<>f__mg$cacheBF);
		if (Lua_BlackJack_ProjectL_Battle_BattleBase.<>f__mg$cacheC0 == null)
		{
			Lua_BlackJack_ProjectL_Battle_BattleBase.<>f__mg$cacheC0 = new LuaCSFunction(Lua_BlackJack_ProjectL_Battle_BattleBase.ExecuteAfterCombatSteps);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Battle_BattleBase.<>f__mg$cacheC0);
		if (Lua_BlackJack_ProjectL_Battle_BattleBase.<>f__mg$cacheC1 == null)
		{
			Lua_BlackJack_ProjectL_Battle_BattleBase.<>f__mg$cacheC1 = new LuaCSFunction(Lua_BlackJack_ProjectL_Battle_BattleBase.ExecuteBattlePerform);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Battle_BattleBase.<>f__mg$cacheC1);
		if (Lua_BlackJack_ProjectL_Battle_BattleBase.<>f__mg$cacheC2 == null)
		{
			Lua_BlackJack_ProjectL_Battle_BattleBase.<>f__mg$cacheC2 = new LuaCSFunction(Lua_BlackJack_ProjectL_Battle_BattleBase.ExecuteBattlePerform_Dialog);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Battle_BattleBase.<>f__mg$cacheC2);
		if (Lua_BlackJack_ProjectL_Battle_BattleBase.<>f__mg$cacheC3 == null)
		{
			Lua_BlackJack_ProjectL_Battle_BattleBase.<>f__mg$cacheC3 = new LuaCSFunction(Lua_BlackJack_ProjectL_Battle_BattleBase.ExecuteBattlePerform_PlayMusic);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Battle_BattleBase.<>f__mg$cacheC3);
		if (Lua_BlackJack_ProjectL_Battle_BattleBase.<>f__mg$cacheC4 == null)
		{
			Lua_BlackJack_ProjectL_Battle_BattleBase.<>f__mg$cacheC4 = new LuaCSFunction(Lua_BlackJack_ProjectL_Battle_BattleBase.ExecuteBattlePerform_PlaySound);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Battle_BattleBase.<>f__mg$cacheC4);
		if (Lua_BlackJack_ProjectL_Battle_BattleBase.<>f__mg$cacheC5 == null)
		{
			Lua_BlackJack_ProjectL_Battle_BattleBase.<>f__mg$cacheC5 = new LuaCSFunction(Lua_BlackJack_ProjectL_Battle_BattleBase.ExecuteBattlePerform_PlayFx);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Battle_BattleBase.<>f__mg$cacheC5);
		if (Lua_BlackJack_ProjectL_Battle_BattleBase.<>f__mg$cacheC6 == null)
		{
			Lua_BlackJack_ProjectL_Battle_BattleBase.<>f__mg$cacheC6 = new LuaCSFunction(Lua_BlackJack_ProjectL_Battle_BattleBase.ExecuteBattlePerform_PlayActorFx);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Battle_BattleBase.<>f__mg$cacheC6);
		if (Lua_BlackJack_ProjectL_Battle_BattleBase.<>f__mg$cacheC7 == null)
		{
			Lua_BlackJack_ProjectL_Battle_BattleBase.<>f__mg$cacheC7 = new LuaCSFunction(Lua_BlackJack_ProjectL_Battle_BattleBase.ExecuteBattlePerform_ChangeTerrain);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Battle_BattleBase.<>f__mg$cacheC7);
		if (Lua_BlackJack_ProjectL_Battle_BattleBase.<>f__mg$cacheC8 == null)
		{
			Lua_BlackJack_ProjectL_Battle_BattleBase.<>f__mg$cacheC8 = new LuaCSFunction(Lua_BlackJack_ProjectL_Battle_BattleBase.ExecuteBattlePerform_CameraFocusPosition);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Battle_BattleBase.<>f__mg$cacheC8);
		if (Lua_BlackJack_ProjectL_Battle_BattleBase.<>f__mg$cacheC9 == null)
		{
			Lua_BlackJack_ProjectL_Battle_BattleBase.<>f__mg$cacheC9 = new LuaCSFunction(Lua_BlackJack_ProjectL_Battle_BattleBase.ExecuteBattlePerform_CameraFocusActor);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Battle_BattleBase.<>f__mg$cacheC9);
		if (Lua_BlackJack_ProjectL_Battle_BattleBase.<>f__mg$cacheCA == null)
		{
			Lua_BlackJack_ProjectL_Battle_BattleBase.<>f__mg$cacheCA = new LuaCSFunction(Lua_BlackJack_ProjectL_Battle_BattleBase.ExecuteBattlePerform_CreateActor);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Battle_BattleBase.<>f__mg$cacheCA);
		if (Lua_BlackJack_ProjectL_Battle_BattleBase.<>f__mg$cacheCB == null)
		{
			Lua_BlackJack_ProjectL_Battle_BattleBase.<>f__mg$cacheCB = new LuaCSFunction(Lua_BlackJack_ProjectL_Battle_BattleBase.ExecuteBattlePerform_CreateActorNear);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Battle_BattleBase.<>f__mg$cacheCB);
		if (Lua_BlackJack_ProjectL_Battle_BattleBase.<>f__mg$cacheCC == null)
		{
			Lua_BlackJack_ProjectL_Battle_BattleBase.<>f__mg$cacheCC = new LuaCSFunction(Lua_BlackJack_ProjectL_Battle_BattleBase.ExecuteBattlePerform_RemoveActor);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Battle_BattleBase.<>f__mg$cacheCC);
		if (Lua_BlackJack_ProjectL_Battle_BattleBase.<>f__mg$cacheCD == null)
		{
			Lua_BlackJack_ProjectL_Battle_BattleBase.<>f__mg$cacheCD = new LuaCSFunction(Lua_BlackJack_ProjectL_Battle_BattleBase.ExecuteBattlePerform_ActorMove);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Battle_BattleBase.<>f__mg$cacheCD);
		if (Lua_BlackJack_ProjectL_Battle_BattleBase.<>f__mg$cacheCE == null)
		{
			Lua_BlackJack_ProjectL_Battle_BattleBase.<>f__mg$cacheCE = new LuaCSFunction(Lua_BlackJack_ProjectL_Battle_BattleBase.ExecuteBattlePerform_ActorMoveNear);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Battle_BattleBase.<>f__mg$cacheCE);
		if (Lua_BlackJack_ProjectL_Battle_BattleBase.<>f__mg$cacheCF == null)
		{
			Lua_BlackJack_ProjectL_Battle_BattleBase.<>f__mg$cacheCF = new LuaCSFunction(Lua_BlackJack_ProjectL_Battle_BattleBase.ExecuteBattlePerform_ActorAttack);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Battle_BattleBase.<>f__mg$cacheCF);
		if (Lua_BlackJack_ProjectL_Battle_BattleBase.<>f__mg$cacheD0 == null)
		{
			Lua_BlackJack_ProjectL_Battle_BattleBase.<>f__mg$cacheD0 = new LuaCSFunction(Lua_BlackJack_ProjectL_Battle_BattleBase.ExecuteBattlePerform_ActorSkill);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Battle_BattleBase.<>f__mg$cacheD0);
		if (Lua_BlackJack_ProjectL_Battle_BattleBase.<>f__mg$cacheD1 == null)
		{
			Lua_BlackJack_ProjectL_Battle_BattleBase.<>f__mg$cacheD1 = new LuaCSFunction(Lua_BlackJack_ProjectL_Battle_BattleBase.ExecuteBattlePerform_ActorDir);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Battle_BattleBase.<>f__mg$cacheD1);
		if (Lua_BlackJack_ProjectL_Battle_BattleBase.<>f__mg$cacheD2 == null)
		{
			Lua_BlackJack_ProjectL_Battle_BattleBase.<>f__mg$cacheD2 = new LuaCSFunction(Lua_BlackJack_ProjectL_Battle_BattleBase.ExecuteBattlePerform_ActorAnimation);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Battle_BattleBase.<>f__mg$cacheD2);
		if (Lua_BlackJack_ProjectL_Battle_BattleBase.<>f__mg$cacheD3 == null)
		{
			Lua_BlackJack_ProjectL_Battle_BattleBase.<>f__mg$cacheD3 = new LuaCSFunction(Lua_BlackJack_ProjectL_Battle_BattleBase.ExecuteBattlePerform_ActorIdle);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Battle_BattleBase.<>f__mg$cacheD3);
		if (Lua_BlackJack_ProjectL_Battle_BattleBase.<>f__mg$cacheD4 == null)
		{
			Lua_BlackJack_ProjectL_Battle_BattleBase.<>f__mg$cacheD4 = new LuaCSFunction(Lua_BlackJack_ProjectL_Battle_BattleBase.ExecuteBattlePerform_WaitTime);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Battle_BattleBase.<>f__mg$cacheD4);
		if (Lua_BlackJack_ProjectL_Battle_BattleBase.<>f__mg$cacheD5 == null)
		{
			Lua_BlackJack_ProjectL_Battle_BattleBase.<>f__mg$cacheD5 = new LuaCSFunction(Lua_BlackJack_ProjectL_Battle_BattleBase.ExecuteBattlePerform_StopBattle);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Battle_BattleBase.<>f__mg$cacheD5);
		if (Lua_BlackJack_ProjectL_Battle_BattleBase.<>f__mg$cacheD6 == null)
		{
			Lua_BlackJack_ProjectL_Battle_BattleBase.<>f__mg$cacheD6 = new LuaCSFunction(Lua_BlackJack_ProjectL_Battle_BattleBase.CheckBattleTreasureOnActorMove);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Battle_BattleBase.<>f__mg$cacheD6);
		if (Lua_BlackJack_ProjectL_Battle_BattleBase.<>f__mg$cacheD7 == null)
		{
			Lua_BlackJack_ProjectL_Battle_BattleBase.<>f__mg$cacheD7 = new LuaCSFunction(Lua_BlackJack_ProjectL_Battle_BattleBase.ChangeBattleTeasureStatus);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Battle_BattleBase.<>f__mg$cacheD7);
		if (Lua_BlackJack_ProjectL_Battle_BattleBase.<>f__mg$cacheD8 == null)
		{
			Lua_BlackJack_ProjectL_Battle_BattleBase.<>f__mg$cacheD8 = new LuaCSFunction(Lua_BlackJack_ProjectL_Battle_BattleBase.IsActorInPositions_s);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Battle_BattleBase.<>f__mg$cacheD8);
		if (Lua_BlackJack_ProjectL_Battle_BattleBase.<>f__mg$cacheD9 == null)
		{
			Lua_BlackJack_ProjectL_Battle_BattleBase.<>f__mg$cacheD9 = new LuaCSFunction(Lua_BlackJack_ProjectL_Battle_BattleBase.IsSkillClassMatch_s);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Battle_BattleBase.<>f__mg$cacheD9);
		if (Lua_BlackJack_ProjectL_Battle_BattleBase.<>f__mg$cacheDA == null)
		{
			Lua_BlackJack_ProjectL_Battle_BattleBase.<>f__mg$cacheDA = new LuaCSFunction(Lua_BlackJack_ProjectL_Battle_BattleBase.IsActorClassMatch_s);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Battle_BattleBase.<>f__mg$cacheDA);
		string name = "m_configDataLoader";
		if (Lua_BlackJack_ProjectL_Battle_BattleBase.<>f__mg$cacheDB == null)
		{
			Lua_BlackJack_ProjectL_Battle_BattleBase.<>f__mg$cacheDB = new LuaCSFunction(Lua_BlackJack_ProjectL_Battle_BattleBase.get_m_configDataLoader);
		}
		LuaCSFunction get = Lua_BlackJack_ProjectL_Battle_BattleBase.<>f__mg$cacheDB;
		if (Lua_BlackJack_ProjectL_Battle_BattleBase.<>f__mg$cacheDC == null)
		{
			Lua_BlackJack_ProjectL_Battle_BattleBase.<>f__mg$cacheDC = new LuaCSFunction(Lua_BlackJack_ProjectL_Battle_BattleBase.set_m_configDataLoader);
		}
		LuaObject.addMember(l, name, get, Lua_BlackJack_ProjectL_Battle_BattleBase.<>f__mg$cacheDC, true);
		string name2 = "m_battleListener";
		if (Lua_BlackJack_ProjectL_Battle_BattleBase.<>f__mg$cacheDD == null)
		{
			Lua_BlackJack_ProjectL_Battle_BattleBase.<>f__mg$cacheDD = new LuaCSFunction(Lua_BlackJack_ProjectL_Battle_BattleBase.get_m_battleListener);
		}
		LuaCSFunction get2 = Lua_BlackJack_ProjectL_Battle_BattleBase.<>f__mg$cacheDD;
		if (Lua_BlackJack_ProjectL_Battle_BattleBase.<>f__mg$cacheDE == null)
		{
			Lua_BlackJack_ProjectL_Battle_BattleBase.<>f__mg$cacheDE = new LuaCSFunction(Lua_BlackJack_ProjectL_Battle_BattleBase.set_m_battleListener);
		}
		LuaObject.addMember(l, name2, get2, Lua_BlackJack_ProjectL_Battle_BattleBase.<>f__mg$cacheDE, true);
		string name3 = "m_randomNumber";
		if (Lua_BlackJack_ProjectL_Battle_BattleBase.<>f__mg$cacheDF == null)
		{
			Lua_BlackJack_ProjectL_Battle_BattleBase.<>f__mg$cacheDF = new LuaCSFunction(Lua_BlackJack_ProjectL_Battle_BattleBase.get_m_randomNumber);
		}
		LuaCSFunction get3 = Lua_BlackJack_ProjectL_Battle_BattleBase.<>f__mg$cacheDF;
		if (Lua_BlackJack_ProjectL_Battle_BattleBase.<>f__mg$cacheE0 == null)
		{
			Lua_BlackJack_ProjectL_Battle_BattleBase.<>f__mg$cacheE0 = new LuaCSFunction(Lua_BlackJack_ProjectL_Battle_BattleBase.set_m_randomNumber);
		}
		LuaObject.addMember(l, name3, get3, Lua_BlackJack_ProjectL_Battle_BattleBase.<>f__mg$cacheE0, true);
		string name4 = "m_aiRandomNumber1";
		if (Lua_BlackJack_ProjectL_Battle_BattleBase.<>f__mg$cacheE1 == null)
		{
			Lua_BlackJack_ProjectL_Battle_BattleBase.<>f__mg$cacheE1 = new LuaCSFunction(Lua_BlackJack_ProjectL_Battle_BattleBase.get_m_aiRandomNumber1);
		}
		LuaCSFunction get4 = Lua_BlackJack_ProjectL_Battle_BattleBase.<>f__mg$cacheE1;
		if (Lua_BlackJack_ProjectL_Battle_BattleBase.<>f__mg$cacheE2 == null)
		{
			Lua_BlackJack_ProjectL_Battle_BattleBase.<>f__mg$cacheE2 = new LuaCSFunction(Lua_BlackJack_ProjectL_Battle_BattleBase.set_m_aiRandomNumber1);
		}
		LuaObject.addMember(l, name4, get4, Lua_BlackJack_ProjectL_Battle_BattleBase.<>f__mg$cacheE2, true);
		string name5 = "m_aiRandomNumber2";
		if (Lua_BlackJack_ProjectL_Battle_BattleBase.<>f__mg$cacheE3 == null)
		{
			Lua_BlackJack_ProjectL_Battle_BattleBase.<>f__mg$cacheE3 = new LuaCSFunction(Lua_BlackJack_ProjectL_Battle_BattleBase.get_m_aiRandomNumber2);
		}
		LuaCSFunction get5 = Lua_BlackJack_ProjectL_Battle_BattleBase.<>f__mg$cacheE3;
		if (Lua_BlackJack_ProjectL_Battle_BattleBase.<>f__mg$cacheE4 == null)
		{
			Lua_BlackJack_ProjectL_Battle_BattleBase.<>f__mg$cacheE4 = new LuaCSFunction(Lua_BlackJack_ProjectL_Battle_BattleBase.set_m_aiRandomNumber2);
		}
		LuaObject.addMember(l, name5, get5, Lua_BlackJack_ProjectL_Battle_BattleBase.<>f__mg$cacheE4, true);
		string name6 = "m_armyRandomNumber";
		if (Lua_BlackJack_ProjectL_Battle_BattleBase.<>f__mg$cacheE5 == null)
		{
			Lua_BlackJack_ProjectL_Battle_BattleBase.<>f__mg$cacheE5 = new LuaCSFunction(Lua_BlackJack_ProjectL_Battle_BattleBase.get_m_armyRandomNumber);
		}
		LuaCSFunction get6 = Lua_BlackJack_ProjectL_Battle_BattleBase.<>f__mg$cacheE5;
		if (Lua_BlackJack_ProjectL_Battle_BattleBase.<>f__mg$cacheE6 == null)
		{
			Lua_BlackJack_ProjectL_Battle_BattleBase.<>f__mg$cacheE6 = new LuaCSFunction(Lua_BlackJack_ProjectL_Battle_BattleBase.set_m_armyRandomNumber);
		}
		LuaObject.addMember(l, name6, get6, Lua_BlackJack_ProjectL_Battle_BattleBase.<>f__mg$cacheE6, true);
		string name7 = "m_map";
		if (Lua_BlackJack_ProjectL_Battle_BattleBase.<>f__mg$cacheE7 == null)
		{
			Lua_BlackJack_ProjectL_Battle_BattleBase.<>f__mg$cacheE7 = new LuaCSFunction(Lua_BlackJack_ProjectL_Battle_BattleBase.get_m_map);
		}
		LuaCSFunction get7 = Lua_BlackJack_ProjectL_Battle_BattleBase.<>f__mg$cacheE7;
		if (Lua_BlackJack_ProjectL_Battle_BattleBase.<>f__mg$cacheE8 == null)
		{
			Lua_BlackJack_ProjectL_Battle_BattleBase.<>f__mg$cacheE8 = new LuaCSFunction(Lua_BlackJack_ProjectL_Battle_BattleBase.set_m_map);
		}
		LuaObject.addMember(l, name7, get7, Lua_BlackJack_ProjectL_Battle_BattleBase.<>f__mg$cacheE8, true);
		string name8 = "m_pathfinder";
		if (Lua_BlackJack_ProjectL_Battle_BattleBase.<>f__mg$cacheE9 == null)
		{
			Lua_BlackJack_ProjectL_Battle_BattleBase.<>f__mg$cacheE9 = new LuaCSFunction(Lua_BlackJack_ProjectL_Battle_BattleBase.get_m_pathfinder);
		}
		LuaCSFunction get8 = Lua_BlackJack_ProjectL_Battle_BattleBase.<>f__mg$cacheE9;
		if (Lua_BlackJack_ProjectL_Battle_BattleBase.<>f__mg$cacheEA == null)
		{
			Lua_BlackJack_ProjectL_Battle_BattleBase.<>f__mg$cacheEA = new LuaCSFunction(Lua_BlackJack_ProjectL_Battle_BattleBase.set_m_pathfinder);
		}
		LuaObject.addMember(l, name8, get8, Lua_BlackJack_ProjectL_Battle_BattleBase.<>f__mg$cacheEA, true);
		string name9 = "m_combat";
		if (Lua_BlackJack_ProjectL_Battle_BattleBase.<>f__mg$cacheEB == null)
		{
			Lua_BlackJack_ProjectL_Battle_BattleBase.<>f__mg$cacheEB = new LuaCSFunction(Lua_BlackJack_ProjectL_Battle_BattleBase.get_m_combat);
		}
		LuaCSFunction get9 = Lua_BlackJack_ProjectL_Battle_BattleBase.<>f__mg$cacheEB;
		if (Lua_BlackJack_ProjectL_Battle_BattleBase.<>f__mg$cacheEC == null)
		{
			Lua_BlackJack_ProjectL_Battle_BattleBase.<>f__mg$cacheEC = new LuaCSFunction(Lua_BlackJack_ProjectL_Battle_BattleBase.set_m_combat);
		}
		LuaObject.addMember(l, name9, get9, Lua_BlackJack_ProjectL_Battle_BattleBase.<>f__mg$cacheEC, true);
		string name10 = "m_battlefieldInfo";
		if (Lua_BlackJack_ProjectL_Battle_BattleBase.<>f__mg$cacheED == null)
		{
			Lua_BlackJack_ProjectL_Battle_BattleBase.<>f__mg$cacheED = new LuaCSFunction(Lua_BlackJack_ProjectL_Battle_BattleBase.get_m_battlefieldInfo);
		}
		LuaCSFunction get10 = Lua_BlackJack_ProjectL_Battle_BattleBase.<>f__mg$cacheED;
		if (Lua_BlackJack_ProjectL_Battle_BattleBase.<>f__mg$cacheEE == null)
		{
			Lua_BlackJack_ProjectL_Battle_BattleBase.<>f__mg$cacheEE = new LuaCSFunction(Lua_BlackJack_ProjectL_Battle_BattleBase.set_m_battlefieldInfo);
		}
		LuaObject.addMember(l, name10, get10, Lua_BlackJack_ProjectL_Battle_BattleBase.<>f__mg$cacheEE, true);
		string name11 = "m_battleInfo";
		if (Lua_BlackJack_ProjectL_Battle_BattleBase.<>f__mg$cacheEF == null)
		{
			Lua_BlackJack_ProjectL_Battle_BattleBase.<>f__mg$cacheEF = new LuaCSFunction(Lua_BlackJack_ProjectL_Battle_BattleBase.get_m_battleInfo);
		}
		LuaCSFunction get11 = Lua_BlackJack_ProjectL_Battle_BattleBase.<>f__mg$cacheEF;
		if (Lua_BlackJack_ProjectL_Battle_BattleBase.<>f__mg$cacheF0 == null)
		{
			Lua_BlackJack_ProjectL_Battle_BattleBase.<>f__mg$cacheF0 = new LuaCSFunction(Lua_BlackJack_ProjectL_Battle_BattleBase.set_m_battleInfo);
		}
		LuaObject.addMember(l, name11, get11, Lua_BlackJack_ProjectL_Battle_BattleBase.<>f__mg$cacheF0, true);
		string name12 = "m_arenaBattleInfo";
		if (Lua_BlackJack_ProjectL_Battle_BattleBase.<>f__mg$cacheF1 == null)
		{
			Lua_BlackJack_ProjectL_Battle_BattleBase.<>f__mg$cacheF1 = new LuaCSFunction(Lua_BlackJack_ProjectL_Battle_BattleBase.get_m_arenaBattleInfo);
		}
		LuaCSFunction get12 = Lua_BlackJack_ProjectL_Battle_BattleBase.<>f__mg$cacheF1;
		if (Lua_BlackJack_ProjectL_Battle_BattleBase.<>f__mg$cacheF2 == null)
		{
			Lua_BlackJack_ProjectL_Battle_BattleBase.<>f__mg$cacheF2 = new LuaCSFunction(Lua_BlackJack_ProjectL_Battle_BattleBase.set_m_arenaBattleInfo);
		}
		LuaObject.addMember(l, name12, get12, Lua_BlackJack_ProjectL_Battle_BattleBase.<>f__mg$cacheF2, true);
		string name13 = "m_pvpBattleInfo";
		if (Lua_BlackJack_ProjectL_Battle_BattleBase.<>f__mg$cacheF3 == null)
		{
			Lua_BlackJack_ProjectL_Battle_BattleBase.<>f__mg$cacheF3 = new LuaCSFunction(Lua_BlackJack_ProjectL_Battle_BattleBase.get_m_pvpBattleInfo);
		}
		LuaCSFunction get13 = Lua_BlackJack_ProjectL_Battle_BattleBase.<>f__mg$cacheF3;
		if (Lua_BlackJack_ProjectL_Battle_BattleBase.<>f__mg$cacheF4 == null)
		{
			Lua_BlackJack_ProjectL_Battle_BattleBase.<>f__mg$cacheF4 = new LuaCSFunction(Lua_BlackJack_ProjectL_Battle_BattleBase.set_m_pvpBattleInfo);
		}
		LuaObject.addMember(l, name13, get13, Lua_BlackJack_ProjectL_Battle_BattleBase.<>f__mg$cacheF4, true);
		string name14 = "m_realtimePvpBattleInfo";
		if (Lua_BlackJack_ProjectL_Battle_BattleBase.<>f__mg$cacheF5 == null)
		{
			Lua_BlackJack_ProjectL_Battle_BattleBase.<>f__mg$cacheF5 = new LuaCSFunction(Lua_BlackJack_ProjectL_Battle_BattleBase.get_m_realtimePvpBattleInfo);
		}
		LuaCSFunction get14 = Lua_BlackJack_ProjectL_Battle_BattleBase.<>f__mg$cacheF5;
		if (Lua_BlackJack_ProjectL_Battle_BattleBase.<>f__mg$cacheF6 == null)
		{
			Lua_BlackJack_ProjectL_Battle_BattleBase.<>f__mg$cacheF6 = new LuaCSFunction(Lua_BlackJack_ProjectL_Battle_BattleBase.set_m_realtimePvpBattleInfo);
		}
		LuaObject.addMember(l, name14, get14, Lua_BlackJack_ProjectL_Battle_BattleBase.<>f__mg$cacheF6, true);
		string name15 = "m_battleType";
		if (Lua_BlackJack_ProjectL_Battle_BattleBase.<>f__mg$cacheF7 == null)
		{
			Lua_BlackJack_ProjectL_Battle_BattleBase.<>f__mg$cacheF7 = new LuaCSFunction(Lua_BlackJack_ProjectL_Battle_BattleBase.get_m_battleType);
		}
		LuaCSFunction get15 = Lua_BlackJack_ProjectL_Battle_BattleBase.<>f__mg$cacheF7;
		if (Lua_BlackJack_ProjectL_Battle_BattleBase.<>f__mg$cacheF8 == null)
		{
			Lua_BlackJack_ProjectL_Battle_BattleBase.<>f__mg$cacheF8 = new LuaCSFunction(Lua_BlackJack_ProjectL_Battle_BattleBase.set_m_battleType);
		}
		LuaObject.addMember(l, name15, get15, Lua_BlackJack_ProjectL_Battle_BattleBase.<>f__mg$cacheF8, true);
		string name16 = "m_monsterLevel";
		if (Lua_BlackJack_ProjectL_Battle_BattleBase.<>f__mg$cacheF9 == null)
		{
			Lua_BlackJack_ProjectL_Battle_BattleBase.<>f__mg$cacheF9 = new LuaCSFunction(Lua_BlackJack_ProjectL_Battle_BattleBase.get_m_monsterLevel);
		}
		LuaCSFunction get16 = Lua_BlackJack_ProjectL_Battle_BattleBase.<>f__mg$cacheF9;
		if (Lua_BlackJack_ProjectL_Battle_BattleBase.<>f__mg$cacheFA == null)
		{
			Lua_BlackJack_ProjectL_Battle_BattleBase.<>f__mg$cacheFA = new LuaCSFunction(Lua_BlackJack_ProjectL_Battle_BattleBase.set_m_monsterLevel);
		}
		LuaObject.addMember(l, name16, get16, Lua_BlackJack_ProjectL_Battle_BattleBase.<>f__mg$cacheFA, true);
		string name17 = "m_teams";
		if (Lua_BlackJack_ProjectL_Battle_BattleBase.<>f__mg$cacheFB == null)
		{
			Lua_BlackJack_ProjectL_Battle_BattleBase.<>f__mg$cacheFB = new LuaCSFunction(Lua_BlackJack_ProjectL_Battle_BattleBase.get_m_teams);
		}
		LuaCSFunction get17 = Lua_BlackJack_ProjectL_Battle_BattleBase.<>f__mg$cacheFB;
		if (Lua_BlackJack_ProjectL_Battle_BattleBase.<>f__mg$cacheFC == null)
		{
			Lua_BlackJack_ProjectL_Battle_BattleBase.<>f__mg$cacheFC = new LuaCSFunction(Lua_BlackJack_ProjectL_Battle_BattleBase.set_m_teams);
		}
		LuaObject.addMember(l, name17, get17, Lua_BlackJack_ProjectL_Battle_BattleBase.<>f__mg$cacheFC, true);
		string name18 = "m_players";
		if (Lua_BlackJack_ProjectL_Battle_BattleBase.<>f__mg$cacheFD == null)
		{
			Lua_BlackJack_ProjectL_Battle_BattleBase.<>f__mg$cacheFD = new LuaCSFunction(Lua_BlackJack_ProjectL_Battle_BattleBase.get_m_players);
		}
		LuaCSFunction get18 = Lua_BlackJack_ProjectL_Battle_BattleBase.<>f__mg$cacheFD;
		if (Lua_BlackJack_ProjectL_Battle_BattleBase.<>f__mg$cacheFE == null)
		{
			Lua_BlackJack_ProjectL_Battle_BattleBase.<>f__mg$cacheFE = new LuaCSFunction(Lua_BlackJack_ProjectL_Battle_BattleBase.set_m_players);
		}
		LuaObject.addMember(l, name18, get18, Lua_BlackJack_ProjectL_Battle_BattleBase.<>f__mg$cacheFE, true);
		string name19 = "m_maxPlayerLevelInfo";
		if (Lua_BlackJack_ProjectL_Battle_BattleBase.<>f__mg$cacheFF == null)
		{
			Lua_BlackJack_ProjectL_Battle_BattleBase.<>f__mg$cacheFF = new LuaCSFunction(Lua_BlackJack_ProjectL_Battle_BattleBase.get_m_maxPlayerLevelInfo);
		}
		LuaCSFunction get19 = Lua_BlackJack_ProjectL_Battle_BattleBase.<>f__mg$cacheFF;
		if (Lua_BlackJack_ProjectL_Battle_BattleBase.<>f__mg$cache100 == null)
		{
			Lua_BlackJack_ProjectL_Battle_BattleBase.<>f__mg$cache100 = new LuaCSFunction(Lua_BlackJack_ProjectL_Battle_BattleBase.set_m_maxPlayerLevelInfo);
		}
		LuaObject.addMember(l, name19, get19, Lua_BlackJack_ProjectL_Battle_BattleBase.<>f__mg$cache100, true);
		string name20 = "m_state";
		if (Lua_BlackJack_ProjectL_Battle_BattleBase.<>f__mg$cache101 == null)
		{
			Lua_BlackJack_ProjectL_Battle_BattleBase.<>f__mg$cache101 = new LuaCSFunction(Lua_BlackJack_ProjectL_Battle_BattleBase.get_m_state);
		}
		LuaCSFunction get20 = Lua_BlackJack_ProjectL_Battle_BattleBase.<>f__mg$cache101;
		if (Lua_BlackJack_ProjectL_Battle_BattleBase.<>f__mg$cache102 == null)
		{
			Lua_BlackJack_ProjectL_Battle_BattleBase.<>f__mg$cache102 = new LuaCSFunction(Lua_BlackJack_ProjectL_Battle_BattleBase.set_m_state);
		}
		LuaObject.addMember(l, name20, get20, Lua_BlackJack_ProjectL_Battle_BattleBase.<>f__mg$cache102, true);
		string name21 = "m_step";
		if (Lua_BlackJack_ProjectL_Battle_BattleBase.<>f__mg$cache103 == null)
		{
			Lua_BlackJack_ProjectL_Battle_BattleBase.<>f__mg$cache103 = new LuaCSFunction(Lua_BlackJack_ProjectL_Battle_BattleBase.get_m_step);
		}
		LuaCSFunction get21 = Lua_BlackJack_ProjectL_Battle_BattleBase.<>f__mg$cache103;
		if (Lua_BlackJack_ProjectL_Battle_BattleBase.<>f__mg$cache104 == null)
		{
			Lua_BlackJack_ProjectL_Battle_BattleBase.<>f__mg$cache104 = new LuaCSFunction(Lua_BlackJack_ProjectL_Battle_BattleBase.set_m_step);
		}
		LuaObject.addMember(l, name21, get21, Lua_BlackJack_ProjectL_Battle_BattleBase.<>f__mg$cache104, true);
		string name22 = "m_turn";
		if (Lua_BlackJack_ProjectL_Battle_BattleBase.<>f__mg$cache105 == null)
		{
			Lua_BlackJack_ProjectL_Battle_BattleBase.<>f__mg$cache105 = new LuaCSFunction(Lua_BlackJack_ProjectL_Battle_BattleBase.get_m_turn);
		}
		LuaCSFunction get22 = Lua_BlackJack_ProjectL_Battle_BattleBase.<>f__mg$cache105;
		if (Lua_BlackJack_ProjectL_Battle_BattleBase.<>f__mg$cache106 == null)
		{
			Lua_BlackJack_ProjectL_Battle_BattleBase.<>f__mg$cache106 = new LuaCSFunction(Lua_BlackJack_ProjectL_Battle_BattleBase.set_m_turn);
		}
		LuaObject.addMember(l, name22, get22, Lua_BlackJack_ProjectL_Battle_BattleBase.<>f__mg$cache106, true);
		string name23 = "m_turnMax";
		if (Lua_BlackJack_ProjectL_Battle_BattleBase.<>f__mg$cache107 == null)
		{
			Lua_BlackJack_ProjectL_Battle_BattleBase.<>f__mg$cache107 = new LuaCSFunction(Lua_BlackJack_ProjectL_Battle_BattleBase.get_m_turnMax);
		}
		LuaCSFunction get23 = Lua_BlackJack_ProjectL_Battle_BattleBase.<>f__mg$cache107;
		if (Lua_BlackJack_ProjectL_Battle_BattleBase.<>f__mg$cache108 == null)
		{
			Lua_BlackJack_ProjectL_Battle_BattleBase.<>f__mg$cache108 = new LuaCSFunction(Lua_BlackJack_ProjectL_Battle_BattleBase.set_m_turnMax);
		}
		LuaObject.addMember(l, name23, get23, Lua_BlackJack_ProjectL_Battle_BattleBase.<>f__mg$cache108, true);
		string name24 = "m_actionTeam";
		if (Lua_BlackJack_ProjectL_Battle_BattleBase.<>f__mg$cache109 == null)
		{
			Lua_BlackJack_ProjectL_Battle_BattleBase.<>f__mg$cache109 = new LuaCSFunction(Lua_BlackJack_ProjectL_Battle_BattleBase.get_m_actionTeam);
		}
		LuaCSFunction get24 = Lua_BlackJack_ProjectL_Battle_BattleBase.<>f__mg$cache109;
		if (Lua_BlackJack_ProjectL_Battle_BattleBase.<>f__mg$cache10A == null)
		{
			Lua_BlackJack_ProjectL_Battle_BattleBase.<>f__mg$cache10A = new LuaCSFunction(Lua_BlackJack_ProjectL_Battle_BattleBase.set_m_actionTeam);
		}
		LuaObject.addMember(l, name24, get24, Lua_BlackJack_ProjectL_Battle_BattleBase.<>f__mg$cache10A, true);
		string name25 = "m_prevActionPlayerIndex";
		if (Lua_BlackJack_ProjectL_Battle_BattleBase.<>f__mg$cache10B == null)
		{
			Lua_BlackJack_ProjectL_Battle_BattleBase.<>f__mg$cache10B = new LuaCSFunction(Lua_BlackJack_ProjectL_Battle_BattleBase.get_m_prevActionPlayerIndex);
		}
		LuaCSFunction get25 = Lua_BlackJack_ProjectL_Battle_BattleBase.<>f__mg$cache10B;
		if (Lua_BlackJack_ProjectL_Battle_BattleBase.<>f__mg$cache10C == null)
		{
			Lua_BlackJack_ProjectL_Battle_BattleBase.<>f__mg$cache10C = new LuaCSFunction(Lua_BlackJack_ProjectL_Battle_BattleBase.set_m_prevActionPlayerIndex);
		}
		LuaObject.addMember(l, name25, get25, Lua_BlackJack_ProjectL_Battle_BattleBase.<>f__mg$cache10C, true);
		string name26 = "m_actionActor";
		if (Lua_BlackJack_ProjectL_Battle_BattleBase.<>f__mg$cache10D == null)
		{
			Lua_BlackJack_ProjectL_Battle_BattleBase.<>f__mg$cache10D = new LuaCSFunction(Lua_BlackJack_ProjectL_Battle_BattleBase.get_m_actionActor);
		}
		LuaCSFunction get26 = Lua_BlackJack_ProjectL_Battle_BattleBase.<>f__mg$cache10D;
		if (Lua_BlackJack_ProjectL_Battle_BattleBase.<>f__mg$cache10E == null)
		{
			Lua_BlackJack_ProjectL_Battle_BattleBase.<>f__mg$cache10E = new LuaCSFunction(Lua_BlackJack_ProjectL_Battle_BattleBase.set_m_actionActor);
		}
		LuaObject.addMember(l, name26, get26, Lua_BlackJack_ProjectL_Battle_BattleBase.<>f__mg$cache10E, true);
		string name27 = "m_actionOrderType";
		if (Lua_BlackJack_ProjectL_Battle_BattleBase.<>f__mg$cache10F == null)
		{
			Lua_BlackJack_ProjectL_Battle_BattleBase.<>f__mg$cache10F = new LuaCSFunction(Lua_BlackJack_ProjectL_Battle_BattleBase.get_m_actionOrderType);
		}
		LuaCSFunction get27 = Lua_BlackJack_ProjectL_Battle_BattleBase.<>f__mg$cache10F;
		if (Lua_BlackJack_ProjectL_Battle_BattleBase.<>f__mg$cache110 == null)
		{
			Lua_BlackJack_ProjectL_Battle_BattleBase.<>f__mg$cache110 = new LuaCSFunction(Lua_BlackJack_ProjectL_Battle_BattleBase.set_m_actionOrderType);
		}
		LuaObject.addMember(l, name27, get27, Lua_BlackJack_ProjectL_Battle_BattleBase.<>f__mg$cache110, true);
		string name28 = "m_entityIdCounter";
		if (Lua_BlackJack_ProjectL_Battle_BattleBase.<>f__mg$cache111 == null)
		{
			Lua_BlackJack_ProjectL_Battle_BattleBase.<>f__mg$cache111 = new LuaCSFunction(Lua_BlackJack_ProjectL_Battle_BattleBase.get_m_entityIdCounter);
		}
		LuaCSFunction get28 = Lua_BlackJack_ProjectL_Battle_BattleBase.<>f__mg$cache111;
		if (Lua_BlackJack_ProjectL_Battle_BattleBase.<>f__mg$cache112 == null)
		{
			Lua_BlackJack_ProjectL_Battle_BattleBase.<>f__mg$cache112 = new LuaCSFunction(Lua_BlackJack_ProjectL_Battle_BattleBase.set_m_entityIdCounter);
		}
		LuaObject.addMember(l, name28, get28, Lua_BlackJack_ProjectL_Battle_BattleBase.<>f__mg$cache112, true);
		string name29 = "m_needCheckBattleStopEventTrigger";
		if (Lua_BlackJack_ProjectL_Battle_BattleBase.<>f__mg$cache113 == null)
		{
			Lua_BlackJack_ProjectL_Battle_BattleBase.<>f__mg$cache113 = new LuaCSFunction(Lua_BlackJack_ProjectL_Battle_BattleBase.get_m_needCheckBattleStopEventTrigger);
		}
		LuaCSFunction get29 = Lua_BlackJack_ProjectL_Battle_BattleBase.<>f__mg$cache113;
		if (Lua_BlackJack_ProjectL_Battle_BattleBase.<>f__mg$cache114 == null)
		{
			Lua_BlackJack_ProjectL_Battle_BattleBase.<>f__mg$cache114 = new LuaCSFunction(Lua_BlackJack_ProjectL_Battle_BattleBase.set_m_needCheckBattleStopEventTrigger);
		}
		LuaObject.addMember(l, name29, get29, Lua_BlackJack_ProjectL_Battle_BattleBase.<>f__mg$cache114, true);
		string name30 = "m_isGiveupBattle";
		if (Lua_BlackJack_ProjectL_Battle_BattleBase.<>f__mg$cache115 == null)
		{
			Lua_BlackJack_ProjectL_Battle_BattleBase.<>f__mg$cache115 = new LuaCSFunction(Lua_BlackJack_ProjectL_Battle_BattleBase.get_m_isGiveupBattle);
		}
		LuaCSFunction get30 = Lua_BlackJack_ProjectL_Battle_BattleBase.<>f__mg$cache115;
		if (Lua_BlackJack_ProjectL_Battle_BattleBase.<>f__mg$cache116 == null)
		{
			Lua_BlackJack_ProjectL_Battle_BattleBase.<>f__mg$cache116 = new LuaCSFunction(Lua_BlackJack_ProjectL_Battle_BattleBase.set_m_isGiveupBattle);
		}
		LuaObject.addMember(l, name30, get30, Lua_BlackJack_ProjectL_Battle_BattleBase.<>f__mg$cache116, true);
		string name31 = "m_giveupBattlePlayerIndex";
		if (Lua_BlackJack_ProjectL_Battle_BattleBase.<>f__mg$cache117 == null)
		{
			Lua_BlackJack_ProjectL_Battle_BattleBase.<>f__mg$cache117 = new LuaCSFunction(Lua_BlackJack_ProjectL_Battle_BattleBase.get_m_giveupBattlePlayerIndex);
		}
		LuaCSFunction get31 = Lua_BlackJack_ProjectL_Battle_BattleBase.<>f__mg$cache117;
		if (Lua_BlackJack_ProjectL_Battle_BattleBase.<>f__mg$cache118 == null)
		{
			Lua_BlackJack_ProjectL_Battle_BattleBase.<>f__mg$cache118 = new LuaCSFunction(Lua_BlackJack_ProjectL_Battle_BattleBase.set_m_giveupBattlePlayerIndex);
		}
		LuaObject.addMember(l, name31, get31, Lua_BlackJack_ProjectL_Battle_BattleBase.<>f__mg$cache118, true);
		string name32 = "m_combatRandomSeed";
		if (Lua_BlackJack_ProjectL_Battle_BattleBase.<>f__mg$cache119 == null)
		{
			Lua_BlackJack_ProjectL_Battle_BattleBase.<>f__mg$cache119 = new LuaCSFunction(Lua_BlackJack_ProjectL_Battle_BattleBase.get_m_combatRandomSeed);
		}
		LuaCSFunction get32 = Lua_BlackJack_ProjectL_Battle_BattleBase.<>f__mg$cache119;
		if (Lua_BlackJack_ProjectL_Battle_BattleBase.<>f__mg$cache11A == null)
		{
			Lua_BlackJack_ProjectL_Battle_BattleBase.<>f__mg$cache11A = new LuaCSFunction(Lua_BlackJack_ProjectL_Battle_BattleBase.set_m_combatRandomSeed);
		}
		LuaObject.addMember(l, name32, get32, Lua_BlackJack_ProjectL_Battle_BattleBase.<>f__mg$cache11A, true);
		string name33 = "m_combatActorA";
		if (Lua_BlackJack_ProjectL_Battle_BattleBase.<>f__mg$cache11B == null)
		{
			Lua_BlackJack_ProjectL_Battle_BattleBase.<>f__mg$cache11B = new LuaCSFunction(Lua_BlackJack_ProjectL_Battle_BattleBase.get_m_combatActorA);
		}
		LuaCSFunction get33 = Lua_BlackJack_ProjectL_Battle_BattleBase.<>f__mg$cache11B;
		if (Lua_BlackJack_ProjectL_Battle_BattleBase.<>f__mg$cache11C == null)
		{
			Lua_BlackJack_ProjectL_Battle_BattleBase.<>f__mg$cache11C = new LuaCSFunction(Lua_BlackJack_ProjectL_Battle_BattleBase.set_m_combatActorA);
		}
		LuaObject.addMember(l, name33, get33, Lua_BlackJack_ProjectL_Battle_BattleBase.<>f__mg$cache11C, true);
		string name34 = "m_combatActorB";
		if (Lua_BlackJack_ProjectL_Battle_BattleBase.<>f__mg$cache11D == null)
		{
			Lua_BlackJack_ProjectL_Battle_BattleBase.<>f__mg$cache11D = new LuaCSFunction(Lua_BlackJack_ProjectL_Battle_BattleBase.get_m_combatActorB);
		}
		LuaCSFunction get34 = Lua_BlackJack_ProjectL_Battle_BattleBase.<>f__mg$cache11D;
		if (Lua_BlackJack_ProjectL_Battle_BattleBase.<>f__mg$cache11E == null)
		{
			Lua_BlackJack_ProjectL_Battle_BattleBase.<>f__mg$cache11E = new LuaCSFunction(Lua_BlackJack_ProjectL_Battle_BattleBase.set_m_combatActorB);
		}
		LuaObject.addMember(l, name34, get34, Lua_BlackJack_ProjectL_Battle_BattleBase.<>f__mg$cache11E, true);
		string name35 = "m_combatSkillInfoA";
		if (Lua_BlackJack_ProjectL_Battle_BattleBase.<>f__mg$cache11F == null)
		{
			Lua_BlackJack_ProjectL_Battle_BattleBase.<>f__mg$cache11F = new LuaCSFunction(Lua_BlackJack_ProjectL_Battle_BattleBase.get_m_combatSkillInfoA);
		}
		LuaCSFunction get35 = Lua_BlackJack_ProjectL_Battle_BattleBase.<>f__mg$cache11F;
		if (Lua_BlackJack_ProjectL_Battle_BattleBase.<>f__mg$cache120 == null)
		{
			Lua_BlackJack_ProjectL_Battle_BattleBase.<>f__mg$cache120 = new LuaCSFunction(Lua_BlackJack_ProjectL_Battle_BattleBase.set_m_combatSkillInfoA);
		}
		LuaObject.addMember(l, name35, get35, Lua_BlackJack_ProjectL_Battle_BattleBase.<>f__mg$cache120, true);
		string name36 = "m_beGuardedCombatActor";
		if (Lua_BlackJack_ProjectL_Battle_BattleBase.<>f__mg$cache121 == null)
		{
			Lua_BlackJack_ProjectL_Battle_BattleBase.<>f__mg$cache121 = new LuaCSFunction(Lua_BlackJack_ProjectL_Battle_BattleBase.get_m_beGuardedCombatActor);
		}
		LuaCSFunction get36 = Lua_BlackJack_ProjectL_Battle_BattleBase.<>f__mg$cache121;
		if (Lua_BlackJack_ProjectL_Battle_BattleBase.<>f__mg$cache122 == null)
		{
			Lua_BlackJack_ProjectL_Battle_BattleBase.<>f__mg$cache122 = new LuaCSFunction(Lua_BlackJack_ProjectL_Battle_BattleBase.set_m_beGuardedCombatActor);
		}
		LuaObject.addMember(l, name36, get36, Lua_BlackJack_ProjectL_Battle_BattleBase.<>f__mg$cache122, true);
		string name37 = "m_isPerformCombat";
		if (Lua_BlackJack_ProjectL_Battle_BattleBase.<>f__mg$cache123 == null)
		{
			Lua_BlackJack_ProjectL_Battle_BattleBase.<>f__mg$cache123 = new LuaCSFunction(Lua_BlackJack_ProjectL_Battle_BattleBase.get_m_isPerformCombat);
		}
		LuaCSFunction get37 = Lua_BlackJack_ProjectL_Battle_BattleBase.<>f__mg$cache123;
		if (Lua_BlackJack_ProjectL_Battle_BattleBase.<>f__mg$cache124 == null)
		{
			Lua_BlackJack_ProjectL_Battle_BattleBase.<>f__mg$cache124 = new LuaCSFunction(Lua_BlackJack_ProjectL_Battle_BattleBase.set_m_isPerformCombat);
		}
		LuaObject.addMember(l, name37, get37, Lua_BlackJack_ProjectL_Battle_BattleBase.<>f__mg$cache124, true);
		string name38 = "m_afterComatPerform";
		if (Lua_BlackJack_ProjectL_Battle_BattleBase.<>f__mg$cache125 == null)
		{
			Lua_BlackJack_ProjectL_Battle_BattleBase.<>f__mg$cache125 = new LuaCSFunction(Lua_BlackJack_ProjectL_Battle_BattleBase.get_m_afterComatPerform);
		}
		LuaCSFunction get38 = Lua_BlackJack_ProjectL_Battle_BattleBase.<>f__mg$cache125;
		if (Lua_BlackJack_ProjectL_Battle_BattleBase.<>f__mg$cache126 == null)
		{
			Lua_BlackJack_ProjectL_Battle_BattleBase.<>f__mg$cache126 = new LuaCSFunction(Lua_BlackJack_ProjectL_Battle_BattleBase.set_m_afterComatPerform);
		}
		LuaObject.addMember(l, name38, get38, Lua_BlackJack_ProjectL_Battle_BattleBase.<>f__mg$cache126, true);
		string name39 = "m_afterCombatExecuteTriggerState";
		if (Lua_BlackJack_ProjectL_Battle_BattleBase.<>f__mg$cache127 == null)
		{
			Lua_BlackJack_ProjectL_Battle_BattleBase.<>f__mg$cache127 = new LuaCSFunction(Lua_BlackJack_ProjectL_Battle_BattleBase.get_m_afterCombatExecuteTriggerState);
		}
		LuaCSFunction get39 = Lua_BlackJack_ProjectL_Battle_BattleBase.<>f__mg$cache127;
		if (Lua_BlackJack_ProjectL_Battle_BattleBase.<>f__mg$cache128 == null)
		{
			Lua_BlackJack_ProjectL_Battle_BattleBase.<>f__mg$cache128 = new LuaCSFunction(Lua_BlackJack_ProjectL_Battle_BattleBase.set_m_afterCombatExecuteTriggerState);
		}
		LuaObject.addMember(l, name39, get39, Lua_BlackJack_ProjectL_Battle_BattleBase.<>f__mg$cache128, true);
		string name40 = "m_afterCombatExecuteTriggerEventActionIndex";
		if (Lua_BlackJack_ProjectL_Battle_BattleBase.<>f__mg$cache129 == null)
		{
			Lua_BlackJack_ProjectL_Battle_BattleBase.<>f__mg$cache129 = new LuaCSFunction(Lua_BlackJack_ProjectL_Battle_BattleBase.get_m_afterCombatExecuteTriggerEventActionIndex);
		}
		LuaCSFunction get40 = Lua_BlackJack_ProjectL_Battle_BattleBase.<>f__mg$cache129;
		if (Lua_BlackJack_ProjectL_Battle_BattleBase.<>f__mg$cache12A == null)
		{
			Lua_BlackJack_ProjectL_Battle_BattleBase.<>f__mg$cache12A = new LuaCSFunction(Lua_BlackJack_ProjectL_Battle_BattleBase.set_m_afterCombatExecuteTriggerEventActionIndex);
		}
		LuaObject.addMember(l, name40, get40, Lua_BlackJack_ProjectL_Battle_BattleBase.<>f__mg$cache12A, true);
		string name41 = "m_isAfterCombatNextStep";
		if (Lua_BlackJack_ProjectL_Battle_BattleBase.<>f__mg$cache12B == null)
		{
			Lua_BlackJack_ProjectL_Battle_BattleBase.<>f__mg$cache12B = new LuaCSFunction(Lua_BlackJack_ProjectL_Battle_BattleBase.get_m_isAfterCombatNextStep);
		}
		LuaCSFunction get41 = Lua_BlackJack_ProjectL_Battle_BattleBase.<>f__mg$cache12B;
		if (Lua_BlackJack_ProjectL_Battle_BattleBase.<>f__mg$cache12C == null)
		{
			Lua_BlackJack_ProjectL_Battle_BattleBase.<>f__mg$cache12C = new LuaCSFunction(Lua_BlackJack_ProjectL_Battle_BattleBase.set_m_isAfterCombatNextStep);
		}
		LuaObject.addMember(l, name41, get41, Lua_BlackJack_ProjectL_Battle_BattleBase.<>f__mg$cache12C, true);
		string name42 = "m_isAfterCombatNextStepActorActive";
		if (Lua_BlackJack_ProjectL_Battle_BattleBase.<>f__mg$cache12D == null)
		{
			Lua_BlackJack_ProjectL_Battle_BattleBase.<>f__mg$cache12D = new LuaCSFunction(Lua_BlackJack_ProjectL_Battle_BattleBase.get_m_isAfterCombatNextStepActorActive);
		}
		LuaCSFunction get42 = Lua_BlackJack_ProjectL_Battle_BattleBase.<>f__mg$cache12D;
		if (Lua_BlackJack_ProjectL_Battle_BattleBase.<>f__mg$cache12E == null)
		{
			Lua_BlackJack_ProjectL_Battle_BattleBase.<>f__mg$cache12E = new LuaCSFunction(Lua_BlackJack_ProjectL_Battle_BattleBase.set_m_isAfterCombatNextStepActorActive);
		}
		LuaObject.addMember(l, name42, get42, Lua_BlackJack_ProjectL_Battle_BattleBase.<>f__mg$cache12E, true);
		string name43 = "m_tempIntLists";
		if (Lua_BlackJack_ProjectL_Battle_BattleBase.<>f__mg$cache12F == null)
		{
			Lua_BlackJack_ProjectL_Battle_BattleBase.<>f__mg$cache12F = new LuaCSFunction(Lua_BlackJack_ProjectL_Battle_BattleBase.get_m_tempIntLists);
		}
		LuaCSFunction get43 = Lua_BlackJack_ProjectL_Battle_BattleBase.<>f__mg$cache12F;
		if (Lua_BlackJack_ProjectL_Battle_BattleBase.<>f__mg$cache130 == null)
		{
			Lua_BlackJack_ProjectL_Battle_BattleBase.<>f__mg$cache130 = new LuaCSFunction(Lua_BlackJack_ProjectL_Battle_BattleBase.set_m_tempIntLists);
		}
		LuaObject.addMember(l, name43, get43, Lua_BlackJack_ProjectL_Battle_BattleBase.<>f__mg$cache130, true);
		string name44 = "m_freeIntListIndex";
		if (Lua_BlackJack_ProjectL_Battle_BattleBase.<>f__mg$cache131 == null)
		{
			Lua_BlackJack_ProjectL_Battle_BattleBase.<>f__mg$cache131 = new LuaCSFunction(Lua_BlackJack_ProjectL_Battle_BattleBase.get_m_freeIntListIndex);
		}
		LuaCSFunction get44 = Lua_BlackJack_ProjectL_Battle_BattleBase.<>f__mg$cache131;
		if (Lua_BlackJack_ProjectL_Battle_BattleBase.<>f__mg$cache132 == null)
		{
			Lua_BlackJack_ProjectL_Battle_BattleBase.<>f__mg$cache132 = new LuaCSFunction(Lua_BlackJack_ProjectL_Battle_BattleBase.set_m_freeIntListIndex);
		}
		LuaObject.addMember(l, name44, get44, Lua_BlackJack_ProjectL_Battle_BattleBase.<>f__mg$cache132, true);
		string name45 = "m_tempGridPositionLists";
		if (Lua_BlackJack_ProjectL_Battle_BattleBase.<>f__mg$cache133 == null)
		{
			Lua_BlackJack_ProjectL_Battle_BattleBase.<>f__mg$cache133 = new LuaCSFunction(Lua_BlackJack_ProjectL_Battle_BattleBase.get_m_tempGridPositionLists);
		}
		LuaCSFunction get45 = Lua_BlackJack_ProjectL_Battle_BattleBase.<>f__mg$cache133;
		if (Lua_BlackJack_ProjectL_Battle_BattleBase.<>f__mg$cache134 == null)
		{
			Lua_BlackJack_ProjectL_Battle_BattleBase.<>f__mg$cache134 = new LuaCSFunction(Lua_BlackJack_ProjectL_Battle_BattleBase.set_m_tempGridPositionLists);
		}
		LuaObject.addMember(l, name45, get45, Lua_BlackJack_ProjectL_Battle_BattleBase.<>f__mg$cache134, true);
		string name46 = "m_freeGridPositionListIndex";
		if (Lua_BlackJack_ProjectL_Battle_BattleBase.<>f__mg$cache135 == null)
		{
			Lua_BlackJack_ProjectL_Battle_BattleBase.<>f__mg$cache135 = new LuaCSFunction(Lua_BlackJack_ProjectL_Battle_BattleBase.get_m_freeGridPositionListIndex);
		}
		LuaCSFunction get46 = Lua_BlackJack_ProjectL_Battle_BattleBase.<>f__mg$cache135;
		if (Lua_BlackJack_ProjectL_Battle_BattleBase.<>f__mg$cache136 == null)
		{
			Lua_BlackJack_ProjectL_Battle_BattleBase.<>f__mg$cache136 = new LuaCSFunction(Lua_BlackJack_ProjectL_Battle_BattleBase.set_m_freeGridPositionListIndex);
		}
		LuaObject.addMember(l, name46, get46, Lua_BlackJack_ProjectL_Battle_BattleBase.<>f__mg$cache136, true);
		string name47 = "m_tempActorLists";
		if (Lua_BlackJack_ProjectL_Battle_BattleBase.<>f__mg$cache137 == null)
		{
			Lua_BlackJack_ProjectL_Battle_BattleBase.<>f__mg$cache137 = new LuaCSFunction(Lua_BlackJack_ProjectL_Battle_BattleBase.get_m_tempActorLists);
		}
		LuaCSFunction get47 = Lua_BlackJack_ProjectL_Battle_BattleBase.<>f__mg$cache137;
		if (Lua_BlackJack_ProjectL_Battle_BattleBase.<>f__mg$cache138 == null)
		{
			Lua_BlackJack_ProjectL_Battle_BattleBase.<>f__mg$cache138 = new LuaCSFunction(Lua_BlackJack_ProjectL_Battle_BattleBase.set_m_tempActorLists);
		}
		LuaObject.addMember(l, name47, get47, Lua_BlackJack_ProjectL_Battle_BattleBase.<>f__mg$cache138, true);
		string name48 = "m_freeActorListIndex";
		if (Lua_BlackJack_ProjectL_Battle_BattleBase.<>f__mg$cache139 == null)
		{
			Lua_BlackJack_ProjectL_Battle_BattleBase.<>f__mg$cache139 = new LuaCSFunction(Lua_BlackJack_ProjectL_Battle_BattleBase.get_m_freeActorListIndex);
		}
		LuaCSFunction get48 = Lua_BlackJack_ProjectL_Battle_BattleBase.<>f__mg$cache139;
		if (Lua_BlackJack_ProjectL_Battle_BattleBase.<>f__mg$cache13A == null)
		{
			Lua_BlackJack_ProjectL_Battle_BattleBase.<>f__mg$cache13A = new LuaCSFunction(Lua_BlackJack_ProjectL_Battle_BattleBase.set_m_freeActorListIndex);
		}
		LuaObject.addMember(l, name48, get48, Lua_BlackJack_ProjectL_Battle_BattleBase.<>f__mg$cache13A, true);
		string name49 = "m_tempBuffLists";
		if (Lua_BlackJack_ProjectL_Battle_BattleBase.<>f__mg$cache13B == null)
		{
			Lua_BlackJack_ProjectL_Battle_BattleBase.<>f__mg$cache13B = new LuaCSFunction(Lua_BlackJack_ProjectL_Battle_BattleBase.get_m_tempBuffLists);
		}
		LuaCSFunction get49 = Lua_BlackJack_ProjectL_Battle_BattleBase.<>f__mg$cache13B;
		if (Lua_BlackJack_ProjectL_Battle_BattleBase.<>f__mg$cache13C == null)
		{
			Lua_BlackJack_ProjectL_Battle_BattleBase.<>f__mg$cache13C = new LuaCSFunction(Lua_BlackJack_ProjectL_Battle_BattleBase.set_m_tempBuffLists);
		}
		LuaObject.addMember(l, name49, get49, Lua_BlackJack_ProjectL_Battle_BattleBase.<>f__mg$cache13C, true);
		string name50 = "m_freeBuffListIndex";
		if (Lua_BlackJack_ProjectL_Battle_BattleBase.<>f__mg$cache13D == null)
		{
			Lua_BlackJack_ProjectL_Battle_BattleBase.<>f__mg$cache13D = new LuaCSFunction(Lua_BlackJack_ProjectL_Battle_BattleBase.get_m_freeBuffListIndex);
		}
		LuaCSFunction get50 = Lua_BlackJack_ProjectL_Battle_BattleBase.<>f__mg$cache13D;
		if (Lua_BlackJack_ProjectL_Battle_BattleBase.<>f__mg$cache13E == null)
		{
			Lua_BlackJack_ProjectL_Battle_BattleBase.<>f__mg$cache13E = new LuaCSFunction(Lua_BlackJack_ProjectL_Battle_BattleBase.set_m_freeBuffListIndex);
		}
		LuaObject.addMember(l, name50, get50, Lua_BlackJack_ProjectL_Battle_BattleBase.<>f__mg$cache13E, true);
		string name51 = "m_tempBuffStateLists";
		if (Lua_BlackJack_ProjectL_Battle_BattleBase.<>f__mg$cache13F == null)
		{
			Lua_BlackJack_ProjectL_Battle_BattleBase.<>f__mg$cache13F = new LuaCSFunction(Lua_BlackJack_ProjectL_Battle_BattleBase.get_m_tempBuffStateLists);
		}
		LuaCSFunction get51 = Lua_BlackJack_ProjectL_Battle_BattleBase.<>f__mg$cache13F;
		if (Lua_BlackJack_ProjectL_Battle_BattleBase.<>f__mg$cache140 == null)
		{
			Lua_BlackJack_ProjectL_Battle_BattleBase.<>f__mg$cache140 = new LuaCSFunction(Lua_BlackJack_ProjectL_Battle_BattleBase.set_m_tempBuffStateLists);
		}
		LuaObject.addMember(l, name51, get51, Lua_BlackJack_ProjectL_Battle_BattleBase.<>f__mg$cache140, true);
		string name52 = "m_freeBuffStateListIndex";
		if (Lua_BlackJack_ProjectL_Battle_BattleBase.<>f__mg$cache141 == null)
		{
			Lua_BlackJack_ProjectL_Battle_BattleBase.<>f__mg$cache141 = new LuaCSFunction(Lua_BlackJack_ProjectL_Battle_BattleBase.get_m_freeBuffStateListIndex);
		}
		LuaCSFunction get52 = Lua_BlackJack_ProjectL_Battle_BattleBase.<>f__mg$cache141;
		if (Lua_BlackJack_ProjectL_Battle_BattleBase.<>f__mg$cache142 == null)
		{
			Lua_BlackJack_ProjectL_Battle_BattleBase.<>f__mg$cache142 = new LuaCSFunction(Lua_BlackJack_ProjectL_Battle_BattleBase.set_m_freeBuffStateListIndex);
		}
		LuaObject.addMember(l, name52, get52, Lua_BlackJack_ProjectL_Battle_BattleBase.<>f__mg$cache142, true);
		string name53 = "m_tempBattlePropertyModifier";
		if (Lua_BlackJack_ProjectL_Battle_BattleBase.<>f__mg$cache143 == null)
		{
			Lua_BlackJack_ProjectL_Battle_BattleBase.<>f__mg$cache143 = new LuaCSFunction(Lua_BlackJack_ProjectL_Battle_BattleBase.get_m_tempBattlePropertyModifier);
		}
		LuaCSFunction get53 = Lua_BlackJack_ProjectL_Battle_BattleBase.<>f__mg$cache143;
		if (Lua_BlackJack_ProjectL_Battle_BattleBase.<>f__mg$cache144 == null)
		{
			Lua_BlackJack_ProjectL_Battle_BattleBase.<>f__mg$cache144 = new LuaCSFunction(Lua_BlackJack_ProjectL_Battle_BattleBase.set_m_tempBattlePropertyModifier);
		}
		LuaObject.addMember(l, name53, get53, Lua_BlackJack_ProjectL_Battle_BattleBase.<>f__mg$cache144, true);
		string name54 = "m_battleCommands";
		if (Lua_BlackJack_ProjectL_Battle_BattleBase.<>f__mg$cache145 == null)
		{
			Lua_BlackJack_ProjectL_Battle_BattleBase.<>f__mg$cache145 = new LuaCSFunction(Lua_BlackJack_ProjectL_Battle_BattleBase.get_m_battleCommands);
		}
		LuaCSFunction get54 = Lua_BlackJack_ProjectL_Battle_BattleBase.<>f__mg$cache145;
		if (Lua_BlackJack_ProjectL_Battle_BattleBase.<>f__mg$cache146 == null)
		{
			Lua_BlackJack_ProjectL_Battle_BattleBase.<>f__mg$cache146 = new LuaCSFunction(Lua_BlackJack_ProjectL_Battle_BattleBase.set_m_battleCommands);
		}
		LuaObject.addMember(l, name54, get54, Lua_BlackJack_ProjectL_Battle_BattleBase.<>f__mg$cache146, true);
		string name55 = "m_logBattleCommands";
		if (Lua_BlackJack_ProjectL_Battle_BattleBase.<>f__mg$cache147 == null)
		{
			Lua_BlackJack_ProjectL_Battle_BattleBase.<>f__mg$cache147 = new LuaCSFunction(Lua_BlackJack_ProjectL_Battle_BattleBase.get_m_logBattleCommands);
		}
		LuaCSFunction get55 = Lua_BlackJack_ProjectL_Battle_BattleBase.<>f__mg$cache147;
		if (Lua_BlackJack_ProjectL_Battle_BattleBase.<>f__mg$cache148 == null)
		{
			Lua_BlackJack_ProjectL_Battle_BattleBase.<>f__mg$cache148 = new LuaCSFunction(Lua_BlackJack_ProjectL_Battle_BattleBase.set_m_logBattleCommands);
		}
		LuaObject.addMember(l, name55, get55, Lua_BlackJack_ProjectL_Battle_BattleBase.<>f__mg$cache148, true);
		string name56 = "m_tempBattleCommands";
		if (Lua_BlackJack_ProjectL_Battle_BattleBase.<>f__mg$cache149 == null)
		{
			Lua_BlackJack_ProjectL_Battle_BattleBase.<>f__mg$cache149 = new LuaCSFunction(Lua_BlackJack_ProjectL_Battle_BattleBase.get_m_tempBattleCommands);
		}
		LuaCSFunction get56 = Lua_BlackJack_ProjectL_Battle_BattleBase.<>f__mg$cache149;
		if (Lua_BlackJack_ProjectL_Battle_BattleBase.<>f__mg$cache14A == null)
		{
			Lua_BlackJack_ProjectL_Battle_BattleBase.<>f__mg$cache14A = new LuaCSFunction(Lua_BlackJack_ProjectL_Battle_BattleBase.set_m_tempBattleCommands);
		}
		LuaObject.addMember(l, name56, get56, Lua_BlackJack_ProjectL_Battle_BattleBase.<>f__mg$cache14A, true);
		string name57 = "m_stepExecutedCommands";
		if (Lua_BlackJack_ProjectL_Battle_BattleBase.<>f__mg$cache14B == null)
		{
			Lua_BlackJack_ProjectL_Battle_BattleBase.<>f__mg$cache14B = new LuaCSFunction(Lua_BlackJack_ProjectL_Battle_BattleBase.get_m_stepExecutedCommands);
		}
		LuaCSFunction get57 = Lua_BlackJack_ProjectL_Battle_BattleBase.<>f__mg$cache14B;
		if (Lua_BlackJack_ProjectL_Battle_BattleBase.<>f__mg$cache14C == null)
		{
			Lua_BlackJack_ProjectL_Battle_BattleBase.<>f__mg$cache14C = new LuaCSFunction(Lua_BlackJack_ProjectL_Battle_BattleBase.set_m_stepExecutedCommands);
		}
		LuaObject.addMember(l, name57, get57, Lua_BlackJack_ProjectL_Battle_BattleBase.<>f__mg$cache14C, true);
		string name58 = "m_enableLogBattleCommands";
		if (Lua_BlackJack_ProjectL_Battle_BattleBase.<>f__mg$cache14D == null)
		{
			Lua_BlackJack_ProjectL_Battle_BattleBase.<>f__mg$cache14D = new LuaCSFunction(Lua_BlackJack_ProjectL_Battle_BattleBase.get_m_enableLogBattleCommands);
		}
		LuaCSFunction get58 = Lua_BlackJack_ProjectL_Battle_BattleBase.<>f__mg$cache14D;
		if (Lua_BlackJack_ProjectL_Battle_BattleBase.<>f__mg$cache14E == null)
		{
			Lua_BlackJack_ProjectL_Battle_BattleBase.<>f__mg$cache14E = new LuaCSFunction(Lua_BlackJack_ProjectL_Battle_BattleBase.set_m_enableLogBattleCommands);
		}
		LuaObject.addMember(l, name58, get58, Lua_BlackJack_ProjectL_Battle_BattleBase.<>f__mg$cache14E, true);
		string name59 = "m_enableTempBattleCommands";
		if (Lua_BlackJack_ProjectL_Battle_BattleBase.<>f__mg$cache14F == null)
		{
			Lua_BlackJack_ProjectL_Battle_BattleBase.<>f__mg$cache14F = new LuaCSFunction(Lua_BlackJack_ProjectL_Battle_BattleBase.get_m_enableTempBattleCommands);
		}
		LuaCSFunction get59 = Lua_BlackJack_ProjectL_Battle_BattleBase.<>f__mg$cache14F;
		if (Lua_BlackJack_ProjectL_Battle_BattleBase.<>f__mg$cache150 == null)
		{
			Lua_BlackJack_ProjectL_Battle_BattleBase.<>f__mg$cache150 = new LuaCSFunction(Lua_BlackJack_ProjectL_Battle_BattleBase.set_m_enableTempBattleCommands);
		}
		LuaObject.addMember(l, name59, get59, Lua_BlackJack_ProjectL_Battle_BattleBase.<>f__mg$cache150, true);
		string name60 = "m_enableDebugLog";
		if (Lua_BlackJack_ProjectL_Battle_BattleBase.<>f__mg$cache151 == null)
		{
			Lua_BlackJack_ProjectL_Battle_BattleBase.<>f__mg$cache151 = new LuaCSFunction(Lua_BlackJack_ProjectL_Battle_BattleBase.get_m_enableDebugLog);
		}
		LuaCSFunction get60 = Lua_BlackJack_ProjectL_Battle_BattleBase.<>f__mg$cache151;
		if (Lua_BlackJack_ProjectL_Battle_BattleBase.<>f__mg$cache152 == null)
		{
			Lua_BlackJack_ProjectL_Battle_BattleBase.<>f__mg$cache152 = new LuaCSFunction(Lua_BlackJack_ProjectL_Battle_BattleBase.set_m_enableDebugLog);
		}
		LuaObject.addMember(l, name60, get60, Lua_BlackJack_ProjectL_Battle_BattleBase.<>f__mg$cache152, true);
		string name61 = "m_enableChecksum";
		if (Lua_BlackJack_ProjectL_Battle_BattleBase.<>f__mg$cache153 == null)
		{
			Lua_BlackJack_ProjectL_Battle_BattleBase.<>f__mg$cache153 = new LuaCSFunction(Lua_BlackJack_ProjectL_Battle_BattleBase.get_m_enableChecksum);
		}
		LuaCSFunction get61 = Lua_BlackJack_ProjectL_Battle_BattleBase.<>f__mg$cache153;
		if (Lua_BlackJack_ProjectL_Battle_BattleBase.<>f__mg$cache154 == null)
		{
			Lua_BlackJack_ProjectL_Battle_BattleBase.<>f__mg$cache154 = new LuaCSFunction(Lua_BlackJack_ProjectL_Battle_BattleBase.set_m_enableChecksum);
		}
		LuaObject.addMember(l, name61, get61, Lua_BlackJack_ProjectL_Battle_BattleBase.<>f__mg$cache154, true);
		string name62 = "m_checksums";
		if (Lua_BlackJack_ProjectL_Battle_BattleBase.<>f__mg$cache155 == null)
		{
			Lua_BlackJack_ProjectL_Battle_BattleBase.<>f__mg$cache155 = new LuaCSFunction(Lua_BlackJack_ProjectL_Battle_BattleBase.get_m_checksums);
		}
		LuaCSFunction get62 = Lua_BlackJack_ProjectL_Battle_BattleBase.<>f__mg$cache155;
		if (Lua_BlackJack_ProjectL_Battle_BattleBase.<>f__mg$cache156 == null)
		{
			Lua_BlackJack_ProjectL_Battle_BattleBase.<>f__mg$cache156 = new LuaCSFunction(Lua_BlackJack_ProjectL_Battle_BattleBase.set_m_checksums);
		}
		LuaObject.addMember(l, name62, get62, Lua_BlackJack_ProjectL_Battle_BattleBase.<>f__mg$cache156, true);
		string name63 = "m_winConditionStates";
		if (Lua_BlackJack_ProjectL_Battle_BattleBase.<>f__mg$cache157 == null)
		{
			Lua_BlackJack_ProjectL_Battle_BattleBase.<>f__mg$cache157 = new LuaCSFunction(Lua_BlackJack_ProjectL_Battle_BattleBase.get_m_winConditionStates);
		}
		LuaCSFunction get63 = Lua_BlackJack_ProjectL_Battle_BattleBase.<>f__mg$cache157;
		if (Lua_BlackJack_ProjectL_Battle_BattleBase.<>f__mg$cache158 == null)
		{
			Lua_BlackJack_ProjectL_Battle_BattleBase.<>f__mg$cache158 = new LuaCSFunction(Lua_BlackJack_ProjectL_Battle_BattleBase.set_m_winConditionStates);
		}
		LuaObject.addMember(l, name63, get63, Lua_BlackJack_ProjectL_Battle_BattleBase.<>f__mg$cache158, true);
		string name64 = "m_loseConditionStates";
		if (Lua_BlackJack_ProjectL_Battle_BattleBase.<>f__mg$cache159 == null)
		{
			Lua_BlackJack_ProjectL_Battle_BattleBase.<>f__mg$cache159 = new LuaCSFunction(Lua_BlackJack_ProjectL_Battle_BattleBase.get_m_loseConditionStates);
		}
		LuaCSFunction get64 = Lua_BlackJack_ProjectL_Battle_BattleBase.<>f__mg$cache159;
		if (Lua_BlackJack_ProjectL_Battle_BattleBase.<>f__mg$cache15A == null)
		{
			Lua_BlackJack_ProjectL_Battle_BattleBase.<>f__mg$cache15A = new LuaCSFunction(Lua_BlackJack_ProjectL_Battle_BattleBase.set_m_loseConditionStates);
		}
		LuaObject.addMember(l, name64, get64, Lua_BlackJack_ProjectL_Battle_BattleBase.<>f__mg$cache15A, true);
		string name65 = "m_achievementStates";
		if (Lua_BlackJack_ProjectL_Battle_BattleBase.<>f__mg$cache15B == null)
		{
			Lua_BlackJack_ProjectL_Battle_BattleBase.<>f__mg$cache15B = new LuaCSFunction(Lua_BlackJack_ProjectL_Battle_BattleBase.get_m_achievementStates);
		}
		LuaCSFunction get65 = Lua_BlackJack_ProjectL_Battle_BattleBase.<>f__mg$cache15B;
		if (Lua_BlackJack_ProjectL_Battle_BattleBase.<>f__mg$cache15C == null)
		{
			Lua_BlackJack_ProjectL_Battle_BattleBase.<>f__mg$cache15C = new LuaCSFunction(Lua_BlackJack_ProjectL_Battle_BattleBase.set_m_achievementStates);
		}
		LuaObject.addMember(l, name65, get65, Lua_BlackJack_ProjectL_Battle_BattleBase.<>f__mg$cache15C, true);
		string name66 = "m_eventTriggerStates";
		if (Lua_BlackJack_ProjectL_Battle_BattleBase.<>f__mg$cache15D == null)
		{
			Lua_BlackJack_ProjectL_Battle_BattleBase.<>f__mg$cache15D = new LuaCSFunction(Lua_BlackJack_ProjectL_Battle_BattleBase.get_m_eventTriggerStates);
		}
		LuaCSFunction get66 = Lua_BlackJack_ProjectL_Battle_BattleBase.<>f__mg$cache15D;
		if (Lua_BlackJack_ProjectL_Battle_BattleBase.<>f__mg$cache15E == null)
		{
			Lua_BlackJack_ProjectL_Battle_BattleBase.<>f__mg$cache15E = new LuaCSFunction(Lua_BlackJack_ProjectL_Battle_BattleBase.set_m_eventTriggerStates);
		}
		LuaObject.addMember(l, name66, get66, Lua_BlackJack_ProjectL_Battle_BattleBase.<>f__mg$cache15E, true);
		string name67 = "m_battleTreasureStates";
		if (Lua_BlackJack_ProjectL_Battle_BattleBase.<>f__mg$cache15F == null)
		{
			Lua_BlackJack_ProjectL_Battle_BattleBase.<>f__mg$cache15F = new LuaCSFunction(Lua_BlackJack_ProjectL_Battle_BattleBase.get_m_battleTreasureStates);
		}
		LuaCSFunction get67 = Lua_BlackJack_ProjectL_Battle_BattleBase.<>f__mg$cache15F;
		if (Lua_BlackJack_ProjectL_Battle_BattleBase.<>f__mg$cache160 == null)
		{
			Lua_BlackJack_ProjectL_Battle_BattleBase.<>f__mg$cache160 = new LuaCSFunction(Lua_BlackJack_ProjectL_Battle_BattleBase.set_m_battleTreasureStates);
		}
		LuaObject.addMember(l, name67, get67, Lua_BlackJack_ProjectL_Battle_BattleBase.<>f__mg$cache160, true);
		string name68 = "m_stars";
		if (Lua_BlackJack_ProjectL_Battle_BattleBase.<>f__mg$cache161 == null)
		{
			Lua_BlackJack_ProjectL_Battle_BattleBase.<>f__mg$cache161 = new LuaCSFunction(Lua_BlackJack_ProjectL_Battle_BattleBase.get_m_stars);
		}
		LuaCSFunction get68 = Lua_BlackJack_ProjectL_Battle_BattleBase.<>f__mg$cache161;
		if (Lua_BlackJack_ProjectL_Battle_BattleBase.<>f__mg$cache162 == null)
		{
			Lua_BlackJack_ProjectL_Battle_BattleBase.<>f__mg$cache162 = new LuaCSFunction(Lua_BlackJack_ProjectL_Battle_BattleBase.set_m_stars);
		}
		LuaObject.addMember(l, name68, get68, Lua_BlackJack_ProjectL_Battle_BattleBase.<>f__mg$cache162, true);
		string name69 = "m_starTurnMax";
		if (Lua_BlackJack_ProjectL_Battle_BattleBase.<>f__mg$cache163 == null)
		{
			Lua_BlackJack_ProjectL_Battle_BattleBase.<>f__mg$cache163 = new LuaCSFunction(Lua_BlackJack_ProjectL_Battle_BattleBase.get_m_starTurnMax);
		}
		LuaCSFunction get69 = Lua_BlackJack_ProjectL_Battle_BattleBase.<>f__mg$cache163;
		if (Lua_BlackJack_ProjectL_Battle_BattleBase.<>f__mg$cache164 == null)
		{
			Lua_BlackJack_ProjectL_Battle_BattleBase.<>f__mg$cache164 = new LuaCSFunction(Lua_BlackJack_ProjectL_Battle_BattleBase.set_m_starTurnMax);
		}
		LuaObject.addMember(l, name69, get69, Lua_BlackJack_ProjectL_Battle_BattleBase.<>f__mg$cache164, true);
		string name70 = "m_starDeadMax";
		if (Lua_BlackJack_ProjectL_Battle_BattleBase.<>f__mg$cache165 == null)
		{
			Lua_BlackJack_ProjectL_Battle_BattleBase.<>f__mg$cache165 = new LuaCSFunction(Lua_BlackJack_ProjectL_Battle_BattleBase.get_m_starDeadMax);
		}
		LuaCSFunction get70 = Lua_BlackJack_ProjectL_Battle_BattleBase.<>f__mg$cache165;
		if (Lua_BlackJack_ProjectL_Battle_BattleBase.<>f__mg$cache166 == null)
		{
			Lua_BlackJack_ProjectL_Battle_BattleBase.<>f__mg$cache166 = new LuaCSFunction(Lua_BlackJack_ProjectL_Battle_BattleBase.set_m_starDeadMax);
		}
		LuaObject.addMember(l, name70, get70, Lua_BlackJack_ProjectL_Battle_BattleBase.<>f__mg$cache166, true);
		string name71 = "m_myPlayerTeam";
		if (Lua_BlackJack_ProjectL_Battle_BattleBase.<>f__mg$cache167 == null)
		{
			Lua_BlackJack_ProjectL_Battle_BattleBase.<>f__mg$cache167 = new LuaCSFunction(Lua_BlackJack_ProjectL_Battle_BattleBase.get_m_myPlayerTeam);
		}
		LuaCSFunction get71 = Lua_BlackJack_ProjectL_Battle_BattleBase.<>f__mg$cache167;
		if (Lua_BlackJack_ProjectL_Battle_BattleBase.<>f__mg$cache168 == null)
		{
			Lua_BlackJack_ProjectL_Battle_BattleBase.<>f__mg$cache168 = new LuaCSFunction(Lua_BlackJack_ProjectL_Battle_BattleBase.set_m_myPlayerTeam);
		}
		LuaObject.addMember(l, name71, get71, Lua_BlackJack_ProjectL_Battle_BattleBase.<>f__mg$cache168, true);
		string name72 = "AliveActorsInfo";
		if (Lua_BlackJack_ProjectL_Battle_BattleBase.<>f__mg$cache169 == null)
		{
			Lua_BlackJack_ProjectL_Battle_BattleBase.<>f__mg$cache169 = new LuaCSFunction(Lua_BlackJack_ProjectL_Battle_BattleBase.get_AliveActorsInfo);
		}
		LuaObject.addMember(l, name72, Lua_BlackJack_ProjectL_Battle_BattleBase.<>f__mg$cache169, null, true);
		string name73 = "ConfigDataLoader";
		if (Lua_BlackJack_ProjectL_Battle_BattleBase.<>f__mg$cache16A == null)
		{
			Lua_BlackJack_ProjectL_Battle_BattleBase.<>f__mg$cache16A = new LuaCSFunction(Lua_BlackJack_ProjectL_Battle_BattleBase.get_ConfigDataLoader);
		}
		LuaObject.addMember(l, name73, Lua_BlackJack_ProjectL_Battle_BattleBase.<>f__mg$cache16A, null, true);
		string name74 = "Listener";
		if (Lua_BlackJack_ProjectL_Battle_BattleBase.<>f__mg$cache16B == null)
		{
			Lua_BlackJack_ProjectL_Battle_BattleBase.<>f__mg$cache16B = new LuaCSFunction(Lua_BlackJack_ProjectL_Battle_BattleBase.get_Listener);
		}
		LuaObject.addMember(l, name74, Lua_BlackJack_ProjectL_Battle_BattleBase.<>f__mg$cache16B, null, true);
		string name75 = "RandomNumber";
		if (Lua_BlackJack_ProjectL_Battle_BattleBase.<>f__mg$cache16C == null)
		{
			Lua_BlackJack_ProjectL_Battle_BattleBase.<>f__mg$cache16C = new LuaCSFunction(Lua_BlackJack_ProjectL_Battle_BattleBase.get_RandomNumber);
		}
		LuaObject.addMember(l, name75, Lua_BlackJack_ProjectL_Battle_BattleBase.<>f__mg$cache16C, null, true);
		string name76 = "AIRandomNumber1";
		if (Lua_BlackJack_ProjectL_Battle_BattleBase.<>f__mg$cache16D == null)
		{
			Lua_BlackJack_ProjectL_Battle_BattleBase.<>f__mg$cache16D = new LuaCSFunction(Lua_BlackJack_ProjectL_Battle_BattleBase.get_AIRandomNumber1);
		}
		LuaObject.addMember(l, name76, Lua_BlackJack_ProjectL_Battle_BattleBase.<>f__mg$cache16D, null, true);
		string name77 = "AIRandomNumber2";
		if (Lua_BlackJack_ProjectL_Battle_BattleBase.<>f__mg$cache16E == null)
		{
			Lua_BlackJack_ProjectL_Battle_BattleBase.<>f__mg$cache16E = new LuaCSFunction(Lua_BlackJack_ProjectL_Battle_BattleBase.get_AIRandomNumber2);
		}
		LuaObject.addMember(l, name77, Lua_BlackJack_ProjectL_Battle_BattleBase.<>f__mg$cache16E, null, true);
		string name78 = "BattleInfo";
		if (Lua_BlackJack_ProjectL_Battle_BattleBase.<>f__mg$cache16F == null)
		{
			Lua_BlackJack_ProjectL_Battle_BattleBase.<>f__mg$cache16F = new LuaCSFunction(Lua_BlackJack_ProjectL_Battle_BattleBase.get_BattleInfo);
		}
		LuaObject.addMember(l, name78, Lua_BlackJack_ProjectL_Battle_BattleBase.<>f__mg$cache16F, null, true);
		string name79 = "ArenaBattleInfo";
		if (Lua_BlackJack_ProjectL_Battle_BattleBase.<>f__mg$cache170 == null)
		{
			Lua_BlackJack_ProjectL_Battle_BattleBase.<>f__mg$cache170 = new LuaCSFunction(Lua_BlackJack_ProjectL_Battle_BattleBase.get_ArenaBattleInfo);
		}
		LuaObject.addMember(l, name79, Lua_BlackJack_ProjectL_Battle_BattleBase.<>f__mg$cache170, null, true);
		string name80 = "PVPBattleInfo";
		if (Lua_BlackJack_ProjectL_Battle_BattleBase.<>f__mg$cache171 == null)
		{
			Lua_BlackJack_ProjectL_Battle_BattleBase.<>f__mg$cache171 = new LuaCSFunction(Lua_BlackJack_ProjectL_Battle_BattleBase.get_PVPBattleInfo);
		}
		LuaObject.addMember(l, name80, Lua_BlackJack_ProjectL_Battle_BattleBase.<>f__mg$cache171, null, true);
		string name81 = "RealTimePVPBattleInfo";
		if (Lua_BlackJack_ProjectL_Battle_BattleBase.<>f__mg$cache172 == null)
		{
			Lua_BlackJack_ProjectL_Battle_BattleBase.<>f__mg$cache172 = new LuaCSFunction(Lua_BlackJack_ProjectL_Battle_BattleBase.get_RealTimePVPBattleInfo);
		}
		LuaObject.addMember(l, name81, Lua_BlackJack_ProjectL_Battle_BattleBase.<>f__mg$cache172, null, true);
		string name82 = "BattleType";
		if (Lua_BlackJack_ProjectL_Battle_BattleBase.<>f__mg$cache173 == null)
		{
			Lua_BlackJack_ProjectL_Battle_BattleBase.<>f__mg$cache173 = new LuaCSFunction(Lua_BlackJack_ProjectL_Battle_BattleBase.get_BattleType);
		}
		LuaObject.addMember(l, name82, Lua_BlackJack_ProjectL_Battle_BattleBase.<>f__mg$cache173, null, true);
		string name83 = "ActionOrderType";
		if (Lua_BlackJack_ProjectL_Battle_BattleBase.<>f__mg$cache174 == null)
		{
			Lua_BlackJack_ProjectL_Battle_BattleBase.<>f__mg$cache174 = new LuaCSFunction(Lua_BlackJack_ProjectL_Battle_BattleBase.get_ActionOrderType);
		}
		LuaObject.addMember(l, name83, Lua_BlackJack_ProjectL_Battle_BattleBase.<>f__mg$cache174, null, true);
		string name84 = "BattlePlayers";
		if (Lua_BlackJack_ProjectL_Battle_BattleBase.<>f__mg$cache175 == null)
		{
			Lua_BlackJack_ProjectL_Battle_BattleBase.<>f__mg$cache175 = new LuaCSFunction(Lua_BlackJack_ProjectL_Battle_BattleBase.get_BattlePlayers);
		}
		LuaObject.addMember(l, name84, Lua_BlackJack_ProjectL_Battle_BattleBase.<>f__mg$cache175, null, true);
		string name85 = "MaxPlayerLevelInfo";
		if (Lua_BlackJack_ProjectL_Battle_BattleBase.<>f__mg$cache176 == null)
		{
			Lua_BlackJack_ProjectL_Battle_BattleBase.<>f__mg$cache176 = new LuaCSFunction(Lua_BlackJack_ProjectL_Battle_BattleBase.get_MaxPlayerLevelInfo);
		}
		LuaObject.addMember(l, name85, Lua_BlackJack_ProjectL_Battle_BattleBase.<>f__mg$cache176, null, true);
		string name86 = "State";
		if (Lua_BlackJack_ProjectL_Battle_BattleBase.<>f__mg$cache177 == null)
		{
			Lua_BlackJack_ProjectL_Battle_BattleBase.<>f__mg$cache177 = new LuaCSFunction(Lua_BlackJack_ProjectL_Battle_BattleBase.get_State);
		}
		LuaObject.addMember(l, name86, Lua_BlackJack_ProjectL_Battle_BattleBase.<>f__mg$cache177, null, true);
		string name87 = "Step";
		if (Lua_BlackJack_ProjectL_Battle_BattleBase.<>f__mg$cache178 == null)
		{
			Lua_BlackJack_ProjectL_Battle_BattleBase.<>f__mg$cache178 = new LuaCSFunction(Lua_BlackJack_ProjectL_Battle_BattleBase.get_Step);
		}
		LuaObject.addMember(l, name87, Lua_BlackJack_ProjectL_Battle_BattleBase.<>f__mg$cache178, null, true);
		string name88 = "Turn";
		if (Lua_BlackJack_ProjectL_Battle_BattleBase.<>f__mg$cache179 == null)
		{
			Lua_BlackJack_ProjectL_Battle_BattleBase.<>f__mg$cache179 = new LuaCSFunction(Lua_BlackJack_ProjectL_Battle_BattleBase.get_Turn);
		}
		LuaObject.addMember(l, name88, Lua_BlackJack_ProjectL_Battle_BattleBase.<>f__mg$cache179, null, true);
		string name89 = "TurnMax";
		if (Lua_BlackJack_ProjectL_Battle_BattleBase.<>f__mg$cache17A == null)
		{
			Lua_BlackJack_ProjectL_Battle_BattleBase.<>f__mg$cache17A = new LuaCSFunction(Lua_BlackJack_ProjectL_Battle_BattleBase.get_TurnMax);
		}
		LuaObject.addMember(l, name89, Lua_BlackJack_ProjectL_Battle_BattleBase.<>f__mg$cache17A, null, true);
		string name90 = "Map";
		if (Lua_BlackJack_ProjectL_Battle_BattleBase.<>f__mg$cache17B == null)
		{
			Lua_BlackJack_ProjectL_Battle_BattleBase.<>f__mg$cache17B = new LuaCSFunction(Lua_BlackJack_ProjectL_Battle_BattleBase.get_Map);
		}
		LuaObject.addMember(l, name90, Lua_BlackJack_ProjectL_Battle_BattleBase.<>f__mg$cache17B, null, true);
		string name91 = "Combat";
		if (Lua_BlackJack_ProjectL_Battle_BattleBase.<>f__mg$cache17C == null)
		{
			Lua_BlackJack_ProjectL_Battle_BattleBase.<>f__mg$cache17C = new LuaCSFunction(Lua_BlackJack_ProjectL_Battle_BattleBase.get_Combat);
		}
		LuaObject.addMember(l, name91, Lua_BlackJack_ProjectL_Battle_BattleBase.<>f__mg$cache17C, null, true);
		if (Lua_BlackJack_ProjectL_Battle_BattleBase.<>f__mg$cache17D == null)
		{
			Lua_BlackJack_ProjectL_Battle_BattleBase.<>f__mg$cache17D = new LuaCSFunction(Lua_BlackJack_ProjectL_Battle_BattleBase.constructor);
		}
		LuaObject.createTypeMetatable(l, Lua_BlackJack_ProjectL_Battle_BattleBase.<>f__mg$cache17D, typeof(BattleBase));
	}

	// Token: 0x0400D8ED RID: 55533
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache0;

	// Token: 0x0400D8EE RID: 55534
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1;

	// Token: 0x0400D8EF RID: 55535
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2;

	// Token: 0x0400D8F0 RID: 55536
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3;

	// Token: 0x0400D8F1 RID: 55537
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache4;

	// Token: 0x0400D8F2 RID: 55538
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache5;

	// Token: 0x0400D8F3 RID: 55539
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache6;

	// Token: 0x0400D8F4 RID: 55540
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache7;

	// Token: 0x0400D8F5 RID: 55541
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache8;

	// Token: 0x0400D8F6 RID: 55542
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache9;

	// Token: 0x0400D8F7 RID: 55543
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheA;

	// Token: 0x0400D8F8 RID: 55544
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheB;

	// Token: 0x0400D8F9 RID: 55545
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheC;

	// Token: 0x0400D8FA RID: 55546
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheD;

	// Token: 0x0400D8FB RID: 55547
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheE;

	// Token: 0x0400D8FC RID: 55548
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheF;

	// Token: 0x0400D8FD RID: 55549
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache10;

	// Token: 0x0400D8FE RID: 55550
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache11;

	// Token: 0x0400D8FF RID: 55551
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache12;

	// Token: 0x0400D900 RID: 55552
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache13;

	// Token: 0x0400D901 RID: 55553
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache14;

	// Token: 0x0400D902 RID: 55554
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache15;

	// Token: 0x0400D903 RID: 55555
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache16;

	// Token: 0x0400D904 RID: 55556
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache17;

	// Token: 0x0400D905 RID: 55557
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache18;

	// Token: 0x0400D906 RID: 55558
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache19;

	// Token: 0x0400D907 RID: 55559
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1A;

	// Token: 0x0400D908 RID: 55560
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1B;

	// Token: 0x0400D909 RID: 55561
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1C;

	// Token: 0x0400D90A RID: 55562
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1D;

	// Token: 0x0400D90B RID: 55563
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1E;

	// Token: 0x0400D90C RID: 55564
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1F;

	// Token: 0x0400D90D RID: 55565
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache20;

	// Token: 0x0400D90E RID: 55566
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache21;

	// Token: 0x0400D90F RID: 55567
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache22;

	// Token: 0x0400D910 RID: 55568
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache23;

	// Token: 0x0400D911 RID: 55569
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache24;

	// Token: 0x0400D912 RID: 55570
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache25;

	// Token: 0x0400D913 RID: 55571
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache26;

	// Token: 0x0400D914 RID: 55572
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache27;

	// Token: 0x0400D915 RID: 55573
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache28;

	// Token: 0x0400D916 RID: 55574
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache29;

	// Token: 0x0400D917 RID: 55575
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2A;

	// Token: 0x0400D918 RID: 55576
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2B;

	// Token: 0x0400D919 RID: 55577
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2C;

	// Token: 0x0400D91A RID: 55578
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2D;

	// Token: 0x0400D91B RID: 55579
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2E;

	// Token: 0x0400D91C RID: 55580
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2F;

	// Token: 0x0400D91D RID: 55581
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache30;

	// Token: 0x0400D91E RID: 55582
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache31;

	// Token: 0x0400D91F RID: 55583
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache32;

	// Token: 0x0400D920 RID: 55584
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache33;

	// Token: 0x0400D921 RID: 55585
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache34;

	// Token: 0x0400D922 RID: 55586
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache35;

	// Token: 0x0400D923 RID: 55587
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache36;

	// Token: 0x0400D924 RID: 55588
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache37;

	// Token: 0x0400D925 RID: 55589
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache38;

	// Token: 0x0400D926 RID: 55590
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache39;

	// Token: 0x0400D927 RID: 55591
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3A;

	// Token: 0x0400D928 RID: 55592
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3B;

	// Token: 0x0400D929 RID: 55593
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3C;

	// Token: 0x0400D92A RID: 55594
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3D;

	// Token: 0x0400D92B RID: 55595
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3E;

	// Token: 0x0400D92C RID: 55596
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3F;

	// Token: 0x0400D92D RID: 55597
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache40;

	// Token: 0x0400D92E RID: 55598
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache41;

	// Token: 0x0400D92F RID: 55599
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache42;

	// Token: 0x0400D930 RID: 55600
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache43;

	// Token: 0x0400D931 RID: 55601
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache44;

	// Token: 0x0400D932 RID: 55602
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache45;

	// Token: 0x0400D933 RID: 55603
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache46;

	// Token: 0x0400D934 RID: 55604
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache47;

	// Token: 0x0400D935 RID: 55605
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache48;

	// Token: 0x0400D936 RID: 55606
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache49;

	// Token: 0x0400D937 RID: 55607
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache4A;

	// Token: 0x0400D938 RID: 55608
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache4B;

	// Token: 0x0400D939 RID: 55609
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache4C;

	// Token: 0x0400D93A RID: 55610
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache4D;

	// Token: 0x0400D93B RID: 55611
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache4E;

	// Token: 0x0400D93C RID: 55612
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache4F;

	// Token: 0x0400D93D RID: 55613
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache50;

	// Token: 0x0400D93E RID: 55614
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache51;

	// Token: 0x0400D93F RID: 55615
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache52;

	// Token: 0x0400D940 RID: 55616
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache53;

	// Token: 0x0400D941 RID: 55617
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache54;

	// Token: 0x0400D942 RID: 55618
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache55;

	// Token: 0x0400D943 RID: 55619
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache56;

	// Token: 0x0400D944 RID: 55620
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache57;

	// Token: 0x0400D945 RID: 55621
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache58;

	// Token: 0x0400D946 RID: 55622
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache59;

	// Token: 0x0400D947 RID: 55623
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache5A;

	// Token: 0x0400D948 RID: 55624
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache5B;

	// Token: 0x0400D949 RID: 55625
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache5C;

	// Token: 0x0400D94A RID: 55626
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache5D;

	// Token: 0x0400D94B RID: 55627
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache5E;

	// Token: 0x0400D94C RID: 55628
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache5F;

	// Token: 0x0400D94D RID: 55629
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache60;

	// Token: 0x0400D94E RID: 55630
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache61;

	// Token: 0x0400D94F RID: 55631
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache62;

	// Token: 0x0400D950 RID: 55632
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache63;

	// Token: 0x0400D951 RID: 55633
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache64;

	// Token: 0x0400D952 RID: 55634
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache65;

	// Token: 0x0400D953 RID: 55635
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache66;

	// Token: 0x0400D954 RID: 55636
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache67;

	// Token: 0x0400D955 RID: 55637
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache68;

	// Token: 0x0400D956 RID: 55638
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache69;

	// Token: 0x0400D957 RID: 55639
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache6A;

	// Token: 0x0400D958 RID: 55640
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache6B;

	// Token: 0x0400D959 RID: 55641
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache6C;

	// Token: 0x0400D95A RID: 55642
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache6D;

	// Token: 0x0400D95B RID: 55643
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache6E;

	// Token: 0x0400D95C RID: 55644
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache6F;

	// Token: 0x0400D95D RID: 55645
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache70;

	// Token: 0x0400D95E RID: 55646
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache71;

	// Token: 0x0400D95F RID: 55647
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache72;

	// Token: 0x0400D960 RID: 55648
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache73;

	// Token: 0x0400D961 RID: 55649
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache74;

	// Token: 0x0400D962 RID: 55650
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache75;

	// Token: 0x0400D963 RID: 55651
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache76;

	// Token: 0x0400D964 RID: 55652
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache77;

	// Token: 0x0400D965 RID: 55653
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache78;

	// Token: 0x0400D966 RID: 55654
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache79;

	// Token: 0x0400D967 RID: 55655
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache7A;

	// Token: 0x0400D968 RID: 55656
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache7B;

	// Token: 0x0400D969 RID: 55657
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache7C;

	// Token: 0x0400D96A RID: 55658
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache7D;

	// Token: 0x0400D96B RID: 55659
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache7E;

	// Token: 0x0400D96C RID: 55660
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache7F;

	// Token: 0x0400D96D RID: 55661
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache80;

	// Token: 0x0400D96E RID: 55662
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache81;

	// Token: 0x0400D96F RID: 55663
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache82;

	// Token: 0x0400D970 RID: 55664
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache83;

	// Token: 0x0400D971 RID: 55665
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache84;

	// Token: 0x0400D972 RID: 55666
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache85;

	// Token: 0x0400D973 RID: 55667
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache86;

	// Token: 0x0400D974 RID: 55668
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache87;

	// Token: 0x0400D975 RID: 55669
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache88;

	// Token: 0x0400D976 RID: 55670
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache89;

	// Token: 0x0400D977 RID: 55671
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache8A;

	// Token: 0x0400D978 RID: 55672
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache8B;

	// Token: 0x0400D979 RID: 55673
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache8C;

	// Token: 0x0400D97A RID: 55674
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache8D;

	// Token: 0x0400D97B RID: 55675
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache8E;

	// Token: 0x0400D97C RID: 55676
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache8F;

	// Token: 0x0400D97D RID: 55677
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache90;

	// Token: 0x0400D97E RID: 55678
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache91;

	// Token: 0x0400D97F RID: 55679
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache92;

	// Token: 0x0400D980 RID: 55680
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache93;

	// Token: 0x0400D981 RID: 55681
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache94;

	// Token: 0x0400D982 RID: 55682
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache95;

	// Token: 0x0400D983 RID: 55683
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache96;

	// Token: 0x0400D984 RID: 55684
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache97;

	// Token: 0x0400D985 RID: 55685
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache98;

	// Token: 0x0400D986 RID: 55686
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache99;

	// Token: 0x0400D987 RID: 55687
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache9A;

	// Token: 0x0400D988 RID: 55688
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache9B;

	// Token: 0x0400D989 RID: 55689
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache9C;

	// Token: 0x0400D98A RID: 55690
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache9D;

	// Token: 0x0400D98B RID: 55691
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache9E;

	// Token: 0x0400D98C RID: 55692
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache9F;

	// Token: 0x0400D98D RID: 55693
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheA0;

	// Token: 0x0400D98E RID: 55694
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheA1;

	// Token: 0x0400D98F RID: 55695
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheA2;

	// Token: 0x0400D990 RID: 55696
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheA3;

	// Token: 0x0400D991 RID: 55697
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheA4;

	// Token: 0x0400D992 RID: 55698
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheA5;

	// Token: 0x0400D993 RID: 55699
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheA6;

	// Token: 0x0400D994 RID: 55700
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheA7;

	// Token: 0x0400D995 RID: 55701
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheA8;

	// Token: 0x0400D996 RID: 55702
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheA9;

	// Token: 0x0400D997 RID: 55703
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheAA;

	// Token: 0x0400D998 RID: 55704
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheAB;

	// Token: 0x0400D999 RID: 55705
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheAC;

	// Token: 0x0400D99A RID: 55706
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheAD;

	// Token: 0x0400D99B RID: 55707
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheAE;

	// Token: 0x0400D99C RID: 55708
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheAF;

	// Token: 0x0400D99D RID: 55709
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheB0;

	// Token: 0x0400D99E RID: 55710
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheB1;

	// Token: 0x0400D99F RID: 55711
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheB2;

	// Token: 0x0400D9A0 RID: 55712
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheB3;

	// Token: 0x0400D9A1 RID: 55713
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheB4;

	// Token: 0x0400D9A2 RID: 55714
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheB5;

	// Token: 0x0400D9A3 RID: 55715
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheB6;

	// Token: 0x0400D9A4 RID: 55716
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheB7;

	// Token: 0x0400D9A5 RID: 55717
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheB8;

	// Token: 0x0400D9A6 RID: 55718
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheB9;

	// Token: 0x0400D9A7 RID: 55719
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheBA;

	// Token: 0x0400D9A8 RID: 55720
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheBB;

	// Token: 0x0400D9A9 RID: 55721
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheBC;

	// Token: 0x0400D9AA RID: 55722
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheBD;

	// Token: 0x0400D9AB RID: 55723
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheBE;

	// Token: 0x0400D9AC RID: 55724
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheBF;

	// Token: 0x0400D9AD RID: 55725
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheC0;

	// Token: 0x0400D9AE RID: 55726
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheC1;

	// Token: 0x0400D9AF RID: 55727
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheC2;

	// Token: 0x0400D9B0 RID: 55728
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheC3;

	// Token: 0x0400D9B1 RID: 55729
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheC4;

	// Token: 0x0400D9B2 RID: 55730
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheC5;

	// Token: 0x0400D9B3 RID: 55731
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheC6;

	// Token: 0x0400D9B4 RID: 55732
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheC7;

	// Token: 0x0400D9B5 RID: 55733
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheC8;

	// Token: 0x0400D9B6 RID: 55734
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheC9;

	// Token: 0x0400D9B7 RID: 55735
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheCA;

	// Token: 0x0400D9B8 RID: 55736
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheCB;

	// Token: 0x0400D9B9 RID: 55737
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheCC;

	// Token: 0x0400D9BA RID: 55738
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheCD;

	// Token: 0x0400D9BB RID: 55739
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheCE;

	// Token: 0x0400D9BC RID: 55740
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheCF;

	// Token: 0x0400D9BD RID: 55741
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheD0;

	// Token: 0x0400D9BE RID: 55742
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheD1;

	// Token: 0x0400D9BF RID: 55743
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheD2;

	// Token: 0x0400D9C0 RID: 55744
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheD3;

	// Token: 0x0400D9C1 RID: 55745
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheD4;

	// Token: 0x0400D9C2 RID: 55746
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheD5;

	// Token: 0x0400D9C3 RID: 55747
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheD6;

	// Token: 0x0400D9C4 RID: 55748
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheD7;

	// Token: 0x0400D9C5 RID: 55749
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheD8;

	// Token: 0x0400D9C6 RID: 55750
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheD9;

	// Token: 0x0400D9C7 RID: 55751
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheDA;

	// Token: 0x0400D9C8 RID: 55752
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheDB;

	// Token: 0x0400D9C9 RID: 55753
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheDC;

	// Token: 0x0400D9CA RID: 55754
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheDD;

	// Token: 0x0400D9CB RID: 55755
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheDE;

	// Token: 0x0400D9CC RID: 55756
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheDF;

	// Token: 0x0400D9CD RID: 55757
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheE0;

	// Token: 0x0400D9CE RID: 55758
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheE1;

	// Token: 0x0400D9CF RID: 55759
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheE2;

	// Token: 0x0400D9D0 RID: 55760
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheE3;

	// Token: 0x0400D9D1 RID: 55761
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheE4;

	// Token: 0x0400D9D2 RID: 55762
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheE5;

	// Token: 0x0400D9D3 RID: 55763
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheE6;

	// Token: 0x0400D9D4 RID: 55764
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheE7;

	// Token: 0x0400D9D5 RID: 55765
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheE8;

	// Token: 0x0400D9D6 RID: 55766
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheE9;

	// Token: 0x0400D9D7 RID: 55767
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheEA;

	// Token: 0x0400D9D8 RID: 55768
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheEB;

	// Token: 0x0400D9D9 RID: 55769
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheEC;

	// Token: 0x0400D9DA RID: 55770
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheED;

	// Token: 0x0400D9DB RID: 55771
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheEE;

	// Token: 0x0400D9DC RID: 55772
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheEF;

	// Token: 0x0400D9DD RID: 55773
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheF0;

	// Token: 0x0400D9DE RID: 55774
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheF1;

	// Token: 0x0400D9DF RID: 55775
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheF2;

	// Token: 0x0400D9E0 RID: 55776
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheF3;

	// Token: 0x0400D9E1 RID: 55777
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheF4;

	// Token: 0x0400D9E2 RID: 55778
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheF5;

	// Token: 0x0400D9E3 RID: 55779
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheF6;

	// Token: 0x0400D9E4 RID: 55780
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheF7;

	// Token: 0x0400D9E5 RID: 55781
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheF8;

	// Token: 0x0400D9E6 RID: 55782
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheF9;

	// Token: 0x0400D9E7 RID: 55783
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheFA;

	// Token: 0x0400D9E8 RID: 55784
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheFB;

	// Token: 0x0400D9E9 RID: 55785
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheFC;

	// Token: 0x0400D9EA RID: 55786
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheFD;

	// Token: 0x0400D9EB RID: 55787
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheFE;

	// Token: 0x0400D9EC RID: 55788
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheFF;

	// Token: 0x0400D9ED RID: 55789
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache100;

	// Token: 0x0400D9EE RID: 55790
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache101;

	// Token: 0x0400D9EF RID: 55791
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache102;

	// Token: 0x0400D9F0 RID: 55792
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache103;

	// Token: 0x0400D9F1 RID: 55793
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache104;

	// Token: 0x0400D9F2 RID: 55794
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache105;

	// Token: 0x0400D9F3 RID: 55795
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache106;

	// Token: 0x0400D9F4 RID: 55796
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache107;

	// Token: 0x0400D9F5 RID: 55797
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache108;

	// Token: 0x0400D9F6 RID: 55798
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache109;

	// Token: 0x0400D9F7 RID: 55799
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache10A;

	// Token: 0x0400D9F8 RID: 55800
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache10B;

	// Token: 0x0400D9F9 RID: 55801
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache10C;

	// Token: 0x0400D9FA RID: 55802
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache10D;

	// Token: 0x0400D9FB RID: 55803
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache10E;

	// Token: 0x0400D9FC RID: 55804
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache10F;

	// Token: 0x0400D9FD RID: 55805
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache110;

	// Token: 0x0400D9FE RID: 55806
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache111;

	// Token: 0x0400D9FF RID: 55807
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache112;

	// Token: 0x0400DA00 RID: 55808
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache113;

	// Token: 0x0400DA01 RID: 55809
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache114;

	// Token: 0x0400DA02 RID: 55810
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache115;

	// Token: 0x0400DA03 RID: 55811
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache116;

	// Token: 0x0400DA04 RID: 55812
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache117;

	// Token: 0x0400DA05 RID: 55813
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache118;

	// Token: 0x0400DA06 RID: 55814
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache119;

	// Token: 0x0400DA07 RID: 55815
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache11A;

	// Token: 0x0400DA08 RID: 55816
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache11B;

	// Token: 0x0400DA09 RID: 55817
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache11C;

	// Token: 0x0400DA0A RID: 55818
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache11D;

	// Token: 0x0400DA0B RID: 55819
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache11E;

	// Token: 0x0400DA0C RID: 55820
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache11F;

	// Token: 0x0400DA0D RID: 55821
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache120;

	// Token: 0x0400DA0E RID: 55822
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache121;

	// Token: 0x0400DA0F RID: 55823
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache122;

	// Token: 0x0400DA10 RID: 55824
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache123;

	// Token: 0x0400DA11 RID: 55825
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache124;

	// Token: 0x0400DA12 RID: 55826
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache125;

	// Token: 0x0400DA13 RID: 55827
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache126;

	// Token: 0x0400DA14 RID: 55828
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache127;

	// Token: 0x0400DA15 RID: 55829
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache128;

	// Token: 0x0400DA16 RID: 55830
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache129;

	// Token: 0x0400DA17 RID: 55831
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache12A;

	// Token: 0x0400DA18 RID: 55832
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache12B;

	// Token: 0x0400DA19 RID: 55833
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache12C;

	// Token: 0x0400DA1A RID: 55834
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache12D;

	// Token: 0x0400DA1B RID: 55835
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache12E;

	// Token: 0x0400DA1C RID: 55836
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache12F;

	// Token: 0x0400DA1D RID: 55837
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache130;

	// Token: 0x0400DA1E RID: 55838
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache131;

	// Token: 0x0400DA1F RID: 55839
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache132;

	// Token: 0x0400DA20 RID: 55840
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache133;

	// Token: 0x0400DA21 RID: 55841
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache134;

	// Token: 0x0400DA22 RID: 55842
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache135;

	// Token: 0x0400DA23 RID: 55843
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache136;

	// Token: 0x0400DA24 RID: 55844
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache137;

	// Token: 0x0400DA25 RID: 55845
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache138;

	// Token: 0x0400DA26 RID: 55846
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache139;

	// Token: 0x0400DA27 RID: 55847
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache13A;

	// Token: 0x0400DA28 RID: 55848
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache13B;

	// Token: 0x0400DA29 RID: 55849
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache13C;

	// Token: 0x0400DA2A RID: 55850
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache13D;

	// Token: 0x0400DA2B RID: 55851
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache13E;

	// Token: 0x0400DA2C RID: 55852
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache13F;

	// Token: 0x0400DA2D RID: 55853
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache140;

	// Token: 0x0400DA2E RID: 55854
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache141;

	// Token: 0x0400DA2F RID: 55855
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache142;

	// Token: 0x0400DA30 RID: 55856
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache143;

	// Token: 0x0400DA31 RID: 55857
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache144;

	// Token: 0x0400DA32 RID: 55858
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache145;

	// Token: 0x0400DA33 RID: 55859
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache146;

	// Token: 0x0400DA34 RID: 55860
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache147;

	// Token: 0x0400DA35 RID: 55861
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache148;

	// Token: 0x0400DA36 RID: 55862
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache149;

	// Token: 0x0400DA37 RID: 55863
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache14A;

	// Token: 0x0400DA38 RID: 55864
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache14B;

	// Token: 0x0400DA39 RID: 55865
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache14C;

	// Token: 0x0400DA3A RID: 55866
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache14D;

	// Token: 0x0400DA3B RID: 55867
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache14E;

	// Token: 0x0400DA3C RID: 55868
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache14F;

	// Token: 0x0400DA3D RID: 55869
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache150;

	// Token: 0x0400DA3E RID: 55870
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache151;

	// Token: 0x0400DA3F RID: 55871
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache152;

	// Token: 0x0400DA40 RID: 55872
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache153;

	// Token: 0x0400DA41 RID: 55873
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache154;

	// Token: 0x0400DA42 RID: 55874
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache155;

	// Token: 0x0400DA43 RID: 55875
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache156;

	// Token: 0x0400DA44 RID: 55876
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache157;

	// Token: 0x0400DA45 RID: 55877
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache158;

	// Token: 0x0400DA46 RID: 55878
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache159;

	// Token: 0x0400DA47 RID: 55879
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache15A;

	// Token: 0x0400DA48 RID: 55880
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache15B;

	// Token: 0x0400DA49 RID: 55881
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache15C;

	// Token: 0x0400DA4A RID: 55882
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache15D;

	// Token: 0x0400DA4B RID: 55883
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache15E;

	// Token: 0x0400DA4C RID: 55884
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache15F;

	// Token: 0x0400DA4D RID: 55885
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache160;

	// Token: 0x0400DA4E RID: 55886
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache161;

	// Token: 0x0400DA4F RID: 55887
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache162;

	// Token: 0x0400DA50 RID: 55888
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache163;

	// Token: 0x0400DA51 RID: 55889
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache164;

	// Token: 0x0400DA52 RID: 55890
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache165;

	// Token: 0x0400DA53 RID: 55891
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache166;

	// Token: 0x0400DA54 RID: 55892
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache167;

	// Token: 0x0400DA55 RID: 55893
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache168;

	// Token: 0x0400DA56 RID: 55894
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache169;

	// Token: 0x0400DA57 RID: 55895
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache16A;

	// Token: 0x0400DA58 RID: 55896
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache16B;

	// Token: 0x0400DA59 RID: 55897
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache16C;

	// Token: 0x0400DA5A RID: 55898
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache16D;

	// Token: 0x0400DA5B RID: 55899
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache16E;

	// Token: 0x0400DA5C RID: 55900
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache16F;

	// Token: 0x0400DA5D RID: 55901
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache170;

	// Token: 0x0400DA5E RID: 55902
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache171;

	// Token: 0x0400DA5F RID: 55903
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache172;

	// Token: 0x0400DA60 RID: 55904
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache173;

	// Token: 0x0400DA61 RID: 55905
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache174;

	// Token: 0x0400DA62 RID: 55906
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache175;

	// Token: 0x0400DA63 RID: 55907
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache176;

	// Token: 0x0400DA64 RID: 55908
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache177;

	// Token: 0x0400DA65 RID: 55909
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache178;

	// Token: 0x0400DA66 RID: 55910
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache179;

	// Token: 0x0400DA67 RID: 55911
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache17A;

	// Token: 0x0400DA68 RID: 55912
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache17B;

	// Token: 0x0400DA69 RID: 55913
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache17C;

	// Token: 0x0400DA6A RID: 55914
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache17D;
}
